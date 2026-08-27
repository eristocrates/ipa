namespace http.w3id.org.emmo_bto.bto.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bato =
    let _namespace_iri = Namespace_Iri bato |> NamespaceIRI
    /// <summary>
    ///   <para>bato:Accuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The level of accuracy of a battery measurement process. It is a property of the process."</para>
    /// labels<para>"Accuracy"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#Accuracy">http://w3id.org/emmo-bto/bto#Accuracy</seealso>
    let Accuracy = Prefixed_Name(bato, "Accuracy") |> PrefixedName
    /// <summary>
    ///   <para>bato:AlligatorClamps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of battery connector."</para>
    /// labels<para>"AlligatorClamps"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#AlligatorClamps">http://w3id.org/emmo-bto/bto#AlligatorClamps</seealso>
    let AlligatorClamps = Prefixed_Name(bato, "AlligatorClamps") |> PrefixedName
    /// <summary>
    ///   <para>bato:AmbientHumidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific property of a battery characterization environment, related to its level of humidity."</para>
    /// labels<para>"AmbientHumidity"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#AmbientHumidity">http://w3id.org/emmo-bto/bto#AmbientHumidity</seealso>
    let AmbientHumidity = Prefixed_Name(bato, "AmbientHumidity") |> PrefixedName
    /// <summary>
    ///   <para>bato:AmbientHumidityUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The measurement unit of the humidity of a battery characterization hardware."</para>
    /// labels<para>"AmbientHumidityUnit"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#AmbientHumidityUnit">http://w3id.org/emmo-bto/bto#AmbientHumidityUnit</seealso>
    let AmbientHumidityUnit = Prefixed_Name(bato, "AmbientHumidityUnit") |> PrefixedName
    /// <summary>
    ///   <para>bato:AmbientLight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific property of a battery characterization environment, related to its level of luminosity (amount of light)."</para>
    /// labels<para>"AmbientLight"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#AmbientLight">http://w3id.org/emmo-bto/bto#AmbientLight</seealso>
    let AmbientLight = Prefixed_Name(bato, "AmbientLight") |> PrefixedName
    /// <summary>
    ///   <para>bato:AmbientLightUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The measurement unit of the light of a battery characterization hardware."</para>
    /// labels<para>"AmbientLightUnit"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#AmbientLightUnit">http://w3id.org/emmo-bto/bto#AmbientLightUnit</seealso>
    let AmbientLightUnit = Prefixed_Name(bato, "AmbientLightUnit") |> PrefixedName
    /// <summary>
    ///   <para>bato:AmbientPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific property of a battery characterization environment, related to its level of pressure."</para>
    /// labels<para>"AmbientPressure"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#AmbientPressure">http://w3id.org/emmo-bto/bto#AmbientPressure</seealso>
    let AmbientPressure = Prefixed_Name(bato, "AmbientPressure") |> PrefixedName
    /// <summary>
    ///   <para>bato:AmbientPressureUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The measurement unit of the pressure of a battery characterization hardware."</para>
    /// labels<para>"AmbientPressureUnit"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#AmbientPressureUnit">http://w3id.org/emmo-bto/bto#AmbientPressureUnit</seealso>
    let AmbientPressureUnit = Prefixed_Name(bato, "AmbientPressureUnit") |> PrefixedName
    /// <summary>
    ///   <para>bato:AmbientTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific property of a battery characterization environment, related to its level of temperature."</para>
    /// labels<para>"AmbientTemperature"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#AmbientTemperature">http://w3id.org/emmo-bto/bto#AmbientTemperature</seealso>
    let AmbientTemperature = Prefixed_Name(bato, "AmbientTemperature") |> PrefixedName

    /// <summary>
    ///   <para>bato:AmbientTemperatureUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The measurement unit of the temperature of a battery characterization hardware."</para>
    /// labels<para>"AmbientTemperatureUnit"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#AmbientTemperatureUnit">http://w3id.org/emmo-bto/bto#AmbientTemperatureUnit</seealso>
    let AmbientTemperatureUnit =
        Prefixed_Name(bato, "AmbientTemperatureUnit") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatteryCharacterizationEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The environment in which a battery characterization takes place. It may have a number of properties, or specifications, including pressure, humidity, temperature and light."</para>
    /// labels<para>"BatteryCharacterizationEnvironment"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationEnvironment">http://w3id.org/emmo-bto/bto#BatteryCharacterizationEnvironment</seealso>
    let BatteryCharacterizationEnvironment =
        Prefixed_Name(bato, "BatteryCharacterizationEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatteryCharacterizationEnvironmentMeasurementUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measurement unit of a specification of a battery characterization hardware. It is a super-class of more specific classes."</para>
    /// labels<para>"BatteryCharacterizationEnvironmentMeasurementUnit"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationEnvironmentMeasurementUnit">http://w3id.org/emmo-bto/bto#BatteryCharacterizationEnvironmentMeasurementUnit</seealso>
    let BatteryCharacterizationEnvironmentMeasurementUnit =
        Prefixed_Name(bato, "BatteryCharacterizationEnvironmentMeasurementUnit") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatteryCharacterizationEnvironmentProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A property of a battery characterization environment, e.g. temperature, pressure, humidity, light. It is a super-class of more specific classes."</para>
    /// labels<para>"BatteryCharacterizationEnvironmentProperty"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationEnvironmentProperty">http://w3id.org/emmo-bto/bto#BatteryCharacterizationEnvironmentProperty</seealso>
    let BatteryCharacterizationEnvironmentProperty =
        Prefixed_Name(bato, "BatteryCharacterizationEnvironmentProperty") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatteryCharacterizationHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The physical apparatus of the battery testing procedure. It is required in a battery measurement process."</para>
    /// labels<para>"BatteryCharacterizationHardware"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationHardware">http://w3id.org/emmo-bto/bto#BatteryCharacterizationHardware</seealso>
    let BatteryCharacterizationHardware =
        Prefixed_Name(bato, "BatteryCharacterizationHardware") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatteryCharacterizationHardwareSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A characteristic or specification of a battery testing hardware"</para>
    /// labels<para>"BatteryCharacterizationHardwareSpecification"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationHardwareSpecification">http://w3id.org/emmo-bto/bto#BatteryCharacterizationHardwareSpecification</seealso>
    let BatteryCharacterizationHardwareSpecification =
        Prefixed_Name(bato, "BatteryCharacterizationHardwareSpecification") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatteryCharacterizationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The description of the overall characterization method for a battery. It is usually made up of different steps, or tasks (e.g. battery measurement process, battery sample preparation)."</para>
    /// labels<para>"BatteryCharacterizationMethod"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationMethod">http://w3id.org/emmo-bto/bto#BatteryCharacterizationMethod</seealso>
    let BatteryCharacterizationMethod =
        Prefixed_Name(bato, "BatteryCharacterizationMethod") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatteryChemistryType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The type of chemistry in a battery sample. It is a property of the sample."</para>
    /// labels<para>"BatteryChemistryType"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatteryChemistryType">http://w3id.org/emmo-bto/bto#BatteryChemistryType</seealso>
    let BatteryChemistryType =
        Prefixed_Name(bato, "BatteryChemistryType") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatteryComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A physical part of a battery."</para>
    /// labels<para>"BatteryComponent"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatteryComponent">http://w3id.org/emmo-bto/bto#BatteryComponent</seealso>
    let BatteryComponent = Prefixed_Name(bato, "BatteryComponent") |> PrefixedName
    /// <summary>
    ///   <para>bato:BatteryConnector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A physical connector that connects a battery sample for the testing procedure."</para>
    /// labels<para>"BatteryConnector"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatteryConnector">http://w3id.org/emmo-bto/bto#BatteryConnector</seealso>
    let BatteryConnector = Prefixed_Name(bato, "BatteryConnector") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatteryElectrolyteType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The type of electrolyte in a battery sample. It is a property of the sample."</para>
    /// labels<para>"BatteryElectrolyteType"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatteryElectrolyteType">http://w3id.org/emmo-bto/bto#BatteryElectrolyteType</seealso>
    let BatteryElectrolyteType =
        Prefixed_Name(bato, "BatteryElectrolyteType") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatteryHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The device that holds the battery in place for the testing procedure."</para>
    /// labels<para>"BatteryHolder"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatteryHolder">http://w3id.org/emmo-bto/bto#BatteryHolder</seealso>
    let BatteryHolder = Prefixed_Name(bato, "BatteryHolder") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatteryHolderComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A physical part of the holding device."</para>
    /// labels<para>"BatteryHolderComponent"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatteryHolderComponent">http://w3id.org/emmo-bto/bto#BatteryHolderComponent</seealso>
    let BatteryHolderComponent =
        Prefixed_Name(bato, "BatteryHolderComponent") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatteryManufacturerName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The name of the manufacturer of a battery sample. It is a property of the sample."</para>
    /// labels<para>"BatteryManufacturerName"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatteryManufacturerName">http://w3id.org/emmo-bto/bto#BatteryManufacturerName</seealso>
    let BatteryManufacturerName =
        Prefixed_Name(bato, "BatteryManufacturerName") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatteryMeasurementParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A configuration parameter of a battery measurement step in the testing procedure."</para>
    /// labels<para>"BatteryMeasurementParameter"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatteryMeasurementParameter">http://w3id.org/emmo-bto/bto#BatteryMeasurementParameter</seealso>
    let BatteryMeasurementParameter =
        Prefixed_Name(bato, "BatteryMeasurementParameter") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatteryMeasurementProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The measurement step in a battery characterization method. It involves at least a characterization hardware, a characterization environment, a battery sample to be measured, the configuration parameters, the level of accuracy and the location of the measurement. Its output is the trace data of the measurement."</para>
    /// labels<para>"BatteryMeasurementProcess"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatteryMeasurementProcess">http://w3id.org/emmo-bto/bto#BatteryMeasurementProcess</seealso>
    let BatteryMeasurementProcess =
        Prefixed_Name(bato, "BatteryMeasurementProcess") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatteryMeasurementProcessProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A characteristic of the battery measurement process. It is a super-class of more specific classes."</para>
    /// labels<para>"BatteryMeasurementProcessProperty"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatteryMeasurementProcessProperty">http://w3id.org/emmo-bto/bto#BatteryMeasurementProcessProperty</seealso>
    let BatteryMeasurementProcessProperty =
        Prefixed_Name(bato, "BatteryMeasurementProcessProperty") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatteryPartNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The part number, or code, of a battery sample. It is a property of the sample."</para>
    /// labels<para>"BatteryPartNumber"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatteryPartNumber">http://w3id.org/emmo-bto/bto#BatteryPartNumber</seealso>
    let BatteryPartNumber = Prefixed_Name(bato, "BatteryPartNumber") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatteryProductionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The date reported as the one in which the battery sample has been produced. It is a property of the sample."</para>
    /// labels<para>"BatteryProductionDate"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatteryProductionDate">http://w3id.org/emmo-bto/bto#BatteryProductionDate</seealso>
    let BatteryProductionDate =
        Prefixed_Name(bato, "BatteryProductionDate") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatterySample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A battery selected from a larger set to be used in a battery testing procedure."</para>
    /// labels<para>"BatterySample"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatterySample">http://w3id.org/emmo-bto/bto#BatterySample</seealso>
    let BatterySample = Prefixed_Name(bato, "BatterySample") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatterySamplePreparation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A step in the battery characterization method, related to the preparation of the battery sample to be tested. The battery sample, unprepared, is input to this step; the battery sample, prepared, is the output of this step. The holding device is a temporary participant of this step."</para>
    /// labels<para>"BatterySamplePreparation"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatterySamplePreparation">http://w3id.org/emmo-bto/bto#BatterySamplePreparation</seealso>
    let BatterySamplePreparation =
        Prefixed_Name(bato, "BatterySamplePreparation") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatterySampleProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A characteristic of a battery sample."</para>
    /// labels<para>"BatterySampleProperty"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatterySampleProperty">http://w3id.org/emmo-bto/bto#BatterySampleProperty</seealso>
    let BatterySampleProperty =
        Prefixed_Name(bato, "BatterySampleProperty") |> PrefixedName

    /// <summary>
    ///   <para>bato:BatteryTestingOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is the root class of the BTO ontology, introduced for grouping all of BTO's classes under a single parent class, each at a different hierarchical position."</para>
    /// labels<para>"BatteryTestingOntology"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#BatteryTestingOntology">http://w3id.org/emmo-bto/bto#BatteryTestingOntology</seealso>
    let BatteryTestingOntology =
        Prefixed_Name(bato, "BatteryTestingOntology") |> PrefixedName

    /// <summary>
    ///   <para>bato:Cable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A physical cable that connects a battery sample for the testing procedure."</para>
    /// labels<para>"Cable"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#Cable">http://w3id.org/emmo-bto/bto#Cable</seealso>
    let Cable = Prefixed_Name(bato, "Cable") |> PrefixedName

    /// <summary>
    ///   <para>bato:CalibrationForBatteryCharacterization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The process of calibration of a battery characterization hardware with reference to a voltage source, which produces as output a reference voltage data."</para>
    /// labels<para>"CalibrationForBatteryCharacterization"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#CalibrationForBatteryCharacterization">http://w3id.org/emmo-bto/bto#CalibrationForBatteryCharacterization</seealso>
    let CalibrationForBatteryCharacterization =
        Prefixed_Name(bato, "CalibrationForBatteryCharacterization") |> PrefixedName

    /// <summary>
    ///   <para>bato:CurrentData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of trace data output from a battery measurement process, related to the current measured."</para>
    /// labels<para>"CurrentData"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#CurrentData">http://w3id.org/emmo-bto/bto#CurrentData</seealso>
    let CurrentData = Prefixed_Name(bato, "CurrentData") |> PrefixedName

    /// <summary>
    ///   <para>bato:CurrentSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specification of the battery characterization hardware, related to the current it can sustain."</para>
    /// labels<para>"CurrentSpecification"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#CurrentSpecification">http://w3id.org/emmo-bto/bto#CurrentSpecification</seealso>
    let CurrentSpecification =
        Prefixed_Name(bato, "CurrentSpecification") |> PrefixedName

    /// <summary>
    ///   <para>bato:EndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A parameter in the battery measurement step. It specifies the end time of the measurement."</para>
    /// labels<para>"EndTime"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#EndTime">http://w3id.org/emmo-bto/bto#EndTime</seealso>
    let EndTime = Prefixed_Name(bato, "EndTime") |> PrefixedName
    /// <summary>
    ///   <para>bato:Fixture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of holding device for a battery sample. It may consist of a battery connector and a cable."</para>
    /// labels<para>"Fixture"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#Fixture">http://w3id.org/emmo-bto/bto#Fixture</seealso>
    let Fixture = Prefixed_Name(bato, "Fixture") |> PrefixedName

    /// <summary>
    ///   <para>bato:HardwareManufacturerName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The name of the manufacturer of the hardware used for the measurement process."</para>
    /// labels<para>"HardwareManufacturerName"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#HardwareManufacturerName">http://w3id.org/emmo-bto/bto#HardwareManufacturerName</seealso>
    let HardwareManufacturerName =
        Prefixed_Name(bato, "HardwareManufacturerName") |> PrefixedName

    /// <summary>
    ///   <para>bato:HardwareModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The model of the hardware used for the measurement process."</para>
    /// labels<para>"HardwareModel"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#HardwareModel">http://w3id.org/emmo-bto/bto#HardwareModel</seealso>
    let HardwareModel = Prefixed_Name(bato, "HardwareModel") |> PrefixedName
    /// <summary>
    ///   <para>bato:HardwareType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The type of the hardware used for the measurement process."</para>
    /// labels<para>"HardwareType"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#HardwareType">http://w3id.org/emmo-bto/bto#HardwareType</seealso>
    let HardwareType = Prefixed_Name(bato, "HardwareType") |> PrefixedName
    /// <summary>
    ///   <para>bato:HipotCable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of cable."</para>
    /// labels<para>"HipotCable"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#HipotCable">http://w3id.org/emmo-bto/bto#HipotCable</seealso>
    let HipotCable = Prefixed_Name(bato, "HipotCable") |> PrefixedName
    /// <summary>
    ///   <para>bato:MaxVoltage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A parameter in the battery measurement step. It specifies the maximum voltage of the measurement."</para>
    /// labels<para>"MaxVoltage"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#MaxVoltage">http://w3id.org/emmo-bto/bto#MaxVoltage</seealso>
    let MaxVoltage = Prefixed_Name(bato, "MaxVoltage") |> PrefixedName

    /// <summary>
    ///   <para>bato:PreparedBatterySample</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#PreparedBatterySample">http://w3id.org/emmo-bto/bto#PreparedBatterySample</seealso>
    let PreparedBatterySample =
        Prefixed_Name(bato, "PreparedBatterySample") |> PrefixedName

    /// <summary>
    ///   <para>bato:PreparedatterySample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A battery sample that has been prepared for testing. It is thus the output of the process of preparing a battery sample."</para>
    /// labels<para>"PreparedBatterySample"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#PreparedatterySample">http://w3id.org/emmo-bto/bto#PreparedatterySample</seealso>
    let PreparedatterySample =
        Prefixed_Name(bato, "PreparedatterySample") |> PrefixedName

    /// <summary>
    ///   <para>bato:RawBatterySample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A battery sample to be prepared for testing. It is thus the input of the process of preparing a battery sample."</para>
    /// labels<para>"RawBatterySample"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#RawBatterySample">http://w3id.org/emmo-bto/bto#RawBatterySample</seealso>
    let RawBatterySample = Prefixed_Name(bato, "RawBatterySample") |> PrefixedName
    /// <summary>
    ///   <para>bato:SamplingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A parameter in the battery measurement step. It specifies the sampling time of the measurement."</para>
    /// labels<para>"SamplingTime"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#SamplingTime">http://w3id.org/emmo-bto/bto#SamplingTime</seealso>
    let SamplingTime = Prefixed_Name(bato, "SamplingTime") |> PrefixedName
    /// <summary>
    ///   <para>bato:TimeData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of trace data output from a battery measurement process, related to the time intervals of the measurement."</para>
    /// labels<para>"TimeData"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#TimeData">http://w3id.org/emmo-bto/bto#TimeData</seealso>
    let TimeData = Prefixed_Name(bato, "TimeData") |> PrefixedName
    /// <summary>
    ///   <para>bato:TraceData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The output of a battery measurement process in terms of raw data resulting from the measurement."</para>
    /// labels<para>"TraceData"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#TraceData">http://w3id.org/emmo-bto/bto#TraceData</seealso>
    let TraceData = Prefixed_Name(bato, "TraceData") |> PrefixedName
    /// <summary>
    ///   <para>bato:VoltageData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of trace data output from a battery measurement process, related to the voltage measured."</para>
    /// labels<para>"VoltageData"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#VoltageData">http://w3id.org/emmo-bto/bto#VoltageData</seealso>
    let VoltageData = Prefixed_Name(bato, "VoltageData") |> PrefixedName
    /// <summary>
    ///   <para>bato:VoltageSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A voltage source used as a reference for the calibration of a battery characterization hardware."</para>
    /// labels<para>"VoltageSource"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#VoltageSource">http://w3id.org/emmo-bto/bto#VoltageSource</seealso>
    let VoltageSource = Prefixed_Name(bato, "VoltageSource") |> PrefixedName

    /// <summary>
    ///   <para>bato:VoltageSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specification of the battery characterization hardware, related to the voltage it can provide."</para>
    /// labels<para>"VoltageSpecification"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#VoltageSpecification">http://w3id.org/emmo-bto/bto#VoltageSpecification</seealso>
    let VoltageSpecification =
        Prefixed_Name(bato, "VoltageSpecification") |> PrefixedName

    /// <summary>
    ///   <para>bato:btoDatatypeProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This is the root datatype property of the BTO ontology, introduced for grouping all of BTO's datatype properties under a single parent datatype property."</para>
    /// labels<para>"btoDatatypeProperty"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#btoDatatypeProperty">http://w3id.org/emmo-bto/bto#btoDatatypeProperty</seealso>
    let btoDatatypeProperty = Prefixed_Name(bato, "btoDatatypeProperty") |> PrefixedName
    /// <summary>
    ///   <para>bato:btoObjectProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the root object property of the BTO ontology, introduced for grouping all of BTO's object properties under a single parent object property."</para>
    /// labels<para>"btoObjectProperty"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#btoObjectProperty">http://w3id.org/emmo-bto/bto#btoObjectProperty</seealso>
    let btoObjectProperty = Prefixed_Name(bato, "btoObjectProperty") |> PrefixedName

    /// <summary>
    ///   <para>bato:hasBatteryCharacterizationHardwareSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Object property that connects a battery characterization hardware with its specifications. It is a super-property of more specific object properties."</para>
    /// labels<para>"hasBatteryCharacterizationHardwareSpecification"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#hasBatteryCharacterizationHardwareSpecification">http://w3id.org/emmo-bto/bto#hasBatteryCharacterizationHardwareSpecification</seealso>
    let hasBatteryCharacterizationHardwareSpecification =
        Prefixed_Name(bato, "hasBatteryCharacterizationHardwareSpecification") |> PrefixedName

    /// <summary>
    ///   <para>bato:hasBatterySampleProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Object property that connects a battery sample with its characteristics (BatterySampleProperties). It is the super-property of a number of more specific object properties."</para>
    /// labels<para>"hasBatterySampleProperty"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#hasBatterySampleProperty">http://w3id.org/emmo-bto/bto#hasBatterySampleProperty</seealso>
    let hasBatterySampleProperty =
        Prefixed_Name(bato, "hasBatterySampleProperty") |> PrefixedName

    /// <summary>
    ///   <para>bato:hasCellForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A specific object property that connects a battery sample with its cell form."</para>
    /// labels<para>"hasCellForm"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#hasCellForm">http://w3id.org/emmo-bto/bto#hasCellForm</seealso>
    let hasCellForm = Prefixed_Name(bato, "hasCellForm") |> PrefixedName
    /// <summary>
    ///   <para>bato:hasChemistryType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A specific object property that connects a battery sample with its chemistry type."</para>
    /// labels<para>"hasChemistryType"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#hasChemistryType">http://w3id.org/emmo-bto/bto#hasChemistryType</seealso>
    let hasChemistryType = Prefixed_Name(bato, "hasChemistryType") |> PrefixedName

    /// <summary>
    ///   <para>bato:hasCurrentSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A specific object property that connects a battery characterization hardware with its current specification."</para>
    /// labels<para>"hasCurrentSpecification"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#hasCurrentSpecification">http://w3id.org/emmo-bto/bto#hasCurrentSpecification</seealso>
    let hasCurrentSpecification =
        Prefixed_Name(bato, "hasCurrentSpecification") |> PrefixedName

    /// <summary>
    ///   <para>bato:hasElectrolyteType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A specific object property that connects a battery sample with its electrolyte type."</para>
    /// labels<para>"hasElectrolyteType"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#hasElectrolyteType">http://w3id.org/emmo-bto/bto#hasElectrolyteType</seealso>
    let hasElectrolyteType = Prefixed_Name(bato, "hasElectrolyteType") |> PrefixedName
    /// <summary>
    ///   <para>bato:hasHardwareModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A specific object property that connects a battery characterization hardware with its hardware model."</para>
    /// labels<para>"hasHardwareModel"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#hasHardwareModel">http://w3id.org/emmo-bto/bto#hasHardwareModel</seealso>
    let hasHardwareModel = Prefixed_Name(bato, "hasHardwareModel") |> PrefixedName
    /// <summary>
    ///   <para>bato:hasHardwareType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A specific object property that connects a battery characterization hardware with its hardware type."</para>
    /// labels<para>"hasHardwareType"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#hasHardwareType">http://w3id.org/emmo-bto/bto#hasHardwareType</seealso>
    let hasHardwareType = Prefixed_Name(bato, "hasHardwareType") |> PrefixedName
    /// <summary>
    ///   <para>bato:hasManufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A specific object property that connects either a battery sample or its characterization hardware with its manufacturer."</para>
    /// labels<para>"hasManufacturer"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#hasManufacturer">http://w3id.org/emmo-bto/bto#hasManufacturer</seealso>
    let hasManufacturer = Prefixed_Name(bato, "hasManufacturer") |> PrefixedName
    /// <summary>
    ///   <para>bato:hasPartNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A specific object property that connects a battery sample with its part number."</para>
    /// labels<para>"hasPartNumber"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#hasPartNumber">http://w3id.org/emmo-bto/bto#hasPartNumber</seealso>
    let hasPartNumber = Prefixed_Name(bato, "hasPartNumber") |> PrefixedName
    /// <summary>
    ///   <para>bato:hasProductionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A specific datatype property that specifies a production date for a battery sample."</para>
    /// labels<para>"hasProductionDate"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#hasProductionDate">http://w3id.org/emmo-bto/bto#hasProductionDate</seealso>
    let hasProductionDate = Prefixed_Name(bato, "hasProductionDate") |> PrefixedName

    /// <summary>
    ///   <para>bato:hasVoltageSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A specific object property that connects a battery characterization hardware with its voltage specification."</para>
    /// labels<para>"hasVoltageSpecification"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-bto/bto#hasVoltageSpecification">http://w3id.org/emmo-bto/bto#hasVoltageSpecification</seealso>
    let hasVoltageSpecification =
        Prefixed_Name(bato, "hasVoltageSpecification") |> PrefixedName
