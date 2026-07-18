namespace https.saref.etsi.org.saref4city.slash

open DoxAletheia.Rdf_Vocabulary

module s4city =
    let _namespace_name = "https://saref.etsi.org/saref4city/"
    /// <summary>
    /// has key performance indicator
    /// <see href="https://saref.etsi.org/saref4city/hasKPI"></see></summary>
    let hasKPI = Namespaced_IRI.parse _namespace_name "hasKPI" |> NamespacedName

    /// <summary>
    /// A Key Performance Indicator (KPI) is a type of performance measurement. KPIs evaluate the success of an organization or of a particular activity in which it engages. (Definition taken from FIWARE)
    /// <see href="https://saref.etsi.org/saref4city/KeyPerformanceIndicator"></see></summary>
    let KeyPerformanceIndicator =
        Namespaced_IRI.parse _namespace_name "KeyPerformanceIndicator" |> NamespacedName

    /// <summary>
    ///   <see href="https://saref.etsi.org/saref4city/v1.1.2/"></see>
    /// </summary>
    let ``v1.1.2/`` = Namespaced_IRI.parse _namespace_name "v1.1.2/" |> NamespacedName

    /// <summary>
    /// An administrative division, unit, entity, area or region, also referred to as a subnational entity, constituent unit, or country subdivision, is a portion of a country or other region delineated for the purpose of administration. (https://en.wikipedia.org/wiki/Administrative_division)
    /// <see href="https://saref.etsi.org/saref4city/AdministrativeArea"></see></summary>
    let AdministrativeArea =
        Namespaced_IRI.parse _namespace_name "AdministrativeArea" |> NamespacedName

    /// <summary>
    /// An agent making an action in the context of a city. An agent could be a person, software, etc.
    /// <see href="https://saref.etsi.org/saref4city/Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName

    /// <summary>
    /// Public service is a service which is provided by government either directly (through the public sector) or by financing provision of services. (Definition taken from Wikipedia)
    /// <see href="https://saref.etsi.org/saref4city/PublicService"></see></summary>
    let PublicService =
        Namespaced_IRI.parse _namespace_name "PublicService" |> NamespacedName

    /// <summary>
    /// A city is a large human settlement. A city is distinguished from other human settlements by its relatively great size, but also by its functions and its special symbolic status, which may be conferred by a central authority. (https://en.wikipedia.org/wiki/City)
    /// <see href="https://saref.etsi.org/saref4city/City"></see></summary>
    let City = Namespaced_IRI.parse _namespace_name "City" |> NamespacedName
    /// <summary>
    /// Generic class for describing city objects.
    /// <see href="https://saref.etsi.org/saref4city/CityObject"></see></summary>
    let CityObject = Namespaced_IRI.parse _namespace_name "CityObject" |> NamespacedName
    /// <summary>
    /// A country is a region that is identified as a distinct national entity in political geography. (https://en.wikipedia.org/wiki/Country)
    /// <see href="https://saref.etsi.org/saref4city/Country"></see></summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName
    /// <summary>
    /// A district is a type of administrative division that, in some countries, is managed by local government. Across the world, areas known as "districts" vary greatly in size, spanning regions or counties, several municipalities, subdivisions of municipalities, school district, or political district. (https://en.wikipedia.org/wiki/District)
    /// <see href="https://saref.etsi.org/saref4city/District"></see></summary>
    let District = Namespaced_IRI.parse _namespace_name "District" |> NamespacedName
    /// <summary>
    /// Temporary and scheduled event, like a festival or competition. (Definition taken from Wikidata)
    /// <see href="https://saref.etsi.org/saref4city/Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    /// has accesibility
    /// <see href="https://saref.etsi.org/saref4city/hasAccesibility"></see></summary>
    let hasAccesibility =
        Namespaced_IRI.parse _namespace_name "hasAccesibility" |> NamespacedName

    /// <summary>
    /// is organized by
    /// <see href="https://saref.etsi.org/saref4city/isOrganizedBy"></see></summary>
    let isOrganizedBy =
        Namespaced_IRI.parse _namespace_name "isOrganizedBy" |> NamespacedName

    /// <summary>
    /// is subevent of
    /// <see href="https://saref.etsi.org/saref4city/isSubEventOf"></see></summary>
    let isSubEventOf =
        Namespaced_IRI.parse _namespace_name "isSubEventOf" |> NamespacedName

    /// <summary>
    /// takes place at facility
    /// <see href="https://saref.etsi.org/saref4city/takesPlaceAtFacility"></see></summary>
    let takesPlaceAtFacility =
        Namespaced_IRI.parse _namespace_name "takesPlaceAtFacility" |> NamespacedName

    /// <summary>
    /// A place, amenity, or piece of equipment provided for a particular purpose. (Definition taken from https://en.oxforddictionaries.com/definition/facility)
    /// <see href="https://saref.etsi.org/saref4city/Facility"></see></summary>
    let Facility = Namespaced_IRI.parse _namespace_name "Facility" |> NamespacedName

    /// <summary>
    /// takes place at time
    /// <see href="https://saref.etsi.org/saref4city/takesPlaceAtTime"></see></summary>
    let takesPlaceAtTime =
        Namespaced_IRI.parse _namespace_name "takesPlaceAtTime" |> NamespacedName

    /// <summary>
    /// has calculation period
    /// <see href="https://saref.etsi.org/saref4city/hasCalculationPeriod"></see></summary>
    let hasCalculationPeriod =
        Namespaced_IRI.parse _namespace_name "hasCalculationPeriod" |> NamespacedName

    /// <summary>
    /// is key performance indicator of
    /// <see href="https://saref.etsi.org/saref4city/isKPIOf"></see></summary>
    let isKPIOf = Namespaced_IRI.parse _namespace_name "isKPIOf" |> NamespacedName

    /// <summary>
    /// A Key Performance Indicator assessment represents the assessment of a KPI calculated by a given agent in a given time.
    /// <see href="https://saref.etsi.org/saref4city/KeyPerformanceIndicatorAssessment"></see></summary>
    let KeyPerformanceIndicatorAssessment =
        Namespaced_IRI.parse _namespace_name "KeyPerformanceIndicatorAssessment" |> NamespacedName

    /// <summary>
    /// has last update date
    /// <see href="https://saref.etsi.org/saref4city/hasLastUpdateDate"></see></summary>
    let hasLastUpdateDate =
        Namespaced_IRI.parse _namespace_name "hasLastUpdateDate" |> NamespacedName

    /// <summary>
    /// has creation date
    /// <see href="https://saref.etsi.org/saref4city/hasCreationDate"></see></summary>
    let hasCreationDate =
        Namespaced_IRI.parse _namespace_name "hasCreationDate" |> NamespacedName

    /// <summary>
    /// is derived from
    /// <see href="https://saref.etsi.org/saref4city/isDerivedFrom"></see></summary>
    let isDerivedFrom =
        Namespaced_IRI.parse _namespace_name "isDerivedFrom" |> NamespacedName

    /// <summary>
    /// assesses
    /// <see href="https://saref.etsi.org/saref4city/assesses"></see></summary>
    let assesses = Namespaced_IRI.parse _namespace_name "assesses" |> NamespacedName

    /// <summary>
    /// quantifies KPI
    /// <see href="https://saref.etsi.org/saref4city/quantifiesKPI"></see></summary>
    let quantifiesKPI =
        Namespaced_IRI.parse _namespace_name "quantifiesKPI" |> NamespacedName

    /// <summary>
    /// has expiration date
    /// <see href="https://saref.etsi.org/saref4city/hasExpirationDate"></see></summary>
    let hasExpirationDate =
        Namespaced_IRI.parse _namespace_name "hasExpirationDate" |> NamespacedName

    /// <summary>
    /// refers to time
    /// <see href="https://saref.etsi.org/saref4city/refersToTime"></see></summary>
    let refersToTime =
        Namespaced_IRI.parse _namespace_name "refersToTime" |> NamespacedName

    /// <summary>
    /// is assessed by
    /// <see href="https://saref.etsi.org/saref4city/isAssessedBy"></see></summary>
    let isAssessedBy =
        Namespaced_IRI.parse _namespace_name "isAssessedBy" |> NamespacedName

    /// <summary>
    /// A neighbourhood (British English), or neighborhood (American English; see spelling differences), is a geographically localised community within a larger city, town, suburb or rural area. (https://en.wikipedia.org/wiki/Neighbourhood)
    /// <see href="https://saref.etsi.org/saref4city/Neighbourhood"></see></summary>
    let Neighbourhood =
        Namespaced_IRI.parse _namespace_name "Neighbourhood" |> NamespacedName

    /// <summary>
    /// Public leadership of public affairs directly responsible for executive action. (Definition taken from wikidata)
    /// <see href="https://saref.etsi.org/saref4city/PublicAdministration"></see></summary>
    let PublicAdministration =
        Namespaced_IRI.parse _namespace_name "PublicAdministration" |> NamespacedName

    /// <summary>
    /// involves facility
    /// <see href="https://saref.etsi.org/saref4city/involvesFacility"></see></summary>
    let involvesFacility =
        Namespaced_IRI.parse _namespace_name "involvesFacility" |> NamespacedName

    /// <summary>
    /// is available in language
    /// <see href="https://saref.etsi.org/saref4city/isAvailableInLanguage"></see></summary>
    let isAvailableInLanguage =
        Namespaced_IRI.parse _namespace_name "isAvailableInLanguage" |> NamespacedName

    /// <summary>
    /// Relation between a KPI assessment and the geographical feature it refers to
    /// <see href="https://saref.etsi.org/saref4city/refersToFeature"></see></summary>
    let refersToFeature =
        Namespaced_IRI.parse _namespace_name "refersToFeature" |> NamespacedName
