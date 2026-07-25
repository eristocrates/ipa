namespace https.data.nasa.gov.ontologies.atmonto.ATM.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module atm =
    let _namespace_iri = Namespace_Iri atm |> NamespaceIRI
    /// <summary>
    ///   <para>atm:AbsoluteFix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fix based on some established global measuring scheme.</para>
    /// labels<para>Absolute fix</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#AbsoluteFix">https://data.nasa.gov/ontologies/atmonto/ATM#AbsoluteFix</seealso>
    let AbsoluteFix = Prefixed_Name(atm, "AbsoluteFix") |> PrefixedName

    /// <summary>
    ///   <para>atm:AirspaceRouteSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A contiguous portion of an existing airspace route.</para>
    /// labels<para>Airspace route segment</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#AirspaceRouteSegment">https://data.nasa.gov/ontologies/atmonto/ATM#AirspaceRouteSegment</seealso>
    let AirspaceRouteSegment =
        Prefixed_Name(atm, "AirspaceRouteSegment") |> PrefixedName

    /// <summary>
    ///   <para>atm:FRDfix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Fix Radial Distance (FRD) fix is located a specified distance from a ground-based navaid, a named fix, or an airport, along a given radial vector.</para>
    /// labels<para>FRD Fix</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#FRDfix">https://data.nasa.gov/ontologies/atmonto/ATM#FRDfix</seealso>
    let FRDfix = Prefixed_Name(atm, "FRDfix") |> PrefixedName
    /// <summary>
    ///   <para>atm:userCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of airspace user that this flight represents: GA, Air Taxi, Cargo, Commercial, Military. Also used to constrain a flight specification to contain only flights representing a specific user category.</para>
    /// labels<para>user category</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#userCategory">https://data.nasa.gov/ontologies/atmonto/ATM#userCategory</seealso>
    let userCategory = Prefixed_Name(atm, "userCategory") |> PrefixedName
    /// <summary>
    ///   <para>atm:PlannedFlightRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A planned flight route is an ordered sequence of navigation elements that the pilot intends to traverse en route from origin to destination airport.</para>
    /// labels<para>Planned flight route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#PlannedFlightRoute">https://data.nasa.gov/ontologies/atmonto/ATM#PlannedFlightRoute</seealso>
    let PlannedFlightRoute = Prefixed_Name(atm, "PlannedFlightRoute") |> PrefixedName
    /// <summary>
    ///   <para>atm:FlightSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A specification describing a set of flights.</para>
    /// labels<para>Flight spec</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#FlightSpec">https://data.nasa.gov/ontologies/atmonto/ATM#FlightSpec</seealso>
    let FlightSpec = Prefixed_Name(atm, "FlightSpec") |> PrefixedName

    /// <summary>
    ///   <para>atm:PopupFactorContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A wrapper around a popup factor parameter. Used to sequence popup factors in the specification of a Ground Delay Program (GDP).</para>
    /// labels<para>Popup Factor container</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#PopupFactorContainer">https://data.nasa.gov/ontologies/atmonto/ATM#PopupFactorContainer</seealso>
    let PopupFactorContainer =
        Prefixed_Name(atm, "PopupFactorContainer") |> PrefixedName

    /// <summary>
    ///   <para>atm:ProgramArrivalRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The number of aircraft that the Ground Delay Program (GDP) is to provide to the airport for a given hour.</para>
    /// labels<para>Program arrival rate</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#ProgramArrivalRate">https://data.nasa.gov/ontologies/atmonto/ATM#ProgramArrivalRate</seealso>
    let ProgramArrivalRate = Prefixed_Name(atm, "ProgramArrivalRate") |> PrefixedName
    /// <summary>
    ///   <para>atm:ReRouteSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>One of the route segment alternatives specified as part of a ReRoute traffic management initiative (TMI).</para>
    /// labels<para>ReRoute segment</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#ReRouteSegment">https://data.nasa.gov/ontologies/atmonto/ATM#ReRouteSegment</seealso>
    let ReRouteSegment = Prefixed_Name(atm, "ReRouteSegment") |> PrefixedName
    /// <summary>
    ///   <para>atm:ReRouteTMI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A ReRoute is a traffic management initiative (TMI) that mandates a change in the filed flight plan for a set of specified flights. There are multiple factors that might justify a reroute, including weather, traffic congestion, unusual airspace activity, etc. The substitute flight plans route air traffic around the airspace problem area.</para>
    /// labels<para>ReRoute</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#ReRouteTMI">https://data.nasa.gov/ontologies/atmonto/ATM#ReRouteTMI</seealso>
    let ReRouteTMI = Prefixed_Name(atm, "ReRouteTMI") |> PrefixedName
    /// <summary>
    ///   <para>atm:aircraftFlown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Links a flight with the actual aircraft used.</para>
    /// labels<para>aircraft flown</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#aircraftFlown">https://data.nasa.gov/ontologies/atmonto/ATM#aircraftFlown</seealso>
    let aircraftFlown = Prefixed_Name(atm, "aircraftFlown") |> PrefixedName
    /// <summary>
    ///   <para>atm:aircraftTypeFlown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a flight with the type of aircraft flown. The aircraft 'type' corresponds to a set of aircraft models with similar characteristics.</para>
    /// labels<para>aircraft type flown</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#aircraftTypeFlown">https://data.nasa.gov/ontologies/atmonto/ATM#aircraftTypeFlown</seealso>
    let aircraftTypeFlown = Prefixed_Name(atm, "aircraftTypeFlown") |> PrefixedName

    /// <summary>
    ///   <para>atm:alternateArrivalAirport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the alternate arrival airport to be used in case of weather, traffic, or other unforseen contingency. The alternate airport is specified in the flight plan.</para>
    /// labels<para>alternate arrival airport</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#alternateArrivalAirport">https://data.nasa.gov/ontologies/atmonto/ATM#alternateArrivalAirport</seealso>
    let alternateArrivalAirport =
        Prefixed_Name(atm, "alternateArrivalAirport") |> PrefixedName

    /// <summary>
    ///   <para>atm:arrivalAirport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the actual arrival airport for the flight.</para>
    /// labels<para>arrival airport</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#arrivalAirport">https://data.nasa.gov/ontologies/atmonto/ATM#arrivalAirport</seealso>
    let arrivalAirport = Prefixed_Name(atm, "arrivalAirport") |> PrefixedName
    /// <summary>
    ///   <para>atm:arrivalRunway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Links to the actual arrival runway for the flight.</para>
    /// labels<para>arrival runway</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#arrivalRunway">https://data.nasa.gov/ontologies/atmonto/ATM#arrivalRunway</seealso>
    let arrivalRunway = Prefixed_Name(atm, "arrivalRunway") |> PrefixedName
    /// <summary>
    ///   <para>atm:cruisingAltitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The cruising altitude (in number of feet) specified in the flight plan for this flight.</para>
    /// labels<para>cruising altitude</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#cruisingAltitude">https://data.nasa.gov/ontologies/atmonto/ATM#cruisingAltitude</seealso>
    let cruisingAltitude = Prefixed_Name(atm, "cruisingAltitude") |> PrefixedName
    /// <summary>
    ///   <para>atm:departureTaxiPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the taxipath followed by the flight en route to the runway.</para>
    /// labels<para>departure taxi path</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#departureTaxiPath">https://data.nasa.gov/ontologies/atmonto/ATM#departureTaxiPath</seealso>
    let departureTaxiPath = Prefixed_Name(atm, "departureTaxiPath") |> PrefixedName
    /// <summary>
    ///   <para>atm:excludesARTCC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an airport specification to one of more ARTCCs (Centers) or ARTCC tiers (Centers radiating out from a give ARTCC). Any airport within the ARTCC or ARTCC tier is excluded from the set of airports covered by this airport specification.</para>
    /// labels<para>excludes ARTCC</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#excludesARTCC">https://data.nasa.gov/ontologies/atmonto/ATM#excludesARTCC</seealso>
    let excludesARTCC = Prefixed_Name(atm, "excludesARTCC") |> PrefixedName
    /// <summary>
    ///   <para>atm:usesAirportRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a SIDSTARtraverse (a path through a SID/STAR) to the airport route used in making the traverse.</para>
    /// labels<para>uses airport route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#usesAirportRoute">https://data.nasa.gov/ontologies/atmonto/ATM#usesAirportRoute</seealso>
    let usesAirportRoute = Prefixed_Name(atm, "usesAirportRoute") |> PrefixedName
    /// <summary>
    ///   <para>atm:ActualFlightRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A flight trajectory (i.e., a sequence of track points), as determined by flight track surveillance data.</para>
    /// labels<para>Actual Flight Route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#ActualFlightRoute">https://data.nasa.gov/ontologies/atmonto/ATM#ActualFlightRoute</seealso>
    let ActualFlightRoute = Prefixed_Name(atm, "ActualFlightRoute") |> PrefixedName
    /// <summary>
    ///   <para>atm:AircraftFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A subclass of interval-based data representing the number of aircraft flowing through an airspace region during some interval of time.</para>
    /// labels<para>Aircraft flow</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#AircraftFlow">https://data.nasa.gov/ontologies/atmonto/ATM#AircraftFlow</seealso>
    let AircraftFlow = Prefixed_Name(atm, "AircraftFlow") |> PrefixedName
    /// <summary>
    ///   <para>atm:includesAirportType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates which type of airports are included in the set of airports covered by this airport specification: all, US, CONUS, NonCONUS, International, Canadian. This property allows for the implicit specification of an entire class of airports; the property atm:includesAirport allows for the explicit specification of a list of specific airports.</para>
    /// labels<para>includes airport type</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#includesAirportType">https://data.nasa.gov/ontologies/atmonto/ATM#includesAirportType</seealso>
    let includesAirportType = Prefixed_Name(atm, "includesAirportType") |> PrefixedName
    /// <summary>
    ///   <para>atm:GroundStopTMI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Ground Stop (GS) traffic management initiative (TMI). A ground stop is a procedure requiring aircraft that meet specific criteria to remain on the ground. The GS may be airport specific, related to a geographical area, or equipment related.</para>
    /// labels<para>Ground Stop (GS)</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#GroundStopTMI">https://data.nasa.gov/ontologies/atmonto/ATM#GroundStopTMI</seealso>
    let GroundStopTMI = Prefixed_Name(atm, "GroundStopTMI") |> PrefixedName
    /// <summary>
    ///   <para>atm:effectiveStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The expected start time of the traffic management initiative (TMI).</para>
    /// labels<para>effective start time</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#effectiveStartTime">https://data.nasa.gov/ontologies/atmonto/ATM#effectiveStartTime</seealso>
    let effectiveStartTime = Prefixed_Name(atm, "effectiveStartTime") |> PrefixedName
    /// <summary>
    ///   <para>atm:excludesAirport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an airport specification to one of more airports. Any airport linked is excluded from the set of airports covered by this airport specification.</para>
    /// labels<para>excludes airport</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#excludesAirport">https://data.nasa.gov/ontologies/atmonto/ATM#excludesAirport</seealso>
    let excludesAirport = Prefixed_Name(atm, "excludesAirport") |> PrefixedName
    /// <summary>
    ///   <para>atm:exemptedAFP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a flight specification to one of more Airspace Flow Program (AFP) traffic management initiatives (TMIs). Any flight included in one of the linked AFPs is excluded from the set of flights covered by this flight specification.</para>
    /// labels<para>exempted AFP</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#exemptedAFP">https://data.nasa.gov/ontologies/atmonto/ATM#exemptedAFP</seealso>
    let exemptedAFP = Prefixed_Name(atm, "exemptedAFP") |> PrefixedName
    /// <summary>
    ///   <para>atm:fixTrajectoryString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This is an experimental property of a flight that stores an ordered sequence of named fixes corresponding one-to-one to the sequence of trajectory track points recorded for the flight. For a given track point, the corresponding named fix is computed by finding the closest named fix to the track point.</para>
    /// labels<para>fix trajectory string</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#fixTrajectoryString">https://data.nasa.gov/ontologies/atmonto/ATM#fixTrajectoryString</seealso>
    let fixTrajectoryString = Prefixed_Name(atm, "fixTrajectoryString") |> PrefixedName
    /// <summary>
    ///   <para>atm:flightExclusionSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a Ground Delay Program (GDP) or a Ground Stop (GS) to a specification of the flight(s) excluded from the traffic management initiative (TMI).</para>
    /// labels<para>flight exclusion spec</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#flightExclusionSpec">https://data.nasa.gov/ontologies/atmonto/ATM#flightExclusionSpec</seealso>
    let flightExclusionSpec = Prefixed_Name(atm, "flightExclusionSpec") |> PrefixedName
    /// <summary>
    ///   <para>atm:flightPlanETA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The estimated time of arrival specified in the flight plan.</para>
    /// labels<para>flight plan ETA</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#flightPlanETA">https://data.nasa.gov/ontologies/atmonto/ATM#flightPlanETA</seealso>
    let flightPlanETA = Prefixed_Name(atm, "flightPlanETA") |> PrefixedName

    /// <summary>
    ///   <para>atm:flowMeasurementRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an aircraft capacity or aircraft flow to the spatial region through which flow or capacity is being monitored and measured.</para>
    /// labels<para>flow measurement region</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#flowMeasurementRegion">https://data.nasa.gov/ontologies/atmonto/ATM#flowMeasurementRegion</seealso>
    let flowMeasurementRegion =
        Prefixed_Name(atm, "flowMeasurementRegion") |> PrefixedName

    /// <summary>
    ///   <para>atm:hasActualRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a flight to its actual trajectory (i.e., a sequence of track points), as determined by flight track surveillance data.</para>
    /// labels<para>has actual route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#hasActualRoute">https://data.nasa.gov/ontologies/atmonto/ATM#hasActualRoute</seealso>
    let hasActualRoute = Prefixed_Name(atm, "hasActualRoute") |> PrefixedName
    /// <summary>
    ///   <para>atm:hasPlannedRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a flight to a version of its flight plan. (Which version gets stored is application-dependent.) There are multiple versions of the flight plan generated and then amended during the course of the flight, starting in the pre-flight timeframe and extending through to the termination of the flight.</para>
    /// labels<para>has planned route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#hasPlannedRoute">https://data.nasa.gov/ontologies/atmonto/ATM#hasPlannedRoute</seealso>
    let hasPlannedRoute = Prefixed_Name(atm, "hasPlannedRoute") |> PrefixedName

    /// <summary>
    ///   <para>atm:planGapAfterSequenceElementNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the location of a gap in the flight plan due to non-parsable/uninterpretable elements in the flight plan string.</para>
    /// labels<para>plan gap after sequence element number</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#planGapAfterSequenceElementNumber">https://data.nasa.gov/ontologies/atmonto/ATM#planGapAfterSequenceElementNumber</seealso>
    let planGapAfterSequenceElementNumber =
        Prefixed_Name(atm, "planGapAfterSequenceElementNumber") |> PrefixedName

    /// <summary>
    ///   <para>atm:AircraftFlowCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A subclass of interval-based data representing the maximum controllable number of aircraft flowing through an airspace region during some interval of time, given weather and other air traffic control constraints.</para>
    /// labels<para>Aircraft flow capacity</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#AircraftFlowCapacity">https://data.nasa.gov/ontologies/atmonto/ATM#AircraftFlowCapacity</seealso>
    let AircraftFlowCapacity =
        Prefixed_Name(atm, "AircraftFlowCapacity") |> PrefixedName

    /// <summary>
    ///   <para>atm:AirportFix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A subclass of navigation fix corresponding to fixes associated directly with a ground reference point that is an airport.</para>
    /// labels<para>Airport Fix</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#AirportFix">https://data.nasa.gov/ontologies/atmonto/ATM#AirportFix</seealso>
    let AirportFix = Prefixed_Name(atm, "AirportFix") |> PrefixedName
    /// <summary>
    ///   <para>atm:DelayModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a computational delay model used in assigning times to the aircraft involved in the GDP or GS. The properties of this class correspond to parameters that are used by the delay model to compute the delay times.</para>
    /// labels<para>GDPmodel</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#DelayModel">https://data.nasa.gov/ontologies/atmonto/ATM#DelayModel</seealso>
    let DelayModel = Prefixed_Name(atm, "DelayModel") |> PrefixedName
    /// <summary>
    ///   <para>atm:PopupFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Factor to account for late-filing flights when modeling delays as part of a traffic management initiative (TMI) design process.</para>
    /// labels<para>Popup factor</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#PopupFactor">https://data.nasa.gov/ontologies/atmonto/ATM#PopupFactor</seealso>
    let PopupFactor = Prefixed_Name(atm, "PopupFactor") |> PrefixedName
    /// <summary>
    ///   <para>atm:adlTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The timestamp of the ADL (Aggregate Demand List) that the delay model is based upon. Each ADL contains information on the flights arriving and departing from an airport, or entering into and departing from a flow area.</para>
    /// labels<para>adl time</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#adlTime">https://data.nasa.gov/ontologies/atmonto/ATM#adlTime</seealso>
    let adlTime = Prefixed_Name(atm, "adlTime") |> PrefixedName
    /// <summary>
    ///   <para>atm:AircraftCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A subclass of interval-based data representing the maximum number of controllable aircraft flowing through an airspace region during some interval of time.</para>
    /// labels<para>Aircraft capacity</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#AircraftCapacity">https://data.nasa.gov/ontologies/atmonto/ATM#AircraftCapacity</seealso>
    let AircraftCapacity = Prefixed_Name(atm, "AircraftCapacity") |> PrefixedName
    /// <summary>
    ///   <para>atm:VORfix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fix based on the location of a ground-based VOR (VHF Omni Directional Radio Range) installation.</para>
    /// labels<para>VOR Fix</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#VORfix">https://data.nasa.gov/ontologies/atmonto/ATM#VORfix</seealso>
    let VORfix = Prefixed_Name(atm, "VORfix") |> PrefixedName
    /// <summary>
    ///   <para>atm:AirportSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A specification of a set of airports.</para>
    /// labels<para>Airport spec</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#AirportSpec">https://data.nasa.gov/ontologies/atmonto/ATM#AirportSpec</seealso>
    let AirportSpec = Prefixed_Name(atm, "AirportSpec") |> PrefixedName

    /// <summary>
    ///   <para>atm:AirspaceFlowProgramTMI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A subclass of Traffic Management Initiative involving control and metering of air traffic through specified airspace volumes.</para>
    /// labels<para>Airspace Flow Program (AFP)</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#AirspaceFlowProgramTMI">https://data.nasa.gov/ontologies/atmonto/ATM#AirspaceFlowProgramTMI</seealso>
    let AirspaceFlowProgramTMI =
        Prefixed_Name(atm, "AirspaceFlowProgramTMI") |> PrefixedName

    /// <summary>
    ///   <para>atm:TrafficManagementInitiative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Traffic Management Initiative (TMI) is an orchestrated air traffic management procedure implemented as needed to control the flow of air traffic in the NAS based on capacity and demand.</para>
    /// labels<para>Traffic management initiative</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#TrafficManagementInitiative">https://data.nasa.gov/ontologies/atmonto/ATM#TrafficManagementInitiative</seealso>
    let TrafficManagementInitiative =
        Prefixed_Name(atm, "TrafficManagementInitiative") |> PrefixedName

    /// <summary>
    ///   <para>atm:delayAssignmentMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of delay assignment mode specified for this delay model: DAS, GAAP, or UDP.</para>
    /// labels<para>delay assignment mode</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#delayAssignmentMode">https://data.nasa.gov/ontologies/atmonto/ATM#delayAssignmentMode</seealso>
    let delayAssignmentMode = Prefixed_Name(atm, "delayAssignmentMode") |> PrefixedName
    /// <summary>
    ///   <para>atm:GPSfix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A navigation fix defined by GPS coordinates.</para>
    /// labels<para>GPS fix</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#GPSfix">https://data.nasa.gov/ontologies/atmonto/ATM#GPSfix</seealso>
    let GPSfix = Prefixed_Name(atm, "GPSfix") |> PrefixedName
    /// <summary>
    ///   <para>atm:LatLonFix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A navigation fix based on latitude/longitude coordinates.</para>
    /// labels<para>Lat-lon fix</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#LatLonFix">https://data.nasa.gov/ontologies/atmonto/ATM#LatLonFix</seealso>
    let LatLonFix = Prefixed_Name(atm, "LatLonFix") |> PrefixedName

    /// <summary>
    ///   <para>atm:controlledNASelement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a traffic management initiative (TMI) to the airspace element being controlled by the TMI (e.g., an airport).</para>
    /// labels<para>controlled NASelement</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#controlledNASelement">https://data.nasa.gov/ontologies/atmonto/ATM#controlledNASelement</seealso>
    let controlledNASelement =
        Prefixed_Name(atm, "controlledNASelement") |> PrefixedName

    /// <summary>
    ///   <para>atm:impactingCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the reason for initiating the Ground Delay Program: weather, volume, runway, equipment, other.</para>
    /// labels<para>impacting condition</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#impactingCondition">https://data.nasa.gov/ontologies/atmonto/ATM#impactingCondition</seealso>
    let impactingCondition = Prefixed_Name(atm, "impactingCondition") |> PrefixedName

    /// <summary>
    ///   <para>atm:extensionProbability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The probability that this traffic management initiative (TMI) will be extended: LOW, MEDIUM, or HIGH.</para>
    /// labels<para>extension probability</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#extensionProbability">https://data.nasa.gov/ontologies/atmonto/ATM#extensionProbability</seealso>
    let extensionProbability =
        Prefixed_Name(atm, "extensionProbability") |> PrefixedName

    /// <summary>
    ///   <para>atm:IntersectionFix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A navigation fix defined by the intersection of two airspace routes.</para>
    /// labels<para>Intersection fix</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#IntersectionFix">https://data.nasa.gov/ontologies/atmonto/ATM#IntersectionFix</seealso>
    let IntersectionFix = Prefixed_Name(atm, "IntersectionFix") |> PrefixedName
    /// <summary>
    ///   <para>atm:MeterFix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fix defined as an point in the terminal airspace through which flights are metered by air traffic control on approach.</para>
    /// labels<para>Meter fix</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#MeterFix">https://data.nasa.gov/ontologies/atmonto/ATM#MeterFix</seealso>
    let MeterFix = Prefixed_Name(atm, "MeterFix") |> PrefixedName
    /// <summary>
    ///   <para>atm:MilesInTrailTMI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Miles-in-Trail (MIT) traffic management initiative (TMI) is used to apportion traffic into a manageable flow, as well as provide space for additional traffic (merging or departing) to enter the flow of traffic. Miles-in-trail describes the number of miles required between aircraft departing an airport, over a fix, at an altitude, through a sector, or on a specific route.</para>
    /// labels<para>Miles in Trail (MIT)</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#MilesInTrailTMI">https://data.nasa.gov/ontologies/atmonto/ATM#MilesInTrailTMI</seealso>
    let MilesInTrailTMI = Prefixed_Name(atm, "MilesInTrailTMI") |> PrefixedName
    /// <summary>
    ///   <para>atm:NDBfix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fix based on the location of a ground-based non-directional radio beacon (NDB) installation. NDB signals follow the curvature of the Earth, so they can be received at much greater distances at lower altitudes, a major advantage over VOR. However, NDB signals are also affected more by atmospheric conditions, mountainous terrain, coastal refraction and electrical storms, particularly at long range.</para>
    /// labels<para>NDB Fix</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#NDBfix">https://data.nasa.gov/ontologies/atmonto/ATM#NDBfix</seealso>
    let NDBfix = Prefixed_Name(atm, "NDBfix") |> PrefixedName
    /// <summary>
    ///   <para>atm:NavaidFix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fix based on the location of a ground-based Navigation Aid (Navaid) installation.</para>
    /// labels<para>NavaidFix</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#NavaidFix">https://data.nasa.gov/ontologies/atmonto/ATM#NavaidFix</seealso>
    let NavaidFix = Prefixed_Name(atm, "NavaidFix") |> PrefixedName
    /// <summary>
    ///   <para>atm:NavigationElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A navigation element is a set of components that can be used to assemble a flight plan or trajectory. They include fixes, routes, airports, SID/STAR traverses, etc.</para>
    /// labels<para>Navigation element</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#NavigationElement">https://data.nasa.gov/ontologies/atmonto/ATM#NavigationElement</seealso>
    let NavigationElement = Prefixed_Name(atm, "NavigationElement") |> PrefixedName
    /// <summary>
    ///   <para>atm:TFMcontrolElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any NAS entity that is potentially controlled via a TFM initiative.</para>
    /// labels<para>TFM control element</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#TFMcontrolElement">https://data.nasa.gov/ontologies/atmonto/ATM#TFMcontrolElement</seealso>
    let TFMcontrolElement = Prefixed_Name(atm, "TFMcontrolElement") |> PrefixedName

    /// <summary>
    ///   <para>atm:NumericParameterContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A wrapper around a numeric parameter. Containers can be sequenced to create an ordered list of numeric parameters.</para>
    /// labels<para>Numeric parameter container</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#NumericParameterContainer">https://data.nasa.gov/ontologies/atmonto/ATM#NumericParameterContainer</seealso>
    let NumericParameterContainer =
        Prefixed_Name(atm, "NumericParameterContainer") |> PrefixedName

    /// <summary>
    ///   <para>atm:hasNumericParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Links a container for a numerical parameter to the numerical parameter contained.</para>
    /// labels<para>has numeric parameter</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#hasNumericParameter">https://data.nasa.gov/ontologies/atmonto/ATM#hasNumericParameter</seealso>
    let hasNumericParameter = Prefixed_Name(atm, "hasNumericParameter") |> PrefixedName
    /// <summary>
    ///   <para>atm:PopupFactorSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ordered sequence of hourly popup factors used in specifying a Ground Delay Program (GDP).</para>
    /// labels<para>Popup Factor Sequence</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#PopupFactorSequence">https://data.nasa.gov/ontologies/atmonto/ATM#PopupFactorSequence</seealso>
    let PopupFactorSequence = Prefixed_Name(atm, "PopupFactorSequence") |> PrefixedName

    /// <summary>
    ///   <para>atm:ProgramArrivalRateContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A wrapper around a program arrival rate, used to sequence them into an ordered list.</para>
    /// labels<para>Program arrival rate container</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#ProgramArrivalRateContainer">https://data.nasa.gov/ontologies/atmonto/ATM#ProgramArrivalRateContainer</seealso>
    let ProgramArrivalRateContainer =
        Prefixed_Name(atm, "ProgramArrivalRateContainer") |> PrefixedName

    /// <summary>
    ///   <para>atm:ProgramArrivalRateSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ordered sequence of hourly program arrival rates used in specifying a Ground Dela Program (GDP).</para>
    /// labels<para>Program Arrival Rate Sequence</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#ProgramArrivalRateSequence">https://data.nasa.gov/ontologies/atmonto/ATM#ProgramArrivalRateSequence</seealso>
    let ProgramArrivalRateSequence =
        Prefixed_Name(atm, "ProgramArrivalRateSequence") |> PrefixedName

    /// <summary>
    ///   <para>atm:reRouteSegmentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates which type of ReRoute segment: origin , destination, origin-destination. A ReRoute segment can be a entire route between origin and destination, or a partial route leading from an origin or leading to a destination.</para>
    /// labels<para>re route segment type</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#reRouteSegmentType">https://data.nasa.gov/ontologies/atmonto/ATM#reRouteSegmentType</seealso>
    let reRouteSegmentType = Prefixed_Name(atm, "reRouteSegmentType") |> PrefixedName
    /// <summary>
    ///   <para>atm:reRouteType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ReRoute type encodes information about the type of ReRoute being initiated or the reason for the ReRoute. One of the following: ROUTE , PLAYBOOK , CDR, SPECIAL OPERATIONS, NRP SUSPENSIONS, VS , NAT, SHUTTLE ACTIVITY, FCA, FEA, INFORMATIONAL, MISCELLANEOUS.</para>
    /// labels<para>ReRoute type</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#reRouteType">https://data.nasa.gov/ontologies/atmonto/ATM#reRouteType</seealso>
    let reRouteType = Prefixed_Name(atm, "reRouteType") |> PrefixedName
    /// <summary>
    ///   <para>atm:reRouteReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides the reason for initiating a ReRoute: WEATHER , VOLUME , EQUIPMENT , RUNWAY/TAXIWAY , OTHER.</para>
    /// labels<para>reroute reason</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#reRouteReason">https://data.nasa.gov/ontologies/atmonto/ATM#reRouteReason</seealso>
    let reRouteReason = Prefixed_Name(atm, "reRouteReason") |> PrefixedName

    /// <summary>
    ///   <para>atm:implementationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the enforcement status of the ReRoute advisory: RQD (required), RMD (recommended), PLN (planned for implementation), FYI (informational only)</para>
    /// labels<para>implementation status</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#implementationStatus">https://data.nasa.gov/ontologies/atmonto/ATM#implementationStatus</seealso>
    let implementationStatus =
        Prefixed_Name(atm, "implementationStatus") |> PrefixedName

    /// <summary>
    ///   <para>atm:reRouteTimeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The time period associated with the reroute is specified in one of three ways. The reroute can apply to flights that: depart specified airports or centers during a certain time window (timeType=ETD); depart specified airports or centers to arrive at their destinations during a certain time window (timeType=ETA); or arrive at the boundary of a flow constrained area during a certain time window (timeType=FCA Flight List).</para>
    /// labels<para>ReRoute time type</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#reRouteTimeType">https://data.nasa.gov/ontologies/atmonto/ATM#reRouteTimeType</seealso>
    let reRouteTimeType = Prefixed_Name(atm, "reRouteTimeType") |> PrefixedName
    /// <summary>
    ///   <para>atm:SIDSTARtraverse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A route through a SID (Standard Instrument Departure route) or a STAR (Standard Arrival Route), traversing a common route at minimum and optionally a transition route and/or an airport route.</para>
    /// labels<para>SIDSTARtraverse</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#SIDSTARtraverse">https://data.nasa.gov/ontologies/atmonto/ATM#SIDSTARtraverse</seealso>
    let SIDSTARtraverse = Prefixed_Name(atm, "SIDSTARtraverse") |> PrefixedName
    /// <summary>
    ///   <para>atm:TACANfix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fix based on the location of a ground-based TACAN (TACtical Air Navigation) installation.</para>
    /// labels<para>TACAN Fix</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#TACANfix">https://data.nasa.gov/ontologies/atmonto/ATM#TACANfix</seealso>
    let TACANfix = Prefixed_Name(atm, "TACANfix") |> PrefixedName
    /// <summary>
    ///   <para>atm:Taxipath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sequence of taxiways followed by an aircraft taxiing en route to/from a runway.</para>
    /// labels<para>Taxipath</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#Taxipath">https://data.nasa.gov/ontologies/atmonto/ATM#Taxipath</seealso>
    let Taxipath = Prefixed_Name(atm, "Taxipath") |> PrefixedName
    /// <summary>
    ///   <para>atm:actualArrivalDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a flight with the day on which the flight arrives. This is the day determined by surveillance data sources to be the 'actual' day of arrival, versus the scheduled day or the day specified in the flight plan, etc.</para>
    /// labels<para>actual arrival day</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#actualArrivalDay">https://data.nasa.gov/ontologies/atmonto/ATM#actualArrivalDay</seealso>
    let actualArrivalDay = Prefixed_Name(atm, "actualArrivalDay") |> PrefixedName
    /// <summary>
    ///   <para>atm:actualArrivalTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The time determined by surveillance data sources to be the 'actual' time of flight arrival, versus the scheduled time or the time specified in the flight plan, etc.</para>
    /// labels<para>actual arrival time</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#actualArrivalTime">https://data.nasa.gov/ontologies/atmonto/ATM#actualArrivalTime</seealso>
    let actualArrivalTime = Prefixed_Name(atm, "actualArrivalTime") |> PrefixedName
    /// <summary>
    ///   <para>atm:actualDepartureDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a flight with the day on which the flight departs. This is the day determined by surveillance data sources to be the 'actual' day of departure, versus the scheduled day or the day specified in the flight plan, etc.</para>
    /// labels<para>actual departure day</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#actualDepartureDay">https://data.nasa.gov/ontologies/atmonto/ATM#actualDepartureDay</seealso>
    let actualDepartureDay = Prefixed_Name(atm, "actualDepartureDay") |> PrefixedName
    /// <summary>
    ///   <para>atm:actualDepartureTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The time determined by surveillance data sources to be the 'actual' time of flight departure, versus the scheduled time or the time specified in the flight plan, etc.</para>
    /// labels<para>actual departure time</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#actualDepartureTime">https://data.nasa.gov/ontologies/atmonto/ATM#actualDepartureTime</seealso>
    let actualDepartureTime = Prefixed_Name(atm, "actualDepartureTime") |> PrefixedName
    /// <summary>
    ///   <para>atm:adlDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a delay model to the day that the ADL (Aggregate Demand List) was generated. Each ADL contains information on the flights arriving and departing from an airport, or entering into and departing from a flow area.</para>
    /// labels<para>adl day</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#adlDay">https://data.nasa.gov/ontologies/atmonto/ATM#adlDay</seealso>
    let adlDay = Prefixed_Name(atm, "adlDay") |> PrefixedName
    /// <summary>
    ///   <para>atm:adsbID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The unique identifier of the ADS-B (Automatic Dependent Surveillance - Broadcast) transponder unit on board the aircraft for this flight.</para>
    /// labels<para>adsb ID</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#adsbID">https://data.nasa.gov/ontologies/atmonto/ATM#adsbID</seealso>
    let adsbID = Prefixed_Name(atm, "adsbID") |> PrefixedName
    /// <summary>
    ///   <para>atm:advisoryNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Advisory number as reported from the FAA Command Center database. it restarts at 001 on every new day UTC.</para>
    /// labels<para>advisory number</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#advisoryNumber">https://data.nasa.gov/ontologies/atmonto/ATM#advisoryNumber</seealso>
    let advisoryNumber = Prefixed_Name(atm, "advisoryNumber") |> PrefixedName
    /// <summary>
    ///   <para>atm:aircraftCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of aircraft flowing through an airspace region per some interval of time.</para>
    /// labels<para>aircraft count</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#aircraftCount">https://data.nasa.gov/ontologies/atmonto/ATM#aircraftCount</seealso>
    let aircraftCount = Prefixed_Name(atm, "aircraftCount") |> PrefixedName
    /// <summary>
    ///   <para>atm:aircraftFix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an aircraft track point with its associated navigation fix.</para>
    /// labels<para>aircraft fix</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#aircraftFix">https://data.nasa.gov/ontologies/atmonto/ATM#aircraftFix</seealso>
    let aircraftFix = Prefixed_Name(atm, "aircraftFix") |> PrefixedName
    /// <summary>
    ///   <para>atm:issuedTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The time when the traffic management initiative (TMI) was issued.</para>
    /// labels<para>issued time</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#issuedTime">https://data.nasa.gov/ontologies/atmonto/ATM#issuedTime</seealso>
    let issuedTime = Prefixed_Name(atm, "issuedTime") |> PrefixedName
    /// <summary>
    ///   <para>atm:locatedInSector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a navigation fix to the airspace sector in which that fix is located.</para>
    /// labels<para>located in sector</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#locatedInSector">https://data.nasa.gov/ontologies/atmonto/ATM#locatedInSector</seealso>
    let locatedInSector = Prefixed_Name(atm, "locatedInSector") |> PrefixedName
    /// <summary>
    ///   <para>atm:maxFlowCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The absolute maximum controllable number of aircraft flowing through an airspace region per some interval of time under any air traffic conditions.</para>
    /// labels<para>max flow capacity</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#maxFlowCapacity">https://data.nasa.gov/ontologies/atmonto/ATM#maxFlowCapacity</seealso>
    let maxFlowCapacity = Prefixed_Name(atm, "maxFlowCapacity") |> PrefixedName
    /// <summary>
    ///   <para>atm:modeledArrivalRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Links a delay model used in defining a Ground Delay Program (GDP) or Ground Stop(GS) to a sequence of desired hourly aircraft arrival rates specified for the initiative.</para>
    /// labels<para>modeled arrival rate</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#modeledArrivalRate">https://data.nasa.gov/ontologies/atmonto/ATM#modeledArrivalRate</seealso>
    let modeledArrivalRate = Prefixed_Name(atm, "modeledArrivalRate") |> PrefixedName
    /// <summary>
    ///   <para>atm:modeledAverageDelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The average flight delay specified when modeling a Ground Delay Program (GDP) or Ground Stop(GS).</para>
    /// labels<para>modeled average delay minutes</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#modeledAverageDelay">https://data.nasa.gov/ontologies/atmonto/ATM#modeledAverageDelay</seealso>
    let modeledAverageDelay = Prefixed_Name(atm, "modeledAverageDelay") |> PrefixedName
    /// <summary>
    ///   <para>atm:modeledMaximumDelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The maximum flight delay specified when modeling a Ground Delay Program (GDP) or Ground Stop(GS).</para>
    /// labels<para>modeled maximum delay minutes</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#modeledMaximumDelay">https://data.nasa.gov/ontologies/atmonto/ATM#modeledMaximumDelay</seealso>
    let modeledMaximumDelay = Prefixed_Name(atm, "modeledMaximumDelay") |> PrefixedName
    /// <summary>
    ///   <para>atm:modeledPopUpFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a delay model used in defining a Ground Delay Program (GDP) or Ground Stop(GS) to a sequence of desired hourly popup factors specified for the initiative. 'Popups' account for late-filing flights (unexpected/unplanned flights) when modeling delays as part of a traffic management initiative (TMI) design process.</para>
    /// labels<para>modeled pop up factor</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#modeledPopUpFactor">https://data.nasa.gov/ontologies/atmonto/ATM#modeledPopUpFactor</seealso>
    let modeledPopUpFactor = Prefixed_Name(atm, "modeledPopUpFactor") |> PrefixedName
    /// <summary>
    ///   <para>atm:modeledTotalDelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total flight delay specified when modeling a Ground Delay Program (GDP) or Ground Stop(GS).</para>
    /// labels<para>modeled total delay minutes</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#modeledTotalDelay">https://data.nasa.gov/ontologies/atmonto/ATM#modeledTotalDelay</seealso>
    let modeledTotalDelay = Prefixed_Name(atm, "modeledTotalDelay") |> PrefixedName
    /// <summary>
    ///   <para>atm:mustHaveDestination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a flight specification to an airport specification describing the destination airports for the flights being specified. Any flight covered by the flight specification must have as its destination one of the airports covered by the airport specification.</para>
    /// labels<para>must have destination</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#mustHaveDestination">https://data.nasa.gov/ontologies/atmonto/ATM#mustHaveDestination</seealso>
    let mustHaveDestination = Prefixed_Name(atm, "mustHaveDestination") |> PrefixedName
    /// <summary>
    ///   <para>atm:mustHaveOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a flight specification to an airport specification describing the originating airports for the flights being specified. Any flight covered by the flight specification must have as its origin one of the airports covered by the airport specification.</para>
    /// labels<para>must have origin</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#mustHaveOrigin">https://data.nasa.gov/ontologies/atmonto/ATM#mustHaveOrigin</seealso>
    let mustHaveOrigin = Prefixed_Name(atm, "mustHaveOrigin") |> PrefixedName
    /// <summary>
    ///   <para>atm:operatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a flight to its carrier airline.</para>
    /// labels<para>operated by</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#operatedBy">https://data.nasa.gov/ontologies/atmonto/ATM#operatedBy</seealso>
    let operatedBy = Prefixed_Name(atm, "operatedBy") |> PrefixedName
    /// <summary>
    ///   <para>atm:operatingCarrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a flight specification to one or more carrier airline(s). Each flight covered by the specification must be operated by one of these carriers.</para>
    /// labels<para>operating carrier</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#operatingCarrier">https://data.nasa.gov/ontologies/atmonto/ATM#operatingCarrier</seealso>
    let operatingCarrier = Prefixed_Name(atm, "operatingCarrier") |> PrefixedName

    /// <summary>
    ///   <para>atm:operatingTimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a flight specification to a time interval. Each flight covered by the specification must be airborne sometime during the time period specified by the interval.</para>
    /// labels<para>operating time interval</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#operatingTimeInterval">https://data.nasa.gov/ontologies/atmonto/ATM#operatingTimeInterval</seealso>
    let operatingTimeInterval =
        Prefixed_Name(atm, "operatingTimeInterval") |> PrefixedName

    /// <summary>
    ///   <para>atm:planFilingDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Links to the day when the flight plan was filed with the FAA.</para>
    /// labels<para>plan filing day</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#planFilingDay">https://data.nasa.gov/ontologies/atmonto/ATM#planFilingDay</seealso>
    let planFilingDay = Prefixed_Name(atm, "planFilingDay") |> PrefixedName
    /// <summary>
    ///   <para>atm:plannedArrivalTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The time that the flight is planned to arrive per the flight plan.</para>
    /// labels<para>planned arrival time</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#plannedArrivalTime">https://data.nasa.gov/ontologies/atmonto/ATM#plannedArrivalTime</seealso>
    let plannedArrivalTime = Prefixed_Name(atm, "plannedArrivalTime") |> PrefixedName
    /// <summary>
    ///   <para>atm:plannedDepartureDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the day that the flight is planned to depart per the flight plan.</para>
    /// labels<para>planned departure day</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#plannedDepartureDay">https://data.nasa.gov/ontologies/atmonto/ATM#plannedDepartureDay</seealso>
    let plannedDepartureDay = Prefixed_Name(atm, "plannedDepartureDay") |> PrefixedName

    /// <summary>
    ///   <para>atm:plannedDepartureTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The time that the flight is planned to depart per the flight plan.</para>
    /// labels<para>planned departure time</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#plannedDepartureTime">https://data.nasa.gov/ontologies/atmonto/ATM#plannedDepartureTime</seealso>
    let plannedDepartureTime =
        Prefixed_Name(atm, "plannedDepartureTime") |> PrefixedName

    /// <summary>
    ///   <para>atm:prevAverageDelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The average flight delay experienced prior to the start of a Ground Stop(GS).</para>
    /// labels<para>previous average delay minutes</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#prevAverageDelay">https://data.nasa.gov/ontologies/atmonto/ATM#prevAverageDelay</seealso>
    let prevAverageDelay = Prefixed_Name(atm, "prevAverageDelay") |> PrefixedName
    /// <summary>
    ///   <para>atm:prevMaximumDelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The maximum flight delay experienced prior to the start of a Ground Stop(GS).</para>
    /// labels<para>previous maximum delay minutes</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#prevMaximumDelay">https://data.nasa.gov/ontologies/atmonto/ATM#prevMaximumDelay</seealso>
    let prevMaximumDelay = Prefixed_Name(atm, "prevMaximumDelay") |> PrefixedName
    /// <summary>
    ///   <para>atm:prevTotalDelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total flight delay experienced prior to the start of a Ground Stop(GS).</para>
    /// labels<para>previous total delay minutes</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#prevTotalDelay">https://data.nasa.gov/ontologies/atmonto/ATM#prevTotalDelay</seealso>
    let prevTotalDelay = Prefixed_Name(atm, "prevTotalDelay") |> PrefixedName
    /// <summary>
    ///   <para>atm:publishedArrivalDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the day that the flight is planned to arrive per the OAG schedule.</para>
    /// labels<para>published arrival day</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#publishedArrivalDay">https://data.nasa.gov/ontologies/atmonto/ATM#publishedArrivalDay</seealso>
    let publishedArrivalDay = Prefixed_Name(atm, "publishedArrivalDay") |> PrefixedName

    /// <summary>
    ///   <para>atm:publishedArrivalTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The time that the flight is planned to arrive per the OAG schedule.</para>
    /// labels<para>published arrival time</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#publishedArrivalTime">https://data.nasa.gov/ontologies/atmonto/ATM#publishedArrivalTime</seealso>
    let publishedArrivalTime =
        Prefixed_Name(atm, "publishedArrivalTime") |> PrefixedName

    /// <summary>
    ///   <para>atm:publishedDepartureDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the day that the flight is planned to depart per the OAG schedule.</para>
    /// labels<para>published departure day</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#publishedDepartureDay">https://data.nasa.gov/ontologies/atmonto/ATM#publishedDepartureDay</seealso>
    let publishedDepartureDay =
        Prefixed_Name(atm, "publishedDepartureDay") |> PrefixedName

    /// <summary>
    ///   <para>atm:publishedDepartureTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The time that the flight is planned to depart per the OAG schedule.</para>
    /// labels<para>published departure time</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#publishedDepartureTime">https://data.nasa.gov/ontologies/atmonto/ATM#publishedDepartureTime</seealso>
    let publishedDepartureTime =
        Prefixed_Name(atm, "publishedDepartureTime") |> PrefixedName

    /// <summary>
    ///   <para>atm:referenceFix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a relative fix to the absolute fix that serves as the basis for its location. (A relative fix position is defined relative to an absolute fix position, e.g. as a vector offset from the absolute fix.)</para>
    /// </remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#referenceFix">https://data.nasa.gov/ontologies/atmonto/ATM#referenceFix</seealso>
    let referenceFix = Prefixed_Name(atm, "referenceFix") |> PrefixedName
    /// <summary>
    ///   <para>atm:relativeAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The angular direction in degrees (1-360) of a relative fix with respect to its defining absolute fix.</para>
    /// labels<para>relative angle</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#relativeAngle">https://data.nasa.gov/ontologies/atmonto/ATM#relativeAngle</seealso>
    let relativeAngle = Prefixed_Name(atm, "relativeAngle") |> PrefixedName
    /// <summary>
    ///   <para>atm:relativeDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The distance (in nautical miles) between a relative fix and its defining (absolute) fix.</para>
    /// labels<para>relative distance</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#relativeDistance">https://data.nasa.gov/ontologies/atmonto/ATM#relativeDistance</seealso>
    let relativeDistance = Prefixed_Name(atm, "relativeDistance") |> PrefixedName
    /// <summary>
    ///   <para>atm:reportingDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A link between an aircraft track point and the day during which an en route aircraft traversed that point and reported its position, speed, and heading.</para>
    /// labels<para>reporting day</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#reportingDay">https://data.nasa.gov/ontologies/atmonto/ATM#reportingDay</seealso>
    let reportingDay = Prefixed_Name(atm, "reportingDay") |> PrefixedName
    /// <summary>
    ///   <para>atm:reportingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The time when an en route aircraft passed through a trackpoint and reported its position, speed, and heading.</para>
    /// labels<para>reporting time</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#reportingTime">https://data.nasa.gov/ontologies/atmonto/ATM#reportingTime</seealso>
    let reportingTime = Prefixed_Name(atm, "reportingTime") |> PrefixedName
    /// <summary>
    ///   <para>atm:traconID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Three letter FAA TRACON identifier code.</para>
    /// labels<para>tracon ID</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#traconID">https://data.nasa.gov/ontologies/atmonto/ATM#traconID</seealso>
    let traconID = Prefixed_Name(atm, "traconID") |> PrefixedName
    /// <summary>
    ///   <para>atm:traversesSIDSTAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a SIDSTARtraverse (i.e., a specific route through a SID or STAR) to the specific SID or STAR being traversed by a given flight.</para>
    /// labels<para>traverses SIDSTAR</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#traversesSIDSTAR">https://data.nasa.gov/ontologies/atmonto/ATM#traversesSIDSTAR</seealso>
    let traversesSIDSTAR = Prefixed_Name(atm, "traversesSIDSTAR") |> PrefixedName
    /// <summary>
    ///   <para>atm:trueAirspeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The true airspeed of a flight: the speed of the aircraft relative to the airmass in which it is flying.</para>
    /// labels<para>true airspeed</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#trueAirspeed">https://data.nasa.gov/ontologies/atmonto/ATM#trueAirspeed</seealso>
    let trueAirspeed = Prefixed_Name(atm, "trueAirspeed") |> PrefixedName
    /// <summary>
    ///   <para>atm:usesTransitionRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a SIDSTARtraverse (a path through a SID/STAR) to the transition route used in making the traverse.</para>
    /// labels<para>uses transition route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#usesTransitionRoute">https://data.nasa.gov/ontologies/atmonto/ATM#usesTransitionRoute</seealso>
    let usesTransitionRoute = Prefixed_Name(atm, "usesTransitionRoute") |> PrefixedName
    /// <summary>
    ///   <para>atm:withinARTCC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an airport specification to an ARTCC or ARTCC tier. Only airports within the ARTCC or ARTCC tier are covered by the specification.</para>
    /// labels<para>within ARTCC</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#withinARTCC">https://data.nasa.gov/ontologies/atmonto/ATM#withinARTCC</seealso>
    let withinARTCC = Prefixed_Name(atm, "withinARTCC") |> PrefixedName

    /// <summary>
    ///   <para>atm:withinAirportBoundingRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an airport specification to a circular geographic region. Only airports whose locations fall within this region satisfy the specification.</para>
    /// labels<para>within airport bounding region</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#withinAirportBoundingRegion">https://data.nasa.gov/ontologies/atmonto/ATM#withinAirportBoundingRegion</seealso>
    let withinAirportBoundingRegion =
        Prefixed_Name(atm, "withinAirportBoundingRegion") |> PrefixedName

    /// <summary>
    ///   <para>atm:Flight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A single flight segment from origin to destination.</para>
    /// labels<para>Flight</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#Flight">https://data.nasa.gov/ontologies/atmonto/ATM#Flight</seealso>
    let Flight = Prefixed_Name(atm, "Flight") |> PrefixedName
    /// <summary>
    ///   <para>atm:NRSfix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The NRS is a system of waypoints developed for use within the United States for flight planning and navigation without reference to ground based navigational aids. The NRS waypoints are located in a grid pattern along defined latitude and longitude lines. NRS waypoint names are composed of two letters followed by two numbers, followed by a single letter. The first and second characters of NRS waypoints are the FIR identifier for the United States (“K”) and the FIR subdivision, or ARTCC center in which the waypoint is located (e.g. “D” for Denver ARTCC). The third and fourth characters are a number group representing the latitude of the waypoint. These numbers begin at the equator with 00 and advances north and south from 01 to 90 and correspond to every 10 minutes of latitude and repeating every 15°. The final character in the NRS waypoint is a letter representing the line of longitude for which the waypoint is located. This identifier starts at the prime meridian moving west to east and uses the letters A to Z while repeating every 26°. To date, the current density of the NRS grid is one waypoint spaced every 30 minutes of latitude and every 2° of longitude.</para>
    /// labels<para>NRS fix</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#NRSfix">https://data.nasa.gov/ontologies/atmonto/ATM#NRSfix</seealso>
    let NRSfix = Prefixed_Name(atm, "NRSfix") |> PrefixedName
    /// <summary>
    ///   <para>atm:NavElementContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A navigation element container is a wrapper around an existing navigation element, such as a fix or a route. These containers can be sequenced together to represent flight paths and flight trajectories.</para>
    /// labels<para>Navigation element container</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#NavElementContainer">https://data.nasa.gov/ontologies/atmonto/ATM#NavElementContainer</seealso>
    let NavElementContainer = Prefixed_Name(atm, "NavElementContainer") |> PrefixedName
    /// <summary>
    ///   <para>atm:NavigationPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ordered sequence of navigation elements (fixes, routes, airports) representing a path through the airspace.</para>
    /// labels<para>Navigation path</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#NavigationPath">https://data.nasa.gov/ontologies/atmonto/ATM#NavigationPath</seealso>
    let NavigationPath = Prefixed_Name(atm, "NavigationPath") |> PrefixedName
    /// <summary>
    ///   <para>atm:groundSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The reported ground speed at an aircraft track point.</para>
    /// labels<para>ground speed</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#groundSpeed">https://data.nasa.gov/ontologies/atmonto/ATM#groundSpeed</seealso>
    let groundSpeed = Prefixed_Name(atm, "groundSpeed") |> PrefixedName
    /// <summary>
    ///   <para>atm:heading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The aircraft heading at the track point: a number between 0.01 and 360.0 indicating the angular heading with respect to North.</para>
    /// labels<para>heading</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#heading">https://data.nasa.gov/ontologies/atmonto/ATM#heading</seealso>
    let heading = Prefixed_Name(atm, "heading") |> PrefixedName
    /// <summary>
    ///   <para>atm:includedFlights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an aircraft flow to a specification of the flights included in the flow.</para>
    /// labels<para>included flights</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#includedFlights">https://data.nasa.gov/ontologies/atmonto/ATM#includedFlights</seealso>
    let includedFlights = Prefixed_Name(atm, "includedFlights") |> PrefixedName
    /// <summary>
    ///   <para>atm:initiativeComments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides any specific comments on the traffic management initiative (TMI) made by the issuing authority (e.g., ATCSCC, ARTCC).</para>
    /// </remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#initiativeComments">https://data.nasa.gov/ontologies/atmonto/ATM#initiativeComments</seealso>
    let initiativeComments = Prefixed_Name(atm, "initiativeComments") |> PrefixedName
    /// <summary>
    ///   <para>atm:issuedDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the day when the traffic management initiative (TMI) was issued.</para>
    /// labels<para>issued day</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#issuedDay">https://data.nasa.gov/ontologies/atmonto/ATM#issuedDay</seealso>
    let issuedDay = Prefixed_Name(atm, "issuedDay") |> PrefixedName
    /// <summary>
    ///   <para>atm:timeConstraintType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the type of flight time being constrained in this flight specification: either ETA (estimated arrival time) or ETD (estimated departure time).</para>
    /// labels<para>time constraint type</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#timeConstraintType">https://data.nasa.gov/ontologies/atmonto/ATM#timeConstraintType</seealso>
    let timeConstraintType = Prefixed_Name(atm, "timeConstraintType") |> PrefixedName
    /// <summary>
    ///   <para>atm:aircraftWeightCat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Indicates the weight category as part of a flight specification constraint.</para>
    /// labels<para>aircraft weight category</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#aircraftWeightCat">https://data.nasa.gov/ontologies/atmonto/ATM#aircraftWeightCat</seealso>
    let aircraftWeightCat = Prefixed_Name(atm, "aircraftWeightCat") |> PrefixedName
    /// <summary>
    ///   <para>atm:GDPmodel</para>
    /// </summary>
    /// <remarks>
    ///   <para>This model provides parameters to the code that assigns times to the aircraft involved in the GDP or GS</para>
    /// </remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#GDPmodel">https://data.nasa.gov/ontologies/atmonto/ATM#GDPmodel</seealso>
    let GDPmodel = Prefixed_Name(atm, "GDPmodel") |> PrefixedName

    /// <summary>
    ///   <para>atm:GroundDelayProgramTMI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Ground Delay Program (GDP) traffic management initiative (TMI). A Ground Delay Program (GDP) is a traffic management procedure where aircraft are delayed at their departure airport in order to manage demand and capacity at their arrival airport.</para>
    /// labels<para>Ground Delay Program (GDP)</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#GroundDelayProgramTMI">https://data.nasa.gov/ontologies/atmonto/ATM#GroundDelayProgramTMI</seealso>
    let GroundDelayProgramTMI =
        Prefixed_Name(atm, "GroundDelayProgramTMI") |> PrefixedName

    /// <summary>
    ///   <para>atm:arrivalTaxiPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the taxipath followed by the flight en route to the gate.</para>
    /// labels<para>arrival taxi path</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#arrivalTaxiPath">https://data.nasa.gov/ontologies/atmonto/ATM#arrivalTaxiPath</seealso>
    let arrivalTaxiPath = Prefixed_Name(atm, "arrivalTaxiPath") |> PrefixedName
    /// <summary>
    ///   <para>atm:departureAirport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the actual departure airport for the flight.</para>
    /// labels<para>departure airport</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#departureAirport">https://data.nasa.gov/ontologies/atmonto/ATM#departureAirport</seealso>
    let departureAirport = Prefixed_Name(atm, "departureAirport") |> PrefixedName
    /// <summary>
    ///   <para>atm:departureRunway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Links to the actual departure runway for the flight.</para>
    /// labels<para>departure runway</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#departureRunway">https://data.nasa.gov/ontologies/atmonto/ATM#departureRunway</seealso>
    let departureRunway = Prefixed_Name(atm, "departureRunway") |> PrefixedName
    /// <summary>
    ///   <para>atm:departureScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a Ground Delay Program (GDP) or a Ground Stop (GS) to a specification of the departure airport(s) participating in the traffic management initiative (TMI).</para>
    /// labels<para>departure scope</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#departureScope">https://data.nasa.gov/ontologies/atmonto/ATM#departureScope</seealso>
    let departureScope = Prefixed_Name(atm, "departureScope") |> PrefixedName
    /// <summary>
    ///   <para>atm:effectiveEndDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the expected ending day of the traffic management initiative (TMI).</para>
    /// labels<para>effective end day</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#effectiveEndDay">https://data.nasa.gov/ontologies/atmonto/ATM#effectiveEndDay</seealso>
    let effectiveEndDay = Prefixed_Name(atm, "effectiveEndDay") |> PrefixedName
    /// <summary>
    ///   <para>atm:effectiveEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The expected end time of the traffic management initiative (TMI).</para>
    /// labels<para>effective end time</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#effectiveEndTime">https://data.nasa.gov/ontologies/atmonto/ATM#effectiveEndTime</seealso>
    let effectiveEndTime = Prefixed_Name(atm, "effectiveEndTime") |> PrefixedName
    /// <summary>
    ///   <para>atm:effectiveStartDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the expected starting day of the traffic management initiative (TMI).</para>
    /// labels<para>effective start day</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#effectiveStartDay">https://data.nasa.gov/ontologies/atmonto/ATM#effectiveStartDay</seealso>
    let effectiveStartDay = Prefixed_Name(atm, "effectiveStartDay") |> PrefixedName
    /// <summary>
    ///   <para>atm:excludesAirway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a flight specification to one of more airways (routes). Any flight that traverses a linked airway is excluded from the set of flights covered by this flight specification.</para>
    /// labels<para>excludes airway</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#excludesAirway">https://data.nasa.gov/ontologies/atmonto/ATM#excludesAirway</seealso>
    let excludesAirway = Prefixed_Name(atm, "excludesAirway") |> PrefixedName
    /// <summary>
    ///   <para>atm:excludesFix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a flight specification to one of more navigation fixes. Any flight that traverses a linked fix is excluded from the set of flights covered by this flight specification.</para>
    /// labels<para>excludes fix</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#excludesFix">https://data.nasa.gov/ontologies/atmonto/ATM#excludesFix</seealso>
    let excludesFix = Prefixed_Name(atm, "excludesFix") |> PrefixedName
    /// <summary>
    ///   <para>atm:excludesFlight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a flight specification to one of more flights. Any linked flight is excluded from the set of flights covered by this flight specification.</para>
    /// labels<para>excludes flight</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#excludesFlight">https://data.nasa.gov/ontologies/atmonto/ATM#excludesFlight</seealso>
    let excludesFlight = Prefixed_Name(atm, "excludesFlight") |> PrefixedName
    /// <summary>
    ///   <para>atm:fixId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A non-unique FAA identifier for a fix. When combined with a fix ICAO code, it defines a unique fix worldwide. Often, but not always, the fixId is identical to the fixName.</para>
    /// labels<para>fix ID</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#fixId">https://data.nasa.gov/ontologies/atmonto/ATM#fixId</seealso>
    let fixId = Prefixed_Name(atm, "fixId") |> PrefixedName
    /// <summary>
    ///   <para>atm:fixName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A unique FAA identier for a fix that can be filed as part of a flight plan. The fix name conceptually represents the worldwide-unique combination of a FixID and ICAO code. Often, but not always, the fixId is identical to the fixName.</para>
    /// labels<para>fix name</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#fixName">https://data.nasa.gov/ontologies/atmonto/ATM#fixName</seealso>
    let fixName = Prefixed_Name(atm, "fixName") |> PrefixedName

    /// <summary>
    ///   <para>atm:flightInclusionExclusion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a ReRoute to a specification of the flight(s) included in or excluded from the ReRoute traffic management initiative (TMI).</para>
    /// labels<para>flight inclusion exclusion</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#flightInclusionExclusion">https://data.nasa.gov/ontologies/atmonto/ATM#flightInclusionExclusion</seealso>
    let flightInclusionExclusion =
        Prefixed_Name(atm, "flightInclusionExclusion") |> PrefixedName

    /// <summary>
    ///   <para>atm:flightInclusionSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a Ground Delay Program (GDP) or a Ground Stop (GS) to a specification of the flight(s) included in the traffic management initiative (TMI).</para>
    /// labels<para>flight inclusion spec</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#flightInclusionSpec">https://data.nasa.gov/ontologies/atmonto/ATM#flightInclusionSpec</seealso>
    let flightInclusionSpec = Prefixed_Name(atm, "flightInclusionSpec") |> PrefixedName
    /// <summary>
    ///   <para>atm:flightRouteString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A string that provides the route of flight proposed in a flight plan. Syntactically, the string shows a path of fixes, airways, SIDs, and STARs, separated by either one or two dots. The string is parsed to create an equivalent ontology representation: an ordered sequence of navigation elements that are associated directly with the flight plan (atm:PlannedFlightRoute).</para>
    /// labels<para>flight route string</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#flightRouteString">https://data.nasa.gov/ontologies/atmonto/ATM#flightRouteString</seealso>
    let flightRouteString = Prefixed_Name(atm, "flightRouteString") |> PrefixedName
    /// <summary>
    ///   <para>atm:flowCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The maximum controllable number of aircraft flowing through an airspace region per some interval of time.</para>
    /// labels<para>flow capacity</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#flowCapacity">https://data.nasa.gov/ontologies/atmonto/ATM#flowCapacity</seealso>
    let flowCapacity = Prefixed_Name(atm, "flowCapacity") |> PrefixedName
    /// <summary>
    ///   <para>atm:hasCrewMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a flight to its crew members.</para>
    /// labels<para>has crew member</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#hasCrewMember">https://data.nasa.gov/ontologies/atmonto/ATM#hasCrewMember</seealso>
    let hasCrewMember = Prefixed_Name(atm, "hasCrewMember") |> PrefixedName
    /// <summary>
    ///   <para>atm:hasNavElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a container for a navigational element to the element contained.</para>
    /// labels<para>has navigation element</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#hasNavElement">https://data.nasa.gov/ontologies/atmonto/ATM#hasNavElement</seealso>
    let hasNavElement = Prefixed_Name(atm, "hasNavElement") |> PrefixedName

    /// <summary>
    ///   <para>atm:impactingConditionMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A free-text descriptoin elaborating on the reason for initiating the Ground Delay Program.</para>
    /// labels<para>impacting condition message</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#impactingConditionMessage">https://data.nasa.gov/ontologies/atmonto/ATM#impactingConditionMessage</seealso>
    let impactingConditionMessage =
        Prefixed_Name(atm, "impactingConditionMessage") |> PrefixedName

    /// <summary>
    ///   <para>atm:includesAirport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an airport specification to one of more airports. Any airport linked is included in the set of airports covered by this airport specification. This property allows for explicit specification of a list of specific airports; the property atm:includesAirportType allows for the the implicit specification of an entire class of airports.</para>
    /// labels<para>includes airport</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#includesAirport">https://data.nasa.gov/ontologies/atmonto/ATM#includesAirport</seealso>
    let includesAirport = Prefixed_Name(atm, "includesAirport") |> PrefixedName
    /// <summary>
    ///   <para>atm:includesAirway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a flight specification to one of more airways (routes). Any flight that traverses a linked airway is included in the set of flights covered by this flight specification.</para>
    /// labels<para>includes airway</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#includesAirway">https://data.nasa.gov/ontologies/atmonto/ATM#includesAirway</seealso>
    let includesAirway = Prefixed_Name(atm, "includesAirway") |> PrefixedName
    /// <summary>
    ///   <para>atm:includesFix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a flight specification to one of more navigation fixes. Any flight that traverses a linked fix is included in the set of flights covered by this flight specification.</para>
    /// labels<para>includes fix</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#includesFix">https://data.nasa.gov/ontologies/atmonto/ATM#includesFix</seealso>
    let includesFix = Prefixed_Name(atm, "includesFix") |> PrefixedName
    /// <summary>
    ///   <para>atm:includesFlight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a flight specification to one of more flights. Any linked flight is included in the set of flights covered by this flight specification.</para>
    /// labels<para>includes flight</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#includesFlight">https://data.nasa.gov/ontologies/atmonto/ATM#includesFlight</seealso>
    let includesFlight = Prefixed_Name(atm, "includesFlight") |> PrefixedName
    /// <summary>
    ///   <para>atm:radialAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The angle (in degrees) that defines the radial route's angular position with respect to the defined fix.</para>
    /// labels<para>radial angle</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#radialAngle">https://data.nasa.gov/ontologies/atmonto/ATM#radialAngle</seealso>
    let radialAngle = Prefixed_Name(atm, "radialAngle") |> PrefixedName
    /// <summary>
    ///   <para>atm:radialFix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the fix through which the radial route passes.</para>
    /// labels<para>radial fix</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#radialFix">https://data.nasa.gov/ontologies/atmonto/ATM#radialFix</seealso>
    let radialFix = Prefixed_Name(atm, "radialFix") |> PrefixedName
    /// <summary>
    ///   <para>atm:reRouteConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a route segment specified as part of a ReRoute traffic management initiative (TMI) to a flight specification indicating which flights are permitted to follow the route segment.</para>
    /// labels<para>reroute constraint</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#reRouteConstraint">https://data.nasa.gov/ontologies/atmonto/ATM#reRouteConstraint</seealso>
    let reRouteConstraint = Prefixed_Name(atm, "reRouteConstraint") |> PrefixedName
    /// <summary>
    ///   <para>atm:reRoutePath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Links a route segment alternative (specified as part of a ReRoute traffic management initiative) to its associated flight plan.</para>
    /// labels<para>re route path</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#reRoutePath">https://data.nasa.gov/ontologies/atmonto/ATM#reRoutePath</seealso>
    let reRoutePath = Prefixed_Name(atm, "reRoutePath") |> PrefixedName
    /// <summary>
    ///   <para>atm:planFilingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The time that the flight plan was filed with the FAA.</para>
    /// labels<para>plan filing time</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#planFilingTime">https://data.nasa.gov/ontologies/atmonto/ATM#planFilingTime</seealso>
    let planFilingTime = Prefixed_Name(atm, "planFilingTime") |> PrefixedName
    /// <summary>
    ///   <para>atm:plannedArrivalDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the day that the flight is planned to arrive per the flight plan.</para>
    /// labels<para>planned arrival day</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#plannedArrivalDay">https://data.nasa.gov/ontologies/atmonto/ATM#plannedArrivalDay</seealso>
    let plannedArrivalDay = Prefixed_Name(atm, "plannedArrivalDay") |> PrefixedName
    /// <summary>
    ///   <para>atm:NavigationFix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A designated point on the surface of the earth used for aeronautical navigation.</para>
    /// labels<para>Navigation fix</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#NavigationFix">https://data.nasa.gov/ontologies/atmonto/ATM#NavigationFix</seealso>
    let NavigationFix = Prefixed_Name(atm, "NavigationFix") |> PrefixedName
    /// <summary>
    ///   <para>atm:AircraftTrackPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point during a flight where various flight parameters are captured and sent (via transponder) to FAA computers.</para>
    /// labels<para>Aircraft Track Point</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#AircraftTrackPoint">https://data.nasa.gov/ontologies/atmonto/ATM#AircraftTrackPoint</seealso>
    let AircraftTrackPoint = Prefixed_Name(atm, "AircraftTrackPoint") |> PrefixedName
    /// <summary>
    ///   <para>atm:NavigationSubPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A contiguous portion of an existing navigation path.</para>
    /// labels<para>Navigation SubPath</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#NavigationSubPath">https://data.nasa.gov/ontologies/atmonto/ATM#NavigationSubPath</seealso>
    let NavigationSubPath = Prefixed_Name(atm, "NavigationSubPath") |> PrefixedName
    /// <summary>
    ///   <para>atm:CrewMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The set of inflight airline personnel operating or performing servicing functions on a flight (pilots and cabin attendants).</para>
    /// labels<para>Crew member</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#CrewMember">https://data.nasa.gov/ontologies/atmonto/ATM#CrewMember</seealso>
    let CrewMember = Prefixed_Name(atm, "CrewMember") |> PrefixedName
    /// <summary>
    ///   <para>atm:RelativeFix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fix defined in relation to another fix.</para>
    /// labels<para>Relative fix</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#RelativeFix">https://data.nasa.gov/ontologies/atmonto/ATM#RelativeFix</seealso>
    let RelativeFix = Prefixed_Name(atm, "RelativeFix") |> PrefixedName
    /// <summary>
    ///   <para>atm:FlightPlanSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A contiguous portion of a complete flight plan.</para>
    /// labels<para>Flight plan segment</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#FlightPlanSegment">https://data.nasa.gov/ontologies/atmonto/ATM#FlightPlanSegment</seealso>
    let FlightPlanSegment = Prefixed_Name(atm, "FlightPlanSegment") |> PrefixedName

    /// <summary>
    ///   <para>atm:includesAircraftClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Indicates which class of aircraft the flights defined by this specification must employ: jet, prop, jet and prop, turbo, all.</para>
    /// labels<para>includes aircraft class</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#includesAircraftClass">https://data.nasa.gov/ontologies/atmonto/ATM#includesAircraftClass</seealso>
    let includesAircraftClass =
        Prefixed_Name(atm, "includesAircraftClass") |> PrefixedName

    /// <summary>
    ///   <para>atm:allowedRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>In a reRoute traffic management initiative, there are multiple allowed routes specified between origin and destination. This property links a ReRouteTMI with its allowed routes.</para>
    /// labels<para>allowed route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#allowedRoute">https://data.nasa.gov/ontologies/atmonto/ATM#allowedRoute</seealso>
    let allowedRoute = Prefixed_Name(atm, "allowedRoute") |> PrefixedName
    /// <summary>
    ///   <para>atm:callSign</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The flight identifier (3-letter ICAO code plus number).</para>
    /// labels<para>call sign</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#callSign">https://data.nasa.gov/ontologies/atmonto/ATM#callSign</seealso>
    let callSign = Prefixed_Name(atm, "callSign") |> PrefixedName
    /// <summary>
    ///   <para>atm:modeledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a Ground Delay Program (GDP) or a Ground Stop (GS) to a representation of the model used to design that initiative. The model contains all relevant parameters used to create the initiative.</para>
    /// labels<para>modeled by</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/ATM#modeledBy">https://data.nasa.gov/ontologies/atmonto/ATM#modeledBy</seealso>
    let modeledBy = Prefixed_Name(atm, "modeledBy") |> PrefixedName
