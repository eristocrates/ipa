#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module juso =
    let _prefixId = PrefixId.fromNamespaceLabel "http://rdfs.co/juso/" "juso"
    let _namespaceIri = _prefixId.prefix ""
    let ``_0.1`` = _prefixId.prefix "0.1"
    /// <summary>
    ///   <para>skos:prefLabel : Addressskos:prefLabel : 주소</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:altLabel : Geographical Addressskos:altLabel : Postal Address</para>
    ///   <para>skos:definition :
    ///     An address is a collection of information, presented in a mostly fixed
    ///     format, used for describing the location of a building, apartment, or other
    ///     structure or a plot of land, generally using political boundaries and
    ///     street names as references, along with other identifiers such as house or
    ///     apartment numbers. Some addresses also contain special codes to aid routing
    ///     of mail and packages, such as a ZIP code or post code.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://rdfs.co/juso/Address">juso:Address</a>
    /// </summary>
    let Address = _prefixId.prefix "Address"
    let AddressGroup = _prefixId.prefix "AddressGroup"
    /// <summary>
    ///   <para>skos:altLabel : Administrative Entityskos:altLabel : Subnational Entityskos:altLabel : Geopolitical Divisionskos:altLabel : Country Subdivisionskos:altLabel : Administrative Unit</para>
    ///   <para>skos:prefLabel : Administrative Division</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     An administrative division is a portion of a country or other region
    ///     delineated for the purpose of administration. Administrative divisions are
    ///     each granted a certain degree of autonomy and are usually required to
    ///     manage themselves through their own local governments.
    ///     </para>
    ///   <a href="http://rdfs.co/juso/AdministrativeDivision">juso:AdministrativeDivision</a>
    /// </summary>
    let AdministrativeDivision = _prefixId.prefix "AdministrativeDivision"
    let Borough = _prefixId.prefix "Borough"
    /// <summary>
    ///   <para>skos:prefLabel : Capital District</para>
    ///   <para>skos:altLabel : Capital Territory</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     A capital district or capital territory is normally a specially designated
    ///     administrative division where a country's seat of government is located.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/CapitalDistrict">juso:CapitalDistrict</a>
    /// </summary>
    let CapitalDistrict = _prefixId.prefix "CapitalDistrict"
    /// <summary>
    ///   <para>skos:definition :
    ///     A city is a large and permanent human settlement. Although there is no
    ///     agreement on how a city is distinguished from a town in general English
    ///     language meanings, many cities have a particular administrative, legal, or
    ///     historical status based on local law.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : 市skos:prefLabel : Cityskos:prefLabel : 시</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/City">juso:City</a>
    /// </summary>
    let City = _prefixId.prefix "City"
    /// <summary>
    ///   <para>skos:prefLabel : Consolidated City-county</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     A consolidated city-county is a city and county that have been merged into
    ///     one unified jurisdiction. As such it is simultaneously a city, which is a
    ///     municipal corporation, and a county, which is an administrative division of
    ///     a state. It has the powers and responsibilities of both types of entities.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/juso/ConsolidatedCityCounty">juso:ConsolidatedCityCounty</a>
    /// </summary>
    let ConsolidatedCityCounty = _prefixId.prefix "ConsolidatedCityCounty"
    let CoreGroup = _prefixId.prefix "CoreGroup"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:altLabel : 国家skos:altLabel : 국가</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 国skos:prefLabel : 나라skos:prefLabel : Country</para>
    ///   <para>skos:definition :
    ///     A country is a region that is identified as a distinct entity in political
    ///     geography. A country may be an independent sovereign state or one that is
    ///     occupied by another state, as a non-sovereign or formerly sovereign
    ///     political division, or a geographic region associated with sets of
    ///     previously independent or differently associated people with distinct
    ///     political characteristics.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/Country">juso:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>skos:prefLabel : 군skos:prefLabel : County</para>
    ///   <para>skos:altLabel : Cnty.skos:altLabel : Co.</para>
    ///   <para>skos:definition :
    ///     A county is a geographical region of a country used for administrative or
    ///     other purposes, in certain modern nations.
    ///     </para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/County">juso:County</a>
    /// </summary>
    let County = _prefixId.prefix "County"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Districtskos:prefLabel : 구</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     A district is a type of administrative division that, in some countries, is
    ///     managed by local government. Across the world, areas known as "districts"
    ///     vary greatly in size, spanning entire regions or counties, several
    ///     municipalities, subdivisions of municipalities, school district, or
    ///     political district.
    ///     </para>
    ///   <a href="http://rdfs.co/juso/District">juso:District</a>
    /// </summary>
    let District = _prefixId.prefix "District"
    /// <summary>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     Geographical features are man-made or naturally-created features associated
    ///     with a location relative to the Earth.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Geographical Feature</para>
    ///   <para>skos:altLabel : Feature</para>
    ///   <a href="http://rdfs.co/juso/Feature">juso:Feature</a>
    /// </summary>
    let Feature = _prefixId.prefix "Feature"
    /// <summary>
    ///   <para>skos:altLabel : 주skos:altLabel : State</para>
    ///   <para>skos:definition :
    ///     A federated state is a territorial and constitutional community forming
    ///     part of a federal union (federation) such as the United States and
    ///     Australia.
    ///     </para>
    ///   <para>skos:prefLabel : Federated Stateskos:prefLabel : 연방주</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/juso/FederatedState">juso:FederatedState</a>
    /// </summary>
    let FederatedState = _prefixId.prefix "FederatedState"

    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:altLabel : Fifth Administrative Levelskos:altLabel : Fifth-order Administrative Division</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     A subdivision of a fourth-level administrative division.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Fifth-level Administrative Division</para>
    ///   <a href="http://rdfs.co/juso/FifthLevelAdministrativeDivision">juso:FifthLevelAdministrativeDivision</a>
    /// </summary>
    let FifthLevelAdministrativeDivision =
        _prefixId.prefix "FifthLevelAdministrativeDivision"

    /// <summary>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     A primary administrative division of a country, such as a state in the
    ///     United States.
    ///     </para>
    ///   <para>skos:prefLabel : First-level Administrative Division</para>
    ///   <para>skos:altLabel : First-order Administrative Divisionskos:altLabel : First Administrative Level</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/FirstLevelAdministrativeDivision">juso:FirstLevelAdministrativeDivision</a>
    /// </summary>
    let FirstLevelAdministrativeDivision =
        _prefixId.prefix "FirstLevelAdministrativeDivision"

    /// <summary>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:altLabel : Fourth Administrative Levelskos:altLabel : Fourth-order Administrative Division</para>
    ///   <para>skos:prefLabel : Fourth-level Administrative Division</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     A subdivision of a third-level administrative division.
    ///     </para>
    ///   <a href="http://rdfs.co/juso/FourthLevelAdministrativeDivision">juso:FourthLevelAdministrativeDivision</a>
    /// </summary>
    let FourthLevelAdministrativeDivision =
        _prefixId.prefix "FourthLevelAdministrativeDivision"

    /// <summary>
    ///   <para>skos:definition :
    ///     Geometry provides "the means for the quantitative description, by means of
    ///     coordinates and mathematical functions, of the spatial characteristics of
    ///     features, including dimension, position, size, shape, and orientation", as
    ///     defined in ISO 19107.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : 기하skos:prefLabel : Geometry</para>
    ///   <a href="http://rdfs.co/juso/Geometry">juso:Geometry</a>
    /// </summary>
    let Geometry = _prefixId.prefix "Geometry"
    /// <summary>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     A hamlet is a type of settlement. The definition of hamlet varies by
    ///     country. It usually refers to a small settlement, with a small population
    ///     that is usually under 100, in a rural area, or a component of a larger
    ///     settlement or municipality. Hamlets are typically unincorporated
    ///     communities.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Hamlet</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/juso/Hamlet">juso:Hamlet</a>
    /// </summary>
    let Hamlet = _prefixId.prefix "Hamlet"
    /// <summary>
    ///   <para>skos:prefLabel : Municipality</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     A municipality is usually an urban administrative division having corporate
    ///     status and usually powers of self-government or jurisdiction.
    ///     </para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/juso/Municipality">juso:Municipality</a>
    /// </summary>
    let Municipality = _prefixId.prefix "Municipality"
    /// <summary>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Neighborhoodskos:prefLabel : Neighbourhoodskos:prefLabel : 동</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     A neighborhood, or neighbourhood, is a geographically localised community
    ///     within a larger city, town, suburb or rural area.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/juso/Neighborhood">juso:Neighborhood</a>
    /// </summary>
    let Neighborhood = _prefixId.prefix "Neighborhood"
    /// <summary>
    ///   <para>skos:definition :
    ///     A parish is an administrative division used by several countries. In parts
    ///     of the British Isles it is known as a civil parish to distinguish it from
    ///     the ecclesiastical parish.
    ///     </para>
    ///   <para>skos:prefLabel : Parish</para>
    ///   <para>skos:altLabel : Civil Parish</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/Parish">juso:Parish</a>
    /// </summary>
    let Parish = _prefixId.prefix "Parish"
    /// <summary>
    ///   <para>skos:definition :
    ///     A political division is a geographic region accepted to be in the
    ///     jurisdiction of a particular governmental entity. The particular government
    ///     entity varies as each organizes its operations by further divisions
    ///     (subdivisions of the state) to further its tasks and satisfy its
    ///     responsibilities.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Political Division</para>
    ///   <a href="http://rdfs.co/juso/PoliticalDivision">juso:PoliticalDivision</a>
    /// </summary>
    let PoliticalDivision = _prefixId.prefix "PoliticalDivision"
    let PoliticalDivisionGroup = _prefixId.prefix "PoliticalDivisionGroup"
    /// <summary>
    ///   <para>skos:prefLabel : Postal Codeskos:prefLabel : 우편번호</para>
    ///   <para>skos:altLabel : Postcodeskos:altLabel : ZIP Codeskos:altLabel : Post Codeskos:altLabel : PIN Codeskos:altLabel : Eircode</para>
    ///   <para>skos:definition :
    ///     A postal code is a series of letters and/or digits, sometimes including
    ///     spaces or punctuation, included in a postal address for the purpose of
    ///     sorting mail.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/juso/PostalCode">juso:PostalCode</a>
    /// </summary>
    let PostalCode = _prefixId.prefix "PostalCode"
    /// <summary>
    ///   <para>skos:prefLabel : Provinceskos:prefLabel : 도</para>
    ///   <para>skos:definition :
    ///     A province is almost always an administrative division, within a country or
    ///     state.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/Province">juso:Province</a>
    /// </summary>
    let Province = _prefixId.prefix "Province"

    /// <summary>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     A subdivision of a first-level administrative division.
    ///     </para>
    ///   <para>skos:altLabel : Second Administrative Levelskos:altLabel : Second-order Administrative Division</para>
    ///   <para>skos:prefLabel : Second-level Administrative Division</para>
    ///   <a href="http://rdfs.co/juso/SecondLevelAdministrativeDivision">juso:SecondLevelAdministrativeDivision</a>
    /// </summary>
    let SecondLevelAdministrativeDivision =
        _prefixId.prefix "SecondLevelAdministrativeDivision"

    /// <summary>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     Anything that has a spatial representation, i.e. size, shape, or position.
    ///     e.g. people, places, objects, as well as abstract areas like cubes.
    ///     </para>
    ///   <para>skos:prefLabel : Spatial Thing</para>
    ///   <para>skos:altLabel : Spatial Object</para>
    ///   <a href="http://rdfs.co/juso/SpatialThing">juso:SpatialThing</a>
    /// </summary>
    let SpatialThing = _prefixId.prefix "SpatialThing"
    /// <summary>
    ///   <para>skos:definition :
    ///     A street is a public thoroughfare (usually paved) in a built environment.
    ///     Practically all public streets in Western countries and the majority
    ///     elsewhere (though not in Japan) are given a street or road name or at least
    ///     a number to identify them and any addresses located along the streets.
    ///     Alleys in some places do not have names.
    ///     </para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Street</para>
    ///   <a href="http://rdfs.co/juso/Street">juso:Street</a>
    /// </summary>
    let Street = _prefixId.prefix "Street"

    /// <summary>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Third-level Administrative Division</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:altLabel : Third Administrative Levelskos:altLabel : Third-order Administrative Division</para>
    ///   <para>skos:definition :
    ///     A subdivision of a second-level administrative division.
    ///     </para>
    ///   <a href="http://rdfs.co/juso/ThirdLevelAdministrativeDivision">juso:ThirdLevelAdministrativeDivision</a>
    /// </summary>
    let ThirdLevelAdministrativeDivision =
        _prefixId.prefix "ThirdLevelAdministrativeDivision"

    /// <summary>
    ///   <para>skos:prefLabel : Thoroughfare</para>
    ///   <para>skos:definition :
    ///     A passage or way through from one location to another, which is usually
    ///     used a component of an address. A thoroughfare is not necessarily a road,
    ///     it might be a waterway or some other feature.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/Thoroughfare">juso:Thoroughfare</a>
    /// </summary>
    let Thoroughfare = _prefixId.prefix "Thoroughfare"
    /// <summary>
    ///   <para>skos:prefLabel : 읍skos:prefLabel : Town</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     A town is a human settlement larger than a village but smaller than a city.
    ///     The size definition for what constitutes a "town" varies considerably in
    ///     different parts of the world.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/Town">juso:Town</a>
    /// </summary>
    let Town = _prefixId.prefix "Town"
    /// <summary>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     The word township is used to refer to different kinds of settlements in
    ///     different countries.
    ///     </para>
    ///   <para>skos:prefLabel : Townshipskos:prefLabel : 면</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/juso/Township">juso:Township</a>
    /// </summary>
    let Township = _prefixId.prefix "Township"
    /// <summary>
    ///   <para>skos:prefLabel : Villageskos:prefLabel : 리</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     A village is a clustered human settlement or community, larger than a
    ///     hamlet but smaller than a town, with a population ranging from a few
    ///     hundred to a few thousand.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/Village">juso:Village</a>
    /// </summary>
    let Village = _prefixId.prefix "Village"
    /// <summary>
    ///   <para>skos:definition :
    ///     This property associates anything with its address.
    ///     </para>
    ///   <para>skos:prefLabel : address</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/address">juso:address</a>
    /// </summary>
    let address = _prefixId.prefix "address"
    /// <summary>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : country</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     The uppermost politial division for the address, almost always a country.
    ///     </para>
    ///   <a href="http://rdfs.co/juso/country">juso:country</a>
    /// </summary>
    let country = _prefixId.prefix "country"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     The endonym is a name given by members of a particular ethnolinguistic
    ///     group to its homeland or a specific place within it.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : endonym</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/endonym">juso:endonym</a>
    /// </summary>
    let endonym = _prefixId.prefix "endonym"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : exonym</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     The exonym is an external name for a geographical place: a common name used
    ///     only outside the place in question, usually for historical reasons.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/exonym">juso:exonym</a>
    /// </summary>
    let exonym = _prefixId.prefix "exonym"

    /// <summary>
    ///   <para>skos:prefLabel : fifth-level administrative division</para>
    ///   <para>skos:definition :
    ///     The fifth-level administrative division of the address, if any.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/fifth_level_administrative_division">juso:fifth_level_administrative_division</a>
    /// </summary>
    let fifth_level_administrative_division =
        _prefixId.prefix "fifth_level_administrative_division"

    /// <summary>
    ///   <para>skos:prefLabel : first-level administrative division</para>
    ///   <para>skos:definition :
    ///     The first-level administrative division (region) of the address, usually a
    ///     county, state or other such area that typically encompasses several
    ///     localities.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/first_level_administrative_division">juso:first_level_administrative_division</a>
    /// </summary>
    let first_level_administrative_division =
        _prefixId.prefix "first_level_administrative_division"

    /// <summary>
    ///   <para>skos:prefLabel : fourth-level administrative division</para>
    ///   <para>skos:definition :
    ///     The fourth-level administrative division of the address, if any.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/fourth_level_administrative_division">juso:fourth_level_administrative_division</a>
    /// </summary>
    let fourth_level_administrative_division =
        _prefixId.prefix "fourth_level_administrative_division"

    /// <summary>
    ///   <para>skos:prefLabel : full address</para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     The complete address written as a string, with or without formatting.
    ///     </para>
    ///   <a href="http://rdfs.co/juso/full_address">juso:full_address</a>
    /// </summary>
    let full_address = _prefixId.prefix "full_address"
    /// <summary>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     This property associates any feature with the corresponding geometry.
    ///     </para>
    ///   <para>skos:prefLabel : geometry</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/juso/geometry">juso:geometry</a>
    /// </summary>
    let geometry = _prefixId.prefix "geometry"
    /// <summary>
    ///   <para>skos:prefLabel : historical address</para>
    ///   <para>skos:definition :
    ///     This property associates anything with one of its historical address.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/historical_address">juso:historical_address</a>
    /// </summary>
    let historical_address = _prefixId.prefix "historical_address"
    /// <summary>
    ///   <para>skos:prefLabel : locator</para>
    ///   <para>skos:definition :
    ///     The real world entity identified by the address. The locator could be the
    ///     property or complex, of the building or part of the building, of it could
    ///     be a room inside a building.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/locator">juso:locator</a>
    /// </summary>
    let locator = _prefixId.prefix "locator"
    /// <summary>
    ///   <para>skos:prefLabel : locator address</para>
    ///   <para>skos:definition :
    ///     This property is used to describe a number or a sequence of characters that
    ///     uniquely identifies the exact locator within the relevant scope(s), that is
    ///     described by juso:locator.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/locator_address">juso:locator_address</a>
    /// </summary>
    let locator_address = _prefixId.prefix "locator_address"
    /// <summary>
    ///   <para>skos:prefLabel : 이름skos:prefLabel : name</para>
    ///   <para>skos:definition :
    ///     This property indicates the name of the spatial thing.
    ///     </para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/name">juso:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>skos:prefLabel : parent politial division</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     A politial or administrative division that is a direct parent of the
    ///     current feature.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/juso/parent">juso:parent</a>
    /// </summary>
    let parent = _prefixId.prefix "parent"
    let po_box = _prefixId.prefix "po_box"
    let political_division = _prefixId.prefix "political_division"
    /// <summary>
    ///   <para>skos:prefLabel : post office box</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     This property describes the post office box number for PO box addresses.
    ///     A post-office box or post office box (commonly referred to as a PO box or a
    ///     postal box) is a uniquely addressable lockable box located on the premises
    ///     of a post office station.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/post_office_box">juso:post_office_box</a>
    /// </summary>
    let post_office_box = _prefixId.prefix "post_office_box"
    /// <summary>
    ///   <para>skos:prefLabel : postal code</para>
    ///   <para>skos:definition :
    ///     This property associates any address with its postal code.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/postal_code">juso:postal_code</a>
    /// </summary>
    let postal_code = _prefixId.prefix "postal_code"

    /// <summary>
    ///   <para>skos:prefLabel : second-level administrative division</para>
    ///   <para>skos:definition :
    ///     The second-level administrative division (locality) of the address, usually
    ///     a city.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/second_level_administrative_division">juso:second_level_administrative_division</a>
    /// </summary>
    let second_level_administrative_division =
        _prefixId.prefix "second_level_administrative_division"

    /// <summary>
    ///   <para>skos:prefLabel : third-level administrative division</para>
    ///   <para>skos:definition :
    ///     The third-level administrative division of the address, if any.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/third_level_administrative_division">juso:third_level_administrative_division</a>
    /// </summary>
    let third_level_administrative_division =
        _prefixId.prefix "third_level_administrative_division"

    /// <summary>
    ///   <para>skos:prefLabel : thoroughfare</para>
    ///   <para>skos:definition :
    ///     An address component that represents the name of a passage or way through
    ///     from one location to another. A thoroughfare is not necessarily a road, it
    ///     might be a waterway or some other feature.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/thoroughfare">juso:thoroughfare</a>
    /// </summary>
    let thoroughfare = _prefixId.prefix "thoroughfare"
    /// <summary>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : thoroughfare address</para>
    ///   <para>skos:definition :
    ///     This property is used to describe a unique number given to each building
    ///     (residential or not) or vacant lot with a mailbox in a street or other
    ///     thoroughfares.
    ///     </para>
    ///   <a href="http://rdfs.co/juso/thoroughfare_address">juso:thoroughfare_address</a>
    /// </summary>
    let thoroughfare_address = _prefixId.prefix "thoroughfare_address"
    let within = _prefixId.prefix "within"
