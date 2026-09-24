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

open System
open System.Text
open System.Globalization
open System.Text
open System.Text.RegularExpressions
open System.Text.Unicode
open System.IO
open System.Web
open System.Linq
open System.Collections
open FSharp.Data
open AW.Identifiers
open LSL.DataUri
open TextCopy
open Nager.PublicSuffix
open FSharp.Collections.ParallelSeq
open Nager.PublicSuffix.Models
open Nager.PublicSuffix.RuleProviders
open System.Text
open FSharp.HashCollections
open System.Net
open System.IO
open Fabulous.AST
open Fantomas.Core
open System.Globalization
open ModelingEvolution.Ipv4
open System.Net.Sockets
open Dubzer.WhatwgUrl
open VDS.Common.Tries
open Meziantou.Framework
open Microsoft.AspNetCore.Http
open ktsu.Semantics.Paths
open Universal.Common
open FolkerKinzel.MimeTypes
open Tavis.UriTemplates
open Humanizer
open CaseConverter
open PuppeteerSharp
open PuppeteerSharp.Cdp
open BrowserApi
open BrowserApi.Common
open System.Collections.Concurrent
open PuppeteerSharp.Cdp.Messaging
open System.Numerics
open System.Threading.Tasks
open WebDriverBiDi
open WebDriverBiDi.Session
open WebDriverBiDi.BrowsingContext
open BrowserApi.Css.Authoring
open IriTools
open Iride
open VDS.RDF
open VDS.RDF.Storage
open RDFSharp.Model
open FsHttp
open System.Net.Http
open VDS.RDF.Parsing
open VDS.RDF.Query.Datasets
open VDS.RDF.Ontology
open VDS.RDF.Query
open VDS.RDF.Query.Builder
open FSharp.Data.Adaptive.Transaction
open VDS.RDF.Query.Patterns
open RDFSharp.Model
open VDS.RDF.Query.Expressions
open System.Threading
open NLanguageTag
open System.Xml

open VDS.RDF.Query.Paths
let personalUriTemplate = UriTemplate "https://eristocrates.dev/ontology/{namespacePrefix}/{localName}"
let genidUriTemplate = UriTemplate "https://eristocrates.dev/.well-known/genid/{uuid}"

type GreatGlobalGraph() =
    let _httpClient =
        let httpClient = new HttpClient()

        [|
            "application/trig;q=1"
            "application/n-quads;q=0.95"
            "text/turtle;q=0.9"
            "application/n-triples;q=0.85"
            "application/rdf+xml;q=0.8"
            "application/ld+json;q=0.75"
            "application/json;q=0.7"
            "application/xml;q=0.6"
            "text/xml;q=0.55"
            "text/html;q=0.4"
            "text/plain;q=0.2"
            "text/plain;charset=utf-8;q=0.2"
            "*/*;q=0.1"
        |]
        |> Array.iter (fun contentType -> httpClient.DefaultRequestHeaders.Accept.ParseAdd(contentType))

        httpClient

    let _loader =
        let loader = new Loader(_httpClient)
        loader.FollowRedirects <- true
        loader

    let _threadSafeGraph = new ThreadSafeGraph(UriNode(RDFNamespaceRegister.DefaultNamespace.NamespaceUri))

    let _threadSafeTripleStore = new ThreadSafeTripleStore()
    member this.defaultGraph = _threadSafeGraph
    member this.tripleStore = _threadSafeTripleStore

    member this.dataset = new InMemoryQuadDataset(_threadSafeTripleStore, _threadSafeGraph.Name)

    member this.memoryManager = new InMemoryManager(this.dataset)
    member this.httpClient = _httpClient
    member this.loader = _loader

let ggg = GreatGlobalGraph()

type InitialTextDirection =
    | Ltr
    | Rtl

    member this.asString = this.ToString().ToLowerInvariant()

type DataPoint =
    | RdfIri of NamedReference
    | RdfBlankNode of AnonymousReference
    | RdfLiteral of LiteralValue
    | RdfVariable of VariableReference
    | RdfTripleTerm of RdfTripleTerm
    | RdfFormula of Formula

    static member fromINode(inode: INode) =
        match inode.NodeType with
        | NodeType.Uri -> inode :?> UriNode |> NamedReference |> RdfIri
        | NodeType.Blank -> inode :?> BlankNode |> AnonymousReference |> RdfBlankNode
        | NodeType.Literal -> inode :?> LiteralNode |> LiteralValue.fromLiteralNode |> RdfLiteral
        | NodeType.Variable -> inode :?> VariableNode |> VariableReference |> RdfVariable
        | NodeType.GraphLiteral -> inode :?> GraphLiteralNode |> Formula.fromGraphLiteralNode |> RdfFormula
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

and NamedReference(iriReference: IriReference) =
    let _rdfResource = RDFResource(iriReference.ToString())
    let _uriNode = UriNode(iriReference.uri)
    new(uri: Uri) = NamedReference(IriReference uri)
    new(url: DomUrl) = NamedReference(IriReference(HttpUtility.UrlDecode url.Href))
    new(uriNode: UriNode) = NamedReference(IriReference uriNode.Uri)
    member this.iriref = iriReference
    member this.lexicalForm = iriReference.ToString()
    member this.rdfResource = _rdfResource
    member this.uriNode = _uriNode
    member this.asINode = _uriNode :> INode
    member this.irefnode = _uriNode :> IRefNode
    member this.uri = iriReference.uri
    member this.url = iriReference.url
    member this.asSubject = IriSubject this
    member this.asPredicate = IriPredicate this
    member this.asObject = IriObject this
    member this.asPath = PredicatePath this
    member this.asGraphVerb = IriPredicate this |> PredicateVerb
and AnonymousReference(identifier: string) =
    let _blankNode = BlankNode(identifier)
    let _rdfResource = RDFResource()
    new() = AnonymousReference(Guid.NewGuid().ToString("N"))
    new(blankNode: BlankNode) = AnonymousReference(blankNode.InternalID)
    member this.identifier = identifier
    member this.lexicalForm = identifier
    member this.blankNode = _blankNode
    member this.asINode = _blankNode :> INode
    member this.rdfResource = _rdfResource
    member this.asSubject = BlankSubject this
    member this.asObject = BlankObject this

and LiteralValue =
    | SimpleLiteral of SimpleString
    | LanguageLiteral of LanguageString
    | DirectedLanguageLiteral of DirectedLanguageString
    | DatatypedLiteral of DatatypedString

    static member inline autotyped<'ValueType>(value: 'ValueType) : LiteralValue =

        let xsd localName =
            NamedReference $"http://www.w3.org/2001/XMLSchema#{localName}"

        let xsi localName =
            NamedReference $"http://www.w3.org/2001/XMLSchema-instance#{localName}"

        let xdt localName =
            NamedReference $"https://www.w3.org/2003/05/xpath-datatypes#{localName}"

        let datatyped (lexicalForm: string) (datatype: NamedReference) =
            DatatypedString(SimpleString lexicalForm, datatype) |> DatatypedLiteral

        let invariantString =
            if box value = null then
                String.Empty
            else
                Convert.ToString(value, CultureInfo.InvariantCulture)

        match box value with
        | :? Boolean as value -> datatyped (if value then "true" else "false") (xsd "boolean")

        | :? (Byte array) as value -> datatyped (Convert.ToBase64String value) (xsd "base64Binary")

        | :? Byte -> datatyped invariantString (xsd "unsignedByte")

        | :? DateOnly as value -> datatyped (value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)) (xsd "date")

        | :? DateTime as value -> datatyped (value.ToString("yyyy-MM-dd'T'HH:mm:ss.ffffffzzz", CultureInfo.InvariantCulture)) (xsd "dateTime")

        | :? DateTimeOffset as value -> datatyped (value.ToString("o", CultureInfo.InvariantCulture)) (xsd "dateTimeStamp")

        | :? Decimal -> datatyped invariantString (xsd "decimal")

        | :? Double as value -> datatyped (value.ToString("R", CultureInfo.InvariantCulture)) (xsd "double")

        | :? Int16 -> datatyped invariantString (xsd "short")

        | :? Int32 -> datatyped invariantString (xsd "int")

        | :? Int64 -> datatyped invariantString (xsd "long")

        | :? SByte -> datatyped invariantString (xsd "byte")

        | :? Single as value -> datatyped (value.ToString("R", CultureInfo.InvariantCulture)) (xsd "float")

        | :? TimeOnly as value -> datatyped (value.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)) (xsd "time")

        | :? TimeSpan as value -> datatyped (Xml.XmlConvert.ToString value) (xsd "duration")

        | :? UInt16 -> datatyped invariantString (xsd "unsignedShort")

        | :? UInt32 -> datatyped invariantString (xsd "unsignedInt")

        | :? UInt64 -> datatyped invariantString (xsd "unsignedLong")

        | :? Uri as value -> datatyped value.OriginalString (xsd "anyURI")

        | :? DomUrl as value -> datatyped (value.ToString()) (xsd "anyURI")

        | :? NamedReference as value -> datatyped value.lexicalForm (xsd "anyURI")

        | :? XmlQualifiedName as value -> datatyped (value.ToString()) (xsd "QName")

        | :? Guid as value -> datatyped (value.ToString("N")) (xsd "ID")

        | :? String as value -> SimpleString value |> SimpleLiteral

        | null -> datatyped "true" (xsi "nil")

        | _ -> datatyped invariantString (xdt "anyAtomicType")
    member this.asObject = LiteralObject this

    member this.lexicalForm =
        match this with
        | SimpleLiteral simpleString -> simpleString.lexicalForm
        | LanguageLiteral languageString -> languageString.lexicalForm
        | DirectedLanguageLiteral directedLanguageString -> directedLanguageString.lexicalForm
        | DatatypedLiteral datatypedString -> datatypedString.lexicalForm
    member this.datatype =
        match this with
        | SimpleLiteral simpleString -> simpleString.datatype
        | LanguageLiteral languageString -> languageString.datatype
        | DirectedLanguageLiteral directedLanguageString -> directedLanguageString.datatype
        | DatatypedLiteral datatypedString -> datatypedString.datatype
    member this.rdfDatatype =
        match this with
        | SimpleLiteral simpleString -> simpleString.rdfDatatype
        | LanguageLiteral languageString -> languageString.rdfDatatype
        | DirectedLanguageLiteral directedLanguageString -> directedLanguageString.rdfDatatype
        | DatatypedLiteral datatypedString -> datatypedString.rdfDatatype
    member this.literalNode =
        match this with
        | SimpleLiteral simpleString -> simpleString.literalNode
        | LanguageLiteral languageString -> languageString.literalNode
        | DirectedLanguageLiteral directedLanguageString -> directedLanguageString.literalNode
        | DatatypedLiteral datatypedString -> datatypedString.literalNode
    member this.tryLanguageTag =
        match this with
        | SimpleLiteral simpleString -> None
        | LanguageLiteral languageString -> Some languageString.languageTag
        | DirectedLanguageLiteral directedLanguageString -> Some directedLanguageString.languageTag
        | DatatypedLiteral datatypedString -> None
    member this.tryBaseDirection =
        match this with
        | SimpleLiteral simpleString -> None
        | LanguageLiteral languageString -> None
        | DirectedLanguageLiteral directedLanguageString -> Some directedLanguageString.baseDirection
        | DatatypedLiteral datatypedString -> None
    static member fromLiteralNode(literalNode: LiteralNode) =
        match literalNode.DataType.OriginalString, Option.ofNullOrWhiteSpace literalNode.Language with
        | _, Some language -> LanguageString literalNode |> LanguageLiteral
        | "http://www.w3.org/2001/XMLSchema#string", _ -> SimpleString literalNode |> SimpleLiteral
        | _, _ -> DatatypedString literalNode |> DatatypedLiteral
    member this.asINode =
        match this with
        | SimpleLiteral simpleString -> simpleString.asINode
        | LanguageLiteral datatypedString -> datatypedString.asINode
        | DirectedLanguageLiteral languageString -> languageString.asINode
        | DatatypedLiteral directedLanguageString -> directedLanguageString.asINode
and SimpleString(lexicalForm: string) =
    let _literalNode = LiteralNode(lexicalForm)
    let _datatype = NamedReference "http://www.w3.org/2001/XMLSchema#string"
    let _rdfDatatype = RDFDatatypeRegister.GetDatatype(_datatype.lexicalForm)
    new(literalNode: LiteralNode) = SimpleString(literalNode.Value)
    member this.lexicalForm = lexicalForm
    member this.rdfPlainLiteral = RDFPlainLiteral this.lexicalForm
    member this.literalNode = _literalNode
    member this.asINode = _literalNode :> INode
    member this.rdfDatatype = _rdfDatatype
    member this.datatype = _datatype
    member this.asObject = LiteralObject(SimpleLiteral this)

and LanguageString(simpleString: SimpleString, languageTag: NLanguageTag.LanguageTag) =
    let _literalNode = LiteralNode(simpleString.lexicalForm, languageTag.ToString())

    let _rdfPlainLiteral = RDFPlainLiteral(simpleString.lexicalForm, languageTag.ToString())

    let _datatype = NamedReference "http://www.w3.org/1999/02/22-rdf-syntax-ns#langString"

    let _rdfDatatype = RDFDatatypeRegister.GetDatatype(_datatype.lexicalForm)

    new(literalNode: LiteralNode) = LanguageString(SimpleString(literalNode.Value), NLanguageTag.LanguageTag.Parse literalNode.Language)

    member this.lexicalForm = simpleString.lexicalForm
    member this.simpleString = simpleString
    member this.languageTag = languageTag
    member this.literalNode = _literalNode
    member this.asINode = _literalNode :> INode
    member this.rdfPlainLiteral = _rdfPlainLiteral
    member this.datatype = _datatype
    member this.rdfDatatype = _rdfDatatype
    member this.asObject = LiteralObject(LanguageLiteral this)

and DirectedLanguageString(languageString: LanguageString, baseDirection: InitialTextDirection) =
    let _literalNode = languageString.literalNode

    let _rdfPlainLiteral = RDFPlainLiteral(languageString.lexicalForm, $"{languageString.languageTag.ToString()}--{baseDirection.asString}")

    let _datatype = NamedReference "http://www.w3.org/1999/02/22-rdf-syntax-ns#dirLangString"

    let _rdfDatatype = RDFDatatypeRegister.GetDatatype(_datatype.lexicalForm)
    member this.languageString = languageString
    member this.baseDirection = baseDirection
    member this.lexicalForm = languageString.lexicalForm
    member this.languageTag = languageString.languageTag
    member this.literalNode = _literalNode
    member this.asINode = _literalNode :> INode
    member this.rdfPlainLiteral = _rdfPlainLiteral
    member this.datatype = _datatype
    member this.rdfDatatype = _rdfDatatype
    member this.asObject = LiteralObject(DirectedLanguageLiteral this)

and DatatypedString(simpleString: SimpleString, datatype: NamedReference) =
    let _literalNode = LiteralNode(simpleString.lexicalForm, datatype.uri)
    let _rdfDatatype = RDFDatatypeRegister.GetDatatype(datatype.lexicalForm)
    let _rdfTypedLiteral = RDFTypedLiteral(simpleString.lexicalForm, _rdfDatatype)
    new(literalNode: LiteralNode) = DatatypedString(SimpleString(literalNode.Value), NamedReference literalNode.DataType)
    member this.simpleString = simpleString
    member this.lexicalForm = simpleString.lexicalForm
    member this.datatype = datatype
    member this.rdfTypedLiteral = _rdfTypedLiteral
    member this.rdfDatatype = _rdfDatatype
    member this.literalNode = _literalNode
    member this.asINode = _literalNode :> INode
    member this.asObject = LiteralObject(DatatypedLiteral this)

and VariableReference(identifier: string) =

    let _guid = Guid.NewGuid()
    let _uuid = _guid.ToString("N")
    let _identifier = identifier
    let _bindingCell = Adaptive.cval (None: DataPoint option)

    let _binding: Adaptive.aval<DataPoint option> = _bindingCell :> Adaptive.aval<DataPoint option>

    let _dollarForm = sprintf "$%s" identifier
    let _questionForm = sprintf "?%s" identifier
    let _variableNode = new VariableNode(identifier)
    let _sparqlVariable = new SparqlVariable(identifier)
    new(variableNode: VariableNode) = VariableReference(variableNode.VariableName)

    member this.identifier = _identifier
    member this.lexicalForm = _identifier
    member this.guid = _guid
    member this.uuid = _uuid

    member this.variableNode = _variableNode
    member this.asINode = _variableNode :> INode
    member this.bindingCell = _bindingCell

    member this.vdsSparqlVariable = _sparqlVariable
    member this.dollarForm = _dollarForm
    member this.questionForm = _questionForm
    member this.asSubject = VariableSubject this
    member this.asPredicate = VariablePredicate this
    member this.asObject = VariableObject this
    member this.asAnonymousReference = AnonymousReference(this.uuid)
    member this.rdfResource = this.asAnonymousReference.rdfResource
    member this.asGraphVerb = this.asPredicate |> PredicateVerb

    member this.asPatternItem(patternBuilder: TriplePatternBuilder) =
        patternBuilder.PatternItemFactory.CreateVariablePattern(this.identifier)

    /// Read-only adaptive view of the current binding.
    member this.binding = _binding

    member this.bind(rdf_term: DataPoint) =
        transact (fun () -> _bindingCell.Value <- Some rdf_term)

    member this.unbind() =
        transact (fun () -> _bindingCell.Value <- None)

    member this.maybeValue = _binding |> Adaptive.AVal.force

    override this.Equals(other: obj) =
        match other with
        | :? VariableReference as other -> _guid = other.guid

        | _ -> false

    override this.GetHashCode() = _guid.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? VariableReference as other -> compare _guid other.guid

            | _ -> invalidArg (nameof other) "An VariableReference can only be compared with another RDF_Variable."

and RdfSubject =
    | IriSubject of NamedReference
    | BlankSubject of AnonymousReference
    | VariableSubject of VariableReference

    member this.lexicalForm =
        match this with
        | IriSubject iri -> iri.lexicalForm
        | BlankSubject blankReference -> blankReference.lexicalForm
        | VariableSubject rdfVariable -> rdfVariable.lexicalForm

    static member fromINode(inode: INode) =
        match inode.NodeType with
        | NodeType.Uri -> inode :?> UriNode |> NamedReference |> IriSubject
        | NodeType.Blank -> inode :?> BlankNode |> AnonymousReference |> BlankSubject
        | NodeType.Variable -> inode :?> VariableNode |> VariableReference |> VariableSubject

    member this.asDataPoint =
        match this with
        | IriSubject iri -> RdfIri iri
        | BlankSubject blankReference -> RdfBlankNode blankReference
        | VariableSubject rdfVariable -> RdfVariable rdfVariable

    member this.asINode =
        match this with
        | IriSubject iri -> iri.asINode
        | BlankSubject blankReference -> blankReference.asINode
        | VariableSubject rdfVariable -> rdfVariable.asINode
    member this.asRDFResource =
        match this with
        | IriSubject iri -> iri.rdfResource
        | BlankSubject blankReference -> blankReference.rdfResource
        | VariableSubject rdfVariable -> rdfVariable.rdfResource

    member this.asPatternItem(patternBuilder: TriplePatternBuilder) : PatternItem =
        match this with
        | VariableSubject rdfVariable -> patternBuilder |> rdfVariable.asPatternItem
        | _ -> patternBuilder.PatternItemFactory.CreateNodeMatchPattern(this.asINode)
    member this.tryPredicate =
        match this with
        | IriSubject iri -> Some(IriPredicate iri)
        | BlankSubject blankReference -> None
        | VariableSubject rdfVariable -> Some(VariablePredicate rdfVariable)

    member this.asObject =
        match this with
        | IriSubject iri -> IriObject iri
        | BlankSubject blankReference -> BlankObject blankReference
        | VariableSubject rdfVariable -> VariableObject rdfVariable
and RdfPredicate =
    | IriPredicate of NamedReference
    | VariablePredicate of VariableReference

    member this.lexicalForm =
        match this with
        | IriPredicate iri -> iri.lexicalForm
        | VariablePredicate rdfVariable -> rdfVariable.lexicalForm
    member this.asGraphVerb = PredicateVerb this
    static member fromINode(inode: INode) =
        match inode.NodeType with
        | NodeType.Uri -> inode :?> UriNode |> NamedReference |> IriPredicate
        | NodeType.Variable -> inode :?> VariableNode |> VariableReference |> VariablePredicate

    member this.asINode =
        match this with
        | IriPredicate iri -> iri.asINode
        | VariablePredicate rdfVariable -> rdfVariable.asINode
    member this.asRDFResource =
        match this with
        | IriPredicate iri -> iri.rdfResource
        | VariablePredicate rdfVariable -> rdfVariable.rdfResource

    member this.asPatternItem(patternBuilder: TriplePatternBuilder) : PatternItem =
        match this with
        | VariablePredicate rdfVariable -> patternBuilder |> rdfVariable.asPatternItem
        | _ -> patternBuilder.PatternItemFactory.CreateNodeMatchPattern(this.asINode)

    member this.asDataPoint =
        match this with
        | IriPredicate iri -> RdfIri iri
        | VariablePredicate rdfVariable -> RdfVariable rdfVariable
    member this.asSubject =
        match this with
        | IriPredicate iri -> IriSubject iri
        | VariablePredicate rdfVariable -> VariableSubject rdfVariable
    member this.asObject =
        match this with
        | IriPredicate iri -> IriObject iri
        | VariablePredicate rdfVariable -> VariableObject rdfVariable

and RdfTripleTerm = {
    ttTriple: RdfTriple
} with

    member this.lexicalForm = this.ttTriple.lexicalForm

    static member fromVDSTriple(vdsTriple: VDS.RDF.Triple) = {
        ttTriple = RdfTriple.fromVDSTriple vdsTriple
    }

    static member fromTripleNode(tripleNode: TripleNode) =
        RdfTripleTerm.fromVDSTriple tripleNode.Triple

    member this.tripleNode = new TripleNode(this.ttTriple.triple)
    member this.asINode: INode = this.tripleNode

    member this.asObject = TripleTermObject this

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
    member this.dataPoints = [|
        this.curSubject.asDataPoint
        this.curPredicate.asDataPoint
        this.curObject.asDataPoint
    |]

    member this.lexicalForms = [|
        this.curSubject.lexicalForm
        this.curPredicate.lexicalForm
        this.curObject.lexicalForm
    |]

    member this.lexicalForm = this.lexicalForms |> String.concat " "

    member this.triple = new Triple(this.curSubject.asINode, this.curPredicate.asINode, this.curObject.asINode)
    member this.rdfTriple =
        match this.curObject with
        | IriObject iri -> new RDFTriple(this.curSubject.asRDFResource, this.curPredicate.asRDFResource, iri.rdfResource)
        | BlankObject blankReference -> new RDFTriple(this.curSubject.asRDFResource, this.curPredicate.asRDFResource, blankReference.rdfResource)
        | LiteralObject(SimpleLiteral literalValue) -> new RDFTriple(this.curSubject.asRDFResource, this.curPredicate.asRDFResource, literalValue.rdfPlainLiteral)
        | LiteralObject(LanguageLiteral literalValue) -> new RDFTriple(this.curSubject.asRDFResource, this.curPredicate.asRDFResource, literalValue.rdfPlainLiteral)
        | LiteralObject(DirectedLanguageLiteral literalValue) -> new RDFTriple(this.curSubject.asRDFResource, this.curPredicate.asRDFResource, literalValue.rdfPlainLiteral)
        | LiteralObject(DatatypedLiteral literalValue) -> new RDFTriple(this.curSubject.asRDFResource, this.curPredicate.asRDFResource, literalValue.rdfTypedLiteral)
        | TripleTermObject tripleTerm -> new RDFTriple(this.curSubject.asRDFResource, this.curPredicate.asRDFResource, tripleTerm.ttTriple.rdfTriple.ReificationSubject)
        | VariableObject rdfVariable -> new RDFTriple(this.curSubject.asRDFResource, this.curPredicate.asRDFResource, rdfVariable.rdfResource)

    member this.asITriplePattern(patternBuilder: TriplePatternBuilder) =
        TriplePattern(this.curSubject.asPatternItem patternBuilder, this.curPredicate.asPatternItem patternBuilder, this.curObject.asPatternItem patternBuilder)
        :> ITriplePattern
    member this.asObject = TripleTermObject { ttTriple = this }
and RdfObject =
    | IriObject of NamedReference
    | BlankObject of AnonymousReference
    | LiteralObject of LiteralValue
    | TripleTermObject of RdfTripleTerm
    | VariableObject of VariableReference

    member this.lexicalForm =
        match this with
        | IriObject iri -> iri.lexicalForm
        | BlankObject blankReference -> blankReference.lexicalForm
        | LiteralObject literalValue -> literalValue.lexicalForm
        | TripleTermObject tripleTerm -> tripleTerm.lexicalForm
        | VariableObject rdfVariable -> rdfVariable.lexicalForm

    static member fromINode(inode: INode) =
        match inode.NodeType with
        | NodeType.Uri -> inode :?> UriNode |> NamedReference |> IriObject
        | NodeType.Blank -> inode :?> BlankNode |> AnonymousReference |> BlankObject
        | NodeType.Literal -> inode :?> LiteralNode |> LiteralValue.fromLiteralNode |> LiteralObject
        | NodeType.Triple -> inode :?> TripleNode |> RdfTripleTerm.fromTripleNode |> TripleTermObject
        | NodeType.Variable -> inode :?> VariableNode |> VariableReference |> VariableObject

    member this.asDataPoint =
        match this with
        | IriObject iri -> RdfIri iri
        | BlankObject blankReference -> RdfBlankNode blankReference
        | LiteralObject literalValue -> RdfLiteral literalValue
        | TripleTermObject tripleTerm -> RdfTripleTerm tripleTerm
        | VariableObject rdfVariable -> RdfVariable rdfVariable

    member this.asINode =
        match this with
        | IriObject iri -> iri.asINode
        | BlankObject blankReference -> blankReference.asINode
        | LiteralObject literalValue -> literalValue.asINode
        | TripleTermObject tripleTerm -> tripleTerm.asINode
        | VariableObject rdfVariable -> rdfVariable.asINode
    member this.tryRDFResource =
        match this with
        | IriObject iri -> Some iri.rdfResource
        | BlankObject blankReference -> Some blankReference.rdfResource
        | LiteralObject literalValue -> None
        | TripleTermObject(tripleTerm: RdfTripleTerm) ->
            let reificationSubject: RDFResource = tripleTerm.ttTriple.rdfTriple.ReificationSubject
            Some reificationSubject
        | VariableObject rdfVariable -> Some rdfVariable.rdfResource

    member this.asPatternItem(patternBuilder: TriplePatternBuilder) : PatternItem =
        match this with
        | VariableObject rdfVariable -> patternBuilder |> rdfVariable.asPatternItem
        | _ -> patternBuilder.PatternItemFactory.CreateNodeMatchPattern(this.asINode)

    member this.trySubject =
        match this with
        | IriObject iri -> Some(IriSubject iri)
        | BlankObject blankReference -> Some(BlankSubject blankReference)
        | LiteralObject literalValue -> None
        | TripleTermObject tripleTerm -> None
        | VariableObject rdfVariable -> Some(VariableSubject rdfVariable)
    member this.tryPredicate =
        match this with
        | IriObject iri -> Some(IriPredicate iri)
        | BlankObject blankReference -> None
        | LiteralObject literalValue -> None
        | TripleTermObject tripleTerm -> None
        | VariableObject rdfVariable -> Some(VariablePredicate rdfVariable)
and Formula = {

    subjects: RdfSubject array
    verbs: GraphVerb array
    objects: RdfObject array
    predicateObjectLists: PredicateObjectList array
    triples: HashSet<RdfTriple>
    pathPatterns: GraphPathPattern array

} with

    static member Empty = {
        subjects = [||]
        verbs = [||]
        objects = [||]
        predicateObjectLists = [||]
        triples = HashSet.empty
        pathPatterns = [||]
    }

    static member fromIGraph(igraph: IGraph) = {
        Formula.Empty with
            triples = igraph.Triples |> PSeq.map RdfTriple.fromVDSTriple |> HashSet.ofSeq
    }

    static member fromGraphLiteralNode(graphLiteralNode: GraphLiteralNode) =
        Formula.fromIGraph graphLiteralNode.SubGraph

    member this.lexicalForm = this.triples |> Seq.map _.lexicalForm |> String.concat "\n"

    member this.IRdfTriplePatterns(patternBuilder: TriplePatternBuilder) : ITriplePattern array =
        this.triples
        |> Seq.map (fun rdfTriple -> rdfTriple.asITriplePattern patternBuilder)
        |> Seq.toArray

    member this.ITriplePatterns(patternBuilder: TriplePatternBuilder) : ITriplePattern array =
        Array.append
            (this.IRdfTriplePatterns patternBuilder)
            (this.pathPatterns
             |> Array.map (fun pathPattern -> pathPattern.asITriplePattern patternBuilder))

    static member fromRdfSubject rdfSubject = {
        Formula.Empty with
            subjects = [| rdfSubject |]
    }

    static member fromRdfSubjects rdfSubjects = {
        Formula.Empty with
            subjects = rdfSubjects |> List.toArray
    }

    static member fromRdfPredicate rdfPredicate = {
        Formula.Empty with
            verbs = [| PredicateVerb rdfPredicate |]
    }

    static member fromRdfPredicates rdfPredicates = {
        Formula.Empty with
            verbs = rdfPredicates |> Array.map PredicateVerb
    }

    static member fromGraphVerb graphVerb = {
        Formula.Empty with
            verbs = [| graphVerb |]
    }

    static member fromGraphVerbs graphVerbs = {
        Formula.Empty with
            verbs = graphVerbs
    }

    static member fromRdfObject rdfObject = {
        Formula.Empty with
            objects = [| rdfObject |]
    }

    static member fromRdfObjects rdfObjects = {
        Formula.Empty with
            objects = rdfObjects
    }

    member this.materializePatterns =

        let rdfPredicates =
            this.verbs
            |> Array.choose (function
                | PredicateVerb predicate -> Some predicate
                | PathVerb _ -> None)

        let graphPaths =
            this.verbs
            |> Array.choose (function
                | PredicateVerb _ -> None
                | PathVerb path -> Some path)

        {
            subjects = [||]
            verbs = [||]
            objects = [||]
            predicateObjectLists = [||]

            triples =
                Seq.concat [
                    this.triples

                    RdfTriple.setFromTerms this.subjects rdfPredicates this.objects

                    RdfTriple.setFromSubjectsPredicateObjectLists this.subjects this.predicateObjectLists
                ]
                |> HashSet.ofSeq

            pathPatterns = Array.append this.pathPatterns (GraphPathPattern.setFromTerms this.subjects graphPaths this.objects)
        }

    static member materializeFormula(formula: Formula) = formula.materializePatterns

    member this.addGraphVerbs graphVerbs = {
        this with
            verbs = this.verbs |> Array.append graphVerbs
    }

    member this.addGraphVerb graphVerb = this.addGraphVerbs [| graphVerb |]

    member this.addRdfPredicates rdfPredicates =
        rdfPredicates |> Array.map PredicateVerb |> this.addGraphVerbs

    member this.addRdfPredicate rdfPredicate =
        PredicateVerb rdfPredicate |> this.addGraphVerb

    member this.addFormulas(formulas: Formula list) = {
        this with
            triples =
                Seq.concat [
                    this.triples

                    formulas |> Seq.collect (fun formula -> formula.triples) |> HashSet.ofSeq
                ]
                |> HashSet.ofSeq

            pathPatterns =
                Seq.concat [
                    this.pathPatterns

                    formulas |> Seq.collect (fun formula -> formula.pathPatterns) |> Seq.toArray
                ]
                |> Seq.toArray
    }

    member this.addRdfSubjects rdfSubjects = {
        this with
            subjects = this.subjects |> Array.append rdfSubjects
    }

    member this.addRdfSubject rdfSubject = this.addRdfSubjects [| rdfSubject |]

    member this.addPredicateObjectLists predicateObjectLists = {
        this with
            predicateObjectLists = this.predicateObjectLists |> Array.append predicateObjectLists
    }

    member this.addRdfObjects rdfObjects = {
        this with
            objects = this.objects |> Array.append rdfObjects
    }

    member this.addRdfObject rdfObject = this.addRdfObjects [| rdfObject |]

    member this.addRdfLiteral rdfLiteral =
        LiteralValue.autotyped rdfLiteral
        |> RdfObject.LiteralObject
        |> this.addRdfObject

    member this.addRdfLiterals rdfLiterals =
        rdfLiterals
        |> List.toArray
        |> Array.Parallel.map (fun literal -> literal |> LiteralValue.autotyped |> RdfObject.LiteralObject)
        |> this.addRdfObjects
and PredicateObjectList = {

    verb: RdfPredicate
    objectLists: ObjectList array

} with

    static member inline fromTerms (predicate: RdfPredicate) (objects: RdfObject array) = {
        verb = predicate
        objectLists =
            objects
            |> Array.map (fun rdfObject -> {
                rdfObject = rdfObject
                annotations = [||]
            })
    }

and ObjectList = {
    rdfObject: RdfObject
    annotations: Annotation array
}

and Annotation =
    | AnnotationReifier of RdfSubject
    | AnnotationBlock of PredicateObjectList
and GraphPath =
    | PredicatePath of NamedReference
    | InversePath of GraphPath
    | SequencePath of GraphPath * GraphPath
    | AlternativePath of GraphPath * GraphPath
    | ZeroOrMorePath of GraphPath
    | OneOrMorePath of GraphPath
    | ZeroOrOnePath of GraphPath

    member this.asGraphVerb = PathVerb this
    member this.asPath = this

    member this.inverse = GraphPath.InversePath this

    member this.zeroOrMore = GraphPath.ZeroOrMorePath this

    member this.oneOrMore = GraphPath.OneOrMorePath this

    member this.zeroOrOne = GraphPath.ZeroOrOnePath this

    member this.asSparqlPath: ISparqlPath =
        match this with
        | PredicatePath predicate -> VDS.RDF.Query.Paths.Property(predicate.asINode) :> ISparqlPath

        | InversePath path -> VDS.RDF.Query.Paths.InversePath(path.asSparqlPath) :> ISparqlPath

        | SequencePath(left, right) -> VDS.RDF.Query.Paths.SequencePath(left.asSparqlPath, right.asSparqlPath) :> ISparqlPath

        | AlternativePath(left, right) -> VDS.RDF.Query.Paths.AlternativePath(left.asSparqlPath, right.asSparqlPath) :> ISparqlPath

        | ZeroOrMorePath path -> VDS.RDF.Query.Paths.ZeroOrMore(path.asSparqlPath) :> ISparqlPath

        | OneOrMorePath path -> VDS.RDF.Query.Paths.OneOrMore(path.asSparqlPath) :> ISparqlPath

        | ZeroOrOnePath path -> VDS.RDF.Query.Paths.ZeroOrOne(path.asSparqlPath) :> ISparqlPath

and GraphPathPattern = {
    subject: RdfSubject
    path: GraphPath
    object: RdfObject
} with

    static member setFromTerms (subjects: RdfSubject array) (paths: GraphPath array) (objects: RdfObject array) =
        objects
        |> Array.collect (fun rdfObject ->
            paths
            |> Array.collect (fun path ->
                subjects
                |> Array.map (fun rdfSubject -> {
                    subject = rdfSubject
                    path = path
                    object = rdfObject
                })))
    member this.asITriplePattern(patternBuilder: TriplePatternBuilder) : ITriplePattern =
        VDS.RDF.Query.Patterns.PropertyPathPattern(this.subject.asPatternItem patternBuilder, this.path.asSparqlPath, this.object.asPatternItem patternBuilder)
        :> ITriplePattern

and SparqlGraphPattern =
    | BasicGraphPattern of Formula
    | PropertyPathGraphPattern of GraphPathPattern
    | GroupGraphPattern of SparqlGraphPattern array
    | OptionalGraphPattern of SparqlGraphPattern
    | UnionGraphPattern of SparqlGraphPattern array
    | MinusGraphPattern of SparqlGraphPattern
    | NamedGraphPattern of SparqlGraphSelector * SparqlGraphPattern
    | ServiceGraphPattern of NamedReference * SparqlGraphPattern
    | FilterGraphPattern of ISparqlExpression
    | BindGraphPattern of VariableReference * ISparqlExpression

and SparqlGraphSelector =
    | GraphIri of NamedReference
    | GraphVariable of VariableReference
and GraphVerb =
    | PredicateVerb of RdfPredicate
    | PathVerb of GraphPath
type String with
    member this.rdfString = SimpleString this
    member this.datatyped(datatypeIri: NamedReference) =
        DatatypedString(this.rdfString, datatypeIri) |> DatatypedLiteral
    member this.languageTagged(languageTag: LanguageTag) =
        LanguageString(this.rdfString, languageTag)
    member this.languageTagged(language: Language) =
        LanguageString(this.rdfString, new LanguageTag(language))
    member this.enTagged = this.languageTagged Language.EN
    member this.USTagged = new LanguageTag(Language.EN, Region.US) |> this.languageTagged

module GraphPathPattern =

    let inline create (subject: ^Subject when ^Subject: (member asSubject: RdfSubject)) (path: GraphPath) (object: ^Object when ^Object: (member asObject: RdfObject)) = {
        subject = subject.asSubject
        path = path
        object = object.asObject
    }

// ============================================================================
// Result access
// ============================================================================
type SparqlResultSet with

    member this.columnByVariables(rdfVariable: VariableReference) =
        this.Results
        |> Seq.map (fun result -> result.Item rdfVariable.identifier |> DataPoint.fromINode)
        |> Seq.toArray

module SparqlResultSet =

    let variableIndex (rdfVariable: VariableReference) (index: int) (resultSet: SparqlResultSet) =
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

    let graph (graphIri: NamedReference) (pattern: SparqlGraphPattern) =
        NamedGraphPattern(GraphIri graphIri, pattern)

    let graphVariable (graphVariable: VariableReference) (pattern: SparqlGraphPattern) =
        NamedGraphPattern(GraphVariable graphVariable, pattern)

    let service (endpoint: NamedReference) (pattern: SparqlGraphPattern) = ServiceGraphPattern(endpoint, pattern)

    let filter (expression: ISparqlExpression) = FilterGraphPattern expression

    let bind (rdfVariable: VariableReference) (expression: ISparqlExpression) =
        BindGraphPattern(rdfVariable, expression)

    let inline path
        (subject: ^SubjectType when ^SubjectType: (member asSubject: RdfSubject))
        (path: GraphPath)
        (objectTerm: ^ObjectType when ^ObjectType: (member asObject: RdfObject))
        =
        PropertyPathGraphPattern {
            subject = subject.asSubject
            path = path
            object = objectTerm.asObject
        }
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
    | From of NamedReference
    | FromNamed of NamedReference

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

let private SELECT (variables: VariableReference seq) : ISelectBuilder =

    variables
    |> Seq.map (fun variable -> variable.identifier)
    |> Seq.toArray
    |> QueryBuilder.Select

let private ASK () : IQueryBuilder = QueryBuilder.Ask()

let private DISCOVER (variables: VariableReference seq) : IDescribeBuilder =

    variables
    |> Seq.map (fun variable -> variable.questionForm)
    |> Seq.toArray
    |> QueryBuilder.Describe

let private DESCRIBE (iris: NamedReference seq) : SparqlQuery =

    iris
    |> Seq.map (fun iri -> iri.uri)
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

    queryBuilder.Prefixes.Import ggg.defaultGraph.NamespaceMap

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

        builder.Graph(graphIri.uri, action pattern) |> ignore

    | NamedGraphPattern(GraphVariable graphVariable, pattern) ->

        builder.Graph(graphVariable.questionForm, action pattern) |> ignore

    | ServiceGraphPattern(endpoint, pattern) ->

        builder.Service(endpoint.uri, action pattern) |> ignore

    | FilterGraphPattern expression ->

        builder.Filter(expression) |> ignore

    | BindGraphPattern(rdfVariable, expression) ->

        builder.Where(BindPattern(rdfVariable.identifier, expression) :> ITriplePattern)
        |> ignore
    | PropertyPathGraphPattern pathPattern ->

        builder.Where([| pathPattern.asITriplePattern patternBuilder |]) |> ignore
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

            sparqlQuery.AddDefaultGraph(graphIri.uriNode :> IRefNode)

        | FromNamed graphIri ->

            sparqlQuery.AddNamedGraph(graphIri.uriNode :> IRefNode))

    sparqlQuery

// ============================================================================
// Typed query compilers
// ============================================================================

let private buildSelectQuery (variables: VariableReference array option) (datasetClauses: SparqlDatasetClause array) (wherePattern: SparqlGraphPattern) : SelectQuery =

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

    if constructFormula.pathPatterns.Length > 0 then
        invalidArg (nameof constructFormula) "A SPARQL CONSTRUCT template cannot contain property paths."

    let queryBuilder =
        QueryBuilder.Construct(
            Action<IDescribeGraphPatternBuilder>(fun constructTemplate ->

                let templatePatternBuilder = TriplePatternBuilder(ggg.defaultGraph.NamespaceMap)

                constructTemplate.Where(constructFormula.IRdfTriplePatterns templatePatternBuilder)
                |> ignore)
        )
    let query =

        queryBuilder
        |> importQueryPrefixes
        |> fun builder -> applyWherePattern builder wherePattern
        |> fun builder -> builder.BuildQuery()
        |> applyDatasetClauses datasetClauses

    { graphQuery = query }

let private buildDiscoverQuery (variables: VariableReference array) (datasetClauses: SparqlDatasetClause array) (wherePattern: SparqlGraphPattern) : GraphQuery =

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

let private buildDescribeQuery (iris: NamedReference array) : GraphQuery =

    let query =

        iris |> DESCRIBE

    query.NamespaceMap.Import ggg.defaultGraph.NamespaceMap

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
    member _.From(draft: SparqlQueryDraft, graphIri: NamedReference) : SparqlQueryDraft =

        {
            draft with

                datasetClauses = From graphIri :: draft.datasetClauses
        }

    [<CustomOperation("fromNamed")>]
    member _.FromNamed(draft: SparqlQueryDraft, graphIri: NamedReference) : SparqlQueryDraft =

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

    let select (variables: VariableReference seq) : WhereQueryBuilder<SelectQuery> =

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

    let discover (variables: VariableReference seq) : WhereQueryBuilder<GraphQuery> =

        let variables = variables |> Seq.toArray

        WhereQueryBuilder<GraphQuery>(fun draft wherePattern ->

            buildDiscoverQuery variables (draft.datasetClauses |> List.toArray) wherePattern)

    // DESCRIBE of concrete IRIs does not require a WHERE clause and therefore
    // remains a direct function rather than a WhereQueryBuilder.

    let describe (iris: NamedReference seq) : GraphQuery =

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
    defaultGraphs: NamedReference array

    namedGraphs: NamedReference array
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

    static member fromIri(httpClient: HttpClient, endpointIri: NamedReference) =

        SparqlRemoteEndpoint.fromUri (httpClient, endpointIri.uri)

    static member fromUrl(httpClient: HttpClient, endpointUrl: DomUrl) =

        SparqlRemoteEndpoint.fromUri (httpClient, Uri endpointUrl.Href)

    member this.withDefaultGraph(graphIri: NamedReference) =

        {
            this with

                protocolDataset = {
                    this.protocolDataset with

                        defaultGraphs = Array.append this.protocolDataset.defaultGraphs [| graphIri |]
                }
        }

    member this.withNamedGraph(graphIri: NamedReference) =

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

type NamespaceName(namespaceIri: NamedReference, namespaceDistributions: IriReference array) =
    let _threadSafeGraph = new ThreadSafeGraph(namespaceIri.irefnode)
    let _ontologyGraph = new OntologyGraph(namespaceIri.irefnode)
    let _uriTemplate = UriTemplate(namespaceIri.lexicalForm + "{localName}")

    let _distributions = namespaceDistributions

    let _reverseHostPath = namespaceIri.uri.Host.Split('.') |> Array.rev |> String.concat "\\"

    let _localDelimiter = namespaceIri.lexicalForm.ToCharArray() |> Array.last |> string

    let _terminalName =
        match _localDelimiter with
        | "/" -> '/'.tryHtmlEntity.Value
        | "#" -> '#'.tryHtmlEntity.Value
        | _ -> String.Empty

    let _localDocumentPath =
        AbsoluteDirectoryPath.Create(
            DriveInfo.preferredDrive.Name
            + namespaceIri.uri.Scheme
            + "\\"
            + _reverseHostPath
            + namespaceIri.uri.LocalPath.Replace("/", "\\").TrimEnd('\\')
            + _terminalName
        )

    let _localTurtlePath = _localDocumentPath / IanaMimeByName["text/turtle"].asRelativeFilePath

    let _localRdfXmlPath = _localDocumentPath / IanaMimeByName["application/rdf+xml"].asRelativeFilePath

    let _localNtriplesPath = _localDocumentPath / IanaMimeByName["application/n-triples"].asRelativeFilePath

    let _localNQuadsPath = _localDocumentPath / IanaMimeByName["application/n-quads"].asRelativeFilePath

    let _localTrigPath = _localDocumentPath / IanaMimeByName["application/trig"].asRelativeFilePath

    let _localJsonLdPath = _localDocumentPath / IanaMimeByName["application/ld+json"].asRelativeFilePath

    let _fileUri = Uri _localTurtlePath.WeakString
    let _gggLoader =
        if _localTurtlePath.Exists then
            task {

                do! ggg.loader.LoadGraphAsync(_threadSafeGraph, _fileUri)
                do! ggg.loader.LoadGraphAsync(_ontologyGraph, _fileUri)

            }
        else
            task {
                // TODO handle dataset distributions
                match _distributions with
                | [| graphDistribution |] -> do! ggg.loader.LoadGraphAsync(_threadSafeGraph, _distributions[0].uri)
                | [||] -> do! ggg.loader.LoadGraphAsync(_threadSafeGraph, namespaceIri.uri)
                | _ ->
                    for distribution in _distributions do
                        do! ggg.loader.LoadGraphAsync(_threadSafeGraph, distribution)

                if not _threadSafeGraph.IsEmpty then
                    _threadSafeGraph.SaveToTurtle _localTurtlePath.WeakString
            }
    let _rdfGraphLoader =
        if _localTurtlePath.Exists then
            task { return! RDFGraph.FromFileAsync(RDFModelEnums.RDFFormats.Turtle, _localTurtlePath.WeakString) }
        else
            task {
                let sourceUris =
                    match _distributions with
                    | [||] -> [| namespaceIri.uri |]
                    | distributions -> distributions |> Array.map _.uri

                let! rdfGraphs = sourceUris |> Array.map RDFGraph.FromUriAsync |> Task.WhenAll

                let rdfGraph =
                    rdfGraphs
                    |> Array.reduce (fun graph otherGraph -> graph.UnionWith(otherGraph))
                    |> _.SetContext(namespaceIri.uri)

                if rdfGraph.TriplesCount > 0L then
                    do! rdfGraph.ToFileAsync(RDFModelEnums.RDFFormats.Turtle, _localTurtlePath.WeakString)

                return rdfGraph
            }
    let _dataPoints =
        lazy
            (_gggLoader.await
             _threadSafeGraph.AllNodes |> Seq.toArray |> Array.map DataPoint.fromINode)
    let _iris =
        lazy
            (_dataPoints.Force()
             |> Array.choose (fun dataPoint ->
                 match dataPoint with
                 | RdfIri iri -> Some iri
                 | _ -> None))
    let _prefixedNames =
        lazy
            (_iris.Force()
             |> Array.choose (fun iri ->
                 if namespaceIri.url.NamespacePattern.IsMatch iri.uri then
                     Some iri
                 else
                     None))
    let _literals =
        lazy
            (_dataPoints.Force()
             |> Array.choose (fun dataPoint ->
                 match dataPoint with
                 | RdfLiteral literal -> Some literal
                 | _ -> None))
    let _stringLiterals =
        lazy
            (_literals.Force()
             |> Array.choose (fun literal ->
                 match literal with
                 | SimpleLiteral literal -> Some literal
                 | _ -> None))
    let _datatypedLiterals =
        lazy
            (_literals.Force()
             |> Array.choose (fun literal ->
                 match literal with
                 | DatatypedLiteral literal -> Some literal
                 | _ -> None))
    let _langStrings =
        lazy
            (_literals.Force()
             |> Array.choose (fun literal ->
                 match literal with
                 | LanguageLiteral literal -> Some literal
                 | _ -> None))
    let _dirLangStrings =
        lazy
            (_literals.Force()
             |> Array.choose (fun literal ->
                 match literal with
                 | DirectedLanguageLiteral literal -> Some literal
                 | _ -> None))
    let _variables =
        lazy
            (_dataPoints.Force()
             |> Array.choose (fun dataPoint ->
                 match dataPoint with
                 | RdfVariable variable -> Some variable
                 | _ -> None))
    let _tripleTerms =
        lazy
            (_dataPoints.Force()
             |> Array.choose (fun dataPoint ->
                 match dataPoint with
                 | RdfTripleTerm variable -> Some variable
                 | _ -> None))
    let _graphLiterals =
        lazy
            (_dataPoints.Force()
             |> Array.choose (fun dataPoint ->
                 match dataPoint with
                 | RdfFormula graphLiteral -> Some graphLiteral
                 | _ -> None))

    let _OntologyClasses = lazy (_ontologyGraph.AllClasses |> Seq.toArray)
    let _OntologyProperties = lazy (_ontologyGraph.AllProperties |> Seq.toArray)
    let _RdfClasses = lazy (_ontologyGraph.RdfClasses |> Seq.toArray)
    let _RdfProperties = lazy (_ontologyGraph.RdfProperties |> Seq.toArray)
    let _OwlClasses = lazy (_ontologyGraph.OwlClasses |> Seq.toArray)
    let _OwlProperties = lazy (_ontologyGraph.OwlProperties |> Seq.toArray)
    let _OwlDatatypeProperties = lazy (_ontologyGraph.OwlDatatypeProperties |> Seq.toArray)
    let _OwlObjectProperties = lazy (_ontologyGraph.OwlObjectProperties |> Seq.toArray)
    let _OwlAnnotationProperties = lazy (_ontologyGraph.OwlAnnotationProperties |> Seq.toArray)
    let _AllOntologyResources =
        lazy
            (Array.concat [|
                _OntologyClasses.Force()
                |> Array.map (fun ontologyClass -> ontologyClass :> OntologyResource)
                _OntologyProperties.Force()
                |> Array.map (fun ontologyProperty -> ontologyProperty :> OntologyResource)
            |])
    new(namespaceIri: NamedReference) =
        let maybeGraphDistribution =
            graphDistributions
            |> Array.tryPick (fun (namespaceString, distributionString) ->
                if namespaceString = namespaceIri.lexicalForm then
                    Some(IriReference distributionString)
                else
                    None)
        let maybeDatasetDistribution =
            datasetDistributions
            |> Array.collect (fun (namespaceString, distributionStrings) ->
                if namespaceString = namespaceIri.lexicalForm then
                    distributionStrings
                    |> Array.map (fun distributionString -> IriReference distributionString)
                else
                    [||])

        match maybeGraphDistribution, maybeDatasetDistribution with
        | Some distribution, [||] -> NamespaceName(namespaceIri, [| distribution |])
        | None, distributions when distributions.Length > 0 -> NamespaceName(namespaceIri, distributions)
        | _, _ -> NamespaceName(namespaceIri, [||])
    member this.iri = namespaceIri
    member this.iriref = namespaceIri.iriref
    member this.uri = namespaceIri.uri
    member this.url = namespaceIri.url
    member this.remoteReference = namespaceIri.lexicalForm
    member this.localReference = _localTurtlePath.WeakString
    member this.fileUri = Uri _localTurtlePath.WeakString
    member this.graphName = namespaceIri.irefnode

    member this.threadSafeGraph =
        _gggLoader.await
        _threadSafeGraph
    member this.ontologyGraph =
        _gggLoader.await
        _ontologyGraph
    member this.rdfGraph = (_rdfGraphLoader.await).SetContext(namespaceIri.uri)

    member this.template = _uriTemplate
    member this.distributions = _distributions
    member this.reverseHostPath = _reverseHostPath
    member this.localDelimiter = _localDelimiter
    member this.terminalName = _terminalName
    member this.localDocumentPath = _localDocumentPath
    member this.localTurtlePath = _localTurtlePath
    member this.localRdfXmlPath = _localRdfXmlPath
    member this.localNtriplesPath = _localNtriplesPath
    member this.localNQuadsPath = _localNQuadsPath
    member this.localTrigPath = _localTrigPath
    member this.localJsonLdPath = _localJsonLdPath

    member this.localRepresentationPath(mime: MimeType) =
        this.localDocumentPath / mime.asRelativeFilePath

    member this.prefixedName(localName: string) =
        _uriTemplate.AddParameter("localName", localName).asIriReference
        |> NamedReference
    member this.tryPrefixFromNamespaceMap =
        try
            _threadSafeGraph.NamespaceMap.GetPrefix(namespaceIri.uri)
            |> Option.ofNullOrWhiteSpace
        with _ ->
            None
    member this.tryRDFNamespaceFromRegister =
        try
            RDFNamespaceRegister.GetByUri(namespaceIri.lexicalForm, false)
            |> Option.ofNullOrWhiteSpace

        with _ ->
            None
    member this.tryRDFNamespaceFromPrefixcc =
        try
            RDFNamespaceRegister.GetByUri(namespaceIri.lexicalForm, true)
            |> Option.ofNullOrWhiteSpace

        with _ ->
            None
    member this.clipLocalDirectory() = _localDocumentPath.WeakString.clip
    member this.SparqlLocalDataset = SparqlLocalDataset.fromGraph this.threadSafeGraph
    member this.dataTable = this.rdfGraph.ToDataTable()
    member this.dataPoints = _dataPoints.Force()
    member this.iris = _iris.Force()
    member this.prefixedNames = _prefixedNames.Force()
    member this.literals = _literals.Force()
    member this.stringLiterals = _stringLiterals.Force()
    member this.datatypedLiterals = _datatypedLiterals.Force()
    member this.langStrings = _langStrings.Force()
    member this.dirLangStrings = _dirLangStrings.Force()
    member this.variables = _variables.Force()
    member this.tripleTerms = _tripleTerms.Force()
    member this.graphLiterals = _graphLiterals.Force()

    member inline this.tryOntologyClass<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        this.ontologyGraph.AllClasses
        |> Seq.tryFind (fun ontologyClass -> ontologyClass.Resource = term.asINode)
    member inline this.tryOntologyProperty<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        this.ontologyGraph.AllProperties
        |> Seq.tryFind (fun ontologyProperty -> ontologyProperty.Resource = term.asINode)

    member this.OntologyClasses = _OntologyClasses.Force()
    member this.OntologyProperties = _OntologyProperties.Force()
    member this.RdfClasses = _RdfClasses.Force()
    member this.RdfProperties = _RdfProperties.Force()
    member this.OwlClasses = _OwlClasses.Force()
    member this.OwlProperties = _OwlProperties.Force()
    member this.OwlDatatypeProperties = _OwlDatatypeProperties.Force()
    member this.OwlObjectProperties = _OwlObjectProperties.Force()
    member this.OwlAnnotationProperties = _OwlAnnotationProperties.Force()
    member this.AllOntologyResources = _AllOntologyResources.Force()

    member inline this.OntologyResourceByTerm<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        this.AllOntologyResources
        |> Array.tryFind (fun ontologyResource -> ontologyResource.Resource = term.asINode)

    member inline this.termComment<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.Comment
            |> Seq.map (fun iliteralNode -> iliteralNode :> INode |> RdfObject.fromINode)
            |> Seq.toArray
        | None -> [||]
    member inline this.termDifferentFrom<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.DifferentFrom
            |> Seq.map (fun inode -> DataPoint.fromINode inode)
            |> Seq.toArray
        | None -> [||]
    member inline this.termDirectSubClasses<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.DirectSubClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termDirectSubProperties<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.DirectSubProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termDirectSuperClasses<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.DirectSuperClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termDirectSuperProperties<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.DirectSuperProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termDisjointClasses<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.DisjointClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termDomains<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.Domains |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termRanges<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.Ranges |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termEquivalentClasses<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.EquivalentClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termEquivalentProperties<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.EquivalentProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIndirectSubClasses<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.IndirectSubClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIndirectSuperClasses<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.IndirectSuperClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIndirectSubProperties<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.IndirectSubProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIndirectSuperProperties<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.IndirectSuperProperty |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termInverseProperties<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.InverseProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termInstances<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.Instances |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIsBottomClass<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.IsBottomClass
            | _ -> false
        | None -> false
    member inline this.termIsBottomProperty<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.IsBottomProperty
            | _ -> false
        | None -> false
    member inline this.termIsDefinedBy<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.IsDefinedBy
            |> Seq.map (fun inode -> DataPoint.fromINode inode)
            |> Seq.toArray
        | None -> [||]
    member inline this.termIsDomainOf<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.IsDomainOf |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIsRangeOf<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.IsRangeOf |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIsTopClass<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.IsTopClass
            | _ -> false
        | None -> false
    member inline this.termIsTopProperty<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.IsTopProperty
            | _ -> false
        | None -> false
    member inline this.termLabel<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.Label
            |> Seq.map (fun iliteralNode -> iliteralNode :?> LiteralNode |> LiteralValue.fromLiteralNode)
            |> Seq.toArray
        | None -> [||]
    member inline this.termSameAs<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.SameAs
            |> Seq.map (fun inode -> DataPoint.fromINode inode)
            |> Seq.toArray
        | None -> [||]
    member inline this.termSeeAlso<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.SeeAlso
            |> Seq.map (fun inode -> DataPoint.fromINode inode)
            |> Seq.toArray
        | None -> [||]
    member inline this.termSiblingClasses<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.Siblings |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termSiblingProperties<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.Siblings |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termUsedBy<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.UsedBy |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termSubClasses<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.SubClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termSuperClasses<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.SuperClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termSubProperties<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.SubProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termSuperProperties<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.SuperProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termTriples<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.Triples
            |> Seq.map (fun vdsTriple -> RdfTriple.fromVDSTriple vdsTriple)
            |> Seq.toArray
        | None -> [||]
    member inline this.termTriplesWithObject<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.TriplesWithObject
            |> Seq.map (fun vdsTriple -> RdfTriple.fromVDSTriple vdsTriple)
            |> Seq.toArray
        | None -> [||]
    member inline this.termTriplesWithPredicate<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.TriplesWithPredicate
            |> Seq.map (fun vdsTriple -> RdfTriple.fromVDSTriple vdsTriple)
            |> Seq.toArray
        | None -> [||]
    member inline this.termTriplesWithSubject<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.TriplesWithSubject
            |> Seq.map (fun vdsTriple -> RdfTriple.fromVDSTriple vdsTriple)
            |> Seq.toArray
        | None -> [||]

    member inline this.termTriplesWithLiteralObject<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        this.termTriplesWithSubject term
        |> Array.choose (fun triple ->
            match triple.curObject with
            | LiteralObject literal -> Some literal
            | _ -> None)
    member inline this.termTriplesWithIriObject<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        this.termTriplesWithSubject term
        |> Array.choose (fun triple ->
            match triple.curObject with
            | IriObject iri -> Some iri
            | _ -> None)
    member inline this.termTriplesWithBlankObject<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        this.termTriplesWithSubject term
        |> Array.choose (fun triple ->
            match triple.curObject with
            | BlankObject blankNode -> Some blankNode
            | _ -> None)

    member inline this.termTriplesWithReferenceObject<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        Array.concat [|
            this.termTriplesWithIriObject term |> Array.map RdfIri
            this.termTriplesWithBlankObject term |> Array.map RdfBlankNode
        |]
    member inline this.termTypes<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.Types
            |> Seq.map (fun inode -> DataPoint.fromINode inode)
            |> Seq.toArray
        | None -> [||]
    member inline this.termVersionInfo<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.VersionInfo
            |> Seq.map (fun iliteralNode -> iliteralNode :?> LiteralNode |> LiteralValue.fromLiteralNode)
            |> Seq.toArray
        | None -> [||]

    member inline this.ontologyClassesByMetaClass<'Term when 'Term: (member asINode: INode)>(metaClass: 'Term) =
        this.ontologyGraph.GetClasses metaClass.asINode |> Seq.toArray

    member this.termByName =
        this.prefixedNames
        |> Array.map (fun prefixedName -> prefixedName.lexicalForm[namespaceIri.lexicalForm.Length ..], prefixedName)
        |> Map.ofArray
    member this.moduleBinder =
        match this.tryPrefixFromNamespaceMap with
        | Some prefix -> PrettierNaming.ModuleBinder prefix
        | None ->
            match this.tryRDFNamespaceFromRegister with
            | Some rdfNamespace -> PrettierNaming.ModuleBinder rdfNamespace.NamespacePrefix
            | None ->
                match this.tryRDFNamespaceFromRegister with
                | Some rdfNamespace -> PrettierNaming.ModuleBinder rdfNamespace.NamespacePrefix
                | None ->
                    match this.tryRDFNamespaceFromPrefixcc with
                    | Some rdfNamespace -> PrettierNaming.ModuleBinder rdfNamespace.NamespacePrefix
                    | None ->
                        namespaceIri.lexicalForm.pathTokens
                        |> String.concat "_"
                        |> PrettierNaming.ModuleBinder
    (*
    member this.asAstModule =
        Ast.Oak() {
            Ast.AnonymousModule() {
                Ast.HashDirective("I", Ast.VerbatimString(@"D:\https\com\github\eristocrates\ipa\dll\"))
                Ast.HashDirective("r", Ast.VerbatimString("ResourceDescription.dll"))
                Ast.HashDirective("I", Ast.VerbatimString(@"D:\https\com\github\eristocrates\ipa\fsx\"))
                Ast.Open("ResourceDescription")
                Ast.HashDirective("load", Ast.VerbatimString(@".paket/load/main.group.fsx"))
                Ast.Open("System")
                Ast.Module(this.moduleBinder.binding) {
                    Ast.Value("_namespace", $"NamedReference \"{namespaceIri.lexicalForm}\" |> NamespaceName")
                    for prefixedName in this.prefixedNames do
                        // printfn "%s" namespacedName.localName
                        let localName = prefixedName.lexicalForm[namespaceIri.lexicalForm.Length ..]
                        let binding =
                            // TODO add label override
                            match localName with
                            | "" -> "_namespaceIri"
                            | _ ->
                                let binder = PrettierNaming.VariableBinder localName
                                binder.binding
                        Ast.Value(binding, $"_namespace.prefixedName \"{localName}\"")
                }
            }
        }
        |> Gen.mkOak
        |> Gen.run

*)
    member this.asAstModule =

        let localNameOf (prefixedName: NamedReference) =
            prefixedName.lexicalForm[namespaceIri.lexicalForm.Length ..]

        let bindingOfLocalName (localName: string) =
            match localName with
            | "" -> "_namespaceIri"
            | _ -> PrettierNaming.VariableBinder(localName).binding

        let bindingOf (prefixedName: NamedReference) =
            prefixedName |> localNameOf |> bindingOfLocalName

        let tryPrefixedNameByResource (resource: INode) =
            this.prefixedNames
            |> Array.tryFind (fun prefixedName -> prefixedName.asINode = resource)

        let ontologyClassesForClass (ontologyClass: OntologyClass) =
            seq {
                yield ontologyClass
                yield! ontologyClass.SuperClasses
            }
            |> Seq.distinctBy _.Resource

        let propertiesForClass (ontologyClass: OntologyClass) =
            ontologyClass
            |> ontologyClassesForClass
            |> Seq.collect _.IsDomainOf
            |> Seq.distinctBy _.Resource
            |> Seq.choose (fun ontologyProperty -> ontologyProperty.Resource |> tryPrefixedNameByResource)
            |> Seq.sortBy _.lexicalForm
            |> Seq.toArray

        let pipe (left: WidgetBuilder<SyntaxOak.Expr>) (right: WidgetBuilder<SyntaxOak.Expr>) : WidgetBuilder<SyntaxOak.Expr> = Ast.InfixAppExpr(left, "|>", right)

        let pipeLambda (parameterName: string) (body: WidgetBuilder<SyntaxOak.Expr>) (left: WidgetBuilder<SyntaxOak.Expr>) : WidgetBuilder<SyntaxOak.Expr> =
            pipe left (Ast.ParenLambdaExpr(parameterName, body))

        let addSubjectExpression (source: WidgetBuilder<SyntaxOak.Expr>) : WidgetBuilder<SyntaxOak.Expr> =
            source
            |> pipeLambda "draft" (Ast.AppExpr("draft.addRdfSubject", Ast.ConstantExpr("iri.asSubject")))

        let addPredicateExpression (predicateExpression: string) (source: WidgetBuilder<SyntaxOak.Expr>) : WidgetBuilder<SyntaxOak.Expr> =
            source
            |> pipeLambda "draft" (Ast.AppExpr("draft.addRdfPredicate", Ast.ConstantExpr(predicateExpression)))

        let addObjectExpression (objectExpression: string) (source: WidgetBuilder<SyntaxOak.Expr>) : WidgetBuilder<SyntaxOak.Expr> =
            source
            |> pipeLambda "draft" (Ast.AppExpr("draft.addRdfObject", Ast.ConstantExpr(objectExpression)))

        let materializeExpression (source: WidgetBuilder<SyntaxOak.Expr>) : WidgetBuilder<SyntaxOak.Expr> =
            pipe source (Ast.ConstantExpr("Formula.materializeFormula"))

        let instanceFormulaExpression () : WidgetBuilder<SyntaxOak.Expr> =
            Ast.AppExpr("Formula.fromRdfSubject", Ast.ConstantExpr("iri.asSubject"))
            |> addPredicateExpression "_rdfType.asPredicate"
            |> addObjectExpression "Class.asObject"
            |> materializeExpression

        let namedIndividualFormulaExpression () : WidgetBuilder<SyntaxOak.Expr> =
            instanceFormulaExpression ()
            |> addSubjectExpression
            |> addPredicateExpression "_rdfType.asPredicate"
            |> addObjectExpression "_owlNamedIndividual.asObject"
            |> materializeExpression

        let predicateFormulaExpression (property: NamedReference) : WidgetBuilder<SyntaxOak.Expr> =

            let propertyLocalName = localNameOf property

            Ast.ConstantExpr("_formula")
            |> addSubjectExpression
            |> addPredicateExpression $"(_namespace.prefixedName \"{propertyLocalName}\").asPredicate"

        Ast.Oak() {
            Ast.AnonymousModule() {

                Ast.HashDirective("I", Ast.VerbatimString(@"D:\https\com\github\eristocrates\ipa\dll\"))

                Ast.HashDirective("r", Ast.VerbatimString("ResourceDescription.dll"))
                Ast.HashDirective("r", Ast.VerbatimString("Iana.dll"))

                Ast.HashDirective("I", Ast.VerbatimString(@"D:\https\com\github\eristocrates\ipa\fsx\"))

                Ast.Open("ResourceDescription")

                Ast.HashDirective("load", Ast.VerbatimString(@".paket/load/main.group.fsx"))

                Ast.Open("System")
                Ast.Open("ResourceDescription")
                Ast.Open("Iana")

                Ast.Module(this.moduleBinder.binding) {

                    Ast.Value("_namespace", $"NamedReference \"{namespaceIri.lexicalForm}\" |> NamespaceName")

                    Ast.Value("_rdfType", "NamedReference \"http://www.w3.org/1999/02/22-rdf-syntax-ns#type\"")

                    Ast.Value("_owlNamedIndividual", "NamedReference \"http://www.w3.org/2002/07/owl#NamedIndividual\"")

                    for prefixedName in this.prefixedNames do

                        let localName = localNameOf prefixedName

                        let binding = bindingOfLocalName localName

                        match this.tryOntologyClass prefixedName with

                        | None ->

                            Ast.Value(binding, $"_namespace.prefixedName \"{localName}\"")

                        | Some ontologyClass ->

                            let properties = propertiesForClass ontologyClass

                            Ast.Module(binding) {

                                Ast.Value("Class", $"_namespace.prefixedName \"{localName}\"")

                                Ast.TypeDefn("Interface") {

                                    Ast.AbstractMember("iri", Seq.empty<string>, "NamedReference")

                                    Ast.AbstractMember("formula", Seq.empty<string>, "Formula")

                                    Ast.AbstractMember("asSubject", Seq.empty<string>, "RdfSubject")

                                    Ast.AbstractMember("asPredicate", Seq.empty<string>, "RdfPredicate")

                                    Ast.AbstractMember("asObject", Seq.empty<string>, "RdfObject")

                                    for property in properties do
                                        Ast.AbstractMember(bindingOf property, Seq.empty<string>, "Formula")
                                }

                                Ast.TypeDefn("Instance", Ast.Constructor(Ast.ParenPat(Ast.ParameterPat("iri", "NamedReference")))) {

                                    Ast.LetBindings([ Ast.Value("_formula", instanceFormulaExpression ()) ])

                                    Ast.Member("this.iri", Ast.ConstantExpr("iri"))

                                    Ast.Member("this.formula", Ast.ConstantExpr("_formula"))

                                    Ast.Member("this.asSubject", Ast.ConstantExpr("iri.asSubject"))

                                    Ast.Member("this.asPredicate", Ast.ConstantExpr("iri.asPredicate"))

                                    Ast.Member("this.asObject", Ast.ConstantExpr("iri.asObject"))

                                    for property in properties do
                                        Ast.Member($"this.{bindingOf property}", predicateFormulaExpression property)

                                    Ast.InterfaceWith("Interface") {

                                        Ast.Member("this.iri", Ast.ConstantExpr("iri"))

                                        Ast.Member("this.formula", Ast.ConstantExpr("_formula"))

                                        Ast.Member("this.asSubject", Ast.ConstantExpr("iri.asSubject"))

                                        Ast.Member("this.asPredicate", Ast.ConstantExpr("iri.asPredicate"))

                                        Ast.Member("this.asObject", Ast.ConstantExpr("iri.asObject"))

                                        for property in properties do
                                            Ast.Member($"this.{bindingOf property}", predicateFormulaExpression property)
                                    }
                                }

                                Ast.TypeDefn("NamedIndividual", Ast.Constructor(Ast.ParenPat(Ast.ParameterPat("iri", "NamedReference")))) {

                                    Ast.LetBindings([ Ast.Value("_formula", namedIndividualFormulaExpression ()) ])

                                    Ast.Member("this.iri", Ast.ConstantExpr("iri"))

                                    Ast.Member("this.formula", Ast.ConstantExpr("_formula"))

                                    Ast.Member("this.asSubject", Ast.ConstantExpr("iri.asSubject"))

                                    Ast.Member("this.asPredicate", Ast.ConstantExpr("iri.asPredicate"))

                                    Ast.Member("this.asObject", Ast.ConstantExpr("iri.asObject"))

                                    for property in properties do
                                        Ast.Member($"this.{bindingOf property}", predicateFormulaExpression property)

                                    Ast.InterfaceWith("Interface") {

                                        Ast.Member("this.iri", Ast.ConstantExpr("iri"))

                                        Ast.Member("this.formula", Ast.ConstantExpr("_formula"))

                                        Ast.Member("this.asSubject", Ast.ConstantExpr("iri.asSubject"))

                                        Ast.Member("this.asPredicate", Ast.ConstantExpr("iri.asPredicate"))

                                        Ast.Member("this.asObject", Ast.ConstantExpr("iri.asObject"))

                                        for property in properties do
                                            Ast.Member($"this.{bindingOf property}", predicateFormulaExpression property)
                                    }
                                }
                            }
                }
            }
        }
        |> Gen.mkOak
        |> Gen.run
    member this.modulePath = Path.Combine(__SOURCE_DIRECTORY__, "Namespaces", "Generated", $"{this.moduleBinder.binding}Namespace.fsx")
    member this.codegenAstModule() =
        Directory.CreateDirectory(Path.GetDirectoryName this.modulePath) |> ignore
        File.WriteAllText(this.modulePath, this.asAstModule)

// variable instantiation
let (!?) (identifier: string) = VariableReference identifier

// lexical adders

let (.*@) (lexicalForm: string) (languageTag: NLanguageTag.LanguageTag) = lexicalForm.languageTagged languageTag

let (.*^) (lexicalForm: string) (datatypeIri: NamedReference) = lexicalForm.datatyped datatypeIri

// unary starters
let inline (!>) (subjectTerm: ^SubjectType when ^SubjectType: (member asSubject: RdfSubject)) : Formula =
    Formula.fromRdfSubject subjectTerm.asSubject

let inline (!|) (subjectTerms: ^SubjectType list when ^SubjectType: (member asSubject: RdfSubject)) : Formula =
    subjectTerms
    |> List.map (fun subjectTerm -> subjectTerm.asSubject)
    |> Formula.fromRdfSubjects

let inline (!-) (verbTerm: ^VerbType when ^VerbType: (member asGraphVerb: GraphVerb)) : Formula =
    Formula.fromGraphVerb verbTerm.asGraphVerb
let inline (!<) (objectTerm: ^ObjectType when ^ObjectType: (member asObject: RdfObject)) : Formula =
    Formula.fromRdfObject objectTerm.asObject

let inline (!<=) valueObject =
    LiteralValue.autotyped valueObject
    |> RdfObject.LiteralObject
    |> Formula.fromRdfObject

// subject adders
let inline (-!>) (draft: Formula) (subjectTerm: ^SubjectType when ^SubjectType: (member asSubject: RdfSubject)) =
    draft.addRdfSubject subjectTerm.asSubject

let inline (-!|) (draft: Formula) (subjectTerms: ^SubjectType list when ^SubjectType: (member asSubject: RdfSubject)) =
    subjectTerms
    |> List.map (fun subjectTerm -> subjectTerm.asSubject)
    |> List.toArray
    |> draft.addRdfSubjects

// predicate adders
let inline (---) (draft: Formula) (verbTerm: ^VerbType when ^VerbType: (member asGraphVerb: GraphVerb)) = draft.addGraphVerb verbTerm.asGraphVerb

let inline (--|) (draft: Formula) (verbTerms: ^VerbType list when ^VerbType: (member asGraphVerb: GraphVerb)) =
    verbTerms
    |> List.toArray
    |> Array.map (fun verbTerm -> verbTerm.asGraphVerb)
    |> draft.addGraphVerbs
// predicateObjectList adders
let inline (-~|) (draft: Formula) (predicateObjectLists: PredicateObjectList list) =
    predicateObjectLists |> List.toArray |> draft.addPredicateObjectLists

let inline (-~|>) (draft: Formula) (predicateObjectLists: PredicateObjectList list) =
    predicateObjectLists
    |> List.toArray
    |> draft.addPredicateObjectLists
    |> Formula.materializeFormula

let inline (->-) (predicate: ^PredicateType when ^PredicateType: (member asPredicate: RdfPredicate)) (object: ^ObjectType when ^ObjectType: (member asObject: RdfObject)) =
    PredicateObjectList.fromTerms predicate.asPredicate [| object.asObject |]

let inline (->|)
    (predicate: ^PredicateType when ^PredicateType: (member asPredicate: RdfPredicate))
    (objectTerms: ^ObjectType list when ^ObjectType: (member asObject: RdfObject))
    =
    let objects =
        objectTerms
        |> List.toArray
        |> Array.Parallel.map (fun objectTerm -> objectTerm.asObject)

    PredicateObjectList.fromTerms predicate.asPredicate objects

let inline (->=) (predicate: ^PredicateType when ^PredicateType: (member asPredicate: RdfPredicate)) valueObject =
    PredicateObjectList.fromTerms predicate.asPredicate [| LiteralValue.autotyped valueObject |> RdfObject.LiteralObject |]

let inline (->=|) (predicate: ^PredicateType when ^PredicateType: (member asPredicate: RdfPredicate)) valueObjects =
    let objects =
        valueObjects
        |> List.map (fun valueObject -> LiteralValue.autotyped valueObject |> RdfObject.LiteralObject)
        |> List.toArray

    PredicateObjectList.fromTerms predicate.asPredicate objects

let inline (-->) (draft: Formula) (objectTerm: ^ObjectType when ^ObjectType: (member asObject: RdfObject)) =
    draft.addRdfObject objectTerm.asObject |> Formula.materializeFormula

let inline (-<-) (draft: Formula) (subjectTerm: ^SubjectType when ^SubjectType: (member asSubject: RdfSubject)) =
    draft.addRdfSubject subjectTerm.asSubject |> Formula.materializeFormula

let inline (-<-/) (draft: Formula) (subjectTerm: ^SubjectType when ^SubjectType: (member asSubject: RdfSubject)) =
    let materializedDraft = draft.addRdfSubject subjectTerm.asSubject |> Formula.materializeFormula

    {
        materializedDraft with

            subjects = [| subjectTerm.asSubject |]

    }

let inline (-->/) (draft: Formula) (objectTerm: ^ObjectType when ^ObjectType: (member asObject: RdfObject)) =
    let materializedDraft = draft.addRdfObject objectTerm.asObject |> Formula.materializeFormula

    {
        materializedDraft with

            subjects =
                match objectTerm.asObject.trySubject with
                | Some subject -> [| subject |]
                | None -> [||]

    }

let inline (-->=) (draft: Formula) literal =
    draft.addRdfLiteral literal |> Formula.materializeFormula

let inline (-->^) (draft: Formula) (lexicalForm: string) (datatype: NamedReference) =
    draft.addRdfLiteral (lexicalForm .*^ datatype) |> Formula.materializeFormula

let inline (-->@) (draft: Formula) (lexicalForm: string) (languageTag: NLanguageTag.LanguageTag) =
    lexicalForm .*@ languageTag |> draft.addRdfLiteral |> Formula.materializeFormula

let inline (-->=|) (draft: Formula) literals =
    draft.addRdfLiterals literals |> Formula.materializeFormula

let inline (-->^|) (draft: Formula) (lexicalForms: string list) (datatype: NamedReference) =
    lexicalForms
    |> List.map (fun lexicalForm -> lexicalForm .*^ datatype)
    |> draft.addRdfLiterals
    |> Formula.materializeFormula

let inline (-->@|) (draft: Formula) (lexicalForms: string list) (languageTag: NLanguageTag.LanguageTag) =
    lexicalForms
    |> List.map (fun lexicalForm -> lexicalForm .*@ languageTag)
    |> draft.addRdfLiterals
    |> Formula.materializeFormula

/// predicate object+
let inline (-->|) (draft: Formula) (objectTerms: ^ObjectType list when ^ObjectType: (member asObject: RdfObject)) =
    objectTerms
    |> List.toArray
    |> Array.Parallel.map (fun objectTerm -> objectTerm.asObject)
    |> draft.addRdfObjects
    |> Formula.materializeFormula

/// formula adders

let inline (-*|) (draft: Formula) (formulaList: Formula list) =
    formulaList |> draft.addFormulas |> Formula.materializeFormula

let inline (-*/) (draft: Formula) (formula: Formula) = [ draft ] |> formula.addFormulas

/// graph paths
let inline (/>) (left: ^Left when ^Left: (member asPath: GraphPath)) (right: ^Right when ^Right: (member asPath: GraphPath)) : GraphPath =
    GraphPath.SequencePath(left.asPath, right.asPath)

type UriTemplate with
    member this.asIri = NamedReference this.asIriReference
type WhatwgSite with
    member this.iri = NamedReference this.remoteReference
    member this.asNamespaceName = NamespaceName this.iri
    member this.originGraph =
        if not (ggg.dataset.HasGraph this.iri.irefnode) then
            ggg.dataset.AddGraph(new ThreadSafeGraph(this.iri.irefnode)) |> ignore
        ggg.dataset[this.iri.irefnode] :?> ThreadSafeGraph

type IriReference with
    member this.NamespaceOrigin = this.url.Origin |> NamedReference |> NamespaceName

type IGraph with

    member this.Assert(formula: Formula) =

        if formula.pathPatterns.Length > 0 then
            invalidArg (nameof formula) "A formula containing graph paths cannot be asserted directly as RDF triples."

        this.Assert(formula.triples |> Seq.map (fun triple -> triple.triple)) |> ignore
type RDFGraph with
    member this.AddFormula(formula: Formula) =
        formula.triples
        |> Seq.iter (fun triple -> this.AddTriple(triple.rdfTriple) |> ignore)

type Irn = {
    namespaceIdentifier: string
    namespaceSpecificString: string
} with

    member this.urn = Urn.Parse $"urn:{this.namespaceIdentifier}:{this.namespaceSpecificString}"
    member this.lexicalForm = this.urn.ToString()
    member this.iri = IriReference this.lexicalForm |> NamedReference
    member this.asSubject = this.iri.asSubject
    member this.asPredicate = this.iri.asPredicate
    member this.asObject = this.iri.asObject
// TODO make DataIri
type LSL.DataUri.DataUri with
    member this.lexicalForm = this.ToString()
    member this.utf8Data = Encoding.UTF8.GetString this.Data
    member this.iri = IriReference this.lexicalForm |> NamedReference
    member this.asSubject = this.iri.asSubject
    member this.asPredicate = this.iri.asPredicate
    member this.asObject = this.iri.asObject

(*
let foafNamespace = NamedReference "http://xmlns.com/foaf/0.1/" |> NamespaceName
foafNamespace.codegenAstModule()

*)

(*

foafNamespace
let rdfNamespace = NamedReference "http://www.w3.org/1999/02/22-rdf-syntax-ns#" |> NamespaceName
let xsdNamespace = NamedReference "http://www.w3.org/2001/XMLSchema#" |> NamespaceName
xsdNamespace.codegenAstModule()

xsdNamespace.distributions
xsdNamespace.localTurtlePath.Exists
xsdNamespace.tryRDFNamespaceFromRegister
graphDistributions
rdfNamespace.localTurtlePath.Exists
rdfNamespace.tryPrefixFromNamespaceMap
rdfNamespace.tryRDFNamespaceFromRegister
rdfNamespace.tryRDFNamespaceFromPrefixcc

type rdfGraphBuilder = GraphBuilder<Sample= @"D:\http\org\w3\www\1999\02\22-rdf-syntax-ns&num;\text\turtle.ttl">
rdfGraphBuilder.Class
RDFNamespaceRegister.GetByPrefix("foaf")

rdfNamespace.threadSafeGraph
rdfNamespace.ontologyGraph
rdfNamespace.threadSafeGraph.NamespaceMap.GetPrefix(RDFNamespaceRegister.DefaultNamespace.NamespaceUri)

ggg.tripleStore.AddFromUri rdfNamespace.uri
ggg.memoryManager.ListGraphNames() |> Seq.toArray
rdfNamespace.localTurtlePath.Exists

let exampleTemplate = new UriTemplate("http://example.org{/environment}{/version}/customers{?active,country}")

let examplePattern = UrlPattern.Create("http://example.org{/:environment}{/:version}/customers?active=:active&country=:country")

let templateUri = exampleTemplate.AddParameters({| version = "v2"; active = "true" |}).asUri

let templateUrl = exampleTemplate.AddParameters({| version = "v2"; active = "true" |}).asUrl
x*)
