namespace http.vocab.org.transit.terms.slash

open DoxAletheia

module transit =
    let _namespace_name = "http://vocab.org/transit/terms/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.org/transit/terms/.html"></see>
    /// </summary>
    let ``_.html`` = _prefix ".html"
    /// <summary>
    ///   <see href="http://vocab.org/transit/terms/.json"></see>
    /// </summary>
    let ``_.json`` = _prefix ".json"
    /// <summary>
    ///   <see href="http://vocab.org/transit/terms/.rdf"></see>
    /// </summary>
    let ``_.rdf`` = _prefix ".rdf"
    /// <summary>
    ///   <see href="http://vocab.org/transit/terms/.turtle"></see>
    /// </summary>
    let ``_.turtle`` = _prefix ".turtle"
    /// <summary>
    /// A type of arrangement for picking up or dropping off passengers from a service stop.
    /// <see href="http://vocab.org/transit/terms/AccessArrangement"></see></summary>
    let AccessArrangement = _prefix "AccessArrangement"
    /// <summary>
    /// An organization that oversees public transportation for a city or region.
    /// <see href="http://vocab.org/transit/terms/Agency"></see></summary>
    let Agency = _prefix "Agency"
    /// <summary>
    /// A public transportation route utilising buses on roads for short- or long-distance travel.
    /// <see href="http://vocab.org/transit/terms/BusRoute"></see></summary>
    let BusRoute = _prefix "BusRoute"
    /// <summary>
    /// A public transportation route.
    /// <see href="http://vocab.org/transit/terms/Route"></see></summary>
    let Route = _prefix "Route"
    /// <summary>
    /// A public transportation route utilising street-level cable cars where the cable runs beneath the car.
    /// <see href="http://vocab.org/transit/terms/CableCarRoute"></see></summary>
    let CableCarRoute = _prefix "CableCarRoute"
    /// <summary>
    /// A class of fare payable for public transportation.
    /// <see href="http://vocab.org/transit/terms/Fare"></see></summary>
    let Fare = _prefix "Fare"
    /// <summary>
    /// A public transportation route utilising boats for short- or long-distance travel.
    /// <see href="http://vocab.org/transit/terms/FerryRoute"></see></summary>
    let FerryRoute = _prefix "FerryRoute"
    /// <summary>
    /// A public transportation route utilising a rail system designed for steep inclines.
    /// <see href="http://vocab.org/transit/terms/FunicularRoute"></see></summary>
    let FunicularRoute = _prefix "FunicularRoute"
    /// <summary>
    /// A public transportation route utilising aerial cable cars where the car is suspended from the cable.
    /// <see href="http://vocab.org/transit/terms/GondalaRoute"></see></summary>
    let GondalaRoute = _prefix "GondalaRoute"
    /// <summary>
    /// A service that travels in an inbound direction.
    /// <see href="http://vocab.org/transit/terms/InboundService"></see></summary>
    let InboundService = _prefix "InboundService"
    /// <summary>
    /// A transfer point between two routes that requires a minimum amount of time between arrival and departure to ensure a connection.
    /// <see href="http://vocab.org/transit/terms/MinimumTimeTransfer"></see></summary>
    let MinimumTimeTransfer = _prefix "MinimumTimeTransfer"
    /// <summary>
    /// A transfer point between two routes.
    /// <see href="http://vocab.org/transit/terms/Transfer"></see></summary>
    let Transfer = _prefix "Transfer"
    /// <summary>
    /// A service that travels in an outbound direction.
    /// <see href="http://vocab.org/transit/terms/OutboundService"></see></summary>
    let OutboundService = _prefix "OutboundService"
    /// <summary>
    /// A public transportation route utilising a rail system for intercity or long-distance travel.
    /// <see href="http://vocab.org/transit/terms/RailRoute"></see></summary>
    let RailRoute = _prefix "RailRoute"
    /// <summary>
    /// A point that is recommended for transfer between two routes.
    /// <see href="http://vocab.org/transit/terms/RecommendedTransfer"></see></summary>
    let RecommendedTransfer = _prefix "RecommendedTransfer"
    /// <summary>
    /// A location where passengers board or disembark from a transit vehicle for a specific route.
    /// <see href="http://vocab.org/transit/terms/RouteStop"></see></summary>
    let RouteStop = _prefix "RouteStop"
    /// <summary>
    /// A public transport schedule that applies for one or more routes.
    /// <see href="http://vocab.org/transit/terms/Schedule"></see></summary>
    let Schedule = _prefix "Schedule"
    /// <summary>
    /// A public transport service that operates a route on a given schedule.
    /// <see href="http://vocab.org/transit/terms/Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// A location where passengers board or disembark from a transit vehicle for a specific service.
    /// <see href="http://vocab.org/transit/terms/ServiceStop"></see></summary>
    let ServiceStop = _prefix "ServiceStop"
    /// <summary>
    /// A physical structure or area that contains one or more stops.
    /// <see href="http://vocab.org/transit/terms/Station"></see></summary>
    let Station = _prefix "Station"
    /// <summary>
    /// A location where passengers board or disembark from a transit vehicle.
    /// <see href="http://vocab.org/transit/terms/Stop"></see></summary>
    let Stop = _prefix "Stop"
    /// <summary>
    /// A public transportation route utilising an underground rail system within a metropolitan area.
    /// <see href="http://vocab.org/transit/terms/SubwayRoute"></see></summary>
    let SubwayRoute = _prefix "SubwayRoute"
    /// <summary>
    /// A transfer point between two routes where the departing vehicle is expected to wait for the arriving one with sufficient time for a passenger to transfer between routes.
    /// <see href="http://vocab.org/transit/terms/TimedTransfer"></see></summary>
    let TimedTransfer = _prefix "TimedTransfer"
    /// <summary>
    /// A public transportation route utilising light rail or street level railed vehicles within a metropolitan area.
    /// <see href="http://vocab.org/transit/terms/TramRoute"></see></summary>
    let TramRoute = _prefix "TramRoute"
    /// <summary>
    /// A point where transfer between two routes is not possible despite appearing possible by proximity.
    /// <see href="http://vocab.org/transit/terms/UnavailableTransfer"></see></summary>
    let UnavailableTransfer = _prefix "UnavailableTransfer"
    /// <summary>
    /// The agency that operates this public transportation route.
    /// <see href="http://vocab.org/transit/terms/agency"></see></summary>
    let agency = _prefix "agency"
    /// <summary>
    /// The time of day at which the service arrives at the stop. The time is measured from "noon minus 12h" (effectively midnight, except for days on which daylight savings time changes occur) at the beginning of the service date. For times occurring after midnight on the service date, the time will be a value greater than 24:00:00 in HH:MM:SS local time for the day on which the trip schedule begins. Services that span multiple dates will have stop times greater than 24:00:00. For example, if a service begins at 10:30:00 p.m. and ends at 2:15:00 a.m. on the following day, the stop times would be 22:30:00 and 26:15:00.
    /// <see href="http://vocab.org/transit/terms/arrivalTime"></see></summary>
    let arrivalTime = _prefix "arrivalTime"
    /// <summary>
    /// The callsign prefix used by an airline to identify itself to air traffic control.
    /// <see href="http://vocab.org/transit/terms/callsign"></see></summary>
    let callsign = _prefix "callsign"
    /// <summary>
    /// A color associated with this route.
    /// <see href="http://vocab.org/transit/terms/color"></see></summary>
    let color = _prefix "color"
    /// <summary>
    /// The particular form of access must be coordinated with the driver.
    /// <see href="http://vocab.org/transit/terms/coordinated"></see></summary>
    let coordinated = _prefix "coordinated"
    /// <summary>
    /// The currency of the fare price.
    /// <see href="http://vocab.org/transit/terms/currency"></see></summary>
    let currency = _prefix "currency"
    /// <summary>
    /// A date on which this service is scheduled to operate.
    /// <see href="http://vocab.org/transit/terms/date"></see></summary>
    let date = _prefix "date"
    /// <summary>
    /// The time of day at which the service departs the stop. The time is measured from "noon minus 12h" (effectively midnight, except for days on which daylight savings time changes occur) at the beginning of the service date. For times occurring after midnight on the service date, the time will be a value greater than 24:00:00 in HH:MM:SS local time for the day on which the trip schedule begins. Services that span multiple dates will have stop times greater than 24:00:00. For example, if a service begins at 10:30:00 p.m. and ends at 2:15:00 a.m. on the following day, the stop times would be 22:30:00 and 26:15:00.
    /// <see href="http://vocab.org/transit/terms/departureTime"></see></summary>
    let departureTime = _prefix "departureTime"
    /// <summary>
    /// The particular form of access is unavailable.
    /// <see href="http://vocab.org/transit/terms/disallowed"></see></summary>
    let disallowed = _prefix "disallowed"
    /// <summary>
    /// The distance of this service stop from the first stop in sequence.
    /// <see href="http://vocab.org/transit/terms/distance"></see></summary>
    let distance = _prefix "distance"
    /// <summary>
    /// The arrangement required for passengers to be dropped off at this service stop.
    /// <see href="http://vocab.org/transit/terms/dropoff"></see></summary>
    let dropoff = _prefix "dropoff"
    /// <summary>
    /// A stop where a connection between routes begins.
    /// <see href="http://vocab.org/transit/terms/fromStop"></see></summary>
    let fromStop = _prefix "fromStop"
    /// <summary>
    /// Text that appears on a sign that identifies the service's destination to passengers.
    /// <see href="http://vocab.org/transit/terms/headsign"></see></summary>
    let headsign = _prefix "headsign"
    /// <summary>
    /// The code issued by the International Air Transport Association to identify an airport.
    /// <see href="http://vocab.org/transit/terms/iataCode"></see></summary>
    let iataCode = _prefix "iataCode"
    /// <summary>
    /// The code issued by the International Civil Aviation Authority to identify an airport or airline.
    /// <see href="http://vocab.org/transit/terms/icaoCode"></see></summary>
    let icaoCode = _prefix "icaoCode"
    /// <summary>
    /// The primary language used by a person or organisation.
    /// <see href="http://vocab.org/transit/terms/language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// The amount of time (in seconds) that must be available in an itinerary to permit a transfer between routes at this transfer point.
    /// <see href="http://vocab.org/transit/terms/minTransferTime"></see></summary>
    let minTransferTime = _prefix "minTransferTime"
    /// <summary>
    /// The arrangement required for passengers to be picked up at this service stop.
    /// <see href="http://vocab.org/transit/terms/pickup"></see></summary>
    let pickup = _prefix "pickup"
    /// <summary>
    /// The particular form of access must be pre-arranged with the transit agency.
    /// <see href="http://vocab.org/transit/terms/prearranged"></see></summary>
    let prearranged = _prefix "prearranged"
    /// <summary>
    /// The price of the fare.
    /// <see href="http://vocab.org/transit/terms/price"></see></summary>
    let price = _prefix "price"
    /// <summary>
    /// A route associated with the given resource.
    /// <see href="http://vocab.org/transit/terms/route"></see></summary>
    let route = _prefix "route"
    /// <summary>
    /// A service that operates on this route.
    /// <see href="http://vocab.org/transit/terms/routeService"></see></summary>
    let routeService = _prefix "routeService"
    /// <summary>
    /// Links a route to a particular stop and the sequence of that stop in the route.
    /// <see href="http://vocab.org/transit/terms/routeStop"></see></summary>
    let routeStop = _prefix "routeStop"
    /// <summary>
    /// The schedule on which this service operates.
    /// <see href="http://vocab.org/transit/terms/schedule"></see></summary>
    let schedule = _prefix "schedule"
    /// <summary>
    /// A service that operates on this schedule.
    /// <see href="http://vocab.org/transit/terms/scheduleService"></see></summary>
    let scheduleService = _prefix "scheduleService"
    /// <summary>
    /// A sequence number for a stop along a route or service. Sequence values are non-negative integers and increase along the route or service however they need not be consecutive.
    /// <see href="http://vocab.org/transit/terms/sequence"></see></summary>
    let sequence = _prefix "sequence"
    /// <summary>
    /// The service associated with this service stop.
    /// <see href="http://vocab.org/transit/terms/service"></see></summary>
    let service = _prefix "service"
    /// <summary>
    /// The arrival and departure time of a service at a particular stop.
    /// <see href="http://vocab.org/transit/terms/serviceStop"></see></summary>
    let serviceStop = _prefix "serviceStop"
    /// <summary>
    /// The particular form of access has no special arrangement.
    /// <see href="http://vocab.org/transit/terms/standard"></see></summary>
    let standard = _prefix "standard"
    /// <summary>
    /// The station that this stop is part of.
    /// <see href="http://vocab.org/transit/terms/station"></see></summary>
    let station = _prefix "station"
    /// <summary>
    /// A stop that is associated with this station.
    /// <see href="http://vocab.org/transit/terms/stationStop"></see></summary>
    let stationStop = _prefix "stationStop"
    /// <summary>
    /// The physical stop associated with this service stop.
    /// <see href="http://vocab.org/transit/terms/stop"></see></summary>
    let stop = _prefix "stop"
    /// <summary>
    /// A legible color for text drawn against a background of the color associated with a route.
    /// <see href="http://vocab.org/transit/terms/textColor"></see></summary>
    let textColor = _prefix "textColor"
    /// <summary>
    /// The timezone where a person or organisation is located.
    /// <see href="http://vocab.org/transit/terms/timezone"></see></summary>
    let timezone = _prefix "timezone"
    /// <summary>
    /// A stop where a connection between routes ends.
    /// <see href="http://vocab.org/transit/terms/toStop"></see></summary>
    let toStop = _prefix "toStop"
    /// <summary>
    /// A transfer point that is associated with this stop.
    /// <see href="http://vocab.org/transit/terms/transfer"></see></summary>
    let transfer = _prefix "transfer"
