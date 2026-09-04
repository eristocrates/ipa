#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ngeo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://geovocab.org/geometry#" "ngeo"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Bounding Box^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a bounding box composed by four line segments.^^xsd:string</para>
    ///   <a href="http://geovocab.org/geometry#BoundingBox">ngeo:BoundingBox</a>
    /// </summary>
    let BoundingBox = _prefixId.prefix "BoundingBox"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Geometry^^xsd:string</para>
    ///   <para>rdfs:comment : Super-class grouping all geometrical representations (also ones in non-RDF formats, such as KML, GML, WKT...).^^xsd:string</para>
    ///   <a href="http://geovocab.org/geometry#Geometry">ngeo:Geometry</a>
    /// </summary>
    let Geometry = _prefixId.prefix "Geometry"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Geometry Collection^^xsd:string</para>
    ///   <para>rdfs:comment : Super-class grouping all composite geometrical representations.^^xsd:string</para>
    ///   <a href="http://geovocab.org/geometry#GeometryCollection">ngeo:GeometryCollection</a>
    /// </summary>
    let GeometryCollection = _prefixId.prefix "GeometryCollection"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : LineString^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a series of points connected by straight lines.^^xsd:string</para>
    ///   <a href="http://geovocab.org/geometry#LineString">ngeo:LineString</a>
    /// </summary>
    let LineString = _prefixId.prefix "LineString"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : LinearRing^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a series of points connected by straight lines, which form a closed shape. Last point must be the same as the first point.^^xsd:string</para>
    ///   <a href="http://geovocab.org/geometry#LinearRing">ngeo:LinearRing</a>
    /// </summary>
    let LinearRing = _prefixId.prefix "LinearRing"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : MultiLineString^^xsd:string</para>
    ///   <para>rdfs:comment : Describes a geometric shape composed of several LineString resources.^^xsd:string</para>
    ///   <a href="http://geovocab.org/geometry#MultiLineString">ngeo:MultiLineString</a>
    /// </summary>
    let MultiLineString = _prefixId.prefix "MultiLineString"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : MultiPoint^^xsd:string</para>
    ///   <para>rdfs:comment : Describes a collection of Point resources, which define a resource's geometric representation.^^xsd:string</para>
    ///   <a href="http://geovocab.org/geometry#MultiPoint">ngeo:MultiPoint</a>
    /// </summary>
    let MultiPoint = _prefixId.prefix "MultiPoint"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : MultiPolygon^^xsd:string</para>
    ///   <para>rdfs:comment : Describes a geometric shape composed of several Polygon resources.^^xsd:string</para>
    ///   <a href="http://geovocab.org/geometry#MultiPolygon">ngeo:MultiPolygon</a>
    /// </summary>
    let MultiPolygon = _prefixId.prefix "MultiPolygon"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Polygon^^xsd:string</para>
    ///   <para>rdfs:comment : A closed area defined by an exterior boundary, and optionally one or more interior boundaries.^^xsd:string</para>
    ///   <a href="http://geovocab.org/geometry#Polygon">ngeo:Polygon</a>
    /// </summary>
    let Polygon = _prefixId.prefix "Polygon"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <para>rdfs:label : As WKT^^xsd:string</para>
    ///   <para>rdfs:comment : WKT serialization of the geometry.^^xsd:string</para>
    ///   <a href="http://geovocab.org/geometry#asWKT">ngeo:asWKT</a>
    /// </summary>
    let asWKT = _prefixId.prefix "asWKT"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : bounding box^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a Geometry to its Bounding Box.^^xsd:string</para>
    ///   <a href="http://geovocab.org/geometry#bbox">ngeo:bbox</a>
    /// </summary>
    let bbox = _prefixId.prefix "bbox"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : boundary^^xsd:string</para>
    ///   <para>rdfs:comment : Super-property that groups all properties defining a polygon's boundaries.^^xsd:string</para>
    ///   <a href="http://geovocab.org/geometry#boundary">ngeo:boundary</a>
    /// </summary>
    let boundary = _prefixId.prefix "boundary"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : exterior^^xsd:string</para>
    ///   <para>rdfs:comment : Defines a polygon's outer boundary.^^xsd:string</para>
    ///   <a href="http://geovocab.org/geometry#exterior">ngeo:exterior</a>
    /// </summary>
    let exterior = _prefixId.prefix "exterior"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : geometry^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a resource to its geometric shape.^^xsd:string</para>
    ///   <a href="http://geovocab.org/geometry#geometry">ngeo:geometry</a>
    /// </summary>
    let geometry = _prefixId.prefix "geometry"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : interior^^xsd:string</para>
    ///   <para>rdfs:comment : Defines an polygon's boundary within its outer boundary, i.e. a polygon with 'holes' in it.^^xsd:string</para>
    ///   <a href="http://geovocab.org/geometry#interior">ngeo:interior</a>
    /// </summary>
    let interior = _prefixId.prefix "interior"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : LineString member^^xsd:string</para>
    ///   <para>rdfs:comment : Links a LineString simple geometry to a MultiLineString composite geometry.^^xsd:string</para>
    ///   <a href="http://geovocab.org/geometry#lineStringMember">ngeo:lineStringMember</a>
    /// </summary>
    let lineStringMember = _prefixId.prefix "lineStringMember"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : part of^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a point to a geometric shape's boundary.^^xsd:string</para>
    ///   <a href="http://geovocab.org/geometry#partOf">ngeo:partOf</a>
    /// </summary>
    let partOf = _prefixId.prefix "partOf"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Point member^^xsd:string</para>
    ///   <para>rdfs:comment : Links a Point simple geometry to a MultiPoint composite Geometry.^^xsd:string</para>
    ///   <a href="http://geovocab.org/geometry#pointMember">ngeo:pointMember</a>
    /// </summary>
    let pointMember = _prefixId.prefix "pointMember"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Polygon member^^xsd:string</para>
    ///   <para>rdfs:comment : Links a Polygon simple geometry to a MultiPolygon composite geometry.^^xsd:string</para>
    ///   <a href="http://geovocab.org/geometry#polygonMember">ngeo:polygonMember</a>
    /// </summary>
    let polygonMember = _prefixId.prefix "polygonMember"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : position list^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a LineString or LinearRing to the points that define them.^^xsd:string</para>
    ///   <a href="http://geovocab.org/geometry#posList">ngeo:posList</a>
    /// </summary>
    let posList = _prefixId.prefix "posList"
