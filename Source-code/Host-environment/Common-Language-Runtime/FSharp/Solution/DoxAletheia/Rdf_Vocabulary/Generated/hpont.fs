namespace https.w3id.org.hpont.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module hpont =
    let _namespace_iri = Namespace_Iri hpont |> NamespaceIRI
    /// <summary>
    ///   <para>hpont:atw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:hpont#HeatPumpTechnology</para>
    ///   <para>Air-to-water Heat Pump technology</para>
    /// labels<para>air-to-water</para></remarks>
    /// <seealso href="https://w3id.org/hpont#atw">https://w3id.org/hpont#atw</seealso>
    let atw = Prefixed_Name(hpont, "atw") |> PrefixedName
    /// <summary>
    ///   <para>hpont:HeatPumpTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The base technology of a given Heat Pump system</para>
    /// labels<para>Heat Pump Technology</para></remarks>
    /// <seealso href="https://w3id.org/hpont#HeatPumpTechnology">https://w3id.org/hpont#HeatPumpTechnology</seealso>
    let HeatPumpTechnology = Prefixed_Name(hpont, "HeatPumpTechnology") |> PrefixedName

    /// <summary>
    ///   <para>hpont:hasBufferStorageVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Buffer storage volume of the Heat Pump. Buffer storage is thermal energy storage using a tank for the circulating heat transfer fluid of the Heat Pump</para>
    /// labels<para>has Buffer Storage Volume</para></remarks>
    /// <seealso href="https://w3id.org/hpont#hasBufferStorageVolume">https://w3id.org/hpont#hasBufferStorageVolume</seealso>
    let hasBufferStorageVolume =
        Prefixed_Name(hpont, "hasBufferStorageVolume") |> PrefixedName

    /// <summary>
    ///   <para>hpont:hasNominalCoolingCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Nominal cooling capacity of the Heat Pump</para>
    /// labels<para>has Nominal Cooling Capacity</para></remarks>
    /// <seealso href="https://w3id.org/hpont#hasNominalCoolingCapacity">https://w3id.org/hpont#hasNominalCoolingCapacity</seealso>
    let hasNominalCoolingCapacity =
        Prefixed_Name(hpont, "hasNominalCoolingCapacity") |> PrefixedName

    /// <summary>
    ///   <para>hpont:hasNominalPowerConsumptionInHeatingMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Nominal power consumption of the Heat Pump when it is in heating mode</para>
    /// labels<para>has Nominal Power Consumption In Heating Mode</para></remarks>
    /// <seealso href="https://w3id.org/hpont#hasNominalPowerConsumptionInHeatingMode">https://w3id.org/hpont#hasNominalPowerConsumptionInHeatingMode</seealso>
    let hasNominalPowerConsumptionInHeatingMode =
        Prefixed_Name(hpont, "hasNominalPowerConsumptionInHeatingMode") |> PrefixedName

    /// <summary>
    ///   <para>hpont:hasOutdoorModelUnitName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Name of the oudoor model unit</para>
    /// labels<para>has Outdoor Model Unit Name</para></remarks>
    /// <seealso href="https://w3id.org/hpont#hasOutdoorModelUnitName">https://w3id.org/hpont#hasOutdoorModelUnitName</seealso>
    let hasOutdoorModelUnitName =
        Prefixed_Name(hpont, "hasOutdoorModelUnitName") |> PrefixedName

    /// <summary>
    ///   <para>hpont:spaceCoolingMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:hpont#HeatPumpOperatingMode</para>
    ///   <para>Space cooling operation mode of the Heat Pump</para>
    /// labels<para>Space cooling mode</para></remarks>
    /// <seealso href="https://w3id.org/hpont#spaceCoolingMode">https://w3id.org/hpont#spaceCoolingMode</seealso>
    let spaceCoolingMode = Prefixed_Name(hpont, "spaceCoolingMode") |> PrefixedName
    /// <summary>
    ///   <para>hpont:spaceHeatingMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:hpont#HeatPumpOperatingMode</para>
    ///   <para>Space heating operation mode of the Heat Pump</para>
    /// labels<para>Space heating mode</para></remarks>
    /// <seealso href="https://w3id.org/hpont#spaceHeatingMode">https://w3id.org/hpont#spaceHeatingMode</seealso>
    let spaceHeatingMode = Prefixed_Name(hpont, "spaceHeatingMode") |> PrefixedName
    /// <summary>
    ///   <para>hpont:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/hpont#">https://w3id.org/hpont#</seealso>
    let _prefix_iri = Prefixed_Name(hpont, "") |> PrefixedName

    /// <summary>
    ///   <para>hpont:HeatPumpOperatingMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The operating mode of a given Heat Pump system</para>
    /// labels<para>Heat Pump Operating Mode</para></remarks>
    /// <seealso href="https://w3id.org/hpont#HeatPumpOperatingMode">https://w3id.org/hpont#HeatPumpOperatingMode</seealso>
    let HeatPumpOperatingMode =
        Prefixed_Name(hpont, "HeatPumpOperatingMode") |> PrefixedName

    /// <summary>
    ///   <para>hpont:hasTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Base technology of a given Heat Pump</para>
    /// labels<para>has Technology</para></remarks>
    /// <seealso href="https://w3id.org/hpont#hasTechnology">https://w3id.org/hpont#hasTechnology</seealso>
    let hasTechnology = Prefixed_Name(hpont, "hasTechnology") |> PrefixedName

    /// <summary>
    ///   <para>hpont:hasOperatingModeAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Operating modes available for the Heat Pump</para>
    /// labels<para>has Operating Mode Available</para></remarks>
    /// <seealso href="https://w3id.org/hpont#hasOperatingModeAvailable">https://w3id.org/hpont#hasOperatingModeAvailable</seealso>
    let hasOperatingModeAvailable =
        Prefixed_Name(hpont, "hasOperatingModeAvailable") |> PrefixedName

    /// <summary>
    ///   <para>hpont:HeatPumpSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A system composed of one or many devices that transfer heat from a colder area to a hotter area by using mechanical energy</para>
    /// labels<para>Heat Pump System</para></remarks>
    /// <seealso href="https://w3id.org/hpont#HeatPumpSystem">https://w3id.org/hpont#HeatPumpSystem</seealso>
    let HeatPumpSystem = Prefixed_Name(hpont, "HeatPumpSystem") |> PrefixedName
    /// <summary>
    ///   <para>hpont:dhwHeatingMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:hpont#HeatPumpOperatingMode</para>
    ///   <para>DHW heating operation mode of the Heat Pump</para>
    /// labels<para>DHW heating mode</para></remarks>
    /// <seealso href="https://w3id.org/hpont#dhwHeatingMode">https://w3id.org/hpont#dhwHeatingMode</seealso>
    let dhwHeatingMode = Prefixed_Name(hpont, "dhwHeatingMode") |> PrefixedName

    /// <summary>
    ///   <para>hpont:hasDHWStorageVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>DHW (Domestic Hot Water) storage volume of the Heat Pump. DHW storage is a tank that contains clean potable water for household hot water consumption</para>
    /// labels<para>has DHW Storage Volume</para></remarks>
    /// <seealso href="https://w3id.org/hpont#hasDHWStorageVolume">https://w3id.org/hpont#hasDHWStorageVolume</seealso>
    let hasDHWStorageVolume =
        Prefixed_Name(hpont, "hasDHWStorageVolume") |> PrefixedName

    /// <summary>
    ///   <para>hpont:hasNominalPowerConsumptionInCoolingMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Nominal power consumption of the Heat Pump when it is in cooling mode</para>
    /// labels<para>has Nominal Power Consumption In Cooling Mode</para></remarks>
    /// <seealso href="https://w3id.org/hpont#hasNominalPowerConsumptionInCoolingMode">https://w3id.org/hpont#hasNominalPowerConsumptionInCoolingMode</seealso>
    let hasNominalPowerConsumptionInCoolingMode =
        Prefixed_Name(hpont, "hasNominalPowerConsumptionInCoolingMode") |> PrefixedName

    /// <summary>
    ///   <para>hpont:hasNumberOfIndoorUnits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of indoor units that the Heat Pump has</para>
    /// labels<para>has Number Of Indoor Units</para></remarks>
    /// <seealso href="https://w3id.org/hpont#hasNumberOfIndoorUnits">https://w3id.org/hpont#hasNumberOfIndoorUnits</seealso>
    let hasNumberOfIndoorUnits =
        Prefixed_Name(hpont, "hasNumberOfIndoorUnits") |> PrefixedName

    /// <summary>
    ///   <para>hpont:hasNominalHeatingCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Nominal heating capacity of the Heat Pump</para>
    /// labels<para>has Nominal Heating Capacity</para></remarks>
    /// <seealso href="https://w3id.org/hpont#hasNominalHeatingCapacity">https://w3id.org/hpont#hasNominalHeatingCapacity</seealso>
    let hasNominalHeatingCapacity =
        Prefixed_Name(hpont, "hasNominalHeatingCapacity") |> PrefixedName

    /// <summary>
    ///   <para>hpont:hasNumberOfOutdoorUnits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of outdoor units that the Heat Pump has</para>
    /// labels<para>has Number Of Outdoor Units</para></remarks>
    /// <seealso href="https://w3id.org/hpont#hasNumberOfOutdoorUnits">https://w3id.org/hpont#hasNumberOfOutdoorUnits</seealso>
    let hasNumberOfOutdoorUnits =
        Prefixed_Name(hpont, "hasNumberOfOutdoorUnits") |> PrefixedName

    /// <summary>
    ///   <para>hpont:hasPowerSupplyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Electric power supply type of the Heat Pump System</para>
    /// labels<para>has Power Supply Type</para></remarks>
    /// <seealso href="https://w3id.org/hpont#hasPowerSupplyType">https://w3id.org/hpont#hasPowerSupplyType</seealso>
    let hasPowerSupplyType = Prefixed_Name(hpont, "hasPowerSupplyType") |> PrefixedName
    /// <summary>
    ///   <para>hpont:ata</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:hpont#HeatPumpTechnology</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Air-to-air Heat Pump technology.</para>
    /// labels<para>air-to-air</para></remarks>
    /// <seealso href="https://w3id.org/hpont#ata">https://w3id.org/hpont#ata</seealso>
    let ata = Prefixed_Name(hpont, "ata") |> PrefixedName
