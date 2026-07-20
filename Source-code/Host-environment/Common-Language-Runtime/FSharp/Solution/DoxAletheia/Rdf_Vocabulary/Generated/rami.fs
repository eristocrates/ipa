namespace http.iais.fraunhofer.de.vocabs.rami.hash

open DoxAletheia

module rami =
    let _namespace_name = "http://iais.fraunhofer.de/vocabs/rami#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#AdminShell"></see>
    /// </summary>
    let AdminShell = _prefix "AdminShell"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#ApplicationData"></see>
    /// </summary>
    let ApplicationData = _prefix "ApplicationData"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#BasicData"></see>
    /// </summary>
    let BasicData = _prefix "BasicData"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#CADFormat"></see>
    /// </summary>
    let CADFormat = _prefix "CADFormat"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#MCAD"></see>
    /// </summary>
    let MCAD = _prefix "MCAD"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#CADSystem"></see>
    /// </summary>
    let CADSystem = _prefix "CADSystem"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#CADarchive"></see>
    /// </summary>
    let CADarchive = _prefix "CADarchive"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#ConnectedWorld"></see>
    /// </summary>
    let ConnectedWorld = _prefix "ConnectedWorld"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#RAMIHierarchyLevel"></see>
    /// </summary>
    let RAMIHierarchyLevel = _prefix "RAMIHierarchyLevel"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#ControlDevice"></see>
    /// </summary>
    let ControlDevice = _prefix "ControlDevice"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#CumulativeEnergyConsumption"></see>
    /// </summary>
    let CumulativeEnergyConsumption = _prefix "CumulativeEnergyConsumption"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#ElectricalData"></see>
    /// </summary>
    let ElectricalData = _prefix "ElectricalData"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#EngineeringData"></see>
    /// </summary>
    let EngineeringData = _prefix "EngineeringData"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#Enterprise"></see>
    /// </summary>
    let Enterprise = _prefix "Enterprise"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#FieldDevice"></see>
    /// </summary>
    let FieldDevice = _prefix "FieldDevice"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#Firmware"></see>
    /// </summary>
    let Firmware = _prefix "Firmware"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#Instance"></see>
    /// </summary>
    let Instance = _prefix "Instance"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#Machine"></see>
    /// </summary>
    let Machine = _prefix "Machine"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#Object"></see>
    /// </summary>
    let Object = _prefix "Object"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#Type"></see>
    /// </summary>
    let Type = _prefix "Type"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#Order"></see>
    /// </summary>
    let Order = _prefix "Order"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#Product"></see>
    /// </summary>
    let Product = _prefix "Product"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#Station"></see>
    /// </summary>
    let Station = _prefix "Station"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#WorkCenter"></see>
    /// </summary>
    let WorkCenter = _prefix "WorkCenter"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#SafetyConfiguration"></see>
    /// </summary>
    let SafetyConfiguration = _prefix "SafetyConfiguration"
    /// <summary>
    /// Data measured by a sensor
    /// <see href="http://iais.fraunhofer.de/vocabs/rami#SensorMeasurementData"></see></summary>
    let SensorMeasurementData = _prefix "SensorMeasurementData"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#Standard"></see>
    /// </summary>
    let Standard = _prefix "Standard"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#TechnicalFunctionality"></see>
    /// </summary>
    let TechnicalFunctionality = _prefix "TechnicalFunctionality"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#TraceRecordings"></see>
    /// </summary>
    let TraceRecordings = _prefix "TraceRecordings"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#VideoRecording"></see>
    /// </summary>
    let VideoRecording = _prefix "VideoRecording"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#VideoRecordings"></see>
    /// </summary>
    let VideoRecordings = _prefix "VideoRecordings"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#blockUrl"></see>
    /// </summary>
    let blockUrl = _prefix "blockUrl"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#brakingResistance"></see>
    /// </summary>
    let brakingResistance = _prefix "brakingResistance"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#certificateName"></see>
    /// </summary>
    let certificateName = _prefix "certificateName"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#certificateUrl"></see>
    /// </summary>
    let certificateUrl = _prefix "certificateUrl"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#contributes"></see>
    /// </summary>
    let contributes = _prefix "contributes"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#contributionDate"></see>
    /// </summary>
    let contributionDate = _prefix "contributionDate"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#createdBy"></see>
    /// </summary>
    let createdBy = _prefix "createdBy"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#creationDate"></see>
    /// </summary>
    let creationDate = _prefix "creationDate"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#description"></see>
    /// </summary>
    let description = _prefix "description"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#eClass"></see>
    /// </summary>
    let eClass = _prefix "eClass"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#eClassClassification"></see>
    /// </summary>
    let eClassClassification = _prefix "eClassClassification"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#eClassIRDI"></see>
    /// </summary>
    let eClassIRDI = _prefix "eClassIRDI"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#firmwareDate"></see>
    /// </summary>
    let firmwareDate = _prefix "firmwareDate"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#hasData"></see>
    /// </summary>
    let hasData = _prefix "hasData"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#hasEnergyValue"></see>
    /// </summary>
    let hasEnergyValue = _prefix "hasEnergyValue"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#hasRAMIHierarchyLevel"></see>
    /// </summary>
    let hasRAMIHierarchyLevel = _prefix "hasRAMIHierarchyLevel"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#hasSensorId"></see>
    /// </summary>
    let hasSensorId = _prefix "hasSensorId"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#hasTechnicalFuncionality"></see>
    /// </summary>
    let hasTechnicalFuncionality = _prefix "hasTechnicalFuncionality"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#identification"></see>
    /// </summary>
    let identification = _prefix "identification"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#inputVoltage"></see>
    /// </summary>
    let inputVoltage = _prefix "inputVoltage"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#inventoryNumber"></see>
    /// </summary>
    let inventoryNumber = _prefix "inventoryNumber"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#isDescribedWith"></see>
    /// </summary>
    let isDescribedWith = _prefix "isDescribedWith"
    /// <summary>
    /// The Object can be part of of other Objects
    /// <see href="http://iais.fraunhofer.de/vocabs/rami#isPartOf"></see></summary>
    let isPartOf = _prefix "isPartOf"
    /// <summary>
    /// Points to an Image for the Object/Entity
    /// <see href="http://iais.fraunhofer.de/vocabs/rami#livePicture"></see></summary>
    let livePicture = _prefix "livePicture"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#logs"></see>
    /// </summary>
    let logs = _prefix "logs"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#manual"></see>
    /// </summary>
    let manual = _prefix "manual"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#objectId"></see>
    /// </summary>
    let objectId = _prefix "objectId"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#outputFrequency"></see>
    /// </summary>
    let outputFrequency = _prefix "outputFrequency"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#phasesNumber"></see>
    /// </summary>
    let phasesNumber = _prefix "phasesNumber"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#publishedURL"></see>
    /// </summary>
    let publishedURL = _prefix "publishedURL"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#releaseDate"></see>
    /// </summary>
    let releaseDate = _prefix "releaseDate"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#safetyName"></see>
    /// </summary>
    let safetyName = _prefix "safetyName"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#standardName"></see>
    /// </summary>
    let standardName = _prefix "standardName"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#standardURL"></see>
    /// </summary>
    let standardURL = _prefix "standardURL"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#standardVersion"></see>
    /// </summary>
    let standardVersion = _prefix "standardVersion"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#stdName"></see>
    /// </summary>
    let stdName = _prefix "stdName"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#typeDescription"></see>
    /// </summary>
    let typeDescription = _prefix "typeDescription"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#version"></see>
    /// </summary>
    let version = _prefix "version"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#videoRecordingUrl"></see>
    /// </summary>
    let videoRecordingUrl = _prefix "videoRecordingUrl"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#videoUrl"></see>
    /// </summary>
    let videoUrl = _prefix "videoUrl"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#wraps"></see>
    /// </summary>
    let wraps = _prefix "wraps"
