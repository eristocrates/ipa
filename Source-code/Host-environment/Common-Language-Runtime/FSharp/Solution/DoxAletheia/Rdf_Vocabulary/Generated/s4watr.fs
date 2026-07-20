namespace https.saref.etsi.org.saref4watr.slash

open DoxAletheia

module s4watr =
    let _namespace_name = "https://saref.etsi.org/saref4watr/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://saref.etsi.org/saref4watr/v1.1.1/"></see>
    /// </summary>
    let ``v1.1.1/`` = _prefix "v1.1.1/"
    /// <summary>
    /// Property of the water indicating its concentration of 1,2-dichloroethane.
    /// <see href="https://saref.etsi.org/saref4watr/12Dichloroethane"></see></summary>
    let _12Dichloroethane = _prefix "12Dichloroethane"
    /// <summary>
    /// A chemical property is a property of water that is related to chemical components.
    /// <see href="https://saref.etsi.org/saref4watr/ChemicalProperty"></see></summary>
    let ChemicalProperty = _prefix "ChemicalProperty"
    /// <summary>
    /// An acceptability property is a property of water that is related to its acceptability.
    /// <see href="https://saref.etsi.org/saref4watr/AcceptabilityProperty"></see></summary>
    let AcceptabilityProperty = _prefix "AcceptabilityProperty"
    /// <summary>
    /// Class to group those properties related to the water.
    /// <see href="https://saref.etsi.org/saref4watr/WaterProperty"></see></summary>
    let WaterProperty = _prefix "WaterProperty"
    /// <summary>
    /// Property of the water indicating its concentration of acrylamide.
    /// <see href="https://saref.etsi.org/saref4watr/Acrylamide"></see></summary>
    let Acrylamide = _prefix "Acrylamide"
    /// <summary>
    /// Use of water for the farming of plants and livestock.
    /// <see href="https://saref.etsi.org/saref4watr/Agriculture"></see></summary>
    let Agriculture = _prefix "Agriculture"
    /// <summary>
    /// This class is used to define the different uses of water.
    /// <see href="https://saref.etsi.org/saref4watr/WaterUse"></see></summary>
    let WaterUse = _prefix "WaterUse"
    /// <summary>
    /// Property of the water indicating its concentration of aluminium.
    /// <see href="https://saref.etsi.org/saref4watr/Aluminium"></see></summary>
    let Aluminium = _prefix "Aluminium"
    /// <summary>
    /// Property of the water indicating its concentration of ammonium.
    /// <see href="https://saref.etsi.org/saref4watr/Ammonium"></see></summary>
    let Ammonium = _prefix "Ammonium"
    /// <summary>
    /// Property of the water indicating its concentration of antimony.
    /// <see href="https://saref.etsi.org/saref4watr/Antimony"></see></summary>
    let Antimony = _prefix "Antimony"
    /// <summary>
    /// Use of water for the farming of fish, crustaceans, molluscs, aquatic plants, algae, and other organisms.
    /// <see href="https://saref.etsi.org/saref4watr/Aquaculture"></see></summary>
    let Aquaculture = _prefix "Aquaculture"
    /// <summary>
    /// An aquifer is an underground layer of water-bearing permeable rock, rock fractures or unconsolidated materials.
    /// <see href="https://saref.etsi.org/saref4watr/Aquifer"></see></summary>
    let Aquifer = _prefix "Aquifer"
    /// <summary>
    /// A storage asset is a water asset used to store water.
    /// <see href="https://saref.etsi.org/saref4watr/StorageAsset"></see></summary>
    let StorageAsset = _prefix "StorageAsset"
    /// <summary>
    /// Property of the water indicating its concentration of arsenic.
    /// <see href="https://saref.etsi.org/saref4watr/Arsenic"></see></summary>
    let Arsenic = _prefix "Arsenic"
    /// <summary>
    /// Property of the environment indicating the atmospheric pressure.
    /// <see href="https://saref.etsi.org/saref4watr/AtmosphericPressure"></see></summary>
    let AtmosphericPressure = _prefix "AtmosphericPressure"
    /// <summary>
    /// Class to group those properties related to the environment.
    /// <see href="https://saref.etsi.org/saref4watr/EnvironmentalProperty"></see></summary>
    let EnvironmentalProperty = _prefix "EnvironmentalProperty"
    /// <summary>
    /// A bacterial property is a property of water that is related to bacteria.
    /// <see href="https://saref.etsi.org/saref4watr/BacterialProperty"></see></summary>
    let BacterialProperty = _prefix "BacterialProperty"
    /// <summary>
    /// A microbial property is a property of water that is related to microbes.
    /// <see href="https://saref.etsi.org/saref4watr/MicrobialProperty"></see></summary>
    let MicrobialProperty = _prefix "MicrobialProperty"
    /// <summary>
    /// The time in which the battery was last changed.
    /// <see href="https://saref.etsi.org/saref4watr/BatteryLastChange"></see></summary>
    let BatteryLastChange = _prefix "BatteryLastChange"
    /// <summary>
    /// Class to group those properties related to water meters.
    /// <see href="https://saref.etsi.org/saref4watr/WaterMeterProperty"></see></summary>
    let WaterMeterProperty = _prefix "WaterMeterProperty"
    /// <summary>
    /// The time for which the battery has been operating since the last charge.
    /// <see href="https://saref.etsi.org/saref4watr/BatteryOperatingTime"></see></summary>
    let BatteryOperatingTime = _prefix "BatteryOperatingTime"
    /// <summary>
    /// The time until the battery is discharged.
    /// <see href="https://saref.etsi.org/saref4watr/BatteryRemainingTime"></see></summary>
    let BatteryRemainingTime = _prefix "BatteryRemainingTime"
    /// <summary>
    /// Property of the water indicating its concentration of benzene.
    /// <see href="https://saref.etsi.org/saref4watr/Benzene"></see></summary>
    let Benzene = _prefix "Benzene"
    /// <summary>
    /// Property of the water indicating its concentration of benzo(a)pyrene.
    /// <see href="https://saref.etsi.org/saref4watr/Benzoapyrene"></see></summary>
    let Benzoapyrene = _prefix "Benzoapyrene"
    /// <summary>
    /// Property of the water indicating its concentration of boron.
    /// <see href="https://saref.etsi.org/saref4watr/Boron"></see></summary>
    let Boron = _prefix "Boron"
    /// <summary>
    /// Property of the water indicating its concentration of bromate.
    /// <see href="https://saref.etsi.org/saref4watr/Bromate"></see></summary>
    let Bromate = _prefix "Bromate"
    /// <summary>
    /// Property of the water indicating its concentration of cadmium.
    /// <see href="https://saref.etsi.org/saref4watr/Cadmium"></see></summary>
    let Cadmium = _prefix "Cadmium"
    /// <summary>
    /// A channel is a passage of water flowing in an open conduit (i.e., subject to atmospheric pressure).
    /// <see href="https://saref.etsi.org/saref4watr/Channel"></see></summary>
    let Channel = _prefix "Channel"
    /// <summary>
    /// A main is a passage of water to flow through.
    /// <see href="https://saref.etsi.org/saref4watr/Main"></see></summary>
    let Main = _prefix "Main"
    /// <summary>
    /// Property of the water indicating its concentration of chloride.
    /// <see href="https://saref.etsi.org/saref4watr/Chloride"></see></summary>
    let Chloride = _prefix "Chloride"
    /// <summary>
    /// Property of the water indicating its concentration of chromium.
    /// <see href="https://saref.etsi.org/saref4watr/Chromium"></see></summary>
    let Chromium = _prefix "Chromium"
    /// <summary>
    /// Property of the water indicating its concentration of clostridium perfringens.
    /// <see href="https://saref.etsi.org/saref4watr/ClostridiumPerfringens"></see></summary>
    let ClostridiumPerfringens = _prefix "ClostridiumPerfringens"
    /// <summary>
    /// Property of the water indicating its concentration of coliform bacteria.
    /// <see href="https://saref.etsi.org/saref4watr/ColiformBacteria"></see></summary>
    let ColiformBacteria = _prefix "ColiformBacteria"
    /// <summary>
    /// Property of the water indicating its colony count at 22 ºC.
    /// <see href="https://saref.etsi.org/saref4watr/ColonyCount22C"></see></summary>
    let ColonyCount22C = _prefix "ColonyCount22C"
    /// <summary>
    /// Property of the water indicating its colony count at 37 ºC.
    /// <see href="https://saref.etsi.org/saref4watr/ColonyCount37C"></see></summary>
    let ColonyCount37C = _prefix "ColonyCount37C"
    /// <summary>
    /// Property of the water indicating its colour.
    /// <see href="https://saref.etsi.org/saref4watr/Colour"></see></summary>
    let Colour = _prefix "Colour"
    /// <summary>
    /// Property of the water indicating its conductivity.
    /// <see href="https://saref.etsi.org/saref4watr/Conductivity"></see></summary>
    let Conductivity = _prefix "Conductivity"
    /// <summary>
    /// A consumption-based tariff is a tariff that is based on consumption.
    /// <see href="https://saref.etsi.org/saref4watr/ConsumptionBasedTariff"></see></summary>
    let ConsumptionBasedTariff = _prefix "ConsumptionBasedTariff"
    /// <summary>
    /// A tariff is a schedule of rates or charges of a business or a public utility. Tariffs can be based on time, thresholds or consumption; however, combined tariffs may also exist that mix more than one of these types.
    /// <see href="https://saref.etsi.org/saref4watr/Tariff"></see></summary>
    let Tariff = _prefix "Tariff"
    /// <summary>
    /// Property of the water indicating its concentration of copper.
    /// <see href="https://saref.etsi.org/saref4watr/Copper"></see></summary>
    let Copper = _prefix "Copper"
    /// <summary>
    /// Property of the water indicating its concentration of cyanide.
    /// <see href="https://saref.etsi.org/saref4watr/Cyanide"></see></summary>
    let Cyanide = _prefix "Cyanide"
    /// <summary>
    /// A water distribution system is an infrastructure to carry potable water from a centralized treatment plant or wells to water consumers in order to adequately deliver water to satisfy residential, commercial, industrial and fire fighting requirements.
    /// <see href="https://saref.etsi.org/saref4watr/DistributionSystem"></see></summary>
    let DistributionSystem = _prefix "DistributionSystem"
    /// <summary>
    /// A water infrastructure is the set of facilities, services, and installations needed for water management.
    /// <see href="https://saref.etsi.org/saref4watr/WaterInfrastructure"></see></summary>
    let WaterInfrastructure = _prefix "WaterInfrastructure"
    /// <summary>
    /// Use of water for domestic purposes.
    /// <see href="https://saref.etsi.org/saref4watr/Domestic"></see></summary>
    let Domestic = _prefix "Domestic"
    /// <summary>
    /// Drinking water is water that is treated to comply with drinking water standards.
    /// <see href="https://saref.etsi.org/saref4watr/DrinkingWater"></see></summary>
    let DrinkingWater = _prefix "DrinkingWater"
    /// <summary>
    /// This class is used to define a particular quantity or body of water.
    /// <see href="https://saref.etsi.org/saref4watr/Water"></see></summary>
    let Water = _prefix "Water"
    /// <summary>
    /// Property of the water indicating its concentration of enterococci.
    /// <see href="https://saref.etsi.org/saref4watr/Enterococci"></see></summary>
    let Enterococci = _prefix "Enterococci"
    /// <summary>
    /// Property of the water indicating its concentration of epichlorohydrin.
    /// <see href="https://saref.etsi.org/saref4watr/Epichlorohydrin"></see></summary>
    let Epichlorohydrin = _prefix "Epichlorohydrin"
    /// <summary>
    /// Property of the water indicating its concentration of escherichia coli.
    /// <see href="https://saref.etsi.org/saref4watr/EscherichiaColi"></see></summary>
    let EscherichiaColi = _prefix "EscherichiaColi"
    /// <summary>
    /// An estuary is a partially enclosed coastal body of brackish water with one or more rivers or streams flowing into it, and with a free connection to the open sea.
    /// <see href="https://saref.etsi.org/saref4watr/Estuary"></see></summary>
    let Estuary = _prefix "Estuary"
    /// <summary>
    /// A sink asset is a water asset where water sinks.
    /// <see href="https://saref.etsi.org/saref4watr/SinkAsset"></see></summary>
    let SinkAsset = _prefix "SinkAsset"
    /// <summary>
    /// Property of the environment indicating the temperature.
    /// <see href="https://saref.etsi.org/saref4watr/ExternalTemperature"></see></summary>
    let ExternalTemperature = _prefix "ExternalTemperature"
    /// <summary>
    /// A fire hydrant is a fitting in a street or other public place with a nozzle by which a fire hose may be attached to a water main.
    /// <see href="https://saref.etsi.org/saref4watr/FireHydrant"></see></summary>
    let FireHydrant = _prefix "FireHydrant"
    /// <summary>
    /// A water device is a device that is also a water asset.
    /// <see href="https://saref.etsi.org/saref4watr/WaterDevice"></see></summary>
    let WaterDevice = _prefix "WaterDevice"
    /// <summary>
    /// Property indicating the pressure of a water flow.
    /// <see href="https://saref.etsi.org/saref4watr/FlowPressure"></see></summary>
    let FlowPressure = _prefix "FlowPressure"
    /// <summary>
    /// Class to group those properties related to water flow.
    /// <see href="https://saref.etsi.org/saref4watr/WaterFlowProperty"></see></summary>
    let WaterFlowProperty = _prefix "WaterFlowProperty"
    /// <summary>
    /// Property indicating the rate of a water flow.
    /// <see href="https://saref.etsi.org/saref4watr/FlowRate"></see></summary>
    let FlowRate = _prefix "FlowRate"
    /// <summary>
    /// Property indicating the temperature of a water flow.
    /// <see href="https://saref.etsi.org/saref4watr/FlowTemperature"></see></summary>
    let FlowTemperature = _prefix "FlowTemperature"
    /// <summary>
    /// Property indicating the volume of a water flow.
    /// <see href="https://saref.etsi.org/saref4watr/FlowVolume"></see></summary>
    let FlowVolume = _prefix "FlowVolume"
    /// <summary>
    /// Property of the water indicating its concentration of fluoride.
    /// <see href="https://saref.etsi.org/saref4watr/Fluoride"></see></summary>
    let Fluoride = _prefix "Fluoride"
    /// <summary>
    /// A gauging station is an infrastructure to monitor and test terrestrial bodies of water.
    /// <see href="https://saref.etsi.org/saref4watr/GaugingStation"></see></summary>
    let GaugingStation = _prefix "GaugingStation"
    /// <summary>
    /// A monitoring infrastructure is an infrastructure to monitor water.
    /// <see href="https://saref.etsi.org/saref4watr/MonitoringInfrastructure"></see></summary>
    let MonitoringInfrastructure = _prefix "MonitoringInfrastructure"
    /// <summary>
    /// A glacier is a persistent body of dense ice that is constantly moving under its own weight.
    /// <see href="https://saref.etsi.org/saref4watr/Glacier"></see></summary>
    let Glacier = _prefix "Glacier"
    /// <summary>
    /// A source asset is a water asset that is a natural source of water.
    /// <see href="https://saref.etsi.org/saref4watr/SourceAsset"></see></summary>
    let SourceAsset = _prefix "SourceAsset"
    /// <summary>
    /// Property of the water indicating its hardness.
    /// <see href="https://saref.etsi.org/saref4watr/Hardness"></see></summary>
    let Hardness = _prefix "Hardness"
    /// <summary>
    /// Property of the environment indicating the humidity.
    /// <see href="https://saref.etsi.org/saref4watr/Humidity"></see></summary>
    let Humidity = _prefix "Humidity"
    /// <summary>
    /// A hydroelectric power plant is an infrastructure to generate electricity by conversion of the energy of running water.
    /// <see href="https://saref.etsi.org/saref4watr/HydroelectricPowerPlant"></see></summary>
    let HydroelectricPowerPlant = _prefix "HydroelectricPowerPlant"
    /// <summary>
    /// Property of the water indicating its hydrogen ion concentration.
    /// <see href="https://saref.etsi.org/saref4watr/HydrogenIonConcentration"></see></summary>
    let HydrogenIonConcentration = _prefix "HydrogenIonConcentration"
    /// <summary>
    /// Use of water for industrial purposes.
    /// <see href="https://saref.etsi.org/saref4watr/Industry"></see></summary>
    let Industry = _prefix "Industry"
    /// <summary>
    /// An intake is an installation for obtaining water from a source of supply (river, lake, reservoir, and so on).
    /// <see href="https://saref.etsi.org/saref4watr/Intake"></see></summary>
    let Intake = _prefix "Intake"
    /// <summary>
    /// A transport asset is a water asset used to enable and support the transport and distribution of water.
    /// <see href="https://saref.etsi.org/saref4watr/TransportAsset"></see></summary>
    let TransportAsset = _prefix "TransportAsset"
    /// <summary>
    /// Property of the water indicating its concentration of iron.
    /// <see href="https://saref.etsi.org/saref4watr/Iron"></see></summary>
    let Iron = _prefix "Iron"
    /// <summary>
    /// A lagoon is a shallow body of water separated from a larger body of water by barrier islands or reefs.
    /// <see href="https://saref.etsi.org/saref4watr/Lagoon"></see></summary>
    let Lagoon = _prefix "Lagoon"
    /// <summary>
    /// A lake is an area filled with water, localized in a basin, surrounded by land, apart from any river or other outlet that serves to feed or drain the lake.
    /// <see href="https://saref.etsi.org/saref4watr/Lake"></see></summary>
    let Lake = _prefix "Lake"
    /// <summary>
    /// Property of the water indicating its concentration of lead.
    /// <see href="https://saref.etsi.org/saref4watr/Lead"></see></summary>
    let Lead = _prefix "Lead"
    /// <summary>
    /// Property of the water indicating its concentration of manganese.
    /// <see href="https://saref.etsi.org/saref4watr/Manganese"></see></summary>
    let Manganese = _prefix "Manganese"
    /// <summary>
    /// A maintenance hole is an enclosure that facilitates human access to and working space for equipment.
    /// <see href="https://saref.etsi.org/saref4watr/Manhole"></see></summary>
    let Manhole = _prefix "Manhole"
    /// <summary>
    /// Property of the water indicating its concentration of mercury.
    /// <see href="https://saref.etsi.org/saref4watr/Mercury"></see></summary>
    let Mercury = _prefix "Mercury"
    /// <summary>
    /// The duration of the meter power up.
    /// <see href="https://saref.etsi.org/saref4watr/MeterOnTime"></see></summary>
    let MeterOnTime = _prefix "MeterOnTime"
    /// <summary>
    /// The time for which the meter has been operating.
    /// <see href="https://saref.etsi.org/saref4watr/MeterOperatingTime"></see></summary>
    let MeterOperatingTime = _prefix "MeterOperatingTime"
    /// <summary>
    /// Property of the water indicating its concentration of nickel.
    /// <see href="https://saref.etsi.org/saref4watr/Nickel"></see></summary>
    let Nickel = _prefix "Nickel"
    /// <summary>
    /// Property of the water indicating its concentration of nitrate.
    /// <see href="https://saref.etsi.org/saref4watr/Nitrate"></see></summary>
    let Nitrate = _prefix "Nitrate"
    /// <summary>
    /// Property of the water indicating its concentration of nitrite.
    /// <see href="https://saref.etsi.org/saref4watr/Nitrite"></see></summary>
    let Nitrite = _prefix "Nitrite"
    /// <summary>
    /// An ocean is a large body of salt water.
    /// <see href="https://saref.etsi.org/saref4watr/Ocean"></see></summary>
    let Ocean = _prefix "Ocean"
    /// <summary>
    /// Property of the water indicating its odour.
    /// <see href="https://saref.etsi.org/saref4watr/Odour"></see></summary>
    let Odour = _prefix "Odour"
    /// <summary>
    /// Property of the water indicating its oxidisability.
    /// <see href="https://saref.etsi.org/saref4watr/Oxidisability"></see></summary>
    let Oxidisability = _prefix "Oxidisability"
    /// <summary>
    /// Property of the water indicating its oxygen saturation.
    /// <see href="https://saref.etsi.org/saref4watr/Oxygen"></see></summary>
    let Oxygen = _prefix "Oxygen"
    /// <summary>
    /// A pipe is a passage of water flowing in a closed conduit (i.e., not subject to atmospheric pressure).
    /// <see href="https://saref.etsi.org/saref4watr/Pipe"></see></summary>
    let Pipe = _prefix "Pipe"
    /// <summary>
    /// A pit is a well or hole sunk in the ground to procure, store or drain water.
    /// <see href="https://saref.etsi.org/saref4watr/Pit"></see></summary>
    let Pit = _prefix "Pit"
    /// <summary>
    /// Property of the water indicating its concentration of polycyclic aromatic hydrocarbons.
    /// <see href="https://saref.etsi.org/saref4watr/PolycyclicAromaticHydrocarbons"></see></summary>
    let PolycyclicAromaticHydrocarbons = _prefix "PolycyclicAromaticHydrocarbons"
    /// <summary>
    /// Property of the environment indicating the precipitation.
    /// <see href="https://saref.etsi.org/saref4watr/Precipitation"></see></summary>
    let Precipitation = _prefix "Precipitation"
    /// <summary>
    /// Property of the water indicating its concentration of pseudomonas aeruginosa.
    /// <see href="https://saref.etsi.org/saref4watr/PseudomonasAeruginosa"></see></summary>
    let PseudomonasAeruginosa = _prefix "PseudomonasAeruginosa"
    /// <summary>
    /// A pump is a device for moving water by mechanical action.
    /// <see href="https://saref.etsi.org/saref4watr/Pump"></see></summary>
    let Pump = _prefix "Pump"
    /// <summary>
    /// Raw water is water found in the environment that has not been treated and does not have any of its minerals, ions, particles, bacteria, or parasites removed.
    /// <see href="https://saref.etsi.org/saref4watr/RawWater"></see></summary>
    let RawWater = _prefix "RawWater"
    /// <summary>
    /// Use of water for recreational purposes.
    /// <see href="https://saref.etsi.org/saref4watr/Recreation"></see></summary>
    let Recreation = _prefix "Recreation"
    /// <summary>
    /// A reservoir is an enlarged natural or artificial lake, pond or impoundment created using a dam or lock to store water.
    /// <see href="https://saref.etsi.org/saref4watr/Reservoir"></see></summary>
    let Reservoir = _prefix "Reservoir"
    /// <summary>
    /// A river is a natural flowing watercourse, usually freshwater, flowing towards an ocean, sea, lake or another river.
    /// <see href="https://saref.etsi.org/saref4watr/River"></see></summary>
    let River = _prefix "River"
    /// <summary>
    /// A sea is a body of salt water partly or fully enclosed by land.
    /// <see href="https://saref.etsi.org/saref4watr/Sea"></see></summary>
    let Sea = _prefix "Sea"
    /// <summary>
    /// Property of the water indicating its concentration of selenium.
    /// <see href="https://saref.etsi.org/saref4watr/Selenium"></see></summary>
    let Selenium = _prefix "Selenium"
    /// <summary>
    /// A water asset is a physical entity used in the process of transporting, treating, storing and distributing water.
    /// <see href="https://saref.etsi.org/saref4watr/WaterAsset"></see></summary>
    let WaterAsset = _prefix "WaterAsset"
    /// <summary>
    /// Property of the water indicating its concentration of sodium.
    /// <see href="https://saref.etsi.org/saref4watr/Sodium"></see></summary>
    let Sodium = _prefix "Sodium"
    /// <summary>
    /// An storage infrastructure is an infrastructure to storage both potable water for consumption, and non potable water for use in agriculture.
    /// <see href="https://saref.etsi.org/saref4watr/StorageInfrastructure"></see></summary>
    let StorageInfrastructure = _prefix "StorageInfrastructure"
    /// <summary>
    /// Stormwater is water that originates during precipitation events and snow/ice melt.
    /// <see href="https://saref.etsi.org/saref4watr/Stormwater"></see></summary>
    let Stormwater = _prefix "Stormwater"
    /// <summary>
    /// Property of the water indicating its concentration of sulphate.
    /// <see href="https://saref.etsi.org/saref4watr/Sulphate"></see></summary>
    let Sulphate = _prefix "Sulphate"
    /// <summary>
    /// A tank is a container for storing water.
    /// <see href="https://saref.etsi.org/saref4watr/Tank"></see></summary>
    let Tank = _prefix "Tank"
    /// <summary>
    /// Property of the water indicating its taste.
    /// <see href="https://saref.etsi.org/saref4watr/Taste"></see></summary>
    let Taste = _prefix "Taste"
    /// <summary>
    /// Property of the water indicating its temperature.
    /// <see href="https://saref.etsi.org/saref4watr/Temperature"></see></summary>
    let Temperature = _prefix "Temperature"
    /// <summary>
    /// Property of the water indicating its concentration of tetrachloroethene.
    /// <see href="https://saref.etsi.org/saref4watr/Tetrachloroethene"></see></summary>
    let Tetrachloroethene = _prefix "Tetrachloroethene"
    /// <summary>
    /// A threshold-based tariff is a tariff that is based on a threshold.
    /// <see href="https://saref.etsi.org/saref4watr/ThresholdBasedTariff"></see></summary>
    let ThresholdBasedTariff = _prefix "ThresholdBasedTariff"
    /// <summary>
    /// A time-based tariff is a tariff that is based on time.
    /// <see href="https://saref.etsi.org/saref4watr/TimeBasedTariff"></see></summary>
    let TimeBasedTariff = _prefix "TimeBasedTariff"
    /// <summary>
    /// Property of the water indicating the dissolved combined content of all inorganic and organic substances present in a sample of water.
    /// <see href="https://saref.etsi.org/saref4watr/TotalDissolvedSolids"></see></summary>
    let TotalDissolvedSolids = _prefix "TotalDissolvedSolids"
    /// <summary>
    /// Property of the water indicating its total indicative dose.
    /// <see href="https://saref.etsi.org/saref4watr/TotalIndicativeDose"></see></summary>
    let TotalIndicativeDose = _prefix "TotalIndicativeDose"
    /// <summary>
    /// Property of the water indicating its concentration of total organic carbon.
    /// <see href="https://saref.etsi.org/saref4watr/TotalOrganicCarbon"></see></summary>
    let TotalOrganicCarbon = _prefix "TotalOrganicCarbon"
    /// <summary>
    /// Property of the water indicating the dry-weight of suspended particles, that are not dissolved, in a sample of water.
    /// <see href="https://saref.etsi.org/saref4watr/TotalSuspendedSolids"></see></summary>
    let TotalSuspendedSolids = _prefix "TotalSuspendedSolids"
    /// <summary>
    /// A treatment plant is an infrastructure to improve the quality of water to make it more acceptable for a specific end-use.
    /// <see href="https://saref.etsi.org/saref4watr/TreatmentPlant"></see></summary>
    let TreatmentPlant = _prefix "TreatmentPlant"
    /// <summary>
    /// Property of the water indicating its concentration of trichloroethene.
    /// <see href="https://saref.etsi.org/saref4watr/Trichloroethene"></see></summary>
    let Trichloroethene = _prefix "Trichloroethene"
    /// <summary>
    /// Property of the water indicating its concentration of trihalomethanes.
    /// <see href="https://saref.etsi.org/saref4watr/Trihalomethanes"></see></summary>
    let Trihalomethanes = _prefix "Trihalomethanes"
    /// <summary>
    /// Property of the water indicating its concentration of tritium.
    /// <see href="https://saref.etsi.org/saref4watr/Tritium"></see></summary>
    let Tritium = _prefix "Tritium"
    /// <summary>
    /// Property of the water indicating its turbidity.
    /// <see href="https://saref.etsi.org/saref4watr/Turbidity"></see></summary>
    let Turbidity = _prefix "Turbidity"
    /// <summary>
    /// A valve is a device designed to control water flow, pressure or volume.
    /// <see href="https://saref.etsi.org/saref4watr/Valve"></see></summary>
    let Valve = _prefix "Valve"
    /// <summary>
    /// A vent is the part of a system that allows air to enter a plumbing system to maintain proper air pressure and sewer gases to escape to the outside.
    /// <see href="https://saref.etsi.org/saref4watr/Vent"></see></summary>
    let Vent = _prefix "Vent"
    /// <summary>
    /// Property of the water indicating its concentration of vinyl chloride.
    /// <see href="https://saref.etsi.org/saref4watr/VinylChloride"></see></summary>
    let VinylChloride = _prefix "VinylChloride"
    /// <summary>
    /// Wastewater is water that has been used in the home, in a business, or as part of an industrial process.
    /// <see href="https://saref.etsi.org/saref4watr/Wastewater"></see></summary>
    let Wastewater = _prefix "Wastewater"
    /// <summary>
    /// The type of water for which an infrastructure is designed for.
    /// <see href="https://saref.etsi.org/saref4watr/isDesignedFor"></see></summary>
    let isDesignedFor = _prefix "isDesignedFor"
    /// <summary>
    /// The intended use of the infrastructure.
    /// <see href="https://saref.etsi.org/saref4watr/isIntendedFor"></see></summary>
    let isIntendedFor = _prefix "isIntendedFor"
    /// <summary>
    /// A water meter is an instrument intended to measure continuously, memorize, and display the volume of water passing through the meter.
    /// <see href="https://saref.etsi.org/saref4watr/WaterMeter"></see></summary>
    let WaterMeter = _prefix "WaterMeter"
    /// <summary>
    /// The version of a device.
    /// <see href="https://saref.etsi.org/saref4watr/hasVersion"></see></summary>
    let hasVersion = _prefix "hasVersion"
    /// <summary>
    /// The fabrication number of a device.
    /// <see href="https://saref.etsi.org/saref4watr/hasFabricationNumber"></see></summary>
    let hasFabricationNumber = _prefix "hasFabricationNumber"
    /// <summary>
    /// The hardware version of a device.
    /// <see href="https://saref.etsi.org/saref4watr/hasHardwareVersion"></see></summary>
    let hasHardwareVersion = _prefix "hasHardwareVersion"
    /// <summary>
    /// The firmware version of a device.
    /// <see href="https://saref.etsi.org/saref4watr/hasFirmwareVersion"></see></summary>
    let hasFirmwareVersion = _prefix "hasFirmwareVersion"
    /// <summary>
    /// The water meter to which a tariff applies to.
    /// <see href="https://saref.etsi.org/saref4watr/appliesTo"></see></summary>
    let appliesTo = _prefix "appliesTo"
    /// <summary>
    /// A relationship specifying the features of interest that are controlled by a device.
    /// <see href="https://saref.etsi.org/saref4watr/controlsFeature"></see></summary>
    let controlsFeature = _prefix "controlsFeature"
    /// <summary>
    /// A relationship specifying the devices that control a feature of interest.
    /// <see href="https://saref.etsi.org/saref4watr/featureIsControlledByDevice"></see></summary>
    let featureIsControlledByDevice = _prefix "featureIsControlledByDevice"
    /// <summary>
    /// A relationship specifying the devices that measure a feature of interest.
    /// <see href="https://saref.etsi.org/saref4watr/featureIsMeasuredByDevice"></see></summary>
    let featureIsMeasuredByDevice = _prefix "featureIsMeasuredByDevice"
    /// <summary>
    /// The time interval in each day for which a tariff is applied (e.g., 8:00 to 10:00).
    /// <see href="https://saref.etsi.org/saref4watr/forAbsoluteTimeAtDay"></see></summary>
    let forAbsoluteTimeAtDay = _prefix "forAbsoluteTimeAtDay"
    /// <summary>
    /// The day of the month for which a tariff is applied (e.g., each 15).
    /// <see href="https://saref.etsi.org/saref4watr/forDayInMonth"></see></summary>
    let forDayInMonth = _prefix "forDayInMonth"
    /// <summary>
    /// The financial consumption related to a tariff (e.g., prepaid tariffs).
    /// <see href="https://saref.etsi.org/saref4watr/forFinancialConsumption"></see></summary>
    let forFinancialConsumption = _prefix "forFinancialConsumption"
    /// <summary>
    /// The volume consumption related to a tariff (e.g., after consumption of 900 litres).
    /// <see href="https://saref.etsi.org/saref4watr/forVolumeConsumption"></see></summary>
    let forVolumeConsumption = _prefix "forVolumeConsumption"
    /// <summary>
    /// The volume flow related to a tariff.
    /// <see href="https://saref.etsi.org/saref4watr/forVolumeFlow"></see></summary>
    let forVolumeFlow = _prefix "forVolumeFlow"
    /// <summary>
    /// The day of the week for which a tariff is applied (e.g., each Saturday and Sunday).
    /// <see href="https://saref.etsi.org/saref4watr/forWeekDay"></see></summary>
    let forWeekDay = _prefix "forWeekDay"
    /// <summary>
    /// The billing date of a tariff.
    /// <see href="https://saref.etsi.org/saref4watr/hasBillingDate"></see></summary>
    let hasBillingDate = _prefix "hasBillingDate"
    /// <summary>
    /// The billing period of a tariff.
    /// <see href="https://saref.etsi.org/saref4watr/hasBillingPeriod"></see></summary>
    let hasBillingPeriod = _prefix "hasBillingPeriod"
    /// <summary>
    /// The duration of a tariff.
    /// <see href="https://saref.etsi.org/saref4watr/hasDuration"></see></summary>
    let hasDuration = _prefix "hasDuration"
    /// <summary>
    /// The period of a tariff.
    /// <see href="https://saref.etsi.org/saref4watr/hasPeriod"></see></summary>
    let hasPeriod = _prefix "hasPeriod"
    /// <summary>
    /// The time for which the value of a measurement applies to the feature of interest.
    /// <see href="https://saref.etsi.org/saref4watr/hasPhenomenonTime"></see></summary>
    let hasPhenomenonTime = _prefix "hasPhenomenonTime"
    /// <summary>
    /// The start date and time of a tariff.
    /// <see href="https://saref.etsi.org/saref4watr/hasStartTimestamp"></see></summary>
    let hasStartTimestamp = _prefix "hasStartTimestamp"
    /// <summary>
    /// A relationship specifying the features of interest that are measured by a device.
    /// <see href="https://saref.etsi.org/saref4watr/measuresFeature"></see></summary>
    let measuresFeature = _prefix "measuresFeature"
    /// <summary>
    /// The radio frequency at which a device operates.
    /// <see href="https://saref.etsi.org/saref4watr/operatesAtRadioFrequency"></see></summary>
    let operatesAtRadioFrequency = _prefix "operatesAtRadioFrequency"
    /// <summary>
    /// The power required by a device.
    /// <see href="https://saref.etsi.org/saref4watr/requiresPower"></see></summary>
    let requiresPower = _prefix "requiresPower"
