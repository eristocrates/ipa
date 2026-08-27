namespace http.rs.tdwg.org.dwc.terms.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dwc =
    let _namespace_iri = Namespace_Iri dwc |> NamespaceIRI
    /// <summary>
    ///   <para>dwc:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/dwc/terms/">http://rs.tdwg.org/dwc/terms/</seealso>
    let _prefix_iri = Prefixed_Name(dwc, "") |> PrefixedName
    /// <summary>
    ///   <para>dwc:Taxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rs.tdwg.org/dwc/terms/Taxon">http://rs.tdwg.org/dwc/terms/Taxon</seealso>
    let Taxon = Prefixed_Name(dwc, "Taxon") |> PrefixedName
    /// <summary>
    ///   <para>dwc:acceptedNameUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rs.tdwg.org/dwc/terms/acceptedNameUsage">http://rs.tdwg.org/dwc/terms/acceptedNameUsage</seealso>
    let acceptedNameUsage = Prefixed_Name(dwc, "acceptedNameUsage") |> PrefixedName

    /// <summary>
    ///   <para>dwc:attributes/TermList</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/dwc/terms/attributes/TermList">http://rs.tdwg.org/dwc/terms/attributes/TermList</seealso>
    let ``attributes/TermList`` =
        Prefixed_Name(dwc, "attributes/TermList") |> PrefixedName

    /// <summary>
    ///   <para>dwc:genus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rs.tdwg.org/dwc/terms/genus">http://rs.tdwg.org/dwc/terms/genus</seealso>
    let genus = Prefixed_Name(dwc, "genus") |> PrefixedName

    /// <summary>
    ///   <para>dwc:index.htm#acceptedNameUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rs.tdwg.org/dwc/terms/index.htm#acceptedNameUsage">http://rs.tdwg.org/dwc/terms/index.htm#acceptedNameUsage</seealso>
    let ``index.htm#acceptedNameUsage`` =
        Prefixed_Name(dwc, "index.htm#acceptedNameUsage") |> PrefixedName

    /// <summary>
    ///   <para>dwc:index.htm#acceptedNameUsageID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rs.tdwg.org/dwc/terms/index.htm#acceptedNameUsageID">http://rs.tdwg.org/dwc/terms/index.htm#acceptedNameUsageID</seealso>
    let ``index.htm#acceptedNameUsageID`` =
        Prefixed_Name(dwc, "index.htm#acceptedNameUsageID") |> PrefixedName

    /// <summary>
    ///   <para>dwc:index.htm#originalNameUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rs.tdwg.org/dwc/terms/index.htm#originalNameUsage">http://rs.tdwg.org/dwc/terms/index.htm#originalNameUsage</seealso>
    let ``index.htm#originalNameUsage`` =
        Prefixed_Name(dwc, "index.htm#originalNameUsage") |> PrefixedName

    /// <summary>
    ///   <para>dwc:index.htm#originalNameUsageID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rs.tdwg.org/dwc/terms/index.htm#originalNameUsageID">http://rs.tdwg.org/dwc/terms/index.htm#originalNameUsageID</seealso>
    let ``index.htm#originalNameUsageID`` =
        Prefixed_Name(dwc, "index.htm#originalNameUsageID") |> PrefixedName

    /// <summary>
    ///   <para>dwc:index.htm#vernacularName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rs.tdwg.org/dwc/terms/index.htm#vernacularName">http://rs.tdwg.org/dwc/terms/index.htm#vernacularName</seealso>
    let ``index.htm#vernacularName`` =
        Prefixed_Name(dwc, "index.htm#vernacularName") |> PrefixedName

    /// <summary>
    ///   <para>dwc:namePublishedInYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rs.tdwg.org/dwc/terms/namePublishedInYear">http://rs.tdwg.org/dwc/terms/namePublishedInYear</seealso>
    let namePublishedInYear = Prefixed_Name(dwc, "namePublishedInYear") |> PrefixedName
    /// <summary>
    ///   <para>dwc:scientificName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rs.tdwg.org/dwc/terms/scientificName">http://rs.tdwg.org/dwc/terms/scientificName</seealso>
    let scientificName = Prefixed_Name(dwc, "scientificName") |> PrefixedName

    /// <summary>
    ///   <para>dwc:scientificNameAuthorship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rs.tdwg.org/dwc/terms/scientificNameAuthorship">http://rs.tdwg.org/dwc/terms/scientificNameAuthorship</seealso>
    let scientificNameAuthorship =
        Prefixed_Name(dwc, "scientificNameAuthorship") |> PrefixedName

    /// <summary>
    ///   <para>dwc:specificEpithet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rs.tdwg.org/dwc/terms/specificEpithet">http://rs.tdwg.org/dwc/terms/specificEpithet</seealso>
    let specificEpithet = Prefixed_Name(dwc, "specificEpithet") |> PrefixedName
    /// <summary>
    ///   <para>dwc:taxonRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rs.tdwg.org/dwc/terms/taxonRank">http://rs.tdwg.org/dwc/terms/taxonRank</seealso>
    let taxonRank = Prefixed_Name(dwc, "taxonRank") |> PrefixedName
    /// <summary>
    ///   <para>dwc:vernacularName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/dwc/terms/vernacularName">http://rs.tdwg.org/dwc/terms/vernacularName</seealso>
    let vernacularName = Prefixed_Name(dwc, "vernacularName") |> PrefixedName
