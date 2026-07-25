namespace http.purl.org.cld.cdtype.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cdtype =
    let _namespace_iri = Namespace_Iri cdtype |> NamespaceIRI
    /// <summary>
    ///   <para>cdtype:IndexingFindingAid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A collection of records consisting of information derived from items in a second collection, regardless of the content of those items.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/cdtype/IndexingFindingAid">http://purl.org/cld/cdtype/IndexingFindingAid</seealso>
    let IndexingFindingAid = Prefixed_Name(cdtype, "IndexingFindingAid") |> PrefixedName
    /// <summary>
    ///   <para>cdtype:AnalyticFindingAid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A collection of individual records describing the items, and the intellectual content of those items, of a second collection. The records provide information about individual items. There are no intrinsic relationships between the records, and each record is essentially self-contained.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/cdtype/AnalyticFindingAid">http://purl.org/cld/cdtype/AnalyticFindingAid</seealso>
    let AnalyticFindingAid = Prefixed_Name(cdtype, "AnalyticFindingAid") |> PrefixedName
    /// <summary>
    ///   <para>cdtype:CatalogueOrIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A catalogue for, or index of, a collection.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/cdtype/CatalogueOrIndex">http://purl.org/cld/cdtype/CatalogueOrIndex</seealso>
    let CatalogueOrIndex = Prefixed_Name(cdtype, "CatalogueOrIndex") |> PrefixedName

    /// <summary>
    ///   <para>cdtype:HierarchicFindingAid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A collection of records describing the individual items, and the intellectual content of those items, of a second collection. The records provide information about the collection and/or about the individual items, including contextual information about the relations between items and the collection. Relationships exist between records, and records are interpreted in the context of those relationships.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/cdtype/HierarchicFindingAid">http://purl.org/cld/cdtype/HierarchicFindingAid</seealso>
    let HierarchicFindingAid =
        Prefixed_Name(cdtype, "HierarchicFindingAid") |> PrefixedName

    /// <summary>
    ///   <para>cdtype:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cld/cdtype/">http://purl.org/cld/cdtype/</seealso>
    let _prefix_iri = Prefixed_Name(cdtype, "") |> PrefixedName
