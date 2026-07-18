namespace http.w3id.org.emmo_bto.bto.hash

open DoxAletheia.Rdf_Vocabulary

module bato =
    let _namespace_name = "http://w3id.org/emmo-bto/bto#"
    /// <summary>
    /// The level of accuracy of a battery measurement process. It is a property of the process.
    /// <see href="http://w3id.org/emmo-bto/bto#Accuracy"></see></summary>
    let Accuracy = Namespaced_IRI.parse _namespace_name "Accuracy" |> NamespacedName

    /// <summary>
    /// A characteristic of the battery measurement process. It is a super-class of more specific classes.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryMeasurementProcessProperty"></see></summary>
    let BatteryMeasurementProcessProperty =
        Namespaced_IRI.parse _namespace_name "BatteryMeasurementProcessProperty" |> NamespacedName

    /// <summary>
    /// A specific type of battery connector.
    /// <see href="http://w3id.org/emmo-bto/bto#AlligatorClamps"></see></summary>
    let AlligatorClamps =
        Namespaced_IRI.parse _namespace_name "AlligatorClamps" |> NamespacedName

    /// <summary>
    /// A physical connector that connects a battery sample for the testing procedure.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryConnector"></see></summary>
    let BatteryConnector =
        Namespaced_IRI.parse _namespace_name "BatteryConnector" |> NamespacedName

    /// <summary>
    /// A specific property of a battery characterization environment, related to its level of humidity.
    /// <see href="http://w3id.org/emmo-bto/bto#AmbientHumidity"></see></summary>
    let AmbientHumidity =
        Namespaced_IRI.parse _namespace_name "AmbientHumidity" |> NamespacedName

    /// <summary>
    /// The measurement unit of the humidity of a battery characterization hardware.
    /// <see href="http://w3id.org/emmo-bto/bto#AmbientHumidityUnit"></see></summary>
    let AmbientHumidityUnit =
        Namespaced_IRI.parse _namespace_name "AmbientHumidityUnit" |> NamespacedName

    /// <summary>
    /// A property of a battery characterization environment, e.g. temperature, pressure, humidity, light. It is a super-class of more specific classes.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationEnvironmentProperty"></see></summary>
    let BatteryCharacterizationEnvironmentProperty =
        Namespaced_IRI.parse _namespace_name "BatteryCharacterizationEnvironmentProperty" |> NamespacedName

    /// <summary>
    /// Measurement unit of a specification of a battery characterization hardware. It is a super-class of more specific classes.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationEnvironmentMeasurementUnit"></see></summary>
    let BatteryCharacterizationEnvironmentMeasurementUnit =
        Namespaced_IRI.parse _namespace_name "BatteryCharacterizationEnvironmentMeasurementUnit" |> NamespacedName

    /// <summary>
    /// A specific property of a battery characterization environment, related to its level of luminosity (amount of light).
    /// <see href="http://w3id.org/emmo-bto/bto#AmbientLight"></see></summary>
    let AmbientLight =
        Namespaced_IRI.parse _namespace_name "AmbientLight" |> NamespacedName

    /// <summary>
    /// The measurement unit of the light of a battery characterization hardware.
    /// <see href="http://w3id.org/emmo-bto/bto#AmbientLightUnit"></see></summary>
    let AmbientLightUnit =
        Namespaced_IRI.parse _namespace_name "AmbientLightUnit" |> NamespacedName

    /// <summary>
    /// A specific property of a battery characterization environment, related to its level of pressure.
    /// <see href="http://w3id.org/emmo-bto/bto#AmbientPressure"></see></summary>
    let AmbientPressure =
        Namespaced_IRI.parse _namespace_name "AmbientPressure" |> NamespacedName

    /// <summary>
    /// The measurement unit of the pressure of a battery characterization hardware.
    /// <see href="http://w3id.org/emmo-bto/bto#AmbientPressureUnit"></see></summary>
    let AmbientPressureUnit =
        Namespaced_IRI.parse _namespace_name "AmbientPressureUnit" |> NamespacedName

    /// <summary>
    /// A specific property of a battery characterization environment, related to its level of temperature.
    /// <see href="http://w3id.org/emmo-bto/bto#AmbientTemperature"></see></summary>
    let AmbientTemperature =
        Namespaced_IRI.parse _namespace_name "AmbientTemperature" |> NamespacedName

    /// <summary>
    /// The measurement unit of the temperature of a battery characterization hardware.
    /// <see href="http://w3id.org/emmo-bto/bto#AmbientTemperatureUnit"></see></summary>
    let AmbientTemperatureUnit =
        Namespaced_IRI.parse _namespace_name "AmbientTemperatureUnit" |> NamespacedName

    /// <summary>
    /// The environment in which a battery characterization takes place. It may have a number of properties, or specifications, including pressure, humidity, temperature and light.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationEnvironment"></see></summary>
    let BatteryCharacterizationEnvironment =
        Namespaced_IRI.parse _namespace_name "BatteryCharacterizationEnvironment" |> NamespacedName

    /// <summary>
    /// This is the root class of the BTO ontology, introduced for grouping all of BTO's classes under a single parent class, each at a different hierarchical position.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryTestingOntology"></see></summary>
    let BatteryTestingOntology =
        Namespaced_IRI.parse _namespace_name "BatteryTestingOntology" |> NamespacedName

    /// <summary>
    /// The physical apparatus of the battery testing procedure. It is required in a battery measurement process.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationHardware"></see></summary>
    let BatteryCharacterizationHardware =
        Namespaced_IRI.parse _namespace_name "BatteryCharacterizationHardware" |> NamespacedName

    /// <summary>
    /// A characteristic or specification of a battery testing hardware
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationHardwareSpecification"></see></summary>
    let BatteryCharacterizationHardwareSpecification =
        Namespaced_IRI.parse _namespace_name "BatteryCharacterizationHardwareSpecification" |> NamespacedName

    /// <summary>
    /// The description of the overall characterization method for a battery. It is usually made up of different steps, or tasks (e.g. battery measurement process, battery sample preparation).
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryCharacterizationMethod"></see></summary>
    let BatteryCharacterizationMethod =
        Namespaced_IRI.parse _namespace_name "BatteryCharacterizationMethod" |> NamespacedName

    /// <summary>
    /// The measurement step in a battery characterization method. It involves at least a characterization hardware, a characterization environment, a battery sample to be measured, the configuration parameters, the level of accuracy and the location of the measurement. Its output is the trace data of the measurement.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryMeasurementProcess"></see></summary>
    let BatteryMeasurementProcess =
        Namespaced_IRI.parse _namespace_name "BatteryMeasurementProcess" |> NamespacedName

    /// <summary>
    /// The process of calibration of a battery characterization hardware with reference to a voltage source, which produces as output a reference voltage data.
    /// <see href="http://w3id.org/emmo-bto/bto#CalibrationForBatteryCharacterization"></see></summary>
    let CalibrationForBatteryCharacterization =
        Namespaced_IRI.parse _namespace_name "CalibrationForBatteryCharacterization" |> NamespacedName

    /// <summary>
    /// A step in the battery characterization method, related to the preparation of the battery sample to be tested. The battery sample, unprepared, is input to this step; the battery sample, prepared, is the output of this step. The holding device is a temporary participant of this step.
    /// <see href="http://w3id.org/emmo-bto/bto#BatterySamplePreparation"></see></summary>
    let BatterySamplePreparation =
        Namespaced_IRI.parse _namespace_name "BatterySamplePreparation" |> NamespacedName

    /// <summary>
    /// The type of chemistry in a battery sample. It is a property of the sample.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryChemistryType"></see></summary>
    let BatteryChemistryType =
        Namespaced_IRI.parse _namespace_name "BatteryChemistryType" |> NamespacedName

    /// <summary>
    /// A characteristic of a battery sample.
    /// <see href="http://w3id.org/emmo-bto/bto#BatterySampleProperty"></see></summary>
    let BatterySampleProperty =
        Namespaced_IRI.parse _namespace_name "BatterySampleProperty" |> NamespacedName

    /// <summary>
    /// A physical part of a battery.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryComponent"></see></summary>
    let BatteryComponent =
        Namespaced_IRI.parse _namespace_name "BatteryComponent" |> NamespacedName

    /// <summary>
    /// A physical part of the holding device.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryHolderComponent"></see></summary>
    let BatteryHolderComponent =
        Namespaced_IRI.parse _namespace_name "BatteryHolderComponent" |> NamespacedName

    /// <summary>
    /// The type of electrolyte in a battery sample. It is a property of the sample.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryElectrolyteType"></see></summary>
    let BatteryElectrolyteType =
        Namespaced_IRI.parse _namespace_name "BatteryElectrolyteType" |> NamespacedName

    /// <summary>
    /// The device that holds the battery in place for the testing procedure.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryHolder"></see></summary>
    let BatteryHolder =
        Namespaced_IRI.parse _namespace_name "BatteryHolder" |> NamespacedName

    /// <summary>
    /// The name of the manufacturer of a battery sample. It is a property of the sample.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryManufacturerName"></see></summary>
    let BatteryManufacturerName =
        Namespaced_IRI.parse _namespace_name "BatteryManufacturerName" |> NamespacedName

    /// <summary>
    /// A configuration parameter of a battery measurement step in the testing procedure.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryMeasurementParameter"></see></summary>
    let BatteryMeasurementParameter =
        Namespaced_IRI.parse _namespace_name "BatteryMeasurementParameter" |> NamespacedName

    /// <summary>
    /// A battery selected from a larger set to be used in a battery testing procedure.
    /// <see href="http://w3id.org/emmo-bto/bto#BatterySample"></see></summary>
    let BatterySample =
        Namespaced_IRI.parse _namespace_name "BatterySample" |> NamespacedName

    /// <summary>
    /// A parameter in the battery measurement step. It specifies the maximum voltage of the measurement.
    /// <see href="http://w3id.org/emmo-bto/bto#MaxVoltage"></see></summary>
    let MaxVoltage = Namespaced_IRI.parse _namespace_name "MaxVoltage" |> NamespacedName

    /// <summary>
    /// A specific type of trace data output from a battery measurement process, related to the current measured.
    /// <see href="http://w3id.org/emmo-bto/bto#CurrentData"></see></summary>
    let CurrentData =
        Namespaced_IRI.parse _namespace_name "CurrentData" |> NamespacedName

    /// <summary>
    /// A parameter in the battery measurement step. It specifies the end time of the measurement.
    /// <see href="http://w3id.org/emmo-bto/bto#EndTime"></see></summary>
    let EndTime = Namespaced_IRI.parse _namespace_name "EndTime" |> NamespacedName

    /// <summary>
    /// A parameter in the battery measurement step. It specifies the sampling time of the measurement.
    /// <see href="http://w3id.org/emmo-bto/bto#SamplingTime"></see></summary>
    let SamplingTime =
        Namespaced_IRI.parse _namespace_name "SamplingTime" |> NamespacedName

    /// <summary>
    /// A specific type of trace data output from a battery measurement process, related to the voltage measured.
    /// <see href="http://w3id.org/emmo-bto/bto#VoltageData"></see></summary>
    let VoltageData =
        Namespaced_IRI.parse _namespace_name "VoltageData" |> NamespacedName

    /// <summary>
    /// A specific type of trace data output from a battery measurement process, related to the time intervals of the measurement.
    /// <see href="http://w3id.org/emmo-bto/bto#TimeData"></see></summary>
    let TimeData = Namespaced_IRI.parse _namespace_name "TimeData" |> NamespacedName

    /// <summary>
    /// The part number, or code, of a battery sample. It is a property of the sample.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryPartNumber"></see></summary>
    let BatteryPartNumber =
        Namespaced_IRI.parse _namespace_name "BatteryPartNumber" |> NamespacedName

    /// <summary>
    /// The date reported as the one in which the battery sample has been produced. It is a property of the sample.
    /// <see href="http://w3id.org/emmo-bto/bto#BatteryProductionDate"></see></summary>
    let BatteryProductionDate =
        Namespaced_IRI.parse _namespace_name "BatteryProductionDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-bto/bto#PreparedBatterySample"></see>
    /// </summary>
    let PreparedBatterySample =
        Namespaced_IRI.parse _namespace_name "PreparedBatterySample" |> NamespacedName

    /// <summary>
    /// A battery sample to be prepared for testing. It is thus the input of the process of preparing a battery sample.
    /// <see href="http://w3id.org/emmo-bto/bto#RawBatterySample"></see></summary>
    let RawBatterySample =
        Namespaced_IRI.parse _namespace_name "RawBatterySample" |> NamespacedName

    /// <summary>
    /// A physical cable that connects a battery sample for the testing procedure.
    /// <see href="http://w3id.org/emmo-bto/bto#Cable"></see></summary>
    let Cable = Namespaced_IRI.parse _namespace_name "Cable" |> NamespacedName

    /// <summary>
    /// A voltage source used as a reference for the calibration of a battery characterization hardware.
    /// <see href="http://w3id.org/emmo-bto/bto#VoltageSource"></see></summary>
    let VoltageSource =
        Namespaced_IRI.parse _namespace_name "VoltageSource" |> NamespacedName

    /// <summary>
    /// The output of a battery measurement process in terms of raw data resulting from the measurement.
    /// <see href="http://w3id.org/emmo-bto/bto#TraceData"></see></summary>
    let TraceData = Namespaced_IRI.parse _namespace_name "TraceData" |> NamespacedName

    /// <summary>
    /// A specification of the battery characterization hardware, related to the current it can sustain.
    /// <see href="http://w3id.org/emmo-bto/bto#CurrentSpecification"></see></summary>
    let CurrentSpecification =
        Namespaced_IRI.parse _namespace_name "CurrentSpecification" |> NamespacedName

    /// <summary>
    /// A type of holding device for a battery sample. It may consist of a battery connector and a cable.
    /// <see href="http://w3id.org/emmo-bto/bto#Fixture"></see></summary>
    let Fixture = Namespaced_IRI.parse _namespace_name "Fixture" |> NamespacedName

    /// <summary>
    /// The name of the manufacturer of the hardware used for the measurement process.
    /// <see href="http://w3id.org/emmo-bto/bto#HardwareManufacturerName"></see></summary>
    let HardwareManufacturerName =
        Namespaced_IRI.parse _namespace_name "HardwareManufacturerName" |> NamespacedName

    /// <summary>
    /// The model of the hardware used for the measurement process.
    /// <see href="http://w3id.org/emmo-bto/bto#HardwareModel"></see></summary>
    let HardwareModel =
        Namespaced_IRI.parse _namespace_name "HardwareModel" |> NamespacedName

    /// <summary>
    /// The type of the hardware used for the measurement process.
    /// <see href="http://w3id.org/emmo-bto/bto#HardwareType"></see></summary>
    let HardwareType =
        Namespaced_IRI.parse _namespace_name "HardwareType" |> NamespacedName

    /// <summary>
    /// A specific type of cable.
    /// <see href="http://w3id.org/emmo-bto/bto#HipotCable"></see></summary>
    let HipotCable = Namespaced_IRI.parse _namespace_name "HipotCable" |> NamespacedName

    /// <summary>
    /// A battery sample that has been prepared for testing. It is thus the output of the process of preparing a battery sample.
    /// <see href="http://w3id.org/emmo-bto/bto#PreparedatterySample"></see></summary>
    let PreparedatterySample =
        Namespaced_IRI.parse _namespace_name "PreparedatterySample" |> NamespacedName

    /// <summary>
    /// A specification of the battery characterization hardware, related to the voltage it can provide.
    /// <see href="http://w3id.org/emmo-bto/bto#VoltageSpecification"></see></summary>
    let VoltageSpecification =
        Namespaced_IRI.parse _namespace_name "VoltageSpecification" |> NamespacedName

    /// <summary>
    /// This is the root datatype property of the BTO ontology, introduced for grouping all of BTO's datatype properties under a single parent datatype property.
    /// <see href="http://w3id.org/emmo-bto/bto#btoDatatypeProperty"></see></summary>
    let btoDatatypeProperty =
        Namespaced_IRI.parse _namespace_name "btoDatatypeProperty" |> NamespacedName

    /// <summary>
    /// This is the root object property of the BTO ontology, introduced for grouping all of BTO's object properties under a single parent object property.
    /// <see href="http://w3id.org/emmo-bto/bto#btoObjectProperty"></see></summary>
    let btoObjectProperty =
        Namespaced_IRI.parse _namespace_name "btoObjectProperty" |> NamespacedName

    /// <summary>
    /// Object property that connects a battery characterization hardware with its specifications. It is a super-property of more specific object properties.
    /// <see href="http://w3id.org/emmo-bto/bto#hasBatteryCharacterizationHardwareSpecification"></see></summary>
    let hasBatteryCharacterizationHardwareSpecification =
        Namespaced_IRI.parse _namespace_name "hasBatteryCharacterizationHardwareSpecification" |> NamespacedName

    /// <summary>
    /// Object property that connects a battery sample with its characteristics (BatterySampleProperties). It is the super-property of a number of more specific object properties.
    /// <see href="http://w3id.org/emmo-bto/bto#hasBatterySampleProperty"></see></summary>
    let hasBatterySampleProperty =
        Namespaced_IRI.parse _namespace_name "hasBatterySampleProperty" |> NamespacedName

    /// <summary>
    /// A specific object property that connects a battery sample with its cell form.
    /// <see href="http://w3id.org/emmo-bto/bto#hasCellForm"></see></summary>
    let hasCellForm =
        Namespaced_IRI.parse _namespace_name "hasCellForm" |> NamespacedName

    /// <summary>
    /// A specific object property that connects a battery sample with its chemistry type.
    /// <see href="http://w3id.org/emmo-bto/bto#hasChemistryType"></see></summary>
    let hasChemistryType =
        Namespaced_IRI.parse _namespace_name "hasChemistryType" |> NamespacedName

    /// <summary>
    /// A specific object property that connects a battery characterization hardware with its current specification.
    /// <see href="http://w3id.org/emmo-bto/bto#hasCurrentSpecification"></see></summary>
    let hasCurrentSpecification =
        Namespaced_IRI.parse _namespace_name "hasCurrentSpecification" |> NamespacedName

    /// <summary>
    /// A specific object property that connects a battery sample with its electrolyte type.
    /// <see href="http://w3id.org/emmo-bto/bto#hasElectrolyteType"></see></summary>
    let hasElectrolyteType =
        Namespaced_IRI.parse _namespace_name "hasElectrolyteType" |> NamespacedName

    /// <summary>
    /// A specific object property that connects a battery characterization hardware with its hardware model.
    /// <see href="http://w3id.org/emmo-bto/bto#hasHardwareModel"></see></summary>
    let hasHardwareModel =
        Namespaced_IRI.parse _namespace_name "hasHardwareModel" |> NamespacedName

    /// <summary>
    /// A specific object property that connects a battery characterization hardware with its hardware type.
    /// <see href="http://w3id.org/emmo-bto/bto#hasHardwareType"></see></summary>
    let hasHardwareType =
        Namespaced_IRI.parse _namespace_name "hasHardwareType" |> NamespacedName

    /// <summary>
    /// A specific object property that connects either a battery sample or its characterization hardware with its manufacturer.
    /// <see href="http://w3id.org/emmo-bto/bto#hasManufacturer"></see></summary>
    let hasManufacturer =
        Namespaced_IRI.parse _namespace_name "hasManufacturer" |> NamespacedName

    /// <summary>
    /// A specific object property that connects a battery sample with its part number.
    /// <see href="http://w3id.org/emmo-bto/bto#hasPartNumber"></see></summary>
    let hasPartNumber =
        Namespaced_IRI.parse _namespace_name "hasPartNumber" |> NamespacedName

    /// <summary>
    /// A specific datatype property that specifies a production date for a battery sample.
    /// <see href="http://w3id.org/emmo-bto/bto#hasProductionDate"></see></summary>
    let hasProductionDate =
        Namespaced_IRI.parse _namespace_name "hasProductionDate" |> NamespacedName

    /// <summary>
    /// A specific object property that connects a battery characterization hardware with its voltage specification.
    /// <see href="http://w3id.org/emmo-bto/bto#hasVoltageSpecification"></see></summary>
    let hasVoltageSpecification =
        Namespaced_IRI.parse _namespace_name "hasVoltageSpecification" |> NamespacedName
