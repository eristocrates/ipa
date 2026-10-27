// TODO use dynamic operator for namespacenames for adhoc local names
// TODO add op_Implicits to literal values

#time on

fsi.PrintLength <- 1
fsi.PrintSize <- 3000
fsi.ShowDeclarationValues <- true

#load @".paket/load/main.group.fsx"

open System
open System.IO
open System.Security.Cryptography
open System.Text
open System.Xml
open VDS.RDF
open RDFSharp.Model
open NLanguageTag
open OWLSharp.Ontology
open Meziantou.Framework
open System
open System.Collections
open System.IO
open System.Globalization
open System.Security.Cryptography
open System.Text
open System.Text.Json
open System.Text.RegularExpressions
open System.Xml
open System.Xml.Linq

open Dubzer.WhatwgUrl
open IriTools
open VDS.RDF
open VDS.RDF.Ontology
open VDS.RDF.Parsing
open RDFSharp.Model
open NLanguageTag
open OWLSharp
open OWLSharp.Extensions
open OWLSharp.Ontology
open OWLSharp.Profiler
open OWLSharp.Reasoner
open OWLSharp.Validator

open FSharp.Data
open FSharpPlus
open Newtonsoft.Json.Linq
open Meziantou.Framework

type Option<'Type> with
    static member ofNullOrWhiteSpace(value: 'Type) =
        if String.IsNullOrWhiteSpace(string value) then
            None
        else
            Some value
    static member tryNullOrWhiteSpace(maybeValue: 'Type option) =
        match maybeValue with
        | Some value when String.IsNullOrWhiteSpace(string value) -> None
        | None -> None
        | Some value -> Some value
type DriveInfo with
    static member byLetter =
        DriveInfo.GetDrives()
        |> Array.map (fun hardDrive -> hardDrive.Name[0], hardDrive)
        |> Map.ofArray
    static member preferredDrive =
        match DriveInfo.byLetter.TryFind 'D' with
        | Some drive -> drive
        | None -> DriveInfo.byLetter['C']
type Guid with
    static member ensure(stringValue: string) =
        match Guid.TryParse stringValue with
        | true, guid -> guid
        | false, _ -> new Guid(MD5.HashData(Encoding.UTF8.GetBytes(stringValue)))
type NonNegativeInteger = uint32

type RDFNamespace with
    member this.UrlPattern = UrlPattern.Create(sprintf "%s{:localName}" this.NamespaceUri.OriginalString)

type RdfConformance =
    | FullNormativeConformance
    | BasicNormativeConformance
    | NonNormativeNonConformance
type NodeType with
    static member normativeSubjectTypes = set [ NodeType.Uri; NodeType.Blank ]
    static member basicNormativeObjectTypes = set [ NodeType.Uri; NodeType.Blank; NodeType.Literal ]
    static member fullNormativeObjectTypes = set [ NodeType.Uri; NodeType.Blank; NodeType.Literal; NodeType.Triple ]
type Triple with
    member this.minimumRdfConformance =
        let subjectIsNormative = NodeType.normativeSubjectTypes.Contains this.Subject.NodeType

        let predicateIsNormative = this.Predicate.NodeType = NodeType.Uri

        let objectIsBasic = NodeType.basicNormativeObjectTypes.Contains this.Object.NodeType

        let objectIsFull = NodeType.fullNormativeObjectTypes.Contains this.Object.NodeType

        match subjectIsNormative, predicateIsNormative, objectIsBasic, objectIsFull with
        | true, true, true, _ -> BasicNormativeConformance

        | true, true, false, true -> FullNormativeConformance

        | _ -> NonNormativeNonConformance
type IGraph with
    member this.BlankNodes =
        this.AllNodes
        |> Seq.choose (fun inode ->
            match inode with
            | :? BlankNode as blankNode -> Some blankNode
            | _ -> None)
        |> Seq.toArray
    member this.UriNodes =
        this.AllNodes
        |> Seq.choose (fun inode ->
            match inode with
            | :? UriNode as uriNode -> Some uriNode
            | _ -> None)
        |> Seq.toArray
    member this.LiteralNodes =
        this.AllNodes
        |> Seq.choose (fun inode ->
            match inode with
            | :? LiteralNode as literalNode -> Some literalNode
            | _ -> None)
        |> Seq.toArray
    member this.GraphLiteralNodes =
        this.AllNodes
        |> Seq.choose (fun inode ->
            match inode with
            | :? GraphLiteralNode as graphLiteralNode -> Some graphLiteralNode
            | _ -> None)
        |> Seq.toArray
    member this.VariableNodes =
        this.AllNodes
        |> Seq.choose (fun inode ->
            match inode with
            | :? VariableNode as variableNode -> Some variableNode
            | _ -> None)
        |> Seq.toArray
    member this.TripleNodes =
        this.AllNodes
        |> Seq.choose (fun inode ->
            match inode with
            | :? TripleNode as tripleNode -> Some tripleNode
            | _ -> None)
        |> Seq.toArray
    member this.BlankNodeCardinality = this.BlankNodes.Length
    member this.UriNodeCardinality = this.UriNodes.Length
    member this.LiteralNodeCardinality = this.LiteralNodes.Length
    member this.GraphLiteralNodeCardinality = this.GraphLiteralNodes.Length
    member this.VariableNodeCardinality = this.VariableNodes.Length
    member this.TripleNodeCardinality = this.TripleNodes.Length
    member this.allSubjectNodesAreNormative =
        this.Triples.SubjectNodes
        |> Seq.forall (fun inode -> NodeType.normativeSubjectTypes.Contains(inode.NodeType))
    member this.allPredicateNodesAreNormative =
        this.Triples.PredicateNodes
        |> Seq.forall (fun inode -> inode.NodeType = NodeType.Uri)

    member this.allObjectNodesAreBasicNormative =
        this.Triples.ObjectNodes
        |> Seq.forall (fun inode -> NodeType.basicNormativeObjectTypes.Contains(inode.NodeType))

    member this.allObjectNodesAreFullNormative =
        this.Triples.ObjectNodes
        |> Seq.forall (fun inode -> NodeType.fullNormativeObjectTypes.Contains(inode.NodeType))
    member this.minimumRdfConformance =
        match this.allSubjectNodesAreNormative, this.allPredicateNodesAreNormative, this.allObjectNodesAreBasicNormative, this.allObjectNodesAreFullNormative with
        | true, true, true, _ -> BasicNormativeConformance

        | true, true, false, true -> FullNormativeConformance

        | _ -> NonNormativeNonConformance

[<CustomEquality; CustomComparison>]
type PrefixedName = {
    namespaceName: RDFNamespace
    localName: string
} with

    member this.identity = this.namespaceName.NamespaceUri.OriginalString + this.localName

    static member op_Implicit(prefixedName: PrefixedName) = RDFResource prefixedName.identity
    // static member op_Implicit(prefixedName: PrefixedName) = XmlQualifiedName(prefixedName.localName, prefixedName.namespaceName.NamespaceUri.OriginalString)
    static member op_Implicit(prefixedName: PrefixedName) =
        let entity = new OWLClass(prefixedName)
        entity.AbbreviatedIRI <- XmlQualifiedName(prefixedName.localName, prefixedName.namespaceName.NamespaceUri.OriginalString)
        entity
    static member op_Implicit(prefixedName: PrefixedName) =
        let entity = new OWLDatatype(prefixedName)
        entity.AbbreviatedIRI <- XmlQualifiedName(prefixedName.localName, prefixedName.namespaceName.NamespaceUri.OriginalString)
        entity
    static member op_Implicit(prefixedName: PrefixedName) =
        let entity = new OWLObjectProperty(prefixedName)
        entity.AbbreviatedIRI <- XmlQualifiedName(prefixedName.localName, prefixedName.namespaceName.NamespaceUri.OriginalString)
        entity
    static member op_Implicit(prefixedName: PrefixedName) =
        let entity = new OWLDataProperty(prefixedName)
        entity.AbbreviatedIRI <- XmlQualifiedName(prefixedName.localName, prefixedName.namespaceName.NamespaceUri.OriginalString)
        entity
    static member op_Implicit(prefixedName: PrefixedName) =
        let entity = new OWLAnnotationProperty(prefixedName)
        entity.AbbreviatedIRI <- XmlQualifiedName(prefixedName.localName, prefixedName.namespaceName.NamespaceUri.OriginalString)
        entity
    static member op_Implicit(prefixedName: PrefixedName) =
        let entity = new OWLNamedIndividual(prefixedName)
        entity.AbbreviatedIRI <- XmlQualifiedName(prefixedName.localName, prefixedName.namespaceName.NamespaceUri.OriginalString)
        entity
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

type XmlQualifiedName with
    static member ofPrefixedName(prefixedName: PrefixedName) =
        XmlQualifiedName(prefixedName.localName, prefixedName.namespaceName.NamespaceUri.OriginalString)

type RDFNamespace with
    member this.NamespaceUriNode = UriNode this.NamespaceUri
    member this.identity = this.NamespaceUri.OriginalString

    member this.prefixedName(localName: string) = {
        namespaceName = this
        localName = localName
    }
    static member xsd = RDFNamespace("xsd", "http://www.w3.org/2001/XMLSchema#")
    static member rdf = RDFNamespace("rdf", "http://www.w3.org/1999/02/22-rdf-syntax-ns#")
    static member rdfs = RDFNamespace("rdfs", "http://www.w3.org/2000/01/rdf-schema#")
    static member owl = RDFNamespace("owl", "http://www.w3.org/2002/07/owl#")
    static member xdt = RDFNamespace("xdt", "http://www.w3.org/2003/05/xpath-datatypes#")
    static member xsi = RDFNamespace("xsi", "http://www.w3.org/2001/XMLSchema-instance#")
    static member xml = RDFNamespace("xml", "http://www.w3.org/XML/1998/namespace#")

type InitialTextDirection =
    | Ltr
    | Rtl

    static member tryParse(rawString: string) =
        match rawString.ToLowerInvariant() with
        | "ltr" -> Some Ltr
        | "rtl" -> Some Rtl
        | _ -> None

    member this.identity = this.ToString().ToLowerInvariant()

type LanguageTag with
    member this.identity = this.ToString().ToLowerInvariant()

type IGraph with
    member this.namespaceUriNodes(rdfNamespace: RDFNamespace) =
        this.AllNodes.UriNodes()
        |> Seq.filter (fun uriNode -> rdfNamespace.UrlPattern.IsMatch uriNode.Uri.OriginalString)
type OntologyResource with

    member this.tryUriNode =
        match this.Resource with
        | :? UriNode as uriNode -> Some uriNode
        | _ -> None
    member this.UriNode = this.Resource :?> UriNode

type OntologyGraph with
    member this.UriNodeClasses = this.AllClasses |> Seq.filter (fun resource -> resource.tryUriNode.IsSome)
    member this.UriNodeProperties = this.AllProperties |> Seq.filter (fun resource -> resource.tryUriNode.IsSome)
    member this.UriNodeRdfClasses = this.RdfClasses |> Seq.filter (fun resource -> resource.tryUriNode.IsSome)
    member this.UriNodeRdfProperties = this.RdfProperties |> Seq.filter (fun resource -> resource.tryUriNode.IsSome)
    member this.UriNodeOwlObjectProperties =
        this.OwlObjectProperties
        |> Seq.filter (fun resource -> resource.tryUriNode.IsSome)
    member this.UriNodeOwlDataProperties =
        this.OwlDatatypeProperties
        |> Seq.filter (fun resource -> resource.tryUriNode.IsSome)
    member this.UriNodeOwlAnnotationProperties =
        this.OwlAnnotationProperties
        |> Seq.filter (fun resource -> resource.tryUriNode.IsSome)
    member this.UriNodeOwlClasses = this.OwlClasses |> Seq.filter (fun resource -> resource.tryUriNode.IsSome)
    member this.namespaceClasses(rdfNamespace: RDFNamespace) =
        this.UriNodeClasses
        |> Seq.filter (fun ontologyClass -> rdfNamespace.UrlPattern.IsMatch ontologyClass.UriNode.Uri.OriginalString)

    member this.namespaceProperties(rdfNamespace: RDFNamespace) =
        this.UriNodeProperties
        |> Seq.filter (fun ontologyProperty -> rdfNamespace.UrlPattern.IsMatch ontologyProperty.UriNode.Uri.OriginalString)

    member this.namespaceRdfClasses(rdfNamespace: RDFNamespace) =
        this.UriNodeRdfClasses
        |> Seq.filter (fun ontologyClass -> rdfNamespace.UrlPattern.IsMatch ontologyClass.UriNode.Uri.OriginalString)

    member this.namespaceRdfProperties(rdfNamespace: RDFNamespace) =
        this.UriNodeRdfProperties
        |> Seq.filter (fun ontologyProperty -> rdfNamespace.UrlPattern.IsMatch ontologyProperty.UriNode.Uri.OriginalString)

    member this.namespaceOwlClasses(rdfNamespace: RDFNamespace) =
        this.UriNodeOwlClasses
        |> Seq.filter (fun ontologyClass -> rdfNamespace.UrlPattern.IsMatch ontologyClass.UriNode.Uri.OriginalString)

    member this.namespaceOwlObjectProperties(rdfNamespace: RDFNamespace) =
        this.UriNodeOwlObjectProperties
        |> Seq.filter (fun ontologyProperty -> rdfNamespace.UrlPattern.IsMatch ontologyProperty.UriNode.Uri.OriginalString)

    member this.namespaceOwlDatatypeProperties(rdfNamespace: RDFNamespace) =
        this.UriNodeOwlDataProperties
        |> Seq.filter (fun ontologyProperty -> rdfNamespace.UrlPattern.IsMatch ontologyProperty.UriNode.Uri.OriginalString)

    member this.namespaceOwlAnnotationProperties(rdfNamespace: RDFNamespace) =
        this.UriNodeOwlAnnotationProperties
        |> Seq.filter (fun ontologyProperty -> rdfNamespace.UrlPattern.IsMatch ontologyProperty.UriNode.Uri.OriginalString)

type RDFGraph with
    member this.ToTurtle(turtlePath: string) =
        this.ToFileAsync(RDFModelEnums.RDFFormats.Turtle, turtlePath)
        |> Async.AwaitTask
        |> Async.RunSynchronously
type OWLOntology with
    member this.ToAssertedTurtle(turtlePath: string) =
        this.ToRDFGraphAsync(false).Result.ToTurtle turtlePath
    member this.ToInferredTurtle(turtlePath: string) =
        this.ToRDFGraphAsync(true).Result.ToTurtle turtlePath
    member this.Assert(axiom: OWLDeclaration) = this.DeclarationAxioms.Add axiom

    member this.Assert(axiom: OWLClassAxiom) = this.ClassAxioms.Add axiom

    member this.Assert(axiom: OWLObjectPropertyAxiom) = this.ObjectPropertyAxioms.Add axiom

    member this.Assert(axiom: OWLDataPropertyAxiom) = this.DataPropertyAxioms.Add axiom

    member this.Assert(axiom: OWLDatatypeDefinition) = this.DatatypeDefinitionAxioms.Add axiom

    member this.Assert(axiom: OWLHasKey) = this.KeyAxioms.Add axiom

    member this.Assert(axiom: OWLAssertionAxiom) = this.AssertionAxioms.Add axiom

    member this.Assert(axiom: OWLAnnotationAxiom) = this.AnnotationAxioms.Add axiom

type OWLOntologyView with
    member this.AnnotationAssertionCount = this.AnnotationAssertionCountAsync().Result
    member this.AnnotationPropertyCount = this.AnnotationPropertyCountAsync().Result
    member this.AnnotationPropertyDomainCount = this.AnnotationPropertyDomainCountAsync().Result
    member this.AnnotationPropertyRangeCount = this.AnnotationPropertyRangeCountAsync().Result
    member this.AnnotationsCount = this.AnnotationsCountAsync().Result
    member this.AsymmetricObjectPropertyCount = this.AsymmetricObjectPropertyCountAsync().Result
    member this.ClassAssertionCount = this.ClassAssertionCountAsync().Result
    member this.ClassCount = this.ClassCountAsync().Result
    member this.DataPropertyAssertionCount = this.DataPropertyAssertionCountAsync().Result
    member this.DataPropertyCount = this.DataPropertyCountAsync().Result
    member this.DataPropertyDomainCount = this.DataPropertyDomainCountAsync().Result
    member this.DataPropertyRangeCount = this.DataPropertyRangeCountAsync().Result
    member this.DatatypeCount = this.DatatypeCountAsync().Result
    member this.DatatypeDefinitionCount = this.DatatypeDefinitionCountAsync().Result
    member this.DeclarationCount = this.DeclarationCountAsync().Result
    member this.DifferentIndividualsCount = this.DifferentIndividualsCountAsync().Result
    member this.DisjointClassesCount = this.DisjointClassesCountAsync().Result
    member this.DisjointDataPropertiesCount = this.DisjointDataPropertiesCountAsync().Result
    member this.DisjointObjectPropertiesCount = this.DisjointObjectPropertiesCountAsync().Result
    member this.DisjointUnionCount = this.DisjointUnionCountAsync().Result
    member this.EquivalentClassesCount = this.EquivalentClassesCountAsync().Result
    member this.EquivalentDataPropertiesCount = this.EquivalentDataPropertiesCountAsync().Result
    member this.EquivalentObjectPropertiesCount = this.EquivalentObjectPropertiesCountAsync().Result
    member this.FunctionalDataPropertyCount = this.FunctionalDataPropertyCountAsync().Result
    member this.FunctionalObjectPropertyCount = this.FunctionalObjectPropertyCountAsync().Result
    member this.ImportsCount = this.ImportsCountAsync().Result
    member this.InverseFunctionalObjectPropertyCount = this.InverseFunctionalObjectPropertyCountAsync().Result
    member this.InverseObjectPropertiesCount = this.InverseObjectPropertiesCountAsync().Result
    member this.IrreflexiveObjectPropertyCount = this.IrreflexiveObjectPropertyCountAsync().Result
    member this.KeyCount = this.KeyCountAsync().Result
    member this.NamedIndividualCount = this.NamedIndividualCountAsync().Result
    member this.NegativeDataPropertyAssertionCount = this.NegativeDataPropertyAssertionCountAsync().Result
    member this.NegativeObjectPropertyAssertionCount = this.NegativeObjectPropertyAssertionCountAsync().Result
    member this.ObjectPropertyAssertionCount = this.ObjectPropertyAssertionCountAsync().Result
    member this.ObjectPropertyCount = this.ObjectPropertyCountAsync().Result
    member this.ObjectPropertyDomainCount = this.ObjectPropertyDomainCountAsync().Result
    member this.ObjectPropertyRangeCount = this.ObjectPropertyRangeCountAsync().Result
    member this.PrefixesCount = this.PrefixesCountAsync().Result
    member this.ReflexiveObjectPropertyCount = this.ReflexiveObjectPropertyCountAsync().Result
    member this.SameIndividualCount = this.SameIndividualCountAsync().Result
    member this.SubAnnotationPropertyOfCount = this.SubAnnotationPropertyOfCountAsync().Result
    member this.SubClassOfCount = this.SubClassOfCountAsync().Result
    member this.SubDataPropertyOfCount = this.SubDataPropertyOfCountAsync().Result
    member this.SubObjectPropertyOfCount = this.SubObjectPropertyOfCountAsync().Result
    member this.SymmetricObjectPropertyCount = this.SymmetricObjectPropertyCountAsync().Result
    member this.TransitiveObjectPropertyCount = this.TransitiveObjectPropertyCountAsync().Result

type OWLClassView with
    member this.DataAnnotations = this.DataAnnotationsAsync().Result |> Seq.toArray
    member this.DisjointClasses = this.DisjointClassesAsync().Result |> Seq.toArray
    member this.EquivalentClasses = this.EquivalentClassesAsync().Result |> Seq.toArray
    member this.Individuals = this.IndividualsAsync().Result |> Seq.toArray
    member this.IsDeprecated = this.IsDeprecatedAsync().Result
    member this.Keys = this.KeysAsync().Result |> Seq.toArray
    member this.NegativeIndividuals = this.NegativeIndividualsAsync().Result |> Seq.toArray
    member this.ObjectAnnotations = this.ObjectAnnotationsAsync().Result |> Seq.toArray
    member this.SubClasses = this.SubClassesAsync().Result |> Seq.toArray
    member this.SuperClasses = this.SuperClassesAsync().Result |> Seq.toArray
type OWLDataPropertyView with
    member this.DataAnnotations = this.DataAnnotationsAsync().Result |> Seq.toArray
    member this.DataAssertions = this.DataAssertionsAsync().Result |> Seq.toArray
    member this.DisjointDataProperties = this.DisjointDataPropertiesAsync().Result |> Seq.toArray
    member this.Domains = this.DomainsAsync().Result |> Seq.toArray
    member this.EquivalentDataProperties = this.EquivalentDataPropertiesAsync().Result |> Seq.toArray
    member this.IsDeprecated = this.IsDeprecatedAsync().Result
    member this.IsFunctional = this.IsFunctionalAsync().Result
    member this.NegativeDataAssertions = this.NegativeDataAssertionsAsync().Result |> Seq.toArray
    member this.ObjectAnnotations = this.ObjectAnnotationsAsync().Result |> Seq.toArray
    member this.Ranges = this.RangesAsync().Result |> Seq.toArray
    member this.SubDataProperties = this.SubDataPropertiesAsync().Result |> Seq.toArray
    member this.SuperDataProperties = this.SuperDataPropertiesAsync().Result |> Seq.toArray
//
type OWLObjectPropertyView with
    member this.DataAnnotations = this.DataAnnotationsAsync().Result |> Seq.toArray
    member this.DisjointObjectProperties = this.DisjointObjectPropertiesAsync().Result |> Seq.toArray
    member this.Domains = this.DomainsAsync().Result |> Seq.toArray
    member this.EquivalentObjectProperties = this.EquivalentObjectPropertiesAsync().Result |> Seq.toArray
    member this.InverseObjectProperties = this.InverseObjectPropertiesAsync().Result |> Seq.toArray
    member this.IsAsymmetric = this.IsAsymmetricAsync().Result
    member this.IsDeprecated = this.IsDeprecatedAsync().Result
    member this.IsFunctional = this.IsFunctionalAsync().Result
    member this.IsInverseFunctional = this.IsInverseFunctionalAsync().Result
    member this.IsIrreflexive = this.IsIrreflexiveAsync().Result
    member this.IsReflexive = this.IsReflexiveAsync().Result
    member this.IsSymmetric = this.IsSymmetricAsync().Result
    member this.IsTransitive = this.IsTransitiveAsync().Result
    member this.NegativeObjectAssertions = this.NegativeObjectAssertionsAsync().Result |> Seq.toArray
    member this.ObjectAnnotations = this.ObjectAnnotationsAsync().Result |> Seq.toArray
    member this.ObjectAssertions = this.ObjectAssertionsAsync().Result |> Seq.toArray
    member this.Ranges = this.RangesAsync().Result |> Seq.toArray
    member this.SubObjectProperties = this.SubObjectPropertiesAsync().Result |> Seq.toArray
    member this.SuperObjectProperties = this.SuperObjectPropertiesAsync().Result |> Seq.toArray
