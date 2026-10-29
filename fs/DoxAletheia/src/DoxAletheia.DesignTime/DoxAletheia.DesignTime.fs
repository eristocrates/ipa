namespace DoxAletheia.DesignTime

open System
open System.IO
open System.Collections.Generic
open System.Reflection
open System.Text.RegularExpressions

open Microsoft.FSharp.Core.CompilerServices
open Microsoft.FSharp.Quotations
open ProviderImplementation.ProvidedTypes

open VDS.RDF
open VDS.Common.Tries
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

open FolkerKinzel.MimeTypes
open System
open Microsoft.FSharp.Quotations
open Microsoft.FSharp.Reflection
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

open CodeProvision
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
        let documentIris =
            documentIrisString.Split(' ', StringSplitOptions.RemoveEmptyEntries ||| StringSplitOptions.TrimEntries)
            |> Array.map Uri
            |> Array.map Iri.ofUri
            |> Array.toList

        let vocabulary =
            { RdfVocabulary.PREFIX(namespacePrefix, namespaceName) with
                documentIris = documentIris }

        let threadSafeGraph = ThreadSafeGraph.ofRdfVocabulary vocabulary
        let ontologyGraph = OntologyGraph.ofRdfVocabulary vocabulary
        
        let classes = vocabulary.ClassMap ontologyGraph 
        let properties =  vocabulary.PropertyMap ontologyGraph
        let owlClasses =  vocabulary.OwlClassMap ontologyGraph
        let owlObjectProperties = vocabulary.OwlObjectPropertyMap ontologyGraph
        let owlDataProperties = vocabulary.OwlDatatypePropertyMap ontologyGraph 
        let owlAnnotationProperties = vocabulary.OwlAnnotationPropertyMap  ontologyGraph 

        let RdfClassTypeDefinition = "RdfClass"  |> CodeProvision.erasedType typeof<Iri>
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

        VocabularyTypeDefinition.AddMember( vocabulary |> CodeProvision.staticProperty "vocabulary\'")
        
        VocabularyTypeDefinition.AddMembersDelayed(fun () ->
            [

              for prefixedName, ontologyProperty in properties |> Map.toSeq do
                  let identity = Expr.Value(prefixedName.identity, typeof<string>)

                  let domainParameterName =
                      ontologyProperty.Domains
                      |> Seq.choose (fun domain -> domain.tryLocalPart)
                      |> Seq.insertAt 0 "domain"
                      |> String.concat "'"

                  let rangeParameterName =
                      ontologyProperty.Ranges
                      |> Seq.choose (fun range -> range.tryLocalPart)
                      |> Seq.insertAt 0 "range"
                      |> String.concat "'"

                  match
                      owlObjectProperties.TryFind prefixedName,
                      owlDataProperties.TryFind prefixedName,
                      owlAnnotationProperties.TryFind prefixedName
                  with
                  | Some objectProperty, None, None ->
                        yield ObjectPropertyIri(PrefixedName prefixedName)  |> CodeProvision.staticProperty OwlObjectPropertyTypeDefinition prefixedName.localName
                    // TODO next rewrite the rest of these cases
                  | None, Some dataProperty, None ->
                      yield DataPropertyIri(PrefixedName prefixedName)  |> CodeProvision.staticProperty OwlDataPropertyTypeDefinition prefixedName.localName
                  | None, None, Some annotationProperty ->
                      yield AnnotationPropertyIri(PrefixedName prefixedName)  |> CodeProvision.staticProperty OwlAnnotationPropertyTypeDefinition prefixedName.localName
                  | _, _, _ ->
                      yield IriPredicate(PrefixedName prefixedName)  |> CodeProvision.staticProperty  prefixedName.localName
            ]

        )

        NamedIndividualTypeDefinition.AddMember NamedIndividualOfClassTypeDefinition

        for KeyValue(prefixedName, ontologyClass) in classes do

            let TermTypeDefinition = prefixedName.localName |> CodeProvision.erasedType typeof<NamedIndividual>

            NamedIndividualOfClassTypeDefinition.AddMember TermTypeDefinition

            NamedIndividualTypeDefinition.AddMemberDelayed(fun () ->
                ProvidedMethod(
                    methodName = prefixedName.localName,
                    parameters = [ ProvidedParameter("iri", typeof<Iri>) ],
                    returnType = TermTypeDefinition,
                    isStatic = true,
                    invokeCode =
                        fun args ->
                            let iri = Expr.Coerce(args[0], typeof<Iri>) 
                            
                            <@@ NamedIndividualIri (%%iri : Iri)  @@>
                ))

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

            let TermTypeDefinition = prefixedName.localName |> CodeProvision.erasedType typeof<AnonymousIndividual>

            AnonymousIndividualOfClassTypeDefinition.AddMember TermTypeDefinition

            AnonymousIndividualTypeDefinition.AddMemberDelayed(fun () ->
                ProvidedMethod(
                    methodName = prefixedName.localName,
                    parameters = [ ProvidedParameter("bnode", typeof<BNode>) ],
                    returnType = TermTypeDefinition,
                    isStatic = true,
                    invokeCode =
                        fun args ->
                            let bnode = Expr.Coerce(args[0], typeof<BNode>)
                            <@@ AnonymousIndividualBNode(%%bnode: BNode) @@>
                ))

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

            for ontologyProperty in ontologyClass.Properties do

                match ontologyProperty.tryLocalPart, ontologyProperty.tryUriNode with
                | Some propertyName, Some propertyNode ->

                    let identity = Expr.Value(propertyNode.Uri.OriginalString, typeof<string>)

                    TermTypeDefinition.AddMembersDelayed(fun () ->
                        [ ProvidedMethod(
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
                          ) ])

                | _ -> ()

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
            [ for prefixedName, ontologyClass in classes |> Map.toSeq do

                  let identity = Expr.Value(prefixedName.identity, typeof<string>)

                  match owlClasses.TryFind prefixedName with
                  | Some owlClass ->
                      yield ClassIri(PrefixedName prefixedName) |> CodeProvision.staticProperty OwlClassTypeDefinition prefixedName.localName
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
                      yield PrefixedName prefixedName |> CodeProvision.staticProperty RdfClassTypeDefinition prefixedName.localName

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

            registryEntries
            |> Array.groupBy _.group
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

    let xml = Xml.Load(xmlFilePath)

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
                                    RdfVocabulary.media_types.prefixedName mime.mimeType.MediaType
                                    |> RdfVocabulary.ofPrefixedName

                                  localName = mime.mimeType.SubType }
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
                                RdfVocabulary.spar_mediatype.prefixedName mime.mimeType.MediaType
                                |> RdfVocabulary.ofPrefixedName

                              localName = mime.mimeType.SubType }
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
                getterCode = fun _ -> Quotation.ofValue (spdx.Measure.MediaType.typedLiteral mime)
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

[<assembly: TypeProviderAssembly>]
do ()
