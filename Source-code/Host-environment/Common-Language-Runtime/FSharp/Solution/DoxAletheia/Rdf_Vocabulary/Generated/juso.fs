namespace http.rdfs.co.juso.slash

open DoxAletheia.Rdf_Vocabulary

module juso =
    let _namespace_name = "http://rdfs.co/juso/"

    /// <summary>
    ///   <see href="http://rdfs.co/juso/SpatialThing"></see>
    /// </summary>
    let SpatialThing =
        Namespaced_IRI.parse _namespace_name "SpatialThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/postal_code"></see>
    /// </summary>
    let postal_code =
        Namespaced_IRI.parse _namespace_name "postal_code" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/first_level_administrative_division"></see>
    /// </summary>
    let first_level_administrative_division =
        Namespaced_IRI.parse _namespace_name "first_level_administrative_division" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/thoroughfare_address"></see>
    /// </summary>
    let thoroughfare_address =
        Namespaced_IRI.parse _namespace_name "thoroughfare_address" |> NamespacedName

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
    let ``_0.1`` = Namespaced_IRI.parse _namespace_name "0.1" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/0.1/rdf"></see>
    /// </summary>
    let ``_0.1/rdf`` = Namespaced_IRI.parse _namespace_name "0.1/rdf" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/0.1/ttl"></see>
    /// </summary>
    let ``_0.1/ttl`` = Namespaced_IRI.parse _namespace_name "0.1/ttl" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/0.1/html"></see>
    /// </summary>
    let ``_0.1/html`` =
        Namespaced_IRI.parse _namespace_name "0.1/html" |> NamespacedName

    /// <summary>
    ///
    ///     These classes and properties are used to describe political and
    ///     administrative divisions.
    ///
    /// <see href="http://rdfs.co/juso/PoliticalDivisionGroup"></see></summary>
    let PoliticalDivisionGroup =
        Namespaced_IRI.parse _namespace_name "PoliticalDivisionGroup" |> NamespacedName

    /// <summary>
    ///
    ///     These classes and properties form the core of Juso Ontology. They describe
    ///     fundamental characteristics of geography in relatively broad terms.
    ///
    /// <see href="http://rdfs.co/juso/CoreGroup"></see></summary>
    let CoreGroup = Namespaced_IRI.parse _namespace_name "CoreGroup" |> NamespacedName

    /// <summary>
    ///
    ///     These classes and properties are used to describe addresses.
    ///
    /// <see href="http://rdfs.co/juso/AddressGroup"></see></summary>
    let AddressGroup =
        Namespaced_IRI.parse _namespace_name "AddressGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/Address"></see>
    /// </summary>
    let Address = Namespaced_IRI.parse _namespace_name "Address" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/full_address"></see>
    /// </summary>
    let full_address =
        Namespaced_IRI.parse _namespace_name "full_address" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/thoroughfare"></see>
    /// </summary>
    let thoroughfare =
        Namespaced_IRI.parse _namespace_name "thoroughfare" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/locator"></see>
    /// </summary>
    let locator = Namespaced_IRI.parse _namespace_name "locator" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/locator_address"></see>
    /// </summary>
    let locator_address =
        Namespaced_IRI.parse _namespace_name "locator_address" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/po_box"></see>
    /// </summary>
    let po_box = Namespaced_IRI.parse _namespace_name "po_box" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/PostalCode"></see>
    /// </summary>
    let PostalCode = Namespaced_IRI.parse _namespace_name "PostalCode" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/country"></see>
    /// </summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/second_level_administrative_division"></see>
    /// </summary>
    let second_level_administrative_division =
        Namespaced_IRI.parse _namespace_name "second_level_administrative_division" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/third_level_administrative_division"></see>
    /// </summary>
    let third_level_administrative_division =
        Namespaced_IRI.parse _namespace_name "third_level_administrative_division" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/fourth_level_administrative_division"></see>
    /// </summary>
    let fourth_level_administrative_division =
        Namespaced_IRI.parse _namespace_name "fourth_level_administrative_division" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/fifth_level_administrative_division"></see>
    /// </summary>
    let fifth_level_administrative_division =
        Namespaced_IRI.parse _namespace_name "fifth_level_administrative_division" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/Thoroughfare"></see>
    /// </summary>
    let Thoroughfare =
        Namespaced_IRI.parse _namespace_name "Thoroughfare" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/Street"></see>
    /// </summary>
    let Street = Namespaced_IRI.parse _namespace_name "Street" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/AdministrativeDivision"></see>
    /// </summary>
    let AdministrativeDivision =
        Namespaced_IRI.parse _namespace_name "AdministrativeDivision" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/PoliticalDivision"></see>
    /// </summary>
    let PoliticalDivision =
        Namespaced_IRI.parse _namespace_name "PoliticalDivision" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/CapitalDistrict"></see>
    /// </summary>
    let CapitalDistrict =
        Namespaced_IRI.parse _namespace_name "CapitalDistrict" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/City"></see>
    /// </summary>
    let City = Namespaced_IRI.parse _namespace_name "City" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/ConsolidatedCityCounty"></see>
    /// </summary>
    let ConsolidatedCityCounty =
        Namespaced_IRI.parse _namespace_name "ConsolidatedCityCounty" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/County"></see>
    /// </summary>
    let County = Namespaced_IRI.parse _namespace_name "County" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/address"></see>
    /// </summary>
    let address = Namespaced_IRI.parse _namespace_name "address" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/historical_address"></see>
    /// </summary>
    let historical_address =
        Namespaced_IRI.parse _namespace_name "historical_address" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/Feature"></see>
    /// </summary>
    let Feature = Namespaced_IRI.parse _namespace_name "Feature" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Geometry"></see>
    /// </summary>
    let Geometry = Namespaced_IRI.parse _namespace_name "Geometry" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/within"></see>
    /// </summary>
    let within = Namespaced_IRI.parse _namespace_name "within" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/endonym"></see>
    /// </summary>
    let endonym = Namespaced_IRI.parse _namespace_name "endonym" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/exonym"></see>
    /// </summary>
    let exonym = Namespaced_IRI.parse _namespace_name "exonym" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/geometry"></see>
    /// </summary>
    let geometry = Namespaced_IRI.parse _namespace_name "geometry" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Country"></see>
    /// </summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/District"></see>
    /// </summary>
    let District = Namespaced_IRI.parse _namespace_name "District" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/FederatedState"></see>
    /// </summary>
    let FederatedState =
        Namespaced_IRI.parse _namespace_name "FederatedState" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/FifthLevelAdministrativeDivision"></see>
    /// </summary>
    let FifthLevelAdministrativeDivision =
        Namespaced_IRI.parse _namespace_name "FifthLevelAdministrativeDivision" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/FirstLevelAdministrativeDivision"></see>
    /// </summary>
    let FirstLevelAdministrativeDivision =
        Namespaced_IRI.parse _namespace_name "FirstLevelAdministrativeDivision" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/FourthLevelAdministrativeDivision"></see>
    /// </summary>
    let FourthLevelAdministrativeDivision =
        Namespaced_IRI.parse _namespace_name "FourthLevelAdministrativeDivision" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/Hamlet"></see>
    /// </summary>
    let Hamlet = Namespaced_IRI.parse _namespace_name "Hamlet" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/Municipality"></see>
    /// </summary>
    let Municipality =
        Namespaced_IRI.parse _namespace_name "Municipality" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/Neighborhood"></see>
    /// </summary>
    let Neighborhood =
        Namespaced_IRI.parse _namespace_name "Neighborhood" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/Parish"></see>
    /// </summary>
    let Parish = Namespaced_IRI.parse _namespace_name "Parish" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Province"></see>
    /// </summary>
    let Province = Namespaced_IRI.parse _namespace_name "Province" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Borough"></see>
    /// </summary>
    let Borough = Namespaced_IRI.parse _namespace_name "Borough" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Town"></see>
    /// </summary>
    let Town = Namespaced_IRI.parse _namespace_name "Town" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Township"></see>
    /// </summary>
    let Township = Namespaced_IRI.parse _namespace_name "Township" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/Village"></see>
    /// </summary>
    let Village = Namespaced_IRI.parse _namespace_name "Village" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/political_division"></see>
    /// </summary>
    let political_division =
        Namespaced_IRI.parse _namespace_name "political_division" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/parent"></see>
    /// </summary>
    let parent = Namespaced_IRI.parse _namespace_name "parent" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/SecondLevelAdministrativeDivision"></see>
    /// </summary>
    let SecondLevelAdministrativeDivision =
        Namespaced_IRI.parse _namespace_name "SecondLevelAdministrativeDivision" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/ThirdLevelAdministrativeDivision"></see>
    /// </summary>
    let ThirdLevelAdministrativeDivision =
        Namespaced_IRI.parse _namespace_name "ThirdLevelAdministrativeDivision" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/post_office_box"></see>
    /// </summary>
    let post_office_box =
        Namespaced_IRI.parse _namespace_name "post_office_box" |> NamespacedName
