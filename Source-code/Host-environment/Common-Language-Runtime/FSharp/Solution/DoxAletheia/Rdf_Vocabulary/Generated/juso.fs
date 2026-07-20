namespace http.rdfs.co.juso.slash

open DoxAletheia

module juso =
    let _namespace_name = "http://rdfs.co/juso/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/SpatialThing"></see>
    /// </summary>
    let SpatialThing = _prefix "SpatialThing"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/postal_code"></see>
    /// </summary>
    let postal_code = _prefix "postal_code"

    /// <summary>
    ///   <see href="http://rdfs.co/juso/first_level_administrative_division"></see>
    /// </summary>
    let first_level_administrative_division =
        _prefix "first_level_administrative_division"

    /// <summary>
    ///   <see href="http://rdfs.co/juso/thoroughfare_address"></see>
    /// </summary>
    let thoroughfare_address = _prefix "thoroughfare_address"
    /// <summary>
    ///
    ///     Most of the descriptions given here are from Wikipedia or from the related
    ///     ontologies and vocabularies.
    ///
    ///
    ///     &lt;div&gt;
    ///       The master version of this vocabulary is maintained in &lt;a
    ///       href="https://github.com/listinc/juso-ontology"&gt;the GitHub repository&lt;/a&gt;
    ///       so others can contribute edits and improvements.
    ///     &lt;/div&gt;
    ///
    /// <see href="http://rdfs.co/juso/0.1"></see></summary>
    let ``_0.1`` = _prefix "0.1"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/0.1/rdf"></see>
    /// </summary>
    let ``_0.1/rdf`` = _prefix "0.1/rdf"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/0.1/ttl"></see>
    /// </summary>
    let ``_0.1/ttl`` = _prefix "0.1/ttl"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/0.1/html"></see>
    /// </summary>
    let ``_0.1/html`` = _prefix "0.1/html"
    /// <summary>
    ///
    ///     These classes and properties are used to describe political and
    ///     administrative divisions.
    ///
    /// <see href="http://rdfs.co/juso/PoliticalDivisionGroup"></see></summary>
    let PoliticalDivisionGroup = _prefix "PoliticalDivisionGroup"
    /// <summary>
    ///
    ///     These classes and properties form the core of Juso Ontology. They describe
    ///     fundamental characteristics of geography in relatively broad terms.
    ///
    /// <see href="http://rdfs.co/juso/CoreGroup"></see></summary>
    let CoreGroup = _prefix "CoreGroup"
    /// <summary>
    ///
    ///     These classes and properties are used to describe addresses.
    ///
    /// <see href="http://rdfs.co/juso/AddressGroup"></see></summary>
    let AddressGroup = _prefix "AddressGroup"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Address"></see>
    /// </summary>
    let Address = _prefix "Address"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/full_address"></see>
    /// </summary>
    let full_address = _prefix "full_address"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/thoroughfare"></see>
    /// </summary>
    let thoroughfare = _prefix "thoroughfare"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/locator"></see>
    /// </summary>
    let locator = _prefix "locator"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/locator_address"></see>
    /// </summary>
    let locator_address = _prefix "locator_address"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/po_box"></see>
    /// </summary>
    let po_box = _prefix "po_box"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/PostalCode"></see>
    /// </summary>
    let PostalCode = _prefix "PostalCode"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/country"></see>
    /// </summary>
    let country = _prefix "country"

    /// <summary>
    ///   <see href="http://rdfs.co/juso/second_level_administrative_division"></see>
    /// </summary>
    let second_level_administrative_division =
        _prefix "second_level_administrative_division"

    /// <summary>
    ///   <see href="http://rdfs.co/juso/third_level_administrative_division"></see>
    /// </summary>
    let third_level_administrative_division =
        _prefix "third_level_administrative_division"

    /// <summary>
    ///   <see href="http://rdfs.co/juso/fourth_level_administrative_division"></see>
    /// </summary>
    let fourth_level_administrative_division =
        _prefix "fourth_level_administrative_division"

    /// <summary>
    ///   <see href="http://rdfs.co/juso/fifth_level_administrative_division"></see>
    /// </summary>
    let fifth_level_administrative_division =
        _prefix "fifth_level_administrative_division"

    /// <summary>
    ///   <see href="http://rdfs.co/juso/Thoroughfare"></see>
    /// </summary>
    let Thoroughfare = _prefix "Thoroughfare"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Street"></see>
    /// </summary>
    let Street = _prefix "Street"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/AdministrativeDivision"></see>
    /// </summary>
    let AdministrativeDivision = _prefix "AdministrativeDivision"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/PoliticalDivision"></see>
    /// </summary>
    let PoliticalDivision = _prefix "PoliticalDivision"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/CapitalDistrict"></see>
    /// </summary>
    let CapitalDistrict = _prefix "CapitalDistrict"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/City"></see>
    /// </summary>
    let City = _prefix "City"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/ConsolidatedCityCounty"></see>
    /// </summary>
    let ConsolidatedCityCounty = _prefix "ConsolidatedCityCounty"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/County"></see>
    /// </summary>
    let County = _prefix "County"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/address"></see>
    /// </summary>
    let address = _prefix "address"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/historical_address"></see>
    /// </summary>
    let historical_address = _prefix "historical_address"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Feature"></see>
    /// </summary>
    let Feature = _prefix "Feature"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Geometry"></see>
    /// </summary>
    let Geometry = _prefix "Geometry"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/within"></see>
    /// </summary>
    let within = _prefix "within"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/endonym"></see>
    /// </summary>
    let endonym = _prefix "endonym"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/exonym"></see>
    /// </summary>
    let exonym = _prefix "exonym"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/geometry"></see>
    /// </summary>
    let geometry = _prefix "geometry"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Country"></see>
    /// </summary>
    let Country = _prefix "Country"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/District"></see>
    /// </summary>
    let District = _prefix "District"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/FederatedState"></see>
    /// </summary>
    let FederatedState = _prefix "FederatedState"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/FifthLevelAdministrativeDivision"></see>
    /// </summary>
    let FifthLevelAdministrativeDivision = _prefix "FifthLevelAdministrativeDivision"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/FirstLevelAdministrativeDivision"></see>
    /// </summary>
    let FirstLevelAdministrativeDivision = _prefix "FirstLevelAdministrativeDivision"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/FourthLevelAdministrativeDivision"></see>
    /// </summary>
    let FourthLevelAdministrativeDivision = _prefix "FourthLevelAdministrativeDivision"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Hamlet"></see>
    /// </summary>
    let Hamlet = _prefix "Hamlet"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Municipality"></see>
    /// </summary>
    let Municipality = _prefix "Municipality"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Neighborhood"></see>
    /// </summary>
    let Neighborhood = _prefix "Neighborhood"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Parish"></see>
    /// </summary>
    let Parish = _prefix "Parish"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Province"></see>
    /// </summary>
    let Province = _prefix "Province"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Borough"></see>
    /// </summary>
    let Borough = _prefix "Borough"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Town"></see>
    /// </summary>
    let Town = _prefix "Town"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Township"></see>
    /// </summary>
    let Township = _prefix "Township"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Village"></see>
    /// </summary>
    let Village = _prefix "Village"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/political_division"></see>
    /// </summary>
    let political_division = _prefix "political_division"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/parent"></see>
    /// </summary>
    let parent = _prefix "parent"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/SecondLevelAdministrativeDivision"></see>
    /// </summary>
    let SecondLevelAdministrativeDivision = _prefix "SecondLevelAdministrativeDivision"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/ThirdLevelAdministrativeDivision"></see>
    /// </summary>
    let ThirdLevelAdministrativeDivision = _prefix "ThirdLevelAdministrativeDivision"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/post_office_box"></see>
    /// </summary>
    let post_office_box = _prefix "post_office_box"
