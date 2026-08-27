namespace http.rdfdata.eionet.europa.eu.ramon.ontology.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ramon =
    let _namespace_iri = Namespace_Iri ramon |> NamespaceIRI
    /// <summary>
    ///   <para>ramon:NUTSRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"NUTS Region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdfdata.eionet.europa.eu/ramon/ontology/NUTSRegion">http://rdfdata.eionet.europa.eu/ramon/ontology/NUTSRegion</seealso>
    let NUTSRegion = Prefixed_Name(ramon, "NUTSRegion") |> PrefixedName
    /// <summary>
    ///   <para>ramon:code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"NUTS/LAU Code of an administrative region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdfdata.eionet.europa.eu/ramon/ontology/code">http://rdfdata.eionet.europa.eu/ramon/ontology/code</seealso>
    let code = Prefixed_Name(ramon, "code") |> PrefixedName
    /// <summary>
    ///   <para>ramon:level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Level of an administrative region: NUTS1..3=1..3, LAU1..2=4..5"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"admin region level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdfdata.eionet.europa.eu/ramon/ontology/level">http://rdfdata.eionet.europa.eu/ramon/ontology/level</seealso>
    let level = Prefixed_Name(ramon, "level") |> PrefixedName
    /// <summary>
    ///   <para>ramon:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Name of an administrative region or settlement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"admin region name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdfdata.eionet.europa.eu/ramon/ontology/name">http://rdfdata.eionet.europa.eu/ramon/ontology/name</seealso>
    let name = Prefixed_Name(ramon, "name") |> PrefixedName
