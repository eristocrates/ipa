namespace http.geovocab.org.geometry.hash

open DoxAletheia

module ngeo =
    let _namespace_name = "http://geovocab.org/geometry#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Represents a bounding box composed by four line segments.
    /// <see href="http://geovocab.org/geometry#BoundingBox"></see></summary>
    let BoundingBox = _prefix "BoundingBox"
    /// <summary>
    /// Super-class grouping all geometrical representations (also ones in non-RDF formats, such as KML, GML, WKT...).
    /// <see href="http://geovocab.org/geometry#Geometry"></see></summary>
    let Geometry = _prefix "Geometry"
    /// <summary>
    /// Super-class grouping all composite geometrical representations.
    /// <see href="http://geovocab.org/geometry#GeometryCollection"></see></summary>
    let GeometryCollection = _prefix "GeometryCollection"
    /// <summary>
    /// Represents a series of points connected by straight lines.
    /// <see href="http://geovocab.org/geometry#LineString"></see></summary>
    let LineString = _prefix "LineString"
    /// <summary>
    /// Represents a series of points connected by straight lines, which form a closed shape. Last point must be the same as the first point.
    /// <see href="http://geovocab.org/geometry#LinearRing"></see></summary>
    let LinearRing = _prefix "LinearRing"
    /// <summary>
    /// Describes a geometric shape composed of several LineString resources.
    /// <see href="http://geovocab.org/geometry#MultiLineString"></see></summary>
    let MultiLineString = _prefix "MultiLineString"
    /// <summary>
    /// Describes a collection of Point resources, which define a resource's geometric representation.
    /// <see href="http://geovocab.org/geometry#MultiPoint"></see></summary>
    let MultiPoint = _prefix "MultiPoint"
    /// <summary>
    /// Describes a geometric shape composed of several Polygon resources.
    /// <see href="http://geovocab.org/geometry#MultiPolygon"></see></summary>
    let MultiPolygon = _prefix "MultiPolygon"
    /// <summary>
    /// A closed area defined by an exterior boundary, and optionally one or more interior boundaries.
    /// <see href="http://geovocab.org/geometry#Polygon"></see></summary>
    let Polygon = _prefix "Polygon"
    /// <summary>
    /// Defines an polygon's boundary within its outer boundary, i.e. a polygon with 'holes' in it.
    /// <see href="http://geovocab.org/geometry#interior"></see></summary>
    let interior = _prefix "interior"
    /// <summary>
    /// Defines a polygon's outer boundary.
    /// <see href="http://geovocab.org/geometry#exterior"></see></summary>
    let exterior = _prefix "exterior"
    /// <summary>
    /// WKT serialization of the geometry.
    /// <see href="http://geovocab.org/geometry#asWKT"></see></summary>
    let asWKT = _prefix "asWKT"
    /// <summary>
    /// Relates a Geometry to its Bounding Box.
    /// <see href="http://geovocab.org/geometry#bbox"></see></summary>
    let bbox = _prefix "bbox"
    /// <summary>
    /// Super-property that groups all properties defining a polygon's boundaries.
    /// <see href="http://geovocab.org/geometry#boundary"></see></summary>
    let boundary = _prefix "boundary"
    /// <summary>
    /// Relates a resource to its geometric shape.
    /// <see href="http://geovocab.org/geometry#geometry"></see></summary>
    let geometry = _prefix "geometry"
    /// <summary>
    /// Links a LineString simple geometry to a MultiLineString composite geometry.
    /// <see href="http://geovocab.org/geometry#lineStringMember"></see></summary>
    let lineStringMember = _prefix "lineStringMember"
    /// <summary>
    /// Relates a point to a geometric shape's boundary.
    /// <see href="http://geovocab.org/geometry#partOf"></see></summary>
    let partOf = _prefix "partOf"
    /// <summary>
    /// Links a Point simple geometry to a MultiPoint composite Geometry.
    /// <see href="http://geovocab.org/geometry#pointMember"></see></summary>
    let pointMember = _prefix "pointMember"
    /// <summary>
    /// Links a Polygon simple geometry to a MultiPolygon composite geometry.
    /// <see href="http://geovocab.org/geometry#polygonMember"></see></summary>
    let polygonMember = _prefix "polygonMember"
    /// <summary>
    /// Relates a LineString or LinearRing to the points that define them.
    /// <see href="http://geovocab.org/geometry#posList"></see></summary>
    let posList = _prefix "posList"
