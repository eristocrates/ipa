// TODO study https://j-alexander.github.io/entry/2016/12/23/jsonpath-queries-using-fsharpdata
open System

open System.Threading.Tasks
open Microsoft.FSharp.Reflection

#r "nuget: Microsoft.Extensions.Logging"
open Microsoft.Extensions.Logging


#r "nuget: FSharp.Data"
open FSharp.Data

#r "nuget: dotNetRdf"

open VDS.RDF
open VDS.RDF.Parsing
open VDS.RDF.Writing


#r "nuget: ChromeProtocol.Core"
#r "nuget: ChromeProtocol.Domains"
#r "nuget: ChromeProtocol.Runtime"

open ChromeProtocol
open ChromeProtocol.Runtime.Messaging.WebSockets

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Microsoft\Edge\DevTools\EdgeDevToolsProtocol.fsx"

#load @"C:\Secret\TwitterSecrets.fsx"



let inline xor a b = (a || b) && not (a && b)

module JsonValue =
    let rec PropertyKeys (jsonValue: JsonValue) =
        match jsonValue with
        | JsonValue.Record properties -> properties |> Array.map fst
        | JsonValue.Array elements -> elements |> Array.collect PropertyKeys |> Array.distinct
        | _ -> [||]

    let rec PropertyValues (jsonValue: JsonValue) =
        match jsonValue with
        | JsonValue.Record properties -> properties |> Array.map snd
        | JsonValue.Array elements -> elements |> Array.collect PropertyValues
        | _ -> [||]

    let rec GrandPropertyKeys (jsonValue: JsonValue) =
        match jsonValue with
        | JsonValue.Record properties -> properties |> Array.map snd |> Array.collect PropertyKeys |> Array.distinct
        | JsonValue.Array elements -> elements |> Array.collect GrandPropertyKeys |> Array.distinct
        | _ -> [||]

    let Kind (jsonValue: JsonValue) =
        let (caseInfo, _) = FSharpValue.GetUnionFields(jsonValue, typeof<JsonValue>)
        caseInfo.Name

    let rec PropertyArray propertyName jsonValue =
        match jsonValue with
        | JsonValue.Record properties ->
            properties
            |> Array.choose (fun (key, value) -> if key = propertyName then Some value else None)
        | JsonValue.Array elements -> elements |> Array.collect (PropertyArray propertyName)
        | _ -> [||]

    let PropertiesArray propertyName jsonValues =
        jsonValues |> Array.collect (PropertyArray propertyName)


type JsonValue with
    member this.PropertyKeys = this |> JsonValue.PropertyKeys

    member this.PropertyValues = this |> JsonValue.PropertyValues

    member this.GrandPropertyKeys = this |> JsonValue.GrandPropertyKeys

    member this.Kind = this |> JsonValue.Kind

    member this.AsArray =
        match this with
        | JsonValue.Array values -> values
        | _ -> [||]

    member this.AsRecord =
        match this with
        | JsonValue.Record properties -> properties
        | _ -> [||]

    member this.Properties = this.AsRecord

    member this.PropertyArray(propertyName: string) =
        JsonValue.PropertyArray propertyName this





type 'T ``[]`` with

    member this.PropertyKeys =
        match box this with
        | :? (JsonValue array) as values -> values |> Array.collect JsonValue.PropertyKeys |> Array.distinct
        | _ -> [||]

    member this.PropertyValues =
        match box this with
        | :? (JsonValue array) as values -> values |> Array.collect JsonValue.PropertyValues
        | _ -> [||]

    member this.GrandPropertyKeys =
        match box this with
        | :? (JsonValue array) as values -> values |> Array.collect JsonValue.GrandPropertyKeys |> Array.distinct
        | _ -> [||]

    member this.Kinds =
        match box this with
        | :? (JsonValue array) as values -> values |> Array.map JsonValue.Kind |> Array.distinct
        | _ -> [||]




let (?>) (jsonObjects: JsonValue array) (propertyName: string) =
    JsonValue.PropertiesArray propertyName jsonObjects
(*

EdgeDevToolsProtocol.protocol.jsonschema.JsonValue.Kind

EdgeDevToolsProtocol.protocol.jsonschema.JsonValue.PropertyKeys
EdgeDevToolsProtocol.protocol.jsonschema.JsonValue?properties?domains.PropertyKeys
EdgeDevToolsProtocol.protocol.jsonschema.JsonValue?properties?domains?items?properties.PropertyKeys


EdgeDevToolsProtocol.protocol.json.JsonValue?domains.PropertyKeys
EdgeDevToolsProtocol.protocol.json.JsonValue?domains.Kind


let types = EdgeDevToolsProtocol.protocol.json.JsonValue?domains.AsArray ?> "types" 



types
|> Array.collect JsonValue.PropertyKeys |> Array.distinct



EdgeDevToolsProtocol.protocol.json.JsonValue |> JsonPath.find "$.domains[].types[0].properties[8].name"
EdgeDevToolsProtocol.protocol.jsonschema.JsonValue?properties?domains.AsArray.Keys




EdgeDevToolsProtocol.protocol.json.JsonValue?domains.Keys ?> domain

let domain_items = EdgeDevToolsProtocol.protocol.json.JsonValue?domains.Keys

let domain_items =
    EdgeDevToolsProtocol.protocol.json.JsonValue?domains.JsonValues.Keys

domain_items |> Array.map (fun domain_item -> domain_item.Kind)

// |> Array.filter (fun domain_item -> domain_item.IsRecord)



*)
















(*
// Must run before the first System.Uri is created.
let configureIriSupport () =
    let uriSection = ConfigurationManager.GetSection("uri") :?> UriSection

    uriSection.IriParsing.Enabled <- true
    uriSection.Idn.Enabled <- UriIdnScope.All

configureIriSupport ()

*)
module Store =
    let compressingturtlewriter = CompressingTurtleWriter(TurtleSyntax.W3C)

    let default_graph = new ThreadSafeGraph()

    module Assert =
        let triples (triplesToAssert: Triple array) =

            Console.WriteLine($"triples generated = {triplesToAssert.Length}")
            triplesToAssert |> Array.iter (fun t -> Console.WriteLine(t.ToString()))

            let changed = default_graph.Assert(triplesToAssert)

            Console.WriteLine($"assert changed = {changed}")
            Console.WriteLine($"graph count after = {default_graph.Triples.Count}")

    module Save =
        let ttl (path: string) (graph: IGraph) =

            compressingturtlewriter.HighSpeedModePermitted <- false
            compressingturtlewriter.PrettyPrintMode <- true

            compressingturtlewriter.Save(graph, path)

let namespace_maps =
    Map.ofArray
        [|

           "as", "https://www.w3.org/ns/activitystreams#"
           "csvw", "http://www.w3.org/ns/csvw#"
           "dcat", "http://www.w3.org/ns/dcat#"
           "dqv", "http://www.w3.org/ns/dqv#"
           "duv", "https://www.w3.org/ns/duv#"
           "grddl", "http://www.w3.org/2003/g/data-view#"
           "jsonld", "http://www.w3.org/ns/json-ld#"
           "ldp", "http://www.w3.org/ns/ldp#"
           "ma", "http://www.w3.org/ns/ma-ont#"
           "oa", "http://www.w3.org/ns/oa#"
           "odrl", "http://www.w3.org/ns/odrl/2/"
           "org", "http://www.w3.org/ns/org#"
           "owl", "http://www.w3.org/2002/07/owl#"
           "prov", "http://www.w3.org/ns/prov#"
           "qb", "http://purl.org/linked-data/cube#"
           "rdf", "http://www.w3.org/1999/02/22-rdf-syntax-ns#"
           "rdfa", "http://www.w3.org/ns/rdfa#"
           "rdfs", "http://www.w3.org/2000/01/rdf-schema#"
           "rif", "http://www.w3.org/2007/rif#"
           "rr", "http://www.w3.org/ns/r2rml#"
           "sd", "http://www.w3.org/ns/sparql-service-description#"
           "skos", "http://www.w3.org/2004/02/skos/core#"
           "skosxl", "http://www.w3.org/2008/05/skos-xl#"
           "ssn", "http://www.w3.org/ns/ssn/"
           "sosa", "http://www.w3.org/ns/sosa/"
           "time", "http://www.w3.org/2006/time#"
           "void", "http://rdfs.org/ns/void#"
           "wdr", "http://www.w3.org/2007/05/powder#"
           "wdrs", "http://www.w3.org/2007/05/powder-s#"
           "xhv", "http://www.w3.org/1999/xhtml/vocab#"
           "xml", "http://www.w3.org/XML/1998/namespace"
           "xsd", "http://www.w3.org/2001/XMLSchema#"
           "", "http://www.example.org/"
           "twitterApi", "https://x.com/i/api#"
           "twitter", "https://x.com/"
           "cdp", "http://chromedevtools.github.io/devtools-protocol#"
           "cdpNetwork", "https://chromedevtools.github.io/devtools-protocol/tot/Network/#"
           "cdpPage", "https://chromedevtools.github.io/devtools-protocol/tot/Page/#"
           "mime_application", "https://w3id.org/uri4uri/mime/application/"
           "foaf", "http://xmlns.com/foaf/0.1/"
           "sioc", "http://rdfs.org/sioc/ns#"
           "sioc_types", "http://rdfs.org/sioc/types#"
           "sioc_services", "http://rdfs.org/sioc/services#"
           "sioc_actions", "http://rdfs.org/sioc/actions#"

           |]

namespace_maps
|> Map.iter (fun prefix uri -> Store.default_graph.NamespaceMap.AddNamespace(prefix, UriFactory.Create(uri)))

let prefixed_name (namespace_prefix: string) (local_name: string) =
    let low_lined_name = local_name.Replace(" ", "_")
    Store.default_graph.CreateUriNode($"{namespace_prefix}:{low_lined_name}")


module rdf =
    let prefix = prefixed_name "rdf"

let a = rdf.prefix "type"

module foaf =
    let prefix = prefixed_name "foaf"
    let OnlineAccount = prefix "OnlineAccount"

module twitter =
    let prefix = prefixed_name "twitter"
    let profile (screen_name: string) = prefix screen_name
    let rest_id = prefix "rest_id"
    let community_member = prefix "community_member"
    let Community = prefix "Community"
    let User = prefix "User"
    let name = prefix "name"
    let description = prefix "description"
    let avatar_image_url = prefix "avatar_image_url"

module sioc =
    let prefix = prefixed_name "sioc"

module twitterApi =
    let prefix = prefixed_name "twitterApi"
    let UserByScreenName = prefix "UserByScreenName"
    let HomeTimeline = prefix "HomeTimeline"
    let CommunityQuery = prefix "CommunityQuery"
    let CommunitiesFetchOneQuery = prefix "CommunitiesFetchOneQuery"
    let CommunitiesRankedTimeline = prefix "CommunitiesRankedTimeline"
    let CommunitiesExploreTimeline = prefix "CommunitiesExploreTimeline"
    let CommunityTweetsTimeline = prefix "CommunityTweetsTimeline"
    let membersSliceTimeline_Query = prefix "membersSliceTimeline_Query"
    let UserTweets = prefix "UserTweets"
    let ProfileSpotlightsQuery = prefix "ProfileSpotlightsQuery"

module colon =
    let prefix = prefixed_name ""
    let this_ = prefix "this"
    let example = prefix "example"

module cdp =
    let prefix = prefixed_name "cdp"
    let ResponseReceived = prefix "ResponseReceived"
    let requestWillBeSent = prefix "requestWillBeSent"
    let responseReceived = prefix "responseReceived"
    let DocumentURL = prefix "DocumentURL"
    let Document = prefix "Document"
    let RequestId = prefix "RequestId"
    let Loader = prefix "Loader"
    let LoaderId = prefix "LoaderId"
    let Monotonic_Timestamp = prefix "Monotonic_Timestamp"
    let Type = prefix "Type"
    let Url = prefix "Url"
    let Response = prefix "Response"
    let Request = prefix "Request"
    let RequestURL = prefix "RequestURL"
    let ResourceType = prefix "ResourceType"
    let Event = prefix "Event"
    let Request_from_value (request_id: string) = prefix $"{request_id}"
    let Frame_from_value (frame_id: string) = prefix $"{frame_id}"
    let Loader_from_value (loader_id: string) = prefix $"{loader_id}"
    let ResourceType_from_value (resource_type: string) = prefix $"{resource_type}"
    let HasExtraInfo = prefix "HasExtraInfo"
    let HasUserGesture = prefix "HasUserGesture"
    let FrameId = prefix "FrameId"
    let LoadingFinished = prefix "LoadingFinished"
    let Frame = prefix "Frame"
    let FrameIdType = prefix "FrameIdType"
    let mimeType = prefix "mimeType"

module cdpPage =
    let prefix = prefixed_name "cdpPage"

    module type_ =
        let Frame = prefix "type-Frame"
        let FrameId = prefix "type-FrameId"

module cdpNetwork =
    let prefix = prefixed_name "cdpNetwork"

    module event =
        let responseReceived = prefix "event-responseReceived"
        let requestWillBeSent = prefix "event-requestWillBeSent"
        let loadingFinished = prefix "event-loadingFinished"

    module type_ =
        let Request = prefix "type-Request"
        let Response = prefix "type-Response"
        let Loader = prefix "type-Loader"
        let LoaderId = prefix "type-LoaderId"
        let ResourceType = prefix "type-ResourceType"

type ObjectList = ObjectList of INode list
type PredicateObjectList = PredicateObjectList of Predicate * ObjectList

and Predicate =
    | Predicate of INode

    member this.objectList(objects: INode list) =
        PredicateObjectList(this, ObjectList objects)

let PredicateObject (predicate: Predicate) (object_: INode) =
    PredicateObjectList(predicate, ObjectList [ object_ ])

type Subject =
    | Subject of INode
    | BlankSubject of IBlankNode

    member this.predicate(predicate: INode) = Predicate(predicate)

let test_blank = Store.default_graph.CreateBlankNode()

let triples (subject: Subject) (predicate_object_lists: PredicateObjectList list) =
    let subject_node =
        match subject with
        | Subject node -> node
        | BlankSubject blankNode -> blankNode :> INode

    predicate_object_lists
    |> List.collect (fun (PredicateObjectList(Predicate predicate, ObjectList objects)) ->
        objects |> List.map (fun obj -> new Triple(subject_node, predicate, obj)))



let triple (cursubject: INode) (curpredicate: INode) (curobject: INode) =
    new Triple(cursubject, curpredicate, curobject)

let triple_test = triple colon.this_ a colon.example

let triples_test =
    triples (Subject colon.this_) [ PredicateObjectList(Predicate a, ObjectList [ colon.example ]) ]


let cursubject = Subject test_blank

let curpredicate = cursubject.predicate a
let predicate_object_list = curpredicate.objectList [ colon.example ]

let result = triples cursubject [ predicate_object_list ]



let lit (value: obj) =
    Store.default_graph.CreateLiteralNode(string value)

let typedLit (value: obj) (datatypePrefix: string) (datatypeLocal: string) =
    let string_value =
        match datatypeLocal with
        | "boolean" -> (string value).ToLower()
        | _ -> string value

    Store.default_graph.CreateLiteralNode(string_value, (prefixed_name datatypePrefix datatypeLocal).Uri)


let xsd_true = typedLit "true" "xsd" "boolean" :> INode
let xsd_false = typedLit "false" "xsd" "boolean" :> INode


let optLit (value: 'a option) =
    match value with
    | Some v -> Store.default_graph.CreateLiteralNode(string v) :> INode
    | None -> Store.default_graph.CreateLiteralNode("") :> INode

let nullableLit (value: Nullable<'a>) =
    if value.HasValue then
        Store.default_graph.CreateLiteralNode(string value.Value) :> INode
    else
        Store.default_graph.CreateLiteralNode("") :> INode


let resync_task (task: Task<_>) =
    task |> Async.AwaitTask |> Async.RunSynchronously

let id_from_guid (guid: Guid) = guid.ToString("N").ToUpperInvariant()

type ConsoleLogger() =
    interface ILogger with
        member _.BeginScope(state) = null
        member _.IsEnabled(_) = true
        member _.Log(logLevel, _, state, _, _) = printfn "[%A] %O" logLevel state



/// https://source.chromium.org/chromium/chromium/src/+/main:content/browser/devtools/devtools_agent_host_impl.cc?ss=chromium&q=f:devtools%20-f:out%20%22::kTypeTab%5B%5D%22
[<Struct>]
[<RequireQualifiedAccess>]
type DevToolKind =
    | assistive_technology
    | auction_worklet
    | browser
    | browser_ui
    | iframe
    | other
    | page
    | service_worker
    | shared_storage_worklet
    | shared_worker
    | tab
    | webview
    | worker
    | worklet

type DevTool =
    {

      client: DefaultProtocolClient
      kind: DevToolKind
      targetId: string

    }


    static member debug_browser(browser_debugging_endpoint: Uri) =
        let browser =
            {

              client = new DefaultProtocolClient(browser_debugging_endpoint, new ConsoleLogger())
              kind = DevToolKind.browser
              targetId = ""


            }

        browser.client.ConnectAsync() |> Async.AwaitTask |> Async.RunSynchronously
        browser

    static member debug_page(page_id: string) =
        let page_debugging_endpoint =
            EdgeDevToolsProtocol.list.json ()
            |> Array.find (fun target -> id_from_guid target.Id = page_id)
            |> fun target -> target.WebSocketDebuggerUrl


        let page =
            {

              client = new DefaultProtocolClient(new Uri(page_debugging_endpoint), new ConsoleLogger())
              kind = DevToolKind.page
              targetId = page_id

            }

        page.client.ConnectAsync() |> Async.AwaitTask |> Async.RunSynchronously

        let PageEnableResponse =
            page.client.SendCommandAsync(Domains.Page.Enable()) |> resync_task

        let NetworkEnableResponse =
            page.client.SendCommandAsync(Domains.Network.Enable()) |> resync_task

        let DOMEnableResponse =
            page.client.SendCommandAsync(Domains.DOM.Enable()) |> resync_task

        let RuntimeEnableResponse =
            page.client.SendCommandAsync(Domains.Runtime.Enable()) |> resync_task


        page





(*
let distinct_types =
    EdgeDevToolsProtocol.list.json ()
    |> Array.map (fun target ->

        target.Type)
    |> Array.distinct
*)

(*
let distinct_properties =
    EdgeDevToolsProtocol.list.json ()
    |> Array.collect (fun target ->
        let target_id = id_from_guid target.Id

        target.JsonValue.Properties() |> Array.map (fun (key, value) -> key))
    |> Array.distinct

let static_members =
    distinct_properties
    |> Array.map (fun property_name ->
        let static_member =
            match property_name with
            | "type" -> $"static member {property_name}_ = PropertyKey \"{property_name}\""
            | _ -> $"static member {property_name} = PropertyKey \"{property_name}\""

        $"    {static_member}")
    |> String.concat "\n"

let from_def =
    """
    static member from_string(input_string: string) =
        match input_string with
"""

let from_strings =
    distinct_properties
    |> Array.map (fun property_name ->
        let from_string =
            match property_name with
            | "type" -> $"| \"{property_name}\" -> PropertyKey.{property_name}_"
            | _ -> $"| \"{property_name}\" -> PropertyKey.{property_name}"

        $"        {from_string}"

    )
    |> String.concat "\n"

let property_key_codegen =
    $$"""
[<Struct>]
[<RequireQualifiedAccess>]
type PropertyKey =
    | PropertyKey of string
{{static_members}}

    static member from_string(input_string: string) =
        match input_string with
{{from_strings}}
            | _ -> failwith $"Unknown property key: {input_string}"
"""
    |> clip


*)

[<Struct>]
[<RequireQualifiedAccess>]
type PropertyKey =
    | PropertyKey of string

    static member description = PropertyKey "description"
    static member devtoolsFrontendUrl = PropertyKey "devtoolsFrontendUrl"
    static member faviconUrl = PropertyKey "faviconUrl"
    static member id = PropertyKey "id"
    static member title = PropertyKey "title"
    static member type_ = PropertyKey "type"
    static member url = PropertyKey "url"
    static member webSocketDebuggerUrl = PropertyKey "webSocketDebuggerUrl"

    static member from_string(input_string: string) =
        match input_string with
        | "description" -> PropertyKey.description
        | "devtoolsFrontendUrl" -> PropertyKey.devtoolsFrontendUrl
        | "faviconUrl" -> PropertyKey.faviconUrl
        | "id" -> PropertyKey.id
        | "title" -> PropertyKey.title
        | "type" -> PropertyKey.type_
        | "url" -> PropertyKey.url
        | "webSocketDebuggerUrl" -> PropertyKey.webSocketDebuggerUrl
        | _ -> failwith $"Unknown property key: {input_string}"

[<Struct>]
type TargetId_PropertyKey =
    {

      target_id: string
      property_key: PropertyKey

    }

(*
let update_list_collection () =
    EdgeDevToolsProtocol.list.json ()
    |> Array.collect (fun target ->
        let target_id = id_from_guid target.Id

        target.JsonValue.Properties()
        |> Array.map (fun (key, value) ->
            let target_id = id_from_guid target.Id
            let property_name = key
            let property_value = value


            printfn "TargetId: %s, PropertyKey: %s" target_id property_name

            targets.AddOrUpdate(
                { target_id = target_id
                  property_key = PropertyKey.from_string property_name },
                property_value.AsString()
            )

        )

    )

*)


module Browser =
    /// https://chromedevtools.github.io/devtools-protocol/tot/Browser/#method-getVersion
    let getVersion (devtool: DevTool) =

        devtool.client.SendCommandAsync(Domains.Browser.GetVersion()) |> resync_task


module Page =
    let navigate (uri: Uri) (devtool: DevTool) =
        let iri = Store.default_graph.CreateUriNode(uri)
        let url = typedLit uri.OriginalString "xsd" "anyURI"

        Store.default_graph.Assert(
            [|

               triple iri cdp.DocumentURL url

               |]
        )
        |> ignore

        devtool.client.SendCommandAsync(Domains.Page.Navigate(uri.OriginalString))
        |> resync_task

module Network =

    let RequestIds () =
        Store.default_graph.GetTriplesWithPredicate(cdp.RequestId)
        |> Seq.map (fun triple ->

            let request_id_literal = triple.Object :?> LiteralNode
            request_id_literal.Value

        )

    let Documents () =
        Store.default_graph.GetTriplesWithPredicate(cdp.DocumentURL)
        |> Seq.map (fun triple ->

            let url_literal = triple.Object :?> LiteralNode
            url_literal.Value

        )

    let is_document (url: string) =
        Documents() |> Seq.exists (fun document_url -> url = document_url)

    let is_twitter_endpoint (endpoint: string) =
        match endpoint with
        | "UserByScreenName"
        | "HomeTimeline"
        | "CommunityQuery"
        | "CommunitiesFetchOneQuery"
        | "CommunitiesRankedTimeline"
        | "CommunitiesExploreTimeline"
        | "CommunityTweetsTimeline"
        | "membersSliceTimeline_Query"
        | "UserTweets"
        | "ProfileSpotlightsQuery" -> true
        | _ -> false

    let is_graphql (url: string) =
        match url with
        | _ when url.Contains("graphql") ->
            let uri = new Uri(url)
            let lastSegment = (uri.Segments |> Array.last).TrimEnd('/')

            match lastSegment with
            | endpoint_local_name when lastSegment |> is_twitter_endpoint -> true
            | _ -> false
        | _ -> false

    let escape (value: string) = Uri.EscapeDataString(value)

    let safeUriNodeFromString (s: string) =
        try
            Store.default_graph.CreateUriNode(UriFactory.Create(s)) :> INode
        with ex ->
            Console.Error.WriteLine($"Could not create URI node from: {s}")
            Console.Error.WriteLine(ex.ToString())
            Store.default_graph.CreateUriNode(UriFactory.Create(escape s)) :> INode




    let responseReceivedSubject (requestId: string) =
        Store.default_graph.CreateUriNode(UriFactory.Create($"urn:cdp:network:responseReceived:{escape requestId}"))

    let responseSubject (requestId: string) =
        Store.default_graph.CreateUriNode(UriFactory.Create($"urn:cdp:network:response:{escape requestId}"))

    let requestSubject (requestId: string) =
        Store.default_graph.CreateUriNode(UriFactory.Create($"urn:cdp:network:request:{escape requestId}"))


    let subscribe_refresh (devtool: DevTool) =

        let request_will_be_sent =
            devtool.client.SubscribeAsync<Domains.Network.RequestWillBeSent>(fun requestWillBeSent ->

                task {
                    try

                        if
                            (requestWillBeSent.Request.Url |> is_document)
                            |> xor (requestWillBeSent.Request.Url |> is_graphql)
                        then


                            Console.WriteLine("\n\n\n---- Network.RequestWillBeSent ----")
                            Console.WriteLine($"{requestWillBeSent.RequestId}: {requestWillBeSent.DocumentURL}")
                            Console.WriteLine($"graph count before = {Store.default_graph.Triples.Count}")

                            let frame = cdp.Frame_from_value requestWillBeSent.FrameId.Value
                            let frame_id = typedLit requestWillBeSent.FrameId.Value "xsd" "string"

                            let has_user_gesture =
                                typedLit requestWillBeSent.HasUserGesture "xsd" "boolean" :> INode

                            let loader = cdp.Loader_from_value requestWillBeSent.LoaderId.Value
                            let loader_id = typedLit requestWillBeSent.LoaderId.Value "xsd" "string"
                            let request = cdp.Request_from_value requestWillBeSent.RequestId.Value
                            let request_id = typedLit requestWillBeSent.RequestId.Value "xsd" "string"
                            let request_url = typedLit requestWillBeSent.Request.Url "xsd" "anyURI"

                            let graphql_iri =

                                let uri = new Uri(requestWillBeSent.Request.Url)

                                let lastSegment = (uri.Segments |> Array.last).TrimEnd('/')
                                twitterApi.prefix lastSegment

                            let document_iri =
                                Store.default_graph.CreateUriNode(UriFactory.Create requestWillBeSent.Request.Url)


                            let timestamp = typedLit requestWillBeSent.Timestamp.Value "xsd" "float"
                            let resource_type = cdp.ResourceType_from_value requestWillBeSent.Type.Value
                            let request_will_be_sent = Store.default_graph.CreateBlankNode()



                            let triplesToAssert =
                                if requestWillBeSent.Request.Url.Contains "graphql" then
                                    [|

                                       // triple loader a cdpNetwork.type_.Loader
                                       triple loader cdp.Request request
                                       triple request a graphql_iri
                                       triple request cdp.RequestId request_id

                                       |]
                                else
                                    [|

                                       triple document_iri a cdp.Document
                                       triple document_iri cdp.Loader loader
                                       // triple loader a cdpNetwork.type_.Loader

                                       |]

                            triplesToAssert |> Store.Assert.triples


                    with ex ->
                        Console.Error.WriteLine("FAILED inside Network.requestWillBeSent subscription")
                        Console.Error.WriteLine(ex.ToString())


                }
                :> Task)

        (*
        let response_received =
            devtool.client.SubscribeAsync<Domains.Network.ResponseReceived>(fun responseReceived ->
                task {
                    try
                        let uri = new Uri(responseReceived.Response.Url)
                        let lastSegment = (uri.Segments |> Array.last).TrimEnd('/')

                        match lastSegment with
                        | endpoint_local_name when uri.OriginalString |> is_graphql ->
                            Console.WriteLine("\n\n\n---- Network.ResponseReceived ----")
                            Console.WriteLine($"{responseReceived.RequestId}: {responseReceived.Response.Url}")
                            Console.WriteLine($"graph count before = {Store.default_graph.Triples.Count}")

                            let frame = cdp.Frame_from_value responseReceived.FrameId.Value
                            let frame_id = typedLit responseReceived.FrameId.Value "xsd" "string"

                            let has_extra_info = typedLit responseReceived.HasExtraInfo "xsd" "boolean" :> INode

                            let loader = cdp.Loader_from_value responseReceived.LoaderId.Value
                            let loader_id = typedLit responseReceived.LoaderId.Value "xsd" "string"
                            let request = cdp.Request_from_value responseReceived.RequestId.Value
                            let request_id = typedLit responseReceived.RequestId.Value "xsd" "string"

                            let graphql = twitterApi.prefix endpoint_local_name

                            let response_mime_type = typedLit responseReceived.Response.MimeType "xsd" "string"
                            let timestamp = typedLit responseReceived.Timestamp.Value "xsd" "float"
                            let resource_type = cdp.ResourceType_from_value responseReceived.Type.Value
                            let response_received = Store.default_graph.CreateBlankNode()


                            let triplesToAssert =
                                [|

                                   triple loader a cdpNetwork.type_.Loader
                                   triple request cdp.Response graphql

                                   // triple graphql cdp.ResourceType resource_type
                                   // triple graphql cdp.mimeType response_mime_type
                                   // triple graphql cdp.Event response_received


                                   // triple frame a cdpPage.type_.Frame
                                   // triple frame cdp.FrameId frame_id

                                   // triple network_loader a cdpNetwork.type_.Loader
                                   // triple network_loader cdp.LoaderId loader_id

                                   // triple request a cdpNetwork.type_.Request
                                   // triple request cdp.RequestId request_id


                                   // triple response_received a cdpNetwork.event.responseReceived
                                   // triple response_received cdp.Monotonic_Timestamp timestamp
                                   // triple response_received cdp.Frame frame
                                   // triple response_received cdp.Request request
                                   // triple response_received cdp.HasExtraInfo has_extra_info
                                   // triple response_received cdp.Loader network_loader





                                   |]

                            triplesToAssert |> Store.Assert.triples

                        | _ -> ()

                    with ex ->
                        Console.Error.WriteLine("FAILED inside Network.responseReceived subscription")
                        Console.Error.WriteLine(ex.ToString())


                }
                :> Task)




        let loading_finished =
            devtool.client.SubscribeAsync<Domains.Network.LoadingFinished>(fun loadingFinished ->
                task {
                    try
                        if
                            RequestIds()
                            |> Seq.exists (fun request_id -> loadingFinished.RequestId.Value = request_id)
                        then
                            Console.WriteLine("\n\n\n---- Network.LoadingFinished ----")
                            Console.WriteLine($"{loadingFinished.RequestId}")
                            Console.WriteLine($"graph count before = {Store.default_graph.Triples.Count}")

                            let request = cdp.Request_from_value loadingFinished.RequestId.Value
                            let request_id = typedLit loadingFinished.RequestId.Value "xsd" "string"


                            let triplesToAssert =
                                [|

                                   triple request cdp.LoadingFinished xsd_true
                                   // triple request cdp.RequestId request_id

                                   |]

                            Store.Assert.triples triplesToAssert


                    with ex ->
                        Console.Error.WriteLine("FAILED inside Network.loadingFinished subscription")
                        Console.Error.WriteLine(ex.ToString())


                }
                :> Task)

        *)


        let reload_request_result =
            devtool.client.SendCommandAsync(Domains.Page.Reload()) |> resync_task

        devtool





module Target =
    /// https://chromedevtools.github.io/devtools-protocol/tot/Target/#method-getTargets
    let getTargets (devtool: DevTool) =
        let result =
            devtool.client.SendCommandAsync(Domains.Target.GetTargets()) |> resync_task

        result.TargetInfos

    /// https://chromedevtools.github.io/devtools-protocol/tot/Target/#method-createTarget
    let createTarget (uri: Uri) (devtool: DevTool) =
        let iri = Store.default_graph.CreateUriNode(uri)
        let url = typedLit uri.OriginalString "xsd" "anyURI"

        Store.default_graph.Assert(
            [|

               triple iri cdp.DocumentURL url

               |]
        )
        |> ignore

        let response =
            devtool.client.SendCommandAsync(Domains.Target.CreateTarget(uri.OriginalString))
            |> resync_task



        // update_list_collection () |> ignore


        (*
        let pageWebSocketDebuggerUri =
            let raw_uri =
                targets.Item
                    { target_id = response.TargetId.Value
                      property_key = PropertyKey.webSocketDebuggerUrl }

            result'from_parse URI.parse OnInput raw_uri

*)
        DevTool.debug_page response.TargetId.Value


    let Open_Link_in_New_Tab (uri: Uri) (devtool: DevTool) = createTarget uri devtool

let edge_endpoint = new Uri(EdgeDevToolsProtocol.version.json.WebSocketDebuggerUrl)


























































let edge = DevTool.debug_browser edge_endpoint


let test_uri = new Uri("https://x.com/home")

let test_page = edge |> Target.createTarget test_uri |> Network.subscribe_refresh




let inputScreenNames =
    [|

       "AngelEyes11357"

       |]

module https =
    module twitter =
        module com =
            let uri = new Uri "https://x.com"

            module home =
                let uri = new Uri $"https://x.com/home"

            module i =
                module communities =
                    let uri = new Uri $"https://x.com/i/communities"

                    let community (community_id: string) =
                        new Uri $"https://x.com/i/communities/{community_id}"

                module flow =
                    module login =
                        let uri = new Uri "https://x.com/i/flow/login"

            let profile_from_screen_name (screen_name: string) = new Uri $"https://x.com/{screen_name}"


let response =
    test_page
    |> Page.navigate (https.twitter.com.profile_from_screen_name "AngelEyes11357")

type TwitterUser =
    {

      name: string
      screen_name: string
      description: string
      created_at: string
      rest_id: int64
      avatar'image_url: string
      is_blue_verified: bool
      community_uri_strings: string array

    }

type MassBlockTwitterUser =
    {

      id: int64
      screen_name: string
      name: string
      description: string
      profile_image_url: string

    }



module HomeTimeline =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\HomeTimeline.json"

    let json (text: string) = JsonProvider<filePath>.Parse(text)

module CommunityQuery =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\CommunityQuery.json"

    let json (text: string) = JsonProvider<filePath>.Parse(text)

module CommunitiesFetchOneQuery =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\CommunitiesFetchOneQuery.json"

    let json (text: string) = JsonProvider<filePath>.Parse(text)

module CommunitiesRankedTimeline =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\CommunitiesRankedTimeline.json"

    let json (text: string) = JsonProvider<filePath>.Parse(text)

module CommunitiesExploreTimeline =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\CommunitiesExploreTimeline.json"

    let json (text: string) = JsonProvider<filePath>.Parse(text)

module CommunityTweetsTimeline =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\CommunityTweetsTimeline.json"

    let json (text: string) = JsonProvider<filePath>.Parse(text)

module membersSliceTimeline_Query =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\membersSliceTimeline_Query.json"

    let json (text: string) = JsonProvider<filePath>.Parse(text)

module UserByScreenName =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\UserByScreenName.json"

    let json (text: string) = JsonProvider<filePath>.Parse(text)

module UserTweets =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\UserTweets.json"

    let json (text: string) = JsonProvider<filePath>.Parse(text)

module ProfileSpotlightsQuery =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\ProfileSpotlightsQuery.json"

    let json (text: string) = JsonProvider<filePath>.Parse(text)


















Store.default_graph.GetTriplesWithObject(twitterApi.UserByScreenName)
|> Seq.map (fun triple -> triple.Subject)
|> Seq.collect (fun request -> Store.default_graph.GetTriplesWithSubjectPredicate(request, cdp.RequestId))
|> Seq.map (fun triple ->

    let request_id_literal = triple.Object :?> LiteralNode
    request_id_literal.Value

)
|> Seq.map (fun request_id ->

    test_page.client.SendCommandAsync(Domains.Network.GetResponseBody(new Domains.Network.RequestIdType(request_id)))
    |> resync_task

)
|> Seq.map (fun json_response ->

    let userByScreenName = (UserByScreenName.json json_response.Body).Data.User.Result
    let screen_name = userByScreenName.Core.ScreenName
    let profile_iri = twitter.profile screen_name

    let name = typedLit userByScreenName.Core.Name "xsd" "string"
    let description = typedLit userByScreenName.Legacy.Description "xsd" "string"
    // let created_at = userByScreenName.Core.CreatedAt
    let rest_id = typedLit userByScreenName.RestId "xsd" "string"
    let avatar_image_url = typedLit userByScreenName.Avatar.ImageUrl "xsd" "anyURI"
    // let is_blue_verified = userByScreenName.IsBlueVerified

    Store.Assert.triples
        [|

           triple profile_iri a twitter.User
           triple profile_iri twitter.name name
           triple profile_iri twitter.description description
           triple profile_iri twitter.rest_id rest_id
           triple profile_iri twitter.avatar_image_url avatar_image_url

           |]


    Store.default_graph.GetTriplesWithObject(twitterApi.UserTweets)
    |> Seq.map (fun triple -> triple.Subject)
    |> Seq.collect (fun request -> Store.default_graph.GetTriplesWithSubjectPredicate(request, cdp.RequestId))
    |> Seq.map (fun triple ->

        let request_id_literal = triple.Object :?> LiteralNode
        request_id_literal.Value

    )
    |> Seq.map (fun request_id ->

        test_page.client.SendCommandAsync(
            Domains.Network.GetResponseBody(new Domains.Network.RequestIdType(request_id))
        )
        |> resync_task

    )
    |> Seq.map (fun json_response ->

        let user_tweets = UserTweets.json json_response.Body

        user_tweets.Data.User.Result.Timeline.Timeline.Instructions
        |> Array.Parallel.collect (fun instruction ->
            instruction.Entries
            |> Array.Parallel.choose (fun entry -> entry.Content.ItemContent

            )
            |> Array.Parallel.filter (fun itemContent ->
                itemContent.TweetResults.Result.Core.UserResults.Result.Core.ScreenName = screen_name)
            |> Array.Parallel.choose (fun itemContent -> itemContent.SocialContext)
            |> Array.Parallel.filter (fun socialContext -> socialContext.ContextType = "Community")
            |> Array.Parallel.map (fun socialContext -> socialContext.LandingUrl.Url)
            |> Array.distinct
            |> Array.map (fun community_url ->

                let community_uri = new Uri(community_url)
                let community_iri = Store.default_graph.CreateUriNode community_uri
                let community_anyURI = typedLit community_url "xsd" "anyURI"

                Store.Assert.triples
                    [|

                       triple community_iri a twitter.Community
                       triple community_iri cdp.DocumentURL community_anyURI
                       triple community_iri twitter.community_member profile_iri

                       |])

        )))






Store.default_graph
|> Store.Save.ttl
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Google\Chromium\DevTools\ChromeDevToolsProtocol.ttl"



// test_page |> Page.navigate (https.twitter.com.profile_from_screen_name "ClandestineMaga")
