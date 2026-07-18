namespace https.w3id.org.hpont.hash

open DoxAletheia.Rdf_Vocabulary

module hpont =
    let _namespace_name = "https://w3id.org/hpont#"
    /// <summary>
    /// Air-to-air Heat Pump technology.
    /// <see href="https://w3id.org/hpont#ata"></see></summary>
    let ata = Namespaced_IRI.parse _namespace_name "ata" |> NamespacedName
    /// <summary>
    /// Air-to-water Heat Pump technology
    /// <see href="https://w3id.org/hpont#atw"></see></summary>
    let atw = Namespaced_IRI.parse _namespace_name "atw" |> NamespacedName

    /// <summary>
    /// The operating mode of a given Heat Pump system
    /// <see href="https://w3id.org/hpont#HeatPumpOperatingMode"></see></summary>
    let HeatPumpOperatingMode =
        Namespaced_IRI.parse _namespace_name "HeatPumpOperatingMode" |> NamespacedName

    /// <summary>
    /// Operating modes available for the Heat Pump
    /// <see href="https://w3id.org/hpont#hasOperatingModeAvailable"></see></summary>
    let hasOperatingModeAvailable =
        Namespaced_IRI.parse _namespace_name "hasOperatingModeAvailable" |> NamespacedName

    /// <summary>
    /// Base technology of a given Heat Pump
    /// <see href="https://w3id.org/hpont#hasTechnology"></see></summary>
    let hasTechnology =
        Namespaced_IRI.parse _namespace_name "hasTechnology" |> NamespacedName

    /// <summary>
    /// The base technology of a given Heat Pump system
    /// <see href="https://w3id.org/hpont#HeatPumpTechnology"></see></summary>
    let HeatPumpTechnology =
        Namespaced_IRI.parse _namespace_name "HeatPumpTechnology" |> NamespacedName

    /// <summary>
    /// A system composed of one or many devices that transfer heat from a colder area to a hotter area by using mechanical energy
    /// <see href="https://w3id.org/hpont#HeatPumpSystem"></see></summary>
    let HeatPumpSystem =
        Namespaced_IRI.parse _namespace_name "HeatPumpSystem" |> NamespacedName

    /// <summary>
    /// DHW heating operation mode of the Heat Pump
    /// <see href="https://w3id.org/hpont#dhwHeatingMode"></see></summary>
    let dhwHeatingMode =
        Namespaced_IRI.parse _namespace_name "dhwHeatingMode" |> NamespacedName

    /// <summary>
    /// Buffer storage volume of the Heat Pump. Buffer storage is thermal energy storage using a tank for the circulating heat transfer fluid of the Heat Pump
    /// <see href="https://w3id.org/hpont#hasBufferStorageVolume"></see></summary>
    let hasBufferStorageVolume =
        Namespaced_IRI.parse _namespace_name "hasBufferStorageVolume" |> NamespacedName

    /// <summary>
    /// DHW (Domestic Hot Water) storage volume of the Heat Pump. DHW storage is a tank that contains clean potable water for household hot water consumption
    /// <see href="https://w3id.org/hpont#hasDHWStorageVolume"></see></summary>
    let hasDHWStorageVolume =
        Namespaced_IRI.parse _namespace_name "hasDHWStorageVolume" |> NamespacedName

    /// <summary>
    /// Nominal cooling capacity of the Heat Pump
    /// <see href="https://w3id.org/hpont#hasNominalCoolingCapacity"></see></summary>
    let hasNominalCoolingCapacity =
        Namespaced_IRI.parse _namespace_name "hasNominalCoolingCapacity" |> NamespacedName

    /// <summary>
    /// Nominal heating capacity of the Heat Pump
    /// <see href="https://w3id.org/hpont#hasNominalHeatingCapacity"></see></summary>
    let hasNominalHeatingCapacity =
        Namespaced_IRI.parse _namespace_name "hasNominalHeatingCapacity" |> NamespacedName

    /// <summary>
    /// Nominal power consumption of the Heat Pump when it is in cooling mode
    /// <see href="https://w3id.org/hpont#hasNominalPowerConsumptionInCoolingMode"></see></summary>
    let hasNominalPowerConsumptionInCoolingMode =
        Namespaced_IRI.parse _namespace_name "hasNominalPowerConsumptionInCoolingMode" |> NamespacedName

    /// <summary>
    /// Nominal power consumption of the Heat Pump when it is in heating mode
    /// <see href="https://w3id.org/hpont#hasNominalPowerConsumptionInHeatingMode"></see></summary>
    let hasNominalPowerConsumptionInHeatingMode =
        Namespaced_IRI.parse _namespace_name "hasNominalPowerConsumptionInHeatingMode" |> NamespacedName

    /// <summary>
    /// Number of indoor units that the Heat Pump has
    /// <see href="https://w3id.org/hpont#hasNumberOfIndoorUnits"></see></summary>
    let hasNumberOfIndoorUnits =
        Namespaced_IRI.parse _namespace_name "hasNumberOfIndoorUnits" |> NamespacedName

    /// <summary>
    /// Number of outdoor units that the Heat Pump has
    /// <see href="https://w3id.org/hpont#hasNumberOfOutdoorUnits"></see></summary>
    let hasNumberOfOutdoorUnits =
        Namespaced_IRI.parse _namespace_name "hasNumberOfOutdoorUnits" |> NamespacedName

    /// <summary>
    /// Name of the oudoor model unit
    /// <see href="https://w3id.org/hpont#hasOutdoorModelUnitName"></see></summary>
    let hasOutdoorModelUnitName =
        Namespaced_IRI.parse _namespace_name "hasOutdoorModelUnitName" |> NamespacedName

    /// <summary>
    /// Electric power supply type of the Heat Pump System
    /// <see href="https://w3id.org/hpont#hasPowerSupplyType"></see></summary>
    let hasPowerSupplyType =
        Namespaced_IRI.parse _namespace_name "hasPowerSupplyType" |> NamespacedName

    /// <summary>
    /// Space cooling operation mode of the Heat Pump
    /// <see href="https://w3id.org/hpont#spaceCoolingMode"></see></summary>
    let spaceCoolingMode =
        Namespaced_IRI.parse _namespace_name "spaceCoolingMode" |> NamespacedName

    /// <summary>
    /// Space heating operation mode of the Heat Pump
    /// <see href="https://w3id.org/hpont#spaceHeatingMode"></see></summary>
    let spaceHeatingMode =
        Namespaced_IRI.parse _namespace_name "spaceHeatingMode" |> NamespacedName
