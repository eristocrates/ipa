namespace https.www.gleif.org.ontology.Geocoding.slash

open DoxAletheia.Rdf_Vocabulary

module gleif_geo =
    let _namespace_name = "https://www.gleif.org/ontology/Geocoding/"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/MatchTypePointAddress"></see>
    /// </summary>
    let MatchTypePointAddress =
        Namespaced_IRI.parse _namespace_name "MatchTypePointAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/MatchTypeInterpolated"></see>
    /// </summary>
    let MatchTypeInterpolated =
        Namespaced_IRI.parse _namespace_name "MatchTypeInterpolated" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/BoundingBox"></see>
    /// </summary>
    let BoundingBox =
        Namespaced_IRI.parse _namespace_name "BoundingBox" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/topLeft"></see>
    /// </summary>
    let topLeft = Namespaced_IRI.parse _namespace_name "topLeft" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/bottomRight"></see>
    /// </summary>
    let bottomRight =
        Namespaced_IRI.parse _namespace_name "bottomRight" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/GeocodedAddress"></see>
    /// </summary>
    let GeocodedAddress =
        Namespaced_IRI.parse _namespace_name "GeocodedAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/relevance"></see>
    /// </summary>
    let relevance = Namespaced_IRI.parse _namespace_name "relevance" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/hasBoundingBox"></see>
    /// </summary>
    let hasBoundingBox =
        Namespaced_IRI.parse _namespace_name "hasBoundingBox" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/hasStreet"></see>
    /// </summary>
    let hasStreet = Namespaced_IRI.parse _namespace_name "hasStreet" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/hasDistrict"></see>
    /// </summary>
    let hasDistrict =
        Namespaced_IRI.parse _namespace_name "hasDistrict" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/matchDate"></see>
    /// </summary>
    let matchDate = Namespaced_IRI.parse _namespace_name "matchDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/formattedAddressText"></see>
    /// </summary>
    let formattedAddressText =
        Namespaced_IRI.parse _namespace_name "formattedAddressText" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/matchType"></see>
    /// </summary>
    let matchType = Namespaced_IRI.parse _namespace_name "matchType" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/MatchType"></see>
    /// </summary>
    let MatchType = Namespaced_IRI.parse _namespace_name "MatchType" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/locationId"></see>
    /// </summary>
    let locationId = Namespaced_IRI.parse _namespace_name "locationId" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/hasRegionText"></see>
    /// </summary>
    let hasRegionText =
        Namespaced_IRI.parse _namespace_name "hasRegionText" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/originalAddress"></see>
    /// </summary>
    let originalAddress =
        Namespaced_IRI.parse _namespace_name "originalAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/originalAddressText"></see>
    /// </summary>
    let originalAddressText =
        Namespaced_IRI.parse _namespace_name "originalAddressText" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/hasGeocodedAddress"></see>
    /// </summary>
    let hasGeocodedAddress =
        Namespaced_IRI.parse _namespace_name "hasGeocodedAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/Geocoding/matchLevel"></see>
    /// </summary>
    let matchLevel = Namespaced_IRI.parse _namespace_name "matchLevel" |> NamespacedName
