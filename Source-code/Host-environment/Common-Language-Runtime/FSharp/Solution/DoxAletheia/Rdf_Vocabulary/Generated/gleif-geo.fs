namespace https.www.gleif.org.ontology.Geocoding.slash

open DoxAletheia

module gleif_geo =
    let _namespace_name = "https://www.gleif.org/ontology/Geocoding/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/MatchTypePointAddress"></see>
    /// </summary>
    let MatchTypePointAddress = _prefix "MatchTypePointAddress"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/MatchTypeInterpolated"></see>
    /// </summary>
    let MatchTypeInterpolated = _prefix "MatchTypeInterpolated"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/BoundingBox"></see>
    /// </summary>
    let BoundingBox = _prefix "BoundingBox"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/topLeft"></see>
    /// </summary>
    let topLeft = _prefix "topLeft"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/bottomRight"></see>
    /// </summary>
    let bottomRight = _prefix "bottomRight"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/GeocodedAddress"></see>
    /// </summary>
    let GeocodedAddress = _prefix "GeocodedAddress"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/relevance"></see>
    /// </summary>
    let relevance = _prefix "relevance"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/hasBoundingBox"></see>
    /// </summary>
    let hasBoundingBox = _prefix "hasBoundingBox"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/hasStreet"></see>
    /// </summary>
    let hasStreet = _prefix "hasStreet"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/hasDistrict"></see>
    /// </summary>
    let hasDistrict = _prefix "hasDistrict"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/matchDate"></see>
    /// </summary>
    let matchDate = _prefix "matchDate"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/formattedAddressText"></see>
    /// </summary>
    let formattedAddressText = _prefix "formattedAddressText"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/matchType"></see>
    /// </summary>
    let matchType = _prefix "matchType"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/MatchType"></see>
    /// </summary>
    let MatchType = _prefix "MatchType"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/locationId"></see>
    /// </summary>
    let locationId = _prefix "locationId"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/hasRegionText"></see>
    /// </summary>
    let hasRegionText = _prefix "hasRegionText"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/originalAddress"></see>
    /// </summary>
    let originalAddress = _prefix "originalAddress"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/originalAddressText"></see>
    /// </summary>
    let originalAddressText = _prefix "originalAddressText"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/hasGeocodedAddress"></see>
    /// </summary>
    let hasGeocodedAddress = _prefix "hasGeocodedAddress"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/matchLevel"></see>
    /// </summary>
    let matchLevel = _prefix "matchLevel"
