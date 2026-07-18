namespace https.saref.etsi.org.saref4agri.slash

open DoxAletheia.Rdf_Vocabulary

module s4agri =
    let _namespace_name = "https://saref.etsi.org/saref4agri/"
    /// <summary>
    ///   <see href="https://saref.etsi.org/saref4agri/v1.1.2/"></see>
    /// </summary>
    let ``v1.1.2/`` = Namespaced_IRI.parse _namespace_name "v1.1.2/" |> NamespacedName

    /// <summary>
    /// The degree or intensity of heat present in the air.
    /// <see href="https://saref.etsi.org/saref4agri/AirTemperature"></see></summary>
    let AirTemperature =
        Namespaced_IRI.parse _namespace_name "AirTemperature" |> NamespacedName

    /// <summary>
    /// The amount of water vapour in the air.
    /// <see href="https://saref.etsi.org/saref4agri/AmbientHumidity"></see></summary>
    let AmbientHumidity =
        Namespaced_IRI.parse _namespace_name "AmbientHumidity" |> NamespacedName

    /// <summary>
    /// An individual and identifiable living organism that feeds on organic matter, typically having specialized sense organs and nervous system and able to respond rapidly to stimuli.
    /// <see href="https://saref.etsi.org/saref4agri/Animal"></see></summary>
    let Animal = Namespaced_IRI.parse _namespace_name "Animal" |> NamespacedName

    /// <summary>
    /// A relation to express the birth date of an animal.
    /// <see href="https://saref.etsi.org/saref4agri/hasBirthDate"></see></summary>
    let hasBirthDate =
        Namespaced_IRI.parse _namespace_name "hasBirthDate" |> NamespacedName

    /// <summary>
    /// A relation to express the name of an entity (e.g.,animal).
    /// <see href="https://saref.etsi.org/saref4agri/hasName"></see></summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName
    /// <summary>
    /// ID
    /// <see href="https://saref.etsi.org/saref4agri/ID"></see></summary>
    let ID = Namespaced_IRI.parse _namespace_name "ID" |> NamespacedName
    /// <summary>
    /// A relation to express the unique identifier of an animal.
    /// <see href="https://saref.etsi.org/saref4agri/hasID"></see></summary>
    let hasID = Namespaced_IRI.parse _namespace_name "hasID" |> NamespacedName

    /// <summary>
    /// A relation to express the death date of an animal.
    /// <see href="https://saref.etsi.org/saref4agri/hasDeathDate"></see></summary>
    let hasDeathDate =
        Namespaced_IRI.parse _namespace_name "hasDeathDate" |> NamespacedName

    /// <summary>
    /// A collection of one or multiple animals.
    /// <see href="https://saref.etsi.org/saref4agri/AnimalGroup"></see></summary>
    let AnimalGroup =
        Namespaced_IRI.parse _namespace_name "AnimalGroup" |> NamespacedName

    /// <summary>
    /// A relation to express that an animal can be part of groups.
    /// <see href="https://saref.etsi.org/saref4agri/isMemberOf"></see></summary>
    let isMemberOf = Namespaced_IRI.parse _namespace_name "isMemberOf" |> NamespacedName

    /// <summary>
    /// A relation to express the physical location of a saref4agri entity (e.g., an animal)
    /// <see href="https://saref.etsi.org/saref4agri/isLocatedIn"></see></summary>
    let isLocatedIn =
        Namespaced_IRI.parse _namespace_name "isLocatedIn" |> NamespacedName

    /// <summary>
    /// A relation to represent  the members of an AnimalGroup.
    /// <see href="https://saref.etsi.org/saref4agri/hasMember"></see></summary>
    let hasMember = Namespaced_IRI.parse _namespace_name "hasMember" |> NamespacedName
    /// <summary>
    /// A building represents a structure that provides shelter for its occupants or contents and stands in one place. The building is also used to provide a basic element within the spatial structure hierarchy for the components of a building project (together with site, storey, and space).
    /// <see href="https://saref.etsi.org/saref4agri/Building"></see></summary>
    let Building = Namespaced_IRI.parse _namespace_name "Building" |> NamespacedName

    /// <summary>
    /// An entity used to define the physical spaces of the building. A building space contains devices or building objects.
    /// <see href="https://saref.etsi.org/saref4agri/BuildingSpace"></see></summary>
    let BuildingSpace =
        Namespaced_IRI.parse _namespace_name "BuildingSpace" |> NamespacedName

    /// <summary>
    /// contains
    /// <see href="https://saref.etsi.org/saref4agri/contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName
    /// <summary>
    /// A collection of cultivated plants that is grown on a large scale commercially, especially a cereal, fruit, or vegetable.
    /// <see href="https://saref.etsi.org/saref4agri/Crop"></see></summary>
    let Crop = Namespaced_IRI.parse _namespace_name "Crop" |> NamespacedName

    /// <summary>
    /// A relation to express the day the crop is planted.
    /// <see href="https://saref.etsi.org/saref4agri/hasPlantDate"></see></summary>
    let hasPlantDate =
        Namespaced_IRI.parse _namespace_name "hasPlantDate" |> NamespacedName

    /// <summary>
    /// A relation to express the day the crop is harvested.
    /// <see href="https://saref.etsi.org/saref4agri/hasHarvestDate"></see></summary>
    let hasHarvestDate =
        Namespaced_IRI.parse _namespace_name "hasHarvestDate" |> NamespacedName

    /// <summary>
    /// The scenario, including temporal and spatial information, in which the systems and devices are installed.
    /// Deployment
    /// <see href="https://saref.etsi.org/saref4agri/Deployment"></see></summary>
    let Deployment = Namespaced_IRI.parse _namespace_name "Deployment" |> NamespacedName

    /// <summary>
    /// is deployed at space
    /// Relation to indicate the geographical componet of a deployment.
    /// <see href="https://saref.etsi.org/saref4agri/isDeployedAtSpace"></see></summary>
    let isDeployedAtSpace =
        Namespaced_IRI.parse _namespace_name "isDeployedAtSpace" |> NamespacedName

    /// <summary>
    /// has deployment period
    /// Relation to indicate the temporal duration or period of a deployment.
    /// <see href="https://saref.etsi.org/saref4agri/hasDeploymentPeriod"></see></summary>
    let hasDeploymentPeriod =
        Namespaced_IRI.parse _namespace_name "hasDeploymentPeriod" |> NamespacedName

    /// <summary>
    /// Eating activity sensor
    /// <see href="https://saref.etsi.org/saref4agri/EatingActivitySensor"></see></summary>
    let EatingActivitySensor =
        Namespaced_IRI.parse _namespace_name "EatingActivitySensor" |> NamespacedName

    /// <summary>
    /// A plot of land used for the scope of farming which can contain buildings and parcels.
    /// <see href="https://saref.etsi.org/saref4agri/Farm"></see></summary>
    let Farm = Namespaced_IRI.parse _namespace_name "Farm" |> NamespacedName
    /// <summary>
    /// An area of land, which might be used for grazing animals or planting crops. The parcel is defined as an undividable logical area of land which contains homogeneous items.
    /// <see href="https://saref.etsi.org/saref4agri/Parcel"></see></summary>
    let Parcel = Namespaced_IRI.parse _namespace_name "Parcel" |> NamespacedName

    /// <summary>
    /// A class to decsribe a saref4agri farm holding as subcass of an org:Organization
    /// <see href="https://saref.etsi.org/saref4agri/FarmHolding"></see></summary>
    let FarmHolding =
        Namespaced_IRI.parse _namespace_name "FarmHolding" |> NamespacedName

    /// <summary>
    /// manages farm
    /// <see href="https://saref.etsi.org/saref4agri/managesFarm"></see></summary>
    let managesFarm =
        Namespaced_IRI.parse _namespace_name "managesFarm" |> NamespacedName

    /// <summary>
    /// A class to decsribe a saref4agri farmer as subcass of a foaf:Person
    /// <see href="https://saref.etsi.org/saref4agri/Farmer"></see></summary>
    let Farmer = Namespaced_IRI.parse _namespace_name "Farmer" |> NamespacedName
    /// <summary>
    /// The amount of food or other substance taken into the body of an animal or into the soil.
    /// <see href="https://saref.etsi.org/saref4agri/Intake"></see></summary>
    let Intake = Namespaced_IRI.parse _namespace_name "Intake" |> NamespacedName

    /// <summary>
    /// The amount of water falling in the soil by irrigation methods.
    /// <see href="https://saref.etsi.org/saref4agri/IrrigationWater"></see></summary>
    let IrrigationWater =
        Namespaced_IRI.parse _namespace_name "IrrigationWater" |> NamespacedName

    /// <summary>
    /// Milking sensor
    /// <see href="https://saref.etsi.org/saref4agri/MilkingSensor"></see></summary>
    let MilkingSensor =
        Namespaced_IRI.parse _namespace_name "MilkingSensor" |> NamespacedName

    /// <summary>
    /// Movement activity sensor
    /// <see href="https://saref.etsi.org/saref4agri/MovementActivitySensor"></see></summary>
    let MovementActivitySensor =
        Namespaced_IRI.parse _namespace_name "MovementActivitySensor" |> NamespacedName

    /// <summary>
    /// The level or stage of growth of the plant.
    /// <see href="https://saref.etsi.org/saref4agri/PlantGrowthStage"></see></summary>
    let PlantGrowthStage =
        Namespaced_IRI.parse _namespace_name "PlantGrowthStage" |> NamespacedName

    /// <summary>
    /// Platform
    /// <see href="https://saref.etsi.org/saref4agri/Platform"></see></summary>
    let Platform = Namespaced_IRI.parse _namespace_name "Platform" |> NamespacedName

    /// <summary>
    /// A sensor that measures the rain fall.
    /// <see href="https://saref.etsi.org/saref4agri/Pluviometer"></see></summary>
    let Pluviometer =
        Namespaced_IRI.parse _namespace_name "Pluviometer" |> NamespacedName

    /// <summary>
    /// The amount of water falling in the soil by natural process (e.g. rain).
    /// <see href="https://saref.etsi.org/saref4agri/Precipitation"></see></summary>
    let Precipitation =
        Namespaced_IRI.parse _namespace_name "Precipitation" |> NamespacedName

    /// <summary>
    /// Upper layer of the earth in which plants grow.
    /// <see href="https://saref.etsi.org/saref4agri/Soil"></see></summary>
    let Soil = Namespaced_IRI.parse _namespace_name "Soil" |> NamespacedName

    /// <summary>
    /// The amount of water or humidity contained in the soil.
    /// <see href="https://saref.etsi.org/saref4agri/SoilMoisture"></see></summary>
    let SoilMoisture =
        Namespaced_IRI.parse _namespace_name "SoilMoisture" |> NamespacedName

    /// <summary>
    /// The degree or intensity of heat present in the soil.
    /// <see href="https://saref.etsi.org/saref4agri/SoilTemperature"></see></summary>
    let SoilTemperature =
        Namespaced_IRI.parse _namespace_name "SoilTemperature" |> NamespacedName

    /// <summary>
    /// A sensor that measures the soil moisture.
    /// <see href="https://saref.etsi.org/saref4agri/SoilTensiometer"></see></summary>
    let SoilTensiometer =
        Namespaced_IRI.parse _namespace_name "SoilTensiometer" |> NamespacedName

    /// <summary>
    /// Thermometer
    /// <see href="https://saref.etsi.org/saref4agri/Thermometer"></see></summary>
    let Thermometer =
        Namespaced_IRI.parse _namespace_name "Thermometer" |> NamespacedName

    /// <summary>
    /// An actuator to irrigate an space.
    /// <see href="https://saref.etsi.org/saref4agri/WateringGun"></see></summary>
    let WateringGun =
        Namespaced_IRI.parse _namespace_name "WateringGun" |> NamespacedName

    /// <summary>
    /// Watering system
    /// <see href="https://saref.etsi.org/saref4agri/WateringSystem"></see></summary>
    let WateringSystem =
        Namespaced_IRI.parse _namespace_name "WateringSystem" |> NamespacedName

    /// <summary>
    /// Watering valve
    /// <see href="https://saref.etsi.org/saref4agri/WateringValve"></see></summary>
    let WateringValve =
        Namespaced_IRI.parse _namespace_name "WateringValve" |> NamespacedName

    /// <summary>
    /// A sensor o system that measure weather conditions.
    /// <see href="https://saref.etsi.org/saref4agri/WeatherStation"></see></summary>
    let WeatherStation =
        Namespaced_IRI.parse _namespace_name "WeatherStation" |> NamespacedName

    /// <summary>
    /// Weight sensor
    /// <see href="https://saref.etsi.org/saref4agri/WeightSensor"></see></summary>
    let WeightSensor =
        Namespaced_IRI.parse _namespace_name "WeightSensor" |> NamespacedName

    /// <summary>
    /// The produced amount of food for animals or of agricultural products.
    /// <see href="https://saref.etsi.org/saref4agri/Yield"></see></summary>
    let Yield = Namespaced_IRI.parse _namespace_name "Yield" |> NamespacedName

    /// <summary>
    /// is contained in
    /// <see href="https://saref.etsi.org/saref4agri/isContainedIn"></see></summary>
    let isContainedIn =
        Namespaced_IRI.parse _namespace_name "isContainedIn" |> NamespacedName

    /// <summary>
    /// A relation to represent the yield generated by a Crop.
    /// <see href="https://saref.etsi.org/saref4agri/generates"></see></summary>
    let generates = Namespaced_IRI.parse _namespace_name "generates" |> NamespacedName

    /// <summary>
    /// has received
    /// <see href="https://saref.etsi.org/saref4agri/hasReceived"></see></summary>
    let hasReceived =
        Namespaced_IRI.parse _namespace_name "hasReceived" |> NamespacedName

    /// <summary>
    /// A relation to represent the intake/consumption of certain substances in a Crop.
    /// <see href="https://saref.etsi.org/saref4agri/receives"></see></summary>
    let receives = Namespaced_IRI.parse _namespace_name "receives" |> NamespacedName

    /// <summary>
    /// is location of
    /// <see href="https://saref.etsi.org/saref4agri/isLocationOf"></see></summary>
    let isLocationOf =
        Namespaced_IRI.parse _namespace_name "isLocationOf" |> NamespacedName
