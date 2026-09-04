#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``gleif-geo`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.gleif.org/ontology/Geocoding/" "gleif-geo"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:definition : A geographic rectangular area bounded by its top left and bottom right points.^^xsd:string</para>
    ///   <para>rdfs:label : bounding box^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Geocoding/BoundingBox">gleif-geo:BoundingBox</a>
    /// </summary>
    let BoundingBox = _prefixId.prefix "BoundingBox"
    /// <summary>
    ///   <para>skos:definition : A geocoded address, derived from a physical address, with latitude and longitude information.^^xsd:string</para>
    ///   <para>rdfs:label : geocoded address</para>
    ///   <a href="https://www.gleif.org/ontology/Geocoding/GeocodedAddress">gleif-geo:GeocodedAddress</a>
    /// </summary>
    let GeocodedAddress = _prefixId.prefix "GeocodedAddress"
    /// <summary>
    ///   <para>skos:definition : Quality of the location match, either pointAddress or interpolated.^^xsd:string</para>
    ///   <para>rdfs:label : match type^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Geocoding/MatchType">gleif-geo:MatchType</a>
    /// </summary>
    let MatchType = _prefixId.prefix "MatchType"
    let MatchTypeInterpolated = _prefixId.prefix "MatchTypeInterpolated"
    let MatchTypePointAddress = _prefixId.prefix "MatchTypePointAddress"
    /// <summary>
    ///   <para>skos:definition : The bottom right point of a bounding box.^^xsd:string</para>
    ///   <para>rdfs:label : bottom right^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Geocoding/bottomRight">gleif-geo:bottomRight</a>
    /// </summary>
    let bottomRight = _prefixId.prefix "bottomRight"
    /// <summary>
    ///   <para>skos:definition : An aggregated textual representation of the the fields produced by the geocoding as a comma-separated list of fields.^^xsd:string</para>
    ///   <para>rdfs:label : formatted address text^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Geocoding/formattedAddressText">gleif-geo:formattedAddressText</a>
    /// </summary>
    let formattedAddressText = _prefixId.prefix "formattedAddressText"
    /// <summary>
    ///   <para>skos:definition : The geographic area represented by the address.^^xsd:string</para>
    ///   <para>rdfs:label : has bounding box^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Geocoding/hasBoundingBox">gleif-geo:hasBoundingBox</a>
    /// </summary>
    let hasBoundingBox = _prefixId.prefix "hasBoundingBox"
    /// <summary>
    ///   <para>skos:definition : A textual representation of the district.^^xsd:string</para>
    ///   <para>rdfs:label : has district^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Geocoding/hasDistrict">gleif-geo:hasDistrict</a>
    /// </summary>
    let hasDistrict = _prefixId.prefix "hasDistrict"
    /// <summary>
    ///   <para>skos:definition : A geocoded address for the legal entity.^^xsd:string</para>
    ///   <para>rdfs:label : has geocoded address^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Geocoding/hasGeocodedAddress">gleif-geo:hasGeocodedAddress</a>
    /// </summary>
    let hasGeocodedAddress = _prefixId.prefix "hasGeocodedAddress"
    /// <summary>
    ///   <para>skos:prefLabel : has region text^^xsd:string</para>
    ///   <para>skos:definition : A textual representation of the state or region.^^xsd:string</para>
    ///   <para>skos:altLabel : has state text^^xsd:string</para>
    ///   <para>rdfs:label : has region text^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Geocoding/hasRegionText">gleif-geo:hasRegionText</a>
    /// </summary>
    let hasRegionText = _prefixId.prefix "hasRegionText"
    /// <summary>
    ///   <para>skos:definition : The name of a street, as opposed to a house within it.^^xsd:string</para>
    ///   <para>rdfs:label : has street^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Geocoding/hasStreet">gleif-geo:hasStreet</a>
    /// </summary>
    let hasStreet = _prefixId.prefix "hasStreet"
    /// <summary>
    ///   <para>skos:definition : A unique identifier representing a hash of the location.^^xsd:string</para>
    ///   <para>rdfs:label : location ID^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Geocoding/locationId">gleif-geo:locationId</a>
    /// </summary>
    let locationId = _prefixId.prefix "locationId"
    /// <summary>
    ///   <para>skos:definition : The date of the geocoding from the original address.^^xsd:string</para>
    ///   <para>rdfs:label : has end</para>
    ///   <a href="https://www.gleif.org/ontology/Geocoding/matchDate">gleif-geo:matchDate</a>
    /// </summary>
    let matchDate = _prefixId.prefix "matchDate"
    /// <summary>
    ///   <para>skos:definition : The most detailed address field that the geocoding was able to provide.^^xsd:string</para>
    ///   <para>rdfs:label : match level^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Geocoding/matchLevel">gleif-geo:matchLevel</a>
    /// </summary>
    let matchLevel = _prefixId.prefix "matchLevel"
    /// <summary>
    ///   <para>skos:definition : Quality of the location match, either pointAddress or interpolated.^^xsd:string</para>
    ///   <para>rdfs:label : match type^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Geocoding/matchType">gleif-geo:matchType</a>
    /// </summary>
    let matchType = _prefixId.prefix "matchType"
    /// <summary>
    ///   <para>skos:definition : The original address(es) from which the geocoding was derived.^^xsd:string</para>
    ///   <para>rdfs:label : original address^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Geocoding/originalAddress">gleif-geo:originalAddress</a>
    /// </summary>
    let originalAddress = _prefixId.prefix "originalAddress"
    /// <summary>
    ///   <para>skos:definition : An aggregated textual representation of the original address(es) from which the geocoding was derived, as a comma-separated list of fields with null where the field did not have a value.^^xsd:string</para>
    ///   <para>rdfs:label : original address text^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Geocoding/originalAddressText">gleif-geo:originalAddressText</a>
    /// </summary>
    let originalAddressText = _prefixId.prefix "originalAddressText"
    /// <summary>
    ///   <para>skos:definition : A value from 0 to 1 representing the percentage of the input that matched the returned address. 1 means that all input tokens were matched.^^xsd:string</para>
    ///   <para>rdfs:label : bottom right^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Geocoding/relevance">gleif-geo:relevance</a>
    /// </summary>
    let relevance = _prefixId.prefix "relevance"
    /// <summary>
    ///   <para>skos:definition : The top left point of a bounding box.^^xsd:string</para>
    ///   <para>rdfs:label : top left^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Geocoding/topLeft">gleif-geo:topLeft</a>
    /// </summary>
    let topLeft = _prefixId.prefix "topLeft"
