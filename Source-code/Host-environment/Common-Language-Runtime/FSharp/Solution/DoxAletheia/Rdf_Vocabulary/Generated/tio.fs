namespace http.purl.org.tio.ns.hash

open DoxAletheia

module tio =
    let _namespace_name = "http://purl.org/tio/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An actual ticket is single, identifiable right to access a particular event, location, or transportation service.
    /// <see href="http://purl.org/tio/ns#ActualTicket"></see></summary>
    let ActualTicket = _prefix "ActualTicket"
    /// <summary>
    /// A ticket is a tradeable right to access a particular event or location, or to use a particular transportation service.
    /// <see href="http://purl.org/tio/ns#Ticket"></see></summary>
    let Ticket = _prefix "Ticket"
    /// <summary>
    /// A ticket placeholder is a dummy for multiple tickets that are themselves not exposed as data.
    /// <see href="http://purl.org/tio/ns#TicketPlaceholder"></see></summary>
    let TicketPlaceholder = _prefix "TicketPlaceholder"
    /// <summary>
    /// Business class as a service level / fare class for transportation by aircraft
    ///
    /// Note: The exact character of a particular fare class may vary by carrier or country.
    /// You can create individual instances of tio:ServiceLevel for a particular fare class for a particular airline.
    /// <see href="http://purl.org/tio/ns#BusinessClass"></see></summary>
    let BusinessClass = _prefix "BusinessClass"
    /// <summary>
    /// Economy class as a service level / fare class for transportation by aircraft
    ///
    /// Note: The exact character of a particular fare class may vary by carrier or country.
    /// You can create individual instances of tio:ServiceLevel for a particular fare class for a particular airline.
    /// <see href="http://purl.org/tio/ns#Economy"></see></summary>
    let Economy = _prefix "Economy"
    /// <summary>
    /// The class of qualitative values indicating a service level oder fare class (e.g. Business Class).
    /// <see href="http://purl.org/tio/ns#ServiceLevel"></see></summary>
    let ServiceLevel = _prefix "ServiceLevel"
    /// <summary>
    /// A regular or individual service to transport passengers or cargo from one location to another location by means of a coach or bus.
    /// <see href="http://purl.org/tio/ns#CoachService"></see></summary>
    let CoachService = _prefix "CoachService"
    /// <summary>
    /// A service to transport passengers or cargo from one location to another location, with optionally intermediate stops
    ///
    /// Note: By design, the Tickets Ontology does not provide mechanisms for modeling rules for recurring patterns of transportation services (e.g. every Monday at 8:00). Instead, it expects that you materialize each individual connection on a given day.
    /// Most timetable applications are complex databases, so they will have to be exposed as SPARQL endpoints anyway.
    /// <see href="http://purl.org/tio/ns#TransportationService"></see></summary>
    let TransportationService = _prefix "TransportationService"
    /// <summary>
    /// A regular or individual service to transport passengers or cargo from one location to another location by means of a train, subway, or other railroad vehicle
    ///
    /// Note: By design, the Tickets Ontology does not provide mechanisms for modeling rules for recurring patterns of transportation services (e.g. every Monday at 8:00). Instead, it expects that you materialize each individual connection on a given day.
    /// Most train schedule applications are complex databases, so they will have to be exposed as SPARQL endpoints anyway.
    /// <see href="http://purl.org/tio/ns#TrainService"></see></summary>
    let TrainService = _prefix "TrainService"
    /// <summary>
    /// A taxi service to transport passengers from one location to another location
    /// <see href="http://purl.org/tio/ns#Taxi"></see></summary>
    let Taxi = _prefix "Taxi"
    /// <summary>
    /// A regular or individual service to transport passengers or cargo from one location to another location by means of an aircraft
    ///
    /// Note: By design, the Tickets Ontology does not provide mechanisms for modeling rules for recurring patterns of transportation services (e.g. every Monday at 8:00). Instead, it expects that you materialize each individual connection on a given day.
    /// Most flight schedule applications are complex databases, so they will have to be exposed as SPARQL endpoints anyway.
    /// <see href="http://purl.org/tio/ns#Flight"></see></summary>
    let Flight = _prefix "Flight"
    /// <summary>
    /// The class of qualitative values indicating a discount type, audience, or group type - e.g. students, military personnel, etc.
    ///
    /// Note: Discount types that solely represent age ranges (e.g. children, senior citizens, ...) are better expressed using tio:ageRange.
    /// <see href="http://purl.org/tio/ns#DiscountType"></see></summary>
    let DiscountType = _prefix "DiscountType"
    /// <summary>
    /// An event, e.g. a concert, a show, etc. You can also safely use the following external classes for describing the respective event:
    ///
    /// http://linkedevents.org/ontology/Event (lode:Event)
    /// http://purl.org/NET/c4dm/event.owl#Event (event:Event)
    /// http://www.loa-cnr.it/ontologies/DUL.owl#Event (dul:Event)
    ///
    /// Note: You can attach the time and date of the event using tio:starts and tio:ends as simple datatype properties, even if lode:Event and event:Event recommend other, more sophisticated ways of modeling the temporal aspects of events.
    /// <see href="http://purl.org/tio/ns#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// The initial, final, or any intermediate point in time and space of a particular tio:TransportationService,
    /// characterized by its location (tio:at), arrival time (tio:arrives), and departure time (tio:departs).
    /// Each tio:TransportationService has at least one tio:Stop for the point and time of departure and another one for the final destination.
    /// <see href="http://purl.org/tio/ns#Stop"></see></summary>
    let Stop = _prefix "Stop"
    /// <summary>
    /// This is a conceptual entity that collates all properties defining the type of access a ticket provides to a particular event, location, or transportation.
    /// <see href="http://purl.org/tio/ns#ScopeOfAccess"></see></summary>
    let ScopeOfAccess = _prefix "ScopeOfAccess"
    /// <summary>
    /// A seating layout for a particular location, vessel, or single transportation service
    /// <see href="http://purl.org/tio/ns#SeatingLayout"></see></summary>
    let SeatingLayout = _prefix "SeatingLayout"
    /// <summary>
    /// A special form of electronic ticket delivery, mainly for flight tickets
    /// <see href="http://purl.org/tio/ns#Etix"></see></summary>
    let Etix = _prefix "Etix"
    /// <summary>
    /// First class as a service level / fare class for transportation by aircraft
    ///
    /// Note: The exact character of a particular fare class may vary by carrier or country.
    /// You can create individual instances of tio:ServiceLevel for a particular fare class for a particular airline.
    /// <see href="http://purl.org/tio/ns#FirstClass"></see></summary>
    let FirstClass = _prefix "FirstClass"
    /// <summary>
    /// A point or area of interest, e.g. a museum, a train station, an airport, a bus stop, a store, a box office, etc.
    ///
    /// Note 1: Use existing vocabularies like vcard or geo to attach address and geoposition (lat/long) details to the location.
    /// Note 2: You can safely re-use any existing location, area, or point of interest from other data sources, e.g. DBPedia.
    /// <see href="http://purl.org/tio/ns#POI"></see></summary>
    let POI = _prefix "POI"
    /// <summary>
    /// The class of qualitative values indicating a seat position (e.g. the seat 4B in a given plane) or a seat category (e.g. window seat).
    ///     Note that the same vessel or building may have multiple seating layouts.
    /// <see href="http://purl.org/tio/ns#SeatOrSeatCategory"></see></summary>
    let SeatOrSeatCategory = _prefix "SeatOrSeatCategory"
    /// <summary>
    /// This links a tio:Ticket or a tio:ScopeOfAccess node to the tio:POI, tio:Event, or tio:TransportationService for which the tio:Ticket grants access.
    ///
    /// Note: When used to link a tio:Ticket directly to a tio:POI, tio:Event, or tio:TransportationService, you cannot specify the various details of a tio:ScopeOfAccess node.
    /// <see href="http://purl.org/tio/ns#accessTo"></see></summary>
    let accessTo = _prefix "accessTo"
    /// <summary>
    /// The eligible age range or age ranges for admission to the revent, POI, or transportation service
    /// Typical unit code(s): ANN for year (less frequently used: MON for months, WEE for weeks)
    /// <see href="http://purl.org/tio/ns#ageRange"></see></summary>
    let ageRange = _prefix "ageRange"
    /// <summary>
    /// The date and time at which the transportation service will arrive at the respective tio:Stop
    /// <see href="http://purl.org/tio/ns#arrives"></see></summary>
    let arrives = _prefix "arrives"
    /// <summary>
    /// This indicates the location of a tio:Stop.
    /// <see href="http://purl.org/tio/ns#at"></see></summary>
    let at = _prefix "at"
    /// <summary>
    /// The number of tickets of this category still available at the time of publishing the data
    /// <see href="http://purl.org/tio/ns#available"></see></summary>
    let available = _prefix "available"
    /// <summary>
    /// This indicates the available seating layouts for a tio:POI.
    /// <see href="http://purl.org/tio/ns#availableLayouts"></see></summary>
    let availableLayouts = _prefix "availableLayouts"
    /// <summary>
    /// This indicates the individual seats for a given seating layout.
    /// <see href="http://purl.org/tio/ns#availableSeats"></see></summary>
    let availableSeats = _prefix "availableSeats"
    /// <summary>
    /// This indicates the service level(s) or fare class(es) available for the particular tio:TransportationService.
    /// <see href="http://purl.org/tio/ns#availableServiceLevel"></see></summary>
    let availableServiceLevel = _prefix "availableServiceLevel"
    /// <summary>
    /// The date and time at which the transportation service will depart from the respective tio:Stop
    /// <see href="http://purl.org/tio/ns#departs"></see></summary>
    let departs = _prefix "departs"
    /// <summary>
    /// The eligible duration of uninterrupted attendance or access.
    /// Typical unit code(s): HUR for hours, DAY for days, WEE for weeks, MON for months, ANN for years
    /// <see href="http://purl.org/tio/ns#durationOfAccess"></see></summary>
    let durationOfAccess = _prefix "durationOfAccess"
    /// <summary>
    /// This links a tio:ScopeOfAccess node to the tio:DiscountType for which the specified access is granted.
    /// <see href="http://purl.org/tio/ns#eligibleAudience"></see></summary>
    let eligibleAudience = _prefix "eligibleAudience"
    /// <summary>
    /// This indicates the service level(s) or fare class(es) to which the tio:Ticket entitles.
    /// <see href="http://purl.org/tio/ns#eligibleServiceLevel"></see></summary>
    let eligibleServiceLevel = _prefix "eligibleServiceLevel"
    /// <summary>
    /// This links a tio:ScopeOfAccess node to one or more gr:OpeningHoursSpecifications that indicate the times of access.
    ///
    /// Note: The times of access for a particular ticket may be more constrained than the opening hours of the location, event, or transportation service. Use tio:openingHours for specifying the overall opening hours or hours of operation.
    /// <see href="http://purl.org/tio/ns#eligibleTimes"></see></summary>
    let eligibleTimes = _prefix "eligibleTimes"
    /// <summary>
    /// The date and time for which the event is scheduled to end
    ///
    /// Note: You can attach the time and date of the event using tio:starts and tio:ends as simple datatype properties,
    /// even if lode:Event and event:Event recommend other, more sophisticated ways of modeling the temporal aspects of events.
    /// <see href="http://purl.org/tio/ns#ends"></see></summary>
    let ends = _prefix "ends"
    /// <summary>
    /// The flight number (or numbers, in case of codeshare flights)
    /// <see href="http://purl.org/tio/ns#flightNo"></see></summary>
    let flightNo = _prefix "flightNo"
    /// <summary>
    /// This indicates the location of origin and time of departure.
    ///
    /// Note: When the object of the statement is a tio:Stop, one can indicate the exact date and time for a single connection.
    /// If such a level of detail is not needed, you can directly link to a point of interest, e.g. an instance of tio:POI.
    /// <see href="http://purl.org/tio/ns#from"></see></summary>
    let from = _prefix "from"
    /// <summary>
    /// This indicates that a particular area includes another area or points of interest.
    ///
    /// Note: Modeling geo-spatial relationships is non-trivial. This property is a very simple approach, sufficient for e.g. grouping all train stations in a particular fare area.
    /// <see href="http://purl.org/tio/ns#includes"></see></summary>
    let includes = _prefix "includes"
    /// <summary>
    /// The number of times the respective participant(s) is/are allowed to enter the event, POI, or transportation service
    /// Typical unit code(s): C62 for times
    /// <see href="http://purl.org/tio/ns#noOfEntrances"></see></summary>
    let noOfEntrances = _prefix "noOfEntrances"
    /// <summary>
    /// This indicates the opening hours for a point of interest.
    ///
    /// Note: The opening hours of the location and the time-windows for which a particular ticket is eligible may differ. Use tio:eligibleTimes for the latter.
    /// <see href="http://purl.org/tio/ns#openingHours"></see></summary>
    let openingHours = _prefix "openingHours"
    /// <summary>
    /// This indicates the business entity that actually operates the vessel used for a transportation service.
    /// <see href="http://purl.org/tio/ns#operatedBy"></see></summary>
    let operatedBy = _prefix "operatedBy"
    /// <summary>
    /// The number of participants that are allowed to enter the event, POI, or use transportation service
    /// Typical unit code(s): C62 for persons
    /// <see href="http://purl.org/tio/ns#participants"></see></summary>
    let participants = _prefix "participants"
    /// <summary>
    /// This links a tio:Ticket to the tio:ScopeOfAccess node or nodes that are included in the ticket.
    ///
    /// Note: For simple scenarios, you can also directly use tio:accessTo.
    /// <see href="http://purl.org/tio/ns#scope"></see></summary>
    let scope = _prefix "scope"
    /// <summary>
    /// This indicates the seat or seat category.
    /// <see href="http://purl.org/tio/ns#seat"></see></summary>
    let seat = _prefix "seat"
    /// <summary>
    /// The number of tickets of this category already sold at the time of publishing the data
    /// <see href="http://purl.org/tio/ns#sold"></see></summary>
    let sold = _prefix "sold"
    /// <summary>
    /// The date and time for which the event is scheduled to begin
    ///
    /// Note: You can attach the time and date of the event using tio:starts and tio:ends as simple datatype properties,
    /// even if lode:Event and event:Event recommend other, more sophisticated ways of modeling the temporal aspects of events.
    /// <see href="http://purl.org/tio/ns#starts"></see></summary>
    let starts = _prefix "starts"
    /// <summary>
    /// This indicates the location or locations of a tio:Event.
    /// <see href="http://purl.org/tio/ns#takesPlaceAt"></see></summary>
    let takesPlaceAt = _prefix "takesPlaceAt"
    /// <summary>
    /// A unique identifier for a particular ticket or ticket type.
    /// <see href="http://purl.org/tio/ns#ticketID"></see></summary>
    let ticketID = _prefix "ticketID"
    /// <summary>
    /// This indicates the destination and time of arrival.
    ///
    /// Note: When the object of the statement is a tio:Stop, one can indicate the exact date and time for a single connection.
    /// If such a level of detail is not needed, you can directly link to a point of interest, e.g. an instance of tio:POI.
    /// <see href="http://purl.org/tio/ns#to"></see></summary>
    let to_ = _prefix "to"
    /// <summary>
    /// The total number of tickets of this category that will be issued for the event
    /// <see href="http://purl.org/tio/ns#total"></see></summary>
    let total = _prefix "total"
    /// <summary>
    /// This property specifies the beginning of the validity of the access or right that the ticket grants.
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
    /// 2010-11-15T09:30:10+09:00.
    /// <see href="http://purl.org/tio/ns#validFrom"></see></summary>
    let validFrom = _prefix "validFrom"
    /// <summary>
    /// This property specifies the ending of the validity of the access or right that the ticket grants.
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
    /// 2010-11-15T09:30:10+09:00.
    /// <see href="http://purl.org/tio/ns#validThrough"></see></summary>
    let validThrough = _prefix "validThrough"
    /// <summary>
    /// This indicates the location, time of arrival, and time of departure for an intermediate stop.
    ///
    /// Note: When the object of the statement is a tio:Stop, one can indicate the exact date and time for a single connection.
    /// If such a level of detail is not needed, you can directly link to a point of interest, e.g. an instance of tio:POI.
    /// <see href="http://purl.org/tio/ns#via"></see></summary>
    let via = _prefix "via"
