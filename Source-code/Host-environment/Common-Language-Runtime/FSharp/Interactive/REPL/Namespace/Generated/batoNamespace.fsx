#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module bato =
    let _prefixId = PrefixId.fromNamespaceLabel "http://w3id.org/emmo-bto/bto#" "bato"
    /// <summary>
    ///   <para>rdfs:comment : The level of accuracy of a battery measurement process. It is a property of the process.</para>
    ///   <para>skos:prefLabel : Accuracy</para>
    ///   <para>rdfs:label : Accuracy</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#Accuracy">bato:Accuracy</a>
    /// </summary>
    let Accuracy = _prefixId.prefix "Accuracy"
    /// <summary>
    ///   <para>rdfs:comment : A specific type of battery connector.</para>
    ///   <para>skos:prefLabel : AlligatorClamps</para>
    ///   <para>rdfs:label : AlligatorClamps</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#AlligatorClamps">bato:AlligatorClamps</a>
    /// </summary>
    let AlligatorClamps = _prefixId.prefix "AlligatorClamps"
    /// <summary>
    ///   <para>rdfs:comment : A specific property of a battery characterization environment, related to its level of humidity.</para>
    ///   <para>skos:prefLabel : AmbientHumidity</para>
    ///   <para>rdfs:label : AmbientHumidity</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#AmbientHumidity">bato:AmbientHumidity</a>
    /// </summary>
    let AmbientHumidity = _prefixId.prefix "AmbientHumidity"
    /// <summary>
    ///   <para>rdfs:comment : The measurement unit of the humidity of a battery characterization hardware.</para>
    ///   <para>skos:prefLabel : AmbientHumidityUnit</para>
    ///   <para>rdfs:label : AmbientHumidityUnit</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#AmbientHumidityUnit">bato:AmbientHumidityUnit</a>
    /// </summary>
    let AmbientHumidityUnit = _prefixId.prefix "AmbientHumidityUnit"
    /// <summary>
    ///   <para>rdfs:comment : A specific property of a battery characterization environment, related to its level of luminosity (amount of light).</para>
    ///   <para>skos:prefLabel : AmbientLight</para>
    ///   <para>rdfs:label : AmbientLight</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#AmbientLight">bato:AmbientLight</a>
    /// </summary>
    let AmbientLight = _prefixId.prefix "AmbientLight"
    /// <summary>
    ///   <para>rdfs:comment : The measurement unit of the light of a battery characterization hardware.</para>
    ///   <para>skos:prefLabel : AmbientLightUnit</para>
    ///   <para>rdfs:label : AmbientLightUnit</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#AmbientLightUnit">bato:AmbientLightUnit</a>
    /// </summary>
    let AmbientLightUnit = _prefixId.prefix "AmbientLightUnit"
    /// <summary>
    ///   <para>rdfs:comment : A specific property of a battery characterization environment, related to its level of pressure.</para>
    ///   <para>skos:prefLabel : AmbientPressure</para>
    ///   <para>rdfs:label : AmbientPressure</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#AmbientPressure">bato:AmbientPressure</a>
    /// </summary>
    let AmbientPressure = _prefixId.prefix "AmbientPressure"
    /// <summary>
    ///   <para>rdfs:comment : The measurement unit of the pressure of a battery characterization hardware.</para>
    ///   <para>skos:prefLabel : AmbientPressureUnit</para>
    ///   <para>rdfs:label : AmbientPressureUnit</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#AmbientPressureUnit">bato:AmbientPressureUnit</a>
    /// </summary>
    let AmbientPressureUnit = _prefixId.prefix "AmbientPressureUnit"
    /// <summary>
    ///   <para>rdfs:comment : A specific property of a battery characterization environment, related to its level of temperature.</para>
    ///   <para>skos:prefLabel : AmbientTemperature</para>
    ///   <para>rdfs:label : AmbientTemperature</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#AmbientTemperature">bato:AmbientTemperature</a>
    /// </summary>
    let AmbientTemperature = _prefixId.prefix "AmbientTemperature"
    /// <summary>
    ///   <para>rdfs:comment : The measurement unit of the temperature of a battery characterization hardware.</para>
    ///   <para>skos:prefLabel : AmbientTemperatureUnit</para>
    ///   <para>rdfs:label : AmbientTemperatureUnit</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#AmbientTemperatureUnit">bato:AmbientTemperatureUnit</a>
    /// </summary>
    let AmbientTemperatureUnit = _prefixId.prefix "AmbientTemperatureUnit"

    /// <summary>
    ///   <para>skos:prefLabel : BatteryCharacterizationEnvironment</para>
    ///   <para>skos:altLabel : BatteryCharacterisationEnvironmentskos:altLabel : Ambientskos:altLabel : Environment</para>
    ///   <para>rdfs:label : BatteryCharacterizationEnvironment</para>
    ///   <para>rdfs:comment : The environment in which a battery characterization takes place. It may have a number of properties, or specifications, including pressure, humidity, temperature and light.</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationEnvironment">bato:BatteryCharacterizationEnvironment</a>
    /// </summary>
    let BatteryCharacterizationEnvironment =
        _prefixId.prefix "BatteryCharacterizationEnvironment"

    /// <summary>
    ///   <para>rdfs:comment : Measurement unit of a specification of a battery characterization hardware. It is a super-class of more specific classes.</para>
    ///   <para>skos:altLabel : BatteryAmbientMeasurementUnit</para>
    ///   <para>skos:prefLabel : BatteryCharacterizationEnvironmentMeasurementUnit</para>
    ///   <para>rdfs:label : BatteryCharacterizationEnvironmentMeasurementUnit</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationEnvironmentMeasurementUnit">bato:BatteryCharacterizationEnvironmentMeasurementUnit</a>
    /// </summary>
    let BatteryCharacterizationEnvironmentMeasurementUnit =
        _prefixId.prefix "BatteryCharacterizationEnvironmentMeasurementUnit"

    /// <summary>
    ///   <para>rdfs:comment : A property of a battery characterization environment, e.g. temperature, pressure, humidity, light. It is a super-class of more specific classes.</para>
    ///   <para>skos:prefLabel : BatteryCharacterizationEnvironmentProperty</para>
    ///   <para>rdfs:label : BatteryCharacterizationEnvironmentProperty</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationEnvironmentProperty">bato:BatteryCharacterizationEnvironmentProperty</a>
    /// </summary>
    let BatteryCharacterizationEnvironmentProperty =
        _prefixId.prefix "BatteryCharacterizationEnvironmentProperty"

    /// <summary>
    ///   <para>rdfs:comment : The physical apparatus of the battery testing procedure. It is required in a battery measurement process.</para>
    ///   <para>skos:altLabel : Hardware</para>
    ///   <para>skos:prefLabel : BatteryCharacterizationHardware</para>
    ///   <para>rdfs:label : BatteryCharacterizationHardware</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationHardware">bato:BatteryCharacterizationHardware</a>
    /// </summary>
    let BatteryCharacterizationHardware =
        _prefixId.prefix "BatteryCharacterizationHardware"

    /// <summary>
    ///   <para>rdfs:comment : A characteristic or specification of a battery testing hardware</para>
    ///   <para>skos:altLabel : BatteryHardwareSpecification</para>
    ///   <para>skos:prefLabel : BatteryCharacterizationHardwareSpecification</para>
    ///   <para>rdfs:label : BatteryCharacterizationHardwareSpecification</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationHardwareSpecification">bato:BatteryCharacterizationHardwareSpecification</a>
    /// </summary>
    let BatteryCharacterizationHardwareSpecification =
        _prefixId.prefix "BatteryCharacterizationHardwareSpecification"

    /// <summary>
    ///   <para>skos:altLabel : BatteryCharacterisationMethod</para>
    ///   <para>rdfs:comment : The description of the overall characterization method for a battery. It is usually made up of different steps, or tasks (e.g. battery measurement process, battery sample preparation).</para>
    ///   <para>rdfs:label : BatteryCharacterizationMethod</para>
    ///   <para>skos:prefLabel : BatteryCharacterizationMethod</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationMethod">bato:BatteryCharacterizationMethod</a>
    /// </summary>
    let BatteryCharacterizationMethod = _prefixId.prefix "BatteryCharacterizationMethod"
    /// <summary>
    ///   <para>rdfs:comment : The type of chemistry in a battery sample. It is a property of the sample.</para>
    ///   <para>skos:prefLabel : BatteryChemistryType</para>
    ///   <para>rdfs:label : BatteryChemistryType</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatteryChemistryType">bato:BatteryChemistryType</a>
    /// </summary>
    let BatteryChemistryType = _prefixId.prefix "BatteryChemistryType"
    /// <summary>
    ///   <para>rdfs:comment : A physical part of a battery.</para>
    ///   <para>skos:prefLabel : BatteryComponent</para>
    ///   <para>rdfs:label : BatteryComponent</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatteryComponent">bato:BatteryComponent</a>
    /// </summary>
    let BatteryComponent = _prefixId.prefix "BatteryComponent"
    /// <summary>
    ///   <para>rdfs:comment : A physical connector that connects a battery sample for the testing procedure.</para>
    ///   <para>skos:prefLabel : BatteryConnector</para>
    ///   <para>rdfs:label : BatteryConnector</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatteryConnector">bato:BatteryConnector</a>
    /// </summary>
    let BatteryConnector = _prefixId.prefix "BatteryConnector"
    /// <summary>
    ///   <para>rdfs:comment : The type of electrolyte in a battery sample. It is a property of the sample.</para>
    ///   <para>skos:prefLabel : BatteryElectrolyteType</para>
    ///   <para>rdfs:label : BatteryElectrolyteType</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatteryElectrolyteType">bato:BatteryElectrolyteType</a>
    /// </summary>
    let BatteryElectrolyteType = _prefixId.prefix "BatteryElectrolyteType"
    /// <summary>
    ///   <para>rdfs:comment : The device that holds the battery in place for the testing procedure.</para>
    ///   <para>skos:prefLabel : BatteryHolder</para>
    ///   <para>rdfs:label : BatteryHolder</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatteryHolder">bato:BatteryHolder</a>
    /// </summary>
    let BatteryHolder = _prefixId.prefix "BatteryHolder"
    /// <summary>
    ///   <para>rdfs:comment : A physical part of the holding device.</para>
    ///   <para>skos:prefLabel : BatteryHolderComponent</para>
    ///   <para>rdfs:label : BatteryHolderComponent</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatteryHolderComponent">bato:BatteryHolderComponent</a>
    /// </summary>
    let BatteryHolderComponent = _prefixId.prefix "BatteryHolderComponent"
    /// <summary>
    ///   <para>rdfs:comment : The name of the manufacturer of a battery sample. It is a property of the sample.</para>
    ///   <para>skos:prefLabel : BatteryManufacturerName</para>
    ///   <para>rdfs:label : BatteryManufacturerName</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatteryManufacturerName">bato:BatteryManufacturerName</a>
    /// </summary>
    let BatteryManufacturerName = _prefixId.prefix "BatteryManufacturerName"
    /// <summary>
    ///   <para>rdfs:comment : A configuration parameter of a battery measurement step in the testing procedure.</para>
    ///   <para>skos:prefLabel : BatteryMeasurementParameter</para>
    ///   <para>rdfs:label : BatteryMeasurementParameter</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatteryMeasurementParameter">bato:BatteryMeasurementParameter</a>
    /// </summary>
    let BatteryMeasurementParameter = _prefixId.prefix "BatteryMeasurementParameter"
    /// <summary>
    ///   <para>rdfs:label : BatteryMeasurementProcess</para>
    ///   <para>skos:prefLabel : BatteryMeasurementProcess</para>
    ///   <para>rdfs:comment : The measurement step in a battery characterization method. It involves at least a characterization hardware, a characterization environment, a battery sample to be measured, the configuration parameters, the level of accuracy and the location of the measurement. Its output is the trace data of the measurement.</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatteryMeasurementProcess">bato:BatteryMeasurementProcess</a>
    /// </summary>
    let BatteryMeasurementProcess = _prefixId.prefix "BatteryMeasurementProcess"

    /// <summary>
    ///   <para>rdfs:comment : A characteristic of the battery measurement process. It is a super-class of more specific classes.</para>
    ///   <para>skos:prefLabel : BatteryMeasurementProcessProperty</para>
    ///   <para>rdfs:label : BatteryMeasurementProcessProperty</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatteryMeasurementProcessProperty">bato:BatteryMeasurementProcessProperty</a>
    /// </summary>
    let BatteryMeasurementProcessProperty =
        _prefixId.prefix "BatteryMeasurementProcessProperty"

    /// <summary>
    ///   <para>rdfs:comment : The part number, or code, of a battery sample. It is a property of the sample.</para>
    ///   <para>skos:prefLabel : BatteryPartNumber</para>
    ///   <para>rdfs:label : BatteryPartNumber</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatteryPartNumber">bato:BatteryPartNumber</a>
    /// </summary>
    let BatteryPartNumber = _prefixId.prefix "BatteryPartNumber"
    /// <summary>
    ///   <para>rdfs:comment : The date reported as the one in which the battery sample has been produced. It is a property of the sample.</para>
    ///   <para>skos:prefLabel : BatteryProductionDate</para>
    ///   <para>rdfs:label : BatteryProductionDate</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatteryProductionDate">bato:BatteryProductionDate</a>
    /// </summary>
    let BatteryProductionDate = _prefixId.prefix "BatteryProductionDate"
    /// <summary>
    ///   <para>rdfs:comment : A battery selected from a larger set to be used in a battery testing procedure.</para>
    ///   <para>skos:prefLabel : BatterySample</para>
    ///   <para>rdfs:label : BatterySample</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatterySample">bato:BatterySample</a>
    /// </summary>
    let BatterySample = _prefixId.prefix "BatterySample"
    /// <summary>
    ///   <para>rdfs:comment : A step in the battery characterization method, related to the preparation of the battery sample to be tested. The battery sample, unprepared, is input to this step; the battery sample, prepared, is the output of this step. The holding device is a temporary participant of this step.</para>
    ///   <para>skos:prefLabel : BatterySamplePreparation</para>
    ///   <para>rdfs:label : BatterySamplePreparation</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatterySamplePreparation">bato:BatterySamplePreparation</a>
    /// </summary>
    let BatterySamplePreparation = _prefixId.prefix "BatterySamplePreparation"
    /// <summary>
    ///   <para>rdfs:comment : A characteristic of a battery sample.</para>
    ///   <para>skos:prefLabel : BatterySampleProperty</para>
    ///   <para>rdfs:label : BatterySampleProperty</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatterySampleProperty">bato:BatterySampleProperty</a>
    /// </summary>
    let BatterySampleProperty = _prefixId.prefix "BatterySampleProperty"
    /// <summary>
    ///   <para>rdfs:comment : This is the root class of the BTO ontology, introduced for grouping all of BTO's classes under a single parent class, each at a different hierarchical position.</para>
    ///   <para>skos:prefLabel : BatteryTestingOntology</para>
    ///   <para>rdfs:label : BatteryTestingOntology</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#BatteryTestingOntology">bato:BatteryTestingOntology</a>
    /// </summary>
    let BatteryTestingOntology = _prefixId.prefix "BatteryTestingOntology"
    /// <summary>
    ///   <para>rdfs:comment : A physical cable that connects a battery sample for the testing procedure.</para>
    ///   <para>skos:prefLabel : Cable</para>
    ///   <para>rdfs:label : Cable</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#Cable">bato:Cable</a>
    /// </summary>
    let Cable = _prefixId.prefix "Cable"

    /// <summary>
    ///   <para>skos:altLabel : CalibrationForBatteryCharacterisationskos:altLabel : BatteryCharacterizationCalibrationskos:altLabel : BatteryCharacterisationCalibration</para>
    ///   <para>rdfs:label : CalibrationForBatteryCharacterization</para>
    ///   <para>skos:prefLabel : CalibrationForBatteryCharacterization</para>
    ///   <para>rdfs:comment : The process of calibration of a battery characterization hardware with reference to a voltage source, which produces as output a reference voltage data.</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#CalibrationForBatteryCharacterization">bato:CalibrationForBatteryCharacterization</a>
    /// </summary>
    let CalibrationForBatteryCharacterization =
        _prefixId.prefix "CalibrationForBatteryCharacterization"

    /// <summary>
    ///   <para>rdfs:comment : A specific type of trace data output from a battery measurement process, related to the current measured.</para>
    ///   <para>skos:prefLabel : CurrentData</para>
    ///   <para>rdfs:label : CurrentData</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#CurrentData">bato:CurrentData</a>
    /// </summary>
    let CurrentData = _prefixId.prefix "CurrentData"
    /// <summary>
    ///   <para>rdfs:comment : A specification of the battery characterization hardware, related to the current it can sustain.</para>
    ///   <para>skos:prefLabel : CurrentSpecification</para>
    ///   <para>rdfs:label : CurrentSpecification</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#CurrentSpecification">bato:CurrentSpecification</a>
    /// </summary>
    let CurrentSpecification = _prefixId.prefix "CurrentSpecification"
    /// <summary>
    ///   <para>rdfs:comment : A parameter in the battery measurement step. It specifies the end time of the measurement.</para>
    ///   <para>skos:prefLabel : EndTime</para>
    ///   <para>rdfs:label : EndTime</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#EndTime">bato:EndTime</a>
    /// </summary>
    let EndTime = _prefixId.prefix "EndTime"
    /// <summary>
    ///   <para>rdfs:comment : A type of holding device for a battery sample. It may consist of a battery connector and a cable.</para>
    ///   <para>skos:prefLabel : Fixture</para>
    ///   <para>rdfs:label : Fixture</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#Fixture">bato:Fixture</a>
    /// </summary>
    let Fixture = _prefixId.prefix "Fixture"
    /// <summary>
    ///   <para>rdfs:comment : The name of the manufacturer of the hardware used for the measurement process.</para>
    ///   <para>skos:prefLabel : HardwareManufacturerName</para>
    ///   <para>rdfs:label : HardwareManufacturerName</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#HardwareManufacturerName">bato:HardwareManufacturerName</a>
    /// </summary>
    let HardwareManufacturerName = _prefixId.prefix "HardwareManufacturerName"
    /// <summary>
    ///   <para>rdfs:comment : The model of the hardware used for the measurement process.</para>
    ///   <para>skos:prefLabel : HardwareModel</para>
    ///   <para>rdfs:label : HardwareModel</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#HardwareModel">bato:HardwareModel</a>
    /// </summary>
    let HardwareModel = _prefixId.prefix "HardwareModel"
    /// <summary>
    ///   <para>rdfs:comment : The type of the hardware used for the measurement process.</para>
    ///   <para>skos:prefLabel : HardwareType</para>
    ///   <para>rdfs:label : HardwareType</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#HardwareType">bato:HardwareType</a>
    /// </summary>
    let HardwareType = _prefixId.prefix "HardwareType"
    /// <summary>
    ///   <para>rdfs:comment : A specific type of cable.</para>
    ///   <para>skos:prefLabel : HipotCable</para>
    ///   <para>rdfs:label : HipotCable</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#HipotCable">bato:HipotCable</a>
    /// </summary>
    let HipotCable = _prefixId.prefix "HipotCable"
    /// <summary>
    ///   <para>rdfs:comment : A parameter in the battery measurement step. It specifies the maximum voltage of the measurement.</para>
    ///   <para>skos:prefLabel : MaxVoltage</para>
    ///   <para>rdfs:label : MaxVoltage</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#MaxVoltage">bato:MaxVoltage</a>
    /// </summary>
    let MaxVoltage = _prefixId.prefix "MaxVoltage"
    let PreparedBatterySample = _prefixId.prefix "PreparedBatterySample"
    /// <summary>
    ///   <para>rdfs:comment : A battery sample that has been prepared for testing. It is thus the output of the process of preparing a battery sample.</para>
    ///   <para>skos:prefLabel : PreparedBatterySample</para>
    ///   <para>rdfs:label : PreparedBatterySample</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#PreparedatterySample">bato:PreparedatterySample</a>
    /// </summary>
    let PreparedatterySample = _prefixId.prefix "PreparedatterySample"
    /// <summary>
    ///   <para>rdfs:comment : A battery sample to be prepared for testing. It is thus the input of the process of preparing a battery sample.</para>
    ///   <para>skos:prefLabel : RawBatterySample</para>
    ///   <para>rdfs:label : RawBatterySample</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#RawBatterySample">bato:RawBatterySample</a>
    /// </summary>
    let RawBatterySample = _prefixId.prefix "RawBatterySample"
    /// <summary>
    ///   <para>rdfs:comment : A parameter in the battery measurement step. It specifies the sampling time of the measurement.</para>
    ///   <para>skos:prefLabel : SamplingTime</para>
    ///   <para>rdfs:label : SamplingTime</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#SamplingTime">bato:SamplingTime</a>
    /// </summary>
    let SamplingTime = _prefixId.prefix "SamplingTime"
    /// <summary>
    ///   <para>rdfs:comment : A specific type of trace data output from a battery measurement process, related to the time intervals of the measurement.</para>
    ///   <para>skos:prefLabel : TimeData</para>
    ///   <para>rdfs:label : TimeData</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#TimeData">bato:TimeData</a>
    /// </summary>
    let TimeData = _prefixId.prefix "TimeData"
    /// <summary>
    ///   <para>rdfs:comment : The output of a battery measurement process in terms of raw data resulting from the measurement.</para>
    ///   <para>skos:prefLabel : TraceData</para>
    ///   <para>rdfs:label : TraceData</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#TraceData">bato:TraceData</a>
    /// </summary>
    let TraceData = _prefixId.prefix "TraceData"
    /// <summary>
    ///   <para>rdfs:comment : A specific type of trace data output from a battery measurement process, related to the voltage measured.</para>
    ///   <para>skos:prefLabel : VoltageData</para>
    ///   <para>rdfs:label : VoltageData</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#VoltageData">bato:VoltageData</a>
    /// </summary>
    let VoltageData = _prefixId.prefix "VoltageData"
    /// <summary>
    ///   <para>rdfs:comment : A voltage source used as a reference for the calibration of a battery characterization hardware.</para>
    ///   <para>skos:prefLabel : VoltageSource</para>
    ///   <para>rdfs:label : VoltageSource</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#VoltageSource">bato:VoltageSource</a>
    /// </summary>
    let VoltageSource = _prefixId.prefix "VoltageSource"
    /// <summary>
    ///   <para>rdfs:comment : A specification of the battery characterization hardware, related to the voltage it can provide.</para>
    ///   <para>skos:prefLabel : VoltageSpecification</para>
    ///   <para>rdfs:label : VoltageSpecification</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#VoltageSpecification">bato:VoltageSpecification</a>
    /// </summary>
    let VoltageSpecification = _prefixId.prefix "VoltageSpecification"
    /// <summary>
    ///   <para>rdfs:comment : This is the root datatype property of the BTO ontology, introduced for grouping all of BTO's datatype properties under a single parent datatype property.</para>
    ///   <para>skos:prefLabel : btoDatatypeProperty</para>
    ///   <para>rdfs:label : btoDatatypeProperty</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#btoDatatypeProperty">bato:btoDatatypeProperty</a>
    /// </summary>
    let btoDatatypeProperty = _prefixId.prefix "btoDatatypeProperty"
    /// <summary>
    ///   <para>rdfs:comment : This is the root object property of the BTO ontology, introduced for grouping all of BTO's object properties under a single parent object property.</para>
    ///   <para>skos:prefLabel : btoObjectProperty</para>
    ///   <para>rdfs:label : btoObjectProperty</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#btoObjectProperty">bato:btoObjectProperty</a>
    /// </summary>
    let btoObjectProperty = _prefixId.prefix "btoObjectProperty"

    /// <summary>
    ///   <para>skos:altLabel : hasBatteryCharacterisationHardwarePropertyskos:altLabel : hasHardwareSpecificationskos:altLabel : hasBatteryCharacterisationHardwareSpecificationskos:altLabel : hasBatteryCharacterizationHardwarePropertyskos:altLabel : hasHardwareProperty</para>
    ///   <para>skos:prefLabel : hasBatteryCharacterizationHardwareSpecification</para>
    ///   <para>rdfs:label : hasBatteryCharacterizationHardwareSpecification</para>
    ///   <para>rdfs:comment : Object property that connects a battery characterization hardware with its specifications. It is a super-property of more specific object properties.</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#hasBatteryCharacterizationHardwareSpecification">bato:hasBatteryCharacterizationHardwareSpecification</a>
    /// </summary>
    let hasBatteryCharacterizationHardwareSpecification =
        _prefixId.prefix "hasBatteryCharacterizationHardwareSpecification"

    /// <summary>
    ///   <para>rdfs:comment : Object property that connects a battery sample with its characteristics (BatterySampleProperties). It is the super-property of a number of more specific object properties.</para>
    ///   <para>skos:prefLabel : hasBatterySampleProperty^^xsd:string</para>
    ///   <para>rdfs:label : hasBatterySampleProperty</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#hasBatterySampleProperty">bato:hasBatterySampleProperty</a>
    /// </summary>
    let hasBatterySampleProperty = _prefixId.prefix "hasBatterySampleProperty"
    /// <summary>
    ///   <para>rdfs:comment : A specific object property that connects a battery sample with its cell form.</para>
    ///   <para>skos:preflabel : hasCellForm</para>
    ///   <para>rdfs:label : hasCellForm</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#hasCellForm">bato:hasCellForm</a>
    /// </summary>
    let hasCellForm = _prefixId.prefix "hasCellForm"
    /// <summary>
    ///   <para>rdfs:comment : A specific object property that connects a battery sample with its chemistry type.</para>
    ///   <para>skos:preflabel : hasChemistryType</para>
    ///   <para>rdfs:label : hasChemistryType</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#hasChemistryType">bato:hasChemistryType</a>
    /// </summary>
    let hasChemistryType = _prefixId.prefix "hasChemistryType"
    /// <summary>
    ///   <para>rdfs:comment : A specific object property that connects a battery characterization hardware with its current specification.</para>
    ///   <para>skos:preflabel : hasCurrentSpecification</para>
    ///   <para>rdfs:label : hasCurrentSpecification</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#hasCurrentSpecification">bato:hasCurrentSpecification</a>
    /// </summary>
    let hasCurrentSpecification = _prefixId.prefix "hasCurrentSpecification"
    /// <summary>
    ///   <para>rdfs:comment : A specific object property that connects a battery sample with its electrolyte type.</para>
    ///   <para>skos:preflabel : hasElectrolyteType</para>
    ///   <para>rdfs:label : hasElectrolyteType</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#hasElectrolyteType">bato:hasElectrolyteType</a>
    /// </summary>
    let hasElectrolyteType = _prefixId.prefix "hasElectrolyteType"
    /// <summary>
    ///   <para>rdfs:comment : A specific object property that connects a battery characterization hardware with its hardware model.</para>
    ///   <para>skos:preflabel : hasHardwareModel</para>
    ///   <para>rdfs:label : hasHardwareModel</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#hasHardwareModel">bato:hasHardwareModel</a>
    /// </summary>
    let hasHardwareModel = _prefixId.prefix "hasHardwareModel"
    /// <summary>
    ///   <para>rdfs:comment : A specific object property that connects a battery characterization hardware with its hardware type.</para>
    ///   <para>skos:preflabel : hasHardwareType</para>
    ///   <para>rdfs:label : hasHardwareType</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#hasHardwareType">bato:hasHardwareType</a>
    /// </summary>
    let hasHardwareType = _prefixId.prefix "hasHardwareType"
    /// <summary>
    ///   <para>rdfs:comment : A specific object property that connects either a battery sample or its characterization hardware with its manufacturer.</para>
    ///   <para>skos:altlabel : hasManufacturer</para>
    ///   <para>skos:preflabel : hasManufacturer</para>
    ///   <para>rdfs:label : hasManufacturer</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#hasManufacturer">bato:hasManufacturer</a>
    /// </summary>
    let hasManufacturer = _prefixId.prefix "hasManufacturer"
    /// <summary>
    ///   <para>rdfs:comment : A specific object property that connects a battery sample with its part number.</para>
    ///   <para>skos:preflabel : hasPartNumber</para>
    ///   <para>rdfs:label : hasPartNumber</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#hasPartNumber">bato:hasPartNumber</a>
    /// </summary>
    let hasPartNumber = _prefixId.prefix "hasPartNumber"
    /// <summary>
    ///   <para>rdfs:comment : A specific datatype property that specifies a production date for a battery sample.</para>
    ///   <para>skos:preflabel : hasProductionDate^^xsd:string</para>
    ///   <para>rdfs:label : hasProductionDate</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#hasProductionDate">bato:hasProductionDate</a>
    /// </summary>
    let hasProductionDate = _prefixId.prefix "hasProductionDate"
    /// <summary>
    ///   <para>rdfs:comment : A specific object property that connects a battery characterization hardware with its voltage specification.</para>
    ///   <para>skos:preflabel : hasVoltageSpecification</para>
    ///   <para>rdfs:label : hasVoltageSpecification</para>
    ///   <a href="http://w3id.org/emmo-bto/bto#hasVoltageSpecification">bato:hasVoltageSpecification</a>
    /// </summary>
    let hasVoltageSpecification = _prefixId.prefix "hasVoltageSpecification"
