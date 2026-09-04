(*

& "C:\Program Files\Google\Chrome\Application\chrome.exe" --remote-debugging-port=9222 --user-data-dir=C:\temp\chrome-automation


& "C:\Program Files\Mozilla Firefox\firefox.exe" --remote-debugging-port 9223
*)
// TODO add gnd to known ontologies https:-nb.info/standards/elementset/gnd2012-06-30

# time on
fsi.ShowDeclarationValues <- false
// fsi.ShowDeclarationValues <- true
open System
open System.Collections
open System.Collections.Concurrent
open System.ComponentModel.DataAnnotations
open System.Diagnostics
open System.Globalization
open System.IO
open System.IO.Compression
open System.Linq
open System.Linq.Expressions
open System.Net
open System.Net.Http
open System.Net.Http.Headers
open System.Reflection
open System.Text
open System.Text.Json
open System.Text.Json.Nodes
open System.Text.Json.Serialization
open System.Text.RegularExpressions
open System.Text.Unicode
open System.Threading
open System.Threading.Tasks
open System.Xml
open System.Xml.Linq
open System.Xml.Schema
open System.Xml.Serialization
open System.Xml.XPath

#r "nuget: Meziantou.Framework.ValueStopwatch, 3.0.0"
let loadTimer =  Meziantou.Framework.ValueStopwatch.StartNew()
#load @".paket/load/main.group.fsx"
#r "nuget: Esri.ArcGISRuntime, 300.0.0"
#r "nuget: Microsoft.SqlServer.DacFx, 162.5.57"


open Microsoft.Kiota.Abstractions.Store
open AngleSharp.Attributes
open AngleSharp.Html
open BrowserApi
open BrowserApi.Common
open BrowserApi.Css
open BrowserApi.Css.Authoring
open CaseConverter
open CsvHelper
open Dubzer.WhatwgUrl
open Esri.ArcGISRuntime
open Esri.ArcGISRuntime.ArcGISServices
open Esri.ArcGISRuntime.Data
open Esri.ArcGISRuntime.Geometry
open Esri.ArcGISRuntime.Mapping
open Esri.ArcGISRuntime.Mapping.FeatureForms
open Esri.ArcGISRuntime.Mapping.Popups
open Esri.ArcGISRuntime.Portal
open Esri.ArcGISRuntime.Symbology
open Fabulous.AST
open Fantomas.Core
open Fantomas.FCS
open Fli
open FolkerKinzel.MimeTypes
open FPrimitive
open FsExcel
open FSharp.Collections.ParallelSeq
open FSharp.Compiler
open FSharp.Data
open FSharp.Data.Adaptive.Transaction
open FSharp.Data.JsonExtensions
open FSharp.Data.JsonPath
open FSharp.Data.JsonSchema
open FSharp.Data.JsonSchema.Core
open FSharp.Data.JsonSchema.OpenApi
open FSharp.Data.JsonSchemaExtensions
open FSharp.Data.Mutator
open FSharp.Data.Sql
open FSharp.Data.Sql.MsSql
open FSharp.HashCollections
open FSharp.Json
open FSharp.Literals
open FSharp.ViewEngine
open FSharp.XExtensions
open FsHttp
open FsPdf
open Humanizer
open Iride
open Iride.Extensions
open IriTools
open Json.More
open Json.Path
open Json.Pointer
open JsonStructure
open ktsu.Semantics.Paths
open ktsu.Semantics.Strings
open ktsu.Semantics.Strings.Identifiers
open Lambda2Js
open Meziantou.Framework
open Meziantou.Framework.Json
open Meziantou.Framework.Language
open Meziantou.Framework.Language.Json
open Microsoft.Extensions.Logging.Abstractions
open Microsoft.FSharp.Linq.RuntimeHelpers
open Microsoft.Graph
open Microsoft.Graph.Models
open Microsoft.Graph.Users.Item.SendMail
open Microsoft.SqlServer
open Newtonsoft.Json
open Newtonsoft.Json.Linq
open NJsonSchema
open NLanguageTag
open OBO.NET
open OBO.NET.CodeGeneration
open OpenQA.Selenium
open OWLSharp
open OWLSharp.Extensions
open OWLSharp.Ontology
open PhoneNumbers
open PosInformatique.Foundations.EmailAddresses
open PuppeteerSharp
open PuppeteerSharp.Cdp
open PuppeteerSharp.Contrib.Extensions
open PuppeteerSharp.Dom
open QuikGraph
open QuikGraph.Data
open QuikGraph.Graphviz
open QuikGraph.MSAGL
open QuikGraph.Petri
open QuikGraph.Serialization
open RDFSharp
open RDFSharp.Model
open Refit
open SafeName
open SolarWinds.Api
open SolarWinds.Api.ServiceDesk
open SolarWinds.Api.ServiceDesk.Helpers
open SolarWinds.Api.ServiceDesk.Interfaces
open SolarWinds.Api.ServiceDesk.Models
open Tavis.UriTemplates
open TextCopy
open TruePath
open TruePath.SystemIo
open UglyToad.PdfPig
open UglyToad.PdfPig.Tokens
open Universal.Common
open VDS.RDF
open VDS.RDF.JsonLd
open VDS.RDF.Nodes
open VDS.RDF.Ontology
open VDS.RDF.Parsing
open VDS.RDF.Parsing.Handlers
open VDS.RDF.Parsing.Tokens
open VDS.RDF.Query
open VDS.RDF.Query.Builder
open VDS.RDF.Query.Datasets
open VDS.RDF.Query.Expressions
open VDS.RDF.Query.Inference
open VDS.RDF.Query.Patterns
open VDS.RDF.Storage
open VDS.RDF.Writing
open VDS.RDF.Writing.Formatting
open WebDriverBiDi
open WebDriverBiDi.BrowsingContext
open WebDriverBiDi.Session
open WebSharper.Core
open XParsec
open Yog.Builder
open Yog.IO
open Yog.Model
open Yog.Pathfinding.Dijkstra
open Yog.Render
open Yog.Render.Dot
open Yog.Render.Mermaid
module FSharpLiteral = FSharp.Literals.Literal

(*



#r "nuget: Microsoft.Graph"

#r "nuget: CsvHelper"
#r "nuget: SafeName"
#r "nuget: WebSharper"
#r "nuget: Microsoft.Extensions.Logging.Abstractions"
#r "nuget: FSharp.ViewEngine"
#r "nuget: Json.More.Net"
#r "nuget: JsonStructure"
#r "nuget: JsonPointer.Net"
#r "nuget: JsonPath.Net"
#r "nuget: SolarWinds.Api"
#r "nuget: Fli"
#r "nuget: FSharp.Collections.ParallelSeq"
#r "nuget: FPrimitive"
#r "nuget: Universal.Common.Css.Selectors"
#r "nuget: Newtonsoft.Json"
#r "nuget: Meziantou.Framework"
#r "nuget: Meziantou.Framework.Uri"
#r "nuget: Meziantou.Framework.Language.Json"
#r "nuget: Humanizer.Core"
#r "nuget: CaseConverter"
#r "nuget: FSharp.Data"
#r "nuget: SQLProvider.MsSql, 1.5.18"
#r "nuget: FSharp.Data.Mutator"
#r "nuget: FSharp.Data.JsonPath"
#r "nuget: FSharp.Data.JsonSchema.Core"
#r "nuget: FSharp.Data.JsonSchema.OpenApi"
#r "nuget: FSharp.Data.JsonSchema.NJsonSchema"
#r "nuget: PuppeteerSharp"
#r "nuget: PuppeteerSharp.Contrib.Extensions"
#r "nuget: PuppeteerSharp.Dom, 5.0.43"
#r "nuget: Dubzer.WhatwgUrl"
#r "nuget: TextCopy"
#r "nuget: NLanguageTag"
#r "nuget: Tavis.UriTemplates"
#r "nuget: Meziantou.Framework.Language.Json"
#r "nuget: FSharp.ViewEngine"
#r "nuget: FolkerKinzel.MimeTypes"
#r "nuget: dotNetRdf"
#r "nuget: FSharp.Json"
#r "nuget: RDFSharp"
#r "nuget: OWLSharp"              
#r "nuget: OWLSharp.Extensions"   
#r "nuget: OBO.NET"               
#r "nuget: OBO.NET.CodeGeneration"
#r "nuget: IriTools"                 
#r "nuget: Iride"                 
#r "nuget: PosInformatique.Foundations.EmailAddresses"
#r "nuget: libphonenumber-csharp" 
#r "nuget: FSharp.Compiler.Service"
#r "nuget: FSharp.Literals"
#r "nuget: FSharp.Data.Adaptive"
#r "nuget: FSharp.HashCollections"
#r "nuget: FSharp.XExtensions"
#r "nuget: LitXml"
#r "nuget: Fabulous.AST"
#r "nuget: Fantomas.FCS"
#r "nuget: XParsec"
#r "nuget: Yog.FSharp"
#r "nuget: QuikGraph"
#r "nuget: QuikGraph.Serialization"
#r "nuget: QuikGraph.Graphviz"
#r "nuget: QuikGraph.Data"
#r "nuget: QuikGraph.MSAGL"
#r "nuget: QuikGraph.Petri"
#r "nuget: FsHttp"
#r "nuget: FsPdf"
#r "nuget: PdfPig"


#r "nuget: FSharp.Compiler.Service, 43.10.102"

#r "nuget: Microsoft.SqlServer.DacFx, 162.5.57"


#r "nuget: FsExcel"

#r "nuget: Esri.ArcGISRuntime, 300.0.0"


#r "nuget: BrowserApi, 0.1.0-preview.9"

#r "nuget: Selenium.WebDriver, 4.47.0"


#r "nuget: AngleSharp, 1.7.2"
#r "nuget: Lambda2Js, 3.1.4"






#r "nuget: BrowserApi, 0.1.0-preview.9"



*)


let loadTime = loadTimer.GetElapsedTime()
printfn "Loaded in %s" (loadTime.Humanize(2))



type El with
    static member Iframe = Selector "iframe"
    static member I = Selector "i"

type Attr with 
    static member Tabindex = AttrSelector "tabindex"

let private utf8 =
    UTF8Encoding(
        encoderShouldEmitUTF8Identifier = false,
        throwOnInvalidBytes = true
    )


let private escapedSurrogatePair =
    Regex(
        @"\\u([dD][89aAbB][0-9a-fA-F]{2})\\u([dD][c-fC-F][0-9a-fA-F]{2})",
        RegexOptions.Compiled ||| RegexOptions.CultureInvariant
    )


let normalizeEscapedSurrogatePairs (text: string) =
    if text.IndexOf(@"\uD", StringComparison.OrdinalIgnoreCase) < 0 then
        text
    else
        escapedSurrogatePair.Replace(
            text,
            MatchEvaluator(fun matched ->
                let high =
                    Convert.ToInt32(matched.Groups.[1].Value, 16)
                    |> char

                let low =
                    Convert.ToInt32(matched.Groups.[2].Value, 16)
                    |> char

                Char.ConvertToUtf32(high, low)
                |> sprintf "\\U%08X"
            )
        )


let decompressNqGzipFile (nqgzipFile: FileInfo) =

    if not (File.Exists nqgzipFile.FullName) then
        raise (
            FileNotFoundException(
                "The N-Quads gzip file does not exist.",
                nqgzipFile.FullName
            )
        )

    if not (
        nqgzipFile.Name.EndsWith(
            ".nq.gz",
            StringComparison.OrdinalIgnoreCase
        )
    ) then
        invalidArg
            (nameof nqgzipFile)
            $"Expected an .nq.gz file, received {nqgzipFile.Name}."

    // Removes only the final ".gz":
    // foo.nq.gz -> foo.nq
    let nqFile =
        Path.ChangeExtension(nqgzipFile.FullName, null)
        |> FileInfo

    // Do not expose a partially-written "clean" .nq file.
    let temporaryFile =
        Path.Combine(
            nqFile.DirectoryName,
            Path.GetRandomFileName()
        )
        |> FileInfo

    let parser = NQuadsParser()
    let handler = NullHandler()

    let mutable kept = 0L
    let mutable rejected = 0L
    let mutable repaired = 0L

    try
        do
            use sourceStream =
                nqgzipFile.OpenRead()

            use gzipStream =
                new GZipStream(
                    sourceStream,
                    CompressionMode.Decompress
                )

            use reader =
                new StreamReader(
                    gzipStream,
                    utf8,
                    detectEncodingFromByteOrderMarks = true
                )

            use writer =
                new StreamWriter(
                    temporaryFile.FullName,
                    append = false,
                    encoding = utf8
                )

            while not reader.EndOfStream do
                let line =
                    reader.ReadLine()

                if not (String.IsNullOrWhiteSpace line) then
                    let normalizedLine =
                        normalizeEscapedSurrogatePairs line

                    if not (
                        Object.ReferenceEquals(
                            normalizedLine,
                            line
                        )
                    ) && normalizedLine <> line then
                        repaired <- repaired + 1L

                    try
                        use lineReader =
                            new StringReader(normalizedLine)

                        parser.Load(
                            handler,
                            lineReader
                        )

                        writer.WriteLine(normalizedLine)
                        kept <- kept + 1L

                    with
                    | :? RdfParseException ->
                        rejected <- rejected + 1L

        File.Move(
            temporaryFile.FullName,
            nqFile.FullName,
            overwrite = true
        )

        File.Delete(nqgzipFile.FullName)

        printfn
            "Created %s — kept %i statements; repaired %i lines; rejected %i invalid statements."
            nqFile.FullName
            kept
            repaired
            rejected

        FileInfo(nqFile.FullName)

    with
    | _ ->
        if File.Exists temporaryFile.FullName then
            File.Delete temporaryFile.FullName

        reraise()

let decompressGz (sourceFile : FileInfo)  =
    let targetFile = sourceFile.FullName[..sourceFile.FullName.Length-4] |> FileInfo
    // Open the compressed file stream
    use sourceStream = new FileStream(sourceFile.FullName, FileMode.Open, FileAccess.Read)
    
    // Create the decompression stream
    use decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress)
    
    // Create the destination file stream
    use targetStream = new FileStream(targetFile.FullName, FileMode.Create, FileAccess.Write)
    
    // Copy the decompressed data to the target file
    decompressionStream.CopyTo(targetStream)
    targetFile

// Example usage:
// decompressGz "data.json.gz" "data.json"

// Initializers


let namespaceMapper = new NamespaceMapper()

let logLines = new ResizeArray<string>()


let wellKnownGenid = $"https://eristocrates.dev/.well-known/genid"

let xsdInference = XmlSchemaInference()

let clipboard = new Clipboard()
let clip (text:string) = clipboard.SetText text


let responses = new ResizeArray<CdpHttpResponse>()
let finishedRequests = new ResizeArray<CdpHttpRequest>()
let failedRequests = new ResizeArray<CdpHttpRequest>()

module ChromeDevTools = 
    let protocol =  DomUrl "localhost:9222/json/protocol"


let LitXmlWriterSettings = new XmlWriterSettings()
LitXmlWriterSettings.Indent <- true
LitXmlWriterSettings.OmitXmlDeclaration <- true
LitXmlWriterSettings.NewLineOnAttributes <- false

// identifier helpers



type QueryParameter = 
    | ParameterKeyValue of string * string
    | ParameterKeyValues of string * string array
    member this.parameterKey = 
        match this with 
        | ParameterKeyValue (parameterKey, parameterValue)  -> parameterKey
        | ParameterKeyValues (parameterKey, parameterValues)  -> parameterKey
    member this.parameterValue = 
        match this with 
        | ParameterKeyValue (parameterKey, parameterValue)  -> parameterValue
        | ParameterKeyValues (parameterKey, parameterValues)  -> parameterValues[0]
    member this.parameterValues = 
        match this with 
        | ParameterKeyValue (parameterKey, parameterValue)  -> [|parameterValue|]
        | ParameterKeyValues (parameterKey, parameterValues)  -> parameterValues
    member this.ParameterPath = 
        Array.concat [|
            [|this.parameterKey|]
            this.parameterValues
        |]
        |> String.concat "\\"

module Folder = 
    let Scratch = Directory.CreateDirectory @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Scratch"
    let fiboMaster = DirectoryInfo @"D:\Iri\https\spec.edmcouncil.org\fibo\ontology\master"
    let ``spec.edmcouncil.org`` = DirectoryInfo @"D:\Iri\https\spec.edmcouncil.org"
    let Downloads = DirectoryInfo @"C:\Users\CollierB\Downloads"
    let  Iri = Directory.CreateDirectory @"D:\Iri"  
    let  DoxAletheia = Directory.CreateDirectory @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia"   
    let  Vocabulary = Directory.CreateDirectory @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary"   
    let  SolarWinds = Directory.CreateDirectory @"D:\Artifact\Company\SolarWinds"   
    let  NeoGov = Directory.CreateDirectory @"D:\Artifact\Company\NeoGov"   
    let  SunshineHealth = Directory.CreateDirectory @"D:\Artifact\Company\SunshineHealth"   
    let  MicrosoftGraph = Directory.CreateDirectory @"D:\Artifact\Company\MicrosoftGraph"   

type NamedCharacterReference = 
    {
        htmlEntity:string
        codepoints:Rune array
        characters:string
    }
    member this.entityName = this.htmlEntity.TrimStart('&').TrimEnd(';')

module HtmlEntities = 
    module json = 
        let domUrl = DomUrl "https://html.spec.whatwg.org/entities.json"
        [<Literal>]
        let filePath = @"D:\Iri\https\html.spec.whatwg.org\entities.json\bare\entities.json"
        type Provider = JsonProvider< UseOriginalNames = true, PreferDateOnly = true, OmitNullFields = true,
            RootName = "entities",
            Sample =  filePath >
        let content = Provider.Load filePath 


    let namedCharacterReferences = 
        json.content.JsonValue.Properties
        |> Array.map (fun (entityKey, entityValue) -> 
            let codepointsKey, codepointsValue = entityValue.Properties[0]
            let charactersKey, charactersValue = entityValue.Properties[1]
            {
                htmlEntity = entityKey
                codepoints = codepointsValue.AsArray() |> Array.map (fun jsonValue -> Rune(jsonValue.AsInteger()))
                characters = charactersValue.AsString()
            }


        )

    /// Pick exactly one canonical named reference for each single codepoint.
    ///
    /// Preference:
    ///   1. semicolon-terminated references
    ///   2. shortest reference
    ///   3. lexical order as a final deterministic tie-breaker
    let namedCharacterReferenceByCodepoint =
        namedCharacterReferences
        |> Array.filter (fun reference ->
            reference.htmlEntity.EndsWith(";")
            && reference.codepoints.Length = 1
        )
        |> Array.groupBy (fun reference ->
            reference.codepoints[0].Value
        )
        |> Array.map (fun (codepoint, references) ->
            let canonical =
                references
                |> Array.sortBy (fun reference ->
                    reference.htmlEntity.Length,
                    reference.htmlEntity
                )
                |> Array.head

            codepoint, canonical
        )
        |> Map.ofArray

    let characterReference (rune:Rune) =
        match namedCharacterReferenceByCodepoint.TryFind rune.Value with
        | Some reference ->
            reference.htmlEntity

        // Not every Unicode character has an HTML named reference.
        // Numeric character references give us a total fallback.
        | None ->
            $"&#x{rune.Value:X};"
    let invalidPathCharacterReferenceSet = 
                Path.GetInvalidPathChars() |> Array.collect (fun pathChar ->  
                        namedCharacterReferences |> Array.choose (fun namedCharacterReference -> 
                            if namedCharacterReference.codepoints = [| Rune pathChar |] then 
                                Some namedCharacterReference
                            else 
                                None
                        
                            )
                )
                |> Set.ofArray
    let invalidFileNameCharacterReferenceSet = 
                Path.GetInvalidFileNameChars () |> Array.collect (fun fileNameChar ->  
                        namedCharacterReferences |> Array.choose (fun namedCharacterReference -> 
                            if namedCharacterReference.codepoints = [| Rune fileNameChar |] then 
                                Some namedCharacterReference
                            else 
                                None
                        
                            )
                )
                |> Set.ofArray



    let namedCharacterReferenceByString = 
        namedCharacterReferences
        |> Array.map (fun namedCharacterReference -> namedCharacterReference.characters, namedCharacterReference)
        |> Map.ofArray




    


module PathName =

    let private invalidChars =
        Path.GetInvalidFileNameChars()
        |> Set.ofArray

    let makeAcceptable (value:string) =
        value
        |> String.collect (fun character ->
            if invalidChars.Contains character then
                match HtmlEntityProvider.ReverseResolver.GetName(string character) with
                | null ->
                    $"&#x{int character:X};"
                | name ->
                    $"&{name}"
            else
                string character
        )





type DomUrl with 
    member this.ConcatFragment (fragment:string) =
        let href = 
            if String.IsNullOrWhiteSpace(this.Search) then 
                $"{this.Origin}/{this.AbsolutePathName}{this.Hash}/{fragment}"
            else
                $"{this.Origin}/{this.AbsolutePathName}{this.Hash}/{fragment}?{this.Search}"
        DomUrl href

    member this.AppendFragmentPath (fragment:string) = 
        let href = 
            if String.IsNullOrWhiteSpace(this.Search) then 
                $"{this.Origin}/{this.AbsolutePathName}#/{fragment}"
            else
                $"{this.Origin}/{this.AbsolutePathName}#/{fragment}?{this.Search}"
        DomUrl href
    member this.AppendFragment (fragment:string) = 
        let href = 
            if String.IsNullOrWhiteSpace(this.Search) then 
                $"{this.Origin}/{this.AbsolutePathName}#{fragment}"
            else
                $"{this.Origin}/{this.AbsolutePathName}#{fragment}?{this.Search}"
        DomUrl href
    member this.asString = this.ToString()

    member this.QueryStringParameters = 
        QueryStringUtilities.ParseQuery this.Search
            |> Seq.map (fun keyValue ->  
                match keyValue.Key, keyValue.Value |> Seq.toArray with 
                | parameterKey, [|parameterValue|] -> ParameterKeyValue(parameterKey, parameterValue)
                | parameterKey, parameterValues -> ParameterKeyValues(parameterKey, parameterValues)
                )
            |> Seq.toArray
            |> Array.sortBy (fun parameter -> parameter.parameterKey)
    member this.AppendSegments (segments:string array) = sprintf "%s/%s" (this.Origin + this.Pathname.TrimEnd('/')) ((segments |> String.concat "/").TrimStart('/'))   |> DomUrl 
        
    member this.AppendPath (path:string) = this.AppendSegments [| path |]

    member this.AbsolutePathName = this.Pathname[1..]
    member this.QueryPathName = this.QueryStringParameters |> Array.map  (fun parameter -> parameter.ParameterPath) |> String.concat "\\"
    member this.terminalName = 
        match this.Href.ToCharArray() |> Array.last with 
        | '#' -> "hash"
        | '/' -> "slash"
        | _ -> "bare"

    member this.HashTerminated = this.Href + "#" |> DomUrl
    member this.SlashTerminated = this.Href + "/" |> DomUrl
    member this.extension = Path.GetExtension this.AbsolutePathName
    member this.pathStem = Path.GetFileNameWithoutExtension this.AbsolutePathName

    member this.protocolPathPart =
        this.Protocol.TrimEnd ':'
        |> PathName.makeAcceptable

    member this.hostPathPart =
        this.Host
        |> PathName.makeAcceptable

    member this.pathSegments =
        this.Pathname.Split(
            '/',
            StringSplitOptions.RemoveEmptyEntries
        )

    member this.directorySegments =
        if this.pathSegments.Length <= 1 then
            [||]
        else
            this.pathSegments[..this.pathSegments.Length - 2]
            |> Array.map PathName.makeAcceptable

    member this.originalFileName =
        if this.pathSegments.Length = 0 then
            invalidArg
                "DomUrl"
                $"URL has no file-name component: {this.Href}"

        this.pathSegments[this.pathSegments.Length - 1]
        |> PathName.makeAcceptable

    member this.fileExtension =
        Path.GetExtension this.originalFileName

    member this.fileStem =
        Path.GetFileNameWithoutExtension this.originalFileName

    member this.queryPathPart =
        if this.Search <> "" then
            this.Search
            |> PathName.makeAcceptable
        elif this.Href.Contains "?" then
            "&quest;"
        else
            ""

    member this.fragmentPathPart =
        if this.Hash <> "" then
            "&num;"
            + (
                this.Hash.TrimStart '#'
                |> PathName.makeAcceptable
            )
        elif this.Href.EndsWith "#" then
            "&num;"
        else
            ""

    member this.fileName =
        this.fileStem
        + this.queryPathPart
        + this.fragmentPathPart
        + this.fileExtension

    member this.fileDirectory =
        Array.concat [
            [|
                this.protocolPathPart
                this.hostPathPart
            |]
            this.directorySegments
        ]
        |> Array.fold
            (fun path segment ->
                Path.Combine(path, segment)
            )
            Folder.Iri.FullName
        |> Directory.CreateDirectory

    member this.asFile =
        Path.Combine(
            this.fileDirectory.FullName,
            this.fileName
        )
        |> FileInfo
    member this.asFileExtension(extension:string) =
        Path.Combine(
            this.fileDirectory.FullName,
            Path.ChangeExtension(this.fileName, extension)
        )
        |> FileInfo
    member this.CreateFileDirectory() = Directory.CreateDirectory this.asFile.DirectoryName  |> ignore
    member this.WriteFileText (text:string) = 
        this.CreateFileDirectory()
        File.WriteAllText(this.asFile.FullName, text)
    member this.WriteFileLines (lines:string array) = 
        this.CreateFileDirectory() 
        File.WriteAllLines(this.asFile.FullName, lines)
    member this.HeadlessDownloadFile() = 
        this.CreateFileDirectory()
        http {
            GET this.Href
        }
        |> Request.send
        |> Response.saveFile this.asFile.FullName
    member this.HeadlessDownloadFileExtension(extension:string) = 
        this.CreateFileDirectory()
        http {
            GET this.Href
        }
        |> Request.send
        |> Response.saveFile (Path.ChangeExtension(this.asFile.FullName, extension))
    member this.MimeType = MimeType.FromFileName this.asFile.FullName
    member this.asFolder =

        let href = this.Href

        let protocol =
            this.Protocol.TrimEnd ':'
            |> PathName.makeAcceptable

        let host =
            this.Host
            |> PathName.makeAcceptable

        let path =
            this.Pathname
                .TrimEnd('/')
                .Split('/', StringSplitOptions.RemoveEmptyEntries)
            |> Array.map PathName.makeAcceptable

        let terminal =
            if href.EndsWith("#") then
                "&num;"
            elif this.Pathname.EndsWith("/") then
                "&sol;"
            else
                "bare"

        Array.concat [
            [| protocol; host |]
            path
            [| terminal |]
        ]
        |> Array.fold
            (fun currentPath segment ->
                Path.Combine(currentPath, segment)
            )
            Folder.Iri.FullName
        |> Directory.CreateDirectory






type ResourceReference = 
    | LocalFolder of DirectoryInfo
    | LocalFile of FileInfo
    | RemoteFolder of DomUrl
    | RemoteFile of DomUrl
    member this.asString = 
        match this with 
        | LocalFolder directoryInfo -> directoryInfo.FullName
        | LocalFile fileInfo -> fileInfo.FullName
        | RemoteFolder domUrl -> domUrl.Href
        | RemoteFile domUrl -> domUrl.Href





type String with 
    member this.runes = this.Normalize().EnumerateRunes() |> Seq.toArray

type Guid with 
    member this.asString = this.ToString("N")
    member this.asHyphenatedString = this.ToString("D")
    member this.asHyphenatedBracedString = this.ToString("B")
    member this.asHyphenatedParenthesizedString = this.ToString("P")
    member this.asHexString = this.ToString("X")
type PhoneNumber with 
    static member Parse(numberString:string) = PhoneNumberUtil.GetInstance().Parse(numberString, "US")



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
              "fori"
              "params"

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

    static member NormalizeCharacters(identifier: string) =
        let sb = System.Text.StringBuilder()

        for character in identifier do
            match character with
            | '#'
            | ':'
            | ','
            | '?'
            | '('
            | ')' ->
                ()

            | '&' ->
                sb.Append("and") |> ignore

            | '/'
            | '-'
            | ' ' ->
                sb.Append('_') |> ignore

            | c when Char.IsWhiteSpace c ->
                sb.Append('_') |> ignore

            | c ->
                sb.Append(c) |> ignore

        sb.ToString()
    static member NormalizeFirstCharacter(identifier: string) =
        match identifier with
        | "" ->
            "_"

        | identifier
            when Syntax.PrettyNaming.IsIdentifierFirstCharacter identifier[0] ->
            identifier

        | identifier ->
            "_" + identifier
    static member NormalizeKeyword(identifier: string) =
        if Binder.KeywordNames.Contains identifier then
            identifier + "_"
        else
            identifier
    member this.binding = this.identifier |> Binder.NormalizeFirstCharacter |> Binder.NormalizeCharacters |> Binder.NormalizeKeyword |> Syntax.PrettyNaming.NormalizeIdentifierBackticks

// xml  helpers

type LitXml.ElementBuilder with 
    
    static member writeToXmlDocs (elements:LitXml.Element array) :string array= 

        elements
        |> Array.collect (fun element -> LitXml.ElementBuilder.writeToStringWith LitXmlWriterSettings element |> _.Split("\n"))



module XmlComment = 
    open LitXml
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


// Rdf Helpers



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








type FileInfo with 
    member this.stem = Path.GetFileNameWithoutExtension this.Name
    member this.stemPath =  Path.Combine(this.DirectoryName,this.stem)


































































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
  member this.asIri = PrefixedIri this.asPrefixedName

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
  member this.namespaceUrl = DomUrl this.namespaceName
  member this.namespaceUri = Uri this.namespaceName
  member this.directory = this.namespaceUrl.asFolder
  member this.asFileExtension (dotExtension:string) = 

        let mimeType = MimeType.FromFileName(dotExtension)
        Path.Combine (this.namespaceUrl.asFolder.FullName, mimeType.MediaType, $"{mimeType.SubType}{dotExtension}") |> FileInfo
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
                uuid = Guid.NewGuid()
                identifier = variableNode.VariableName
                bindingCell = Adaptive.cval (None:Point option)
            }
    static member fromIdentifier (identifier:string) = 
            {
                uuid = Guid.NewGuid()
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

















// ============================================================================
// Result access
// ============================================================================
type SparqlResultSet with 

    member this.columnByVariables(rdfVariable: RdfVariable) =
        this.Results
        |> Seq.map (fun result ->
            result.Item rdfVariable.identifier
            |> Point.fromINode)
        |> Seq.toArray
module SparqlResultSet =

    let variableIndex (rdfVariable: RdfVariable)(index:int)( resultSet: SparqlResultSet) =
        resultSet.Results
        |> Seq.map (fun result ->
            result.Item rdfVariable.identifier
            |> Point.fromINode)
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

    let basic (formula: Formula) =
        BasicGraphPattern formula


    let group (patterns: SparqlGraphPattern seq) =
        patterns
        |> Seq.toArray
        |> GroupGraphPattern


    let optional (pattern: SparqlGraphPattern) =
        OptionalGraphPattern pattern


    let union (patterns: SparqlGraphPattern seq) =

        let patterns =
            patterns
            |> Seq.toArray

        if patterns.Length < 2 then
            invalidArg
                (nameof patterns)
                "A SPARQL UNION requires at least two graph patterns."

        UnionGraphPattern patterns


    let minus (pattern: SparqlGraphPattern) =
        MinusGraphPattern pattern


    let graph
        (graphIri: Iri)
        (pattern: SparqlGraphPattern)
        =
        NamedGraphPattern(
            GraphIri graphIri,
            pattern
        )


    let graphVariable
        (graphVariable: RdfVariable)
        (pattern: SparqlGraphPattern)
        =
        NamedGraphPattern(
            GraphVariable graphVariable,
            pattern
        )


    let service
        (endpoint: Iri)
        (pattern: SparqlGraphPattern)
        =
        ServiceGraphPattern(
            endpoint,
            pattern
        )


    let filter
        (expression: ISparqlExpression)
        =
        FilterGraphPattern expression


    let bind
        (rdfVariable: RdfVariable)
        (expression: ISparqlExpression)
        =
        BindGraphPattern(
            rdfVariable,
            expression
        )


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
    | From of Iri
    | FromNamed of Iri


// ============================================================================
// Strongly typed query values
//
// Building a query no longer executes it.
//
// The query form determines the result type without routing everything through
// obj.
// ============================================================================

type SelectQuery =
    {
        selectQuery: SparqlQuery
    }

    member this.asSparqlQuery =
        this.selectQuery

    member this.text =
        this.selectQuery.ToString()


type AskQuery =
    {
        askQuery: SparqlQuery
    }

    member this.asSparqlQuery =
        this.askQuery

    member this.text =
        this.askQuery.ToString()


type GraphQuery =
    {
        graphQuery: SparqlQuery
    }

    member this.asSparqlQuery =
        this.graphQuery

    member this.text =
        this.graphQuery.ToString()


// ============================================================================
// Low-level dotNetRDF query-form adapters
// ============================================================================

let private SELECTALL () : ISelectBuilder =
    QueryBuilder.SelectAll()


let private SELECT
    (variables: RdfVariable seq)
    : ISelectBuilder
    =

    variables
    |> Seq.map (fun variable ->
        variable.identifier)
    |> Seq.toArray
    |> QueryBuilder.Select


let private ASK () : IQueryBuilder =
    QueryBuilder.Ask()


let private DISCOVER
    (variables: RdfVariable seq)
    : IDescribeBuilder
    =

    variables
    |> Seq.map (fun variable ->
        variable.questionForm)
    |> Seq.toArray
    |> QueryBuilder.Describe


let private DESCRIBE
    (iris: Iri seq)
    : SparqlQuery
    =

    iris
    |> Seq.map (fun iri ->
        iri.asUri)
    |> Seq.toArray
    |> QueryBuilder.Describe
    |> fun builder ->
        builder.BuildQuery()


// ============================================================================
// DESCRIBE variable repair
//
// Retained from the previous implementation because the surrounding code
// already depended upon this behavior.
// ============================================================================

let private repairDescribeVariables
    (sparqlQuery: SparqlQuery)
    : SparqlQuery
    =

    if sparqlQuery.QueryType = SparqlQueryType.Describe then

        let queryVariables =
            sparqlQuery.Variables
            :?> System.Collections.Generic.ICollection<SparqlVariable>

        sparqlQuery.DescribeVariables
        |> Seq.filter (fun token ->
            token.TokenType = Token.VARIABLE)
        |> Seq.iter (fun token ->

            let variableName =
                token.Value.Substring(1)

            let alreadyRegistered =
                queryVariables
                |> Seq.exists (fun variable ->
                    variable.Name = variableName)

            if not alreadyRegistered then
                queryVariables.Add(
                    SparqlVariable(
                        variableName,
                        true
                    )
                )
        )

    sparqlQuery


// ============================================================================
// Prefix handling
//
// Query construction must not require an execution graph merely to obtain a
// NamespaceMap. The existing global namespaceMapper is therefore imported into
// each query builder.
// ============================================================================

let private importQueryPrefixes
    (queryBuilder: IQueryBuilder)
    : IQueryBuilder
    =

    queryBuilder.Prefixes.Import namespaceMapper

    queryBuilder


// ============================================================================
// Graph-pattern lowering
//
// Converts the F# SparqlGraphPattern representation into dotNetRDF's
// GraphPatternBuilder representation.
// ============================================================================

let rec private applyGraphPattern
    (patternBuilder: TriplePatternBuilder)
    (builder: IGraphPatternBuilder)
    (graphPattern: SparqlGraphPattern)
    : unit
    =

    let action
        (pattern: SparqlGraphPattern)
        =
        Action<IGraphPatternBuilder>(
            fun childBuilder ->
                applyGraphPattern
                    patternBuilder
                    childBuilder
                    pattern
        )

    match graphPattern with

    | BasicGraphPattern formula ->

        builder.Where(
            patternBuilder
            |> formula.ITriplePatterns
        )
        |> ignore


    | GroupGraphPattern patterns ->

        builder.Group(
            Action<IGraphPatternBuilder>(
                fun groupBuilder ->

                    patterns
                    |> Array.iter (
                        applyGraphPattern
                            patternBuilder
                            groupBuilder
                    )
            )
        )
        |> ignore


    | OptionalGraphPattern pattern ->

        builder.Optional(
            action pattern
        )
        |> ignore


    | UnionGraphPattern patterns ->

        if patterns.Length < 2 then
            invalidOp
                "A SPARQL UNION requires at least two graph patterns."

        let actions =
            patterns
            |> Array.map action

        builder.Union(
            actions[0],
            actions[1..]
        )
        |> ignore


    | MinusGraphPattern pattern ->

        builder.Minus(
            action pattern
        )
        |> ignore


    | NamedGraphPattern(
        GraphIri graphIri,
        pattern
      ) ->

        builder.Graph(
            graphIri.asUri,
            action pattern
        )
        |> ignore


    | NamedGraphPattern(
        GraphVariable graphVariable,
        pattern
      ) ->

        builder.Graph(
            graphVariable.questionForm,
            action pattern
        )
        |> ignore


    | ServiceGraphPattern(
        endpoint,
        pattern
      ) ->

        builder.Service(
            endpoint.asUri,
            action pattern
        )
        |> ignore


    | FilterGraphPattern expression ->

        builder.Filter(
            expression
        )
        |> ignore


    | BindGraphPattern(
        rdfVariable,
        expression
      ) ->

        builder.Where(
            BindPattern(
                rdfVariable.identifier,
                expression
            )
            :> ITriplePattern
        )
        |> ignore


let private applyWherePattern
    (queryBuilder: IQueryBuilder)
    (wherePattern: SparqlGraphPattern)
    : IQueryBuilder
    =

    let patternBuilder =
        TriplePatternBuilder(
            queryBuilder.Prefixes
        )

    applyGraphPattern
        patternBuilder
        queryBuilder.Root
        wherePattern

    queryBuilder


// ============================================================================
// Query-level RDF dataset lowering
//
// These become literal SPARQL FROM / FROM NAMED clauses on SparqlQuery.
// ============================================================================

let private applyDatasetClauses
    (datasetClauses: SparqlDatasetClause array)
    (sparqlQuery: SparqlQuery)
    : SparqlQuery
    =

    datasetClauses
    |> Array.iter (
        function

        | From graphIri ->

            sparqlQuery.AddDefaultGraph(
                graphIri.asUriNode
                :> IRefNode
            )


        | FromNamed graphIri ->

            sparqlQuery.AddNamedGraph(
                graphIri.asUriNode
                :> IRefNode
            )
    )

    sparqlQuery


// ============================================================================
// Typed query compilers
// ============================================================================

let private buildSelectQuery
    (variables: RdfVariable array option)
    (datasetClauses: SparqlDatasetClause array)
    (wherePattern: SparqlGraphPattern)
    : SelectQuery
    =

    let queryBuilder : IQueryBuilder =

        match variables with

        | Some variables ->
            SELECT variables
            :> IQueryBuilder

        | None ->
            SELECTALL()
            :> IQueryBuilder


    let query =

        queryBuilder
        |> importQueryPrefixes
        |> fun builder ->
            applyWherePattern
                builder
                wherePattern
        |> fun builder ->
            builder.BuildQuery()
        |> applyDatasetClauses datasetClauses


    {
        selectQuery = query
    }


let private buildAskQuery
    (datasetClauses: SparqlDatasetClause array)
    (wherePattern: SparqlGraphPattern)
    : AskQuery
    =

    let query =

        ASK()
        |> importQueryPrefixes
        |> fun builder ->
            applyWherePattern
                builder
                wherePattern
        |> fun builder ->
            builder.BuildQuery()
        |> applyDatasetClauses datasetClauses


    {
        askQuery = query
    }


let private buildConstructQuery
    (constructFormula: Formula)
    (datasetClauses: SparqlDatasetClause array)
    (wherePattern: SparqlGraphPattern)
    : GraphQuery
    =

    let queryBuilder =

        QueryBuilder.Construct(
            Action<IDescribeGraphPatternBuilder>(
                fun constructTemplate ->

                    let templatePatternBuilder =
                        TriplePatternBuilder(
                            namespaceMapper
                        )

                    constructTemplate.Where(
                        templatePatternBuilder
                        |> constructFormula.ITriplePatterns
                    )
                    |> ignore
            )
        )


    let query =

        queryBuilder
        |> importQueryPrefixes
        |> fun builder ->
            applyWherePattern
                builder
                wherePattern
        |> fun builder ->
            builder.BuildQuery()
        |> applyDatasetClauses datasetClauses


    {
        graphQuery = query
    }


let private buildDiscoverQuery
    (variables: RdfVariable array)
    (datasetClauses: SparqlDatasetClause array)
    (wherePattern: SparqlGraphPattern)
    : GraphQuery
    =

    let queryBuilder =

        DISCOVER variables
        :> IQueryBuilder


    let query =

        queryBuilder
        |> importQueryPrefixes
        |> fun builder ->
            applyWherePattern
                builder
                wherePattern
        |> fun builder ->
            builder.BuildQuery()
        |> repairDescribeVariables
        |> applyDatasetClauses datasetClauses


    {
        graphQuery = query
    }


let private buildDescribeQuery
    (iris: Iri array)
    : GraphQuery
    =

    let query =

        iris
        |> DESCRIBE

    query.NamespaceMap.Import namespaceMapper

    {
        graphQuery = query
    }


// ============================================================================
// Query computation-expression state
// ============================================================================

type SparqlQueryDraft =
    {
        datasetClauses:
            SparqlDatasetClause list

        wherePattern:
            SparqlGraphPattern option
    }


let private emptySparqlQueryDraft =
    {
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

type WhereQueryBuilder<'Query>
    (
        build:
            SparqlQueryDraft
                -> SparqlGraphPattern
                -> 'Query
    )
    =


    member _.Yield(_: unit)
        : SparqlQueryDraft
        =
        emptySparqlQueryDraft


    member _.Zero()
        : SparqlQueryDraft
        =
        emptySparqlQueryDraft


    member _.For
        (
            _draft: SparqlQueryDraft,
            continuation:
                unit -> SparqlQueryDraft
        )
        : SparqlQueryDraft
        =
        continuation()


    [<CustomOperation("from")>]
    member _.From
        (
            draft: SparqlQueryDraft,
            graphIri: Iri
        )
        : SparqlQueryDraft
        =

        {
            draft with

                datasetClauses =
                    From graphIri
                    :: draft.datasetClauses
        }


    [<CustomOperation("fromNamed")>]
    member _.FromNamed
        (
            draft: SparqlQueryDraft,
            graphIri: Iri
        )
        : SparqlQueryDraft
        =

        {
            draft with

                datasetClauses =
                    FromNamed graphIri
                    :: draft.datasetClauses
        }


    // Compatibility/convenience form:
    //
    //     where formula
    //
    // A Formula becomes a basic graph pattern.

    [<CustomOperation("where")>]
    member _.Where
        (
            draft: SparqlQueryDraft,
            formula: Formula
        )
        : SparqlQueryDraft
        =

        match draft.wherePattern with

        | Some _ ->

            invalidOp
                "The query already contains a WHERE graph pattern."


        | None ->

            {
                draft with

                    wherePattern =
                        Some(
                            BasicGraphPattern formula
                        )
            }


    // Full graph-pattern form:
    //
    //     wherePattern pattern
    //
    // This is used for GRAPH, OPTIONAL, UNION, MINUS, SERVICE, FILTER, BIND,
    // nested groups, etc.

    [<CustomOperation("wherePattern")>]
    member _.WherePattern
        (
            draft: SparqlQueryDraft,
            graphPattern: SparqlGraphPattern
        )
        : SparqlQueryDraft
        =

        match draft.wherePattern with

        | Some _ ->

            invalidOp
                "The query already contains a WHERE graph pattern."


        | None ->

            {
                draft with

                    wherePattern =
                        Some graphPattern
            }


    member _.Run
        (
            draft: SparqlQueryDraft
        )
        : 'Query
        =

        let wherePattern =

            match draft.wherePattern with

            | Some wherePattern ->
                wherePattern

            | None ->
                invalidOp
                    "The query requires a WHERE graph pattern."


        let normalizedDraft =

            {
                draft with

                    datasetClauses =
                        draft.datasetClauses
                        |> List.rev
            }


        build
            normalizedDraft
            wherePattern


// ============================================================================
// Public SPARQL query-authoring surface
//
// These BUILD query values. They do not execute.
// ============================================================================

module sparql =


    let select
        (variables: RdfVariable seq)
        : WhereQueryBuilder<SelectQuery>
        =

        let variables =
            variables
            |> Seq.toArray

        WhereQueryBuilder<SelectQuery>(
            fun draft wherePattern ->

                buildSelectQuery
                    (Some variables)
                    (
                        draft.datasetClauses
                        |> List.toArray
                    )
                    wherePattern
        )


    let selectAll
        : WhereQueryBuilder<SelectQuery>
        =

        WhereQueryBuilder<SelectQuery>(
            fun draft wherePattern ->

                buildSelectQuery
                    None
                    (
                        draft.datasetClauses
                        |> List.toArray
                    )
                    wherePattern
        )


    let construct
        (constructFormula: Formula)
        : WhereQueryBuilder<GraphQuery>
        =

        WhereQueryBuilder<GraphQuery>(
            fun draft wherePattern ->

                buildConstructQuery
                    constructFormula
                    (
                        draft.datasetClauses
                        |> List.toArray
                    )
                    wherePattern
        )


    let ask
        : WhereQueryBuilder<AskQuery>
        =

        WhereQueryBuilder<AskQuery>(
            fun draft wherePattern ->

                buildAskQuery
                    (
                        draft.datasetClauses
                        |> List.toArray
                    )
                    wherePattern
        )


    // "discover" remains your convenience name for:
    //
    //     DESCRIBE ?variable ...
    //     WHERE { ... }

    let discover
        (variables: RdfVariable seq)
        : WhereQueryBuilder<GraphQuery>
        =

        let variables =
            variables
            |> Seq.toArray

        WhereQueryBuilder<GraphQuery>(
            fun draft wherePattern ->

                buildDiscoverQuery
                    variables
                    (
                        draft.datasetClauses
                        |> List.toArray
                    )
                    wherePattern
        )


    // DESCRIBE of concrete IRIs does not require a WHERE clause and therefore
    // remains a direct function rather than a WhereQueryBuilder.

    let describe
        (iris: Iri seq)
        : GraphQuery
        =

        iris
        |> Seq.toArray
        |> buildDescribeQuery


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

type SparqlProtocolDataset =
    {
        defaultGraphs:
            Iri array

        namedGraphs:
            Iri array
    }

    static member Empty =
        {
            defaultGraphs = [||]

            namedGraphs = [||]
        }


// ============================================================================
// Remote SPARQL endpoint
//
// This is the remote execution substrate.
// It is NOT part of the query AST.
// ============================================================================

type SparqlRemoteEndpoint =
    {
        httpClient:
            HttpClient

        endpointUri:
            Uri

        protocolDataset:
            SparqlProtocolDataset
    }


    static member fromUri
        (
            httpClient: HttpClient,
            endpointUri: Uri
        )
        =

        {
            httpClient = httpClient

            endpointUri = endpointUri

            protocolDataset =
                SparqlProtocolDataset.Empty
        }


    static member fromString
        (
            httpClient: HttpClient,
            endpointUri: string
        )
        =

        SparqlRemoteEndpoint.fromUri(
            httpClient,
            Uri endpointUri
        )


    static member fromIri
        (
            httpClient: HttpClient,
            endpointIri: Iri
        )
        =

        SparqlRemoteEndpoint.fromUri(
            httpClient,
            endpointIri.asUri
        )
    static member fromUrl
        (
            httpClient: HttpClient,
            endpointUrl: DomUrl
        )
        =

        SparqlRemoteEndpoint.fromUri(
            httpClient,
            Uri endpointUrl.Href
        )


    member this.withDefaultGraph
        (
            graphIri: Iri
        )
        =

        {
            this with

                protocolDataset =
                    {
                        this.protocolDataset with

                            defaultGraphs =
                                Array.append
                                    this.protocolDataset.defaultGraphs
                                    [| graphIri |]
                    }
        }


    member this.withNamedGraph
        (
            graphIri: Iri
        )
        =

        {
            this with

                protocolDataset =
                    {
                        this.protocolDataset with

                            namedGraphs =
                                Array.append
                                    this.protocolDataset.namedGraphs
                                    [| graphIri |]
                    }
        }


    member private this.createClient() =

        let client =
            SparqlQueryClient(
                this.httpClient,
                this.endpointUri
            )


        this.protocolDataset.defaultGraphs
        |> Array.iter (fun graphIri ->

            client.DefaultGraphs.Add(
                graphIri.lexicalForm
            )
        )


        this.protocolDataset.namedGraphs
        |> Array.iter (fun graphIri ->

            client.NamedGraphs.Add(
                graphIri.lexicalForm
            )
        )


        client


    member this.query
        (
            selectQuery: SelectQuery,
            ?cancellationToken: CancellationToken
        )
        : Task<SparqlResultSet>
        =

        let cancellationToken =
            defaultArg
                cancellationToken
                CancellationToken.None

        let client =
            this.createClient()

        client.QueryWithResultSetAsync(
            selectQuery.text,
            cancellationToken
        )


    member this.query
        (
            askQuery: AskQuery,
            ?cancellationToken: CancellationToken
        )
        : Task<bool>
        =

        task {

            let cancellationToken =
                defaultArg
                    cancellationToken
                    CancellationToken.None

            let client =
                this.createClient()

            let! resultSet =
                client.QueryWithResultSetAsync(
                    askQuery.text,
                    cancellationToken
                )

            return resultSet.Result
        }


    member this.query
        (
            graphQuery: GraphQuery,
            ?cancellationToken: CancellationToken
        )
        : Task<IGraph>
        =

        let cancellationToken =
            defaultArg
                cancellationToken
                CancellationToken.None

        let client =
            this.createClient()

        client.QueryWithResultGraphAsync(
            graphQuery.text,
            cancellationToken
        )


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

type SparqlLocalDataset =
    {
        dataset:
            ISparqlDataset
    }


    static member fromDataset
        (
            dataset: ISparqlDataset
        )
        =

        {
            dataset = dataset
        }


    static member fromGraph
        (
            graph: IGraph
        )
        =

        {
            dataset =
                new InMemoryDataset(graph)
                :> ISparqlDataset
        }


    static member fromStore
        (
            store: IInMemoryQueryableStore
        )
        =

        {
            dataset =
                new InMemoryDataset(store)
                :> ISparqlDataset
        }


    member private this.processQuery
        (
            query: SparqlQuery
        )
        =

        let processor =
            new LeviathanQueryProcessor(
                this.dataset
            )

        processor.ProcessQuery(
            query
        )


    member this.query
        (
            selectQuery: SelectQuery
        )
        : SparqlResultSet
        =

        this.processQuery(
            selectQuery.asSparqlQuery
        )
        :?> SparqlResultSet


    member this.query
        (
            askQuery: AskQuery
        )
        : bool
        =

        let resultSet =

            this.processQuery(
                askQuery.asSparqlQuery
            )
            :?> SparqlResultSet

        resultSet.Result


    member this.query
        (
            graphQuery: GraphQuery
        )
        : IGraph
        =

        this.processQuery(
            graphQuery.asSparqlQuery
        )
        :?> IGraph






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


module Turtle =
    let syntax =
        { syntaxName = "Turtle"
          fileExtension = ".ttl" }


    let isValidPrefixedNameRelaxed (s: string) =
        if s.Contains(".") then
            true
        else
            TurtleSpecsHelper.IsValidQName(s)

    let percentEncodeCharUtf8 (ch: char) =
        Encoding.UTF8.GetBytes([| ch |])
        |> Seq.map (fun b -> "%" + b.ToString("X2"))
        |> String.concat ""

    let isForbiddenInTurtleIriRef (ch: char) =
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

    let escapeIriRefByPercentEncoding (iri: string) =
        let sb = System.Text.StringBuilder(iri.Length)

        for ch in iri do
            if isForbiddenInTurtleIriRef ch then
                sb.Append(percentEncodeCharUtf8 ch) |> ignore
            else
                sb.Append(ch) |> ignore

        sb.ToString()

    let formatIriRefFromOriginalString (uri: Uri) =
        "<"
        + escapeIriRefByPercentEncoding uri.OriginalString
        + ">"

    let isAsciiSafeLocal (local: string) =
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

    let isValidLocalName (local: string) =
        if String.IsNullOrEmpty(local) then
            false
        elif local.Contains("/") then
            false
        else
            TurtleSpecsHelper.IsValidQName("p:" + local)
            || isAsciiSafeLocal local

    let tryReduceToPrefixOnly (nsMap: INamespaceMapper) (uriOriginal: string) =
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

    let tryReduceToPrefixedNameLongest (nsMap: INamespaceMapper) (uriOriginal: string) : string option =
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

    let tryReduceToPrefixedName (nsMap: INamespaceMapper) (uriOriginal: string) =
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

    let writeAllPrefixes (tw: TextWriter) (g: IGraph) =
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



let distributionMap = 
    [|

                    "http://purl.org/vocab/vann/", "http://purl.org/vocab/vann/vann-vocab-20100607.rdf"
                    "http://rdfs.org/ns/void#", "https://lov.linkeddata.es/generated/widoco/void-1788068093928-33605f87/ontology.ttl"
                    "http://purl.org/vocommons/voaf#", "https://lov.linkeddata.es/generated/widoco/voaf-1788235281178-42d2c623/ontology.ttl"
                    "http://www.linkedmodel.org/schema/vaem#", "http://www.linkedmodel.org/1.2/schema/OSG_vaem-(v1.2).ttl"
        
    |]
    |> Map.ofArray




type RdfDatasetDocument = 
    {
    datasetFile: FileInfo
    }
    member this.asTripleStore = 
        let tripleStore = new TripleStore()
        FileLoader.Load(tripleStore, this.datasetFile.FullName)
        // TODO figure out how to get namespacemap of all graphs
        // namespaceMapper.Import tripleStore.NamespaceMap
        tripleStore
    member this.asInMemoryQuadDataset = 
        new InMemoryQuadDataset(this.asTripleStore)
    member this.asSparqlLocalDataset = SparqlLocalDataset.fromDataset this.asInMemoryQuadDataset






type RdfGraphDocument = 
  {
    graphFile: FileInfo
  }
  static member fromTurtleVocabulary (prefixId:PrefixId) = { graphFile = prefixId.asFileExtension ".ttl" }
  member this.asIGraph :IGraph = 
        let igraph = new ThreadSafeGraph()
        FileLoader.Load(igraph,this.graphFile.FullName)
        namespaceMapper.Import igraph.NamespaceMap
        igraph
  member this.asOntologyGraph = 
        let ontologyGraph = new OntologyGraph()
        FileLoader.Load(ontologyGraph,this.graphFile.FullName)
        namespaceMapper.Import ontologyGraph.NamespaceMap
        ontologyGraph
  member this.asSparqlLocalDataset = SparqlLocalDataset.fromGraph this.asIGraph

  member this.asRDFGraph = RDFGraph.FromFile(RDFModelEnums.RDFFormats.Turtle, this.graphFile.FullName)
  // member this.asOWLOntology = task { return! OWLOntology.FromRDFGraphAsync this.asRDFGraph } |> Async.AwaitTask |> Async.RunSynchronously
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


type RdfVocabulary = 
    {
        prefixId : PrefixId
        namespaceDocument : RdfGraphDocument
    }
    
    member inline this.maybeOntologyClass<'Term when 'Term : (member asINode:INode)> (term:'Term) =  this.namespaceDocument.asOntologyGraph.AllClasses |> Seq.tryFind (fun ontologyClass -> ontologyClass.Resource = term.asINode )
    member inline this.maybeOntologyProperty<'Term when 'Term : (member asINode:INode)> (term:'Term) =  this.namespaceDocument.asOntologyGraph.AllProperties |> Seq.tryFind (fun ontologyProperty -> ontologyProperty.Resource = term.asINode )
    member this.OntologyClasses = this.namespaceDocument.asOntologyGraph.AllClasses |> Seq.toArray
    member this.OntologyProperties = this.namespaceDocument.asOntologyGraph.AllProperties |> Seq.toArray
    member this.RdfClasses = this.namespaceDocument.asOntologyGraph.RdfClasses |> Seq.toArray
    member this.RdfProperties = this.namespaceDocument.asOntologyGraph.RdfProperties |> Seq.toArray
    member this.OwlClasses = this.namespaceDocument.asOntologyGraph.OwlClasses |> Seq.toArray
    member this.OwlProperties = this.namespaceDocument.asOntologyGraph.OwlProperties |> Seq.toArray
    member this.OwlDatatypeProperties = this.namespaceDocument.asOntologyGraph.OwlDatatypeProperties |> Seq.toArray
    member this.OwlObjectProperties = this.namespaceDocument.asOntologyGraph.OwlObjectProperties |> Seq.toArray
    member this.OwlAnnotationProperties = this.namespaceDocument.asOntologyGraph.OwlAnnotationProperties |> Seq.toArray
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


    member inline this.ontologyClassesByMetaClass<'Term when 'Term : (member asINode:INode)> (metaClass:'Term) = this.namespaceDocument.asOntologyGraph.GetClasses metaClass.asINode |> Seq.toArray
    member this.namespacedNames = this.namespaceDocument.namespacedNames this.prefixId
    member this.termByName = 
        this.namespacedNames 
        |> Array.map (fun prefixedName -> prefixedName.localName, prefixedName )
        |> Map.ofArray



module RdfVocabulary = 
    open XmlComment
    
    let fromPrefixId (prefixId :PrefixId) = 
        namespaceMapper.AddNamespace(prefixId.asNamespaceMap)

        let ttlFile = prefixId.asFileExtension ".ttl"

        let loader = new Loader()
        let graph = new ThreadSafeGraph()
        try 
            if ttlFile.Exists then
                printfn "Loading %s from %s" prefixId.namespaceName ttlFile.FullName 
                loader.LoadGraph(graph, Uri ttlFile.FullName)
            else
                let distribution = 
                    match distributionMap.TryFind prefixId.namespaceName with 
                    | Some distribution -> distribution
                    | None -> prefixId.namespaceName
                printfn "Dereferencing distribution %s for %s " distribution prefixId.namespaceName
                loader.LoadGraph(graph, Uri distribution)
                Directory.CreateDirectory ttlFile.DirectoryName |> ignore
            
                use fileStream =
                    new FileStream(ttlFile.FullName, FileMode.Create, FileAccess.Write, FileShare.Read)
                use streamWriter = new StreamWriter(fileStream, new UTF8Encoding(false))
                Turtle.writeAllPrefixes streamWriter graph
                let formatter = Turtle.UnicodePrefixedNameTurtleW3CFormatter(graph) :> ITripleFormatter

                printfn "Writing %s to %s" prefixId.namespaceName ttlFile.FullName
                for triple in graph.Triples do
                    streamWriter.WriteLine(formatter.Format(triple))

                streamWriter.Flush()
        with 
        | _ -> ()
        {
            prefixId =  prefixId
            namespaceDocument = { graphFile = prefixId.asFileExtension ".ttl" }
        }
    let asModule(vocabulary:RdfVocabulary) = 

        Ast.Oak() {
              Ast.AnonymousModule(){

                Ast.Module(vocabulary.prefixId.prefixLabel){
                    for namespacedName in vocabulary.namespacedNames do 
                        printfn "%s" namespacedName.localName
                        
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
                            let elements :LitXml.XmlPart array = 
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


                            astValue.xmlDocs( LitXml.ElementBuilder.writeToXmlDocs elements )
                        else 
                            astValue


              }
              }
        }
        |> Gen.mkOak
        |> Gen.run




(*
let ttlDocuments = Folder.Iri.GetFiles("*.ttl", SearchOption.AllDirectories) |> Array.Parallel.map (fun rdfFile -> { rdfFile = rdfFile } )
let owlDocuments = 
  rdfDocuments |> Array.Parallel.choose (fun rdfDocument -> 
      try 
          match rdfDocument.asOWLOntology with 
          | _ -> Some rdfDocument
      with 
      | _ -> None
        )

*)

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

        JsonLdProcessor.Compact(expandedJsonLd, context, options).ToString(Newtonsoft.Json.Formatting.Indented)

    let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) = 
        let fileText: string = 
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
















































// Async Task helpers

type Task<'OutputType> with
    member this.await =
        this.GetAwaiter().GetResult()
type Task with
    member this.await =
        this.GetAwaiter().GetResult()

let await (operation: Task<'OutputType>) : 'OutputType = operation.GetAwaiter().GetResult()

let awaitUnit (task : Task) =
    task.GetAwaiter().GetResult()





















// Esri Helpers 

ArcGISRuntimeEnvironment.Initialize()
module Feature = 
    let rec Query (offset:int)  (table:ServiceFeatureTable) = 
        Array.concat [|

            let query = QueryParameters()
            query.WhereClause <- "1 = 1"
            query.ReturnGeometry <- true
            query.ResultOffset <- offset
            query.MaxFeatures <- int table.LayerInfo.MaxRecordCount

            let features =
                table.QueryFeaturesAsync(
                    query,
                    QueryFeatureFields.LoadAll
                )
                |> Async.AwaitTask
                |> Async.RunSynchronously
                |> Seq.toArray

            if features.Length = 0 then
                [||]
            else
                table |> Query (offset + features.Length) |> Array.append features
        |]

type Feature with 


    member this.X = 
            match this.Geometry with 
            | :? MapPoint as mapPoint -> string mapPoint.X
            | _ -> String.Empty
    member this.Y = 
            match this.Geometry with 
            | :? MapPoint as mapPoint -> string mapPoint.Y
            | _ -> String.Empty
    member this.Z = 
            match this.Geometry with 
            | :? MapPoint as mapPoint -> string mapPoint.Z
            | _ -> String.Empty
    member this.attributes = 
            this.Attributes
            |> Seq.toArray
            |> Array.map (|KeyValue|)
            |> Array.filter (fun (key,objValue) -> objValue <> null )
            |> Array.filter (fun (key,objValue) -> not (String.IsNullOrWhiteSpace (string objValue)))
            |> Array.map (fun (key,objValue) ->  key, string objValue)
    member this.attribute (fieldName:string) = this.attributes |> Array.tryPick (fun (key,value) -> 
        if key = fieldName then 
            Some value
        else
            None
        )
    member this.hasAttribute (fieldName:string) = 
        match this.attribute fieldName with 
        | Some _ -> true
        | None -> false

type StormwaterFeature = 
    | StormwaterFeature of Feature
    member this.feature = 
        match this with 
        | StormwaterFeature feature -> feature


    member this.ACCEPT_DATE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "ACCEPT_DATE" then Some value else None)
    member this.ACCURACYCODE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "ACCURACYCODE" then Some value else None)
    member this.ACREAGE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "ACREAGE" then Some value else None)
    member this.ACRES = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "ACRES" then Some value else None)
    member this.ACTIVITY = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "ACTIVITY" then Some value else None)
    member this.ANCILLARYROLE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "ANCILLARYROLE" then Some value else None)
    member this.ATTACHEDTOID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "ATTACHEDTOID" then Some value else None)
    member this.ATTRIBUTECOMPLETE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "ATTRIBUTECOMPLETE" then Some value else None)
    member this.CAPACITY = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "CAPACITY" then Some value else None)
    member this.CREATIONDATE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "CREATIONDATE" then Some value else None)
    member this.CREATOR = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "CREATOR" then Some value else None)
    member this.CREW = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "CREW" then Some value else None)
    member this.DAMAGEID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "DAMAGEID" then Some value else None)
    member this.DAMAGETYPE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "DAMAGETYPE" then Some value else None)
    member this.DATAFILE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "DATAFILE" then Some value else None)
    member this.DATECREATED = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "DATECREATED" then Some value else None)
    member this.DATEMODIFIED = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "DATEMODIFIED" then Some value else None)
    member this.DATE_ = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "DATE_" then Some value else None)
    member this.DESCRIPTION = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "DESCRIPTION" then Some value else None)
    member this.DIAMETER = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "DIAMETER" then Some value else None)
    member this.DIGITALPICTUREID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "DIGITALPICTUREID" then Some value else None)
    member this.DIGITALPICTUREID_E = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "DIGITALPICTUREID_E" then Some value else None)
    member this.DIGITALPICTUREID_S = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "DIGITALPICTUREID_S" then Some value else None)
    member this.DIGITALPICTUREID_W = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "DIGITALPICTUREID_W" then Some value else None)
    member this.DOWNSTREAMDEPTH = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "DOWNSTREAMDEPTH" then Some value else None)
    member this.DOWNSTREAMELEVATION = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "DOWNSTREAMELEVATION" then Some value else None)
    member this.DOWNSTREAM_DEPTH = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "DOWNSTREAM_DEPTH" then Some value else None)
    member this.DOWNSTREAM_ELEV = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "DOWNSTREAM_ELEV" then Some value else None)
    member this.DRAINAGEAREA = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "DRAINAGEAREA" then Some value else None)
    member this.DRAINAGEBASIN = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "DRAINAGEBASIN" then Some value else None)
    member this.DRAINAGE_AREA = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "DRAINAGE_AREA" then Some value else None)
    member this.DRAWINGID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "DRAWINGID" then Some value else None)
    member this.EASTING = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "EASTING" then Some value else None)
    member this.EDITDATE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "EDITDATE" then Some value else None)
    member this.EDITOR = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "EDITOR" then Some value else None)
    member this.ELEMENTX = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "ELEMENTX" then Some value else None)
    member this.ELEMENTY = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "ELEMENTY" then Some value else None)
    member this.ENABLED = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "ENABLED" then Some value else None)
    member this.FACILITYID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "FACILITYID" then Some value else None)
    member this.FIELDCOMMENTS = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "FIELDCOMMENTS" then Some value else None)
    member this.FIELDCOMPLETE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "FIELDCOMPLETE" then Some value else None)
    member this.FIELDCREW = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "FIELDCREW" then Some value else None)
    member this.FIELD_COMMENTS_ = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "FIELD_COMMENTS_" then Some value else None)
    member this.FILE_NAME = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "FILE_NAME" then Some value else None)
    member this.FILE_NAME_1 = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "FILE_NAME_1" then Some value else None)
    member this.FILTER = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "FILTER" then Some value else None)
    member this.FILTERLOCATION = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "FILTERLOCATION" then Some value else None)
    member this.FILTERTYPE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "FILTERTYPE" then Some value else None)
    member this.FINAL_NAME = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "FINAL_NAME" then Some value else None)
    member this.FOLDER = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "FOLDER" then Some value else None)
    member this.GLOBALID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "GLOBALID" then Some value else None)
    member this.HEIGHT = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "HEIGHT" then Some value else None)
    member this.HOTLINK = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "HOTLINK" then Some value else None)
    member this.HYD_ID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "HYD_ID" then Some value else None)
    member this.HYPERLINK = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "HYPERLINK" then Some value else None)
    member this.HYPERLINK_AR = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "HYPERLINK_AR" then Some value else None)
    member this.IMAGERYYEAR = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "IMAGERYYEAR" then Some value else None)
    member this.INFILTRATION = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "INFILTRATION" then Some value else None)
    member this.INSPDATE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "INSPDATE" then Some value else None)
    member this.INVENTORIED_BY = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "INVENTORIED_BY" then Some value else None)
    member this.INVENTORYDATE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "INVENTORYDATE" then Some value else None)
    member this.INVENTORYTYPE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "INVENTORYTYPE" then Some value else None)
    member this.INVERTELEV = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "INVERTELEV" then Some value else None)
    member this.INVERT_ELEV = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "INVERT_ELEV" then Some value else None)
    member this.INVERT_ELEV29 = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "INVERT_ELEV29" then Some value else None)
    member this.ISINFALL = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "ISINFALL" then Some value else None)
    member this.LEGACYID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "LEGACYID" then Some value else None)
    member this.LEGACY_ID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "LEGACY_ID" then Some value else None)
    member this.LFEET = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "LFEET" then Some value else None)
    member this.LIFECYCLE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "LIFECYCLE" then Some value else None)
    member this.LOCATION = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "LOCATION" then Some value else None)
    member this.LOC_DESC = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "LOC_DESC" then Some value else None)
    member this.MAINTBY = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "MAINTBY" then Some value else None)
    member this.MATERIAL = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "MATERIAL" then Some value else None)
    member this.MEDIA_CODE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "MEDIA_CODE" then Some value else None)
    member this.MILES = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "MILES" then Some value else None)
    member this.NEEDSATTENTION = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "NEEDSATTENTION" then Some value else None)
    member this.NORTHING = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "NORTHING" then Some value else None)
    member this.NOTES = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "NOTES" then Some value else None)
    member this.NUM_BARRELS = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "NUM_BARRELS" then Some value else None)
    member this.OBJECTID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "OBJECTID" then Some value else None)
    member this.OBSTRUCTION = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "OBSTRUCTION" then Some value else None)
    member this.ORIGINALSOURCE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "ORIGINALSOURCE" then Some value else None)
    member this.OUTFALLID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "OUTFALLID" then Some value else None)
    member this.OUTFALLTYPE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "OUTFALLTYPE" then Some value else None)
    member this.OWNER = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "OWNER" then Some value else None)
    member this.PARCELID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "PARCELID" then Some value else None)
    member this.PARENTID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "PARENTID" then Some value else None)
    member this.PERCT_GRD = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "PERCT_GRD" then Some value else None)
    member this.PHOTOID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "PHOTOID" then Some value else None)
    member this.PHOTO_FOLDER = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "PHOTO_FOLDER" then Some value else None)
    member this.PHOTO_NUM = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "PHOTO_NUM" then Some value else None)
    member this.PID_1 = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "PID_1" then Some value else None)
    member this.PIPESHAPE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "PIPESHAPE" then Some value else None)
    member this.PLACE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "PLACE" then Some value else None)
    member this.PONDID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "PONDID" then Some value else None)
    member this.PONDTYPE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "PONDTYPE" then Some value else None)
    member this.PONDYR = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "PONDYR" then Some value else None)
    member this.POND_ID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "POND_ID" then Some value else None)
    member this.PRFRESOLUTION = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "PRFRESOLUTION" then Some value else None)
    member this.RAW_NAME = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "RAW_NAME" then Some value else None)
    member this.RELATEDFEATURE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "RELATEDFEATURE" then Some value else None)
    member this.ROTATION_AZ = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "ROTATION_AZ" then Some value else None)
    member this.SHAPE_Area = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "SHAPE_Area" then Some value else None)
    member this.SHAPE_Length = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "SHAPE_Length" then Some value else None)
    member this.SLOT_ELEV = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "SLOT_ELEV" then Some value else None)
    member this.SOURCE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "SOURCE" then Some value else None)
    member this.SOURCEYEAR = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "SOURCEYEAR" then Some value else None)
    member this.STORAGE_FULL_PATH_ADDR = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "STORAGE_FULL_PATH_ADDR" then Some value else None)
    member this.STORAGE_PATH_ADDR = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "STORAGE_PATH_ADDR" then Some value else None)
    member this.STORAGE_STATIC_PATH_ADDR = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "STORAGE_STATIC_PATH_ADDR" then Some value else None)
    member this.STRCT_DEPTH = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "STRCT_DEPTH" then Some value else None)
    member this.STRUCTUREID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "STRUCTUREID" then Some value else None)
    member this.STRUCTURETYPE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "STRUCTURETYPE" then Some value else None)
    member this.STRUCTURE_ID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "STRUCTURE_ID" then Some value else None)
    member this.SUBTYPEFIELD = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "SUBTYPEFIELD" then Some value else None)
    member this.SURFACETYPE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "SURFACETYPE" then Some value else None)
    member this.Shape_Area = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "Shape_Area" then Some value else None)
    member this.Shape_Length = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "Shape_Length" then Some value else None)
    member this.UNDERDRAINS = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "UNDERDRAINS" then Some value else None)
    member this.UNITDESC = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "UNITDESC" then Some value else None)
    member this.UNITID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "UNITID" then Some value else None)
    member this.UPDATESOURCE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "UPDATESOURCE" then Some value else None)
    member this.UPSTREAMDEPTH = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "UPSTREAMDEPTH" then Some value else None)
    member this.UPSTREAMELEVATION = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "UPSTREAMELEVATION" then Some value else None)
    member this.UPSTREAMSTUCTUREID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "UPSTREAMSTUCTUREID" then Some value else None)
    member this.UPSTREAM_DEPTH = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "UPSTREAM_DEPTH" then Some value else None)
    member this.UPSTREAM_ELEV = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "UPSTREAM_ELEV" then Some value else None)
    member this.VIEW_ = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "VIEW_" then Some value else None)
    member this.WATERBODYNAME = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "WATERBODYNAME" then Some value else None)
    member this.WBID = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "WBID" then Some value else None)
    member this.WHOCREATED = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "WHOCREATED" then Some value else None)
    member this.WHOMODIFIED = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "WHOMODIFIED" then Some value else None)
    member this.WIDTH = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "WIDTH" then Some value else None)
    member this.Z29 = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "Z29" then Some value else None)
    member this.ZVALUE = this.feature.attributes |> Array.tryPick (fun (key,value) -> if key = "ZVALUE" then Some value else None)




        

type ServiceFeatureTable with
    member this.fields = this.Fields |> Seq.toArray
    member this.domainFields = this.Fields |> Seq.filter (fun field -> field.Domain <> null) |> Seq.toArray
    member this.nondomainFields = this.Fields |> Seq.filter (fun field -> field.Domain = null) |> Seq.toArray
    member this.aliasedFields = this.Fields |> Seq.filter (fun field -> field.Name <> field.Alias) |> Seq.toArray
    member this.features = this |> Feature.Query  0
type StormwaterFeatureTable =
    | StormwaterFeatureTable of ServiceFeatureTable
    member this.table = 
        match this with 
        | StormwaterFeatureTable serviceFeatureTable -> serviceFeatureTable
    member this.features = this.table.features |> Array.map (fun feature -> StormwaterFeature feature)

type ArcGISMapImageLayer with
    member this.sublayers = this.Sublayers |> Seq.map (fun layer -> layer :?> ArcGISMapImageSublayer) |> Seq.toArray
type StormwaterImageLayer = 
    | StormwaterImageLayer of ArcGISMapImageSublayer
    member this.imageLayer = 
        match this with 
        | StormwaterImageLayer arcGISMapImageSublayer -> arcGISMapImageSublayer



#load @"C:\Secret\EsriSecrets.fsx"
let StormwaterInfrastructureMapImageLayer = ArcGISMapImageLayer(new Uri(EsriSecrets.StormwaterInfrastructurePath))
StormwaterInfrastructureMapImageLayer.LoadTablesAndLayersAsync().await



















// Infor Helpers 


#load @"C:\Secret\InforSecrets.fsx"
open InforSecrets





















































(*

type InforProdSql = SqlDataProvider<IndividualsAmount=1000, UseOptionTypes=Common.NullableColumnType.OPTION, CaseSensitivityChange = Common.CaseSensitivityChange.ORIGINAL,
    SsdtPath = Prod.dapac,
    ConnectionString=Prod.connection_string>

let operations = InforProdSql.GetDataContext()


*)



module HansenDataDistribution = 
    [<Literal>]
    let xmlFilePath =  @"D:/Surface/Company/Infor/Download_Center/Product/Operations_and_Regulations/Release/Infor_Public_Sector_2025_04_01/IPS_2025_04_01/Deployment Files/MetaData/MetaData.xml"
    type Provider = XmlProvider<UseOriginalNames = true, PreferDateOnly = true,
            Sample = xmlFilePath >
    let xml = Provider.Load xmlFilePath









type Dac.Model.TSqlObject with 
    member this.ast = this.GetAst()
    member this.children = this.GetChildren() |> Seq.toArray
    member this.parent = this.GetParent()
    member this.referenced = this.GetReferenced() |> Seq.toArray
    member this.referencedRelationshipInstances = this.GetReferencedRelationshipInstances() |> Seq.toArray
    member this.referencing = this.GetReferencing() |> Seq.toArray
    member this.referencingRelationshipInstances = this.GetReferencingRelationshipInstances() |> Seq.toArray
    member this.script = this.GetScript() |> Seq.toArray
    member this.sourceInformation = this.GetSourceInformation()

type Dac.Model.TSqlModel with 
        member this.TableValuedFunctions =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "TableValuedFunction")

        member this.ScalarFunctions =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "ScalarFunction")

        member this.Indexes =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Index")

        member this.CheckConstraints =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "CheckConstraint")

        member this.DatabaseOptions =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "DatabaseOptions")

        member this.DefaultConstraints =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "DefaultConstraint")

        member this.DmlTriggers =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "DmlTrigger")

        member this.ExtendedPropertys =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "ExtendedProperty")

        member this.ForeignKeyConstraints =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "ForeignKeyConstraint")

        member this.Logins =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Login")

        member this.PrimaryKeyConstraints =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "PrimaryKeyConstraint")

        member this.Procedures =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Procedure")

        member this.Roles =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Role")

        member this.RoleMemberships =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "RoleMembership")

        member this.Schemas =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Schema")

        member this.Statisticss =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Statistics")

        member this.Synonyms =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Synonym")

        member this.Tables =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Table")

        member this.TableTypes =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "TableType")

        member this.UniqueConstraints =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "UniqueConstraint")

        member this.Users =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "User")

        member this.Views =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "View")


                                           
                                           
module Dacpac =                            
        [<Literal>]                        
        let xmlFilePath = @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\SqlDatabase\Metadata\dapac\model.xml"
        type Provider = XmlProvider<UseOriginalNames = true, PreferDateOnly = true,
                Sample = xmlFilePath >     
        let xml = Provider.Load xmlFilePath
                                           
        let Model =                        
            let options = Dac.Model.ModelLoadOptions()
                                                                      
            options.LoadAsScriptBackedModel <- true                   
            options.ModelStorageType <- Dac.DacSchemaModelStorageType.Memory
                                                                      
            Dac.Model.TSqlModel.LoadFromDacpac(@"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\SqlDatabase\Metadata\operations.dacpac", options)
                                                                      
                                                                      
type Dac.Model.ObjectIdentifier with                                  
  member this.display  = Dacpac.Model.DisplayServices.GetDisplayName(this, Dac.Model.EscapeStyle.EscapeIfNecessary, false)
  member this.fullDisplay  = Dacpac.Model.DisplayServices.GetDisplayName(this, Dac.Model.EscapeStyle.EscapeIfNecessary, true)
                                                                      
type Dac.Model.TSqlObject with                                        
  member this.simpleName  = Dacpac.Model.DisplayServices.GetElementName (this, Dac.Model.ElementNameStyle.SimpleName)
  member this.escapedSimpleName  = Dacpac.Model.DisplayServices.GetElementName (this, Dac.Model.ElementNameStyle.EscapedSimpleName)
  member this.fullyQualifiedName  = Dacpac.Model.DisplayServices.GetElementName (this, Dac.Model.ElementNameStyle.FullyQualifiedName)
  member this.escapedFullyQualifiedName  = Dacpac.Model.DisplayServices.GetElementName (this, Dac.Model.ElementNameStyle.EscapedFullyQualifiedName)
  (*
  member this.maybeProductFamily =                                    
    HansenDataDistribution.xml.hansenMetadata.productFamilies         
    |> Array.tryFind (fun productFamily ->                            
                            match this.fullyQualifiedName with        
                            | "MetaData" -> this.fullyQualifiedName = productFamily.name
                            | _ -> this.fullyQualifiedName = productFamily.name.ToUpperInvariant().Replace('.','_')
    )
  member this.maybeTable = 
    HansenDataDistribution.xml.hansenMetadata.productFamilies
    |> Array.tryPick (fun productFamily -> 
                        productFamily.tables
                        |> Array.tryFind (fun table -> 
                            match this.fullyQualifiedName with 
                            | "MetaData" -> this.fullyQualifiedName = table.name
                            | _ -> this.fullyQualifiedName = table.name.ToUpperInvariant().Replace('.','_')
                        )
    )

  *)
type Dac.Model.ModelTypeClass with 
    member this.metadata = this.Metadata |> Seq.toArray
    member this.properties = this.Properties |> Seq.toArray


(*


HansenDataDistribution.xml.hansenMetadata.productFamilies 
|> Array.filter (fun productFamily -> productFamily.name = "AssetManagement.Storm")
|> Array.collect (fun productFamily -> productFamily.tables |> Array.filter (fun table -> table.databaseName.StartsWith("COMP")))
|> Array.collect (fun table -> table.columns |> Array.filter (fun column -> column.name = "AssetKey") )
|> Array.head

*)








// codegen helpers 
























(*

// BrowserApi  helpers

let coerce<'T> (value : obj) : 'T =

    if isNull value then
        Unchecked.defaultof<'T>

    elif typeof<'T> = typeof<obj> then
        unbox<'T> value

    elif typeof<'T>.IsInstanceOfType value then
        unbox<'T> value

    else
        Convert.ChangeType(value, typeof<'T>)
        |> unbox<'T>



let fromHandle<'T when 'T :> JsObject>
    (handle : JsHandle)
    : 'T =

    let instance =
        Activator.CreateInstance(typeof<'T>)
        :?> 'T

    let handleProperty =
        typeof<JsObject>.GetProperty(
            "Handle",
            BindingFlags.Instance |||
            BindingFlags.Public
        )

    let setter =
        handleProperty.GetSetMethod(true)

    setter.Invoke(
        instance,
        [| box handle |]
    )
    |> ignore

    instance




type PuppeteerBrowserBackend(page : CdpPage) =

    // BrowserApi deliberately makes JsHandle opaque.
    //
    // So our BrowserApi JsHandle is just an identity token,
    // and this dictionary contains the actual PuppeteerSharp handle.
    let handles =
        ConcurrentDictionary<JsHandle, IJSHandle>()


    let wrap (puppeteerHandle : IJSHandle) =

        let browserHandle =
            JsHandle(obj())

        handles[browserHandle] <- puppeteerHandle

        browserHandle


    let unwrap (browserHandle : JsHandle) =

        match handles.TryGetValue browserHandle with
        | true, puppeteerHandle ->
            puppeteerHandle

        | false, _ ->
            invalidOp "Unknown BrowserApi JsHandle"

    let convertResultAsync (result : IJSHandle) =
        task {
            let! kind =
                result.EvaluateFunctionAsync<string>(
                    """
                    value => {
                        if (value === null)
                            return "null";

                        return typeof value;
                    }
                    """
                )

            match kind with
            | "undefined"
            | "null" ->
                do! result.DisposeAsync().AsTask()
                return null

            | "string" ->
                let! value =
                    result.JsonValueAsync<string>()

                do! result.DisposeAsync().AsTask()

                return box value

            | "boolean" ->
                let! value =
                    result.JsonValueAsync<bool>()

                do! result.DisposeAsync().AsTask()

                return box value

            | "number" ->
                let! value =
                    result.JsonValueAsync<double>()

                do! result.DisposeAsync().AsTask()

                return box value

            | _ ->
                return box (wrap result)
        }


    let convertResult result =
        convertResultAsync result
        |> await
    // BrowserApi will sometimes pass one of its handles as an
    // argument to another browser method.
    //
    // Turn that back into the corresponding Puppeteer IJSHandle.
    let convertArgument (value : obj) =

        match value with
        | null ->
            null

        | :? JsHandle as browserHandle ->
            box (unwrap browserHandle)

        | value ->
            value

    member _.Wrap(handle : IJSHandle) =
        wrap handle

    member this.FrameGlobal
        (
            frame : CdpFrame,
            name : string
        ) =

        frame.EvaluateFunctionHandleAsync(
            "name => globalThis[name]",
            [| box name |]
        )
        |> await
        |> this.Wrap
    interface IBrowserBackend with

        member _.GetProperty<'T>(target, propertyName) =

            let targetHandle =
                unwrap target

            let result =
                targetHandle.EvaluateFunctionHandleAsync(
                    """
                    (target, propertyName) =>
                        target[propertyName]
                    """,
                    [|
                        box propertyName
                    |]
                )
                |> await

            result
            |> convertResult
            |> coerce<'T>

        member _.SetProperty(target, propertyName, value) =

            let targetHandle =
                unwrap target

            targetHandle.EvaluateFunctionAsync(
                """
                (target, propertyName, value) => {
                    target[propertyName] = value;
                }
                """,
                [|
                    box propertyName
                    convertArgument value
                |]
            )
            |> await
            |> ignore

        member _.Invoke<'T>(target, methodName, arguments) =

            let targetHandle =
                unwrap target

            let arguments =
                Array.append
                    [| box methodName |]
                    (arguments |> Array.map convertArgument)

            let result =
                targetHandle.EvaluateFunctionHandleAsync(
                    """
                    (target, methodName, ...arguments) =>
                        target[methodName](...arguments)
                    """,
                    arguments
                )
                |> await

            result
            |> convertResult
            |> coerce<'T>

        member _.InvokeVoid(target, methodName, arguments) =

            let targetHandle =
                unwrap target

            let arguments =
                Array.append
                    [| box methodName |]
                    (arguments |> Array.map convertArgument)

            targetHandle.EvaluateFunctionAsync(
                """
                (target, methodName, ...arguments) => {
                    target[methodName](...arguments);
                }
                """,
                arguments
            )
            |> await
            |> ignore

        member _.InvokeAsync<'T>(target, methodName, arguments) =

            task {
                let targetHandle =
                    unwrap target

                let arguments =
                    Array.append
                        [| box methodName |]
                        (arguments |> Array.map convertArgument)

                let! result =
                    targetHandle.EvaluateFunctionHandleAsync(
                        """
                        (target, methodName, ...arguments) =>
                            target[methodName](...arguments)
                        """,
                        arguments
                    )

                let! converted =
                    convertResultAsync result

                return coerce<'T> converted
            }

        member _.InvokeVoidAsync(target, methodName, arguments) =

            let operation =
                task {
                    let targetHandle =
                        unwrap target

                    let arguments =
                        Array.append
                            [| box methodName |]
                            (arguments |> Array.map convertArgument)

                    let! _ =
                        targetHandle.EvaluateFunctionAsync(
                            """
                            (target, methodName, ...arguments) => {
                                target[methodName](...arguments);
                            }
                            """,
                            arguments
                        )

                    return ()
                }

            operation :> Task

        member _.GetGlobal(name) =

            page.EvaluateFunctionHandleAsync(
                """
                name => globalThis[name]
                """,
                [| box name |]
            )
            |> await
            |> wrap

        member _.Construct(jsClassName, arguments) =

            let arguments =
                Array.append
                    [| box jsClassName |]
                    (arguments |> Array.map convertArgument)

            page.EvaluateFunctionHandleAsync(
                """
                (className, ...arguments) => {
                    const constructor =
                        className
                            .split(".")
                            .reduce(
                                (current, part) => current[part],
                                globalThis
                            );

                    return Reflect.construct(
                        constructor,
                        arguments
                    );
                }
                """,
                arguments
            )
            |> await
            |> wrap


        member _.DisposeHandle(browserHandle) =

            match handles.TryRemove browserHandle with
            | true, puppeteerHandle ->
                puppeteerHandle.DisposeAsync()

            | false, _ ->
                ValueTask.CompletedTask


        member _.AddEventListener(_, _, _) =
            raise (
                NotSupportedException(
                    "Events are not implemented in the initial Puppeteer backend."
                )
            )


        member _.RemoveEventListener(_, _, _) =
            raise (
                NotSupportedException(
                    "Events are not implemented in the initial Puppeteer backend."
                )
            )


        member _.DisposeAsync() =

            let cleanup =
                task {
                    for KeyValue(_, handle) in handles do
                        do! handle.DisposeAsync().AsTask()

                    handles.Clear()
                }

            ValueTask(cleanup :> Task)




type Dom.Node with

    member this.asElement =
        this.Handle
        |> fromHandle<Dom.Element>

type Dom.NodeList with

    static member toArray (nodeList : Dom.NodeList) =
        [|
            for index = 0u to nodeList.Length - 1u do
                nodeList[index]
        |]

    static member toElements (nodeList : Dom.NodeList) =
        nodeList
        |> Dom.NodeList.toArray
        |> Array.map (fun node ->
            node.Handle
            |> fromHandle<Dom.Element>
        )




type Dom.Element with 
    member this.outerHTML = string this.OuterHtml
    member this.QuerySelector (selector:Selector) = 
        this.QuerySelector selector.Css
    member this.QuerySelectorAll (selector:Selector) = 
        this.QuerySelectorAll selector.Css |> Dom.NodeList.toElements

type Dom.Document with 
    member this.DomUrl = DomUrl this.Url
    member this.Uri = Uri this.Url
    member this.IriReference = IriReference this.Url
    member this.QuerySelector (selector:Selector) = 
        this.QuerySelector selector.Css
    member this.QuerySelectorAll (selector:Selector) = 
        this.QuerySelectorAll selector.Css |> Dom.NodeList.toElements

*)



/// https://source.chromium.org/chromium/chromium/src/+/main:content/browser/devtools/devtools_agent_host_impl.cc?ss=chromium&q=f:devtools%20-f:out%20%22::kTypeTab%5B%5D%22
[<RequireQualifiedAccess>]
type kType = 
    | tab
    | page
    | iframe
    | worker
    | shared_worker
    | service_worker
    | worklet
    | browser
    | webview
    | other
    | auction_worklet
    | assistive_technology
    | browser_ui
    member this.asString = this.ToString()
    member this.asTargetType = 
        match this with 
        | kType.tab -> TargetType.Tab
        | kType.page -> TargetType.Page
        | kType.iframe -> TargetType.IFrame
        | kType.worker -> TargetType.Worker
        | kType.shared_worker -> TargetType.SharedWorker
        | kType.service_worker -> TargetType.ServiceWorker
        | kType.worklet -> TargetType.Other
        | kType.browser -> TargetType.Browser
        | kType.webview -> TargetType.Webview
        | kType.other -> TargetType.Other
        | kType.auction_worklet -> TargetType.Other
        | kType.assistive_technology -> TargetType.Other
        | kType.browser_ui -> TargetType.Other






























// Javascript Authoring


type AngleSharpDomMetadataProvider() =
    inherit JavascriptMetadataProvider()

    let fallback =
        AttributeJavascriptMetadataProvider()

    override _.GetMemberMetadata(memberInfo: MemberInfo) =

        let domName =
            memberInfo.GetCustomAttributes(typeof<DomNameAttribute>, false)
            |> Seq.tryPick (function
                | :? DomNameAttribute as attribute ->
                    Some attribute.OfficialName
                | _ ->
                    None
            )

        match domName with
        | Some name ->
            JavascriptMemberAttribute(MemberName = name)
            :> IJavascriptMemberMetadata

        | None ->
            fallback.GetMemberMetadata(memberInfo)


type Javascript private () =

    static let options =
        JavascriptCompilationOptions(
            enum<JsCompilationFlags> 0
        )

    static do
        options.CustomMetadataProvider <-
            AngleSharpDomMetadataProvider()

    static member func<'InputType, 'OutputType>
        (
            expression:
                Expression<
                    Func<'InputType, 'OutputType>
                >
        ) =
        expression

    static member asText<'InputType, 'OutputType>
        (
            expression:
                Expression<
                    Func<'InputType, 'OutputType>
                >
        ) =
        expression.CompileToJavascript(options)












// cdp helpers 


type IPage with
    member this.asCdp =
        this :?> CdpPage

type IBrowser with
    member this.asCdp =
        this :?> CdpBrowser

type ITarget with
    member this.asCdp =
        this :?> CdpTarget

type IBrowserContext with
    member this.asCdp =
        this :?> CdpBrowserContext

type IRequest with 
    member this.asCdp = this :?> CdpHttpRequest

type IResponse with 
    member this.asCdp = this :?> CdpHttpResponse

type IElementHandle with 
    member this.asCdp = this :?> CdpElementHandle





let chrome = 
    
        let options = ConnectOptions()
        
        options.BrowserURL <- "http://127.0.0.1:9222"
        options.DefaultViewport <- null

        let ibrowser = task { return! Puppeteer.ConnectAsync(options) } |> await
        ibrowser :?> CdpBrowser


let backgroundOption = new CreatePageOptions()
backgroundOption.Background <- true

type DomUrl with 
    member this.HeadedDownloadText() = 
        let backTab = chrome.NewPageAsync(backgroundOption).await.asCdp
        let response = backTab.GoToAsync(this.asString).await
        this.WriteFileText(response.TextAsync().await)
        backTab.CloseAsync() |> ignore


    member this.ProviderText = 
        if not this.asFile.Exists then 
            this.HeadedDownloadText()
        let sampleIdentifier = $"{this.pathStem}FilePath"
        let text = 
            Ast.Oak(){
                Ast.AnonymousModule(){
                    Ast.Value(sampleIdentifier, Ast.VerbatimString(this.asFile.FullName))
                    |> _.attribute(
                        Ast.Attribute("Literal")
                    )

                    match this.extension with 
                    | ".json" -> Ast.Abbrev($"{this.pathStem}JsonProvider", "JsonProvider< UseOriginalNames = true, PreferDateOnly = true, OmitNullFields = true, RootName = \"{this.pathStem}\"")
                    | ".xml" -> 
                                Ast.Abbrev($"{this.pathStem}HtmlProvider",$"HtmlProvider<PreferOptionals = true, PreferDateOnly = true, Sample = {sampleIdentifier}>")
                                Ast.Abbrev($"{this.pathStem}XmlProvider", $"XmlProvider<UseOriginalNames = true, PreferDateOnly = true, Sample = {sampleIdentifier}>")
                    | _ -> ()
                }
            }
            |> Gen.mkOak
            |> Gen.run
        text



module DomUrl = 

    let AddQueryParameter (parameterKey:string) parameterValue (domUrl:DomUrl) = 
        new DomUrl(QueryStringUtilities.AddQueryString( domUrl.Href, parameterKey, string parameterValue) )  

    let UpsertQueryParameter (parameterKey:string) parameterValue (domUrl:DomUrl)= 
        new DomUrl(QueryStringUtilities.AddOrReplaceQueryString( domUrl.Href, parameterKey, string parameterValue) )  
    let RemoveQueryParameter (parameterKey:string)  (domUrl:DomUrl)= 
        new DomUrl(QueryStringUtilities.RemoveQueryString( domUrl.Href, parameterKey) )  
    let WriteFileExtensionText (text:string) (extension:string) (url:DomUrl)= 
        url.CreateFileDirectory()
        File.WriteAllText(Path.ChangeExtension(url.asFile.FullName, extension), text)

type DomUrl with 

    member this.HeadedDownloadTextExtension(extension:string) = 
        let backTab = chrome.NewPageAsync(backgroundOption).await.asCdp
        let response = backTab.GoToAsync(this.asString).await
        this |> DomUrl.WriteFileExtensionText (response.TextAsync().await) extension
        backTab.CloseAsync() |> ignore
(*

// BiDi automation


let firefox =

    let driver =
        BiDiDriver(
            TimeSpan.FromSeconds 30.
        )

    task { return! driver.StartAsync( "ws://127.0.0.1:9223/session" ) }
    |> await

    driver.Session.NewSessionAsync(
        NewCommandParameters()
    )
    |> await
    |> ignore

    driver

type BiDiDriver with 
    member this.BrowsingContextTree = 
        task {
            let! tree = this.BrowsingContext.GetTreeAsync( GetTreeCommandParameters() )
            return tree.ContextTree |> Seq.toArray
        } |> await



type BrowsingContextInfo with 
    member this.ResourceName = DomUrl this.Url 



*)
    







// Chrome devtools automation









type CdpHttpRequest with 
    member this.DomUrl = DomUrl this.Url  
    member this.headers = this.Headers |> Seq.map (fun kvp -> kvp.Key, kvp.Value) |> Seq.toArray
    member this.header (targetHeader:string) = this.headers  |> Array.tryPick (fun (headerKey,headerValue) -> if headerKey = targetHeader then Some headerValue else None)
    member this.PostText  = 
        if this.HasPostData then 
            Some this.PostData
        else 
            None



type CdpHttpResponse with 
    member this.DomUrl = DomUrl this.Url  
    member this.headers = this.Headers |> Seq.map (fun kvp -> kvp.Key, kvp.Value) |> Seq.toArray
    member this.Text()  = 
        try 
            task { return! this.TextAsync() } |> await |> Some
        with 
        | err -> 
            logLines.Add(sprintf "request %s %A threw %s" this.Url this.headers err.Message)
            None





type CdpElementHandle with 
    member this.EvaluateFunction ( javascriptFunction: Expression< Func<'InputType, 'OutputType> > ) =
        task { return! this.EvaluateFunctionAsync<'OutputType>(javascriptFunction |> Javascript.asText) }
        |> await
    member this.outerHTML = 
            Javascript.func<AngleSharp.Dom.IElement, string> ( fun element -> element.OuterHtml )
            |> this.EvaluateFunction  
            |> HtmlNode.Parse
        


type CdpPageTarget with
    member this.DomUrl = DomUrl this.Url

type CdpPage with
    member this.DomUrl = DomUrl this.Url
    member this.ScrollToBottom() = task { return! this.EvaluateFunctionAsync( "() => window.scrollTo(0, document.documentElement.scrollHeight)" ) } |> await
    member this.ScrollDown(pixels: int) = task { return! this.EvaluateFunctionAsync( "(pixels) => window.scrollBy(0, pixels)", pixels ) } |> await

    member this.ScrollUp(pixels: int) = task { return! this.EvaluateFunctionAsync( "(pixels) => window.scrollBy(0, -pixels)", pixels ) } |> await
    member this.SetTabName(name: string) =
        task {
            return!
                this.EvaluateFunctionAsync<string>(
                    "name => document.title = name",
                    name
                )
        }



type CdpFrame with
    member this.DomUrl = DomUrl this.Url 





type CdpBrowser with 
    member this.targets = this.Targets() |> Array.map (fun itarget -> itarget :?> CdpTarget)
    member this.otherDevToolsTargets = this.targets |> Array.choose (fun target -> 
        match target.Type, target.GetType().Name with 
        | TargetType.Other, "CdpDevToolsTarget" -> Some (target :?> CdpDevToolsTarget)
        | _ -> None
        ) 
    member this.otherTargets = this.targets |> Array.choose (fun target -> 
        match target.Type, target.GetType().Name with 
        | TargetType.Other, "CdpOtherTarget" -> Some (target :?> CdpOtherTarget)
        | _ -> None
        ) 
    
    member this.pageOtherTargets = this.targets |> Array.choose (fun target -> 
        match target.Type, target.GetType().Name with 
        | TargetType.Page, "CdpOtherTarget" -> Some (target :?> CdpOtherTarget)
        | _ -> None
        ) 
    
    member this.pageTargets = this.targets |> Array.choose (fun target -> 
        match target.Type, target.GetType().Name with 
        | TargetType.Page, "CdpPageTarget" -> Some (target :?> CdpPageTarget)
        | _ -> None
        ) 
    member this.workerTargets = this.targets |> Array.choose (fun target -> 
        match target.Type, target.GetType().Name with 
        | TargetType.ServiceWorker, "CdpWorkerTarget" -> Some (target :?> CdpWorkerTarget)
        | _ -> None
        ) 
    member this.browserOtherTargets = this.targets |> Array.choose (fun target -> 
        match target.Type, target.GetType().Name with 
        | TargetType.Browser, "CdpOtherTarget" -> Some (target :?> CdpOtherTarget)
        | _ -> None
        ) 
    member this.workerOtherTargets = this.targets |> Array.choose (fun target -> 
        match target.Type, target.GetType().Name with 
        | TargetType.Worker, "CdpOtherTarget" -> Some (target :?> CdpOtherTarget)
        | _ -> None
        ) 
    member this.iframeOtherTargets = this.targets |> Array.choose (fun target -> 
        match target.Type, target.GetType().Name with 
        | TargetType.IFrame, "CdpOtherTarget" -> Some (target :?> CdpOtherTarget)
        | _ -> None
        ) 
    
    member this.maybePageTarget ( pageTargetFinder : CdpPageTarget  -> bool)  = this.pageTargets |> Array.tryFind pageTargetFinder
    
module CdpBrowser = 
    let maybeTab ( pageTargetFinder : CdpPageTarget -> bool) (browser:CdpBrowser) = 
        let maybePage = browser.maybePageTarget pageTargetFinder |> Option.map (fun target -> target.AsPageAsync().await.asCdp )
        match maybePage with 
        | Some page -> page
        | None -> browser.NewPageAsync().await.asCdp





let writeRequestResponse  (response:CdpHttpResponse) (extensionOverride:string option) = 
        match extensionOverride, response.Text() with 
        | Some extension, Some text  -> 
            let file = Path.ChangeExtension(response.DomUrl.asFile.FullName, extension) |> FileInfo
            Directory.CreateDirectory file.DirectoryName |> ignore
            File.WriteAllText(  file.FullName, text)
        | None, Some text -> 
            Directory.CreateDirectory response.DomUrl.asFile.DirectoryName |> ignore
            File.WriteAllText( response.DomUrl.asFile.FullName , text)
        | _, _ -> ()

let neogovPathStems = 
    set [
            "employees"
            "customWindowProperties"
            "orgChartView"
            "directManager"
            "user-profile"
    ]

let bannerXmlStems = 
    set [
        "menu"
    ]
let bannerJsonStems = 
    set [
        "fetchUsageTracking"
        "getAccordionSectionData"
        "getSettingsVisibilityInd"
        "getPayStubSummary"
        "getPayStubSummaryList"
    ]
let networkMailbox =
    MailboxProcessor<CdpHttpRequest>.Start(fun inbox ->
        let rec loop () =
            async {
                let! request = inbox.Receive()
                match request.Response.Status with 
                | HttpStatusCode.OK ->

                    
                    finishedRequests.Add request
                    match request.Response.DomUrl.Host, request.Response.DomUrl.pathStem, request.Response.DomUrl.extension with
                    | "leoncountyfl.samanage.com", _, ".json"-> writeRequestResponse request.Response  None
                    | "leoncountyfl.samanage.com", _, ".jsonhtml"-> writeRequestResponse request.Response  None
                    | "leoncountyfl.samanage.com", _, ".xml"-> writeRequestResponse request.Response  None
                    | "unifiedweb-api.neogov.com", pathStem, _ when neogovPathStems.Contains(pathStem) -> Some ".json" |> writeRequestResponse request.Response 
                    | "content.centene.com", _, ".json"->  writeRequestResponse request.Response  None
                    | "my.centene.com", _, ".json"->  writeRequestResponse request.Response  None
                    | "app.securiti.ai", "location", _ -> Some ".json" |> writeRequestResponse request.Response 
                    | "smetrics.sunshinehealth.com", "interact", _ -> Some ".json" |> writeRequestResponse request.Response 
                    | "external-api.search.my.centene.com", "query", _ -> Some ".json" |> writeRequestResponse request.Response 
                    | "siteintercept.qualtrics.com", _, ".php" -> Some ".json" |> writeRequestResponse request.Response 
                    | "bannerprodssb.leoncountyfl.gov:8449", pathStem, _ when bannerXmlStems.Contains(pathStem) -> Some ".xml" |> writeRequestResponse request.Response 
                    | "bannerprodssb.leoncountyfl.gov:8449", pathStem, _ when bannerJsonStems.Contains(pathStem) -> Some ".json" |> writeRequestResponse request.Response 
                    

                         
                    | _ -> ()
                | _ -> failedRequests.Add request
                return! loop ()
            }

        loop ()
    )

let watchPageNetworkTraffic (page:CdpPage) = page.RequestFinished.Add(fun eventArguments -> networkMailbox.Post eventArguments.Request.asCdp)


type CdpBrowser with 

    member this.tabs = 
        let pages = this.pageTargets |> Array.map (fun target -> target.AsPageAsync().await.asCdp)
        pages |> Array.iter watchPageNetworkTraffic
        pages

























































let localVersionSet = Folder.fiboMaster.GetDirectories() |> Array.map (fun directory -> directory.Name) |> Set.ofArray
let latestRelease = DomUrl "https://github.com/edmcouncil/fibo/releases/latest"
    
let latestRemoteVersion =
    let master_ = "master_"
    task {
            let options = new CreatePageOptions()
            options.Background <- true
            let! tab = chrome.NewPageAsync(options)
            let! response = tab.GoToAsync(latestRelease.Href)
            do! tab.CloseAsync()

            return response.asCdp.DomUrl.pathStem[master_.Length .. ]
            }
        |> await
match localVersionSet.Contains(latestRemoteVersion) with  
| true -> printfn "fibo version %s already downloaded" latestRemoteVersion
| false ->
    printfn "downloading fibo version %s" latestRemoteVersion
    let fiboZip = DomUrl $"https://spec.edmcouncil.org/fibo/ontology/master/{latestRemoteVersion}/prod.ttl.zip"
    let httpGetFiboZip (distribution: string) =
        http {

            GET distribution

        }
        |> Request.send

    let httpResponse = httpGetFiboZip fiboZip.Href
    if httpResponse.originalHttpResponseMessage.IsSuccessStatusCode then
        fiboZip.CreateFileDirectory()
        Response.saveFile fiboZip.asFile.FullName httpResponse
    if fiboZip.asFile.Exists then 
        ZipFile.ExtractToDirectory(fiboZip.asFile.FullName, Folder.``spec.edmcouncil.org``.FullName)



module PrefixId =

    let vann = PrefixId.fromNamespaceLabel "http://purl.org/vocab/vann/"  "vann"
    let foaf = PrefixId.fromNamespaceLabel "http://xmlns.com/foaf/0.1/" "foaf" 
    let vs = PrefixId.fromNamespaceLabel "http://www.w3.org/2003/06/sw-vocab-status/ns#" "vs" 
    let hydra = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/hydra/core#" "hydra" 
    let void_ = PrefixId.fromNamespaceLabel "http://rdfs.org/ns/void#" "void" 
    let vaem = PrefixId.fromNamespaceLabel "http://www.linkedmodel.org/schema/vaem#" "vaem" 
    let voaf = PrefixId.fromNamespaceLabel "http://purl.org/vocommons/voaf#" "voaf"
    let dcterms = PrefixId.fromNamespaceLabel "http://purl.org/dc/terms/" "dcterms"
    let dcat = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/dcat#" "dcat"




let rdfVocabulary = PrefixId.fromNamespaceLabel "http://www.w3.org/1999/02/22-rdf-syntax-ns#" "rdf" |> RdfVocabulary.fromPrefixId  
let rdfsVocabulary = PrefixId.fromNamespaceLabel "http://www.w3.org/2000/01/rdf-schema#" "rdfs" |> RdfVocabulary.fromPrefixId  
let owlVocabulary = PrefixId.fromNamespaceLabel "http://www.w3.org/2002/07/owl#" "owl" |> RdfVocabulary.fromPrefixId  
let timeVocabulary = PrefixId.fromNamespaceLabel "http://www.w3.org/2006/time#" "time" |> RdfVocabulary.fromPrefixId  
let vannVocabulary = PrefixId.fromNamespaceLabel "http://purl.org/vocab/vann/" "vann" |> RdfVocabulary.fromPrefixId  
let foafVocabulary = PrefixId.fromNamespaceLabel "http://xmlns.com/foaf/0.1/" "foaf" |> RdfVocabulary.fromPrefixId  
let vsVocabulary = PrefixId.fromNamespaceLabel "http://www.w3.org/2003/06/sw-vocab-status/ns#" "vs" |> RdfVocabulary.fromPrefixId  
let hydraVocabulary = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/hydra/core#" "hydra" |> RdfVocabulary.fromPrefixId  
let voidVocabulary = PrefixId.fromNamespaceLabel "http://rdfs.org/ns/void#" "void" |> RdfVocabulary.fromPrefixId  
let vaemVocabulary = PrefixId.fromNamespaceLabel "http://www.linkedmodel.org/schema/vaem#" "vaem" |> RdfVocabulary.fromPrefixId  
let voafVocabulary = PrefixId.fromNamespaceLabel "http://purl.org/vocommons/voaf#" "voaf" |> RdfVocabulary.fromPrefixId  
let dctermsVocabulary = PrefixId.fromNamespaceLabel "http://purl.org/dc/terms/" "dcterms" |> RdfVocabulary.fromPrefixId  
let dcatVocabulary = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/dcat#" "dcat" |> RdfVocabulary.fromPrefixId  




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


module hydra =
    let ApiDocumentation = hydraVocabulary.prefixId.prefix "ApiDocumentation"
    let BaseUriSource = hydraVocabulary.prefixId.prefix "BaseUriSource"
    let BasicRepresentation = hydraVocabulary.prefixId.prefix "BasicRepresentation"
    /// <summary>
    ///   <para>rdfs:comment : The class of Hydra classes.^^xsd:string</para>
    ///   <para>rdfs:label : Hydra Class^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#Class">hydra:Class</a>
    /// </summary>
    let Class = hydraVocabulary.prefixId.prefix "Class"
    let Collection = hydraVocabulary.prefixId.prefix "Collection"
    let Error = hydraVocabulary.prefixId.prefix "Error"

    let ExplicitRepresentation =
        hydraVocabulary.prefixId.prefix "ExplicitRepresentation"

    /// <summary>
    ///   <para>rdfs:comment : Specifies a possible either expected or returned header values^^xsd:string</para>
    ///   <para>rdfs:label : Header specification^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#HeaderSpecification">hydra:HeaderSpecification</a>
    /// </summary>
    let HeaderSpecification = hydraVocabulary.prefixId.prefix "HeaderSpecification"
    let IriTemplate = hydraVocabulary.prefixId.prefix "IriTemplate"
    let IriTemplateMapping = hydraVocabulary.prefixId.prefix "IriTemplateMapping"
    let Link = hydraVocabulary.prefixId.prefix "Link"
    let LinkContext = hydraVocabulary.prefixId.prefix "LinkContext"
    let Operation = hydraVocabulary.prefixId.prefix "Operation"
    let PartialCollectionView = hydraVocabulary.prefixId.prefix "PartialCollectionView"
    let Resource = hydraVocabulary.prefixId.prefix "Resource"
    let Rfc3986 = hydraVocabulary.prefixId.prefix "Rfc3986"
    let Rfc6570Template = hydraVocabulary.prefixId.prefix "Rfc6570Template"
    let Status = hydraVocabulary.prefixId.prefix "Status"
    let SupportedProperty = hydraVocabulary.prefixId.prefix "SupportedProperty"
    let TemplatedLink = hydraVocabulary.prefixId.prefix "TemplatedLink"

    let VariableRepresentation =
        hydraVocabulary.prefixId.prefix "VariableRepresentation"

    let apiDocumentation = hydraVocabulary.prefixId.prefix "apiDocumentation"
    /// <summary>
    ///   <para>rdfs:comment : Determines whether the provided set of header values is closed or not.^^xsd:string</para>
    ///   <para>rdfs:label : closed set^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#closedSet">hydra:closedSet</a>
    /// </summary>
    let closedSet = hydraVocabulary.prefixId.prefix "closedSet"
    let collection = hydraVocabulary.prefixId.prefix "collection"
    /// <summary>
    ///   <para>rdfs:comment : A description.^^xsd:string</para>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#description">hydra:description</a>
    /// </summary>
    let description = hydraVocabulary.prefixId.prefix "description"
    let entrypoint = hydraVocabulary.prefixId.prefix "entrypoint"
    let expects = hydraVocabulary.prefixId.prefix "expects"
    /// <summary>
    ///   <para>rdfs:comment : Specification of the header expected by the operation.^^xsd:string</para>
    ///   <para>rdfs:label : expects header^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#expectsHeader">hydra:expectsHeader</a>
    /// </summary>
    let expectsHeader = hydraVocabulary.prefixId.prefix "expectsHeader"
    /// <summary>
    ///   <para>rdfs:comment : Hint on what kind of extensions are in use.^^xsd:string</para>
    ///   <para>rdfs:label : extension^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#extension">hydra:extension</a>
    /// </summary>
    let extension = hydraVocabulary.prefixId.prefix "extension"
    let first = hydraVocabulary.prefixId.prefix "first"
    /// <summary>
    ///   <para>rdfs:comment : A property representing a freetext query.^^xsd:string</para>
    ///   <para>rdfs:label : freetext query^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#freetextQuery">hydra:freetextQuery</a>
    /// </summary>
    let freetextQuery = hydraVocabulary.prefixId.prefix "freetextQuery"
    /// <summary>
    ///   <para>rdfs:comment : Name of the header.^^xsd:string</para>
    ///   <para>rdfs:label : header name^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#headerName">hydra:headerName</a>
    /// </summary>
    let headerName = hydraVocabulary.prefixId.prefix "headerName"
    let last = hydraVocabulary.prefixId.prefix "last"
    /// <summary>
    ///   <para>rdfs:comment : Instructs to limit set only to N elements.^^xsd:string</para>
    ///   <para>rdfs:label : take^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#limit">hydra:limit</a>
    /// </summary>
    let limit = hydraVocabulary.prefixId.prefix "limit"
    let manages = hydraVocabulary.prefixId.prefix "manages"
    /// <summary>
    ///   <para>rdfs:comment : A variable-to-property mapping of the IRI template.^^xsd:string</para>
    ///   <para>rdfs:label : mapping^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#mapping">hydra:mapping</a>
    /// </summary>
    let mapping = hydraVocabulary.prefixId.prefix "mapping"
    let member_ = hydraVocabulary.prefixId.prefix "member"
    let memberAssertion = hydraVocabulary.prefixId.prefix "memberAssertion"
    /// <summary>
    ///   <para>rdfs:comment : The HTTP method.^^xsd:string</para>
    ///   <para>rdfs:label : method^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#method">hydra:method</a>
    /// </summary>
    let method = hydraVocabulary.prefixId.prefix "method"
    let next = hydraVocabulary.prefixId.prefix "next"
    let object = hydraVocabulary.prefixId.prefix "object"
    /// <summary>
    ///   <para>rdfs:comment : Instructs to skip N elements of the set.^^xsd:string</para>
    ///   <para>rdfs:label : skip^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#offset">hydra:offset</a>
    /// </summary>
    let offset = hydraVocabulary.prefixId.prefix "offset"
    let operation = hydraVocabulary.prefixId.prefix "operation"
    /// <summary>
    ///   <para>rdfs:comment : Instructs to provide a specific page of the collection at a given index.^^xsd:string</para>
    ///   <para>rdfs:label : page index^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#pageIndex">hydra:pageIndex</a>
    /// </summary>
    let pageIndex = hydraVocabulary.prefixId.prefix "pageIndex"
    /// <summary>
    ///   <para>rdfs:comment : Instructs to provide a specific page reference of the collection.^^xsd:string</para>
    ///   <para>rdfs:label : page reference^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#pageReference">hydra:pageReference</a>
    /// </summary>
    let pageReference = hydraVocabulary.prefixId.prefix "pageReference"
    let possibleStatus = hydraVocabulary.prefixId.prefix "possibleStatus"
    /// <summary>
    ///   <para>rdfs:comment : Possible value of the header.^^xsd:string</para>
    ///   <para>rdfs:label : possible header value^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#possibleValue">hydra:possibleValue</a>
    /// </summary>
    let possibleValue = hydraVocabulary.prefixId.prefix "possibleValue"
    let previous = hydraVocabulary.prefixId.prefix "previous"
    /// <summary>
    ///   <para>rdfs:comment : A property^^xsd:string</para>
    ///   <para>rdfs:label : property^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#property">hydra:property</a>
    /// </summary>
    let property = hydraVocabulary.prefixId.prefix "property"
    /// <summary>
    ///   <para>rdfs:comment : True if the client can retrieve the property's value, false otherwise.^^xsd:string</para>
    ///   <para>rdfs:label : readable^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#readable">hydra:readable</a>
    /// </summary>
    let readable = hydraVocabulary.prefixId.prefix "readable"
    /// <summary>
    ///   <para>rdfs:comment : True if the property is required, false otherwise.^^xsd:string</para>
    ///   <para>rdfs:label : required^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#required">hydra:required</a>
    /// </summary>
    let required = hydraVocabulary.prefixId.prefix "required"
    /// <summary>
    ///   <para>rdfs:label : relative Uri resolution^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#resolveRelativeUsing">hydra:resolveRelativeUsing</a>
    /// </summary>
    let resolveRelativeUsing = hydraVocabulary.prefixId.prefix "resolveRelativeUsing"
    let returns = hydraVocabulary.prefixId.prefix "returns"
    /// <summary>
    ///   <para>rdfs:comment : Name of the header returned by the operation.^^xsd:string</para>
    ///   <para>rdfs:label : returns header^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#returnsHeader">hydra:returnsHeader</a>
    /// </summary>
    let returnsHeader = hydraVocabulary.prefixId.prefix "returnsHeader"
    let search = hydraVocabulary.prefixId.prefix "search"
    /// <summary>
    ///   <para>rdfs:comment : The HTTP status code. Please note it may happen this value will be different to actual status code received.^^xsd:string</para>
    ///   <para>rdfs:label : status code^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#statusCode">hydra:statusCode</a>
    /// </summary>
    let statusCode = hydraVocabulary.prefixId.prefix "statusCode"
    let subject = hydraVocabulary.prefixId.prefix "subject"
    let supportedClass = hydraVocabulary.prefixId.prefix "supportedClass"
    let supportedOperation = hydraVocabulary.prefixId.prefix "supportedOperation"
    let supportedProperty = hydraVocabulary.prefixId.prefix "supportedProperty"
    /// <summary>
    ///   <para>rdfs:comment : A templated string with placeholders. The literal's datatype indicates the template syntax; if not specified, hydra:Rfc6570Template is assumed.^^xsd:string</para>
    ///   <para>rdfs:label : template^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#template">hydra:template</a>
    /// </summary>
    let template = hydraVocabulary.prefixId.prefix "template"
    /// <summary>
    ///   <para>rdfs:comment : A title, often used along with a description.^^xsd:string</para>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#title">hydra:title</a>
    /// </summary>
    let title = hydraVocabulary.prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:comment : The total number of items referenced by a collection.^^xsd:string</para>
    ///   <para>rdfs:label : total items^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#totalItems">hydra:totalItems</a>
    /// </summary>
    let totalItems = hydraVocabulary.prefixId.prefix "totalItems"
    /// <summary>
    ///   <para>rdfs:comment : An IRI template variable^^xsd:string</para>
    ///   <para>rdfs:label : variable^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#variable">hydra:variable</a>
    /// </summary>
    let variable = hydraVocabulary.prefixId.prefix "variable"

    /// <summary>
    ///   <para>rdfs:comment : The representation format to use when expanding the IRI template.^^xsd:string</para>
    ///   <para>rdfs:label : variable representation^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#variableRepresentation">hydra:variableRepresentation</a>
    /// </summary>
    let variableRepresentation =
        hydraVocabulary.prefixId.prefix "variableRepresentation"

    let view = hydraVocabulary.prefixId.prefix "view"
    /// <summary>
    ///   <para>rdfs:comment : True if the client can change the property's value, false otherwise.^^xsd:string</para>
    ///   <para>rdfs:label : writable^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/hydra/core#writable">hydra:writable</a>
    /// </summary>
    let writable = hydraVocabulary.prefixId.prefix "writable"
    let writeable = hydraVocabulary.prefixId.prefix "writeable"

module ``void`` =
    /// <summary>
    ///   <para>rdfs:comment : A set of RDF triples that are published, maintained or aggregated by a single provider.^^xsd:string</para>
    ///   <para>rdfs:label : dataset^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#Dataset">void:Dataset</a>
    /// </summary>
    let Dataset = voidVocabulary.prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>rdfs:comment : A web resource whose foaf:primaryTopic or foaf:topics include void:Datasets.^^xsd:string</para>
    ///   <para>rdfs:label : dataset description^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#DatasetDescription">void:DatasetDescription</a>
    /// </summary>
    let DatasetDescription = voidVocabulary.prefixId.prefix "DatasetDescription"
    /// <summary>
    ///   <para>rdfs:comment : A collection of RDF links between two void:Datasets.^^xsd:string</para>
    ///   <para>rdfs:label : linkset^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#Linkset">void:Linkset</a>
    /// </summary>
    let Linkset = voidVocabulary.prefixId.prefix "Linkset"
    /// <summary>
    ///   <para>rdfs:comment : A technical feature of a void:Dataset, such as a supported RDF serialization format.^^xsd:string</para>
    ///   <para>rdfs:label : technical feature^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#TechnicalFeature">void:TechnicalFeature</a>
    /// </summary>
    let TechnicalFeature = voidVocabulary.prefixId.prefix "TechnicalFeature"
    /// <summary>
    ///   <para>rdfs:comment : The rdfs:Class that is the rdf:type of all entities in a class-based partition.^^xsd:string</para>
    ///   <para>rdfs:label : class^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#class">void:class</a>
    /// </summary>
    let class_ = voidVocabulary.prefixId.prefix "class"
    /// <summary>
    ///   <para>rdfs:comment : A subset of a void:Dataset that contains only the entities of a certain rdfs:Class.^^xsd:string</para>
    ///   <para>rdfs:label : class partition^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#classPartition">void:classPartition</a>
    /// </summary>
    let classPartition = voidVocabulary.prefixId.prefix "classPartition"
    /// <summary>
    ///   <para>rdfs:comment : The total number of distinct classes in a void:Dataset. In other words, the number of distinct resources occuring as objects of rdf:type triples in the dataset.^^xsd:string</para>
    ///   <para>rdfs:label : classes^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#classes">void:classes</a>
    /// </summary>
    let classes = voidVocabulary.prefixId.prefix "classes"
    /// <summary>
    ///   <para>rdfs:comment : An RDF dump, partial or complete, of a void:Dataset.^^xsd:string</para>
    ///   <para>rdfs:label : Data Dump^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#dataDump">void:dataDump</a>
    /// </summary>
    let dataDump = voidVocabulary.prefixId.prefix "dataDump"
    /// <summary>
    ///   <para>rdfs:comment : The total number of distinct objects in a void:Dataset. In other words, the number of distinct resources that occur in the object position of triples in the dataset. Literals are included in this count.^^xsd:string</para>
    ///   <para>rdfs:label : distinct objects^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#distinctObjects">void:distinctObjects</a>
    /// </summary>
    let distinctObjects = voidVocabulary.prefixId.prefix "distinctObjects"
    /// <summary>
    ///   <para>rdfs:comment : The total number of distinct subjects in a void:Dataset. In other words, the number of distinct resources that occur in the subject position of triples in the dataset.^^xsd:string</para>
    ///   <para>rdfs:label : distinct subjects^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#distinctSubjects">void:distinctSubjects</a>
    /// </summary>
    let distinctSubjects = voidVocabulary.prefixId.prefix "distinctSubjects"
    /// <summary>
    ///   <para>rdfs:comment : The total number of documents, for datasets that are published as a set of individual documents, such as RDF/XML documents or RDFa-annotated web pages. Non-RDF documents, such as web pages in HTML or images, are usually not included in this count. This property is intended for datasets where the total number of triples or entities is hard to determine. void:triples or void:entities should be preferred where practical.^^xsd:string</para>
    ///   <para>rdfs:label : number of documents^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#documents">void:documents</a>
    /// </summary>
    let documents = voidVocabulary.prefixId.prefix "documents"
    /// <summary>
    ///   <para>rdfs:comment : The total number of entities that are described in a void:Dataset.^^xsd:string</para>
    ///   <para>rdfs:label : number of entities^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#entities">void:entities</a>
    /// </summary>
    let entities = voidVocabulary.prefixId.prefix "entities"
    /// <summary>
    ///   <para>rdfs:label : example resource of dataset^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#exampleResource">void:exampleResource</a>
    /// </summary>
    let exampleResource = voidVocabulary.prefixId.prefix "exampleResource"
    /// <summary>
    ///   <para>rdfs:label : feature^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#feature">void:feature</a>
    /// </summary>
    let feature = voidVocabulary.prefixId.prefix "feature"
    /// <summary>
    ///   <para>rdfs:comment : Points to the void:Dataset that a document is a part of.^^xsd:string</para>
    ///   <para>rdfs:label : in dataset^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#inDataset">void:inDataset</a>
    /// </summary>
    let inDataset = voidVocabulary.prefixId.prefix "inDataset"
    /// <summary>
    ///   <para>rdfs:label : a link predicate^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#linkPredicate">void:linkPredicate</a>
    /// </summary>
    let linkPredicate = voidVocabulary.prefixId.prefix "linkPredicate"
    /// <summary>
    ///   <para>rdfs:comment : The dataset describing the objects of the triples contained in the Linkset.^^xsd:string</para>
    ///   <para>rdfs:label : Objects Target^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#objectsTarget">void:objectsTarget</a>
    /// </summary>
    let objectsTarget = voidVocabulary.prefixId.prefix "objectsTarget"
    /// <summary>
    ///   <para>rdfs:comment : An OpenSearch description document for a free-text search service over a void:Dataset.^^xsd:string</para>
    ///   <para>rdfs:label : open search description^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#openSearchDescription">void:openSearchDescription</a>
    /// </summary>
    let openSearchDescription = voidVocabulary.prefixId.prefix "openSearchDescription"
    /// <summary>
    ///   <para>rdfs:comment : The total number of distinct properties in a void:Dataset. In other words, the number of distinct resources that occur in the predicate position of triples in the dataset.^^xsd:string</para>
    ///   <para>rdfs:label : number of properties^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#properties">void:properties</a>
    /// </summary>
    let properties = voidVocabulary.prefixId.prefix "properties"
    /// <summary>
    ///   <para>rdfs:comment : The rdf:Property that is the predicate of all triples in a property-based partition.^^xsd:string</para>
    ///   <para>rdfs:label : property^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#property">void:property</a>
    /// </summary>
    let property = voidVocabulary.prefixId.prefix "property"
    /// <summary>
    ///   <para>rdfs:comment : A subset of a void:Dataset that contains only the triples of a certain rdf:Property.^^xsd:string</para>
    ///   <para>rdfs:label : property partition^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#propertyPartition">void:propertyPartition</a>
    /// </summary>
    let propertyPartition = voidVocabulary.prefixId.prefix "propertyPartition"
    /// <summary>
    ///   <para>rdfs:comment : A top concept or entry point for a void:Dataset that is structured in a tree-like fashion. All resources in a dataset can be reached by following links from its root resources in a small number of steps.^^xsd:string</para>
    ///   <para>rdfs:label : root resource^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#rootResource">void:rootResource</a>
    /// </summary>
    let rootResource = voidVocabulary.prefixId.prefix "rootResource"
    /// <summary>
    ///   <para>rdfs:label : has a SPARQL endpoint at^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#sparqlEndpoint">void:sparqlEndpoint</a>
    /// </summary>
    let sparqlEndpoint = voidVocabulary.prefixId.prefix "sparqlEndpoint"
    /// <summary>
    ///   <para>rdfs:comment : The dataset describing the subjects of triples contained in the Linkset.^^xsd:string</para>
    ///   <para>rdfs:label : Subjects Target^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#subjectsTarget">void:subjectsTarget</a>
    /// </summary>
    let subjectsTarget = voidVocabulary.prefixId.prefix "subjectsTarget"
    /// <summary>
    ///   <para>rdfs:label : has subset^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#subset">void:subset</a>
    /// </summary>
    let subset = voidVocabulary.prefixId.prefix "subset"
    /// <summary>
    ///   <para>rdfs:comment : One of the two datasets linked by the Linkset.^^xsd:string</para>
    ///   <para>rdfs:label : Target^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#target">void:target</a>
    /// </summary>
    let target = voidVocabulary.prefixId.prefix "target"
    /// <summary>
    ///   <para>rdfs:comment : The total number of triples contained in a void:Dataset.^^xsd:string</para>
    ///   <para>rdfs:label : number of triples^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#triples">void:triples</a>
    /// </summary>
    let triples = voidVocabulary.prefixId.prefix "triples"
    /// <summary>
    ///   <para>rdfs:comment : Defines a simple URI look-up protocol for accessing a dataset.^^xsd:string</para>
    ///   <para>rdfs:label : has an URI look-up endpoint at^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#uriLookupEndpoint">void:uriLookupEndpoint</a>
    /// </summary>
    let uriLookupEndpoint = voidVocabulary.prefixId.prefix "uriLookupEndpoint"
    /// <summary>
    ///   <para>rdfs:comment : Defines a regular expression pattern matching URIs in the dataset.^^xsd:string</para>
    ///   <para>rdfs:label : has URI regular expression pattern^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#uriRegexPattern">void:uriRegexPattern</a>
    /// </summary>
    let uriRegexPattern = voidVocabulary.prefixId.prefix "uriRegexPattern"
    /// <summary>
    ///   <para>rdfs:comment : A URI that is a common string prefix of all the entity URIs in a void:Dataset.^^xsd:string</para>
    ///   <para>rdfs:label : URI space^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#uriSpace">void:uriSpace</a>
    /// </summary>
    let uriSpace = voidVocabulary.prefixId.prefix "uriSpace"
    /// <summary>
    ///   <para>rdfs:comment : A vocabulary that is used in the dataset.^^xsd:string</para>
    ///   <para>rdfs:label : vocabulary^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#vocabulary">void:vocabulary</a>
    /// </summary>
    let vocabulary = voidVocabulary.prefixId.prefix "vocabulary"

module vann =
    let _namespaceIri = vannVocabulary.prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Changes</para>
    ///   <para>rdfs:comment : A reference to a resource that describes changes between this version of a vocabulary and the previous.</para>
    ///   <a href="http://purl.org/vocab/vann/changes">vann:changes</a>
    /// </summary>
    let changes = vannVocabulary.prefixId.prefix "changes"
    /// <summary>
    ///   <para>rdfs:label : Example</para>
    ///   <para>rdfs:comment : A reference to a resource that provides an example of how this resource can be used.</para>
    ///   <a href="http://purl.org/vocab/vann/example">vann:example</a>
    /// </summary>
    let example = vannVocabulary.prefixId.prefix "example"

    /// <summary>
    ///   <para>rdfs:label : Preferred Namespace Prefix</para>
    ///   <para>rdfs:comment : The preferred namespace prefix to use when using terms from this vocabulary in an XML document.</para>
    ///   <a href="http://purl.org/vocab/vann/preferredNamespacePrefix">vann:preferredNamespacePrefix</a>
    /// </summary>
    let preferredNamespacePrefix =
        vannVocabulary.prefixId.prefix "preferredNamespacePrefix"

    /// <summary>
    ///   <para>rdfs:label : Preferred Namespace Uri</para>
    ///   <para>rdfs:comment : The preferred namespace URI to use when using terms from this vocabulary in an XML document.</para>
    ///   <a href="http://purl.org/vocab/vann/preferredNamespaceUri">vann:preferredNamespaceUri</a>
    /// </summary>
    let preferredNamespaceUri = vannVocabulary.prefixId.prefix "preferredNamespaceUri"
    /// <summary>
    ///   <para>rdfs:label : Term Group</para>
    ///   <para>rdfs:comment : A group of related terms in a vocabulary.</para>
    ///   <a href="http://purl.org/vocab/vann/termGroup">vann:termGroup</a>
    /// </summary>
    let termGroup = vannVocabulary.prefixId.prefix "termGroup"
    /// <summary>
    ///   <para>rdfs:label : Usage Note</para>
    ///   <para>rdfs:comment : A reference to a resource that provides information on how this resource is to be used.</para>
    ///   <a href="http://purl.org/vocab/vann/usageNote">vann:usageNote</a>
    /// </summary>
    let usageNote = vannVocabulary.prefixId.prefix "usageNote"
    let vann_vocab_20040305 = vannVocabulary.prefixId.prefix "vann-vocab-20040305"

    let ``vann_vocab_20100607.rdf`` =
        vannVocabulary.prefixId.prefix "vann-vocab-20100607.rdf"

module vaem =
    let AnnotationsGraph = vaemVocabulary.prefixId.prefix "AnnotationsGraph"
    /// <summary>
    ///   <para>ns0:description : A mininal treatment of attribution. This serves as a placeholder class for voag:Attribution.^^xsd:string</para>
    ///   <para>rdfs:label : Attribution^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#Attribution">vaem:Attribution</a>
    /// </summary>
    let Attribution = vaemVocabulary.prefixId.prefix "Attribution"
    let BridgeGraph = vaemVocabulary.prefixId.prefix "BridgeGraph"
    /// <summary>
    ///   <para>ns0:description : VAEM Governed Object class is a placeholder for concepts that are fully defined by the voag:GovernedObject concept hierarchy for building a catalog of ontologies and graphs.^^xsd:string</para>
    ///   <para>rdfs:label : Governed object^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#CatalogEntry">vaem:CatalogEntry</a>
    /// </summary>
    let CatalogEntry = vaemVocabulary.prefixId.prefix "CatalogEntry"
    let CollectionGraph = vaemVocabulary.prefixId.prefix "CollectionGraph"
    let CurationGraph = vaemVocabulary.prefixId.prefix "CurationGraph"
    let DataGraph = vaemVocabulary.prefixId.prefix "DataGraph"
    let FunctionsGraph = vaemVocabulary.prefixId.prefix "FunctionsGraph"
    /// <summary>
    ///   <para>rdfs:comment : GraphRole is used to characterize how a graph of resources participates in an ontology set.  For example, a graph can be a schema, vocabulary, dataset, script, or ruleset.^^xsd:string</para>
    ///   <para>rdfs:label : Graph role^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#GraphRole">vaem:GraphRole</a>
    /// </summary>
    let GraphRole = vaemVocabulary.prefixId.prefix "GraphRole"
    /// <summary>
    ///   <para>ns0:description : The VAEM Licence Model class is a placeholder for concepts that are fully defined by VOAG.^^xsd:string</para>
    ///   <para>rdfs:label : License model^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#LicenseModel">vaem:LicenseModel</a>
    /// </summary>
    let LicenseModel = vaemVocabulary.prefixId.prefix "LicenseModel"
    let MappingGraph = vaemVocabulary.prefixId.prefix "MappingGraph"
    let ProxyGraph = vaemVocabulary.prefixId.prefix "ProxyGraph"
    let RulesGraph = vaemVocabulary.prefixId.prefix "RulesGraph"
    let SchemaGraph = vaemVocabulary.prefixId.prefix "SchemaGraph"
    let ScriptGraph = vaemVocabulary.prefixId.prefix "ScriptGraph"
    let ViewGraph = vaemVocabulary.prefixId.prefix "ViewGraph"
    let VocabularyGraph = vaemVocabulary.prefixId.prefix "VocabularyGraph"
    /// <summary>
    ///   <para>rdfs:comment : An annotation property that can be freely used on any kind of resource. The range of the property is 'xsd:string'.^^xsd:string</para>
    ///   <para>rdfs:label : definition^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#comment">vaem:comment</a>
    /// </summary>
    let comment = vaemVocabulary.prefixId.prefix "comment"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:date' is intended for general use as the name implies.  The range of the property is set as 'vaem:dateUnion' so as to allow a value to have a number of forms from a  year only to a full timestamp. The property is also the parent of all dates so that queries can be made for any date on an ontology.^^xsd:string</para>
    ///   <para>rdfs:label : date^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#date">vaem:date</a>
    /// </summary>
    let date = vaemVocabulary.prefixId.prefix "date"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:dateCreated' is intended for general use as the name implies.  The range of the property is set as 'vaem:dateUnion' so as to allow a value to have a number of forms from a  year only to a full timestamp.^^xsd:string</para>
    ///   <para>rdfs:label : date created^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#dateCreated">vaem:dateCreated</a>
    /// </summary>
    let dateCreated = vaemVocabulary.prefixId.prefix "dateCreated"
    let dateUnion = vaemVocabulary.prefixId.prefix "dateUnion"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:description' is intended for general use as the name implies.  Unlike 'rdfs:comment',  'vaem:description' is an 'owl:DatatypeProperty'. As such it can play a stronger role in the model, for example, as a predicate in an axiom.^^xsd:string</para>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#description">vaem:description</a>
    /// </summary>
    let description = vaemVocabulary.prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : has catalog entry^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#hasCatalogEntry">vaem:hasCatalogEntry</a>
    /// </summary>
    let hasCatalogEntry = vaemVocabulary.prefixId.prefix "hasCatalogEntry"
    /// <summary>
    ///   <para>rdfs:comment : The property 'lms:hasGraphRole' is used to characterize how a resource participates in an ontology set.  The property is used to specify the role that a graph plays, for example, an ontology graph can be a schema, vocabulary, dataset, script, or ruleset.^^xsd:string</para>
    ///   <para>rdfs:label : has graph role^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#hasGraphRole">vaem:hasGraphRole</a>
    /// </summary>
    let hasGraphRole = vaemVocabulary.prefixId.prefix "hasGraphRole"
    /// <summary>
    ///   <para>rdfs:label : has license type</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#hasLicenseType">vaem:hasLicenseType</a>
    /// </summary>
    let hasLicenseType = vaemVocabulary.prefixId.prefix "hasLicenseType"
    /// <summary>
    ///   <para>rdfs:comment : A refinement of the subject resource. Modelled after rdfs:isDefinedBy for the purpose of referring to layered graphs that further define a subject.^^xsd:string</para>
    ///   <para>rdfs:label : isRefinedBy^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#isRefinedBy">vaem:isRefinedBy</a>
    /// </summary>
    let isRefinedBy = vaemVocabulary.prefixId.prefix "isRefinedBy"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:lastUpdated' is intended for general use as the name implies.  The range of the property is set as 'vaem:dateUnion' so as to allow a value to have a number of forms from a  year only to a full timestamp.^^xsd:string</para>
    ///   <para>rdfs:label : last updated^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#lastUpdated">vaem:lastUpdated</a>
    /// </summary>
    let lastUpdated = vaemVocabulary.prefixId.prefix "lastUpdated"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:name' is intended for general use. In many cases 'rdfs:label' could be used give names to resources. In the case where compliance with a specific naming rule is needed,  'vaem:name' allows  a resource to carry a name that is used in more specific contexts. Making 'vaem:name' a sub-property of 'rdfs:label' allows 'vaem:name' to serve in the same way as an 'rdfs:label'.^^xsd:string</para>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#name">vaem:name</a>
    /// </summary>
    let name = vaemVocabulary.prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:namespace' provides a means to specify the onotlogy URI with which a graph is primarily associated. The intent is to allow multiple graphs to define statements for resources in the same Ontology namespace. For example, a foundation level graph with the base URI of 'http://www.somesite.com/1.0/schema/OurOntology'  may define general  concepts for 'OurOntology'. Another graph with the base URI 'http://www.somesite.com/1.0/schema/level2/OurOntology'  may add more specific details to the same 'OurOntology'. Each of these two graphs would carry the same value for 'vaem:namespace', that is, 'http://www.somesite.com/schema/OurOntology'.    In other words, an ontology URI is the URI associated with the resources of a controlled namespace. On the other hand the graph URIs (the base URIs) identify the graphs that hold resources that make up an ontology.^^xsd:string</para>
    ///   <para>rdfs:label : namespace^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#namespace">vaem:namespace</a>
    /// </summary>
    let namespace_ = vaemVocabulary.prefixId.prefix "namespace"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:namespacePrefix' specifes a short handle or label for the URI of an Ontology.  Multiple graphs can define statements for resources in the same Ontololgy namespace. For example, a foundation level graph with the base URI of 'http://www.somesite.com/1.0/schema/OurOntology'  may define general  concepts for 'OurOntology'. Another graph with the base URI 'http://www.somesite.com/1.0/schema/level2/OurOntology'  may add more specific details to the same 'OurOntology'. Each of these two graphs would carry the same value for 'vaem:namespacePrefix', for this example, perhaps, 'ourOntology'.^^xsd:string</para>
    ///   <para>rdfs:label : namespace prefix^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#namespacePrefix">vaem:namespacePrefix</a>
    /// </summary>
    let namespacePrefix = vaemVocabulary.prefixId.prefix "namespacePrefix"
    let numericUnion = vaemVocabulary.prefixId.prefix "numericUnion"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:ownedBy' is a general property that in some cases could have scalar values or may refer to some concept of 'Party'.  For this reason, the  type of this property is set as 'rdf:Property' and the property is rangeless. There are two sub-properties of 'vaem:ownedBy', namely 'vaem:owner' for string values and 'vaem:owningParty' for referencing a 'party'.  Ownership applies to thos ontologies that are proprietary. Other governance and provenance specifications are held in the VOAG ontology.^^xsd:string</para>
    ///   <para>rdfs:label : owned by^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#ownedBy">vaem:ownedBy</a>
    /// </summary>
    let ownedBy = vaemVocabulary.prefixId.prefix "ownedBy"
    /// <summary>
    ///   <para>rdfs:label : owner^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#owner">vaem:owner</a>
    /// </summary>
    let owner = vaemVocabulary.prefixId.prefix "owner"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:owningParty' is used to refer to some concept of 'Party' and is a sub-property of 'vaem:ownedBy'.^^xsd:string</para>
    ///   <para>rdfs:label : owning party^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#owningParty">vaem:owningParty</a>
    /// </summary>
    let owningParty = vaemVocabulary.prefixId.prefix "owningParty"
    /// <summary>
    ///   <para>rdfs:comment : To express how statements in a model can be reifiable, this property is used to explicitly associate a property with a user-defined sub-class of 'rdf:Statement'. A recommended way of using this is to declare the properties that share the same reification constructs as sub-properties of a parent property that carries the 'vaem:reifiableBy' property. The parent property should be of type 'rdf:Property' so that it can have both datatype and object properties as sub-properties. By this means use and transformations of a model can be understood through a fully specified metamodel. 'vaem:reifiableBy' is rangeless in order to comply with OWL DL semantics. Its range would have been rdfs:Class in order to refer to 'rdf:Statement' sub-classes.^^xsd:string</para>
    ///   <para>rdfs:label : reifiable by^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#reifiableBy">vaem:reifiableBy</a>
    /// </summary>
    let reifiableBy = vaemVocabulary.prefixId.prefix "reifiableBy"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:releaseDate' is intended for general use as the name implies.  The range of the property is set as 'vaem:dateUnion' so as to allow a value to have a number of forms from a  year only to a full timestamp.^^xsd:string</para>
    ///   <para>rdfs:label : release date^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#releaseDate">vaem:releaseDate</a>
    /// </summary>
    let releaseDate = vaemVocabulary.prefixId.prefix "releaseDate"
    /// <summary>
    ///   <para>rdfs:comment : The property 'vaem:revision' is a property intended for general use as the name implies. ^^xsd:string</para>
    ///   <para>rdfs:label : revision^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#revision">vaem:revision</a>
    /// </summary>
    let revision = vaemVocabulary.prefixId.prefix "revision"
    /// <summary>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#title">vaem:title</a>
    /// </summary>
    let title = vaemVocabulary.prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:comment : As it name implies, a way to attach an annotation about a 'todo' task^^xsd:string</para>
    ///   <para>rdfs:label : todo^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#todo">vaem:todo</a>
    /// </summary>
    let todo = vaemVocabulary.prefixId.prefix "todo"
    /// <summary>
    ///   <para>ns0:description : The property 'vaem:url' is intended for general use as the name implies.  The range of the property is set as an XSD URI.^^xsd:string</para>
    ///   <para>rdfs:label : url^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#url">vaem:url</a>
    /// </summary>
    let url = vaemVocabulary.prefixId.prefix "url"

    /// <summary>
    ///   <para>rdfs:comment : A property that is used to express dependencies on resources from graphs that are not imported.^^xsd:string</para>
    ///   <para>rdfs:label : uses non-imported resource^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#usesNonImportedResource">vaem:usesNonImportedResource</a>
    /// </summary>
    let usesNonImportedResource =
        vaemVocabulary.prefixId.prefix "usesNonImportedResource"

    /// <summary>
    ///   <para>rdfs:label : with attribution to^^xsd:string</para>
    ///   <a href="http://www.linkedmodel.org/schema/vaem#withAttributionTo">vaem:withAttributionTo</a>
    /// </summary>
    let withAttributionTo = vaemVocabulary.prefixId.prefix "withAttributionTo"

module voaf =
    /// <summary>
    ///   <para>rdfs:comment : Class used to store the number of occurences of a vocabulary in a particular datasetrdfs:comment : Classe utilisée pour stocker l'information d'occurences d'un vocabulaire dans un jeu de données</para>
    ///   <para>rdfs:label : Dataset occurrencesrdfs:label : Occurrences dans un jeu de données</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#DatasetOccurrences">voaf:DatasetOccurrences</a>
    /// </summary>
    let DatasetOccurrences = voafVocabulary.prefixId.prefix "DatasetOccurrences"
    /// <summary>
    ///   <para>rdfs:comment : A vocabulary used in the linked data cloud. An instance of voaf:Vocabulary relies on or is used by at least another instance of voaf:Vocabularyrdfs:comment : Un vocabulaire utilisé ou utilisable dans le Web des données. Une instance de voaf:Vocabulary s'appuie at/ou est utilisée par au moins une autre instance of voaf:Vocabulary</para>
    ///   <para>rdfs:label : Vocabulairerdfs:label : Vocabulary</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#Vocabulary">voaf:Vocabulary</a>
    /// </summary>
    let Vocabulary = voafVocabulary.prefixId.prefix "Vocabulary"
    /// <summary>
    ///   <para>rdfs:comment : A vocabulary space defines any relevant grouping of vocabularies e.g., designed for similar purposes or domains, or designed by the same publisher or the same project, etc.
    ///           A vocabulary can belong to zero, one or more vocabulary spaces.Dublin Core properties isPartOf and hasPart are used to link a vocabulary to a vocabulary space.rdfs:comment : Un Espace de vocabulaires définit un regroupement pertinent de vocabulaires, par exemple construits pour des domaines ou objectifs similaires, ou par le même déditeur ou le même projet, etc.
    ///          Un Vocabulaire peut appartenir à zéro, un ou plusieurs Espace de vocabulaires. Les propriétés Dublin Core isPartOf et hasPart sont utilisées pour relier un Vocabulaire à un Espace de vocabulaires.</para>
    ///   <para>rdfs:label : Espace de vocabulairesrdfs:label : Vocabulary Space</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#VocabularySpace">voaf:VocabularySpace</a>
    /// </summary>
    let VocabularySpace = voafVocabulary.prefixId.prefix "VocabularySpace"
    /// <summary>
    ///   <para>dc:description : PREFIX rdfs:&lt;http://www.w3.org/2000/01/rdf-schema#&gt;
    /// 		PREFIX owl:&lt;http://www.w3.org/2002/07/owl#&gt;
    /// 		PREFIX voaf:&lt;http://purl.org/vocommons/voaf#&gt;
    ///
    /// 		CONSTRUCT{
    /// 		?vocab voaf:classNumber ?nbClass
    /// 		}
    /// 		WHERE{
    /// 			SELECT (COUNT(distinct ?class) AS ?nbClass) ?vocab
    /// 			WHERE{
    /// 				{?class a rdfs:Class.}
    /// 				UNION{?class a owl:Class.}
    /// 				?class a ?type.
    /// 				FILTER(?type!=owl:DeprecatedClass)
    /// 				?class rdfs:isDefinedBy ?vocab.
    /// 				?vocab a voaf:Vocabulary.
    /// 			}GROUP BY ?vocab
    /// 		}^^xsd:string</para>
    ///   <para>rdfs:comment : Le nombre de classes définies dans l'espace de noms du Vocabulaire. Les classes importées d'autres vocabulaires ne sont pas comptabilisées.rdfs:comment : The number of classes defined in the vocabulary namespace. Classes imported from other namespaces are not taken into account.</para>
    ///   <para>rdfs:label : nombre de classesrdfs:label : number of classes</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#classNumber">voaf:classNumber</a>
    /// </summary>
    let classNumber = voafVocabulary.prefixId.prefix "classNumber"
    /// <summary>
    ///   <para>rdfs:comment : Deprecated since v2.4rdfs:comment : Déprécié depuis la v2.4</para>
    ///   <para>rdfs:label : datasetrdfs:label : jeu de données</para>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#dataset">voaf:dataset</a>
    /// </summary>
    let dataset = voafVocabulary.prefixId.prefix "dataset"
    /// <summary>
    ///   <para>rdfs:comment : Deprecated since v1.1rdfs:comment : Déprécié depuis la v1.1</para>
    ///   <para>rdfs:label : example datasetrdfs:label : exemple de jeu de données</para>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#exampleDataset">voaf:exampleDataset</a>
    /// </summary>
    let exampleDataset = voafVocabulary.prefixId.prefix "exampleDataset"
    /// <summary>
    ///   <para>dc:description : PREFIX rdfs:&lt;http://www.w3.org/2000/01/rdf-schema#&gt;
    /// 		PREFIX owl:&lt;http://www.w3.org/2002/07/owl#&gt;
    /// 		PREFIX voaf:&lt;http://purl.org/vocommons/voaf#&gt;
    ///
    /// 		CONSTRUCT{
    /// 			?vocab1 voaf:extends ?vocab2
    /// 		}
    /// 		WHERE{
    /// 			{?elem1 owl:inverseOf ?elem2. FILTER(!isBlank(?elem2))}
    /// 			UNION{?elem1 rdfs:domain ?elem2. FILTER(!isBlank(?elem2))}
    /// 			UNION{?elem1 rdfs:range ?elem2. FILTER(!isBlank(?elem2))}
    /// 			UNION{?elem2 rdfs:domain ?elem1. FILTER(!isBlank(?elem1))}
    /// 			UNION{?elem2 rdfs:range ?elem1. FILTER(!isBlank(?elem1))}
    /// 			?elem1 rdfs:isDefinedBy ?vocab1.
    /// 			?vocab1 a voaf:Vocabulary.
    /// 			?elem2 rdfs:isDefinedBy ?vocab2.
    /// 			?vocab2 a voaf:Vocabulary.
    /// 			FILTER(?vocab1!=?vocab2)
    /// 		}^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary extends the expressivity of the object vocabulary by declaring subsumption relationships, using object vocabulary class as domain or range of a subject vocabulary property, defining local restrictions etc ...rdfs:comment : Indique que le vocabulaire sujet étend l'expressivité du vocabulaire objet en déclarant des relations de subsomption avec ce dernier, ou en utilisant ses classes comme domaine ou co-domaine d'un propriété du vocabulaire sujet, ou en définissant des contraintes locales etc.</para>
    ///   <para>rdfs:label : extendsrdfs:label : étend</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#extends">voaf:extends</a>
    /// </summary>
    let extends = voafVocabulary.prefixId.prefix "extends"
    /// <summary>
    ///   <para>dc:description : PREFIX rdf:&lt;http://www.w3.org/1999/02/22-rdf-syntax-ns#&gt;
    /// 		PREFIX rdfs:&lt;http://www.w3.org/2000/01/rdf-schema#&gt;
    /// 		PREFIX owl:&lt;http://www.w3.org/2002/07/owl#&gt;
    /// 		PREFIX voaf:&lt;http://purl.org/vocommons/voaf#&gt;
    /// 		PREFIX skos:&lt;http://www.w3.org/2004/02/skos/core#&gt;
    ///
    /// 		CONSTRUCT{
    /// 			?vocab1 voaf:generalizes ?vocab2
    /// 		}
    /// 		WHERE{
    /// 			{?elem1 skos:narrowMatch ?elem2. FILTER(!isBlank(?elem2))}
    /// 			UNION{?elem2 rdfs:subPropertyOf ?elem1.}
    /// 			UNION{?elem1 a owl:Class. ?elem1 owl:unionOf ?union. ?union rdf:first ?elem2.}
    /// 			UNION{?elem1 a owl:Class. ?elem1 owl:unionOf ?union. ?union rdf:rest ?union2. ?union2 rdf:first ?elem2.}
    /// 			UNION{?elem1 a owl:Class. ?elem1 owl:unionOf ?union. ?union rdf:rest ?union2. ?union2 rdf:rest ?union3. ?union3 rdf:first ?elem2.}
    /// 			UNION{?elem1 a owl:Class. ?elem1 owl:unionOf ?union. ?union rdf:rest ?union2. ?union2 rdf:rest ?union3. ?union3 rdf:rest ?union4. ?union4 rdf:first ?elem2.}
    /// 			UNION{?elem1 a owl:Class. ?elem1 owl:unionOf ?union. ?union rdf:rest ?union2. ?union2 rdf:rest ?union3. ?union3 rdf:rest ?union4. ?union4 rdf:rest ?union5. ?union5 rdf:first ?elem2.}
    /// 			FILTER(!isBlank(?elem2))
    /// 			?elem1 rdfs:isDefinedBy ?vocab1.
    /// 			?vocab1 a voaf:Vocabulary.
    /// 			?elem2 rdfs:isDefinedBy ?vocab2.
    /// 			?vocab2 a voaf:Vocabulary.
    /// 			FILTER(?vocab1!=?vocab2)
    /// 		}^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary generalizes by some superclasses or superproperties the object vocabulary.rdfs:comment : Indique que le vocabulaire sujet définit des super-classes ou super-propriétés du vocabulaire objet</para>
    ///   <para>rdfs:label : generalizesrdfs:label : généralise</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#generalizes">voaf:generalizes</a>
    /// </summary>
    let generalizes = voafVocabulary.prefixId.prefix "generalizes"
    /// <summary>
    ///   <para>dc:description : PREFIX rdfs:&lt;http://www.w3.org/2000/01/rdf-schema#&gt;
    /// 		PREFIX owl:&lt;http://www.w3.org/2002/07/owl#&gt;
    /// 		PREFIX voaf:&lt;http://purl.org/vocommons/voaf#&gt;
    ///
    /// 		CONSTRUCT{
    /// 			?vocab1 voaf:hasDisjunctionsWith ?vocab2
    /// 		}
    /// 		WHERE{
    /// 			?elem1 owl:disjointWith ?elem2. FILTER(!isBlank(?elem2))
    /// 			?elem1 rdfs:isDefinedBy ?vocab1.
    /// 			?vocab1 a voaf:Vocabulary.
    /// 			?elem2 rdfs:isDefinedBy ?vocab2.
    /// 			?vocab2 a voaf:Vocabulary.
    /// 			FILTER(?vocab1!=?vocab2)
    /// 		}^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary contains some declaration of disjoint classes with the object vocabulary.rdfs:comment : Indique que le vocabulaire sujet contient des déclarations de classes disjointes avec le vocabulaire objet</para>
    ///   <para>rdfs:label : a des disjonctions avecrdfs:label : has disjunctions with</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#hasDisjunctionsWith">voaf:hasDisjunctionsWith</a>
    /// </summary>
    let hasDisjunctionsWith = voafVocabulary.prefixId.prefix "hasDisjunctionsWith"
    /// <summary>
    ///   <para>dc:description : PREFIX rdfs:&lt;http://www.w3.org/2000/01/rdf-schema#&gt;
    /// 		PREFIX owl:&lt;http://www.w3.org/2002/07/owl#&gt;
    /// 		PREFIX voaf:&lt;http://purl.org/vocommons/voaf#&gt;
    /// 		PREFIX skos:&lt;http://www.w3.org/2004/02/skos/core#&gt;
    ///
    /// 		CONSTRUCT{
    /// 			?vocab1 voaf:hasEquivalencesWith ?vocab2
    /// 		}
    /// 		WHERE{
    /// 			{?elem1 owl:equivalentProperty ?elem2.}
    /// 			UNION{?elem1 owl:sameAs ?elem2.}
    /// 			UNION{?elem1 owl:equivalentClass ?elem2.}
    /// 			UNION{?elem2 owl:equivalentProperty ?elem1.}
    /// 			UNION{?elem2 owl:equivalentClass ?elem1.}
    /// 			UNION{?elem1 skos:exactMatch ?elem2.}
    /// 			UNION{?elem2 skos:exactMatch ?elem1.}
    /// 			FILTER(!isBlank(?elem2))
    /// 			?elem1 rdfs:isDefinedBy ?vocab1.
    /// 			?vocab1 a voaf:Vocabulary.
    /// 			?elem2 rdfs:isDefinedBy ?vocab2.
    /// 			?vocab2 a voaf:Vocabulary.
    /// 			FILTER(?vocab1!=?vocab2)
    /// 		}^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary declares some equivalent classes or properties with the object vocabulary.rdfs:comment : Indique que le vocabulaire sujet déclare des équivalences de classes ou de propriétés avec le vocabulaire objet</para>
    ///   <para>rdfs:label : a des équivalences avecrdfs:label : has equivalences with</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#hasEquivalencesWith">voaf:hasEquivalencesWith</a>
    /// </summary>
    let hasEquivalencesWith = voafVocabulary.prefixId.prefix "hasEquivalencesWith"
    /// <summary>
    ///   <para>rdfs:comment : dataset in which a vocabulary occurredrdfs:comment : jeu de données dans lequel un vocabulaire apparait</para>
    ///   <para>rdfs:label : dans le jeu de donnéesrdfs:label : in dataset</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#inDataset">voaf:inDataset</a>
    /// </summary>
    let inDataset = voafVocabulary.prefixId.prefix "inDataset"
    /// <summary>
    ///   <para>dc:description : PREFIX rdfs:&lt;http://www.w3.org/2000/01/rdf-schema#&gt;
    /// 		PREFIX owl:&lt;http://www.w3.org/2002/07/owl#&gt;
    /// 		PREFIX voaf:&lt;http://purl.org/vocommons/voaf#&gt;
    ///
    /// 		CONSTRUCT{
    /// 			?vocab1 voaf:metadataVoc ?vocab2
    /// 		}
    /// 		WHERE{
    /// 			?elem1 ?elem2 ?o.
    /// 			?elem1 rdfs:isDefinedBy ?vocab1.
    /// 			?vocab1 a voaf:Vocabulary.
    /// 			?elem2 rdfs:isDefinedBy ?vocab2.
    /// 			?vocab2 a voaf:Vocabulary.
    /// 			FILTER(?vocab1!=?vocab2)
    /// 		}^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary uses the object vocabulary in metadata at global vocabulary level or at element levelrdfs:comment : Indique que le vocabulaire sujet utilise le vocabulaire objet pour décrire ses métadonnées, au niveau global du vocabulaire ou au niveau des éléments</para>
    ///   <para>rdfs:label : metadata vocabularyrdfs:label : vocabulaire de métadonnées</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#metadataVoc">voaf:metadataVoc</a>
    /// </summary>
    let metadataVoc = voafVocabulary.prefixId.prefix "metadataVoc"
    /// <summary>
    ///   <para>rdfs:comment : Number of occurrences of a vocabulary in a datasetrdfs:comment : nombre d'occurrences d'un vocabulaire dans un dataset</para>
    ///   <para>rdfs:label : occurrencesrdfs:label : occurrences</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#occurrences">voaf:occurrences</a>
    /// </summary>
    let occurrences = voafVocabulary.prefixId.prefix "occurrences"
    /// <summary>
    ///   <para>rdfs:comment : Nombre de jeux de données utilisant une ressource.rdfs:comment : Number of datasets using a resource.</para>
    ///   <para>rdfs:label : occurences dans des datasetsrdfs:label : occurrences in datasets</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#occurrencesInDatasets">voaf:occurrencesInDatasets</a>
    /// </summary>
    let occurrencesInDatasets = voafVocabulary.prefixId.prefix "occurrencesInDatasets"

    /// <summary>
    ///   <para>rdfs:comment : Nombre de vocabulaires utilisant une ressource.rdfs:comment : Number of vocabularies using a resource</para>
    ///   <para>rdfs:label : occurences dans des vocabulairesrdfs:label : occurrences in vocabularies</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#occurrencesInVocabularies">voaf:occurrencesInVocabularies</a>
    /// </summary>
    let occurrencesInVocabularies =
        voafVocabulary.prefixId.prefix "occurrencesInVocabularies"

    /// <summary>
    ///   <para>dc:description : PREFIX rdf:&lt;http://www.w3.org/1999/02/22-rdf-syntax-ns#&gt;
    /// 		PREFIX rdfs:&lt;http://www.w3.org/2000/01/rdf-schema#&gt;
    /// 		PREFIX owl:&lt;http://www.w3.org/2002/07/owl#&gt;
    /// 		PREFIX voaf:&lt;http://purl.org/vocommons/voaf#&gt;
    ///
    /// 		CONSTRUCT{
    /// 		?vocab voaf:propertyNumber ?nbProp
    /// 		}
    /// 		WHERE{
    /// 			SELECT (COUNT(distinct ?prop) AS ?nbProp) ?vocab
    /// 			WHERE{
    /// 				{?prop a rdf:Property.}
    /// 				UNION{?prop a owl:ObjectProperty.}
    /// 				UNION{?prop a owl:DatatypeProperty.}
    /// 				UNION{?prop a owl:AnnotationProperty.}
    /// 				UNION{?prop a owl:FunctionalProperty.}
    /// 				UNION{?prop a owl:OntologyProperty.}
    /// 				UNION{?prop a owl:AsymmetricProperty.}
    /// 				UNION{?prop a owl:InverseFunctionalProperty.}
    /// 				UNION{?prop a owl:IrreflexiveProperty.}
    /// 				UNION{?prop a owl:ReflexiveProperty.}
    /// 				UNION{?prop a owl:SymmetricProperty.}
    /// 				UNION{?prop a owl:TransitiveProperty.}
    /// 				?prop a ?type.
    /// 				FILTER(?type!=owl:DeprecatedProperty)
    /// 				?prop rdfs:isDefinedBy ?vocab.
    /// 				?vocab a voaf:Vocabulary.
    /// 			}GROUP BY ?vocab
    /// 		}^^xsd:string</para>
    ///   <para>rdfs:comment : Le nombre de propriétés définies dans l'espace de noms du Vocabulaire. Les propriétés importées d'autres vocabulaires ne sont pas comptabilisées.rdfs:comment : The number of properties defined in the vocabulary namespace. Properties imported from other namespaces are not taken into account.</para>
    ///   <para>rdfs:label : nombre de propriétésrdfs:label : number of properties</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#propertyNumber">voaf:propertyNumber</a>
    /// </summary>
    let propertyNumber = voafVocabulary.prefixId.prefix "propertyNumber"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary uses or extends some class or property of the object vocabularyrdfs:comment : Indique que le vocabulaire sujet utilise ou étend au moins une classe ou propriété du vocabulaire objet</para>
    ///   <para>rdfs:label : relies onrdfs:label : réutilise</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#reliesOn">voaf:reliesOn</a>
    /// </summary>
    let reliesOn = voafVocabulary.prefixId.prefix "reliesOn"
    /// <summary>
    ///   <para>rdfs:comment : Distinct number of datasets reusing a resource.rdfs:comment : Nombre distinct de jeux de données reutilisant une resource.</para>
    ///   <para>rdfs:label : reused by datasetsrdfs:label : réutilisé par des jeux de données</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#reusedByDatasets">voaf:reusedByDatasets</a>
    /// </summary>
    let reusedByDatasets = voafVocabulary.prefixId.prefix "reusedByDatasets"
    /// <summary>
    ///   <para>rdfs:comment : Distinct number of vocabularies reusing a resource.rdfs:comment : Nombre distinct de vocabulaires reutilisant une resource.</para>
    ///   <para>rdfs:label : reused by vocabulariesrdfs:label : réutilisé par des vocabulaires</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#reusedByVocabularies">voaf:reusedByVocabularies</a>
    /// </summary>
    let reusedByVocabularies = voafVocabulary.prefixId.prefix "reusedByVocabularies"
    /// <summary>
    ///   <para>rdfs:comment : Indique que deux vocabulaires sont similaires dans leur domaine et/ou leurs objectifs, sans être nécessairement reliés par des références.rdfs:comment : Used to assert that two vocabularies are similar in scope and objectives, independently of the fact that they otherwise refer to each other.</para>
    ///   <para>rdfs:label : similairerdfs:label : similar</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#similar">voaf:similar</a>
    /// </summary>
    let similar = voafVocabulary.prefixId.prefix "similar"
    /// <summary>
    ///   <para>dc:description : PREFIX rdfs:&lt;http://www.w3.org/2000/01/rdf-schema#&gt;
    /// 		PREFIX voaf:&lt;http://purl.org/vocommons/voaf#&gt;
    /// 		PREFIX skos:&lt;http://www.w3.org/2004/02/skos/core#&gt;
    ///
    /// 		CONSTRUCT{
    /// 			?vocab1 voaf:specializes ?vocab2
    /// 		}
    /// 		WHERE{
    /// 			{?elem1 rdfs:subPropertyOf ?elem2. FILTER(!isBlank(?elem2))}
    /// 			UNION{?elem1 rdfs:subClassOf ?elem2. FILTER(!isBlank(?elem2))}
    /// 			UNION{?elem1 skos:broadMatch ?elem2. FILTER(!isBlank(?elem2))}
    /// 			?elem1 rdfs:isDefinedBy ?vocab1.
    /// 			?vocab1 a voaf:Vocabulary.
    /// 			?elem2 rdfs:isDefinedBy ?vocab2.
    /// 			?vocab2 a voaf:Vocabulary.
    /// 			FILTER(?vocab1!=?vocab2)
    /// 		}^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary defines some subclasses or subproperties of the object vocabulary, or local restrictions on those.rdfs:comment : Indique que le vocabulaire sujet définit des sous-classes ou sous-propriétés du vocabulaire objet</para>
    ///   <para>rdfs:label : specializesrdfs:label : spécialise</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#specializes">voaf:specializes</a>
    /// </summary>
    let specializes = voafVocabulary.prefixId.prefix "specializes"
    /// <summary>
    ///   <para>rdfs:comment : Describes future tasks planned by a resource curator. This property is primarily intended to be used for vocabularies or datasets, but the domain is left open, it can be used for any resource. Use iCalendar Vtodo class and its properties to further describe the task calendar, priorities etc.rdfs:comment : Liste des tâches prévues par le gestionnaire d'une ressource. Cette propriété est destinée à l'usage des gestionnaires de vocabulaires ou de jeu de données mais son doamine est ouvert, elle peut être utilisée pour n'importe quelle ressource. Utiliser la classe ical:Vtodo pour une description fine des tâches : calendrier, priorités etc</para>
    ///   <para>rdfs:label : liste des choses à fairerdfs:label : to-do list</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#toDoList">voaf:toDoList</a>
    /// </summary>
    let toDoList = voafVocabulary.prefixId.prefix "toDoList"
    /// <summary>
    ///   <para>rdfs:comment : statistiques d'utilisation dans un jeu de donnéesrdfs:comment : usage statistics in a dataset</para>
    ///   <para>rdfs:label : usage in datasetrdfs:label : utilisation dans un jeu de données</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#usageInDataset">voaf:usageInDataset</a>
    /// </summary>
    let usageInDataset = voafVocabulary.prefixId.prefix "usageInDataset"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary is used by the object vocabularyrdfs:comment : Indique que le vocabulaire sujet est utilisé par le vocabulaire objet</para>
    ///   <para>rdfs:label : used byrdfs:label : utilisé par</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#usedBy">voaf:usedBy</a>
    /// </summary>
    let usedBy = voafVocabulary.prefixId.prefix "usedBy"


module dcterms =
    let _namespaceIri = dctermsVocabulary.prefixId.prefix ""
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A resource that acts or has the power to act.</para>
    ///   <para>rdfs:label : Agent</para>
    ///   <a href="http://purl.org/dc/terms/Agent">dcterms:Agent</a>
    /// </summary>
    let Agent = dctermsVocabulary.prefixId.prefix "Agent"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A group of agents.</para>
    ///   <para>rdfs:label : Agent Class</para>
    ///   <a href="http://purl.org/dc/terms/AgentClass">dcterms:AgentClass</a>
    /// </summary>
    let AgentClass = dctermsVocabulary.prefixId.prefix "AgentClass"

    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A book, article, or other documentary resource.</para>
    ///   <para>rdfs:label : Bibliographic Resource</para>
    ///   <a href="http://purl.org/dc/terms/BibliographicResource">dcterms:BibliographicResource</a>
    /// </summary>
    let BibliographicResource =
        dctermsVocabulary.prefixId.prefix "BibliographicResource"

    let Box = dctermsVocabulary.prefixId.prefix "Box"
    let DCMIType = dctermsVocabulary.prefixId.prefix "DCMIType"
    let DDC = dctermsVocabulary.prefixId.prefix "DDC"
    let Extent = dctermsVocabulary.prefixId.prefix "Extent"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A digital resource format.</para>
    ///   <para>rdfs:label : File Format</para>
    ///   <a href="http://purl.org/dc/terms/FileFormat">dcterms:FileFormat</a>
    /// </summary>
    let FileFormat = dctermsVocabulary.prefixId.prefix "FileFormat"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A rate at which something recurs.</para>
    ///   <para>rdfs:label : Frequency</para>
    ///   <a href="http://purl.org/dc/terms/Frequency">dcterms:Frequency</a>
    /// </summary>
    let Frequency = dctermsVocabulary.prefixId.prefix "Frequency"
    let IMT = dctermsVocabulary.prefixId.prefix "IMT"
    let ISO3166 = dctermsVocabulary.prefixId.prefix "ISO3166"
    let ISO639_2 = dctermsVocabulary.prefixId.prefix "ISO639-2"
    let ISO639_3 = dctermsVocabulary.prefixId.prefix "ISO639-3"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : The extent or range of judicial, law enforcement, or other authority.</para>
    ///   <para>rdfs:label : Jurisdiction</para>
    ///   <a href="http://purl.org/dc/terms/Jurisdiction">dcterms:Jurisdiction</a>
    /// </summary>
    let Jurisdiction = dctermsVocabulary.prefixId.prefix "Jurisdiction"
    let LCC = dctermsVocabulary.prefixId.prefix "LCC"
    let LCSH = dctermsVocabulary.prefixId.prefix "LCSH"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A legal document giving official permission to do something with a resource.</para>
    ///   <para>rdfs:label : License Document</para>
    ///   <a href="http://purl.org/dc/terms/LicenseDocument">dcterms:LicenseDocument</a>
    /// </summary>
    let LicenseDocument = dctermsVocabulary.prefixId.prefix "LicenseDocument"
    /// <summary>
    ///   <para>dcterms:description : Written, spoken, sign, and computer languages are linguistic systems.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A system of signs, symbols, sounds, gestures, or rules used in communication.</para>
    ///   <para>rdfs:label : Linguistic System</para>
    ///   <a href="http://purl.org/dc/terms/LinguisticSystem">dcterms:LinguisticSystem</a>
    /// </summary>
    let LinguisticSystem = dctermsVocabulary.prefixId.prefix "LinguisticSystem"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A spatial region or named place.</para>
    ///   <para>rdfs:label : Location</para>
    ///   <a href="http://purl.org/dc/terms/Location">dcterms:Location</a>
    /// </summary>
    let Location = dctermsVocabulary.prefixId.prefix "Location"

    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A location, period of time, or jurisdiction.</para>
    ///   <para>rdfs:label : Location, Period, or Jurisdiction</para>
    ///   <a href="http://purl.org/dc/terms/LocationPeriodOrJurisdiction">dcterms:LocationPeriodOrJurisdiction</a>
    /// </summary>
    let LocationPeriodOrJurisdiction =
        dctermsVocabulary.prefixId.prefix "LocationPeriodOrJurisdiction"

    let MESH = dctermsVocabulary.prefixId.prefix "MESH"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A file format or physical medium.</para>
    ///   <para>rdfs:label : Media Type</para>
    ///   <a href="http://purl.org/dc/terms/MediaType">dcterms:MediaType</a>
    /// </summary>
    let MediaType = dctermsVocabulary.prefixId.prefix "MediaType"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A media type or extent.</para>
    ///   <para>rdfs:label : Media Type or Extent</para>
    ///   <a href="http://purl.org/dc/terms/MediaTypeOrExtent">dcterms:MediaTypeOrExtent</a>
    /// </summary>
    let MediaTypeOrExtent = dctermsVocabulary.prefixId.prefix "MediaTypeOrExtent"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A method by which resources are added to a collection.</para>
    ///   <para>rdfs:label : Method of Accrual</para>
    ///   <a href="http://purl.org/dc/terms/MethodOfAccrual">dcterms:MethodOfAccrual</a>
    /// </summary>
    let MethodOfAccrual = dctermsVocabulary.prefixId.prefix "MethodOfAccrual"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A process that is used to engender knowledge, attitudes, and skills.</para>
    ///   <para>rdfs:label : Method of Instruction</para>
    ///   <a href="http://purl.org/dc/terms/MethodOfInstruction">dcterms:MethodOfInstruction</a>
    /// </summary>
    let MethodOfInstruction = dctermsVocabulary.prefixId.prefix "MethodOfInstruction"
    let NLM = dctermsVocabulary.prefixId.prefix "NLM"
    let Period = dctermsVocabulary.prefixId.prefix "Period"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : An interval of time that is named or defined by its start and end dates.</para>
    ///   <para>rdfs:label : Period of Time</para>
    ///   <a href="http://purl.org/dc/terms/PeriodOfTime">dcterms:PeriodOfTime</a>
    /// </summary>
    let PeriodOfTime = dctermsVocabulary.prefixId.prefix "PeriodOfTime"
    /// <summary>
    ///   <para>dcterms:description : Examples include paper, canvas, or DVD.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A physical material or carrier.</para>
    ///   <para>rdfs:label : Physical Medium</para>
    ///   <a href="http://purl.org/dc/terms/PhysicalMedium">dcterms:PhysicalMedium</a>
    /// </summary>
    let PhysicalMedium = dctermsVocabulary.prefixId.prefix "PhysicalMedium"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A material thing.</para>
    ///   <para>rdfs:label : Physical Resource</para>
    ///   <a href="http://purl.org/dc/terms/PhysicalResource">dcterms:PhysicalResource</a>
    /// </summary>
    let PhysicalResource = dctermsVocabulary.prefixId.prefix "PhysicalResource"
    let Point = dctermsVocabulary.prefixId.prefix "Point"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A plan or course of action by an authority, intended to influence and determine decisions, actions, and other matters.</para>
    ///   <para>rdfs:label : Policy</para>
    ///   <a href="http://purl.org/dc/terms/Policy">dcterms:Policy</a>
    /// </summary>
    let Policy = dctermsVocabulary.prefixId.prefix "Policy"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : Any changes in ownership and custody of a resource since its creation that are significant for its authenticity, integrity, and interpretation.</para>
    ///   <para>rdfs:label : Provenance Statement</para>
    ///   <a href="http://purl.org/dc/terms/ProvenanceStatement">dcterms:ProvenanceStatement</a>
    /// </summary>
    let ProvenanceStatement = dctermsVocabulary.prefixId.prefix "ProvenanceStatement"
    let RFC1766 = dctermsVocabulary.prefixId.prefix "RFC1766"
    let RFC3066 = dctermsVocabulary.prefixId.prefix "RFC3066"
    let RFC4646 = dctermsVocabulary.prefixId.prefix "RFC4646"
    let RFC5646 = dctermsVocabulary.prefixId.prefix "RFC5646"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A statement about the intellectual property rights (IPR) held in or over a resource, a legal document giving official permission to do something with a resource, or a statement about access rights.</para>
    ///   <para>rdfs:label : Rights Statement</para>
    ///   <a href="http://purl.org/dc/terms/RightsStatement">dcterms:RightsStatement</a>
    /// </summary>
    let RightsStatement = dctermsVocabulary.prefixId.prefix "RightsStatement"
    /// <summary>
    ///   <para>dcterms:description : Examples include a number of pages, a specification of length, width, and breadth, or a period in hours, minutes, and seconds.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A dimension or extent, or a time taken to play or execute.</para>
    ///   <para>rdfs:label : Size or Duration</para>
    ///   <a href="http://purl.org/dc/terms/SizeOrDuration">dcterms:SizeOrDuration</a>
    /// </summary>
    let SizeOrDuration = dctermsVocabulary.prefixId.prefix "SizeOrDuration"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A reference point against which other things can be evaluated or compared.</para>
    ///   <para>rdfs:label : Standard</para>
    ///   <a href="http://purl.org/dc/terms/Standard">dcterms:Standard</a>
    /// </summary>
    let Standard = dctermsVocabulary.prefixId.prefix "Standard"
    let TGN = dctermsVocabulary.prefixId.prefix "TGN"
    let UDC = dctermsVocabulary.prefixId.prefix "UDC"
    let URI = dctermsVocabulary.prefixId.prefix "URI"
    let W3CDTF = dctermsVocabulary.prefixId.prefix "W3CDTF"
    /// <summary>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A summary of the resource.</para>
    ///   <para>rdfs:label : Abstract</para>
    ///   <a href="http://purl.org/dc/terms/abstract">dcterms:abstract</a>
    /// </summary>
    let abstract_ = dctermsVocabulary.prefixId.prefix "abstract"
    /// <summary>
    ///   <para>dcterms:description : Access Rights may include information regarding access or restrictions based on privacy, security, or other policies.</para>
    ///   <para>dcterms:issued : 2003-02-15^^xsd:date</para>
    ///   <para>rdfs:comment : Information about who access the resource or an indication of its security status.</para>
    ///   <para>rdfs:label : Access Rights</para>
    ///   <a href="http://purl.org/dc/terms/accessRights">dcterms:accessRights</a>
    /// </summary>
    let accessRights = dctermsVocabulary.prefixId.prefix "accessRights"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to use a value from the Collection Description Accrual Method Vocabulary [[DCMI-ACCRUALMETHOD](https://dublincore.org/groups/collections/accrual-method/)].</para>
    ///   <para>dcterms:issued : 2005-06-13^^xsd:date</para>
    ///   <para>rdfs:comment : The method by which items are added to a collection.</para>
    ///   <para>rdfs:label : Accrual Method</para>
    ///   <a href="http://purl.org/dc/terms/accrualMethod">dcterms:accrualMethod</a>
    /// </summary>
    let accrualMethod = dctermsVocabulary.prefixId.prefix "accrualMethod"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to use a value from the Collection Description Frequency Vocabulary [[DCMI-COLLFREQ](https://dublincore.org/groups/collections/frequency/)].</para>
    ///   <para>dcterms:issued : 2005-06-13^^xsd:date</para>
    ///   <para>rdfs:comment : The frequency with which items are added to a collection.</para>
    ///   <para>rdfs:label : Accrual Periodicity</para>
    ///   <a href="http://purl.org/dc/terms/accrualPeriodicity">dcterms:accrualPeriodicity</a>
    /// </summary>
    let accrualPeriodicity = dctermsVocabulary.prefixId.prefix "accrualPeriodicity"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to use a value from the Collection Description Accrual Policy Vocabulary [[DCMI-ACCRUALPOLICY](https://dublincore.org/groups/collections/accrual-policy/)].</para>
    ///   <para>dcterms:issued : 2005-06-13^^xsd:date</para>
    ///   <para>rdfs:comment : The policy governing the addition of items to a collection.</para>
    ///   <para>rdfs:label : Accrual Policy</para>
    ///   <a href="http://purl.org/dc/terms/accrualPolicy">dcterms:accrualPolicy</a>
    /// </summary>
    let accrualPolicy = dctermsVocabulary.prefixId.prefix "accrualPolicy"
    /// <summary>
    ///   <para>dcterms:description : The distinction between titles and alternative titles is application-specific.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : An alternative name for the resource.</para>
    ///   <para>rdfs:label : Alternative Title</para>
    ///   <a href="http://purl.org/dc/terms/alternative">dcterms:alternative</a>
    /// </summary>
    let alternative = dctermsVocabulary.prefixId.prefix "alternative"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to use this property with non-literal values from a vocabulary of audience types.</para>
    ///   <para>dcterms:issued : 2001-05-21^^xsd:date</para>
    ///   <para>rdfs:comment : A class of agents for whom the resource is intended or useful.</para>
    ///   <para>rdfs:label : Audience</para>
    ///   <a href="http://purl.org/dc/terms/audience">dcterms:audience</a>
    /// </summary>
    let audience = dctermsVocabulary.prefixId.prefix "audience"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to describe the date, date/time, or period of time as recommended for the property Date, of which this is a subproperty.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : Date that the resource became or will become available.</para>
    ///   <para>rdfs:label : Date Available</para>
    ///   <a href="http://purl.org/dc/terms/available">dcterms:available</a>
    /// </summary>
    let available = dctermsVocabulary.prefixId.prefix "available"

    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to include sufficient bibliographic detail to identify the resource as unambiguously as possible.</para>
    ///   <para>dcterms:issued : 2003-02-15^^xsd:date</para>
    ///   <para>rdfs:comment : A bibliographic reference for the resource.</para>
    ///   <para>rdfs:label : Bibliographic Citation</para>
    ///   <a href="http://purl.org/dc/terms/bibliographicCitation">dcterms:bibliographicCitation</a>
    /// </summary>
    let bibliographicCitation =
        dctermsVocabulary.prefixId.prefix "bibliographicCitation"

    /// <summary>
    ///   <para>dcterms:issued : 2001-05-21^^xsd:date</para>
    ///   <para>rdfs:comment : An established standard to which the described resource conforms.</para>
    ///   <para>rdfs:label : Conforms To</para>
    ///   <a href="http://purl.org/dc/terms/conformsTo">dcterms:conformsTo</a>
    /// </summary>
    let conformsTo = dctermsVocabulary.prefixId.prefix "conformsTo"
    /// <summary>
    ///   <para>dcterms:description : The guidelines for using names of persons or organizations as creators apply to contributors.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : An entity responsible for making contributions to the resource.</para>
    ///   <para>rdfs:label : Contributor</para>
    ///   <a href="http://purl.org/dc/terms/contributor">dcterms:contributor</a>
    /// </summary>
    let contributor = dctermsVocabulary.prefixId.prefix "contributor"
    /// <summary>
    ///   <para>dcterms:description : Spatial topic and spatial applicability may be a named place or a location specified by its geographic coordinates. Temporal topic may be a named period, date, or date range. A jurisdiction may be a named administrative entity or a geographic place to which the resource applies. Recommended practice is to use a controlled vocabulary such as the Getty Thesaurus of Geographic Names [[TGN](https://www.getty.edu/research/tools/vocabulary/tgn/index.html)]. Where appropriate, named places or time periods may be used in preference to numeric identifiers such as sets of coordinates or date ranges.  Because coverage is so broadly defined, it is preferable to use the more specific subproperties Temporal Coverage and Spatial Coverage.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : The spatial or temporal topic of the resource, spatial applicability of the resource, or jurisdiction under which the resource is relevant.</para>
    ///   <para>rdfs:label : Coverage</para>
    ///   <a href="http://purl.org/dc/terms/coverage">dcterms:coverage</a>
    /// </summary>
    let coverage = dctermsVocabulary.prefixId.prefix "coverage"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to describe the date, date/time, or period of time as recommended for the property Date, of which this is a subproperty.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : Date of creation of the resource.</para>
    ///   <para>rdfs:label : Date Created</para>
    ///   <a href="http://purl.org/dc/terms/created">dcterms:created</a>
    /// </summary>
    let created = dctermsVocabulary.prefixId.prefix "created"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to identify the creator with a URI.  If this is not possible or feasible, a literal value that identifies the creator may be provided.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : An entity responsible for making the resource.</para>
    ///   <para>rdfs:label : Creator</para>
    ///   <a href="http://purl.org/dc/terms/creator">dcterms:creator</a>
    /// </summary>
    let creator = dctermsVocabulary.prefixId.prefix "creator"
    /// <summary>
    ///   <para>dcterms:description : Date may be used to express temporal information at any level of granularity.  Recommended practice is to express the date, date/time, or period of time according to ISO 8601-1 [[ISO 8601-1](https://www.iso.org/iso-8601-date-and-time-format.html)] or a published profile of the ISO standard, such as the W3C Note on Date and Time Formats [[W3CDTF](https://www.w3.org/TR/NOTE-datetime)] or the Extended Date/Time Format Specification [[EDTF](http://www.loc.gov/standards/datetime/)].  If the full date is unknown, month and year (YYYY-MM) or just year (YYYY) may be used. Date ranges may be specified using ISO 8601 period of time specification in which start and end dates are separated by a '/' (slash) character.  Either the start or end date may be missing.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A point or period of time associated with an event in the lifecycle of the resource.</para>
    ///   <para>rdfs:label : Date</para>
    ///   <a href="http://purl.org/dc/terms/date">dcterms:date</a>
    /// </summary>
    let date = dctermsVocabulary.prefixId.prefix "date"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to describe the date, date/time, or period of time as recommended for the property Date, of which this is a subproperty.  Examples of resources to which a date of acceptance may be relevant are a thesis (accepted by a university department) or an article (accepted by a journal).</para>
    ///   <para>dcterms:issued : 2002-07-13^^xsd:date</para>
    ///   <para>rdfs:comment : Date of acceptance of the resource.</para>
    ///   <para>rdfs:label : Date Accepted</para>
    ///   <a href="http://purl.org/dc/terms/dateAccepted">dcterms:dateAccepted</a>
    /// </summary>
    let dateAccepted = dctermsVocabulary.prefixId.prefix "dateAccepted"
    /// <summary>
    ///   <para>dcterms:description : Typically a year.  Recommended practice is to describe the date, date/time, or period of time as recommended for the property Date, of which this is a subproperty.</para>
    ///   <para>dcterms:issued : 2002-07-13^^xsd:date</para>
    ///   <para>rdfs:comment : Date of copyright of the resource.</para>
    ///   <para>rdfs:label : Date Copyrighted</para>
    ///   <a href="http://purl.org/dc/terms/dateCopyrighted">dcterms:dateCopyrighted</a>
    /// </summary>
    let dateCopyrighted = dctermsVocabulary.prefixId.prefix "dateCopyrighted"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to describe the date, date/time, or period of time as recommended for the property Date, of which this is a subproperty.  Examples of resources to which a 'Date Submitted' may be relevant include a thesis (submitted to a university department) or an article (submitted to a journal).</para>
    ///   <para>dcterms:issued : 2002-07-13^^xsd:date</para>
    ///   <para>rdfs:comment : Date of submission of the resource.</para>
    ///   <para>rdfs:label : Date Submitted</para>
    ///   <a href="http://purl.org/dc/terms/dateSubmitted">dcterms:dateSubmitted</a>
    /// </summary>
    let dateSubmitted = dctermsVocabulary.prefixId.prefix "dateSubmitted"
    /// <summary>
    ///   <para>dcterms:description : Description may include but is not limited to: an abstract, a table of contents, a graphical representation, or a free-text account of the resource.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : An account of the resource.</para>
    ///   <para>rdfs:label : Description</para>
    ///   <a href="http://purl.org/dc/terms/description">dcterms:description</a>
    /// </summary>
    let description = dctermsVocabulary.prefixId.prefix "description"
    /// <summary>
    ///   <para>dcterms:issued : 2002-07-13^^xsd:date</para>
    ///   <para>rdfs:comment : A class of agents, defined in terms of progression through an educational or training context, for which the described resource is intended.</para>
    ///   <para>rdfs:label : Audience Education Level</para>
    ///   <a href="http://purl.org/dc/terms/educationLevel">dcterms:educationLevel</a>
    /// </summary>
    let educationLevel = dctermsVocabulary.prefixId.prefix "educationLevel"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to specify the file size in megabytes and duration in ISO 8601 format.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : The size or duration of the resource.</para>
    ///   <para>rdfs:label : Extent</para>
    ///   <a href="http://purl.org/dc/terms/extent">dcterms:extent</a>
    /// </summary>
    let extent = dctermsVocabulary.prefixId.prefix "extent"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to use a controlled vocabulary where available. For example, for file formats one could use the list of Internet Media Types [[MIME](https://www.iana.org/assignments/media-types/media-types.xhtml)].  Examples of dimensions include size and duration.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : The file format, physical medium, or dimensions of the resource.</para>
    ///   <para>rdfs:label : Format</para>
    ///   <a href="http://purl.org/dc/terms/format">dcterms:format</a>
    /// </summary>
    let format = dctermsVocabulary.prefixId.prefix "format"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. This property is an inverse property of Is Format Of.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that is substantially the same as the pre-existing described resource, but in another format.</para>
    ///   <para>rdfs:label : Has Format</para>
    ///   <a href="http://purl.org/dc/terms/hasFormat">dcterms:hasFormat</a>
    /// </summary>
    let hasFormat = dctermsVocabulary.prefixId.prefix "hasFormat"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. This property is an inverse property of Is Part Of.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that is included either physically or logically in the described resource.</para>
    ///   <para>rdfs:label : Has Part</para>
    ///   <a href="http://purl.org/dc/terms/hasPart">dcterms:hasPart</a>
    /// </summary>
    let hasPart = dctermsVocabulary.prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>dcterms:description : Changes in version imply substantive changes in content rather than differences in format. This property is intended to be used with non-literal values. This property is an inverse property of Is Version Of.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that is a version, edition, or adaptation of the described resource.</para>
    ///   <para>rdfs:label : Has Version</para>
    ///   <a href="http://purl.org/dc/terms/hasVersion">dcterms:hasVersion</a>
    /// </summary>
    let hasVersion = dctermsVocabulary.prefixId.prefix "hasVersion"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to identify the resource by means of a string conforming to an identification system. Examples include International Standard Book Number (ISBN), Digital Object Identifier (DOI), and Uniform Resource Name (URN).  Persistent identifiers should be provided as HTTP URIs.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : An unambiguous reference to the resource within a given context.</para>
    ///   <para>rdfs:label : Identifier</para>
    ///   <a href="http://purl.org/dc/terms/identifier">dcterms:identifier</a>
    /// </summary>
    let identifier = dctermsVocabulary.prefixId.prefix "identifier"
    /// <summary>
    ///   <para>dcterms:description : Instructional Method typically includes ways of presenting instructional materials or conducting instructional activities, patterns of learner-to-learner and learner-to-instructor interactions, and mechanisms by which group and individual levels of learning are measured.  Instructional methods include all aspects of the instruction and learning processes from planning and implementation through evaluation and feedback.</para>
    ///   <para>dcterms:issued : 2005-06-13^^xsd:date</para>
    ///   <para>rdfs:comment : A process, used to engender knowledge, attitudes and skills, that the described resource is designed to support.</para>
    ///   <para>rdfs:label : Instructional Method</para>
    ///   <a href="http://purl.org/dc/terms/instructionalMethod">dcterms:instructionalMethod</a>
    /// </summary>
    let instructionalMethod = dctermsVocabulary.prefixId.prefix "instructionalMethod"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. This property is an inverse property of Has Format.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A pre-existing related resource that is substantially the same as the described resource, but in another format.</para>
    ///   <para>rdfs:label : Is Format Of</para>
    ///   <a href="http://purl.org/dc/terms/isFormatOf">dcterms:isFormatOf</a>
    /// </summary>
    let isFormatOf = dctermsVocabulary.prefixId.prefix "isFormatOf"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. This property is an inverse property of Has Part.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource in which the described resource is physically or logically included.</para>
    ///   <para>rdfs:label : Is Part Of</para>
    ///   <a href="http://purl.org/dc/terms/isPartOf">dcterms:isPartOf</a>
    /// </summary>
    let isPartOf = dctermsVocabulary.prefixId.prefix "isPartOf"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. This property is an inverse property of References.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that references, cites, or otherwise points to the described resource.</para>
    ///   <para>rdfs:label : Is Referenced By</para>
    ///   <a href="http://purl.org/dc/terms/isReferencedBy">dcterms:isReferencedBy</a>
    /// </summary>
    let isReferencedBy = dctermsVocabulary.prefixId.prefix "isReferencedBy"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. This property is an inverse property of Replaces.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that supplants, displaces, or supersedes the described resource.</para>
    ///   <para>rdfs:label : Is Replaced By</para>
    ///   <a href="http://purl.org/dc/terms/isReplacedBy">dcterms:isReplacedBy</a>
    /// </summary>
    let isReplacedBy = dctermsVocabulary.prefixId.prefix "isReplacedBy"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. This property is an inverse property of Requires.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that requires the described resource to support its function, delivery, or coherence.</para>
    ///   <para>rdfs:label : Is Required By</para>
    ///   <a href="http://purl.org/dc/terms/isRequiredBy">dcterms:isRequiredBy</a>
    /// </summary>
    let isRequiredBy = dctermsVocabulary.prefixId.prefix "isRequiredBy"
    /// <summary>
    ///   <para>dcterms:description : Changes in version imply substantive changes in content rather than differences in format. This property is intended to be used with non-literal values. This property is an inverse property of Has Version.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource of which the described resource is a version, edition, or adaptation.</para>
    ///   <para>rdfs:label : Is Version Of</para>
    ///   <a href="http://purl.org/dc/terms/isVersionOf">dcterms:isVersionOf</a>
    /// </summary>
    let isVersionOf = dctermsVocabulary.prefixId.prefix "isVersionOf"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to describe the date, date/time, or period of time as recommended for the property Date, of which this is a subproperty.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : Date of formal issuance of the resource.</para>
    ///   <para>rdfs:label : Date Issued</para>
    ///   <a href="http://purl.org/dc/terms/issued">dcterms:issued</a>
    /// </summary>
    let issued = dctermsVocabulary.prefixId.prefix "issued"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to use either a non-literal value representing a language from a controlled vocabulary such as ISO 639-2 or ISO 639-3, or a literal value consisting of an IETF Best Current Practice 47 [[IETF-BCP47](https://tools.ietf.org/html/bcp47)] language tag.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A language of the resource.</para>
    ///   <para>rdfs:label : Language</para>
    ///   <a href="http://purl.org/dc/terms/language">dcterms:language</a>
    /// </summary>
    let language = dctermsVocabulary.prefixId.prefix "language"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to identify the license document with a URI. If this is not possible or feasible, a literal value that identifies the license may be provided.</para>
    ///   <para>dcterms:issued : 2004-06-14^^xsd:date</para>
    ///   <para>rdfs:comment : A legal document giving official permission to do something with the resource.</para>
    ///   <para>rdfs:label : License</para>
    ///   <a href="http://purl.org/dc/terms/license">dcterms:license</a>
    /// </summary>
    let license = dctermsVocabulary.prefixId.prefix "license"
    /// <summary>
    ///   <para>dcterms:description : In an educational context, a mediator might be a parent, teacher, teaching assistant, or care-giver.</para>
    ///   <para>dcterms:issued : 2001-05-21^^xsd:date</para>
    ///   <para>rdfs:comment : An entity that mediates access to the resource.</para>
    ///   <para>rdfs:label : Mediator</para>
    ///   <a href="http://purl.org/dc/terms/mediator">dcterms:mediator</a>
    /// </summary>
    let mediator = dctermsVocabulary.prefixId.prefix "mediator"
    /// <summary>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : The material or physical carrier of the resource.</para>
    ///   <para>rdfs:label : Medium</para>
    ///   <a href="http://purl.org/dc/terms/medium">dcterms:medium</a>
    /// </summary>
    let medium = dctermsVocabulary.prefixId.prefix "medium"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to describe the date, date/time, or period of time as recommended for the property Date, of which this is a subproperty.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : Date on which the resource was changed.</para>
    ///   <para>rdfs:label : Date Modified</para>
    ///   <a href="http://purl.org/dc/terms/modified">dcterms:modified</a>
    /// </summary>
    let modified = dctermsVocabulary.prefixId.prefix "modified"
    /// <summary>
    ///   <para>dcterms:description : The statement may include a description of any changes successive custodians made to the resource.</para>
    ///   <para>dcterms:issued : 2004-09-20^^xsd:date</para>
    ///   <para>rdfs:comment : A statement of any changes in ownership and custody of the resource since its creation that are significant for its authenticity, integrity, and interpretation.</para>
    ///   <para>rdfs:label : Provenance</para>
    ///   <a href="http://purl.org/dc/terms/provenance">dcterms:provenance</a>
    /// </summary>
    let provenance = dctermsVocabulary.prefixId.prefix "provenance"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : An entity responsible for making the resource available.</para>
    ///   <para>rdfs:label : Publisher</para>
    ///   <a href="http://purl.org/dc/terms/publisher">dcterms:publisher</a>
    /// </summary>
    let publisher = dctermsVocabulary.prefixId.prefix "publisher"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. This property is an inverse property of Is Referenced By.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that is referenced, cited, or otherwise pointed to by the described resource.</para>
    ///   <para>rdfs:label : References</para>
    ///   <a href="http://purl.org/dc/terms/references">dcterms:references</a>
    /// </summary>
    let references = dctermsVocabulary.prefixId.prefix "references"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to identify the related resource by means of a URI.  If this is not possible or feasible, a string conforming to a formal identification system may be provided.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource.</para>
    ///   <para>rdfs:label : Relation</para>
    ///   <a href="http://purl.org/dc/terms/relation">dcterms:relation</a>
    /// </summary>
    let relation = dctermsVocabulary.prefixId.prefix "relation"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. This property is an inverse property of Is Replaced By.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that is supplanted, displaced, or superseded by the described resource.</para>
    ///   <para>rdfs:label : Replaces</para>
    ///   <a href="http://purl.org/dc/terms/replaces">dcterms:replaces</a>
    /// </summary>
    let replaces = dctermsVocabulary.prefixId.prefix "replaces"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. This property is an inverse property of Is Required By.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that is required by the described resource to support its function, delivery, or coherence.</para>
    ///   <para>rdfs:label : Requires</para>
    ///   <a href="http://purl.org/dc/terms/requires">dcterms:requires</a>
    /// </summary>
    let requires = dctermsVocabulary.prefixId.prefix "requires"
    /// <summary>
    ///   <para>dcterms:description : Typically, rights information includes a statement about various property rights associated with the resource, including intellectual property rights.  Recommended practice is to refer to a rights statement with a URI.  If this is not possible or feasible, a literal value (name, label, or short text) may be provided.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : Information about rights held in and over the resource.</para>
    ///   <para>rdfs:label : Rights</para>
    ///   <a href="http://purl.org/dc/terms/rights">dcterms:rights</a>
    /// </summary>
    let rights = dctermsVocabulary.prefixId.prefix "rights"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to refer to the rights holder with a URI. If this is not possible or feasible, a literal value that identifies the rights holder may be provided.</para>
    ///   <para>dcterms:issued : 2004-06-14^^xsd:date</para>
    ///   <para>rdfs:comment : A person or organization owning or managing rights over the resource.</para>
    ///   <para>rdfs:label : Rights Holder</para>
    ///   <a href="http://purl.org/dc/terms/rightsHolder">dcterms:rightsHolder</a>
    /// </summary>
    let rightsHolder = dctermsVocabulary.prefixId.prefix "rightsHolder"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. The described resource may be derived from the related resource in whole or in part. Best practice is to identify the related resource by means of a URI or a string conforming to a formal identification system.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource from which the described resource is derived.</para>
    ///   <para>rdfs:label : Source</para>
    ///   <a href="http://purl.org/dc/terms/source">dcterms:source</a>
    /// </summary>
    let source = dctermsVocabulary.prefixId.prefix "source"
    /// <summary>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : Spatial characteristics of the resource.</para>
    ///   <para>rdfs:label : Spatial Coverage</para>
    ///   <a href="http://purl.org/dc/terms/spatial">dcterms:spatial</a>
    /// </summary>
    let spatial = dctermsVocabulary.prefixId.prefix "spatial"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to refer to the subject with a URI. If this is not possible or feasible, a literal value that identifies the subject may be provided. Both should preferably refer to a subject in a controlled vocabulary.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A topic of the resource.</para>
    ///   <para>rdfs:label : Subject</para>
    ///   <a href="http://purl.org/dc/terms/subject">dcterms:subject</a>
    /// </summary>
    let subject = dctermsVocabulary.prefixId.prefix "subject"
    /// <summary>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A list of subunits of the resource.</para>
    ///   <para>rdfs:label : Table Of Contents</para>
    ///   <a href="http://purl.org/dc/terms/tableOfContents">dcterms:tableOfContents</a>
    /// </summary>
    let tableOfContents = dctermsVocabulary.prefixId.prefix "tableOfContents"
    /// <summary>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : Temporal characteristics of the resource.</para>
    ///   <para>rdfs:label : Temporal Coverage</para>
    ///   <a href="http://purl.org/dc/terms/temporal">dcterms:temporal</a>
    /// </summary>
    let temporal = dctermsVocabulary.prefixId.prefix "temporal"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A name given to the resource.</para>
    ///   <para>rdfs:label : Title</para>
    ///   <a href="http://purl.org/dc/terms/title">dcterms:title</a>
    /// </summary>
    let title = dctermsVocabulary.prefixId.prefix "title"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to use a controlled vocabulary such as the DCMI Type Vocabulary [[DCMI-TYPE](http://dublincore.org/documents/dcmi-type-vocabulary/)]. To describe the file format, physical medium, or dimensions of the resource, use the property Format.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : The nature or genre of the resource.</para>
    ///   <para>rdfs:label : Type</para>
    ///   <a href="http://purl.org/dc/terms/type">dcterms:type</a>
    /// </summary>
    let type_ = dctermsVocabulary.prefixId.prefix "type"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to describe the date, date/time, or period of time as recommended for the property Date, of which this is a subproperty.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : Date (often a range) of validity of a resource.</para>
    ///   <para>rdfs:label : Date Valid</para>
    ///   <a href="http://purl.org/dc/terms/valid">dcterms:valid</a>
    /// </summary>
    let valid = dctermsVocabulary.prefixId.prefix "valid"


module dcat =
    /// <summary>
    ///   <para>rdfs:comment : A curated collection of metadata about resources (e.g., datasets and data services in the context of a data catalog).rdfs:comment : Una colección curada de metadatos sobre recursos (por ejemplo, conjuntos de datos y servicios de datos en el contexto de un catálogo de datos).rdfs:comment : Una raccolta curata di metadati sulle risorse (ad es. sui dataset e relativi servizi nel contesto di cataloghi di dati).rdfs:comment : Une collection élaborée de métadonnées sur les jeux de donnéesrdfs:comment : Řízená kolekce metadat o datových sadách a datových službáchrdfs:comment : Μια επιμελημένη συλλογή μεταδεδομένων περί συνόλων δεδομένωνrdfs:comment : مجموعة من توصيفات قوائم البياناتrdfs:comment : データ・カタログは、データセットに関するキュレートされたメタデータの集合です。rdfs:comment : En udvalgt og arrangeret samling af metadata om ressourcer (fx datasæt og datatjenester i kontekst af et datakatalog). </para>
    ///   <para>rdfs:label : Catalogrdfs:label : Catalogordfs:label : Cataloguerdfs:label : Catálogordfs:label : Katalogrdfs:label : Κατάλογοςrdfs:label : فهرس قوائم البياناتrdfs:label : カタログrdfs:label : Katalog</para>
    ///   <para>skos:definition : A curated collection of metadata about resources.skos:definition : Una colección curada de metadatos sobre recursos.skos:definition : Una raccolta curata di metadati sulle risorse.skos:definition : Une collection élaborée de métadonnées sur les jeux de données.skos:definition : Řízená kolekce metadat o datových sadách a datových službách.skos:definition : Μια επιμελημένη συλλογή μεταδεδομένων περί συνόλων δεδομένων.skos:definition : مجموعة من توصيفات قوائم البياناتskos:definition : データ・カタログは、データセットに関するキュレートされたメタデータの集合です。skos:definition : En samling af metadata om ressourcer.</para>
    ///   <para>skos:editorialNote : Multilingual text not completelly updated. Translations for skos:scopeNote and definitions to doublecheck.</para>
    ///   <para>skos:scopeNote : A web-based data catalog is typically represented as a single instance of this class.skos:scopeNote : Normalmente, un catalogo di dati nel web viene rappresentato come una singola istanza di questa classe.skos:scopeNote : Normalmente, un catálogo de datos disponible en la web se representa como una única instancia de esta clase.skos:scopeNote : Webový datový katalog je typicky reprezentován jako jedna instance této třídy.skos:scopeNote : Συνήθως, ένας κατάλογος δεδομένων στον Παγκόσμιο Ιστό αναπαρίσταται ως ένα στιγμιότυπο αυτής της κλάσης.skos:scopeNote : 通常、ウェブ・ベースのデータ・カタログは、このクラスの1つのインスタンスとして表わされます。skos:scopeNote : Et webbaseret datakatalog repræsenteres typisk ved en enkelt instans af denne klasse.skos:scopeNote : Datasets and data services are examples of resources in the context of a data catalog.</para>
    ///   <a href="http://www.w3.org/ns/dcat#Catalog">ns0:Catalog</a>
    /// </summary>
    let Catalog = dcatVocabulary.prefixId.prefix "Catalog"
    /// <summary>
    ///   <para>rdfs:comment : 1つのデータセットを記述したデータ・カタログ内のレコード。rdfs:comment : A record in a data catalog, describing the registration of a single dataset or data service.rdfs:comment : Un record in un catalogo di dati che descrive un singolo dataset o servizio di dati.rdfs:comment : Un registre du catalogue ou une entrée du catalogue, décrivant un seul jeu de données.rdfs:comment : Un registro en un catálogo de datos que describe un solo conjunto de datos o un servicio de datos.rdfs:comment : Záznam v datovém katalogu popisující jednu datovou sadu či datovou službu.rdfs:comment : Μία καταγραφή ενός καταλόγου, η οποία περιγράφει ένα συγκεκριμένο σύνολο δεδομένων.rdfs:comment : En post i et datakatalog der beskriver registreringen af et enkelt datasæt eller en datatjeneste.</para>
    ///   <para>rdfs:label : Catalog Recordrdfs:label : Katalogizační záznamrdfs:label : Record di catalogordfs:label : Registre du cataloguerdfs:label : Registro del catálogordfs:label : Καταγραφή καταλόγουrdfs:label : سجلrdfs:label : カタログ・レコードrdfs:label : Katalogpost</para>
    ///   <para>skos:definition : 1つのデータセットを記述したデータ・カタログ内のレコード。skos:definition : A record in a data catalog, describing the registration of a single dataset or data service.skos:definition : Un record in un catalogo di dati che descrive un singolo dataset o servizio di dati.skos:definition : Un registre du catalogue ou une entrée du catalogue, décrivant un seul jeu de données.skos:definition : Un registro en un catálogo de datos que describe un solo conjunto de datos o un servicio de datos.skos:definition : Záznam v datovém katalogu popisující jednu datovou sadu či datovou službu.skos:definition : Μία καταγραφή ενός καταλόγου, η οποία περιγράφει ένα συγκεκριμένο σύνολο δεδομένων.skos:definition : En post i et datakatalog der beskriver registreringen af et enkelt datasæt eller en datatjeneste.</para>
    ///   <para>skos:editorialNote : English definition updated in this revision. Multilingual text not yet updated except the Spanish one and the Czech one and Italian one.</para>
    ///   <para>skos:scopeNote : C'est une classe facultative et tous les catalogues ne l'utiliseront pas. Cette classe existe pour les catalogues	ayant une distinction entre les métadonnées sur le jeu de données et les métadonnées sur une entrée du jeu de données dans le catalogue.skos:scopeNote : Esta clase es opcional y no todos los catálogos la utilizarán. Esta clase existe para catálogos que hacen una distinción entre los metadatos acerca de un conjunto de datos o un servicio de datos y los metadatos acerca de una entrada en ese conjunto de datos en el catálogo. Por ejemplo, la propiedad sobre la fecha de la publicación de los datos refleja la fecha en que la información fue originalmente publicada, mientras que la fecha de publicación del registro del catálogo es la fecha en que los datos se agregaron al mismo. En caso en que ambas fechas fueran diferentes, o en que sólo la fecha de publicación del registro del catálogo estuviera disponible, sólo debe especificarse en el registro del catálogo. Tengan en cuenta que la ontología PROV de W3C permite describir otra información sobre la proveniencia de los datos, como por ejemplo detalles del proceso y de los agentes involucrados en algún cambio específico a los datos.skos:scopeNote : Questa classe è opzionale e non tutti i cataloghi la utilizzeranno. Esiste per cataloghi in cui si opera una distinzione tra i metadati relativi al dataset ed i metadati relativi alla gestione del dataset nel catalogo. Ad esempio, la  proprietà per indicare la data di pubblicazione del dataset rifletterà la data in cui l'informazione è stata originariamente messa a disposizione dalla casa editrice, mentre la data di pubblicazione per il record nel catalogo rifletterà la data in cui il dataset è stato aggiunto al catalogo. Nei casi dove solo quest'ultima sia nota, si utilizzerà esclusivamente la data di  pubblicazione relativa al record del catalogo. Si noti che l'Ontologia W3C PROV permette di descrivere ulteriori informazioni sulla provenienza, quali i dettagli del processo, la procedura e l'agente coinvolto in una particolare modifica di un dataset.skos:scopeNote : Tato třída je volitelná a ne všechny katalogy ji využijí. Existuje pro katalogy, ve kterých se rozlišují metadata datové sady či datové služby a metadata o záznamu o datové sadě či datové službě v katalogu. Například datum publikace datové sady odráží datum, kdy byla datová sada původně zveřejněna poskytovatelem dat, zatímco datum publikace katalogizačního záznamu je datum zanesení datové sady do katalogu. V případech kdy se obě data liší, nebo je známo jen to druhé, by mělo být specifikováno jen datum publikace katalogizačního záznamu. Všimněte si, že ontologie W3C PROV umožňuje popsat další informace o původu jako například podrobnosti o procesu konkrétní změny datové sady a jeho účastnících.skos:scopeNote : This class is optional and not all catalogs will use it. It exists for catalogs where a distinction is made between metadata about a dataset or data service and metadata about the entry for the dataset or data service in the catalog. For example, the publication date property of the dataset reflects the date when the information was originally made available by the publishing agency, while the publication date of the catalog record is the date when the dataset was added to the catalog. In cases where both dates differ, or where only the latter is known, the publication date should only be specified for the catalog record. Notice that the W3C PROV Ontology allows describing further provenance information such as the details of the process and the agent involved in a particular change to a dataset.skos:scopeNote : Αυτή η κλάση είναι προαιρετική και δεν χρησιμοποιείται από όλους τους καταλόγους. Υπάρχει για τις περιπτώσεις καταλόγων όπου γίνεται διαχωρισμός μεταξύ των μεταδεδομένων για το σύνολο των δεδομένων και των μεταδεδομένων για την καταγραφή του συνόλου δεδομένων εντός του καταλόγου. Για παράδειγμα, η ιδιότητα της ημερομηνίας δημοσίευσης του συνόλου δεδομένων δείχνει την ημερομηνία κατά την οποία οι πληροφορίες έγιναν διαθέσιμες από τον φορέα δημοσίευσης, ενώ η ημερομηνία δημοσίευσης της καταγραφής του καταλόγου δείχνει την ημερομηνία που το σύνολο δεδομένων προστέθηκε στον κατάλογο. Σε περιπτώσεις που οι δύο ημερομηνίες διαφέρουν, ή που μόνο η τελευταία είναι γνωστή, η ημερομηνία δημοσίευσης θα πρέπει να δίνεται για την καταγραφή του καταλόγου. Να σημειωθεί πως η οντολογία W3C PROV επιτρέπει την περιγραφή επιπλέον πληροφοριών ιστορικού όπως λεπτομέρειες για τη διαδικασία και τον δράστη που εμπλέκονται σε μία συγκεκριμένη αλλαγή εντός του συνόλου δεδομένων.skos:scopeNote : このクラスはオプションで、すべてのカタログがそれを用いるとは限りません。これは、データセットに関するメタデータとカタログ内のデータセットのエントリーに関するメタデータとで区別が行われるカタログのために存在しています。例えば、データセットの公開日プロパティーは、公開機関が情報を最初に利用可能とした日付を示しますが、カタログ・レコードの公開日は、データセットがカタログに追加された日付です。両方の日付が異っていたり、後者だけが分かっている場合は、カタログ・レコードに対してのみ公開日を指定すべきです。W3CのPROVオントロジー[prov-o]を用いれば、データセットに対する特定の変更に関連するプロセスやエージェントの詳細などの、さらに詳しい来歴情報の記述が可能となることに注意してください。skos:scopeNote : Denne klasse er valgfri og ikke alle kataloger vil anvende denne klasse. Den kan anvendes i de kataloger hvor der skelnes mellem metadata om datasættet eller datatjenesten og metadata om selve posten til registreringen af datasættet eller datatjenesten i kataloget. Udgivelsesdatoen for datasættet afspejler for eksempel den dato hvor informationerne oprindeligt blev gjort tilgængelige af udgiveren, hvorimod udgivelsesdatoen for katalogposten er den dato hvor datasættet blev føjet til kataloget. I de tilfælde hvor de to datoer er forskellige eller hvor blot sidstnævnte er kendt, bør udgivelsesdatoen kun angives for katalogposten. Bemærk at W3Cs PROV ontologi gør til muligt at tilføje yderligere proveniensoplysninger eksempelvis om processen eller aktøren involveret i en given ændring af datasættet.</para>
    ///   <a href="http://www.w3.org/ns/dcat#CatalogRecord">ns0:CatalogRecord</a>
    /// </summary>
    let CatalogRecord = dcatVocabulary.prefixId.prefix "CatalogRecord"
    /// <summary>
    ///   <para>rdfs:comment : A site or end-point providing operations related to the discovery of, access to, or processing functions on, data or related resources.rdfs:comment : Umístění či přístupový bod poskytující operace související s hledáním, přistupem k, či výkonem funkcí na datech či souvisejících zdrojích.rdfs:comment : Un sitio o end-point que provee operaciones relacionadas a funciones de descubrimiento, acceso, o procesamiento de datos o recursos relacionados.rdfs:comment : Un sito o end-point che fornisce operazioni relative alla scoperta, all'accesso o all'elaborazione di funzioni su dati o risorse correlate.rdfs:comment : Et websted eller endpoint der udstiller operationer relateret til opdagelse af, adgang til eller behandlende funktioner på data eller relaterede ressourcer.</para>
    ///   <para>rdfs:label : Data servicerdfs:label : Servizio di datirdfs:label : Servicio de datosrdfs:label : Datatjeneste</para>
    ///   <para>skos:altLabel : Dataservice</para>
    ///   <para>skos:changeNote : New class added in DCAT 2.skos:changeNote : Nová třída přidaná ve verzi DCAT 2.skos:changeNote : Nueva clase añadida en DCAT 2.skos:changeNote : Nuova classe aggiunta in DCAT 2.skos:changeNote : Ny klasse tilføjet i DCAT 2.</para>
    ///   <para>skos:definition : A site or end-point providing operations related to the discovery of, access to, or processing functions on, data or related resources.skos:definition : Umístění či přístupový bod poskytující operace související s hledáním, přistupem k, či výkonem funkcí na datech či souvisejících zdrojích.skos:definition : Un sitio o end-point que provee operaciones relacionadas a funciones de descubrimiento, acceso, o procesamiento de datos o recursos relacionados.skos:definition : Un sito o end-point che fornisce operazioni relative alla scoperta, all'accesso o all'elaborazione di funzioni su dati o risorse correlate.skos:definition : Et site eller endpoint der udstiller operationer relateret til opdagelse af, adgang til eller behandlende funktioner på data eller relaterede ressourcer.</para>
    ///   <para>skos:scopeNote : Druh služby může být indikován vlastností dcterms:type. Její hodnota může být z řízeného slovníku, kterým je například slovník typů prostorových datových služeb INSPIRE.skos:scopeNote : El tipo de servicio puede indicarse usando la propiedad dcterms:type. Su valor puede provenir de un vocabulario controlado, como por ejemplo el vocabulario de servicios de datos espaciales de INSPIRE.skos:scopeNote : If a dcat:DataService is bound to one or more specified Datasets, they are indicated by the dcat:servesDataset property.skos:scopeNote : Il tipo di servizio può essere indicato usando la proprietà dcterms:type. Il suo valore può essere preso da un vocabolario controllato come il vocabolario dei tipi di servizi per dati spaziali di INSPIRE.skos:scopeNote : Pokud je dcat:DataService navázána na jednu či více Datových sad, jsou tyto indikovány vlstností dcat:servesDataset.skos:scopeNote : Se un dcat:DataService è associato a uno o più Dataset specificati, questi sono indicati dalla proprietà dcat:serveDataset.skos:scopeNote : Si un dcat:DataService está asociado con uno o más conjuntos de datos especificados, dichos conjuntos de datos pueden indicarse con la propiedad dcat:servesDataset.skos:scopeNote : The kind of service can be indicated using the dcterms:type property. Its value may be taken from a controlled vocabulary such as the INSPIRE spatial data service type vocabulary.skos:scopeNote : Datatjenestetypen kan indikeres ved hjælp af egenskaben dcterms:type. Værdien kan tages fra kontrollerede udfaldsrum såsom INSPIRE spatial data service vocabulary.skos:scopeNote : Hvis en dcat:DataService er bundet til en eller flere specifikke datasæt kan dette indikeres ved hjælp af egenskaben dcat:servesDataset. </para>
    ///   <a href="http://www.w3.org/ns/dcat#DataService">ns0:DataService</a>
    /// </summary>
    let DataService = dcatVocabulary.prefixId.prefix "DataService"
    /// <summary>
    ///   <para>rdfs:comment : 1つのエージェントによって公開またはキュレートされ、1つ以上の形式でアクセスまたはダウンロードできるデータの集合。rdfs:comment : A collection of data, published or curated by a single source, and available for access or download in one or more representations.rdfs:comment : Kolekce dat poskytovaná či řízená jedním zdrojem, která je k dispozici pro přístup či stažení v jednom či více formátech.rdfs:comment : Raccolta di dati, pubblicati o curati da un'unica fonte, disponibili per l'accesso o il download in uno o più formati.rdfs:comment : Una colección de datos, publicados o conservados por una única fuente, y disponibles para ser accedidos o descargados en uno o más formatos.rdfs:comment : Une collection de données, publiée ou élaborée par une seule source, et disponible pour accès ou téléchargement dans un ou plusieurs formats.rdfs:comment : Μία συλλογή από δεδομένα, δημοσιευμένη ή επιμελημένη από μία και μόνο πηγή, διαθέσιμη δε προς πρόσβαση ή μεταφόρτωση σε μία ή περισσότερες μορφές.rdfs:comment : قائمة بيانات منشورة أو مجموعة من قبل مصدر ما و متاح الوصول إليها أو تحميلهاrdfs:comment : En samling af data, udgivet eller udvalgt og arrangeret af en enkelt kilde og som er til råde for adgang til eller download af i en eller flere repræsentationer.</para>
    ///   <para>rdfs:label : Conjunto de datosrdfs:label : Datasetrdfs:label : Datasetrdfs:label : Datová sadardfs:label : Jeu de donnéesrdfs:label : Σύνολο Δεδομένωνrdfs:label : قائمة بياناتrdfs:label : データセットrdfs:label : Datasæt</para>
    ///   <para>skos:altLabel : Datasamling</para>
    ///   <para>skos:editorialNote : 2020-03-16 A new scopenote added and need to be translated</para>
    ///   <para>skos:changeNote : 2018-02 - odstraněno tvrzení o podtřídě dctype:Dataset, jelikož rozsah dcat:Dataset zahrnuje několik dalších typů ze slovníku dctype.skos:changeNote : 2018-02 - se eliminó el axioma de subclase con dctype:Dataset porque el alcance de dcat:Dataset incluye muchos otros tipos del vocabulario dctype.skos:changeNote : 2018-02 - subclass of dctype:Dataset removed because scope of dcat:Dataset includes several other types from the dctype vocabulary.skos:changeNote : 2018-02 - sottoclasse di dctype:Dataset rimosso perché l'ambito di dcat:Dataset include diversi altri tipi dal vocabolario dctype.skos:changeNote : 2018-02 - subklasse af dctype:Dataset fjernet da scope af dcat:Dataset omfatter flere forskellige typer fra dctype-vokabularet.</para>
    ///   <para>skos:definition : 1つのエージェントによって公開またはキュレートされ、1つ以上の形式でアクセスまたはダウンロードできるデータの集合。skos:definition : A collection of data, published or curated by a single source, and available for access or download in one or more representations.skos:definition : Kolekce dat poskytovaná či řízená jedním zdrojem, která je k dispozici pro přístup či stažení v jednom či více formátech.skos:definition : Raccolta di dati, pubblicati o curati da un'unica fonte, disponibili per l'accesso o il download in uno o più formati.skos:definition : Una colección de datos, publicados o conservados por una única fuente, y disponibles para ser accedidos o descargados en uno o más formatos.skos:definition : Une collection de données, publiée ou élaborée par une seule source, et disponible pour accès ou téléchargement dans un ou plusieurs formats.skos:definition : Μία συλλογή από δεδομένα, δημοσιευμένη ή επιμελημένη από μία και μόνο πηγή, διαθέσιμη δε προς πρόσβαση ή μεταφόρτωση σε μία ή περισσότερες μορφές.skos:definition : قائمة بيانات منشورة أو مجموعة من قبل مصدر ما و متاح الوصول إليها أو تحميلهاskos:definition : En samling a data, udgivet eller udvalgt og arrangeret af en enkelt kilde og som der er adgang til i en eller flere repræsentationer.</para>
    ///   <para>skos:scopeNote : Cette classe représente le jeu de données publié par le fournisseur de données. Dans les cas où une distinction est nécessaire entre le jeu de donénes et son entrée dans le catalogue, la classe registre de données peut être utilisée pour ce dernier.skos:scopeNote : Esta clase representa el conjunto de datos publicados. En los casos donde es necesario distinguir entre el conjunto de datos y su entrada en el catálogo de datos, se debe utilizar la clase 'registro del catálogo'.skos:scopeNote : Questa classe rappresenta il dataset come pubblicato dall’editore. Nel caso in cui sia necessario operare  una distinzione fra i metadati originali del dataset e il record dei metadati ad esso associato nel catalogo (ad esempio, per distinguere la data di modifica del dataset da quella del dataset nel catalogo) si può impiegare la classe catalog record.skos:scopeNote : Tato třída reprezentuje datovou sadu tak, jak je publikována poskytovatelem dat. V případě potřeby rozlišení datové sady a jejího katalogizačního záznamu (jelikož metadata jako datum modifikace se mohou lišit) pro něj může být použita třída "katalogizační záznam".skos:scopeNote : This class describes the conceptual dataset. One or more representations might be available, with differing schematic layouts and formats or serializations.skos:scopeNote : Questa classe descrive il dataset dal punto di vista concettuale. Possono essere disponibili una o più rappresentazioni, con diversi layout e formati schematici o serializzazioni.skos:scopeNote : This class represents the actual dataset as published by the dataset provider. In cases where a distinction between the actual dataset and its entry in the catalog is necessary (because metadata such as modification date and maintainer might differ), the catalog record class can be used for the latter.skos:scopeNote : Η κλάση αυτή αναπαριστά το σύνολο δεδομένων αυτό καθ'εαυτό, όπως έχει δημοσιευθεί από τον εκδότη. Σε περιπτώσεις όπου είναι απαραίτητος ο διαχωρισμός μεταξύ του συνόλου δεδομένων και της καταγραφής αυτού στον κατάλογο (γιατί μεταδεδομένα όπως η ημερομηνία αλλαγής και ο συντηρητής μπορεί να διαφέρουν) η κλάση της καταγραφής καταλόγου μπορεί να χρησιμοποιηθεί για το τελευταίο.skos:scopeNote : このクラスは、データセットの公開者が公開する実際のデータセットを表わします。カタログ内の実際のデータセットとそのエントリーとの区別が必要な場合（修正日と維持者などのメタデータが異なるかもしれないので）は、後者にcatalog recordというクラスを使用できます。skos:scopeNote : The notion of dataset in DCAT is broad and inclusive, with the intention of accommodating resource types arising from all communities. Data comes in many forms including numbers, text, pixels, imagery, sound and other multi-media, and potentially other types, any of which might be collected into a dataset.skos:scopeNote : Denne klasse repræsenterer det konkrete datasæt som det udgives af datasætleverandøren. I de tilfælde hvor det er nødvendigt at skelne mellem det konkrete datasæt og dets registrering i kataloget (fordi metadata såsom ændringsdato og vedligeholder er forskellige), så kan klassen katalogpost anvendes. skos:scopeNote : Denne klasse beskriver det konceptuelle datasæt. En eller flere repræsentationer kan være tilgængelige med forskellige skematiske opsætninger, formater eller serialiseringer.</para>
    ///   <a href="http://www.w3.org/ns/dcat#Dataset">ns0:Dataset</a>
    /// </summary>
    let Dataset = dcatVocabulary.prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>rdfs:comment : A collection of datasets that are published separately, but share some characteristics that group them.rdfs:comment : Una collezione di dataset che sono pubblicati separatamente, ma che condividono caratteristiche che li rendono parte di uno stesso gruppo.rdfs:comment : Una colección de conjuntos de datos publicados por separado, pero que comparten características que los agrupan.</para>
    ///   <para>rdfs:label : Dataset seriesrdfs:label : Serie de conjuntos de datosrdfs:label : Serie di dataset</para>
    ///   <para>skos:editorialNote : 2022-05-08 Added to ttl file with annotations in English, Spanish and Italian, except notes that are in other languages too.</para>
    ///   <para>skos:changeNote : New class added in DCAT 3.skos:changeNote : Nueva clase agregada en DCAT 3.skos:changeNote : Nová třída přidaná ve verzi DCAT 3skos:changeNote : Nuova classe aggiunta in DCAT 3skos:changeNote : Ny klasse tilføjet i DCAT 3</para>
    ///   <para>skos:definition : A collection of datasets that are published separately, but share some common characteristics that groups them.skos:definition : Una collezione di dataset che sono pubblicati separatamente, ma che condividono caratteristiche che li rendono parte di uno stesso gruppo.skos:definition : Una colección de conjuntos de datos publicados por separado, pero que comparten características comunes que los agrupan.</para>
    ///   <para>skos:scopeNote : Common scenarios for dataset series include: time series composed of periodically released subsets; map-series composed of items of the same type or theme but with differing spatial footprints.skos:scopeNote : Algunos escenarios comunes para series de conjuntos de datos son: series temporales compuestas de subconjuntos de datos publicados periódicamente; series de mapas compuestos de elementos del mismo tipo o tema pero con distintas huellas espaciales.skos:scopeNote : Scenari tipici per l'uso di serie di dataset: serie temporali costituite di dataset pubblicati regolarmente; serie di mappe costituite da elementi dello stesso tipo o tematica ma relative a differenti aree geografiche.skos:scopeNote : Dataset series can be also soft-typed via property dcterms:type as in the approach used in [GeoDCAT-AP], and adopted in [DCAT-AP-IT] and [GeoDCAT-AP-IT]).skos:scopeNote : También puede asignarse un tipo a las series de datos usando la propiedad dcterms:type como se hace en [GeoDCAT-AP], y adoptado en [DCAT-AP-IT] y [GeoDCAT-AP-IT]).skos:scopeNote : Le serie di dati possono anche essere denotate come tali usando la proprietà dcterms:type, secondo l'approccio usato in [GeoDCAT-AP], e adottato in [DCAT-AP-IT] e [GeoDCAT-AP-IT]).</para>
    ///   <a href="http://www.w3.org/ns/dcat#DatasetSeries">ns0:DatasetSeries</a>
    /// </summary>
    let DatasetSeries = dcatVocabulary.prefixId.prefix "DatasetSeries"
    /// <summary>
    ///   <para>rdfs:comment : A specific representation of a dataset. A dataset might be available in multiple serializations that may differ in various ways, including natural language, media-type or format, schematic organization, temporal and spatial resolution, level of detail or profiles (which might specify any or all of the above).rdfs:comment : Konkrétní reprezentace datové sady. Datová sada může být dostupná v různých serializacích, které se mohou navzájem lišit různými způsoby, mimo jiné přirozeným jazykem, media-typem či formátem, schematickou organizací, časovým a prostorovým rozlišením, úrovní detailu či profily (které mohou specifikovat některé či všechny tyto rozdíly).rdfs:comment : Rappresenta una forma disponibile e specifica del dataset. Ciascun dataset può essere disponibile in forme differenti, che possono rappresentare formati diversi o diversi punti di accesso per un dataset. Esempi di distribuzioni sono un file CSV scaricabile, una API o un RSS feed.rdfs:comment : Représente une forme spécifique d'un jeu de données. Caque jeu de données peut être disponible sous différentes formes, celles-ci pouvant représenter différents formats du jeu de données ou différents endpoint. Des exemples de distribution sont des fichirs CSV, des API ou des flux RSS.rdfs:comment : Una representación específica de los datos. Cada conjunto de datos puede estar disponible en formas diferentes, las cuáles pueden variar en distintas formas, incluyendo el idioma, 'media-type' o formato, organización esquemática, resolución temporal y espacial, nivel de detalle o perfiles (que pueden especificar cualquiera o todas las diferencias anteriores).rdfs:comment : Αναπαριστά μία συγκεκριμένη διαθέσιμη μορφή ενός συνόλου δεδομένων. Κάθε σύνολο δεδομενων μπορεί να είναι διαθέσιμο σε διαφορετικές μορφές, οι μορφές αυτές μπορεί να αναπαριστούν διαφορετικές μορφές αρχείων ή διαφορετικά σημεία διάθεσης. Παραδείγματα διανομών συμπεριλαμβάνουν ένα μεταφορτώσιμο αρχείο μορφής CSV, ένα API ή ένα RSS feed.rdfs:comment : شكل محدد لقائمة البيانات يمكن الوصول إليه. قائمة بيانات ما يمكن أن تكون متاحه باشكال و أنواع متعددة.  ملف يمكن تحميله أو واجهة برمجية يمكن من خلالها الوصول إلى البيانات هي أمثلة على ذلك.rdfs:comment : データセットの特定の利用可能な形式を表わします。各データセットは、異なる形式で利用できることがあり、これらの形式は、データセットの異なる形式や、異なるエンドポイントを表わす可能性があります。配信の例には、ダウンロード可能なCSVファイル、API、RSSフィードが含まれます。rdfs:comment : En specifik repræsentation af et datasæt. Et datasæt kan være tilgængelig i mange serialiseringer der kan variere på forskellige vis, herunder sprog, medietype eller format, systemorganisering, tidslig- og geografisk opløsning, detaljeringsniveau eller profiler (der kan specificere en eller flere af ovenstående).</para>
    ///   <para>rdfs:label : Distribucerdfs:label : Distribuciónrdfs:label : Distributionrdfs:label : Distributionrdfs:label : Distribuzionerdfs:label : Διανομήrdfs:label : التوزيعrdfs:label : 配信rdfs:label : Distribution</para>
    ///   <para>skos:altLabel : Datadistributionskos:altLabel : Datarepræsentationskos:altLabel : Datamanifestationskos:altLabel : Dataudstilling</para>
    ///   <para>skos:definition : A specific representation of a dataset. A dataset might be available in multiple serializations that may differ in various ways, including natural language, media-type or format, schematic organization, temporal and spatial resolution, level of detail or profiles (which might specify any or all of the above).skos:definition : Konkrétní reprezentace datové sady. Datová sada může být dostupná v různých serializacích, které se mohou navzájem lišit různými způsoby, mimo jiné přirozeným jazykem, media-typem či formátem, schematickou organizací, časovým a prostorovým rozlišením, úrovní detailu či profily (které mohou specifikovat některé či všechny tyto rozdíly).skos:definition : Rappresenta una forma disponibile e specifica del dataset. Ciascun dataset può essere disponibile in forme differenti, che possono rappresentare formati diversi o diversi punti di accesso per un dataset. Esempi di distribuzioni sono un file CSV scaricabile, una API o un RSS feed.skos:definition : Représente une forme spécifique d'un jeu de données. Caque jeu de données peut être disponible sous différentes formes, celles-ci pouvant représenter différents formats du jeu de données ou différents endpoint. Des exemples de distribution sont des fichirs CSV, des API ou des flux RSS.skos:definition : Una representación específica de los datos. Cada conjunto de datos puede estar disponible en formas diferentes, las cuáles pueden variar en distintas formas, incluyendo el idioma, 'media-type' o formato, organización esquemática, resolución temporal y espacial, nivel de detalle o perfiles (que pueden especificar cualquiera o todas las diferencias anteriores).skos:definition : Αναπαριστά μία συγκεκριμένη διαθέσιμη μορφή ενός συνόλου δεδομένων. Κάθε σύνολο δεδομενων μπορεί να είναι διαθέσιμο σε διαφορετικές μορφές, οι μορφές αυτές μπορεί να αναπαριστούν διαφορετικές μορφές αρχείων ή διαφορετικά σημεία διάθεσης. Παραδείγματα διανομών συμπεριλαμβάνουν ένα μεταφορτώσιμο αρχείο μορφής CSV, ένα API ή ένα RSS feed.skos:definition : شكل محدد لقائمة البيانات يمكن الوصول إليه. قائمة بيانات ما يمكن أن تكون متاحه باشكال و أنواع متعددة.  ملف يمكن تحميله أو واجهة برمجية يمكن من خلالها الوصول إلى البيانات هي أمثلة على ذلك.skos:definition : データセットの特定の利用可能な形式を表わします。各データセットは、異なる形式で利用できることがあり、これらの形式は、データセットの異なる形式や、異なるエンドポイントを表わす可能性があります。配信の例には、ダウンロード可能なCSVファイル、API、RSSフィードが含まれます。skos:definition : En specifik repræsentation af et datasæt. Et datasæt kan være tilgængelig i mange serialiseringer der kan variere på forskellige vis, herunder sprog, medietype eller format, systemorganisering, tidslig- og geografisk opløsning, detaljeringsniveau eller profiler (der kan specificere en eller flere af ovenstående).</para>
    ///   <para>skos:scopeNote : Ceci représente une disponibilité générale du jeu de données, et implique qu'il n'existe pas d'information sur la méthode d'accès réelle des données, par exple, si c'est un lien de téléchargement direct ou à travers une page Web.skos:scopeNote : Esta clase representa una disponibilidad general de un conjunto de datos, e implica que no existe información acerca del método de acceso real a los datos, i.e., si es un enlace de descarga directa o a través de una página Web.skos:scopeNote : Questa classe rappresenta una disponibilità generale di un dataset e non implica alcuna informazione sul metodo di accesso effettivo ai dati, ad esempio se si tratta di un accesso a download diretto, API, o attraverso una pagina Web. L'utilizzo della proprietà dcat:downloadURL indica distribuzioni direttamente scaricabili.skos:scopeNote : This represents a general availability of a dataset it implies no information about the actual access method of the data, i.e. whether by direct download, API, or through a Web page. The use of dcat:downloadURL property indicates directly downloadable distributions.skos:scopeNote : Toto popisuje obecnou dostupnost datové sady. Neimplikuje žádnou informaci o skutečné metodě přístupu k datům, tj. zda jsou přímo ke stažení, skrze API či přes webovou stránku. Použití vlastnosti dcat:downloadURL indikuje přímo stažitelné distribuce.skos:scopeNote : Αυτό αναπαριστά μία γενική διαθεσιμότητα ενός συνόλου δεδομένων και δεν υπονοεί τίποτα περί του πραγματικού τρόπου πρόσβασης στα δεδομένα, αν είναι άμεσα μεταφορτώσιμα, μέσω API ή μέσω μίας ιστοσελίδας. Η χρήση της ιδιότητας dcat:downloadURL δείχνει μόνο άμεσα μεταφορτώσιμες διανομές.skos:scopeNote : これは、データセットの一般的な利用可能性を表わし、データの実際のアクセス方式に関する情報（つまり、直接ダウンロードなのか、APIなのか、ウェブページを介したものなのか）を意味しません。dcat:downloadURLプロパティーの使用は、直接ダウンロード可能な配信を意味します。skos:scopeNote : Denne klasse repræsenterer datasættets overordnede tilgængelighed og giver ikke oplysninger om hvilken metode der kan anvendes til at få adgang til data, dvs. om adgang til datasættet realiseres ved direkte download, API eller via et websted. Anvendelsen af egenskaben dcat:downloadURL indikerer at distributionen kan downloades direkte.</para>
    ///   <a href="http://www.w3.org/ns/dcat#Distribution">ns0:Distribution</a>
    /// </summary>
    let Distribution = dcatVocabulary.prefixId.prefix "Distribution"
    /// <summary>
    ///   <para>rdfs:comment : An association class for attaching additional information to a relationship between DCAT Resources.rdfs:comment : Asociační třída pro připojení dodatečných informací ke vztahu mezi zdroji DCAT.rdfs:comment : Una clase de asociación para adjuntar información adicional a una relación entre recursos DCAT.rdfs:comment : Una classe di associazione per il collegamento di informazioni aggiuntive a una relazione tra le risorse DCAT.rdfs:comment : En associationsklasse til brug for tilknytning af yderligere information til en relation mellem DCAT-ressourcer.</para>
    ///   <para>rdfs:label : Relaciónrdfs:label : Relationshiprdfs:label : Relazionerdfs:label : Vztahrdfs:label : Relation</para>
    ///   <para>skos:changeNote : New class added in DCAT 2skos:changeNote : Nová třída přidaná ve verzi DCAT 2skos:changeNote : Nueva clase añadida en DCAT 2skos:changeNote : Nuova classe aggiunta in DCAT 2skos:changeNote : Ny klasse i DCAT 2</para>
    ///   <para>skos:definition : An association class for attaching additional information to a relationship between DCAT Resources.skos:definition : Asociační třída pro připojení dodatečných informací ke vztahu mezi zdroji DCAT.skos:definition : Una clase de asociación para adjuntar información adicional a una relación entre recursos DCAT.skos:definition : Una classe di associazione per il collegamento di informazioni aggiuntive a una relazione tra le risorse DCAT.skos:definition : En associationsklasse til brug for tilknytning af yderligere information til en relation mellem DCAT-ressourcer.</para>
    ///   <para>skos:scopeNote : Používá se pro charakterizaci vztahu mezi datovými sadami a případně i jinými zdroji, kde druh vztahu je sice znám, ale není přiměřeně charakterizován standardními vlastnostmi slovníku Dublin Core (dcterms:hasPart, dcterms:isPartOf, dcterms:conformsTo, dcterms:isFormatOf, dcterms:hasFormat, dcterms:isVersionOf, dcterms:hasVersion, dcterms:replaces, dcterms:isReplacedBy, dcterms:references, dcterms:isReferencedBy, dcterms:requires, dcterms:isRequiredBy) či vlastnostmi slovníku PROV-O (prov:wasDerivedFrom, prov:wasInfluencedBy, prov:wasQuotedFrom, prov:wasRevisionOf, prov:hadPrimarySource, prov:alternateOf, prov:specializationOf).skos:scopeNote : Se usa para caracterizar la relación entre conjuntos de datos, y potencialmente otros recursos, donde la naturaleza de la relación se conoce pero no está caracterizada adecuadamente con propiedades del estándar 'Dublin Core' (dcterms:hasPart, dcterms:isPartOf, dcterms:conformsTo, dcterms:isFormatOf, dcterms:hasFormat, dcterms:isVersionOf, dcterms:hasVersion, dcterms:replaces, dcterms:isReplacedBy, dcterms:references, dcterms:isReferencedBy, dcterms:requires, dcterms:isRequiredBy) or PROV-O properties (prov:wasDerivedFrom, prov:wasInfluencedBy, prov:wasQuotedFrom, prov:wasRevisionOf, prov:hadPrimarySource, prov:alternateOf, prov:specializationOf).skos:scopeNote : Use to characterize a relationship between datasets, and potentially other resources, where the nature of the relationship is known but is not adequately characterized by the standard Dublin Core properties (dcterms:hasPart, dcterms:isPartOf, dcterms:conformsTo, dcterms:isFormatOf, dcterms:hasFormat, dcterms:isVersionOf, dcterms:hasVersion, dcterms:replaces, dcterms:isReplacedBy, dcterms:references, dcterms:isReferencedBy, dcterms:requires, dcterms:isRequiredBy) or PROV-O properties (prov:wasDerivedFrom, prov:wasInfluencedBy, prov:wasQuotedFrom, prov:wasRevisionOf, prov:hadPrimarySource, prov:alternateOf, prov:specializationOf).skos:scopeNote : Viene utilizzato per caratterizzare la relazione tra insiemi di dati, e potenzialmente altri tipi di risorse, nei casi in cui la natura della relazione è nota ma non adeguatamente caratterizzata dalle proprietà dello standard 'Dublin Core' (dcterms:hasPart, dcterms:isPartOf, dcterms:conformsTo, dcterms:isFormatOf, dcterms:hasFormat, dcterms:isVersionOf, dcterms:hasVersion, dcterms:replaces, dcterms:isReplacedBy, dcterms:references, dcterms:isReferencedBy, dcterms:require, dcterms:isRequiredBy) o dalle propietà fornite da PROV-O  (prov:wasDerivedFrom, prov:wasInfluencedBy, prov:wasQuotedFrom, prov:wasRevisionOf, prov: hadPrimarySource, prov:alternateOf, prov:specializationOf).skos:scopeNote : Anvendes til at karakterisere en relation mellem datasæt, og potentielt andre ressourcer, hvor relationen er kendt men ikke tilstrækkeligt beskrevet af de standardiserede egenskaber i Dublin Core (dcterms:hasPart, dcterms:isPartOf, dcterms:conformsTo, dcterms:isFormatOf, dcterms:hasFormat, dcterms:isVersionOf, dcterms:hasVersion, dcterms:replaces, dcterms:isReplacedBy, dcterms:references, dcterms:isReferencedBy, dcterms:requires, dcterms:isRequiredBy) eller PROV-O-egenskaber (prov:wasDerivedFrom, prov:wasInfluencedBy, prov:wasQuotedFrom, prov:wasRevisionOf, prov:hadPrimarySource, prov:alternateOf, prov:specializationOf).</para>
    ///   <a href="http://www.w3.org/ns/dcat#Relationship">ns0:Relationship</a>
    /// </summary>
    let Relationship = dcatVocabulary.prefixId.prefix "Relationship"
    /// <summary>
    ///   <para>rdfs:comment : Recurso publicado o curado por un agente único.rdfs:comment : Resource published or curated by a single agent.rdfs:comment : Risorsa pubblicata o curata da un singolo agente.rdfs:comment : Zdroj publikovaný či řízený jediným činitelem.rdfs:comment : Ressource udgivet eller udvalgt og arrangeret af en enkelt aktør.</para>
    ///   <para>rdfs:label : Catalogued resourcerdfs:label : Katalogizovaný zdrojrdfs:label : Recurso catalogadordfs:label : Risorsa catalogatardfs:label : Katalogiseret ressource</para>
    ///   <para>skos:editorialNote : 2020-08-23 Scopenote updated  and needs to be translated</para>
    ///   <para>skos:changeNote : New class added in DCAT 2skos:changeNote : Nová třída přidaná ve verzi DCAT 2skos:changeNote : Nueva clase agregada en DCAT 2skos:changeNote : Nuova classe aggiunta in DCAT 2skos:changeNote : Ny klasse i DCAT 2</para>
    ///   <para>skos:definition : Recurso publicado o curado por un agente único.skos:definition : Resource published or curated by a single agent.skos:definition : Risorsa pubblicata o curata da un singolo agente.skos:definition : Zdroj publikovaný či řízený jediným činitelem.skos:definition : Ressource udgivet eller udvalgt og arrangeret af en enkelt aktør.</para>
    ///   <para>skos:scopeNote : La clase de todos los recursos catalogados, la superclase de dcat:Dataset, dcat:DataService, dcat:Catalog y cualquier otro miembro de un dcat:Catalog. Esta clase tiene propiedades comunes a todos los recursos catalogados, incluyendo conjuntos de datos y servicios de datos. Se recomienda fuertemente que se use una clase más específica. Cuando se describe un recurso que no es un dcat:Dataset o dcat:DataService, se recomienda crear una sub-clase apropiada de dcat:Resource, o usar dcat:Resource con la propiedad dcterms:type to indicar el tipo específico.skos:scopeNote : La classe di tutte le risorse catalogate, la Superclasse di dcat:Dataset, dcat:DataService, dcat:Catalog e qualsiasi altro membro di dcat:Catalog. Questa classe porta proprietà comuni a tutte le risorse catalogate, inclusi set di dati e servizi dati. Si raccomanda vivamente di utilizzare una sottoclasse più specifica. Quando si descrive una risorsa che non è un dcat:Dataset o dcat:DataService, si raccomanda di creare una sottoclasse di dcat:Resource appropriata, o utilizzare dcat:Resource con la proprietà dcterms:type per indicare il tipo specifico.skos:scopeNote : The class of all catalogued resources, the Superclass of dcat:Dataset, dcat:DataService, dcat:Catalog and any other member of a dcat:Catalog. This class carries properties common to all catalogued resources, including datasets and data services. The instances of this class SHOULD be included in a catalog. The instances of this class SHOULD be included in a catalog. It is strongly recommended to use a more specific sub-class. When describing a resource which is not a dcat:Dataset or dcat:DataService, it is recommended to create a suitable sub-class of dcat:Resource, or use dcat:Resource with the dcterms:type property to indicate the specific type.skos:scopeNote : Třída všech katalogizovaných zdrojů, nadtřída dcat:Dataset, dcat:DataService, dcat:Catalog a všech ostatních členů dcat:Catalog. Tato třída nese vlastnosti společné všem katalogizovaným zdrojům včetně datových sad a datových služeb. Je silně doporučeno používat specifičtější podtřídy, pokud je to možné. Při popisu zdroje, který není ani dcat:Dataset, ani dcat:DataService se doporučuje vytvořit odpovídající podtřídu dcat:Resrouce a nebo použít dcat:Resource s vlastností dcterms:type pro určení konkrétního typu.skos:scopeNote : dcat:Resource es un punto de extensión que permite la definición de cualquier tipo de catálogo. Se pueden definir subclases adicionales en perfil de DCAT o una aplicación para catálogos de otro tipo de recursos.skos:scopeNote : dcat:Resource is an extension point that enables the definition of any kind of catalog. Additional subclasses may be defined in a DCAT profile or application for catalogs of other kinds of resources.skos:scopeNote : dcat:Resource je bod pro rozšíření umožňující definici různých druhů katalogů. Další podtřídy lze definovat v profilech DCAT či aplikacích pro katalogy zdrojů jiných druhů.skos:scopeNote : dcat:Resource è un punto di estensione che consente la definizione di qualsiasi tipo di catalogo. Sottoclassi aggiuntive possono essere definite in un profilo DCAT o in un'applicazione per cataloghi di altri tipi di risorse.skos:scopeNote : Klassen for alle katalogiserede ressourcer, den overordnede klasse for dcat:Dataset, dcat:DataService, dcat:Catalog og enhvert medlem af et dcat:Catalog. Denne klasse bærer egenskaber der gælder alle katalogiserede ressourcer, herunder dataset og datatjenester. Det anbefales kraftigt at mere specifikke subklasser oprettes. Når der beskrives ressourcer der ikke er dcat:Dataset eller dcat:DataService, anbefales det at oprette passende subklasser af dcat:Resource eller at dcat:Resource anvendes sammen med egenskaben dcterms:type til opmærkning med en specifik typeangivelse.skos:scopeNote : dcat:Resource er et udvidelsespunkt der tillader oprettelsen af enhver type af kataloger. Yderligere subklasser kan defineres i en DCAT-profil eller i en applikation til kataloger med andre typer af ressourcer.</para>
    ///   <a href="http://www.w3.org/ns/dcat#Resource">ns0:Resource</a>
    /// </summary>
    let Resource = dcatVocabulary.prefixId.prefix "Resource"
    /// <summary>
    ///   <para>rdfs:comment : A role is the function of a resource or agent with respect to another resource, in the context of resource attribution or resource relationships.rdfs:comment : Role je funkce zdroje či agenta ve vztahu k jinému zdroji, v kontextu přiřazení zdrojů či vztahů mezi zdroji.rdfs:comment : Un rol es la función de un recurso o agente con respecto a otro recuros, en el contexto de atribución del recurso o de las relaciones entre recursos.rdfs:comment : Un ruolo è la funzione di una risorsa o di un agente rispetto ad un'altra risorsa, nel contesto dell'attribuzione delle risorse o delle relazioni tra risorse.rdfs:comment : En rolle er den funktion en ressource eller aktør har i forhold til en anden ressource, i forbindelse med ressourcekreditering eller ressourcerelationer.</para>
    ///   <para>rdfs:label : Rolrdfs:label : Rolerdfs:label : Rolerdfs:label : Ruolordfs:label : Rolle</para>
    ///   <para>skos:changeNote : New class added in DCAT 2skos:changeNote : Nueva clase agregada en DCAT 2skos:changeNote : Nová třída přidaná ve verzi DCAT 2skos:changeNote : Nuova classe aggiunta in DCAT 2skos:changeNote : Ny klasse tilføjet i DCAT 2</para>
    ///   <para>skos:definition : A role is the function of a resource or agent with respect to another resource, in the context of resource attribution or resource relationships.skos:definition : Role je funkce zdroje či agenta ve vztahu k jinému zdroji, v kontextu přiřazení zdrojů či vztahů mezi zdroji.skos:definition : Un rol es la función de un recurso o agente con respecto a otro recuros, en el contexto de atribución del recurso o de las relaciones entre recursos.skos:definition : Un ruolo è la funzione di una risorsa o di un agente rispetto ad un'altra risorsa, nel contesto dell'attribuzione delle risorse o delle relazioni tra risorse.skos:definition : En rolle er den funktion en ressource eller aktør har i forhold til en anden ressource, i forbindelse med ressourcekreditering eller ressourcerelationer.</para>
    ///   <para>skos:editorialNote : Incluída en DCAT para complementar prov:Role (cuyo uso está limitado a roles en el contexto de una actividad, ya que es el rango es prov:hadRole).skos:editorialNote : Introdotta in DCAT per completare prov:Role (il cui uso è limitato ai ruoli nel contesto di un'attività, in conseguenza alla definizione del codominio di prov:hadRole).skos:editorialNote : Introduced into DCAT to complement prov:Role (whose use is limited to roles in the context of an activity, as the range of prov:hadRole).skos:editorialNote : Přidáno do DCAT pro doplnění třídy prov:Role (jejíž užití je omezeno na role v kontextu aktivit, jakožto obor hodnot vlastnosti prov:hadRole).skos:editorialNote : Introduceret i DCAT for at supplere prov:Role (hvis anvendelse er begrænset til roller i forbindelse med en aktivitet, som er rækkevidde for prov:hadRole).</para>
    ///   <para>skos:scopeNote : Použito v kvalifikovaném přiřazení pro specifikaci role Agenta ve vztahu k Entitě. Je doporučeno množinu hodnot spravovat jako řízený slovník rolí agentů, jako například http://registry.it.csiro.au/def/isotc211/CI_RoleCode.skos:scopeNote : Použito v kvalifikovaném vztahu pro specifikaci role Entity ve vztahu k jiné Entitě. Je doporučeno množinu hodnot spravovat jako řízený slovník rolí entit, jako například ISO 19115 DS_AssociationTypeCode http://registry.it.csiro.au/def/isotc211/DS_AssociationTypeCode, IANA Registry of Link Relations https://www.iana.org/assignments/link-relation, DataCite metadata schema, či MARC relators https://id.loc.gov/vocabulary/relators.skos:scopeNote : Se usa en una atribución cualificada para especificar el rol de un Agente con respecto a una Entidad. Se recomienda que los valores se administren como un vocabulario controlado de roles de agente, como por ejemplo http://registry.it.csiro.au/def/isotc211/CI_RoleCode.skos:scopeNote : Se usa en una relación cualificada para especificar el rol de una Entidad con respecto a otra Entidad. Se recomienda que los valores se administren como los valores de un vocabulario controlado de roles de entidad como por ejemplo: ISO 19115 DS_AssociationTypeCode http://registry.it.csiro.au/def/isotc211/DS_AssociationTypeCode; IANA Registry of Link Relations https://www.iana.org/assignments/link-relation; el esquema de metadatos de DataCite; MARC relators https://id.loc.gov/vocabulary/relators.skos:scopeNote : Used in a qualified-attribution to specify the role of an Agent with respect to an Entity. It is recommended that the values be managed as a controlled vocabulary of agent roles, such as http://registry.it.csiro.au/def/isotc211/CI_RoleCode.skos:scopeNote : Used in a qualified-relation to specify the role of an Entity with respect to another Entity. It is recommended that the values be managed as a controlled vocabulary of entity roles such as: ISO 19115 DS_AssociationTypeCode http://registry.it.csiro.au/def/isotc211/DS_AssociationTypeCode; IANA Registry of Link Relations https://www.iana.org/assignments/link-relation;  DataCite metadata schema;  MARC relators https://id.loc.gov/vocabulary/relators.skos:scopeNote : Utilizzato in un'attribuzione qualificata per specificare il ruolo di un agente rispetto a un'entità. Si consiglia di attribuire i valori considerando un vocabolario controllato dei ruoli dell'agente, ad esempio http://registry.it.csiro.au/def/isotc211/CI_RoleCode.skos:scopeNote : Utilizzato in una relazione qualificata per specificare il ruolo di un'entità rispetto a un'altra entità. Si raccomanda che il valore sia preso da un vocabolario controllato di ruoli di entità come ISO 19115 DS_AssociationTypeCode http://registry.it.csiro.au/def/isotc211/DS_AssociationTypeCode, IANA Registry of Link Relations https://www.iana.org/assignments/link-relation, DataCite metadata schema, o MARC relators https://id.loc.gov/vocabulary/relators.skos:scopeNote : Anvendes i forbindelse med kvalificerede krediteringer til at angive aktørens rolle i forhold til en entitet. Det anbefales at værdierne styres som et kontrolleret udfaldsrum med aktørroller, såsom http://registry.it.csiro.au/def/isotc211/CI_RoleCode.skos:scopeNote : Anvendes i forbindelse med kvalificerede relationer til at specificere en entitets rolle i forhold til en anden entitet. Det anbefales at værdierne styres med et kontrolleret udfaldsrum for for entitetsroller såsom: ISO 19115 DS_AssociationTypeCode http://registry.it.csiro.au/def/isotc211/DS_AssociationTypeCode; IANA Registry of Link Relations https://www.iana.org/assignments/link-relation;  DataCite metadata schema;  MARC relators https://id.loc.gov/vocabulary/relators.</para>
    ///   <a href="http://www.w3.org/ns/dcat#Role">ns0:Role</a>
    /// </summary>
    let Role = dcatVocabulary.prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:comment : A site or end-point that gives access to the distribution of the dataset.rdfs:comment : Umístění či přístupový bod zpřístupňující distribuci datové sady.rdfs:comment : Un sitio o end-point que da acceso a la distribución de un conjunto de datos.rdfs:comment : Un sito o end-point che dà accesso alla distribuzione del set di dati.rdfs:comment : Et websted eller endpoint der giver adgang til en repræsentation af datasættet.</para>
    ///   <para>rdfs:label : data access servicerdfs:label : servicio de acceso de datosrdfs:label : servizio di accesso ai datirdfs:label : služba pro přístup k datůmrdfs:label : dataadgangstjeneste</para>
    ///   <para>skos:changeNote : New property added in DCAT 2.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 2.skos:changeNote : Nueva propiedad agregada en DCAT 2.skos:changeNote : Nuova proprietà aggiunta in DCAT 2.skos:changeNote : Ny egenskab tilføjet i DCAT 2.</para>
    ///   <para>skos:definition : A site or end-point that gives access to the distribution of the dataset.skos:definition : Umístění či přístupový bod zpřístupňující distribuci datové sady.skos:definition : Un sitio o end-point que da acceso a la distribución de un conjunto de datos.skos:definition : Un sito o end-point che dà accesso alla distribuzione del set di dati.skos:definition : Et websted eller endpoint der giver adgang til en repræsentation af datasættet.</para>
    ///   <a href="http://www.w3.org/ns/dcat#accessService">ns0:accessService</a>
    /// </summary>
    let accessService = dcatVocabulary.prefixId.prefix "accessService"
    /// <summary>
    ///   <para>rdfs:comment : A URL of a resource that gives access to a distribution of the dataset. E.g. landing page, feed, SPARQL endpoint. Use for all cases except a simple download link, in which case downloadURL is preferred.rdfs:comment : Ceci peut être tout type d'URL qui donne accès à une distribution du jeu de données. Par exemple, un lien à une page HTML contenant un lien au jeu de données, un Flux RSS, un point d'accès SPARQL. Utilisez le lorsque votre catalogue ne contient pas d'information sur quoi il est ou quand ce n'est pas téléchargeable.rdfs:comment : Puede ser cualquier tipo de URL que de acceso a una distribución del conjunto de datos, e.g., página de destino, descarga, URL feed, punto de acceso SPARQL. Esta propriedad se debe usar cuando su catálogo de datos no tiene información sobre donde está o cuando no se puede descargar.rdfs:comment : URL zdroje, přes které je přístupná distribuce datové sady. Příkladem může být vstupní stránka, RSS kanál či SPARQL endpoint. Použijte ve všech případech kromě URL souboru ke stažení, pro které je lepší použít dcat:downloadURL.rdfs:comment : Un URL di una risorsa che consente di accedere a una distribuzione del set di dati. Per esempio, pagina di destinazione, feed, endpoint SPARQL. Da utilizzare per tutti i casi, tranne  quando  si tratta di un semplice link per il download nel qual caso è preferito downloadURL.rdfs:comment : Μπορεί να είναι οποιουδήποτε είδους URL που δίνει πρόσβαση στη διανομή ενός συνόλου δεδομένων. Π.χ. ιστοσελίδα αρχικής πρόσβασης, μεταφόρτωση, feed URL, σημείο διάθεσης SPARQL. Να χρησιμοποιείται όταν ο κατάλογος δεν περιέχει πληροφορίες εαν πρόκειται ή όχι για μεταφορτώσιμο αρχείο.rdfs:comment : أي رابط يتيح الوصول إلى البيانات. إذا كان الرابط هو ربط مباشر لملف يمكن تحميله استخدم الخاصية downloadURLrdfs:comment : データセットの配信にアクセス権を与えるランディング・ページ、フィード、SPARQLエンドポイント、その他の種類の資源。rdfs:comment : En URL for en ressource som giver adgang til en repræsentation af datsættet. Fx destinationsside, feed, SPARQL-endpoint. Anvendes i alle sammenhænge undtagen til angivelse af et simpelt download link hvor anvendelse af egenskaben downloadURL foretrækkes.</para>
    ///   <para>rdfs:label : URL d'accèsrdfs:label : URL de accesordfs:label : URL πρόσβασηςrdfs:label : access addressrdfs:label : indirizzo di accessordfs:label : přístupová adresardfs:label : رابط وصولrdfs:label : アクセスURLrdfs:label : adgangsadresse</para>
    ///   <para>skos:altLabel : adgangsURL</para>
    ///   <para>skos:definition : A URL of a resource that gives access to a distribution of the dataset. E.g. landing page, feed, SPARQL endpoint. Use for all cases except a simple download link, in which case downloadURL is preferred.skos:definition : Ceci peut être tout type d'URL qui donne accès à une distribution du jeu de données. Par exemple, un lien à une page HTML contenant un lien au jeu de données, un Flux RSS, un point d'accès SPARQL. Utilisez le lorsque votre catalogue ne contient pas d'information sur quoi il est ou quand ce n'est pas téléchargeable.skos:definition : Puede ser cualquier tipo de URL que de acceso a una distribución del conjunto de datos, e.g., página de destino, descarga, URL feed, punto de acceso SPARQL. Esta propriedad se debe usar cuando su catálogo de datos no tiene información sobre donde está o cuando no se puede descargar.skos:definition : URL zdroje, přes které je přístupná distribuce datové sady. Příkladem může být vstupní stránka, RSS kanál či SPARQL endpoint. Použijte ve všech případech kromě URL souboru ke stažení, pro které je lepší použít dcat:downloadURL.skos:definition : Un URL di una risorsa che consente di accedere a una distribuzione del set di dati. Per esempio, pagina di destinazione, feed, endpoint SPARQL. Da utilizzare per tutti i casi, tranne  quando  si tratta di un semplice link per il download nel qual caso è preferito downloadURL.skos:definition : Μπορεί να είναι οποιουδήποτε είδους URL που δίνει πρόσβαση στη διανομή ενός συνόλου δεδομένων. Π.χ. ιστοσελίδα αρχικής πρόσβασης, μεταφόρτωση, feed URL, σημείο διάθεσης SPARQL. Να χρησιμοποιείται όταν ο κατάλογος δεν περιέχει πληροφορίες εαν πρόκειται ή όχι για μεταφορτώσιμο αρχείο.skos:definition : أي رابط يتيح الوصول إلى البيانات. إذا كان الرابط هو ربط مباشر لملف يمكن تحميله استخدم الخاصية downloadURLskos:definition : データセットの配信にアクセス権を与えるランディング・ページ、フィード、SPARQLエンドポイント、その他の種類の資源。skos:definition : En URL for en ressource som giver adgang til en repræsentation af datsættet. Fx destinationsside, feed, SPARQL-endpoint. Anvendes i alle sammenhænge undtagen til angivelse af et simpelt download link hvor anvendelse af egenskaben downloadURL foretrækkes.</para>
    ///   <para>skos:editorialNote : Status: English Definition text modified by DCAT revision team, updated Italian and Czech translation provided, translations for other languages pending.skos:editorialNote : rdfs:label, rdfs:comment and skos:scopeNote have been modified. Non-english versions except for Italian must be updated.</para>
    ///   <para>skos:scopeNote : El rango es una URL. Si la distribución es accesible solamente través de una página de destino (es decir, si no se conoce una URL de descarga directa), entonces el enlance a la página de destino debe ser duplicado como accessURL en la distribución.skos:scopeNote : If the distribution(s) are accessible only through a landing page (i.e. direct download URLs are not known), then the landing page link should be duplicated as accessURL on a distribution.skos:scopeNote : La valeur est une URL. Si la distribution est accessible seulement au travers d'une page d'atterrissage (c-à-dire on n'ignore une URL de téléchargement direct), alors le lien à la page d'atterrissage doit être dupliqué comee accessURL sur la distribution.skos:scopeNote : Pokud jsou distribuce přístupné pouze přes vstupní stránku (tj. URL pro přímé stažení nejsou známa), pak by URL přístupové stránky mělo být duplikováno ve vlastnosti distribuce accessURL.skos:scopeNote : Se le distribuzioni sono accessibili solo attraverso una pagina web (ad esempio, gli URL per il download diretto non sono noti), allora il link della pagina web deve essere duplicato come accessURL sulla distribuzione.skos:scopeNote : Η τιμή είναι ένα URL. Αν η/οι διανομή/ές είναι προσβάσιμη/ες μόνο μέσω μίας ιστοσελίδας αρχικής πρόσβασης (δηλαδή αν δεν υπάρχουν γνωστές διευθύνσεις άμεσης μεταφόρτωσης), τότε ο σύνδεσμος της ιστοσελίδας αρχικής πρόσβασης πρέπει να αναπαραχθεί ως accessURL σε μία διανομή.skos:scopeNote : 確実にダウンロードでない場合や、ダウンロードかどうかが不明である場合は、downloadURLではなく、accessURLを用いてください。ランディング・ページを通じてしか配信にアクセスできない場合（つまり、直接的なダウンロードURLが不明）は、配信におけるaccessURLとしてランディング・ページのリンクをコピーすべきです（SHOULD）。skos:scopeNote : Hvis en eller flere distributioner kun er tilgængelige via en destinationsside (dvs. en URL til direkte download er ikke kendt), så bør destinationssidelinket gentages som adgangsadresse for distributionen.</para>
    ///   <a href="http://www.w3.org/ns/dcat#accessURL">ns0:accessURL</a>
    /// </summary>
    let accessURL = dcatVocabulary.prefixId.prefix "accessURL"
    /// <summary>
    ///   <para>rdfs:comment : El cuadro delimitador geográfico para un recurso.rdfs:comment : Ohraničení geografické oblasti zdroje.rdfs:comment : The geographic bounding box of a spatial thing [SDW-BP].rdfs:comment : Il riquadro di delimitazione geografica di una risorsa.rdfs:comment : Den geografiske omskrevne firkant af en ressource.</para>
    ///   <para>rdfs:label : bounding boxrdfs:label : quadro di delimitazionerdfs:label : cuadro delimitadorrdfs:label : ohraničení oblastirdfs:label : bounding box</para>
    ///   <para>skos:changeNote : New property added in DCAT 2.skos:changeNote : Nuova proprietà aggiunta in DCAT 2.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 2.skos:changeNote : Propiedad nueva agregada en DCAT 2.skos:changeNote : Ny egenskab tilføjet i DCAT 2.</para>
    ///   <para>skos:definition : El cuadro delimitador geográfico para un recurso.skos:definition : Ohraničení geografické oblasti zdroje.skos:definition : The geographic bounding box of a spatial thing [SDW-BP].skos:definition : Il riquadro di delimitazione geografica di una risorsa.skos:definition : Den geografiske omskrevne firkant af en ressource.</para>
    ///   <para>skos:editorialNote : English language definitions and comments updated in this revision in line with ED. Multilingual text unevenly updated.</para>
    ///   <para>skos:scopeNote : El rango de esta propiedad es intencionalmente genérico con el propósito de permitir distintas codificaciones geométricas. Por ejemplo, la geometría puede ser codificada como WKT (geosparql:wktLiteral [GeoSPARQL]) o [GML] (geosparql:asGML [GeoSPARQL]).skos:scopeNote : Obor hodnot této vlastnosti je úmyslně obecný, aby umožnil různé kódování geometrií. Geometrie by kupříkladu mohla být kódována jako WKT (geosparql:wktLiteral [GeoSPARQL]) či [GML] (geosparql:asGML [GeoSPARQL]).skos:scopeNote : The range of this property (rdfs:Literal) is intentionally generic, with the purpose of allowing different geometry literal encodings. E.g., the geometry could be encoded as a WKT literal (geosparql:wktLiteral [GeoSPARQL]).skos:scopeNote : Il range di questa proprietà (rdfs:Literal) è volutamente generica, con lo scopo di consentire diverse codifiche geometriche letterali. Ad esempio, la geometria potrebbe essere codificata con un letterale WKT (geosparql:wktLiteral [GeoSPARQL]) o [GML] (geosparql:asGML [GeoSPARQL]).skos:scopeNote : Rækkevidden for denne egenskab er bevidst generisk defineret med det formål at tillade forskellige kodninger af geometrier. Geometrien kan eksempelvis repræsenteres som WKT (geosparql:asWKT [GeoSPARQL]) eller [GML] (geosparql:asGML [GeoSPARQL]).</para>
    ///   <a href="http://www.w3.org/ns/dcat#bbox">ns0:bbox</a>
    /// </summary>
    let bbox = dcatVocabulary.prefixId.prefix "bbox"
    /// <summary>
    ///   <para>rdfs:comment : El tamaño de una distribución en bytes.rdfs:comment : La dimensione di una distribuzione in byte.rdfs:comment : La taille de la distribution en octectsrdfs:comment : The size of a distribution in bytes.rdfs:comment : Velikost distribuce v bajtech.rdfs:comment : Το μέγεθος μιας διανομής σε bytes.rdfs:comment : الحجم بالبايتات rdfs:comment : バイトによる配信のサイズ。rdfs:comment : Størrelsen af en distributionen angivet i bytes.</para>
    ///   <para>rdfs:label : byte sizerdfs:label : dimensione in byterdfs:label : taille en octectsrdfs:label : tamaño en bytesrdfs:label : velikost v bajtechrdfs:label : μέγεθος σε bytesrdfs:label : الحجم بالبايتrdfs:label : バイト・サイズrdfs:label : bytestørrelse</para>
    ///   <para>skos:definition : El tamaño de una distribución en bytes.skos:definition : La dimensione di una distribuzione in byte.skos:definition : La taille de la distribution en octects.skos:definition : The size of a distribution in bytes.skos:definition : Velikost distribuce v bajtech.skos:definition : Το μέγεθος μιας διανομής σε bytes.skos:definition : الحجم بالبايتات skos:definition : バイトによる配信のサイズ。skos:definition : Størrelsen af en distribution angivet i bytes.</para>
    ///   <para>skos:scopeNote : El tamaño en bytes puede ser aproximado cuando se desconoce el tamaño exacto. El valor literal de dcat:byteSize debe tener tipo 'xsd:decimal'.skos:scopeNote : La dimensione in byte può essere approssimata quando non si conosce la dimensione precisa. Il valore di dcat:byteSize dovrebbe essere espresso come un xsd:decimal.skos:scopeNote : La taille en octects peut être approximative lorsque l'on ignore la taille réelle. La valeur littérale de dcat:byteSize doit être de type xsd:decimal.skos:scopeNote : The size in bytes can be approximated when the precise size is not known. The literal value of dcat:byteSize should by typed as xsd:decimal.skos:scopeNote : Velikost v bajtech může být přibližná, pokud její přesná hodnota není známa. Literál s hodnotou dcat:byteSize by měl mít datový typ xsd:decimal.skos:scopeNote : Το μέγεθος σε bytes μπορεί να προσεγγιστεί όταν η ακριβής τιμή δεν είναι γνωστή. Η τιμή της dcat:byteSize θα πρέπει να δίνεται με τύπο δεδομένων xsd:decimal.skos:scopeNote : الحجم يمكن أن يكون تقريبي إذا كان الحجم الدقيق غير معروفskos:scopeNote : 正確なサイズが不明である場合、サイズは、バイトによる近似値を示すことができます。skos:scopeNote : Bytestørrelsen kan approximeres hvis den præcise størrelse ikke er kendt. Værdien af dcat:byteSize bør angives som xsd:decimal.</para>
    ///   <a href="http://www.w3.org/ns/dcat#byteSize">ns0:byteSize</a>
    /// </summary>
    let byteSize = dcatVocabulary.prefixId.prefix "byteSize"
    /// <summary>
    ///   <para>rdfs:comment : A catalog that is listed in the catalog.rdfs:comment : Katalog, jehož obsah je v kontextu tohoto katalogu zajímavý.rdfs:comment : Un catalogo i cui contenuti sono di interesse nel contesto di questo catalogo.rdfs:comment : Un catálogo cuyo contenido es de interés en el contexto del catálogo que está siendo descripto.rdfs:comment : Et katalog hvis indhold er relevant i forhold til det aktuelle katalog.</para>
    ///   <para>rdfs:label : catalogrdfs:label : catalogordfs:label : catálogordfs:label : katalogrdfs:label : katalog</para>
    ///   <para>skos:altLabel : har delkatalogskos:altLabel : has catalog</para>
    ///   <para>skos:changeNote : New property added in DCAT 2.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 2.skos:changeNote : Nueva propiedad agregada en DCAT 2.skos:changeNote : Nuova proprietà aggiunta in DCAT 2.</para>
    ///   <para>skos:definition : A catalog that is listed in the catalog.skos:definition : Katalog, jehož obsah je v kontextu tohoto katalogu zajímavý.skos:definition : Un catalogo i cui contenuti sono di interesse nel contesto di questo catalogo.skos:definition : Un catálogo cuyo contenido es de interés en el contexto del catálogo que está siendo descripto.skos:definition : Et katalog hvis indhold er relevant i forhold til det aktuelle katalog.</para>
    ///   <para>skos:editorialNote : Status: English Definition text modified by DCAT 3 revision team, translations pending.</para>
    ///   <a href="http://www.w3.org/ns/dcat#catalog">ns0:catalog</a>
    /// </summary>
    let catalog = dcatVocabulary.prefixId.prefix "catalog"
    /// <summary>
    ///   <para>rdfs:comment : El centro geográfico (centroide) de un recurso.rdfs:comment : Geografický střed (centroid) zdroje.rdfs:comment : The geographic center (centroid) of a spatial thing [SDW-BP].rdfs:comment : Il centro geografico (centroide) di una risorsa.rdfs:comment : Det geometrisk tyngdepunkt (centroid) for en ressource.</para>
    ///   <para>rdfs:label : centroidrdfs:label : centroidrdfs:label : centroiderdfs:label : centroiderdfs:label : geometrisk tyngdepunkt</para>
    ///   <para>skos:altLabel : centroide</para>
    ///   <para>skos:changeNote : New property added in DCAT 2.skos:changeNote : Nuova proprietà aggiunta in DCAT 2.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 2.skos:changeNote : Nueva propiedad agregada en DCAT 2.skos:changeNote : Ny egenskab tilføjet i DCAT 2.</para>
    ///   <para>skos:definition : El centro geográfico (centroide) de un recurso.skos:definition : Geografický střed (centroid) zdroje.skos:definition : The geographic center (centroid) of a spatial thing [SDW-BP].skos:definition : Il centro geografico (centroide) di una risorsa.skos:definition : Det geometrisk tyngdepunkt (centroid) for en ressource.</para>
    ///   <para>skos:editorialNote : English language definitions and comments updated in this revision in line with ED. Multilingual text unevenly updated.</para>
    ///   <para>skos:scopeNote : El rango de esta propiedad es intencionalmente genérico con el objetivo de permitir distintas codificaciones geométricas. Por ejemplo, la geometría puede codificarse como WKT (geosparql:wktLiteral [GeoSPARQL]) o [GML] (geosparql:asGML [GeoSPARQL]).skos:scopeNote : Obor hodnot této vlastnosti je úmyslně obecný, aby umožnil různé kódování geometrií. Geometrie by kupříkladu mohla být kódována jako WKT (geosparql:wktLiteral [GeoSPARQL]) či [GML] (geosparql:asGML [GeoSPARQL]).skos:scopeNote : The range of this property (rdfs:Literal) is intentionally generic, with the purpose of allowing different geometry literal encodings. E.g., the geometry could be encoded as a WKT literal (geosparql:wktLiteral [GeoSPARQL]).skos:scopeNote : Il range di questa proprietà (rdfs:Literal) è volutamente generica, con lo scopo di consentire diverse codifiche geometriche letterali. Ad esempio, la geometria potrebbe essere codificata con un letterale WKT (geosparql:wktLiteral [GeoSPARQL]) o [GML] (geosparql:asGML [GeoSPARQL]).skos:scopeNote : Rækkevidden for denne egenskab er bevidst generisk definere med det formål at tillade forskellige geokodninger. Geometrien kan eksempelvis repræsenteres som WKT (geosparql:asWKT [GeoSPARQL]) eller [GML] (geosparql:asGML [GeoSPARQL]).</para>
    ///   <a href="http://www.w3.org/ns/dcat#centroid">ns0:centroid</a>
    /// </summary>
    let centroid = dcatVocabulary.prefixId.prefix "centroid"
    /// <summary>
    ///   <para>rdfs:comment : El formato de la distribución en el que los datos están en forma comprimida, e.g. para reducir el tamaño del archivo a bajar.rdfs:comment : Formát komprese souboru, ve kterém jsou data poskytována v komprimované podobě, např. ke snížení velikosti souboru ke stažení.rdfs:comment : Il formato di compressione della distribuzione nel quale i dati sono in forma compressa, ad es. per ridurre le dimensioni del file da scaricare.rdfs:comment : The compression format of the distribution in which the data is contained in a compressed form, e.g. to reduce the size of the downloadable file.rdfs:comment : Kompressionsformatet for distributionen som indeholder data i et komprimeret format, fx for at reducere størrelsen af downloadfilen.</para>
    ///   <para>rdfs:label : compression formatrdfs:label : formato de compresiónrdfs:label : formato di compressionerdfs:label : formát kompreserdfs:label : kompressionsformat</para>
    ///   <para>skos:changeNote : New property added in DCAT 2.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 2.skos:changeNote : Nueva propiedad agregada en DCAT 2.skos:changeNote : Nuova proprietà aggiunta in DCAT 2.skos:changeNote : Ny egenskab tilføjet i DCAT 2.</para>
    ///   <para>skos:definition : El formato de la distribución en el que los datos están en forma comprimida, e.g. para reducir el tamaño del archivo a bajar.skos:definition : Formát komprese souboru, ve kterém jsou data poskytována v komprimované podobě, např. ke snížení velikosti souboru ke stažení.skos:definition : Il formato di compressione della distribuzione nel quale i dati sono in forma compressa, ad es. per ridurre le dimensioni del file da scaricare.skos:definition : The compression format of the distribution in which the data is contained in a compressed form, e.g. to reduce the size of the downloadable file.skos:definition : Kompressionsformatet for distributionen som indeholder data i et komprimeret format, fx for at reducere størrelsen af downloadfilen.</para>
    ///   <para>skos:scopeNote : Esta propiedad se debe usar cuando los archivos de la distribución están comprimidos, por ejemplo en un archivo ZIP. El formato DEBERÍA expresarse usando un 'media type', tales como los definidos en el registro IANA de 'media types' https://www.iana.org/assignments/media-types/, si está disponibles.skos:scopeNote : Questa proprietà deve essere utilizzata quando i file nella distribuzione sono compressi, ad es. in un file ZIP. Il formato DOVREBBE essere espresso usando un tipo di media come definito dal registro dei tipi di media IANA https://www.iana.org/assignments/media-types/, se disponibile.skos:scopeNote : Tato vlastnost se použije, když jsou soubory v distribuci komprimovány, např. v ZIP souboru. Formát BY MĚL být vyjádřen pomocí typu média definovaného v registru IANA https://www.iana.org/assignments/media-types/, pokud existuje.skos:scopeNote : This property is to be used when the files in the distribution are compressed, e.g. in a ZIP file. The format SHOULD be expressed using a media type as defined by IANA media types registry https://www.iana.org/assignments/media-types/, if available.skos:scopeNote : Denne egenskab kan anvendes når filerne i en distribution er blevet komprimeret, fx i en ZIP-fil. Formatet BØR udtrykkes ved en medietype som defineret i 'IANA media types registry', hvis der optræder en relevant medietype dér: https://www.iana.org/assignments/media-types/.</para>
    ///   <a href="http://www.w3.org/ns/dcat#compressFormat">ns0:compressFormat</a>
    /// </summary>
    let compressFormat = dcatVocabulary.prefixId.prefix "compressFormat"
    /// <summary>
    ///   <para>rdfs:comment : Información relevante de contacto para el recurso catalogado. Se recomienda el uso de vCard.rdfs:comment : Informazioni di contatto rilevanti per la risorsa catalogata. Si raccomanda l'uso di vCard.rdfs:comment : Relevant contact information for the catalogued resource. Use of vCard is recommended.rdfs:comment : Relevantní kontaktní informace pro katalogizovaný zdroj. Doporučuje se použít slovník VCard.rdfs:comment : Relie un jeu de données à une information de contact utile en utilisant VCard.rdfs:comment : Συνδέει ένα σύνολο δεδομένων με ένα σχετικό σημείο επικοινωνίας, μέσω VCard.rdfs:comment : تربط قائمة البيانات بعنوان اتصال موصف  باستخدام VCardrdfs:comment : データセットを、VCardを用いて提供されている適切な連絡先情報にリンクします。rdfs:comment : Relevante kontaktoplysninger for den katalogiserede ressource. Anvendelse af vCard anbefales.</para>
    ///   <para>rdfs:label : Punto de contactordfs:label : contact pointrdfs:label : kontaktní bodrdfs:label : point de contactrdfs:label : punto di contattordfs:label : σημείο επικοινωνίαςrdfs:label : عنوان اتصالrdfs:label : 窓口rdfs:label : kontaktpunkt</para>
    ///   <para>skos:definition : Información relevante de contacto para el recurso catalogado. Se recomienda el uso de vCard.skos:definition : Informazioni di contatto rilevanti per la risorsa catalogata. Si raccomanda l'uso di vCard.skos:definition : Relevant contact information for the catalogued resource. Use of vCard is recommended.skos:definition : Relevantní kontaktní informace pro katalogizovaný zdroj. Doporučuje se použít slovník VCard.skos:definition : Relie un jeu de données à une information de contact utile en utilisant VCard.skos:definition : Συνδέει ένα σύνολο δεδομένων με ένα σχετικό σημείο επικοινωνίας, μέσω VCard.skos:definition : تربط قائمة البيانات بعنوان اتصال موصف  باستخدام VCardskos:definition : データセットを、VCardを用いて提供されている適切な連絡先情報にリンクします。skos:definition : Relevante kontaktoplysninger for den katalogiserede ressource. Anvendelse af vCard anbefales.</para>
    ///   <para>skos:editorialNote : Status: English Definition text modified by DCAT revision team, Italian, Spanish and Czech translations provided, other translations pending.</para>
    ///   <a href="http://www.w3.org/ns/dcat#contactPoint">ns0:contactPoint</a>
    /// </summary>
    let contactPoint = dcatVocabulary.prefixId.prefix "contactPoint"
    /// <summary>
    ///   <para>rdfs:comment : A dataset that is listed in the catalog.rdfs:comment : Kolekce dat, která je katalogizována v katalogu.rdfs:comment : Relie un catalogue à un jeu de données faisant partie de ce catalogue.rdfs:comment : Un conjunto de datos que se lista en el catálogo.rdfs:comment : Una raccolta di dati che è elencata nel catalogo.rdfs:comment : Συνδέει έναν κατάλογο με ένα σύνολο δεδομένων το οποίο ανήκει στον εν λόγω κατάλογο.rdfs:comment : تربط الفهرس بقائمة بيانات ضمنهrdfs:comment : カタログの一部であるデータセット。rdfs:comment : En samling af data som er opført i kataloget.</para>
    ///   <para>rdfs:label : conjunto de datosrdfs:label : datasetrdfs:label : datasetrdfs:label : datová sadardfs:label : jeu de donnéesrdfs:label : σύνολο δεδομένωνrdfs:label : قائمة بياناتrdfs:label : データセットrdfs:label : datasæt</para>
    ///   <para>skos:altLabel : har datasætskos:altLabel : datasamlingskos:altLabel : has dataset</para>
    ///   <para>skos:definition : A dataset that is listed in the catalog.skos:definition : Kolekce dat, která je katalogizována v katalogu.skos:definition : Relie un catalogue à un jeu de données faisant partie de ce catalogue.skos:definition : Un conjunto de datos que se lista en el catálogo.skos:definition : Una raccolta di dati che è elencata nel catalogo.skos:definition : Συνδέει έναν κατάλογο με ένα σύνολο δεδομένων το οποίο ανήκει στον εν λόγω κατάλογο.skos:definition : تربط الفهرس بقائمة بيانات ضمنهskos:definition : カタログの一部であるデータセット。skos:definition : En samling af data som er opført i kataloget.</para>
    ///   <para>skos:editorialNote : Status: English Definition text modified by DCAT 3 revision team, translations pending.</para>
    ///   <a href="http://www.w3.org/ns/dcat#dataset">ns0:dataset</a>
    /// </summary>
    let dataset = dcatVocabulary.prefixId.prefix "dataset"
    /// <summary>
    ///   <para>rdfs:comment : An available distribution of the dataset.rdfs:comment : Connecte un jeu de données à des distributions disponibles.rdfs:comment : Dostupná distribuce datové sady.rdfs:comment : Una distribución disponible del conjunto de datos.rdfs:comment : Una distribuzione disponibile per il set di dati.rdfs:comment : Συνδέει ένα σύνολο δεδομένων με μία από τις διαθέσιμες διανομές του.rdfs:comment : تربط قائمة البيانات بطريقة أو بشكل يسمح  الوصول الى البياناتrdfs:comment : データセットを、その利用可能な配信に接続します。rdfs:comment : En tilgængelig repræsentation af datasættet.</para>
    ///   <para>rdfs:label : distribucerdfs:label : distribuciónrdfs:label : distributionrdfs:label : distributionrdfs:label : distribuzionerdfs:label : distributionrdfs:label : διανομήrdfs:label : توزيعrdfs:label : データセット配信</para>
    ///   <para>skos:altLabel : har distributionskos:altLabel : has distribution</para>
    ///   <para>skos:definition : An available distribution of the dataset.skos:definition : Connecte un jeu de données à des distributions disponibles.skos:definition : Dostupná distribuce datové sady.skos:definition : Una distribución disponible del conjunto de datos.skos:definition : Una distribuzione disponibile per il set di dati.skos:definition : Συνδέει ένα σύνολο δεδομένων με μία από τις διαθέσιμες διανομές του.skos:definition : تربط قائمة البيانات بطريقة أو بشكل يسمح  الوصول الى البياناتskos:definition : データセットを、その利用可能な配信に接続します。skos:definition : En tilgængelig repræsentation af datasættet.</para>
    ///   <para>skos:editorialNote : Status: English Definition text modified by DCAT revision team, translations pending (except for Italian, Spanish and Czech).</para>
    ///   <a href="http://www.w3.org/ns/dcat#distribution">ns0:distribution</a>
    /// </summary>
    let distribution = dcatVocabulary.prefixId.prefix "distribution"
    /// <summary>
    ///   <para>rdfs:comment : Ceci est un lien direct à un fichier téléchargeable en un format donnée. Exple fichier CSV ou RDF. Le format est décrit par les propriétés de distribution dcterms:format et/ou dcat:mediaType.rdfs:comment : La URL de un archivo descargable en el formato dato. Por ejemplo, archivo CSV o archivo RDF. El formato se describe con las propiedades de la distribución dcterms:format y/o dcat:mediaType.rdfs:comment : Questo è un link diretto al file scaricabile in un dato formato. E.g. un file CSV o un file RDF. Il formato è descritto dal dcterms:format e/o dal dcat:mediaType della distribuzione.rdfs:comment : The URL of the downloadable file in a given format. E.g. CSV file or RDF file. The format is indicated by the distribution's dcterms:format and/or dcat:mediaType.rdfs:comment : URL souboru ke stažení v daném formátu, například CSV nebo RDF soubor. Formát je popsán vlastností distribuce dcterms:format a/nebo dcat:mediaType.rdfs:comment : dcat:downloadURLはdcat:accessURLの特定の形式です。しかし、DCATプロファイルが非ダウンロード・ロケーションに対してのみaccessURLを用いる場合には、より強い分離を課すことを望む可能性があるため、この含意を強化しないように、DCATは、dcat:downloadURLをdcat:accessURLのサブプロパティーであると定義しません。rdfs:comment : Είναι ένας σύνδεσμος άμεσης μεταφόρτωσης ενός αρχείου σε μια δεδομένη μορφή. Π.χ. ένα αρχείο CSV ή RDF. Η μορφη αρχείου περιγράφεται από τις ιδιότητες dcterms:format ή/και dcat:mediaType της διανομής.rdfs:comment : رابط مباشر لملف يمكن تحميله. نوع الملف يتم توصيفه باستخدام الخاصية dcterms:format dcat:mediaType rdfs:comment : URL til fil der kan downloades i et bestemt format. Fx en CSV-fil eller en RDF-fil. Formatet for distributionen angives ved hjælp af egenskaberne dcterms:format og/eller dcat:mediaType.</para>
    ///   <para>rdfs:label : URL de descargardfs:label : URL de téléchargementrdfs:label : URL di scaricordfs:label : URL souboru ke staženírdfs:label : URL μεταφόρτωσηςrdfs:label : download URLrdfs:label : رابط تحميلrdfs:label : ダウンロードURLrdfs:label : downloadURL</para>
    ///   <para>skos:definition : Ceci est un lien direct à un fichier téléchargeable en un format donnée. Exple fichier CSV ou RDF. Le format est décrit par les propriétés de distribution dcterms:format et/ou dcat:mediaType.skos:definition : La URL de un archivo descargable en el formato dato. Por ejemplo, archivo CSV o archivo RDF. El formato se describe con las propiedades de la distribución dcterms:format y/o dcat:mediaType.skos:definition : Questo è un link diretto al file scaricabile in un dato formato. E.g. un file CSV o un file RDF. Il formato è descritto dal dcterms:format e/o dal dcat:mediaType della distribuzione.skos:definition : The URL of the downloadable file in a given format. E.g. CSV file or RDF file. The format is indicated by the distribution's dcterms:format and/or dcat:mediaType.skos:definition : URL souboru ke stažení v daném formátu, například CSV nebo RDF soubor. Formát je popsán vlastností distribuce dcterms:format a/nebo dcat:mediaType.skos:definition : dcat:downloadURLはdcat:accessURLの特定の形式です。しかし、DCATプロファイルが非ダウンロード・ロケーションに対してのみaccessURLを用いる場合には、より強い分離を課すことを望む可能性があるため、この含意を強化しないように、DCATは、dcat:downloadURLをdcat:accessURLのサブプロパティーであると定義しません。skos:definition : Είναι ένας σύνδεσμος άμεσης μεταφόρτωσης ενός αρχείου σε μια δεδομένη μορφή. Π.χ. ένα αρχείο CSV ή RDF. Η μορφη αρχείου περιγράφεται από τις ιδιότητες dcterms:format ή/και dcat:mediaType της διανομής.skos:definition : URL til fil der kan downloades i et bestemt format. Fx en CSV-fil eller en RDF-fil. Formatet for distributionen angives ved hjælp af egenskaberne dcterms:format og/eller dcat:mediaType.skos:definition : رابط مباشر لملف يمكن تحميله. نوع الملف يتم توصيفه باستخدام الخاصية dcterms:format dcat:mediaType </para>
    ///   <para>skos:editorialNote : Status: English  Definition text modified by DCAT revision team, Italian, Spanish and Czech translation updated, other translations pending.skos:editorialNote : rdfs:label, rdfs:comment and/or skos:scopeNote have been modified. Non-english versions must be updated.</para>
    ///   <para>skos:scopeNote : El valor es una URL.skos:scopeNote : La valeur est une URL.skos:scopeNote : dcat:downloadURL BY MĚLA být použita pro adresu, ze které je distribuce přímo přístupná, typicky skrze požadavek HTTP Get.skos:scopeNote : dcat:downloadURL DOVREBBE essere utilizzato per l'indirizzo a cui questa distribuzione è disponibile direttamente, in genere attraverso una richiesta Get HTTP.skos:scopeNote : dcat:downloadURL SHOULD be used for the address at which this distribution is available directly, typically through a HTTP Get request.skos:scopeNote : Η τιμή είναι ένα URL.skos:scopeNote : dcat:downloadURL BØR anvendes til angivelse af den adresse hvor distributionen er tilgængelig direkte, typisk gennem et HTTP Get request.</para>
    ///   <a href="http://www.w3.org/ns/dcat#downloadURL">ns0:downloadURL</a>
    /// </summary>
    let downloadURL = dcatVocabulary.prefixId.prefix "downloadURL"
    /// <summary>
    ///   <para>rdfs:comment : El fin del período.rdfs:comment : Konec doby trvání.rdfs:comment : The end of the period.rdfs:comment : La fine del periodo.rdfs:comment : Slutningen på perioden.</para>
    ///   <para>rdfs:label : datum koncerdfs:label : end daterdfs:label : data di finerdfs:label : fecha finalrdfs:label : slutdato</para>
    ///   <para>skos:altLabel : sluttidspunkt</para>
    ///   <para>skos:changeNote : New property added in DCAT 2.skos:changeNote : Nuova proprietà aggiunta in DCAT 2.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 2.skos:changeNote : Nueva propiedad agregada en DCAT 2.skos:changeNote : Ny egenskab i DCAT 2.</para>
    ///   <para>skos:definition : El fin del período.skos:definition : Konec doby trvání.skos:definition : The end of the period.skos:definition : La fine del periodo.skos:definition : Slutningen på perioden.</para>
    ///   <para>skos:scopeNote : El rango de esta propiedad es intencionalmente genérico con el propósito de permitir distintos niveles de precisión temporal para especificar el fin del período. Por ejemplo, puede expresarse como una fecha (xsd:date), una fecha y un tiempo (xsd:dateTime), o un año (xsd:gYear).skos:scopeNote : Obor hodnot této vlastnosti je úmyslně obecný, aby umožnil různé úrovně časového rozlišení pro specifikaci konce doby trvání. Ten může být kupříkladu vyjádřen datumem (xsd:date), datumem a časem (xsd:dateTime) či rokem (xsd:gYear).skos:scopeNote : The range of this property is intentionally generic, with the purpose of allowing different level of temporal precision for specifying the end of a period. E.g., it can be expressed with a date (xsd:date), a date and time (xsd:dateTime), or a year (xsd:gYear).skos:scopeNote : La range di questa proprietà è volutamente generico, con lo scopo di consentire diversi livelli di precisione temporale per specificare la fine di un periodo. Ad esempio, può essere espresso con una data (xsd:date), una data e un'ora (xsd:dateTime), o un anno (xsd:gYear).skos:scopeNote : Rækkeviden for denne egenskab er bevidst generisk defineret med det formål at tillade forskellige niveauer af tidslig præcision ifm. angivelse af slutdatoen for en periode. Den kan eksempelvis udtrykkes som en dato (xsd:date), en dato og et tidspunkt (xsd:dateTime), eller et årstal (xsd:gYear).</para>
    ///   <a href="http://www.w3.org/ns/dcat#endDate">ns0:endDate</a>
    /// </summary>
    let endDate = dcatVocabulary.prefixId.prefix "endDate"
    /// <summary>
    ///   <para>rdfs:comment : A description of the service end-point, including its operations, parameters etc.rdfs:comment : Popis přístupového bodu služby včetně operací, parametrů apod.rdfs:comment : Una descripción del end-point del servicio, incluyendo sus operaciones, parámetros, etc.rdfs:comment : Una descrizione dell'endpoint del servizio, incluse le sue operazioni, parametri, ecc.rdfs:comment : En beskrivelse af det pågældende tjenesteendpoint, inklusiv dets operationer, parametre etc.</para>
    ///   <para>rdfs:label : descripción del end-point del serviciordfs:label : description of service end-pointrdfs:label : descrizione dell'endpoint del serviziordfs:label : popis přístupového bodu službyrdfs:label : endpointbeskrivelse</para>
    ///   <para>skos:changeNote : New property in DCAT 2.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 2.skos:changeNote : Nueva propiedad agregada en DCAT 2.skos:changeNote : Nuova proprietà in DCAT 2.skos:changeNote : Ny egenskab i DCAT 2.</para>
    ///   <para>skos:definition : A description of the service end-point, including its operations, parameters etc.skos:definition : Popis přístupového bodu služby včetně operací, parametrů apod.skos:definition : Una descripción del end-point del servicio, incluyendo sus operaciones, parámetros, etc..skos:definition : Una descrizione dell'endpoint del servizio, incluse le sue operazioni, parametri, ecc.skos:definition : En beskrivelse af det pågældende tjenesteendpoint, inklusiv dets operationer, parametre etc.</para>
    ///   <para>skos:scopeNote : An endpoint description may be expressed in a machine-readable form, such as an OpenAPI (Swagger) description, an OGC GetCapabilities response, a SPARQL Service Description, an OpenSearch or WSDL document, a Hydra API description, else in text or some other informal mode if a formal representation is not possible.skos:scopeNote : La descripción del endpoint brinda detalles específicos de la instancia del endpoint, mientras que dcterms:conformsTo se usa para indicar el estándar general o especificación que implementa el endpoint.skos:scopeNote : La descrizione dell'endpoint fornisce dettagli specifici dell'istanza dell'endpoint reale, mentre dcterms:conformsTo viene utilizzato per indicare lo standard o le specifiche implementate dall'endpoint.skos:scopeNote : Popis přístupového bodu dává specifické detaily jeho konkrétní instance, zatímco dcterms:conformsTo indikuje obecný standard či specifikaci kterou přístupový bod implementuje.skos:scopeNote : Popis přístupového bodu může být vyjádřen ve strojově čitelné formě, například jako popis OpenAPI (Swagger), odpověď služby OGC getCapabilities, pomocí slovníku SPARQL Service Description, jako OpenSearch či WSDL document, jako popis API dle slovníku Hydra, a nebo textově nebo jiným neformálním způsobem, pokud není možno použít formální reprezentaci.skos:scopeNote : The endpoint description gives specific details of the actual endpoint instance, while dcterms:conformsTo is used to indicate the general standard or specification that the endpoint implements.skos:scopeNote : Una descripción del endpoint del servicio puede expresarse en un formato que la máquina puede interpretar, tal como una descripción basada en OpenAPI (Swagger), una respuesta OGC GetCapabilities, una descripción de un servicio SPARQL, un documento OpenSearch o WSDL, una descripción con la Hydra API, o en texto u otro modo informal si la representación formal no es posible.skos:scopeNote : Una descrizione dell'endpoint può essere espressa in un formato leggibile dalla macchina, come una descrizione OpenAPI (Swagger), una risposta GetCapabilities OGC, una descrizione del servizio SPARQL, un documento OpenSearch o WSDL, una descrizione API Hydra, o con del testo o qualche altra modalità informale se una rappresentazione formale non è possibile.skos:scopeNote : En beskrivelse af et endpoint kan udtrykkes i et maskinlæsbart format, såsom OpenAPI (Swagger)-beskrivelser, et OGC GetCapabilities svar, en SPARQL tjenestebeskrivelse, en OpenSearch- eller et WSDL-dokument, en Hydra-API-beskrivelse, eller i tekstformat eller i et andet uformelt format, hvis en formel repræsentation ikke er mulig.skos:scopeNote : Endpointbeskrivelsen giver specifikke oplysninger om den konkrete endpointinstans, mens dcterms:conformsTo anvendes til at indikere den overordnede standard eller specifikation som endpointet er i overensstemmelse med.</para>
    ///   <a href="http://www.w3.org/ns/dcat#endpointDescription">ns0:endpointDescription</a>
    /// </summary>
    let endpointDescription = dcatVocabulary.prefixId.prefix "endpointDescription"
    /// <summary>
    ///   <para>rdfs:comment : Kořenové umístění nebo hlavní přístupový bod služby (IRI přístupné přes Web).rdfs:comment : La locazione principale o l'endpoint primario del servizio (un IRI risolvibile via web).rdfs:comment : La posición raíz o end-point principal del servicio (una IRI web).rdfs:comment : The root location or primary endpoint of the service (a web-resolvable IRI).rdfs:comment : Rodplaceringen eller det primære endpoint for en tjeneste (en web-resolverbar IRI).</para>
    ///   <para>rdfs:label : end-point del serviciordfs:label : end-point del serviziordfs:label : přístupový bod službyrdfs:label : service end-pointrdfs:label : tjenesteendpoint</para>
    ///   <para>skos:changeNote : New property in DCAT 2.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 2.skos:changeNote : Nueva propiedad agregada en DCAT 2.skos:changeNote : Nuova proprietà in DCAT 2.</para>
    ///   <para>skos:definition : Kořenové umístění nebo hlavní přístupový bod služby (IRI přístupné přes Web).skos:definition : La locazione principale o l'endpoint primario del servizio (un IRI risolvibile via web).skos:definition : La posición raíz o end-point principal del servicio (una IRI web).skos:definition : The root location or primary endpoint of the service (a web-resolvable IRI).skos:definition : Rodplaceringen eller det primære endpoint for en tjeneste (en web-resolverbar IRI).</para>
    ///   <a href="http://www.w3.org/ns/dcat#endpointURL">ns0:endpointURL</a>
    /// </summary>
    let endpointURL = dcatVocabulary.prefixId.prefix "endpointURL"
    /// <summary>
    ///   <para>rdfs:comment : The first resource in an ordered collection or series of resources, to which the current resource belongs.rdfs:comment : El primer recurso en una colección ordenada o serie de recursos, al que el recurso pertenece.rdfs:comment : La prima risorsa in una collezione ordinata o in una serie di risorse, di cui la risorsa fa parte.</para>
    ///   <para>rdfs:label : firstrdfs:label : primerordfs:label : primo</para>
    ///   <para>skos:changeNote : New property added in DCAT 3.skos:changeNote : Nueva propiedad agregada in DCAT 3.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 3.skos:changeNote : Nuova proprietà aggiunta in DCAT 3.skos:changeNote : Ny egenskab tilføjet i DCAT 3.</para>
    ///   <para>skos:definition : The first resource in an ordered collection or series of resources, to which the current resource belongs.skos:definition : El primer recurso en una colección ordenada o serie de recursos, al que el recurso pertenece.skos:definition : La prima risorsa in una collezione ordinata o in una serie di risorse, di cui la risorsa fa parte.</para>
    ///   <para>skos:scopeNote : In DCAT this property is used for resources belonging to a dcat:DatasetSeries.skos:scopeNote : En DCAT esta propiedad se usa para recursos que pertenecen a una dcat:DatasetSeries.skos:scopeNote : In DCAT questa proprietà è usata per risorse che fanno parte di una dcat:DatasetSeries.</para>
    ///   <a href="http://www.w3.org/ns/dcat#first">ns0:first</a>
    /// </summary>
    let first = dcatVocabulary.prefixId.prefix "first"
    /// <summary>
    ///   <para>rdfs:comment : Funkce entity či agenta ve vztahu k jiné entitě či zdroji.rdfs:comment : La función de una entidad o agente con respecto a otra entidad o recurso.rdfs:comment : La funzione di un'entità o un agente rispetto ad un'altra entità o risorsa.rdfs:comment : The function of an entity or agent with respect to another entity or resource.rdfs:comment : Den funktion en entitet eller aktør har i forhold til en anden ressource.</para>
    ///   <para>rdfs:label : haRuolordfs:label : hadRolerdfs:label : sehraná rolerdfs:label : tiene rolrdfs:label : havde rolle</para>
    ///   <para>skos:changeNote : New property added in DCAT 2.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 2.skos:changeNote : Nueva propiedad agregada en DCAT 2.skos:changeNote : Nuova proprietà aggiunta in DCAT 2.</para>
    ///   <para>skos:definition : Funkce entity či agenta ve vztahu k jiné entitě či zdroji.skos:definition : La función de una entidad o agente con respecto a otra entidad o recurso.skos:definition : La funzione di un'entità o un agente rispetto ad un'altra entità o risorsa.skos:definition : The function of an entity or agent with respect to another entity or resource.skos:definition : Den funktion en entitet eller aktør har i forhold til en anden ressource.</para>
    ///   <para>skos:editorialNote : Agregada en DCAT para complementar prov:hadRole (cuyo uso está limitado a roles en el contexto de una actividad, con dominio prov:Association.skos:editorialNote : Introdotta in DCAT per completare prov:hadRole (il cui uso è limitato ai ruoli nel contesto di un'attività, con il dominio di prov:Association.skos:editorialNote : Introduced into DCAT to complement prov:hadRole (whose use is limited to roles in the context of an activity, with the domain of prov:Association.skos:editorialNote : Přidáno do DCAT pro doplnění vlastnosti prov:hadRole (jejíž užití je omezeno na role v kontextu aktivity, s definičním oborem prov:Association).skos:editorialNote : Introduceret i DCAT for at supplere prov:hadRole (hvis anvendelse er begrænset til roller i forbindelse med en aktivitet med domænet prov:Association).</para>
    ///   <para>skos:scopeNote : May be used in a qualified-attribution to specify the role of an Agent with respect to an Entity. It is recommended that the value be taken from a controlled vocabulary of agent roles, such as http://registry.it.csiro.au/def/isotc211/CI_RoleCode.skos:scopeNote : May be used in a qualified-relation to specify the role of an Entity with respect to another Entity.  It is recommended that the value be taken from a controlled vocabulary of entity roles such as: ISO 19115 DS_AssociationTypeCode http://registry.it.csiro.au/def/isotc211/DS_AssociationTypeCode; IANA Registry of Link Relations https://www.iana.org/assignments/link-relation; DataCite metadata schema; MARC relators https://id.loc.gov/vocabulary/relators.skos:scopeNote : Může být použito v kvalifikovaném přiřazení pro specifikaci role Agenta ve vztahu k Entitě. Je doporučeno hodnotu vybrat z řízeného slovníku rolí agentů, jako například http://registry.it.csiro.au/def/isotc211/CI_RoleCode.skos:scopeNote : Může být použito v kvalifikovaném vztahu pro specifikaci role Entity ve vztahu k jiné Entitě. Je doporučeno použít hodnotu z řízeného slovníku rolí entit, jako například ISO 19115 DS_AssociationTypeCode http://registry.it.csiro.au/def/isotc211/DS_AssociationTypeCode, IANA Registry of Link Relations https://www.iana.org/assignments/link-relation, DataCite metadata schema, MARC relators https://id.loc.gov/vocabulary/relators.skos:scopeNote : Puede usarse en una atribución cualificada para especificar el rol de un Agente con respecto a una Entidad. Se recomienda que el valor sea de un vocabulario controlado de roles de agentes, como por ejemplo http://registry.it.csiro.au/def/isotc211/CI_RoleCode.skos:scopeNote : Puede usarse en una atribución cualificada para especificar el rol de una Entidad con respecto a otra Entidad. Se recomienda que su valor se tome de un vocabulario controlado de roles de entidades como por ejemplo: ISO 19115 DS_AssociationTypeCode http://registry.it.csiro.au/def/isotc211/DS_AssociationTypeCode; IANA Registry of Link Relations https://www.iana.org/assignments/link-relation; esquema de metadatos de DataCite; MARC relators https://id.loc.gov/vocabulary/relators.skos:scopeNote : Può essere utilizzata in una relazione qualificata per specificare il ruolo di un'entità rispetto a un'altra entità. Si raccomanda che il valore sia preso da un vocabolario controllato di ruoli di entità come ISO 19115 DS_AssociationTypeCode http://registry.it.csiro.au/def/isotc211/DS_AssociationTypeCode, IANA Registry of Link Relations https://www.iana.org/assignments/link-relation, DataCite metadata schema, o MARC relators https://id.loc.gov/vocabulary/relators.skos:scopeNote : Può essere utilizzato in un'attribuzione qualificata per specificare il ruolo di un agente rispetto a un'entità. Si raccomanda che il valore sia preso da un vocabolario controllato di ruoli di agente, come ad esempio http://registry.it.csiro.au/def/isotc211/CI_RoleCode.skos:scopeNote : Kan vendes ved kvalificerede krediteringer til at angive en aktørs rolle i forhold en entitet. Det anbefales at værdierne styres som et kontrolleret udfaldsrum med aktørroller, såsom http://registry.it.csiro.au/def/isotc211/CI_RoleCode.</para>
    ///   <a href="http://www.w3.org/ns/dcat#hadRole">ns0:hadRole</a>
    /// </summary>
    let hadRole = dcatVocabulary.prefixId.prefix "hadRole"
    /// <summary>
    ///   <para>rdfs:comment : This resource has a more specific, versioned resource with equivalent content [PAV].rdfs:comment : Este recurso es más específico y versionado con contenido equivalente [PAV].rdfs:comment : Per questa risorsa esiste una risorsa più specifica e versionata, ma con lo stesso contenuto.</para>
    ///   <para>rdfs:label : has current versionrdfs:label : tiene versión actualrdfs:label : ha versione attuale</para>
    ///   <para>skos:changeNote : New property added in DCAT 3.skos:changeNote : Nueva propiedad agregada in DCAT 3.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 3.skos:changeNote : Nuova proprietà aggiunta in DCAT 3.skos:changeNote : Ny egenskab tilføjet i DCAT 3.</para>
    ///   <para>skos:definition : This resource has a more specific, versioned resource with equivalent content [PAV].skos:definition : Este recurso es más específico y versionado con contenido equivalente [PAV].skos:definition : Per questa risorsa esiste una risorsa più specifica e versionata, ma con lo stesso contenuto.</para>
    ///   <para>skos:scopeNote : This property is intended for relating a non-versioned or abstract resource to a single snapshot that can be used as a permalink to indicate the current version of the content [PAV].skos:scopeNote : Esta propepiedad está destinada a relacionar un recurso no versionado o abstracto con una versión instantánea que puede usarse como un enlace permanente a la versión actual del recurso [PAV].skos:scopeNote : Questa proprietà è usata per correlare una risorsa non versionata o astratta a un suo specifico snapshot che può essere usato come permalink per indicare la versione attuale del suo contenuto.skos:scopeNote : The notion of version used by this property is limited to versions resulting from revisions occurring to a resource as part of its life-cycle.skos:scopeNote : La noción de versión que se usa en esta propiedad está limitada a las versiones que resultan de revisiones de un recurso como parte de su ciclo de vida.skos:scopeNote : La nozione di versione usata da questa proprietà è limitata a versioni risultanti da revisioni a cui una risorsa è soggetta nel suo ciclo di vita.</para>
    ///   <a href="http://www.w3.org/ns/dcat#hasCurrentVersion">ns0:hasCurrentVersion</a>
    /// </summary>
    let hasCurrentVersion = dcatVocabulary.prefixId.prefix "hasCurrentVersion"
    /// <summary>
    ///   <para>rdfs:comment : This resource has a more specific, versioned resource [PAV].rdfs:comment : Este recurso tiene una versión específica.rdfs:comment : Per questa risorsa esiste una risorsa più specifica e versionata.</para>
    ///   <para>rdfs:label : has versionrdfs:label : tiene versiónrdfs:label : ha versione</para>
    ///   <para>skos:changeNote : New property added in DCAT 3.skos:changeNote : Nueva propiedad agregada in DCAT 3.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 3.skos:changeNote : Nuova proprietà aggiunta in DCAT 3.skos:changeNote : Ny egenskab tilføjet i DCAT 3.</para>
    ///   <para>skos:definition : This resource has a more specific, versioned resource [PAV].skos:definition : Este recurso tiene una versión específica.skos:definition : Per questa risorsa esiste una risorsa più specifica e versionata.</para>
    ///   <para>skos:scopeNote : This property is intended for relating a non-versioned or abstract resource to several versioned resources, e.g., snapshots [PAV].skos:scopeNote : Esta propiedad se utiliza para relacionar un recurso abstracto o no versionado de un recurso con varias versiones del recuros; por ejemplo, versiones intastáneas.skos:scopeNote : Questa proprietà è usata per correlare una risorsa non versionata o astratta a differenti risorse versionate, ad es., i relativi snapshot.skos:scopeNote : The notion of version used by this property is limited to versions resulting from revisions occurring to a resource as part of its life-cycle. Therefore, its semantics is more specific than its super-property dcterms:hasVersion, which makes use of a broader notion of version, including editions and adaptations.skos:scopeNote : La noción de versión que se usa en esta propiedad está limitada a las versiones que resultan de revisiones de un recurso como parte de su ciclo de vida. Por lo tanto, su semántica es más específica que su super-propiedad dcterns:hasVersion, la cuál hace uso de la noción más amplia de versión, incluyendo ediciones y adaptaciones.skos:scopeNote : La nozione di versione usata da questa proprietà è limitata a versioni risultanti da revisioni a cui una risorsa è soggetta nel suo ciclo di vita. Quindi la sua semantica è più specifica di quella della sua super-proprietà dcterms:hasVersion, che utilizza una nozione di versione più ampia, e include, ad es., edizioni e adattamenti.</para>
    ///   <a href="http://www.w3.org/ns/dcat#hasVersion">ns0:hasVersion</a>
    /// </summary>
    let hasVersion = dcatVocabulary.prefixId.prefix "hasVersion"
    let inCatalog = dcatVocabulary.prefixId.prefix "inCatalog"
    /// <summary>
    ///   <para>rdfs:comment : A dataset series of which the dataset is part.rdfs:comment : Una serie de conjuntos de datos del cuál un conjunto de datos es parte.rdfs:comment : Una serie di dataset di cui questo dataset fa parte.</para>
    ///   <para>rdfs:label : in seriesrdfs:label : en serierdfs:label : in serie</para>
    ///   <para>skos:changeNote : New property added in DCAT 3.skos:changeNote : Nueva propiedad agregada in DCAT 3.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 3.skos:changeNote : Nuova proprietà aggiunta in DCAT 3.skos:changeNote : Ny egenskab tilføjet i DCAT 3.</para>
    ///   <para>skos:definition : A dataset series of which the dataset is part.skos:definition : Una serie de conjuntos de datos del cuál un conjunto de datos es parte.skos:definition : Una serie di dataset di cui questo dataset fa parte.</para>
    ///   <a href="http://www.w3.org/ns/dcat#inSeries">ns0:inSeries</a>
    /// </summary>
    let inSeries = dcatVocabulary.prefixId.prefix "inSeries"
    let isDistributionOf = dcatVocabulary.prefixId.prefix "isDistributionOf"
    let isVersionOf = dcatVocabulary.prefixId.prefix "isVersionOf"
    /// <summary>
    ///   <para>rdfs:comment : A keyword or tag describing a resource.rdfs:comment : Klíčové slovo nebo značka popisující zdroj.rdfs:comment : Un mot-clé ou étiquette décrivant une ressource.rdfs:comment : Una palabra clave o etiqueta que describe un recurso.rdfs:comment : Una parola chiave o un'etichetta per descrivere la risorsa.rdfs:comment : Μία λέξη-κλειδί ή μία ετικέτα που περιγράφει το σύνολο δεδομένων.rdfs:comment : كلمة  مفتاحيه توصف قائمة البياناتrdfs:comment : データセットを記述しているキーワードまたはタグ。rdfs:comment : Et nøgleord eller tag til beskrivelse af en ressource.</para>
    ///   <para>rdfs:label : keywordrdfs:label : klíčové slovordfs:label : mot-clés rdfs:label : palabra claverdfs:label : parola chiaverdfs:label : λέξη-κλειδίrdfs:label : كلمة  مفتاحية rdfs:label : キーワード/タグrdfs:label : nøgleord</para>
    ///   <para>skos:definition : A keyword or tag describing a resource.skos:definition : Klíčové slovo nebo značka popisující zdroj.skos:definition : Un mot-clé ou étiquette décrivant une ressource.skos:definition : Una palabra clave o etiqueta que describe un recurso.skos:definition : Una parola chiave o un'etichetta per descrivere la risorsa.skos:definition : Μία λέξη-κλειδί ή μία ετικέτα που περιγράφει το σύνολο δεδομένων.skos:definition : كلمة  مفتاحيه توصف قائمة البياناتskos:definition : データセットを記述しているキーワードまたはタグ。skos:definition : Et nøgleord eller tag til beskrivelse af en ressource.</para>
    ///   <a href="http://www.w3.org/ns/dcat#keyword">ns0:keyword</a>
    /// </summary>
    let keyword = dcatVocabulary.prefixId.prefix "keyword"
    /// <summary>
    ///   <para>rdfs:comment : A Web page that can be navigated to in a Web browser to gain access to the catalog, a dataset, its distributions and/or additional information.rdfs:comment : Una pagina web che può essere navigata per ottenere l'accesso al catalogo, ad un dataset, alle distribuzioni del dataset e/o ad informazioni addizionali.rdfs:comment : Una página web que puede ser visitada en un explorador Web para tener acceso el catálogo, un conjunto de datos, sus distribuciones y/o información adicional.rdfs:comment : Une page Web accessible par un navigateur Web donnant accès au catalogue, un jeu de données, ses distributions et/ou des informations additionnelles.rdfs:comment : Webová stránka, na kterou lze pro získání přístupu ke katalogu, datové sadě, jejím distribucím a/nebo dalším informacím přistoupit webovým prohlížečem.rdfs:comment : Μία ιστοσελίδα πλοηγίσιμη μέσω ενός φυλλομετρητή (Web browser) που δίνει πρόσβαση στο σύνολο δεδομένων, τις διανομές αυτού ή/και επιπρόσθετες πληροφορίες.rdfs:comment : صفحة وب يمكن من خلالها الوصول الى قائمة البيانات أو إلى معلومات إضافية متعلقة بها rdfs:comment : データセット、その配信および（または）追加情報にアクセスするためにウエブ・ブラウザでナビゲートできるウェブページ。rdfs:comment : En webside som der kan navigeres til i en webbrowser for at få adgang til kataloget, et datasæt, dets distributioner og/eller yderligere information.</para>
    ///   <para>rdfs:label : landing pagerdfs:label : page d'atterrissagerdfs:label : pagina di destinazionerdfs:label : página de destinordfs:label : vstupní stránkardfs:label : ιστοσελίδα αρχικής πρόσβασηςrdfs:label : صفحة وصولrdfs:label : ランディング・ページrdfs:label : destinationsside</para>
    ///   <para>skos:definition : A Web page that can be navigated to in a Web browser to gain access to the catalog, a dataset, its distributions and/or additional information.skos:definition : Una pagina web che può essere navigata per ottenere l'accesso al catalogo, ad un dataset, alle distribuzioni del dataset e/o ad informazioni addizionali.skos:definition : Una página web que puede ser visitada en un explorador Web para tener acceso el catálogo, un conjunto de datos, sus distribuciones y/o información adicional.skos:definition : Une page Web accessible par un navigateur Web donnant accès au catalogue, un jeu de données, ses distributions et/ou des informations additionnelles.skos:definition : Webová stránka, na kterou lze pro získání přístupu ke katalogu, datové sadě, jejím distribucím a/nebo dalším informacím přistoupit webovým prohlížečem.skos:definition : Μία ιστοσελίδα πλοηγίσιμη μέσω ενός φυλλομετρητή (Web browser) που δίνει πρόσβαση στο σύνολο δεδομένων, τις διανομές αυτού ή/και επιπρόσθετες πληροφορίες.skos:definition : صفحة وب يمكن من خلالها الوصول الى قائمة البيانات أو إلى معلومات إضافية متعلقة بها skos:definition : データセット、その配信および（または）追加情報にアクセスするためにウエブ・ブラウザでナビゲートできるウェブページ。skos:definition : En webside som en webbrowser kan navigeres til for at få adgang til kataloget, et datasæt, dets distritbutioner og/eller yderligere information.</para>
    ///   <para>skos:scopeNote : If the distribution(s) are accessible only through a landing page (i.e. direct download URLs are not known), then the landing page link should be duplicated as accessURL on a distribution.skos:scopeNote : Pokud je distribuce dostupná pouze přes vstupní stránku, t.j. přímý URL odkaz ke stažení není znám, URL přístupové stránky by mělo být duplikováno ve vlastnosti distribuce accessURL.skos:scopeNote : Se la distribuzione è accessibile solo attraverso una pagina di destinazione (cioè, un URL di download diretto non è noto), il link alla pagina di destinazione deve essere duplicato come accessURL sulla distribuzione.skos:scopeNote : Si la distribución es accesible solamente través de una página de aterrizaje (i.e., no se conoce una URL de descarga directa), entonces el enlance a la página de aterrizaje debe ser duplicado como accessURL sobre la distribución.skos:scopeNote : Si la distribution est seulement accessible à travers une page d'atterrissage (exple. pas de connaissance d'URLS de téléchargement direct ), alors le lien de la page d'atterrissage doit être dupliqué comme accessURL sur la distribution.skos:scopeNote : Αν η/οι διανομή/ές είναι προσβάσιμη/ες μόνο μέσω μίας ιστοσελίδας αρχικής πρόσβασης (δηλαδή αν δεν υπάρχουν γνωστές διευθύνσεις άμεσης μεταφόρτωσης), τότε ο σύνδεσμος της ιστοσελίδας αρχικής πρόσβασης πρέπει να αναπαραχθεί ως accessURL σε μία διανομή.skos:scopeNote : ランディング・ページを通じてしか配信にアクセスできない場合（つまり、直接的なダウンロードURLが不明）には、配信におけるaccessURLとしてランディング・ページのリンクをコピーすべきです（SHOULD）。skos:scopeNote : Hvis en eller flere distributioner kun er tilgængelige via en destinationsside (dvs. en URL til direkte download er ikke kendt), så bør destinationssidelinket gentages som adgangsadresse for en distribution.</para>
    ///   <a href="http://www.w3.org/ns/dcat#landingPage">ns0:landingPage</a>
    /// </summary>
    let landingPage = dcatVocabulary.prefixId.prefix "landingPage"
    /// <summary>
    ///   <para>rdfs:comment : The last resource in an ordered collection or series of resources, to which the current resource belongs.rdfs:comment : El último recurso en una colección ordenada o serie de recursos, al que el recurso pertenece.rdfs:comment : L'ultima risorsa in una collezione ordinata o in una serie di risorse, di cui la risorsa fa parte.</para>
    ///   <para>rdfs:label : lastrdfs:label : últimordfs:label : ultimo</para>
    ///   <para>skos:changeNote : New property added in DCAT 3.skos:changeNote : Nueva propiedad agregada in DCAT 3.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 3.skos:changeNote : Nuova proprietà aggiunta in DCAT 3.skos:changeNote : Ny egenskab tilføjet i DCAT 3.</para>
    ///   <para>skos:definition : The last resource in an ordered collection or series of resources, to which the current resource belongs.skos:definition : El último recurso en una colección ordenada o serie de recursos, al que el recurso pertenece.skos:definition : L'ultima risorsa in una collezione ordinata o in una serie di risorse, di cui la risorsa fa parte.</para>
    ///   <para>skos:scopeNote : In DCAT this property is used for resources belonging to a dcat:DatasetSeries.skos:scopeNote : En DCAT esta propiedad se usa para recursos que pertenecen a una dcat:DatasetSeries.skos:scopeNote : In DCAT questa proprietà è usata per risorse che fanno parte di una dcat:DatasetSeries.</para>
    ///   <a href="http://www.w3.org/ns/dcat#last">ns0:last</a>
    /// </summary>
    let last = dcatVocabulary.prefixId.prefix "last"
    /// <summary>
    ///   <para>rdfs:comment : Cette propriété doit être utilisée quand c'est définit le type de média de la distribution en IANA, sinon dcterms:format DOIT être utilisé avec différentes valeurs.rdfs:comment : Esta propiedad debe ser usada cuando está definido el tipo de media de la distribución en IANA, de otra manera dcterms:format puede ser utilizado con diferentes valoresrdfs:comment : Il tipo di media della distribuzione come definito da IANArdfs:comment : The media type of the distribution as defined by IANArdfs:comment : Typ média distribuce definovaný v IANA.rdfs:comment : Η ιδιότητα αυτή ΘΑ ΠΡΕΠΕΙ να χρησιμοποιείται όταν ο τύπος μέσου μίας διανομής είναι ορισμένος στο IANA, αλλιώς η ιδιότητα dcterms:format ΔΥΝΑΤΑΙ να χρησιμοποιηθεί με διαφορετικές τιμές.rdfs:comment : يجب استخدام هذه الخاصية إذا كان نوع الملف معرف ضمن IANArdfs:comment : このプロパティーは、配信のメディア・タイプがIANAで定義されているときに使用すべきで（SHOULD）、そうでない場合には、dcterms:formatを様々な値と共に使用できます（MAY）。rdfs:comment : Medietypen for distributionen som den er defineret af IANA.</para>
    ///   <para>rdfs:label : media typerdfs:label : tipo de mediardfs:label : tipo di mediardfs:label : typ médiardfs:label : type de médiardfs:label : τύπος μέσουrdfs:label : نوع الميدياrdfs:label : メディア・タイプrdfs:label : medietype</para>
    ///   <para>skos:changeNote : Obor hodnot dcat:mediaType byl zúžen v této revizi DCAT.skos:changeNote : The range of dcat:mediaType has been tightened as part of the revision of DCAT.skos:changeNote : Il range di dcat:mediaType è stato ristretto  come parte della revisione di DCAT.</para>
    ///   <para>skos:definition : Cette propriété doit être utilisée quand c'est définit le type de média de la distribution en IANA, sinon dcterms:format DOIT être utilisé avec différentes valeurs.skos:definition : Esta propiedad debe ser usada cuando está definido el tipo de media de la distribución en IANA, de otra manera dcterms:format puede ser utilizado con diferentes valores.skos:definition : Il tipo di media della distribuzione come definito da IANA.skos:definition : The media type of the distribution as defined by IANA.skos:definition : Typ média distribuce definovaný v IANA.skos:definition : Η ιδιότητα αυτή ΘΑ ΠΡΕΠΕΙ να χρησιμοποιείται όταν ο τύπος μέσου μίας διανομής είναι ορισμένος στο IANA, αλλιώς η ιδιότητα dcterms:format ΔΥΝΑΤΑΙ να χρησιμοποιηθεί με διαφορετικές τιμές.skos:definition : يجب استخدام هذه الخاصية إذا كان نوع الملف معرف ضمن IANAskos:definition : このプロパティーは、配信のメディア・タイプがIANAで定義されているときに使用すべきで（SHOULD）、そうでない場合には、dcterms:formatを様々な値と共に使用できます（MAY）。skos:definition : Medietypen for distributionen som den er defineret af IANA.</para>
    ///   <para>skos:editorialNote : Status: English Definition text modified by DCAT revision team, Italian and Czech translation provided, other translations pending. Note some inconsistency on def vs. usage.</para>
    ///   <para>skos:scopeNote : Esta propiedad DEBERÍA usarse cuando el 'media type' de la distribución está definido en el registro IANA de 'media types' https://www.iana.org/assignments/media-types/, de lo contrario, dcterms:format PUEDE usarse con distintos valores.skos:scopeNote : Questa proprietà DEVE essere usata quando il tipo di media della distribuzione è definito nel registro dei tipi di media IANA https://www.iana.org/assignments/media-types/, altrimenti dcterms:format PUO 'essere usato con differenti valori.skos:scopeNote : Tato vlastnost BY MĚLA být použita, je-li typ média distribuce definován v registru IANA https://www.iana.org/assignments/media-types/. V ostatních případech MŮŽE být použita vlastnost dcterms:format s jinými hodnotami.skos:scopeNote : This property SHOULD be used when the media type of the distribution is defined in the IANA media types registry https://www.iana.org/assignments/media-types/, otherwise dcterms:format MAY be used with different values.skos:scopeNote : Denne egenskab BØR anvendes hvis distributionens medietype optræder i 'IANA media types registry' https://www.iana.org/assignments/media-types/, ellers KAN egenskaben dcterms:format anvendes med et andet udfaldsrum.</para>
    ///   <a href="http://www.w3.org/ns/dcat#mediaType">ns0:mediaType</a>
    /// </summary>
    let mediaType = dcatVocabulary.prefixId.prefix "mediaType"
    let next = dcatVocabulary.prefixId.prefix "next"
    let nextVersion = dcatVocabulary.prefixId.prefix "nextVersion"
    /// <summary>
    ///   <para>rdfs:comment : Balíčkový formát souboru, ve kterém je jeden či více souborů seskupeno dohromady, např. aby bylo možné stáhnout sadu souvisejících souborů naráz.rdfs:comment : El formato del archivo en que se agrupan uno o más archivos de datos, e.g. para permitir que un conjunto de archivos relacionados se bajen juntos.rdfs:comment : Il formato di impacchettamento della distribuzione in cui uno o più file di dati sono raggruppati insieme, ad es. per abilitare un insieme di file correlati da scaricare insieme.rdfs:comment : The package format of the distribution in which one or more data files are grouped together, e.g. to enable a set of related files to be downloaded together.rdfs:comment : Format til pakning af data med henblik på distribution af en eller flere relaterede datafiler der samles til en enhed med henblik på samlet distribution. </para>
    ///   <para>rdfs:label : formato de empaquetadordfs:label : formato di impacchettamentordfs:label : formát balíčkurdfs:label : packaging formatrdfs:label : pakkeformat</para>
    ///   <para>skos:changeNote : New property added in DCAT 2.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 2.skos:changeNote : Nueva propiedad agregada en DCAT 2.skos:changeNote : Nuova proprietà aggiunta in DCAT 2.skos:changeNote : Ny egenskab tilføjet i DCAT 2.</para>
    ///   <para>skos:definition : Balíčkový formát souboru, ve kterém je jeden či více souborů seskupeno dohromady, např. aby bylo možné stáhnout sadu souvisejících souborů naráz.skos:definition : El formato del archivo en que se agrupan uno o más archivos de datos, e.g. para permitir que un conjunto de archivos relacionados se bajen juntos.skos:definition : Il formato di impacchettamento della distribuzione in cui uno o più file di dati sono raggruppati insieme, ad es. per abilitare un insieme di file correlati da scaricare insieme.skos:definition : The package format of the distribution in which one or more data files are grouped together, e.g. to enable a set of related files to be downloaded together.</para>
    ///   <para>skos:scopeNote : Esta propiedad se debe usar cuando los archivos de la distribución están empaquetados, por ejemplo en un archivo TAR, Frictionless Data Package o Bagit. El formato DEBERÍA expresarse usando un 'media type', tales como los definidos en el registro IANA de 'media types' https://www.iana.org/assignments/media-types/, si está disponibles.skos:scopeNote : Questa proprietà deve essere utilizzata quando i file nella distribuzione sono impacchettati, ad esempio in un file TAR, Frictionless Data Package o Bagit. Il formato DOVREBBE essere espresso utilizzando un tipo di supporto come definito dal registro dei tipi di media IANA https://www.iana.org/assignments/media-types/, se disponibili.skos:scopeNote : Tato vlastnost se použije, když jsou soubory v distribuci zabaleny, např. v souboru TAR, v balíčku Frictionless Data Package nebo v souboru Bagit. Formát BY MĚL být vyjádřen pomocí typu média definovaného v registru IANA https://www.iana.org/assignments/media-types/, pokud existuje.skos:scopeNote : This property to be used when the files in the distribution are packaged, e.g. in a TAR file, a Frictionless Data Package or a Bagit file. The format SHOULD be expressed using a media type as defined by IANA media types registry https://www.iana.org/assignments/media-types/, if available.skos:scopeNote : Denne egenskab kan anvendes hvis filerne i en distribution er pakket, fx i en TAR-fil, en Frictionless Data Package eller en Bagit-fil. Formatet BØR udtrykkes ved en medietype som defineret i 'IANA media types registry', hvis der optræder en relevant medietype dér: https://www.iana.org/assignments/media-types/.</para>
    ///   <a href="http://www.w3.org/ns/dcat#packageFormat">ns0:packageFormat</a>
    /// </summary>
    let packageFormat = dcatVocabulary.prefixId.prefix "packageFormat"
    /// <summary>
    ///   <para>rdfs:comment : The previous resource (before the current one) in an ordered collection or series of resources.rdfs:comment : La risorsa precedente a quella attuale in una collezione ordinata o in una serie di risorse.</para>
    ///   <para>rdfs:label : previousrdfs:label : previordfs:label : precedente</para>
    ///   <para>skos:changeNote : New property added in DCAT 3.skos:changeNote : Nueva propiedad agregada in DCAT 3.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 3.skos:changeNote : Nuova proprietà aggiunta in DCAT 3.skos:changeNote : Ny egenskab tilføjet i DCAT 3.</para>
    ///   <para>skos:definition : The previous resource (before the current one) in an ordered collection or series of resources.skos:definition : La risorsa precedente a quella attuale in una collezione ordinata o in una serie di risorse.</para>
    ///   <para>skos:scopeNote : In DCAT this property is used for resources belonging to a dcat:DatasetSeries.skos:scopeNote : En DCAT esta propiedad se usa para recursos que pertenecen a una dcat:DatasetSeries.skos:scopeNote : In DCAT questa proprietà è usata per risorse che fanno parte di una dcat:DatasetSeries.skos:scopeNote : It is important to note that this property is different from dcat:previousVersion, as it does not denote a previous version of the same resource, but a distinct resource immediately preceding the current one in an ordered collection of resources.skos:scopeNote : È importante notare che questa proprietà è diversa da dcat:previousVersion, dato che non indica una versione precedente della stessa risorsa, ma una risorsa distinta che precede immediatamente quella attuale in una collezione ordinata di risorse.</para>
    ///   <a href="http://www.w3.org/ns/dcat#prev">ns0:prev</a>
    /// </summary>
    let prev = dcatVocabulary.prefixId.prefix "prev"
    /// <summary>
    ///   <para>rdfs:comment : The previous version of a resource in a lineage [PAV].rdfs:comment : La versione precedente di una risorsa.</para>
    ///   <para>rdfs:label : previous versionrdfs:label : versión anteriorrdfs:label : versione precedente</para>
    ///   <para>skos:definition : The previous version of a resource in a lineage [PAV].skos:definition : La versione precedente di una risorsa.</para>
    ///   <para>skos:scopeNote : This property is meant to be used to specify a version chain, consisting of snapshots of a resource.skos:scopeNote : Questa proprietà è usata per specificare una catena di versioni, costituita da snapshot di una risorsa.skos:scopeNote : The notion of version used by this property is limited to versions resulting from revisions occurring to a resource as part of its life-cycle. One of the typical cases here is representing the history of the versions of a dataset that have been released over time.skos:scopeNote : La nozione di versione usata da questa proprietà è limitata a versioni risultanti da revisioni a cui una risorsa è soggetta nel suo ciclo di vita. Uno dei casi tipici è la rappresentazione della storia delle versioni di un dataset, che sono state pubblicate nel corso del tempo.</para>
    ///   <para>skos:changeNote : New property added in DCAT 3.skos:changeNote : Nueva propiedad agregada in DCAT 3.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 3.skos:changeNote : Nuova proprietà aggiunta in DCAT 3.skos:changeNote : Ny egenskab tilføjet i DCAT 3.</para>
    ///   <a href="http://www.w3.org/ns/dcat#previousVersion">ns0:previousVersion</a>
    /// </summary>
    let previousVersion = dcatVocabulary.prefixId.prefix "previousVersion"
    /// <summary>
    ///   <para>rdfs:comment : Enlace a una descripción de la relación con otro recurso.rdfs:comment : Link a una descrizione di una relazione con un'altra risorsa.rdfs:comment : Link to a description of a relationship with another resource.rdfs:comment : Odkaz na popis vztahu s jiným zdrojem.rdfs:comment : Reference til en beskrivelse af en relation til en anden ressource.</para>
    ///   <para>rdfs:label : kvalifikovaný vztahrdfs:label : qualified relationrdfs:label : relación calificadardfs:label : relazione qualificatardfs:label : Kvalificeret relation</para>
    ///   <para>skos:changeNote : New property added in DCAT 2.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 2.skos:changeNote : Nuova proprietà aggiunta in DCAT 2.skos:changeNote : Propiedad nueva añadida en DCAT 2.skos:changeNote : Ny egenskab tilføjet i DCAT 2.</para>
    ///   <para>skos:definition : Enlace a una descripción de la relación con otro recurso.skos:definition : Link a una descrizione di una relazione con un'altra risorsa.skos:definition : Link to a description of a relationship with another resource.skos:definition : Odkaz na popis vztahu s jiným zdrojem.skos:definition : Reference til en beskrivelse af en relation til en anden ressource.</para>
    ///   <para>skos:editorialNote : Introdotta in DCAT per integrare le altre relazioni qualificate di PROV.skos:editorialNote : Introduced into DCAT to complement the other PROV qualified relations. skos:editorialNote : Přidáno do DCAT k doplnění jiných kvalifikovaných vztahů ze slovníku PROV.skos:editorialNote : Se incluyó en DCAT para complementar las relaciones calificadas disponibles en PROV.skos:editorialNote : Introduceret i DCAT med henblik på at supplere de øvrige kvalificerede relationer fra PROV. </para>
    ///   <para>skos:scopeNote : Použito pro odkazování na jiný zdroj, kde druh vztahu je znám, ale neodpovídá standardním vlastnostem ze slovníku Dublin Core (dcterms:hasPart, dcterms:isPartOf, dcterms:conformsTo, dcterms:isFormatOf, dcterms:hasFormat, dcterms:isVersionOf, dcterms:hasVersion, dcterms:replaces, dcterms:isReplacedBy, dcterms:references, dcterms:isReferencedBy, dcterms:requires, dcterms:isRequiredBy) či slovníku PROV-O (prov:wasDerivedFrom, prov:wasInfluencedBy, prov:wasQuotedFrom, prov:wasRevisionOf, prov:hadPrimarySource, prov:alternateOf, prov:specializationOf).skos:scopeNote : Se usa para asociar con otro recurso para el cuál la naturaleza de la relación es conocida pero no es ninguna de las propiedades que provee el estándar Dublin Core (dcterms:hasPart, dcterms:isPartOf, dcterms:conformsTo, dcterms:isFormatOf, dcterms:hasFormat, dcterms:isVersionOf, dcterms:hasVersion, dcterms:replaces, dcterms:isReplacedBy, dcterms:references, dcterms:isReferencedBy, dcterms:requires, dcterms:isRequiredBy) or PROV-O properties (prov:wasDerivedFrom, prov:wasInfluencedBy, prov:wasQuotedFrom, prov:wasRevisionOf, prov:hadPrimarySource, prov:alternateOf, prov:specializationOf).skos:scopeNote : Used to link to another resource where the nature of the relationship is known but does not match one of the standard Dublin Core properties (dcterms:hasPart, dcterms:isPartOf, dcterms:conformsTo, dcterms:isFormatOf, dcterms:hasFormat, dcterms:isVersionOf, dcterms:hasVersion, dcterms:replaces, dcterms:isReplacedBy, dcterms:references, dcterms:isReferencedBy, dcterms:requires, dcterms:isRequiredBy) or PROV-O properties (prov:wasDerivedFrom, prov:wasInfluencedBy, prov:wasQuotedFrom, prov:wasRevisionOf, prov:hadPrimarySource, prov:alternateOf, prov:specializationOf).skos:scopeNote : Viene utilizzato per associarsi a un'altra risorsa nei casi per i quali la natura della relazione è nota ma non è alcuna delle proprietà fornite dallo standard Dublin Core (dcterms:hasPart, dcterms:isPartOf, dcterms:conformsTo, dcterms:isFormatOf, dcterms:hasFormat , dcterms:isVersionOf, dcterms:hasVersion, dcterms:replaces, dcterms:isReplacedBy, dcterms:references, dcterms:isReferencedBy, dcterms:require, dcterms:isRequiredBy) o dalle proprietà fornite da PROV-O (prov:wasDerivedFrom, prov:wasInfluencedBy, prov:wasQuotedFrom , prov:wasRevisionOf, prov:hadPrimarySource, prov:alternateOf, prov:specializationOf).skos:scopeNote : Anvendes til at referere til en anden ressource hvor relationens betydning er kendt men ikke matcher en af de standardiserede egenskaber fra Dublin Core (dcterms:hasPart, dcterms:isPartOf, dcterms:conformsTo, dcterms:isFormatOf, dcterms:hasFormat, dcterms:isVersionOf, dcterms:hasVersion, dcterms:replaces, dcterms:isReplacedBy, dcterms:references, dcterms:isReferencedBy, dcterms:requires, dcterms:isRequiredBy) eller PROV-O-egenskaber (prov:wasDerivedFrom, prov:wasInfluencedBy, prov:wasQuotedFrom, prov:wasRevisionOf, prov:hadPrimarySource, prov:alternateOf, prov:specializationOf).</para>
    ///   <a href="http://www.w3.org/ns/dcat#qualifiedRelation">ns0:qualifiedRelation</a>
    /// </summary>
    let qualifiedRelation = dcatVocabulary.prefixId.prefix "qualifiedRelation"
    /// <summary>
    ///   <para>rdfs:comment : A record describing the registration of a single dataset or data service that is part of the catalog.rdfs:comment : Describe la registración de un conjunto de datos o un servicio de datos en el catálogo.rdfs:comment : Propojuje katalog a jeho záznamy.rdfs:comment : Relie un catalogue à ses registres.rdfs:comment : Un record che descrive la registrazione di un singolo set di dati o di un servizio dati che fa parte del catalogo.rdfs:comment : Záznam popisující registraci jedné datové sady či datové služby jakožto součásti katalogu.rdfs:comment : Συνδέει έναν κατάλογο με τις καταγραφές του.rdfs:comment : تربط الفهرس بسجل ضمنهrdfs:comment : カタログの一部であるカタログ・レコード。rdfs:comment : En post der beskriver registreringen af et enkelt datasæt eller en datatjeneste som er opført i kataloget.</para>
    ///   <para>rdfs:label : recordrdfs:label : recordrdfs:label : registrerdfs:label : registrordfs:label : záznamrdfs:label : καταγραφήrdfs:label : سجلrdfs:label : カタログ・レコードrdfs:label : post</para>
    ///   <para>skos:altLabel : har post</para>
    ///   <para>skos:definition : A record describing the registration of a single dataset or data service that is part of the catalog.skos:definition : Describe la registración de un conjunto de datos o un servicio de datos en el catálogo.skos:definition : Propojuje katalog a jeho záznamy.skos:definition : Relie un catalogue à ses registres.skos:definition : Un record che descrive la registrazione di un singolo set di dati o di un servizio dati che fa parte del catalogo.skos:definition : Záznam popisující registraci jedné datové sady či datové služby jakožto součásti katalogu.skos:definition : Συνδέει έναν κατάλογο με τις καταγραφές του.skos:definition : تربط الفهرس بسجل ضمنهskos:definition : カタログの一部であるカタログ・レコード。skos:definition : En post der beskriver registreringen af et enkelt datasæt eller en datatjeneste som er opført i kataloget.</para>
    ///   <para>skos:editorialNote : Status: English, Italian, Spanish and Czech Definitions modified by DCAT revision team, other translations pending.</para>
    ///   <a href="http://www.w3.org/ns/dcat#record">ns0:record</a>
    /// </summary>
    let record = dcatVocabulary.prefixId.prefix "record"
    /// <summary>
    ///   <para>rdfs:comment : A resource that is listed in the catalog.rdfs:comment : Una risorsa elencata nel catalogo.</para>
    ///   <para>rdfs:label : resourcerdfs:label : risorsa</para>
    ///   <para>skos:changeNote : New property added in DCAT 3.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 3.skos:changeNote : Nueva propiedad agregada en DCAT 3.skos:changeNote : Nuova proprietà aggiunta in DCAT 3.</para>
    ///   <para>skos:definition : A resource that is listed in the catalog.skos:definition : Una risorsa elencata nel catalogo.</para>
    ///   <para>skos:editorialNote : Status: English Definition text modified by DCAT 3 revision team, translations pending.</para>
    ///   <para>skos:scopeNote : This is the most general predicate for membership of a catalog. Use of a more specific sub-property is recommended when available.skos:scopeNote : Questo è il predicate più generale per indicare l'appartenenza di una risorsa a un catalogo. Si raccomanda l'uso di una proprietà più specifica, quando disponibile.skos:scopeNote : See also:	Sub-properties of dcat:resource in particular dcat:dataset, dcat:catalog, dcat:service.skos:scopeNote : Vd. anche: Le sottoproprietà di dcat:resource, in particolare: dcat:dataset, dcat:catalog, dcat:service.</para>
    ///   <a href="http://www.w3.org/ns/dcat#resource">ns0:resource</a>
    /// </summary>
    let resource = dcatVocabulary.prefixId.prefix "resource"
    let seriesMember = dcatVocabulary.prefixId.prefix "seriesMember"
    /// <summary>
    ///   <para>rdfs:comment : A collection of data that this DataService can distribute.rdfs:comment : Kolekce dat, kterou je tato Datová služba schopna poskytnout.rdfs:comment : Una colección de datos que este Servicio de Datos puede distribuir.rdfs:comment : Una raccolta di dati che questo DataService può distribuire.rdfs:comment : En samling af data som denne datatjeneste kan distribuere.</para>
    ///   <para>rdfs:label : poskytuje datovou sadurdfs:label : provee conjunto de datosrdfs:label : serve set di datirdfs:label : serves datasetrdfs:label : datatjeneste for datasæt</para>
    ///   <para>skos:altLabel : distribuererskos:altLabel : udstillerskos:altLabel : ekspederer</para>
    ///   <para>skos:changeNote : New property in DCAT 2.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 2.skos:changeNote : Nueva propiedad agregada en DCAT 2.skos:changeNote : Nuova proprietà in DCAT 2.</para>
    ///   <para>skos:definition : A collection of data that this DataService can distribute.skos:definition : Kolekce dat, kterou je tato Datová služba schopna poskytnout.skos:definition : Una colección de datos que este Servicio de Datos puede distribuir.skos:definition : Una raccolta di dati che questo DataService può distribuire.skos:definition : En samling af data som denne datatjeneste kan distribuere.</para>
    ///   <a href="http://www.w3.org/ns/dcat#servesDataset">ns0:servesDataset</a>
    /// </summary>
    let servesDataset = dcatVocabulary.prefixId.prefix "servesDataset"
    /// <summary>
    ///   <para>rdfs:comment : A service that is listed in the catalog.rdfs:comment : Umístění či přístupový bod registrovaný v katalogu.rdfs:comment : Un sitio o 'endpoint' que está listado en el catálogo.rdfs:comment : Un sito o endpoint elencato nel catalogo.rdfs:comment : Et websted eller et endpoint som er opført i kataloget.</para>
    ///   <para>rdfs:label : servicerdfs:label : serviciordfs:label : serviziordfs:label : službardfs:label : datatjeneste</para>
    ///   <para>skos:altLabel : har datatjenesteskos:altLabel : has service</para>
    ///   <para>skos:changeNote : New property added in DCAT 2.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 2.skos:changeNote : Nueva propiedad añadida en DCAT 2.skos:changeNote : Nuova proprietà aggiunta in DCAT 2.</para>
    ///   <para>skos:definition : A service that is listed in the catalog.skos:definition : Umístění či přístupový bod registrovaný v katalogu.skos:definition : Un sitio o 'endpoint' que está listado en el catálogo.skos:definition : Un sito o endpoint elencato nel catalogo.skos:definition : Et websted eller et endpoint som er opført i kataloget.</para>
    ///   <para>skos:editorialNote : Status: English Definition text modified by DCAT 3 revision team, translations pending.</para>
    ///   <a href="http://www.w3.org/ns/dcat#service">ns0:service</a>
    /// </summary>
    let service = dcatVocabulary.prefixId.prefix "service"

    /// <summary>
    ///   <para>rdfs:comment : minimum spatial separation resolvable in a dataset, measured in meters.rdfs:comment : minimum spatial separation resolvable in a dataset, measured in metres.rdfs:comment : minimální prostorový rozestup rozeznatelný v datové sadě, měřeno v metrech.rdfs:comment : mínima separacíon espacial disponible en un conjunto de datos, medida en metros.rdfs:comment : separazione spaziale minima risolvibile in un set di dati, misurata in metri.rdfs:comment : mindste geografiske afstand som kan erkendes i et datasæt, målt i meter.</para>
    ///   <para>rdfs:label : prostorové rozlišení (metry)rdfs:label : resolución espacial (metros)rdfs:label : risoluzione spaziale (metri)rdfs:label : spatial resolution (meters)rdfs:label : spatial resolution (metres)rdfs:label : geografisk opløsning (meter)</para>
    ///   <para>skos:changeNote : New property added in DCAT 2.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 2.skos:changeNote : Nueva propiedad añadida en DCAT 2.skos:changeNote : Nuova proprietà aggiunta in DCAT 2.skos:changeNote : Ny genskab tilføjet i DCAT 2.</para>
    ///   <para>skos:definition : minimum spatial separation resolvable in a dataset, measured in meters.skos:definition : minimum spatial separation resolvable in a dataset, measured in metres.skos:definition : minimální prostorový rozestup rozeznatelný v datové sadě, měřeno v metrech.skos:definition : mínima separacíon espacial disponible en un conjunto de datos, medida en metros.skos:definition : separazione spaziale minima risolvibile in un set di dati, misurata in metri.skos:definition : mindste geografiske afstand som kan resolveres i et datasæt, målt i meter.</para>
    ///   <para>skos:editorialNote : Might appear in the description of a Dataset or a Distribution, so no domain is specified.skos:editorialNote : Může se vyskytnout v popisu Datové sady nebo Distribuce, takže nebyl specifikován definiční obor.skos:editorialNote : Kan optræde i forbindelse med beskrivelse af datasættet eller datasætditributionen, så der er ikke angivet et domæne for egenskaben.</para>
    ///   <para>skos:scopeNote : Alternative spatial resolutions might be provided as different dataset distributions.skos:scopeNote : Distintas distribuciones de un conjunto de datos pueden tener resoluciones espaciales diferentes.skos:scopeNote : If the dataset is an image or grid this should correspond to the spacing of items. For other kinds of spatial dataset, this property will usually indicate the smallest distance between items in the dataset.skos:scopeNote : Pokud je datová sada obraz či mřížka, měla by tato vlastnost odpovídat rozestupu položek. Pro ostatní druhy prostorových datových sad bude tato vlastnost obvykle indikovat nejmenší vzdálenost mezi položkami této datové sady.skos:scopeNote : Risoluzioni spaziali alternative possono essere fornite come diverse distribuzioni di set di dati.skos:scopeNote : Různá prostorová rozlišení mohou být poskytována jako různé distribuce datové sady.skos:scopeNote : Se il set di dati è un'immagine o una griglia, questo dovrebbe corrispondere alla spaziatura degli elementi. Per altri tipi di set di dati spaziali, questa proprietà di solito indica la distanza minima tra gli elementi nel set di dati.skos:scopeNote : Si el conjunto de datos es una imágen o grilla, esta propiedad corresponde al espaciado de los elementos. Para otro tipo de conjunto de datos espaciales, esta propieda usualmente indica la menor distancia entre los elementos de dichos datos.skos:scopeNote : Alternative geografiske opløsninger kan leveres som forskellige datasætdistributioner.skos:scopeNote : Hvis datasættet udgøres af et billede eller et grid, så bør dette svare til afstanden mellem elementerne. For andre typer af spatiale datasæt, vil denne egenskab typisk indikere den mindste afstand mellem elementerne i datasættet.</para>
    ///   <a href="http://www.w3.org/ns/dcat#spatialResolutionInMeters">ns0:spatialResolutionInMeters</a>
    /// </summary>
    let spatialResolutionInMeters =
        dcatVocabulary.prefixId.prefix "spatialResolutionInMeters"

    /// <summary>
    ///   <para>rdfs:label : datum začátkurdfs:label : start daterdfs:label : data di iniziordfs:label : startdato</para>
    ///   <para>skos:altLabel : starttidspunkt</para>
    ///   <para>skos:changeNote : New property added in DCAT 2.skos:changeNote : Nuova proprietà aggiunta in DCAT 2.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 2.skos:changeNote : Nueva propiedad agregada en DCAT 2.skos:changeNote : Ny egenskab tilføjet i DCAT 2.</para>
    ///   <para>skos:definition : El comienzo del períodoskos:definition : The start of the periodskos:definition : L'inizio del periodoskos:definition : Začátek doby trvánískos:definition : Start på perioden.</para>
    ///   <para>skos:scopeNote : El rango de esta propiedad es intencionalmente genérico con el propósito de permitir distintos niveles de precisión temporal para especificar el comienzo de un período. Por ejemplo, puede expresarse como una fecha (xsd:date), una fecha y un tiempo (xsd:dateTime), o un año (xsd:gYear).skos:scopeNote : Obor hodnot této vlastnosti je úmyslně obecný, aby umožnil různé úrovně časového rozlišení pro specifikaci začátku doby trvání. Ten může být kupříkladu vyjádřen datumem (xsd:date), datumem a časem (xsd:dateTime) či rokem (xsd:gYear).skos:scopeNote : The range of this property is intentionally generic, with the purpose of allowing different level of temporal precision for specifying the start of a period. E.g., it can be expressed with a date (xsd:date), a date and time (xsd:dateTime), or a year (xsd:gYear).skos:scopeNote : Il range di questa proprietà è volutamente generico, con lo scopo di consentire diversi livelli di precisione temporale per specificare l'inizio di un periodo. Ad esempio, può essere espresso con una data (xsd:date), una data e un'ora (xsd:dateTime), o un anno (xsd:gYear).skos:scopeNote : Rækkeviden for denne egenskab er bevidst generisk defineret med det formål at tillade forskellige niveauer af tidslig præcision ifm. angivelse af startdatoen for en periode. Den kan eksempelvis udtrykkes som en dato (xsd:date), en dato og et tidspunkt (xsd:dateTime), eller et årstal (xsd:gYear).</para>
    ///   <a href="http://www.w3.org/ns/dcat#startDate">ns0:startDate</a>
    /// </summary>
    let startDate = dcatVocabulary.prefixId.prefix "startDate"
    /// <summary>
    ///   <para>rdfs:comment : minimum time period resolvable in a dataset.rdfs:comment : minimální doba trvání rozlišitelná v datové sadě.rdfs:comment : periodo di tempo minimo risolvibile in un set di dati.rdfs:comment : período de tiempo mínimo en el conjunto de datos.rdfs:comment : mindste tidsperiode der kan resolveres i datasættet.</para>
    ///   <para>rdfs:label : resolución temporalrdfs:label : risoluzione temporalerdfs:label : temporal resolutionrdfs:label : časové rozlišenírdfs:label : tidslig opløsning</para>
    ///   <para>skos:changeNote : New property added in DCAT 2.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 2.skos:changeNote : Nueva propiedad añadida en DCAT 2.skos:changeNote : Nuova proprietà aggiunta in DCAT 2.</para>
    ///   <para>skos:definition : minimum time period resolvable in a dataset.skos:definition : minimální doba trvání rozlišitelná v datové sadě.skos:definition : periodo di tempo minimo risolvibile in un set di dati.skos:definition : período de tiempo mínimo en el conjunto de datos.skos:definition : mindste tidsperiode der kan resolveres i datasættet.</para>
    ///   <para>skos:editorialNote : Might appear in the description of a Dataset or a Distribution, so no domain is specified.skos:editorialNote : Může se vyskytnout v popisu Datové sady nebo Distribuce, takže nebyl specifikován definiční obor.skos:editorialNote : Kan optræde i forbindelse med beskrivelse af datasættet eller datasætditributionen, så der er ikke angivet et domæne for egenskaben.</para>
    ///   <para>skos:scopeNote : Alternative temporal resolutions might be provided as different dataset distributions.skos:scopeNote : Distintas distribuciones del conjunto de datos pueden tener resoluciones temporales diferentes.skos:scopeNote : If the dataset is a time-series this should correspond to the spacing of items in the series. For other kinds of dataset, this property will usually indicate the smallest time difference between items in the dataset.skos:scopeNote : Pokud je datová sada časovou řadou, měla by tato vlastnost odpovídat rozestupu položek v řadě. Pro ostatní druhy datových sad bude tato vlastnost obvykle indikovat nejmenší časovou vzdálenost mezi položkami této datové sady.skos:scopeNote : Risoluzioni temporali alternative potrebbero essere fornite come diverse distribuzioni di set di dati.skos:scopeNote : Různá časová rozlišení mohou být poskytována jako různé distribuce datové sady.skos:scopeNote : Se il set di dati è una serie temporale, questo dovrebbe corrispondere alla spaziatura degli elementi della serie. Per altri tipi di set di dati, questa proprietà di solito indica la più piccola differenza di tempo tra gli elementi nel set di dati.skos:scopeNote : Si el conjunto de datos es una serie temporal, debe corresponder al espaciado de los elementos de la serie. Para otro tipo de conjuntos de datos, esta propiedad indicará usualmente la menor diferencia de tiempo entre elementos en el dataset.skos:scopeNote : Alternative tidslige opløsninger kan leveres som forskellige datasætdistributioner.skos:scopeNote : Hvis datasættet er en tidsserie, så bør denne egenskab svare til afstanden mellem elementerne i tidsserien. For andre typer af datasæt indikerer denne egenskab den mindste tidsforskel mellem elementer i datasættet.</para>
    ///   <a href="http://www.w3.org/ns/dcat#temporalResolution">ns0:temporalResolution</a>
    /// </summary>
    let temporalResolution = dcatVocabulary.prefixId.prefix "temporalResolution"
    /// <summary>
    ///   <para>rdfs:comment : A main category of the resource. A resource can have multiple themes.rdfs:comment : Hlavní téma zdroje. Zdroj může mít více témat.rdfs:comment : La categoria principale della risorsa. Una risorsa può avere più temi.rdfs:comment : La categoría principal del recurso. Un recurso puede tener varios temas.rdfs:comment : La catégorie principale de la ressource. Une ressource peut avoir plusieurs thèmes.rdfs:comment : Η κύρια κατηγορία του συνόλου δεδομένων. Ένα σύνολο δεδομένων δύναται να έχει πολλαπλά θέματα.rdfs:comment : التصنيف الرئيسي لقائمة البيانات. قائمة البيانات يمكن أن تملك أكثر من تصنيف رئيسي واحد.rdfs:comment : データセットの主要カテゴリー。データセットは複数のテーマを持つことができます。rdfs:comment : Et centralt emne for ressourcen. En ressource kan have flere centrale emner.</para>
    ///   <para>rdfs:label : temardfs:label : temardfs:label : themerdfs:label : thèmerdfs:label : témardfs:label : Θέμαrdfs:label : التصنيفrdfs:label : テーマ/カテゴリーrdfs:label : emne</para>
    ///   <para>skos:altLabel : tema</para>
    ///   <para>skos:definition : A main category of the resource. A resource can have multiple themes.skos:definition : Hlavní téma zdroje. Zdroj může mít více témat.skos:definition : La categoria principale della risorsa. Una risorsa può avere più temi.skos:definition : La categoría principal del recurso. Un recurso puede tener varios temas.skos:definition : La catégorie principale de la ressource. Une ressource peut avoir plusieurs thèmes.skos:definition : Η κύρια κατηγορία του συνόλου δεδομένων. Ένα σύνολο δεδομένων δύναται να έχει πολλαπλά θέματα.skos:definition : التصنيف الرئيسي لقائمة البيانات. قائمة البيانات يمكن أن تملك أكثر من تصنيف رئيسي واحد.skos:definition : データセットの主要カテゴリー。データセットは複数のテーマを持つことができます。skos:definition : Et centralt emne for ressourcen. En ressource kan have flere centrale emner.</para>
    ///   <para>skos:editorialNote : Status: English Definition text  modified by DCAT revision team, all except for Italian and Czech translations are pending. Scope note has changed and its translations should be updated</para>
    ///   <para>skos:scopeNote : El conjunto de skos:Concepts utilizados para categorizar los recursos están organizados en un skos:ConceptScheme que describe todas las categorías y sus relaciones en el catálogo.skos:scopeNote : Il set di concetti skos usati per categorizzare le risorse sono organizzati in skos:ConceptScheme che descrive tutte le categorie e le loro relazioni nel catalogo.skos:scopeNote : Sada instancí třídy skos:Concept použitá pro kategorizaci zdrojů je organizována do schématu konceptů skos:ConceptScheme, které popisuje všechny kategorie v katalogu a jejich vztahy.skos:scopeNote : The set of themes used to categorize the resources are organized in a skos:ConceptScheme, skos:Collection, owl:Ontology or similar, describing all the categories and their relations in the catalog.skos:scopeNote : Un ensemble de skos:Concepts utilisés pour catégoriser les ressources sont organisés en un skos:ConceptScheme décrivant toutes les catégories et ses relations dans le catalogue.skos:scopeNote : Το σετ των skos:Concepts που χρησιμοποιείται για να κατηγοριοποιήσει τα σύνολα δεδομένων είναι οργανωμένο εντός ενός skos:ConceptScheme που περιγράφει όλες τις κατηγορίες και τις σχέσεις αυτών στον κατάλογο.skos:scopeNote : データセットを分類するために用いられるskos:Conceptの集合は、カタログのすべてのカテゴリーとそれらの関係を記述しているskos:ConceptSchemeで組織化されます。skos:scopeNote : Samlingen af begreber (skos:Concept) der anvendes til at emneinddele ressourcer organiseres i et begrebssystem (skos:ConceptScheme) som beskriver alle emnerne og deres relationer i kataloget.</para>
    ///   <a href="http://www.w3.org/ns/dcat#theme">ns0:theme</a>
    /// </summary>
    let theme = dcatVocabulary.prefixId.prefix "theme"
    /// <summary>
    ///   <para>rdfs:comment : El sistema de organización del conocimiento utilizado para clasificar conjuntos de datos de catálogos.rdfs:comment : Il sistema di organizzazione della conoscenza (KOS) usato per classificare i dataset del catalogo.rdfs:comment : Le systhème d'ogranisation de connaissances utilisé pour classifier les jeux de données du catalogue.rdfs:comment : Systém organizace znalostí (KOS) použitý pro klasifikaci datových sad v katalogu.rdfs:comment : The knowledge organization system (KOS) used to classify catalog's datasets.rdfs:comment : Το σύστημα οργάνωσης γνώσης που χρησιμοποιείται για την κατηγοριοποίηση των συνόλων δεδομένων του καταλόγου.rdfs:comment : لائحة التصنيفات المستخدمه لتصنيف قوائم البيانات ضمن الفهرسrdfs:comment : カタログのデータセットを分類するために用いられる知識組織化体系（KOS；knowledge organization system）。rdfs:comment : Vidensorganiseringssystem (KOS) som anvendes til at klassificere datasæt i kataloget.</para>
    ///   <para>rdfs:label : tassonomia dei temirdfs:label : taxonomie de thèmesrdfs:label : taxonomie tématrdfs:label : taxonomía de temasrdfs:label : theme taxonomyrdfs:label : Ταξινομία θεματικών κατηγοριών.rdfs:label : قائمة التصنيفاتrdfs:label : テーマrdfs:label : emnetaksonomi</para>
    ///   <para>skos:altLabel : temataksonomi</para>
    ///   <para>skos:definition : El sistema de organización del conocimiento utilizado para clasificar conjuntos de datos de catálogos.skos:definition : Il sistema di organizzazione della conoscenza (KOS) usato per classificare i dataset del catalogo.skos:definition : Le systhème d'ogranisation de connaissances utilisé pour classifier les jeux de données du catalogue.skos:definition : Systém organizace znalostí (KOS) použitý pro klasifikaci datových sad v katalogu.skos:definition : The knowledge organization system (KOS) used to classify catalog's datasets.skos:definition : Το σύστημα οργάνωσης γνώσης που χρησιμοποιείται για την κατηγοριοποίηση των συνόλων δεδομένων του καταλόγου.skos:definition : لائحة التصنيفات المستخدمه لتصنيف قوائم البيانات ضمن الفهرسskos:definition : カタログのデータセットを分類するために用いられる知識組織化体系（KOS；knowledge organization system）。skos:definition : Vidensorganiseringssystem (KOS) som anvendes til at klassificere datasæt i kataloget.</para>
    ///   <para>skos:scopeNote : It is recommended that the taxonomy is organized in a skos:ConceptScheme, skos:Collection, owl:Ontology or similar, which allows each member to be denoted by an IRI and published as linked-data.skos:scopeNote : Si raccomanda che la tassonomia sia organizzata in uno skos:ConceptScheme, skos:Collection, owl:Ontology o simili, che permette ad ogni membro di essere indicato da un IRI e pubblicato come linked-data.skos:scopeNote : Je doporučeno, aby byla taxonomie vyjádřena jako skos:ConceptScheme, skos:Collection, owl:Ontology nebo podobné, aby mohla být každá položka identifikována pomocí IRI a publikována jako propojená data.skos:scopeNote : Se recomienda que la taxonomía se organice como un skos:ConceptScheme, skos:Collection, owl:Ontology o similar, los cuáles permiten que cada miembro se denote con una IRI y se publique como datos enlazados.skos:scopeNote : Det anbefales at taksonomien organiseres i et skos:ConceptScheme, skos:Collection, owl:Ontology eller lignende, som giver mulighed for at ethvert medlem af taksonomien kan forsynes med en IRI og udgives som linked-data.</para>
    ///   <a href="http://www.w3.org/ns/dcat#themeTaxonomy">ns0:themeTaxonomy</a>
    /// </summary>
    let themeTaxonomy = dcatVocabulary.prefixId.prefix "themeTaxonomy"
    /// <summary>
    ///   <para>rdfs:comment : The version indicator (name or identifier) of a resource.rdfs:comment : El indicador de versión (nombre o identificador) del recurso.rdfs:comment : L'indicatore di versione (un nome o un identificatore) di una risorsa.</para>
    ///   <para>rdfs:label : versionrdfs:label : versiónrdfs:label : versione</para>
    ///   <para>skos:changeNote : New property added in DCAT 3.skos:changeNote : Nueva propiedad agregada in DCAT 3.skos:changeNote : Nová vlastnost přidaná ve verzi DCAT 3.skos:changeNote : Nuova proprietà aggiunta in DCAT 3.skos:changeNote : Ny egenskab tilføjet i DCAT 3.</para>
    ///   <para>skos:definition : The version indicator (name or identifier) of a resource.skos:definition : El indicador de versión (nombre o identificador) del recurso.skos:definition : L'indicatore di versione (un nome o un identificatore) di una risorsa</para>
    ///   <para>skos:scopeNote : DCAT does not prescribe how a version name / identifier should be specified, and refers for guidance to [DWBP]'s Best Practice 7: Provide a version indicator.skos:scopeNote : DCAT no prescribe cómo especificar el nombre or identificador de una versión, y como guía sugiere leer las práctica 7 en [DWBP] sobre cómo proveer un indicador de versiónskos:scopeNote : DCAT non prescrive come un nome o identificatore di versione dovrebbe essere specificato, e fa riferimento alle linee guida indicate in [DWBP] Best Practice 7: Provide a version indicator.</para>
    ///   <a href="http://www.w3.org/ns/dcat#version">ns0:version</a>
    /// </summary>
    let version = dcatVocabulary.prefixId.prefix "version"


// TODO finally fix binder
(*

    rdfVocabulary
    rdfsVocabulary
    owlVocabulary
    foafVocabulary
    vsVocabulary
    hydraVocabulary
    voidVocabulary
    vannVocabulary
    vaemVocabulary
    voafVocabulary
    dctermsVocabulary

[|
    dcatVocabulary
|]
|> Array.filter (fun vocabulary -> vocabulary.document.graphFile.Exists)
|> Array.map (fun vocabulary -> RdfVocabulary.asModule vocabulary)
|> String.concat "\n"
|> clip



*)

    
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



















































































































// Network traffic helpers



























































(*

Uri "https://leonco-prod-av.accela.com/portlets/web/en-us/#/auth/login"
DomUrl "https://html.spec.whatwg.org/entities.json"
IriReference "https://leonco-prod-av.accela.com/portlets/web/en-us/#/auth/login"
FileInfo "https://leonco-prod-av.accela.com/portlets/web/en-us/#/auth/login"
DirectoryInfo "https://leonco-prod-av.accela.com/portlets/web/en-us/#/auth/login"


let solarwindsTest = DomUrl "https://leoncountyfl.samanage.com/incidents.json?report_id=9641268&assigned_to%5B%5D=10744815&data=state&sort_by=state&sort_order=DESC&state_is_not%5B%5D=758500&state_is_not%5B%5D=758501&state_is_not%5B%5D=758502&state_is_not%5B%5D=793540&state_is_not%5B%5D=800657" 
let entitiesTest = DomUrl "https://html.spec.whatwg.org/entities.json" 

FilePath.Sanitize solarwindsTest.asFile.FullName
entitiesTest.asFile.FullName


FilePath.Sanitize entitiesTest.asFile.FullName
let invalidPathTest = Path.GetInvalidPathChars() |> Array.map (fun character -> string character)
let invalidFileNameTest = Path.GetInvalidFileNameChars() |> Array.map (fun character -> string character)


type DomUrl with 
    member this.pathName = this.Pathname[1..]
    member this.AppendPath(path:string) = Path.Combine(this.Origin + this.pathName, path.TrimStart('/')) + this.Search |> DomUrl
    member this.AppendSegments(segments:string list) = 
        let absolutePath = 
            List.concat [
                [this.Origin + this.Pathname]
                segments
            ]
            |> String.concat "/"
        absolutePath + this.Search |> DomUrl
    member this.SlashTerminated = this.Href + "/" |> DomUrl
    member this.HashTerminated = this.Href + "#" |> DomUrl
    member this.Absolute = this.Origin + this.Pathname |> DomUrl
    member this.asIriReference = IriReference this.Href
    member this.Query = QueryStringUtilities.ParseQuery this.Search |> Seq.map (fun keyValue ->  keyValue.Key, keyValue.Value |> Seq.toArray) |> Seq.toArray |> Array.sortBy (fun (key,values) -> key)
    member this.extension = Path.GetExtension this.pathName
    member this.pathStem = Path.GetFileNameWithoutExtension this.pathName


*)





















let a = rdf.type_



module dbug = 
    let _prefixId = PrefixId.fromNamespaceLabel "https://eristocrates.dev/ontology/dbug/"  "dbug"
    let _prefix (localName:string) = PrefixedIri { prefixId = _prefixId ; localName = localName } 
    let Bob = _prefix "Bob"
    let Alice = _prefix "Alice"
    let this = _prefix "this"
    let test = _prefix "test"



[<RequireQualifiedAccess>]
type LovTermType = 
    | ``class``
    | property
    | datatype
    | instance
type LovApiTermSearchParameters =
    {
        /// Full text query.
        q :string
        /// Maximum number of results to return per page (default: 10).
        page_size :int option
        /// Result page to display starting from 1 (default: 1).
        page :int option
        /// Filter query results based on their type. Possible values: [class, propery, datatype, instance]. Multiple values allowed (use coma without space to seperate them).
        types :LovTermType array
        /// Filter query results based on the vocabulary it belongs to (e.g. "foaf"). Expecting only one value.
        vocab :string
        /// Number of elements to display in the vocabulary facet (default: 10).
        vocab_limit :int option
        /// Filter query results based on their tag (e.g. "event"). Multiple values allowed, use coma as a separator (e.g. "event,time").
        tags :string array
        /// Number of elements to display in the tag facet (default: 10).
        tag_limit :int option
    }
[<Literal>]
let termSearchFilePath = @"D:\Iri\https\lov.linkeddata.es\dataset\api\v2\term\search&quest;q=sample.json"
type TermSearchProvider = JsonProvider< UseOriginalNames = true, PreferDateOnly = true, OmitNullFields = true,
            RootName = "result",
            Sample =  termSearchFilePath >
[<Literal>]
let vocabSearchFilePath = @"D:\Iri\https\lov.linkeddata.es\dataset\api\v2\vocabulary\search&quest;q=http%3A%2F%2Fwww.w3.json"
type VocabSearchProvider = JsonProvider< UseOriginalNames = true, PreferDateOnly = true, OmitNullFields = true,
            RootName = "result",
            Sample =  vocabSearchFilePath >

let lovBase = DomUrl "https://lov.linkeddata.es/dataset/api/v2"

let LovSearchTerm (term:string) = 
    let domUrl = lovBase.AppendPath "term/search"  |> DomUrl.AddQueryParameter "q" term
    domUrl.HeadedDownloadTextExtension(".json")
    TermSearchProvider.Load (domUrl.asFileExtension ".json").FullName

let LovSearchVocab (vocab:string) = 
    let domUrl = lovBase.AppendPath "vocabulary/search"  |> DomUrl.AddQueryParameter "q" vocab
    domUrl.HeadedDownloadTextExtension(".json")
    VocabSearchProvider.Load (domUrl.asFileExtension ".json").FullName

let n3gzDataDump = DomUrl "https://lov.linkeddata.es/lov.n3.gz"
// n3gzDataDump.HeadlessDownloadFile()
let nqgzDataDump = DomUrl "https://lov.linkeddata.es/lov.nq.gz"
// nqgzDataDump.HeadlessDownloadFile()


module LovKeyword =
    let API = RdfLiteral.simple "API"
    let Academy = RdfLiteral.simple "Academy"
    let Biology = RdfLiteral.simple "Biology"
    let CSV = RdfLiteral.simple "CSV"
    let Catalogs = RdfLiteral.simple "Catalogs"
    let Contracts = RdfLiteral.simple "Contracts"
    let Environment = RdfLiteral.simple "Environment"
    let Events = RdfLiteral.simple "Events"
    let FRBR = RdfLiteral.simple "FRBR"
    let Food = RdfLiteral.simple "Food"
    let Games = RdfLiteral.simple "Games"
    let General_and_Upper = RdfLiteral.simple "General & Upper"
    let Geography = RdfLiteral.simple "Geography"
    let Geometry = RdfLiteral.simple "Geometry"
    let Government = RdfLiteral.simple "Government"
    let Health = RdfLiteral.simple "Health"
    let Image = RdfLiteral.simple "Image"
    let Industry = RdfLiteral.simple "Industry"
    let IoT = RdfLiteral.simple "IoT"
    let Metadata = RdfLiteral.simple "Metadata"
    let Methods = RdfLiteral.simple "Methods"
    let Multimedia = RdfLiteral.simple "Multimedia"
    let Music = RdfLiteral.simple "Music"
    let PLM = RdfLiteral.simple "PLM"
    let PROTON = RdfLiteral.simple "PROTON"
    let People = RdfLiteral.simple "People"
    let Press = RdfLiteral.simple "Press"
    let Quality = RdfLiteral.simple "Quality"
    let RDF = RdfLiteral.simple "RDF"
    let Rec = RdfLiteral.simple "Rec"
    let SPAR = RdfLiteral.simple "SPAR"
    let SSDesk = RdfLiteral.simple "SSDesk"
    let Security = RdfLiteral.simple "Security"
    let Services = RdfLiteral.simple "Services"
    let Society = RdfLiteral.simple "Society"
    let Support = RdfLiteral.simple "Support"
    let Tag = RdfLiteral.simple "Tag"
    let Time = RdfLiteral.simple "Time"
    let Transport = RdfLiteral.simple "Transport"
    let Travel = RdfLiteral.simple "Travel"
    let Vocabularies = RdfLiteral.simple "Vocabularies"
    let W3CRec = RdfLiteral.simple "W3CRec"
    let eBusiness = RdfLiteral.simple "eBusiness"





type DomUrl with 
    member this.asSparqlRemoteEndpoint = 
        SparqlRemoteEndpoint.fromString(
            new HttpClient(),
            this.Href
        )

let lov_n3 = { graphFile = FileInfo @"D:\Iri\https\lov.linkeddata.es\lov.n3" }
let lov_nq = { datasetFile = FileInfo @"D:\Iri\https\lov.linkeddata.es\lov.nq"  }
let lovDataset = lov_nq.asInMemoryQuadDataset
let lov_sparql = DomUrl "https://lov.linkeddata.es/dataset/lov/sparql"
    

let s = !? "s"
let p = !? "p"
let o = !? "o"

let vocabularyIri = !? "vocabularyIri"
let preferredNamespaceUri = !? "preferredNamespaceUri"
let preferredNamespacePrefix = !? "preferredNamespacePrefix"


let selectVariables = [ vocabularyIri ; preferredNamespaceUri ; preferredNamespacePrefix]
let vocabularyQuery = 

        sparql.select selectVariables {
            where ( 
                !>vocabularyIri -~|> [ 
                                        a ->- voaf.Vocabulary
                                        vann.preferredNamespacePrefix ->- preferredNamespacePrefix
                                        vann.preferredNamespaceUri ->- preferredNamespaceUri
                                    ]
                
                )
        }
        |> lov_n3.asSparqlLocalDataset.query


type LovVocabulary = 
    {
        vocabularyIri : Iri
        vocabularyPrefix : RdfLiteral
        vocabularyNamespace : RdfLiteral
    }
    member this.namespaceUrl = DomUrl this.vocabularyNamespace.lexicalForm
    member this.graphName = this.vocabularyIri.asUriNode :> IRefNode
    member this.asIGraph = lovDataset[this.graphName]
    member this.tryIGraph = 
        if lovDataset.HasGraph this.graphName then 
            printfn "Loading %s from lov.nq" this.vocabularyIri.lexicalForm
            Some lovDataset[this.graphName]
        else 
            printfn "%s not found in lov.nq" this.vocabularyIri.lexicalForm
            None
    member this.asFileExtension (dotExtension:string) = 
        let mimeType = MimeType.FromFileName(dotExtension)
        Path.Combine (this.namespaceUrl.asFolder.FullName, mimeType.MediaType, $"{mimeType.SubType}{dotExtension}") |> FileInfo
    member this.namespaceIri = IriReference this.vocabularyNamespace.lexicalForm  |> IRIREF
    member this.asPrefixId = PrefixId.fromNamespaceLabel this.vocabularyNamespace.lexicalForm this.vocabularyPrefix.lexicalForm
    member this.ttlFile = this.asFileExtension ".ttl"
    member this.tryGraphDocument = 
        let ttlFile = this.ttlFile
        match ttlFile.Exists, this.tryIGraph with 
        | false, Some igraph ->
                printfn "writing %s to  %s" this.vocabularyIri.lexicalForm (Path.Combine(ttlFile.DirectoryName,$"{ttlFile.stem}.ttl"))
                igraph |> Turtle.writeIgraph ttlFile.DirectoryName ttlFile.stem
                Some { graphFile = ttlFile }
        | true, _ -> Some { graphFile = ttlFile }
        | _, _ -> None
    member this.asRdfGraphDocument = 
                    let ttlFile = this.ttlFile
                    if not (ttlFile.Exists) then 
                        this.asIGraph |> Turtle.writeIgraph this.ttlFile.DirectoryName this.ttlFile.stem
                    { graphFile = ttlFile}

    member this.tryRdfVocabulary = 
        match this.tryGraphDocument with 
        | Some document -> 
            Some {
                    prefixId = this.asPrefixId
                    namespaceDocument = document
                }
        | None -> None
    member this.asRdfVocabulary = 
                 {
                    prefixId = this.asPrefixId
                    namespaceDocument = this.asRdfGraphDocument
                }

let lovVocabularies =
    [|

        for index = 0 to vocabularyQuery.Count() - 1 do
            let (IriPoint vocabIri) =  vocabularyQuery |> SparqlResultSet.variableIndex vocabularyIri index
            let (LiteralPoint prefixLabel) = vocabularyQuery |>  SparqlResultSet.variableIndex preferredNamespacePrefix index 
            let (LiteralPoint namespaceUri) = vocabularyQuery |>  SparqlResultSet.variableIndex preferredNamespaceUri index
            {
                vocabularyIri = vocabIri
                vocabularyPrefix = prefixLabel
                vocabularyNamespace = namespaceUri

            }
    
    |]

let lovVocabularyMap = 
    Array.concat [|
        lovVocabularies |> Array.map (fun vocabulary -> vocabulary.vocabularyNamespace.lexicalForm, vocabulary) 
        lovVocabularies |> Array.map (fun vocabulary -> vocabulary.vocabularyIri.lexicalForm, vocabulary) 
        |]
        |> Array.distinctBy (fun (vocabularyKey, _) -> vocabularyKey)
        |> Map.ofArray

type RDFNamespaceRegister with 
    static member rdfNamespaces = RDFNamespaceRegister.Instance |> Seq.cast<RDFNamespace> |> Seq.toArray
    static member hasPrefixRegistered(prefix:string) = RDFNamespaceRegister.rdfNamespaces |> Array.exists (fun rdfNamespace -> rdfNamespace.NamespacePrefix = prefix)
    static member hasNamespaceNameRegistered(namespaceName:string) = RDFNamespaceRegister.rdfNamespaces |> Array.exists (fun rdfNamespace -> rdfNamespace.NamespaceUri.OriginalString= namespaceName)
    static member maybePrefixIdCollision (prefixId:PrefixId) = 
        match RDFNamespaceRegister.GetByPrefix prefixId.prefixLabel, RDFNamespaceRegister.GetByUri prefixId.namespaceName with 
        | namespaceFromPrefix, namespaceFromName when prefixId.asRDFNamespace = namespaceFromPrefix && prefixId.asRDFNamespace = namespaceFromName -> None
        | namespaceFromPrefix, namespaceFromName -> Some(namespaceFromPrefix, namespaceFromName)
    static member lovVocabularyNamespaces = 
        RDFNamespaceRegister.rdfNamespaces |> Array.choose (fun rdfNamespace -> lovVocabularyMap.TryFind rdfNamespace.NamespaceUri.OriginalString)

let lovVocabularyNamespaces = RDFNamespaceRegister.lovVocabularyNamespaces |> Array.choose (fun lovVocabularyNamespaces -> lovVocabularyNamespaces.tryRdfVocabulary )

lovVocabularyNamespaces[16]

let lovNamespaces = lovVocabularies |> Array.choose (fun vocabulary -> vocabulary.tryRdfVocabulary)

let lovNamespaceMap = lovNamespaces |> Array.map (fun lovNamespace -> lovNamespace.prefixId.namespaceName,  lovNamespace) |> Map.ofArray

let targetNamespaceNames = 
    [|
        "http://www.w3.org/1999/02/22-rdf-syntax-ns#"
        "http://www.w3.org/2000/01/rdf-schema#"
        "http://www.w3.org/2002/07/owl#"
        "http://www.w3.org/2001/XMLSchema#"
        "http://www.w3.org/2001/XMLSchema-instance#"
        "https://www.w3.org/2003/05/xpath-datatypes#"
        "http://www.w3.org/2006/time#"
        "http://purl.org/vocab/vann/"
        "http://xmlns.com/foaf/0.1/"
        "http://www.w3.org/2003/06/sw-vocab-status/ns#"
        "http://www.w3.org/ns/hydra/core#"
        "http://rdfs.org/ns/void#"
        "http://www.linkedmodel.org/schema/vaem#"
        "http://purl.org/vocommons/voaf#"
        "http://purl.org/dc/terms/"
        "http://www.w3.org/ns/dcat#"
    |]
let missingNamespaceNames = 
    targetNamespaceNames
    |> Array.filter (fun namespaceName -> 
        match lovNamespaceMap.TryFind namespaceName with 
        | Some _ -> false
        | _ -> true)

targetNamespaceNames
|> Array.choose (fun namespaceName -> lovNamespaceMap.TryFind namespaceName)
|> Array.filter (fun vocabulary -> vocabulary.namespaceDocument.graphFile.Exists)
|> Array.map (fun vocabulary -> $"let {vocabulary.prefixId.prefixLabel}Vocabulary = PrefixId.fromNamespaceLabel \"{vocabulary.prefixId.namespaceName}\" \"{vocabulary.prefixId.prefixLabel}\" |> RdfVocabulary.fromPrefixId  ")
|> String.concat "\n"
|> clip

targetNamespaceNames
|> Array.choose (fun namespaceName -> lovNamespaceMap.TryFind namespaceName)
|> Array.filter (fun vocabulary -> vocabulary.namespaceDocument.graphFile.Exists)
|> Array.sortBy (fun vocabulary -> vocabulary.prefixId.prefixLabel)
|> Array.map (fun vocabulary -> RdfVocabulary.asModule vocabulary)
|> String.concat "\n\n\n"
|> fun namespaceText -> File.WriteAllText(@"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL\VocabularyModules.txt", namespaceText)


(*

let describeTriples = 
    sparql.describe [ PrefixId.vann.asIri ]
    |> lov_sparql.asSparqlRemoteEndpoint.query |> await

describeTriples
|> Turtle.writeIgraph Folder.Scratch.FullName "scratch"

*)

!> PrefixId.vann.asIri --- a --> voaf.Vocabulary
|> writeDraft Folder.Scratch.FullName "scratch"





module gov = 
    module leoncountyfl = 
        module leonintra = 
            let baseUrl = DomUrl "https://leonintra.leoncountyfl.gov/"

            let PayrollCalendar = baseUrl.AppendPath "Departments/Human-Resources/PAYROLL-CALENDARS"

            let FormsDocuments = baseUrl.AppendPath "Forms-Documents"

        module bannerprodssb = 

            let baseUrl = DomUrl "https://bannerprodssb.leoncountyfl.gov:8449/EmployeeSelfService"
            let hrDashboard = baseUrl.AppendPath "ssb/hrDashboard"
            let payStubSummaryList = hrDashboard.AppendFragmentPath "payStubSummary/list"
            let payStubSummary (payYear:int) = payStubSummaryList.ConcatFragment (string payYear)


gov.leoncountyfl.bannerprodssb.payStubSummary 2025









module Infor = 
    module infortest = 
        let test_operations = DomUrl "https://infortest.leoncountyfl.gov/test_operations/"
    module CustomerService = 
        let portal = DomUrl "https://customerportal.infor.com/csmcore"


(*

let skedpalTab = chrome.tabs |> Array.find (fun tab -> tab.DomUrl.Host = "app.skedpal.com")



let menuElement = skedpalTab.QuerySelectorAllWithContentAsync(El.I.Css, "menu").await |> Array.map (fun element -> element.asCdp)
skedpalTab.ClickAsync(El.Button * Attr.Tabindex.Equals("0") |> _.Css).await

chrome.tabs
|> Array.tryFind (fun tab -> tab.DomUrl.Host.StartsWith("customerportal"))
|> Option.map (fun tab -> tab.GoToAsync(Infor.CustomerService.portal.Href).await)



chrome.tabs
|> Array.tryFind (fun tab -> tab.DomUrl.Host.StartsWith("leonintra"))
|> Option.map (fun tab -> tab.QuerySelectorAllAsync(El.A |> _.Css).await)


*)



let employeeTest = DomUrl "https://bannerprodssb.leoncountyfl.gov:8449/EmployeeSelfService/ssb/menu"
employeeTest.Host
employeeTest.pathStem
employeeTest.extension


module Microsoft = 
    module Graph = 
        let OpenAPI = DomUrl "https://github.com/microsoftgraph/msgraph-metadata/raw/refs/heads/master/openapi/beta/openapi.yaml"
        let csdl = DomUrl "https://github.com/microsoftgraph/msgraph-metadata/raw/refs/heads/master/schemas/beta-Prod.csdl"
        let betaMetadata = DomUrl "https://graph.microsoft.com/beta/$metadata"
        let v1metadata = DomUrl "https://graph.microsoft.com/v1.0/$metadata"
        let httpClient = new HttpClient()

        let explorer =  DomUrl "https://developer.microsoft.com/en-us/graph/graph-explorer"
        let getAccessToken(tab:CdpPage) = 
    
            tab.ClickAsync(El.Button * Attr.Value.Equals("access-token") |> _.Css).await
            let accessTokenElement = tab.QuerySelectorAsync(El.Div * Attr.Id.Equals("access-token") |> _.Css).await.asCdp
            accessTokenElement.InnerTextAsync().await
        let userProperties = 
            [|


                "additionalData"
                "adhocCalls"
                "ageGroup"
                "agreementAcceptances"
                "appRoleAssignments"
                "assignedLicenses"
                "assignedPlans"
                "authentication"
                "authorizationInfo"
                "backingStore"
                "birthday"
                "businessPhones"
                "calendar"
                "calendarGroups"
                "chats"
                "city"
                "cloudClipboard"
                "cloudPCs"
                "companyName"
                "consentProvidedForMinor"
                "contactFolders"
                "contacts"
                "country"
                "createdDateTime"
                "createdObjects"
                "creationType"
                "customSecurityAttributes"
                "dataSecurityAndGovernance"
                "deletedDateTime"
                "deviceManagementTroubleshootingEvents"
                "directReports"
                "displayName"
                "drive"
                "drives"
                "employeeExperience"
                "employeeHireDate"
                "employeeId"
                "employeeLeaveDateTime"
                "employeeOrgData"
                "employeeType"
                "events"
                "extensions"
                "externalUserState"
                "externalUserStateChangeDateTime"
                "givenName"
                "hireDate"
                "id"
                "identities"
                "identityParentId"
                "imAddresses"
                "inferenceClassification"
                "insights"
                "interests"
                "isManagementRestricted"
                "isResourceAccount"
                "jobTitle"
                "joinedTeams"
                "lastPasswordChangeDateTime"
                "legalAgeGroupClassification"
                "mail"
                "mailFolders"
                "mailNickname"
                "mailboxSettings"
                "managedAppRegistrations"
                "managedDevices"
                "manager"
                "memberOf"
                "messages"
                "mobilePhone"
                "mySite"
                "oauth2PermissionGrants"
                "odataType"
                "officeLocation"
                "onPremisesDistinguishedName"
                "onPremisesImmutableId"
                "onPremisesLastSyncDateTime"
                "onPremisesProvisioningErrors"
                "onPremisesSamAccountName"
                "onPremisesSecurityIdentifier"
                "onPremisesSyncBehavior"
                "onPremisesSyncEnabled"
                "onPremisesUserPrincipalName"
                "onenote"
                "onlineMeetings"
                "otherMails"
                "outlook"
                "ownedDevices"
                "ownedObjects"
                "passwordPolicies"
                "people"
                "permissionGrants"
                "photo"
                "photos"
                "planner"
                "postalCode"
                "preferredDataLocation"
                "preferredLanguage"
                "preferredName"
                "presence"
                "provisionedPlans"
                "proxyAddresses"
                "registeredDevices"
                "responsibilities"
                "securityIdentifier"
                "serviceProvisioningErrors"
                "settings"
                "showInAddressList"
                "signInSessionsValidFromDateTime"
                "skills"
                "solutions"
                "sponsorOf"
                "sponsors"
                "state"
                "streetAddress"
                "surname"
                "teamwork"
                "todo"
                "userPrincipalName"
                "userType"


            |]


let microsoftGraphTab = chrome.NewPageAsync().await.asCdp
microsoftGraphTab.GoToAsync(Microsoft.Graph.explorer.Href).await
Microsoft.Graph.httpClient.DefaultRequestHeaders.Authorization <- AuthenticationHeaderValue("Bearer", Microsoft.Graph.getAccessToken(microsoftGraphTab))
let microsoftGraphClient = new GraphServiceClient(Microsoft.Graph.httpClient,  baseUrl = "https://graph.microsoft.com/beta")


// Microsoft.Graph.v1metadata.HeadlessDownloadFileExtension(".xml")
// Microsoft.Graph.betaMetadata.HeadlessDownloadFileExtension(".xml")
// Microsoft.Graph.OpenAPI.HeadlessDownloadFile()
// Microsoft.Graph.csdl.HeadlessDownloadFile()
// Microsoft.Graph.csdl.asFile.FullName |> clip
[<Literal>]
let csdlFilePath = @"D:\Iri\https\github.com\microsoftgraph\msgraph-metadata\raw\refs\heads\master\schemas\beta-Prod.csdl"
type CsdlProvider  = XmlProvider<UseOriginalNames = true, PreferDateOnly = true,
            Sample = csdlFilePath >
let beta_Prod_csdl = CsdlProvider.Load csdlFilePath
let user_csdl =
    beta_Prod_csdl.DataServices.Schemas
    |> Array.pick (fun schema -> 
        match schema.Namespace with 
        | "microsoft.graph" -> 
                    schema.EntityTypes |> Array.tryFind (fun entityType -> entityType.Name = "user" )

        | _ -> None
    )
let csdlUserPropertySet = user_csdl.Properties |> Array.map (fun property -> property.Name) |> Set.ofArray
let clrUserPropertySet = typeof<Microsoft.Graph.Models.User>.GetProperties() |> Array.map (fun property -> property.Name.ToCamelCase()) |> Set.ofArray
csdlUserPropertySet.Count()
clrUserPropertySet.Count()
let workingProperties = 
    clrUserPropertySet
    |> Set.toArray
    |> Array.Parallel.choose (fun property -> 
        try 
            let  myUserAccount = microsoftGraphClient.Me.GetAsync(fun request -> request.QueryParameters.Select <- [| property |] ).await
            Some property
        with 
        | _ -> None

    
    )
let  myUserAccount = microsoftGraphClient.Me.GetAsync(fun request -> request.QueryParameters.Select <- Microsoft.Graph.userProperties ).await




type Microsoft.Graph.Models.User with 
    member this.properties: array<PropertyInfo * obj> = 
        typeof<Microsoft.Graph.Models.User>.GetProperties()
        |> Array.choose (fun property -> 
            match property.GetValue this with 
            | null -> None 
            | value -> Some (property, value)
            )
    member this.propertyNames = this.properties |> Array.map (fun (property, value) -> property.Name)
    member this.propertyTypeNames = this.properties |> Array.map (fun (property, value) -> FSharpLiteral.stringifyTypeDynamic property.PropertyType, property.PropertyType.FullName) |> Array.distinct |> Array.sort

    member this.AstAdditionalDataFields =
            this.AdditionalData
            |> Seq.toArray
            |> Array.map (fun keyValue -> 
                match keyValue.Key, FSharpLiteral.stringifyTypeDynamic (keyValue.Value.GetType()) with 
                | "@odata.context", fieldTypeName  -> Ast.Field("OdataContext", "DomUrl")
                | fieldName, fieldTypeName -> Ast.Field(fieldName, fieldTypeName)
                )
        
    member this.AstFields =

        this.properties
        |> Array.filter (fun (property,value) -> property.Name <> "AdditionalData")
        |> Array.map (fun (property,value) -> 
            match property.Name, FSharpLiteral.stringifyTypeDynamic property.PropertyType with 
            | "BusinessPhones", fieldTypeName   -> Ast.Field("BusinessPhones", "PhoneNumber array" )
            | "Id", fieldTypeName   -> Ast.Field("Id", "Guid" )
            | "ImAddresses", fieldTypeName   -> Ast.Field("ImAddresses", "EmailAddress" )
            | "Mail", fieldTypeName   -> Ast.Field("Mail", "EmailAddress" )
            | "ProxyAddresses", fieldTypeName   -> Ast.Field("ProxyAddresses", "EmailAddress array" )
            | fieldName, fieldTypeName when property.PropertyType.IsInterface && fieldName <> "AdditionalData"  -> Ast.Field(fieldName, FSharpLiteral.stringifyTypeDynamic(value.GetType()))
            | fieldName, fieldTypeName when fieldTypeName.StartsWith("Nullable") -> Ast.Field(fieldName, fieldTypeName.Replace("Nullable","Option"))
            | fieldName, fieldTypeName when fieldTypeName.StartsWith("IDictionary") -> Ast.Field(fieldName, fieldTypeName.Replace("IDictionary","Map"))
            | fieldName, fieldTypeName when fieldTypeName.StartsWith("ResizeArray") -> Ast.Field(fieldName, fieldTypeName.Replace("ResizeArray","array"))
            | fieldName, fieldTypeName -> Ast.Field(fieldName, fieldTypeName)
            )
    member this.AstRecord (recordName:string) = 
        Ast.Record(recordName){
            for field in this.AstFields -> field
            for field in this.AstAdditionalDataFields -> field
            
        }
    member this.AstAnonymousModule = 
        Ast.AnonymousModule(){
            this.AstRecord "EntraUser"

        }
    member this.AstOak = 

        Ast.Oak(){
            this.AstAnonymousModule
        }
        |> Gen.mkOak
        |> Gen.run




myUserAccount.AstOak |> clip



let additionalData = myUserAccount.AdditionalData |> Seq.toArray

additionalData[0].Value.GetType().Name
additionalData[0].Key

myUserAccount.BackingStore.GetType().Name


myUserAccount.BusinessPhones |> Seq.map PhoneNumber.Parse 
myUserAccount.ImAddresses |> Seq.map EmailAddress.Parse

myUserAccount.propertyTypeNames

typeof<ResizeArray<string>>.FullName
typeof<ResizeArray<string>>

(*

type BrowserFrame =
    {
        frame : CdpFrame
        backend : PuppeteerBrowserBackend
    }
    member this.document =
        this.backend.FrameGlobal(
            this.frame,
            "document"
        )
        |> fromHandle<Dom.Document>

    member this.window =
        this.backend.FrameGlobal(
            this.frame,
            "window"
        )
        |> fromHandle<Dom.Window>

    member this.childFrames =
        this.frame.ChildFrames
        |> Seq.map (fun frame ->
            let cdpFrame = frame :?> CdpFrame
            {
                frame = cdpFrame
                backend = this.backend
            }
        )
        |> Seq.toArray

    member this.menuitems = 
        Attr.Role.Equals "menuitem" |> this.document.QuerySelectorAll 


type BrowserTab = 
    {
        page:CdpPage
        session:ICDPSession
        backend : PuppeteerBrowserBackend
    }
    member this.bringToFront() = task { do! this.page.BringToFrontAsync() } |> await
    member this.navigate (url:DomUrl) = this.page.GoTo url
    member this.navigateToFront(url:DomUrl) = 
        this.bringToFront()
        this.navigate url 

    member this.document =
        (this.backend :> IBrowserBackend).GetGlobal("document")
        |> fromHandle<Dom.Document>

    member this.window =
        (this.backend :> IBrowserBackend)
            .GetGlobal("window")
        |> fromHandle<Dom.Window>

    member this.mainFrame : BrowserFrame =
        {
            frame = this.page.MainFrame :?> CdpFrame
            backend = this.backend
        }

    member this.frames : BrowserFrame array =
        this.page.Frames
        |> Array.map (fun frame ->
            {
                frame = frame :?> CdpFrame
                backend = this.backend
            }
        )

    member this.childFrames : BrowserFrame array =
        this.page.MainFrame.ChildFrames
        |> Seq.map (fun frame ->
            {
                frame = frame :?> CdpFrame
                backend = this.backend
            }
        )
        |> Seq.toArray


type ProtocolTarget = 
    {
        cdp:CdpTarget
        info:DevTools.V151.Target.TargetInfo option
    }

type GoogleChrome =
    {
        browser : CdpBrowser
        session : ICDPSession
        backend : PuppeteerBrowserBackend
    }

    static member Start () =

        let options = ConnectOptions()
        
        options.BrowserURL <- "http://127.0.0.1:9222"
        options.DefaultViewport <- null

        task {
            let! browser =
                Puppeteer.ConnectAsync(options)

            let! session =
                browser.CreateCDPSessionAsync()

            let! pages =
                browser.PagesAsync()

            let backend =
                PuppeteerBrowserBackend(pages[0] :?> CdpPage)

            BrowserApi.Common.JsObject.Backend <-
                backend :> IBrowserBackend

            return
                {
                    browser = browser :?> CdpBrowser
                    session = session
                    backend = backend
                }
        }
        |> await
    


    member this.openTargetInForeground
        (target : ProtocolTarget) =

        task {
            let! page =
                target.cdp.PageAsync() 
            let cdpPage = page :?> CdpPage

            let! session =
                target.cdp.CreateCDPSessionAsync()

            let backend =
                PuppeteerBrowserBackend(cdpPage)

            JsObject.Backend <-
                backend :> IBrowserBackend

            return {
                page = cdpPage
                session = session
                backend = backend
            }
        }
        |> await
        
    member this.targetInfos = 
        let command = DevTools.V151.Target.GetTargetsCommandSettings()
        let response = this.session.SendAsync<DevTools.V151.Target.GetTargetsCommandResponse>(command.CommandName, command) |> await
        response.TargetInfos 
        |> Array.sortBy (fun target -> target.TargetId)
    member this.cdpTargets = 
        this.browser.Targets() |> Array.choose (fun itarget -> 
            match itarget with 
            | :? CdpTarget as cdpTarget -> Some cdpTarget
            | _ -> None
            )
            |> Array.sortBy (fun target -> target.TargetId)
    member this.protocolTargets = 
        this.cdpTargets
        |> Array.map (fun cdpTarget -> 
            let targetInfo =  this.targetInfos |> Array.tryFind (fun targetInfo -> targetInfo.TargetId = cdpTarget.TargetId)
            {
                cdp = cdpTarget
                info = targetInfo
            }
        )


    member this.targetsByType (ktype:kType) = 
        this.protocolTargets
        |> Array.filter (fun protocolTarget -> 
            match protocolTarget.info with 
            | Some targetInfo -> targetInfo.Type = ktype.asString
            | None -> protocolTarget.cdp.Type = ktype.asTargetType
            )

    member this.tabs = this.targetsByType kType.tab
    member this.pages = this.targetsByType kType.page
    member this.iframes = this.targetsByType kType.iframe
    member this.workers = this.targetsByType kType.worker
    member this.shared_workers = this.targetsByType kType.shared_worker
    member this.service_workers = this.targetsByType kType.service_worker
    member this.worklets = this.targetsByType kType.worklet
    member this.browsers = this.targetsByType kType.browser
    member this.webviews = this.targetsByType kType.webview
    member this.others = this.targetsByType kType.other
    member this.auction_worklets = this.targetsByType kType.auction_worklet
    member this.assistive_technologiess = this.targetsByType kType.assistive_technology
    member this.browser_uis = this.targetsByType kType.browser_ui

    

let cdp = GoogleChrome.Start()

let mainTab = cdp.openTargetInForeground cdp.pages[0]






















*)

module LeonCounty = 
    module Resolution = 
        let TreatAllDignityRespect =  "https://cms.leoncountyfl.gov/Portals/0/DeptFiles/Admin/ResolutionTreatAllDignityRespect.pdf" |> FileInfo 
    module ComprehensivePlan = 
        let TallahasseeLeonCounty2050 =  "https://www.talgov.com/Uploads/Public/Documents/place/comp_plan/tallahassee-leon-county-comprehensive-plan-rev-g2026n.pdf" |> FileInfo 
    module FY2022 = 
        module FY2026 = 
            let StrategicPlan =  "https://cms.leoncountyfl.gov/Portals/0/DeptFiles/CMR/Docs/StrategicPlan.pdf" |> FileInfo 
    module FY2025 = 
            let AnnualReport =  "https://cms.leoncountyfl.gov/Portals/0/adam/Documents/AI0vCswaFkyX0tCKHBE7pQ/Link/LCAR-2025.pdf" |> FileInfo 
    module FY2026 = 
        module Budget = 
            module Adopted = 
                let LeonCounty =  "https://cms.leoncountyfl.gov/Portals/0/DeptFiles/OMB/Docs/AnnualBudget/FY2026AdoptedBudget.pdf" |> FileInfo 
                let GeneralBudgetInformation =  "https://www.leoncountyfl.gov/omb/budget26/docs/00-05%20-%20General%20Budget%20Information.pdf" |> FileInfo 
                let DepartmentofPublicWorks =  "https://www.leoncountyfl.gov/omb/budget26/docs/11%20-%20Public%20Works.pdf" |> FileInfo 
                let OfficeofInformationAndTechnology =  "https://www.leoncountyfl.gov/omb/budget26/docs/09%20-%20Office%20of%20Information%20Technology.pdf" |> FileInfo 
                let Appendix =  "https://www.leoncountyfl.gov/omb/budget26/docs/26%20-%20Appendix.pdf" |> FileInfo 




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


module OfficeofInformationAndTechnology =
    let pdf = PdfDocument.Open LeonCounty.FY2026.Budget.Adopted.OfficeofInformationAndTechnology.FullName

module NeoGov = 
    let PaginatedUrl (url:DomUrl) = 

                    url
                    |> DomUrl.AddQueryParameter "Page" 1
                    |> DomUrl.AddQueryParameter "PageSize" 1000
    let loginwithsso = DomUrl "https://login.neogov.com/loginwithsso"  // ?returnURL=https%3A%2F%2Funified.neogov.com%2Fdashboard&siteCode=US 
    let dashboard = DomUrl "https://unified.neogov.com/dashboard" 
    module Employee = 
        let employees = DomUrl "https://unifiedweb-api.neogov.com/api/Employee/employees"  |> PaginatedUrl
        module by = 
            module id = 
                let orgChartView (employeeId:string) = DomUrl $"https://unifiedweb-api.neogov.com/api/Employee/{employeeId}/hierarchy/orgChartView"  |> DomUrl.AddQueryParameter "includeSubordinateInformation"  true
                let directManager (employeeId:string) = DomUrl $"https://unifiedweb-api.neogov.com/api/Employee/{employeeId}/directManager"  
                let profile (employeeId:string) = DomUrl $"https://unifiedweb-api.neogov.com/api/Employee/user-profile"  |> DomUrl.AddQueryParameter "employeeId"  employeeId
    module Default = 
        let customWindowProperties = DomUrl "https://unifiedweb-api.neogov.com/api/Default/customWindowProperties" 
    let profile (employeeId:string) = DomUrl $"https://unified.neogov.com/profile/{employeeId}" 
    module Task = 
        let todo = DomUrl "https://unifiedweb-api.neogov.com/api/Task/todo"  |> PaginatedUrl
        let completed = DomUrl "https://unifiedweb-api.neogov.com/api/Task/completed"  |> PaginatedUrl
        let taskType = DomUrl "https://unifiedweb-api.neogov.com/api/TaskType" 





(*

mainTab.BringToFrontAsync().await

mainTab.GoToAsync(NeoGov.dashboard.asString).await

El.A * Attr.Href.StartsWith("/loginwithsso") |> _.Css |> mainTab.Locator |> _.ClickAsync().await

El.Input * Attr.Id.Equals("EmployerCode") |> _.Css |> mainTab.Locator |> _.FillAsync("leoncountyfl").await

El.Button * Attr.Id.Equals("sendEmployerId") |> _.Css |> mainTab.Locator |> _.ClickAsync().await
El.Input * Attr.Type.Equals("submit") |> _.Css |> mainTab.Locator |> _.ClickAsync().await







*)








module Accela = 
    [<RequireQualifiedAccess>]
    type Environment = 
        | prod
        | test
        | supp
        member this.asString = this.ToString()
        member this.url  = DomUrl $"https://leonco-{this.asString}-av.accela.com/" 
        member this.contacts = this.url.AppendPath "portlets/commons/contact/refContact.jsp?mode=search&spaceName=spaces.leonco.contacts&spaceName=spaces.leonco.contacts&spaceName=spaces.leonco.contacts"
        member this.licenseprofessionals = this.url.AppendPath "portlets/commons/professional/refProfessional.jsp?spaceName=spaces.leonco.licenseprofessionals&spaceName=spaces.leonco.licenseprofessionals&spaceName=spaces.leonco.licenseprofessionals&spaceName=spaces.leonco.licenseprofessionals"
        member this.record = this.url.AppendPath "portlets/commons/cap/myCAPDetailPortlet.jsp?module=-select-&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record"
        member this.recordSearch = this.url.AppendPath "portlets/cap/capSearch.do?mode=search&isFromSearch=true&isSearchButton=true&spaceName=spaces.leonco.record&module=PublicWorks&isGeneralCAP=Y"
        member this.permit (permitNumber : string) = this.url.AppendPath $"portlets/cap/capsummary/CapTabSummary.do?mode=tabSummary&serviceProviderCode=LEONCO&ID1=EMP26&ID2=00000&ID3=00029&requireNotice=YES&clearForm=clearForm&module=EnvManagement&isFromCapList=true&isGeneralCAP=Y&spaceName=spaces.leonco.{permitNumber.ToLowerInvariant()}&spaceName=spaces.leonco.{permitNumber.ToLowerInvariant()}"
    module DigEplan = 
        // https://support.digeplan.com/hc/en-us/articles/51431808148884-Bug-Fixes
        let url  = DomUrl "https://leonco.usw.digeplan.app/"
        
        module DataSheet =
            let May25 = DomUrl "https://avolvesoftware.com/wp-content/uploads/2025/07/DigEplan-Data-Sheet-May-25.pdf" 
            let AccelaND = DomUrl "https://digeplan.com/wp-content/uploads/2020/12/DEP-Data-Sheet-Accela-ND.pdf" 


// Accela.DigEplan.DataSheet.AccelaND.DownloadFileText()
let leonco = Accela.Environment.prod


// leonco.permit "LEM26006" |> mainTab.navigate











(*
[|
    "Attachments"
    "Audits"
    "CatalogItems"
    "Categories"
    "ChangeCatalogs"
    "ChangeRequests"
    "Changes"
    "Comments"
    "ConfigurationItems"
    "Contracts"
    "CustomFields"
    "CustomForms"
    "Dashboards"
    "Departments"
    "Groups"
    "Hardwares"
    "Incidents"
    "IncidentTypes"
    "Memberships"
    "MobileDevices"
    "Notifications"
    "OtherAssets"
    "Printers"
    "Problems"
    "PurchaseOrders"
    "PurchaseOrdersApi"
    "Purchases"
    "Releases"
    "ResponseTemplates"
    "Risks"
    "Roles"
    "ServiceRequests"
    "SetupItsmStates"
    "Sites"
    "Softwares"
    "Solutions"
    "Tasks"
    "Tickets"
    "TimeTracks"
    "UiCustomViews"
    "UiInfrastructure"
    "UiJsonHtmlLists"
    "Users"
    "Vendors"
    "Widgets"
    "WorkflowApprovers"
|]
|> Array.map (fun SolarWindsInterface ->
$"""
module {SolarWindsInterface} = 
    let restService = RestService.For<I{SolarWindsInterface}> (httpClient, refitSettings)
"""

)
|> String.concat "\n"
|> clip

*)



module SolarWindsServiceDesk = 


    let jsonOptions =
        JsonSerializerOptions(
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
        )

    let refitSettings =
        RefitSettings(
            SystemTextJsonContentSerializer(jsonOptions)
        )

    refitSettings.UrlParameterFormatter <- ServiceDeskUrlParameterFormatter()

    let ServiceUrl = 
        DomUrl "https://leoncountyfl.samanage.com"
        
        |> DomUrl.AddQueryParameter "layout" "long"
        |> DomUrl.AddQueryParameter "is_portal_mode" false
    let home = ServiceUrl.AppendPath "incidents?report_id=9641268&assigned_to%5B%5D=10744815&data=state&sort_by=state&sort_order=DESC&state_is_not%5B%5D=758500&state_is_not%5B%5D=758501&state_is_not%5B%5D=758502&state_is_not%5B%5D=793540&state_is_not%5B%5D=800657"
    let sessionCookie = 
        task {
            let options = new CreatePageOptions()
            options.Background <- true
            let! tab = chrome.NewPageAsync(options)
            let! response = tab.GoToAsync(ServiceUrl.asString)
            let request = response.Request
            let cookie =
                match request.Headers.TryGetValue "cookie" with
                | true, value -> value
                | _ -> failwith "The browser request has no cookie header."

            do! tab.CloseAsync()
            return cookie
            }
    let httpClient = new HttpClient(BaseAddress = Uri ServiceUrl.Origin)

    httpClient.DefaultRequestHeaders.TryAddWithoutValidation(
        "Cookie", await sessionCookie  
    )
    |> ignore
    module Api =

        let Attachments = RestService.For<IAttachments> (httpClient, refitSettings) 
        let Audits = RestService.For<IAudits> (httpClient, refitSettings) 
        let CatalogItems = RestService.For<ICatalogItems> (httpClient, refitSettings) 
        let Categories = RestService.For<ICategories> (httpClient, refitSettings) 
        let ChangeCatalogs = RestService.For<IChangeCatalogs> (httpClient, refitSettings) 
        let ChangeRequests = RestService.For<IChangeRequests> (httpClient, refitSettings) 
        let Changes = RestService.For<IChanges> (httpClient, refitSettings) 
        let Comments = RestService.For<IComments> (httpClient, refitSettings) 
        let ConfigurationItems = RestService.For<IConfigurationItems> (httpClient, refitSettings) 
        let Contracts = RestService.For<IContracts> (httpClient, refitSettings) 
        let CustomFields = RestService.For<ICustomFields> (httpClient, refitSettings) 
        let CustomForms = RestService.For<ICustomForms> (httpClient, refitSettings) 
        let Dashboards = RestService.For<IDashboards> (httpClient, refitSettings) 
        let Departments = RestService.For<IDepartments> (httpClient, refitSettings) 
        let Groups = RestService.For<IGroups> (httpClient, refitSettings) 
        let Hardwares = RestService.For<IHardwares> (httpClient, refitSettings) 
        let Incidents = RestService.For<IIncidents> (httpClient, refitSettings) 
        let IncidentTypes = RestService.For<IIncidentTypes> (httpClient, refitSettings) 
        let Memberships = RestService.For<IMemberships> (httpClient, refitSettings) 
        let MobileDevices = RestService.For<IMobileDevices> (httpClient, refitSettings) 
        let Notifications = RestService.For<INotifications> (httpClient, refitSettings) 
        let OtherAssets = RestService.For<IOtherAssets> (httpClient, refitSettings) 
        let Printers = RestService.For<IPrinters> (httpClient, refitSettings) 
        let Problems = RestService.For<IProblems> (httpClient, refitSettings) 
        let PurchaseOrders = RestService.For<IPurchaseOrders> (httpClient, refitSettings) 
        let PurchaseOrdersApi = RestService.For<IPurchaseOrdersApi> (httpClient, refitSettings) 
        let Purchases = RestService.For<IPurchases> (httpClient, refitSettings) 
        let Releases = RestService.For<IReleases> (httpClient, refitSettings) 
        let ResponseTemplates = RestService.For<IResponseTemplates> (httpClient, refitSettings) 
        let Risks = RestService.For<IRisks> (httpClient, refitSettings) 
        let Roles = RestService.For<IRoles> (httpClient, refitSettings) 
        let ServiceRequests = RestService.For<IServiceRequests> (httpClient, refitSettings) 
        let SetupItsmStates = RestService.For<ISetupItsmStates> (httpClient, refitSettings) 
        let Sites = RestService.For<ISites> (httpClient, refitSettings) 
        let Softwares = RestService.For<ISoftwares> (httpClient, refitSettings) 
        let Solutions = RestService.For<ISolutions> (httpClient, refitSettings) 
        let Tasks = RestService.For<ITasks> (httpClient, refitSettings) 
        let Tickets = RestService.For<ITickets> (httpClient, refitSettings) 
        let TimeTracks = RestService.For<ITimeTracks> (httpClient, refitSettings) 
        let UiCustomViews = RestService.For<IUiCustomViews> (httpClient, refitSettings) 
        let UiInfrastructure = RestService.For<IUiInfrastructure> (httpClient, refitSettings) 
        let UiJsonHtmlLists = RestService.For<IUiJsonHtmlLists> (httpClient, refitSettings) 
        let Users = RestService.For<IUsers> (httpClient, refitSettings) 
        let Vendors = RestService.For<IVendors> (httpClient, refitSettings) 
        let Widgets = RestService.For<IWidgets> (httpClient, refitSettings) 
        let WorkflowApprovers = RestService.For<IWorkflowApprovers> (httpClient, refitSettings) 


[<Literal>]
let incidentsFilterFilePath = @"D:\Iri\https\leoncountyfl.samanage.com\filters.json\context\incidents\is_portal_mode\False\layout\long\bare\filters.json"
type IncidentsFilterProvider = JsonProvider< UseOriginalNames = true, PreferDateOnly = true, OmitNullFields = true,
    RootName = "filters",
    Sample =  incidentsFilterFilePath >



[<Literal>]
let incidentsMetadataFilePath = @"D:\Iri\https\leoncountyfl.samanage.com\custom_views\incidents\metadata.json\assigned_to[]\10744815\data\state\is_portal_mode\false\report_id\9641268\sort_by\state\sort_order\DESC\state_is_not[]\758500\758501\758502\793540\800657\bare\metadata.json"
type IncidentsMetadataProvider = JsonProvider< UseOriginalNames = true, PreferDateOnly = true, OmitNullFields = true,
    RootName = "metadata",
    Sample =  incidentsMetadataFilePath >


[<Literal>]
let incidentsCustomViewFilePath = @"D:\Iri\https\leoncountyfl.samanage.com\custom_views\incidents.json\is_portal_mode\false\report_id\9641268\bare\incidents.json"
type IncidentsCustomViewProvider = JsonProvider< UseOriginalNames = true, PreferDateOnly = true, OmitNullFields = true,
    RootName = "column",
    Sample =  incidentsCustomViewFilePath >



type IIncidents with
    member this.Get(request:GetIncidentsRequest) = 
        request.Layout <- ResponseLayout.Long
        task {
            return! this.GetAsync( request, CancellationToken.None )
        }
        |> await
        |> Seq.toArray
    member this.GetId(id:int) = 
        task {
            return! this.GetAsync( id, ResponseLayout.Long, CancellationToken.None )
        }
        |> await





let incidentsMetadata = IncidentsMetadataProvider.Load incidentsMetadataFilePath
let incidentsCustomView = IncidentsCustomViewProvider.Load incidentsCustomViewFilePath
let incidentsFilters = IncidentsFilterProvider.Load(incidentsFilterFilePath)

let titleFilter (title:string) (resource:DomUrl) = 
    resource
    |> DomUrl.AddQueryParameter "title" title

let viewIncidents (resource:DomUrl) = 
    resource
    |> DomUrl.AddQueryParameter "report_id" 9641268
    |> DomUrl.AddQueryParameter "applied" true





type String with 
    member this.prefixed (affix:string) = affix + this
    member this.suffixed (affix:string) = this + affix
    member this.circumfixed (affix:string) = affix + this + affix
    member this.normalizedFSharpIdentifier  =
        let sb = System.Text.StringBuilder()
        for rune in this.EnumerateRunes() do
            let maybeCharacterReference = HtmlEntities.namedCharacterReferenceByString.TryFind(string rune)
            let toAppend = 
                match maybeCharacterReference, CharUnicodeInfo.GetUnicodeCategory rune.Value with 
                | Some namedCharacterReference, UnicodeCategory.ConnectorPunctuation when namedCharacterReference.entityName <> "lowbar"  -> maybeCharacterReference.Value.entityName.circumfixed  "'"
                | Some namedCharacterReference, UnicodeCategory.OtherPunctuation  -> maybeCharacterReference.Value.entityName.circumfixed  "'"
                | Some namedCharacterReference, UnicodeCategory.OpenPunctuation  -> maybeCharacterReference.Value.entityName.circumfixed  "'"
                | Some namedCharacterReference, UnicodeCategory.ClosePunctuation  -> maybeCharacterReference.Value.entityName.circumfixed  "'"
                | _, UnicodeCategory.DashPunctuation  -> "_"
                | _, _ -> string rune
            sb.Append((toAppend.ReplaceWhitespace("_")).NormalizeKeyword) |> ignore


        sb.ToString()
    member this.NormalizeFirstCharacter =
        match this with
        | "" ->
            "_"

        | identifier
            when Syntax.PrettyNaming.IsIdentifierFirstCharacter identifier[0] ->
            identifier

        | identifier ->
            "_" + identifier
    member this.NormalizeKeyword : string =
        if Binder.KeywordNames.Contains this then
            this + "_"
        else
            this

let rdfNamespaceName = "http://www.w3.org/1999/02/22-rdf-syntax-ns#"
rdfNamespaceName

// HtmlEntities.resourceReference.DownloadFileText()

let testColumn = incidentsCustomView[22]
let testIdentifier = testColumn.name.JsonValue.AsString()
let testBinder = VariableBinder testIdentifier 

testIdentifier.normalizedFSharpIdentifier 

type Rune with 
    member this.UnicodeCategory = CharUnicodeInfo.GetUnicodeCategory this.Value


(*
incidentsCustomView
|> Array.map (fun  column -> 
    let columnName = column.name.JsonValue.AsString()
    let identifier = 
        match Int32.TryParse (columnName) with
        |true, _ -> column.label + columnName
        | false, _  -> columnName
    let parameterValue = 
        match column.``type`` with 
            | "attachment_input" -> "parameterValue"
            | "Checkbox" -> "parameterValue"
            | "Date_and_Time" -> "parameterValue"
            | "date" -> "parameterValue"
            | "Date" -> "parameterValue"
            | "Dropdown" -> "parameterValue"
            | "multi_picklist" -> "parameterValue"
            | "Number" -> "parameterValue"
            | "select" -> "parameterValue"
            | "select2" -> "parameterValue"
            | "Text_Area" -> "parameterValue"
            | "text" -> "parameterValue"
            | "Text" -> "(parameterValue : string) "
            | "user" -> "parameterValue"
            | "User" -> "parameterValue"
            | _ -> "parameterValue"
    $"let {identifier.normalizedFSharpIdentifier} {parameterValue}  (resourceReference:ResourceReference) = resourceReference |> ResourceReference.AddQueryParameter \"{columnName}\" parameterValue"

    )
|> Array.distinct
|> Array.sort
|> String.concat "\n" |> clip

*)
module Users = 
    let resourceReference = SolarWindsServiceDesk.ServiceUrl.AppendPath "users.jsonhtml"
    [<Literal>]                        
    let jsonHtmlPath = @"D:\Iri\https\leoncountyfl.samanage.com\users.jsonhtml\bare\users.jsonhtml"
    
    type Provider = JsonProvider< UseOriginalNames = true, PreferDateOnly = true, OmitNullFields = true,
        RootName = "jsonhtml",
        Sample =  jsonHtmlPath >
    let jsonhtml = Provider.Load jsonHtmlPath

Users.jsonhtml.count








module SolarWindsFilter =
        let assigned_to parameterValue  (resourceReference:DomUrl) = resourceReference |> DomUrl.AddQueryParameter "2327702" parameterValue




// https://leoncountyfl.samanage.com/incidents?report_id=9641268
// &applied=true
// &title%5B%5D=test
// &sort_by=state
// &sort_order=DESC
// &data=state
// &columns=requester%2Ctitle%2Cstate%2Csub_type%2Ctype%2Csite%2Cdepartment%2Cassigned_to%2Cpriority%2Ccreated_at%2Ccreated_by%2Ctag_list%2Cnumber%2Cslm%2Cpreview

let filterTypes = incidentsCustomView |> Array.map (fun column -> column.``type``) |> Array.distinct |> Array.sort


SolarWindsServiceDesk.ServiceUrl.AppendPath "incidents.json"
|> DomUrl.AddQueryParameter "applied" true
|> DomUrl.AddQueryParameter "data" "state"
|> SolarWindsFilter.assigned_to 10744815

let testFilter = DomUrl "https://leoncountyfl.samanage.com/incidents?assigned_to_is_not%5B%5D=10744815&created_by%5B%5D=10899501&report_id=9702975&state_is_not%5B%5D=758500&state_is_not%5B%5D=758501&state_is_not%5B%5D=758502&state_is_not%5B%5D=793540&state_is_not%5B%5D=800657" 
testFilter.QueryStringParameters

let metadataTest = DomUrl "https://leoncountyfl.samanage.com/custom_views/incidents/metadata.json?assigned_to%5B%5D=10744815&data=state&report_id=9641268&sort_by=state&sort_order=DESC&state_is_not%5B%5D=758500&state_is_not%5B%5D=758501&state_is_not%5B%5D=758502&state_is_not%5B%5D=793540&state_is_not%5B%5D=800657&is_portal_mode=false" 
metadataTest.AbsolutePathName
let incidentFilters = 
    SolarWindsServiceDesk.ServiceUrl.AppendPath "filters.json"
    |> DomUrl.AddQueryParameter "context" "incidents"
incidentFilters.asFile.FullName |> clip
// // D:\Iri\https\leoncountyfl.samanage.com\filters.json\context\incidents\is_portal_mode\False\layout\long\bare\filters.json

// incidentFilters.DownloadFileText()
// incidentFilters.asFile.DirectoryName |> clip







incidentsFilters[0]
incidentsFilters
|> Array.map (fun filter -> 
    filter.optionsUrl
    |> Option.map (fun optionsUrl ->
        SolarWindsServiceDesk.ServiceUrl.Origin + optionsUrl
        |> DomUrl
        
        |> _.HeadedDownloadText()
        )
)

let testTitleFilter = DomUrl "https://leoncountyfl.samanage.com/incidents?report_id=9641268&applied=true&columns=requester%2Ctitle%2Cstate%2Csub_type%2Ctype%2Csite%2Cdepartment%2Cassigned_to%2Cpriority%2Ccreated_at%2Ccreated_by%2Ctag_list%2Cnumber%2Cslm%2Cpreview&data=state&sort_by=state&sort_order=DESC&title%5B%5D=test" 
testTitleFilter.QueryStringParameters
let testOption = SolarWindsServiceDesk.ServiceUrl.Origin + incidentsFilters[1].optionsUrl.Value |>DomUrl 
testOption
QueryStringUtilities.ParseQuery incidentsFilters[1].optionsUrl.Value
let queryDelimiterIndex = incidentsFilters[1].optionsUrl.Value.IndexOf('?')

// https://leoncountyfl.samanage.com/incidents/filter_values.json?filter=number_of_reassignments

(*

type IncidentRequest = 
    {

    }

*)



let incidents = 
    let request = GetIncidentsRequest()
    
    request.CreatedFrom <- DateTime.Today
    request.ReportId <- 9641268
    SolarWindsServiceDesk.Api.Incidents.Get request




















































(*



frontTab.page.GoTo Infor.infortest.test_operations
frontTab.childFrames[0]
let selectedNodes = El.Iframe * Attr.Id.Equals "menuAndView" |> frontTab.document.DocumentElement.QuerySelectorAll

selectedNodes
frontTab.document.Body

frontTab.childFrames[0]



let menuAndView = frontTab.childFrames |> Array.find (fun browserFrame -> browserFrame.frame.DomUrl.Pathname.EndsWith("Menu.aspx"))


type InforMenuItem = 
    {
        menuItem :Dom.Element
    }
    static member fromId (id:string) = 
        {
            menuItem = Attr.Id.Equals id |> menuAndView.document.QuerySelector
        }
    member this.pathName =  this.menuItem.OwnerDocument.DomUrl.Absolute.HashTerminated.asIriReference.asPathName ./ this.menuItem.Id
    member this.selector = El.Li * Attr.Id.Equals (string this.menuItem.Id)
    member this.labelFor = string this.menuItem.Id |> Attr.Aria.LabelledBy.Equals  |> menuAndView.document.QuerySelector 
    member this.Click() = menuAndView.frame.Click this.selector
    member this.name = this.menuItem.FirstChild.TextContent
    member this.sampleIdentifier = $"{this.name}HtmlPath"
    member this.HtmlAbbrev = Ast.Abbrev($"{this.name}HtmlProvider",$"HtmlProvider<PreferOptionals = true, PreferDateOnly = true, Sample = {this.sampleIdentifier}>")
    member this.XmlAbbrev = Ast.Abbrev($"{this.name}XmlProvider", $"XmlProvider<UseOriginalNames = true, PreferDateOnly = true, Sample = {this.sampleIdentifier}>")
    member this.WriteHtmlText() =  this.menuItem.outerHTML |> this.pathName.writeTextFileExtension ".html" 
    member this.htmlFile = this.pathName.asFileExtension ".html"

    member this.ProviderText = 
        if not this.htmlFile.Exists then 
            this.WriteHtmlText()
        Ast.Oak(){
            Ast.AnonymousModule(){
                Ast.Value(this.sampleIdentifier, Ast.VerbatimString(this.htmlFile.FullName))
                |> _.attribute(
                    Ast.Attribute("Literal")
                )
                this.HtmlAbbrev
                this.XmlAbbrev
            }
        }
        |> Gen.mkOak
        |> Gen.run

module InforMenu = 
    let Asset_Management = InforMenuItem.fromId "AstMngmnt" 
    let Inventory = InforMenuItem.fromId "Invntry" 
    let Work_Management = InforMenuItem.fromId "WrkMngmnt" 
    let Customer_Service = InforMenuItem.fromId "CstmrSrvc" 
    let Resources = InforMenuItem.fromId "Rsrcs" 
    let System = InforMenuItem.fromId "Systm" 
    let Portal = InforMenuItem.fromId "Prtl" 

[<Literal>]
let SystemHtmlPath =
    @"C:\Iri\https\infortest.leoncountyfl.gov\test_operations\Menu.aspx\hash\Systm.html"

type SystemHtmlProvider = HtmlProvider<PreferOptionals = true, PreferDateOnly = true, Sample = SystemHtmlPath>
type SystemXmlProvider = XmlProvider<UseOriginalNames = true, PreferDateOnly = true, Sample = SystemHtmlPath>
let SystemHtml = SystemHtmlProvider.Load SystemHtmlPath
let SystemXHtml = SystemXmlProvider.Parse InforMenu.System.menuItem.outerHTML
SystemXHtml.ul.lis[0].ul
SystemHtml.Lists
let monikers = SystemXHtml.ul.lis |> Array.choose (fun li -> li.moniker)
SystemXHtml.ul.lis[0]

InforMenu.System.ProviderText |> clip
InforMenu.System.WriteHtmlText()
InforMenu.System.htmlFile
InforMenu.System.pathName
InforMenu.System.Click()
InforMenu.System.menuItem.Children[1u].Children[0u].Children[1u].Children[0u].Children[0u].TextContent
InforMenu.System.menuItem.TagName
InforMenu.System.menuItem.Children[0u].TagName
InforMenu.System.menuItem.outerHTML |> clip

let inforMenuItems = menuAndView.menuitems |> Array.map (fun menuitem -> { menuItem = menuitem})

*)

