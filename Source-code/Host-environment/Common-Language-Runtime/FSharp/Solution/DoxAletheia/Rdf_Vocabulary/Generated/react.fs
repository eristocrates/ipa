namespace https.w3id.org.react.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module react =
    let _namespace_iri = Namespace_Iri react |> NamespaceIRI
    /// <summary>
    ///   <para>react:hasGridCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Code to uniquely identify electricity supply points such as individual domestic residences</para>
    /// labels<para>has Grid Code</para></remarks>
    /// <seealso href="https://w3id.org/react#hasGridCode">https://w3id.org/react#hasGridCode</seealso>
    let hasGridCode = Prefixed_Name(react, "hasGridCode") |> PrefixedName
    /// <summary>
    ///   <para>react:hasMaxChargePower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Maximum charging power</para>
    /// labels<para>has Max Charge Power</para></remarks>
    /// <seealso href="https://w3id.org/react#hasMaxChargePower">https://w3id.org/react#hasMaxChargePower</seealso>
    let hasMaxChargePower = Prefixed_Name(react, "hasMaxChargePower") |> PrefixedName

    /// <summary>
    ///   <para>react:hasGenerationEnergyCarrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Energy carriers present in a given facility (bot:Space) as local generators</para>
    /// labels<para>has Generation Energy Carrier</para></remarks>
    /// <seealso href="https://w3id.org/react#hasGenerationEnergyCarrier">https://w3id.org/react#hasGenerationEnergyCarrier</seealso>
    let hasGenerationEnergyCarrier =
        Prefixed_Name(react, "hasGenerationEnergyCarrier") |> PrefixedName

    /// <summary>
    ///   <para>react:hasMaxDischargePower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Maximum discharging power</para>
    /// labels<para>has Max Discharge Power</para></remarks>
    /// <seealso href="https://w3id.org/react#hasMaxDischargePower">https://w3id.org/react#hasMaxDischargePower</seealso>
    let hasMaxDischargePower =
        Prefixed_Name(react, "hasMaxDischargePower") |> PrefixedName

    /// <summary>
    ///   <para>react:hasMaxGridImport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Maximum power drawn from the grid</para>
    /// labels<para>has Max Grid Import</para></remarks>
    /// <seealso href="https://w3id.org/react#hasMaxGridImport">https://w3id.org/react#hasMaxGridImport</seealso>
    let hasMaxGridImport = Prefixed_Name(react, "hasMaxGridImport") |> PrefixedName

    /// <summary>
    ///   <para>react:hasMeasurementIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Measurement index of an Execution or a set of Executions. Measurement index for scalar values is set to 1. For vector values (e.g. 3-phase measurement), it is set to the corresponding value: 1,2,3…</para>
    /// labels<para>has Measurement Index</para></remarks>
    /// <seealso href="https://w3id.org/react#hasMeasurementIndex">https://w3id.org/react#hasMeasurementIndex</seealso>
    let hasMeasurementIndex =
        Prefixed_Name(react, "hasMeasurementIndex") |> PrefixedName

    /// <summary>
    ///   <para>react:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/react#">https://w3id.org/react#</seealso>
    let _prefix_iri = Prefixed_Name(react, "") |> PrefixedName
    /// <summary>
    ///   <para>react:hasSerialNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Unique identifier of a phyisical equipment (eep:Executor)</para>
    /// labels<para>has Serial Number</para></remarks>
    /// <seealso href="https://w3id.org/react#hasSerialNumber">https://w3id.org/react#hasSerialNumber</seealso>
    let hasSerialNumber = Prefixed_Name(react, "hasSerialNumber") |> PrefixedName

    /// <summary>
    ///   <para>react:hasTotalStorageCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The nominal total storage capacity of a given storage system</para>
    /// labels<para>has Total Storage Capacity</para></remarks>
    /// <seealso href="https://w3id.org/react#hasTotalStorageCapacity">https://w3id.org/react#hasTotalStorageCapacity</seealso>
    let hasTotalStorageCapacity =
        Prefixed_Name(react, "hasTotalStorageCapacity") |> PrefixedName

    /// <summary>
    ///   <para>react:isCurtailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Whether a PV system has the possibility of curtailment or not</para>
    /// labels<para>is Curtailable</para></remarks>
    /// <seealso href="https://w3id.org/react#isCurtailable">https://w3id.org/react#isCurtailable</seealso>
    let isCurtailable = Prefixed_Name(react, "isCurtailable") |> PrefixedName
    /// <summary>
    ///   <para>react:PVSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A system composed of one or more solar panels combined that use energy from the sun to generate electricity</para>
    /// labels<para>PV System</para></remarks>
    /// <seealso href="https://w3id.org/react#PVSystem">https://w3id.org/react#PVSystem</seealso>
    let PVSystem = Prefixed_Name(react, "PVSystem") |> PrefixedName
    /// <summary>
    ///   <para>react:hasAccessType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of acces of a given Execution</para>
    /// labels<para>has Access Type</para></remarks>
    /// <seealso href="https://w3id.org/react#hasAccessType">https://w3id.org/react#hasAccessType</seealso>
    let hasAccessType = Prefixed_Name(react, "hasAccessType") |> PrefixedName
    /// <summary>
    ///   <para>react:equipmentCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Category to which a given equipment (eep:Executor) belongs to</para>
    /// labels<para>equipment Category</para></remarks>
    /// <seealso href="https://w3id.org/react#equipmentCategory">https://w3id.org/react#equipmentCategory</seealso>
    let equipmentCategory = Prefixed_Name(react, "equipmentCategory") |> PrefixedName
    /// <summary>
    ///   <para>react:hasBatteryCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The nominal charge stored by a given Battery.</para>
    /// labels<para>has Battery Capacity</para></remarks>
    /// <seealso href="https://w3id.org/react#hasBatteryCapacity">https://w3id.org/react#hasBatteryCapacity</seealso>
    let hasBatteryCapacity = Prefixed_Name(react, "hasBatteryCapacity") |> PrefixedName

    /// <summary>
    ///   <para>react:hasDemandEnergyCarrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Energy carriers present in a given facility (bot:Space) as demand</para>
    /// labels<para>has Demand Energy Carrier</para></remarks>
    /// <seealso href="https://w3id.org/react#hasDemandEnergyCarrier">https://w3id.org/react#hasDemandEnergyCarrier</seealso>
    let hasDemandEnergyCarrier =
        Prefixed_Name(react, "hasDemandEnergyCarrier") |> PrefixedName

    /// <summary>
    ///   <para>react:hasElectricitySupplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Information of the Electricity Supplier of a given facility (bot:Space)</para>
    /// labels<para>has Electricity Supplier</para></remarks>
    /// <seealso href="https://w3id.org/react#hasElectricitySupplier">https://w3id.org/react#hasElectricitySupplier</seealso>
    let hasElectricitySupplier =
        Prefixed_Name(react, "hasElectricitySupplier") |> PrefixedName

    /// <summary>
    ///   <para>react:hasEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The nominal energy of a given Equipment (eep:Executor)</para>
    /// labels<para>has Energy</para></remarks>
    /// <seealso href="https://w3id.org/react#hasEnergy">https://w3id.org/react#hasEnergy</seealso>
    let hasEnergy = Prefixed_Name(react, "hasEnergy") |> PrefixedName
    /// <summary>
    ///   <para>react:hasGridType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/react#hasGridType">https://w3id.org/react#hasGridType</seealso>
    let hasGridType = Prefixed_Name(react, "hasGridType") |> PrefixedName

    /// <summary>
    ///   <para>react:hasInstallationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date when a given Equipment (eep:Executor) was installed.</para>
    /// labels<para>has Installation Date</para></remarks>
    /// <seealso href="https://w3id.org/react#hasInstallationDate">https://w3id.org/react#hasInstallationDate</seealso>
    let hasInstallationDate =
        Prefixed_Name(react, "hasInstallationDate") |> PrefixedName

    /// <summary>
    ///   <para>react:hasMaxGridExport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Maximum power fed</para>
    /// labels<para>has Max Grid Export</para></remarks>
    /// <seealso href="https://w3id.org/react#hasMaxGridExport">https://w3id.org/react#hasMaxGridExport</seealso>
    let hasMaxGridExport = Prefixed_Name(react, "hasMaxGridExport") |> PrefixedName
    /// <summary>
    ///   <para>react:hasModuleQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The quantity of modules that composes a given energy storage or production system</para>
    /// labels<para>has Module Quantity</para></remarks>
    /// <seealso href="https://w3id.org/react#hasModuleQuantity">https://w3id.org/react#hasModuleQuantity</seealso>
    let hasModuleQuantity = Prefixed_Name(react, "hasModuleQuantity") |> PrefixedName

    /// <summary>
    ///   <para>react:hasTotalProductionCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The nominal total production capacity of a given production system</para>
    /// labels<para>has Total Production Capacity</para></remarks>
    /// <seealso href="https://w3id.org/react#hasTotalProductionCapacity">https://w3id.org/react#hasTotalProductionCapacity</seealso>
    let hasTotalProductionCapacity =
        Prefixed_Name(react, "hasTotalProductionCapacity") |> PrefixedName

    /// <summary>
    ///   <para>react:hasSamplingMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Sampling method of a given Execution</para>
    /// labels<para>has Sampling Method</para></remarks>
    /// <seealso href="https://w3id.org/react#hasSamplingMethod">https://w3id.org/react#hasSamplingMethod</seealso>
    let hasSamplingMethod = Prefixed_Name(react, "hasSamplingMethod") |> PrefixedName
    /// <summary>
    ///   <para>react:hasTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Base technology of a given Equipment (eep:Executor)</para>
    /// labels<para>has Technology</para></remarks>
    /// <seealso href="https://w3id.org/react#hasTechnology">https://w3id.org/react#hasTechnology</seealso>
    let hasTechnology = Prefixed_Name(react, "hasTechnology") |> PrefixedName
    /// <summary>
    ///   <para>react:hasVoltage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The nominal voltage of a Battery.</para>
    /// labels<para>has Voltage</para></remarks>
    /// <seealso href="https://w3id.org/react#hasVoltage">https://w3id.org/react#hasVoltage</seealso>
    let hasVoltage = Prefixed_Name(react, "hasVoltage") |> PrefixedName
    /// <summary>
    ///   <para>react:isManagedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between an Executor and another Executor that manages it.</para>
    /// labels<para>isManagedBy</para></remarks>
    /// <seealso href="https://w3id.org/react#isManagedBy">https://w3id.org/react#isManagedBy</seealso>
    let isManagedBy = Prefixed_Name(react, "isManagedBy") |> PrefixedName
    /// <summary>
    ///   <para>react:Battery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A unit that creates electrical energy from stored chemical energy</para>
    /// labels<para>Battery</para></remarks>
    /// <seealso href="https://w3id.org/react#Battery">https://w3id.org/react#Battery</seealso>
    let Battery = Prefixed_Name(react, "Battery") |> PrefixedName
