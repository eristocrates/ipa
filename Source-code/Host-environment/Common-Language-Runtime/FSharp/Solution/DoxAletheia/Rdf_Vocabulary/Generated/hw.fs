namespace https.www.auto.tuwien.ac.at.downloads.thinkhome.ontology.WeatherOntology.owl.bare

open DoxAletheia

module hw =
    let _namespace_name =
        "https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightWind"></see>
    /// </summary>
    let ``_#LightWind`` = _prefix "#LightWind"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#NoWind"></see>
    /// </summary>
    let ``_#NoWind`` = _prefix "#NoWind"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Storm"></see>
    /// </summary>
    let ``_#Storm`` = _prefix "#Storm"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#StrongWind"></see>
    /// </summary>
    let ``_#StrongWind`` = _prefix "#StrongWind"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#MostlyCloudy"></see>
    /// </summary>
    let ``_#MostlyCloudy`` = _prefix "#MostlyCloudy"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#NoCloudCover"></see>
    /// </summary>
    let ``_#NoCloudCover`` = _prefix "#NoCloudCover"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Overcast"></see>
    /// </summary>
    let ``_#Overcast`` = _prefix "#Overcast"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#PartlyCloudy"></see>
    /// </summary>
    let ``_#PartlyCloudy`` = _prefix "#PartlyCloudy"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#UnknownCloudCover"></see>
    /// </summary>
    let ``_#UnknownCloudCover`` = _prefix "#UnknownCloudCover"
    /// <summary>
    /// One-word description of the observed weather condition
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherCondition"></see></summary>
    let ``_#WeatherCondition`` = _prefix "#WeatherCondition"
    /// <summary>
    /// different weather phenomena that may influence the current and forecasted weather state.
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherPhenomenon"></see></summary>
    let ``_#WeatherPhenomenon`` = _prefix "#WeatherPhenomenon"
    /// <summary>
    /// a weather report that can be retrieved through a local sensor (e.g. weather station integrated in the smart home) or a remote internet service. Further a time division has been realized to differentiate between current, short, mid and long term forecasts.
    ///
    /// For the smart home domain, a time window of 24 hours for weather forecasts has been seen as suitable with a 24 hours forecast being classified as long-term forecast
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherReport"></see></summary>
    let ``_#WeatherReport`` = _prefix "#WeatherReport"
    /// <summary>
    /// Holds information about the origins of weather reports
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherReportSource"></see></summary>
    let ``_#WeatherReportSource`` = _prefix "#WeatherReportSource"
    /// <summary>
    /// Describes the actual weather reported through information from the weather source.
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherState"></see></summary>
    let ``_#WeatherState`` = _prefix "#WeatherState"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#HighAirPollution"></see>
    /// </summary>
    let ``_#HighAirPollution`` = _prefix "#HighAirPollution"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LowAirPollution"></see>
    /// </summary>
    let ``_#LowAirPollution`` = _prefix "#LowAirPollution"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#MediumAirPollution"></see>
    /// </summary>
    let ``_#MediumAirPollution`` = _prefix "#MediumAirPollution"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#VeryHighAirPollution"></see>
    /// </summary>
    let ``_#VeryHighAirPollution`` = _prefix "#VeryHighAirPollution"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#VeryLowAirPollution"></see>
    /// </summary>
    let ``_#VeryLowAirPollution`` = _prefix "#VeryLowAirPollution"
    /// <summary>
    /// the current air pollution represented as European Air Quality Index value. The index value is based on 3 pollutants of major concern in Europe: PM10, NO2, O3 and will be able to take into account to 3 additional pollutants (CO, PM2.5 and SO2) where data are also available.
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#AirPollution"></see></summary>
    let ``_#AirPollution`` = _prefix "#AirPollution"
    /// <summary>
    /// atmospheric pressure in hectopascal (hPa)
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#AtmosphericPressure"></see></summary>
    let ``_#AtmosphericPressure`` = _prefix "#AtmosphericPressure"
    /// <summary>
    /// clound cover in the unit "Okta"
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#CloudCover"></see></summary>
    let ``_#CloudCover`` = _prefix "#CloudCover"
    /// <summary>
    /// this concept was known as "DewPoint" in prior versions of the ontology
    /// The dewpoint temperature in degrees Celsius. It is the temperature at which the air can no longer hold all of its water vapor, and some of the water vapor must condense into liquid water. The dew point is always lower than (or equal to) the air temperature.
    ///
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#DewPointTemperature"></see></summary>
    let ``_#DewPointTemperature`` = _prefix "#DewPointTemperature"
    /// <summary>
    /// represents the relative humidity of the air in percent
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Humidity"></see></summary>
    let ``_#Humidity`` = _prefix "#Humidity"
    /// <summary>
    /// represents precipitation in millimetres
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Precipitation"></see></summary>
    let ``_#Precipitation`` = _prefix "#Precipitation"
    /// <summary>
    /// this concept was known as "SolarRadiation" in prior versions of the ontology
    /// measurement of solar irrradiation at a specific location in Watts per square meter (W/m²)
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#SolarIrradiance"></see></summary>
    let ``_#SolarIrradiance`` = _prefix "#SolarIrradiance"
    /// <summary>
    /// exterior temperature in degrees Celsius
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Temperature"></see></summary>
    let ``_#Temperature`` = _prefix "#Temperature"
    /// <summary>
    /// Wind direction and speed are represented as datatype properties"hasDirection" and "hasSpeed"
    ///
    /// Unit of wind speed in metres per second (m/s).
    /// Unit of wind direction is degrees
    ///
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Wind"></see></summary>
    let ``_#Wind`` = _prefix "#Wind"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast12HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast12HoursWeatherReport`` = _prefix "#Forecast12HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast15HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast15HoursWeatherReport`` = _prefix "#Forecast15HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast18HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast18HoursWeatherReport`` = _prefix "#Forecast18HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast1HourWeatherReport"></see>
    /// </summary>
    let ``_#Forecast1HourWeatherReport`` = _prefix "#Forecast1HourWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast21HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast21HoursWeatherReport`` = _prefix "#Forecast21HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast24HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast24HoursWeatherReport`` = _prefix "#Forecast24HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast2HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast2HoursWeatherReport`` = _prefix "#Forecast2HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast3HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast3HoursWeatherReport`` = _prefix "#Forecast3HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast6HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast6HoursWeatherReport`` = _prefix "#Forecast6HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast9HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast9HoursWeatherReport`` = _prefix "#Forecast9HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#HeavyPrecipitation"></see>
    /// </summary>
    let ``_#HeavyPrecipitation`` = _prefix "#HeavyPrecipitation"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightPrecipitation"></see>
    /// </summary>
    let ``_#LightPrecipitation`` = _prefix "#LightPrecipitation"
    /// <summary>
    /// this concept was known as "MediumPrecipitation" in prior versions of the ontology
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ModeratePrecipitation"></see></summary>
    let ``_#ModeratePrecipitation`` = _prefix "#ModeratePrecipitation"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#NoPrecipitation"></see>
    /// </summary>
    let ``_#NoPrecipitation`` = _prefix "#NoPrecipitation"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#DryHumidity"></see>
    /// </summary>
    let ``_#DryHumidity`` = _prefix "#DryHumidity"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#MoistHumidity"></see>
    /// </summary>
    let ``_#MoistHumidity`` = _prefix "#MoistHumidity"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#OptimumHumidity"></see>
    /// </summary>
    let ``_#OptimumHumidity`` = _prefix "#OptimumHumidity"
    /// <summary>
    /// this concept was known as "HighSolarRadiation" in prior versions of the ontology
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#HighSolarIrradiance"></see></summary>
    let ``_#HighSolarIrradiance`` = _prefix "#HighSolarIrradiance"
    /// <summary>
    /// this concept was known as "LowSolarRadiation" in prior versions of the ontology
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LowSolarIrradiance"></see></summary>
    let ``_#LowSolarIrradiance`` = _prefix "#LowSolarIrradiance"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ModerateSolarIrradiance"></see>
    /// </summary>
    let ``_#ModerateSolarIrradiance`` = _prefix "#ModerateSolarIrradiance"
    /// <summary>
    /// this concept was known as "NeglectibleSolarRadiation" in prior versions of the ontology
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#NeglectibleSolarIrradiance"></see></summary>
    let ``_#NeglectibleSolarIrradiance`` = _prefix "#NeglectibleSolarIrradiance"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#AboveRoomTemperature"></see>
    /// </summary>
    let ``_#AboveRoomTemperature`` = _prefix "#AboveRoomTemperature"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasValue"></see>
    /// </summary>
    let ``_#hasValue`` = _prefix "#hasValue"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#AboveZeroTemperature"></see>
    /// </summary>
    let ``_#AboveZeroTemperature`` = _prefix "#AboveZeroTemperature"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#AiringWeatherState"></see>
    /// </summary>
    let ``_#AiringWeatherState`` = _prefix "#AiringWeatherState"
    /// <summary>
    /// Relation between weather states and the phenomena that are observed or forecasted
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasWeatherPhenomenon"></see></summary>
    let ``_#hasWeatherPhenomenon`` = _prefix "#hasWeatherPhenomenon"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#BelowOrZeroTemperature"></see>
    /// </summary>
    let ``_#BelowOrZeroTemperature`` = _prefix "#BelowOrZeroTemperature"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#BelowRoomTemperature"></see>
    /// </summary>
    let ``_#BelowRoomTemperature`` = _prefix "#BelowRoomTemperature"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Cloud"></see>
    /// </summary>
    let ``_#Cloud`` = _prefix "#Cloud"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasCloudCoverValue"></see>
    /// </summary>
    let ``_#hasCloudCoverValue`` = _prefix "#hasCloudCoverValue"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasCloudAltitude"></see>
    /// </summary>
    let ``_#hasCloudAltitude`` = _prefix "#hasCloudAltitude"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#CoolingWeatherState"></see>
    /// </summary>
    let ``_#CoolingWeatherState`` = _prefix "#CoolingWeatherState"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#CurrentWeatherReport"></see>
    /// </summary>
    let ``_#CurrentWeatherReport`` = _prefix "#CurrentWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ForecastWeatherReport"></see>
    /// </summary>
    let ``_#ForecastWeatherReport`` = _prefix "#ForecastWeatherReport"
    /// <summary>
    /// this property describes an interval that denotes the time in the future (offset) for which the weather is reported
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#reportsWeatherForTimeInterval"></see></summary>
    let ``_#reportsWeatherForTimeInterval`` = _prefix "#reportsWeatherForTimeInterval"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#CurrentWeatherReportFromSensor"></see>
    /// </summary>
    let ``_#CurrentWeatherReportFromSensor`` = _prefix "#CurrentWeatherReportFromSensor"
    /// <summary>
    /// this class was known as "SensorSource" in prior versions of the ontology
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#SensorReportSource"></see></summary>
    let ``_#SensorReportSource`` = _prefix "#SensorReportSource"
    /// <summary>
    /// links a weather report to the reporting source, either an internet weather service or a local weather sensor
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasSource"></see></summary>
    let ``_#hasSource`` = _prefix "#hasSource"

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#CurrentWeatherReportFromService"></see>
    /// </summary>
    let ``_#CurrentWeatherReportFromService`` =
        _prefix "#CurrentWeatherReportFromService"

    /// <summary>
    /// this class was known as "ServiceSource" in prior versions of the ontology
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ServiceReportSource"></see></summary>
    let ``_#ServiceReportSource`` = _prefix "#ServiceReportSource"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ExtremeFrost"></see>
    /// </summary>
    let ``_#ExtremeFrost`` = _prefix "#ExtremeFrost"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ExtremeHeat"></see>
    /// </summary>
    let ``_#ExtremeHeat`` = _prefix "#ExtremeHeat"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#FairWeatherState"></see>
    /// </summary>
    let ``_#FairWeatherState`` = _prefix "#FairWeatherState"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Fog"></see>
    /// </summary>
    let ``_#Fog`` = _prefix "#Fog"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast10HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast10HoursWeatherReport`` = _prefix "#Forecast10HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast11HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast11HoursWeatherReport`` = _prefix "#Forecast11HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast13HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast13HoursWeatherReport`` = _prefix "#Forecast13HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast14HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast14HoursWeatherReport`` = _prefix "#Forecast14HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast16HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast16HoursWeatherReport`` = _prefix "#Forecast16HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast17HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast17HoursWeatherReport`` = _prefix "#Forecast17HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast19HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast19HoursWeatherReport`` = _prefix "#Forecast19HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast20HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast20HoursWeatherReport`` = _prefix "#Forecast20HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast22HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast22HoursWeatherReport`` = _prefix "#Forecast22HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast23HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast23HoursWeatherReport`` = _prefix "#Forecast23HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast4HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast4HoursWeatherReport`` = _prefix "#Forecast4HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast5HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast5HoursWeatherReport`` = _prefix "#Forecast5HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast7HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast7HoursWeatherReport`` = _prefix "#Forecast7HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast8HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast8HoursWeatherReport`` = _prefix "#Forecast8HoursWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#FreshBreeze"></see>
    /// </summary>
    let ``_#FreshBreeze`` = _prefix "#FreshBreeze"
    /// <summary>
    /// wind speed in metres per second (m/s)
    /// Wind speed
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasSpeed"></see></summary>
    let ``_#hasSpeed`` = _prefix "#hasSpeed"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#FreshGale"></see>
    /// </summary>
    let ``_#FreshGale`` = _prefix "#FreshGale"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Frost"></see>
    /// </summary>
    let ``_#Frost`` = _prefix "#Frost"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#GentleBreeze"></see>
    /// </summary>
    let ``_#GentleBreeze`` = _prefix "#GentleBreeze"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Hail"></see>
    /// </summary>
    let ``_#Hail`` = _prefix "#Hail"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Heat"></see>
    /// </summary>
    let ``_#Heat`` = _prefix "#Heat"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#HeatingWeatherState"></see>
    /// </summary>
    let ``_#HeatingWeatherState`` = _prefix "#HeatingWeatherState"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasIntensity"></see>
    /// </summary>
    let ``_#hasIntensity`` = _prefix "#hasIntensity"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#HumidifyingWeatherState"></see>
    /// </summary>
    let ``_#HumidifyingWeatherState`` = _prefix "#HumidifyingWeatherState"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Hurricane"></see>
    /// </summary>
    let ``_#Hurricane`` = _prefix "#Hurricane"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightAir"></see>
    /// </summary>
    let ``_#LightAir`` = _prefix "#LightAir"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightBreeze"></see>
    /// </summary>
    let ``_#LightBreeze`` = _prefix "#LightBreeze"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightCloud"></see>
    /// </summary>
    let ``_#LightCloud`` = _prefix "#LightCloud"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightRainSun"></see>
    /// </summary>
    let ``_#LightRainSun`` = _prefix "#LightRainSun"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LongRangeForecast"></see>
    /// </summary>
    let ``_#LongRangeForecast`` = _prefix "#LongRangeForecast"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#MidRangeForecast"></see>
    /// </summary>
    let ``_#MidRangeForecast`` = _prefix "#MidRangeForecast"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ModerateBreeze"></see>
    /// </summary>
    let ``_#ModerateBreeze`` = _prefix "#ModerateBreeze"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ModerateGale"></see>
    /// </summary>
    let ``_#ModerateGale`` = _prefix "#ModerateGale"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#NeutralWeatherState"></see>
    /// </summary>
    let ``_#NeutralWeatherState`` = _prefix "#NeutralWeatherState"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#SevereWeatherState"></see>
    /// </summary>
    let ``_#SevereWeatherState`` = _prefix "#SevereWeatherState"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#PartlyCloud"></see>
    /// </summary>
    let ``_#PartlyCloud`` = _prefix "#PartlyCloud"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Rain"></see>
    /// </summary>
    let ``_#Rain`` = _prefix "#Rain"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#RainyWeatherState"></see>
    /// </summary>
    let ``_#RainyWeatherState`` = _prefix "#RainyWeatherState"
    /// <summary>
    /// relation of weather states and a one-word description for the observed weather situation
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasWeatherCondition"></see></summary>
    let ``_#hasWeatherCondition`` = _prefix "#hasWeatherCondition"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#RoomTemperature"></see>
    /// </summary>
    let ``_#RoomTemperature`` = _prefix "#RoomTemperature"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasAssociatedSensor"></see>
    /// </summary>
    let ``_#hasAssociatedSensor`` = _prefix "#hasAssociatedSensor"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ShortRangeForecast"></see>
    /// </summary>
    let ``_#ShortRangeForecast`` = _prefix "#ShortRangeForecast"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Sleet"></see>
    /// </summary>
    let ``_#Sleet`` = _prefix "#Sleet"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Snow"></see>
    /// </summary>
    let ``_#Snow`` = _prefix "#Snow"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#SnowyWeatherState"></see>
    /// </summary>
    let ``_#SnowyWeatherState`` = _prefix "#SnowyWeatherState"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#StrongBreeze"></see>
    /// </summary>
    let ``_#StrongBreeze`` = _prefix "#StrongBreeze"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#StrongGale"></see>
    /// </summary>
    let ``_#StrongGale`` = _prefix "#StrongGale"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Sun"></see>
    /// </summary>
    let ``_#Sun`` = _prefix "#Sun"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#SunnyWeatherState"></see>
    /// </summary>
    let ``_#SunnyWeatherState`` = _prefix "#SunnyWeatherState"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Thunder"></see>
    /// </summary>
    let ``_#Thunder`` = _prefix "#Thunder"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Thunderstorm"></see>
    /// </summary>
    let ``_#Thunderstorm`` = _prefix "#Thunderstorm"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ViolentStorm"></see>
    /// </summary>
    let ``_#ViolentStorm`` = _prefix "#ViolentStorm"
    /// <summary>
    /// The instant at which a weather report is created
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#createdAt"></see></summary>
    let ``_#createdAt`` = _prefix "#createdAt"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasPriority"></see>
    /// </summary>
    let ``_#hasPriority`` = _prefix "#hasPriority"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#reportsWeatherObservation"></see>
    /// </summary>
    let ``_#reportsWeatherObservation`` = _prefix "#reportsWeatherObservation"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherReportFromSensor"></see>
    /// </summary>
    let ``_#WeatherReportFromSensor`` = _prefix "#WeatherReportFromSensor"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherReportFromService"></see>
    /// </summary>
    let ``_#WeatherReportFromService`` = _prefix "#WeatherReportFromService"
    /// <summary>
    /// Denotes the time a weather state has been observed or is forecasted for.
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasObservationTime"></see></summary>
    let ``_#hasObservationTime`` = _prefix "#hasObservationTime"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WholeGale"></see>
    /// </summary>
    let ``_#WholeGale`` = _prefix "#WholeGale"
    /// <summary>
    /// Wind direction represented in degrees
    /// Wind direction
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasDirection"></see></summary>
    let ``_#hasDirection`` = _prefix "#hasDirection"
    /// <summary>
    /// this property was known as "belongsToState" in prior versions of the ontology
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#belongsToWeatherState"></see></summary>
    let ``_#belongsToWeatherState`` = _prefix "#belongsToWeatherState"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasAirPollution"></see>
    /// </summary>
    let ``_#hasAirPollution`` = _prefix "#hasAirPollution"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasAtmosphericPressure"></see>
    /// </summary>
    let ``_#hasAtmosphericPressure`` = _prefix "#hasAtmosphericPressure"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasCloudCover"></see>
    /// </summary>
    let ``_#hasCloudCover`` = _prefix "#hasCloudCover"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasDewPointTemperature"></see>
    /// </summary>
    let ``_#hasDewPointTemperature`` = _prefix "#hasDewPointTemperature"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasEndTime"></see>
    /// </summary>
    let ``_#hasEndTime`` = _prefix "#hasEndTime"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasExteriorTemperature"></see>
    /// </summary>
    let ``_#hasExteriorTemperature`` = _prefix "#hasExteriorTemperature"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasHumidity"></see>
    /// </summary>
    let ``_#hasHumidity`` = _prefix "#hasHumidity"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasLatitude"></see>
    /// </summary>
    let ``_#hasLatitude`` = _prefix "#hasLatitude"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasLongitude"></see>
    /// </summary>
    let ``_#hasLongitude`` = _prefix "#hasLongitude"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasPrecipitation"></see>
    /// </summary>
    let ``_#hasPrecipitation`` = _prefix "#hasPrecipitation"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasSolarIrradiation"></see>
    /// </summary>
    let ``_#hasSolarIrradiation`` = _prefix "#hasSolarIrradiation"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasStartTime"></see>
    /// </summary>
    let ``_#hasStartTime`` = _prefix "#hasStartTime"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasTime"></see>
    /// </summary>
    let ``_#hasTime`` = _prefix "#hasTime"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasUnit"></see>
    /// </summary>
    let ``_#hasUnit`` = _prefix "#hasUnit"
    /// <summary>
    /// a specific weather state is reported for a location by a weather report.
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasWeatherReport"></see></summary>
    let ``_#hasWeatherReport`` = _prefix "#hasWeatherReport"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasWind"></see>
    /// </summary>
    let ``_#hasWind`` = _prefix "#hasWind"
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#isSourceOf"></see>
    /// </summary>
    let ``_#isSourceOf`` = _prefix "#isSourceOf"
