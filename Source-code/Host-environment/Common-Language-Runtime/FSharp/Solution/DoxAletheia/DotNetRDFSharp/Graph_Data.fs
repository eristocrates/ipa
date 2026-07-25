module DoxAletheia.Graph_Data

open System
open System.IO
open System.Xml
open System.Globalization
open System.Collections


open VDS.RDF
open VDS.RDF.Nodes
open VDS.RDF.Query.Builder
open VDS.RDF.Query.Patterns
open VDS.RDF.Parsing
open VDS.RDF.JsonLd
open VDS.RDF.Query.Datasets
open VDS.RDF.Storage
open VDS.RDF.Query
open VDS.RDF.Parsing.Tokens


open FSharp.Data
open FSharp.Data.Adaptive.Transaction
open FSharp.HashCollections
open FSharp.Collections.ParallelSeq


open Swensen.Unquote.Assertions


open DoxAletheia

open type Prefix_ID
open DotNetRDFSharp
open NamespaceRegistry
open PrettierNaming




type RDF_Graph =
    { triples: HashSet<RDF_Triple> }

    member this.verticies =
        this.triples
        |> Array.ofSeq
        |> Array.Parallel.collect (fun triple -> triple.verticies)
        |> Array.distinct

    static member from_vds_graph (vds_graph:IGraph) = 
        { triples = vds_graph.Triples |> PSeq.map (fun vds_triple -> RDF_Triple.from_vds_triple vds_triple) |> HashSet.ofSeq }



[<CLIMutable>]
type Force_Node = { id: string }



[<CLIMutable>]
type Force_Link =
    { source: string
      target: string
      predicate: string }
    static member type_name = "Force_Link"

/// https://github.com/vasturiano/force-graph
type Force_Graph(rdf_graph: RDF_Graph) =
    let _type_name = "Force_Graph"

    let _force_links =

        rdf_graph.triples
        |> Array.ofSeq
        |> Array.map (fun triple ->
            { source = triple.curSubject.curie
              target = triple.curObject.curie
              predicate = triple.curPredicate.curie })

    let _force_nodes =
        _force_links
        |> Array.collect (fun link -> [| link.source; link.target |])
        |> Array.distinct
        |> Array.map (fun id -> { id = id })

    member this.type_name = _type_name
    member this.force_links = _force_links
    member this.force_nodes = _force_nodes








