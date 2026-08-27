module DoxAletheia.Graph_Data

open System
open System.Text
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
open VDS.RDF.Writing.Formatting
open VDS.RDF.Storage
open VDS.RDF.Query
open VDS.RDF.Parsing.Tokens
open VDS.RDF.Writing

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

open FSharp.Data
open FSharp.Json
open FSharp.Data.Adaptive.Transaction
open FSharp.HashCollections
open FSharp.Collections.ParallelSeq


open Swensen.Unquote.Assertions


open DoxAletheia

open type Prefix_ID

open DotNetRDFSharp
open NamespaceRegistry
open PrettierNaming




type Textual_Syntax =
    {

      syntax_name: string
      file_extension: string

     }
    member this.file_path parent_directory stem =
        Directory.CreateDirectory(parent_directory)
        |> ignore

        Path.Combine(parent_directory, sprintf "%s.%s" stem this.file_extension)





module NTriples =

    let syntax =
        { syntax_name = "NTriples"
          file_extension = "nt"

        }

    let mime_type = Mime_Path.application.n.triples.media_type

    let parser = NTriplesParser()

    let parse (text: string) (graph: IGraph) =
        try
            use reader = new StringReader(text)
            parser.Load(graph, reader)
        with
        | err ->

            failwithf "The text %s failed to parse with error %s" text err.Message



module IGraph =
    let from_rdf_graph (rdf_graph: RDF_Graph) =
        let vds_graph = new ThreadSafeGraph()
        NTriples.parse rdf_graph.nt vds_graph

        rdf_graph.prefix_ids
        |> Array.iter (fun prefix_id ->
            vds_graph.NamespaceMap.AddNamespace(prefix_id.namespace_prefix, new Uri(prefix_id.namespace_name)))

        vds_graph



module Turtle =
    open VDS.RDF.Writing.Formatting
    open VDS.RDF.Writing

    let syntax =
        { syntax_name = "Turtle"
          file_extension = "ttl" }

    let mime_type = Mime_Path.text.turtle.media_type

    let private isValidPrefixedNameRelaxed (s: string) =
        if s.Contains(".") then
            true
        else
            TurtleSpecsHelper.IsValidQName(s)

    let private percentEncodeCharUtf8 (ch: char) =
        Encoding.UTF8.GetBytes([| ch |])
        |> Seq.map (fun b -> "%" + b.ToString("X2"))
        |> String.concat ""

    let private isForbiddenInTurtleIriRef (ch: char) =
        let code = int ch

        code <= 0x20
        || code = 0x7F
        || ch = '<'
        || ch = '>'
        || ch = '"'
        || ch = '{'
        || ch = '}'
        || ch = '|'
        || ch = '^'
        || ch = '`'
        || ch = '\\'

    let private escapeIriRefByPercentEncoding (iri: string) =
        let sb = StringBuilder(iri.Length)

        for ch in iri do
            if isForbiddenInTurtleIriRef ch then
                sb.Append(percentEncodeCharUtf8 ch) |> ignore
            else
                sb.Append(ch) |> ignore

        sb.ToString()

    let private formatIriRefFromOriginalString (uri: Uri) =
        "<"
        + escapeIriRefByPercentEncoding uri.OriginalString
        + ">"

    let private isAsciiSafeLocal (local: string) =
        if String.IsNullOrEmpty(local) then
            false
        else
            let isStartOk ch = Char.IsLetterOrDigit(ch) || ch = '_'

            let isRestOk ch =
                Char.IsLetterOrDigit(ch)
                || ch = '_'
                || ch = '-'
                || ch = '.'

            isStartOk local.[0]
            && local |> Seq.forall isRestOk

    let private isValidLocalName (local: string) =
        if String.IsNullOrEmpty(local) then
            false
        elif local.Contains("/") then
            false
        else
            TurtleSpecsHelper.IsValidQName("p:" + local)
            || isAsciiSafeLocal local

    let private tryReduceToPrefixOnly (nsMap: INamespaceMapper) (uriOriginal: string) =
        nsMap.Prefixes
        |> Seq.tryPick (fun (p: string) ->
            let nsUri = nsMap.GetNamespaceUri(p)

            if isNull (box nsUri) then
                None
            else
                let ns = nsUri.OriginalString

                if uriOriginal.Equals(ns, StringComparison.Ordinal) then
                    Some(p + ":")
                else
                    None)

    let private tryReduceToPrefixedNameLongest (nsMap: INamespaceMapper) (uriOriginal: string) : string option =
        let candidates: (string * string) list =
            nsMap.Prefixes
            |> Seq.choose (fun (p: string) ->
                let nsUri = nsMap.GetNamespaceUri(p)

                if isNull (box nsUri) then
                    None
                else
                    Some(p, nsUri.OriginalString))
            |> Seq.filter (fun (_pfx: string, ns: string) -> uriOriginal.StartsWith(ns, StringComparison.Ordinal))
            |> Seq.sortByDescending (fun (_pfx: string, ns: string) -> ns.Length)
            |> Seq.toList

        let rec pick (xs: (string * string) list) =
            match xs with
            | [] -> None
            | (pfx, ns) :: rest ->
                let local = uriOriginal.Substring(ns.Length)

                if isValidLocalName local then
                    Some(pfx + ":" + local)
                else
                    pick rest

        pick candidates

    let private tryReduceToPrefixedName (nsMap: INamespaceMapper) (uriOriginal: string) =
        match tryReduceToPrefixOnly nsMap uriOriginal with
        | Some p -> Some p
        | None -> tryReduceToPrefixedNameLongest nsMap uriOriginal

    type UnicodePrefixedNameTurtleW3CFormatter(g: IGraph) =
        inherit TurtleW3CFormatter(g)

        override _.IsValidQName(value: string) = isValidPrefixedNameRelaxed value

        override _.FormatUriNode(u: IUriNode, segment: Nullable<TripleSegment>) =
            let uri = u.Uri

            if
                segment.HasValue
                && segment.Value = TripleSegment.Predicate
                && uri.AbsoluteUri.Equals("http://www.w3.org/1999/02/22-rdf-syntax-ns#type", StringComparison.Ordinal)
            then
                "a"
            else
                match tryReduceToPrefixedName g.NamespaceMap uri.OriginalString with
                | Some prefixedName -> prefixedName
                | None -> formatIriRefFromOriginalString uri

    let private writeAllPrefixes (tw: TextWriter) (g: IGraph) =
        g.NamespaceMap.Prefixes
        |> Seq.sort
        |> Seq.iter (fun p ->
            let ns = g.NamespaceMap.GetNamespaceUri(p)
            tw.Write("@prefix ")
            tw.Write(p)
            tw.Write(": <")
            tw.Write(ns.OriginalString)
            tw.WriteLine("> ."))

        tw.WriteLine()

    let write_igraph (parent_directory: string) (stem: string) (graph: VDS.RDF.IGraph) =

        use file_stream =
            new FileStream(syntax.file_path parent_directory stem, FileMode.Create, FileAccess.Write, FileShare.Read)

        use stream_writer = new StreamWriter(file_stream, new UTF8Encoding(false))

        writeAllPrefixes stream_writer graph

        let formatter = UnicodePrefixedNameTurtleW3CFormatter(graph) :> ITripleFormatter

        for triple in graph.Triples do
            stream_writer.WriteLine(formatter.Format(triple))

        stream_writer.Flush()

    (*

    let writer =
        let writer = new CompressingTurtleWriter(TurtleSyntax.W3C)
        writer.HighSpeedModePermitted <- false
        writer.PrettyPrintMode <- true
        writer

    let write_igraph (parent_directory: string) (stem: string) (graph: VDS.RDF.IGraph) =
        map_prefixes graph
        writer.Save(graph, syntax.file_path parent_directory stem)

*)
    let write_draft (parent_directory: string) (stem: string) (draft: Formula) =
        let file_path = syntax.file_path parent_directory stem

        { triples = draft.triples }
        |> IGraph.from_rdf_graph
        |> write_igraph parent_directory stem


module JsonLd =
    open VDS.RDF.Writing
    open Newtonsoft.Json.Linq

    let syntax =
        { syntax_name = "JsonLd"
          file_extension = "jsonld" }

    let triplestore_from_igraph (output_path: string) (graph: IGraph) =
        let store = new TripleStore()

        store.Add(graph) |> ignore

        let writer = JsonLdWriter()
        writer.Save(store, output_path)
        store

    let private context_from_graph (graph: IGraph) =
        let context = JObject()

        for prefix in graph.NamespaceMap.Prefixes do
            let namespace_iri =
                graph
                    .NamespaceMap
                    .GetNamespaceUri(
                        prefix
                    )
                    .AbsoluteUri

            if String.IsNullOrEmpty(prefix) then
                // Turtle's default prefix corresponds most closely to @vocab.
                context["@vocab"] <- JValue(namespace_iri)
            else
                let prefix_definition = JObject()

                prefix_definition["@id"] <- JValue(namespace_iri)

                prefix_definition["@prefix"] <- JValue(true)

                context[prefix] <- prefix_definition

        context

    let compacted_from_igraph (graph: IGraph) =
        let store = new TripleStore()
        store.Add(graph) |> ignore

        let expanded_json_ld = JsonLdWriter().SerializeStore(store)

        let context = context_from_graph graph

        let options = JsonLdProcessorOptions()
        options.Ordered <- true

        let compact_json_ld = JsonLdProcessor.Compact(expanded_json_ld, context, options)
        compact_json_ld.ToString(Newtonsoft.Json.Formatting.Indented)

    let write_draft (parent_directory: string) (stem: string) (draft: Formula) =
        let file_text =
            { triples = draft.triples }
            |> IGraph.from_rdf_graph
            |> compacted_from_igraph

        let file_path = syntax.file_path parent_directory stem
        File.WriteAllText(file_path, file_text)

module JsonRq =

    let syntax =
        { syntax_name = "SPARQL Results JSON"
          file_extension = "rq.json" }

    let write_draft (parent_directory: string) (stem: string) (draft: Formula) =
        let file_path = syntax.file_path parent_directory stem
        let store = new TripleStore()

        store.Add(
            { triples = draft.triples }
            |> IGraph.from_rdf_graph
        )
        |> ignore

        let dataset = new InMemoryDataset(store)

        let query =
            SparqlQueryParser()
                .ParseFromString(
                    """
                SELECT ?source ?predicate ?target
                WHERE {
                    ?source ?predicate ?target
                }
                """
                )

        let processor = new LeviathanQueryProcessor(dataset)

        let results = processor.ProcessQuery(query) :?> SparqlResultSet

        SparqlJsonWriter().Save(results, file_path)





























[<CLIMutable>]
type Force_Node = { id: string }



[<CLIMutable>]
type Force_Link =
    { source: string
      target: string
      predicate: string }
    static member type_name = "Force_Link"

/// https://github.com/vasturiano/force-graph
type Force_Graph =
    { type_name: string
      force_links: Force_Link array
      force_nodes: Force_Node array }
    static member from_rdf_graph(rdf_graph) =
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

        { type_name = "Force_Graph"
          force_links = _force_links
          force_nodes = _force_nodes }





module Force_Graph_2D =
    let syntax =
        { syntax_name = "2d force-graph"
          file_extension = "force-graph.2d.json" }

    let write_draft (parent_directory: string) (stem: string) (draft: Formula) =
        let file_text =
            { triples = draft.triples }
            |> Force_Graph.from_rdf_graph
            |> Json.serialize

        let file_path = syntax.file_path parent_directory stem
        File.WriteAllText(file_path, file_text)






type YoGraph = Graph<string, string>

module YoGraph =
    let from_rdf_graph (rdf_graph: RDF_Graph) =
        rdf_graph.triples
        |> Array.ofSeq
        |> Array.Parallel.map (fun triple -> triple.curSubject.curie, triple.curObject.curie, triple.curPredicate.curie)
        |> Array.toList
        |> Labeled.fromList Directed
        |> Labeled.toGraph

type Quik_Edge = TaggedEdge<string, string>
type Quik_Graph = BidirectionalGraph<string, Quik_Edge>


module Quik_Graph =
    let from_rdf_graph (rdf_graph: RDF_Graph) =
        let quik_graph = new Quik_Graph()

        rdf_graph.triples
        |> Array.ofSeq
        |> Array.map (fun triple ->
            quik_graph.AddVerticesAndEdge(
                new Quik_Edge(triple.curSubject.curie, triple.curObject.curie, triple.curPredicate.curie)
            ))
        |> ignore

        quik_graph




module ddot =
    module it =
        let syntax =
            { syntax_name = "ddot.it"
              file_extension = "ddot" }

        let triple_ddot (rdf_triple: RDF_Triple) =
            sprintf "%s..%s..%s" rdf_triple.curSubject.curie rdf_triple.curPredicate.curie rdf_triple.curObject.curie

        let graph_lines (rdf_graph: RDF_Graph) =
            rdf_graph.triples
            |> Array.ofSeq
            |> Array.Parallel.map (fun triple -> triple_ddot triple)

        let graph_text (rdf_graph: RDF_Graph) =
            rdf_graph |> graph_lines |> String.concat "\n"

        let write_draft (parent_directory: string) (stem: string) (draft: Formula) =
            let file_text = { triples = draft.triples } |> graph_text

            let file_path = syntax.file_path parent_directory stem
            File.WriteAllText(file_path, file_text)



module Dot =

    let syntax =
        { syntax_name = "Graphviz"
          file_extension = "dot" }

    let prefix_delimiter = ":"


    let yog_options: Dot.Options<string, string> =
        {

          NodeLabel = (fun _ vertex -> vertex)
          EdgeLabel = (fun edge -> edge)
          HighlightedSourceNodes = Set.empty
          HighlightedSinkNodes = Set.empty
          HighlightedNodes = Set.empty
          HighlightedEdges = Set.empty
          NodeShape = "ellipse"
          HighlightColor = "red"

        }


    let write_yograph (parent_directory: string) (stem: string) (yograph: YoGraph) =
        let file_path = syntax.file_path parent_directory stem
        Dot.writeFile file_path yog_options yograph

    let write_quik_graph (parent_directory: string) (stem: string) (quik_graph: Quik_Graph) =
        let dot_graph = new GraphvizAlgorithm<string, Quik_Edge>(quik_graph)

        dot_graph.FormatVertex.Add (fun args ->

            args.VertexFormat.Label <- (args.Vertex)

        )

        dot_graph.FormatEdge.Add (fun args ->

            args.EdgeFormat.Label.Value <- (args.Edge.Tag)

        )



        dot_graph.Generate(new FileDotEngine(), (syntax.file_path parent_directory stem))
        |> ignore

    let write_draft_from_yograph (parent_directory: string) (stem: string) (draft: Formula) =
        { triples = draft.triples }
        |> YoGraph.from_rdf_graph
        |> write_yograph parent_directory $"{stem}.yog"

    let write_draft_from_quik_graph (parent_directory: string) (stem: string) (draft: Formula) =
        { triples = draft.triples }
        |> Quik_Graph.from_rdf_graph
        |> write_quik_graph parent_directory $"{stem}.quik"

    let write_draft (parent_directory: string) (stem: string) (draft: Formula) =
        draft
        |> write_draft_from_yograph parent_directory stem

        draft
        |> write_draft_from_quik_graph parent_directory stem




module Mermaid =

    let syntax =
        { syntax_name = "Mermaid"
          file_extension = "mmd" }

    let prefix_delimiter = ":"

    let options: Mermaid.Options<string, string> =
        {

          Direction = "LR"
          NodeLabel = (fun vertex_id vertex -> vertex.Replace("\"", ""))
          EdgeLabel = (fun edge -> edge.Replace("\"", ""))
          HighlightedEdges = Set.empty
          HighlightedNodes = Set.empty
          HighlightedSinkNodes = Set.empty
          HighlightedSourceNodes = Set.empty

        }

    let write_yograph (parent_directory: string) (stem: string) yograph =
        let file_path = syntax.file_path parent_directory stem
        Mermaid.writeFile file_path options yograph

    let write_draft (parent_directory: string) (stem: string) (draft: Formula) =
        { triples = draft.triples }
        |> YoGraph.from_rdf_graph
        |> write_yograph parent_directory stem


module d2 =
    let syntax =
        { syntax_name = "d2"
          file_extension = "d2" }

    let prefix_delimiter = "\\:"


    let graph_lines (rdf_graph: RDF_Graph) =
        rdf_graph.triples
        |> Array.ofSeq
        |> Array.Parallel.map (fun triple -> triple.curSubject.curie, triple.curObject.curie, triple.curPredicate.curie)
        |> Array.Parallel.map (fun (in_vertex, out_vertex, out_edge) ->
            sprintf "%s -> %s : %s" in_vertex out_vertex out_edge)

    let graph_text (rdf_graph: RDF_Graph) =
        rdf_graph |> graph_lines |> String.concat "\n"

    let write_draft (parent_directory: string) (stem: string) (draft: Formula) =
        let file_text = { triples = draft.triples } |> graph_text

        let file_path = syntax.file_path parent_directory stem
        File.WriteAllText(file_path, file_text)


module Formula =
    let materialize_triples (draft: Formula) = draft.materialize_triples
    let emit_triples (draft: Formula) = draft.triples
    let to_rdf_graph (draft: Formula) = { triples = draft.triples }

    let to_igraph (draft: Formula) =
        draft |> to_rdf_graph |> IGraph.from_rdf_graph

let write_draft parent_directory stem draft =
    Turtle.write_draft parent_directory stem draft
    Dot.write_draft parent_directory stem draft
    ddot.it.write_draft parent_directory stem draft
    Mermaid.write_draft parent_directory stem draft
    d2.write_draft parent_directory stem draft
    JsonLd.write_draft parent_directory stem draft
    JsonRq.write_draft parent_directory stem draft
    Force_Graph_2D.write_draft parent_directory stem draft
