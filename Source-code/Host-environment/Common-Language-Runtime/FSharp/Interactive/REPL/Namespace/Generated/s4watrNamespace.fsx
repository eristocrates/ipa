#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module s4watr =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://saref.etsi.org/saref4watr/" "s4watr"

    let _namespaceIri = _prefixId.prefix ""
    let _12Dichloroethane = _prefixId.prefix "12Dichloroethane"
    /// <summary>
    ///   <para>rdfs:label : Acceptability property</para>
    ///   <para>rdfs:comment : An acceptability property is a property of water that is related to its acceptability.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/AcceptabilityProperty">s4watr:AcceptabilityProperty</a>
    /// </summary>
    let AcceptabilityProperty = _prefixId.prefix "AcceptabilityProperty"
    let Acrylamide = _prefixId.prefix "Acrylamide"
    let Agriculture = _prefixId.prefix "Agriculture"
    let Aluminium = _prefixId.prefix "Aluminium"
    let Ammonium = _prefixId.prefix "Ammonium"
    let Antimony = _prefixId.prefix "Antimony"
    let Aquaculture = _prefixId.prefix "Aquaculture"
    /// <summary>
    ///   <para>rdfs:label : Aquifer</para>
    ///   <para>rdfs:comment : An aquifer is an underground layer of water-bearing permeable rock, rock fractures or unconsolidated materials.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/Aquifer">s4watr:Aquifer</a>
    /// </summary>
    let Aquifer = _prefixId.prefix "Aquifer"
    let Arsenic = _prefixId.prefix "Arsenic"
    let AtmosphericPressure = _prefixId.prefix "AtmosphericPressure"
    /// <summary>
    ///   <para>rdfs:label : Bacterial property</para>
    ///   <para>rdfs:comment : A bacterial property is a property of water that is related to bacteria.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/BacterialProperty">s4watr:BacterialProperty</a>
    /// </summary>
    let BacterialProperty = _prefixId.prefix "BacterialProperty"
    let BatteryLastChange = _prefixId.prefix "BatteryLastChange"
    let BatteryOperatingTime = _prefixId.prefix "BatteryOperatingTime"
    let BatteryRemainingTime = _prefixId.prefix "BatteryRemainingTime"
    let Benzene = _prefixId.prefix "Benzene"
    let Benzoapyrene = _prefixId.prefix "Benzoapyrene"
    let Boron = _prefixId.prefix "Boron"
    let Bromate = _prefixId.prefix "Bromate"
    let Cadmium = _prefixId.prefix "Cadmium"
    /// <summary>
    ///   <para>rdfs:label : Channel</para>
    ///   <para>rdfs:comment : A channel is a passage of water flowing in an open conduit (i.e., subject to atmospheric pressure).</para>
    ///   <a href="https://saref.etsi.org/saref4watr/Channel">s4watr:Channel</a>
    /// </summary>
    let Channel = _prefixId.prefix "Channel"
    /// <summary>
    ///   <para>rdfs:label : ChemicalProperty</para>
    ///   <para>rdfs:comment : A chemical property is a property of water that is related to chemical components.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/ChemicalProperty">s4watr:ChemicalProperty</a>
    /// </summary>
    let ChemicalProperty = _prefixId.prefix "ChemicalProperty"
    let Chloride = _prefixId.prefix "Chloride"
    let Chromium = _prefixId.prefix "Chromium"
    let ClostridiumPerfringens = _prefixId.prefix "ClostridiumPerfringens"
    let ColiformBacteria = _prefixId.prefix "ColiformBacteria"
    let ColonyCount22C = _prefixId.prefix "ColonyCount22C"
    let ColonyCount37C = _prefixId.prefix "ColonyCount37C"
    let Colour = _prefixId.prefix "Colour"
    let Conductivity = _prefixId.prefix "Conductivity"
    /// <summary>
    ///   <para>rdfs:label : Consumption-based tariff</para>
    ///   <para>rdfs:comment : A consumption-based tariff is a tariff that is based on consumption.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/ConsumptionBasedTariff">s4watr:ConsumptionBasedTariff</a>
    /// </summary>
    let ConsumptionBasedTariff = _prefixId.prefix "ConsumptionBasedTariff"
    let Copper = _prefixId.prefix "Copper"
    let Cyanide = _prefixId.prefix "Cyanide"
    /// <summary>
    ///   <para>rdfs:label : Distribution system</para>
    ///   <para>rdfs:comment : A water distribution system is an infrastructure to carry potable water from a centralized treatment plant or wells to water consumers in order to adequately deliver water to satisfy residential, commercial, industrial and fire fighting requirements.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/DistributionSystem">s4watr:DistributionSystem</a>
    /// </summary>
    let DistributionSystem = _prefixId.prefix "DistributionSystem"
    let Domestic = _prefixId.prefix "Domestic"
    let DrinkingWater = _prefixId.prefix "DrinkingWater"
    let Enterococci = _prefixId.prefix "Enterococci"
    /// <summary>
    ///   <para>rdfs:label : Environmental property</para>
    ///   <para>rdfs:comment : Class to group those properties related to the environment.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/EnvironmentalProperty">s4watr:EnvironmentalProperty</a>
    /// </summary>
    let EnvironmentalProperty = _prefixId.prefix "EnvironmentalProperty"
    let Epichlorohydrin = _prefixId.prefix "Epichlorohydrin"
    let EscherichiaColi = _prefixId.prefix "EscherichiaColi"
    /// <summary>
    ///   <para>rdfs:label : Estuary</para>
    ///   <para>rdfs:comment : An estuary is a partially enclosed coastal body of brackish water with one or more rivers or streams flowing into it, and with a free connection to the open sea.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/Estuary">s4watr:Estuary</a>
    /// </summary>
    let Estuary = _prefixId.prefix "Estuary"
    let ExternalTemperature = _prefixId.prefix "ExternalTemperature"
    /// <summary>
    ///   <para>rdfs:label : Fire hydrant</para>
    ///   <para>rdfs:comment : A fire hydrant is a fitting in a street or other public place with a nozzle by which a fire hose may be attached to a water main.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/FireHydrant">s4watr:FireHydrant</a>
    /// </summary>
    let FireHydrant = _prefixId.prefix "FireHydrant"
    let FlowPressure = _prefixId.prefix "FlowPressure"
    let FlowRate = _prefixId.prefix "FlowRate"
    let FlowTemperature = _prefixId.prefix "FlowTemperature"
    let FlowVolume = _prefixId.prefix "FlowVolume"
    let Fluoride = _prefixId.prefix "Fluoride"
    /// <summary>
    ///   <para>rdfs:label : Gauging station</para>
    ///   <para>rdfs:comment : A gauging station is an infrastructure to monitor and test terrestrial bodies of water.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/GaugingStation">s4watr:GaugingStation</a>
    /// </summary>
    let GaugingStation = _prefixId.prefix "GaugingStation"
    /// <summary>
    ///   <para>rdfs:label : Glacier</para>
    ///   <para>rdfs:comment : A glacier is a persistent body of dense ice that is constantly moving under its own weight.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/Glacier">s4watr:Glacier</a>
    /// </summary>
    let Glacier = _prefixId.prefix "Glacier"
    let Hardness = _prefixId.prefix "Hardness"
    let Humidity = _prefixId.prefix "Humidity"
    /// <summary>
    ///   <para>rdfs:label : Hydroelectric power plant</para>
    ///   <para>rdfs:comment : A hydroelectric power plant is an infrastructure to generate electricity by conversion of the energy of running water.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/HydroelectricPowerPlant">s4watr:HydroelectricPowerPlant</a>
    /// </summary>
    let HydroelectricPowerPlant = _prefixId.prefix "HydroelectricPowerPlant"
    let HydrogenIonConcentration = _prefixId.prefix "HydrogenIonConcentration"
    let Industry = _prefixId.prefix "Industry"
    /// <summary>
    ///   <para>rdfs:label : Intake</para>
    ///   <para>rdfs:comment : An intake is an installation for obtaining water from a source of supply (river, lake, reservoir, and so on).</para>
    ///   <a href="https://saref.etsi.org/saref4watr/Intake">s4watr:Intake</a>
    /// </summary>
    let Intake = _prefixId.prefix "Intake"
    let Iron = _prefixId.prefix "Iron"
    /// <summary>
    ///   <para>rdfs:label : Lagoon</para>
    ///   <para>rdfs:comment : A lagoon is a shallow body of water separated from a larger body of water by barrier islands or reefs.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/Lagoon">s4watr:Lagoon</a>
    /// </summary>
    let Lagoon = _prefixId.prefix "Lagoon"
    /// <summary>
    ///   <para>rdfs:label : Lake</para>
    ///   <para>rdfs:comment : A lake is an area filled with water, localized in a basin, surrounded by land, apart from any river or other outlet that serves to feed or drain the lake.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/Lake">s4watr:Lake</a>
    /// </summary>
    let Lake = _prefixId.prefix "Lake"
    let Lead = _prefixId.prefix "Lead"
    /// <summary>
    ///   <para>rdfs:label : Main</para>
    ///   <para>rdfs:comment : A main is a passage of water to flow through.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/Main">s4watr:Main</a>
    /// </summary>
    let Main = _prefixId.prefix "Main"
    let Manganese = _prefixId.prefix "Manganese"
    /// <summary>
    ///   <para>rdfs:label : Maintenance holerdfs:label : Manhole</para>
    ///   <para>rdfs:comment : A maintenance hole is an enclosure that facilitates human access to and working space for equipment.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/Manhole">s4watr:Manhole</a>
    /// </summary>
    let Manhole = _prefixId.prefix "Manhole"
    let Mercury = _prefixId.prefix "Mercury"
    let MeterOnTime = _prefixId.prefix "MeterOnTime"
    let MeterOperatingTime = _prefixId.prefix "MeterOperatingTime"
    /// <summary>
    ///   <para>rdfs:label : Microbial property</para>
    ///   <para>rdfs:comment : A microbial property is a property of water that is related to microbes.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/MicrobialProperty">s4watr:MicrobialProperty</a>
    /// </summary>
    let MicrobialProperty = _prefixId.prefix "MicrobialProperty"
    /// <summary>
    ///   <para>rdfs:label : Monitoring infrastructure</para>
    ///   <para>rdfs:comment : A monitoring infrastructure is an infrastructure to monitor water.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/MonitoringInfrastructure">s4watr:MonitoringInfrastructure</a>
    /// </summary>
    let MonitoringInfrastructure = _prefixId.prefix "MonitoringInfrastructure"
    let Nickel = _prefixId.prefix "Nickel"
    let Nitrate = _prefixId.prefix "Nitrate"
    let Nitrite = _prefixId.prefix "Nitrite"
    /// <summary>
    ///   <para>rdfs:label : Ocean</para>
    ///   <para>rdfs:comment : An ocean is a large body of salt water.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/Ocean">s4watr:Ocean</a>
    /// </summary>
    let Ocean = _prefixId.prefix "Ocean"
    let Odour = _prefixId.prefix "Odour"
    let Oxidisability = _prefixId.prefix "Oxidisability"
    let Oxygen = _prefixId.prefix "Oxygen"
    /// <summary>
    ///   <para>rdfs:label : Pipe</para>
    ///   <para>rdfs:comment : A pipe is a passage of water flowing in a closed conduit (i.e., not subject to atmospheric pressure).</para>
    ///   <a href="https://saref.etsi.org/saref4watr/Pipe">s4watr:Pipe</a>
    /// </summary>
    let Pipe = _prefixId.prefix "Pipe"
    /// <summary>
    ///   <para>rdfs:label : Pit</para>
    ///   <para>rdfs:comment : A pit is a well or hole sunk in the ground to procure, store or drain water.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/Pit">s4watr:Pit</a>
    /// </summary>
    let Pit = _prefixId.prefix "Pit"

    let PolycyclicAromaticHydrocarbons =
        _prefixId.prefix "PolycyclicAromaticHydrocarbons"

    let Precipitation = _prefixId.prefix "Precipitation"
    let PseudomonasAeruginosa = _prefixId.prefix "PseudomonasAeruginosa"
    /// <summary>
    ///   <para>rdfs:label : Pump</para>
    ///   <para>rdfs:comment : A pump is a device for moving water by mechanical action.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/Pump">s4watr:Pump</a>
    /// </summary>
    let Pump = _prefixId.prefix "Pump"
    let RawWater = _prefixId.prefix "RawWater"
    let Recreation = _prefixId.prefix "Recreation"
    /// <summary>
    ///   <para>rdfs:label : Reservoir</para>
    ///   <para>rdfs:comment : A reservoir is an enlarged natural or artificial lake, pond or impoundment created using a dam or lock to store water.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/Reservoir">s4watr:Reservoir</a>
    /// </summary>
    let Reservoir = _prefixId.prefix "Reservoir"
    /// <summary>
    ///   <para>rdfs:label : River</para>
    ///   <para>rdfs:comment : A river is a natural flowing watercourse, usually freshwater, flowing towards an ocean, sea, lake or another river.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/River">s4watr:River</a>
    /// </summary>
    let River = _prefixId.prefix "River"
    /// <summary>
    ///   <para>rdfs:label : Sea</para>
    ///   <para>rdfs:comment : A sea is a body of salt water partly or fully enclosed by land.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/Sea">s4watr:Sea</a>
    /// </summary>
    let Sea = _prefixId.prefix "Sea"
    let Selenium = _prefixId.prefix "Selenium"
    /// <summary>
    ///   <para>rdfs:label : Sink asset</para>
    ///   <para>rdfs:comment : A sink asset is a water asset where water sinks.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/SinkAsset">s4watr:SinkAsset</a>
    /// </summary>
    let SinkAsset = _prefixId.prefix "SinkAsset"
    let Sodium = _prefixId.prefix "Sodium"
    /// <summary>
    ///   <para>rdfs:label : Source asset</para>
    ///   <para>rdfs:comment : A source asset is a water asset that is a natural source of water.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/SourceAsset">s4watr:SourceAsset</a>
    /// </summary>
    let SourceAsset = _prefixId.prefix "SourceAsset"
    /// <summary>
    ///   <para>rdfs:label : Storage asset</para>
    ///   <para>rdfs:comment : A storage asset is a water asset used to store water.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/StorageAsset">s4watr:StorageAsset</a>
    /// </summary>
    let StorageAsset = _prefixId.prefix "StorageAsset"
    /// <summary>
    ///   <para>rdfs:label : Storage infrastructure</para>
    ///   <para>rdfs:comment : An storage infrastructure is an infrastructure to storage both potable water for consumption, and non potable water for use in agriculture.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/StorageInfrastructure">s4watr:StorageInfrastructure</a>
    /// </summary>
    let StorageInfrastructure = _prefixId.prefix "StorageInfrastructure"
    let Stormwater = _prefixId.prefix "Stormwater"
    let Sulphate = _prefixId.prefix "Sulphate"
    /// <summary>
    ///   <para>rdfs:label : Tank</para>
    ///   <para>rdfs:comment : A tank is a container for storing water.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/Tank">s4watr:Tank</a>
    /// </summary>
    let Tank = _prefixId.prefix "Tank"
    /// <summary>
    ///   <para>rdfs:label : Tariff</para>
    ///   <para>rdfs:comment : A tariff is a schedule of rates or charges of a business or a public utility. Tariffs can be based on time, thresholds or consumption; however, combined tariffs may also exist that mix more than one of these types.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/Tariff">s4watr:Tariff</a>
    /// </summary>
    let Tariff = _prefixId.prefix "Tariff"
    let Taste = _prefixId.prefix "Taste"
    let Temperature = _prefixId.prefix "Temperature"
    let Tetrachloroethene = _prefixId.prefix "Tetrachloroethene"
    /// <summary>
    ///   <para>rdfs:label : Threshold-based tariff</para>
    ///   <para>rdfs:comment : A threshold-based tariff is a tariff that is based on a threshold.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/ThresholdBasedTariff">s4watr:ThresholdBasedTariff</a>
    /// </summary>
    let ThresholdBasedTariff = _prefixId.prefix "ThresholdBasedTariff"
    /// <summary>
    ///   <para>rdfs:label : Time-based tariff</para>
    ///   <para>rdfs:comment : A time-based tariff is a tariff that is based on time.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/TimeBasedTariff">s4watr:TimeBasedTariff</a>
    /// </summary>
    let TimeBasedTariff = _prefixId.prefix "TimeBasedTariff"
    let TotalDissolvedSolids = _prefixId.prefix "TotalDissolvedSolids"
    let TotalIndicativeDose = _prefixId.prefix "TotalIndicativeDose"
    let TotalOrganicCarbon = _prefixId.prefix "TotalOrganicCarbon"
    let TotalSuspendedSolids = _prefixId.prefix "TotalSuspendedSolids"
    /// <summary>
    ///   <para>rdfs:label : Transport asset</para>
    ///   <para>rdfs:comment : A transport asset is a water asset used to enable and support the transport and distribution of water.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/TransportAsset">s4watr:TransportAsset</a>
    /// </summary>
    let TransportAsset = _prefixId.prefix "TransportAsset"
    /// <summary>
    ///   <para>rdfs:label : Treatment plant</para>
    ///   <para>rdfs:comment : A treatment plant is an infrastructure to improve the quality of water to make it more acceptable for a specific end-use.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/TreatmentPlant">s4watr:TreatmentPlant</a>
    /// </summary>
    let TreatmentPlant = _prefixId.prefix "TreatmentPlant"
    let Trichloroethene = _prefixId.prefix "Trichloroethene"
    let Trihalomethanes = _prefixId.prefix "Trihalomethanes"
    let Tritium = _prefixId.prefix "Tritium"
    let Turbidity = _prefixId.prefix "Turbidity"
    /// <summary>
    ///   <para>rdfs:label : Valve</para>
    ///   <para>rdfs:comment : A valve is a device designed to control water flow, pressure or volume.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/Valve">s4watr:Valve</a>
    /// </summary>
    let Valve = _prefixId.prefix "Valve"
    /// <summary>
    ///   <para>rdfs:label : Vent</para>
    ///   <para>rdfs:comment : A vent is the part of a system that allows air to enter a plumbing system to maintain proper air pressure and sewer gases to escape to the outside.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/Vent">s4watr:Vent</a>
    /// </summary>
    let Vent = _prefixId.prefix "Vent"
    let VinylChloride = _prefixId.prefix "VinylChloride"
    let Wastewater = _prefixId.prefix "Wastewater"
    /// <summary>
    ///   <para>rdfs:label : Water</para>
    ///   <para>rdfs:comment : This class is used to define a particular quantity or body of water.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/Water">s4watr:Water</a>
    /// </summary>
    let Water = _prefixId.prefix "Water"
    /// <summary>
    ///   <para>rdfs:label : Water asset</para>
    ///   <para>rdfs:comment : A water asset is a physical entity used in the process of transporting, treating, storing and distributing water.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/WaterAsset">s4watr:WaterAsset</a>
    /// </summary>
    let WaterAsset = _prefixId.prefix "WaterAsset"
    /// <summary>
    ///   <para>rdfs:label : Water device</para>
    ///   <para>rdfs:comment : A water device is a device that is also a water asset.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/WaterDevice">s4watr:WaterDevice</a>
    /// </summary>
    let WaterDevice = _prefixId.prefix "WaterDevice"
    /// <summary>
    ///   <para>rdfs:label : Water flow property</para>
    ///   <para>rdfs:comment : Class to group those properties related to water flow.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/WaterFlowProperty">s4watr:WaterFlowProperty</a>
    /// </summary>
    let WaterFlowProperty = _prefixId.prefix "WaterFlowProperty"
    /// <summary>
    ///   <para>rdfs:label : Water infrastructure</para>
    ///   <para>rdfs:comment : A water infrastructure is the set of facilities, services, and installations needed for water management.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/WaterInfrastructure">s4watr:WaterInfrastructure</a>
    /// </summary>
    let WaterInfrastructure = _prefixId.prefix "WaterInfrastructure"
    /// <summary>
    ///   <para>rdfs:label : Water meter</para>
    ///   <para>rdfs:comment : A water meter is an instrument intended to measure continuously, memorize, and display the volume of water passing through the meter.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/WaterMeter">s4watr:WaterMeter</a>
    /// </summary>
    let WaterMeter = _prefixId.prefix "WaterMeter"
    /// <summary>
    ///   <para>rdfs:label : Water meter property</para>
    ///   <para>rdfs:comment : Class to group those properties related to water meters.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/WaterMeterProperty">s4watr:WaterMeterProperty</a>
    /// </summary>
    let WaterMeterProperty = _prefixId.prefix "WaterMeterProperty"
    /// <summary>
    ///   <para>rdfs:label : Water property</para>
    ///   <para>rdfs:comment : Class to group those properties related to the water.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/WaterProperty">s4watr:WaterProperty</a>
    /// </summary>
    let WaterProperty = _prefixId.prefix "WaterProperty"
    /// <summary>
    ///   <para>rdfs:label : Water use</para>
    ///   <para>rdfs:comment : This class is used to define the different uses of water.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/WaterUse">s4watr:WaterUse</a>
    /// </summary>
    let WaterUse = _prefixId.prefix "WaterUse"
    /// <summary>
    ///   <para>rdfs:label : applies to</para>
    ///   <para>rdfs:comment : The water meter to which a tariff applies to.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/appliesTo">s4watr:appliesTo</a>
    /// </summary>
    let appliesTo = _prefixId.prefix "appliesTo"
    /// <summary>
    ///   <para>rdfs:label : controls feature</para>
    ///   <para>rdfs:comment : A relationship specifying the features of interest that are controlled by a device.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/controlsFeature">s4watr:controlsFeature</a>
    /// </summary>
    let controlsFeature = _prefixId.prefix "controlsFeature"
    /// <summary>
    ///   <para>rdfs:label : feature is controlled by device</para>
    ///   <para>rdfs:comment : A relationship specifying the devices that control a feature of interest.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/featureIsControlledByDevice">s4watr:featureIsControlledByDevice</a>
    /// </summary>
    let featureIsControlledByDevice = _prefixId.prefix "featureIsControlledByDevice"
    /// <summary>
    ///   <para>rdfs:label : feature is measured by device</para>
    ///   <para>rdfs:comment : A relationship specifying the devices that measure a feature of interest.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/featureIsMeasuredByDevice">s4watr:featureIsMeasuredByDevice</a>
    /// </summary>
    let featureIsMeasuredByDevice = _prefixId.prefix "featureIsMeasuredByDevice"
    /// <summary>
    ///   <para>rdfs:label : for absolute time at day</para>
    ///   <para>rdfs:comment : The time interval in each day for which a tariff is applied (e.g., 8:00 to 10:00).</para>
    ///   <a href="https://saref.etsi.org/saref4watr/forAbsoluteTimeAtDay">s4watr:forAbsoluteTimeAtDay</a>
    /// </summary>
    let forAbsoluteTimeAtDay = _prefixId.prefix "forAbsoluteTimeAtDay"
    /// <summary>
    ///   <para>rdfs:label : for day in month</para>
    ///   <para>rdfs:comment : The day of the month for which a tariff is applied (e.g., each 15).</para>
    ///   <a href="https://saref.etsi.org/saref4watr/forDayInMonth">s4watr:forDayInMonth</a>
    /// </summary>
    let forDayInMonth = _prefixId.prefix "forDayInMonth"
    /// <summary>
    ///   <para>rdfs:label : for financial consumption</para>
    ///   <para>rdfs:comment : The financial consumption related to a tariff (e.g., prepaid tariffs).</para>
    ///   <a href="https://saref.etsi.org/saref4watr/forFinancialConsumption">s4watr:forFinancialConsumption</a>
    /// </summary>
    let forFinancialConsumption = _prefixId.prefix "forFinancialConsumption"
    /// <summary>
    ///   <para>rdfs:label : for volume consumption</para>
    ///   <para>rdfs:comment : The volume consumption related to a tariff (e.g., after consumption of 900 litres).</para>
    ///   <a href="https://saref.etsi.org/saref4watr/forVolumeConsumption">s4watr:forVolumeConsumption</a>
    /// </summary>
    let forVolumeConsumption = _prefixId.prefix "forVolumeConsumption"
    /// <summary>
    ///   <para>rdfs:label : for volume flow</para>
    ///   <para>rdfs:comment : The volume flow related to a tariff.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/forVolumeFlow">s4watr:forVolumeFlow</a>
    /// </summary>
    let forVolumeFlow = _prefixId.prefix "forVolumeFlow"
    /// <summary>
    ///   <para>rdfs:label : for week day</para>
    ///   <para>rdfs:comment : The day of the week for which a tariff is applied (e.g., each Saturday and Sunday).</para>
    ///   <a href="https://saref.etsi.org/saref4watr/forWeekDay">s4watr:forWeekDay</a>
    /// </summary>
    let forWeekDay = _prefixId.prefix "forWeekDay"
    /// <summary>
    ///   <para>rdfs:label : has billing date</para>
    ///   <para>rdfs:comment : The billing date of a tariff.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/hasBillingDate">s4watr:hasBillingDate</a>
    /// </summary>
    let hasBillingDate = _prefixId.prefix "hasBillingDate"
    /// <summary>
    ///   <para>rdfs:label : has billing period</para>
    ///   <para>rdfs:comment : The billing period of a tariff.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/hasBillingPeriod">s4watr:hasBillingPeriod</a>
    /// </summary>
    let hasBillingPeriod = _prefixId.prefix "hasBillingPeriod"
    /// <summary>
    ///   <para>rdfs:label : has duration</para>
    ///   <para>rdfs:comment : The duration of a tariff.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/hasDuration">s4watr:hasDuration</a>
    /// </summary>
    let hasDuration = _prefixId.prefix "hasDuration"
    /// <summary>
    ///   <para>rdfs:label : has fabrication number</para>
    ///   <para>rdfs:comment : The fabrication number of a device.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/hasFabricationNumber">s4watr:hasFabricationNumber</a>
    /// </summary>
    let hasFabricationNumber = _prefixId.prefix "hasFabricationNumber"
    /// <summary>
    ///   <para>rdfs:label : has firmware version</para>
    ///   <para>rdfs:comment : The firmware version of a device.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/hasFirmwareVersion">s4watr:hasFirmwareVersion</a>
    /// </summary>
    let hasFirmwareVersion = _prefixId.prefix "hasFirmwareVersion"
    /// <summary>
    ///   <para>rdfs:label : has hardware version</para>
    ///   <para>rdfs:comment : The hardware version of a device.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/hasHardwareVersion">s4watr:hasHardwareVersion</a>
    /// </summary>
    let hasHardwareVersion = _prefixId.prefix "hasHardwareVersion"
    /// <summary>
    ///   <para>rdfs:label : has period</para>
    ///   <para>rdfs:comment : The period of a tariff.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/hasPeriod">s4watr:hasPeriod</a>
    /// </summary>
    let hasPeriod = _prefixId.prefix "hasPeriod"
    /// <summary>
    ///   <para>rdfs:label : has phenomenon time</para>
    ///   <para>rdfs:comment : The time for which the value of a measurement applies to the feature of interest.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/hasPhenomenonTime">s4watr:hasPhenomenonTime</a>
    /// </summary>
    let hasPhenomenonTime = _prefixId.prefix "hasPhenomenonTime"
    /// <summary>
    ///   <para>rdfs:label : has start timestamp</para>
    ///   <para>rdfs:comment : The start date and time of a tariff.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/hasStartTimestamp">s4watr:hasStartTimestamp</a>
    /// </summary>
    let hasStartTimestamp = _prefixId.prefix "hasStartTimestamp"
    /// <summary>
    ///   <para>rdfs:label : has version</para>
    ///   <para>rdfs:comment : The version of a device.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/hasVersion">s4watr:hasVersion</a>
    /// </summary>
    let hasVersion = _prefixId.prefix "hasVersion"
    /// <summary>
    ///   <para>rdfs:label : is designed for</para>
    ///   <para>rdfs:comment : The type of water for which an infrastructure is designed for.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/isDesignedFor">s4watr:isDesignedFor</a>
    /// </summary>
    let isDesignedFor = _prefixId.prefix "isDesignedFor"
    /// <summary>
    ///   <para>rdfs:label : is intended for</para>
    ///   <para>rdfs:comment : The intended use of the infrastructure.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/isIntendedFor">s4watr:isIntendedFor</a>
    /// </summary>
    let isIntendedFor = _prefixId.prefix "isIntendedFor"
    /// <summary>
    ///   <para>rdfs:label : measures feature</para>
    ///   <para>rdfs:comment : A relationship specifying the features of interest that are measured by a device.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/measuresFeature">s4watr:measuresFeature</a>
    /// </summary>
    let measuresFeature = _prefixId.prefix "measuresFeature"
    /// <summary>
    ///   <para>rdfs:label : operates at radio frequency</para>
    ///   <para>rdfs:comment : The radio frequency at which a device operates.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/operatesAtRadioFrequency">s4watr:operatesAtRadioFrequency</a>
    /// </summary>
    let operatesAtRadioFrequency = _prefixId.prefix "operatesAtRadioFrequency"
    /// <summary>
    ///   <para>rdfs:label : requires power</para>
    ///   <para>rdfs:comment : The power required by a device.</para>
    ///   <a href="https://saref.etsi.org/saref4watr/requiresPower">s4watr:requiresPower</a>
    /// </summary>
    let requiresPower = _prefixId.prefix "requiresPower"
