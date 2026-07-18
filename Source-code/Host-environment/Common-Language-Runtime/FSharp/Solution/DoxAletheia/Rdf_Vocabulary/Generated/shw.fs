namespace http.paul.staroch.name.thesis.SmartHomeWeather.owl.hash

open DoxAletheia.Rdf_Vocabulary

module shw =
    let _namespace_name = "http://paul.staroch.name/thesis/SmartHomeWeather.owl#"

    /// <summary>
    /// A WeatherCondition is a simple description of the state of the weather. Currently there are: Cloud, Fog, LightCloud, PartlyCloud, Rain, Sleet, Snow, Sun, Thunder.
    ///
    /// Several instances of WeatherCondition can be associated with the same instance of WeatherPhenomenon using the hasCondition property. That way, it is possible to describe a thunderstorm that comes with rain.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherCondition"></see></summary>
    let WeatherCondition =
        Namespaced_IRI.parse _namespace_name "WeatherCondition" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon specifies information about the weather (temperature, humidity etc.) for a certain WeatherState. It is linked to the WeatherState using the belongsToState property.
    ///
    /// For specifying the weather information, there exist several data properties: hasTemperature, hasHumidity, hasDewPoint, hasWindSpeed, hasWindDirection, hasPrecipitationProbability, hasPrecipitationValue, hasPressure, hasCloudCover, hasCloudAltitude, hasSunRadiation and hasSunAngleNoon.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherPhenomenon"></see></summary>
    let WeatherPhenomenon =
        Namespaced_IRI.parse _namespace_name "WeatherPhenomenon" |> NamespacedName

    /// <summary>
    /// A WeatherObservation puts together all the information known at a certain time about both the current and the future weather at a certain location.
    ///
    /// Using the mandatory properties location a Point -- having latitude, longitude and altitude -- the location this WeatherObservation belongs to is specified. The property hasObservation time gives the time when the data has been collected.
    ///
    /// A WeatherObservation can have an arbitrary number of WeatherStates. Each of them gives some information about either the current state of the weather or the weather predicted for some time in the future.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherReport"></see></summary>
    let WeatherReport =
        Namespaced_IRI.parse _namespace_name "WeatherReport" |> NamespacedName

    /// <summary>
    /// WeatherStateSource represents a source of weather data, either from a (collection of) sensor(s) (sub-concept SensorSource) or from an internet service (ServiceSource).
    ///
    /// WeatherStateSource is connected to WeatherState via the hasSource/isSourceOf properties.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherReportSource"></see></summary>
    let WeatherReportSource =
        Namespaced_IRI.parse _namespace_name "WeatherReportSource" |> NamespacedName

    /// <summary>
    /// A WeatherState is a set of weather information (temperature, humidity etc.). It is assigned to exactly one WeatherObservation (properties belongsToWeatherObservation/hasWeatherState), has a priority (property hasPriority) and has a source (where the weather information comes from, properties hasSource/isSourceOf).
    ///
    /// The weather information itself (temperature, humidity etc.) is provided using instances of WeatherPhenomenon that are connected using the belongsToState/hasWeatherPhenomenon properties.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherState"></see></summary>
    let WeatherState =
        Namespaced_IRI.parse _namespace_name "WeatherState" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon specifying atmospheric pressure using the hasPressure property (in hPa/mbar on MSL).
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#AtmosphericPressure"></see></summary>
    let AtmosphericPressure =
        Namespaced_IRI.parse _namespace_name "AtmosphericPressure" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon giving information about a cloud layer. There are two properties: hasCloudCover gives the cloud cover of this layer in okta (an integer in the interval [0-9] where 0 is clear sky, 8 is overcast and 9 is unknown). hasCloudAltitude gives the altitude of that cloud layer.
    ///
    /// If there is more than one cloud layer, for each cloud layer another WeatherPhenomenon must be created and linked to the appropriate WeatherState.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CloudCover"></see></summary>
    let CloudCover = Namespaced_IRI.parse _namespace_name "CloudCover" |> NamespacedName
    /// <summary>
    /// A WeatherPhenomenon specifying the dew point. The actual value is specified in degrees Celsius using the hasDewPoint property.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#DewPoint"></see></summary>
    let DewPoint = Namespaced_IRI.parse _namespace_name "DewPoint" |> NamespacedName
    /// <summary>
    /// A WeatherPhenomenon specifying relative humidity. Relative umidity specified using the hasHumidity property (in the interval [0,1]).
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Humidity"></see></summary>
    let Humidity = Namespaced_IRI.parse _namespace_name "Humidity" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing both precipitation probability (property hasPrecipitationProbability, in the interval [0,1]) and the amount of precipitation (property hasPrecipitationValue, in mm/h).
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Precipitation"></see></summary>
    let Precipitation =
        Namespaced_IRI.parse _namespace_name "Precipitation" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing sun radiation using the hasSunRadiation property (in W/m²).
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SolarRadiation"></see></summary>
    let SolarRadiation =
        Namespaced_IRI.parse _namespace_name "SolarRadiation" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing the sun's position at solar noon. The property hasSunAngleNoon specifies the angle of the sun above horizon in degrees Celsius.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunPosition"></see></summary>
    let SunPosition =
        Namespaced_IRI.parse _namespace_name "SunPosition" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon specifying temperature. The actual temperature is specified using the hasTemperature property (in degrees Celsius).
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Temperature"></see></summary>
    let Temperature =
        Namespaced_IRI.parse _namespace_name "Temperature" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Wind"></see></summary>
    let Wind = Namespaced_IRI.parse _namespace_name "Wind" |> NamespacedName

    /// <summary>
    /// A WeatherState describing the weather in 12 hours.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast12HoursWeatherReport"></see></summary>
    let Forecast12HoursWeatherReport =
        Namespaced_IRI.parse _namespace_name "Forecast12HoursWeatherReport" |> NamespacedName

    /// <summary>
    /// A WeatherState describing the weather in 15 hours.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast15HoursWeatherReport"></see></summary>
    let Forecast15HoursWeatherReport =
        Namespaced_IRI.parse _namespace_name "Forecast15HoursWeatherReport" |> NamespacedName

    /// <summary>
    /// A WeatherState describing the weather in 18 hours.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast18HoursWeatherReport"></see></summary>
    let Forecast18HoursWeatherReport =
        Namespaced_IRI.parse _namespace_name "Forecast18HoursWeatherReport" |> NamespacedName

    /// <summary>
    /// A WeatherState describing the weather in one hour.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast1HourWeatherReport"></see></summary>
    let Forecast1HourWeatherReport =
        Namespaced_IRI.parse _namespace_name "Forecast1HourWeatherReport" |> NamespacedName

    /// <summary>
    /// A WeatherState describing the weather in 21 hours.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast21HoursWeatherReport"></see></summary>
    let Forecast21HoursWeatherReport =
        Namespaced_IRI.parse _namespace_name "Forecast21HoursWeatherReport" |> NamespacedName

    /// <summary>
    /// A WeatherState describing the weather in 21 hours.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast24HoursWeatherReport"></see></summary>
    let Forecast24HoursWeatherReport =
        Namespaced_IRI.parse _namespace_name "Forecast24HoursWeatherReport" |> NamespacedName

    /// <summary>
    /// A WeatherState describing the weather in two hours.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast2HoursWeatherReport"></see></summary>
    let Forecast2HoursWeatherReport =
        Namespaced_IRI.parse _namespace_name "Forecast2HoursWeatherReport" |> NamespacedName

    /// <summary>
    /// A WeatherState describing the weather in three hours.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast3HoursWeatherReport"></see></summary>
    let Forecast3HoursWeatherReport =
        Namespaced_IRI.parse _namespace_name "Forecast3HoursWeatherReport" |> NamespacedName

    /// <summary>
    /// A WeatherState describing the weather in 6 hours.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast6HoursWeatherReport"></see></summary>
    let Forecast6HoursWeatherReport =
        Namespaced_IRI.parse _namespace_name "Forecast6HoursWeatherReport" |> NamespacedName

    /// <summary>
    /// A WeatherState describing the weather in 9 hours.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast9HoursWeatherReport"></see></summary>
    let Forecast9HoursWeatherReport =
        Namespaced_IRI.parse _namespace_name "Forecast9HoursWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Cloud"></see>
    /// </summary>
    let Cloud = Namespaced_IRI.parse _namespace_name "Cloud" |> NamespacedName
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Fog"></see>
    /// </summary>
    let Fog = Namespaced_IRI.parse _namespace_name "Fog" |> NamespacedName
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LightCloud"></see>
    /// </summary>
    let LightCloud = Namespaced_IRI.parse _namespace_name "LightCloud" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#PartlyCloud"></see>
    /// </summary>
    let PartlyCloud =
        Namespaced_IRI.parse _namespace_name "PartlyCloud" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Rain"></see>
    /// </summary>
    let Rain = Namespaced_IRI.parse _namespace_name "Rain" |> NamespacedName
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Sleet"></see>
    /// </summary>
    let Sleet = Namespaced_IRI.parse _namespace_name "Sleet" |> NamespacedName
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Snow"></see>
    /// </summary>
    let Snow = Namespaced_IRI.parse _namespace_name "Snow" |> NamespacedName
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Sun"></see>
    /// </summary>
    let Sun = Namespaced_IRI.parse _namespace_name "Sun" |> NamespacedName
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Thunder"></see>
    /// </summary>
    let Thunder = Namespaced_IRI.parse _namespace_name "Thunder" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing a temperature of more than 25 degrees Celsius.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#AboveRoomTemperature"></see></summary>
    let AboveRoomTemperature =
        Namespaced_IRI.parse _namespace_name "AboveRoomTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasTemperature"></see>
    /// </summary>
    let hasTemperature =
        Namespaced_IRI.parse _namespace_name "hasTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasTemperatureValue"></see>
    /// </summary>
    let hasTemperatureValue =
        Namespaced_IRI.parse _namespace_name "hasTemperatureValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#AiringWeather"></see>
    /// </summary>
    let AiringWeather =
        Namespaced_IRI.parse _namespace_name "AiringWeather" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#FairWeather"></see>
    /// </summary>
    let FairWeather =
        Namespaced_IRI.parse _namespace_name "FairWeather" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#PleasantTemperatureWeather"></see>
    /// </summary>
    let PleasantTemperatureWeather =
        Namespaced_IRI.parse _namespace_name "PleasantTemperatureWeather" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#AstronomicalTwilight"></see>
    /// </summary>
    let AstronomicalTwilight =
        Namespaced_IRI.parse _namespace_name "AstronomicalTwilight" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSunDirection"></see>
    /// </summary>
    let hasSunDirection =
        Namespaced_IRI.parse _namespace_name "hasSunDirection" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSunElevationAngle"></see>
    /// </summary>
    let hasSunElevationAngle =
        Namespaced_IRI.parse _namespace_name "hasSunElevationAngle" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPressure"></see>
    /// </summary>
    let hasPressure =
        Namespaced_IRI.parse _namespace_name "hasPressure" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hectopascal"></see>
    /// </summary>
    let hectopascal =
        Namespaced_IRI.parse _namespace_name "hectopascal" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPressureValue"></see>
    /// </summary>
    let hasPressureValue =
        Namespaced_IRI.parse _namespace_name "hasPressureValue" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing a temperature of less than 20 degrees Celsius.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#BelowRoomTemperature"></see></summary>
    let BelowRoomTemperature =
        Namespaced_IRI.parse _namespace_name "BelowRoomTemperature" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing a wind speed of less than 1 m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Calm"></see></summary>
    let Calm = Namespaced_IRI.parse _namespace_name "Calm" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasWindSpeed"></see>
    /// </summary>
    let hasWindSpeed =
        Namespaced_IRI.parse _namespace_name "hasWindSpeed" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasWindDirection"></see>
    /// </summary>
    let hasWindDirection =
        Namespaced_IRI.parse _namespace_name "hasWindDirection" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#metresPerSecond"></see>
    /// </summary>
    let metresPerSecond =
        Namespaced_IRI.parse _namespace_name "metresPerSecond" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CalmWeather"></see>
    /// </summary>
    let CalmWeather =
        Namespaced_IRI.parse _namespace_name "CalmWeather" |> NamespacedName

    /// <summary>
    /// Associates a WeatherPhenomenon to its WeatherState. One WeatherPhenomenon can only belong to one WeatherState, but one WeatherState can have an arbitrary number of instances of WeatherPhenomenon.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasWeatherPhenomenon"></see></summary>
    let hasWeatherPhenomenon =
        Namespaced_IRI.parse _namespace_name "hasWeatherPhenomenon" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing a wind speed of less than 1 m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LightWind"></see></summary>
    let LightWind = Namespaced_IRI.parse _namespace_name "LightWind" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CivilTwilight"></see>
    /// </summary>
    let CivilTwilight =
        Namespaced_IRI.parse _namespace_name "CivilTwilight" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing a cloud layer with cloud cover 0 (clear sky).
    ///
    /// NOTE: This class only specifies a single cloud layer. It does not make any statement about other cloud layers.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ClearSky"></see></summary>
    let ClearSky = Namespaced_IRI.parse _namespace_name "ClearSky" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasCloudCover"></see>
    /// </summary>
    let hasCloudCover =
        Namespaced_IRI.parse _namespace_name "hasCloudCover" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasCloudAltitude"></see>
    /// </summary>
    let hasCloudAltitude =
        Namespaced_IRI.parse _namespace_name "hasCloudAltitude" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#okta"></see>
    /// </summary>
    let okta = Namespaced_IRI.parse _namespace_name "okta" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ClearWeather"></see>
    /// </summary>
    let ClearWeather =
        Namespaced_IRI.parse _namespace_name "ClearWeather" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing a cloud layer with cloud cover 1, 2, 3 or 4 (partly cloudy).
    ///
    /// NOTE: This class only specifies a single cloud layer. It does not make any statement about other cloud layers.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#PartlyCloudy"></see></summary>
    let PartlyCloudy =
        Namespaced_IRI.parse _namespace_name "PartlyCloudy" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CloudyWeather"></see>
    /// </summary>
    let CloudyWeather =
        Namespaced_IRI.parse _namespace_name "CloudyWeather" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing a cloud layer with cloud cover 5, 6 or 7 (mostly cloudy).
    ///
    /// NOTE: This class only specifies a single cloud layer. It does not make any statement about other cloud layers.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#MostlyCloudy"></see></summary>
    let MostlyCloudy =
        Namespaced_IRI.parse _namespace_name "MostlyCloudy" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing a cloud layer with cloud cover 8 (overcast).
    ///
    /// NOTE: This class only specifies a single cloud layer. It does not make any statement about other cloud layers.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Overcast"></see></summary>
    let Overcast = Namespaced_IRI.parse _namespace_name "Overcast" |> NamespacedName
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Cold"></see>
    /// </summary>
    let Cold = Namespaced_IRI.parse _namespace_name "Cold" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ColdWeather"></see>
    /// </summary>
    let ColdWeather =
        Namespaced_IRI.parse _namespace_name "ColdWeather" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing a temperature of less than 0 degrees Celsius.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Frost"></see></summary>
    let Frost = Namespaced_IRI.parse _namespace_name "Frost" |> NamespacedName

    /// <summary>
    /// A WeatherState describing the current weather.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CurrentWeatherReport"></see></summary>
    let CurrentWeatherReport =
        Namespaced_IRI.parse _namespace_name "CurrentWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasTime"></see>
    /// </summary>
    let hasTime = Namespaced_IRI.parse _namespace_name "hasTime" |> NamespacedName
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ZeroHour"></see>
    /// </summary>
    let ZeroHour = Namespaced_IRI.parse _namespace_name "ZeroHour" |> NamespacedName

    /// <summary>
    /// A WeatherState describing the weather for some time in the future.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ForecastWeatherReport"></see></summary>
    let ForecastWeatherReport =
        Namespaced_IRI.parse _namespace_name "ForecastWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasStartTime"></see>
    /// </summary>
    let hasStartTime =
        Namespaced_IRI.parse _namespace_name "hasStartTime" |> NamespacedName

    /// <summary>
    /// A WeatherState about the current weather based on data retrieved from a (collection of) sensor(s), e.g. it is connected to an instance of SensorSource via the hasSource property.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CurrentWeatherReportFromSensor"></see></summary>
    let CurrentWeatherReportFromSensor =
        Namespaced_IRI.parse _namespace_name "CurrentWeatherReportFromSensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherStateFromSensor"></see>
    /// </summary>
    let WeatherStateFromSensor =
        Namespaced_IRI.parse _namespace_name "WeatherStateFromSensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CurrentWeatherState"></see>
    /// </summary>
    let CurrentWeatherState =
        Namespaced_IRI.parse _namespace_name "CurrentWeatherState" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherReportFromSensor"></see>
    /// </summary>
    let WeatherReportFromSensor =
        Namespaced_IRI.parse _namespace_name "WeatherReportFromSensor" |> NamespacedName

    /// <summary>
    /// A WeatherState about the current weather based on data retrieved from an internet service, e.g. it is connected to an instance of ServiceSource via the hasSource property.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CurrentWeatherReportFromService"></see></summary>
    let CurrentWeatherReportFromService =
        Namespaced_IRI.parse _namespace_name "CurrentWeatherReportFromService" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherStateFromService"></see>
    /// </summary>
    let WeatherStateFromService =
        Namespaced_IRI.parse _namespace_name "WeatherStateFromService" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherReportFromService"></see>
    /// </summary>
    let WeatherReportFromService =
        Namespaced_IRI.parse _namespace_name "WeatherReportFromService" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Day"></see>
    /// </summary>
    let Day = Namespaced_IRI.parse _namespace_name "Day" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasDewPoint"></see>
    /// </summary>
    let hasDewPoint =
        Namespaced_IRI.parse _namespace_name "hasDewPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasDewPointValue"></see>
    /// </summary>
    let hasDewPointValue =
        Namespaced_IRI.parse _namespace_name "hasDewPointValue" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#DirectionalWind"></see></summary>
    let DirectionalWind =
        Namespaced_IRI.parse _namespace_name "DirectionalWind" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing a humidity of less than 40 percent.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Dry"></see></summary>
    let Dry = Namespaced_IRI.parse _namespace_name "Dry" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasHumidity"></see>
    /// </summary>
    let hasHumidity =
        Namespaced_IRI.parse _namespace_name "hasHumidity" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasHumidityValue"></see>
    /// </summary>
    let hasHumidityValue =
        Namespaced_IRI.parse _namespace_name "hasHumidityValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#DryWeather"></see>
    /// </summary>
    let DryWeather = Namespaced_IRI.parse _namespace_name "DryWeather" |> NamespacedName
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryDry"></see>
    /// </summary>
    let VeryDry = Namespaced_IRI.parse _namespace_name "VeryDry" |> NamespacedName
    /// <summary>
    /// A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#EastWind"></see></summary>
    let EastWind = Namespaced_IRI.parse _namespace_name "EastWind" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ExtremelyHeavyRain"></see>
    /// </summary>
    let ExtremelyHeavyRain =
        Namespaced_IRI.parse _namespace_name "ExtremelyHeavyRain" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#millimetresPerHour"></see>
    /// </summary>
    let millimetresPerHour =
        Namespaced_IRI.parse _namespace_name "millimetresPerHour" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPrecipitationIntensity"></see>
    /// </summary>
    let hasPrecipitationIntensity =
        Namespaced_IRI.parse _namespace_name "hasPrecipitationIntensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPrecipitationProbability"></see>
    /// </summary>
    let hasPrecipitationProbability =
        Namespaced_IRI.parse _namespace_name "hasPrecipitationProbability" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NoRainWeather"></see>
    /// </summary>
    let NoRainWeather =
        Namespaced_IRI.parse _namespace_name "NoRainWeather" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing a temperature of more than 30 degrees Celsius.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Heat"></see></summary>
    let Heat = Namespaced_IRI.parse _namespace_name "Heat" |> NamespacedName
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#HeavyRain"></see>
    /// </summary>
    let HeavyRain = Namespaced_IRI.parse _namespace_name "HeavyRain" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing an atmospheric pressure between 1018 hPa and 1028 hPa.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#HighPressure"></see></summary>
    let HighPressure =
        Namespaced_IRI.parse _namespace_name "HighPressure" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#HighRadiation"></see>
    /// </summary>
    let HighRadiation =
        Namespaced_IRI.parse _namespace_name "HighRadiation" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#wattsPerSquareMeter"></see>
    /// </summary>
    let wattsPerSquareMeter =
        Namespaced_IRI.parse _namespace_name "wattsPerSquareMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSolarRadiationValue"></see>
    /// </summary>
    let hasSolarRadiationValue =
        Namespaced_IRI.parse _namespace_name "hasSolarRadiationValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#HotWeather"></see>
    /// </summary>
    let HotWeather = Namespaced_IRI.parse _namespace_name "HotWeather" |> NamespacedName
    /// <summary>
    /// This class describes a duration of hours.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Hour"></see></summary>
    let Hour = Namespaced_IRI.parse _namespace_name "Hour" |> NamespacedName
    /// <summary>
    /// A WeatherPhenomenon describing a wind speed of more than 32 m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Hurricane"></see></summary>
    let Hurricane = Namespaced_IRI.parse _namespace_name "Hurricane" |> NamespacedName
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LightRain"></see>
    /// </summary>
    let LightRain = Namespaced_IRI.parse _namespace_name "LightRain" |> NamespacedName

    /// <summary>
    /// A WeatherState describing the weather for more than 12 hours in the future.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LongRangeForecastReport"></see></summary>
    let LongRangeForecastReport =
        Namespaced_IRI.parse _namespace_name "LongRangeForecastReport" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LongRange"></see>
    /// </summary>
    let LongRange = Namespaced_IRI.parse _namespace_name "LongRange" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing an atmospheric pressure between 998 hPa and 1008 hPa.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LowPressure"></see></summary>
    let LowPressure =
        Namespaced_IRI.parse _namespace_name "LowPressure" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LowRadiation"></see>
    /// </summary>
    let LowRadiation =
        Namespaced_IRI.parse _namespace_name "LowRadiation" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#MediumRadiation"></see>
    /// </summary>
    let MediumRadiation =
        Namespaced_IRI.parse _namespace_name "MediumRadiation" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#MediumRain"></see>
    /// </summary>
    let MediumRain = Namespaced_IRI.parse _namespace_name "MediumRain" |> NamespacedName

    /// <summary>
    /// A WeatherState describing the weather for more than 3 and less than 12 hours in the future.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#MediumRangeForecastReport"></see></summary>
    let MediumRangeForecastReport =
        Namespaced_IRI.parse _namespace_name "MediumRangeForecastReport" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#MidRange"></see>
    /// </summary>
    let MidRange = Namespaced_IRI.parse _namespace_name "MidRange" |> NamespacedName
    /// <summary>
    /// A WeatherPhenomenon describing a humidity of more than 70 percent.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Moist"></see></summary>
    let Moist = Namespaced_IRI.parse _namespace_name "Moist" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#MoistWeather"></see>
    /// </summary>
    let MoistWeather =
        Namespaced_IRI.parse _namespace_name "MoistWeather" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryMoist"></see>
    /// </summary>
    let VeryMoist = Namespaced_IRI.parse _namespace_name "VeryMoist" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NauticalTwilight"></see>
    /// </summary>
    let NauticalTwilight =
        Namespaced_IRI.parse _namespace_name "NauticalTwilight" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Night"></see>
    /// </summary>
    let Night = Namespaced_IRI.parse _namespace_name "Night" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NoAwningWeather"></see>
    /// </summary>
    let NoAwningWeather =
        Namespaced_IRI.parse _namespace_name "NoAwningWeather" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SevereWeather"></see>
    /// </summary>
    let SevereWeather =
        Namespaced_IRI.parse _namespace_name "SevereWeather" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing a wind speed of less than 1 m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#StrongWind"></see></summary>
    let StrongWind = Namespaced_IRI.parse _namespace_name "StrongWind" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NoRadiation"></see>
    /// </summary>
    let NoRadiation =
        Namespaced_IRI.parse _namespace_name "NoRadiation" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing the absence of precipitation, either because the probability for precipitation is 0 (specified by the property hasPrecipitationProbability) or because the amount of precipitation per hour is 0 (specified by the property hasPrecipitationValue) or both.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NoRain"></see></summary>
    let NoRain = Namespaced_IRI.parse _namespace_name "NoRain" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPrecipitationValue"></see>
    /// </summary>
    let hasPrecipitationValue =
        Namespaced_IRI.parse _namespace_name "hasPrecipitationValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NormalHumidity"></see>
    /// </summary>
    let NormalHumidity =
        Namespaced_IRI.parse _namespace_name "NormalHumidity" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing an atmospheric pressure between 1008 hPa and 1018 hPa.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NormalPressure"></see></summary>
    let NormalPressure =
        Namespaced_IRI.parse _namespace_name "NormalPressure" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NorthWind"></see></summary>
    let NorthWind = Namespaced_IRI.parse _namespace_name "NorthWind" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing a temperature between 20 and 25 degrees Celsius.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#RoomTemperature"></see></summary>
    let RoomTemperature =
        Namespaced_IRI.parse _namespace_name "RoomTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#RainyWeather"></see>
    /// </summary>
    let RainyWeather =
        Namespaced_IRI.parse _namespace_name "RainyWeather" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#TropicalStormRain"></see>
    /// </summary>
    let TropicalStormRain =
        Namespaced_IRI.parse _namespace_name "TropicalStormRain" |> NamespacedName

    /// <summary>
    /// A WeatherStateSource as a (collection of) sensor(s).
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SensorSource"></see></summary>
    let SensorSource =
        Namespaced_IRI.parse _namespace_name "SensorSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherStateSource"></see>
    /// </summary>
    let WeatherStateSource =
        Namespaced_IRI.parse _namespace_name "WeatherStateSource" |> NamespacedName

    /// <summary>
    /// A WeatherStateSource as an internet service.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ServiceSource"></see></summary>
    let ServiceSource =
        Namespaced_IRI.parse _namespace_name "ServiceSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#StormyWeather"></see>
    /// </summary>
    let StormyWeather =
        Namespaced_IRI.parse _namespace_name "StormyWeather" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryRainyWeather"></see>
    /// </summary>
    let VeryRainyWeather =
        Namespaced_IRI.parse _namespace_name "VeryRainyWeather" |> NamespacedName

    /// <summary>
    /// A WeatherState describing the weather for more at most 3 hours in the future.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ShortRangeForecastReport"></see></summary>
    let ShortRangeForecastReport =
        Namespaced_IRI.parse _namespace_name "ShortRangeForecastReport" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ShortRange"></see>
    /// </summary>
    let ShortRange = Namespaced_IRI.parse _namespace_name "ShortRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSunRadiation"></see>
    /// </summary>
    let hasSunRadiation =
        Namespaced_IRI.parse _namespace_name "hasSunRadiation" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SolarTwilight"></see>
    /// </summary>
    let SolarTwilight =
        Namespaced_IRI.parse _namespace_name "SolarTwilight" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SouthWind"></see></summary>
    let SouthWind = Namespaced_IRI.parse _namespace_name "SouthWind" |> NamespacedName
    /// <summary>
    /// A WeatherPhenomenon describing a wind speed of more than 20 m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Storm"></see></summary>
    let Storm = Namespaced_IRI.parse _namespace_name "Storm" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunBelowHorizon"></see>
    /// </summary>
    let SunBelowHorizon =
        Namespaced_IRI.parse _namespace_name "SunBelowHorizon" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunFromEast"></see>
    /// </summary>
    let SunFromEast =
        Namespaced_IRI.parse _namespace_name "SunFromEast" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunFromNorth"></see>
    /// </summary>
    let SunFromNorth =
        Namespaced_IRI.parse _namespace_name "SunFromNorth" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunFromSouth"></see>
    /// </summary>
    let SunFromSouth =
        Namespaced_IRI.parse _namespace_name "SunFromSouth" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunFromWest"></see>
    /// </summary>
    let SunFromWest =
        Namespaced_IRI.parse _namespace_name "SunFromWest" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSunAngleNoon"></see>
    /// </summary>
    let hasSunAngleNoon =
        Namespaced_IRI.parse _namespace_name "hasSunAngleNoon" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunProtectionWeather"></see>
    /// </summary>
    let SunProtectionWeather =
        Namespaced_IRI.parse _namespace_name "SunProtectionWeather" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Thunderstorm"></see>
    /// </summary>
    let Thunderstorm =
        Namespaced_IRI.parse _namespace_name "Thunderstorm" |> NamespacedName

    /// <summary>
    /// Links a WeatherCondition to a WeatherPhenomenon. A WeatherPhenomenon can be associated with an arbitrary number of instances of WeatherCondition.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasCondition"></see></summary>
    let hasCondition =
        Namespaced_IRI.parse _namespace_name "hasCondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Twilight"></see>
    /// </summary>
    let Twilight = Namespaced_IRI.parse _namespace_name "Twilight" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#UnknownCloudCover"></see>
    /// </summary>
    let UnknownCloudCover =
        Namespaced_IRI.parse _namespace_name "UnknownCloudCover" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing an atmospheric pressure of more than 1028 hPa.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryHighPressure"></see></summary>
    let VeryHighPressure =
        Namespaced_IRI.parse _namespace_name "VeryHighPressure" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryHighRadiation"></see>
    /// </summary>
    let VeryHighRadiation =
        Namespaced_IRI.parse _namespace_name "VeryHighRadiation" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon describing an atmospheric pressure of less than 998 hPa.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryLowPressure"></see></summary>
    let VeryLowPressure =
        Namespaced_IRI.parse _namespace_name "VeryLowPressure" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#sunAngleNoon"></see>
    /// </summary>
    let sunAngleNoon =
        Namespaced_IRI.parse _namespace_name "sunAngleNoon" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#belongsToState"></see>
    /// </summary>
    let belongsToState =
        Namespaced_IRI.parse _namespace_name "belongsToState" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#belongsToWeather"></see>
    /// </summary>
    let belongsToWeather =
        Namespaced_IRI.parse _namespace_name "belongsToWeather" |> NamespacedName

    /// <summary>
    /// Associates a WeatherState to a WeatherObservation. One WeatherState can only be associated with one WeatherObservation.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasWeatherState"></see></summary>
    let hasWeatherState =
        Namespaced_IRI.parse _namespace_name "hasWeatherState" |> NamespacedName

    /// <summary>
    /// Associates a WeatherStateSource with a WeatherState, i.e. specifies where a WeatherState's data comes from. One WeatherState can only have one WeatherStateSource.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSource"></see></summary>
    let hasSource = Namespaced_IRI.parse _namespace_name "hasSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasObservationTime"></see>
    /// </summary>
    let hasObservationTime =
        Namespaced_IRI.parse _namespace_name "hasObservationTime" |> NamespacedName

    /// <summary>
    /// Specifies the priority of a WeatherState (a positive integer). The higher this value is compared to another WeatherState's priority, the more the WeatherState takes precedence over the other WeatherState.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPriority"></see></summary>
    let hasPriority =
        Namespaced_IRI.parse _namespace_name "hasPriority" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasEndTime"></see>
    /// </summary>
    let hasEndTime = Namespaced_IRI.parse _namespace_name "hasEndTime" |> NamespacedName
    /// <summary>
    /// Inverse property of hasSource.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#isSourceOf"></see></summary>
    let isSourceOf = Namespaced_IRI.parse _namespace_name "isSourceOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasTemporalEntity"></see>
    /// </summary>
    let hasTemporalEntity =
        Namespaced_IRI.parse _namespace_name "hasTemporalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherObservation"></see>
    /// </summary>
    let WeatherObservation =
        Namespaced_IRI.parse _namespace_name "WeatherObservation" |> NamespacedName

    /// <summary>
    /// A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WestWind"></see></summary>
    let WestWind = Namespaced_IRI.parse _namespace_name "WestWind" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WindyWeather"></see>
    /// </summary>
    let WindyWeather =
        Namespaced_IRI.parse _namespace_name "WindyWeather" |> NamespacedName

    /// <summary>
    /// Inverse property of hasWeatherState.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#belongsToWeatherReport"></see></summary>
    let belongsToWeatherReport =
        Namespaced_IRI.parse _namespace_name "belongsToWeatherReport" |> NamespacedName

    /// <summary>
    /// Inverse property of hasWeatherPhenomenon.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#belongsToWeatherState"></see></summary>
    let belongsToWeatherState =
        Namespaced_IRI.parse _namespace_name "belongsToWeatherState" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#cloudCoverage"></see>
    /// </summary>
    let cloudCoverage =
        Namespaced_IRI.parse _namespace_name "cloudCoverage" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasNextWeatherState"></see>
    /// </summary>
    let hasNextWeatherState =
        Namespaced_IRI.parse _namespace_name "hasNextWeatherState" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPreviousWeatherState"></see>
    /// </summary>
    let hasPreviousWeatherState =
        Namespaced_IRI.parse _namespace_name "hasPreviousWeatherState" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#irradiance"></see>
    /// </summary>
    let irradiance = Namespaced_IRI.parse _namespace_name "irradiance" |> NamespacedName
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#speed"></see>
    /// </summary>
    let speed = Namespaced_IRI.parse _namespace_name "speed" |> NamespacedName
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#millimeter"></see>
    /// </summary>
    let millimeter = Namespaced_IRI.parse _namespace_name "millimeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#precipitationIntensity"></see>
    /// </summary>
    let precipitationIntensity =
        Namespaced_IRI.parse _namespace_name "precipitationIntensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#squareMeter"></see>
    /// </summary>
    let squareMeter =
        Namespaced_IRI.parse _namespace_name "squareMeter" |> NamespacedName
