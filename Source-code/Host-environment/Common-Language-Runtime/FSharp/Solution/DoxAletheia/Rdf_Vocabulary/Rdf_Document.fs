module DoxAletheia.Rdf_Document

open System

open System.IO
open System.Text
open System.Globalization
open System.Xml


open FSharp.HashCollections
open VDS.RDF
open VDS.RDF.Query
open VDS.RDF.Parsing
open VDS.RDF.Parsing.Tokens
open VDS.RDF.Storage
open VDS.RDF.Writing
open VDS.RDF.Query.Datasets
open VDS.RDF.Writing.Formatting

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


open System
open Newtonsoft.Json
open Newtonsoft.Json.Linq
open VDS.RDF
open VDS.RDF.JsonLd
open VDS.RDF.Writing
open DoxAletheia
open Namespace_Prefixes

open Fabulous.AST
open Fantomas.Core.SyntaxOak

open type Fabulous.AST.Ast

open FSharp.Json



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

    let iriref_nt (iriref: IRIREF) = "<" + iriref.as_raw_string + ">"



    let blank_node_nt (blank_node: Blank_Node) =
        match blank_node with
        | BlankNodeIdentifier identifier -> sprintf "_:%s" identifier
        // TODO handle nt representation of blanknodepropertylist
        | BlankNodePropertyList (identifier, predicateObjectList) -> sprintf "_:%s" identifier

    let subject_nt (rdf_subject: Rdf_Subject) =
        match rdf_subject with
        | IRIREFSubject iriref -> iriref_nt iriref
        | BlankNodeSubject blank_node -> blank_node_nt blank_node

    let predicate_nt (rdf_predicate: Rdf_Predicate) =
        match rdf_predicate with
        | IRIREFPredicate iriref -> iriref_nt iriref

    let rdf_literal_nt (rdf_literal: Rdf_Literal) =

        match rdf_literal with
        | SimpleLiteral lexical_form -> sprintf "\"%s\"" lexical_form
        | LongLiteral lexical_form -> sprintf "\"\"\"%s\"\"\"" lexical_form
        | DatatypedLiteral (lexical_form, datatype) -> sprintf "\"%s\"^^%s" lexical_form (iriref_nt datatype)
        | LanguageString (lexical_form, language) -> sprintf "\"%s\"@%s" lexical_form (language.ToString())
        | RegionString (lexical_form, language, region) ->
            sprintf "\"%s\"@%s-%s" lexical_form (language.ToString()) (region.ToString())
        | DirectedLanguageString (lexical_form, language, base_direction) ->
            sprintf "\"%s\"@%s--%s" lexical_form (language.ToString()) base_direction.lexical_form
        | DirectedRegionString (lexical_form, language, region, base_direction) ->
            sprintf
                "\"%s\"@%s-%s--%s"
                lexical_form
                (language.ToString())
                (region.ToString())
                base_direction.lexical_form

    let rec object_nt (rdf_object: Rdf_Object) =
        match rdf_object with
        | IRIREFObject iriref -> iriref_nt iriref
        | BlankNodeObject blank_node -> blank_node_nt blank_node
        | LiteralObject rdf_literal -> rdf_literal_nt rdf_literal
        | TripleTermObject triple_term ->
            sprintf
                "<<(%s %s %s)>>"
                (subject_nt triple_term.ttSubject)
                (predicate_nt triple_term.ttPredicate)
                (object_nt triple_term.ttObject)

    let triple_nt (rdf_triple: Rdf_Triple) =
        sprintf
            "%s %s %s ."
            (subject_nt rdf_triple.curSubject)
            (predicate_nt rdf_triple.curPredicate)
            (object_nt rdf_triple.curObject)

    let triple_term_nt (triple_term: Triple_Term) =
        match triple_term with
        | TripleTerm triple ->
            sprintf
                "<<(%s %s %s)>>"
                (subject_nt triple_term.ttSubject)
                (predicate_nt triple_term.ttPredicate)
                (object_nt triple_term.ttObject)

    let graph_lines (rdf_graph: Rdf_Graph) =
        rdf_graph.triples
        |> Array.ofSeq
        |> Array.Parallel.map (fun triple -> triple_nt triple)

    let graph_text (rdf_graph: Rdf_Graph) =
        graph_lines rdf_graph |> String.concat "\n"



module IGraph =
    let from_rdf_graph (rdf_graph: Rdf_Graph) =
        let igraph = new ThreadSafeGraph()
        NTriples.parse (NTriples.graph_text rdf_graph) igraph
        igraph


    let map_prefixes (graph: IGraph) =
        global_prefix_declarations
        |> Array.Parallel.iter (fun (namespace_name, prefix_label) ->

            let uri_nodes =
                graph.AllNodes
                |> Seq.toArray
                |> Array.Parallel.choose (fun inode ->
                    if inode.NodeType = NodeType.Uri then
                        Some(inode :?> UriNode)
                    else
                        None

                )

            let term_is_namespaced =
                uri_nodes
                |> Array.Parallel.exists (fun uri_node ->

                    uri_node.Uri.OriginalString.StartsWith(namespace_name)

                )

            if term_is_namespaced then
                graph.NamespaceMap.AddNamespace(prefix_label, new Uri(namespace_name)))

type YoGraph = Graph<Vertex, Edge>

module YoGraph =
    let from_rdf_graph (rdf_graph: Rdf_Graph) =
        rdf_graph.triples
        |> Array.ofSeq
        |> Array.Parallel.map (fun triple ->
            SubjectVertex triple.curSubject, ObjectVertex triple.curObject, PredicateEdge triple.curPredicate)
        |> Array.toList
        |> Labeled.fromList Directed
        |> Labeled.toGraph


type Quik_Edge = TaggedEdge<Vertex, Edge>
type Quik_Graph = BidirectionalGraph<Vertex, Quik_Edge>

module Quik_Graph =
    let from_rdf_graph (rdf_graph: Rdf_Graph) =
        let quik_graph = new Quik_Graph()

        rdf_graph.triples
        |> Array.ofSeq
        |> Array.map (fun triple ->
            quik_graph.AddVerticesAndEdge(
                new Quik_Edge(
                    SubjectVertex triple.curSubject,
                    ObjectVertex triple.curObject,
                    PredicateEdge triple.curPredicate
                )
            ))
        |> ignore

        quik_graph



module Turtle =
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
                && uri.AbsoluteUri.Equals(RdfSpecsHelper.RdfType, StringComparison.Ordinal)
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
        IGraph.map_prefixes graph

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

        JsonLdProcessor.Compact(expanded_json_ld, context, options)
        |> _.ToString(Formatting.Indented)

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

        store.Add({ triples = draft.triples } |> IGraph.from_rdf_graph) |> ignore

        let dataset =
            new InMemoryDataset(store)

        let query =
            SparqlQueryParser().ParseFromString(
                """
                SELECT ?source ?predicate ?target
                WHERE {
                    ?source ?predicate ?target
                }
                """
            )

        let processor =
            new LeviathanQueryProcessor(dataset)

        let results =
            processor.ProcessQuery(query)
            :?> SparqlResultSet

        SparqlJsonWriter().Save(
            results,
            file_path
        )
module ddot =
    module it =
        let syntax =
            { syntax_name = "ddot.it"
              file_extension = "ddot" }

        let triple_ddot (rdf_triple: Rdf_Triple) =
            sprintf
                "%s..%s..%s"
                (NTriples.subject_nt rdf_triple.curSubject)
                (NTriples.predicate_nt rdf_triple.curPredicate)
                (NTriples.object_nt rdf_triple.curObject)

        let graph_lines (rdf_graph: Rdf_Graph) =
            rdf_graph.triples
            |> Array.ofSeq
            |> Array.Parallel.map (fun triple -> triple_ddot triple)

        let graph_text (rdf_graph: Rdf_Graph) =
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

    let vertex_dot (vertex: Vertex) =
        vertex.as_rendered_string prefix_delimiter global_prefix_map

    let edge_dot (edge: Edge) =
        edge.as_rendered_string prefix_delimiter global_prefix_map

    let yog_options: Dot.Options<Vertex, Edge> =
        {

          NodeLabel = (fun _ vertex -> vertex_dot vertex)
          EdgeLabel = (fun edge -> edge_dot edge)
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
        let dot_graph = new GraphvizAlgorithm<Vertex, Quik_Edge>(quik_graph)

        dot_graph.FormatVertex.Add (fun args ->

            args.VertexFormat.Label <- (vertex_dot args.Vertex)

        )

        dot_graph.FormatEdge.Add (fun args ->

            args.EdgeFormat.Label.Value <- (edge_dot args.Edge.Tag)

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

    let vertex_mmd (vertex: Vertex) =
        vertex.as_rendered_string prefix_delimiter global_prefix_map

    let edge_mmd (edge: Edge) =
        edge.as_rendered_string prefix_delimiter global_prefix_map

    let options: Mermaid.Options<Vertex, Edge> =
        {

          Direction = "LR"
          NodeLabel = (fun vertex_id vertex -> vertex_mmd vertex)
          EdgeLabel = (fun edge -> edge_mmd edge)
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

    let vertex_d2 (vertex: Vertex) =
        vertex.as_rendered_string prefix_delimiter global_prefix_map

    let edge_d2 (edge: Edge) =
        edge.as_rendered_string prefix_delimiter global_prefix_map

    let graph_lines (rdf_graph: Rdf_Graph) =
        rdf_graph.triples
        |> Array.ofSeq
        |> Array.Parallel.map (fun triple ->
            SubjectVertex triple.curSubject, ObjectVertex triple.curObject, PredicateEdge triple.curPredicate)
        |> Array.Parallel.map (fun (in_vertex, out_vertex, out_edge) ->
            sprintf "%s -> %s : %s" (vertex_d2 in_vertex) (vertex_d2 out_vertex) (edge_d2 out_edge))

    let graph_text (rdf_graph: Rdf_Graph) =
        rdf_graph |> graph_lines |> String.concat "\n"

    let write_draft (parent_directory: string) (stem: string) (draft: Formula) =
        let file_text = { triples = draft.triples } |> graph_text

        let file_path = syntax.file_path parent_directory stem
        File.WriteAllText(file_path, file_text)

module Force_Graph_2D = 
    let syntax =
        { syntax_name = "2d force-graph"
          file_extension = "force-graph.2d.json" }
    
    let write_draft (parent_directory: string) (stem: string) (draft: Formula) =
        let file_text = Json.serialize({ triples = draft.triples } |> Force_Graph.from_rdf_graph )

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