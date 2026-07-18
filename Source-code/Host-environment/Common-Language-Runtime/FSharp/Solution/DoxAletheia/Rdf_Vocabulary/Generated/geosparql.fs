namespace http.www.opengis.net.ont.geosparql.hash

open DoxAletheia.Rdf_Vocabulary

module geosparql =
    let _namespace_name = "http://www.opengis.net/ont/geosparql#"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#Feature"></see>
    /// </summary>
    let Feature = Namespaced_IRI.parse _namespace_name "Feature" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#SpatialObject"></see>
    /// </summary>
    let SpatialObject =
        Namespaced_IRI.parse _namespace_name "SpatialObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#Geometry"></see>
    /// </summary>
    let Geometry = Namespaced_IRI.parse _namespace_name "Geometry" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#FeatureCollection"></see>
    /// </summary>
    let FeatureCollection =
        Namespaced_IRI.parse _namespace_name "FeatureCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#SpatialObjectCollection"></see>
    /// </summary>
    let SpatialObjectCollection =
        Namespaced_IRI.parse _namespace_name "SpatialObjectCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#GeometryCollection"></see>
    /// </summary>
    let GeometryCollection =
        Namespaced_IRI.parse _namespace_name "GeometryCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#asDGGS"></see>
    /// </summary>
    let asDGGS = Namespaced_IRI.parse _namespace_name "asDGGS" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#dggsLiteral"></see>
    /// </summary>
    let dggsLiteral =
        Namespaced_IRI.parse _namespace_name "dggsLiteral" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasSerialization"></see>
    /// </summary>
    let hasSerialization =
        Namespaced_IRI.parse _namespace_name "hasSerialization" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#asGML"></see>
    /// </summary>
    let asGML = Namespaced_IRI.parse _namespace_name "asGML" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#gmlLiteral"></see>
    /// </summary>
    let gmlLiteral = Namespaced_IRI.parse _namespace_name "gmlLiteral" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#asGeoJSON"></see>
    /// </summary>
    let asGeoJSON = Namespaced_IRI.parse _namespace_name "asGeoJSON" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#geoJSONLiteral"></see>
    /// </summary>
    let geoJSONLiteral =
        Namespaced_IRI.parse _namespace_name "geoJSONLiteral" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#asKML"></see>
    /// </summary>
    let asKML = Namespaced_IRI.parse _namespace_name "asKML" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#kmlLiteral"></see>
    /// </summary>
    let kmlLiteral = Namespaced_IRI.parse _namespace_name "kmlLiteral" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#asWKT"></see>
    /// </summary>
    let asWKT = Namespaced_IRI.parse _namespace_name "asWKT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#wktLiteral"></see>
    /// </summary>
    let wktLiteral = Namespaced_IRI.parse _namespace_name "wktLiteral" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#coordinateDimension"></see>
    /// </summary>
    let coordinateDimension =
        Namespaced_IRI.parse _namespace_name "coordinateDimension" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#defaultGeometry"></see>
    /// </summary>
    let defaultGeometry =
        Namespaced_IRI.parse _namespace_name "defaultGeometry" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasGeometry"></see>
    /// </summary>
    let hasGeometry =
        Namespaced_IRI.parse _namespace_name "hasGeometry" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasDefaultGeometry"></see>
    /// </summary>
    let hasDefaultGeometry =
        Namespaced_IRI.parse _namespace_name "hasDefaultGeometry" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#dimension"></see>
    /// </summary>
    let dimension = Namespaced_IRI.parse _namespace_name "dimension" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#ehContains"></see>
    /// </summary>
    let ehContains = Namespaced_IRI.parse _namespace_name "ehContains" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#ehCoveredBy"></see>
    /// </summary>
    let ehCoveredBy =
        Namespaced_IRI.parse _namespace_name "ehCoveredBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#ehCovers"></see>
    /// </summary>
    let ehCovers = Namespaced_IRI.parse _namespace_name "ehCovers" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#ehDisjoint"></see>
    /// </summary>
    let ehDisjoint = Namespaced_IRI.parse _namespace_name "ehDisjoint" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#sfDisjoint"></see>
    /// </summary>
    let sfDisjoint = Namespaced_IRI.parse _namespace_name "sfDisjoint" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#ehEquals"></see>
    /// </summary>
    let ehEquals = Namespaced_IRI.parse _namespace_name "ehEquals" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#sfEquals"></see>
    /// </summary>
    let sfEquals = Namespaced_IRI.parse _namespace_name "sfEquals" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#ehInside"></see>
    /// </summary>
    let ehInside = Namespaced_IRI.parse _namespace_name "ehInside" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#ehMeet"></see>
    /// </summary>
    let ehMeet = Namespaced_IRI.parse _namespace_name "ehMeet" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#sfTouches"></see>
    /// </summary>
    let sfTouches = Namespaced_IRI.parse _namespace_name "sfTouches" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#ehOverlap"></see>
    /// </summary>
    let ehOverlap = Namespaced_IRI.parse _namespace_name "ehOverlap" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasArea"></see>
    /// </summary>
    let hasArea = Namespaced_IRI.parse _namespace_name "hasArea" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasSize"></see>
    /// </summary>
    let hasSize = Namespaced_IRI.parse _namespace_name "hasSize" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasBoundingBox"></see>
    /// </summary>
    let hasBoundingBox =
        Namespaced_IRI.parse _namespace_name "hasBoundingBox" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasCentroid"></see>
    /// </summary>
    let hasCentroid =
        Namespaced_IRI.parse _namespace_name "hasCentroid" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasLength"></see>
    /// </summary>
    let hasLength = Namespaced_IRI.parse _namespace_name "hasLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasMetricArea"></see>
    /// </summary>
    let hasMetricArea =
        Namespaced_IRI.parse _namespace_name "hasMetricArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasMetricSize"></see>
    /// </summary>
    let hasMetricSize =
        Namespaced_IRI.parse _namespace_name "hasMetricSize" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasMetricLength"></see>
    /// </summary>
    let hasMetricLength =
        Namespaced_IRI.parse _namespace_name "hasMetricLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasMetricPerimeterLength"></see>
    /// </summary>
    let hasMetricPerimeterLength =
        Namespaced_IRI.parse _namespace_name "hasMetricPerimeterLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasMetricSpatialAccuracy"></see>
    /// </summary>
    let hasMetricSpatialAccuracy =
        Namespaced_IRI.parse _namespace_name "hasMetricSpatialAccuracy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasMetricSpatialResolution"></see>
    /// </summary>
    let hasMetricSpatialResolution =
        Namespaced_IRI.parse _namespace_name "hasMetricSpatialResolution" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasMetricVolume"></see>
    /// </summary>
    let hasMetricVolume =
        Namespaced_IRI.parse _namespace_name "hasMetricVolume" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasPerimeterLength"></see>
    /// </summary>
    let hasPerimeterLength =
        Namespaced_IRI.parse _namespace_name "hasPerimeterLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasSpatialAccuracy"></see>
    /// </summary>
    let hasSpatialAccuracy =
        Namespaced_IRI.parse _namespace_name "hasSpatialAccuracy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasSpatialResolution"></see>
    /// </summary>
    let hasSpatialResolution =
        Namespaced_IRI.parse _namespace_name "hasSpatialResolution" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasVolume"></see>
    /// </summary>
    let hasVolume = Namespaced_IRI.parse _namespace_name "hasVolume" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#isEmpty"></see>
    /// </summary>
    let isEmpty = Namespaced_IRI.parse _namespace_name "isEmpty" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#isSimple"></see>
    /// </summary>
    let isSimple = Namespaced_IRI.parse _namespace_name "isSimple" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#rcc8dc"></see>
    /// </summary>
    let rcc8dc = Namespaced_IRI.parse _namespace_name "rcc8dc" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#rcc8ec"></see>
    /// </summary>
    let rcc8ec = Namespaced_IRI.parse _namespace_name "rcc8ec" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#rcc8eq"></see>
    /// </summary>
    let rcc8eq = Namespaced_IRI.parse _namespace_name "rcc8eq" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#rcc8ntpp"></see>
    /// </summary>
    let rcc8ntpp = Namespaced_IRI.parse _namespace_name "rcc8ntpp" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#rcc8ntppi"></see>
    /// </summary>
    let rcc8ntppi = Namespaced_IRI.parse _namespace_name "rcc8ntppi" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#rcc8po"></see>
    /// </summary>
    let rcc8po = Namespaced_IRI.parse _namespace_name "rcc8po" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#rcc8tpp"></see>
    /// </summary>
    let rcc8tpp = Namespaced_IRI.parse _namespace_name "rcc8tpp" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#rcc8tppi"></see>
    /// </summary>
    let rcc8tppi = Namespaced_IRI.parse _namespace_name "rcc8tppi" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#sfContains"></see>
    /// </summary>
    let sfContains = Namespaced_IRI.parse _namespace_name "sfContains" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#sfCrosses"></see>
    /// </summary>
    let sfCrosses = Namespaced_IRI.parse _namespace_name "sfCrosses" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#sfIntersects"></see>
    /// </summary>
    let sfIntersects =
        Namespaced_IRI.parse _namespace_name "sfIntersects" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#sfOverlaps"></see>
    /// </summary>
    let sfOverlaps = Namespaced_IRI.parse _namespace_name "sfOverlaps" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#sfWithin"></see>
    /// </summary>
    let sfWithin = Namespaced_IRI.parse _namespace_name "sfWithin" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#spatialDimension"></see>
    /// </summary>
    let spatialDimension =
        Namespaced_IRI.parse _namespace_name "spatialDimension" |> NamespacedName
