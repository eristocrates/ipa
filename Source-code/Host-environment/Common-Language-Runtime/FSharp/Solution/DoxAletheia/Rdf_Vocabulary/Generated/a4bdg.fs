namespace https.w3id.org.aerOS.building.hash

open DoxAletheia.Rdf_Vocabulary

module a4bdg =
    let _namespace_name = "https://w3id.org/aerOS/building#"
    /// <summary>
    /// Working place composed of table, chair, and display.
    /// <see href="https://w3id.org/aerOS/building#Desk"></see></summary>
    let Desk = Namespaced_IRI.parse _namespace_name "Desk" |> NamespacedName

    /// <summary>
    /// Service responsible for providing recommendations to employees.
    /// <see href="https://w3id.org/aerOS/building#RecommendationSystem"></see></summary>
    let RecommendationSystem =
        Namespaced_IRI.parse _namespace_name "RecommendationSystem" |> NamespacedName

    /// <summary>
    /// Represents a prediction for a property.
    /// <see href="https://w3id.org/aerOS/building#Forecast"></see></summary>
    let Forecast = Namespaced_IRI.parse _namespace_name "Forecast" |> NamespacedName
    /// <summary>
    /// Denotes a device whose state can be on or off, such as a smart switch.
    /// <see href="https://w3id.org/aerOS/building#OnOffState"></see></summary>
    let OnOffState = Namespaced_IRI.parse _namespace_name "OnOffState" |> NamespacedName

    /// <summary>
    /// Denotes a device whose state can be open or closed, such as a window or a door.
    /// <see href="https://w3id.org/aerOS/building#OpenClosedState"></see></summary>
    let OpenClosedState =
        Namespaced_IRI.parse _namespace_name "OpenClosedState" |> NamespacedName

    /// <summary>
    /// Represents the optimal calculation for a given property.
    /// <see href="https://w3id.org/aerOS/building#OptimalCalculation"></see></summary>
    let OptimalCalculation =
        Namespaced_IRI.parse _namespace_name "OptimalCalculation" |> NamespacedName

    /// <summary>
    /// Describes an ordered list of preferences.
    /// <see href="https://w3id.org/aerOS/building#RankedPreference"></see></summary>
    let RankedPreference =
        Namespaced_IRI.parse _namespace_name "RankedPreference" |> NamespacedName

    /// <summary>
    /// Represents the action of someone that rates a thing.
    /// <see href="https://w3id.org/aerOS/building#Rating"></see></summary>
    let Rating = Namespaced_IRI.parse _namespace_name "Rating" |> NamespacedName

    /// <summary>
    /// Property that represents the amount of acetone present in the air a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomAcetone"></see></summary>
    let RoomAcetone =
        Namespaced_IRI.parse _namespace_name "RoomAcetone" |> NamespacedName

    /// <summary>
    /// Groups properties related to the presence of gas in the air of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomGas"></see></summary>
    let RoomGas = Namespaced_IRI.parse _namespace_name "RoomGas" |> NamespacedName

    /// <summary>
    /// Property that represents the air quality index (AQI) of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomAirQuality"></see></summary>
    let RoomAirQuality =
        Namespaced_IRI.parse _namespace_name "RoomAirQuality" |> NamespacedName

    /// <summary>
    /// Represents an observable property of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomProperty"></see></summary>
    let RoomProperty =
        Namespaced_IRI.parse _namespace_name "RoomProperty" |> NamespacedName

    /// <summary>
    /// Property that represents the amount of alcohol present in the air a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomAlcohol"></see></summary>
    let RoomAlcohol =
        Namespaced_IRI.parse _namespace_name "RoomAlcohol" |> NamespacedName

    /// <summary>
    /// Property that represents the amount of carbon monoxide (CO) present in the air a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomCO"></see></summary>
    let RoomCO = Namespaced_IRI.parse _namespace_name "RoomCO" |> NamespacedName
    /// <summary>
    /// Property that represents the amount of carbon dioxide (CO2) present in the air a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomCO2"></see></summary>
    let RoomCO2 = Namespaced_IRI.parse _namespace_name "RoomCO2" |> NamespacedName
    /// <summary>
    /// Groups properties related to the presence of dust in the air of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomDust"></see></summary>
    let RoomDust = Namespaced_IRI.parse _namespace_name "RoomDust" |> NamespacedName
    /// <summary>
    /// Property that represents the energy consumed by a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomEnergy"></see></summary>
    let RoomEnergy = Namespaced_IRI.parse _namespace_name "RoomEnergy" |> NamespacedName
    /// <summary>
    /// Property that represents the health of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomHealth"></see></summary>
    let RoomHealth = Namespaced_IRI.parse _namespace_name "RoomHealth" |> NamespacedName

    /// <summary>
    /// Property that represents the humidity of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomHumidity"></see></summary>
    let RoomHumidity =
        Namespaced_IRI.parse _namespace_name "RoomHumidity" |> NamespacedName

    /// <summary>
    /// Property that represents the amount of ammonium (NH4) present in the air a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomNH4"></see></summary>
    let RoomNH4 = Namespaced_IRI.parse _namespace_name "RoomNH4" |> NamespacedName
    /// <summary>
    /// Property that represents the air quality index (AQI) of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomPM1"></see></summary>
    let RoomPM1 = Namespaced_IRI.parse _namespace_name "RoomPM1" |> NamespacedName
    /// <summary>
    /// Property that represents the air quality index (AQI) of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomPM10"></see></summary>
    let RoomPM10 = Namespaced_IRI.parse _namespace_name "RoomPM10" |> NamespacedName

    /// <summary>
    /// Property that represents the air quality index (AQI) of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomPM2.5"></see></summary>
    let ``RoomPM2.5`` =
        Namespaced_IRI.parse _namespace_name "RoomPM2.5" |> NamespacedName

    /// <summary>
    /// Property that represents the power consumed by a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomPower"></see></summary>
    let RoomPower = Namespaced_IRI.parse _namespace_name "RoomPower" |> NamespacedName

    /// <summary>
    /// Property that represents the pressure of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomPressure"></see></summary>
    let RoomPressure =
        Namespaced_IRI.parse _namespace_name "RoomPressure" |> NamespacedName

    /// <summary>
    /// Property that represents the temperature of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomTemperature"></see></summary>
    let RoomTemperature =
        Namespaced_IRI.parse _namespace_name "RoomTemperature" |> NamespacedName

    /// <summary>
    /// Property that represents the amount of toluene present in the air a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomToluene"></see></summary>
    let RoomToluene =
        Namespaced_IRI.parse _namespace_name "RoomToluene" |> NamespacedName

    /// <summary>
    /// Type of sensor that measures air quality index (AQI) property of a room.
    /// <see href="https://w3id.org/aerOS/building#air_quality"></see></summary>
    let air_quality =
        Namespaced_IRI.parse _namespace_name "air_quality" |> NamespacedName

    /// <summary>
    /// Relates an optimal calculation of property.
    /// <see href="https://w3id.org/aerOS/building#calculates"></see></summary>
    let calculates = Namespaced_IRI.parse _namespace_name "calculates" |> NamespacedName

    /// <summary>
    /// Denotes a device whose state is closed.
    /// <see href="https://w3id.org/aerOS/building#closedState"></see></summary>
    let closedState =
        Namespaced_IRI.parse _namespace_name "closedState" |> NamespacedName

    /// <summary>
    /// Type of sensor that measures temperature, humidity, and pressure properties of a room.
    /// <see href="https://w3id.org/aerOS/building#environmental"></see></summary>
    let environmental =
        Namespaced_IRI.parse _namespace_name "environmental" |> NamespacedName

    /// <summary>
    /// Type of sensor that measures dust properties of a room.
    /// <see href="https://w3id.org/aerOS/building#environmental_dust"></see></summary>
    let environmental_dust =
        Namespaced_IRI.parse _namespace_name "environmental_dust" |> NamespacedName

    /// <summary>
    /// Type of sensor that measures gas properties of a room.
    /// <see href="https://w3id.org/aerOS/building#environmental_gasses"></see></summary>
    let environmental_gasses =
        Namespaced_IRI.parse _namespace_name "environmental_gasses" |> NamespacedName

    /// <summary>
    /// Type of sensor that measures temperature and humidity properties of a room.
    /// <see href="https://w3id.org/aerOS/building#environmental_nop"></see></summary>
    let environmental_nop =
        Namespaced_IRI.parse _namespace_name "environmental_nop" |> NamespacedName

    /// <summary>
    /// Relates a forecast with the predicted property.
    /// <see href="https://w3id.org/aerOS/building#forecasts"></see></summary>
    let forecasts = Namespaced_IRI.parse _namespace_name "forecasts" |> NamespacedName

    /// <summary>
    /// Relates a person with a ranked preference.
    /// <see href="https://w3id.org/aerOS/building#hasRankedPreference"></see></summary>
    let hasRankedPreference =
        Namespaced_IRI.parse _namespace_name "hasRankedPreference" |> NamespacedName

    /// <summary>
    /// Denotes whether a desk is available or not.
    /// <see href="https://w3id.org/aerOS/building#isAvailable"></see></summary>
    let isAvailable =
        Namespaced_IRI.parse _namespace_name "isAvailable" |> NamespacedName

    /// <summary>
    /// Refers to a thing that is contained within a room.
    /// <see href="https://w3id.org/aerOS/building#isContainedInRoom"></see></summary>
    let isContainedInRoom =
        Namespaced_IRI.parse _namespace_name "isContainedInRoom" |> NamespacedName

    /// <summary>
    /// Refers to a thing that is contained within a zone.
    /// <see href="https://w3id.org/aerOS/building#isContainedInZone"></see></summary>
    let isContainedInZone =
        Namespaced_IRI.parse _namespace_name "isContainedInZone" |> NamespacedName

    /// <summary>
    /// Refers to a thing that is located in a storey.
    /// <see href="https://w3id.org/aerOS/building#isLocatedInStorey"></see></summary>
    let isLocatedInStorey =
        Namespaced_IRI.parse _namespace_name "isLocatedInStorey" |> NamespacedName

    /// <summary>
    /// Denotes a device whose state is off.
    /// <see href="https://w3id.org/aerOS/building#offState"></see></summary>
    let offState = Namespaced_IRI.parse _namespace_name "offState" |> NamespacedName
    /// <summary>
    /// Denotes a device whose state is on.
    /// <see href="https://w3id.org/aerOS/building#onState"></see></summary>
    let onState = Namespaced_IRI.parse _namespace_name "onState" |> NamespacedName
    /// <summary>
    /// Denotes a device whose state is open.
    /// <see href="https://w3id.org/aerOS/building#openState"></see></summary>
    let openState = Namespaced_IRI.parse _namespace_name "openState" |> NamespacedName

    /// <summary>
    /// Type of sensor that measures the energy and power consumption of a room.
    /// <see href="https://w3id.org/aerOS/building#power_meter"></see></summary>
    let power_meter =
        Namespaced_IRI.parse _namespace_name "power_meter" |> NamespacedName

    /// <summary>
    /// Relates a ranked preference with the preferred thing.
    /// <see href="https://w3id.org/aerOS/building#preferenceObject"></see></summary>
    let preferenceObject =
        Namespaced_IRI.parse _namespace_name "preferenceObject" |> NamespacedName

    /// <summary>
    /// Denotes the presence of a person inside a building.
    /// <see href="https://w3id.org/aerOS/building#presentInBuilding"></see></summary>
    let presentInBuilding =
        Namespaced_IRI.parse _namespace_name "presentInBuilding" |> NamespacedName

    /// <summary>
    /// Relates a person with a rating.
    /// <see href="https://w3id.org/aerOS/building#ratingAuthor"></see></summary>
    let ratingAuthor =
        Namespaced_IRI.parse _namespace_name "ratingAuthor" |> NamespacedName

    /// <summary>
    /// Relates a rating with the rated thing.
    /// <see href="https://w3id.org/aerOS/building#ratingTarget"></see></summary>
    let ratingTarget =
        Namespaced_IRI.parse _namespace_name "ratingTarget" |> NamespacedName

    /// <summary>
    /// Represents the value of the rating.
    /// <see href="https://w3id.org/aerOS/building#ratingValue"></see></summary>
    let ratingValue =
        Namespaced_IRI.parse _namespace_name "ratingValue" |> NamespacedName

    /// <summary>
    /// Represents the location where the sensor is placed, i.e., indoors or outdoors.
    /// <see href="https://w3id.org/aerOS/building#roomPlacement"></see></summary>
    let roomPlacement =
        Namespaced_IRI.parse _namespace_name "roomPlacement" |> NamespacedName

    /// <summary>
    /// Type of switch that measures the energy and power consumption of a room.
    /// <see href="https://w3id.org/aerOS/building#smart_switch"></see></summary>
    let smart_switch =
        Namespaced_IRI.parse _namespace_name "smart_switch" |> NamespacedName
