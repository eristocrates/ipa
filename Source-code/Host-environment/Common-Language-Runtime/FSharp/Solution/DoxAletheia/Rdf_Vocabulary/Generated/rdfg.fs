namespace http.www.w3.org._2004._03.trix.rdfg_1.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdfg =
    let _namespace_iri = Namespace_Iri rdfg |> NamespaceIRI
    /// <summary>
    ///   <para>rdfg:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2004/03/trix/rdfg-1/">http://www.w3.org/2004/03/trix/rdfg-1/</seealso>
    let _prefix_iri = Prefixed_Name(rdfg, "") |> PrefixedName
    /// <summary>
    ///   <para>rdfg:Graph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"
    /// An RDF graph (with intensional semantics).
    ///       "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/03/trix/rdfg-1/Graph">http://www.w3.org/2004/03/trix/rdfg-1/Graph</seealso>
    let Graph = Prefixed_Name(rdfg, "Graph") |> PrefixedName
    /// <summary>
    ///   <para>rdfg:equivalentGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"
    /// The graphs associated with the subject and object are equivalent.
    ///       "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"equivalent graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/03/trix/rdfg-1/equivalentGraph">http://www.w3.org/2004/03/trix/rdfg-1/equivalentGraph</seealso>
    let equivalentGraph = Prefixed_Name(rdfg, "equivalentGraph") |> PrefixedName
    /// <summary>
    ///   <para>rdfg:subGraphOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"
    /// The graph associated with the subject is a subgraph of a graph equivalent
    /// to that associated with the object.
    ///       "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subgraph of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2004/03/trix/rdfg-1/subGraphOf">http://www.w3.org/2004/03/trix/rdfg-1/subGraphOf</seealso>
    let subGraphOf = Prefixed_Name(rdfg, "subGraphOf") |> PrefixedName
