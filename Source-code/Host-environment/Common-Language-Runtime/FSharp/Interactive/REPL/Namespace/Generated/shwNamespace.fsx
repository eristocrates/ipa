#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module shw =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://paul.staroch.name/thesis/SmartHomeWeather.owl#" "shw"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing a temperature of more than 25 degrees Celsius.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#AboveRoomTemperature">shw:AboveRoomTemperature</a>
    /// </summary>
    let AboveRoomTemperature = _prefixId.prefix "AboveRoomTemperature"
    let AiringWeather = _prefixId.prefix "AiringWeather"
    let AstronomicalTwilight = _prefixId.prefix "AstronomicalTwilight"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon specifying atmospheric pressure using the hasPressure property (in hPa/mbar on MSL).^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#AtmosphericPressure">shw:AtmosphericPressure</a>
    /// </summary>
    let AtmosphericPressure = _prefixId.prefix "AtmosphericPressure"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing a temperature of less than 20 degrees Celsius.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#BelowRoomTemperature">shw:BelowRoomTemperature</a>
    /// </summary>
    let BelowRoomTemperature = _prefixId.prefix "BelowRoomTemperature"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing a wind speed of less than 1 m/s.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Calm">shw:Calm</a>
    /// </summary>
    let Calm = _prefixId.prefix "Calm"
    let CalmWeather = _prefixId.prefix "CalmWeather"
    let CivilTwilight = _prefixId.prefix "CivilTwilight"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing a cloud layer with cloud cover 0 (clear sky).
    ///
    /// NOTE: This class only specifies a single cloud layer. It does not make any statement about other cloud layers.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ClearSky">shw:ClearSky</a>
    /// </summary>
    let ClearSky = _prefixId.prefix "ClearSky"
    let ClearWeather = _prefixId.prefix "ClearWeather"
    let Cloud = _prefixId.prefix "Cloud"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon giving information about a cloud layer. There are two properties: hasCloudCover gives the cloud cover of this layer in okta (an integer in the interval [0-9] where 0 is clear sky, 8 is overcast and 9 is unknown). hasCloudAltitude gives the altitude of that cloud layer.
    ///
    /// If there is more than one cloud layer, for each cloud layer another WeatherPhenomenon must be created and linked to the appropriate WeatherState.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CloudCover">shw:CloudCover</a>
    /// </summary>
    let CloudCover = _prefixId.prefix "CloudCover"
    let CloudyWeather = _prefixId.prefix "CloudyWeather"
    let Cold = _prefixId.prefix "Cold"
    let ColdWeather = _prefixId.prefix "ColdWeather"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherState describing the current weather.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CurrentWeatherReport">shw:CurrentWeatherReport</a>
    /// </summary>
    let CurrentWeatherReport = _prefixId.prefix "CurrentWeatherReport"

    /// <summary>
    ///   <para>rdfs:comment : A WeatherState about the current weather based on data retrieved from a (collection of) sensor(s), e.g. it is connected to an instance of SensorSource via the hasSource property.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CurrentWeatherReportFromSensor">shw:CurrentWeatherReportFromSensor</a>
    /// </summary>
    let CurrentWeatherReportFromSensor =
        _prefixId.prefix "CurrentWeatherReportFromSensor"

    /// <summary>
    ///   <para>rdfs:comment : A WeatherState about the current weather based on data retrieved from an internet service, e.g. it is connected to an instance of ServiceSource via the hasSource property.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CurrentWeatherReportFromService">shw:CurrentWeatherReportFromService</a>
    /// </summary>
    let CurrentWeatherReportFromService =
        _prefixId.prefix "CurrentWeatherReportFromService"

    let CurrentWeatherState = _prefixId.prefix "CurrentWeatherState"
    let Day = _prefixId.prefix "Day"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon specifying the dew point. The actual value is specified in degrees Celsius using the hasDewPoint property.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#DewPoint">shw:DewPoint</a>
    /// </summary>
    let DewPoint = _prefixId.prefix "DewPoint"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#DirectionalWind">shw:DirectionalWind</a>
    /// </summary>
    let DirectionalWind = _prefixId.prefix "DirectionalWind"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing a humidity of less than 40 percent.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Dry">shw:Dry</a>
    /// </summary>
    let Dry = _prefixId.prefix "Dry"
    let DryWeather = _prefixId.prefix "DryWeather"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#EastWind">shw:EastWind</a>
    /// </summary>
    let EastWind = _prefixId.prefix "EastWind"
    let ExtremelyHeavyRain = _prefixId.prefix "ExtremelyHeavyRain"
    let FairWeather = _prefixId.prefix "FairWeather"
    let Fog = _prefixId.prefix "Fog"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherState describing the weather in 12 hours.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast12HoursWeatherReport">shw:Forecast12HoursWeatherReport</a>
    /// </summary>
    let Forecast12HoursWeatherReport = _prefixId.prefix "Forecast12HoursWeatherReport"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherState describing the weather in 15 hours.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast15HoursWeatherReport">shw:Forecast15HoursWeatherReport</a>
    /// </summary>
    let Forecast15HoursWeatherReport = _prefixId.prefix "Forecast15HoursWeatherReport"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherState describing the weather in 18 hours.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast18HoursWeatherReport">shw:Forecast18HoursWeatherReport</a>
    /// </summary>
    let Forecast18HoursWeatherReport = _prefixId.prefix "Forecast18HoursWeatherReport"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherState describing the weather in one hour.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast1HourWeatherReport">shw:Forecast1HourWeatherReport</a>
    /// </summary>
    let Forecast1HourWeatherReport = _prefixId.prefix "Forecast1HourWeatherReport"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherState describing the weather in 21 hours.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast21HoursWeatherReport">shw:Forecast21HoursWeatherReport</a>
    /// </summary>
    let Forecast21HoursWeatherReport = _prefixId.prefix "Forecast21HoursWeatherReport"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherState describing the weather in 21 hours.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast24HoursWeatherReport">shw:Forecast24HoursWeatherReport</a>
    /// </summary>
    let Forecast24HoursWeatherReport = _prefixId.prefix "Forecast24HoursWeatherReport"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherState describing the weather in two hours.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast2HoursWeatherReport">shw:Forecast2HoursWeatherReport</a>
    /// </summary>
    let Forecast2HoursWeatherReport = _prefixId.prefix "Forecast2HoursWeatherReport"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherState describing the weather in three hours.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast3HoursWeatherReport">shw:Forecast3HoursWeatherReport</a>
    /// </summary>
    let Forecast3HoursWeatherReport = _prefixId.prefix "Forecast3HoursWeatherReport"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherState describing the weather in 6 hours.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast6HoursWeatherReport">shw:Forecast6HoursWeatherReport</a>
    /// </summary>
    let Forecast6HoursWeatherReport = _prefixId.prefix "Forecast6HoursWeatherReport"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherState describing the weather in 9 hours.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast9HoursWeatherReport">shw:Forecast9HoursWeatherReport</a>
    /// </summary>
    let Forecast9HoursWeatherReport = _prefixId.prefix "Forecast9HoursWeatherReport"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherState describing the weather for some time in the future.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ForecastWeatherReport">shw:ForecastWeatherReport</a>
    /// </summary>
    let ForecastWeatherReport = _prefixId.prefix "ForecastWeatherReport"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing a temperature of less than 0 degrees Celsius.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Frost">shw:Frost</a>
    /// </summary>
    let Frost = _prefixId.prefix "Frost"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing a temperature of more than 30 degrees Celsius.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Heat">shw:Heat</a>
    /// </summary>
    let Heat = _prefixId.prefix "Heat"
    let HeavyRain = _prefixId.prefix "HeavyRain"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing an atmospheric pressure between 1018 hPa and 1028 hPa.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#HighPressure">shw:HighPressure</a>
    /// </summary>
    let HighPressure = _prefixId.prefix "HighPressure"
    let HighRadiation = _prefixId.prefix "HighRadiation"
    let HotWeather = _prefixId.prefix "HotWeather"
    /// <summary>
    ///   <para>rdfs:comment : This class describes a duration of hours.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Hour">shw:Hour</a>
    /// </summary>
    let Hour = _prefixId.prefix "Hour"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon specifying relative humidity. Relative umidity specified using the hasHumidity property (in the interval [0,1]).^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Humidity">shw:Humidity</a>
    /// </summary>
    let Humidity = _prefixId.prefix "Humidity"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing a wind speed of more than 32 m/s.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Hurricane">shw:Hurricane</a>
    /// </summary>
    let Hurricane = _prefixId.prefix "Hurricane"
    let LightCloud = _prefixId.prefix "LightCloud"
    let LightRain = _prefixId.prefix "LightRain"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing a wind speed of less than 1 m/s.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LightWind">shw:LightWind</a>
    /// </summary>
    let LightWind = _prefixId.prefix "LightWind"
    let LongRange = _prefixId.prefix "LongRange"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherState describing the weather for more than 12 hours in the future.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LongRangeForecastReport">shw:LongRangeForecastReport</a>
    /// </summary>
    let LongRangeForecastReport = _prefixId.prefix "LongRangeForecastReport"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing an atmospheric pressure between 998 hPa and 1008 hPa.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LowPressure">shw:LowPressure</a>
    /// </summary>
    let LowPressure = _prefixId.prefix "LowPressure"
    let LowRadiation = _prefixId.prefix "LowRadiation"
    let MediumRadiation = _prefixId.prefix "MediumRadiation"
    let MediumRain = _prefixId.prefix "MediumRain"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherState describing the weather for more than 3 and less than 12 hours in the future.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#MediumRangeForecastReport">shw:MediumRangeForecastReport</a>
    /// </summary>
    let MediumRangeForecastReport = _prefixId.prefix "MediumRangeForecastReport"
    let MidRange = _prefixId.prefix "MidRange"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing a humidity of more than 70 percent.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Moist">shw:Moist</a>
    /// </summary>
    let Moist = _prefixId.prefix "Moist"
    let MoistWeather = _prefixId.prefix "MoistWeather"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing a cloud layer with cloud cover 5, 6 or 7 (mostly cloudy).
    ///
    /// NOTE: This class only specifies a single cloud layer. It does not make any statement about other cloud layers.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#MostlyCloudy">shw:MostlyCloudy</a>
    /// </summary>
    let MostlyCloudy = _prefixId.prefix "MostlyCloudy"
    let NauticalTwilight = _prefixId.prefix "NauticalTwilight"
    let Night = _prefixId.prefix "Night"
    let NoAwningWeather = _prefixId.prefix "NoAwningWeather"
    let NoRadiation = _prefixId.prefix "NoRadiation"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing the absence of precipitation, either because the probability for precipitation is 0 (specified by the property hasPrecipitationProbability) or because the amount of precipitation per hour is 0 (specified by the property hasPrecipitationValue) or both.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NoRain">shw:NoRain</a>
    /// </summary>
    let NoRain = _prefixId.prefix "NoRain"
    let NoRainWeather = _prefixId.prefix "NoRainWeather"
    let NormalHumidity = _prefixId.prefix "NormalHumidity"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing an atmospheric pressure between 1008 hPa and 1018 hPa.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NormalPressure">shw:NormalPressure</a>
    /// </summary>
    let NormalPressure = _prefixId.prefix "NormalPressure"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NorthWind">shw:NorthWind</a>
    /// </summary>
    let NorthWind = _prefixId.prefix "NorthWind"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing a cloud layer with cloud cover 8 (overcast).
    ///
    /// NOTE: This class only specifies a single cloud layer. It does not make any statement about other cloud layers.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Overcast">shw:Overcast</a>
    /// </summary>
    let Overcast = _prefixId.prefix "Overcast"
    let PartlyCloud = _prefixId.prefix "PartlyCloud"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing a cloud layer with cloud cover 1, 2, 3 or 4 (partly cloudy).
    ///
    /// NOTE: This class only specifies a single cloud layer. It does not make any statement about other cloud layers.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#PartlyCloudy">shw:PartlyCloudy</a>
    /// </summary>
    let PartlyCloudy = _prefixId.prefix "PartlyCloudy"
    let PleasantTemperatureWeather = _prefixId.prefix "PleasantTemperatureWeather"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing both precipitation probability (property hasPrecipitationProbability, in the interval [0,1]) and the amount of precipitation (property hasPrecipitationValue, in mm/h).^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Precipitation">shw:Precipitation</a>
    /// </summary>
    let Precipitation = _prefixId.prefix "Precipitation"
    let Rain = _prefixId.prefix "Rain"
    let RainyWeather = _prefixId.prefix "RainyWeather"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing a temperature between 20 and 25 degrees Celsius.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#RoomTemperature">shw:RoomTemperature</a>
    /// </summary>
    let RoomTemperature = _prefixId.prefix "RoomTemperature"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherStateSource as a (collection of) sensor(s).^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SensorSource">shw:SensorSource</a>
    /// </summary>
    let SensorSource = _prefixId.prefix "SensorSource"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherStateSource as an internet service.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ServiceSource">shw:ServiceSource</a>
    /// </summary>
    let ServiceSource = _prefixId.prefix "ServiceSource"
    let SevereWeather = _prefixId.prefix "SevereWeather"
    let ShortRange = _prefixId.prefix "ShortRange"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherState describing the weather for more at most 3 hours in the future.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ShortRangeForecastReport">shw:ShortRangeForecastReport</a>
    /// </summary>
    let ShortRangeForecastReport = _prefixId.prefix "ShortRangeForecastReport"
    let Sleet = _prefixId.prefix "Sleet"
    let Snow = _prefixId.prefix "Snow"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing sun radiation using the hasSunRadiation property (in W/m²).^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SolarRadiation">shw:SolarRadiation</a>
    /// </summary>
    let SolarRadiation = _prefixId.prefix "SolarRadiation"
    let SolarTwilight = _prefixId.prefix "SolarTwilight"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SouthWind">shw:SouthWind</a>
    /// </summary>
    let SouthWind = _prefixId.prefix "SouthWind"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing a wind speed of more than 20 m/s.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Storm">shw:Storm</a>
    /// </summary>
    let Storm = _prefixId.prefix "Storm"
    let StormyWeather = _prefixId.prefix "StormyWeather"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing a wind speed of less than 1 m/s.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#StrongWind">shw:StrongWind</a>
    /// </summary>
    let StrongWind = _prefixId.prefix "StrongWind"
    let Sun = _prefixId.prefix "Sun"
    let SunBelowHorizon = _prefixId.prefix "SunBelowHorizon"
    let SunFromEast = _prefixId.prefix "SunFromEast"
    let SunFromNorth = _prefixId.prefix "SunFromNorth"
    let SunFromSouth = _prefixId.prefix "SunFromSouth"
    let SunFromWest = _prefixId.prefix "SunFromWest"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing the sun's position at solar noon. The property hasSunAngleNoon specifies the angle of the sun above horizon in degrees Celsius.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunPosition">shw:SunPosition</a>
    /// </summary>
    let SunPosition = _prefixId.prefix "SunPosition"
    let SunProtectionWeather = _prefixId.prefix "SunProtectionWeather"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon specifying temperature. The actual temperature is specified using the hasTemperature property (in degrees Celsius).^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Temperature">shw:Temperature</a>
    /// </summary>
    let Temperature = _prefixId.prefix "Temperature"
    let Thunder = _prefixId.prefix "Thunder"
    let Thunderstorm = _prefixId.prefix "Thunderstorm"
    let TropicalStormRain = _prefixId.prefix "TropicalStormRain"
    let Twilight = _prefixId.prefix "Twilight"
    /// <summary>
    ///   <para>rdfs:seeAlso : A WeatherPhenomenon describing a cloud layer with cloud cover 9 (unknown cloud cover).
    ///
    /// NOTE: This class only specifies a single cloud layer. It does not make any statement about other cloud layers.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#UnknownCloudCover">shw:UnknownCloudCover</a>
    /// </summary>
    let UnknownCloudCover = _prefixId.prefix "UnknownCloudCover"
    let VeryDry = _prefixId.prefix "VeryDry"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing an atmospheric pressure of more than 1028 hPa.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryHighPressure">shw:VeryHighPressure</a>
    /// </summary>
    let VeryHighPressure = _prefixId.prefix "VeryHighPressure"
    let VeryHighRadiation = _prefixId.prefix "VeryHighRadiation"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon describing an atmospheric pressure of less than 998 hPa.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryLowPressure">shw:VeryLowPressure</a>
    /// </summary>
    let VeryLowPressure = _prefixId.prefix "VeryLowPressure"
    let VeryMoist = _prefixId.prefix "VeryMoist"
    let VeryRainyWeather = _prefixId.prefix "VeryRainyWeather"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherCondition is a simple description of the state of the weather. Currently there are: Cloud, Fog, LightCloud, PartlyCloud, Rain, Sleet, Snow, Sun, Thunder.
    ///
    /// Several instances of WeatherCondition can be associated with the same instance of WeatherPhenomenon using the hasCondition property. That way, it is possible to describe a thunderstorm that comes with rain.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherCondition">shw:WeatherCondition</a>
    /// </summary>
    let WeatherCondition = _prefixId.prefix "WeatherCondition"
    let WeatherObservation = _prefixId.prefix "WeatherObservation"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon specifies information about the weather (temperature, humidity etc.) for a certain WeatherState. It is linked to the WeatherState using the belongsToState property.
    ///
    /// For specifying the weather information, there exist several data properties: hasTemperature, hasHumidity, hasDewPoint, hasWindSpeed, hasWindDirection, hasPrecipitationProbability, hasPrecipitationValue, hasPressure, hasCloudCover, hasCloudAltitude, hasSunRadiation and hasSunAngleNoon.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherPhenomenon">shw:WeatherPhenomenon</a>
    /// </summary>
    let WeatherPhenomenon = _prefixId.prefix "WeatherPhenomenon"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherObservation puts together all the information known at a certain time about both the current and the future weather at a certain location.
    ///
    /// Using the mandatory properties location a Point -- having latitude, longitude and altitude -- the location this WeatherObservation belongs to is specified. The property hasObservation time gives the time when the data has been collected.
    ///
    /// A WeatherObservation can have an arbitrary number of WeatherStates. Each of them gives some information about either the current state of the weather or the weather predicted for some time in the future.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherReport">shw:WeatherReport</a>
    /// </summary>
    let WeatherReport = _prefixId.prefix "WeatherReport"
    let WeatherReportFromSensor = _prefixId.prefix "WeatherReportFromSensor"
    let WeatherReportFromService = _prefixId.prefix "WeatherReportFromService"
    /// <summary>
    ///   <para>rdfs:comment : WeatherStateSource represents a source of weather data, either from a (collection of) sensor(s) (sub-concept SensorSource) or from an internet service (ServiceSource).
    ///
    /// WeatherStateSource is connected to WeatherState via the hasSource/isSourceOf properties.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherReportSource">shw:WeatherReportSource</a>
    /// </summary>
    let WeatherReportSource = _prefixId.prefix "WeatherReportSource"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherState is a set of weather information (temperature, humidity etc.). It is assigned to exactly one WeatherObservation (properties belongsToWeatherObservation/hasWeatherState), has a priority (property hasPriority) and has a source (where the weather information comes from, properties hasSource/isSourceOf).
    ///
    /// The weather information itself (temperature, humidity etc.) is provided using instances of WeatherPhenomenon that are connected using the belongsToState/hasWeatherPhenomenon properties.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherState">shw:WeatherState</a>
    /// </summary>
    let WeatherState = _prefixId.prefix "WeatherState"
    let WeatherStateFromSensor = _prefixId.prefix "WeatherStateFromSensor"
    let WeatherStateFromService = _prefixId.prefix "WeatherStateFromService"
    let WeatherStateSource = _prefixId.prefix "WeatherStateSource"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WestWind">shw:WestWind</a>
    /// </summary>
    let WestWind = _prefixId.prefix "WestWind"
    /// <summary>
    ///   <para>rdfs:comment : A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Wind">shw:Wind</a>
    /// </summary>
    let Wind = _prefixId.prefix "Wind"
    let WindyWeather = _prefixId.prefix "WindyWeather"
    let ZeroHour = _prefixId.prefix "ZeroHour"
    let belongsToState = _prefixId.prefix "belongsToState"
    let belongsToWeather = _prefixId.prefix "belongsToWeather"
    /// <summary>
    ///   <para>rdfs:comment : Inverse property of hasWeatherState.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#belongsToWeatherReport">shw:belongsToWeatherReport</a>
    /// </summary>
    let belongsToWeatherReport = _prefixId.prefix "belongsToWeatherReport"
    /// <summary>
    ///   <para>rdfs:comment : Inverse property of hasWeatherPhenomenon.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#belongsToWeatherState">shw:belongsToWeatherState</a>
    /// </summary>
    let belongsToWeatherState = _prefixId.prefix "belongsToWeatherState"
    let cloudCoverage = _prefixId.prefix "cloudCoverage"
    let hasCloudAltitude = _prefixId.prefix "hasCloudAltitude"
    let hasCloudCover = _prefixId.prefix "hasCloudCover"
    /// <summary>
    ///   <para>rdfs:comment : Links a WeatherCondition to a WeatherPhenomenon. A WeatherPhenomenon can be associated with an arbitrary number of instances of WeatherCondition.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasCondition">shw:hasCondition</a>
    /// </summary>
    let hasCondition = _prefixId.prefix "hasCondition"
    let hasDewPoint = _prefixId.prefix "hasDewPoint"
    let hasDewPointValue = _prefixId.prefix "hasDewPointValue"
    let hasEndTime = _prefixId.prefix "hasEndTime"
    let hasHumidity = _prefixId.prefix "hasHumidity"
    let hasHumidityValue = _prefixId.prefix "hasHumidityValue"
    let hasNextWeatherState = _prefixId.prefix "hasNextWeatherState"
    let hasObservationTime = _prefixId.prefix "hasObservationTime"
    let hasPrecipitationIntensity = _prefixId.prefix "hasPrecipitationIntensity"
    let hasPrecipitationProbability = _prefixId.prefix "hasPrecipitationProbability"
    let hasPrecipitationValue = _prefixId.prefix "hasPrecipitationValue"
    let hasPressure = _prefixId.prefix "hasPressure"
    let hasPressureValue = _prefixId.prefix "hasPressureValue"
    let hasPreviousWeatherState = _prefixId.prefix "hasPreviousWeatherState"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the priority of a WeatherState (a positive integer). The higher this value is compared to another WeatherState's priority, the more the WeatherState takes precedence over the other WeatherState.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPriority">shw:hasPriority</a>
    /// </summary>
    let hasPriority = _prefixId.prefix "hasPriority"
    let hasSolarRadiationValue = _prefixId.prefix "hasSolarRadiationValue"
    /// <summary>
    ///   <para>rdfs:comment : Associates a WeatherStateSource with a WeatherState, i.e. specifies where a WeatherState's data comes from. One WeatherState can only have one WeatherStateSource.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSource">shw:hasSource</a>
    /// </summary>
    let hasSource = _prefixId.prefix "hasSource"
    let hasStartTime = _prefixId.prefix "hasStartTime"
    let hasSunAngleNoon = _prefixId.prefix "hasSunAngleNoon"
    let hasSunDirection = _prefixId.prefix "hasSunDirection"
    let hasSunElevationAngle = _prefixId.prefix "hasSunElevationAngle"
    let hasSunRadiation = _prefixId.prefix "hasSunRadiation"
    let hasTemperature = _prefixId.prefix "hasTemperature"
    let hasTemperatureValue = _prefixId.prefix "hasTemperatureValue"
    let hasTemporalEntity = _prefixId.prefix "hasTemporalEntity"
    let hasTime = _prefixId.prefix "hasTime"
    /// <summary>
    ///   <para>rdfs:comment : Associates a WeatherPhenomenon to its WeatherState. One WeatherPhenomenon can only belong to one WeatherState, but one WeatherState can have an arbitrary number of instances of WeatherPhenomenon.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasWeatherPhenomenon">shw:hasWeatherPhenomenon</a>
    /// </summary>
    let hasWeatherPhenomenon = _prefixId.prefix "hasWeatherPhenomenon"
    /// <summary>
    ///   <para>rdfs:comment : Associates a WeatherState to a WeatherObservation. One WeatherState can only be associated with one WeatherObservation.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasWeatherState">shw:hasWeatherState</a>
    /// </summary>
    let hasWeatherState = _prefixId.prefix "hasWeatherState"
    let hasWindDirection = _prefixId.prefix "hasWindDirection"
    let hasWindSpeed = _prefixId.prefix "hasWindSpeed"
    let hectopascal = _prefixId.prefix "hectopascal"
    let irradiance = _prefixId.prefix "irradiance"
    /// <summary>
    ///   <para>rdfs:comment : Inverse property of hasSource.^^xsd:string</para>
    ///   <a href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#isSourceOf">shw:isSourceOf</a>
    /// </summary>
    let isSourceOf = _prefixId.prefix "isSourceOf"
    let metresPerSecond = _prefixId.prefix "metresPerSecond"
    let millimeter = _prefixId.prefix "millimeter"
    let millimetresPerHour = _prefixId.prefix "millimetresPerHour"
    let okta = _prefixId.prefix "okta"
    let precipitationIntensity = _prefixId.prefix "precipitationIntensity"
    let speed = _prefixId.prefix "speed"
    let squareMeter = _prefixId.prefix "squareMeter"
    let sunAngleNoon = _prefixId.prefix "sunAngleNoon"
    let wattsPerSquareMeter = _prefixId.prefix "wattsPerSquareMeter"
