namespace http.www.w3.org._2004._03.trix.rdfg_1.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdfg =
    let _namespace_iri = Namespace_Iri rdfg |> NamespaceIRI
    /// <summary>
    ///   <para>rdfg:equivalentGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>
    /// The graphs associated with the subject and object are equivalent.
    ///       </para>
    /// labels<para>equivalent graph</para></remarks>
    /// <seealso href="http://www.w3.org/2004/03/trix/rdfg-1/equivalentGraph">http://www.w3.org/2004/03/trix/rdfg-1/equivalentGraph</seealso>
    let equivalentGraph = Prefixed_Name(rdfg, "equivalentGraph") |> PrefixedName
    /// <summary>
    ///   <para>rdfg:Graph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>
    /// An RDF graph (with intensional semantics).
    ///       </para>
    /// labels<para>Graph</para></remarks>
    /// <seealso href="http://www.w3.org/2004/03/trix/rdfg-1/Graph">http://www.w3.org/2004/03/trix/rdfg-1/Graph</seealso>
    let Graph = Prefixed_Name(rdfg, "Graph") |> PrefixedName
    /// <summary>
    ///   <para>rdfg:subGraphOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>
    /// The graph associated with the subject is a subgraph of a graph equivalent
    /// to that associated with the object.
    ///       </para>
    /// labels<para>subgraph of</para></remarks>
    /// <seealso href="http://www.w3.org/2004/03/trix/rdfg-1/subGraphOf">http://www.w3.org/2004/03/trix/rdfg-1/subGraphOf</seealso>
    let subGraphOf = Prefixed_Name(rdfg, "subGraphOf") |> PrefixedName
