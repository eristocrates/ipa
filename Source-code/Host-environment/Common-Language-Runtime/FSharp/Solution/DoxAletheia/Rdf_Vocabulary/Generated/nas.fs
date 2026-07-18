namespace https.data.nasa.gov.ontologies.atmonto.NAS.hash

open DoxAletheia.Rdf_Vocabulary

module nas =
    let _namespace_name = "https://data.nasa.gov/ontologies/atmonto/NAS#"
    /// <summary>
    /// Air Route Traffic Control Center (ARTCC or 'Center') facility
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#ARTCC"></see></summary>
    let ARTCC = Namespaced_IRI.parse _namespace_name "ARTCC" |> NamespacedName

    /// <summary>
    /// The set of FAA and airport facilities involved in operational air traffic management.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#NASfacility"></see></summary>
    let NASfacility =
        Namespaced_IRI.parse _namespace_name "NASfacility" |> NamespacedName

    /// <summary>
    /// A defined substructure of the airspace used to manage air traffic, including sectors, SIDs, STARs, routes, etc.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AirspaceInfrastructureComponent"></see></summary>
    let AirspaceInfrastructureComponent =
        Namespaced_IRI.parse _namespace_name "AirspaceInfrastructureComponent" |> NamespacedName

    /// <summary>
    /// A donut-shaped geographical area surrounding a designated central ARTCC. The first tier includes all the ARTCCs that share a boundary with the designated  ARTCC. The tier two ARTCCs includes the first tier ARTCCs plus those adjacent to the first tier ARCCCs. And so on.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#ARTCCtier"></see></summary>
    let ARTCCtier = Namespaced_IRI.parse _namespace_name "ARTCCtier" |> NamespacedName
    /// <summary>
    /// Air Traffic Control System Command Center (ATCSCC) facility
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#ATCSCC"></see></summary>
    let ATCSCC = Namespaced_IRI.parse _namespace_name "ATCSCC" |> NamespacedName
    /// <summary>
    /// Air Traffic Control Tower (ATCT) facility
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#ATCT"></see></summary>
    let ATCT = Namespaced_IRI.parse _namespace_name "ATCT" |> NamespacedName

    /// <summary>
    /// Part of an airport's physical infrastructure, including gates, terminals, runways, taxiways, etc.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AirportInfrastructureComponent"></see></summary>
    let AirportInfrastructureComponent =
        Namespaced_IRI.parse _namespace_name "AirportInfrastructureComponent" |> NamespacedName

    /// <summary>
    /// An entity that it licensed to operate aircraft.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AirCarrier"></see></summary>
    let AirCarrier = Namespaced_IRI.parse _namespace_name "AirCarrier" |> NamespacedName

    /// <summary>
    /// A superclass encompassing all entities that provide aviation services in the public and private sectors.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AviationServiceProvider"></see></summary>
    let AviationServiceProvider =
        Namespaced_IRI.parse _namespace_name "AviationServiceProvider" |> NamespacedName

    /// <summary>
    /// A manufacturer of aircraft engines.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AircraftEngineManufacturer"></see></summary>
    let AircraftEngineManufacturer =
        Namespaced_IRI.parse _namespace_name "AircraftEngineManufacturer" |> NamespacedName

    /// <summary>
    /// A superclass encompassing the set of airframe and engine manufacturers.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AviationIndustryManufacturer"></see></summary>
    let AviationIndustryManufacturer =
        Namespaced_IRI.parse _namespace_name "AviationIndustryManufacturer" |> NamespacedName

    /// <summary>
    /// A manufacturer of physical aircraft.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AirframeManufacturer"></see></summary>
    let AirframeManufacturer =
        Namespaced_IRI.parse _namespace_name "AirframeManufacturer" |> NamespacedName

    /// <summary>
    /// A facility where regularly-scheduled aircraft arrive and depart.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#Airport"></see></summary>
    let Airport = Namespaced_IRI.parse _namespace_name "Airport" |> NamespacedName

    /// <summary>
    /// A route within a SID or STAR that connects the common route to one of multiple airports that use the SID/STAR.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AirportRoute"></see></summary>
    let AirportRoute =
        Namespaced_IRI.parse _namespace_name "AirportRoute" |> NamespacedName

    /// <summary>
    /// A route that defines a SID or STAR.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#SIDSTARroute"></see></summary>
    let SIDSTARroute =
        Namespaced_IRI.parse _namespace_name "SIDSTARroute" |> NamespacedName

    /// <summary>
    /// A class of vehicles that service the flights and maintain the airport physical infrastructure.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AirportServiceVehicle"></see></summary>
    let AirportServiceVehicle =
        Namespaced_IRI.parse _namespace_name "AirportServiceVehicle" |> NamespacedName

    /// <summary>
    /// Represents a layer within the airspace, defined by a shear-sided polygon with specified low and high altitudes.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AirspaceLayer"></see></summary>
    let AirspaceLayer =
        Namespaced_IRI.parse _namespace_name "AirspaceLayer" |> NamespacedName

    /// <summary>
    /// An ordered sequence of navigation elements specifying a path through the airspace.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#AirspaceRoute"></see></summary>
    let AirspaceRoute =
        Namespaced_IRI.parse _namespace_name "AirspaceRoute" |> NamespacedName

    /// <summary>
    /// The set of airports in the continental US.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#CONUSairport"></see></summary>
    let CONUSairport =
        Namespaced_IRI.parse _namespace_name "CONUSairport" |> NamespacedName

    /// <summary>
    /// The set of airports located in the United States.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#USairport"></see></summary>
    let USairport = Namespaced_IRI.parse _namespace_name "USairport" |> NamespacedName

    /// <summary>
    /// The set of Canadian airports.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#CanadianAirport"></see></summary>
    let CanadianAirport =
        Namespaced_IRI.parse _namespace_name "CanadianAirport" |> NamespacedName

    /// <summary>
    /// The set of international (i.e., non-US) airports.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#InternationalAirport"></see></summary>
    let InternationalAirport =
        Namespaced_IRI.parse _namespace_name "InternationalAirport" |> NamespacedName

    /// <summary>
    /// The backbone portion of a SID or STAR that is flown by all aircraft.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#CommonRoute"></see></summary>
    let CommonRoute =
        Namespaced_IRI.parse _namespace_name "CommonRoute" |> NamespacedName

    /// <summary>
    /// A physical location in the airport where deicing is performed.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#DeicingPad"></see></summary>
    let DeicingPad = Namespaced_IRI.parse _namespace_name "DeicingPad" |> NamespacedName

    /// <summary>
    /// An ordered sequence of aircraft awaiting deicing at a deicing pad.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#DeicingQueue"></see></summary>
    let DeicingQueue =
        Namespaced_IRI.parse _namespace_name "DeicingQueue" |> NamespacedName

    /// <summary>
    /// A vehicle that holds deicing fluid and pumping equipment to support deicing.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#DeicingTruck"></see></summary>
    let DeicingTruck =
        Namespaced_IRI.parse _namespace_name "DeicingTruck" |> NamespacedName

    /// <summary>
    /// An airspace route that is defined by FAA and can be filed as part of a flight plan: a jet route, a Q-route,  a T-Route, a Victor route.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#FederalAirway"></see></summary>
    let FederalAirway =
        Namespaced_IRI.parse _namespace_name "FederalAirway" |> NamespacedName

    /// <summary>
    /// A physical interface between the aircraft and the terminal, used to board passengers and crew.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#Gate"></see></summary>
    let Gate = Namespaced_IRI.parse _namespace_name "Gate" |> NamespacedName

    /// <summary>
    /// The set of govenment agencies that perform aviation services.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#GovernmentAviationServiceProvider"></see></summary>
    let GovernmentAviationServiceProvider =
        Namespaced_IRI.parse _namespace_name "GovernmentAviationServiceProvider" |> NamespacedName

    /// <summary>
    /// A high altitude airway based on ground-based VOR sensor locations.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#JetRoute"></see></summary>
    let JetRoute = Namespaced_IRI.parse _namespace_name "JetRoute" |> NamespacedName
    /// <summary>
    /// A VOR route is defined relative to a network of existing ground-based VOR navigation beacons. VOR routes consist of point-to-point segments, where the points are defined by the beacons. More modern RNAV routes allow any path within the network, not limited to VOR-to-VOR segments.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#VORroute"></see></summary>
    let VORroute = Namespaced_IRI.parse _namespace_name "VORroute" |> NamespacedName
    /// <summary>
    /// A class that represents a day of the year. Events, such as flights, weather forecasts, and other events are linked to the instance of the day they occurred.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#NASday"></see></summary>
    let NASday = Namespaced_IRI.parse _namespace_name "NASday" |> NamespacedName
    /// <summary>
    /// A class that represents an hour within a day. Events, such as flights, weather forecasts, and other events are linked to the instance of the day they occurred.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#NAShour"></see></summary>
    let NAShour = Namespaced_IRI.parse _namespace_name "NAShour" |> NamespacedName

    /// <summary>
    /// The set of airports located in the United States, but outside the contiguous lower 48 states.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#NonCONUSairport"></see></summary>
    let NonCONUSairport =
        Namespaced_IRI.parse _namespace_name "NonCONUSairport" |> NamespacedName

    /// <summary>
    /// An operational runway is a named runway one used in airport operations. There are two operational runways corresponding to one physical runway; these operational runways are 180 degrees apart.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#OperationalRunway"></see></summary>
    let OperationalRunway =
        Namespaced_IRI.parse _namespace_name "OperationalRunway" |> NamespacedName

    /// <summary>
    /// A physical runway, defined as a delimited rectangular surface region of the airport. Each physical runway is associated with two operational runways, 180 degrees apart.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#PhysicalRunway"></see></summary>
    let PhysicalRunway =
        Namespaced_IRI.parse _namespace_name "PhysicalRunway" |> NamespacedName

    /// <summary>
    /// A high altitude RNAV airway route. (RNAV routes allow an aircraft to choose any course within a network of navigation beacons, rather than navigate directly to and from the beacons.)
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#QRoute"></see></summary>
    let QRoute = Namespaced_IRI.parse _namespace_name "QRoute" |> NamespacedName
    /// <summary>
    /// An RNAV (Random Navigation) route is defined relative to a network of existing ground-based navigation beacons.  RNAV allows an aircraft to choose any course within the network, rather than navigate using only point-to-point routes defined by the beacons.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#RNAVroute"></see></summary>
    let RNAVroute = Namespaced_IRI.parse _namespace_name "RNAVroute" |> NamespacedName

    /// <summary>
    /// A route that follows a specified radial path emanating from a given fix.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#RadialRoute"></see></summary>
    let RadialRoute =
        Namespaced_IRI.parse _namespace_name "RadialRoute" |> NamespacedName

    /// <summary>
    /// A control tower from which ramp controllers guide aircraft movements as they enter and exit the taxiways, and arrive and leave the gates. The ramp is the area of the airport surface where planes, service vehicles, and people meet.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#RampTower"></see></summary>
    let RampTower = Namespaced_IRI.parse _namespace_name "RampTower" |> NamespacedName

    /// <summary>
    /// Vechicle that transports and pumps jet fuel to refuel aircraft.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#RefuelingTruck"></see></summary>
    let RefuelingTruck =
        Namespaced_IRI.parse _namespace_name "RefuelingTruck" |> NamespacedName

    /// <summary>
    /// A measurement of the distance over which a pilot of an aircraft on the centerline of a runway can see the runway surface markings delineating the runway and its centerline. RVR (Runway Visible Range) is expressed as an interval specifying the minimum and maximum number of feet visible.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#RunwayVisibleRangeMeasurement"></see></summary>
    let RunwayVisibleRangeMeasurement =
        Namespaced_IRI.parse _namespace_name "RunwayVisibleRangeMeasurement" |> NamespacedName

    /// <summary>
    /// A SID (Standard Instrument Departure) is an air traffic control coded departure procedure that has been established at certain airports to simplify clearance delivery procedures.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#SID"></see></summary>
    let SID = Namespaced_IRI.parse _namespace_name "SID" |> NamespacedName
    /// <summary>
    /// A superclass of SID and STAR defining the properties shared by both, specifically the set of common, airport, and transition routes that comprise the SID/STAR.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#SIDSTAR"></see></summary>
    let SIDSTAR = Namespaced_IRI.parse _namespace_name "SIDSTAR" |> NamespacedName
    /// <summary>
    /// A STAR (Standard Terminal Arrival Route) is an air traffic control coded arrival route established for application to arriving IFR (Instrument Flight Rules) aircraft destined for certain airports.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#STAR"></see></summary>
    let STAR = Namespaced_IRI.parse _namespace_name "STAR" |> NamespacedName
    /// <summary>
    /// A defined volume in the the airspace of an ARTCC or TRACON whose flight traffic is typically controlled by a single controller.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#Sector"></see></summary>
    let Sector = Namespaced_IRI.parse _namespace_name "Sector" |> NamespacedName

    /// <summary>
    /// A non-airport location where operational weather monitoring hardware is installed.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#StandAloneWeatherStation"></see></summary>
    let StandAloneWeatherStation =
        Namespaced_IRI.parse _namespace_name "StandAloneWeatherStation" |> NamespacedName

    /// <summary>
    /// Terminal Radar Approach Control (TRACON) facility
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#TRACON"></see></summary>
    let TRACON = Namespaced_IRI.parse _namespace_name "TRACON" |> NamespacedName

    /// <summary>
    /// The type of TRACON: Tower-colocated TRACON or standalone TRACON.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONtype"></see></summary>
    let hasTRACONtype =
        Namespaced_IRI.parse _namespace_name "hasTRACONtype" |> NamespacedName

    /// <summary>
    /// A low altitude RNAV airway route. (RNAV routes allow an aircraft to choose any course within a network of navigation beacons, rather than navigate directly to and from the beacons.)
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#TRoute"></see></summary>
    let TRoute = Namespaced_IRI.parse _namespace_name "TRoute" |> NamespacedName
    /// <summary>
    /// An airport surface leading that connects the ramp area (i.e., the area in the vicinity of the gates) with the runways.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#Taxiway"></see></summary>
    let Taxiway = Namespaced_IRI.parse _namespace_name "Taxiway" |> NamespacedName
    /// <summary>
    /// A structure on the airport surface that serves as an interface between people, baggage, and aircraft.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#Terminal"></see></summary>
    let Terminal = Namespaced_IRI.parse _namespace_name "Terminal" |> NamespacedName

    /// <summary>
    /// A route within a SID or STAR that feeds aircraft into or out from the common route of the SID/STAR. In other words, the transition route is a feeder route from the en route segment of a flight into the heart of a STAR for arrival; or an exit route from a SID funneling flights to their appropriate initial jet routes for the en route segment of flight.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#TransitionRoute"></see></summary>
    let TransitionRoute =
        Namespaced_IRI.parse _namespace_name "TransitionRoute" |> NamespacedName

    /// <summary>
    /// A low altitude airway based on ground-based VOR sensor locations.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#VictorRoute"></see></summary>
    let VictorRoute =
        Namespaced_IRI.parse _namespace_name "VictorRoute" |> NamespacedName

    /// <summary>
    /// Links a sector to an immediately adjacent sector that shares a boundary.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#adjacentSector"></see></summary>
    let adjacentSector =
        Namespaced_IRI.parse _namespace_name "adjacentSector" |> NamespacedName

    /// <summary>
    /// An alternative name for an air carrier.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#airCarrierAlias"></see></summary>
    let airCarrierAlias =
        Namespaced_IRI.parse _namespace_name "airCarrierAlias" |> NamespacedName

    /// <summary>
    /// The official name of an air carrier.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#airCarrierName"></see></summary>
    let airCarrierName =
        Namespaced_IRI.parse _namespace_name "airCarrierName" |> NamespacedName

    /// <summary>
    /// The radio call sign associated with an the air carrier. Used by pilots and controllers to identify aircraft over radio frequencies.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#airlineCallsign"></see></summary>
    let airlineCallsign =
        Namespaced_IRI.parse _namespace_name "airlineCallsign" |> NamespacedName

    /// <summary>
    /// Links an airport to a representation of its perimeter boundary.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#airportBoundary"></see></summary>
    let airportBoundary =
        Namespaced_IRI.parse _namespace_name "airportBoundary" |> NamespacedName

    /// <summary>
    /// Links to a geographic point designated as the airport location.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#airportLocation"></see></summary>
    let airportLocation =
        Namespaced_IRI.parse _namespace_name "airportLocation" |> NamespacedName

    /// <summary>
    /// The official name of the airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#airportName"></see></summary>
    let airportName =
        Namespaced_IRI.parse _namespace_name "airportName" |> NamespacedName

    /// <summary>
    /// The upper altitude bound of an airspace layer.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#airspaceLayerHighAltitude"></see></summary>
    let airspaceLayerHighAltitude =
        Namespaced_IRI.parse _namespace_name "airspaceLayerHighAltitude" |> NamespacedName

    /// <summary>
    /// The lower altitude bound of an airspace layer.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#airspaceLayerLowAltitude"></see></summary>
    let airspaceLayerLowAltitude =
        Namespaced_IRI.parse _namespace_name "airspaceLayerLowAltitude" |> NamespacedName

    /// <summary>
    /// Links to the airport for which this route is destined.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#arrivalRouteAirport"></see></summary>
    let arrivalRouteAirport =
        Namespaced_IRI.parse _namespace_name "arrivalRouteAirport" |> NamespacedName

    /// <summary>
    /// The 3-letter ARTCC (Air Route Traffic Control Center) code.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#artccID"></see></summary>
    let artccID = Namespaced_IRI.parse _namespace_name "artccID" |> NamespacedName

    /// <summary>
    /// Associates some component of airport infrastructure (runway, terminal, tower, etc.) with its airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#associatedAirport"></see></summary>
    let associatedAirport =
        Namespaced_IRI.parse _namespace_name "associatedAirport" |> NamespacedName

    /// <summary>
    /// Associates a physical runway with its two operational runways (180 degrees apart, representing approaches from either end of the physical runway).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#associatedOpRunway"></see></summary>
    let associatedOpRunway =
        Namespaced_IRI.parse _namespace_name "associatedOpRunway" |> NamespacedName

    /// <summary>
    /// The month number associated with a day class.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#calendarMonth"></see></summary>
    let calendarMonth =
        Namespaced_IRI.parse _namespace_name "calendarMonth" |> NamespacedName

    /// <summary>
    /// The calendar year associated with a day class.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#calendarYear"></see></summary>
    let calendarYear =
        Namespaced_IRI.parse _namespace_name "calendarYear" |> NamespacedName

    /// <summary>
    /// The country name of the airline registration.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#countryOfRegistry"></see></summary>
    let countryOfRegistry =
        Namespaced_IRI.parse _namespace_name "countryOfRegistry" |> NamespacedName

    /// <summary>
    /// The date corresponding to the day represented by the day class. The value of this property is a date datatype. In contrast, the class represents the day conceptually as an object.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#date"></see></summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName
    /// <summary>
    /// The day number associated with a day class.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#dayOfMonth"></see></summary>
    let dayOfMonth = Namespaced_IRI.parse _namespace_name "dayOfMonth" |> NamespacedName

    /// <summary>
    /// Links a deicing pad with its location as a two-dimensional bounding polygon.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#deicingPadLocation"></see></summary>
    let deicingPadLocation =
        Namespaced_IRI.parse _namespace_name "deicingPadLocation" |> NamespacedName

    /// <summary>
    /// Links to the airport from which this route is destined.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#departureRouteAirport"></see></summary>
    let departureRouteAirport =
        Namespaced_IRI.parse _namespace_name "departureRouteAirport" |> NamespacedName

    /// <summary>
    /// The alphanumeric FAA code of lenth 3 or 4 for the airport. Contrasted with the ICAO and IATA codes, which in general are different. Often the IATA and FAA codes are identical.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#faaAirportCode"></see></summary>
    let faaAirportCode =
        Namespaced_IRI.parse _namespace_name "faaAirportCode" |> NamespacedName

    /// <summary>
    /// The gate identifier assigned by the airport authority.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#gateID"></see></summary>
    let gateID = Namespaced_IRI.parse _namespace_name "gateID" |> NamespacedName

    /// <summary>
    /// Associates an airport route with a SID or STAR. A SID or STAR has a single common route, but can have multiple airport or transition routes.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasAirportRoute"></see></summary>
    let hasAirportRoute =
        Namespaced_IRI.parse _namespace_name "hasAirportRoute" |> NamespacedName

    /// <summary>
    /// Links an airspace layer with a polygon describing its location in 3-space. A sector is composed of a sequence of layers, each of which is represented as a shear-sided polygonal volume.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasAirspaceLayerGeometry"></see></summary>
    let hasAirspaceLayerGeometry =
        Namespaced_IRI.parse _namespace_name "hasAirspaceLayerGeometry" |> NamespacedName

    /// <summary>
    /// Links an ARTCC to a 2-dimensional bounding polygon.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasCenterGeometry"></see></summary>
    let hasCenterGeometry =
        Namespaced_IRI.parse _namespace_name "hasCenterGeometry" |> NamespacedName

    /// <summary>
    /// Associates a common route with a SID or STAR. A SID or STAR has a single common route, but can have multiple airport or transition routes.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasCommonRoute"></see></summary>
    let hasCommonRoute =
        Namespaced_IRI.parse _namespace_name "hasCommonRoute" |> NamespacedName

    /// <summary>
    /// Associates an airport terminal with a aircraft gate located at that terminal.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasGate"></see></summary>
    let hasGate = Namespaced_IRI.parse _namespace_name "hasGate" |> NamespacedName
    /// <summary>
    /// This property links a NAS facility to another NAS facility when there is a letter of agreement (LOA) in place between them.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasLOAwith"></see></summary>
    let hasLOAwith = Namespaced_IRI.parse _namespace_name "hasLOAwith" |> NamespacedName
    /// <summary>
    /// Links a deicing pad to its queue of aircraft waiting to be deiced.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasQueue"></see></summary>
    let hasQueue = Namespaced_IRI.parse _namespace_name "hasQueue" |> NamespacedName

    /// <summary>
    /// Associates an airport terminal with a ramp tower that controlls the aircraft and vehicle traffic in the vicinity of that terminal.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasRampTower"></see></summary>
    let hasRampTower =
        Namespaced_IRI.parse _namespace_name "hasRampTower" |> NamespacedName

    /// <summary>
    /// Links an airport to a physical runway for that airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasRunway"></see></summary>
    let hasRunway = Namespaced_IRI.parse _namespace_name "hasRunway" |> NamespacedName
    /// <summary>
    /// Associates an airport with the the SIDs designated to route aircraft from that airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasSID"></see></summary>
    let hasSID = Namespaced_IRI.parse _namespace_name "hasSID" |> NamespacedName
    /// <summary>
    /// Associates an airport with the the STARs designated to route aircraft to that airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasSTAR"></see></summary>
    let hasSTAR = Namespaced_IRI.parse _namespace_name "hasSTAR" |> NamespacedName

    /// <summary>
    /// A sector identifier that consists of the ARTCC identifier concatenated with a three-digit number. This identifier is in general different than the sector name.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasSectorID"></see></summary>
    let hasSectorID =
        Namespaced_IRI.parse _namespace_name "hasSectorID" |> NamespacedName

    /// <summary>
    /// Links a sector to its vertically-stacked set of layers.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasSectorLayer"></see></summary>
    let hasSectorLayer =
        Namespaced_IRI.parse _namespace_name "hasSectorLayer" |> NamespacedName

    /// <summary>
    /// An alphanumeric sector name that is in general different than the sector ID.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasSectorName"></see></summary>
    let hasSectorName =
        Namespaced_IRI.parse _namespace_name "hasSectorName" |> NamespacedName

    /// <summary>
    /// The city name where the TRACON command center is located.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONcity"></see></summary>
    let hasTRACONcity =
        Namespaced_IRI.parse _namespace_name "hasTRACONcity" |> NamespacedName

    /// <summary>
    /// The FAA alphanumeric code for the TRACON.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONid"></see></summary>
    let hasTRACONid =
        Namespaced_IRI.parse _namespace_name "hasTRACONid" |> NamespacedName

    /// <summary>
    /// A link between the TRACON and its geographic extent, represented as a single shear-sided polygonal volume.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONlayer"></see></summary>
    let hasTRACONlayer =
        Namespaced_IRI.parse _namespace_name "hasTRACONlayer" |> NamespacedName

    /// <summary>
    /// The common name for the TRACON.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONname"></see></summary>
    let hasTRACONname =
        Namespaced_IRI.parse _namespace_name "hasTRACONname" |> NamespacedName

    /// <summary>
    /// The name of the US state in which the TRACON command center is located.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONstate"></see></summary>
    let hasTRACONstate =
        Namespaced_IRI.parse _namespace_name "hasTRACONstate" |> NamespacedName

    /// <summary>
    /// Links an airport to a taxiway for that airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTaxiway"></see></summary>
    let hasTaxiway = Namespaced_IRI.parse _namespace_name "hasTaxiway" |> NamespacedName

    /// <summary>
    /// Links an airport to a terminal for that airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTerminal"></see></summary>
    let hasTerminal =
        Namespaced_IRI.parse _namespace_name "hasTerminal" |> NamespacedName

    /// <summary>
    /// Asociates an ARTCC with the set of ARTCCs in its nth level tier.  Tier 1 includes the central ARTCC plus all ARTCCs immediately adjoining the central ARTCC; tier 2 includes tier 1 plus all adjacent ARTCCs two steps away from the central ARTCC. And so on.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTier"></see></summary>
    let hasTier = Namespaced_IRI.parse _namespace_name "hasTier" |> NamespacedName
    /// <summary>
    /// Links an airport to an air traffic control tower for that airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTower"></see></summary>
    let hasTower = Namespaced_IRI.parse _namespace_name "hasTower" |> NamespacedName

    /// <summary>
    /// Associates a transition route with a SID or STAR. A SID or STAR has a single common route, but can have multiple airport or transition routes.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTransitionRoute"></see></summary>
    let hasTransitionRoute =
        Namespaced_IRI.parse _namespace_name "hasTransitionRoute" |> NamespacedName

    /// <summary>
    /// The number of hours that the airport is offset from the UTC timezone.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#hoursOffsetFromUTC"></see></summary>
    let hoursOffsetFromUTC =
        Namespaced_IRI.parse _namespace_name "hoursOffsetFromUTC" |> NamespacedName

    /// <summary>
    /// The thre-letter IATA code assigned to the airport. Contrast with the ICAO and FAA airport codes.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#iataAirportCode"></see></summary>
    let iataAirportCode =
        Namespaced_IRI.parse _namespace_name "iataAirportCode" |> NamespacedName

    /// <summary>
    /// The two-letter IATA code assigned to the carrier.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#iataCarrierCode"></see></summary>
    let iataCarrierCode =
        Namespaced_IRI.parse _namespace_name "iataCarrierCode" |> NamespacedName

    /// <summary>
    /// The four-letter ICAO code assignied to the airport. Contrast with the IATA and FAA airport codes.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#icaoAirportCode"></see></summary>
    let icaoAirportCode =
        Namespaced_IRI.parse _namespace_name "icaoAirportCode" |> NamespacedName

    /// <summary>
    /// The three-letter ICAO code assigned to the airline carrier.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#icaoCarrierCode"></see></summary>
    let icaoCarrierCode =
        Namespaced_IRI.parse _namespace_name "icaoCarrierCode" |> NamespacedName

    /// <summary>
    /// A link between an ARTCC tier and the ARTCCs included in the tier.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#includesARTCC"></see></summary>
    let includesARTCC =
        Namespaced_IRI.parse _namespace_name "includesARTCC" |> NamespacedName

    /// <summary>
    /// Indicates whether this airport is capable of an instrument approach.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#isInstrumentControlEligible"></see></summary>
    let isInstrumentControlEligible =
        Namespaced_IRI.parse _namespace_name "isInstrumentControlEligible" |> NamespacedName

    /// <summary>
    /// Indicates whether this airport is a METAR weather reporting station.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#isWeatherReportingStation"></see></summary>
    let isWeatherReportingStation =
        Namespaced_IRI.parse _namespace_name "isWeatherReportingStation" |> NamespacedName

    /// <summary>
    /// Links a sector to the ARTCC in which the sector is located.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#locatedInCenter"></see></summary>
    let locatedInCenter =
        Namespaced_IRI.parse _namespace_name "locatedInCenter" |> NamespacedName

    /// <summary>
    /// The 2-letter US postal code for the state in which the airport is located.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#locatedInState"></see></summary>
    let locatedInState =
        Namespaced_IRI.parse _namespace_name "locatedInState" |> NamespacedName

    /// <summary>
    /// The country name where the manufacturer is established.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#manufacturerCountryName"></see></summary>
    let manufacturerCountryName =
        Namespaced_IRI.parse _namespace_name "manufacturerCountryName" |> NamespacedName

    /// <summary>
    /// The full name of the manufacturer.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#manufacturerFullName"></see></summary>
    let manufacturerFullName =
        Namespaced_IRI.parse _namespace_name "manufacturerFullName" |> NamespacedName

    /// <summary>
    /// The upper bound of visibility in feet over the centerline of the runway.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#maxVisibility"></see></summary>
    let maxVisibility =
        Namespaced_IRI.parse _namespace_name "maxVisibility" |> NamespacedName

    /// <summary>
    /// The lower bound of visibility in feet over the centerline of the runway.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#minVisibility"></see></summary>
    let minVisibility =
        Namespaced_IRI.parse _namespace_name "minVisibility" |> NamespacedName

    /// <summary>
    /// FAA alphanumeric identifier assigned to the route/airway.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#routeID"></see></summary>
    let routeID = Namespaced_IRI.parse _namespace_name "routeID" |> NamespacedName

    /// <summary>
    /// Associates a physical runway with its bounding two-dimensional rectangle.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#runwayFootprint"></see></summary>
    let runwayFootprint =
        Namespaced_IRI.parse _namespace_name "runwayFootprint" |> NamespacedName

    /// <summary>
    /// An identifier for the runway. For physical runways, the convention is to label runways by their heading, dropping the last digit. E.g. for Liverpool, runway 9/27 is facing approximately magnetic heading 90 degrees in one direction, and 270 degrees in the opposite direction. If an airport has parallel runways, these would then be marked Left, Center and Right, e.g. 9L, 9C, 9R. For operational runways, the runway identifiers specifies one direction only: either 9 or 27 in the Liverpool example.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#runwayID"></see></summary>
    let runwayID = Namespaced_IRI.parse _namespace_name "runwayID" |> NamespacedName

    /// <summary>
    /// The length in feet of the physical runway.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#runwayLengthInFeet"></see></summary>
    let runwayLengthInFeet =
        Namespaced_IRI.parse _namespace_name "runwayLengthInFeet" |> NamespacedName

    /// <summary>
    /// Indicates which operational runway is being measured for visible range.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#runwayMeasured"></see></summary>
    let runwayMeasured =
        Namespaced_IRI.parse _namespace_name "runwayMeasured" |> NamespacedName

    /// <summary>
    /// The width in feet of the physical runway.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#runwayWidthInFeet"></see></summary>
    let runwayWidthInFeet =
        Namespaced_IRI.parse _namespace_name "runwayWidthInFeet" |> NamespacedName

    /// <summary>
    /// The FAA identifier for the SID or STAR. Typically, but not uniformly, 5 alpha characters plus a revision digit.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#sidstarID"></see></summary>
    let sidstarID = Namespaced_IRI.parse _namespace_name "sidstarID" |> NamespacedName

    /// <summary>
    /// The beginning of the hour stored as a datetime value.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#startingTime"></see></summary>
    let startingTime =
        Namespaced_IRI.parse _namespace_name "startingTime" |> NamespacedName

    /// <summary>
    /// Associates a taxiway with its bounding two-dimensional rectangle.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#taxiwayFootprint"></see></summary>
    let taxiwayFootprint =
        Namespaced_IRI.parse _namespace_name "taxiwayFootprint" |> NamespacedName

    /// <summary>
    /// An identifier for the taxiway.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#taxiwayID"></see></summary>
    let taxiwayID = Namespaced_IRI.parse _namespace_name "taxiwayID" |> NamespacedName
    /// <summary>
    /// The alphanumeric identifier of the airport terminal.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#terminalID"></see></summary>
    let terminalID = Namespaced_IRI.parse _namespace_name "terminalID" |> NamespacedName

    /// <summary>
    /// The maximum number of aircraft permitted in a given sector at any time, per agreement between FAA and Air Traffic Controller union. MAP (Monitor Alert Parameter) is a TFMS input parameter.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#tfmsMonitorAlertParameter"></see></summary>
    let tfmsMonitorAlertParameter =
        Namespaced_IRI.parse _namespace_name "tfmsMonitorAlertParameter" |> NamespacedName

    /// <summary>
    /// The degree number of the ARTCC tier. Tier 1 includes the central ARTCC plus all ARTCCs immediately adjoining the central ARTCC; tier 2 includes tier 1 plus all adjacent ARTCCs two steps away from the central ARTCC. And so on.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#tierLevel"></see></summary>
    let tierLevel = Namespaced_IRI.parse _namespace_name "tierLevel" |> NamespacedName

    /// <summary>
    /// Links to the geographical point location that is the touchdown spot on the operational runway.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#touchdownPoint"></see></summary>
    let touchdownPoint =
        Namespaced_IRI.parse _namespace_name "touchdownPoint" |> NamespacedName

    /// <summary>
    /// The FAA identifier for air traffic control tower.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#towerID"></see></summary>
    let towerID = Namespaced_IRI.parse _namespace_name "towerID" |> NamespacedName

    /// <summary>
    /// Links the airport to the ARTCC within which it is located.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#withinARTCC"></see></summary>
    let withinARTCC =
        Namespaced_IRI.parse _namespace_name "withinARTCC" |> NamespacedName

    /// <summary>
    /// The timezone identifier for the airport, where the timezone is specified as Area/Location, e.g. America/New_York.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/NAS#withinTimezone"></see></summary>
    let withinTimezone =
        Namespaced_IRI.parse _namespace_name "withinTimezone" |> NamespacedName
