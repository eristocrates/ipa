#load @".paket/load/main.group.fsx"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#r "Ipa.dll"
open Ipa
#r "Iana.dll"
open Iana
#r "IanaScheme.dll"
#r "Turtle.dll"
#r "RdfAsm.dll"
open RdfAsm
#r "FSLang.dll"
#r "ResolvedResource.dll"
#r "XmlDocumentationComment.dll"
#r "NamespaceErgonomics.dll"

open NamespaceErgonomics
#r "ManualDistributions.dll"
open ManualDistributions
open System
open System.IO

open System
open VDS.RDF

open CaseConverter
open Humanizer
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

module Turtle =
    open VDS.RDF
    let writeDraft (parentDirectory: string) (stem: string) (draft: Formula) =
        let filePath = Turtle.syntax.filePath parentDirectory stem

        { triples = draft.triples }
        |> IGraph.fromRdfTripleSet
        |> Turtle.writeIgraph parentDirectory stem namespaceMapper








type RdfDatasetDocument = {
    datasetFile: FileInfo
} with

    member this.asTripleStore =
        let tripleStore = new TripleStore()
        FileLoader.Load(tripleStore, this.datasetFile.FullName)
        // TODO figure out how to get namespacemap of all graphs
        // namespaceMapper.Import tripleStore.NamespaceMap
        tripleStore
    member this.asInMemoryQuadDataset = new InMemoryQuadDataset(this.asTripleStore)
    member this.asSparqlLocalDataset = SparqlLocalDataset.fromDataset this.asInMemoryQuadDataset






type RdfGraphDocument = {
    graphFile: FileInfo
} with

    static member fromTurtleVocabulary(prefixId: PrefixId) = {
        graphFile = prefixId.namespaceTurtleFilePath.WeakString |> FileInfo
    }
    member this.asIGraph: IGraph =
        let igraph = new ThreadSafeGraph()
        FileLoader.Load(igraph, this.graphFile.FullName)
        namespaceMapper.Import igraph.NamespaceMap
        igraph
    member this.asOntologyGraph =
        let ontologyGraph = new OntologyGraph()
        FileLoader.Load(ontologyGraph, this.graphFile.FullName)
        namespaceMapper.Import ontologyGraph.NamespaceMap
        ontologyGraph
    member this.asSparqlLocalDataset = SparqlLocalDataset.fromGraph this.asIGraph

    member this.asRDFGraph = RDFGraph.FromFile(RDFModelEnums.RDFFormats.Turtle, this.graphFile.FullName)
    // member this.asOWLOntology = task { return! OWLOntology.FromRDFGraphAsync this.asRDFGraph } |> Async.AwaitTask |> Async.RunSynchronously
    member this.asDataTable = this.asRDFGraph.ToDataTable()
    member this.points = this.asIGraph.AllNodes |> Seq.toArray |> Array.map Point.fromINode
    member this.iris =
        this.points
        |> Array.choose (fun point ->
            match point with
            | IriPoint iri -> Some iri
            | _ -> None)
    member this.prefixedNames =
        this.iris
        |> Array.choose (fun iri ->
            match iri with
            | PrefixedIri prefixedName -> Some prefixedName
            | _ -> None)

    member this.literals =
        this.points
        |> Array.choose (fun point ->
            match point with
            | LiteralPoint literal -> Some literal
            | _ -> None)
    member this.blankNodes =
        this.points
        |> Array.choose (fun point ->
            match point with
            | BlankPoint blankNode -> Some blankNode
            | _ -> None)

    member this.namespacedNames(namespacePrefixId: PrefixId) =
        this.prefixedNames
        |> Array.filter (fun prefixedName -> prefixedName.prefixId.namespaceName = namespacePrefixId.namespaceName)
        |> Array.sortBy (fun prefixedName -> prefixedName.localName)


type RdfVocabulary = {
    prefixId: PrefixId
    namespaceDocument: RdfGraphDocument
} with

    member this.fsxFile =
        Path.Combine(ResolvedResource.GeneratedNamespaces.localReference, $"{this.prefixId.prefixLabel.FirstCharToUpperCase()}Namespace.fsx")
        |> FileInfo

    member inline this.maybeOntologyClass<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        this.namespaceDocument.asOntologyGraph.AllClasses
        |> Seq.tryFind (fun ontologyClass -> ontologyClass.Resource = term.asINode)
    member inline this.maybeOntologyProperty<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        this.namespaceDocument.asOntologyGraph.AllProperties
        |> Seq.tryFind (fun ontologyProperty -> ontologyProperty.Resource = term.asINode)
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
            this.OntologyClasses
            |> Array.map (fun ontologyClass -> ontologyClass :> OntologyResource)
            this.OntologyProperties
            |> Array.map (fun ontologyProperty -> ontologyProperty :> OntologyResource)
        |]
    member inline this.OntologyResourceByTerm<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        this.AllOntologyResources
        |> Array.tryFind (fun ontologyResource -> ontologyResource.Resource = term.asINode)
    member inline this.termComment<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.Comment
            |> Seq.map (fun iliteralNode -> RdfLiteral.fromILiteralNode iliteralNode)
            |> Seq.toArray
        | None -> [||]
    member inline this.termDifferentFrom<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.DifferentFrom
            |> Seq.map (fun inode -> Point.fromINode inode)
            |> Seq.toArray
        | None -> [||]
    member inline this.termDirectSubClasses<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.DirectSubClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termDirectSubProperties<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.DirectSubProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termDirectSuperClasses<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.DirectSuperClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termDirectSuperProperties<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.DirectSuperProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termDisjointClasses<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.DisjointClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termDomains<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.Domains |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termRanges<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.Ranges |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termEquivalentClasses<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.EquivalentClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termEquivalentProperties<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.EquivalentProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIndirectSubClasses<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.IndirectSubClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIndirectSuperClasses<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.IndirectSuperClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIndirectSubProperties<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.IndirectSubProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIndirectSuperProperties<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.IndirectSuperProperty |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termInverseProperties<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.InverseProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termInstances<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.Instances |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIsBottomClass<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.IsBottomClass
            | _ -> false
        | None -> false
    member inline this.termIsBottomProperty<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.IsBottomProperty
            | _ -> false
        | None -> false
    member inline this.termIsDefinedBy<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.IsDefinedBy
            |> Seq.map (fun inode -> Point.fromINode inode)
            |> Seq.toArray
        | None -> [||]
    member inline this.termIsDomainOf<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.IsDomainOf |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIsRangeOf<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.IsRangeOf |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termIsTopClass<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.IsTopClass
            | _ -> false
        | None -> false
    member inline this.termIsTopProperty<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.IsTopProperty
            | _ -> false
        | None -> false
    member inline this.termLabel<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.Label
            |> Seq.map (fun iliteralNode -> RdfLiteral.fromILiteralNode iliteralNode)
            |> Seq.toArray
        | None -> [||]
    member inline this.termSameAs<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.SameAs
            |> Seq.map (fun inode -> Point.fromINode inode)
            |> Seq.toArray
        | None -> [||]
    member inline this.termSeeAlso<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.SeeAlso
            |> Seq.map (fun inode -> Point.fromINode inode)
            |> Seq.toArray
        | None -> [||]
    member inline this.termSiblingClasses<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.Siblings |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termSiblingProperties<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.Siblings |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termUsedBy<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.UsedBy |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termSubClasses<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.SubClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termSuperClasses<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyClass as ontologyClass -> ontologyClass.SuperClasses |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termSubProperties<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.SubProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termSuperProperties<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            match ontologyResource with
            | :? OntologyProperty as ontologyProperty -> ontologyProperty.SuperProperties |> Seq.toArray
            | _ -> [||]
        | None -> [||]
    member inline this.termTriples<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.Triples
            |> Seq.map (fun vdsTriple -> RdfTriple.fromVDSTriple vdsTriple)
            |> Seq.toArray
        | None -> [||]
    member inline this.termTriplesWithObject<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.TriplesWithObject
            |> Seq.map (fun vdsTriple -> RdfTriple.fromVDSTriple vdsTriple)
            |> Seq.toArray
        | None -> [||]
    member inline this.termTriplesWithPredicate<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.TriplesWithPredicate
            |> Seq.map (fun vdsTriple -> RdfTriple.fromVDSTriple vdsTriple)
            |> Seq.toArray
        | None -> [||]
    member inline this.termTriplesWithSubject<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.TriplesWithSubject
            |> Seq.map (fun vdsTriple -> RdfTriple.fromVDSTriple vdsTriple)
            |> Seq.toArray
        | None -> [||]
    member inline this.termTriplesWithLiteralObject<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        this.termTriplesWithSubject term
        |> Array.filter (fun triple -> triple.curObject.IsLiteralObject)
    member inline this.termTriplesWithIriObject<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        this.termTriplesWithSubject term
        |> Array.filter (fun triple -> triple.curObject.IsIriObject)
    member inline this.termTriplesWithBlankObject<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        this.termTriplesWithSubject term
        |> Array.filter (fun triple -> triple.curObject.IsBlankObject)

    member inline this.termTriplesWithReferenceObject<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        Array.concat [| this.termTriplesWithIriObject term; this.termTriplesWithBlankObject term |]
    member inline this.termTypes<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.Types
            |> Seq.map (fun inode -> Point.fromINode inode)
            |> Seq.toArray
        | None -> [||]
    member inline this.termVersionInfo<'Term when 'Term: (member asINode: INode)>(term: 'Term) =
        match this.OntologyResourceByTerm term with
        | Some ontologyResource ->
            ontologyResource.VersionInfo
            |> Seq.map (fun iliteralNode -> RdfLiteral.fromILiteralNode iliteralNode)
            |> Seq.toArray
        | None -> [||]


    member inline this.ontologyClassesByMetaClass<'Term when 'Term: (member asINode: INode)>(metaClass: 'Term) =
        this.namespaceDocument.asOntologyGraph.GetClasses metaClass.asINode
        |> Seq.toArray
    member this.namespacedNames = this.namespaceDocument.namespacedNames this.prefixId
    member this.termByName =
        this.namespacedNames
        |> Array.map (fun prefixedName -> prefixedName.localName, prefixedName)
        |> Map.ofArray



module RdfVocabulary =
    open XmlDocumentationComment
    open System.Text
    open VDS.RDF.Writing.Formatting
    open Fabulous.AST

    let fromPrefixId (prefixId: PrefixId) =
        namespaceMapper.AddNamespace(prefixId.asNamespaceMap)

        let ttlFilePath = prefixId.namespaceTurtleFilePath
        let namespaceDocument = {
            graphFile = FileInfo ttlFilePath.WeakString
        }

        let loader = new Loader()
        let graph = new ThreadSafeGraph()
        try
            if ttlFilePath.Exists then
                printfn "Loading %s from %s" prefixId.namespaceName ttlFilePath.WeakString
                loader.LoadGraph(graph, Uri ttlFilePath.WeakString)
            else
                let distribution =
                    match
                        graphDistributions
                        |> Array.tryPick (fun (namespaceName, distributionResource) ->
                            if namespaceName = prefixId.namespaceName then
                                Some distributionResource.remoteReference
                            else
                                None)
                    with
                    | Some distribution -> distribution
                    | None -> prefixId.namespaceName
                printfn "Dereferencing distribution %s for %s " distribution prefixId.namespaceName
                loader.LoadGraph(graph, Uri distribution)
                Directory.CreateDirectory ttlFilePath.DirectoryPath.WeakString |> ignore

                use fileStream = new FileStream(ttlFilePath.WeakString, FileMode.Create, FileAccess.Write, FileShare.Read)
                use streamWriter = new StreamWriter(fileStream, new UTF8Encoding(false))
                Turtle.writeAllPrefixes streamWriter graph
                let formatter = Turtle.UnicodePrefixedNameTurtleW3CFormatter(graph) :> ITripleFormatter

                printfn "Writing %s to %s" prefixId.namespaceName ttlFilePath.WeakString
                for triple in graph.Triples do
                    streamWriter.WriteLine(formatter.Format(triple))

                streamWriter.Flush()
        with _ ->
            ()
        {
            prefixId = prefixId
            namespaceDocument = namespaceDocument
        }
    let asModule (vocabulary: RdfVocabulary) =

        Ast.Oak() {
            Ast.AnonymousModule() {
                Ast.HashDirective("I", Ast.VerbatimString(@"D:\https\com\github\eristocrates\ipa\fsx"))
                Ast.HashDirective("load", Ast.VerbatimString(@".paket/load/main.group.fsx"))
                Ast.HashDirective("r", Ast.VerbatimString("RdfAsm.dll"))
                Ast.Open("RdfAsm")
                Ast.HashDirective("r", Ast.VerbatimString("RdfIO.dll"))
                Ast.Open("RdfIO")
                Ast.Module(vocabulary.prefixId.prefixLabel) {
                    Ast.Value("_prefixId", $"PrefixId.fromNamespaceLabel \"{vocabulary.prefixId.namespaceName}\" \"{vocabulary.prefixId.prefixLabel}\"")
                    for namespacedName in vocabulary.namespacedNames do
                        // printfn "%s" namespacedName.localName

                        let binding =
                            match namespacedName.localName with
                            | "" -> "_namespaceIri"
                            | _ ->
                                let binder = FSLang.VariableBinder namespacedName.localName
                                binder.binding
                        let astValue = Ast.Value(binding, $"_prefixId.prefix \"{namespacedName.localName}\"")
                        let triplesWithLiteralObject = vocabulary.termTriplesWithLiteralObject namespacedName

                        if triplesWithLiteralObject |> _.Length > 0 then

                            let datatypePropertyValues =
                                triplesWithLiteralObject
                                |> Array.groupBy (fun triple -> triple.curPredicate)
                                |> Array.map (fun (curPredicate, triples) -> curPredicate, triples |> Array.map (fun triple -> triple.curObject))
                            let elements: LitXml.XmlPart array = [|

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


                            astValue.xmlDocs (LitXml.ElementBuilder.writeToXmlDocs elements)
                        else
                            astValue


                }
            }
        }
        |> Gen.mkOak
        |> Gen.run



type PrefixedName with
    member this._vocabulary = RdfVocabulary.fromPrefixId this.prefixId
    member this._maybeOntologyClass = this._vocabulary.maybeOntologyClass this
    member this._maybeOntologyProperty = this._vocabulary.maybeOntologyProperty this
    member this._asOntologyResource = this._vocabulary.OntologyResourceByTerm this
    member this._metaClass = this._vocabulary.ontologyClassesByMetaClass this
    member this._Comment = this._vocabulary.termComment this
    member this._DifferentFrom = this._vocabulary.termDifferentFrom this
    member this._DirectSubClasses = this._vocabulary.termDirectSubClasses this
    member this._DirectSubProperties = this._vocabulary.termDirectSubProperties this
    member this._DirectSuperClasses = this._vocabulary.termDirectSuperClasses this
    member this._DirectSuperProperties = this._vocabulary.termDirectSuperProperties this
    member this._DisjointClasses = this._vocabulary.termDisjointClasses this
    member this._Domains = this._vocabulary.termDomains this
    member this._Ranges = this._vocabulary.termRanges this
    member this._EquivalentClasses = this._vocabulary.termEquivalentClasses this
    member this._EquivalentProperties = this._vocabulary.termEquivalentProperties this
    member this._IndirectSubClasses = this._vocabulary.termIndirectSubClasses this
    member this._IndirectSuperClasses = this._vocabulary.termIndirectSuperClasses this
    member this._IndirectSubProperties = this._vocabulary.termIndirectSubProperties this
    member this._IndirectSuperProperties = this._vocabulary.termIndirectSuperProperties this
    member this._InverseProperties = this._vocabulary.termInverseProperties this
    member this._Instances = this._vocabulary.termInstances this
    member this._IsBottomClass = this._vocabulary.termIsBottomClass this
    member this._IsBottomProperty = this._vocabulary.termIsBottomProperty this
    member this._IsDefinedBy = this._vocabulary.termIsDefinedBy this
    member this._IsDomainOf = this._vocabulary.termIsDomainOf this
    member this._IsRangeOf = this._vocabulary.termIsRangeOf this
    member this._IsTopClass = this._vocabulary.termIsTopClass this
    member this._IsTopProperty = this._vocabulary.termIsTopProperty this
    member this._Label = this._vocabulary.termLabel this
    member this._SameAs = this._vocabulary.termSameAs this
    member this._SeeAlso = this._vocabulary.termSeeAlso this
    member this._SiblingClasses = this._vocabulary.termSiblingClasses this
    member this._SiblingProperties = this._vocabulary.termSiblingProperties this
    member this._UsedBy = this._vocabulary.termUsedBy this
    member this._SubClasses = this._vocabulary.termSubClasses this
    member this._SuperClasses = this._vocabulary.termSuperClasses this
    member this._SubProperties = this._vocabulary.termSubProperties this
    member this._SuperProperties = this._vocabulary.termSuperProperties this
    member this._Triples = this._vocabulary.termTriples this
    member this._TriplesWithObject = this._vocabulary.termTriplesWithObject this
    member this._TriplesWithPredicate = this._vocabulary.termTriplesWithPredicate this
    member this._TriplesWithSubject = this._vocabulary.termTriplesWithSubject this
    member this._TriplesWithLiteralObject = this._vocabulary.termTriplesWithLiteralObject this
    member this._TriplesWithIriObject = this._vocabulary.termTriplesWithIriObject this
    member this._TriplesWithBlankObject = this._vocabulary.termTriplesWithBlankObject this
    member this._TriplesWithReferenceObject = this._vocabulary.termTriplesWithReferenceObject this
    member this._Types = this._vocabulary.termTypes this
    member this._VersionInfo = this._vocabulary.termVersionInfo this


type Iri with
    member this._maybeVocabulary =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._vocabulary
        | _ -> None
    member this._maybeOntologyClass =
        match this with
        | PrefixedIri prefixedName -> prefixedName._maybeOntologyClass
        | _ -> None
    member this._maybemaybeOntologyProperty =
        match this with
        | PrefixedIri prefixedName -> prefixedName._maybeOntologyProperty
        | _ -> None
    member this._asOntologyResource =
        match this with
        | PrefixedIri prefixedName -> prefixedName._asOntologyResource
        | _ -> None
    member this._metaClass =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._metaClass
        | _ -> None
    member this._maybeComment =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._Comment
        | _ -> None
    member this._maybeDifferentFrom =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._DifferentFrom
        | _ -> None
    member this._maybeDirectSubClasses =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._DirectSubClasses
        | _ -> None
    member this._maybeDirectSubProperties =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._DirectSubProperties
        | _ -> None
    member this._maybeDirectSuperClasses =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._DirectSuperClasses
        | _ -> None
    member this._maybeDirectSuperProperties =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._DirectSuperProperties
        | _ -> None
    member this._maybeDisjointClasses =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._DisjointClasses
        | _ -> None
    member this._maybeDomains =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._Domains
        | _ -> None
    member this._maybeRanges =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._Ranges
        | _ -> None
    member this._maybeEquivalentClasses =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._EquivalentClasses
        | _ -> None
    member this._maybeEquivalentProperties =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._EquivalentProperties
        | _ -> None
    member this._maybeIndirectSubClasses =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._IndirectSubClasses
        | _ -> None
    member this._maybeIndirectSuperClasses =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._IndirectSuperClasses
        | _ -> None
    member this._maybeIndirectSubProperties =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._IndirectSubProperties
        | _ -> None
    member this._maybeIndirectSuperProperties =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._IndirectSuperProperties
        | _ -> None
    member this._maybeInverseProperties =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._InverseProperties
        | _ -> None
    member this._maybeInstances =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._Instances
        | _ -> None
    member this._maybeIsBottomClass =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._IsBottomClass
        | _ -> None
    member this._maybeIsBottomProperty =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._IsBottomProperty
        | _ -> None
    member this._maybeIsDefinedBy =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._IsDefinedBy
        | _ -> None
    member this._maybeIsDomainOf =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._IsDomainOf
        | _ -> None
    member this._maybeIsRangeOf =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._IsRangeOf
        | _ -> None
    member this._maybeIsTopClass =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._IsTopClass
        | _ -> None
    member this._maybeIsTopProperty =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._IsTopProperty
        | _ -> None
    member this._maybeLabel =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._Label
        | _ -> None
    member this._maybeSameAs =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._SameAs
        | _ -> None
    member this._maybeSeeAlso =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._SeeAlso
        | _ -> None
    member this._maybeSiblingClasses =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._SiblingClasses
        | _ -> None
    member this._maybeSiblingProperties =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._SiblingProperties
        | _ -> None
    member this._maybeUsedBy =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._UsedBy
        | _ -> None
    member this._maybeSubClasses =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._SubClasses
        | _ -> None
    member this._maybeSuperClasses =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._SuperClasses
        | _ -> None
    member this._maybeSubProperties =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._SubProperties
        | _ -> None
    member this._maybeSuperProperties =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._SuperProperties
        | _ -> None
    member this._maybeTriples =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._Triples
        | _ -> None
    member this._maybeTriplesWithObject =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._TriplesWithObject
        | _ -> None
    member this._maybeTriplesWithPredicate =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._TriplesWithPredicate
        | _ -> None
    member this._maybeTriplesWithSubject =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._TriplesWithSubject
        | _ -> None
    member this._maybeTriplesWithLiteralObject =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._TriplesWithLiteralObject
        | _ -> None
    member this._maybeTriplesWithIriObject =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._TriplesWithIriObject
        | _ -> None
    member this._maybeTriplesWithBlankObject =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._TriplesWithBlankObject
        | _ -> None
    member this._maybeTriplesWithReferenceObject =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._TriplesWithReferenceObject
        | _ -> None
    member this._maybeTypes =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._Types
        | _ -> None
    member this._maybeVersionInfo =
        match this with
        | PrefixedIri prefixedName -> Some prefixedName._VersionInfo
        | _ -> None



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
