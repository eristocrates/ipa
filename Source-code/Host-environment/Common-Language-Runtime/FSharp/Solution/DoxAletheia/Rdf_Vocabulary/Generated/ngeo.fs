namespace http.geovocab.org.geometry.hash

open DoxAletheia.Rdf_Vocabulary

module ngeo =
    let _namespace_name = "http://geovocab.org/geometry#"

    /// <summary>
    /// Represents a bounding box composed by four line segments.
    /// <see href="http://geovocab.org/geometry#BoundingBox"></see></summary>
    let BoundingBox =
        Namespaced_IRI.parse _namespace_name "BoundingBox" |> NamespacedName

    /// <summary>
    /// Super-class grouping all geometrical representations (also ones in non-RDF formats, such as KML, GML, WKT...).
    /// <see href="http://geovocab.org/geometry#Geometry"></see></summary>
    let Geometry = Namespaced_IRI.parse _namespace_name "Geometry" |> NamespacedName

    /// <summary>
    /// Super-class grouping all composite geometrical representations.
    /// <see href="http://geovocab.org/geometry#GeometryCollection"></see></summary>
    let GeometryCollection =
        Namespaced_IRI.parse _namespace_name "GeometryCollection" |> NamespacedName

    /// <summary>
    /// Represents a series of points connected by straight lines.
    /// <see href="http://geovocab.org/geometry#LineString"></see></summary>
    let LineString = Namespaced_IRI.parse _namespace_name "LineString" |> NamespacedName
    /// <summary>
    /// Represents a series of points connected by straight lines, which form a closed shape. Last point must be the same as the first point.
    /// <see href="http://geovocab.org/geometry#LinearRing"></see></summary>
    let LinearRing = Namespaced_IRI.parse _namespace_name "LinearRing" |> NamespacedName

    /// <summary>
    /// Describes a geometric shape composed of several LineString resources.
    /// <see href="http://geovocab.org/geometry#MultiLineString"></see></summary>
    let MultiLineString =
        Namespaced_IRI.parse _namespace_name "MultiLineString" |> NamespacedName

    /// <summary>
    /// Describes a collection of Point resources, which define a resource's geometric representation.
    /// <see href="http://geovocab.org/geometry#MultiPoint"></see></summary>
    let MultiPoint = Namespaced_IRI.parse _namespace_name "MultiPoint" |> NamespacedName

    /// <summary>
    /// Describes a geometric shape composed of several Polygon resources.
    /// <see href="http://geovocab.org/geometry#MultiPolygon"></see></summary>
    let MultiPolygon =
        Namespaced_IRI.parse _namespace_name "MultiPolygon" |> NamespacedName

    /// <summary>
    /// A closed area defined by an exterior boundary, and optionally one or more interior boundaries.
    /// <see href="http://geovocab.org/geometry#Polygon"></see></summary>
    let Polygon = Namespaced_IRI.parse _namespace_name "Polygon" |> NamespacedName
    /// <summary>
    /// Defines an polygon's boundary within its outer boundary, i.e. a polygon with 'holes' in it.
    /// <see href="http://geovocab.org/geometry#interior"></see></summary>
    let interior = Namespaced_IRI.parse _namespace_name "interior" |> NamespacedName
    /// <summary>
    /// Defines a polygon's outer boundary.
    /// <see href="http://geovocab.org/geometry#exterior"></see></summary>
    let exterior = Namespaced_IRI.parse _namespace_name "exterior" |> NamespacedName
    /// <summary>
    /// WKT serialization of the geometry.
    /// <see href="http://geovocab.org/geometry#asWKT"></see></summary>
    let asWKT = Namespaced_IRI.parse _namespace_name "asWKT" |> NamespacedName
    /// <summary>
    /// Relates a Geometry to its Bounding Box.
    /// <see href="http://geovocab.org/geometry#bbox"></see></summary>
    let bbox = Namespaced_IRI.parse _namespace_name "bbox" |> NamespacedName
    /// <summary>
    /// Super-property that groups all properties defining a polygon's boundaries.
    /// <see href="http://geovocab.org/geometry#boundary"></see></summary>
    let boundary = Namespaced_IRI.parse _namespace_name "boundary" |> NamespacedName
    /// <summary>
    /// Relates a resource to its geometric shape.
    /// <see href="http://geovocab.org/geometry#geometry"></see></summary>
    let geometry = Namespaced_IRI.parse _namespace_name "geometry" |> NamespacedName

    /// <summary>
    /// Links a LineString simple geometry to a MultiLineString composite geometry.
    /// <see href="http://geovocab.org/geometry#lineStringMember"></see></summary>
    let lineStringMember =
        Namespaced_IRI.parse _namespace_name "lineStringMember" |> NamespacedName

    /// <summary>
    /// Relates a point to a geometric shape's boundary.
    /// <see href="http://geovocab.org/geometry#partOf"></see></summary>
    let partOf = Namespaced_IRI.parse _namespace_name "partOf" |> NamespacedName

    /// <summary>
    /// Links a Point simple geometry to a MultiPoint composite Geometry.
    /// <see href="http://geovocab.org/geometry#pointMember"></see></summary>
    let pointMember =
        Namespaced_IRI.parse _namespace_name "pointMember" |> NamespacedName

    /// <summary>
    /// Links a Polygon simple geometry to a MultiPolygon composite geometry.
    /// <see href="http://geovocab.org/geometry#polygonMember"></see></summary>
    let polygonMember =
        Namespaced_IRI.parse _namespace_name "polygonMember" |> NamespacedName

    /// <summary>
    /// Relates a LineString or LinearRing to the points that define them.
    /// <see href="http://geovocab.org/geometry#posList"></see></summary>
    let posList = Namespaced_IRI.parse _namespace_name "posList" |> NamespacedName
