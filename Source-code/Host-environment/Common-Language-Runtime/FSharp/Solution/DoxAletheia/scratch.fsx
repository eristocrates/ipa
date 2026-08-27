



// TODO add gnd to known ontologies https://d-nb.info/standards/elementset/gnd2012-06-30

#time on
open System
open System.Collections
open System.Globalization
open System.IO
open System.Text
open System.Xml
open System.Xml.Linq
open System.Xml.Schema
open System.Xml.Serialization
open System.Xml.XPath
#r "nuget: NLanguageTag"
open NLanguageTag

#r "nuget: Tavis.UriTemplates"
open Tavis.UriTemplates

#r "nuget: Meziantou.Framework.Language.Json"
#r "nuget: Meziantou.Framework.Uri"
open Meziantou.Framework
open Meziantou.Framework.Json
open Meziantou.Framework.Language

#r "nuget: FSharp.ViewEngine"
open FSharp.ViewEngine

#r "nuget: FolkerKinzel.MimeTypes"
open FolkerKinzel.MimeTypes

#r "nuget: dotNetRdf"
open VDS.RDF
open VDS.RDF.JsonLd
open VDS.RDF.Nodes
open VDS.RDF.Ontology
open VDS.RDF.Parsing
open VDS.RDF.Parsing.Tokens
open VDS.RDF.Query
open VDS.RDF.Query.Builder
open VDS.RDF.Query.Datasets
open VDS.RDF.Query.Inference
open VDS.RDF.Query.Patterns
open VDS.RDF.Storage
open VDS.RDF.Writing
open VDS.RDF.Writing.Formatting


#r "nuget: FSharp.Json"
open FSharp.Json

#r "nuget: RDFSharp"
open RDFSharp
open RDFSharp.Model
#r "nuget: OWLSharp"
open OWLSharp
open OWLSharp.Ontology
#r "nuget: OWLSharp.Extensions"
open OWLSharp.Extensions
#r "nuget: OBO.NET"
open OBO.NET
#r "nuget: OBO.NET.CodeGeneration"
open OBO.NET.CodeGeneration
#r "nuget: Dubzer.WhatwgUrl"
open Dubzer.WhatwgUrl

#r "nuget: IriTools"
open IriTools

#r "nuget: Iride"
open Iride
open Iride.Extensions

#r "nuget: PosInformatique.Foundations.EmailAddresses"
open PosInformatique.Foundations.EmailAddresses


#r "nuget: libphonenumber-csharp"
open PhoneNumbers

#r "nuget: PosInformatique.Foundations.EmailAddresses"
open PosInformatique.Foundations.EmailAddresses

#r "nuget: FSharp.Compiler.Service, 43.10.102"
open FSharp.Compiler

#r "nuget: FSharp.Literals, 2.2.15"
open FSharp.Literals

#r "nuget: FSharp.Data"
#r "nuget: FSharp.Data.Adaptive"
open FSharp.Data
open FSharp.Data.Adaptive.Transaction

#r "nuget: FSharp.HashCollections"
open FSharp.HashCollections

#r "nuget: FSharp.XExtensions"
open FSharp.XExtensions
#r "nuget: LitXml"
open LitXml

#r "nuget: FSharp.Collections.ParallelSeq"
open FSharp.Collections.ParallelSeq

#r "nuget: Fabulous.AST"
#r "nuget: Fantomas.FCS, 7.0.6"
open Fabulous.AST
open Fantomas.Core
open Fantomas.FCS


#r "nuget: Humanizer.Core"
open Humanizer
#r "nuget: CaseConverter"
open CaseConverter


#r "nuget: Fli"
open Fli


#r "nuget: TextCopy"
open TextCopy

#r "nuget: XParsec"
open XParsec

open Newtonsoft.Json
open Newtonsoft.Json.Linq










open FSharp.HashCollections
#r "nuget: Yog.FSharp"
open Yog.Model
open Yog.Builder
open Yog.IO
open Yog.Pathfinding.Dijkstra
open Yog.Render
open Yog.Render.Dot
open Yog.Render.Mermaid

#r "nuget: QuikGraph"
#r "nuget: QuikGraph.Serialization"
#r "nuget: QuikGraph.Graphviz"
#r "nuget: QuikGraph.Data"
#r "nuget: QuikGraph.MSAGL"
#r "nuget: QuikGraph.Petri"
open QuikGraph
open QuikGraph.Serialization
open QuikGraph.Graphviz
open QuikGraph.Data
open QuikGraph.MSAGL
open QuikGraph.Petri


#r "nuget: SafeName, 0.1.1"
open SafeName


#r "nuget: FsHttp"
open FsHttp

#r "nuget: FsPdf, 0.0.3"
open FsPdf


#r "nuget: PdfPig, 0.1.16"
open UglyToad.PdfPig
open UglyToad.PdfPig.Tokens












type PhoneNumber with 
    static member Parse(numberString:string) = PhoneNumberUtil.GetInstance().Parse(numberString, "US")

let LitXmlWriterSettings = new XmlWriterSettings()
LitXmlWriterSettings.Indent <- true
LitXmlWriterSettings.OmitXmlDeclaration <- true
LitXmlWriterSettings.NewLineOnAttributes <- false
type ElementBuilder with 
    
    static member writeToXmlDocs (elements:Element array) :string array= 

        elements
        |> Array.collect (fun element -> ElementBuilder.writeToStringWith LitXmlWriterSettings element |> _.Split("\n"))

module XmlComment = 
    let _href (reference:string) = attr "href" reference
    let a: ElementBuilder = elem "a"
    /// §D.3.2	Set text in a code-like font
    let c: ElementBuilder = elem "c"
    /// §D.3.3	Set one or more lines of source code or program output
    let code : ElementBuilder = elem "code"
    /// §D.3.4	Indicate an example
    let example : ElementBuilder = elem "example"
    /// §D.3.5	Identifies the exceptions a method can throw
    let exception_ : ElementBuilder = elem "exception"
    /// §D.3.6	Includes XML from an external file
    let include_ : ElementBuilder = elem "include"
    /// §D.3.7	Create a list or table
    let list_ : ElementBuilder = elem "list"
    /// §D.3.8	Permit structure to be added to text
    let para : ElementBuilder = elem "para"
    /// §D.3.9	Describe a parameter for a method or constructor
    let param : ElementBuilder = elem "param"
    /// §D.3.10	Identify that a word is a parameter name
    let paramref : ElementBuilder = elem "paramref"
    /// §D.3.11	Document the security accessibility of a member
    let permission : ElementBuilder = elem "permission"
    /// §D.3.12	Describe additional information about a type
    let remarks : ElementBuilder = elem "remarks"
    /// §D.3.13	Describe the return value of a method
    let returns : ElementBuilder = elem "returns"
    /// §D.3.14	Specify a link
    let see : ElementBuilder = elem "see"
    /// §D.3.15	Generate a See Also entry
    let seealso : ElementBuilder = elem "seealso"
    /// §D.3.16	Describe a type or a member of a type
    let summary : ElementBuilder = elem "summary"
    /// §D.3.17	Describe a type parameter for a generic type or method
    let typeparam : ElementBuilder = elem "typeparam"
    /// §D.3.18	Identify that a word is a type parameter name
    let typeparamref : ElementBuilder = elem "typeparamref"
    /// §D.3.19	Describe a property
    let value : ElementBuilder = elem "value"


let clipboard = new Clipboard()
let clip (text:string) = clipboard.SetText text




let wellKnownGenid = $"https://eristocrates.dev/.well-known/genid"


type Binder = 
    | TypeBinder of identifier:string
    | CaseBinder of identifier:string
    | ModuleBinder of identifier:string
    | NamespaceBinder of identifier:string
    | VariableBinder of identifier:string
    member this.identifier = 
        match this with 
        | TypeBinder identifier -> identifier
        | CaseBinder identifier -> identifier
        | ModuleBinder identifier -> identifier
        | NamespaceBinder identifier -> identifier
        | VariableBinder identifier -> identifier
    static member BackTickExclusions = 
        [|
            '.'
            '+'
            '$'
            '&'
            '['
            ']'
            '/'
            '\\'
            '*'
            '\"'
            '`'
        |]
    static member IdentKeywords = 
        set [
            "abstract"
            "and"
            "as"
            "assert"
            "base"
            "begin"
            "class"
            "const"
            "default"
            "delegate"
            "do"
            "done"
            "downcast"
            "downto"
            "elif"
            "else"
            "end"
            "exception"
            "extern"
            "false"
            "finally"
            "fixed"
            "for"
            "fun"
            "function"
            "global"
            "if"
            "in"
            "inherit"
            "inline"
            "interface"
            "internal"
            "lazy"
            "let"
            "match"
            "member"
            "module"
            "mutable"
            "namespace"
            "new"
            "null"
            "of"
            "open"
            "or"
            "override"
            "private"
            "public"
            "rec"
            "return"
            "sig"
            "static"
            "struct"
            "then"
            "to"
            "true"
            "try"
            "type"
            "upcast"
            "use"
            "val"
            "void"
            "when"
            "while"
            "with"
            "yield"
            
        ]
    static member OCamlKeywords = 
            set [

              "asr"
              "land"
              "lor"
              "lsl"
              "lsr"
              "lxor"
              "mod"
              "sig"

               ]
    static member ReservedKeywords = 
    
        set [

              "break"
              "checked"
              "component"
              "const"
              "constraint"
              "continue"
              "event"
              "external"
              "include"
              "mixin"
              "parallel"
              "process"
              "protected"
              "pure"
              "sealed"
              "tailcall"
              "trait"
              "virtual"

               ]
    static member KeywordNames = Binder.IdentKeywords + Binder.OCamlKeywords + Binder.ReservedKeywords

    member this.Contains(character:char) = this.identifier.Contains(character)
    member this.isBackTickRestricted =
        match this with 
        | TypeBinder identifier -> true
        | CaseBinder identifier -> true
        | ModuleBinder identifier -> true
        | NamespaceBinder identifier -> true
        | VariableBinder identifier -> false
    static member NormalizeIdentifier (isRestricted:bool) (identifier: string)  =
        match identifier with
        | _ when identifier.Contains(' ') ->
            Converters.ReplaceWhitespace(identifier,  "_")
            |> Binder.NormalizeIdentifier isRestricted
        | _ when identifier.Contains('-') ->
            identifier.Replace("-", "_")
            |> Binder.NormalizeIdentifier isRestricted
        | _ when not (Syntax.PrettyNaming.IsIdentifierFirstCharacter identifier[0]) ->
            "_" + identifier |> Binder.NormalizeIdentifier isRestricted
        | _ when Binder.KeywordNames.Contains(identifier) -> identifier + "_" |> Binder.NormalizeIdentifier isRestricted
        | _ when Syntax.PrettyNaming.DoesIdentifierNeedBackticks identifier && isRestricted  ->
            let backtickableIdentifier = identifier.Replace(Binder.BackTickExclusions,"")
            Syntax.PrettyNaming.NormalizeIdentifierBackticks backtickableIdentifier |> Binder.NormalizeIdentifier isRestricted
        | _ when Syntax.PrettyNaming.DoesIdentifierNeedBackticks identifier   ->
            Syntax.PrettyNaming.NormalizeIdentifierBackticks identifier |> Binder.NormalizeIdentifier isRestricted
        | _ -> identifier
    member this.binding = Binder.NormalizeIdentifier this.isBackTickRestricted this.identifier




type DirectoryInfo with 
    member this.ChildFiles(pattern:string) = Directory.GetFiles(this.FullName, pattern) |> Array.map FileInfo
    member this.DescendantFiles(pattern:string) = Directory.GetFiles(this.FullName, pattern, SearchOption.AllDirectories) |> Array.map FileInfo







module Folder = 
    let Iri = Directory.CreateDirectory @"C:\Iri"
    let DoxAletheia = Directory.CreateDirectory @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia"
    let Vocabulary = Directory.CreateDirectory @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary"
let namespaceMapper = new NamespaceMapper()



type Guid with 
    member this.asString = this.ToString("N")
    member this.asHyphenatedString = this.ToString("D")
    member this.asHyphenatedBracedString = this.ToString("B")
    member this.asHyphenatedParenthesizedString = this.ToString("P")
    member this.asHexString = this.ToString("X")


(*
  | Blank = 0
  | Uri = 1
  | Literal = 2
  | GraphLiteral = 3
  | Variable = 4
  | Triple = 5
*)


type IGraph with 
    member inline this.S<'Subject when 'Subject : (member asINode: INode)> (S:'Subject ) = this.GetTriplesWithSubject(S.asINode) |> Seq.toArray
    member inline this.SP<'Subject,'Predicate when 'Subject : (member asINode: INode) and 'Predicate : (member asINode: INode) > (S:'Subject, P:'Predicate ) = this.GetTriplesWithSubjectPredicate(S.asINode, P.asINode) |> Seq.toArray
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
    member this.GraphLiteralNodes  =
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


let randomFile = 
    Folder.DoxAletheia.DescendantFiles("*.ttl") |> Array.randomChoice
let greatGlobalGraph: IGraph = new ThreadSafeGraph()


let rec findLiteralNodeGraph (file:FileInfo) = 
    
    let fileGraph = new ThreadSafeGraph()
    FileLoader.Load(fileGraph, randomFile.FullName)
    namespaceMapper.Import fileGraph.NamespaceMap
    match fileGraph.LiteralNodes with 
    | [||] -> Folder.DoxAletheia.DescendantFiles("*.ttl") |> Array.randomChoice |> findLiteralNodeGraph 
    | _ -> file

type Namespace = 
  {
    namespaceIri:IriReference
    preferredPrefix:string
    personalPrefix:string
    seenPrefixes: ResizeArray<string>
  }

type rdfstring = Rune array

type String with 
    member this.asRdfString:rdfstring = this.Normalize().EnumerateRunes() |> Seq.toArray

type IriReference with 
    static member fromUriNode (uriNode:UriNode) = IriReference uriNode.Uri
    member this.lexicalForm = this.uri.OriginalString
    member this.identity = this.lexicalForm

    member this.asUrl = DomUrl this.uri.OriginalString 
    member this.asUri = this.uri
    member this.asUriNode = new UriNode (this.asUri)
    member this.asINode:INode = this.asUriNode
    member this.asRDFResource = new RDFResource(this.lexicalForm)
    member this.maybeCurie = 
      match namespaceMapper.ReduceToQName this.lexicalForm with 
      | true, qname -> Some qname 
      | false, _ -> None
    member this.iriref = $"<{this.uri.OriginalString}>"
    member this.toRelativeLocalPath = 
        let scheme = [ Uri.EscapeDataString this.uri.Scheme ]
        let host = [ Uri.EscapeDataString this.uri.Host ]

        let pathSegments =
            this.uri.AbsolutePath.Split([| '/' |], StringSplitOptions.RemoveEmptyEntries)
            |> Array.toList
            |> List.map (fun segment -> 
            
                // Keep it conservative: only letters/digits and a small set of safe punctuation.
                // Everything else becomes '_'.
                segment |> Seq.map (fun character ->
                    if Char.IsLetterOrDigit character
                       || character = '.'
                       || character = '-'
                       || character = '_' then
                        character
                    else
                        '_')
                |> Seq.toArray
                |> String
            
            )
            |> List.map Uri.EscapeDataString





        let delimiterBucket =
            if this.lexicalForm.ToCharArray() |> Array.last = '#' then
                [ "hash" ]
            elif this.lexicalForm.ToCharArray() |> Array.last =  '/' then
                [ "slash" ]
            else
                [ "bare" ]

        let dirs = scheme @ host @ pathSegments @ delimiterBucket

        Path.Combine(dirs |> List.toArray)


    static member fromRelativePath (relativePath: string) =
        let segments =
            relativePath.Split(
                [| Path.DirectorySeparatorChar
                   Path.AltDirectorySeparatorChar |],
                StringSplitOptions.RemoveEmptyEntries
            )
            |> Array.map Uri.UnescapeDataString
            |> Array.toList

        match segments with
        | scheme :: host :: remaining ->
            let pathSegments, delimiter =
                match List.rev remaining with
                | "hash" :: rest -> List.rev rest, "#"
                | "slash" :: rest -> List.rev rest, "/"
                | "bare" :: rest -> List.rev rest, ""
                | _ -> failwith $"Invalid relative path format: {relativePath}"

            let path =
                match pathSegments with
                | [] -> ""
                | _ -> "/" + String.concat "/" pathSegments

            IriReference $"{scheme}://{host}{path}{delimiter}"

        | _ -> failwith $"Invalid relative path format: {relativePath}"



type INamespaceMapper with 

    member this.GetNamespaceName (prefix:string) = this.GetNamespaceUri prefix |> _.OriginalString
    member this.GetNamespaceUrl (prefix:string) = this.GetNamespaceName prefix |> DomUrl
    member this.GetNamespaceIriReference (prefix:string) = this.GetNamespaceName  prefix |> IriReference









type NLanguageTag.LanguageTag with 
    member this.asString = this.ToString()
type InitialTextDirection =
    | Ltr
    | Rtl
    member this.asString = this.ToString().ToLowerInvariant()











































































type Arc =
    {
        uuid : Guid
        tailPoint : Point
        legisignPoint : Point
        headPoint : Point
    }
and [< CustomComparison ; CustomEquality>] Iri = 
    | IRIREF of IriReference
    | PrefixedIri of PrefixedName
    | SkolemIri of SkolemizedName
    static member fromUri(uri:Uri) = 
                match namespaceMapper.ReduceToQName uri.OriginalString with 
                | false, _ -> IriReference uri |> IRIREF 
                | true, qname -> PrefixedName.fromQname qname |> PrefixedIri 
    static member fromUriNode(uriNode:UriNode) = 
                match namespaceMapper.ReduceToQName uriNode.Uri.OriginalString with 
                | false, _ -> IriReference uriNode.Uri |> IRIREF 
                | true, qname -> PrefixedName.fromQname qname |> PrefixedIri 
    member this.asSubject = IriSubject this
    member this.asPredicate = IriPredicate this
    member this.asObject = IriObject this
    member this.asRdfName = IriName this
    member this.asRdfReference = NamedReference this.asIriReference

    member this.asIriReference = 
      match this with 
      | IRIREF iriReference -> iriReference
      | PrefixedIri prefixedName -> prefixedName.asIriReference
      | SkolemIri skolemizedName -> skolemizedName.asIriReference
    member this.lexicalForm = 
      match this with 
      | IRIREF iriReference -> iriReference.lexicalForm
      | PrefixedIri prefixedName -> prefixedName.lexicalForm
      | SkolemIri skolemizedName -> skolemizedName.lexicalForm
    member this.iriref = $"<{this.lexicalForm}>"
    member this.asUrl = 
      match this with 
      | IRIREF iriReference -> iriReference.asUrl
      | PrefixedIri prefixedName -> prefixedName.asUrl
      | SkolemIri skolemizedName -> skolemizedName.asUrl
    member this.asUri = 
      match this with 
      | IRIREF iriReference -> iriReference.asUri
      | PrefixedIri prefixedName -> prefixedName.asUri
      | SkolemIri skolemizedName -> skolemizedName.asUri
    member this.asUriNode = 
      match this with 
      | IRIREF iriReference -> iriReference.asUriNode
      | PrefixedIri prefixedName -> prefixedName.asUriNode
      | SkolemIri skolemizedName -> skolemizedName.asUriNode
    member this.asINode = 
      match this with 
      | IRIREF iriReference -> iriReference.asINode
      | PrefixedIri prefixedName -> prefixedName.asINode
      | SkolemIri skolemizedName -> skolemizedName.asINode

    member this.asRDFResource = 
      match this with 
      | IRIREF iriReference -> iriReference.asRDFResource
      | PrefixedIri prefixedName -> prefixedName.asRDFResource
      | SkolemIri skolemizedName -> skolemizedName.asRDFResource
    member this.maybeCurie = 
      match this with 
      | IRIREF iriReference -> iriReference.maybeCurie
      | PrefixedIri prefixedName -> Some prefixedName.curie
      | SkolemIri skolemizedName -> skolemizedName.maybeCurie

      
    member this.identity = this.lexicalForm
    
    override this.Equals(other: obj) =
        match other with
        | :? Iri as other -> this.identity = other.identity
        | :? IriReference as other -> this.identity = other.identity
        | :? PrefixedName as other -> this.identity = other.identity
        | :? SkolemizedName as other -> this.identity = other.identity
        | _ -> false
    override this.GetHashCode() = this.lexicalForm.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? Iri as other -> compare this.identity other.identity
            | :? IriReference as other -> compare this.identity other.identity
            | :? PrefixedName as other -> compare this.identity other.identity
            | :? SkolemizedName as other -> compare this.identity other.identity
            | _ -> 
                invalidArg (nameof other) (
                    sprintf "%s can only be compared with %s, %s, %s, or %s"
                        typeof<Iri>.Name
                        typeof<Iri>.Name
                        typeof<IriReference>.Name
                        typeof<PrefixedName>.Name
                        typeof<SkolemizedName>.Name
                )
                        
and [< CustomComparison ; CustomEquality>] PrefixedName = 
    {
      prefixId:PrefixId
      localName:string
    }
    static member fromQname (qname:string)  =
        {
          prefixId = PrefixId.fromPrefixLabel qname[..qname.IndexOf ":" - 1]
          localName = qname[qname.IndexOf ":" + 1..]
        }
    member this.asSubject = PrefixedIri this |> IriSubject
    member this.asPredicate = PrefixedIri this |> IriPredicate
    member this.asObject = PrefixedIri this |> IriObject
    member this.asRdfName = PrefixedIri this |> IriName
    member this.asRdfReference = NamedReference this.asIriReference
    member this.asXName = XName.op_Implicit(this.lexicalForm)
    member this.asXmlQualifiedName = new XmlQualifiedName(this.localName, this.prefixId.namespaceName)
    
        
    member this.lexicalForm = this.prefixId.namespaceName + this.localName
    member this.curieDelimited infixDelimiter = this.prefixId.prefixLabel + infixDelimiter + this.localName
    member this.curie = this.curieDelimited ":"
    member this.asUrl = DomUrl this.lexicalForm
    member this.asUri = Uri this.lexicalForm
    member this.asUriNode = new UriNode(this.asUri)
    member this.asINode :INode = this.asUriNode
    member this.asIriReference = IriReference this.lexicalForm
    member this.asRDFResource = new RDFResource(this.lexicalForm)
    member this.identity = this.lexicalForm
    
    override this.Equals(other: obj) =
        match other with
        | :? Iri as other -> this.identity = other.identity
        | :? IriReference as other -> this.identity = other.identity
        | :? PrefixedName as other -> this.identity = other.identity
        | :? SkolemizedName as other -> this.identity = other.identity
        | _ -> false
    override this.GetHashCode() = this.lexicalForm.GetHashCode()
    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? Iri as other -> compare this.identity other.identity
            | :? IriReference as other -> compare this.identity other.identity
            | :? PrefixedName as other -> compare this.identity other.identity
            | :? SkolemizedName as other -> compare this.identity other.identity
            | _ -> 
                invalidArg (nameof other) (
                    sprintf "%s can only be compared with %s, %s, %s, or %s"
                        typeof<Iri>.Name
                        typeof<Iri>.Name
                        typeof<IriReference>.Name
                        typeof<PrefixedName>.Name
                        typeof<SkolemizedName>.Name
                )
                        
and PrefixId = 
  {
    prefixLabel :string
    namespaceName :string
  }
  static member fromNamespaceLabel (namespaceName:string) (prefixLabel:string)  = 
    let prefixId = {prefixLabel = prefixLabel ; namespaceName = namespaceName}
    namespaceMapper.AddNamespace(prefixId.asNamespaceMap)
    prefixId

  static member rdf = PrefixId.fromNamespaceLabel "http://www.w3.org/1999/02/22-rdf-syntax-ns#"  "rdf"
  static member rdfs = PrefixId.fromNamespaceLabel "http://www.w3.org/2000/01/rdf-schema#"  "rdfs"
  static member owl = PrefixId.fromNamespaceLabel "http://www.w3.org/2002/07/owl#"  "owl"
  static member xsd = PrefixId.fromNamespaceLabel "http://www.w3.org/2001/XMLSchema#"  "xsd"
  static member xsi = PrefixId.fromNamespaceLabel "http://www.w3.org/2001/XMLSchema-instance#"  "xsi"
  static member xdt = PrefixId.fromNamespaceLabel "https://www.w3.org/2003/05/xpath-datatypes#"  "xdt"
  static member owlTime = PrefixId.fromNamespaceLabel "http://www.w3.org/2006/time#"  "owlTime"
  

  member this.asPrefixedName = 
    {
        prefixId = this
        localName = String.Empty
    }

  member this.prefix (localName:string) = { prefixId = this ; localName = localName} |> PrefixedIri
  member this.asSubject = PrefixedIri this.asPrefixedName |> IriSubject
  member this.asPredicate = PrefixedIri this.asPrefixedName |> IriPredicate
  member this.asObject = PrefixedIri this.asPrefixedName |> IriObject
  member this.asRdfName = PrefixedIri this.asPrefixedName |> IriName
  member this.asRdfReference = NamedReference this.asIriReference
  member this.asIriReference = this.asPrefixedName.asIriReference

  static member fromPrefixLabel (prefixLabel:string) = 
      {
        prefixLabel = prefixLabel 
        namespaceName = namespaceMapper.GetNamespaceUri prefixLabel |> _.OriginalString
      }
  member this.XNamespace = XNamespace.op_Implicit this.namespaceName
  member this.XName (localName:string) = XNamespace.Xmlns + localName
  member this.asRDFNamespace = new RDFNamespace(this.prefixLabel, this.namespaceName)
  member this.asNamespaceMap = this.prefixLabel, Uri this.namespaceName
  member this.namespaceIriReference = IriReference this.namespaceName
  member this.directory = 
    Path.Combine(Folder.Vocabulary.FullName, this.namespaceIriReference.toRelativeLocalPath) |> DirectoryInfo

and [<CustomComparison ; CustomEquality>] SkolemizedName = 
    {
      uuid:Guid
      blankNode:BlankReference
    }
    member this.maybeCurie = 
      match namespaceMapper.ReduceToQName this.lexicalForm with 
      | true, qname -> Some qname 
      | false, _ -> None
      
    member this.asSubject = SkolemIri this |> IriSubject
    member this.asPredicate = SkolemIri this |> IriPredicate
    member this.asObject = SkolemIri this |> IriObject
    member this.asRdfName = SkolemIri this |> IriName
    member this.asRdfReference = NamedReference this.asIriReference
    member this.lexicalForm = $"{wellKnownGenid}/{this.uuid.asString}"
    member this.asUrl = DomUrl this.lexicalForm
    member this.asUri = Uri this.lexicalForm
    member this.asUriNode = new UriNode(this.asUri)
    member this.asINode :INode = this.asUriNode
    member this.asIriReference = IriReference this.lexicalForm
    member this.asRDFResource = new RDFResource(this.lexicalForm)

    member this.identity = this.lexicalForm
    
    override this.Equals(other: obj) =
        match other with
        | :? Iri as other -> this.identity = other.identity
        | :? IriReference as other -> this.identity = other.identity
        | :? PrefixedName as other -> this.identity = other.identity
        | :? SkolemizedName as other -> this.identity = other.identity
        | _ -> false
    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? Iri as other -> compare this.identity other.identity
            | :? IriReference as other -> compare this.identity other.identity
            | :? PrefixedName as other -> compare this.identity other.identity
            | :? SkolemizedName as other -> compare this.identity other.identity
            | _ -> 
                invalidArg (nameof other) (
                    sprintf "%s can only be compared with %s, %s, %s, or %s"
                        typeof<Iri>.Name
                        typeof<Iri>.Name
                        typeof<IriReference>.Name
                        typeof<PrefixedName>.Name
                        typeof<SkolemizedName>.Name
                )
and BlankReference = 
    {
      blankNodeIdentifier: string
    }
    static member fromBlankNode(blankNode:VDS.RDF.BlankNode) = {blankNodeIdentifier = blankNode.InternalID}
    
    member this.asSubject = BlankSubject this 
    member this.asObject = BlankObject this 
    member this.asRdfReference = AnonymousReference this
    member this.lexicalForm = this.blankNodeIdentifier
    member this.curie = "_:" + this.blankNodeIdentifier
    member this.asBlankNode = new VDS.RDF.BlankNode(this.blankNodeIdentifier)
    member this.asRDFResource = new RDFResource(this.curie)
    member this.asINode:INode = this.asBlankNode

and [<CustomEquality ; CustomComparison>] RdfLiteral = 
    | PlainLiteral of PlainLiteral
    | DatatypedLiteral of DatatypedLiteral
    static member fromLiteralNode (literalNode:LiteralNode) = 
            match literalNode.Value, literalNode.DataType, literalNode.Language.ToLowerInvariant() with
            | lexicalForm, null, lang when not (String.IsNullOrWhiteSpace lang) -> NLanguageTag.LanguageTag.Parse lang |> RdfLiteral.languageTagged  lexicalForm
            | lexicalForm, datatypeUri, lang when not (isNull datatypeUri) && String.IsNullOrWhiteSpace lang -> 
                {
                    lexicalForm = lexicalForm
                    datatypeIri = Iri.fromUri datatypeUri 
                } |> DatatypedLiteral
            | lexicalForm ,_ ,_ -> RdfLiteral.simple lexicalForm
    static member fromILiteralNode (iliteralNode:ILiteralNode) = iliteralNode :?> LiteralNode |> RdfLiteral.fromLiteralNode
    
    static member simple(lexicalForm:string) = SimpleString lexicalForm |> PlainLiteral
    static member datatyped(lexicalForm:string) (datatypeIri:Iri) =
        {
            lexicalForm = lexicalForm 
            datatypeIri = datatypeIri 
        } |> DatatypedLiteral 
    static member languageTagged (lexicalForm:string) (languageTag:NLanguageTag.LanguageTag) = 
        {
            lexicalForm = lexicalForm 
            languageTag = languageTag
        } |> LanguageString |> PlainLiteral 
    static member language(lexicalForm:string) (language:Language) = 
        {
            lexicalForm = lexicalForm 
            languageTag = new NLanguageTag.LanguageTag(language)
        } |> LanguageString |> PlainLiteral 
    static member en (lexicalForm:string) = RdfLiteral.language lexicalForm Language.EN
    static member US (lexicalForm:string) = new NLanguageTag.LanguageTag(Language.EN, Region.US) |> RdfLiteral.languageTagged lexicalForm 


    static member inline autotyped<'ValueType>(value: 'ValueType) =

        let datatypedLiteral =
            let invariantString =
                if box value = null then
                    String.Empty
                else
                    Convert.ToString(value, CultureInfo.InvariantCulture)

            match box value with
            | :? Boolean as value -> { lexicalForm = (if value then "true" else "false") ; datatypeIri = PrefixId.xsd.prefix "boolean" }
            | :? (Byte array) as value -> { lexicalForm = Convert.ToBase64String(value) ; datatypeIri = PrefixId.xsd.prefix "base64Binary" }
            | :? Byte as value -> { lexicalForm = invariantString ; datatypeIri = PrefixId.xsd.prefix "unsignedByte" }
            | :? DateOnly as value -> { lexicalForm = value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) ; datatypeIri = PrefixId.xsd.prefix "date" }
            | :? DateTime as value -> { lexicalForm = value.ToString("o", CultureInfo.InvariantCulture) ; datatypeIri = PrefixId.xsd.prefix "dateTime" }
            | :? DateTimeOffset as value -> { lexicalForm = value.ToString("o", CultureInfo.InvariantCulture) ; datatypeIri = PrefixId.xsd.prefix "dateTimeStamp" }
            | :? Decimal as value -> { lexicalForm = invariantString ; datatypeIri = PrefixId.xsd.prefix "decimal" }
            | :? Double as value -> { lexicalForm = value.ToString("R", CultureInfo.InvariantCulture) ; datatypeIri = PrefixId.xsd.prefix "double" }
            | :? Int16 as value -> { lexicalForm = invariantString ; datatypeIri = PrefixId.xsd.prefix "short" }
            | :? Int32 as value -> { lexicalForm = invariantString ; datatypeIri = PrefixId.xsd.prefix "int" }
            | :? Int64 as value -> { lexicalForm = invariantString ; datatypeIri = PrefixId.xsd.prefix "long" }
            | :? SByte as value -> { lexicalForm = invariantString ; datatypeIri = PrefixId.xsd.prefix "byte" }
            | :? Single as value -> { lexicalForm = value.ToString("R", CultureInfo.InvariantCulture) ; datatypeIri = PrefixId.xsd.prefix "float" }
            | :? TimeOnly as value -> { lexicalForm = value.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture) ; datatypeIri = PrefixId.xsd.prefix "time" }
            | :? TimeSpan as value -> { lexicalForm = Xml.XmlConvert.ToString(value) ; datatypeIri = PrefixId.xsd.prefix "duration" }
            | :? UInt16 as value -> { lexicalForm = invariantString ; datatypeIri = PrefixId.xsd.prefix "unsignedShort" }
            | :? UInt32 as value -> { lexicalForm = invariantString ; datatypeIri = PrefixId.xsd.prefix "unsignedInt" }
            | :? UInt64 as value -> { lexicalForm = invariantString ; datatypeIri = PrefixId.xsd.prefix "unsignedLong" }
            | :? Uri as value -> { lexicalForm = value.OriginalString ; datatypeIri = PrefixId.xsd.prefix "anyURI" }
            | :? DomUrl as value -> { lexicalForm = value.ToString() ; datatypeIri = PrefixId.xsd.prefix "anyURI" }
            | :? IriReference as value -> { lexicalForm = value.ToString() ; datatypeIri = PrefixId.xsd.prefix "anyURI" }
            | :? XmlQualifiedName as value -> { lexicalForm = value.ToString() ; datatypeIri = PrefixId.xsd.prefix "QName" }
            | :? Guid as value -> { lexicalForm = value.ToString() ; datatypeIri = PrefixId.xsd.prefix "ID" }
            | :? String as value -> { lexicalForm = value ; datatypeIri = PrefixId.xsd.prefix "string" }
            | null  -> { lexicalForm = "true" ; datatypeIri = PrefixId.xsi.prefix "nil" }
            | value -> { lexicalForm = invariantString ; datatypeIri = PrefixId.xdt.prefix "anyAtomicType" }

        datatypedLiteral |> DatatypedLiteral

    static member True = RdfLiteral.autotyped true 
    static member False = RdfLiteral.autotyped false
    member this.asObject = LiteralObject this
    member this.asRdfName = LiteralName this
    member this.lexicalForm = 
      match this with 
      | PlainLiteral plainLiteral -> plainLiteral.lexicalForm
      | DatatypedLiteral datatypedLiteral -> datatypedLiteral.lexicalForm
    member this.maybeCurie = 
      match this with 
      | PlainLiteral plainLiteral -> None
      | DatatypedLiteral datatypedLiteral -> datatypedLiteral.curie
    member this.asLiteralNode = 
      match this with 
      | PlainLiteral plainLiteral -> plainLiteral.asLiteralNode
      | DatatypedLiteral datatypedLiteral -> datatypedLiteral.asLiteralNode
      
    member this.asINode :INode = this.asLiteralNode
    member this.datatypeIri = 
      match this with 
      | PlainLiteral plainLiteral -> PrefixId.xsd.prefix "string"
      | DatatypedLiteral datatypedLiteral -> datatypedLiteral.datatypeIri
      
    member this.maybeLanguageTag = 
      match this with 
      | PlainLiteral plainLiteral -> plainLiteral.maybeLanguageTag
      | DatatypedLiteral datatypedLiteral -> None
    member this.maybeBaseDirection = 
      match this with 
      | PlainLiteral plainLiteral -> plainLiteral.maybeBaseDirection
      | DatatypedLiteral datatypedLiteral -> None

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
and [<CustomEquality ; CustomComparison>] PlainLiteral = 
    | SimpleString of string
    | LanguageString of LanguageString
    | DirectedLanguageString of DirectedLanguageString
    member this.asObject = PlainLiteral this |> LiteralObject
    member this.asRdfName = PlainLiteral this |> LiteralName 
    member this.lexicalForm = 
      match this with 
      | SimpleString rdfString -> rdfString
      | LanguageString languageString -> languageString.lexicalForm
      | DirectedLanguageString directedLanguageString -> directedLanguageString.lexicalForm
    member this.curie = 
      match this with 
      | SimpleString rdfString -> rdfString
      | LanguageString languageString -> languageString.curie
      | DirectedLanguageString directedLanguageString -> directedLanguageString.curie
    member this.asLiteralNode = 
      match this with 
      | SimpleString rdfString -> new LiteralNode (rdfString)
      | LanguageString languageString -> new LiteralNode (languageString.lexicalForm, languageString.languageTag.asString)
      | DirectedLanguageString directedLanguageString -> new LiteralNode (directedLanguageString.lexicalForm, directedLanguageString.i18nIri.asUri)
    member this.asINode :INode = this.asLiteralNode
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
    member this.identity = 
      match this with 
      | SimpleString rdfString -> (rdfString, (PrefixId.xsd.prefix "string").identity, None, None)
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
and [<CustomEquality ; CustomComparison>] LanguageString = 
    {
    lexicalForm:string
    languageTag:NLanguageTag.LanguageTag
    }
    member this.asObject = LanguageString this |> PlainLiteral |> LiteralObject
    member this.asRdfName = LanguageString this |> PlainLiteral |> LiteralName
    member this.curie = sprintf "%s@%s" this.lexicalForm this.languageTag.asString
    member this.identity = (this.lexicalForm, (PrefixId.rdf.prefix "langString").identity, Some(this.languageTag.asString), None)

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
and [<CustomEquality ; CustomComparison>] DirectedLanguageString = 
    {
    lexicalForm:string
    languageTag:NLanguageTag.LanguageTag
    baseDirection:InitialTextDirection
    }
    member this.asObject = DirectedLanguageString this |> PlainLiteral |> LiteralObject
    member this.asRdfName = DirectedLanguageString this |> PlainLiteral |> LiteralName
    member this.curie = sprintf "%s@%s--%s" this.lexicalForm this.languageTag.asString this.baseDirection.asString
    member this.i18nIri:Iri = IriReference $"https://www.w3.org/ns/i18n#{this.languageTag.asString}_{this.baseDirection.asString}" |> IRIREF
    // TODO from i18nIri
    member this.identity = (this.lexicalForm, (PrefixId.rdf.prefix "dirLangString").identity, Some(this.languageTag.asString), Some(this.baseDirection.asString))

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

and [<CustomEquality ; CustomComparison>] DatatypedLiteral = 
    {
    lexicalForm:string
    datatypeIri:Iri
    }
    member this.asObject = DatatypedLiteral this  |> LiteralObject
    member this.asRdfName = DatatypedLiteral this |> LiteralName
    member this.asLiteralNode = new LiteralNode (this.lexicalForm, this.datatypeIri.asUri)
    member this.asINode :INode = this.asLiteralNode
    member this.curie = 
        match this.datatypeIri.maybeCurie with 
        | Some curie -> Some(sprintf "%s^^%s" this.lexicalForm curie)
        | None -> None
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
and [<CustomEquality ; CustomComparison>] RdfVariable = 
    {
        uuid :Guid
        identifier:string
        mutable bindingCell : Adaptive.cval<Point option>
    }
    static member fromVariableNode (variableNode:VariableNode) = 
            {
                uuid = new Guid()
                identifier = variableNode.VariableName
                bindingCell = Adaptive.cval (None:Point option)
            }
    static member fromIdentifier (identifier:string) = 
            {
                uuid = new Guid()
                identifier = identifier
                bindingCell = Adaptive.cval (None:Point option)
            }
    member this.asSubject = VariableSubject this
    member this.asPredicate = VariablePredicate this
    member this.asObject = VariableObject this

    member this.lexicalForm = this.identifier
    member this.questionForm = "?" + this.lexicalForm
    member this.dollarForm = "$" + this.lexicalForm
    member this.asVariableNode = new VariableNode(this.identifier)
    member this.asINode :INode = this.asVariableNode
    member this.asSparqlVariable = new SparqlVariable(this.identifier)
    member this.asBlankReference = { blankNodeIdentifier = this.identifier}
    member this.asSkolemIri = { uuid = this.uuid ; blankNode = this.asBlankReference}
    member this.asPatternItem(patternBuilder: TriplePatternBuilder) = patternBuilder.PatternItemFactory.CreateVariablePattern(this.identifier)
    member this.binding : Adaptive.aval<Point option> = this.bindingCell :> Adaptive.aval<Point option>
    member this.bind (point:Point) = transact (fun () -> this.bindingCell.Value <- Some point)
    member this.unbind() = transact (fun () -> this.bindingCell.Value <- None)
    member this.maybeTerm = this.binding |> Adaptive.AVal.force
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

and RdfSubject = 
    | IriSubject of Iri
    | BlankSubject of BlankReference
    | VariableSubject of RdfVariable
    static member fromINode (inode:INode) = 
        match inode.NodeType with
        | NodeType.Uri ->
            inode :?> UriNode
            |> Iri.fromUriNode
            |> IriSubject
        | NodeType.Blank ->
            inode :?> BlankNode
            |> BlankReference.fromBlankNode
            |> BlankSubject
        | NodeType.Variable ->
            inode :?> VariableNode
            |> RdfVariable.fromVariableNode
            |> VariableSubject
    member this.maybePredicate = 
        match this with 
        | IriSubject  iri -> Some iri.asPredicate
        | BlankSubject  blankReference -> None
        | VariableSubject  rdfVariable -> Some rdfVariable.asPredicate
    member this.asObject = 
        match this with 
        | IriSubject  iri -> iri.asObject
        | BlankSubject  blankReference -> blankReference.asObject
        | VariableSubject  rdfVariable -> rdfVariable.asObject
    member this.maybeRdfName = 
        match this with 
        | IriSubject  iri -> Some iri.asRdfName
        | BlankSubject  blankReference -> None
        | VariableSubject  rdfVariable -> None
    member this.maybeRdfReference = 
        match this with 
        | IriSubject  iri -> Some iri.asRdfReference
        | BlankSubject  blankReference -> Some blankReference.asRdfReference
        | VariableSubject  rdfVariable -> None
    member this.asVertex = SubjectVertex this
    member this.asRdfTerm = 
        match this with 
        | IriSubject  iri -> IriPoint iri
        | BlankSubject  blankReference -> BlankPoint blankReference
        | VariableSubject  rdfVariable -> VariablePoint rdfVariable
    member this.lexicalForm = 
        match this with 
        | IriSubject  iri -> iri.lexicalForm
        | BlankSubject  blankReference -> blankReference.lexicalForm
        | VariableSubject  rdfVariable -> rdfVariable.lexicalForm
    member this.maybeCurie = 
        match this with 
        | IriSubject  iri -> iri.maybeCurie
        | BlankSubject  blankReference -> Some blankReference.curie
        | VariableSubject  rdfVariable -> None
    member this.asINode = 
        match this with 
        | IriSubject  iri -> iri.asINode
        | BlankSubject  blankReference -> blankReference.asINode
        | VariableSubject  rdfVariable -> rdfVariable.asINode
    member this.asPatternItem(patternBuilder: TriplePatternBuilder) : PatternItem =
        match this with
        | VariableSubject rdfVariable -> patternBuilder |> rdfVariable.asPatternItem
        | _ -> patternBuilder.PatternItemFactory.CreateNodeMatchPattern(this.asINode)

and RdfPredicate = 
    | IriPredicate of Iri
    | VariablePredicate of RdfVariable
    static member fromINode (inode:INode) = 
        match inode.NodeType with
        | NodeType.Uri ->
            inode :?> UriNode
            |> Iri.fromUriNode
            |> IriPredicate
        | NodeType.Variable ->
            inode :?> VariableNode
            |> RdfVariable.fromVariableNode
            |> VariablePredicate
    member this.asSubject = 
        match this with 
        | IriPredicate  iri -> iri.asSubject
        | VariablePredicate  rdfVariable -> rdfVariable.asSubject
    member this.asObject = 
        match this with 
        | IriPredicate  iri -> iri.asObject
        | VariablePredicate  rdfVariable -> rdfVariable.asObject
    member this.maybeRdfName = 
        match this with 
        | IriPredicate  iri -> Some iri.asRdfName
        | VariablePredicate  rdfVariable -> None
    member this.maybeRdfReference = 
        match this with 
        | IriPredicate  iri -> Some(NamedReference iri.asIriReference)
        | VariablePredicate  rdfVariable -> None
    member this.asEdge = PredicateEdge this
    member this.asRdfTerm = 
        match this with 
        | IriPredicate  iri -> IriPoint iri
        | VariablePredicate  rdfVariable -> VariablePoint rdfVariable
    member this.lexicalForm = 
        match this with 
        | IriPredicate  iri -> iri.lexicalForm
        | VariablePredicate  rdfVariable -> rdfVariable.lexicalForm
    member this.maybeCurie = 
        match this with 
        | IriPredicate  iri -> iri.maybeCurie
        | VariablePredicate  rdfVariable -> None
    member this.asINode = 
        match this with 
        | IriPredicate  iri -> iri.asINode
        | VariablePredicate  rdfVariable -> rdfVariable.asINode
    member this.asPatternItem(patternBuilder: TriplePatternBuilder) : PatternItem =
        match this with
        | VariablePredicate rdfVariable -> patternBuilder |> rdfVariable.asPatternItem
        | _ -> patternBuilder.PatternItemFactory.CreateNodeMatchPattern(this.asINode)

and RdfObject = 
    | IriObject of Iri
    | BlankObject of BlankReference
    | LiteralObject of RdfLiteral
    | TripleTermObject of RdfTripleTerm
    | VariableObject of RdfVariable
    static member fromINode (inode:INode) = 
        match inode.NodeType with
        | NodeType.Uri ->
            inode :?> UriNode
            |> Iri.fromUriNode
            |> IriObject
        | NodeType.Blank ->
            inode :?> BlankNode
            |> BlankReference.fromBlankNode
            |> BlankObject
        | NodeType.Literal ->
            inode :?> LiteralNode
            |> RdfLiteral.fromLiteralNode
            |> LiteralObject
        | NodeType.Triple ->
            inode :?> TripleNode
            |> RdfTripleTerm.fromTripleNode
            |> TripleTermObject
        | NodeType.Variable ->
            inode :?> VariableNode
            |> RdfVariable.fromVariableNode
            |> VariableObject
    member this.maybeSubject = 
        match this with 
        | IriObject  iri -> Some (IriSubject iri)
        | BlankObject  blankReference -> Some (BlankSubject blankReference)
        | LiteralObject  rdfLiteral -> None
        | TripleTermObject tripleTerm -> None
        | VariableObject  rdfVariable -> Some (VariableSubject rdfVariable )
    member this.maybePredicate = 
        match this with 
        | IriObject  iri -> Some (IriPredicate iri)
        | BlankObject  blankReference -> None
        | LiteralObject  rdfLiteral -> None
        | TripleTermObject tripleTerm -> None
        | VariableObject  rdfVariable -> Some (VariablePredicate rdfVariable )
    member this.asRdfTerm = 
        match this with 
        | IriObject  iri -> IriPoint iri
        | BlankObject  blankReference -> BlankPoint blankReference
        | LiteralObject  rdfLiteral -> LiteralPoint rdfLiteral
        | TripleTermObject tripleTerm -> TriplePoint tripleTerm
        | VariableObject  rdfVariable -> VariablePoint rdfVariable
    member this.lexicalForm = 
        match this with 
        | IriObject  iri -> iri.lexicalForm
        | BlankObject  blankReference -> blankReference.lexicalForm
        | LiteralObject  rdfLiteral -> rdfLiteral.lexicalForm
        | TripleTermObject tripleTerm -> tripleTerm.lexicalForm
        | VariableObject  rdfVariable -> rdfVariable.lexicalForm
    member this.maybeCurie = 
        match this with 
        | IriObject  iri -> iri.maybeCurie
        | BlankObject  blankReference -> Some blankReference.curie
        | LiteralObject  rdfLiteral -> rdfLiteral.maybeCurie
        | TripleTermObject tripleTerm -> Some tripleTerm.curiesAndOrLexicalForms
        | VariableObject  rdfVariable -> None
    member this.asINode = 
        match this with 
        | IriObject  iri -> iri.asINode
        | BlankObject  blankReference -> blankReference.asINode
        | LiteralObject  rdfLiteral -> rdfLiteral.asINode
        | TripleTermObject tripleTerm -> tripleTerm.asINode
        | VariableObject  rdfVariable -> rdfVariable.asINode
    member this.asPatternItem(patternBuilder: TriplePatternBuilder) : PatternItem =
        match this with
        | VariableObject rdfVariable -> patternBuilder |> rdfVariable.asPatternItem
        | _ -> patternBuilder.PatternItemFactory.CreateNodeMatchPattern(this.asINode)


and PredicateObjectList =
    {

      verb: RdfPredicate
      objectLists: ObjectList array

     }

    static member inline fromTerms (predicate: RdfPredicate) (objects: RdfObject array) =
        {

          verb = predicate
          objectLists =
            objects
            |> Array.map (fun rdfObject ->
                { rdfObject = rdfObject
                  annotations = [||]

                })

        }

and ObjectList =
    { rdfObject: RdfObject
      annotations: Annotation array }
and Annotation =
    | AnnotationReifier of RdfSubject
    | AnnotationBlock of PredicateObjectList
and RdfTriple =
    { curSubject: RdfSubject
      curPredicate: RdfPredicate
      curObject: RdfObject }
    static member fromVDSTriple (vdsTriple:VDS.RDF.Triple) = 

        { curSubject = RdfSubject.fromINode vdsTriple.Subject
          curPredicate = RdfPredicate.fromINode vdsTriple.Predicate
          curObject = RdfObject.fromINode vdsTriple.Object }
    static member inline fromTerms
        (rdfSubject: ^SubjectType when ^SubjectType: (member asSubject: RdfSubject))
        (rdfPredicate: ^PredicateType when ^PredicateType: (member asPredicate: RdfPredicate))
        (rdfObject: ^ObjectType when ^ObjectType: (member asObject: RdfObject))
        =
        { curSubject = rdfSubject.asSubject
          curPredicate = rdfPredicate.asPredicate
          curObject = rdfObject.asObject }
    static member setFromTerms
        (rdfSubjects: RdfSubject array)
        (rdfPredicates: RdfPredicate array)
        (rdfObjects: RdfObject array)
        =
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
    static member setFromSubjectsPredicateObjectLists
        (rdfSubjects: RdfSubject array)
        (predicateObjectLists: PredicateObjectList array)
        =
        rdfSubjects
        |> Array.Parallel.collect (fun rdfSubject ->
            predicateObjectLists
            |> Array.Parallel.collect (fun predicateObjectList ->
                predicateObjectList.objectLists
                |> Array.Parallel.map (fun objectList ->
                    // TODO deal with annotations


                    { curSubject = rdfSubject
                      curPredicate = predicateObjectList.verb
                      curObject = objectList.rdfObject }

                )

            )

        )
        |> HashSet.ofSeq
    member this.lexicalTriple = this.curSubject.lexicalForm, this.curPredicate.lexicalForm, this.curObject.lexicalForm
    member this.lexicalForms = 
        [|
            this.curSubject.lexicalForm
            this.curPredicate.lexicalForm
            this.curObject.lexicalForm
        |]

    member this.lexicalForm = this.lexicalForms |> String.concat " "
    member this.points =
        [| this.curSubject.asRdfTerm
           this.curPredicate.asRdfTerm
           this.curObject.asRdfTerm |]
    member this.curiesAndOrLexicalForms = 
        this.points
         |> Array.map (fun point -> defaultArg point.maybeCurie point.lexicalForm )
        |> String.concat " "
    member this.verticies = 
        [| SubjectVertex this.curSubject
           ObjectVertex this.curObject |]
    member this.asVDSTriple = new Triple (this.curSubject.asINode, this.curPredicate.asINode, this.curObject.asINode)
    member this.asITriplePattern  (patternBuilder: TriplePatternBuilder) =
        TriplePattern(
            this.curSubject.asPatternItem patternBuilder,
            this.curPredicate.asPatternItem patternBuilder,
            this.curObject.asPatternItem patternBuilder
        )
        :> ITriplePattern
and RdfTripleTerm = 
    {
        ttTriple:RdfTriple 
    }
    static member fromVDSTriple (vdsTriple:VDS.RDF.Triple) = 
        {
            ttTriple = RdfTriple.fromVDSTriple vdsTriple
        }
    static member fromTripleNode (tripleNode:TripleNode) = RdfTripleTerm.fromVDSTriple tripleNode.Triple
    member this.ttSubject = this.ttTriple.curSubject
    member this.ttPredicate = this.ttTriple.curPredicate
    member this.ttObject = this.ttTriple.curObject
    member this.asTripleNode = new TripleNode(this.ttTriple.asVDSTriple)
    member this.lexicalForm = this.ttTriple.lexicalForm
    member this.curiesAndOrLexicalForms = this.ttTriple.curiesAndOrLexicalForms
    member this.asINode :INode = this.asTripleNode

and Formula =
    {

      subjects: RdfSubject array
      predicates: RdfPredicate array
      objects: RdfObject array
      predicateObjectLists: PredicateObjectList array
      triples: HashSet<RdfTriple>

     }
    static member Empty =

        { subjects = [||]
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member fromIGraph(igraph: IGraph) =
        { Formula.Empty with
            triples =
                igraph.Triples
                |> PSeq.map (fun vdsTriple ->

                    RdfTriple.fromVDSTriple vdsTriple

                )
                |> HashSet.ofSeq

         }

    static member fromGraphLiteralNode(graphLiteralNode: GraphLiteralNode) =
        Formula.fromIGraph graphLiteralNode.SubGraph


    member this.ITriplePatterns(patternBuilder: TriplePatternBuilder) : ITriplePattern array =
        this.triples
        |> Seq.toArray
        |> Array.map (fun rdfTriple -> patternBuilder |> rdfTriple.asITriplePattern)

    member this.asRdfTripleSet: RdfTripleSet = { triples = this.triples }


    static member fromRdfSubject rdfSubject =

        { subjects = [| rdfSubject |]
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member fromRdfSubjects rdfSubjects =

        { subjects = rdfSubjects |> List.toArray
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member fromRdfPredicate rdfPredicate =

        { subjects = [||]
          predicates = [| rdfPredicate |]
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member fromRdfPredicates rdfPredicates =

        { subjects = [||]
          predicates = rdfPredicates
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member fromRdfObject rdfObject =

        { subjects = [||]
          predicates = [||]
          objects = [| rdfObject |]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member fromRdfObjects rdfObjects =

        { subjects = [||]
          predicates = [||]
          objects = rdfObjects
          predicateObjectLists = [||]
          triples = HashSet.empty

        }


    member this.materializeTriples =
        { subjects = [||]
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples =
            Seq.concat [ this.triples
                         RdfTriple.setFromTerms this.subjects this.predicates this.objects
                         RdfTriple.setFromSubjectsPredicateObjectLists this.subjects this.predicateObjectLists ]
            |> HashSet.ofSeq


        }

    static member materializeFormula(formula: Formula) = formula.materializeTriples

    member this.addFormulas(formulas: Formula list) =
        { this with
            triples =
                Seq.concat [ this.triples
                             formulas |> Seq.collect (fun formula -> formula.triples) |> HashSet.ofSeq ]
                |> HashSet.ofSeq }



    member this.addRdfSubjects rdfSubjects =
        { this with subjects = this.subjects |> Array.append rdfSubjects }

    member this.addRdfSubject rdfSubject = this.addRdfSubjects [| rdfSubject |]


    member this.addRdfPredicates rdfPredicates =

        { this with predicates = this.predicates |> Array.append rdfPredicates }

    member this.addPredicateObjectLists predicateObjectLists =

        { this with
            predicateObjectLists =
                this.predicateObjectLists
                |> Array.append predicateObjectLists }

    member this.addRdfPredicate rdfPredicate =
        this.addRdfPredicates [| rdfPredicate |]

    member this.addRdfObjects rdfObjects =
        { this with objects = this.objects |> Array.append rdfObjects }

    member this.addRdfObject rdfObject = this.addRdfObjects [| rdfObject |]

    member this.addRdfLiteral rdfLiteral =
        RdfLiteral.autotyped rdfLiteral
        |> RdfObject.LiteralObject
        |> this.addRdfObject

    member this.addRdfLiterals rdfLiterals =
        rdfLiterals
        |> List.toArray
        |> Array.Parallel.map (fun literal ->
            literal
            |> RdfLiteral.autotyped
            |> RdfObject.LiteralObject)
        |> this.addRdfObjects
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


and Point = 
  | IriPoint of Iri
  | BlankPoint of BlankReference
  | LiteralPoint of RdfLiteral
  | TriplePoint of RdfTripleTerm
  | VariablePoint of RdfVariable
  | FormulaPoint of Formula
  
    static member fromINode(inode: INode) =
        match inode.NodeType with
        | NodeType.Uri ->
            inode :?> UriNode
            |> Iri.fromUriNode
            |> IriPoint
        | NodeType.Blank ->
            inode :?> BlankNode
            |> BlankReference.fromBlankNode
            |> BlankPoint
        | NodeType.Literal ->
            inode :?> LiteralNode
            |> RdfLiteral.fromLiteralNode
            |> LiteralPoint
        | NodeType.Triple ->
            inode :?> TripleNode
            |> RdfTripleTerm.fromTripleNode
            |> TriplePoint
        | NodeType.Variable ->
            inode :?> VariableNode
            |> RdfVariable.fromVariableNode
            |> VariablePoint
        | NodeType.GraphLiteral ->
           inode :?> GraphLiteralNode
           |> Formula.fromGraphLiteralNode
           |> FormulaPoint
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



and Vertex =
    | SubjectVertex of RdfSubject
    | ObjectVertex of RdfObject


    member this.asRenderedString (prefixDelimiter: string)  =
        match this with
        | SubjectVertex rdfSubject -> defaultArg rdfSubject.maybeCurie rdfSubject.lexicalForm |> _.Replace(":",prefixDelimiter)
        | ObjectVertex rdfObject -> defaultArg  rdfObject.maybeCurie rdfObject.lexicalForm |> _.Replace(":",prefixDelimiter)

and Edge =
    | PredicateEdge of RdfPredicate
    | TripleEdge of RdfTriple

    member this.asRenderedString (prefixDelimiter: string)  =
        match this with
        | PredicateEdge rdfPredicate -> defaultArg rdfPredicate.maybeCurie rdfPredicate.lexicalForm |> _.Replace(":",prefixDelimiter)
        | TripleEdge rdfTriple -> defaultArg rdfTriple.curPredicate.maybeCurie rdfTriple.lexicalForm |> _.Replace(":",prefixDelimiter)

and RdfName = 
    | IriName of Iri
    | LiteralName of RdfLiteral

and RdfReference = 
  | NamedReference of IriReference
  | AnonymousReference of BlankReference


and RdfTripleSet =
    { triples: HashSet<RdfTriple> }

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


    static member fromIGraph(igraph: IGraph) =
        { triples =
            igraph.Triples
            |> PSeq.map (fun vdsTriple -> RdfTriple.fromVDSTriple vdsTriple)
            |> HashSet.ofSeq }






type VDS.RDF.BlankNode with 
    member this.asBlankReference = { blankNodeIdentifier = this.InternalID}
type VDS.RDF.UriNode with 
    member this.asIriReference = IriReference this.Uri
type VDS.RDF.LiteralNode with 
    member this.asRDFLiteral = 
        match this.DataType.OriginalString, this.Language with 
        | "http://www.w3.org/2001/XMLSchema#string", _ -> SimpleString this.Value |> PlainLiteral
        | "http://www.w3.org/1999/02/22-rdf-syntax-ns#langString", languageTagString -> 
            {
              lexicalForm = this.Value
              languageTag = LanguageTag.Parse languageTagString
            } |> LanguageString |> PlainLiteral
        | datatype, "" -> 
            DatatypedLiteral {
                            lexicalForm = this.Value
                            datatypeIri =  Iri.fromUri this.DataType 
                          }
        | _ -> failwithf "%O %s %s failed " this this.DataType.OriginalString this.Language

type IGraph with 
    member this.RdfsEntailedGraph() = 
        let rdfsEntailedGraph = new ThreadSafeGraph()
        rdfsEntailedGraph.Assert this.Triples |> ignore
        RdfsReasoner().Apply rdfsEntailedGraph
        rdfsEntailedGraph
type RDFGraph with 
    member this.triples = this |> Seq.toArray
type RDFNamespace with 
    member this.NamespaceName = this.NamespaceUri.OriginalString


type INode with 
    member this.asRdfTerm = 
          match this with 
          | :? UriNode as uriNode -> Iri.fromUriNode uriNode |> IriPoint
          | :? BlankNode as blankNode -> BlankReference.fromBlankNode blankNode |> BlankPoint
          | :? LiteralNode as literalNode -> RdfLiteral.fromLiteralNode literalNode |> LiteralPoint
          | :? TripleNode as tripleNode -> RdfTripleTerm.fromTripleNode tripleNode |> TriplePoint 
          | :? VariableNode as variableNode -> RdfVariable.fromVariableNode variableNode |> VariablePoint
          | :? GraphLiteralNode as graphLiteralNode -> Formula.fromGraphLiteralNode graphLiteralNode |> FormulaPoint




type OntologyClass with 
    member this.asRdfTerm = this.Resource.asRdfTerm
type OntologyProperty with 
    member this.asRdfTerm = this.Resource.asRdfTerm
































type RdfDocument = 
  {
    rdfFile: FileInfo
  }
  member this.asIGraph :IGraph = 
        let igraph = new ThreadSafeGraph()
        FileLoader.Load(igraph,this.rdfFile.FullName)
        namespaceMapper.Import igraph.NamespaceMap
        igraph
  member this.asOntologyGraph = 
        let ontologyGraph = new OntologyGraph()
        FileLoader.Load(ontologyGraph,this.rdfFile.FullName)
        namespaceMapper.Import ontologyGraph.NamespaceMap
        ontologyGraph
  member this.asRDFGraph = RDFGraph.FromFile(RDFModelEnums.RDFFormats.Turtle, randomFile.FullName)
  member this.asOWLOntology = task { return! OWLOntology.FromRDFGraphAsync this.asRDFGraph } |> Async.AwaitTask |> Async.RunSynchronously
  member this.asDataTable = this.asRDFGraph.ToDataTable()
  member this.points = 
      this.asIGraph.AllNodes
    |> Seq.toArray
    |> Array.map Point.fromINode
  member this.iris = this.points |> Array.choose (fun point -> 
    match point with 
    | IriPoint iri -> Some iri
    | _ -> None
    )
  member this.prefixedNames = this.iris |> Array.choose (fun iri -> 
    match iri with 
    | PrefixedIri prefixedName -> Some prefixedName
    | _ -> None
    )

  member this.literals = this.points |> Array.choose (fun point -> 
    match point with 
    | LiteralPoint literal -> Some literal
    | _ -> None
    )
  member this.blankNodes = this.points |> Array.choose (fun point -> 
    match point with 
    | BlankPoint blankNode -> Some blankNode
    | _ -> None
    )

  member this.namespacedNames (namespacePrefixId:PrefixId) = 
      this.prefixedNames |> Array.filter (fun prefixedName -> prefixedName.prefixId.namespaceName = namespacePrefixId.namespaceName) |> Array.sortBy (fun prefixedName -> prefixedName.localName)







module RdfLiteral =



    let true_ = RdfLiteral.autotyped true
    let false_ = RdfLiteral.autotyped false

    module Binary =

        let base64 (bytes: Byte array) =
            let valueString = Convert.ToBase64String(bytes)

            PrefixId.xsd.prefix "base64Binary"
            |> RdfLiteral.datatyped valueString

        let hex (bytes: Byte array) =
            let valueString = Convert.ToHexString(bytes)

            PrefixId.xsd.prefix "hexBinary"
            |> RdfLiteral.datatyped valueString


    module Temporal =
        module duration =
            let timeDuration (timespan: TimeSpan) =
                let valueString = Xml.XmlConvert.ToString(timespan)

                PrefixId.xsd.prefix "duration"
                |> RdfLiteral.datatyped valueString

            let dayTimeDuration (timespan: TimeSpan) =
                let valueString = Xml.XmlConvert.ToString(timespan)

                PrefixId.xdt.prefix "dayTimeDuration"
                |> RdfLiteral.datatyped valueString


            let yearMonthDuration (years: int) (months: int) =
                let totalMonths = years * 12 + months

                let valueString =
                    if totalMonths = 0 then
                        "P0M"
                    else
                        let absoluteMonths = abs totalMonths
                        let yearsPart = absoluteMonths / 12
                        let monthsPart = absoluteMonths % 12
                        let sign = if totalMonths < 0 then "-" else ""

                        let yearText =
                            if yearsPart = 0 then
                                ""
                            else
                                $"{yearsPart}Y"

                        let monthText =
                            if monthsPart = 0 then
                                ""
                            else
                                $"{monthsPart}M"

                        $"{sign}P{yearText}{monthText}"

                PrefixId.xdt.prefix "yearMonthDuration"
                |> RdfLiteral.datatyped valueString


        module date =

            let only (date: DateOnly) =
                let valueString = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "date"
                |> RdfLiteral.datatyped valueString

            let fromDatetime (datetime: DateTime) =
                let valueString = datetime.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "date"
                |> RdfLiteral.datatyped valueString

            let time (datetime: DateTime) =
                let valueString = datetime.ToString("o", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "dateTime"
                |> RdfLiteral.datatyped valueString

            let timeStamp (datetimeOffset: DateTimeOffset) =
                let valueString = datetimeOffset.ToString("o", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "dateTimeStamp"
                |> RdfLiteral.datatyped valueString



        module time =

            let only (time: TimeOnly) =
                let valueString = time.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "time"
                |> RdfLiteral.datatyped valueString

            let fromDatetime (datetime: DateTime) =
                let valueString =
                    datetime.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "time"
                |> RdfLiteral.datatyped valueString

        module period =

            let day (datetime: DateTime) =
                let valueString =
                    $"""---{datetime.Day.ToString("00", CultureInfo.InvariantCulture)}"""

                PrefixId.xsd.prefix "gDay"
                |> RdfLiteral.datatyped valueString


            let month (datetime: DateTime) =
                let valueString =
                    $"""--{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}"""

                PrefixId.xsd.prefix "gMonth"
                |> RdfLiteral.datatyped valueString


            let monthDay (datetime: DateTime) =
                let valueString =
                    $"""--{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}-{datetime.Day.ToString("00", CultureInfo.InvariantCulture)}"""

                PrefixId.xsd.prefix "gMonthDay"
                |> RdfLiteral.datatyped valueString


            let year (datetime: DateTime) =
                let valueString = datetime.Year.ToString("0000", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "gYear"
                |> RdfLiteral.datatyped valueString


            let yearMonth (datetime: DateTime) =
                let valueString =
                    $"""{datetime.Year.ToString("0000", CultureInfo.InvariantCulture)}-{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}"""

                PrefixId.xsd.prefix "gYearMonth"
                |> RdfLiteral.datatyped valueString
            let generalDay (day: int) =
                // TODO find a strongly typed parse instead of validation
                // test <@ day >= 1 && day <= 99 @>
                let valueString = $"""---{day.ToString("00", CultureInfo.InvariantCulture)}"""

                PrefixId.owlTime.prefix "generalDay"
                |> RdfLiteral.datatyped valueString


            let generalMonth (month: int) =
                // TODO find a strongly typed parse instead of validation
                // test <@ month >= 1 && month <= 20 @>
                let valueString = $"""--{month.ToString("00", CultureInfo.InvariantCulture)}"""

                PrefixId.owlTime.prefix "generalMonth"
                |> RdfLiteral.datatyped valueString


            let generalYear (year: int) =
                let valueString = year.ToString("0000", CultureInfo.InvariantCulture)

                PrefixId.owlTime.prefix "generalYear"
                |> RdfLiteral.datatyped valueString


    module Numeric =

        let private bigintValueString (value: bigint) =
            value.ToString(CultureInfo.InvariantCulture)

        let integer (value: bigint) =
            PrefixId.xsd.prefix "integer"
            |> RdfLiteral.datatyped (bigintValueString value)

        let negativeInteger (value: bigint) =
            // TODO find a strongly typed parse instead of validation
            // test <@ value < 0I @>

            PrefixId.xsd.prefix "negativeInteger"
            |> RdfLiteral.datatyped (bigintValueString value)

        let nonNegativeInteger (value: bigint) =
            // TODO find a strongly typed parse instead of validation
            // test <@ value >= 0I @>

            PrefixId.xsd.prefix "nonNegativeInteger"
            |> RdfLiteral.datatyped (bigintValueString value)

        let nonPositiveInteger (value: bigint) =
            // TODO find a strongly typed parse instead of validation
            // test <@ value <= 0I @>

            PrefixId.xsd.prefix "nonPositiveInteger"
            |> RdfLiteral.datatyped (bigintValueString value)

        let positiveInteger (value: bigint) =
            // TODO find a strongly typed parse instead of validation
            // test <@ value > 0I @>

            PrefixId.xsd.prefix "positiveInteger"
            |> RdfLiteral.datatyped (bigintValueString value)
















type SparqlResultSet with
    member this.columnByVariables(rdfVariable: RdfVariable) =
        this.Results
        |> Seq.map (fun result ->
            result.Item rdfVariable.identifier
            |> Point.fromINode)
        |> Seq.toArray

// ─────────────────────────────────────────────────────────────
// Existing dotNetRDF query-form adapters
// ─────────────────────────────────────────────────────────────

let SELECTALL () : ISelectBuilder = QueryBuilder.SelectAll()


let SELECT (variables: RdfVariable seq) : ISelectBuilder =
    variables
    |> Seq.map (fun variable -> variable.identifier)
    |> Seq.toArray
    |> QueryBuilder.Select


let CONSTRUCT (patternBuilder: TriplePatternBuilder) (formula: Formula) : IQueryBuilder =
    QueryBuilder.Construct(
        Action<IDescribeGraphPatternBuilder> (fun constructTemplate ->
            constructTemplate.Where(patternBuilder |> formula.ITriplePatterns)
            |> ignore)
    )


let ASK () : IQueryBuilder = QueryBuilder.Ask()


let DISCOVER (variables: RdfVariable seq) : IDescribeBuilder =
    variables
    |> Seq.map (fun variable -> variable.questionForm)
    |> Seq.toArray
    |> QueryBuilder.Describe


let DESCRIBE (iris: Iri seq) : SparqlQuery =
    iris
    |> Seq.map (fun iri -> iri.asUri)
    |> Seq.toArray
    |> QueryBuilder.Describe
    |> fun builder -> builder.BuildQuery()


let repairDescribeVariables (query: SparqlQuery) : SparqlQuery =
    if query.QueryType = SparqlQueryType.Describe then

        let queryVariables = query.Variables :?> Generic.ICollection<SparqlVariable>

        query.DescribeVariables
        |> Seq.filter (fun token -> token.TokenType = Token.VARIABLE)
        |> Seq.iter (fun token ->

            let variableName = token.Value.Substring(1)

            let alreadyRegistered =
                queryVariables
                |> Seq.exists (fun variable -> variable.Name = variableName)

            if not alreadyRegistered then
                queryVariables.Add(SparqlVariable(variableName, true)))

    query


let WHERE (patternBuilder: TriplePatternBuilder) (formula: Formula) (queryBuilder: IQueryBuilder) : SparqlQuery =
    queryBuilder
        .Where(patternBuilder |> formula.ITriplePatterns)
        .BuildQuery()
    |> repairDescribeVariables


let private processQuery (graph: IGraph) (query: SparqlQuery) : obj =
    let dataset = new InMemoryDataset(graph)

    let processor = new LeviathanQueryProcessor(dataset)

    processor.ProcessQuery(query)


type FromWhereDraft =
    { sourceGraph: IGraph option
      whereFormula: Formula option }


let private emptyFromWhereDraft =
    { sourceGraph = None
      whereFormula = None }


type FromWhereBuilder<'Result>(execute: IGraph -> Formula -> 'Result) =

    member _.Yield(_: unit) : FromWhereDraft = emptyFromWhereDraft

    member _.Zero() : FromWhereDraft = emptyFromWhereDraft

    member _.For(_draft: FromWhereDraft, continuation: unit -> FromWhereDraft) : FromWhereDraft = continuation ()


    [<CustomOperation("from")>]
    member _.From(draft: FromWhereDraft, graph: IGraph) : FromWhereDraft =
        match draft.sourceGraph with
        | Some _ -> invalidOp "The query already contains a source graph."

        | None -> { draft with sourceGraph = Some graph }


    [<CustomOperation("where")>]
    member _.Where(draft: FromWhereDraft, formula: Formula) : FromWhereDraft =
        match draft.whereFormula with
        | Some _ -> invalidOp "The query already contains a where clause."

        | None -> { draft with whereFormula = Some formula }


    member _.Run(draft: FromWhereDraft) : 'Result =
        let graph =
            match draft.sourceGraph with
            | Some graph -> graph

            | None -> invalidOp "The query requires a graph supplied with 'from'."


        let whereFormula =
            match draft.whereFormula with
            | Some formula -> formula

            | None -> invalidOp "The query requires a 'where' clause."


        execute graph whereFormula

type FromDraft = { sourceGraph: IGraph option }


let private emptyFromDraft = { sourceGraph = None }


type FromBuilder<'Result>(execute: IGraph -> 'Result) =

    member _.Yield(_: unit) : FromDraft = emptyFromDraft

    member _.Zero() : FromDraft = emptyFromDraft

    member _.For(_draft: FromDraft, continuation: unit -> FromDraft) : FromDraft = continuation ()


    [<CustomOperation("from")>]
    member _.From(draft: FromDraft, graph: IGraph) : FromDraft =
        match draft.sourceGraph with
        | Some _ -> invalidOp "The query already contains a source graph."

        | None -> { draft with sourceGraph = Some graph }


    member _.Run(draft: FromDraft) : 'Result =
        let graph =
            match draft.sourceGraph with
            | Some graph -> graph

            | None -> invalidOp "The query requires a graph supplied with 'from'."


        execute graph

module sparql =

    let select (variables: RdfVariable seq) : FromWhereBuilder<SparqlResultSet> =
        FromWhereBuilder<SparqlResultSet> (fun graph whereFormula ->

            let patternBuilder = TriplePatternBuilder(graph.NamespaceMap)

            let queryBuilder = SELECT variables :> IQueryBuilder

            let query =
                queryBuilder
                |> WHERE patternBuilder whereFormula

            processQuery graph query :?> SparqlResultSet)


    let selectAll: FromWhereBuilder<SparqlResultSet> =
        FromWhereBuilder<SparqlResultSet> (fun graph whereFormula ->

            let patternBuilder = TriplePatternBuilder(graph.NamespaceMap)

            let queryBuilder = SELECTALL() :> IQueryBuilder

            let query =
                queryBuilder
                |> WHERE patternBuilder whereFormula

            processQuery graph query :?> SparqlResultSet)


    let construct (constructFormula: Formula) : FromWhereBuilder<IGraph> =
        FromWhereBuilder<IGraph> (fun graph whereFormula ->

            let patternBuilder = TriplePatternBuilder(graph.NamespaceMap)

            let queryBuilder = CONSTRUCT patternBuilder constructFormula

            let query =
                queryBuilder
                |> WHERE patternBuilder whereFormula

            processQuery graph query :?> IGraph)


    let ask: FromWhereBuilder<bool> =
        FromWhereBuilder<bool> (fun graph whereFormula ->

            let patternBuilder = TriplePatternBuilder(graph.NamespaceMap)

            let query = ASK() |> WHERE patternBuilder whereFormula

            let resultSet = processQuery graph query :?> SparqlResultSet

            resultSet.Result)


    let discover (variables: RdfVariable seq) : FromWhereBuilder<IGraph> =
        FromWhereBuilder<IGraph> (fun graph whereFormula ->

            let patternBuilder = TriplePatternBuilder(graph.NamespaceMap)

            let queryBuilder = DISCOVER variables :> IQueryBuilder

            let query =
                queryBuilder
                |> WHERE patternBuilder whereFormula

            processQuery graph query :?> IGraph)


    let describe (iris: Iri seq) : FromBuilder<IGraph> =
        FromBuilder<IGraph> (fun graph ->

            let query = DESCRIBE iris

            processQuery graph query :?> IGraph)




















// variable instantiation
let (!?) (identifier: string) = RdfVariable.fromIdentifier identifier




// lexical adders

let (.*@) (lexicalForm:string) (languageTag:NLanguageTag.LanguageTag) = RdfLiteral.languageTagged lexicalForm languageTag


let (.*^) (lexicalForm:string) (datatypeIri:Iri) = RdfLiteral.datatyped lexicalForm datatypeIri
// TODO consider something for long string literals


// unary starters
let inline (!>) (subjectTerm: ^SubjectType when ^SubjectType: (member asSubject: RdfSubject)) : Formula =
    Formula.fromRdfSubject subjectTerm.asSubject

let inline (!|) (subjectTerms: ^SubjectType list when ^SubjectType: (member asSubject: RdfSubject)) : Formula =
    subjectTerms
    |> List.map (fun subjectTerm -> subjectTerm.asSubject)
    |> Formula.fromRdfSubjects

let inline (!-) (predicateTerm: ^PredicateType when ^PredicateType: (member asPredicate: RdfPredicate)) : Formula =
    Formula.fromRdfPredicate predicateTerm.asPredicate

let inline (!<) (objectTerm: ^ObjectType when ^ObjectType: (member asObject: RdfObject)) : Formula =
    Formula.fromRdfObject objectTerm.asObject

let inline (!<=) valueObject =
    RdfLiteral.autotyped valueObject
    |> RdfObject.LiteralObject
    |> Formula.fromRdfObject


// subject adders
let inline (-!>) (draft: Formula) (subjectTerm: ^SubjectType when ^SubjectType: (member asSubject: RdfSubject)) =
    draft.addRdfSubject subjectTerm.asSubject

let inline (-!|)
    (draft: Formula)
    (subjectTerms: ^SubjectType list when ^SubjectType: (member asSubject: RdfSubject))
    =
    subjectTerms
    |> List.map (fun subjectTerm -> subjectTerm.asSubject)
    |> List.toArray
    |> draft.addRdfSubjects


// predicate adders
let inline (---)
    (draft: Formula)
    (predicateTerm: ^PredicateType when ^PredicateType: (member asPredicate: RdfPredicate))
    =
    draft.addRdfPredicate predicateTerm.asPredicate

let inline (--|)
    (draft: Formula)
    (predicateTerms: ^PredicateType list when ^PredicateType: (member asPredicate: RdfPredicate))
    =
    predicateTerms
    |> List.toArray
    |> Array.Parallel.map (fun predicateTerm -> predicateTerm.asPredicate)
    |> draft.addRdfPredicates

// predicateObjectList adders
let inline (-~|) (draft: Formula) (predicateObjectLists: PredicateObjectList list) =
    predicateObjectLists
    |> List.toArray
    |> draft.addPredicateObjectLists

let inline (-~|>) (draft: Formula) (predicateObjectLists: PredicateObjectList list) =
    predicateObjectLists
    |> List.toArray
    |> draft.addPredicateObjectLists
    |> Formula.materializeFormula


let inline (->-)
    (predicate: ^PredicateType when ^PredicateType: (member asPredicate: RdfPredicate))
    (object: ^ObjectType when ^ObjectType: (member asObject: RdfObject))
    =
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
    PredicateObjectList.fromTerms
        predicate.asPredicate
        [| RdfLiteral.autotyped valueObject
           |> RdfObject.LiteralObject |]


let inline (->=|) (predicate: ^PredicateType when ^PredicateType: (member asPredicate: RdfPredicate)) valueObjects =
    let objects =
        valueObjects
        |> List.map (fun valueObject ->
            RdfLiteral.autotyped valueObject
            |> RdfObject.LiteralObject)
        |> List.toArray

    PredicateObjectList.fromTerms predicate.asPredicate objects


let inline (-->) (draft: Formula) (objectTerm: ^ObjectType when ^ObjectType: (member asObject: RdfObject)) =
    draft.addRdfObject objectTerm.asObject
    |> Formula.materializeFormula

let inline (-<-) (draft: Formula) (subjectTerm: ^SubjectType when ^SubjectType: (member asSubject: RdfSubject)) =
    draft.addRdfSubject subjectTerm.asSubject
    |> Formula.materializeFormula

let inline (-<-/) (draft: Formula) (subjectTerm: ^SubjectType when ^SubjectType: (member asSubject: RdfSubject)) =
    let materializedDraft =
        draft.addRdfSubject subjectTerm.asSubject
        |> Formula.materializeFormula

    { materializedDraft with

        subjects = [| subjectTerm.asSubject |]

     }

let inline (-->/) (draft: Formula) (objectTerm: ^ObjectType when ^ObjectType: (member asObject: RdfObject)) =
    let materializedDraft =
        draft.addRdfObject objectTerm.asObject
        |> Formula.materializeFormula

    { materializedDraft with

        subjects =
            match objectTerm.asObject.maybeSubject with
            | Some subject -> [| subject |]
            | None -> [||]

     }

let inline (-->=) (draft: Formula) literal =
    draft.addRdfLiteral literal
    |> Formula.materializeFormula

let inline (-->^) (draft: Formula) (lexicalForm: string) (datatype: Iri) =
    draft.addRdfLiteral (lexicalForm .*^ datatype)
    |> Formula.materializeFormula

let inline (-->@) (draft: Formula) (lexicalForm: string) (languageTag: NLanguageTag.LanguageTag) =
    lexicalForm .*@ languageTag
    |> draft.addRdfLiteral
    |> Formula.materializeFormula



let inline (-->=|) (draft: Formula) literals =
    draft.addRdfLiterals literals
    |> Formula.materializeFormula

let inline (-->^|) (draft: Formula) (lexicalForms: string list) (datatype: Iri) =
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

/// formulas

let inline (-*|) (draft: Formula) (formulaList: Formula list) =
    formulaList
    |> draft.addFormulas
    |> Formula.materializeFormula



























type RdfVocabulary = 
    {
        prefixId : PrefixId
        document : RdfDocument
    }
    
    static member fromPrefixId (prefixId :PrefixId) = 
        namespaceMapper.AddNamespace(prefixId.asNamespaceMap)
        {
            prefixId =  prefixId
            document = { rdfFile = prefixId.directory.GetFiles($"*.ttl", SearchOption.AllDirectories) |> Array.exactlyOne }
        }
    member inline this.maybeOntologyClass<'Term when 'Term : (member asINode:INode)> (term:'Term) =  this.document.asOntologyGraph.AllClasses |> Seq.tryFind (fun ontologyClass -> ontologyClass.Resource = term.asINode )
    member inline this.maybeOntologyProperty<'Term when 'Term : (member asINode:INode)> (term:'Term) =  this.document.asOntologyGraph.AllProperties |> Seq.tryFind (fun ontologyProperty -> ontologyProperty.Resource = term.asINode )
    member this.OntologyClasses = this.document.asOntologyGraph.AllClasses |> Seq.toArray
    member this.OntologyProperties = this.document.asOntologyGraph.AllProperties |> Seq.toArray
    member this.RdfClasses = this.document.asOntologyGraph.RdfClasses |> Seq.toArray
    member this.RdfProperties = this.document.asOntologyGraph.RdfProperties |> Seq.toArray
    member this.OwlClasses = this.document.asOntologyGraph.OwlClasses |> Seq.toArray
    member this.OwlProperties = this.document.asOntologyGraph.OwlProperties |> Seq.toArray
    member this.OwlDatatypeProperties = this.document.asOntologyGraph.OwlDatatypeProperties |> Seq.toArray
    member this.OwlObjectProperties = this.document.asOntologyGraph.OwlObjectProperties |> Seq.toArray
    member this.OwlAnnotationProperties = this.document.asOntologyGraph.OwlAnnotationProperties |> Seq.toArray
    member this.AllOntologyResources = 
        Array.concat [|
            this.OntologyClasses |> Array.map (fun ontologyClass -> ontologyClass :> OntologyResource)
            this.OntologyProperties  |> Array.map (fun ontologyProperty -> ontologyProperty :> OntologyResource)
            |]
    member inline this.OntologyResourceByTerm<'Term when 'Term : (member asINode:INode)> (term:'Term) =   this.AllOntologyResources |> Array.tryFind (fun ontologyResource -> ontologyResource.Resource = term.asINode  ) 
    member inline this.termComment<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> ontologyResource.Comment |> Seq.map (fun iliteralNode -> RdfLiteral.fromILiteralNode iliteralNode ) |> Seq.toArray
        | None -> [||]
    member inline this.termDifferentFrom<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> ontologyResource.DifferentFrom |> Seq.map (fun inode -> Point.fromINode inode ) |> Seq.toArray
        | None -> [||]
    member inline this.termDirectSubClasses<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.DirectSubClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termDirectSubProperties<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.DirectSubProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termDirectSuperClasses<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.DirectSuperClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termDirectSuperProperties<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.DirectSuperProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termDisjointClasses<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.DisjointClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termDomains<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.Domains |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termRanges<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.Ranges |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termEquivalentClasses<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.EquivalentClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termEquivalentProperties<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.EquivalentProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIndirectSubClasses<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.IndirectSubClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIndirectSuperClasses<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.IndirectSuperClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIndirectSubProperties<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.IndirectSubProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIndirectSuperProperties<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.IndirectSuperProperty |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termInverseProperties<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.InverseProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termInstances<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.Instances |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIsBottomClass<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.IsBottomClass
            | _ -> false
        | None -> false
    member inline this.termIsBottomProperty<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.IsBottomProperty
            | _ -> false
        | None -> false
    member inline this.termIsDefinedBy<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> ontologyResource.IsDefinedBy |> Seq.map (fun inode -> Point.fromINode inode ) |> Seq.toArray
        | None -> [||]
    member inline this.termIsDomainOf<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.IsDomainOf |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIsRangeOf<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.IsRangeOf |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIsTopClass<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.IsTopClass
            | _ -> false
        | None -> false
    member inline this.termIsTopProperty<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.IsTopProperty
            | _ -> false
        | None -> false
    member inline this.termLabel<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> ontologyResource.Label |> Seq.map (fun iliteralNode -> RdfLiteral.fromILiteralNode iliteralNode ) |> Seq.toArray
        | None -> [||]
    member inline this.termSameAs<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> ontologyResource.SameAs |> Seq.map (fun inode -> Point.fromINode inode ) |> Seq.toArray
        | None -> [||]
    member inline this.termSeeAlso<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> ontologyResource.SeeAlso |> Seq.map (fun inode -> Point.fromINode inode ) |> Seq.toArray
        | None -> [||]
    member inline this.termSiblingClasses<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.Siblings |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termSiblingProperties<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.Siblings |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termUsedBy<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.UsedBy |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termSubClasses<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.SubClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termSuperClasses<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.SuperClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termSubProperties<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.SubProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termSuperProperties<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.SuperProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termTriples<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with
        | Some ontologyResource -> ontologyResource.Triples |> Seq.map (fun vdsTriple -> RdfTriple.fromVDSTriple vdsTriple ) |> Seq.toArray
        | None -> [||]
    member inline this.termTriplesWithObject<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with
        | Some ontologyResource -> ontologyResource.TriplesWithObject |> Seq.map (fun vdsTriple -> RdfTriple.fromVDSTriple vdsTriple ) |> Seq.toArray
        | None -> [||]
    member inline this.termTriplesWithPredicate<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with
        | Some ontologyResource -> ontologyResource.TriplesWithPredicate |> Seq.map (fun vdsTriple -> RdfTriple.fromVDSTriple vdsTriple ) |> Seq.toArray
        | None -> [||]
    member inline this.termTriplesWithSubject<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with
        | Some ontologyResource -> ontologyResource.TriplesWithSubject |> Seq.map (fun vdsTriple -> RdfTriple.fromVDSTriple vdsTriple ) |> Seq.toArray
        | None -> [||]
    member inline this.termTriplesWithLiteralObject<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        this.termTriplesWithSubject term
        |> Array.filter (fun triple -> triple.curObject.IsLiteralObject)
    member inline this.termTriplesWithIriObject<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        this.termTriplesWithSubject term
        |> Array.filter (fun triple -> triple.curObject.IsIriObject)
    member inline this.termTriplesWithBlankObject<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        this.termTriplesWithSubject term
        |> Array.filter (fun triple -> triple.curObject.IsBlankObject)
        
    member inline this.termTriplesWithReferenceObject<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        Array.concat [|
            this.termTriplesWithIriObject term
            this.termTriplesWithBlankObject term
        |]
    member inline this.termTypes<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with
        | Some ontologyResource -> ontologyResource.Types |> Seq.map (fun inode -> Point.fromINode inode ) |> Seq.toArray
        | None -> [||]
    member inline this.termVersionInfo<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with
        | Some ontologyResource -> ontologyResource.VersionInfo |> Seq.map (fun iliteralNode -> RdfLiteral.fromILiteralNode iliteralNode ) |> Seq.toArray
        | None -> [||]


    member inline this.ontologyClassesByMetaClass<'Term when 'Term : (member asINode:INode)> (metaClass:'Term) = this.document.asOntologyGraph.GetClasses metaClass.asINode |> Seq.toArray
    member this.namespacedNames = this.document.namespacedNames this.prefixId
    member this.termByName = 
        this.namespacedNames 
        |> Array.map (fun prefixedName -> prefixedName.localName, prefixedName )
        |> Map.ofArray



module RdfVocabulary = 
    open XmlComment
    
    let asModule(vocabulary:RdfVocabulary) = 

        Ast.Oak() {
              Ast.AnonymousModule(){

                Ast.Module(vocabulary.prefixId.prefixLabel){
                    for namespacedName in vocabulary.namespacedNames do 
                        
                        let binding = 
                          match namespacedName.localName with 
                          | "" -> "_namespaceIri"
                          | _ -> 
                              let binder = VariableBinder namespacedName.localName
                              binder.binding
                        let astValue = Ast.Value(binding, $"{vocabulary.prefixId.prefixLabel}Vocabulary.prefixId.prefix \"{namespacedName.localName}\"" )
                        let triplesWithLiteralObject = vocabulary.termTriplesWithLiteralObject namespacedName

                        if triplesWithLiteralObject |> _.Length > 0 then 

                            let datatypePropertyValues = 
                                triplesWithLiteralObject    
                                |> Array.groupBy (fun triple -> triple.curPredicate)
                                |> Array.map (fun (curPredicate, triples) -> curPredicate, triples |> Array.map (fun triple -> triple.curObject))
                            let elements :XmlPart array = 
                                    [|

                                        summary {
                                            for datatypeProperty, propertyValues in datatypePropertyValues do  
                                                match datatypeProperty.lexicalForm with 

                                                | _ -> 
                                                      para { 
                                                            for propertyValue in propertyValues do 
                                                                $"{defaultArg datatypeProperty.maybeCurie datatypeProperty.lexicalForm} : {defaultArg propertyValue.maybeCurie propertyValue.lexicalForm}"
                                                      }
                                                                
                                            a {
                                                _href namespacedName.lexicalForm
                                                namespacedName.curie
                                            }
                                        }
                                    |]


                            astValue.xmlDocs( ElementBuilder.writeToXmlDocs elements )
                        else 
                            astValue


              }
              }
        }
        |> Gen.mkOak
        |> Gen.run




let rdfDocuments = Folder.DoxAletheia.DescendantFiles("*.ttl") |> Array.Parallel.map (fun rdfFile -> { rdfFile = rdfFile } )
let owlDocuments = 
  rdfDocuments |> Array.Parallel.choose (fun rdfDocument -> 
      try 
          match rdfDocument.asOWLOntology with 
          | _ -> Some rdfDocument
      with 
      | _ -> None
        )


type NamespaceMapper with 
    member this.GetPrefixId (prefix :string) = 
                                      {
                                        prefixLabel = prefix
                                        namespaceName = this.GetNamespaceUri prefix |> _.OriginalString

                                      }
    member this.prefixIds = 
            this.Prefixes
            |> Seq.map (fun prefix -> 
                                      {
                                        prefixLabel = prefix
                                        namespaceName = this.GetNamespaceUri prefix |> _.OriginalString

                                      }
            )
            |> Set.ofSeq
          
          









(*

namespaceMapper.AddNamespace ("dcterms", Uri "http://purl.org/dc/terms/11")
namespaceMapper.GetNamespaceUri "dcterms"
RDFNamespaceRegister.GetByPrefix "rdf"
type RDFNamespaceRegister with 
    static member rdfNamespaces = RDFNamespaceRegister.Instance |> Seq.cast<RDFNamespace> |> Seq.toArray
    static member hasPrefixRegistered(prefix:string) = RDFNamespaceRegister.rdfNamespaces |> Array.exists (fun rdfNamespace -> rdfNamespace.NamespacePrefix = prefix)
    static member hasNamespaceNameRegistered(namespaceName:string) = RDFNamespaceRegister.rdfNamespaces |> Array.exists (fun rdfNamespace -> rdfNamespace.NamespaceUri.OriginalString= namespaceName)
    static member maybePrefixIdCollision (prefixId:PrefixId) = 
        match RDFNamespaceRegister.GetByPrefix prefixId.prefixLabel, RDFNamespaceRegister.GetByUri prefixId.namespaceName with 
        | namespaceFromPrefix, namespaceFromName when prefixId.asRDFNamespace = namespaceFromPrefix && prefixId.asRDFNamespace = namespaceFromName -> None
        | namespaceFromPrefix, namespaceFromName -> Some(namespaceFromPrefix, namespaceFromName)

RDFNamespaceRegister.rdfNamespaces |> Array.iter (fun rdfNamespace -> printfn "%s" rdfNamespace.NamespaceUri.OriginalString)
RDFNamespaceRegister.GetByUri("http://purl.org/dc/terms/", true)
RDFNamespaceRegister.hasPrefixRegistered "rdf"



let randomRdfDocument = rdfDocuments |> Array.randomChoice
let test = randomRdfDocument.asRDFGraph.triples[0]
randomRdfDocument.asRDFGraph.SelectTriples()
// TODO figure out why OWLOntology is throwing

randomRdfDocument.rdfFile.FullName |> clip
randomRdfDocument.points[0]
randomRdfDocument.asOntologyGraph
randomRdfDocument.asOntologyGraph.RdfClasses
randomRdfDocument.asOntologyGraph.OwlClasses
let randomRdfClass = randomRdfDocument.asOntologyGraph.RdfClasses  |> Seq.toArray |> Array.randomChoice
randomRdfClass





let randomRdfTerm = randomRdfDocument.points |> Array.randomChoice
let randomIri = randomRdfDocument.points
randomRdfTerm.maybeCurie





















type ModelElement<'ElementType when 'ElementType : comparison> =
  {
    id:string
    members : 'ElementType array
  }
  member this.elementType = typeof<'ElementType>
  static member fromElement(element:'ElementType) = 
    {
      id = element.GetType().Name
      members = [|element|]
    }

type Model<'ElementType when 'ElementType : comparison> = 
    {
      elements :Set<ModelElement<'ElementType>>
      subelements :'ElementType * Set<'ElementType>
      superelements : 'ElementType *'ElementType
      typeToElement : Type * 'ElementType
    }
    member this.findElement (name:string) =
      this.elements
      |> Set.toArray
      |> Array.tryFind (fun modelElement -> modelElement.elementType.Name = name)
    member this.asString = sprintf "MODEL %A" this.elements
type LanguageMember<'ElementType when 'ElementType : comparison> = 
    {
      modelElement:ModelElement<'ElementType>
      isOptional:bool
      isKey:bool
      isReference:bool
      prefix : Parser<string, Rune,unit, ReadableMemory<Rune>> array
      suffix : Parser<string, Rune,unit, ReadableMemory<Rune>> array
      separator : Parser<string, Rune,unit, ReadableMemory<Rune>> array
      evaluator : unit -> 'ElementType
    }



*)





[<CLIMutable>]
type ForceNode = { id: string }


[<CLIMutable>]
type ForceLink =
    { source: string
      target: string
      predicate: string }
    static member typeName = "ForceLink"

type RdfTripleSet with 

    member this.forceLinks =

        this.triples
        |> Array.ofSeq
        |> Array.map (fun triple ->
            { source = triple.curSubject.lexicalForm
              target = triple.curObject.lexicalForm
              predicate = triple.curPredicate.lexicalForm })

    member this.forceNodes =
        this.forceLinks
        |> Array.collect (fun link -> [| link.source; link.target |])
        |> Array.distinct
        |> Array.map (fun id -> { id = id })

/// https://github.com/vasturiano/force-graph
[<CLIMutable>]
type ForceGraph =
    {

      nodes: ForceNode array
      links: ForceLink array

     }
    static member typeName = "ForceGraph"

    static member fromRdfTripleSet(rdfTripleSet: RdfTripleSet) =
        { nodes = rdfTripleSet.forceNodes
          links = rdfTripleSet.forceLinks }

type TextualSyntax =
    {

      syntaxName: string
      fileExtension: string

     }
    member this.mimeType = MimeString.FromFileName this.fileExtension
    member this.filePath parentDirectory stem =
        Directory.CreateDirectory(parentDirectory)
        |> ignore

        Path.Combine(parentDirectory, stem + this.fileExtension)





module NTriples =

    let syntax =
        { syntaxName = "NTriples"
          fileExtension = ".nt"

        }


    let parser = NTriplesParser()

    let parse (text: string) (graph: IGraph) =
        try
            use reader = new StringReader(text)
            parser.Load(graph, reader)
        with
        | err ->

            failwithf "The text %s failed to parse with error %s" text err.Message




NTriples.syntax.mimeType

type YoGraph = Graph<Vertex, Edge>


module YoGraph =
    let fromRdfTripleSet (rdfTripleSet: RdfTripleSet) =
        rdfTripleSet.triples
        |> Array.ofSeq
        |> Array.Parallel.map (fun triple ->
            SubjectVertex triple.curSubject, ObjectVertex triple.curObject, PredicateEdge triple.curPredicate)
        |> Array.toList
        |> Labeled.fromList Directed
        |> Labeled.toGraph


type QuikEdge = TaggedEdge<Vertex, Edge>
type QuikGraph = BidirectionalGraph<Vertex, QuikEdge>

module QuikGraph =
    let fromRdfTripleSet (rdfTripleSet: RdfTripleSet) =
        let quikGraph = new QuikGraph()

        rdfTripleSet.triples
        |> Array.ofSeq
        |> Array.map (fun triple ->
            quikGraph.AddVerticesAndEdge(
                new QuikEdge(
                    SubjectVertex triple.curSubject,
                    ObjectVertex triple.curObject,
                    PredicateEdge triple.curPredicate
                )
            ))
        |> ignore

        quikGraph



type IGraph with

    member this.mapPrefixes () =
        this.AllNodes
        |> Seq.iter(fun (inode) -> 
            match Point.fromINode inode with 
            | IriPoint (PrefixedIri prefixedName) -> this.NamespaceMap.AddNamespace prefixedName.prefixId.asNamespaceMap
            | _ -> ()
        )
    static member fromRdfTripleSet (rdfTripleSet :RdfTripleSet) = 
        let graph = new ThreadSafeGraph()
        graph.Assert( rdfTripleSet.triples |> Seq.map (fun triple -> triple.asVDSTriple)) |> ignore
        graph



module Turtle =
    let syntax =
        { syntaxName = "Turtle"
          fileExtension = ".ttl" }


    let private isValidPrefixedNameRelaxed (s: string) =
        if s.Contains(".") then
            true
        else
            TurtleSpecsHelper.IsValidQName(s)

    let private percentEncodeCharUtf8 (ch: char) =
        Encoding.UTF8.GetBytes([| ch |])
        |> Seq.map (fun b -> "%" + b.ToString("X2"))
        |> String.concat ""

    let private isForbiddenInTurtleIriRef (ch: char) =
        let code = int ch

        code <= 0x20
        || code = 0x7F
        || ch = '<'
        || ch = '>'
        || ch = '"'
        || ch = '{'
        || ch = '}'
        || ch = '|'
        || ch = '^'
        || ch = '`'
        || ch = '\\'

    let private escapeIriRefByPercentEncoding (iri: string) =
        let sb = System.Text.StringBuilder(iri.Length)

        for ch in iri do
            if isForbiddenInTurtleIriRef ch then
                sb.Append(percentEncodeCharUtf8 ch) |> ignore
            else
                sb.Append(ch) |> ignore

        sb.ToString()

    let private formatIriRefFromOriginalString (uri: Uri) =
        "<"
        + escapeIriRefByPercentEncoding uri.OriginalString
        + ">"

    let private isAsciiSafeLocal (local: string) =
        if String.IsNullOrEmpty(local) then
            false
        else
            let isStartOk ch = Char.IsLetterOrDigit(ch) || ch = '_'

            let isRestOk ch =
                Char.IsLetterOrDigit(ch)
                || ch = '_'
                || ch = '-'
                || ch = '.'

            isStartOk local.[0]
            && local |> Seq.forall isRestOk

    let private isValidLocalName (local: string) =
        if String.IsNullOrEmpty(local) then
            false
        elif local.Contains("/") then
            false
        else
            TurtleSpecsHelper.IsValidQName("p:" + local)
            || isAsciiSafeLocal local

    let private tryReduceToPrefixOnly (nsMap: INamespaceMapper) (uriOriginal: string) =
        nsMap.Prefixes
        |> Seq.tryPick (fun (p: string) ->
            let nsUri = nsMap.GetNamespaceUri(p)

            if isNull (box nsUri) then
                None
            else
                let ns = nsUri.OriginalString

                if uriOriginal.Equals(ns, StringComparison.Ordinal) then
                    Some(p + ":")
                else
                    None)

    let private tryReduceToPrefixedNameLongest (nsMap: INamespaceMapper) (uriOriginal: string) : string option =
        let candidates: (string * string) list =
            nsMap.Prefixes
            |> Seq.choose (fun (p: string) ->
                let nsUri = nsMap.GetNamespaceUri(p)

                if isNull (box nsUri) then
                    None
                else
                    Some(p, nsUri.OriginalString))
            |> Seq.filter (fun (_pfx: string, ns: string) -> uriOriginal.StartsWith(ns, StringComparison.Ordinal))
            |> Seq.sortByDescending (fun (_pfx: string, ns: string) -> ns.Length)
            |> Seq.toList

        let rec pick (xs: (string * string) list) =
            match xs with
            | [] -> None
            | (pfx, ns) :: rest ->
                let local = uriOriginal.Substring(ns.Length)

                if isValidLocalName local then
                    Some(pfx + ":" + local)
                else
                    pick rest

        pick candidates

    let private tryReduceToPrefixedName (nsMap: INamespaceMapper) (uriOriginal: string) =
        match tryReduceToPrefixOnly nsMap uriOriginal with
        | Some p -> Some p
        | None -> tryReduceToPrefixedNameLongest nsMap uriOriginal

    type UnicodePrefixedNameTurtleW3CFormatter(g: IGraph) =
        inherit TurtleW3CFormatter(g)

        override _.IsValidQName(value: string) = isValidPrefixedNameRelaxed value

        override _.FormatUriNode(u: IUriNode, segment: Nullable<TripleSegment>) =
            let uri = u.Uri

            if
                segment.HasValue
                && segment.Value = TripleSegment.Predicate
                && uri.AbsoluteUri.Equals((PrefixId.rdf.prefix "type").identity, StringComparison.Ordinal)
            then
                "a"
            else
                match tryReduceToPrefixedName g.NamespaceMap uri.OriginalString with
                | Some prefixedName -> prefixedName
                | None -> formatIriRefFromOriginalString uri

    let private writeAllPrefixes (tw: TextWriter) (g: IGraph) =
        g.NamespaceMap.Prefixes
        |> Seq.sort
        |> Seq.iter (fun p ->
            let ns = g.NamespaceMap.GetNamespaceUri(p)
            tw.Write("@prefix ")
            tw.Write(p)
            tw.Write(": <")
            tw.Write(ns.OriginalString)
            tw.WriteLine("> ."))

        tw.WriteLine()

    let writeIgraph (parentDirectory: string) (stem: string) (graph: VDS.RDF.IGraph) =
        graph.mapPrefixes()

        use fileStream =
            new FileStream(syntax.filePath parentDirectory stem, FileMode.Create, FileAccess.Write, FileShare.Read)

        use streamWriter = new StreamWriter(fileStream, new UTF8Encoding(false))

        writeAllPrefixes streamWriter graph

        let formatter = UnicodePrefixedNameTurtleW3CFormatter(graph) :> ITripleFormatter

        for triple in graph.Triples do
            streamWriter.WriteLine(formatter.Format(triple))

        streamWriter.Flush()

    (*

    let writer =
        let writer = new CompressingTurtleWriter(TurtleSyntax.W3C)
        writer.HighSpeedModePermitted <- false
        writer.PrettyPrintMode <- true
        writer

    let writeIgraph (parentDirectory: string) (stem: string) (graph: VDS.RDF.IGraph) =
        mapPrefixes graph
        writer.Save(graph, syntax.filePath parentDirectory stem)

*)
    let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) =
        let filePath = syntax.filePath parentDirectory stem

        { triples = draft.triples }
        |> IGraph.fromRdfTripleSet
        |> writeIgraph parentDirectory stem



module JsonLd =
    let syntax =
        { syntaxName = "JsonLd"
          fileExtension = ".jsonld" }
    let triplestoreFromIgraph (outputPath: string) (graph: IGraph) =
        let store = new TripleStore()

        store.Add(graph) |> ignore

        let writer = JsonLdWriter()
        writer.Save(store, outputPath)
        store

    let private contextFromGraph (graph: IGraph) =
        let context = JObject()

        for prefix in graph.NamespaceMap.Prefixes do
            let namespaceIri =
                graph
                    .NamespaceMap
                    .GetNamespaceUri(
                        prefix
                    )
                    .AbsoluteUri

            if String.IsNullOrEmpty(prefix) then
                // Turtle's default prefix corresponds most closely to @vocab.
                context["@vocab"] <- JValue(namespaceIri)
            else
                let prefixDefinition = JObject()

                prefixDefinition["@id"] <- JValue(namespaceIri)

                prefixDefinition["@prefix"] <- JValue(true)

                context[prefix] <- prefixDefinition

        context

    let compactedFromIgraph (graph: IGraph) =
        let store = new TripleStore()
        store.Add(graph) |> ignore

        let expandedJsonLd = JsonLdWriter().SerializeStore(store)

        let context = contextFromGraph graph

        let options = JsonLdProcessorOptions()
        options.Ordered <- true

        JsonLdProcessor.Compact(expandedJsonLd, context, options)
        |> _.ToString(Formatting.Indented)

    let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) = 
        let fileText = 
            { triples = draft.triples }
            |> IGraph.fromRdfTripleSet
            |> compactedFromIgraph

        let filePath = syntax.filePath parentDirectory stem
        File.WriteAllText(filePath, fileText)
module JsonRq =
    
    let syntax = 
        { syntaxName = "SPARQL Results JSON"
          fileExtension = ".rq.json" }
    let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) =
        let filePath = syntax.filePath parentDirectory stem
        let store = new TripleStore()

        store.Add({ triples = draft.triples } |> IGraph.fromRdfTripleSet) |> ignore

        let dataset =
            new InMemoryDataset(store)

        let query =
            SparqlQueryParser().ParseFromString(
                """
                SELECT ?source ?predicate ?target
                WHERE {
                    ?source ?predicate ?target
                }
                """
            )

        let processor =
            new LeviathanQueryProcessor(dataset)

        let results =
            processor.ProcessQuery(query)
            :?> SparqlResultSet

        SparqlJsonWriter().Save(
            results,
            filePath
        )
module ddot =
    module it =
        let syntax =
            { syntaxName = "ddot.it"
              fileExtension = ".ddot" }

        let tripleDdot (rdfTriple: RdfTriple) =
            sprintf
                "%s..%s..%s"
                (defaultArg rdfTriple.curSubject.maybeCurie rdfTriple.curSubject.lexicalForm)
                (defaultArg rdfTriple.curPredicate.maybeCurie rdfTriple.curPredicate.lexicalForm)
                (defaultArg rdfTriple.curObject.maybeCurie rdfTriple.curObject.lexicalForm)

        let graphLines (rdfTripleSet: RdfTripleSet) =
            rdfTripleSet.triples
            |> Array.ofSeq
            |> Array.Parallel.map (fun triple -> tripleDdot triple)

        let graphText (rdfTripleSet: RdfTripleSet) =
            rdfTripleSet |> graphLines |> String.concat "\n"

        let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) =
            let fileText = { triples = draft.triples } |> graphText

            let filePath = syntax.filePath parentDirectory stem
            File.WriteAllText(filePath, fileText)



module Dot =

    let syntax =
        { syntaxName = "Graphviz"
          fileExtension = ".dot" }

    let prefixDelimiter = ":"

    let vertexDot (vertex: Vertex)  =
        vertex.asRenderedString prefixDelimiter 

    let edgeDot (edge: Edge)  =
        edge.asRenderedString prefixDelimiter 

    let yogOptions: Dot.Options<Vertex, Edge> =
        {

          NodeLabel = (fun _ vertex -> vertexDot vertex )
          EdgeLabel = (fun edge -> edgeDot edge )
          HighlightedSourceNodes = Set.empty
          HighlightedSinkNodes = Set.empty
          HighlightedNodes = Set.empty
          HighlightedEdges = Set.empty
          NodeShape = "ellipse"
          HighlightColor = "red"

        }


    let writeYograph (parentDirectory: string) (stem: string) (yograph: YoGraph) =
        let filePath = syntax.filePath parentDirectory stem
        Dot.writeFile filePath yogOptions  yograph

    let writeQuikGraph (parentDirectory: string) (stem: string) (quikGraph: QuikGraph) =
        let dotGraph = new GraphvizAlgorithm<Vertex, QuikEdge>(quikGraph)

        dotGraph.FormatVertex.Add (fun args ->

            args.VertexFormat.Label <- (vertexDot args.Vertex)

        )

        dotGraph.FormatEdge.Add (fun args ->

            args.EdgeFormat.Label.Value <- (edgeDot args.Edge.Tag)

        )



        dotGraph.Generate(new FileDotEngine(), (syntax.filePath parentDirectory stem))
        |> ignore

    let writeDraftFromYograph (parentDirectory: string) (stem: string)  (draft: Formula) =
        { triples = draft.triples }
        |> YoGraph.fromRdfTripleSet
        |> writeYograph parentDirectory $"{stem}.yog" 

    let writeDraftFromQuikGraph (parentDirectory: string) (stem: string)  (draft: Formula) =
        { triples = draft.triples }
        |> QuikGraph.fromRdfTripleSet
        |> writeQuikGraph parentDirectory $"{stem}.quik" 

    let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) =
        draft
        |> writeDraftFromYograph parentDirectory stem 

        draft
        |> writeDraftFromQuikGraph parentDirectory stem 

module Mermaid =

    let syntax =
        { syntaxName = "Mermaid"
          fileExtension = ".mmd" }

    let prefixDelimiter = ":"

    let vertexMmd (vertex: Vertex) =
        vertex.asRenderedString prefixDelimiter 

    let edgeMmd (edge: Edge) =
        edge.asRenderedString prefixDelimiter 

    let options : Mermaid.Options<Vertex, Edge> =
        {

          Direction = "LR"
          NodeLabel = (fun vertexId vertex -> vertexMmd vertex )
          EdgeLabel = (fun edge -> edgeMmd edge )
          HighlightedEdges = Set.empty
          HighlightedNodes = Set.empty
          HighlightedSinkNodes = Set.empty
          HighlightedSourceNodes = Set.empty

        }

    let writeYograph (parentDirectory: string) (stem: string)  yograph =
        let filePath = syntax.filePath parentDirectory stem
        Mermaid.writeFile filePath options  yograph

    let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) =
        { triples = draft.triples }
        |> YoGraph.fromRdfTripleSet
        |> writeYograph parentDirectory stem 



module d2 =
    let syntax =
        { syntaxName = "d2"
          fileExtension = ".d2" }

    let prefixDelimiter = "\\:"

    let vertexD2 (vertex: Vertex) =
        vertex.asRenderedString prefixDelimiter 

    let edgeD2 (edge: Edge) =
        edge.asRenderedString prefixDelimiter 

    let graphLines  (rdfTripleSet: RdfTripleSet) =
        rdfTripleSet.triples
        |> Array.ofSeq
        |> Array.Parallel.map (fun triple ->
            SubjectVertex triple.curSubject, ObjectVertex triple.curObject, PredicateEdge triple.curPredicate)
        |> Array.Parallel.map (fun (inVertex, outVertex, outEdge) ->
            sprintf "%s -> %s : %s" (vertexD2 inVertex ) (vertexD2 outVertex ) (edgeD2 outEdge ))

    let graphText (rdfTripleSet: RdfTripleSet) =
        rdfTripleSet |> graphLines |> String.concat "\n"

    let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) =
        let fileText = { triples = draft.triples } |> graphText 

        let filePath = syntax.filePath parentDirectory stem
        File.WriteAllText(filePath, fileText)

module ForceGraph2D = 
    let syntax =
        { syntaxName = "2d force-graph"
          fileExtension = ".force-graph.2d.json" }
    
    let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) =
        let fileText = Json.serialize({ triples = draft.triples } |> ForceGraph.fromRdfTripleSet )

        let filePath = syntax.filePath parentDirectory stem
        File.WriteAllText(filePath, fileText)








module Formula =
    let materializeTriples (draft: Formula) = draft.materializeTriples
    let emitTriples (draft: Formula) = draft.triples
    let toRdfGraph (draft: Formula) = { triples = draft.triples }

    let toIgraph (draft: Formula) =
        draft |> toRdfGraph |> IGraph.fromRdfTripleSet

let writeDraft  parentDirectory stem  draft =
    Turtle.writeDraft parentDirectory stem draft
    Dot.writeDraft parentDirectory stem  draft
    ddot.it.writeDraft parentDirectory stem draft
    Mermaid.writeDraft parentDirectory stem  draft
    d2.writeDraft parentDirectory stem  draft
    JsonLd.writeDraft parentDirectory stem draft
    JsonRq.writeDraft parentDirectory stem draft
    ForceGraph2D.writeDraft parentDirectory stem draft




























































module PrefixId = 
      let foaf = PrefixId.fromNamespaceLabel "http://xmlns.com/foaf/0.1/" "foaf" 
      let vs = PrefixId.fromNamespaceLabel "http://www.w3.org/2003/06/sw-vocab-status/ns#" "vs" 

let rdfVocabulary = RdfVocabulary.fromPrefixId PrefixId.rdf
let rdfsVocabulary = RdfVocabulary.fromPrefixId PrefixId.rdfs
let owlVocabulary = RdfVocabulary.fromPrefixId PrefixId.owl
let foafVocabulary = RdfVocabulary.fromPrefixId PrefixId.foaf
let vsVocabulary = RdfVocabulary.fromPrefixId PrefixId.vs








(*


[|
    RdfVocabulary.asModule rdfVocabulary
    RdfVocabulary.asModule rdfsVocabulary
    RdfVocabulary.asModule owlVocabulary
    RdfVocabulary.asModule foafVocabulary
    RdfVocabulary.asModule vsVocabulary
|]
|> String.concat "\n"
|> clip

*)


module rdf =
    let _namespaceIri = rdfVocabulary.prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : The class of containers of alternatives.^^xsd:string</para>
    ///   <para>rdfs:label : Alt^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt">rdf:Alt</a>
    /// </summary>
    let Alt = rdfVocabulary.prefixId.prefix "Alt"
    /// <summary>
    ///   <para>rdfs:comment : The class of unordered containers.^^xsd:string</para>
    ///   <para>rdfs:label : Bag^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag">rdf:Bag</a>
    /// </summary>
    let Bag = rdfVocabulary.prefixId.prefix "Bag"
    /// <summary>
    ///   <para>rdfs:comment : A class representing a compound literal.^^xsd:string</para>
    ///   <para>rdfs:label : CompoundLiteral^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#CompoundLiteral">rdf:CompoundLiteral</a>
    /// </summary>
    let CompoundLiteral = rdfVocabulary.prefixId.prefix "CompoundLiteral"
    let HTML = rdfVocabulary.prefixId.prefix "HTML"
    let JSON = rdfVocabulary.prefixId.prefix "JSON"
    /// <summary>
    ///   <para>rdfs:comment : The class of RDF Lists.^^xsd:string</para>
    ///   <para>rdfs:label : List^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#List">rdf:List</a>
    /// </summary>
    let List = rdfVocabulary.prefixId.prefix "List"
    let PlainLiteral = rdfVocabulary.prefixId.prefix "PlainLiteral"
    /// <summary>
    ///   <para>rdfs:comment : The class of RDF properties.^^xsd:string</para>
    ///   <para>rdfs:label : Property^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Property">rdf:Property</a>
    /// </summary>
    let Property = rdfVocabulary.prefixId.prefix "Property"
    /// <summary>
    ///   <para>rdfs:comment : The class of ordered containers.^^xsd:string</para>
    ///   <para>rdfs:label : Seq^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq">rdf:Seq</a>
    /// </summary>
    let Seq = rdfVocabulary.prefixId.prefix "Seq"
    /// <summary>
    ///   <para>rdfs:comment : The class of RDF statements.^^xsd:string</para>
    ///   <para>rdfs:label : Statement^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement">rdf:Statement</a>
    /// </summary>
    let Statement = rdfVocabulary.prefixId.prefix "Statement"
    let XMLLiteral = rdfVocabulary.prefixId.prefix "XMLLiteral"
    /// <summary>
    ///   <para>rdfs:comment : The base direction component of a CompoundLiteral.^^xsd:string</para>
    ///   <para>rdfs:label : direction^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#direction">rdf:direction</a>
    /// </summary>
    let direction = rdfVocabulary.prefixId.prefix "direction"
    /// <summary>
    ///   <para>rdfs:comment : The first item in the subject RDF list.^^xsd:string</para>
    ///   <para>rdfs:label : first^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#first">rdf:first</a>
    /// </summary>
    let first = rdfVocabulary.prefixId.prefix "first"
    let langString = rdfVocabulary.prefixId.prefix "langString"
    /// <summary>
    ///   <para>rdfs:comment : The language component of a CompoundLiteral.^^xsd:string</para>
    ///   <para>rdfs:label : language^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#language">rdf:language</a>
    /// </summary>
    let language = rdfVocabulary.prefixId.prefix "language"
    let nil = rdfVocabulary.prefixId.prefix "nil"
    /// <summary>
    ///   <para>rdfs:comment : The object of the subject RDF statement.^^xsd:string</para>
    ///   <para>rdfs:label : object^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#object">rdf:object</a>
    /// </summary>
    let object = rdfVocabulary.prefixId.prefix "object"
    /// <summary>
    ///   <para>rdfs:comment : The predicate of the subject RDF statement.^^xsd:string</para>
    ///   <para>rdfs:label : predicate^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate">rdf:predicate</a>
    /// </summary>
    let predicate = rdfVocabulary.prefixId.prefix "predicate"
    /// <summary>
    ///   <para>rdfs:comment : The rest of the subject RDF list after the first item.^^xsd:string</para>
    ///   <para>rdfs:label : rest^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#rest">rdf:rest</a>
    /// </summary>
    let rest = rdfVocabulary.prefixId.prefix "rest"
    /// <summary>
    ///   <para>rdfs:comment : The subject of the subject RDF statement.^^xsd:string</para>
    ///   <para>rdfs:label : subject^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#subject">rdf:subject</a>
    /// </summary>
    let subject = rdfVocabulary.prefixId.prefix "subject"
    /// <summary>
    ///   <para>rdfs:comment : The subject is an instance of a class.^^xsd:string</para>
    ///   <para>rdfs:label : type^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#type">rdf:type</a>
    /// </summary>
    let type_ = rdfVocabulary.prefixId.prefix "type"
    /// <summary>
    ///   <para>rdfs:comment : Idiomatic property used for structured values.^^xsd:string</para>
    ///   <para>rdfs:label : value^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#value">rdf:value</a>
    /// </summary>
    let value = rdfVocabulary.prefixId.prefix "value"

module rdfs =
    let _namespaceIri = rdfsVocabulary.prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : The class of classes.^^xsd:string</para>
    ///   <para>rdfs:label : Class^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#Class">rdfs:Class</a>
    /// </summary>
    let Class = rdfsVocabulary.prefixId.prefix "Class"
    /// <summary>
    ///   <para>rdfs:comment : The class of RDF containers.^^xsd:string</para>
    ///   <para>rdfs:label : Container^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#Container">rdfs:Container</a>
    /// </summary>
    let Container = rdfsVocabulary.prefixId.prefix "Container"

    /// <summary>
    ///   <para>rdfs:comment : The class of container membership properties, rdf:_1, rdf:_2, ...,
    ///                     all of which are sub-properties of 'member'.^^xsd:string</para>
    ///   <para>rdfs:label : ContainerMembershipProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty">rdfs:ContainerMembershipProperty</a>
    /// </summary>
    let ContainerMembershipProperty =
        rdfsVocabulary.prefixId.prefix "ContainerMembershipProperty"

    /// <summary>
    ///   <para>rdfs:comment : The class of RDF datatypes.^^xsd:string</para>
    ///   <para>rdfs:label : Datatype^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#Datatype">rdfs:Datatype</a>
    /// </summary>
    let Datatype = rdfsVocabulary.prefixId.prefix "Datatype"
    /// <summary>
    ///   <para>rdfs:comment : The class of literal values, eg. textual strings and integers.^^xsd:string</para>
    ///   <para>rdfs:label : Literal^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#Literal">rdfs:Literal</a>
    /// </summary>
    let Literal = rdfsVocabulary.prefixId.prefix "Literal"
    /// <summary>
    ///   <para>rdfs:comment : The class resource, everything.^^xsd:string</para>
    ///   <para>rdfs:label : Resource^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#Resource">rdfs:Resource</a>
    /// </summary>
    let Resource = rdfsVocabulary.prefixId.prefix "Resource"
    /// <summary>
    ///   <para>rdfs:comment : A description of the subject resource.^^xsd:string</para>
    ///   <para>rdfs:label : comment^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#comment">rdfs:comment</a>
    /// </summary>
    let comment = rdfsVocabulary.prefixId.prefix "comment"
    /// <summary>
    ///   <para>rdfs:comment : A domain of the subject property.^^xsd:string</para>
    ///   <para>rdfs:label : domain^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#domain">rdfs:domain</a>
    /// </summary>
    let domain = rdfsVocabulary.prefixId.prefix "domain"
    /// <summary>
    ///   <para>rdfs:comment : The defininition of the subject resource.^^xsd:string</para>
    ///   <para>rdfs:label : isDefinedBy^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#isDefinedBy">rdfs:isDefinedBy</a>
    /// </summary>
    let isDefinedBy = rdfsVocabulary.prefixId.prefix "isDefinedBy"
    /// <summary>
    ///   <para>rdfs:comment : A human-readable name for the subject.^^xsd:string</para>
    ///   <para>rdfs:label : label^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#label">rdfs:label</a>
    /// </summary>
    let label = rdfsVocabulary.prefixId.prefix "label"
    /// <summary>
    ///   <para>rdfs:comment : A member of the subject resource.^^xsd:string</para>
    ///   <para>rdfs:label : member^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#member">rdfs:member</a>
    /// </summary>
    let member_ = rdfsVocabulary.prefixId.prefix "member"
    /// <summary>
    ///   <para>rdfs:comment : A range of the subject property.^^xsd:string</para>
    ///   <para>rdfs:label : range^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#range">rdfs:range</a>
    /// </summary>
    let range = rdfsVocabulary.prefixId.prefix "range"
    /// <summary>
    ///   <para>rdfs:comment : Further information about the subject resource.^^xsd:string</para>
    ///   <para>rdfs:label : seeAlso^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#seeAlso">rdfs:seeAlso</a>
    /// </summary>
    let seeAlso = rdfsVocabulary.prefixId.prefix "seeAlso"
    /// <summary>
    ///   <para>rdfs:comment : The subject is a subclass of a class.^^xsd:string</para>
    ///   <para>rdfs:label : subClassOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#subClassOf">rdfs:subClassOf</a>
    /// </summary>
    let subClassOf = rdfsVocabulary.prefixId.prefix "subClassOf"
    /// <summary>
    ///   <para>rdfs:comment : The subject is a subproperty of a property.^^xsd:string</para>
    ///   <para>rdfs:label : subPropertyOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#subPropertyOf">rdfs:subPropertyOf</a>
    /// </summary>
    let subPropertyOf = rdfsVocabulary.prefixId.prefix "subPropertyOf"

module owl =
    let _namespaceIri = owlVocabulary.prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : The class of collections of pairwise different individuals.^^xsd:string</para>
    ///   <para>rdfs:label : AllDifferent^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#AllDifferent">owl:AllDifferent</a>
    /// </summary>
    let AllDifferent = owlVocabulary.prefixId.prefix "AllDifferent"
    /// <summary>
    ///   <para>rdfs:comment : The class of collections of pairwise disjoint classes.^^xsd:string</para>
    ///   <para>rdfs:label : AllDisjointClasses^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#AllDisjointClasses">owl:AllDisjointClasses</a>
    /// </summary>
    let AllDisjointClasses = owlVocabulary.prefixId.prefix "AllDisjointClasses"
    /// <summary>
    ///   <para>rdfs:comment : The class of collections of pairwise disjoint properties.^^xsd:string</para>
    ///   <para>rdfs:label : AllDisjointProperties^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#AllDisjointProperties">owl:AllDisjointProperties</a>
    /// </summary>
    let AllDisjointProperties = owlVocabulary.prefixId.prefix "AllDisjointProperties"
    /// <summary>
    ///   <para>rdfs:comment : The class of annotated annotations for which the RDF serialization consists of an annotated subject, predicate and object.^^xsd:string</para>
    ///   <para>rdfs:label : Annotation^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Annotation">owl:Annotation</a>
    /// </summary>
    let Annotation = owlVocabulary.prefixId.prefix "Annotation"
    /// <summary>
    ///   <para>rdfs:comment : The class of annotation properties.^^xsd:string</para>
    ///   <para>rdfs:label : AnnotationProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#AnnotationProperty">owl:AnnotationProperty</a>
    /// </summary>
    let AnnotationProperty = owlVocabulary.prefixId.prefix "AnnotationProperty"
    /// <summary>
    ///   <para>rdfs:comment : The class of asymmetric properties.^^xsd:string</para>
    ///   <para>rdfs:label : AsymmetricProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#AsymmetricProperty">owl:AsymmetricProperty</a>
    /// </summary>
    let AsymmetricProperty = owlVocabulary.prefixId.prefix "AsymmetricProperty"
    /// <summary>
    ///   <para>rdfs:comment : The class of annotated axioms for which the RDF serialization consists of an annotated subject, predicate and object.^^xsd:string</para>
    ///   <para>rdfs:label : Axiom^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Axiom">owl:Axiom</a>
    /// </summary>
    let Axiom = owlVocabulary.prefixId.prefix "Axiom"
    /// <summary>
    ///   <para>rdfs:comment : The class of OWL classes.^^xsd:string</para>
    ///   <para>rdfs:label : Class^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Class">owl:Class</a>
    /// </summary>
    let Class = owlVocabulary.prefixId.prefix "Class"
    /// <summary>
    ///   <para>rdfs:comment : The class of OWL data ranges, which are special kinds of datatypes. Note: The use of the IRI owl:DataRange has been deprecated as of OWL 2. The IRI rdfs:Datatype SHOULD be used instead.^^xsd:string</para>
    ///   <para>rdfs:label : DataRange^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#DataRange">owl:DataRange</a>
    /// </summary>
    let DataRange = owlVocabulary.prefixId.prefix "DataRange"
    /// <summary>
    ///   <para>rdfs:comment : The class of data properties.^^xsd:string</para>
    ///   <para>rdfs:label : DatatypeProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#DatatypeProperty">owl:DatatypeProperty</a>
    /// </summary>
    let DatatypeProperty = owlVocabulary.prefixId.prefix "DatatypeProperty"
    /// <summary>
    ///   <para>rdfs:comment : The class of deprecated classes.^^xsd:string</para>
    ///   <para>rdfs:label : DeprecatedClass^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#DeprecatedClass">owl:DeprecatedClass</a>
    /// </summary>
    let DeprecatedClass = owlVocabulary.prefixId.prefix "DeprecatedClass"
    /// <summary>
    ///   <para>rdfs:comment : The class of deprecated properties.^^xsd:string</para>
    ///   <para>rdfs:label : DeprecatedProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#DeprecatedProperty">owl:DeprecatedProperty</a>
    /// </summary>
    let DeprecatedProperty = owlVocabulary.prefixId.prefix "DeprecatedProperty"
    /// <summary>
    ///   <para>rdfs:comment : The class of functional properties.^^xsd:string</para>
    ///   <para>rdfs:label : FunctionalProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#FunctionalProperty">owl:FunctionalProperty</a>
    /// </summary>
    let FunctionalProperty = owlVocabulary.prefixId.prefix "FunctionalProperty"

    /// <summary>
    ///   <para>rdfs:comment : The class of inverse-functional properties.^^xsd:string</para>
    ///   <para>rdfs:label : InverseFunctionalProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#InverseFunctionalProperty">owl:InverseFunctionalProperty</a>
    /// </summary>
    let InverseFunctionalProperty =
        owlVocabulary.prefixId.prefix "InverseFunctionalProperty"

    /// <summary>
    ///   <para>rdfs:comment : The class of irreflexive properties.^^xsd:string</para>
    ///   <para>rdfs:label : IrreflexiveProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#IrreflexiveProperty">owl:IrreflexiveProperty</a>
    /// </summary>
    let IrreflexiveProperty = owlVocabulary.prefixId.prefix "IrreflexiveProperty"
    /// <summary>
    ///   <para>rdfs:comment : The class of named individuals.^^xsd:string</para>
    ///   <para>rdfs:label : NamedIndividual^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#NamedIndividual">owl:NamedIndividual</a>
    /// </summary>
    let NamedIndividual = owlVocabulary.prefixId.prefix "NamedIndividual"

    /// <summary>
    ///   <para>rdfs:comment : The class of negative property assertions.^^xsd:string</para>
    ///   <para>rdfs:label : NegativePropertyAssertion^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#NegativePropertyAssertion">owl:NegativePropertyAssertion</a>
    /// </summary>
    let NegativePropertyAssertion =
        owlVocabulary.prefixId.prefix "NegativePropertyAssertion"

    /// <summary>
    ///   <para>rdfs:comment : This is the empty class.^^xsd:string</para>
    ///   <para>rdfs:label : Nothing^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Nothing">owl:Nothing</a>
    /// </summary>
    let Nothing = owlVocabulary.prefixId.prefix "Nothing"
    /// <summary>
    ///   <para>rdfs:comment : The class of object properties.^^xsd:string</para>
    ///   <para>rdfs:label : ObjectProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#ObjectProperty">owl:ObjectProperty</a>
    /// </summary>
    let ObjectProperty = owlVocabulary.prefixId.prefix "ObjectProperty"
    /// <summary>
    ///   <para>rdfs:comment : The class of ontologies.^^xsd:string</para>
    ///   <para>rdfs:label : Ontology^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Ontology">owl:Ontology</a>
    /// </summary>
    let Ontology = owlVocabulary.prefixId.prefix "Ontology"
    /// <summary>
    ///   <para>rdfs:comment : The class of ontology properties.^^xsd:string</para>
    ///   <para>rdfs:label : OntologyProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#OntologyProperty">owl:OntologyProperty</a>
    /// </summary>
    let OntologyProperty = owlVocabulary.prefixId.prefix "OntologyProperty"
    /// <summary>
    ///   <para>rdfs:comment : The class of reflexive properties.^^xsd:string</para>
    ///   <para>rdfs:label : ReflexiveProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#ReflexiveProperty">owl:ReflexiveProperty</a>
    /// </summary>
    let ReflexiveProperty = owlVocabulary.prefixId.prefix "ReflexiveProperty"
    /// <summary>
    ///   <para>rdfs:comment : The class of property restrictions.^^xsd:string</para>
    ///   <para>rdfs:label : Restriction^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Restriction">owl:Restriction</a>
    /// </summary>
    let Restriction = owlVocabulary.prefixId.prefix "Restriction"
    /// <summary>
    ///   <para>rdfs:comment : The class of symmetric properties.^^xsd:string</para>
    ///   <para>rdfs:label : SymmetricProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#SymmetricProperty">owl:SymmetricProperty</a>
    /// </summary>
    let SymmetricProperty = owlVocabulary.prefixId.prefix "SymmetricProperty"
    /// <summary>
    ///   <para>rdfs:comment : The class of OWL individuals.^^xsd:string</para>
    ///   <para>rdfs:label : Thing^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Thing">owl:Thing</a>
    /// </summary>
    let Thing = owlVocabulary.prefixId.prefix "Thing"
    /// <summary>
    ///   <para>rdfs:comment : The class of transitive properties.^^xsd:string</para>
    ///   <para>rdfs:label : TransitiveProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#TransitiveProperty">owl:TransitiveProperty</a>
    /// </summary>
    let TransitiveProperty = owlVocabulary.prefixId.prefix "TransitiveProperty"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the class that a universal property restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : allValuesFrom^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#allValuesFrom">owl:allValuesFrom</a>
    /// </summary>
    let allValuesFrom = owlVocabulary.prefixId.prefix "allValuesFrom"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the predicate of an annotated axiom or annotated annotation.^^xsd:string</para>
    ///   <para>rdfs:label : annotatedProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#annotatedProperty">owl:annotatedProperty</a>
    /// </summary>
    let annotatedProperty = owlVocabulary.prefixId.prefix "annotatedProperty"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the subject of an annotated axiom or annotated annotation.^^xsd:string</para>
    ///   <para>rdfs:label : annotatedSource^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#annotatedSource">owl:annotatedSource</a>
    /// </summary>
    let annotatedSource = owlVocabulary.prefixId.prefix "annotatedSource"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the object of an annotated axiom or annotated annotation.^^xsd:string</para>
    ///   <para>rdfs:label : annotatedTarget^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#annotatedTarget">owl:annotatedTarget</a>
    /// </summary>
    let annotatedTarget = owlVocabulary.prefixId.prefix "annotatedTarget"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the predicate of a negative property assertion.^^xsd:string</para>
    ///   <para>rdfs:label : assertionProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#assertionProperty">owl:assertionProperty</a>
    /// </summary>
    let assertionProperty = owlVocabulary.prefixId.prefix "assertionProperty"
    /// <summary>
    ///   <para>rdfs:comment : The annotation property that indicates that a given ontology is backward compatible with another ontology.^^xsd:string</para>
    ///   <para>rdfs:label : backwardCompatibleWith^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#backwardCompatibleWith">owl:backwardCompatibleWith</a>
    /// </summary>
    let backwardCompatibleWith = owlVocabulary.prefixId.prefix "backwardCompatibleWith"
    /// <summary>
    ///   <para>rdfs:comment : The data property that does not relate any individual to any data value.^^xsd:string</para>
    ///   <para>rdfs:label : bottomDataProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#bottomDataProperty">owl:bottomDataProperty</a>
    /// </summary>
    let bottomDataProperty = owlVocabulary.prefixId.prefix "bottomDataProperty"
    /// <summary>
    ///   <para>rdfs:comment : The object property that does not relate any two individuals.^^xsd:string</para>
    ///   <para>rdfs:label : bottomObjectProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#bottomObjectProperty">owl:bottomObjectProperty</a>
    /// </summary>
    let bottomObjectProperty = owlVocabulary.prefixId.prefix "bottomObjectProperty"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the cardinality of an exact cardinality restriction.^^xsd:string</para>
    ///   <para>rdfs:label : cardinality^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#cardinality">owl:cardinality</a>
    /// </summary>
    let cardinality = owlVocabulary.prefixId.prefix "cardinality"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines that a given class is the complement of another class.^^xsd:string</para>
    ///   <para>rdfs:label : complementOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#complementOf">owl:complementOf</a>
    /// </summary>
    let complementOf = owlVocabulary.prefixId.prefix "complementOf"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines that a given data range is the complement of another data range with respect to the data domain.^^xsd:string</para>
    ///   <para>rdfs:label : datatypeComplementOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#datatypeComplementOf">owl:datatypeComplementOf</a>
    /// </summary>
    let datatypeComplementOf = owlVocabulary.prefixId.prefix "datatypeComplementOf"
    /// <summary>
    ///   <para>rdfs:comment : The annotation property that indicates that a given entity has been deprecated.^^xsd:string</para>
    ///   <para>rdfs:label : deprecated^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#deprecated">owl:deprecated</a>
    /// </summary>
    let deprecated = owlVocabulary.prefixId.prefix "deprecated"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given individuals are different.^^xsd:string</para>
    ///   <para>rdfs:label : differentFrom^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#differentFrom">owl:differentFrom</a>
    /// </summary>
    let differentFrom = owlVocabulary.prefixId.prefix "differentFrom"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines that a given class is equivalent to the disjoint union of a collection of other classes.^^xsd:string</para>
    ///   <para>rdfs:label : disjointUnionOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#disjointUnionOf">owl:disjointUnionOf</a>
    /// </summary>
    let disjointUnionOf = owlVocabulary.prefixId.prefix "disjointUnionOf"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given classes are disjoint.^^xsd:string</para>
    ///   <para>rdfs:label : disjointWith^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#disjointWith">owl:disjointWith</a>
    /// </summary>
    let disjointWith = owlVocabulary.prefixId.prefix "disjointWith"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of pairwise different individuals in a owl:AllDifferent axiom.^^xsd:string</para>
    ///   <para>rdfs:label : distinctMembers^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#distinctMembers">owl:distinctMembers</a>
    /// </summary>
    let distinctMembers = owlVocabulary.prefixId.prefix "distinctMembers"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given classes are equivalent, and that is used to specify datatype definitions.^^xsd:string</para>
    ///   <para>rdfs:label : equivalentClass^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#equivalentClass">owl:equivalentClass</a>
    /// </summary>
    let equivalentClass = owlVocabulary.prefixId.prefix "equivalentClass"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given properties are equivalent.^^xsd:string</para>
    ///   <para>rdfs:label : equivalentProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#equivalentProperty">owl:equivalentProperty</a>
    /// </summary>
    let equivalentProperty = owlVocabulary.prefixId.prefix "equivalentProperty"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of properties that jointly build a key.^^xsd:string</para>
    ///   <para>rdfs:label : hasKey^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#hasKey">owl:hasKey</a>
    /// </summary>
    let hasKey = owlVocabulary.prefixId.prefix "hasKey"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the property that a self restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : hasSelf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#hasSelf">owl:hasSelf</a>
    /// </summary>
    let hasSelf = owlVocabulary.prefixId.prefix "hasSelf"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the individual that a has-value restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : hasValue^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#hasValue">owl:hasValue</a>
    /// </summary>
    let hasValue = owlVocabulary.prefixId.prefix "hasValue"
    let imports = owlVocabulary.prefixId.prefix "imports"
    /// <summary>
    ///   <para>rdfs:comment : The annotation property that indicates that a given ontology is incompatible with another ontology.^^xsd:string</para>
    ///   <para>rdfs:label : incompatibleWith^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#incompatibleWith">owl:incompatibleWith</a>
    /// </summary>
    let incompatibleWith = owlVocabulary.prefixId.prefix "incompatibleWith"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of classes or data ranges that build an intersection.^^xsd:string</para>
    ///   <para>rdfs:label : intersectionOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#intersectionOf">owl:intersectionOf</a>
    /// </summary>
    let intersectionOf = owlVocabulary.prefixId.prefix "intersectionOf"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given properties are inverse.^^xsd:string</para>
    ///   <para>rdfs:label : inverseOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#inverseOf">owl:inverseOf</a>
    /// </summary>
    let inverseOf = owlVocabulary.prefixId.prefix "inverseOf"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the cardinality of a maximum cardinality restriction.^^xsd:string</para>
    ///   <para>rdfs:label : maxCardinality^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#maxCardinality">owl:maxCardinality</a>
    /// </summary>
    let maxCardinality = owlVocabulary.prefixId.prefix "maxCardinality"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the cardinality of a maximum qualified cardinality restriction.^^xsd:string</para>
    ///   <para>rdfs:label : maxQualifiedCardinality^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#maxQualifiedCardinality">owl:maxQualifiedCardinality</a>
    /// </summary>
    let maxQualifiedCardinality =
        owlVocabulary.prefixId.prefix "maxQualifiedCardinality"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of members in either a owl:AllDifferent, owl:AllDisjointClasses or owl:AllDisjointProperties axiom.^^xsd:string</para>
    ///   <para>rdfs:label : members^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#members">owl:members</a>
    /// </summary>
    let members = owlVocabulary.prefixId.prefix "members"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the cardinality of a minimum cardinality restriction.^^xsd:string</para>
    ///   <para>rdfs:label : minCardinality^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#minCardinality">owl:minCardinality</a>
    /// </summary>
    let minCardinality = owlVocabulary.prefixId.prefix "minCardinality"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the cardinality of a minimum qualified cardinality restriction.^^xsd:string</para>
    ///   <para>rdfs:label : minQualifiedCardinality^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#minQualifiedCardinality">owl:minQualifiedCardinality</a>
    /// </summary>
    let minQualifiedCardinality =
        owlVocabulary.prefixId.prefix "minQualifiedCardinality"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the class that a qualified object cardinality restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : onClass^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#onClass">owl:onClass</a>
    /// </summary>
    let onClass = owlVocabulary.prefixId.prefix "onClass"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the data range that a qualified data cardinality restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : onDataRange^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#onDataRange">owl:onDataRange</a>
    /// </summary>
    let onDataRange = owlVocabulary.prefixId.prefix "onDataRange"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the datatype that a datatype restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : onDatatype^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#onDatatype">owl:onDatatype</a>
    /// </summary>
    let onDatatype = owlVocabulary.prefixId.prefix "onDatatype"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the n-tuple of properties that a property restriction on an n-ary data range refers to.^^xsd:string</para>
    ///   <para>rdfs:label : onProperties^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#onProperties">owl:onProperties</a>
    /// </summary>
    let onProperties = owlVocabulary.prefixId.prefix "onProperties"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the property that a property restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : onProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#onProperty">owl:onProperty</a>
    /// </summary>
    let onProperty = owlVocabulary.prefixId.prefix "onProperty"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of individuals or data values that build an enumeration.^^xsd:string</para>
    ///   <para>rdfs:label : oneOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#oneOf">owl:oneOf</a>
    /// </summary>
    let oneOf = owlVocabulary.prefixId.prefix "oneOf"
    /// <summary>
    ///   <para>rdfs:comment : The annotation property that indicates the predecessor ontology of a given ontology.^^xsd:string</para>
    ///   <para>rdfs:label : priorVersion^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#priorVersion">owl:priorVersion</a>
    /// </summary>
    let priorVersion = owlVocabulary.prefixId.prefix "priorVersion"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the n-tuple of properties that build a sub property chain of a given property.^^xsd:string</para>
    ///   <para>rdfs:label : propertyChainAxiom^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#propertyChainAxiom">owl:propertyChainAxiom</a>
    /// </summary>
    let propertyChainAxiom = owlVocabulary.prefixId.prefix "propertyChainAxiom"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given properties are disjoint.^^xsd:string</para>
    ///   <para>rdfs:label : propertyDisjointWith^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#propertyDisjointWith">owl:propertyDisjointWith</a>
    /// </summary>
    let propertyDisjointWith = owlVocabulary.prefixId.prefix "propertyDisjointWith"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the cardinality of an exact qualified cardinality restriction.^^xsd:string</para>
    ///   <para>rdfs:label : qualifiedCardinality^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#qualifiedCardinality">owl:qualifiedCardinality</a>
    /// </summary>
    let qualifiedCardinality = owlVocabulary.prefixId.prefix "qualifiedCardinality"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given individuals are equal.^^xsd:string</para>
    ///   <para>rdfs:label : sameAs^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#sameAs">owl:sameAs</a>
    /// </summary>
    let sameAs = owlVocabulary.prefixId.prefix "sameAs"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the class that an existential property restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : someValuesFrom^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#someValuesFrom">owl:someValuesFrom</a>
    /// </summary>
    let someValuesFrom = owlVocabulary.prefixId.prefix "someValuesFrom"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the subject of a negative property assertion.^^xsd:string</para>
    ///   <para>rdfs:label : sourceIndividual^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#sourceIndividual">owl:sourceIndividual</a>
    /// </summary>
    let sourceIndividual = owlVocabulary.prefixId.prefix "sourceIndividual"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the object of a negative object property assertion.^^xsd:string</para>
    ///   <para>rdfs:label : targetIndividual^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#targetIndividual">owl:targetIndividual</a>
    /// </summary>
    let targetIndividual = owlVocabulary.prefixId.prefix "targetIndividual"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the value of a negative data property assertion.^^xsd:string</para>
    ///   <para>rdfs:label : targetValue^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#targetValue">owl:targetValue</a>
    /// </summary>
    let targetValue = owlVocabulary.prefixId.prefix "targetValue"
    /// <summary>
    ///   <para>rdfs:comment : The data property that relates every individual to every data value.^^xsd:string</para>
    ///   <para>rdfs:label : topDataProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#topDataProperty">owl:topDataProperty</a>
    /// </summary>
    let topDataProperty = owlVocabulary.prefixId.prefix "topDataProperty"
    /// <summary>
    ///   <para>rdfs:comment : The object property that relates every two individuals.^^xsd:string</para>
    ///   <para>rdfs:label : topObjectProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#topObjectProperty">owl:topObjectProperty</a>
    /// </summary>
    let topObjectProperty = owlVocabulary.prefixId.prefix "topObjectProperty"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of classes or data ranges that build a union.^^xsd:string</para>
    ///   <para>rdfs:label : unionOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#unionOf">owl:unionOf</a>
    /// </summary>
    let unionOf = owlVocabulary.prefixId.prefix "unionOf"
    let versionIRI = owlVocabulary.prefixId.prefix "versionIRI"
    /// <summary>
    ///   <para>rdfs:comment : The annotation property that provides version information for an ontology or another OWL construct.^^xsd:string</para>
    ///   <para>rdfs:label : versionInfo^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#versionInfo">owl:versionInfo</a>
    /// </summary>
    let versionInfo = owlVocabulary.prefixId.prefix "versionInfo"
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of facet-value pairs that define a datatype restriction.^^xsd:string</para>
    ///   <para>rdfs:label : withRestrictions^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#withRestrictions">owl:withRestrictions</a>
    /// </summary>
    let withRestrictions = owlVocabulary.prefixId.prefix "withRestrictions"

module foaf =
    let _namespaceIri = foafVocabulary.prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : An agent (eg. person, group, software or physical artifact).^^xsd:string</para>
    ///   <para>rdfs:label : Agent^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Agent">foaf:Agent</a>
    /// </summary>
    let Agent = foafVocabulary.prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:comment : A document.^^xsd:string</para>
    ///   <para>rdfs:label : Document^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Document">foaf:Document</a>
    /// </summary>
    let Document = foafVocabulary.prefixId.prefix "Document"
    /// <summary>
    ///   <para>rdfs:comment : A class of Agents.^^xsd:string</para>
    ///   <para>rdfs:label : Group^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Group">foaf:Group</a>
    /// </summary>
    let Group = foafVocabulary.prefixId.prefix "Group"
    /// <summary>
    ///   <para>rdfs:comment : An image.^^xsd:string</para>
    ///   <para>rdfs:label : Image^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Image">foaf:Image</a>
    /// </summary>
    let Image = foafVocabulary.prefixId.prefix "Image"
    /// <summary>
    ///   <para>rdfs:comment : A foaf:LabelProperty is any RDF property with texual values that serve as labels.^^xsd:string</para>
    ///   <para>rdfs:label : Label Property^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/LabelProperty">foaf:LabelProperty</a>
    /// </summary>
    let LabelProperty = foafVocabulary.prefixId.prefix "LabelProperty"
    /// <summary>
    ///   <para>rdfs:comment : An online account.^^xsd:string</para>
    ///   <para>rdfs:label : Online Account^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/OnlineAccount">foaf:OnlineAccount</a>
    /// </summary>
    let OnlineAccount = foafVocabulary.prefixId.prefix "OnlineAccount"
    /// <summary>
    ///   <para>rdfs:comment : An online chat account.^^xsd:string</para>
    ///   <para>rdfs:label : Online Chat Account^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/OnlineChatAccount">foaf:OnlineChatAccount</a>
    /// </summary>
    let OnlineChatAccount = foafVocabulary.prefixId.prefix "OnlineChatAccount"
    /// <summary>
    ///   <para>rdfs:comment : An online e-commerce account.^^xsd:string</para>
    ///   <para>rdfs:label : Online E-commerce Account^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/OnlineEcommerceAccount">foaf:OnlineEcommerceAccount</a>
    /// </summary>
    let OnlineEcommerceAccount = foafVocabulary.prefixId.prefix "OnlineEcommerceAccount"
    /// <summary>
    ///   <para>rdfs:comment : An online gaming account.^^xsd:string</para>
    ///   <para>rdfs:label : Online Gaming Account^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/OnlineGamingAccount">foaf:OnlineGamingAccount</a>
    /// </summary>
    let OnlineGamingAccount = foafVocabulary.prefixId.prefix "OnlineGamingAccount"
    /// <summary>
    ///   <para>rdfs:comment : An organization.^^xsd:string</para>
    ///   <para>rdfs:label : Organization^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Organization">foaf:Organization</a>
    /// </summary>
    let Organization = foafVocabulary.prefixId.prefix "Organization"
    /// <summary>
    ///   <para>rdfs:comment : A person.^^xsd:string</para>
    ///   <para>rdfs:label : Person^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Person">foaf:Person</a>
    /// </summary>
    let Person = foafVocabulary.prefixId.prefix "Person"

    /// <summary>
    ///   <para>rdfs:comment : A personal profile RDF document.^^xsd:string</para>
    ///   <para>rdfs:label : PersonalProfileDocument^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/PersonalProfileDocument">foaf:PersonalProfileDocument</a>
    /// </summary>
    let PersonalProfileDocument =
        foafVocabulary.prefixId.prefix "PersonalProfileDocument"

    /// <summary>
    ///   <para>rdfs:comment : A project (a collective endeavour of some kind).^^xsd:string</para>
    ///   <para>rdfs:label : Project^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Project">foaf:Project</a>
    /// </summary>
    let Project = foafVocabulary.prefixId.prefix "Project"
    /// <summary>
    ///   <para>rdfs:comment : Indicates an account held by this agent.^^xsd:string</para>
    ///   <para>rdfs:label : account^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/account">foaf:account</a>
    /// </summary>
    let account = foafVocabulary.prefixId.prefix "account"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name (identifier) associated with this online account.^^xsd:string</para>
    ///   <para>rdfs:label : account name^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/accountName">foaf:accountName</a>
    /// </summary>
    let accountName = foafVocabulary.prefixId.prefix "accountName"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a homepage of the service provide for this online account.^^xsd:string</para>
    ///   <para>rdfs:label : account service homepage^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/accountServiceHomepage">foaf:accountServiceHomepage</a>
    /// </summary>
    let accountServiceHomepage = foafVocabulary.prefixId.prefix "accountServiceHomepage"
    /// <summary>
    ///   <para>rdfs:comment : The age in years of some agent.^^xsd:string</para>
    ///   <para>rdfs:label : age^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/age">foaf:age</a>
    /// </summary>
    let age = foafVocabulary.prefixId.prefix "age"
    /// <summary>
    ///   <para>rdfs:comment : An AIM chat ID^^xsd:string</para>
    ///   <para>rdfs:label : AIM chat ID^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/aimChatID">foaf:aimChatID</a>
    /// </summary>
    let aimChatID = foafVocabulary.prefixId.prefix "aimChatID"
    /// <summary>
    ///   <para>rdfs:comment : A location that something is based near, for some broadly human notion of near.^^xsd:string</para>
    ///   <para>rdfs:label : based near^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/based_near">foaf:based_near</a>
    /// </summary>
    let based_near = foafVocabulary.prefixId.prefix "based_near"
    /// <summary>
    ///   <para>rdfs:comment : The birthday of this Agent, represented in mm-dd string form, eg. '12-31'.^^xsd:string</para>
    ///   <para>rdfs:label : birthday^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/birthday">foaf:birthday</a>
    /// </summary>
    let birthday = foafVocabulary.prefixId.prefix "birthday"
    /// <summary>
    ///   <para>rdfs:comment : A current project this person works on.^^xsd:string</para>
    ///   <para>rdfs:label : current project^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/currentProject">foaf:currentProject</a>
    /// </summary>
    let currentProject = foafVocabulary.prefixId.prefix "currentProject"
    /// <summary>
    ///   <para>rdfs:comment : A depiction of some thing.^^xsd:string</para>
    ///   <para>rdfs:label : depiction^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/depiction">foaf:depiction</a>
    /// </summary>
    let depiction = foafVocabulary.prefixId.prefix "depiction"
    /// <summary>
    ///   <para>rdfs:comment : A thing depicted in this representation.^^xsd:string</para>
    ///   <para>rdfs:label : depicts^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/depicts">foaf:depicts</a>
    /// </summary>
    let depicts = foafVocabulary.prefixId.prefix "depicts"
    /// <summary>
    ///   <para>rdfs:comment : A checksum for the DNA of some thing. Joke.^^xsd:string</para>
    ///   <para>rdfs:label : DNA checksum^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/dnaChecksum">foaf:dnaChecksum</a>
    /// </summary>
    let dnaChecksum = foafVocabulary.prefixId.prefix "dnaChecksum"
    /// <summary>
    ///   <para>rdfs:comment : The family name of some person.^^xsd:string</para>
    ///   <para>rdfs:label : familyName^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/familyName">foaf:familyName</a>
    /// </summary>
    let familyName = foafVocabulary.prefixId.prefix "familyName"
    /// <summary>
    ///   <para>rdfs:comment : The family name of some person.^^xsd:string</para>
    ///   <para>rdfs:label : family_name^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/family_name">foaf:family_name</a>
    /// </summary>
    let family_name = foafVocabulary.prefixId.prefix "family_name"
    /// <summary>
    ///   <para>rdfs:comment : The first name of a person.^^xsd:string</para>
    ///   <para>rdfs:label : firstName^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/firstName">foaf:firstName</a>
    /// </summary>
    let firstName = foafVocabulary.prefixId.prefix "firstName"
    /// <summary>
    ///   <para>rdfs:comment : The underlying or 'focal' entity associated with some SKOS-described concept.^^xsd:string</para>
    ///   <para>rdfs:label : focus^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/focus">foaf:focus</a>
    /// </summary>
    let focus = foafVocabulary.prefixId.prefix "focus"
    /// <summary>
    ///   <para>rdfs:comment : An organization funding a project or person.^^xsd:string</para>
    ///   <para>rdfs:label : funded by^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/fundedBy">foaf:fundedBy</a>
    /// </summary>
    let fundedBy = foafVocabulary.prefixId.prefix "fundedBy"
    /// <summary>
    ///   <para>rdfs:comment : A textual geekcode for this person, see http://www.geekcode.com/geek.html^^xsd:string</para>
    ///   <para>rdfs:label : geekcode^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/geekcode">foaf:geekcode</a>
    /// </summary>
    let geekcode = foafVocabulary.prefixId.prefix "geekcode"
    /// <summary>
    ///   <para>rdfs:comment : The gender of this Agent (typically but not necessarily 'male' or 'female').^^xsd:string</para>
    ///   <para>rdfs:label : gender^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/gender">foaf:gender</a>
    /// </summary>
    let gender = foafVocabulary.prefixId.prefix "gender"
    /// <summary>
    ///   <para>rdfs:comment : The given name of some person.^^xsd:string</para>
    ///   <para>rdfs:label : Given name^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/givenName">foaf:givenName</a>
    /// </summary>
    let givenName = foafVocabulary.prefixId.prefix "givenName"
    /// <summary>
    ///   <para>rdfs:comment : The given name of some person.^^xsd:string</para>
    ///   <para>rdfs:label : Given name^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/givenname">foaf:givenname</a>
    /// </summary>
    let givenname = foafVocabulary.prefixId.prefix "givenname"
    /// <summary>
    ///   <para>rdfs:comment : Indicates an account held by this agent.^^xsd:string</para>
    ///   <para>rdfs:label : account^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/holdsAccount">foaf:holdsAccount</a>
    /// </summary>
    let holdsAccount = foafVocabulary.prefixId.prefix "holdsAccount"
    /// <summary>
    ///   <para>rdfs:comment : A homepage for some thing.^^xsd:string</para>
    ///   <para>rdfs:label : homepage^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/homepage">foaf:homepage</a>
    /// </summary>
    let homepage = foafVocabulary.prefixId.prefix "homepage"
    /// <summary>
    ///   <para>rdfs:comment : An ICQ chat ID^^xsd:string</para>
    ///   <para>rdfs:label : ICQ chat ID^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/icqChatID">foaf:icqChatID</a>
    /// </summary>
    let icqChatID = foafVocabulary.prefixId.prefix "icqChatID"
    /// <summary>
    ///   <para>rdfs:comment : An image that can be used to represent some thing (ie. those depictions which are particularly representative of something, eg. one's photo on a homepage).^^xsd:string</para>
    ///   <para>rdfs:label : image^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/img">foaf:img</a>
    /// </summary>
    let img = foafVocabulary.prefixId.prefix "img"
    /// <summary>
    ///   <para>rdfs:comment : A page about a topic of interest to this person.^^xsd:string</para>
    ///   <para>rdfs:label : interest^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/interest">foaf:interest</a>
    /// </summary>
    let interest = foafVocabulary.prefixId.prefix "interest"
    /// <summary>
    ///   <para>rdfs:comment : A document that this thing is the primary topic of.^^xsd:string</para>
    ///   <para>rdfs:label : is primary topic of^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/isPrimaryTopicOf">foaf:isPrimaryTopicOf</a>
    /// </summary>
    let isPrimaryTopicOf = foafVocabulary.prefixId.prefix "isPrimaryTopicOf"
    /// <summary>
    ///   <para>rdfs:comment : A jabber ID for something.^^xsd:string</para>
    ///   <para>rdfs:label : jabber ID^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/jabberID">foaf:jabberID</a>
    /// </summary>
    let jabberID = foafVocabulary.prefixId.prefix "jabberID"
    /// <summary>
    ///   <para>rdfs:comment : A person known by this person (indicating some level of reciprocated interaction between the parties).^^xsd:string</para>
    ///   <para>rdfs:label : knows^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/knows">foaf:knows</a>
    /// </summary>
    let knows = foafVocabulary.prefixId.prefix "knows"
    /// <summary>
    ///   <para>rdfs:comment : The last name of a person.^^xsd:string</para>
    ///   <para>rdfs:label : lastName^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/lastName">foaf:lastName</a>
    /// </summary>
    let lastName = foafVocabulary.prefixId.prefix "lastName"
    /// <summary>
    ///   <para>rdfs:comment : A logo representing some thing.^^xsd:string</para>
    ///   <para>rdfs:label : logo^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/logo">foaf:logo</a>
    /// </summary>
    let logo = foafVocabulary.prefixId.prefix "logo"
    /// <summary>
    ///   <para>rdfs:comment : Something that was made by this agent.^^xsd:string</para>
    ///   <para>rdfs:label : made^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/made">foaf:made</a>
    /// </summary>
    let made = foafVocabulary.prefixId.prefix "made"
    /// <summary>
    ///   <para>rdfs:comment : An agent that  made this thing.^^xsd:string</para>
    ///   <para>rdfs:label : maker^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/maker">foaf:maker</a>
    /// </summary>
    let maker = foafVocabulary.prefixId.prefix "maker"
    /// <summary>
    ///   <para>rdfs:comment : A  personal mailbox, ie. an Internet mailbox associated with exactly one owner, the first owner of this mailbox. This is a 'static inverse functional property', in that  there is (across time and change) at most one individual that ever has any particular value for foaf:mbox.^^xsd:string</para>
    ///   <para>rdfs:label : personal mailbox^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/mbox">foaf:mbox</a>
    /// </summary>
    let mbox = foafVocabulary.prefixId.prefix "mbox"
    /// <summary>
    ///   <para>rdfs:comment : The sha1sum of the URI of an Internet mailbox associated with exactly one owner, the  first owner of the mailbox.^^xsd:string</para>
    ///   <para>rdfs:label : sha1sum of a personal mailbox URI name^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/mbox_sha1sum">foaf:mbox_sha1sum</a>
    /// </summary>
    let mbox_sha1sum = foafVocabulary.prefixId.prefix "mbox_sha1sum"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a member of a Group^^xsd:string</para>
    ///   <para>rdfs:label : member^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/member">foaf:member</a>
    /// </summary>
    let member_ = foafVocabulary.prefixId.prefix "member"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the class of individuals that are a member of a Group^^xsd:string</para>
    ///   <para>rdfs:label : membershipClass^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/membershipClass">foaf:membershipClass</a>
    /// </summary>
    let membershipClass = foafVocabulary.prefixId.prefix "membershipClass"
    /// <summary>
    ///   <para>rdfs:comment : An MSN chat ID^^xsd:string</para>
    ///   <para>rdfs:label : MSN chat ID^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/msnChatID">foaf:msnChatID</a>
    /// </summary>
    let msnChatID = foafVocabulary.prefixId.prefix "msnChatID"
    /// <summary>
    ///   <para>rdfs:comment : A Myers Briggs (MBTI) personality classification.^^xsd:string</para>
    ///   <para>rdfs:label : myersBriggs^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/myersBriggs">foaf:myersBriggs</a>
    /// </summary>
    let myersBriggs = foafVocabulary.prefixId.prefix "myersBriggs"
    /// <summary>
    ///   <para>rdfs:comment : A name for some thing.^^xsd:string</para>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/name">foaf:name</a>
    /// </summary>
    let name = foafVocabulary.prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:comment : A short informal nickname characterising an agent (includes login identifiers, IRC and other chat nicknames).^^xsd:string</para>
    ///   <para>rdfs:label : nickname^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/nick">foaf:nick</a>
    /// </summary>
    let nick = foafVocabulary.prefixId.prefix "nick"
    /// <summary>
    ///   <para>rdfs:comment : An OpenID for an Agent.^^xsd:string</para>
    ///   <para>rdfs:label : openid^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/openid">foaf:openid</a>
    /// </summary>
    let openid = foafVocabulary.prefixId.prefix "openid"
    /// <summary>
    ///   <para>rdfs:comment : A page or document about this thing.^^xsd:string</para>
    ///   <para>rdfs:label : page^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/page">foaf:page</a>
    /// </summary>
    let page = foafVocabulary.prefixId.prefix "page"
    /// <summary>
    ///   <para>rdfs:comment : A project this person has previously worked on.^^xsd:string</para>
    ///   <para>rdfs:label : past project^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/pastProject">foaf:pastProject</a>
    /// </summary>
    let pastProject = foafVocabulary.prefixId.prefix "pastProject"
    /// <summary>
    ///   <para>rdfs:comment : A phone,  specified using fully qualified tel: URI scheme (refs: http://www.w3.org/Addressing/schemes.html#tel).^^xsd:string</para>
    ///   <para>rdfs:label : phone^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/phone">foaf:phone</a>
    /// </summary>
    let phone = foafVocabulary.prefixId.prefix "phone"
    /// <summary>
    ///   <para>rdfs:comment : A .plan comment, in the tradition of finger and '.plan' files.^^xsd:string</para>
    ///   <para>rdfs:label : plan^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/plan">foaf:plan</a>
    /// </summary>
    let plan = foafVocabulary.prefixId.prefix "plan"
    /// <summary>
    ///   <para>rdfs:comment : The primary topic of some page or document.^^xsd:string</para>
    ///   <para>rdfs:label : primary topic^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/primaryTopic">foaf:primaryTopic</a>
    /// </summary>
    let primaryTopic = foafVocabulary.prefixId.prefix "primaryTopic"
    /// <summary>
    ///   <para>rdfs:comment : A link to the publications of this person.^^xsd:string</para>
    ///   <para>rdfs:label : publications^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/publications">foaf:publications</a>
    /// </summary>
    let publications = foafVocabulary.prefixId.prefix "publications"
    /// <summary>
    ///   <para>rdfs:comment : A homepage of a school attended by the person.^^xsd:string</para>
    ///   <para>rdfs:label : schoolHomepage^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/schoolHomepage">foaf:schoolHomepage</a>
    /// </summary>
    let schoolHomepage = foafVocabulary.prefixId.prefix "schoolHomepage"
    /// <summary>
    ///   <para>rdfs:comment : A sha1sum hash, in hex.^^xsd:string</para>
    ///   <para>rdfs:label : sha1sum (hex)^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/sha1">foaf:sha1</a>
    /// </summary>
    let sha1 = foafVocabulary.prefixId.prefix "sha1"
    /// <summary>
    ///   <para>rdfs:comment : A Skype ID^^xsd:string</para>
    ///   <para>rdfs:label : Skype ID^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/skypeID">foaf:skypeID</a>
    /// </summary>
    let skypeID = foafVocabulary.prefixId.prefix "skypeID"
    /// <summary>
    ///   <para>rdfs:comment : A string expressing what the user is happy for the general public (normally) to know about their current activity.^^xsd:string</para>
    ///   <para>rdfs:label : status^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/status">foaf:status</a>
    /// </summary>
    let status = foafVocabulary.prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfs:comment : The surname of some person.^^xsd:string</para>
    ///   <para>rdfs:label : Surname^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/surname">foaf:surname</a>
    /// </summary>
    let surname = foafVocabulary.prefixId.prefix "surname"
    /// <summary>
    ///   <para>rdfs:comment : A theme.^^xsd:string</para>
    ///   <para>rdfs:label : theme^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/theme">foaf:theme</a>
    /// </summary>
    let theme = foafVocabulary.prefixId.prefix "theme"
    /// <summary>
    ///   <para>rdfs:comment : A derived thumbnail image.^^xsd:string</para>
    ///   <para>rdfs:label : thumbnail^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/thumbnail">foaf:thumbnail</a>
    /// </summary>
    let thumbnail = foafVocabulary.prefixId.prefix "thumbnail"
    /// <summary>
    ///   <para>rdfs:comment : A tipjar document for this agent, describing means for payment and reward.^^xsd:string</para>
    ///   <para>rdfs:label : tipjar^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/tipjar">foaf:tipjar</a>
    /// </summary>
    let tipjar = foafVocabulary.prefixId.prefix "tipjar"
    /// <summary>
    ///   <para>rdfs:comment : Title (Mr, Mrs, Ms, Dr. etc)^^xsd:string</para>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/title">foaf:title</a>
    /// </summary>
    let title = foafVocabulary.prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:comment : A topic of some page or document.^^xsd:string</para>
    ///   <para>rdfs:label : topic^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/topic">foaf:topic</a>
    /// </summary>
    let topic = foafVocabulary.prefixId.prefix "topic"
    /// <summary>
    ///   <para>rdfs:comment : A thing of interest to this person.^^xsd:string</para>
    ///   <para>rdfs:label : topic_interest^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/topic_interest">foaf:topic_interest</a>
    /// </summary>
    let topic_interest = foafVocabulary.prefixId.prefix "topic_interest"
    /// <summary>
    ///   <para>rdfs:comment : A weblog of some thing (whether person, group, company etc.).^^xsd:string</para>
    ///   <para>rdfs:label : weblog^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/weblog">foaf:weblog</a>
    /// </summary>
    let weblog = foafVocabulary.prefixId.prefix "weblog"
    /// <summary>
    ///   <para>rdfs:comment : A work info homepage of some person; a page about their work for some organization.^^xsd:string</para>
    ///   <para>rdfs:label : work info homepage^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/workInfoHomepage">foaf:workInfoHomepage</a>
    /// </summary>
    let workInfoHomepage = foafVocabulary.prefixId.prefix "workInfoHomepage"
    /// <summary>
    ///   <para>rdfs:comment : A workplace homepage of some person; the homepage of an organization they work for.^^xsd:string</para>
    ///   <para>rdfs:label : workplace homepage^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/workplaceHomepage">foaf:workplaceHomepage</a>
    /// </summary>
    let workplaceHomepage = foafVocabulary.prefixId.prefix "workplaceHomepage"
    /// <summary>
    ///   <para>rdfs:comment : A Yahoo chat ID^^xsd:string</para>
    ///   <para>rdfs:label : Yahoo chat ID^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/yahooChatID">foaf:yahooChatID</a>
    /// </summary>
    let yahooChatID = foafVocabulary.prefixId.prefix "yahooChatID"

module vs =
    let _namespaceIri = vsVocabulary.prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : more information about the status etc of a term, typically human oriented^^xsd:string</para>
    ///   <para>rdfs:label : more info^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/06/sw-vocab-status/ns#moreinfo">vs:moreinfo</a>
    /// </summary>
    let moreinfo = vsVocabulary.prefixId.prefix "moreinfo"
    /// <summary>
    ///   <para>rdfs:comment : the status of a vocabulary term, expressed as a short symbolic string; known values include 'unstable','testing', 'stable' and 'archaic'^^xsd:string</para>
    ///   <para>rdfs:label : term status^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/06/sw-vocab-status/ns#term_status">vs:term_status</a>
    /// </summary>
    let term_status = vsVocabulary.prefixId.prefix "term_status"
    /// <summary>
    ///   <para>rdfs:comment : human-oriented documentation, examples etc for use of this term^^xsd:string</para>
    ///   <para>rdfs:label : user docs^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/06/sw-vocab-status/ns#userdocs">vs:userdocs</a>
    /// </summary>
    let userdocs = vsVocabulary.prefixId.prefix "userdocs"


    
module dac = 
    let _prefixId = PrefixId.fromNamespaceLabel "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02" "dac"
    let _prefix (localName:string) = PrefixedIri { prefixId = _prefixId ; localName = localName } 
    let DataSchemaModel = _prefix "DataSchemaModel"
    let Model = _prefix "Model"
    let Element = _prefix "Element"
    let Property = _prefix "Property"
    let Value = _prefix "Value"
    let QuotedIdentifiers = _prefix "QuotedIdentifiers"
    let AnsiNulls = _prefix "AnsiNulls"
    let Name = _prefix "Name"
    let Relationship = _prefix "Relationship"
    let Entry = _prefix "Entry"
    let Annotation = _prefix "Annotation"
    let Type = _prefix "Type"
    let References = _prefix "References"
    let ExternalSource = _prefix "ExternalSource"
    let AttachedAnnotation = _prefix "AttachedAnnotation"
    let Disambiguator = _prefix "Disambiguator"
    let FileFormatVersion = _prefix "FileFormatVersion"
    let SchemaVersion = _prefix "SchemaVersion"
    let DspName = _prefix "DspName"
    let CollationLcid = _prefix "CollationLcid"
    let CollationCaseSensitive = _prefix "CollationCaseSensitive"
    let SqlCheckConstraint = _prefix "SqlCheckConstraint"
    let SqlDatabaseOptions = _prefix "SqlDatabaseOptions"
    let SqlDefaultConstraint = _prefix "SqlDefaultConstraint"
    let SqlDmlTrigger = _prefix "SqlDmlTrigger"
    let SqlExtendedProperty = _prefix "SqlExtendedProperty"
    let SqlForeignKeyConstraint = _prefix "SqlForeignKeyConstraint"
    let SqlIndex = _prefix "SqlIndex"
    let SqlInlineTableValuedFunction = _prefix "SqlInlineTableValuedFunction"
    let SqlLogin = _prefix "SqlLogin"
    let SqlMultiStatementTableValuedFunction = _prefix "SqlMultiStatementTableValuedFunction"
    let SqlPrimaryKeyConstraint = _prefix "SqlPrimaryKeyConstraint"
    let SqlProcedure = _prefix "SqlProcedure"
    let SqlRole = _prefix "SqlRole"
    let SqlRoleMembership = _prefix "SqlRoleMembership"
    let SqlScalarFunction = _prefix "SqlScalarFunction"
    let SqlSchema = _prefix "SqlSchema"
    let SqlStatistic = _prefix "SqlStatistic"
    let SqlSynonym = _prefix "SqlSynonym"
    let SqlTable = _prefix "SqlTable"
    let SqlTableType = _prefix "SqlTableType"
    let SqlUniqueConstraint = _prefix "SqlUniqueConstraint"
    let SqlUser = _prefix "SqlUser"
    let SqlView = _prefix "SqlView"
let a = rdf.type_

module dbug = 
    let _prefixId = PrefixId.fromNamespaceLabel "https://eristocrates.dev/ontology/dbug/"  "dbug"
    let _prefix (localName:string) = PrefixedIri { prefixId = _prefixId ; localName = localName } 
    let Bob = _prefix "Bob"
    let Alice = _prefix "Alice"
    let this = _prefix "this"
    let test = _prefix "test"







!> dbug.Bob --- a --> foaf.Person
|> writeDraft @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\scratch" "scratch"




































type FileInfo with 
    member this.asUri = Uri this.FullName
    member this.asIriReference = IriReference this.asUri

type DocumentRepresentation = 
    {
        iriReference : IriReference
        localReference : FileInfo
    }
    static member fromLocalFile (file:FileInfo) = 
        {
            iriReference =  file.asIriReference
            localReference = file
        }
    static member fromRemoteIriReference (iriReference:IriReference) = 
        let fileName = Path.GetFileName iriReference.asUrl.Pathname
        {
            iriReference =  iriReference
            localReference = Path.Combine(Folder.Iri.FullName,iriReference.toRelativeLocalPath,fileName) |> FileInfo
        }
    member this.download() = 
        Directory.CreateDirectory this.localReference.DirectoryName |> ignore
        http {
            GET this.iriReference.lexicalForm
        }
        |> Request.send
        |> Response.saveFile this.localReference.FullName
    member this.mimeType = MimeType.FromFileName this.localReference.FullName

module DocumentRepresentation = 
    module LeonCounty = 
        module Resolution = 
            let TreatAllDignityRespect = IriReference "https://cms.leoncountyfl.gov/Portals/0/DeptFiles/Admin/ResolutionTreatAllDignityRespect.pdf" |> DocumentRepresentation.fromRemoteIriReference
        module ComprehensivePlan = 
            let TallahasseeLeonCounty2050 = IriReference "https://www.talgov.com/Uploads/Public/Documents/place/comp_plan/tallahassee-leon-county-comprehensive-plan-rev-g2026n.pdf" |> DocumentRepresentation.fromRemoteIriReference 
        module FY2022 = 
            module FY2026 = 
                let StrategicPlan = IriReference "https://cms.leoncountyfl.gov/Portals/0/DeptFiles/CMR/Docs/StrategicPlan.pdf" |> DocumentRepresentation.fromRemoteIriReference
        module FY2025 = 
                let AnnualReport = IriReference "https://cms.leoncountyfl.gov/Portals/0/adam/Documents/AI0vCswaFkyX0tCKHBE7pQ/Link/LCAR-2025.pdf" |> DocumentRepresentation.fromRemoteIriReference
        module FY2026 = 
            module Budget = 
                module Adopted = 
                    let LeonCounty = IriReference "https://cms.leoncountyfl.gov/Portals/0/DeptFiles/OMB/Docs/AnnualBudget/FY2026AdoptedBudget.pdf" |> DocumentRepresentation.fromRemoteIriReference
                    let GeneralBudgetInformation = IriReference "https://www.leoncountyfl.gov/omb/budget26/docs/00-05%20-%20General%20Budget%20Information.pdf" |> DocumentRepresentation.fromRemoteIriReference 
                    let DepartmentofPublicWorks = IriReference "https://www.leoncountyfl.gov/omb/budget26/docs/11%20-%20Public%20Works.pdf" |> DocumentRepresentation.fromRemoteIriReference
                    let OfficeofInformationAndTechnology = IriReference "https://www.leoncountyfl.gov/omb/budget26/docs/09%20-%20Office%20of%20Information%20Technology.pdf" |> DocumentRepresentation.fromRemoteIriReference
                    let Appendix = IriReference "https://www.leoncountyfl.gov/omb/budget26/docs/26%20-%20Appendix.pdf" |> DocumentRepresentation.fromRemoteIriReference


open DocumentRepresentation.LeonCounty.FY2025
open DocumentRepresentation.LeonCounty.FY2026
open DocumentRepresentation.LeonCounty.FY2022.FY2026


type DictionaryToken with 
    member this.data = this.Data |> Seq.toArray

type Structure with 
        member this.catalogAcroForm = this.Catalog.CatalogDictionary.Data["AcroForm"]
        member this.catalogMarkInfo = this.Catalog.CatalogDictionary.Data["MarkInfo"]
        member this.catalogMetadata = this.Catalog.CatalogDictionary.Data["Metadata"]
        member this.catalogOCProperties = this.Catalog.CatalogDictionary.Data["OCProperties"]
        member this.catalogOutlines = this.Catalog.CatalogDictionary.Data["Outlines"]
        member this.catalogPages = this.Catalog.CatalogDictionary.Data["Pages"]
        member this.catalogStructTreeRoot = this.Catalog.CatalogDictionary.Data["StructTreeRoot"]
        member this.catalogType = this.Catalog.CatalogDictionary.Data["Type"]



Budget.Adopted.OfficeofInformationAndTechnology.mimeType
Budget.Adopted.OfficeofInformationAndTechnology.download()
Budget.Adopted.OfficeofInformationAndTechnology.localReference.DirectoryName |> clip
StrategicPlan.download()
StrategicPlan.localReference.DirectoryName |> clip

module OfficeofInformationAndTechnology =
    let pdf = PdfDocument.Open Budget.Adopted.OfficeofInformationAndTechnology.localReference.FullName
let testToken = OfficeofInformationAndTechnology.pdf.Structure.Catalog.CatalogDictionary.data[0].Value :?> IndirectReferenceToken
testToken
OfficeofInformationAndTechnology.pdf.Structure.Catalog.CatalogDictionary.data |> Array.iter (fun keyValuePair -> printfn "%s" keyValuePair.Key)
OfficeofInformationAndTechnology.pdf.Structure.catalogPages

DocumentRepresentation.LeonCounty.FY2026.Budget.Adopted.OfficeofInformationAndTechnology






//