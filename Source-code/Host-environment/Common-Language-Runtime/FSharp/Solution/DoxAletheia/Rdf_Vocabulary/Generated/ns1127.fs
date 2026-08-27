namespace https.defs.opengis.net.org.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ns1127 =
    let _namespace_iri = Namespace_Iri ns1127 |> NamespaceIRI
    /// <summary>
    ///   <para>ns1127:geosparql-swg</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://defs.opengis.net/org/geosparql-swg">https://defs.opengis.net/org/geosparql-swg</seealso>
    let geosparql_swg = Prefixed_Name(ns1127, "geosparql-swg") |> PrefixedName
    /// <summary>
    ///   <para>ns1127:ogc</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://defs.opengis.net/org/ogc">https://defs.opengis.net/org/ogc</seealso>
    let ogc = Prefixed_Name(ns1127, "ogc") |> PrefixedName
