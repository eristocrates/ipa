namespace https.data.nasa.gov.ontologies.atmonto.NAS.hash

open DoxAletheia

module nas =
    let _namespace_name = "https://data.nasa.gov/ontologies/atmonto/NAS#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Air Route Traffic Control Center (ARTCC or 'Center') facility
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#ARTCC"></see></summary>
    let ARTCC = _prefix "ARTCC"
    /// <summary>
    /// The set of FAA and airport facilities involved in operational air traffic management.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#NASfacility"></see></summary>
    let NASfacility = _prefix "NASfacility"
    /// <summary>
    /// A defined substructure of the airspace used to manage air traffic, including sectors, SIDs, STARs, routes, etc.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AirspaceInfrastructureComponent"></see></summary>
    let AirspaceInfrastructureComponent = _prefix "AirspaceInfrastructureComponent"
    /// <summary>
    /// A donut-shaped geographical area surrounding a designated central ARTCC. The first tier includes all the ARTCCs that share a boundary with the designated  ARTCC. The tier two ARTCCs includes the first tier ARTCCs plus those adjacent to the first tier ARCCCs. And so on.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#ARTCCtier"></see></summary>
    let ARTCCtier = _prefix "ARTCCtier"
    /// <summary>
    /// Air Traffic Control System Command Center (ATCSCC) facility
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#ATCSCC"></see></summary>
    let ATCSCC = _prefix "ATCSCC"
    /// <summary>
    /// Air Traffic Control Tower (ATCT) facility
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#ATCT"></see></summary>
    let ATCT = _prefix "ATCT"
    /// <summary>
    /// Part of an airport's physical infrastructure, including gates, terminals, runways, taxiways, etc.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AirportInfrastructureComponent"></see></summary>
    let AirportInfrastructureComponent = _prefix "AirportInfrastructureComponent"
    /// <summary>
    /// An entity that it licensed to operate aircraft.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AirCarrier"></see></summary>
    let AirCarrier = _prefix "AirCarrier"
    /// <summary>
    /// A superclass encompassing all entities that provide aviation services in the public and private sectors.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AviationServiceProvider"></see></summary>
    let AviationServiceProvider = _prefix "AviationServiceProvider"
    /// <summary>
    /// A manufacturer of aircraft engines.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AircraftEngineManufacturer"></see></summary>
    let AircraftEngineManufacturer = _prefix "AircraftEngineManufacturer"
    /// <summary>
    /// A superclass encompassing the set of airframe and engine manufacturers.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AviationIndustryManufacturer"></see></summary>
    let AviationIndustryManufacturer = _prefix "AviationIndustryManufacturer"
    /// <summary>
    /// A manufacturer of physical aircraft.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AirframeManufacturer"></see></summary>
    let AirframeManufacturer = _prefix "AirframeManufacturer"
    /// <summary>
    /// A facility where regularly-scheduled aircraft arrive and depart.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#Airport"></see></summary>
    let Airport = _prefix "Airport"
    /// <summary>
    /// A route within a SID or STAR that connects the common route to one of multiple airports that use the SID/STAR.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AirportRoute"></see></summary>
    let AirportRoute = _prefix "AirportRoute"
    /// <summary>
    /// A route that defines a SID or STAR.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#SIDSTARroute"></see></summary>
    let SIDSTARroute = _prefix "SIDSTARroute"
    /// <summary>
    /// A class of vehicles that service the flights and maintain the airport physical infrastructure.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AirportServiceVehicle"></see></summary>
    let AirportServiceVehicle = _prefix "AirportServiceVehicle"
    /// <summary>
    /// Represents a layer within the airspace, defined by a shear-sided polygon with specified low and high altitudes.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AirspaceLayer"></see></summary>
    let AirspaceLayer = _prefix "AirspaceLayer"
    /// <summary>
    /// An ordered sequence of navigation elements specifying a path through the airspace.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AirspaceRoute"></see></summary>
    let AirspaceRoute = _prefix "AirspaceRoute"
    /// <summary>
    /// The set of airports in the continental US.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#CONUSairport"></see></summary>
    let CONUSairport = _prefix "CONUSairport"
    /// <summary>
    /// The set of airports located in the United States.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#USairport"></see></summary>
    let USairport = _prefix "USairport"
    /// <summary>
    /// The set of Canadian airports.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#CanadianAirport"></see></summary>
    let CanadianAirport = _prefix "CanadianAirport"
    /// <summary>
    /// The set of international (i.e., non-US) airports.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#InternationalAirport"></see></summary>
    let InternationalAirport = _prefix "InternationalAirport"
    /// <summary>
    /// The backbone portion of a SID or STAR that is flown by all aircraft.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#CommonRoute"></see></summary>
    let CommonRoute = _prefix "CommonRoute"
    /// <summary>
    /// A physical location in the airport where deicing is performed.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#DeicingPad"></see></summary>
    let DeicingPad = _prefix "DeicingPad"
    /// <summary>
    /// An ordered sequence of aircraft awaiting deicing at a deicing pad.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#DeicingQueue"></see></summary>
    let DeicingQueue = _prefix "DeicingQueue"
    /// <summary>
    /// A vehicle that holds deicing fluid and pumping equipment to support deicing.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#DeicingTruck"></see></summary>
    let DeicingTruck = _prefix "DeicingTruck"
    /// <summary>
    /// An airspace route that is defined by FAA and can be filed as part of a flight plan: a jet route, a Q-route,  a T-Route, a Victor route.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#FederalAirway"></see></summary>
    let FederalAirway = _prefix "FederalAirway"
    /// <summary>
    /// A physical interface between the aircraft and the terminal, used to board passengers and crew.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#Gate"></see></summary>
    let Gate = _prefix "Gate"
    /// <summary>
    /// The set of govenment agencies that perform aviation services.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#GovernmentAviationServiceProvider"></see></summary>
    let GovernmentAviationServiceProvider = _prefix "GovernmentAviationServiceProvider"
    /// <summary>
    /// A high altitude airway based on ground-based VOR sensor locations.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#JetRoute"></see></summary>
    let JetRoute = _prefix "JetRoute"
    /// <summary>
    /// A VOR route is defined relative to a network of existing ground-based VOR navigation beacons. VOR routes consist of point-to-point segments, where the points are defined by the beacons. More modern RNAV routes allow any path within the network, not limited to VOR-to-VOR segments.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#VORroute"></see></summary>
    let VORroute = _prefix "VORroute"
    /// <summary>
    /// A class that represents a day of the year. Events, such as flights, weather forecasts, and other events are linked to the instance of the day they occurred.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#NASday"></see></summary>
    let NASday = _prefix "NASday"
    /// <summary>
    /// A class that represents an hour within a day. Events, such as flights, weather forecasts, and other events are linked to the instance of the day they occurred.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#NAShour"></see></summary>
    let NAShour = _prefix "NAShour"
    /// <summary>
    /// The set of airports located in the United States, but outside the contiguous lower 48 states.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#NonCONUSairport"></see></summary>
    let NonCONUSairport = _prefix "NonCONUSairport"
    /// <summary>
    /// An operational runway is a named runway one used in airport operations. There are two operational runways corresponding to one physical runway; these operational runways are 180 degrees apart.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#OperationalRunway"></see></summary>
    let OperationalRunway = _prefix "OperationalRunway"
    /// <summary>
    /// A physical runway, defined as a delimited rectangular surface region of the airport. Each physical runway is associated with two operational runways, 180 degrees apart.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#PhysicalRunway"></see></summary>
    let PhysicalRunway = _prefix "PhysicalRunway"
    /// <summary>
    /// A high altitude RNAV airway route. (RNAV routes allow an aircraft to choose any course within a network of navigation beacons, rather than navigate directly to and from the beacons.)
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#QRoute"></see></summary>
    let QRoute = _prefix "QRoute"
    /// <summary>
    /// An RNAV (Random Navigation) route is defined relative to a network of existing ground-based navigation beacons.  RNAV allows an aircraft to choose any course within the network, rather than navigate using only point-to-point routes defined by the beacons.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#RNAVroute"></see></summary>
    let RNAVroute = _prefix "RNAVroute"
    /// <summary>
    /// A route that follows a specified radial path emanating from a given fix.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#RadialRoute"></see></summary>
    let RadialRoute = _prefix "RadialRoute"
    /// <summary>
    /// A control tower from which ramp controllers guide aircraft movements as they enter and exit the taxiways, and arrive and leave the gates. The ramp is the area of the airport surface where planes, service vehicles, and people meet.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#RampTower"></see></summary>
    let RampTower = _prefix "RampTower"
    /// <summary>
    /// Vechicle that transports and pumps jet fuel to refuel aircraft.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#RefuelingTruck"></see></summary>
    let RefuelingTruck = _prefix "RefuelingTruck"
    /// <summary>
    /// A measurement of the distance over which a pilot of an aircraft on the centerline of a runway can see the runway surface markings delineating the runway and its centerline. RVR (Runway Visible Range) is expressed as an interval specifying the minimum and maximum number of feet visible.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#RunwayVisibleRangeMeasurement"></see></summary>
    let RunwayVisibleRangeMeasurement = _prefix "RunwayVisibleRangeMeasurement"
    /// <summary>
    /// A SID (Standard Instrument Departure) is an air traffic control coded departure procedure that has been established at certain airports to simplify clearance delivery procedures.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#SID"></see></summary>
    let SID = _prefix "SID"
    /// <summary>
    /// A superclass of SID and STAR defining the properties shared by both, specifically the set of common, airport, and transition routes that comprise the SID/STAR.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#SIDSTAR"></see></summary>
    let SIDSTAR = _prefix "SIDSTAR"
    /// <summary>
    /// A STAR (Standard Terminal Arrival Route) is an air traffic control coded arrival route established for application to arriving IFR (Instrument Flight Rules) aircraft destined for certain airports.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#STAR"></see></summary>
    let STAR = _prefix "STAR"
    /// <summary>
    /// A defined volume in the the airspace of an ARTCC or TRACON whose flight traffic is typically controlled by a single controller.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#Sector"></see></summary>
    let Sector = _prefix "Sector"
    /// <summary>
    /// A non-airport location where operational weather monitoring hardware is installed.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#StandAloneWeatherStation"></see></summary>
    let StandAloneWeatherStation = _prefix "StandAloneWeatherStation"
    /// <summary>
    /// Terminal Radar Approach Control (TRACON) facility
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#TRACON"></see></summary>
    let TRACON = _prefix "TRACON"
    /// <summary>
    /// The type of TRACON: Tower-colocated TRACON or standalone TRACON.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONtype"></see></summary>
    let hasTRACONtype = _prefix "hasTRACONtype"
    /// <summary>
    /// A low altitude RNAV airway route. (RNAV routes allow an aircraft to choose any course within a network of navigation beacons, rather than navigate directly to and from the beacons.)
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#TRoute"></see></summary>
    let TRoute = _prefix "TRoute"
    /// <summary>
    /// An airport surface leading that connects the ramp area (i.e., the area in the vicinity of the gates) with the runways.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#Taxiway"></see></summary>
    let Taxiway = _prefix "Taxiway"
    /// <summary>
    /// A structure on the airport surface that serves as an interface between people, baggage, and aircraft.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#Terminal"></see></summary>
    let Terminal = _prefix "Terminal"
    /// <summary>
    /// A route within a SID or STAR that feeds aircraft into or out from the common route of the SID/STAR. In other words, the transition route is a feeder route from the en route segment of a flight into the heart of a STAR for arrival; or an exit route from a SID funneling flights to their appropriate initial jet routes for the en route segment of flight.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#TransitionRoute"></see></summary>
    let TransitionRoute = _prefix "TransitionRoute"
    /// <summary>
    /// A low altitude airway based on ground-based VOR sensor locations.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#VictorRoute"></see></summary>
    let VictorRoute = _prefix "VictorRoute"
    /// <summary>
    /// Links a sector to an immediately adjacent sector that shares a boundary.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#adjacentSector"></see></summary>
    let adjacentSector = _prefix "adjacentSector"
    /// <summary>
    /// An alternative name for an air carrier.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#airCarrierAlias"></see></summary>
    let airCarrierAlias = _prefix "airCarrierAlias"
    /// <summary>
    /// The official name of an air carrier.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#airCarrierName"></see></summary>
    let airCarrierName = _prefix "airCarrierName"
    /// <summary>
    /// The radio call sign associated with an the air carrier. Used by pilots and controllers to identify aircraft over radio frequencies.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#airlineCallsign"></see></summary>
    let airlineCallsign = _prefix "airlineCallsign"
    /// <summary>
    /// Links an airport to a representation of its perimeter boundary.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#airportBoundary"></see></summary>
    let airportBoundary = _prefix "airportBoundary"
    /// <summary>
    /// Links to a geographic point designated as the airport location.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#airportLocation"></see></summary>
    let airportLocation = _prefix "airportLocation"
    /// <summary>
    /// The official name of the airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#airportName"></see></summary>
    let airportName = _prefix "airportName"
    /// <summary>
    /// The upper altitude bound of an airspace layer.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#airspaceLayerHighAltitude"></see></summary>
    let airspaceLayerHighAltitude = _prefix "airspaceLayerHighAltitude"
    /// <summary>
    /// The lower altitude bound of an airspace layer.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#airspaceLayerLowAltitude"></see></summary>
    let airspaceLayerLowAltitude = _prefix "airspaceLayerLowAltitude"
    /// <summary>
    /// Links to the airport for which this route is destined.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#arrivalRouteAirport"></see></summary>
    let arrivalRouteAirport = _prefix "arrivalRouteAirport"
    /// <summary>
    /// The 3-letter ARTCC (Air Route Traffic Control Center) code.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#artccID"></see></summary>
    let artccID = _prefix "artccID"
    /// <summary>
    /// Associates some component of airport infrastructure (runway, terminal, tower, etc.) with its airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#associatedAirport"></see></summary>
    let associatedAirport = _prefix "associatedAirport"
    /// <summary>
    /// Associates a physical runway with its two operational runways (180 degrees apart, representing approaches from either end of the physical runway).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#associatedOpRunway"></see></summary>
    let associatedOpRunway = _prefix "associatedOpRunway"
    /// <summary>
    /// The month number associated with a day class.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#calendarMonth"></see></summary>
    let calendarMonth = _prefix "calendarMonth"
    /// <summary>
    /// The calendar year associated with a day class.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#calendarYear"></see></summary>
    let calendarYear = _prefix "calendarYear"
    /// <summary>
    /// The country name of the airline registration.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#countryOfRegistry"></see></summary>
    let countryOfRegistry = _prefix "countryOfRegistry"
    /// <summary>
    /// The date corresponding to the day represented by the day class. The value of this property is a date datatype. In contrast, the class represents the day conceptually as an object.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#date"></see></summary>
    let date = _prefix "date"
    /// <summary>
    /// The day number associated with a day class.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#dayOfMonth"></see></summary>
    let dayOfMonth = _prefix "dayOfMonth"
    /// <summary>
    /// Links a deicing pad with its location as a two-dimensional bounding polygon.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#deicingPadLocation"></see></summary>
    let deicingPadLocation = _prefix "deicingPadLocation"
    /// <summary>
    /// Links to the airport from which this route is destined.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#departureRouteAirport"></see></summary>
    let departureRouteAirport = _prefix "departureRouteAirport"
    /// <summary>
    /// The alphanumeric FAA code of lenth 3 or 4 for the airport. Contrasted with the ICAO and IATA codes, which in general are different. Often the IATA and FAA codes are identical.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#faaAirportCode"></see></summary>
    let faaAirportCode = _prefix "faaAirportCode"
    /// <summary>
    /// The gate identifier assigned by the airport authority.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#gateID"></see></summary>
    let gateID = _prefix "gateID"
    /// <summary>
    /// Associates an airport route with a SID or STAR. A SID or STAR has a single common route, but can have multiple airport or transition routes.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasAirportRoute"></see></summary>
    let hasAirportRoute = _prefix "hasAirportRoute"
    /// <summary>
    /// Links an airspace layer with a polygon describing its location in 3-space. A sector is composed of a sequence of layers, each of which is represented as a shear-sided polygonal volume.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasAirspaceLayerGeometry"></see></summary>
    let hasAirspaceLayerGeometry = _prefix "hasAirspaceLayerGeometry"
    /// <summary>
    /// Links an ARTCC to a 2-dimensional bounding polygon.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasCenterGeometry"></see></summary>
    let hasCenterGeometry = _prefix "hasCenterGeometry"
    /// <summary>
    /// Associates a common route with a SID or STAR. A SID or STAR has a single common route, but can have multiple airport or transition routes.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasCommonRoute"></see></summary>
    let hasCommonRoute = _prefix "hasCommonRoute"
    /// <summary>
    /// Associates an airport terminal with a aircraft gate located at that terminal.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasGate"></see></summary>
    let hasGate = _prefix "hasGate"
    /// <summary>
    /// This property links a NAS facility to another NAS facility when there is a letter of agreement (LOA) in place between them.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasLOAwith"></see></summary>
    let hasLOAwith = _prefix "hasLOAwith"
    /// <summary>
    /// Links a deicing pad to its queue of aircraft waiting to be deiced.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasQueue"></see></summary>
    let hasQueue = _prefix "hasQueue"
    /// <summary>
    /// Associates an airport terminal with a ramp tower that controlls the aircraft and vehicle traffic in the vicinity of that terminal.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasRampTower"></see></summary>
    let hasRampTower = _prefix "hasRampTower"
    /// <summary>
    /// Links an airport to a physical runway for that airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasRunway"></see></summary>
    let hasRunway = _prefix "hasRunway"
    /// <summary>
    /// Associates an airport with the the SIDs designated to route aircraft from that airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasSID"></see></summary>
    let hasSID = _prefix "hasSID"
    /// <summary>
    /// Associates an airport with the the STARs designated to route aircraft to that airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasSTAR"></see></summary>
    let hasSTAR = _prefix "hasSTAR"
    /// <summary>
    /// A sector identifier that consists of the ARTCC identifier concatenated with a three-digit number. This identifier is in general different than the sector name.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasSectorID"></see></summary>
    let hasSectorID = _prefix "hasSectorID"
    /// <summary>
    /// Links a sector to its vertically-stacked set of layers.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasSectorLayer"></see></summary>
    let hasSectorLayer = _prefix "hasSectorLayer"
    /// <summary>
    /// An alphanumeric sector name that is in general different than the sector ID.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasSectorName"></see></summary>
    let hasSectorName = _prefix "hasSectorName"
    /// <summary>
    /// The city name where the TRACON command center is located.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONcity"></see></summary>
    let hasTRACONcity = _prefix "hasTRACONcity"
    /// <summary>
    /// The FAA alphanumeric code for the TRACON.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONid"></see></summary>
    let hasTRACONid = _prefix "hasTRACONid"
    /// <summary>
    /// A link between the TRACON and its geographic extent, represented as a single shear-sided polygonal volume.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONlayer"></see></summary>
    let hasTRACONlayer = _prefix "hasTRACONlayer"
    /// <summary>
    /// The common name for the TRACON.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONname"></see></summary>
    let hasTRACONname = _prefix "hasTRACONname"
    /// <summary>
    /// The name of the US state in which the TRACON command center is located.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONstate"></see></summary>
    let hasTRACONstate = _prefix "hasTRACONstate"
    /// <summary>
    /// Links an airport to a taxiway for that airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTaxiway"></see></summary>
    let hasTaxiway = _prefix "hasTaxiway"
    /// <summary>
    /// Links an airport to a terminal for that airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTerminal"></see></summary>
    let hasTerminal = _prefix "hasTerminal"
    /// <summary>
    /// Asociates an ARTCC with the set of ARTCCs in its nth level tier.  Tier 1 includes the central ARTCC plus all ARTCCs immediately adjoining the central ARTCC; tier 2 includes tier 1 plus all adjacent ARTCCs two steps away from the central ARTCC. And so on.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTier"></see></summary>
    let hasTier = _prefix "hasTier"
    /// <summary>
    /// Links an airport to an air traffic control tower for that airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTower"></see></summary>
    let hasTower = _prefix "hasTower"
    /// <summary>
    /// Associates a transition route with a SID or STAR. A SID or STAR has a single common route, but can have multiple airport or transition routes.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTransitionRoute"></see></summary>
    let hasTransitionRoute = _prefix "hasTransitionRoute"
    /// <summary>
    /// The number of hours that the airport is offset from the UTC timezone.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hoursOffsetFromUTC"></see></summary>
    let hoursOffsetFromUTC = _prefix "hoursOffsetFromUTC"
    /// <summary>
    /// The thre-letter IATA code assigned to the airport. Contrast with the ICAO and FAA airport codes.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#iataAirportCode"></see></summary>
    let iataAirportCode = _prefix "iataAirportCode"
    /// <summary>
    /// The two-letter IATA code assigned to the carrier.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#iataCarrierCode"></see></summary>
    let iataCarrierCode = _prefix "iataCarrierCode"
    /// <summary>
    /// The four-letter ICAO code assignied to the airport. Contrast with the IATA and FAA airport codes.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#icaoAirportCode"></see></summary>
    let icaoAirportCode = _prefix "icaoAirportCode"
    /// <summary>
    /// The three-letter ICAO code assigned to the airline carrier.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#icaoCarrierCode"></see></summary>
    let icaoCarrierCode = _prefix "icaoCarrierCode"
    /// <summary>
    /// A link between an ARTCC tier and the ARTCCs included in the tier.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#includesARTCC"></see></summary>
    let includesARTCC = _prefix "includesARTCC"
    /// <summary>
    /// Indicates whether this airport is capable of an instrument approach.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#isInstrumentControlEligible"></see></summary>
    let isInstrumentControlEligible = _prefix "isInstrumentControlEligible"
    /// <summary>
    /// Indicates whether this airport is a METAR weather reporting station.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#isWeatherReportingStation"></see></summary>
    let isWeatherReportingStation = _prefix "isWeatherReportingStation"
    /// <summary>
    /// Links a sector to the ARTCC in which the sector is located.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#locatedInCenter"></see></summary>
    let locatedInCenter = _prefix "locatedInCenter"
    /// <summary>
    /// The 2-letter US postal code for the state in which the airport is located.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#locatedInState"></see></summary>
    let locatedInState = _prefix "locatedInState"
    /// <summary>
    /// The country name where the manufacturer is established.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#manufacturerCountryName"></see></summary>
    let manufacturerCountryName = _prefix "manufacturerCountryName"
    /// <summary>
    /// The full name of the manufacturer.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#manufacturerFullName"></see></summary>
    let manufacturerFullName = _prefix "manufacturerFullName"
    /// <summary>
    /// The upper bound of visibility in feet over the centerline of the runway.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#maxVisibility"></see></summary>
    let maxVisibility = _prefix "maxVisibility"
    /// <summary>
    /// The lower bound of visibility in feet over the centerline of the runway.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#minVisibility"></see></summary>
    let minVisibility = _prefix "minVisibility"
    /// <summary>
    /// FAA alphanumeric identifier assigned to the route/airway.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#routeID"></see></summary>
    let routeID = _prefix "routeID"
    /// <summary>
    /// Associates a physical runway with its bounding two-dimensional rectangle.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#runwayFootprint"></see></summary>
    let runwayFootprint = _prefix "runwayFootprint"
    /// <summary>
    /// An identifier for the runway. For physical runways, the convention is to label runways by their heading, dropping the last digit. E.g. for Liverpool, runway 9/27 is facing approximately magnetic heading 90 degrees in one direction, and 270 degrees in the opposite direction. If an airport has parallel runways, these would then be marked Left, Center and Right, e.g. 9L, 9C, 9R. For operational runways, the runway identifiers specifies one direction only: either 9 or 27 in the Liverpool example.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#runwayID"></see></summary>
    let runwayID = _prefix "runwayID"
    /// <summary>
    /// The length in feet of the physical runway.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#runwayLengthInFeet"></see></summary>
    let runwayLengthInFeet = _prefix "runwayLengthInFeet"
    /// <summary>
    /// Indicates which operational runway is being measured for visible range.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#runwayMeasured"></see></summary>
    let runwayMeasured = _prefix "runwayMeasured"
    /// <summary>
    /// The width in feet of the physical runway.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#runwayWidthInFeet"></see></summary>
    let runwayWidthInFeet = _prefix "runwayWidthInFeet"
    /// <summary>
    /// The FAA identifier for the SID or STAR. Typically, but not uniformly, 5 alpha characters plus a revision digit.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#sidstarID"></see></summary>
    let sidstarID = _prefix "sidstarID"
    /// <summary>
    /// The beginning of the hour stored as a datetime value.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#startingTime"></see></summary>
    let startingTime = _prefix "startingTime"
    /// <summary>
    /// Associates a taxiway with its bounding two-dimensional rectangle.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#taxiwayFootprint"></see></summary>
    let taxiwayFootprint = _prefix "taxiwayFootprint"
    /// <summary>
    /// An identifier for the taxiway.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#taxiwayID"></see></summary>
    let taxiwayID = _prefix "taxiwayID"
    /// <summary>
    /// The alphanumeric identifier of the airport terminal.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#terminalID"></see></summary>
    let terminalID = _prefix "terminalID"
    /// <summary>
    /// The maximum number of aircraft permitted in a given sector at any time, per agreement between FAA and Air Traffic Controller union. MAP (Monitor Alert Parameter) is a TFMS input parameter.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#tfmsMonitorAlertParameter"></see></summary>
    let tfmsMonitorAlertParameter = _prefix "tfmsMonitorAlertParameter"
    /// <summary>
    /// The degree number of the ARTCC tier. Tier 1 includes the central ARTCC plus all ARTCCs immediately adjoining the central ARTCC; tier 2 includes tier 1 plus all adjacent ARTCCs two steps away from the central ARTCC. And so on.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#tierLevel"></see></summary>
    let tierLevel = _prefix "tierLevel"
    /// <summary>
    /// Links to the geographical point location that is the touchdown spot on the operational runway.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#touchdownPoint"></see></summary>
    let touchdownPoint = _prefix "touchdownPoint"
    /// <summary>
    /// The FAA identifier for air traffic control tower.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#towerID"></see></summary>
    let towerID = _prefix "towerID"
    /// <summary>
    /// Links the airport to the ARTCC within which it is located.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#withinARTCC"></see></summary>
    let withinARTCC = _prefix "withinARTCC"
    /// <summary>
    /// The timezone identifier for the airport, where the timezone is specified as Area/Location, e.g. America/New_York.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#withinTimezone"></see></summary>
    let withinTimezone = _prefix "withinTimezone"
