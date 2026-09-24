#time on

fsi.PrintLength <- 10
fsi.PrintSize <- 100

// fsi.ShowDeclarationValues <- false
#I @"D:\https\com\github\eristocrates\ipa\dll"
#r "SharedKernel.dll"
#r "StringModule.dll"

#r @"Internet.dll"
#r @"TopLevelDomain.dll"
#r @"IanaScheme.dll"
#r @"IanaMimeType.dll"
#r "ManualDistributions.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load "PrettierNaming.fsx"
#load "Ast.fsx"

open SharedKernel
open StringModule
open ManualDistributions
open Internet

#I @"D:\https\com\github\eristocrates\ipa\fsx\Sites"

#load @".paket/load/main.group.fsx"
open System
open System
open System.IO
open System.Text
open System.Text.RegularExpressions
open System.Threading.Tasks
open System
open System.Net.Http
open System.Threading
open System.Threading.Tasks
open System.Net
open System.Xml.Linq
open System.IO.Compression
open System.Xml
open System.Globalization
open VDS.RDF
open VDS.RDF.Query
open VDS.RDF.Query.Expressions
open VDS.RDF.Query.Builder
open VDS.RDF.Query.Patterns
open VDS.RDF.Query.Datasets
open VDS.RDF.Parsing
open VDS.RDF.Query.Inference
open VDS.RDF.Ontology
open System.IO
open RDFSharp.Model
open FSharp.HashCollections
open Dubzer.WhatwgUrl
open ktsu.Semantics.Paths
open PuppeteerSharp
open PuppeteerSharp.Cdp
open NLanguageTag
open Tavis.UriTemplates
open System.Web
open FSharp.Data.Adaptive.Transaction
open FSharp.Collections.ParallelSeq


let distributionMap =
    graphDistributions
    |> Array.map (fun namespaceName -> namespaceName.namespaceIri.lexicalForm, namespaceName)
    |> Map.ofArray

























type InitialTextDirection =
    | Ltr
    | Rtl

    member this.asString = this.ToString().ToLowerInvariant()

type BlankReference = {
    blankNodeIdentifier: string
} with

    static member fromBlankNode(blankNode: VDS.RDF.BlankNode) = {
        blankNodeIdentifier = blankNode.InternalID
    }
    member this.lexicalForm = this.blankNodeIdentifier
    member this.curie = "_:" + this.blankNodeIdentifier
    member this.asBlankNode = new VDS.RDF.BlankNode(this.blankNodeIdentifier)
    member this.asINode: INode = this.asBlankNode





type PrefixId = {
    namespaceName: NamespaceName
    namespacePrefix: string
} with

    static member fromRDFNamespaceRegister(namespaceString: string) =
        RDFNamespaceRegister.GetByUri(namespaceString, false)
        |> Option.ofNullOrWhiteSpace
    static member fromPrefixcc(namespaceString: string) =
        RDFNamespaceRegister.GetByUri(namespaceString, true)
        |> Option.ofNullOrWhiteSpace


    static member fromNamespaceLabel (namespaceString: string) (prefixString: string) =
        let prefixId = {
            namespaceName = NamespaceName.fromString namespaceString
            namespacePrefix = prefixString
        }
        namespaceMapper.AddNamespace(prefixId.asNamespaceMap)
        prefixId

    static member rdf = PrefixId.fromNamespaceLabel "http://www.w3.org/1999/02/22-rdf-syntax-ns#" "rdf"
    static member rdfs = PrefixId.fromNamespaceLabel "http://www.w3.org/2000/01/rdf-schema#" "rdfs"
    static member owl = PrefixId.fromNamespaceLabel "http://www.w3.org/2002/07/owl#" "owl"
    static member xsd = PrefixId.fromNamespaceLabel "http://www.w3.org/2001/XMLSchema#" "xsd"
    static member xsi = PrefixId.fromNamespaceLabel "http://www.w3.org/2001/XMLSchema-instance#" "xsi"
    static member xdt = PrefixId.fromNamespaceLabel "https://www.w3.org/2003/05/xpath-datatypes#" "xdt"
    static member owlTime = PrefixId.fromNamespaceLabel "http://www.w3.org/2006/time#" "owlTime"
    static member i18n =
        let iri = Iri.fromString "https://www.w3.org/ns/i18n#"
        {
            namespaceName = {
                namespaceIri = iri
                iriSpace = {
                    siteRoot = iri.site
                    pathTemplate = UriTemplate "https://www.w3.org/ns/i18n#{languageTag}_{baseDirection}"
                }
                graphDistribution = None
                datasetDistribution = [||]
            }

            namespacePrefix = "i18n"
        }

    member this.prefixedName(localName: string) = {
        prefixId = this
        localName = localName
    }
    member this.XNamespace = XNamespace.op_Implicit this.namespaceName.namespaceIri.lexicalForm
    member this.XName(localName: string) = XNamespace.Xmlns + localName
    member this.asRDFNamespace = new RDFNamespace(this.namespacePrefix, this.namespaceName.namespaceIri.lexicalForm)
    member this.asNamespaceMap = this.namespacePrefix, this.namespaceName.namespaceIri.asUri
    member this.namespaceUrl = this.namespaceName.namespaceIri.asUrl
    member this.namespaceUri = this.namespaceName.namespaceIri.asUri



and [<CustomComparison; CustomEquality>] PrefixedName = {
    prefixId: PrefixId
    localName: string
} with

    member this.lexicalForm = this.prefixId.namespaceName.namespaceIri.lexicalForm + this.localName
    member this.identity = this.lexicalForm

    override this.Equals(other: obj) =
        match other with
        | :? Iri as other -> this.identity = other.identity
        | :? PrefixedName as other -> this.identity = other.identity
        | _ -> false
    override this.GetHashCode() = this.lexicalForm.GetHashCode()
    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? Iri as other -> compare this.identity other.identity
            | :? PrefixedName as other -> compare this.identity other.identity
            | _ -> invalidArg (nameof other) (sprintf "%s can only be compared with %s or %s" typeof<PrefixedName>.Name typeof<PrefixedName>.Name typeof<Iri>.Name)













































type NLanguageTag.LanguageTag with
    member this.asString = this.ToString()



type DataPoint =
    | IriPoint of RdfIri
    | BlankPoint of BlankReference
    | LiteralPoint of RdfLiteral
    | VariablePoint of RdfVariable
    | TriplePoint of RdfTripleTerm
    | FormulaPoint of Formula

    static member fromINode(inode: INode) =
        match inode.NodeType with
        | NodeType.Uri -> inode :?> UriNode |> RdfIri.fromUriNode |> IriPoint
        | NodeType.Blank -> inode :?> BlankNode |> BlankReference.fromBlankNode |> BlankPoint
        | NodeType.Literal -> inode :?> LiteralNode |> RdfLiteral.fromLiteralNode |> LiteralPoint
        | NodeType.Triple -> inode :?> TripleNode |> RdfTripleTerm.fromTripleNode |> TriplePoint
        | NodeType.Variable -> inode :?> VariableNode |> RdfVariable.fromVariableNode |> VariablePoint
        | NodeType.GraphLiteral -> inode :?> GraphLiteralNode |> Formula.fromGraphLiteralNode |> FormulaPoint
    member this.lexicalForm =
        match this with
        | IriPoint iri -> iri.lexicalForm
        | BlankPoint blankNode -> blankNode.lexicalForm
        | LiteralPoint literal -> literal.lexicalForm
        | VariablePoint variable -> variable.lexicalForm
        | TriplePoint tripleTerm -> tripleTerm.lexicalForm
        | FormulaPoint formula -> formula.lexicalForm
    member this.maybeCurie =
        match this with
        | IriPoint iri -> iri.maybeCurie
        | BlankPoint blankNode -> Some blankNode.curie
        | LiteralPoint literal -> literal.maybeCurie
        | VariablePoint variable -> None
        | TriplePoint tripleTerm -> Some tripleTerm.curiesAndOrLexicalForms
        | FormulaPoint formula -> Some formula.curiesAndOrLexicalForms

and [<CustomComparison; CustomEquality>] DirectedArc = {
    fromTail: DataPoint
    legisignId: DataPoint
    toHead: DataPoint
    sinsignId: Guid
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
            | _ -> invalidArg (nameof other) (sprintf "%s can only be compared with %s" typeof<DirectedArc>.Name typeof<DirectedArc>.Name)
and Vertex =
    | SubjectVertex of RdfSubject
    | ObjectVertex of RdfObject
and Edge =
    | PredicateEdge of RdfPredicate
    | TripleEdge of RdfTriple
and [<CustomComparison; CustomEquality>] RdfIri =
    | IRIREF of Iri
    | PrefixedIri of PrefixedName

    static member fromUriNode(uriNode: UriNode) =
        Iri.fromString uriNode.Uri.OriginalString |> IRIREF
    member this.lexicalForm =
        match this with
        | IRIREF iri -> iri.remoteReference
        | PrefixedIri prefixedName -> prefixedName.lexicalForm
    member this.asUri = Uri this.lexicalForm
    member this.asUrl = DomUrl this.lexicalForm
    member this.maybeCurie =
        match namespaceMapper.ReduceToQName this.lexicalForm with
        | true, qname -> Some qname
        | false, _ -> None

    member this.asUriNode = new UriNode(this.asUri)
    member this.asINode: INode = this.asUriNode
    member this.identity = this.lexicalForm
    override this.Equals(other: obj) =
        match other with
        | :? Iri as other -> this.identity = other.identity
        | :? Uri as other -> this.identity = other.OriginalString
        | :? DomUrl as other -> this.identity = other.Href
        | _ -> false
    override this.GetHashCode() = this.lexicalForm.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? Iri as other -> compare this.identity other.identity
            | :? Uri as other -> compare this.identity other.OriginalString
            | :? DomUrl as other -> compare this.identity other.Href
            | _ -> invalidArg (nameof other) (sprintf "%s can only be compared with %s, %s, or %s" typeof<Iri>.Name typeof<Iri>.Name typeof<Uri>.Name typeof<DomUrl>.Name)

and RdfSubject =
    | IriSubject of RdfIri
    | BlankSubject of BlankReference
    | VariableSubject of RdfVariable

    member this.lexicalForm =
        match this with
        | IriSubject iri -> iri.lexicalForm
        | BlankSubject blankReference -> blankReference.lexicalForm
        | VariableSubject rdfVariable -> rdfVariable.lexicalForm
    static member fromINode(inode: INode) =
        match inode.NodeType with
        | NodeType.Uri -> inode :?> UriNode |> RdfIri.fromUriNode |> IriSubject
        | NodeType.Blank -> inode :?> BlankNode |> BlankReference.fromBlankNode |> BlankSubject
        | NodeType.Variable -> inode :?> VariableNode |> RdfVariable.fromVariableNode |> VariableSubject
    member this.asRdfTerm =
        match this with
        | IriSubject iri -> IriPoint iri
        | BlankSubject blankReference -> BlankPoint blankReference
        | VariableSubject rdfVariable -> VariablePoint rdfVariable
    member this.asINode =
        match this with
        | IriSubject iri -> iri.asINode
        | BlankSubject blankReference -> blankReference.asINode
        | VariableSubject rdfVariable -> rdfVariable.asINode
    member this.asPatternItem(patternBuilder: TriplePatternBuilder) : PatternItem =
        match this with
        | VariableSubject rdfVariable -> patternBuilder |> rdfVariable.asPatternItem
        | _ -> patternBuilder.PatternItemFactory.CreateNodeMatchPattern(this.asINode)
and RdfPredicate =
    | IriPredicate of RdfIri
    | VariablePredicate of RdfVariable

    member this.lexicalForm =
        match this with
        | IriPredicate iri -> iri.lexicalForm
        | VariablePredicate rdfVariable -> rdfVariable.lexicalForm
    static member fromINode(inode: INode) =
        match inode.NodeType with
        | NodeType.Uri -> inode :?> UriNode |> RdfIri.fromUriNode |> IriPredicate
        | NodeType.Variable -> inode :?> VariableNode |> RdfVariable.fromVariableNode |> VariablePredicate

    member this.asINode =
        match this with
        | IriPredicate iri -> iri.asINode
        | VariablePredicate rdfVariable -> rdfVariable.asINode
    member this.asPatternItem(patternBuilder: TriplePatternBuilder) : PatternItem =
        match this with
        | VariablePredicate rdfVariable -> patternBuilder |> rdfVariable.asPatternItem
        | _ -> patternBuilder.PatternItemFactory.CreateNodeMatchPattern(this.asINode)
    member this.asRdfTerm =
        match this with
        | IriPredicate iri -> IriPoint iri
        | VariablePredicate rdfVariable -> VariablePoint rdfVariable
and RdfObject =
    | IriObject of RdfIri
    | BlankObject of BlankReference
    | LiteralObject of RdfLiteral
    | TripleTermObject of RdfTripleTerm
    | VariableObject of RdfVariable

    member this.lexicalForm =
        match this with
        | IriObject iri -> iri.lexicalForm
        | BlankObject blankReference -> blankReference.lexicalForm
        | LiteralObject rdfLiteral -> rdfLiteral.lexicalForm
        | TripleTermObject tripleTerm -> tripleTerm.lexicalForm
        | VariableObject rdfVariable -> rdfVariable.lexicalForm
    static member fromINode(inode: INode) =
        match inode.NodeType with
        | NodeType.Uri -> inode :?> UriNode |> RdfIri.fromUriNode |> IriObject
        | NodeType.Blank -> inode :?> BlankNode |> BlankReference.fromBlankNode |> BlankObject
        | NodeType.Literal -> inode :?> LiteralNode |> RdfLiteral.fromLiteralNode |> LiteralObject
        | NodeType.Triple -> inode :?> TripleNode |> RdfTripleTerm.fromTripleNode |> TripleTermObject
        | NodeType.Variable -> inode :?> VariableNode |> RdfVariable.fromVariableNode |> VariableObject

    member this.asRdfTerm =
        match this with
        | IriObject iri -> IriPoint iri
        | BlankObject blankReference -> BlankPoint blankReference
        | LiteralObject rdfLiteral -> LiteralPoint rdfLiteral
        | TripleTermObject tripleTerm -> TriplePoint tripleTerm
        | VariableObject rdfVariable -> VariablePoint rdfVariable
    member this.asINode =
        match this with
        | IriObject iri -> iri.asINode
        | BlankObject blankReference -> blankReference.asINode
        | LiteralObject rdfLiteral -> rdfLiteral.asINode
        | TripleTermObject tripleTerm -> tripleTerm.asINode
        | VariableObject rdfVariable -> rdfVariable.asINode
    member this.asPatternItem(patternBuilder: TriplePatternBuilder) : PatternItem =
        match this with
        | VariableObject rdfVariable -> patternBuilder |> rdfVariable.asPatternItem
        | _ -> patternBuilder.PatternItemFactory.CreateNodeMatchPattern(this.asINode)
    member this.maybeCurie =
        match this with
        | IriObject iri -> iri.maybeCurie
        | BlankObject blankReference -> Some blankReference.curie
        | LiteralObject rdfLiteral -> rdfLiteral.maybeCurie
        | TripleTermObject tripleTerm -> Some tripleTerm.curiesAndOrLexicalForms
        | VariableObject rdfVariable -> None
and [<CustomEquality; CustomComparison>] RdfLiteral =
    | PlainLiteral of PlainLiteral
    | DatatypedLiteral of DatatypedLiteral

    member this.lexicalForm =
        match this with
        | PlainLiteral plainLiteral -> plainLiteral.lexicalForm
        | DatatypedLiteral datatypedLiteral -> datatypedLiteral.lexicalForm

    member this.asLiteralNode =
        match this with
        | PlainLiteral plainLiteral -> plainLiteral.asLiteralNode
        | DatatypedLiteral datatypedLiteral -> datatypedLiteral.asLiteralNode
    member this.asINode: INode = this.asLiteralNode
    member this.maybeCurie =
        match this with
        | PlainLiteral plainLiteral -> None
        | DatatypedLiteral datatypedLiteral -> datatypedLiteral.curie
    static member fromLiteralNode(literalNode: LiteralNode) =
        match literalNode.Value, literalNode.DataType, literalNode.Language.ToLowerInvariant() with
        | lexicalForm, null, lang when not (String.IsNullOrWhiteSpace lang) -> NLanguageTag.LanguageTag.Parse lang |> RdfLiteral.languageTagged lexicalForm
        | lexicalForm, datatypeUri, lang when not (isNull datatypeUri) && String.IsNullOrWhiteSpace lang ->
            {
                lexicalForm = lexicalForm
                datatypeIri = Iri.fromString datatypeUri.OriginalString |> IRIREF
            }
            |> DatatypedLiteral
        | lexicalForm, _, _ -> RdfLiteral.simple lexicalForm
    static member fromILiteralNode(iliteralNode: ILiteralNode) =
        iliteralNode :?> LiteralNode |> RdfLiteral.fromLiteralNode


    static member simple(lexicalForm: string) =
        SimpleString lexicalForm |> PlainLiteral
    static member datatyped (lexicalForm: string) (datatypeIri: RdfIri) =
        {
            lexicalForm = lexicalForm
            datatypeIri = datatypeIri
        }
        |> DatatypedLiteral
    static member languageTagged (lexicalForm: string) (languageTag: NLanguageTag.LanguageTag) =
        {
            lexicalForm = lexicalForm
            languageTag = languageTag
        }
        |> LanguageString
        |> PlainLiteral
    static member language (lexicalForm: string) (language: Language) =
        {
            lexicalForm = lexicalForm
            languageTag = new NLanguageTag.LanguageTag(language)
        }
        |> LanguageString
        |> PlainLiteral
    static member en(lexicalForm: string) =
        RdfLiteral.language lexicalForm Language.EN
    static member US(lexicalForm: string) =
        new NLanguageTag.LanguageTag(Language.EN, Region.US)
        |> RdfLiteral.languageTagged lexicalForm

        
    static member inline autotyped<'ValueType>(value: 'ValueType) =

        let datatypedLiteral =
            let invariantString =
                if box value = null then
                    String.Empty
                else
                    Convert.ToString(value, CultureInfo.InvariantCulture)

            match box value with
            | :? Boolean as value -> {
                lexicalForm = (if value then "true" else "false")
                datatypeIri = PrefixId.xsd.prefixedName "boolean" |> PrefixedIri
              }
            | :? (Byte array) as value -> {
                lexicalForm = Convert.ToBase64String(value)
                datatypeIri = PrefixId.xsd.prefixedName "base64Binary" |> PrefixedIri
              }
            | :? Byte as value -> {
                lexicalForm = invariantString
                datatypeIri = PrefixId.xsd.prefixedName "unsignedByte" |> PrefixedIri
              }
            | :? DateOnly as value -> {
                lexicalForm = value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
                datatypeIri = PrefixId.xsd.prefixedName "date" |> PrefixedIri
              }
            | :? DateTime as value -> {
                lexicalForm = value.ToString("o", CultureInfo.InvariantCulture)
                datatypeIri = PrefixId.xsd.prefixedName "dateTime" |> PrefixedIri
              }
            | :? DateTimeOffset as value -> {
                lexicalForm = value.ToString("o", CultureInfo.InvariantCulture)
                datatypeIri = PrefixId.xsd.prefixedName "dateTimeStamp" |> PrefixedIri
              }
            | :? Decimal as value -> {
                lexicalForm = invariantString
                datatypeIri = PrefixId.xsd.prefixedName "decimal" |> PrefixedIri
              }
            | :? Double as value -> {
                lexicalForm = value.ToString("R", CultureInfo.InvariantCulture)
                datatypeIri = PrefixId.xsd.prefixedName "double" |> PrefixedIri
              }
            | :? Int16 as value -> {
                lexicalForm = invariantString
                datatypeIri = PrefixId.xsd.prefixedName "short" |> PrefixedIri
              }
            | :? Int32 as value -> {
                lexicalForm = invariantString
                datatypeIri = PrefixId.xsd.prefixedName "int" |> PrefixedIri
              }
            | :? Int64 as value -> {
                lexicalForm = invariantString
                datatypeIri = PrefixId.xsd.prefixedName "long" |> PrefixedIri
              }
            | :? SByte as value -> {
                lexicalForm = invariantString
                datatypeIri = PrefixId.xsd.prefixedName "byte" |> PrefixedIri
              }
            | :? Single as value -> {
                lexicalForm = value.ToString("R", CultureInfo.InvariantCulture)
                datatypeIri = PrefixId.xsd.prefixedName "float" |> PrefixedIri
              }
            | :? TimeOnly as value -> {
                lexicalForm = value.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)
                datatypeIri = PrefixId.xsd.prefixedName "time" |> PrefixedIri
              }
            | :? TimeSpan as value -> {
                lexicalForm = Xml.XmlConvert.ToString(value)
                datatypeIri = PrefixId.xsd.prefixedName "duration" |> PrefixedIri
              }
            | :? UInt16 as value -> {
                lexicalForm = invariantString
                datatypeIri = PrefixId.xsd.prefixedName "unsignedShort" |> PrefixedIri
              }
            | :? UInt32 as value -> {
                lexicalForm = invariantString
                datatypeIri = PrefixId.xsd.prefixedName "unsignedInt" |> PrefixedIri
              }
            | :? UInt64 as value -> {
                lexicalForm = invariantString
                datatypeIri = PrefixId.xsd.prefixedName "unsignedLong" |> PrefixedIri
              }
            | :? Uri as value -> {
                lexicalForm = value.OriginalString
                datatypeIri = PrefixId.xsd.prefixedName "anyURI" |> PrefixedIri
              }
            | :? DomUrl as value -> {
                lexicalForm = value.ToString()
                datatypeIri = PrefixId.xsd.prefixedName "anyURI" |> PrefixedIri
              }
            | :? Iri as value -> {
                lexicalForm = value.ToString()
                datatypeIri = PrefixId.xsd.prefixedName "anyURI" |> PrefixedIri
              }
            | :? XmlQualifiedName as value -> {
                lexicalForm = value.ToString()
                datatypeIri = PrefixId.xsd.prefixedName "QName" |> PrefixedIri
              }
            | :? Guid as value -> {
                lexicalForm = value.ToString()
                datatypeIri = PrefixId.xsd.prefixedName "ID" |> PrefixedIri
              }
            | :? String as value -> {
                lexicalForm = value
                datatypeIri = PrefixId.xsd.prefixedName "string" |> PrefixedIri
              }
            | null -> {
                lexicalForm = "true"
                datatypeIri = PrefixId.xsi.prefixedName "nil" |> PrefixedIri
              }
            | value -> {
                lexicalForm = invariantString
                datatypeIri = PrefixId.xdt.prefixedName "anyAtomicType" |> PrefixedIri
              }

        datatypedLiteral |> DatatypedLiteral
static member inline autotyped<'ValueType>(value: 'ValueType) =

        let datatypedLiteral =
            let invariantString =
                if box value = null then
                    String.Empty
                else
                    Convert.ToString(value, CultureInfo.InvariantCulture)

            match box value with
            | :? Boolean as value -> {
                lexicalForm = (if value then "true" else "false")
                datatypeIri = PrefixId.xsd.prefixedName "boolean" |> PrefixedIri
              }
            | :? (Byte array) as value -> {
                lexicalForm = Convert.ToBase64String(value)
                datatypeIri = PrefixId.xsd.prefixedName "base64Binary" |> PrefixedIri
              }
            | :? Byte as value -> {
                lexicalForm = invariantString
                datatypeIri = PrefixId.xsd.prefixedName "unsignedByte" |> PrefixedIri
              }
            | :? DateOnly as value -> {
                lexicalForm = value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
                datatypeIri = PrefixId.xsd.prefixedName "date" |> PrefixedIri
              }
            | :? DateTime as value -> {
                lexicalForm = value.ToString("o", CultureInfo.InvariantCulture)
                datatypeIri = PrefixId.xsd.prefixedName "dateTime" |> PrefixedIri
              }
            | :? DateTimeOffset as value -> {
                lexicalForm = value.ToString("o", CultureInfo.InvariantCulture)
                datatypeIri = PrefixId.xsd.prefixedName "dateTimeStamp" |> PrefixedIri
              }
            | :? Decimal as value -> {
                lexicalForm = invariantString
                datatypeIri = PrefixId.xsd.prefixedName "decimal" |> PrefixedIri
              }
            | :? Double as value -> {
                lexicalForm = value.ToString("R", CultureInfo.InvariantCulture)
                datatypeIri = PrefixId.xsd.prefixedName "double" |> PrefixedIri
              }
            | :? Int16 as value -> {
                lexicalForm = invariantString
                datatypeIri = PrefixId.xsd.prefixedName "short" |> PrefixedIri
              }
            | :? Int32 as value -> {
                lexicalForm = invariantString
                datatypeIri = PrefixId.xsd.prefixedName "int" |> PrefixedIri
              }
            | :? Int64 as value -> {
                lexicalForm = invariantString
                datatypeIri = PrefixId.xsd.prefixedName "long" |> PrefixedIri
              }
            | :? SByte as value -> {
                lexicalForm = invariantString
                datatypeIri = PrefixId.xsd.prefixedName "byte" |> PrefixedIri
              }
            | :? Single as value -> {
                lexicalForm = value.ToString("R", CultureInfo.InvariantCulture)
                datatypeIri = PrefixId.xsd.prefixedName "float" |> PrefixedIri
              }
            | :? TimeOnly as value -> {
                lexicalForm = value.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)
                datatypeIri = PrefixId.xsd.prefixedName "time" |> PrefixedIri
              }
            | :? TimeSpan as value -> {
                lexicalForm = Xml.XmlConvert.ToString(value)
                datatypeIri = PrefixId.xsd.prefixedName "duration" |> PrefixedIri
              }
            | :? UInt16 as value -> {
                lexicalForm = invariantString
                datatypeIri = PrefixId.xsd.prefixedName "unsignedShort" |> PrefixedIri
              }
            | :? UInt32 as value -> {
                lexicalForm = invariantString
                datatypeIri = PrefixId.xsd.prefixedName "unsignedInt" |> PrefixedIri
              }
            | :? UInt64 as value -> {
                lexicalForm = invariantString
                datatypeIri = PrefixId.xsd.prefixedName "unsignedLong" |> PrefixedIri
              }
            | :? Uri as value -> {
                lexicalForm = value.OriginalString
                datatypeIri = PrefixId.xsd.prefixedName "anyURI" |> PrefixedIri
              }
            | :? DomUrl as value -> {
                lexicalForm = value.ToString()
                datatypeIri = PrefixId.xsd.prefixedName "anyURI" |> PrefixedIri
              }
            | :? Iri as value -> {
                lexicalForm = value.ToString()
                datatypeIri = PrefixId.xsd.prefixedName "anyURI" |> PrefixedIri
              }
            | :? XmlQualifiedName as value -> {
                lexicalForm = value.ToString()
                datatypeIri = PrefixId.xsd.prefixedName "QName" |> PrefixedIri
              }
            | :? Guid as value -> {
                lexicalForm = value.ToString()
                datatypeIri = PrefixId.xsd.prefixedName "ID" |> PrefixedIri
              }
            | :? String as value -> {
                lexicalForm = value
                datatypeIri = PrefixId.xsd.prefixedName "string" |> PrefixedIri
              }
            | null -> {
                lexicalForm = "true"
                datatypeIri = PrefixId.xsi.prefixedName "nil" |> PrefixedIri
              }
            | value -> {
                lexicalForm = invariantString
                datatypeIri = PrefixId.xdt.prefixedName "anyAtomicType" |> PrefixedIri
              }

        datatypedLiteral |> DatatypedLiteral

    member this.identity =
        match this with
        | PlainLiteral plainLiteral -> plainLiteral.identity
        | DatatypedLiteral datatypedLiteral -> datatypedLiteral.identity

    override this.Equals(other: obj) =
        match other with
        | :? RdfLiteral as other -> this.identity = other.identity
        | :? PlainLiteral as other -> this.identity = other.identity
        | :? DatatypedLiteral as other -> this.identity = other.identity
        | :? LanguageString as other -> this.identity = other.identity
        | :? DirectedLanguageString as other -> this.identity = other.identity
        | _ -> false
    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? RdfLiteral as other -> compare this.identity other.identity
            | :? PlainLiteral as other -> compare this.identity other.identity
            | :? DatatypedLiteral as other -> compare this.identity other.identity
            | :? LanguageString as other -> compare this.identity other.identity
            | :? DirectedLanguageString as other -> compare this.identity other.identity
            | _ -> compare this.identity (RdfLiteral.autotyped other).identity
and [<CustomEquality; CustomComparison>] PlainLiteral =
    | SimpleString of string
    | LanguageString of LanguageString
    | DirectedLanguageString of DirectedLanguageString


    member this.lexicalForm =
        match this with
        | SimpleString rdfString -> rdfString
        | LanguageString languageString -> languageString.lexicalForm
        | DirectedLanguageString directedLanguageString -> directedLanguageString.lexicalForm
    member this.asLiteralNode =
        match this with
        | SimpleString rdfString -> new LiteralNode(rdfString)
        | LanguageString languageString -> new LiteralNode(languageString.lexicalForm, languageString.languageTag.asString)
        | DirectedLanguageString directedLanguageString -> new LiteralNode(directedLanguageString.lexicalForm, directedLanguageString.i18nIri.asUri)
    member this.asINode: INode = this.asLiteralNode
    member this.identity =
        match this with
        | SimpleString rdfString -> (rdfString, (PrefixId.xsd.prefixedName "string").identity, None, None)
        | LanguageString languageString -> languageString.identity
        | DirectedLanguageString directedLanguageString -> directedLanguageString.identity

    override this.Equals(other: obj) =
        match other with
        | :? RdfLiteral as other -> this.identity = other.identity
        | :? PlainLiteral as other -> this.identity = other.identity
        | :? DatatypedLiteral as other -> this.identity = other.identity
        | :? LanguageString as other -> this.identity = other.identity
        | :? DirectedLanguageString as other -> this.identity = other.identity
        | _ -> false
    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? RdfLiteral as other -> compare this.identity other.identity
            | :? PlainLiteral as other -> compare this.identity other.identity
            | :? DatatypedLiteral as other -> compare this.identity other.identity
            | :? LanguageString as other -> compare this.identity other.identity
            | :? DirectedLanguageString as other -> compare this.identity other.identity
            | _ -> compare this.identity (RdfLiteral.autotyped other).identity

and [<CustomEquality; CustomComparison>] DatatypedLiteral = {
    lexicalForm: string
    datatypeIri: RdfIri
} with

    member this.curie =
        match this.datatypeIri.maybeCurie with
        | Some curie -> Some(sprintf "%s^^%s" this.lexicalForm curie)
        | None -> None
    member this.asLiteralNode = new LiteralNode(this.lexicalForm, this.datatypeIri.asUri)
    member this.asINode: INode = this.asLiteralNode
    member this.identity = (this.lexicalForm, this.datatypeIri.identity, None, None)

    override this.Equals(other: obj) =
        match other with
        | :? RdfLiteral as other -> this.identity = other.identity
        | :? PlainLiteral as other -> this.identity = other.identity
        | :? DatatypedLiteral as other -> this.identity = other.identity
        | :? LanguageString as other -> this.identity = other.identity
        | :? DirectedLanguageString as other -> this.identity = other.identity
        | _ -> false
    override this.GetHashCode() = this.identity.GetHashCode()
    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? RdfLiteral as other -> compare this.identity other.identity
            | :? PlainLiteral as other -> compare this.identity other.identity
            | :? DatatypedLiteral as other -> compare this.identity other.identity
            | :? LanguageString as other -> compare this.identity other.identity
            | :? DirectedLanguageString as other -> compare this.identity other.identity
            | _ -> compare this.identity (RdfLiteral.autotyped other).identity
and [<CustomEquality; CustomComparison>] LanguageString = {
    lexicalForm: string
    languageTag: NLanguageTag.LanguageTag
} with


    member this.identity = (this.lexicalForm, (PrefixId.rdf.prefixedName "langString").identity, Some(this.languageTag.asString), None)

    override this.Equals(other: obj) =
        match other with
        | :? RdfLiteral as other -> this.identity = other.identity
        | :? PlainLiteral as other -> this.identity = other.identity
        | :? DatatypedLiteral as other -> this.identity = other.identity
        | :? LanguageString as other -> this.identity = other.identity
        | :? DirectedLanguageString as other -> this.identity = other.identity
        | _ -> false
    override this.GetHashCode() = this.identity.GetHashCode()
    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? RdfLiteral as other -> compare this.identity other.identity
            | :? PlainLiteral as other -> compare this.identity other.identity
            | :? DatatypedLiteral as other -> compare this.identity other.identity
            | :? LanguageString as other -> compare this.identity other.identity
            | :? DirectedLanguageString as other -> compare this.identity other.identity
            | _ -> compare this.identity (RdfLiteral.autotyped other).identity
and [<CustomEquality; CustomComparison>] DirectedLanguageString = {
    lexicalForm: string
    languageTag: NLanguageTag.LanguageTag
    baseDirection: InitialTextDirection
} with

    member this.i18nIri: Iri =
        PrefixId.i18n.namespaceName.iriSpace.pathTemplate
            .AddParameters(
                {|
                    languageTag = this.languageTag.asString
                    baseDirection = this.baseDirection.asString
                |}
            )
            .Resolve()
        |> HttpUtility.UrlDecode
        |> Iri.fromString
    // TODO from i18nIri

    member this.identity = (this.lexicalForm, (PrefixId.rdf.prefixedName "dirLangString").identity, Some(this.languageTag.asString), Some(this.baseDirection.asString))

    override this.Equals(other: obj) =
        match other with
        | :? RdfLiteral as other -> this.identity = other.identity
        | :? PlainLiteral as other -> this.identity = other.identity
        | :? DatatypedLiteral as other -> this.identity = other.identity
        | :? LanguageString as other -> this.identity = other.identity
        | :? DirectedLanguageString as other -> this.identity = other.identity
        | _ -> false
    override this.GetHashCode() = this.identity.GetHashCode()
    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? RdfLiteral as other -> compare this.identity other.identity
            | :? PlainLiteral as other -> compare this.identity other.identity
            | :? DatatypedLiteral as other -> compare this.identity other.identity
            | :? LanguageString as other -> compare this.identity other.identity
            | :? DirectedLanguageString as other -> compare this.identity other.identity
            | _ -> compare this.identity (RdfLiteral.autotyped other).identity

and RdfTriple = {
    curSubject: RdfSubject
    curPredicate: RdfPredicate
    curObject: RdfObject
} with

    static member fromVDSTriple(vdsTriple: VDS.RDF.Triple) =

        {
            curSubject = RdfSubject.fromINode vdsTriple.Subject
            curPredicate = RdfPredicate.fromINode vdsTriple.Predicate
            curObject = RdfObject.fromINode vdsTriple.Object
        }

    member this.points = [|
        this.curSubject.asRdfTerm
        this.curPredicate.asRdfTerm
        this.curObject.asRdfTerm
    |]
    member this.curiesAndOrLexicalForms =
        this.points
        |> Array.map (fun point -> defaultArg point.maybeCurie point.lexicalForm)
        |> String.concat " "
    member this.lexicalForms = [|
        this.curSubject.lexicalForm
        this.curPredicate.lexicalForm
        this.curObject.lexicalForm
    |]
    member this.lexicalForm = this.lexicalForms |> String.concat " "
    member this.asVDSTriple = new Triple(this.curSubject.asINode, this.curPredicate.asINode, this.curObject.asINode)
    member this.asITriplePattern(patternBuilder: TriplePatternBuilder) =
        TriplePattern(this.curSubject.asPatternItem patternBuilder, this.curPredicate.asPatternItem patternBuilder, this.curObject.asPatternItem patternBuilder)
        :> ITriplePattern
and RdfTripleTerm = {
    ttTriple: RdfTriple
} with

    member this.lexicalForm = this.ttTriple.lexicalForm
    member this.curiesAndOrLexicalForms = this.ttTriple.curiesAndOrLexicalForms
    static member fromVDSTriple(vdsTriple: VDS.RDF.Triple) = {
        ttTriple = RdfTriple.fromVDSTriple vdsTriple
    }
    static member fromTripleNode(tripleNode: TripleNode) =
        RdfTripleTerm.fromVDSTriple tripleNode.Triple
    member this.asTripleNode = new TripleNode(this.ttTriple.asVDSTriple)
    member this.asINode: INode = this.asTripleNode
and [<CustomEquality; CustomComparison>] RdfVariable = {
    uuid: Guid
    identifier: string
    mutable bindingCell: FSharp.Data.Adaptive.cval<DataPoint option>
} with


    static member fromVariableNode(variableNode: VariableNode) = {
        uuid = Guid.NewGuid()
        identifier = variableNode.VariableName
        bindingCell = FSharp.Data.Adaptive.cval (None: DataPoint option)
    }
    static member fromIdentifier(identifier: string) = {
        uuid = Guid.NewGuid()
        identifier = identifier
        bindingCell = FSharp.Data.Adaptive.cval (None: DataPoint option)
    }
    member this.lexicalForm = this.identifier

    member this.asPatternItem(patternBuilder: TriplePatternBuilder) =
        patternBuilder.PatternItemFactory.CreateVariablePattern(this.identifier)
    member this.asVariableNode = new VariableNode(this.identifier)
    member this.asINode: INode = this.asVariableNode
    member this.identity = this.uuid

    override this.Equals(other: obj) =
        match other with
        | :? RdfVariable as otherVariable -> this.identity = otherVariable.identity
        | _ -> false

    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? RdfVariable as otherVariable -> compare this.identity otherVariable.identity
            | _ -> invalidArg (nameof other) "An RdfVariable can only be compared with another RdfVariable."
and Formula = {

    subjects: RdfSubject array
    predicates: RdfPredicate array
    objects: RdfObject array
    predicateObjectLists: PredicateObjectList array
    triples: HashSet<RdfTriple>

} with


    static member Empty =

        {
            subjects = [||]
            predicates = [||]
            objects = [||]
            predicateObjectLists = [||]
            triples = HashSet.empty

        }
    static member fromIGraph(igraph: IGraph) = {
        Formula.Empty with
            triples =
                igraph.Triples
                |> PSeq.map (fun vdsTriple ->

                    RdfTriple.fromVDSTriple vdsTriple

                )
                |> HashSet.ofSeq

    }
    static member fromGraphLiteralNode(graphLiteralNode: GraphLiteralNode) =
        Formula.fromIGraph graphLiteralNode.SubGraph
    member this.lexicalForm =
        this.triples
        |> Seq.toArray
        |> Array.map (fun triple -> triple.lexicalForm)
        |> String.concat "\n"

    member this.curiesAndOrLexicalForms =
        this.triples
        |> Seq.toArray
        |> Array.map (fun triple -> triple.curiesAndOrLexicalForms)
        |> String.concat "\n"
and PredicateObjectList = {

    verb: RdfPredicate
    objectLists: ObjectList array

}
and ObjectList = {
    rdfObject: RdfObject
    annotations: Annotation array
}
and Annotation =
    | AnnotationReifier of RdfSubject
    | AnnotationBlock of PredicateObjectList



and RdfTripleSet = { triples: HashSet<RdfTriple> }



and RdfName =
    | IriName of RdfIri
    | LiteralName of RdfLiteral

and RdfReference =
    | NamedReference of RdfIri
    | AnonymousReference of BlankReference
















































type PrefixedName with
    (*
    static member fromQname(qname: string) = {
        prefixId = PrefixId.fromPrefix qname[.. qname.IndexOf ":" - 1]
        localName = qname[qname.IndexOf ":" + 1 ..]
    }
*)
    member this.asIri = this.prefixId.prefixedName this.localName |> PrefixedIri
    member this.asSubject = this.asIri |> IriSubject
    member this.asPredicate = this.asIri |> IriPredicate
    member this.asObject = this.asIri |> IriObject
    member this.asRdfName = this.asIri |> IriName
    member this.asRdfReference = NamedReference this.asIri
    member this.asXName = XName.op_Implicit (this.lexicalForm)
    member this.asXmlQualifiedName = new XmlQualifiedName(this.localName, this.prefixId.namespaceName.namespaceIri.lexicalForm)


    member this.curieDelimited infixDelimiter =
        this.prefixId.namespacePrefix + infixDelimiter + this.localName
    member this.curie = this.curieDelimited ":"
    member this.asUrl = DomUrl this.lexicalForm
    member this.asUri = Uri this.lexicalForm
    member this.asUriNode = new UriNode(this.asUri)
    member this.asINode: INode = this.asUriNode
    member this.asRDFResource = new RDFResource(this.lexicalForm)

type LanguageString with

    member this.asObject = LanguageString this |> PlainLiteral |> LiteralObject
    member this.asRdfName = LanguageString this |> PlainLiteral |> LiteralName
    member this.curie = sprintf "%s@%s" this.lexicalForm this.languageTag.asString
type DirectedLanguageString with

    member this.asObject = DirectedLanguageString this |> PlainLiteral |> LiteralObject
    member this.asRdfName = DirectedLanguageString this |> PlainLiteral |> LiteralName
    member this.curie = sprintf "%s@%s--%s" this.lexicalForm this.languageTag.asString this.baseDirection.asString
type PlainLiteral with

    member this.asObject = PlainLiteral this |> LiteralObject
    member this.asRdfName = PlainLiteral this |> LiteralName
    member this.curie =
        match this with
        | SimpleString rdfString -> rdfString
        | LanguageString languageString -> languageString.curie
        | DirectedLanguageString directedLanguageString -> directedLanguageString.curie
    member this.maybeLanguageTag =
        match this with
        | SimpleString rdfString -> None
        | LanguageString languageString -> Some languageString.languageTag
        | DirectedLanguageString directedLanguageString -> Some directedLanguageString.languageTag
    member this.maybeBaseDirection =
        match this with
        | SimpleString rdfString -> None
        | LanguageString languageString -> None
        | DirectedLanguageString directedLanguageString -> Some directedLanguageString.baseDirection


type RdfIri with

    member this.asRDFResource = new RDFResource(this.lexicalForm)
    member this.iriref = $"<{this.lexicalForm}>"

    member this.asSubject = IriSubject this
    member this.asPredicate = IriPredicate this
    member this.asObject = IriObject this
    member this.asRdfName = IriName this
    member this.asRdfReference = NamedReference this
type DatatypedLiteral with

    member this.asObject = DatatypedLiteral this |> LiteralObject
    member this.asRdfName = DatatypedLiteral this |> LiteralName
type RdfLiteral with



    static member True = RdfLiteral.autotyped true
    static member False = RdfLiteral.autotyped false
    member this.asObject = LiteralObject this
    member this.asRdfName = LiteralName this

    member this.datatypeIri =
        match this with
        | PlainLiteral plainLiteral -> PrefixId.xsd.prefixedName "string" |> PrefixedIri
        | DatatypedLiteral datatypedLiteral -> datatypedLiteral.datatypeIri

    member this.maybeLanguageTag =
        match this with
        | PlainLiteral plainLiteral -> plainLiteral.maybeLanguageTag
        | DatatypedLiteral datatypedLiteral -> None
    member this.maybeBaseDirection =
        match this with
        | PlainLiteral plainLiteral -> plainLiteral.maybeBaseDirection
        | DatatypedLiteral datatypedLiteral -> None








type BlankReference with

    member this.mintSkolemIri() =
        Iri.fromString $"{wellKnownGenid}/{Guid.NewGuid()}" |> IRIREF
    member this.asSubject = BlankSubject this
    member this.asObject = BlankObject this
    member this.asRdfReference = AnonymousReference this
    member this.asRDFResource = new RDFResource(this.curie)












type PrefixId with
    member this.asIri = this.prefixedName String.Empty |> PrefixedIri

    member this.asPrefixedName = {
        prefixId = this
        localName = String.Empty
    }



    member this.prefix(localName: string) = {
        prefixId = this
        localName = localName
    }
    // member this.prefix (localName:string) = { prefixId = this ; localName = localName} |> PrefixedIri
    member this.asSubject = this.asIri |> IriSubject
    member this.asPredicate = this.asIri |> IriPredicate
    member this.asObject = this.asIri |> IriObject
    member this.asRdfName = this.asIri |> IriName
    member this.asRdfReference = NamedReference this.asIri

    static member fromPrefix(namespacePrefix: string) = {
        namespacePrefix = namespacePrefix
        namespaceName =
            (namespaceMapper.GetNamespaceUri namespacePrefix).OriginalString
            |> NamespaceName.fromString
    }



type RdfVariable with
    member this.asSubject = VariableSubject this
    member this.asPredicate = VariablePredicate this
    member this.asObject = VariableObject this

    member this.questionForm = "?" + this.lexicalForm
    member this.dollarForm = "$" + this.lexicalForm
    member this.asSparqlVariable = new SparqlVariable(this.identifier)
    member this.asBlankReference = {
        blankNodeIdentifier = this.identifier
    }
    member this.mintSkolemIri() =
        Iri.fromString $"{wellKnownGenid}/{this.uuid}"
    member this.binding: FSharp.Data.Adaptive.aval<DataPoint option> = this.bindingCell :> FSharp.Data.Adaptive.aval<DataPoint option>
    member this.bind(point: DataPoint) =
        transact (fun () -> this.bindingCell.Value <- Some point)
    member this.unbind() =
        transact (fun () -> this.bindingCell.Value <- None)
    member this.maybeTerm = this.binding |> FSharp.Data.Adaptive.AVal.force






type RdfSubject with


    member this.maybePredicate =
        match this with
        | IriSubject iri -> Some iri.asPredicate
        | BlankSubject blankReference -> None
        | VariableSubject rdfVariable -> Some rdfVariable.asPredicate
    member this.asObject =
        match this with
        | IriSubject iri -> iri.asObject
        | BlankSubject blankReference -> blankReference.asObject
        | VariableSubject rdfVariable -> rdfVariable.asObject
    member this.maybeRdfName =
        match this with
        | IriSubject iri -> Some iri.asRdfName
        | BlankSubject blankReference -> None
        | VariableSubject rdfVariable -> None
    member this.maybeRdfReference =
        match this with
        | IriSubject iri -> Some iri.asRdfReference
        | BlankSubject blankReference -> Some blankReference.asRdfReference
        | VariableSubject rdfVariable -> None
    member this.asVertex = SubjectVertex this
    member this.maybeCurie =
        match this with
        | IriSubject iri -> iri.maybeCurie
        | BlankSubject blankReference -> Some blankReference.curie
        | VariableSubject rdfVariable -> None


type RdfPredicate with

    member this.asSubject =
        match this with
        | IriPredicate iri -> iri.asSubject
        | VariablePredicate rdfVariable -> rdfVariable.asSubject
    member this.asObject =
        match this with
        | IriPredicate iri -> iri.asObject
        | VariablePredicate rdfVariable -> rdfVariable.asObject
    member this.maybeRdfName =
        match this with
        | IriPredicate iri -> Some iri.asRdfName
        | VariablePredicate rdfVariable -> None
    member this.maybeRdfReference =
        match this with
        | IriPredicate iri -> Some(NamedReference iri)
        | VariablePredicate rdfVariable -> None
    member this.asEdge = PredicateEdge this
    member this.maybeCurie =
        match this with
        | IriPredicate iri -> iri.maybeCurie
        | VariablePredicate rdfVariable -> None


type PredicateObjectList with

    static member inline fromTerms (predicate: RdfPredicate) (objects: RdfObject array) = {

        verb = predicate
        objectLists =
            objects
            |> Array.map (fun rdfObject -> {
                rdfObject = rdfObject
                annotations = [||]

            })

    }

type RdfTriple with



    static member inline fromTerms
        (rdfSubject: ^SubjectType when ^SubjectType: (member asSubject: RdfSubject))
        (rdfPredicate: ^PredicateType when ^PredicateType: (member asPredicate: RdfPredicate))
        (rdfObject: ^ObjectType when ^ObjectType: (member asObject: RdfObject))
        =
        {
            curSubject = rdfSubject.asSubject
            curPredicate = rdfPredicate.asPredicate
            curObject = rdfObject.asObject
        }
    static member setFromTerms (rdfSubjects: RdfSubject array) (rdfPredicates: RdfPredicate array) (rdfObjects: RdfObject array) =
        rdfObjects
        |> Array.Parallel.collect (fun rdfObject ->

            rdfPredicates
            |> Array.Parallel.collect (fun rdfPredicate ->

                rdfSubjects
                |> Array.Parallel.map (fun rdfSubject ->

                    {

                        curSubject = rdfSubject
                        curPredicate = rdfPredicate
                        curObject = rdfObject

                    }

                )))
        |> HashSet.ofSeq
    static member setFromSubjectsPredicateObjectLists (rdfSubjects: RdfSubject array) (predicateObjectLists: PredicateObjectList array) =
        rdfSubjects
        |> Array.Parallel.collect (fun rdfSubject ->
            predicateObjectLists
            |> Array.Parallel.collect (fun predicateObjectList ->
                predicateObjectList.objectLists
                |> Array.Parallel.map (fun objectList ->
                    // TODO deal with annotations


                    {
                        curSubject = rdfSubject
                        curPredicate = predicateObjectList.verb
                        curObject = objectList.rdfObject
                    }

                )

            )

        )
        |> HashSet.ofSeq
    member this.lexicalTriple = this.curSubject.lexicalForm, this.curPredicate.lexicalForm, this.curObject.lexicalForm

    member this.verticies = [| SubjectVertex this.curSubject; ObjectVertex this.curObject |]



type RdfTripleTerm with

    member this.ttSubject = this.ttTriple.curSubject
    member this.ttPredicate = this.ttTriple.curPredicate
    member this.ttObject = this.ttTriple.curObject



type Formula with




    member this.ITriplePatterns(patternBuilder: TriplePatternBuilder) : ITriplePattern array =
        this.triples
        |> Seq.toArray
        |> Array.map (fun rdfTriple -> patternBuilder |> rdfTriple.asITriplePattern)

    member this.asRdfTripleSet: RdfTripleSet = { triples = this.triples }

    static member fromRdfSubject rdfSubject =

        {
            subjects = [| rdfSubject |]
            predicates = [||]
            objects = [||]
            predicateObjectLists = [||]
            triples = HashSet.empty

        }

    static member fromRdfSubjects rdfSubjects =

        {
            subjects = rdfSubjects |> List.toArray
            predicates = [||]
            objects = [||]
            predicateObjectLists = [||]
            triples = HashSet.empty

        }

    static member fromRdfPredicate rdfPredicate =

        {
            subjects = [||]
            predicates = [| rdfPredicate |]
            objects = [||]
            predicateObjectLists = [||]
            triples = HashSet.empty

        }

    static member fromRdfPredicates rdfPredicates =

        {
            subjects = [||]
            predicates = rdfPredicates
            objects = [||]
            predicateObjectLists = [||]
            triples = HashSet.empty

        }

    static member fromRdfObject rdfObject =

        {
            subjects = [||]
            predicates = [||]
            objects = [| rdfObject |]
            predicateObjectLists = [||]
            triples = HashSet.empty

        }

    static member fromRdfObjects rdfObjects =

        {
            subjects = [||]
            predicates = [||]
            objects = rdfObjects
            predicateObjectLists = [||]
            triples = HashSet.empty

        }


    member this.materializeTriples = {
        subjects = [||]
        predicates = [||]
        objects = [||]
        predicateObjectLists = [||]
        triples =
            Seq.concat [
                this.triples
                RdfTriple.setFromTerms this.subjects this.predicates this.objects
                RdfTriple.setFromSubjectsPredicateObjectLists this.subjects this.predicateObjectLists
            ]
            |> HashSet.ofSeq


    }

    static member materializeFormula(formula: Formula) = formula.materializeTriples

    member this.addFormulas(formulas: Formula list) = {
        this with
            triples =
                Seq.concat [
                    this.triples
                    formulas |> Seq.collect (fun formula -> formula.triples) |> HashSet.ofSeq
                ]
                |> HashSet.ofSeq
    }



    member this.addRdfSubjects rdfSubjects = {
        this with
            subjects = this.subjects |> Array.append rdfSubjects
    }

    member this.addRdfSubject rdfSubject = this.addRdfSubjects [| rdfSubject |]


    member this.addRdfPredicates rdfPredicates =

        {
            this with
                predicates = this.predicates |> Array.append rdfPredicates
        }

    member this.addPredicateObjectLists predicateObjectLists =

        {
            this with
                predicateObjectLists = this.predicateObjectLists |> Array.append predicateObjectLists
        }

    member this.addRdfPredicate rdfPredicate =
        this.addRdfPredicates [| rdfPredicate |]

    member this.addRdfObjects rdfObjects = {
        this with
            objects = this.objects |> Array.append rdfObjects
    }

    member this.addRdfObject rdfObject = this.addRdfObjects [| rdfObject |]

    member this.addRdfLiteral rdfLiteral =
        RdfLiteral.autotyped rdfLiteral |> RdfObject.LiteralObject |> this.addRdfObject

    member this.addRdfLiterals rdfLiterals =
        rdfLiterals
        |> List.toArray
        |> Array.Parallel.map (fun literal -> literal |> RdfLiteral.autotyped |> RdfObject.LiteralObject)
        |> this.addRdfObjects





type Vertex with

    member this.asRenderedString(prefixDelimiter: string) =
        match this with
        | SubjectVertex rdfSubject ->
            defaultArg rdfSubject.maybeCurie rdfSubject.lexicalForm
            |> _.Replace(":", prefixDelimiter)
        | ObjectVertex rdfObject ->
            defaultArg rdfObject.maybeCurie rdfObject.lexicalForm
            |> _.Replace(":", prefixDelimiter)
type Edge with

    member this.asRenderedString(prefixDelimiter: string) =
        match this with
        | PredicateEdge rdfPredicate ->
            defaultArg rdfPredicate.maybeCurie rdfPredicate.lexicalForm
            |> _.Replace(":", prefixDelimiter)
        | TripleEdge rdfTriple ->
            defaultArg rdfTriple.curPredicate.maybeCurie rdfTriple.lexicalForm
            |> _.Replace(":", prefixDelimiter)




type RdfTripleSet with



    member this.verticies =
        this.triples
        |> Array.ofSeq
        |> Array.Parallel.collect (fun triple -> triple.verticies)
        |> Array.distinct

    member this.points =
        this.triples
        |> PSeq.collect (fun triple -> triple.points)
        |> PSeq.distinct
        |> Array.ofSeq
        |> Array.distinct

    member this.iris =
        this.points
        |> Array.Parallel.choose (fun point ->
            match point with
            | IriPoint iri -> Some iri
            | _ -> None)
        |> Array.distinct

    member this.prefixedNames =
        this.iris
        |> Array.Parallel.choose (fun iri ->
            match iri with
            | PrefixedIri prefixedName -> Some prefixedName
            | _ -> None)
        |> Array.distinct

    member this.prefixIds =
        this.prefixedNames
        |> Array.Parallel.map (fun prefixedName -> prefixedName.prefixId)
        |> Array.distinct


    static member fromIGraph(igraph: IGraph) = {
        triples =
            igraph.Triples
            |> PSeq.map (fun vdsTriple -> RdfTriple.fromVDSTriple vdsTriple)
            |> HashSet.ofSeq
    }
















type VDS.RDF.BlankNode with
    member this.asBlankReference = {
        blankNodeIdentifier = this.InternalID
    }
type VDS.RDF.LiteralNode with
    member this.asRDFLiteral =
        match this.DataType.OriginalString, this.Language with
        | "http://www.w3.org/2001/XMLSchema#string", _ -> SimpleString this.Value |> PlainLiteral
        | "http://www.w3.org/1999/02/22-rdf-syntax-ns#langString", languageTagString ->
            {
                lexicalForm = this.Value
                languageTag = LanguageTag.Parse languageTagString
            }
            |> LanguageString
            |> PlainLiteral
        | datatype, "" ->
            DatatypedLiteral {
                lexicalForm = this.Value
                datatypeIri = Iri.fromString this.DataType.OriginalString |> IRIREF
            }
        | _ -> failwithf "%O %s %s failed " this this.DataType.OriginalString this.Language

type IGraph with
    member this.RdfsEntailedGraph() =
        let rdfsEntailedGraph = new ThreadSafeGraph()
        rdfsEntailedGraph.Assert this.Triples |> ignore
        RdfsReasoner().Apply rdfsEntailedGraph
        rdfsEntailedGraph
    member this.mapPrefixes() =
        this.AllNodes
        |> Seq.iter (fun (inode) ->
            match DataPoint.fromINode inode with
            | IriPoint(PrefixedIri prefixedName) -> this.NamespaceMap.AddNamespace prefixedName.prefixId.asNamespaceMap
            | _ -> ())
    static member fromRdfTripleSet(rdfTripleSet: RdfTripleSet) =
        let graph = new ThreadSafeGraph()
        graph.Assert(rdfTripleSet.triples |> Seq.map (fun triple -> triple.asVDSTriple))
        |> ignore
        graph
type RDFGraph with
    member this.triples = this |> Seq.toArray
type RDFNamespace with
    member this.NamespaceName = this.NamespaceUri.OriginalString


type INode with
    member this.asRdfTerm =
        match this with
        | :? UriNode as uriNode -> RdfIri.fromUriNode uriNode |> IriPoint
        | :? BlankNode as blankNode -> BlankReference.fromBlankNode blankNode |> BlankPoint
        | :? LiteralNode as literalNode -> RdfLiteral.fromLiteralNode literalNode |> LiteralPoint
        | :? TripleNode as tripleNode -> RdfTripleTerm.fromTripleNode tripleNode |> TriplePoint
        | :? VariableNode as variableNode -> RdfVariable.fromVariableNode variableNode |> VariablePoint
        | :? GraphLiteralNode as graphLiteralNode -> Formula.fromGraphLiteralNode graphLiteralNode |> FormulaPoint




type OntologyClass with
    member this.asRdfTerm = this.Resource.asRdfTerm
type OntologyProperty with
    member this.asRdfTerm = this.Resource.asRdfTerm



type NamespaceMapper with
    member this.GetPrefixId(prefix: string) = {

        namespaceName = (this.GetNamespaceUri prefix).OriginalString |> NamespaceName.fromString
        namespacePrefix = prefix

    }
    member this.prefixIds =
        this.Prefixes
        |> Seq.map (fun prefix -> {
            namespaceName = (this.GetNamespaceUri prefix).OriginalString |> NamespaceName.fromString
            namespacePrefix = prefix

        })
        |> Seq.distinctBy (fun prefixId -> prefixId.namespaceName.namespaceIri.lexicalForm, prefixId.namespacePrefix)
        |> Seq.toArray


















type InMemoryDataset with
    member this.namespaceMap =
        let namespaceMapper = new NamespaceMapper()

        this.graphNames
        |> Array.iter (fun (graphName: IRefNode) -> namespaceMapper.Import this[graphName].NamespaceMap)

        namespaceMapper

    member this.graphNames =
        this.GraphNames
        |> Seq.filter (fun graphName -> not (isNull graphName))
        |> Seq.toArray

    static member fromTurtleDirectory(turtleDirectory: DirectoryInfo) =
        let dataset = new InMemoryDataset()
        turtleDirectory.GetFiles("*.ttl", SearchOption.AllDirectories)
        |> Array.iter (fun file ->
            let fileGraph = new ThreadSafeGraph()
            FileLoader.Load(fileGraph, file.FullName)
            dataset.AddGraph(fileGraph) |> ignore)
        dataset



type IGraph with
    member inline this.S<'Subject when 'Subject: (member asINode: INode)>(S: 'Subject) =
        this.GetTriplesWithSubject(S.asINode) |> Seq.toArray
    member inline this.SP<'Subject, 'Predicate when 'Subject: (member asINode: INode) and 'Predicate: (member asINode: INode)>(S: 'Subject, P: 'Predicate) =
        this.GetTriplesWithSubjectPredicate(S.asINode, P.asINode) |> Seq.toArray
    member this.BlankNodes =
        this.AllNodes
        |> Seq.toArray
        |> Array.filter (fun node -> node.NodeType = NodeType.Blank)
        |> Array.map (fun node -> node :?> BlankNode)
        |> Array.sortBy (fun node -> node.InternalID)
    member this.UriNodes =
        this.AllNodes
        |> Seq.toArray
        |> Array.filter (fun node -> node.NodeType = NodeType.Uri)
        |> Array.map (fun node -> node :?> UriNode)
        |> Array.sortBy (fun node -> node.Uri.OriginalString)
    member this.LiteralNodes =
        this.AllNodes
        |> Seq.toArray
        |> Array.filter (fun node -> node.NodeType = NodeType.Literal)
        |> Array.map (fun node -> node :?> LiteralNode)
        |> Array.filter (fun node -> node.Language = String.Empty)
        |> Array.sortBy (fun node -> node.DataType.OriginalString, node.Value)
    member this.LanguageLiteralNodes =
        this.AllNodes
        |> Seq.toArray
        |> Array.filter (fun node -> node.NodeType = NodeType.Literal)
        |> Array.map (fun node -> node :?> LiteralNode)
        |> Array.filter (fun node -> node.Language <> String.Empty)
        |> Array.sortBy (fun node -> node.Language, node.Value)
    member this.GraphLiteralNodes =
        this.AllNodes
        |> Seq.toArray
        |> Array.filter (fun node -> node.NodeType = NodeType.GraphLiteral)
        |> Array.map (fun node -> node :?> GraphLiteralNode)

    member this.VariableNodes =
        this.AllNodes
        |> Seq.toArray
        |> Array.filter (fun node -> node.NodeType = NodeType.Variable)
        |> Array.map (fun node -> node :?> VariableNode)
    member this.TripleNodes =
        this.AllNodes
        |> Seq.toArray
        |> Array.filter (fun node -> node.NodeType = NodeType.Triple)
        |> Array.map (fun node -> node :?> TripleNode)
        |> Array.sortBy (fun node -> node.Triple.Subject.ToString(), node.Triple.Predicate.ToString(), node.Triple.Object.ToString())



type INamespaceMapper with

    member this.GetNamespaceName(prefix: string) =
        this.GetNamespaceUri prefix |> _.OriginalString








type RdfObject with
    member this.maybeSubject =
        match this with
        | IriObject iri -> Some(IriSubject iri)
        | BlankObject blankReference -> Some(BlankSubject blankReference)
        | LiteralObject rdfLiteral -> None
        | TripleTermObject tripleTerm -> None
        | VariableObject rdfVariable -> Some(VariableSubject rdfVariable)
    member this.maybePredicate =
        match this with
        | IriObject iri -> Some(IriPredicate iri)
        | BlankObject blankReference -> None
        | LiteralObject rdfLiteral -> None
        | TripleTermObject tripleTerm -> None
        | VariableObject rdfVariable -> Some(VariablePredicate rdfVariable)







// ============================================================================
// Result access
// ============================================================================
type SparqlResultSet with

    member this.columnByVariables(rdfVariable: RdfVariable) =
        this.Results
        |> Seq.map (fun result -> result.Item rdfVariable.identifier |> DataPoint.fromINode)
        |> Seq.toArray

module SparqlResultSet =

    let variableIndex (rdfVariable: RdfVariable) (index: int) (resultSet: SparqlResultSet) =
        resultSet.Results
        |> Seq.map (fun result -> result.Item rdfVariable.identifier |> DataPoint.fromINode)
        |> Seq.item index


// ============================================================================
// SPARQL graph-pattern model
//
// Formula remains useful: it represents the basic graph-pattern case already
// expressible by the RDF terms/triples in the surrounding code.
//
// SparqlGraphPattern represents the larger SPARQL graph-pattern language.
// ============================================================================

type SparqlGraphSelector =
    | GraphIri of Iri
    | GraphVariable of RdfVariable


type SparqlGraphPattern =
    | BasicGraphPattern of Formula
    | GroupGraphPattern of SparqlGraphPattern array
    | OptionalGraphPattern of SparqlGraphPattern
    | UnionGraphPattern of SparqlGraphPattern array
    | MinusGraphPattern of SparqlGraphPattern
    | NamedGraphPattern of SparqlGraphSelector * SparqlGraphPattern
    | ServiceGraphPattern of Iri * SparqlGraphPattern
    | FilterGraphPattern of ISparqlExpression
    | BindGraphPattern of RdfVariable * ISparqlExpression


module SparqlPattern =

    let basic (formula: Formula) = BasicGraphPattern formula


    let group (patterns: SparqlGraphPattern seq) =
        patterns |> Seq.toArray |> GroupGraphPattern


    let optional (pattern: SparqlGraphPattern) = OptionalGraphPattern pattern


    let union (patterns: SparqlGraphPattern seq) =

        let patterns = patterns |> Seq.toArray

        if patterns.Length < 2 then
            invalidArg (nameof patterns) "A SPARQL UNION requires at least two graph patterns."

        UnionGraphPattern patterns


    let minus (pattern: SparqlGraphPattern) = MinusGraphPattern pattern


    let graph (graphIri: Iri) (pattern: SparqlGraphPattern) =
        NamedGraphPattern(GraphIri graphIri, pattern)


    let graphVariable (graphVariable: RdfVariable) (pattern: SparqlGraphPattern) =
        NamedGraphPattern(GraphVariable graphVariable, pattern)


    let service (endpoint: Iri) (pattern: SparqlGraphPattern) = ServiceGraphPattern(endpoint, pattern)


    let filter (expression: ISparqlExpression) = FilterGraphPattern expression


    let bind (rdfVariable: RdfVariable) (expression: ISparqlExpression) =
        BindGraphPattern(rdfVariable, expression)


// ============================================================================
// SPARQL dataset clauses
//
// These are SPARQL query-language dataset declarations:
//
//     FROM <iri>
//     FROM NAMED <iri>
//
// They are NOT execution targets.
// ============================================================================

type SparqlDatasetClause =
    | From of RdfIri
    | FromNamed of RdfIri


// ============================================================================
// Strongly typed query values
//
// Building a query no longer executes it.
//
// The query form determines the result type without routing everything through
// obj.
// ============================================================================

type SelectQuery = {
    selectQuery: SparqlQuery
} with

    member this.asSparqlQuery = this.selectQuery

    member this.text = this.selectQuery.ToString()


type AskQuery = {
    askQuery: SparqlQuery
} with

    member this.asSparqlQuery = this.askQuery

    member this.text = this.askQuery.ToString()


type GraphQuery = {
    graphQuery: SparqlQuery
} with

    member this.asSparqlQuery = this.graphQuery

    member this.text = this.graphQuery.ToString()


// ============================================================================
// Low-level dotNetRDF query-form adapters
// ============================================================================

let private SELECTALL () : ISelectBuilder = QueryBuilder.SelectAll()


let private SELECT (variables: RdfVariable seq) : ISelectBuilder =

    variables
    |> Seq.map (fun variable -> variable.identifier)
    |> Seq.toArray
    |> QueryBuilder.Select


let private ASK () : IQueryBuilder = QueryBuilder.Ask()


let private DISCOVER (variables: RdfVariable seq) : IDescribeBuilder =

    variables
    |> Seq.map (fun variable -> variable.questionForm)
    |> Seq.toArray
    |> QueryBuilder.Describe


let private DESCRIBE (iris: Iri seq) : SparqlQuery =

    iris
    |> Seq.map (fun iri -> iri.asUri)
    |> Seq.toArray
    |> QueryBuilder.Describe
    |> fun builder -> builder.BuildQuery()


// ============================================================================
// DESCRIBE variable repair
//
// Retained from the previous implementation because the surrounding code
// already depended upon this behavior.
// ============================================================================

let private repairDescribeVariables (sparqlQuery: SparqlQuery) : SparqlQuery =

    if sparqlQuery.QueryType = SparqlQueryType.Describe then

        let queryVariables = sparqlQuery.Variables :?> System.Collections.Generic.ICollection<SparqlVariable>

        sparqlQuery.DescribeVariables
        |> Seq.filter (fun token -> token.TokenType = VDS.RDF.Parsing.Tokens.Token.VARIABLE)
        |> Seq.iter (fun token ->

            let variableName = token.Value.Substring(1)

            let alreadyRegistered = queryVariables |> Seq.exists (fun variable -> variable.Name = variableName)

            if not alreadyRegistered then
                queryVariables.Add(SparqlVariable(variableName, true)))

    sparqlQuery


// ============================================================================
// Prefix handling
//
// Query construction must not require an execution graph merely to obtain a
// NamespaceMap. The existing global namespaceMapper is therefore imported into
// each query builder.
// ============================================================================

let private importQueryPrefixes (queryBuilder: IQueryBuilder) : IQueryBuilder =

    queryBuilder.Prefixes.Import namespaceMapper

    queryBuilder


// ============================================================================
// Graph-pattern lowering
//
// Converts the F# SparqlGraphPattern representation into dotNetRDF's
// GraphPatternBuilder representation.
// ============================================================================

let rec private applyGraphPattern (patternBuilder: TriplePatternBuilder) (builder: IGraphPatternBuilder) (graphPattern: SparqlGraphPattern) : unit =

    let action (pattern: SparqlGraphPattern) =
        Action<IGraphPatternBuilder>(fun childBuilder -> applyGraphPattern patternBuilder childBuilder pattern)

    match graphPattern with

    | BasicGraphPattern formula ->

        builder.Where(patternBuilder |> formula.ITriplePatterns) |> ignore


    | GroupGraphPattern patterns ->

        builder.Group(
            Action<IGraphPatternBuilder>(fun groupBuilder ->

                patterns |> Array.iter (applyGraphPattern patternBuilder groupBuilder))
        )
        |> ignore


    | OptionalGraphPattern pattern ->

        builder.Optional(action pattern) |> ignore


    | UnionGraphPattern patterns ->

        if patterns.Length < 2 then
            invalidOp "A SPARQL UNION requires at least two graph patterns."

        let actions = patterns |> Array.map action

        builder.Union(actions[0], actions[1..]) |> ignore


    | MinusGraphPattern pattern ->

        builder.Minus(action pattern) |> ignore


    | NamedGraphPattern(GraphIri graphIri, pattern) ->

        builder.Graph(graphIri.asUri, action pattern) |> ignore


    | NamedGraphPattern(GraphVariable graphVariable, pattern) ->

        builder.Graph(graphVariable.questionForm, action pattern) |> ignore


    | ServiceGraphPattern(endpoint, pattern) ->

        builder.Service(endpoint.asUri, action pattern) |> ignore


    | FilterGraphPattern expression ->

        builder.Filter(expression) |> ignore


    | BindGraphPattern(rdfVariable, expression) ->

        builder.Where(BindPattern(rdfVariable.identifier, expression) :> ITriplePattern)
        |> ignore


let private applyWherePattern (queryBuilder: IQueryBuilder) (wherePattern: SparqlGraphPattern) : IQueryBuilder =

    let patternBuilder = TriplePatternBuilder(queryBuilder.Prefixes)

    applyGraphPattern patternBuilder queryBuilder.Root wherePattern

    queryBuilder


// ============================================================================
// Query-level RDF dataset lowering
//
// These become literal SPARQL FROM / FROM NAMED clauses on SparqlQuery.
// ============================================================================

let private applyDatasetClauses (datasetClauses: SparqlDatasetClause array) (sparqlQuery: SparqlQuery) : SparqlQuery =

    datasetClauses
    |> Array.iter (function

        | From graphIri ->

            sparqlQuery.AddDefaultGraph(graphIri.asUriNode :> IRefNode)


        | FromNamed graphIri ->

            sparqlQuery.AddNamedGraph(graphIri.asUriNode :> IRefNode))

    sparqlQuery


// ============================================================================
// Typed query compilers
// ============================================================================

let private buildSelectQuery (variables: RdfVariable array option) (datasetClauses: SparqlDatasetClause array) (wherePattern: SparqlGraphPattern) : SelectQuery =

    let queryBuilder: IQueryBuilder =

        match variables with

        | Some variables -> SELECT variables :> IQueryBuilder

        | None -> SELECTALL() :> IQueryBuilder


    let query =

        queryBuilder
        |> importQueryPrefixes
        |> fun builder -> applyWherePattern builder wherePattern
        |> fun builder -> builder.BuildQuery()
        |> applyDatasetClauses datasetClauses


    { selectQuery = query }


let private buildAskQuery (datasetClauses: SparqlDatasetClause array) (wherePattern: SparqlGraphPattern) : AskQuery =

    let query =

        ASK()
        |> importQueryPrefixes
        |> fun builder -> applyWherePattern builder wherePattern
        |> fun builder -> builder.BuildQuery()
        |> applyDatasetClauses datasetClauses


    { askQuery = query }


let private buildConstructQuery (constructFormula: Formula) (datasetClauses: SparqlDatasetClause array) (wherePattern: SparqlGraphPattern) : GraphQuery =

    let queryBuilder =

        QueryBuilder.Construct(
            Action<IDescribeGraphPatternBuilder>(fun constructTemplate ->

                let templatePatternBuilder = TriplePatternBuilder(namespaceMapper)

                constructTemplate.Where(templatePatternBuilder |> constructFormula.ITriplePatterns)
                |> ignore)
        )


    let query =

        queryBuilder
        |> importQueryPrefixes
        |> fun builder -> applyWherePattern builder wherePattern
        |> fun builder -> builder.BuildQuery()
        |> applyDatasetClauses datasetClauses


    { graphQuery = query }


let private buildDiscoverQuery (variables: RdfVariable array) (datasetClauses: SparqlDatasetClause array) (wherePattern: SparqlGraphPattern) : GraphQuery =

    let queryBuilder =

        DISCOVER variables :> IQueryBuilder


    let query =

        queryBuilder
        |> importQueryPrefixes
        |> fun builder -> applyWherePattern builder wherePattern
        |> fun builder -> builder.BuildQuery()
        |> repairDescribeVariables
        |> applyDatasetClauses datasetClauses


    { graphQuery = query }


let private buildDescribeQuery (iris: Iri array) : GraphQuery =

    let query =

        iris |> DESCRIBE

    query.NamespaceMap.Import namespaceMapper

    { graphQuery = query }


// ============================================================================
// Query computation-expression state
// ============================================================================

type SparqlQueryDraft = {
    datasetClauses: SparqlDatasetClause list

    wherePattern: SparqlGraphPattern option
}


let private emptySparqlQueryDraft = {
    datasetClauses = []

    wherePattern = None
}


// ============================================================================
// Query computation-expression builder
//
// Notice the changed semantics:
//
//     from iri
//
// now means actual SPARQL:
//
//     FROM <iri>
//
// It no longer means "execute against this IGraph".
// ============================================================================

type WhereQueryBuilder<'Query>(build: SparqlQueryDraft -> SparqlGraphPattern -> 'Query) =


    member _.Yield(_: unit) : SparqlQueryDraft = emptySparqlQueryDraft


    member _.Zero() : SparqlQueryDraft = emptySparqlQueryDraft


    member _.For(_draft: SparqlQueryDraft, continuation: unit -> SparqlQueryDraft) : SparqlQueryDraft = continuation ()


    [<CustomOperation("from")>]
    member _.From(draft: SparqlQueryDraft, graphIri: RdfIri) : SparqlQueryDraft =

        {
            draft with

                datasetClauses = From graphIri :: draft.datasetClauses
        }


    [<CustomOperation("fromNamed")>]
    member _.FromNamed(draft: SparqlQueryDraft, graphIri: RdfIri) : SparqlQueryDraft =

        {
            draft with

                datasetClauses = FromNamed graphIri :: draft.datasetClauses
        }


    // Compatibility/convenience form:
    //
    //     where formula
    //
    // A Formula becomes a basic graph pattern.

    [<CustomOperation("where")>]
    member _.Where(draft: SparqlQueryDraft, formula: Formula) : SparqlQueryDraft =

        match draft.wherePattern with

        | Some _ ->

            invalidOp "The query already contains a WHERE graph pattern."


        | None ->

            {
                draft with

                    wherePattern = Some(BasicGraphPattern formula)
            }


    // Full graph-pattern form:
    //
    //     wherePattern pattern
    //
    // This is used for GRAPH, OPTIONAL, UNION, MINUS, SERVICE, FILTER, BIND,
    // nested groups, etc.

    [<CustomOperation("wherePattern")>]
    member _.WherePattern(draft: SparqlQueryDraft, graphPattern: SparqlGraphPattern) : SparqlQueryDraft =

        match draft.wherePattern with

        | Some _ ->

            invalidOp "The query already contains a WHERE graph pattern."


        | None ->

            {
                draft with

                    wherePattern = Some graphPattern
            }


    member _.Run(draft: SparqlQueryDraft) : 'Query =

        let wherePattern =

            match draft.wherePattern with

            | Some wherePattern -> wherePattern

            | None -> invalidOp "The query requires a WHERE graph pattern."


        let normalizedDraft =

            {
                draft with

                    datasetClauses = draft.datasetClauses |> List.rev
            }


        build normalizedDraft wherePattern


// ============================================================================
// Public SPARQL query-authoring surface
//
// These BUILD query values. They do not execute.
// ============================================================================

module sparql =


    let select (variables: RdfVariable seq) : WhereQueryBuilder<SelectQuery> =

        let variables = variables |> Seq.toArray

        WhereQueryBuilder<SelectQuery>(fun draft wherePattern ->

            buildSelectQuery (Some variables) (draft.datasetClauses |> List.toArray) wherePattern)


    let selectAll: WhereQueryBuilder<SelectQuery> =

        WhereQueryBuilder<SelectQuery>(fun draft wherePattern ->

            buildSelectQuery None (draft.datasetClauses |> List.toArray) wherePattern)


    let construct (constructFormula: Formula) : WhereQueryBuilder<GraphQuery> =

        WhereQueryBuilder<GraphQuery>(fun draft wherePattern ->

            buildConstructQuery constructFormula (draft.datasetClauses |> List.toArray) wherePattern)


    let ask: WhereQueryBuilder<AskQuery> =

        WhereQueryBuilder<AskQuery>(fun draft wherePattern ->

            buildAskQuery (draft.datasetClauses |> List.toArray) wherePattern)


    // "discover" remains your convenience name for:
    //
    //     DESCRIBE ?variable ...
    //     WHERE { ... }

    let discover (variables: RdfVariable seq) : WhereQueryBuilder<GraphQuery> =

        let variables = variables |> Seq.toArray

        WhereQueryBuilder<GraphQuery>(fun draft wherePattern ->

            buildDiscoverQuery variables (draft.datasetClauses |> List.toArray) wherePattern)


    // DESCRIBE of concrete IRIs does not require a WHERE clause and therefore
    // remains a direct function rather than a WhereQueryBuilder.

    let describe (iris: Iri seq) : GraphQuery =

        iris |> Seq.toArray |> buildDescribeQuery


// ============================================================================
// SPARQL Protocol dataset
//
// This is deliberately separate from SparqlDatasetClause.
//
// These values become HTTP protocol parameters on a remote endpoint:
//
//     default-graph-uri
//     named-graph-uri
//
// rather than FROM / FROM NAMED in the SPARQL text.
// ============================================================================

type SparqlProtocolDataset = {
    defaultGraphs: Iri array

    namedGraphs: Iri array
} with

    static member Empty = {
        defaultGraphs = [||]

        namedGraphs = [||]
    }


// ============================================================================
// Remote SPARQL endpoint
//
// This is the remote execution substrate.
// It is NOT part of the query AST.
// ============================================================================

type SparqlRemoteEndpoint = {
    httpClient: HttpClient

    endpointUri: Uri

    protocolDataset: SparqlProtocolDataset
} with


    static member fromUri(httpClient: HttpClient, endpointUri: Uri) =

        {
            httpClient = httpClient

            endpointUri = endpointUri

            protocolDataset = SparqlProtocolDataset.Empty
        }


    static member fromString(httpClient: HttpClient, endpointUri: string) =

        SparqlRemoteEndpoint.fromUri (httpClient, Uri endpointUri)


    static member fromIri(httpClient: HttpClient, endpointIri: Iri) =

        SparqlRemoteEndpoint.fromUri (httpClient, endpointIri.asUri)

    static member fromUrl(httpClient: HttpClient, endpointUrl: DomUrl) =

        SparqlRemoteEndpoint.fromUri (httpClient, Uri endpointUrl.Href)


    member this.withDefaultGraph(graphIri: Iri) =

        {
            this with

                protocolDataset = {
                    this.protocolDataset with

                        defaultGraphs = Array.append this.protocolDataset.defaultGraphs [| graphIri |]
                }
        }


    member this.withNamedGraph(graphIri: Iri) =

        {
            this with

                protocolDataset = {
                    this.protocolDataset with

                        namedGraphs = Array.append this.protocolDataset.namedGraphs [| graphIri |]
                }
        }


    member private this.createClient() =

        let client = SparqlQueryClient(this.httpClient, this.endpointUri)


        this.protocolDataset.defaultGraphs
        |> Array.iter (fun graphIri ->

            client.DefaultGraphs.Add(graphIri.lexicalForm))


        this.protocolDataset.namedGraphs
        |> Array.iter (fun graphIri ->

            client.NamedGraphs.Add(graphIri.lexicalForm))


        client


    member this.query(selectQuery: SelectQuery, ?cancellationToken: CancellationToken) : Task<SparqlResultSet> =

        let cancellationToken = defaultArg cancellationToken CancellationToken.None

        let client = this.createClient ()

        client.QueryWithResultSetAsync(selectQuery.text, cancellationToken)


    member this.query(askQuery: AskQuery, ?cancellationToken: CancellationToken) : Task<bool> =

        task {

            let cancellationToken = defaultArg cancellationToken CancellationToken.None

            let client = this.createClient ()

            let! resultSet = client.QueryWithResultSetAsync(askQuery.text, cancellationToken)

            return resultSet.Result
        }


    member this.query(graphQuery: GraphQuery, ?cancellationToken: CancellationToken) : Task<IGraph> =

        let cancellationToken = defaultArg cancellationToken CancellationToken.None

        let client = this.createClient ()

        client.QueryWithResultGraphAsync(graphQuery.text, cancellationToken)


// ============================================================================
// Local SPARQL dataset
//
// A local graph is only one special case of a local RDF dataset.
//
// A caller can now execute against:
//
//     IGraph
//     IInMemoryQueryableStore
//     ISparqlDataset
//
// without changing the query itself.
// ============================================================================

type SparqlLocalDataset = {
    dataset: ISparqlDataset
} with


    static member fromDataset(dataset: ISparqlDataset) =

        { dataset = dataset }


    static member fromGraph(graph: IGraph) =

        {
            dataset = new InMemoryDataset(graph) :> ISparqlDataset
        }


    static member fromStore(store: IInMemoryQueryableStore) =

        {
            dataset = new InMemoryDataset(store) :> ISparqlDataset
        }


    member private this.processQuery(query: SparqlQuery) =

        let processor = new LeviathanQueryProcessor(this.dataset)

        processor.ProcessQuery(query)


    member this.query(selectQuery: SelectQuery) : SparqlResultSet =

        this.processQuery (selectQuery.asSparqlQuery) :?> SparqlResultSet


    member this.query(askQuery: AskQuery) : bool =

        let resultSet =

            this.processQuery (askQuery.asSparqlQuery) :?> SparqlResultSet

        resultSet.Result


    member this.query(graphQuery: GraphQuery) : IGraph =

        this.processQuery (graphQuery.asSparqlQuery) :?> IGraph





type DomUrl with
    member this.asSparqlRemoteEndpoint = SparqlRemoteEndpoint.fromString (new HttpClient(), this.Href)




let rdfTab = chrome.NewPageAsync().await.asCdp
chrome.tabs |> Array.map (fun tab -> tab.Url) |> String.concat "\n" |> String.Clipboard.SetText



module https =
    let scheme = IanaScheme.https

    module org =
        let topLevelDomain = TopLevelDomain.org

        module edmcouncil =
            let secondLevelDomain = "edmcouncil"
            let host = secondLevelDomain +. topLevelDomain
            let site = scheme ..// host

            module spec =
                let site = site .+ "spec"
                module ontology = 

                    let space = site +/ "edmcouncil/fibo/ontology/{ontology}"
                    let ontology (ontology) = space.pathTemplate.AddParameter("ontology", ontology).Resolve() |> HttpUtility.UrlDecode |> Iri.fromString
                    let master = ontology "master"



let namespaceName = graphDistributions[0]
namespaceName.namespaceIri.remoteReference
let namespaceTurtleFile = Path.Combine (namespaceName.namespaceIri.localReference, IanaMimeType.text.turtle.asRelativeFilePath.WeakString) |> FileInfo
namespaceTurtleFile
