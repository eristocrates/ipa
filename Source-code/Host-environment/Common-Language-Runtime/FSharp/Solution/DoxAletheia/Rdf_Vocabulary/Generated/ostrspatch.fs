namespace http.open_services.net.ns.core.trspatch.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ostrspatch =
    let _namespace_iri = Namespace_Iri ostrspatch |> NamespaceIRI
    /// <summary>
    ///   <para>ostrspatch:afterETag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"HTTP entity tag of resource immediately after this change."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"afterETag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core/trspatch#afterETag">http://open-services.net/ns/core/trspatch#afterETag</seealso>
    let afterETag = Prefixed_Name(ostrspatch, "afterETag") |> PrefixedName
    /// <summary>
    ///   <para>ostrspatch:beforeETag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"HTTP entity tag of resource immediately before this change."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"beforeETag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core/trspatch#beforeETag">http://open-services.net/ns/core/trspatch#beforeETag</seealso>
    let beforeETag = Prefixed_Name(ostrspatch, "beforeETag") |> PrefixedName
    /// <summary>
    ///   <para>ostrspatch:createdFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"URI of antecedent resource for trs:Creation Change Events."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"createdFrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core/trspatch#createdFrom">http://open-services.net/ns/core/trspatch#createdFrom</seealso>
    let createdFrom = Prefixed_Name(ostrspatch, "createdFrom") |> PrefixedName
    /// <summary>
    ///   <para>ostrspatch:rdfPatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Patch directives describing a modification to the resource's RDF representation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rdfPatch"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core/trspatch#rdfPatch">http://open-services.net/ns/core/trspatch#rdfPatch</seealso>
    let rdfPatch = Prefixed_Name(ostrspatch, "rdfPatch") |> PrefixedName
