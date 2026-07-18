namespace https.w3id.org.react.hash

open DoxAletheia.Rdf_Vocabulary

module react =
    let _namespace_name = "https://w3id.org/react#"
    /// <summary>
    /// A unit that creates electrical energy from stored chemical energy
    /// <see href="https://w3id.org/react#Battery"></see></summary>
    let Battery = Namespaced_IRI.parse _namespace_name "Battery" |> NamespacedName
    /// <summary>
    /// A system composed of one or more solar panels combined that use energy from the sun to generate electricity
    /// <see href="https://w3id.org/react#PVSystem"></see></summary>
    let PVSystem = Namespaced_IRI.parse _namespace_name "PVSystem" |> NamespacedName

    /// <summary>
    /// Category to which a given equipment (eep:Executor) belongs to
    /// <see href="https://w3id.org/react#equipmentCategory"></see></summary>
    let equipmentCategory =
        Namespaced_IRI.parse _namespace_name "equipmentCategory" |> NamespacedName

    /// <summary>
    /// The type of acces of a given Execution
    /// <see href="https://w3id.org/react#hasAccessType"></see></summary>
    let hasAccessType =
        Namespaced_IRI.parse _namespace_name "hasAccessType" |> NamespacedName

    /// <summary>
    /// The nominal charge stored by a given Battery.
    /// <see href="https://w3id.org/react#hasBatteryCapacity"></see></summary>
    let hasBatteryCapacity =
        Namespaced_IRI.parse _namespace_name "hasBatteryCapacity" |> NamespacedName

    /// <summary>
    /// Energy carriers present in a given facility (bot:Space) as demand
    /// <see href="https://w3id.org/react#hasDemandEnergyCarrier"></see></summary>
    let hasDemandEnergyCarrier =
        Namespaced_IRI.parse _namespace_name "hasDemandEnergyCarrier" |> NamespacedName

    /// <summary>
    /// Information of the Electricity Supplier of a given facility (bot:Space)
    /// <see href="https://w3id.org/react#hasElectricitySupplier"></see></summary>
    let hasElectricitySupplier =
        Namespaced_IRI.parse _namespace_name "hasElectricitySupplier" |> NamespacedName

    /// <summary>
    /// The nominal energy of a given Equipment (eep:Executor)
    /// <see href="https://w3id.org/react#hasEnergy"></see></summary>
    let hasEnergy = Namespaced_IRI.parse _namespace_name "hasEnergy" |> NamespacedName

    /// <summary>
    /// Energy carriers present in a given facility (bot:Space) as local generators
    /// <see href="https://w3id.org/react#hasGenerationEnergyCarrier"></see></summary>
    let hasGenerationEnergyCarrier =
        Namespaced_IRI.parse _namespace_name "hasGenerationEnergyCarrier" |> NamespacedName

    /// <summary>
    /// Code to uniquely identify electricity supply points such as individual domestic residences
    /// <see href="https://w3id.org/react#hasGridCode"></see></summary>
    let hasGridCode =
        Namespaced_IRI.parse _namespace_name "hasGridCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/react#hasGridType"></see>
    /// </summary>
    let hasGridType =
        Namespaced_IRI.parse _namespace_name "hasGridType" |> NamespacedName

    /// <summary>
    /// Date when a given Equipment (eep:Executor) was installed.
    /// <see href="https://w3id.org/react#hasInstallationDate"></see></summary>
    let hasInstallationDate =
        Namespaced_IRI.parse _namespace_name "hasInstallationDate" |> NamespacedName

    /// <summary>
    /// Maximum charging power
    /// <see href="https://w3id.org/react#hasMaxChargePower"></see></summary>
    let hasMaxChargePower =
        Namespaced_IRI.parse _namespace_name "hasMaxChargePower" |> NamespacedName

    /// <summary>
    /// Maximum discharging power
    /// <see href="https://w3id.org/react#hasMaxDischargePower"></see></summary>
    let hasMaxDischargePower =
        Namespaced_IRI.parse _namespace_name "hasMaxDischargePower" |> NamespacedName

    /// <summary>
    /// Maximum power fed
    /// <see href="https://w3id.org/react#hasMaxGridExport"></see></summary>
    let hasMaxGridExport =
        Namespaced_IRI.parse _namespace_name "hasMaxGridExport" |> NamespacedName

    /// <summary>
    /// Maximum power drawn from the grid
    /// <see href="https://w3id.org/react#hasMaxGridImport"></see></summary>
    let hasMaxGridImport =
        Namespaced_IRI.parse _namespace_name "hasMaxGridImport" |> NamespacedName

    /// <summary>
    /// Measurement index of an Execution or a set of Executions. Measurement index for scalar values is set to 1. For vector values (e.g. 3-phase measurement), it is set to the corresponding value: 1,2,3…
    /// <see href="https://w3id.org/react#hasMeasurementIndex"></see></summary>
    let hasMeasurementIndex =
        Namespaced_IRI.parse _namespace_name "hasMeasurementIndex" |> NamespacedName

    /// <summary>
    /// The quantity of modules that composes a given energy storage or production system
    /// <see href="https://w3id.org/react#hasModuleQuantity"></see></summary>
    let hasModuleQuantity =
        Namespaced_IRI.parse _namespace_name "hasModuleQuantity" |> NamespacedName

    /// <summary>
    /// Sampling method of a given Execution
    /// <see href="https://w3id.org/react#hasSamplingMethod"></see></summary>
    let hasSamplingMethod =
        Namespaced_IRI.parse _namespace_name "hasSamplingMethod" |> NamespacedName

    /// <summary>
    /// Unique identifier of a phyisical equipment (eep:Executor)
    /// <see href="https://w3id.org/react#hasSerialNumber"></see></summary>
    let hasSerialNumber =
        Namespaced_IRI.parse _namespace_name "hasSerialNumber" |> NamespacedName

    /// <summary>
    /// Base technology of a given Equipment (eep:Executor)
    /// <see href="https://w3id.org/react#hasTechnology"></see></summary>
    let hasTechnology =
        Namespaced_IRI.parse _namespace_name "hasTechnology" |> NamespacedName

    /// <summary>
    /// The nominal total production capacity of a given production system
    /// <see href="https://w3id.org/react#hasTotalProductionCapacity"></see></summary>
    let hasTotalProductionCapacity =
        Namespaced_IRI.parse _namespace_name "hasTotalProductionCapacity" |> NamespacedName

    /// <summary>
    /// The nominal total storage capacity of a given storage system
    /// <see href="https://w3id.org/react#hasTotalStorageCapacity"></see></summary>
    let hasTotalStorageCapacity =
        Namespaced_IRI.parse _namespace_name "hasTotalStorageCapacity" |> NamespacedName

    /// <summary>
    /// The nominal voltage of a Battery.
    /// <see href="https://w3id.org/react#hasVoltage"></see></summary>
    let hasVoltage = Namespaced_IRI.parse _namespace_name "hasVoltage" |> NamespacedName

    /// <summary>
    /// Whether a PV system has the possibility of curtailment or not
    /// <see href="https://w3id.org/react#isCurtailable"></see></summary>
    let isCurtailable =
        Namespaced_IRI.parse _namespace_name "isCurtailable" |> NamespacedName

    /// <summary>
    /// Relationship between an Executor and another Executor that manages it.
    /// <see href="https://w3id.org/react#isManagedBy"></see></summary>
    let isManagedBy =
        Namespaced_IRI.parse _namespace_name "isManagedBy" |> NamespacedName
