#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gsp =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.opengis.net/ont/geosparql#" "gsp"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:prefLabel : Feature</para>
    ///   <para>skos:definition : A discrete spatial phenomenon in a universe of discourse.</para>
    ///   <para>skos:note : A Feature represents a uniquely identifiable phenomenon, for example a river or an apple. While such phenomena (and therefore the Features used to represent them) are bounded, their boundaries may be crisp (e.g., the declared boundaries of a state), vague (e.g., the delineation of a valley versus its neighboring mountains), and change with time (e.g., a storm front). While discrete in nature, Features may be created from continuous observations, such as an isochrone that determines the region that can be reached by ambulance within 5 minutes.</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#Feature">gsp:Feature</a>
    /// </summary>
    let Feature = _prefixId.prefix "Feature"
    /// <summary>
    ///   <para>skos:definition : A collection of individual Features.</para>
    ///   <para>skos:prefLabel : Feature Collection</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#FeatureCollection">gsp:FeatureCollection</a>
    /// </summary>
    let FeatureCollection = _prefixId.prefix "FeatureCollection"
    /// <summary>
    ///   <para>skos:definition : A coherent set of direct positions in space. The positions are held within a Spatial Reference System (SRS).</para>
    ///   <para>skos:prefLabel : Geometry</para>
    ///   <para>skos:note : Geometry can be used as a representation of the shape, extent or location of a Feature and may exist as a self-contained entity.</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#Geometry">gsp:Geometry</a>
    /// </summary>
    let Geometry = _prefixId.prefix "Geometry"
    /// <summary>
    ///   <para>skos:prefLabel : Geometry Collection</para>
    ///   <para>skos:definition : A collection of individual Geometries.</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#GeometryCollection">gsp:GeometryCollection</a>
    /// </summary>
    let GeometryCollection = _prefixId.prefix "GeometryCollection"
    /// <summary>
    ///   <para>skos:prefLabel : Spatial Object</para>
    ///   <para>skos:definition : Anything spatial (being or having a shape, position or an extent).</para>
    ///   <para>skos:note : Subclasses of this class are expected to be used for instance data.</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#SpatialObject">gsp:SpatialObject</a>
    /// </summary>
    let SpatialObject = _prefixId.prefix "SpatialObject"
    /// <summary>
    ///   <para>skos:note : This is the superclass of Feature Collection and Geometry Collection.</para>
    ///   <para>skos:definition : A collection of individual Spatial Objects.</para>
    ///   <para>skos:prefLabel : Spatial Object Collection</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#SpatialObjectCollection">gsp:SpatialObjectCollection</a>
    /// </summary>
    let SpatialObjectCollection = _prefixId.prefix "SpatialObjectCollection"
    /// <summary>
    ///   <para>skos:definition : The Discrete Global Grid System (DGGS) serialization of a Geometry</para>
    ///   <para>skos:prefLabel : as DGGS</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#asDGGS">gsp:asDGGS</a>
    /// </summary>
    let asDGGS = _prefixId.prefix "asDGGS"
    /// <summary>
    ///   <para>skos:prefLabel : as GML</para>
    ///   <para>skos:definition : The GML serialization of a Geometry</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#asGML">gsp:asGML</a>
    /// </summary>
    let asGML = _prefixId.prefix "asGML"
    /// <summary>
    ///   <para>skos:definition : The GeoJSON serialization of a Geometry</para>
    ///   <para>skos:prefLabel : as GeoJSON</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#asGeoJSON">gsp:asGeoJSON</a>
    /// </summary>
    let asGeoJSON = _prefixId.prefix "asGeoJSON"
    /// <summary>
    ///   <para>skos:definition : The KML serialization of a Geometry</para>
    ///   <para>skos:prefLabel : as KML</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#asKML">gsp:asKML</a>
    /// </summary>
    let asKML = _prefixId.prefix "asKML"
    /// <summary>
    ///   <para>skos:prefLabel : as WKT</para>
    ///   <para>skos:definition : The WKT serialization of a Geometry</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#asWKT">gsp:asWKT</a>
    /// </summary>
    let asWKT = _prefixId.prefix "asWKT"
    /// <summary>
    ///   <para>skos:prefLabel : coordinate dimension</para>
    ///   <para>skos:definition : The number of measurements or axes needed to describe the position of this Geometry in a coordinate system.</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#coordinateDimension">gsp:coordinateDimension</a>
    /// </summary>
    let coordinateDimension = _prefixId.prefix "coordinateDimension"
    /// <summary>
    ///   <para>skos:definition : The default Geometry to be used in spatial calculations. It is usually the most detailed Geometry.</para>
    ///   <para>skos:note : Duplicate properties defaultGeometry and hasDefaultGeometry exist because of an inconsistency between ontology and documentation in GeoSPARQL 1.0. Only hasDefaultGeometry is described in the documention.</para>
    ///   <para>skos:prefLabel : default geometry</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#defaultGeometry">gsp:defaultGeometry</a>
    /// </summary>
    let defaultGeometry = _prefixId.prefix "defaultGeometry"
    let dggsLiteral = _prefixId.prefix "dggsLiteral"
    /// <summary>
    ///   <para>skos:prefLabel : dimension</para>
    ///   <para>skos:definition : The topological dimension of this geometric object, which must be less than or equal to the coordinate dimension. In non-homogeneous collections, this will return the largest topological dimension of the contained objects.</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#dimension">gsp:dimension</a>
    /// </summary>
    let dimension = _prefixId.prefix "dimension"
    /// <summary>
    ///   <para>skos:prefLabel : contains</para>
    ///   <para>skos:definition : States that the subject SpatialObject spatially contains the object SpatialObject. DE-9IM: T*TFF*FF*</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#ehContains">gsp:ehContains</a>
    /// </summary>
    let ehContains = _prefixId.prefix "ehContains"
    /// <summary>
    ///   <para>skos:prefLabel : covered by</para>
    ///   <para>skos:definition : States that the subject SpatialObject is spatially covered by the object SpatialObject. DE-9IM: TFF*TFT**</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#ehCoveredBy">gsp:ehCoveredBy</a>
    /// </summary>
    let ehCoveredBy = _prefixId.prefix "ehCoveredBy"
    /// <summary>
    ///   <para>skos:prefLabel : covers</para>
    ///   <para>skos:definition : States that the subject SpatialObject spatially covers the object SpatialObject. DE-9IM: T*TFT*FF*</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#ehCovers">gsp:ehCovers</a>
    /// </summary>
    let ehCovers = _prefixId.prefix "ehCovers"
    /// <summary>
    ///   <para>skos:prefLabel : disjoint</para>
    ///   <para>skos:definition : States that the subject SpatialObject is spatially disjoint from the object SpatialObject. DE-9IM: FF*FF****</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#ehDisjoint">gsp:ehDisjoint</a>
    /// </summary>
    let ehDisjoint = _prefixId.prefix "ehDisjoint"
    /// <summary>
    ///   <para>skos:prefLabel : equals</para>
    ///   <para>skos:definition : States that the subject SpatialObject spatially equals the object SpatialObject. DE-9IM: TFFFTFFFT</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#ehEquals">gsp:ehEquals</a>
    /// </summary>
    let ehEquals = _prefixId.prefix "ehEquals"
    /// <summary>
    ///   <para>skos:prefLabel : inside</para>
    ///   <para>skos:definition : States that the subject SpatialObject is spatially inside the object SpatialObject. DE-9IM: TFF*FFT**</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#ehInside">gsp:ehInside</a>
    /// </summary>
    let ehInside = _prefixId.prefix "ehInside"
    /// <summary>
    ///   <para>skos:definition : States that the subject SpatialObject spatially meets the object SpatialObject. DE-9IM: FT******* ^ F**T***** ^ F***T****</para>
    ///   <para>skos:prefLabel : meet</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#ehMeet">gsp:ehMeet</a>
    /// </summary>
    let ehMeet = _prefixId.prefix "ehMeet"
    /// <summary>
    ///   <para>skos:definition : States that the subject SpatialObject spatially overlaps the object SpatialObject. DE-9IM: T*T***T**</para>
    ///   <para>skos:prefLabel : overlap</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#ehOverlap">gsp:ehOverlap</a>
    /// </summary>
    let ehOverlap = _prefixId.prefix "ehOverlap"
    let geoJSONLiteral = _prefixId.prefix "geoJSONLiteral"
    let gmlLiteral = _prefixId.prefix "gmlLiteral"
    /// <summary>
    ///   <para>skos:prefLabel : has area</para>
    ///   <para>skos:definition : The area of a Spatial Object.</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#hasArea">gsp:hasArea</a>
    /// </summary>
    let hasArea = _prefixId.prefix "hasArea"
    /// <summary>
    ///   <para>skos:scopeNote : The target is a Geometry that defines a rectilinear region whose edges are aligned with the axes of the coordinate reference system, which exactly contains the Feature, for example an instance of http://www.opengis.net/ont/sf#envelope.</para>
    ///   <para>skos:definition : The minimum or smallest bounding or enclosing box of a given Feature.</para>
    ///   <para>skos:prefLabel : has bounding box</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#hasBoundingBox">gsp:hasBoundingBox</a>
    /// </summary>
    let hasBoundingBox = _prefixId.prefix "hasBoundingBox"
    /// <summary>
    ///   <para>skos:scopeNote : The target Geometry shall describe a point, for example an instance of http://www.opengis.net/ont/sf#Point.</para>
    ///   <para>skos:prefLabel : has centroid</para>
    ///   <para>skos:definition : The arithmetic mean position of all the Geometry points of a given Feature.</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#hasCentroid">gsp:hasCentroid</a>
    /// </summary>
    let hasCentroid = _prefixId.prefix "hasCentroid"
    /// <summary>
    ///   <para>skos:prefLabel : has default geometry</para>
    ///   <para>skos:definition : The default Geometry to be used in spatial calculations. It is usually the most detailed Geometry.</para>
    ///   <para>skos:note : Duplicate properties defaultGeometry and hasDefaultGeometry exist because of an inconsistency between ontology and documentation in GeoSPARQL 1.0. Only hasDefaultGeometry is described in the documention.</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#hasDefaultGeometry">gsp:hasDefaultGeometry</a>
    /// </summary>
    let hasDefaultGeometry = _prefixId.prefix "hasDefaultGeometry"
    /// <summary>
    ///   <para>skos:definition : A spatial representation for a given Feature.</para>
    ///   <para>skos:prefLabel : has geometry</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#hasGeometry">gsp:hasGeometry</a>
    /// </summary>
    let hasGeometry = _prefixId.prefix "hasGeometry"
    /// <summary>
    ///   <para>skos:prefLabel : has length</para>
    ///   <para>skos:definition : The length of a Spatial Object.</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#hasLength">gsp:hasLength</a>
    /// </summary>
    let hasLength = _prefixId.prefix "hasLength"
    /// <summary>
    ///   <para>skos:definition : The area of a Spatial Object in square meters.</para>
    ///   <para>skos:prefLabel : has area in square meters</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#hasMetricArea">gsp:hasMetricArea</a>
    /// </summary>
    let hasMetricArea = _prefixId.prefix "hasMetricArea"
    /// <summary>
    ///   <para>skos:definition : The length of a Spatial Object in meters.</para>
    ///   <para>skos:prefLabel : has length in meters</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#hasMetricLength">gsp:hasMetricLength</a>
    /// </summary>
    let hasMetricLength = _prefixId.prefix "hasMetricLength"
    /// <summary>
    ///   <para>skos:definition : The length of the perimeter of a Spatial Object in meters.</para>
    ///   <para>skos:prefLabel : has perimeter length in meters</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#hasMetricPerimeterLength">gsp:hasMetricPerimeterLength</a>
    /// </summary>
    let hasMetricPerimeterLength = _prefixId.prefix "hasMetricPerimeterLength"
    /// <summary>
    ///   <para>skos:prefLabel : has metric size</para>
    ///   <para>skos:definition : Subproperties of this property are used to indicate the size of a Spatial Object, as a measurement or estimate of one or more dimensions of the Spatial Object's spatial presence. Units are always metric (meter, square meter or cubic meter).</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#hasMetricSize">gsp:hasMetricSize</a>
    /// </summary>
    let hasMetricSize = _prefixId.prefix "hasMetricSize"
    /// <summary>
    ///   <para>skos:prefLabel : has spatial accuracy in meters</para>
    ///   <para>skos:definition : The positional accuracy of the coordinates of a Geometry in meters.</para>
    ///   <para>skos:note : Spatial accuracy is applicable when a Geometry is used to represent a Feature. It is expressed as a distance that indicates the truthfullness of the positions (coordinates) that define the Geometry. In this case accuracy defines a zone surrounding each coordinate within wich the real positions are known to be. The accuracy value defines this zone as a distance from the coordinate(s) in all directions (e.g. a line, a circle or a sphere, depending on spatial dimension).</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#hasMetricSpatialAccuracy">gsp:hasMetricSpatialAccuracy</a>
    /// </summary>
    let hasMetricSpatialAccuracy = _prefixId.prefix "hasMetricSpatialAccuracy"
    /// <summary>
    ///   <para>skos:definition : The spatial resolution of a Geometry in meters.</para>
    ///   <para>skos:prefLabel : has spatial resolution in meters</para>
    ///   <para>skos:note : Spatial resolution specifies the level of detail of a Geometry. It the smallest dinstinguishable distance between spatially adjacent coordinates.</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#hasMetricSpatialResolution">gsp:hasMetricSpatialResolution</a>
    /// </summary>
    let hasMetricSpatialResolution = _prefixId.prefix "hasMetricSpatialResolution"
    /// <summary>
    ///   <para>skos:prefLabel : has volume in cubic meters</para>
    ///   <para>skos:definition : The volume of a Spatial Object in cubic meters.</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#hasMetricVolume">gsp:hasMetricVolume</a>
    /// </summary>
    let hasMetricVolume = _prefixId.prefix "hasMetricVolume"
    /// <summary>
    ///   <para>skos:prefLabel : has perimeter length</para>
    ///   <para>skos:definition : The length of the perimeter of a Spatial Object.</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#hasPerimeterLength">gsp:hasPerimeterLength</a>
    /// </summary>
    let hasPerimeterLength = _prefixId.prefix "hasPerimeterLength"
    /// <summary>
    ///   <para>skos:prefLabel : has serialization</para>
    ///   <para>skos:definition : Connects a Geometry object with its text-based serialization.</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#hasSerialization">gsp:hasSerialization</a>
    /// </summary>
    let hasSerialization = _prefixId.prefix "hasSerialization"
    /// <summary>
    ///   <para>skos:prefLabel : has size</para>
    ///   <para>skos:note : The recommended way to specify size is by using a subproperty of hasMetricSize. Subproperties of hasSize can be used if more complex expressions are necessary, for example if the unit of length can not be converted to meter, or if additional data are needed to describe the measurement or estimate.</para>
    ///   <para>skos:definition : Subproperties of this property are used to indicate the size of a Spatial Object as a measurement or estimate of one or more dimensions of the Spatial Object's spatial presence.</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#hasSize">gsp:hasSize</a>
    /// </summary>
    let hasSize = _prefixId.prefix "hasSize"
    /// <summary>
    ///   <para>skos:prefLabel : has spatial accuracy</para>
    ///   <para>skos:note : Spatial accuracy is applicable when a Geometry is used to represent a Feature. It is expressed as a distance that indicates the truthfullness of the positions (coordinates) that define the Geometry. In this case accuracy defines a zone surrounding each coordinate within wich the real positions are known to be. The accuracy value defines this zone as a distance from the coordinate(s) in all directions (e.g. a line, a circle or a sphere, depending on spatial dimension).</para>
    ///   <para>skos:definition : The positional accuracy of the coordinates of a Geometry.</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#hasSpatialAccuracy">gsp:hasSpatialAccuracy</a>
    /// </summary>
    let hasSpatialAccuracy = _prefixId.prefix "hasSpatialAccuracy"
    /// <summary>
    ///   <para>skos:prefLabel : has spatial resolution</para>
    ///   <para>skos:note : Spatial resolution specifies the level of detail of a Geometry. It the smallest distinguishable distance between spatially adjacent coordinates.</para>
    ///   <para>skos:definition : The spatial resolution of a Geometry.</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#hasSpatialResolution">gsp:hasSpatialResolution</a>
    /// </summary>
    let hasSpatialResolution = _prefixId.prefix "hasSpatialResolution"
    /// <summary>
    ///   <para>skos:prefLabel : has volume</para>
    ///   <para>skos:definition : The volume of a three-dimensional Spatial Object.</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#hasVolume">gsp:hasVolume</a>
    /// </summary>
    let hasVolume = _prefixId.prefix "hasVolume"
    /// <summary>
    ///   <para>skos:prefLabel : is empty</para>
    ///   <para>skos:definition : (true) if this geometric object is the empty Geometry. If true, then this geometric object represents the empty point set for the coordinate space.</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#isEmpty">gsp:isEmpty</a>
    /// </summary>
    let isEmpty = _prefixId.prefix "isEmpty"
    /// <summary>
    ///   <para>skos:definition : (true) if this geometric object has no anomalous geometric points, such as self intersection or self tangency.</para>
    ///   <para>skos:prefLabel : is simple</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#isSimple">gsp:isSimple</a>
    /// </summary>
    let isSimple = _prefixId.prefix "isSimple"
    let kmlLiteral = _prefixId.prefix "kmlLiteral"
    /// <summary>
    ///   <para>skos:definition : States that the subject SpatialObject is spatially disjoint from the object SpatialObject. DE-9IM: FFTFFTTTT</para>
    ///   <para>skos:prefLabel : disconnected</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#rcc8dc">gsp:rcc8dc</a>
    /// </summary>
    let rcc8dc = _prefixId.prefix "rcc8dc"
    /// <summary>
    ///   <para>skos:prefLabel : externally connected</para>
    ///   <para>skos:definition : States that the subject SpatialObject spatially meets the object SpatialObject. DE-9IM: FFTFTTTTT</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#rcc8ec">gsp:rcc8ec</a>
    /// </summary>
    let rcc8ec = _prefixId.prefix "rcc8ec"
    /// <summary>
    ///   <para>skos:definition : States that the subject SpatialObject spatially equals the object SpatialObject. DE-9IM: TFFFTFFFT</para>
    ///   <para>skos:prefLabel : equals</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#rcc8eq">gsp:rcc8eq</a>
    /// </summary>
    let rcc8eq = _prefixId.prefix "rcc8eq"
    /// <summary>
    ///   <para>skos:definition : States that the subject SpatialObject is spatially inside the object SpatialObject. DE-9IM: TFFTFFTTT</para>
    ///   <para>skos:prefLabel : non-tangential proper part</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#rcc8ntpp">gsp:rcc8ntpp</a>
    /// </summary>
    let rcc8ntpp = _prefixId.prefix "rcc8ntpp"
    /// <summary>
    ///   <para>skos:prefLabel : non-tangential proper part inverse</para>
    ///   <para>skos:definition : States that the subject SpatialObject spatially contains the object SpatialObject. DE-9IM: TTTFFTFFT</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#rcc8ntppi">gsp:rcc8ntppi</a>
    /// </summary>
    let rcc8ntppi = _prefixId.prefix "rcc8ntppi"
    /// <summary>
    ///   <para>skos:prefLabel : partially overlapping</para>
    ///   <para>skos:definition : States that the subject SpatialObject spatially overlaps the object SpatialObject. DE-9IM: TTTTTTTTT</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#rcc8po">gsp:rcc8po</a>
    /// </summary>
    let rcc8po = _prefixId.prefix "rcc8po"
    /// <summary>
    ///   <para>skos:prefLabel : tangential proper part</para>
    ///   <para>skos:definition : States that the subject SpatialObject is spatially covered by the object SpatialObject. DE-9IM: TFFTTFTTT</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#rcc8tpp">gsp:rcc8tpp</a>
    /// </summary>
    let rcc8tpp = _prefixId.prefix "rcc8tpp"
    /// <summary>
    ///   <para>skos:prefLabel : tangential proper part inverse</para>
    ///   <para>skos:definition : States that the subject SpatialObject spatially covers the object SpatialObject. DE-9IM: TTTFTTFFT</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#rcc8tppi">gsp:rcc8tppi</a>
    /// </summary>
    let rcc8tppi = _prefixId.prefix "rcc8tppi"
    /// <summary>
    ///   <para>skos:definition : States that the subject SpatialObject spatially contains the object SpatialObject. DE-9IM: T*****FF*</para>
    ///   <para>skos:prefLabel : contains</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#sfContains">gsp:sfContains</a>
    /// </summary>
    let sfContains = _prefixId.prefix "sfContains"
    /// <summary>
    ///   <para>skos:prefLabel : crosses</para>
    ///   <para>skos:definition : States that the subject SpatialObject spatially crosses the object SpatialObject. DE-9IM: T*T******</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#sfCrosses">gsp:sfCrosses</a>
    /// </summary>
    let sfCrosses = _prefixId.prefix "sfCrosses"
    /// <summary>
    ///   <para>skos:prefLabel : disjoint</para>
    ///   <para>skos:definition : States that the subject SpatialObject is spatially disjoint from the object SpatialObject. DE-9IM: FF*FF****</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#sfDisjoint">gsp:sfDisjoint</a>
    /// </summary>
    let sfDisjoint = _prefixId.prefix "sfDisjoint"
    /// <summary>
    ///   <para>skos:prefLabel : equals</para>
    ///   <para>skos:definition : States that the subject SpatialObject spatially equals the object SpatialObject. DE-9IM: TFFFTFFFT</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#sfEquals">gsp:sfEquals</a>
    /// </summary>
    let sfEquals = _prefixId.prefix "sfEquals"
    /// <summary>
    ///   <para>skos:prefLabel : intersects</para>
    ///   <para>skos:definition : States that the subject SpatialObject is not spatially disjoint from the object SpatialObject. DE-9IM: T******** ^ *T******* ^ ***T***** ^ ****T****</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#sfIntersects">gsp:sfIntersects</a>
    /// </summary>
    let sfIntersects = _prefixId.prefix "sfIntersects"
    /// <summary>
    ///   <para>skos:definition : States that the subject SpatialObject spatially overlaps the object SpatialObject. DE-9IM: T*T***T**</para>
    ///   <para>skos:prefLabel : overlaps</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#sfOverlaps">gsp:sfOverlaps</a>
    /// </summary>
    let sfOverlaps = _prefixId.prefix "sfOverlaps"
    /// <summary>
    ///   <para>skos:prefLabel : touches</para>
    ///   <para>skos:definition : States that the subject SpatialObject spatially touches the object SpatialObject. DE-9IM: FT******* ^ F**T***** ^ F***T****</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#sfTouches">gsp:sfTouches</a>
    /// </summary>
    let sfTouches = _prefixId.prefix "sfTouches"
    /// <summary>
    ///   <para>skos:definition : States that the subject SpatialObject is spatially within the object SpatialObject. DE-9IM: T*F**F***</para>
    ///   <para>skos:prefLabel : within</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#sfWithin">gsp:sfWithin</a>
    /// </summary>
    let sfWithin = _prefixId.prefix "sfWithin"
    /// <summary>
    ///   <para>skos:prefLabel : spatial dimension</para>
    ///   <para>skos:definition : The number of measurements or axes needed to describe the spatial position of this Geometry in a coordinate system.</para>
    ///   <a href="http://www.opengis.net/ont/geosparql#spatialDimension">gsp:spatialDimension</a>
    /// </summary>
    let spatialDimension = _prefixId.prefix "spatialDimension"
    let wktLiteral = _prefixId.prefix "wktLiteral"
