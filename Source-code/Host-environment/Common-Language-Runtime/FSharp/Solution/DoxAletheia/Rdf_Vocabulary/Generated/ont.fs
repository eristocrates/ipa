namespace http.purl.org.net.ns.ontology_annot.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ont =
    let _namespace_iri = Namespace_Iri ont |> NamespaceIRI
    /// <summary>
    ///   <para>ont:created</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"created"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/net/ns/ontology-annot#created">http://purl.org/net/ns/ontology-annot#created</seealso>
    let created = Prefixed_Name(ont, "created") |> PrefixedName
    /// <summary>
    ///   <para>ont:creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"creator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/net/ns/ontology-annot#creator">http://purl.org/net/ns/ontology-annot#creator</seealso>
    let creator = Prefixed_Name(ont, "creator") |> PrefixedName
    /// <summary>
    ///   <para>ont:deprecatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"deprecated by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/net/ns/ontology-annot#deprecatedBy">http://purl.org/net/ns/ontology-annot#deprecatedBy</seealso>
    let deprecatedBy = Prefixed_Name(ont, "deprecatedBy") |> PrefixedName
    /// <summary>
    ///   <para>ont:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/net/ns/ontology-annot#description">http://purl.org/net/ns/ontology-annot#description</seealso>
    let description = Prefixed_Name(ont, "description") |> PrefixedName
    /// <summary>
    ///   <para>ont:modified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"modified"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/net/ns/ontology-annot#modified">http://purl.org/net/ns/ontology-annot#modified</seealso>
    let modified = Prefixed_Name(ont, "modified") |> PrefixedName
    /// <summary>
    ///   <para>ont:relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"relation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/net/ns/ontology-annot#relation">http://purl.org/net/ns/ontology-annot#relation</seealso>
    let relation = Prefixed_Name(ont, "relation") |> PrefixedName
    /// <summary>
    ///   <para>ont:seeOther</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"see other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/net/ns/ontology-annot#seeOther">http://purl.org/net/ns/ontology-annot#seeOther</seealso>
    let seeOther = Prefixed_Name(ont, "seeOther") |> PrefixedName
    /// <summary>
    ///   <para>ont:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/net/ns/ontology-annot#title">http://purl.org/net/ns/ontology-annot#title</seealso>
    let title = Prefixed_Name(ont, "title") |> PrefixedName
