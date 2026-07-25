namespace https.saref.etsi.org.saref4city.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module s4city =
    let _namespace_iri = Namespace_Iri s4city |> NamespaceIRI
    /// <summary>
    ///   <para>s4city:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An agent making an action in the context of a city. An agent could be a person, software, etc.</para>
    /// labels<para>Agent</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/Agent">https://saref.etsi.org/saref4city/Agent</seealso>
    let Agent = Prefixed_Name(s4city, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>s4city:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A country is a region that is identified as a distinct national entity in political geography. (https://en.wikipedia.org/wiki/Country)</para>
    /// labels<para>Country</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/Country">https://saref.etsi.org/saref4city/Country</seealso>
    let Country = Prefixed_Name(s4city, "Country") |> PrefixedName
    /// <summary>
    ///   <para>s4city:hasAccesibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>has accesibility</para>
    /// labels<para>has accesibility</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/hasAccesibility">https://saref.etsi.org/saref4city/hasAccesibility</seealso>
    let hasAccesibility = Prefixed_Name(s4city, "hasAccesibility") |> PrefixedName
    /// <summary>
    ///   <para>s4city:isOrganizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>is organized by</para>
    /// labels<para>is organized by</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/isOrganizedBy">https://saref.etsi.org/saref4city/isOrganizedBy</seealso>
    let isOrganizedBy = Prefixed_Name(s4city, "isOrganizedBy") |> PrefixedName

    /// <summary>
    ///   <para>s4city:hasCalculationPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>has calculation period</para>
    /// labels<para>has calculation period</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/hasCalculationPeriod">https://saref.etsi.org/saref4city/hasCalculationPeriod</seealso>
    let hasCalculationPeriod =
        Prefixed_Name(s4city, "hasCalculationPeriod") |> PrefixedName

    /// <summary>
    ///   <para>s4city:isKPIOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>is key performance indicator of</para>
    /// labels<para>is key performance indicator of</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/isKPIOf">https://saref.etsi.org/saref4city/isKPIOf</seealso>
    let isKPIOf = Prefixed_Name(s4city, "isKPIOf") |> PrefixedName

    /// <summary>
    ///   <para>s4city:KeyPerformanceIndicatorAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Key Performance Indicator assessment represents the assessment of a KPI calculated by a given agent in a given time.</para>
    /// labels<para>Key performance indicator assessment</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/KeyPerformanceIndicatorAssessment">https://saref.etsi.org/saref4city/KeyPerformanceIndicatorAssessment</seealso>
    let KeyPerformanceIndicatorAssessment =
        Prefixed_Name(s4city, "KeyPerformanceIndicatorAssessment") |> PrefixedName

    /// <summary>
    ///   <para>s4city:assesses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>assesses</para>
    /// labels<para>assesses</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/assesses">https://saref.etsi.org/saref4city/assesses</seealso>
    let assesses = Prefixed_Name(s4city, "assesses") |> PrefixedName
    /// <summary>
    ///   <para>s4city:quantifiesKPI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>quantifies KPI</para>
    /// labels<para>quantifies KPI</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/quantifiesKPI">https://saref.etsi.org/saref4city/quantifiesKPI</seealso>
    let quantifiesKPI = Prefixed_Name(s4city, "quantifiesKPI") |> PrefixedName
    /// <summary>
    ///   <para>s4city:involvesFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>involves facility</para>
    /// labels<para>involves facility</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/involvesFacility">https://saref.etsi.org/saref4city/involvesFacility</seealso>
    let involvesFacility = Prefixed_Name(s4city, "involvesFacility") |> PrefixedName

    /// <summary>
    ///   <para>s4city:isAvailableInLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>is available in language</para>
    /// labels<para>is available in language</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/isAvailableInLanguage">https://saref.etsi.org/saref4city/isAvailableInLanguage</seealso>
    let isAvailableInLanguage =
        Prefixed_Name(s4city, "isAvailableInLanguage") |> PrefixedName

    /// <summary>
    ///   <para>s4city:refersToFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a KPI assessment and the geographical feature it refers to</para>
    /// labels<para>refers to feature</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/refersToFeature">https://saref.etsi.org/saref4city/refersToFeature</seealso>
    let refersToFeature = Prefixed_Name(s4city, "refersToFeature") |> PrefixedName
    /// <summary>
    ///   <para>s4city:AdministrativeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An administrative division, unit, entity, area or region, also referred to as a subnational entity, constituent unit, or country subdivision, is a portion of a country or other region delineated for the purpose of administration. (https://en.wikipedia.org/wiki/Administrative_division)</para>
    /// labels<para>Administrative area</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/AdministrativeArea">https://saref.etsi.org/saref4city/AdministrativeArea</seealso>
    let AdministrativeArea = Prefixed_Name(s4city, "AdministrativeArea") |> PrefixedName
    /// <summary>
    ///   <para>s4city:hasKPI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>has key performance indicator</para>
    /// labels<para>has key performance indicator</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/hasKPI">https://saref.etsi.org/saref4city/hasKPI</seealso>
    let hasKPI = Prefixed_Name(s4city, "hasKPI") |> PrefixedName

    /// <summary>
    ///   <para>s4city:KeyPerformanceIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Key Performance Indicator (KPI) is a type of performance measurement. KPIs evaluate the success of an organization or of a particular activity in which it engages. (Definition taken from FIWARE)</para>
    /// labels<para>Key Performance Indicator</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/KeyPerformanceIndicator">https://saref.etsi.org/saref4city/KeyPerformanceIndicator</seealso>
    let KeyPerformanceIndicator =
        Prefixed_Name(s4city, "KeyPerformanceIndicator") |> PrefixedName

    /// <summary>
    ///   <para>s4city:hasExpirationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>has expiration date</para>
    /// labels<para>has expiration date</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/hasExpirationDate">https://saref.etsi.org/saref4city/hasExpirationDate</seealso>
    let hasExpirationDate = Prefixed_Name(s4city, "hasExpirationDate") |> PrefixedName
    /// <summary>
    ///   <para>s4city:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>Information about changes compared to version 1.1.1:
    ///  - Updated namespaces for compatibility with SAREF v3.</para>
    /// </remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/">https://saref.etsi.org/saref4city/</seealso>
    let _prefix_iri = Prefixed_Name(s4city, "") |> PrefixedName
    /// <summary>
    ///   <para>s4city:v1.1.2/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/v1.1.2/">https://saref.etsi.org/saref4city/v1.1.2/</seealso>
    let ``v1.1.2/`` = Prefixed_Name(s4city, "v1.1.2/") |> PrefixedName
    /// <summary>
    ///   <para>s4city:PublicService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Public service is a service which is provided by government either directly (through the public sector) or by financing provision of services. (Definition taken from Wikipedia)</para>
    /// labels<para>Public service</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/PublicService">https://saref.etsi.org/saref4city/PublicService</seealso>
    let PublicService = Prefixed_Name(s4city, "PublicService") |> PrefixedName
    /// <summary>
    ///   <para>s4city:City</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A city is a large human settlement. A city is distinguished from other human settlements by its relatively great size, but also by its functions and its special symbolic status, which may be conferred by a central authority. (https://en.wikipedia.org/wiki/City)</para>
    /// labels<para>City</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/City">https://saref.etsi.org/saref4city/City</seealso>
    let City = Prefixed_Name(s4city, "City") |> PrefixedName
    /// <summary>
    ///   <para>s4city:CityObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Generic class for describing city objects.</para>
    /// labels<para>City object</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/CityObject">https://saref.etsi.org/saref4city/CityObject</seealso>
    let CityObject = Prefixed_Name(s4city, "CityObject") |> PrefixedName
    /// <summary>
    ///   <para>s4city:District</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A district is a type of administrative division that, in some countries, is managed by local government. Across the world, areas known as "districts" vary greatly in size, spanning regions or counties, several municipalities, subdivisions of municipalities, school district, or political district. (https://en.wikipedia.org/wiki/District)</para>
    /// labels<para>District</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/District">https://saref.etsi.org/saref4city/District</seealso>
    let District = Prefixed_Name(s4city, "District") |> PrefixedName
    /// <summary>
    ///   <para>s4city:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Temporary and scheduled event, like a festival or competition. (Definition taken from Wikidata)</para>
    /// labels<para>Event</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/Event">https://saref.etsi.org/saref4city/Event</seealso>
    let Event = Prefixed_Name(s4city, "Event") |> PrefixedName
    /// <summary>
    ///   <para>s4city:isSubEventOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>is subevent of</para>
    /// labels<para>is subevent of</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/isSubEventOf">https://saref.etsi.org/saref4city/isSubEventOf</seealso>
    let isSubEventOf = Prefixed_Name(s4city, "isSubEventOf") |> PrefixedName

    /// <summary>
    ///   <para>s4city:takesPlaceAtFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>takes place at facility</para>
    /// labels<para>takes place at facility</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/takesPlaceAtFacility">https://saref.etsi.org/saref4city/takesPlaceAtFacility</seealso>
    let takesPlaceAtFacility =
        Prefixed_Name(s4city, "takesPlaceAtFacility") |> PrefixedName

    /// <summary>
    ///   <para>s4city:Facility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A place, amenity, or piece of equipment provided for a particular purpose. (Definition taken from https://en.oxforddictionaries.com/definition/facility)</para>
    /// labels<para>Facility</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/Facility">https://saref.etsi.org/saref4city/Facility</seealso>
    let Facility = Prefixed_Name(s4city, "Facility") |> PrefixedName
    /// <summary>
    ///   <para>s4city:takesPlaceAtTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>takes place at time</para>
    /// labels<para>takes place at time</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/takesPlaceAtTime">https://saref.etsi.org/saref4city/takesPlaceAtTime</seealso>
    let takesPlaceAtTime = Prefixed_Name(s4city, "takesPlaceAtTime") |> PrefixedName
    /// <summary>
    ///   <para>s4city:hasLastUpdateDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>has last update date</para>
    /// labels<para>has last update date</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/hasLastUpdateDate">https://saref.etsi.org/saref4city/hasLastUpdateDate</seealso>
    let hasLastUpdateDate = Prefixed_Name(s4city, "hasLastUpdateDate") |> PrefixedName
    /// <summary>
    ///   <para>s4city:hasCreationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>has creation date</para>
    /// labels<para>has creation date</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/hasCreationDate">https://saref.etsi.org/saref4city/hasCreationDate</seealso>
    let hasCreationDate = Prefixed_Name(s4city, "hasCreationDate") |> PrefixedName
    /// <summary>
    ///   <para>s4city:isDerivedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>is derived from</para>
    /// labels<para>is derived from</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/isDerivedFrom">https://saref.etsi.org/saref4city/isDerivedFrom</seealso>
    let isDerivedFrom = Prefixed_Name(s4city, "isDerivedFrom") |> PrefixedName
    /// <summary>
    ///   <para>s4city:refersToTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>refers to time</para>
    /// labels<para>refers to time</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/refersToTime">https://saref.etsi.org/saref4city/refersToTime</seealso>
    let refersToTime = Prefixed_Name(s4city, "refersToTime") |> PrefixedName
    /// <summary>
    ///   <para>s4city:isAssessedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>is assessed by</para>
    /// labels<para>is assessed by</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/isAssessedBy">https://saref.etsi.org/saref4city/isAssessedBy</seealso>
    let isAssessedBy = Prefixed_Name(s4city, "isAssessedBy") |> PrefixedName
    /// <summary>
    ///   <para>s4city:Neighbourhood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A neighbourhood (British English), or neighborhood (American English; see spelling differences), is a geographically localised community within a larger city, town, suburb or rural area. (https://en.wikipedia.org/wiki/Neighbourhood)</para>
    /// labels<para>Neighbourhood</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/Neighbourhood">https://saref.etsi.org/saref4city/Neighbourhood</seealso>
    let Neighbourhood = Prefixed_Name(s4city, "Neighbourhood") |> PrefixedName

    /// <summary>
    ///   <para>s4city:PublicAdministration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Public leadership of public affairs directly responsible for executive action. (Definition taken from wikidata)</para>
    /// labels<para>Public administration</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4city/PublicAdministration">https://saref.etsi.org/saref4city/PublicAdministration</seealso>
    let PublicAdministration =
        Prefixed_Name(s4city, "PublicAdministration") |> PrefixedName
