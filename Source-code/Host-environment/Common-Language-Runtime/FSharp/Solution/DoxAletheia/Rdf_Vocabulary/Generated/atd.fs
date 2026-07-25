namespace https.data.nasa.gov.ontologies.atmonto.data.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module atd =
    let _namespace_iri = Namespace_Iri atd |> NamespaceIRI

    /// <summary>
    ///   <para>atd:associatedMETARreportingStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a METAR report to the reporting station where the data were collected.</para>
    /// labels<para>METAR reporting station</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#associatedMETARreportingStation">https://data.nasa.gov/ontologies/atmonto/data#associatedMETARreportingStation</seealso>
    let associatedMETARreportingStation =
        Prefixed_Name(atd, "associatedMETARreportingStation") |> PrefixedName

    /// <summary>
    ///   <para>atd:hasTAFreport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates an airport with TAF weather reports generated for that airport.</para>
    /// labels<para>has TAFreport</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#hasTAFreport">https://data.nasa.gov/ontologies/atmonto/data#hasTAFreport</seealso>
    let hasTAFreport = Prefixed_Name(atd, "hasTAFreport") |> PrefixedName

    /// <summary>
    ///   <para>atd:runwaySurfaceFriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The surface friction (mu) value of the runway for the specified period. Runway surface friction is directly relevant to the braking action which will be available to an aircraft decelerating after touch down, or after a decision to reject a take off.</para>
    /// labels<para>runway surface friction (mu)</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#runwaySurfaceFriction">https://data.nasa.gov/ontologies/atmonto/data#runwaySurfaceFriction</seealso>
    let runwaySurfaceFriction =
        Prefixed_Name(atd, "runwaySurfaceFriction") |> PrefixedName

    /// <summary>
    ///   <para>atd:etmsDepartures</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Count of departures at airport based on ETMS (Enhanced Traffic Management System) data.</para>
    /// labels<para>etms arrivals</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#etmsDepartures">https://data.nasa.gov/ontologies/atmonto/data#etmsDepartures</seealso>
    let etmsDepartures = Prefixed_Name(atd, "etmsDepartures") |> PrefixedName
    /// <summary>
    ///   <para>atd:hasASPMmetCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links meteorological information to the collection of temporally-dependent data associated with an airport.</para>
    /// labels<para>has ASPMmet condition</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#hasASPMmetCondition">https://data.nasa.gov/ontologies/atmonto/data#hasASPMmetCondition</seealso>
    let hasASPMmetCondition = Prefixed_Name(atd, "hasASPMmetCondition") |> PrefixedName
    /// <summary>
    ///   <para>atd:totalAirborneDelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Total airborne flight delay in minutes for this airport during the specified period.</para>
    /// labels<para>total airborne delay</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#totalAirborneDelay">https://data.nasa.gov/ontologies/atmonto/data#totalAirborneDelay</seealso>
    let totalAirborneDelay = Prefixed_Name(atd, "totalAirborneDelay") |> PrefixedName
    /// <summary>
    ///   <para>atd:hasMETARreport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a METAR reporting station with METAR weather reports generated for that station.</para>
    /// labels<para>has METARreport</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#hasMETARreport">https://data.nasa.gov/ontologies/atmonto/data#hasMETARreport</seealso>
    let hasMETARreport = Prefixed_Name(atd, "hasMETARreport") |> PrefixedName

    /// <summary>
    ///   <para>atd:lowVisibilityWITIdaily</para>
    /// </summary>
    /// <remarks>
    ///   <para>atd:WITIproperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The low visibility weather impacted traffic index (WITI) computed for the airport during the specified timeframe (daily). WITI is an estimate of the number of flights potentially impacted due to inclement weather based on the scheduled traffic demand for a defined geographic region of the air traffic system (in this case, an airport). If the visibility at the airport is below a set threshold, then the low visibility WITI is set to the number of scheduled arrivals for that timeframe.</para>
    /// labels<para>low visibility WITI daily</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#lowVisibilityWITIdaily">https://data.nasa.gov/ontologies/atmonto/data#lowVisibilityWITIdaily</seealso>
    let lowVisibilityWITIdaily =
        Prefixed_Name(atd, "lowVisibilityWITIdaily") |> PrefixedName

    /// <summary>
    ///   <para>atd:edctDepartureHold</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>EDCT (Estimated Departure Clearance Time) hold minutes at other airports departing this airport.</para>
    /// labels<para>EDCT departure hold</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#edctDepartureHold">https://data.nasa.gov/ontologies/atmonto/data#edctDepartureHold</seealso>
    let edctDepartureHold = Prefixed_Name(atd, "edctDepartureHold") |> PrefixedName
    /// <summary>
    ///   <para>atd:etmsArrivals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Count of arrivals at airport based on ETMS (Enhanced Traffic Management System) data.</para>
    /// labels<para>etms arrivals</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#etmsArrivals">https://data.nasa.gov/ontologies/atmonto/data#etmsArrivals</seealso>
    let etmsArrivals = Prefixed_Name(atd, "etmsArrivals") |> PrefixedName
    /// <summary>
    ///   <para>atd:forecastIssueTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The time that the TAF (Terminal Area Forecast) report was issued.</para>
    /// labels<para>forecast issue time</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#forecastIssueTime">https://data.nasa.gov/ontologies/atmonto/data#forecastIssueTime</seealso>
    let forecastIssueTime = Prefixed_Name(atd, "forecastIssueTime") |> PrefixedName
    /// <summary>
    ///   <para>atd:forecastingAirport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the airport for which the TAF (Terminal Area Forecast) report was compiled.</para>
    /// labels<para>forecasting airport</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#forecastingAirport">https://data.nasa.gov/ontologies/atmonto/data#forecastingAirport</seealso>
    let forecastingAirport = Prefixed_Name(atd, "forecastingAirport") |> PrefixedName

    /// <summary>
    ///   <para>atd:lowCeilingWITIhourly</para>
    /// </summary>
    /// <remarks>
    ///   <para>atd:WITIproperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The low ceiling weather impacted traffic index (WITI) computed for the airport during the specified timeframe (hourly). WITI is an estimate of the number of flights potentially impacted due to inclement weather based on the scheduled traffic demand for a defined geographic region of the air traffic system (in this case, an airport). If the ceiling at the airport is below a set threshold, then the low ceiling WITI is set to the number of scheduled arrivals for that timeframe.</para>
    /// labels<para>low ceiling WITI hourly</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#lowCeilingWITIhourly">https://data.nasa.gov/ontologies/atmonto/data#lowCeilingWITIhourly</seealso>
    let lowCeilingWITIhourly =
        Prefixed_Name(atd, "lowCeilingWITIhourly") |> PrefixedName

    /// <summary>
    ///   <para>atd:lowVisibilityWITIhourly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>atd:WITIproperty</para>
    ///   <para>The low visibility weather impacted traffic index (WITI) computed for the airport during the specified timeframe (hourly). WITI is an estimate of the number of flights potentially impacted due to inclement weather based on the scheduled traffic demand for a defined geographic region of the air traffic system (in this case, an airport). If the visibility at the airport is below a set threshold, then the low visibility WITI is set to the number of scheduled arrivals for that timeframe.</para>
    /// labels<para>low visibility WITI hourly</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#lowVisibilityWITIhourly">https://data.nasa.gov/ontologies/atmonto/data#lowVisibilityWITIhourly</seealso>
    let lowVisibilityWITIhourly =
        Prefixed_Name(atd, "lowVisibilityWITIhourly") |> PrefixedName

    /// <summary>
    ///   <para>atd:limitedVisibilityDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The visibility distance (in miles) at the reporting station. Only applicable if data:unlimitedVisibility is False.</para>
    /// labels<para>limited visibility distance</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#limitedVisibilityDistance">https://data.nasa.gov/ontologies/atmonto/data#limitedVisibilityDistance</seealso>
    let limitedVisibilityDistance =
        Prefixed_Name(atd, "limitedVisibilityDistance") |> PrefixedName

    /// <summary>
    ///   <para>atd:lowCeilingWITIdaily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>atd:WITIproperty</para>
    ///   <para>The low ceiling weather impacted traffic index (WITI) computed for the airport during the specified timeframe (daily). WITI is an estimate of the number of flights potentially impacted due to inclement weather based on the scheduled traffic demand for a defined geographic region of the air traffic system (in this case, an airport). If the ceiling at the airport is below a set threshold, then the low ceiling WITI is set to the number of scheduled arrivals for that timeframe.</para>
    /// labels<para>low ceiling WITI daily</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#lowCeilingWITIdaily">https://data.nasa.gov/ontologies/atmonto/data#lowCeilingWITIdaily</seealso>
    let lowCeilingWITIdaily = Prefixed_Name(atd, "lowCeilingWITIdaily") |> PrefixedName
    /// <summary>
    ///   <para>atd:unlimitedVisibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A binary property indicating whether the visibility conditions are unlimited.</para>
    /// labels<para>unlimited visibility</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#unlimitedVisibility">https://data.nasa.gov/ontologies/atmonto/data#unlimitedVisibility</seealso>
    let unlimitedVisibility = Prefixed_Name(atd, "unlimitedVisibility") |> PrefixedName
    /// <summary>
    ///   <para>atd:IntervalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>State data that has a temporal lifetime: a start and end time.</para>
    /// labels<para>Interval data</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#IntervalData">https://data.nasa.gov/ontologies/atmonto/data#IntervalData</seealso>
    let IntervalData = Prefixed_Name(atd, "IntervalData") |> PrefixedName

    /// <summary>
    ///   <para>atd:METARreportingStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A weather reporting station that provides sensor data for a METAR report. Many airports are also METAR reporting stations.</para>
    /// labels<para>METARreporting station</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#METARreportingStation">https://data.nasa.gov/ontologies/atmonto/data#METARreportingStation</seealso>
    let METARreportingStation =
        Prefixed_Name(atd, "METARreportingStation") |> PrefixedName

    /// <summary>
    ///   <para>atd:ASPMmeteorologicalCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Meteorological conditions reported as part of the ASPM hourly airport data. Includes sky, wind, visibility and weather components.</para>
    /// labels<para>ASPM meteorological condition</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#ASPMmeteorologicalCondition">https://data.nasa.gov/ontologies/atmonto/data#ASPMmeteorologicalCondition</seealso>
    let ASPMmeteorologicalCondition =
        Prefixed_Name(atd, "ASPMmeteorologicalCondition") |> PrefixedName

    /// <summary>
    ///   <para>atd:MeteorologicalCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A representation of the meteorological status for the specified time period, including sky, wind, visibility, and weather subcomponents.</para>
    /// labels<para>Meteorological condition</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#MeteorologicalCondition">https://data.nasa.gov/ontologies/atmonto/data#MeteorologicalCondition</seealso>
    let MeteorologicalCondition =
        Prefixed_Name(atd, "MeteorologicalCondition") |> PrefixedName

    /// <summary>
    ///   <para>atd:AirportData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a collection of airport data for a given time period, as reported by the FAA's ASPM system.</para>
    /// labels<para>Airport Data</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#AirportData">https://data.nasa.gov/ontologies/atmonto/data#AirportData</seealso>
    let AirportData = Prefixed_Name(atd, "AirportData") |> PrefixedName
    /// <summary>
    ///   <para>atd:aspmFlightRules</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Indicates what flight rule conditions the airport is operating under during the specified time period (I-instrument, V-Visual).</para>
    /// labels<para>ASPM Flight Rules</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#aspmFlightRules">https://data.nasa.gov/ontologies/atmonto/data#aspmFlightRules</seealso>
    let aspmFlightRules = Prefixed_Name(atd, "aspmFlightRules") |> PrefixedName
    /// <summary>
    ///   <para>atd:CloudLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a cloud layer, providing its bottom and top altitude, its cloud type, and its degree of coverage.</para>
    /// labels<para>Cloud layer</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#CloudLayer">https://data.nasa.gov/ontologies/atmonto/data#CloudLayer</seealso>
    let CloudLayer = Prefixed_Name(atd, "CloudLayer") |> PrefixedName
    /// <summary>
    ///   <para>atd:cloudType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>For a given homogeneous cloud layer, the type of cloud present: towering cumulus, cumulonimbus, altocumulus castellanus.</para>
    /// labels<para>cloud type</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#cloudType">https://data.nasa.gov/ontologies/atmonto/data#cloudType</seealso>
    let cloudType = Prefixed_Name(atd, "cloudType") |> PrefixedName
    /// <summary>
    ///   <para>atd:cloudCover</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>For a given homogenous cloud layer, the type of cloud cover present: clear, few clouds, scattered clouds, broken clouds, overcast, vertical visibility layer.</para>
    /// labels<para>cloud cover</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#cloudCover">https://data.nasa.gov/ontologies/atmonto/data#cloudCover</seealso>
    let cloudCover = Prefixed_Name(atd, "cloudCover") |> PrefixedName
    /// <summary>
    ///   <para>atd:CloudLayerProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sequence of cloud layers, ordered from the ground upward. Represents cloud conditions.</para>
    /// labels<para>Cloud layer profile</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#CloudLayerProfile">https://data.nasa.gov/ontologies/atmonto/data#CloudLayerProfile</seealso>
    let CloudLayerProfile = Prefixed_Name(atd, "CloudLayerProfile") |> PrefixedName
    /// <summary>
    ///   <para>atd:FixCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A subclass of interval-based data representing the maximum controllable number of aircraft flowing through a fix per some interval of time, given weather and other air traffic control constraints.</para>
    /// labels<para>Fix capacity</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#FixCapacity">https://data.nasa.gov/ontologies/atmonto/data#FixCapacity</seealso>
    let FixCapacity = Prefixed_Name(atd, "FixCapacity") |> PrefixedName
    /// <summary>
    ///   <para>atd:FixFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A subclass of interval-based data representing the number of aircraft flowing through a fix per some interval of time.</para>
    /// labels<para>Fix flow</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#FixFlow">https://data.nasa.gov/ontologies/atmonto/data#FixFlow</seealso>
    let FixFlow = Prefixed_Name(atd, "FixFlow") |> PrefixedName
    /// <summary>
    ///   <para>atd:METARreport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Meteorological conditions provided in a periodic METAR report. Includes sky, wind, visibility and weather components.</para>
    /// labels<para>METAR Report</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#METARreport">https://data.nasa.gov/ontologies/atmonto/data#METARreport</seealso>
    let METARreport = Prefixed_Name(atd, "METARreport") |> PrefixedName
    /// <summary>
    ///   <para>atd:metarReportType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>METAR report type indicator specifies whether this report is a regularly scheduled hourly report (METAR) or a special unscheduled report (SPECI). SPECIs are issued more frequently than hourly when adverse weather conditions prevail.</para>
    /// labels<para>metar report type</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#metarReportType">https://data.nasa.gov/ontologies/atmonto/data#metarReportType</seealso>
    let metarReportType = Prefixed_Name(atd, "metarReportType") |> PrefixedName
    /// <summary>
    ///   <para>atd:metarReportModifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Automation status information pertaining to a METAR report: AUTO indicates a fully automated report with no human intervention; COR indicates a corrected observation; no modifier indicates either human observer/reporter or automated report with human oversight.</para>
    /// labels<para>metar report modifier</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#metarReportModifier">https://data.nasa.gov/ontologies/atmonto/data#metarReportModifier</seealso>
    let metarReportModifier = Prefixed_Name(atd, "metarReportModifier") |> PrefixedName
    /// <summary>
    ///   <para>atd:MetCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A superclass over the various types of meteorological conditions.</para>
    /// labels<para>Meteorological condition</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#MetCondition">https://data.nasa.gov/ontologies/atmonto/data#MetCondition</seealso>
    let MetCondition = Prefixed_Name(atd, "MetCondition") |> PrefixedName

    /// <summary>
    ///   <para>atd:meteorologicalConditionStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An indicator of whether the meteorological condition is based on actual observations (observed) or on future projections (forecast).</para>
    /// labels<para>meteorological condition status</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#meteorologicalConditionStatus">https://data.nasa.gov/ontologies/atmonto/data#meteorologicalConditionStatus</seealso>
    let meteorologicalConditionStatus =
        Prefixed_Name(atd, "meteorologicalConditionStatus") |> PrefixedName

    /// <summary>
    ///   <para>atd:RunwayReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>A report on runway conditions during a specified interval of time, focusing on runway status (open vs. closed) and surface friction during winter precipitation.</para>
    /// </remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#RunwayReport">https://data.nasa.gov/ontologies/atmonto/data#RunwayReport</seealso>
    let RunwayReport = Prefixed_Name(atd, "RunwayReport") |> PrefixedName
    /// <summary>
    ///   <para>atd:RunwayStatusData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes a temporally-dependent set of data about the operating status of a physical runway.</para>
    /// labels<para>Runway status data</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#RunwayStatusData">https://data.nasa.gov/ontologies/atmonto/data#RunwayStatusData</seealso>
    let RunwayStatusData = Prefixed_Name(atd, "RunwayStatusData") |> PrefixedName
    /// <summary>
    ///   <para>atd:runwayStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An indicator of whether the runway is open or closed during the specified period.</para>
    /// labels<para>runway status</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#runwayStatus">https://data.nasa.gov/ontologies/atmonto/data#runwayStatus</seealso>
    let runwayStatus = Prefixed_Name(atd, "runwayStatus") |> PrefixedName
    /// <summary>
    ///   <para>atd:SectorCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A subclass of interval-based data representing the maximum number of controllable aircraft flowing through a sector during some interval of time.</para>
    /// labels<para>Sector capacity</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#SectorCapacity">https://data.nasa.gov/ontologies/atmonto/data#SectorCapacity</seealso>
    let SectorCapacity = Prefixed_Name(atd, "SectorCapacity") |> PrefixedName
    /// <summary>
    ///   <para>atd:SectorFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A subclass of interval-based data representing the number of aircraft flowing through a sector during some interval of time.</para>
    /// labels<para>Sector flow</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#SectorFlow">https://data.nasa.gov/ontologies/atmonto/data#SectorFlow</seealso>
    let SectorFlow = Prefixed_Name(atd, "SectorFlow") |> PrefixedName
    /// <summary>
    ///   <para>atd:SkyCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The current or forecast sky conditions, including the ceiling and information on the cloud layers present.</para>
    /// labels<para>Sky condition</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#SkyCondition">https://data.nasa.gov/ontologies/atmonto/data#SkyCondition</seealso>
    let SkyCondition = Prefixed_Name(atd, "SkyCondition") |> PrefixedName

    /// <summary>
    ///   <para>atd:SurfaceWindCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The current or forecast surface wind conditions.</para>
    /// labels<para>Surface wind condition</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#SurfaceWindCondition">https://data.nasa.gov/ontologies/atmonto/data#SurfaceWindCondition</seealso>
    let SurfaceWindCondition =
        Prefixed_Name(atd, "SurfaceWindCondition") |> PrefixedName

    /// <summary>
    ///   <para>atd:surfaceWindDirectionStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Information about the direction of the wind, either fixed, varyingWithinRange, or variable.</para>
    /// labels<para>surface wind direction status</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#surfaceWindDirectionStatus">https://data.nasa.gov/ontologies/atmonto/data#surfaceWindDirectionStatus</seealso>
    let surfaceWindDirectionStatus =
        Prefixed_Name(atd, "surfaceWindDirectionStatus") |> PrefixedName

    /// <summary>
    ///   <para>atd:TAFmeteorologicalCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Meteorological conditions reported as part of a TAF forecast. Includes sky, wind, visibility and weather components for current and future time periods.</para>
    /// labels<para>TAF meteorological condition</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#TAFmeteorologicalCondition">https://data.nasa.gov/ontologies/atmonto/data#TAFmeteorologicalCondition</seealso>
    let TAFmeteorologicalCondition =
        Prefixed_Name(atd, "TAFmeteorologicalCondition") |> PrefixedName

    /// <summary>
    ///   <para>atd:rapidityOfWeatherChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates how fast change is expected from the prior state to the forecast meteorological conditions: "rapid" , "gradual" , "transient".</para>
    /// labels<para>rapidity of weather change</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#rapidityOfWeatherChange">https://data.nasa.gov/ontologies/atmonto/data#rapidityOfWeatherChange</seealso>
    let rapidityOfWeatherChange =
        Prefixed_Name(atd, "rapidityOfWeatherChange") |> PrefixedName

    /// <summary>
    ///   <para>atd:TAFreport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Meteorological conditions provided in a periodic TAF forecast. Includes sky, wind, visibility and weather components.</para>
    /// labels<para>TAF report</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#TAFreport">https://data.nasa.gov/ontologies/atmonto/data#TAFreport</seealso>
    let TAFreport = Prefixed_Name(atd, "TAFreport") |> PrefixedName
    /// <summary>
    ///   <para>atd:tafReportType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type of Terminal Area Forecast (TAF) report: a routine report (TAF), an amended report (AMD), a corrected report (COR), or a delayed report (RTD). An amended TAF is issued when the current TAF no longer adequately describes the ongoing weather or the forecaster feels the TAF is not representative of the current or expected weather.</para>
    /// labels<para>taf report type</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#tafReportType">https://data.nasa.gov/ontologies/atmonto/data#tafReportType</seealso>
    let tafReportType = Prefixed_Name(atd, "tafReportType") |> PrefixedName
    /// <summary>
    ///   <para>atd:VisibilityCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The current or forecast surface visibility conditions at a given airport or other reporting station.</para>
    /// labels<para>Visibility condition</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#VisibilityCondition">https://data.nasa.gov/ontologies/atmonto/data#VisibilityCondition</seealso>
    let VisibilityCondition = Prefixed_Name(atd, "VisibilityCondition") |> PrefixedName
    /// <summary>
    ///   <para>atd:WITIproperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class of different properties relating to WITI (Weather-Impacted Traffic Index)</para>
    /// labels<para>WITIproperty</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#WITIproperty">https://data.nasa.gov/ontologies/atmonto/data#WITIproperty</seealso>
    let WITIproperty = Prefixed_Name(atd, "WITIproperty") |> PrefixedName
    /// <summary>
    ///   <para>atd:WeatherCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The current or forecast weather conditions at a given airport or other reporting station.</para>
    /// labels<para>Weather condition</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#WeatherCondition">https://data.nasa.gov/ontologies/atmonto/data#WeatherCondition</seealso>
    let WeatherCondition = Prefixed_Name(atd, "WeatherCondition") |> PrefixedName
    /// <summary>
    ///   <para>atd:weatherQualifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An additional qualifier describing the reported weather phenomenon: shallow, partial, patchy, low drifting, blowing, shower, thunderstorm, freezing.</para>
    /// labels<para>weather qualifier</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#weatherQualifier">https://data.nasa.gov/ontologies/atmonto/data#weatherQualifier</seealso>
    let weatherQualifier = Prefixed_Name(atd, "weatherQualifier") |> PrefixedName
    /// <summary>
    ///   <para>atd:weatherPhenomenon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Describes the type of weather phenomena experienced during the specified period: drizzle, rain, snow, snow grains, ice crystals, ice pellets, hail, small hail and/or snow pellets, unknown precipitation, mist, fog, smoke, volcanic ash, widespread dust, sand, haze, spray, well-developed dust/sand whirls, squalls, funnel cloud, tornado/waterspout, sandstorm, duststorm</para>
    /// labels<para>weather phenomenon</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#weatherPhenomenon">https://data.nasa.gov/ontologies/atmonto/data#weatherPhenomenon</seealso>
    let weatherPhenomenon = Prefixed_Name(atd, "weatherPhenomenon") |> PrefixedName
    /// <summary>
    ///   <para>atd:weatherIntensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An indicator of the intensity of the weather: light, moderate, heavy.</para>
    /// labels<para>weather intensity</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#weatherIntensity">https://data.nasa.gov/ontologies/atmonto/data#weatherIntensity</seealso>
    let weatherIntensity = Prefixed_Name(atd, "weatherIntensity") |> PrefixedName
    /// <summary>
    ///   <para>atd:weatherProximity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Describes the location of the weather phenomena in relation to the reporting station: immediate proximity or in vicinity.</para>
    /// labels<para>weather proximity</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#weatherProximity">https://data.nasa.gov/ontologies/atmonto/data#weatherProximity</seealso>
    let weatherProximity = Prefixed_Name(atd, "weatherProximity") |> PrefixedName
    /// <summary>
    ///   <para>atd:airportArrivalRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The arrival rate per hour set by the airport during the specified interval. This is the total number of aircraft that can arrive on all runways combined during an hour.</para>
    /// labels<para>airport arrival rate</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#airportArrivalRate">https://data.nasa.gov/ontologies/atmonto/data#airportArrivalRate</seealso>
    let airportArrivalRate = Prefixed_Name(atd, "airportArrivalRate") |> PrefixedName

    /// <summary>
    ///   <para>atd:airportDepartureRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The departure rate per hour set by the airport during the specified interval. This is the total number of aircraft that can depart from all runways combined during an hour.</para>
    /// labels<para>airport departure rate</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#airportDepartureRate">https://data.nasa.gov/ontologies/atmonto/data#airportDepartureRate</seealso>
    let airportDepartureRate =
        Prefixed_Name(atd, "airportDepartureRate") |> PrefixedName

    /// <summary>
    ///   <para>atd:arrivalDemand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The number of aircraft intending to arrive at an airport during the specified time period.</para>
    /// labels<para>arrival demand</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#arrivalDemand">https://data.nasa.gov/ontologies/atmonto/data#arrivalDemand</seealso>
    let arrivalDemand = Prefixed_Name(atd, "arrivalDemand") |> PrefixedName
    /// <summary>
    ///   <para>atd:baseAltitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>For a given homogeonous cloud layer, this is the lowest altitude.</para>
    /// labels<para>base altitude</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#baseAltitude">https://data.nasa.gov/ontologies/atmonto/data#baseAltitude</seealso>
    let baseAltitude = Prefixed_Name(atd, "baseAltitude") |> PrefixedName
    /// <summary>
    ///   <para>atd:ceiling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The vertical visibility (in feet) measured from the ground to the lowest cloud layer reported as broken or overcast.</para>
    /// labels<para>ceiling</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#ceiling">https://data.nasa.gov/ontologies/atmonto/data#ceiling</seealso>
    let ceiling = Prefixed_Name(atd, "ceiling") |> PrefixedName
    /// <summary>
    ///   <para>atd:dataIntervalEndDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links temporally-dependent data to the ending day of its period of validity.</para>
    /// labels<para>data interval end day</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#dataIntervalEndDay">https://data.nasa.gov/ontologies/atmonto/data#dataIntervalEndDay</seealso>
    let dataIntervalEndDay = Prefixed_Name(atd, "dataIntervalEndDay") |> PrefixedName
    /// <summary>
    ///   <para>atd:dataIntervalEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>For temporally-dependent data, the ending time of the data's period of validity.</para>
    /// labels<para>data interval end time</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#dataIntervalEndTime">https://data.nasa.gov/ontologies/atmonto/data#dataIntervalEndTime</seealso>
    let dataIntervalEndTime = Prefixed_Name(atd, "dataIntervalEndTime") |> PrefixedName

    /// <summary>
    ///   <para>atd:dataIntervalStartDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links temporally-dependent data to the starting day of its period of validity.</para>
    /// labels<para>data interval start day</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#dataIntervalStartDay">https://data.nasa.gov/ontologies/atmonto/data#dataIntervalStartDay</seealso>
    let dataIntervalStartDay =
        Prefixed_Name(atd, "dataIntervalStartDay") |> PrefixedName

    /// <summary>
    ///   <para>atd:dataIntervalStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>For temporally-dependent data, the starting time of the data's period of validity.</para>
    /// labels<para>data interval start time</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#dataIntervalStartTime">https://data.nasa.gov/ontologies/atmonto/data#dataIntervalStartTime</seealso>
    let dataIntervalStartTime =
        Prefixed_Name(atd, "dataIntervalStartTime") |> PrefixedName

    /// <summary>
    ///   <para>atd:departureDemand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of aircraft intending to depart during the specified time period.</para>
    /// labels<para>departure demand</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#departureDemand">https://data.nasa.gov/ontologies/atmonto/data#departureDemand</seealso>
    let departureDemand = Prefixed_Name(atd, "departureDemand") |> PrefixedName
    /// <summary>
    ///   <para>atd:dewpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The dewpoint recorded as part of a meteorological condition report.</para>
    /// labels<para>dewpoint</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#dewpoint">https://data.nasa.gov/ontologies/atmonto/data#dewpoint</seealso>
    let dewpoint = Prefixed_Name(atd, "dewpoint") |> PrefixedName
    /// <summary>
    ///   <para>atd:edctArrivalHold</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>EDCT (Estimated Departure Clearance Time) hold minutes at other airports arriving this airport.</para>
    /// labels<para>EDCT arrival hold</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#edctArrivalHold">https://data.nasa.gov/ontologies/atmonto/data#edctArrivalHold</seealso>
    let edctArrivalHold = Prefixed_Name(atd, "edctArrivalHold") |> PrefixedName
    /// <summary>
    ///   <para>atd:hasAirportData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an airport to a collection of temporally-dependent data pertinent to the airport conditions, including a variety of data collected in the ASPM system.</para>
    /// labels<para>has airport data</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#hasAirportData">https://data.nasa.gov/ontologies/atmonto/data#hasAirportData</seealso>
    let hasAirportData = Prefixed_Name(atd, "hasAirportData") |> PrefixedName

    /// <summary>
    ///   <para>atd:hasCloudLayerProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a sky condition to a representation of the cloud layers present.</para>
    /// labels<para>has cloud layer profile</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#hasCloudLayerProfile">https://data.nasa.gov/ontologies/atmonto/data#hasCloudLayerProfile</seealso>
    let hasCloudLayerProfile =
        Prefixed_Name(atd, "hasCloudLayerProfile") |> PrefixedName

    /// <summary>
    ///   <para>atd:hasSkyCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a meteorological condition with the details of the sky and cloud conditions at the reporting location..</para>
    /// labels<para>has sky condition</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#hasSkyCondition">https://data.nasa.gov/ontologies/atmonto/data#hasSkyCondition</seealso>
    let hasSkyCondition = Prefixed_Name(atd, "hasSkyCondition") |> PrefixedName

    /// <summary>
    ///   <para>atd:hasSurfaceWindCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a meteorological condition with the details of the surface wind conditions at the reporting location..</para>
    /// labels<para>has surface wind condition</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#hasSurfaceWindCondition">https://data.nasa.gov/ontologies/atmonto/data#hasSurfaceWindCondition</seealso>
    let hasSurfaceWindCondition =
        Prefixed_Name(atd, "hasSurfaceWindCondition") |> PrefixedName

    /// <summary>
    ///   <para>atd:hasVisibilityCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a meteorological condition with the details of the surface visibility conditions at the reporting location..</para>
    /// labels<para>has visibility condition</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#hasVisibilityCondition">https://data.nasa.gov/ontologies/atmonto/data#hasVisibilityCondition</seealso>
    let hasVisibilityCondition =
        Prefixed_Name(atd, "hasVisibilityCondition") |> PrefixedName

    /// <summary>
    ///   <para>atd:hasWeatherCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a meteorological condition with the details of the weather conditions at the reporting location.</para>
    /// labels<para>has weather condition</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#hasWeatherCondition">https://data.nasa.gov/ontologies/atmonto/data#hasWeatherCondition</seealso>
    let hasWeatherCondition = Prefixed_Name(atd, "hasWeatherCondition") |> PrefixedName
    /// <summary>
    ///   <para>atd:highWindWITIdaily</para>
    /// </summary>
    /// <remarks>
    ///   <para>atd:WITIproperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The high wind weather impacted traffic index (WITI) computed for the airport during the specified timeframe (daily). WITI is an estimate of the number of flights potentially impacted due to inclement weather based on the scheduled traffic demand for a defined geographic region of the air traffic system (in this case, an airport). If the winds at the airport are above a set threshold, then the high wind WITI is set to the number of scheduled arrivals for that timeframe.</para>
    /// labels<para>high wind WITI daily</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#highWindWITIdaily">https://data.nasa.gov/ontologies/atmonto/data#highWindWITIdaily</seealso>
    let highWindWITIdaily = Prefixed_Name(atd, "highWindWITIdaily") |> PrefixedName
    /// <summary>
    ///   <para>atd:highWindWITIhourly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>atd:WITIproperty</para>
    ///   <para>The high wind weather impacted traffic index (WITI) computed for the airport during the specified timeframe (hourly). WITI is an estimate of the number of flights potentially impacted due to inclement weather based on the scheduled traffic demand for a defined geographic region of the air traffic system (in this case, an airport). If the winds at the airport are above a set threshold, then the high wind WITI is set to the number of scheduled arrivals for that timeframe.</para>
    /// labels<para>high wind WITI hourly</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#highWindWITIhourly">https://data.nasa.gov/ontologies/atmonto/data#highWindWITIhourly</seealso>
    let highWindWITIhourly = Prefixed_Name(atd, "highWindWITIhourly") |> PrefixedName
    /// <summary>
    ///   <para>atd:hourlyPrecipitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Recorded hourly precipitation rate at the measurement station in inches.</para>
    /// labels<para>hourly precipitation</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#hourlyPrecipitation">https://data.nasa.gov/ontologies/atmonto/data#hourlyPrecipitation</seealso>
    let hourlyPrecipitation = Prefixed_Name(atd, "hourlyPrecipitation") |> PrefixedName

    /// <summary>
    ///   <para>atd:metConditionProbability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>For a forecast meteorological condition, the percent probability associated with the forecast occurrence.</para>
    /// labels<para>met condition probability</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#metConditionProbability">https://data.nasa.gov/ontologies/atmonto/data#metConditionProbability</seealso>
    let metConditionProbability =
        Prefixed_Name(atd, "metConditionProbability") |> PrefixedName

    /// <summary>
    ///   <para>atd:metarReportString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Entire text of METAR report.</para>
    /// labels<para>METAR report string</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#metarReportString">https://data.nasa.gov/ontologies/atmonto/data#metarReportString</seealso>
    let metarReportString = Prefixed_Name(atd, "metarReportString") |> PrefixedName

    /// <summary>
    ///   <para>atd:metarStationHasPrecipitationSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A boolean value indicating whether the reporting METAR station has a precipitation sensor.</para>
    /// labels<para>metar station has precipitation sensor</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#metarStationHasPrecipitationSensor">https://data.nasa.gov/ontologies/atmonto/data#metarStationHasPrecipitationSensor</seealso>
    let metarStationHasPrecipitationSensor =
        Prefixed_Name(atd, "metarStationHasPrecipitationSensor") |> PrefixedName

    /// <summary>
    ///   <para>atd:oagArrivalDelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Minutes of OAG (Official Airline Guide) based arrival delay in excess of 15 minutes.</para>
    /// labels<para>OAG arrival delay</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#oagArrivalDelay">https://data.nasa.gov/ontologies/atmonto/data#oagArrivalDelay</seealso>
    let oagArrivalDelay = Prefixed_Name(atd, "oagArrivalDelay") |> PrefixedName

    /// <summary>
    ///   <para>atd:oagGateDepartureDelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Minutes of OAG (Official Airline Guide) based gate departure delay in excess of 15 minutes.</para>
    /// labels<para>OAG gate departure delay</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#oagGateDepartureDelay">https://data.nasa.gov/ontologies/atmonto/data#oagGateDepartureDelay</seealso>
    let oagGateDepartureDelay =
        Prefixed_Name(atd, "oagGateDepartureDelay") |> PrefixedName

    /// <summary>
    ///   <para>atd:runwayReportedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a runway status report with the physical runway being measured.</para>
    /// labels<para>runway reported on</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#runwayReportedOn">https://data.nasa.gov/ontologies/atmonto/data#runwayReportedOn</seealso>
    let runwayReportedOn = Prefixed_Name(atd, "runwayReportedOn") |> PrefixedName
    /// <summary>
    ///   <para>atd:runwayVisibleRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Links a visibility condition to a runway visible range measurement class instance.</para>
    /// labels<para>runway visible range</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#runwayVisibleRange">https://data.nasa.gov/ontologies/atmonto/data#runwayVisibleRange</seealso>
    let runwayVisibleRange = Prefixed_Name(atd, "runwayVisibleRange") |> PrefixedName
    /// <summary>
    ///   <para>atd:scheduledArrivals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Count of scheduled arrivals. (Most probably from OAG (Official Airline Guide))</para>
    /// labels<para>scheduled arrivals</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#scheduledArrivals">https://data.nasa.gov/ontologies/atmonto/data#scheduledArrivals</seealso>
    let scheduledArrivals = Prefixed_Name(atd, "scheduledArrivals") |> PrefixedName
    /// <summary>
    ///   <para>atd:scheduledDepartures</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Count of scheduled departures. (Most probably from OAG (Official Airline Guide))</para>
    /// labels<para>scheduled departures</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#scheduledDepartures">https://data.nasa.gov/ontologies/atmonto/data#scheduledDepartures</seealso>
    let scheduledDepartures = Prefixed_Name(atd, "scheduledDepartures") |> PrefixedName
    /// <summary>
    ///   <para>atd:seaLevelPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Sea level pressure measured under the associated meteorological conditions.</para>
    /// labels<para>sea level pressure</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#seaLevelPressure">https://data.nasa.gov/ontologies/atmonto/data#seaLevelPressure</seealso>
    let seaLevelPressure = Prefixed_Name(atd, "seaLevelPressure") |> PrefixedName
    /// <summary>
    ///   <para>atd:surfaceGustSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Surface gust speed measured under the associated surface wind conditions.</para>
    /// labels<para>surface gust speed</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#surfaceGustSpeed">https://data.nasa.gov/ontologies/atmonto/data#surfaceGustSpeed</seealso>
    let surfaceGustSpeed = Prefixed_Name(atd, "surfaceGustSpeed") |> PrefixedName
    /// <summary>
    ///   <para>atd:surfaceTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Surface temperature measured under the associated meteorological conditions.</para>
    /// labels<para>surface temperature</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#surfaceTemperature">https://data.nasa.gov/ontologies/atmonto/data#surfaceTemperature</seealso>
    let surfaceTemperature = Prefixed_Name(atd, "surfaceTemperature") |> PrefixedName
    /// <summary>
    ///   <para>atd:surfaceWindSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The speed in knots of the surface wind.</para>
    /// labels<para>surface wind speed</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#surfaceWindSpeed">https://data.nasa.gov/ontologies/atmonto/data#surfaceWindSpeed</seealso>
    let surfaceWindSpeed = Prefixed_Name(atd, "surfaceWindSpeed") |> PrefixedName
    /// <summary>
    ///   <para>atd:tafReportString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The full text of the entire TAF report.</para>
    /// labels<para>taf report string</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#tafReportString">https://data.nasa.gov/ontologies/atmonto/data#tafReportString</seealso>
    let tafReportString = Prefixed_Name(atd, "tafReportString") |> PrefixedName
    /// <summary>
    ///   <para>atd:topAltitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The top altitude of a homogenous cloud layer.</para>
    /// labels<para>top altitude</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#topAltitude">https://data.nasa.gov/ontologies/atmonto/data#topAltitude</seealso>
    let topAltitude = Prefixed_Name(atd, "topAltitude") |> PrefixedName
    /// <summary>
    ///   <para>atd:windDirectionFixed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Steady wind direction (in degrees), when winds are fixed and not variable.</para>
    /// labels<para>fixed wind direction</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#windDirectionFixed">https://data.nasa.gov/ontologies/atmonto/data#windDirectionFixed</seealso>
    let windDirectionFixed = Prefixed_Name(atd, "windDirectionFixed") |> PrefixedName
    /// <summary>
    ///   <para>atd:windDirectionLower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Lower bound (in degrees) of two bounding values describing a variable wind direction.</para>
    /// labels<para>lower wind direction</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#windDirectionLower">https://data.nasa.gov/ontologies/atmonto/data#windDirectionLower</seealso>
    let windDirectionLower = Prefixed_Name(atd, "windDirectionLower") |> PrefixedName
    /// <summary>
    ///   <para>atd:windDirectionUpper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Upper bound (in degrees) of two bounding values describing a variable wind direction.</para>
    /// labels<para>lower wind direction</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#windDirectionUpper">https://data.nasa.gov/ontologies/atmonto/data#windDirectionUpper</seealso>
    let windDirectionUpper = Prefixed_Name(atd, "windDirectionUpper") |> PrefixedName
    /// <summary>
    ///   <para>atd:windShearHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The height in hundreds of feet above ground level associated with a wind shear phenomenon.</para>
    /// labels<para>wind shear height</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/data#windShearHeight">https://data.nasa.gov/ontologies/atmonto/data#windShearHeight</seealso>
    let windShearHeight = Prefixed_Name(atd, "windShearHeight") |> PrefixedName
