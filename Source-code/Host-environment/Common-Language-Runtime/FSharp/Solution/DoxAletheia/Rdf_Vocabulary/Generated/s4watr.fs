namespace https.saref.etsi.org.saref4watr.slash

open DoxAletheia.Rdf_Vocabulary

module s4watr =
    let _namespace_name = "https://saref.etsi.org/saref4watr/"
    /// <summary>
    ///   <see href="https://saref.etsi.org/saref4watr/v1.1.1/"></see>
    /// </summary>
    let ``v1.1.1/`` = Namespaced_IRI.parse _namespace_name "v1.1.1/" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of 1,2-dichloroethane.
    /// <see href="https://saref.etsi.org/saref4watr/12Dichloroethane"></see></summary>
    let _12Dichloroethane =
        Namespaced_IRI.parse _namespace_name "12Dichloroethane" |> NamespacedName

    /// <summary>
    /// A chemical property is a property of water that is related to chemical components.
    /// <see href="https://saref.etsi.org/saref4watr/ChemicalProperty"></see></summary>
    let ChemicalProperty =
        Namespaced_IRI.parse _namespace_name "ChemicalProperty" |> NamespacedName

    /// <summary>
    /// An acceptability property is a property of water that is related to its acceptability.
    /// <see href="https://saref.etsi.org/saref4watr/AcceptabilityProperty"></see></summary>
    let AcceptabilityProperty =
        Namespaced_IRI.parse _namespace_name "AcceptabilityProperty" |> NamespacedName

    /// <summary>
    /// Class to group those properties related to the water.
    /// <see href="https://saref.etsi.org/saref4watr/WaterProperty"></see></summary>
    let WaterProperty =
        Namespaced_IRI.parse _namespace_name "WaterProperty" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of acrylamide.
    /// <see href="https://saref.etsi.org/saref4watr/Acrylamide"></see></summary>
    let Acrylamide = Namespaced_IRI.parse _namespace_name "Acrylamide" |> NamespacedName

    /// <summary>
    /// Use of water for the farming of plants and livestock.
    /// <see href="https://saref.etsi.org/saref4watr/Agriculture"></see></summary>
    let Agriculture =
        Namespaced_IRI.parse _namespace_name "Agriculture" |> NamespacedName

    /// <summary>
    /// This class is used to define the different uses of water.
    /// <see href="https://saref.etsi.org/saref4watr/WaterUse"></see></summary>
    let WaterUse = Namespaced_IRI.parse _namespace_name "WaterUse" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its concentration of aluminium.
    /// <see href="https://saref.etsi.org/saref4watr/Aluminium"></see></summary>
    let Aluminium = Namespaced_IRI.parse _namespace_name "Aluminium" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its concentration of ammonium.
    /// <see href="https://saref.etsi.org/saref4watr/Ammonium"></see></summary>
    let Ammonium = Namespaced_IRI.parse _namespace_name "Ammonium" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its concentration of antimony.
    /// <see href="https://saref.etsi.org/saref4watr/Antimony"></see></summary>
    let Antimony = Namespaced_IRI.parse _namespace_name "Antimony" |> NamespacedName

    /// <summary>
    /// Use of water for the farming of fish, crustaceans, molluscs, aquatic plants, algae, and other organisms.
    /// <see href="https://saref.etsi.org/saref4watr/Aquaculture"></see></summary>
    let Aquaculture =
        Namespaced_IRI.parse _namespace_name "Aquaculture" |> NamespacedName

    /// <summary>
    /// An aquifer is an underground layer of water-bearing permeable rock, rock fractures or unconsolidated materials.
    /// <see href="https://saref.etsi.org/saref4watr/Aquifer"></see></summary>
    let Aquifer = Namespaced_IRI.parse _namespace_name "Aquifer" |> NamespacedName

    /// <summary>
    /// A storage asset is a water asset used to store water.
    /// <see href="https://saref.etsi.org/saref4watr/StorageAsset"></see></summary>
    let StorageAsset =
        Namespaced_IRI.parse _namespace_name "StorageAsset" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of arsenic.
    /// <see href="https://saref.etsi.org/saref4watr/Arsenic"></see></summary>
    let Arsenic = Namespaced_IRI.parse _namespace_name "Arsenic" |> NamespacedName

    /// <summary>
    /// Property of the environment indicating the atmospheric pressure.
    /// <see href="https://saref.etsi.org/saref4watr/AtmosphericPressure"></see></summary>
    let AtmosphericPressure =
        Namespaced_IRI.parse _namespace_name "AtmosphericPressure" |> NamespacedName

    /// <summary>
    /// Class to group those properties related to the environment.
    /// <see href="https://saref.etsi.org/saref4watr/EnvironmentalProperty"></see></summary>
    let EnvironmentalProperty =
        Namespaced_IRI.parse _namespace_name "EnvironmentalProperty" |> NamespacedName

    /// <summary>
    /// A bacterial property is a property of water that is related to bacteria.
    /// <see href="https://saref.etsi.org/saref4watr/BacterialProperty"></see></summary>
    let BacterialProperty =
        Namespaced_IRI.parse _namespace_name "BacterialProperty" |> NamespacedName

    /// <summary>
    /// A microbial property is a property of water that is related to microbes.
    /// <see href="https://saref.etsi.org/saref4watr/MicrobialProperty"></see></summary>
    let MicrobialProperty =
        Namespaced_IRI.parse _namespace_name "MicrobialProperty" |> NamespacedName

    /// <summary>
    /// The time in which the battery was last changed.
    /// <see href="https://saref.etsi.org/saref4watr/BatteryLastChange"></see></summary>
    let BatteryLastChange =
        Namespaced_IRI.parse _namespace_name "BatteryLastChange" |> NamespacedName

    /// <summary>
    /// Class to group those properties related to water meters.
    /// <see href="https://saref.etsi.org/saref4watr/WaterMeterProperty"></see></summary>
    let WaterMeterProperty =
        Namespaced_IRI.parse _namespace_name "WaterMeterProperty" |> NamespacedName

    /// <summary>
    /// The time for which the battery has been operating since the last charge.
    /// <see href="https://saref.etsi.org/saref4watr/BatteryOperatingTime"></see></summary>
    let BatteryOperatingTime =
        Namespaced_IRI.parse _namespace_name "BatteryOperatingTime" |> NamespacedName

    /// <summary>
    /// The time until the battery is discharged.
    /// <see href="https://saref.etsi.org/saref4watr/BatteryRemainingTime"></see></summary>
    let BatteryRemainingTime =
        Namespaced_IRI.parse _namespace_name "BatteryRemainingTime" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of benzene.
    /// <see href="https://saref.etsi.org/saref4watr/Benzene"></see></summary>
    let Benzene = Namespaced_IRI.parse _namespace_name "Benzene" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of benzo(a)pyrene.
    /// <see href="https://saref.etsi.org/saref4watr/Benzoapyrene"></see></summary>
    let Benzoapyrene =
        Namespaced_IRI.parse _namespace_name "Benzoapyrene" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of boron.
    /// <see href="https://saref.etsi.org/saref4watr/Boron"></see></summary>
    let Boron = Namespaced_IRI.parse _namespace_name "Boron" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its concentration of bromate.
    /// <see href="https://saref.etsi.org/saref4watr/Bromate"></see></summary>
    let Bromate = Namespaced_IRI.parse _namespace_name "Bromate" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its concentration of cadmium.
    /// <see href="https://saref.etsi.org/saref4watr/Cadmium"></see></summary>
    let Cadmium = Namespaced_IRI.parse _namespace_name "Cadmium" |> NamespacedName
    /// <summary>
    /// A channel is a passage of water flowing in an open conduit (i.e., subject to atmospheric pressure).
    /// <see href="https://saref.etsi.org/saref4watr/Channel"></see></summary>
    let Channel = Namespaced_IRI.parse _namespace_name "Channel" |> NamespacedName
    /// <summary>
    /// A main is a passage of water to flow through.
    /// <see href="https://saref.etsi.org/saref4watr/Main"></see></summary>
    let Main = Namespaced_IRI.parse _namespace_name "Main" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its concentration of chloride.
    /// <see href="https://saref.etsi.org/saref4watr/Chloride"></see></summary>
    let Chloride = Namespaced_IRI.parse _namespace_name "Chloride" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its concentration of chromium.
    /// <see href="https://saref.etsi.org/saref4watr/Chromium"></see></summary>
    let Chromium = Namespaced_IRI.parse _namespace_name "Chromium" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of clostridium perfringens.
    /// <see href="https://saref.etsi.org/saref4watr/ClostridiumPerfringens"></see></summary>
    let ClostridiumPerfringens =
        Namespaced_IRI.parse _namespace_name "ClostridiumPerfringens" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of coliform bacteria.
    /// <see href="https://saref.etsi.org/saref4watr/ColiformBacteria"></see></summary>
    let ColiformBacteria =
        Namespaced_IRI.parse _namespace_name "ColiformBacteria" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its colony count at 22 ºC.
    /// <see href="https://saref.etsi.org/saref4watr/ColonyCount22C"></see></summary>
    let ColonyCount22C =
        Namespaced_IRI.parse _namespace_name "ColonyCount22C" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its colony count at 37 ºC.
    /// <see href="https://saref.etsi.org/saref4watr/ColonyCount37C"></see></summary>
    let ColonyCount37C =
        Namespaced_IRI.parse _namespace_name "ColonyCount37C" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its colour.
    /// <see href="https://saref.etsi.org/saref4watr/Colour"></see></summary>
    let Colour = Namespaced_IRI.parse _namespace_name "Colour" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its conductivity.
    /// <see href="https://saref.etsi.org/saref4watr/Conductivity"></see></summary>
    let Conductivity =
        Namespaced_IRI.parse _namespace_name "Conductivity" |> NamespacedName

    /// <summary>
    /// A consumption-based tariff is a tariff that is based on consumption.
    /// <see href="https://saref.etsi.org/saref4watr/ConsumptionBasedTariff"></see></summary>
    let ConsumptionBasedTariff =
        Namespaced_IRI.parse _namespace_name "ConsumptionBasedTariff" |> NamespacedName

    /// <summary>
    /// A tariff is a schedule of rates or charges of a business or a public utility. Tariffs can be based on time, thresholds or consumption; however, combined tariffs may also exist that mix more than one of these types.
    /// <see href="https://saref.etsi.org/saref4watr/Tariff"></see></summary>
    let Tariff = Namespaced_IRI.parse _namespace_name "Tariff" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its concentration of copper.
    /// <see href="https://saref.etsi.org/saref4watr/Copper"></see></summary>
    let Copper = Namespaced_IRI.parse _namespace_name "Copper" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its concentration of cyanide.
    /// <see href="https://saref.etsi.org/saref4watr/Cyanide"></see></summary>
    let Cyanide = Namespaced_IRI.parse _namespace_name "Cyanide" |> NamespacedName

    /// <summary>
    /// A water distribution system is an infrastructure to carry potable water from a centralized treatment plant or wells to water consumers in order to adequately deliver water to satisfy residential, commercial, industrial and fire fighting requirements.
    /// <see href="https://saref.etsi.org/saref4watr/DistributionSystem"></see></summary>
    let DistributionSystem =
        Namespaced_IRI.parse _namespace_name "DistributionSystem" |> NamespacedName

    /// <summary>
    /// A water infrastructure is the set of facilities, services, and installations needed for water management.
    /// <see href="https://saref.etsi.org/saref4watr/WaterInfrastructure"></see></summary>
    let WaterInfrastructure =
        Namespaced_IRI.parse _namespace_name "WaterInfrastructure" |> NamespacedName

    /// <summary>
    /// Use of water for domestic purposes.
    /// <see href="https://saref.etsi.org/saref4watr/Domestic"></see></summary>
    let Domestic = Namespaced_IRI.parse _namespace_name "Domestic" |> NamespacedName

    /// <summary>
    /// Drinking water is water that is treated to comply with drinking water standards.
    /// <see href="https://saref.etsi.org/saref4watr/DrinkingWater"></see></summary>
    let DrinkingWater =
        Namespaced_IRI.parse _namespace_name "DrinkingWater" |> NamespacedName

    /// <summary>
    /// This class is used to define a particular quantity or body of water.
    /// <see href="https://saref.etsi.org/saref4watr/Water"></see></summary>
    let Water = Namespaced_IRI.parse _namespace_name "Water" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of enterococci.
    /// <see href="https://saref.etsi.org/saref4watr/Enterococci"></see></summary>
    let Enterococci =
        Namespaced_IRI.parse _namespace_name "Enterococci" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of epichlorohydrin.
    /// <see href="https://saref.etsi.org/saref4watr/Epichlorohydrin"></see></summary>
    let Epichlorohydrin =
        Namespaced_IRI.parse _namespace_name "Epichlorohydrin" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of escherichia coli.
    /// <see href="https://saref.etsi.org/saref4watr/EscherichiaColi"></see></summary>
    let EscherichiaColi =
        Namespaced_IRI.parse _namespace_name "EscherichiaColi" |> NamespacedName

    /// <summary>
    /// An estuary is a partially enclosed coastal body of brackish water with one or more rivers or streams flowing into it, and with a free connection to the open sea.
    /// <see href="https://saref.etsi.org/saref4watr/Estuary"></see></summary>
    let Estuary = Namespaced_IRI.parse _namespace_name "Estuary" |> NamespacedName
    /// <summary>
    /// A sink asset is a water asset where water sinks.
    /// <see href="https://saref.etsi.org/saref4watr/SinkAsset"></see></summary>
    let SinkAsset = Namespaced_IRI.parse _namespace_name "SinkAsset" |> NamespacedName

    /// <summary>
    /// Property of the environment indicating the temperature.
    /// <see href="https://saref.etsi.org/saref4watr/ExternalTemperature"></see></summary>
    let ExternalTemperature =
        Namespaced_IRI.parse _namespace_name "ExternalTemperature" |> NamespacedName

    /// <summary>
    /// A fire hydrant is a fitting in a street or other public place with a nozzle by which a fire hose may be attached to a water main.
    /// <see href="https://saref.etsi.org/saref4watr/FireHydrant"></see></summary>
    let FireHydrant =
        Namespaced_IRI.parse _namespace_name "FireHydrant" |> NamespacedName

    /// <summary>
    /// A water device is a device that is also a water asset.
    /// <see href="https://saref.etsi.org/saref4watr/WaterDevice"></see></summary>
    let WaterDevice =
        Namespaced_IRI.parse _namespace_name "WaterDevice" |> NamespacedName

    /// <summary>
    /// Property indicating the pressure of a water flow.
    /// <see href="https://saref.etsi.org/saref4watr/FlowPressure"></see></summary>
    let FlowPressure =
        Namespaced_IRI.parse _namespace_name "FlowPressure" |> NamespacedName

    /// <summary>
    /// Class to group those properties related to water flow.
    /// <see href="https://saref.etsi.org/saref4watr/WaterFlowProperty"></see></summary>
    let WaterFlowProperty =
        Namespaced_IRI.parse _namespace_name "WaterFlowProperty" |> NamespacedName

    /// <summary>
    /// Property indicating the rate of a water flow.
    /// <see href="https://saref.etsi.org/saref4watr/FlowRate"></see></summary>
    let FlowRate = Namespaced_IRI.parse _namespace_name "FlowRate" |> NamespacedName

    /// <summary>
    /// Property indicating the temperature of a water flow.
    /// <see href="https://saref.etsi.org/saref4watr/FlowTemperature"></see></summary>
    let FlowTemperature =
        Namespaced_IRI.parse _namespace_name "FlowTemperature" |> NamespacedName

    /// <summary>
    /// Property indicating the volume of a water flow.
    /// <see href="https://saref.etsi.org/saref4watr/FlowVolume"></see></summary>
    let FlowVolume = Namespaced_IRI.parse _namespace_name "FlowVolume" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its concentration of fluoride.
    /// <see href="https://saref.etsi.org/saref4watr/Fluoride"></see></summary>
    let Fluoride = Namespaced_IRI.parse _namespace_name "Fluoride" |> NamespacedName

    /// <summary>
    /// A gauging station is an infrastructure to monitor and test terrestrial bodies of water.
    /// <see href="https://saref.etsi.org/saref4watr/GaugingStation"></see></summary>
    let GaugingStation =
        Namespaced_IRI.parse _namespace_name "GaugingStation" |> NamespacedName

    /// <summary>
    /// A monitoring infrastructure is an infrastructure to monitor water.
    /// <see href="https://saref.etsi.org/saref4watr/MonitoringInfrastructure"></see></summary>
    let MonitoringInfrastructure =
        Namespaced_IRI.parse _namespace_name "MonitoringInfrastructure" |> NamespacedName

    /// <summary>
    /// A glacier is a persistent body of dense ice that is constantly moving under its own weight.
    /// <see href="https://saref.etsi.org/saref4watr/Glacier"></see></summary>
    let Glacier = Namespaced_IRI.parse _namespace_name "Glacier" |> NamespacedName

    /// <summary>
    /// A source asset is a water asset that is a natural source of water.
    /// <see href="https://saref.etsi.org/saref4watr/SourceAsset"></see></summary>
    let SourceAsset =
        Namespaced_IRI.parse _namespace_name "SourceAsset" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its hardness.
    /// <see href="https://saref.etsi.org/saref4watr/Hardness"></see></summary>
    let Hardness = Namespaced_IRI.parse _namespace_name "Hardness" |> NamespacedName
    /// <summary>
    /// Property of the environment indicating the humidity.
    /// <see href="https://saref.etsi.org/saref4watr/Humidity"></see></summary>
    let Humidity = Namespaced_IRI.parse _namespace_name "Humidity" |> NamespacedName

    /// <summary>
    /// A hydroelectric power plant is an infrastructure to generate electricity by conversion of the energy of running water.
    /// <see href="https://saref.etsi.org/saref4watr/HydroelectricPowerPlant"></see></summary>
    let HydroelectricPowerPlant =
        Namespaced_IRI.parse _namespace_name "HydroelectricPowerPlant" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its hydrogen ion concentration.
    /// <see href="https://saref.etsi.org/saref4watr/HydrogenIonConcentration"></see></summary>
    let HydrogenIonConcentration =
        Namespaced_IRI.parse _namespace_name "HydrogenIonConcentration" |> NamespacedName

    /// <summary>
    /// Use of water for industrial purposes.
    /// <see href="https://saref.etsi.org/saref4watr/Industry"></see></summary>
    let Industry = Namespaced_IRI.parse _namespace_name "Industry" |> NamespacedName
    /// <summary>
    /// An intake is an installation for obtaining water from a source of supply (river, lake, reservoir, and so on).
    /// <see href="https://saref.etsi.org/saref4watr/Intake"></see></summary>
    let Intake = Namespaced_IRI.parse _namespace_name "Intake" |> NamespacedName

    /// <summary>
    /// A transport asset is a water asset used to enable and support the transport and distribution of water.
    /// <see href="https://saref.etsi.org/saref4watr/TransportAsset"></see></summary>
    let TransportAsset =
        Namespaced_IRI.parse _namespace_name "TransportAsset" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of iron.
    /// <see href="https://saref.etsi.org/saref4watr/Iron"></see></summary>
    let Iron = Namespaced_IRI.parse _namespace_name "Iron" |> NamespacedName
    /// <summary>
    /// A lagoon is a shallow body of water separated from a larger body of water by barrier islands or reefs.
    /// <see href="https://saref.etsi.org/saref4watr/Lagoon"></see></summary>
    let Lagoon = Namespaced_IRI.parse _namespace_name "Lagoon" |> NamespacedName
    /// <summary>
    /// A lake is an area filled with water, localized in a basin, surrounded by land, apart from any river or other outlet that serves to feed or drain the lake.
    /// <see href="https://saref.etsi.org/saref4watr/Lake"></see></summary>
    let Lake = Namespaced_IRI.parse _namespace_name "Lake" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its concentration of lead.
    /// <see href="https://saref.etsi.org/saref4watr/Lead"></see></summary>
    let Lead = Namespaced_IRI.parse _namespace_name "Lead" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its concentration of manganese.
    /// <see href="https://saref.etsi.org/saref4watr/Manganese"></see></summary>
    let Manganese = Namespaced_IRI.parse _namespace_name "Manganese" |> NamespacedName
    /// <summary>
    /// A maintenance hole is an enclosure that facilitates human access to and working space for equipment.
    /// <see href="https://saref.etsi.org/saref4watr/Manhole"></see></summary>
    let Manhole = Namespaced_IRI.parse _namespace_name "Manhole" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its concentration of mercury.
    /// <see href="https://saref.etsi.org/saref4watr/Mercury"></see></summary>
    let Mercury = Namespaced_IRI.parse _namespace_name "Mercury" |> NamespacedName

    /// <summary>
    /// The duration of the meter power up.
    /// <see href="https://saref.etsi.org/saref4watr/MeterOnTime"></see></summary>
    let MeterOnTime =
        Namespaced_IRI.parse _namespace_name "MeterOnTime" |> NamespacedName

    /// <summary>
    /// The time for which the meter has been operating.
    /// <see href="https://saref.etsi.org/saref4watr/MeterOperatingTime"></see></summary>
    let MeterOperatingTime =
        Namespaced_IRI.parse _namespace_name "MeterOperatingTime" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of nickel.
    /// <see href="https://saref.etsi.org/saref4watr/Nickel"></see></summary>
    let Nickel = Namespaced_IRI.parse _namespace_name "Nickel" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its concentration of nitrate.
    /// <see href="https://saref.etsi.org/saref4watr/Nitrate"></see></summary>
    let Nitrate = Namespaced_IRI.parse _namespace_name "Nitrate" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its concentration of nitrite.
    /// <see href="https://saref.etsi.org/saref4watr/Nitrite"></see></summary>
    let Nitrite = Namespaced_IRI.parse _namespace_name "Nitrite" |> NamespacedName
    /// <summary>
    /// An ocean is a large body of salt water.
    /// <see href="https://saref.etsi.org/saref4watr/Ocean"></see></summary>
    let Ocean = Namespaced_IRI.parse _namespace_name "Ocean" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its odour.
    /// <see href="https://saref.etsi.org/saref4watr/Odour"></see></summary>
    let Odour = Namespaced_IRI.parse _namespace_name "Odour" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its oxidisability.
    /// <see href="https://saref.etsi.org/saref4watr/Oxidisability"></see></summary>
    let Oxidisability =
        Namespaced_IRI.parse _namespace_name "Oxidisability" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its oxygen saturation.
    /// <see href="https://saref.etsi.org/saref4watr/Oxygen"></see></summary>
    let Oxygen = Namespaced_IRI.parse _namespace_name "Oxygen" |> NamespacedName
    /// <summary>
    /// A pipe is a passage of water flowing in a closed conduit (i.e., not subject to atmospheric pressure).
    /// <see href="https://saref.etsi.org/saref4watr/Pipe"></see></summary>
    let Pipe = Namespaced_IRI.parse _namespace_name "Pipe" |> NamespacedName
    /// <summary>
    /// A pit is a well or hole sunk in the ground to procure, store or drain water.
    /// <see href="https://saref.etsi.org/saref4watr/Pit"></see></summary>
    let Pit = Namespaced_IRI.parse _namespace_name "Pit" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of polycyclic aromatic hydrocarbons.
    /// <see href="https://saref.etsi.org/saref4watr/PolycyclicAromaticHydrocarbons"></see></summary>
    let PolycyclicAromaticHydrocarbons =
        Namespaced_IRI.parse _namespace_name "PolycyclicAromaticHydrocarbons" |> NamespacedName

    /// <summary>
    /// Property of the environment indicating the precipitation.
    /// <see href="https://saref.etsi.org/saref4watr/Precipitation"></see></summary>
    let Precipitation =
        Namespaced_IRI.parse _namespace_name "Precipitation" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of pseudomonas aeruginosa.
    /// <see href="https://saref.etsi.org/saref4watr/PseudomonasAeruginosa"></see></summary>
    let PseudomonasAeruginosa =
        Namespaced_IRI.parse _namespace_name "PseudomonasAeruginosa" |> NamespacedName

    /// <summary>
    /// A pump is a device for moving water by mechanical action.
    /// <see href="https://saref.etsi.org/saref4watr/Pump"></see></summary>
    let Pump = Namespaced_IRI.parse _namespace_name "Pump" |> NamespacedName
    /// <summary>
    /// Raw water is water found in the environment that has not been treated and does not have any of its minerals, ions, particles, bacteria, or parasites removed.
    /// <see href="https://saref.etsi.org/saref4watr/RawWater"></see></summary>
    let RawWater = Namespaced_IRI.parse _namespace_name "RawWater" |> NamespacedName
    /// <summary>
    /// Use of water for recreational purposes.
    /// <see href="https://saref.etsi.org/saref4watr/Recreation"></see></summary>
    let Recreation = Namespaced_IRI.parse _namespace_name "Recreation" |> NamespacedName
    /// <summary>
    /// A reservoir is an enlarged natural or artificial lake, pond or impoundment created using a dam or lock to store water.
    /// <see href="https://saref.etsi.org/saref4watr/Reservoir"></see></summary>
    let Reservoir = Namespaced_IRI.parse _namespace_name "Reservoir" |> NamespacedName
    /// <summary>
    /// A river is a natural flowing watercourse, usually freshwater, flowing towards an ocean, sea, lake or another river.
    /// <see href="https://saref.etsi.org/saref4watr/River"></see></summary>
    let River = Namespaced_IRI.parse _namespace_name "River" |> NamespacedName
    /// <summary>
    /// A sea is a body of salt water partly or fully enclosed by land.
    /// <see href="https://saref.etsi.org/saref4watr/Sea"></see></summary>
    let Sea = Namespaced_IRI.parse _namespace_name "Sea" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its concentration of selenium.
    /// <see href="https://saref.etsi.org/saref4watr/Selenium"></see></summary>
    let Selenium = Namespaced_IRI.parse _namespace_name "Selenium" |> NamespacedName
    /// <summary>
    /// A water asset is a physical entity used in the process of transporting, treating, storing and distributing water.
    /// <see href="https://saref.etsi.org/saref4watr/WaterAsset"></see></summary>
    let WaterAsset = Namespaced_IRI.parse _namespace_name "WaterAsset" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its concentration of sodium.
    /// <see href="https://saref.etsi.org/saref4watr/Sodium"></see></summary>
    let Sodium = Namespaced_IRI.parse _namespace_name "Sodium" |> NamespacedName

    /// <summary>
    /// An storage infrastructure is an infrastructure to storage both potable water for consumption, and non potable water for use in agriculture.
    /// <see href="https://saref.etsi.org/saref4watr/StorageInfrastructure"></see></summary>
    let StorageInfrastructure =
        Namespaced_IRI.parse _namespace_name "StorageInfrastructure" |> NamespacedName

    /// <summary>
    /// Stormwater is water that originates during precipitation events and snow/ice melt.
    /// <see href="https://saref.etsi.org/saref4watr/Stormwater"></see></summary>
    let Stormwater = Namespaced_IRI.parse _namespace_name "Stormwater" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its concentration of sulphate.
    /// <see href="https://saref.etsi.org/saref4watr/Sulphate"></see></summary>
    let Sulphate = Namespaced_IRI.parse _namespace_name "Sulphate" |> NamespacedName
    /// <summary>
    /// A tank is a container for storing water.
    /// <see href="https://saref.etsi.org/saref4watr/Tank"></see></summary>
    let Tank = Namespaced_IRI.parse _namespace_name "Tank" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its taste.
    /// <see href="https://saref.etsi.org/saref4watr/Taste"></see></summary>
    let Taste = Namespaced_IRI.parse _namespace_name "Taste" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its temperature.
    /// <see href="https://saref.etsi.org/saref4watr/Temperature"></see></summary>
    let Temperature =
        Namespaced_IRI.parse _namespace_name "Temperature" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of tetrachloroethene.
    /// <see href="https://saref.etsi.org/saref4watr/Tetrachloroethene"></see></summary>
    let Tetrachloroethene =
        Namespaced_IRI.parse _namespace_name "Tetrachloroethene" |> NamespacedName

    /// <summary>
    /// A threshold-based tariff is a tariff that is based on a threshold.
    /// <see href="https://saref.etsi.org/saref4watr/ThresholdBasedTariff"></see></summary>
    let ThresholdBasedTariff =
        Namespaced_IRI.parse _namespace_name "ThresholdBasedTariff" |> NamespacedName

    /// <summary>
    /// A time-based tariff is a tariff that is based on time.
    /// <see href="https://saref.etsi.org/saref4watr/TimeBasedTariff"></see></summary>
    let TimeBasedTariff =
        Namespaced_IRI.parse _namespace_name "TimeBasedTariff" |> NamespacedName

    /// <summary>
    /// Property of the water indicating the dissolved combined content of all inorganic and organic substances present in a sample of water.
    /// <see href="https://saref.etsi.org/saref4watr/TotalDissolvedSolids"></see></summary>
    let TotalDissolvedSolids =
        Namespaced_IRI.parse _namespace_name "TotalDissolvedSolids" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its total indicative dose.
    /// <see href="https://saref.etsi.org/saref4watr/TotalIndicativeDose"></see></summary>
    let TotalIndicativeDose =
        Namespaced_IRI.parse _namespace_name "TotalIndicativeDose" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of total organic carbon.
    /// <see href="https://saref.etsi.org/saref4watr/TotalOrganicCarbon"></see></summary>
    let TotalOrganicCarbon =
        Namespaced_IRI.parse _namespace_name "TotalOrganicCarbon" |> NamespacedName

    /// <summary>
    /// Property of the water indicating the dry-weight of suspended particles, that are not dissolved, in a sample of water.
    /// <see href="https://saref.etsi.org/saref4watr/TotalSuspendedSolids"></see></summary>
    let TotalSuspendedSolids =
        Namespaced_IRI.parse _namespace_name "TotalSuspendedSolids" |> NamespacedName

    /// <summary>
    /// A treatment plant is an infrastructure to improve the quality of water to make it more acceptable for a specific end-use.
    /// <see href="https://saref.etsi.org/saref4watr/TreatmentPlant"></see></summary>
    let TreatmentPlant =
        Namespaced_IRI.parse _namespace_name "TreatmentPlant" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of trichloroethene.
    /// <see href="https://saref.etsi.org/saref4watr/Trichloroethene"></see></summary>
    let Trichloroethene =
        Namespaced_IRI.parse _namespace_name "Trichloroethene" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of trihalomethanes.
    /// <see href="https://saref.etsi.org/saref4watr/Trihalomethanes"></see></summary>
    let Trihalomethanes =
        Namespaced_IRI.parse _namespace_name "Trihalomethanes" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of tritium.
    /// <see href="https://saref.etsi.org/saref4watr/Tritium"></see></summary>
    let Tritium = Namespaced_IRI.parse _namespace_name "Tritium" |> NamespacedName
    /// <summary>
    /// Property of the water indicating its turbidity.
    /// <see href="https://saref.etsi.org/saref4watr/Turbidity"></see></summary>
    let Turbidity = Namespaced_IRI.parse _namespace_name "Turbidity" |> NamespacedName
    /// <summary>
    /// A valve is a device designed to control water flow, pressure or volume.
    /// <see href="https://saref.etsi.org/saref4watr/Valve"></see></summary>
    let Valve = Namespaced_IRI.parse _namespace_name "Valve" |> NamespacedName
    /// <summary>
    /// A vent is the part of a system that allows air to enter a plumbing system to maintain proper air pressure and sewer gases to escape to the outside.
    /// <see href="https://saref.etsi.org/saref4watr/Vent"></see></summary>
    let Vent = Namespaced_IRI.parse _namespace_name "Vent" |> NamespacedName

    /// <summary>
    /// Property of the water indicating its concentration of vinyl chloride.
    /// <see href="https://saref.etsi.org/saref4watr/VinylChloride"></see></summary>
    let VinylChloride =
        Namespaced_IRI.parse _namespace_name "VinylChloride" |> NamespacedName

    /// <summary>
    /// Wastewater is water that has been used in the home, in a business, or as part of an industrial process.
    /// <see href="https://saref.etsi.org/saref4watr/Wastewater"></see></summary>
    let Wastewater = Namespaced_IRI.parse _namespace_name "Wastewater" |> NamespacedName

    /// <summary>
    /// The type of water for which an infrastructure is designed for.
    /// <see href="https://saref.etsi.org/saref4watr/isDesignedFor"></see></summary>
    let isDesignedFor =
        Namespaced_IRI.parse _namespace_name "isDesignedFor" |> NamespacedName

    /// <summary>
    /// The intended use of the infrastructure.
    /// <see href="https://saref.etsi.org/saref4watr/isIntendedFor"></see></summary>
    let isIntendedFor =
        Namespaced_IRI.parse _namespace_name "isIntendedFor" |> NamespacedName

    /// <summary>
    /// A water meter is an instrument intended to measure continuously, memorize, and display the volume of water passing through the meter.
    /// <see href="https://saref.etsi.org/saref4watr/WaterMeter"></see></summary>
    let WaterMeter = Namespaced_IRI.parse _namespace_name "WaterMeter" |> NamespacedName
    /// <summary>
    /// The version of a device.
    /// <see href="https://saref.etsi.org/saref4watr/hasVersion"></see></summary>
    let hasVersion = Namespaced_IRI.parse _namespace_name "hasVersion" |> NamespacedName

    /// <summary>
    /// The fabrication number of a device.
    /// <see href="https://saref.etsi.org/saref4watr/hasFabricationNumber"></see></summary>
    let hasFabricationNumber =
        Namespaced_IRI.parse _namespace_name "hasFabricationNumber" |> NamespacedName

    /// <summary>
    /// The hardware version of a device.
    /// <see href="https://saref.etsi.org/saref4watr/hasHardwareVersion"></see></summary>
    let hasHardwareVersion =
        Namespaced_IRI.parse _namespace_name "hasHardwareVersion" |> NamespacedName

    /// <summary>
    /// The firmware version of a device.
    /// <see href="https://saref.etsi.org/saref4watr/hasFirmwareVersion"></see></summary>
    let hasFirmwareVersion =
        Namespaced_IRI.parse _namespace_name "hasFirmwareVersion" |> NamespacedName

    /// <summary>
    /// The water meter to which a tariff applies to.
    /// <see href="https://saref.etsi.org/saref4watr/appliesTo"></see></summary>
    let appliesTo = Namespaced_IRI.parse _namespace_name "appliesTo" |> NamespacedName

    /// <summary>
    /// A relationship specifying the features of interest that are controlled by a device.
    /// <see href="https://saref.etsi.org/saref4watr/controlsFeature"></see></summary>
    let controlsFeature =
        Namespaced_IRI.parse _namespace_name "controlsFeature" |> NamespacedName

    /// <summary>
    /// A relationship specifying the devices that control a feature of interest.
    /// <see href="https://saref.etsi.org/saref4watr/featureIsControlledByDevice"></see></summary>
    let featureIsControlledByDevice =
        Namespaced_IRI.parse _namespace_name "featureIsControlledByDevice" |> NamespacedName

    /// <summary>
    /// A relationship specifying the devices that measure a feature of interest.
    /// <see href="https://saref.etsi.org/saref4watr/featureIsMeasuredByDevice"></see></summary>
    let featureIsMeasuredByDevice =
        Namespaced_IRI.parse _namespace_name "featureIsMeasuredByDevice" |> NamespacedName

    /// <summary>
    /// The time interval in each day for which a tariff is applied (e.g., 8:00 to 10:00).
    /// <see href="https://saref.etsi.org/saref4watr/forAbsoluteTimeAtDay"></see></summary>
    let forAbsoluteTimeAtDay =
        Namespaced_IRI.parse _namespace_name "forAbsoluteTimeAtDay" |> NamespacedName

    /// <summary>
    /// The day of the month for which a tariff is applied (e.g., each 15).
    /// <see href="https://saref.etsi.org/saref4watr/forDayInMonth"></see></summary>
    let forDayInMonth =
        Namespaced_IRI.parse _namespace_name "forDayInMonth" |> NamespacedName

    /// <summary>
    /// The financial consumption related to a tariff (e.g., prepaid tariffs).
    /// <see href="https://saref.etsi.org/saref4watr/forFinancialConsumption"></see></summary>
    let forFinancialConsumption =
        Namespaced_IRI.parse _namespace_name "forFinancialConsumption" |> NamespacedName

    /// <summary>
    /// The volume consumption related to a tariff (e.g., after consumption of 900 litres).
    /// <see href="https://saref.etsi.org/saref4watr/forVolumeConsumption"></see></summary>
    let forVolumeConsumption =
        Namespaced_IRI.parse _namespace_name "forVolumeConsumption" |> NamespacedName

    /// <summary>
    /// The volume flow related to a tariff.
    /// <see href="https://saref.etsi.org/saref4watr/forVolumeFlow"></see></summary>
    let forVolumeFlow =
        Namespaced_IRI.parse _namespace_name "forVolumeFlow" |> NamespacedName

    /// <summary>
    /// The day of the week for which a tariff is applied (e.g., each Saturday and Sunday).
    /// <see href="https://saref.etsi.org/saref4watr/forWeekDay"></see></summary>
    let forWeekDay = Namespaced_IRI.parse _namespace_name "forWeekDay" |> NamespacedName

    /// <summary>
    /// The billing date of a tariff.
    /// <see href="https://saref.etsi.org/saref4watr/hasBillingDate"></see></summary>
    let hasBillingDate =
        Namespaced_IRI.parse _namespace_name "hasBillingDate" |> NamespacedName

    /// <summary>
    /// The billing period of a tariff.
    /// <see href="https://saref.etsi.org/saref4watr/hasBillingPeriod"></see></summary>
    let hasBillingPeriod =
        Namespaced_IRI.parse _namespace_name "hasBillingPeriod" |> NamespacedName

    /// <summary>
    /// The duration of a tariff.
    /// <see href="https://saref.etsi.org/saref4watr/hasDuration"></see></summary>
    let hasDuration =
        Namespaced_IRI.parse _namespace_name "hasDuration" |> NamespacedName

    /// <summary>
    /// The period of a tariff.
    /// <see href="https://saref.etsi.org/saref4watr/hasPeriod"></see></summary>
    let hasPeriod = Namespaced_IRI.parse _namespace_name "hasPeriod" |> NamespacedName

    /// <summary>
    /// The time for which the value of a measurement applies to the feature of interest.
    /// <see href="https://saref.etsi.org/saref4watr/hasPhenomenonTime"></see></summary>
    let hasPhenomenonTime =
        Namespaced_IRI.parse _namespace_name "hasPhenomenonTime" |> NamespacedName

    /// <summary>
    /// The start date and time of a tariff.
    /// <see href="https://saref.etsi.org/saref4watr/hasStartTimestamp"></see></summary>
    let hasStartTimestamp =
        Namespaced_IRI.parse _namespace_name "hasStartTimestamp" |> NamespacedName

    /// <summary>
    /// A relationship specifying the features of interest that are measured by a device.
    /// <see href="https://saref.etsi.org/saref4watr/measuresFeature"></see></summary>
    let measuresFeature =
        Namespaced_IRI.parse _namespace_name "measuresFeature" |> NamespacedName

    /// <summary>
    /// The radio frequency at which a device operates.
    /// <see href="https://saref.etsi.org/saref4watr/operatesAtRadioFrequency"></see></summary>
    let operatesAtRadioFrequency =
        Namespaced_IRI.parse _namespace_name "operatesAtRadioFrequency" |> NamespacedName

    /// <summary>
    /// The power required by a device.
    /// <see href="https://saref.etsi.org/saref4watr/requiresPower"></see></summary>
    let requiresPower =
        Namespaced_IRI.parse _namespace_name "requiresPower" |> NamespacedName
