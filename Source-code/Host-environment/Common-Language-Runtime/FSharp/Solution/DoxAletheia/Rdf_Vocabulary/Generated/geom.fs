namespace http.data.ign.fr.def.geometrie.hash

open DoxAletheia.Rdf_Vocabulary

module geom =
    let _namespace_name = "http://data.ign.fr/def/geometrie#"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#Curve"></see>
    /// </summary>
    let Curve = Namespaced_IRI.parse _namespace_name "Curve" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#Geometry"></see>
    /// </summary>
    let Geometry = Namespaced_IRI.parse _namespace_name "Geometry" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#Envelope"></see>
    /// </summary>
    let Envelope = Namespaced_IRI.parse _namespace_name "Envelope" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#upperCorner"></see>
    /// </summary>
    let upperCorner =
        Namespaced_IRI.parse _namespace_name "upperCorner" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#Point"></see>
    /// </summary>
    let Point = Namespaced_IRI.parse _namespace_name "Point" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#lowerCorner"></see>
    /// </summary>
    let lowerCorner =
        Namespaced_IRI.parse _namespace_name "lowerCorner" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#crs"></see>
    /// </summary>
    let crs = Namespaced_IRI.parse _namespace_name "crs" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#GeometryCollection"></see>
    /// </summary>
    let GeometryCollection =
        Namespaced_IRI.parse _namespace_name "GeometryCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#Line"></see>
    /// </summary>
    let Line = Namespaced_IRI.parse _namespace_name "Line" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#LineString"></see>
    /// </summary>
    let LineString = Namespaced_IRI.parse _namespace_name "LineString" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#PointsList"></see>
    /// </summary>
    let PointsList = Namespaced_IRI.parse _namespace_name "PointsList" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#points"></see>
    /// </summary>
    let points = Namespaced_IRI.parse _namespace_name "points" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#LinearRing"></see>
    /// </summary>
    let LinearRing = Namespaced_IRI.parse _namespace_name "LinearRing" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#firstAndLast"></see>
    /// </summary>
    let firstAndLast =
        Namespaced_IRI.parse _namespace_name "firstAndLast" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#MultiCurve"></see>
    /// </summary>
    let MultiCurve = Namespaced_IRI.parse _namespace_name "MultiCurve" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#MultiLineString"></see>
    /// </summary>
    let MultiLineString =
        Namespaced_IRI.parse _namespace_name "MultiLineString" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#lineStringMember"></see>
    /// </summary>
    let lineStringMember =
        Namespaced_IRI.parse _namespace_name "lineStringMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#MultiPoint"></see>
    /// </summary>
    let MultiPoint = Namespaced_IRI.parse _namespace_name "MultiPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#pointMember"></see>
    /// </summary>
    let pointMember =
        Namespaced_IRI.parse _namespace_name "pointMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#MultiPolygon"></see>
    /// </summary>
    let MultiPolygon =
        Namespaced_IRI.parse _namespace_name "MultiPolygon" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#MultiSurface"></see>
    /// </summary>
    let MultiSurface =
        Namespaced_IRI.parse _namespace_name "MultiSurface" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#Polygon"></see>
    /// </summary>
    let Polygon = Namespaced_IRI.parse _namespace_name "Polygon" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#polygonMember"></see>
    /// </summary>
    let polygonMember =
        Namespaced_IRI.parse _namespace_name "polygonMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#coordY"></see>
    /// </summary>
    let coordY = Namespaced_IRI.parse _namespace_name "coordY" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#coordX"></see>
    /// </summary>
    let coordX = Namespaced_IRI.parse _namespace_name "coordX" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#coordZ"></see>
    /// </summary>
    let coordZ = Namespaced_IRI.parse _namespace_name "coordZ" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#coordM"></see>
    /// </summary>
    let coordM = Namespaced_IRI.parse _namespace_name "coordM" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#exterior"></see>
    /// </summary>
    let exterior = Namespaced_IRI.parse _namespace_name "exterior" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#interior"></see>
    /// </summary>
    let interior = Namespaced_IRI.parse _namespace_name "interior" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#Surface"></see>
    /// </summary>
    let Surface = Namespaced_IRI.parse _namespace_name "Surface" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#boundary"></see>
    /// </summary>
    let boundary = Namespaced_IRI.parse _namespace_name "boundary" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#centroid"></see>
    /// </summary>
    let centroid = Namespaced_IRI.parse _namespace_name "centroid" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#envelope"></see>
    /// </summary>
    let envelope = Namespaced_IRI.parse _namespace_name "envelope" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/geometrie#geometry"></see>
    /// </summary>
    let geometry = Namespaced_IRI.parse _namespace_name "geometry" |> NamespacedName
