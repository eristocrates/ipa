namespace http.www.w3.org._2000._10.swap.util.sniffSchema.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ss =
    let _namespace_iri = Namespace_Iri ss |> NamespaceIRI
    /// <summary>
    ///   <para>ss:domainIntersects</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/util/sniffSchema#domainIntersects">http://www.w3.org/2000/10/swap/util/sniffSchema#domainIntersects</seealso>
    let domainIntersects = Prefixed_Name(ss, "domainIntersects") |> PrefixedName
    /// <summary>
    ///   <para>ss:intersectsDomainOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/util/sniffSchema#intersectsDomainOf">http://www.w3.org/2000/10/swap/util/sniffSchema#intersectsDomainOf</seealso>
    let intersectsDomainOf = Prefixed_Name(ss, "intersectsDomainOf") |> PrefixedName
    /// <summary>
    ///   <para>ss:label</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/util/sniffSchema#label">http://www.w3.org/2000/10/swap/util/sniffSchema#label</seealso>
    let label = Prefixed_Name(ss, "label") |> PrefixedName
    /// <summary>
    ///   <para>ss:rangeIntersects</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/util/sniffSchema#rangeIntersects">http://www.w3.org/2000/10/swap/util/sniffSchema#rangeIntersects</seealso>
    let rangeIntersects = Prefixed_Name(ss, "rangeIntersects") |> PrefixedName
