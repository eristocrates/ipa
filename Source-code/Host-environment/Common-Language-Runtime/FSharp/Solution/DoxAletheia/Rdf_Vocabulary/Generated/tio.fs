namespace http.purl.org.tio.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tio =
    let _namespace_iri = Namespace_Iri tio |> NamespaceIRI
    /// <summary>
    ///   <para>tio:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"TIO: The TIckets Ontology
    ///
    /// A vocabulary for describing tickets for events, transportation, or points of interest for e-commerce.
    ///
    /// Vocabulary:    http://purl.org/tio/ns#
    /// Namespace:     http://purl.org/tio/ns#
    ///
    /// The Tickets Ontology is designed to be used in combination with GoodRelations, a standard vocabulary for the commercial aspects of offers of tickets.
    ///
    /// See http://purl.org/goodrelations/ for more information."</para>
    /// labels<para>"Tickets Ontology"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#">http://purl.org/tio/ns#</seealso>
    let _prefix_iri = Prefixed_Name(tio, "") |> PrefixedName
    /// <summary>
    ///   <para>tio:ActualTicket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actual ticket is single, identifiable right to access a particular event, location, or transportation service."</para>
    /// labels<para>"ActualTicket (gr:ProductOrService)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#ActualTicket">http://purl.org/tio/ns#ActualTicket</seealso>
    let ActualTicket = Prefixed_Name(tio, "ActualTicket") |> PrefixedName
    /// <summary>
    ///   <para>tio:BusinessClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>tio:ServiceLevel</para>
    ///   <para>"Business class as a service level / fare class for transportation by aircraft
    ///
    /// Note: The exact character of a particular fare class may vary by carrier or country.
    /// You can create individual instances of tio:ServiceLevel for a particular fare class for a particular airline."</para>
    /// labels<para>"BusinessClass (tio:ServiceLevel)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#BusinessClass">http://purl.org/tio/ns#BusinessClass</seealso>
    let BusinessClass = Prefixed_Name(tio, "BusinessClass") |> PrefixedName
    /// <summary>
    ///   <para>tio:CoachService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A regular or individual service to transport passengers or cargo from one location to another location by means of a coach or bus."</para>
    /// labels<para>"CoachService"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#CoachService">http://purl.org/tio/ns#CoachService</seealso>
    let CoachService = Prefixed_Name(tio, "CoachService") |> PrefixedName
    /// <summary>
    ///   <para>tio:DiscountType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of qualitative values indicating a discount type, audience, or group type - e.g. students, military personnel, etc.
    ///
    /// Note: Discount types that solely represent age ranges (e.g. children, senior citizens, ...) are better expressed using tio:ageRange."</para>
    /// labels<para>"DiscountType (gr:QualitativeValue)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#DiscountType">http://purl.org/tio/ns#DiscountType</seealso>
    let DiscountType = Prefixed_Name(tio, "DiscountType") |> PrefixedName
    /// <summary>
    ///   <para>tio:Economy</para>
    /// </summary>
    /// <remarks>
    ///   <para>tio:ServiceLevel</para>
    ///   <para>"Economy class as a service level / fare class for transportation by aircraft
    ///
    /// Note: The exact character of a particular fare class may vary by carrier or country.
    /// You can create individual instances of tio:ServiceLevel for a particular fare class for a particular airline."</para>
    /// labels<para>"Economy (tio:ServiceLevel)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#Economy">http://purl.org/tio/ns#Economy</seealso>
    let Economy = Prefixed_Name(tio, "Economy") |> PrefixedName
    /// <summary>
    ///   <para>tio:Etix</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:DeliveryMethod</para>
    ///   <para>"A special form of electronic ticket delivery, mainly for flight tickets"</para>
    /// labels<para>"Etix (gr:DeliveryMethod)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#Etix">http://purl.org/tio/ns#Etix</seealso>
    let Etix = Prefixed_Name(tio, "Etix") |> PrefixedName
    /// <summary>
    ///   <para>tio:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An event, e.g. a concert, a show, etc. You can also safely use the following external classes for describing the respective event:
    ///
    /// http://linkedevents.org/ontology/Event (lode:Event)
    /// http://purl.org/NET/c4dm/event.owl#Event (event:Event)
    /// http://www.loa-cnr.it/ontologies/DUL.owl#Event (dul:Event)
    ///
    /// Note: You can attach the time and date of the event using tio:starts and tio:ends as simple datatype properties, even if lode:Event and event:Event recommend other, more sophisticated ways of modeling the temporal aspects of events."</para>
    /// labels<para>"Event"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#Event">http://purl.org/tio/ns#Event</seealso>
    let Event = Prefixed_Name(tio, "Event") |> PrefixedName
    /// <summary>
    ///   <para>tio:FirstClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>tio:ServiceLevel</para>
    ///   <para>"First class as a service level / fare class for transportation by aircraft
    ///
    /// Note: The exact character of a particular fare class may vary by carrier or country.
    /// You can create individual instances of tio:ServiceLevel for a particular fare class for a particular airline."</para>
    /// labels<para>"FirstClass (tio:ServiceLevel)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#FirstClass">http://purl.org/tio/ns#FirstClass</seealso>
    let FirstClass = Prefixed_Name(tio, "FirstClass") |> PrefixedName
    /// <summary>
    ///   <para>tio:Flight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A regular or individual service to transport passengers or cargo from one location to another location by means of an aircraft
    ///
    /// Note: By design, the Tickets Ontology does not provide mechanisms for modeling rules for recurring patterns of transportation services (e.g. every Monday at 8:00). Instead, it expects that you materialize each individual connection on a given day.
    /// Most flight schedule applications are complex databases, so they will have to be exposed as SPARQL endpoints anyway."</para>
    /// labels<para>"Flight"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#Flight">http://purl.org/tio/ns#Flight</seealso>
    let Flight = Prefixed_Name(tio, "Flight") |> PrefixedName
    /// <summary>
    ///   <para>tio:POI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A point or area of interest, e.g. a museum, a train station, an airport, a bus stop, a store, a box office, etc.
    ///
    /// Note 1: Use existing vocabularies like vcard or geo to attach address and geoposition (lat/long) details to the location.
    /// Note 2: You can safely re-use any existing location, area, or point of interest from other data sources, e.g. DBPedia."</para>
    /// labels<para>"POI (gr:LocationOfSalesOrServiceProvisioning)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#POI">http://purl.org/tio/ns#POI</seealso>
    let POI = Prefixed_Name(tio, "POI") |> PrefixedName
    /// <summary>
    ///   <para>tio:ScopeOfAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is a conceptual entity that collates all properties defining the type of access a ticket provides to a particular event, location, or transportation."</para>
    /// labels<para>"ScopeOfAccess"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#ScopeOfAccess">http://purl.org/tio/ns#ScopeOfAccess</seealso>
    let ScopeOfAccess = Prefixed_Name(tio, "ScopeOfAccess") |> PrefixedName
    /// <summary>
    ///   <para>tio:SeatOrSeatCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of qualitative values indicating a seat position (e.g. the seat 4B in a given plane) or a seat category (e.g. window seat).
    ///     Note that the same vessel or building may have multiple seating layouts."</para>
    /// labels<para>"SeatOrSeatCategory (gr:QualitativeValue)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#SeatOrSeatCategory">http://purl.org/tio/ns#SeatOrSeatCategory</seealso>
    let SeatOrSeatCategory = Prefixed_Name(tio, "SeatOrSeatCategory") |> PrefixedName
    /// <summary>
    ///   <para>tio:SeatingLayout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A seating layout for a particular location, vessel, or single transportation service"</para>
    /// labels<para>"SeatingLayout"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#SeatingLayout">http://purl.org/tio/ns#SeatingLayout</seealso>
    let SeatingLayout = Prefixed_Name(tio, "SeatingLayout") |> PrefixedName
    /// <summary>
    ///   <para>tio:ServiceLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of qualitative values indicating a service level oder fare class (e.g. Business Class)."</para>
    /// labels<para>"ServiceLevel (gr:QualitativeValue)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#ServiceLevel">http://purl.org/tio/ns#ServiceLevel</seealso>
    let ServiceLevel = Prefixed_Name(tio, "ServiceLevel") |> PrefixedName
    /// <summary>
    ///   <para>tio:Stop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The initial, final, or any intermediate point in time and space of a particular tio:TransportationService,
    /// characterized by its location (tio:at), arrival time (tio:arrives), and departure time (tio:departs).
    /// Each tio:TransportationService has at least one tio:Stop for the point and time of departure and another one for the final destination."</para>
    /// labels<para>"Stop"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#Stop">http://purl.org/tio/ns#Stop</seealso>
    let Stop = Prefixed_Name(tio, "Stop") |> PrefixedName
    /// <summary>
    ///   <para>tio:Taxi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A taxi service to transport passengers from one location to another location"</para>
    /// labels<para>"Taxi"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#Taxi">http://purl.org/tio/ns#Taxi</seealso>
    let Taxi = Prefixed_Name(tio, "Taxi") |> PrefixedName
    /// <summary>
    ///   <para>tio:Ticket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A ticket is a tradeable right to access a particular event or location, or to use a particular transportation service."</para>
    /// labels<para>"Ticket (gr:ProductOrService)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#Ticket">http://purl.org/tio/ns#Ticket</seealso>
    let Ticket = Prefixed_Name(tio, "Ticket") |> PrefixedName
    /// <summary>
    ///   <para>tio:TicketPlaceholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A ticket placeholder is a dummy for multiple tickets that are themselves not exposed as data."</para>
    /// labels<para>"TicketPlaceholder (gr:ProductOrService)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#TicketPlaceholder">http://purl.org/tio/ns#TicketPlaceholder</seealso>
    let TicketPlaceholder = Prefixed_Name(tio, "TicketPlaceholder") |> PrefixedName
    /// <summary>
    ///   <para>tio:TrainService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A regular or individual service to transport passengers or cargo from one location to another location by means of a train, subway, or other railroad vehicle
    ///
    /// Note: By design, the Tickets Ontology does not provide mechanisms for modeling rules for recurring patterns of transportation services (e.g. every Monday at 8:00). Instead, it expects that you materialize each individual connection on a given day.
    /// Most train schedule applications are complex databases, so they will have to be exposed as SPARQL endpoints anyway."</para>
    /// labels<para>"TrainService"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#TrainService">http://purl.org/tio/ns#TrainService</seealso>
    let TrainService = Prefixed_Name(tio, "TrainService") |> PrefixedName

    /// <summary>
    ///   <para>tio:TransportationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A service to transport passengers or cargo from one location to another location, with optionally intermediate stops
    ///
    /// Note: By design, the Tickets Ontology does not provide mechanisms for modeling rules for recurring patterns of transportation services (e.g. every Monday at 8:00). Instead, it expects that you materialize each individual connection on a given day.
    /// Most timetable applications are complex databases, so they will have to be exposed as SPARQL endpoints anyway."</para>
    /// labels<para>"TransportationService"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#TransportationService">http://purl.org/tio/ns#TransportationService</seealso>
    let TransportationService =
        Prefixed_Name(tio, "TransportationService") |> PrefixedName

    /// <summary>
    ///   <para>tio:accessTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This links a tio:Ticket or a tio:ScopeOfAccess node to the tio:POI, tio:Event, or tio:TransportationService for which the tio:Ticket grants access.
    ///
    /// Note: When used to link a tio:Ticket directly to a tio:POI, tio:Event, or tio:TransportationService, you cannot specify the various details of a tio:ScopeOfAccess node."</para>
    /// labels<para>"accessTo (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#accessTo">http://purl.org/tio/ns#accessTo</seealso>
    let accessTo = Prefixed_Name(tio, "accessTo") |> PrefixedName
    /// <summary>
    ///   <para>tio:ageRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The eligible age range or age ranges for admission to the revent, POI, or transportation service
    /// Typical unit code(s): ANN for year (less frequently used: MON for months, WEE for weeks)"</para>
    /// labels<para>"ageRange (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#ageRange">http://purl.org/tio/ns#ageRange</seealso>
    let ageRange = Prefixed_Name(tio, "ageRange") |> PrefixedName
    /// <summary>
    ///   <para>tio:arrives</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date and time at which the transportation service will arrive at the respective tio:Stop"</para>
    /// labels<para>"arrives (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#arrives">http://purl.org/tio/ns#arrives</seealso>
    let arrives = Prefixed_Name(tio, "arrives") |> PrefixedName
    /// <summary>
    ///   <para>tio:at</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This indicates the location of a tio:Stop."</para>
    /// labels<para>"at (1..1)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#at">http://purl.org/tio/ns#at</seealso>
    let at = Prefixed_Name(tio, "at") |> PrefixedName
    /// <summary>
    ///   <para>tio:available</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The number of tickets of this category still available at the time of publishing the data"</para>
    /// labels<para>"available (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#available">http://purl.org/tio/ns#available</seealso>
    let available = Prefixed_Name(tio, "available") |> PrefixedName
    /// <summary>
    ///   <para>tio:availableLayouts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This indicates the available seating layouts for a tio:POI."</para>
    /// labels<para>"availableLayouts (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#availableLayouts">http://purl.org/tio/ns#availableLayouts</seealso>
    let availableLayouts = Prefixed_Name(tio, "availableLayouts") |> PrefixedName
    /// <summary>
    ///   <para>tio:availableSeats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This indicates the individual seats for a given seating layout."</para>
    /// labels<para>"availableSeats (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#availableSeats">http://purl.org/tio/ns#availableSeats</seealso>
    let availableSeats = Prefixed_Name(tio, "availableSeats") |> PrefixedName

    /// <summary>
    ///   <para>tio:availableServiceLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This indicates the service level(s) or fare class(es) available for the particular tio:TransportationService."</para>
    /// labels<para>"availableServiceLevel (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#availableServiceLevel">http://purl.org/tio/ns#availableServiceLevel</seealso>
    let availableServiceLevel =
        Prefixed_Name(tio, "availableServiceLevel") |> PrefixedName

    /// <summary>
    ///   <para>tio:departs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date and time at which the transportation service will depart from the respective tio:Stop"</para>
    /// labels<para>"departs (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#departs">http://purl.org/tio/ns#departs</seealso>
    let departs = Prefixed_Name(tio, "departs") |> PrefixedName
    /// <summary>
    ///   <para>tio:durationOfAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The eligible duration of uninterrupted attendance or access.
    /// Typical unit code(s): HUR for hours, DAY for days, WEE for weeks, MON for months, ANN for years "</para>
    /// labels<para>"durationOfAccess (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#durationOfAccess">http://purl.org/tio/ns#durationOfAccess</seealso>
    let durationOfAccess = Prefixed_Name(tio, "durationOfAccess") |> PrefixedName
    /// <summary>
    ///   <para>tio:eligibleAudience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This links a tio:ScopeOfAccess node to the tio:DiscountType for which the specified access is granted."</para>
    /// labels<para>"eligibleAudience (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#eligibleAudience">http://purl.org/tio/ns#eligibleAudience</seealso>
    let eligibleAudience = Prefixed_Name(tio, "eligibleAudience") |> PrefixedName

    /// <summary>
    ///   <para>tio:eligibleServiceLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This indicates the service level(s) or fare class(es) to which the tio:Ticket entitles."</para>
    /// labels<para>"eligibleServiceLevel (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#eligibleServiceLevel">http://purl.org/tio/ns#eligibleServiceLevel</seealso>
    let eligibleServiceLevel =
        Prefixed_Name(tio, "eligibleServiceLevel") |> PrefixedName

    /// <summary>
    ///   <para>tio:eligibleTimes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This links a tio:ScopeOfAccess node to one or more gr:OpeningHoursSpecifications that indicate the times of access.
    ///
    /// Note: The times of access for a particular ticket may be more constrained than the opening hours of the location, event, or transportation service. Use tio:openingHours for specifying the overall opening hours or hours of operation."</para>
    /// labels<para>"eligibleTimes (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#eligibleTimes">http://purl.org/tio/ns#eligibleTimes</seealso>
    let eligibleTimes = Prefixed_Name(tio, "eligibleTimes") |> PrefixedName
    /// <summary>
    ///   <para>tio:ends</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date and time for which the event is scheduled to end
    ///
    /// Note: You can attach the time and date of the event using tio:starts and tio:ends as simple datatype properties,
    /// even if lode:Event and event:Event recommend other, more sophisticated ways of modeling the temporal aspects of events."</para>
    /// labels<para>"ends (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#ends">http://purl.org/tio/ns#ends</seealso>
    let ends = Prefixed_Name(tio, "ends") |> PrefixedName
    /// <summary>
    ///   <para>tio:flightNo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The flight number (or numbers, in case of codeshare flights)"</para>
    /// labels<para>"flightNo (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#flightNo">http://purl.org/tio/ns#flightNo</seealso>
    let flightNo = Prefixed_Name(tio, "flightNo") |> PrefixedName
    /// <summary>
    ///   <para>tio:from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This indicates the location of origin and time of departure.
    ///
    /// Note: When the object of the statement is a tio:Stop, one can indicate the exact date and time for a single connection.
    /// If such a level of detail is not needed, you can directly link to a point of interest, e.g. an instance of tio:POI."</para>
    /// labels<para>"from (1..1)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#from">http://purl.org/tio/ns#from</seealso>
    let from = Prefixed_Name(tio, "from") |> PrefixedName
    /// <summary>
    ///   <para>tio:includes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"This indicates that a particular area includes another area or points of interest.
    ///
    /// Note: Modeling geo-spatial relationships is non-trivial. This property is a very simple approach, sufficient for e.g. grouping all train stations in a particular fare area."</para>
    /// labels<para>"includes (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#includes">http://purl.org/tio/ns#includes</seealso>
    let includes = Prefixed_Name(tio, "includes") |> PrefixedName
    /// <summary>
    ///   <para>tio:noOfEntrances</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The number of times the respective participant(s) is/are allowed to enter the event, POI, or transportation service
    /// Typical unit code(s): C62 for times "</para>
    /// labels<para>"noOfEntrances (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#noOfEntrances">http://purl.org/tio/ns#noOfEntrances</seealso>
    let noOfEntrances = Prefixed_Name(tio, "noOfEntrances") |> PrefixedName
    /// <summary>
    ///   <para>tio:openingHours</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This indicates the opening hours for a point of interest.
    ///
    /// Note: The opening hours of the location and the time-windows for which a particular ticket is eligible may differ. Use tio:eligibleTimes for the latter."</para>
    /// labels<para>"openingHours (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#openingHours">http://purl.org/tio/ns#openingHours</seealso>
    let openingHours = Prefixed_Name(tio, "openingHours") |> PrefixedName
    /// <summary>
    ///   <para>tio:operatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This indicates the business entity that actually operates the vessel used for a transportation service."</para>
    /// labels<para>"operatedBy (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#operatedBy">http://purl.org/tio/ns#operatedBy</seealso>
    let operatedBy = Prefixed_Name(tio, "operatedBy") |> PrefixedName
    /// <summary>
    ///   <para>tio:participants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The number of participants that are allowed to enter the event, POI, or use transportation service
    /// Typical unit code(s): C62 for persons "</para>
    /// labels<para>"participants (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#participants">http://purl.org/tio/ns#participants</seealso>
    let participants = Prefixed_Name(tio, "participants") |> PrefixedName
    /// <summary>
    ///   <para>tio:scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This links a tio:Ticket to the tio:ScopeOfAccess node or nodes that are included in the ticket.
    ///
    /// Note: For simple scenarios, you can also directly use tio:accessTo."</para>
    /// labels<para>"scope (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#scope">http://purl.org/tio/ns#scope</seealso>
    let scope = Prefixed_Name(tio, "scope") |> PrefixedName
    /// <summary>
    ///   <para>tio:seat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This indicates the seat or seat category."</para>
    /// labels<para>"seat (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#seat">http://purl.org/tio/ns#seat</seealso>
    let seat = Prefixed_Name(tio, "seat") |> PrefixedName
    /// <summary>
    ///   <para>tio:sold</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The number of tickets of this category already sold at the time of publishing the data"</para>
    /// labels<para>"sold (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#sold">http://purl.org/tio/ns#sold</seealso>
    let sold = Prefixed_Name(tio, "sold") |> PrefixedName
    /// <summary>
    ///   <para>tio:starts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date and time for which the event is scheduled to begin
    ///
    /// Note: You can attach the time and date of the event using tio:starts and tio:ends as simple datatype properties,
    /// even if lode:Event and event:Event recommend other, more sophisticated ways of modeling the temporal aspects of events."</para>
    /// labels<para>"starts (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#starts">http://purl.org/tio/ns#starts</seealso>
    let starts = Prefixed_Name(tio, "starts") |> PrefixedName
    /// <summary>
    ///   <para>tio:takesPlaceAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This indicates the location or locations of a tio:Event."</para>
    /// labels<para>"takesPlaceAt (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#takesPlaceAt">http://purl.org/tio/ns#takesPlaceAt</seealso>
    let takesPlaceAt = Prefixed_Name(tio, "takesPlaceAt") |> PrefixedName
    /// <summary>
    ///   <para>tio:ticketID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A unique identifier for a particular ticket or ticket type."</para>
    /// labels<para>"ticketID (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#ticketID">http://purl.org/tio/ns#ticketID</seealso>
    let ticketID = Prefixed_Name(tio, "ticketID") |> PrefixedName
    /// <summary>
    ///   <para>tio:to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This indicates the destination and time of arrival.
    ///
    /// Note: When the object of the statement is a tio:Stop, one can indicate the exact date and time for a single connection.
    /// If such a level of detail is not needed, you can directly link to a point of interest, e.g. an instance of tio:POI."</para>
    /// labels<para>"to (1..1)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#to">http://purl.org/tio/ns#to</seealso>
    let to_ = Prefixed_Name(tio, "to") |> PrefixedName
    /// <summary>
    ///   <para>tio:total</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The total number of tickets of this category that will be issued for the event"</para>
    /// labels<para>"total (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#total">http://purl.org/tio/ns#total</seealso>
    let total = Prefixed_Name(tio, "total") |> PrefixedName
    /// <summary>
    ///   <para>tio:validFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies the beginning of the validity of the access or right that the ticket grants.
    /// It can be attached to the tio:Ticket (if meant for the ticket as a whole) and to individual tio:ScopeOfAccess entities (if meant for just a particular part of the access rights).
    ///
    /// A time-zone should be specified. For a time in GMT/UTC, simply add a "Z" following the time:
    ///
    /// 2010-11-15T09:30:10Z.
    ///
    /// Alternatively, you can specify an offset from the UTC time by adding a positive or negative time following the time:
    ///
    /// 2010-11-15T09:30:10-09:00
    ///
    /// or
    ///
    /// 2010-11-15T09:30:10+09:00."</para>
    /// labels<para>"validFrom (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#validFrom">http://purl.org/tio/ns#validFrom</seealso>
    let validFrom = Prefixed_Name(tio, "validFrom") |> PrefixedName
    /// <summary>
    ///   <para>tio:validThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies the ending of the validity of the access or right that the ticket grants.
    /// It can be attached to the tio:Ticket (if meant for the ticket as a whole) and to individual tio:ScopeOfAccess entities (if meant for just a particular part of the access rights).
    ///
    /// A time-zone should be specified. For a time in GMT/UTC, simply add a "Z" following the time:
    ///
    /// 2010-11-15T09:30:10Z.
    ///
    /// Alternatively, you can specify an offset from the UTC time by adding a positive or negative time following the time:
    ///
    /// 2010-11-15T09:30:10-09:00
    ///
    /// or
    ///
    /// 2010-11-15T09:30:10+09:00."</para>
    /// labels<para>"validThrough (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#validThrough">http://purl.org/tio/ns#validThrough</seealso>
    let validThrough = Prefixed_Name(tio, "validThrough") |> PrefixedName
    /// <summary>
    ///   <para>tio:via</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This indicates the location, time of arrival, and time of departure for an intermediate stop.
    ///
    /// Note: When the object of the statement is a tio:Stop, one can indicate the exact date and time for a single connection.
    /// If such a level of detail is not needed, you can directly link to a point of interest, e.g. an instance of tio:POI."</para>
    /// labels<para>"via (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/tio/ns#via">http://purl.org/tio/ns#via</seealso>
    let via = Prefixed_Name(tio, "via") |> PrefixedName
