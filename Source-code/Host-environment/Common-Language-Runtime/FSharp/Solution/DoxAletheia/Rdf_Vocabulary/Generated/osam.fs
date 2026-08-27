namespace http.open_services.net.ns.am.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module osam =
    let _namespace_iri = Namespace_Iri osam |> NamespaceIRI
    /// <summary>
    ///   <para>osam:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"OSLC Architecture Management (AM) Vocabulary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/am#">http://open-services.net/ns/am#</seealso>
    let _prefix_iri = Prefixed_Name(osam, "") |> PrefixedName
    /// <summary>
    ///   <para>osam:LinkType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A locally managed resource that describes a link type predicate that might otherwise not be directly resolvable."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LinkType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/am#LinkType">http://open-services.net/ns/am#LinkType</seealso>
    let LinkType = Prefixed_Name(osam, "LinkType") |> PrefixedName
    /// <summary>
    ///   <para>osam:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A generic architecture resource.  A resource of this type is likely to be a model or design artifact."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ArchitectureResource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/am#Resource">http://open-services.net/ns/am#Resource</seealso>
    let Resource = Prefixed_Name(osam, "Resource") |> PrefixedName
