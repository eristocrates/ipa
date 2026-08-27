// TODO add gnd to known ontologies https://d-nb.info/standards/elementset/gnd2012-06-30

#time on
open System
open System.Globalization
open System.Text
open System.Collections

open System.Xml
open System.Xml.Linq
open System.Xml.XPath
open System.Xml.Serialization
open System.Xml.Schema
open System.IO
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
    static member NormalizeIdentifier (is_restricted:bool) (identifier: string)  =
        match identifier with
        | _ when identifier.Contains(' ') ->
            Converters.ReplaceWhitespace(identifier,  "_")
            |> Binder.NormalizeIdentifier is_restricted
        | _ when identifier.Contains('-') ->
            identifier.Replace("-", "_")
            |> Binder.NormalizeIdentifier is_restricted
        | _ when not (Syntax.PrettyNaming.IsIdentifierFirstCharacter identifier[0]) ->
            "_" + identifier |> Binder.NormalizeIdentifier is_restricted
        | _ when Binder.KeywordNames.Contains(identifier) -> identifier + "_" |> Binder.NormalizeIdentifier is_restricted
        | _ when Syntax.PrettyNaming.DoesIdentifierNeedBackticks identifier && is_restricted  ->
            let backtickableIdentifier = identifier.Replace(Binder.BackTickExclusions,"")
            Syntax.PrettyNaming.NormalizeIdentifierBackticks backtickableIdentifier |> Binder.NormalizeIdentifier is_restricted
        | _ when Syntax.PrettyNaming.DoesIdentifierNeedBackticks identifier   ->
            Syntax.PrettyNaming.NormalizeIdentifierBackticks identifier |> Binder.NormalizeIdentifier is_restricted
        | _ -> identifier
    member this.binding = Binder.NormalizeIdentifier this.isBackTickRestricted this.identifier




type DirectoryInfo with 
    member this.ChildFiles(pattern:string) = Directory.GetFiles(this.FullName, pattern) |> Array.map FileInfo
    member this.DescendantFiles(pattern:string) = Directory.GetFiles(this.FullName, pattern, SearchOption.AllDirectories) |> Array.map FileInfo







module Folder = 
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




type Iri = 
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

      
and PrefixedName = 
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
    
        
    member this.lexicalForm = this.prefixId.namespaceName + this.localName
    member this.curieDelimited infixDelimiter = this.prefixId.prefixLabel + infixDelimiter + this.localName
    member this.curie = this.curieDelimited ":"
    member this.asUrl = DomUrl this.lexicalForm
    member this.asUri = Uri this.lexicalForm
    member this.asUriNode = new UriNode(this.asUri)
    member this.asINode :INode = this.asUriNode
    member this.asIriReference = IriReference this.lexicalForm
    member this.asRDFResource = new RDFResource(this.lexicalForm)

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

and SkolemizedName = 
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

and RdfLiteral = 
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

        let datatyped_literal =
            let invariant_string =
                if box value = null then
                    String.Empty
                else
                    Convert.ToString(value, CultureInfo.InvariantCulture)

            match box value with
            | :? Boolean as value -> { lexicalForm = (if value then "true" else "false") ; datatypeIri = PrefixId.xsd.prefix "boolean" }
            | :? (Byte array) as value -> { lexicalForm = Convert.ToBase64String(value) ; datatypeIri = PrefixId.xsd.prefix "base64Binary" }
            | :? Byte as value -> { lexicalForm = invariant_string ; datatypeIri = PrefixId.xsd.prefix "unsignedByte" }
            | :? DateOnly as value -> { lexicalForm = value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) ; datatypeIri = PrefixId.xsd.prefix "date" }
            | :? DateTime as value -> { lexicalForm = value.ToString("o", CultureInfo.InvariantCulture) ; datatypeIri = PrefixId.xsd.prefix "dateTime" }
            | :? DateTimeOffset as value -> { lexicalForm = value.ToString("o", CultureInfo.InvariantCulture) ; datatypeIri = PrefixId.xsd.prefix "dateTimeStamp" }
            | :? Decimal as value -> { lexicalForm = invariant_string ; datatypeIri = PrefixId.xsd.prefix "decimal" }
            | :? Double as value -> { lexicalForm = value.ToString("R", CultureInfo.InvariantCulture) ; datatypeIri = PrefixId.xsd.prefix "double" }
            | :? Int16 as value -> { lexicalForm = invariant_string ; datatypeIri = PrefixId.xsd.prefix "short" }
            | :? Int32 as value -> { lexicalForm = invariant_string ; datatypeIri = PrefixId.xsd.prefix "int" }
            | :? Int64 as value -> { lexicalForm = invariant_string ; datatypeIri = PrefixId.xsd.prefix "long" }
            | :? SByte as value -> { lexicalForm = invariant_string ; datatypeIri = PrefixId.xsd.prefix "byte" }
            | :? Single as value -> { lexicalForm = value.ToString("R", CultureInfo.InvariantCulture) ; datatypeIri = PrefixId.xsd.prefix "float" }
            | :? TimeOnly as value -> { lexicalForm = value.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture) ; datatypeIri = PrefixId.xsd.prefix "time" }
            | :? TimeSpan as value -> { lexicalForm = Xml.XmlConvert.ToString(value) ; datatypeIri = PrefixId.xsd.prefix "duration" }
            | :? UInt16 as value -> { lexicalForm = invariant_string ; datatypeIri = PrefixId.xsd.prefix "unsignedShort" }
            | :? UInt32 as value -> { lexicalForm = invariant_string ; datatypeIri = PrefixId.xsd.prefix "unsignedInt" }
            | :? UInt64 as value -> { lexicalForm = invariant_string ; datatypeIri = PrefixId.xsd.prefix "unsignedLong" }
            | :? Uri as value -> { lexicalForm = value.OriginalString ; datatypeIri = PrefixId.xsd.prefix "anyURI" }
            | :? DomUrl as value -> { lexicalForm = value.ToString() ; datatypeIri = PrefixId.xsd.prefix "anyURI" }
            | :? IriReference as value -> { lexicalForm = value.ToString() ; datatypeIri = PrefixId.xsd.prefix "anyURI" }
            | :? XmlQualifiedName as value -> { lexicalForm = value.ToString() ; datatypeIri = PrefixId.xsd.prefix "QName" }
            | :? Guid as value -> { lexicalForm = value.ToString() ; datatypeIri = PrefixId.xsd.prefix "ID" }
            | :? String as value -> { lexicalForm = value ; datatypeIri = PrefixId.xsd.prefix "string" }
            | null  -> { lexicalForm = "true" ; datatypeIri = PrefixId.xsi.prefix "nil" }
            | value -> { lexicalForm = invariant_string ; datatypeIri = PrefixId.xdt.prefix "anyAtomicType" }

        datatyped_literal |> DatatypedLiteral

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

and PlainLiteral = 
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
and LanguageString = 
  {
    lexicalForm:string
    languageTag:NLanguageTag.LanguageTag
  }
  member this.asObject = LanguageString this |> PlainLiteral |> LiteralObject
  member this.asRdfName = LanguageString this |> PlainLiteral |> LiteralName
  member this.curie = sprintf "%s@%s" this.lexicalForm this.languageTag.asString
and DirectedLanguageString =
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

and DatatypedLiteral = 
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
and [<CustomEquality ; CustomComparison>] RdfVariable = 
    {
        uuid :Guid
        identifier:string
        mutable bindingCell : Adaptive.cval<RdfTerm option>
    }
    static member fromVariableNode (variableNode:VariableNode) = 
            {
                uuid = new Guid()
                identifier = variableNode.VariableName
                bindingCell = Adaptive.cval (None:RdfTerm option)
            }
    static member fromIdentifier (identifier:string) = 
            {
                uuid = new Guid()
                identifier = identifier
                bindingCell = Adaptive.cval (None:RdfTerm option)
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
    member this.binding : Adaptive.aval<RdfTerm option> = this.bindingCell :> Adaptive.aval<RdfTerm option>
    member this.bind (rdfTerm:RdfTerm) = transact (fun () -> this.bindingCell.Value <- Some rdfTerm)
    member this.unbind() = transact (fun () -> this.bindingCell.Value <- None)
    member this.maybeTerm = this.binding |> Adaptive.AVal.force

    override this.Equals(other: obj) =
        match other with
        | :? RdfVariable as otherVariable -> this.uuid = otherVariable.uuid

        | _ -> false

    override this.GetHashCode() = this.uuid.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? RdfVariable as other_variable -> compare this.uuid other_variable.uuid 
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
        | IriSubject  iri -> IriRdfTerm iri
        | BlankSubject  blankReference -> BlankRdfTerm blankReference
        | VariableSubject  rdfVariable -> VariableRdfTerm rdfVariable
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
        | VariableSubject rdf_variable -> patternBuilder |> rdf_variable.asPatternItem
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
        | IriPredicate  iri -> IriRdfTerm iri
        | VariablePredicate  rdfVariable -> VariableRdfTerm rdfVariable
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
        | VariablePredicate rdf_variable -> patternBuilder |> rdf_variable.asPatternItem
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
        | IriObject  iri -> IriRdfTerm iri
        | BlankObject  blankReference -> BlankRdfTerm blankReference
        | LiteralObject  rdfLiteral -> LiteralRdfTerm rdfLiteral
        | TripleTermObject tripleTerm -> TripleRdfTerm tripleTerm
        | VariableObject  rdfVariable -> VariableRdfTerm rdfVariable
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
        | VariableObject rdf_variable -> patternBuilder |> rdf_variable.asPatternItem
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
    static member inline from_terms
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
    member this.rdfTerms =
        [| this.curSubject.asRdfTerm
           this.curPredicate.asRdfTerm
           this.curObject.asRdfTerm |]
    member this.curiesAndOrLexicalForms = 
        this.rdfTerms
         |> Array.map (fun rdfTerm -> defaultArg rdfTerm.maybeCurie rdfTerm.lexicalForm )
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


    member this.ITriplePatterns(pattern_builder: TriplePatternBuilder) : ITriplePattern array =
        this.triples
        |> Seq.toArray
        |> Array.map (fun rdf_triple -> pattern_builder |> rdf_triple.asITriplePattern)

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


and RdfTerm = 
  | IriRdfTerm of Iri
  | BlankRdfTerm of BlankReference
  | LiteralRdfTerm of RdfLiteral
  | TripleRdfTerm of RdfTripleTerm
  | VariableRdfTerm of RdfVariable
  | FormulaRdfTerm of Formula
  
    static member fromINode(inode: INode) =
        match inode.NodeType with
        | NodeType.Uri ->
            inode :?> UriNode
            |> Iri.fromUriNode
            |> IriRdfTerm
        | NodeType.Blank ->
            inode :?> BlankNode
            |> BlankReference.fromBlankNode
            |> BlankRdfTerm
        | NodeType.Literal ->
            inode :?> LiteralNode
            |> RdfLiteral.fromLiteralNode
            |> LiteralRdfTerm
        | NodeType.Triple ->
            inode :?> TripleNode
            |> RdfTripleTerm.fromTripleNode
            |> TripleRdfTerm
        | NodeType.Variable ->
            inode :?> VariableNode
            |> RdfVariable.fromVariableNode
            |> VariableRdfTerm
        | NodeType.GraphLiteral ->
           inode :?> GraphLiteralNode
           |> Formula.fromGraphLiteralNode
           |> FormulaRdfTerm
  member this.lexicalForm = 
    match this with 
    | IriRdfTerm iri -> iri.lexicalForm
    | BlankRdfTerm blankNode -> blankNode.lexicalForm
    | LiteralRdfTerm literal -> literal.lexicalForm
    | VariableRdfTerm variable -> variable.lexicalForm
    | TripleRdfTerm tripleTerm -> tripleTerm.lexicalForm
    | FormulaRdfTerm formula -> formula.lexicalForm
  member this.maybeCurie = 
    match this with 
    | IriRdfTerm iri -> iri.maybeCurie
    | BlankRdfTerm blankNode -> Some blankNode.curie
    | LiteralRdfTerm literal -> literal.maybeCurie
    | VariableRdfTerm variable -> None
    | TripleRdfTerm tripleTerm -> Some tripleTerm.curiesAndOrLexicalForms
    | FormulaRdfTerm formula -> Some formula.curiesAndOrLexicalForms



and Vertex =
    | SubjectVertex of RdfSubject
    | ObjectVertex of RdfObject


    member this.as_rendered_string (prefix_delimiter: string) (prefix_map: Map<string, string>) =
        match this with
        | SubjectVertex rdf_subject -> defaultArg rdf_subject.maybeCurie rdf_subject.lexicalForm
        | ObjectVertex rdf_object -> defaultArg  rdf_object.maybeCurie rdf_object.lexicalForm

and Edge =
    | PredicateEdge of RdfPredicate
    | TripleEdge of RdfTriple

    member this.as_rendered_string (prefix_delimiter: string) (prefix_map: Map<string, string>) =
        match this with
        | PredicateEdge rdf_predicate -> defaultArg rdf_predicate.maybeCurie rdf_predicate.lexicalForm
        | TripleEdge rdf_triple -> defaultArg rdf_triple.curPredicate.maybeCurie rdf_triple.lexicalForm

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

    member this.rdfTerms =
        this.triples
        |> PSeq.collect (fun triple -> triple.rdfTerms)
        |> PSeq.distinct
        |> Array.ofSeq
        |> Array.distinct

    member this.iris =
        this.rdfTerms
        |> Array.Parallel.choose (fun rdfTerm ->
            match rdfTerm with
            | IriRdfTerm iri -> Some iri
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
        |> Array.Parallel.map (fun prefixed_name -> prefixed_name.prefixId)
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
          | :? UriNode as uriNode -> Iri.fromUriNode uriNode |> IriRdfTerm
          | :? BlankNode as blankNode -> BlankReference.fromBlankNode blankNode |> BlankRdfTerm
          | :? LiteralNode as literalNode -> RdfLiteral.fromLiteralNode literalNode |> LiteralRdfTerm
          | :? TripleNode as tripleNode -> RdfTripleTerm.fromTripleNode tripleNode |> TripleRdfTerm 
          | :? VariableNode as variableNode -> RdfVariable.fromVariableNode variableNode |> VariableRdfTerm
          | :? GraphLiteralNode as graphLiteralNode -> Formula.fromGraphLiteralNode graphLiteralNode |> FormulaRdfTerm




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
  member this.rdfTerms = 
      this.asIGraph.AllNodes
    |> Seq.toArray
    |> Array.map RdfTerm.fromINode
  member this.iris = this.rdfTerms |> Array.choose (fun rdfTerm -> 
    match rdfTerm with 
    | IriRdfTerm iri -> Some iri
    | _ -> None
    )
  member this.prefixedNames = this.iris |> Array.choose (fun iri -> 
    match iri with 
    | PrefixedIri prefixedName -> Some prefixedName
    | _ -> None
    )

  member this.literals = this.rdfTerms |> Array.choose (fun rdfTerm -> 
    match rdfTerm with 
    | LiteralRdfTerm literal -> Some literal
    | _ -> None
    )
  member this.blankNodes = this.rdfTerms |> Array.choose (fun rdfTerm -> 
    match rdfTerm with 
    | BlankRdfTerm blankNode -> Some blankNode
    | _ -> None
    )

  member this.namespacedNames (namespacePrefixId:PrefixId) = 
      this.prefixedNames |> Array.filter (fun prefixedName -> prefixedName.prefixId.namespaceName = namespacePrefixId.namespaceName) |> Array.sortBy (fun prefixedName -> prefixedName.localName)







module RdfLiteral =



    let true_ = RdfLiteral.autotyped true
    let false_ = RdfLiteral.autotyped false

    module Binary =

        let base64 (bytes: Byte array) =
            let value_string = Convert.ToBase64String(bytes)

            PrefixId.xsd.prefix "base64Binary"
            |> RdfLiteral.datatyped value_string

        let hex (bytes: Byte array) =
            let value_string = Convert.ToHexString(bytes)

            PrefixId.xsd.prefix "hexBinary"
            |> RdfLiteral.datatyped value_string


    module Temporal =
        module duration =
            let timeDuration (timespan: TimeSpan) =
                let value_string = Xml.XmlConvert.ToString(timespan)

                PrefixId.xsd.prefix "duration"
                |> RdfLiteral.datatyped value_string

            let dayTimeDuration (timespan: TimeSpan) =
                let value_string = Xml.XmlConvert.ToString(timespan)

                PrefixId.xdt.prefix "dayTimeDuration"
                |> RdfLiteral.datatyped value_string


            let yearMonthDuration (years: int) (months: int) =
                let total_months = years * 12 + months

                let value_string =
                    if total_months = 0 then
                        "P0M"
                    else
                        let absolute_months = abs total_months
                        let years_part = absolute_months / 12
                        let months_part = absolute_months % 12
                        let sign = if total_months < 0 then "-" else ""

                        let year_text =
                            if years_part = 0 then
                                ""
                            else
                                $"{years_part}Y"

                        let month_text =
                            if months_part = 0 then
                                ""
                            else
                                $"{months_part}M"

                        $"{sign}P{year_text}{month_text}"

                PrefixId.xdt.prefix "yearMonthDuration"
                |> RdfLiteral.datatyped value_string


        module date =

            let only (date: DateOnly) =
                let value_string = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "date"
                |> RdfLiteral.datatyped value_string

            let from_datetime (datetime: DateTime) =
                let value_string = datetime.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "date"
                |> RdfLiteral.datatyped value_string

            let time (datetime: DateTime) =
                let value_string = datetime.ToString("o", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "dateTime"
                |> RdfLiteral.datatyped value_string

            let timeStamp (datetime_offset: DateTimeOffset) =
                let value_string = datetime_offset.ToString("o", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "dateTimeStamp"
                |> RdfLiteral.datatyped value_string



        module time =

            let only (time: TimeOnly) =
                let value_string = time.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "time"
                |> RdfLiteral.datatyped value_string

            let from_datetime (datetime: DateTime) =
                let value_string =
                    datetime.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "time"
                |> RdfLiteral.datatyped value_string

        module period =

            let day (datetime: DateTime) =
                let value_string =
                    $"""---{datetime.Day.ToString("00", CultureInfo.InvariantCulture)}"""

                PrefixId.xsd.prefix "gDay"
                |> RdfLiteral.datatyped value_string


            let month (datetime: DateTime) =
                let value_string =
                    $"""--{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}"""

                PrefixId.xsd.prefix "gMonth"
                |> RdfLiteral.datatyped value_string


            let monthDay (datetime: DateTime) =
                let value_string =
                    $"""--{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}-{datetime.Day.ToString("00", CultureInfo.InvariantCulture)}"""

                PrefixId.xsd.prefix "gMonthDay"
                |> RdfLiteral.datatyped value_string


            let year (datetime: DateTime) =
                let value_string = datetime.Year.ToString("0000", CultureInfo.InvariantCulture)

                PrefixId.xsd.prefix "gYear"
                |> RdfLiteral.datatyped value_string


            let yearMonth (datetime: DateTime) =
                let value_string =
                    $"""{datetime.Year.ToString("0000", CultureInfo.InvariantCulture)}-{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}"""

                PrefixId.xsd.prefix "gYearMonth"
                |> RdfLiteral.datatyped value_string
            let generalDay (day: int) =
                // TODO find a strongly typed parse instead of validation
                // test <@ day >= 1 && day <= 99 @>
                let value_string = $"""---{day.ToString("00", CultureInfo.InvariantCulture)}"""

                PrefixId.owlTime.prefix "generalDay"
                |> RdfLiteral.datatyped value_string


            let generalMonth (month: int) =
                // TODO find a strongly typed parse instead of validation
                // test <@ month >= 1 && month <= 20 @>
                let value_string = $"""--{month.ToString("00", CultureInfo.InvariantCulture)}"""

                PrefixId.owlTime.prefix "generalMonth"
                |> RdfLiteral.datatyped value_string


            let generalYear (year: int) =
                let value_string = year.ToString("0000", CultureInfo.InvariantCulture)

                PrefixId.owlTime.prefix "generalYear"
                |> RdfLiteral.datatyped value_string


    module Numeric =

        let private bigint_value_string (value: bigint) =
            value.ToString(CultureInfo.InvariantCulture)

        let integer (value: bigint) =
            PrefixId.xsd.prefix "integer"
            |> RdfLiteral.datatyped (bigint_value_string value)

        let negativeInteger (value: bigint) =
            // TODO find a strongly typed parse instead of validation
            // test <@ value < 0I @>

            PrefixId.xsd.prefix "negativeInteger"
            |> RdfLiteral.datatyped (bigint_value_string value)

        let nonNegativeInteger (value: bigint) =
            // TODO find a strongly typed parse instead of validation
            // test <@ value >= 0I @>

            PrefixId.xsd.prefix "nonNegativeInteger"
            |> RdfLiteral.datatyped (bigint_value_string value)

        let nonPositiveInteger (value: bigint) =
            // TODO find a strongly typed parse instead of validation
            // test <@ value <= 0I @>

            PrefixId.xsd.prefix "nonPositiveInteger"
            |> RdfLiteral.datatyped (bigint_value_string value)

        let positiveInteger (value: bigint) =
            // TODO find a strongly typed parse instead of validation
            // test <@ value > 0I @>

            PrefixId.xsd.prefix "positiveInteger"
            |> RdfLiteral.datatyped (bigint_value_string value)
















type SparqlResultSet with
    member this.columnByVariables(rdfVariable: RdfVariable) =
        this.Results
        |> Seq.map (fun result ->
            result.Item rdfVariable.identifier
            |> RdfTerm.fromINode)
        |> Seq.toArray

// ─────────────────────────────────────────────────────────────
// Existing dotNetRDF query-form adapters
// ─────────────────────────────────────────────────────────────

let SELECT_ALL () : ISelectBuilder = QueryBuilder.SelectAll()


let SELECT (variables: RdfVariable seq) : ISelectBuilder =
    variables
    |> Seq.map (fun variable -> variable.identifier)
    |> Seq.toArray
    |> QueryBuilder.Select


let CONSTRUCT (pattern_builder: TriplePatternBuilder) (formula: Formula) : IQueryBuilder =
    QueryBuilder.Construct(
        Action<IDescribeGraphPatternBuilder> (fun construct_template ->
            construct_template.Where(pattern_builder |> formula.ITriplePatterns)
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


let repair_describe_variables (query: SparqlQuery) : SparqlQuery =
    if query.QueryType = SparqlQueryType.Describe then

        let query_variables = query.Variables :?> Generic.ICollection<SparqlVariable>

        query.DescribeVariables
        |> Seq.filter (fun token -> token.TokenType = Token.VARIABLE)
        |> Seq.iter (fun token ->

            let variable_name = token.Value.Substring(1)

            let already_registered =
                query_variables
                |> Seq.exists (fun variable -> variable.Name = variable_name)

            if not already_registered then
                query_variables.Add(SparqlVariable(variable_name, true)))

    query


let WHERE (pattern_builder: TriplePatternBuilder) (formula: Formula) (query_builder: IQueryBuilder) : SparqlQuery =
    query_builder
        .Where(pattern_builder |> formula.ITriplePatterns)
        .BuildQuery()
    |> repair_describe_variables


let private process_query (graph: IGraph) (query: SparqlQuery) : obj =
    let dataset = new InMemoryDataset(graph)

    let processor = new LeviathanQueryProcessor(dataset)

    processor.ProcessQuery(query)


type From_Where_Draft =
    { source_graph: IGraph option
      where_formula: Formula option }


let private empty_from_where_draft =
    { source_graph = None
      where_formula = None }


type From_Where_Builder<'Result>(execute: IGraph -> Formula -> 'Result) =

    member _.Yield(_: unit) : From_Where_Draft = empty_from_where_draft

    member _.Zero() : From_Where_Draft = empty_from_where_draft

    member _.For(_draft: From_Where_Draft, continuation: unit -> From_Where_Draft) : From_Where_Draft = continuation ()


    [<CustomOperation("from")>]
    member _.From(draft: From_Where_Draft, graph: IGraph) : From_Where_Draft =
        match draft.source_graph with
        | Some _ -> invalidOp "The query already contains a source graph."

        | None -> { draft with source_graph = Some graph }


    [<CustomOperation("where")>]
    member _.Where(draft: From_Where_Draft, formula: Formula) : From_Where_Draft =
        match draft.where_formula with
        | Some _ -> invalidOp "The query already contains a where clause."

        | None -> { draft with where_formula = Some formula }


    member _.Run(draft: From_Where_Draft) : 'Result =
        let graph =
            match draft.source_graph with
            | Some graph -> graph

            | None -> invalidOp "The query requires a graph supplied with 'from'."


        let where_formula =
            match draft.where_formula with
            | Some formula -> formula

            | None -> invalidOp "The query requires a 'where' clause."


        execute graph where_formula

type From_Draft = { source_graph: IGraph option }


let private empty_from_draft = { source_graph = None }


type From_Builder<'Result>(execute: IGraph -> 'Result) =

    member _.Yield(_: unit) : From_Draft = empty_from_draft

    member _.Zero() : From_Draft = empty_from_draft

    member _.For(_draft: From_Draft, continuation: unit -> From_Draft) : From_Draft = continuation ()


    [<CustomOperation("from")>]
    member _.From(draft: From_Draft, graph: IGraph) : From_Draft =
        match draft.source_graph with
        | Some _ -> invalidOp "The query already contains a source graph."

        | None -> { draft with source_graph = Some graph }


    member _.Run(draft: From_Draft) : 'Result =
        let graph =
            match draft.source_graph with
            | Some graph -> graph

            | None -> invalidOp "The query requires a graph supplied with 'from'."


        execute graph

module sparql =

    let select (variables: RdfVariable seq) : From_Where_Builder<SparqlResultSet> =
        From_Where_Builder<SparqlResultSet> (fun graph where_formula ->

            let pattern_builder = TriplePatternBuilder(graph.NamespaceMap)

            let query_builder = SELECT variables :> IQueryBuilder

            let query =
                query_builder
                |> WHERE pattern_builder where_formula

            process_query graph query :?> SparqlResultSet)


    let select_all: From_Where_Builder<SparqlResultSet> =
        From_Where_Builder<SparqlResultSet> (fun graph where_formula ->

            let pattern_builder = TriplePatternBuilder(graph.NamespaceMap)

            let query_builder = SELECT_ALL() :> IQueryBuilder

            let query =
                query_builder
                |> WHERE pattern_builder where_formula

            process_query graph query :?> SparqlResultSet)


    let construct (construct_formula: Formula) : From_Where_Builder<IGraph> =
        From_Where_Builder<IGraph> (fun graph where_formula ->

            let pattern_builder = TriplePatternBuilder(graph.NamespaceMap)

            let query_builder = CONSTRUCT pattern_builder construct_formula

            let query =
                query_builder
                |> WHERE pattern_builder where_formula

            process_query graph query :?> IGraph)


    let ask: From_Where_Builder<bool> =
        From_Where_Builder<bool> (fun graph where_formula ->

            let pattern_builder = TriplePatternBuilder(graph.NamespaceMap)

            let query = ASK() |> WHERE pattern_builder where_formula

            let result_set = process_query graph query :?> SparqlResultSet

            result_set.Result)


    let discover (variables: RdfVariable seq) : From_Where_Builder<IGraph> =
        From_Where_Builder<IGraph> (fun graph where_formula ->

            let pattern_builder = TriplePatternBuilder(graph.NamespaceMap)

            let query_builder = DISCOVER variables :> IQueryBuilder

            let query =
                query_builder
                |> WHERE pattern_builder where_formula

            process_query graph query :?> IGraph)


    let describe (iris: Iri seq) : From_Builder<IGraph> =
        From_Builder<IGraph> (fun graph ->

            let query = DESCRIBE iris

            process_query graph query :?> IGraph)




















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

let inline (!<=) value_object =
    RdfLiteral.autotyped value_object
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

let inline (->=) (predicate: ^PredicateType when ^PredicateType: (member asPredicate: RdfPredicate)) value_object =
    PredicateObjectList.fromTerms
        predicate.asPredicate
        [| RdfLiteral.autotyped value_object
           |> RdfObject.LiteralObject |]


let inline (->=|) (predicate: ^PredicateType when ^PredicateType: (member asPredicate: RdfPredicate)) value_objects =
    let objects =
        value_objects
        |> List.map (fun value_object ->
            RdfLiteral.autotyped value_object
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
    let materialized_draft =
        draft.addRdfSubject subjectTerm.asSubject
        |> Formula.materializeFormula

    { materialized_draft with

        subjects = [| subjectTerm.asSubject |]

     }

let inline (-->/) (draft: Formula) (objectTerm: ^ObjectType when ^ObjectType: (member asObject: RdfObject)) =
    let materialized_draft =
        draft.addRdfObject objectTerm.asObject
        |> Formula.materializeFormula

    { materialized_draft with

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

let inline (-*|) (draft: Formula) (formula_list: Formula list) =
    formula_list
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
        | Some ontologyResource -> ontologyResource.DifferentFrom |> Seq.map (fun inode -> RdfTerm.fromINode inode ) |> Seq.toArray
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
        | Some ontologyResource -> ontologyResource.IsDefinedBy |> Seq.map (fun inode -> RdfTerm.fromINode inode ) |> Seq.toArray
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
        | Some ontologyResource -> ontologyResource.SameAs |> Seq.map (fun inode -> RdfTerm.fromINode inode ) |> Seq.toArray
        | None -> [||]
    member inline this.termSeeAlso<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> ontologyResource.SeeAlso |> Seq.map (fun inode -> RdfTerm.fromINode inode ) |> Seq.toArray
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
        | Some ontologyResource -> ontologyResource.Types |> Seq.map (fun inode -> RdfTerm.fromINode inode ) |> Seq.toArray
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
                        let astValue = Ast.Value(binding, $"""{vocabulary.prefixId.prefixLabel}Vocabulary.termByName["{namespacedName.localName}"] |> PrefixedIri""" )
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

module PrefixId = 
      let foaf = PrefixId.fromNamespaceLabel "http://xmlns.com/foaf/0.1/" "foaf" 
      let vs = PrefixId.fromNamespaceLabel "http://www.w3.org/2003/06/sw-vocab-status/ns#" "vs" 

let rdfVocabulary = RdfVocabulary.fromPrefixId PrefixId.rdf
let rdfsVocabulary = RdfVocabulary.fromPrefixId PrefixId.rdfs
let owlVocabulary = RdfVocabulary.fromPrefixId PrefixId.owl
let foafVocabulary = RdfVocabulary.fromPrefixId PrefixId.foaf
let vsVocabulary = RdfVocabulary.fromPrefixId PrefixId.vs








(*


RdfVocabulary.asModule rdfVocabulary |> clip
RdfVocabulary.asModule rdfsVocabulary |> clip
RdfVocabulary.asModule owlVocabulary |> clip
RdfVocabulary.asModule foafVocabulary |> clip
RdfVocabulary.asModule vsVocabulary |> clip


*)




module vs =
    let _namespaceIri = vsVocabulary.termByName[""] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : more information about the status etc of a term, typically human oriented^^xsd:string</para>
    ///   <para>rdfs:label : more info^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/06/sw-vocab-status/ns#moreinfo">vs:moreinfo</a>
    /// </summary>
    let moreinfo = vsVocabulary.termByName["moreinfo"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : the status of a vocabulary term, expressed as a short symbolic string; known values include 'unstable','testing', 'stable' and 'archaic'^^xsd:string</para>
    ///   <para>rdfs:label : term status^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/06/sw-vocab-status/ns#term_status">vs:term_status</a>
    /// </summary>
    let term_status = vsVocabulary.termByName["term_status"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : human-oriented documentation, examples etc for use of this term^^xsd:string</para>
    ///   <para>rdfs:label : user docs^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/06/sw-vocab-status/ns#userdocs">vs:userdocs</a>
    /// </summary>
    let userdocs = vsVocabulary.termByName["userdocs"] |> PrefixedIri


module rdf =
    let _namespaceIri = rdfVocabulary.termByName[""] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of containers of alternatives.^^xsd:string</para>
    ///   <para>rdfs:label : Alt^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt">rdf:Alt</a>
    /// </summary>
    let Alt = rdfVocabulary.termByName["Alt"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of unordered containers.^^xsd:string</para>
    ///   <para>rdfs:label : Bag^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag">rdf:Bag</a>
    /// </summary>
    let Bag = rdfVocabulary.termByName["Bag"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A class representing a compound literal.^^xsd:string</para>
    ///   <para>rdfs:label : CompoundLiteral^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#CompoundLiteral">rdf:CompoundLiteral</a>
    /// </summary>
    let CompoundLiteral = rdfVocabulary.termByName["CompoundLiteral"] |> PrefixedIri
    let HTML = rdfVocabulary.termByName["HTML"] |> PrefixedIri
    let JSON = rdfVocabulary.termByName["JSON"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of RDF Lists.^^xsd:string</para>
    ///   <para>rdfs:label : List^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#List">rdf:List</a>
    /// </summary>
    let List = rdfVocabulary.termByName["List"] |> PrefixedIri
    let PlainLiteral = rdfVocabulary.termByName["PlainLiteral"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of RDF properties.^^xsd:string</para>
    ///   <para>rdfs:label : Property^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Property">rdf:Property</a>
    /// </summary>
    let Property = rdfVocabulary.termByName["Property"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of ordered containers.^^xsd:string</para>
    ///   <para>rdfs:label : Seq^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq">rdf:Seq</a>
    /// </summary>
    let Seq = rdfVocabulary.termByName["Seq"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of RDF statements.^^xsd:string</para>
    ///   <para>rdfs:label : Statement^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement">rdf:Statement</a>
    /// </summary>
    let Statement = rdfVocabulary.termByName["Statement"] |> PrefixedIri
    let XMLLiteral = rdfVocabulary.termByName["XMLLiteral"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The base direction component of a CompoundLiteral.^^xsd:string</para>
    ///   <para>rdfs:label : direction^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#direction">rdf:direction</a>
    /// </summary>
    let direction = rdfVocabulary.termByName["direction"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The first item in the subject RDF list.^^xsd:string</para>
    ///   <para>rdfs:label : first^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#first">rdf:first</a>
    /// </summary>
    let first = rdfVocabulary.termByName["first"] |> PrefixedIri
    let langString = rdfVocabulary.termByName["langString"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The language component of a CompoundLiteral.^^xsd:string</para>
    ///   <para>rdfs:label : language^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#language">rdf:language</a>
    /// </summary>
    let language = rdfVocabulary.termByName["language"] |> PrefixedIri
    let nil = rdfVocabulary.termByName["nil"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The object of the subject RDF statement.^^xsd:string</para>
    ///   <para>rdfs:label : object^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#object">rdf:object</a>
    /// </summary>
    let object = rdfVocabulary.termByName["object"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The predicate of the subject RDF statement.^^xsd:string</para>
    ///   <para>rdfs:label : predicate^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate">rdf:predicate</a>
    /// </summary>
    let predicate = rdfVocabulary.termByName["predicate"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The rest of the subject RDF list after the first item.^^xsd:string</para>
    ///   <para>rdfs:label : rest^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#rest">rdf:rest</a>
    /// </summary>
    let rest = rdfVocabulary.termByName["rest"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The subject of the subject RDF statement.^^xsd:string</para>
    ///   <para>rdfs:label : subject^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#subject">rdf:subject</a>
    /// </summary>
    let subject = rdfVocabulary.termByName["subject"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The subject is an instance of a class.^^xsd:string</para>
    ///   <para>rdfs:label : type^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#type">rdf:type</a>
    /// </summary>
    let type_ = rdfVocabulary.termByName["type"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : Idiomatic property used for structured values.^^xsd:string</para>
    ///   <para>rdfs:label : value^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#value">rdf:value</a>
    /// </summary>
    let value = rdfVocabulary.termByName["value"] |> PrefixedIri






module rdfs =
    let _namespaceIri = rdfsVocabulary.termByName[""] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of classes.^^xsd:string</para>
    ///   <para>rdfs:label : Class^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#Class">rdfs:Class</a>
    /// </summary>
    let Class = rdfsVocabulary.termByName["Class"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of RDF containers.^^xsd:string</para>
    ///   <para>rdfs:label : Container^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#Container">rdfs:Container</a>
    /// </summary>
    let Container = rdfsVocabulary.termByName["Container"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The class of container membership properties, rdf:_1, rdf:_2, ...,
    ///                     all of which are sub-properties of 'member'.^^xsd:string</para>
    ///   <para>rdfs:label : ContainerMembershipProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty">rdfs:ContainerMembershipProperty</a>
    /// </summary>
    let ContainerMembershipProperty =
        rdfsVocabulary.termByName["ContainerMembershipProperty"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The class of RDF datatypes.^^xsd:string</para>
    ///   <para>rdfs:label : Datatype^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#Datatype">rdfs:Datatype</a>
    /// </summary>
    let Datatype = rdfsVocabulary.termByName["Datatype"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of literal values, eg. textual strings and integers.^^xsd:string</para>
    ///   <para>rdfs:label : Literal^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#Literal">rdfs:Literal</a>
    /// </summary>
    let Literal = rdfsVocabulary.termByName["Literal"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class resource, everything.^^xsd:string</para>
    ///   <para>rdfs:label : Resource^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#Resource">rdfs:Resource</a>
    /// </summary>
    let Resource = rdfsVocabulary.termByName["Resource"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A description of the subject resource.^^xsd:string</para>
    ///   <para>rdfs:label : comment^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#comment">rdfs:comment</a>
    /// </summary>
    let comment = rdfsVocabulary.termByName["comment"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A domain of the subject property.^^xsd:string</para>
    ///   <para>rdfs:label : domain^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#domain">rdfs:domain</a>
    /// </summary>
    let domain = rdfsVocabulary.termByName["domain"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The defininition of the subject resource.^^xsd:string</para>
    ///   <para>rdfs:label : isDefinedBy^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#isDefinedBy">rdfs:isDefinedBy</a>
    /// </summary>
    let isDefinedBy = rdfsVocabulary.termByName["isDefinedBy"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A human-readable name for the subject.^^xsd:string</para>
    ///   <para>rdfs:label : label^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#label">rdfs:label</a>
    /// </summary>
    let label = rdfsVocabulary.termByName["label"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A member of the subject resource.^^xsd:string</para>
    ///   <para>rdfs:label : member^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#member">rdfs:member</a>
    /// </summary>
    let member_ = rdfsVocabulary.termByName["member"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A range of the subject property.^^xsd:string</para>
    ///   <para>rdfs:label : range^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#range">rdfs:range</a>
    /// </summary>
    let range = rdfsVocabulary.termByName["range"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : Further information about the subject resource.^^xsd:string</para>
    ///   <para>rdfs:label : seeAlso^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#seeAlso">rdfs:seeAlso</a>
    /// </summary>
    let seeAlso = rdfsVocabulary.termByName["seeAlso"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The subject is a subclass of a class.^^xsd:string</para>
    ///   <para>rdfs:label : subClassOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#subClassOf">rdfs:subClassOf</a>
    /// </summary>
    let subClassOf = rdfsVocabulary.termByName["subClassOf"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The subject is a subproperty of a property.^^xsd:string</para>
    ///   <para>rdfs:label : subPropertyOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/01/rdf-schema#subPropertyOf">rdfs:subPropertyOf</a>
    /// </summary>
    let subPropertyOf = rdfsVocabulary.termByName["subPropertyOf"] |> PrefixedIri


module owl =
    let _namespaceIri = owlVocabulary.termByName[""] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of collections of pairwise different individuals.^^xsd:string</para>
    ///   <para>rdfs:label : AllDifferent^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#AllDifferent">owl:AllDifferent</a>
    /// </summary>
    let AllDifferent = owlVocabulary.termByName["AllDifferent"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The class of collections of pairwise disjoint classes.^^xsd:string</para>
    ///   <para>rdfs:label : AllDisjointClasses^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#AllDisjointClasses">owl:AllDisjointClasses</a>
    /// </summary>
    let AllDisjointClasses =
        owlVocabulary.termByName["AllDisjointClasses"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The class of collections of pairwise disjoint properties.^^xsd:string</para>
    ///   <para>rdfs:label : AllDisjointProperties^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#AllDisjointProperties">owl:AllDisjointProperties</a>
    /// </summary>
    let AllDisjointProperties =
        owlVocabulary.termByName["AllDisjointProperties"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The class of annotated annotations for which the RDF serialization consists of an annotated subject, predicate and object.^^xsd:string</para>
    ///   <para>rdfs:label : Annotation^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Annotation">owl:Annotation</a>
    /// </summary>
    let Annotation = owlVocabulary.termByName["Annotation"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The class of annotation properties.^^xsd:string</para>
    ///   <para>rdfs:label : AnnotationProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#AnnotationProperty">owl:AnnotationProperty</a>
    /// </summary>
    let AnnotationProperty =
        owlVocabulary.termByName["AnnotationProperty"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The class of asymmetric properties.^^xsd:string</para>
    ///   <para>rdfs:label : AsymmetricProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#AsymmetricProperty">owl:AsymmetricProperty</a>
    /// </summary>
    let AsymmetricProperty =
        owlVocabulary.termByName["AsymmetricProperty"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The class of annotated axioms for which the RDF serialization consists of an annotated subject, predicate and object.^^xsd:string</para>
    ///   <para>rdfs:label : Axiom^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Axiom">owl:Axiom</a>
    /// </summary>
    let Axiom = owlVocabulary.termByName["Axiom"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of OWL classes.^^xsd:string</para>
    ///   <para>rdfs:label : Class^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Class">owl:Class</a>
    /// </summary>
    let Class = owlVocabulary.termByName["Class"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of OWL data ranges, which are special kinds of datatypes. Note: The use of the IRI owl:DataRange has been deprecated as of OWL 2. The IRI rdfs:Datatype SHOULD be used instead.^^xsd:string</para>
    ///   <para>rdfs:label : DataRange^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#DataRange">owl:DataRange</a>
    /// </summary>
    let DataRange = owlVocabulary.termByName["DataRange"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of data properties.^^xsd:string</para>
    ///   <para>rdfs:label : DatatypeProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#DatatypeProperty">owl:DatatypeProperty</a>
    /// </summary>
    let DatatypeProperty = owlVocabulary.termByName["DatatypeProperty"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of deprecated classes.^^xsd:string</para>
    ///   <para>rdfs:label : DeprecatedClass^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#DeprecatedClass">owl:DeprecatedClass</a>
    /// </summary>
    let DeprecatedClass = owlVocabulary.termByName["DeprecatedClass"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The class of deprecated properties.^^xsd:string</para>
    ///   <para>rdfs:label : DeprecatedProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#DeprecatedProperty">owl:DeprecatedProperty</a>
    /// </summary>
    let DeprecatedProperty =
        owlVocabulary.termByName["DeprecatedProperty"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The class of functional properties.^^xsd:string</para>
    ///   <para>rdfs:label : FunctionalProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#FunctionalProperty">owl:FunctionalProperty</a>
    /// </summary>
    let FunctionalProperty =
        owlVocabulary.termByName["FunctionalProperty"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The class of inverse-functional properties.^^xsd:string</para>
    ///   <para>rdfs:label : InverseFunctionalProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#InverseFunctionalProperty">owl:InverseFunctionalProperty</a>
    /// </summary>
    let InverseFunctionalProperty =
        owlVocabulary.termByName["InverseFunctionalProperty"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The class of irreflexive properties.^^xsd:string</para>
    ///   <para>rdfs:label : IrreflexiveProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#IrreflexiveProperty">owl:IrreflexiveProperty</a>
    /// </summary>
    let IrreflexiveProperty =
        owlVocabulary.termByName["IrreflexiveProperty"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The class of named individuals.^^xsd:string</para>
    ///   <para>rdfs:label : NamedIndividual^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#NamedIndividual">owl:NamedIndividual</a>
    /// </summary>
    let NamedIndividual = owlVocabulary.termByName["NamedIndividual"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The class of negative property assertions.^^xsd:string</para>
    ///   <para>rdfs:label : NegativePropertyAssertion^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#NegativePropertyAssertion">owl:NegativePropertyAssertion</a>
    /// </summary>
    let NegativePropertyAssertion =
        owlVocabulary.termByName["NegativePropertyAssertion"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : This is the empty class.^^xsd:string</para>
    ///   <para>rdfs:label : Nothing^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Nothing">owl:Nothing</a>
    /// </summary>
    let Nothing = owlVocabulary.termByName["Nothing"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of object properties.^^xsd:string</para>
    ///   <para>rdfs:label : ObjectProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#ObjectProperty">owl:ObjectProperty</a>
    /// </summary>
    let ObjectProperty = owlVocabulary.termByName["ObjectProperty"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of ontologies.^^xsd:string</para>
    ///   <para>rdfs:label : Ontology^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Ontology">owl:Ontology</a>
    /// </summary>
    let Ontology = owlVocabulary.termByName["Ontology"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of ontology properties.^^xsd:string</para>
    ///   <para>rdfs:label : OntologyProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#OntologyProperty">owl:OntologyProperty</a>
    /// </summary>
    let OntologyProperty = owlVocabulary.termByName["OntologyProperty"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of reflexive properties.^^xsd:string</para>
    ///   <para>rdfs:label : ReflexiveProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#ReflexiveProperty">owl:ReflexiveProperty</a>
    /// </summary>
    let ReflexiveProperty = owlVocabulary.termByName["ReflexiveProperty"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of property restrictions.^^xsd:string</para>
    ///   <para>rdfs:label : Restriction^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Restriction">owl:Restriction</a>
    /// </summary>
    let Restriction = owlVocabulary.termByName["Restriction"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of symmetric properties.^^xsd:string</para>
    ///   <para>rdfs:label : SymmetricProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#SymmetricProperty">owl:SymmetricProperty</a>
    /// </summary>
    let SymmetricProperty = owlVocabulary.termByName["SymmetricProperty"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The class of OWL individuals.^^xsd:string</para>
    ///   <para>rdfs:label : Thing^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Thing">owl:Thing</a>
    /// </summary>
    let Thing = owlVocabulary.termByName["Thing"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The class of transitive properties.^^xsd:string</para>
    ///   <para>rdfs:label : TransitiveProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#TransitiveProperty">owl:TransitiveProperty</a>
    /// </summary>
    let TransitiveProperty =
        owlVocabulary.termByName["TransitiveProperty"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the class that a universal property restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : allValuesFrom^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#allValuesFrom">owl:allValuesFrom</a>
    /// </summary>
    let allValuesFrom = owlVocabulary.termByName["allValuesFrom"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the predicate of an annotated axiom or annotated annotation.^^xsd:string</para>
    ///   <para>rdfs:label : annotatedProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#annotatedProperty">owl:annotatedProperty</a>
    /// </summary>
    let annotatedProperty = owlVocabulary.termByName["annotatedProperty"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the subject of an annotated axiom or annotated annotation.^^xsd:string</para>
    ///   <para>rdfs:label : annotatedSource^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#annotatedSource">owl:annotatedSource</a>
    /// </summary>
    let annotatedSource = owlVocabulary.termByName["annotatedSource"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the object of an annotated axiom or annotated annotation.^^xsd:string</para>
    ///   <para>rdfs:label : annotatedTarget^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#annotatedTarget">owl:annotatedTarget</a>
    /// </summary>
    let annotatedTarget = owlVocabulary.termByName["annotatedTarget"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the predicate of a negative property assertion.^^xsd:string</para>
    ///   <para>rdfs:label : assertionProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#assertionProperty">owl:assertionProperty</a>
    /// </summary>
    let assertionProperty = owlVocabulary.termByName["assertionProperty"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The annotation property that indicates that a given ontology is backward compatible with another ontology.^^xsd:string</para>
    ///   <para>rdfs:label : backwardCompatibleWith^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#backwardCompatibleWith">owl:backwardCompatibleWith</a>
    /// </summary>
    let backwardCompatibleWith =
        owlVocabulary.termByName["backwardCompatibleWith"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The data property that does not relate any individual to any data value.^^xsd:string</para>
    ///   <para>rdfs:label : bottomDataProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#bottomDataProperty">owl:bottomDataProperty</a>
    /// </summary>
    let bottomDataProperty =
        owlVocabulary.termByName["bottomDataProperty"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The object property that does not relate any two individuals.^^xsd:string</para>
    ///   <para>rdfs:label : bottomObjectProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#bottomObjectProperty">owl:bottomObjectProperty</a>
    /// </summary>
    let bottomObjectProperty =
        owlVocabulary.termByName["bottomObjectProperty"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the cardinality of an exact cardinality restriction.^^xsd:string</para>
    ///   <para>rdfs:label : cardinality^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#cardinality">owl:cardinality</a>
    /// </summary>
    let cardinality = owlVocabulary.termByName["cardinality"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines that a given class is the complement of another class.^^xsd:string</para>
    ///   <para>rdfs:label : complementOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#complementOf">owl:complementOf</a>
    /// </summary>
    let complementOf = owlVocabulary.termByName["complementOf"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The property that determines that a given data range is the complement of another data range with respect to the data domain.^^xsd:string</para>
    ///   <para>rdfs:label : datatypeComplementOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#datatypeComplementOf">owl:datatypeComplementOf</a>
    /// </summary>
    let datatypeComplementOf =
        owlVocabulary.termByName["datatypeComplementOf"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The annotation property that indicates that a given entity has been deprecated.^^xsd:string</para>
    ///   <para>rdfs:label : deprecated^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#deprecated">owl:deprecated</a>
    /// </summary>
    let deprecated = owlVocabulary.termByName["deprecated"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given individuals are different.^^xsd:string</para>
    ///   <para>rdfs:label : differentFrom^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#differentFrom">owl:differentFrom</a>
    /// </summary>
    let differentFrom = owlVocabulary.termByName["differentFrom"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines that a given class is equivalent to the disjoint union of a collection of other classes.^^xsd:string</para>
    ///   <para>rdfs:label : disjointUnionOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#disjointUnionOf">owl:disjointUnionOf</a>
    /// </summary>
    let disjointUnionOf = owlVocabulary.termByName["disjointUnionOf"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given classes are disjoint.^^xsd:string</para>
    ///   <para>rdfs:label : disjointWith^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#disjointWith">owl:disjointWith</a>
    /// </summary>
    let disjointWith = owlVocabulary.termByName["disjointWith"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of pairwise different individuals in a owl:AllDifferent axiom.^^xsd:string</para>
    ///   <para>rdfs:label : distinctMembers^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#distinctMembers">owl:distinctMembers</a>
    /// </summary>
    let distinctMembers = owlVocabulary.termByName["distinctMembers"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given classes are equivalent, and that is used to specify datatype definitions.^^xsd:string</para>
    ///   <para>rdfs:label : equivalentClass^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#equivalentClass">owl:equivalentClass</a>
    /// </summary>
    let equivalentClass = owlVocabulary.termByName["equivalentClass"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given properties are equivalent.^^xsd:string</para>
    ///   <para>rdfs:label : equivalentProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#equivalentProperty">owl:equivalentProperty</a>
    /// </summary>
    let equivalentProperty =
        owlVocabulary.termByName["equivalentProperty"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of properties that jointly build a key.^^xsd:string</para>
    ///   <para>rdfs:label : hasKey^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#hasKey">owl:hasKey</a>
    /// </summary>
    let hasKey = owlVocabulary.termByName["hasKey"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the property that a self restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : hasSelf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#hasSelf">owl:hasSelf</a>
    /// </summary>
    let hasSelf = owlVocabulary.termByName["hasSelf"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the individual that a has-value restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : hasValue^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#hasValue">owl:hasValue</a>
    /// </summary>
    let hasValue = owlVocabulary.termByName["hasValue"] |> PrefixedIri
    let imports = owlVocabulary.termByName["imports"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The annotation property that indicates that a given ontology is incompatible with another ontology.^^xsd:string</para>
    ///   <para>rdfs:label : incompatibleWith^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#incompatibleWith">owl:incompatibleWith</a>
    /// </summary>
    let incompatibleWith = owlVocabulary.termByName["incompatibleWith"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of classes or data ranges that build an intersection.^^xsd:string</para>
    ///   <para>rdfs:label : intersectionOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#intersectionOf">owl:intersectionOf</a>
    /// </summary>
    let intersectionOf = owlVocabulary.termByName["intersectionOf"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given properties are inverse.^^xsd:string</para>
    ///   <para>rdfs:label : inverseOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#inverseOf">owl:inverseOf</a>
    /// </summary>
    let inverseOf = owlVocabulary.termByName["inverseOf"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the cardinality of a maximum cardinality restriction.^^xsd:string</para>
    ///   <para>rdfs:label : maxCardinality^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#maxCardinality">owl:maxCardinality</a>
    /// </summary>
    let maxCardinality = owlVocabulary.termByName["maxCardinality"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the cardinality of a maximum qualified cardinality restriction.^^xsd:string</para>
    ///   <para>rdfs:label : maxQualifiedCardinality^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#maxQualifiedCardinality">owl:maxQualifiedCardinality</a>
    /// </summary>
    let maxQualifiedCardinality =
        owlVocabulary.termByName["maxQualifiedCardinality"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of members in either a owl:AllDifferent, owl:AllDisjointClasses or owl:AllDisjointProperties axiom.^^xsd:string</para>
    ///   <para>rdfs:label : members^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#members">owl:members</a>
    /// </summary>
    let members = owlVocabulary.termByName["members"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the cardinality of a minimum cardinality restriction.^^xsd:string</para>
    ///   <para>rdfs:label : minCardinality^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#minCardinality">owl:minCardinality</a>
    /// </summary>
    let minCardinality = owlVocabulary.termByName["minCardinality"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the cardinality of a minimum qualified cardinality restriction.^^xsd:string</para>
    ///   <para>rdfs:label : minQualifiedCardinality^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#minQualifiedCardinality">owl:minQualifiedCardinality</a>
    /// </summary>
    let minQualifiedCardinality =
        owlVocabulary.termByName["minQualifiedCardinality"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the class that a qualified object cardinality restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : onClass^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#onClass">owl:onClass</a>
    /// </summary>
    let onClass = owlVocabulary.termByName["onClass"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the data range that a qualified data cardinality restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : onDataRange^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#onDataRange">owl:onDataRange</a>
    /// </summary>
    let onDataRange = owlVocabulary.termByName["onDataRange"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the datatype that a datatype restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : onDatatype^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#onDatatype">owl:onDatatype</a>
    /// </summary>
    let onDatatype = owlVocabulary.termByName["onDatatype"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the n-tuple of properties that a property restriction on an n-ary data range refers to.^^xsd:string</para>
    ///   <para>rdfs:label : onProperties^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#onProperties">owl:onProperties</a>
    /// </summary>
    let onProperties = owlVocabulary.termByName["onProperties"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the property that a property restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : onProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#onProperty">owl:onProperty</a>
    /// </summary>
    let onProperty = owlVocabulary.termByName["onProperty"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of individuals or data values that build an enumeration.^^xsd:string</para>
    ///   <para>rdfs:label : oneOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#oneOf">owl:oneOf</a>
    /// </summary>
    let oneOf = owlVocabulary.termByName["oneOf"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The annotation property that indicates the predecessor ontology of a given ontology.^^xsd:string</para>
    ///   <para>rdfs:label : priorVersion^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#priorVersion">owl:priorVersion</a>
    /// </summary>
    let priorVersion = owlVocabulary.termByName["priorVersion"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the n-tuple of properties that build a sub property chain of a given property.^^xsd:string</para>
    ///   <para>rdfs:label : propertyChainAxiom^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#propertyChainAxiom">owl:propertyChainAxiom</a>
    /// </summary>
    let propertyChainAxiom =
        owlVocabulary.termByName["propertyChainAxiom"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given properties are disjoint.^^xsd:string</para>
    ///   <para>rdfs:label : propertyDisjointWith^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#propertyDisjointWith">owl:propertyDisjointWith</a>
    /// </summary>
    let propertyDisjointWith =
        owlVocabulary.termByName["propertyDisjointWith"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the cardinality of an exact qualified cardinality restriction.^^xsd:string</para>
    ///   <para>rdfs:label : qualifiedCardinality^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#qualifiedCardinality">owl:qualifiedCardinality</a>
    /// </summary>
    let qualifiedCardinality =
        owlVocabulary.termByName["qualifiedCardinality"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given individuals are equal.^^xsd:string</para>
    ///   <para>rdfs:label : sameAs^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#sameAs">owl:sameAs</a>
    /// </summary>
    let sameAs = owlVocabulary.termByName["sameAs"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the class that an existential property restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : someValuesFrom^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#someValuesFrom">owl:someValuesFrom</a>
    /// </summary>
    let someValuesFrom = owlVocabulary.termByName["someValuesFrom"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the subject of a negative property assertion.^^xsd:string</para>
    ///   <para>rdfs:label : sourceIndividual^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#sourceIndividual">owl:sourceIndividual</a>
    /// </summary>
    let sourceIndividual = owlVocabulary.termByName["sourceIndividual"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the object of a negative object property assertion.^^xsd:string</para>
    ///   <para>rdfs:label : targetIndividual^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#targetIndividual">owl:targetIndividual</a>
    /// </summary>
    let targetIndividual = owlVocabulary.termByName["targetIndividual"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the value of a negative data property assertion.^^xsd:string</para>
    ///   <para>rdfs:label : targetValue^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#targetValue">owl:targetValue</a>
    /// </summary>
    let targetValue = owlVocabulary.termByName["targetValue"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The data property that relates every individual to every data value.^^xsd:string</para>
    ///   <para>rdfs:label : topDataProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#topDataProperty">owl:topDataProperty</a>
    /// </summary>
    let topDataProperty = owlVocabulary.termByName["topDataProperty"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The object property that relates every two individuals.^^xsd:string</para>
    ///   <para>rdfs:label : topObjectProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#topObjectProperty">owl:topObjectProperty</a>
    /// </summary>
    let topObjectProperty = owlVocabulary.termByName["topObjectProperty"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of classes or data ranges that build a union.^^xsd:string</para>
    ///   <para>rdfs:label : unionOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#unionOf">owl:unionOf</a>
    /// </summary>
    let unionOf = owlVocabulary.termByName["unionOf"] |> PrefixedIri
    let versionIRI = owlVocabulary.termByName["versionIRI"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The annotation property that provides version information for an ontology or another OWL construct.^^xsd:string</para>
    ///   <para>rdfs:label : versionInfo^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#versionInfo">owl:versionInfo</a>
    /// </summary>
    let versionInfo = owlVocabulary.termByName["versionInfo"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of facet-value pairs that define a datatype restriction.^^xsd:string</para>
    ///   <para>rdfs:label : withRestrictions^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#withRestrictions">owl:withRestrictions</a>
    /// </summary>
    let withRestrictions = owlVocabulary.termByName["withRestrictions"] |> PrefixedIri


module foaf =
    let _namespaceIri = foafVocabulary.termByName[""] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : An agent (eg. person, group, software or physical artifact).^^xsd:string</para>
    ///   <para>rdfs:label : Agent^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Agent">foaf:Agent</a>
    /// </summary>
    let Agent = foafVocabulary.termByName["Agent"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A document.^^xsd:string</para>
    ///   <para>rdfs:label : Document^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Document">foaf:Document</a>
    /// </summary>
    let Document = foafVocabulary.termByName["Document"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A class of Agents.^^xsd:string</para>
    ///   <para>rdfs:label : Group^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Group">foaf:Group</a>
    /// </summary>
    let Group = foafVocabulary.termByName["Group"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : An image.^^xsd:string</para>
    ///   <para>rdfs:label : Image^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Image">foaf:Image</a>
    /// </summary>
    let Image = foafVocabulary.termByName["Image"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A foaf:LabelProperty is any RDF property with texual values that serve as labels.^^xsd:string</para>
    ///   <para>rdfs:label : Label Property^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/LabelProperty">foaf:LabelProperty</a>
    /// </summary>
    let LabelProperty = foafVocabulary.termByName["LabelProperty"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : An online account.^^xsd:string</para>
    ///   <para>rdfs:label : Online Account^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/OnlineAccount">foaf:OnlineAccount</a>
    /// </summary>
    let OnlineAccount = foafVocabulary.termByName["OnlineAccount"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : An online chat account.^^xsd:string</para>
    ///   <para>rdfs:label : Online Chat Account^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/OnlineChatAccount">foaf:OnlineChatAccount</a>
    /// </summary>
    let OnlineChatAccount =
        foafVocabulary.termByName["OnlineChatAccount"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : An online e-commerce account.^^xsd:string</para>
    ///   <para>rdfs:label : Online E-commerce Account^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/OnlineEcommerceAccount">foaf:OnlineEcommerceAccount</a>
    /// </summary>
    let OnlineEcommerceAccount =
        foafVocabulary.termByName["OnlineEcommerceAccount"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : An online gaming account.^^xsd:string</para>
    ///   <para>rdfs:label : Online Gaming Account^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/OnlineGamingAccount">foaf:OnlineGamingAccount</a>
    /// </summary>
    let OnlineGamingAccount =
        foafVocabulary.termByName["OnlineGamingAccount"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : An organization.^^xsd:string</para>
    ///   <para>rdfs:label : Organization^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Organization">foaf:Organization</a>
    /// </summary>
    let Organization = foafVocabulary.termByName["Organization"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A person.^^xsd:string</para>
    ///   <para>rdfs:label : Person^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Person">foaf:Person</a>
    /// </summary>
    let Person = foafVocabulary.termByName["Person"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : A personal profile RDF document.^^xsd:string</para>
    ///   <para>rdfs:label : PersonalProfileDocument^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/PersonalProfileDocument">foaf:PersonalProfileDocument</a>
    /// </summary>
    let PersonalProfileDocument =
        foafVocabulary.termByName["PersonalProfileDocument"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : A project (a collective endeavour of some kind).^^xsd:string</para>
    ///   <para>rdfs:label : Project^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Project">foaf:Project</a>
    /// </summary>
    let Project = foafVocabulary.termByName["Project"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : Indicates an account held by this agent.^^xsd:string</para>
    ///   <para>rdfs:label : account^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/account">foaf:account</a>
    /// </summary>
    let account = foafVocabulary.termByName["account"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name (identifier) associated with this online account.^^xsd:string</para>
    ///   <para>rdfs:label : account name^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/accountName">foaf:accountName</a>
    /// </summary>
    let accountName = foafVocabulary.termByName["accountName"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : Indicates a homepage of the service provide for this online account.^^xsd:string</para>
    ///   <para>rdfs:label : account service homepage^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/accountServiceHomepage">foaf:accountServiceHomepage</a>
    /// </summary>
    let accountServiceHomepage =
        foafVocabulary.termByName["accountServiceHomepage"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : The age in years of some agent.^^xsd:string</para>
    ///   <para>rdfs:label : age^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/age">foaf:age</a>
    /// </summary>
    let age = foafVocabulary.termByName["age"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : An AIM chat ID^^xsd:string</para>
    ///   <para>rdfs:label : AIM chat ID^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/aimChatID">foaf:aimChatID</a>
    /// </summary>
    let aimChatID = foafVocabulary.termByName["aimChatID"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A location that something is based near, for some broadly human notion of near.^^xsd:string</para>
    ///   <para>rdfs:label : based near^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/based_near">foaf:based_near</a>
    /// </summary>
    let based_near = foafVocabulary.termByName["based_near"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The birthday of this Agent, represented in mm-dd string form, eg. '12-31'.^^xsd:string</para>
    ///   <para>rdfs:label : birthday^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/birthday">foaf:birthday</a>
    /// </summary>
    let birthday = foafVocabulary.termByName["birthday"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A current project this person works on.^^xsd:string</para>
    ///   <para>rdfs:label : current project^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/currentProject">foaf:currentProject</a>
    /// </summary>
    let currentProject = foafVocabulary.termByName["currentProject"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A depiction of some thing.^^xsd:string</para>
    ///   <para>rdfs:label : depiction^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/depiction">foaf:depiction</a>
    /// </summary>
    let depiction = foafVocabulary.termByName["depiction"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A thing depicted in this representation.^^xsd:string</para>
    ///   <para>rdfs:label : depicts^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/depicts">foaf:depicts</a>
    /// </summary>
    let depicts = foafVocabulary.termByName["depicts"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A checksum for the DNA of some thing. Joke.^^xsd:string</para>
    ///   <para>rdfs:label : DNA checksum^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/dnaChecksum">foaf:dnaChecksum</a>
    /// </summary>
    let dnaChecksum = foafVocabulary.termByName["dnaChecksum"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The family name of some person.^^xsd:string</para>
    ///   <para>rdfs:label : familyName^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/familyName">foaf:familyName</a>
    /// </summary>
    let familyName = foafVocabulary.termByName["familyName"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The family name of some person.^^xsd:string</para>
    ///   <para>rdfs:label : family_name^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/family_name">foaf:family_name</a>
    /// </summary>
    let family_name = foafVocabulary.termByName["family_name"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The first name of a person.^^xsd:string</para>
    ///   <para>rdfs:label : firstName^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/firstName">foaf:firstName</a>
    /// </summary>
    let firstName = foafVocabulary.termByName["firstName"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The underlying or 'focal' entity associated with some SKOS-described concept.^^xsd:string</para>
    ///   <para>rdfs:label : focus^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/focus">foaf:focus</a>
    /// </summary>
    let focus = foafVocabulary.termByName["focus"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : An organization funding a project or person.^^xsd:string</para>
    ///   <para>rdfs:label : funded by^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/fundedBy">foaf:fundedBy</a>
    /// </summary>
    let fundedBy = foafVocabulary.termByName["fundedBy"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A textual geekcode for this person, see http://www.geekcode.com/geek.html^^xsd:string</para>
    ///   <para>rdfs:label : geekcode^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/geekcode">foaf:geekcode</a>
    /// </summary>
    let geekcode = foafVocabulary.termByName["geekcode"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The gender of this Agent (typically but not necessarily 'male' or 'female').^^xsd:string</para>
    ///   <para>rdfs:label : gender^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/gender">foaf:gender</a>
    /// </summary>
    let gender = foafVocabulary.termByName["gender"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The given name of some person.^^xsd:string</para>
    ///   <para>rdfs:label : Given name^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/givenName">foaf:givenName</a>
    /// </summary>
    let givenName = foafVocabulary.termByName["givenName"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The given name of some person.^^xsd:string</para>
    ///   <para>rdfs:label : Given name^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/givenname">foaf:givenname</a>
    /// </summary>
    let givenname = foafVocabulary.termByName["givenname"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : Indicates an account held by this agent.^^xsd:string</para>
    ///   <para>rdfs:label : account^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/holdsAccount">foaf:holdsAccount</a>
    /// </summary>
    let holdsAccount = foafVocabulary.termByName["holdsAccount"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A homepage for some thing.^^xsd:string</para>
    ///   <para>rdfs:label : homepage^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/homepage">foaf:homepage</a>
    /// </summary>
    let homepage = foafVocabulary.termByName["homepage"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : An ICQ chat ID^^xsd:string</para>
    ///   <para>rdfs:label : ICQ chat ID^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/icqChatID">foaf:icqChatID</a>
    /// </summary>
    let icqChatID = foafVocabulary.termByName["icqChatID"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : An image that can be used to represent some thing (ie. those depictions which are particularly representative of something, eg. one's photo on a homepage).^^xsd:string</para>
    ///   <para>rdfs:label : image^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/img">foaf:img</a>
    /// </summary>
    let img = foafVocabulary.termByName["img"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A page about a topic of interest to this person.^^xsd:string</para>
    ///   <para>rdfs:label : interest^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/interest">foaf:interest</a>
    /// </summary>
    let interest = foafVocabulary.termByName["interest"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A document that this thing is the primary topic of.^^xsd:string</para>
    ///   <para>rdfs:label : is primary topic of^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/isPrimaryTopicOf">foaf:isPrimaryTopicOf</a>
    /// </summary>
    let isPrimaryTopicOf = foafVocabulary.termByName["isPrimaryTopicOf"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A jabber ID for something.^^xsd:string</para>
    ///   <para>rdfs:label : jabber ID^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/jabberID">foaf:jabberID</a>
    /// </summary>
    let jabberID = foafVocabulary.termByName["jabberID"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A person known by this person (indicating some level of reciprocated interaction between the parties).^^xsd:string</para>
    ///   <para>rdfs:label : knows^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/knows">foaf:knows</a>
    /// </summary>
    let knows = foafVocabulary.termByName["knows"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The last name of a person.^^xsd:string</para>
    ///   <para>rdfs:label : lastName^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/lastName">foaf:lastName</a>
    /// </summary>
    let lastName = foafVocabulary.termByName["lastName"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A logo representing some thing.^^xsd:string</para>
    ///   <para>rdfs:label : logo^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/logo">foaf:logo</a>
    /// </summary>
    let logo = foafVocabulary.termByName["logo"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : Something that was made by this agent.^^xsd:string</para>
    ///   <para>rdfs:label : made^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/made">foaf:made</a>
    /// </summary>
    let made = foafVocabulary.termByName["made"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : An agent that  made this thing.^^xsd:string</para>
    ///   <para>rdfs:label : maker^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/maker">foaf:maker</a>
    /// </summary>
    let maker = foafVocabulary.termByName["maker"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A  personal mailbox, ie. an Internet mailbox associated with exactly one owner, the first owner of this mailbox. This is a 'static inverse functional property', in that  there is (across time and change) at most one individual that ever has any particular value for foaf:mbox.^^xsd:string</para>
    ///   <para>rdfs:label : personal mailbox^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/mbox">foaf:mbox</a>
    /// </summary>
    let mbox = foafVocabulary.termByName["mbox"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The sha1sum of the URI of an Internet mailbox associated with exactly one owner, the  first owner of the mailbox.^^xsd:string</para>
    ///   <para>rdfs:label : sha1sum of a personal mailbox URI name^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/mbox_sha1sum">foaf:mbox_sha1sum</a>
    /// </summary>
    let mbox_sha1sum = foafVocabulary.termByName["mbox_sha1sum"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : Indicates a member of a Group^^xsd:string</para>
    ///   <para>rdfs:label : member^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/member">foaf:member</a>
    /// </summary>
    let member_ = foafVocabulary.termByName["member"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : Indicates the class of individuals that are a member of a Group^^xsd:string</para>
    ///   <para>rdfs:label : membershipClass^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/membershipClass">foaf:membershipClass</a>
    /// </summary>
    let membershipClass = foafVocabulary.termByName["membershipClass"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : An MSN chat ID^^xsd:string</para>
    ///   <para>rdfs:label : MSN chat ID^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/msnChatID">foaf:msnChatID</a>
    /// </summary>
    let msnChatID = foafVocabulary.termByName["msnChatID"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A Myers Briggs (MBTI) personality classification.^^xsd:string</para>
    ///   <para>rdfs:label : myersBriggs^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/myersBriggs">foaf:myersBriggs</a>
    /// </summary>
    let myersBriggs = foafVocabulary.termByName["myersBriggs"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A name for some thing.^^xsd:string</para>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/name">foaf:name</a>
    /// </summary>
    let name = foafVocabulary.termByName["name"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A short informal nickname characterising an agent (includes login identifiers, IRC and other chat nicknames).^^xsd:string</para>
    ///   <para>rdfs:label : nickname^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/nick">foaf:nick</a>
    /// </summary>
    let nick = foafVocabulary.termByName["nick"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : An OpenID for an Agent.^^xsd:string</para>
    ///   <para>rdfs:label : openid^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/openid">foaf:openid</a>
    /// </summary>
    let openid = foafVocabulary.termByName["openid"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A page or document about this thing.^^xsd:string</para>
    ///   <para>rdfs:label : page^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/page">foaf:page</a>
    /// </summary>
    let page = foafVocabulary.termByName["page"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A project this person has previously worked on.^^xsd:string</para>
    ///   <para>rdfs:label : past project^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/pastProject">foaf:pastProject</a>
    /// </summary>
    let pastProject = foafVocabulary.termByName["pastProject"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A phone,  specified using fully qualified tel: URI scheme (refs: http://www.w3.org/Addressing/schemes.html#tel).^^xsd:string</para>
    ///   <para>rdfs:label : phone^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/phone">foaf:phone</a>
    /// </summary>
    let phone = foafVocabulary.termByName["phone"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A .plan comment, in the tradition of finger and '.plan' files.^^xsd:string</para>
    ///   <para>rdfs:label : plan^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/plan">foaf:plan</a>
    /// </summary>
    let plan = foafVocabulary.termByName["plan"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The primary topic of some page or document.^^xsd:string</para>
    ///   <para>rdfs:label : primary topic^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/primaryTopic">foaf:primaryTopic</a>
    /// </summary>
    let primaryTopic = foafVocabulary.termByName["primaryTopic"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A link to the publications of this person.^^xsd:string</para>
    ///   <para>rdfs:label : publications^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/publications">foaf:publications</a>
    /// </summary>
    let publications = foafVocabulary.termByName["publications"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A homepage of a school attended by the person.^^xsd:string</para>
    ///   <para>rdfs:label : schoolHomepage^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/schoolHomepage">foaf:schoolHomepage</a>
    /// </summary>
    let schoolHomepage = foafVocabulary.termByName["schoolHomepage"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A sha1sum hash, in hex.^^xsd:string</para>
    ///   <para>rdfs:label : sha1sum (hex)^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/sha1">foaf:sha1</a>
    /// </summary>
    let sha1 = foafVocabulary.termByName["sha1"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A Skype ID^^xsd:string</para>
    ///   <para>rdfs:label : Skype ID^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/skypeID">foaf:skypeID</a>
    /// </summary>
    let skypeID = foafVocabulary.termByName["skypeID"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A string expressing what the user is happy for the general public (normally) to know about their current activity.^^xsd:string</para>
    ///   <para>rdfs:label : status^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/status">foaf:status</a>
    /// </summary>
    let status = foafVocabulary.termByName["status"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : The surname of some person.^^xsd:string</para>
    ///   <para>rdfs:label : Surname^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/surname">foaf:surname</a>
    /// </summary>
    let surname = foafVocabulary.termByName["surname"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A theme.^^xsd:string</para>
    ///   <para>rdfs:label : theme^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/theme">foaf:theme</a>
    /// </summary>
    let theme = foafVocabulary.termByName["theme"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A derived thumbnail image.^^xsd:string</para>
    ///   <para>rdfs:label : thumbnail^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/thumbnail">foaf:thumbnail</a>
    /// </summary>
    let thumbnail = foafVocabulary.termByName["thumbnail"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A tipjar document for this agent, describing means for payment and reward.^^xsd:string</para>
    ///   <para>rdfs:label : tipjar^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/tipjar">foaf:tipjar</a>
    /// </summary>
    let tipjar = foafVocabulary.termByName["tipjar"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : Title (Mr, Mrs, Ms, Dr. etc)^^xsd:string</para>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/title">foaf:title</a>
    /// </summary>
    let title = foafVocabulary.termByName["title"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A topic of some page or document.^^xsd:string</para>
    ///   <para>rdfs:label : topic^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/topic">foaf:topic</a>
    /// </summary>
    let topic = foafVocabulary.termByName["topic"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A thing of interest to this person.^^xsd:string</para>
    ///   <para>rdfs:label : topic_interest^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/topic_interest">foaf:topic_interest</a>
    /// </summary>
    let topic_interest = foafVocabulary.termByName["topic_interest"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A weblog of some thing (whether person, group, company etc.).^^xsd:string</para>
    ///   <para>rdfs:label : weblog^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/weblog">foaf:weblog</a>
    /// </summary>
    let weblog = foafVocabulary.termByName["weblog"] |> PrefixedIri
    /// <summary>
    ///   <para>rdfs:comment : A work info homepage of some person; a page about their work for some organization.^^xsd:string</para>
    ///   <para>rdfs:label : work info homepage^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/workInfoHomepage">foaf:workInfoHomepage</a>
    /// </summary>
    let workInfoHomepage = foafVocabulary.termByName["workInfoHomepage"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : A workplace homepage of some person; the homepage of an organization they work for.^^xsd:string</para>
    ///   <para>rdfs:label : workplace homepage^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/workplaceHomepage">foaf:workplaceHomepage</a>
    /// </summary>
    let workplaceHomepage =
        foafVocabulary.termByName["workplaceHomepage"] |> PrefixedIri

    /// <summary>
    ///   <para>rdfs:comment : A Yahoo chat ID^^xsd:string</para>
    ///   <para>rdfs:label : Yahoo chat ID^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/yahooChatID">foaf:yahooChatID</a>
    /// </summary>
    let yahooChatID = foafVocabulary.termByName["yahooChatID"] |> PrefixedIri




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
randomRdfDocument.rdfTerms[0]
randomRdfDocument.asOntologyGraph
randomRdfDocument.asOntologyGraph.RdfClasses
randomRdfDocument.asOntologyGraph.OwlClasses
let randomRdfClass = randomRdfDocument.asOntologyGraph.RdfClasses  |> Seq.toArray |> Array.randomChoice
randomRdfClass





let randomRdfTerm = randomRdfDocument.rdfTerms |> Array.randomChoice
let randomIri = randomRdfDocument.rdfTerms
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



    

let a = rdf.type_

module dbug = 
    let _prefixId = PrefixId.fromNamespaceLabel "https://eristocrates.dev/ontology/dbug/"  "dbug"
    let _prefix (localName:string) = PrefixedIri { prefixId = _prefixId ; localName = localName } 
    let Bob = _prefix "Bob"
    let Alice = _prefix "Alice"
    let this = _prefix "this"
    let test = _prefix "test"


!> dbug.Bob --- a --> foaf.Person
