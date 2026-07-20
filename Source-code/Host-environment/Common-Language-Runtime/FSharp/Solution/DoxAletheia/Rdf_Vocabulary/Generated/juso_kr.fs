namespace http.rdfs.co.juso.kr.slash

open DoxAletheia

module juso_kr =
    let _namespace_name = "http://rdfs.co/juso/kr/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

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
    let ``_0.1`` = _prefix "0.1"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/0.1/html"></see>
    /// </summary>
    let ``_0.1/html`` = _prefix "0.1/html"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/0.1/rdf"></see>
    /// </summary>
    let ``_0.1/rdf`` = _prefix "0.1/rdf"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/0.1/ttl"></see>
    /// </summary>
    let ``_0.1/ttl`` = _prefix "0.1/ttl"
    /// <summary>
    ///
    ///      These classes and properties are used to describe addresses in South Korea.
    ///
    /// <see href="http://rdfs.co/juso/kr/AddressGroup"></see></summary>
    let AddressGroup = _prefix "AddressGroup"
    /// <summary>
    ///
    ///     These classes and properties are used to describe administrative divisions
    ///     in South Korea.
    ///
    /// <see href="http://rdfs.co/juso/kr/AdministrativeDivisionGroup"></see></summary>
    let AdministrativeDivisionGroup = _prefix "AdministrativeDivisionGroup"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/EastAsianAddress"></see>
    /// </summary>
    let EastAsianAddress = _prefix "EastAsianAddress"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/Street"></see>
    /// </summary>
    let Street = _prefix "Street"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/Road"></see>
    /// </summary>
    let Road = _prefix "Road"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/road_name_number"></see>
    /// </summary>
    let road_name_number = _prefix "road_name_number"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/parent_road"></see>
    /// </summary>
    let parent_road = _prefix "parent_road"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/Building"></see>
    /// </summary>
    let Building = _prefix "Building"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/administrative_building_number"></see>
    /// </summary>
    let administrative_building_number = _prefix "administrative_building_number"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/MultiFamilyResidentialBuilding"></see>
    /// </summary>
    let MultiFamilyResidentialBuilding = _prefix "MultiFamilyResidentialBuilding"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/PostalCode1970"></see>
    /// </summary>
    let PostalCode1970 = _prefix "PostalCode1970"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/PostalCode1988"></see>
    /// </summary>
    let PostalCode1988 = _prefix "PostalCode1988"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/PostalCode2015"></see>
    /// </summary>
    let PostalCode2015 = _prefix "PostalCode2015"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/RoadNameAddress"></see>
    /// </summary>
    let RoadNameAddress = _prefix "RoadNameAddress"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/landform"></see>
    /// </summary>
    let landform = _prefix "landform"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/floor"></see>
    /// </summary>
    let floor = _prefix "floor"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/building_number"></see>
    /// </summary>
    let building_number = _prefix "building_number"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/building_extra_number"></see>
    /// </summary>
    let building_extra_number = _prefix "building_extra_number"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/eup_myeon_dong_serial_number"></see>
    /// </summary>
    let eup_myeon_dong_serial_number = _prefix "eup_myeon_dong_serial_number"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/si_do"></see>
    /// </summary>
    let si_do = _prefix "si_do"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/si_gun_gu"></see>
    /// </summary>
    let si_gun_gu = _prefix "si_gun_gu"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/eup_myeon_dong"></see>
    /// </summary>
    let eup_myeon_dong = _prefix "eup_myeon_dong"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/ri"></see>
    /// </summary>
    let ri = _prefix "ri"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/beonji"></see>
    /// </summary>
    let beonji = _prefix "beonji"
    /// <summary>
    ///
    ///     Usually, the words "번지" and "호" are not included in the written address;
    ///     instead, only their numbers, separated by a hyphen, are written.
    ///
    /// <see href="http://rdfs.co/juso/kr/ho"></see></summary>
    let ho = _prefix "ho"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/Boulevard"></see>
    /// </summary>
    let Boulevard = _prefix "Boulevard"
    /// <summary>
    ///
    ///     Since Jeju was given more autonomy, cities in Jeju could not be defined by
    ///     the Local Autonomy Law so this new class of city was created for Jeju.
    ///
    /// <see href="http://rdfs.co/juso/kr/AdministrativeCity"></see></summary>
    let AdministrativeCity = _prefix "AdministrativeCity"
    /// <summary>
    ///
    ///     Cities are ranked on the same level as county and autonomous district.
    ///
    /// <see href="http://rdfs.co/juso/kr/City"></see></summary>
    let City = _prefix "City"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/RegionalLocalGovernment"></see>
    /// </summary>
    let RegionalLocalGovernment = _prefix "RegionalLocalGovernment"
    /// <summary>
    ///
    ///     In South Korea, a county has a population of less than 150,000 (more than
    ///     that would make it a city), is less densely populated than a district, and
    ///     is more rural in character than either of the other 2 divisions.
    ///
    /// <see href="http://rdfs.co/juso/kr/County"></see></summary>
    let County = _prefix "County"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/AutonomousDistrict"></see>
    /// </summary>
    let AutonomousDistrict = _prefix "AutonomousDistrict"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/NonAutonomousDistrict"></see>
    /// </summary>
    let NonAutonomousDistrict = _prefix "NonAutonomousDistrict"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/si_gun_gu_code"></see>
    /// </summary>
    let si_gun_gu_code = _prefix "si_gun_gu_code"
    /// <summary>
    ///
    ///     Along with "township", a town is one of the divisions of a county, and of
    ///     some cities with a population of less than 500,000. Towns are subdivided
    ///     into villages.
    ///
    /// <see href="http://rdfs.co/juso/kr/Town"></see></summary>
    let Town = _prefix "Town"
    /// <summary>
    ///
    ///     Along with town, township is of a county and some cities of fewer than
    ///     500,000 population. Townships have smaller populations than towns and
    ///     represent the rural areas of a county or city. Townships are subdivided
    ///     into villages.
    ///
    /// <see href="http://rdfs.co/juso/kr/Township"></see></summary>
    let Township = _prefix "Township"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/LegalStatusNeighborhood"></see>
    /// </summary>
    let LegalStatusNeighborhood = _prefix "LegalStatusNeighborhood"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/legal_status_neighborhood_code"></see>
    /// </summary>
    let legal_status_neighborhood_code = _prefix "legal_status_neighborhood_code"
    /// <summary>
    ///
    ///     In some cases, a single legal-status neighborhood is divided into several
    ///     administrative neighborhoods. In such cases, each administrative dong has
    ///     its own office and staff.
    ///
    /// <see href="http://rdfs.co/juso/kr/AdministrativeNeighborhood"></see></summary>
    let AdministrativeNeighborhood = _prefix "AdministrativeNeighborhood"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/Province"></see>
    /// </summary>
    let Province = _prefix "Province"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/administrative_neighborhood_code"></see>
    /// </summary>
    let administrative_neighborhood_code = _prefix "administrative_neighborhood_code"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/eup_myeon_dong_code"></see>
    /// </summary>
    let eup_myeon_dong_code = _prefix "eup_myeon_dong_code"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/LegalStatusVillage"></see>
    /// </summary>
    let LegalStatusVillage = _prefix "LegalStatusVillage"
    /// <summary>
    ///
    ///     A legal-status village can be subdivided into one or more administrative
    ///     villages.
    ///
    /// <see href="http://rdfs.co/juso/kr/AdministrativeVillage"></see></summary>
    let AdministrativeVillage = _prefix "AdministrativeVillage"
    /// <summary>
    ///
    ///     Jeju is the only special autonomous province in South Korea.
    ///
    /// <see href="http://rdfs.co/juso/kr/SpecialAutonomousProvince"></see></summary>
    let SpecialAutonomousProvince = _prefix "SpecialAutonomousProvince"
    /// <summary>
    ///   <see href="http://rdfs.co/juso/kr/SpecialCity"></see>
    /// </summary>
    let SpecialCity = _prefix "SpecialCity"
    /// <summary>
    ///
    ///     They were called "directly-administered city" before 1995. These cities
    ///     have equal status to the provinces.
    ///
    /// <see href="http://rdfs.co/juso/kr/MetropolitanCity"></see></summary>
    let MetropolitanCity = _prefix "MetropolitanCity"
    /// <summary>
    ///
    ///     The only metropolitan autonomous city in South Korea called Sejong opened 2
    ///     July 2012.
    ///
    /// <see href="http://rdfs.co/juso/kr/MetropolitanAutonomousCity"></see></summary>
    let MetropolitanAutonomousCity = _prefix "MetropolitanAutonomousCity"
    /// <summary>
    ///
    ///     Non-autonomous districts of municipal cities and administrative cities in
    ///     Jeju are not basic local governments.
    ///
    /// <see href="http://rdfs.co/juso/kr/BasicLocalGovernment"></see></summary>
    let BasicLocalGovernment = _prefix "BasicLocalGovernment"
    /// <summary>
    ///
    ///     Specific city are given powers to subdivide themselves into non-autonomous
    ///     districts but, not all Specific city are subdivided into non-autonomous
    ///     districts.
    ///
    /// <see href="http://rdfs.co/juso/kr/SpecificCity"></see></summary>
    let SpecificCity = _prefix "SpecificCity"
