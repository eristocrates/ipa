namespace https.www.auto.tuwien.ac.at.downloads.thinkhome.ontology.WeatherOntology.owl.bare

open DoxAletheia.Rdf_Vocabulary

module hw =
    let _namespace_name =
        "https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl"

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightWind"></see>
    /// </summary>
    let ``_#LightWind`` =
        Namespaced_IRI.parse _namespace_name "#LightWind" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#NoWind"></see>
    /// </summary>
    let ``_#NoWind`` = Namespaced_IRI.parse _namespace_name "#NoWind" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Storm"></see>
    /// </summary>
    let ``_#Storm`` = Namespaced_IRI.parse _namespace_name "#Storm" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#StrongWind"></see>
    /// </summary>
    let ``_#StrongWind`` =
        Namespaced_IRI.parse _namespace_name "#StrongWind" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#MostlyCloudy"></see>
    /// </summary>
    let ``_#MostlyCloudy`` =
        Namespaced_IRI.parse _namespace_name "#MostlyCloudy" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#NoCloudCover"></see>
    /// </summary>
    let ``_#NoCloudCover`` =
        Namespaced_IRI.parse _namespace_name "#NoCloudCover" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Overcast"></see>
    /// </summary>
    let ``_#Overcast`` =
        Namespaced_IRI.parse _namespace_name "#Overcast" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#PartlyCloudy"></see>
    /// </summary>
    let ``_#PartlyCloudy`` =
        Namespaced_IRI.parse _namespace_name "#PartlyCloudy" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#UnknownCloudCover"></see>
    /// </summary>
    let ``_#UnknownCloudCover`` =
        Namespaced_IRI.parse _namespace_name "#UnknownCloudCover" |> NamespacedName

    /// <summary>
    /// One-word description of the observed weather condition
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherCondition"></see></summary>
    let ``_#WeatherCondition`` =
        Namespaced_IRI.parse _namespace_name "#WeatherCondition" |> NamespacedName

    /// <summary>
    /// different weather phenomena that may influence the current and forecasted weather state.
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherPhenomenon"></see></summary>
    let ``_#WeatherPhenomenon`` =
        Namespaced_IRI.parse _namespace_name "#WeatherPhenomenon" |> NamespacedName

    /// <summary>
    /// a weather report that can be retrieved through a local sensor (e.g. weather station integrated in the smart home) or a remote internet service. Further a time division has been realized to differentiate between current, short, mid and long term forecasts.
    ///
    /// For the smart home domain, a time window of 24 hours for weather forecasts has been seen as suitable with a 24 hours forecast being classified as long-term forecast
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherReport"></see></summary>
    let ``_#WeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#WeatherReport" |> NamespacedName

    /// <summary>
    /// Holds information about the origins of weather reports
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherReportSource"></see></summary>
    let ``_#WeatherReportSource`` =
        Namespaced_IRI.parse _namespace_name "#WeatherReportSource" |> NamespacedName

    /// <summary>
    /// Describes the actual weather reported through information from the weather source.
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherState"></see></summary>
    let ``_#WeatherState`` =
        Namespaced_IRI.parse _namespace_name "#WeatherState" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#HighAirPollution"></see>
    /// </summary>
    let ``_#HighAirPollution`` =
        Namespaced_IRI.parse _namespace_name "#HighAirPollution" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LowAirPollution"></see>
    /// </summary>
    let ``_#LowAirPollution`` =
        Namespaced_IRI.parse _namespace_name "#LowAirPollution" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#MediumAirPollution"></see>
    /// </summary>
    let ``_#MediumAirPollution`` =
        Namespaced_IRI.parse _namespace_name "#MediumAirPollution" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#VeryHighAirPollution"></see>
    /// </summary>
    let ``_#VeryHighAirPollution`` =
        Namespaced_IRI.parse _namespace_name "#VeryHighAirPollution" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#VeryLowAirPollution"></see>
    /// </summary>
    let ``_#VeryLowAirPollution`` =
        Namespaced_IRI.parse _namespace_name "#VeryLowAirPollution" |> NamespacedName

    /// <summary>
    /// the current air pollution represented as European Air Quality Index value. The index value is based on 3 pollutants of major concern in Europe: PM10, NO2, O3 and will be able to take into account to 3 additional pollutants (CO, PM2.5 and SO2) where data are also available.
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#AirPollution"></see></summary>
    let ``_#AirPollution`` =
        Namespaced_IRI.parse _namespace_name "#AirPollution" |> NamespacedName

    /// <summary>
    /// atmospheric pressure in hectopascal (hPa)
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#AtmosphericPressure"></see></summary>
    let ``_#AtmosphericPressure`` =
        Namespaced_IRI.parse _namespace_name "#AtmosphericPressure" |> NamespacedName

    /// <summary>
    /// clound cover in the unit "Okta"
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#CloudCover"></see></summary>
    let ``_#CloudCover`` =
        Namespaced_IRI.parse _namespace_name "#CloudCover" |> NamespacedName

    /// <summary>
    /// this concept was known as "DewPoint" in prior versions of the ontology
    /// The dewpoint temperature in degrees Celsius. It is the temperature at which the air can no longer hold all of its water vapor, and some of the water vapor must condense into liquid water. The dew point is always lower than (or equal to) the air temperature.
    ///
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#DewPointTemperature"></see></summary>
    let ``_#DewPointTemperature`` =
        Namespaced_IRI.parse _namespace_name "#DewPointTemperature" |> NamespacedName

    /// <summary>
    /// represents the relative humidity of the air in percent
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Humidity"></see></summary>
    let ``_#Humidity`` =
        Namespaced_IRI.parse _namespace_name "#Humidity" |> NamespacedName

    /// <summary>
    /// represents precipitation in millimetres
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Precipitation"></see></summary>
    let ``_#Precipitation`` =
        Namespaced_IRI.parse _namespace_name "#Precipitation" |> NamespacedName

    /// <summary>
    /// this concept was known as "SolarRadiation" in prior versions of the ontology
    /// measurement of solar irrradiation at a specific location in Watts per square meter (W/m²)
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#SolarIrradiance"></see></summary>
    let ``_#SolarIrradiance`` =
        Namespaced_IRI.parse _namespace_name "#SolarIrradiance" |> NamespacedName

    /// <summary>
    /// exterior temperature in degrees Celsius
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Temperature"></see></summary>
    let ``_#Temperature`` =
        Namespaced_IRI.parse _namespace_name "#Temperature" |> NamespacedName

    /// <summary>
    /// Wind direction and speed are represented as datatype properties"hasDirection" and "hasSpeed"
    ///
    /// Unit of wind speed in metres per second (m/s).
    /// Unit of wind direction is degrees
    ///
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Wind"></see></summary>
    let ``_#Wind`` = Namespaced_IRI.parse _namespace_name "#Wind" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast12HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast12HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast12HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast15HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast15HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast15HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast18HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast18HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast18HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast1HourWeatherReport"></see>
    /// </summary>
    let ``_#Forecast1HourWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast1HourWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast21HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast21HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast21HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast24HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast24HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast24HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast2HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast2HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast2HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast3HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast3HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast3HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast6HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast6HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast6HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast9HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast9HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast9HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#HeavyPrecipitation"></see>
    /// </summary>
    let ``_#HeavyPrecipitation`` =
        Namespaced_IRI.parse _namespace_name "#HeavyPrecipitation" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightPrecipitation"></see>
    /// </summary>
    let ``_#LightPrecipitation`` =
        Namespaced_IRI.parse _namespace_name "#LightPrecipitation" |> NamespacedName

    /// <summary>
    /// this concept was known as "MediumPrecipitation" in prior versions of the ontology
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ModeratePrecipitation"></see></summary>
    let ``_#ModeratePrecipitation`` =
        Namespaced_IRI.parse _namespace_name "#ModeratePrecipitation" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#NoPrecipitation"></see>
    /// </summary>
    let ``_#NoPrecipitation`` =
        Namespaced_IRI.parse _namespace_name "#NoPrecipitation" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#DryHumidity"></see>
    /// </summary>
    let ``_#DryHumidity`` =
        Namespaced_IRI.parse _namespace_name "#DryHumidity" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#MoistHumidity"></see>
    /// </summary>
    let ``_#MoistHumidity`` =
        Namespaced_IRI.parse _namespace_name "#MoistHumidity" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#OptimumHumidity"></see>
    /// </summary>
    let ``_#OptimumHumidity`` =
        Namespaced_IRI.parse _namespace_name "#OptimumHumidity" |> NamespacedName

    /// <summary>
    /// this concept was known as "HighSolarRadiation" in prior versions of the ontology
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#HighSolarIrradiance"></see></summary>
    let ``_#HighSolarIrradiance`` =
        Namespaced_IRI.parse _namespace_name "#HighSolarIrradiance" |> NamespacedName

    /// <summary>
    /// this concept was known as "LowSolarRadiation" in prior versions of the ontology
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LowSolarIrradiance"></see></summary>
    let ``_#LowSolarIrradiance`` =
        Namespaced_IRI.parse _namespace_name "#LowSolarIrradiance" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ModerateSolarIrradiance"></see>
    /// </summary>
    let ``_#ModerateSolarIrradiance`` =
        Namespaced_IRI.parse _namespace_name "#ModerateSolarIrradiance" |> NamespacedName

    /// <summary>
    /// this concept was known as "NeglectibleSolarRadiation" in prior versions of the ontology
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#NeglectibleSolarIrradiance"></see></summary>
    let ``_#NeglectibleSolarIrradiance`` =
        Namespaced_IRI.parse _namespace_name "#NeglectibleSolarIrradiance" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#AboveRoomTemperature"></see>
    /// </summary>
    let ``_#AboveRoomTemperature`` =
        Namespaced_IRI.parse _namespace_name "#AboveRoomTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasValue"></see>
    /// </summary>
    let ``_#hasValue`` =
        Namespaced_IRI.parse _namespace_name "#hasValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#AboveZeroTemperature"></see>
    /// </summary>
    let ``_#AboveZeroTemperature`` =
        Namespaced_IRI.parse _namespace_name "#AboveZeroTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#AiringWeatherState"></see>
    /// </summary>
    let ``_#AiringWeatherState`` =
        Namespaced_IRI.parse _namespace_name "#AiringWeatherState" |> NamespacedName

    /// <summary>
    /// Relation between weather states and the phenomena that are observed or forecasted
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasWeatherPhenomenon"></see></summary>
    let ``_#hasWeatherPhenomenon`` =
        Namespaced_IRI.parse _namespace_name "#hasWeatherPhenomenon" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#BelowOrZeroTemperature"></see>
    /// </summary>
    let ``_#BelowOrZeroTemperature`` =
        Namespaced_IRI.parse _namespace_name "#BelowOrZeroTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#BelowRoomTemperature"></see>
    /// </summary>
    let ``_#BelowRoomTemperature`` =
        Namespaced_IRI.parse _namespace_name "#BelowRoomTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Cloud"></see>
    /// </summary>
    let ``_#Cloud`` = Namespaced_IRI.parse _namespace_name "#Cloud" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasCloudCoverValue"></see>
    /// </summary>
    let ``_#hasCloudCoverValue`` =
        Namespaced_IRI.parse _namespace_name "#hasCloudCoverValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasCloudAltitude"></see>
    /// </summary>
    let ``_#hasCloudAltitude`` =
        Namespaced_IRI.parse _namespace_name "#hasCloudAltitude" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#CoolingWeatherState"></see>
    /// </summary>
    let ``_#CoolingWeatherState`` =
        Namespaced_IRI.parse _namespace_name "#CoolingWeatherState" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#CurrentWeatherReport"></see>
    /// </summary>
    let ``_#CurrentWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#CurrentWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ForecastWeatherReport"></see>
    /// </summary>
    let ``_#ForecastWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#ForecastWeatherReport" |> NamespacedName

    /// <summary>
    /// this property describes an interval that denotes the time in the future (offset) for which the weather is reported
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#reportsWeatherForTimeInterval"></see></summary>
    let ``_#reportsWeatherForTimeInterval`` =
        Namespaced_IRI.parse _namespace_name "#reportsWeatherForTimeInterval" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#CurrentWeatherReportFromSensor"></see>
    /// </summary>
    let ``_#CurrentWeatherReportFromSensor`` =
        Namespaced_IRI.parse _namespace_name "#CurrentWeatherReportFromSensor" |> NamespacedName

    /// <summary>
    /// this class was known as "SensorSource" in prior versions of the ontology
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#SensorReportSource"></see></summary>
    let ``_#SensorReportSource`` =
        Namespaced_IRI.parse _namespace_name "#SensorReportSource" |> NamespacedName

    /// <summary>
    /// links a weather report to the reporting source, either an internet weather service or a local weather sensor
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasSource"></see></summary>
    let ``_#hasSource`` =
        Namespaced_IRI.parse _namespace_name "#hasSource" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#CurrentWeatherReportFromService"></see>
    /// </summary>
    let ``_#CurrentWeatherReportFromService`` =
        Namespaced_IRI.parse _namespace_name "#CurrentWeatherReportFromService" |> NamespacedName

    /// <summary>
    /// this class was known as "ServiceSource" in prior versions of the ontology
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ServiceReportSource"></see></summary>
    let ``_#ServiceReportSource`` =
        Namespaced_IRI.parse _namespace_name "#ServiceReportSource" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ExtremeFrost"></see>
    /// </summary>
    let ``_#ExtremeFrost`` =
        Namespaced_IRI.parse _namespace_name "#ExtremeFrost" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ExtremeHeat"></see>
    /// </summary>
    let ``_#ExtremeHeat`` =
        Namespaced_IRI.parse _namespace_name "#ExtremeHeat" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#FairWeatherState"></see>
    /// </summary>
    let ``_#FairWeatherState`` =
        Namespaced_IRI.parse _namespace_name "#FairWeatherState" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Fog"></see>
    /// </summary>
    let ``_#Fog`` = Namespaced_IRI.parse _namespace_name "#Fog" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast10HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast10HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast10HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast11HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast11HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast11HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast13HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast13HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast13HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast14HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast14HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast14HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast16HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast16HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast16HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast17HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast17HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast17HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast19HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast19HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast19HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast20HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast20HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast20HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast22HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast22HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast22HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast23HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast23HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast23HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast4HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast4HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast4HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast5HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast5HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast5HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast7HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast7HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast7HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast8HoursWeatherReport"></see>
    /// </summary>
    let ``_#Forecast8HoursWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#Forecast8HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#FreshBreeze"></see>
    /// </summary>
    let ``_#FreshBreeze`` =
        Namespaced_IRI.parse _namespace_name "#FreshBreeze" |> NamespacedName

    /// <summary>
    /// wind speed in metres per second (m/s)
    /// Wind speed
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasSpeed"></see></summary>
    let ``_#hasSpeed`` =
        Namespaced_IRI.parse _namespace_name "#hasSpeed" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#FreshGale"></see>
    /// </summary>
    let ``_#FreshGale`` =
        Namespaced_IRI.parse _namespace_name "#FreshGale" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Frost"></see>
    /// </summary>
    let ``_#Frost`` = Namespaced_IRI.parse _namespace_name "#Frost" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#GentleBreeze"></see>
    /// </summary>
    let ``_#GentleBreeze`` =
        Namespaced_IRI.parse _namespace_name "#GentleBreeze" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Hail"></see>
    /// </summary>
    let ``_#Hail`` = Namespaced_IRI.parse _namespace_name "#Hail" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Heat"></see>
    /// </summary>
    let ``_#Heat`` = Namespaced_IRI.parse _namespace_name "#Heat" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#HeatingWeatherState"></see>
    /// </summary>
    let ``_#HeatingWeatherState`` =
        Namespaced_IRI.parse _namespace_name "#HeatingWeatherState" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasIntensity"></see>
    /// </summary>
    let ``_#hasIntensity`` =
        Namespaced_IRI.parse _namespace_name "#hasIntensity" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#HumidifyingWeatherState"></see>
    /// </summary>
    let ``_#HumidifyingWeatherState`` =
        Namespaced_IRI.parse _namespace_name "#HumidifyingWeatherState" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Hurricane"></see>
    /// </summary>
    let ``_#Hurricane`` =
        Namespaced_IRI.parse _namespace_name "#Hurricane" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightAir"></see>
    /// </summary>
    let ``_#LightAir`` =
        Namespaced_IRI.parse _namespace_name "#LightAir" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightBreeze"></see>
    /// </summary>
    let ``_#LightBreeze`` =
        Namespaced_IRI.parse _namespace_name "#LightBreeze" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightCloud"></see>
    /// </summary>
    let ``_#LightCloud`` =
        Namespaced_IRI.parse _namespace_name "#LightCloud" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightRainSun"></see>
    /// </summary>
    let ``_#LightRainSun`` =
        Namespaced_IRI.parse _namespace_name "#LightRainSun" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LongRangeForecast"></see>
    /// </summary>
    let ``_#LongRangeForecast`` =
        Namespaced_IRI.parse _namespace_name "#LongRangeForecast" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#MidRangeForecast"></see>
    /// </summary>
    let ``_#MidRangeForecast`` =
        Namespaced_IRI.parse _namespace_name "#MidRangeForecast" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ModerateBreeze"></see>
    /// </summary>
    let ``_#ModerateBreeze`` =
        Namespaced_IRI.parse _namespace_name "#ModerateBreeze" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ModerateGale"></see>
    /// </summary>
    let ``_#ModerateGale`` =
        Namespaced_IRI.parse _namespace_name "#ModerateGale" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#NeutralWeatherState"></see>
    /// </summary>
    let ``_#NeutralWeatherState`` =
        Namespaced_IRI.parse _namespace_name "#NeutralWeatherState" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#SevereWeatherState"></see>
    /// </summary>
    let ``_#SevereWeatherState`` =
        Namespaced_IRI.parse _namespace_name "#SevereWeatherState" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#PartlyCloud"></see>
    /// </summary>
    let ``_#PartlyCloud`` =
        Namespaced_IRI.parse _namespace_name "#PartlyCloud" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Rain"></see>
    /// </summary>
    let ``_#Rain`` = Namespaced_IRI.parse _namespace_name "#Rain" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#RainyWeatherState"></see>
    /// </summary>
    let ``_#RainyWeatherState`` =
        Namespaced_IRI.parse _namespace_name "#RainyWeatherState" |> NamespacedName

    /// <summary>
    /// relation of weather states and a one-word description for the observed weather situation
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasWeatherCondition"></see></summary>
    let ``_#hasWeatherCondition`` =
        Namespaced_IRI.parse _namespace_name "#hasWeatherCondition" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#RoomTemperature"></see>
    /// </summary>
    let ``_#RoomTemperature`` =
        Namespaced_IRI.parse _namespace_name "#RoomTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasAssociatedSensor"></see>
    /// </summary>
    let ``_#hasAssociatedSensor`` =
        Namespaced_IRI.parse _namespace_name "#hasAssociatedSensor" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ShortRangeForecast"></see>
    /// </summary>
    let ``_#ShortRangeForecast`` =
        Namespaced_IRI.parse _namespace_name "#ShortRangeForecast" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Sleet"></see>
    /// </summary>
    let ``_#Sleet`` = Namespaced_IRI.parse _namespace_name "#Sleet" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Snow"></see>
    /// </summary>
    let ``_#Snow`` = Namespaced_IRI.parse _namespace_name "#Snow" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#SnowyWeatherState"></see>
    /// </summary>
    let ``_#SnowyWeatherState`` =
        Namespaced_IRI.parse _namespace_name "#SnowyWeatherState" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#StrongBreeze"></see>
    /// </summary>
    let ``_#StrongBreeze`` =
        Namespaced_IRI.parse _namespace_name "#StrongBreeze" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#StrongGale"></see>
    /// </summary>
    let ``_#StrongGale`` =
        Namespaced_IRI.parse _namespace_name "#StrongGale" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Sun"></see>
    /// </summary>
    let ``_#Sun`` = Namespaced_IRI.parse _namespace_name "#Sun" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#SunnyWeatherState"></see>
    /// </summary>
    let ``_#SunnyWeatherState`` =
        Namespaced_IRI.parse _namespace_name "#SunnyWeatherState" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Thunder"></see>
    /// </summary>
    let ``_#Thunder`` =
        Namespaced_IRI.parse _namespace_name "#Thunder" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Thunderstorm"></see>
    /// </summary>
    let ``_#Thunderstorm`` =
        Namespaced_IRI.parse _namespace_name "#Thunderstorm" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ViolentStorm"></see>
    /// </summary>
    let ``_#ViolentStorm`` =
        Namespaced_IRI.parse _namespace_name "#ViolentStorm" |> NamespacedName

    /// <summary>
    /// The instant at which a weather report is created
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#createdAt"></see></summary>
    let ``_#createdAt`` =
        Namespaced_IRI.parse _namespace_name "#createdAt" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasPriority"></see>
    /// </summary>
    let ``_#hasPriority`` =
        Namespaced_IRI.parse _namespace_name "#hasPriority" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#reportsWeatherObservation"></see>
    /// </summary>
    let ``_#reportsWeatherObservation`` =
        Namespaced_IRI.parse _namespace_name "#reportsWeatherObservation" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherReportFromSensor"></see>
    /// </summary>
    let ``_#WeatherReportFromSensor`` =
        Namespaced_IRI.parse _namespace_name "#WeatherReportFromSensor" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherReportFromService"></see>
    /// </summary>
    let ``_#WeatherReportFromService`` =
        Namespaced_IRI.parse _namespace_name "#WeatherReportFromService" |> NamespacedName

    /// <summary>
    /// Denotes the time a weather state has been observed or is forecasted for.
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasObservationTime"></see></summary>
    let ``_#hasObservationTime`` =
        Namespaced_IRI.parse _namespace_name "#hasObservationTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WholeGale"></see>
    /// </summary>
    let ``_#WholeGale`` =
        Namespaced_IRI.parse _namespace_name "#WholeGale" |> NamespacedName

    /// <summary>
    /// Wind direction represented in degrees
    /// Wind direction
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasDirection"></see></summary>
    let ``_#hasDirection`` =
        Namespaced_IRI.parse _namespace_name "#hasDirection" |> NamespacedName

    /// <summary>
    /// this property was known as "belongsToState" in prior versions of the ontology
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#belongsToWeatherState"></see></summary>
    let ``_#belongsToWeatherState`` =
        Namespaced_IRI.parse _namespace_name "#belongsToWeatherState" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasAirPollution"></see>
    /// </summary>
    let ``_#hasAirPollution`` =
        Namespaced_IRI.parse _namespace_name "#hasAirPollution" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasAtmosphericPressure"></see>
    /// </summary>
    let ``_#hasAtmosphericPressure`` =
        Namespaced_IRI.parse _namespace_name "#hasAtmosphericPressure" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasCloudCover"></see>
    /// </summary>
    let ``_#hasCloudCover`` =
        Namespaced_IRI.parse _namespace_name "#hasCloudCover" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasDewPointTemperature"></see>
    /// </summary>
    let ``_#hasDewPointTemperature`` =
        Namespaced_IRI.parse _namespace_name "#hasDewPointTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasEndTime"></see>
    /// </summary>
    let ``_#hasEndTime`` =
        Namespaced_IRI.parse _namespace_name "#hasEndTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasExteriorTemperature"></see>
    /// </summary>
    let ``_#hasExteriorTemperature`` =
        Namespaced_IRI.parse _namespace_name "#hasExteriorTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasHumidity"></see>
    /// </summary>
    let ``_#hasHumidity`` =
        Namespaced_IRI.parse _namespace_name "#hasHumidity" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasLatitude"></see>
    /// </summary>
    let ``_#hasLatitude`` =
        Namespaced_IRI.parse _namespace_name "#hasLatitude" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasLongitude"></see>
    /// </summary>
    let ``_#hasLongitude`` =
        Namespaced_IRI.parse _namespace_name "#hasLongitude" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasPrecipitation"></see>
    /// </summary>
    let ``_#hasPrecipitation`` =
        Namespaced_IRI.parse _namespace_name "#hasPrecipitation" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasSolarIrradiation"></see>
    /// </summary>
    let ``_#hasSolarIrradiation`` =
        Namespaced_IRI.parse _namespace_name "#hasSolarIrradiation" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasStartTime"></see>
    /// </summary>
    let ``_#hasStartTime`` =
        Namespaced_IRI.parse _namespace_name "#hasStartTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasTime"></see>
    /// </summary>
    let ``_#hasTime`` =
        Namespaced_IRI.parse _namespace_name "#hasTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasUnit"></see>
    /// </summary>
    let ``_#hasUnit`` =
        Namespaced_IRI.parse _namespace_name "#hasUnit" |> NamespacedName

    /// <summary>
    /// a specific weather state is reported for a location by a weather report.
    /// <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasWeatherReport"></see></summary>
    let ``_#hasWeatherReport`` =
        Namespaced_IRI.parse _namespace_name "#hasWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasWind"></see>
    /// </summary>
    let ``_#hasWind`` =
        Namespaced_IRI.parse _namespace_name "#hasWind" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#isSourceOf"></see>
    /// </summary>
    let ``_#isSourceOf`` =
        Namespaced_IRI.parse _namespace_name "#isSourceOf" |> NamespacedName
