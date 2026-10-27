// TODO use dynamic operator for namespacenames for adhoc local names
// TODO add op_Implicits to literal values

#time on

fsi.PrintLength <- 1
fsi.PrintSize <- 3000
fsi.ShowDeclarationValues <- true

#load @".paket/load/main.group.fsx"

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

type BasicRdfTerm =
    | IriTerm of Iri
    | LiteralTerm of LiteralValue
    | BlankTerm of BNode
and [<CustomEquality; CustomComparison>] Iri =
    | FullIRI of IriReference
    | AbbreviatedIRI of PrefixedName

    static member op_Implicit(iri: Iri) = iri.identity
    static member op_Implicit(iriString: string) = IriReference iriString |> FullIRI
    static member toUri(iri: Iri) = Uri iri.identity
    member this.asUri = Iri.toUri this
    static member op_Implicit(iri: Iri) = iri.asUri
    static member ofUri(uri: Uri) = IriReference uri |> FullIRI
    static member op_Implicit(uri: Uri) = Iri.ofUri uri
    static member toDomUrl(iri: Iri) = DomUrl iri.identity
    member this.asDomUrl = Iri.toDomUrl this
    static member ofDomUrl(domUrl: DomUrl) = IriReference domUrl.Href |> FullIRI
    static member op_Implicit(domUrl: DomUrl) = Iri.ofDomUrl domUrl
    static member toUriNode(iri: Iri) = UriNode(iri)
    member this.asUriNode = Iri.toUriNode this
    static member op_Implicit(iri: Iri) = iri.asUriNode
    static member toINode(iri: Iri) = iri.asUriNode :> INode
    member this.asINode = Iri.toINode this
    static member op_Implicit(iri: Iri) = iri.asINode
    static member toIRefNode(iri: Iri) = iri.asUriNode :> IRefNode
    member this.asIRefNode = Iri.toIRefNode this
    static member op_Implicit(iri: Iri) = iri.asIRefNode
    static member ofUriNode(uriNode: UriNode) = Iri.op_Implicit uriNode.Uri
    static member op_Implicit(uriNode: UriNode) = Iri.ofUriNode uriNode
    static member toRDFResource(iri: Iri) = RDFResource(iri.identity)
    member this.asRDFResource = Iri.toRDFResource this
    static member op_Implicit(iri: Iri) = iri.asRDFResource
    static member tryRDFResource(rdfResource: RDFResource) =
        if rdfResource.IsBlank then
            None
        else
            Some(Iri.op_Implicit rdfResource.URI)
    member this.tryRDFNamespace = RDFNamespaceRegister.GetByUri this.identity |> Option.ofObj

    static member ofRDFNamespace(rdfNamespace: RDFNamespace) =
        IriReference rdfNamespace.NamespaceUri |> FullIRI
    static member op_Implicit(rdfNamespace: RDFNamespace) = Iri.ofRDFNamespace rdfNamespace
    static member toOWLClass(iri: Iri) = new OWLClass(iri)
    member this.asOWLClass = Iri.toOWLClass this
    static member op_Implicit(iri: Iri) = iri.asOWLClass
    static member ofOWLClass(owlClass: OWLClass) =
        owlClass.GetIRI() |> Iri.tryRDFResource |> Option.get
    static member op_Implicit(owlClass: OWLClass) = Iri.ofOWLClass owlClass
    static member tryOntologyResource(ontologyResource: #OntologyResource) =
        match ontologyResource.Resource with
        | :? UriNode as uriNode -> Some(Iri.op_Implicit uriNode)
        | _ -> None
    member this.identity =
        match this with
        | FullIRI iriref -> iriref.uri.OriginalString
        | AbbreviatedIRI prefixedName -> prefixedName.identity

    override this.Equals(other: obj) =
        match other with
        | :? Iri as other -> this.identity = other.identity
        | _ -> false

    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? Iri as other -> compare this.identity other.identity
            | _ -> invalidArg (nameof other) "Incompatible comparison"
and [<CustomEquality; CustomComparison>] BNode = {
    sinsignId: Guid
    scope: string
    localIdentifier: string option
} with

    static member toBlankNode(bnode: BNode) = new BlankNode(bnode.identity)
    member this.asBlankNode = BNode.toBlankNode this
    static member op_Implicit(bnode: BNode) = bnode.asBlankNode
    static member ofBlankNode(blankNode: BlankNode) = {
        scope = String.Empty
        sinsignId = Guid.ensure blankNode.InternalID
        localIdentifier = None
    }
    static member op_Implicit(blankNode: BlankNode) = BNode.ofBlankNode blankNode
    static member toINode(bnode: BNode) = BNode.toBlankNode bnode :> INode
    member this.asINode = BNode.toINode this
    static member op_Implicit(bnode: BNode) = bnode.asINode
    static member toIRefNode(bnode: BNode) = BNode.toBlankNode bnode :> IRefNode
    member this.asIRefNode = BNode.toIRefNode this
    static member op_Implicit(bnode: BNode) = bnode.asIRefNode
    static member ofIGraphBlankNode((igraph: IGraph), (blankNode: BlankNode)) =
        let scope =
            match Option.ofNullOrWhiteSpace igraph.Name with
            | Some irefNode ->
                match irefNode with
                | :? UriNode as graphUriNode -> graphUriNode.Uri.OriginalString
                | :? BlankNode as graphBlankNode -> igraph.BaseUri.OriginalString + graphBlankNode.InternalID
                | _ -> igraph.BaseUri.OriginalString
            | _ -> igraph.BaseUri.OriginalString
        {
            scope = scope
            sinsignId = Guid.ensure blankNode.InternalID
            localIdentifier = None
        }
    static member toRDFResource(bnode: BNode) =
        new RDFResource($"bnode:{bnode.identity}")
    member this.asRDFResource = BNode.toRDFResource this
    static member op_Implicit(bnode: BNode) = bnode.asRDFResource
    static member tryRDFResource(rdfResource: RDFResource) =
        if rdfResource.IsBlank then

            let label = rdfResource.URI.OriginalString.Replace("bnode:", "").Replace("_:", "")
            let guid = Guid.ensure label
            let identifier = if guid.ToString("N") <> label then Some label else None
            Some {
                scope = String.Empty
                sinsignId = guid
                localIdentifier = identifier
            }
        else
            None
    static member tryRDFGraphRDFResource((rdfGraph: RDFGraph), (rdfResource: RDFResource)) =
        if rdfResource.IsBlank then

            let label = rdfResource.URI.OriginalString.Replace("bnode:", "").Replace("_:", "")
            let guid = Guid.ensure label
            let identifier = if guid.ToString("N") <> label then Some label else None
            Some {
                scope = rdfGraph.Context.OriginalString
                sinsignId = guid
                localIdentifier = identifier
            }
        else
            None
    member this.identity = this.sinsignId.ToString("N")
    override this.Equals(other: obj) =
        match other with
        | :? BNode as other -> this.identity = other.identity && this.scope = other.scope
        | _ -> false

    override this.GetHashCode() =
        HashCode.Combine(this.scope, this.identity)
    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? BNode as other -> compare (this.scope, this.identity) (other.scope, other.identity)

            | _ -> invalidArg (nameof other) $"Cannot compare {typeof<BNode>.Name} with {other.GetType().Name}"
and [<CustomEquality; CustomComparison>] DatatypeIri =
    | DatatypeIri of Iri

    member this.iri: Iri =
        match this with
        | DatatypeIri iri -> iri
    member this.identity: string = this.iri.identity
    static member op_Implicit(datatype: DatatypeIri) = datatype.identity
    static member op_Implicit(datatype: DatatypeIri) = Uri datatype.identity
    static member op_Implicit(uri: Uri) = Iri.op_Implicit uri |> DatatypeIri
    static member op_Implicit(datatypeString: string) =
        Iri.op_Implicit datatypeString |> DatatypeIri
    static member op_Implicit(prefixedName: PrefixedName) =
        AbbreviatedIRI prefixedName |> DatatypeIri
    static member op_Implicit(datatype: DatatypeIri) =
        RDFDatatypeRegister.GetDatatype(datatype.identity) |> Option.ofObj
    static member op_Implicit(rdfDatatype: RDFDatatype) =
        Iri.op_Implicit rdfDatatype.URI |> DatatypeIri
    static member op_Implicit(datatype: DatatypeIri) = RDFResource(datatype.identity)
    static member op_Implicit(datatype: DatatypeIri) =
        OWLDatatype(RDFResource(datatype.identity))
    static member op_Implicit(datatype: DatatypeIri) =
        OWLDatatype(RDFResource(datatype.identity)) :> OWLDataRangeExpression

    override this.Equals(other: obj) =
        match other with
        | :? DatatypeIri as other -> this.identity = other.identity
        | _ -> false
    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? DatatypeIri as other -> compare this.identity other.identity
            | _ -> invalidArg (nameof other) "Incompatible comparison"
and [<StructuralEquality; StructuralComparison>] LiteralIdentity = {
    lexicalForm: string
    literalDatatype: DatatypeIri
    languageTag: string option
    baseDirection: InitialTextDirection option
}
and [<CustomEquality; CustomComparison>] LiteralValue =
    | PlainLiteral of PlainLiteral
    | TypedLiteral of TypedLiteral
    | EmbeddedLiteral of EmbeddedLiteral

    // string -> xsd:string via your PlainLiteral representation
    static member op_Implicit(literalValue: LiteralValue) = literalValue.identity.lexicalForm
    static member op_Implicit(stringValue: string) =
        PlainLiteral.op_Implicit stringValue |> PlainLiteral
    static member toRDFLiteral(literalValue: LiteralValue) =
        match literalValue with
        | PlainLiteral plainLiteral -> plainLiteral.asRDFPlainLiteral :> RDFLiteral
        | TypedLiteral typedLiteral -> typedLiteral.asRDFTypedLiteral :> RDFLiteral
        | EmbeddedLiteral embeddedLiteral -> embeddedLiteral.asRDFTypedLiteral :> RDFLiteral
    member this.asRDFLiteral = LiteralValue.toRDFLiteral this
    static member op_Implicit(literalValue: LiteralValue) = literalValue.asRDFLiteral

    static member ofRDFLiteral(rdfLiteral: RDFLiteral) =
        match rdfLiteral with
        | :? RDFPlainLiteral as rdfPlainLiteral -> PlainLiteral.ofRDFPlainLiteral rdfPlainLiteral |> PlainLiteral
        | :? RDFTypedLiteral as rdfTypedLiteral -> TypedLiteral.ofRDFTypedLiteral rdfTypedLiteral |> TypedLiteral
        | _ -> LiteralValue.op_Implicit rdfLiteral.Value
    static member op_Implicit(rdfLiteral: RDFLiteral) = LiteralValue.ofRDFLiteral rdfLiteral
    static member toOWLLiteral(literalValue: LiteralValue) =
        new OWLLiteral(literalValue.asRDFLiteral)
    member this.asOWLLiteral = LiteralValue.toOWLLiteral this
    static member op_Implicit(literalValue: LiteralValue) = literalValue.asOWLLiteral
    static member ofOWLLiteral(owlLiteral: OWLLiteral) =
        owlLiteral.GetLiteral() |> LiteralValue.ofRDFLiteral
    static member op_Implicit(owlLiteral: OWLLiteral) = LiteralValue.ofOWLLiteral owlLiteral
    static member toLiteralNode(literalValue: LiteralValue) =
        match literalValue with
        | PlainLiteral plainLiteral -> plainLiteral.asLiteralNode
        | TypedLiteral typedLiteral -> LiteralNode(literal = typedLiteral.identity.lexicalForm, datatype = typedLiteral.datatype)
        | EmbeddedLiteral embeddedLiteral -> LiteralNode(literal = embeddedLiteral.identity.lexicalForm, datatype = embeddedLiteral.datatype)
    member this.asLiteralNode = LiteralValue.toLiteralNode this
    static member op_Implicit(literalValue: LiteralValue) = literalValue.asLiteralNode
    static member toINode(literalValue: LiteralValue) =
        LiteralValue.toLiteralNode literalValue :> INode
    member this.asINode = LiteralValue.toINode this
    static member op_Implicit(literalValue: LiteralValue) = literalValue.asINode
    static member ofLiteralNode(literalNode: LiteralNode) =
        match Option.ofNullOrWhiteSpace literalNode.Language, Option.ofNullOrWhiteSpace literalNode.DataType with
        | Some language, _ ->
            match language.LastIndexOf("--") with
            | -1 ->
                {
                    lexicalForm = literalNode.Value
                    languageTag = LanguageTag.Parse language
                    baseDirection = None
                }
                |> LanguageLiteral
                |> PlainLiteral

            | delimiterIndex ->
                match InitialTextDirection.tryParse language[delimiterIndex + 2 ..] with
                | Some direction ->
                    let rawTag = language[.. delimiterIndex - 1]
                    {
                        lexicalForm = literalNode.Value
                        languageTag = LanguageTag.Parse rawTag
                        baseDirection = Some direction
                    }
                    |> LanguageLiteral
                    |> PlainLiteral
                | None ->
                    {
                        lexicalForm = literalNode.Value
                        languageTag = LanguageTag.Parse language
                        baseDirection = None
                    }
                    |> LanguageLiteral
                    |> PlainLiteral

        | None, Some datatypeUri ->
            {
                lexicalForm = literalNode.Value
                datatype = datatypeUri
            }
            |> TypedLiteral
        | _, _ -> LiteralValue.op_Implicit literalNode.Value
    static member op_Implicit(literalNode: LiteralNode) = LiteralValue.ofLiteralNode literalNode
    // bool -> xsd:boolean
    member this.identity: LiteralIdentity =
        match this with

        | PlainLiteral(SimpleLiteral stringLiteral) -> stringLiteral.identity

        | PlainLiteral(LanguageLiteral languageString) -> languageString.identity

        | TypedLiteral typedLiteral -> typedLiteral.identity

        | EmbeddedLiteral embeddedLiteral -> embeddedLiteral.identity
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

    static member toRDFPlainLiteral(plainLiteral: PlainLiteral) =
        match plainLiteral with
        | SimpleLiteral stringLiteral -> stringLiteral.asRDFPlainLiteral
        | LanguageLiteral languageString -> languageString.asRDFPlainLiteral
    member this.asRDFPlainLiteral = PlainLiteral.toRDFPlainLiteral this

    static member op_Implicit(plainLiteral: PlainLiteral) : RDFPlainLiteral = plainLiteral.asRDFPlainLiteral
    static member ofRDFPlainLiteral(plainLiteral: RDFPlainLiteral) =
        match Option.ofNullOrWhiteSpace plainLiteral.Language with
        | Some language ->
            match plainLiteral.HasDirection(), language.LastIndexOf("--") with
            | true, delimiterIndex when delimiterIndex <> -1 ->
                let rawTag = language[.. delimiterIndex - 1]
                let rawDirection = language[delimiterIndex + 2 ..]
                LanguageLiteral {
                    lexicalForm = plainLiteral.Value
                    languageTag = LanguageTag.Parse rawTag
                    baseDirection = InitialTextDirection.tryParse rawDirection
                }
            | _, _ ->
                LanguageLiteral {
                    lexicalForm = plainLiteral.Value
                    languageTag = LanguageTag.Parse language
                    baseDirection = None
                }
        | None -> PlainLiteral.op_Implicit plainLiteral.Value
    static member op_Implicit(rdfPlainLiteral: RDFPlainLiteral) =
        PlainLiteral.ofRDFPlainLiteral rdfPlainLiteral
    static member toOWLLiteral(plainLiteral: PlainLiteral) =
        new OWLLiteral(plainLiteral.asRDFPlainLiteral)
    member this.asOWLLiteral = PlainLiteral.toOWLLiteral this
    static member op_Implicit(plainLiteral: PlainLiteral) = plainLiteral.asOWLLiteral
    static member toLiteralNode(plainLiteral: PlainLiteral) =
        match plainLiteral with
        | SimpleLiteral stringLiteral -> stringLiteral.asLiteralNode
        | LanguageLiteral languageString -> languageString.asLiteralNode
    member this.asLiteralNode = PlainLiteral.toLiteralNode this
    static member op_Implicit(plainLiteral: PlainLiteral) = plainLiteral.asLiteralNode

    member this.identity =
        match this with
        | SimpleLiteral stringLiteral -> stringLiteral.identity
        | LanguageLiteral languageString -> languageString.identity
    static member op_Implicit(literalValue: LiteralValue) = literalValue.identity.lexicalForm
    static member op_Implicit(value: string) =
        StringLiteral.op_Implicit value |> SimpleLiteral
and StringLiteral = {
    simpleString: string
} with

    static member op_Implicit(stringLiteral: StringLiteral) = stringLiteral.identity.lexicalForm
    static member op_Implicit(value: string) = { simpleString = value }
    static member toLiteralNode(stringLiteral: StringLiteral) =
        new LiteralNode(stringLiteral.simpleString)
    member this.asLiteralNode = StringLiteral.toLiteralNode this
    static member op_Implicit(stringLiteral: StringLiteral) = stringLiteral.asLiteralNode
    static member toRDFPlainLiteral(stringLiteral: StringLiteral) =
        new RDFPlainLiteral(stringLiteral.simpleString)
    member this.asRDFPlainLiteral = StringLiteral.toRDFPlainLiteral this
    static member op_Implicit(stringLiteral: StringLiteral) = stringLiteral.asRDFPlainLiteral
    static member toOWLLiteral(stringLiteral: StringLiteral) =
        new OWLLiteral(stringLiteral.asRDFPlainLiteral)

    member this.asOWLLiteral = StringLiteral.toOWLLiteral this

    static member op_Implicit(stringLiteral: StringLiteral) = stringLiteral.asOWLLiteral
    member this.identity: LiteralIdentity = {
        lexicalForm = this.simpleString
        literalDatatype = RDFNamespace.xsd.prefixedName "string" |> AbbreviatedIRI |> DatatypeIri
        languageTag = None
        baseDirection = None
    }

and LanguageString = {
    lexicalForm: string
    languageTag: LanguageTag
    baseDirection: InitialTextDirection option
} with

    member this.tagString =
        match this.baseDirection with
        | Some direction -> $"{this.languageTag.identity}--{direction.identity}"
        | None -> this.languageTag.identity

    static member op_Implicit(languageString: LanguageString) = languageString.identity.lexicalForm
    static member toLiteralNode(languageString: LanguageString) =
        new LiteralNode(languageString.lexicalForm, languageString.tagString)
    member this.asLiteralNode = LanguageString.toLiteralNode this
    static member op_Implicit(languageString: LanguageString) = languageString.asLiteralNode
    static member toRDFPlainLiteral(languageString: LanguageString) =
        new RDFPlainLiteral(languageString.lexicalForm, languageString.tagString)
    member this.asRDFPlainLiteral = LanguageString.toRDFPlainLiteral this
    static member op_Implicit(languageString: LanguageString) = languageString.asRDFPlainLiteral
    static member toOWLLiteral(languageString: LanguageString) =
        new OWLLiteral(languageString.asRDFPlainLiteral)
    member this.asOWLLiteral = LanguageString.toOWLLiteral this
    static member op_Implicit(languageString: LanguageString) = languageString.asOWLLiteral

    member this.identity: LiteralIdentity = {
        lexicalForm = this.lexicalForm
        literalDatatype =
            match this.baseDirection with
            | None -> RDFNamespace.rdf.prefixedName "langString" |> AbbreviatedIRI |> DatatypeIri
            | Some _ -> RDFNamespace.rdf.prefixedName "dirLangString" |> AbbreviatedIRI |> DatatypeIri
        languageTag = Some this.languageTag.identity
        baseDirection = this.baseDirection
    }

and TypedLiteral = {
    lexicalForm: string
    datatype: DatatypeIri
} with

    static member toRDFTypedLiteral(typedLiteral: TypedLiteral) =
        RDFTypedLiteral(typedLiteral.identity.lexicalForm, RDFDatatypeRegister.GetDatatype(typedLiteral.datatype))

    member this.asRDFTypedLiteral = TypedLiteral.toRDFTypedLiteral this

    static member op_Implicit(typedLiteral: TypedLiteral) =
        TypedLiteral.toRDFTypedLiteral typedLiteral
    static member ofRDFTypedLiteral(typedLiteral: RDFTypedLiteral) = {
        lexicalForm = typedLiteral.Value
        datatype = typedLiteral.Datatype
    }
    static member op_Implicit(rdfTypedLiteral: RDFTypedLiteral) =
        TypedLiteral.ofRDFTypedLiteral rdfTypedLiteral
    static member toOWLLiteral(typedLiteral: TypedLiteral) =
        new OWLLiteral(typedLiteral.asRDFTypedLiteral)

    member this.asOWLLiteral = TypedLiteral.toOWLLiteral this

    static member op_Implicit(typedLiteral: TypedLiteral) = TypedLiteral.toOWLLiteral typedLiteral

    static member nonNegativeInteger(nonNegativeInteger: NonNegativeInteger) = {
        lexicalForm = string nonNegativeInteger
        datatype = RDFNamespace.xsd.prefixedName "nonNegativeInteger"
    }

    static member op_Implicit(value: bool) = {
        lexicalForm = if value then "true" else "false"
        datatype = RDFNamespace.xsd.prefixedName "boolean"
    }

    // byte[] -> xsd:base64Binary
    static member op_Implicit(value: byte array) = {
        lexicalForm = Convert.ToBase64String value
        datatype = RDFNamespace.xsd.prefixedName "base64Binary"
    }

    // byte -> xsd:unsignedByte
    static member op_Implicit(value: byte) = {
        lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
        datatype = RDFNamespace.xsd.prefixedName "unsignedByte"
    }

    // DateOnly -> xsd:date
    static member op_Implicit(value: DateOnly) = {
        lexicalForm = value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
        datatype = RDFNamespace.xsd.prefixedName "date"
    }

    // DateTime -> xsd:dateTime
    static member op_Implicit(value: DateTime) = {
        lexicalForm = value.ToString("yyyy-MM-dd'T'HH:mm:ss.ffffff", CultureInfo.InvariantCulture)
        datatype = RDFNamespace.xsd.prefixedName "dateTime"
    }

    // DateTimeOffset -> xsd:dateTimeStamp
    static member op_Implicit(value: DateTimeOffset) = {
        lexicalForm = value.ToString("o", CultureInfo.InvariantCulture)
        datatype = RDFNamespace.xsd.prefixedName "dateTimeStamp"
    }

    // decimal -> xsd:decimal
    static member op_Implicit(value: decimal) = {
        lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
        datatype = RDFNamespace.xsd.prefixedName "decimal"
    }

    // double -> xsd:double
    static member op_Implicit(value: double) = {
        lexicalForm = value.ToString("R", CultureInfo.InvariantCulture)
        datatype = RDFNamespace.xsd.prefixedName "double"
    }

    // int16 -> xsd:short
    static member op_Implicit(value: int16) = {
        lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
        datatype = RDFNamespace.xsd.prefixedName "short"
    }

    // int32 -> xsd:int
    static member op_Implicit(value: int32) = {
        lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
        datatype = RDFNamespace.xsd.prefixedName "int"
    }

    // int64 -> xsd:long
    static member op_Implicit(value: int64) = {
        lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
        datatype = RDFNamespace.xsd.prefixedName "long"
    }

    // sbyte -> xsd:byte
    static member op_Implicit(value: sbyte) = {
        lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
        datatype = RDFNamespace.xsd.prefixedName "byte"
    }

    // single -> xsd:float
    static member op_Implicit(value: single) = {
        lexicalForm = value.ToString("R", CultureInfo.InvariantCulture)
        datatype = RDFNamespace.xsd.prefixedName "float"
    }

    // TimeOnly -> xsd:time
    static member op_Implicit(value: TimeOnly) = {
        lexicalForm = value.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)
        datatype = RDFNamespace.xsd.prefixedName "time"
    }

    // TimeSpan -> xsd:duration
    static member op_Implicit(value: TimeSpan) = {
        lexicalForm = Xml.XmlConvert.ToString value
        datatype = RDFNamespace.xsd.prefixedName "duration"
    }

    // uint16 -> xsd:unsignedShort
    static member op_Implicit(value: uint16) = {
        lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
        datatype = RDFNamespace.xsd.prefixedName "unsignedShort"
    }

    // uint32 -> xsd:unsignedInt
    static member op_Implicit(value: uint32) = {
        lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
        datatype = RDFNamespace.xsd.prefixedName "unsignedInt"
    }

    // uint64 -> xsd:unsignedLong
    static member op_Implicit(value: uint64) = {
        lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
        datatype = RDFNamespace.xsd.prefixedName "unsignedLong"
    }

    // System.Uri -> xsd:anyURI
    static member op_Implicit(value: Uri) = {
        lexicalForm = value.OriginalString
        datatype = RDFNamespace.xsd.prefixedName "anyURI"
    }

    // WHATWG DomUrl -> xsd:anyURI
    static member op_Implicit(value: DomUrl) = {
        lexicalForm = value.ToString()
        datatype = RDFNamespace.xsd.prefixedName "anyURI"
    }

    // XmlQualifiedName -> xsd:QName
    static member op_Implicit(value: XmlQualifiedName) = {
        lexicalForm = value.ToString()
        datatype = RDFNamespace.xsd.prefixedName "QName"
    }

    // Guid -> xsd:ID
    static member op_Implicit(value: Guid) = {
        lexicalForm = value.ToString("N")
        datatype = RDFNamespace.xsd.prefixedName "ID"
    }

    static member nil = {
        lexicalForm = "true"
        datatype = RDFNamespace.xsi.prefixedName "nil"
    }
    member this.identity: LiteralIdentity = {

        lexicalForm = this.lexicalForm

        literalDatatype = this.datatype

        languageTag = None

        baseDirection = None
    }

and EmbeddedLiteral =
    | EmbeddedHtml of HtmlLiteral
    | EmbeddedXml of XmlLiteral
    | EmbeddedJson of JsonLiteral

    static member op_Implicit(embeddedLiteral: EmbeddedLiteral) = embeddedLiteral.identity.lexicalForm
    static member toRDFTypedLiteral(embeddedLiteral: EmbeddedLiteral) =
        RDFTypedLiteral(embeddedLiteral.identity.lexicalForm, RDFDatatypeRegister.GetDatatype(embeddedLiteral.datatype))

    member this.asRDFTypedLiteral = EmbeddedLiteral.toRDFTypedLiteral this

    static member op_Implicit(embeddedLiteral: EmbeddedLiteral) =
        EmbeddedLiteral.toRDFTypedLiteral embeddedLiteral
    static member toOWLLiteral(embeddedLiteral: EmbeddedLiteral) =
        new OWLLiteral(embeddedLiteral.asRDFTypedLiteral)

    member this.asOWLLiteral = EmbeddedLiteral.toOWLLiteral this

    static member op_Implicit(embeddedLiteral: EmbeddedLiteral) =
        EmbeddedLiteral.toOWLLiteral embeddedLiteral
    member this.datatype: DatatypeIri =
        match this with
        | EmbeddedHtml htmlLiteral -> htmlLiteral.datatype
        | EmbeddedXml xmlLiteral -> xmlLiteral.datatype
        | EmbeddedJson jsonLiteral -> jsonLiteral.datatype

    member this.identity: LiteralIdentity =
        match this with
        | EmbeddedHtml htmlLiteral -> htmlLiteral.identity
        | EmbeddedXml xmlLiteral -> xmlLiteral.identity
        | EmbeddedJson jsonLiteral -> jsonLiteral.identity

and HtmlLiteral = {
    htmlString: string
} with

    static member op_Implicit(htmlLiteral: HtmlLiteral) =
        HtmlNode.Parse htmlLiteral.identity.lexicalForm
    static member op_Implicit(htmlNode: HtmlNode) = { htmlString = htmlNode.ToString() }
    static member op_Implicit(htmlLiteral: HtmlLiteral) =
        HtmlDocument.Parse htmlLiteral.identity.lexicalForm
    static member op_Implicit(htmlDocument: HtmlDocument) = { htmlString = htmlDocument.ToString() }
    member this.datatype = RDFNamespace.rdf.prefixedName "HTML" |> AbbreviatedIRI |> DatatypeIri

    member this.identity = {
        lexicalForm = this.htmlString
        literalDatatype = this.datatype
        languageTag = None
        baseDirection = None
    }

and XmlLiteral = {
    xmlString: string
} with

    static member op_Implicit(xmlLiteral: XmlLiteral) =
        XDocument.Parse xmlLiteral.identity.lexicalForm
    static member op_Implicit(xdocument: XDocument) = { xmlString = xdocument.ToString() }
    static member op_Implicit(xmlLiteral: XmlLiteral) =
        XElement.Parse xmlLiteral.identity.lexicalForm
    static member op_Implicit(xelement: XElement) = { xmlString = xelement.ToString() }
    member this.datatype = RDFNamespace.rdf.prefixedName "XMLLiteral" |> AbbreviatedIRI |> DatatypeIri

    member this.identity = {
        lexicalForm = this.xmlString
        literalDatatype = this.datatype
        languageTag = None
        baseDirection = None
    }

and JsonLiteral = {
    jsonString: string
} with

    static member op_Implicit(jsonLiteral: JsonLiteral) =
        JsonValue.Parse jsonLiteral.identity.lexicalForm
    static member op_Implicit(jsonValue: JsonValue) = { jsonString = string jsonValue }
    static member op_Implicit(jsonLiteral: JsonLiteral) =
        JValue.Parse jsonLiteral.identity.lexicalForm
    static member op_Implicit(jvalue: JValue) = { jsonString = jvalue.ToString() }
    static member op_Implicit(jsonLiteral: JsonLiteral) =
        JsonDocument.Parse jsonLiteral.identity.lexicalForm
    static member op_Implicit(jsonDocument: JsonDocument) = { jsonString = jsonDocument.ToString() }
    member this.datatype = RDFNamespace.rdf.prefixedName "JSON" |> AbbreviatedIRI |> DatatypeIri

    member this.identity = {
        lexicalForm = this.jsonString
        literalDatatype = this.datatype
        languageTag = None
        baseDirection = None
    }
and RdfTerm =
    | BasicRdfTerm of BasicRdfTerm
    | RdfTripleTerm of TripleTerm
and TripleTerm =
    | TripleTerm of FullNormativeTriple

    static member op_Implicit(tripleTerm: TripleTerm) = tripleTerm.asTripleNode
    static member toINode(tripleTerm: TripleTerm) = tripleTerm.asTripleNode :> INode
    member this.asINode = TripleTerm.toINode this
    static member op_Implicit(tripleTerm: TripleTerm) = tripleTerm.asINode
    static member toTripleNode(tripleTerm: TripleTerm) =
        match tripleTerm with
        | TripleTerm fullNormativeTriple -> new TripleNode(fullNormativeTriple.asTriple)
    member this.asTripleNode = TripleTerm.toTripleNode this
    static member ofTripleNode(tripleNode: TripleNode) =
        FullNormativeTriple.ofTriple tripleNode.Triple |> TripleTerm
    static member op_Implicit(tripleNode: TripleNode) = TripleTerm.ofTripleNode tripleNode
and BasicNormativeTriple = {
    normativeSubject: NormativeSubject
    normativePredicate: NormativePredicate
    basicNormativeObject: BasicNormativeObject
} with

    static member toTriple(basicNormativeTriple: BasicNormativeTriple) =
        new Triple(basicNormativeTriple.normativeSubject.asINode, basicNormativeTriple.normativePredicate.asINode, basicNormativeTriple.basicNormativeObject.asINode)
    member this.asTriple = BasicNormativeTriple.toTriple this
    static member op_Implicit(basicNormativeTriple: BasicNormativeTriple) = basicNormativeTriple.asTriple

    static member toRDFTriple(basicNormativeTriple: BasicNormativeTriple) =
        match basicNormativeTriple.basicNormativeObject with
        | IriObject iri -> new RDFTriple(basicNormativeTriple.normativeSubject.asRDFResource, basicNormativeTriple.normativePredicate.asRDFResource, iri.asRDFResource)
        | BNodeObject bnode -> new RDFTriple(basicNormativeTriple.normativeSubject.asRDFResource, basicNormativeTriple.normativePredicate.asRDFResource, bnode.asRDFResource)
        | LiteralValueObject literalValue ->
            new RDFTriple(basicNormativeTriple.normativeSubject.asRDFResource, basicNormativeTriple.normativePredicate.asRDFResource, literalValue.asRDFLiteral)
    member this.asRDFTriple = BasicNormativeTriple.toRDFTriple this
    static member op_Implicit(basicNormativeTriple: BasicNormativeTriple) = basicNormativeTriple.asRDFTriple

    static member ofRDFTriple(rdfTriple: RDFTriple) = {
        normativeSubject = NormativeSubject.ofRDFTriple rdfTriple
        normativePredicate = NormativePredicate.ofRDFTriple rdfTriple
        basicNormativeObject = BasicNormativeObject.ofRDFTriple rdfTriple
    }

    static member op_Implicit(rdfTriple: RDFTriple) =
        BasicNormativeTriple.ofRDFTriple rdfTriple
and FullNormativeTriple = {
    normativeSubject: NormativeSubject
    normativePredicate: NormativePredicate
    fullNormativeObject: FullNormativeObject
} with

    static member toTriple(fullNormativeTriple: FullNormativeTriple) =
        new Triple(fullNormativeTriple.normativeSubject.asINode, fullNormativeTriple.normativePredicate.asINode, fullNormativeTriple.fullNormativeObject.asINode)
    member this.asTriple = FullNormativeTriple.toTriple this
    static member op_Implicit(fullNormativeTriple: FullNormativeTriple) = fullNormativeTriple.asTriple

    static member ofTriple(triple: Triple) = {
        normativeSubject = NormativeSubject.ofTriple triple
        normativePredicate = NormativePredicate.ofTriple triple
        fullNormativeObject = FullNormativeObject.ofTriple triple
    }
    static member ofRDFTriple(rdfTriple: RDFTriple) =
        let normativeSubject = rdfTriple.Subject :?> RDFResource |> NormativeSubject.ofRDFResource

        let normativePredicate =
            rdfTriple.Predicate :?> RDFResource
            |> Iri.tryRDFResource
            |> Option.get
            |> IriPredicate
        let fullNormativeObject =
            match rdfTriple.TripleFlavor with
            | RDFModelEnums.RDFTripleFlavors.SPO ->
                let objectResource = rdfTriple.Object :?> RDFResource
                if objectResource.IsBlank then
                    BNode.tryRDFResource objectResource
                    |> Option.get
                    |> BNodeObject
                    |> BasicNormativeObject
                else
                    Iri.tryRDFResource objectResource
                    |> Option.get
                    |> IriObject
                    |> BasicNormativeObject
            | RDFModelEnums.RDFTripleFlavors.SPL ->
                match rdfTriple.Object with
                | :? RDFLiteral as rdfLiteral ->
                    LiteralValue.ofRDFLiteral rdfLiteral
                    |> LiteralValueObject
                    |> BasicNormativeObject
        {
            normativeSubject = normativeSubject
            normativePredicate = normativePredicate
            fullNormativeObject = fullNormativeObject
        }

    static member op_Implicit(rdfTriple: RDFTriple) =
        FullNormativeTriple.ofRDFTriple rdfTriple
and NormativeSubject =
    | IriSubject of Iri
    | BNodeSubject of BNode

    static member toIRefNode(normativeSubject: NormativeSubject) =
        match normativeSubject with
        | IriSubject iri -> iri.asIRefNode
        | BNodeSubject bnode -> bnode.asBlankNode :> IRefNode
    member this.asIRefNode = NormativeSubject.toIRefNode this
    static member toINode(normativeSubject: NormativeSubject) =
        match normativeSubject with
        | IriSubject iri -> iri.asINode
        | BNodeSubject bnode -> bnode.asBlankNode :> INode
    member this.asINode = NormativeSubject.toINode this
    static member ofTriple(triple: Triple) =
        match triple.Subject with
        | :? UriNode as uriNode -> Iri.ofUriNode uriNode |> IriSubject
        | :? BlankNode as blankNode -> BNode.ofBlankNode blankNode |> BNodeSubject
    static member ofIRefNode(irefNode: IRefNode) =
        match irefNode with
        | :? UriNode as uriNode -> Iri.ofUriNode uriNode |> IriSubject
        | :? BlankNode as blankNode -> BNode.ofBlankNode blankNode |> BNodeSubject

    static member toRDFResource(normativeSubject: NormativeSubject) =
        match normativeSubject with
        | IriSubject iri -> iri.asRDFResource
        | BNodeSubject bnode -> bnode.asRDFResource
    member this.asRDFResource = NormativeSubject.toRDFResource this
    static member ofRDFResource(rdfResource: RDFResource) =
        if rdfResource.IsBlank then
            BNode.tryRDFResource rdfResource |> Option.get |> BNodeSubject
        else
            Iri.tryRDFResource rdfResource |> Option.get |> IriSubject
    static member ofRDFTriple(rdfTriple: RDFTriple) =
        rdfTriple.Subject :?> RDFResource |> NormativeSubject.ofRDFResource

and NormativePredicate =
    | IriPredicate of Iri

    static member toINode(normativePredicate: NormativePredicate) =
        match normativePredicate with
        | IriPredicate iri -> iri.asINode
    member this.asINode = NormativePredicate.toINode this
    static member ofTriple(triple: Triple) =
        match triple.Predicate with
        | :? UriNode as uriNode -> Iri.ofUriNode uriNode |> IriPredicate

    static member toRDFResource(normativePredicate: NormativePredicate) =
        match normativePredicate with
        | IriPredicate iri -> iri.asRDFResource
    member this.asRDFResource = NormativePredicate.toRDFResource this
    static member tryRDFResource(rdfResource: RDFResource) =
        if rdfResource.IsBlank then
            None
        else
            Iri.tryRDFResource rdfResource
            |> Option.map (fun iriResource -> IriPredicate iriResource)
    static member ofRDFTriple(rdfTriple: RDFTriple) =
        rdfTriple.Predicate :?> RDFResource
        |> NormativePredicate.tryRDFResource
        |> Option.get

and BasicNormativeObject =
    | IriObject of Iri
    | BNodeObject of BNode
    | LiteralValueObject of LiteralValue

    static member toINode(basicNormativeObject: BasicNormativeObject) =
        match basicNormativeObject with
        | IriObject iri -> iri.asINode
        | BNodeObject bnode -> bnode.asINode
        | LiteralValueObject literalValue -> literalValue.asINode

    static member ofRDFTriple(rdfTriple: RDFTriple) =
        match rdfTriple.TripleFlavor with
        | RDFModelEnums.RDFTripleFlavors.SPO ->
            let objectResource = rdfTriple.Object :?> RDFResource
            if objectResource.IsBlank then
                BNode.tryRDFResource objectResource |> Option.get |> BNodeObject
            else
                Iri.tryRDFResource objectResource |> Option.get |> IriObject
        | RDFModelEnums.RDFTripleFlavors.SPL ->
            match rdfTriple.Object with
            | :? RDFLiteral as rdfLiteral -> LiteralValue.ofRDFLiteral rdfLiteral |> LiteralValueObject

    member this.asINode = BasicNormativeObject.toINode this
and FullNormativeObject =
    | BasicNormativeObject of BasicNormativeObject
    | TripleTermObject of TripleTerm

    static member toINode(fullNormativeObject: FullNormativeObject) =
        match fullNormativeObject with
        | BasicNormativeObject basicNormativeObject -> basicNormativeObject.asINode
        | TripleTermObject semanticTripleTerm -> semanticTripleTerm.asINode
    member this.asINode = FullNormativeObject.toINode this

    static member ofTriple(triple: Triple) =
        match triple.Object with
        | :? UriNode as uriNode -> Iri.ofUriNode uriNode |> IriObject |> BasicNormativeObject
        | :? BlankNode as blankNode -> BNode.ofBlankNode blankNode |> BNodeObject |> BasicNormativeObject
        | :? LiteralNode as literalNode ->
            LiteralValue.ofLiteralNode literalNode
            |> LiteralValueObject
            |> BasicNormativeObject
        | :? TripleNode as tripleNode -> TripleTerm.ofTripleNode tripleNode |> TripleTermObject
and GraphName =
    | GraphName of NormativeSubject

    member this.normativeSubject =
        match this with
        | GraphName normativeSubject -> normativeSubject
    static member op_Implicit(graphName: GraphName) = graphName.normativeSubject.asIRefNode

and BasicNormativeGraph = {
    context: Iri option
    basicNormativeTripleSet: Set<BasicNormativeTriple>
} with

    static member toFullNormativeTriple(basicTriple: BasicNormativeTriple) =

        {
            normativeSubject = basicTriple.normativeSubject
            normativePredicate = basicTriple.normativePredicate
            fullNormativeObject = BasicNormativeObject basicTriple.basicNormativeObject
        }

    static member toThreadSafeGraph(basicNormativeGraph: BasicNormativeGraph) =
        let threadSafeGraph =
            match basicNormativeGraph.context with
            | Some graphName -> new ThreadSafeGraph(graphName)
            | None -> new ThreadSafeGraph()
        threadSafeGraph.Assert(
            basicNormativeGraph.basicNormativeTripleSet
            |> Seq.map (fun basicNormativeTriple -> basicNormativeTriple.asTriple)
        )
        |> ignore
        threadSafeGraph
    member this.asThreadSafeGraph = BasicNormativeGraph.toThreadSafeGraph this
    static member op_Implicit(semanticGraph: BasicNormativeGraph) =
        semanticGraph.asThreadSafeGraph :> IGraph
    static member tryIGraph(igraph: IGraph) =
        match igraph.minimumRdfConformance with
        | BasicNormativeConformance ->
            Some {

                context =
                    match Option.ofNullOrWhiteSpace igraph.Name with
                    | Some irefNode ->
                        match irefNode with
                        | :? UriNode as uriNode -> Some(Iri.ofUriNode uriNode)
                        | _ when not (isNull igraph.BaseUri) -> Some(Iri.ofUri igraph.BaseUri)
                        | _ -> None
                    | _ -> None

                basicNormativeTripleSet =
                    igraph.Triples
                    |> Seq.map (fun triple ->
                        let (BasicNormativeObject basicNormativeObject) = FullNormativeObject.ofTriple triple
                        {
                            normativeSubject = NormativeSubject.ofTriple triple
                            normativePredicate = NormativePredicate.ofTriple triple
                            basicNormativeObject = basicNormativeObject
                        }

                    )
                    |> Set.ofSeq
            }
        | _ -> None

and FullNormativeGraph = {
    context: Iri option
    fullNormativeTripleSet: Set<FullNormativeTriple>
} with

    static member tryBasicNormativeTriple(fullTriple: FullNormativeTriple) =

        match fullTriple.fullNormativeObject with
        | BasicNormativeObject basicObject ->
            Some {
                normativeSubject = fullTriple.normativeSubject
                normativePredicate = fullTriple.normativePredicate
                basicNormativeObject = basicObject
            }

        | TripleTermObject _ -> None

    member this.minimumRdfConformance =
        let tripleTermExists =
            this.fullNormativeTripleSet
            |> Set.exists (fun fullNormativeTriple -> fullNormativeTriple.fullNormativeObject.IsTripleTermObject)
        if tripleTermExists then
            FullNormativeConformance
        else
            BasicNormativeConformance

    static member toThreadSafeGraph(fullNormativeGraph: FullNormativeGraph) =
        let threadSafeGraph =
            match fullNormativeGraph.context with
            | Some graphName -> new ThreadSafeGraph(graphName)
            | None -> new ThreadSafeGraph()
        threadSafeGraph.Assert(
            fullNormativeGraph.fullNormativeTripleSet
            |> Seq.map (fun fullNormativeTriple -> fullNormativeTriple.asTriple)
        )
        |> ignore
        threadSafeGraph
    member this.asThreadSafeGraph = FullNormativeGraph.toThreadSafeGraph this
    static member op_Implicit(semanticGraph: FullNormativeGraph) =
        semanticGraph.asThreadSafeGraph :> IGraph
    static member tryIGraph(igraph: IGraph) =
        let normativeIGraph () = {
            context =
                match Option.ofNullOrWhiteSpace igraph.Name with
                | Some irefNode ->
                    match irefNode with
                    | :? UriNode as uriNode -> Some(Iri.ofUriNode uriNode)
                    | _ when not (isNull igraph.BaseUri) -> Some(Iri.ofUri igraph.BaseUri)
                    | _ -> None
                | _ -> None

            fullNormativeTripleSet =
                igraph.Triples
                |> Seq.map (fun triple -> FullNormativeTriple.ofTriple triple)
                |> Set.ofSeq
        }

        match igraph.minimumRdfConformance with
        | BasicNormativeConformance -> Some(normativeIGraph ())
        | FullNormativeConformance -> Some(normativeIGraph ())
        | _ -> None

    member this.tryRDFGraph =
        match this.minimumRdfConformance with
        | BasicNormativeConformance ->
            let rdfGraph =
                new RDFGraph(
                    this.fullNormativeTripleSet
                    |> Seq.map (fun fullNormativeTriple ->
                        let (BasicNormativeObject basicNormativeObject) = fullNormativeTriple.fullNormativeObject
                        {
                            normativeSubject = fullNormativeTriple.normativeSubject
                            normativePredicate = fullNormativeTriple.normativePredicate
                            basicNormativeObject = basicNormativeObject
                        }
                        |> BasicNormativeTriple.toRDFTriple)
                    |> Generic.List
                )
            match this.context with
            | Some context -> Some(rdfGraph.SetContext context)
            | None -> Some rdfGraph
        | _ -> None
    static member ofRDFGraph(rdfGraph: RDFGraph) =
        let fullNormativeTripleSet =
            rdfGraph
            |> Seq.map (fun rdfTriple -> FullNormativeTriple.ofRDFTriple rdfTriple)
            |> Set.ofSeq
        {
            context =
                match Option.ofNullOrWhiteSpace rdfGraph.Context with
                | Some uri -> Some(Iri.ofUri uri)
                | None -> None
            fullNormativeTripleSet = fullNormativeTripleSet
        }

    static member op_Implicit(rdfGraph: RDFGraph) = FullNormativeGraph.ofRDFGraph rdfGraph
and FullNormativeQuadruple = {
    fullNormativeTriple: FullNormativeTriple
    graphName: GraphName option
}
and FullNormativeNamedGraph = {
    fullNormativeGraph: FullNormativeGraph
    graphName: GraphName
}
and FullNormativeDataset = {
    defaultGraph: FullNormativeGraph
    namedGraphs: FullNormativeNamedGraph list
}

module RdfInteroperability =

    let private rdfIri (localName: string) : Iri =
        RDFNamespace.rdf.prefixedName localName |> AbbreviatedIRI

    let private rdfType = rdfIri "type"
    let private rdfPropositionForm = rdfIri "PropositionForm"
    let private rdfPropositionFormSubject = rdfIri "propositionFormSubject"
    let private rdfPropositionFormPredicate = rdfIri "propositionFormPredicate"
    let private rdfPropositionFormObject = rdfIri "propositionFormObject"

    let private subjectAsBasicObject (normativeSubject: NormativeSubject) =
        match normativeSubject with
        | IriSubject iri -> IriObject iri
        | BNodeSubject bnode -> BNodeObject bnode

    let private predicateAsBasicObject (normativePredicate: NormativePredicate) =
        match normativePredicate with
        | IriPredicate iri -> IriObject iri

    let private structuralTriple (subject: BNode) (predicate: Iri) (objectValue: BasicNormativeObject) = {
        normativeSubject = BNodeSubject subject
        normativePredicate = IriPredicate predicate
        basicNormativeObject = objectValue
    }

    let private isPropositionFormMarker (fullNormativeTriple: FullNormativeTriple) =
        match fullNormativeTriple.normativeSubject, fullNormativeTriple.normativePredicate, fullNormativeTriple.fullNormativeObject with
        | BNodeSubject _, IriPredicate predicate, BasicNormativeObject(IriObject objectIri) when predicate = rdfType && objectIri = rdfPropositionForm -> true
        | _ -> false

    let private existingBlankNodeIdentities (fullNormativeGraph: FullNormativeGraph) =
        let rec collectTriple (identities: Set<string>) (fullNormativeTriple: FullNormativeTriple) =
            let identities =
                match fullNormativeTriple.normativeSubject with
                | BNodeSubject bnode -> identities.Add bnode.identity
                | IriSubject _ -> identities

            match fullNormativeTriple.fullNormativeObject with
            | BasicNormativeObject(BNodeObject bnode) -> identities.Add bnode.identity
            | BasicNormativeObject _ -> identities
            | TripleTermObject(TripleTerm tripleTerm) -> collectTriple identities tripleTerm

        fullNormativeGraph.fullNormativeTripleSet |> Seq.fold collectTriple Set.empty

    /// RDF 1.2 Interoperability: Full -> Basic basic encoding.
    let basicEncode (fullNormativeGraph: FullNormativeGraph) : BasicNormativeGraph =
        let hasTripleTerms =
            fullNormativeGraph.fullNormativeTripleSet
            |> Seq.exists (fun triple -> triple.fullNormativeObject.IsTripleTermObject)

        let hasPropositionFormMarker = fullNormativeGraph.fullNormativeTripleSet |> Seq.exists isPropositionFormMarker

        if hasTripleTerms && hasPropositionFormMarker then
            invalidOp "RDF 1.2 basic encoding is undefined for a hybrid graph containing both triple terms and blank-node rdf:PropositionForm markers."

        let generatedScope =
            fullNormativeGraph.context
            |> Option.map (fun iri -> iri.identity)
            |> Option.defaultValue String.Empty

        // Freshness is checked on the exported blank-node identity, not only on
        // Doxaletheia's (scope, identity) equality, because external RDF libraries
        // generally expose the identifier without our scope component.
        let mutable usedBlankNodeIdentities = existingBlankNodeIdentities fullNormativeGraph

        let freshBlankNode () =
            let rec create () =
                let sinsignId = Guid.NewGuid()
                let identity = sinsignId.ToString("N")

                if usedBlankNodeIdentities.Contains identity then
                    create ()
                else
                    usedBlankNodeIdentities <- usedBlankNodeIdentities.Add identity
                    {
                        sinsignId = sinsignId
                        scope = generatedScope
                        localIdentifier = None
                    }

            create ()

        let tripleTermMap = System.Collections.Generic.Dictionary<FullNormativeTriple, BNode>()

        let outputTriples = ResizeArray<BasicNormativeTriple>()

        let rec encodeObject (fullNormativeObject: FullNormativeObject) : BasicNormativeObject =
            match fullNormativeObject with
            | BasicNormativeObject basicObject -> basicObject
            | TripleTermObject tripleTerm -> encodeTripleTerm tripleTerm |> BNodeObject

        and encodeTripleTerm (tripleTerm: TripleTerm) : BNode =
            let (TripleTerm triple) = tripleTerm

            match tripleTermMap.TryGetValue triple with
            | true, existingBlankNode -> existingBlankNode
            | false, _ ->
                let encodedObject = encodeObject triple.fullNormativeObject
                let blankNode = freshBlankNode ()
                tripleTermMap.Add(triple, blankNode)

                outputTriples.Add(structuralTriple blankNode rdfType (IriObject rdfPropositionForm))
                outputTriples.Add(structuralTriple blankNode rdfPropositionFormSubject (subjectAsBasicObject triple.normativeSubject))
                outputTriples.Add(structuralTriple blankNode rdfPropositionFormPredicate (predicateAsBasicObject triple.normativePredicate))
                outputTriples.Add(structuralTriple blankNode rdfPropositionFormObject encodedObject)

                blankNode

        for fullTriple in fullNormativeGraph.fullNormativeTripleSet do
            outputTriples.Add {
                normativeSubject = fullTriple.normativeSubject
                normativePredicate = fullTriple.normativePredicate
                basicNormativeObject = encodeObject fullTriple.fullNormativeObject
            }

        {
            context = fullNormativeGraph.context
            basicNormativeTripleSet = outputTriples |> Set.ofSeq
        }

    type private PropositionFormDefinition = {
        subject: NormativeSubject
        predicate: NormativePredicate
        objectValue: BasicNormativeObject
        structuralTriples: Set<BasicNormativeTriple>
    }

    let private exactlyOne (blankNode: BNode) (propertyName: string) (values: BasicNormativeObject list) =
        match values with
        | [ value ] -> value
        | [] -> invalidOp $"Cannot basic-decode rdf:PropositionForm blank node {blankNode.identity}: missing rdf:{propertyName}."
        | _ -> invalidOp $"Cannot basic-decode rdf:PropositionForm blank node {blankNode.identity}: rdf:{propertyName} is ambiguous."

    /// RDF 1.2 Interoperability: Basic -> Full reverse transformation.
    /// The current W3C draft specifies this direction in prose; this implements
    /// that prose recursively so nested encoded triple terms are reconstructed.
    let basicDecode (basicNormativeGraph: BasicNormativeGraph) : FullNormativeGraph =
        let triples = basicNormativeGraph.basicNormativeTripleSet

        let propositionFormBlankNodes =
            triples
            |> Seq.choose (fun triple ->
                match triple.normativeSubject, triple.normativePredicate, triple.basicNormativeObject with
                | BNodeSubject bnode, IriPredicate predicate, IriObject objectIri when predicate = rdfType && objectIri = rdfPropositionForm -> Some bnode
                | _ -> None)
            |> Set.ofSeq

        let valuesFor (blankNode: BNode) (predicateIri: Iri) =
            triples
            |> Seq.choose (fun triple ->
                match triple.normativeSubject, triple.normativePredicate with
                | BNodeSubject subject, IriPredicate predicate when subject = blankNode && predicate = predicateIri -> Some triple.basicNormativeObject
                | _ -> None)
            |> Set.ofSeq
            |> Set.toList

        let definitionFor (blankNode: BNode) =
            let subjectValue =
                valuesFor blankNode rdfPropositionFormSubject
                |> exactlyOne blankNode "propositionFormSubject"

            let predicateValue =
                valuesFor blankNode rdfPropositionFormPredicate
                |> exactlyOne blankNode "propositionFormPredicate"

            let objectValue =
                valuesFor blankNode rdfPropositionFormObject
                |> exactlyOne blankNode "propositionFormObject"

            let subject =
                match subjectValue with
                | IriObject iri -> IriSubject iri
                | BNodeObject bnode -> BNodeSubject bnode
                | LiteralValueObject _ ->
                    invalidOp $"Cannot basic-decode rdf:PropositionForm blank node {blankNode.identity}: rdf:propositionFormSubject is not an IRI or blank node."

            let predicate =
                match predicateValue with
                | IriObject iri -> IriPredicate iri
                | _ -> invalidOp $"Cannot basic-decode rdf:PropositionForm blank node {blankNode.identity}: rdf:propositionFormPredicate is not an IRI."

            let structuralTriples =
                [
                    structuralTriple blankNode rdfType (IriObject rdfPropositionForm)
                    structuralTriple blankNode rdfPropositionFormSubject subjectValue
                    structuralTriple blankNode rdfPropositionFormPredicate predicateValue
                    structuralTriple blankNode rdfPropositionFormObject objectValue
                ]
                |> Set.ofList

            {
                subject = subject
                predicate = predicate
                objectValue = objectValue
                structuralTriples = structuralTriples
            }

        let definitions =
            propositionFormBlankNodes
            |> Seq.map (fun blankNode -> blankNode, definitionFor blankNode)
            |> Map.ofSeq

        let structuralTriples =
            definitions
            |> Map.toSeq
            |> Seq.collect (fun (_, definition) -> definition.structuralTriples)
            |> Set.ofSeq

        let remainingTriples = Set.difference triples structuralTriples

        // A blank node minted by basic-encode can only have replaced a triple term
        // in object position. If it survives as a subject after removing the four
        // structural triples, the graph was not produced by a valid basic encoding
        // that can be represented by our normative Full model.
        remainingTriples
        |> Seq.iter (fun triple ->
            match triple.normativeSubject with
            | BNodeSubject bnode when definitions.ContainsKey bnode ->
                invalidOp
                    $"Cannot basic-decode rdf:PropositionForm blank node {bnode.identity}: the encoding blank node also occurs as the subject of a non-structural triple."
            | _ -> ())

        let decodedTripleTerms = System.Collections.Generic.Dictionary<BNode, TripleTerm>()

        let rec decodeBlankNode (visiting: Set<BNode>) (blankNode: BNode) : TripleTerm =

            match decodedTripleTerms.TryGetValue blankNode with
            | true, tripleTerm -> tripleTerm
            | false, _ ->
                if visiting.Contains blankNode then
                    invalidOp $"Cannot basic-decode rdf:PropositionForm blank node {blankNode.identity}: cyclic proposition-form structure."

                let definition = definitions[blankNode]
                let visiting = visiting.Add blankNode

                match definition.subject with
                | BNodeSubject subjectBlankNode when definitions.ContainsKey subjectBlankNode ->
                    invalidOp $"Cannot basic-decode rdf:PropositionForm blank node {blankNode.identity}: decoding would place a triple term in subject position."
                | _ -> ()

                let decodedObject =
                    match definition.objectValue with
                    | BNodeObject objectBlankNode when definitions.ContainsKey objectBlankNode -> decodeBlankNode visiting objectBlankNode |> TripleTermObject
                    | basicObject -> BasicNormativeObject basicObject

                let tripleTerm =
                    TripleTerm {
                        normativeSubject = definition.subject
                        normativePredicate = definition.predicate
                        fullNormativeObject = decodedObject
                    }

                decodedTripleTerms.Add(blankNode, tripleTerm)
                tripleTerm

        let decodedTriples =
            remainingTriples
            |> Seq.map (fun basicTriple ->
                let fullObject =
                    match basicTriple.basicNormativeObject with
                    | BNodeObject bnode when definitions.ContainsKey bnode -> decodeBlankNode Set.empty bnode |> TripleTermObject
                    | basicObject -> BasicNormativeObject basicObject

                {
                    normativeSubject = basicTriple.normativeSubject
                    normativePredicate = basicTriple.normativePredicate
                    fullNormativeObject = fullObject
                })
            |> Set.ofSeq

        {
            context = basicNormativeGraph.context
            fullNormativeTripleSet = decodedTriples
        }

type BasicNormativeGraph with
    member this.basicDecode = RdfInteroperability.basicDecode this

    static member toRDFGraph(basicNormativeGraph: BasicNormativeGraph) =
        let rdfGraph =
            new RDFGraph(
                basicNormativeGraph.basicNormativeTripleSet
                |> Seq.map BasicNormativeTriple.toRDFTriple
                |> Generic.List
            )

        match basicNormativeGraph.context with
        | Some context -> rdfGraph.SetContext context
        | None -> rdfGraph

    member this.asRDFGraph = BasicNormativeGraph.toRDFGraph this

    static member ofRDFGraph(rdfGraph: RDFGraph) = {
        context =
            match Option.ofNullOrWhiteSpace rdfGraph.Context with
            | Some uri -> Some(Iri.ofUri uri)
            | None -> None
        basicNormativeTripleSet = rdfGraph |> Seq.map BasicNormativeTriple.ofRDFTriple |> Set.ofSeq
    }

type FullNormativeGraph with
    member this.basicEncode = RdfInteroperability.basicEncode this

    member this.asBasicEncodedRDFGraph = this.basicEncode.asRDFGraph

type RDFNamespace with
    member this.curie(localName: string) : Iri =
        this.prefixedName localName |> AbbreviatedIRI

type RDFNamespaceRegister with
    static member tryFindIri(iri: Iri) =
        match RDFNamespaceRegister.GetByUri(iri, false) |> Option.ofObj with
        | Some rdfNamespace -> Some rdfNamespace
        | None ->
            match RDFNamespaceRegister.GetByUri(iri, true) |> Option.ofObj with
            | Some rdfNamespace -> Some rdfNamespace
            | None -> None
    static member findIri(iri: Iri) =
        RDFNamespaceRegister.tryFindIri iri |> Option.get
    static member tryFindPrefix(prefix: string) =
        match RDFNamespaceRegister.GetByPrefix(prefix, false) |> Option.ofObj with
        | Some rdfNamespace -> Some rdfNamespace
        | None ->
            match RDFNamespaceRegister.GetByPrefix(prefix, true) |> Option.ofObj with
            | Some rdfNamespace -> Some rdfNamespace
            | None -> None
    static member findPrefix(prefix: string) =
        RDFNamespaceRegister.tryFindPrefix prefix |> Option.get
    static member tryAddNamespace(rdfNamespace: RDFNamespace) =
        RDFNamespaceRegister.AddNamespace rdfNamespace
        match RDFNamespaceRegister.tryFindIri rdfNamespace with
        | Some registeredNamespace when
            registeredNamespace.NamespacePrefix = rdfNamespace.NamespacePrefix
            && registeredNamespace.NamespaceUri = rdfNamespace.NamespaceUri
            ->
            Ok registeredNamespace
        | _ ->
            match RDFNamespaceRegister.tryFindIri rdfNamespace, RDFNamespaceRegister.tryFindPrefix rdfNamespace.NamespacePrefix with
            | Some iriCollision, _ -> Error iriCollision
            | _, Some prefixCollision -> Error prefixCollision
            | _, _ -> Error rdfNamespace

    static member tryAddPrefix((namespacePrefix: string), (namespaceIri: Iri), (dereferenceIri: Iri)) =
        let rdfNamespace = RDFNamespace(namespacePrefix, namespaceIri)
        rdfNamespace.SetDereferenceUri dereferenceIri
        |> RDFNamespaceRegister.tryAddNamespace
    static member tryAddPrefix((namespacePrefix: string), (namespaceIri: Iri)) =
        RDFNamespace(namespacePrefix, namespaceIri)
        |> RDFNamespaceRegister.tryAddNamespace

    static member ensurePrefix((namespacePrefix: string), (namespaceIri: Iri), (dereferenceIri: Iri)) =
        RDFNamespaceRegister.RemoveByUri namespaceIri
        RDFNamespaceRegister.RemoveByPrefix namespacePrefix
        RDFNamespaceRegister.tryAddPrefix (namespacePrefix, namespaceIri, dereferenceIri)
        |> Result.get
    static member ensurePrefix((namespacePrefix: string), (namespaceIri: Iri)) =
        RDFNamespaceRegister.RemoveByUri namespaceIri
        RDFNamespaceRegister.RemoveByPrefix namespacePrefix
        RDFNamespaceRegister.tryAddPrefix (namespacePrefix, namespaceIri) |> Result.get
type Iri with

    member this.localDelimiter = this.identity.ToCharArray() |> Array.last |> string

    member this.localPart =
        match UrlPattern.Create(UrlPatternInit()).Match this.identity |> Option.ofObj with
        | Some urlPatternMatch when not (String.IsNullOrWhiteSpace urlPatternMatch.Hash.Input) -> urlPatternMatch.Hash.Input
        | Some urlPatternMatch -> urlPatternMatch.Pathname.Input.Split("/") |> Array.last
        | None -> String.Empty
    member this.delimiterName =
        match this.localDelimiter with
        | "/" -> "&sol;"
        | "#" -> "&num;"
        | _ -> String.Empty

    member this.reverseHostPath = this.asUri.Host.Split('.') |> Array.rev |> String.concat "\\"
    member this.localDocumentPath =

        DriveInfo.preferredDrive.Name
        + this.asUri.Scheme
        + "\\"
        + this.reverseHostPath
        + this.asUri.LocalPath.Replace("/", "\\").TrimEnd('\\')
        + this.delimiterName
    member this.localTurtlePath = Path.Combine(this.localDocumentPath, "text", "turtle.ttl")

type RDFNamespace with
    member this.NamespaceIri = Iri.op_Implicit this.NamespaceUri
type RDFGraph with
    static member ofRDFNamespace(rdfNamespace: RDFNamespace) =
        RDFGraph.FromFile(RDFModelEnums.RDFFormats.Turtle, rdfNamespace.NamespaceIri.localTurtlePath, true)
    member this.ToTurtle(turtlePath: string) =
        this.ToFileAsync(RDFModelEnums.RDFFormats.Turtle, turtlePath)
        |> Async.AwaitTask
        |> Async.RunSynchronously

type IGraph with
    member this.namespaceUriNodes(rdfNamespace: RDFNamespace) =
        this.AllNodes.UriNodes()
        |> Seq.filter (fun uriNode -> rdfNamespace.UrlPattern.IsMatch uriNode.Uri.OriginalString)
    member this.tryFullNormativeGraph = FullNormativeGraph.tryIGraph this

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
type OWLOntologyView with
    static member tryOntologyGraph(ontologyGraph: OntologyGraph) =
        match ontologyGraph.tryFullNormativeGraph with
        | Some fullyNormativeGraph ->
            fullyNormativeGraph.tryRDFGraph
            |> Option.map (fun rdfGraph -> new OWLOntologyView(OWLOntology.FromRDFGraphAsync(rdfGraph).Result))
        | None -> None
type OntologyClass with
    static member ofOWLClass((owlClass: OWLClass), (owlOntology: OWLOntology)) =
        new OntologyClass(
            Iri.ofOWLClass owlClass,
            owlOntology.ToRDFGraphAsync().Result
            |> FullNormativeGraph.ofRDFGraph
            |> _.asThreadSafeGraph
        )
type OWLClassView with
    static member tryOntologyClass((ontologyClass: OntologyClass), (ontologyGraph: OntologyGraph)) =
        match ontologyGraph.tryFullNormativeGraph, Iri.tryOntologyResource ontologyClass with
        | Some fullyNormativeGraph, Some iri ->
            fullyNormativeGraph.tryRDFGraph
            |> Option.map (fun rdfGraph -> new OWLClassView(iri, OWLOntology.FromRDFGraphAsync(rdfGraph).Result))
        | _, _ -> None

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
    static member tryOntologyGraph(ontologyGraph: OntologyGraph) =
        match ontologyGraph.tryFullNormativeGraph with
        | Some fullyNormativeGraph ->
            fullyNormativeGraph.tryRDFGraph
            |> Option.map (fun rdfGraph -> OWLOntology.FromRDFGraphAsync(rdfGraph) |> fun task -> task.Result)
        | None -> None

type OntologyGraph with

    member this.tryOWLClassViews(rdfNamespace: RDFNamespace) =
        match OWLOntology.tryOntologyGraph this with
        | Some owlOntology ->
            this.namespaceOwlClasses rdfNamespace
            |> Seq.choose (fun ontologyClass ->
                match Iri.tryOntologyResource ontologyClass with
                | Some iri -> new OWLClassView(iri, owlOntology) |> Some
                | _ -> None)

            |> Seq.toArray
            |> Some
        | None -> None

    member this.tryOWLDataPropertyViews(rdfNamespace: RDFNamespace) =
        match OWLOntology.tryOntologyGraph this with
        | Some owlOntology ->
            this.namespaceOwlDatatypeProperties rdfNamespace
            |> Seq.choose (fun ontologyProperty ->
                match Iri.tryOntologyResource ontologyProperty with
                | Some iri -> new OWLDataPropertyView(OWLDataProperty iri, owlOntology) |> Some
                | _ -> None)
            |> Seq.toArray
            |> Some
        | None -> None
    member this.namespaceOWLObjectPropertyViews(rdfNamespace: RDFNamespace) =
        match OWLOntology.tryOntologyGraph this with
        | Some owlOntology ->

            this.namespaceOwlObjectProperties rdfNamespace
            |> Seq.choose (fun ontologyProperty ->
                match Iri.tryOntologyResource ontologyProperty with
                | Some iri -> new OWLObjectPropertyView(OWLObjectProperty iri, owlOntology) |> Some
                | _ -> None)
            |> Seq.toArray
            |> Some
        | None -> None

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
type OWLIndividualExpression with
    member this.a<'ClassExpression when 'ClassExpression :> OWLClassExpression>(classExpression: 'ClassExpression) =
        match this with
        | :? OWLNamedIndividual as namedIndividual -> OWLClassAssertion(classExpression, namedIndividual)
        | :? OWLAnonymousIndividual as anonymousIndividual -> OWLClassAssertion(classExpression, anonymousIndividual)

type OWLClass with
    member this.Class = this :> OWLClassExpression

module xsd =
    let _namespace = RDFNamespace.xsd
    let anyType = _namespace.curie "anyType" |> DatatypeIri
    let anySimpleType = _namespace.curie "anySimpleType" |> DatatypeIri
    let anyAtomicType = _namespace.curie "anyAtomicType" |> DatatypeIri
    let anyURI = _namespace.curie "anyURI" |> DatatypeIri
    let base64Binary = _namespace.curie "base64Binary" |> DatatypeIri
    let boolean = _namespace.curie "boolean" |> DatatypeIri
    let date = _namespace.curie "date" |> DatatypeIri
    let dateTime = _namespace.curie "dateTime" |> DatatypeIri
    let dateTimeStamp = _namespace.curie "dateTimeStamp" |> DatatypeIri
    let decimal = _namespace.curie "decimal" |> DatatypeIri
    let integer = _namespace.curie "integer" |> DatatypeIri
    let long = _namespace.curie "long" |> DatatypeIri
    let int = _namespace.curie "int" |> DatatypeIri
    let short = _namespace.curie "short" |> DatatypeIri
    let byte = _namespace.curie "byte" |> DatatypeIri
    let nonNegativeInteger = _namespace.curie "nonNegativeInteger" |> DatatypeIri
    let positiveInteger = _namespace.curie "positiveInteger" |> DatatypeIri
    let unsignedLong = _namespace.curie "unsignedLong" |> DatatypeIri
    let unsignedInt = _namespace.curie "unsignedInt" |> DatatypeIri
    let unsignedShort = _namespace.curie "unsignedShort" |> DatatypeIri
    let unsignedByte = _namespace.curie "unsignedByte" |> DatatypeIri
    let nonPositiveInteger = _namespace.curie "nonPositiveInteger" |> DatatypeIri
    let negativeInteger = _namespace.curie "negativeInteger" |> DatatypeIri
    let double = _namespace.curie "double" |> DatatypeIri
    let duration = _namespace.curie "duration" |> DatatypeIri
    let dayTimeDuration = _namespace.curie "dayTimeDuration" |> DatatypeIri
    let yearMonthDuration = _namespace.curie "yearMonthDuration" |> DatatypeIri
    let float = _namespace.curie "float" |> DatatypeIri
    let gDay = _namespace.curie "gDay" |> DatatypeIri
    let gMonth = _namespace.curie "gMonth" |> DatatypeIri
    let gMonthDay = _namespace.curie "gMonthDay" |> DatatypeIri
    let gYear = _namespace.curie "gYear" |> DatatypeIri
    let gYearMonth = _namespace.curie "gYearMonth" |> DatatypeIri
    let hexBinary = _namespace.curie "hexBinary" |> DatatypeIri
    let NOTATION = _namespace.curie "NOTATION" |> DatatypeIri
    let QName = _namespace.curie "QName" |> DatatypeIri
    let string = _namespace.curie "string" |> DatatypeIri
    let normalizedString = _namespace.curie "normalizedString" |> DatatypeIri
    let token = _namespace.curie "token" |> DatatypeIri
    let language = _namespace.curie "language" |> DatatypeIri
    let Name = _namespace.curie "Name" |> DatatypeIri
    let NCName = _namespace.curie "NCName" |> DatatypeIri
    let ENTITY = _namespace.curie "ENTITY" |> DatatypeIri
    let ID = _namespace.curie "ID" |> DatatypeIri
    let IDREF = _namespace.curie "IDREF" |> DatatypeIri
    let NMTOKEN = _namespace.curie "NMTOKEN" |> DatatypeIri
    let time = _namespace.curie "time" |> DatatypeIri
    let ENTITIES = _namespace.curie "ENTITIES" |> DatatypeIri
    let IDREFS = _namespace.curie "IDREFS" |> DatatypeIri
    let NMTOKENS = _namespace.curie "NMTOKENS" |> DatatypeIri
    let schema = _namespace.curie "schema"
    let group = _namespace.curie "group"
    let element = _namespace.curie "element"
    let simpleType = _namespace.curie "simpleType"
    let attribute = _namespace.curie "attribute"
    let attributeGroup = _namespace.curie "attributeGroup"
    let anyAttribute = _namespace.curie "anyAttribute"
    let assert_ = _namespace.curie "assert"
    let complexContent = _namespace.curie "complexContent"
    let restriction = _namespace.curie "restriction"
    let extension = _namespace.curie "extension"
    let openContent = _namespace.curie "openContent"
    let any = _namespace.curie "any"
    let defaultOpenContent = _namespace.curie "defaultOpenContent"
    let simpleContent = _namespace.curie "simpleContent"
    let complexType = _namespace.curie "complexType"
    let alternative = _namespace.curie "alternative"
    let all = _namespace.curie "all"
    let choice = _namespace.curie "choice"
    let sequence = _namespace.curie "sequence"
    let include_ = _namespace.curie "include"
    let redefine = _namespace.curie "redefine"
    let override_ = _namespace.curie "override"
    let import = _namespace.curie "import"
    let selector = _namespace.curie "selector"
    let field = _namespace.curie "field"
    let unique = _namespace.curie "unique"
    let key = _namespace.curie "key"
    let keyref = _namespace.curie "keyref"
    let notation = _namespace.curie "notation"
    let appinfo = _namespace.curie "appinfo"
    let documentation = _namespace.curie "documentation"
    let annotation = _namespace.curie "annotation"
    let facet = _namespace.curie "facet"
    let list = _namespace.curie "list"
    let union = _namespace.curie "union"
    let minExclusive = _namespace.curie "minExclusive"
    let minInclusive = _namespace.curie "minInclusive"
    let maxExclusive = _namespace.curie "maxExclusive"
    let maxInclusive = _namespace.curie "maxInclusive"
    let totalDigits = _namespace.curie "totalDigits"
    let fractionDigits = _namespace.curie "fractionDigits"
    let length = _namespace.curie "length"
    let minLength = _namespace.curie "minLength"

    (*
    // TODO deal with actual restriction values like how the value of minLength  ·must· be a nonNegativeInteger.
    // https://www.w3.org/TR/xmlschema-2/#rf-minLength
    module minLength =
        let iri = _namespace.curie "minLength"
        let facet (maybeNonNegativeInteger:int) = 
            new OWLFacetRestriction( {
                    lexicalForm = if maybeNonNegativeInteger < 0 then "0" else $"{maybeNonNegativeInteger}"
                    datatype = nonNegativeInteger
                }, iri)
*)

    let maxLength = _namespace.curie "maxLength"
    let enumeration = _namespace.curie "enumeration"
    let whiteSpace = _namespace.curie "whiteSpace"
    let pattern = _namespace.curie "pattern"
    let assertion = _namespace.curie "assertion"
    let explicitTimezone = _namespace.curie "explicitTimezone"
// module Owl2 =
//     module FunctionalSyntax =
type DirectlyImportsDocuments = Import of Iri
type OntologyAnnotation = OntologyAnnotation of OWLAnnotation
type Declaration = Declaration of AxiomAnnotation list * Entity
and AxiomAnnotation = AxiomAnnotation of OWLAnnotation
and Entity =
    | Class of OWLClass
    | Datatype of OWLDatatype
    | ObjectProperty of OWLObjectProperty
    | DataProperty of OWLDataProperty
    | AnnotationProperty of OWLAnnotationProperty
    | NamedIndividual of OWLNamedIndividual
