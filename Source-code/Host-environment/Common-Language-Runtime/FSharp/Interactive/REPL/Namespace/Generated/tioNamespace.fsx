#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tio =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/tio/ns#" "tio"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : ActualTicket (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : An actual ticket is single, identifiable right to access a particular event, location, or transportation service.</para>
    ///   <a href="http://purl.org/tio/ns#ActualTicket">tio:ActualTicket</a>
    /// </summary>
    let ActualTicket = _prefixId.prefix "ActualTicket"
    let BusinessClass = _prefixId.prefix "BusinessClass"
    /// <summary>
    ///   <para>rdfs:label : CoachService</para>
    ///   <para>rdfs:comment : A regular or individual service to transport passengers or cargo from one location to another location by means of a coach or bus.</para>
    ///   <a href="http://purl.org/tio/ns#CoachService">tio:CoachService</a>
    /// </summary>
    let CoachService = _prefixId.prefix "CoachService"
    /// <summary>
    ///   <para>rdfs:label : DiscountType (gr:QualitativeValue)</para>
    ///   <para>rdfs:comment : The class of qualitative values indicating a discount type, audience, or group type - e.g. students, military personnel, etc.
    ///
    /// Note: Discount types that solely represent age ranges (e.g. children, senior citizens, ...) are better expressed using tio:ageRange.</para>
    ///   <a href="http://purl.org/tio/ns#DiscountType">tio:DiscountType</a>
    /// </summary>
    let DiscountType = _prefixId.prefix "DiscountType"
    let Economy = _prefixId.prefix "Economy"
    let Etix = _prefixId.prefix "Etix"
    /// <summary>
    ///   <para>rdfs:comment : An event, e.g. a concert, a show, etc. You can also safely use the following external classes for describing the respective event:
    ///
    /// http://linkedevents.org/ontology/Event (lode:Event)
    /// http://purl.org/NET/c4dm/event.owl#Event (event:Event)
    /// http://www.loa-cnr.it/ontologies/DUL.owl#Event (dul:Event)
    ///
    /// Note: You can attach the time and date of the event using tio:starts and tio:ends as simple datatype properties, even if lode:Event and event:Event recommend other, more sophisticated ways of modeling the temporal aspects of events.</para>
    ///   <para>rdfs:label : Event</para>
    ///   <a href="http://purl.org/tio/ns#Event">tio:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    let FirstClass = _prefixId.prefix "FirstClass"
    /// <summary>
    ///   <para>rdfs:label : Flight</para>
    ///   <para>rdfs:comment : A regular or individual service to transport passengers or cargo from one location to another location by means of an aircraft
    ///
    /// Note: By design, the Tickets Ontology does not provide mechanisms for modeling rules for recurring patterns of transportation services (e.g. every Monday at 8:00). Instead, it expects that you materialize each individual connection on a given day.
    /// Most flight schedule applications are complex databases, so they will have to be exposed as SPARQL endpoints anyway.</para>
    ///   <a href="http://purl.org/tio/ns#Flight">tio:Flight</a>
    /// </summary>
    let Flight = _prefixId.prefix "Flight"
    /// <summary>
    ///   <para>rdfs:label : POI (gr:LocationOfSalesOrServiceProvisioning)</para>
    ///   <para>rdfs:comment : A point or area of interest, e.g. a museum, a train station, an airport, a bus stop, a store, a box office, etc.
    ///
    /// Note 1: Use existing vocabularies like vcard or geo to attach address and geoposition (lat/long) details to the location.
    /// Note 2: You can safely re-use any existing location, area, or point of interest from other data sources, e.g. DBPedia.</para>
    ///   <a href="http://purl.org/tio/ns#POI">tio:POI</a>
    /// </summary>
    let POI = _prefixId.prefix "POI"
    /// <summary>
    ///   <para>rdfs:label : ScopeOfAccess</para>
    ///   <para>rdfs:comment : This is a conceptual entity that collates all properties defining the type of access a ticket provides to a particular event, location, or transportation.</para>
    ///   <a href="http://purl.org/tio/ns#ScopeOfAccess">tio:ScopeOfAccess</a>
    /// </summary>
    let ScopeOfAccess = _prefixId.prefix "ScopeOfAccess"
    /// <summary>
    ///   <para>rdfs:label : SeatOrSeatCategory (gr:QualitativeValue)</para>
    ///   <para>rdfs:comment : The class of qualitative values indicating a seat position (e.g. the seat 4B in a given plane) or a seat category (e.g. window seat).
    ///     Note that the same vessel or building may have multiple seating layouts.</para>
    ///   <a href="http://purl.org/tio/ns#SeatOrSeatCategory">tio:SeatOrSeatCategory</a>
    /// </summary>
    let SeatOrSeatCategory = _prefixId.prefix "SeatOrSeatCategory"
    /// <summary>
    ///   <para>rdfs:comment : A seating layout for a particular location, vessel, or single transportation service</para>
    ///   <para>rdfs:label : SeatingLayout</para>
    ///   <a href="http://purl.org/tio/ns#SeatingLayout">tio:SeatingLayout</a>
    /// </summary>
    let SeatingLayout = _prefixId.prefix "SeatingLayout"
    /// <summary>
    ///   <para>rdfs:label : ServiceLevel (gr:QualitativeValue)</para>
    ///   <para>rdfs:comment : The class of qualitative values indicating a service level oder fare class (e.g. Business Class).</para>
    ///   <a href="http://purl.org/tio/ns#ServiceLevel">tio:ServiceLevel</a>
    /// </summary>
    let ServiceLevel = _prefixId.prefix "ServiceLevel"
    /// <summary>
    ///   <para>rdfs:comment : The initial, final, or any intermediate point in time and space of a particular tio:TransportationService,
    /// characterized by its location (tio:at), arrival time (tio:arrives), and departure time (tio:departs).
    /// Each tio:TransportationService has at least one tio:Stop for the point and time of departure and another one for the final destination.</para>
    ///   <para>rdfs:label : Stop</para>
    ///   <a href="http://purl.org/tio/ns#Stop">tio:Stop</a>
    /// </summary>
    let Stop = _prefixId.prefix "Stop"
    /// <summary>
    ///   <para>rdfs:label : Taxi</para>
    ///   <para>rdfs:comment : A taxi service to transport passengers from one location to another location</para>
    ///   <a href="http://purl.org/tio/ns#Taxi">tio:Taxi</a>
    /// </summary>
    let Taxi = _prefixId.prefix "Taxi"
    /// <summary>
    ///   <para>rdfs:label : Ticket (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A ticket is a tradeable right to access a particular event or location, or to use a particular transportation service.</para>
    ///   <a href="http://purl.org/tio/ns#Ticket">tio:Ticket</a>
    /// </summary>
    let Ticket = _prefixId.prefix "Ticket"
    /// <summary>
    ///   <para>rdfs:label : TicketPlaceholder (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A ticket placeholder is a dummy for multiple tickets that are themselves not exposed as data.</para>
    ///   <a href="http://purl.org/tio/ns#TicketPlaceholder">tio:TicketPlaceholder</a>
    /// </summary>
    let TicketPlaceholder = _prefixId.prefix "TicketPlaceholder"
    /// <summary>
    ///   <para>rdfs:label : TrainService</para>
    ///   <para>rdfs:comment : A regular or individual service to transport passengers or cargo from one location to another location by means of a train, subway, or other railroad vehicle
    ///
    /// Note: By design, the Tickets Ontology does not provide mechanisms for modeling rules for recurring patterns of transportation services (e.g. every Monday at 8:00). Instead, it expects that you materialize each individual connection on a given day.
    /// Most train schedule applications are complex databases, so they will have to be exposed as SPARQL endpoints anyway.</para>
    ///   <a href="http://purl.org/tio/ns#TrainService">tio:TrainService</a>
    /// </summary>
    let TrainService = _prefixId.prefix "TrainService"
    /// <summary>
    ///   <para>rdfs:label : TransportationService</para>
    ///   <para>rdfs:comment : A service to transport passengers or cargo from one location to another location, with optionally intermediate stops
    ///
    /// Note: By design, the Tickets Ontology does not provide mechanisms for modeling rules for recurring patterns of transportation services (e.g. every Monday at 8:00). Instead, it expects that you materialize each individual connection on a given day.
    /// Most timetable applications are complex databases, so they will have to be exposed as SPARQL endpoints anyway.</para>
    ///   <a href="http://purl.org/tio/ns#TransportationService">tio:TransportationService</a>
    /// </summary>
    let TransportationService = _prefixId.prefix "TransportationService"
    /// <summary>
    ///   <para>rdfs:label : accessTo (0..*)</para>
    ///   <para>rdfs:comment : This links a tio:Ticket or a tio:ScopeOfAccess node to the tio:POI, tio:Event, or tio:TransportationService for which the tio:Ticket grants access.
    ///
    /// Note: When used to link a tio:Ticket directly to a tio:POI, tio:Event, or tio:TransportationService, you cannot specify the various details of a tio:ScopeOfAccess node.</para>
    ///   <a href="http://purl.org/tio/ns#accessTo">tio:accessTo</a>
    /// </summary>
    let accessTo = _prefixId.prefix "accessTo"
    /// <summary>
    ///   <para>rdfs:label : ageRange (0..*)</para>
    ///   <para>rdfs:comment : The eligible age range or age ranges for admission to the revent, POI, or transportation service
    /// Typical unit code(s): ANN for year (less frequently used: MON for months, WEE for weeks)</para>
    ///   <a href="http://purl.org/tio/ns#ageRange">tio:ageRange</a>
    /// </summary>
    let ageRange = _prefixId.prefix "ageRange"
    /// <summary>
    ///   <para>rdfs:label : arrives (0..1)</para>
    ///   <para>rdfs:comment : The date and time at which the transportation service will arrive at the respective tio:Stop</para>
    ///   <a href="http://purl.org/tio/ns#arrives">tio:arrives</a>
    /// </summary>
    let arrives = _prefixId.prefix "arrives"
    /// <summary>
    ///   <para>rdfs:label : at (1..1)</para>
    ///   <para>rdfs:comment : This indicates the location of a tio:Stop.</para>
    ///   <a href="http://purl.org/tio/ns#at">tio:at</a>
    /// </summary>
    let at = _prefixId.prefix "at"
    /// <summary>
    ///   <para>rdfs:label : available (0..1)</para>
    ///   <para>rdfs:comment : The number of tickets of this category still available at the time of publishing the data</para>
    ///   <a href="http://purl.org/tio/ns#available">tio:available</a>
    /// </summary>
    let available = _prefixId.prefix "available"
    /// <summary>
    ///   <para>rdfs:label : availableLayouts (0..*)</para>
    ///   <para>rdfs:comment : This indicates the available seating layouts for a tio:POI.</para>
    ///   <a href="http://purl.org/tio/ns#availableLayouts">tio:availableLayouts</a>
    /// </summary>
    let availableLayouts = _prefixId.prefix "availableLayouts"
    /// <summary>
    ///   <para>rdfs:label : availableSeats (0..*)</para>
    ///   <para>rdfs:comment : This indicates the individual seats for a given seating layout.</para>
    ///   <a href="http://purl.org/tio/ns#availableSeats">tio:availableSeats</a>
    /// </summary>
    let availableSeats = _prefixId.prefix "availableSeats"
    /// <summary>
    ///   <para>rdfs:label : availableServiceLevel (0..*)</para>
    ///   <para>rdfs:comment : This indicates the service level(s) or fare class(es) available for the particular tio:TransportationService.</para>
    ///   <a href="http://purl.org/tio/ns#availableServiceLevel">tio:availableServiceLevel</a>
    /// </summary>
    let availableServiceLevel = _prefixId.prefix "availableServiceLevel"
    /// <summary>
    ///   <para>rdfs:label : departs (0..1)</para>
    ///   <para>rdfs:comment : The date and time at which the transportation service will depart from the respective tio:Stop</para>
    ///   <a href="http://purl.org/tio/ns#departs">tio:departs</a>
    /// </summary>
    let departs = _prefixId.prefix "departs"
    /// <summary>
    ///   <para>rdfs:label : durationOfAccess (0..1)</para>
    ///   <para>rdfs:comment : The eligible duration of uninterrupted attendance or access.
    /// Typical unit code(s): HUR for hours, DAY for days, WEE for weeks, MON for months, ANN for years </para>
    ///   <a href="http://purl.org/tio/ns#durationOfAccess">tio:durationOfAccess</a>
    /// </summary>
    let durationOfAccess = _prefixId.prefix "durationOfAccess"
    /// <summary>
    ///   <para>rdfs:label : eligibleAudience (0..*)</para>
    ///   <para>rdfs:comment : This links a tio:ScopeOfAccess node to the tio:DiscountType for which the specified access is granted.</para>
    ///   <a href="http://purl.org/tio/ns#eligibleAudience">tio:eligibleAudience</a>
    /// </summary>
    let eligibleAudience = _prefixId.prefix "eligibleAudience"
    /// <summary>
    ///   <para>rdfs:label : eligibleServiceLevel (0..*)</para>
    ///   <para>rdfs:comment : This indicates the service level(s) or fare class(es) to which the tio:Ticket entitles.</para>
    ///   <a href="http://purl.org/tio/ns#eligibleServiceLevel">tio:eligibleServiceLevel</a>
    /// </summary>
    let eligibleServiceLevel = _prefixId.prefix "eligibleServiceLevel"
    /// <summary>
    ///   <para>rdfs:label : eligibleTimes (0..*)</para>
    ///   <para>rdfs:comment : This links a tio:ScopeOfAccess node to one or more gr:OpeningHoursSpecifications that indicate the times of access.
    ///
    /// Note: The times of access for a particular ticket may be more constrained than the opening hours of the location, event, or transportation service. Use tio:openingHours for specifying the overall opening hours or hours of operation.</para>
    ///   <a href="http://purl.org/tio/ns#eligibleTimes">tio:eligibleTimes</a>
    /// </summary>
    let eligibleTimes = _prefixId.prefix "eligibleTimes"
    /// <summary>
    ///   <para>rdfs:label : ends (0..1)</para>
    ///   <para>rdfs:comment : The date and time for which the event is scheduled to end
    ///
    /// Note: You can attach the time and date of the event using tio:starts and tio:ends as simple datatype properties,
    /// even if lode:Event and event:Event recommend other, more sophisticated ways of modeling the temporal aspects of events.</para>
    ///   <a href="http://purl.org/tio/ns#ends">tio:ends</a>
    /// </summary>
    let ends = _prefixId.prefix "ends"
    /// <summary>
    ///   <para>rdfs:label : flightNo (0..*)</para>
    ///   <para>rdfs:comment : The flight number (or numbers, in case of codeshare flights)</para>
    ///   <a href="http://purl.org/tio/ns#flightNo">tio:flightNo</a>
    /// </summary>
    let flightNo = _prefixId.prefix "flightNo"
    /// <summary>
    ///   <para>rdfs:label : from (1..1)</para>
    ///   <para>rdfs:comment : This indicates the location of origin and time of departure.
    ///
    /// Note: When the object of the statement is a tio:Stop, one can indicate the exact date and time for a single connection.
    /// If such a level of detail is not needed, you can directly link to a point of interest, e.g. an instance of tio:POI.</para>
    ///   <a href="http://purl.org/tio/ns#from">tio:from</a>
    /// </summary>
    let from = _prefixId.prefix "from"
    /// <summary>
    ///   <para>rdfs:label : includes (0..*)</para>
    ///   <para>rdfs:comment : This indicates that a particular area includes another area or points of interest.
    ///
    /// Note: Modeling geo-spatial relationships is non-trivial. This property is a very simple approach, sufficient for e.g. grouping all train stations in a particular fare area.</para>
    ///   <a href="http://purl.org/tio/ns#includes">tio:includes</a>
    /// </summary>
    let includes = _prefixId.prefix "includes"
    /// <summary>
    ///   <para>rdfs:label : noOfEntrances (0..1)</para>
    ///   <para>rdfs:comment : The number of times the respective participant(s) is/are allowed to enter the event, POI, or transportation service
    /// Typical unit code(s): C62 for times </para>
    ///   <a href="http://purl.org/tio/ns#noOfEntrances">tio:noOfEntrances</a>
    /// </summary>
    let noOfEntrances = _prefixId.prefix "noOfEntrances"
    /// <summary>
    ///   <para>rdfs:label : openingHours (0..*)</para>
    ///   <para>rdfs:comment : This indicates the opening hours for a point of interest.
    ///
    /// Note: The opening hours of the location and the time-windows for which a particular ticket is eligible may differ. Use tio:eligibleTimes for the latter.</para>
    ///   <a href="http://purl.org/tio/ns#openingHours">tio:openingHours</a>
    /// </summary>
    let openingHours = _prefixId.prefix "openingHours"
    /// <summary>
    ///   <para>rdfs:label : operatedBy (0..1)</para>
    ///   <para>rdfs:comment : This indicates the business entity that actually operates the vessel used for a transportation service.</para>
    ///   <a href="http://purl.org/tio/ns#operatedBy">tio:operatedBy</a>
    /// </summary>
    let operatedBy = _prefixId.prefix "operatedBy"
    /// <summary>
    ///   <para>rdfs:label : participants (0..1)</para>
    ///   <para>rdfs:comment : The number of participants that are allowed to enter the event, POI, or use transportation service
    /// Typical unit code(s): C62 for persons </para>
    ///   <a href="http://purl.org/tio/ns#participants">tio:participants</a>
    /// </summary>
    let participants = _prefixId.prefix "participants"
    /// <summary>
    ///   <para>rdfs:label : scope (0..*)</para>
    ///   <para>rdfs:comment : This links a tio:Ticket to the tio:ScopeOfAccess node or nodes that are included in the ticket.
    ///
    /// Note: For simple scenarios, you can also directly use tio:accessTo.</para>
    ///   <a href="http://purl.org/tio/ns#scope">tio:scope</a>
    /// </summary>
    let scope = _prefixId.prefix "scope"
    /// <summary>
    ///   <para>rdfs:label : seat (0..*)</para>
    ///   <para>rdfs:comment : This indicates the seat or seat category.</para>
    ///   <a href="http://purl.org/tio/ns#seat">tio:seat</a>
    /// </summary>
    let seat = _prefixId.prefix "seat"
    /// <summary>
    ///   <para>rdfs:label : sold (0..1)</para>
    ///   <para>rdfs:comment : The number of tickets of this category already sold at the time of publishing the data</para>
    ///   <a href="http://purl.org/tio/ns#sold">tio:sold</a>
    /// </summary>
    let sold = _prefixId.prefix "sold"
    /// <summary>
    ///   <para>rdfs:label : starts (0..1)</para>
    ///   <para>rdfs:comment : The date and time for which the event is scheduled to begin
    ///
    /// Note: You can attach the time and date of the event using tio:starts and tio:ends as simple datatype properties,
    /// even if lode:Event and event:Event recommend other, more sophisticated ways of modeling the temporal aspects of events.</para>
    ///   <a href="http://purl.org/tio/ns#starts">tio:starts</a>
    /// </summary>
    let starts = _prefixId.prefix "starts"
    /// <summary>
    ///   <para>rdfs:label : takesPlaceAt (0..*)</para>
    ///   <para>rdfs:comment : This indicates the location or locations of a tio:Event.</para>
    ///   <a href="http://purl.org/tio/ns#takesPlaceAt">tio:takesPlaceAt</a>
    /// </summary>
    let takesPlaceAt = _prefixId.prefix "takesPlaceAt"
    /// <summary>
    ///   <para>rdfs:label : ticketID (0..1)</para>
    ///   <para>rdfs:comment : A unique identifier for a particular ticket or ticket type.</para>
    ///   <a href="http://purl.org/tio/ns#ticketID">tio:ticketID</a>
    /// </summary>
    let ticketID = _prefixId.prefix "ticketID"
    /// <summary>
    ///   <para>rdfs:label : to (1..1)</para>
    ///   <para>rdfs:comment : This indicates the destination and time of arrival.
    ///
    /// Note: When the object of the statement is a tio:Stop, one can indicate the exact date and time for a single connection.
    /// If such a level of detail is not needed, you can directly link to a point of interest, e.g. an instance of tio:POI.</para>
    ///   <a href="http://purl.org/tio/ns#to">tio:to</a>
    /// </summary>
    let to_ = _prefixId.prefix "to"
    /// <summary>
    ///   <para>rdfs:label : total (0..1)</para>
    ///   <para>rdfs:comment : The total number of tickets of this category that will be issued for the event</para>
    ///   <a href="http://purl.org/tio/ns#total">tio:total</a>
    /// </summary>
    let total = _prefixId.prefix "total"
    /// <summary>
    ///   <para>rdfs:label : validFrom (0..1)</para>
    ///   <para>rdfs:comment : This property specifies the beginning of the validity of the access or right that the ticket grants.
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
    /// 2010-11-15T09:30:10+09:00.</para>
    ///   <a href="http://purl.org/tio/ns#validFrom">tio:validFrom</a>
    /// </summary>
    let validFrom = _prefixId.prefix "validFrom"
    /// <summary>
    ///   <para>rdfs:label : validThrough (0..1)</para>
    ///   <para>rdfs:comment : This property specifies the ending of the validity of the access or right that the ticket grants.
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
    /// 2010-11-15T09:30:10+09:00.</para>
    ///   <a href="http://purl.org/tio/ns#validThrough">tio:validThrough</a>
    /// </summary>
    let validThrough = _prefixId.prefix "validThrough"
    /// <summary>
    ///   <para>rdfs:label : via (0..*)</para>
    ///   <para>rdfs:comment : This indicates the location, time of arrival, and time of departure for an intermediate stop.
    ///
    /// Note: When the object of the statement is a tio:Stop, one can indicate the exact date and time for a single connection.
    /// If such a level of detail is not needed, you can directly link to a point of interest, e.g. an instance of tio:POI.</para>
    ///   <a href="http://purl.org/tio/ns#via">tio:via</a>
    /// </summary>
    let via = _prefixId.prefix "via"
