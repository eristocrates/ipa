namespace https.saref.etsi.org.saref4city.slash

open DoxAletheia

module s4city =
    let _namespace_name = "https://saref.etsi.org/saref4city/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// has key performance indicator
    /// <see href="https://saref.etsi.org/saref4city/hasKPI"></see></summary>
    let hasKPI = _prefix "hasKPI"
    /// <summary>
    /// A Key Performance Indicator (KPI) is a type of performance measurement. KPIs evaluate the success of an organization or of a particular activity in which it engages. (Definition taken from FIWARE)
    /// <see href="https://saref.etsi.org/saref4city/KeyPerformanceIndicator"></see></summary>
    let KeyPerformanceIndicator = _prefix "KeyPerformanceIndicator"
    /// <summary>
    ///   <see href="https://saref.etsi.org/saref4city/v1.1.2/"></see>
    /// </summary>
    let ``v1.1.2/`` = _prefix "v1.1.2/"
    /// <summary>
    /// An administrative division, unit, entity, area or region, also referred to as a subnational entity, constituent unit, or country subdivision, is a portion of a country or other region delineated for the purpose of administration. (https://en.wikipedia.org/wiki/Administrative_division)
    /// <see href="https://saref.etsi.org/saref4city/AdministrativeArea"></see></summary>
    let AdministrativeArea = _prefix "AdministrativeArea"
    /// <summary>
    /// An agent making an action in the context of a city. An agent could be a person, software, etc.
    /// <see href="https://saref.etsi.org/saref4city/Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// Public service is a service which is provided by government either directly (through the public sector) or by financing provision of services. (Definition taken from Wikipedia)
    /// <see href="https://saref.etsi.org/saref4city/PublicService"></see></summary>
    let PublicService = _prefix "PublicService"
    /// <summary>
    /// A city is a large human settlement. A city is distinguished from other human settlements by its relatively great size, but also by its functions and its special symbolic status, which may be conferred by a central authority. (https://en.wikipedia.org/wiki/City)
    /// <see href="https://saref.etsi.org/saref4city/City"></see></summary>
    let City = _prefix "City"
    /// <summary>
    /// Generic class for describing city objects.
    /// <see href="https://saref.etsi.org/saref4city/CityObject"></see></summary>
    let CityObject = _prefix "CityObject"
    /// <summary>
    /// A country is a region that is identified as a distinct national entity in political geography. (https://en.wikipedia.org/wiki/Country)
    /// <see href="https://saref.etsi.org/saref4city/Country"></see></summary>
    let Country = _prefix "Country"
    /// <summary>
    /// A district is a type of administrative division that, in some countries, is managed by local government. Across the world, areas known as "districts" vary greatly in size, spanning regions or counties, several municipalities, subdivisions of municipalities, school district, or political district. (https://en.wikipedia.org/wiki/District)
    /// <see href="https://saref.etsi.org/saref4city/District"></see></summary>
    let District = _prefix "District"
    /// <summary>
    /// Temporary and scheduled event, like a festival or competition. (Definition taken from Wikidata)
    /// <see href="https://saref.etsi.org/saref4city/Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// has accesibility
    /// <see href="https://saref.etsi.org/saref4city/hasAccesibility"></see></summary>
    let hasAccesibility = _prefix "hasAccesibility"
    /// <summary>
    /// is organized by
    /// <see href="https://saref.etsi.org/saref4city/isOrganizedBy"></see></summary>
    let isOrganizedBy = _prefix "isOrganizedBy"
    /// <summary>
    /// is subevent of
    /// <see href="https://saref.etsi.org/saref4city/isSubEventOf"></see></summary>
    let isSubEventOf = _prefix "isSubEventOf"
    /// <summary>
    /// takes place at facility
    /// <see href="https://saref.etsi.org/saref4city/takesPlaceAtFacility"></see></summary>
    let takesPlaceAtFacility = _prefix "takesPlaceAtFacility"
    /// <summary>
    /// A place, amenity, or piece of equipment provided for a particular purpose. (Definition taken from https://en.oxforddictionaries.com/definition/facility)
    /// <see href="https://saref.etsi.org/saref4city/Facility"></see></summary>
    let Facility = _prefix "Facility"
    /// <summary>
    /// takes place at time
    /// <see href="https://saref.etsi.org/saref4city/takesPlaceAtTime"></see></summary>
    let takesPlaceAtTime = _prefix "takesPlaceAtTime"
    /// <summary>
    /// has calculation period
    /// <see href="https://saref.etsi.org/saref4city/hasCalculationPeriod"></see></summary>
    let hasCalculationPeriod = _prefix "hasCalculationPeriod"
    /// <summary>
    /// is key performance indicator of
    /// <see href="https://saref.etsi.org/saref4city/isKPIOf"></see></summary>
    let isKPIOf = _prefix "isKPIOf"
    /// <summary>
    /// A Key Performance Indicator assessment represents the assessment of a KPI calculated by a given agent in a given time.
    /// <see href="https://saref.etsi.org/saref4city/KeyPerformanceIndicatorAssessment"></see></summary>
    let KeyPerformanceIndicatorAssessment = _prefix "KeyPerformanceIndicatorAssessment"
    /// <summary>
    /// has last update date
    /// <see href="https://saref.etsi.org/saref4city/hasLastUpdateDate"></see></summary>
    let hasLastUpdateDate = _prefix "hasLastUpdateDate"
    /// <summary>
    /// has creation date
    /// <see href="https://saref.etsi.org/saref4city/hasCreationDate"></see></summary>
    let hasCreationDate = _prefix "hasCreationDate"
    /// <summary>
    /// is derived from
    /// <see href="https://saref.etsi.org/saref4city/isDerivedFrom"></see></summary>
    let isDerivedFrom = _prefix "isDerivedFrom"
    /// <summary>
    /// assesses
    /// <see href="https://saref.etsi.org/saref4city/assesses"></see></summary>
    let assesses = _prefix "assesses"
    /// <summary>
    /// quantifies KPI
    /// <see href="https://saref.etsi.org/saref4city/quantifiesKPI"></see></summary>
    let quantifiesKPI = _prefix "quantifiesKPI"
    /// <summary>
    /// has expiration date
    /// <see href="https://saref.etsi.org/saref4city/hasExpirationDate"></see></summary>
    let hasExpirationDate = _prefix "hasExpirationDate"
    /// <summary>
    /// refers to time
    /// <see href="https://saref.etsi.org/saref4city/refersToTime"></see></summary>
    let refersToTime = _prefix "refersToTime"
    /// <summary>
    /// is assessed by
    /// <see href="https://saref.etsi.org/saref4city/isAssessedBy"></see></summary>
    let isAssessedBy = _prefix "isAssessedBy"
    /// <summary>
    /// A neighbourhood (British English), or neighborhood (American English; see spelling differences), is a geographically localised community within a larger city, town, suburb or rural area. (https://en.wikipedia.org/wiki/Neighbourhood)
    /// <see href="https://saref.etsi.org/saref4city/Neighbourhood"></see></summary>
    let Neighbourhood = _prefix "Neighbourhood"
    /// <summary>
    /// Public leadership of public affairs directly responsible for executive action. (Definition taken from wikidata)
    /// <see href="https://saref.etsi.org/saref4city/PublicAdministration"></see></summary>
    let PublicAdministration = _prefix "PublicAdministration"
    /// <summary>
    /// involves facility
    /// <see href="https://saref.etsi.org/saref4city/involvesFacility"></see></summary>
    let involvesFacility = _prefix "involvesFacility"
    /// <summary>
    /// is available in language
    /// <see href="https://saref.etsi.org/saref4city/isAvailableInLanguage"></see></summary>
    let isAvailableInLanguage = _prefix "isAvailableInLanguage"
    /// <summary>
    /// Relation between a KPI assessment and the geographical feature it refers to
    /// <see href="https://saref.etsi.org/saref4city/refersToFeature"></see></summary>
    let refersToFeature = _prefix "refersToFeature"
