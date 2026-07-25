namespace http.paul.staroch.name.thesis.SmartHomeWeather.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module shw =
    let _namespace_iri = Namespace_Iri shw |> NamespaceIRI
    /// <summary>
    ///   <para>shw:WeatherCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherCondition is a simple description of the state of the weather. Currently there are: Cloud, Fog, LightCloud, PartlyCloud, Rain, Sleet, Snow, Sun, Thunder.
    ///
    /// Several instances of WeatherCondition can be associated with the same instance of WeatherPhenomenon using the hasCondition property. That way, it is possible to describe a thunderstorm that comes with rain.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherCondition">http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherCondition</seealso>
    let WeatherCondition = Prefixed_Name(shw, "WeatherCondition") |> PrefixedName
    /// <summary>
    ///   <para>shw:WeatherState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherState is a set of weather information (temperature, humidity etc.). It is assigned to exactly one WeatherObservation (properties belongsToWeatherObservation/hasWeatherState), has a priority (property hasPriority) and has a source (where the weather information comes from, properties hasSource/isSourceOf).
    ///
    /// The weather information itself (temperature, humidity etc.) is provided using instances of WeatherPhenomenon that are connected using the belongsToState/hasWeatherPhenomenon properties.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherState">http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherState</seealso>
    let WeatherState = Prefixed_Name(shw, "WeatherState") |> PrefixedName
    /// <summary>
    ///   <para>shw:Humidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon specifying relative humidity. Relative umidity specified using the hasHumidity property (in the interval [0,1]).</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Humidity">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Humidity</seealso>
    let Humidity = Prefixed_Name(shw, "Humidity") |> PrefixedName
    /// <summary>
    ///   <para>shw:SunPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing the sun's position at solar noon. The property hasSunAngleNoon specifies the angle of the sun above horizon in degrees Celsius.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunPosition">http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunPosition</seealso>
    let SunPosition = Prefixed_Name(shw, "SunPosition") |> PrefixedName
    /// <summary>
    ///   <para>shw:Wind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Wind">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Wind</seealso>
    let Wind = Prefixed_Name(shw, "Wind") |> PrefixedName

    /// <summary>
    ///   <para>shw:Forecast18HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherState describing the weather in 18 hours.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast18HoursWeatherReport">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast18HoursWeatherReport</seealso>
    let Forecast18HoursWeatherReport =
        Prefixed_Name(shw, "Forecast18HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>shw:Forecast2HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherState describing the weather in two hours.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast2HoursWeatherReport">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast2HoursWeatherReport</seealso>
    let Forecast2HoursWeatherReport =
        Prefixed_Name(shw, "Forecast2HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>shw:hasSunDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSunDirection">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSunDirection</seealso>
    let hasSunDirection = Prefixed_Name(shw, "hasSunDirection") |> PrefixedName

    /// <summary>
    ///   <para>shw:hasSunElevationAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSunElevationAngle">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSunElevationAngle</seealso>
    let hasSunElevationAngle =
        Prefixed_Name(shw, "hasSunElevationAngle") |> PrefixedName

    /// <summary>
    ///   <para>shw:hasPressure</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPressure">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPressure</seealso>
    let hasPressure = Prefixed_Name(shw, "hasPressure") |> PrefixedName
    /// <summary>
    ///   <para>shw:hectopascal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>muo:SimpleDerivedUnit</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hectopascal">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hectopascal</seealso>
    let hectopascal = Prefixed_Name(shw, "hectopascal") |> PrefixedName
    /// <summary>
    ///   <para>shw:hasPressureValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPressureValue">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPressureValue</seealso>
    let hasPressureValue = Prefixed_Name(shw, "hasPressureValue") |> PrefixedName
    /// <summary>
    ///   <para>shw:WeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherObservation puts together all the information known at a certain time about both the current and the future weather at a certain location.
    ///
    /// Using the mandatory properties location a Point -- having latitude, longitude and altitude -- the location this WeatherObservation belongs to is specified. The property hasObservation time gives the time when the data has been collected.
    ///
    /// A WeatherObservation can have an arbitrary number of WeatherStates. Each of them gives some information about either the current state of the weather or the weather predicted for some time in the future.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherReport">http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherReport</seealso>
    let WeatherReport = Prefixed_Name(shw, "WeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>shw:BelowRoomTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing a temperature of less than 20 degrees Celsius.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#BelowRoomTemperature">http://paul.staroch.name/thesis/SmartHomeWeather.owl#BelowRoomTemperature</seealso>
    let BelowRoomTemperature =
        Prefixed_Name(shw, "BelowRoomTemperature") |> PrefixedName

    /// <summary>
    ///   <para>shw:squareMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>muo:SimpleDerivedUnit</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#squareMeter">http://paul.staroch.name/thesis/SmartHomeWeather.owl#squareMeter</seealso>
    let squareMeter = Prefixed_Name(shw, "squareMeter") |> PrefixedName
    /// <summary>
    ///   <para>shw:Snow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>shw:WeatherCondition</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Snow">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Snow</seealso>
    let Snow = Prefixed_Name(shw, "Snow") |> PrefixedName
    /// <summary>
    ///   <para>shw:Sun</para>
    /// </summary>
    /// <remarks>
    ///   <para>shw:WeatherCondition</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Sun">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Sun</seealso>
    let Sun = Prefixed_Name(shw, "Sun") |> PrefixedName
    /// <summary>
    ///   <para>shw:Thunder</para>
    /// </summary>
    /// <remarks>
    ///   <para>shw:WeatherCondition</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Thunder">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Thunder</seealso>
    let Thunder = Prefixed_Name(shw, "Thunder") |> PrefixedName
    /// <summary>
    ///   <para>shw:hasCloudAltitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasCloudAltitude">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasCloudAltitude</seealso>
    let hasCloudAltitude = Prefixed_Name(shw, "hasCloudAltitude") |> PrefixedName
    /// <summary>
    ///   <para>shw:okta</para>
    /// </summary>
    /// <remarks>
    ///   <para>muo:UnitOfMeasurement</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#okta">http://paul.staroch.name/thesis/SmartHomeWeather.owl#okta</seealso>
    let okta = Prefixed_Name(shw, "okta") |> PrefixedName
    /// <summary>
    ///   <para>shw:HighRadiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#HighRadiation">http://paul.staroch.name/thesis/SmartHomeWeather.owl#HighRadiation</seealso>
    let HighRadiation = Prefixed_Name(shw, "HighRadiation") |> PrefixedName
    /// <summary>
    ///   <para>shw:wattsPerSquareMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>muo:ComplexDerivedUnit</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#wattsPerSquareMeter">http://paul.staroch.name/thesis/SmartHomeWeather.owl#wattsPerSquareMeter</seealso>
    let wattsPerSquareMeter = Prefixed_Name(shw, "wattsPerSquareMeter") |> PrefixedName

    /// <summary>
    ///   <para>shw:hasSolarRadiationValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSolarRadiationValue">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSolarRadiationValue</seealso>
    let hasSolarRadiationValue =
        Prefixed_Name(shw, "hasSolarRadiationValue") |> PrefixedName

    /// <summary>
    ///   <para>shw:HotWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#HotWeather">http://paul.staroch.name/thesis/SmartHomeWeather.owl#HotWeather</seealso>
    let HotWeather = Prefixed_Name(shw, "HotWeather") |> PrefixedName
    /// <summary>
    ///   <para>shw:Hour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes a duration of hours.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Hour">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Hour</seealso>
    let Hour = Prefixed_Name(shw, "Hour") |> PrefixedName
    /// <summary>
    ///   <para>shw:CloudCover</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon giving information about a cloud layer. There are two properties: hasCloudCover gives the cloud cover of this layer in okta (an integer in the interval [0-9] where 0 is clear sky, 8 is overcast and 9 is unknown). hasCloudAltitude gives the altitude of that cloud layer.
    ///
    /// If there is more than one cloud layer, for each cloud layer another WeatherPhenomenon must be created and linked to the appropriate WeatherState.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CloudCover">http://paul.staroch.name/thesis/SmartHomeWeather.owl#CloudCover</seealso>
    let CloudCover = Prefixed_Name(shw, "CloudCover") |> PrefixedName
    /// <summary>
    ///   <para>shw:hasTemperature</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasTemperature">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasTemperature</seealso>
    let hasTemperature = Prefixed_Name(shw, "hasTemperature") |> PrefixedName
    /// <summary>
    ///   <para>shw:hasTemperatureValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasTemperatureValue">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasTemperatureValue</seealso>
    let hasTemperatureValue = Prefixed_Name(shw, "hasTemperatureValue") |> PrefixedName
    /// <summary>
    ///   <para>shw:AiringWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#AiringWeather">http://paul.staroch.name/thesis/SmartHomeWeather.owl#AiringWeather</seealso>
    let AiringWeather = Prefixed_Name(shw, "AiringWeather") |> PrefixedName
    /// <summary>
    ///   <para>shw:FairWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#FairWeather">http://paul.staroch.name/thesis/SmartHomeWeather.owl#FairWeather</seealso>
    let FairWeather = Prefixed_Name(shw, "FairWeather") |> PrefixedName

    /// <summary>
    ///   <para>shw:WeatherReportFromService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherReportFromService">http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherReportFromService</seealso>
    let WeatherReportFromService =
        Prefixed_Name(shw, "WeatherReportFromService") |> PrefixedName

    /// <summary>
    ///   <para>shw:Day</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Day">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Day</seealso>
    let Day = Prefixed_Name(shw, "Day") |> PrefixedName
    /// <summary>
    ///   <para>shw:Hurricane</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing a wind speed of more than 32 m/s.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Hurricane">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Hurricane</seealso>
    let Hurricane = Prefixed_Name(shw, "Hurricane") |> PrefixedName
    /// <summary>
    ///   <para>shw:SolarRadiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing sun radiation using the hasSunRadiation property (in W/m²).</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SolarRadiation">http://paul.staroch.name/thesis/SmartHomeWeather.owl#SolarRadiation</seealso>
    let SolarRadiation = Prefixed_Name(shw, "SolarRadiation") |> PrefixedName
    /// <summary>
    ///   <para>shw:Temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon specifying temperature. The actual temperature is specified using the hasTemperature property (in degrees Celsius).</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Temperature">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Temperature</seealso>
    let Temperature = Prefixed_Name(shw, "Temperature") |> PrefixedName

    /// <summary>
    ///   <para>shw:Forecast24HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherState describing the weather in 21 hours.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast24HoursWeatherReport">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast24HoursWeatherReport</seealso>
    let Forecast24HoursWeatherReport =
        Prefixed_Name(shw, "Forecast24HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>shw:Forecast3HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherState describing the weather in three hours.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast3HoursWeatherReport">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast3HoursWeatherReport</seealso>
    let Forecast3HoursWeatherReport =
        Prefixed_Name(shw, "Forecast3HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>shw:Rain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>shw:WeatherCondition</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Rain">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Rain</seealso>
    let Rain = Prefixed_Name(shw, "Rain") |> PrefixedName
    /// <summary>
    ///   <para>shw:ClearSky</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing a cloud layer with cloud cover 0 (clear sky).
    ///
    /// NOTE: This class only specifies a single cloud layer. It does not make any statement about other cloud layers.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ClearSky">http://paul.staroch.name/thesis/SmartHomeWeather.owl#ClearSky</seealso>
    let ClearSky = Prefixed_Name(shw, "ClearSky") |> PrefixedName
    /// <summary>
    ///   <para>shw:hasCloudCover</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasCloudCover">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasCloudCover</seealso>
    let hasCloudCover = Prefixed_Name(shw, "hasCloudCover") |> PrefixedName
    /// <summary>
    ///   <para>shw:ClearWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ClearWeather">http://paul.staroch.name/thesis/SmartHomeWeather.owl#ClearWeather</seealso>
    let ClearWeather = Prefixed_Name(shw, "ClearWeather") |> PrefixedName
    /// <summary>
    ///   <para>shw:PartlyCloudy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing a cloud layer with cloud cover 1, 2, 3 or 4 (partly cloudy).
    ///
    /// NOTE: This class only specifies a single cloud layer. It does not make any statement about other cloud layers.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#PartlyCloudy">http://paul.staroch.name/thesis/SmartHomeWeather.owl#PartlyCloudy</seealso>
    let PartlyCloudy = Prefixed_Name(shw, "PartlyCloudy") |> PrefixedName
    /// <summary>
    ///   <para>shw:HighPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing an atmospheric pressure between 1018 hPa and 1028 hPa.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#HighPressure">http://paul.staroch.name/thesis/SmartHomeWeather.owl#HighPressure</seealso>
    let HighPressure = Prefixed_Name(shw, "HighPressure") |> PrefixedName
    /// <summary>
    ///   <para>shw:StrongWind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing a wind speed of less than 1 m/s.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#StrongWind">http://paul.staroch.name/thesis/SmartHomeWeather.owl#StrongWind</seealso>
    let StrongWind = Prefixed_Name(shw, "StrongWind") |> PrefixedName
    /// <summary>
    ///   <para>shw:NoRadiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NoRadiation">http://paul.staroch.name/thesis/SmartHomeWeather.owl#NoRadiation</seealso>
    let NoRadiation = Prefixed_Name(shw, "NoRadiation") |> PrefixedName
    /// <summary>
    ///   <para>shw:hasObservationTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasObservationTime">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasObservationTime</seealso>
    let hasObservationTime = Prefixed_Name(shw, "hasObservationTime") |> PrefixedName
    /// <summary>
    ///   <para>shw:hasPriority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the priority of a WeatherState (a positive integer). The higher this value is compared to another WeatherState's priority, the more the WeatherState takes precedence over the other WeatherState.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPriority">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPriority</seealso>
    let hasPriority = Prefixed_Name(shw, "hasPriority") |> PrefixedName

    /// <summary>
    ///   <para>shw:Forecast12HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherState describing the weather in 12 hours.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast12HoursWeatherReport">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast12HoursWeatherReport</seealso>
    let Forecast12HoursWeatherReport =
        Prefixed_Name(shw, "Forecast12HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>shw:Forecast21HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherState describing the weather in 21 hours.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast21HoursWeatherReport">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast21HoursWeatherReport</seealso>
    let Forecast21HoursWeatherReport =
        Prefixed_Name(shw, "Forecast21HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>shw:Forecast9HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherState describing the weather in 9 hours.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast9HoursWeatherReport">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast9HoursWeatherReport</seealso>
    let Forecast9HoursWeatherReport =
        Prefixed_Name(shw, "Forecast9HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>shw:PartlyCloud</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>shw:WeatherCondition</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#PartlyCloud">http://paul.staroch.name/thesis/SmartHomeWeather.owl#PartlyCloud</seealso>
    let PartlyCloud = Prefixed_Name(shw, "PartlyCloud") |> PrefixedName
    /// <summary>
    ///   <para>shw:LightWind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing a wind speed of less than 1 m/s.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LightWind">http://paul.staroch.name/thesis/SmartHomeWeather.owl#LightWind</seealso>
    let LightWind = Prefixed_Name(shw, "LightWind") |> PrefixedName
    /// <summary>
    ///   <para>shw:Heat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing a temperature of more than 30 degrees Celsius.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Heat">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Heat</seealso>
    let Heat = Prefixed_Name(shw, "Heat") |> PrefixedName
    /// <summary>
    ///   <para>shw:HeavyRain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#HeavyRain">http://paul.staroch.name/thesis/SmartHomeWeather.owl#HeavyRain</seealso>
    let HeavyRain = Prefixed_Name(shw, "HeavyRain") |> PrefixedName
    /// <summary>
    ///   <para>shw:sunAngleNoon</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#sunAngleNoon">http://paul.staroch.name/thesis/SmartHomeWeather.owl#sunAngleNoon</seealso>
    let sunAngleNoon = Prefixed_Name(shw, "sunAngleNoon") |> PrefixedName
    /// <summary>
    ///   <para>shw:belongsToState</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#belongsToState">http://paul.staroch.name/thesis/SmartHomeWeather.owl#belongsToState</seealso>
    let belongsToState = Prefixed_Name(shw, "belongsToState") |> PrefixedName
    /// <summary>
    ///   <para>shw:belongsToWeather</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#belongsToWeather">http://paul.staroch.name/thesis/SmartHomeWeather.owl#belongsToWeather</seealso>
    let belongsToWeather = Prefixed_Name(shw, "belongsToWeather") |> PrefixedName
    /// <summary>
    ///   <para>shw:hasWeatherState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Associates a WeatherState to a WeatherObservation. One WeatherState can only be associated with one WeatherObservation.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasWeatherState">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasWeatherState</seealso>
    let hasWeatherState = Prefixed_Name(shw, "hasWeatherState") |> PrefixedName
    /// <summary>
    ///   <para>shw:Cloud</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>shw:WeatherCondition</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Cloud">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Cloud</seealso>
    let Cloud = Prefixed_Name(shw, "Cloud") |> PrefixedName
    /// <summary>
    ///   <para>shw:metresPerSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>muo:ComplexDerivedUnit</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#metresPerSecond">http://paul.staroch.name/thesis/SmartHomeWeather.owl#metresPerSecond</seealso>
    let metresPerSecond = Prefixed_Name(shw, "metresPerSecond") |> PrefixedName
    /// <summary>
    ///   <para>shw:LightCloud</para>
    /// </summary>
    /// <remarks>
    ///   <para>shw:WeatherCondition</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LightCloud">http://paul.staroch.name/thesis/SmartHomeWeather.owl#LightCloud</seealso>
    let LightCloud = Prefixed_Name(shw, "LightCloud") |> PrefixedName
    /// <summary>
    ///   <para>shw:VeryMoist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryMoist">http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryMoist</seealso>
    let VeryMoist = Prefixed_Name(shw, "VeryMoist") |> PrefixedName
    /// <summary>
    ///   <para>shw:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#">http://paul.staroch.name/thesis/SmartHomeWeather.owl#</seealso>
    let _prefix_iri = Prefixed_Name(shw, "") |> PrefixedName

    /// <summary>
    ///   <para>shw:AboveRoomTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing a temperature of more than 25 degrees Celsius.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#AboveRoomTemperature">http://paul.staroch.name/thesis/SmartHomeWeather.owl#AboveRoomTemperature</seealso>
    let AboveRoomTemperature =
        Prefixed_Name(shw, "AboveRoomTemperature") |> PrefixedName

    /// <summary>
    ///   <para>shw:CloudyWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CloudyWeather">http://paul.staroch.name/thesis/SmartHomeWeather.owl#CloudyWeather</seealso>
    let CloudyWeather = Prefixed_Name(shw, "CloudyWeather") |> PrefixedName
    /// <summary>
    ///   <para>shw:Overcast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing a cloud layer with cloud cover 8 (overcast).
    ///
    /// NOTE: This class only specifies a single cloud layer. It does not make any statement about other cloud layers.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Overcast">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Overcast</seealso>
    let Overcast = Prefixed_Name(shw, "Overcast") |> PrefixedName
    /// <summary>
    ///   <para>shw:ColdWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ColdWeather">http://paul.staroch.name/thesis/SmartHomeWeather.owl#ColdWeather</seealso>
    let ColdWeather = Prefixed_Name(shw, "ColdWeather") |> PrefixedName
    /// <summary>
    ///   <para>shw:Frost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing a temperature of less than 0 degrees Celsius.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Frost">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Frost</seealso>
    let Frost = Prefixed_Name(shw, "Frost") |> PrefixedName

    /// <summary>
    ///   <para>shw:CurrentWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherState describing the current weather.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CurrentWeatherReport">http://paul.staroch.name/thesis/SmartHomeWeather.owl#CurrentWeatherReport</seealso>
    let CurrentWeatherReport =
        Prefixed_Name(shw, "CurrentWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>shw:hasTime</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasTime">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasTime</seealso>
    let hasTime = Prefixed_Name(shw, "hasTime") |> PrefixedName
    /// <summary>
    ///   <para>shw:ZeroHour</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ZeroHour">http://paul.staroch.name/thesis/SmartHomeWeather.owl#ZeroHour</seealso>
    let ZeroHour = Prefixed_Name(shw, "ZeroHour") |> PrefixedName

    /// <summary>
    ///   <para>shw:ForecastWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherState describing the weather for some time in the future.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ForecastWeatherReport">http://paul.staroch.name/thesis/SmartHomeWeather.owl#ForecastWeatherReport</seealso>
    let ForecastWeatherReport =
        Prefixed_Name(shw, "ForecastWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>shw:CurrentWeatherReportFromSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherState about the current weather based on data retrieved from a (collection of) sensor(s), e.g. it is connected to an instance of SensorSource via the hasSource property.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CurrentWeatherReportFromSensor">http://paul.staroch.name/thesis/SmartHomeWeather.owl#CurrentWeatherReportFromSensor</seealso>
    let CurrentWeatherReportFromSensor =
        Prefixed_Name(shw, "CurrentWeatherReportFromSensor") |> PrefixedName

    /// <summary>
    ///   <para>shw:WeatherStateFromSensor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherStateFromSensor">http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherStateFromSensor</seealso>
    let WeatherStateFromSensor =
        Prefixed_Name(shw, "WeatherStateFromSensor") |> PrefixedName

    /// <summary>
    ///   <para>shw:CurrentWeatherReportFromService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherState about the current weather based on data retrieved from an internet service, e.g. it is connected to an instance of ServiceSource via the hasSource property.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CurrentWeatherReportFromService">http://paul.staroch.name/thesis/SmartHomeWeather.owl#CurrentWeatherReportFromService</seealso>
    let CurrentWeatherReportFromService =
        Prefixed_Name(shw, "CurrentWeatherReportFromService") |> PrefixedName

    /// <summary>
    ///   <para>shw:WeatherStateFromService</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherStateFromService">http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherStateFromService</seealso>
    let WeatherStateFromService =
        Prefixed_Name(shw, "WeatherStateFromService") |> PrefixedName

    /// <summary>
    ///   <para>shw:hasDewPoint</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasDewPoint">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasDewPoint</seealso>
    let hasDewPoint = Prefixed_Name(shw, "hasDewPoint") |> PrefixedName
    /// <summary>
    ///   <para>shw:DirectionalWind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#DirectionalWind">http://paul.staroch.name/thesis/SmartHomeWeather.owl#DirectionalWind</seealso>
    let DirectionalWind = Prefixed_Name(shw, "DirectionalWind") |> PrefixedName

    /// <summary>
    ///   <para>shw:belongsToWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of hasWeatherState.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#belongsToWeatherReport">http://paul.staroch.name/thesis/SmartHomeWeather.owl#belongsToWeatherReport</seealso>
    let belongsToWeatherReport =
        Prefixed_Name(shw, "belongsToWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>shw:belongsToWeatherState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of hasWeatherPhenomenon.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#belongsToWeatherState">http://paul.staroch.name/thesis/SmartHomeWeather.owl#belongsToWeatherState</seealso>
    let belongsToWeatherState =
        Prefixed_Name(shw, "belongsToWeatherState") |> PrefixedName

    /// <summary>
    ///   <para>shw:cloudCoverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>muo:PhysicalQuality</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#cloudCoverage">http://paul.staroch.name/thesis/SmartHomeWeather.owl#cloudCoverage</seealso>
    let cloudCoverage = Prefixed_Name(shw, "cloudCoverage") |> PrefixedName
    /// <summary>
    ///   <para>shw:MostlyCloudy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing a cloud layer with cloud cover 5, 6 or 7 (mostly cloudy).
    ///
    /// NOTE: This class only specifies a single cloud layer. It does not make any statement about other cloud layers.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#MostlyCloudy">http://paul.staroch.name/thesis/SmartHomeWeather.owl#MostlyCloudy</seealso>
    let MostlyCloudy = Prefixed_Name(shw, "MostlyCloudy") |> PrefixedName
    /// <summary>
    ///   <para>shw:Cold</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Cold">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Cold</seealso>
    let Cold = Prefixed_Name(shw, "Cold") |> PrefixedName
    /// <summary>
    ///   <para>shw:hasEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasEndTime">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasEndTime</seealso>
    let hasEndTime = Prefixed_Name(shw, "hasEndTime") |> PrefixedName
    /// <summary>
    ///   <para>shw:isSourceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of hasSource.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#isSourceOf">http://paul.staroch.name/thesis/SmartHomeWeather.owl#isSourceOf</seealso>
    let isSourceOf = Prefixed_Name(shw, "isSourceOf") |> PrefixedName
    /// <summary>
    ///   <para>shw:hasTemporalEntity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasTemporalEntity">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasTemporalEntity</seealso>
    let hasTemporalEntity = Prefixed_Name(shw, "hasTemporalEntity") |> PrefixedName
    /// <summary>
    ///   <para>shw:WeatherObservation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherObservation">http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherObservation</seealso>
    let WeatherObservation = Prefixed_Name(shw, "WeatherObservation") |> PrefixedName
    /// <summary>
    ///   <para>shw:hasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Associates a WeatherStateSource with a WeatherState, i.e. specifies where a WeatherState's data comes from. One WeatherState can only have one WeatherStateSource.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSource">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSource</seealso>
    let hasSource = Prefixed_Name(shw, "hasSource") |> PrefixedName
    /// <summary>
    ///   <para>shw:hasStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasStartTime">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasStartTime</seealso>
    let hasStartTime = Prefixed_Name(shw, "hasStartTime") |> PrefixedName
    /// <summary>
    ///   <para>shw:CurrentWeatherState</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CurrentWeatherState">http://paul.staroch.name/thesis/SmartHomeWeather.owl#CurrentWeatherState</seealso>
    let CurrentWeatherState = Prefixed_Name(shw, "CurrentWeatherState") |> PrefixedName

    /// <summary>
    ///   <para>shw:WeatherReportFromSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherReportFromSensor">http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherReportFromSensor</seealso>
    let WeatherReportFromSensor =
        Prefixed_Name(shw, "WeatherReportFromSensor") |> PrefixedName

    /// <summary>
    ///   <para>shw:WestWind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WestWind">http://paul.staroch.name/thesis/SmartHomeWeather.owl#WestWind</seealso>
    let WestWind = Prefixed_Name(shw, "WestWind") |> PrefixedName
    /// <summary>
    ///   <para>shw:WindyWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WindyWeather">http://paul.staroch.name/thesis/SmartHomeWeather.owl#WindyWeather</seealso>
    let WindyWeather = Prefixed_Name(shw, "WindyWeather") |> PrefixedName

    /// <summary>
    ///   <para>shw:PleasantTemperatureWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#PleasantTemperatureWeather">http://paul.staroch.name/thesis/SmartHomeWeather.owl#PleasantTemperatureWeather</seealso>
    let PleasantTemperatureWeather =
        Prefixed_Name(shw, "PleasantTemperatureWeather") |> PrefixedName

    /// <summary>
    ///   <para>shw:hasDewPointValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasDewPointValue">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasDewPointValue</seealso>
    let hasDewPointValue = Prefixed_Name(shw, "hasDewPointValue") |> PrefixedName
    /// <summary>
    ///   <para>shw:Dry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing a humidity of less than 40 percent.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Dry">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Dry</seealso>
    let Dry = Prefixed_Name(shw, "Dry") |> PrefixedName
    /// <summary>
    ///   <para>shw:hasHumidity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasHumidity">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasHumidity</seealso>
    let hasHumidity = Prefixed_Name(shw, "hasHumidity") |> PrefixedName
    /// <summary>
    ///   <para>shw:hasHumidityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasHumidityValue">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasHumidityValue</seealso>
    let hasHumidityValue = Prefixed_Name(shw, "hasHumidityValue") |> PrefixedName
    /// <summary>
    ///   <para>shw:DryWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#DryWeather">http://paul.staroch.name/thesis/SmartHomeWeather.owl#DryWeather</seealso>
    let DryWeather = Prefixed_Name(shw, "DryWeather") |> PrefixedName
    /// <summary>
    ///   <para>shw:VeryDry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryDry">http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryDry</seealso>
    let VeryDry = Prefixed_Name(shw, "VeryDry") |> PrefixedName
    /// <summary>
    ///   <para>shw:LongRange</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LongRange">http://paul.staroch.name/thesis/SmartHomeWeather.owl#LongRange</seealso>
    let LongRange = Prefixed_Name(shw, "LongRange") |> PrefixedName
    /// <summary>
    ///   <para>shw:hasNextWeatherState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasNextWeatherState">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasNextWeatherState</seealso>
    let hasNextWeatherState = Prefixed_Name(shw, "hasNextWeatherState") |> PrefixedName

    /// <summary>
    ///   <para>shw:AstronomicalTwilight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#AstronomicalTwilight">http://paul.staroch.name/thesis/SmartHomeWeather.owl#AstronomicalTwilight</seealso>
    let AstronomicalTwilight =
        Prefixed_Name(shw, "AstronomicalTwilight") |> PrefixedName

    /// <summary>
    ///   <para>shw:LightRain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LightRain">http://paul.staroch.name/thesis/SmartHomeWeather.owl#LightRain</seealso>
    let LightRain = Prefixed_Name(shw, "LightRain") |> PrefixedName
    /// <summary>
    ///   <para>shw:EastWind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#EastWind">http://paul.staroch.name/thesis/SmartHomeWeather.owl#EastWind</seealso>
    let EastWind = Prefixed_Name(shw, "EastWind") |> PrefixedName
    /// <summary>
    ///   <para>shw:LowRadiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LowRadiation">http://paul.staroch.name/thesis/SmartHomeWeather.owl#LowRadiation</seealso>
    let LowRadiation = Prefixed_Name(shw, "LowRadiation") |> PrefixedName

    /// <summary>
    ///   <para>shw:hasPreviousWeatherState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPreviousWeatherState">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPreviousWeatherState</seealso>
    let hasPreviousWeatherState =
        Prefixed_Name(shw, "hasPreviousWeatherState") |> PrefixedName

    /// <summary>
    ///   <para>shw:LowPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing an atmospheric pressure between 998 hPa and 1008 hPa.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LowPressure">http://paul.staroch.name/thesis/SmartHomeWeather.owl#LowPressure</seealso>
    let LowPressure = Prefixed_Name(shw, "LowPressure") |> PrefixedName

    /// <summary>
    ///   <para>shw:LongRangeForecastReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherState describing the weather for more than 12 hours in the future.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#LongRangeForecastReport">http://paul.staroch.name/thesis/SmartHomeWeather.owl#LongRangeForecastReport</seealso>
    let LongRangeForecastReport =
        Prefixed_Name(shw, "LongRangeForecastReport") |> PrefixedName

    /// <summary>
    ///   <para>shw:ExtremelyHeavyRain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ExtremelyHeavyRain">http://paul.staroch.name/thesis/SmartHomeWeather.owl#ExtremelyHeavyRain</seealso>
    let ExtremelyHeavyRain = Prefixed_Name(shw, "ExtremelyHeavyRain") |> PrefixedName
    /// <summary>
    ///   <para>shw:millimetresPerHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>muo:ComplexDerivedUnit</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#millimetresPerHour">http://paul.staroch.name/thesis/SmartHomeWeather.owl#millimetresPerHour</seealso>
    let millimetresPerHour = Prefixed_Name(shw, "millimetresPerHour") |> PrefixedName
    /// <summary>
    ///   <para>shw:hasSunRadiation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSunRadiation">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSunRadiation</seealso>
    let hasSunRadiation = Prefixed_Name(shw, "hasSunRadiation") |> PrefixedName

    /// <summary>
    ///   <para>shw:hasPrecipitationIntensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPrecipitationIntensity">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPrecipitationIntensity</seealso>
    let hasPrecipitationIntensity =
        Prefixed_Name(shw, "hasPrecipitationIntensity") |> PrefixedName

    /// <summary>
    ///   <para>shw:MediumRadiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#MediumRadiation">http://paul.staroch.name/thesis/SmartHomeWeather.owl#MediumRadiation</seealso>
    let MediumRadiation = Prefixed_Name(shw, "MediumRadiation") |> PrefixedName
    /// <summary>
    ///   <para>shw:MediumRain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#MediumRain">http://paul.staroch.name/thesis/SmartHomeWeather.owl#MediumRain</seealso>
    let MediumRain = Prefixed_Name(shw, "MediumRain") |> PrefixedName

    /// <summary>
    ///   <para>shw:MediumRangeForecastReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherState describing the weather for more than 3 and less than 12 hours in the future.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#MediumRangeForecastReport">http://paul.staroch.name/thesis/SmartHomeWeather.owl#MediumRangeForecastReport</seealso>
    let MediumRangeForecastReport =
        Prefixed_Name(shw, "MediumRangeForecastReport") |> PrefixedName

    /// <summary>
    ///   <para>shw:MidRange</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#MidRange">http://paul.staroch.name/thesis/SmartHomeWeather.owl#MidRange</seealso>
    let MidRange = Prefixed_Name(shw, "MidRange") |> PrefixedName

    /// <summary>
    ///   <para>shw:hasPrecipitationProbability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPrecipitationProbability">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPrecipitationProbability</seealso>
    let hasPrecipitationProbability =
        Prefixed_Name(shw, "hasPrecipitationProbability") |> PrefixedName

    /// <summary>
    ///   <para>shw:Calm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing a wind speed of less than 1 m/s.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Calm">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Calm</seealso>
    let Calm = Prefixed_Name(shw, "Calm") |> PrefixedName
    /// <summary>
    ///   <para>shw:hasWindDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasWindDirection">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasWindDirection</seealso>
    let hasWindDirection = Prefixed_Name(shw, "hasWindDirection") |> PrefixedName
    /// <summary>
    ///   <para>shw:Moist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing a humidity of more than 70 percent.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Moist">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Moist</seealso>
    let Moist = Prefixed_Name(shw, "Moist") |> PrefixedName
    /// <summary>
    ///   <para>shw:MoistWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#MoistWeather">http://paul.staroch.name/thesis/SmartHomeWeather.owl#MoistWeather</seealso>
    let MoistWeather = Prefixed_Name(shw, "MoistWeather") |> PrefixedName
    /// <summary>
    ///   <para>shw:NauticalTwilight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NauticalTwilight">http://paul.staroch.name/thesis/SmartHomeWeather.owl#NauticalTwilight</seealso>
    let NauticalTwilight = Prefixed_Name(shw, "NauticalTwilight") |> PrefixedName
    /// <summary>
    ///   <para>shw:NoRainWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NoRainWeather">http://paul.staroch.name/thesis/SmartHomeWeather.owl#NoRainWeather</seealso>
    let NoRainWeather = Prefixed_Name(shw, "NoRainWeather") |> PrefixedName
    /// <summary>
    ///   <para>shw:irradiance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>muo:PhysicalQuality</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#irradiance">http://paul.staroch.name/thesis/SmartHomeWeather.owl#irradiance</seealso>
    let irradiance = Prefixed_Name(shw, "irradiance") |> PrefixedName
    /// <summary>
    ///   <para>shw:speed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>muo:PhysicalQuality</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#speed">http://paul.staroch.name/thesis/SmartHomeWeather.owl#speed</seealso>
    let speed = Prefixed_Name(shw, "speed") |> PrefixedName
    /// <summary>
    ///   <para>shw:millimeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>muo:SimpleDerivedUnit</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#millimeter">http://paul.staroch.name/thesis/SmartHomeWeather.owl#millimeter</seealso>
    let millimeter = Prefixed_Name(shw, "millimeter") |> PrefixedName

    /// <summary>
    ///   <para>shw:precipitationIntensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>muo:PhysicalQuality</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#precipitationIntensity">http://paul.staroch.name/thesis/SmartHomeWeather.owl#precipitationIntensity</seealso>
    let precipitationIntensity =
        Prefixed_Name(shw, "precipitationIntensity") |> PrefixedName

    /// <summary>
    ///   <para>shw:hasWindSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasWindSpeed">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasWindSpeed</seealso>
    let hasWindSpeed = Prefixed_Name(shw, "hasWindSpeed") |> PrefixedName
    /// <summary>
    ///   <para>shw:CalmWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CalmWeather">http://paul.staroch.name/thesis/SmartHomeWeather.owl#CalmWeather</seealso>
    let CalmWeather = Prefixed_Name(shw, "CalmWeather") |> PrefixedName

    /// <summary>
    ///   <para>shw:hasWeatherPhenomenon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a WeatherPhenomenon to its WeatherState. One WeatherPhenomenon can only belong to one WeatherState, but one WeatherState can have an arbitrary number of instances of WeatherPhenomenon.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasWeatherPhenomenon">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasWeatherPhenomenon</seealso>
    let hasWeatherPhenomenon =
        Prefixed_Name(shw, "hasWeatherPhenomenon") |> PrefixedName

    /// <summary>
    ///   <para>shw:CivilTwilight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#CivilTwilight">http://paul.staroch.name/thesis/SmartHomeWeather.owl#CivilTwilight</seealso>
    let CivilTwilight = Prefixed_Name(shw, "CivilTwilight") |> PrefixedName
    /// <summary>
    ///   <para>shw:WeatherPhenomenon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon specifies information about the weather (temperature, humidity etc.) for a certain WeatherState. It is linked to the WeatherState using the belongsToState property.
    ///
    /// For specifying the weather information, there exist several data properties: hasTemperature, hasHumidity, hasDewPoint, hasWindSpeed, hasWindDirection, hasPrecipitationProbability, hasPrecipitationValue, hasPressure, hasCloudCover, hasCloudAltitude, hasSunRadiation and hasSunAngleNoon.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherPhenomenon">http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherPhenomenon</seealso>
    let WeatherPhenomenon = Prefixed_Name(shw, "WeatherPhenomenon") |> PrefixedName
    /// <summary>
    ///   <para>shw:WeatherReportSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>WeatherStateSource represents a source of weather data, either from a (collection of) sensor(s) (sub-concept SensorSource) or from an internet service (ServiceSource).
    ///
    /// WeatherStateSource is connected to WeatherState via the hasSource/isSourceOf properties.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherReportSource">http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherReportSource</seealso>
    let WeatherReportSource = Prefixed_Name(shw, "WeatherReportSource") |> PrefixedName
    /// <summary>
    ///   <para>shw:AtmosphericPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon specifying atmospheric pressure using the hasPressure property (in hPa/mbar on MSL).</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#AtmosphericPressure">http://paul.staroch.name/thesis/SmartHomeWeather.owl#AtmosphericPressure</seealso>
    let AtmosphericPressure = Prefixed_Name(shw, "AtmosphericPressure") |> PrefixedName
    /// <summary>
    ///   <para>shw:DewPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon specifying the dew point. The actual value is specified in degrees Celsius using the hasDewPoint property.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#DewPoint">http://paul.staroch.name/thesis/SmartHomeWeather.owl#DewPoint</seealso>
    let DewPoint = Prefixed_Name(shw, "DewPoint") |> PrefixedName
    /// <summary>
    ///   <para>shw:Precipitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing both precipitation probability (property hasPrecipitationProbability, in the interval [0,1]) and the amount of precipitation (property hasPrecipitationValue, in mm/h).</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Precipitation">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Precipitation</seealso>
    let Precipitation = Prefixed_Name(shw, "Precipitation") |> PrefixedName

    /// <summary>
    ///   <para>shw:Forecast15HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherState describing the weather in 15 hours.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast15HoursWeatherReport">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast15HoursWeatherReport</seealso>
    let Forecast15HoursWeatherReport =
        Prefixed_Name(shw, "Forecast15HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>shw:Forecast1HourWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherState describing the weather in one hour.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast1HourWeatherReport">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast1HourWeatherReport</seealso>
    let Forecast1HourWeatherReport =
        Prefixed_Name(shw, "Forecast1HourWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>shw:Forecast6HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherState describing the weather in 6 hours.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast6HoursWeatherReport">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Forecast6HoursWeatherReport</seealso>
    let Forecast6HoursWeatherReport =
        Prefixed_Name(shw, "Forecast6HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>shw:Fog</para>
    /// </summary>
    /// <remarks>
    ///   <para>shw:WeatherCondition</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Fog">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Fog</seealso>
    let Fog = Prefixed_Name(shw, "Fog") |> PrefixedName
    /// <summary>
    ///   <para>shw:Sleet</para>
    /// </summary>
    /// <remarks>
    ///   <para>shw:WeatherCondition</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Sleet">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Sleet</seealso>
    let Sleet = Prefixed_Name(shw, "Sleet") |> PrefixedName
    /// <summary>
    ///   <para>shw:Night</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Night">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Night</seealso>
    let Night = Prefixed_Name(shw, "Night") |> PrefixedName
    /// <summary>
    ///   <para>shw:NoAwningWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NoAwningWeather">http://paul.staroch.name/thesis/SmartHomeWeather.owl#NoAwningWeather</seealso>
    let NoAwningWeather = Prefixed_Name(shw, "NoAwningWeather") |> PrefixedName
    /// <summary>
    ///   <para>shw:SevereWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SevereWeather">http://paul.staroch.name/thesis/SmartHomeWeather.owl#SevereWeather</seealso>
    let SevereWeather = Prefixed_Name(shw, "SevereWeather") |> PrefixedName
    /// <summary>
    ///   <para>shw:NoRain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing the absence of precipitation, either because the probability for precipitation is 0 (specified by the property hasPrecipitationProbability) or because the amount of precipitation per hour is 0 (specified by the property hasPrecipitationValue) or both.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NoRain">http://paul.staroch.name/thesis/SmartHomeWeather.owl#NoRain</seealso>
    let NoRain = Prefixed_Name(shw, "NoRain") |> PrefixedName

    /// <summary>
    ///   <para>shw:hasPrecipitationValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPrecipitationValue">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasPrecipitationValue</seealso>
    let hasPrecipitationValue =
        Prefixed_Name(shw, "hasPrecipitationValue") |> PrefixedName

    /// <summary>
    ///   <para>shw:NormalHumidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NormalHumidity">http://paul.staroch.name/thesis/SmartHomeWeather.owl#NormalHumidity</seealso>
    let NormalHumidity = Prefixed_Name(shw, "NormalHumidity") |> PrefixedName
    /// <summary>
    ///   <para>shw:NormalPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing an atmospheric pressure between 1008 hPa and 1018 hPa.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NormalPressure">http://paul.staroch.name/thesis/SmartHomeWeather.owl#NormalPressure</seealso>
    let NormalPressure = Prefixed_Name(shw, "NormalPressure") |> PrefixedName
    /// <summary>
    ///   <para>shw:NorthWind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#NorthWind">http://paul.staroch.name/thesis/SmartHomeWeather.owl#NorthWind</seealso>
    let NorthWind = Prefixed_Name(shw, "NorthWind") |> PrefixedName
    /// <summary>
    ///   <para>shw:RoomTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing a temperature between 20 and 25 degrees Celsius.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#RoomTemperature">http://paul.staroch.name/thesis/SmartHomeWeather.owl#RoomTemperature</seealso>
    let RoomTemperature = Prefixed_Name(shw, "RoomTemperature") |> PrefixedName
    /// <summary>
    ///   <para>shw:RainyWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#RainyWeather">http://paul.staroch.name/thesis/SmartHomeWeather.owl#RainyWeather</seealso>
    let RainyWeather = Prefixed_Name(shw, "RainyWeather") |> PrefixedName
    /// <summary>
    ///   <para>shw:TropicalStormRain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#TropicalStormRain">http://paul.staroch.name/thesis/SmartHomeWeather.owl#TropicalStormRain</seealso>
    let TropicalStormRain = Prefixed_Name(shw, "TropicalStormRain") |> PrefixedName
    /// <summary>
    ///   <para>shw:SensorSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherStateSource as a (collection of) sensor(s).</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SensorSource">http://paul.staroch.name/thesis/SmartHomeWeather.owl#SensorSource</seealso>
    let SensorSource = Prefixed_Name(shw, "SensorSource") |> PrefixedName
    /// <summary>
    ///   <para>shw:WeatherStateSource</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherStateSource">http://paul.staroch.name/thesis/SmartHomeWeather.owl#WeatherStateSource</seealso>
    let WeatherStateSource = Prefixed_Name(shw, "WeatherStateSource") |> PrefixedName
    /// <summary>
    ///   <para>shw:ServiceSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherStateSource as an internet service.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ServiceSource">http://paul.staroch.name/thesis/SmartHomeWeather.owl#ServiceSource</seealso>
    let ServiceSource = Prefixed_Name(shw, "ServiceSource") |> PrefixedName
    /// <summary>
    ///   <para>shw:StormyWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#StormyWeather">http://paul.staroch.name/thesis/SmartHomeWeather.owl#StormyWeather</seealso>
    let StormyWeather = Prefixed_Name(shw, "StormyWeather") |> PrefixedName
    /// <summary>
    ///   <para>shw:VeryRainyWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryRainyWeather">http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryRainyWeather</seealso>
    let VeryRainyWeather = Prefixed_Name(shw, "VeryRainyWeather") |> PrefixedName

    /// <summary>
    ///   <para>shw:ShortRangeForecastReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherState describing the weather for more at most 3 hours in the future.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ShortRangeForecastReport">http://paul.staroch.name/thesis/SmartHomeWeather.owl#ShortRangeForecastReport</seealso>
    let ShortRangeForecastReport =
        Prefixed_Name(shw, "ShortRangeForecastReport") |> PrefixedName

    /// <summary>
    ///   <para>shw:ShortRange</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#ShortRange">http://paul.staroch.name/thesis/SmartHomeWeather.owl#ShortRange</seealso>
    let ShortRange = Prefixed_Name(shw, "ShortRange") |> PrefixedName
    /// <summary>
    ///   <para>shw:SolarTwilight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SolarTwilight">http://paul.staroch.name/thesis/SmartHomeWeather.owl#SolarTwilight</seealso>
    let SolarTwilight = Prefixed_Name(shw, "SolarTwilight") |> PrefixedName
    /// <summary>
    ///   <para>shw:SouthWind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon giving information about wind. There are two properties: hasWindDirection gives the cloud cover of this layer in degrees (an integer in the interval [0-359] where 0 is North, 90 is East etc.). hasWindSpeed is a float specifying wind speed in m/s.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SouthWind">http://paul.staroch.name/thesis/SmartHomeWeather.owl#SouthWind</seealso>
    let SouthWind = Prefixed_Name(shw, "SouthWind") |> PrefixedName
    /// <summary>
    ///   <para>shw:Storm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing a wind speed of more than 20 m/s.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Storm">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Storm</seealso>
    let Storm = Prefixed_Name(shw, "Storm") |> PrefixedName
    /// <summary>
    ///   <para>shw:SunBelowHorizon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunBelowHorizon">http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunBelowHorizon</seealso>
    let SunBelowHorizon = Prefixed_Name(shw, "SunBelowHorizon") |> PrefixedName
    /// <summary>
    ///   <para>shw:SunFromEast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunFromEast">http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunFromEast</seealso>
    let SunFromEast = Prefixed_Name(shw, "SunFromEast") |> PrefixedName
    /// <summary>
    ///   <para>shw:SunFromNorth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunFromNorth">http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunFromNorth</seealso>
    let SunFromNorth = Prefixed_Name(shw, "SunFromNorth") |> PrefixedName
    /// <summary>
    ///   <para>shw:SunFromSouth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunFromSouth">http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunFromSouth</seealso>
    let SunFromSouth = Prefixed_Name(shw, "SunFromSouth") |> PrefixedName
    /// <summary>
    ///   <para>shw:SunFromWest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunFromWest">http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunFromWest</seealso>
    let SunFromWest = Prefixed_Name(shw, "SunFromWest") |> PrefixedName
    /// <summary>
    ///   <para>shw:hasSunAngleNoon</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSunAngleNoon">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasSunAngleNoon</seealso>
    let hasSunAngleNoon = Prefixed_Name(shw, "hasSunAngleNoon") |> PrefixedName

    /// <summary>
    ///   <para>shw:SunProtectionWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunProtectionWeather">http://paul.staroch.name/thesis/SmartHomeWeather.owl#SunProtectionWeather</seealso>
    let SunProtectionWeather =
        Prefixed_Name(shw, "SunProtectionWeather") |> PrefixedName

    /// <summary>
    ///   <para>shw:Thunderstorm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Thunderstorm">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Thunderstorm</seealso>
    let Thunderstorm = Prefixed_Name(shw, "Thunderstorm") |> PrefixedName
    /// <summary>
    ///   <para>shw:hasCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a WeatherCondition to a WeatherPhenomenon. A WeatherPhenomenon can be associated with an arbitrary number of instances of WeatherCondition.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasCondition">http://paul.staroch.name/thesis/SmartHomeWeather.owl#hasCondition</seealso>
    let hasCondition = Prefixed_Name(shw, "hasCondition") |> PrefixedName
    /// <summary>
    ///   <para>shw:Twilight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#Twilight">http://paul.staroch.name/thesis/SmartHomeWeather.owl#Twilight</seealso>
    let Twilight = Prefixed_Name(shw, "Twilight") |> PrefixedName
    /// <summary>
    ///   <para>shw:UnknownCloudCover</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#UnknownCloudCover">http://paul.staroch.name/thesis/SmartHomeWeather.owl#UnknownCloudCover</seealso>
    let UnknownCloudCover = Prefixed_Name(shw, "UnknownCloudCover") |> PrefixedName
    /// <summary>
    ///   <para>shw:VeryHighPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing an atmospheric pressure of more than 1028 hPa.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryHighPressure">http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryHighPressure</seealso>
    let VeryHighPressure = Prefixed_Name(shw, "VeryHighPressure") |> PrefixedName
    /// <summary>
    ///   <para>shw:VeryHighRadiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryHighRadiation">http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryHighRadiation</seealso>
    let VeryHighRadiation = Prefixed_Name(shw, "VeryHighRadiation") |> PrefixedName
    /// <summary>
    ///   <para>shw:VeryLowPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A WeatherPhenomenon describing an atmospheric pressure of less than 998 hPa.</para>
    /// </remarks>
    /// <seealso href="http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryLowPressure">http://paul.staroch.name/thesis/SmartHomeWeather.owl#VeryLowPressure</seealso>
    let VeryLowPressure = Prefixed_Name(shw, "VeryLowPressure") |> PrefixedName
