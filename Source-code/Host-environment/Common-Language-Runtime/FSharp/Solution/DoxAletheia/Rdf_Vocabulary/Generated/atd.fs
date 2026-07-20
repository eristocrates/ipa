namespace https.data.nasa.gov.ontologies.atmonto.data.hash

open DoxAletheia

module atd =
    let _namespace_name = "https://data.nasa.gov/ontologies/atmonto/data#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// State data that has a temporal lifetime: a start and end time.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#IntervalData"></see></summary>
    let IntervalData = _prefix "IntervalData"
    /// <summary>
    /// A weather reporting station that provides sensor data for a METAR report. Many airports are also METAR reporting stations.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#METARreportingStation"></see></summary>
    let METARreportingStation = _prefix "METARreportingStation"
    /// <summary>
    /// Meteorological conditions reported as part of the ASPM hourly airport data. Includes sky, wind, visibility and weather components.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#ASPMmeteorologicalCondition"></see></summary>
    let ASPMmeteorologicalCondition = _prefix "ASPMmeteorologicalCondition"
    /// <summary>
    /// A representation of the meteorological status for the specified time period, including sky, wind, visibility, and weather subcomponents.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#MeteorologicalCondition"></see></summary>
    let MeteorologicalCondition = _prefix "MeteorologicalCondition"
    /// <summary>
    /// Represents a collection of airport data for a given time period, as reported by the FAA's ASPM system.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#AirportData"></see></summary>
    let AirportData = _prefix "AirportData"
    /// <summary>
    /// Indicates what flight rule conditions the airport is operating under during the specified time period (I-instrument, V-Visual).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#aspmFlightRules"></see></summary>
    let aspmFlightRules = _prefix "aspmFlightRules"
    /// <summary>
    /// Represents a cloud layer, providing its bottom and top altitude, its cloud type, and its degree of coverage.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#CloudLayer"></see></summary>
    let CloudLayer = _prefix "CloudLayer"
    /// <summary>
    /// For a given homogeneous cloud layer, the type of cloud present: towering cumulus, cumulonimbus, altocumulus castellanus.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#cloudType"></see></summary>
    let cloudType = _prefix "cloudType"
    /// <summary>
    /// For a given homogenous cloud layer, the type of cloud cover present: clear, few clouds, scattered clouds, broken clouds, overcast, vertical visibility layer.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#cloudCover"></see></summary>
    let cloudCover = _prefix "cloudCover"
    /// <summary>
    /// A sequence of cloud layers, ordered from the ground upward. Represents cloud conditions.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#CloudLayerProfile"></see></summary>
    let CloudLayerProfile = _prefix "CloudLayerProfile"
    /// <summary>
    /// A subclass of interval-based data representing the maximum controllable number of aircraft flowing through a fix per some interval of time, given weather and other air traffic control constraints.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#FixCapacity"></see></summary>
    let FixCapacity = _prefix "FixCapacity"
    /// <summary>
    /// A subclass of interval-based data representing the number of aircraft flowing through a fix per some interval of time.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#FixFlow"></see></summary>
    let FixFlow = _prefix "FixFlow"
    /// <summary>
    /// Meteorological conditions provided in a periodic METAR report. Includes sky, wind, visibility and weather components.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#METARreport"></see></summary>
    let METARreport = _prefix "METARreport"
    /// <summary>
    /// METAR report type indicator specifies whether this report is a regularly scheduled hourly report (METAR) or a special unscheduled report (SPECI). SPECIs are issued more frequently than hourly when adverse weather conditions prevail.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#metarReportType"></see></summary>
    let metarReportType = _prefix "metarReportType"
    /// <summary>
    /// Automation status information pertaining to a METAR report: AUTO indicates a fully automated report with no human intervention; COR indicates a corrected observation; no modifier indicates either human observer/reporter or automated report with human oversight.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#metarReportModifier"></see></summary>
    let metarReportModifier = _prefix "metarReportModifier"
    /// <summary>
    /// A superclass over the various types of meteorological conditions.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#MetCondition"></see></summary>
    let MetCondition = _prefix "MetCondition"
    /// <summary>
    /// An indicator of whether the meteorological condition is based on actual observations (observed) or on future projections (forecast).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#meteorologicalConditionStatus"></see></summary>
    let meteorologicalConditionStatus = _prefix "meteorologicalConditionStatus"
    /// <summary>
    /// A report on runway conditions during a specified interval of time, focusing on runway status (open vs. closed) and surface friction during winter precipitation.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#RunwayReport"></see></summary>
    let RunwayReport = _prefix "RunwayReport"
    /// <summary>
    /// This class describes a temporally-dependent set of data about the operating status of a physical runway.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#RunwayStatusData"></see></summary>
    let RunwayStatusData = _prefix "RunwayStatusData"
    /// <summary>
    /// An indicator of whether the runway is open or closed during the specified period.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#runwayStatus"></see></summary>
    let runwayStatus = _prefix "runwayStatus"
    /// <summary>
    /// A subclass of interval-based data representing the maximum number of controllable aircraft flowing through a sector during some interval of time.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#SectorCapacity"></see></summary>
    let SectorCapacity = _prefix "SectorCapacity"
    /// <summary>
    /// A subclass of interval-based data representing the number of aircraft flowing through a sector during some interval of time.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#SectorFlow"></see></summary>
    let SectorFlow = _prefix "SectorFlow"
    /// <summary>
    /// The current or forecast sky conditions, including the ceiling and information on the cloud layers present.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#SkyCondition"></see></summary>
    let SkyCondition = _prefix "SkyCondition"
    /// <summary>
    /// The current or forecast surface wind conditions.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#SurfaceWindCondition"></see></summary>
    let SurfaceWindCondition = _prefix "SurfaceWindCondition"
    /// <summary>
    /// Information about the direction of the wind, either fixed, varyingWithinRange, or variable.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#surfaceWindDirectionStatus"></see></summary>
    let surfaceWindDirectionStatus = _prefix "surfaceWindDirectionStatus"
    /// <summary>
    /// Meteorological conditions reported as part of a TAF forecast. Includes sky, wind, visibility and weather components for current and future time periods.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#TAFmeteorologicalCondition"></see></summary>
    let TAFmeteorologicalCondition = _prefix "TAFmeteorologicalCondition"
    /// <summary>
    /// Indicates how fast change is expected from the prior state to the forecast meteorological conditions: "rapid" , "gradual" , "transient".
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#rapidityOfWeatherChange"></see></summary>
    let rapidityOfWeatherChange = _prefix "rapidityOfWeatherChange"
    /// <summary>
    /// Meteorological conditions provided in a periodic TAF forecast. Includes sky, wind, visibility and weather components.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#TAFreport"></see></summary>
    let TAFreport = _prefix "TAFreport"
    /// <summary>
    /// Type of Terminal Area Forecast (TAF) report: a routine report (TAF), an amended report (AMD), a corrected report (COR), or a delayed report (RTD). An amended TAF is issued when the current TAF no longer adequately describes the ongoing weather or the forecaster feels the TAF is not representative of the current or expected weather.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#tafReportType"></see></summary>
    let tafReportType = _prefix "tafReportType"
    /// <summary>
    /// The current or forecast surface visibility conditions at a given airport or other reporting station.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#VisibilityCondition"></see></summary>
    let VisibilityCondition = _prefix "VisibilityCondition"
    /// <summary>
    /// A class of different properties relating to WITI (Weather-Impacted Traffic Index)
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#WITIproperty"></see></summary>
    let WITIproperty = _prefix "WITIproperty"
    /// <summary>
    /// The current or forecast weather conditions at a given airport or other reporting station.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#WeatherCondition"></see></summary>
    let WeatherCondition = _prefix "WeatherCondition"
    /// <summary>
    /// An additional qualifier describing the reported weather phenomenon: shallow, partial, patchy, low drifting, blowing, shower, thunderstorm, freezing.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#weatherQualifier"></see></summary>
    let weatherQualifier = _prefix "weatherQualifier"
    /// <summary>
    /// Describes the type of weather phenomena experienced during the specified period: drizzle, rain, snow, snow grains, ice crystals, ice pellets, hail, small hail and/or snow pellets, unknown precipitation, mist, fog, smoke, volcanic ash, widespread dust, sand, haze, spray, well-developed dust/sand whirls, squalls, funnel cloud, tornado/waterspout, sandstorm, duststorm
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#weatherPhenomenon"></see></summary>
    let weatherPhenomenon = _prefix "weatherPhenomenon"
    /// <summary>
    /// An indicator of the intensity of the weather: light, moderate, heavy.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#weatherIntensity"></see></summary>
    let weatherIntensity = _prefix "weatherIntensity"
    /// <summary>
    /// Describes the location of the weather phenomena in relation to the reporting station: immediate proximity or in vicinity.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#weatherProximity"></see></summary>
    let weatherProximity = _prefix "weatherProximity"
    /// <summary>
    /// The arrival rate per hour set by the airport during the specified interval. This is the total number of aircraft that can arrive on all runways combined during an hour.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#airportArrivalRate"></see></summary>
    let airportArrivalRate = _prefix "airportArrivalRate"
    /// <summary>
    /// The departure rate per hour set by the airport during the specified interval. This is the total number of aircraft that can depart from all runways combined during an hour.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#airportDepartureRate"></see></summary>
    let airportDepartureRate = _prefix "airportDepartureRate"
    /// <summary>
    /// The number of aircraft intending to arrive at an airport during the specified time period.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#arrivalDemand"></see></summary>
    let arrivalDemand = _prefix "arrivalDemand"
    /// <summary>
    /// Links a METAR report to the reporting station where the data were collected.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#associatedMETARreportingStation"></see></summary>
    let associatedMETARreportingStation = _prefix "associatedMETARreportingStation"
    /// <summary>
    /// Associates a METAR reporting station with METAR weather reports generated for that station.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#hasMETARreport"></see></summary>
    let hasMETARreport = _prefix "hasMETARreport"
    /// <summary>
    /// For a given homogeonous cloud layer, this is the lowest altitude.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#baseAltitude"></see></summary>
    let baseAltitude = _prefix "baseAltitude"
    /// <summary>
    /// The vertical visibility (in feet) measured from the ground to the lowest cloud layer reported as broken or overcast.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#ceiling"></see></summary>
    let ceiling = _prefix "ceiling"
    /// <summary>
    /// Links temporally-dependent data to the ending day of its period of validity.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#dataIntervalEndDay"></see></summary>
    let dataIntervalEndDay = _prefix "dataIntervalEndDay"
    /// <summary>
    /// For temporally-dependent data, the ending time of the data's period of validity.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#dataIntervalEndTime"></see></summary>
    let dataIntervalEndTime = _prefix "dataIntervalEndTime"
    /// <summary>
    /// Links temporally-dependent data to the starting day of its period of validity.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#dataIntervalStartDay"></see></summary>
    let dataIntervalStartDay = _prefix "dataIntervalStartDay"
    /// <summary>
    /// For temporally-dependent data, the starting time of the data's period of validity.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#dataIntervalStartTime"></see></summary>
    let dataIntervalStartTime = _prefix "dataIntervalStartTime"
    /// <summary>
    /// The number of aircraft intending to depart during the specified time period.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#departureDemand"></see></summary>
    let departureDemand = _prefix "departureDemand"
    /// <summary>
    /// The dewpoint recorded as part of a meteorological condition report.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#dewpoint"></see></summary>
    let dewpoint = _prefix "dewpoint"
    /// <summary>
    /// EDCT (Estimated Departure Clearance Time) hold minutes at other airports arriving this airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#edctArrivalHold"></see></summary>
    let edctArrivalHold = _prefix "edctArrivalHold"
    /// <summary>
    /// EDCT (Estimated Departure Clearance Time) hold minutes at other airports departing this airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#edctDepartureHold"></see></summary>
    let edctDepartureHold = _prefix "edctDepartureHold"
    /// <summary>
    /// Count of arrivals at airport based on ETMS (Enhanced Traffic Management System) data.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#etmsArrivals"></see></summary>
    let etmsArrivals = _prefix "etmsArrivals"
    /// <summary>
    /// Count of departures at airport based on ETMS (Enhanced Traffic Management System) data.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#etmsDepartures"></see></summary>
    let etmsDepartures = _prefix "etmsDepartures"
    /// <summary>
    /// The time that the TAF (Terminal Area Forecast) report was issued.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#forecastIssueTime"></see></summary>
    let forecastIssueTime = _prefix "forecastIssueTime"
    /// <summary>
    /// Links to the airport for which the TAF (Terminal Area Forecast) report was compiled.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#forecastingAirport"></see></summary>
    let forecastingAirport = _prefix "forecastingAirport"
    /// <summary>
    /// Associates an airport with TAF weather reports generated for that airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#hasTAFreport"></see></summary>
    let hasTAFreport = _prefix "hasTAFreport"
    /// <summary>
    /// Links meteorological information to the collection of temporally-dependent data associated with an airport.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#hasASPMmetCondition"></see></summary>
    let hasASPMmetCondition = _prefix "hasASPMmetCondition"
    /// <summary>
    /// Links an airport to a collection of temporally-dependent data pertinent to the airport conditions, including a variety of data collected in the ASPM system.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#hasAirportData"></see></summary>
    let hasAirportData = _prefix "hasAirportData"
    /// <summary>
    /// Links a sky condition to a representation of the cloud layers present.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#hasCloudLayerProfile"></see></summary>
    let hasCloudLayerProfile = _prefix "hasCloudLayerProfile"
    /// <summary>
    /// Associates a meteorological condition with the details of the sky and cloud conditions at the reporting location..
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#hasSkyCondition"></see></summary>
    let hasSkyCondition = _prefix "hasSkyCondition"
    /// <summary>
    /// Associates a meteorological condition with the details of the surface wind conditions at the reporting location..
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#hasSurfaceWindCondition"></see></summary>
    let hasSurfaceWindCondition = _prefix "hasSurfaceWindCondition"
    /// <summary>
    /// Associates a meteorological condition with the details of the surface visibility conditions at the reporting location..
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#hasVisibilityCondition"></see></summary>
    let hasVisibilityCondition = _prefix "hasVisibilityCondition"
    /// <summary>
    /// Associates a meteorological condition with the details of the weather conditions at the reporting location.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#hasWeatherCondition"></see></summary>
    let hasWeatherCondition = _prefix "hasWeatherCondition"
    /// <summary>
    /// The high wind weather impacted traffic index (WITI) computed for the airport during the specified timeframe (daily). WITI is an estimate of the number of flights potentially impacted due to inclement weather based on the scheduled traffic demand for a defined geographic region of the air traffic system (in this case, an airport). If the winds at the airport are above a set threshold, then the high wind WITI is set to the number of scheduled arrivals for that timeframe.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#highWindWITIdaily"></see></summary>
    let highWindWITIdaily = _prefix "highWindWITIdaily"
    /// <summary>
    /// The high wind weather impacted traffic index (WITI) computed for the airport during the specified timeframe (hourly). WITI is an estimate of the number of flights potentially impacted due to inclement weather based on the scheduled traffic demand for a defined geographic region of the air traffic system (in this case, an airport). If the winds at the airport are above a set threshold, then the high wind WITI is set to the number of scheduled arrivals for that timeframe.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#highWindWITIhourly"></see></summary>
    let highWindWITIhourly = _prefix "highWindWITIhourly"
    /// <summary>
    /// Recorded hourly precipitation rate at the measurement station in inches.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#hourlyPrecipitation"></see></summary>
    let hourlyPrecipitation = _prefix "hourlyPrecipitation"
    /// <summary>
    /// The visibility distance (in miles) at the reporting station. Only applicable if data:unlimitedVisibility is False.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#limitedVisibilityDistance"></see></summary>
    let limitedVisibilityDistance = _prefix "limitedVisibilityDistance"
    /// <summary>
    /// A binary property indicating whether the visibility conditions are unlimited.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#unlimitedVisibility"></see></summary>
    let unlimitedVisibility = _prefix "unlimitedVisibility"
    /// <summary>
    /// The low ceiling weather impacted traffic index (WITI) computed for the airport during the specified timeframe (daily). WITI is an estimate of the number of flights potentially impacted due to inclement weather based on the scheduled traffic demand for a defined geographic region of the air traffic system (in this case, an airport). If the ceiling at the airport is below a set threshold, then the low ceiling WITI is set to the number of scheduled arrivals for that timeframe.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#lowCeilingWITIdaily"></see></summary>
    let lowCeilingWITIdaily = _prefix "lowCeilingWITIdaily"
    /// <summary>
    /// The low ceiling weather impacted traffic index (WITI) computed for the airport during the specified timeframe (hourly). WITI is an estimate of the number of flights potentially impacted due to inclement weather based on the scheduled traffic demand for a defined geographic region of the air traffic system (in this case, an airport). If the ceiling at the airport is below a set threshold, then the low ceiling WITI is set to the number of scheduled arrivals for that timeframe.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#lowCeilingWITIhourly"></see></summary>
    let lowCeilingWITIhourly = _prefix "lowCeilingWITIhourly"
    /// <summary>
    /// The low visibility weather impacted traffic index (WITI) computed for the airport during the specified timeframe (daily). WITI is an estimate of the number of flights potentially impacted due to inclement weather based on the scheduled traffic demand for a defined geographic region of the air traffic system (in this case, an airport). If the visibility at the airport is below a set threshold, then the low visibility WITI is set to the number of scheduled arrivals for that timeframe.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#lowVisibilityWITIdaily"></see></summary>
    let lowVisibilityWITIdaily = _prefix "lowVisibilityWITIdaily"
    /// <summary>
    /// The low visibility weather impacted traffic index (WITI) computed for the airport during the specified timeframe (hourly). WITI is an estimate of the number of flights potentially impacted due to inclement weather based on the scheduled traffic demand for a defined geographic region of the air traffic system (in this case, an airport). If the visibility at the airport is below a set threshold, then the low visibility WITI is set to the number of scheduled arrivals for that timeframe.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#lowVisibilityWITIhourly"></see></summary>
    let lowVisibilityWITIhourly = _prefix "lowVisibilityWITIhourly"
    /// <summary>
    /// For a forecast meteorological condition, the percent probability associated with the forecast occurrence.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#metConditionProbability"></see></summary>
    let metConditionProbability = _prefix "metConditionProbability"
    /// <summary>
    /// Entire text of METAR report.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#metarReportString"></see></summary>
    let metarReportString = _prefix "metarReportString"

    /// <summary>
    /// A boolean value indicating whether the reporting METAR station has a precipitation sensor.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#metarStationHasPrecipitationSensor"></see></summary>
    let metarStationHasPrecipitationSensor =
        _prefix "metarStationHasPrecipitationSensor"

    /// <summary>
    /// Minutes of OAG (Official Airline Guide) based arrival delay in excess of 15 minutes.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#oagArrivalDelay"></see></summary>
    let oagArrivalDelay = _prefix "oagArrivalDelay"
    /// <summary>
    /// Minutes of OAG (Official Airline Guide) based gate departure delay in excess of 15 minutes.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#oagGateDepartureDelay"></see></summary>
    let oagGateDepartureDelay = _prefix "oagGateDepartureDelay"
    /// <summary>
    /// Associates a runway status report with the physical runway being measured.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#runwayReportedOn"></see></summary>
    let runwayReportedOn = _prefix "runwayReportedOn"
    /// <summary>
    /// The surface friction (mu) value of the runway for the specified period. Runway surface friction is directly relevant to the braking action which will be available to an aircraft decelerating after touch down, or after a decision to reject a take off.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#runwaySurfaceFriction"></see></summary>
    let runwaySurfaceFriction = _prefix "runwaySurfaceFriction"
    /// <summary>
    /// Links a visibility condition to a runway visible range measurement class instance.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#runwayVisibleRange"></see></summary>
    let runwayVisibleRange = _prefix "runwayVisibleRange"
    /// <summary>
    /// Count of scheduled arrivals. (Most probably from OAG (Official Airline Guide))
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#scheduledArrivals"></see></summary>
    let scheduledArrivals = _prefix "scheduledArrivals"
    /// <summary>
    /// Count of scheduled departures. (Most probably from OAG (Official Airline Guide))
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#scheduledDepartures"></see></summary>
    let scheduledDepartures = _prefix "scheduledDepartures"
    /// <summary>
    /// Sea level pressure measured under the associated meteorological conditions.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#seaLevelPressure"></see></summary>
    let seaLevelPressure = _prefix "seaLevelPressure"
    /// <summary>
    /// Surface gust speed measured under the associated surface wind conditions.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#surfaceGustSpeed"></see></summary>
    let surfaceGustSpeed = _prefix "surfaceGustSpeed"
    /// <summary>
    /// Surface temperature measured under the associated meteorological conditions.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#surfaceTemperature"></see></summary>
    let surfaceTemperature = _prefix "surfaceTemperature"
    /// <summary>
    /// The speed in knots of the surface wind.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#surfaceWindSpeed"></see></summary>
    let surfaceWindSpeed = _prefix "surfaceWindSpeed"
    /// <summary>
    /// The full text of the entire TAF report.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#tafReportString"></see></summary>
    let tafReportString = _prefix "tafReportString"
    /// <summary>
    /// The top altitude of a homogenous cloud layer.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#topAltitude"></see></summary>
    let topAltitude = _prefix "topAltitude"
    /// <summary>
    /// Total airborne flight delay in minutes for this airport during the specified period.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#totalAirborneDelay"></see></summary>
    let totalAirborneDelay = _prefix "totalAirborneDelay"
    /// <summary>
    /// Steady wind direction (in degrees), when winds are fixed and not variable.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#windDirectionFixed"></see></summary>
    let windDirectionFixed = _prefix "windDirectionFixed"
    /// <summary>
    /// Lower bound (in degrees) of two bounding values describing a variable wind direction.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#windDirectionLower"></see></summary>
    let windDirectionLower = _prefix "windDirectionLower"
    /// <summary>
    /// Upper bound (in degrees) of two bounding values describing a variable wind direction.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#windDirectionUpper"></see></summary>
    let windDirectionUpper = _prefix "windDirectionUpper"
    /// <summary>
    /// The height in hundreds of feet above ground level associated with a wind shear phenomenon.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/data#windShearHeight"></see></summary>
    let windShearHeight = _prefix "windShearHeight"
