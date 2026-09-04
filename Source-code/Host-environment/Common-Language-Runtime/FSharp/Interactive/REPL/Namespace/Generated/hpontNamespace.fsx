#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module hpont =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/hpont#" "hpont"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Heat Pump Operating Mode</para>
    ///   <para>rdfs:comment : The operating mode of a given Heat Pump system</para>
    ///   <a href="https://w3id.org/hpont#HeatPumpOperatingMode">hpont:HeatPumpOperatingMode</a>
    /// </summary>
    let HeatPumpOperatingMode = _prefixId.prefix "HeatPumpOperatingMode"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Heat Pump System</para>
    ///   <para>rdfs:comment : A system composed of one or many devices that transfer heat from a colder area to a hotter area by using mechanical energy</para>
    ///   <a href="https://w3id.org/hpont#HeatPumpSystem">hpont:HeatPumpSystem</a>
    /// </summary>
    let HeatPumpSystem = _prefixId.prefix "HeatPumpSystem"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Heat Pump Technology</para>
    ///   <para>rdfs:comment : The base technology of a given Heat Pump system</para>
    ///   <a href="https://w3id.org/hpont#HeatPumpTechnology">hpont:HeatPumpTechnology</a>
    /// </summary>
    let HeatPumpTechnology = _prefixId.prefix "HeatPumpTechnology"
    let ata = _prefixId.prefix "ata"
    let atw = _prefixId.prefix "atw"
    let dhwHeatingMode = _prefixId.prefix "dhwHeatingMode"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has Buffer Storage Volume</para>
    ///   <para>rdfs:comment : Buffer storage volume of the Heat Pump. Buffer storage is thermal energy storage using a tank for the circulating heat transfer fluid of the Heat Pump</para>
    ///   <a href="https://w3id.org/hpont#hasBufferStorageVolume">hpont:hasBufferStorageVolume</a>
    /// </summary>
    let hasBufferStorageVolume = _prefixId.prefix "hasBufferStorageVolume"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has DHW Storage Volume</para>
    ///   <para>rdfs:comment : DHW (Domestic Hot Water) storage volume of the Heat Pump. DHW storage is a tank that contains clean potable water for household hot water consumption</para>
    ///   <a href="https://w3id.org/hpont#hasDHWStorageVolume">hpont:hasDHWStorageVolume</a>
    /// </summary>
    let hasDHWStorageVolume = _prefixId.prefix "hasDHWStorageVolume"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has Nominal Cooling Capacity</para>
    ///   <para>rdfs:comment : Nominal cooling capacity of the Heat Pump</para>
    ///   <a href="https://w3id.org/hpont#hasNominalCoolingCapacity">hpont:hasNominalCoolingCapacity</a>
    /// </summary>
    let hasNominalCoolingCapacity = _prefixId.prefix "hasNominalCoolingCapacity"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has Nominal Heating Capacity</para>
    ///   <para>rdfs:comment : Nominal heating capacity of the Heat Pump</para>
    ///   <a href="https://w3id.org/hpont#hasNominalHeatingCapacity">hpont:hasNominalHeatingCapacity</a>
    /// </summary>
    let hasNominalHeatingCapacity = _prefixId.prefix "hasNominalHeatingCapacity"

    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has Nominal Power Consumption In Cooling Mode</para>
    ///   <para>rdfs:comment : Nominal power consumption of the Heat Pump when it is in cooling mode</para>
    ///   <a href="https://w3id.org/hpont#hasNominalPowerConsumptionInCoolingMode">hpont:hasNominalPowerConsumptionInCoolingMode</a>
    /// </summary>
    let hasNominalPowerConsumptionInCoolingMode =
        _prefixId.prefix "hasNominalPowerConsumptionInCoolingMode"

    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has Nominal Power Consumption In Heating Mode</para>
    ///   <para>rdfs:comment : Nominal power consumption of the Heat Pump when it is in heating mode</para>
    ///   <a href="https://w3id.org/hpont#hasNominalPowerConsumptionInHeatingMode">hpont:hasNominalPowerConsumptionInHeatingMode</a>
    /// </summary>
    let hasNominalPowerConsumptionInHeatingMode =
        _prefixId.prefix "hasNominalPowerConsumptionInHeatingMode"

    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has Number Of Indoor Units</para>
    ///   <para>rdfs:comment : Number of indoor units that the Heat Pump has</para>
    ///   <a href="https://w3id.org/hpont#hasNumberOfIndoorUnits">hpont:hasNumberOfIndoorUnits</a>
    /// </summary>
    let hasNumberOfIndoorUnits = _prefixId.prefix "hasNumberOfIndoorUnits"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has Number Of Outdoor Units</para>
    ///   <para>rdfs:comment : Number of outdoor units that the Heat Pump has</para>
    ///   <a href="https://w3id.org/hpont#hasNumberOfOutdoorUnits">hpont:hasNumberOfOutdoorUnits</a>
    /// </summary>
    let hasNumberOfOutdoorUnits = _prefixId.prefix "hasNumberOfOutdoorUnits"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has Operating Mode Available</para>
    ///   <para>rdfs:comment : Operating modes available for the Heat Pump</para>
    ///   <a href="https://w3id.org/hpont#hasOperatingModeAvailable">hpont:hasOperatingModeAvailable</a>
    /// </summary>
    let hasOperatingModeAvailable = _prefixId.prefix "hasOperatingModeAvailable"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has Outdoor Model Unit Name</para>
    ///   <para>rdfs:comment : Name of the oudoor model unit</para>
    ///   <a href="https://w3id.org/hpont#hasOutdoorModelUnitName">hpont:hasOutdoorModelUnitName</a>
    /// </summary>
    let hasOutdoorModelUnitName = _prefixId.prefix "hasOutdoorModelUnitName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has Power Supply Type</para>
    ///   <para>rdfs:comment : Electric power supply type of the Heat Pump System</para>
    ///   <a href="https://w3id.org/hpont#hasPowerSupplyType">hpont:hasPowerSupplyType</a>
    /// </summary>
    let hasPowerSupplyType = _prefixId.prefix "hasPowerSupplyType"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has Technology</para>
    ///   <para>rdfs:comment : Base technology of a given Heat Pump</para>
    ///   <a href="https://w3id.org/hpont#hasTechnology">hpont:hasTechnology</a>
    /// </summary>
    let hasTechnology = _prefixId.prefix "hasTechnology"
    let spaceCoolingMode = _prefixId.prefix "spaceCoolingMode"
    let spaceHeatingMode = _prefixId.prefix "spaceHeatingMode"
