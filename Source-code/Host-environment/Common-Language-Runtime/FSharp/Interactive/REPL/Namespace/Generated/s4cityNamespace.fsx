#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module s4city =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://saref.etsi.org/saref4city/" "s4city"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Administrative area</para>
    ///   <para>rdfs:comment : An administrative division, unit, entity, area or region, also referred to as a subnational entity, constituent unit, or country subdivision, is a portion of a country or other region delineated for the purpose of administration. (https://en.wikipedia.org/wiki/Administrative_division)</para>
    ///   <a href="https://saref.etsi.org/saref4city/AdministrativeArea">s4city:AdministrativeArea</a>
    /// </summary>
    let AdministrativeArea = _prefixId.prefix "AdministrativeArea"
    /// <summary>
    ///   <para>rdfs:label : Agent</para>
    ///   <para>rdfs:comment : An agent making an action in the context of a city. An agent could be a person, software, etc.</para>
    ///   <a href="https://saref.etsi.org/saref4city/Agent">s4city:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:label : City</para>
    ///   <para>rdfs:comment : A city is a large human settlement. A city is distinguished from other human settlements by its relatively great size, but also by its functions and its special symbolic status, which may be conferred by a central authority. (https://en.wikipedia.org/wiki/City)</para>
    ///   <a href="https://saref.etsi.org/saref4city/City">s4city:City</a>
    /// </summary>
    let City = _prefixId.prefix "City"
    /// <summary>
    ///   <para>rdfs:label : City object</para>
    ///   <para>rdfs:comment : Generic class for describing city objects.</para>
    ///   <a href="https://saref.etsi.org/saref4city/CityObject">s4city:CityObject</a>
    /// </summary>
    let CityObject = _prefixId.prefix "CityObject"
    /// <summary>
    ///   <para>rdfs:label : Country</para>
    ///   <para>rdfs:comment : A country is a region that is identified as a distinct national entity in political geography. (https://en.wikipedia.org/wiki/Country)</para>
    ///   <a href="https://saref.etsi.org/saref4city/Country">s4city:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>rdfs:label : District</para>
    ///   <para>rdfs:comment : A district is a type of administrative division that, in some countries, is managed by local government. Across the world, areas known as "districts" vary greatly in size, spanning regions or counties, several municipalities, subdivisions of municipalities, school district, or political district. (https://en.wikipedia.org/wiki/District)</para>
    ///   <a href="https://saref.etsi.org/saref4city/District">s4city:District</a>
    /// </summary>
    let District = _prefixId.prefix "District"
    /// <summary>
    ///   <para>rdfs:label : Event</para>
    ///   <para>rdfs:comment : Temporary and scheduled event, like a festival or competition. (Definition taken from Wikidata)</para>
    ///   <a href="https://saref.etsi.org/saref4city/Event">s4city:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:label : Facility</para>
    ///   <para>rdfs:comment : A place, amenity, or piece of equipment provided for a particular purpose. (Definition taken from https://en.oxforddictionaries.com/definition/facility)</para>
    ///   <a href="https://saref.etsi.org/saref4city/Facility">s4city:Facility</a>
    /// </summary>
    let Facility = _prefixId.prefix "Facility"
    /// <summary>
    ///   <para>rdfs:label : Key Performance Indicator</para>
    ///   <para>rdfs:comment : A Key Performance Indicator (KPI) is a type of performance measurement. KPIs evaluate the success of an organization or of a particular activity in which it engages. (Definition taken from FIWARE)</para>
    ///   <a href="https://saref.etsi.org/saref4city/KeyPerformanceIndicator">s4city:KeyPerformanceIndicator</a>
    /// </summary>
    let KeyPerformanceIndicator = _prefixId.prefix "KeyPerformanceIndicator"

    /// <summary>
    ///   <para>rdfs:comment : A Key Performance Indicator assessment represents the assessment of a KPI calculated by a given agent in a given time.</para>
    ///   <para>rdfs:label : Key performance indicator assessment</para>
    ///   <a href="https://saref.etsi.org/saref4city/KeyPerformanceIndicatorAssessment">s4city:KeyPerformanceIndicatorAssessment</a>
    /// </summary>
    let KeyPerformanceIndicatorAssessment =
        _prefixId.prefix "KeyPerformanceIndicatorAssessment"

    /// <summary>
    ///   <para>rdfs:label : Neighbourhood</para>
    ///   <para>rdfs:comment : A neighbourhood (British English), or neighborhood (American English; see spelling differences), is a geographically localised community within a larger city, town, suburb or rural area. (https://en.wikipedia.org/wiki/Neighbourhood)</para>
    ///   <a href="https://saref.etsi.org/saref4city/Neighbourhood">s4city:Neighbourhood</a>
    /// </summary>
    let Neighbourhood = _prefixId.prefix "Neighbourhood"
    /// <summary>
    ///   <para>rdfs:label : Public administration</para>
    ///   <para>rdfs:comment : Public leadership of public affairs directly responsible for executive action. (Definition taken from wikidata)</para>
    ///   <a href="https://saref.etsi.org/saref4city/PublicAdministration">s4city:PublicAdministration</a>
    /// </summary>
    let PublicAdministration = _prefixId.prefix "PublicAdministration"
    /// <summary>
    ///   <para>rdfs:label : Public service</para>
    ///   <para>rdfs:comment : Public service is a service which is provided by government either directly (through the public sector) or by financing provision of services. (Definition taken from Wikipedia)</para>
    ///   <a href="https://saref.etsi.org/saref4city/PublicService">s4city:PublicService</a>
    /// </summary>
    let PublicService = _prefixId.prefix "PublicService"
    /// <summary>
    ///   <para>rdfs:label : assesses</para>
    ///   <para>rdfs:comment : assesses</para>
    ///   <a href="https://saref.etsi.org/saref4city/assesses">s4city:assesses</a>
    /// </summary>
    let assesses = _prefixId.prefix "assesses"
    /// <summary>
    ///   <para>rdfs:label : has accesibility</para>
    ///   <para>rdfs:comment : has accesibility</para>
    ///   <a href="https://saref.etsi.org/saref4city/hasAccesibility">s4city:hasAccesibility</a>
    /// </summary>
    let hasAccesibility = _prefixId.prefix "hasAccesibility"
    /// <summary>
    ///   <para>rdfs:label : has calculation period</para>
    ///   <para>rdfs:comment : has calculation period</para>
    ///   <a href="https://saref.etsi.org/saref4city/hasCalculationPeriod">s4city:hasCalculationPeriod</a>
    /// </summary>
    let hasCalculationPeriod = _prefixId.prefix "hasCalculationPeriod"
    /// <summary>
    ///   <para>rdfs:label : has creation date</para>
    ///   <para>rdfs:comment : has creation date</para>
    ///   <a href="https://saref.etsi.org/saref4city/hasCreationDate">s4city:hasCreationDate</a>
    /// </summary>
    let hasCreationDate = _prefixId.prefix "hasCreationDate"
    /// <summary>
    ///   <para>rdfs:label : has expiration date</para>
    ///   <para>rdfs:comment : has expiration date</para>
    ///   <a href="https://saref.etsi.org/saref4city/hasExpirationDate">s4city:hasExpirationDate</a>
    /// </summary>
    let hasExpirationDate = _prefixId.prefix "hasExpirationDate"
    /// <summary>
    ///   <para>rdfs:label : has key performance indicator</para>
    ///   <para>rdfs:comment : has key performance indicator</para>
    ///   <a href="https://saref.etsi.org/saref4city/hasKPI">s4city:hasKPI</a>
    /// </summary>
    let hasKPI = _prefixId.prefix "hasKPI"
    /// <summary>
    ///   <para>rdfs:label : has last update date</para>
    ///   <para>rdfs:comment : has last update date</para>
    ///   <a href="https://saref.etsi.org/saref4city/hasLastUpdateDate">s4city:hasLastUpdateDate</a>
    /// </summary>
    let hasLastUpdateDate = _prefixId.prefix "hasLastUpdateDate"
    /// <summary>
    ///   <para>rdfs:label : involves facility</para>
    ///   <para>rdfs:comment : involves facility</para>
    ///   <a href="https://saref.etsi.org/saref4city/involvesFacility">s4city:involvesFacility</a>
    /// </summary>
    let involvesFacility = _prefixId.prefix "involvesFacility"
    /// <summary>
    ///   <para>rdfs:label : is assessed by</para>
    ///   <para>rdfs:comment : is assessed by</para>
    ///   <a href="https://saref.etsi.org/saref4city/isAssessedBy">s4city:isAssessedBy</a>
    /// </summary>
    let isAssessedBy = _prefixId.prefix "isAssessedBy"
    /// <summary>
    ///   <para>rdfs:label : is available in language</para>
    ///   <para>rdfs:comment : is available in language</para>
    ///   <a href="https://saref.etsi.org/saref4city/isAvailableInLanguage">s4city:isAvailableInLanguage</a>
    /// </summary>
    let isAvailableInLanguage = _prefixId.prefix "isAvailableInLanguage"
    /// <summary>
    ///   <para>rdfs:label : is derived from</para>
    ///   <para>rdfs:comment : is derived from</para>
    ///   <a href="https://saref.etsi.org/saref4city/isDerivedFrom">s4city:isDerivedFrom</a>
    /// </summary>
    let isDerivedFrom = _prefixId.prefix "isDerivedFrom"
    /// <summary>
    ///   <para>rdfs:label : is key performance indicator of</para>
    ///   <para>rdfs:comment : is key performance indicator of</para>
    ///   <a href="https://saref.etsi.org/saref4city/isKPIOf">s4city:isKPIOf</a>
    /// </summary>
    let isKPIOf = _prefixId.prefix "isKPIOf"
    /// <summary>
    ///   <para>rdfs:label : is organized by</para>
    ///   <para>rdfs:comment : is organized by</para>
    ///   <a href="https://saref.etsi.org/saref4city/isOrganizedBy">s4city:isOrganizedBy</a>
    /// </summary>
    let isOrganizedBy = _prefixId.prefix "isOrganizedBy"
    /// <summary>
    ///   <para>rdfs:label : is subevent of</para>
    ///   <para>rdfs:comment : is subevent of</para>
    ///   <a href="https://saref.etsi.org/saref4city/isSubEventOf">s4city:isSubEventOf</a>
    /// </summary>
    let isSubEventOf = _prefixId.prefix "isSubEventOf"
    /// <summary>
    ///   <para>rdfs:label : quantifies KPI</para>
    ///   <para>rdfs:comment : quantifies KPI</para>
    ///   <a href="https://saref.etsi.org/saref4city/quantifiesKPI">s4city:quantifiesKPI</a>
    /// </summary>
    let quantifiesKPI = _prefixId.prefix "quantifiesKPI"
    /// <summary>
    ///   <para>rdfs:label : refers to feature</para>
    ///   <para>rdfs:comment : Relation between a KPI assessment and the geographical feature it refers to</para>
    ///   <a href="https://saref.etsi.org/saref4city/refersToFeature">s4city:refersToFeature</a>
    /// </summary>
    let refersToFeature = _prefixId.prefix "refersToFeature"
    /// <summary>
    ///   <para>rdfs:label : refers to time</para>
    ///   <para>rdfs:comment : refers to time</para>
    ///   <a href="https://saref.etsi.org/saref4city/refersToTime">s4city:refersToTime</a>
    /// </summary>
    let refersToTime = _prefixId.prefix "refersToTime"
    /// <summary>
    ///   <para>rdfs:label : takes place at facility</para>
    ///   <para>rdfs:comment : takes place at facility</para>
    ///   <a href="https://saref.etsi.org/saref4city/takesPlaceAtFacility">s4city:takesPlaceAtFacility</a>
    /// </summary>
    let takesPlaceAtFacility = _prefixId.prefix "takesPlaceAtFacility"
    /// <summary>
    ///   <para>rdfs:label : takes place at time</para>
    ///   <para>rdfs:comment : takes place at time</para>
    ///   <a href="https://saref.etsi.org/saref4city/takesPlaceAtTime">s4city:takesPlaceAtTime</a>
    /// </summary>
    let takesPlaceAtTime = _prefixId.prefix "takesPlaceAtTime"
