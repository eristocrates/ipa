namespace https.w3id.org.react.hash

open DoxAletheia

module react =
    let _namespace_name = "https://w3id.org/react#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A unit that creates electrical energy from stored chemical energy
    /// <see href="https://w3id.org/react#Battery"></see></summary>
    let Battery = _prefix "Battery"
    /// <summary>
    /// A system composed of one or more solar panels combined that use energy from the sun to generate electricity
    /// <see href="https://w3id.org/react#PVSystem"></see></summary>
    let PVSystem = _prefix "PVSystem"
    /// <summary>
    /// Category to which a given equipment (eep:Executor) belongs to
    /// <see href="https://w3id.org/react#equipmentCategory"></see></summary>
    let equipmentCategory = _prefix "equipmentCategory"
    /// <summary>
    /// The type of acces of a given Execution
    /// <see href="https://w3id.org/react#hasAccessType"></see></summary>
    let hasAccessType = _prefix "hasAccessType"
    /// <summary>
    /// The nominal charge stored by a given Battery.
    /// <see href="https://w3id.org/react#hasBatteryCapacity"></see></summary>
    let hasBatteryCapacity = _prefix "hasBatteryCapacity"
    /// <summary>
    /// Energy carriers present in a given facility (bot:Space) as demand
    /// <see href="https://w3id.org/react#hasDemandEnergyCarrier"></see></summary>
    let hasDemandEnergyCarrier = _prefix "hasDemandEnergyCarrier"
    /// <summary>
    /// Information of the Electricity Supplier of a given facility (bot:Space)
    /// <see href="https://w3id.org/react#hasElectricitySupplier"></see></summary>
    let hasElectricitySupplier = _prefix "hasElectricitySupplier"
    /// <summary>
    /// The nominal energy of a given Equipment (eep:Executor)
    /// <see href="https://w3id.org/react#hasEnergy"></see></summary>
    let hasEnergy = _prefix "hasEnergy"
    /// <summary>
    /// Energy carriers present in a given facility (bot:Space) as local generators
    /// <see href="https://w3id.org/react#hasGenerationEnergyCarrier"></see></summary>
    let hasGenerationEnergyCarrier = _prefix "hasGenerationEnergyCarrier"
    /// <summary>
    /// Code to uniquely identify electricity supply points such as individual domestic residences
    /// <see href="https://w3id.org/react#hasGridCode"></see></summary>
    let hasGridCode = _prefix "hasGridCode"
    /// <summary>
    ///   <see href="https://w3id.org/react#hasGridType"></see>
    /// </summary>
    let hasGridType = _prefix "hasGridType"
    /// <summary>
    /// Date when a given Equipment (eep:Executor) was installed.
    /// <see href="https://w3id.org/react#hasInstallationDate"></see></summary>
    let hasInstallationDate = _prefix "hasInstallationDate"
    /// <summary>
    /// Maximum charging power
    /// <see href="https://w3id.org/react#hasMaxChargePower"></see></summary>
    let hasMaxChargePower = _prefix "hasMaxChargePower"
    /// <summary>
    /// Maximum discharging power
    /// <see href="https://w3id.org/react#hasMaxDischargePower"></see></summary>
    let hasMaxDischargePower = _prefix "hasMaxDischargePower"
    /// <summary>
    /// Maximum power fed
    /// <see href="https://w3id.org/react#hasMaxGridExport"></see></summary>
    let hasMaxGridExport = _prefix "hasMaxGridExport"
    /// <summary>
    /// Maximum power drawn from the grid
    /// <see href="https://w3id.org/react#hasMaxGridImport"></see></summary>
    let hasMaxGridImport = _prefix "hasMaxGridImport"
    /// <summary>
    /// Measurement index of an Execution or a set of Executions. Measurement index for scalar values is set to 1. For vector values (e.g. 3-phase measurement), it is set to the corresponding value: 1,2,3…
    /// <see href="https://w3id.org/react#hasMeasurementIndex"></see></summary>
    let hasMeasurementIndex = _prefix "hasMeasurementIndex"
    /// <summary>
    /// The quantity of modules that composes a given energy storage or production system
    /// <see href="https://w3id.org/react#hasModuleQuantity"></see></summary>
    let hasModuleQuantity = _prefix "hasModuleQuantity"
    /// <summary>
    /// Sampling method of a given Execution
    /// <see href="https://w3id.org/react#hasSamplingMethod"></see></summary>
    let hasSamplingMethod = _prefix "hasSamplingMethod"
    /// <summary>
    /// Unique identifier of a phyisical equipment (eep:Executor)
    /// <see href="https://w3id.org/react#hasSerialNumber"></see></summary>
    let hasSerialNumber = _prefix "hasSerialNumber"
    /// <summary>
    /// Base technology of a given Equipment (eep:Executor)
    /// <see href="https://w3id.org/react#hasTechnology"></see></summary>
    let hasTechnology = _prefix "hasTechnology"
    /// <summary>
    /// The nominal total production capacity of a given production system
    /// <see href="https://w3id.org/react#hasTotalProductionCapacity"></see></summary>
    let hasTotalProductionCapacity = _prefix "hasTotalProductionCapacity"
    /// <summary>
    /// The nominal total storage capacity of a given storage system
    /// <see href="https://w3id.org/react#hasTotalStorageCapacity"></see></summary>
    let hasTotalStorageCapacity = _prefix "hasTotalStorageCapacity"
    /// <summary>
    /// The nominal voltage of a Battery.
    /// <see href="https://w3id.org/react#hasVoltage"></see></summary>
    let hasVoltage = _prefix "hasVoltage"
    /// <summary>
    /// Whether a PV system has the possibility of curtailment or not
    /// <see href="https://w3id.org/react#isCurtailable"></see></summary>
    let isCurtailable = _prefix "isCurtailable"
    /// <summary>
    /// Relationship between an Executor and another Executor that manages it.
    /// <see href="https://w3id.org/react#isManagedBy"></see></summary>
    let isManagedBy = _prefix "isManagedBy"
