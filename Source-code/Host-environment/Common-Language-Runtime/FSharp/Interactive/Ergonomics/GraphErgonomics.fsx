open System
open System.IO

#r "nuget: Yog.FSharp"

open Yog.Model
open Yog.Builder.Labeled
open Yog.IO
open Yog.Pathfinding.Dijkstra

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Parsing\Identifier\Resource\RDF\Turtle.fsx"

open IRI
open Turtle

let dotFilePath = Path.Combine(__SOURCE_DIRECTORY__, "graph.dot")


let subject_predicate_object subject predicate object = addEdge subject object predicate

type example =
    static member _prefix_id = https.www.example.com.prefix_id

    static member Alice =
        Turtle_IRI.FromPrefixedName(Prefixed_Name.from_prefix_id example._prefix_id "Alice")

    static member Bob =
        Turtle_IRI.FromPrefixedName(Prefixed_Name.from_prefix_id example._prefix_id "Bob")

    static member knows =
        Turtle_IRI.FromPrefixedName(Prefixed_Name.from_prefix_id example._prefix_id "knows")

// Create a directed graph
let default_graph =
    directed<Turtle_IRI, Turtle_IRI> ()
    |> addNode example.Alice
    |> addNode example.Bob
    |> subject_predicate_object example.Alice example.knows example.Bob
    // |> addSVO "Bob" "knows" "Charlie"
    // |> addSVO "Alice" "knows" "Charlie"
    |> toGraph


let graphvizOptions: Dot.Options<Turtle_IRI, Turtle_IRI> =
    { Dot.defaultOptions with
        NodeLabel = fun _ node -> node.as_string
        EdgeLabel = fun iri -> iri.as_string }


Dot.writeFile dotFilePath graphvizOptions default_graph
