namespace DoxAletheia

open System
open System.IO


open ParserCombinator.Data
open ParserCombinator.ResourceIdentifier
open StringExtensions
open XParsecExtensions
open XParsecExtensions.Code_Parsers
open ArrayErgonomics
open GrammarErgonomics
open Interval_Range
open IntervalErgonomics


open Yog.Model
open Yog.Builder
open Yog.IO
open Yog.Pathfinding.Dijkstra
open Yog.Render
open Yog.Render.Dot
open Yog.Render.Mermaid




open QuikGraph
open QuikGraph.Serialization
open QuikGraph.Graphviz
open QuikGraph.Data
open QuikGraph.MSAGL
open QuikGraph.Petri



open Rubjerg.Graphviz
open Code_Point_Rule
open Code_Line_Rule
open XParsec
open FSharp.HashCollections
open Interval_Range
open VDS.RDF
open VDS.RDF.Parsing

open Fabulous.AST
open Fantomas.Core.SyntaxOak

open type Fabulous.AST.Ast
open Namespace_Prefixes


[<CLIMutable>]
type Force_Node = { id: string }



[<CLIMutable>]
type Force_Link =
    { source: string
      target: string
      predicate: string }
    static member type_name = "Force_Link"





type Formula =
    {

      subjects: Rdf_Subject array
      predicates: Rdf_Predicate array
      objects: Rdf_Object array
      predicateObjectLists: PredicateObjectList array
      triples: HashSet<Rdf_Triple>

     }

    static member from_subject subject_term =

        { subjects = [| subject_term |]
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member from_subjects subjects =

        { subjects = subjects |> List.toArray
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member from_predicate predicate_term =

        { subjects = [||]
          predicates = [| predicate_term |]
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member from_predicates predicates =

        { subjects = [||]
          predicates = predicates
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member from_object object_term =

        { subjects = [||]
          predicates = [||]
          objects = [| object_term |]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member from_objects objects =

        { subjects = [||]
          predicates = [||]
          objects = objects
          predicateObjectLists = [||]
          triples = HashSet.empty

        }


    member this.materialize_triples =
        let triples_from_terms =
            Rdf_Triple.set_from_terms this.subjects this.predicates this.objects

        let triples_from_subjects_predicateObjectLists =
            Rdf_Triple.set_from_subjects_predicateObjectLists this.subjects this.predicateObjectLists

        { subjects = [||]
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples =
            HashSet.union this.triples (HashSet.union triples_from_terms triples_from_subjects_predicateObjectLists)


        }

    member this.add_subjects subject_terms =
        { this with subjects = this.subjects |> Array.append subject_terms }

    member this.add_subject subject_term = this.add_subjects [| subject_term |]


    member this.add_predicates predicate_terms =

        { this with predicates = this.predicates |> Array.append predicate_terms }

    member this.add_predicateObjectLists predicateObjectLists =

        { this with
            predicateObjectLists =
                this.predicateObjectLists
                |> Array.append predicateObjectLists }

    member this.add_predicate predicate_term =
        this.add_predicates [| predicate_term |]

    member this.add_objects object_terms =
        { this with objects = this.objects |> Array.append object_terms }

    member this.add_object object_term = this.add_objects [| object_term |]

    member this.add_literal literal =
        Literal.autotyped literal
        |> Rdf_Object.LiteralObject
        |> this.add_object

    member this.add_literals literals =
        literals
        |> List.toArray
        |> Array.Parallel.map (fun literal ->
            literal
            |> Literal.autotyped
            |> Rdf_Object.LiteralObject)
        |> this.add_objects




type Rdf_Graph =
    { triples: HashSet<Rdf_Triple> }
    member this.verticies =
        this.triples
        |> Array.ofSeq
        |> Array.Parallel.collect (fun triple -> triple.verticies)
        |> Array.distinct

    member this.force_links =

        this.triples
        |> Array.ofSeq
        |> Array.map (fun triple ->
            { source = triple.curSubject.as_raw_string
              target = triple.curObject.as_raw_string
              predicate = triple.curPredicate.as_raw_string })

    member this.force_nodes =
        this.force_links
        |> Array.collect (fun link -> [| link.source; link.target |])
        |> Array.distinct
        |> Array.map (fun id -> { id = id })



/// https://github.com/vasturiano/force-graph
[<CLIMutable>]
type Force_Graph =
    {

      nodes: Force_Node array
      links: Force_Link array

     }
    static member type_name = "Force_Graph"

    static member from_rdf_graph(rdf_graph: Rdf_Graph) =
        { nodes = rdf_graph.force_nodes
          links = rdf_graph.force_links }
