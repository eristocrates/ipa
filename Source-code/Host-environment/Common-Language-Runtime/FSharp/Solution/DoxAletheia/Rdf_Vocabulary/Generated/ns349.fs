namespace http.www.opengis.net.ont.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ns349 =
    let _namespace_iri = Namespace_Iri ns349 |> NamespaceIRI
    /// <summary>
    ///   <para>ns349:geosparql</para>
    /// </summary>
    /// <remarks>
    ///   <para>schemas:Person</para>
    ///   <para>owl:Ontology</para>
    ///   <para>schemas:Organization</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql">http://www.opengis.net/ont/geosparql</seealso>
    let geosparql = Prefixed_Name(ns349, "geosparql") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql/1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql/1.0">http://www.opengis.net/ont/geosparql/1.0</seealso>
    let ``geosparql/1.0`` = Prefixed_Name(ns349, "geosparql/1.0") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql/1.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql/1.1">http://www.opengis.net/ont/geosparql/1.1</seealso>
    let ``geosparql/1.1`` = Prefixed_Name(ns349, "geosparql/1.1") |> PrefixedName
    /// <summary>
    ///   <para>ns349:gml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/gml">http://www.opengis.net/ont/gml</seealso>
    let gml = Prefixed_Name(ns349, "gml") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/sf">http://www.opengis.net/ont/sf</seealso>
    let sf = Prefixed_Name(ns349, "sf") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf/1.1.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf/1.1.1">http://www.opengis.net/ont/sf/1.1.1</seealso>
    let ``sf/1.1.1`` = Prefixed_Name(ns349, "sf/1.1.1") |> PrefixedName
