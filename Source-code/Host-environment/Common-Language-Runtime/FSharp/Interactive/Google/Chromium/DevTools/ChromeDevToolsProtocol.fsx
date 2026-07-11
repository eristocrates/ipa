// TODO study https://www.w3.org/TR/Pointers-in-RDF10/#startEndPointerClass
// TODO consider https://www.w3.org/TR/HTTP-in-RDF10/#RequestClass/
// TODO study https://datatracker.ietf.org/doc/html/rfc2397
// TODO study https://jwosty.github.io/FSharp.Logf/
// TODO study https://j-alexander.github.io/entry/2016/12/23/jsonpath-queries-using-fsharpdata
open System

open System.Threading.Tasks

#r "nuget: Microsoft.Extensions.Logging"
open Microsoft.Extensions.Logging


#r "nuget: FSharp.Data"
open FSharp.Data

#r "nuget: dotNetRdf"

open VDS.RDF
open VDS.RDF.Storage
open VDS.RDF.Parsing
open VDS.RDF.Writing
open VDS.RDF.Query.Datasets


#r "nuget: ChromeProtocol.Core"
#r "nuget: ChromeProtocol.Domains"
#r "nuget: ChromeProtocol.Runtime"

open ChromeProtocol
open ChromeProtocol.Runtime.Messaging.WebSockets

#r "nuget: Unquote"
open Swensen.Unquote.Assertions

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Microsoft\Edge\DevTools\EdgeDevToolsProtocol.fsx"

#load @"C:\Secret\TwitterSecrets.fsx"

open System.Threading



let inline xor a b = (a || b) && not (a && b)












(*
// Must run before the first System.Uri is created.
let configureIriSupport () =
    let uriSection = ConfigurationManager.GetSection("uri") :?> UriSection

    uriSection.IriParsing.Enabled <- true
    uriSection.Idn.Enabled <- UriIdnScope.All

configureIriSupport ()

*)
module Persistence =
    let compressingturtlewriter =
        let writer = new CompressingTurtleWriter(TurtleSyntax.W3C)
        writer.HighSpeedModePermitted <- false
        writer.PrettyPrintMode <- true
        writer



    let default_graph = new ThreadSafeGraph()
    let triplestore = new ThreadSafeTripleStore()
    let dataset = new InMemoryDataset(triplestore, true)

    let segment_to_stem_path (last_segment: string) =
        $@"D:\Persistence\Twitter\{last_segment}"

    let uri_to_last_segment (uri: Uri) =
        (uri.Segments |> Array.last).TrimEnd('/')

    let string_to_uri (uri_string: string) =
        triplestore.UriFactory.Create(uri_string)

    let uri_to_base_uri (uri: Uri) =
        uri
        |> uri_to_last_segment
        |> segment_to_stem_path
        |> string_to_uri

    let string_to_base_uri (uri_string: string) =
        uri_string |> string_to_uri |> uri_to_base_uri

    let uri_to_iri (uri: Uri) = new UriNode(uri)
    let string_to_iri (name: string) = name |> string_to_uri |> uri_to_iri


    let vocabulary_graph =
        let graph_name =
            "https://eristocrates.dev/ontology/vocabulary/"
            |> string_to_iri

        let named_graph = new ThreadSafeGraph(graph_name)
        named_graph.BaseUri <- triplestore.UriFactory.Create(@"D:\Persistence\vocabulary")
        named_graph.UriFactory <- triplestore.UriFactory
        test <@ triplestore.Add(named_graph, true) @>
        // test <@ dataset.AddGraph(named_graph) @>
        named_graph

    let string_to_named_graph (graph_name_string: string) =
        let graph_name = graph_name_string |> string_to_iri

        if triplestore.HasGraph(graph_name) then
            triplestore[graph_name]
        else
            let named_graph = new ThreadSafeGraph(graph_name)
            named_graph.BaseUri <- graph_name_string |> string_to_base_uri
            named_graph.UriFactory <- triplestore.UriFactory
            named_graph.NamespaceMap.Import(vocabulary_graph.NamespaceMap)
            test <@ triplestore.Add(named_graph, true) @>
            // test <@ dataset.AddGraph(named_graph) @>
            named_graph

    let graphs () =
        dataset.GraphNames
        |> Seq.map (fun graph_name -> dataset[graph_name])


    let named_graph (graph_name_string: string) (base_uri_string: string) =
        let graph_name = string_to_iri graph_name_string

        if triplestore.HasGraph(graph_name) then
            triplestore[graph_name]
        else
            let named_graph = new ThreadSafeGraph(graph_name)
            named_graph.BaseUri <- triplestore.UriFactory.Create(base_uri_string)
            named_graph.UriFactory <- triplestore.UriFactory
            named_graph.NamespaceMap.Import(vocabulary_graph.NamespaceMap)
            test <@ triplestore.Add(named_graph, true) @>
            // test <@ dataset.AddGraph(named_graph) @>
            named_graph


    let document_graph (document_iri: IUriNode) (document_base_uri_path: string) =
        if triplestore.HasGraph document_iri then
            triplestore.Item document_iri
        else
            named_graph document_iri.Uri.OriginalString document_base_uri_path



    let union_graph () =
        let union_graph = new ThreadSafeGraph()

        let triples =
            graphs ()
            |> Seq.collect (fun graph -> graph.Triples)

        test <@ union_graph.Assert(triples) @>
        union_graph






    module Assert =
        let triples (graph: IGraph) (triplesToAssert: Triple array) =

            Console.WriteLine($"triples generated = {triplesToAssert.Length}")

            triplesToAssert
            |> Array.iter (fun triple -> Console.WriteLine(triple.ToString()))

            let changed = graph.Assert(triplesToAssert)

            Console.WriteLine($"assert changed = {changed}")
            Console.WriteLine($"{graph.Name} count after = {graph.Triples.Count}")

    module Save =
        let ttl () =
            graphs ()
            |> Seq.filter (fun graph -> graph.BaseUri <> null)
            |> Seq.iter (fun graph -> compressingturtlewriter.Save(graph, $"{graph.BaseUri.OriginalString}.ttl"))

let namespace_maps =
    Map.ofArray [|


                   "http://chromedevtools.github.io/devtools-protocol#", "cdp"
                   "http://purl.org/dc/terms/", "dct"
                   "http://purl.org/linked-data/cube#", "qb"
                   "http://rdfs.org/ns/void#", "void"
                   "http://rdfs.org/sioc/actions#", "sioc_actions"
                   "http://rdfs.org/sioc/ns#", "sioc"
                   "http://rdfs.org/sioc/services#", "sioc_services"
                   "http://rdfs.org/sioc/types#", "sioc_types"
                   "http://usefulinc.com/ns/doap#", "doap"
                   "http://www.example.org/", ""
                   "http://www.w3.org/1999/02/22-rdf-syntax-ns#", "rdf"
                   "http://www.w3.org/1999/xhtml/vocab#", "xhv"
                   "http://www.w3.org/2000/01/rdf-schema#", "rdfs"
                   "http://www.w3.org/2001/XMLSchema#", "xsd"
                   "http://www.w3.org/2002/07/owl#", "owl"
                   "http://www.w3.org/2003/g/data-view#", "grddl"
                   "http://www.w3.org/2004/02/skos/core#", "skos"
                   "http://www.w3.org/2006/time#", "time"
                   "http://www.w3.org/2007/05/powder-s#", "wdrs"
                   "http://www.w3.org/2007/05/powder#", "wdr"
                   "http://www.w3.org/2007/rif#", "rif"
                   "http://www.w3.org/2008/05/skos-xl#", "skosxl"
                   "http://www.w3.org/2009/pointers#", "ptr"
                   "http://www.w3.org/2011/content#", "cnt"
                   "http://www.w3.org/2011/http-headers#", "http-headers"
                   "http://www.w3.org/2011/http-methods#", "http-methods"
                   "http://www.w3.org/2011/http-statusCodes#", "http-statusCodes"
                   "http://www.w3.org/2011/http#", "http"
                   "http://www.w3.org/ns/csvw#", "csvw"
                   "http://www.w3.org/ns/dcat#", "dcat"
                   "http://www.w3.org/ns/dqv#", "dqv"
                   "http://www.w3.org/ns/earl#", "earl"
                   "http://www.w3.org/ns/json-ld#", "jsonld"
                   "http://www.w3.org/ns/ldp#", "ldp"
                   "http://www.w3.org/ns/ma-ont#", "ma"
                   "http://www.w3.org/ns/oa#", "oa"
                   "http://www.w3.org/ns/odrl/2/", "odrl"
                   "http://www.w3.org/ns/org#", "org"
                   "http://www.w3.org/ns/prov#", "prov"
                   "http://www.w3.org/ns/r2rml#", "rr"
                   "http://www.w3.org/ns/rdfa#", "rdfa"
                   "http://www.w3.org/ns/sosa/", "sosa"
                   "http://www.w3.org/ns/sparql-service-description#", "sd"
                   "http://www.w3.org/ns/ssn/", "ssn"
                   "http://www.w3.org/XML/1998/namespace", "xml"
                   "http://xmlns.com/foaf/0.1/", "foaf"
                   "http://xmlns.com/foaf/spec/#", "foaf"
                   "https://chromedevtools.github.io/devtools-protocol/tot/Network/#", "cdpNetwork"
                   "https://chromedevtools.github.io/devtools-protocol/tot/Page/#", "cdpPage"
                   "https://eristocrates.dev/ontology/vocabulary/", "vocabulary"
                   "https://x.com/i/communities/", "community"
                   "https://w3id.org/uri4uri/mime/application/", "mime_application"
                   "https://www.w3.org/ns/activitystreams#", "as"
                   "https://www.w3.org/ns/duv#", "duv"
                   "https://x.com/", "twitter"
                   "https://x.com/i/api#", "twitterApi"



                    |]

namespace_maps
|> Map.iter (fun uri prefix ->
    Persistence.vocabulary_graph.NamespaceMap.AddNamespace(prefix, Persistence.triplestore.UriFactory.Create(uri)))

let prefixed_name (namespace_prefix: string) (local_name: string) =
    let low_lined_name = local_name.Replace(" ", "_")
    Persistence.vocabulary_graph.CreateUriNode($"{namespace_prefix}:{low_lined_name}")


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
    let screen_name = prefix "screen_name"
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

let test_blank = Persistence.vocabulary_graph.CreateBlankNode()

let triples (subject: Subject) (predicate_object_lists: PredicateObjectList list) =
    let subject_node =
        match subject with
        | Subject node -> node
        | BlankSubject blankNode -> blankNode :> INode

    predicate_object_lists
    |> List.collect (fun (PredicateObjectList (Predicate predicate, ObjectList objects)) ->
        objects
        |> List.map (fun obj -> new Triple(subject_node, predicate, obj)))



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
    Persistence.vocabulary_graph.CreateLiteralNode(string value)

let typedLit (value: obj) (datatypePrefix: string) (datatypeLocal: string) =
    let string_value =
        match datatypeLocal with
        | "boolean" -> (string value).ToLower()
        | _ -> string value

    Persistence.vocabulary_graph.CreateLiteralNode(string_value, (prefixed_name datatypePrefix datatypeLocal).Uri)


let xsd_true = typedLit "true" "xsd" "boolean" :> INode
let xsd_false = typedLit "false" "xsd" "boolean" :> INode


let optLit (value: 'a option) =
    match value with
    | Some v -> Persistence.vocabulary_graph.CreateLiteralNode(string v) :> INode
    | None -> Persistence.vocabulary_graph.CreateLiteralNode("") :> INode

let nullableLit (value: Nullable<'a>) =
    if value.HasValue then
        Persistence.vocabulary_graph.CreateLiteralNode(string value.Value) :> INode
    else
        Persistence.vocabulary_graph.CreateLiteralNode("") :> INode


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

        browser.client.ConnectAsync()
        |> Async.AwaitTask
        |> Async.RunSynchronously

        browser

    static member debug_page(page_id: string) =
        let page_debugging_endpoint =
            EdgeDevToolsProtocol.list.json ()
            |> Array.find (fun target -> id_from_guid target.Id = page_id)
            |> fun target -> target.WebSocketDebuggerUrl


        let page =
            {

              client =
                  new DefaultProtocolClient(
                      Persistence.triplestore.UriFactory.Create(page_debugging_endpoint),
                      new ConsoleLogger()
                  )
              kind = DevToolKind.page
              targetId = page_id

            }

        page.client.ConnectAsync()
        |> Async.AwaitTask
        |> Async.RunSynchronously

        let PageEnableResponse =
            page.client.SendCommandAsync(Domains.Page.Enable())
            |> resync_task

        let NetworkEnableResponse =
            page.client.SendCommandAsync(Domains.Network.Enable())
            |> resync_task

        let DOMEnableResponse =
            page.client.SendCommandAsync(Domains.DOM.Enable())
            |> resync_task

        let RuntimeEnableResponse =
            page.client.SendCommandAsync(Domains.Runtime.Enable())
            |> resync_task


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

        devtool.client.SendCommandAsync(Domains.Browser.GetVersion())
        |> resync_task


module Page =
    let navigate (uri: Uri) (devtool: DevTool) =
        let last_segment = (uri.Segments |> Array.last).TrimEnd('/')
        let document_base_uri = Persistence.segment_to_stem_path last_segment

        let document_iri = Persistence.vocabulary_graph.CreateUriNode(uri)

        let document_graph =
            Persistence.named_graph document_iri.Uri.OriginalString document_base_uri

        let document_anyURI = typedLit uri.OriginalString "xsd" "anyURI"

        Persistence.Assert.triples
            document_graph
            [|

               triple document_iri cdp.DocumentURL document_anyURI

               |]

        devtool.client.SendCommandAsync(Domains.Page.Navigate(uri.OriginalString))
        |> resync_task

module Network =

    let RequestIds () =
        Persistence.dataset.GetTriplesWithPredicate(cdp.RequestId)
        |> Seq.map (fun triple ->

            let request_id_literal = triple.Object :?> LiteralNode
            request_id_literal.Value

        )

    let Documents () =
        Persistence.dataset.GetTriplesWithPredicate(cdp.DocumentURL)
        |> Seq.map (fun triple ->

            let url_literal = triple.Object :?> LiteralNode
            url_literal.Value

        )

    let is_document (url: string) =
        Documents()
        |> Seq.exists (fun document_url -> url = document_url)

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
            let uri = Persistence.triplestore.UriFactory.Create(url)
            let lastSegment = (uri.Segments |> Array.last).TrimEnd('/')

            match lastSegment with
            | endpoint_local_name when lastSegment |> is_twitter_endpoint -> true
            | _ -> false
        | _ -> false

    let escape (value: string) = Uri.EscapeDataString(value)

    let safeUriNodeFromString (s: string) =
        try
            Persistence.vocabulary_graph.CreateUriNode(UriFactory.Create(s)) :> INode
        with
        | ex ->
            Console.Error.WriteLine($"Could not create URI node from: {s}")
            Console.Error.WriteLine(ex.ToString())
            Persistence.vocabulary_graph.CreateUriNode(UriFactory.Create(escape s)) :> INode




    let subscribe_refresh (devtool: DevTool) =

        let request_will_be_sent =
            devtool.client.SubscribeAsync<Domains.Network.RequestWillBeSent> (fun requestWillBeSent ->

                task {
                    try

                        if (requestWillBeSent.Request.Url |> is_document) then
                            let document_uri =
                                Persistence.triplestore.UriFactory.Create(requestWillBeSent.Request.Url)

                            let document_iri = Persistence.vocabulary_graph.CreateUriNode(document_uri)
                            let last_segment = (document_uri.Segments |> Array.last).TrimEnd('/')
                            let base_uri_path = Persistence.segment_to_stem_path last_segment

                            let document_graph = Persistence.document_graph document_iri base_uri_path



                            Console.WriteLine("\n\n\n---- Network.RequestWillBeSent ----")
                            Console.WriteLine($"{requestWillBeSent.DocumentURL}: {requestWillBeSent.RequestId}")

                            Console.WriteLine(
                                $"{requestWillBeSent.DocumentURL} count before = {document_graph.Triples.Count}"
                            )

                            let frame = cdp.Frame_from_value requestWillBeSent.FrameId.Value
                            let frame_id = typedLit requestWillBeSent.FrameId.Value "xsd" "string"

                            let has_user_gesture =
                                typedLit requestWillBeSent.HasUserGesture "xsd" "boolean" :> INode

                            let loader = cdp.Loader_from_value requestWillBeSent.LoaderId.Value
                            let loader_id = typedLit requestWillBeSent.LoaderId.Value "xsd" "string"
                            let request = cdp.Request_from_value requestWillBeSent.RequestId.Value
                            let request_id = typedLit requestWillBeSent.RequestId.Value "xsd" "string"
                            let request_url = typedLit requestWillBeSent.Request.Url "xsd" "anyURI"

                            let graphql_iri = twitterApi.prefix last_segment


                            let timestamp = typedLit requestWillBeSent.Timestamp.Value "xsd" "float"
                            let resource_type = cdp.ResourceType_from_value requestWillBeSent.Type.Value
                            let request_will_be_sent = document_graph.CreateBlankNode()



                            let triplesToAssert =
                                [|

                                   triple document_iri a cdp.Document
                                   triple document_iri cdp.Loader loader
                                   // triple loader a cdpNetwork.type_.Loader

                                   |]

                            triplesToAssert
                            |> Persistence.Assert.triples document_graph





                        if (requestWillBeSent.Request.Url |> is_graphql) then
                            let document_uri =
                                Persistence.triplestore.UriFactory.Create(requestWillBeSent.DocumentURL)

                            let request_uri =
                                Persistence.triplestore.UriFactory.Create(requestWillBeSent.Request.Url)

                            let request_iri = Persistence.vocabulary_graph.CreateUriNode(request_uri)

                            let document_iri = Persistence.vocabulary_graph.CreateUriNode(document_uri)
                            let last_document_segment = (document_uri.Segments |> Array.last).TrimEnd('/')
                            let last_request_segment = (request_uri.Segments |> Array.last).TrimEnd('/')
                            let base_uri_path = Persistence.segment_to_stem_path last_document_segment

                            let document_graph = Persistence.document_graph document_iri base_uri_path



                            Console.WriteLine("\n\n\n---- Network.RequestWillBeSent ----")
                            Console.WriteLine($"{last_document_segment}: {requestWillBeSent.RequestId}")

                            Console.WriteLine(
                                $"{requestWillBeSent.DocumentURL} count before = {document_graph.Triples.Count}"
                            )

                            let frame = cdp.Frame_from_value requestWillBeSent.FrameId.Value
                            let frame_id = typedLit requestWillBeSent.FrameId.Value "xsd" "string"

                            let has_user_gesture =
                                typedLit requestWillBeSent.HasUserGesture "xsd" "boolean" :> INode

                            let loader = cdp.Loader_from_value requestWillBeSent.LoaderId.Value
                            let loader_id = typedLit requestWillBeSent.LoaderId.Value "xsd" "string"
                            let request = cdp.Request_from_value requestWillBeSent.RequestId.Value
                            let request_id = typedLit requestWillBeSent.RequestId.Value "xsd" "string"
                            let request_url = typedLit requestWillBeSent.Request.Url "xsd" "anyURI"

                            let graphql_iri = twitterApi.prefix last_request_segment


                            let timestamp = typedLit requestWillBeSent.Timestamp.Value "xsd" "float"
                            let resource_type = cdp.ResourceType_from_value requestWillBeSent.Type.Value
                            let request_will_be_sent = document_graph.CreateBlankNode()
                            let document_anyURI = typedLit requestWillBeSent.DocumentURL "xsd" "anyURI"



                            let triplesToAssert =
                                [|

                                   // triple loader a cdpNetwork.type_.Loader
                                   triple document_iri cdp.Loader loader
                                   triple document_iri a cdp.Document
                                   triple document_iri cdp.DocumentURL document_anyURI
                                   triple loader cdp.Request request
                                   triple request a graphql_iri
                                   triple request cdp.RequestId request_id

                                   |]

                            triplesToAssert
                            |> Persistence.Assert.triples document_graph


                    with
                    | ex ->
                        Console.Error.WriteLine("FAILED inside Network.requestWillBeSent subscription")
                        Console.Error.WriteLine(ex.ToString())


                }
                :> Task)

        (*
        let response_received =
            devtool.client.SubscribeAsync<Domains.Network.ResponseReceived>(fun responseReceived ->
                task {
                    try
                        let uri = Persistence.triplestore.UriFactory.Create(responseReceived.Response.Url)
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
            devtool.client.SendCommandAsync(Domains.Page.Reload())
            |> resync_task

        devtool





module Target =
    /// https://chromedevtools.github.io/devtools-protocol/tot/Target/#method-getTargets
    let getTargets (devtool: DevTool) =
        let result =
            devtool.client.SendCommandAsync(Domains.Target.GetTargets())
            |> resync_task

        result.TargetInfos

    /// https://chromedevtools.github.io/devtools-protocol/tot/Target/#method-createTarget
    let createTarget (uri: Uri) (devtool: DevTool) =
        let last_segment = (uri.Segments |> Array.last).TrimEnd('/')
        let document_base_uri = Persistence.segment_to_stem_path last_segment

        let document_iri = Persistence.vocabulary_graph.CreateUriNode(uri)

        let document_graph =
            Persistence.named_graph document_iri.Uri.OriginalString document_base_uri

        let document_anyURI = typedLit uri.OriginalString "xsd" "anyURI"

        Persistence.Assert.triples
            document_graph
            [|

               triple document_iri cdp.DocumentURL document_anyURI

               |]

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

let edge_endpoint =
    Persistence.triplestore.UriFactory.Create(EdgeDevToolsProtocol.version.json.WebSocketDebuggerUrl)


























































let edge = DevTool.debug_browser edge_endpoint


let test_uri = Persistence.triplestore.UriFactory.Create("https://x.com/home")

let test_page =
    edge
    |> Target.createTarget test_uri
    |> Network.subscribe_refresh



let inputScreenNames =
    [|

       "AngelEyes11357"

       |]

module https =
    module twitter =
        module com =
            let uri = Persistence.triplestore.UriFactory.Create "https://x.com"

            module home =
                let uri = Persistence.triplestore.UriFactory.Create $"https://x.com/home"

            module i =
                module communities =
                    let uri = Persistence.triplestore.UriFactory.Create $"https://x.com/i/communities"

                    let community (community_id: string) =
                        Persistence.triplestore.UriFactory.Create $"https://x.com/i/communities/{community_id}"

                module flow =
                    module login =
                        let uri = Persistence.triplestore.UriFactory.Create "https://x.com/i/flow/login"

            let profile_from_screen_name (screen_name: string) =
                Persistence.triplestore.UriFactory.Create $"https://x.com/{screen_name}"


test_page
|> Page.navigate (https.twitter.com.profile_from_screen_name "vlucasrocha")

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

    let json (text: string) = JsonProvider<filePath>.Parse (text)

module CommunityQuery =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\CommunityQuery.json"

    let json (text: string) = JsonProvider<filePath>.Parse (text)

module CommunitiesFetchOneQuery =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\CommunitiesFetchOneQuery.json"

    let json (text: string) = JsonProvider<filePath>.Parse (text)

module CommunitiesRankedTimeline =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\CommunitiesRankedTimeline.json"

    let json (text: string) = JsonProvider<filePath>.Parse (text)

module CommunitiesExploreTimeline =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\CommunitiesExploreTimeline.json"

    let json (text: string) = JsonProvider<filePath>.Parse (text)

module CommunityTweetsTimeline =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\CommunityTweetsTimeline.json"

    let json (text: string) = JsonProvider<filePath>.Parse (text)

module membersSliceTimeline_Query =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\membersSliceTimeline_Query.json"

    let json (text: string) = JsonProvider<filePath>.Parse (text)

module UserByScreenName =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\UserByScreenName.json"

    let json (text: string) = JsonProvider<filePath>.Parse (text)

module UserTweets =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\UserTweets.json"

    let json (text: string) = JsonProvider<filePath>.Parse (text)

module ProfileSpotlightsQuery =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\ProfileSpotlightsQuery.json"

    let json (text: string) = JsonProvider<filePath>.Parse (text)

















Persistence
    .union_graph()
    .GetTriplesWithObject(twitterApi.UserByScreenName)
|> Seq.map (fun triple -> triple.Subject)
|> Seq.collect (fun request ->
    Persistence
        .union_graph()
        .GetTriplesWithSubjectPredicate(request, cdp.RequestId))
|> Seq.map (fun triple ->

    let request_id_literal = triple.Object :?> LiteralNode
    request_id_literal.Value

)
|> Seq.map (fun request_id ->

    test_page.client.SendCommandAsync(Domains.Network.GetResponseBody(new Domains.Network.RequestIdType(request_id)))
    |> resync_task

)
|> Seq.map (fun json_response ->

    let userByScreenName =
        (UserByScreenName.json json_response.Body)
            .Data
            .User
            .Result

    let screen_name = userByScreenName.Core.ScreenName

    let screen_name_xsd_string =
        typedLit userByScreenName.Core.ScreenName "xsd" "string"

    let profile_iri = twitter.profile screen_name
    let profile_base_uri_path = Persistence.segment_to_stem_path screen_name
    let profile_graph = Persistence.document_graph profile_iri profile_base_uri_path

    let name = typedLit userByScreenName.Core.Name "xsd" "string"
    let description = typedLit userByScreenName.Legacy.Description "xsd" "string"
    // let created_at = userByScreenName.Core.CreatedAt
    let rest_id = typedLit userByScreenName.RestId "xsd" "string"
    let avatar_image_url = typedLit userByScreenName.Avatar.ImageUrl "xsd" "anyURI"
    // let is_blue_verified = userByScreenName.IsBlueVerified

    let triplesToAssert =
        [|

           triple profile_iri a twitter.User
           triple profile_iri twitter.name name
           triple profile_iri twitter.screen_name screen_name_xsd_string
           triple profile_iri twitter.description description
           triple profile_iri twitter.rest_id rest_id
           triple profile_iri twitter.avatar_image_url avatar_image_url

           |]

    triplesToAssert
    |> Persistence.Assert.triples profile_graph


    Persistence
        .union_graph()
        .GetTriplesWithObject(twitterApi.UserTweets)
    |> Seq.map (fun triple -> triple.Subject)
    |> Seq.collect (fun request ->
        Persistence
            .union_graph()
            .GetTriplesWithSubjectPredicate(request, cdp.RequestId))
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
        // data.user.result.timeline.timeline.instructions[1].entries[0].content.itemContent.tweet_results.result.core.user_results.result.core.screen_name

        let item_contents =
            user_tweets.Data.User.Result.Timeline.Timeline.Instructions
            |> Array.Parallel.collect (fun instruction ->
                instruction.Entries
                |> Array.Parallel.choose (fun entry -> entry.Content.ItemContent

                )
                |> Array.Parallel.filter (fun itemContent ->
                    itemContent.TweetResults.Result.Core.UserResults.Result.Core.ScreenName = screen_name))

        let screen_name =
            let random_item_content = item_contents |> Array.head
            random_item_content.TweetResults.Result.Core.UserResults.Result.Core.ScreenName

        let profile_iri = twitter.prefix screen_name
        let profile_base_uri_path = Persistence.segment_to_stem_path screen_name
        let profile_graph = Persistence.document_graph profile_iri profile_base_uri_path

        item_contents
        |> Array.Parallel.choose (fun itemContent -> itemContent.SocialContext)
        |> Array.Parallel.filter (fun socialContext -> socialContext.ContextType = "Community")
        |> Array.Parallel.map (fun socialContext -> socialContext.LandingUrl.Url)
        |> Array.distinct
        |> Array.map (fun community_url ->

            let community_uri = community_url |> Persistence.string_to_uri
            let community_iri = community_uri |> Persistence.uri_to_iri
            let community_graph = community_url |> Persistence.string_to_named_graph
            let community_anyURI = typedLit community_url "xsd" "anyURI"

            let triplesToAssert =
                [|

                   triple community_iri a twitter.Community
                   triple community_iri cdp.DocumentURL community_anyURI
                   triple community_iri twitter.community_member profile_iri

                   |]

            triplesToAssert
            |> Persistence.Assert.triples profile_graph

            triplesToAssert
            |> Persistence.Assert.triples community_graph


        )))



(*

let test_url = "https://eristocrates.dev/ontology/test/"
let test_uri = Persistence.triplestore.UriFactory.Create(test_url)
let test_iri = Persistence.triplestore.UriFactory.CreateNode(test_uri)
let test_graph = new ThreadSafeGraph(test_iri)
test_graph.BaseUri <- Persistence.triplestore.UriFactory.Create(@"D:\Persistence\test")
test_graph.Assert(triple colon.this_ a colon.example)
test_graph.AllNodes
let test_dataset = new InMemoryDataset(true)

test_dataset.Graphs
|> Seq.filter (fun graph -> graph.BaseUri <> null)
|> Seq.map (fun graph -> graph.BaseUri)

test_dataset.AddGraph test_graph

test_dataset.Add

Store.disk_demand
let memory_manager = new InMemoryManager(Store.disk_demand)
memory_manager.ListGraphNames()
let memory_dataset = new InMemoryDataset(Store.disk_demand, true)
memory_dataset.AddGraph



Store.disk_demand.Add
Store.disk_demand.Graphs

*)

let community_urls =
    Persistence
        .union_graph()
        .GetTriples(twitter.Community)
    |> Seq.collect (fun community'iri_a_twitter'Community ->

        Persistence
            .union_graph()
            .GetTriplesWithSubjectPredicate(community'iri_a_twitter'Community.Subject, cdp.DocumentURL)
        |> Seq.map (fun community'iri_cdp'DocumentURL_community_url ->

            let community_url_literal =
                community'iri_cdp'DocumentURL_community_url.Object :?> ILiteralNode

            community_url_literal.Value

        )


    )


community_urls
|> Seq.map (fun community_url ->
    let community_uri = Persistence.triplestore.UriFactory.Create(community_url)
    test_page |> Page.navigate community_uri

)


(*

let there_were_new_requests (current: int) (last: int) =
    if current > last then
        printfn "New membersSliceTimeline_Query request detected. Total count: %d" current
        true
    else
        printfn "No new membersSliceTimeline_Query request detected. Total count remains: %d" last
        false

let countRequests_from_communityMembersPageUriString (substring_to_check: string) =
    membersSliceTimeline_QueryRequests
    |> Seq.filter (fun network -> network.Request.Url.Contains(substring_to_check))
    |> Seq.length

let rec scroll (substring_to_check: string) =

    let lastCount = countRequests_from_communityMembersPageUriString substring_to_check

    Thread.Sleep(1500)

    test_page.client.SendCommandAsync(
        Domains.Runtime.Evaluate(
            """
    window.scrollTo({
      top: document.body.scrollHeight,
      left: 0,
      behavior: "smooth",
    });
                """
                .TrimStart()
                .TrimEnd()
        )
    )
    |> Async.AwaitTask
    |> Async.RunSynchronously
    |> ignore

    Thread.Sleep(1500)

    let currentCount =
        countRequests_from_communityMembersPageUriString substring_to_check

    if there_were_new_requests currentCount lastCount then
        scroll (substring_to_check)
    else
        printfn "Finished scrolling. Total membersSliceTimeline_Query request count: %d" currentCount

        membersSliceTimeline_QueryRequests
        |> Seq.filter (fun network -> network.Request.Url.Contains(substring_to_check))
        |> Seq.toArray
        |> Array.Parallel.collect (fun membersSliceTimeline_QueryRequest ->

            let membersSliceTimeline_QueryRequestResponse =
                test_page.client.SendCommandAsync(
                    Domains.Network.GetResponseBody(membersSliceTimeline_QueryRequest.RequestId)
                )
                |> Async.AwaitTask
                |> Async.RunSynchronously

            let membersSlice =
                (membersSliceTimeline_Query.json membersSliceTimeline_QueryRequestResponse.Body) // Data.CommunityMembersSliceTimeline.CommunityMembersSliceTimeline

            membersSlice.Data.CommunityResults.Result.MembersSlice.ItemsResults
            |> Array.Parallel.map (fun itemResult ->

                itemResult.Result.Core.ScreenName


            )

        )



*)

Persistence.Save.ttl ()


test_page
|> Page.navigate (https.twitter.com.profile_from_screen_name "ClandestineMaga")
