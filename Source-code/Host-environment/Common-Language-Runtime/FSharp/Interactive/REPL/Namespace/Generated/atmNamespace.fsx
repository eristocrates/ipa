#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module atm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://data.nasa.gov/ontologies/atmonto/ATM#" "atm"

    /// <summary>
    ///   <para>rdfs:label : Absolute fix^^xsd:string</para>
    ///   <para>rdfs:comment : A fix based on some established global measuring scheme.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#AbsoluteFix">atm:AbsoluteFix</a>
    /// </summary>
    let AbsoluteFix = _prefixId.prefix "AbsoluteFix"
    /// <summary>
    ///   <para>rdfs:label : Actual Flight Route^^xsd:string</para>
    ///   <para>rdfs:comment : A flight trajectory (i.e., a sequence of track points), as determined by flight track surveillance data.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#ActualFlightRoute">atm:ActualFlightRoute</a>
    /// </summary>
    let ActualFlightRoute = _prefixId.prefix "ActualFlightRoute"
    /// <summary>
    ///   <para>rdfs:label : Aircraft capacity^^xsd:string</para>
    ///   <para>rdfs:comment : A subclass of interval-based data representing the maximum number of controllable aircraft flowing through an airspace region during some interval of time.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#AircraftCapacity">atm:AircraftCapacity</a>
    /// </summary>
    let AircraftCapacity = _prefixId.prefix "AircraftCapacity"
    /// <summary>
    ///   <para>rdfs:label : Aircraft flow^^xsd:string</para>
    ///   <para>rdfs:comment : A subclass of interval-based data representing the number of aircraft flowing through an airspace region during some interval of time.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#AircraftFlow">atm:AircraftFlow</a>
    /// </summary>
    let AircraftFlow = _prefixId.prefix "AircraftFlow"
    /// <summary>
    ///   <para>rdfs:label : Aircraft flow capacity^^xsd:string</para>
    ///   <para>rdfs:comment : A subclass of interval-based data representing the maximum controllable number of aircraft flowing through an airspace region during some interval of time, given weather and other air traffic control constraints.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#AircraftFlowCapacity">atm:AircraftFlowCapacity</a>
    /// </summary>
    let AircraftFlowCapacity = _prefixId.prefix "AircraftFlowCapacity"
    /// <summary>
    ///   <para>rdfs:label : Aircraft Track Point^^xsd:string</para>
    ///   <para>rdfs:comment : A point during a flight where various flight parameters are captured and sent (via transponder) to FAA computers.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#AircraftTrackPoint">atm:AircraftTrackPoint</a>
    /// </summary>
    let AircraftTrackPoint = _prefixId.prefix "AircraftTrackPoint"
    /// <summary>
    ///   <para>rdfs:label : Airport Fix^^xsd:string</para>
    ///   <para>rdfs:comment : A subclass of navigation fix corresponding to fixes associated directly with a ground reference point that is an airport.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#AirportFix">atm:AirportFix</a>
    /// </summary>
    let AirportFix = _prefixId.prefix "AirportFix"
    /// <summary>
    ///   <para>rdfs:label : Airport spec^^xsd:string</para>
    ///   <para>rdfs:comment : A specification of a set of airports.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#AirportSpec">atm:AirportSpec</a>
    /// </summary>
    let AirportSpec = _prefixId.prefix "AirportSpec"
    /// <summary>
    ///   <para>rdfs:label : Airspace Flow Program (AFP)^^xsd:string</para>
    ///   <para>rdfs:comment : A subclass of Traffic Management Initiative involving control and metering of air traffic through specified airspace volumes.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#AirspaceFlowProgramTMI">atm:AirspaceFlowProgramTMI</a>
    /// </summary>
    let AirspaceFlowProgramTMI = _prefixId.prefix "AirspaceFlowProgramTMI"
    /// <summary>
    ///   <para>rdfs:label : Airspace route segment^^xsd:string</para>
    ///   <para>rdfs:comment : A contiguous portion of an existing airspace route.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#AirspaceRouteSegment">atm:AirspaceRouteSegment</a>
    /// </summary>
    let AirspaceRouteSegment = _prefixId.prefix "AirspaceRouteSegment"
    /// <summary>
    ///   <para>rdfs:label : Crew member^^xsd:string</para>
    ///   <para>rdfs:comment : The set of inflight airline personnel operating or performing servicing functions on a flight (pilots and cabin attendants).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#CrewMember">atm:CrewMember</a>
    /// </summary>
    let CrewMember = _prefixId.prefix "CrewMember"
    /// <summary>
    ///   <para>rdfs:label : GDPmodel^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a computational delay model used in assigning times to the aircraft involved in the GDP or GS. The properties of this class correspond to parameters that are used by the delay model to compute the delay times.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#DelayModel">atm:DelayModel</a>
    /// </summary>
    let DelayModel = _prefixId.prefix "DelayModel"
    /// <summary>
    ///   <para>rdfs:label : FRD Fix^^xsd:string</para>
    ///   <para>rdfs:comment : A Fix Radial Distance (FRD) fix is located a specified distance from a ground-based navaid, a named fix, or an airport, along a given radial vector.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#FRDfix">atm:FRDfix</a>
    /// </summary>
    let FRDfix = _prefixId.prefix "FRDfix"
    /// <summary>
    ///   <para>rdfs:label : Flight^^xsd:string</para>
    ///   <para>rdfs:comment : A single flight segment from origin to destination.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#Flight">atm:Flight</a>
    /// </summary>
    let Flight = _prefixId.prefix "Flight"
    /// <summary>
    ///   <para>rdfs:label : Flight plan segment^^xsd:string</para>
    ///   <para>rdfs:comment : A contiguous portion of a complete flight plan.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#FlightPlanSegment">atm:FlightPlanSegment</a>
    /// </summary>
    let FlightPlanSegment = _prefixId.prefix "FlightPlanSegment"
    /// <summary>
    ///   <para>rdfs:label : Flight spec^^xsd:string</para>
    ///   <para>rdfs:comment : A specification describing a set of flights.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#FlightSpec">atm:FlightSpec</a>
    /// </summary>
    let FlightSpec = _prefixId.prefix "FlightSpec"
    let GDPmodel = _prefixId.prefix "GDPmodel"
    /// <summary>
    ///   <para>rdfs:label : GPS fix^^xsd:string</para>
    ///   <para>rdfs:comment : A navigation fix defined by GPS coordinates.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#GPSfix">atm:GPSfix</a>
    /// </summary>
    let GPSfix = _prefixId.prefix "GPSfix"
    /// <summary>
    ///   <para>rdfs:label : Ground Delay Program (GDP)^^xsd:string</para>
    ///   <para>rdfs:comment : A Ground Delay Program (GDP) traffic management initiative (TMI). A Ground Delay Program (GDP) is a traffic management procedure where aircraft are delayed at their departure airport in order to manage demand and capacity at their arrival airport.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#GroundDelayProgramTMI">atm:GroundDelayProgramTMI</a>
    /// </summary>
    let GroundDelayProgramTMI = _prefixId.prefix "GroundDelayProgramTMI"
    /// <summary>
    ///   <para>rdfs:label : Ground Stop (GS)^^xsd:string</para>
    ///   <para>rdfs:comment : A Ground Stop (GS) traffic management initiative (TMI). A ground stop is a procedure requiring aircraft that meet specific criteria to remain on the ground. The GS may be airport specific, related to a geographical area, or equipment related.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#GroundStopTMI">atm:GroundStopTMI</a>
    /// </summary>
    let GroundStopTMI = _prefixId.prefix "GroundStopTMI"
    /// <summary>
    ///   <para>rdfs:label : Intersection fix^^xsd:string</para>
    ///   <para>rdfs:comment : A navigation fix defined by the intersection of two airspace routes.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#IntersectionFix">atm:IntersectionFix</a>
    /// </summary>
    let IntersectionFix = _prefixId.prefix "IntersectionFix"
    /// <summary>
    ///   <para>rdfs:label : Lat-lon fix^^xsd:string</para>
    ///   <para>rdfs:comment : A navigation fix based on latitude/longitude coordinates.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#LatLonFix">atm:LatLonFix</a>
    /// </summary>
    let LatLonFix = _prefixId.prefix "LatLonFix"
    /// <summary>
    ///   <para>rdfs:label : Meter fix^^xsd:string</para>
    ///   <para>rdfs:comment : A fix defined as an point in the terminal airspace through which flights are metered by air traffic control on approach.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#MeterFix">atm:MeterFix</a>
    /// </summary>
    let MeterFix = _prefixId.prefix "MeterFix"
    /// <summary>
    ///   <para>rdfs:label : Miles in Trail (MIT)^^xsd:string</para>
    ///   <para>rdfs:comment : A Miles-in-Trail (MIT) traffic management initiative (TMI) is used to apportion traffic into a manageable flow, as well as provide space for additional traffic (merging or departing) to enter the flow of traffic. Miles-in-trail describes the number of miles required between aircraft departing an airport, over a fix, at an altitude, through a sector, or on a specific route.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#MilesInTrailTMI">atm:MilesInTrailTMI</a>
    /// </summary>
    let MilesInTrailTMI = _prefixId.prefix "MilesInTrailTMI"
    /// <summary>
    ///   <para>rdfs:label : NDB Fix^^xsd:string</para>
    ///   <para>rdfs:comment : A fix based on the location of a ground-based non-directional radio beacon (NDB) installation. NDB signals follow the curvature of the Earth, so they can be received at much greater distances at lower altitudes, a major advantage over VOR. However, NDB signals are also affected more by atmospheric conditions, mountainous terrain, coastal refraction and electrical storms, particularly at long range.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#NDBfix">atm:NDBfix</a>
    /// </summary>
    let NDBfix = _prefixId.prefix "NDBfix"
    /// <summary>
    ///   <para>rdfs:label : NRS fix^^xsd:string</para>
    ///   <para>rdfs:comment : The NRS is a system of waypoints developed for use within the United States for flight planning and navigation without reference to ground based navigational aids. The NRS waypoints are located in a grid pattern along defined latitude and longitude lines. NRS waypoint names are composed of two letters followed by two numbers, followed by a single letter. The first and second characters of NRS waypoints are the FIR identifier for the United States (“K”) and the FIR subdivision, or ARTCC center in which the waypoint is located (e.g. “D” for Denver ARTCC). The third and fourth characters are a number group representing the latitude of the waypoint. These numbers begin at the equator with 00 and advances north and south from 01 to 90 and correspond to every 10 minutes of latitude and repeating every 15°. The final character in the NRS waypoint is a letter representing the line of longitude for which the waypoint is located. This identifier starts at the prime meridian moving west to east and uses the letters A to Z while repeating every 26°. To date, the current density of the NRS grid is one waypoint spaced every 30 minutes of latitude and every 2° of longitude.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#NRSfix">atm:NRSfix</a>
    /// </summary>
    let NRSfix = _prefixId.prefix "NRSfix"
    /// <summary>
    ///   <para>rdfs:label : Navigation element container^^xsd:string</para>
    ///   <para>rdfs:comment : A navigation element container is a wrapper around an existing navigation element, such as a fix or a route. These containers can be sequenced together to represent flight paths and flight trajectories.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#NavElementContainer">atm:NavElementContainer</a>
    /// </summary>
    let NavElementContainer = _prefixId.prefix "NavElementContainer"
    /// <summary>
    ///   <para>rdfs:label : NavaidFix^^xsd:string</para>
    ///   <para>rdfs:comment : A fix based on the location of a ground-based Navigation Aid (Navaid) installation.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#NavaidFix">atm:NavaidFix</a>
    /// </summary>
    let NavaidFix = _prefixId.prefix "NavaidFix"
    /// <summary>
    ///   <para>rdfs:label : Navigation element^^xsd:string</para>
    ///   <para>rdfs:comment : A navigation element is a set of components that can be used to assemble a flight plan or trajectory. They include fixes, routes, airports, SID/STAR traverses, etc.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#NavigationElement">atm:NavigationElement</a>
    /// </summary>
    let NavigationElement = _prefixId.prefix "NavigationElement"
    /// <summary>
    ///   <para>rdfs:label : Navigation fix^^xsd:string</para>
    ///   <para>rdfs:comment : A designated point on the surface of the earth used for aeronautical navigation.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#NavigationFix">atm:NavigationFix</a>
    /// </summary>
    let NavigationFix = _prefixId.prefix "NavigationFix"
    /// <summary>
    ///   <para>rdfs:label : Navigation path^^xsd:string</para>
    ///   <para>rdfs:comment : An ordered sequence of navigation elements (fixes, routes, airports) representing a path through the airspace.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#NavigationPath">atm:NavigationPath</a>
    /// </summary>
    let NavigationPath = _prefixId.prefix "NavigationPath"
    /// <summary>
    ///   <para>rdfs:label : Navigation SubPath^^xsd:string</para>
    ///   <para>rdfs:comment : A contiguous portion of an existing navigation path.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#NavigationSubPath">atm:NavigationSubPath</a>
    /// </summary>
    let NavigationSubPath = _prefixId.prefix "NavigationSubPath"
    /// <summary>
    ///   <para>rdfs:label : Numeric parameter container^^xsd:string</para>
    ///   <para>rdfs:comment : A wrapper around a numeric parameter. Containers can be sequenced to create an ordered list of numeric parameters.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#NumericParameterContainer">atm:NumericParameterContainer</a>
    /// </summary>
    let NumericParameterContainer = _prefixId.prefix "NumericParameterContainer"
    /// <summary>
    ///   <para>rdfs:label : Planned flight route^^xsd:string</para>
    ///   <para>rdfs:comment : A planned flight route is an ordered sequence of navigation elements that the pilot intends to traverse en route from origin to destination airport.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#PlannedFlightRoute">atm:PlannedFlightRoute</a>
    /// </summary>
    let PlannedFlightRoute = _prefixId.prefix "PlannedFlightRoute"
    /// <summary>
    ///   <para>rdfs:label : Popup factor^^xsd:string</para>
    ///   <para>rdfs:comment : Factor to account for late-filing flights when modeling delays as part of a traffic management initiative (TMI) design process.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#PopupFactor">atm:PopupFactor</a>
    /// </summary>
    let PopupFactor = _prefixId.prefix "PopupFactor"
    /// <summary>
    ///   <para>rdfs:label : Popup Factor container^^xsd:string</para>
    ///   <para>rdfs:comment : A wrapper around a popup factor parameter. Used to sequence popup factors in the specification of a Ground Delay Program (GDP).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#PopupFactorContainer">atm:PopupFactorContainer</a>
    /// </summary>
    let PopupFactorContainer = _prefixId.prefix "PopupFactorContainer"
    /// <summary>
    ///   <para>rdfs:label : Popup Factor Sequence^^xsd:string</para>
    ///   <para>rdfs:comment : An ordered sequence of hourly popup factors used in specifying a Ground Delay Program (GDP).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#PopupFactorSequence">atm:PopupFactorSequence</a>
    /// </summary>
    let PopupFactorSequence = _prefixId.prefix "PopupFactorSequence"
    /// <summary>
    ///   <para>rdfs:label : Program arrival rate^^xsd:string</para>
    ///   <para>rdfs:comment : The number of aircraft that the Ground Delay Program (GDP) is to provide to the airport for a given hour.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#ProgramArrivalRate">atm:ProgramArrivalRate</a>
    /// </summary>
    let ProgramArrivalRate = _prefixId.prefix "ProgramArrivalRate"
    /// <summary>
    ///   <para>rdfs:label : Program arrival rate container^^xsd:string</para>
    ///   <para>rdfs:comment : A wrapper around a program arrival rate, used to sequence them into an ordered list.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#ProgramArrivalRateContainer">atm:ProgramArrivalRateContainer</a>
    /// </summary>
    let ProgramArrivalRateContainer = _prefixId.prefix "ProgramArrivalRateContainer"
    /// <summary>
    ///   <para>rdfs:label : Program Arrival Rate Sequence^^xsd:string</para>
    ///   <para>rdfs:comment : An ordered sequence of hourly program arrival rates used in specifying a Ground Dela Program (GDP).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#ProgramArrivalRateSequence">atm:ProgramArrivalRateSequence</a>
    /// </summary>
    let ProgramArrivalRateSequence = _prefixId.prefix "ProgramArrivalRateSequence"
    /// <summary>
    ///   <para>rdfs:label : ReRoute segment^^xsd:string</para>
    ///   <para>rdfs:comment : One of the route segment alternatives specified as part of a ReRoute traffic management initiative (TMI).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#ReRouteSegment">atm:ReRouteSegment</a>
    /// </summary>
    let ReRouteSegment = _prefixId.prefix "ReRouteSegment"
    /// <summary>
    ///   <para>rdfs:comment : A ReRoute is a traffic management initiative (TMI) that mandates a change in the filed flight plan for a set of specified flights. There are multiple factors that might justify a reroute, including weather, traffic congestion, unusual airspace activity, etc. The substitute flight plans route air traffic around the airspace problem area.^^xsd:string</para>
    ///   <para>rdfs:label : ReRoute^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#ReRouteTMI">atm:ReRouteTMI</a>
    /// </summary>
    let ReRouteTMI = _prefixId.prefix "ReRouteTMI"
    /// <summary>
    ///   <para>rdfs:label : Relative fix^^xsd:string</para>
    ///   <para>rdfs:comment : A fix defined in relation to another fix.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#RelativeFix">atm:RelativeFix</a>
    /// </summary>
    let RelativeFix = _prefixId.prefix "RelativeFix"
    /// <summary>
    ///   <para>rdfs:label : SIDSTARtraverse^^xsd:string</para>
    ///   <para>rdfs:comment : A route through a SID (Standard Instrument Departure route) or a STAR (Standard Arrival Route), traversing a common route at minimum and optionally a transition route and/or an airport route.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#SIDSTARtraverse">atm:SIDSTARtraverse</a>
    /// </summary>
    let SIDSTARtraverse = _prefixId.prefix "SIDSTARtraverse"
    /// <summary>
    ///   <para>rdfs:label : TACAN Fix^^xsd:string</para>
    ///   <para>rdfs:comment : A fix based on the location of a ground-based TACAN (TACtical Air Navigation) installation.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#TACANfix">atm:TACANfix</a>
    /// </summary>
    let TACANfix = _prefixId.prefix "TACANfix"
    /// <summary>
    ///   <para>rdfs:label : TFM control element^^xsd:string</para>
    ///   <para>rdfs:comment : Any NAS entity that is potentially controlled via a TFM initiative.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#TFMcontrolElement">atm:TFMcontrolElement</a>
    /// </summary>
    let TFMcontrolElement = _prefixId.prefix "TFMcontrolElement"
    /// <summary>
    ///   <para>rdfs:label : Taxipath^^xsd:string</para>
    ///   <para>rdfs:comment : A sequence of taxiways followed by an aircraft taxiing en route to/from a runway.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#Taxipath">atm:Taxipath</a>
    /// </summary>
    let Taxipath = _prefixId.prefix "Taxipath"
    /// <summary>
    ///   <para>rdfs:label : Traffic management initiative^^xsd:string</para>
    ///   <para>rdfs:comment : A Traffic Management Initiative (TMI) is an orchestrated air traffic management procedure implemented as needed to control the flow of air traffic in the NAS based on capacity and demand.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#TrafficManagementInitiative">atm:TrafficManagementInitiative</a>
    /// </summary>
    let TrafficManagementInitiative = _prefixId.prefix "TrafficManagementInitiative"
    /// <summary>
    ///   <para>rdfs:label : VOR Fix^^xsd:string</para>
    ///   <para>rdfs:comment : A fix based on the location of a ground-based VOR (VHF Omni Directional Radio Range) installation.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#VORfix">atm:VORfix</a>
    /// </summary>
    let VORfix = _prefixId.prefix "VORfix"
    /// <summary>
    ///   <para>rdfs:label : actual arrival day^^xsd:string</para>
    ///   <para>rdfs:comment : Links a flight with the day on which the flight arrives. This is the day determined by surveillance data sources to be the 'actual' day of arrival, versus the scheduled day or the day specified in the flight plan, etc.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#actualArrivalDay">atm:actualArrivalDay</a>
    /// </summary>
    let actualArrivalDay = _prefixId.prefix "actualArrivalDay"
    /// <summary>
    ///   <para>rdfs:label : actual arrival time^^xsd:string</para>
    ///   <para>rdfs:comment : The time determined by surveillance data sources to be the 'actual' time of flight arrival, versus the scheduled time or the time specified in the flight plan, etc.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#actualArrivalTime">atm:actualArrivalTime</a>
    /// </summary>
    let actualArrivalTime = _prefixId.prefix "actualArrivalTime"
    /// <summary>
    ///   <para>rdfs:label : actual departure day^^xsd:string</para>
    ///   <para>rdfs:comment : Links a flight with the day on which the flight departs. This is the day determined by surveillance data sources to be the 'actual' day of departure, versus the scheduled day or the day specified in the flight plan, etc.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#actualDepartureDay">atm:actualDepartureDay</a>
    /// </summary>
    let actualDepartureDay = _prefixId.prefix "actualDepartureDay"
    /// <summary>
    ///   <para>rdfs:label : actual departure time^^xsd:string</para>
    ///   <para>rdfs:comment : The time determined by surveillance data sources to be the 'actual' time of flight departure, versus the scheduled time or the time specified in the flight plan, etc.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#actualDepartureTime">atm:actualDepartureTime</a>
    /// </summary>
    let actualDepartureTime = _prefixId.prefix "actualDepartureTime"
    /// <summary>
    ///   <para>rdfs:label : adl day^^xsd:string</para>
    ///   <para>rdfs:comment : Links a delay model to the day that the ADL (Aggregate Demand List) was generated. Each ADL contains information on the flights arriving and departing from an airport, or entering into and departing from a flow area.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#adlDay">atm:adlDay</a>
    /// </summary>
    let adlDay = _prefixId.prefix "adlDay"
    /// <summary>
    ///   <para>rdfs:label : adl time^^xsd:string</para>
    ///   <para>rdfs:comment : The timestamp of the ADL (Aggregate Demand List) that the delay model is based upon. Each ADL contains information on the flights arriving and departing from an airport, or entering into and departing from a flow area.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#adlTime">atm:adlTime</a>
    /// </summary>
    let adlTime = _prefixId.prefix "adlTime"
    /// <summary>
    ///   <para>rdfs:label : adsb ID^^xsd:string</para>
    ///   <para>rdfs:comment : The unique identifier of the ADS-B (Automatic Dependent Surveillance - Broadcast) transponder unit on board the aircraft for this flight.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#adsbID">atm:adsbID</a>
    /// </summary>
    let adsbID = _prefixId.prefix "adsbID"
    /// <summary>
    ///   <para>rdfs:label : advisory number^^xsd:string</para>
    ///   <para>rdfs:comment : Advisory number as reported from the FAA Command Center database. it restarts at 001 on every new day UTC.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#advisoryNumber">atm:advisoryNumber</a>
    /// </summary>
    let advisoryNumber = _prefixId.prefix "advisoryNumber"
    /// <summary>
    ///   <para>rdfs:label : aircraft count^^xsd:string</para>
    ///   <para>rdfs:comment : The number of aircraft flowing through an airspace region per some interval of time.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#aircraftCount">atm:aircraftCount</a>
    /// </summary>
    let aircraftCount = _prefixId.prefix "aircraftCount"
    /// <summary>
    ///   <para>rdfs:label : aircraft fix^^xsd:string</para>
    ///   <para>rdfs:comment : Links an aircraft track point with its associated navigation fix.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#aircraftFix">atm:aircraftFix</a>
    /// </summary>
    let aircraftFix = _prefixId.prefix "aircraftFix"
    /// <summary>
    ///   <para>rdfs:label : aircraft flown^^xsd:string</para>
    ///   <para>rdfs:comment : Links a flight with the actual aircraft used.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#aircraftFlown">atm:aircraftFlown</a>
    /// </summary>
    let aircraftFlown = _prefixId.prefix "aircraftFlown"
    /// <summary>
    ///   <para>rdfs:label : aircraft type flown^^xsd:string</para>
    ///   <para>rdfs:comment : Links a flight with the type of aircraft flown. The aircraft 'type' corresponds to a set of aircraft models with similar characteristics.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#aircraftTypeFlown">atm:aircraftTypeFlown</a>
    /// </summary>
    let aircraftTypeFlown = _prefixId.prefix "aircraftTypeFlown"
    /// <summary>
    ///   <para>rdfs:label : aircraft weight category^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the weight category as part of a flight specification constraint.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#aircraftWeightCat">atm:aircraftWeightCat</a>
    /// </summary>
    let aircraftWeightCat = _prefixId.prefix "aircraftWeightCat"
    /// <summary>
    ///   <para>rdfs:label : allowed route^^xsd:string</para>
    ///   <para>rdfs:comment : In a reRoute traffic management initiative, there are multiple allowed routes specified between origin and destination. This property links a ReRouteTMI with its allowed routes.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#allowedRoute">atm:allowedRoute</a>
    /// </summary>
    let allowedRoute = _prefixId.prefix "allowedRoute"
    /// <summary>
    ///   <para>rdfs:label : alternate arrival airport^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the alternate arrival airport to be used in case of weather, traffic, or other unforseen contingency. The alternate airport is specified in the flight plan.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#alternateArrivalAirport">atm:alternateArrivalAirport</a>
    /// </summary>
    let alternateArrivalAirport = _prefixId.prefix "alternateArrivalAirport"
    /// <summary>
    ///   <para>rdfs:label : arrival airport^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the actual arrival airport for the flight.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#arrivalAirport">atm:arrivalAirport</a>
    /// </summary>
    let arrivalAirport = _prefixId.prefix "arrivalAirport"
    /// <summary>
    ///   <para>rdfs:label : arrival runway^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the actual arrival runway for the flight.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#arrivalRunway">atm:arrivalRunway</a>
    /// </summary>
    let arrivalRunway = _prefixId.prefix "arrivalRunway"
    /// <summary>
    ///   <para>rdfs:label : arrival taxi path^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the taxipath followed by the flight en route to the gate.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#arrivalTaxiPath">atm:arrivalTaxiPath</a>
    /// </summary>
    let arrivalTaxiPath = _prefixId.prefix "arrivalTaxiPath"
    /// <summary>
    ///   <para>rdfs:label : call sign^^xsd:string</para>
    ///   <para>rdfs:comment : The flight identifier (3-letter ICAO code plus number).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#callSign">atm:callSign</a>
    /// </summary>
    let callSign = _prefixId.prefix "callSign"
    /// <summary>
    ///   <para>rdfs:label : controlled NASelement^^xsd:string</para>
    ///   <para>rdfs:comment : Links a traffic management initiative (TMI) to the airspace element being controlled by the TMI (e.g., an airport).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#controlledNASelement">atm:controlledNASelement</a>
    /// </summary>
    let controlledNASelement = _prefixId.prefix "controlledNASelement"
    /// <summary>
    ///   <para>rdfs:label : cruising altitude^^xsd:string</para>
    ///   <para>rdfs:comment : The cruising altitude (in number of feet) specified in the flight plan for this flight.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#cruisingAltitude">atm:cruisingAltitude</a>
    /// </summary>
    let cruisingAltitude = _prefixId.prefix "cruisingAltitude"
    /// <summary>
    ///   <para>rdfs:label : delay assignment mode^^xsd:string</para>
    ///   <para>rdfs:comment : The type of delay assignment mode specified for this delay model: DAS, GAAP, or UDP.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#delayAssignmentMode">atm:delayAssignmentMode</a>
    /// </summary>
    let delayAssignmentMode = _prefixId.prefix "delayAssignmentMode"
    /// <summary>
    ///   <para>rdfs:label : departure airport^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the actual departure airport for the flight.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#departureAirport">atm:departureAirport</a>
    /// </summary>
    let departureAirport = _prefixId.prefix "departureAirport"
    /// <summary>
    ///   <para>rdfs:label : departure runway^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the actual departure runway for the flight.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#departureRunway">atm:departureRunway</a>
    /// </summary>
    let departureRunway = _prefixId.prefix "departureRunway"
    /// <summary>
    ///   <para>rdfs:label : departure scope^^xsd:string</para>
    ///   <para>rdfs:comment : Links a Ground Delay Program (GDP) or a Ground Stop (GS) to a specification of the departure airport(s) participating in the traffic management initiative (TMI).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#departureScope">atm:departureScope</a>
    /// </summary>
    let departureScope = _prefixId.prefix "departureScope"
    /// <summary>
    ///   <para>rdfs:label : departure taxi path^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the taxipath followed by the flight en route to the runway.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#departureTaxiPath">atm:departureTaxiPath</a>
    /// </summary>
    let departureTaxiPath = _prefixId.prefix "departureTaxiPath"
    /// <summary>
    ///   <para>rdfs:label : effective end day^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the expected ending day of the traffic management initiative (TMI).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#effectiveEndDay">atm:effectiveEndDay</a>
    /// </summary>
    let effectiveEndDay = _prefixId.prefix "effectiveEndDay"
    /// <summary>
    ///   <para>rdfs:label : effective end time^^xsd:string</para>
    ///   <para>rdfs:comment : The expected end time of the traffic management initiative (TMI).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#effectiveEndTime">atm:effectiveEndTime</a>
    /// </summary>
    let effectiveEndTime = _prefixId.prefix "effectiveEndTime"
    /// <summary>
    ///   <para>rdfs:label : effective start day^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the expected starting day of the traffic management initiative (TMI).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#effectiveStartDay">atm:effectiveStartDay</a>
    /// </summary>
    let effectiveStartDay = _prefixId.prefix "effectiveStartDay"
    /// <summary>
    ///   <para>rdfs:label : effective start time^^xsd:string</para>
    ///   <para>rdfs:comment : The expected start time of the traffic management initiative (TMI).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#effectiveStartTime">atm:effectiveStartTime</a>
    /// </summary>
    let effectiveStartTime = _prefixId.prefix "effectiveStartTime"
    /// <summary>
    ///   <para>rdfs:label : excludes ARTCC^^xsd:string</para>
    ///   <para>rdfs:comment : Links an airport specification to one of more ARTCCs (Centers) or ARTCC tiers (Centers radiating out from a give ARTCC). Any airport within the ARTCC or ARTCC tier is excluded from the set of airports covered by this airport specification.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#excludesARTCC">atm:excludesARTCC</a>
    /// </summary>
    let excludesARTCC = _prefixId.prefix "excludesARTCC"
    /// <summary>
    ///   <para>rdfs:label : excludes airport^^xsd:string</para>
    ///   <para>rdfs:comment : Links an airport specification to one of more airports. Any airport linked is excluded from the set of airports covered by this airport specification.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#excludesAirport">atm:excludesAirport</a>
    /// </summary>
    let excludesAirport = _prefixId.prefix "excludesAirport"
    /// <summary>
    ///   <para>rdfs:label : excludes airway^^xsd:string</para>
    ///   <para>rdfs:comment : Links a flight specification to one of more airways (routes). Any flight that traverses a linked airway is excluded from the set of flights covered by this flight specification.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#excludesAirway">atm:excludesAirway</a>
    /// </summary>
    let excludesAirway = _prefixId.prefix "excludesAirway"
    /// <summary>
    ///   <para>rdfs:label : excludes fix^^xsd:string</para>
    ///   <para>rdfs:comment : Links a flight specification to one of more navigation fixes. Any flight that traverses a linked fix is excluded from the set of flights covered by this flight specification.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#excludesFix">atm:excludesFix</a>
    /// </summary>
    let excludesFix = _prefixId.prefix "excludesFix"
    /// <summary>
    ///   <para>rdfs:label : excludes flight^^xsd:string</para>
    ///   <para>rdfs:comment : Links a flight specification to one of more flights. Any linked flight is excluded from the set of flights covered by this flight specification.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#excludesFlight">atm:excludesFlight</a>
    /// </summary>
    let excludesFlight = _prefixId.prefix "excludesFlight"
    /// <summary>
    ///   <para>rdfs:label : exempted AFP^^xsd:string</para>
    ///   <para>rdfs:comment : Links a flight specification to one of more Airspace Flow Program (AFP) traffic management initiatives (TMIs). Any flight included in one of the linked AFPs is excluded from the set of flights covered by this flight specification.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#exemptedAFP">atm:exemptedAFP</a>
    /// </summary>
    let exemptedAFP = _prefixId.prefix "exemptedAFP"
    /// <summary>
    ///   <para>rdfs:label : extension probability^^xsd:string</para>
    ///   <para>rdfs:comment : The probability that this traffic management initiative (TMI) will be extended: LOW, MEDIUM, or HIGH.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#extensionProbability">atm:extensionProbability</a>
    /// </summary>
    let extensionProbability = _prefixId.prefix "extensionProbability"
    /// <summary>
    ///   <para>rdfs:label : fix ID^^xsd:string</para>
    ///   <para>rdfs:comment : A non-unique FAA identifier for a fix. When combined with a fix ICAO code, it defines a unique fix worldwide. Often, but not always, the fixId is identical to the fixName.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#fixId">atm:fixId</a>
    /// </summary>
    let fixId = _prefixId.prefix "fixId"
    /// <summary>
    ///   <para>rdfs:label : fix name^^xsd:string</para>
    ///   <para>rdfs:comment : A unique FAA identier for a fix that can be filed as part of a flight plan. The fix name conceptually represents the worldwide-unique combination of a FixID and ICAO code. Often, but not always, the fixId is identical to the fixName.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#fixName">atm:fixName</a>
    /// </summary>
    let fixName = _prefixId.prefix "fixName"
    /// <summary>
    ///   <para>rdfs:label : fix trajectory string^^xsd:string</para>
    ///   <para>rdfs:comment : This is an experimental property of a flight that stores an ordered sequence of named fixes corresponding one-to-one to the sequence of trajectory track points recorded for the flight. For a given track point, the corresponding named fix is computed by finding the closest named fix to the track point.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#fixTrajectoryString">atm:fixTrajectoryString</a>
    /// </summary>
    let fixTrajectoryString = _prefixId.prefix "fixTrajectoryString"
    /// <summary>
    ///   <para>rdfs:label : flight exclusion spec^^xsd:string</para>
    ///   <para>rdfs:comment : Links a Ground Delay Program (GDP) or a Ground Stop (GS) to a specification of the flight(s) excluded from the traffic management initiative (TMI).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#flightExclusionSpec">atm:flightExclusionSpec</a>
    /// </summary>
    let flightExclusionSpec = _prefixId.prefix "flightExclusionSpec"
    /// <summary>
    ///   <para>rdfs:label : flight inclusion exclusion^^xsd:string</para>
    ///   <para>rdfs:comment : Links a ReRoute to a specification of the flight(s) included in or excluded from the ReRoute traffic management initiative (TMI).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#flightInclusionExclusion">atm:flightInclusionExclusion</a>
    /// </summary>
    let flightInclusionExclusion = _prefixId.prefix "flightInclusionExclusion"
    /// <summary>
    ///   <para>rdfs:label : flight inclusion spec^^xsd:string</para>
    ///   <para>rdfs:comment : Links a Ground Delay Program (GDP) or a Ground Stop (GS) to a specification of the flight(s) included in the traffic management initiative (TMI).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#flightInclusionSpec">atm:flightInclusionSpec</a>
    /// </summary>
    let flightInclusionSpec = _prefixId.prefix "flightInclusionSpec"
    /// <summary>
    ///   <para>rdfs:label : flight plan ETA^^xsd:string</para>
    ///   <para>rdfs:comment : The estimated time of arrival specified in the flight plan.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#flightPlanETA">atm:flightPlanETA</a>
    /// </summary>
    let flightPlanETA = _prefixId.prefix "flightPlanETA"
    /// <summary>
    ///   <para>rdfs:label : flight route string^^xsd:string</para>
    ///   <para>rdfs:comment : A string that provides the route of flight proposed in a flight plan. Syntactically, the string shows a path of fixes, airways, SIDs, and STARs, separated by either one or two dots. The string is parsed to create an equivalent ontology representation: an ordered sequence of navigation elements that are associated directly with the flight plan (atm:PlannedFlightRoute).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#flightRouteString">atm:flightRouteString</a>
    /// </summary>
    let flightRouteString = _prefixId.prefix "flightRouteString"
    /// <summary>
    ///   <para>rdfs:label : flow capacity^^xsd:string</para>
    ///   <para>rdfs:comment : The maximum controllable number of aircraft flowing through an airspace region per some interval of time.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#flowCapacity">atm:flowCapacity</a>
    /// </summary>
    let flowCapacity = _prefixId.prefix "flowCapacity"
    /// <summary>
    ///   <para>rdfs:label : flow measurement region^^xsd:string</para>
    ///   <para>rdfs:comment : Links an aircraft capacity or aircraft flow to the spatial region through which flow or capacity is being monitored and measured.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#flowMeasurementRegion">atm:flowMeasurementRegion</a>
    /// </summary>
    let flowMeasurementRegion = _prefixId.prefix "flowMeasurementRegion"
    /// <summary>
    ///   <para>rdfs:label : ground speed^^xsd:string</para>
    ///   <para>rdfs:comment : The reported ground speed at an aircraft track point.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#groundSpeed">atm:groundSpeed</a>
    /// </summary>
    let groundSpeed = _prefixId.prefix "groundSpeed"
    /// <summary>
    ///   <para>rdfs:label : has actual route^^xsd:string</para>
    ///   <para>rdfs:comment : Links a flight to its actual trajectory (i.e., a sequence of track points), as determined by flight track surveillance data.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#hasActualRoute">atm:hasActualRoute</a>
    /// </summary>
    let hasActualRoute = _prefixId.prefix "hasActualRoute"
    /// <summary>
    ///   <para>rdfs:label : has crew member^^xsd:string</para>
    ///   <para>rdfs:comment : Links a flight to its crew members.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#hasCrewMember">atm:hasCrewMember</a>
    /// </summary>
    let hasCrewMember = _prefixId.prefix "hasCrewMember"
    /// <summary>
    ///   <para>rdfs:label : has navigation element^^xsd:string</para>
    ///   <para>rdfs:comment : Links a container for a navigational element to the element contained.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#hasNavElement">atm:hasNavElement</a>
    /// </summary>
    let hasNavElement = _prefixId.prefix "hasNavElement"
    /// <summary>
    ///   <para>rdfs:label : has numeric parameter^^xsd:string</para>
    ///   <para>rdfs:comment : Links a container for a numerical parameter to the numerical parameter contained.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#hasNumericParameter">atm:hasNumericParameter</a>
    /// </summary>
    let hasNumericParameter = _prefixId.prefix "hasNumericParameter"
    /// <summary>
    ///   <para>rdfs:label : has planned route^^xsd:string</para>
    ///   <para>rdfs:comment : Links a flight to a version of its flight plan. (Which version gets stored is application-dependent.) There are multiple versions of the flight plan generated and then amended during the course of the flight, starting in the pre-flight timeframe and extending through to the termination of the flight.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#hasPlannedRoute">atm:hasPlannedRoute</a>
    /// </summary>
    let hasPlannedRoute = _prefixId.prefix "hasPlannedRoute"
    /// <summary>
    ///   <para>rdfs:label : heading^^xsd:string</para>
    ///   <para>rdfs:comment : The aircraft heading at the track point: a number between 0.01 and 360.0 indicating the angular heading with respect to North.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#heading">atm:heading</a>
    /// </summary>
    let heading = _prefixId.prefix "heading"
    /// <summary>
    ///   <para>rdfs:label : impacting condition^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the reason for initiating the Ground Delay Program: weather, volume, runway, equipment, other.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#impactingCondition">atm:impactingCondition</a>
    /// </summary>
    let impactingCondition = _prefixId.prefix "impactingCondition"
    /// <summary>
    ///   <para>rdfs:label : impacting condition message^^xsd:string</para>
    ///   <para>rdfs:comment : A free-text descriptoin elaborating on the reason for initiating the Ground Delay Program.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#impactingConditionMessage">atm:impactingConditionMessage</a>
    /// </summary>
    let impactingConditionMessage = _prefixId.prefix "impactingConditionMessage"
    /// <summary>
    ///   <para>rdfs:label : implementation status^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the enforcement status of the ReRoute advisory: RQD (required), RMD (recommended), PLN (planned for implementation), FYI (informational only)^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#implementationStatus">atm:implementationStatus</a>
    /// </summary>
    let implementationStatus = _prefixId.prefix "implementationStatus"
    /// <summary>
    ///   <para>rdfs:label : included flights^^xsd:string</para>
    ///   <para>rdfs:comment : Links an aircraft flow to a specification of the flights included in the flow.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#includedFlights">atm:includedFlights</a>
    /// </summary>
    let includedFlights = _prefixId.prefix "includedFlights"
    /// <summary>
    ///   <para>rdfs:label : includes aircraft class^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates which class of aircraft the flights defined by this specification must employ: jet, prop, jet and prop, turbo, all.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#includesAircraftClass">atm:includesAircraftClass</a>
    /// </summary>
    let includesAircraftClass = _prefixId.prefix "includesAircraftClass"
    /// <summary>
    ///   <para>rdfs:label : includes airport^^xsd:string</para>
    ///   <para>rdfs:comment : Links an airport specification to one of more airports. Any airport linked is included in the set of airports covered by this airport specification. This property allows for explicit specification of a list of specific airports; the property atm:includesAirportType allows for the the implicit specification of an entire class of airports.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#includesAirport">atm:includesAirport</a>
    /// </summary>
    let includesAirport = _prefixId.prefix "includesAirport"
    /// <summary>
    ///   <para>rdfs:label : includes airport type^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates which type of airports are included in the set of airports covered by this airport specification: all, US, CONUS, NonCONUS, International, Canadian. This property allows for the implicit specification of an entire class of airports; the property atm:includesAirport allows for the explicit specification of a list of specific airports.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#includesAirportType">atm:includesAirportType</a>
    /// </summary>
    let includesAirportType = _prefixId.prefix "includesAirportType"
    /// <summary>
    ///   <para>rdfs:label : includes airway^^xsd:string</para>
    ///   <para>rdfs:comment : Links a flight specification to one of more airways (routes). Any flight that traverses a linked airway is included in the set of flights covered by this flight specification.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#includesAirway">atm:includesAirway</a>
    /// </summary>
    let includesAirway = _prefixId.prefix "includesAirway"
    /// <summary>
    ///   <para>rdfs:label : includes fix^^xsd:string</para>
    ///   <para>rdfs:comment : Links a flight specification to one of more navigation fixes. Any flight that traverses a linked fix is included in the set of flights covered by this flight specification.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#includesFix">atm:includesFix</a>
    /// </summary>
    let includesFix = _prefixId.prefix "includesFix"
    /// <summary>
    ///   <para>rdfs:label : includes flight^^xsd:string</para>
    ///   <para>rdfs:comment : Links a flight specification to one of more flights. Any linked flight is included in the set of flights covered by this flight specification.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#includesFlight">atm:includesFlight</a>
    /// </summary>
    let includesFlight = _prefixId.prefix "includesFlight"
    /// <summary>
    ///   <para>rdfs:comment : Provides any specific comments on the traffic management initiative (TMI) made by the issuing authority (e.g., ATCSCC, ARTCC).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#initiativeComments">atm:initiativeComments</a>
    /// </summary>
    let initiativeComments = _prefixId.prefix "initiativeComments"
    /// <summary>
    ///   <para>rdfs:label : issued day^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the day when the traffic management initiative (TMI) was issued.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#issuedDay">atm:issuedDay</a>
    /// </summary>
    let issuedDay = _prefixId.prefix "issuedDay"
    /// <summary>
    ///   <para>rdfs:label : issued time^^xsd:string</para>
    ///   <para>rdfs:comment : The time when the traffic management initiative (TMI) was issued.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#issuedTime">atm:issuedTime</a>
    /// </summary>
    let issuedTime = _prefixId.prefix "issuedTime"
    /// <summary>
    ///   <para>rdfs:label : located in sector^^xsd:string</para>
    ///   <para>rdfs:comment : Links a navigation fix to the airspace sector in which that fix is located.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#locatedInSector">atm:locatedInSector</a>
    /// </summary>
    let locatedInSector = _prefixId.prefix "locatedInSector"
    /// <summary>
    ///   <para>rdfs:label : max flow capacity^^xsd:string</para>
    ///   <para>rdfs:comment : The absolute maximum controllable number of aircraft flowing through an airspace region per some interval of time under any air traffic conditions.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#maxFlowCapacity">atm:maxFlowCapacity</a>
    /// </summary>
    let maxFlowCapacity = _prefixId.prefix "maxFlowCapacity"
    /// <summary>
    ///   <para>rdfs:label : modeled arrival rate^^xsd:string</para>
    ///   <para>rdfs:comment : Links a delay model used in defining a Ground Delay Program (GDP) or Ground Stop(GS) to a sequence of desired hourly aircraft arrival rates specified for the initiative.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#modeledArrivalRate">atm:modeledArrivalRate</a>
    /// </summary>
    let modeledArrivalRate = _prefixId.prefix "modeledArrivalRate"
    /// <summary>
    ///   <para>rdfs:label : modeled average delay minutes^^xsd:string</para>
    ///   <para>rdfs:comment : The average flight delay specified when modeling a Ground Delay Program (GDP) or Ground Stop(GS).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#modeledAverageDelay">atm:modeledAverageDelay</a>
    /// </summary>
    let modeledAverageDelay = _prefixId.prefix "modeledAverageDelay"
    /// <summary>
    ///   <para>rdfs:label : modeled by^^xsd:string</para>
    ///   <para>rdfs:comment : Links a Ground Delay Program (GDP) or a Ground Stop (GS) to a representation of the model used to design that initiative. The model contains all relevant parameters used to create the initiative.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#modeledBy">atm:modeledBy</a>
    /// </summary>
    let modeledBy = _prefixId.prefix "modeledBy"
    /// <summary>
    ///   <para>rdfs:label : modeled maximum delay minutes^^xsd:string</para>
    ///   <para>rdfs:comment : The maximum flight delay specified when modeling a Ground Delay Program (GDP) or Ground Stop(GS).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#modeledMaximumDelay">atm:modeledMaximumDelay</a>
    /// </summary>
    let modeledMaximumDelay = _prefixId.prefix "modeledMaximumDelay"
    /// <summary>
    ///   <para>rdfs:label : modeled pop up factor^^xsd:string</para>
    ///   <para>rdfs:comment : Links a delay model used in defining a Ground Delay Program (GDP) or Ground Stop(GS) to a sequence of desired hourly popup factors specified for the initiative. 'Popups' account for late-filing flights (unexpected/unplanned flights) when modeling delays as part of a traffic management initiative (TMI) design process.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#modeledPopUpFactor">atm:modeledPopUpFactor</a>
    /// </summary>
    let modeledPopUpFactor = _prefixId.prefix "modeledPopUpFactor"
    /// <summary>
    ///   <para>rdfs:label : modeled total delay minutes^^xsd:string</para>
    ///   <para>rdfs:comment : The total flight delay specified when modeling a Ground Delay Program (GDP) or Ground Stop(GS).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#modeledTotalDelay">atm:modeledTotalDelay</a>
    /// </summary>
    let modeledTotalDelay = _prefixId.prefix "modeledTotalDelay"
    /// <summary>
    ///   <para>rdfs:label : must have destination^^xsd:string</para>
    ///   <para>rdfs:comment : Links a flight specification to an airport specification describing the destination airports for the flights being specified. Any flight covered by the flight specification must have as its destination one of the airports covered by the airport specification.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#mustHaveDestination">atm:mustHaveDestination</a>
    /// </summary>
    let mustHaveDestination = _prefixId.prefix "mustHaveDestination"
    /// <summary>
    ///   <para>rdfs:label : must have origin^^xsd:string</para>
    ///   <para>rdfs:comment : Links a flight specification to an airport specification describing the originating airports for the flights being specified. Any flight covered by the flight specification must have as its origin one of the airports covered by the airport specification.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#mustHaveOrigin">atm:mustHaveOrigin</a>
    /// </summary>
    let mustHaveOrigin = _prefixId.prefix "mustHaveOrigin"
    /// <summary>
    ///   <para>rdfs:label : operated by^^xsd:string</para>
    ///   <para>rdfs:comment : Links a flight to its carrier airline.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#operatedBy">atm:operatedBy</a>
    /// </summary>
    let operatedBy = _prefixId.prefix "operatedBy"
    /// <summary>
    ///   <para>rdfs:label : operating carrier^^xsd:string</para>
    ///   <para>rdfs:comment : Links a flight specification to one or more carrier airline(s). Each flight covered by the specification must be operated by one of these carriers.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#operatingCarrier">atm:operatingCarrier</a>
    /// </summary>
    let operatingCarrier = _prefixId.prefix "operatingCarrier"
    /// <summary>
    ///   <para>rdfs:label : operating time interval^^xsd:string</para>
    ///   <para>rdfs:comment : Links a flight specification to a time interval. Each flight covered by the specification must be airborne sometime during the time period specified by the interval.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#operatingTimeInterval">atm:operatingTimeInterval</a>
    /// </summary>
    let operatingTimeInterval = _prefixId.prefix "operatingTimeInterval"
    /// <summary>
    ///   <para>rdfs:label : plan filing day^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the day when the flight plan was filed with the FAA.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#planFilingDay">atm:planFilingDay</a>
    /// </summary>
    let planFilingDay = _prefixId.prefix "planFilingDay"
    /// <summary>
    ///   <para>rdfs:label : plan filing time^^xsd:string</para>
    ///   <para>rdfs:comment : The time that the flight plan was filed with the FAA.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#planFilingTime">atm:planFilingTime</a>
    /// </summary>
    let planFilingTime = _prefixId.prefix "planFilingTime"

    /// <summary>
    ///   <para>rdfs:label : plan gap after sequence element number^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the location of a gap in the flight plan due to non-parsable/uninterpretable elements in the flight plan string.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#planGapAfterSequenceElementNumber">atm:planGapAfterSequenceElementNumber</a>
    /// </summary>
    let planGapAfterSequenceElementNumber =
        _prefixId.prefix "planGapAfterSequenceElementNumber"

    /// <summary>
    ///   <para>rdfs:label : planned arrival day^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the day that the flight is planned to arrive per the flight plan.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#plannedArrivalDay">atm:plannedArrivalDay</a>
    /// </summary>
    let plannedArrivalDay = _prefixId.prefix "plannedArrivalDay"
    /// <summary>
    ///   <para>rdfs:label : planned arrival time^^xsd:string</para>
    ///   <para>rdfs:comment : The time that the flight is planned to arrive per the flight plan.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#plannedArrivalTime">atm:plannedArrivalTime</a>
    /// </summary>
    let plannedArrivalTime = _prefixId.prefix "plannedArrivalTime"
    /// <summary>
    ///   <para>rdfs:label : planned departure day^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the day that the flight is planned to depart per the flight plan.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#plannedDepartureDay">atm:plannedDepartureDay</a>
    /// </summary>
    let plannedDepartureDay = _prefixId.prefix "plannedDepartureDay"
    /// <summary>
    ///   <para>rdfs:label : planned departure time^^xsd:string</para>
    ///   <para>rdfs:comment : The time that the flight is planned to depart per the flight plan.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#plannedDepartureTime">atm:plannedDepartureTime</a>
    /// </summary>
    let plannedDepartureTime = _prefixId.prefix "plannedDepartureTime"
    /// <summary>
    ///   <para>rdfs:label : previous average delay minutes^^xsd:string</para>
    ///   <para>rdfs:comment : The average flight delay experienced prior to the start of a Ground Stop(GS).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#prevAverageDelay">atm:prevAverageDelay</a>
    /// </summary>
    let prevAverageDelay = _prefixId.prefix "prevAverageDelay"
    /// <summary>
    ///   <para>rdfs:label : previous maximum delay minutes^^xsd:string</para>
    ///   <para>rdfs:comment : The maximum flight delay experienced prior to the start of a Ground Stop(GS).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#prevMaximumDelay">atm:prevMaximumDelay</a>
    /// </summary>
    let prevMaximumDelay = _prefixId.prefix "prevMaximumDelay"
    /// <summary>
    ///   <para>rdfs:label : previous total delay minutes^^xsd:string</para>
    ///   <para>rdfs:comment : The total flight delay experienced prior to the start of a Ground Stop(GS).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#prevTotalDelay">atm:prevTotalDelay</a>
    /// </summary>
    let prevTotalDelay = _prefixId.prefix "prevTotalDelay"
    /// <summary>
    ///   <para>rdfs:label : published arrival day^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the day that the flight is planned to arrive per the OAG schedule.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#publishedArrivalDay">atm:publishedArrivalDay</a>
    /// </summary>
    let publishedArrivalDay = _prefixId.prefix "publishedArrivalDay"
    /// <summary>
    ///   <para>rdfs:label : published arrival time^^xsd:string</para>
    ///   <para>rdfs:comment : The time that the flight is planned to arrive per the OAG schedule.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#publishedArrivalTime">atm:publishedArrivalTime</a>
    /// </summary>
    let publishedArrivalTime = _prefixId.prefix "publishedArrivalTime"
    /// <summary>
    ///   <para>rdfs:label : published departure day^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the day that the flight is planned to depart per the OAG schedule.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#publishedDepartureDay">atm:publishedDepartureDay</a>
    /// </summary>
    let publishedDepartureDay = _prefixId.prefix "publishedDepartureDay"
    /// <summary>
    ///   <para>rdfs:label : published departure time^^xsd:string</para>
    ///   <para>rdfs:comment : The time that the flight is planned to depart per the OAG schedule.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#publishedDepartureTime">atm:publishedDepartureTime</a>
    /// </summary>
    let publishedDepartureTime = _prefixId.prefix "publishedDepartureTime"
    /// <summary>
    ///   <para>rdfs:label : radial angle^^xsd:string</para>
    ///   <para>rdfs:comment : The angle (in degrees) that defines the radial route's angular position with respect to the defined fix.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#radialAngle">atm:radialAngle</a>
    /// </summary>
    let radialAngle = _prefixId.prefix "radialAngle"
    /// <summary>
    ///   <para>rdfs:label : radial fix^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the fix through which the radial route passes.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#radialFix">atm:radialFix</a>
    /// </summary>
    let radialFix = _prefixId.prefix "radialFix"
    /// <summary>
    ///   <para>rdfs:label : reroute constraint^^xsd:string</para>
    ///   <para>rdfs:comment : Links a route segment specified as part of a ReRoute traffic management initiative (TMI) to a flight specification indicating which flights are permitted to follow the route segment.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#reRouteConstraint">atm:reRouteConstraint</a>
    /// </summary>
    let reRouteConstraint = _prefixId.prefix "reRouteConstraint"
    /// <summary>
    ///   <para>rdfs:label : re route path^^xsd:string</para>
    ///   <para>rdfs:comment : Links a route segment alternative (specified as part of a ReRoute traffic management initiative) to its associated flight plan.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#reRoutePath">atm:reRoutePath</a>
    /// </summary>
    let reRoutePath = _prefixId.prefix "reRoutePath"
    /// <summary>
    ///   <para>rdfs:label : reroute reason^^xsd:string</para>
    ///   <para>rdfs:comment : Provides the reason for initiating a ReRoute: WEATHER , VOLUME , EQUIPMENT , RUNWAY/TAXIWAY , OTHER.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#reRouteReason">atm:reRouteReason</a>
    /// </summary>
    let reRouteReason = _prefixId.prefix "reRouteReason"
    /// <summary>
    ///   <para>rdfs:label : re route segment type^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates which type of ReRoute segment: origin , destination, origin-destination. A ReRoute segment can be a entire route between origin and destination, or a partial route leading from an origin or leading to a destination.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#reRouteSegmentType">atm:reRouteSegmentType</a>
    /// </summary>
    let reRouteSegmentType = _prefixId.prefix "reRouteSegmentType"
    /// <summary>
    ///   <para>rdfs:label : ReRoute time type^^xsd:string</para>
    ///   <para>rdfs:comment : The time period associated with the reroute is specified in one of three ways. The reroute can apply to flights that: depart specified airports or centers during a certain time window (timeType=ETD); depart specified airports or centers to arrive at their destinations during a certain time window (timeType=ETA); or arrive at the boundary of a flow constrained area during a certain time window (timeType=FCA Flight List).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#reRouteTimeType">atm:reRouteTimeType</a>
    /// </summary>
    let reRouteTimeType = _prefixId.prefix "reRouteTimeType"
    /// <summary>
    ///   <para>rdfs:label : ReRoute type^^xsd:string</para>
    ///   <para>rdfs:comment : The ReRoute type encodes information about the type of ReRoute being initiated or the reason for the ReRoute. One of the following: ROUTE , PLAYBOOK , CDR, SPECIAL OPERATIONS, NRP SUSPENSIONS, VS , NAT, SHUTTLE ACTIVITY, FCA, FEA, INFORMATIONAL, MISCELLANEOUS.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#reRouteType">atm:reRouteType</a>
    /// </summary>
    let reRouteType = _prefixId.prefix "reRouteType"
    /// <summary>
    ///   <para>rdfs:comment : Links a relative fix to the absolute fix that serves as the basis for its location. (A relative fix position is defined relative to an absolute fix position, e.g. as a vector offset from the absolute fix.)^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#referenceFix">atm:referenceFix</a>
    /// </summary>
    let referenceFix = _prefixId.prefix "referenceFix"
    /// <summary>
    ///   <para>rdfs:label : relative angle^^xsd:string</para>
    ///   <para>rdfs:comment : The angular direction in degrees (1-360) of a relative fix with respect to its defining absolute fix.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#relativeAngle">atm:relativeAngle</a>
    /// </summary>
    let relativeAngle = _prefixId.prefix "relativeAngle"
    /// <summary>
    ///   <para>rdfs:label : relative distance^^xsd:string</para>
    ///   <para>rdfs:comment : The distance (in nautical miles) between a relative fix and its defining (absolute) fix.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#relativeDistance">atm:relativeDistance</a>
    /// </summary>
    let relativeDistance = _prefixId.prefix "relativeDistance"
    /// <summary>
    ///   <para>rdfs:label : reporting day^^xsd:string</para>
    ///   <para>rdfs:comment : A link between an aircraft track point and the day during which an en route aircraft traversed that point and reported its position, speed, and heading.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#reportingDay">atm:reportingDay</a>
    /// </summary>
    let reportingDay = _prefixId.prefix "reportingDay"
    /// <summary>
    ///   <para>rdfs:label : reporting time^^xsd:string</para>
    ///   <para>rdfs:comment : The time when an en route aircraft passed through a trackpoint and reported its position, speed, and heading.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#reportingTime">atm:reportingTime</a>
    /// </summary>
    let reportingTime = _prefixId.prefix "reportingTime"
    /// <summary>
    ///   <para>rdfs:label : time constraint type^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the type of flight time being constrained in this flight specification: either ETA (estimated arrival time) or ETD (estimated departure time).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#timeConstraintType">atm:timeConstraintType</a>
    /// </summary>
    let timeConstraintType = _prefixId.prefix "timeConstraintType"
    /// <summary>
    ///   <para>rdfs:label : tracon ID^^xsd:string</para>
    ///   <para>rdfs:comment : Three letter FAA TRACON identifier code.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#traconID">atm:traconID</a>
    /// </summary>
    let traconID = _prefixId.prefix "traconID"
    /// <summary>
    ///   <para>rdfs:label : traverses SIDSTAR^^xsd:string</para>
    ///   <para>rdfs:comment : Links a SIDSTARtraverse (i.e., a specific route through a SID or STAR) to the specific SID or STAR being traversed by a given flight.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#traversesSIDSTAR">atm:traversesSIDSTAR</a>
    /// </summary>
    let traversesSIDSTAR = _prefixId.prefix "traversesSIDSTAR"
    /// <summary>
    ///   <para>rdfs:label : true airspeed^^xsd:string</para>
    ///   <para>rdfs:comment : The true airspeed of a flight: the speed of the aircraft relative to the airmass in which it is flying.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#trueAirspeed">atm:trueAirspeed</a>
    /// </summary>
    let trueAirspeed = _prefixId.prefix "trueAirspeed"
    /// <summary>
    ///   <para>rdfs:label : user category^^xsd:string</para>
    ///   <para>rdfs:comment : The type of airspace user that this flight represents: GA, Air Taxi, Cargo, Commercial, Military. Also used to constrain a flight specification to contain only flights representing a specific user category.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#userCategory">atm:userCategory</a>
    /// </summary>
    let userCategory = _prefixId.prefix "userCategory"
    /// <summary>
    ///   <para>rdfs:label : uses airport route^^xsd:string</para>
    ///   <para>rdfs:comment : Links a SIDSTARtraverse (a path through a SID/STAR) to the airport route used in making the traverse.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#usesAirportRoute">atm:usesAirportRoute</a>
    /// </summary>
    let usesAirportRoute = _prefixId.prefix "usesAirportRoute"
    /// <summary>
    ///   <para>rdfs:label : uses transition route^^xsd:string</para>
    ///   <para>rdfs:comment : Links a SIDSTARtraverse (a path through a SID/STAR) to the transition route used in making the traverse.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#usesTransitionRoute">atm:usesTransitionRoute</a>
    /// </summary>
    let usesTransitionRoute = _prefixId.prefix "usesTransitionRoute"
    /// <summary>
    ///   <para>rdfs:label : within ARTCC^^xsd:string</para>
    ///   <para>rdfs:comment : Links an airport specification to an ARTCC or ARTCC tier. Only airports within the ARTCC or ARTCC tier are covered by the specification.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#withinARTCC">atm:withinARTCC</a>
    /// </summary>
    let withinARTCC = _prefixId.prefix "withinARTCC"
    /// <summary>
    ///   <para>rdfs:label : within airport bounding region^^xsd:string</para>
    ///   <para>rdfs:comment : Links an airport specification to a circular geographic region. Only airports whose locations fall within this region satisfy the specification.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/ATM#withinAirportBoundingRegion">atm:withinAirportBoundingRegion</a>
    /// </summary>
    let withinAirportBoundingRegion = _prefixId.prefix "withinAirportBoundingRegion"
