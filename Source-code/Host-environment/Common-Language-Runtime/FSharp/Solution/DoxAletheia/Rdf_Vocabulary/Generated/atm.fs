namespace https.data.nasa.gov.ontologies.atmonto.ATM.hash

open DoxAletheia.Rdf_Vocabulary

module atm =
    let _namespace_name = "https://data.nasa.gov/ontologies/atmonto/ATM#"

    /// <summary>
    /// A fix based on some established global measuring scheme.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#AbsoluteFix"></see></summary>
    let AbsoluteFix =
        Namespaced_IRI.parse _namespace_name "AbsoluteFix" |> NamespacedName

    /// <summary>
    /// A designated point on the surface of the earth used for aeronautical navigation.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#NavigationFix"></see></summary>
    let NavigationFix =
        Namespaced_IRI.parse _namespace_name "NavigationFix" |> NamespacedName

    /// <summary>
    /// A flight trajectory (i.e., a sequence of track points), as determined by flight track surveillance data.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#ActualFlightRoute"></see></summary>
    let ActualFlightRoute =
        Namespaced_IRI.parse _namespace_name "ActualFlightRoute" |> NamespacedName

    /// <summary>
    /// A point during a flight where various flight parameters are captured and sent (via transponder) to FAA computers.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#AircraftTrackPoint"></see></summary>
    let AircraftTrackPoint =
        Namespaced_IRI.parse _namespace_name "AircraftTrackPoint" |> NamespacedName

    /// <summary>
    /// A subclass of interval-based data representing the maximum number of controllable aircraft flowing through an airspace region during some interval of time.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#AircraftCapacity"></see></summary>
    let AircraftCapacity =
        Namespaced_IRI.parse _namespace_name "AircraftCapacity" |> NamespacedName

    /// <summary>
    /// A subclass of interval-based data representing the maximum controllable number of aircraft flowing through an airspace region during some interval of time, given weather and other air traffic control constraints.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#AircraftFlowCapacity"></see></summary>
    let AircraftFlowCapacity =
        Namespaced_IRI.parse _namespace_name "AircraftFlowCapacity" |> NamespacedName

    /// <summary>
    /// A subclass of interval-based data representing the number of aircraft flowing through an airspace region during some interval of time.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#AircraftFlow"></see></summary>
    let AircraftFlow =
        Namespaced_IRI.parse _namespace_name "AircraftFlow" |> NamespacedName

    /// <summary>
    /// A subclass of navigation fix corresponding to fixes associated directly with a ground reference point that is an airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#AirportFix"></see></summary>
    let AirportFix = Namespaced_IRI.parse _namespace_name "AirportFix" |> NamespacedName
    /// <summary>
    /// A fix based on the location of a ground-based VOR (VHF Omni Directional Radio Range) installation.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#VORfix"></see></summary>
    let VORfix = Namespaced_IRI.parse _namespace_name "VORfix" |> NamespacedName

    /// <summary>
    /// A specification of a set of airports.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#AirportSpec"></see></summary>
    let AirportSpec =
        Namespaced_IRI.parse _namespace_name "AirportSpec" |> NamespacedName

    /// <summary>
    /// Indicates which type of airports are included in the set of airports covered by this airport specification: all, US, CONUS, NonCONUS, International, Canadian. This property allows for the implicit specification of an entire class of airports; the property atm:includesAirport allows for the explicit specification of a list of specific airports.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#includesAirportType"></see></summary>
    let includesAirportType =
        Namespaced_IRI.parse _namespace_name "includesAirportType" |> NamespacedName

    /// <summary>
    /// A subclass of Traffic Management Initiative involving control and metering of air traffic through specified airspace volumes.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#AirspaceFlowProgramTMI"></see></summary>
    let AirspaceFlowProgramTMI =
        Namespaced_IRI.parse _namespace_name "AirspaceFlowProgramTMI" |> NamespacedName

    /// <summary>
    /// A Traffic Management Initiative (TMI) is an orchestrated air traffic management procedure implemented as needed to control the flow of air traffic in the NAS based on capacity and demand.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#TrafficManagementInitiative"></see></summary>
    let TrafficManagementInitiative =
        Namespaced_IRI.parse _namespace_name "TrafficManagementInitiative" |> NamespacedName

    /// <summary>
    /// A contiguous portion of an existing airspace route.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#AirspaceRouteSegment"></see></summary>
    let AirspaceRouteSegment =
        Namespaced_IRI.parse _namespace_name "AirspaceRouteSegment" |> NamespacedName

    /// <summary>
    /// A contiguous portion of an existing navigation path.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#NavigationSubPath"></see></summary>
    let NavigationSubPath =
        Namespaced_IRI.parse _namespace_name "NavigationSubPath" |> NamespacedName

    /// <summary>
    /// The set of inflight airline personnel operating or performing servicing functions on a flight (pilots and cabin attendants).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#CrewMember"></see></summary>
    let CrewMember = Namespaced_IRI.parse _namespace_name "CrewMember" |> NamespacedName
    /// <summary>
    /// This class represents a computational delay model used in assigning times to the aircraft involved in the GDP or GS. The properties of this class correspond to parameters that are used by the delay model to compute the delay times.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#DelayModel"></see></summary>
    let DelayModel = Namespaced_IRI.parse _namespace_name "DelayModel" |> NamespacedName

    /// <summary>
    /// The type of delay assignment mode specified for this delay model: DAS, GAAP, or UDP.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#delayAssignmentMode"></see></summary>
    let delayAssignmentMode =
        Namespaced_IRI.parse _namespace_name "delayAssignmentMode" |> NamespacedName

    /// <summary>
    /// A Fix Radial Distance (FRD) fix is located a specified distance from a ground-based navaid, a named fix, or an airport, along a given radial vector.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#FRDfix"></see></summary>
    let FRDfix = Namespaced_IRI.parse _namespace_name "FRDfix" |> NamespacedName

    /// <summary>
    /// A fix defined in relation to another fix.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#RelativeFix"></see></summary>
    let RelativeFix =
        Namespaced_IRI.parse _namespace_name "RelativeFix" |> NamespacedName

    /// <summary>
    /// A single flight segment from origin to destination.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#Flight"></see></summary>
    let Flight = Namespaced_IRI.parse _namespace_name "Flight" |> NamespacedName

    /// <summary>
    /// The type of airspace user that this flight represents: GA, Air Taxi, Cargo, Commercial, Military. Also used to constrain a flight specification to contain only flights representing a specific user category.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#userCategory"></see></summary>
    let userCategory =
        Namespaced_IRI.parse _namespace_name "userCategory" |> NamespacedName

    /// <summary>
    /// A contiguous portion of a complete flight plan.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#FlightPlanSegment"></see></summary>
    let FlightPlanSegment =
        Namespaced_IRI.parse _namespace_name "FlightPlanSegment" |> NamespacedName

    /// <summary>
    /// A planned flight route is an ordered sequence of navigation elements that the pilot intends to traverse en route from origin to destination airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#PlannedFlightRoute"></see></summary>
    let PlannedFlightRoute =
        Namespaced_IRI.parse _namespace_name "PlannedFlightRoute" |> NamespacedName

    /// <summary>
    /// A specification describing a set of flights.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#FlightSpec"></see></summary>
    let FlightSpec = Namespaced_IRI.parse _namespace_name "FlightSpec" |> NamespacedName

    /// <summary>
    /// Specifies the type of flight time being constrained in this flight specification: either ETA (estimated arrival time) or ETD (estimated departure time).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#timeConstraintType"></see></summary>
    let timeConstraintType =
        Namespaced_IRI.parse _namespace_name "timeConstraintType" |> NamespacedName

    /// <summary>
    /// Indicates which class of aircraft the flights defined by this specification must employ: jet, prop, jet and prop, turbo, all.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#includesAircraftClass"></see></summary>
    let includesAircraftClass =
        Namespaced_IRI.parse _namespace_name "includesAircraftClass" |> NamespacedName

    /// <summary>
    /// Indicates the weight category as part of a flight specification constraint.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#aircraftWeightCat"></see></summary>
    let aircraftWeightCat =
        Namespaced_IRI.parse _namespace_name "aircraftWeightCat" |> NamespacedName

    /// <summary>
    /// This model provides parameters to the code that assigns times to the aircraft involved in the GDP or GS
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#GDPmodel"></see></summary>
    let GDPmodel = Namespaced_IRI.parse _namespace_name "GDPmodel" |> NamespacedName
    /// <summary>
    /// A navigation fix defined by GPS coordinates.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#GPSfix"></see></summary>
    let GPSfix = Namespaced_IRI.parse _namespace_name "GPSfix" |> NamespacedName
    /// <summary>
    /// A navigation fix based on latitude/longitude coordinates.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#LatLonFix"></see></summary>
    let LatLonFix = Namespaced_IRI.parse _namespace_name "LatLonFix" |> NamespacedName

    /// <summary>
    /// A Ground Delay Program (GDP) traffic management initiative (TMI). A Ground Delay Program (GDP) is a traffic management procedure where aircraft are delayed at their departure airport in order to manage demand and capacity at their arrival airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#GroundDelayProgramTMI"></see></summary>
    let GroundDelayProgramTMI =
        Namespaced_IRI.parse _namespace_name "GroundDelayProgramTMI" |> NamespacedName

    /// <summary>
    /// Links a traffic management initiative (TMI) to the airspace element being controlled by the TMI (e.g., an airport).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#controlledNASelement"></see></summary>
    let controlledNASelement =
        Namespaced_IRI.parse _namespace_name "controlledNASelement" |> NamespacedName

    /// <summary>
    /// Indicates the reason for initiating the Ground Delay Program: weather, volume, runway, equipment, other.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#impactingCondition"></see></summary>
    let impactingCondition =
        Namespaced_IRI.parse _namespace_name "impactingCondition" |> NamespacedName

    /// <summary>
    /// A Ground Stop (GS) traffic management initiative (TMI). A ground stop is a procedure requiring aircraft that meet specific criteria to remain on the ground. The GS may be airport specific, related to a geographical area, or equipment related.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#GroundStopTMI"></see></summary>
    let GroundStopTMI =
        Namespaced_IRI.parse _namespace_name "GroundStopTMI" |> NamespacedName

    /// <summary>
    /// The probability that this traffic management initiative (TMI) will be extended: LOW, MEDIUM, or HIGH.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#extensionProbability"></see></summary>
    let extensionProbability =
        Namespaced_IRI.parse _namespace_name "extensionProbability" |> NamespacedName

    /// <summary>
    /// A navigation fix defined by the intersection of two airspace routes.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#IntersectionFix"></see></summary>
    let IntersectionFix =
        Namespaced_IRI.parse _namespace_name "IntersectionFix" |> NamespacedName

    /// <summary>
    /// A fix defined as an point in the terminal airspace through which flights are metered by air traffic control on approach.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#MeterFix"></see></summary>
    let MeterFix = Namespaced_IRI.parse _namespace_name "MeterFix" |> NamespacedName

    /// <summary>
    /// A Miles-in-Trail (MIT) traffic management initiative (TMI) is used to apportion traffic into a manageable flow, as well as provide space for additional traffic (merging or departing) to enter the flow of traffic. Miles-in-trail describes the number of miles required between aircraft departing an airport, over a fix, at an altitude, through a sector, or on a specific route.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#MilesInTrailTMI"></see></summary>
    let MilesInTrailTMI =
        Namespaced_IRI.parse _namespace_name "MilesInTrailTMI" |> NamespacedName

    /// <summary>
    /// A fix based on the location of a ground-based non-directional radio beacon (NDB) installation. NDB signals follow the curvature of the Earth, so they can be received at much greater distances at lower altitudes, a major advantage over VOR. However, NDB signals are also affected more by atmospheric conditions, mountainous terrain, coastal refraction and electrical storms, particularly at long range.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#NDBfix"></see></summary>
    let NDBfix = Namespaced_IRI.parse _namespace_name "NDBfix" |> NamespacedName
    /// <summary>
    /// A fix based on the location of a ground-based Navigation Aid (Navaid) installation.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#NavaidFix"></see></summary>
    let NavaidFix = Namespaced_IRI.parse _namespace_name "NavaidFix" |> NamespacedName
    /// <summary>
    /// The NRS is a system of waypoints developed for use within the United States for flight planning and navigation without reference to ground based navigational aids. The NRS waypoints are located in a grid pattern along defined latitude and longitude lines. NRS waypoint names are composed of two letters followed by two numbers, followed by a single letter. The first and second characters of NRS waypoints are the FIR identifier for the United States (“K”) and the FIR subdivision, or ARTCC center in which the waypoint is located (e.g. “D” for Denver ARTCC). The third and fourth characters are a number group representing the latitude of the waypoint. These numbers begin at the equator with 00 and advances north and south from 01 to 90 and correspond to every 10 minutes of latitude and repeating every 15°. The final character in the NRS waypoint is a letter representing the line of longitude for which the waypoint is located. This identifier starts at the prime meridian moving west to east and uses the letters A to Z while repeating every 26°. To date, the current density of the NRS grid is one waypoint spaced every 30 minutes of latitude and every 2° of longitude.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#NRSfix"></see></summary>
    let NRSfix = Namespaced_IRI.parse _namespace_name "NRSfix" |> NamespacedName

    /// <summary>
    /// A navigation element container is a wrapper around an existing navigation element, such as a fix or a route. These containers can be sequenced together to represent flight paths and flight trajectories.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#NavElementContainer"></see></summary>
    let NavElementContainer =
        Namespaced_IRI.parse _namespace_name "NavElementContainer" |> NamespacedName

    /// <summary>
    /// A navigation element is a set of components that can be used to assemble a flight plan or trajectory. They include fixes, routes, airports, SID/STAR traverses, etc.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#NavigationElement"></see></summary>
    let NavigationElement =
        Namespaced_IRI.parse _namespace_name "NavigationElement" |> NamespacedName

    /// <summary>
    /// Any NAS entity that is potentially controlled via a TFM initiative.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#TFMcontrolElement"></see></summary>
    let TFMcontrolElement =
        Namespaced_IRI.parse _namespace_name "TFMcontrolElement" |> NamespacedName

    /// <summary>
    /// An ordered sequence of navigation elements (fixes, routes, airports) representing a path through the airspace.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#NavigationPath"></see></summary>
    let NavigationPath =
        Namespaced_IRI.parse _namespace_name "NavigationPath" |> NamespacedName

    /// <summary>
    /// A wrapper around a numeric parameter. Containers can be sequenced to create an ordered list of numeric parameters.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#NumericParameterContainer"></see></summary>
    let NumericParameterContainer =
        Namespaced_IRI.parse _namespace_name "NumericParameterContainer" |> NamespacedName

    /// <summary>
    /// Factor to account for late-filing flights when modeling delays as part of a traffic management initiative (TMI) design process.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#PopupFactor"></see></summary>
    let PopupFactor =
        Namespaced_IRI.parse _namespace_name "PopupFactor" |> NamespacedName

    /// <summary>
    /// A wrapper around a popup factor parameter. Used to sequence popup factors in the specification of a Ground Delay Program (GDP).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#PopupFactorContainer"></see></summary>
    let PopupFactorContainer =
        Namespaced_IRI.parse _namespace_name "PopupFactorContainer" |> NamespacedName

    /// <summary>
    /// Links a container for a numerical parameter to the numerical parameter contained.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#hasNumericParameter"></see></summary>
    let hasNumericParameter =
        Namespaced_IRI.parse _namespace_name "hasNumericParameter" |> NamespacedName

    /// <summary>
    /// An ordered sequence of hourly popup factors used in specifying a Ground Delay Program (GDP).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#PopupFactorSequence"></see></summary>
    let PopupFactorSequence =
        Namespaced_IRI.parse _namespace_name "PopupFactorSequence" |> NamespacedName

    /// <summary>
    /// The number of aircraft that the Ground Delay Program (GDP) is to provide to the airport for a given hour.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#ProgramArrivalRate"></see></summary>
    let ProgramArrivalRate =
        Namespaced_IRI.parse _namespace_name "ProgramArrivalRate" |> NamespacedName

    /// <summary>
    /// A wrapper around a program arrival rate, used to sequence them into an ordered list.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#ProgramArrivalRateContainer"></see></summary>
    let ProgramArrivalRateContainer =
        Namespaced_IRI.parse _namespace_name "ProgramArrivalRateContainer" |> NamespacedName

    /// <summary>
    /// An ordered sequence of hourly program arrival rates used in specifying a Ground Dela Program (GDP).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#ProgramArrivalRateSequence"></see></summary>
    let ProgramArrivalRateSequence =
        Namespaced_IRI.parse _namespace_name "ProgramArrivalRateSequence" |> NamespacedName

    /// <summary>
    /// One of the route segment alternatives specified as part of a ReRoute traffic management initiative (TMI).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#ReRouteSegment"></see></summary>
    let ReRouteSegment =
        Namespaced_IRI.parse _namespace_name "ReRouteSegment" |> NamespacedName

    /// <summary>
    /// Indicates which type of ReRoute segment: origin , destination, origin-destination. A ReRoute segment can be a entire route between origin and destination, or a partial route leading from an origin or leading to a destination.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#reRouteSegmentType"></see></summary>
    let reRouteSegmentType =
        Namespaced_IRI.parse _namespace_name "reRouteSegmentType" |> NamespacedName

    /// <summary>
    /// A ReRoute is a traffic management initiative (TMI) that mandates a change in the filed flight plan for a set of specified flights. There are multiple factors that might justify a reroute, including weather, traffic congestion, unusual airspace activity, etc. The substitute flight plans route air traffic around the airspace problem area.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#ReRouteTMI"></see></summary>
    let ReRouteTMI = Namespaced_IRI.parse _namespace_name "ReRouteTMI" |> NamespacedName

    /// <summary>
    /// The ReRoute type encodes information about the type of ReRoute being initiated or the reason for the ReRoute. One of the following: ROUTE , PLAYBOOK , CDR, SPECIAL OPERATIONS, NRP SUSPENSIONS, VS , NAT, SHUTTLE ACTIVITY, FCA, FEA, INFORMATIONAL, MISCELLANEOUS.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#reRouteType"></see></summary>
    let reRouteType =
        Namespaced_IRI.parse _namespace_name "reRouteType" |> NamespacedName

    /// <summary>
    /// Provides the reason for initiating a ReRoute: WEATHER , VOLUME , EQUIPMENT , RUNWAY/TAXIWAY , OTHER.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#reRouteReason"></see></summary>
    let reRouteReason =
        Namespaced_IRI.parse _namespace_name "reRouteReason" |> NamespacedName

    /// <summary>
    /// Indicates the enforcement status of the ReRoute advisory: RQD (required), RMD (recommended), PLN (planned for implementation), FYI (informational only)
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#implementationStatus"></see></summary>
    let implementationStatus =
        Namespaced_IRI.parse _namespace_name "implementationStatus" |> NamespacedName

    /// <summary>
    /// The time period associated with the reroute is specified in one of three ways. The reroute can apply to flights that: depart specified airports or centers during a certain time window (timeType=ETD); depart specified airports or centers to arrive at their destinations during a certain time window (timeType=ETA); or arrive at the boundary of a flow constrained area during a certain time window (timeType=FCA Flight List).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#reRouteTimeType"></see></summary>
    let reRouteTimeType =
        Namespaced_IRI.parse _namespace_name "reRouteTimeType" |> NamespacedName

    /// <summary>
    /// A route through a SID (Standard Instrument Departure route) or a STAR (Standard Arrival Route), traversing a common route at minimum and optionally a transition route and/or an airport route.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#SIDSTARtraverse"></see></summary>
    let SIDSTARtraverse =
        Namespaced_IRI.parse _namespace_name "SIDSTARtraverse" |> NamespacedName

    /// <summary>
    /// A fix based on the location of a ground-based TACAN (TACtical Air Navigation) installation.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#TACANfix"></see></summary>
    let TACANfix = Namespaced_IRI.parse _namespace_name "TACANfix" |> NamespacedName
    /// <summary>
    /// A sequence of taxiways followed by an aircraft taxiing en route to/from a runway.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#Taxipath"></see></summary>
    let Taxipath = Namespaced_IRI.parse _namespace_name "Taxipath" |> NamespacedName

    /// <summary>
    /// Links a flight with the day on which the flight arrives. This is the day determined by surveillance data sources to be the 'actual' day of arrival, versus the scheduled day or the day specified in the flight plan, etc.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#actualArrivalDay"></see></summary>
    let actualArrivalDay =
        Namespaced_IRI.parse _namespace_name "actualArrivalDay" |> NamespacedName

    /// <summary>
    /// The time determined by surveillance data sources to be the 'actual' time of flight arrival, versus the scheduled time or the time specified in the flight plan, etc.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#actualArrivalTime"></see></summary>
    let actualArrivalTime =
        Namespaced_IRI.parse _namespace_name "actualArrivalTime" |> NamespacedName

    /// <summary>
    /// Links a flight with the day on which the flight departs. This is the day determined by surveillance data sources to be the 'actual' day of departure, versus the scheduled day or the day specified in the flight plan, etc.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#actualDepartureDay"></see></summary>
    let actualDepartureDay =
        Namespaced_IRI.parse _namespace_name "actualDepartureDay" |> NamespacedName

    /// <summary>
    /// The time determined by surveillance data sources to be the 'actual' time of flight departure, versus the scheduled time or the time specified in the flight plan, etc.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#actualDepartureTime"></see></summary>
    let actualDepartureTime =
        Namespaced_IRI.parse _namespace_name "actualDepartureTime" |> NamespacedName

    /// <summary>
    /// Links a delay model to the day that the ADL (Aggregate Demand List) was generated. Each ADL contains information on the flights arriving and departing from an airport, or entering into and departing from a flow area.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#adlDay"></see></summary>
    let adlDay = Namespaced_IRI.parse _namespace_name "adlDay" |> NamespacedName
    /// <summary>
    /// The timestamp of the ADL (Aggregate Demand List) that the delay model is based upon. Each ADL contains information on the flights arriving and departing from an airport, or entering into and departing from a flow area.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#adlTime"></see></summary>
    let adlTime = Namespaced_IRI.parse _namespace_name "adlTime" |> NamespacedName
    /// <summary>
    /// The unique identifier of the ADS-B (Automatic Dependent Surveillance - Broadcast) transponder unit on board the aircraft for this flight.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#adsbID"></see></summary>
    let adsbID = Namespaced_IRI.parse _namespace_name "adsbID" |> NamespacedName

    /// <summary>
    /// Advisory number as reported from the FAA Command Center database. it restarts at 001 on every new day UTC.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#advisoryNumber"></see></summary>
    let advisoryNumber =
        Namespaced_IRI.parse _namespace_name "advisoryNumber" |> NamespacedName

    /// <summary>
    /// The number of aircraft flowing through an airspace region per some interval of time.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#aircraftCount"></see></summary>
    let aircraftCount =
        Namespaced_IRI.parse _namespace_name "aircraftCount" |> NamespacedName

    /// <summary>
    /// Links an aircraft track point with its associated navigation fix.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#aircraftFix"></see></summary>
    let aircraftFix =
        Namespaced_IRI.parse _namespace_name "aircraftFix" |> NamespacedName

    /// <summary>
    /// Links a flight with the actual aircraft used.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#aircraftFlown"></see></summary>
    let aircraftFlown =
        Namespaced_IRI.parse _namespace_name "aircraftFlown" |> NamespacedName

    /// <summary>
    /// Links a flight with the type of aircraft flown. The aircraft 'type' corresponds to a set of aircraft models with similar characteristics.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#aircraftTypeFlown"></see></summary>
    let aircraftTypeFlown =
        Namespaced_IRI.parse _namespace_name "aircraftTypeFlown" |> NamespacedName

    /// <summary>
    /// In a reRoute traffic management initiative, there are multiple allowed routes specified between origin and destination. This property links a ReRouteTMI with its allowed routes.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#allowedRoute"></see></summary>
    let allowedRoute =
        Namespaced_IRI.parse _namespace_name "allowedRoute" |> NamespacedName

    /// <summary>
    /// Links to the alternate arrival airport to be used in case of weather, traffic, or other unforseen contingency. The alternate airport is specified in the flight plan.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#alternateArrivalAirport"></see></summary>
    let alternateArrivalAirport =
        Namespaced_IRI.parse _namespace_name "alternateArrivalAirport" |> NamespacedName

    /// <summary>
    /// Links to the actual arrival airport for the flight.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#arrivalAirport"></see></summary>
    let arrivalAirport =
        Namespaced_IRI.parse _namespace_name "arrivalAirport" |> NamespacedName

    /// <summary>
    /// Links to the actual arrival runway for the flight.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#arrivalRunway"></see></summary>
    let arrivalRunway =
        Namespaced_IRI.parse _namespace_name "arrivalRunway" |> NamespacedName

    /// <summary>
    /// Links to the taxipath followed by the flight en route to the gate.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#arrivalTaxiPath"></see></summary>
    let arrivalTaxiPath =
        Namespaced_IRI.parse _namespace_name "arrivalTaxiPath" |> NamespacedName

    /// <summary>
    /// The flight identifier (3-letter ICAO code plus number).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#callSign"></see></summary>
    let callSign = Namespaced_IRI.parse _namespace_name "callSign" |> NamespacedName

    /// <summary>
    /// The cruising altitude (in number of feet) specified in the flight plan for this flight.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#cruisingAltitude"></see></summary>
    let cruisingAltitude =
        Namespaced_IRI.parse _namespace_name "cruisingAltitude" |> NamespacedName

    /// <summary>
    /// Links to the actual departure airport for the flight.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#departureAirport"></see></summary>
    let departureAirport =
        Namespaced_IRI.parse _namespace_name "departureAirport" |> NamespacedName

    /// <summary>
    /// Links to the actual departure runway for the flight.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#departureRunway"></see></summary>
    let departureRunway =
        Namespaced_IRI.parse _namespace_name "departureRunway" |> NamespacedName

    /// <summary>
    /// Links a Ground Delay Program (GDP) or a Ground Stop (GS) to a specification of the departure airport(s) participating in the traffic management initiative (TMI).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#departureScope"></see></summary>
    let departureScope =
        Namespaced_IRI.parse _namespace_name "departureScope" |> NamespacedName

    /// <summary>
    /// Links to the taxipath followed by the flight en route to the runway.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#departureTaxiPath"></see></summary>
    let departureTaxiPath =
        Namespaced_IRI.parse _namespace_name "departureTaxiPath" |> NamespacedName

    /// <summary>
    /// Links to the expected ending day of the traffic management initiative (TMI).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#effectiveEndDay"></see></summary>
    let effectiveEndDay =
        Namespaced_IRI.parse _namespace_name "effectiveEndDay" |> NamespacedName

    /// <summary>
    /// The expected end time of the traffic management initiative (TMI).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#effectiveEndTime"></see></summary>
    let effectiveEndTime =
        Namespaced_IRI.parse _namespace_name "effectiveEndTime" |> NamespacedName

    /// <summary>
    /// Links to the expected starting day of the traffic management initiative (TMI).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#effectiveStartDay"></see></summary>
    let effectiveStartDay =
        Namespaced_IRI.parse _namespace_name "effectiveStartDay" |> NamespacedName

    /// <summary>
    /// The expected start time of the traffic management initiative (TMI).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#effectiveStartTime"></see></summary>
    let effectiveStartTime =
        Namespaced_IRI.parse _namespace_name "effectiveStartTime" |> NamespacedName

    /// <summary>
    /// Links an airport specification to one of more ARTCCs (Centers) or ARTCC tiers (Centers radiating out from a give ARTCC). Any airport within the ARTCC or ARTCC tier is excluded from the set of airports covered by this airport specification.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#excludesARTCC"></see></summary>
    let excludesARTCC =
        Namespaced_IRI.parse _namespace_name "excludesARTCC" |> NamespacedName

    /// <summary>
    /// Links an airport specification to one of more airports. Any airport linked is excluded from the set of airports covered by this airport specification.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#excludesAirport"></see></summary>
    let excludesAirport =
        Namespaced_IRI.parse _namespace_name "excludesAirport" |> NamespacedName

    /// <summary>
    /// Links a flight specification to one of more airways (routes). Any flight that traverses a linked airway is excluded from the set of flights covered by this flight specification.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#excludesAirway"></see></summary>
    let excludesAirway =
        Namespaced_IRI.parse _namespace_name "excludesAirway" |> NamespacedName

    /// <summary>
    /// Links a flight specification to one of more navigation fixes. Any flight that traverses a linked fix is excluded from the set of flights covered by this flight specification.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#excludesFix"></see></summary>
    let excludesFix =
        Namespaced_IRI.parse _namespace_name "excludesFix" |> NamespacedName

    /// <summary>
    /// Links a flight specification to one of more flights. Any linked flight is excluded from the set of flights covered by this flight specification.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#excludesFlight"></see></summary>
    let excludesFlight =
        Namespaced_IRI.parse _namespace_name "excludesFlight" |> NamespacedName

    /// <summary>
    /// Links a flight specification to one of more Airspace Flow Program (AFP) traffic management initiatives (TMIs). Any flight included in one of the linked AFPs is excluded from the set of flights covered by this flight specification.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#exemptedAFP"></see></summary>
    let exemptedAFP =
        Namespaced_IRI.parse _namespace_name "exemptedAFP" |> NamespacedName

    /// <summary>
    /// A non-unique FAA identifier for a fix. When combined with a fix ICAO code, it defines a unique fix worldwide. Often, but not always, the fixId is identical to the fixName.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#fixId"></see></summary>
    let fixId = Namespaced_IRI.parse _namespace_name "fixId" |> NamespacedName
    /// <summary>
    /// A unique FAA identier for a fix that can be filed as part of a flight plan. The fix name conceptually represents the worldwide-unique combination of a FixID and ICAO code. Often, but not always, the fixId is identical to the fixName.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#fixName"></see></summary>
    let fixName = Namespaced_IRI.parse _namespace_name "fixName" |> NamespacedName

    /// <summary>
    /// This is an experimental property of a flight that stores an ordered sequence of named fixes corresponding one-to-one to the sequence of trajectory track points recorded for the flight. For a given track point, the corresponding named fix is computed by finding the closest named fix to the track point.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#fixTrajectoryString"></see></summary>
    let fixTrajectoryString =
        Namespaced_IRI.parse _namespace_name "fixTrajectoryString" |> NamespacedName

    /// <summary>
    /// Links a Ground Delay Program (GDP) or a Ground Stop (GS) to a specification of the flight(s) excluded from the traffic management initiative (TMI).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#flightExclusionSpec"></see></summary>
    let flightExclusionSpec =
        Namespaced_IRI.parse _namespace_name "flightExclusionSpec" |> NamespacedName

    /// <summary>
    /// Links a ReRoute to a specification of the flight(s) included in or excluded from the ReRoute traffic management initiative (TMI).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#flightInclusionExclusion"></see></summary>
    let flightInclusionExclusion =
        Namespaced_IRI.parse _namespace_name "flightInclusionExclusion" |> NamespacedName

    /// <summary>
    /// Links a Ground Delay Program (GDP) or a Ground Stop (GS) to a specification of the flight(s) included in the traffic management initiative (TMI).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#flightInclusionSpec"></see></summary>
    let flightInclusionSpec =
        Namespaced_IRI.parse _namespace_name "flightInclusionSpec" |> NamespacedName

    /// <summary>
    /// The estimated time of arrival specified in the flight plan.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#flightPlanETA"></see></summary>
    let flightPlanETA =
        Namespaced_IRI.parse _namespace_name "flightPlanETA" |> NamespacedName

    /// <summary>
    /// A string that provides the route of flight proposed in a flight plan. Syntactically, the string shows a path of fixes, airways, SIDs, and STARs, separated by either one or two dots. The string is parsed to create an equivalent ontology representation: an ordered sequence of navigation elements that are associated directly with the flight plan (atm:PlannedFlightRoute).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#flightRouteString"></see></summary>
    let flightRouteString =
        Namespaced_IRI.parse _namespace_name "flightRouteString" |> NamespacedName

    /// <summary>
    /// The maximum controllable number of aircraft flowing through an airspace region per some interval of time.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#flowCapacity"></see></summary>
    let flowCapacity =
        Namespaced_IRI.parse _namespace_name "flowCapacity" |> NamespacedName

    /// <summary>
    /// Links an aircraft capacity or aircraft flow to the spatial region through which flow or capacity is being monitored and measured.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#flowMeasurementRegion"></see></summary>
    let flowMeasurementRegion =
        Namespaced_IRI.parse _namespace_name "flowMeasurementRegion" |> NamespacedName

    /// <summary>
    /// The reported ground speed at an aircraft track point.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#groundSpeed"></see></summary>
    let groundSpeed =
        Namespaced_IRI.parse _namespace_name "groundSpeed" |> NamespacedName

    /// <summary>
    /// Links a flight to its actual trajectory (i.e., a sequence of track points), as determined by flight track surveillance data.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#hasActualRoute"></see></summary>
    let hasActualRoute =
        Namespaced_IRI.parse _namespace_name "hasActualRoute" |> NamespacedName

    /// <summary>
    /// Links a flight to its crew members.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#hasCrewMember"></see></summary>
    let hasCrewMember =
        Namespaced_IRI.parse _namespace_name "hasCrewMember" |> NamespacedName

    /// <summary>
    /// Links a container for a navigational element to the element contained.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#hasNavElement"></see></summary>
    let hasNavElement =
        Namespaced_IRI.parse _namespace_name "hasNavElement" |> NamespacedName

    /// <summary>
    /// Links a flight to a version of its flight plan. (Which version gets stored is application-dependent.) There are multiple versions of the flight plan generated and then amended during the course of the flight, starting in the pre-flight timeframe and extending through to the termination of the flight.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#hasPlannedRoute"></see></summary>
    let hasPlannedRoute =
        Namespaced_IRI.parse _namespace_name "hasPlannedRoute" |> NamespacedName

    /// <summary>
    /// The aircraft heading at the track point: a number between 0.01 and 360.0 indicating the angular heading with respect to North.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#heading"></see></summary>
    let heading = Namespaced_IRI.parse _namespace_name "heading" |> NamespacedName

    /// <summary>
    /// A free-text descriptoin elaborating on the reason for initiating the Ground Delay Program.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#impactingConditionMessage"></see></summary>
    let impactingConditionMessage =
        Namespaced_IRI.parse _namespace_name "impactingConditionMessage" |> NamespacedName

    /// <summary>
    /// Links an aircraft flow to a specification of the flights included in the flow.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#includedFlights"></see></summary>
    let includedFlights =
        Namespaced_IRI.parse _namespace_name "includedFlights" |> NamespacedName

    /// <summary>
    /// Links an airport specification to one of more airports. Any airport linked is included in the set of airports covered by this airport specification. This property allows for explicit specification of a list of specific airports; the property atm:includesAirportType allows for the the implicit specification of an entire class of airports.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#includesAirport"></see></summary>
    let includesAirport =
        Namespaced_IRI.parse _namespace_name "includesAirport" |> NamespacedName

    /// <summary>
    /// Links a flight specification to one of more airways (routes). Any flight that traverses a linked airway is included in the set of flights covered by this flight specification.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#includesAirway"></see></summary>
    let includesAirway =
        Namespaced_IRI.parse _namespace_name "includesAirway" |> NamespacedName

    /// <summary>
    /// Links a flight specification to one of more navigation fixes. Any flight that traverses a linked fix is included in the set of flights covered by this flight specification.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#includesFix"></see></summary>
    let includesFix =
        Namespaced_IRI.parse _namespace_name "includesFix" |> NamespacedName

    /// <summary>
    /// Links a flight specification to one of more flights. Any linked flight is included in the set of flights covered by this flight specification.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#includesFlight"></see></summary>
    let includesFlight =
        Namespaced_IRI.parse _namespace_name "includesFlight" |> NamespacedName

    /// <summary>
    /// Provides any specific comments on the traffic management initiative (TMI) made by the issuing authority (e.g., ATCSCC, ARTCC).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#initiativeComments"></see></summary>
    let initiativeComments =
        Namespaced_IRI.parse _namespace_name "initiativeComments" |> NamespacedName

    /// <summary>
    /// Links to the day when the traffic management initiative (TMI) was issued.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#issuedDay"></see></summary>
    let issuedDay = Namespaced_IRI.parse _namespace_name "issuedDay" |> NamespacedName
    /// <summary>
    /// The time when the traffic management initiative (TMI) was issued.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#issuedTime"></see></summary>
    let issuedTime = Namespaced_IRI.parse _namespace_name "issuedTime" |> NamespacedName

    /// <summary>
    /// Links a navigation fix to the airspace sector in which that fix is located.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#locatedInSector"></see></summary>
    let locatedInSector =
        Namespaced_IRI.parse _namespace_name "locatedInSector" |> NamespacedName

    /// <summary>
    /// The absolute maximum controllable number of aircraft flowing through an airspace region per some interval of time under any air traffic conditions.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#maxFlowCapacity"></see></summary>
    let maxFlowCapacity =
        Namespaced_IRI.parse _namespace_name "maxFlowCapacity" |> NamespacedName

    /// <summary>
    /// Links a delay model used in defining a Ground Delay Program (GDP) or Ground Stop(GS) to a sequence of desired hourly aircraft arrival rates specified for the initiative.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#modeledArrivalRate"></see></summary>
    let modeledArrivalRate =
        Namespaced_IRI.parse _namespace_name "modeledArrivalRate" |> NamespacedName

    /// <summary>
    /// The average flight delay specified when modeling a Ground Delay Program (GDP) or Ground Stop(GS).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#modeledAverageDelay"></see></summary>
    let modeledAverageDelay =
        Namespaced_IRI.parse _namespace_name "modeledAverageDelay" |> NamespacedName

    /// <summary>
    /// Links a Ground Delay Program (GDP) or a Ground Stop (GS) to a representation of the model used to design that initiative. The model contains all relevant parameters used to create the initiative.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#modeledBy"></see></summary>
    let modeledBy = Namespaced_IRI.parse _namespace_name "modeledBy" |> NamespacedName

    /// <summary>
    /// The maximum flight delay specified when modeling a Ground Delay Program (GDP) or Ground Stop(GS).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#modeledMaximumDelay"></see></summary>
    let modeledMaximumDelay =
        Namespaced_IRI.parse _namespace_name "modeledMaximumDelay" |> NamespacedName

    /// <summary>
    /// Links a delay model used in defining a Ground Delay Program (GDP) or Ground Stop(GS) to a sequence of desired hourly popup factors specified for the initiative. 'Popups' account for late-filing flights (unexpected/unplanned flights) when modeling delays as part of a traffic management initiative (TMI) design process.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#modeledPopUpFactor"></see></summary>
    let modeledPopUpFactor =
        Namespaced_IRI.parse _namespace_name "modeledPopUpFactor" |> NamespacedName

    /// <summary>
    /// The total flight delay specified when modeling a Ground Delay Program (GDP) or Ground Stop(GS).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#modeledTotalDelay"></see></summary>
    let modeledTotalDelay =
        Namespaced_IRI.parse _namespace_name "modeledTotalDelay" |> NamespacedName

    /// <summary>
    /// Links a flight specification to an airport specification describing the destination airports for the flights being specified. Any flight covered by the flight specification must have as its destination one of the airports covered by the airport specification.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#mustHaveDestination"></see></summary>
    let mustHaveDestination =
        Namespaced_IRI.parse _namespace_name "mustHaveDestination" |> NamespacedName

    /// <summary>
    /// Links a flight specification to an airport specification describing the originating airports for the flights being specified. Any flight covered by the flight specification must have as its origin one of the airports covered by the airport specification.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#mustHaveOrigin"></see></summary>
    let mustHaveOrigin =
        Namespaced_IRI.parse _namespace_name "mustHaveOrigin" |> NamespacedName

    /// <summary>
    /// Links a flight to its carrier airline.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#operatedBy"></see></summary>
    let operatedBy = Namespaced_IRI.parse _namespace_name "operatedBy" |> NamespacedName

    /// <summary>
    /// Links a flight specification to one or more carrier airline(s). Each flight covered by the specification must be operated by one of these carriers.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#operatingCarrier"></see></summary>
    let operatingCarrier =
        Namespaced_IRI.parse _namespace_name "operatingCarrier" |> NamespacedName

    /// <summary>
    /// Links a flight specification to a time interval. Each flight covered by the specification must be airborne sometime during the time period specified by the interval.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#operatingTimeInterval"></see></summary>
    let operatingTimeInterval =
        Namespaced_IRI.parse _namespace_name "operatingTimeInterval" |> NamespacedName

    /// <summary>
    /// Links to the day when the flight plan was filed with the FAA.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#planFilingDay"></see></summary>
    let planFilingDay =
        Namespaced_IRI.parse _namespace_name "planFilingDay" |> NamespacedName

    /// <summary>
    /// The time that the flight plan was filed with the FAA.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#planFilingTime"></see></summary>
    let planFilingTime =
        Namespaced_IRI.parse _namespace_name "planFilingTime" |> NamespacedName

    /// <summary>
    /// Indicates the location of a gap in the flight plan due to non-parsable/uninterpretable elements in the flight plan string.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#planGapAfterSequenceElementNumber"></see></summary>
    let planGapAfterSequenceElementNumber =
        Namespaced_IRI.parse _namespace_name "planGapAfterSequenceElementNumber" |> NamespacedName

    /// <summary>
    /// Links to the day that the flight is planned to arrive per the flight plan.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#plannedArrivalDay"></see></summary>
    let plannedArrivalDay =
        Namespaced_IRI.parse _namespace_name "plannedArrivalDay" |> NamespacedName

    /// <summary>
    /// The time that the flight is planned to arrive per the flight plan.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#plannedArrivalTime"></see></summary>
    let plannedArrivalTime =
        Namespaced_IRI.parse _namespace_name "plannedArrivalTime" |> NamespacedName

    /// <summary>
    /// Links to the day that the flight is planned to depart per the flight plan.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#plannedDepartureDay"></see></summary>
    let plannedDepartureDay =
        Namespaced_IRI.parse _namespace_name "plannedDepartureDay" |> NamespacedName

    /// <summary>
    /// The time that the flight is planned to depart per the flight plan.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#plannedDepartureTime"></see></summary>
    let plannedDepartureTime =
        Namespaced_IRI.parse _namespace_name "plannedDepartureTime" |> NamespacedName

    /// <summary>
    /// The average flight delay experienced prior to the start of a Ground Stop(GS).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#prevAverageDelay"></see></summary>
    let prevAverageDelay =
        Namespaced_IRI.parse _namespace_name "prevAverageDelay" |> NamespacedName

    /// <summary>
    /// The maximum flight delay experienced prior to the start of a Ground Stop(GS).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#prevMaximumDelay"></see></summary>
    let prevMaximumDelay =
        Namespaced_IRI.parse _namespace_name "prevMaximumDelay" |> NamespacedName

    /// <summary>
    /// The total flight delay experienced prior to the start of a Ground Stop(GS).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#prevTotalDelay"></see></summary>
    let prevTotalDelay =
        Namespaced_IRI.parse _namespace_name "prevTotalDelay" |> NamespacedName

    /// <summary>
    /// Links to the day that the flight is planned to arrive per the OAG schedule.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#publishedArrivalDay"></see></summary>
    let publishedArrivalDay =
        Namespaced_IRI.parse _namespace_name "publishedArrivalDay" |> NamespacedName

    /// <summary>
    /// The time that the flight is planned to arrive per the OAG schedule.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#publishedArrivalTime"></see></summary>
    let publishedArrivalTime =
        Namespaced_IRI.parse _namespace_name "publishedArrivalTime" |> NamespacedName

    /// <summary>
    /// Links to the day that the flight is planned to depart per the OAG schedule.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#publishedDepartureDay"></see></summary>
    let publishedDepartureDay =
        Namespaced_IRI.parse _namespace_name "publishedDepartureDay" |> NamespacedName

    /// <summary>
    /// The time that the flight is planned to depart per the OAG schedule.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#publishedDepartureTime"></see></summary>
    let publishedDepartureTime =
        Namespaced_IRI.parse _namespace_name "publishedDepartureTime" |> NamespacedName

    /// <summary>
    /// The angle (in degrees) that defines the radial route's angular position with respect to the defined fix.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#radialAngle"></see></summary>
    let radialAngle =
        Namespaced_IRI.parse _namespace_name "radialAngle" |> NamespacedName

    /// <summary>
    /// Links to the fix through which the radial route passes.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#radialFix"></see></summary>
    let radialFix = Namespaced_IRI.parse _namespace_name "radialFix" |> NamespacedName

    /// <summary>
    /// Links a route segment specified as part of a ReRoute traffic management initiative (TMI) to a flight specification indicating which flights are permitted to follow the route segment.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#reRouteConstraint"></see></summary>
    let reRouteConstraint =
        Namespaced_IRI.parse _namespace_name "reRouteConstraint" |> NamespacedName

    /// <summary>
    /// Links a route segment alternative (specified as part of a ReRoute traffic management initiative) to its associated flight plan.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#reRoutePath"></see></summary>
    let reRoutePath =
        Namespaced_IRI.parse _namespace_name "reRoutePath" |> NamespacedName

    /// <summary>
    /// Links a relative fix to the absolute fix that serves as the basis for its location. (A relative fix position is defined relative to an absolute fix position, e.g. as a vector offset from the absolute fix.)
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#referenceFix"></see></summary>
    let referenceFix =
        Namespaced_IRI.parse _namespace_name "referenceFix" |> NamespacedName

    /// <summary>
    /// The angular direction in degrees (1-360) of a relative fix with respect to its defining absolute fix.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#relativeAngle"></see></summary>
    let relativeAngle =
        Namespaced_IRI.parse _namespace_name "relativeAngle" |> NamespacedName

    /// <summary>
    /// The distance (in nautical miles) between a relative fix and its defining (absolute) fix.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#relativeDistance"></see></summary>
    let relativeDistance =
        Namespaced_IRI.parse _namespace_name "relativeDistance" |> NamespacedName

    /// <summary>
    /// A link between an aircraft track point and the day during which an en route aircraft traversed that point and reported its position, speed, and heading.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#reportingDay"></see></summary>
    let reportingDay =
        Namespaced_IRI.parse _namespace_name "reportingDay" |> NamespacedName

    /// <summary>
    /// The time when an en route aircraft passed through a trackpoint and reported its position, speed, and heading.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#reportingTime"></see></summary>
    let reportingTime =
        Namespaced_IRI.parse _namespace_name "reportingTime" |> NamespacedName

    /// <summary>
    /// Three letter FAA TRACON identifier code.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#traconID"></see></summary>
    let traconID = Namespaced_IRI.parse _namespace_name "traconID" |> NamespacedName

    /// <summary>
    /// Links a SIDSTARtraverse (i.e., a specific route through a SID or STAR) to the specific SID or STAR being traversed by a given flight.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#traversesSIDSTAR"></see></summary>
    let traversesSIDSTAR =
        Namespaced_IRI.parse _namespace_name "traversesSIDSTAR" |> NamespacedName

    /// <summary>
    /// The true airspeed of a flight: the speed of the aircraft relative to the airmass in which it is flying.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#trueAirspeed"></see></summary>
    let trueAirspeed =
        Namespaced_IRI.parse _namespace_name "trueAirspeed" |> NamespacedName

    /// <summary>
    /// Links a SIDSTARtraverse (a path through a SID/STAR) to the airport route used in making the traverse.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#usesAirportRoute"></see></summary>
    let usesAirportRoute =
        Namespaced_IRI.parse _namespace_name "usesAirportRoute" |> NamespacedName

    /// <summary>
    /// Links a SIDSTARtraverse (a path through a SID/STAR) to the transition route used in making the traverse.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#usesTransitionRoute"></see></summary>
    let usesTransitionRoute =
        Namespaced_IRI.parse _namespace_name "usesTransitionRoute" |> NamespacedName

    /// <summary>
    /// Links an airport specification to an ARTCC or ARTCC tier. Only airports within the ARTCC or ARTCC tier are covered by the specification.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#withinARTCC"></see></summary>
    let withinARTCC =
        Namespaced_IRI.parse _namespace_name "withinARTCC" |> NamespacedName

    /// <summary>
    /// Links an airport specification to a circular geographic region. Only airports whose locations fall within this region satisfy the specification.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/ATM#withinAirportBoundingRegion"></see></summary>
    let withinAirportBoundingRegion =
        Namespaced_IRI.parse _namespace_name "withinAirportBoundingRegion" |> NamespacedName
