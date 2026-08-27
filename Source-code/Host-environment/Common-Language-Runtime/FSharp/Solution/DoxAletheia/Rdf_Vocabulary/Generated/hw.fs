namespace https.www.auto.tuwien.ac.at.downloads.thinkhome.ontology.WeatherOntology.owl.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module hw =
    let _namespace_iri = Namespace_Iri hw |> NamespaceIRI
    /// <summary>
    ///   <para>hw:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"smart home ontology for weather phenomena and exterior conditions"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl</seealso>
    let _prefix_iri = Prefixed_Name(hw, "") |> PrefixedName

    /// <summary>
    ///   <para>hw:#AboveRoomTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#AboveRoomTemperature">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#AboveRoomTemperature</seealso>
    let ``_#AboveRoomTemperature`` =
        Prefixed_Name(hw, "#AboveRoomTemperature") |> PrefixedName

    /// <summary>
    ///   <para>hw:#AboveZeroTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#AboveZeroTemperature">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#AboveZeroTemperature</seealso>
    let ``_#AboveZeroTemperature`` =
        Prefixed_Name(hw, "#AboveZeroTemperature") |> PrefixedName

    /// <summary>
    ///   <para>hw:#AirPollution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the current air pollution represented as European Air Quality Index value. The index value is based on 3 pollutants of major concern in Europe: PM10, NO2, O3 and will be able to take into account to 3 additional pollutants (CO, PM2.5 and SO2) where data are also available."</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#AirPollution">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#AirPollution</seealso>
    let ``_#AirPollution`` = Prefixed_Name(hw, "#AirPollution") |> PrefixedName

    /// <summary>
    ///   <para>hw:#AiringWeatherState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#AiringWeatherState">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#AiringWeatherState</seealso>
    let ``_#AiringWeatherState`` =
        Prefixed_Name(hw, "#AiringWeatherState") |> PrefixedName

    /// <summary>
    ///   <para>hw:#AtmosphericPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"atmospheric pressure in hectopascal (hPa)"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#AtmosphericPressure">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#AtmosphericPressure</seealso>
    let ``_#AtmosphericPressure`` =
        Prefixed_Name(hw, "#AtmosphericPressure") |> PrefixedName

    /// <summary>
    ///   <para>hw:#BelowOrZeroTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#BelowOrZeroTemperature">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#BelowOrZeroTemperature</seealso>
    let ``_#BelowOrZeroTemperature`` =
        Prefixed_Name(hw, "#BelowOrZeroTemperature") |> PrefixedName

    /// <summary>
    ///   <para>hw:#BelowRoomTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#BelowRoomTemperature">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#BelowRoomTemperature</seealso>
    let ``_#BelowRoomTemperature`` =
        Prefixed_Name(hw, "#BelowRoomTemperature") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Cloud</para>
    /// </summary>
    /// <remarks>
    ///   <para>hw:#WeatherCondition</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Cloud">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Cloud</seealso>
    let ``_#Cloud`` = Prefixed_Name(hw, "#Cloud") |> PrefixedName
    /// <summary>
    ///   <para>hw:#CloudCover</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"clound cover in the unit "Okta""</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#CloudCover">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#CloudCover</seealso>
    let ``_#CloudCover`` = Prefixed_Name(hw, "#CloudCover") |> PrefixedName

    /// <summary>
    ///   <para>hw:#CoolingWeatherState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#CoolingWeatherState">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#CoolingWeatherState</seealso>
    let ``_#CoolingWeatherState`` =
        Prefixed_Name(hw, "#CoolingWeatherState") |> PrefixedName

    /// <summary>
    ///   <para>hw:#CurrentWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#CurrentWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#CurrentWeatherReport</seealso>
    let ``_#CurrentWeatherReport`` =
        Prefixed_Name(hw, "#CurrentWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#CurrentWeatherReportFromSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#CurrentWeatherReportFromSensor">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#CurrentWeatherReportFromSensor</seealso>
    let ``_#CurrentWeatherReportFromSensor`` =
        Prefixed_Name(hw, "#CurrentWeatherReportFromSensor") |> PrefixedName

    /// <summary>
    ///   <para>hw:#CurrentWeatherReportFromService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#CurrentWeatherReportFromService">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#CurrentWeatherReportFromService</seealso>
    let ``_#CurrentWeatherReportFromService`` =
        Prefixed_Name(hw, "#CurrentWeatherReportFromService") |> PrefixedName

    /// <summary>
    ///   <para>hw:#DewPointTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"this concept was known as "DewPoint" in prior versions of the ontology"</para>
    ///   <para>"The dewpoint temperature in degrees Celsius. It is the temperature at which the air can no longer hold all of its water vapor, and some of the water vapor must condense into liquid water. The dew point is always lower than (or equal to) the air temperature.
    /// "</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#DewPointTemperature">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#DewPointTemperature</seealso>
    let ``_#DewPointTemperature`` =
        Prefixed_Name(hw, "#DewPointTemperature") |> PrefixedName

    /// <summary>
    ///   <para>hw:#DryHumidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#DryHumidity">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#DryHumidity</seealso>
    let ``_#DryHumidity`` = Prefixed_Name(hw, "#DryHumidity") |> PrefixedName
    /// <summary>
    ///   <para>hw:#ExtremeFrost</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ExtremeFrost">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ExtremeFrost</seealso>
    let ``_#ExtremeFrost`` = Prefixed_Name(hw, "#ExtremeFrost") |> PrefixedName
    /// <summary>
    ///   <para>hw:#ExtremeHeat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ExtremeHeat">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ExtremeHeat</seealso>
    let ``_#ExtremeHeat`` = Prefixed_Name(hw, "#ExtremeHeat") |> PrefixedName
    /// <summary>
    ///   <para>hw:#FairWeatherState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#FairWeatherState">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#FairWeatherState</seealso>
    let ``_#FairWeatherState`` = Prefixed_Name(hw, "#FairWeatherState") |> PrefixedName
    /// <summary>
    ///   <para>hw:#Fog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hw:#WeatherCondition</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Fog">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Fog</seealso>
    let ``_#Fog`` = Prefixed_Name(hw, "#Fog") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast10HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast10HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast10HoursWeatherReport</seealso>
    let ``_#Forecast10HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast10HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast11HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast11HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast11HoursWeatherReport</seealso>
    let ``_#Forecast11HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast11HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast12HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast12HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast12HoursWeatherReport</seealso>
    let ``_#Forecast12HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast12HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast13HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast13HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast13HoursWeatherReport</seealso>
    let ``_#Forecast13HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast13HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast14HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast14HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast14HoursWeatherReport</seealso>
    let ``_#Forecast14HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast14HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast15HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast15HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast15HoursWeatherReport</seealso>
    let ``_#Forecast15HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast15HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast16HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast16HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast16HoursWeatherReport</seealso>
    let ``_#Forecast16HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast16HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast17HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast17HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast17HoursWeatherReport</seealso>
    let ``_#Forecast17HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast17HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast18HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast18HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast18HoursWeatherReport</seealso>
    let ``_#Forecast18HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast18HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast19HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast19HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast19HoursWeatherReport</seealso>
    let ``_#Forecast19HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast19HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast1HourWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast1HourWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast1HourWeatherReport</seealso>
    let ``_#Forecast1HourWeatherReport`` =
        Prefixed_Name(hw, "#Forecast1HourWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast20HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast20HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast20HoursWeatherReport</seealso>
    let ``_#Forecast20HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast20HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast21HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast21HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast21HoursWeatherReport</seealso>
    let ``_#Forecast21HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast21HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast22HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast22HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast22HoursWeatherReport</seealso>
    let ``_#Forecast22HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast22HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast23HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast23HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast23HoursWeatherReport</seealso>
    let ``_#Forecast23HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast23HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast24HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast24HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast24HoursWeatherReport</seealso>
    let ``_#Forecast24HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast24HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast2HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast2HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast2HoursWeatherReport</seealso>
    let ``_#Forecast2HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast2HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast3HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast3HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast3HoursWeatherReport</seealso>
    let ``_#Forecast3HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast3HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast4HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast4HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast4HoursWeatherReport</seealso>
    let ``_#Forecast4HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast4HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast5HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast5HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast5HoursWeatherReport</seealso>
    let ``_#Forecast5HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast5HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast6HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast6HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast6HoursWeatherReport</seealso>
    let ``_#Forecast6HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast6HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast7HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast7HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast7HoursWeatherReport</seealso>
    let ``_#Forecast7HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast7HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast8HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast8HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast8HoursWeatherReport</seealso>
    let ``_#Forecast8HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast8HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Forecast9HoursWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast9HoursWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Forecast9HoursWeatherReport</seealso>
    let ``_#Forecast9HoursWeatherReport`` =
        Prefixed_Name(hw, "#Forecast9HoursWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#ForecastWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ForecastWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ForecastWeatherReport</seealso>
    let ``_#ForecastWeatherReport`` =
        Prefixed_Name(hw, "#ForecastWeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#FreshBreeze</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#FreshBreeze">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#FreshBreeze</seealso>
    let ``_#FreshBreeze`` = Prefixed_Name(hw, "#FreshBreeze") |> PrefixedName
    /// <summary>
    ///   <para>hw:#FreshGale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#FreshGale">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#FreshGale</seealso>
    let ``_#FreshGale`` = Prefixed_Name(hw, "#FreshGale") |> PrefixedName
    /// <summary>
    ///   <para>hw:#Frost</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Frost">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Frost</seealso>
    let ``_#Frost`` = Prefixed_Name(hw, "#Frost") |> PrefixedName
    /// <summary>
    ///   <para>hw:#GentleBreeze</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#GentleBreeze">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#GentleBreeze</seealso>
    let ``_#GentleBreeze`` = Prefixed_Name(hw, "#GentleBreeze") |> PrefixedName
    /// <summary>
    ///   <para>hw:#Hail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hw:#WeatherCondition</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Hail">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Hail</seealso>
    let ``_#Hail`` = Prefixed_Name(hw, "#Hail") |> PrefixedName
    /// <summary>
    ///   <para>hw:#Heat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Heat">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Heat</seealso>
    let ``_#Heat`` = Prefixed_Name(hw, "#Heat") |> PrefixedName

    /// <summary>
    ///   <para>hw:#HeatingWeatherState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#HeatingWeatherState">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#HeatingWeatherState</seealso>
    let ``_#HeatingWeatherState`` =
        Prefixed_Name(hw, "#HeatingWeatherState") |> PrefixedName

    /// <summary>
    ///   <para>hw:#HeavyPrecipitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#HeavyPrecipitation">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#HeavyPrecipitation</seealso>
    let ``_#HeavyPrecipitation`` =
        Prefixed_Name(hw, "#HeavyPrecipitation") |> PrefixedName

    /// <summary>
    ///   <para>hw:#HighAirPollution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#HighAirPollution">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#HighAirPollution</seealso>
    let ``_#HighAirPollution`` = Prefixed_Name(hw, "#HighAirPollution") |> PrefixedName

    /// <summary>
    ///   <para>hw:#HighSolarIrradiance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    ///   <para>"this concept was known as "HighSolarRadiation" in prior versions of the ontology"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#HighSolarIrradiance">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#HighSolarIrradiance</seealso>
    let ``_#HighSolarIrradiance`` =
        Prefixed_Name(hw, "#HighSolarIrradiance") |> PrefixedName

    /// <summary>
    ///   <para>hw:#HumidifyingWeatherState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#HumidifyingWeatherState">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#HumidifyingWeatherState</seealso>
    let ``_#HumidifyingWeatherState`` =
        Prefixed_Name(hw, "#HumidifyingWeatherState") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Humidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"represents the relative humidity of the air in percent"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Humidity">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Humidity</seealso>
    let ``_#Humidity`` = Prefixed_Name(hw, "#Humidity") |> PrefixedName
    /// <summary>
    ///   <para>hw:#Hurricane</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Hurricane">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Hurricane</seealso>
    let ``_#Hurricane`` = Prefixed_Name(hw, "#Hurricane") |> PrefixedName
    /// <summary>
    ///   <para>hw:#LightAir</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightAir">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightAir</seealso>
    let ``_#LightAir`` = Prefixed_Name(hw, "#LightAir") |> PrefixedName
    /// <summary>
    ///   <para>hw:#LightBreeze</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightBreeze">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightBreeze</seealso>
    let ``_#LightBreeze`` = Prefixed_Name(hw, "#LightBreeze") |> PrefixedName
    /// <summary>
    ///   <para>hw:#LightCloud</para>
    /// </summary>
    /// <remarks>
    ///   <para>hw:#WeatherCondition</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightCloud">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightCloud</seealso>
    let ``_#LightCloud`` = Prefixed_Name(hw, "#LightCloud") |> PrefixedName

    /// <summary>
    ///   <para>hw:#LightPrecipitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightPrecipitation">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightPrecipitation</seealso>
    let ``_#LightPrecipitation`` =
        Prefixed_Name(hw, "#LightPrecipitation") |> PrefixedName

    /// <summary>
    ///   <para>hw:#LightRainSun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hw:#WeatherCondition</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightRainSun">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightRainSun</seealso>
    let ``_#LightRainSun`` = Prefixed_Name(hw, "#LightRainSun") |> PrefixedName
    /// <summary>
    ///   <para>hw:#LightWind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightWind">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LightWind</seealso>
    let ``_#LightWind`` = Prefixed_Name(hw, "#LightWind") |> PrefixedName

    /// <summary>
    ///   <para>hw:#LongRangeForecast</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LongRangeForecast">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LongRangeForecast</seealso>
    let ``_#LongRangeForecast`` =
        Prefixed_Name(hw, "#LongRangeForecast") |> PrefixedName

    /// <summary>
    ///   <para>hw:#LowAirPollution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LowAirPollution">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LowAirPollution</seealso>
    let ``_#LowAirPollution`` = Prefixed_Name(hw, "#LowAirPollution") |> PrefixedName

    /// <summary>
    ///   <para>hw:#LowSolarIrradiance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"this concept was known as "LowSolarRadiation" in prior versions of the ontology"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LowSolarIrradiance">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#LowSolarIrradiance</seealso>
    let ``_#LowSolarIrradiance`` =
        Prefixed_Name(hw, "#LowSolarIrradiance") |> PrefixedName

    /// <summary>
    ///   <para>hw:#MediumAirPollution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#MediumAirPollution">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#MediumAirPollution</seealso>
    let ``_#MediumAirPollution`` =
        Prefixed_Name(hw, "#MediumAirPollution") |> PrefixedName

    /// <summary>
    ///   <para>hw:#MidRangeForecast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#MidRangeForecast">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#MidRangeForecast</seealso>
    let ``_#MidRangeForecast`` = Prefixed_Name(hw, "#MidRangeForecast") |> PrefixedName
    /// <summary>
    ///   <para>hw:#ModerateBreeze</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ModerateBreeze">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ModerateBreeze</seealso>
    let ``_#ModerateBreeze`` = Prefixed_Name(hw, "#ModerateBreeze") |> PrefixedName
    /// <summary>
    ///   <para>hw:#ModerateGale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ModerateGale">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ModerateGale</seealso>
    let ``_#ModerateGale`` = Prefixed_Name(hw, "#ModerateGale") |> PrefixedName

    /// <summary>
    ///   <para>hw:#ModeratePrecipitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    ///   <para>"this concept was known as "MediumPrecipitation" in prior versions of the ontology"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ModeratePrecipitation">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ModeratePrecipitation</seealso>
    let ``_#ModeratePrecipitation`` =
        Prefixed_Name(hw, "#ModeratePrecipitation") |> PrefixedName

    /// <summary>
    ///   <para>hw:#ModerateSolarIrradiance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ModerateSolarIrradiance">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ModerateSolarIrradiance</seealso>
    let ``_#ModerateSolarIrradiance`` =
        Prefixed_Name(hw, "#ModerateSolarIrradiance") |> PrefixedName

    /// <summary>
    ///   <para>hw:#MoistHumidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#MoistHumidity">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#MoistHumidity</seealso>
    let ``_#MoistHumidity`` = Prefixed_Name(hw, "#MoistHumidity") |> PrefixedName
    /// <summary>
    ///   <para>hw:#MostlyCloudy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#MostlyCloudy">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#MostlyCloudy</seealso>
    let ``_#MostlyCloudy`` = Prefixed_Name(hw, "#MostlyCloudy") |> PrefixedName

    /// <summary>
    ///   <para>hw:#NeglectibleSolarIrradiance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    ///   <para>"this concept was known as "NeglectibleSolarRadiation" in prior versions of the ontology"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#NeglectibleSolarIrradiance">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#NeglectibleSolarIrradiance</seealso>
    let ``_#NeglectibleSolarIrradiance`` =
        Prefixed_Name(hw, "#NeglectibleSolarIrradiance") |> PrefixedName

    /// <summary>
    ///   <para>hw:#NeutralWeatherState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#NeutralWeatherState">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#NeutralWeatherState</seealso>
    let ``_#NeutralWeatherState`` =
        Prefixed_Name(hw, "#NeutralWeatherState") |> PrefixedName

    /// <summary>
    ///   <para>hw:#NoCloudCover</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#NoCloudCover">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#NoCloudCover</seealso>
    let ``_#NoCloudCover`` = Prefixed_Name(hw, "#NoCloudCover") |> PrefixedName
    /// <summary>
    ///   <para>hw:#NoPrecipitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#NoPrecipitation">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#NoPrecipitation</seealso>
    let ``_#NoPrecipitation`` = Prefixed_Name(hw, "#NoPrecipitation") |> PrefixedName
    /// <summary>
    ///   <para>hw:#NoWind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#NoWind">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#NoWind</seealso>
    let ``_#NoWind`` = Prefixed_Name(hw, "#NoWind") |> PrefixedName
    /// <summary>
    ///   <para>hw:#OptimumHumidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#OptimumHumidity">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#OptimumHumidity</seealso>
    let ``_#OptimumHumidity`` = Prefixed_Name(hw, "#OptimumHumidity") |> PrefixedName
    /// <summary>
    ///   <para>hw:#Overcast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Overcast">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Overcast</seealso>
    let ``_#Overcast`` = Prefixed_Name(hw, "#Overcast") |> PrefixedName
    /// <summary>
    ///   <para>hw:#PartlyCloud</para>
    /// </summary>
    /// <remarks>
    ///   <para>hw:#WeatherCondition</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#PartlyCloud">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#PartlyCloud</seealso>
    let ``_#PartlyCloud`` = Prefixed_Name(hw, "#PartlyCloud") |> PrefixedName
    /// <summary>
    ///   <para>hw:#PartlyCloudy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#PartlyCloudy">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#PartlyCloudy</seealso>
    let ``_#PartlyCloudy`` = Prefixed_Name(hw, "#PartlyCloudy") |> PrefixedName
    /// <summary>
    ///   <para>hw:#Precipitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"represents precipitation in millimetres"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Precipitation">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Precipitation</seealso>
    let ``_#Precipitation`` = Prefixed_Name(hw, "#Precipitation") |> PrefixedName
    /// <summary>
    ///   <para>hw:#Rain</para>
    /// </summary>
    /// <remarks>
    ///   <para>hw:#WeatherCondition</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Rain">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Rain</seealso>
    let ``_#Rain`` = Prefixed_Name(hw, "#Rain") |> PrefixedName

    /// <summary>
    ///   <para>hw:#RainyWeatherState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#RainyWeatherState">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#RainyWeatherState</seealso>
    let ``_#RainyWeatherState`` =
        Prefixed_Name(hw, "#RainyWeatherState") |> PrefixedName

    /// <summary>
    ///   <para>hw:#RoomTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#RoomTemperature">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#RoomTemperature</seealso>
    let ``_#RoomTemperature`` = Prefixed_Name(hw, "#RoomTemperature") |> PrefixedName

    /// <summary>
    ///   <para>hw:#SensorReportSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"this class was known as "SensorSource" in prior versions of the ontology"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#SensorReportSource">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#SensorReportSource</seealso>
    let ``_#SensorReportSource`` =
        Prefixed_Name(hw, "#SensorReportSource") |> PrefixedName

    /// <summary>
    ///   <para>hw:#ServiceReportSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"this class was known as "ServiceSource" in prior versions of the ontology"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ServiceReportSource">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ServiceReportSource</seealso>
    let ``_#ServiceReportSource`` =
        Prefixed_Name(hw, "#ServiceReportSource") |> PrefixedName

    /// <summary>
    ///   <para>hw:#SevereWeatherState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#SevereWeatherState">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#SevereWeatherState</seealso>
    let ``_#SevereWeatherState`` =
        Prefixed_Name(hw, "#SevereWeatherState") |> PrefixedName

    /// <summary>
    ///   <para>hw:#ShortRangeForecast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ShortRangeForecast">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ShortRangeForecast</seealso>
    let ``_#ShortRangeForecast`` =
        Prefixed_Name(hw, "#ShortRangeForecast") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Sleet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hw:#WeatherCondition</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Sleet">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Sleet</seealso>
    let ``_#Sleet`` = Prefixed_Name(hw, "#Sleet") |> PrefixedName
    /// <summary>
    ///   <para>hw:#Snow</para>
    /// </summary>
    /// <remarks>
    ///   <para>hw:#WeatherCondition</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Snow">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Snow</seealso>
    let ``_#Snow`` = Prefixed_Name(hw, "#Snow") |> PrefixedName

    /// <summary>
    ///   <para>hw:#SnowyWeatherState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#SnowyWeatherState">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#SnowyWeatherState</seealso>
    let ``_#SnowyWeatherState`` =
        Prefixed_Name(hw, "#SnowyWeatherState") |> PrefixedName

    /// <summary>
    ///   <para>hw:#SolarIrradiance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"measurement of solar irrradiation at a specific location in Watts per square meter (W/m²)"</para>
    ///   <para>"this concept was known as "SolarRadiation" in prior versions of the ontology"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#SolarIrradiance">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#SolarIrradiance</seealso>
    let ``_#SolarIrradiance`` = Prefixed_Name(hw, "#SolarIrradiance") |> PrefixedName
    /// <summary>
    ///   <para>hw:#Storm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Storm">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Storm</seealso>
    let ``_#Storm`` = Prefixed_Name(hw, "#Storm") |> PrefixedName
    /// <summary>
    ///   <para>hw:#StrongBreeze</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#StrongBreeze">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#StrongBreeze</seealso>
    let ``_#StrongBreeze`` = Prefixed_Name(hw, "#StrongBreeze") |> PrefixedName
    /// <summary>
    ///   <para>hw:#StrongGale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#StrongGale">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#StrongGale</seealso>
    let ``_#StrongGale`` = Prefixed_Name(hw, "#StrongGale") |> PrefixedName
    /// <summary>
    ///   <para>hw:#StrongWind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#StrongWind">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#StrongWind</seealso>
    let ``_#StrongWind`` = Prefixed_Name(hw, "#StrongWind") |> PrefixedName
    /// <summary>
    ///   <para>hw:#Sun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hw:#WeatherCondition</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Sun">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Sun</seealso>
    let ``_#Sun`` = Prefixed_Name(hw, "#Sun") |> PrefixedName

    /// <summary>
    ///   <para>hw:#SunnyWeatherState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#SunnyWeatherState">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#SunnyWeatherState</seealso>
    let ``_#SunnyWeatherState`` =
        Prefixed_Name(hw, "#SunnyWeatherState") |> PrefixedName

    /// <summary>
    ///   <para>hw:#Temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"exterior temperature in degrees Celsius"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Temperature">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Temperature</seealso>
    let ``_#Temperature`` = Prefixed_Name(hw, "#Temperature") |> PrefixedName
    /// <summary>
    ///   <para>hw:#Thunder</para>
    /// </summary>
    /// <remarks>
    ///   <para>hw:#WeatherCondition</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Thunder">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Thunder</seealso>
    let ``_#Thunder`` = Prefixed_Name(hw, "#Thunder") |> PrefixedName
    /// <summary>
    ///   <para>hw:#Thunderstorm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Thunderstorm">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Thunderstorm</seealso>
    let ``_#Thunderstorm`` = Prefixed_Name(hw, "#Thunderstorm") |> PrefixedName

    /// <summary>
    ///   <para>hw:#UnknownCloudCover</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#UnknownCloudCover">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#UnknownCloudCover</seealso>
    let ``_#UnknownCloudCover`` =
        Prefixed_Name(hw, "#UnknownCloudCover") |> PrefixedName

    /// <summary>
    ///   <para>hw:#VeryHighAirPollution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#VeryHighAirPollution">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#VeryHighAirPollution</seealso>
    let ``_#VeryHighAirPollution`` =
        Prefixed_Name(hw, "#VeryHighAirPollution") |> PrefixedName

    /// <summary>
    ///   <para>hw:#VeryLowAirPollution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#VeryLowAirPollution">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#VeryLowAirPollution</seealso>
    let ``_#VeryLowAirPollution`` =
        Prefixed_Name(hw, "#VeryLowAirPollution") |> PrefixedName

    /// <summary>
    ///   <para>hw:#ViolentStorm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ViolentStorm">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#ViolentStorm</seealso>
    let ``_#ViolentStorm`` = Prefixed_Name(hw, "#ViolentStorm") |> PrefixedName
    /// <summary>
    ///   <para>hw:#WeatherCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"One-word description of the observed weather condition"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherCondition">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherCondition</seealso>
    let ``_#WeatherCondition`` = Prefixed_Name(hw, "#WeatherCondition") |> PrefixedName

    /// <summary>
    ///   <para>hw:#WeatherPhenomenon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"different weather phenomena that may influence the current and forecasted weather state."</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherPhenomenon">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherPhenomenon</seealso>
    let ``_#WeatherPhenomenon`` =
        Prefixed_Name(hw, "#WeatherPhenomenon") |> PrefixedName

    /// <summary>
    ///   <para>hw:#WeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"a weather report that can be retrieved through a local sensor (e.g. weather station integrated in the smart home) or a remote internet service. Further a time division has been realized to differentiate between current, short, mid and long term forecasts.
    ///
    /// For the smart home domain, a time window of 24 hours for weather forecasts has been seen as suitable with a 24 hours forecast being classified as long-term forecast"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherReport</seealso>
    let ``_#WeatherReport`` = Prefixed_Name(hw, "#WeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>hw:#WeatherReportFromSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherReportFromSensor">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherReportFromSensor</seealso>
    let ``_#WeatherReportFromSensor`` =
        Prefixed_Name(hw, "#WeatherReportFromSensor") |> PrefixedName

    /// <summary>
    ///   <para>hw:#WeatherReportFromService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherReportFromService">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherReportFromService</seealso>
    let ``_#WeatherReportFromService`` =
        Prefixed_Name(hw, "#WeatherReportFromService") |> PrefixedName

    /// <summary>
    ///   <para>hw:#WeatherReportSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Holds information about the origins of weather reports"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherReportSource">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherReportSource</seealso>
    let ``_#WeatherReportSource`` =
        Prefixed_Name(hw, "#WeatherReportSource") |> PrefixedName

    /// <summary>
    ///   <para>hw:#WeatherState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes the actual weather reported through information from the weather source."</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherState">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WeatherState</seealso>
    let ``_#WeatherState`` = Prefixed_Name(hw, "#WeatherState") |> PrefixedName
    /// <summary>
    ///   <para>hw:#WholeGale</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WholeGale">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#WholeGale</seealso>
    let ``_#WholeGale`` = Prefixed_Name(hw, "#WholeGale") |> PrefixedName
    /// <summary>
    ///   <para>hw:#Wind</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    ///   <para>"Unit of wind speed in metres per second (m/s)."</para>
    ///   <para>"Wind direction and speed are represented as datatype properties"hasDirection" and "hasSpeed"
    /// "</para>
    ///   <para>"Unit of wind direction is degrees
    /// "</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Wind">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#Wind</seealso>
    let ``_#Wind`` = Prefixed_Name(hw, "#Wind") |> PrefixedName

    /// <summary>
    ///   <para>hw:#belongsToWeatherState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"this property was known as "belongsToState" in prior versions of the ontology"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#belongsToWeatherState">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#belongsToWeatherState</seealso>
    let ``_#belongsToWeatherState`` =
        Prefixed_Name(hw, "#belongsToWeatherState") |> PrefixedName

    /// <summary>
    ///   <para>hw:#createdAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The instant at which a weather report is created"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#createdAt">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#createdAt</seealso>
    let ``_#createdAt`` = Prefixed_Name(hw, "#createdAt") |> PrefixedName
    /// <summary>
    ///   <para>hw:#hasAirPollution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasAirPollution">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasAirPollution</seealso>
    let ``_#hasAirPollution`` = Prefixed_Name(hw, "#hasAirPollution") |> PrefixedName

    /// <summary>
    ///   <para>hw:#hasAssociatedSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasAssociatedSensor">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasAssociatedSensor</seealso>
    let ``_#hasAssociatedSensor`` =
        Prefixed_Name(hw, "#hasAssociatedSensor") |> PrefixedName

    /// <summary>
    ///   <para>hw:#hasAtmosphericPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasAtmosphericPressure">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasAtmosphericPressure</seealso>
    let ``_#hasAtmosphericPressure`` =
        Prefixed_Name(hw, "#hasAtmosphericPressure") |> PrefixedName

    /// <summary>
    ///   <para>hw:#hasCloudAltitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasCloudAltitude">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasCloudAltitude</seealso>
    let ``_#hasCloudAltitude`` = Prefixed_Name(hw, "#hasCloudAltitude") |> PrefixedName
    /// <summary>
    ///   <para>hw:#hasCloudCover</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasCloudCover">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasCloudCover</seealso>
    let ``_#hasCloudCover`` = Prefixed_Name(hw, "#hasCloudCover") |> PrefixedName

    /// <summary>
    ///   <para>hw:#hasCloudCoverValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasCloudCoverValue">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasCloudCoverValue</seealso>
    let ``_#hasCloudCoverValue`` =
        Prefixed_Name(hw, "#hasCloudCoverValue") |> PrefixedName

    /// <summary>
    ///   <para>hw:#hasDewPointTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasDewPointTemperature">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasDewPointTemperature</seealso>
    let ``_#hasDewPointTemperature`` =
        Prefixed_Name(hw, "#hasDewPointTemperature") |> PrefixedName

    /// <summary>
    ///   <para>hw:#hasDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Wind direction represented in degrees"</para>
    ///   <para>"Wind direction"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasDirection">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasDirection</seealso>
    let ``_#hasDirection`` = Prefixed_Name(hw, "#hasDirection") |> PrefixedName
    /// <summary>
    ///   <para>hw:#hasEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasEndTime">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasEndTime</seealso>
    let ``_#hasEndTime`` = Prefixed_Name(hw, "#hasEndTime") |> PrefixedName

    /// <summary>
    ///   <para>hw:#hasExteriorTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasExteriorTemperature">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasExteriorTemperature</seealso>
    let ``_#hasExteriorTemperature`` =
        Prefixed_Name(hw, "#hasExteriorTemperature") |> PrefixedName

    /// <summary>
    ///   <para>hw:#hasHumidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasHumidity">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasHumidity</seealso>
    let ``_#hasHumidity`` = Prefixed_Name(hw, "#hasHumidity") |> PrefixedName
    /// <summary>
    ///   <para>hw:#hasIntensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasIntensity">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasIntensity</seealso>
    let ``_#hasIntensity`` = Prefixed_Name(hw, "#hasIntensity") |> PrefixedName
    /// <summary>
    ///   <para>hw:#hasLatitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasLatitude">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasLatitude</seealso>
    let ``_#hasLatitude`` = Prefixed_Name(hw, "#hasLatitude") |> PrefixedName
    /// <summary>
    ///   <para>hw:#hasLongitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasLongitude">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasLongitude</seealso>
    let ``_#hasLongitude`` = Prefixed_Name(hw, "#hasLongitude") |> PrefixedName

    /// <summary>
    ///   <para>hw:#hasObservationTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes the time a weather state has been observed or is forecasted for."</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasObservationTime">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasObservationTime</seealso>
    let ``_#hasObservationTime`` =
        Prefixed_Name(hw, "#hasObservationTime") |> PrefixedName

    /// <summary>
    ///   <para>hw:#hasPrecipitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasPrecipitation">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasPrecipitation</seealso>
    let ``_#hasPrecipitation`` = Prefixed_Name(hw, "#hasPrecipitation") |> PrefixedName
    /// <summary>
    ///   <para>hw:#hasPriority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasPriority">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasPriority</seealso>
    let ``_#hasPriority`` = Prefixed_Name(hw, "#hasPriority") |> PrefixedName

    /// <summary>
    ///   <para>hw:#hasSolarIrradiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasSolarIrradiation">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasSolarIrradiation</seealso>
    let ``_#hasSolarIrradiation`` =
        Prefixed_Name(hw, "#hasSolarIrradiation") |> PrefixedName

    /// <summary>
    ///   <para>hw:#hasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"links a weather report to the reporting source, either an internet weather service or a local weather sensor"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasSource">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasSource</seealso>
    let ``_#hasSource`` = Prefixed_Name(hw, "#hasSource") |> PrefixedName
    /// <summary>
    ///   <para>hw:#hasSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Wind speed"</para>
    ///   <para>"wind speed in metres per second (m/s)"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasSpeed">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasSpeed</seealso>
    let ``_#hasSpeed`` = Prefixed_Name(hw, "#hasSpeed") |> PrefixedName
    /// <summary>
    ///   <para>hw:#hasStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasStartTime">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasStartTime</seealso>
    let ``_#hasStartTime`` = Prefixed_Name(hw, "#hasStartTime") |> PrefixedName
    /// <summary>
    ///   <para>hw:#hasTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasTime">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasTime</seealso>
    let ``_#hasTime`` = Prefixed_Name(hw, "#hasTime") |> PrefixedName
    /// <summary>
    ///   <para>hw:#hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasUnit">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasUnit</seealso>
    let ``_#hasUnit`` = Prefixed_Name(hw, "#hasUnit") |> PrefixedName
    /// <summary>
    ///   <para>hw:#hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasValue">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasValue</seealso>
    let ``_#hasValue`` = Prefixed_Name(hw, "#hasValue") |> PrefixedName

    /// <summary>
    ///   <para>hw:#hasWeatherCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"relation of weather states and a one-word description for the observed weather situation"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasWeatherCondition">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasWeatherCondition</seealso>
    let ``_#hasWeatherCondition`` =
        Prefixed_Name(hw, "#hasWeatherCondition") |> PrefixedName

    /// <summary>
    ///   <para>hw:#hasWeatherPhenomenon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between weather states and the phenomena that are observed or forecasted"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasWeatherPhenomenon">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasWeatherPhenomenon</seealso>
    let ``_#hasWeatherPhenomenon`` =
        Prefixed_Name(hw, "#hasWeatherPhenomenon") |> PrefixedName

    /// <summary>
    ///   <para>hw:#hasWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"a specific weather state is reported for a location by a weather report."</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasWeatherReport">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasWeatherReport</seealso>
    let ``_#hasWeatherReport`` = Prefixed_Name(hw, "#hasWeatherReport") |> PrefixedName
    /// <summary>
    ///   <para>hw:#hasWind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasWind">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#hasWind</seealso>
    let ``_#hasWind`` = Prefixed_Name(hw, "#hasWind") |> PrefixedName
    /// <summary>
    ///   <para>hw:#isSourceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#isSourceOf">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#isSourceOf</seealso>
    let ``_#isSourceOf`` = Prefixed_Name(hw, "#isSourceOf") |> PrefixedName

    /// <summary>
    ///   <para>hw:#reportsWeatherForTimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"this property describes an interval that denotes the time in the future (offset) for which the weather is reported"</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#reportsWeatherForTimeInterval">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#reportsWeatherForTimeInterval</seealso>
    let ``_#reportsWeatherForTimeInterval`` =
        Prefixed_Name(hw, "#reportsWeatherForTimeInterval") |> PrefixedName

    /// <summary>
    ///   <para>hw:#reportsWeatherObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#reportsWeatherObservation">https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl#reportsWeatherObservation</seealso>
    let ``_#reportsWeatherObservation`` =
        Prefixed_Name(hw, "#reportsWeatherObservation") |> PrefixedName
