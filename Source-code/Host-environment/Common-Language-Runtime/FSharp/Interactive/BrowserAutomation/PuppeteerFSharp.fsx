(*
& "C:\Program Files\Google\Chrome\Application\chrome.exe" --remote-debugging-port=9222 --user-data-dir=C:\temp\chrome-automation
*)
# time on
fsi.ShowDeclarationValues <- false

open System
open System.Diagnostics
open System.Collections.Generic
open System.IO
open System.ComponentModel.DataAnnotations
open System
open System.Globalization
open System.Threading
open System.Net
open System.Linq
open System.IO
open System.Threading.Tasks
open System.Text
open System.Text.Json
open System.Text.Json.Nodes
open System.Text.Json.Serialization
open System.IO
open System.Text.Json
open System.Xml
open System.Xml.Linq
open System.Xml.XPath
open System.Xml.Serialization
open System.Xml.Schema


open System
open System.Net.Http
open System.Net.Http.Headers
#r "nuget: Microsoft.Graph"

open System.Net.Http
open System.Net.Http.Headers
open Microsoft.Graph
open Microsoft.Graph.Models
open Microsoft.Graph.Users.Item.SendMail

#r "nuget: CsvHelper"
open CsvHelper



#r "nuget: SafeName, 0.1.1"
open SafeName

#r "nuget: WebSharper, 9.1.9.621"
open WebSharper.Core
#r "nuget: Microsoft.Extensions.Logging.Abstractions, 10.0.11"
open Microsoft.Extensions.Logging.Abstractions

#r "nuget: FSharp.ViewEngine, 2026.8.1"
open FSharp.ViewEngine
open type Html

#r "nuget: Fabulous.AST.Json, 2.0.0-pre06"
open Fabulous.AST
open Fabulous.AST.Json

#r "nuget: Json.More.Net, 3.0.1"
open Json.More

#r "nuget: JsonStructure, 0.8.0"
open JsonStructure

#r "nuget: JsonPointer.Net"
open Json.Pointer
#r "nuget: JsonPath.Net, 3.0.2"
open Json.Path

#r "nuget: SolarWinds.Api, 2026.5.44"
open SolarWinds.Api
open SolarWinds.Api.ServiceDesk
open SolarWinds.Api.ServiceDesk.Models

// #r "nuget: NJsonSchema, 11.5.2.0"
// open NJsonSchema

#r "nuget: Fli"
open Fli
#r "nuget: FSharp.Collections.ParallelSeq"
open FSharp.Collections.ParallelSeq

#r "nuget: FPrimitive"

open FPrimitive

#r "nuget: Universal.Common.Css.Selectors"
open Universal.Common
#r "nuget: Newtonsoft.Json, 13.0.5-beta1"
open Newtonsoft.Json

#r "nuget: Meziantou.Framework"
#r "nuget: Meziantou.Framework.Uri"
open Meziantou.Framework
// #r "nuget: Meziantou.Framework.Language.Json"
// open Meziantou.Framework.Json
// open Meziantou.Framework.Language.Json

#r "nuget: Humanizer.Core"
open Humanizer
#r "nuget: CaseConverter"
open CaseConverter

#r "nuget: FSharp.Data"
#r "nuget: FSharp.Data.Mutator,0.2.0"
#r "nuget: FSharp.Data.JsonPath, 1.1.3"
#r "nuget: FSharp.Data.JsonSchema.Core, 3.1.0"
#r "nuget: FSharp.Data.JsonSchema.NJsonSchema, 3.1.0"
#r "nuget: FSharp.Data.JsonSchema.OpenApi, 3.1.0"
open FSharp.Data
open FSharp.Data.Mutator
open FSharp.Data.JsonPath
open FSharp.Data.JsonSchema
open FSharp.Data.JsonSchema.Core
open FSharp.Data.JsonSchema.OpenApi
open NJsonSchema

#r "nuget: PuppeteerSharp"

open PuppeteerSharp
open PuppeteerSharp.Cdp

#r "nuget: PuppeteerSharp.Contrib.Extensions, 7.0.0"
open PuppeteerSharp.Contrib.Extensions
#r "nuget: Dubzer.WhatwgUrl"
open Dubzer.WhatwgUrl

#r "nuget: TextCopy"
open TextCopy

#r "nuget: Fss-lib.Core, 3.0.0"
open Fss.Selector 
type FssSelector = Fss.Selector.Selector
type FssAttribute = Fss.Types.Attribute.Attribute
type FssTag = Fss.Types.Html.Html


let clipboard = new Clipboard()
let clip (text:string) = clipboard.SetText text


let connectOptions = ConnectOptions()
connectOptions.BrowserURL <- "http://127.0.0.1:9222"
connectOptions.DefaultViewport <- null


module Folder = 
    let _aggregates = Directory.CreateDirectory @"D:\Artifact\Company\SolarWinds\_aggregates"
    let _samples = Directory.CreateDirectory @"D:\Artifact\Company\SolarWinds\_samples"
    let _schema = Directory.CreateDirectory @"D:\Artifact\Company\SolarWinds\_schema"
    let current = DirectoryInfo __SOURCE_DIRECTORY__ 
    let SolarWinds = Directory.CreateDirectory @"D:\Artifact\Company\SolarWinds"
    let NeoGov = Directory.CreateDirectory @"D:\Artifact\Company\NeoGov"
    let SunshineHealth = Directory.CreateDirectory @"D:\Artifact\Company\SunshineHealth"
    let MicrosoftGraph = Directory.CreateDirectory @"D:\Artifact\Company\MicrosoftGraph"
    // let departments = Directory.CreateDirectory @"D:\Artifact\Company\SolarWinds\departments" 
    // let allIncidents = Directory.CreateDirectory @"D:\Artifact\Company\SolarWinds\all_incidents" 
    let incidents = Directory.CreateDirectory @"D:\Artifact\Company\SolarWinds\incidents" 
    let incidentsPage = Directory.CreateDirectory @"D:\Artifact\Company\SolarWinds\incidents_page" 

let logLines = new ResizeArray<string>()

let force (operation: Task<'OutputType>) : 'OutputType = operation.GetAwaiter().GetResult()



type FSharp.Data.JsonValue with 
    member this.JsonLine  = this.ToString( JsonSaveOptions.DisableFormatting )




type JsonSinsign = 
    {
        effectiveKey:string
        jsonValue: FSharp.Data.JsonValue
        jsonValueKind: JsonValueKind
        jsonPointer : JsonPointer
        jsonPath : JsonPath
        jsonFile: FileInfo
    }
    member this.asJsonMember = 
            match this.effectiveKey with 
            | "" when this.jsonFile.Name.StartsWith("incidents_") -> FSharp.Data.JsonValue.Record [| "incident", this.jsonValue |]  
            | "" -> FSharp.Data.JsonValue.Record [| Path.GetFileNameWithoutExtension this.jsonFile.FullName, this.jsonValue |]  
            | _ -> FSharp.Data.JsonValue.Record [| this.effectiveKey, this.jsonValue |] 
    member this.jsonText =
        string this.asJsonMember

type JsonPointer with

    member this.memberKey =
        match this.SegmentCount with
        | 0 ->
            String.Empty

        | count ->
            this.GetSegment(count - 1).ToString()


    member this.elementKey =
        match this.SegmentCount with
        | count when count >= 2 ->
            this.GetSegment(count - 2).ToString()

        | _ ->
            String.Empty


type JsonNode with

    member this.asFormattedString =
        this.ToJsonString( JsonSerializerOptions(WriteIndented = true) )


    member this.jsonPointer =
        this.GetPointerFromRoot()
        |> JsonPointer.Parse


    member this.jsonPath =
        this.GetPathFromRoot()
        |> JsonPath.Parse


    member this.effectiveKey =
        match this.Parent with

        // The root is treated as an implicit sinsign whose effective key
        // is the empty string.
        | null ->
            String.Empty

        // An object-member value is explicitly keyed by the member name.
        | :? JsonObject ->
            this.jsonPointer.memberKey

        // An array element is implicitly keyed by the array itself.
        //
        // Importantly, use the array's effectiveKey rather than its last
        // pointer segment. This preserves the key through nested arrays.
        | :? JsonArray as arrayParent ->
            arrayParent.effectiveKey

        | parent ->
            failwith
                $"Unexpected JsonNode parent type: {parent.GetType().FullName}"


    member this.asJsonSinsign (jsonFile:FileInfo) =
        {
            effectiveKey = this.effectiveKey
            jsonValue = this.JsonValue()
            jsonValueKind = this.GetValueKind()
            jsonPointer = this.jsonPointer
            jsonPath = this.jsonPath
            jsonFile = jsonFile
        }


type JsonObject with

    /// The immediate JSON-member value occurrences contained by this object.
    member this.jsonSinsigns (jsonFile:FileInfo) =
        this
        |> Seq.map (fun (KeyValue(key, value)) ->

            match value with

            | null ->
                {
                    effectiveKey = key

                    jsonValue =
                        FSharp.Data.JsonValue.Null

                    jsonValueKind =
                        JsonValueKind.Null

                    jsonPointer =
                        this.jsonPointer.Combine [|
                            SegmentValueStandIn.op_Implicit key
                        |]

                    jsonPath =
                        this.jsonPath.Append(key)
                    jsonFile = jsonFile
                }

            | value ->
                value.asJsonSinsign jsonFile
        )
        |> Seq.toArray


type JsonNode with

    /// Yields this value-position and every descendant value-position as
    /// JsonSinsigns.
    ///
    /// Object-member nulls and array-element nulls require explicit
    /// construction because System.Text.Json represents JSON null as a
    /// null JsonNode reference.
    member this.DescendantsAndSelf (jsonFile:FileInfo) =
        [|
            yield this.asJsonSinsign jsonFile

            match this with

            | :? JsonObject as jsonObject ->

                for KeyValue(key, child) in jsonObject do

                    match child with

                    | null ->
                        yield
                            {
                                effectiveKey = key

                                jsonValue =
                                    FSharp.Data.JsonValue.Null

                                jsonValueKind =
                                    JsonValueKind.Null

                                jsonPointer =
                                    jsonObject.jsonPointer.Combine [|
                                        SegmentValueStandIn.op_Implicit key
                                    |]

                                jsonPath = jsonObject.jsonPath.Append(key)
                                jsonFile = jsonFile
                            }

                    | child ->
                        yield! child.DescendantsAndSelf jsonFile


            | :? JsonArray as jsonArray ->

                for index, child in jsonArray |> Seq.indexed do
                    match child with

                    | null ->
                        yield
                            {
                                effectiveKey =
                                    jsonArray.effectiveKey

                                jsonValue =
                                    FSharp.Data.JsonValue.Null

                                jsonValueKind =
                                    JsonValueKind.Null

                                jsonPointer =
                                    jsonArray.jsonPointer.Combine [|
                                        SegmentValueStandIn.op_Implicit index
                                    |]

                                jsonPath =
                                    jsonArray.jsonPath.Append(index)
                                jsonFile = jsonFile
                            }

                    | child ->
                        yield! child.DescendantsAndSelf jsonFile


            | _ -> ()
        |]






type FileInfo with 
    member this.ChangeExtension(newExtension :string) = Path.ChangeExtension(this.FullName, newExtension) |> FilePath.Sanitize |> FileInfo

type JsonRepresentation =
    {
        jsonFile: FileInfo
        jsonText:string
    }
    member this.ensureDirectory() = Directory.CreateDirectory this.jsonFile.Directory.FullName |> ignore
    member this.ndjsonFile = this.jsonFile.ChangeExtension ".ndjson"
    member this.jsonlFile = this.jsonFile.ChangeExtension ".jsonl"
    member this.schemaFile = this.jsonFile.ChangeExtension ".schema.json"
    member this.csvFile = this.jsonFile.ChangeExtension ".csv"


    member this.jsonValue =
        FSharp.Data.JsonValue.Parse this.jsonText

    member this.jsonToken =
        JsonToken.Parse this.jsonText

    member this.jsonNode =
        JsonNode.Parse this.jsonText

    member this.jsonDocument =
        JsonDocument.Parse this.jsonText


    member this.jsonSpace =
        {
            jsonSinsigns = this.jsonNode.DescendantsAndSelf this.jsonFile
        }
    member this.WriteAllJsonText() =
        this.ensureDirectory()
        File.WriteAllText(this.jsonFile.FullName, this.jsonText)
    member this.WriteAllJsonLines() = 
        this.ensureDirectory()
        File.WriteAllLines(this.ndjsonFile.FullName, this.jsonSpace.jsonLines)

    member this.WriteAllJson() = 
                this.ensureDirectory()
                this.WriteAllJsonText()
                this.WriteAllJsonLines()

    member this.resolvePointer (jsonPointer :JsonPointer) = 
        match jsonPointer.Evaluate this.jsonDocument.RootElement with 
        | nullableJsonElement when nullableJsonElement.HasValue  -> JsonNode.Parse(nullableJsonElement.Value.GetRawText()).asFormattedString |> Some
        | _ -> None


and JsonSpace =
    {
        jsonSinsigns: JsonSinsign array
    }
    member this.asJsonMembers = this.jsonSinsigns |> Array.map _.asJsonMember
    member this.jsonLines = this.asJsonMembers |> Array.map (fun jsonMember -> jsonMember.ToString( JsonSaveOptions.DisableFormatting ) ) |> Array.distinct |> Array.sort
    member this.NDJson = this.jsonLines  |> String.concat "\n"
    member this.jsonValueKinds = this.jsonSinsigns |> Array.map (fun jsonSinsign -> jsonSinsign.jsonValueKind) |> Array.distinct |> Array.sort
    member this.randomSamplesByKind (sampleCount:int) =
                this.jsonValueKinds
                |> Array.map (fun jsonValueKind -> 
                    jsonValueKind, this.jsonSinsigns |> Array.filter (fun jsonSinsign -> jsonSinsign.jsonValueKind = jsonValueKind) |> Array.randomSample sampleCount
                )


    member this.effectiveKeys =
        this.jsonSinsigns
        |> Array.map _.effectiveKey
        |> Array.distinct
        |> Array.sort


    member this.jsonSubspace chooser =
        {
            jsonSinsigns =
                this.jsonSinsigns
                |> Array.choose chooser
        }


    member this.jsonScalarSubspace =
        this.jsonSubspace (fun jsonSinsign ->

            match jsonSinsign.jsonValue with

            | FSharp.Data.JsonValue.Record _ ->
                None

            | FSharp.Data.JsonValue.Array _ ->
                None

            | _ ->
                Some jsonSinsign
        )


    member this.jsonArraySubspace =
        this.jsonSubspace (fun jsonSinsign ->

            match jsonSinsign.jsonValue with

            | FSharp.Data.JsonValue.Array _ ->
                Some jsonSinsign

            | _ ->
                None
        )


    member this.jsonObjectSubspace =
        this.jsonSubspace (fun jsonSinsign ->

            match jsonSinsign.jsonValue with

            | FSharp.Data.JsonValue.Record _ ->
                Some jsonSinsign

            | _ ->
                None
        )


    member this.keySubspaces : array<string * JsonSpace> =
        this.jsonSinsigns
        |> Array.groupBy _.effectiveKey
        |> Array.map (fun (effectiveKey, jsonSinsigns) -> effectiveKey, {jsonSinsigns = jsonSinsigns})
        |> Array.sortBy fst
    member this.subspaceByKey (key:string) = 
            this.keySubspaces
            |> Array.tryFind (fun (effectiveKey, _) ->
                effectiveKey = key)
            |> Option.map (fun (key,(keySpace:JsonSpace)) -> keySpace)
    member this.homogenousKeySubspaces = 
        this.keySubspaces
        |> Array.choose (fun (effectiveKey, (keySpace:JsonSpace)) -> 
        match keySpace.jsonValueKinds with 
        | [| valueKind |] -> Some (effectiveKey, keySpace)
        | [| JsonValueKind.True ; JsonValueKind.False |] -> Some (effectiveKey, keySpace)
        | [| JsonValueKind.Array ; elementValueKind |] -> Some (effectiveKey, keySpace)
        | [| JsonValueKind.Object ; JsonValueKind.Array  |] -> Some (effectiveKey, keySpace)
        | [| valueKind ; JsonValueKind.Null |] -> Some (effectiveKey, keySpace)
        | _ -> None
        )
        |> Array.distinct
        |> Array.sortBy (fun (key,keySpace) -> keySpace.jsonSinsigns.Length)
        |> Array.rev
    member this.homogenousSubspace = 
        {
            jsonSinsigns = this.homogenousKeySubspaces |> Array.collect (fun (key, keySpace) -> keySpace.jsonSinsigns )
        }
    member this.homogenousEffectiveKeys = 
            this.homogenousKeySubspaces  |> Array.map (fun (effectiveKey, _) -> effectiveKey)

    member this.heterogenousKeySubspaces = 
        this.keySubspaces
        |> Array.choose (fun (effectiveKey, (keySpace:JsonSpace)) -> 
        match keySpace.jsonValueKinds with 
        | [| valueKind |] -> None
        | [| JsonValueKind.True ; JsonValueKind.False |] -> None
        | [| JsonValueKind.Array ; elementValueKind |] -> None
        | [| JsonValueKind.Object ; JsonValueKind.Array  |] -> None
        | [| valueKind ; JsonValueKind.Null |] -> None
        | _ -> Some (effectiveKey, keySpace)
        )
        |> Array.distinct
        |> Array.sortBy (fun (key,keySpace) -> keySpace.jsonSinsigns.Length)
        |> Array.rev

    member this.heterogenousSubspace = 
        {
            jsonSinsigns = this.heterogenousKeySubspaces |> Array.collect (fun (key, keySpace) -> keySpace.jsonSinsigns )
        }
    member this.heterogenousEffectiveKeys = 
            this.heterogenousKeySubspaces  |> Array.map (fun (effectiveKey, _) -> effectiveKey)



type IRequest with 
    member this.DomUrl = DomUrl this.Url 
    member this.headers = this.Headers |> Seq.map (fun kvp -> kvp.Key, kvp.Value) |> Seq.toArray
    member this.header (targetHeader:string) = this.headers  |> Array.tryPick (fun (headerKey,headerValue) -> if headerKey = targetHeader then Some headerValue else None)
    member this.PostText  = 
        if this.HasPostData then 
            Some this.PostData
        else 
            None

    member this.PostJsonText(parentDirectory:DirectoryInfo)(pathNamer:DomUrl -> string)  = 
        try 
            match this.PostText with 
            | Some text when not (String.IsNullOrWhiteSpace text) ->
                    match text with 
                    | """{"status":500,"error":"Internal Server Error"}"""
                    | "[]"
                    | "null" -> None 
                    | _ -> 
                                Some {
                                    jsonFile = Path.Combine(parentDirectory.FullName,  pathNamer this.DomUrl)  |> FileInfo 
                                    jsonText = JsonValue.Parse text |> string
                                }
            | _ -> None
            
        with 
        | err -> 
            logLines.Add(sprintf "response %s %A threw %s" this.Url this.headers err.Message)
            None

type IResponse with 
    member this.DomUrl = DomUrl this.Url 
    member this.headers = this.Headers |> Seq.map (fun kvp -> kvp.Key, kvp.Value) |> Seq.toArray
    member this.header (targetHeader:string) = this.headers  |> Array.tryPick (fun (headerKey,headerValue) -> if headerKey = targetHeader then Some headerValue else None)
    member this.Text()  = 
        try 
            task { return! this.TextAsync() } |> force |> Some
        with 
        | err -> 
            logLines.Add(sprintf "request %s %A threw %s" this.Url this.headers err.Message)
            None

    member this.JsonText(parentDirectory:DirectoryInfo)(fileNamer:DomUrl -> string)  = 
        try 
            match this.Text() with 
            | Some text when not (String.IsNullOrWhiteSpace text) ->
                    match text with 
                    | """{"status":500,"error":"Internal Server Error"}"""
                    | "[]"
                    | "null" -> None 
                    | _ -> 
                                Some {
                                    jsonFile = FilePath.Sanitize( Path.Combine(parentDirectory.FullName,  fileNamer this.DomUrl) ) |> FileInfo 
                                    jsonText = JsonValue.Parse text |> string
                                }
            | _ -> None
            
        with 
        | err -> 
            logLines.Add(sprintf "response %s %A threw %s" this.Url this.headers err.Message)
            None



type FileInfo with 
    member this.Stem = this.Name[0..this.Name.Length - this.Extension.Length - 1]




type DomUrl with 


    member this.metadata = this.Origin + this.Pathname + "/metadata" + this.Search |> DomUrl
    member this.json = this.Origin + this.Pathname + ".json" + this.Search |> DomUrl
    member this.xml = this.Origin + this.Pathname + ".xml" + this.Search |> DomUrl
    member this.jsonhtml = this.Origin + this.Pathname + ".jsonhtml" + this.Search |> DomUrl
    member this.AppendPath(path:string) = Path.Combine(this.Origin + this.pathName, path.TrimStart('/')) + this.Search |> DomUrl
    member this.AppendSegments(segments:string list) = 
        let absolutePath = 
            List.concat [
                [this.Origin + this.Pathname]
                segments
            ]
            |> String.concat "/"
        absolutePath + this.Search |> DomUrl


    static member AddQueryParameter (key:string) value (url:DomUrl) = new DomUrl(QueryStringUtilities.AddQueryString(url.asString, key, string value) )
    static member UpsertQueryParameter(key:string) value (url:DomUrl)= QueryStringUtilities.AddOrReplaceQueryString(url.asString, key, string value) |> DomUrl
    static member RemoveQueryParameter (key:string) (url:DomUrl)= QueryStringUtilities.AddQueryString(url.asString, key, null) |> DomUrl
    member this.pathName = this.Pathname[1..]
    member this.extension = Path.GetExtension this.pathName
    member this.pathStem = Path.GetFileNameWithoutExtension this.pathName
    member this.relativeStem = 
                match this.pathStem with 
                | pathStem when this.pathStem.Contains('/') -> pathStem
                | pathStem -> Path.Combine(pathStem,  pathStem)

    member this.asString = this.ToString()
    member this.Query = QueryStringUtilities.ParseQuery this.Search |> Seq.map (fun keyValue ->  keyValue.Key, keyValue.Value |> Seq.toArray) |> Seq.toArray |> Array.sortBy (fun (key,values) -> key)
    member this.QueryKeyValues (parameter:string) = this.Query |> Array.tryFind (fun (key, values) -> key = parameter)
    member this.QueryKeyValue (parameter:string) = this.QueryKeyValues parameter |> Option.map (fun (key, values) -> key, values |> Array.exactlyOne)



let responses = new ResizeArray<IResponse>()
let finishedRequests = new ResizeArray<IRequest>()
let failedRequests = new ResizeArray<IRequest>()

// TODO next test query string paths
let queryStringPath  (url:DomUrl) (extension:string) = 
    let path = 
        Array.concat [|
            [|url.pathStem|]
            url.Query |> Array.collect (fun (key,value)-> Array.concat [| [|key|] ; value|])
            |] 
            |> Array.map FilePath.Sanitize
            |> String.concat "\\"
    Path.Combine(path, $"{url.pathStem}.{extension}")
        
        
let writeResponseToDirectory (directory:DirectoryInfo) (response:IResponse) (extension:string) = 
    match response.Text() with 
    | Some text -> 
        let file = FilePath.Sanitize( Path.Combine(directory.FullName,  queryStringPath response.DomUrl extension  ) ) |> FileInfo 
        Directory.CreateDirectory file.Directory.FullName |> ignore
        printfn "%s\t\t%s%s -----> %s"  response.DomUrl.Host response.DomUrl.pathName (response.DomUrl.Search.Truncate(100)) file.FullName[directory.FullName.Length + 1 ..]
        File.WriteAllText(file.FullName, text)
    | None -> ()

let networkMailbox =
    MailboxProcessor<IRequest>.Start(fun inbox ->
        let rec loop () =
            async {
                let! request = inbox.Receive()
                match request.Response.Status with 
                | HttpStatusCode.OK ->

                    
                    finishedRequests.Add request
                    match request.Response.DomUrl.Host, request.Response.DomUrl.pathName with
                    | "leoncountyfl.samanage.com", pathName when pathName.EndsWith ".json"-> writeResponseToDirectory Folder.SolarWinds request.Response "json"
                    | "leoncountyfl.samanage.com", pathName when pathName.EndsWith ".jsonhtml"-> writeResponseToDirectory Folder.SolarWinds request.Response "jsonhtml"
                    | "leoncountyfl.samanage.com", pathName when pathName.EndsWith ".xml"-> writeResponseToDirectory Folder.SolarWinds request.Response "xml"
                    | "unifiedweb-api.neogov.com", pathName when pathName.EndsWith "employees"-> writeResponseToDirectory Folder.NeoGov request.Response "json"
                    | "unifiedweb-api.neogov.com", pathName when pathName.EndsWith "customWindowProperties"-> writeResponseToDirectory Folder.NeoGov request.Response "json"
                    | "unifiedweb-api.neogov.com", pathName when pathName.EndsWith "orgChartView"-> writeResponseToDirectory Folder.NeoGov request.Response "json"
                    | "unifiedweb-api.neogov.com", pathName when pathName.EndsWith "directManager"-> writeResponseToDirectory Folder.NeoGov request.Response "json"
                    | "unifiedweb-api.neogov.com", pathName when pathName.EndsWith "user-profile"-> writeResponseToDirectory Folder.NeoGov request.Response "json"
                    | "content.centene.com", pathName when pathName.EndsWith ".json"-> writeResponseToDirectory Folder.SunshineHealth request.Response "json"
                    | "my.centene.com", pathName when pathName.EndsWith ".json"-> writeResponseToDirectory Folder.SunshineHealth request.Response "json"
                    | "app.securiti.ai", "core/v1/utils/geo/location" -> writeResponseToDirectory Folder.SunshineHealth request.Response "json"
                    | "smetrics.sunshinehealth.com", "ee/va6/v1/interact" -> writeResponseToDirectory Folder.SunshineHealth request.Response "json"
                    | "external-api.search.my.centene.com", "productmapping/v2/v2/query" -> writeResponseToDirectory Folder.SunshineHealth request.Response "json"
                    | "siteintercept.qualtrics.com", pathName when pathName.EndsWith("php") -> writeResponseToDirectory Folder.SunshineHealth request.Response "json"
                    

                         
                    | _ -> ()
                | _ -> failedRequests.Add request
                return! loop ()
            }

        loop ()
    )




type IBrowser with 
    member this.NewForegroundTab() = 
            let page = task {  return! this.NewPageAsync() } |> force
            page.RequestFinished.Add(fun eventArguments -> networkMailbox.Post eventArguments.Request)
            page

    member this.NewBackgroundTab() =
        task {
                let inBackground = CreatePageOptions()
                inBackground.Background <- Nullable<bool>(true)

                let! page = this.NewPageAsync(inBackground)
                page.RequestFinished.Add(fun eventArguments -> networkMailbox.Post eventArguments.Request)


                return page
            }


let browser : IBrowser = task { return! Puppeteer.ConnectAsync(connectOptions) } |> force




type Fss.Types.Selector with 
    member this.universalCommon : Css.Selectors.SimpleSelector = 
        match this with 
        | Fss.Types.Selector.Tag selectedTag -> Css.Selectors.TypeSelector (selectedTag.Stringify())
        | Fss.Types.Selector.Class selectedClass -> Css.Selectors.ClassSelector(selectedClass.ToString())
        | Fss.Types.Selector.Id selectedId -> Css.Selectors.IdSelector(selectedId)
type Fss.Types.Html.Html with 
    member this.universalCommon : Css.Selectors.SimpleSelector  = Css.Selectors.TypeSelector (this.Stringify())
type Fss.Types.Attribute.Attribute with 
    member this.asCssValue : Fss.Types.ICssValue = this 
    member this.universalCommon :Css.Selectors.SimpleSelector = Css.Selectors.AttributeSelector(this.asCssValue.StringifyCss())
type Selector =  
    | SimpleSelector of SimpleSelector
    | CompoundSelector of SimpleSelector array
    member this.asString = 
        match this with 
        | SimpleSelector simpleSelector -> simpleSelector.universalCommon.ToString()
        | CompoundSelector simpleSelectors -> 
            simpleSelectors
            |> Array.map (fun simpleSelector -> simpleSelector.universalCommon)
            |> Css.Selectors.CompoundSelector
            |> _.ToString()

and SimpleSelector = 
    | TypeSelector of Fss.Types.Html.Html
    | AttributeSelector of Fss.Types.Attribute.Attribute
    | ClassSelector of string
    | IDSelector of string
    // | UniversalSelector of Css.Selectors.UniversalSelector
    // | PseudoClass of Css.Selectors.PseudoClassSelector
    member this.universalCommon :Css.Selectors.SimpleSelector = 
        match this with 
        | TypeSelector htmlTag -> htmlTag.universalCommon
        | AttributeSelector htmlAttribute -> htmlAttribute.universalCommon
        | ClassSelector classString -> Css.Selectors.ClassSelector(classString)
        | IDSelector idString -> Css.Selectors.IdSelector(idString)


module Selector =

    let element
        (tag: FssTag)
        =
        CompoundSelector
            [|
                TypeSelector tag
            |]

    let elementWithTagAttribute
        (tag: FssTag)
        (attribute: FssAttribute)
        =

        CompoundSelector
            [|
                TypeSelector tag
                AttributeSelector attribute
            |]


type Fss.Types.Attribute.Attribute with

    member this.cssName =
        this.asCssValue.StringifyCss()
















let (=>)
    (parameterName: string)
    (body: JavaScript.Syntax.Expression -> JavaScript.Syntax.Expression)
    =
    let parameter =
        JavaScript.Syntax.Id.New parameterName

    let parameterExpression =
        JavaScript.Syntax.Var parameter

    JavaScript.Syntax.Lambda(
        None,
        [ parameter ],
        [
            JavaScript.Syntax.Return(
                Some (body parameterExpression)
            )
        ],
        true
    )
let javascript expression =
    JavaScript.Writer.ExpressionToString
        JavaScript.Preferences.Readable
        expression





type IElementHandle with 
    member this.outerHTML =
        task {
            return!
                this.EvaluateFunctionAsync<string>(
                        javascript(
                                "element" => fun element -> element?outerHTML
                                )
                        )
          }
          |> force
          |> HtmlNode.Parse
        
    member this.Click() = task { do! this.ClickAsync() } |> force
    member this.ScrollIntoView() = task { do! this.ScrollIntoViewAsync() } |> force

    member this.EnterText(text:string) =
        task { 
                do! this.ClickAsync()
                do! this.TypeAsync(text)
            } |> force
    member this.Type(text:string) = task { do! this.TypeAsync(text) } |> force
    member this.InnerText() = task { return! this.InnerTextAsync() } |> force

type IPage with
    member this.ScrollToBottom() = task { return! this.EvaluateFunctionAsync( "() => window.scrollTo(0, document.documentElement.scrollHeight)" ) } |> force
    member this.ScrollDown(pixels: int) = task { return! this.EvaluateFunctionAsync( "(pixels) => window.scrollBy(0, pixels)", pixels ) } |> force

    member this.ScrollUp(pixels: int) = task { return! this.EvaluateFunctionAsync( "(pixels) => window.scrollBy(0, -pixels)", pixels ) } |> force
    member this.WaitForSelector (selector : Selector) = task { return! this.WaitForSelectorAsync( selector.asString ) }  |> force
    member this.SetTabName(name: string) =
        task {
            return!
                this.EvaluateFunctionAsync<string>(
                    "name => document.title = name",
                    name
                )
        }
    member this.GoToAsync (url:DomUrl) = task { return! this.GoToAsync(url.Href) } 
    member this.GoTo (url:DomUrl) = task { return! this.GoToAsync(url.Href) } |> force
    member this.GoBack() = task { return! this.GoBackAsync() } |> force
    member this.GoForward() = task { return! this.GoForwardAsync() } |> force
    member this.Click (selector:Selector) =  task { do! this.Locator( selector.asString).ClickAsync() } |> force
    member this.QuerySelectorAll (selector:Selector) = 
        task { return! this.QuerySelectorAllAsync(selector.asString) } |> force

    member this.elementsWhereNode
        (selector: Selector)
        predicate
        =
        selector
        |> this.QuerySelectorAll
        |> Array.filter (fun element ->
            element.outerHTML
            |> List.exists predicate
        )

    member this.elements
        (tag: FssTag)
        =
        Selector.element tag
        |> this.QuerySelectorAll

    member this.elementsWithTagAttribute
        (tag: FssTag)
        (attribute: FssAttribute)
        =
        Selector.elementWithTagAttribute tag attribute
        |> this.QuerySelectorAll

    member this.elementsByTagInnerText
        (tag: FssTag)
        (text: string)
        =
        let expected =
            text.Trim()

        this.elementsWhereNode
            (Selector.element tag)
            (fun node ->
                node.InnerText().Trim() = expected
            )

    member this.elementByTagInnerText
        (tag: FssTag)
        (text: string)
        = this.elementsByTagInnerText tag text |> Array.exactlyOne


    member this.elementsByTagAttributeValue
        (tag: FssTag)
        (attribute: FssAttribute)
        (value: string)
        =
        let selector = Selector.elementWithTagAttribute tag attribute
        this.elementsWhereNode
            selector
            (fun node ->
                node.HasAttribute(
                    attribute.cssName,
                    value
                )
            )
    member this.elementsByAttributeValue
        (attribute: FssAttribute)
        (value: string)
        =
        let selector = AttributeSelector attribute |> SimpleSelector
        this.elementsWhereNode
            selector
            (fun node ->
                node.HasAttribute(
                    attribute.cssName,
                    value
                )
            )
    member this.elementByAttributeValue
        (attribute: FssAttribute)
        (value: string)
        = this.elementsByAttributeValue attribute value |> Array.exactlyOne

    member this.elementByTagAttributeValue
        (tag: FssTag)
        (attribute: FssAttribute)
        (value: string)
        = this.elementsByTagAttributeValue tag attribute value |> Array.exactlyOne

    member this.anchorElements =
        this.elementsWithTagAttribute
            FssTag.A
            FssAttribute.Href

    member this.anchorsByText
        (text: string)
        =
        this.elementsWhereNode
            (
                Selector.elementWithTagAttribute
                    FssTag.A
                    FssAttribute.Href
            )
            (fun node ->
                node.InnerText() = text
            )

    member this.buttonElements =
        this.elements FssTag.Button

    member this.buttonsByValue
        (value: string)
        =
        this.elementsByTagAttributeValue
            FssTag.Button
            FssAttribute.Value
            value


type Type with 
    member this.asJsonSchema =  Generator.Create typeof<'Type>.Name  typeof<'Type>


type DateTime with 
    member this.lastWeek = this.AddDays(-7)
    member this.IsoWeekNumber = sprintf "%d-W%d" this.Year (ISOWeek.GetWeekOfYear this)




// -----------------------------------------------------------------------------
// Naming / domain policy
// -----------------------------------------------------------------------------





/// Domain-specific refinements.
///
/// These are deliberately separate from JSON-Schema structural interpretation.
/// The schema tells us "string"; this policy may refine that to DateTime,
/// DomUrl, State, etc.
let domainValueType (fieldName: string) =
    match fieldName with
    | _ when fieldName.EndsWith("_at") -> Some "DateTime" 
    | _ when fieldName.StartsWith("href") -> Some "DomUrl" 
    | "created_by" -> Some "User"
    | "resolved_by" -> Some "Assignee"
    | "reports_to" -> Some "Account"
    | "custom_fields_values" -> Some "string" 
    | "state" -> Some "State" 
    | "priority" -> Some "Priority" 
    | "origin" -> Some "Origin" 
    | "description" -> Some "HtmlNode list" 
    | "resolution_code" -> Some "ResolutionCode" 
    | _ -> None



let astTypeName (fieldName: string) = 
    match domainValueType fieldName with 
    | Some domainType -> Converters.ToPascalCase domainType 
    | None -> Converters.ToPascalCase fieldName
type JsonSchema with

    /// JsonObjectType is a flags enum.
    ///
    /// This therefore answers:
    ///
    ///     "Does this schema admit values of this JSON primitive type?"
    ///
    /// rather than treating Type.ToString() as a discriminated-union case.
    member this.hasType(jsonType: JsonObjectType) =
        this.Type.HasFlag(jsonType)


    member this.anyOf =
        this.AnyOf
        |> Seq.map (fun schema ->
            schema.ActualSchema)
        |> Seq.toArray


    member this.oneOf =
        this.OneOf
        |> Seq.map (fun schema ->
            schema.ActualSchema)
        |> Seq.toArray


    /// All explicit alternatives except null.
    member this.nonNullAlternatives =
        Array.concat [|
            this.anyOf
            this.oneOf
        |]
        |> Array.filter (fun schema ->
            not (schema.hasType JsonObjectType.Null))


    /// Whether null is admitted by the schema.
    ///
    /// Handles both:
    ///
    ///     "type": ["string", "null"]
    ///
    /// and:
    ///
    ///     "anyOf": [
    ///         { "type": "string" },
    ///         { "type": "null" }
    ///     ]
    member this.acceptsNull =
        this.hasType JsonObjectType.Null
        ||
        Array.concat [|
            this.anyOf
            this.oneOf
        |]
        |> Array.exists (fun schema ->
            schema.hasType JsonObjectType.Null)


    /// If NJsonSchema represents:
    ///
    ///     anyOf [
    ///         null
    ///         object
    ///     ]
    ///
    /// the outer schema often has Type = None.
    ///
    /// For F# value-type generation we generally want the one non-null schema.
    member this.nonNullValueSchema =
        let actual =
            this.ActualSchema

        match actual.Type, actual.nonNullAlternatives with
        | JsonObjectType.None, [| single |] ->
            single.ActualSchema

        | _ ->
            actual


    /// Obtain an array's homogeneous item schema without relying on exceptions.
    member this.arrayItem =
        if isNull this.Item then
            None
        else
            Some this.Item.ActualSchema


    /// Represents the unconstrained JSON Schema `{}` case.
    ///
    /// This is distinct from an ordinary object schema.
    member this.isUnconstrained =
        let actual =
            this.ActualSchema

        actual.Type = JsonObjectType.None
        && actual.AnyOf.Count = 0
        && actual.OneOf.Count = 0
        && actual.AllOf.Count = 0
        && not actual.HasActualProperties
        && not actual.IsEnumeration
        && isNull actual.AdditionalPropertiesSchema


    /// Object properties represented by this schema.
    ///
    /// ActualProperties already handles direct properties and properties
    /// contributed through allOf. We additionally inspect object-shaped
    /// anyOf/oneOf alternatives because GenSON commonly expresses nullability
    /// through those combinators.
    member this.schemaProperties : JsonSchemaProperty array =
        let actual =
            this.ActualSchema

        let directProperties =
            actual.ActualProperties
            |> Seq.map (fun property ->
                property.Value)
            |> Seq.toArray

        let alternativeProperties =
            actual.nonNullAlternatives
            |> Array.collect (fun alternative ->
                alternative.schemaProperties)

        Array.append
            directProperties
            alternativeProperties
        |> Array.distinctBy (fun property ->
            property.Name)


    /// Properties we currently elect to materialize into generated F#.
    ///
    /// This is intentionally a generation policy layered over schemaProperties.
    /// schemaProperties itself does not erase schema information.
    member this.codegenProperties =
        this.schemaProperties
        |> Array.filter (fun property ->

            match property.Name with

            // Explicit domain exclusion.
            | "incidents" ->
                false

            | _ ->
                let schema =
                    property.ActualSchema

                // A property whose only possible value is null provides no
                // useful F# value domain for the current model.
                if schema.Type = JsonObjectType.Null then
                    false

                // Do not generate completely unconstrained arrays such as:
                //
                //     "items": {}
                //
                // Primitive arrays such as int[] are NOT removed.
                elif schema.hasType JsonObjectType.Array then
                    match schema.arrayItem with
                    | None ->
                        false

                    | Some item ->
                        not item.isUnconstrained

                else
                    true)


    /// Map the VALUE DOMAIN of a JSON schema to an F# type.
    ///
    /// This does not decide whether a record FIELD should be optional.
    /// Optionality belongs to JsonSchemaProperty below.
    member this.astValueType(fieldName: string) =

        match domainValueType fieldName with

        // Domain-specific semantic refinement wins over generic structural
        // mapping.
        | Some fieldType ->
            fieldType

        | None ->
            let schema =
                this.nonNullValueSchema

            if schema.hasType JsonObjectType.Boolean then
                "bool"

            elif schema.hasType JsonObjectType.Integer then
                "int"

            elif schema.hasType JsonObjectType.Number then
                "float"

            elif schema.hasType JsonObjectType.String then
                "string"

            elif schema.hasType JsonObjectType.Object
                 || schema.HasActualProperties then

                astTypeName fieldName

            elif schema.hasType JsonObjectType.Array then

                match schema.arrayItem with

                | None ->
                    "obj array"

                | Some item ->

                    let itemName =
                        fieldName.Singularize()

                    let itemValueType =
                        item.astValueType itemName

                    let itemType =
                        match fieldName, itemValueType with 
                        | _, _ when  item.acceptsNull -> $"{itemValueType} option"
                        | _, _ -> itemValueType

                    $"{itemType} array"

            elif schema.isUnconstrained then
                "obj"

            else
                // Deliberately conspicuous fallback.
                //
                // This is preferable to silently inventing an F# model for a
                // schema construct we have not yet mapped.
                "obj"




type JsonSchemaProperty with

    /// The property's underlying value type before accounting for whether
    /// the property itself can be missing/null.
    member this.astValueType =
        this.ActualSchema.astValueType this.Name


    /// There are two independent reasons an F# field needs option:
    ///
    /// 1. the JSON property may be absent;
    /// 2. the JSON value may explicitly be null.
    member this.isOptional =
        not this.IsRequired
        || this.ActualSchema.acceptsNull


    member this.astFieldType =
        match this.Name,  this.astValueType with 
        | "description", "HtmlNode list" -> "HtmlNode list"
        | _, valueType when this.isOptional -> $"{valueType} option"
        | _, valueType -> valueType


    member this.astField =
        Ast.Field(
            this.Name,
            this.astFieldType
        )
























































































[<RequireQualifiedAccess>]
type SolarWindsContext = 
    | asset_links
    | attachments
    | audits
    | catalog_items
    | categories
    | change_catalogs
    | changes
    | configuration_items
    | contracts
    | departments
    | groups
    | hardwares
    | incidents
    | memberships
    | mobiles
    | other_assets
    | printers
    | problems
    | purchase_orders
    | releases
    | risks
    | roles
    | sites
    | softwares
    | solutions
    | tasks
    | users
    | vendors

    static member all = 
        [|
            asset_links
            attachments
            audits
            catalog_items
            categories
            change_catalogs
            changes
            configuration_items
            contracts
            departments
            groups
            hardwares
            incidents
            memberships
            mobiles
            other_assets
            printers
            problems
            purchase_orders
            releases
            risks
            roles
            sites
            softwares
            solutions
            tasks
            users
            vendors
        |]
    member this.asString = this.ToString()
    member this.asSingularString = this.asString.Singularize()
    



type IncidentsJsonHtmlProvider = JsonProvider< UseOriginalNames = true, PreferDateOnly = true, OmitNullFields = true,
    RootName = "incidents",
    Sample =  @"D:\Artifact\Company\SolarWinds\_samples\incidents.jsonhtml" >
type PagedIncidentProvider = JsonProvider< UseOriginalNames = true, PreferDateOnly = true, OmitNullFields = true,
    RootName = "incident",
    Sample =  @"D:\Artifact\Company\SolarWinds\_samples\pagedIncident.json" >

type ServiceMonitorStatisticProvider = JsonProvider< UseOriginalNames = true, PreferDateOnly = true, OmitNullFields = true,
    RootName = "service_monitor_statistic",
    Sample = @"D:\Artifact\Company\SolarWinds\_samples\service_monitor_statistic.json" >
type IncidentProvider = JsonProvider< UseOriginalNames = true, PreferDateOnly = true, OmitNullFields = true,
    RootName = "incident",
    Sample = @"D:\Artifact\Company\SolarWinds\_samples\174995569.json" >
type CommentsProvider = JsonProvider<UseOriginalNames = true, PreferDateOnly = true, OmitNullFields = true,
    RootName = "comments",
    Sample = @"D:\Artifact\Company\SolarWinds\_samples\comments.json">
type RelatedItemsProvider = JsonProvider<UseOriginalNames = true, PreferDateOnly = true, OmitNullFields = true,
    RootName = "related_items",
    Sample = @"D:\Artifact\Company\SolarWinds\_samples\related_items.json">
type SolarWindsProfileProvider = JsonProvider<UseOriginalNames = true, PreferDateOnly = true, OmitNullFields = true,
    RootName = "profile",
    Sample = @"D:\Artifact\Company\SolarWinds\_samples\profile.json">

type NeoGovEmployeesProvider = JsonProvider<UseOriginalNames = true, PreferDateOnly = true, OmitNullFields = true,
    RootName = "employees",
    Sample = @"D:\Artifact\Company\NeoGov\_samples\employees.json">


[<Literal>]
let carrierEntitiesFilePath = @"D:\Artifact\Company\SunshineHealth\query\results.json"
type CarrierEntityProvider = JsonProvider<UseOriginalNames = true, PreferDateOnly = true, OmitNullFields = true,
    RootName = "results",
    SampleIsList = true,
    Sample = carrierEntitiesFilePath>


[<RequireQualifiedAccess>]
type JsonoidPropertySet = 
    | All
    | Min
    | Simple
    member this.asString = this.ToString()




[<RequireQualifiedAccess>]
type StateKind =
    | Assigned
    | AwaitingApproval
    | AwaitingDelivery
    | AwaitingEffectiveDate
    | AwaitingInputTech
    | AwaitingInputUser
    | AwaitingInputVendor
    | AwaitingQuote
    | CanceledByRequester
    | Closed
    | InProcess
    | New
    | OnHold
    | PendingAssignment
    | ProjectProactive
    | PurchaseInProcess
    | ResearchRequired
    | Resolved
    | ScheduledCheckDueDate
    | UnderReview
    | Unknown of string
    static member fromTitle (title:string) = 
        match title with 
        | "Assigned" -> StateKind.Assigned
        | "Awaiting Approval" -> StateKind.AwaitingApproval
        | "Awaiting Delivery" -> StateKind.AwaitingDelivery
        | "Awaiting Effective Date" -> StateKind.AwaitingEffectiveDate
        | "Awaiting Input - Tech" -> StateKind.AwaitingInputTech
        | "Awaiting Input - User" -> StateKind.AwaitingInputUser
        | "Awaiting Input - Vendor" -> StateKind.AwaitingInputVendor
        | "Awaiting Quote" -> StateKind.AwaitingQuote
        | "Canceled by Requester" -> StateKind.CanceledByRequester
        | "Closed" -> StateKind.Closed
        | "In Process" -> StateKind.InProcess
        | "New" -> StateKind.New
        | "On Hold" -> StateKind.OnHold
        | "Pending Assignment" -> StateKind.PendingAssignment
        | "Project - Proactive" -> StateKind.ProjectProactive
        | "Purchase in Process" -> StateKind.PurchaseInProcess
        | "Research Required" -> StateKind.ResearchRequired
        | "Resolved" -> StateKind.Resolved
        | "Scheduled-Check Due Date" -> StateKind.ScheduledCheckDueDate
        | "Under Review" -> StateKind.UnderReview
        | _ -> StateKind.Unknown title
    member this.asString= 
        match this with 
        | StateKind.Assigned ->  "Assigned" 
        | StateKind.AwaitingApproval ->  "Awaiting Approval" 
        | StateKind.AwaitingDelivery ->  "Awaiting Delivery" 
        | StateKind.AwaitingEffectiveDate ->  "Awaiting Effective Date" 
        | StateKind.AwaitingInputTech ->  "Awaiting Input - Tech" 
        | StateKind.AwaitingInputUser ->  "Awaiting Input - User" 
        | StateKind.AwaitingInputVendor ->  "Awaiting Input - Vendor" 
        | StateKind.AwaitingQuote ->  "Awaiting Quote" 
        | StateKind.CanceledByRequester ->  "Canceled by Requester" 
        | StateKind.Closed ->  "Closed" 
        | StateKind.InProcess ->  "In Process" 
        | StateKind.New ->  "New" 
        | StateKind.OnHold ->  "On Hold" 
        | StateKind.PendingAssignment ->  "Pending Assignment" 
        | StateKind.ProjectProactive ->  "Project - Proactive" 
        | StateKind.PurchaseInProcess ->  "Purchase in Process" 
        | StateKind.ResearchRequired ->  "Research Required" 
        | StateKind.Resolved ->  "Resolved" 
        | StateKind.ScheduledCheckDueDate ->  "Scheduled-Check Due Date" 
        | StateKind.UnderReview ->  "Under Review" 
        | StateKind.Unknown title -> title



type IncidentState = 
    {
        id:int
        kind:StateKind
        title:string
        startTime:DateTimeOffset
        endTime:DateTimeOffset
        timeSpent:int
        timeSpentBH:int
        timeSinceCreation:int
        timeSinceCreationBH:int
        isCurrent:bool
        isDeleted:bool
    }
type IncidentStateSpace = 
    {
        incidentStates :IncidentState array
    }
    member this.current  = this.incidentStates |> Array.find (fun state -> state.isCurrent)
    member this.subspaceByKind(kind:StateKind) = 
        {
            incidentStates = this.incidentStates |> Array.filter (fun state -> state.kind = kind)
        }
    member this.isKindByDaysAgo (kind:StateKind)(days:int) = 
        match this.incidentStates with 
        | [||] -> false
        | _ -> 
            let kindSubspace = this.subspaceByKind  kind
            match kindSubspace.incidentStates with 
            | [||] -> false
            | states -> 
                let lastState = states |> Array.last
                let daysAgo = 
                    if days > 0 then 
                        days * -1
                    else 
                        days
                lastState.startTime > DateTimeOffset.Now.AddDays(daysAgo)






(*
// TODO look into adapting openapi specification
// TODO implement patterns documented here 
    // https://thwack.solarwinds.com/discussion/151176/api-for-fetching-the-custom-and-system-fields-meta-for-entities
module https = 
    module leoncountyfl = 
        module samanage = 
            module com =
                let PaginatedUrl (url:DomUrl) = 
                                url
                                |> DomUrl.AddQueryParameter "page" 1
                                |> DomUrl.AddQueryParameter "per_page" 100
                                |> DomUrl.AddQueryParameter "no_me" true
                                |> DomUrl.AddQueryParameter "is_portal_mode" false
                module filters = 
                    let url (context:SolarWindsContext) = DomUrl "https://leoncountyfl.samanage.com/filters.json" |> DomUrl.AddQueryParameter "context" context.asString
                module websockets = 
                    module jwt = 
                        let url = DomUrl "https://leoncountyfl.samanage.com/websockets/jwt" |> DomUrl.AddQueryParameter "is_portal_mode" false

                module api = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/api"
                
                module hardwares = 
                        let url = DomUrl "https://leoncountyfl.samanage.com/hardwares"
                        module by = 
                            module page = 
                                    let url (index:int ) = DomUrl "https://leoncountyfl.samanage.com/hardwares" |> DomUrl.AddQueryParameter "page" index
                        let page1 = by.page.url 1

                module incidents = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/incidents"
                    module by = 
                        module page =
                            let url  (index:int) = DomUrl "https://leoncountyfl.samanage.com/incidents" |> DomUrl.AddQueryParameter "page" index
                        module id = 
                            let url (id:int) = DomUrl $"https://leoncountyfl.samanage.com/incidents/{id}"

                            module service_monitor_statistic = 
                                let url (id:int) = DomUrl $"https://leoncountyfl.samanage.com/incidents/{id}/service_monitor_statistic" |> DomUrl.AddQueryParameter "is_portal_mode" false
                            module comments = 
                                let url (id:int) = DomUrl $"https://leoncountyfl.samanage.com/incidents/{id}/comments" |> DomUrl.AddQueryParameter "unmasked" false |> DomUrl.AddQueryParameter "is_portal_mode" false
                            module response_template_variables = 
                                let url (id:int) = DomUrl $"https://leoncountyfl.samanage.com/incidents/{id}/response_template_variables" |> DomUrl.AddQueryParameter "is_portal_mode" false
                            module related_itsms = 
                                module related_items = 
                                    let url (id:int) = 
                                                DomUrl $"https://leoncountyfl.samanage.com/incidents/{id}/related_itsms/related_items"
                                                |> DomUrl.AddQueryParameter "collections[]" "incidents"
                                                |> DomUrl.AddQueryParameter "collections[]" "problems"
                                                |> DomUrl.AddQueryParameter "collections[]" "changes"
                                                |> DomUrl.AddQueryParameter "collections[]" "releases"
                                                |> DomUrl.AddQueryParameter "collections[]" "hardwares"
                                                |> DomUrl.AddQueryParameter "collections[]" "mobiles"
                                                |> DomUrl.AddQueryParameter "collections[]" "other_assets"
                                                |> DomUrl.AddQueryParameter "collections[]" "discovery_hardwares"
                                                |> DomUrl.AddQueryParameter "collections[]" "configuration_items"
                                                |> DomUrl.AddQueryParameter "collections[]" "solutions"
                                                |> DomUrl.AddQueryParameter "collections[]" "purchase_orders"
                                                |> DomUrl.AddQueryParameter "is_portal_mode" false
                                module list' = 
                                    let url (id:int) = 
                                                DomUrl $"https://leoncountyfl.samanage.com/incidents/{id}/related_itsms/list"
                                                |> DomUrl.AddQueryParameter "object_type" "incident"
                                                |> DomUrl.AddQueryParameter "is_portal_mode" false
                    let page1 = by.page.url 1


                module risks = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/risks"
                module contracts = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/contracts"
                module softwares = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/softwares"
                    module by = 
                        module page = 
                            let url (index:int ) = DomUrl "https://leoncountyfl.samanage.com/softwares" |> DomUrl.AddQueryParameter "page" index
                    let page1 = by.page.url 1
                module other_assets = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/other_assets"
                module vendors = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/vendors"
                module printers = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/printers"
                module audits = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/audits"
                module users = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/users"
                    module user_list = 
                        let url = DomUrl "https://leoncountyfl.samanage.com/users/user_list"
                module problems = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/problems"
                module changes = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/changes"
                module releases = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/releases"
                module solutions = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/solutions"
                module catalog_items = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/catalog_items"
                module departments = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/departments" |> PaginatedUrl
                module sites = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/sites"
                module groups = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/groups"
                    module group_list = 
                        let url = DomUrl "https://leoncountyfl.samanage.com/groups/group_list" |> PaginatedUrl
                        let assignees = url |> DomUrl.AddQueryParameter "staff" true
                module mobiles = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/mobiles"
                module roles = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/roles"
                module categories = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/categories"
                module change_catalogs = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/change_catalogs"
                module configuration_items = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/configuration_items"
                module purchase_orders = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/purchase_orders"
                module login = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/login"
                module default_landing_page = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/default_landing_page"
                module notifications = 
                    module unseen_count = 
                        let url = DomUrl "https://leoncountyfl.samanage.com/notifications/unseen_count"
                module custom_views = 
                    module users = 
                        let url = DomUrl "https://leoncountyfl.samanage.com/custom_views/users"
                    module incidents = 
                        let url = DomUrl "https://leoncountyfl.samanage.com/custom_views/incidents"
                    module hardwares = 
                        let url = DomUrl "https://leoncountyfl.samanage.com/custom_views/hardwares"
                    module softwares = 
                        let url = DomUrl "https://leoncountyfl.samanage.com/custom_views/softwares"
                    module tasks = 
                        let url = DomUrl "https://leoncountyfl.samanage.com/custom_views/tasks"
                module reports = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/reports" |> DomUrl.AddQueryParameter "family_type" "all"
                module custom = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/custom" 
                    let context (context:SolarWindsContext) = DomUrl "https://leoncountyfl.samanage.com/custom"  |> DomUrl.AddQueryParameter "context" context.asString
                module dashboard = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/dashboard"
                module dashboards = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/dashboards"
                module incident_types = 
                    module types_list = 
                        let url = DomUrl "https://leoncountyfl.samanage.com/incident_types/types_list"
                    module sub_types_list = 
                        let url = DomUrl "https://leoncountyfl.samanage.com/incident_types/sub_types_list"
                module entity_general_info = 
                    let url (id:int)(context:SolarWindsContext) =
                            DomUrl $"https://leoncountyfl.samanage.com/entity_general_info/{id}"
                            |> DomUrl.AddQueryParameter "is_portal_mode" false
                module response_templates = 
                    module total_count = 
                        let url = DomUrl $"https://leoncountyfl.samanage.com/response_templates/total_count" |> DomUrl.AddQueryParameter "is_portal_mode" false


                    module total_count_personal =
                        let url =  DomUrl $"https://leoncountyfl.samanage.com/response_templates/total_count_personal" |> DomUrl.AddQueryParameter "is_portal_mode" false
                    module total_count_global =
                        let url =  DomUrl $"https://leoncountyfl.samanage.com/response_templates/total_count_global" |> DomUrl.AddQueryParameter "is_portal_mode" false
                module tasks = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/tasks" 
                    module all = 
                        let url = DomUrl "https://leoncountyfl.samanage.com/tasks" |> DomUrl.AddQueryParameter "report_id" 8992258
                    module by = 
                        module assignee = 
                            let url (id:int) = 
                                DomUrl "https://leoncountyfl.samanage.com/tasks"
                                |> DomUrl.AddQueryParameter "report_id" 8992258
                                |> DomUrl.AddQueryParameter "assigned_to" id
                            let me = url 10744815
                module setup = 
                    module users = 
                        let url = DomUrl "https://leoncountyfl.samanage.com/setup/users"
                module requesters = 
                    let url = DomUrl "https://leoncountyfl.samanage.com/requesters" |> PaginatedUrl
                module taggings = 
                    module tags_list = 
                        let url = DomUrl "https://leoncountyfl.samanage.com/taggings/tags_list"



open https.leoncountyfl.samanage.com

*)
let mainTab = browser.NewForegroundTab()



module SolarWindsServiceDesk = 
    module _header = 
        let current_page (url:DomUrl) (tab:IPage) = (tab.GoTo url).header "x-current-page"
        let content_type (url:DomUrl) (tab:IPage) = (tab.GoTo url).header "x-content-type"
        let link (url:DomUrl) (tab:IPage) = (tab.GoTo url).header "link"
        let total_pages (url:DomUrl) (tab:IPage) = (tab.GoTo url).header "x-total-pages" |> Option.map (fun pagesString -> int pagesString)
        let total_count (url:DomUrl) (tab:IPage) = (tab.GoTo url).header "x-total-count"|> Option.map (fun countString -> int countString)
    module _query =
        let per_page (url:DomUrl) (count:int)  = url |> DomUrl.AddQueryParameter "per_page" count  
        let updatedDaysAgo (url:DomUrl) (days:int)  = url |> DomUrl.AddQueryParameter "updated" days  
        let updatedHoursAgo (url:DomUrl) (hours:int)  = url |> DomUrl.AddQueryParameter "updated" (string hours + "h")  
        let updated_from (url:DomUrl) (dateTime:DateTime)  = url |> DomUrl.AddQueryParameter "updated_from" (dateTime.ToString("o"))  
        let updated_to (url:DomUrl) (dateTime:DateTime)  = url |> DomUrl.AddQueryParameter "updated_to" (dateTime.ToString("o"))  
        let created_from (url:DomUrl) (dateTime:DateTime)  = url |> DomUrl.AddQueryParameter "created_from" (dateTime.ToString("o"))  
        let created_to (url:DomUrl) (dateTime:DateTime)  = url |> DomUrl.AddQueryParameter "created_to" (dateTime.ToString("o"))  
        let assigned_to (url:DomUrl) (id:int)  = url |> DomUrl.AddQueryParameter "assigned_to" (string id)  
        let long (url:DomUrl)   = url |> DomUrl.UpsertQueryParameter "layout" "long"  
        let short (url:DomUrl)   = url |> DomUrl.UpsertQueryParameter "layout" "short"  
        let context (url:DomUrl)(context:SolarWindsContext)  = url |> DomUrl.AddQueryParameter "context" context.asString  
        let page (page:int) (url:DomUrl)  = url |> DomUrl.AddQueryParameter "page" page 

    let ServiceUrl = 
        DomUrl "https://leoncountyfl.samanage.com"
        |> DomUrl.AddQueryParameter "layout" "long"
        |> DomUrl.AddQueryParameter "is_portal_mode" false
    let jwt = ServiceUrl.AppendSegments [ "websockets" ; "jwt" ]
    let profile = ServiceUrl.AppendPath "profile"
    let unseen_count = ServiceUrl.AppendSegments [ "notification" ; "unseen_count" ]
    let timezone_data = ServiceUrl.AppendSegments [ "sites" ; "timezone_data" ]
    let ApiEntryPoint = ServiceUrl.AppendPath "api"
    let ComputersList = ServiceUrl.AppendPath "hardwares"
    let HelpdeskIncidentsList = ServiceUrl.AppendPath "incidents"
    let RisksList = ServiceUrl.AppendPath "risks"
    let ContractsList = ServiceUrl.AppendPath "contracts"
    let SoftwareList = ServiceUrl.AppendPath "softwares"
    let OtherAssetsList = ServiceUrl.AppendPath "other_assets"
    let VendorsList = ServiceUrl.AppendPath "vendors"
    let PrintersList = ServiceUrl.AppendPath "printers"
    let AuditLogList = ServiceUrl.AppendPath "audits"
    let UsersList = ServiceUrl.AppendPath "users"
    let ProblemsList = ServiceUrl.AppendPath "problems"
    let ChangesList = ServiceUrl.AppendPath "changes"
    let ReleasesList = ServiceUrl.AppendPath "releases"
    let SolutionsList = ServiceUrl.AppendPath "solutions"
    let CatalogItemsList = ServiceUrl.AppendPath "catalog_items"
    let DepartmentsList = ServiceUrl.AppendPath "departments"
    let SitesList = ServiceUrl.AppendPath "sites"
    let GroupsList = ServiceUrl.AppendPath "groups"
    let MobileDevicesList = ServiceUrl.AppendPath "mobiles"
    let RolesList = ServiceUrl.AppendPath "roles"
    let CategoriesList = ServiceUrl.AppendPath "categories"
    let ChangeCatalogsList = ServiceUrl.AppendPath "change_catalogs"
    let ConfigurationItemsList = ServiceUrl.AppendPath "configuration_items"
    let PurchaseOrdersList = ServiceUrl.AppendPath "purchase_orders"
    let userList = ServiceUrl.AppendSegments [ "users" ; "user_list" ]
    let groupList = ServiceUrl.AppendSegments [ "groups" ; "group_list" ]
    let reports = ServiceUrl.AppendPath "reports" |> DomUrl.AddQueryParameter "family_type" "all"
    let typesList = ServiceUrl.AppendSegments [ "incident_types" ; "types_list" ]
    let subTypesList = ServiceUrl.AppendSegments [ "incident_types" ; "sub_types_list" ]

    module response_templates = 
        let total_count = ServiceUrl.AppendSegments ["response_templates" ; "total_count" ] 
        let total_count_personal = ServiceUrl.AppendSegments ["response_templates" ; "total_count_personal" ] 
        let total_count_global = ServiceUrl.AppendSegments ["response_templates" ; "total_count_global" ] 
    module context = 
        let url (context:SolarWindsContext) = ServiceUrl.AppendPath context.asString
        let filters (context:SolarWindsContext) = ServiceUrl.AppendPath "filters" |>  DomUrl.AddQueryParameter "context" context.asString
        let custom (context:SolarWindsContext) = ServiceUrl.AppendPath "custom" |>  DomUrl.AddQueryParameter "context" context.asString
        let customViews (context:SolarWindsContext) = ServiceUrl.AppendPath "custom_views" |>  DomUrl.AddQueryParameter "context" context.asString
        module by = 
            let page (context:SolarWindsContext) (index:int) = url context  |> DomUrl.AddQueryParameter "page" (string index)
            module id = 
                let url  (context:SolarWindsContext)(contextId:int) = ServiceUrl.AppendSegments [ context.asString ; string contextId ]
                let entityGeneralInfo (contextId:int) (context:SolarWindsContext) =
                    ServiceUrl.AppendSegments [ "entity_general_info" ; string contextId ]
                    |> DomUrl.AddQueryParameter "object_type" context.asSingularString
                    |> DomUrl.AddQueryParameter "action_page_type" "show" 
                let tasks (contextId:int) (context:SolarWindsContext) = ServiceUrl.AppendSegments [ context.asString ; string contextId ; "tasks"]
                let taskById (contextId:int) (taskId : int) (context:SolarWindsContext) = ServiceUrl.AppendSegments [ context.asString ; string contextId ; "tasks" ; string taskId]
                let comments (context:SolarWindsContext) (contextId:int)  = ServiceUrl.AppendSegments [ context.asString ; string contextId ; "comments"]
                let commentById (contextId:int) (commentId : int) (context:SolarWindsContext) = ServiceUrl.AppendSegments [ context.asString ; string contextId ; "comments" ; string commentId]
                let timeTracks (contextId:int) (context:SolarWindsContext) = ServiceUrl.AppendSegments [ context.asString ; string contextId ; "time_tracks"]
                let timeTrackById (contextId:int) (time_trackId : int) (context:SolarWindsContext) = ServiceUrl.AppendSegments [ context.asString ; string contextId ; "time_tracks" ; string time_trackId]
                let purchases (contextId:int) (context:SolarWindsContext) = ServiceUrl.AppendSegments [ context.asString ; string contextId ; "purchases"]
                let purchaseById (contextId:int) (purchaseId : int) (context:SolarWindsContext) = ServiceUrl.AppendSegments [ context.asString ; string contextId ; "purchases" ; string purchaseId]
                let audits (contextId:int) (context:SolarWindsContext) = ServiceUrl.AppendSegments [ context.asString ; string contextId ; "audits"]
                let serviceMonitorStatistic  (context:SolarWindsContext) (contextId:int) = ServiceUrl.AppendSegments [ context.asString ; string contextId ; "service_monitor_statistic"]
                let responseTemplateVariables (contextId:int) (context:SolarWindsContext) = ServiceUrl.AppendSegments [ context.asString ; string contextId ; "comments"]
                let relatedItems (context:SolarWindsContext)  (contextId:int) = 
                    ServiceUrl.AppendSegments [ context.asString ; string contextId ; "related_itsms" ; "related_items"]
                    |> DomUrl.AddQueryParameter "collections[]" "incidents"
                    |> DomUrl.AddQueryParameter "collections[]" "problems"
                    |> DomUrl.AddQueryParameter "collections[]" "changes"
                    |> DomUrl.AddQueryParameter "collections[]" "releases"
                    |> DomUrl.AddQueryParameter "collections[]" "hardwares"
                    |> DomUrl.AddQueryParameter "collections[]" "mobiles"
                    |> DomUrl.AddQueryParameter "collections[]" "other_assets"
                    |> DomUrl.AddQueryParameter "collections[]" "discovery_hardwares"
                    |> DomUrl.AddQueryParameter "collections[]" "configuration_items"
                    |> DomUrl.AddQueryParameter "collections[]" "solutions"
                    |> DomUrl.AddQueryParameter "collections[]" "purchase_orders"
                let relatedItemsList  (contextId:int) (context:SolarWindsContext) = 
                    ServiceUrl.AppendSegments [ context.asString ; string contextId ; "related_itsms" ; "list"]
                    |> DomUrl.AddQueryParameter "object_type" context.asString

    let incidentsById (id:int) = context.by.id.url SolarWindsContext.incidents id 
    let serviceMonitorStatisticByIncidentId (incidentId:int) = context.by.id.serviceMonitorStatistic SolarWindsContext.incidents incidentId
    let commentsByIncidentId (incidentId:int) = context.by.id.comments SolarWindsContext.incidents incidentId
    let relatedItemsByIncidentId (incidentId:int) = context.by.id.relatedItems SolarWindsContext.incidents incidentId
    let incidentsByPage (page:int) = context.by.page SolarWindsContext.incidents page

    let serviceRequestsByCatalogItemId (catalogItemId:int)   = ServiceUrl.AppendSegments [ SolarWindsContext.catalog_items.asString ; string catalogItemId ; "service_requests"]
    let changeRequestsByChangeCatalogId (changeCatalogId:int)   = ServiceUrl.AppendSegments [ SolarWindsContext.change_catalogs.asString ; string changeCatalogId ; "change_requests"]
    let warrantiesByHardwareId (hardwareId:int)   = ServiceUrl.AppendSegments [ SolarWindsContext.hardwares.asString ; string hardwareId ; "warranties"]
    let warrantyByHardwareIdWarrantyId (hardwareId:int)(warrantyId:int)   = ServiceUrl.AppendSegments [ SolarWindsContext.hardwares.asString ; string hardwareId ; "warranties" ; string warrantyId]
    let contractItemsByContractId (contractId:int)  = ServiceUrl.AppendSegments [ SolarWindsContext.contracts.asString ; string contractId ; "items"]
    let contractItemByContractIdItemId (contractId:int)(itemId:int)   = ServiceUrl.AppendSegments [ SolarWindsContext.contracts.asString ; string contractId ; "items" ; string itemId]

    // configuration_items/{id}/append_multiple_dependent_assets"

(*


SolarWindsContext.all |> Array.map (fun context -> 
        task {

            let! contextTab = browser.NewBackgroundTab()
            let! response = (SolarWindsServiceDesk.filtersByContext context).json |> contextTab.GoToAsync
            do! contextTab.CloseAsync()
        }
    
    )
SolarWindsContext.all |> Array.map (fun context -> 
        task {

            let! contextTab = browser.NewBackgroundTab()
            let! response = (SolarWindsServiceDesk.context context).json |> contextTab.GoToAsync
            do! contextTab.CloseAsync()
        }
    
    )


*)

// TODO next paginate 
let waitUntilFileExists (file: FileInfo) =
    task {
        while not (File.Exists file.FullName) do
            do! Task.Delay 1000
    }

let paginateSolarWinds  (url:DomUrl) (pagesDirectory:DirectoryInfo) = 

        let lastPage = 
            match pagesDirectory.GetFiles( $"*{url.pathName}") with 
            | [||] -> 1
            | urlFiles -> 
                urlFiles
                |> Array.map (fun urlFile -> int urlFile.Directory.Name)
                |> Array.sort
                |> Array.last
        task {

            match mainTab |> SolarWindsServiceDesk._header.total_pages url with 
            | Some totalPages when totalPages > 1 -> 
                    for currentPage = lastPage to totalPages do 
                            let! pageTab = browser.NewBackgroundTab()
                            let! response = pageTab.GoToAsync( url |> DomUrl.AddQueryParameter "page" currentPage )
                            let file = FilePath.Sanitize( Path.Combine(Folder.SolarWinds.FullName,  queryStringPath response.DomUrl response.DomUrl.extension ) ) |> FileInfo
                            printfn
                                "Waiting for file before closing tab: %s"
                                file.FullName

                            do! waitUntilFileExists file

                            printfn
                                "File detected; closing tab: %s"
                                file.FullName

                            do! pageTab.CloseAsync()
                | _ -> ()
        }



let getIncidentsXml() = 
    DirectoryInfo @"D:\Artifact\Company\SolarWinds\incidents\is_portal_mode\false\layout\long\page"
    |> paginateSolarWinds SolarWindsServiceDesk.HelpdeskIncidentsList.xml




let getIncidentsJson() = 
    DirectoryInfo @"D:\Artifact\Company\SolarWinds\incidents\is_portal_mode\false\layout\long\page"
    |> paginateSolarWinds SolarWindsServiceDesk.HelpdeskIncidentsList.json


// mainTab.GoTo SolarWindsServiceDesk.profile

// let response = mainTab.GoTo SolarWindsServiceDesk.HelpdeskIncidentsList 

module Microsoft =
    module Graph = 
        let graph_explorer =  DomUrl "https://developer.microsoft.com/en-us/graph/graph-explorer"

// mainTab.GoTo Microsoft.Graph.graph_explorer




let getAccessToken(tab:IPage) = 
    tab.GoTo Microsoft.Graph.graph_explorer |> ignore
    let accessTokenButton = 
            tab.elementsByTagAttributeValue FssTag.Button FssAttribute.Value "access-token"
            |> Array.exactlyOne
    accessTokenButton.Click()
    let accessTokenDiv = 
            mainTab.elementsByTagAttributeValue FssTag.Div FssAttribute.Id "access-token"
                |> Array.exactlyOne
    accessTokenDiv.InnerText()


let httpClient = new HttpClient()
httpClient.DefaultRequestHeaders.Authorization <- AuthenticationHeaderValue("Bearer", getAccessToken(mainTab))
let MicrosoftGraph = new GraphServiceClient(httpClient)
let me = task {return! MicrosoftGraph.Me.GetAsync() } |> force
let userResponse = task {return! MicrosoftGraph.Users.GetAsync() } |> force

let applicationsResponse = 
    task {return! MicrosoftGraph.Applications.GetAsync() }
    |> force



let mailFolders = MicrosoftGraph.Me.MailFolders.GetAsync() |> Async.AwaitTask |> Async.RunSynchronously


   
let emailRequest = new Me.SendMail.SendMailPostRequestBody()
let email = new Models.Message()
let body = new ItemBody()
body.Content <- 
    """
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Sample Web Page</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            line-height: 1.6;
            margin: 0;
            padding: 20px;
            background-color: #f4f4f9;
            color: #333;
        }
        header {
            background: #354259;
            color: #fff;
            padding: 20px;
            text-align: center;
        }
        main {
            background: #fff;
            padding: 20px;
            margin-top: 20px;
            border-radius: 8px;
            box-shadow: 0 2px 5px rgba(0,0,0,0.1);
        }
        footer {
            text-align: center;
            margin-top: 20px;
            font-size: 0.9em;
            color: #666;
        }
        a {
            color: #0066cc;
        }
    </style>
</head>
<body>

    <header>
        <h1>Welcome to My Sample Website</h1>
    </header>

    <main>
        <h2>About This Page</h2>
        <p>This is a foundational HTML5 document. It incorporates typical structural components used to engineer modern, responsive web experiences.</p>
        
        <h3>Key Features Included:</h3>
        <ul>
            <li>Mobile-friendly viewport configuration meta tag</li>
            <li>Embedded CSS stylesheet block for structural presentation</li>
            <li>Semantic layout dividers (&lt;header&gt;, &lt;main&gt;, &lt;footer&gt;)</li>
        </ul>

        <p>You can find comprehensive documentation and tutorials on the official <a href="https://developer.mozilla.org" target="_blank">MDN Web Docs</a>.</p>
    </main>

    <footer>
        <p>&copy; 2026 Sample Company. All rights reserved.</p>
    </footer>

</body>
</html>
    """
body.ContentType <- BodyType.Html
email.Body <- body
email.Subject <- "Html Testing"
let recipient = new Recipient()
let myEmailAddress = new EmailAddress()
myEmailAddress.Address <- me.UserPrincipalName
recipient.EmailAddress <- myEmailAddress
let recipients = new ResizeArray<Recipient>()
recipients.Add recipient
email.ToRecipients <- recipients
emailRequest.Message <- email
// MicrosoftGraph.Me.SendMail.PostAsync(emailRequest) |> Async.AwaitTask |> Async.RunSynchronously


 



module NeoGov = 
    let PaginatedUrl (url:DomUrl) = 
                    url
                    |> DomUrl.AddQueryParameter "Page" 1
                    |> DomUrl.AddQueryParameter "PageSize" 1000
    let loginwithsso = DomUrl "https://login.neogov.com/loginwithsso"// ?returnURL=https%3A%2F%2Funified.neogov.com%2Fdashboard&siteCode=US 
    let dashboard = DomUrl "https://unified.neogov.com/dashboard"
    module Employee = 
        let employees = DomUrl "https://unifiedweb-api.neogov.com/api/Employee/employees" |> PaginatedUrl
        module by = 
            module id = 
                let orgChartView (employeeId:string) = DomUrl $"https://unifiedweb-api.neogov.com/api/Employee/{employeeId}/hierarchy/orgChartView" |> DomUrl.AddQueryParameter "includeSubordinateInformation" true
                let directManager (employeeId:string) = DomUrl $"https://unifiedweb-api.neogov.com/api/Employee/{employeeId}/directManager" 
                let profile (employeeId:string) = DomUrl $"https://unifiedweb-api.neogov.com/api/Employee/user-profile" |> DomUrl.AddQueryParameter "employeeId" employeeId
    module Default = 
        let customWindowProperties = DomUrl "https://unifiedweb-api.neogov.com/api/Default/customWindowProperties"
    let profile (employeeId:string) = DomUrl $"https://unified.neogov.com/profile/{employeeId}"
    module Task = 
        let todo = DomUrl "https://unifiedweb-api.neogov.com/api/Task/todo" |> PaginatedUrl
        let completed = DomUrl "https://unifiedweb-api.neogov.com/api/Task/completed" |> PaginatedUrl
        let taskType = DomUrl "https://unifiedweb-api.neogov.com/api/TaskType"




let neogovEmployees = NeoGovEmployeesProvider.Load @"D:\Artifact\Company\NeoGov\_samples\employees.json"
let neogovEmployeeById = 
    neogovEmployees.data
    |> Array.map (fun employee -> employee.id, employee)
    |> Map.ofArray






module Me = 
    module SolarWinds =
        let profile = SolarWindsProfileProvider.Load  @"D:\Artifact\Company\SolarWinds\_samples\profile.json"
    module NeoGov = 
        let employee = neogovEmployees.data |> Array.find (fun employee -> employee.employeeName = "Brandon Collier")
        let profile = NeoGov.profile (employee.id.ToString())
    module MicrosoftGraph = 
        let user =  task {return! (MicrosoftGraph.UsersWithUserPrincipalName "CollierB@leoncountyfl.gov").GetAsync() } |> force




let NeoGovEmployeeJsonSchema = JsonSchema.FromSampleJson(Me.NeoGov.employee.ToString())
NeoGovEmployeeJsonSchema.codegenProperties
NeoGovEmployeeJsonSchema.ToJson()
Me.NeoGov.employee
neogovEmployeeById[Me.NeoGov.employee.reportingToEmployeeId.Value]
// mainTab.GoTo Me.NeoGov.profile

Me.NeoGov.employee.id
Me.SolarWinds.profile


// mainTab.GoTo NeoGov.Employee.employees







module SunshineHealth = 
    let home = DomUrl "https://findaprovider.sunshinehealth.com/location"
    let response = CarrierEntityProvider.Load carrierEntitiesFilePath
    

mainTab.GoTo SunshineHealth.home


(*



let locationInput = mainTab.elementByAttributeValue FssAttribute.Id "location-input" 

locationInput.EnterText("18200 Cochran Blvd, Port Charlotte, FL 33948")
let continueSubmitButton = mainTab.elementByTagAttributeValue FssTag.Button FssAttribute.Id "continue-submit-button" 
continueSubmitButton.Click()

let selectNetwork = mainTab.elementByTagAttributeValue FssTag.Select FssAttribute.Id "select-network" 
selectNetwork.Click()
selectNetwork.Type("Medicaid Plan")
selectNetwork.Click()
continueSubmitButton.Click()

let medicalProfessionalsSpan = mainTab.elementByTagInnerText FssTag.Span "Medical Professionals"
medicalProfessionalsSpan.Click()


let primaryCareSpans = mainTab.elementsByTagInnerText FssTag.Span "Primary Care"
primaryCareSpans[1].Click()

let primaryDefaultSearchButton = mainTab.elementsByTagInnerText FssTag.Button "Search"
primaryDefaultSearchButton[0].Click()


let pcesQueries = finishedRequests |> Seq.filter (fun request -> request.Url = "https://external-api.search.my.centene.com/pces/query") |> Seq.toArray
pcesQueries.Length

pcesQueries[0].PostData

pcesQueries
|> Array.iteri (fun index pcesQuery -> 
    let indexDirectory = Directory.CreateDirectory $@"D:\Artifact\Company\SunshineHealth\query\{index}"
    let queryRequestFile = Path.Combine(indexDirectory.FullName, "request.json")  |> FileInfo
    File.WriteAllText(queryRequestFile.FullName, pcesQuery.PostData |> JsonValue.Parse |> string)
    let queryResponseFile = Path.Combine(indexDirectory.FullName, "response.json")   |> FileInfo
    match pcesQuery.Response.Text() with 
    | Some responseText -> File.WriteAllText(queryResponseFile.FullName, responseText |> JsonValue.Parse |> string)
    | None -> ()
)
*)

type MedicalProvider = 
    {
        ``First Name``:string
        ``Middle Name``:string
        ``Last Name``:string
        Description:string
        Gender:string
        Grouping:string
        ``Primary Location Name``:string
        ``Primary Location Phone``:string
        ``Primary Location Address Line 1``:string
        ``Primary Location Address Line 2``:string
        ``Primary Location Address City``:string
        ``Primary Location Address Zip Code``:int
    }

let results = 
    let carrierEntitiesJsonValue = JsonValue.Load carrierEntitiesFilePath
    carrierEntitiesJsonValue.AsArray()
    |> Array.map (fun carrierEntity -> CarrierEntityProvider.Parse(string carrierEntity))


let writeCsv (filePath: string) data =
    use writer = new StreamWriter(filePath)
    use csv = new CsvWriter(writer, CultureInfo.InvariantCulture)
    csv.WriteRecords(data)
let targetCities = 
    set [
        
        "Englewood"
        "North Port"
        "Port Charlotte"
        "Punta Gorda"
        "Venice"
    ]




let locationEntities = 
    results
    |> Array.collect (fun result -> 
            result.carrierEntity.locations
            |> Array.choose (fun location -> 
                match location.address.city with 
                | city when targetCities.Contains city && not (location.name.ToLowerInvariant().Contains("millennium")) -> Some(location, result.carrierEntity)
                // | "North Port"
                // | "Port Charlotte"
                // | "Punta Gorda"
                // | "Venice"
                // | "Arcadia"
                // | "Cape Coral"
                // | "Estero"
                // | "Fort Myers"
                // | "Labelle"
                // | "Myakka City"
                // | "Nokomis"
                // | "North Fort Myers"
                // | "Osprey"
                // | "Saint James City"
                // | "Sarasota"
                | _ -> None
                )
        )





type LocationRow = 
    {
        ``Address City``:string
        ``Location Name``:string
        ``Provider Name``:string
        ``Main or Secondary``:string
        ``Location Type`` :string
        ``Phone Number``:string
        ``Address Line 1``:string
        ``Address Line 2``:string
        ``Address Zip Code``:int
        ``Primary Care Type``:string
        ``Monday Hours``: string
        ``Tuesday Hours``: string
        ``Wednesday Hours``: string
        ``Thursday Hours``: string
        ``Friday Hours``: string
        ``Practitioner First Name``:string
        ``Practitioner Middle Name``:string
        ``Practitioner Last Name``:string
        ``Practitioner Gender`` :string
        ``Provider Type``:string
        ``Telehealth Participant`` : string
    }





let locationRows = 
    locationEntities
    |> Array.map (fun (location, carrierEntity) -> 

        {
            ``Location Name`` = location.name
            ``Main or Secondary`` = 
                match location.primary with 
                | "Y" -> "Main Location"
                | "N" -> "Secondary Location"
            ``Phone Number`` =  location.phone.phone
            ``Address Line 1`` = location.address.addressLine1
            ``Address Line 2`` = defaultArg location.address.addressLine2 String.Empty
            ``Address City`` = location.address.city
            ``Address Zip Code`` = location.address.zipCode
            ``Primary Care Type`` = location.specialties |> Array.choose (fun speciality -> speciality.descriptionDisplay) |> Array.distinct |> String.concat ", "
            ``Monday Hours`` = defaultArg (location.practitionerOfficeHours |> Option.map (fun officeHours -> $"{officeHours.monday.isoOpen.DateTime.ToShortTimeString()} - {officeHours.monday.isoClose.DateTime.ToLocalTime().ToShortTimeString()}")) String.Empty
            ``Tuesday Hours`` = defaultArg (location.practitionerOfficeHours |> Option.map (fun officeHours -> $"{officeHours.tuesday.isoOpen.DateTime.ToShortTimeString()} - {officeHours.tuesday.isoClose.DateTime.ToLocalTime().ToShortTimeString()}")) String.Empty
            ``Wednesday Hours`` = defaultArg (location.practitionerOfficeHours |> Option.map (fun officeHours -> $"{officeHours.wednesday.isoOpen.DateTime.ToShortTimeString()} - {officeHours.wednesday.isoClose.DateTime.ToLocalTime().ToShortTimeString()}")) String.Empty
            ``Thursday Hours`` = defaultArg (location.practitionerOfficeHours |> Option.map (fun officeHours -> $"{officeHours.thursday.isoOpen.DateTime.ToShortTimeString()} - {officeHours.thursday.isoClose.DateTime.ToLocalTime().ToShortTimeString()}")) String.Empty
            ``Friday Hours`` = defaultArg (location.practitionerOfficeHours |> Option.map (fun officeHours -> $"{officeHours.friday.isoOpen.DateTime.ToShortTimeString()} - {officeHours.friday.isoClose.DateTime.ToLocalTime().ToShortTimeString()}")) String.Empty
            ``Practitioner First Name`` =  defaultArg (carrierEntity.name |> Option.map (fun name -> name.firstName)) String.Empty
            ``Practitioner Middle Name`` =  defaultArg (carrierEntity.name |> Option.map (fun name -> defaultArg name.middleName String.Empty)) String.Empty
            ``Practitioner Last Name`` =  defaultArg (carrierEntity.name |> Option.map (fun name -> name.lastName)) String.Empty
            ``Location Type`` = location.specialties |> Array.choose (fun speciality -> speciality.grouping) |> Array.distinct |> String.concat ", "
            ``Practitioner Gender`` = defaultArg carrierEntity.gender String.Empty
            ``Provider Name`` = defaultArg carrierEntity.providerName String.Empty
            ``Provider Type`` =  location.specialties |> Array.choose (fun speciality -> speciality.category) |> Array.distinct |> String.concat ", "
            ``Telehealth Participant`` =
                                carrierEntity.attributes
                                |> Array.filter (fun attribute -> attribute.name =  "Telehealth Participant")
                                |> Array.collect (fun attribute -> attribute.fields |> Array.map (fun field -> $"{field.name} {field.value}") )
                                |> String.concat " "
                                |> _.Replace("\"","")
                                
        }
    )
    |> Array.filter (fun locationRow -> 
            locationRow.``Practitioner Gender`` <> "F"
        )
    |> Array.choose (fun locationRow -> 
        match locationRow.``Primary Care Type`` with 
        | "Pediatrics (Babies, Children)"
        | "Pediatrics (Babies, Children) Neonatal-Perinatal Medicine, Pediatrics (Babies, Children)"
            -> None
        | _ -> Some locationRow
        )
    |> Array.sortBy (fun locationRow -> locationRow.``Address City``, locationRow.``Location Name``,locationRow.``Main or Secondary``  )

let randomLocation = locationRows |> Array.randomChoice

randomLocation

locationRows |> writeCsv @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Family\Providers.csv" 





















// TODO investigate these for infor module 
(*
https://inforprod.leoncountyfl.gov/operations/Core/DashboardImages/DashboardImage.aspx?mapname=a2712234&configName=_e1b5b1e6d88d445381e48301377a6d0c&id=db_e1b5b1e6d88d445381e48301377a6d0c&w=300&h=153&map=true
https://inforprod.leoncountyfl.gov/operations/Client/contextMessagingCombined.js?_=1787580143156
https://inforprod.leoncountyfl.gov/operations/api/core/autocomplete/search

*)






















// .results[29].carrierEntity.locations[0].name
(*

module SolarWinds = 
    
    open https.leoncountyfl.samanage.com
    let ComputersList = hardwares.json.url
    let HelpdeskIncidentsList = incidents.json.url
    let RisksList = risks.json.url
    let ContractsList = contracts.json.url
    let SoftwareList = softwares.json.url
    let OtherAssetsList = other_assets.json.url
    let VendorsList = vendors.json.url
    let PrintersList = printers.json.url
    let AuditLogList = audits.json.url
    let UsersList = users.json.url
    let ProblemsList = problems.json.url
    let ChangesList = changes.json.url
    let ReleasesList = releases.json.url
    let SolutionsList = solutions.json.url
    let CatalogItemsList = catalog_items.json.url
    let DepartmentsList = departments.json.url
    let SitesList = sites.json.url
    let GroupsList = groups.json.url
    let MobileDevicesList = mobiles.json.url
    let RolesList = roles.json.url
    let CategoriesList = categories.json.url
    let ChangeCatalogsList = change_catalogs.json.url
    let ConfigurationItemsList = configuration_items.json.url
    let PurchaseOrdersList = purchase_orders.json.url
    let padWidth = 6
    
    let default_landing_page = DomUrl "https://leoncountyfl.samanage.com/default_landing_page"
    let homePage (ipage:IPage) = 
        ipage.GoTo default_landing_page |> ignore
        match ipage.Url with 
        | "https://leoncountyfl.samanage.com/login" -> 
            let singleSignOnButton = ipage.anchorsByText "Single Sign-On" |> Array.exactlyOne
            singleSignOnButton.javascriptElement.Click()
        | _ -> ()

    let unseen_count = DomUrl "https://leoncountyfl.samanage.com/notifications/unseen_count.json"
    let PaginatedUrl (url:DomUrl) = 
                    url
                    |> DomUrl.AddQueryParameter "page" 1
                    |> DomUrl.AddQueryParameter "per_page" 100
                    |> DomUrl.AddQueryParameter "no_me" true
                    |> DomUrl.AddQueryParameter "is_portal_mode" false
    module Users = 
        let custom_view = 
            DomUrl $"https://leoncountyfl.samanage.com/custom_views/users.json"
            |> DomUrl.AddQueryParameter "page_parameters[controller]" "users"
            |> DomUrl.AddQueryParameter "page_parameters[action]" "index"
            |> DomUrl.AddQueryParameter "page_parameters[enabled]" 1
            |> DomUrl.AddQueryParameter "page_parameters[report_id]" 8992244
            |> DomUrl.AddQueryParameter "report_id" 8992244
            |> DomUrl.AddQueryParameter "is_portal_mode" false
    module Analytics = 
        module Reports = 
            let url = DomUrl "https://leoncountyfl.samanage.com/reports" |> DomUrl.AddQueryParameter "family_type" "all"
            let reports = DomUrl "https://leoncountyfl.samanage.com/reports.json" |> DomUrl.AddQueryParameter "family_type" "all"
        module DataExport = 
            let url = DomUrl "https://leoncountyfl.samanage.com/custom" 
            let custom (context:SolarWindsContext) = DomUrl "https://leoncountyfl.samanage.com/custom.json"  |> DomUrl.AddQueryParameter "context" context.asString

            let hardwares = custom SolarWindsContext.hardwares 
            let tasks = custom SolarWindsContext.tasks 
            

    module Dashboard = 
        let url = DomUrl "https://leoncountyfl.samanage.com/dashboard"
        let dashboards = DomUrl "https://leoncountyfl.samanage.com/dashboards.json"
    module Solutions = 

        let solutions = DomUrl "https://leoncountyfl.samanage.com/solutions.json"
    module ServiceCatalog = 

            let catalog_items = DomUrl "https://leoncountyfl.samanage.com/catalog_items.json"
    module ServiceDesk = 
        module Incidents = 
            let url = DomUrl "https://leoncountyfl.samanage.com/incidents"
            let incidentsByPage (index:int) = DomUrl "https://leoncountyfl.samanage.com/incidents.json" |> DomUrl.AddQueryParameter "page" index
            let incidents = incidentsByPage 1
            let directory = Path.Combine(Folder.SolarWinds.FullName,  incidents.pathStem) |> DirectoryInfo
            let downloadedIndexes = 
                Folder.allIncidents.GetFiles() |> Array.map (fun file -> file.Stem[incidents.pathStem.Length + 1 ..])
                    |> Array.choose (fun stem -> 
                        try 
                            let downloadedIndex = int stem
                            Some downloadedIndex
                        with 
                         | err -> 
                            logLines.Add(sprintf "%s failed to parse with error %s" stem err.Message)
                            None
                    )
                    
            let latestIndex  = 
                match directory.Exists, downloadedIndexes.Length with
                | true, length when length > 0 -> downloadedIndexes |> Array.sort |> Array.rev |> Array.head
                | _ -> 0
            let metadata = DomUrl "https://leoncountyfl.samanage.com/custom_views/incidents/metadata.json"
            let views = Analytics.DataExport.custom SolarWindsContext.incidents 
            let columns = DomUrl "https://leoncountyfl.samanage.com/custom_views/incidents.json"
            let types_list = DomUrl "https://leoncountyfl.samanage.com/incident_types/types_list.json"
            let incident (id:int) = DomUrl $"https://leoncountyfl.samanage.com/incidents/{id}.json"
            let entity_general_info (id:int) = 
                    DomUrl $"https://leoncountyfl.samanage.com/entity_general_info/{id}.json"
                    |> DomUrl.AddQueryParameter "object_type" "incident"
                    |> DomUrl.AddQueryParameter "action_page_type" "show" 
                    |> DomUrl.AddQueryParameter "is_portal_mode" false
            let related_items_list (id:int) = 
                    DomUrl $"https://leoncountyfl.samanage.com/incidents/{id}/related_itsms/list.json"
                    |> DomUrl.AddQueryParameter "object_type" "incident"
                    |> DomUrl.AddQueryParameter "is_portal_mode" false
                

        module ResponseTemplates = 
            let total_count = DomUrl $"https://leoncountyfl.samanage.com/response_templates/total_count.json" |> DomUrl.AddQueryParameter "is_portal_mode" false
            let total_count_personal = DomUrl $"https://leoncountyfl.samanage.com/response_templates/total_count_personal.json" |> DomUrl.AddQueryParameter "is_portal_mode" false
            let total_count_global = DomUrl $"https://leoncountyfl.samanage.com/response_templates/total_count_global.json" |> DomUrl.AddQueryParameter "is_portal_mode" false
            let variables (id:int) = DomUrl $"https://leoncountyfl.samanage.com/incidents/{id}/response_template_variables.json" |> DomUrl.AddQueryParameter "is_portal_mode" false
        module ServiceCatalog = 
            let catalog_items = DomUrl "https://leoncountyfl.samanage.com/catalog_items.json"
        module Assets = 
            module Computers = 
                let url = DomUrl "https://leoncountyfl.samanage.com/hardwares.json"
                let hardwaresByPage (index:int) = DomUrl "https://leoncountyfl.samanage.com/hardwares.json" |> DomUrl.AddQueryParameter "page" index
                let hardwares = hardwaresByPage 1
                let metadata = DomUrl "https://leoncountyfl.samanage.com/custom_views/hardwares/metadata.json"
                let views = Analytics.DataExport.custom SolarWindsContext.hardwares 
                let columns = DomUrl "https://leoncountyfl.samanage.com/custom_views/hardwares.json"
            module Software = 
                let url = DomUrl "https://leoncountyfl.samanage.com/softwares.json"
                let softwaresByPage (index:int) = DomUrl "https://leoncountyfl.samanage.com/softwares.json" |> DomUrl.AddQueryParameter "page" index
                let softwares = softwaresByPage 1
                let metadata = DomUrl "https://leoncountyfl.samanage.com/custom_views/softwares/metadata.json"
                let views = Analytics.DataExport.custom SolarWindsContext.softwares 
                let columns = DomUrl "https://leoncountyfl.samanage.com/custom_views/softwares.json"
            module Printers = 
                let url = DomUrl "https://leoncountyfl.samanage.com/printers"
            module MobileDevices = 
                let url = DomUrl "https://leoncountyfl.samanage.com/mobiles"
            module NetworkDevices = 
                let url = DomUrl "https://leoncountyfl.samanage.com/discovery_hardwares"
            module OtherAssets = 
                let url = DomUrl "https://leoncountyfl.samanage.com/other_assets"
            module Maps = 
                let url = DomUrl "https://leoncountyfl.samanage.com/maps"
        module Tasks = 
            let url = DomUrl "https://leoncountyfl.samanage.com/tasks"
            let metadata = DomUrl "https://leoncountyfl.samanage.com/custom_views/tasks/metadata.json" |> DomUrl.AddQueryParameter "is_portal_mode" false
            
            let tasks_json = DomUrl "https://leoncountyfl.samanage.com/tasks.json"
            let tasks_jsonhtml = DomUrl "https://leoncountyfl.samanage.com/tasks.json"
            let all_tasks = DomUrl "https://leoncountyfl.samanage.com/tasks.jsonhtml" |> DomUrl.AddQueryParameter "report_id" 8992258
            let my_tasks = 
                tasks_jsonhtml.AddQueryParameter "assigned_to" 10744815
            // https://leoncountyfl.samanage.com/tasks.jsonhtml?assigned_to=10744815&report_id=8992259
    module Setup = 
        let users = DomUrl "https://leoncountyfl.samanage.com/setup/users.json" 
        let group_list = DomUrl "https://leoncountyfl.samanage.com/groups/group_list.json" |> PaginatedUrl
        let assignees = group_list.AddQueryParameter "staff" true

        let departments = DomUrl "https://leoncountyfl.samanage.com/departments.json" |> PaginatedUrl
        let sites = DomUrl "https://leoncountyfl.samanage.com/sites.json"
        let requesters = DomUrl "https://leoncountyfl.samanage.com/requesters.json" |> PaginatedUrl
        
*)










type IncidentFileSet = 
    {
        incidentId:int
        pagedIncidentFile:FileInfo
        incidentFile:FileInfo
        commentsFile:FileInfo
        serviceMonitorStatisticFile:FileInfo
        relatedItemsFile:FileInfo
    }
    static member fromId (id:int) = 
        {
            incidentId = id
            pagedIncidentFile = Path.Combine(Folder.incidents.FullName, string id,$"pagedIncident.json") |> FilePath.Sanitize |> FileInfo
            incidentFile = Path.Combine(Folder.incidents.FullName, string id,$"incident.json") |> FilePath.Sanitize |> FileInfo
            commentsFile = Path.Combine(Folder.incidents.FullName,string id, "comments.json") |> FilePath.Sanitize |> FileInfo
            serviceMonitorStatisticFile = Path.Combine(Folder.incidents.FullName,$"{id}",$"service_monitor_statistic.json") |> FilePath.Sanitize |> FileInfo
            relatedItemsFile = Path.Combine(Folder.incidents.FullName,string id,"related_itsms",$"related_items.json") |> FilePath.Sanitize |> FileInfo
        }
    member this.incidentDirectory = this.pagedIncidentFile.Directory
    member this.localFileRepresentation (file:FileInfo)  = 
        if file.Exists then 
                    Some {
                            jsonFile = file
                            jsonText = File.ReadAllText file.FullName 
                        }

        else 
            None
    
    member this.remoteFileRepresentation (urlFromId : int -> DomUrl)(fileName:string)(tab:IPage) = 
        let response = urlFromId this.incidentId |> _.json |> tab.GoTo
        response.JsonText this.incidentDirectory (fun url -> fileName )
    
    member this.localIncidentRepresentation = this.localFileRepresentation this.pagedIncidentFile
    member this.localIncident = 
        match this.localIncidentRepresentation with 
            | Some representation -> Some(IncidentProvider.Parse representation.jsonText)
            | None -> None
    member this.remoteIncidentRepresentation (tab:IPage) = this.remoteFileRepresentation SolarWindsServiceDesk.incidentsById "incident.json" tab
    member this.remoteIncident (tab:IPage) = 
        match this.remoteIncidentRepresentation tab with 
        | Some incident -> Some (IncidentProvider.Parse incident.jsonText)
        | None -> None
    member this.remoteIncidentPage (tab:IPage) = SolarWindsServiceDesk.incidentsById this.incidentId |> tab.GoTo

    member this.localServiceMonitorStatisticRepresentation = this.localFileRepresentation this.serviceMonitorStatisticFile
    member this.localServiceMonitorStatistic = 
            match this.localServiceMonitorStatisticRepresentation with 
            | Some representation -> Some(ServiceMonitorStatisticProvider.Parse representation.jsonText)
            | None -> None

    member this.localStateSpace = 
        match this.localServiceMonitorStatistic with 
        | Some serviceMonitorStatistic -> 
                Some {
                        incidentStates = 
                                serviceMonitorStatistic.state
                                |> Array.map (fun state -> 
        
                                        {
                                            id = state.id
                                            kind = StateKind.fromTitle state.title
                                            title = state.title
                                            startTime = state.startTime
                                            endTime = state.endTime
                                            timeSpent = state.timeSpent
                                            timeSpentBH = state.timeSpentBH
                                            timeSinceCreation = state.timeSinceCreation
                                            timeSinceCreationBH = state.timeSinceCreationBH
                                            isCurrent = state.isCurrent
                                            isDeleted = state.isDeleted
                                        }
                                )
                    }
        | None -> None
    member this.remoteServiceMonitorStatisticRepresentation (tab:IPage) = this.remoteFileRepresentation SolarWindsServiceDesk.serviceMonitorStatisticByIncidentId "service_monitor_statistic.json" tab
    member this.remoteServiceMonitorStatistic (tab:IPage) = 
        match this.remoteServiceMonitorStatisticRepresentation tab with 
        | Some serviceMonitorStatistic -> Some (ServiceMonitorStatisticProvider.Parse serviceMonitorStatistic.jsonText)
        | None -> None
    member this.remoteStateSpace(tab:IPage) = 
        match this.remoteServiceMonitorStatistic tab with 
        | Some serviceMonitorStatistic -> 
                Some {
                        incidentStates = 
                                serviceMonitorStatistic.state
                                |> Array.map (fun state -> 
        
                                        {
                                            id = state.id
                                            kind = StateKind.fromTitle state.title
                                            title = state.title
                                            startTime = state.startTime
                                            endTime = state.endTime
                                            timeSpent = state.timeSpent
                                            timeSpentBH = state.timeSpentBH
                                            timeSinceCreation = state.timeSinceCreation
                                            timeSinceCreationBH = state.timeSinceCreationBH
                                            isCurrent = state.isCurrent
                                            isDeleted = state.isDeleted
                                        }
                                )
                    }
        | None -> None
    member this.localCommentsRepresentation = this.localFileRepresentation this.commentsFile

    member this.localComments = 
        match this.localCommentsRepresentation with 
        | Some representation -> Some(CommentsProvider.Parse representation.jsonText)
        | None -> None

    member this.remoteCommentsRepresentation (tab:IPage) = this.remoteFileRepresentation SolarWindsServiceDesk.commentsByIncidentId "comments.json" tab
    member this.remoteComments (tab:IPage) = 
        match this.remoteCommentsRepresentation tab with 
        | Some comments -> Some (CommentsProvider.Parse comments.jsonText)
        | None -> None
    member this.localRelatedItemsRepresentation = this.localFileRepresentation this.relatedItemsFile
    member this.localRelatedItems = 
        match this.localRelatedItemsRepresentation with 
        | Some representation -> Some(RelatedItemsProvider.Parse representation.jsonText)
        | None -> None
    member this.remoteRelatedItemsRepresentation (tab:IPage) = this.remoteFileRepresentation SolarWindsServiceDesk.relatedItemsByIncidentId "related_items.json" tab
    member this.remoteRelatedItems (tab:IPage) = 
        match this.remoteRelatedItemsRepresentation tab with 
        | Some relatedItems -> Some (RelatedItemsProvider.Parse relatedItems.jsonText)
        | None -> None
    member this.byState (incidentState:StateKind) = 
        match this.localServiceMonitorStatistic with 
        | Some serviceMonitorStatistic -> serviceMonitorStatistic.state |> Array.filter (fun state -> state.title = incidentState.ToString())
        | None -> [||]

let chunkSize = 15
type IncidentDataSet = 
    {
        fileSets : IncidentFileSet array
    }
    member this.fileSetsMissingIncidentFile = 
        this.fileSets
        |> Array.Parallel.filter (fun fileSet -> not fileSet.incidentFile.Exists)
    member this.fileSetsMissingServiceMonitorStatisticFile = 
        this.fileSets
        |> Array.Parallel.filter (fun fileSet -> not fileSet.serviceMonitorStatisticFile.Exists)

    member this.WriteMissingIncidentFiles(initialCount:int) = 
        let mutable currentCount = 0
        let missingSet = this.fileSetsMissingIncidentFile
        missingSet
        |> Array.chunkBySize chunkSize
        |> Array.iter (fun chunk -> 
            chunk |>Array.Parallel.iter (fun fileSet -> 
                currentCount <- currentCount + 1
                let fileSetTab = browser.NewBackgroundTab() |> force
                printfn "processed %d of %d" currentCount initialCount
                match fileSet.remoteIncidentRepresentation fileSetTab with 
                | Some representation -> 
                    fileSetTab.CloseAsync() |> ignore
                    representation.WriteAllJson()
                | None -> 
                    fileSetTab.CloseAsync() |> ignore
                    printfn "incident.json not found for incident %d" fileSet.incidentId

                )
        )
    member this.WriteMissingServiceMonitorStatisticFiles(initialCount:int) = 
        let missingSet = this.fileSetsMissingServiceMonitorStatisticFile
        let mutable currentCount = 0
        missingSet
        |> Array.chunkBySize chunkSize
        |> Array.iter (fun chunk -> 
            chunk |>Array.Parallel.iter (fun fileSet -> 
                currentCount <- currentCount + 1
                let fileSetTab = browser.NewBackgroundTab() |> force
                printfn "processed %d of %d" currentCount initialCount
                match fileSet.remoteServiceMonitorStatisticRepresentation fileSetTab with 
                | Some representation -> 
                    fileSetTab.CloseAsync() |> ignore
                    representation.WriteAllJson()
                | None -> 
                    fileSetTab.CloseAsync() |> ignore
                    printfn "service_monitor_statistic.json not found for incident %d" fileSet.incidentId

                )
        )
    static member LoadDirectory() = 
        {
            fileSets = 
                    Folder.incidents.GetDirectories()
                    |> Array.map (fun idDirectory -> IncidentFileSet.fromId (int idDirectory.Name))
        }
    member this.byStateDaysAgo (kind:StateKind)(days:int) (tab:IPage)= 
        {
            fileSets =
                    this.fileSets
                    |> Array.filter (fun fileSet -> 
                            match fileSet.remoteStateSpace tab with 
                            | Some stateSpace -> stateSpace.isKindByDaysAgo kind days
                            | _ -> false
                            
                            )
        }
    member this.byStateLastWeek (kind:StateKind) (tab:IPage) = this.byStateDaysAgo kind -7 tab
    member this.byStateLastPayPeriod (kind:StateKind) (tab:IPage) = this.byStateDaysAgo kind -14 tab
    member this.createdDaysAgo(days:int) (tab:IPage) = tab |> this.byStateDaysAgo StateKind.New days 
    member this.createdLastWeek (tab:IPage) = tab |> this.createdDaysAgo -7
    member this.createdLastPayPeriod (tab:IPage) = tab |> this.createdDaysAgo -14
    member this.resolvedDaysAgo(days:int) (tab:IPage)= tab |> this.byStateDaysAgo StateKind.Resolved days 
    member this.resolvedLastWeek (tab:IPage) = tab |> this.resolvedDaysAgo -7
    member this.resolvedLastPayPeriod (tab:IPage) = tab |> this.resolvedDaysAgo -14
    member this.closedDaysAgo(days:int) (tab:IPage)= tab |> this.byStateDaysAgo StateKind.Closed days 
    member this.closedLastWeek (tab:IPage) = tab |> this.closedDaysAgo -7
    member this.closedLastPayPeriod (tab:IPage) = tab |> this.closedDaysAgo -14
    member this.statusReportableDaysAgo (days:int)(tab:IPage) = 
        let resolvedSubset = this.resolvedDaysAgo days tab
        let closedSubset = this.closedDaysAgo days tab
        {
            fileSets =
                    Array.concat [|
                        resolvedSubset.fileSets
                        closedSubset.fileSets
                    |]
        }








module Collector_of_Musicality = 
  let homePage = DomUrl "https://comterminal.carrd.co/" 

module Yaladre_Music_Blog = 
    let homePage = DomUrl "https://yaladre.blogspot.com/" 

module regenq_charting = 
    let repository = DomUrl "https://github.com/keannyooi/regenq-charting" 













// https://leoncountyfl.samanage.com/websockets/jwt.json?is_portal_mode=false













let jsonoidCommandLine (jsonlFile:FileInfo) (propertySet:JsonoidPropertySet) = 
    let outputFile = jsonlFile.ChangeExtension ".schema.json"
    let valuesFile = jsonlFile.ChangeExtension ".csv"
    $@"jsonoid --write-output {outputFile.FullName} --values {valuesFile.FullName} --prop {propertySet.asString} --extended-formats --detect-dynamic --detect-disjoint --numeric-strings {jsonlFile.FullName}"


let jsonoid  (commandLine:string) =
    cli {
        Shell CMD
        Command commandLine
    }
    |> Command.executeAsync


let getIncidentsPage (currentPage:int) (tab:IPage) = 
    let response = SolarWindsServiceDesk.incidentsByPage  currentPage |> _.jsonhtml |> tab.GoTo
    let representation = 
            response.JsonText Folder.incidentsPage (fun url -> 
                    match url.QueryKeyValue "page" with 
                    | Some (pageKey, pageValue) -> $"{pageValue}.json"
                    | None -> url.pathName
                    )
                    |> Option.get
    IncidentsJsonHtmlProvider.Parse representation.jsonText 
(*
let firstIncidentsPage = getIncidentsPage 1 
let pageEstimation = (firstIncidentsPage.count / 100) + 1

*)


let rec processIncidentsPages (currentPage:int) (tab:IPage) =
    let incidentsPage = getIncidentsPage currentPage tab
    Array.concat[|

        if incidentsPage.data.Length <> 0 then 
            incidentsPage.data
            |> Array.Parallel.map (fun incidentDatum -> 
                let incidentDirectory = Path.Combine (Folder.incidents.FullName,  string incidentDatum.id) |> Directory.CreateDirectory
                let pagedIncident = 
                    {
                        jsonFile = Path.Combine(incidentDirectory.FullName, "pagedIncident.json") |> FilePath.Sanitize |> FileInfo
                        jsonText = string incidentDatum.JsonValue 
                    }
                pagedIncident.WriteAllJson()
                

                IncidentFileSet.fromId incidentDatum.id

            )
            processIncidentsPages (currentPage + 1) tab

    |]


let incidentDataSet = IncidentDataSet.LoadDirectory()



let preCount = incidentDataSet.fileSetsMissingIncidentFile.Length

// incidentDataSet.WriteMissingServiceMonitorStatisticFiles()
incidentDataSet.WriteMissingIncidentFiles(preCount)

let postCount = incidentDataSet.fileSetsMissingIncidentFile.Length

match preCount,postCount with 
| _,_ when preCount = postCount -> printfn "no new files to download"
| _,_ -> printfn "downloaded %d files" (postCount - preCount)


let randomIncidentFileSet = incidentDataSet.fileSetsMissingServiceMonitorStatisticFile |> Array.randomChoice



randomIncidentFileSet.remoteIncidentPage mainTab
randomIncidentFileSet.remoteIncident mainTab
randomIncidentFileSet.incidentDirectory.FullName |> clip
let incident = randomIncidentFileSet.localIncident |> Option.get
incident.created_at
randomIncidentFileSet.localIncident

let processedIncidents = mainTab |> processIncidentsPages 889



(*

let processedPages = processIncidentsPages 345  |> Array.collect (fun fileset -> fileset)

let processedPage = processedPages[0]


jsonoidCommandLine processedPage.incidentLocalRepresentation.ndjsonFile JsonoidPropertySet.All |> clip

*)




















(*




type SolarWindsServiceDeskClient with 
    static member Create() = 
        let options = new SolarWindsServiceDeskClientOptions()
        options.BaseUrl <- "https://leoncountyfl.samanage.com/"
        options.AccessToken <- websockets.jwt.json.root.Jwt
        new SolarWindsServiceDeskClient(options)
    member this.getIncidents() = 
        let request = new GetIncidentsRequest()
        request.Layout <- ResponseLayout.Long
        request.Page <- 1
        request.PerPage <- 50
        task { return! this.Incidents.GetAsync(request, CancellationToken.None) } |> run




SolarWinds.Setup.group_list.WriteAllJsonPages()
SolarWinds.Setup.assignees.WriteAllJsonPages()
SolarWinds.Setup.sites.WriteAllJsonPages()
SolarWinds.Setup.requesters.WriteAllJsonPages()
SolarWinds.ServiceDesk.Incidents.types_list.WriteAllJsonPages()
SolarWinds.ServiceDesk.Incidents.columns.WriteAllJsonPages()
SolarWinds.Dashboard.dashboards.WriteAllJsonPages()
let incidentPage = SolarWinds.ServiceDesk.Incidents.incidentsByPage 887
incidentPage.pathStem
incidentPage.WriteAllJsonPages()

SolarWinds.ServiceDesk.Incidents.incidents.WriteAllJsonPages()

SolarWinds.Analytics.Reports.reports.WriteAllJsonPages()
*)




















































// -----------------------------------------------------------------------------
// NJsonSchema normalization
// -----------------------------------------------------------------------------

// -----------------------------------------------------------------------------
// Load schema
// -----------------------------------------------------------------------------

let incidentsSchema =
    task {
        return!
            JsonSchema.FromFileAsync(
                @"D:\Artifact\Company\SolarWinds\_schema\incidents.schema.json"
            )
    }
    |> force


let incidentSchema =
    incidentsSchema.Item.ActualSchema


// -----------------------------------------------------------------------------
// Load actual observations for closed-domain types
// -----------------------------------------------------------------------------
(*
let allIncidents =
    Folder.allIncidents.GetFiles("*.json")
    |> Array.collect (fun jsonFile ->
        IncidentsJsonHtmlProvider.Load jsonFile.FullName)

let states =
    allIncidents
    |> Array.map (fun incident ->
        incident.State)
    |> Array.distinct
    |> Array.sort

let priorities = 
    allIncidents
    |> Array.map (fun incident ->
        incident.Priority)
    |> Array.distinct
    |> Array.sort

let origins =
    allIncidents
    |> Array.map (fun incident ->
        incident.Origin)
    |> Array.distinct
    |> Array.sort


let resolutionCodes =
    allIncidents
    |> Array.choose (fun incident ->
        incident.ResolutionCode)
    |> Array.distinct
    |> Array.sort


let problems =
    allIncidents
    |> Array.map (fun incident ->
        incident.Problem)
    |> Array.distinct

let categories = 
    allIncidents 
    |> Array.choose (fun incident -> 
        try 
            Some incident.Category
        with 
        | _ -> None
    )
    |> Array.distinctBy (fun category -> category.Id)
    |> Array.sortBy (fun category -> category.Name)

let subcategories = 
    allIncidents 
    |> Array.choose (fun incident -> 
        try 
            incident.Subcategory
        with 
        | _ -> None
    )
    |> Array.distinctBy (fun category -> category.Id)
    |> Array.sortBy (fun category -> category.Name)

// -----------------------------------------------------------------------------
// Discover record-shaped schemas recursively
// -----------------------------------------------------------------------------

let generatedRecordSchemas =
    let encounteredTypeNames = HashSet<string>(StringComparer.Ordinal)

    let records = ResizeArray<string * JsonSchema>()

    // Problem is explicitly modeled below rather than mechanically generated.
    encounteredTypeNames.Add("Problem") |> ignore

    let rec visitSchema (schema: JsonSchema) =

        for property in schema.codegenProperties do

            let valueSchema = property.ActualSchema.nonNullValueSchema

            if valueSchema.hasType JsonObjectType.Object
               || valueSchema.HasActualProperties then

                let typeName =
                    astTypeName property.Name

                addRecord
                    typeName
                    valueSchema

            elif valueSchema.hasType JsonObjectType.Array then

                match valueSchema.arrayItem with

                | Some item ->

                    let itemSchema = item.nonNullValueSchema

                    if itemSchema.hasType JsonObjectType.Object || itemSchema.HasActualProperties then

                        let typeName =
                            property.Name
                                .Singularize()
                            |> astTypeName

                        addRecord
                            typeName
                            itemSchema

                | None ->
                    ()


    and addRecord
        (typeName: string)
        (schema: JsonSchema)
        =

        if encounteredTypeNames.Add(typeName) then

            records.Add(
                typeName,
                schema
            )

            // Recurse so Assignee -> ReportsTo -> Avatar etc. are also
            // materialized rather than only discovering root-level objects.
            visitSchema schema


    visitSchema incidentSchema

    records.ToArray()


// -----------------------------------------------------------------------------
// Generate F#
// -----------------------------------------------------------------------------

Ast.Oak() {
    Ast.AnonymousModule() {

        Ast.HashDirective( "r", "\"nuget: Dubzer.WhatwgUrl\"" )
        Ast.HashDirective( "r", "\"nuget: FSharp.Data\"" )
        Ast.HashDirective ( "r", "\"nuget: PosInformatique.Foundations.EmailAddresses\"" )
        Ast.HashDirective ( "r", "\"nuget: libphonenumber-csharp\"" )
 

        Ast.Open("System")
        Ast.Open("FSharp.Data")
        Ast.Open("Dubzer.WhatwgUrl")
        Ast.Open( "PosInformatique.Foundations.EmailAddresses")
        Ast.Open( "PhoneNumbers")

        Ast.Record("Incident") {

            for property in incidentSchema.codegenProperties do
                property.astField
        }


        Ast.Union("State") {

            for state in states do
                Ast.UnionCase(state)
        }
        |> _.toRecursive()
        |> _.attribute(
            Ast.Attribute("RequireQualifiedAccess")
        )

        Ast.Union("Priority") {

            for priority in priorities do
                Ast.UnionCase(priority)
        }
        |> _.toRecursive()
        |> _.attribute(
            Ast.Attribute("RequireQualifiedAccess")
        )


        Ast.Union("Origin") {

            for origin in origins do
                Ast.UnionCase(origin)
        }
        |> _.toRecursive()
        |> _.attribute(
            Ast.Attribute("RequireQualifiedAccess")
        )


        Ast.Union("ResolutionCode") {

            for resolutionCode in resolutionCodes do
                Ast.UnionCase(resolutionCode)
        }
        |> _.toRecursive()
        |> _.attribute(
            Ast.Attribute("RequireQualifiedAccess")
        )


        Ast.Record("Problem") {
            Ast.Field("id", "int")
            Ast.Field("href", "DomUrl")
        }
        |> _.toRecursive()


        for typeName, schema in generatedRecordSchemas do

            Ast.Record(typeName) {

                for property in schema.codegenProperties do
                    property.astField
            }
            |> _.toRecursive()
        Ast.Module("Category"){

            for category in categories do 
                Ast.Value(category.Name, Ast.RecordExpr([

                      Ast.RecordFieldExpr("id", Ast.Int category.Id)
                      Ast.RecordFieldExpr("name", Ast.String category.Name)
                      Ast.RecordFieldExpr("default_tags", Ast.String(defaultArg category.DefaultTags String.Empty))
                      Ast.RecordFieldExpr("deleted", Ast.Bool category.Deleted)
                      let default_assignee_id =
                        try 
                              Some category.DefaultAssigneeId
                        with 
                        | _ -> None
                      match default_assignee_id with 
                      | Some id -> Ast.RecordFieldExpr("default_assignee_id", $"Some {id}")
                      | None -> Ast.RecordFieldExpr("default_assignee_id", $"None")
                ]))
        }
        Ast.Module("Subcategory"){

            for subcategory in subcategories do 
                Ast.Value($"{subcategory.Name}'{subcategory.Id}", Ast.RecordExpr([

                      Ast.RecordFieldExpr("id", Ast.Int subcategory.Id)
                      Ast.RecordFieldExpr("name", Ast.String subcategory.Name)
                      Ast.RecordFieldExpr("default_tags", Ast.String(defaultArg subcategory.DefaultTags String.Empty))
                      Ast.RecordFieldExpr("parent_id", Ast.Int subcategory.ParentId)
                      Ast.RecordFieldExpr("deleted", Ast.Bool subcategory.Deleted)
                      let default_assignee_id =
                        try 
                              Some subcategory.DefaultAssigneeId
                        with 
                        | _ -> None
                      match default_assignee_id with 
                      | Some id -> Ast.RecordFieldExpr("default_assignee_id", $"Some {id}")
                      | None -> Ast.RecordFieldExpr("default_assignee_id", $"None")
                ]))
        }
    }
}
|> Gen.mkOak
|> Gen.run
|> fun fsharpText -> File.WriteAllText( @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\BrowserAutomation\Incidents.fsx", fsharpText )






let apiPaths = 
    {
        jsonFile = FileInfo apiPathDefinitionFilePath
        jsonText = 
                    apiDefinition.paths.JsonValue.Properties()
                    |> Array.map (fun (jsonKey,jsonValue) -> 
                        match jsonValue with 
                        | JsonValue.Record jsonRecord -> jsonRecord |> Array.insertAt 0 ("path", JsonValue.String jsonKey) |> JsonValue.Record
                    ) 
                    |> JsonValue.Array
                    |> string
    }
File.WriteAllText(apiPathDefinitionFilePath, apiPaths.jsonNode.asFormattedString)
let object_types = 
    apiDefinition.paths.JsonValue.Properties()
    |> Array.choose (fun (key,_) -> 
        let path = key[1..]
        let delimiterIndex = path.IndexOf "/"
        match path[..delimiterIndex - 1] with 
        | "{object_type}" -> None
        | "" -> None
        | object_type -> Some object_type
    )
    |> Array.distinct
    |> Array.sort



let incidentsRequestJsonSchema = Generator.Create "IncidentsRequest" typeof<GetIncidentsRequest>
let testRequest = new GetIncidentsRequest()
Ast.Oak() {
    Ast.AnonymousModule() {

        Ast.HashDirective( "r", "\"nuget: Dubzer.WhatwgUrl\"" )
        Ast.HashDirective( "r", "\"nuget: FSharp.Data\"" )
        Ast.HashDirective ( "r", "\"nuget: PosInformatique.Foundations.EmailAddresses\"" )
        Ast.HashDirective ( "r", "\"nuget: libphonenumber-csharp\"" )
        Ast.HashDirective ( "r", "\"nuget: CaseConverter\"" )
        Ast.HashDirective ( "r", "\"nuget: Humanizer.Core\"" )

 

        Ast.Open("System")
        Ast.Open("FSharp.Data")
        Ast.Open("Dubzer.WhatwgUrl")
        Ast.Open( "PosInformatique.Foundations.EmailAddresses")
        Ast.Open( "PhoneNumbers")
        Ast.Open( "Humanizer")
        Ast.Open( "CaseConverter")


        (Ast.Union("ObjectType") {

            for object_type in object_types do
                Ast.UnionCase(object_type)
        }
        |> _.attribute(
            Ast.Attribute("RequireQualifiedAccess")
        )).members(){
            Ast.Member("this.asPluralString", "this.ToString()")
            Ast.Member("this.asSingularString", "this.ToString().Singularize()")
        }
        for tag in apiDefinition.tags do
            let paths = 
                apiPathDefinitions
                |> Array.filter (fun element -> element.get.IsSome) 
                |> Array.filter (fun element -> element.get.Value.tags |> Array.exists (fun getTag -> getTag = tag.name))
            if paths.Length > 0 then 
                Ast.Module(tag.name.ToPascalCase()){
                    for path in paths do 
                        Ast.Value(path.get.Value.operationId, "()")
                
                }


        Ast.Record("IncidentsRequest") {
            
            

            for property in incidentsRequestJsonSchema.codegenProperties do
                property.astField
        }
        Ast.Union("State") {

            for state in states do
                Ast.UnionCase(state)
        }
        |> _.toRecursive()
        |> _.attribute(
            Ast.Attribute("RequireQualifiedAccess")
        )


    }
}
|> Gen.mkOak
|> Gen.run
|> fun fsharpText -> File.WriteAllText( @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\BrowserAutomation\SolarWindsServiceDeskAPI.fsx", fsharpText )








































let testFile = Folder.allIncidents.GetFiles() |> Array.randomChoice
let providedIncident = IncidentsJsonHtmlProvider.Load testFile.FullName












let incidentsAssignedToMe = 
    allIncidents
    |> Array.Parallel.filter (fun incident -> 
        try 
          match incident.Assignee.Email, incident.CreatedBy.Email   with 
          | Some email,_ when email.ToLowerInvariant() = "collierb@leoncountyfl.gov" -> true
          | _ -> false
        with 
        | _ -> false
    )
    |> Array.rev
let incidentsCreatedByMe = 
    allIncidents
    |> Array.Parallel.filter (fun incident -> 
        try 
          match incident.Assignee.Email, incident.CreatedBy.Email   with 
          | _, email when email.ToLowerInvariant() = "collierb@leoncountyfl.gov" -> true
          | _ -> false
        with 
        | _ -> false
    )
    |> Array.rev


let writeIncidentPages(incidentId:int) = 
        [|

            DomUrl $"https://leoncountyfl.samanage.com/incidents/{incidentId}.json" 
            DomUrl $"https://leoncountyfl.samanage.com/incidents/{incidentId}/service_monitor_statistic.json" |> DomUrl.AddQueryParameter "is_portal_mode" false
            DomUrl $"https://leoncountyfl.samanage.com/incidents/{incidentId}/comments.json"
            |> DomUrl.AddQueryParameter "unmasked" false
            // |> DomUrl.AddQueryParameter "page" 1
            // |> DomUrl.AddQueryParameter "per_page" 20
            |> DomUrl.AddQueryParameter "is_portal_mode" false
            DomUrl $"https://leoncountyfl.samanage.com/incidents/{incidentId}/related_itsms/related_items.json"
            |> DomUrl.AddQueryParameter "collections[]" "incidents"
            |> DomUrl.AddQueryParameter "collections[]" "problems"
            |> DomUrl.AddQueryParameter "collections[]" "changes"
            |> DomUrl.AddQueryParameter "collections[]" "releases"
            |> DomUrl.AddQueryParameter "collections[]" "hardwares"
            |> DomUrl.AddQueryParameter "collections[]" "mobiles"
            |> DomUrl.AddQueryParameter "collections[]" "other_assets"
            |> DomUrl.AddQueryParameter "collections[]" "discovery_hardwares"
            |> DomUrl.AddQueryParameter "collections[]" "configuration_items"
            |> DomUrl.AddQueryParameter "collections[]" "solutions"
            |> DomUrl.AddQueryParameter "collections[]" "purchase_orders"
            |> DomUrl.AddQueryParameter "is_portal_mode" false

        |]

        |> Array.iter (fun incidentUrl -> incidentUrl.WriteAllJsonPaginated "page" )

// incidents |> Array.iter (fun myIncident ->  writeIncidentPages myIncident.Id)
// incidentsCreatedByMe |> Array.iter (fun myIncident ->  writeIncidentPages myIncident.Id)

// https://leoncountyfl.samanage.com/entity_general_info/181915404.json?object_type=incident&action_page_type=show&is_portal_mode=false

*)



(*
let assignedToMeDataSet = 
    {
        fileSets = 
                incidentsAssignedToMe
                |> Array.map (fun myIncident ->  IncidentFileSet.fromId myIncident.Id)
                |> Array.sortBy (fun incidentFileSet -> incidentFileSet.incidentLocalRepresentation.CreatedAt )
                |> Array.rev
    }
let createdByMeDataSet = 
    {
        fileSets = 
                incidentsCreatedByMe
                |> Array.map (fun myIncident ->  IncidentFileSet.fromId myIncident.Id)
                |> Array.sortBy (fun incidentFileSet -> incidentFileSet.incidentLocalRepresentation.CreatedAt )
                |> Array.rev

    }




let statusReportableIncidentsAssignedToMe  = assignedToMeDataSet.statusReportableDaysAgo -27
// incidentsCreatedThisMonth.fileSets |> Array.iter (fun fileSet -> fileSet.WriteAllIncidentPages() )







let myOpenIncidents = 
    statusReportableIncidentsAssignedToMe.fileSets
    |> Array.filter(fun fileSet -> 
        match fileSet.currentState.title with 
        ("Resolved" | "Closed") -> false 
        | _ -> true
        )
let myClosedIncidentDataSet = statusReportableIncidentsAssignedToMe.resolvedDaysAgo -27



html {
    _lang "en-US"

    head {
        meta {
            _charset "utf-8"
            _name "viewport"
            _content "width=device-width, initial-scale=1.0"
        }

        title "title"
    }

    body {
        header {
            h1 { $"Status Report ({DateTime.Now.lastWeek.IsoWeekNumber})" }
        }
        main {
            section {
                h2 { "Summary" }
                ul {
                    li { $"Closed Incidents: {myClosedIncidentDataSet.fileSets.Length}" }
                    li { $"Open Incidents: {myOpenIncidents.Length}" }
                }
            }
            article {

                header { h2 { $"Closed Incidents"}}

                for incidentFileSet in myClosedIncidentDataSet.fileSets do 
                        article {
                                    h3 { $"{incidentFileSet.incidentRemoteContent.name} ({incidentFileSet.currentState.title})"}
                                    ul { li { incidentFileSet.incidentRemoteContent.resolution_description } }
                                }

            }
            article {

                header { h2 { $"Open Incidents"}}

                for incidentFileSet in myOpenIncidents do 
                        article {
                                    h3 { $"{incidentFileSet.incidentRemoteContent.name} ({incidentFileSet.currentState.title})"}
                                    p { incidentFileSet.incidentRemoteContent.description }
                                }

            }

        }
        (*
        footer {
                  p {
                        sprintf "Generated %A" DateTime.Now
                    
                    }
                }
        *)
    }
} 
|> Render.toHtmlDocString
|> HtmlDocument.Parse
|> fun htmlDoc ->  File.WriteAllText( $@"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\BrowserAutomation\StatusReport\{DateTime.Now.IsoWeekNumber}.html", htmlDoc.ToString() )








*)














// TODO look into getting employees
// TODO find old api notes




// TODO automate logging in and getting access token


// page.GoTo NeoGov.employees.url
// page.GoTo MicrosoftGraph.explorer.url

































(*






let pageTime = new TimeSpan(0,0,9 * 888)
pageTime.Minutes


page.GoTo incidents.url

type RequestsSnapshot = 
    {
        requests: IRequest array 
    }
    member this.jsonRequests = 
                            this.requests
                            |> Seq.toArray
                            |> Array.filter (fun request ->
                                request.Response.headers |> Array.exists (fun (key,value) -> 
                                    match key,value with 
                                    |"content-type", contentType when contentType.Contains "json" -> request.Response.JsonText().IsSome
                                    | _ -> false
        
                                    )
                            )

let solarWindsRequests = 
    {

        requests = finishedRequests |> Seq.filter (fun request -> request.DomUrl.Host = "leoncountyfl.samanage.com") |> Seq.toArray

    }
let groupedRequests = solarWindsRequests.jsonRequests |> Array.groupBy (fun requests -> requests.DomUrl.Pathname.TrimStart('/'))
let path, requests = groupedRequests[0]
requests
let jsonTexts = 
    groupedRequests
    |> Array.map (fun (path,requests) -> 
            path, requests  |> Array.map (fun request -> request.Response.JsonText().Value)
    )


let lastRequest =  solarWindsRequests.jsonRequests |> Array.last
lastRequest.DomUrl
let anchorElements = page.anchorElements

anchorElements |> Array.randomSample 3
anchorElements[0].javascriptElement.Click()



*)
