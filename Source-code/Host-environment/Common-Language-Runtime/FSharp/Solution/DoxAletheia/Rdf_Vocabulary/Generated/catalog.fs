namespace https.www.opengis.net.def.catalog.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module catalog =
    let _namespace_iri = Namespace_Iri catalog |> NamespaceIRI
    /// <summary>
    ///   <para>catalog:geosparql</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.opengis.net/def/catalog/geosparql">https://www.opengis.net/def/catalog/geosparql</seealso>
    let geosparql = Prefixed_Name(catalog, "geosparql") |> PrefixedName
