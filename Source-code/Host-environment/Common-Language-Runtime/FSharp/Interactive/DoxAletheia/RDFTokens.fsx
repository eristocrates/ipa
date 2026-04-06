open System
open System.IO

#r "nuget: dotNetRdf"


open VDS.RDF
open VDS.RDF.Parsing
open VDS.RDF.Parsing.Tokens
open VDS.RDF.Ontology

#r "nuget: FSharp.Collections.ParallelSeq"
open FSharp.Collections.ParallelSeq


#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\StringErgonomics.fsx"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PathErgonomics.fsx"

open StringErgonomics
open PathErgonomics

let ontologyGraph = new OntologyGraph()

let filePath =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\xmlns.com\foaf\0.1\slash\foaf.rdf"

FileLoader.Load(ontologyGraph, filePath)








let NodeClass_from_NodeType<'NodeClass when 'NodeClass :> INode> (nodeType: NodeType) (inodes: INode seq) =
    inodes
    |> PSeq.filter (fun inode -> inode.NodeType = nodeType)
    |> PSeq.map (fun inode -> inode :?> 'NodeClass)








let BlankNodes_from_Nodes = NodeClass_from_NodeType<BlankNode> NodeType.Blank
let UriNodes_from_Nodes = NodeClass_from_NodeType<UriNode> NodeType.Uri
let LiteralNodes_from_Nodes = NodeClass_from_NodeType<LiteralNode> NodeType.Literal

let GraphLiteralNodes_from_Nodes =
    NodeClass_from_NodeType<GraphLiteralNode> NodeType.GraphLiteral

let VariableNodes_from_Nodes =
    NodeClass_from_NodeType<VariableNode> NodeType.Variable

let TripleNodes_from_Nodes = NodeClass_from_NodeType<TripleNode> NodeType.Triple









let BlankNodes = ontologyGraph.Nodes |> BlankNodes_from_Nodes
let UriNodes = ontologyGraph.Nodes |> UriNodes_from_Nodes
let LiteralNodes = ontologyGraph.Nodes |> LiteralNodes_from_Nodes

let GraphLiteralNodes =
    ontologyGraph.Nodes
    |> GraphLiteralNodes_from_Nodes

let VariableNodes = ontologyGraph.Nodes |> VariableNodes_from_Nodes
let TripleNodes = ontologyGraph.Nodes |> TripleNodes_from_Nodes


let OntologyProperties = ontologyGraph.AllProperties
let OntologyClasses = ontologyGraph.AllClasses





let randomUriINode = UriNodes |> Seq.randomChoice
let randomClass = OntologyClasses |> Seq.randomChoice
let randomProperty = OntologyProperties |> Seq.randomChoice


randomUriINode
randomClass
randomProperty



let vocabularyIriStrings =
    [|

       "http://www.w3.org/1999/02/22-rdf-syntax-ns#"
       "http://www.w3.org/2000/01/rdf-schema#"
       "http://www.w3.org/2002/07/owl#"
       "http://xmlns.com/foaf/0.1/"

       |]


let NamespaceIri_for_Iri (iri: Iri) = 

    vocabularyIriStrings
    |> Array.Parallel.tryPick (fun vocabularyIriString ->

        if iri.iriString.StartsWith vocabularyIriString then
            let vocabularyIri = Iri_from_uriString vocabularyIriString
            let namespaceIri = 
        else
            None

    )


let testUriString = "http://www.w3.org/1999/02/22-rdf-syntax-ns#type"

let testUri = new Uri(testUriString)
let testIri = Iri_from_uriString testUriString

testUri.Scheme
Scheme.Delimiter
testUri.Host





testIri.iriString
