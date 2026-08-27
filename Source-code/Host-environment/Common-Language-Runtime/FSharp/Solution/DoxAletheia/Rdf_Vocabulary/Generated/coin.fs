namespace http.purl.org.court.def._2009.coin.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module coin =
    let _namespace_iri = Namespace_Iri coin |> NamespaceIRI
    /// <summary>
    ///   <para>coin:slug</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/court/def/2009/coin#slug">http://purl.org/court/def/2009/coin#slug</seealso>
    let slug = Prefixed_Name(coin, "slug") |> PrefixedName
