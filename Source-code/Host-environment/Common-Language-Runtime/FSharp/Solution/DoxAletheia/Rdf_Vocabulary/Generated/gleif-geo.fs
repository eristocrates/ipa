namespace https.www.gleif.org.ontology.Geocoding.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gleif_geo =
    let _namespace_iri = Namespace_Iri gleif_geo |> NamespaceIRI

    /// <summary>
    ///   <para>gleif-geo:MatchTypeInterpolated</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-geo:MatchType</para>
    ///
    /// labels<para>match type interpolated</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/MatchTypeInterpolated">https://www.gleif.org/ontology/Geocoding/MatchTypeInterpolated</seealso>
    let MatchTypeInterpolated =
        Prefixed_Name(gleif_geo, "MatchTypeInterpolated") |> PrefixedName

    /// <summary>
    ///   <para>gleif-geo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>GLEIF Geocoding Ontology</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/">https://www.gleif.org/ontology/Geocoding/</seealso>
    let _prefix_iri = Prefixed_Name(gleif_geo, "") |> PrefixedName
    /// <summary>
    ///   <para>gleif-geo:topLeft</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>top left</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/topLeft">https://www.gleif.org/ontology/Geocoding/topLeft</seealso>
    let topLeft = Prefixed_Name(gleif_geo, "topLeft") |> PrefixedName
    /// <summary>
    ///   <para>gleif-geo:hasBoundingBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has bounding box</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/hasBoundingBox">https://www.gleif.org/ontology/Geocoding/hasBoundingBox</seealso>
    let hasBoundingBox = Prefixed_Name(gleif_geo, "hasBoundingBox") |> PrefixedName
    /// <summary>
    ///   <para>gleif-geo:hasStreet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has street</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/hasStreet">https://www.gleif.org/ontology/Geocoding/hasStreet</seealso>
    let hasStreet = Prefixed_Name(gleif_geo, "hasStreet") |> PrefixedName
    /// <summary>
    ///   <para>gleif-geo:hasDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has district</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/hasDistrict">https://www.gleif.org/ontology/Geocoding/hasDistrict</seealso>
    let hasDistrict = Prefixed_Name(gleif_geo, "hasDistrict") |> PrefixedName
    /// <summary>
    ///   <para>gleif-geo:matchDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has end</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/matchDate">https://www.gleif.org/ontology/Geocoding/matchDate</seealso>
    let matchDate = Prefixed_Name(gleif_geo, "matchDate") |> PrefixedName
    /// <summary>
    ///   <para>gleif-geo:matchType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>match type</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/matchType">https://www.gleif.org/ontology/Geocoding/matchType</seealso>
    let matchType = Prefixed_Name(gleif_geo, "matchType") |> PrefixedName
    /// <summary>
    ///   <para>gleif-geo:MatchType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>match type</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/MatchType">https://www.gleif.org/ontology/Geocoding/MatchType</seealso>
    let MatchType = Prefixed_Name(gleif_geo, "MatchType") |> PrefixedName

    /// <summary>
    ///   <para>gleif-geo:originalAddressText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>original address text</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/originalAddressText">https://www.gleif.org/ontology/Geocoding/originalAddressText</seealso>
    let originalAddressText =
        Prefixed_Name(gleif_geo, "originalAddressText") |> PrefixedName

    /// <summary>
    ///   <para>gleif-geo:hasGeocodedAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has geocoded address</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/hasGeocodedAddress">https://www.gleif.org/ontology/Geocoding/hasGeocodedAddress</seealso>
    let hasGeocodedAddress =
        Prefixed_Name(gleif_geo, "hasGeocodedAddress") |> PrefixedName

    /// <summary>
    ///   <para>gleif-geo:formattedAddressText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>formatted address text</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/formattedAddressText">https://www.gleif.org/ontology/Geocoding/formattedAddressText</seealso>
    let formattedAddressText =
        Prefixed_Name(gleif_geo, "formattedAddressText") |> PrefixedName

    /// <summary>
    ///   <para>gleif-geo:originalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>original address</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/originalAddress">https://www.gleif.org/ontology/Geocoding/originalAddress</seealso>
    let originalAddress = Prefixed_Name(gleif_geo, "originalAddress") |> PrefixedName
    /// <summary>
    ///   <para>gleif-geo:matchLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>match level</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/matchLevel">https://www.gleif.org/ontology/Geocoding/matchLevel</seealso>
    let matchLevel = Prefixed_Name(gleif_geo, "matchLevel") |> PrefixedName

    /// <summary>
    ///   <para>gleif-geo:MatchTypePointAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-geo:MatchType</para>
    ///
    /// labels<para>match type point address</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/MatchTypePointAddress">https://www.gleif.org/ontology/Geocoding/MatchTypePointAddress</seealso>
    let MatchTypePointAddress =
        Prefixed_Name(gleif_geo, "MatchTypePointAddress") |> PrefixedName

    /// <summary>
    ///   <para>gleif-geo:BoundingBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>bounding box</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/BoundingBox">https://www.gleif.org/ontology/Geocoding/BoundingBox</seealso>
    let BoundingBox = Prefixed_Name(gleif_geo, "BoundingBox") |> PrefixedName
    /// <summary>
    ///   <para>gleif-geo:bottomRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>bottom right</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/bottomRight">https://www.gleif.org/ontology/Geocoding/bottomRight</seealso>
    let bottomRight = Prefixed_Name(gleif_geo, "bottomRight") |> PrefixedName
    /// <summary>
    ///   <para>gleif-geo:GeocodedAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>geocoded address</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/GeocodedAddress">https://www.gleif.org/ontology/Geocoding/GeocodedAddress</seealso>
    let GeocodedAddress = Prefixed_Name(gleif_geo, "GeocodedAddress") |> PrefixedName
    /// <summary>
    ///   <para>gleif-geo:relevance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>bottom right</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/relevance">https://www.gleif.org/ontology/Geocoding/relevance</seealso>
    let relevance = Prefixed_Name(gleif_geo, "relevance") |> PrefixedName
    /// <summary>
    ///   <para>gleif-geo:locationId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>location ID</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/locationId">https://www.gleif.org/ontology/Geocoding/locationId</seealso>
    let locationId = Prefixed_Name(gleif_geo, "locationId") |> PrefixedName
    /// <summary>
    ///   <para>gleif-geo:hasRegionText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has region text</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/Geocoding/hasRegionText">https://www.gleif.org/ontology/Geocoding/hasRegionText</seealso>
    let hasRegionText = Prefixed_Name(gleif_geo, "hasRegionText") |> PrefixedName
