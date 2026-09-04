#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module atd =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://data.nasa.gov/ontologies/atmonto/data#" "atd"

    /// <summary>
    ///   <para>rdfs:label : ASPM meteorological condition^^xsd:string</para>
    ///   <para>rdfs:comment : Meteorological conditions reported as part of the ASPM hourly airport data. Includes sky, wind, visibility and weather components.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#ASPMmeteorologicalCondition">atd:ASPMmeteorologicalCondition</a>
    /// </summary>
    let ASPMmeteorologicalCondition = _prefixId.prefix "ASPMmeteorologicalCondition"
    /// <summary>
    ///   <para>rdfs:label : Airport Data^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a collection of airport data for a given time period, as reported by the FAA's ASPM system.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#AirportData">atd:AirportData</a>
    /// </summary>
    let AirportData = _prefixId.prefix "AirportData"
    /// <summary>
    ///   <para>rdfs:label : Cloud layer^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a cloud layer, providing its bottom and top altitude, its cloud type, and its degree of coverage.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#CloudLayer">atd:CloudLayer</a>
    /// </summary>
    let CloudLayer = _prefixId.prefix "CloudLayer"
    /// <summary>
    ///   <para>rdfs:label : Cloud layer profile^^xsd:string</para>
    ///   <para>rdfs:comment : A sequence of cloud layers, ordered from the ground upward. Represents cloud conditions.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#CloudLayerProfile">atd:CloudLayerProfile</a>
    /// </summary>
    let CloudLayerProfile = _prefixId.prefix "CloudLayerProfile"
    /// <summary>
    ///   <para>rdfs:label : Fix capacity^^xsd:string</para>
    ///   <para>rdfs:comment : A subclass of interval-based data representing the maximum controllable number of aircraft flowing through a fix per some interval of time, given weather and other air traffic control constraints.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#FixCapacity">atd:FixCapacity</a>
    /// </summary>
    let FixCapacity = _prefixId.prefix "FixCapacity"
    /// <summary>
    ///   <para>rdfs:label : Fix flow^^xsd:string</para>
    ///   <para>rdfs:comment : A subclass of interval-based data representing the number of aircraft flowing through a fix per some interval of time.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#FixFlow">atd:FixFlow</a>
    /// </summary>
    let FixFlow = _prefixId.prefix "FixFlow"
    /// <summary>
    ///   <para>rdfs:label : Interval data^^xsd:string</para>
    ///   <para>rdfs:comment : State data that has a temporal lifetime: a start and end time.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#IntervalData">atd:IntervalData</a>
    /// </summary>
    let IntervalData = _prefixId.prefix "IntervalData"
    /// <summary>
    ///   <para>rdfs:label : METAR Report^^xsd:string</para>
    ///   <para>rdfs:comment : Meteorological conditions provided in a periodic METAR report. Includes sky, wind, visibility and weather components.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#METARreport">atd:METARreport</a>
    /// </summary>
    let METARreport = _prefixId.prefix "METARreport"
    /// <summary>
    ///   <para>rdfs:label : METARreporting station^^xsd:string</para>
    ///   <para>rdfs:comment : A weather reporting station that provides sensor data for a METAR report. Many airports are also METAR reporting stations.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#METARreportingStation">atd:METARreportingStation</a>
    /// </summary>
    let METARreportingStation = _prefixId.prefix "METARreportingStation"
    /// <summary>
    ///   <para>rdfs:label : Meteorological condition^^xsd:string</para>
    ///   <para>rdfs:comment : A superclass over the various types of meteorological conditions.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#MetCondition">atd:MetCondition</a>
    /// </summary>
    let MetCondition = _prefixId.prefix "MetCondition"
    /// <summary>
    ///   <para>rdfs:label : Meteorological condition^^xsd:string</para>
    ///   <para>rdfs:comment : A representation of the meteorological status for the specified time period, including sky, wind, visibility, and weather subcomponents.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#MeteorologicalCondition">atd:MeteorologicalCondition</a>
    /// </summary>
    let MeteorologicalCondition = _prefixId.prefix "MeteorologicalCondition"
    let RunwayReport = _prefixId.prefix "RunwayReport"
    /// <summary>
    ///   <para>rdfs:label : Runway status data^^xsd:string</para>
    ///   <para>rdfs:comment : This class describes a temporally-dependent set of data about the operating status of a physical runway.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#RunwayStatusData">atd:RunwayStatusData</a>
    /// </summary>
    let RunwayStatusData = _prefixId.prefix "RunwayStatusData"
    /// <summary>
    ///   <para>rdfs:label : Sector capacity^^xsd:string</para>
    ///   <para>rdfs:comment : A subclass of interval-based data representing the maximum number of controllable aircraft flowing through a sector during some interval of time.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#SectorCapacity">atd:SectorCapacity</a>
    /// </summary>
    let SectorCapacity = _prefixId.prefix "SectorCapacity"
    /// <summary>
    ///   <para>rdfs:label : Sector flow^^xsd:string</para>
    ///   <para>rdfs:comment : A subclass of interval-based data representing the number of aircraft flowing through a sector during some interval of time.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#SectorFlow">atd:SectorFlow</a>
    /// </summary>
    let SectorFlow = _prefixId.prefix "SectorFlow"
    /// <summary>
    ///   <para>rdfs:label : Sky condition^^xsd:string</para>
    ///   <para>rdfs:comment : The current or forecast sky conditions, including the ceiling and information on the cloud layers present.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#SkyCondition">atd:SkyCondition</a>
    /// </summary>
    let SkyCondition = _prefixId.prefix "SkyCondition"
    /// <summary>
    ///   <para>rdfs:label : Surface wind condition^^xsd:string</para>
    ///   <para>rdfs:comment : The current or forecast surface wind conditions.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#SurfaceWindCondition">atd:SurfaceWindCondition</a>
    /// </summary>
    let SurfaceWindCondition = _prefixId.prefix "SurfaceWindCondition"
    /// <summary>
    ///   <para>rdfs:label : TAF meteorological condition^^xsd:string</para>
    ///   <para>rdfs:comment : Meteorological conditions reported as part of a TAF forecast. Includes sky, wind, visibility and weather components for current and future time periods.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#TAFmeteorologicalCondition">atd:TAFmeteorologicalCondition</a>
    /// </summary>
    let TAFmeteorologicalCondition = _prefixId.prefix "TAFmeteorologicalCondition"
    /// <summary>
    ///   <para>rdfs:label : TAF report^^xsd:string</para>
    ///   <para>rdfs:comment : Meteorological conditions provided in a periodic TAF forecast. Includes sky, wind, visibility and weather components.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#TAFreport">atd:TAFreport</a>
    /// </summary>
    let TAFreport = _prefixId.prefix "TAFreport"
    /// <summary>
    ///   <para>rdfs:label : Visibility condition^^xsd:string</para>
    ///   <para>rdfs:comment : The current or forecast surface visibility conditions at a given airport or other reporting station.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#VisibilityCondition">atd:VisibilityCondition</a>
    /// </summary>
    let VisibilityCondition = _prefixId.prefix "VisibilityCondition"
    /// <summary>
    ///   <para>rdfs:label : WITIproperty^^xsd:string</para>
    ///   <para>rdfs:comment : A class of different properties relating to WITI (Weather-Impacted Traffic Index)^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#WITIproperty">atd:WITIproperty</a>
    /// </summary>
    let WITIproperty = _prefixId.prefix "WITIproperty"
    /// <summary>
    ///   <para>rdfs:label : Weather condition^^xsd:string</para>
    ///   <para>rdfs:comment : The current or forecast weather conditions at a given airport or other reporting station.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#WeatherCondition">atd:WeatherCondition</a>
    /// </summary>
    let WeatherCondition = _prefixId.prefix "WeatherCondition"
    /// <summary>
    ///   <para>rdfs:label : airport arrival rate^^xsd:string</para>
    ///   <para>rdfs:comment : The arrival rate per hour set by the airport during the specified interval. This is the total number of aircraft that can arrive on all runways combined during an hour.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#airportArrivalRate">atd:airportArrivalRate</a>
    /// </summary>
    let airportArrivalRate = _prefixId.prefix "airportArrivalRate"
    /// <summary>
    ///   <para>rdfs:label : airport departure rate^^xsd:string</para>
    ///   <para>rdfs:comment : The departure rate per hour set by the airport during the specified interval. This is the total number of aircraft that can depart from all runways combined during an hour.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#airportDepartureRate">atd:airportDepartureRate</a>
    /// </summary>
    let airportDepartureRate = _prefixId.prefix "airportDepartureRate"
    /// <summary>
    ///   <para>rdfs:label : arrival demand^^xsd:string</para>
    ///   <para>rdfs:comment : The number of aircraft intending to arrive at an airport during the specified time period.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#arrivalDemand">atd:arrivalDemand</a>
    /// </summary>
    let arrivalDemand = _prefixId.prefix "arrivalDemand"
    /// <summary>
    ///   <para>rdfs:label : ASPM Flight Rules^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates what flight rule conditions the airport is operating under during the specified time period (I-instrument, V-Visual).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#aspmFlightRules">atd:aspmFlightRules</a>
    /// </summary>
    let aspmFlightRules = _prefixId.prefix "aspmFlightRules"

    /// <summary>
    ///   <para>rdfs:label : METAR reporting station^^xsd:string</para>
    ///   <para>rdfs:comment : Links a METAR report to the reporting station where the data were collected.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#associatedMETARreportingStation">atd:associatedMETARreportingStation</a>
    /// </summary>
    let associatedMETARreportingStation =
        _prefixId.prefix "associatedMETARreportingStation"

    /// <summary>
    ///   <para>rdfs:label : base altitude^^xsd:string</para>
    ///   <para>rdfs:comment : For a given homogeonous cloud layer, this is the lowest altitude.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#baseAltitude">atd:baseAltitude</a>
    /// </summary>
    let baseAltitude = _prefixId.prefix "baseAltitude"
    /// <summary>
    ///   <para>rdfs:label : ceiling^^xsd:string</para>
    ///   <para>rdfs:comment : The vertical visibility (in feet) measured from the ground to the lowest cloud layer reported as broken or overcast.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#ceiling">atd:ceiling</a>
    /// </summary>
    let ceiling = _prefixId.prefix "ceiling"
    /// <summary>
    ///   <para>rdfs:label : cloud cover^^xsd:string</para>
    ///   <para>rdfs:comment : For a given homogenous cloud layer, the type of cloud cover present: clear, few clouds, scattered clouds, broken clouds, overcast, vertical visibility layer.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#cloudCover">atd:cloudCover</a>
    /// </summary>
    let cloudCover = _prefixId.prefix "cloudCover"
    /// <summary>
    ///   <para>rdfs:label : cloud type^^xsd:string</para>
    ///   <para>rdfs:comment : For a given homogeneous cloud layer, the type of cloud present: towering cumulus, cumulonimbus, altocumulus castellanus.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#cloudType">atd:cloudType</a>
    /// </summary>
    let cloudType = _prefixId.prefix "cloudType"
    /// <summary>
    ///   <para>rdfs:label : data interval end day^^xsd:string</para>
    ///   <para>rdfs:comment : Links temporally-dependent data to the ending day of its period of validity.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#dataIntervalEndDay">atd:dataIntervalEndDay</a>
    /// </summary>
    let dataIntervalEndDay = _prefixId.prefix "dataIntervalEndDay"
    /// <summary>
    ///   <para>rdfs:label : data interval end time^^xsd:string</para>
    ///   <para>rdfs:comment : For temporally-dependent data, the ending time of the data's period of validity.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#dataIntervalEndTime">atd:dataIntervalEndTime</a>
    /// </summary>
    let dataIntervalEndTime = _prefixId.prefix "dataIntervalEndTime"
    /// <summary>
    ///   <para>rdfs:label : data interval start day^^xsd:string</para>
    ///   <para>rdfs:comment : Links temporally-dependent data to the starting day of its period of validity.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#dataIntervalStartDay">atd:dataIntervalStartDay</a>
    /// </summary>
    let dataIntervalStartDay = _prefixId.prefix "dataIntervalStartDay"
    /// <summary>
    ///   <para>rdfs:label : data interval start time^^xsd:string</para>
    ///   <para>rdfs:comment : For temporally-dependent data, the starting time of the data's period of validity.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#dataIntervalStartTime">atd:dataIntervalStartTime</a>
    /// </summary>
    let dataIntervalStartTime = _prefixId.prefix "dataIntervalStartTime"
    /// <summary>
    ///   <para>rdfs:label : departure demand^^xsd:string</para>
    ///   <para>rdfs:comment : The number of aircraft intending to depart during the specified time period.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#departureDemand">atd:departureDemand</a>
    /// </summary>
    let departureDemand = _prefixId.prefix "departureDemand"
    /// <summary>
    ///   <para>rdfs:label : dewpoint^^xsd:string</para>
    ///   <para>rdfs:comment : The dewpoint recorded as part of a meteorological condition report.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#dewpoint">atd:dewpoint</a>
    /// </summary>
    let dewpoint = _prefixId.prefix "dewpoint"
    /// <summary>
    ///   <para>rdfs:label : EDCT arrival hold^^xsd:string</para>
    ///   <para>rdfs:comment : EDCT (Estimated Departure Clearance Time) hold minutes at other airports arriving this airport.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#edctArrivalHold">atd:edctArrivalHold</a>
    /// </summary>
    let edctArrivalHold = _prefixId.prefix "edctArrivalHold"
    /// <summary>
    ///   <para>rdfs:label : EDCT departure hold^^xsd:string</para>
    ///   <para>rdfs:comment : EDCT (Estimated Departure Clearance Time) hold minutes at other airports departing this airport.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#edctDepartureHold">atd:edctDepartureHold</a>
    /// </summary>
    let edctDepartureHold = _prefixId.prefix "edctDepartureHold"
    /// <summary>
    ///   <para>rdfs:label : etms arrivals^^xsd:string</para>
    ///   <para>rdfs:comment : Count of arrivals at airport based on ETMS (Enhanced Traffic Management System) data.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#etmsArrivals">atd:etmsArrivals</a>
    /// </summary>
    let etmsArrivals = _prefixId.prefix "etmsArrivals"
    /// <summary>
    ///   <para>rdfs:label : etms arrivals^^xsd:string</para>
    ///   <para>rdfs:comment : Count of departures at airport based on ETMS (Enhanced Traffic Management System) data.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#etmsDepartures">atd:etmsDepartures</a>
    /// </summary>
    let etmsDepartures = _prefixId.prefix "etmsDepartures"
    /// <summary>
    ///   <para>rdfs:label : forecast issue time^^xsd:string</para>
    ///   <para>rdfs:comment : The time that the TAF (Terminal Area Forecast) report was issued.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#forecastIssueTime">atd:forecastIssueTime</a>
    /// </summary>
    let forecastIssueTime = _prefixId.prefix "forecastIssueTime"
    /// <summary>
    ///   <para>rdfs:label : forecasting airport^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the airport for which the TAF (Terminal Area Forecast) report was compiled.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#forecastingAirport">atd:forecastingAirport</a>
    /// </summary>
    let forecastingAirport = _prefixId.prefix "forecastingAirport"
    /// <summary>
    ///   <para>rdfs:label : has ASPMmet condition^^xsd:string</para>
    ///   <para>rdfs:comment : Links meteorological information to the collection of temporally-dependent data associated with an airport.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#hasASPMmetCondition">atd:hasASPMmetCondition</a>
    /// </summary>
    let hasASPMmetCondition = _prefixId.prefix "hasASPMmetCondition"
    /// <summary>
    ///   <para>rdfs:label : has airport data^^xsd:string</para>
    ///   <para>rdfs:comment : Links an airport to a collection of temporally-dependent data pertinent to the airport conditions, including a variety of data collected in the ASPM system.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#hasAirportData">atd:hasAirportData</a>
    /// </summary>
    let hasAirportData = _prefixId.prefix "hasAirportData"
    /// <summary>
    ///   <para>rdfs:label : has cloud layer profile^^xsd:string</para>
    ///   <para>rdfs:comment : Links a sky condition to a representation of the cloud layers present.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#hasCloudLayerProfile">atd:hasCloudLayerProfile</a>
    /// </summary>
    let hasCloudLayerProfile = _prefixId.prefix "hasCloudLayerProfile"
    /// <summary>
    ///   <para>rdfs:label : has METARreport^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a METAR reporting station with METAR weather reports generated for that station.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#hasMETARreport">atd:hasMETARreport</a>
    /// </summary>
    let hasMETARreport = _prefixId.prefix "hasMETARreport"
    /// <summary>
    ///   <para>rdfs:label : has sky condition^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a meteorological condition with the details of the sky and cloud conditions at the reporting location..^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#hasSkyCondition">atd:hasSkyCondition</a>
    /// </summary>
    let hasSkyCondition = _prefixId.prefix "hasSkyCondition"
    /// <summary>
    ///   <para>rdfs:label : has surface wind condition^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a meteorological condition with the details of the surface wind conditions at the reporting location..^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#hasSurfaceWindCondition">atd:hasSurfaceWindCondition</a>
    /// </summary>
    let hasSurfaceWindCondition = _prefixId.prefix "hasSurfaceWindCondition"
    /// <summary>
    ///   <para>rdfs:label : has TAFreport^^xsd:string</para>
    ///   <para>rdfs:comment : Associates an airport with TAF weather reports generated for that airport.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#hasTAFreport">atd:hasTAFreport</a>
    /// </summary>
    let hasTAFreport = _prefixId.prefix "hasTAFreport"
    /// <summary>
    ///   <para>rdfs:label : has visibility condition^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a meteorological condition with the details of the surface visibility conditions at the reporting location..^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#hasVisibilityCondition">atd:hasVisibilityCondition</a>
    /// </summary>
    let hasVisibilityCondition = _prefixId.prefix "hasVisibilityCondition"
    /// <summary>
    ///   <para>rdfs:label : has weather condition^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a meteorological condition with the details of the weather conditions at the reporting location.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#hasWeatherCondition">atd:hasWeatherCondition</a>
    /// </summary>
    let hasWeatherCondition = _prefixId.prefix "hasWeatherCondition"
    let highWindWITIdaily = _prefixId.prefix "highWindWITIdaily"
    let highWindWITIhourly = _prefixId.prefix "highWindWITIhourly"
    /// <summary>
    ///   <para>rdfs:label : hourly precipitation^^xsd:string</para>
    ///   <para>rdfs:comment : Recorded hourly precipitation rate at the measurement station in inches.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#hourlyPrecipitation">atd:hourlyPrecipitation</a>
    /// </summary>
    let hourlyPrecipitation = _prefixId.prefix "hourlyPrecipitation"
    /// <summary>
    ///   <para>rdfs:label : limited visibility distance^^xsd:string</para>
    ///   <para>rdfs:comment : The visibility distance (in miles) at the reporting station. Only applicable if data:unlimitedVisibility is False.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#limitedVisibilityDistance">atd:limitedVisibilityDistance</a>
    /// </summary>
    let limitedVisibilityDistance = _prefixId.prefix "limitedVisibilityDistance"
    let lowCeilingWITIdaily = _prefixId.prefix "lowCeilingWITIdaily"
    let lowCeilingWITIhourly = _prefixId.prefix "lowCeilingWITIhourly"
    let lowVisibilityWITIdaily = _prefixId.prefix "lowVisibilityWITIdaily"
    let lowVisibilityWITIhourly = _prefixId.prefix "lowVisibilityWITIhourly"
    /// <summary>
    ///   <para>rdfs:label : met condition probability^^xsd:string</para>
    ///   <para>rdfs:comment : For a forecast meteorological condition, the percent probability associated with the forecast occurrence.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#metConditionProbability">atd:metConditionProbability</a>
    /// </summary>
    let metConditionProbability = _prefixId.prefix "metConditionProbability"
    /// <summary>
    ///   <para>rdfs:label : metar report modifier^^xsd:string</para>
    ///   <para>rdfs:comment : Automation status information pertaining to a METAR report: AUTO indicates a fully automated report with no human intervention; COR indicates a corrected observation; no modifier indicates either human observer/reporter or automated report with human oversight.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#metarReportModifier">atd:metarReportModifier</a>
    /// </summary>
    let metarReportModifier = _prefixId.prefix "metarReportModifier"
    /// <summary>
    ///   <para>rdfs:label : METAR report string^^xsd:string</para>
    ///   <para>rdfs:comment : Entire text of METAR report.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#metarReportString">atd:metarReportString</a>
    /// </summary>
    let metarReportString = _prefixId.prefix "metarReportString"
    /// <summary>
    ///   <para>rdfs:label : metar report type^^xsd:string</para>
    ///   <para>rdfs:comment : METAR report type indicator specifies whether this report is a regularly scheduled hourly report (METAR) or a special unscheduled report (SPECI). SPECIs are issued more frequently than hourly when adverse weather conditions prevail.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#metarReportType">atd:metarReportType</a>
    /// </summary>
    let metarReportType = _prefixId.prefix "metarReportType"

    /// <summary>
    ///   <para>rdfs:label : metar station has precipitation sensor^^xsd:string</para>
    ///   <para>rdfs:comment : A boolean value indicating whether the reporting METAR station has a precipitation sensor.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#metarStationHasPrecipitationSensor">atd:metarStationHasPrecipitationSensor</a>
    /// </summary>
    let metarStationHasPrecipitationSensor =
        _prefixId.prefix "metarStationHasPrecipitationSensor"

    /// <summary>
    ///   <para>rdfs:label : meteorological condition status^^xsd:string</para>
    ///   <para>rdfs:comment : An indicator of whether the meteorological condition is based on actual observations (observed) or on future projections (forecast).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#meteorologicalConditionStatus">atd:meteorologicalConditionStatus</a>
    /// </summary>
    let meteorologicalConditionStatus = _prefixId.prefix "meteorologicalConditionStatus"
    /// <summary>
    ///   <para>rdfs:label : OAG arrival delay^^xsd:string</para>
    ///   <para>rdfs:comment : Minutes of OAG (Official Airline Guide) based arrival delay in excess of 15 minutes.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#oagArrivalDelay">atd:oagArrivalDelay</a>
    /// </summary>
    let oagArrivalDelay = _prefixId.prefix "oagArrivalDelay"
    /// <summary>
    ///   <para>rdfs:label : OAG gate departure delay^^xsd:string</para>
    ///   <para>rdfs:comment : Minutes of OAG (Official Airline Guide) based gate departure delay in excess of 15 minutes.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#oagGateDepartureDelay">atd:oagGateDepartureDelay</a>
    /// </summary>
    let oagGateDepartureDelay = _prefixId.prefix "oagGateDepartureDelay"
    /// <summary>
    ///   <para>rdfs:label : rapidity of weather change^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates how fast change is expected from the prior state to the forecast meteorological conditions: "rapid" , "gradual" , "transient".^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#rapidityOfWeatherChange">atd:rapidityOfWeatherChange</a>
    /// </summary>
    let rapidityOfWeatherChange = _prefixId.prefix "rapidityOfWeatherChange"
    /// <summary>
    ///   <para>rdfs:label : runway reported on^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a runway status report with the physical runway being measured.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#runwayReportedOn">atd:runwayReportedOn</a>
    /// </summary>
    let runwayReportedOn = _prefixId.prefix "runwayReportedOn"
    /// <summary>
    ///   <para>rdfs:label : runway status^^xsd:string</para>
    ///   <para>rdfs:comment : An indicator of whether the runway is open or closed during the specified period.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#runwayStatus">atd:runwayStatus</a>
    /// </summary>
    let runwayStatus = _prefixId.prefix "runwayStatus"
    /// <summary>
    ///   <para>rdfs:label : runway surface friction (mu)^^xsd:string</para>
    ///   <para>rdfs:comment : The surface friction (mu) value of the runway for the specified period. Runway surface friction is directly relevant to the braking action which will be available to an aircraft decelerating after touch down, or after a decision to reject a take off.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#runwaySurfaceFriction">atd:runwaySurfaceFriction</a>
    /// </summary>
    let runwaySurfaceFriction = _prefixId.prefix "runwaySurfaceFriction"
    /// <summary>
    ///   <para>rdfs:label : runway visible range^^xsd:string</para>
    ///   <para>rdfs:comment : Links a visibility condition to a runway visible range measurement class instance.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#runwayVisibleRange">atd:runwayVisibleRange</a>
    /// </summary>
    let runwayVisibleRange = _prefixId.prefix "runwayVisibleRange"
    /// <summary>
    ///   <para>rdfs:label : scheduled arrivals^^xsd:string</para>
    ///   <para>rdfs:comment : Count of scheduled arrivals. (Most probably from OAG (Official Airline Guide))^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#scheduledArrivals">atd:scheduledArrivals</a>
    /// </summary>
    let scheduledArrivals = _prefixId.prefix "scheduledArrivals"
    /// <summary>
    ///   <para>rdfs:label : scheduled departures^^xsd:string</para>
    ///   <para>rdfs:comment : Count of scheduled departures. (Most probably from OAG (Official Airline Guide))^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#scheduledDepartures">atd:scheduledDepartures</a>
    /// </summary>
    let scheduledDepartures = _prefixId.prefix "scheduledDepartures"
    /// <summary>
    ///   <para>rdfs:label : sea level pressure^^xsd:string</para>
    ///   <para>rdfs:comment : Sea level pressure measured under the associated meteorological conditions.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#seaLevelPressure">atd:seaLevelPressure</a>
    /// </summary>
    let seaLevelPressure = _prefixId.prefix "seaLevelPressure"
    /// <summary>
    ///   <para>rdfs:label : surface gust speed^^xsd:string</para>
    ///   <para>rdfs:comment : Surface gust speed measured under the associated surface wind conditions.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#surfaceGustSpeed">atd:surfaceGustSpeed</a>
    /// </summary>
    let surfaceGustSpeed = _prefixId.prefix "surfaceGustSpeed"
    /// <summary>
    ///   <para>rdfs:label : surface temperature^^xsd:string</para>
    ///   <para>rdfs:comment : Surface temperature measured under the associated meteorological conditions.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#surfaceTemperature">atd:surfaceTemperature</a>
    /// </summary>
    let surfaceTemperature = _prefixId.prefix "surfaceTemperature"
    /// <summary>
    ///   <para>rdfs:label : surface wind direction status^^xsd:string</para>
    ///   <para>rdfs:comment : Information about the direction of the wind, either fixed, varyingWithinRange, or variable.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#surfaceWindDirectionStatus">atd:surfaceWindDirectionStatus</a>
    /// </summary>
    let surfaceWindDirectionStatus = _prefixId.prefix "surfaceWindDirectionStatus"
    /// <summary>
    ///   <para>rdfs:label : surface wind speed^^xsd:string</para>
    ///   <para>rdfs:comment : The speed in knots of the surface wind.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#surfaceWindSpeed">atd:surfaceWindSpeed</a>
    /// </summary>
    let surfaceWindSpeed = _prefixId.prefix "surfaceWindSpeed"
    /// <summary>
    ///   <para>rdfs:label : taf report string^^xsd:string</para>
    ///   <para>rdfs:comment : The full text of the entire TAF report.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#tafReportString">atd:tafReportString</a>
    /// </summary>
    let tafReportString = _prefixId.prefix "tafReportString"
    /// <summary>
    ///   <para>rdfs:label : taf report type^^xsd:string</para>
    ///   <para>rdfs:comment : Type of Terminal Area Forecast (TAF) report: a routine report (TAF), an amended report (AMD), a corrected report (COR), or a delayed report (RTD). An amended TAF is issued when the current TAF no longer adequately describes the ongoing weather or the forecaster feels the TAF is not representative of the current or expected weather.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#tafReportType">atd:tafReportType</a>
    /// </summary>
    let tafReportType = _prefixId.prefix "tafReportType"
    /// <summary>
    ///   <para>rdfs:label : top altitude^^xsd:string</para>
    ///   <para>rdfs:comment : The top altitude of a homogenous cloud layer.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#topAltitude">atd:topAltitude</a>
    /// </summary>
    let topAltitude = _prefixId.prefix "topAltitude"
    /// <summary>
    ///   <para>rdfs:label : total airborne delay^^xsd:string</para>
    ///   <para>rdfs:comment : Total airborne flight delay in minutes for this airport during the specified period.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#totalAirborneDelay">atd:totalAirborneDelay</a>
    /// </summary>
    let totalAirborneDelay = _prefixId.prefix "totalAirborneDelay"
    /// <summary>
    ///   <para>rdfs:label : unlimited visibility^^xsd:string</para>
    ///   <para>rdfs:comment : A binary property indicating whether the visibility conditions are unlimited.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#unlimitedVisibility">atd:unlimitedVisibility</a>
    /// </summary>
    let unlimitedVisibility = _prefixId.prefix "unlimitedVisibility"
    /// <summary>
    ///   <para>rdfs:label : weather intensity^^xsd:string</para>
    ///   <para>rdfs:comment : An indicator of the intensity of the weather: light, moderate, heavy.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#weatherIntensity">atd:weatherIntensity</a>
    /// </summary>
    let weatherIntensity = _prefixId.prefix "weatherIntensity"
    /// <summary>
    ///   <para>rdfs:label : weather phenomenon^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the type of weather phenomena experienced during the specified period: drizzle, rain, snow, snow grains, ice crystals, ice pellets, hail, small hail and/or snow pellets, unknown precipitation, mist, fog, smoke, volcanic ash, widespread dust, sand, haze, spray, well-developed dust/sand whirls, squalls, funnel cloud, tornado/waterspout, sandstorm, duststorm^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#weatherPhenomenon">atd:weatherPhenomenon</a>
    /// </summary>
    let weatherPhenomenon = _prefixId.prefix "weatherPhenomenon"
    /// <summary>
    ///   <para>rdfs:label : weather proximity^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the location of the weather phenomena in relation to the reporting station: immediate proximity or in vicinity.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#weatherProximity">atd:weatherProximity</a>
    /// </summary>
    let weatherProximity = _prefixId.prefix "weatherProximity"
    /// <summary>
    ///   <para>rdfs:label : weather qualifier^^xsd:string</para>
    ///   <para>rdfs:comment : An additional qualifier describing the reported weather phenomenon: shallow, partial, patchy, low drifting, blowing, shower, thunderstorm, freezing.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#weatherQualifier">atd:weatherQualifier</a>
    /// </summary>
    let weatherQualifier = _prefixId.prefix "weatherQualifier"
    /// <summary>
    ///   <para>rdfs:label : fixed wind direction^^xsd:string</para>
    ///   <para>rdfs:comment : Steady wind direction (in degrees), when winds are fixed and not variable.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#windDirectionFixed">atd:windDirectionFixed</a>
    /// </summary>
    let windDirectionFixed = _prefixId.prefix "windDirectionFixed"
    /// <summary>
    ///   <para>rdfs:label : lower wind direction^^xsd:string</para>
    ///   <para>rdfs:comment : Lower bound (in degrees) of two bounding values describing a variable wind direction.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#windDirectionLower">atd:windDirectionLower</a>
    /// </summary>
    let windDirectionLower = _prefixId.prefix "windDirectionLower"
    /// <summary>
    ///   <para>rdfs:label : lower wind direction^^xsd:string</para>
    ///   <para>rdfs:comment : Upper bound (in degrees) of two bounding values describing a variable wind direction.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#windDirectionUpper">atd:windDirectionUpper</a>
    /// </summary>
    let windDirectionUpper = _prefixId.prefix "windDirectionUpper"
    /// <summary>
    ///   <para>rdfs:label : wind shear height^^xsd:string</para>
    ///   <para>rdfs:comment : The height in hundreds of feet above ground level associated with a wind shear phenomenon.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/data#windShearHeight">atd:windShearHeight</a>
    /// </summary>
    let windShearHeight = _prefixId.prefix "windShearHeight"
