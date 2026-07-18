module DoxAletheia.Rdf_Document
open System
open System.IO
open System.Text
open System.Globalization
open System.Xml
open Rdf_Vocabulary
open Namespace_Prefixes

open FSharp.HashCollections
open VDS.RDF
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


type Draft_Document =
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
            Triples.from_terms this.subjects this.predicates this.objects

        let triples_from_subjects_predicateObjectLists =
            Triples.from_subjects_predicateObjectLists this.subjects this.predicateObjectLists

        { subjects = [||]
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples =
            HashSet.union
                this.triples
                (HashSet.union triples_from_terms triples_from_subjects_predicateObjectLists)


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
        Rdf_Literal.autotyped literal
        |> Rdf_Object.LiteralObject
        |> this.add_object

    member this.add_literals literals =
        literals
        |> List.toArray
        |> Array.Parallel.map (fun literal ->
            literal
            |> Rdf_Literal.autotyped
            |> Rdf_Object.LiteralObject)
        |> this.add_objects



let global_prefix_map = global_prefix_declarations |> Map.ofArray


let prefixed_name (delimiter: string) (iri: Namespaced_IRI) =
    let namespace_name = iri.namespace_iriref.as_rendered_string
    let prefix_label = global_prefix_map[namespace_name]
    sprintf "%s%s%s" prefix_label delimiter iri.local_name.as_raw_string


let curie (iri: Namespaced_IRI) = iri |> prefixed_name ":"




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


type Rdf_Graph = { triples: HashSet<Rdf_Triple> }


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



module NQuads =
    let syntax =
        { syntax_name = "N-Quads"
          file_extension = "nq" }

    let mime_type = Mime_Path.application.n.quads.media_type

module TriG =
    let syntax =
        { syntax_name = "TriG"
          file_extension = "trig"

        }

    let mime_type = Mime_Path.application.trig.media_type

module D2 =

    let syntax =
        { syntax_name = "D2"
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

    let write_draft (parent_directory: string) (stem: string) (draft: Draft_Document) =
        let file_text = { triples = draft.triples } |> graph_text

        let file_path = syntax.file_path parent_directory stem
        File.WriteAllText(file_path, file_text)



type YoGraph = Yog.Model.Graph<Vertex, Edge>
type Quik_Edge = TaggedEdge<Vertex, Edge>
type Quik_Graph = BidirectionalGraph<Vertex, Quik_Edge>


module Rdf_Graph =
    let to_igraph (rdf_graph: Rdf_Graph) =
        let igraph = new ThreadSafeGraph()
        NTriples.parse (NTriples.graph_text rdf_graph) igraph
        igraph


    let to_yograph (rdf_graph: Rdf_Graph) =
        rdf_graph.triples
        |> Array.ofSeq
        |> Array.Parallel.map (fun triple ->
            SubjectVertex triple.curSubject, ObjectVertex triple.curObject, PredicateEdge triple.curPredicate)
        |> Array.toList
        |> Labeled.fromList Directed
        |> Labeled.toGraph

    let to_quik_graph (rdf_graph: Rdf_Graph) =
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
        map_prefixes graph

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
    let write_draft (parent_directory: string) (stem: string) (draft: Draft_Document) =
        let file_path = syntax.file_path parent_directory stem

        { triples = draft.triples }
        |> Rdf_Graph.to_igraph
        |> write_igraph parent_directory stem


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

        let write_draft (parent_directory: string) (stem: string) (draft: Draft_Document) =
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

          NodeLabel = (fun vertex_id vertex -> vertex_dot vertex)
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

    let write_draft_from_yograph (parent_directory: string) (stem: string) (draft: Draft_Document) =
        { triples = draft.triples }
        |> Rdf_Graph.to_yograph
        |> write_yograph parent_directory $"{stem}.yog"

    let write_draft_from_quik_graph (parent_directory: string) (stem: string) (draft: Draft_Document) =
        { triples = draft.triples }
        |> Rdf_Graph.to_quik_graph
        |> write_quik_graph parent_directory $"{stem}.quik"

    let write_draft (parent_directory: string) (stem: string) (draft: Draft_Document) =
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

    let write_draft (parent_directory: string) (stem: string) (draft: Draft_Document) =
        { triples = draft.triples }
        |> Rdf_Graph.to_yograph
        |> write_yograph parent_directory stem




module Draft_Document =
    let materialize_triples (draft: Draft_Document) = draft.materialize_triples
    let emit_triples (draft: Draft_Document) = draft.triples
    let to_rdf_graph (draft: Draft_Document) = { triples = draft.triples }

    let to_igraph (draft: Draft_Document) =
        draft |> to_rdf_graph |> Rdf_Graph.to_igraph

let write_draft parent_directory stem draft =
    Turtle.write_draft parent_directory stem draft
    Dot.write_draft parent_directory stem draft
    ddot.it.write_draft parent_directory stem draft
    Mermaid.write_draft parent_directory stem draft
    D2.write_draft parent_directory stem draft
