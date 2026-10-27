#time on

fsi.PrintLength <- 10
fsi.PrintSize <- 100

// fsi.ShowDeclarationValues <- false
#I @"D:\https\com\github\eristocrates\ipa\dll"
#r "SharedKernel.dll"
#r "StringModule.dll"
#r "Iana.dll"
#r @"TopLevelDomain.dll"
#r @"IanaScheme.dll"
#r @"IanaMime.dll"
#r @"IanaMime.dll"
#r "Turtle.dll"
#r "ManualDistributions.dll"
#r "ResourceIdentification.dll"

#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load "PrettierNaming.fsx"
#load "Ast.fsx"

open SharedKernel
open StringModule
open Iana
open Turtle
open ManualDistributions
open ResourceIdentification

#I @"D:\https\com\github\eristocrates\ipa\fsx\Sites"

#load @".paket/load/main.group.fsx"

open AW.Identifiers
open BrowserApi
open BrowserApi.Common
open BrowserApi.Css.Authoring
open CaseConverter
open Dubzer.WhatwgUrl
open Fabulous.AST
open Fantomas.Core
open FolkerKinzel.MimeTypes
open FSharp.Collections.ParallelSeq
open FSharp.Data
open FSharp.Data.Adaptive.Transaction
open FSharp.HashCollections
open FsHttp
open Humanizer
open Iride
open IriTools
open ktsu.Semantics.Paths
open LSL.DataUri
open Meziantou.Framework
open Microsoft.AspNetCore.Http
open ModelingEvolution.Ipv4
open Nager.PublicSuffix
open Nager.PublicSuffix.Models
open Nager.PublicSuffix.RuleProviders
open NLanguageTag
open PuppeteerSharp
open PuppeteerSharp.Cdp
open PuppeteerSharp.Cdp.Messaging
open RDFSharp.Model
open RDFSharp.Model
open System
open System.Collections
open System.Collections.Concurrent
open System.Globalization
open System.Globalization
open System.IO
open System.IO
open System.Linq
open System.Net
open System.Net.Http
open System.Net.Sockets
open System.Numerics
open System.Text
open System.Text
open System.Text
open System.Text.RegularExpressions
open System.Text.Unicode
open System.Threading
open System.Threading.Tasks
open System.Security.Cryptography
open System.Web
open System.Xml
open Tavis.UriTemplates
open TextCopy
open Universal.Common
open VDS.Common.Tries
open VDS.RDF
open VDS.RDF.Ontology
open VDS.RDF.Parsing
open VDS.RDF.Query
open VDS.RDF.Query.Builder
open VDS.RDF.Query.Datasets
open VDS.RDF.Query.Expressions
open VDS.RDF.Query.Patterns
open VDS.RDF.Storage
open RDFSharp
open RDFSharp.Model
open OWLSharp.Ontology
open WebDriverBiDi
open WebDriverBiDi.BrowsingContext
open WebDriverBiDi.Session

open VDS.RDF.Query.Paths
open System.Xml.Linq
open Lumoin.Base
open Lumoin.Veritas.Core
open Lumoin.Veritas.Core.Diagnostics
// Core graph storage and indexing
open Lumoin.Veritas.Core

// Graph computation primitives
open Lumoin.Veritas.Rdf
open Lumoin.Veritas.Turtle

// SPARQL querying
open Lumoin.Veritas.Sparql

// RDF Dataset Canonicalization
open Lumoin.Veritas.Canonicalization

// SHACL validation
open Lumoin.Veritas.Shacl

// OWL 2 reasoning
open Lumoin.Veritas.Owl
open FSharpPlus
open FSharpPlus.Data
open NLanguageTag

let personalUriTemplate = UriTemplate "https://eristocrates.dev/ontology/{namespacePrefix}/{localName}"
let dotNetRdfLoader = new Loader()
type String with
    member this.asUtf8Bytes = Encoding.UTF8.GetBytes this
    member this.asUtf8String = Utf8String this.asUtf8Bytes
type IriReference with
    member this.identity = this.ToString()

type InitialTextDirection =
    | Ltr
    | Rtl

    member this.identity = this.ToString().ToLowerInvariant()
type LanguageTag with
    member this.identity = this.ToString().ToLowerInvariant()

type DataPoint =
    | NamedPoint of NamedReference
    | AnonymousPoint of AnonymousReference
    | LiteralPoint of LiteralValue
    | ArcPoint of DirectedArc
    | FormulaPoint of Formula
and [<CustomEquality; CustomComparison>] DirectedArc = {
    sinsignId: Guid
    legisignId: DataPoint
    fromPoint: DataPoint
    toPoint: DataPoint
} with

    member this.identity = this.sinsignId

    override this.Equals(other: obj) =
        match other with
        | :? DirectedArc as other -> this.identity = other.identity

        | _ -> false

    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? DirectedArc as other -> compare this.identity other.identity

            | _ -> invalidArg (nameof other) $"Cannot compare {typeof<DirectedArc>.Name} with {other.GetType().Name}"
and [<CustomEquality; CustomComparison>] NamedReference =
    | IRIREF of IriReference
    | CURIE of PrefixedName

    member this.identity =
        match this with
        | IRIREF iri -> iri.identity
        | CURIE prefixedName -> prefixedName.identity

    override this.Equals(other: obj) =
        match other with
        | :? NamedReference as other -> this.identity = other.identity
        | _ -> false

    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? NamedReference as other -> compare this.identity other.identity
            | _ -> invalidArg (nameof other) $"Cannot compare {typeof<NamedReference>.Name} with {other.GetType().Name}"
and [<CustomEquality; CustomComparison>] NamespaceName = {
    namespaceIri: NamedReference
    turtlePaths: string list
    prefixLabels: string list
} with

    member this.identity = this.namespaceIri.identity
    member this.prefixedName(localName: string) = {
        namespaceName = this
        localName = localName
    }
    member this.curie(localName: string) = this.prefixedName localName |> CURIE

    static member rdf = {
        namespaceIri = IRIREF <| IriReference "http://www.w3.org/1999/02/22-rdf-syntax-ns#"
        turtlePaths = []
        prefixLabels = [ "rdf" ]
    }
    static member xsd = {
        namespaceIri = IRIREF <| IriReference "http://www.w3.org/2001/XMLSchema#"
        turtlePaths = []
        prefixLabels = [ "xsd"; "xs" ]
    }
    override this.Equals(other: obj) =
        match other with
        | :? NamespaceName as other -> this.identity = other.identity
        | _ -> false

    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? NamespaceName as other -> compare this.identity other.identity
            | _ -> invalidArg (nameof other) "Incompatible comparison"
and [<CustomEquality; CustomComparison>] PrefixedName = {
    namespaceName: NamespaceName
    localName: string
} with

    member this.identity = this.namespaceName.identity + this.localName

    override this.Equals(other: obj) =
        match other with
        | :? PrefixedName as other -> this.identity = other.identity
        | _ -> false

    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? PrefixedName as other -> compare this.identity other.identity
            | _ -> invalidArg (nameof other) "Incompatible comparison"
and [<CustomEquality; CustomComparison>] AnonymousReference = {
    sinsignId: Guid
    localIdentifier: string
} with

    member this.identity = this.sinsignId.ToString("N")

    override this.Equals(other: obj) =
        match other with
        | :? AnonymousReference as other -> this.identity = other.identity

        | _ -> false

    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? AnonymousReference as other -> compare this.identity other.identity

            | _ -> invalidArg (nameof other) $"Cannot compare {typeof<AnonymousReference>.Name} with {other.GetType().Name}"
and [<StructuralEquality; StructuralComparison>] LiteralIdentity = {
    lexicalForm: string
    datatypeIri: NamedReference
    languageTag: string option
    baseDirection: InitialTextDirection option
}

and [<CustomEquality; CustomComparison>] LiteralValue =
    | PlainLiteral of PlainLiteral
    | TypedLiteral of TypedLiteral
    | EmbeddedLiteral of EmbeddedLiteral

    member this.identity =
        match this with

        | PlainLiteral(SimpleLiteral lexicalForm) -> lexicalForm.identity

        | PlainLiteral(LanguageLiteral languageString) -> languageString.identity

        | TypedLiteral literal -> literal.identity

        | EmbeddedLiteral embedded -> embedded.identity

    override this.Equals(other: obj) =
        match other with
        | :? LiteralValue as other -> this.identity = other.identity

        | _ -> false

    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? LiteralValue as other -> compare this.identity other.identity

            | _ -> invalidArg (nameof other) $"Cannot compare {typeof<LiteralValue>.Name} with {other.GetType().Name}"
and PlainLiteral =
    | SimpleLiteral of StringLiteral
    | LanguageLiteral of LanguageString
and StringLiteral = {
    simpleString: string
} with

    member this.identity = {
        lexicalForm = this.simpleString
        datatypeIri = NamespaceName.xsd.curie "string"
        languageTag = None
        baseDirection = None
    }

and LanguageString = {
    lexicalForm: string
    languageTag: LanguageTag
    baseDirection: InitialTextDirection option
} with

    member this.identity = {
        lexicalForm = this.lexicalForm

        datatypeIri =
            match this.baseDirection with
            | None -> NamespaceName.rdf.curie "langString"

            | Some _ -> NamespaceName.rdf.curie "dirLangString"

        languageTag = Some this.languageTag.identity

        baseDirection = this.baseDirection
    }
and TypedLiteral = {
    lexicalForm: string
    datatypeIri: NamedReference
} with

    member this.identity = {

        lexicalForm = this.lexicalForm

        datatypeIri = this.datatypeIri

        languageTag = None

        baseDirection = None
    }

and EmbeddedLiteral =
    | EmbeddedHtml of HtmlLiteral
    | EmbeddedXml of XmlLiteral
    | EmbeddedJson of JsonLiteral

    member this.identity =
        match this with
        | EmbeddedHtml htmlLiteral -> htmlLiteral.identity
        | EmbeddedXml xmlLiteral -> xmlLiteral.identity
        | EmbeddedJson jsonLiteral -> jsonLiteral.identity
and HtmlLiteral = {
    htmlString: string
} with

    member this.datatypeIri = NamespaceName.rdf.curie "HTML"

    member this.identity = {
        lexicalForm = this.htmlString
        datatypeIri = this.datatypeIri
        languageTag = None
        baseDirection = None
    }
and XmlLiteral = {
    xmlString: string
} with

    member this.datatypeIri = NamespaceName.rdf.curie "XMLLiteral"
    member this.identity = {
        lexicalForm = this.xmlString
        datatypeIri = this.datatypeIri
        languageTag = None
        baseDirection = None
    }
and JsonLiteral = {
    jsonString: string
} with

    member this.datatypeIri = NamespaceName.rdf.curie "JSON"

    member this.identity = {
        lexicalForm = this.jsonString
        datatypeIri = this.datatypeIri
        languageTag = None
        baseDirection = None
    }

and Formula = {
    formulaStatements: HashSet<TripleStatement>
}
and SubjectVertex =
    | NamedSubject of NamedReference
    | AnonymousSubject of AnonymousReference
and PredicateEdge = NamedPredicate of NamedReference
and ObjectVertex =
    | NamedObject of NamedReference
    | AnonymousObject of AnonymousReference
    | LiteralObject of LiteralValue
    | AssertionObject of TripleStatement
and Vertex =
    | SubjectVertex of SubjectVertex
    | ObjectVertex of ObjectVertex
and PredicateObjectList = {
    predicateEdge: PredicateEdge
    objectVerticies: ObjectVertex list
}
and TripleStatement = {
    curSubject: SubjectVertex
    curPredicate: PredicateEdge
    curObject: ObjectVertex
}

and QuadStatement = {
    statement: TripleStatement
    context: SubjectVertex
}

type NamespaceName with
    member this.terminal = this.identity.ToCharArray() |> Array.last
    member this.UrlPattern = UrlPattern.Create(sprintf "%s{:localName}" this.identity)
type Uri with
    static member ofNamespaceName(namespaceName: NamespaceName) = Uri namespaceName.identity
type UriNode with
    static member ofNamespaceName(namespaceName: NamespaceName) =
        UriNode(Uri.ofNamespaceName namespaceName)
type INode with
    static member ofNamespaceName(namespaceName: NamespaceName) : INode = UriNode.ofNamespaceName namespaceName
type IRefNode with
    static member ofNamespaceName(namespaceName: NamespaceName) : IRefNode = UriNode.ofNamespaceName namespaceName
type NamedNode with
    static member ofNamespaceName(namespaceName: NamespaceName) =
        NamedNode namespaceName.identity.asUtf8String
type RDFResource with
    static member ofNamespaceName(namespaceName: NamespaceName) = new RDFResource(namespaceName.identity)
    static member ofNamedReference(namedReference: NamedReference) =
        new RDFResource(namedReference.identity)
type ThreadSafeGraph with
    static member ofNamespaceName(namespaceName: NamespaceName) =
        let graph = new ThreadSafeGraph(IRefNode.ofNamespaceName namespaceName)
        namespaceName.turtlePaths
        |> List.map (fun turtlePath -> dotNetRdfLoader.LoadGraph(graph, Uri turtlePath))
        |> ignore
        graph

type RDFGraph with
    static member ofNamespaceName(namespaceName: NamespaceName) =
        let RDFTriples =
            namespaceName.turtlePaths
            |> Seq.collect (fun turtlePath -> RDFGraph.FromFile(RDFModelEnums.RDFFormats.Turtle, turtlePath, true))
            |> Generic.List
        new RDFGraph(RDFTriples)
type OWLOntologyView with
    static member ofNamespaceName(namespaceName: NamespaceName) =
        new OWLOntologyView(OWLOntology.FromRDFGraphAsync(RDFGraph.ofNamespaceName namespaceName).Result)

type IGraph with
    member this.AllUriNodes =
        this.AllNodes
        |> Seq.choose (fun inode ->
            match inode with
            | :? UriNode as uriNode -> Some uriNode
            | _ -> None)
    member this.prefixedNames(namespaceName: NamespaceName) =
        this.AllUriNodes
        |> Seq.choose (fun uriNode ->

            match namespaceName.UrlPattern.Match uriNode.Uri.OriginalString |> Option.ofObj with
            | Some urlPatternMatch when namespaceName.terminal = '#' -> namespaceName.curie urlPatternMatch.Hash.Groups["localName"] |> Some
            | Some urlPatternMatch -> namespaceName.curie urlPatternMatch.Pathname.Groups["localName"] |> Some
            | None -> None

        )

type AnnotationAxiom =
    | AnnotationAssertionAxiom of OWLAnnotationAssertion
    | AnnotationPropertyDomainAxiom of OWLAnnotationPropertyDomain
    | AnnotationPropertyRangeAxiom of OWLAnnotationPropertyRange
    | SubAnnotationPropertyOfAxiom of OWLSubAnnotationPropertyOf

    static member CheckHasAnnotationAxiom = OWLAnnotationAxiomHelper.CheckHasAnnotationAxiom
    static member CheckIsSubAnnotationPropertyOf = OWLAnnotationAxiomHelper.CheckIsSubAnnotationPropertyOf
    static member CheckIsSuperAnnotationPropertyOf = OWLAnnotationAxiomHelper.CheckIsSuperAnnotationPropertyOf
    static member DeclareAnnotationAxiom = OWLAnnotationAxiomHelper.DeclareAnnotationAxiom
    static member GetAnnotationAxiomsOfType = OWLAnnotationAxiomHelper.GetAnnotationAxiomsOfType
    static member GetSubAnnotationPropertiesOf = OWLAnnotationAxiomHelper.GetSubAnnotationPropertiesOf
    static member GetSuperAnnotationPropertiesOf = OWLAnnotationAxiomHelper.GetSuperAnnotationPropertiesOf

type AssertionAxiom =
    | ClassAssertionAxiom of OWLClassAssertion
    | DataPropertyAssertionAxiom of OWLDataPropertyAssertion
    | DifferentIndividualsAxiom of OWLDifferentIndividuals
    | NegativeDataPropertyAssertionAxiom of OWLNegativeDataPropertyAssertion
    | NegativeObjectPropertyAssertionAxiom of OWLNegativeObjectPropertyAssertion
    | ObjectPropertyAssertionAxiom of OWLObjectPropertyAssertion
    | SameIndividualAxiom of OWLSameIndividual

    static member CheckAreDifferentIndividuals = OWLAssertionAxiomHelper.CheckAreDifferentIndividuals
    static member CheckHasAssertionAxiom = OWLAssertionAxiomHelper.CheckHasAssertionAxiom
    static member CheckIsIndividualOf = OWLAssertionAxiomHelper.CheckIsIndividualOf
    static member CheckIsLiteralOf = OWLAssertionAxiomHelper.CheckIsLiteralOf
    static member CheckIsNegativeIndividualOf = OWLAssertionAxiomHelper.CheckIsNegativeIndividualOf
    static member CheckIsSameIndividual = OWLAssertionAxiomHelper.CheckIsSameIndividual
    static member DeclareAssertionAxiom = OWLAssertionAxiomHelper.DeclareAssertionAxiom
    static member GetAssertionAxiomsOfType = OWLAssertionAxiomHelper.GetAssertionAxiomsOfType
    static member GetDifferentIndividuals = OWLAssertionAxiomHelper.GetDifferentIndividuals
    static member GetIndividualsOf = OWLAssertionAxiomHelper.GetIndividualsOf
    static member GetSameIndividuals = OWLAssertionAxiomHelper.GetSameIndividuals

type OWLClassAxiom =
    | DisjointClassesAxiom of OWLDisjointClasses
    | DisjointUnionAxiom of OWLDisjointUnion
    | EquivalentClassesAxiom of OWLEquivalentClasses
    | SubClassOfAxiom of OWLSubClassOf

    static member CheckAreDisjointClasses = OWLClassAxiomHelper.CheckAreDisjointClasses
    static member CheckAreEquivalentClasses = OWLClassAxiomHelper.CheckAreEquivalentClasses
    static member CheckHasClassAxiom = OWLClassAxiomHelper.CheckHasClassAxiom
    static member CheckIsSubClassOf = OWLClassAxiomHelper.CheckIsSubClassOf
    static member CheckIsSuperClassOf = OWLClassAxiomHelper.CheckIsSuperClassOf
    static member DeclareClassAxiom = OWLClassAxiomHelper.DeclareClassAxiom
    static member GetClassAxiomsOfType = OWLClassAxiomHelper.GetClassAxiomsOfType
    static member GetDisjointClasses = OWLClassAxiomHelper.GetDisjointClasses
    static member GetEquivalentClasses = OWLClassAxiomHelper.GetEquivalentClasses
    static member GetSubClassesOf = OWLClassAxiomHelper.GetSubClassesOf
    static member GetSuperClassesOf = OWLClassAxiomHelper.GetSuperClassesOf
type OWLDataPropertyAxiom =
    | DataPropertyDomainAxiom of OWLDataPropertyDomain
    | DataPropertyRangeAxiom of OWLDataPropertyRange
    | DisjointDataPropertiesAxiom of OWLDisjointDataProperties
    | EquivalentDataPropertiesAxiom of OWLEquivalentDataProperties
    | FunctionalDataPropertyAxiom of OWLFunctionalDataProperty
    | SubDataPropertyOfAxiom of OWLSubDataPropertyOf

    static member CheckAreDisjointDataProperties = OWLDataPropertyAxiomHelper.CheckAreDisjointDataProperties
    static member CheckAreEquivalentDataProperties = OWLDataPropertyAxiomHelper.CheckAreEquivalentDataProperties
    static member CheckHasDataPropertyAxiom = OWLDataPropertyAxiomHelper.CheckHasDataPropertyAxiom
    static member CheckHasFunctionalDataProperty = OWLDataPropertyAxiomHelper.CheckHasFunctionalDataProperty
    static member CheckIsSubDataPropertyOf = OWLDataPropertyAxiomHelper.CheckIsSubDataPropertyOf
    static member CheckIsSuperDataPropertyOf = OWLDataPropertyAxiomHelper.CheckIsSuperDataPropertyOf
    static member DeclareDataPropertyAxiom = OWLDataPropertyAxiomHelper.DeclareDataPropertyAxiom
    static member GetDataPropertyAxiomsOfType = OWLDataPropertyAxiomHelper.GetDataPropertyAxiomsOfType
    static member GetDisjointDataProperties = OWLDataPropertyAxiomHelper.GetDisjointDataProperties
    static member GetEquivalentDataProperties = OWLDataPropertyAxiomHelper.GetEquivalentDataProperties
    static member GetSubDataPropertiesOf = OWLDataPropertyAxiomHelper.GetSubDataPropertiesOf
    static member GetSuperDataPropertiesOf = OWLDataPropertyAxiomHelper.GetSuperDataPropertiesOf

type OWLObjectPropertyAxiom =
    | AsymmetricObjectPropertyAxiom of OWLAsymmetricObjectProperty
    | DisjointObjectPropertiesAxiom of OWLDisjointObjectProperties
    | EquivalentObjectPropertiesAxiom of OWLEquivalentObjectProperties
    | FunctionalObjectPropertyAxiom of OWLFunctionalObjectProperty
    | InverseFunctionalObjectPropertyAxiom of OWLInverseFunctionalObjectProperty
    | InverseObjectPropertiesAxiom of OWLInverseObjectProperties
    | IrreflexiveObjectPropertyAxiom of OWLIrreflexiveObjectProperty
    | ObjectPropertyDomainAxiom of OWLObjectPropertyDomain
    | ObjectPropertyRangeAxiom of OWLObjectPropertyRange
    | ReflexiveObjectPropertyAxiom of OWLReflexiveObjectProperty
    | SubObjectPropertyOfAxiom of OWLSubObjectPropertyOf
    | SymmetricObjectPropertyAxiom of OWLSymmetricObjectProperty
    | TransitiveObjectPropertyAxiom of OWLTransitiveObjectProperty

    static member CheckAreDisjointObjectProperties = OWLObjectPropertyAxiomHelper.CheckAreDisjointObjectProperties
    static member CheckAreEquivalentObjectProperties = OWLObjectPropertyAxiomHelper.CheckAreEquivalentObjectProperties
    static member CheckHasAsymmetricObjectProperty = OWLObjectPropertyAxiomHelper.CheckHasAsymmetricObjectProperty
    static member CheckHasFunctionalObjectProperty = OWLObjectPropertyAxiomHelper.CheckHasFunctionalObjectProperty
    static member CheckHasInverseFunctionalObjectProperty = OWLObjectPropertyAxiomHelper.CheckHasInverseFunctionalObjectProperty
    static member CheckHasIrreflexiveObjectProperty = OWLObjectPropertyAxiomHelper.CheckHasIrreflexiveObjectProperty
    static member CheckHasObjectPropertyAxiom = OWLObjectPropertyAxiomHelper.CheckHasObjectPropertyAxiom
    static member CheckHasReflexiveObjectProperty = OWLObjectPropertyAxiomHelper.CheckHasReflexiveObjectProperty
    static member CheckHasSymmetricObjectProperty = OWLObjectPropertyAxiomHelper.CheckHasSymmetricObjectProperty
    static member CheckHasTransitiveObjectProperty = OWLObjectPropertyAxiomHelper.CheckHasTransitiveObjectProperty
    static member CheckIsSubObjectPropertyOf = OWLObjectPropertyAxiomHelper.CheckIsSubObjectPropertyOf
    static member CheckIsSuperObjectPropertyOf = OWLObjectPropertyAxiomHelper.CheckIsSuperObjectPropertyOf
    static member DeclareObjectPropertyAxiom = OWLObjectPropertyAxiomHelper.DeclareObjectPropertyAxiom
    static member GetDisjointObjectProperties = OWLObjectPropertyAxiomHelper.GetDisjointObjectProperties
    static member GetEquivalentObjectProperties = OWLObjectPropertyAxiomHelper.GetEquivalentObjectProperties
    static member GetObjectPropertyAxiomsOfType = OWLObjectPropertyAxiomHelper.GetObjectPropertyAxiomsOfType
    static member GetSubObjectPropertiesOf = OWLObjectPropertyAxiomHelper.GetSubObjectPropertiesOf
    static member GetSuperObjectPropertiesOf = OWLObjectPropertyAxiomHelper.GetSuperObjectPropertiesOf
type DeclarationAxiom =
    | IndividualDeclaration of OWLDeclaration
    | ClassDeclaration of OWLDeclaration
    | AnnotationPropertyDeclaration of OWLDeclaration
    | DataPropertyDeclaration of OWLDeclaration
    | ObjectPropertyDeclaration of OWLDeclaration

type OWLOntology with

    member this.owlClasses =
        this.DeclarationAxioms
        |> Seq.choose (fun axiom ->
            match axiom.Entity with
            | :? OWLClass as owlClass -> Some owlClass
            | _ -> None)
        |> Seq.toArray
    member this.owlDatatypes =
        this.DeclarationAxioms
        |> Seq.choose (fun axiom ->
            match axiom.Entity with
            | :? OWLDatatype as owlDatatype -> Some owlDatatype
            | _ -> None)
        |> Seq.toArray
    member this.owlObjectProperties =
        this.DeclarationAxioms
        |> Seq.choose (fun axiom ->
            match axiom.Entity with
            | :? OWLObjectProperty as owlObjectProperty -> Some owlObjectProperty
            | _ -> None)
        |> Seq.toArray
    member this.owlDataProperties =
        this.DeclarationAxioms
        |> Seq.choose (fun axiom ->
            match axiom.Entity with
            | :? OWLDataProperty as owlDataProperty -> Some owlDataProperty
            | _ -> None)
        |> Seq.toArray
    member this.owlAnnotationProperties =
        this.DeclarationAxioms
        |> Seq.choose (fun axiom ->
            match axiom.Entity with
            | :? OWLAnnotationProperty as owlAnnotationProperty -> Some owlAnnotationProperty
            | _ -> None)
        |> Seq.toArray
    member this.owlNamedIndividuals =
        this.DeclarationAxioms
        |> Seq.choose (fun axiom ->
            match axiom.Entity with
            | :? OWLNamedIndividual as owlNamedIndividual -> Some owlNamedIndividual
            | _ -> None)
        |> Seq.toArray
    member this.annotationAxioms =
        this.AnnotationAxioms
        |> Seq.map (fun axiom ->
            match axiom with
            | :? OWLAnnotationAssertion as annotationAssertion -> AnnotationAssertionAxiom annotationAssertion
            | :? OWLAnnotationPropertyDomain as annotationPropertyDomain -> AnnotationPropertyDomainAxiom annotationPropertyDomain
            | :? OWLAnnotationPropertyRange as annotationPropertyRange -> AnnotationPropertyRangeAxiom annotationPropertyRange
            | :? OWLSubAnnotationPropertyOf as subAnnotationPropertyOf -> SubAnnotationPropertyOfAxiom subAnnotationPropertyOf)
        |> Seq.toArray
    member this.annotationAssertions =
        this.annotationAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | AnnotationAssertionAxiom annotationAssertion -> Some annotationAssertion
            | _ -> None)
    member this.annotationPropertyDomains =
        this.annotationAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | AnnotationPropertyDomainAxiom annotationPropertyDomain -> Some annotationPropertyDomain
            | _ -> None)
    member this.annotationPropertyRanges =
        this.annotationAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | AnnotationPropertyRangeAxiom annotationPropertyRange -> Some annotationPropertyRange
            | _ -> None)
    member this.subAnnotationProperties =
        this.annotationAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | SubAnnotationPropertyOfAxiom subAnnotationPropertyOf -> Some subAnnotationPropertyOf
            | _ -> None)

    member this.assertionAxioms =
        this.AssertionAxioms
        |> Seq.map (fun axiom ->
            match axiom with
            | :? OWLClassAssertion as classAssertion -> ClassAssertionAxiom classAssertion
            | :? OWLDataPropertyAssertion as dataPropertyAssertion -> DataPropertyAssertionAxiom dataPropertyAssertion
            | :? OWLDifferentIndividuals as differentIndividuals -> DifferentIndividualsAxiom differentIndividuals
            | :? OWLNegativeDataPropertyAssertion as negativeDataPropertyAssertion -> NegativeDataPropertyAssertionAxiom negativeDataPropertyAssertion
            | :? OWLNegativeObjectPropertyAssertion as negativeObjectPropertyAssertion -> NegativeObjectPropertyAssertionAxiom negativeObjectPropertyAssertion
            | :? OWLObjectPropertyAssertion as objectPropertyAssertion -> ObjectPropertyAssertionAxiom objectPropertyAssertion
            | :? OWLSameIndividual as sameIndividual -> SameIndividualAxiom sameIndividual)
        |> Seq.toArray
    member this.classAssertions =
        this.assertionAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | ClassAssertionAxiom classAssertion -> Some classAssertion
            | _ -> None)
    member this.dataPropertyAssertion =
        this.assertionAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | DataPropertyAssertionAxiom dataPropertyAssertion -> Some dataPropertyAssertion
            | _ -> None)
    member this.differentIndividuals =
        this.assertionAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | DifferentIndividualsAxiom differentIndividuals -> Some differentIndividuals
            | _ -> None)
    member this.negativeDataPropertyAssertion =
        this.assertionAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | NegativeDataPropertyAssertionAxiom negativeDataPropertyAssertion -> Some negativeDataPropertyAssertion
            | _ -> None)
    member this.negativeObjectPropertyAssertion =
        this.assertionAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | NegativeObjectPropertyAssertionAxiom negativeObjectPropertyAssertion -> Some negativeObjectPropertyAssertion
            | _ -> None)
    member this.objectPropertyAssertion =
        this.assertionAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | ObjectPropertyAssertionAxiom objectPropertyAssertion -> Some objectPropertyAssertion
            | _ -> None)
    member this.sameIndividual =
        this.assertionAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | SameIndividualAxiom sameIndividual -> Some sameIndividual
            | _ -> None)

    member this.classAxioms =
        this.ClassAxioms
        |> Seq.map (fun axiom ->
            match axiom with
            | :? OWLDisjointClasses as disjointClasses -> DisjointClassesAxiom disjointClasses
            | :? OWLDisjointUnion as disjointUnion -> DisjointUnionAxiom disjointUnion
            | :? OWLEquivalentClasses as equivalentClasses -> EquivalentClassesAxiom equivalentClasses
            | :? OWLSubClassOf as subClassOf -> SubClassOfAxiom subClassOf)
        |> Seq.toArray

    member this.disjointClasses =
        this.classAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | DisjointClassesAxiom disjointClasses -> Some disjointClasses
            | _ -> None)
    member this.disjointUnion =
        this.classAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | DisjointUnionAxiom disjointUnion -> Some disjointUnion
            | _ -> None)
    member this.equivalentClasses =
        this.classAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | EquivalentClassesAxiom equivalentClasses -> Some equivalentClasses
            | _ -> None)
    member this.subClassOfAxioms =
        this.classAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | SubClassOfAxiom subClassOf -> Some subClassOf
            | _ -> None)
    member this.dataPropertyAxioms =
        this.DataPropertyAxioms
        |> Seq.map (fun axiom ->
            match axiom with
            | :? OWLDataPropertyDomain as dataPropertyDomain -> DataPropertyDomainAxiom dataPropertyDomain
            | :? OWLDataPropertyRange as dataPropertyRange -> DataPropertyRangeAxiom dataPropertyRange
            | :? OWLDisjointDataProperties as disjointDataProperties -> DisjointDataPropertiesAxiom disjointDataProperties
            | :? OWLEquivalentDataProperties as equivalentDataProperties -> EquivalentDataPropertiesAxiom equivalentDataProperties
            | :? OWLFunctionalDataProperty as functionalDataProperty -> FunctionalDataPropertyAxiom functionalDataProperty
            | :? OWLSubDataPropertyOf as subDataPropertyOf -> SubDataPropertyOfAxiom subDataPropertyOf)
        |> Seq.toArray
    member this.dataPropertyDomain =
        this.dataPropertyAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | DataPropertyDomainAxiom dataPropertyDomain -> Some dataPropertyDomain
            | _ -> None)
    member this.dataPropertyRange =
        this.dataPropertyAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | DataPropertyRangeAxiom dataPropertyRange -> Some dataPropertyRange
            | _ -> None)
    member this.disjointDataProperties =
        this.dataPropertyAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | DisjointDataPropertiesAxiom disjointDataProperties -> Some disjointDataProperties
            | _ -> None)
    member this.equivalentDataProperties =
        this.dataPropertyAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | EquivalentDataPropertiesAxiom equivalentDataProperties -> Some equivalentDataProperties
            | _ -> None)
    member this.functionalDataProperty =
        this.dataPropertyAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | FunctionalDataPropertyAxiom functionalDataProperty -> Some functionalDataProperty
            | _ -> None)
    member this.subDataPropertyOf =
        this.dataPropertyAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | SubDataPropertyOfAxiom subDataPropertyOf -> Some subDataPropertyOf
            | _ -> None)

    member this.objectPropertyAxioms =
        this.ObjectPropertyAxioms
        |> Seq.map (fun axiom ->
            match axiom with
            | :? OWLAsymmetricObjectProperty as asymmetricObjectProperty -> AsymmetricObjectPropertyAxiom asymmetricObjectProperty
            | :? OWLDisjointObjectProperties as disjointObjectProperties -> DisjointObjectPropertiesAxiom disjointObjectProperties
            | :? OWLEquivalentObjectProperties as equivalentObjectProperties -> EquivalentObjectPropertiesAxiom equivalentObjectProperties
            | :? OWLFunctionalObjectProperty as functionalObjectProperty -> FunctionalObjectPropertyAxiom functionalObjectProperty
            | :? OWLInverseFunctionalObjectProperty as inverseFunctionalObjectProperty -> InverseFunctionalObjectPropertyAxiom inverseFunctionalObjectProperty
            | :? OWLInverseObjectProperties as inverseObjectProperties -> InverseObjectPropertiesAxiom inverseObjectProperties
            | :? OWLIrreflexiveObjectProperty as irreflexiveObjectProperty -> IrreflexiveObjectPropertyAxiom irreflexiveObjectProperty
            | :? OWLObjectPropertyDomain as objectPropertyDomain -> ObjectPropertyDomainAxiom objectPropertyDomain
            | :? OWLObjectPropertyRange as objectPropertyRange -> ObjectPropertyRangeAxiom objectPropertyRange
            | :? OWLReflexiveObjectProperty as reflexiveObjectProperty -> ReflexiveObjectPropertyAxiom reflexiveObjectProperty
            | :? OWLSubObjectPropertyOf as subObjectPropertyOf -> SubObjectPropertyOfAxiom subObjectPropertyOf
            | :? OWLSymmetricObjectProperty as symmetricObjectProperty -> SymmetricObjectPropertyAxiom symmetricObjectProperty
            | :? OWLTransitiveObjectProperty as transitiveObjectProperty -> TransitiveObjectPropertyAxiom transitiveObjectProperty)
        |> Seq.toArray

    member this.asymmetricObjectProperty =
        this.objectPropertyAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | AsymmetricObjectPropertyAxiom asymmetricObjectProperty -> Some asymmetricObjectProperty
            | _ -> None)
    member this.disjointObjectProperties =
        this.objectPropertyAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | DisjointObjectPropertiesAxiom disjointObjectProperties -> Some disjointObjectProperties
            | _ -> None)
    member this.equivalentObjectProperties =
        this.objectPropertyAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | EquivalentObjectPropertiesAxiom equivalentObjectProperties -> Some equivalentObjectProperties
            | _ -> None)
    member this.functionalObjectProperty =
        this.objectPropertyAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | FunctionalObjectPropertyAxiom functionalObjectProperty -> Some functionalObjectProperty
            | _ -> None)
    member this.inverseFunctionalObjectProperty =
        this.objectPropertyAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | InverseFunctionalObjectPropertyAxiom inverseFunctionalObjectProperty -> Some inverseFunctionalObjectProperty
            | _ -> None)
    member this.inverseObjectProperties =
        this.objectPropertyAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | InverseObjectPropertiesAxiom inverseObjectProperties -> Some inverseObjectProperties
            | _ -> None)
    member this.irreflexiveObjectProperty =
        this.objectPropertyAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | IrreflexiveObjectPropertyAxiom irreflexiveObjectProperty -> Some irreflexiveObjectProperty
            | _ -> None)
    member this.objectPropertyDomain =
        this.objectPropertyAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | ObjectPropertyDomainAxiom objectPropertyDomain -> Some objectPropertyDomain
            | _ -> None)
    member this.objectPropertyRange =
        this.objectPropertyAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | ObjectPropertyRangeAxiom objectPropertyRange -> Some objectPropertyRange
            | _ -> None)
    member this.reflexiveObjectProperty =
        this.objectPropertyAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | ReflexiveObjectPropertyAxiom reflexiveObjectProperty -> Some reflexiveObjectProperty
            | _ -> None)
    member this.subObjectPropertyOf =
        this.objectPropertyAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | SubObjectPropertyOfAxiom subObjectPropertyOf -> Some subObjectPropertyOf
            | _ -> None)
    member this.symmetricObjectProperty =
        this.objectPropertyAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | SymmetricObjectPropertyAxiom symmetricObjectProperty -> Some symmetricObjectProperty
            | _ -> None)
    member this.transitiveObjectProperty =
        this.objectPropertyAxioms
        |> Array.choose (fun axiom ->
            match axiom with
            | TransitiveObjectPropertyAxiom transitiveObjectProperty -> Some transitiveObjectProperty
            | _ -> None)

type OWLObjectPropertyExpression with
    member this.Assert(toIndividual: OWLNamedIndividual) =
        fun (fromIndividual: OWLNamedIndividual) -> OWLObjectPropertyAssertion(this, fromIndividual, toIndividual)

type NamedReference with
    member this.NamedIndividual = RDFResource.ofNamedReference this |> OWLNamedIndividual
    member this.ObjectProperty(toIndividual: OWLNamedIndividual) =
        (RDFResource.ofNamedReference this |> OWLObjectProperty).Assert toIndividual

type RDFResource with
    member this.toNamedReference = this.URI.OriginalString |> IriReference |> IRIREF

    member this.toAnonymousReference =
        if not this.IsBlank then
            invalidArg (nameof this) "Resource is not blank."

        let blankNodeIri = this.URI.OriginalString

        {
            sinsignId =
                match Guid.TryParse this.URI.AbsolutePath with
                | true, guid -> guid
                | false, _ -> new Guid(MD5.HashData(Encoding.UTF8.GetBytes(this.URI.AbsolutePath)))

            localIdentifier = this.URI.OriginalString["bnode:".Length ..]
        }

type RDFLiteral with

    member this.toLiteralValue =
        match this with

        | :? RDFPlainLiteral as plainLiteral ->

            if not (plainLiteral.HasLanguage()) then
                { simpleString = plainLiteral.Value } |> SimpleLiteral |> PlainLiteral

            else
                let languageTag, baseDirection =
                    if plainLiteral.HasDirection() then

                        if plainLiteral.Language.EndsWith("--ltr", StringComparison.OrdinalIgnoreCase) then
                            plainLiteral.Language[.. plainLiteral.Language.Length - 6], Some Ltr

                        else
                            plainLiteral.Language[.. plainLiteral.Language.Length - 6], Some Rtl

                    else
                        plainLiteral.Language, None

                {
                    lexicalForm = plainLiteral.Value
                    languageTag = LanguageTag.Parse languageTag
                    baseDirection = baseDirection
                }
                |> LanguageLiteral
                |> PlainLiteral

        | :? RDFTypedLiteral as typedLiteral ->

            let datatypeIri = typedLiteral.Datatype.URI.OriginalString |> IriReference |> IRIREF

            match datatypeIri.identity with

            | "http://www.w3.org/1999/02/22-rdf-syntax-ns#HTML" -> { htmlString = typedLiteral.Value } |> EmbeddedHtml |> EmbeddedLiteral

            | "http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral" -> { xmlString = typedLiteral.Value } |> EmbeddedXml |> EmbeddedLiteral

            | "http://www.w3.org/1999/02/22-rdf-syntax-ns#JSON" -> { jsonString = typedLiteral.Value } |> EmbeddedJson |> EmbeddedLiteral

            | _ ->
                {
                    lexicalForm = typedLiteral.Value
                    datatypeIri = datatypeIri
                }
                |> TypedLiteral

        | literal -> invalidArg (nameof this) $"Unsupported RDFLiteral type: {literal.GetType().FullName}"

type RDFTriple with

    member this.toTripleStatement =

        {
            curSubject =
                match this.Subject :?> RDFResource with
                | rdfResource when rdfResource.IsBlank -> AnonymousSubject rdfResource.toAnonymousReference
                | rdfResource -> NamedSubject rdfResource.toNamedReference

            curPredicate = (this.Predicate :?> RDFResource).toNamedReference |> NamedPredicate

            curObject =

                match this.Object with
                | :? RDFResource as rdfResource -> NamedObject rdfResource.toNamedReference
                | :? RDFLiteral as rdfLiteral -> rdfLiteral.toLiteralValue |> LiteralObject
                | value -> invalidArg (nameof this.Object) $"Unexpected RDFTriple object type: {value.GetType().FullName}"
        }
type OWLIndividualExpression with
    member this.toNamedReference = this.GetIRI().toNamedReference
type OWLObjectPropertyExpression with
    member this.toNamedReference = this.GetIRI().toNamedReference

type RDFGraph with
    member this.toTripleStatements = this |> Seq.map (fun rdfTriple -> rdfTriple.toTripleStatement) |> Seq.toArray

type OWLObjectPropertyAssertion with
    member this.toTripleStatements = this.ToRDFGraph().toTripleStatements

let personalNamespaceName (namespacePrefix: string) = {
    namespaceIri = IriReference $"https://eristocrates.dev/ontology/{namespacePrefix}/" |> IRIREF
    turtlePaths = []
    prefixLabels = [ namespacePrefix ]
}

module foaf =
    let _namespace = {
        namespaceIri = "http://xmlns.com/foaf/0.1/" |> IriReference |> IRIREF
        turtlePaths = [ @"D:\http\com\xmlns\foaf\0.1&sol;\text\turtle.ttl" ]
        prefixLabels = [ "foaf" ]
    }

module dbug =
    let _namespace = personalNamespaceName "dbug"
    let Alice = _namespace.curie "Alice"
    let knows = _namespace.curie "knows"
    let Bob = _namespace.curie "Bob"

let testAssertion = dbug.Alice.NamedIndividual |> dbug.knows.ObjectProperty dbug.Bob.NamedIndividual
testAssertion.toTripleStatements

let ontologyView = OWLOntologyView.ofNamespaceName foaf._namespace
let ontologyGraph = new OntologyGraph(IRefNode.ofNamespaceName foaf._namespace)
dotNetRdfLoader.LoadGraph(ontologyGraph, Uri foaf._namespace.turtlePaths[0])
