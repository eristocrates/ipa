#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#r "PathErgonomics.dll"
open PathErgonomics
#r "RdfAsm.dll"

open RdfAsm
#r "SparqlErgonomics.dll"
open SparqlErgonomics
#r "XmlErgonomics.dll"
open XmlErgonomics
#r "Metaprogramming.dll"
open Metaprogramming

open System
open VDS.RDF

open QuikGraph
open QuikGraph.Data
open QuikGraph.Graphviz
open QuikGraph.MSAGL
open QuikGraph.Petri
open QuikGraph.Serialization


open Yog.Builder
open Yog.IO
open Yog.Model
open Yog.Pathfinding.Dijkstra
open Yog.Render
open Yog.Render.Dot
open Yog.Render.Mermaid
open FolkerKinzel.MimeTypes
open System.IO
open VDS.RDF.Parsing
open VDS.RDF.Query.Datasets
open VDS.RDF.Ontology
open RDFSharp.Model
open FSharp.Json













type IGraph with

    member this.mapPrefixes () =
        this.AllNodes
        |> Seq.iter(fun (inode) -> 
            match Point.fromINode inode with 
            | IriPoint (PrefixedIri prefixedName) -> this.NamespaceMap.AddNamespace prefixedName.prefixId.asNamespaceMap
            | _ -> ()
        )
    static member fromRdfTripleSet (rdfTripleSet :RdfTripleSet) = 
        let graph = new ThreadSafeGraph()
        graph.Assert( rdfTripleSet.triples |> Seq.map (fun triple -> triple.asVDSTriple)) |> ignore
        graph



type TextualSyntax =
    {

      syntaxName: string
      fileExtension: string

     }
    member this.mimeType = MimeString.FromFileName this.fileExtension
    member this.filePath parentDirectory stem =
        Directory.CreateDirectory(parentDirectory)
        |> ignore

        Path.Combine(parentDirectory, stem + this.fileExtension)


module Turtle =
    open VDS.RDF.Parsing
    open System.Text
    open VDS.RDF.Writing.Formatting
    open VDS.RDF.Writing
    let syntax =
        { syntaxName = "Turtle"
          fileExtension = ".ttl" }


    let isValidPrefixedNameRelaxed (s: string) =
        if s.Contains(".") then
            true
        else
            TurtleSpecsHelper.IsValidQName(s)

    let percentEncodeCharUtf8 (ch: char) =
        Encoding.UTF8.GetBytes([| ch |])
        |> Seq.map (fun b -> "%" + b.ToString("X2"))
        |> String.concat ""

    let isForbiddenInTurtleIriRef (ch: char) =
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

    let escapeIriRefByPercentEncoding (iri: string) =
        let sb = System.Text.StringBuilder(iri.Length)

        for ch in iri do
            if isForbiddenInTurtleIriRef ch then
                sb.Append(percentEncodeCharUtf8 ch) |> ignore
            else
                sb.Append(ch) |> ignore

        sb.ToString()

    let formatIriRefFromOriginalString (uri: Uri) =
        "<"
        + escapeIriRefByPercentEncoding uri.OriginalString
        + ">"

    let isAsciiSafeLocal (local: string) =
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

    let isValidLocalName (local: string) =
        if String.IsNullOrEmpty(local) then
            false
        elif local.Contains("/") then
            false
        else
            TurtleSpecsHelper.IsValidQName("p:" + local)
            || isAsciiSafeLocal local

    let tryReduceToPrefixOnly (nsMap: INamespaceMapper) (uriOriginal: string) =
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

    let tryReduceToPrefixedNameLongest (nsMap: INamespaceMapper) (uriOriginal: string) : string option =
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

    let tryReduceToPrefixedName (nsMap: INamespaceMapper) (uriOriginal: string) =
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
                && uri.AbsoluteUri.Equals((PrefixId.rdf.prefix "type").identity, StringComparison.Ordinal)
            then
                "a"
            else
                match tryReduceToPrefixedName g.NamespaceMap uri.OriginalString with
                | Some prefixedName -> prefixedName
                | None -> formatIriRefFromOriginalString uri

    let writeAllPrefixes (tw: TextWriter) (g: IGraph) =
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
        graph.mapPrefixes()

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
        |> IGraph.fromRdfTripleSet
        |> writeIgraph parentDirectory stem



let distributionMap = 
    [|

                    "http://purl.org/vocab/vann/", "http://purl.org/vocab/vann/vann-vocab-20100607.rdf"
                    "http://rdfs.org/ns/void#", "https://lov.linkeddata.es/generated/widoco/void-1788068093928-33605f87/ontology.ttl"
                    "http://purl.org/vocommons/voaf#", "https://lov.linkeddata.es/generated/widoco/voaf-1788235281178-42d2c623/ontology.ttl"
                    "http://www.linkedmodel.org/schema/vaem#", "http://www.linkedmodel.org/1.2/schema/OSG_vaem-(v1.2).ttl"
        
    |]
    |> Map.ofArray




type RdfDatasetDocument = 
    {
    datasetFile: FileInfo
    }
    member this.asTripleStore = 
        let tripleStore = new TripleStore()
        FileLoader.Load(tripleStore, this.datasetFile.FullName)
        // TODO figure out how to get namespacemap of all graphs
        // namespaceMapper.Import tripleStore.NamespaceMap
        tripleStore
    member this.asInMemoryQuadDataset = 
        new InMemoryQuadDataset(this.asTripleStore)
    member this.asSparqlLocalDataset = SparqlLocalDataset.fromDataset this.asInMemoryQuadDataset






type RdfGraphDocument = 
  {
    graphFile: FileInfo
  }
  static member fromTurtleVocabulary (prefixId:PrefixId) = { graphFile = prefixId.asFileExtension ".ttl" }
  member this.asIGraph :IGraph = 
        let igraph = new ThreadSafeGraph()
        FileLoader.Load(igraph,this.graphFile.FullName)
        namespaceMapper.Import igraph.NamespaceMap
        igraph
  member this.asOntologyGraph = 
        let ontologyGraph = new OntologyGraph()
        FileLoader.Load(ontologyGraph,this.graphFile.FullName)
        namespaceMapper.Import ontologyGraph.NamespaceMap
        ontologyGraph
  member this.asSparqlLocalDataset = SparqlLocalDataset.fromGraph this.asIGraph

  member this.asRDFGraph = RDFGraph.FromFile(RDFModelEnums.RDFFormats.Turtle, this.graphFile.FullName)
  // member this.asOWLOntology = task { return! OWLOntology.FromRDFGraphAsync this.asRDFGraph } |> Async.AwaitTask |> Async.RunSynchronously
  member this.asDataTable = this.asRDFGraph.ToDataTable()
  member this.points = 
      this.asIGraph.AllNodes
    |> Seq.toArray
    |> Array.map Point.fromINode
  member this.iris = this.points |> Array.choose (fun point -> 
    match point with 
    | IriPoint iri -> Some iri
    | _ -> None
    )
  member this.prefixedNames = this.iris |> Array.choose (fun iri -> 
    match iri with 
    | PrefixedIri prefixedName -> Some prefixedName
    | _ -> None
    )

  member this.literals = this.points |> Array.choose (fun point -> 
    match point with 
    | LiteralPoint literal -> Some literal
    | _ -> None
    )
  member this.blankNodes = this.points |> Array.choose (fun point -> 
    match point with 
    | BlankPoint blankNode -> Some blankNode
    | _ -> None
    )

  member this.namespacedNames (namespacePrefixId:PrefixId) = 
      this.prefixedNames |> Array.filter (fun prefixedName -> prefixedName.prefixId.namespaceName = namespacePrefixId.namespaceName) |> Array.sortBy (fun prefixedName -> prefixedName.localName)


type RdfVocabulary = 
    {
        prefixId : PrefixId
        namespaceDocument : RdfGraphDocument
    }
    member this.fsxFile = Path.Combine (Folder.Generated.FullName,  $"{this.prefixId.prefixLabel}Namespace.fsx") |> FileInfo
    
    member inline this.maybeOntologyClass<'Term when 'Term : (member asINode:INode)> (term:'Term) =  this.namespaceDocument.asOntologyGraph.AllClasses |> Seq.tryFind (fun ontologyClass -> ontologyClass.Resource = term.asINode )
    member inline this.maybeOntologyProperty<'Term when 'Term : (member asINode:INode)> (term:'Term) =  this.namespaceDocument.asOntologyGraph.AllProperties |> Seq.tryFind (fun ontologyProperty -> ontologyProperty.Resource = term.asINode )
    member this.OntologyClasses = this.namespaceDocument.asOntologyGraph.AllClasses |> Seq.toArray
    member this.OntologyProperties = this.namespaceDocument.asOntologyGraph.AllProperties |> Seq.toArray
    member this.RdfClasses = this.namespaceDocument.asOntologyGraph.RdfClasses |> Seq.toArray
    member this.RdfProperties = this.namespaceDocument.asOntologyGraph.RdfProperties |> Seq.toArray
    member this.OwlClasses = this.namespaceDocument.asOntologyGraph.OwlClasses |> Seq.toArray
    member this.OwlProperties = this.namespaceDocument.asOntologyGraph.OwlProperties |> Seq.toArray
    member this.OwlDatatypeProperties = this.namespaceDocument.asOntologyGraph.OwlDatatypeProperties |> Seq.toArray
    member this.OwlObjectProperties = this.namespaceDocument.asOntologyGraph.OwlObjectProperties |> Seq.toArray
    member this.OwlAnnotationProperties = this.namespaceDocument.asOntologyGraph.OwlAnnotationProperties |> Seq.toArray
    member this.AllOntologyResources = 
        Array.concat [|
            this.OntologyClasses |> Array.map (fun ontologyClass -> ontologyClass :> OntologyResource)
            this.OntologyProperties  |> Array.map (fun ontologyProperty -> ontologyProperty :> OntologyResource)
            |]
    member inline this.OntologyResourceByTerm<'Term when 'Term : (member asINode:INode)> (term:'Term) =   this.AllOntologyResources |> Array.tryFind (fun ontologyResource -> ontologyResource.Resource = term.asINode  ) 
    member inline this.termComment<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> ontologyResource.Comment |> Seq.map (fun iliteralNode -> RdfLiteral.fromILiteralNode iliteralNode ) |> Seq.toArray
        | None -> [||]
    member inline this.termDifferentFrom<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> ontologyResource.DifferentFrom |> Seq.map (fun inode -> Point.fromINode inode ) |> Seq.toArray
        | None -> [||]
    member inline this.termDirectSubClasses<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.DirectSubClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termDirectSubProperties<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.DirectSubProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termDirectSuperClasses<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.DirectSuperClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termDirectSuperProperties<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.DirectSuperProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termDisjointClasses<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.DisjointClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termDomains<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.Domains |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termRanges<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.Ranges |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termEquivalentClasses<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.EquivalentClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termEquivalentProperties<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.EquivalentProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIndirectSubClasses<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.IndirectSubClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIndirectSuperClasses<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.IndirectSuperClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIndirectSubProperties<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.IndirectSubProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIndirectSuperProperties<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.IndirectSuperProperty |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termInverseProperties<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.InverseProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termInstances<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.Instances |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIsBottomClass<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.IsBottomClass
            | _ -> false
        | None -> false
    member inline this.termIsBottomProperty<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.IsBottomProperty
            | _ -> false
        | None -> false
    member inline this.termIsDefinedBy<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> ontologyResource.IsDefinedBy |> Seq.map (fun inode -> Point.fromINode inode ) |> Seq.toArray
        | None -> [||]
    member inline this.termIsDomainOf<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.IsDomainOf |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIsRangeOf<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.IsRangeOf |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIsTopClass<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.IsTopClass
            | _ -> false
        | None -> false
    member inline this.termIsTopProperty<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.IsTopProperty
            | _ -> false
        | None -> false
    member inline this.termLabel<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> ontologyResource.Label |> Seq.map (fun iliteralNode -> RdfLiteral.fromILiteralNode iliteralNode ) |> Seq.toArray
        | None -> [||]
    member inline this.termSameAs<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> ontologyResource.SameAs |> Seq.map (fun inode -> Point.fromINode inode ) |> Seq.toArray
        | None -> [||]
    member inline this.termSeeAlso<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> ontologyResource.SeeAlso |> Seq.map (fun inode -> Point.fromINode inode ) |> Seq.toArray
        | None -> [||]
    member inline this.termSiblingClasses<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.Siblings |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termSiblingProperties<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.Siblings |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termUsedBy<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.UsedBy |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termSubClasses<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.SubClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termSuperClasses<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyClass as ontologyClass -> ontologyClass.SuperClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termSubProperties<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.SubProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termSuperProperties<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with 
        | Some ontologyResource -> 
            match ontologyResource with 
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.SuperProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termTriples<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with
        | Some ontologyResource -> ontologyResource.Triples |> Seq.map (fun vdsTriple -> RdfTriple.fromVDSTriple vdsTriple ) |> Seq.toArray
        | None -> [||]
    member inline this.termTriplesWithObject<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with
        | Some ontologyResource -> ontologyResource.TriplesWithObject |> Seq.map (fun vdsTriple -> RdfTriple.fromVDSTriple vdsTriple ) |> Seq.toArray
        | None -> [||]
    member inline this.termTriplesWithPredicate<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with
        | Some ontologyResource -> ontologyResource.TriplesWithPredicate |> Seq.map (fun vdsTriple -> RdfTriple.fromVDSTriple vdsTriple ) |> Seq.toArray
        | None -> [||]
    member inline this.termTriplesWithSubject<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with
        | Some ontologyResource -> ontologyResource.TriplesWithSubject |> Seq.map (fun vdsTriple -> RdfTriple.fromVDSTriple vdsTriple ) |> Seq.toArray
        | None -> [||]
    member inline this.termTriplesWithLiteralObject<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        this.termTriplesWithSubject term
        |> Array.filter (fun triple -> triple.curObject.IsLiteralObject)
    member inline this.termTriplesWithIriObject<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        this.termTriplesWithSubject term
        |> Array.filter (fun triple -> triple.curObject.IsIriObject)
    member inline this.termTriplesWithBlankObject<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        this.termTriplesWithSubject term
        |> Array.filter (fun triple -> triple.curObject.IsBlankObject)
        
    member inline this.termTriplesWithReferenceObject<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        Array.concat [|
            this.termTriplesWithIriObject term
            this.termTriplesWithBlankObject term
        |]
    member inline this.termTypes<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with
        | Some ontologyResource -> ontologyResource.Types |> Seq.map (fun inode -> Point.fromINode inode ) |> Seq.toArray
        | None -> [||]
    member inline this.termVersionInfo<'Term when 'Term : (member asINode:INode)> (term:'Term) = 
        match this.OntologyResourceByTerm term with
        | Some ontologyResource -> ontologyResource.VersionInfo |> Seq.map (fun iliteralNode -> RdfLiteral.fromILiteralNode iliteralNode ) |> Seq.toArray
        | None -> [||]


    member inline this.ontologyClassesByMetaClass<'Term when 'Term : (member asINode:INode)> (metaClass:'Term) = this.namespaceDocument.asOntologyGraph.GetClasses metaClass.asINode |> Seq.toArray
    member this.namespacedNames = this.namespaceDocument.namespacedNames this.prefixId
    member this.termByName = 
        this.namespacedNames 
        |> Array.map (fun prefixedName -> prefixedName.localName, prefixedName )
        |> Map.ofArray



module RdfVocabulary = 
    open XmlDocumentationComment
    open System.Text
    open VDS.RDF.Writing.Formatting
    open Fabulous.AST
    
    let fromPrefixId (prefixId :PrefixId) = 
        namespaceMapper.AddNamespace(prefixId.asNamespaceMap)

        let ttlFile = prefixId.asFileExtension ".ttl"

        let loader = new Loader()
        let graph = new ThreadSafeGraph()
        try 
            if ttlFile.Exists then
                printfn "Loading %s from %s" prefixId.namespaceName ttlFile.FullName 
                loader.LoadGraph(graph, Uri ttlFile.FullName)
            else
                let distribution = 
                    match distributionMap.TryFind prefixId.namespaceName with 
                    | Some distribution -> distribution
                    | None -> prefixId.namespaceName
                printfn "Dereferencing distribution %s for %s " distribution prefixId.namespaceName
                loader.LoadGraph(graph, Uri distribution)
                Directory.CreateDirectory ttlFile.DirectoryName |> ignore
            
                use fileStream =
                    new FileStream(ttlFile.FullName, FileMode.Create, FileAccess.Write, FileShare.Read)
                use streamWriter = new StreamWriter(fileStream, new UTF8Encoding(false))
                Turtle.writeAllPrefixes streamWriter graph
                let formatter = Turtle.UnicodePrefixedNameTurtleW3CFormatter(graph) :> ITripleFormatter

                printfn "Writing %s to %s" prefixId.namespaceName ttlFile.FullName
                for triple in graph.Triples do
                    streamWriter.WriteLine(formatter.Format(triple))

                streamWriter.Flush()
        with 
        | _ -> ()
        {
            prefixId =  prefixId
            namespaceDocument = { graphFile = prefixId.asFileExtension ".ttl" }
        }
    let asModule(vocabulary:RdfVocabulary) = 

        Ast.Oak() {
              Ast.AnonymousModule(){
                Ast.HashDirective("I",Ast.VerbatimString(@"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL") )
                Ast.HashDirective("load", Ast.VerbatimString(@".paket/load/main.group.fsx") )
                Ast.HashDirective("r", Ast.VerbatimString("RdfAsm.dll"))
                Ast.Open("RdfAsm")
                Ast.HashDirective("r", Ast.VerbatimString("RdfIO.dll"))
                Ast.Open("RdfIO")
                Ast.Module(vocabulary.prefixId.prefixLabel){
                    Ast.Value("_prefixId", $"PrefixId.fromNamespaceLabel \"{vocabulary.prefixId.namespaceName}\" \"{vocabulary.prefixId.prefixLabel}\"")
                    for namespacedName in vocabulary.namespacedNames do 
                        // printfn "%s" namespacedName.localName
                        
                        let binding = 
                          match namespacedName.localName with 
                          | "" -> "_namespaceIri"
                          | _ -> 
                              let binder = VariableBinder namespacedName.localName
                              binder.binding
                        let astValue = Ast.Value(binding, $"_prefixId.prefix \"{namespacedName.localName}\"" )
                        let triplesWithLiteralObject = vocabulary.termTriplesWithLiteralObject namespacedName

                        if triplesWithLiteralObject |> _.Length > 0 then 

                            let datatypePropertyValues = 
                                triplesWithLiteralObject    
                                |> Array.groupBy (fun triple -> triple.curPredicate)
                                |> Array.map (fun (curPredicate, triples) -> curPredicate, triples |> Array.map (fun triple -> triple.curObject))
                            let elements :LitXml.XmlPart array = 
                                    [|

                                        summary {
                                            for datatypeProperty, propertyValues in datatypePropertyValues do  
                                                match datatypeProperty.lexicalForm with 

                                                | _ -> 
                                                      para { 
                                                            for propertyValue in propertyValues do 
                                                                $"{defaultArg datatypeProperty.maybeCurie datatypeProperty.lexicalForm} : {defaultArg propertyValue.maybeCurie propertyValue.lexicalForm}"
                                                      }
                                                                
                                            a {
                                                _href namespacedName.lexicalForm
                                                namespacedName.curie
                                            }
                                        }
                                    |]


                            astValue.xmlDocs( LitXml.ElementBuilder.writeToXmlDocs elements )
                        else 
                            astValue


              }
              }
        }
        |> Gen.mkOak
        |> Gen.run




(*
let ttlDocuments = Folder.Iri.GetFiles("*.ttl", SearchOption.AllDirectories) |> Array.Parallel.map (fun rdfFile -> { rdfFile = rdfFile } )
let owlDocuments = 
  rdfDocuments |> Array.Parallel.choose (fun rdfDocument -> 
      try 
          match rdfDocument.asOWLOntology with 
          | _ -> Some rdfDocument
      with 
      | _ -> None
        )

*)













[<CLIMutable>]
type ForceNode = { id: string }


[<CLIMutable>]
type ForceLink =
    { source: string
      target: string
      predicate: string }
    static member typeName = "ForceLink"

type RdfTripleSet with 

    member this.forceLinks =

        this.triples
        |> Array.ofSeq
        |> Array.map (fun triple ->
            { source = triple.curSubject.lexicalForm
              target = triple.curObject.lexicalForm
              predicate = triple.curPredicate.lexicalForm })

    member this.forceNodes =
        this.forceLinks
        |> Array.collect (fun link -> [| link.source; link.target |])
        |> Array.distinct
        |> Array.map (fun id -> { id = id })

/// https://github.com/vasturiano/force-graph
[<CLIMutable>]
type ForceGraph =
    {

      nodes: ForceNode array
      links: ForceLink array

     }
    static member typeName = "ForceGraph"

    static member fromRdfTripleSet(rdfTripleSet: RdfTripleSet) =
        { nodes = rdfTripleSet.forceNodes
          links = rdfTripleSet.forceLinks }




module NTriples =

    let syntax =
        { syntaxName = "NTriples"
          fileExtension = ".nt"

        }


    let parser = NTriplesParser()

    let parse (text: string) (graph: IGraph) =
        try
            use reader = new StringReader(text)
            parser.Load(graph, reader)
        with
        | err ->

            failwithf "The text %s failed to parse with error %s" text err.Message




NTriples.syntax.mimeType

type YoGraph = Graph<Vertex, Edge>


module YoGraph =
    let fromRdfTripleSet (rdfTripleSet: RdfTripleSet) =
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
    let fromRdfTripleSet (rdfTripleSet: RdfTripleSet) =
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



module JsonLd =
    open VDS.RDF.Writing
    open Newtonsoft.Json.Linq
    open VDS.RDF.JsonLd
    let syntax =
        { syntaxName = "JsonLd"
          fileExtension = ".jsonld" }
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

        JsonLdProcessor.Compact(expandedJsonLd, context, options).ToString(Newtonsoft.Json.Formatting.Indented)

    let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) = 
        let fileText: string = 
            { triples = draft.triples }
            |> IGraph.fromRdfTripleSet
            |> compactedFromIgraph

        let filePath = syntax.filePath parentDirectory stem
        File.WriteAllText(filePath, fileText)


module JsonRq =
    open VDS.RDF.Query
    open VDS.RDF.Writing
    
    let syntax = 
        { syntaxName = "SPARQL Results JSON"
          fileExtension = ".rq.json" }
    let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) =
        let filePath = syntax.filePath parentDirectory stem
        let store = new TripleStore()

        store.Add({ triples = draft.triples } |> IGraph.fromRdfTripleSet) |> ignore

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
              fileExtension = ".ddot" }

        let tripleDdot (rdfTriple: RdfTriple) =
            sprintf
                "%s..%s..%s"
                (defaultArg rdfTriple.curSubject.maybeCurie rdfTriple.curSubject.lexicalForm)
                (defaultArg rdfTriple.curPredicate.maybeCurie rdfTriple.curPredicate.lexicalForm)
                (defaultArg rdfTriple.curObject.maybeCurie rdfTriple.curObject.lexicalForm)

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
          fileExtension = ".dot" }

    let prefixDelimiter = ":"

    let vertexDot (vertex: Vertex)  =
        vertex.asRenderedString prefixDelimiter 

    let edgeDot (edge: Edge)  =
        edge.asRenderedString prefixDelimiter 

    let yogOptions: Dot.Options<Vertex, Edge> =
        {

          NodeLabel = (fun _ vertex -> vertexDot vertex )
          EdgeLabel = (fun edge -> edgeDot edge )
          HighlightedSourceNodes = Set.empty
          HighlightedSinkNodes = Set.empty
          HighlightedNodes = Set.empty
          HighlightedEdges = Set.empty
          NodeShape = "ellipse"
          HighlightColor = "red"

        }


    let writeYograph (parentDirectory: string) (stem: string) (yograph: YoGraph) =
        let filePath = syntax.filePath parentDirectory stem
        Dot.writeFile filePath yogOptions  yograph

    let writeQuikGraph (parentDirectory: string) (stem: string) (quikGraph: QuikGraph) =
        let dotGraph = new GraphvizAlgorithm<Vertex, QuikEdge>(quikGraph)

        dotGraph.FormatVertex.Add (fun args ->

            args.VertexFormat.Label <- (vertexDot args.Vertex)

        )

        dotGraph.FormatEdge.Add (fun args ->

            args.EdgeFormat.Label.Value <- (edgeDot args.Edge.Tag)

        )



        dotGraph.Generate(new FileDotEngine(), (syntax.filePath parentDirectory stem))
        |> ignore

    let writeDraftFromYograph (parentDirectory: string) (stem: string)  (draft: Formula) =
        { triples = draft.triples }
        |> YoGraph.fromRdfTripleSet
        |> writeYograph parentDirectory $"{stem}.yog" 

    let writeDraftFromQuikGraph (parentDirectory: string) (stem: string)  (draft: Formula) =
        { triples = draft.triples }
        |> QuikGraph.fromRdfTripleSet
        |> writeQuikGraph parentDirectory $"{stem}.quik" 

    let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) =
        draft
        |> writeDraftFromYograph parentDirectory stem 

        draft
        |> writeDraftFromQuikGraph parentDirectory stem 

module Mermaid =

    let syntax =
        { syntaxName = "Mermaid"
          fileExtension = ".mmd" }

    let prefixDelimiter = ":"

    let vertexMmd (vertex: Vertex) =
        vertex.asRenderedString prefixDelimiter 

    let edgeMmd (edge: Edge) =
        edge.asRenderedString prefixDelimiter 

    let options : Mermaid.Options<Vertex, Edge> =
        {

          Direction = "LR"
          NodeLabel = (fun vertexId vertex -> vertexMmd vertex )
          EdgeLabel = (fun edge -> edgeMmd edge )
          HighlightedEdges = Set.empty
          HighlightedNodes = Set.empty
          HighlightedSinkNodes = Set.empty
          HighlightedSourceNodes = Set.empty

        }

    let writeYograph (parentDirectory: string) (stem: string)  yograph =
        let filePath = syntax.filePath parentDirectory stem
        Mermaid.writeFile filePath options  yograph

    let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) =
        { triples = draft.triples }
        |> YoGraph.fromRdfTripleSet
        |> writeYograph parentDirectory stem 



module d2 =
    let syntax =
        { syntaxName = "d2"
          fileExtension = ".d2" }

    let prefixDelimiter = "\\:"

    let vertexD2 (vertex: Vertex) =
        vertex.asRenderedString prefixDelimiter 

    let edgeD2 (edge: Edge) =
        edge.asRenderedString prefixDelimiter 

    let graphLines  (rdfTripleSet: RdfTripleSet) =
        rdfTripleSet.triples
        |> Array.ofSeq
        |> Array.Parallel.map (fun triple ->
            SubjectVertex triple.curSubject, ObjectVertex triple.curObject, PredicateEdge triple.curPredicate)
        |> Array.Parallel.map (fun (inVertex, outVertex, outEdge) ->
            sprintf "%s -> %s : %s" (vertexD2 inVertex ) (vertexD2 outVertex ) (edgeD2 outEdge ))

    let graphText (rdfTripleSet: RdfTripleSet) =
        rdfTripleSet |> graphLines |> String.concat "\n"

    let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) =
        let fileText = { triples = draft.triples } |> graphText 

        let filePath = syntax.filePath parentDirectory stem
        File.WriteAllText(filePath, fileText)

module ForceGraph2D = 
    let syntax =
        { syntaxName = "2d force-graph"
          fileExtension = ".force-graph.2d.json" }
    
    let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) =
        let fileText = Json.serialize({ triples = draft.triples } |> ForceGraph.fromRdfTripleSet )

        let filePath = syntax.filePath parentDirectory stem
        File.WriteAllText(filePath, fileText)








module Formula =
    let materializeTriples (draft: Formula) = draft.materializeTriples
    let emitTriples (draft: Formula) = draft.triples
    let toRdfGraph (draft: Formula) = { triples = draft.triples }

    let toIgraph (draft: Formula) =
        draft |> toRdfGraph |> IGraph.fromRdfTripleSet

let writeDraft  parentDirectory stem  draft =
    Turtle.writeDraft parentDirectory stem draft
    Dot.writeDraft parentDirectory stem  draft
    ddot.it.writeDraft parentDirectory stem draft
    Mermaid.writeDraft parentDirectory stem  draft
    d2.writeDraft parentDirectory stem  draft
    JsonLd.writeDraft parentDirectory stem draft
    JsonRq.writeDraft parentDirectory stem draft
    ForceGraph2D.writeDraft parentDirectory stem draft

















































