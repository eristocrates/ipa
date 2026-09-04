#load @".paket/load/main.group.fsx"

open System
open VDS.RDF
open IriTools
open Dubzer.WhatwgUrl
open RDFSharp.Model

let wellKnownGenid = $"https://eristocrates.dev/.well-known/genid"

let greatGlobalGraph = new ThreadSafeGraph()
let ggg = greatGlobalGraph
let namespaceMapper = ggg.NamespaceMap :?> NamespaceMapper


type IGraph with
    member inline this.S<'Subject when 'Subject: (member asINode: INode)>(S: 'Subject) =
        this.GetTriplesWithSubject(S.asINode)
        |> Seq.toArray

    member inline this.SP<'Subject, 'Predicate when 'Subject: (member asINode: INode) and 'Predicate: (member asINode:
        INode)>
        (
            S: 'Subject,
            P: 'Predicate
        ) =
        this.GetTriplesWithSubjectPredicate(S.asINode, P.asINode)
        |> Seq.toArray

    member this.BlankNodes =
        this.AllNodes
        |> Seq.toArray
        |> Array.filter (fun node -> node.NodeType = NodeType.Blank)
        |> Array.map (fun node -> node :?> BlankNode)
        |> Array.sortBy (fun node -> node.InternalID)

    member this.UriNodes =
        this.AllNodes
        |> Seq.toArray
        |> Array.filter (fun node -> node.NodeType = NodeType.Uri)
        |> Array.map (fun node -> node :?> UriNode)
        |> Array.sortBy (fun node -> node.Uri.OriginalString)

    member this.LiteralNodes =
        this.AllNodes
        |> Seq.toArray
        |> Array.filter (fun node -> node.NodeType = NodeType.Literal)
        |> Array.map (fun node -> node :?> LiteralNode)
        |> Array.filter (fun node -> node.Language = String.Empty)
        |> Array.sortBy (fun node -> node.DataType.OriginalString, node.Value)

    member this.LanguageLiteralNodes =
        this.AllNodes
        |> Seq.toArray
        |> Array.filter (fun node -> node.NodeType = NodeType.Literal)
        |> Array.map (fun node -> node :?> LiteralNode)
        |> Array.filter (fun node -> node.Language <> String.Empty)
        |> Array.sortBy (fun node -> node.Language, node.Value)

    member this.GraphLiteralNodes =
        this.AllNodes
        |> Seq.toArray
        |> Array.filter (fun node -> node.NodeType = NodeType.GraphLiteral)
        |> Array.map (fun node -> node :?> GraphLiteralNode)

    member this.VariableNodes =
        this.AllNodes
        |> Seq.toArray
        |> Array.filter (fun node -> node.NodeType = NodeType.Variable)
        |> Array.map (fun node -> node :?> VariableNode)

    member this.TripleNodes =
        this.AllNodes
        |> Seq.toArray
        |> Array.filter (fun node -> node.NodeType = NodeType.Triple)
        |> Array.map (fun node -> node :?> TripleNode)
        |> Array.sortBy (fun node ->
            node.Triple.Subject.ToString(), node.Triple.Predicate.ToString(), node.Triple.Object.ToString())


type IriReference with
    static member fromUriNode(uriNode: UriNode) = IriReference uriNode.Uri
    member this.lexicalForm = this.uri.OriginalString
    member this.identity = this.lexicalForm

    member this.asUrl = DomUrl this.uri.OriginalString
    member this.asUri = this.uri
    member this.asUriNode = new UriNode(this.asUri)
    member this.asINode: INode = this.asUriNode
    member this.asRDFResource = new RDFResource(this.lexicalForm)

    member this.maybeCurie =
        match namespaceMapper.ReduceToQName this.lexicalForm with
        | true, qname -> Some qname
        | false, _ -> None

    member this.iriref = $"<{this.uri.OriginalString}>"
