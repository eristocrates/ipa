namespace http.www.opengis.net.ont.geosparql.hash

open DoxAletheia

module geosparql =
    let _namespace_name = "http://www.opengis.net/ont/geosparql#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#Feature"></see>
    /// </summary>
    let Feature = _prefix "Feature"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#SpatialObject"></see>
    /// </summary>
    let SpatialObject = _prefix "SpatialObject"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#Geometry"></see>
    /// </summary>
    let Geometry = _prefix "Geometry"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#FeatureCollection"></see>
    /// </summary>
    let FeatureCollection = _prefix "FeatureCollection"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#SpatialObjectCollection"></see>
    /// </summary>
    let SpatialObjectCollection = _prefix "SpatialObjectCollection"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#GeometryCollection"></see>
    /// </summary>
    let GeometryCollection = _prefix "GeometryCollection"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#asDGGS"></see>
    /// </summary>
    let asDGGS = _prefix "asDGGS"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#dggsLiteral"></see>
    /// </summary>
    let dggsLiteral = _prefix "dggsLiteral"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasSerialization"></see>
    /// </summary>
    let hasSerialization = _prefix "hasSerialization"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#asGML"></see>
    /// </summary>
    let asGML = _prefix "asGML"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#gmlLiteral"></see>
    /// </summary>
    let gmlLiteral = _prefix "gmlLiteral"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#asGeoJSON"></see>
    /// </summary>
    let asGeoJSON = _prefix "asGeoJSON"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#geoJSONLiteral"></see>
    /// </summary>
    let geoJSONLiteral = _prefix "geoJSONLiteral"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#asKML"></see>
    /// </summary>
    let asKML = _prefix "asKML"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#kmlLiteral"></see>
    /// </summary>
    let kmlLiteral = _prefix "kmlLiteral"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#asWKT"></see>
    /// </summary>
    let asWKT = _prefix "asWKT"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#wktLiteral"></see>
    /// </summary>
    let wktLiteral = _prefix "wktLiteral"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#coordinateDimension"></see>
    /// </summary>
    let coordinateDimension = _prefix "coordinateDimension"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#defaultGeometry"></see>
    /// </summary>
    let defaultGeometry = _prefix "defaultGeometry"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasGeometry"></see>
    /// </summary>
    let hasGeometry = _prefix "hasGeometry"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasDefaultGeometry"></see>
    /// </summary>
    let hasDefaultGeometry = _prefix "hasDefaultGeometry"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#dimension"></see>
    /// </summary>
    let dimension = _prefix "dimension"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#ehContains"></see>
    /// </summary>
    let ehContains = _prefix "ehContains"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#ehCoveredBy"></see>
    /// </summary>
    let ehCoveredBy = _prefix "ehCoveredBy"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#ehCovers"></see>
    /// </summary>
    let ehCovers = _prefix "ehCovers"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#ehDisjoint"></see>
    /// </summary>
    let ehDisjoint = _prefix "ehDisjoint"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#sfDisjoint"></see>
    /// </summary>
    let sfDisjoint = _prefix "sfDisjoint"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#ehEquals"></see>
    /// </summary>
    let ehEquals = _prefix "ehEquals"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#sfEquals"></see>
    /// </summary>
    let sfEquals = _prefix "sfEquals"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#ehInside"></see>
    /// </summary>
    let ehInside = _prefix "ehInside"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#ehMeet"></see>
    /// </summary>
    let ehMeet = _prefix "ehMeet"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#sfTouches"></see>
    /// </summary>
    let sfTouches = _prefix "sfTouches"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#ehOverlap"></see>
    /// </summary>
    let ehOverlap = _prefix "ehOverlap"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasArea"></see>
    /// </summary>
    let hasArea = _prefix "hasArea"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasSize"></see>
    /// </summary>
    let hasSize = _prefix "hasSize"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasBoundingBox"></see>
    /// </summary>
    let hasBoundingBox = _prefix "hasBoundingBox"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasCentroid"></see>
    /// </summary>
    let hasCentroid = _prefix "hasCentroid"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasLength"></see>
    /// </summary>
    let hasLength = _prefix "hasLength"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasMetricArea"></see>
    /// </summary>
    let hasMetricArea = _prefix "hasMetricArea"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasMetricSize"></see>
    /// </summary>
    let hasMetricSize = _prefix "hasMetricSize"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasMetricLength"></see>
    /// </summary>
    let hasMetricLength = _prefix "hasMetricLength"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasMetricPerimeterLength"></see>
    /// </summary>
    let hasMetricPerimeterLength = _prefix "hasMetricPerimeterLength"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasMetricSpatialAccuracy"></see>
    /// </summary>
    let hasMetricSpatialAccuracy = _prefix "hasMetricSpatialAccuracy"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasMetricSpatialResolution"></see>
    /// </summary>
    let hasMetricSpatialResolution = _prefix "hasMetricSpatialResolution"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasMetricVolume"></see>
    /// </summary>
    let hasMetricVolume = _prefix "hasMetricVolume"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasPerimeterLength"></see>
    /// </summary>
    let hasPerimeterLength = _prefix "hasPerimeterLength"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasSpatialAccuracy"></see>
    /// </summary>
    let hasSpatialAccuracy = _prefix "hasSpatialAccuracy"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasSpatialResolution"></see>
    /// </summary>
    let hasSpatialResolution = _prefix "hasSpatialResolution"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#hasVolume"></see>
    /// </summary>
    let hasVolume = _prefix "hasVolume"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#isEmpty"></see>
    /// </summary>
    let isEmpty = _prefix "isEmpty"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#isSimple"></see>
    /// </summary>
    let isSimple = _prefix "isSimple"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#rcc8dc"></see>
    /// </summary>
    let rcc8dc = _prefix "rcc8dc"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#rcc8ec"></see>
    /// </summary>
    let rcc8ec = _prefix "rcc8ec"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#rcc8eq"></see>
    /// </summary>
    let rcc8eq = _prefix "rcc8eq"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#rcc8ntpp"></see>
    /// </summary>
    let rcc8ntpp = _prefix "rcc8ntpp"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#rcc8ntppi"></see>
    /// </summary>
    let rcc8ntppi = _prefix "rcc8ntppi"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#rcc8po"></see>
    /// </summary>
    let rcc8po = _prefix "rcc8po"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#rcc8tpp"></see>
    /// </summary>
    let rcc8tpp = _prefix "rcc8tpp"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#rcc8tppi"></see>
    /// </summary>
    let rcc8tppi = _prefix "rcc8tppi"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#sfContains"></see>
    /// </summary>
    let sfContains = _prefix "sfContains"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#sfCrosses"></see>
    /// </summary>
    let sfCrosses = _prefix "sfCrosses"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#sfIntersects"></see>
    /// </summary>
    let sfIntersects = _prefix "sfIntersects"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#sfOverlaps"></see>
    /// </summary>
    let sfOverlaps = _prefix "sfOverlaps"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#sfWithin"></see>
    /// </summary>
    let sfWithin = _prefix "sfWithin"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/geosparql#spatialDimension"></see>
    /// </summary>
    let spatialDimension = _prefix "spatialDimension"
