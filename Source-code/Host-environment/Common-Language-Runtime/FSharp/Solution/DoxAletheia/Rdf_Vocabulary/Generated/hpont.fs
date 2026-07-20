namespace https.w3id.org.hpont.hash

open DoxAletheia

module hpont =
    let _namespace_name = "https://w3id.org/hpont#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Air-to-air Heat Pump technology.
    /// <see href="https://w3id.org/hpont#ata"></see></summary>
    let ata = _prefix "ata"
    /// <summary>
    /// Air-to-water Heat Pump technology
    /// <see href="https://w3id.org/hpont#atw"></see></summary>
    let atw = _prefix "atw"
    /// <summary>
    /// The operating mode of a given Heat Pump system
    /// <see href="https://w3id.org/hpont#HeatPumpOperatingMode"></see></summary>
    let HeatPumpOperatingMode = _prefix "HeatPumpOperatingMode"
    /// <summary>
    /// Operating modes available for the Heat Pump
    /// <see href="https://w3id.org/hpont#hasOperatingModeAvailable"></see></summary>
    let hasOperatingModeAvailable = _prefix "hasOperatingModeAvailable"
    /// <summary>
    /// Base technology of a given Heat Pump
    /// <see href="https://w3id.org/hpont#hasTechnology"></see></summary>
    let hasTechnology = _prefix "hasTechnology"
    /// <summary>
    /// The base technology of a given Heat Pump system
    /// <see href="https://w3id.org/hpont#HeatPumpTechnology"></see></summary>
    let HeatPumpTechnology = _prefix "HeatPumpTechnology"
    /// <summary>
    /// A system composed of one or many devices that transfer heat from a colder area to a hotter area by using mechanical energy
    /// <see href="https://w3id.org/hpont#HeatPumpSystem"></see></summary>
    let HeatPumpSystem = _prefix "HeatPumpSystem"
    /// <summary>
    /// DHW heating operation mode of the Heat Pump
    /// <see href="https://w3id.org/hpont#dhwHeatingMode"></see></summary>
    let dhwHeatingMode = _prefix "dhwHeatingMode"
    /// <summary>
    /// Buffer storage volume of the Heat Pump. Buffer storage is thermal energy storage using a tank for the circulating heat transfer fluid of the Heat Pump
    /// <see href="https://w3id.org/hpont#hasBufferStorageVolume"></see></summary>
    let hasBufferStorageVolume = _prefix "hasBufferStorageVolume"
    /// <summary>
    /// DHW (Domestic Hot Water) storage volume of the Heat Pump. DHW storage is a tank that contains clean potable water for household hot water consumption
    /// <see href="https://w3id.org/hpont#hasDHWStorageVolume"></see></summary>
    let hasDHWStorageVolume = _prefix "hasDHWStorageVolume"
    /// <summary>
    /// Nominal cooling capacity of the Heat Pump
    /// <see href="https://w3id.org/hpont#hasNominalCoolingCapacity"></see></summary>
    let hasNominalCoolingCapacity = _prefix "hasNominalCoolingCapacity"
    /// <summary>
    /// Nominal heating capacity of the Heat Pump
    /// <see href="https://w3id.org/hpont#hasNominalHeatingCapacity"></see></summary>
    let hasNominalHeatingCapacity = _prefix "hasNominalHeatingCapacity"

    /// <summary>
    /// Nominal power consumption of the Heat Pump when it is in cooling mode
    /// <see href="https://w3id.org/hpont#hasNominalPowerConsumptionInCoolingMode"></see></summary>
    let hasNominalPowerConsumptionInCoolingMode =
        _prefix "hasNominalPowerConsumptionInCoolingMode"

    /// <summary>
    /// Nominal power consumption of the Heat Pump when it is in heating mode
    /// <see href="https://w3id.org/hpont#hasNominalPowerConsumptionInHeatingMode"></see></summary>
    let hasNominalPowerConsumptionInHeatingMode =
        _prefix "hasNominalPowerConsumptionInHeatingMode"

    /// <summary>
    /// Number of indoor units that the Heat Pump has
    /// <see href="https://w3id.org/hpont#hasNumberOfIndoorUnits"></see></summary>
    let hasNumberOfIndoorUnits = _prefix "hasNumberOfIndoorUnits"
    /// <summary>
    /// Number of outdoor units that the Heat Pump has
    /// <see href="https://w3id.org/hpont#hasNumberOfOutdoorUnits"></see></summary>
    let hasNumberOfOutdoorUnits = _prefix "hasNumberOfOutdoorUnits"
    /// <summary>
    /// Name of the oudoor model unit
    /// <see href="https://w3id.org/hpont#hasOutdoorModelUnitName"></see></summary>
    let hasOutdoorModelUnitName = _prefix "hasOutdoorModelUnitName"
    /// <summary>
    /// Electric power supply type of the Heat Pump System
    /// <see href="https://w3id.org/hpont#hasPowerSupplyType"></see></summary>
    let hasPowerSupplyType = _prefix "hasPowerSupplyType"
    /// <summary>
    /// Space cooling operation mode of the Heat Pump
    /// <see href="https://w3id.org/hpont#spaceCoolingMode"></see></summary>
    let spaceCoolingMode = _prefix "spaceCoolingMode"
    /// <summary>
    /// Space heating operation mode of the Heat Pump
    /// <see href="https://w3id.org/hpont#spaceHeatingMode"></see></summary>
    let spaceHeatingMode = _prefix "spaceHeatingMode"
