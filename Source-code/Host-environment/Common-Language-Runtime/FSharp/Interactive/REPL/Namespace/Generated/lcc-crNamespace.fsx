#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``lcc-cr`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/LCC/Countries/CountryRepresentation/" "lcc-cr"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : alpha-2 code^^xsd:string</para>
    ///   <para>skos:definition : a digraph representing a country or geographic region^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/Alpha2Code">lcc-cr:Alpha2Code</a>
    /// </summary>
    let Alpha2Code = _prefixId.prefix "Alpha2Code"
    /// <summary>
    ///   <para>rdfs:label : alpha-3 code^^xsd:string</para>
    ///   <para>skos:definition : a trigraph representing a country or geographic region^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/Alpha3Code">lcc-cr:Alpha3Code</a>
    /// </summary>
    let Alpha3Code = _prefixId.prefix "Alpha3Code"
    /// <summary>
    ///   <para>rdfs:label : coordinate system^^xsd:string</para>
    ///   <para>skos:definition : a system that uses one or more numbers, or coordinates, to uniquely determine the position of a point or other geometric element on a planar or spherical surface^^xsd:string</para>
    ///   <para>skos:note : Without a concise definition of the coordinate system used to represent a point, it is difficult to change to a new coordinate system. Changing coordinate systems is required when integrating data from different sources into a common coordinate system.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/CoordinateSystem">lcc-cr:CoordinateSystem</a>
    /// </summary>
    let CoordinateSystem = _prefixId.prefix "CoordinateSystem"
    /// <summary>
    ///   <para>rdfs:label : country^^xsd:string</para>
    ///   <para>skos:definition : a geopolitical entity representing a country or dependent territory^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/Country">lcc-cr:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>rdfs:label : country subdivision^^xsd:string</para>
    ///   <para>skos:definition : a geopolitical entity, typically a division of a country, dependency, or other area of special geopolitical interest related to a country or other geopolitical entity^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/CountrySubdivision">lcc-cr:CountrySubdivision</a>
    /// </summary>
    let CountrySubdivision = _prefixId.prefix "CountrySubdivision"
    /// <summary>
    ///   <para>rdfs:label : geographic coordinate system^^xsd:string</para>
    ///   <para>skos:definition : a three-dimensional reference system that locates points on the Earth's surface^^xsd:string</para>
    ///   <para>skos:example : The three most widely used systems for indicating point locations in the United States are (1) latitude and longitude [and optionally elevation], (2) Universal Transverse Mercator (UTM) system, and (3) State Plane Coordinate Systems (SPCS).^^xsd:string</para>
    ///   <para>skos:note : The unit of measure is usually decimal degrees. A point has two coordinate values, latitude and longitude. Latitude and longitude measure angles.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/GeographicCoordinateSystem">lcc-cr:GeographicCoordinateSystem</a>
    /// </summary>
    let GeographicCoordinateSystem = _prefixId.prefix "GeographicCoordinateSystem"
    /// <summary>
    ///   <para>rdfs:label : geographic region^^xsd:string</para>
    ///   <para>skos:definition : an area, especially part of a country or the world having definable characteristics but not always fixed boundaries^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/GeographicRegion">lcc-cr:GeographicRegion</a>
    /// </summary>
    let GeographicRegion = _prefixId.prefix "GeographicRegion"
    /// <summary>
    ///   <para>rdfs:label : geographic region identifier^^xsd:string</para>
    ///   <para>skos:definition : a string of letters assigned to a country or other geographic region for the purpose of uniquely representing it^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/GeographicRegionIdentifier">lcc-cr:GeographicRegionIdentifier</a>
    /// </summary>
    let GeographicRegionIdentifier = _prefixId.prefix "GeographicRegionIdentifier"
    /// <summary>
    ///   <para>rdfs:label : kind of geographic region^^xsd:string</para>
    ///   <para>skos:definition : a classification scheme for geographic regions, including but not limited to subdivisions of a geopolitical entity, (noting that there may be more than one kind for a given country or other entity)^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/GeographicRegionKind">lcc-cr:GeographicRegionKind</a>
    /// </summary>
    let GeographicRegionKind = _prefixId.prefix "GeographicRegionKind"
    /// <summary>
    ///   <para>rdfs:label : geopolitical entity^^xsd:string</para>
    ///   <para>skos:definition : any country, federal province, city or other administrative unit that represents a geophysical location and has some political identity^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/GeopoliticalEntity">lcc-cr:GeopoliticalEntity</a>
    /// </summary>
    let GeopoliticalEntity = _prefixId.prefix "GeopoliticalEntity"
    /// <summary>
    ///   <para>rdfs:label : location^^xsd:string</para>
    ///   <para>skos:definition : a place or position in time and/or space, including virtual place^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/Location">lcc-cr:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:label : territory^^xsd:string</para>
    ///   <para>skos:definition : a geopolitical entity, typically considered an area of special geopolitical interest, related to a country or other geopolitical entity^^xsd:string</para>
    ///   <para>skos:note : Certain territories are included in the ISO 3166-2 code set without an alpha 2 or alpha 3 code.  In these cases, the numeric code for the subregion may have more than 3 characters in their corresponding numeric region codes.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/Territory">lcc-cr:Territory</a>
    /// </summary>
    let Territory = _prefixId.prefix "Territory"
    /// <summary>
    ///   <para>rdfs:label : classifies^^xsd:string</para>
    ///   <para>skos:definition : arranges in categories according to shared characteristics^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/classifies">lcc-cr:classifies</a>
    /// </summary>
    let classifies = _prefixId.prefix "classifies"
    /// <summary>
    ///   <para>rdfs:label : has English full name^^xsd:string</para>
    ///   <para>skos:definition : the full name, if different from the short form of the country name, in lower case^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/hasEnglishFullName">lcc-cr:hasEnglishFullName</a>
    /// </summary>
    let hasEnglishFullName = _prefixId.prefix "hasEnglishFullName"
    /// <summary>
    ///   <para>rdfs:label : has English short name^^xsd:string</para>
    ///   <para>skos:definition : the short form of the country name, in English^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/hasEnglishShortName">lcc-cr:hasEnglishShortName</a>
    /// </summary>
    let hasEnglishShortName = _prefixId.prefix "hasEnglishShortName"
    /// <summary>
    ///   <para>rdfs:label : has English short name in capitals^^xsd:string</para>
    ///   <para>skos:definition : the short form of the country name, in English (capitals)^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/hasEnglishShortNameInCapitals">lcc-cr:hasEnglishShortNameInCapitals</a>
    /// </summary>
    let hasEnglishShortNameInCapitals = _prefixId.prefix "hasEnglishShortNameInCapitals"
    /// <summary>
    ///   <para>rdfs:label : has French full name^^xsd:string</para>
    ///   <para>skos:definition : the full name, if different from the short form of the country name, in lower case^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/hasFrenchFullName">lcc-cr:hasFrenchFullName</a>
    /// </summary>
    let hasFrenchFullName = _prefixId.prefix "hasFrenchFullName"
    /// <summary>
    ///   <para>rdfs:label : has French short name^^xsd:string</para>
    ///   <para>skos:definition : the short form of the country name, in French^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/hasFrenchShortName">lcc-cr:hasFrenchShortName</a>
    /// </summary>
    let hasFrenchShortName = _prefixId.prefix "hasFrenchShortName"
    /// <summary>
    ///   <para>rdfs:label : has French short name in capitals^^xsd:string</para>
    ///   <para>skos:definition : the short form of the country name, in French (capitals)^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/hasFrenchShortNameInCapitals">lcc-cr:hasFrenchShortNameInCapitals</a>
    /// </summary>
    let hasFrenchShortNameInCapitals = _prefixId.prefix "hasFrenchShortNameInCapitals"
    /// <summary>
    ///   <para>rdfs:label : has latitude^^xsd:string</para>
    ///   <para>skos:definition : the angle formed by the intersection of a line perpendicular to the Earth's surface at a point and the plane of the Equator^^xsd:string</para>
    ///   <para>skos:note : Points north of the Equator have positive latitude values, while points south have negative values. Latitude values range from minus 90 to plus 90 degrees. Lines of latitude are also called parallels because a particular value of latitude forms a circle parallel to the Equator.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/hasLatitude">lcc-cr:hasLatitude</a>
    /// </summary>
    let hasLatitude = _prefixId.prefix "hasLatitude"
    /// <summary>
    ///   <para>rdfs:label : has local short name^^xsd:string</para>
    ///   <para>skos:definition : the local, regional, cultural, or indigenous short form of the country name^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/hasLocalShortName">lcc-cr:hasLocalShortName</a>
    /// </summary>
    let hasLocalShortName = _prefixId.prefix "hasLocalShortName"
    /// <summary>
    ///   <para>rdfs:label : has longitude^^xsd:string</para>
    ///   <para>skos:definition : the angle between a plane that passes through the point and the North and South poles, and a reference plane^^xsd:string</para>
    ///   <para>skos:note : The reference plane is known as the prime meridian. The most common prime meridian passes through Greenwich, United Kingdom. Other examples of prime meridians in use pass through Paris and Bogota. Longitude values range from minus 180 to plus 180 degrees.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/hasLongitude">lcc-cr:hasLongitude</a>
    /// </summary>
    let hasLongitude = _prefixId.prefix "hasLongitude"
    /// <summary>
    ///   <para>rdfs:label : has maximum latitude^^xsd:string</para>
    ///   <para>skos:definition : a maximum latitude with respect to a range^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/hasMaximumLatitude">lcc-cr:hasMaximumLatitude</a>
    /// </summary>
    let hasMaximumLatitude = _prefixId.prefix "hasMaximumLatitude"
    /// <summary>
    ///   <para>rdfs:label : has maximum longitude^^xsd:string</para>
    ///   <para>skos:definition : a maximum longitude with respect to a range^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/hasMaximumLongitude">lcc-cr:hasMaximumLongitude</a>
    /// </summary>
    let hasMaximumLongitude = _prefixId.prefix "hasMaximumLongitude"
    /// <summary>
    ///   <para>rdfs:label : has minimum latitude^^xsd:string</para>
    ///   <para>skos:definition : a minimum latitude with respect to a range^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/hasMinimumLatitude">lcc-cr:hasMinimumLatitude</a>
    /// </summary>
    let hasMinimumLatitude = _prefixId.prefix "hasMinimumLatitude"
    /// <summary>
    ///   <para>rdfs:label : has minimum longitude^^xsd:string</para>
    ///   <para>skos:definition : a minimum longitude with respect to a range^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/hasMinimumLongitude">lcc-cr:hasMinimumLongitude</a>
    /// </summary>
    let hasMinimumLongitude = _prefixId.prefix "hasMinimumLongitude"
    /// <summary>
    ///   <para>rdfs:label : has numeric region code^^xsd:string</para>
    ///   <para>skos:definition : a three-digit numeric code assigned to a region according to some code set^^xsd:string</para>
    ///   <para>skos:note : For certain territories that do not have an alternate designation (i.e. country or country subdivision code in ISO 3166), the corresponding numeric code may have four digits.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/hasNumericRegionCode">lcc-cr:hasNumericRegionCode</a>
    /// </summary>
    let hasNumericRegionCode = _prefixId.prefix "hasNumericRegionCode"
    /// <summary>
    ///   <para>rdfs:label : has part^^xsd:string</para>
    ///   <para>sm:directSource : Stanford Encyclopedia of Philosophy at http://plato.stanford.edu/entries/mereology/^^xsd:string</para>
    ///   <para>skos:definition : indicates any portion of something, regardless of whether the portion itself is attached to the remainder or detached; cognitively salient or arbitrarily demarcated; self-connected or disconnected; homogeneous or gerrymandered; material or immaterial; extended or unextended; spatial or temporal^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/hasPart">lcc-cr:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>rdfs:label : has remarks^^xsd:string</para>
    ///   <para>skos:definition : remarks, such as other widely-used country names, names of geographically separated territories covered by the coding system, and so forth^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/hasRemarks">lcc-cr:hasRemarks</a>
    /// </summary>
    let hasRemarks = _prefixId.prefix "hasRemarks"
    /// <summary>
    ///   <para>rdfs:label : has subregion^^xsd:string</para>
    ///   <para>skos:definition : relates a geographic region to another geographic region that is a designated subregion of it^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/hasSubregion">lcc-cr:hasSubregion</a>
    /// </summary>
    let hasSubregion = _prefixId.prefix "hasSubregion"
    /// <summary>
    ///   <para>rdfs:label : is classified by^^xsd:string</para>
    ///   <para>skos:definition : indicates the classifier used to characterize something^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/isClassifiedBy">lcc-cr:isClassifiedBy</a>
    /// </summary>
    let isClassifiedBy = _prefixId.prefix "isClassifiedBy"
    /// <summary>
    ///   <para>rdfs:label : is independent^^xsd:string</para>
    ///   <para>skos:definition : indicates whether a geopolitical entity stands alone or is part of another country^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/isIndependent">lcc-cr:isIndependent</a>
    /// </summary>
    let isIndependent = _prefixId.prefix "isIndependent"
    /// <summary>
    ///   <para>rdfs:label : is a part of^^xsd:string</para>
    ///   <para>sm:directSource : Stanford Encyclopedia of Philosophy at http://plato.stanford.edu/entries/mereology/^^xsd:string</para>
    ///   <para>skos:definition : relates something to another thing that it is some component or portion of, regardless of how that whole-part relationship is manifested, i.e., attached to the remainder or detached; cognitively salient or arbitrarily demarcated; self-connected or disconnected; homogeneous or gerrymandered; material or immaterial; extended or unextended; spatial or temporal; the most generic part relation, reflexive, asymmetric, and transitive^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/isPartOf">lcc-cr:isPartOf</a>
    /// </summary>
    let isPartOf = _prefixId.prefix "isPartOf"
    /// <summary>
    ///   <para>rdfs:label : is a subregion of^^xsd:string</para>
    ///   <para>skos:definition : relates a geographic region to another geographic region that it is a part of^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/isSubregionOf">lcc-cr:isSubregionOf</a>
    /// </summary>
    let isSubregionOf = _prefixId.prefix "isSubregionOf"
    /// <summary>
    ///   <para>rdfs:label : is used by^^xsd:string</para>
    ///   <para>skos:definition : is employed in the process of accomplishing something^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/isUsedBy">lcc-cr:isUsedBy</a>
    /// </summary>
    let isUsedBy = _prefixId.prefix "isUsedBy"
    /// <summary>
    ///   <para>rdfs:label : uses^^xsd:string</para>
    ///   <para>skos:definition : employs as a means of accomplishing some task or achieving some result^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/uses">lcc-cr:uses</a>
    /// </summary>
    let uses = _prefixId.prefix "uses"
    /// <summary>
    ///   <para>rdfs:label : uses administrative language^^xsd:string</para>
    ///   <para>skos:definition : relates a country or geopolitical entity to an administrative language that entity uses for international communications^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/LCC/Countries/CountryRepresentation/usesAdministrativeLanguage">lcc-cr:usesAdministrativeLanguage</a>
    /// </summary>
    let usesAdministrativeLanguage = _prefixId.prefix "usesAdministrativeLanguage"
