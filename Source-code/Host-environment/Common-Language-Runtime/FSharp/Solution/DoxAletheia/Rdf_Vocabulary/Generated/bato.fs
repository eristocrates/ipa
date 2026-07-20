namespace http.w3id.org.emmo_bto.bto.hash

open DoxAletheia

module bato =
    let _namespace_name = "http://w3id.org/emmo-bto/bto#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The level of accuracy of a battery measurement process. It is a property of the process.
    /// <see href="http://w3id.org/emmo-bto/bto#Accuracy"></see></summary>
    let Accuracy = _prefix "Accuracy"
    /// <summary>
    /// A characteristic of the battery measurement process. It is a super-class of more specific classes.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryMeasurementProcessProperty"></see></summary>
    let BatteryMeasurementProcessProperty = _prefix "BatteryMeasurementProcessProperty"
    /// <summary>
    /// A specific type of battery connector.
    /// <see href="http://w3id.org/emmo-bto/bto#AlligatorClamps"></see></summary>
    let AlligatorClamps = _prefix "AlligatorClamps"
    /// <summary>
    /// A physical connector that connects a battery sample for the testing procedure.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryConnector"></see></summary>
    let BatteryConnector = _prefix "BatteryConnector"
    /// <summary>
    /// A specific property of a battery characterization environment, related to its level of humidity.
    /// <see href="http://w3id.org/emmo-bto/bto#AmbientHumidity"></see></summary>
    let AmbientHumidity = _prefix "AmbientHumidity"
    /// <summary>
    /// The measurement unit of the humidity of a battery characterization hardware.
    /// <see href="http://w3id.org/emmo-bto/bto#AmbientHumidityUnit"></see></summary>
    let AmbientHumidityUnit = _prefix "AmbientHumidityUnit"

    /// <summary>
    /// A property of a battery characterization environment, e.g. temperature, pressure, humidity, light. It is a super-class of more specific classes.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationEnvironmentProperty"></see></summary>
    let BatteryCharacterizationEnvironmentProperty =
        _prefix "BatteryCharacterizationEnvironmentProperty"

    /// <summary>
    /// Measurement unit of a specification of a battery characterization hardware. It is a super-class of more specific classes.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationEnvironmentMeasurementUnit"></see></summary>
    let BatteryCharacterizationEnvironmentMeasurementUnit =
        _prefix "BatteryCharacterizationEnvironmentMeasurementUnit"

    /// <summary>
    /// A specific property of a battery characterization environment, related to its level of luminosity (amount of light).
    /// <see href="http://w3id.org/emmo-bto/bto#AmbientLight"></see></summary>
    let AmbientLight = _prefix "AmbientLight"
    /// <summary>
    /// The measurement unit of the light of a battery characterization hardware.
    /// <see href="http://w3id.org/emmo-bto/bto#AmbientLightUnit"></see></summary>
    let AmbientLightUnit = _prefix "AmbientLightUnit"
    /// <summary>
    /// A specific property of a battery characterization environment, related to its level of pressure.
    /// <see href="http://w3id.org/emmo-bto/bto#AmbientPressure"></see></summary>
    let AmbientPressure = _prefix "AmbientPressure"
    /// <summary>
    /// The measurement unit of the pressure of a battery characterization hardware.
    /// <see href="http://w3id.org/emmo-bto/bto#AmbientPressureUnit"></see></summary>
    let AmbientPressureUnit = _prefix "AmbientPressureUnit"
    /// <summary>
    /// A specific property of a battery characterization environment, related to its level of temperature.
    /// <see href="http://w3id.org/emmo-bto/bto#AmbientTemperature"></see></summary>
    let AmbientTemperature = _prefix "AmbientTemperature"
    /// <summary>
    /// The measurement unit of the temperature of a battery characterization hardware.
    /// <see href="http://w3id.org/emmo-bto/bto#AmbientTemperatureUnit"></see></summary>
    let AmbientTemperatureUnit = _prefix "AmbientTemperatureUnit"

    /// <summary>
    /// The environment in which a battery characterization takes place. It may have a number of properties, or specifications, including pressure, humidity, temperature and light.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationEnvironment"></see></summary>
    let BatteryCharacterizationEnvironment =
        _prefix "BatteryCharacterizationEnvironment"

    /// <summary>
    /// This is the root class of the BTO ontology, introduced for grouping all of BTO's classes under a single parent class, each at a different hierarchical position.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryTestingOntology"></see></summary>
    let BatteryTestingOntology = _prefix "BatteryTestingOntology"
    /// <summary>
    /// The physical apparatus of the battery testing procedure. It is required in a battery measurement process.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationHardware"></see></summary>
    let BatteryCharacterizationHardware = _prefix "BatteryCharacterizationHardware"

    /// <summary>
    /// A characteristic or specification of a battery testing hardware
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationHardwareSpecification"></see></summary>
    let BatteryCharacterizationHardwareSpecification =
        _prefix "BatteryCharacterizationHardwareSpecification"

    /// <summary>
    /// The description of the overall characterization method for a battery. It is usually made up of different steps, or tasks (e.g. battery measurement process, battery sample preparation).
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationMethod"></see></summary>
    let BatteryCharacterizationMethod = _prefix "BatteryCharacterizationMethod"
    /// <summary>
    /// The measurement step in a battery characterization method. It involves at least a characterization hardware, a characterization environment, a battery sample to be measured, the configuration parameters, the level of accuracy and the location of the measurement. Its output is the trace data of the measurement.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryMeasurementProcess"></see></summary>
    let BatteryMeasurementProcess = _prefix "BatteryMeasurementProcess"

    /// <summary>
    /// The process of calibration of a battery characterization hardware with reference to a voltage source, which produces as output a reference voltage data.
    /// <see href="http://w3id.org/emmo-bto/bto#CalibrationForBatteryCharacterization"></see></summary>
    let CalibrationForBatteryCharacterization =
        _prefix "CalibrationForBatteryCharacterization"

    /// <summary>
    /// A step in the battery characterization method, related to the preparation of the battery sample to be tested. The battery sample, unprepared, is input to this step; the battery sample, prepared, is the output of this step. The holding device is a temporary participant of this step.
    /// <see href="http://w3id.org/emmo-bto/bto#BatterySamplePreparation"></see></summary>
    let BatterySamplePreparation = _prefix "BatterySamplePreparation"
    /// <summary>
    /// The type of chemistry in a battery sample. It is a property of the sample.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryChemistryType"></see></summary>
    let BatteryChemistryType = _prefix "BatteryChemistryType"
    /// <summary>
    /// A characteristic of a battery sample.
    /// <see href="http://w3id.org/emmo-bto/bto#BatterySampleProperty"></see></summary>
    let BatterySampleProperty = _prefix "BatterySampleProperty"
    /// <summary>
    /// A physical part of a battery.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryComponent"></see></summary>
    let BatteryComponent = _prefix "BatteryComponent"
    /// <summary>
    /// A physical part of the holding device.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryHolderComponent"></see></summary>
    let BatteryHolderComponent = _prefix "BatteryHolderComponent"
    /// <summary>
    /// The type of electrolyte in a battery sample. It is a property of the sample.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryElectrolyteType"></see></summary>
    let BatteryElectrolyteType = _prefix "BatteryElectrolyteType"
    /// <summary>
    /// The device that holds the battery in place for the testing procedure.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryHolder"></see></summary>
    let BatteryHolder = _prefix "BatteryHolder"
    /// <summary>
    /// The name of the manufacturer of a battery sample. It is a property of the sample.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryManufacturerName"></see></summary>
    let BatteryManufacturerName = _prefix "BatteryManufacturerName"
    /// <summary>
    /// A configuration parameter of a battery measurement step in the testing procedure.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryMeasurementParameter"></see></summary>
    let BatteryMeasurementParameter = _prefix "BatteryMeasurementParameter"
    /// <summary>
    /// A battery selected from a larger set to be used in a battery testing procedure.
    /// <see href="http://w3id.org/emmo-bto/bto#BatterySample"></see></summary>
    let BatterySample = _prefix "BatterySample"
    /// <summary>
    /// A parameter in the battery measurement step. It specifies the maximum voltage of the measurement.
    /// <see href="http://w3id.org/emmo-bto/bto#MaxVoltage"></see></summary>
    let MaxVoltage = _prefix "MaxVoltage"
    /// <summary>
    /// A specific type of trace data output from a battery measurement process, related to the current measured.
    /// <see href="http://w3id.org/emmo-bto/bto#CurrentData"></see></summary>
    let CurrentData = _prefix "CurrentData"
    /// <summary>
    /// A parameter in the battery measurement step. It specifies the end time of the measurement.
    /// <see href="http://w3id.org/emmo-bto/bto#EndTime"></see></summary>
    let EndTime = _prefix "EndTime"
    /// <summary>
    /// A parameter in the battery measurement step. It specifies the sampling time of the measurement.
    /// <see href="http://w3id.org/emmo-bto/bto#SamplingTime"></see></summary>
    let SamplingTime = _prefix "SamplingTime"
    /// <summary>
    /// A specific type of trace data output from a battery measurement process, related to the voltage measured.
    /// <see href="http://w3id.org/emmo-bto/bto#VoltageData"></see></summary>
    let VoltageData = _prefix "VoltageData"
    /// <summary>
    /// A specific type of trace data output from a battery measurement process, related to the time intervals of the measurement.
    /// <see href="http://w3id.org/emmo-bto/bto#TimeData"></see></summary>
    let TimeData = _prefix "TimeData"
    /// <summary>
    /// The part number, or code, of a battery sample. It is a property of the sample.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryPartNumber"></see></summary>
    let BatteryPartNumber = _prefix "BatteryPartNumber"
    /// <summary>
    /// The date reported as the one in which the battery sample has been produced. It is a property of the sample.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryProductionDate"></see></summary>
    let BatteryProductionDate = _prefix "BatteryProductionDate"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-bto/bto#PreparedBatterySample"></see>
    /// </summary>
    let PreparedBatterySample = _prefix "PreparedBatterySample"
    /// <summary>
    /// A battery sample to be prepared for testing. It is thus the input of the process of preparing a battery sample.
    /// <see href="http://w3id.org/emmo-bto/bto#RawBatterySample"></see></summary>
    let RawBatterySample = _prefix "RawBatterySample"
    /// <summary>
    /// A physical cable that connects a battery sample for the testing procedure.
    /// <see href="http://w3id.org/emmo-bto/bto#Cable"></see></summary>
    let Cable = _prefix "Cable"
    /// <summary>
    /// A voltage source used as a reference for the calibration of a battery characterization hardware.
    /// <see href="http://w3id.org/emmo-bto/bto#VoltageSource"></see></summary>
    let VoltageSource = _prefix "VoltageSource"
    /// <summary>
    /// The output of a battery measurement process in terms of raw data resulting from the measurement.
    /// <see href="http://w3id.org/emmo-bto/bto#TraceData"></see></summary>
    let TraceData = _prefix "TraceData"
    /// <summary>
    /// A specification of the battery characterization hardware, related to the current it can sustain.
    /// <see href="http://w3id.org/emmo-bto/bto#CurrentSpecification"></see></summary>
    let CurrentSpecification = _prefix "CurrentSpecification"
    /// <summary>
    /// A type of holding device for a battery sample. It may consist of a battery connector and a cable.
    /// <see href="http://w3id.org/emmo-bto/bto#Fixture"></see></summary>
    let Fixture = _prefix "Fixture"
    /// <summary>
    /// The name of the manufacturer of the hardware used for the measurement process.
    /// <see href="http://w3id.org/emmo-bto/bto#HardwareManufacturerName"></see></summary>
    let HardwareManufacturerName = _prefix "HardwareManufacturerName"
    /// <summary>
    /// The model of the hardware used for the measurement process.
    /// <see href="http://w3id.org/emmo-bto/bto#HardwareModel"></see></summary>
    let HardwareModel = _prefix "HardwareModel"
    /// <summary>
    /// The type of the hardware used for the measurement process.
    /// <see href="http://w3id.org/emmo-bto/bto#HardwareType"></see></summary>
    let HardwareType = _prefix "HardwareType"
    /// <summary>
    /// A specific type of cable.
    /// <see href="http://w3id.org/emmo-bto/bto#HipotCable"></see></summary>
    let HipotCable = _prefix "HipotCable"
    /// <summary>
    /// A battery sample that has been prepared for testing. It is thus the output of the process of preparing a battery sample.
    /// <see href="http://w3id.org/emmo-bto/bto#PreparedatterySample"></see></summary>
    let PreparedatterySample = _prefix "PreparedatterySample"
    /// <summary>
    /// A specification of the battery characterization hardware, related to the voltage it can provide.
    /// <see href="http://w3id.org/emmo-bto/bto#VoltageSpecification"></see></summary>
    let VoltageSpecification = _prefix "VoltageSpecification"
    /// <summary>
    /// This is the root datatype property of the BTO ontology, introduced for grouping all of BTO's datatype properties under a single parent datatype property.
    /// <see href="http://w3id.org/emmo-bto/bto#btoDatatypeProperty"></see></summary>
    let btoDatatypeProperty = _prefix "btoDatatypeProperty"
    /// <summary>
    /// This is the root object property of the BTO ontology, introduced for grouping all of BTO's object properties under a single parent object property.
    /// <see href="http://w3id.org/emmo-bto/bto#btoObjectProperty"></see></summary>
    let btoObjectProperty = _prefix "btoObjectProperty"

    /// <summary>
    /// Object property that connects a battery characterization hardware with its specifications. It is a super-property of more specific object properties.
    /// <see href="http://w3id.org/emmo-bto/bto#hasBatteryCharacterizationHardwareSpecification"></see></summary>
    let hasBatteryCharacterizationHardwareSpecification =
        _prefix "hasBatteryCharacterizationHardwareSpecification"

    /// <summary>
    /// Object property that connects a battery sample with its characteristics (BatterySampleProperties). It is the super-property of a number of more specific object properties.
    /// <see href="http://w3id.org/emmo-bto/bto#hasBatterySampleProperty"></see></summary>
    let hasBatterySampleProperty = _prefix "hasBatterySampleProperty"
    /// <summary>
    /// A specific object property that connects a battery sample with its cell form.
    /// <see href="http://w3id.org/emmo-bto/bto#hasCellForm"></see></summary>
    let hasCellForm = _prefix "hasCellForm"
    /// <summary>
    /// A specific object property that connects a battery sample with its chemistry type.
    /// <see href="http://w3id.org/emmo-bto/bto#hasChemistryType"></see></summary>
    let hasChemistryType = _prefix "hasChemistryType"
    /// <summary>
    /// A specific object property that connects a battery characterization hardware with its current specification.
    /// <see href="http://w3id.org/emmo-bto/bto#hasCurrentSpecification"></see></summary>
    let hasCurrentSpecification = _prefix "hasCurrentSpecification"
    /// <summary>
    /// A specific object property that connects a battery sample with its electrolyte type.
    /// <see href="http://w3id.org/emmo-bto/bto#hasElectrolyteType"></see></summary>
    let hasElectrolyteType = _prefix "hasElectrolyteType"
    /// <summary>
    /// A specific object property that connects a battery characterization hardware with its hardware model.
    /// <see href="http://w3id.org/emmo-bto/bto#hasHardwareModel"></see></summary>
    let hasHardwareModel = _prefix "hasHardwareModel"
    /// <summary>
    /// A specific object property that connects a battery characterization hardware with its hardware type.
    /// <see href="http://w3id.org/emmo-bto/bto#hasHardwareType"></see></summary>
    let hasHardwareType = _prefix "hasHardwareType"
    /// <summary>
    /// A specific object property that connects either a battery sample or its characterization hardware with its manufacturer.
    /// <see href="http://w3id.org/emmo-bto/bto#hasManufacturer"></see></summary>
    let hasManufacturer = _prefix "hasManufacturer"
    /// <summary>
    /// A specific object property that connects a battery sample with its part number.
    /// <see href="http://w3id.org/emmo-bto/bto#hasPartNumber"></see></summary>
    let hasPartNumber = _prefix "hasPartNumber"
    /// <summary>
    /// A specific datatype property that specifies a production date for a battery sample.
    /// <see href="http://w3id.org/emmo-bto/bto#hasProductionDate"></see></summary>
    let hasProductionDate = _prefix "hasProductionDate"
    /// <summary>
    /// A specific object property that connects a battery characterization hardware with its voltage specification.
    /// <see href="http://w3id.org/emmo-bto/bto#hasVoltageSpecification"></see></summary>
    let hasVoltageSpecification = _prefix "hasVoltageSpecification"
