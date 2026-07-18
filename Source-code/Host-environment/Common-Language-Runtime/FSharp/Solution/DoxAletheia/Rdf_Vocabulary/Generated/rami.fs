namespace http.iais.fraunhofer.de.vocabs.rami.hash

open DoxAletheia.Rdf_Vocabulary

module rami =
    let _namespace_name = "http://iais.fraunhofer.de/vocabs/rami#"
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#AdminShell"></see>
    /// </summary>
    let AdminShell = Namespaced_IRI.parse _namespace_name "AdminShell" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#ApplicationData"></see>
    /// </summary>
    let ApplicationData =
        Namespaced_IRI.parse _namespace_name "ApplicationData" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#BasicData"></see>
    /// </summary>
    let BasicData = Namespaced_IRI.parse _namespace_name "BasicData" |> NamespacedName
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#CADFormat"></see>
    /// </summary>
    let CADFormat = Namespaced_IRI.parse _namespace_name "CADFormat" |> NamespacedName
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#MCAD"></see>
    /// </summary>
    let MCAD = Namespaced_IRI.parse _namespace_name "MCAD" |> NamespacedName
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#CADSystem"></see>
    /// </summary>
    let CADSystem = Namespaced_IRI.parse _namespace_name "CADSystem" |> NamespacedName
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#CADarchive"></see>
    /// </summary>
    let CADarchive = Namespaced_IRI.parse _namespace_name "CADarchive" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#ConnectedWorld"></see>
    /// </summary>
    let ConnectedWorld =
        Namespaced_IRI.parse _namespace_name "ConnectedWorld" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#RAMIHierarchyLevel"></see>
    /// </summary>
    let RAMIHierarchyLevel =
        Namespaced_IRI.parse _namespace_name "RAMIHierarchyLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#ControlDevice"></see>
    /// </summary>
    let ControlDevice =
        Namespaced_IRI.parse _namespace_name "ControlDevice" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#CumulativeEnergyConsumption"></see>
    /// </summary>
    let CumulativeEnergyConsumption =
        Namespaced_IRI.parse _namespace_name "CumulativeEnergyConsumption" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#ElectricalData"></see>
    /// </summary>
    let ElectricalData =
        Namespaced_IRI.parse _namespace_name "ElectricalData" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#EngineeringData"></see>
    /// </summary>
    let EngineeringData =
        Namespaced_IRI.parse _namespace_name "EngineeringData" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#Enterprise"></see>
    /// </summary>
    let Enterprise = Namespaced_IRI.parse _namespace_name "Enterprise" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#FieldDevice"></see>
    /// </summary>
    let FieldDevice =
        Namespaced_IRI.parse _namespace_name "FieldDevice" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#Firmware"></see>
    /// </summary>
    let Firmware = Namespaced_IRI.parse _namespace_name "Firmware" |> NamespacedName
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#Instance"></see>
    /// </summary>
    let Instance = Namespaced_IRI.parse _namespace_name "Instance" |> NamespacedName
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#Machine"></see>
    /// </summary>
    let Machine = Namespaced_IRI.parse _namespace_name "Machine" |> NamespacedName
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#Object"></see>
    /// </summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#Type"></see>
    /// </summary>
    let Type = Namespaced_IRI.parse _namespace_name "Type" |> NamespacedName
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#Order"></see>
    /// </summary>
    let Order = Namespaced_IRI.parse _namespace_name "Order" |> NamespacedName
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#Product"></see>
    /// </summary>
    let Product = Namespaced_IRI.parse _namespace_name "Product" |> NamespacedName
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#Station"></see>
    /// </summary>
    let Station = Namespaced_IRI.parse _namespace_name "Station" |> NamespacedName
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#WorkCenter"></see>
    /// </summary>
    let WorkCenter = Namespaced_IRI.parse _namespace_name "WorkCenter" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#SafetyConfiguration"></see>
    /// </summary>
    let SafetyConfiguration =
        Namespaced_IRI.parse _namespace_name "SafetyConfiguration" |> NamespacedName

    /// <summary>
    /// Data measured by a sensor
    /// <see href="http://iais.fraunhofer.de/vocabs/rami#SensorMeasurementData"></see></summary>
    let SensorMeasurementData =
        Namespaced_IRI.parse _namespace_name "SensorMeasurementData" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#Standard"></see>
    /// </summary>
    let Standard = Namespaced_IRI.parse _namespace_name "Standard" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#TechnicalFunctionality"></see>
    /// </summary>
    let TechnicalFunctionality =
        Namespaced_IRI.parse _namespace_name "TechnicalFunctionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#TraceRecordings"></see>
    /// </summary>
    let TraceRecordings =
        Namespaced_IRI.parse _namespace_name "TraceRecordings" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#VideoRecording"></see>
    /// </summary>
    let VideoRecording =
        Namespaced_IRI.parse _namespace_name "VideoRecording" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#VideoRecordings"></see>
    /// </summary>
    let VideoRecordings =
        Namespaced_IRI.parse _namespace_name "VideoRecordings" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#blockUrl"></see>
    /// </summary>
    let blockUrl = Namespaced_IRI.parse _namespace_name "blockUrl" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#brakingResistance"></see>
    /// </summary>
    let brakingResistance =
        Namespaced_IRI.parse _namespace_name "brakingResistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#certificateName"></see>
    /// </summary>
    let certificateName =
        Namespaced_IRI.parse _namespace_name "certificateName" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#certificateUrl"></see>
    /// </summary>
    let certificateUrl =
        Namespaced_IRI.parse _namespace_name "certificateUrl" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#contributes"></see>
    /// </summary>
    let contributes =
        Namespaced_IRI.parse _namespace_name "contributes" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#contributionDate"></see>
    /// </summary>
    let contributionDate =
        Namespaced_IRI.parse _namespace_name "contributionDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#createdBy"></see>
    /// </summary>
    let createdBy = Namespaced_IRI.parse _namespace_name "createdBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#creationDate"></see>
    /// </summary>
    let creationDate =
        Namespaced_IRI.parse _namespace_name "creationDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#description"></see>
    /// </summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#eClass"></see>
    /// </summary>
    let eClass = Namespaced_IRI.parse _namespace_name "eClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#eClassClassification"></see>
    /// </summary>
    let eClassClassification =
        Namespaced_IRI.parse _namespace_name "eClassClassification" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#eClassIRDI"></see>
    /// </summary>
    let eClassIRDI = Namespaced_IRI.parse _namespace_name "eClassIRDI" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#firmwareDate"></see>
    /// </summary>
    let firmwareDate =
        Namespaced_IRI.parse _namespace_name "firmwareDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#hasData"></see>
    /// </summary>
    let hasData = Namespaced_IRI.parse _namespace_name "hasData" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#hasEnergyValue"></see>
    /// </summary>
    let hasEnergyValue =
        Namespaced_IRI.parse _namespace_name "hasEnergyValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#hasRAMIHierarchyLevel"></see>
    /// </summary>
    let hasRAMIHierarchyLevel =
        Namespaced_IRI.parse _namespace_name "hasRAMIHierarchyLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#hasSensorId"></see>
    /// </summary>
    let hasSensorId =
        Namespaced_IRI.parse _namespace_name "hasSensorId" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#hasTechnicalFuncionality"></see>
    /// </summary>
    let hasTechnicalFuncionality =
        Namespaced_IRI.parse _namespace_name "hasTechnicalFuncionality" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#identification"></see>
    /// </summary>
    let identification =
        Namespaced_IRI.parse _namespace_name "identification" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#inputVoltage"></see>
    /// </summary>
    let inputVoltage =
        Namespaced_IRI.parse _namespace_name "inputVoltage" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#inventoryNumber"></see>
    /// </summary>
    let inventoryNumber =
        Namespaced_IRI.parse _namespace_name "inventoryNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#isDescribedWith"></see>
    /// </summary>
    let isDescribedWith =
        Namespaced_IRI.parse _namespace_name "isDescribedWith" |> NamespacedName

    /// <summary>
    /// The Object can be part of of other Objects
    /// <see href="http://iais.fraunhofer.de/vocabs/rami#isPartOf"></see></summary>
    let isPartOf = Namespaced_IRI.parse _namespace_name "isPartOf" |> NamespacedName

    /// <summary>
    /// Points to an Image for the Object/Entity
    /// <see href="http://iais.fraunhofer.de/vocabs/rami#livePicture"></see></summary>
    let livePicture =
        Namespaced_IRI.parse _namespace_name "livePicture" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#logs"></see>
    /// </summary>
    let logs = Namespaced_IRI.parse _namespace_name "logs" |> NamespacedName
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#manual"></see>
    /// </summary>
    let manual = Namespaced_IRI.parse _namespace_name "manual" |> NamespacedName
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#objectId"></see>
    /// </summary>
    let objectId = Namespaced_IRI.parse _namespace_name "objectId" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#outputFrequency"></see>
    /// </summary>
    let outputFrequency =
        Namespaced_IRI.parse _namespace_name "outputFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#phasesNumber"></see>
    /// </summary>
    let phasesNumber =
        Namespaced_IRI.parse _namespace_name "phasesNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#publishedURL"></see>
    /// </summary>
    let publishedURL =
        Namespaced_IRI.parse _namespace_name "publishedURL" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#releaseDate"></see>
    /// </summary>
    let releaseDate =
        Namespaced_IRI.parse _namespace_name "releaseDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#safetyName"></see>
    /// </summary>
    let safetyName = Namespaced_IRI.parse _namespace_name "safetyName" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#standardName"></see>
    /// </summary>
    let standardName =
        Namespaced_IRI.parse _namespace_name "standardName" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#standardURL"></see>
    /// </summary>
    let standardURL =
        Namespaced_IRI.parse _namespace_name "standardURL" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#standardVersion"></see>
    /// </summary>
    let standardVersion =
        Namespaced_IRI.parse _namespace_name "standardVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#stdName"></see>
    /// </summary>
    let stdName = Namespaced_IRI.parse _namespace_name "stdName" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#typeDescription"></see>
    /// </summary>
    let typeDescription =
        Namespaced_IRI.parse _namespace_name "typeDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#version"></see>
    /// </summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#videoRecordingUrl"></see>
    /// </summary>
    let videoRecordingUrl =
        Namespaced_IRI.parse _namespace_name "videoRecordingUrl" |> NamespacedName

    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#videoUrl"></see>
    /// </summary>
    let videoUrl = Namespaced_IRI.parse _namespace_name "videoUrl" |> NamespacedName
    /// <summary>
    ///   <see href="http://iais.fraunhofer.de/vocabs/rami#wraps"></see>
    /// </summary>
    let wraps = Namespaced_IRI.parse _namespace_name "wraps" |> NamespacedName
