#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-loc`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/Locations/" "cmns-loc"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : business center^^xsd:string</para>
    ///   <para>skos:definition : municipality where business is conducted, especially one that is considered a financial center^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : FpML Business Center and related codes, see http://www.fpml.org/coding-scheme/business-center-7-14.xml^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/BusinessCenter">cmns-loc:BusinessCenter</a>
    /// </summary>
    let BusinessCenter = _prefixId.prefix "BusinessCenter"
    /// <summary>
    ///   <para>rdfs:label : country^^xsd:string</para>
    ///   <para>skos:definition : geopolitical entity representing a distinct territorial body or political entity or dependent territory^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : It may be an independent sovereign state or part of a larger state, as a non-sovereign or formerly sovereign political division, a physical territory with a government, or a geographic region associated with sets of previously independent or differently associated peoples with distinct political characteristics.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/Country">cmns-loc:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>rdfs:label : country subdivision^^xsd:string</para>
    ///   <para>skos:definition : geopolitical entity that is a legal division of a country, dependency, or other area of special geopolitical interest related to a country or other geopolitical entity^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In the US, the US Census Bureau and other federal agencies may group some number of other subdivisions for statistical analysis and reporting purposes, ranging from multiple states to minor civil divisions.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/CountrySubdivision">cmns-loc:CountrySubdivision</a>
    /// </summary>
    let CountrySubdivision = _prefixId.prefix "CountrySubdivision"
    /// <summary>
    ///   <para>rdfs:label : county^^xsd:string</para>
    ///   <para>skos:definition : political and administrative division of a country, state or province, providing certain local governmental services^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/County">cmns-loc:County</a>
    /// </summary>
    let County = _prefixId.prefix "County"
    /// <summary>
    ///   <para>rdfs:label : federal capital area^^xsd:string</para>
    ///   <para>skos:definition : country subdivision that is or includes the municipality or capital city that acts as the seat of the federal government^^xsd:string</para>
    ///   <para>skos:example : Examples include the District of Columbia in the US, and the Canberra area in Australia.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The capital administrative region of some federations includes those for which the capital is situated other than within one of the states or provinces which make up the country as a whole.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/FederalCapitalArea">cmns-loc:FederalCapitalArea</a>
    /// </summary>
    let FederalCapitalArea = _prefixId.prefix "FederalCapitalArea"
    /// <summary>
    ///   <para>rdfs:label : federal state^^xsd:string</para>
    ///   <para>skos:definition : self-governing geopolitical unit which forms part of a wider geopolitical unit that is recognized as a country^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This type of entity, variously referred to as a state, province or canton, has a level of self government including its own legal system and court jurisdiction, but cedes a level of autonomy to the federation of which it forms a part.^^xsd:string</para>
    ///   <para>cmns-av:synonym : canton^^xsd:stringcmns-av:synonym : province^^xsd:stringcmns-av:synonym : state^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/FederalState">cmns-loc:FederalState</a>
    /// </summary>
    let FederalState = _prefixId.prefix "FederalState"
    /// <summary>
    ///   <para>rdfs:label : geodetic coordinate system^^xsd:string</para>
    ///   <para>skos:definition : three-dimensional reference system that is a global frame of reference for precisely representing the position of locations on Earth or other planetary bodies by means of geodetic coordinates^^xsd:string</para>
    ///   <para>skos:example : The three most widely used systems for indicating point locations in the United States are (1) latitude and longitude [and optionally elevation], (2) Universal Transverse Mercator (UTM) system, and (3) State Plane Coordinate Systems (SPCS).^^xsd:string</para>
    ///   <para>skos:note : The unit of measure is usually decimal degrees. A point has two coordinate values, latitude and longitude. Latitude and longitude measure angles.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Geodetic coordinates are crucial to any technology or technique based on spatial location, including geodesy, navigation, surveying, geographic information systems, remote sensing, and cartography.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/GeodeticCoordinateSystem">cmns-loc:GeodeticCoordinateSystem</a>
    /// </summary>
    let GeodeticCoordinateSystem = _prefixId.prefix "GeodeticCoordinateSystem"
    /// <summary>
    ///   <para>rdfs:label : geographic region^^xsd:string</para>
    ///   <para>skos:definition : area of land that has common features^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A region may be defined by natural or artificial features, and may be described as part of a country or the world having definable characteristics but not always fixed boundaries.^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Many cases in which a geographic region, or subclass thereof, is mapped to certain applications or a relational store, or where codes are used to identify the region, require a class to represent the name of the region. In such situations, attributes of the name, such as the dates when a particular name was in use, or was valid under certain circumstances, may be important. For other applications, such as for addressing, a text value may be required. Thus, both options are provided here, with a preference for use of the full class option, depending on the use case.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/GeographicRegion">cmns-loc:GeographicRegion</a>
    /// </summary>
    let GeographicRegion = _prefixId.prefix "GeographicRegion"

    /// <summary>
    ///   <para>rdfs:label : geographic region identification scheme^^xsd:string</para>
    ///   <para>skos:definition : identification scheme dedicated to the unique identification of geographic regions^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/GeographicRegionIdentificationScheme">cmns-loc:GeographicRegionIdentificationScheme</a>
    /// </summary>
    let GeographicRegionIdentificationScheme =
        _prefixId.prefix "GeographicRegionIdentificationScheme"

    /// <summary>
    ///   <para>rdfs:label : geographic region identifier^^xsd:string</para>
    ///   <para>skos:definition : string of letters that indicates a code or other identifier for geographical region, assigned for the purpose of uniquely identifying it within some context^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/GeographicRegionIdentifier">cmns-loc:GeographicRegionIdentifier</a>
    /// </summary>
    let GeographicRegionIdentifier = _prefixId.prefix "GeographicRegionIdentifier"
    /// <summary>
    ///   <para>rdfs:label : geographic region kind^^xsd:string</para>
    ///   <para>skos:definition : classifier for a geographic region, including but not limited to a subdivision of a geopolitical entity, (noting that there may be more than one kind for a given country or other entity)^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/GeographicRegionKind">cmns-loc:GeographicRegionKind</a>
    /// </summary>
    let GeographicRegionKind = _prefixId.prefix "GeographicRegionKind"
    /// <summary>
    ///   <para>rdfs:label : geopolitical entity^^xsd:string</para>
    ///   <para>skos:definition : geographic area that represents a geophysical location associated with some form of political structure^^xsd:string</para>
    ///   <para>skos:example : A geopolitical entity may be any country, federal province, city or other administrative unit that represents a geophysical location^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/GeopoliticalEntity">cmns-loc:GeopoliticalEntity</a>
    /// </summary>
    let GeopoliticalEntity = _prefixId.prefix "GeopoliticalEntity"
    /// <summary>
    ///   <para>rdfs:label : location^^xsd:string</para>
    ///   <para>skos:definition : place or position in time and/or space, including a virtual place^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/Location">cmns-loc:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:label : municipality^^xsd:string</para>
    ///   <para>skos:definition : urban administrative division having corporate status and usually powers of self-government or jurisdiction^^xsd:string</para>
    ///   <para>skos:example : A municipality can be any political jurisdiction from a sovereign state, such as the Principality of Monaco, or a small village, such as West Hampton Dunes, New York.^^xsd:string</para>
    ///   <para>skos:scopeNote : The territory over which a municipality has jurisdiction may encompass:
    /// - only one populated place such as a city, town, or village
    /// - several of such places (e.g., early jurisdictions in the state of New Jersey (1798-1899) as townships governing several villages, Municipalities of Mexico)
    /// - only parts of such places, sometimes boroughs of a city such as the 34 municipalities of Santiago, Chile.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A municipality is a general-purpose administrative subdivision, as opposed to a special-purpose district.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/Municipality">cmns-loc:Municipality</a>
    /// </summary>
    let Municipality = _prefixId.prefix "Municipality"
    /// <summary>
    ///   <para>rdfs:label : physical location^^xsd:string</para>
    ///   <para>skos:definition : location in physical space^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/PhysicalLocation">cmns-loc:PhysicalLocation</a>
    /// </summary>
    let PhysicalLocation = _prefixId.prefix "PhysicalLocation"
    /// <summary>
    ///   <para>rdfs:label : region^^xsd:string</para>
    ///   <para>skos:definition : area that is a continuous part of a surface, space, or body^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/Region">cmns-loc:Region</a>
    /// </summary>
    let Region = _prefixId.prefix "Region"
    /// <summary>
    ///   <para>rdfs:label : territory^^xsd:string</para>
    ///   <para>skos:definition : geographic area, typically considered an area of special geopolitical interest, subject to the sovereignty, control, or jurisdiction of a state or other entity^^xsd:string</para>
    ///   <para>skos:note : Certain territories are included in the ISO 3166-2 code set without an alpha 2 or alpha 3 code. In these cases, the numeric code for the subregion may have more than 3 characters in their corresponding numeric region codes.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/Territory">cmns-loc:Territory</a>
    /// </summary>
    let Territory = _prefixId.prefix "Territory"
    /// <summary>
    ///   <para>rdfs:label : virtual location^^xsd:string</para>
    ///   <para>skos:definition : place that does not exist in any single physical location^^xsd:string</para>
    ///   <para>skos:example : a network-based location without geographic boundaries^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/VirtualLocation">cmns-loc:VirtualLocation</a>
    /// </summary>
    let VirtualLocation = _prefixId.prefix "VirtualLocation"
    /// <summary>
    ///   <para>rdfs:label : has altitude^^xsd:string</para>
    ///   <para>skos:definition : the height or vertical elevation of a point above a reference surface^^xsd:string</para>
    ///   <para>skos:note : Altitude measurements are usually based on a given reference datum, such as mean sea level.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/hasAltitude">cmns-loc:hasAltitude</a>
    /// </summary>
    let hasAltitude = _prefixId.prefix "hasAltitude"
    /// <summary>
    ///   <para>rdfs:label : has business center^^xsd:string</para>
    ///   <para>skos:definition : identifies a location where business is conducted, and hence the business calendar used to adjust dates^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/hasBusinessCenter">cmns-loc:hasBusinessCenter</a>
    /// </summary>
    let hasBusinessCenter = _prefixId.prefix "hasBusinessCenter"
    /// <summary>
    ///   <para>rdfs:label : has city name^^xsd:string</para>
    ///   <para>skos:definition : indicates the name of a typically large, permanent, and densely settled place^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://en.wikipedia.org/wiki/City^^xsd:anyURIcmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/current-versions/level-1-data-lei-cdf-3-1-format^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Typical working definitions for small-city populations start at around 100,000 people. Common population definitions for an urban area (city or town) range between 1,500 and 50,000 people, with most U.S states using a minimum between 1,500 and 5,000 inhabitants. Some jurisdictions set no such minima.^^xsd:string</para>
    ///   <para>cmns-av:usageNote : This property should be used in cases where a formal individual for the business center or municipality is not available. Note that Geonames could be used as a source in cases where an individual is desired. Use the property cmns-loc;hasMunicipality in cases where an individual is available. Also note that with respect to an address, this property may stand in for any village, town, or city of any size.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/hasCityName">cmns-loc:hasCityName</a>
    /// </summary>
    let hasCityName = _prefixId.prefix "hasCityName"
    /// <summary>
    ///   <para>rdfs:label : has country^^xsd:string</para>
    ///   <para>skos:definition : indicates a country, such as one that is recognized by the United Nations^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/current-versions/level-1-data-lei-cdf-3-1-format^^xsd:anyURI</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/hasCountry">cmns-loc:hasCountry</a>
    /// </summary>
    let hasCountry = _prefixId.prefix "hasCountry"
    /// <summary>
    ///   <para>rdfs:label : has county^^xsd:string</para>
    ///   <para>skos:definition : indicates a country subdivision providing certain local governmental services^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/hasCounty">cmns-loc:hasCounty</a>
    /// </summary>
    let hasCounty = _prefixId.prefix "hasCounty"
    /// <summary>
    ///   <para>rdfs:label : has coverage area^^xsd:string</para>
    ///   <para>skos:definition : indicates a geographic region in which some service is provided, or to which some policy applies, or in which something is available^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/hasCoverageArea">cmns-loc:hasCoverageArea</a>
    /// </summary>
    let hasCoverageArea = _prefixId.prefix "hasCoverageArea"
    /// <summary>
    ///   <para>rdfs:label : has latitude^^xsd:string</para>
    ///   <para>skos:definition : the angle formed by the intersection of a line perpendicular to the Earth's (or other celestial body's) surface at a point and the plane of the Equator^^xsd:string</para>
    ///   <para>skos:note : Points north of the Equator have positive latitude values, while points south have negative values. Latitude values range from minus 90 to plus 90 degrees. Lines of latitude are also called parallels because a particular value of latitude forms a circle parallel to the Equator.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/hasLatitude">cmns-loc:hasLatitude</a>
    /// </summary>
    let hasLatitude = _prefixId.prefix "hasLatitude"
    /// <summary>
    ///   <para>rdfs:label : has location^^xsd:string</para>
    ///   <para>skos:definition : relates something to a location, which might be physical or virtual^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/hasLocation">cmns-loc:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    /// <summary>
    ///   <para>rdfs:label : has longitude^^xsd:string</para>
    ///   <para>skos:definition : the angle between a plane that passes through the point and the North and South poles, and a reference plane^^xsd:string</para>
    ///   <para>skos:note : The reference plane is known as the prime meridian. The most common prime meridian passes through Greenwich, United Kingdom. Other examples of prime meridians in use pass through Paris and Bogota. Longitude values range from minus 180 to plus 180 degrees.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/hasLongitude">cmns-loc:hasLongitude</a>
    /// </summary>
    let hasLongitude = _prefixId.prefix "hasLongitude"
    /// <summary>
    ///   <para>rdfs:label : has maximum latitude^^xsd:string</para>
    ///   <para>skos:definition : indicates the highest value / maximum for latitude with respect to a range^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/hasMaximumLatitude">cmns-loc:hasMaximumLatitude</a>
    /// </summary>
    let hasMaximumLatitude = _prefixId.prefix "hasMaximumLatitude"
    /// <summary>
    ///   <para>rdfs:label : has maximum longitude^^xsd:string</para>
    ///   <para>skos:definition : indicates the highest value / maximum for longitude with respect to a range^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/hasMaximumLongitude">cmns-loc:hasMaximumLongitude</a>
    /// </summary>
    let hasMaximumLongitude = _prefixId.prefix "hasMaximumLongitude"
    /// <summary>
    ///   <para>rdfs:label : has minimum latitude^^xsd:string</para>
    ///   <para>skos:definition : indicates the lowest value / latitude with respect to a range^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/hasMinimumLatitude">cmns-loc:hasMinimumLatitude</a>
    /// </summary>
    let hasMinimumLatitude = _prefixId.prefix "hasMinimumLatitude"
    /// <summary>
    ///   <para>rdfs:label : has minimum longitude^^xsd:string</para>
    ///   <para>skos:definition : indicates the lowest value / longitude with respect to a range^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/hasMinimumLongitude">cmns-loc:hasMinimumLongitude</a>
    /// </summary>
    let hasMinimumLongitude = _prefixId.prefix "hasMinimumLongitude"
    /// <summary>
    ///   <para>rdfs:label : has municipality^^xsd:string</para>
    ///   <para>skos:definition : indicates a business center, city, or municipality^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Note that certain greater metropolitan areas span multiple counties or states (e.g., the greater Washington, D.C. area, which includes parts of Maryland and Virginia, and divided/disputed cities such as Jerusalem), thus hasMunicipality is a subproperty of hasRegion rather than hasSubdivision.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/hasMunicipality">cmns-loc:hasMunicipality</a>
    /// </summary>
    let hasMunicipality = _prefixId.prefix "hasMunicipality"
    /// <summary>
    ///   <para>rdfs:label : has primary subdivision^^xsd:string</para>
    ///   <para>skos:definition : identifies the most immediate and main subdivision of a country, such as a state or province^^xsd:string</para>
    ///   <para>cmns-av:usageNote : This property is intended for use when using RDF entailment or other inferencing to query for only the primary subdivisions of a geopolitical entity and eliminate references to smaller subdivisions, such as counties, from being returned in results, if present in the data set.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/hasPrimarySubdivision">cmns-loc:hasPrimarySubdivision</a>
    /// </summary>
    let hasPrimarySubdivision = _prefixId.prefix "hasPrimarySubdivision"
    /// <summary>
    ///   <para>rdfs:label : has region^^xsd:string</para>
    ///   <para>skos:definition : indicates a demarcated area on the surface of the Earth^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/hasRegion">cmns-loc:hasRegion</a>
    /// </summary>
    let hasRegion = _prefixId.prefix "hasRegion"
    /// <summary>
    ///   <para>rdfs:label : has subdivision^^xsd:string</para>
    ///   <para>skos:definition : identifies a country subdivision (state, province, region, etc.)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.gleif.org/en/about-lei/common-data-file-format/current-versions/level-1-data-lei-cdf-3-1-format^^xsd:anyURI</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/hasSubdivision">cmns-loc:hasSubdivision</a>
    /// </summary>
    let hasSubdivision = _prefixId.prefix "hasSubdivision"
    /// <summary>
    ///   <para>rdfs:label : has subregion^^xsd:string</para>
    ///   <para>skos:definition : relates a geographic region to another geographic region that is a designated subregion of it^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/hasSubregion">cmns-loc:hasSubregion</a>
    /// </summary>
    let hasSubregion = _prefixId.prefix "hasSubregion"
    /// <summary>
    ///   <para>rdfs:label : is independent^^xsd:string</para>
    ///   <para>skos:definition : indicates whether a geopolitical entity stands alone or is considered part of another geopolitical entity (e.g., a country)^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/isIndependent">cmns-loc:isIndependent</a>
    /// </summary>
    let isIndependent = _prefixId.prefix "isIndependent"
    /// <summary>
    ///   <para>rdfs:label : is subregion of^^xsd:string</para>
    ///   <para>skos:definition : relates a geographic region to another geographic region that it is a part of^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Locations/isSubregionOf">cmns-loc:isSubregionOf</a>
    /// </summary>
    let isSubregionOf = _prefixId.prefix "isSubregionOf"
