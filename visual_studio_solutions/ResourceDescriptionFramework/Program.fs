// For more information see https://aka.ms/fsharp-console-apps
// printfn "Hello from F#"


open AngleSharp
open FParsec
open FSharp.Core
open Iride
open Microsoft.Identity.Client
open Microsoft.Playwright
open MigraDoc
open Newtonsoft.Json
open PdfSharp
open System
open System.Collections.Generic
open System.Globalization
open System.IO
open System.Net
open System.Net.Http
open System.Reflection
open System.Text
open System.Text.RegularExpressions
open System.Threading.Tasks
open System.Xml.Linq
open System.Xml.XPath
open UglyToad
open VDS
open VDS.RDF
open VDS.RDF.Nodes
open VDS.RDF.Parsing
open VDS.RDF.Writing
open SharedKernel
open Ergonomics.Shorthand


type MintingNamespace(prefixID: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type) =
    member _.Item
        with get (localNameRaw: string) =
            let localName = localNameRaw.Replace(" ", "_")
            { prefixID with _localName = localName }

    member this.prefix(localNameRaw: string) =
        let localName = localNameRaw.Replace(" ", "_")
        { prefixID with _localName = localName }
    member this.prefixID = prefixID

module mint =
    let prefixID (namespaceUriString: string) (namespacePrefix: string) =
            Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
                namespaceUriString
                None
                (Some namespacePrefix)
                None
    let fullIri (uriString: string) =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant uriString None None None

let getLastSegment (input: string) (delimiter: char) =
    if String.IsNullOrEmpty(input) then
      String.Empty
    else
        let parts = input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries)
        if parts.Length = 0 then input
        else Array.last parts
let capitalizeFirst (input: string) =
  match input with
  | null -> null
  | "" -> ""
  | _ ->
      let firstChar = Char.ToUpper(input.[0])
      let rest = input.Substring(1)
      string firstChar + rest

module Artifact =
    let exeDirectory =
        AppContext.BaseDirectory
        |> fun path -> Path.GetFullPath(path)

    let rootDirectory = $"""C:\Repositories\ipa\visual_studio_solutions\ResourceDescriptionFramework"""
    let surfaceDirectory = $"""C:\Surfaces"""

    /// Saves text to a file, creating directories if needed
    let saveToFile (filePath: string) (content: string) =
        try
            // Ensure the directory exists
            let dir = Path.GetDirectoryName(filePath)

            if
                not (String.IsNullOrWhiteSpace(dir))
                && not (Directory.Exists(dir))
            then
                Directory.CreateDirectory(dir) |> ignore

            // Write text with UTF-8 encoding
            File.WriteAllText(filePath, content, Encoding.UTF8)
            printfn "File saved successfully: %s" filePath
        with
        | :? UnauthorizedAccessException -> printfn "Error: Access denied to '%s'." filePath
        | :? DirectoryNotFoundException -> printfn "Error: Directory not found for '%s'." filePath
        | :? IOException as ex -> printfn "I/O Error: %s" ex.Message
        | ex -> printfn "Unexpected error: %s" ex.Message


    module example =
        let txt = "example.txt"

    module tabgroupsrules =
        let ttl = @"artifacts\adhoc\tabgroups\tab-groups-rules.ttl"

    module test =
        let ttl = "Artifact/test.ttl"
        let fsx = "Artifact/test.fsx"
        let txt = "Artifact/test.txt"

    module urlLinks =
        let txt = "urlLinks.txt"

    module urlFragments =
        let txt = "urlFragments.txt"

    module Module =
        let directory = $"""{rootDirectory}\Module\"""

    module Vocabulary =

        let directory = $"""{rootDirectory}\Vocabulary\"""

        module Manual =
            let directory = $"""{directory}Manual\"""

        module Generated =
            let directory = $"""{directory}Generated\"""

    module Prefix =
        let directory = $"""{rootDirectory}\Prefix\"""

    module CodegenFailures =
        let txt = $"""{rootDirectory}\Artifact\CodegenFailures.txt"""

    module LovFailures =
        let txt = "LovFailures.txt"



module Fsharp =
    module Identifier =
        let keywordSet: string Set =
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
                  "yield" ]

        let futureSet: string Set =
            set [ "break"
                  "checked"
                  "component"
                  "constraint"
                  "continue"
                  "fori"
                  "include"
                  "mixin"
                  "parallel"
                  "params"
                  "process"
                  "protected"
                  "pure"
                  "sealed"
                  "tailcall"
                  "trait"
                  "virtual" ]

        let ocamlSet: string Set =
            set [ "break"
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
                  "land"

                   ]

        let reservedKeywordSet =
            Set.unionMany (
                seq {
                    keywordSet
                    ocamlSet
                    futureSet
                }
            )

        module Character =
            module First =
                let parser: Parser<char, unit> = choice [ pchar '_'; letter ]

            module Rest =
                let parser: Parser<string, unit> = manyChars (choice [ letter; digit; anyOf "\'_" ])

    module Module =
        module Name =
            type ParameterRecord =
                { fallbackName: string
                  keywordSet: Set<string>
                  rawInput: string }

            let defaultParameters: ParameterRecord =
                { fallbackName = "ns"
                  keywordSet = Identifier.reservedKeywordSet
                  rawInput = "" }


            let parser (keywordSet: string Set) : Parser<string, unit> =
                pipe2 (Identifier.Character.First.parser) (Identifier.Character.Rest.parser) (fun first rest ->
                    string first + rest)
                |>> fun rawName ->
                        match rawName with
                        | _ when keywordSet.Contains(rawName) -> $"``{rawName}``"
                        | _ -> rawName


            let inhabitant (parameter: ParameterRecord) : string =
                let backtickableName =
                    parameter
                        .rawInput
                        .Replace('.', '_')
                        .Replace('+', '_')
                        .Replace('$', '_')
                        .Replace('&', '_')
                        .Replace('[', '_')
                        .Replace(']', '_')
                        .Replace('/', '_')
                        .Replace('\\', '_')
                        .Replace('*', '_')
                        .Replace('\"', '_')
                        .Replace('`', '_')

                match run (parser parameter.keywordSet .>> eof) backtickableName with
                | ParserResult.Success (moduleName, _, _) -> moduleName
                | ParserResult.Failure (msg, _, _) -> failwith msg

// TODO figure out how to automate scraping this                
// https://odpa.github.io/patterns-repository/
let namespaceIris =
    [
            
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://termlex.oeg.fi.upm.es/termlex#" (Some @"https://termlex.oeg.fi.upm.es/static/termlex.rdf") (Some "ontolex.termlex") None

        
    
        

        

        
        



    ]


// ============================================================
// ONE FAILURE TYPE, ONE OUTCOME TYPE (Result)
// ============================================================

type Failure =
    { namespaceUriString: string
      stage: string
      exceptionText: string
      httpStatus: int option
      httpMediaType: string option
      dereferencedUrl: string option
      contentSnippet: string option
      attempts: string list option }

type Outcome<'a> = Result<'a, Failure>

// ============================================================
// PrefixID (unchanged)
// ============================================================

module PrefixID =
    type Type =
        { PNAME_NS: string
          IRIREF: string
          IRIDOC: string }

    let inhabitant (PNAME_NS: string) (IRIREF: string) (IRIDOC: string) =
        { PNAME_NS = PNAME_NS
          IRIREF = IRIREF
          IRIDOC = IRIDOC }

// ============================================================
// HTTP probe (unchanged API, but used by Failure when needed)
// ============================================================

let client =
    Communication.Internet.ProtocolSuite.Layer.Application.Protocol.Transfer.Text.Hyper.Client.inhabitant

let resultWithTimeout (timeout: TimeSpan) (label: string) (job: Task<'T>) : 'T =
    // If it completes, return it; if not, raise with a useful message.
    let completed = Task.WhenAny(job, Task.Delay(timeout)).GetAwaiter().GetResult()
    if Object.ReferenceEquals(completed, (job :> Task)) then
        job.GetAwaiter().GetResult()
    else
        raise (TimeoutException($"TIMEOUT after {timeout.TotalSeconds}s in {label}"))

let result (job: Task<'T>) : 'T =
    // Pick a default you can tolerate interactively.
    resultWithTimeout (TimeSpan.FromSeconds 30.0) "result" job
    
type Probe =
    { requestedUrl: string
      dereferencedUrl: string
      statusCode: int
      characterSet: string option
      mediaType: string option
      content: string }

let probe (urlString: string) =
    task {
        use! response =
            Communication.Internet.ProtocolSuite.Layer.Application.Protocol.Transfer.Text.Hyper.Message.Request.Method.GET
                urlString
                client

        let ct = response.Content.Headers.ContentType

        let mediaType =
            if isNull ct then
                None
            else
                Some ct.MediaType

        let characterSet =
            if isNull ct then
                None
            else
                Some ct.CharSet

        let! content = response.Content.ReadAsStringAsync()

        return
            { requestedUrl = urlString
              dereferencedUrl = response.RequestMessage.RequestUri.OriginalString
              statusCode = int response.StatusCode
              characterSet = characterSet
              mediaType = mediaType
              content = content }
    }

let probeWithHeaders (urlString: string) =
    task {
        use! response =
            Communication.Internet.ProtocolSuite.Layer.Application.Protocol.Transfer.Text.Hyper.Message.Request.Method.GET_withHeaders
                urlString
                client

        let ct = response.Content.Headers.ContentType

        let mediaType =
            if isNull ct then
                None
            else
                Some ct.MediaType

        let characterSet =
            if isNull ct then
                None
            else
                Some ct.CharSet

        let! content = response.Content.ReadAsStringAsync()

        return
            { requestedUrl = urlString
              dereferencedUrl = response.RequestMessage.RequestUri.OriginalString
              statusCode = int response.StatusCode
              characterSet = characterSet
              mediaType = mediaType
              content = content }
    }
// ============================================================
// prefix.cc (unchanged)
// ============================================================

module prefixcc =
    let _prefixID = PrefixID.inhabitant "prefixcc" $"http://prefix.cc/" ""

    [<RequireQualifiedAccess>]
    type Format =
        | ttl
        | n3
        | rdf
        | xml
        | rdfa
        | html
        | xmlns
        | sparql
        | txt
        | csv
        | json
        | js
        | jsonld
        | ini
        | vann
        | go
        | none

        member this.parameter =
            match this with
            | Format.none -> ""
            | _ -> $"{this.ToString()}"

    let namespaceLookupProbe (prefixes: string list) (format: Format) : Task<Probe> =
        task {
            let url =
                _prefixID.IRIREF
                + (String.concat "," prefixes)
                + $".file.{format.parameter}"

            return! probe url
        }

    let reverseLookupProbe (uriString: string) (format: Format) : Task<Probe> =
        task {
            let url = $"http://prefix.cc/reverse?uri={uriString}&format={format.parameter}"
            return! probe url
        }

    let contextProbe =
        task {
            let url = $"{_prefixID.IRIREF}context.jsonld"
            return! probe url
        }

let prefixccProbe =
    prefixcc.reverseLookupProbe "https://w3id.org/pko" prefixcc.Format.ttl
    |> result

// ============================================================
// LOV (mostly unchanged; endpoint used later)
// ============================================================

module lov =
    let _prefixID =
        PrefixID.inhabitant "lov" $"https://lov.linkeddata.es/dataset/lov/vocabs/" ""

    module Vocabulary =
        module List =
            let endpoint =
                task { return! probe "https://lov.linkeddata.es/dataset/lov/api/v2/vocabulary/list" }

        module Search =
            module Parameter =
                type Type =
                    { key: string
                      value: string }
                    member this.parameter = $"{this.key}={this.value}"

                let inhabitant (key: string) (value: string) : Type = { key = key; value = value }
                let q (preferredPrefixName: string) : Type = inhabitant "q" preferredPrefixName

                let page_size (maxResultsPerPage: int) : Type =
                    inhabitant "page_size" (maxResultsPerPage.ToString())

                let page (initialPageIndex: int) : Type =
                    inhabitant "page" (initialPageIndex.ToString())

                let tag (commaSeparatedTags: string) : Type = inhabitant "tag" commaSeparatedTags

                let tag_limit (displayTagCardinality: int) : Type =
                    inhabitant "tag_limit" (displayTagCardinality.ToString())

                let lang (commaSeparatedLanguages: string) : Type =
                    inhabitant "lang" commaSeparatedLanguages

                let lang_limit (maxLanguageCardinality: int) : Type =
                    inhabitant "lang_limit" (maxLanguageCardinality.ToString())

            let endpoint (parameters: Parameter.Type list) : Task<Probe> =
                let queryString =
                    parameters
                    |> List.map (fun p -> p.parameter)
                    |> String.concat "&"

                task {
                    let url =
                        $"https://lov.linkeddata.es/dataset/lov/api/v2/vocabulary/search?{queryString}"

                    return! probe url
                }

        module Autocomplete =
            module Parameter =
                type Type =
                    { key: string
                      value: string }
                    member this.parameter = $"{this.key}={this.value}"

                let inhabitant (key: string) (value: string) : Type = { key = key; value = value }
                let q (preferredPrefixName: string) : Type = inhabitant "q" preferredPrefixName

                let page_size (maxResultsPerPage: int) : Type =
                    inhabitant "page_size" (maxResultsPerPage.ToString())

            let endpoint (parameters: Parameter.Type list) : Task<Probe> =
                let queryString =
                    parameters
                    |> List.map (fun p -> p.parameter)
                    |> String.concat "&"

                task {
                    let url =
                        $"https://lov.linkeddata.es/dataset/lov/api/v2/vocabulary/autocomplete?{queryString}"

                    return! probe url
                }

        module Info =
            module Parameter =
                type Type =
                    { key: string
                      value: string }
                    member this.parameter = $"{this.key}={this.value}"

                let private inhabitant (key: string) (value: string) : Type = { key = key; value = value }
                let vocabPrefix (vocabPrefix: string) : Type = inhabitant "vocab" vocabPrefix
                let vocabUri (vocabUri: Uri) : Type = inhabitant "vocab" vocabUri.OriginalString
                let vocabNamespace (vocabNamespace: string) : Type = inhabitant "vocab" vocabNamespace

            let endpoint (vocab: Parameter.Type) : Task<Probe> =
                task {
                    let url =
                        $"https://lov.linkeddata.es/dataset/lov/api/v2/vocabulary/info?{vocab.parameter}"

                    return! probe url
                }

    let datasetUriString = "https://lov.linkeddata.es/dataset/lov"

    module Sparql =
        module Query =
            let key = "query"

            let value (namespaceUriString: string) =
                let vocabularyUriString =
                    match namespaceUriString with
                    // hash namespace exceptions
                    | "http://www.w3.org/1999/02/22-rdf-syntax-ns#"
                    | "http://www.w3.org/2000/01/rdf-schema#"
                    | "http://purl.org/net/p-plan#"
                    | "http://www.w3.org/ns/prov#" -> namespaceUriString
                    | _ when namespaceUriString.EndsWith('#') ->
                        namespaceUriString.Substring(0, namespaceUriString.Length - 1)
                    | _ -> namespaceUriString

                printfn "querying lov for %s" vocabularyUriString

                $"""
PREFIX vann:<http://purl.org/vocab/vann/>
PREFIX voaf:<http://purl.org/vocommons/voaf#>
PREFIX dcat: <http://www.w3.org/ns/dcat#>
PREFIX owl: <http://www.w3.org/2002/07/owl#>
PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>
PREFIX dcterms: <http://purl.org/dc/terms/>
PREFIX ocid: <https://orcid.org/>
PREFIX iso639-2:  <http://id.loc.gov/vocabulary/iso639-2/>
PREFIX xsd: <http://www.w3.org/2001/XMLSchema#>
PREFIX bibo:  <http://purl.org/ontology/bibo/>
PREFIX rev:  <http://purl.org/stuff/rev#>
PREFIX schema: <https://schema.org/>
PREFIX mod:   <https://w3id.org/mod#>

### Vocabularies contained in LOV and their prefix
DESCRIBE <{vocabularyUriString}>
WHERE {{
  GRAPH <{datasetUriString}> {{
  }}
}}
"""

        let endpoint (namespaceUriString: string) =
            Communication.Internet.ProtocolSuite.Layer.Application.Protocol.Transfer.Text.Hyper.Message.Request.Method.POST
                $"https://lov.linkeddata.es/dataset/lov/sparql"
                [ KeyValuePair(Query.key, (Query.value namespaceUriString)) ]
                client

// ============================================================
// Misc helpers (mostly unchanged)
// ============================================================

let namespaceBindingString = "_prefixID"

let renderStringOption (value: string option) =
    match value with
    | Some v -> $"""(Some @"{v}")"""
    | None -> "None"

let firstUriObjectOrExplain
    (contextLabel: string)
    (namespaceUriString: string)
    (predicateUri: System.Uri)
    (triples: seq<VDS.RDF.Triple>)
    : System.Uri =

    let uriObjects =
        triples
        |> Seq.choose (fun triple ->
            match triple.Object with
            | :? VDS.RDF.IUriNode as uriNode -> Some uriNode.Uri
            | :? VDS.RDF.ILiteralNode as literalNode -> Some(UriFactory.Create(literalNode.Value))
            | _ -> None)
        |> Seq.toList

    match uriObjects with
    | first :: _ -> first
    | [] ->
        let allTriples = triples |> Seq.toList
        eprintfn ""
        eprintfn "FAIL (%s): expected at least 1 triple with a URI object, got 0." contextLabel
        eprintfn "  namespaceUriString: %s" namespaceUriString
        eprintfn "  predicate: %s" (predicateUri.OriginalString)
        eprintfn "  triple count for predicate: %d" allTriples.Length

        allTriples
        |> List.truncate 10
        |> List.iter (fun t ->
            eprintfn "  candidate: %s %s %s" (t.Subject.ToString()) (t.Predicate.ToString()) (t.Object.ToString()))

        raise (System.ArgumentException($"No URI-object triple found for predicate: {predicateUri.OriginalString}"))

let firstRdfLiteralOrExplain
    (contextLabel: string)
    (namespaceUriString: string)
    (predicateUri: System.Uri)
    (triples: seq<VDS.RDF.Triple>)
    : string =

    let literalValues =
        triples
        |> Seq.choose (fun t ->
            match t.Object with
            | :? VDS.RDF.ILiteralNode as lit -> Some lit.Value
            | _ -> None)
        |> Seq.toList

    match literalValues with
    | first :: _ -> first
    | [] ->
        let allTriples = triples |> Seq.toList
        eprintfn ""
        eprintfn "FAIL (%s): expected at least 1 triple with a literal object, got 0." contextLabel
        eprintfn "  namespaceUriString: %s" namespaceUriString
        eprintfn "  predicate: %s" (predicateUri.OriginalString)
        eprintfn "  triple count for predicate: %d" allTriples.Length

        allTriples
        |> List.truncate 10
        |> List.iter (fun t ->
            eprintfn "  candidate: %s %s %s" (t.Subject.ToString()) (t.Predicate.ToString()) (t.Object.ToString()))

        raise (System.ArgumentException($"No literal-object triple found for predicate: {predicateUri.OriginalString}"))

let fileName (basename: string) (extension: string) = $"{basename}.{extension}"
let filePath (directory: string) (fileName: string) = Path.Combine(directory, fileName)

// ============================================================
// Trie rendering (your dot-prefix idea), with AppendLine fix
// ============================================================

// ============================================================
// TRIE: store leaves as (localName -> bindingText)
// so we can bind "Bosc pear (raw)" to localName "00002509".
// ============================================================

// ============================================================
// TRIE: leaves are keyed by *leaf segment* (not full local path)
// so that inside module AI we emit _localName = "AIPackage".
// ============================================================

type NameTrie =
    { leaves: Map<string, string> // leafLocalName -> bindingText
      children: Map<string, NameTrie> }

let emptyNameTrie =
    { leaves = Map.empty
      children = Map.empty }

let splitPath (localName: string) =
    localName.Split([| '/' |], StringSplitOptions.RemoveEmptyEntries)
    |> Array.toList

let rec insertNameSegment (segments: string list) (bindingText: string) (trie: NameTrie) =
    match segments with
    | [] -> trie

    | [ leafLocal ] ->
        // IMPORTANT: store only the LEAF at this trie node.
        // If collisions occur (same leafLocal under same path), keep first and warn.
        if trie.leaves.ContainsKey leafLocal then
            // Do not throw; just keep deterministic output and inform.
            eprintfn "WARN (buildTrie): leaf collision under same path: %s" leafLocal
            trie
        else
            { trie with leaves = trie.leaves.Add(leafLocal, bindingText) }

    | head :: tail ->
        let child =
            trie.children
            |> Map.tryFind head
            |> Option.defaultValue emptyNameTrie

        let child' = insertNameSegment tail bindingText child
        { trie with children = trie.children.Add(head, child') }

let buildTrie (localsWithBindings: (string * string) list) =
    // localsWithBindings is still: (fullLocalName, bindingText)
    localsWithBindings
    |> List.fold
        (fun acc (fullLocal, bindingText) -> insertNameSegment (splitPath fullLocal) bindingText acc)
        emptyNameTrie

let isReserved (s: string) =
    Fsharp.Identifier.reservedKeywordSet.Contains s

let isIdentifierChar (c: char) =
    Char.IsLetterOrDigit c || c = '_' || c = '\''

let needsBackticks (s: string) =
    s.Length = 0
    || isReserved s
    || Char.IsDigit s[0]
    || (s
        |> Seq.exists (fun c -> not (isIdentifierChar c)))



let backtick (s: string) =
    // backticks inside a backticked identifier are not allowed; normalize them.
    let escaped = s.Replace("`", "'")
    $"``{escaped}``"

let sanitizeSegment (s: string) =
    // This is still used for module segments, which you already sanitize.
    s
        .Replace('.', '_')
        .Replace('-', '_')
        .Replace('+', '_')
        .Replace('$', '_')
        .Replace('&', '_')
        .Replace('[', '_')
        .Replace(']', '_')
        .Replace('\\', '_')
        .Replace('*', '_')
        .Replace('\"', '_')
        .Replace('`', '_')
        .Replace('/', '_')

let moduleIdentifier (segmentRaw: string) =
    // root segment: do NOT suffix underscore (you want `swap`)
    let moduleName = sanitizeSegment segmentRaw

    if needsBackticks moduleName then
        backtick moduleName
    else
        moduleName

let submoduleIdentifier (segmentRaw: string) = moduleIdentifier $"{segmentRaw}_"


let valueIdentifierFromBindingText (bindingText: string) =
    if needsBackticks bindingText then
        backtick bindingText
    else
        bindingText

// ============================================================
// renderTrie: use bindingText for the `let <binding> = {_prefixID with _localName="ID"}`
// ============================================================

let indentWhitespace (n: int) = String.replicate n "    "

let renderNameTrie
    (baseNamespaceUri: string)
    (baseDistributionUriString: string option)
    (basePrefixLabel: string)
    (trie: NameTrie)
    : string =

    let rec go (level: int) (currentNamespaceUri: string) (currentPrefixLabel: string) (node: NameTrie) : string =
        let sb = StringBuilder()

        // 1) Leaves: emit _localName = leafLocalName
        for KeyValue (leafLocalName, bindingText) in node.leaves |> Seq.sortBy (fun kv -> kv.Key) do
            let binding = valueIdentifierFromBindingText bindingText

            sb.AppendLine(
                $"{indentWhitespace level}let {binding} = {{{namespaceBindingString} with _localName = \"{leafLocalName}\"}}"
            )
            |> ignore

        // 2) Children: descend and keep consuming segments
        for KeyValue (childSegment, childNode) in node.children |> Seq.sortBy (fun kv -> kv.Key) do
            let childModuleName = submoduleIdentifier childSegment

            let childNamespaceUri =
                // strict '/'-based concatenation, as before
                currentNamespaceUri + childSegment + "/"

            let childPrefixLabel = currentPrefixLabel + "." + childSegment

            sb.AppendLine($"{indentWhitespace level}module {childModuleName} =")
            |> ignore

            sb.AppendLine(
                $"""{indentWhitespace (level + 1)}let {namespaceBindingString} = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "{childNamespaceUri}" {renderStringOption baseDistributionUriString} (Some "{childPrefixLabel}") None """
            )
            |> ignore

            let childText: string = go (level + 1) childNamespaceUri childPrefixLabel childNode
            sb.AppendLine(childText) |> ignore
            sb.AppendLine() |> ignore

        sb.ToString()

    go 1 baseNamespaceUri basePrefixLabel trie
// ============================================================
// OVERRIDE: ID-like locals -> use rdfs:label@en for the *binding name*
// while keeping _localName as the actual ID string.
// ============================================================

// 1) Put the namespaces that should use the override here.
//    (Exact string match; include the exact trailing delimiter you use in ns.)
let localNameIdOverrideNamespaces: Set<string> =
    set [


          "http://purl.obolibrary.org/obo/BFO_"
          "http://purl.obolibrary.org/obo/FOODON_"
          "http://purl.obolibrary.org/obo/IAO_"
          "http://purl.obolibrary.org/obo/NCIT_"
          "http://purl.obolibrary.org/obo/OBI_"
          "http://purl.obolibrary.org/obo/OMRSE_"
          "http://purl.obolibrary.org/obo/PATO_"
          "https://www.commoncoreontologies.org/mro/"
          "http://purl.obolibrary.org/obo/RO_"
          "http://semanticscience.org/resource/SIO_"
          "http://www.ebi.ac.uk/swo/SWO_" 
          "https://www.commoncoreontologies.org/"
          ]

let private rdfsLabelUri =
    UriFactory.Create("http://www.w3.org/2000/01/rdf-schema#label")



let private isIdLikeLocalName (s: string) =
    // "merely ids" should include:
    //  - all digits: 00002509
    //  - letter+digits: C80249, P108
    //  - OBO-ish with underscore: NCIT_C80249 (if you ever pass that form through), SIO_000001
    //  - short alnum codes like NHC0
    if String.IsNullOrWhiteSpace s then
        false
    else
        let s = s.Trim()

        let allDigits =
            s |> Seq.forall Char.IsDigit

        let alphaNumOrUnderscore =
            s |> Seq.forall (fun c -> Char.IsLetterOrDigit c || c = '_')

        let hasDigit =
            s |> Seq.exists Char.IsDigit

        let hasLetter =
            s |> Seq.exists Char.IsLetter

        // Case A: pure numeric IDs
        allDigits
        ||
        // Case B: code-like tokens (letters+digits, optionally underscores)
        (alphaNumOrUnderscore && hasDigit && hasLetter)
let private tryEnglishRdfsLabel (g: IGraph) (subjectUri: Uri) : string option =
    // Prefer language-tagged English literals. If none, fall back to any literal label.
    let subj = g.CreateUriNode(subjectUri)
    let pred = g.CreateUriNode(rdfsLabelUri)

    let labels =
        g.GetTriplesWithSubjectPredicate(subj, pred)
        |> Seq.choose (fun t ->
            match t.Object with
            | :? ILiteralNode as lit ->
                let langOpt =
                    if String.IsNullOrWhiteSpace(lit.Language) then
                        None
                    else
                        Some lit.Language

                Some(lit.Value, langOpt)
            | _ -> None)
        |> Seq.toList

    let isEnglish (lang: string) =
        // accept "en", "en-US", "en-GB", etc.
        lang.Equals("en", StringComparison.OrdinalIgnoreCase)
        || lang.StartsWith("en-", StringComparison.OrdinalIgnoreCase)

    match labels
          |> List.tryFind (fun (_, langOpt) -> langOpt |> Option.exists isEnglish)
        with
    | Some (v, _) -> Some v
    | None -> labels |> List.tryHead |> Option.map fst










// ============================================================
// localNamesFrom: now returns (localName, bindingText) list.
// - If namespace is in override set AND localName is all-digits,
//   try rdfs:label@en and use it for the binding text.
// - Still fails (throws) if there are zero locals.
// ============================================================
let cleanLabel (labelRaw:string) = labelRaw
                                    .Replace(" ", "_")
                                    .Replace("'", "")
                                    .Replace("\"", "")
                                    .Replace(":", "")
let cleanNamespace (namespaceRaw:string) = 
    let cleanSegments = namespaceRaw.Split('.') |> Array.map (fun segment ->
        if
            segment.Contains("/")
            || segment.Contains("-")
            || Fsharp.Identifier.reservedKeywordSet.Contains(segment)
        then
            let backtickableName =
                segment
                    // .Replace('.', '_')
                    .Replace('+', '_')
                    .Replace('$', '_')
                    .Replace('&', '_')
                    .Replace('[', '_')
                    .Replace(']', '_')
                    .Replace('/', '_')
                    .Replace('\\', '_')
                    .Replace('*', '_')
                    .Replace('\"', '_')
                    .Replace('`', '_')

            $"``{backtickableName}``"
        else
            segment
    )
    String.Join(".", cleanSegments)


let localNamesFrom
    (namespaceIri: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type)
    (g: IGraph)
    =
    let ns = namespaceIri._namespaceUri.OriginalString
    let useOverride = localNameIdOverrideNamespaces.Contains ns

    let leafFrom (local:string) =
                    let leaf =
                        local.Split([| '/' |], StringSplitOptions.RemoveEmptyEntries)
                        |> Array.tryLast
                        |> Option.defaultValue local

                    Some(local, leaf)

    let localsWithBindings =
        g.AllNodes.UriNodes()
        |> Seq.choose (fun uriNode ->
            let iri = uriNode.Uri.OriginalString

            if iri.StartsWith(ns, StringComparison.Ordinal) then
                let local = iri.Substring(ns.Length)

                if local.Length = 0 then
                    None
                else if useOverride && isIdLikeLocalName local then
                    // bindingText = label@en if present, else fallback to local id
                    let labelTextRaw =
                        tryEnglishRdfsLabel g uriNode.Uri
                        |> Option.defaultValue local

                    let labelTextClean = cleanLabel labelTextRaw
                    if labelTextClean = local 
                        then
                            leafFrom local
                        else
                            let bindingText = $"{labelTextClean}'{local}"
                            Some(local, bindingText)
                else
                    // default binding name is the *leaf* segment, not the whole path
                    leafFrom local
            else
                None)
        |> Seq.distinct
        |> Seq.toList

    if localsWithBindings.IsEmpty then
        eprintfn ""
        eprintfn "FAIL (localNamesFrom): got 0 local names."
        eprintfn "  namespaceUri: %s" namespaceIri._namespaceUri.OriginalString
        eprintfn "  distributionUri: %s" (defaultArg namespaceIri._distributionUriString "<none>")
        eprintfn "  uriNodesTotal: %d" (g.AllNodes.UriNodes() |> Seq.length)

        g.AllNodes.UriNodes()
        |> Seq.map (fun u -> u.Uri.OriginalString)
        |> Seq.truncate 25
        |> Seq.iter (fun s -> eprintfn "  sample: %s" s)

        failwith "No local names found after namespace match."
    else
        localsWithBindings

// ============================================================
// Parser fallback: IRdfReader + IStoreReader, returning ONE Failure type
// ============================================================

type LoadAttempt = { attemptName: string; attemptExecution: unit -> IGraph } // returns a graph or throws

let extensionHint (u: Uri) : string option =
    let path = u.AbsolutePath
    let i = path.LastIndexOf('.')

    if i >= 0 && i < path.Length - 1 then
        Some(path.Substring(i + 1).ToLowerInvariant())
    else
        None


// ------------------------------------------------------------
// Fetch+Parse (auto): chooses parser based on Content-Type (and a cheap sniff)
// Handles IRdfReader vs IStoreReader branching (JsonLdParser version variance)
// ------------------------------------------------------------

let private firstNonWhitespaceChar (s: string) : char option =
    s
    |> Seq.tryFind (fun c -> not (Char.IsWhiteSpace c))

let private mediaTypeLower (mt: string option) =
    mt
    |> Option.map (fun s -> s.Trim().ToLowerInvariant())

let private parseGraphFromStringWithReader (content: string) (reader: IRdfReader) : IGraph =
    let g = new Graph()
    g.LoadFromString(content, reader)
    g :> IGraph

let private parseGraphFromStringWithStoreReader (content: string) (reader: IStoreReader) : IGraph =
    let store = new TripleStore()
    use sr = new StringReader(content)
    reader.Load(store, sr)
    let g = new Graph()

    for sg in store.Graphs do
        g.Merge(sg, true)

    g :> IGraph

let private tryParseJsonLdIntoGraph (content: string) : IGraph =
    // dotNetRDF version variance:
    // - Some builds: JsonLdParser : IRdfReader
    // - Some builds: JsonLdParser : IStoreReader (or only store-capable)
    //
    // We runtime-dispatch.

    let p = JsonLdParser()

    match box p with
    | :? IRdfReader as r -> parseGraphFromStringWithReader content r
    | :? IStoreReader as sr -> parseGraphFromStringWithStoreReader content sr
    | _ -> failwith "JsonLdParser exists but implements neither IRdfReader nor IStoreReader in this build."

let private attemptFetchThenParse (namespaceUriString: string) (uri: Uri) : LoadAttempt =
    { attemptName = "Fetch+Parse (auto by Content-Type)"
      attemptExecution =
        fun () ->
            let p = probeWithHeaders uri.OriginalString |> result

            if p.statusCode < 200 || p.statusCode >= 300 then
                raise (
                    Exception(
                        $"""HTTP {p.statusCode} from {p.dereferencedUrl} (mediaType={defaultArg p.mediaType "<none>"})"""
                    )
                )

            let mt = mediaTypeLower p.mediaType
            let sniff = firstNonWhitespaceChar p.content

            // Primary decision: Content-Type
            // Secondary decision: trivial sniff
            match mt, sniff with
            | Some ct, _ when
                ct.Contains("text/turtle")
                || ct.Contains("application/turtle")
                || ct.Contains("text/n3")
                ->
                parseGraphFromStringWithReader p.content (TurtleParser() :> IRdfReader)

            | Some ct, _ when
                ct.Contains("application/rdf+xml")
                || ct.Contains("application/xml")
                || ct.Contains("text/xml")
                ->
                parseGraphFromStringWithReader p.content (RdfXmlParser() :> IRdfReader)

            | Some ct, _ when ct.Contains("application/n-triples") ->
                parseGraphFromStringWithReader p.content (NTriplesParser() :> IRdfReader)

            | Some ct, _ when ct.Contains("application/trig") ->
                parseGraphFromStringWithStoreReader p.content (TriGParser() :> IStoreReader)

            | Some ct, _ when ct.Contains("application/n-quads") ->
                parseGraphFromStringWithStoreReader p.content (NQuadsParser() :> IStoreReader)

            | Some ct, _ when
                ct.Contains("application/ld+json")
                || ct.Contains("application/json")
                || ct.Contains("text/json")
                ->
                tryParseJsonLdIntoGraph p.content

            // If Content-Type is missing or useless: sniff
            | _, Some '{' ->
                // almost certainly JSON / JSON-LD
                tryParseJsonLdIntoGraph p.content

            | _, Some '<' ->
                // probably RDF/XML (or HTML). Try RDF/XML first, then Turtle.
                try
                    parseGraphFromStringWithReader p.content (RdfXmlParser() :> IRdfReader)
                with
                | _ -> parseGraphFromStringWithReader p.content (TurtleParser() :> IRdfReader)

            | _ ->
                // last resort: Turtle then RDF/XML
                try
                    parseGraphFromStringWithReader p.content (TurtleParser() :> IRdfReader)
                with
                | _ -> parseGraphFromStringWithReader p.content (RdfXmlParser() :> IRdfReader) }

let private attemptGraph (namespaceUri:Uri) (distributionUri: Uri) (attemptName: string) (reader: IRdfReader) : LoadAttempt =
    { attemptName = attemptName
      attemptExecution =
        fun () ->
            let g = new Graph(namespaceUri)
            g.LoadFromUri(distributionUri, reader)
            g :> IGraph }

let private attemptStore (namespaceUri:Uri) (distributionUri: Uri) (attemptName: string) (reader: IStoreReader) : LoadAttempt =
    { attemptName = attemptName
      attemptExecution =
        fun () ->
            let store = new TripleStore()
            store.LoadFromUri(distributionUri, reader)
            let g = new Graph(namespaceUri)

            for sg in store.Graphs do
                g.Merge(sg, true)

            g :> IGraph }

let private attemptDefaultGraphLoad (namespaceUri:Uri) (distributionUri: Uri) : LoadAttempt =
    { attemptName = "Graph.LoadFromUri (default)"
      attemptExecution =
        fun () ->
            let g = new Graph()
            g.LoadFromUri(distributionUri)
            g :> IGraph }

let private isBlockedHost (uri: Uri) =
    uri.Host.Equals("id.loc.gov", StringComparison.OrdinalIgnoreCase)
    || uri.Host.Equals("www.w3.org", StringComparison.OrdinalIgnoreCase)
    || uri.Host.Equals("gitlab.gnome.org", StringComparison.OrdinalIgnoreCase)
    || uri.Host.Equals("semiceu.github.io", StringComparison.OrdinalIgnoreCase)
    || uri.Host.Equals("ns.ottr.xyz", StringComparison.OrdinalIgnoreCase)
    || uri.Host.Equals("spec.ottr.xyz", StringComparison.OrdinalIgnoreCase)
    || uri.Host.Equals("rdfs.org", StringComparison.OrdinalIgnoreCase)
    

// ------------------------------------------------------------
// attemptsFor: inject ONE auto fetch+parse attempt for blocked hosts
// ------------------------------------------------------------

let  attemptsFor (namespaceUriString: string) (distributionUri: Uri) : LoadAttempt list =
    let namespaceUri = UriFactory.Create(namespaceUriString)
    let baseAttempts =
        match extensionHint distributionUri with
        | Some "ttl"
        | Some "ontology"
        | Some "turtle"
        | Some "n3" ->
            [ attemptGraph namespaceUri  distributionUri "TurtleParser" (TurtleParser() :> IRdfReader)
              attemptGraph namespaceUri distributionUri "RdfXmlParser" (RdfXmlParser() :> IRdfReader)
              attemptStore namespaceUri distributionUri "TriGParser" (TriGParser() :> IStoreReader)
              attemptDefaultGraphLoad namespaceUri distributionUri ]
        | Some "rdf"
        | Some "xml"
        | Some "owl" ->
            [ attemptGraph namespaceUri distributionUri "RdfXmlParser" (RdfXmlParser() :> IRdfReader)
              attemptGraph namespaceUri distributionUri "TurtleParser" (TurtleParser() :> IRdfReader)
              attemptStore namespaceUri distributionUri "TriGParser" (TriGParser() :> IStoreReader)
              attemptDefaultGraphLoad namespaceUri distributionUri ]
        | Some "trig" ->
            [ attemptStore namespaceUri distributionUri "TriGParser" (TriGParser() :> IStoreReader)
              attemptGraph namespaceUri distributionUri "TurtleParser" (TurtleParser() :> IRdfReader)
              attemptDefaultGraphLoad namespaceUri distributionUri ]
        | Some "nq" ->
            [ attemptStore namespaceUri distributionUri "NQuadsParser" (NQuadsParser() :> IStoreReader)
              attemptStore namespaceUri distributionUri "TriGParser" (TriGParser() :> IStoreReader)
              attemptDefaultGraphLoad namespaceUri distributionUri ]
        | Some "jsonld"
        | Some "json" ->
            [ attemptDefaultGraphLoad namespaceUri distributionUri
              attemptGraph namespaceUri distributionUri "TurtleParser" (TurtleParser() :> IRdfReader)
              attemptGraph namespaceUri distributionUri "RdfXmlParser" (RdfXmlParser() :> IRdfReader)
              attemptStore namespaceUri distributionUri "TriGParser" (TriGParser() :> IStoreReader) ]
        | _ ->
            [ attemptGraph namespaceUri distributionUri "TurtleParser" (TurtleParser() :> IRdfReader)
              attemptGraph namespaceUri distributionUri "RdfXmlParser" (RdfXmlParser() :> IRdfReader)
              attemptStore namespaceUri distributionUri "TriGParser" (TriGParser() :> IStoreReader)
              attemptDefaultGraphLoad namespaceUri distributionUri ]

    if isBlockedHost distributionUri then
        // Inject the auto fetch+parse attempt FIRST.
        (attemptFetchThenParse namespaceUriString distributionUri)
        :: baseAttempts
    else
        baseAttempts

// ------------------------------------------------------------
// OPTIONAL but recommended: never dereference a fragment URI
// (Hydra namespace ends with #; dereference drops it)
// ------------------------------------------------------------

let private stripFragment (u: Uri) =
    if String.IsNullOrEmpty(u.Fragment) then
        u
    else
        Uri(u.GetLeftPart(UriPartial.Path))

// Then, wherever you create distributionUri for loading, do:
// let distributionUriNoFrag = stripFragment distributionUri
// and pass that into loadGraphFromUriWithFallback.





let loadGraphFromUriWithFallback (namespaceUriString: string) (distributionUri: Uri) : Outcome<IGraph> =

    let attemptsTried = ResizeArray<string>()

    let rec loopLoadAttempts (loadAttemptList: LoadAttempt list) : Outcome<IGraph> =
        match loadAttemptList with
        | [] ->
            Error
                { namespaceUriString = namespaceUriString
                  stage = "loadGraphFromUriWithFallback"
                  exceptionText = "All attempts failed."
                  httpStatus = None
                  httpMediaType = None
                  dereferencedUrl = Some distributionUri.OriginalString
                  contentSnippet = None
                  attempts = Some(attemptsTried |> Seq.toList) }
        | currentAttempt :: attemptList ->
            attemptsTried.Add currentAttempt.attemptName

            try
                Ok(currentAttempt.attemptExecution ())
            with
            | currentAttemptException ->
                match loopLoadAttempts attemptList with
                | Ok graphFromSuccessfulAttempt -> Ok graphFromSuccessfulAttempt
                | Error failedAttempt -> Error { failedAttempt with exceptionText = currentAttemptException.ToString() }

    try
        loopLoadAttempts (attemptsFor namespaceUriString distributionUri)

    with
    | loadGraphException ->
        Error
            { namespaceUriString = namespaceUriString
              stage = "loadGraphFromUriWithFallback"
              exceptionText = loadGraphException.ToString()
              httpStatus = None
              httpMediaType = None
              dereferencedUrl = Some distributionUri.OriginalString
              contentSnippet = None
              attempts = Some(attemptsTried |> Seq.toList) }
// ============================================================
// Codegen: returns Outcome<string> per namespaceIri (fsx path on success)
// ============================================================


// Strict: keep scheme/host/path structure, and record hash-vs-slash.
module IriPathing =

    let private sanitizeSegment (s: string) =
        // Keep it conservative: only letters/digits and a small set of safe punctuation.
        // Everything else becomes '_'.
        s
        |> Seq.map (fun c ->
            if Char.IsLetterOrDigit c
               || c = '.'
               || c = '-'
               || c = '_' then
                c
            else
                '_')
        |> Seq.toArray
        |> String

    let private splitPathSegments (path: string) =
        path.Split([| '/' |], StringSplitOptions.RemoveEmptyEntries)
        |> Array.toList
        |> List.map sanitizeSegment

    /// Returns a relative directory path + filename.
    /// Example:
    ///   http://www.w3.org/1999/02/22-rdf-syntax-ns#  + "rdf"
    /// -> "http/www.w3.org/1999/02/22-rdf-syntax-ns/hash/rdf.fsx"
    let iriToRelativePath (namespaceIriString: string) =
        let uri = Uri(namespaceIriString)

        let scheme = sanitizeSegment uri.Scheme // "http" / "https"
        let host = sanitizeSegment uri.Host // "www.w3.org"
        let pathSegments = splitPathSegments uri.AbsolutePath // ["1999"; "02"; ...]

        // Disambiguate namespace delimiter style
        // NOTE: Uri.Fragment is "" for a trailing '#', but the original string *does* end with '#'.
        let delimiterBucket =
            if namespaceIriString.EndsWith("#", StringComparison.Ordinal) then
                "hash"
            elif namespaceIriString.EndsWith("/", StringComparison.Ordinal) then
                "slash"
            else
                "bare"


        // Build relative path with forward slashes; Path.Combine can be used later for OS paths.
        let dirs =
            [ scheme; host ]
            @ pathSegments @ [ delimiterBucket ]

        Path.Combine(dirs |> List.toArray)
let codegenFromNamespaceIris
    (namespaceIriList: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type list)
    : Outcome<string> list =
    namespaceIriList
    |> List.map (fun namespaceIri ->

        let relativePath =
            IriPathing.iriToRelativePath namespaceIri._namespaceUri.OriginalString

        let moduleBasename =  namespaceIri._namespacePrefix.Value
        Console.WriteLine moduleBasename
        //let moduleFilePath = Path.Combine(Artifact.Vocabulary.directory, relativeModulePath)
        let moduleParentDirectory = Ensure.path ( Path.Combine(Artifact.Vocabulary.Generated.directory, relativePath))
        let moduleFilePath = Path.Combine(moduleParentDirectory, $"{moduleBasename}.fs")

        match namespaceIri._distributionUriString with
        | None ->
            Error
                { namespaceUriString = namespaceIri._namespaceUri.OriginalString
                  stage = "codegenFromNamespaceIris:missingDistributionUri"
                  exceptionText = "namespaceIri._distributionUriString was None"
                  httpStatus = None
                  httpMediaType = None
                  dereferencedUrl = None
                  contentSnippet = None
                  attempts = None }

        | Some distribution ->
            let distributionGraphUri = UriFactory.Create distribution

            match loadGraphFromUriWithFallback namespaceIri._namespaceUri.OriginalString distributionGraphUri with
            | Error f -> Error { f with stage = "codegenFromNamespaceIris:loadGraphFromUriWithFallback" }

            | Ok unnamedDistributionGraph ->

                let distributionGraph = new ThreadSafeGraph(namespaceIri._node)
                distributionGraph.Merge unnamedDistributionGraph
                let graphParentDirectory =  Ensure.path (Path.Combine(Artifact.Vocabulary.Generated.directory,relativePath ))
                let graphFilePath = Path.Combine(graphParentDirectory, moduleBasename)
                distributionGraph.NamespaceMap.AddNamespace(namespaceIri._namespacePrefix.Value, namespaceIri._namespaceUri)
                let distributionNamedGraph =
                            NamedGraph.fromIGraph
                                namespaceIri
                                graphFilePath
                                distributionGraph
             
                
                GraphRuntime.Serialization.Turtle.save distributionNamedGraph
                try
                    let namespacePrefixRaw = namespaceIri._namespacePrefix.Value

                    let cleanNamespace  = cleanNamespace namespacePrefixRaw

                    let renderedTrie =
                        renderNameTrie
                            namespaceIri._namespaceUri.OriginalString
                            namespaceIri._distributionUriString
                            namespaceIri._namespacePrefix.Value
                            (buildTrie (localNamesFrom namespaceIri distributionGraph))
                    let cleanModule = getLastSegment cleanNamespace '.'
                    let templateContent =
                        $"""
namespace {capitalizeFirst cleanNamespace}.Namespace
module {cleanModule} =
    let {namespaceBindingString} = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "{namespaceIri._namespaceUri.OriginalString}" {renderStringOption namespaceIri._distributionUriString} {renderStringOption namespaceIri._namespacePrefix} None
{renderedTrie}
                        """
                            .TrimStart()
                            .TrimEnd()

                    Artifact.saveToFile moduleFilePath templateContent
                    Ok moduleFilePath
                with
                | ex ->
                    Error
                        { namespaceUriString = namespaceIri._namespaceUri.OriginalString
                          stage = "codegenFromNamespaceIris:templateOrWrite"
                          exceptionText = ex.ToString()
                          httpStatus = None
                          httpMediaType = None
                          dereferencedUrl = namespaceIri._distributionUriString
                          contentSnippet = None
                          attempts = None })

// ============================================================
// LOV -> namespace iris: returns Outcome<Internationalized.Type> list
//   (keeps your existing extraction logic, but now uses ONE failure type)
// ============================================================

let namespaceIriFromLovUriStrings
    (namespaceUriStringList: string list)
    : Outcome<Communication.Internet.Standard.Resource.Identifier.Internationalized.Type> list =
    namespaceUriStringList
    |> List.map (fun namespaceUriString ->
        try
            let lovResp = lov.Sparql.endpoint namespaceUriString |> result
            let body = lovResp.Content.ReadAsStringAsync() |> result

            let g: RDF.IGraph = new RDF.Graph()
            g.LoadFromString body

            let dcatDistributionUri =
                UriFactory.Create("http://www.w3.org/ns/dcat#distribution")

            let namespaceDistributionUri =
                firstUriObjectOrExplain
                    "dcat:distribution"
                    namespaceUriString
                    dcatDistributionUri
                    (g.GetTriplesWithPredicate dcatDistributionUri)

            let vannNamespacePrefixUri =
                UriFactory.Create("http://purl.org/vocab/vann/preferredNamespacePrefix")

            let preferredNamespacePrefix =
                firstRdfLiteralOrExplain
                    "vann:preferredNamespacePrefix"
                    namespaceUriString
                    vannNamespacePrefixUri
                    (g.GetTriplesWithPredicate vannNamespacePrefixUri)

            Ok(
                Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
                    namespaceUriString
                    (Some namespaceDistributionUri.OriginalString)
                    (Some preferredNamespacePrefix)
                    None
            )
        with
        | ex ->
            Error
                { namespaceUriString = namespaceUriString
                  stage = "namespaceIriFromLovUriStrings"
                  exceptionText = ex.ToString()
                  httpStatus = None
                  httpMediaType = None
                  dereferencedUrl = None
                  contentSnippet = None
                  attempts = None })

// ============================================================
// Example execution + unified failure reporting
// ============================================================




let codegenOutcomes = codegenFromNamespaceIris namespaceIris

let failures =
    codegenOutcomes
    |> List.choose (function
        | Error f -> Some f
        | Ok _ -> None)

if not failures.IsEmpty then
    let report =
        failures
        |> List.map (fun f ->
            $"""FAIL ({f.stage})
  namespaceUriString: {f.namespaceUriString}
  dereferencedUrl: {defaultArg f.dereferencedUrl "<none>"}
  httpStatus: {f.httpStatus
               |> Option.map string
               |> Option.defaultValue "<none>"}
  httpMediaType: {defaultArg f.httpMediaType "<none>"}
  attempts: {f.attempts
             |> Option.map (String.concat ", ")
             |> Option.defaultValue "<none>"}
{f.exceptionText}
{f.contentSnippet |> Option.defaultValue ""}
            """)
        |> String.concat "\n"

    Artifact.saveToFile Artifact.CodegenFailures.txt report




// ------------------------------
// Configuration
// ------------------------------

let moduleFiles =
    Directory.GetFiles(Artifact.Vocabulary.directory, "*.fsx", SearchOption.AllDirectories)
    |> Array.sort
    |> Array.toList

let prelude =
    """
#if INTERACTIVE && !RNUGET_LOADED
#load "Rnuget.fsx"
#endif

open System
open VDS
open VDS.RDF
open System.IO

// Shared binding name expected by generated modules
let namespaceBindingString = "_prefixID"
type MintingNamespace(prefixID: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type) =
    member this.prefix(localNameRaw: string) =
        let localName = localNameRaw.Replace(" ", "_")
        { prefixID with _localName = localName }

    member _.Item
        with get (localNameRaw: string) =
            let localName = localNameRaw.Replace(" ", "_")
            { prefixID with _localName = localName }
        
"""

// ------------------------------
// Helpers: indentation + parsing
// ------------------------------

let indentString (level: int) (s: string) =
    // 4 spaces per level; keep consistent with your other generators.
    let pad = String.replicate level "    "

    if String.IsNullOrWhiteSpace(s) then
        s
    else
        pad + s

let indentBlock (level: int) (text: string) =
    text.Replace("\r\n", "\n").Split('\n')
    |> Array.map (indentString level)
    |> String.concat "\n"


// Parse: `module ``swap.math`` =` OR `module swap =`
let tryParseModuleHeader (text: string) : string list option =
    let firstLine =
        text.Replace("\r\n", "\n").Split('\n')
        |> Array.tryFind (fun l -> not (String.IsNullOrWhiteSpace l))

    match firstLine with
    | None -> None
    | Some line ->
        // capture whatever is between "module " and " ="
        // group 1 includes possible backticks.
        let m = Regex.Match(line, @"^\s*module\s+(.+?)\s*=\s*$")

        if not m.Success then
            None
        else
            let raw = m.Groups.[1].Value.Trim()
            // strip enclosing double-backticks if present: ``swap.math``
            let unwrapped =
                if raw.StartsWith("``")
                   && raw.EndsWith("``")
                   && raw.Length >= 4 then
                    raw.Substring(2, raw.Length - 4)
                else
                    raw

            // split on dot for hierarchy
            let segments =
                unwrapped.Split([| '.' |], StringSplitOptions.RemoveEmptyEntries)
                |> Array.toList

            if segments.Length = 0 then
                None
            else
                Some segments

let dropFirstNonEmptyLine (text: string) =
    let lines =
        text.Replace("\r\n", "\n").Split('\n')
        |> Array.toList

    let rec loop acc rest =
        match rest with
        | [] -> List.rev acc
        | h :: t ->
            if String.IsNullOrWhiteSpace h then
                loop (h :: acc) t
            else
                List.rev acc @ t

    loop [] lines |> String.concat "\n"

// ------------------------------
// Trie for module segments
// ------------------------------

type ModuleTrie =
    { // bodies directly attached to this node (rare, but allow it)
      bodies: string list
      children: Map<string, ModuleTrie> }

let emptyModuleTrie = { bodies = []; children = Map.empty }

let rec insertModuleSegment (segments: string list) (body: string) (node: ModuleTrie) : ModuleTrie =
    match segments with
    | [] -> { node with bodies = body :: node.bodies }
    | head :: tail ->
        let child =
            node.children
            |> Map.tryFind head
            |> Option.defaultValue emptyModuleTrie

        let child' = insertModuleSegment tail body child
        { node with children = node.children.Add(head, child') }

let buildTrieFromFiles (files: string list) =
    files
    |> List.fold
        (fun acc file ->
            let content = File.ReadAllText(file)

            match tryParseModuleHeader content with
            | None ->
                // If we can’t parse, keep it as a “body” under a synthetic key so it still appears.
                // You can tighten this later.
                insertModuleSegment [ "__UNPARSED__" ] (content.TrimEnd()) acc
            | Some segments ->
                let body =
                    dropFirstNonEmptyLine content
                    |> fun s -> s.TrimEnd()

                insertModuleSegment segments body acc)
        emptyModuleTrie

// ------------------------------
// Rendering: swap → math_ → ...
// ------------------------------

let renderModuleTrie (trie: ModuleTrie) =
    let sb = StringBuilder()

    let rec go (level: int) (segmentsSoFar: string list) (node: ModuleTrie) =
        // Emit any bodies directly on this node.
        // Typically you won't have these (your files attach bodies at leaf nodes).
        for body in node.bodies |> List.rev do
            sb.AppendLine(indentBlock level body) |> ignore
            sb.AppendLine() |> ignore

        // Emit children as nested modules
        node.children
        |> Seq.sortBy (fun kv -> kv.Key)
        |> Seq.iter (fun (KeyValue (seg, child)) ->
            let moduleName =
                match segmentsSoFar with
                | [] -> moduleIdentifier seg
                | _ -> submoduleIdentifier seg

            sb.AppendLine($"""{String.replicate level "    "}module {moduleName} =""")
            |> ignore

            // If the child has no bodies and only children, still descend.
            go (level + 1) (segmentsSoFar @ [ seg ]) child

            // Spacer between sibling modules
            sb.AppendLine() |> ignore)

    go 0 [] trie
    sb.ToString()

// ------------------------------
// Put it together
// ------------------------------

let moduleTrie = buildTrieFromFiles moduleFiles

let moduleContent =
    let sb = StringBuilder()
    sb.AppendLine(prelude.TrimStart()) |> ignore
    sb.AppendLine() |> ignore

    sb.AppendLine("// ========================================================")
    |> ignore

    sb.AppendLine("// GENERATED MODULES (ROLLUP)")
    |> ignore

    sb.AppendLine("// ========================================================")
    |> ignore

    sb.AppendLine() |> ignore

    sb.AppendLine(renderModuleTrie moduleTrie)
    |> ignore

    sb.ToString()

// File.WriteAllText(Artifact.PrefixDeclaration.fsx, moduleContent, Encoding.UTF8)
// printfn "Wrote %s (%d module payloads)" Artifact.PrefixDeclaration.fsx moduleFiles.Length
