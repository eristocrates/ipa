open System
open System.IO

#r "nuget: Yog.FSharp"

open Yog.Model
open Yog.Builder.Labeled
open Yog.IO
open Yog.Pathfinding.Dijkstra

let dotFilePath = Path.Combine(__SOURCE_DIRECTORY__, "graph.dot")

let graphvizOptions: Dot.Options<string, string> =
    { Dot.defaultOptions with
        NodeLabel = fun _ label -> label
        EdgeLabel = string }

let addSVO S V O = addEdge S O V

// Create a directed graph
let graph =
    directed<string, string> ()
    |> addNode "Alice"
    |> addNode "Bob"
    |> addSVO "Alice" "knows" "Bob"
    |> addSVO "Bob" "knows" "Charlie"
    |> addSVO "Alice" "knows" "Charlie"
    |> toGraph


Dot.writeFile dotFilePath graphvizOptions graph
