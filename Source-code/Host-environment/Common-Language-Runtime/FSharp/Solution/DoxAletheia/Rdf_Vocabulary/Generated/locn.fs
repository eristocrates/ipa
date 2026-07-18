namespace http.www.w3.org.ns.locn.hash

open DoxAletheia.Rdf_Vocabulary

module locn =
    let _namespace_name = "http://www.w3.org/ns/locn#"
    /// <summary>
    /// An "address representation" as conceptually defined by the INSPIRE Address Representation data type. The locn:addressId property may be used to link this locn:Address to other representations.
    /// <see href="http://www.w3.org/ns/locn#Address"></see></summary>
    let Address = Namespaced_IRI.parse _namespace_name "Address" |> NamespacedName
    /// <summary>
    /// The locn:Geometry class provides the means to identify a location as a point, line, polygon, etc. expressed using coordinates in some coordinate reference system.
    /// <see href="http://www.w3.org/ns/locn#Geometry"></see></summary>
    let Geometry = Namespaced_IRI.parse _namespace_name "Geometry" |> NamespacedName
    /// <summary>
    /// The locn:address property relationship associates any resource with the locn:Address class
    /// <see href="http://www.w3.org/ns/locn#address"></see></summary>
    let address = Namespaced_IRI.parse _namespace_name "address" |> NamespacedName

    /// <summary>
    /// The name or names of a geographic area or locality that groups a number of addressable objects for addressing purposes, without being an administrative unit. This would typically be part of a city, a neighbourhood or village. The domain of locn:addressArea is locn:Address.
    /// <see href="http://www.w3.org/ns/locn#addressArea"></see></summary>
    let addressArea =
        Namespaced_IRI.parse _namespace_name "addressArea" |> NamespacedName

    /// <summary>
    /// The concept of adding a globally unique identifier for each instance of an address is a crucial part of the INSPIRE data spec. The domain of locn:addressId is locn:Address.
    /// <see href="http://www.w3.org/ns/locn#addressId"></see></summary>
    let addressId = Namespaced_IRI.parse _namespace_name "addressId" |> NamespacedName

    /// <summary>
    /// The uppermost administrative unit for the address, almost always a country. The domain of locn:adminUnitL1 is locn:Address and the range is a literal, conceptually defined by the INSPIRE Geographical Name data type.
    /// <see href="http://www.w3.org/ns/locn#adminUnitL1"></see></summary>
    let adminUnitL1 =
        Namespaced_IRI.parse _namespace_name "adminUnitL1" |> NamespacedName

    /// <summary>
    /// The region of the address, usually a county, state or other such area that typically encompasses several localities. The domain of  locn:adminUnitL2 is locn:Address and the range is a literal, conceptually defined by the INSPIRE Geographical Name data type.
    /// <see href="http://www.w3.org/ns/locn#adminUnitL2"></see></summary>
    let adminUnitL2 =
        Namespaced_IRI.parse _namespace_name "adminUnitL2" |> NamespacedName

    /// <summary>
    /// The complete address written as a string, with or without formatting. The domain of locn:fullAddress is locn:Address.
    /// <see href="http://www.w3.org/ns/locn#fullAddress"></see></summary>
    let fullAddress =
        Namespaced_IRI.parse _namespace_name "fullAddress" |> NamespacedName

    /// <summary>
    ///
    /// A geographic name is a proper noun applied to a spatial object. Taking the example used in the relevant INSPIRE data specification (page 18), the following are all valid geographic names for the Greek capital:
    /// - Αθήνα (the Greek endonym written in the Greek script)
    /// - Athína (the standard Romanisation of the endonym)
    /// - Athens (the English language exonym)
    /// For INSPIRE-conformant data, provide the metadata for the geographic name using a skos:Concept as a datatype.
    ///
    /// <see href="http://www.w3.org/ns/locn#geographicName"></see></summary>
    let geographicName =
        Namespaced_IRI.parse _namespace_name "geographicName" |> NamespacedName

    /// <summary>
    /// Associates any resource with the corresponding geometry.
    /// <see href="http://www.w3.org/ns/locn#geometry"></see></summary>
    let geometry = Namespaced_IRI.parse _namespace_name "geometry" |> NamespacedName
    /// <summary>
    /// The location property links any resource to the Location Class. Asserting the location relationship implies only that the domain has some connection to a Location in time or space. It does not imply that the resource is necessarily at that location at the time when the assertion is made.
    /// <see href="http://www.w3.org/ns/locn#location"></see></summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName

    /// <summary>
    /// A number or a sequence of characters that uniquely identifies the locator within the relevant scope(s). The full identification of the locator could include one or more locator designators.
    ///
    /// <see href="http://www.w3.org/ns/locn#locatorDesignator"></see></summary>
    let locatorDesignator =
        Namespaced_IRI.parse _namespace_name "locatorDesignator" |> NamespacedName

    /// <summary>
    /// Proper noun(s) applied to the real world entity identified by the locator. The locator name could be the name of the property or complex, of the building or part of the building, or it could be the name of a room inside a building.
    ///
    /// <see href="http://www.w3.org/ns/locn#locatorName"></see></summary>
    let locatorName =
        Namespaced_IRI.parse _namespace_name "locatorName" |> NamespacedName

    /// <summary>
    /// The Post Office Box number. The domain of locn:poBox is locn:Address.
    /// <see href="http://www.w3.org/ns/locn#poBox"></see></summary>
    let poBox = Namespaced_IRI.parse _namespace_name "poBox" |> NamespacedName
    /// <summary>
    /// The post code (a.k.a postal code, zip code etc.). Post codes are common elements in many countries' postal address systems. The domain of locn:postCode is locn:Address.
    /// <see href="http://www.w3.org/ns/locn#postCode"></see></summary>
    let postCode = Namespaced_IRI.parse _namespace_name "postCode" |> NamespacedName
    /// <summary>
    /// The key postal division of the address, usually the city. (INSPIRE's definition is "One or more names created and maintained for postal purposes to identify a subdivision of addresses and postal delivery points."). The domain of locn:postName is locn:Address.
    /// <see href="http://www.w3.org/ns/locn#postName"></see></summary>
    let postName = Namespaced_IRI.parse _namespace_name "postName" |> NamespacedName

    /// <summary>
    /// An address component that represents the name of a passage or way through from one location to another. A thoroughfare is not necessarily a road, it might be a waterway or some other feature. The domain of locn:thoroughfare is locn:Address.
    /// <see href="http://www.w3.org/ns/locn#thoroughfare"></see></summary>
    let thoroughfare =
        Namespaced_IRI.parse _namespace_name "thoroughfare" |> NamespacedName
