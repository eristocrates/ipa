#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``juso.kr`` =
    let _prefixId = PrefixId.fromNamespaceLabel "http://rdfs.co/juso/kr/" "juso.kr"
    let _namespaceIri = _prefixId.prefix ""
    let ``_0.1`` = _prefixId.prefix "0.1"
    let AddressGroup = _prefixId.prefix "AddressGroup"
    /// <summary>
    ///   <para>rdfs:comment :
    ///     Since Jeju was given more autonomy, cities in Jeju could not be defined by
    ///     the Local Autonomy Law so this new class of city was created for Jeju.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     행정시(行政市)는 대한민국의 행정 구역 중 하나로, 지방자치법 시행 이후 기초자치단체인 자치시로
    ///     전환되면서 사실상 행정시의 기능은 완전히 사라졌다가 특별자치도 제도의 도입으로 제주특별자치도가
    ///     2006년 7월 1일 출범하면서 행정시가 다시 나타났다.
    ///     skos:definition :
    ///     An Administrative city is a type of municipal city that are created in 1
    ///     July 2006 after the 2005 referendum in Jeju and the province was given
    ///     extensive administrative powers that had previously been reserved for the
    ///     central government.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 행정시skos:prefLabel : Administrative City</para>
    ///   <a href="http://rdfs.co/juso/kr/AdministrativeCity">juso.kr:AdministrativeCity</a>
    /// </summary>
    let AdministrativeCity = _prefixId.prefix "AdministrativeCity"
    let AdministrativeDivisionGroup = _prefixId.prefix "AdministrativeDivisionGroup"
    /// <summary>
    ///   <para>skos:definition :
    ///     An administrative neighborhood is the smallest level of urban government to
    ///     have its own office and staff in South Korea.
    ///     skos:definition :
    ///     행정동(行政洞)은 대한민국의 행정 구역의 하나로 구 또는 시의 하부 행정 구역이다.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>rdfs:comment :
    ///     In some cases, a single legal-status neighborhood is divided into several
    ///     administrative neighborhoods. In such cases, each administrative dong has
    ///     its own office and staff.
    ///     </para>
    ///   <para>skos:prefLabel : Administrative Neighborhoodskos:prefLabel : 행정동</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/juso/kr/AdministrativeNeighborhood">juso.kr:AdministrativeNeighborhood</a>
    /// </summary>
    let AdministrativeNeighborhood = _prefixId.prefix "AdministrativeNeighborhood"
    /// <summary>
    ///   <para>rdfs:comment :
    ///     A legal-status village can be subdivided into one or more administrative
    ///     villages.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     대한민국의 리(里)는 읍(邑)·면(面)의 하부 행정 구역이며, 행정리(行政里)는 인구와 생활권을 고려하여
    ///     법정리에 1개 또는 여러 개로 설치한 행정 구역이다.
    ///     skos:definition :
    ///     A administrative village is an administrative unit in South Korea.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 행정리skos:prefLabel : Administrative Village</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/AdministrativeVillage">juso.kr:AdministrativeVillage</a>
    /// </summary>
    let AdministrativeVillage = _prefixId.prefix "AdministrativeVillage"
    /// <summary>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Autonomous Districtskos:prefLabel : 자치구</para>
    ///   <para>skos:definition :
    ///     An autonomous district of special and metropolitan cities is a municipal
    ///     entity similar to a city with its own mayor along with its own
    ///     legislative council.
    ///     skos:definition :
    ///     자치구(自治區)는 특별시, 광역시의 하위 행정 구역으로서 시, 군과 동급인 기초자치단체이다.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/juso/kr/AutonomousDistrict">juso.kr:AutonomousDistrict</a>
    /// </summary>
    let AutonomousDistrict = _prefixId.prefix "AutonomousDistrict"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     대한민국의 기초지방자치단체(基礎地方自治團體)는 지방자치단체에서 광역지방자치단체의 하부의
    ///     조직으로서 광역지방자치단체보다 좁은 지역을 관할하는 지방 행정 조직이다.
    ///     skos:definition :
    ///     Basic local governments are the municipal-level administrative division
    ///     within South Korea.
    ///     </para>
    ///   <para>skos:altLabel : Municipalityskos:altLabel : Lower-level Local Autonomyskos:altLabel : Municipal Government</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 기초지방자치단체skos:prefLabel : Basic Local Government</para>
    ///   <para>rdfs:comment :
    ///     Non-autonomous districts of municipal cities and administrative cities in
    ///     Jeju are not basic local governments.
    ///     </para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/BasicLocalGovernment">juso.kr:BasicLocalGovernment</a>
    /// </summary>
    let BasicLocalGovernment = _prefixId.prefix "BasicLocalGovernment"
    /// <summary>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     도로명주소에서 대로(大路)는 폭이 40m 이상이거나 왕복 8차선 이상의 도로를 의미한다.
    ///     skos:definition :
    ///     In the Road Name Address system, the word boulevard (daero) is used to
    ///     describe two-way roads that have more than 40m width or 8 lanes.
    ///     </para>
    ///   <para>skos:prefLabel : Boulevardskos:prefLabel : 대로</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/juso/kr/Boulevard">juso.kr:Boulevard</a>
    /// </summary>
    let Boulevard = _prefixId.prefix "Boulevard"
    /// <summary>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:altLabel : 건축물skos:altLabel : 구축물</para>
    ///   <para>skos:prefLabel : Buildingskos:prefLabel : 건물</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     일반적으로 건물(建物)이란 일정 기간 동안 그 형상이 필요하기 때문에, 혹은 그것이 제공하는 공간이
    ///     필요하기 때문에, 인간이 지은 지면에 고정되는 구조물을 뜻한다.
    ///     skos:definition :
    ///     A building is a man-made structure with a roof and walls standing more or
    ///     less permanently in one place, such as a house or factory.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/Building">juso.kr:Building</a>
    /// </summary>
    let Building = _prefixId.prefix "Building"
    /// <summary>
    ///   <para>skos:prefLabel : 시skos:prefLabel : City</para>
    ///   <para>skos:definition :
    ///     A city is a municipal administrative unit in South Korea.
    ///     skos:definition :
    ///     시(市)는 대한민국 행정 구역의 하나로 행정시와 달리 기초지방자치단체에 해당한다.
    ///     </para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>rdfs:comment :
    ///     Cities are ranked on the same level as county and autonomous district.
    ///   </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/City">juso.kr:City</a>
    /// </summary>
    let City = _prefixId.prefix "City"
    /// <summary>
    ///   <para>skos:definition :
    ///     A county is an administrative unit in South Korea similar.
    ///     skos:definition :
    ///     군(郡)은 행정 구역의 하나로, 대한민국의 군은 도 및 광역시의 하부 행정 구역이자 기초지방자치단체이다.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 군skos:prefLabel : County</para>
    ///   <para>rdfs:comment :
    ///     In South Korea, a county has a population of less than 150,000 (more than
    ///     that would make it a city), is less densely populated than a district, and
    ///     is more rural in character than either of the other 2 divisions.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/County">juso.kr:County</a>
    /// </summary>
    let County = _prefixId.prefix "County"
    /// <summary>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : East Asian Addressskos:prefLabel : 지번 주소</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     기존 대한민국에서 사용되던 지번 주소 체계는 토지 구획을 정리한 지번을 구분자로 이용하는 주소 체계로
    ///     아직 널리 사용되고 있으나 2014년 1월 1일부터 도로명주소로 대체되어 공식적으로 폐지되었다.
    ///     skos:definition :
    ///     The previous addressing system used in South Korea was the the East Asian
    ///     system, which is also used in Japan and North Korea (but not within the
    ///       Chinese-speaking world), but although still commonly used, is no longer
    ///     officially recognized since December 31, 2013.
    ///     </para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://rdfs.co/juso/kr/EastAsianAddress">juso.kr:EastAsianAddress</a>
    /// </summary>
    let EastAsianAddress = _prefixId.prefix "EastAsianAddress"
    /// <summary>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     법정동(法定洞)은 대한민국 법정 구역으로, 법률(관습법)로 지정된 일정한 명칭과 영역을 지닌
    ///     구역이다.
    ///     skos:definition :
    ///     A legal-status neighborhood is a submunicipal level administrative unit of
    ///     a city and of those cities which are not divided into districts throughout
    ///     Korea.
    ///     </para>
    ///   <para>skos:prefLabel : 법정동skos:prefLabel : Legal-status Neighborhood</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/LegalStatusNeighborhood">juso.kr:LegalStatusNeighborhood</a>
    /// </summary>
    let LegalStatusNeighborhood = _prefixId.prefix "LegalStatusNeighborhood"
    /// <summary>
    ///   <para>skos:prefLabel : 법정리skos:prefLabel : Legal-status Village</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     대한민국의 리(里)는 읍(邑)·면(面)의 하부 행정 구역이며, 법정리(法定里)는 법령으로 정하여진 리로
    ///     지번의 기준이 된다.
    ///     skos:definition :
    ///     A legal-status village is an administrative unit in South Korea.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/juso/kr/LegalStatusVillage">juso.kr:LegalStatusVillage</a>
    /// </summary>
    let LegalStatusVillage = _prefixId.prefix "LegalStatusVillage"
    /// <summary>
    ///   <para>skos:prefLabel : Metropolitan Autonomous Cityskos:prefLabel : 특별자치시</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     특별자치시(特別自治市)는 대한민국의 행정 구역이다.
    ///     skos:definition :
    ///     In early 2007, the South Korean government created a special administrative
    ///     district from parts of South Chungcheong and North Chungcheong provinces,
    ///     near Daejeon, to relocate nine ministries and four national agencies from
    ///     Seoul.
    ///     </para>
    ///   <para>rdfs:comment :
    ///     The only metropolitan autonomous city in South Korea called Sejong opened 2
    ///     July 2012.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/juso/kr/MetropolitanAutonomousCity">juso.kr:MetropolitanAutonomousCity</a>
    /// </summary>
    let MetropolitanAutonomousCity = _prefixId.prefix "MetropolitanAutonomousCity"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     Metropolitan cities are the highest-ranked administrative divisions in
    ///     South Korea.
    ///     skos:definition :
    ///     광역시(廣域市)는 대한민국의 행정 구역이다.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>rdfs:comment :
    ///     They were called "directly-administered city" before 1995. These cities
    ///     have equal status to the provinces.
    ///     </para>
    ///   <para>skos:prefLabel : Metropolitan Cityskos:prefLabel : 광역시</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/MetropolitanCity">juso.kr:MetropolitanCity</a>
    /// </summary>
    let MetropolitanCity = _prefixId.prefix "MetropolitanCity"

    /// <summary>
    ///   <para>skos:definition :
    ///     A multifamily residential building is a building that contain multiple
    ///     separate housing units for residential inhabitants.
    ///     skos:definition :
    ///     공동 주택(共同住宅)은 하나의 건물 내에 서로 독립적인 여러 세대가 공동으로 거주하는 주거의
    ///     형태이다.
    ///     </para>
    ///   <para>skos:prefLabel : 공동 주택skos:prefLabel : Multi-family Residential Building</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:altLabel : Multi-dwelling Unit Buildingskos:altLabel : MDU Building</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/MultiFamilyResidentialBuilding">juso.kr:MultiFamilyResidentialBuilding</a>
    /// </summary>
    let MultiFamilyResidentialBuilding =
        _prefixId.prefix "MultiFamilyResidentialBuilding"

    /// <summary>
    ///   <para>skos:altLabel : 행정구skos:altLabel : Administrative District</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     자치구가 아닌 일반구(一般區)는 인구 50만 명 이상인 시(기초자치단체)의 하위 행정 구역이다.
    ///     skos:definition :
    ///     Cities with over 500,000 people are allowed to have non-autonomous
    ///     districts (notable exceptions to this rule are the cities of Gimhae,
    ///     Hwaseong, and Namyangju).
    ///     </para>
    ///   <para>skos:prefLabel : 일반구skos:prefLabel : Non-autonomous District</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/juso/kr/NonAutonomousDistrict">juso.kr:NonAutonomousDistrict</a>
    /// </summary>
    let NonAutonomousDistrict = _prefixId.prefix "NonAutonomousDistrict"
    /// <summary>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Postal Code (1970 - 1988)skos:prefLabel : 우편번호(1970 ~ 1988)</para>
    ///   <para>skos:definition :
    ///     The first 5-digit postal code system in South Korea that was rolled out on
    ///     July 1, 1970, and used until January 31, 1988.
    ///     skos:definition :
    ///     1970년 7월 1일에 도입되어 1988년 1월 31일까지 사용된 대한민국 최초의 5자리 우편번호.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/PostalCode1970">juso.kr:PostalCode1970</a>
    /// </summary>
    let PostalCode1970 = _prefixId.prefix "PostalCode1970"
    /// <summary>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     The 6-digit postal code system in South Korea that was rolled out on
    ///     February 1, 1988, and used until July 31, 2015.
    ///     skos:definition :
    ///     1988년 2월 1일에 도입되어 2015년 7월 31일까지 사용된 대한민국의 6자리 우편번호.
    ///     </para>
    ///   <para>skos:prefLabel : 우편번호(1988 ~ 2015)skos:prefLabel : Postal Code (1988 - 2015)</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/PostalCode1988">juso.kr:PostalCode1988</a>
    /// </summary>
    let PostalCode1988 = _prefixId.prefix "PostalCode1988"
    /// <summary>
    ///   <para>skos:definition :
    ///     2015년 8월 1일에 도입된 도로명주소 체계 기반 5자리 대한민국 우편번호.
    ///     skos:definition :
    ///     The 5-digit postal code system based on the road name address system in
    ///     South Korea, which has been rolled out on August 1, 2015.
    ///     </para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Postal Code (1988 - 2015)skos:prefLabel : 우편번호(1988 ~ 2015)</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/juso/kr/PostalCode2015">juso.kr:PostalCode2015</a>
    /// </summary>
    let PostalCode2015 = _prefixId.prefix "PostalCode2015"
    /// <summary>
    ///   <para>skos:definition :
    ///     도(道)는 대한민국의 행정 구역 이름으로 특별자치도와 구분된다.
    ///     skos:definition :
    ///     A province are the highest-ranked administrative divisions in South Korea.
    ///     </para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Provinceskos:prefLabel : 도</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:altLabel : 일반도</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/Province">juso.kr:Province</a>
    /// </summary>
    let Province = _prefixId.prefix "Province"
    /// <summary>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 광역지방자치단체skos:prefLabel : Regional Local Government</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     Regional local governments are the highest-ranked administrative division
    ///     within South Korea.
    ///     skos:definition :
    ///     대한민국의 광역지방자치단체(廣域地方自治團體)는 지방자치단체 중 기초지방자치단체에 비해 넓은 구역과
    ///     많은 주민을 관할하는 기초지방자치단체 상위의 행정 구역이다.
    ///     </para>
    ///   <para>skos:altLabel : Metropolitan Governmentskos:altLabel : Upper-level Local Autonomy</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/juso/kr/RegionalLocalGovernment">juso.kr:RegionalLocalGovernment</a>
    /// </summary>
    let RegionalLocalGovernment = _prefixId.prefix "RegionalLocalGovernment"
    /// <summary>
    ///   <para>skos:definition :
    ///     도로명주소에서 길은 폭이 12m 미만이거나 2차로 미만인 도로를 의미한다.
    ///     skos:definition :
    ///     In the Road Name Address system, the word road (gil) is used to describe
    ///     roads that have less than 12m width or 2 lanes.
    ///     width or 2 lanes.
    ///     </para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : Roadskos:prefLabel : 길</para>
    ///   <a href="http://rdfs.co/juso/kr/Road">juso.kr:Road</a>
    /// </summary>
    let Road = _prefixId.prefix "Road"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 도로명주소skos:prefLabel : Road Name Address</para>
    ///   <para>skos:definition :
    ///     대한민국의 도로명주소란 부여된 도로명, 기초번호, 건물번호, 상세주소에 의하여 건물의 주소를 표기하는
    ///     방식으로 2014년부터 사용되고 있다.
    ///     skos:definition :
    ///     The Road Name Address system, rolled out on January 1, 2014, uses street
    ///     names and house numbers, and is similar to the systems used by the United
    ///     States, Canada, and Europe.
    ///     </para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/RoadNameAddress">juso.kr:RoadNameAddress</a>
    /// </summary>
    let RoadNameAddress = _prefixId.prefix "RoadNameAddress"
    /// <summary>
    ///   <para>rdfs:comment :
    ///     Jeju is the only special autonomous province in South Korea.
    ///     </para>
    ///   <para>skos:definition :
    ///     A special autonomous province is a province with more autonomy over its
    ///     economy and more powers are given to the provincial government.
    ///     skos:definition :
    ///     특별자치도(特別自治道)는 대한민국의 행정 구역으로, 일반 도(道)와 기능적으로 거의 동일하지만,
    ///     관련 법률에 의거해 고도의 자치권이 보장된다.
    ///     </para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Special Autonomous Provinceskos:prefLabel : 특별자치도</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:altLabel : Special Self-governing Province</para>
    ///   <a href="http://rdfs.co/juso/kr/SpecialAutonomousProvince">juso.kr:SpecialAutonomousProvince</a>
    /// </summary>
    let SpecialAutonomousProvince = _prefixId.prefix "SpecialAutonomousProvince"
    /// <summary>
    ///   <para>skos:prefLabel : Special Cityskos:prefLabel : 특별시</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     특별시(特別市)는 대한민국의 행정 구역으로 서울특별시가 유일하다.
    ///     skos:definition :
    ///     Seoul was designated a "special free city" separate from Gyeonggi Province
    ///     on August 15, 1946; it became a "special city" on August 15, 1949.
    ///     </para>
    ///   <a href="http://rdfs.co/juso/kr/SpecialCity">juso.kr:SpecialCity</a>
    /// </summary>
    let SpecialCity = _prefixId.prefix "SpecialCity"
    /// <summary>
    ///   <para>rdfs:comment :
    ///     Specific city are given powers to subdivide themselves into non-autonomous
    ///     districts but, not all Specific city are subdivided into non-autonomous
    ///     districts.
    ///   </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : Specific Cityskos:prefLabel : 특정시</para>
    ///   <para>skos:definition :
    ///     특정시(特定市)는 대한민국의 광역자치단체인 도에 소속된 기초자치단체 중 지방자치법 제175조에 따라
    ///     도지사의 권한 일부가 시장에게 위임된 시를 비공식적으로 일컫는 명칭으로 지방자치법에서는 이를 인구
    ///     50만 이상 대도시라고 규정하고 있다.
    ///     skos:definition :
    ///     A Specific city is a municipal city that has a population greater than
    ///     500,000 and has been designated as such by an order of the National
    ///     Government under Article 175 of the Local Autonomy Law.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/SpecificCity">juso.kr:SpecificCity</a>
    /// </summary>
    let SpecificCity = _prefixId.prefix "SpecificCity"
    /// <summary>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     In the Road Name Address system, the word street (ro) is used to
    ///     describe two-way roads that are narrower than roads but have more than 12m
    ///     width or 2 lanes.
    ///     skos:definition :
    ///     도로명주소에서 로(路)는 대로보다 작지만 폭이 12m 이상이거나 왕복 2차선 이상의 도로를
    ///     의미한다.
    ///     </para>
    ///   <para>skos:prefLabel : Streetskos:prefLabel : 로</para>
    ///   <a href="http://rdfs.co/juso/kr/Street">juso.kr:Street</a>
    /// </summary>
    let Street = _prefixId.prefix "Street"
    /// <summary>
    ///   <para>rdfs:comment :
    ///     Along with "township", a town is one of the divisions of a county, and of
    ///     some cities with a population of less than 500,000. Towns are subdivided
    ///     into villages.
    ///     </para>
    ///   <para>skos:definition :
    ///     대한민국의 읍(邑)은 시·군·구의 하부 행정 구역이다.
    ///     skos:definition :
    ///     A town is an administrative unit in South Korea.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 읍skos:prefLabel : Town</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/juso/kr/Town">juso.kr:Town</a>
    /// </summary>
    let Town = _prefixId.prefix "Town"
    /// <summary>
    ///   <para>rdfs:comment :
    ///     Along with town, township is of a county and some cities of fewer than
    ///     500,000 population. Townships have smaller populations than towns and
    ///     represent the rural areas of a county or city. Townships are subdivided
    ///     into villages.
    ///     </para>
    ///   <para>skos:prefLabel : Townshipskos:prefLabel : 면</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     면(面)은 대한민국의 자치시·군 또는 행정시의 하부 행정 구역 이름이다.
    ///     skos:definition :
    ///     A township is an administrative unit in South Korea.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/Township">juso.kr:Township</a>
    /// </summary>
    let Township = _prefixId.prefix "Township"

    /// <summary>
    ///   <para>skos:definition :
    ///     Each building is given a number for administration.
    ///     skos:definition :
    ///     건물은 관리 번호를 부여 받는다.
    ///     </para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : 건물 관리 번호skos:prefLabel : administrative building number</para>
    ///   <a href="http://rdfs.co/juso/kr/administrative_building_number">juso.kr:administrative_building_number</a>
    /// </summary>
    let administrative_building_number =
        _prefixId.prefix "administrative_building_number"

    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : administrative neighborhood codeskos:prefLabel : 행정동코드</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     행정동에 부여된 행정 표준 코드.
    ///     skos:definition :
    ///     The unique administrative code for the administrative neighborhood.
    ///     </para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/administrative_neighborhood_code">juso.kr:administrative_neighborhood_code</a>
    /// </summary>
    let administrative_neighborhood_code =
        _prefixId.prefix "administrative_neighborhood_code"

    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     Each neighborhood is divided into city blocks (beonji), which can range
    ///     from several dozen to several thousand per neighborhood.
    ///     skos:definition :
    ///     번지(番地)는 토지를 구획할 때 어떤 특정한 토지에 붙이는 번호를 의미하는 지번이다.
    ///     </para>
    ///   <para>skos:prefLabel : beonjiskos:prefLabel : 번지</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/beonji">juso.kr:beonji</a>
    /// </summary>
    let beonji = _prefixId.prefix "beonji"
    /// <summary>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 건물 부 번호skos:prefLabel : building extra number</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     건물 번호는 본 번과 부 번으로 구성되는데, 한 건물이 두 개의 도로와 인접해 있을 경우, 보다 넓은
    ///     도로로 건물 번호를 부여하고, 한 구간 내 여러 건물이 위치하고 있을 경우 -1, -2, -3처럼 부
    ///     번을 부여하여 본 번을 부여받은 건물과 구별한다.
    ///     skos:definition :
    ///     Buildings on a street or alley that is too small or too short to receive
    ///     a name of its own share the same building number, followed by a hyphen,
    ///     followed by a unique extra number afterwards.
    ///     </para>
    ///   <para>skos:altLabel : 건물 부 번</para>
    ///   <a href="http://rdfs.co/juso/kr/building_extra_number">juso.kr:building_extra_number</a>
    /// </summary>
    let building_extra_number = _prefixId.prefix "building_extra_number"
    /// <summary>
    ///   <para>skos:prefLabel : building numberskos:prefLabel : 건물 번호</para>
    ///   <para>skos:definition :
    ///     Buildings are numbered along a street with even numbers on one side and odd
    ///     numbers on the other, as in most European countries.
    ///     skos:definition :
    ///     건물 번호는 건물마다 부여된 번호로 건물번호 도로의 시작점으로부터 왼편에는 홀수를, 오른편에는 짝수를
    ///     대로(Boulevard) 및 로(Street)의 경우 매20미터마다, 길(Road)의 경우 매10미터마다 2씩
    ///     증가시키면서 부여한다.
    ///     </para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:altLabel : building main numberskos:altLabel : 건물 본 번호skos:altLabel : 건물 본 번</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/juso/kr/building_number">juso.kr:building_number</a>
    /// </summary>
    let building_number = _prefixId.prefix "building_number"
    /// <summary>
    ///   <para>skos:definition :
    ///     The third-level administrative division of the address in South Korea,
    ///     one of the four types of submunicipal-level divisions: towns (eup),
    ///     townships (myeon), legal-status neighborhoods (beopjeongdong), and
    ///     administrative neighborhoods (haengjeongdong).
    ///     skos:definition :
    ///     대한민국 주소의 읍면동급 행정 구역으로 읍, 면, 법정동, 행정동 중 하나에 해당한다.
    ///     </para>
    ///   <para>skos:prefLabel : 읍/면/동skos:prefLabel : town, township, or neighborhood</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/eup_myeon_dong">juso.kr:eup_myeon_dong</a>
    /// </summary>
    let eup_myeon_dong = _prefixId.prefix "eup_myeon_dong"
    /// <summary>
    ///   <para>skos:definition :
    ///     Each of towns (eup), townships (myeon), or neighborhoods (dong) is given a
    ///     3-number code.
    ///     skos:definition :
    ///     읍, 면, 동은 3자리 코드를 부여 받는다.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : code for town, township, neighborhoodskos:prefLabel : 읍면동 코드</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/eup_myeon_dong_code">juso.kr:eup_myeon_dong_code</a>
    /// </summary>
    let eup_myeon_dong_code = _prefixId.prefix "eup_myeon_dong_code"
    /// <summary>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : serial number for town, township, or neighborhoodskos:prefLabel : 읍면동 일련 번호</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     A serial number for town, township, or neighborhood to distinguish
    ///     addresses that share the same code for city, county, or district, and
    ///     the same road name number.
    ///     skos:definition :
    ///     시군구 코드와 도로명 번호가 중복되는 주소를 구분하기 위한 읍면동 일련 번호.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/eup_myeon_dong_serial_number">juso.kr:eup_myeon_dong_serial_number</a>
    /// </summary>
    let eup_myeon_dong_serial_number = _prefixId.prefix "eup_myeon_dong_serial_number"
    /// <summary>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:prefLabel : 층 구분skos:prefLabel : floor</para>
    ///   <para>skos:definition :
    ///     주소가 가리키는 곳이 지상인지, 지하인지, 공중인지 여부.
    ///     skos:definition :
    ///     Whether the address locates a place on the ground, under the ground, or in
    ///     the air.
    ///     </para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="http://rdfs.co/juso/kr/floor">juso.kr:floor</a>
    /// </summary>
    let floor = _prefixId.prefix "floor"
    /// <summary>
    ///   <para>skos:prefLabel : 호skos:prefLabel : ho</para>
    ///   <para>skos:definition :
    ///     호(戶)는 건물에 부여된 각 번지 내 건물 번호이다.
    ///     skos:definition :
    ///     The building itself is given a house number (ho) within the city block.
    ///     </para>
    ///   <para>rdfs:comment :
    ///     Usually, the words "번지" and "호" are not included in the written address;
    ///     instead, only their numbers, separated by a hyphen, are written.
    ///     </para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/ho">juso.kr:ho</a>
    /// </summary>
    let ho = _prefixId.prefix "ho"
    /// <summary>
    ///   <para>skos:definition :
    ///     주소 필지의 산 여부.
    ///     skos:definition :
    ///     Whether the address locates a land lot or a mountain.
    ///     </para>
    ///   <para>skos:prefLabel : landformskos:prefLabel : 필지 구분</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/landform">juso.kr:landform</a>
    /// </summary>
    let landform = _prefixId.prefix "landform"

    /// <summary>
    ///   <para>skos:definition :
    ///     The unique administrative code for the legal-status neighborhood.
    ///     skos:definition :
    ///     법정동에 부여된 행정 표준 코드.
    ///     </para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : 법정동코드skos:prefLabel : legal-status neighborhood code</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/legal_status_neighborhood_code">juso.kr:legal_status_neighborhood_code</a>
    /// </summary>
    let legal_status_neighborhood_code =
        _prefixId.prefix "legal_status_neighborhood_code"

    /// <summary>
    ///   <para>skos:prefLabel : 상위 도로skos:prefLabel : parent boulevard, street, or road</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     A boulevard, street, or road that is a direct parent of the current one.
    ///     skos:definition :
    ///     이 도로의 상위에 있는 대로, 로, 길.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/parent_road">juso.kr:parent_road</a>
    /// </summary>
    let parent_road = _prefixId.prefix "parent_road"
    /// <summary>
    ///   <para>skos:prefLabel : 리skos:prefLabel : village</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     대한민국 주소의 리통급 행정 구역 중 현재는 거의 사용되지 않는 통을 제외한 법정리 또는 행정리에
    ///     해당한다.
    ///     skos:definition :
    ///     A legal-status village (beopjeongri) or administrative village
    ///     (haengjeongri) for the fourth-level administrative division of the address
    ///     in South Korea.
    ///     </para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/ri">juso.kr:ri</a>
    /// </summary>
    let ri = _prefixId.prefix "ri"
    /// <summary>
    ///   <para>skos:definition :
    ///     Each of boulevards, streets, or roads is given a 7-number code.
    ///     skos:definition :
    ///     대로, 로, 길은 7자리 코드를 부여 받는다.
    ///     </para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : road name numberskos:prefLabel : 도로명 번호</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/road_name_number">juso.kr:road_name_number</a>
    /// </summary>
    let road_name_number = _prefixId.prefix "road_name_number"
    /// <summary>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:definition :
    ///     대한민국 주소의 시도급 행정 구역으로 1개의 특별시, 6개의 광역시, 8개의 도, 1개의 특별자치시,
    ///     1개의 특별자치도 중 하나에 해당한다.
    ///     skos:definition :
    ///     The top tier of administrative division of the address in South Korea,
    ///     one of the five types of provincial-level divisions: provinces (do),
    ///     special autonomous provinces (teukbyeol-jachido), special cities
    ///     (teukbyeolsi), metropolitan cities (gwangyeoksi) and metropolitan
    ///     autonomous cities (teukbyeol-jachisi).
    ///     </para>
    ///   <para>skos:prefLabel : 시/도skos:prefLabel : city or province</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/si_do">juso.kr:si_do</a>
    /// </summary>
    let si_do = _prefixId.prefix "si_do"
    /// <summary>
    ///   <para>skos:definition :
    ///     대한민국 주소의 시군구급 행정 구역으로 시, 특정시, 행정시, 군, 자치구, 일반구 중 하나에
    ///     해당한다.
    ///     skos:definition :
    ///     The second-level administrative division of the address in South Korea,
    ///     one of the six types of municipal-level divisions: cities (si), specific
    ///     cities (teukjeongsi), administrative cities (haengjeongsi), county (gun),
    ///     autonomous districts (jachigu), and non-autonomous districts (ilbangu).
    ///     </para>
    ///   <para>skos:prefLabel : city, county, or districtskos:prefLabel : 시/군/구</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <a href="http://rdfs.co/juso/kr/si_gun_gu">juso.kr:si_gun_gu</a>
    /// </summary>
    let si_gun_gu = _prefixId.prefix "si_gun_gu"
    /// <summary>
    ///   <para>dcterms:issued : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>skos:definition :
    ///     시, 군, 구는 5자리 코드를 부여받는다.
    ///     skos:definition :
    ///     Each of cities (si), counties (gun), or districts (gu) is given a 5-number
    ///     code.
    ///     </para>
    ///   <para>dcterms:modified : 2015-10-02+09:00^^xsd:date</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>skos:prefLabel : 시군구 코드skos:prefLabel : code for city, county, or district</para>
    ///   <a href="http://rdfs.co/juso/kr/si_gun_gu_code">juso.kr:si_gun_gu_code</a>
    /// </summary>
    let si_gun_gu_code = _prefixId.prefix "si_gun_gu_code"
