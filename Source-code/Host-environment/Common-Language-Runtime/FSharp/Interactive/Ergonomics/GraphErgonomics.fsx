type Graph<'VertexType when 'VertexType: comparison> =
    {

      vertex_set: Set<Vertex<'VertexType>>
      edge_set: Set<Edge<'VertexType>>

     }

    member this.vertex_order = this.vertex_set.Count
    member this.edge_size = this.edge_set.Count
    member this.graph_quantity = this.vertex_order + this.edge_size
    member this.is_simple_graph = 
      match this.edge_set with 

and Vertex<'VertexType when 'VertexType: comparison> =
    {

      value: 'VertexType
      incident_edges: Set<Edge<'VertexType>>

     }
    member this.degree = this.incident_edges.Count
    member this.valency = this.degree
    member this.is_isolated = this.incident_edges.IsEmpty

and Edge<'VertexType when 'VertexType: comparison> =
    | FromDirectedEdge of Directed_Edge<'VertexType>
    | FromUndirectedEdge of Undirected_Edge<'VertexType>

and Directed_Edge<'VertexType when 'VertexType: comparison> =
    {

      from_vertex: Vertex<'VertexType>
      to_vertex: Vertex<'VertexType>

     }

and Arc<'VertexType when 'VertexType: comparison> = Directed_Edge<'VertexType>
and Arrow<'VertexType when 'VertexType: comparison> = Directed_Edge<'VertexType>


and Undirected_Edge<'VertexType when 'VertexType: comparison> =
    { endpoints: Vertex<'VertexType> * Vertex<'VertexType> }

and Line<'VertexType when 'VertexType: comparison> = Undirected_Edge<'VertexType>
and Link<'VertexType when 'VertexType: comparison> = Undirected_Edge<'VertexType>




type Directed_Graph<'VertexType when 'VertexType: comparison> =
    {

      vertex_set: Set<Vertex<'VertexType>>
      edge_set: Set<Directed_Edge<'VertexType>>

     }
