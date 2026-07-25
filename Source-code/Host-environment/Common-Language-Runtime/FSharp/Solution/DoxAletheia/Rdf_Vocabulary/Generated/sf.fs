namespace http.www.opengis.net.ont.sf.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sf =
    let _namespace_iri = Namespace_Iri sf |> NamespaceIRI
    /// <summary>
    ///   <para>sf:GeometryCollection</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#GeometryCollection">http://www.opengis.net/ont/sf#GeometryCollection</seealso>
    let GeometryCollection = Prefixed_Name(sf, "GeometryCollection") |> PrefixedName
    /// <summary>
    ///   <para>sf:MultiPoint</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#MultiPoint">http://www.opengis.net/ont/sf#MultiPoint</seealso>
    let MultiPoint = Prefixed_Name(sf, "MultiPoint") |> PrefixedName
    /// <summary>
    ///   <para>sf:Point</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#Point">http://www.opengis.net/ont/sf#Point</seealso>
    let Point = Prefixed_Name(sf, "Point") |> PrefixedName
    /// <summary>
    ///   <para>sf:minimum</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#minimum">http://www.opengis.net/ont/sf#minimum</seealso>
    let minimum = Prefixed_Name(sf, "minimum") |> PrefixedName
    /// <summary>
    ///   <para>sf:PolyhedralSurface</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#PolyhedralSurface">http://www.opengis.net/ont/sf#PolyhedralSurface</seealso>
    let PolyhedralSurface = Prefixed_Name(sf, "PolyhedralSurface") |> PrefixedName
    /// <summary>
    ///   <para>sf:Triangle</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#Triangle">http://www.opengis.net/ont/sf#Triangle</seealso>
    let Triangle = Prefixed_Name(sf, "Triangle") |> PrefixedName
    /// <summary>
    ///   <para>sf:Envelope</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#Envelope">http://www.opengis.net/ont/sf#Envelope</seealso>
    let Envelope = Prefixed_Name(sf, "Envelope") |> PrefixedName
    /// <summary>
    ///   <para>sf:Line</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#Line">http://www.opengis.net/ont/sf#Line</seealso>
    let Line = Prefixed_Name(sf, "Line") |> PrefixedName
    /// <summary>
    ///   <para>sf:Geometry</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#Geometry">http://www.opengis.net/ont/sf#Geometry</seealso>
    let Geometry = Prefixed_Name(sf, "Geometry") |> PrefixedName
    /// <summary>
    ///   <para>sf:LinearRing</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#LinearRing">http://www.opengis.net/ont/sf#LinearRing</seealso>
    let LinearRing = Prefixed_Name(sf, "LinearRing") |> PrefixedName
    /// <summary>
    ///   <para>sf:MultiLineString</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#MultiLineString">http://www.opengis.net/ont/sf#MultiLineString</seealso>
    let MultiLineString = Prefixed_Name(sf, "MultiLineString") |> PrefixedName
    /// <summary>
    ///   <para>sf:MultiSurface</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#MultiSurface">http://www.opengis.net/ont/sf#MultiSurface</seealso>
    let MultiSurface = Prefixed_Name(sf, "MultiSurface") |> PrefixedName
    /// <summary>
    ///   <para>sf:Polygon</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#Polygon">http://www.opengis.net/ont/sf#Polygon</seealso>
    let Polygon = Prefixed_Name(sf, "Polygon") |> PrefixedName
    /// <summary>
    ///   <para>sf:maximum</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#maximum">http://www.opengis.net/ont/sf#maximum</seealso>
    let maximum = Prefixed_Name(sf, "maximum") |> PrefixedName
    /// <summary>
    ///   <para>sf:Curve</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#Curve">http://www.opengis.net/ont/sf#Curve</seealso>
    let Curve = Prefixed_Name(sf, "Curve") |> PrefixedName
    /// <summary>
    ///   <para>sf:LineString</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#LineString">http://www.opengis.net/ont/sf#LineString</seealso>
    let LineString = Prefixed_Name(sf, "LineString") |> PrefixedName
    /// <summary>
    ///   <para>sf:MultiCurve</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#MultiCurve">http://www.opengis.net/ont/sf#MultiCurve</seealso>
    let MultiCurve = Prefixed_Name(sf, "MultiCurve") |> PrefixedName
    /// <summary>
    ///   <para>sf:MultiPolygon</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#MultiPolygon">http://www.opengis.net/ont/sf#MultiPolygon</seealso>
    let MultiPolygon = Prefixed_Name(sf, "MultiPolygon") |> PrefixedName
    /// <summary>
    ///   <para>sf:Surface</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#Surface">http://www.opengis.net/ont/sf#Surface</seealso>
    let Surface = Prefixed_Name(sf, "Surface") |> PrefixedName
    /// <summary>
    ///   <para>sf:TIN</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#TIN">http://www.opengis.net/ont/sf#TIN</seealso>
    let TIN = Prefixed_Name(sf, "TIN") |> PrefixedName
