namespace http.vocab.org.transit.terms.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module transit =
    let _namespace_iri = Namespace_Iri transit |> NamespaceIRI
    /// <summary>
    ///   <para>transit:.html</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcmitype:Text</para>
    ///   <para>foaf:Document</para>
    ///
    /// labels<para>HTML</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/.html">http://vocab.org/transit/terms/.html</seealso>
    let ``_.html`` = Prefixed_Name(transit, ".html") |> PrefixedName
    /// <summary>
    ///   <para>transit:.rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcmitype:Text</para>
    ///   <para>foaf:Document</para>
    /// </remarks>
    /// <seealso href="http://vocab.org/transit/terms/.rdf">http://vocab.org/transit/terms/.rdf</seealso>
    let ``_.rdf`` = Prefixed_Name(transit, ".rdf") |> PrefixedName
    /// <summary>
    ///   <para>transit:Agency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An organization that oversees public transportation for a city or region.</para>
    /// labels<para>Transit Agency</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/Agency">http://vocab.org/transit/terms/Agency</seealso>
    let Agency = Prefixed_Name(transit, "Agency") |> PrefixedName
    /// <summary>
    ///   <para>transit:Route</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A public transportation route.</para>
    /// labels<para>Transit Route</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/Route">http://vocab.org/transit/terms/Route</seealso>
    let Route = Prefixed_Name(transit, "Route") |> PrefixedName
    /// <summary>
    ///   <para>transit:CableCarRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A public transportation route utilising street-level cable cars where the cable runs beneath the car.</para>
    /// labels<para>Cable Car Route</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/CableCarRoute">http://vocab.org/transit/terms/CableCarRoute</seealso>
    let CableCarRoute = Prefixed_Name(transit, "CableCarRoute") |> PrefixedName
    /// <summary>
    ///   <para>transit:FerryRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A public transportation route utilising boats for short- or long-distance travel.</para>
    /// labels<para>Ferry Route</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/FerryRoute">http://vocab.org/transit/terms/FerryRoute</seealso>
    let FerryRoute = Prefixed_Name(transit, "FerryRoute") |> PrefixedName
    /// <summary>
    ///   <para>transit:FunicularRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A public transportation route utilising a rail system designed for steep inclines.</para>
    /// labels<para>Funicular Route</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/FunicularRoute">http://vocab.org/transit/terms/FunicularRoute</seealso>
    let FunicularRoute = Prefixed_Name(transit, "FunicularRoute") |> PrefixedName
    /// <summary>
    ///   <para>transit:InboundService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A service that travels in an inbound direction.</para>
    /// labels<para>Inbound Service</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/InboundService">http://vocab.org/transit/terms/InboundService</seealso>
    let InboundService = Prefixed_Name(transit, "InboundService") |> PrefixedName
    /// <summary>
    ///   <para>transit:OutboundService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A service that travels in an outbound direction.</para>
    /// labels<para>Outbound Service</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/OutboundService">http://vocab.org/transit/terms/OutboundService</seealso>
    let OutboundService = Prefixed_Name(transit, "OutboundService") |> PrefixedName
    /// <summary>
    ///   <para>transit:RailRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A public transportation route utilising a rail system for intercity or long-distance travel.</para>
    /// labels<para>Rail Route</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/RailRoute">http://vocab.org/transit/terms/RailRoute</seealso>
    let RailRoute = Prefixed_Name(transit, "RailRoute") |> PrefixedName

    /// <summary>
    ///   <para>transit:RecommendedTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point that is recommended for transfer between two routes.</para>
    /// labels<para>Timed Transfer</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/RecommendedTransfer">http://vocab.org/transit/terms/RecommendedTransfer</seealso>
    let RecommendedTransfer =
        Prefixed_Name(transit, "RecommendedTransfer") |> PrefixedName

    /// <summary>
    ///   <para>transit:Schedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A public transport schedule that applies for one or more routes.</para>
    /// labels<para>Schedule</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/Schedule">http://vocab.org/transit/terms/Schedule</seealso>
    let Schedule = Prefixed_Name(transit, "Schedule") |> PrefixedName
    /// <summary>
    ///   <para>transit:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A public transport service that operates a route on a given schedule.</para>
    /// labels<para>Service</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/Service">http://vocab.org/transit/terms/Service</seealso>
    let Service = Prefixed_Name(transit, "Service") |> PrefixedName
    /// <summary>
    ///   <para>transit:Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical structure or area that contains one or more stops.</para>
    /// labels<para>Transit Station</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/Station">http://vocab.org/transit/terms/Station</seealso>
    let Station = Prefixed_Name(transit, "Station") |> PrefixedName
    /// <summary>
    ///   <para>transit:Stop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A location where passengers board or disembark from a transit vehicle.</para>
    /// labels<para>Transit Stop</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/Stop">http://vocab.org/transit/terms/Stop</seealso>
    let Stop = Prefixed_Name(transit, "Stop") |> PrefixedName
    /// <summary>
    ///   <para>transit:SubwayRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A public transportation route utilising an underground rail system within a metropolitan area.</para>
    /// labels<para>Subway Route</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/SubwayRoute">http://vocab.org/transit/terms/SubwayRoute</seealso>
    let SubwayRoute = Prefixed_Name(transit, "SubwayRoute") |> PrefixedName

    /// <summary>
    ///   <para>transit:UnavailableTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point where transfer between two routes is not possible despite appearing possible by proximity.</para>
    /// labels<para>Unavailable Transfer</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/UnavailableTransfer">http://vocab.org/transit/terms/UnavailableTransfer</seealso>
    let UnavailableTransfer =
        Prefixed_Name(transit, "UnavailableTransfer") |> PrefixedName

    /// <summary>
    ///   <para>transit:agency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The agency that operates this public transportation route.</para>
    /// labels<para>Agency</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/agency">http://vocab.org/transit/terms/agency</seealso>
    let agency = Prefixed_Name(transit, "agency") |> PrefixedName
    /// <summary>
    ///   <para>transit:color</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A color associated with this route.</para>
    /// labels<para>Color</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/color">http://vocab.org/transit/terms/color</seealso>
    let color = Prefixed_Name(transit, "color") |> PrefixedName
    /// <summary>
    ///   <para>transit:coordinated</para>
    /// </summary>
    /// <remarks>
    ///   <para>transit:AccessArrangement</para>
    ///   <para>The particular form of access must be coordinated with the driver.</para>
    /// labels<para>Coordinated</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/coordinated">http://vocab.org/transit/terms/coordinated</seealso>
    let coordinated = Prefixed_Name(transit, "coordinated") |> PrefixedName
    /// <summary>
    ///   <para>transit:disallowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>transit:AccessArrangement</para>
    ///   <para>The particular form of access is unavailable.</para>
    /// labels<para>Disallowed</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/disallowed">http://vocab.org/transit/terms/disallowed</seealso>
    let disallowed = Prefixed_Name(transit, "disallowed") |> PrefixedName
    /// <summary>
    ///   <para>transit:distance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The distance of this service stop from the first stop in sequence.</para>
    /// labels<para>Distance</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/distance">http://vocab.org/transit/terms/distance</seealso>
    let distance = Prefixed_Name(transit, "distance") |> PrefixedName
    /// <summary>
    ///   <para>transit:iataCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The code issued by the International Air Transport Association to identify an airport.</para>
    /// labels<para>IATA code</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/iataCode">http://vocab.org/transit/terms/iataCode</seealso>
    let iataCode = Prefixed_Name(transit, "iataCode") |> PrefixedName
    /// <summary>
    ///   <para>transit:icaoCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The code issued by the International Civil Aviation Authority to identify an airport or airline.</para>
    /// labels<para>ICAO code</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/icaoCode">http://vocab.org/transit/terms/icaoCode</seealso>
    let icaoCode = Prefixed_Name(transit, "icaoCode") |> PrefixedName
    /// <summary>
    ///   <para>transit:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The primary language used by a person or organisation.</para>
    /// labels<para>Language</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/language">http://vocab.org/transit/terms/language</seealso>
    let language = Prefixed_Name(transit, "language") |> PrefixedName
    /// <summary>
    ///   <para>transit:prearranged</para>
    /// </summary>
    /// <remarks>
    ///   <para>transit:AccessArrangement</para>
    ///   <para>The particular form of access must be pre-arranged with the transit agency.</para>
    /// labels<para>Pre-arranged</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/prearranged">http://vocab.org/transit/terms/prearranged</seealso>
    let prearranged = Prefixed_Name(transit, "prearranged") |> PrefixedName
    /// <summary>
    ///   <para>transit:price</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The price of the fare.</para>
    /// labels<para>Price</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/price">http://vocab.org/transit/terms/price</seealso>
    let price = Prefixed_Name(transit, "price") |> PrefixedName
    /// <summary>
    ///   <para>transit:route</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A route associated with the given resource.</para>
    /// labels<para>Route</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/route">http://vocab.org/transit/terms/route</seealso>
    let route = Prefixed_Name(transit, "route") |> PrefixedName
    /// <summary>
    ///   <para>transit:routeStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Links a route to a particular stop and the sequence of that stop in the route.</para>
    /// labels<para>Route Stop</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/routeStop">http://vocab.org/transit/terms/routeStop</seealso>
    let routeStop = Prefixed_Name(transit, "routeStop") |> PrefixedName
    /// <summary>
    ///   <para>transit:schedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The schedule on which this service operates.</para>
    /// labels<para>Schedule</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/schedule">http://vocab.org/transit/terms/schedule</seealso>
    let schedule = Prefixed_Name(transit, "schedule") |> PrefixedName
    /// <summary>
    ///   <para>transit:scheduleService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A service that operates on this schedule.</para>
    /// labels<para>Schedule Service</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/scheduleService">http://vocab.org/transit/terms/scheduleService</seealso>
    let scheduleService = Prefixed_Name(transit, "scheduleService") |> PrefixedName
    /// <summary>
    ///   <para>transit:sequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A sequence number for a stop along a route or service. Sequence values are non-negative integers and increase along the route or service however they need not be consecutive.</para>
    /// labels<para>Sequence</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/sequence">http://vocab.org/transit/terms/sequence</seealso>
    let sequence = Prefixed_Name(transit, "sequence") |> PrefixedName
    /// <summary>
    ///   <para>transit:service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The service associated with this service stop.</para>
    /// labels<para>Service</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/service">http://vocab.org/transit/terms/service</seealso>
    let service = Prefixed_Name(transit, "service") |> PrefixedName
    /// <summary>
    ///   <para>transit:serviceStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The arrival and departure time of a service at a particular stop.</para>
    /// labels<para>Service Stop</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/serviceStop">http://vocab.org/transit/terms/serviceStop</seealso>
    let serviceStop = Prefixed_Name(transit, "serviceStop") |> PrefixedName
    /// <summary>
    ///   <para>transit:stop</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The physical stop associated with this service stop.</para>
    /// labels<para>Stop</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/stop">http://vocab.org/transit/terms/stop</seealso>
    let stop = Prefixed_Name(transit, "stop") |> PrefixedName
    /// <summary>
    ///   <para>transit:textColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A legible color for text drawn against a background of the color associated with a route.</para>
    /// labels<para>Text Color</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/textColor">http://vocab.org/transit/terms/textColor</seealso>
    let textColor = Prefixed_Name(transit, "textColor") |> PrefixedName
    /// <summary>
    ///   <para>transit:timezone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The timezone where a person or organisation is located.</para>
    /// labels<para>Timezone</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/timezone">http://vocab.org/transit/terms/timezone</seealso>
    let timezone = Prefixed_Name(transit, "timezone") |> PrefixedName
    /// <summary>
    ///   <para>transit:toStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A stop where a connection between routes ends.</para>
    /// labels<para>To Stop</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/toStop">http://vocab.org/transit/terms/toStop</seealso>
    let toStop = Prefixed_Name(transit, "toStop") |> PrefixedName
    /// <summary>
    ///   <para>transit:transfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A transfer point that is associated with this stop.</para>
    /// labels<para>Transfer</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/transfer">http://vocab.org/transit/terms/transfer</seealso>
    let transfer = Prefixed_Name(transit, "transfer") |> PrefixedName
    /// <summary>
    ///   <para>transit:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://vocab.org/transit/terms/">http://vocab.org/transit/terms/</seealso>
    let _prefix_iri = Prefixed_Name(transit, "") |> PrefixedName
    /// <summary>
    ///   <para>transit:.json</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Document</para>
    ///   <para>dcmitype:Text</para>
    ///
    /// labels<para>JSON</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/.json">http://vocab.org/transit/terms/.json</seealso>
    let ``_.json`` = Prefixed_Name(transit, ".json") |> PrefixedName
    /// <summary>
    ///   <para>transit:.turtle</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcmitype:Text</para>
    ///   <para>foaf:Document</para>
    ///
    /// labels<para>Turtle</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/.turtle">http://vocab.org/transit/terms/.turtle</seealso>
    let ``_.turtle`` = Prefixed_Name(transit, ".turtle") |> PrefixedName
    /// <summary>
    ///   <para>transit:AccessArrangement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of arrangement for picking up or dropping off passengers from a service stop.</para>
    /// labels<para>Access Arrangement</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/AccessArrangement">http://vocab.org/transit/terms/AccessArrangement</seealso>
    let AccessArrangement = Prefixed_Name(transit, "AccessArrangement") |> PrefixedName
    /// <summary>
    ///   <para>transit:BusRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A public transportation route utilising buses on roads for short- or long-distance travel.</para>
    /// labels<para>Bus Route</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/BusRoute">http://vocab.org/transit/terms/BusRoute</seealso>
    let BusRoute = Prefixed_Name(transit, "BusRoute") |> PrefixedName
    /// <summary>
    ///   <para>transit:Fare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class of fare payable for public transportation.</para>
    /// labels<para>Fare</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/Fare">http://vocab.org/transit/terms/Fare</seealso>
    let Fare = Prefixed_Name(transit, "Fare") |> PrefixedName
    /// <summary>
    ///   <para>transit:GondalaRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A public transportation route utilising aerial cable cars where the car is suspended from the cable.</para>
    /// labels<para>Gondala Route</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/GondalaRoute">http://vocab.org/transit/terms/GondalaRoute</seealso>
    let GondalaRoute = Prefixed_Name(transit, "GondalaRoute") |> PrefixedName

    /// <summary>
    ///   <para>transit:MinimumTimeTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A transfer point between two routes that requires a minimum amount of time between arrival and departure to ensure a connection.</para>
    /// labels<para>Minimum Time Transfer</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/MinimumTimeTransfer">http://vocab.org/transit/terms/MinimumTimeTransfer</seealso>
    let MinimumTimeTransfer =
        Prefixed_Name(transit, "MinimumTimeTransfer") |> PrefixedName

    /// <summary>
    ///   <para>transit:Transfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A transfer point between two routes.</para>
    /// labels<para>Transfer</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/Transfer">http://vocab.org/transit/terms/Transfer</seealso>
    let Transfer = Prefixed_Name(transit, "Transfer") |> PrefixedName
    /// <summary>
    ///   <para>transit:RouteStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A location where passengers board or disembark from a transit vehicle for a specific route.</para>
    /// labels<para>Route Stop</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/RouteStop">http://vocab.org/transit/terms/RouteStop</seealso>
    let RouteStop = Prefixed_Name(transit, "RouteStop") |> PrefixedName
    /// <summary>
    ///   <para>transit:ServiceStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A location where passengers board or disembark from a transit vehicle for a specific service.</para>
    /// labels<para>Service Stop</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/ServiceStop">http://vocab.org/transit/terms/ServiceStop</seealso>
    let ServiceStop = Prefixed_Name(transit, "ServiceStop") |> PrefixedName
    /// <summary>
    ///   <para>transit:TimedTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A transfer point between two routes where the departing vehicle is expected to wait for the arriving one with sufficient time for a passenger to transfer between routes.</para>
    /// labels<para>Timed Transfer</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/TimedTransfer">http://vocab.org/transit/terms/TimedTransfer</seealso>
    let TimedTransfer = Prefixed_Name(transit, "TimedTransfer") |> PrefixedName
    /// <summary>
    ///   <para>transit:TramRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A public transportation route utilising light rail or street level railed vehicles within a metropolitan area.</para>
    /// labels<para>Tram Route</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/TramRoute">http://vocab.org/transit/terms/TramRoute</seealso>
    let TramRoute = Prefixed_Name(transit, "TramRoute") |> PrefixedName
    /// <summary>
    ///   <para>transit:arrivalTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The time of day at which the service arrives at the stop. The time is measured from "noon minus 12h" (effectively midnight, except for days on which daylight savings time changes occur) at the beginning of the service date. For times occurring after midnight on the service date, the time will be a value greater than 24:00:00 in HH:MM:SS local time for the day on which the trip schedule begins. Services that span multiple dates will have stop times greater than 24:00:00. For example, if a service begins at 10:30:00 p.m. and ends at 2:15:00 a.m. on the following day, the stop times would be 22:30:00 and 26:15:00. </para>
    /// labels<para>Arrival Time</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/arrivalTime">http://vocab.org/transit/terms/arrivalTime</seealso>
    let arrivalTime = Prefixed_Name(transit, "arrivalTime") |> PrefixedName
    /// <summary>
    ///   <para>transit:callsign</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The callsign prefix used by an airline to identify itself to air traffic control.</para>
    /// labels<para>Callsign prefix</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/callsign">http://vocab.org/transit/terms/callsign</seealso>
    let callsign = Prefixed_Name(transit, "callsign") |> PrefixedName
    /// <summary>
    ///   <para>transit:currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The currency of the fare price.</para>
    /// labels<para>Currency</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/currency">http://vocab.org/transit/terms/currency</seealso>
    let currency = Prefixed_Name(transit, "currency") |> PrefixedName
    /// <summary>
    ///   <para>transit:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A date on which this service is scheduled to operate.</para>
    /// labels<para>Date</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/date">http://vocab.org/transit/terms/date</seealso>
    let date = Prefixed_Name(transit, "date") |> PrefixedName
    /// <summary>
    ///   <para>transit:departureTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The time of day at which the service departs the stop. The time is measured from "noon minus 12h" (effectively midnight, except for days on which daylight savings time changes occur) at the beginning of the service date. For times occurring after midnight on the service date, the time will be a value greater than 24:00:00 in HH:MM:SS local time for the day on which the trip schedule begins. Services that span multiple dates will have stop times greater than 24:00:00. For example, if a service begins at 10:30:00 p.m. and ends at 2:15:00 a.m. on the following day, the stop times would be 22:30:00 and 26:15:00. </para>
    /// labels<para>Departure Time</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/departureTime">http://vocab.org/transit/terms/departureTime</seealso>
    let departureTime = Prefixed_Name(transit, "departureTime") |> PrefixedName
    /// <summary>
    ///   <para>transit:dropoff</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The arrangement required for passengers to be dropped off at this service stop.</para>
    /// labels<para>Drop Off</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/dropoff">http://vocab.org/transit/terms/dropoff</seealso>
    let dropoff = Prefixed_Name(transit, "dropoff") |> PrefixedName
    /// <summary>
    ///   <para>transit:fromStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A stop where a connection between routes begins.</para>
    /// labels<para>From Stop</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/fromStop">http://vocab.org/transit/terms/fromStop</seealso>
    let fromStop = Prefixed_Name(transit, "fromStop") |> PrefixedName
    /// <summary>
    ///   <para>transit:headsign</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Text that appears on a sign that identifies the service's destination to passengers.</para>
    /// labels<para>Date</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/headsign">http://vocab.org/transit/terms/headsign</seealso>
    let headsign = Prefixed_Name(transit, "headsign") |> PrefixedName
    /// <summary>
    ///   <para>transit:minTransferTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The amount of time (in seconds) that must be available in an itinerary to permit a transfer between routes at this transfer point.</para>
    /// labels<para>Minimum Transfer Time</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/minTransferTime">http://vocab.org/transit/terms/minTransferTime</seealso>
    let minTransferTime = Prefixed_Name(transit, "minTransferTime") |> PrefixedName
    /// <summary>
    ///   <para>transit:pickup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The arrangement required for passengers to be picked up at this service stop.</para>
    /// labels<para>Pick Up</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/pickup">http://vocab.org/transit/terms/pickup</seealso>
    let pickup = Prefixed_Name(transit, "pickup") |> PrefixedName
    /// <summary>
    ///   <para>transit:routeService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A service that operates on this route.</para>
    /// labels<para>Route Service</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/routeService">http://vocab.org/transit/terms/routeService</seealso>
    let routeService = Prefixed_Name(transit, "routeService") |> PrefixedName
    /// <summary>
    ///   <para>transit:standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>transit:AccessArrangement</para>
    ///   <para>The particular form of access has no special arrangement.</para>
    /// labels<para>Standard</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/standard">http://vocab.org/transit/terms/standard</seealso>
    let standard = Prefixed_Name(transit, "standard") |> PrefixedName
    /// <summary>
    ///   <para>transit:station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The station that this stop is part of.</para>
    /// labels<para>Station</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/station">http://vocab.org/transit/terms/station</seealso>
    let station = Prefixed_Name(transit, "station") |> PrefixedName
    /// <summary>
    ///   <para>transit:stationStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A stop that is associated with this station.</para>
    /// labels<para>Station Stop</para></remarks>
    /// <seealso href="http://vocab.org/transit/terms/stationStop">http://vocab.org/transit/terms/stationStop</seealso>
    let stationStop = Prefixed_Name(transit, "stationStop") |> PrefixedName
