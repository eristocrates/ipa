open Browser.Dom
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop

let N = 300


let gData =
    {| nodes = Array.init N (fun id -> {| id = id |})
       links =
        [| 1 .. N - 1 |]
        |> Array.map (fun id ->
            {| source = id
               target = JS.Math.round (JS.Math.random () * float (id - 1)) |}) |}



type ForceGraph =
    abstract linkDirectionalParticles: count: int -> ForceGraph
    abstract graphData: data: obj -> ForceGraph

[<Emit("new ForceGraph()($0)")>]
let new_ForceGraph (element: HTMLElement) : ForceGraph = jsNative

let Graph =
    document.getElementById ("graph")
    |> new_ForceGraph
    |> fun graph -> graph.linkDirectionalParticles (2)
    |> fun graph -> graph.graphData (gData)
