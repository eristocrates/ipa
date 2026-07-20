namespace http.paul.staroch.name.thesis.SmartHomeWeather.owl.hash

open DoxAletheia

module shw =
    let _namespace_name = "http://paul.staroch.name/thesis/SmartHomeWeather.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A WeatherCondition is a simple description of the state of the weather. Currently there are: Cloud, Fog, LightCloud, PartlyCloud, Rain, Sleet, Snow, Sun, Thunder.
    ///
    /// Several instances of WeatherCondition can be associated with the same instance of WeatherPhenomenon using the hasCondition property. That way, it is possible to describe a thunderstorm that comes with rain.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherCondition"></see></summary>
    let WeatherCondition = _prefix "WeatherCondition"
    /// <summary>
    /// A WeatherPhenomenon specifies information about the weather (temperature, humidity etc.) for a certain WeatherState. It is linked to the WeatherState using the belongsToState property.
    ///
    /// For specifying the weather information, there exist several data properties: hasTemperature, hasHumidity, hasDewPoint, hasWindSpeed, hasWindDirection, hasPrecipitationProbability, hasPrecipitationValue, hasPressure, hasCloudCover, hasCloudAltitude, hasSunRadiation and hasSunAngleNoon.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherPhenomenon"></see></summary>
    let WeatherPhenomenon = _prefix "WeatherPhenomenon"
    /// <summary>
    /// A WeatherObservation puts together all the information known at a certain time about both the current and the future weather at a certain location.
    ///
    /// Using the mandatory properties location a Point -- having latitude, longitude and altitude -- the location this WeatherObservation belongs to is specified. The property hasObservation time gives the time when the data has been collected.
    ///
    /// A WeatherObservation can have an arbitrary number of WeatherStates. Each of them gives some information about either the current state of the weather or the weather predicted for some time in the future.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherReport"></see></summary>
    let WeatherReport = _prefix "WeatherReport"
    /// <summary>
    /// WeatherStateSource represents a source of weather data, either from a (collection of) sensor(s) (sub-concept SensorSource) or from an internet service (ServiceSource).
    ///
    /// WeatherStateSource is connected to WeatherState via the hasSource/isSourceOf properties.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherReportSource"></see></summary>
    let WeatherReportSource = _prefix "WeatherReportSource"
    /// <summary>
    /// A WeatherState is a set of weather information (temperature, humidity etc.). It is assigned to exactly one WeatherObservation (properties belongsToWeatherObservation/hasWeatherState), has a priority (property hasPriority) and has a source (where the weather information comes from, properties hasSource/isSourceOf).
    ///
    /// The weather information itself (temperature, humidity etc.) is provided using instances of WeatherPhenomenon that are connected using the belongsToState/hasWeatherPhenomenon properties.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherState"></see></summary>
    let WeatherState = _prefix "WeatherState"
    /// <summary>
    /// A WeatherPhenomenon specifying atmospheric pressure using the hasPressure property (in hPa/mbar on MSL).
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#AtmosphericPressure"></see></summary>
    let AtmosphericPressure = _prefix "AtmosphericPressure"
    /// <summary>
    /// A WeatherPhenomenon giving information about a cloud layer. There are two properties: hasCloudCover gives the cloud cover of this layer in okta (an integer in the interval [0-9] where 0 is clear sky, 8 is overcast and 9 is unknown). hasCloudAltitude gives the altitude of that cloud layer.
    ///
    /// If there is more than one cloud layer, for each cloud layer another WeatherPhenomenon must be created and linked to the appropriate WeatherState.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CloudCover"></see></summary>
    let CloudCover = _prefix "CloudCover"
    /// <summary>
    /// A WeatherPhenomenon specifying the dew point. The actual value is specified in degrees Celsius using the hasDewPoint property.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#DewPoint"></see></summary>
    let DewPoint = _prefix "DewPoint"
    /// <summary>
    /// A WeatherPhenomenon specifying relative humidity. Relative umidity specified using the hasHumidity property (in the interval [0,1]).
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Humidity"></see></summary>
    let Humidity = _prefix "Humidity"
    /// <summary>
    /// A WeatherPhenomenon describing both precipitation probability (property hasPrecipitationProbability, in the interval [0,1]) and the amount of precipitation (property hasPrecipitationValue, in mm/h).
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Precipitation"></see></summary>
    let Precipitation = _prefix "Precipitation"
    /// <summary>
    /// A WeatherPhenomenon describing sun radiation using the hasSunRadiation property (in W/m²).
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SolarRadiation"></see></summary>
    let SolarRadiation = _prefix "SolarRadiation"
    /// <summary>
    /// A WeatherPhenomenon describing the sun's position at solar noon. The property hasSunAngleNoon specifies the angle of the sun above horizon in degrees Celsius.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunPosition"></see></summary>
    let SunPosition = _prefix "SunPosition"
    /// <summary>
    /// A WeatherPhenomenon specifying temperature. The actual temperature is specified using the hasTemperature property (in degrees Celsius).
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Temperature"></see></summary>
    let Temperature = _prefix "Temperature"
    /// <summary>
    /// A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Wind"></see></summary>
    let Wind = _prefix "Wind"
    /// <summary>
    /// A WeatherState describing the weather in 12 hours.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast12HoursWeatherReport"></see></summary>
    let Forecast12HoursWeatherReport = _prefix "Forecast12HoursWeatherReport"
    /// <summary>
    /// A WeatherState describing the weather in 15 hours.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast15HoursWeatherReport"></see></summary>
    let Forecast15HoursWeatherReport = _prefix "Forecast15HoursWeatherReport"
    /// <summary>
    /// A WeatherState describing the weather in 18 hours.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast18HoursWeatherReport"></see></summary>
    let Forecast18HoursWeatherReport = _prefix "Forecast18HoursWeatherReport"
    /// <summary>
    /// A WeatherState describing the weather in one hour.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast1HourWeatherReport"></see></summary>
    let Forecast1HourWeatherReport = _prefix "Forecast1HourWeatherReport"
    /// <summary>
    /// A WeatherState describing the weather in 21 hours.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast21HoursWeatherReport"></see></summary>
    let Forecast21HoursWeatherReport = _prefix "Forecast21HoursWeatherReport"
    /// <summary>
    /// A WeatherState describing the weather in 21 hours.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast24HoursWeatherReport"></see></summary>
    let Forecast24HoursWeatherReport = _prefix "Forecast24HoursWeatherReport"
    /// <summary>
    /// A WeatherState describing the weather in two hours.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast2HoursWeatherReport"></see></summary>
    let Forecast2HoursWeatherReport = _prefix "Forecast2HoursWeatherReport"
    /// <summary>
    /// A WeatherState describing the weather in three hours.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast3HoursWeatherReport"></see></summary>
    let Forecast3HoursWeatherReport = _prefix "Forecast3HoursWeatherReport"
    /// <summary>
    /// A WeatherState describing the weather in 6 hours.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast6HoursWeatherReport"></see></summary>
    let Forecast6HoursWeatherReport = _prefix "Forecast6HoursWeatherReport"
    /// <summary>
    /// A WeatherState describing the weather in 9 hours.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast9HoursWeatherReport"></see></summary>
    let Forecast9HoursWeatherReport = _prefix "Forecast9HoursWeatherReport"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Cloud"></see>
    /// </summary>
    let Cloud = _prefix "Cloud"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Fog"></see>
    /// </summary>
    let Fog = _prefix "Fog"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LightCloud"></see>
    /// </summary>
    let LightCloud = _prefix "LightCloud"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#PartlyCloud"></see>
    /// </summary>
    let PartlyCloud = _prefix "PartlyCloud"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Rain"></see>
    /// </summary>
    let Rain = _prefix "Rain"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Sleet"></see>
    /// </summary>
    let Sleet = _prefix "Sleet"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Snow"></see>
    /// </summary>
    let Snow = _prefix "Snow"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Sun"></see>
    /// </summary>
    let Sun = _prefix "Sun"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Thunder"></see>
    /// </summary>
    let Thunder = _prefix "Thunder"
    /// <summary>
    /// A WeatherPhenomenon describing a temperature of more than 25 degrees Celsius.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#AboveRoomTemperature"></see></summary>
    let AboveRoomTemperature = _prefix "AboveRoomTemperature"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasTemperature"></see>
    /// </summary>
    let hasTemperature = _prefix "hasTemperature"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasTemperatureValue"></see>
    /// </summary>
    let hasTemperatureValue = _prefix "hasTemperatureValue"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#AiringWeather"></see>
    /// </summary>
    let AiringWeather = _prefix "AiringWeather"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#FairWeather"></see>
    /// </summary>
    let FairWeather = _prefix "FairWeather"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#PleasantTemperatureWeather"></see>
    /// </summary>
    let PleasantTemperatureWeather = _prefix "PleasantTemperatureWeather"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#AstronomicalTwilight"></see>
    /// </summary>
    let AstronomicalTwilight = _prefix "AstronomicalTwilight"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSunDirection"></see>
    /// </summary>
    let hasSunDirection = _prefix "hasSunDirection"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSunElevationAngle"></see>
    /// </summary>
    let hasSunElevationAngle = _prefix "hasSunElevationAngle"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPressure"></see>
    /// </summary>
    let hasPressure = _prefix "hasPressure"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hectopascal"></see>
    /// </summary>
    let hectopascal = _prefix "hectopascal"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPressureValue"></see>
    /// </summary>
    let hasPressureValue = _prefix "hasPressureValue"
    /// <summary>
    /// A WeatherPhenomenon describing a temperature of less than 20 degrees Celsius.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#BelowRoomTemperature"></see></summary>
    let BelowRoomTemperature = _prefix "BelowRoomTemperature"
    /// <summary>
    /// A WeatherPhenomenon describing a wind speed of less than 1 m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Calm"></see></summary>
    let Calm = _prefix "Calm"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasWindSpeed"></see>
    /// </summary>
    let hasWindSpeed = _prefix "hasWindSpeed"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasWindDirection"></see>
    /// </summary>
    let hasWindDirection = _prefix "hasWindDirection"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#metresPerSecond"></see>
    /// </summary>
    let metresPerSecond = _prefix "metresPerSecond"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CalmWeather"></see>
    /// </summary>
    let CalmWeather = _prefix "CalmWeather"
    /// <summary>
    /// Associates a WeatherPhenomenon to its WeatherState. One WeatherPhenomenon can only belong to one WeatherState, but one WeatherState can have an arbitrary number of instances of WeatherPhenomenon.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasWeatherPhenomenon"></see></summary>
    let hasWeatherPhenomenon = _prefix "hasWeatherPhenomenon"
    /// <summary>
    /// A WeatherPhenomenon describing a wind speed of less than 1 m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LightWind"></see></summary>
    let LightWind = _prefix "LightWind"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CivilTwilight"></see>
    /// </summary>
    let CivilTwilight = _prefix "CivilTwilight"
    /// <summary>
    /// A WeatherPhenomenon describing a cloud layer with cloud cover 0 (clear sky).
    ///
    /// NOTE: This class only specifies a single cloud layer. It does not make any statement about other cloud layers.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ClearSky"></see></summary>
    let ClearSky = _prefix "ClearSky"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasCloudCover"></see>
    /// </summary>
    let hasCloudCover = _prefix "hasCloudCover"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasCloudAltitude"></see>
    /// </summary>
    let hasCloudAltitude = _prefix "hasCloudAltitude"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#okta"></see>
    /// </summary>
    let okta = _prefix "okta"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ClearWeather"></see>
    /// </summary>
    let ClearWeather = _prefix "ClearWeather"
    /// <summary>
    /// A WeatherPhenomenon describing a cloud layer with cloud cover 1, 2, 3 or 4 (partly cloudy).
    ///
    /// NOTE: This class only specifies a single cloud layer. It does not make any statement about other cloud layers.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#PartlyCloudy"></see></summary>
    let PartlyCloudy = _prefix "PartlyCloudy"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CloudyWeather"></see>
    /// </summary>
    let CloudyWeather = _prefix "CloudyWeather"
    /// <summary>
    /// A WeatherPhenomenon describing a cloud layer with cloud cover 5, 6 or 7 (mostly cloudy).
    ///
    /// NOTE: This class only specifies a single cloud layer. It does not make any statement about other cloud layers.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#MostlyCloudy"></see></summary>
    let MostlyCloudy = _prefix "MostlyCloudy"
    /// <summary>
    /// A WeatherPhenomenon describing a cloud layer with cloud cover 8 (overcast).
    ///
    /// NOTE: This class only specifies a single cloud layer. It does not make any statement about other cloud layers.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Overcast"></see></summary>
    let Overcast = _prefix "Overcast"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Cold"></see>
    /// </summary>
    let Cold = _prefix "Cold"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ColdWeather"></see>
    /// </summary>
    let ColdWeather = _prefix "ColdWeather"
    /// <summary>
    /// A WeatherPhenomenon describing a temperature of less than 0 degrees Celsius.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Frost"></see></summary>
    let Frost = _prefix "Frost"
    /// <summary>
    /// A WeatherState describing the current weather.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CurrentWeatherReport"></see></summary>
    let CurrentWeatherReport = _prefix "CurrentWeatherReport"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasTime"></see>
    /// </summary>
    let hasTime = _prefix "hasTime"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ZeroHour"></see>
    /// </summary>
    let ZeroHour = _prefix "ZeroHour"
    /// <summary>
    /// A WeatherState describing the weather for some time in the future.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ForecastWeatherReport"></see></summary>
    let ForecastWeatherReport = _prefix "ForecastWeatherReport"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasStartTime"></see>
    /// </summary>
    let hasStartTime = _prefix "hasStartTime"
    /// <summary>
    /// A WeatherState about the current weather based on data retrieved from a (collection of) sensor(s), e.g. it is connected to an instance of SensorSource via the hasSource property.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CurrentWeatherReportFromSensor"></see></summary>
    let CurrentWeatherReportFromSensor = _prefix "CurrentWeatherReportFromSensor"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherStateFromSensor"></see>
    /// </summary>
    let WeatherStateFromSensor = _prefix "WeatherStateFromSensor"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CurrentWeatherState"></see>
    /// </summary>
    let CurrentWeatherState = _prefix "CurrentWeatherState"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherReportFromSensor"></see>
    /// </summary>
    let WeatherReportFromSensor = _prefix "WeatherReportFromSensor"
    /// <summary>
    /// A WeatherState about the current weather based on data retrieved from an internet service, e.g. it is connected to an instance of ServiceSource via the hasSource property.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CurrentWeatherReportFromService"></see></summary>
    let CurrentWeatherReportFromService = _prefix "CurrentWeatherReportFromService"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherStateFromService"></see>
    /// </summary>
    let WeatherStateFromService = _prefix "WeatherStateFromService"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherReportFromService"></see>
    /// </summary>
    let WeatherReportFromService = _prefix "WeatherReportFromService"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Day"></see>
    /// </summary>
    let Day = _prefix "Day"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasDewPoint"></see>
    /// </summary>
    let hasDewPoint = _prefix "hasDewPoint"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasDewPointValue"></see>
    /// </summary>
    let hasDewPointValue = _prefix "hasDewPointValue"
    /// <summary>
    /// A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#DirectionalWind"></see></summary>
    let DirectionalWind = _prefix "DirectionalWind"
    /// <summary>
    /// A WeatherPhenomenon describing a humidity of less than 40 percent.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Dry"></see></summary>
    let Dry = _prefix "Dry"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasHumidity"></see>
    /// </summary>
    let hasHumidity = _prefix "hasHumidity"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasHumidityValue"></see>
    /// </summary>
    let hasHumidityValue = _prefix "hasHumidityValue"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#DryWeather"></see>
    /// </summary>
    let DryWeather = _prefix "DryWeather"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryDry"></see>
    /// </summary>
    let VeryDry = _prefix "VeryDry"
    /// <summary>
    /// A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#EastWind"></see></summary>
    let EastWind = _prefix "EastWind"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ExtremelyHeavyRain"></see>
    /// </summary>
    let ExtremelyHeavyRain = _prefix "ExtremelyHeavyRain"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#millimetresPerHour"></see>
    /// </summary>
    let millimetresPerHour = _prefix "millimetresPerHour"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPrecipitationIntensity"></see>
    /// </summary>
    let hasPrecipitationIntensity = _prefix "hasPrecipitationIntensity"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPrecipitationProbability"></see>
    /// </summary>
    let hasPrecipitationProbability = _prefix "hasPrecipitationProbability"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NoRainWeather"></see>
    /// </summary>
    let NoRainWeather = _prefix "NoRainWeather"
    /// <summary>
    /// A WeatherPhenomenon describing a temperature of more than 30 degrees Celsius.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Heat"></see></summary>
    let Heat = _prefix "Heat"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#HeavyRain"></see>
    /// </summary>
    let HeavyRain = _prefix "HeavyRain"
    /// <summary>
    /// A WeatherPhenomenon describing an atmospheric pressure between 1018 hPa and 1028 hPa.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#HighPressure"></see></summary>
    let HighPressure = _prefix "HighPressure"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#HighRadiation"></see>
    /// </summary>
    let HighRadiation = _prefix "HighRadiation"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#wattsPerSquareMeter"></see>
    /// </summary>
    let wattsPerSquareMeter = _prefix "wattsPerSquareMeter"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSolarRadiationValue"></see>
    /// </summary>
    let hasSolarRadiationValue = _prefix "hasSolarRadiationValue"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#HotWeather"></see>
    /// </summary>
    let HotWeather = _prefix "HotWeather"
    /// <summary>
    /// This class describes a duration of hours.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Hour"></see></summary>
    let Hour = _prefix "Hour"
    /// <summary>
    /// A WeatherPhenomenon describing a wind speed of more than 32 m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Hurricane"></see></summary>
    let Hurricane = _prefix "Hurricane"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LightRain"></see>
    /// </summary>
    let LightRain = _prefix "LightRain"
    /// <summary>
    /// A WeatherState describing the weather for more than 12 hours in the future.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LongRangeForecastReport"></see></summary>
    let LongRangeForecastReport = _prefix "LongRangeForecastReport"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LongRange"></see>
    /// </summary>
    let LongRange = _prefix "LongRange"
    /// <summary>
    /// A WeatherPhenomenon describing an atmospheric pressure between 998 hPa and 1008 hPa.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LowPressure"></see></summary>
    let LowPressure = _prefix "LowPressure"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LowRadiation"></see>
    /// </summary>
    let LowRadiation = _prefix "LowRadiation"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#MediumRadiation"></see>
    /// </summary>
    let MediumRadiation = _prefix "MediumRadiation"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#MediumRain"></see>
    /// </summary>
    let MediumRain = _prefix "MediumRain"
    /// <summary>
    /// A WeatherState describing the weather for more than 3 and less than 12 hours in the future.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#MediumRangeForecastReport"></see></summary>
    let MediumRangeForecastReport = _prefix "MediumRangeForecastReport"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#MidRange"></see>
    /// </summary>
    let MidRange = _prefix "MidRange"
    /// <summary>
    /// A WeatherPhenomenon describing a humidity of more than 70 percent.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Moist"></see></summary>
    let Moist = _prefix "Moist"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#MoistWeather"></see>
    /// </summary>
    let MoistWeather = _prefix "MoistWeather"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryMoist"></see>
    /// </summary>
    let VeryMoist = _prefix "VeryMoist"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NauticalTwilight"></see>
    /// </summary>
    let NauticalTwilight = _prefix "NauticalTwilight"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Night"></see>
    /// </summary>
    let Night = _prefix "Night"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NoAwningWeather"></see>
    /// </summary>
    let NoAwningWeather = _prefix "NoAwningWeather"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SevereWeather"></see>
    /// </summary>
    let SevereWeather = _prefix "SevereWeather"
    /// <summary>
    /// A WeatherPhenomenon describing a wind speed of less than 1 m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#StrongWind"></see></summary>
    let StrongWind = _prefix "StrongWind"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NoRadiation"></see>
    /// </summary>
    let NoRadiation = _prefix "NoRadiation"
    /// <summary>
    /// A WeatherPhenomenon describing the absence of precipitation, either because the probability for precipitation is 0 (specified by the property hasPrecipitationProbability) or because the amount of precipitation per hour is 0 (specified by the property hasPrecipitationValue) or both.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NoRain"></see></summary>
    let NoRain = _prefix "NoRain"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPrecipitationValue"></see>
    /// </summary>
    let hasPrecipitationValue = _prefix "hasPrecipitationValue"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NormalHumidity"></see>
    /// </summary>
    let NormalHumidity = _prefix "NormalHumidity"
    /// <summary>
    /// A WeatherPhenomenon describing an atmospheric pressure between 1008 hPa and 1018 hPa.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NormalPressure"></see></summary>
    let NormalPressure = _prefix "NormalPressure"
    /// <summary>
    /// A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NorthWind"></see></summary>
    let NorthWind = _prefix "NorthWind"
    /// <summary>
    /// A WeatherPhenomenon describing a temperature between 20 and 25 degrees Celsius.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#RoomTemperature"></see></summary>
    let RoomTemperature = _prefix "RoomTemperature"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#RainyWeather"></see>
    /// </summary>
    let RainyWeather = _prefix "RainyWeather"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#TropicalStormRain"></see>
    /// </summary>
    let TropicalStormRain = _prefix "TropicalStormRain"
    /// <summary>
    /// A WeatherStateSource as a (collection of) sensor(s).
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SensorSource"></see></summary>
    let SensorSource = _prefix "SensorSource"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherStateSource"></see>
    /// </summary>
    let WeatherStateSource = _prefix "WeatherStateSource"
    /// <summary>
    /// A WeatherStateSource as an internet service.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ServiceSource"></see></summary>
    let ServiceSource = _prefix "ServiceSource"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#StormyWeather"></see>
    /// </summary>
    let StormyWeather = _prefix "StormyWeather"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryRainyWeather"></see>
    /// </summary>
    let VeryRainyWeather = _prefix "VeryRainyWeather"
    /// <summary>
    /// A WeatherState describing the weather for more at most 3 hours in the future.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ShortRangeForecastReport"></see></summary>
    let ShortRangeForecastReport = _prefix "ShortRangeForecastReport"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ShortRange"></see>
    /// </summary>
    let ShortRange = _prefix "ShortRange"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSunRadiation"></see>
    /// </summary>
    let hasSunRadiation = _prefix "hasSunRadiation"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SolarTwilight"></see>
    /// </summary>
    let SolarTwilight = _prefix "SolarTwilight"
    /// <summary>
    /// A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SouthWind"></see></summary>
    let SouthWind = _prefix "SouthWind"
    /// <summary>
    /// A WeatherPhenomenon describing a wind speed of more than 20 m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Storm"></see></summary>
    let Storm = _prefix "Storm"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunBelowHorizon"></see>
    /// </summary>
    let SunBelowHorizon = _prefix "SunBelowHorizon"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunFromEast"></see>
    /// </summary>
    let SunFromEast = _prefix "SunFromEast"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunFromNorth"></see>
    /// </summary>
    let SunFromNorth = _prefix "SunFromNorth"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunFromSouth"></see>
    /// </summary>
    let SunFromSouth = _prefix "SunFromSouth"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunFromWest"></see>
    /// </summary>
    let SunFromWest = _prefix "SunFromWest"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSunAngleNoon"></see>
    /// </summary>
    let hasSunAngleNoon = _prefix "hasSunAngleNoon"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunProtectionWeather"></see>
    /// </summary>
    let SunProtectionWeather = _prefix "SunProtectionWeather"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Thunderstorm"></see>
    /// </summary>
    let Thunderstorm = _prefix "Thunderstorm"
    /// <summary>
    /// Links a WeatherCondition to a WeatherPhenomenon. A WeatherPhenomenon can be associated with an arbitrary number of instances of WeatherCondition.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasCondition"></see></summary>
    let hasCondition = _prefix "hasCondition"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Twilight"></see>
    /// </summary>
    let Twilight = _prefix "Twilight"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#UnknownCloudCover"></see>
    /// </summary>
    let UnknownCloudCover = _prefix "UnknownCloudCover"
    /// <summary>
    /// A WeatherPhenomenon describing an atmospheric pressure of more than 1028 hPa.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryHighPressure"></see></summary>
    let VeryHighPressure = _prefix "VeryHighPressure"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryHighRadiation"></see>
    /// </summary>
    let VeryHighRadiation = _prefix "VeryHighRadiation"
    /// <summary>
    /// A WeatherPhenomenon describing an atmospheric pressure of less than 998 hPa.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryLowPressure"></see></summary>
    let VeryLowPressure = _prefix "VeryLowPressure"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#sunAngleNoon"></see>
    /// </summary>
    let sunAngleNoon = _prefix "sunAngleNoon"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#belongsToState"></see>
    /// </summary>
    let belongsToState = _prefix "belongsToState"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#belongsToWeather"></see>
    /// </summary>
    let belongsToWeather = _prefix "belongsToWeather"
    /// <summary>
    /// Associates a WeatherState to a WeatherObservation. One WeatherState can only be associated with one WeatherObservation.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasWeatherState"></see></summary>
    let hasWeatherState = _prefix "hasWeatherState"
    /// <summary>
    /// Associates a WeatherStateSource with a WeatherState, i.e. specifies where a WeatherState's data comes from. One WeatherState can only have one WeatherStateSource.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSource"></see></summary>
    let hasSource = _prefix "hasSource"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasObservationTime"></see>
    /// </summary>
    let hasObservationTime = _prefix "hasObservationTime"
    /// <summary>
    /// Specifies the priority of a WeatherState (a positive integer). The higher this value is compared to another WeatherState's priority, the more the WeatherState takes precedence over the other WeatherState.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPriority"></see></summary>
    let hasPriority = _prefix "hasPriority"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasEndTime"></see>
    /// </summary>
    let hasEndTime = _prefix "hasEndTime"
    /// <summary>
    /// Inverse property of hasSource.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#isSourceOf"></see></summary>
    let isSourceOf = _prefix "isSourceOf"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasTemporalEntity"></see>
    /// </summary>
    let hasTemporalEntity = _prefix "hasTemporalEntity"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherObservation"></see>
    /// </summary>
    let WeatherObservation = _prefix "WeatherObservation"
    /// <summary>
    /// A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WestWind"></see></summary>
    let WestWind = _prefix "WestWind"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WindyWeather"></see>
    /// </summary>
    let WindyWeather = _prefix "WindyWeather"
    /// <summary>
    /// Inverse property of hasWeatherState.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#belongsToWeatherReport"></see></summary>
    let belongsToWeatherReport = _prefix "belongsToWeatherReport"
    /// <summary>
    /// Inverse property of hasWeatherPhenomenon.
    /// <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#belongsToWeatherState"></see></summary>
    let belongsToWeatherState = _prefix "belongsToWeatherState"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#cloudCoverage"></see>
    /// </summary>
    let cloudCoverage = _prefix "cloudCoverage"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasNextWeatherState"></see>
    /// </summary>
    let hasNextWeatherState = _prefix "hasNextWeatherState"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPreviousWeatherState"></see>
    /// </summary>
    let hasPreviousWeatherState = _prefix "hasPreviousWeatherState"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#irradiance"></see>
    /// </summary>
    let irradiance = _prefix "irradiance"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#speed"></see>
    /// </summary>
    let speed = _prefix "speed"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#millimeter"></see>
    /// </summary>
    let millimeter = _prefix "millimeter"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#precipitationIntensity"></see>
    /// </summary>
    let precipitationIntensity = _prefix "precipitationIntensity"
    /// <summary>
    ///   <see href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#squareMeter"></see>
    /// </summary>
    let squareMeter = _prefix "squareMeter"
