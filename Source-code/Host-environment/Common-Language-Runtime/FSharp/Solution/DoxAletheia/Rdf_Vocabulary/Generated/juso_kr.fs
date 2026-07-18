namespace http.rdfs.co.juso.kr.slash

open DoxAletheia.Rdf_Vocabulary

module juso_kr =
    let _namespace_name = "http://rdfs.co/juso/kr/"
    /// <summary>
    ///
    ///     &lt;div&gt;
    ///       The master version of this vocabulary is maintained in &lt;a
    ///       href="https://github.com/listinc/juso-ontology/tree/master/kr"&gt;the GitHub
    ///       repository&lt;/a&gt; so others can contribute edits and improvements.
    ///     &lt;/div&gt;
    ///
    ///
    ///     Most of the descriptions given here are from Wikipedia or from the related
    ///     ontologies and vocabularies.
    ///
    /// <see href="http://rdfs.co/juso/kr/0.1"></see></summary>
    let ``_0.1`` = Namespaced_IRI.parse _namespace_name "0.1" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/0.1/html"></see>
    /// </summary>
    let ``_0.1/html`` =
        Namespaced_IRI.parse _namespace_name "0.1/html" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/0.1/rdf"></see>
    /// </summary>
    let ``_0.1/rdf`` = Namespaced_IRI.parse _namespace_name "0.1/rdf" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/0.1/ttl"></see>
    /// </summary>
    let ``_0.1/ttl`` = Namespaced_IRI.parse _namespace_name "0.1/ttl" |> NamespacedName

    /// <summary>
    ///
    ///      These classes and properties are used to describe addresses in South Korea.
    ///
    /// <see href="http://rdfs.co/juso/kr/AddressGroup"></see></summary>
    let AddressGroup =
        Namespaced_IRI.parse _namespace_name "AddressGroup" |> NamespacedName

    /// <summary>
    ///
    ///     These classes and properties are used to describe administrative divisions
    ///     in South Korea.
    ///
    /// <see href="http://rdfs.co/juso/kr/AdministrativeDivisionGroup"></see></summary>
    let AdministrativeDivisionGroup =
        Namespaced_IRI.parse _namespace_name "AdministrativeDivisionGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/EastAsianAddress"></see>
    /// </summary>
    let EastAsianAddress =
        Namespaced_IRI.parse _namespace_name "EastAsianAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/Street"></see>
    /// </summary>
    let Street = Namespaced_IRI.parse _namespace_name "Street" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/Road"></see>
    /// </summary>
    let Road = Namespaced_IRI.parse _namespace_name "Road" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/road_name_number"></see>
    /// </summary>
    let road_name_number =
        Namespaced_IRI.parse _namespace_name "road_name_number" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/parent_road"></see>
    /// </summary>
    let parent_road =
        Namespaced_IRI.parse _namespace_name "parent_road" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/Building"></see>
    /// </summary>
    let Building = Namespaced_IRI.parse _namespace_name "Building" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/administrative_building_number"></see>
    /// </summary>
    let administrative_building_number =
        Namespaced_IRI.parse _namespace_name "administrative_building_number" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/MultiFamilyResidentialBuilding"></see>
    /// </summary>
    let MultiFamilyResidentialBuilding =
        Namespaced_IRI.parse _namespace_name "MultiFamilyResidentialBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/PostalCode1970"></see>
    /// </summary>
    let PostalCode1970 =
        Namespaced_IRI.parse _namespace_name "PostalCode1970" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/PostalCode1988"></see>
    /// </summary>
    let PostalCode1988 =
        Namespaced_IRI.parse _namespace_name "PostalCode1988" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/PostalCode2015"></see>
    /// </summary>
    let PostalCode2015 =
        Namespaced_IRI.parse _namespace_name "PostalCode2015" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/RoadNameAddress"></see>
    /// </summary>
    let RoadNameAddress =
        Namespaced_IRI.parse _namespace_name "RoadNameAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/landform"></see>
    /// </summary>
    let landform = Namespaced_IRI.parse _namespace_name "landform" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/floor"></see>
    /// </summary>
    let floor = Namespaced_IRI.parse _namespace_name "floor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/building_number"></see>
    /// </summary>
    let building_number =
        Namespaced_IRI.parse _namespace_name "building_number" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/building_extra_number"></see>
    /// </summary>
    let building_extra_number =
        Namespaced_IRI.parse _namespace_name "building_extra_number" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/eup_myeon_dong_serial_number"></see>
    /// </summary>
    let eup_myeon_dong_serial_number =
        Namespaced_IRI.parse _namespace_name "eup_myeon_dong_serial_number" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/si_do"></see>
    /// </summary>
    let si_do = Namespaced_IRI.parse _namespace_name "si_do" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/si_gun_gu"></see>
    /// </summary>
    let si_gun_gu = Namespaced_IRI.parse _namespace_name "si_gun_gu" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/eup_myeon_dong"></see>
    /// </summary>
    let eup_myeon_dong =
        Namespaced_IRI.parse _namespace_name "eup_myeon_dong" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/ri"></see>
    /// </summary>
    let ri = Namespaced_IRI.parse _namespace_name "ri" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/beonji"></see>
    /// </summary>
    let beonji = Namespaced_IRI.parse _namespace_name "beonji" |> NamespacedName
    /// <summary>
    ///
    ///     Usually, the words "번지" and "호" are not included in the written address;
    ///     instead, only their numbers, separated by a hyphen, are written.
    ///
    /// <see href="http://rdfs.co/juso/kr/ho"></see></summary>
    let ho = Namespaced_IRI.parse _namespace_name "ho" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/Boulevard"></see>
    /// </summary>
    let Boulevard = Namespaced_IRI.parse _namespace_name "Boulevard" |> NamespacedName

    /// <summary>
    ///
    ///     Since Jeju was given more autonomy, cities in Jeju could not be defined by
    ///     the Local Autonomy Law so this new class of city was created for Jeju.
    ///
    /// <see href="http://rdfs.co/juso/kr/AdministrativeCity"></see></summary>
    let AdministrativeCity =
        Namespaced_IRI.parse _namespace_name "AdministrativeCity" |> NamespacedName

    /// <summary>
    ///
    ///     Cities are ranked on the same level as county and autonomous district.
    ///
    /// <see href="http://rdfs.co/juso/kr/City"></see></summary>
    let City = Namespaced_IRI.parse _namespace_name "City" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/RegionalLocalGovernment"></see>
    /// </summary>
    let RegionalLocalGovernment =
        Namespaced_IRI.parse _namespace_name "RegionalLocalGovernment" |> NamespacedName

    /// <summary>
    ///
    ///     In South Korea, a county has a population of less than 150,000 (more than
    ///     that would make it a city), is less densely populated than a district, and
    ///     is more rural in character than either of the other 2 divisions.
    ///
    /// <see href="http://rdfs.co/juso/kr/County"></see></summary>
    let County = Namespaced_IRI.parse _namespace_name "County" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/AutonomousDistrict"></see>
    /// </summary>
    let AutonomousDistrict =
        Namespaced_IRI.parse _namespace_name "AutonomousDistrict" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/NonAutonomousDistrict"></see>
    /// </summary>
    let NonAutonomousDistrict =
        Namespaced_IRI.parse _namespace_name "NonAutonomousDistrict" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/si_gun_gu_code"></see>
    /// </summary>
    let si_gun_gu_code =
        Namespaced_IRI.parse _namespace_name "si_gun_gu_code" |> NamespacedName

    /// <summary>
    ///
    ///     Along with "township", a town is one of the divisions of a county, and of
    ///     some cities with a population of less than 500,000. Towns are subdivided
    ///     into villages.
    ///
    /// <see href="http://rdfs.co/juso/kr/Town"></see></summary>
    let Town = Namespaced_IRI.parse _namespace_name "Town" |> NamespacedName
    /// <summary>
    ///
    ///     Along with town, township is of a county and some cities of fewer than
    ///     500,000 population. Townships have smaller populations than towns and
    ///     represent the rural areas of a county or city. Townships are subdivided
    ///     into villages.
    ///
    /// <see href="http://rdfs.co/juso/kr/Township"></see></summary>
    let Township = Namespaced_IRI.parse _namespace_name "Township" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/LegalStatusNeighborhood"></see>
    /// </summary>
    let LegalStatusNeighborhood =
        Namespaced_IRI.parse _namespace_name "LegalStatusNeighborhood" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/legal_status_neighborhood_code"></see>
    /// </summary>
    let legal_status_neighborhood_code =
        Namespaced_IRI.parse _namespace_name "legal_status_neighborhood_code" |> NamespacedName

    /// <summary>
    ///
    ///     In some cases, a single legal-status neighborhood is divided into several
    ///     administrative neighborhoods. In such cases, each administrative dong has
    ///     its own office and staff.
    ///
    /// <see href="http://rdfs.co/juso/kr/AdministrativeNeighborhood"></see></summary>
    let AdministrativeNeighborhood =
        Namespaced_IRI.parse _namespace_name "AdministrativeNeighborhood" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/Province"></see>
    /// </summary>
    let Province = Namespaced_IRI.parse _namespace_name "Province" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/administrative_neighborhood_code"></see>
    /// </summary>
    let administrative_neighborhood_code =
        Namespaced_IRI.parse _namespace_name "administrative_neighborhood_code" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/eup_myeon_dong_code"></see>
    /// </summary>
    let eup_myeon_dong_code =
        Namespaced_IRI.parse _namespace_name "eup_myeon_dong_code" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/LegalStatusVillage"></see>
    /// </summary>
    let LegalStatusVillage =
        Namespaced_IRI.parse _namespace_name "LegalStatusVillage" |> NamespacedName

    /// <summary>
    ///
    ///     A legal-status village can be subdivided into one or more administrative
    ///     villages.
    ///
    /// <see href="http://rdfs.co/juso/kr/AdministrativeVillage"></see></summary>
    let AdministrativeVillage =
        Namespaced_IRI.parse _namespace_name "AdministrativeVillage" |> NamespacedName

    /// <summary>
    ///
    ///     Jeju is the only special autonomous province in South Korea.
    ///
    /// <see href="http://rdfs.co/juso/kr/SpecialAutonomousProvince"></see></summary>
    let SpecialAutonomousProvince =
        Namespaced_IRI.parse _namespace_name "SpecialAutonomousProvince" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/SpecialCity"></see>
    /// </summary>
    let SpecialCity =
        Namespaced_IRI.parse _namespace_name "SpecialCity" |> NamespacedName

    /// <summary>
    ///
    ///     They were called "directly-administered city" before 1995. These cities
    ///     have equal status to the provinces.
    ///
    /// <see href="http://rdfs.co/juso/kr/MetropolitanCity"></see></summary>
    let MetropolitanCity =
        Namespaced_IRI.parse _namespace_name "MetropolitanCity" |> NamespacedName

    /// <summary>
    ///
    ///     The only metropolitan autonomous city in South Korea called Sejong opened 2
    ///     July 2012.
    ///
    /// <see href="http://rdfs.co/juso/kr/MetropolitanAutonomousCity"></see></summary>
    let MetropolitanAutonomousCity =
        Namespaced_IRI.parse _namespace_name "MetropolitanAutonomousCity" |> NamespacedName

    /// <summary>
    ///
    ///     Non-autonomous districts of municipal cities and administrative cities in
    ///     Jeju are not basic local governments.
    ///
    /// <see href="http://rdfs.co/juso/kr/BasicLocalGovernment"></see></summary>
    let BasicLocalGovernment =
        Namespaced_IRI.parse _namespace_name "BasicLocalGovernment" |> NamespacedName

    /// <summary>
    ///
    ///     Specific city are given powers to subdivide themselves into non-autonomous
    ///     districts but, not all Specific city are subdivided into non-autonomous
    ///     districts.
    ///
    /// <see href="http://rdfs.co/juso/kr/SpecificCity"></see></summary>
    let SpecificCity =
        Namespaced_IRI.parse _namespace_name "SpecificCity" |> NamespacedName
