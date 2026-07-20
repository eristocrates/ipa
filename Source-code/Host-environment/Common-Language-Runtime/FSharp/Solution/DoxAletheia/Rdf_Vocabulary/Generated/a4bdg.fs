namespace https.w3id.org.aerOS.building.hash

open DoxAletheia

module a4bdg =
    let _namespace_name = "https://w3id.org/aerOS/building#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Working place composed of table, chair, and display.
    /// <see href="https://w3id.org/aerOS/building#Desk"></see></summary>
    let Desk = _prefix "Desk"
    /// <summary>
    /// Service responsible for providing recommendations to employees.
    /// <see href="https://w3id.org/aerOS/building#RecommendationSystem"></see></summary>
    let RecommendationSystem = _prefix "RecommendationSystem"
    /// <summary>
    /// Represents a prediction for a property.
    /// <see href="https://w3id.org/aerOS/building#Forecast"></see></summary>
    let Forecast = _prefix "Forecast"
    /// <summary>
    /// Denotes a device whose state can be on or off, such as a smart switch.
    /// <see href="https://w3id.org/aerOS/building#OnOffState"></see></summary>
    let OnOffState = _prefix "OnOffState"
    /// <summary>
    /// Denotes a device whose state can be open or closed, such as a window or a door.
    /// <see href="https://w3id.org/aerOS/building#OpenClosedState"></see></summary>
    let OpenClosedState = _prefix "OpenClosedState"
    /// <summary>
    /// Represents the optimal calculation for a given property.
    /// <see href="https://w3id.org/aerOS/building#OptimalCalculation"></see></summary>
    let OptimalCalculation = _prefix "OptimalCalculation"
    /// <summary>
    /// Describes an ordered list of preferences.
    /// <see href="https://w3id.org/aerOS/building#RankedPreference"></see></summary>
    let RankedPreference = _prefix "RankedPreference"
    /// <summary>
    /// Represents the action of someone that rates a thing.
    /// <see href="https://w3id.org/aerOS/building#Rating"></see></summary>
    let Rating = _prefix "Rating"
    /// <summary>
    /// Property that represents the amount of acetone present in the air a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomAcetone"></see></summary>
    let RoomAcetone = _prefix "RoomAcetone"
    /// <summary>
    /// Groups properties related to the presence of gas in the air of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomGas"></see></summary>
    let RoomGas = _prefix "RoomGas"
    /// <summary>
    /// Property that represents the air quality index (AQI) of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomAirQuality"></see></summary>
    let RoomAirQuality = _prefix "RoomAirQuality"
    /// <summary>
    /// Represents an observable property of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomProperty"></see></summary>
    let RoomProperty = _prefix "RoomProperty"
    /// <summary>
    /// Property that represents the amount of alcohol present in the air a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomAlcohol"></see></summary>
    let RoomAlcohol = _prefix "RoomAlcohol"
    /// <summary>
    /// Property that represents the amount of carbon monoxide (CO) present in the air a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomCO"></see></summary>
    let RoomCO = _prefix "RoomCO"
    /// <summary>
    /// Property that represents the amount of carbon dioxide (CO2) present in the air a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomCO2"></see></summary>
    let RoomCO2 = _prefix "RoomCO2"
    /// <summary>
    /// Groups properties related to the presence of dust in the air of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomDust"></see></summary>
    let RoomDust = _prefix "RoomDust"
    /// <summary>
    /// Property that represents the energy consumed by a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomEnergy"></see></summary>
    let RoomEnergy = _prefix "RoomEnergy"
    /// <summary>
    /// Property that represents the health of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomHealth"></see></summary>
    let RoomHealth = _prefix "RoomHealth"
    /// <summary>
    /// Property that represents the humidity of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomHumidity"></see></summary>
    let RoomHumidity = _prefix "RoomHumidity"
    /// <summary>
    /// Property that represents the amount of ammonium (NH4) present in the air a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomNH4"></see></summary>
    let RoomNH4 = _prefix "RoomNH4"
    /// <summary>
    /// Property that represents the air quality index (AQI) of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomPM1"></see></summary>
    let RoomPM1 = _prefix "RoomPM1"
    /// <summary>
    /// Property that represents the air quality index (AQI) of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomPM10"></see></summary>
    let RoomPM10 = _prefix "RoomPM10"
    /// <summary>
    /// Property that represents the air quality index (AQI) of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomPM2.5"></see></summary>
    let ``RoomPM2.5`` = _prefix "RoomPM2.5"
    /// <summary>
    /// Property that represents the power consumed by a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomPower"></see></summary>
    let RoomPower = _prefix "RoomPower"
    /// <summary>
    /// Property that represents the pressure of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomPressure"></see></summary>
    let RoomPressure = _prefix "RoomPressure"
    /// <summary>
    /// Property that represents the temperature of a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomTemperature"></see></summary>
    let RoomTemperature = _prefix "RoomTemperature"
    /// <summary>
    /// Property that represents the amount of toluene present in the air a given room.
    /// <see href="https://w3id.org/aerOS/building#RoomToluene"></see></summary>
    let RoomToluene = _prefix "RoomToluene"
    /// <summary>
    /// Type of sensor that measures air quality index (AQI) property of a room.
    /// <see href="https://w3id.org/aerOS/building#air_quality"></see></summary>
    let air_quality = _prefix "air_quality"
    /// <summary>
    /// Relates an optimal calculation of property.
    /// <see href="https://w3id.org/aerOS/building#calculates"></see></summary>
    let calculates = _prefix "calculates"
    /// <summary>
    /// Denotes a device whose state is closed.
    /// <see href="https://w3id.org/aerOS/building#closedState"></see></summary>
    let closedState = _prefix "closedState"
    /// <summary>
    /// Type of sensor that measures temperature, humidity, and pressure properties of a room.
    /// <see href="https://w3id.org/aerOS/building#environmental"></see></summary>
    let environmental = _prefix "environmental"
    /// <summary>
    /// Type of sensor that measures dust properties of a room.
    /// <see href="https://w3id.org/aerOS/building#environmental_dust"></see></summary>
    let environmental_dust = _prefix "environmental_dust"
    /// <summary>
    /// Type of sensor that measures gas properties of a room.
    /// <see href="https://w3id.org/aerOS/building#environmental_gasses"></see></summary>
    let environmental_gasses = _prefix "environmental_gasses"
    /// <summary>
    /// Type of sensor that measures temperature and humidity properties of a room.
    /// <see href="https://w3id.org/aerOS/building#environmental_nop"></see></summary>
    let environmental_nop = _prefix "environmental_nop"
    /// <summary>
    /// Relates a forecast with the predicted property.
    /// <see href="https://w3id.org/aerOS/building#forecasts"></see></summary>
    let forecasts = _prefix "forecasts"
    /// <summary>
    /// Relates a person with a ranked preference.
    /// <see href="https://w3id.org/aerOS/building#hasRankedPreference"></see></summary>
    let hasRankedPreference = _prefix "hasRankedPreference"
    /// <summary>
    /// Denotes whether a desk is available or not.
    /// <see href="https://w3id.org/aerOS/building#isAvailable"></see></summary>
    let isAvailable = _prefix "isAvailable"
    /// <summary>
    /// Refers to a thing that is contained within a room.
    /// <see href="https://w3id.org/aerOS/building#isContainedInRoom"></see></summary>
    let isContainedInRoom = _prefix "isContainedInRoom"
    /// <summary>
    /// Refers to a thing that is contained within a zone.
    /// <see href="https://w3id.org/aerOS/building#isContainedInZone"></see></summary>
    let isContainedInZone = _prefix "isContainedInZone"
    /// <summary>
    /// Refers to a thing that is located in a storey.
    /// <see href="https://w3id.org/aerOS/building#isLocatedInStorey"></see></summary>
    let isLocatedInStorey = _prefix "isLocatedInStorey"
    /// <summary>
    /// Denotes a device whose state is off.
    /// <see href="https://w3id.org/aerOS/building#offState"></see></summary>
    let offState = _prefix "offState"
    /// <summary>
    /// Denotes a device whose state is on.
    /// <see href="https://w3id.org/aerOS/building#onState"></see></summary>
    let onState = _prefix "onState"
    /// <summary>
    /// Denotes a device whose state is open.
    /// <see href="https://w3id.org/aerOS/building#openState"></see></summary>
    let openState = _prefix "openState"
    /// <summary>
    /// Type of sensor that measures the energy and power consumption of a room.
    /// <see href="https://w3id.org/aerOS/building#power_meter"></see></summary>
    let power_meter = _prefix "power_meter"
    /// <summary>
    /// Relates a ranked preference with the preferred thing.
    /// <see href="https://w3id.org/aerOS/building#preferenceObject"></see></summary>
    let preferenceObject = _prefix "preferenceObject"
    /// <summary>
    /// Denotes the presence of a person inside a building.
    /// <see href="https://w3id.org/aerOS/building#presentInBuilding"></see></summary>
    let presentInBuilding = _prefix "presentInBuilding"
    /// <summary>
    /// Relates a person with a rating.
    /// <see href="https://w3id.org/aerOS/building#ratingAuthor"></see></summary>
    let ratingAuthor = _prefix "ratingAuthor"
    /// <summary>
    /// Relates a rating with the rated thing.
    /// <see href="https://w3id.org/aerOS/building#ratingTarget"></see></summary>
    let ratingTarget = _prefix "ratingTarget"
    /// <summary>
    /// Represents the value of the rating.
    /// <see href="https://w3id.org/aerOS/building#ratingValue"></see></summary>
    let ratingValue = _prefix "ratingValue"
    /// <summary>
    /// Represents the location where the sensor is placed, i.e., indoors or outdoors.
    /// <see href="https://w3id.org/aerOS/building#roomPlacement"></see></summary>
    let roomPlacement = _prefix "roomPlacement"
    /// <summary>
    /// Type of switch that measures the energy and power consumption of a room.
    /// <see href="https://w3id.org/aerOS/building#smart_switch"></see></summary>
    let smart_switch = _prefix "smart_switch"
