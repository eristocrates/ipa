namespace http.www.opengis.net.ont.geosparql.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module geosparql =
    let _namespace_iri = Namespace_Iri geosparql |> NamespaceIRI
    /// <summary>
    ///   <para>ns349:geosparql#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#">http://www.opengis.net/ont/geosparql#</seealso>
    let _prefix_iri = Prefixed_Name(geosparql, "") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///       This class represents the top-level feature type. This class is
    ///       equivalent to GFI_Feature defined in ISO 19156:2011, and it is
    ///       superclass of all feature types.
    ///     "</para>
    ///   <para>"This class represents the top-level feature type. This class is equivalent to GFI_Feature defined in ISO 19156:2011, and it is superclass of all feature types."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This class represents the top-level feature type. This class is equivalent to GFI_Feature defined in ISO 19156:2011, and it is superclass of all feature types."</para>
    /// labels<para>"Feature"</para><para>"geosparql:Feature"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#Feature">http://www.opengis.net/ont/geosparql#Feature</seealso>
    let Feature = Prefixed_Name(geosparql, "Feature") |> PrefixedName

    /// <summary>
    ///   <para>ns349:geosparql#FeatureCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#FeatureCollection">http://www.opengis.net/ont/geosparql#FeatureCollection</seealso>
    let FeatureCollection =
        Prefixed_Name(geosparql, "FeatureCollection") |> PrefixedName

    /// <summary>
    ///   <para>ns349:geosparql#Geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"
    ///       The class represents the top-level geometry type. This class is
    ///       equivalent to the UML class GM_Object defined in ISO 19107, and
    ///       it is superclass of all geometry types.
    ///     "</para>
    ///   <para>"The class represents the top-level geometry type. This class is equivalent to the UML class GM_Object defined in ISO 19107, and it is superclass of all geometry types."</para>
    /// labels<para>"Geometry"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#Geometry">http://www.opengis.net/ont/geosparql#Geometry</seealso>
    let Geometry = Prefixed_Name(geosparql, "Geometry") |> PrefixedName

    /// <summary>
    ///   <para>ns349:geosparql#GeometryCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#GeometryCollection">http://www.opengis.net/ont/geosparql#GeometryCollection</seealso>
    let GeometryCollection =
        Prefixed_Name(geosparql, "GeometryCollection") |> PrefixedName

    /// <summary>
    ///   <para>ns349:geosparql#SpatialObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"
    ///       The class spatial-object represents everything that can have
    ///       a spatial representation. It is superclass of feature and geometry.
    ///     "</para>
    ///   <para>"The class spatial-object represents everything that can have a spatial representation. It is superclass of feature and geometry."</para>
    /// labels<para>"SpatialObject"</para><para>"Spatial object"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#SpatialObject">http://www.opengis.net/ont/geosparql#SpatialObject</seealso>
    let SpatialObject = Prefixed_Name(geosparql, "SpatialObject") |> PrefixedName

    /// <summary>
    ///   <para>ns349:geosparql#SpatialObjectCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#SpatialObjectCollection">http://www.opengis.net/ont/geosparql#SpatialObjectCollection</seealso>
    let SpatialObjectCollection =
        Prefixed_Name(geosparql, "SpatialObjectCollection") |> PrefixedName

    /// <summary>
    ///   <para>ns349:geosparql#asDGGS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#asDGGS">http://www.opengis.net/ont/geosparql#asDGGS</seealso>
    let asDGGS = Prefixed_Name(geosparql, "asDGGS") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#asGML</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#asGML">http://www.opengis.net/ont/geosparql#asGML</seealso>
    let asGML = Prefixed_Name(geosparql, "asGML") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#asGeoJSON</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#asGeoJSON">http://www.opengis.net/ont/geosparql#asGeoJSON</seealso>
    let asGeoJSON = Prefixed_Name(geosparql, "asGeoJSON") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#asKML</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#asKML">http://www.opengis.net/ont/geosparql#asKML</seealso>
    let asKML = Prefixed_Name(geosparql, "asKML") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#asWKT</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The WKT serialization of a geometry."</para>
    ///   <para>"
    ///       The WKT serialization of a geometry
    ///     "</para>
    ///   <para>"Well Known Text line string representing the geographical shape of the track"</para>
    ///   <para>"Well Known Text polygonal shape"</para>
    /// labels<para>"as WKT"</para><para>"asWKT"</para><para>"asWKT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#asWKT">http://www.opengis.net/ont/geosparql#asWKT</seealso>
    let asWKT = Prefixed_Name(geosparql, "asWKT") |> PrefixedName

    /// <summary>
    ///   <para>ns349:geosparql#coordinateDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    ///       The number of measurements or axes needed to describe the position of this
    ///       geometry in a coordinate system.
    ///     "</para>
    /// labels<para>"coordinateDimension"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#coordinateDimension">http://www.opengis.net/ont/geosparql#coordinateDimension</seealso>
    let coordinateDimension =
        Prefixed_Name(geosparql, "coordinateDimension") |> PrefixedName

    /// <summary>
    ///   <para>ns349:geosparql#defaultGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///       The default geometry to be used in spatial calculations.
    ///       It is Usually the most detailed geometry.
    ///     "</para>
    /// labels<para>"defaultGeometry"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#defaultGeometry">http://www.opengis.net/ont/geosparql#defaultGeometry</seealso>
    let defaultGeometry = Prefixed_Name(geosparql, "defaultGeometry") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#dggsLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#dggsLiteral">http://www.opengis.net/ont/geosparql#dggsLiteral</seealso>
    let dggsLiteral = Prefixed_Name(geosparql, "dggsLiteral") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    ///       The topological dimension of this geometric object, which
    ///       must be less than or equal to the coordinate dimension.
    ///       In non-homogeneous collections, this will return the largest
    ///       topological dimension of the contained objects.
    ///     "</para>
    /// labels<para>"dimension"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#dimension">http://www.opengis.net/ont/geosparql#dimension</seealso>
    let dimension = Prefixed_Name(geosparql, "dimension") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#ehContains</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject spatially contains the
    ///       object SpatialObject. DE-9IM: T*TFF*FF*
    ///     "</para>
    /// labels<para>"contains"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#ehContains">http://www.opengis.net/ont/geosparql#ehContains</seealso>
    let ehContains = Prefixed_Name(geosparql, "ehContains") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#ehCoveredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject is spatially covered
    ///       by the object SpatialObject. DE-9IM: TFF*TFT**
    ///     "</para>
    /// labels<para>"coveredBy"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#ehCoveredBy">http://www.opengis.net/ont/geosparql#ehCoveredBy</seealso>
    let ehCoveredBy = Prefixed_Name(geosparql, "ehCoveredBy") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#ehCovers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject spatially covers the
    ///       object SpatialObject. DE-9IM: T*TFT*FF*
    ///     "</para>
    /// labels<para>"covers"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#ehCovers">http://www.opengis.net/ont/geosparql#ehCovers</seealso>
    let ehCovers = Prefixed_Name(geosparql, "ehCovers") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#ehDisjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject is spatially disjoint
    ///       from the object SpatialObject. DE-9IM: FF*FF****
    ///     "</para>
    /// labels<para>"disjoint"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#ehDisjoint">http://www.opengis.net/ont/geosparql#ehDisjoint</seealso>
    let ehDisjoint = Prefixed_Name(geosparql, "ehDisjoint") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#ehEquals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject spatially equals the
    ///       object SpatialObject. DE-9IM: TFFFTFFFT
    ///     "</para>
    /// labels<para>"equals"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#ehEquals">http://www.opengis.net/ont/geosparql#ehEquals</seealso>
    let ehEquals = Prefixed_Name(geosparql, "ehEquals") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#ehInside</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject is spatially inside
    ///       the object SpatialObject. DE-9IM: TFF*FFT**
    ///     "</para>
    /// labels<para>"inside"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#ehInside">http://www.opengis.net/ont/geosparql#ehInside</seealso>
    let ehInside = Prefixed_Name(geosparql, "ehInside") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#ehMeet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject spatially meets the
    ///       object SpatialObject.
    ///       DE-9IM: FT******* ^ F**T***** ^ F***T****
    ///     "</para>
    /// labels<para>"meet"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#ehMeet">http://www.opengis.net/ont/geosparql#ehMeet</seealso>
    let ehMeet = Prefixed_Name(geosparql, "ehMeet") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#ehOverlap</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject spatially overlaps the
    ///       object SpatialObject. DE-9IM: T*T***T**
    ///     "</para>
    /// labels<para>"overlap"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#ehOverlap">http://www.opengis.net/ont/geosparql#ehOverlap</seealso>
    let ehOverlap = Prefixed_Name(geosparql, "ehOverlap") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#geoJSONLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#geoJSONLiteral">http://www.opengis.net/ont/geosparql#geoJSONLiteral</seealso>
    let geoJSONLiteral = Prefixed_Name(geosparql, "geoJSONLiteral") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#gmlLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///       A GML serialization of a geometry object.
    ///     "</para>
    /// labels<para>"GML Literal"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#gmlLiteral">http://www.opengis.net/ont/geosparql#gmlLiteral</seealso>
    let gmlLiteral = Prefixed_Name(geosparql, "gmlLiteral") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#hasArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#hasArea">http://www.opengis.net/ont/geosparql#hasArea</seealso>
    let hasArea = Prefixed_Name(geosparql, "hasArea") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#hasBoundingBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#hasBoundingBox">http://www.opengis.net/ont/geosparql#hasBoundingBox</seealso>
    let hasBoundingBox = Prefixed_Name(geosparql, "hasBoundingBox") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#hasCentroid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#hasCentroid">http://www.opengis.net/ont/geosparql#hasCentroid</seealso>
    let hasCentroid = Prefixed_Name(geosparql, "hasCentroid") |> PrefixedName

    /// <summary>
    ///   <para>ns349:geosparql#hasDefaultGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#hasDefaultGeometry">http://www.opengis.net/ont/geosparql#hasDefaultGeometry</seealso>
    let hasDefaultGeometry =
        Prefixed_Name(geosparql, "hasDefaultGeometry") |> PrefixedName

    /// <summary>
    ///   <para>ns349:geosparql#hasGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    ///       A spatial representation for a given feature.
    ///     "</para>
    ///   <para>"A spatial representation for a given feature."</para>
    /// labels<para>"hasGeometry"</para><para>"has geometry"</para><para>"geosparql:hasGeometry"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#hasGeometry">http://www.opengis.net/ont/geosparql#hasGeometry</seealso>
    let hasGeometry = Prefixed_Name(geosparql, "hasGeometry") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#hasLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#hasLength">http://www.opengis.net/ont/geosparql#hasLength</seealso>
    let hasLength = Prefixed_Name(geosparql, "hasLength") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#hasMetricArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#hasMetricArea">http://www.opengis.net/ont/geosparql#hasMetricArea</seealso>
    let hasMetricArea = Prefixed_Name(geosparql, "hasMetricArea") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#hasMetricLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#hasMetricLength">http://www.opengis.net/ont/geosparql#hasMetricLength</seealso>
    let hasMetricLength = Prefixed_Name(geosparql, "hasMetricLength") |> PrefixedName

    /// <summary>
    ///   <para>ns349:geosparql#hasMetricPerimeterLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#hasMetricPerimeterLength">http://www.opengis.net/ont/geosparql#hasMetricPerimeterLength</seealso>
    let hasMetricPerimeterLength =
        Prefixed_Name(geosparql, "hasMetricPerimeterLength") |> PrefixedName

    /// <summary>
    ///   <para>ns349:geosparql#hasMetricSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#hasMetricSize">http://www.opengis.net/ont/geosparql#hasMetricSize</seealso>
    let hasMetricSize = Prefixed_Name(geosparql, "hasMetricSize") |> PrefixedName

    /// <summary>
    ///   <para>ns349:geosparql#hasMetricSpatialAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#hasMetricSpatialAccuracy">http://www.opengis.net/ont/geosparql#hasMetricSpatialAccuracy</seealso>
    let hasMetricSpatialAccuracy =
        Prefixed_Name(geosparql, "hasMetricSpatialAccuracy") |> PrefixedName

    /// <summary>
    ///   <para>ns349:geosparql#hasMetricSpatialResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#hasMetricSpatialResolution">http://www.opengis.net/ont/geosparql#hasMetricSpatialResolution</seealso>
    let hasMetricSpatialResolution =
        Prefixed_Name(geosparql, "hasMetricSpatialResolution") |> PrefixedName

    /// <summary>
    ///   <para>ns349:geosparql#hasMetricVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#hasMetricVolume">http://www.opengis.net/ont/geosparql#hasMetricVolume</seealso>
    let hasMetricVolume = Prefixed_Name(geosparql, "hasMetricVolume") |> PrefixedName

    /// <summary>
    ///   <para>ns349:geosparql#hasPerimeterLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#hasPerimeterLength">http://www.opengis.net/ont/geosparql#hasPerimeterLength</seealso>
    let hasPerimeterLength =
        Prefixed_Name(geosparql, "hasPerimeterLength") |> PrefixedName

    /// <summary>
    ///   <para>ns349:geosparql#hasSerialization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#hasSerialization">http://www.opengis.net/ont/geosparql#hasSerialization</seealso>
    let hasSerialization = Prefixed_Name(geosparql, "hasSerialization") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#hasSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#hasSize">http://www.opengis.net/ont/geosparql#hasSize</seealso>
    let hasSize = Prefixed_Name(geosparql, "hasSize") |> PrefixedName

    /// <summary>
    ///   <para>ns349:geosparql#hasSpatialAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#hasSpatialAccuracy">http://www.opengis.net/ont/geosparql#hasSpatialAccuracy</seealso>
    let hasSpatialAccuracy =
        Prefixed_Name(geosparql, "hasSpatialAccuracy") |> PrefixedName

    /// <summary>
    ///   <para>ns349:geosparql#hasSpatialResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#hasSpatialResolution">http://www.opengis.net/ont/geosparql#hasSpatialResolution</seealso>
    let hasSpatialResolution =
        Prefixed_Name(geosparql, "hasSpatialResolution") |> PrefixedName

    /// <summary>
    ///   <para>ns349:geosparql#hasVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#hasVolume">http://www.opengis.net/ont/geosparql#hasVolume</seealso>
    let hasVolume = Prefixed_Name(geosparql, "hasVolume") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#isEmpty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    ///       (true) if this geometric object is the empty Geometry. If
    ///       true, then this geometric object represents the empty point
    ///       set for the coordinate space.
    ///     "</para>
    /// labels<para>"isEmpty"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#isEmpty">http://www.opengis.net/ont/geosparql#isEmpty</seealso>
    let isEmpty = Prefixed_Name(geosparql, "isEmpty") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#isSimple</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"
    ///       (true) if this geometric object has no anomalous geometric
    ///       points, such as self intersection or self tangency.
    ///     "</para>
    /// labels<para>"isSimple"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#isSimple">http://www.opengis.net/ont/geosparql#isSimple</seealso>
    let isSimple = Prefixed_Name(geosparql, "isSimple") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#kmlLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#kmlLiteral">http://www.opengis.net/ont/geosparql#kmlLiteral</seealso>
    let kmlLiteral = Prefixed_Name(geosparql, "kmlLiteral") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#rcc8dc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject is spatially disjoint
    ///       from the object SpatialObject. DE-9IM: FFTFFTTTT
    ///     "</para>
    /// labels<para>"disconnected"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#rcc8dc">http://www.opengis.net/ont/geosparql#rcc8dc</seealso>
    let rcc8dc = Prefixed_Name(geosparql, "rcc8dc") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#rcc8ec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject spatially meets the
    ///       object SpatialObject. DE-9IM: FFTFTTTTT
    ///     "</para>
    /// labels<para>"externally connected"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#rcc8ec">http://www.opengis.net/ont/geosparql#rcc8ec</seealso>
    let rcc8ec = Prefixed_Name(geosparql, "rcc8ec") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#rcc8eq</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject spatially equals the
    ///       object SpatialObject. DE-9IM: TFFFTFFFT
    ///     "</para>
    /// labels<para>"equals"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#rcc8eq">http://www.opengis.net/ont/geosparql#rcc8eq</seealso>
    let rcc8eq = Prefixed_Name(geosparql, "rcc8eq") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#rcc8ntpp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject is spatially inside
    ///       the object SpatialObject. DE-9IM: TFFTFFTTT
    ///     "</para>
    /// labels<para>"non-tangential proper part"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#rcc8ntpp">http://www.opengis.net/ont/geosparql#rcc8ntpp</seealso>
    let rcc8ntpp = Prefixed_Name(geosparql, "rcc8ntpp") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#rcc8ntppi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject spatially contains the
    ///       object SpatialObject. DE-9IM: TTTFFTFFT
    ///     "</para>
    /// labels<para>"non-tangential proper part inverse"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#rcc8ntppi">http://www.opengis.net/ont/geosparql#rcc8ntppi</seealso>
    let rcc8ntppi = Prefixed_Name(geosparql, "rcc8ntppi") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#rcc8po</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject spatially overlaps the
    ///       object SpatialObject. DE-9IM: TTTTTTTTT
    ///     "</para>
    /// labels<para>"partially overlapping"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#rcc8po">http://www.opengis.net/ont/geosparql#rcc8po</seealso>
    let rcc8po = Prefixed_Name(geosparql, "rcc8po") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#rcc8tpp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject is spatially covered
    ///       by the object SpatialObject. DE-9IM: TFFTTFTTT
    ///     "</para>
    /// labels<para>"tangential proper part"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#rcc8tpp">http://www.opengis.net/ont/geosparql#rcc8tpp</seealso>
    let rcc8tpp = Prefixed_Name(geosparql, "rcc8tpp") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#rcc8tppi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject spatially covers the
    ///       object SpatialObject. DE-9IM: TTTFTTFFT
    ///     "</para>
    /// labels<para>"tangential proper part inverse"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#rcc8tppi">http://www.opengis.net/ont/geosparql#rcc8tppi</seealso>
    let rcc8tppi = Prefixed_Name(geosparql, "rcc8tppi") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#sfContains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Exists if the subject SpatialObject spatially contains the object SpatialObject. DE-9IM: T*****FF*"</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject spatially contains the
    ///       object SpatialObject. DE-9IM: T*****FF*
    ///     "</para>
    ///   <para>"Exists if the subject SpatialObject spatially contains the object SpatialObject."</para>
    /// labels<para>"sfContains"</para><para>"contains"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#sfContains">http://www.opengis.net/ont/geosparql#sfContains</seealso>
    let sfContains = Prefixed_Name(geosparql, "sfContains") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#sfCrosses</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject spatially crosses the
    ///       object SpatialObject. DE-9IM: T*T******
    ///     "</para>
    /// labels<para>"crosses"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#sfCrosses">http://www.opengis.net/ont/geosparql#sfCrosses</seealso>
    let sfCrosses = Prefixed_Name(geosparql, "sfCrosses") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#sfDisjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject is spatially disjoint
    ///       from the object SpatialObject. DE-9IM: FF*FF****
    ///     "</para>
    /// labels<para>"disjoint"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#sfDisjoint">http://www.opengis.net/ont/geosparql#sfDisjoint</seealso>
    let sfDisjoint = Prefixed_Name(geosparql, "sfDisjoint") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#sfEquals</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject spatially equals the
    ///       object SpatialObject. DE-9IM: TFFFTFFFT
    ///     "</para>
    /// labels<para>"equals"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#sfEquals">http://www.opengis.net/ont/geosparql#sfEquals</seealso>
    let sfEquals = Prefixed_Name(geosparql, "sfEquals") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#sfIntersects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject is not spatially disjoint
    ///       from the object SpatialObject.
    ///       DE-9IM: T******** ^ *T******* ^ ***T***** ^ ****T****
    ///     "</para>
    /// labels<para>"intersects"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#sfIntersects">http://www.opengis.net/ont/geosparql#sfIntersects</seealso>
    let sfIntersects = Prefixed_Name(geosparql, "sfIntersects") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#sfOverlaps</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject spatially overlaps the
    ///       object SpatialObject. DE-9IM: T*T***T**
    ///     "</para>
    /// labels<para>"overlaps"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#sfOverlaps">http://www.opengis.net/ont/geosparql#sfOverlaps</seealso>
    let sfOverlaps = Prefixed_Name(geosparql, "sfOverlaps") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#sfTouches</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject spatially touches the
    ///       object SpatialObject.
    ///       DE-9IM: FT******* ^ F**T***** ^ F***T****
    ///     "</para>
    /// labels<para>"touches"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#sfTouches">http://www.opengis.net/ont/geosparql#sfTouches</seealso>
    let sfTouches = Prefixed_Name(geosparql, "sfTouches") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#sfWithin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Exists if the subject SpatialObject is spatially within the object SpatialObject. DE-9IM: T*F**F***"</para>
    ///   <para>"
    ///       Exists if the subject SpatialObject is spatially within the
    ///       object SpatialObject. DE-9IM: T*F**F***
    ///     "</para>
    ///   <para>"Exists if the subject SpatialObject is spatially within the object SpatialObject."</para>
    /// labels<para>"sfWithin"</para><para>"within"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#sfWithin">http://www.opengis.net/ont/geosparql#sfWithin</seealso>
    let sfWithin = Prefixed_Name(geosparql, "sfWithin") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#spatialDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"
    ///       The number of measurements or axes needed to describe the spatial position of
    ///       this geometry in a coordinate system.
    ///     "</para>
    /// labels<para>"spatialDimension"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#spatialDimension">http://www.opengis.net/ont/geosparql#spatialDimension</seealso>
    let spatialDimension = Prefixed_Name(geosparql, "spatialDimension") |> PrefixedName
    /// <summary>
    ///   <para>ns349:geosparql#wktLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"
    ///       A Well-known Text serialization of a geometry object.
    ///     "</para>
    /// labels<para>"Well-known Text Literal"</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/geosparql#wktLiteral">http://www.opengis.net/ont/geosparql#wktLiteral</seealso>
    let wktLiteral = Prefixed_Name(geosparql, "wktLiteral") |> PrefixedName
