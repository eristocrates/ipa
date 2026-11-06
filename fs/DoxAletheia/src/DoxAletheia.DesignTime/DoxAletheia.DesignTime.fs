namespace DoxAletheia.DesignTime

open System
open System.IO
open System.Linq
open System.Web.Services.Description
open System.Reflection
open System.Text.RegularExpressions
open System.Collections.Concurrent
open VDS.Common.Tries
open Microsoft.FSharp.Core.CompilerServices
open Microsoft.FSharp.Quotations
open ProviderImplementation.ProvidedTypes
open System.Xml.Linq
open VDS.RDF
open VDS.RDF.Ontology
open DoxAletheia.Runtime
open DoxAletheia.Runtime.Iana
open AngleSharp
open FSharp.Data
open Microsoft.FSharp.Reflection
open AngleSharp.Html.Parser
open AngleSharp.Xhtml
open Nager.PublicSuffix
open Nager.PublicSuffix.Models
open Nager.PublicSuffix.RuleParsers
open SmartWsdlKit
open FolkerKinzel.MimeTypes
open AngleSharp.Html
open IriTools
open TypeShape.Core
open NuGet.Common
open NuGet.Protocol
open NuGet.Protocol.Core.Types
open NuGet.Protocol.Resources
open FSharpPlus
open DynamicObj
module FSharpLiteral = FSharp.Literals.Literal

type CodeProvision = 

    static member inline staticProperty<'ValueType> ((propertyName:string), (propertyType:Type), (value:'ValueType))
        =

        match CodeQuotation<'ValueType>.lift value with

        | DirectQuote expression ->

            ProvidedProperty(
                propertyName = propertyName,
                propertyType = propertyType,
                isStatic = true,
                getterCode = fun _ ->
                    expression :> Expr
            )

        | IndirectQuote projection ->

            ProvidedProperty(
                propertyName = propertyName,
                propertyType = typeof<obj>,
                isStatic = true,
                getterCode = fun _ ->
                    Expr.Coerce(
                        projection.projectionExpression,
                        typeof<obj>
                    )
            )

    static member inline staticProperty<'ValueType>  ((propertyName:string), (value:'ValueType)) = CodeProvision.staticProperty(propertyName, typeof<'ValueType>, value)

    static member inline staticProperty<'ValueType>  (propertyName:string) = 
        fun (value:'ValueType) -> CodeProvision.staticProperty<'ValueType>(propertyName,  value)
    static member inline staticProperty<'ValueType>  (propertyType:Type) = 
        fun (propertyName:string) -> 
            fun (value:'ValueType) ->  CodeProvision.staticProperty<'ValueType>(propertyName, propertyType, value)
    static member inline erasedType<'ValueType>(className:string) = ProvidedTypeDefinition(className, Some typeof<'ValueType>, isErased = true)
    static member  erasedType<'ValueType>() = CodeProvision.erasedType typeof<'ValueType>.fsharpName
    static member inline erasedType(className:string, baseType:Type) = ProvidedTypeDefinition(className, Some baseType, isErased = true)
    static member inline erasedType(baseType:Type) =
        fun (className:string) -> CodeProvision.erasedType(className, baseType)
    static member  erasedType(className:string) =
        fun (baseType:Type) -> CodeProvision.erasedType(className, baseType)
module CodeProvision =

    type ProvidedTypeDefinition with

        member this.addProjectionMembers<'ValueType>
            (projection : Projection<'ValueType>)
            : unit
            =

            let addMember
                (projectionSource : 'SourceType)
                (memberShape : IShapeReadOnlyMember<'SourceType>)
                : unit
                =

                if Projection<'SourceType>.usableMember memberShape then

                    memberShape.Accept {
                        new IReadOnlyMemberVisitor<'SourceType, bool> with

                            member _.Visit<'MemberType>
                                (memberShape : ReadOnlyMember<'SourceType, 'MemberType>)
                                =

                                let memberValue : 'MemberType =
                                    memberShape.Get projectionSource

                                match CodeQuotation<'MemberType>.lift memberValue with

                                | DirectQuote expression ->

                                    this.AddMember(
                                        ProvidedProperty(
                                            propertyName = memberShape.Label,
                                            propertyType = typeof<'MemberType>,
                                            isStatic = false,
                                            getterCode =
                                                fun _ ->
                                                    expression :> Expr
                                        )
                                    )

                                | IndirectQuote memberProjection ->

                                    let ProjectionTypeDefinition =
                                        ProvidedTypeDefinition(
                                            memberShape.Label + "'Projection",
                                            Some typeof<obj>,
                                            isErased = true
                                        )

                                    ProjectionTypeDefinition.addProjectionMembers
                                        memberProjection

                                    this.AddMember
                                        ProjectionTypeDefinition

                                    this.AddMember(
                                        this.projectionProperty(
                                            memberShape.Label,
                                            ProjectionTypeDefinition,
                                            memberProjection,
                                            false
                                        )
                                    )

                                true
                    }
                    |> ignore

            match projection with

            | NullProjection _ ->

                ()

            | RecordProjection recordProjection ->

                recordProjection.Access {
                    new RecordAccessor<bool> with

                        member _.Access<'RecordType, 'Fields>
                            (projectedRecord : ProjectedRecord<'RecordType, 'Fields>)
                            =

                            match shapeof<'RecordType> with

                            | Shape.FSharpRecord
                                (:? ShapeFSharpRecord<'RecordType> as recordShape) ->

                                recordShape.Fields
                                |> Array.map (fun field ->
                                    field :> IShapeReadOnlyMember<'RecordType>
                                )
                                |> Array.iter (
                                    addMember projectedRecord.source
                                )

                            | _ ->

                                invalidOp
                                    $"Expected {typeof<'RecordType>.FullName} to be an F# record."

                            true
                }
                |> ignore

            | PocoProjection pocoProjection ->

                pocoProjection.Access {
                    new PocoAccessor<bool> with

                        member _.Access<'SourceType>
                            (projectedPoco : ProjectedPoco<'SourceType>)
                            =

                            projectedPoco.members
                            |> Array.iter (
                                addMember projectedPoco.source
                            )

                            true
                }
                |> ignore

            | TupleProjection tupleProjection ->

                tupleProjection.Access {
                    new TupleAccessor<bool> with

                        member _.Access<'TupleType, 'Fields>
                            (projectedTuple : ProjectedTuple<'TupleType, 'Fields>)
                            =

                            match shapeof<'TupleType> with

                            | Shape.Tuple
                                (:? ShapeTuple<'TupleType> as tupleShape) ->

                                tupleShape.Elements
                                |> Array.map (fun element ->
                                    element :> IShapeReadOnlyMember<'TupleType>
                                )
                                |> Array.iter (
                                    addMember projectedTuple.source
                                )

                            | _ ->

                                invalidOp
                                    $"Expected {typeof<'TupleType>.FullName} to be a tuple."

                            true
                }
                |> ignore

            | UnionProjection unionProjection ->

                unionProjection.Access {
                    new UnionAccessor<bool> with

                        member _.Access<'UnionType, 'Cases>
                            (projectedUnion : ProjectedUnion<'UnionType, 'Cases>)
                            =

                            match shapeof<'UnionType> with

                            | Shape.FSharpUnion
                                (:? ShapeFSharpUnion<'UnionType> as unionShape) ->

                                let caseIndex =
                                    unionShape.GetTag projectedUnion.source

                                let activeCase =
                                    unionShape.UnionCases.[caseIndex]

                                this.AddMember(
                                    ProvidedProperty(
                                        propertyName = "Case",
                                        propertyType = typeof<string>,
                                        isStatic = false,
                                        getterCode =
                                            fun _ ->
                                                Expr.Value activeCase.CaseInfo.Name
                                    )
                                )

                                activeCase.Fields
                                |> Array.map (fun field ->
                                    field :> IShapeReadOnlyMember<'UnionType>
                                )
                                |> Array.iter (
                                    addMember projectedUnion.source
                                )

                            | _ ->

                                invalidOp
                                    $"Expected {typeof<'UnionType>.FullName} to be an F# union."

                            true
                }
                |> ignore

            | EnumerableProjection enumerableProjection ->

                enumerableProjection.Access {
                    new EnumerableAccessor<bool> with

                        member _.Access<'Enumerable, 'Element when 'Enumerable :> seq<'Element>>
                            (projectedEnumerable : ProjectedEnumerable<'Enumerable, 'Element>)
                            =

                            projectedEnumerable.enumerableValue
                            |> Seq.iteri (fun index element ->

                                let propertyName =
                                    $"Item{index}"

                                match CodeQuotation<'Element>.lift element with

                                | DirectQuote expression ->

                                    this.AddMember(
                                        ProvidedProperty(
                                            propertyName = propertyName,
                                            propertyType = typeof<'Element>,
                                            isStatic = false,
                                            getterCode =
                                                fun _ ->
                                                    expression :> Expr
                                        )
                                    )

                                | IndirectQuote elementProjection ->

                                    let ProjectionTypeDefinition =
                                        ProvidedTypeDefinition(
                                            propertyName + "'Projection",
                                            Some typeof<obj>,
                                            isErased = true
                                        )

                                    ProjectionTypeDefinition.addProjectionMembers
                                        elementProjection

                                    this.AddMember
                                        ProjectionTypeDefinition

                                    this.AddMember(
                                        this.projectionProperty(
                                            propertyName,
                                            ProjectionTypeDefinition,
                                            elementProjection,
                                            false
                                        )
                                    )
                            )

                            true
                }
                |> ignore

            | RuntimeProjection projectionSource ->

                TypeShape.FromValue(box projectionSource).Accept {
                    new ITypeVisitor<bool> with

                        member _.Visit<'RuntimeType>() =

                            let runtimeValue : 'RuntimeType =
                                projectionSource
                                |> box
                                |> unbox<'RuntimeType>

                            let runtimeProjection : Projection<'RuntimeType> =
                                Projection<'RuntimeType>.ofValue runtimeValue

                            this.addProjectionMembers
                                runtimeProjection

                            true
                }
                |> ignore

        // ---------------------------------------------------------------------
        // Property whose value is represented by an indirect projection.
        // ---------------------------------------------------------------------

        member this.projectionProperty<'ValueType>
            (
                propertyName : string,
                propertyType : Type,
                projection : Projection<'ValueType>,
                isStatic : bool
            )
            : ProvidedProperty
            =

            ProvidedProperty(
                propertyName = propertyName,
                propertyType = propertyType,
                isStatic = isStatic,
                getterCode =
                    fun _ ->
                        Expr.Coerce(
                            projection.projectionExpression,
                            typeof<obj>
                        )
            )

        member inline this.projectionProperty<'ValueType>
            (
                propertyName : string,
                propertyType : Type,
                projection : Projection<'ValueType>
            )
            : ProvidedProperty
            =

            this.projectionProperty(
                propertyName,
                propertyType,
                projection,
                true
            )

        // ---------------------------------------------------------------------
        // Static property
        // ---------------------------------------------------------------------

        member inline this.staticProperty<'ValueType>
            (
                propertyName : string,
                propertyType : Type,
                value : 'ValueType
            )
            : unit
            =

            match CodeQuotation<'ValueType>.lift value with

            | DirectQuote expression ->

                this.AddMember(
                    ProvidedProperty(
                        propertyName = propertyName,
                        propertyType = propertyType,
                        isStatic = true,
                        getterCode =
                            fun _ ->
                                expression :> Expr
                    )
                )

            | IndirectQuote projection ->

                let ProjectionTypeDefinition =
                    ProvidedTypeDefinition(
                        propertyName + "'Projection",
                        Some typeof<obj>,
                        isErased = true
                    )

                ProjectionTypeDefinition.addProjectionMembers
                    projection

                this.AddMember
                    ProjectionTypeDefinition

                this.AddMember(
                    this.projectionProperty(
                        propertyName,
                        ProjectionTypeDefinition,
                        projection
                    )
                )

        member inline this.staticProperty<'ValueType>
            (
                propertyName : string,
                value : 'ValueType
            )
            : unit
            =

            this.staticProperty(
                propertyName,
                typeof<'ValueType>,
                value
            )

        member inline this.staticProperty<'ValueType>
            (propertyName : string)
            =

            fun (value : 'ValueType) ->

                this.staticProperty(
                    propertyName,
                    typeof<'ValueType>,
                    value
                )

        member inline this.staticProperty<'ValueType>
            (propertyType : Type)
            =

            fun (propertyName : string) ->
                fun (value : 'ValueType) ->

                    this.staticProperty(
                        propertyName,
                        propertyType,
                        value
                    )
    let providedMemberAccessor =
        {
            new PocoAccessor<MemberInfo array> with

                member _.Access<'SourceType>
                    (projectedPoco : ProjectedPoco<'SourceType>)
                    =

                    let source : 'SourceType =
                        projectedPoco.source

                    projectedPoco.members
                    |> Array.collect (fun memberShape ->

                        memberShape.Accept {
                            new IReadOnlyMemberVisitor<'SourceType, MemberInfo array> with

                                member _.Visit<'MemberType>
                                    (memberShape : ReadOnlyMember<'SourceType, 'MemberType>)
                                    =

                                    let memberValue : 'MemberType =
                                        memberShape.Get source

                                    match CodeQuotation<'MemberType>.lift memberValue with

                                    | DirectQuote expression ->

                                        let property =
                                            ProvidedProperty(
                                                propertyName = memberShape.Label,
                                                propertyType = typeof<'MemberType>,
                                                isStatic = false,
                                                getterCode =
                                                    fun _ ->
                                                        expression :> Expr
                                            )

                                        [|
                                            property :> MemberInfo
                                        |]

                                    | IndirectQuote memberProjection ->

                                        let projectionType =
                                            ProvidedTypeDefinition(
                                                memberShape.Label + "'Projection",
                                                Some typeof<obj>,
                                                isErased = true
                                            )

                                        projectionType.addProjectionMembers
                                            memberProjection

                                        let property =
                                            ProvidedProperty(
                                                propertyName = memberShape.Label,
                                                propertyType = projectionType,
                                                isStatic = false,
                                                getterCode =
                                                    fun _ ->
                                                        Expr.Coerce(
                                                            memberProjection.projectionExpression,
                                                            typeof<obj>
                                                        )
                                            )

                                        [|
                                            projectionType :> MemberInfo
                                            property :> MemberInfo
                                        |]
                        }
                    )
        }
open CodeProvision

type private VocabularyOntologyMetadata(vocabulary: RdfVocabulary, ontologyGraph: OntologyGraph) =

    let _classes = lazy (vocabulary.ClassMap ontologyGraph)
    let _properties = lazy (vocabulary.PropertyMap ontologyGraph)
    let _individuals =
        lazy (
            ontologyGraph.InstanceMap
            |> Map.toSeq
            |> Seq.choose (fun (iri, ontologyInstance) ->
                match iri.tryPrefixedName vocabulary with
                | Some prefixedName -> Some(prefixedName, iri, ontologyInstance)
                | None -> None)
            |> Seq.toArray
        )
    let _owlClasses = lazy (vocabulary.OwlClassMap ontologyGraph)
    let _owlObjectProperties = lazy (vocabulary.OwlObjectPropertyMap ontologyGraph)
    let _owlDataProperties = lazy (vocabulary.OwlDatatypePropertyMap ontologyGraph)
    let _owlAnnotationProperties = lazy (vocabulary.OwlAnnotationPropertyMap ontologyGraph)

    member _.vocabulary = vocabulary
    member _.classes = _classes.Value
    member _.properties = _properties.Value
    member _.individuals = _individuals.Value
    member _.owlClasses = _owlClasses.Value
    member _.owlObjectProperties = _owlObjectProperties.Value
    member _.owlDataProperties = _owlDataProperties.Value
    member _.owlAnnotationProperties = _owlAnnotationProperties.Value

module private VocabularyOntologyIndex =

    let private cache =
        ConcurrentDictionary<string * string * string, Lazy<VocabularyOntologyMetadata>>()

    let get (namespacePrefix: string) (namespaceIriString: string) (documentIrisString: string) =
        // Prefixes are case-sensitive. Do not lowercase the cache key.
        let key = (namespacePrefix, namespaceIriString, documentIrisString)

        cache.GetOrAdd(
            key,
            fun (prefix, namespaceIri, documentIrisText) ->
                lazy (
                    let documentIris =
                        documentIrisText.Split(' ', StringSplitOptions.RemoveEmptyEntries ||| StringSplitOptions.TrimEntries)
                        |> Array.map Uri
                        |> Array.map Iri.ofUri
                        |> Array.toList

                    let vocabulary =
                        { RdfVocabulary.PREFIX(prefix, namespaceIri) with
                            documentIris = documentIris }

                    VocabularyOntologyMetadata(vocabulary, OntologyGraph.ofRdfVocabulary vocabulary)
                )
        ).Value

module private VocabularyXmlDocumentation =

    let ofResource (fallbackName: string) (identity: string) (resource: OntologyResource) =
        let labels =
            resource.Label
            |> Seq.filter (fun label -> not (String.IsNullOrWhiteSpace label.Value))
            |> Seq.toArray

        let comments =
            resource.Comment
            |> Seq.filter (fun comment -> not (String.IsNullOrWhiteSpace comment.Value))
            |> Seq.toArray

        let isEnglish (language: string) =
            not (String.IsNullOrWhiteSpace language)
            && (language.Equals("en", StringComparison.OrdinalIgnoreCase)
                || language.StartsWith("en-", StringComparison.OrdinalIgnoreCase))

        let primaryLabel =
            labels
            |> Array.tryFind (fun label -> isEnglish label.Language)
            |> Option.orElseWith (fun () -> labels |> Array.tryHead)
            |> Option.map _.Value
            |> Option.defaultValue fallbackName

        let xmlElement name (value: string) =
            System.Xml.Linq.XElement(System.Xml.Linq.XName.Get name, value)

        let summary = xmlElement "summary" primaryLabel
        let remarks = System.Xml.Linq.XElement(System.Xml.Linq.XName.Get "remarks")

        let languageSuffix (language: string) =
            if String.IsNullOrWhiteSpace language then "" else $" [{language}]"

        for label in labels do
            if label.Value <> primaryLabel then
                remarks.Add(xmlElement "para" $"Label{languageSuffix label.Language}: {label.Value}")

        for comment in comments do
            remarks.Add(xmlElement "para" $"{comment.Value}{languageSuffix comment.Language}")

        remarks.Add(xmlElement "para" $"IRI: {identity}")

        [ summary.ToString(System.Xml.Linq.SaveOptions.DisableFormatting)
          remarks.ToString(System.Xml.Linq.SaveOptions.DisableFormatting) ]
        |> String.concat "\n"

    let forPrefixedName (prefixedName: PrefixedName) (resource: OntologyResource) =
        ofResource prefixedName.localName prefixedName.identity resource

    let attachProperty (prefixedName: PrefixedName) (resource: OntologyResource) (property: ProvidedProperty) =
        property.AddXmlDocDelayed(fun () -> forPrefixedName prefixedName resource)
        property

[<TypeProvider>]
type VocabularyProvider(config: TypeProviderConfig) as this =

    inherit
        TypeProviderForNamespaces(
            config,
            assemblyReplacementMap = [ ("DoxAletheia.DesignTime", "DoxAletheia.Runtime") ],
            addDefaultProbingLocation = true
        )

    let providedNamespace = "DoxAletheia"
    let assembly = Assembly.GetExecutingAssembly()

    let createType (typeName: string) (namespacePrefix: string)(namespaceName: string) (documentIrisString: string) =
        let ontologyMetadata = VocabularyOntologyIndex.get namespacePrefix namespaceName documentIrisString
        let vocabulary = ontologyMetadata.vocabulary
        let shouldLabelName =
            match namespaceName with
            | obo when obo.Contains("obolibrary") -> true
            | _ -> false

        let classes = ontologyMetadata.classes
        let properties = ontologyMetadata.properties
        let individuals = ontologyMetadata.individuals
        let owlClasses = ontologyMetadata.owlClasses
        let owlObjectProperties = ontologyMetadata.owlObjectProperties
        let owlDataProperties = ontologyMetadata.owlDataProperties
        let owlAnnotationProperties = ontologyMetadata.owlAnnotationProperties

        let RdfClassTypeDefinition = "RdfClass" |> CodeProvision.erasedType typeof<Iri>
        let RdfPropertyTypeDefinition = "RdfProperty" |> CodeProvision.erasedType typeof<NormativePredicate>
        let OwlClassTypeDefinition = "OwlClass" |> CodeProvision.erasedType typeof<Class>
        let OwlObjectPropertyTypeDefinition = "OwlObjectProperty" |> CodeProvision.erasedType typeof<ObjectProperty>
        let OwlDataPropertyTypeDefinition = "OwlDataProperty" |> CodeProvision.erasedType typeof<DataProperty>
        let OwlAnnotationPropertyTypeDefinition = "OwlAnnotationProperty" |> CodeProvision.erasedType typeof<AnnotationProperty>
        let NamedIndividualTypeDefinition = "NamedIndividual\'" |> CodeProvision.erasedType typeof<obj>
        let AnonymousIndividualTypeDefinition = "AnonymousIndividual\'" |> CodeProvision.erasedType typeof<obj>
        let NamedIndividualOfClassTypeDefinition =
            "OfClass"
            |> CodeProvision.erasedType typeof<obj>

        let AnonymousIndividualOfClassTypeDefinition =
            "OfClass"
            |> CodeProvision.erasedType typeof<obj>

        let VocabularyTypeDefinition =
            ProvidedTypeDefinition(assembly, providedNamespace, typeName, Some typeof<obj>, isErased = true)

        VocabularyTypeDefinition.AddMembersDelayed(fun () ->
            [ RdfClassTypeDefinition
              RdfPropertyTypeDefinition
              AnonymousIndividualTypeDefinition
              NamedIndividualTypeDefinition
              OwlClassTypeDefinition
              OwlObjectPropertyTypeDefinition
              OwlDataPropertyTypeDefinition
              OwlAnnotationPropertyTypeDefinition ])

        VocabularyTypeDefinition.AddMember(vocabulary |> CodeProvision.staticProperty "vocabulary\'")

        VocabularyTypeDefinition.AddMembersDelayed(fun () ->
            [
                for prefixedName, ontologyProperty in properties |> Map.toSeq do
                    match
                        owlObjectProperties.TryFind prefixedName,
                        owlDataProperties.TryFind prefixedName,
                        owlAnnotationProperties.TryFind prefixedName
                    with
                    | Some objectProperty, None, None ->
                        yield ObjectPropertyIri(PrefixedName prefixedName)
                              |> CodeProvision.staticProperty OwlObjectPropertyTypeDefinition prefixedName.localName
                              |> VocabularyXmlDocumentation.attachProperty prefixedName ontologyProperty
                        // TODO next rewrite the rest of these cases
                    | None, Some dataProperty, None ->
                        yield DataPropertyIri(PrefixedName prefixedName)
                              |> CodeProvision.staticProperty OwlDataPropertyTypeDefinition prefixedName.localName
                              |> VocabularyXmlDocumentation.attachProperty prefixedName ontologyProperty
                    | None, None, Some annotationProperty ->
                        yield AnnotationPropertyIri(PrefixedName prefixedName)
                              |> CodeProvision.staticProperty OwlAnnotationPropertyTypeDefinition prefixedName.localName
                              |> VocabularyXmlDocumentation.attachProperty prefixedName ontologyProperty
                    | _, _, _ ->
                        yield IriPredicate(PrefixedName prefixedName)
                              |> CodeProvision.staticProperty prefixedName.localName
                              |> VocabularyXmlDocumentation.attachProperty prefixedName ontologyProperty
            ]
        )

        NamedIndividualTypeDefinition.AddMember NamedIndividualOfClassTypeDefinition

        NamedIndividualTypeDefinition.AddMembersDelayed(fun () ->
            [
                for prefixedName, iri, ontologyInstance in individuals do
                    yield
                        NamedIndividualIri iri
                        |> CodeProvision.staticProperty prefixedName.localName
                        |> VocabularyXmlDocumentation.attachProperty prefixedName ontologyInstance
            ])

        for KeyValue(prefixedName, ontologyClass) in classes do
            let providedName =
                match shouldLabelName, ontologyClass.Label with
                | true, labels when labels.Count() > 0 ->
                    match labels |> Seq.tryFind (fun label -> label.Language.Contains("en")) with
                    | Some englishLabel -> $"{englishLabel.Value}'{prefixedName.localName}"
                    | None ->
                        let label = labels |> Seq.head |> _.Value
                        $"{label}'{prefixedName.localName}"
                | _, _ -> prefixedName.localName

            let TermTypeDefinition = providedName |> CodeProvision.erasedType typeof<NamedIndividual>

            TermTypeDefinition.AddXmlDocDelayed(fun () ->
                VocabularyXmlDocumentation.forPrefixedName prefixedName ontologyClass)

            NamedIndividualOfClassTypeDefinition.AddMember TermTypeDefinition

            NamedIndividualTypeDefinition.AddMemberDelayed(fun () ->
                let methodDefinition = ProvidedMethod(
                    methodName = providedName,
                    parameters = [ ProvidedParameter("iri", typeof<Iri>) ],
                    returnType = TermTypeDefinition,
                    isStatic = true,
                    invokeCode =
                        fun args ->
                            let iri = Expr.Coerce(args[0], typeof<Iri>)

                            <@@ NamedIndividualIri (%%iri : Iri) @@>
                )
                methodDefinition.AddXmlDocDelayed(fun () ->
                    VocabularyXmlDocumentation.forPrefixedName prefixedName ontologyClass)
                methodDefinition)

            TermTypeDefinition.AddMember(
                ProvidedProperty(
                    propertyName = "Individual",
                    propertyType = typeof<Individual>,
                    isStatic = false,
                    getterCode =
                        fun arguments ->
                            let namedIndividual = Expr.Coerce(arguments[0], typeof<NamedIndividual>)
                            <@@ Individual(%%namedIndividual: NamedIndividual) @@>
                )
            )

        AnonymousIndividualTypeDefinition.AddMember AnonymousIndividualOfClassTypeDefinition

        for KeyValue(prefixedName, ontologyClass) in classes do

            let providedName =
                match shouldLabelName, ontologyClass.Label with
                | true, labels when labels.Count() > 0 ->
                    match labels |> Seq.tryFind (fun label -> label.Language.Contains("en")) with
                    | Some englishLabel -> $"{englishLabel.Value}'{prefixedName.localName}"
                    | None ->
                        let label = labels |> Seq.head |> _.Value
                        $"{label}'{prefixedName.localName}"
                | _, _ -> prefixedName.localName

            let TermTypeDefinition = providedName |> CodeProvision.erasedType typeof<AnonymousIndividual>

            TermTypeDefinition.AddXmlDocDelayed(fun () ->
                VocabularyXmlDocumentation.forPrefixedName prefixedName ontologyClass)

            AnonymousIndividualOfClassTypeDefinition.AddMember TermTypeDefinition

            AnonymousIndividualTypeDefinition.AddMemberDelayed(fun () ->
                let methodDefinition = ProvidedMethod(
                    methodName = providedName,
                    parameters = [ ProvidedParameter("bnode", typeof<BNode>) ],
                    returnType = TermTypeDefinition,
                    isStatic = true,
                    invokeCode =
                        fun args ->
                            let bnode = Expr.Coerce(args[0], typeof<BNode>)
                            <@@ AnonymousIndividualBNode(%%bnode: BNode) @@>
                )
                methodDefinition.AddXmlDocDelayed(fun () ->
                    VocabularyXmlDocumentation.forPrefixedName prefixedName ontologyClass)
                methodDefinition)

            TermTypeDefinition.AddMember(
                ProvidedProperty(
                    propertyName = "Individual",
                    propertyType = typeof<Individual>,
                    isStatic = false,
                    getterCode =
                        fun arguments ->
                            let anonymousIndividual = Expr.Coerce(arguments[0], typeof<AnonymousIndividual>)
                            <@@ AnonymousIndividual(%%anonymousIndividual: AnonymousIndividual) @@>
                )
            )

            // Defer superclass/domain traversal and method construction until this type is expanded.
            TermTypeDefinition.AddMembersDelayed(fun () ->
                ontologyClass.Properties
                |> Seq.collect (fun ontologyProperty ->
                    match ontologyProperty.tryLocalPart, ontologyProperty.tryUriNode with
                    | Some propertyName, Some propertyNode ->
                        let identity = Expr.Value(propertyNode.Uri.OriginalString, typeof<string>)

                        [
                            ProvidedMethod(
                                methodName = propertyName,
                                parameters = [ ProvidedParameter("object", typeof<NormativeObject>) ],
                                returnType = typeof<NormativeTriple>,
                                isStatic = false,
                                invokeCode =
                                    fun args ->

                                        let subject = Expr.Coerce(args[0], typeof<NamedIndividual>)
                                        let object_ = Expr.Coerce(args[1], typeof<NormativeObject>)

                                        <@@
                                            let predicate = IriPredicate(Iri.op_Implicit (%%identity: string))

                                            let normativeSubject = IriSubject((%%subject: NamedIndividual).Iri)

                                            let normativeObject = (%%object_: NormativeObject)

                                            NormativeTriple.PSO(predicate, normativeSubject, normativeObject)
                                        @@>
                            )
                            ProvidedMethod(
                                methodName = propertyName,
                                parameters = [ ProvidedParameter("objects", typeof<NormativeObject list>) ],
                                returnType = typeof<NormativeTriple list>,
                                isStatic = false,
                                invokeCode =
                                    fun args ->

                                        let subject = Expr.Coerce(args[0], typeof<NamedIndividual>)
                                        let objects = Expr.Coerce(args[1], typeof<NormativeObject list>)

                                        <@@
                                            let predicate = IriPredicate(Iri.op_Implicit (%%identity: string))

                                            let normativeSubject = IriSubject((%%subject: NamedIndividual).Iri)

                                            (%%objects: NormativeObject list)
                                            |> List.map (fun object_ ->
                                                NormativeTriple.PSO(predicate, normativeSubject, object_))
                                        @@>
                            )
                            ProvidedMethod(
                                methodName = propertyName,
                                parameters = [ ProvidedParameter("object", typeof<Iri>) ],
                                returnType = typeof<NormativeTriple>,
                                isStatic = false,
                                invokeCode =
                                    fun args ->

                                        let subject = Expr.Coerce(args[0], typeof<NamedIndividual>)
                                        let object_ = Expr.Coerce(args[1], typeof<Iri>)

                                        <@@
                                            let predicate = IriPredicate(Iri.op_Implicit (%%identity: string))

                                            let normativeSubject = IriSubject((%%subject: NamedIndividual).Iri)

                                            let normativeObject = IriObject(%%object_: Iri) |> BasicNormativeObject

                                            NormativeTriple.PSO(predicate, normativeSubject, normativeObject)
                                        @@>
                            )
                            ProvidedMethod(
                                methodName = propertyName,
                                parameters = [ ProvidedParameter("objects", typeof<Iri list>) ],
                                returnType = typeof<NormativeTriple list>,
                                isStatic = false,
                                invokeCode =
                                    fun args ->

                                        let subject = Expr.Coerce(args[0], typeof<NamedIndividual>)
                                        let objects = Expr.Coerce(args[1], typeof<Iri list>)

                                        <@@
                                            let predicate = IriPredicate(Iri.op_Implicit (%%identity: string))

                                            let normativeSubject = IriSubject((%%subject: NamedIndividual).Iri)

                                            (%%objects: Iri list)
                                            |> List.map (fun object_ ->
                                                NormativeTriple.PSO(
                                                    predicate,
                                                    normativeSubject,
                                                    IriObject object_ |> BasicNormativeObject
                                                ))
                                        @@>
                            )
                            ProvidedMethod(
                                methodName = propertyName,
                                parameters = [ ProvidedParameter("object", typeof<BNode>) ],
                                returnType = typeof<NormativeTriple>,
                                isStatic = false,
                                invokeCode =
                                    fun args ->

                                        let subject = Expr.Coerce(args[0], typeof<NamedIndividual>)
                                        let object_ = Expr.Coerce(args[1], typeof<BNode>)

                                        <@@
                                            let predicate = IriPredicate(Iri.op_Implicit (%%identity: string))

                                            let normativeSubject = IriSubject((%%subject: NamedIndividual).Iri)

                                            let normativeObject = BNodeObject(%%object_: BNode) |> BasicNormativeObject

                                            NormativeTriple.PSO(predicate, normativeSubject, normativeObject)
                                        @@>
                            )
                            ProvidedMethod(
                                methodName = propertyName,
                                parameters = [ ProvidedParameter("objects", typeof<BNode list>) ],
                                returnType = typeof<NormativeTriple list>,
                                isStatic = false,
                                invokeCode =
                                    fun args ->

                                        let subject = Expr.Coerce(args[0], typeof<NamedIndividual>)
                                        let objects = Expr.Coerce(args[1], typeof<BNode list>)

                                        <@@
                                            let predicate = IriPredicate(Iri.op_Implicit (%%identity: string))

                                            let normativeSubject = IriSubject((%%subject: NamedIndividual).Iri)

                                            (%%objects: BNode list)
                                            |> List.map (fun object_ ->
                                                NormativeTriple.PSO(
                                                    predicate,
                                                    normativeSubject,
                                                    BNodeObject object_ |> BasicNormativeObject
                                                ))
                                        @@>
                            )
                            ProvidedMethod(
                                methodName = propertyName,
                                parameters = [ ProvidedParameter("object", typeof<Literal>) ],
                                returnType = typeof<NormativeTriple>,
                                isStatic = false,
                                invokeCode =
                                    fun args ->

                                        let subject = Expr.Coerce(args[0], typeof<NamedIndividual>)
                                        let object_ = Expr.Coerce(args[1], typeof<Literal>)

                                        <@@
                                            let predicate = IriPredicate(Iri.op_Implicit (%%identity: string))

                                            let normativeSubject = IriSubject((%%subject: NamedIndividual).Iri)

                                            let normativeObject =
                                                LiteralObject(%%object_: Literal) |> BasicNormativeObject

                                            NormativeTriple.PSO(predicate, normativeSubject, normativeObject)
                                        @@>
                            )
                            ProvidedMethod(
                                methodName = propertyName,
                                parameters = [ ProvidedParameter("objects", typeof<Literal list>) ],
                                returnType = typeof<NormativeTriple list>,
                                isStatic = false,
                                invokeCode =
                                    fun args ->

                                        let subject = Expr.Coerce(args[0], typeof<NamedIndividual>)
                                        let objects = Expr.Coerce(args[1], typeof<Literal list>)

                                        <@@
                                            let predicate = IriPredicate(Iri.op_Implicit (%%identity: string))

                                            let normativeSubject = IriSubject((%%subject: NamedIndividual).Iri)

                                            (%%objects: Literal list)
                                            |> List.map (fun object_ ->
                                                NormativeTriple.PSO(
                                                    predicate,
                                                    normativeSubject,
                                                    LiteralObject object_ |> BasicNormativeObject
                                                ))
                                        @@>
                            )
                            ProvidedMethod(
                                methodName = propertyName,
                                parameters = [ ProvidedParameter("object", typeof<TripleTerm>) ],
                                returnType = typeof<NormativeTriple>,
                                isStatic = false,
                                invokeCode =
                                    fun args ->

                                        let subject = Expr.Coerce(args[0], typeof<NamedIndividual>)
                                        let object_ = Expr.Coerce(args[1], typeof<TripleTerm>)

                                        <@@
                                            let predicate = IriPredicate(Iri.op_Implicit (%%identity: string))

                                            let normativeSubject = IriSubject((%%subject: NamedIndividual).Iri)

                                            let normativeObject = TripleTermObject(%%object_: TripleTerm)

                                            NormativeTriple.PSO(predicate, normativeSubject, normativeObject)
                                        @@>
                            )
                            ProvidedMethod(
                                methodName = propertyName,
                                parameters = [ ProvidedParameter("objects", typeof<TripleTerm list>) ],
                                returnType = typeof<NormativeTriple list>,
                                isStatic = false,
                                invokeCode =
                                    fun args ->

                                        let subject = Expr.Coerce(args[0], typeof<NamedIndividual>)
                                        let objects = Expr.Coerce(args[1], typeof<TripleTerm list>)

                                        <@@
                                            let predicate = IriPredicate(Iri.op_Implicit (%%identity: string))

                                            let normativeSubject = IriSubject((%%subject: NamedIndividual).Iri)

                                            (%%objects: TripleTerm list)
                                            |> List.map (fun object_ ->
                                                NormativeTriple.PSO(
                                                    predicate,
                                                    normativeSubject,
                                                    TripleTermObject object_
                                                ))
                                        @@>
                            )
                            ProvidedMethod(
                                methodName = propertyName,
                                parameters = [ ProvidedParameter("object", typeof<NamedIndividual>) ],
                                returnType = typeof<NormativeTriple>,
                                isStatic = false,
                                invokeCode =
                                    fun args ->

                                        let subject = Expr.Coerce(args[0], typeof<NamedIndividual>)
                                        let object_ = Expr.Coerce(args[1], typeof<NamedIndividual>)

                                        <@@
                                            let predicate = IriPredicate(Iri.op_Implicit (%%identity: string))

                                            let normativeSubject = IriSubject((%%subject: NamedIndividual).Iri)

                                            let normativeObject =
                                                BasicNormativeObject(IriObject((%%object_: NamedIndividual).Iri))

                                            NormativeTriple.PSO(predicate, normativeSubject, normativeObject)
                                        @@>
                            )
                            ProvidedMethod(
                                methodName = propertyName,
                                parameters = [ ProvidedParameter("objects", typeof<NamedIndividual list>) ],
                                returnType = typeof<NormativeTriple list>,
                                isStatic = false,
                                invokeCode =
                                    fun args ->

                                        let subject = Expr.Coerce(args[0], typeof<NamedIndividual>)
                                        let objects = Expr.Coerce(args[1], typeof<NamedIndividual list>)

                                        <@@
                                            let predicate = IriPredicate(Iri.op_Implicit (%%identity: string))

                                            let normativeSubject = IriSubject((%%subject: NamedIndividual).Iri)

                                            (%%objects: NamedIndividual list)
                                            |> List.map (fun object_ ->
                                                NormativeTriple.PSO(
                                                    predicate,
                                                    normativeSubject,
                                                    IriObject object_.Iri |> BasicNormativeObject
                                                ))
                                        @@>
                            )
                        ]
                        |> List.map (fun methodDefinition ->
                            methodDefinition.AddXmlDocDelayed(fun () ->
                                VocabularyXmlDocumentation.ofResource
                                    propertyName
                                    propertyNode.Uri.OriginalString
                                    ontologyProperty)
                            methodDefinition)

                    | _ -> [])
                |> Seq.toList)

        (*
            TermTypeDefinition.AddMembersDelayed(fun () ->
                [
                  ProvidedProperty(
                      propertyName = "asSubject",
                      propertyType = typeof<NormativeSubject>,
                      isStatic = false,
                      getterCode =
                          fun args ->
                              let individual = Expr.Coerce(args[0], typeof<NamedIndividual>)

                              <@@ IriSubject((%%individual: NamedIndividual).Iri) @@>
                  )
                  ProvidedProperty(
                      propertyName = "asObject",
                      propertyType = typeof<NormativeObject>,
                      isStatic = false,
                      getterCode =
                          fun args ->
                              let individual = Expr.Coerce(args[0], typeof<NamedIndividual>)

                              <@@ BasicNormativeObject(IriObject((%%individual: NamedIndividual).Iri)) @@>
                  ) ])
        *)

        VocabularyTypeDefinition.AddMembersDelayed(fun () ->
            [
                for prefixedName, ontologyClass in classes |> Map.toSeq do

                    let providedName =
                        ontologyClass.Label
                        |> Seq.map (fun label -> label.Value)
                        |> Seq.distinct
                        |> Seq.sort
                        |> Seq.filter (fun label -> label <> prefixedName.localName)
                        |> Seq.insertAt 0 prefixedName.localName
                        |> String.concat "'"

                    match owlClasses.TryFind prefixedName with
                    | Some owlClass ->
                        yield ClassIri(PrefixedName prefixedName)
                              |> CodeProvision.staticProperty OwlClassTypeDefinition providedName
                              |> VocabularyXmlDocumentation.attachProperty prefixedName ontologyClass
                    | None ->
                        (*
                          RdfClassTypeDefinition.AddMemberDelayed(fun () ->
                              ProvidedProperty(
                                  propertyName = "asObject",
                                  propertyType = typeof<NormativeObject>,
                                  isStatic = false,
                                  getterCode =
                                      fun args ->
                                          let individual = Expr.Coerce(args[0], typeof<Iri>)

                                          <@@ BasicNormativeObject(IriObject((%%individual: Iri))) @@>
                              ))

                          RdfClassTypeDefinition.AddMemberDelayed(fun () ->
                              ProvidedProperty(
                                  propertyName = "asSubject",
                                  propertyType = typeof<NormativeSubject>,
                                  isStatic = false,
                                  getterCode =
                                      fun args ->
                                          let individual = Expr.Coerce(args[0], typeof<Iri>)

                                          <@@ IriSubject((%%individual: Iri)) @@>
                              ))
                        *)
                        yield PrefixedName prefixedName
                              |> CodeProvision.staticProperty RdfClassTypeDefinition providedName
                              |> VocabularyXmlDocumentation.attachProperty prefixedName ontologyClass
            ])

        VocabularyTypeDefinition

    do
        let vocabularyProvider =
            ProvidedTypeDefinition(assembly, providedNamespace, "VocabularyProvider", Some typeof<obj>, isErased = true)

        vocabularyProvider.DefineStaticParameters(
            parameters =
                [ ProvidedStaticParameter("NamespacePrefix", typeof<string>)
                  ProvidedStaticParameter("NamespaceName", typeof<string>)
                  ProvidedStaticParameter("DocumentIris", typeof<string>) ],
            instantiationFunction =
                fun typeName args ->
                    let namespacePrefix = args[0] :?> string
                    let namespaceName = args[1] :?> string
                    let documentIriString = args[2] :?> string

                    createType typeName namespacePrefix namespaceName documentIriString
        )

        this.AddNamespace(providedNamespace, [ vocabularyProvider ])

module index =

    [<Literal>]
    let htmlFilePath = @"D:\ftp\org\iana\assignments\index.html"

    type Html = HtmlProvider<htmlFilePath>
    let html = Html.Load htmlFilePath

    [<Literal>]
    let xhtmlFilePath = @"D:\ftp\org\iana\assignments\index.xhtml"

    let htmlDocument =
        let document = HtmlParser().ParseDocument(File.ReadAllText(htmlFilePath))

        use writer = new StreamWriter(xhtmlFilePath)

        document.DocumentElement.ToHtml(writer, XhtmlMarkupFormatter.Instance)

        document

    type XHtml = XmlProvider<UseOriginalNames=true, Sample=xhtmlFilePath>
    let xhtml = XHtml.Load xhtmlFilePath

    module uri_schemes =
        [<Literal>]
        let xmlFilePath = @"D:\ftp\org\iana\assignments\uri-schemes\uri-schemes.xml"

        type Xml =
            XmlProvider<UseOriginalNames=true, Sample= @"D:\ftp\org\iana\assignments\uri-schemes\uri-schemes.xml">

        let xml = Xml.Load(xmlFilePath)
module private ProtocolRegistryIndex =

    let groupIndexes =

        index.html.Tables.``Index of IANA Protocol Registries``.Rows
        |> Array.mapi (fun currentIndex row ->
            let tr = index.xhtml.body.table.tbody.trs[currentIndex]

            match tr.``class`` with

            | "iana-protocol-group" -> Group currentIndex
            | "iana-protocol-registry" -> Registry currentIndex)
        |> Array.choose (fun row ->
            match row with
            | Group length -> Some length
            | _ -> None)
        |> Array.distinct
        |> Array.sort

    let registryEntries =
        groupIndexes
        |> Array.mapi (fun groupOrdinal groupRowIndex ->

            let registryIndexStart = groupRowIndex + 1

            let registryIndexEnd =
                if groupOrdinal + 1 < groupIndexes.Length then
                    groupIndexes[groupOrdinal + 1] - 1
                else
                    index.html.Tables.``Index of IANA Protocol Registries``.Rows.Length - 1

            let group =
                index.html.Tables.``Index of IANA Protocol Registries``.Rows[groupRowIndex].Column1

            [| for registryIndex = registryIndexStart to registryIndexEnd do
                   yield
                       { group = group
                         name = index.html.Tables.``Index of IANA Protocol Registries``.Rows[registryIndex].Column1

                         localName = index.xhtml.body.table.tbody.trs[registryIndex].tds[0].``as``[0].href

                         documentation =
                           index.html.Tables.``Index of IANA Protocol Registries``.Rows[registryIndex].Column2

                         references =
                           index.xhtml.body.table.tbody.trs[registryIndex].tds[1].``as``
                           |> Array.map _.href

                         comment = index.html.Tables.``Index of IANA Protocol Registries``.Rows[registryIndex].Column3 } |])
        |> Array.concat

    let protocolSchemes =
        index.uri_schemes.xml.registries
        |> Array.filter (fun registry -> registry.title = "Uniform Resource Identifier (URI) Schemes")
        |> Array.collect (fun schemeRegistry ->

            schemeRegistry.records
            |> Array.distinctBy (fun scheme -> scheme.value.Value.XElement.Value)
            // |> Array.Parallel.filter (fun scheme -> not (scheme.value.Value.XElement.Value.Contains("OBSOLETE")))
            |> Array.map (fun record ->

                let namespaceName = record.XElement.Name.NamespaceName
                let value = record.value.Value.XElement.Value

                let file =
                    match record.file with
                    | Some file -> file.Value
                    | None -> None

                let description =
                    if record.description.Value.Value.Value = value then
                        None
                    else
                        Some record.description.Value.Value.Value

                let wellKnown =
                    match record.``well-known`` with
                    | Some wellKnown ->
                        try
                            Some(Iana.XRef.ofElement (wellKnown.xref.``type``, wellKnown.xref.data, None))
                        with _ ->
                            None
                    | _ -> None

                let references =
                    match record.xrefs with
                    | [||] -> [||]
                    | xrefs ->
                        xrefs
                        |> Array.map (fun xref -> Iana.XRef.ofElement (xref.``type``, xref.data, xref.Value))

                let notes =
                    match record.notes with
                    | Some notes when not (String.IsNullOrWhiteSpace notes.XElement.Value) ->
                        Some notes.XElement.Value
                    | _ -> None

                { date = record.date
                  updated = record.updated
                  fileTemplate = file
                  name = value
                  description = description
                  status = Iana.Status.ofString record.status.Value |> Some
                  cri = Some record.cri.Value
                  wellKnown = wellKnown
                  references = references
                  notes = notes }
                : Iana.ProtocolScheme))

    let groupedEntries = registryEntries |> Array.groupBy _.group

[<TypeProvider>]
type ProtocolRegistryProvider(config: TypeProviderConfig) as this =

    inherit
        TypeProviderForNamespaces(
            config,
            assemblyReplacementMap = [ ("DoxAletheia.DesignTime", "DoxAletheia.Runtime") ]
        )

    let namespaceName = "Iana"

    let provider =
        ProvidedTypeDefinition(Assembly.GetExecutingAssembly(), namespaceName, "RegistryProvider", Some typeof<obj>)

    let groupIndexes =

        index.html.Tables.``Index of IANA Protocol Registries``.Rows
        |> Array.mapi (fun currentIndex row ->
            let tr = index.xhtml.body.table.tbody.trs[currentIndex]

            match tr.``class`` with

            | "iana-protocol-group" -> Group currentIndex
            | "iana-protocol-registry" -> Registry currentIndex)
        |> Array.choose (fun row ->
            match row with
            | Group length -> Some length
            | _ -> None)
        |> Array.distinct
        |> Array.sort

    let registryEntries =
        groupIndexes
        |> Array.mapi (fun groupOrdinal groupRowIndex ->

            let registryIndexStart = groupRowIndex + 1

            let registryIndexEnd =
                if groupOrdinal + 1 < groupIndexes.Length then
                    groupIndexes[groupOrdinal + 1] - 1
                else
                    index.html.Tables.``Index of IANA Protocol Registries``.Rows.Length - 1

            let group =
                index.html.Tables.``Index of IANA Protocol Registries``.Rows[groupRowIndex].Column1

            [| for registryIndex = registryIndexStart to registryIndexEnd do
                   yield
                       { group = group
                         name = index.html.Tables.``Index of IANA Protocol Registries``.Rows[registryIndex].Column1

                         localName = index.xhtml.body.table.tbody.trs[registryIndex].tds[0].``as``[0].href

                         documentation =
                           index.html.Tables.``Index of IANA Protocol Registries``.Rows[registryIndex].Column2

                         references =
                           index.xhtml.body.table.tbody.trs[registryIndex].tds[1].``as``
                           |> Array.map _.href

                         comment = index.html.Tables.``Index of IANA Protocol Registries``.Rows[registryIndex].Column3 } |])
        |> Array.concat

    let protocolSchemes =
        index.uri_schemes.xml.registries
        |> Array.filter (fun registry -> registry.title = "Uniform Resource Identifier (URI) Schemes")
        |> Array.collect (fun schemeRegistry ->

            schemeRegistry.records
            |> Array.distinctBy (fun scheme -> scheme.value.Value.XElement.Value)
            // |> Array.Parallel.filter (fun scheme -> not (scheme.value.Value.XElement.Value.Contains("OBSOLETE")))
            |> Array.map (fun record ->

                let namespaceName = record.XElement.Name.NamespaceName
                let value = record.value.Value.XElement.Value

                let file =
                    match record.file with
                    | Some file -> file.Value
                    | None -> None

                let description =
                    if record.description.Value.Value.Value = value then
                        None
                    else
                        Some record.description.Value.Value.Value

                let wellKnown =
                    match record.``well-known`` with
                    | Some wellKnown ->
                        try
                            Some(Iana.XRef.ofElement (wellKnown.xref.``type``, wellKnown.xref.data, None))
                        with _ ->
                            None
                    | _ -> None

                let references =
                    match record.xrefs with
                    | [||] -> [||]
                    | xrefs ->
                        xrefs
                        |> Array.map (fun xref -> Iana.XRef.ofElement (xref.``type``, xref.data, xref.Value))

                let notes =
                    match record.notes with
                    | Some notes when not (String.IsNullOrWhiteSpace notes.XElement.Value) ->
                        Some notes.XElement.Value
                    | _ -> None

                { date = record.date
                  updated = record.updated
                  fileTemplate = file
                  name = value
                  description = description
                  status = Iana.Status.ofString record.status.Value |> Some
                  cri = Some record.cri.Value
                  wellKnown = wellKnown
                  references = references
                  notes = notes }
                : Iana.ProtocolScheme))

    let asRegistryEntryExpression (entry: ProtocolRegistryEntry) =

        Expr.NewRecord(
            typeof<ProtocolRegistryEntry>,
            [ Expr.Value(entry.group)
              Expr.Value(entry.name)
              Expr.Value(entry.localName)
              Expr.Value(entry.documentation)

              Expr.NewArray(
                  typeof<string>,
                  entry.references
                  |> Array.map (fun reference -> Expr.Value(reference))
                  |> Array.toList
              )

              Expr.Value(entry.comment) ]
        )

    let rec asValueExpression (value: obj) (valueType: Type) : Expr =

        if valueType = typeof<DateTime> then

            let date = unbox<DateTime> value

            let constructor =
                typeof<DateTime>.GetConstructor([| typeof<int64>; typeof<DateTimeKind> |])

            Expr.NewObject(
                constructor,
                [ Expr.Value(date.Ticks, typeof<int64>)

                  Expr.Coerce(Expr.Value(int date.Kind, typeof<int>), typeof<DateTimeKind>) ]
            )

        elif FSharpType.IsUnion valueType then

            let unionCase, fields = FSharpValue.GetUnionFields(value, valueType)

            let fieldTypes = unionCase.GetFields() |> Array.map _.PropertyType

            let fieldExpressions =
                (fields, fieldTypes) ||> Array.map2 asValueExpression |> Array.toList

            Expr.NewUnionCase(unionCase, fieldExpressions)

        elif FSharpType.IsRecord valueType then

            let fields = FSharpValue.GetRecordFields(value)

            let fieldTypes = FSharpType.GetRecordFields(valueType) |> Array.map _.PropertyType

            let fieldExpressions =
                (fields, fieldTypes) ||> Array.map2 asValueExpression |> Array.toList

            Expr.NewRecord(valueType, fieldExpressions)

        elif valueType.IsArray then

            let elementType = valueType.GetElementType()

            let elements =
                (value :?> Array)
                |> Seq.cast<obj>
                |> Seq.map (fun element -> asValueExpression element elementType)
                |> Seq.toList

            Expr.NewArray(elementType, elements)

        else
            Expr.Value(value, valueType)

    let asProvidedSchemeProperty (scheme: ProtocolScheme) =

        ProvidedProperty(
            propertyName = scheme.name,
            propertyType = typeof<ProtocolScheme>,
            isStatic = true,
            getterCode = fun _ -> Quotation.ofValue scheme
        )

    do
        provider.AddMembersDelayed(fun () ->

            ProtocolRegistryIndex.groupedEntries
            |> Array.map (fun (groupName, entries) ->

                let groupType = ProvidedTypeDefinition(groupName, Some typeof<obj>)

                groupType.AddMembersDelayed(fun () ->

                    entries
                    |> Array.map (fun entry ->

                        if
                            entry.group = "Uniform Resource Identifier (URI) Schemes"
                            && entry.name = "Uniform Resource Identifier (URI) Schemes"
                        then

                            let registryType = ProvidedTypeDefinition(entry.name, Some typeof<obj>)

                            registryType.AddMember(
                                ProvidedProperty(
                                    propertyName = "Entry",
                                    propertyType = typeof<ProtocolRegistryEntry>,
                                    isStatic = true,
                                    getterCode = fun _ -> Quotation.ofValue entry
                                )
                            )

                            registryType.AddMembersDelayed(fun () ->

                                protocolSchemes |> Array.map asProvidedSchemeProperty |> Array.toList)

                            registryType :> MemberInfo

                        else

                            let property =
                                ProvidedProperty(
                                    propertyName = entry.name,
                                    propertyType = typeof<ProtocolRegistryEntry>,
                                    isStatic = true,
                                    getterCode = fun _ -> Quotation.ofValue entry
                                )

                            property.AddXmlDocDelayed(fun () ->
                                $"Documentation: {entry.documentation}<br>{entry.comment}")

                            property :> MemberInfo)
                    |> Array.toList)

                groupType)
            |> Array.toList)

        this.AddNamespace(namespaceName, [ provider ])

module private PublicSuffixIndex =

    let publicSuffixes =
        let parser = TldRuleParser(TldRuleDivisionFilter.All)

        File.ReadAllLines(@"D:\https\org\publicsuffix\list\public_suffix_list.dat")
        |> parser.ParseRules
        |> Seq.toArray
        |> Array.map TopLevelDomainRule

    let publicSuffixTrie =
        let trie =
            Trie<string array, string, PublicSuffix>(fun tokens -> tokens :> seq<string>)

        publicSuffixes
        |> Array.map (fun suffix -> suffix, suffix.labels |> Array.rev)
        |> Array.iter (fun (suffix, reverseLabels) -> trie.Add(reverseLabels, suffix))

        trie
[<TypeProvider>]
type PublicSuffixProvider(config: TypeProviderConfig) as this =

    inherit
        TypeProviderForNamespaces(
            config,
            assemblyReplacementMap = [ ("DoxAletheia.DesignTime", "DoxAletheia.Runtime") ]
        )

    let namespaceName = "PublicSuffixList"

    let provider =
        ProvidedTypeDefinition(Assembly.GetExecutingAssembly(), namespaceName, "PublicSuffixProvider", Some typeof<obj>)

    let publicSuffixTrie = PublicSuffixIndex.publicSuffixTrie
    let asSuffixProperty (suffix: PublicSuffix) =

        let property =
            ProvidedProperty(
                propertyName = "tld",
                propertyType = typeof<PublicSuffix>,
                isStatic = true,
                getterCode = fun _ -> Quotation.ofValue suffix
            )

        property.AddXmlDocDelayed(fun () ->
            $"Public suffix: {suffix.name}\nRule type: {suffix.ruleType}\nDivision: {suffix.division}")

        property

    let rec asProvidedNodes (nodes: seq<ITrieNode<string, PublicSuffix>>) : ProvidedTypeDefinition list =

        nodes
        |> Seq.sortBy _.KeyBit
        |> Seq.map (fun trieNode ->

            let node = ProvidedTypeDefinition(trieNode.KeyBit, Some typeof<obj>)

            node.AddMembersDelayed(fun () ->

                let terminalProperties =
                    if trieNode.HasValue then
                        [ asSuffixProperty trieNode.Value :> MemberInfo ]
                    else
                        []

                let children =
                    asProvidedNodes trieNode.Children |> List.map (fun child -> child :> MemberInfo)

                terminalProperties @ children)

            node)
        |> Seq.toList

    do
        provider.AddMembersDelayed(fun () -> asProvidedNodes publicSuffixTrie.Root.Children)

        this.AddNamespace(namespaceName, [ provider ])

module media_types =

    [<Literal>]
    let xmlFilePath = @"D:\ftp\org\iana\assignments\media-types\media-types.xml"

    type Xml = XmlProvider<UseOriginalNames=true, Sample= @"D:\ftp\org\iana\assignments\media-types\media-types.xml">

    let xml = Xml.Load xmlFilePath
module private InternetMediaTypeIndex =

    let internetMediaTypes =
        media_types.xml.registries
        |> Array.collect (fun registry ->
            registry.records
            |> Array.map (fun record ->
                InternetMediaType.ofRegistryRecord (
                    record.file.Value,
                    record.xrefs
                    |> Array.map (fun xref -> XRef.ofElement (xref.``type``, xref.data.Value, xref.Value))
                )))
        |> Array.distinctBy (fun mime -> mime.contentType)
        |> Array.sortBy (fun mime -> mime.contentType)

    let internetMediaTypeTrie =
        let trie =
            Trie<string array, string, InternetMediaType>(fun tokens -> tokens :> seq<string>)

        for mime in internetMediaTypes do
            let tokens = mime.tokens

            if trie.ContainsKey(tokens, true) then
                invalidOp (sprintf "Duplicate MIME provider path: %s" (String.concat "." tokens))

            trie.Add(tokens, mime)

        trie

[<TypeProvider>]
type InternetMediaTypeProvider(config: TypeProviderConfig) as this =

    inherit
        TypeProviderForNamespaces(
            config,
            assemblyReplacementMap = [ ("DoxAletheia.DesignTime", "DoxAletheia.Runtime") ]
        )

    let namespaceName = "Iana"

    let provider =
        ProvidedTypeDefinition(
            Assembly.GetExecutingAssembly(),
            namespaceName,
            "InternetMediaTypeProvider",
            Some typeof<obj>
        )

    let RdfClassTypeDefinition =
        ProvidedTypeDefinition("RdfClass", Some typeof<Iri>, isErased = true)

    do provider.AddMember RdfClassTypeDefinition

    let internetMediaTypeTrie = InternetMediaTypeIndex.internetMediaTypeTrie

    let rec asValueExpression (value: obj) (valueType: Type) : Expr =

        if FSharpType.IsUnion valueType then

            let unionCase, fields = FSharpValue.GetUnionFields(value, valueType)

            let fieldTypes = unionCase.GetFields() |> Array.map _.PropertyType

            let expressions = Array.map2 asValueExpression fields fieldTypes |> Array.toList

            Expr.NewUnionCase(unionCase, expressions)

        elif valueType.IsArray then

            let elementType = valueType.GetElementType()

            let elements =
                (value :?> Array)
                |> Seq.cast<obj>
                |> Seq.map (fun element -> asValueExpression element elementType)
                |> Seq.toList

            Expr.NewArray(elementType, elements)

        else
            Expr.Value(value, valueType)

    let ofContentTypeMethod =
        typeof<InternetMediaType>.GetMethod("ofContentType", [| typeof<string>; typeof<XRef array> |])

    let asInternetMediaTypeExpression (mime: InternetMediaType) =

        Expr.Call(
            ofContentTypeMethod,
            [ Expr.Value(mime.contentType, typeof<string>)

              asValueExpression (box mime.references) typeof<XRef array> ]
        )

    let asInternetMediaTypeProperty (mime: InternetMediaType) =

        let property =
            ProvidedProperty(
                propertyName = "mime",
                propertyType = typeof<InternetMediaType>,
                isStatic = true,
                getterCode = fun _ -> Quotation.ofValue mime
            )

        property.AddXmlDocDelayed(fun () -> $"MIME type: {mime.contentType}")

        property

    let asIanaIriProperty (mime: InternetMediaType) =

        let property =
            ProvidedProperty(
                propertyName = "ianaIri",
                propertyType = typeof<Iri>,
                isStatic = true,
                getterCode =
                    fun _ ->
                        Quotation.ofValue (
                            PrefixedName
                                { vocabulary =
                                    RdfVocabulary.media_types.prefixedName mime.mime.MediaType
                                    |> RdfVocabulary.ofPrefixedName

                                  localName = mime.mime.SubType }
                        )
            )

        property

    let asW3IDIriProperty (mime: InternetMediaType) =

        let property =
            ProvidedProperty(
                propertyName = "w3idIri",
                propertyType = typeof<Iri>,
                isStatic = true,
                getterCode =
                    fun _ ->
                        Quotation.ofValue (
                            PrefixedName
                                { vocabulary = RdfVocabulary.w3id_mediatype

                                  localName = mime.contentType }
                        )
            )

        property

    let asClassProperty (mime: InternetMediaType) =

        let property =
            ProvidedProperty(
                propertyName = "RdfClass",
                propertyType = RdfClassTypeDefinition,
                isStatic = true,
                getterCode =
                    fun _ ->
                        Quotation.ofValue (
                            PrefixedName
                                { vocabulary =
                                    RdfVocabulary.media_types.prefixedName mime.contentType
                                    |> RdfVocabulary.hashPrefixedName

                                  localName = "Resource" }
                        )
            )

        property

    let asSparIndividualProperty (mime: InternetMediaType) =

        let property =
            ProvidedProperty(
                propertyName = "sparIndividual",
                propertyType = typeof<NamedIndividual>,
                isStatic = true,
                getterCode =
                    fun _ ->
                        Quotation.ofValue (
                            { vocabulary =
                                RdfVocabulary.spar_mediatype.prefixedName mime.mime.MediaType
                                |> RdfVocabulary.ofPrefixedName

                              localName = mime.mime.SubType }
                            |> PrefixedName
                            |> NamedIndividualIri
                        )
            )

        property

    let asSpdxLiteralProperty (mime: InternetMediaType) =

        let property =
            ProvidedProperty(
                propertyName = "spdxLiteral",
                propertyType = typeof<TypedLiteral>,
                isStatic = true,
                getterCode = fun _ -> Quotation.ofValue (StaticTypedLiteral.toTypedLiteral mime.spdx'MediaType)
            )

        property

    let rec asProvidedNodes (trieNode: ITrieNode<string, InternetMediaType>) : ProvidedTypeDefinition list =

        trieNode.Children
        |> Seq.sortBy (fun child -> child.KeyBit)
        |> Seq.map (fun child ->

            let node = ProvidedTypeDefinition(child.KeyBit, Some typeof<obj>)

            node.AddMembersDelayed(fun () ->

                let terminalProperties =
                    if child.HasValue then
                        [ asInternetMediaTypeProperty child.Value :> MemberInfo

                          asIanaIriProperty child.Value :> MemberInfo

                          asW3IDIriProperty child.Value :> MemberInfo

                          asClassProperty child.Value :> MemberInfo

                          asSparIndividualProperty child.Value :> MemberInfo

                          asSpdxLiteralProperty child.Value :> MemberInfo ]
                    else
                        []

                let children =
                    asProvidedNodes child |> List.map (fun nested -> nested :> MemberInfo)

                terminalProperties @ children)

            node)
        |> Seq.toList

    do
        provider.AddMembersDelayed(fun () -> asProvidedNodes internetMediaTypeTrie.Root)

        this.AddNamespace(namespaceName, [ provider ])

[<TypeProvider>]
type NuGetProtocolProvider(config: TypeProviderConfig) as this =

    inherit
        TypeProviderForNamespaces(
            config,
            assemblyReplacementMap = [ ("DoxAletheia.DesignTime", "DoxAletheia.Runtime") ]
        )

    let namespaceName = "NuGet"

    let provider =
        ProvidedTypeDefinition(
            Assembly.GetExecutingAssembly(),
            namespaceName,
            "ProtocolProvider",
            Some typeof<obj>,
            isErased = true
        )

    let getAvailableResources (serviceIndex: string) =
        Repository.Factory.GetCoreV3(serviceIndex).ResourceTypes
        |> Array.filter (fun resourceType ->
            match resourceType.Name with
            | "RawSearchResourceV3" -> false
            | "ReadmeUriTemplateResource" -> false
            | _ -> true)
        |> Array.toList
    // The existing SourceRepository.GetResourceAsync<'T>() method.
    let getResourceMethod =
        typeof<SourceRepository>.GetMethods()
        |> Array.find (fun methodInfo ->
            methodInfo.Name = "GetResourceAsync"
            && methodInfo.IsGenericMethodDefinition
            && methodInfo.GetParameters().Length = 0)

    let createType (typeName: string) (serviceIndex: string) =

        let nugetType =
            ProvidedTypeDefinition(
                Assembly.GetExecutingAssembly(),
                namespaceName,
                typeName,
                Some typeof<obj>,
                isErased = true
            )

        let asResourceProperty (resourceType: Type) =

            let propertyName = resourceType.Name.Replace("V3", "").Replace("Resource", "")

            ProvidedProperty(
                propertyName = propertyName,
                propertyType = resourceType,
                isStatic = true,
                getterCode = fun _ -> Quotation.ofNuGetResource (serviceIndex, resourceType)
            )

        nugetType.AddMembersDelayed(fun () ->
            getAvailableResources serviceIndex
            |> List.map (fun resourceType -> asResourceProperty resourceType :> MemberInfo))

        nugetType

    do
        provider.DefineStaticParameters(
            parameters = [ ProvidedStaticParameter("ServiceIndex", typeof<string>) ],
            instantiationFunction = fun typeName args -> createType typeName (args[0] :?> string)
        )

        this.AddNamespace(namespaceName, [ provider ])

module WebServiceDescriptionIndex =

    let private cache =
        ConcurrentDictionary< string, Lazy<Trie<string array, string, FileInfo>> >(StringComparer.OrdinalIgnoreCase)

    let private create (directoryPath: string) =

        let directory = DirectoryInfo(directoryPath)

        if not directory.Exists then
            invalidArg "directoryPath" directoryPath

        let trie =
            Trie<string array, string, FileInfo>(
                fun tokens -> tokens :> seq<string>
            )

        for file in directory.EnumerateFiles(
            "*.wsdl",
            SearchOption.AllDirectories
        ) do

            let relativePath =
                Path.GetRelativePath(directory.FullName, file.FullName)

            let directorySegments =
                match Path.GetDirectoryName(relativePath) with
                | null | "" -> [||]
                | path ->
                    path.Split(
                        [| Path.DirectorySeparatorChar; Path.AltDirectorySeparatorChar |],
                        StringSplitOptions.RemoveEmptyEntries
                    )

            let monikerSegments =
                Path.GetFileNameWithoutExtension(relativePath).Split('.')

            let tokens =
                Array.append directorySegments monikerSegments

            if trie.ContainsKey(tokens, true) then
                invalidOp $"Duplicate WSDL path: {relativePath}"

            trie.Add(tokens, file)

        trie

    let get (directoryPath: string) =

        let normalizedPath =
            Path.GetFullPath(directoryPath)

        cache.GetOrAdd(
            normalizedPath,
            fun path -> lazy (create path)
        ).Value

[<TypeProvider>]
type WebServiceDescriptionProvider(config: TypeProviderConfig) as this =

    inherit
        TypeProviderForNamespaces(
            config,
            assemblyReplacementMap =
                [ ("DoxAletheia.DesignTime", "DoxAletheia.Runtime") ],
            addDefaultProbingLocation = true
        )

    let providedNamespace = "DoxAletheia"
    let assembly = Assembly.GetExecutingAssembly()

    // A named WSDL port, represented by the original Port object.
    let asPortType (port: Port) =

        let portType =
            ProvidedTypeDefinition(
                $"{port.Name}'Port",
                Some typeof<obj>,
                isErased = true
            )

        portType.AddMember(
            ProvidedProperty(
                propertyName = "Value",
                propertyType = typeof<Port>,
                isStatic = false,
                getterCode = fun arguments ->
                    let value =
                        Expr.Coerce(arguments[0], typeof<obj>)

                    <@@ (%%value : obj) :?> Port @@>
            )
        )

        portType

    let asOperationMethods (description: ServiceDescription) : MemberInfo list =

        description.PortTypes
        |> Seq.cast<PortType>
        |> Seq.collect (fun portType ->
            portType.Operations |> Seq.cast<Operation>
        )
        |> Seq.map (fun operation -> operation.Name)
        |> Seq.distinct
        |> Seq.map (fun operationName ->

            ProvidedMethod(
                methodName = operationName,
                parameters = [],
                returnType = typeof<unit>,
                isStatic = false,
                invokeCode = fun _ -> <@@ () @@>
            ) :> MemberInfo

        )
        |> Seq.toList
    // The collection of ports belonging to a particular service.
    let asPortsType (service: Service) =

        let portsType =
            ProvidedTypeDefinition(
                "Ports'Collection",
                Some typeof<obj>,
                isErased = true
            )

        portsType.AddMember(
            ProvidedProperty(
                propertyName = "Collection",
                propertyType = typeof<PortCollection>,
                isStatic = false,
                getterCode = fun arguments ->
                    let value =
                        Expr.Coerce(arguments[0], typeof<obj>)

                    <@@ (%%value : obj) :?> PortCollection @@>
            )
        )

        portsType.AddMembersDelayed(fun () ->
            [
                for port in service.Ports |> Seq.cast<Port> do

                    let providedPortType = asPortType port

                    let portNameExpression =
                        CodeQuotation<string>.expression port.Name
                        |> Expr.Cast<string>

                    yield providedPortType :> MemberInfo

                    yield
                        ProvidedProperty(
                            propertyName = port.Name,
                            propertyType = providedPortType,
                            isStatic = false,
                            getterCode = fun arguments ->

                                let ports =
                                    Expr.Coerce(arguments[0], typeof<obj>)

                                <@@
                                    box (
                                        ((%%ports : obj) :?> PortCollection)
                                            .[%portNameExpression]
                                    )
                                @@>
                        ) :> MemberInfo
            ]
        )

        portsType

    // A named WSDL service, represented by the original Service object.
    let asServiceType (service: Service) =

        let serviceType =
            ProvidedTypeDefinition(
                $"{service.Name}'Service",
                Some typeof<obj>,
                isErased = true
            )

        serviceType.AddMember(
            ProvidedProperty(
                propertyName = "Value",
                propertyType = typeof<Service>,
                isStatic = false,
                getterCode = fun arguments ->
                    let value =
                        Expr.Coerce(arguments[0], typeof<obj>)

                    <@@ (%%value : obj) :?> Service @@>
            )
        )

        serviceType.AddMembersDelayed(fun () ->

            let portsType = asPortsType service

            [
                yield portsType :> MemberInfo

                yield
                    ProvidedProperty(
                        propertyName = "Ports",
                        propertyType = portsType,
                        isStatic = false,
                        getterCode = fun arguments ->

                            let value =
                                Expr.Coerce(arguments[0], typeof<obj>)

                            <@@
                                box (
                                    ((%%value : obj) :?> Service).Ports
                                )
                            @@>
                    ) :> MemberInfo
            ]
        )

        serviceType

    // The collection of services declared by a WSDL document.
    let asServicesType (description: ServiceDescription) =

        let servicesType =
            ProvidedTypeDefinition(
                "Services'Collection",
                Some typeof<obj>,
                isErased = true
            )

        servicesType.AddMember(
            ProvidedProperty(
                propertyName = "Collection",
                propertyType = typeof<ServiceCollection>,
                isStatic = false,
                getterCode = fun arguments ->

                    let value =
                        Expr.Coerce(arguments[0], typeof<obj>)

                    <@@ (%%value : obj) :?> ServiceCollection @@>
            )
        )

        servicesType.AddMembersDelayed(fun () ->
            [
                for service in description.Services |> Seq.cast<Service> do

                    let providedServiceType =
                        asServiceType service

                    let serviceNameExpression =
                        CodeQuotation<string>.expression service.Name
                        |> Expr.Cast<string>

                    yield providedServiceType :> MemberInfo

                    yield
                        ProvidedProperty(
                            propertyName = service.Name,
                            propertyType = providedServiceType,
                            isStatic = false,
                            getterCode = fun arguments ->

                                let services =
                                    Expr.Coerce(arguments[0], typeof<obj>)

                                <@@
                                    box (
                                        ((%%services : obj) :?> ServiceCollection)
                                            .[%serviceNameExpression]
                                    )
                                @@>
                        ) :> MemberInfo
            ]
        )

        servicesType

    // A WSDL document, represented by ServiceDescription.
    let asServiceDescriptionType
        (providedName: string)
        (file: FileInfo) =

        let descriptionType =
            ProvidedTypeDefinition(
                $"{providedName}'ServiceDescription",
                Some typeof<ServiceDescription>,
                isErased = true
            )

        let pathExpression =
            CodeQuotation<string>.expression file.FullName
            |> Expr.Cast<string>

        descriptionType.AddMember(
            ProvidedProperty(
                propertyName = "wsdl",
                propertyType = typeof<XDocument>,
                isStatic = false,
                getterCode = fun _ ->
                    <@@ XDocument.Load(%pathExpression) @@>
            )
        )

        descriptionType.AddMember(
            ProvidedProperty(
                propertyName = "FileInfo",
                propertyType = typeof<FileInfo>,
                isStatic = false,
                getterCode = fun _ ->
                    CodeQuotation<FileInfo>.expression file
            )
        )

        descriptionType.AddMembersDelayed(fun () ->

            let description =
                ServiceDescription.Read(file.FullName)
            asOperationMethods description
(*
            let servicesType =
                asServicesType description
            [
                yield servicesType :> MemberInfo
                
                yield
                    ProvidedProperty(
                        propertyName = "Services",
                        propertyType = servicesType,
                        isStatic = false,
                        getterCode = fun arguments ->

                            let description =
                                Expr.Coerce(
                                    arguments[0],
                                    typeof<ServiceDescription>
                                )

                            <@@
                                box (
                                    (%%description : ServiceDescription).Services
                                )
                            @@>
                    ) :> MemberInfo

            ]
*)

        )

        descriptionType

    // The terminal file becomes a static property, not a nested type
    // bearing the same name as the WSDL file.
    let asServiceDescriptionProperty
        (providedName: string)
        (providedDescriptionType: ProvidedTypeDefinition)
        (file: FileInfo) =

        let pathExpression =
            CodeQuotation<string>.expression file.FullName
            |> Expr.Cast<string>

        ProvidedProperty(
            propertyName = providedName,
            propertyType = providedDescriptionType,
            isStatic = true,
            getterCode = fun _ ->
                <@@ ServiceDescription.Read(%pathExpression) @@>
        )

    // Project directory/moniker nodes as types and terminal WSDLs
    // as static properties.
    let rec asProvidedMembers
        (trieNode: ITrieNode<string, FileInfo>)
        : MemberInfo list =

        [
            for child in trieNode.Children |> Seq.sortBy _.KeyBit do

                if child.Children |> Seq.isEmpty |> not then

                    let navigationType =
                        ProvidedTypeDefinition(
                            child.KeyBit,
                            Some typeof<obj>,
                            isErased = true
                        )

                    navigationType.AddMembersDelayed(fun () ->
                        asProvidedMembers child
                    )

                    yield navigationType :> MemberInfo

                if child.HasValue then

                    let descriptionType =
                        asServiceDescriptionType child.KeyBit child.Value

                    let descriptionProperty =
                        asServiceDescriptionProperty
                            child.KeyBit
                            descriptionType
                            child.Value

                    yield descriptionType :> MemberInfo
                    yield descriptionProperty :> MemberInfo
        ]

    let createType
        (typeName: string)
        (directoryPath: string) =

        let webservicesDirectory =
            DirectoryInfo(directoryPath)

        if not webservicesDirectory.Exists then
            invalidArg
                "directoryPath"
                $"Directory not found: {directoryPath}"

        let wsdlTrie =
            WebServiceDescriptionIndex.get directoryPath

        let provider =
            ProvidedTypeDefinition(
                assembly,
                providedNamespace,
                typeName,
                Some typeof<obj>,
                isErased = true
            )

        provider.AddMembersDelayed(fun () ->
            asProvidedMembers wsdlTrie.Root
        )

        provider

    do
        let provider =
            ProvidedTypeDefinition(
                assembly,
                providedNamespace,
                "WebServiceDescriptionProvider",
                Some typeof<obj>,
                isErased = true
            )

        provider.DefineStaticParameters(
            parameters =
                [
                    ProvidedStaticParameter(
                        "DirectoryPath",
                        typeof<string>
                    )
                ],
            instantiationFunction =
                fun typeName arguments ->

                    let directoryPath =
                        arguments[0] :?> string

                    createType typeName directoryPath
        )

        this.AddNamespace(
            providedNamespace,
            [ provider ]
        )
[<assembly: TypeProviderAssembly>]
do ()
