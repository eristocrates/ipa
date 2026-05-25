open System
open System.IO

#r "nuget: dotNetRdf"


open VDS.RDF
open VDS.RDF.Parsing
open VDS.RDF.Parsing.Tokens
open VDS.RDF.Ontology

#r "nuget: FSharp.Collections.ParallelSeq"
open FSharp.Collections.ParallelSeq



let graph = new ThreadSafeGraph()

let ontology_graph = new OntologyGraph()

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









let BlankNodes = graph.Nodes |> BlankNodes_from_Nodes
let UriNodes = graph.Nodes |> UriNodes_from_Nodes
let LiteralNodes = graph.Nodes |> LiteralNodes_from_Nodes

let GraphLiteralNodes = graph.Nodes |> GraphLiteralNodes_from_Nodes

let VariableNodes = graph.Nodes |> VariableNodes_from_Nodes
let TripleNodes = graph.Nodes |> TripleNodes_from_Nodes



let OntologyProperties = ontology_graph.AllProperties
let OntologyClasses = ontology_graph.AllClasses





let randomUriINode = UriNodes |> Seq.randomChoice
let randomClass = OntologyClasses |> Seq.randomChoice
let randomProperty = OntologyProperties |> Seq.randomChoice


randomUriINode
randomClass
randomProperty
