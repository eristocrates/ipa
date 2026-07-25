namespace http.eulersharp.sourceforge.net._2003._03swap.coding.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swapcoding =
    let _namespace_iri = Namespace_Iri swapcoding |> NamespaceIRI
    /// <summary>
    ///   <para>swapcoding:Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A code system is declared using &lt;http://www.w3.org/2004/02/skos/core#inScheme&gt;. A system version is declared using &lt;http://purl.org/dc/terms/hasVersion&gt;.</para>
    /// labels<para>code</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/coding#Code">http://eulersharp.sourceforge.net/2003/03swap/coding#Code</seealso>
    let Code = Prefixed_Name(swapcoding, "Code") |> PrefixedName
    /// <summary>
    ///   <para>swapcoding:codes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/coding#codes">http://eulersharp.sourceforge.net/2003/03swap/coding#codes</seealso>
    let codes = Prefixed_Name(swapcoding, "codes") |> PrefixedName
    /// <summary>
    ///   <para>swapcoding:hasCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasCode">http://eulersharp.sourceforge.net/2003/03swap/coding#hasCode</seealso>
    let hasCode = Prefixed_Name(swapcoding, "hasCode") |> PrefixedName
    /// <summary>
    ///   <para>swapcoding:hasMappingCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasMappingCode">http://eulersharp.sourceforge.net/2003/03swap/coding#hasMappingCode</seealso>
    let hasMappingCode = Prefixed_Name(swapcoding, "hasMappingCode") |> PrefixedName
    /// <summary>
    ///   <para>swapcoding:hasBroadCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasBroadCode">http://eulersharp.sourceforge.net/2003/03swap/coding#hasBroadCode</seealso>
    let hasBroadCode = Prefixed_Name(swapcoding, "hasBroadCode") |> PrefixedName
    /// <summary>
    ///   <para>swapcoding:hasExactCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasExactCode">http://eulersharp.sourceforge.net/2003/03swap/coding#hasExactCode</seealso>
    let hasExactCode = Prefixed_Name(swapcoding, "hasExactCode") |> PrefixedName
    /// <summary>
    ///   <para>swapcoding:hasCodeAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasCodeAuthority">http://eulersharp.sourceforge.net/2003/03swap/coding#hasCodeAuthority</seealso>
    let hasCodeAuthority = Prefixed_Name(swapcoding, "hasCodeAuthority") |> PrefixedName
    /// <summary>
    ///   <para>swapcoding:hasCodeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasCodeValue">http://eulersharp.sourceforge.net/2003/03swap/coding#hasCodeValue</seealso>
    let hasCodeValue = Prefixed_Name(swapcoding, "hasCodeValue") |> PrefixedName

    /// <summary>
    ///   <para>swapcoding:hasCodeExpirationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasCodeExpirationDate">http://eulersharp.sourceforge.net/2003/03swap/coding#hasCodeExpirationDate</seealso>
    let hasCodeExpirationDate =
        Prefixed_Name(swapcoding, "hasCodeExpirationDate") |> PrefixedName

    /// <summary>
    ///   <para>swapcoding:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/coding#">http://eulersharp.sourceforge.net/2003/03swap/coding#</seealso>
    let _prefix_iri = Prefixed_Name(swapcoding, "") |> PrefixedName
    /// <summary>
    ///   <para>swapcoding:hasNarrowCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasNarrowCode">http://eulersharp.sourceforge.net/2003/03swap/coding#hasNarrowCode</seealso>
    let hasNarrowCode = Prefixed_Name(swapcoding, "hasNarrowCode") |> PrefixedName
