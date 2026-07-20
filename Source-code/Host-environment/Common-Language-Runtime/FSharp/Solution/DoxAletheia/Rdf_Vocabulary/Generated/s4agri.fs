namespace https.saref.etsi.org.saref4agri.slash

open DoxAletheia

module s4agri =
    let _namespace_name = "https://saref.etsi.org/saref4agri/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://saref.etsi.org/saref4agri/v1.1.2/"></see>
    /// </summary>
    let ``v1.1.2/`` = _prefix "v1.1.2/"
    /// <summary>
    /// The degree or intensity of heat present in the air.
    /// <see href="https://saref.etsi.org/saref4agri/AirTemperature"></see></summary>
    let AirTemperature = _prefix "AirTemperature"
    /// <summary>
    /// The amount of water vapour in the air.
    /// <see href="https://saref.etsi.org/saref4agri/AmbientHumidity"></see></summary>
    let AmbientHumidity = _prefix "AmbientHumidity"
    /// <summary>
    /// An individual and identifiable living organism that feeds on organic matter, typically having specialized sense organs and nervous system and able to respond rapidly to stimuli.
    /// <see href="https://saref.etsi.org/saref4agri/Animal"></see></summary>
    let Animal = _prefix "Animal"
    /// <summary>
    /// A relation to express the birth date of an animal.
    /// <see href="https://saref.etsi.org/saref4agri/hasBirthDate"></see></summary>
    let hasBirthDate = _prefix "hasBirthDate"
    /// <summary>
    /// A relation to express the name of an entity (e.g.,animal).
    /// <see href="https://saref.etsi.org/saref4agri/hasName"></see></summary>
    let hasName = _prefix "hasName"
    /// <summary>
    /// ID
    /// <see href="https://saref.etsi.org/saref4agri/ID"></see></summary>
    let ID = _prefix "ID"
    /// <summary>
    /// A relation to express the unique identifier of an animal.
    /// <see href="https://saref.etsi.org/saref4agri/hasID"></see></summary>
    let hasID = _prefix "hasID"
    /// <summary>
    /// A relation to express the death date of an animal.
    /// <see href="https://saref.etsi.org/saref4agri/hasDeathDate"></see></summary>
    let hasDeathDate = _prefix "hasDeathDate"
    /// <summary>
    /// A collection of one or multiple animals.
    /// <see href="https://saref.etsi.org/saref4agri/AnimalGroup"></see></summary>
    let AnimalGroup = _prefix "AnimalGroup"
    /// <summary>
    /// A relation to express that an animal can be part of groups.
    /// <see href="https://saref.etsi.org/saref4agri/isMemberOf"></see></summary>
    let isMemberOf = _prefix "isMemberOf"
    /// <summary>
    /// A relation to express the physical location of a saref4agri entity (e.g., an animal)
    /// <see href="https://saref.etsi.org/saref4agri/isLocatedIn"></see></summary>
    let isLocatedIn = _prefix "isLocatedIn"
    /// <summary>
    /// A relation to represent  the members of an AnimalGroup.
    /// <see href="https://saref.etsi.org/saref4agri/hasMember"></see></summary>
    let hasMember = _prefix "hasMember"
    /// <summary>
    /// A building represents a structure that provides shelter for its occupants or contents and stands in one place. The building is also used to provide a basic element within the spatial structure hierarchy for the components of a building project (together with site, storey, and space).
    /// <see href="https://saref.etsi.org/saref4agri/Building"></see></summary>
    let Building = _prefix "Building"
    /// <summary>
    /// An entity used to define the physical spaces of the building. A building space contains devices or building objects.
    /// <see href="https://saref.etsi.org/saref4agri/BuildingSpace"></see></summary>
    let BuildingSpace = _prefix "BuildingSpace"
    /// <summary>
    /// contains
    /// <see href="https://saref.etsi.org/saref4agri/contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    /// A collection of cultivated plants that is grown on a large scale commercially, especially a cereal, fruit, or vegetable.
    /// <see href="https://saref.etsi.org/saref4agri/Crop"></see></summary>
    let Crop = _prefix "Crop"
    /// <summary>
    /// A relation to express the day the crop is planted.
    /// <see href="https://saref.etsi.org/saref4agri/hasPlantDate"></see></summary>
    let hasPlantDate = _prefix "hasPlantDate"
    /// <summary>
    /// A relation to express the day the crop is harvested.
    /// <see href="https://saref.etsi.org/saref4agri/hasHarvestDate"></see></summary>
    let hasHarvestDate = _prefix "hasHarvestDate"
    /// <summary>
    /// The scenario, including temporal and spatial information, in which the systems and devices are installed.
    /// Deployment
    /// <see href="https://saref.etsi.org/saref4agri/Deployment"></see></summary>
    let Deployment = _prefix "Deployment"
    /// <summary>
    /// is deployed at space
    /// Relation to indicate the geographical componet of a deployment.
    /// <see href="https://saref.etsi.org/saref4agri/isDeployedAtSpace"></see></summary>
    let isDeployedAtSpace = _prefix "isDeployedAtSpace"
    /// <summary>
    /// has deployment period
    /// Relation to indicate the temporal duration or period of a deployment.
    /// <see href="https://saref.etsi.org/saref4agri/hasDeploymentPeriod"></see></summary>
    let hasDeploymentPeriod = _prefix "hasDeploymentPeriod"
    /// <summary>
    /// Eating activity sensor
    /// <see href="https://saref.etsi.org/saref4agri/EatingActivitySensor"></see></summary>
    let EatingActivitySensor = _prefix "EatingActivitySensor"
    /// <summary>
    /// A plot of land used for the scope of farming which can contain buildings and parcels.
    /// <see href="https://saref.etsi.org/saref4agri/Farm"></see></summary>
    let Farm = _prefix "Farm"
    /// <summary>
    /// An area of land, which might be used for grazing animals or planting crops. The parcel is defined as an undividable logical area of land which contains homogeneous items.
    /// <see href="https://saref.etsi.org/saref4agri/Parcel"></see></summary>
    let Parcel = _prefix "Parcel"
    /// <summary>
    /// A class to decsribe a saref4agri farm holding as subcass of an org:Organization
    /// <see href="https://saref.etsi.org/saref4agri/FarmHolding"></see></summary>
    let FarmHolding = _prefix "FarmHolding"
    /// <summary>
    /// manages farm
    /// <see href="https://saref.etsi.org/saref4agri/managesFarm"></see></summary>
    let managesFarm = _prefix "managesFarm"
    /// <summary>
    /// A class to decsribe a saref4agri farmer as subcass of a foaf:Person
    /// <see href="https://saref.etsi.org/saref4agri/Farmer"></see></summary>
    let Farmer = _prefix "Farmer"
    /// <summary>
    /// The amount of food or other substance taken into the body of an animal or into the soil.
    /// <see href="https://saref.etsi.org/saref4agri/Intake"></see></summary>
    let Intake = _prefix "Intake"
    /// <summary>
    /// The amount of water falling in the soil by irrigation methods.
    /// <see href="https://saref.etsi.org/saref4agri/IrrigationWater"></see></summary>
    let IrrigationWater = _prefix "IrrigationWater"
    /// <summary>
    /// Milking sensor
    /// <see href="https://saref.etsi.org/saref4agri/MilkingSensor"></see></summary>
    let MilkingSensor = _prefix "MilkingSensor"
    /// <summary>
    /// Movement activity sensor
    /// <see href="https://saref.etsi.org/saref4agri/MovementActivitySensor"></see></summary>
    let MovementActivitySensor = _prefix "MovementActivitySensor"
    /// <summary>
    /// The level or stage of growth of the plant.
    /// <see href="https://saref.etsi.org/saref4agri/PlantGrowthStage"></see></summary>
    let PlantGrowthStage = _prefix "PlantGrowthStage"
    /// <summary>
    /// Platform
    /// <see href="https://saref.etsi.org/saref4agri/Platform"></see></summary>
    let Platform = _prefix "Platform"
    /// <summary>
    /// A sensor that measures the rain fall.
    /// <see href="https://saref.etsi.org/saref4agri/Pluviometer"></see></summary>
    let Pluviometer = _prefix "Pluviometer"
    /// <summary>
    /// The amount of water falling in the soil by natural process (e.g. rain).
    /// <see href="https://saref.etsi.org/saref4agri/Precipitation"></see></summary>
    let Precipitation = _prefix "Precipitation"
    /// <summary>
    /// Upper layer of the earth in which plants grow.
    /// <see href="https://saref.etsi.org/saref4agri/Soil"></see></summary>
    let Soil = _prefix "Soil"
    /// <summary>
    /// The amount of water or humidity contained in the soil.
    /// <see href="https://saref.etsi.org/saref4agri/SoilMoisture"></see></summary>
    let SoilMoisture = _prefix "SoilMoisture"
    /// <summary>
    /// The degree or intensity of heat present in the soil.
    /// <see href="https://saref.etsi.org/saref4agri/SoilTemperature"></see></summary>
    let SoilTemperature = _prefix "SoilTemperature"
    /// <summary>
    /// A sensor that measures the soil moisture.
    /// <see href="https://saref.etsi.org/saref4agri/SoilTensiometer"></see></summary>
    let SoilTensiometer = _prefix "SoilTensiometer"
    /// <summary>
    /// Thermometer
    /// <see href="https://saref.etsi.org/saref4agri/Thermometer"></see></summary>
    let Thermometer = _prefix "Thermometer"
    /// <summary>
    /// An actuator to irrigate an space.
    /// <see href="https://saref.etsi.org/saref4agri/WateringGun"></see></summary>
    let WateringGun = _prefix "WateringGun"
    /// <summary>
    /// Watering system
    /// <see href="https://saref.etsi.org/saref4agri/WateringSystem"></see></summary>
    let WateringSystem = _prefix "WateringSystem"
    /// <summary>
    /// Watering valve
    /// <see href="https://saref.etsi.org/saref4agri/WateringValve"></see></summary>
    let WateringValve = _prefix "WateringValve"
    /// <summary>
    /// A sensor o system that measure weather conditions.
    /// <see href="https://saref.etsi.org/saref4agri/WeatherStation"></see></summary>
    let WeatherStation = _prefix "WeatherStation"
    /// <summary>
    /// Weight sensor
    /// <see href="https://saref.etsi.org/saref4agri/WeightSensor"></see></summary>
    let WeightSensor = _prefix "WeightSensor"
    /// <summary>
    /// The produced amount of food for animals or of agricultural products.
    /// <see href="https://saref.etsi.org/saref4agri/Yield"></see></summary>
    let Yield = _prefix "Yield"
    /// <summary>
    /// is contained in
    /// <see href="https://saref.etsi.org/saref4agri/isContainedIn"></see></summary>
    let isContainedIn = _prefix "isContainedIn"
    /// <summary>
    /// A relation to represent the yield generated by a Crop.
    /// <see href="https://saref.etsi.org/saref4agri/generates"></see></summary>
    let generates = _prefix "generates"
    /// <summary>
    /// has received
    /// <see href="https://saref.etsi.org/saref4agri/hasReceived"></see></summary>
    let hasReceived = _prefix "hasReceived"
    /// <summary>
    /// A relation to represent the intake/consumption of certain substances in a Crop.
    /// <see href="https://saref.etsi.org/saref4agri/receives"></see></summary>
    let receives = _prefix "receives"
    /// <summary>
    /// is location of
    /// <see href="https://saref.etsi.org/saref4agri/isLocationOf"></see></summary>
    let isLocationOf = _prefix "isLocationOf"
