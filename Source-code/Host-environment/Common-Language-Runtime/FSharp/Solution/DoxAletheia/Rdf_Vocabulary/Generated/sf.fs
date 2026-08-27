namespace http.www.opengis.net.ont.sf.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sf =
    let _namespace_iri = Namespace_Iri sf |> NamespaceIRI
    /// <summary>
    ///   <para>ns349:sf#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#">http://www.opengis.net/ont/sf#</seealso>
    let _prefix_iri = Prefixed_Name(sf, "") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#Curve</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#Curve">http://www.opengis.net/ont/sf#Curve</seealso>
    let Curve = Prefixed_Name(sf, "Curve") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#Envelope</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#Envelope">http://www.opengis.net/ont/sf#Envelope</seealso>
    let Envelope = Prefixed_Name(sf, "Envelope") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#Geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Geometry is the root class of the hierarchy. The instantiable subclasses of Geometry are restricted to 0, 1 and 2-dimensional geometric objects that exist in 2, 3 or 4-dimensional coordinate space (R2, R3 or R4). Geometry values in R2 have points with coordinate values for x and y. Geometry values in R3 have points with coordinate values for x, y and z or for x, y and m. Geometry values in R4 have points with coordinate values for x, y, z and m. The interpretation of the coordinates is subject to the coordinate reference systems associated to the point. All coordinates within a geometry object should be in the same coordinate reference systems. Each coordinate shall be unambiguously associated to a coordinate reference system either directly or through its containing geometry. The z coordinate of a point is typically, but not necessarily, represents altitude or elevation. The m coordinate represents a measurement. All Geometry classes described in this specification are defined so that instances of Geometry are topologically closed, i.e. all represented geometries include their boundary as point sets. This does not affect their representation, and open version of the same classes may be used in other circumstances, such as topological representations."</para>
    /// labels<para>"Geometry"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#Geometry">http://www.opengis.net/ont/sf#Geometry</seealso>
    let Geometry = Prefixed_Name(sf, "Geometry") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#GeometryCollection</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#GeometryCollection">http://www.opengis.net/ont/sf#GeometryCollection</seealso>
    let GeometryCollection = Prefixed_Name(sf, "GeometryCollection") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#Line</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#Line">http://www.opengis.net/ont/sf#Line</seealso>
    let Line = Prefixed_Name(sf, "Line") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#LineString</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#LineString">http://www.opengis.net/ont/sf#LineString</seealso>
    let LineString = Prefixed_Name(sf, "LineString") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#LinearRing</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#LinearRing">http://www.opengis.net/ont/sf#LinearRing</seealso>
    let LinearRing = Prefixed_Name(sf, "LinearRing") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#MultiCurve</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#MultiCurve">http://www.opengis.net/ont/sf#MultiCurve</seealso>
    let MultiCurve = Prefixed_Name(sf, "MultiCurve") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#MultiLineString</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#MultiLineString">http://www.opengis.net/ont/sf#MultiLineString</seealso>
    let MultiLineString = Prefixed_Name(sf, "MultiLineString") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#MultiPoint</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#MultiPoint">http://www.opengis.net/ont/sf#MultiPoint</seealso>
    let MultiPoint = Prefixed_Name(sf, "MultiPoint") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#MultiPolygon</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#MultiPolygon">http://www.opengis.net/ont/sf#MultiPolygon</seealso>
    let MultiPolygon = Prefixed_Name(sf, "MultiPolygon") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#MultiSurface</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#MultiSurface">http://www.opengis.net/ont/sf#MultiSurface</seealso>
    let MultiSurface = Prefixed_Name(sf, "MultiSurface") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Point is a 0-dimensional geometric object and represents a single location in coordinate space. A Point has an x-coordinate value, a y-coordinate value. If called for by the associated Spatial Reference System, it may also have coordinate values for z and m. The boundary of a Point is the empty set."</para>
    /// labels<para>"Point"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#Point">http://www.opengis.net/ont/sf#Point</seealso>
    let Point = Prefixed_Name(sf, "Point") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#Polygon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Polygon"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#Polygon">http://www.opengis.net/ont/sf#Polygon</seealso>
    let Polygon = Prefixed_Name(sf, "Polygon") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#PolyhedralSurface</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#PolyhedralSurface">http://www.opengis.net/ont/sf#PolyhedralSurface</seealso>
    let PolyhedralSurface = Prefixed_Name(sf, "PolyhedralSurface") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#Surface</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#Surface">http://www.opengis.net/ont/sf#Surface</seealso>
    let Surface = Prefixed_Name(sf, "Surface") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#TIN</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#TIN">http://www.opengis.net/ont/sf#TIN</seealso>
    let TIN = Prefixed_Name(sf, "TIN") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#Triangle</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#Triangle">http://www.opengis.net/ont/sf#Triangle</seealso>
    let Triangle = Prefixed_Name(sf, "Triangle") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#WktLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#WktLiteral">http://www.opengis.net/ont/sf#WktLiteral</seealso>
    let WktLiteral = Prefixed_Name(sf, "WktLiteral") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#maximum</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#maximum">http://www.opengis.net/ont/sf#maximum</seealso>
    let maximum = Prefixed_Name(sf, "maximum") |> PrefixedName
    /// <summary>
    ///   <para>ns349:sf#minimum</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/sf#minimum">http://www.opengis.net/ont/sf#minimum</seealso>
    let minimum = Prefixed_Name(sf, "minimum") |> PrefixedName
