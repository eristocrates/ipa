module DoxAletheia.RDFDocument

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
open Newtonsoft.Json
open Newtonsoft.Json.Linq
open VDS.RDF.JsonLd
open System.Collections
open VDS.RDF.Nodes
open VDS.RDF.Query.Builder
open VDS.RDF.Query.Patterns
open FSharp.Data
open FSharp.Data.Adaptive.Transaction
open FSharp.Collections.ParallelSeq
open Swensen.Unquote.Assertions

open Fabulous.AST
open Fantomas.Core.SyntaxOak
open type Fabulous.AST.Ast
open FSharp.Json




open DoxAletheia


open type PrefixID
open DotNetRDFSharp
open NamespaceRegistry
open PrettierNaming


type TextualSyntax =
    {

      syntaxName: string
      fileExtension: string

     }
    member this.filePath parentDirectory stem =
        Directory.CreateDirectory(parentDirectory)
        |> ignore

        Path.Combine(parentDirectory, sprintf "%s.%s" stem this.fileExtension)




module NTriples =

    let syntax =
        { syntaxName = "NTriples"
          fileExtension = "nt"

        }

    let mimeType = MimePath.application.n.triples.mediaType

    let parser = NTriplesParser()

    let parse (text: string) (graph: IGraph) =
        try
            use reader = new StringReader(text)
            parser.Load(graph, reader)
        with
        | err ->

            failwithf "The text %s failed to parse with error %s" text err.Message




[<CLIMutable>]
type ForceNode = { id: string }



[<CLIMutable>]
type ForceLink =
    { source: string
      target: string
      predicate: string }
    static member typeName = "ForceLink"

/// https://github.com/vasturiano/force-graph
type ForceGraph(rdfTripleSet: RdfTripleSet) =
    let _typeName = "ForceGraph"

    let _forceLinks =

        rdfTripleSet.triples
        |> Array.ofSeq
        |> Array.map (fun triple ->
            { source = triple.curSubject.curie
              target = triple.curObject.curie
              predicate = triple.curPredicate.curie })

    let _forceNodes =
        _forceLinks
        |> Array.collect (fun link -> [| link.source; link.target |])
        |> Array.distinct
        |> Array.map (fun id -> { id = id })

    member this.typeName = _typeName
    member this.forceLinks = _forceLinks
    member this.forceNodes = _forceNodes









module IGraph =
    let fromRdfGraph (rdfTripleSet: RdfTripleSet) =
        let vdsGraph = new ThreadSafeGraph()
        NTriples.parse rdfTripleSet.nt vdsGraph
        vdsGraph.


    let mapPrefixes (graph: IGraph) =
        globalPrefixDeclarations
        |> Array.Parallel.iter (fun ((namespaceName:string), prefixLabel) ->

            let uriNodes =
                graph.AllNodes
                |> Seq.toArray
                |> Array.Parallel.choose (fun inode ->
                    if inode.NodeType = NodeType.Uri then
                        Some(inode :?> UriNode)
                    else
                        None

                )

            let termIsNamespaced =
                uriNodes
                |> Array.Parallel.exists (fun uriNode ->

                    uriNode.Uri.OriginalString.StartsWith(namespaceName)

                )

            if termIsNamespaced then
                graph.NamespaceMap.AddNamespace(prefixLabel, new Uri(namespaceName)))

type YoGraph = Graph<Vertex, Edge>


module YoGraph =
    let fromRdfGraph (rdfTripleSet: RdfTripleSet) =
        rdfTripleSet.triples
        |> Array.ofSeq
        |> Array.Parallel.map (fun triple ->
            SubjectVertex triple.curSubject, ObjectVertex triple.curObject, PredicateEdge triple.curPredicate)
        |> Array.toList
        |> Labeled.fromList Directed
        |> Labeled.toGraph


type QuikEdge = TaggedEdge<Vertex, Edge>
type QuikGraph = BidirectionalGraph<Vertex, QuikEdge>

module QuikGraph =
    let fromRdfGraph (rdfTripleSet: RdfTripleSet) =
        let quikGraph = new QuikGraph()

        rdfTripleSet.triples
        |> Array.ofSeq
        |> Array.map (fun triple ->
            quikGraph.AddVerticesAndEdge(
                new QuikEdge(
                    SubjectVertex triple.curSubject,
                    ObjectVertex triple.curObject,
                    PredicateEdge triple.curPredicate
                )
            ))
        |> ignore

        quikGraph



module Turtle =
    let syntax =
        { syntaxName = "Turtle"
          fileExtension = "ttl" }

    let mimeType = MimePath.text.turtle.mediaType

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
                && uri.AbsoluteUri.Equals(RDFSpecsHelper.RDFType, StringComparison.Ordinal)
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

    let writeIgraph (parentDirectory: string) (stem: string) (graph: VDS.RDF.IGraph) =
        IGraph.mapPrefixes graph

        use fileStream =
            new FileStream(syntax.filePath parentDirectory stem, FileMode.Create, FileAccess.Write, FileShare.Read)

        use streamWriter = new StreamWriter(fileStream, new UTF8Encoding(false))

        writeAllPrefixes streamWriter graph

        let formatter = UnicodePrefixedNameTurtleW3CFormatter(graph) :> ITripleFormatter

        for triple in graph.Triples do
            streamWriter.WriteLine(formatter.Format(triple))

        streamWriter.Flush()

    (*

    let writer =
        let writer = new CompressingTurtleWriter(TurtleSyntax.W3C)
        writer.HighSpeedModePermitted <- false
        writer.PrettyPrintMode <- true
        writer

    let writeIgraph (parentDirectory: string) (stem: string) (graph: VDS.RDF.IGraph) =
        mapPrefixes graph
        writer.Save(graph, syntax.filePath parentDirectory stem)

*)
    let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) =
        let filePath = syntax.filePath parentDirectory stem

        { triples = draft.triples }
        |> IGraph.fromRdfGraph
        |> writeIgraph parentDirectory stem



module JsonLd =
    let syntax =
        { syntaxName = "JsonLd"
          fileExtension = "jsonld" }
    let triplestoreFromIgraph (outputPath: string) (graph: IGraph) =
        let store = new TripleStore()

        store.Add(graph) |> ignore

        let writer = JsonLdWriter()
        writer.Save(store, outputPath)
        store

    let private contextFromGraph (graph: IGraph) =
        let context = JObject()

        for prefix in graph.NamespaceMap.Prefixes do
            let namespaceIri =
                graph
                    .NamespaceMap
                    .GetNamespaceUri(
                        prefix
                    )
                    .AbsoluteUri

            if String.IsNullOrEmpty(prefix) then
                // Turtle's default prefix corresponds most closely to @vocab.
                context["@vocab"] <- JValue(namespaceIri)
            else
                let prefixDefinition = JObject()

                prefixDefinition["@id"] <- JValue(namespaceIri)

                prefixDefinition["@prefix"] <- JValue(true)

                context[prefix] <- prefixDefinition

        context

    let compactedFromIgraph (graph: IGraph) =
        let store = new TripleStore()
        store.Add(graph) |> ignore

        let expandedJsonLd = JsonLdWriter().SerializeStore(store)

        let context = contextFromGraph graph

        let options = JsonLdProcessorOptions()
        options.Ordered <- true

        JsonLdProcessor.Compact(expandedJsonLd, context, options)
        |> _.ToString(Formatting.Indented)

    let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) = 
        let fileText = 
            { triples = draft.triples }
            |> IGraph.fromRdfGraph
            |> compactedFromIgraph

        let filePath = syntax.filePath parentDirectory stem
        File.WriteAllText(filePath, fileText)
module JsonRq =
    
    let syntax = 
        { syntaxName = "SPARQL Results JSON"
          fileExtension = "rq.json" }
    let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) =
        let filePath = syntax.filePath parentDirectory stem
        let store = new TripleStore()

        store.Add({ triples = draft.triples } |> IGraph.fromRdfGraph) |> ignore

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
            filePath
        )
module ddot =
    module it =
        let syntax =
            { syntaxName = "ddot.it"
              fileExtension = "ddot" }

        let tripleDdot (rdfTriple: RDFTriple) =
            sprintf
                "%s..%s..%s"
                (NTriples.subjectNt rdfTriple.curSubject)
                (NTriples.predicateNt rdfTriple.curPredicate)
                (NTriples.objectNt rdfTriple.curObject)

        let graphLines (rdfTripleSet: RdfTripleSet) =
            rdfTripleSet.triples
            |> Array.ofSeq
            |> Array.Parallel.map (fun triple -> tripleDdot triple)

        let graphText (rdfTripleSet: RdfTripleSet) =
            rdfTripleSet |> graphLines |> String.concat "\n"

        let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) =
            let fileText = { triples = draft.triples } |> graphText

            let filePath = syntax.filePath parentDirectory stem
            File.WriteAllText(filePath, fileText)



module Dot =

    let syntax =
        { syntaxName = "Graphviz"
          fileExtension = "dot" }

    let prefixDelimiter = ":"

    let vertexDot (vertex: Vertex) (globalPrefixMap:Map<string, string>) =
        vertex.asRenderedString prefixDelimiter globalPrefixMap

    let edgeDot (edge: Edge) (globalPrefixMap:Map<string, string>) =
        edge.asRenderedString prefixDelimiter globalPrefixMap

    let yogOptions(globalPrefixMap:Map<string, string>): Dot.Options<Vertex, Edge> =
        {

          NodeLabel = (fun _ vertex -> vertexDot vertex globalPrefixMap)
          EdgeLabel = (fun edge -> edgeDot edge globalPrefixMap)
          HighlightedSourceNodes = Set.empty
          HighlightedSinkNodes = Set.empty
          HighlightedNodes = Set.empty
          HighlightedEdges = Set.empty
          NodeShape = "ellipse"
          HighlightColor = "red"

        }


    let writeYograph (parentDirectory: string) (stem: string) (globalPrefixMap:Map<string, string>)(yograph: YoGraph) =
        let filePath = syntax.filePath parentDirectory stem
        Dot.writeFile filePath (yogOptions globalPrefixMap) yograph

    let writeQuikGraph (parentDirectory: string) (stem: string) (globalPrefixMap:Map<string, string>)(quikGraph: QuikGraph) =
        let dotGraph = new GraphvizAlgorithm<Vertex, QuikEdge>(quikGraph)

        dotGraph.FormatVertex.Add (fun args ->

            args.VertexFormat.Label <- (vertexDot args.Vertex globalPrefixMap)

        )

        dotGraph.FormatEdge.Add (fun args ->

            args.EdgeFormat.Label.Value <- (edgeDot args.Edge.Tag globalPrefixMap)

        )



        dotGraph.Generate(new FileDotEngine(), (syntax.filePath parentDirectory stem))
        |> ignore

    let writeDraftFromYograph (parentDirectory: string) (stem: string) (globalPrefixMap:Map<string, string>) (draft: Formula) =
        { triples = draft.triples }
        |> YoGraph.fromRdfGraph
        |> writeYograph parentDirectory $"{stem}.yog" globalPrefixMap

    let writeDraftFromQuikGraph (parentDirectory: string) (stem: string) (globalPrefixMap:Map<string, string>) (draft: Formula) =
        { triples = draft.triples }
        |> QuikGraph.fromRdfGraph
        |> writeQuikGraph parentDirectory $"{stem}.quik" globalPrefixMap

    let writeDraft (parentDirectory: string) (stem: string) (globalPrefixMap:Map<string, string>)(draft: Formula) =
        draft
        |> writeDraftFromYograph parentDirectory stem globalPrefixMap

        draft
        |> writeDraftFromQuikGraph parentDirectory stem globalPrefixMap

module Mermaid =

    let syntax =
        { syntaxName = "Mermaid"
          fileExtension = "mmd" }

    let prefixDelimiter = ":"

    let vertexMmd (vertex: Vertex)(globalPrefixMap:Map<string, string>) =
        vertex.asRenderedString prefixDelimiter globalPrefixMap

    let edgeMmd (edge: Edge) (globalPrefixMap:Map<string, string>)=
        edge.asRenderedString prefixDelimiter globalPrefixMap

    let options (globalPrefixMap:Map<string, string>): Mermaid.Options<Vertex, Edge> =
        {

          Direction = "LR"
          NodeLabel = (fun vertexId vertex -> vertexMmd vertex globalPrefixMap)
          EdgeLabel = (fun edge -> edgeMmd edge globalPrefixMap)
          HighlightedEdges = Set.empty
          HighlightedNodes = Set.empty
          HighlightedSinkNodes = Set.empty
          HighlightedSourceNodes = Set.empty

        }

    let writeYograph (parentDirectory: string) (stem: string) (globalPrefixMap:Map<string, string>) yograph =
        let filePath = syntax.filePath parentDirectory stem
        Mermaid.writeFile filePath (options globalPrefixMap) yograph

    let writeDraft (parentDirectory: string) (stem: string) (globalPrefixMap:Map<string, string>)(draft: Formula) =
        { triples = draft.triples }
        |> YoGraph.fromRdfGraph
        |> writeYograph parentDirectory stem globalPrefixMap



module d2 =
    let syntax =
        { syntaxName = "d2"
          fileExtension = "d2" }

    let prefixDelimiter = "\\:"

    let vertexD2 (vertex: Vertex) (globalPrefixMap:Map<string, string>)=
        vertex.asRenderedString prefixDelimiter globalPrefixMap

    let edgeD2 (edge: Edge) (globalPrefixMap:Map<string, string>)=
        edge.asRenderedString prefixDelimiter globalPrefixMap

    let graphLines (globalPrefixMap:Map<string, string>) (rdfTripleSet: RdfTripleSet) =
        rdfTripleSet.triples
        |> Array.ofSeq
        |> Array.Parallel.map (fun triple ->
            SubjectVertex triple.curSubject, ObjectVertex triple.curObject, PredicateEdge triple.curPredicate)
        |> Array.Parallel.map (fun (inVertex, outVertex, outEdge) ->
            sprintf "%s -> %s : %s" (vertexD2 inVertex globalPrefixMap) (vertexD2 outVertex globalPrefixMap) (edgeD2 outEdge globalPrefixMap))

    let graphText (globalPrefixMap:Map<string, string>)(rdfTripleSet: RdfTripleSet) =
        rdfTripleSet |> graphLines globalPrefixMap|> String.concat "\n"

    let writeDraft (parentDirectory: string) (stem: string) (globalPrefixMap:Map<string, string>)(draft: Formula) =
        let fileText = { triples = draft.triples } |> graphText globalPrefixMap

        let filePath = syntax.filePath parentDirectory stem
        File.WriteAllText(filePath, fileText)

module ForceGraph2D = 
    let syntax =
        { syntaxName = "2d force-graph"
          fileExtension = "force-graph.2d.json" }
    
    let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) =
        let fileText = Json.serialize({ triples = draft.triples } |> ForceGraph.fromRdfGraph )

        let filePath = syntax.filePath parentDirectory stem
        File.WriteAllText(filePath, fileText)








module Formula =
    let materializeTriples (draft: Formula) = draft.materializeTriples
    let emitTriples (draft: Formula) = draft.triples
    let toRdfGraph (draft: Formula) = { triples = draft.triples }

    let toIgraph (draft: Formula) =
        draft |> toRdfGraph |> IGraph.fromRdfGraph

let writeDraft  parentDirectory stem (globalPrefixMap:Map<string, string>) draft =
    Turtle.writeDraft parentDirectory stem draft
    Dot.writeDraft parentDirectory stem globalPrefixMap draft
    ddot.it.writeDraft parentDirectory stem draft
    Mermaid.writeDraft parentDirectory stem globalPrefixMap draft
    d2.writeDraft parentDirectory stem globalPrefixMap draft
    JsonLd.writeDraft parentDirectory stem draft
    JsonRq.writeDraft parentDirectory stem draft
    ForceGraph2D.writeDraft parentDirectory stem draft