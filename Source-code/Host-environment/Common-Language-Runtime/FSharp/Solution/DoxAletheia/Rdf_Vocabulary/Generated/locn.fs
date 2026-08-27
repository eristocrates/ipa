namespace http.www.w3.org.ns.locn.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module locn =
    let _namespace_iri = Namespace_Iri locn |> NamespaceIRI
    /// <summary>
    ///   <para>locn:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#">http://www.w3.org/ns/locn#</seealso>
    let _prefix_iri = Prefixed_Name(locn, "") |> PrefixedName
    /// <summary>
    ///   <para>locn:Address</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An "address representation" as defined in the &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2538"&gt;data specifications&lt;/a&gt; of the EU INSPIRE Directive. The &lt;a ="#locn:addressId"&gt;locn:addressId&lt;/a&gt; property may be used to link this Address to other representations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An "address representation" as conceptually defined by the INSPIRE Address Representation data type. The locn:addressId property may be used to link this locn:Address to other representations."</para>
    /// labels<para>"Address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Address"</para><para>"Indirizzo"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#Address">http://www.w3.org/ns/locn#Address</seealso>
    let Address = Prefixed_Name(locn, "Address") |> PrefixedName
    /// <summary>
    ///   <para>locn:Geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The locn:Geometry class provides the means to identify a location as a point, line, polygon, etc. expressed using coordinates in some coordinate reference system."</para>
    ///   <para>"The Geometry Class provides the means to identify a Location as a point, line, polygon, etc. expressed using coordinates in some coordinate reference system."</para>
    /// labels<para>"Geometry"</para><para>"Geometria"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#Geometry">http://www.w3.org/ns/locn#Geometry</seealso>
    let Geometry = Prefixed_Name(locn, "Geometry") |> PrefixedName
    /// <summary>
    ///   <para>locn:Location</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#Location">http://www.w3.org/ns/locn#Location</seealso>
    let Location = Prefixed_Name(locn, "Location") |> PrefixedName
    /// <summary>
    ///   <para>locn:address</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The locn:address property relationship associates any resource with the &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="#locn:Address"&gt;Address&lt;/a&gt; Class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The locn:address property relationship associates any resource with the locn:Address class "</para>
    /// labels<para>"indirizzo"</para><para>"address"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#address">http://www.w3.org/ns/locn#address</seealso>
    let address = Prefixed_Name(locn, "address") |> PrefixedName
    /// <summary>
    ///   <para>locn:addressArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The name or names of a geographic area or locality that groups a number of addressable objects for addressing purposes, without being an administrative unit. This would typically be part of a city, a neighbourhood or village. The domain of locn:addressArea is locn:Address."</para>
    /// labels<para>"address area"</para><para>"address area (neighbourhood/quarter)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#addressArea">http://www.w3.org/ns/locn#addressArea</seealso>
    let addressArea = Prefixed_Name(locn, "addressArea") |> PrefixedName
    /// <summary>
    ///   <para>locn:addressId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The concept of adding a globally unique identifier for each instance of an address is a crucial part of the INSPIRE data spec. The domain of locn:addressId is locn:Address."</para>
    /// labels<para>"address ID"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#addressId">http://www.w3.org/ns/locn#addressId</seealso>
    let addressId = Prefixed_Name(locn, "addressId") |> PrefixedName
    /// <summary>
    ///   <para>locn:adminUnitL1</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The uppermost administrative unit for the address, almost always a country. The domain of locn:adminUnitL1 is locn:Address and the range is a literal, conceptually defined by the INSPIRE Geographical Name data type."</para>
    /// labels<para>"admin unit level 1"</para><para>"admin unit level 1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#adminUnitL1">http://www.w3.org/ns/locn#adminUnitL1</seealso>
    let adminUnitL1 = Prefixed_Name(locn, "adminUnitL1") |> PrefixedName
    /// <summary>
    ///   <para>locn:adminUnitL2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The region of the address, usually a county, state or other such area that typically encompasses several localities. The domain of  locn:adminUnitL2 is locn:Address and the range is a literal, conceptually defined by the INSPIRE Geographical Name data type."</para>
    /// labels<para>"admin unit level 2"</para><para>"admin unit level 2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#adminUnitL2">http://www.w3.org/ns/locn#adminUnitL2</seealso>
    let adminUnitL2 = Prefixed_Name(locn, "adminUnitL2") |> PrefixedName
    /// <summary>
    ///   <para>locn:fullAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The complete address written as a string, with or without formatting. The domain of locn:fullAddress is locn:Address."</para>
    /// labels<para>"full address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"full address"</para><para>"indirizzo completo"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#fullAddress">http://www.w3.org/ns/locn#fullAddress</seealso>
    let fullAddress = Prefixed_Name(locn, "fullAddress") |> PrefixedName
    /// <summary>
    ///   <para>locn:geographicName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"&lt;p xmlns="http://purl.org/oslo/ns/localgov#"&gt;A geographic name is a proper noun applied to a spatial object. Taking the example used in the &lt;a ="http://inspire.jrc.ec.europa.eu/documents/Data_Specifications/INSPIRE_DataSpecification_GN_v3.0.1.pdf"&gt;INSPIRE document&lt;/a&gt; (page 18), the following are all valid geographic names for the Greek capital:&lt;/p&gt;
    ///     &lt;ul&gt;&lt;li&gt;A?n?a (the Greek endonym written in the Greek script)&lt;/li&gt;&lt;li&gt;Athina (the standard Romanisation of the endonym)&lt;/li&gt;&lt;li&gt;Athens (the English language exonym)&lt;/li&gt;&lt;/ul&gt;
    ///     &lt;p&gt;For INSPIRE-conformant data, provide the metadata for the geographic name using a skos:Concept as a datatype.&lt;/p&gt;"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"
    /// A geographic name is a proper noun applied to a spatial object. Taking the example used in the relevant INSPIRE data specification (page 18), the following are all valid geographic names for the Greek capital:
    /// - Αθήνα (the Greek endonym written in the Greek script)
    /// - Athína (the standard Romanisation of the endonym)
    /// - Athens (the English language exonym)
    /// For INSPIRE-conformant data, provide the metadata for the geographic name using a skos:Concept as a datatype.
    /// "</para>
    /// labels<para>"geographic name"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#geographicName">http://www.w3.org/ns/locn#geographicName</seealso>
    let geographicName = Prefixed_Name(locn, "geographicName") |> PrefixedName
    /// <summary>
    ///   <para>locn:geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates any &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="#dcterms:Location"&gt;Location&lt;/a&gt; with the locn:Geometry class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Associates any resource with the corresponding geometry."</para>
    /// labels<para>"geometria"</para><para>"geometry"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#geometry">http://www.w3.org/ns/locn#geometry</seealso>
    let geometry = Prefixed_Name(locn, "geometry") |> PrefixedName
    /// <summary>
    ///   <para>locn:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The location property links any resource to the Location Class.
    ///     Asserting the location relationship implies only that the domain has some connection to a
    ///     Location in time or space. It does not imply that the resource is necessarily at that location
    ///     at the time when the assertion is made."</para>
    ///   <para>"The location property links any resource to the Location Class. Asserting the location relationship implies only that the domain has some connection to a Location in time or space. It does not imply that the resource is necessarily at that location at the time when the assertion is made."</para>
    /// labels<para>"localizzazione"</para><para>"location"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#location">http://www.w3.org/ns/locn#location</seealso>
    let location = Prefixed_Name(locn, "location") |> PrefixedName
    /// <summary>
    ///   <para>locn:locatorDesignator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A number or a sequence of characters that uniquely identifies the locator within the relevant scope(s). The full identification of the locator could include one or more locator designators.
    ///     "</para>
    /// labels<para>"locator designator"</para><para>"locator designator (street number)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#locatorDesignator">http://www.w3.org/ns/locn#locatorDesignator</seealso>
    let locatorDesignator = Prefixed_Name(locn, "locatorDesignator") |> PrefixedName
    /// <summary>
    ///   <para>locn:locatorName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Proper noun(s) applied to the real world entity identified by the locator. The locator name could be the name of the property or complex, of the building or part of the building, or it could be the name of a room inside a building.
    ///     "</para>
    /// labels<para>"locator name"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#locatorName">http://www.w3.org/ns/locn#locatorName</seealso>
    let locatorName = Prefixed_Name(locn, "locatorName") |> PrefixedName
    /// <summary>
    ///   <para>locn:locn;locatorName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#locn;locatorName">http://www.w3.org/ns/locn#locn;locatorName</seealso>
    let ``locn;locatorName`` = Prefixed_Name(locn, "locn;locatorName") |> PrefixedName
    /// <summary>
    ///   <para>locn:poBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The Post Office Box number. The domain of locn:poBox is locn:Address."</para>
    /// labels<para>"post office box"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"PO box"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#poBox">http://www.w3.org/ns/locn#poBox</seealso>
    let poBox = Prefixed_Name(locn, "poBox") |> PrefixedName
    /// <summary>
    ///   <para>locn:postCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The post code (a.k.a postal code, zip code etc.). Post codes are common elements in many countries' postal address systems. The domain of locn:postCode is locn:Address."</para>
    /// labels<para>"post code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"codice postale"</para><para>"post code"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#postCode">http://www.w3.org/ns/locn#postCode</seealso>
    let postCode = Prefixed_Name(locn, "postCode") |> PrefixedName
    /// <summary>
    ///   <para>locn:postName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The key postal division of the address, usually the city. (INSPIRE's definition is "One or more names created and maintained for postal purposes to identify a subdivision of addresses and postal delivery points.") The domain of locn:postName is locn:Address."</para>
    ///   <para>"The key postal division of the address, usually the city. (INSPIRE's definition is "One or more names created and maintained for postal purposes to identify a subdivision of addresses and postal delivery points."). The domain of locn:postName is locn:Address."</para>
    /// labels<para>"post name"</para><para>"post name (locality/city/settlement)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"divisione postale"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#postName">http://www.w3.org/ns/locn#postName</seealso>
    let postName = Prefixed_Name(locn, "postName") |> PrefixedName
    /// <summary>
    ///   <para>locn:registeredAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"registered address"</para><para>"sede legale"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#registeredAddress">http://www.w3.org/ns/locn#registeredAddress</seealso>
    let registeredAddress = Prefixed_Name(locn, "registeredAddress") |> PrefixedName
    /// <summary>
    ///   <para>locn:thoroughfare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"An address component that represents the name of a passage or way through from one location to another. A thoroughfare is not necessarily a road, it might be a waterway or some other feature. The domain of locn:thoroughfare is locn:Address."</para>
    /// labels<para>"thoroughfare"</para><para>"thoroughfare (street address)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/locn#thoroughfare">http://www.w3.org/ns/locn#thoroughfare</seealso>
    let thoroughfare = Prefixed_Name(locn, "thoroughfare") |> PrefixedName
