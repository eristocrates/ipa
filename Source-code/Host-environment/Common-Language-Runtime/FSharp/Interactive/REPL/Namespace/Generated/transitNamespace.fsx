#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module transit =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://vocab.org/transit/terms/" "transit"

    let _namespaceIri = _prefixId.prefix ""
    let ``_.html`` = _prefixId.prefix ".html"
    let ``_.json`` = _prefixId.prefix ".json"
    let ``_.rdf`` = _prefixId.prefix ".rdf"
    let ``_.turtle`` = _prefixId.prefix ".turtle"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Access Arrangement</para>
    ///   <para>rdfs:comment : A type of arrangement for picking up or dropping off passengers from a service stop.</para>
    ///   <a href="http://vocab.org/transit/terms/AccessArrangement">transit:AccessArrangement</a>
    /// </summary>
    let AccessArrangement = _prefixId.prefix "AccessArrangement"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Transit Agency</para>
    ///   <para>rdfs:comment : An organization that oversees public transportation for a city or region.</para>
    ///   <a href="http://vocab.org/transit/terms/Agency">transit:Agency</a>
    /// </summary>
    let Agency = _prefixId.prefix "Agency"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Bus Route</para>
    ///   <para>rdfs:comment : A public transportation route utilising buses on roads for short- or long-distance travel.</para>
    ///   <a href="http://vocab.org/transit/terms/BusRoute">transit:BusRoute</a>
    /// </summary>
    let BusRoute = _prefixId.prefix "BusRoute"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Cable Car Route</para>
    ///   <para>rdfs:comment : A public transportation route utilising street-level cable cars where the cable runs beneath the car.</para>
    ///   <a href="http://vocab.org/transit/terms/CableCarRoute">transit:CableCarRoute</a>
    /// </summary>
    let CableCarRoute = _prefixId.prefix "CableCarRoute"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Fare</para>
    ///   <para>rdfs:comment : A class of fare payable for public transportation.</para>
    ///   <a href="http://vocab.org/transit/terms/Fare">transit:Fare</a>
    /// </summary>
    let Fare = _prefixId.prefix "Fare"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Ferry Route</para>
    ///   <para>rdfs:comment : A public transportation route utilising boats for short- or long-distance travel.</para>
    ///   <a href="http://vocab.org/transit/terms/FerryRoute">transit:FerryRoute</a>
    /// </summary>
    let FerryRoute = _prefixId.prefix "FerryRoute"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Funicular Route</para>
    ///   <para>rdfs:comment : A public transportation route utilising a rail system designed for steep inclines.</para>
    ///   <a href="http://vocab.org/transit/terms/FunicularRoute">transit:FunicularRoute</a>
    /// </summary>
    let FunicularRoute = _prefixId.prefix "FunicularRoute"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Gondala Route</para>
    ///   <para>rdfs:comment : A public transportation route utilising aerial cable cars where the car is suspended from the cable.</para>
    ///   <a href="http://vocab.org/transit/terms/GondalaRoute">transit:GondalaRoute</a>
    /// </summary>
    let GondalaRoute = _prefixId.prefix "GondalaRoute"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Inbound Service</para>
    ///   <para>rdfs:comment : A service that travels in an inbound direction.</para>
    ///   <a href="http://vocab.org/transit/terms/InboundService">transit:InboundService</a>
    /// </summary>
    let InboundService = _prefixId.prefix "InboundService"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Minimum Time Transfer</para>
    ///   <para>rdfs:comment : A transfer point between two routes that requires a minimum amount of time between arrival and departure to ensure a connection.</para>
    ///   <a href="http://vocab.org/transit/terms/MinimumTimeTransfer">transit:MinimumTimeTransfer</a>
    /// </summary>
    let MinimumTimeTransfer = _prefixId.prefix "MinimumTimeTransfer"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Outbound Service</para>
    ///   <para>rdfs:comment : A service that travels in an outbound direction.</para>
    ///   <a href="http://vocab.org/transit/terms/OutboundService">transit:OutboundService</a>
    /// </summary>
    let OutboundService = _prefixId.prefix "OutboundService"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Rail Route</para>
    ///   <para>rdfs:comment : A public transportation route utilising a rail system for intercity or long-distance travel.</para>
    ///   <a href="http://vocab.org/transit/terms/RailRoute">transit:RailRoute</a>
    /// </summary>
    let RailRoute = _prefixId.prefix "RailRoute"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Timed Transfer</para>
    ///   <para>rdfs:comment : A point that is recommended for transfer between two routes.</para>
    ///   <a href="http://vocab.org/transit/terms/RecommendedTransfer">transit:RecommendedTransfer</a>
    /// </summary>
    let RecommendedTransfer = _prefixId.prefix "RecommendedTransfer"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Transit Route</para>
    ///   <para>rdfs:comment : A public transportation route.</para>
    ///   <a href="http://vocab.org/transit/terms/Route">transit:Route</a>
    /// </summary>
    let Route = _prefixId.prefix "Route"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-08-06^^xsd:date</para>
    ///   <para>rdfs:label : Route Stop</para>
    ///   <para>rdfs:comment : A location where passengers board or disembark from a transit vehicle for a specific route.</para>
    ///   <a href="http://vocab.org/transit/terms/RouteStop">transit:RouteStop</a>
    /// </summary>
    let RouteStop = _prefixId.prefix "RouteStop"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Schedule</para>
    ///   <para>rdfs:comment : A public transport schedule that applies for one or more routes.</para>
    ///   <a href="http://vocab.org/transit/terms/Schedule">transit:Schedule</a>
    /// </summary>
    let Schedule = _prefixId.prefix "Schedule"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Service</para>
    ///   <para>rdfs:comment : A public transport service that operates a route on a given schedule.</para>
    ///   <a href="http://vocab.org/transit/terms/Service">transit:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Service Stop</para>
    ///   <para>rdfs:comment : A location where passengers board or disembark from a transit vehicle for a specific service.</para>
    ///   <a href="http://vocab.org/transit/terms/ServiceStop">transit:ServiceStop</a>
    /// </summary>
    let ServiceStop = _prefixId.prefix "ServiceStop"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Transit Station</para>
    ///   <para>rdfs:comment : A physical structure or area that contains one or more stops.</para>
    ///   <a href="http://vocab.org/transit/terms/Station">transit:Station</a>
    /// </summary>
    let Station = _prefixId.prefix "Station"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Transit Stop</para>
    ///   <para>rdfs:comment : A location where passengers board or disembark from a transit vehicle.</para>
    ///   <a href="http://vocab.org/transit/terms/Stop">transit:Stop</a>
    /// </summary>
    let Stop = _prefixId.prefix "Stop"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Subway Route</para>
    ///   <para>rdfs:comment : A public transportation route utilising an underground rail system within a metropolitan area.</para>
    ///   <a href="http://vocab.org/transit/terms/SubwayRoute">transit:SubwayRoute</a>
    /// </summary>
    let SubwayRoute = _prefixId.prefix "SubwayRoute"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Timed Transfer</para>
    ///   <para>rdfs:comment : A transfer point between two routes where the departing vehicle is expected to wait for the arriving one with sufficient time for a passenger to transfer between routes.</para>
    ///   <a href="http://vocab.org/transit/terms/TimedTransfer">transit:TimedTransfer</a>
    /// </summary>
    let TimedTransfer = _prefixId.prefix "TimedTransfer"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Tram Route</para>
    ///   <para>rdfs:comment : A public transportation route utilising light rail or street level railed vehicles within a metropolitan area.</para>
    ///   <a href="http://vocab.org/transit/terms/TramRoute">transit:TramRoute</a>
    /// </summary>
    let TramRoute = _prefixId.prefix "TramRoute"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Transfer</para>
    ///   <para>rdfs:comment : A transfer point between two routes.</para>
    ///   <a href="http://vocab.org/transit/terms/Transfer">transit:Transfer</a>
    /// </summary>
    let Transfer = _prefixId.prefix "Transfer"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Unavailable Transfer</para>
    ///   <para>rdfs:comment : A point where transfer between two routes is not possible despite appearing possible by proximity.</para>
    ///   <a href="http://vocab.org/transit/terms/UnavailableTransfer">transit:UnavailableTransfer</a>
    /// </summary>
    let UnavailableTransfer = _prefixId.prefix "UnavailableTransfer"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Agency</para>
    ///   <para>rdfs:comment : The agency that operates this public transportation route.</para>
    ///   <a href="http://vocab.org/transit/terms/agency">transit:agency</a>
    /// </summary>
    let agency = _prefixId.prefix "agency"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Arrival Time</para>
    ///   <para>rdfs:comment : The time of day at which the service arrives at the stop. The time is measured from "noon minus 12h" (effectively midnight, except for days on which daylight savings time changes occur) at the beginning of the service date. For times occurring after midnight on the service date, the time will be a value greater than 24:00:00 in HH:MM:SS local time for the day on which the trip schedule begins. Services that span multiple dates will have stop times greater than 24:00:00. For example, if a service begins at 10:30:00 p.m. and ends at 2:15:00 a.m. on the following day, the stop times would be 22:30:00 and 26:15:00. </para>
    ///   <a href="http://vocab.org/transit/terms/arrivalTime">transit:arrivalTime</a>
    /// </summary>
    let arrivalTime = _prefixId.prefix "arrivalTime"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2012-01-25^^xsd:date</para>
    ///   <para>rdfs:label : Callsign prefix</para>
    ///   <para>rdfs:comment : The callsign prefix used by an airline to identify itself to air traffic control.</para>
    ///   <a href="http://vocab.org/transit/terms/callsign">transit:callsign</a>
    /// </summary>
    let callsign = _prefixId.prefix "callsign"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Color</para>
    ///   <para>rdfs:comment : A color associated with this route.</para>
    ///   <a href="http://vocab.org/transit/terms/color">transit:color</a>
    /// </summary>
    let color = _prefixId.prefix "color"
    let coordinated = _prefixId.prefix "coordinated"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Currency</para>
    ///   <para>rdfs:comment : The currency of the fare price.</para>
    ///   <a href="http://vocab.org/transit/terms/currency">transit:currency</a>
    /// </summary>
    let currency = _prefixId.prefix "currency"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Date</para>
    ///   <para>rdfs:comment : A date on which this service is scheduled to operate.</para>
    ///   <a href="http://vocab.org/transit/terms/date">transit:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Departure Time</para>
    ///   <para>rdfs:comment : The time of day at which the service departs the stop. The time is measured from "noon minus 12h" (effectively midnight, except for days on which daylight savings time changes occur) at the beginning of the service date. For times occurring after midnight on the service date, the time will be a value greater than 24:00:00 in HH:MM:SS local time for the day on which the trip schedule begins. Services that span multiple dates will have stop times greater than 24:00:00. For example, if a service begins at 10:30:00 p.m. and ends at 2:15:00 a.m. on the following day, the stop times would be 22:30:00 and 26:15:00. </para>
    ///   <a href="http://vocab.org/transit/terms/departureTime">transit:departureTime</a>
    /// </summary>
    let departureTime = _prefixId.prefix "departureTime"
    let disallowed = _prefixId.prefix "disallowed"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Distance</para>
    ///   <para>rdfs:comment : The distance of this service stop from the first stop in sequence.</para>
    ///   <a href="http://vocab.org/transit/terms/distance">transit:distance</a>
    /// </summary>
    let distance = _prefixId.prefix "distance"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Drop Off</para>
    ///   <para>rdfs:comment : The arrangement required for passengers to be dropped off at this service stop.</para>
    ///   <a href="http://vocab.org/transit/terms/dropoff">transit:dropoff</a>
    /// </summary>
    let dropoff = _prefixId.prefix "dropoff"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : From Stop</para>
    ///   <para>rdfs:comment : A stop where a connection between routes begins.</para>
    ///   <a href="http://vocab.org/transit/terms/fromStop">transit:fromStop</a>
    /// </summary>
    let fromStop = _prefixId.prefix "fromStop"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Date</para>
    ///   <para>rdfs:comment : Text that appears on a sign that identifies the service's destination to passengers.</para>
    ///   <a href="http://vocab.org/transit/terms/headsign">transit:headsign</a>
    /// </summary>
    let headsign = _prefixId.prefix "headsign"
    /// <summary>
    ///   <para>dcterms:issued : 2012-01-25^^xsd:date</para>
    ///   <para>rdfs:label : IATA code</para>
    ///   <para>rdfs:comment : The code issued by the International Air Transport Association to identify an airport.</para>
    ///   <a href="http://vocab.org/transit/terms/iataCode">transit:iataCode</a>
    /// </summary>
    let iataCode = _prefixId.prefix "iataCode"
    /// <summary>
    ///   <para>dcterms:issued : 2012-01-25^^xsd:date</para>
    ///   <para>rdfs:label : ICAO code</para>
    ///   <para>rdfs:comment : The code issued by the International Civil Aviation Authority to identify an airport or airline.</para>
    ///   <a href="http://vocab.org/transit/terms/icaoCode">transit:icaoCode</a>
    /// </summary>
    let icaoCode = _prefixId.prefix "icaoCode"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Language</para>
    ///   <para>rdfs:comment : The primary language used by a person or organisation.</para>
    ///   <a href="http://vocab.org/transit/terms/language">transit:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Minimum Transfer Time</para>
    ///   <para>rdfs:comment : The amount of time (in seconds) that must be available in an itinerary to permit a transfer between routes at this transfer point.</para>
    ///   <a href="http://vocab.org/transit/terms/minTransferTime">transit:minTransferTime</a>
    /// </summary>
    let minTransferTime = _prefixId.prefix "minTransferTime"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Pick Up</para>
    ///   <para>rdfs:comment : The arrangement required for passengers to be picked up at this service stop.</para>
    ///   <a href="http://vocab.org/transit/terms/pickup">transit:pickup</a>
    /// </summary>
    let pickup = _prefixId.prefix "pickup"
    let prearranged = _prefixId.prefix "prearranged"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Price</para>
    ///   <para>rdfs:comment : The price of the fare.</para>
    ///   <a href="http://vocab.org/transit/terms/price">transit:price</a>
    /// </summary>
    let price = _prefixId.prefix "price"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Route</para>
    ///   <para>rdfs:comment : A route associated with the given resource.</para>
    ///   <a href="http://vocab.org/transit/terms/route">transit:route</a>
    /// </summary>
    let route = _prefixId.prefix "route"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Route Service</para>
    ///   <para>rdfs:comment : A service that operates on this route.</para>
    ///   <a href="http://vocab.org/transit/terms/routeService">transit:routeService</a>
    /// </summary>
    let routeService = _prefixId.prefix "routeService"
    /// <summary>
    ///   <para>dcterms:issued : 2011-08-06^^xsd:date</para>
    ///   <para>rdfs:label : Route Stop</para>
    ///   <para>rdfs:comment : Links a route to a particular stop and the sequence of that stop in the route.</para>
    ///   <a href="http://vocab.org/transit/terms/routeStop">transit:routeStop</a>
    /// </summary>
    let routeStop = _prefixId.prefix "routeStop"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Schedule</para>
    ///   <para>rdfs:comment : The schedule on which this service operates.</para>
    ///   <a href="http://vocab.org/transit/terms/schedule">transit:schedule</a>
    /// </summary>
    let schedule = _prefixId.prefix "schedule"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Schedule Service</para>
    ///   <para>rdfs:comment : A service that operates on this schedule.</para>
    ///   <a href="http://vocab.org/transit/terms/scheduleService">transit:scheduleService</a>
    /// </summary>
    let scheduleService = _prefixId.prefix "scheduleService"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Sequence</para>
    ///   <para>rdfs:comment : A sequence number for a stop along a route or service. Sequence values are non-negative integers and increase along the route or service however they need not be consecutive.</para>
    ///   <a href="http://vocab.org/transit/terms/sequence">transit:sequence</a>
    /// </summary>
    let sequence = _prefixId.prefix "sequence"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Service</para>
    ///   <para>rdfs:comment : The service associated with this service stop.</para>
    ///   <a href="http://vocab.org/transit/terms/service">transit:service</a>
    /// </summary>
    let service = _prefixId.prefix "service"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Service Stop</para>
    ///   <para>rdfs:comment : The arrival and departure time of a service at a particular stop.</para>
    ///   <a href="http://vocab.org/transit/terms/serviceStop">transit:serviceStop</a>
    /// </summary>
    let serviceStop = _prefixId.prefix "serviceStop"
    let standard = _prefixId.prefix "standard"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Station</para>
    ///   <para>rdfs:comment : The station that this stop is part of.</para>
    ///   <a href="http://vocab.org/transit/terms/station">transit:station</a>
    /// </summary>
    let station = _prefixId.prefix "station"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Station Stop</para>
    ///   <para>rdfs:comment : A stop that is associated with this station.</para>
    ///   <a href="http://vocab.org/transit/terms/stationStop">transit:stationStop</a>
    /// </summary>
    let stationStop = _prefixId.prefix "stationStop"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Stop</para>
    ///   <para>rdfs:comment : The physical stop associated with this service stop.</para>
    ///   <a href="http://vocab.org/transit/terms/stop">transit:stop</a>
    /// </summary>
    let stop = _prefixId.prefix "stop"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Text Color</para>
    ///   <para>rdfs:comment : A legible color for text drawn against a background of the color associated with a route.</para>
    ///   <a href="http://vocab.org/transit/terms/textColor">transit:textColor</a>
    /// </summary>
    let textColor = _prefixId.prefix "textColor"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Timezone</para>
    ///   <para>rdfs:comment : The timezone where a person or organisation is located.</para>
    ///   <a href="http://vocab.org/transit/terms/timezone">transit:timezone</a>
    /// </summary>
    let timezone = _prefixId.prefix "timezone"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : To Stop</para>
    ///   <para>rdfs:comment : A stop where a connection between routes ends.</para>
    ///   <a href="http://vocab.org/transit/terms/toStop">transit:toStop</a>
    /// </summary>
    let toStop = _prefixId.prefix "toStop"
    /// <summary>
    ///   <para>dcterms:issued : 2011-03-28^^xsd:date</para>
    ///   <para>rdfs:label : Transfer</para>
    ///   <para>rdfs:comment : A transfer point that is associated with this stop.</para>
    ///   <a href="http://vocab.org/transit/terms/transfer">transit:transfer</a>
    /// </summary>
    let transfer = _prefixId.prefix "transfer"
