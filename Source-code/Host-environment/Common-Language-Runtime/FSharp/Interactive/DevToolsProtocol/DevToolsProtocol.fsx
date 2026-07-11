open System
open System.IO
open System.Text
open System.Text.Unicode
open System.Linq
open System.Globalization

#r "nuget: FsHttp"
open FsHttp
#r "nuget: FSharp.Data"

open FSharp.Data
open System.Threading.Tasks

#r "nuget: ChromeProtocol.Core"
#r "nuget: ChromeProtocol.Domains"
#r "nuget: ChromeProtocol.Runtime"

open ChromeProtocol
open ChromeProtocol.Runtime.Messaging.WebSockets
open Microsoft.Extensions.Logging

#r "nuget: XParsec"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\Identifier\Resource\International\International_Resource_Identifier.fsx"

open XParsecErgonomics
open International_Resource_Identifier
open Uniform_Resource_Identifier


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


module com =
    module neogov =
        module login =
            module signin =
                let uri =
                    result'from_parse URI.parse OnInput "https://login.neogov.com/signin?sitecode=US"

        module unifiedweb_api =
            module api =
                module Employee =
                    module employees =
                        let uri =
                            result'from_parse
                                URI.parse
                                OnInput
                                "https://unifiedweb-api.neogov.com/api/Employee/employees"

let scheme_string = "http"
let host_string = "localhost"
let port_string = "9222"

let startpoint =
    result'from_parse URI.parse OnInput $"{scheme_string}://{host_string}:{port_string}"

let json_endpoint (endpoint: string) =
    result'from_parse URI.parse OnInput $"{startpoint.as'string}/json/{endpoint}"

let runtimeDirectoryPath = Path.Combine(__SOURCE_DIRECTORY__, "runtime")

let file_scheme_string'from'windows_path (windows_path: string) =
    let reverse_solidus_path = windows_path.Replace("\\", "/")
    $"file:///{reverse_solidus_path}"

let runtimeDirectoryUriString =
    file_scheme_string'from'windows_path runtimeDirectoryPath


let runtimeDirectory =
    result'from_parse URI_Reference.parse OnInput runtimeDirectoryUriString


let id_from_guid (guid: Guid) = guid.ToString("N").ToUpperInvariant()

let resync_task (task: Task<_>) =
    task |> Async.AwaitTask |> Async.RunSynchronously








module version =
    let endpoint = json_endpoint "version"

    let response =
        http { GET endpoint.as'string }
        |> Request.send
        |> Response.toText


    [<Literal>]
    let sampleFilePath =
        @"D:\Surface\Company\Microsoft\Edge\ChromeDevTools\version.json"

    let json = JsonProvider<sampleFilePath>.Parse (response)




module protocol =
    let endpoint = json_endpoint "protocol"

    let response =
        http { GET endpoint.as'string }
        |> Request.send
        |> Response.toText

    [<Literal>]
    let sampleFilePath =
        @"D:\Surface\Company\Microsoft\Edge\ChromeDevTools\protocol.json"

    let json = JsonProvider<sampleFilePath>.Parse (response)

module list =
    let endpoint = json_endpoint "list"
    let url = endpoint.as'string

    let response () =
        let text =
            http { GET url }
            |> Request.send
            |> Response.toText

        File.WriteAllText(Path.Combine(runtimeDirectoryPath, "list.json"), text)
        text

    [<Literal>]
    let sampleFilePath = @"D:\Surface\Company\Microsoft\Edge\ChromeDevTools\list.json"

    let json () =
        JsonProvider<sampleFilePath>.Parse (response ())















type ConsoleLogger() =
    interface ILogger with
        member _.BeginScope(state) = null
        member _.IsEnabled(_) = true
        member _.Log(logLevel, _, state, _, _) = printfn "[%A] %O" logLevel state




type Browser =
    {

      client: DefaultProtocolClient

     }

    static member from'debugging_endpoint(debugging_endpoint: URI) =
        let browser =
            {

              client = new DefaultProtocolClient(new Uri(debugging_endpoint.as'string), new ConsoleLogger())

            }

        browser.client.ConnectAsync()
        |> Async.AwaitTask
        |> Async.RunSynchronously

        browser

    member this.new_tab'from'uri(uri: URI) =
        this.client.SendCommandAsync(Domains.Target.CreateTarget(uri.as'string))
        |> resync_task




let output_file_path_string (parent_directory: string) (stem: string) (extension: string) =
    Path.Combine(parent_directory, $"{stem}.{extension}")

type Labeled_MultiGraph = BidirectionalGraph<string, TaggedEdge<string, string>>
type Statement = TaggedEdge<string, string>

let subject_predicate_object_graph subject predicate object (graph: Labeled_MultiGraph) =
    graph.AddVerticesAndEdge(new Statement(subject, object, predicate))
    |> ignore

    graph

let deduplicate_edges (old_graph: Labeled_MultiGraph) =
    let new_graph = new Labeled_MultiGraph()

    new_graph.AddVertexRange old_graph.Vertices
    |> ignore

    new_graph.AddEdgeRange(
        old_graph.Edges
        |> Seq.distinctBy (fun edge -> edge.ToString())
    )
    |> ignore

    new_graph

let render_dot (graph: Labeled_MultiGraph) (parent_directory: string) (stem: string) =
    let dot_graph =
        new GraphvizAlgorithm<string, TaggedEdge<string, string>>(deduplicate_edges graph)

    dot_graph.FormatVertex.Add (fun args ->

        args.VertexFormat.Label <- args.Vertex

    )

    dot_graph.FormatEdge.Add (fun args ->

        args.EdgeFormat.Label.Value <- args.Edge.Tag

    )


    dot_graph.Generate(new FileDotEngine(), (output_file_path_string parent_directory stem "dot"))
    |> ignore


let default_graph = new Labeled_MultiGraph()

let edge_endpoint =
    result'from_parse URI.parse OnInput version.json.WebSocketDebuggerUrl

let edge = Browser.from'debugging_endpoint edge_endpoint

edge.new_tab'from'uri com.neogov.login.signin.uri
