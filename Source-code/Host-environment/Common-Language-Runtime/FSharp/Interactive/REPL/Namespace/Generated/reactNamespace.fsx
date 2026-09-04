#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module react =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/react#" "react"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : Battery</para>
    ///   <para>rdfs:comment : A unit that creates electrical energy from stored chemical energy</para>
    ///   <a href="https://w3id.org/react#Battery">react:Battery</a>
    /// </summary>
    let Battery = _prefixId.prefix "Battery"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : PV System</para>
    ///   <para>rdfs:comment : A system composed of one or more solar panels combined that use energy from the sun to generate electricity</para>
    ///   <a href="https://w3id.org/react#PVSystem">react:PVSystem</a>
    /// </summary>
    let PVSystem = _prefixId.prefix "PVSystem"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : equipment Category</para>
    ///   <para>rdfs:comment : Category to which a given equipment (eep:Executor) belongs to</para>
    ///   <a href="https://w3id.org/react#equipmentCategory">react:equipmentCategory</a>
    /// </summary>
    let equipmentCategory = _prefixId.prefix "equipmentCategory"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Access Type</para>
    ///   <para>rdfs:comment : The type of acces of a given Execution</para>
    ///   <a href="https://w3id.org/react#hasAccessType">react:hasAccessType</a>
    /// </summary>
    let hasAccessType = _prefixId.prefix "hasAccessType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Battery Capacity</para>
    ///   <para>rdfs:comment : The nominal charge stored by a given Battery.</para>
    ///   <a href="https://w3id.org/react#hasBatteryCapacity">react:hasBatteryCapacity</a>
    /// </summary>
    let hasBatteryCapacity = _prefixId.prefix "hasBatteryCapacity"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Demand Energy Carrier</para>
    ///   <para>rdfs:comment : Energy carriers present in a given facility (bot:Space) as demand</para>
    ///   <a href="https://w3id.org/react#hasDemandEnergyCarrier">react:hasDemandEnergyCarrier</a>
    /// </summary>
    let hasDemandEnergyCarrier = _prefixId.prefix "hasDemandEnergyCarrier"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has Electricity Supplier</para>
    ///   <para>rdfs:comment : Information of the Electricity Supplier of a given facility (bot:Space)</para>
    ///   <a href="https://w3id.org/react#hasElectricitySupplier">react:hasElectricitySupplier</a>
    /// </summary>
    let hasElectricitySupplier = _prefixId.prefix "hasElectricitySupplier"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Energy</para>
    ///   <para>rdfs:comment : The nominal energy of a given Equipment (eep:Executor)</para>
    ///   <a href="https://w3id.org/react#hasEnergy">react:hasEnergy</a>
    /// </summary>
    let hasEnergy = _prefixId.prefix "hasEnergy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Generation Energy Carrier</para>
    ///   <para>rdfs:comment : Energy carriers present in a given facility (bot:Space) as local generators</para>
    ///   <a href="https://w3id.org/react#hasGenerationEnergyCarrier">react:hasGenerationEnergyCarrier</a>
    /// </summary>
    let hasGenerationEnergyCarrier = _prefixId.prefix "hasGenerationEnergyCarrier"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has Grid Code</para>
    ///   <para>rdfs:comment : Code to uniquely identify electricity supply points such as individual domestic residences</para>
    ///   <a href="https://w3id.org/react#hasGridCode">react:hasGridCode</a>
    /// </summary>
    let hasGridCode = _prefixId.prefix "hasGridCode"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="https://w3id.org/react#hasGridType">react:hasGridType</a>
    /// </summary>
    let hasGridType = _prefixId.prefix "hasGridType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Installation Date^^xsd:string</para>
    ///   <para>rdfs:comment : Date when a given Equipment (eep:Executor) was installed.</para>
    ///   <a href="https://w3id.org/react#hasInstallationDate">react:hasInstallationDate</a>
    /// </summary>
    let hasInstallationDate = _prefixId.prefix "hasInstallationDate"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has Max Charge Power</para>
    ///   <para>rdfs:comment : Maximum charging power</para>
    ///   <a href="https://w3id.org/react#hasMaxChargePower">react:hasMaxChargePower</a>
    /// </summary>
    let hasMaxChargePower = _prefixId.prefix "hasMaxChargePower"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has Max Discharge Power</para>
    ///   <para>rdfs:comment : Maximum discharging power</para>
    ///   <a href="https://w3id.org/react#hasMaxDischargePower">react:hasMaxDischargePower</a>
    /// </summary>
    let hasMaxDischargePower = _prefixId.prefix "hasMaxDischargePower"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has Max Grid Export</para>
    ///   <para>rdfs:comment : Maximum power fed</para>
    ///   <a href="https://w3id.org/react#hasMaxGridExport">react:hasMaxGridExport</a>
    /// </summary>
    let hasMaxGridExport = _prefixId.prefix "hasMaxGridExport"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has Max Grid Import</para>
    ///   <para>rdfs:comment : Maximum power drawn from the grid</para>
    ///   <a href="https://w3id.org/react#hasMaxGridImport">react:hasMaxGridImport</a>
    /// </summary>
    let hasMaxGridImport = _prefixId.prefix "hasMaxGridImport"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Measurement Index</para>
    ///   <para>rdfs:comment : Measurement index of an Execution or a set of Executions. Measurement index for scalar values is set to 1. For vector values (e.g. 3-phase measurement), it is set to the corresponding value: 1,2,3…</para>
    ///   <a href="https://w3id.org/react#hasMeasurementIndex">react:hasMeasurementIndex</a>
    /// </summary>
    let hasMeasurementIndex = _prefixId.prefix "hasMeasurementIndex"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Module Quantity</para>
    ///   <para>rdfs:comment : The quantity of modules that composes a given energy storage or production system</para>
    ///   <a href="https://w3id.org/react#hasModuleQuantity">react:hasModuleQuantity</a>
    /// </summary>
    let hasModuleQuantity = _prefixId.prefix "hasModuleQuantity"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Sampling Method</para>
    ///   <para>rdfs:comment : Sampling method of a given Execution</para>
    ///   <a href="https://w3id.org/react#hasSamplingMethod">react:hasSamplingMethod</a>
    /// </summary>
    let hasSamplingMethod = _prefixId.prefix "hasSamplingMethod"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has Serial Number</para>
    ///   <para>rdfs:comment : Unique identifier of a phyisical equipment (eep:Executor)</para>
    ///   <a href="https://w3id.org/react#hasSerialNumber">react:hasSerialNumber</a>
    /// </summary>
    let hasSerialNumber = _prefixId.prefix "hasSerialNumber"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Technology</para>
    ///   <para>rdfs:comment : Base technology of a given Equipment (eep:Executor)</para>
    ///   <a href="https://w3id.org/react#hasTechnology">react:hasTechnology</a>
    /// </summary>
    let hasTechnology = _prefixId.prefix "hasTechnology"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Total Production Capacity</para>
    ///   <para>rdfs:comment : The nominal total production capacity of a given production system</para>
    ///   <a href="https://w3id.org/react#hasTotalProductionCapacity">react:hasTotalProductionCapacity</a>
    /// </summary>
    let hasTotalProductionCapacity = _prefixId.prefix "hasTotalProductionCapacity"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Total Storage Capacity</para>
    ///   <para>rdfs:comment : The nominal total storage capacity of a given storage system</para>
    ///   <a href="https://w3id.org/react#hasTotalStorageCapacity">react:hasTotalStorageCapacity</a>
    /// </summary>
    let hasTotalStorageCapacity = _prefixId.prefix "hasTotalStorageCapacity"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Voltage^^xsd:string</para>
    ///   <para>rdfs:comment : The nominal voltage of a Battery.</para>
    ///   <a href="https://w3id.org/react#hasVoltage">react:hasVoltage</a>
    /// </summary>
    let hasVoltage = _prefixId.prefix "hasVoltage"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : is Curtailable</para>
    ///   <para>rdfs:comment : Whether a PV system has the possibility of curtailment or not</para>
    ///   <a href="https://w3id.org/react#isCurtailable">react:isCurtailable</a>
    /// </summary>
    let isCurtailable = _prefixId.prefix "isCurtailable"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isManagedBy</para>
    ///   <para>rdfs:comment : Relationship between an Executor and another Executor that manages it.</para>
    ///   <a href="https://w3id.org/react#isManagedBy">react:isManagedBy</a>
    /// </summary>
    let isManagedBy = _prefixId.prefix "isManagedBy"
