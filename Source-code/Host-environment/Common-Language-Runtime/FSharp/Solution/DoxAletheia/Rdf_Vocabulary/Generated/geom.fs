namespace http.data.ign.fr.def.geometrie.hash

open DoxAletheia

module geom =
    let _namespace_name = "http://data.ign.fr/def/geometrie#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#Curve"></see>
    /// </summary>
    let Curve = _prefix "Curve"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#Geometry"></see>
    /// </summary>
    let Geometry = _prefix "Geometry"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#Envelope"></see>
    /// </summary>
    let Envelope = _prefix "Envelope"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#upperCorner"></see>
    /// </summary>
    let upperCorner = _prefix "upperCorner"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#Point"></see>
    /// </summary>
    let Point = _prefix "Point"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#lowerCorner"></see>
    /// </summary>
    let lowerCorner = _prefix "lowerCorner"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#crs"></see>
    /// </summary>
    let crs = _prefix "crs"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#GeometryCollection"></see>
    /// </summary>
    let GeometryCollection = _prefix "GeometryCollection"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#Line"></see>
    /// </summary>
    let Line = _prefix "Line"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#LineString"></see>
    /// </summary>
    let LineString = _prefix "LineString"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#PointsList"></see>
    /// </summary>
    let PointsList = _prefix "PointsList"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#points"></see>
    /// </summary>
    let points = _prefix "points"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#LinearRing"></see>
    /// </summary>
    let LinearRing = _prefix "LinearRing"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#firstAndLast"></see>
    /// </summary>
    let firstAndLast = _prefix "firstAndLast"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#MultiCurve"></see>
    /// </summary>
    let MultiCurve = _prefix "MultiCurve"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#MultiLineString"></see>
    /// </summary>
    let MultiLineString = _prefix "MultiLineString"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#lineStringMember"></see>
    /// </summary>
    let lineStringMember = _prefix "lineStringMember"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#MultiPoint"></see>
    /// </summary>
    let MultiPoint = _prefix "MultiPoint"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#pointMember"></see>
    /// </summary>
    let pointMember = _prefix "pointMember"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#MultiPolygon"></see>
    /// </summary>
    let MultiPolygon = _prefix "MultiPolygon"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#MultiSurface"></see>
    /// </summary>
    let MultiSurface = _prefix "MultiSurface"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#Polygon"></see>
    /// </summary>
    let Polygon = _prefix "Polygon"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#polygonMember"></see>
    /// </summary>
    let polygonMember = _prefix "polygonMember"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#coordY"></see>
    /// </summary>
    let coordY = _prefix "coordY"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#coordX"></see>
    /// </summary>
    let coordX = _prefix "coordX"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#coordZ"></see>
    /// </summary>
    let coordZ = _prefix "coordZ"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#coordM"></see>
    /// </summary>
    let coordM = _prefix "coordM"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#exterior"></see>
    /// </summary>
    let exterior = _prefix "exterior"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#interior"></see>
    /// </summary>
    let interior = _prefix "interior"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#Surface"></see>
    /// </summary>
    let Surface = _prefix "Surface"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#boundary"></see>
    /// </summary>
    let boundary = _prefix "boundary"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#centroid"></see>
    /// </summary>
    let centroid = _prefix "centroid"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#envelope"></see>
    /// </summary>
    let envelope = _prefix "envelope"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#geometry"></see>
    /// </summary>
    let geometry = _prefix "geometry"
