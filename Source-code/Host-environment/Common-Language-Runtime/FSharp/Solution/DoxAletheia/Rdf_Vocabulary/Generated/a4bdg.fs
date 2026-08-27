namespace https.w3id.org.aerOS.building.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module a4bdg =
    let _namespace_iri = Namespace_Iri a4bdg |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:aerOS/building#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#">https://w3id.org/aerOS/building#</seealso>
    let _prefix_iri = Prefixed_Name(a4bdg, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#Desk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Working place composed of table, chair, and display."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Desk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#Desk">https://w3id.org/aerOS/building#Desk</seealso>
    let Desk = Prefixed_Name(a4bdg, "Desk") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#Forecast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a prediction for a property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Forecast"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#Forecast">https://w3id.org/aerOS/building#Forecast</seealso>
    let Forecast = Prefixed_Name(a4bdg, "Forecast") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#OnOffState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes a device whose state can be on or off, such as a smart switch."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"On Off State"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#OnOffState">https://w3id.org/aerOS/building#OnOffState</seealso>
    let OnOffState = Prefixed_Name(a4bdg, "OnOffState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#OpenClosedState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes a device whose state can be open or closed, such as a window or a door."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Open Closed State"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#OpenClosedState">https://w3id.org/aerOS/building#OpenClosedState</seealso>
    let OpenClosedState = Prefixed_Name(a4bdg, "OpenClosedState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#OptimalCalculation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the optimal calculation for a given property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OptimalCalculation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#OptimalCalculation">https://w3id.org/aerOS/building#OptimalCalculation</seealso>
    let OptimalCalculation = Prefixed_Name(a4bdg, "OptimalCalculation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#RankedPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes an ordered list of preferences."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ranked Preference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RankedPreference">https://w3id.org/aerOS/building#RankedPreference</seealso>
    let RankedPreference = Prefixed_Name(a4bdg, "RankedPreference") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#Rating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the action of someone that rates a thing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rating"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#Rating">https://w3id.org/aerOS/building#Rating</seealso>
    let Rating = Prefixed_Name(a4bdg, "Rating") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/building#RecommendationSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Service responsible for providing recommendations to employees."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Recommendation System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RecommendationSystem">https://w3id.org/aerOS/building#RecommendationSystem</seealso>
    let RecommendationSystem =
        Prefixed_Name(a4bdg, "RecommendationSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/building#RoomAcetone</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/building#RoomGas</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Property that represents the amount of acetone present in the air a given room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room Acetone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RoomAcetone">https://w3id.org/aerOS/building#RoomAcetone</seealso>
    let RoomAcetone = Prefixed_Name(a4bdg, "RoomAcetone") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#RoomAirQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/building#RoomProperty</para>
    ///   <para>"Property that represents the air quality index (AQI) of a given room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room AirQuality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RoomAirQuality">https://w3id.org/aerOS/building#RoomAirQuality</seealso>
    let RoomAirQuality = Prefixed_Name(a4bdg, "RoomAirQuality") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#RoomAlcohol</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/building#RoomGas</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Property that represents the amount of alcohol present in the air a given room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room Alcohol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RoomAlcohol">https://w3id.org/aerOS/building#RoomAlcohol</seealso>
    let RoomAlcohol = Prefixed_Name(a4bdg, "RoomAlcohol") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#RoomCO</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/building#RoomGas</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Property that represents the amount of carbon monoxide (CO) present in the air a given room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room CO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RoomCO">https://w3id.org/aerOS/building#RoomCO</seealso>
    let RoomCO = Prefixed_Name(a4bdg, "RoomCO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#RoomCO2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/building#RoomGas</para>
    ///   <para>"Property that represents the amount of carbon dioxide (CO2) present in the air a given room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room CO2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RoomCO2">https://w3id.org/aerOS/building#RoomCO2</seealso>
    let RoomCO2 = Prefixed_Name(a4bdg, "RoomCO2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#RoomDust</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Groups properties related to the presence of dust in the air of a given room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room Dust"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RoomDust">https://w3id.org/aerOS/building#RoomDust</seealso>
    let RoomDust = Prefixed_Name(a4bdg, "RoomDust") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#RoomEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/building#RoomProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Property that represents the energy consumed by a given room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RoomEnergy">https://w3id.org/aerOS/building#RoomEnergy</seealso>
    let RoomEnergy = Prefixed_Name(a4bdg, "RoomEnergy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#RoomGas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Groups properties related to the presence of gas in the air of a given room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room Gas"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RoomGas">https://w3id.org/aerOS/building#RoomGas</seealso>
    let RoomGas = Prefixed_Name(a4bdg, "RoomGas") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#RoomHealth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/building#RoomProperty</para>
    ///   <para>"Property that represents the health of a given room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room Health"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RoomHealth">https://w3id.org/aerOS/building#RoomHealth</seealso>
    let RoomHealth = Prefixed_Name(a4bdg, "RoomHealth") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#RoomHumidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/building#RoomProperty</para>
    ///   <para>"Property that represents the humidity of a given room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room Humidity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RoomHumidity">https://w3id.org/aerOS/building#RoomHumidity</seealso>
    let RoomHumidity = Prefixed_Name(a4bdg, "RoomHumidity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#RoomNH4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/building#RoomGas</para>
    ///   <para>"Property that represents the amount of ammonium (NH4) present in the air a given room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room NH4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RoomNH4">https://w3id.org/aerOS/building#RoomNH4</seealso>
    let RoomNH4 = Prefixed_Name(a4bdg, "RoomNH4") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#RoomPM1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/building#RoomDust</para>
    ///   <para>"Property that represents the air quality index (AQI) of a given room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room PM1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RoomPM1">https://w3id.org/aerOS/building#RoomPM1</seealso>
    let RoomPM1 = Prefixed_Name(a4bdg, "RoomPM1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#RoomPM10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/building#RoomDust</para>
    ///   <para>"Property that represents the air quality index (AQI) of a given room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room PM10"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RoomPM10">https://w3id.org/aerOS/building#RoomPM10</seealso>
    let RoomPM10 = Prefixed_Name(a4bdg, "RoomPM10") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#RoomPM2.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/building#RoomDust</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Property that represents the air quality index (AQI) of a given room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room PM2.5"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RoomPM2.5">https://w3id.org/aerOS/building#RoomPM2.5</seealso>
    let ``RoomPM2.5`` = Prefixed_Name(a4bdg, "RoomPM2.5") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#RoomPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/building#RoomProperty</para>
    ///   <para>"Property that represents the power consumed by a given room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room Power"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RoomPower">https://w3id.org/aerOS/building#RoomPower</seealso>
    let RoomPower = Prefixed_Name(a4bdg, "RoomPower") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#RoomPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/building#RoomProperty</para>
    ///   <para>"Property that represents the pressure of a given room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room Pressure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RoomPressure">https://w3id.org/aerOS/building#RoomPressure</seealso>
    let RoomPressure = Prefixed_Name(a4bdg, "RoomPressure") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#RoomProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents an observable property of a given room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RoomProperty">https://w3id.org/aerOS/building#RoomProperty</seealso>
    let RoomProperty = Prefixed_Name(a4bdg, "RoomProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#RoomTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/building#RoomProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Property that represents the temperature of a given room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room Temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RoomTemperature">https://w3id.org/aerOS/building#RoomTemperature</seealso>
    let RoomTemperature = Prefixed_Name(a4bdg, "RoomTemperature") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#RoomToluene</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/building#RoomGas</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Property that represents the amount of toluene present in the air a given room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room Toluene"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#RoomToluene">https://w3id.org/aerOS/building#RoomToluene</seealso>
    let RoomToluene = Prefixed_Name(a4bdg, "RoomToluene") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#air_quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>saref:Sensor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Type of sensor that measures air quality index (AQI) property of a room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Air Quality Sensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#air_quality">https://w3id.org/aerOS/building#air_quality</seealso>
    let air_quality = Prefixed_Name(a4bdg, "air_quality") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#calculates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates an optimal calculation of property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"calculates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#calculates">https://w3id.org/aerOS/building#calculates</seealso>
    let calculates = Prefixed_Name(a4bdg, "calculates") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#closedState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/building#OpenClosedState</para>
    ///   <para>"Denotes a device whose state is closed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Closed State"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#closedState">https://w3id.org/aerOS/building#closedState</seealso>
    let closedState = Prefixed_Name(a4bdg, "closedState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#environmental</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>saref:Sensor</para>
    ///   <para>"Type of sensor that measures temperature, humidity, and pressure properties of a room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"THP Sensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#environmental">https://w3id.org/aerOS/building#environmental</seealso>
    let environmental = Prefixed_Name(a4bdg, "environmental") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#environmental_dust</para>
    /// </summary>
    /// <remarks>
    ///   <para>saref:Sensor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Type of sensor that measures dust properties of a room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dust Sensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#environmental_dust">https://w3id.org/aerOS/building#environmental_dust</seealso>
    let environmental_dust = Prefixed_Name(a4bdg, "environmental_dust") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/building#environmental_gasses</para>
    /// </summary>
    /// <remarks>
    ///   <para>saref:Sensor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Type of sensor that measures gas properties of a room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gas Sensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#environmental_gasses">https://w3id.org/aerOS/building#environmental_gasses</seealso>
    let environmental_gasses =
        Prefixed_Name(a4bdg, "environmental_gasses") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/building#environmental_nop</para>
    /// </summary>
    /// <remarks>
    ///   <para>saref:Sensor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Type of sensor that measures temperature and humidity properties of a room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TH Sensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#environmental_nop">https://w3id.org/aerOS/building#environmental_nop</seealso>
    let environmental_nop = Prefixed_Name(a4bdg, "environmental_nop") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#forecasts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a forecast with the predicted property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"forecasts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#forecasts">https://w3id.org/aerOS/building#forecasts</seealso>
    let forecasts = Prefixed_Name(a4bdg, "forecasts") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/building#hasRankedPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a person with a ranked preference."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has ranked preference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#hasRankedPreference">https://w3id.org/aerOS/building#hasRankedPreference</seealso>
    let hasRankedPreference =
        Prefixed_Name(a4bdg, "hasRankedPreference") |> PrefixedName

    /// <summary>
    ///   <para>w3id:aerOS/building#isAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Denotes whether a desk is available or not."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is available"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#isAvailable">https://w3id.org/aerOS/building#isAvailable</seealso>
    let isAvailable = Prefixed_Name(a4bdg, "isAvailable") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#isContainedInRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Refers to a thing that is contained within a room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is contained in room"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#isContainedInRoom">https://w3id.org/aerOS/building#isContainedInRoom</seealso>
    let isContainedInRoom = Prefixed_Name(a4bdg, "isContainedInRoom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#isContainedInZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Refers to a thing that is contained within a zone."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is contained in zone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#isContainedInZone">https://w3id.org/aerOS/building#isContainedInZone</seealso>
    let isContainedInZone = Prefixed_Name(a4bdg, "isContainedInZone") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#isLocatedInStorey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Refers to a thing that is located in a storey."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is located in storey"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#isLocatedInStorey">https://w3id.org/aerOS/building#isLocatedInStorey</seealso>
    let isLocatedInStorey = Prefixed_Name(a4bdg, "isLocatedInStorey") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#offState</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/building#OnOffState</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Denotes a device whose state is off."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Off State"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#offState">https://w3id.org/aerOS/building#offState</seealso>
    let offState = Prefixed_Name(a4bdg, "offState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#onState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:aerOS/building#OnOffState</para>
    ///   <para>"Denotes a device whose state is on."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"On State"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#onState">https://w3id.org/aerOS/building#onState</seealso>
    let onState = Prefixed_Name(a4bdg, "onState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#openState</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:aerOS/building#OpenClosedState</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Denotes a device whose state is open."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Open State"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#openState">https://w3id.org/aerOS/building#openState</seealso>
    let openState = Prefixed_Name(a4bdg, "openState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#power_meter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>saref:Sensor</para>
    ///   <para>"Type of sensor that measures the energy and power consumption of a room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Power Meter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#power_meter">https://w3id.org/aerOS/building#power_meter</seealso>
    let power_meter = Prefixed_Name(a4bdg, "power_meter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#preferenceObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a ranked preference with the preferred thing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"preference object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#preferenceObject">https://w3id.org/aerOS/building#preferenceObject</seealso>
    let preferenceObject = Prefixed_Name(a4bdg, "preferenceObject") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#presentInBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Denotes the presence of a person inside a building."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"present in building"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#presentInBuilding">https://w3id.org/aerOS/building#presentInBuilding</seealso>
    let presentInBuilding = Prefixed_Name(a4bdg, "presentInBuilding") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#ratingAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a person with a rating."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rating author"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#ratingAuthor">https://w3id.org/aerOS/building#ratingAuthor</seealso>
    let ratingAuthor = Prefixed_Name(a4bdg, "ratingAuthor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#ratingTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a rating with the rated thing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rating target"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#ratingTarget">https://w3id.org/aerOS/building#ratingTarget</seealso>
    let ratingTarget = Prefixed_Name(a4bdg, "ratingTarget") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#ratingValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Represents the value of the rating."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rating value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#ratingValue">https://w3id.org/aerOS/building#ratingValue</seealso>
    let ratingValue = Prefixed_Name(a4bdg, "ratingValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#roomPlacement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Represents the location where the sensor is placed, i.e., indoors or outdoors."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"room placement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#roomPlacement">https://w3id.org/aerOS/building#roomPlacement</seealso>
    let roomPlacement = Prefixed_Name(a4bdg, "roomPlacement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:aerOS/building#smart_switch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>saref:Sensor</para>
    ///   <para>"Type of switch that measures the energy and power consumption of a room."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Smart Switch"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/aerOS/building#smart_switch">https://w3id.org/aerOS/building#smart_switch</seealso>
    let smart_switch = Prefixed_Name(a4bdg, "smart_switch") |> PrefixedName
