open System
open System.IO

#r "nuget: Yog.FSharp"

open Yog.Model
open Yog.Builder.Labeled
open Yog.IO
open Yog.Pathfinding.Dijkstra

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XParsecErgonomics.fsx"
open XParsecErgonomics

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Parsing\Identifier\Resource\RDF\Turtle.fsx"


open Turtle



let label_from_iri (iri: Turtle_IRI) = iri.as_string
let nodeLabel_from_iri id (iri: Turtle_IRI) = label_from_iri iri

let graphvizOptions: Dot.Options<Turtle_IRI, Turtle_IRI> =
    {


      NodeLabel = nodeLabel_from_iri
      EdgeLabel = label_from_iri
      HighlightedNodes = Set.empty
      HighlightedEdges = Set.empty
      NodeShape = "ellipse"
      HighlightColor = "red"

    }

let mermaidOptions: Mermaid.Options<Turtle_IRI, Turtle_IRI> =
    {

      NodeLabel = nodeLabel_from_iri
      EdgeLabel = label_from_iri
      HighlightedNodes = Set.empty
      HighlightedEdges = Set.empty

    }

let graph_from_context graph (parent_directory: string) (stem: string) =
    let stemPath = Path.Combine(parent_directory, $"{stem}.stem")

    let dotFilePath = Path.ChangeExtension(stemPath, "dot")
    Dot.writeFile dotFilePath graphvizOptions graph


    let jsonFilePath = Path.ChangeExtension(stemPath, "json")
    Json.writeFile jsonFilePath graph


    let mermaidFilePath = Path.ChangeExtension(stemPath, "mmd")
    Mermaid.writeFile mermaidFilePath mermaidOptions graph


// let contextmlFilePath = Path.ChangeExtension(stemPath, "contextml")
// GraphML.writeFile contextmlFilePath context

let subject_predicate_object_context subject predicate object context =
    addEdge subject object predicate context

let subjects_predicate_object_context subjects predicate object context =
    List.fold
        (fun current_context subject -> subject_predicate_object_context subject predicate object current_context)
        context
        subjects
(*
// TODO figure out how to generate this
type example =
    static member _prefix_id = https.www.example.com.prefix_id

    static member knows =
        Turtle_IRI.FromPrefixedName(Prefixed_Name.from_prefix_id example._prefix_id "knows")

    static member Alice =
        Turtle_IRI.FromPrefixedName(Prefixed_Name.from_prefix_id example._prefix_id "Alice")

    static member Bob =
        Turtle_IRI.FromPrefixedName(Prefixed_Name.from_prefix_id example._prefix_id "Bob")

    static member Charlie =
        Turtle_IRI.FromPrefixedName(Prefixed_Name.from_prefix_id example._prefix_id "Charlie")


// Create a directed context
let default_context =
    directed<Turtle_IRI, Turtle_IRI> ()
    |> subject_predicate_object_context example.Alice example.knows example.Bob
    |> subjects_predicate_object_context [ example.Alice; example.Bob ] example.knows example.Charlie

let default_graph = default_context |> toGraph



graph_from_context default_graph __SOURCE_DIRECTORY__ "graph"

*)
