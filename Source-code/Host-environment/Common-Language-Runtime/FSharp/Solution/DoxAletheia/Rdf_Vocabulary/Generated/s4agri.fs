namespace https.saref.etsi.org.saref4agri.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module s4agri =
    let _namespace_iri = Namespace_Iri s4agri |> NamespaceIRI
    /// <summary>
    ///   <para>s4agri:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relation to express the name of an entity (e.g.,animal).</para>
    /// labels<para>has name</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/hasName">https://saref.etsi.org/saref4agri/hasName</seealso>
    let hasName = Prefixed_Name(s4agri, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:hasDeathDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relation to express the death date of an animal.</para>
    /// labels<para>has death date</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/hasDeathDate">https://saref.etsi.org/saref4agri/hasDeathDate</seealso>
    let hasDeathDate = Prefixed_Name(s4agri, "hasDeathDate") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:Building</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A building represents a structure that provides shelter for its occupants or contents and stands in one place. The building is also used to provide a basic element within the spatial structure hierarchy for the components of a building project (together with site, storey, and space).</para>
    /// labels<para>Building</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/Building">https://saref.etsi.org/saref4agri/Building</seealso>
    let Building = Prefixed_Name(s4agri, "Building") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:Crop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of cultivated plants that is grown on a large scale commercially, especially a cereal, fruit, or vegetable.</para>
    /// labels<para>Crop</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/Crop">https://saref.etsi.org/saref4agri/Crop</seealso>
    let Crop = Prefixed_Name(s4agri, "Crop") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:hasHarvestDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relation to express the day the crop is harvested.</para>
    /// labels<para>has harvest date</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/hasHarvestDate">https://saref.etsi.org/saref4agri/hasHarvestDate</seealso>
    let hasHarvestDate = Prefixed_Name(s4agri, "hasHarvestDate") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:isDeployedAtSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation to indicate the geographical componet of a deployment.</para>
    ///   <para>is deployed at space</para>
    /// labels<para>is deployed at space</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/isDeployedAtSpace">https://saref.etsi.org/saref4agri/isDeployedAtSpace</seealso>
    let isDeployedAtSpace = Prefixed_Name(s4agri, "isDeployedAtSpace") |> PrefixedName

    /// <summary>
    ///   <para>s4agri:EatingActivitySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Eating activity sensor</para>
    /// labels<para>Eating activity sensor</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/EatingActivitySensor">https://saref.etsi.org/saref4agri/EatingActivitySensor</seealso>
    let EatingActivitySensor =
        Prefixed_Name(s4agri, "EatingActivitySensor") |> PrefixedName

    /// <summary>
    ///   <para>s4agri:Farm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A plot of land used for the scope of farming which can contain buildings and parcels.</para>
    /// labels<para>Farm</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/Farm">https://saref.etsi.org/saref4agri/Farm</seealso>
    let Farm = Prefixed_Name(s4agri, "Farm") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:Farmer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class to decsribe a saref4agri farmer as subcass of a foaf:Person</para>
    /// labels<para>Farmer</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/Farmer">https://saref.etsi.org/saref4agri/Farmer</seealso>
    let Farmer = Prefixed_Name(s4agri, "Farmer") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:Animal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An individual and identifiable living organism that feeds on organic matter, typically having specialized sense organs and nervous system and able to respond rapidly to stimuli.</para>
    /// labels<para>Animal</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/Animal">https://saref.etsi.org/saref4agri/Animal</seealso>
    let Animal = Prefixed_Name(s4agri, "Animal") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:v1.1.2/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/v1.1.2/">https://saref.etsi.org/saref4agri/v1.1.2/</seealso>
    let ``v1.1.2/`` = Prefixed_Name(s4agri, "v1.1.2/") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:hasBirthDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relation to express the birth date of an animal.</para>
    /// labels<para>has birth date</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/hasBirthDate">https://saref.etsi.org/saref4agri/hasBirthDate</seealso>
    let hasBirthDate = Prefixed_Name(s4agri, "hasBirthDate") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>ID</para>
    /// labels<para>ID</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/ID">https://saref.etsi.org/saref4agri/ID</seealso>
    let ID = Prefixed_Name(s4agri, "ID") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:hasID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation to express the unique identifier of an animal.</para>
    /// labels<para>has id</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/hasID">https://saref.etsi.org/saref4agri/hasID</seealso>
    let hasID = Prefixed_Name(s4agri, "hasID") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:AnimalGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of one or multiple animals.</para>
    /// labels<para>Animal Group</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/AnimalGroup">https://saref.etsi.org/saref4agri/AnimalGroup</seealso>
    let AnimalGroup = Prefixed_Name(s4agri, "AnimalGroup") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:isMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation to express that an animal can be part of groups.</para>
    /// labels<para>is member of</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/isMemberOf">https://saref.etsi.org/saref4agri/isMemberOf</seealso>
    let isMemberOf = Prefixed_Name(s4agri, "isMemberOf") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/">https://saref.etsi.org/saref4agri/</seealso>
    let _prefix_iri = Prefixed_Name(s4agri, "") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:AirTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>saref:Temperature</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The degree or intensity of heat present in the air.</para>
    /// labels<para>Air temperature</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/AirTemperature">https://saref.etsi.org/saref4agri/AirTemperature</seealso>
    let AirTemperature = Prefixed_Name(s4agri, "AirTemperature") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:AmbientHumidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>saref:Humidity</para>
    ///   <para>The amount of water vapour in the air.</para>
    /// labels<para>Ambient humidity</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/AmbientHumidity">https://saref.etsi.org/saref4agri/AmbientHumidity</seealso>
    let AmbientHumidity = Prefixed_Name(s4agri, "AmbientHumidity") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:FarmHolding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class to decsribe a saref4agri farm holding as subcass of an org:Organization</para>
    /// labels<para>Farm holding</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/FarmHolding">https://saref.etsi.org/saref4agri/FarmHolding</seealso>
    let FarmHolding = Prefixed_Name(s4agri, "FarmHolding") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:managesFarm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>manages farm</para>
    /// labels<para>manages farm</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/managesFarm">https://saref.etsi.org/saref4agri/managesFarm</seealso>
    let managesFarm = Prefixed_Name(s4agri, "managesFarm") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:Intake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The amount of food or other substance taken into the body of an animal or into the soil.</para>
    /// labels<para>Intake</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/Intake">https://saref.etsi.org/saref4agri/Intake</seealso>
    let Intake = Prefixed_Name(s4agri, "Intake") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:IrrigationWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>saref:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The amount of water falling in the soil by irrigation methods.</para>
    /// labels<para>Irrigation water</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/IrrigationWater">https://saref.etsi.org/saref4agri/IrrigationWater</seealso>
    let IrrigationWater = Prefixed_Name(s4agri, "IrrigationWater") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:MilkingSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Milking sensor</para>
    /// labels<para>Milking sensor</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/MilkingSensor">https://saref.etsi.org/saref4agri/MilkingSensor</seealso>
    let MilkingSensor = Prefixed_Name(s4agri, "MilkingSensor") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:PlantGrowthStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>saref:Property</para>
    ///   <para>The level or stage of growth of the plant.</para>
    /// labels<para>Plant growth stage</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/PlantGrowthStage">https://saref.etsi.org/saref4agri/PlantGrowthStage</seealso>
    let PlantGrowthStage = Prefixed_Name(s4agri, "PlantGrowthStage") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:Pluviometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sensor that measures the rain fall.</para>
    /// labels<para>Pluviometer</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/Pluviometer">https://saref.etsi.org/saref4agri/Pluviometer</seealso>
    let Pluviometer = Prefixed_Name(s4agri, "Pluviometer") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:Precipitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>saref:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The amount of water falling in the soil by natural process (e.g. rain).</para>
    /// labels<para>Precipitation</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/Precipitation">https://saref.etsi.org/saref4agri/Precipitation</seealso>
    let Precipitation = Prefixed_Name(s4agri, "Precipitation") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:SoilMoisture</para>
    /// </summary>
    /// <remarks>
    ///   <para>saref:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The amount of water or humidity contained in the soil.</para>
    /// labels<para>Soil moisture</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/SoilMoisture">https://saref.etsi.org/saref4agri/SoilMoisture</seealso>
    let SoilMoisture = Prefixed_Name(s4agri, "SoilMoisture") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:SoilTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>saref:Temperature</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The degree or intensity of heat present in the soil.</para>
    /// labels<para>Soil temperature</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/SoilTemperature">https://saref.etsi.org/saref4agri/SoilTemperature</seealso>
    let SoilTemperature = Prefixed_Name(s4agri, "SoilTemperature") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:SoilTensiometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sensor that measures the soil moisture.</para>
    /// labels<para>Soil tensiometer</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/SoilTensiometer">https://saref.etsi.org/saref4agri/SoilTensiometer</seealso>
    let SoilTensiometer = Prefixed_Name(s4agri, "SoilTensiometer") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:WateringGun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to irrigate an space.</para>
    /// labels<para>Watering gun</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/WateringGun">https://saref.etsi.org/saref4agri/WateringGun</seealso>
    let WateringGun = Prefixed_Name(s4agri, "WateringGun") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:WateringValve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Watering valve</para>
    /// labels<para>Watering valve</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/WateringValve">https://saref.etsi.org/saref4agri/WateringValve</seealso>
    let WateringValve = Prefixed_Name(s4agri, "WateringValve") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:WeatherStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sensor o system that measure weather conditions.</para>
    /// labels<para>Weather station</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/WeatherStation">https://saref.etsi.org/saref4agri/WeatherStation</seealso>
    let WeatherStation = Prefixed_Name(s4agri, "WeatherStation") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:WeightSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Weight sensor</para>
    /// labels<para>Weight sensor</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/WeightSensor">https://saref.etsi.org/saref4agri/WeightSensor</seealso>
    let WeightSensor = Prefixed_Name(s4agri, "WeightSensor") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:Yield</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The produced amount of food for animals or of agricultural products.</para>
    /// labels<para>Yield</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/Yield">https://saref.etsi.org/saref4agri/Yield</seealso>
    let Yield = Prefixed_Name(s4agri, "Yield") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:receives</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation to represent the intake/consumption of certain substances in a Crop.</para>
    /// labels<para>receives</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/receives">https://saref.etsi.org/saref4agri/receives</seealso>
    let receives = Prefixed_Name(s4agri, "receives") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:isLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>is location of</para>
    /// labels<para>is location of</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/isLocationOf">https://saref.etsi.org/saref4agri/isLocationOf</seealso>
    let isLocationOf = Prefixed_Name(s4agri, "isLocationOf") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:isLocatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation to express the physical location of a saref4agri entity (e.g., an animal)</para>
    /// labels<para>is located in</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/isLocatedIn">https://saref.etsi.org/saref4agri/isLocatedIn</seealso>
    let isLocatedIn = Prefixed_Name(s4agri, "isLocatedIn") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation to represent  the members of an AnimalGroup.</para>
    /// labels<para>has member</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/hasMember">https://saref.etsi.org/saref4agri/hasMember</seealso>
    let hasMember = Prefixed_Name(s4agri, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:BuildingSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An entity used to define the physical spaces of the building. A building space contains devices or building objects.</para>
    /// labels<para>Building space</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/BuildingSpace">https://saref.etsi.org/saref4agri/BuildingSpace</seealso>
    let BuildingSpace = Prefixed_Name(s4agri, "BuildingSpace") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>contains</para>
    /// labels<para>contains</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/contains">https://saref.etsi.org/saref4agri/contains</seealso>
    let contains = Prefixed_Name(s4agri, "contains") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:hasPlantDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relation to express the day the crop is planted.</para>
    /// labels<para>has plant date</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/hasPlantDate">https://saref.etsi.org/saref4agri/hasPlantDate</seealso>
    let hasPlantDate = Prefixed_Name(s4agri, "hasPlantDate") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:Deployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The scenario, including temporal and spatial information, in which the systems and devices are installed.</para>
    ///   <para>Deployment</para>
    /// labels<para>Deployment</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/Deployment">https://saref.etsi.org/saref4agri/Deployment</seealso>
    let Deployment = Prefixed_Name(s4agri, "Deployment") |> PrefixedName

    /// <summary>
    ///   <para>s4agri:hasDeploymentPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation to indicate the temporal duration or period of a deployment.</para>
    ///   <para>has deployment period</para>
    /// labels<para>has deployment period</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/hasDeploymentPeriod">https://saref.etsi.org/saref4agri/hasDeploymentPeriod</seealso>
    let hasDeploymentPeriod =
        Prefixed_Name(s4agri, "hasDeploymentPeriod") |> PrefixedName

    /// <summary>
    ///   <para>s4agri:Parcel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An area of land, which might be used for grazing animals or planting crops. The parcel is defined as an undividable logical area of land which contains homogeneous items.</para>
    /// labels<para>Parcel</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/Parcel">https://saref.etsi.org/saref4agri/Parcel</seealso>
    let Parcel = Prefixed_Name(s4agri, "Parcel") |> PrefixedName

    /// <summary>
    ///   <para>s4agri:MovementActivitySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Movement activity sensor</para>
    /// labels<para>Movement activity sensor</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/MovementActivitySensor">https://saref.etsi.org/saref4agri/MovementActivitySensor</seealso>
    let MovementActivitySensor =
        Prefixed_Name(s4agri, "MovementActivitySensor") |> PrefixedName

    /// <summary>
    ///   <para>s4agri:Platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Platform</para>
    /// labels<para>Platform</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/Platform">https://saref.etsi.org/saref4agri/Platform</seealso>
    let Platform = Prefixed_Name(s4agri, "Platform") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:Soil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Upper layer of the earth in which plants grow.</para>
    /// labels<para>Soil</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/Soil">https://saref.etsi.org/saref4agri/Soil</seealso>
    let Soil = Prefixed_Name(s4agri, "Soil") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:Thermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Thermometer</para>
    /// labels<para>Thermometer</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/Thermometer">https://saref.etsi.org/saref4agri/Thermometer</seealso>
    let Thermometer = Prefixed_Name(s4agri, "Thermometer") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:isContainedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>is contained in</para>
    /// labels<para>is contained in</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/isContainedIn">https://saref.etsi.org/saref4agri/isContainedIn</seealso>
    let isContainedIn = Prefixed_Name(s4agri, "isContainedIn") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:generates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation to represent the yield generated by a Crop.</para>
    /// labels<para>generates</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/generates">https://saref.etsi.org/saref4agri/generates</seealso>
    let generates = Prefixed_Name(s4agri, "generates") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:hasReceived</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>has received</para>
    /// labels<para>has received</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/hasReceived">https://saref.etsi.org/saref4agri/hasReceived</seealso>
    let hasReceived = Prefixed_Name(s4agri, "hasReceived") |> PrefixedName
    /// <summary>
    ///   <para>s4agri:WateringSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Watering system</para>
    /// labels<para>Watering system</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4agri/WateringSystem">https://saref.etsi.org/saref4agri/WateringSystem</seealso>
    let WateringSystem = Prefixed_Name(s4agri, "WateringSystem") |> PrefixedName
