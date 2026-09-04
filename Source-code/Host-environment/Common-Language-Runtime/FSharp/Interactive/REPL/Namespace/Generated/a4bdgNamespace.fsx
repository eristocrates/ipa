#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module a4bdg =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/aerOS/building#" "a4bdg"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Desk^^xsd:string</para>
    ///   <para>rdfs:comment : Working place composed of table, chair, and display.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#Desk">a4bdg:Desk</a>
    /// </summary>
    let Desk = _prefixId.prefix "Desk"
    /// <summary>
    ///   <para>rdfs:label : Forecast^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a prediction for a property.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#Forecast">a4bdg:Forecast</a>
    /// </summary>
    let Forecast = _prefixId.prefix "Forecast"
    /// <summary>
    ///   <para>rdfs:label : On Off State^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes a device whose state can be on or off, such as a smart switch.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#OnOffState">a4bdg:OnOffState</a>
    /// </summary>
    let OnOffState = _prefixId.prefix "OnOffState"
    /// <summary>
    ///   <para>rdfs:label : Open Closed State^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes a device whose state can be open or closed, such as a window or a door.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#OpenClosedState">a4bdg:OpenClosedState</a>
    /// </summary>
    let OpenClosedState = _prefixId.prefix "OpenClosedState"
    /// <summary>
    ///   <para>rdfs:label : OptimalCalculation^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the optimal calculation for a given property.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#OptimalCalculation">a4bdg:OptimalCalculation</a>
    /// </summary>
    let OptimalCalculation = _prefixId.prefix "OptimalCalculation"
    /// <summary>
    ///   <para>rdfs:label : Ranked Preference^^xsd:string</para>
    ///   <para>rdfs:comment : Describes an ordered list of preferences.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#RankedPreference">a4bdg:RankedPreference</a>
    /// </summary>
    let RankedPreference = _prefixId.prefix "RankedPreference"
    /// <summary>
    ///   <para>rdfs:label : Rating^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the action of someone that rates a thing.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#Rating">a4bdg:Rating</a>
    /// </summary>
    let Rating = _prefixId.prefix "Rating"
    /// <summary>
    ///   <para>rdfs:label : Recommendation System^^xsd:string</para>
    ///   <para>rdfs:comment : Service responsible for providing recommendations to employees.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#RecommendationSystem">a4bdg:RecommendationSystem</a>
    /// </summary>
    let RecommendationSystem = _prefixId.prefix "RecommendationSystem"
    let RoomAcetone = _prefixId.prefix "RoomAcetone"
    let RoomAirQuality = _prefixId.prefix "RoomAirQuality"
    let RoomAlcohol = _prefixId.prefix "RoomAlcohol"
    let RoomCO = _prefixId.prefix "RoomCO"
    let RoomCO2 = _prefixId.prefix "RoomCO2"
    /// <summary>
    ///   <para>rdfs:label : Room Dust^^xsd:string</para>
    ///   <para>rdfs:comment : Groups properties related to the presence of dust in the air of a given room.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#RoomDust">a4bdg:RoomDust</a>
    /// </summary>
    let RoomDust = _prefixId.prefix "RoomDust"
    let RoomEnergy = _prefixId.prefix "RoomEnergy"
    /// <summary>
    ///   <para>rdfs:label : Room Gas^^xsd:string</para>
    ///   <para>rdfs:comment : Groups properties related to the presence of gas in the air of a given room.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#RoomGas">a4bdg:RoomGas</a>
    /// </summary>
    let RoomGas = _prefixId.prefix "RoomGas"
    let RoomHealth = _prefixId.prefix "RoomHealth"
    let RoomHumidity = _prefixId.prefix "RoomHumidity"
    let RoomNH4 = _prefixId.prefix "RoomNH4"
    let RoomPM1 = _prefixId.prefix "RoomPM1"
    let RoomPM10 = _prefixId.prefix "RoomPM10"
    let ``RoomPM2.5`` = _prefixId.prefix "RoomPM2.5"
    let RoomPower = _prefixId.prefix "RoomPower"
    let RoomPressure = _prefixId.prefix "RoomPressure"
    /// <summary>
    ///   <para>rdfs:label : Room Property^^xsd:string</para>
    ///   <para>rdfs:comment : Represents an observable property of a given room.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#RoomProperty">a4bdg:RoomProperty</a>
    /// </summary>
    let RoomProperty = _prefixId.prefix "RoomProperty"
    let RoomTemperature = _prefixId.prefix "RoomTemperature"
    let RoomToluene = _prefixId.prefix "RoomToluene"
    let air_quality = _prefixId.prefix "air_quality"
    /// <summary>
    ///   <para>rdfs:label : calculates^^xsd:string</para>
    ///   <para>rdfs:comment : Relates an optimal calculation of property.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#calculates">a4bdg:calculates</a>
    /// </summary>
    let calculates = _prefixId.prefix "calculates"
    let closedState = _prefixId.prefix "closedState"
    let environmental = _prefixId.prefix "environmental"
    let environmental_dust = _prefixId.prefix "environmental_dust"
    let environmental_gasses = _prefixId.prefix "environmental_gasses"
    let environmental_nop = _prefixId.prefix "environmental_nop"
    /// <summary>
    ///   <para>rdfs:label : forecasts^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a forecast with the predicted property.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#forecasts">a4bdg:forecasts</a>
    /// </summary>
    let forecasts = _prefixId.prefix "forecasts"
    /// <summary>
    ///   <para>rdfs:label : has ranked preference^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a person with a ranked preference.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#hasRankedPreference">a4bdg:hasRankedPreference</a>
    /// </summary>
    let hasRankedPreference = _prefixId.prefix "hasRankedPreference"
    /// <summary>
    ///   <para>rdfs:label : is available^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes whether a desk is available or not.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#isAvailable">a4bdg:isAvailable</a>
    /// </summary>
    let isAvailable = _prefixId.prefix "isAvailable"
    /// <summary>
    ///   <para>rdfs:label : is contained in room^^xsd:string</para>
    ///   <para>rdfs:comment : Refers to a thing that is contained within a room.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#isContainedInRoom">a4bdg:isContainedInRoom</a>
    /// </summary>
    let isContainedInRoom = _prefixId.prefix "isContainedInRoom"
    /// <summary>
    ///   <para>rdfs:label : is contained in zone^^xsd:string</para>
    ///   <para>rdfs:comment : Refers to a thing that is contained within a zone.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#isContainedInZone">a4bdg:isContainedInZone</a>
    /// </summary>
    let isContainedInZone = _prefixId.prefix "isContainedInZone"
    /// <summary>
    ///   <para>rdfs:label : is located in storey^^xsd:string</para>
    ///   <para>rdfs:comment : Refers to a thing that is located in a storey.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#isLocatedInStorey">a4bdg:isLocatedInStorey</a>
    /// </summary>
    let isLocatedInStorey = _prefixId.prefix "isLocatedInStorey"
    let offState = _prefixId.prefix "offState"
    let onState = _prefixId.prefix "onState"
    let openState = _prefixId.prefix "openState"
    let power_meter = _prefixId.prefix "power_meter"
    /// <summary>
    ///   <para>rdfs:label : preference object^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a ranked preference with the preferred thing.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#preferenceObject">a4bdg:preferenceObject</a>
    /// </summary>
    let preferenceObject = _prefixId.prefix "preferenceObject"
    /// <summary>
    ///   <para>rdfs:label : present in building^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes the presence of a person inside a building.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#presentInBuilding">a4bdg:presentInBuilding</a>
    /// </summary>
    let presentInBuilding = _prefixId.prefix "presentInBuilding"
    /// <summary>
    ///   <para>rdfs:label : rating author^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a person with a rating.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#ratingAuthor">a4bdg:ratingAuthor</a>
    /// </summary>
    let ratingAuthor = _prefixId.prefix "ratingAuthor"
    /// <summary>
    ///   <para>rdfs:label : rating target^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a rating with the rated thing.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#ratingTarget">a4bdg:ratingTarget</a>
    /// </summary>
    let ratingTarget = _prefixId.prefix "ratingTarget"
    /// <summary>
    ///   <para>rdfs:label : rating value^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the value of the rating.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#ratingValue">a4bdg:ratingValue</a>
    /// </summary>
    let ratingValue = _prefixId.prefix "ratingValue"
    /// <summary>
    ///   <para>rdfs:label : room placement^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the location where the sensor is placed, i.e., indoors or outdoors.^^xsd:string</para>
    ///   <a href="https://w3id.org/aerOS/building#roomPlacement">a4bdg:roomPlacement</a>
    /// </summary>
    let roomPlacement = _prefixId.prefix "roomPlacement"
    let smart_switch = _prefixId.prefix "smart_switch"
