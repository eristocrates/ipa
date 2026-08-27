namespace http.geovocab.org.geometry.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ngeo =
    let _namespace_iri = Namespace_Iri ngeo |> NamespaceIRI
    /// <summary>
    ///   <para>geovocab:geometry#BoundingBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a bounding box composed by four line segments."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bounding Box"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry#BoundingBox">http://geovocab.org/geometry#BoundingBox</seealso>
    let BoundingBox = Prefixed_Name(ngeo, "BoundingBox") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:geometry#Geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Super-class grouping all geometrical representations (also ones in non-RDF formats, such as KML, GML, WKT...)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Geometry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry#Geometry">http://geovocab.org/geometry#Geometry</seealso>
    let Geometry = Prefixed_Name(ngeo, "Geometry") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:geometry#GeometryCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Super-class grouping all composite geometrical representations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Geometry Collection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry#GeometryCollection">http://geovocab.org/geometry#GeometryCollection</seealso>
    let GeometryCollection = Prefixed_Name(ngeo, "GeometryCollection") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:geometry#LineString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a series of points connected by straight lines."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LineString"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry#LineString">http://geovocab.org/geometry#LineString</seealso>
    let LineString = Prefixed_Name(ngeo, "LineString") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:geometry#LinearRing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a series of points connected by straight lines, which form a closed shape. Last point must be the same as the first point."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LinearRing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry#LinearRing">http://geovocab.org/geometry#LinearRing</seealso>
    let LinearRing = Prefixed_Name(ngeo, "LinearRing") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:geometry#MultiLineString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a geometric shape composed of several LineString resources."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MultiLineString"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry#MultiLineString">http://geovocab.org/geometry#MultiLineString</seealso>
    let MultiLineString = Prefixed_Name(ngeo, "MultiLineString") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:geometry#MultiPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a collection of Point resources, which define a resource's geometric representation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MultiPoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry#MultiPoint">http://geovocab.org/geometry#MultiPoint</seealso>
    let MultiPoint = Prefixed_Name(ngeo, "MultiPoint") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:geometry#MultiPolygon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a geometric shape composed of several Polygon resources."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MultiPolygon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry#MultiPolygon">http://geovocab.org/geometry#MultiPolygon</seealso>
    let MultiPolygon = Prefixed_Name(ngeo, "MultiPolygon") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:geometry#Polygon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A closed area defined by an exterior boundary, and optionally one or more interior boundaries."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Polygon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry#Polygon">http://geovocab.org/geometry#Polygon</seealso>
    let Polygon = Prefixed_Name(ngeo, "Polygon") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:geometry#asWKT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"WKT serialization of the geometry."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"As WKT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry#asWKT">http://geovocab.org/geometry#asWKT</seealso>
    let asWKT = Prefixed_Name(ngeo, "asWKT") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:geometry#bbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a Geometry to its Bounding Box."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"bounding box"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry#bbox">http://geovocab.org/geometry#bbox</seealso>
    let bbox = Prefixed_Name(ngeo, "bbox") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:geometry#boundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Super-property that groups all properties defining a polygon's boundaries."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"boundary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry#boundary">http://geovocab.org/geometry#boundary</seealso>
    let boundary = Prefixed_Name(ngeo, "boundary") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:geometry#exterior</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines a polygon's outer boundary."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"exterior"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry#exterior">http://geovocab.org/geometry#exterior</seealso>
    let exterior = Prefixed_Name(ngeo, "exterior") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:geometry#geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a resource to its geometric shape."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"geometry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry#geometry">http://geovocab.org/geometry#geometry</seealso>
    let geometry = Prefixed_Name(ngeo, "geometry") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:geometry#interior</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines an polygon's boundary within its outer boundary, i.e. a polygon with 'holes' in it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"interior"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry#interior">http://geovocab.org/geometry#interior</seealso>
    let interior = Prefixed_Name(ngeo, "interior") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:geometry#lineStringMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a LineString simple geometry to a MultiLineString composite geometry."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LineString member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry#lineStringMember">http://geovocab.org/geometry#lineStringMember</seealso>
    let lineStringMember = Prefixed_Name(ngeo, "lineStringMember") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:geometry#partOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a point to a geometric shape's boundary."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"part of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry#partOf">http://geovocab.org/geometry#partOf</seealso>
    let partOf = Prefixed_Name(ngeo, "partOf") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:geometry#pointMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a Point simple geometry to a MultiPoint composite Geometry."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Point member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry#pointMember">http://geovocab.org/geometry#pointMember</seealso>
    let pointMember = Prefixed_Name(ngeo, "pointMember") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:geometry#polygonMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a Polygon simple geometry to a MultiPolygon composite geometry."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Polygon member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry#polygonMember">http://geovocab.org/geometry#polygonMember</seealso>
    let polygonMember = Prefixed_Name(ngeo, "polygonMember") |> PrefixedName
    /// <summary>
    ///   <para>geovocab:geometry#posList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a LineString or LinearRing to the points that define them."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"position list"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://geovocab.org/geometry#posList">http://geovocab.org/geometry#posList</seealso>
    let posList = Prefixed_Name(ngeo, "posList") |> PrefixedName
