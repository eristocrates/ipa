// TODO use dynamic operator for namespacenames for adhoc local names
// TODO add op_Implicits to literal values

#time on

fsi.PrintLength <- 1
fsi.PrintSize <- 3000
fsi.ShowDeclarationValues <- true

#I @"D:\https\com\github\eristocrates\ipa\dll"
#r "DoxAletheia.Core.dll"
open DoxAletheia.Core
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

type IGraph with
    member this.tryFullNormativeGraph = FullNormativeGraph.tryIGraph this
