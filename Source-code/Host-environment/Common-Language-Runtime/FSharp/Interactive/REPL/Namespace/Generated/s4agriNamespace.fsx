#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module s4agri =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://saref.etsi.org/saref4agri/" "s4agri"

    let _namespaceIri = _prefixId.prefix ""
    let AirTemperature = _prefixId.prefix "AirTemperature"
    let AmbientHumidity = _prefixId.prefix "AmbientHumidity"
    /// <summary>
    ///   <para>rdfs:comment : An individual and identifiable living organism that feeds on organic matter, typically having specialized sense organs and nervous system and able to respond rapidly to stimuli.</para>
    ///   <para>rdfs:label : Animal</para>
    ///   <a href="https://saref.etsi.org/saref4agri/Animal">s4agri:Animal</a>
    /// </summary>
    let Animal = _prefixId.prefix "Animal"
    /// <summary>
    ///   <para>rdfs:label : Animal Group</para>
    ///   <para>rdfs:comment : A collection of one or multiple animals.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/AnimalGroup">s4agri:AnimalGroup</a>
    /// </summary>
    let AnimalGroup = _prefixId.prefix "AnimalGroup"
    /// <summary>
    ///   <para>rdfs:label : Building</para>
    ///   <para>rdfs:comment : A building represents a structure that provides shelter for its occupants or contents and stands in one place. The building is also used to provide a basic element within the spatial structure hierarchy for the components of a building project (together with site, storey, and space).</para>
    ///   <a href="https://saref.etsi.org/saref4agri/Building">s4agri:Building</a>
    /// </summary>
    let Building = _prefixId.prefix "Building"
    /// <summary>
    ///   <para>rdfs:label : Building space</para>
    ///   <para>rdfs:comment : An entity used to define the physical spaces of the building. A building space contains devices or building objects.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/BuildingSpace">s4agri:BuildingSpace</a>
    /// </summary>
    let BuildingSpace = _prefixId.prefix "BuildingSpace"
    /// <summary>
    ///   <para>rdfs:label : Crop</para>
    ///   <para>rdfs:comment : A collection of cultivated plants that is grown on a large scale commercially, especially a cereal, fruit, or vegetable.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/Crop">s4agri:Crop</a>
    /// </summary>
    let Crop = _prefixId.prefix "Crop"
    /// <summary>
    ///   <para>rdfs:label : Deployment</para>
    ///   <para>rdfs:comment : The scenario, including temporal and spatial information, in which the systems and devices are installed.rdfs:comment : Deployment</para>
    ///   <a href="https://saref.etsi.org/saref4agri/Deployment">s4agri:Deployment</a>
    /// </summary>
    let Deployment = _prefixId.prefix "Deployment"
    /// <summary>
    ///   <para>rdfs:label : Eating activity sensor</para>
    ///   <para>rdfs:comment : Eating activity sensor</para>
    ///   <a href="https://saref.etsi.org/saref4agri/EatingActivitySensor">s4agri:EatingActivitySensor</a>
    /// </summary>
    let EatingActivitySensor = _prefixId.prefix "EatingActivitySensor"
    /// <summary>
    ///   <para>rdfs:label : Farm</para>
    ///   <para>rdfs:comment : A plot of land used for the scope of farming which can contain buildings and parcels.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/Farm">s4agri:Farm</a>
    /// </summary>
    let Farm = _prefixId.prefix "Farm"
    /// <summary>
    ///   <para>rdfs:label : Farm holding</para>
    ///   <para>rdfs:comment : A class to decsribe a saref4agri farm holding as subcass of an org:Organization</para>
    ///   <a href="https://saref.etsi.org/saref4agri/FarmHolding">s4agri:FarmHolding</a>
    /// </summary>
    let FarmHolding = _prefixId.prefix "FarmHolding"
    /// <summary>
    ///   <para>rdfs:label : Farmer</para>
    ///   <para>rdfs:comment : A class to decsribe a saref4agri farmer as subcass of a foaf:Person</para>
    ///   <a href="https://saref.etsi.org/saref4agri/Farmer">s4agri:Farmer</a>
    /// </summary>
    let Farmer = _prefixId.prefix "Farmer"
    /// <summary>
    ///   <para>rdfs:label : ID</para>
    ///   <para>rdfs:comment : ID</para>
    ///   <a href="https://saref.etsi.org/saref4agri/ID">s4agri:ID</a>
    /// </summary>
    let ID = _prefixId.prefix "ID"
    /// <summary>
    ///   <para>rdfs:label : Intake</para>
    ///   <para>rdfs:comment : The amount of food or other substance taken into the body of an animal or into the soil.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/Intake">s4agri:Intake</a>
    /// </summary>
    let Intake = _prefixId.prefix "Intake"
    let IrrigationWater = _prefixId.prefix "IrrigationWater"
    /// <summary>
    ///   <para>rdfs:label : Milking sensor</para>
    ///   <para>rdfs:comment : Milking sensor</para>
    ///   <a href="https://saref.etsi.org/saref4agri/MilkingSensor">s4agri:MilkingSensor</a>
    /// </summary>
    let MilkingSensor = _prefixId.prefix "MilkingSensor"
    /// <summary>
    ///   <para>rdfs:label : Movement activity sensor</para>
    ///   <para>rdfs:comment : Movement activity sensor</para>
    ///   <a href="https://saref.etsi.org/saref4agri/MovementActivitySensor">s4agri:MovementActivitySensor</a>
    /// </summary>
    let MovementActivitySensor = _prefixId.prefix "MovementActivitySensor"
    /// <summary>
    ///   <para>rdfs:label : Parcel</para>
    ///   <para>rdfs:comment : An area of land, which might be used for grazing animals or planting crops. The parcel is defined as an undividable logical area of land which contains homogeneous items.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/Parcel">s4agri:Parcel</a>
    /// </summary>
    let Parcel = _prefixId.prefix "Parcel"
    let PlantGrowthStage = _prefixId.prefix "PlantGrowthStage"
    /// <summary>
    ///   <para>rdfs:label : Platform</para>
    ///   <para>rdfs:comment : Platform</para>
    ///   <a href="https://saref.etsi.org/saref4agri/Platform">s4agri:Platform</a>
    /// </summary>
    let Platform = _prefixId.prefix "Platform"
    /// <summary>
    ///   <para>rdfs:label : Pluviometer</para>
    ///   <para>rdfs:comment : A sensor that measures the rain fall.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/Pluviometer">s4agri:Pluviometer</a>
    /// </summary>
    let Pluviometer = _prefixId.prefix "Pluviometer"
    let Precipitation = _prefixId.prefix "Precipitation"
    /// <summary>
    ///   <para>rdfs:label : Soil</para>
    ///   <para>rdfs:comment : Upper layer of the earth in which plants grow.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/Soil">s4agri:Soil</a>
    /// </summary>
    let Soil = _prefixId.prefix "Soil"
    let SoilMoisture = _prefixId.prefix "SoilMoisture"
    let SoilTemperature = _prefixId.prefix "SoilTemperature"
    /// <summary>
    ///   <para>rdfs:label : Soil tensiometer</para>
    ///   <para>rdfs:comment : A sensor that measures the soil moisture.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/SoilTensiometer">s4agri:SoilTensiometer</a>
    /// </summary>
    let SoilTensiometer = _prefixId.prefix "SoilTensiometer"
    /// <summary>
    ///   <para>rdfs:label : Thermometer</para>
    ///   <para>rdfs:comment : Thermometer</para>
    ///   <a href="https://saref.etsi.org/saref4agri/Thermometer">s4agri:Thermometer</a>
    /// </summary>
    let Thermometer = _prefixId.prefix "Thermometer"
    /// <summary>
    ///   <para>rdfs:label : Watering gun</para>
    ///   <para>rdfs:comment : An actuator to irrigate an space.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/WateringGun">s4agri:WateringGun</a>
    /// </summary>
    let WateringGun = _prefixId.prefix "WateringGun"
    /// <summary>
    ///   <para>rdfs:label : Watering system</para>
    ///   <para>rdfs:comment : Watering system</para>
    ///   <a href="https://saref.etsi.org/saref4agri/WateringSystem">s4agri:WateringSystem</a>
    /// </summary>
    let WateringSystem = _prefixId.prefix "WateringSystem"
    /// <summary>
    ///   <para>rdfs:label : Watering valve</para>
    ///   <para>rdfs:comment : Watering valve</para>
    ///   <a href="https://saref.etsi.org/saref4agri/WateringValve">s4agri:WateringValve</a>
    /// </summary>
    let WateringValve = _prefixId.prefix "WateringValve"
    /// <summary>
    ///   <para>rdfs:label : Weather station</para>
    ///   <para>rdfs:comment : A sensor o system that measure weather conditions.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/WeatherStation">s4agri:WeatherStation</a>
    /// </summary>
    let WeatherStation = _prefixId.prefix "WeatherStation"
    /// <summary>
    ///   <para>rdfs:label : Weight sensor</para>
    ///   <para>rdfs:comment : Weight sensor</para>
    ///   <a href="https://saref.etsi.org/saref4agri/WeightSensor">s4agri:WeightSensor</a>
    /// </summary>
    let WeightSensor = _prefixId.prefix "WeightSensor"
    /// <summary>
    ///   <para>rdfs:label : Yield</para>
    ///   <para>rdfs:comment : The produced amount of food for animals or of agricultural products.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/Yield">s4agri:Yield</a>
    /// </summary>
    let Yield = _prefixId.prefix "Yield"
    /// <summary>
    ///   <para>rdfs:label : contains</para>
    ///   <para>rdfs:comment : contains</para>
    ///   <a href="https://saref.etsi.org/saref4agri/contains">s4agri:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>rdfs:label : generates</para>
    ///   <para>rdfs:comment : A relation to represent the yield generated by a Crop.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/generates">s4agri:generates</a>
    /// </summary>
    let generates = _prefixId.prefix "generates"
    /// <summary>
    ///   <para>rdfs:label : has birth date</para>
    ///   <para>rdfs:comment : A relation to express the birth date of an animal.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/hasBirthDate">s4agri:hasBirthDate</a>
    /// </summary>
    let hasBirthDate = _prefixId.prefix "hasBirthDate"
    /// <summary>
    ///   <para>rdfs:label : has death date</para>
    ///   <para>rdfs:comment : A relation to express the death date of an animal.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/hasDeathDate">s4agri:hasDeathDate</a>
    /// </summary>
    let hasDeathDate = _prefixId.prefix "hasDeathDate"
    /// <summary>
    ///   <para>rdfs:label : has deployment period</para>
    ///   <para>rdfs:comment : has deployment periodrdfs:comment : Relation to indicate the temporal duration or period of a deployment.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/hasDeploymentPeriod">s4agri:hasDeploymentPeriod</a>
    /// </summary>
    let hasDeploymentPeriod = _prefixId.prefix "hasDeploymentPeriod"
    /// <summary>
    ///   <para>rdfs:label : has harvest date</para>
    ///   <para>rdfs:comment : A relation to express the day the crop is harvested.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/hasHarvestDate">s4agri:hasHarvestDate</a>
    /// </summary>
    let hasHarvestDate = _prefixId.prefix "hasHarvestDate"
    /// <summary>
    ///   <para>rdfs:label : has id</para>
    ///   <para>rdfs:comment : A relation to express the unique identifier of an animal.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/hasID">s4agri:hasID</a>
    /// </summary>
    let hasID = _prefixId.prefix "hasID"
    /// <summary>
    ///   <para>rdfs:label : has member</para>
    ///   <para>rdfs:comment : A relation to represent  the members of an AnimalGroup.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/hasMember">s4agri:hasMember</a>
    /// </summary>
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:label : has name</para>
    ///   <para>rdfs:comment : A relation to express the name of an entity (e.g.,animal).</para>
    ///   <a href="https://saref.etsi.org/saref4agri/hasName">s4agri:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>rdfs:label : has plant date</para>
    ///   <para>rdfs:comment : A relation to express the day the crop is planted.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/hasPlantDate">s4agri:hasPlantDate</a>
    /// </summary>
    let hasPlantDate = _prefixId.prefix "hasPlantDate"
    /// <summary>
    ///   <para>rdfs:label : has received</para>
    ///   <para>rdfs:comment : has received</para>
    ///   <a href="https://saref.etsi.org/saref4agri/hasReceived">s4agri:hasReceived</a>
    /// </summary>
    let hasReceived = _prefixId.prefix "hasReceived"
    /// <summary>
    ///   <para>rdfs:label : is contained in</para>
    ///   <para>rdfs:comment : is contained in</para>
    ///   <a href="https://saref.etsi.org/saref4agri/isContainedIn">s4agri:isContainedIn</a>
    /// </summary>
    let isContainedIn = _prefixId.prefix "isContainedIn"
    /// <summary>
    ///   <para>rdfs:label : is deployed at space</para>
    ///   <para>rdfs:comment : is deployed at spacerdfs:comment : Relation to indicate the geographical componet of a deployment.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/isDeployedAtSpace">s4agri:isDeployedAtSpace</a>
    /// </summary>
    let isDeployedAtSpace = _prefixId.prefix "isDeployedAtSpace"
    /// <summary>
    ///   <para>rdfs:label : is located in</para>
    ///   <para>rdfs:comment : A relation to express the physical location of a saref4agri entity (e.g., an animal)</para>
    ///   <a href="https://saref.etsi.org/saref4agri/isLocatedIn">s4agri:isLocatedIn</a>
    /// </summary>
    let isLocatedIn = _prefixId.prefix "isLocatedIn"
    /// <summary>
    ///   <para>rdfs:label : is location of</para>
    ///   <para>rdfs:comment : is location of</para>
    ///   <a href="https://saref.etsi.org/saref4agri/isLocationOf">s4agri:isLocationOf</a>
    /// </summary>
    let isLocationOf = _prefixId.prefix "isLocationOf"
    /// <summary>
    ///   <para>rdfs:label : is member of</para>
    ///   <para>rdfs:comment : A relation to express that an animal can be part of groups.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/isMemberOf">s4agri:isMemberOf</a>
    /// </summary>
    let isMemberOf = _prefixId.prefix "isMemberOf"
    /// <summary>
    ///   <para>rdfs:label : manages farm</para>
    ///   <para>rdfs:comment : manages farm</para>
    ///   <a href="https://saref.etsi.org/saref4agri/managesFarm">s4agri:managesFarm</a>
    /// </summary>
    let managesFarm = _prefixId.prefix "managesFarm"
    /// <summary>
    ///   <para>rdfs:label : receives</para>
    ///   <para>rdfs:comment : A relation to represent the intake/consumption of certain substances in a Crop.</para>
    ///   <a href="https://saref.etsi.org/saref4agri/receives">s4agri:receives</a>
    /// </summary>
    let receives = _prefixId.prefix "receives"
