#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module locn =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/locn#" "locn"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : An "address representation" as conceptually defined by the INSPIRE Address Representation data type. The locn:addressId property may be used to link this locn:Address to other representations.</para>
    ///   <para>dcterms:identifier : locn:Address^^xsd:string</para>
    ///   <para>rdfs:label : Address</para>
    ///   <a href="http://www.w3.org/ns/locn#Address">locn:Address</a>
    /// </summary>
    let Address = _prefixId.prefix "Address"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:comment : The locn:Geometry class provides the means to identify a location as a point, line, polygon, etc. expressed using coordinates in some coordinate reference system.</para>
    ///   <para>vann:usageNote : This class defines the notion of "geometry" at the conceptual level, and it shall be encoded by using different formats (see usage note of the locn:geometry property).</para>
    ///   <para>dcterms:identifier : locn:Geometry^^xsd:string</para>
    ///   <para>rdfs:label : Geometry</para>
    ///   <a href="http://www.w3.org/ns/locn#Geometry">locn:Geometry</a>
    /// </summary>
    let Geometry = _prefixId.prefix "Geometry"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : The locn:address property relationship associates any resource with the locn:Address class </para>
    ///   <para>dcterms:identifier : locn:address^^xsd:string</para>
    ///   <para>rdfs:label : address</para>
    ///   <a href="http://www.w3.org/ns/locn#address">locn:address</a>
    /// </summary>
    let address = _prefixId.prefix "address"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : The name or names of a geographic area or locality that groups a number of addressable objects for addressing purposes, without being an administrative unit. This would typically be part of a city, a neighbourhood or village. The domain of locn:addressArea is locn:Address.</para>
    ///   <para>dcterms:identifier : locn:addressArea^^xsd:string</para>
    ///   <para>rdfs:label : address area</para>
    ///   <a href="http://www.w3.org/ns/locn#addressArea">locn:addressArea</a>
    /// </summary>
    let addressArea = _prefixId.prefix "addressArea"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:comment : The concept of adding a globally unique identifier for each instance of an address is a crucial part of the INSPIRE data spec. The domain of locn:addressId is locn:Address.</para>
    ///   <para>dcterms:identifier : locn:addressId^^xsd:string</para>
    ///   <para>rdfs:label : address ID</para>
    ///   <a href="http://www.w3.org/ns/locn#addressId">locn:addressId</a>
    /// </summary>
    let addressId = _prefixId.prefix "addressId"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : The uppermost administrative unit for the address, almost always a country. The domain of locn:adminUnitL1 is locn:Address and the range is a literal, conceptually defined by the INSPIRE Geographical Name data type.</para>
    ///   <para>vann:usageNote : Best practice is to use the ISO 3166-1 code but if this is inappropriate for the context, country names should be provided in a consistent manner to reduce ambiguity. For example, either write 'United Kingdom' or 'UK' consistently throughout the data set and avoid mixing the two.</para>
    ///   <para>dcterms:identifier : locn:adminUnitL1^^xsd:string</para>
    ///   <para>rdfs:label : admin unit level 1</para>
    ///   <a href="http://www.w3.org/ns/locn#adminUnitL1">locn:adminUnitL1</a>
    /// </summary>
    let adminUnitL1 = _prefixId.prefix "adminUnitL1"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : The region of the address, usually a county, state or other such area that typically encompasses several localities. The domain of  locn:adminUnitL2 is locn:Address and the range is a literal, conceptually defined by the INSPIRE Geographical Name data type.</para>
    ///   <para>dcterms:identifier : locn:adminUnitL2^^xsd:string</para>
    ///   <para>rdfs:label : admin unit level 2</para>
    ///   <a href="http://www.w3.org/ns/locn#adminUnitL2">locn:adminUnitL2</a>
    /// </summary>
    let adminUnitL2 = _prefixId.prefix "adminUnitL2"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : The complete address written as a string, with or without formatting. The domain of locn:fullAddress is locn:Address.</para>
    ///   <para>dcterms:identifier : locn:fullAddress^^xsd:string</para>
    ///   <para>rdfs:label : full address</para>
    ///   <a href="http://www.w3.org/ns/locn#fullAddress">locn:fullAddress</a>
    /// </summary>
    let fullAddress = _prefixId.prefix "fullAddress"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment :
    /// A geographic name is a proper noun applied to a spatial object. Taking the example used in the relevant INSPIRE data specification (page 18), the following are all valid geographic names for the Greek capital:
    /// - Αθήνα (the Greek endonym written in the Greek script)
    /// - Athína (the standard Romanisation of the endonym)
    /// - Athens (the English language exonym)
    /// For INSPIRE-conformant data, provide the metadata for the geographic name using a skos:Concept as a datatype.
    /// </para>
    ///   <para>dcterms:identifier : locn:geographicName^^xsd:string</para>
    ///   <para>rdfs:label : geographic name</para>
    ///   <a href="http://www.w3.org/ns/locn#geographicName">locn:geographicName</a>
    /// </summary>
    let geographicName = _prefixId.prefix "geographicName"
    /// <summary>
    ///   <para>dcterms:identifier : locn:geometry^^xsd:string</para>
    ///   <para>rdfs:label : geometry</para>
    ///   <para>vann:usageNote :
    /// Depending on how a geometry is encoded, the range of this property may be one of the following:
    /// - a literal (e.g., WKT - string literal -, GML, KML - XML literal)
    /// - a geometry class, as those defined in the OGC's GeoSPARQL specification, in the W3C's Basic Geo (WGS84 lat/long) vocabulary, and at schema.org;
    /// - geocoded URIs, as geo or GeoHash URIs, treated as URI references.
    /// For interoperability reasons, it is recommended using one of the following:
    /// - Any geometry:
    ///   - WKT, GML, and RDF+WKT/GML, as per the GeoSPARQL specification.
    ///   - KML (Keyhole Markup Language) - note that KML supports the following geometries only: point, line string, linear ring, and polygon.
    ///   - RDF as per the schema.org vocabulary (see classes schema:GeoCoordinates and schema:GeoShape).
    /// - Points: one of the above, or:
    ///   - RDF as per the W3C Basic Geo (WGS84 lat/long) vocabulary.
    ///   - GeoHash URIs.
    ///   - geo URIs.
    ///     </para>
    ///   <para>rdfs:comment : Associates any resource with the corresponding geometry.</para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>vann:example :
    /// The following are examples of equivalent statements using different geometry encodings. In the examples, prefix gsp is used for namespace URI http://www.opengis.net/ont/geosparql#, whereas prefix sf is used for namespace URI http://www.opengis.net/ont/sf#.
    /// - WKT (GeoSPARQL)
    /// :Resource locn:geometry
    ///   "&lt;http://www.opengis.net/def/crs/OGC/1.3/CRS84&gt; Point(-0.001475 51.477811)"^^gsp:wktLiteral .
    /// - GML
    /// :Resource locn:geometry
    ///   "&lt;gml:Point srsName='http://www.opengis.net/def/crs/OGC/1.3/CRS84'&gt;
    ///   &lt;gml:coordinates&gt;-0.001475, 51.477811&lt;/gml:coordinates&gt;&lt;/gml:Point&gt;"^^gsp:gmlLiteral .
    /// - RDF+WKT (GeoSPARQL)
    /// :Resource locn:geometry
    ///   [ a sf:Point; gsp:asWKT "&lt;http://www.opengis.net/def/crs/OGC/1.3/CRS84&gt; Point(-0.001475 51.477811)"^^gsp:wktLiteral ] .
    /// - RDF+GML (GeoSPARQL)
    /// :Resource locn:geometry
    ///   [ a sf:Point; gsp:asGML
    ///      "&lt;gml:Point srsName='http://www.opengis.net/def/crs/OGC/1.3/CRS84'&gt;
    ///       &lt;gml:coordinates&gt;-0.001475, 51.477811&lt;/gml:coordinates&gt;&lt;/gml:Point&gt;"^^gsp:gmlLiteral ] .
    /// - RDF (WGS84 lat/long)
    /// :Resource locn:geometry [ a geo:Point; geo:lat "51.477811"; geo:long "-0.001475" ] .
    /// - RDF (schema.org)
    /// :Resource locn:geometry [ a schema:GeoCoordinates; schema:latitude "51.477811"; schema:longitude "-0.001475" ] .
    /// - geo URI
    /// :Resource locn:geometry &lt;geo:51.477811,-0.001475;u=0;crs=wgs84&gt; .
    /// - GeoHash URI
    /// :Resource locn:geometry &lt;http://geohash.org/gcpuzgnzvxkp&gt; .
    ///     </para>
    ///   <a href="http://www.w3.org/ns/locn#geometry">locn:geometry</a>
    /// </summary>
    let geometry = _prefixId.prefix "geometry"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : The location property links any resource to the Location Class. Asserting the location relationship implies only that the domain has some connection to a Location in time or space. It does not imply that the resource is necessarily at that location at the time when the assertion is made.</para>
    ///   <para>dcterms:identifier : locn:location^^xsd:string</para>
    ///   <para>rdfs:label : location</para>
    ///   <a href="http://www.w3.org/ns/locn#location">locn:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : A number or a sequence of characters that uniquely identifies the locator within the relevant scope(s). The full identification of the locator could include one or more locator designators.
    ///     </para>
    ///   <para>dcterms:identifier : locn:locatorDesignator^^xsd:string</para>
    ///   <para>rdfs:label : locator designator</para>
    ///   <a href="http://www.w3.org/ns/locn#locatorDesignator">locn:locatorDesignator</a>
    /// </summary>
    let locatorDesignator = _prefixId.prefix "locatorDesignator"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : Proper noun(s) applied to the real world entity identified by the locator. The locator name could be the name of the property or complex, of the building or part of the building, or it could be the name of a room inside a building.
    ///     </para>
    ///   <para>dcterms:identifier : locn:locatorName^^xsd:string</para>
    ///   <para>rdfs:label : locator name</para>
    ///   <a href="http://www.w3.org/ns/locn#locatorName">locn:locatorName</a>
    /// </summary>
    let locatorName = _prefixId.prefix "locatorName"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : The Post Office Box number. The domain of locn:poBox is locn:Address.</para>
    ///   <para>dcterms:identifier : locn:poBox^^xsd:string</para>
    ///   <para>rdfs:label : PO box</para>
    ///   <a href="http://www.w3.org/ns/locn#poBox">locn:poBox</a>
    /// </summary>
    let poBox = _prefixId.prefix "poBox"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : The post code (a.k.a postal code, zip code etc.). Post codes are common elements in many countries' postal address systems. The domain of locn:postCode is locn:Address.</para>
    ///   <para>dcterms:identifier : locn:postCode^^xsd:string</para>
    ///   <para>rdfs:label : post code</para>
    ///   <a href="http://www.w3.org/ns/locn#postCode">locn:postCode</a>
    /// </summary>
    let postCode = _prefixId.prefix "postCode"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : The key postal division of the address, usually the city. (INSPIRE's definition is "One or more names created and maintained for postal purposes to identify a subdivision of addresses and postal delivery points."). The domain of locn:postName is locn:Address.</para>
    ///   <para>dcterms:identifier : locn:postName^^xsd:string</para>
    ///   <para>rdfs:label : post name</para>
    ///   <a href="http://www.w3.org/ns/locn#postName">locn:postName</a>
    /// </summary>
    let postName = _prefixId.prefix "postName"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : An address component that represents the name of a passage or way through from one location to another. A thoroughfare is not necessarily a road, it might be a waterway or some other feature. The domain of locn:thoroughfare is locn:Address.</para>
    ///   <para>dcterms:identifier : locn:thoroughfare^^xsd:string</para>
    ///   <para>rdfs:label : thoroughfare</para>
    ///   <a href="http://www.w3.org/ns/locn#thoroughfare">locn:thoroughfare</a>
    /// </summary>
    let thoroughfare = _prefixId.prefix "thoroughfare"
