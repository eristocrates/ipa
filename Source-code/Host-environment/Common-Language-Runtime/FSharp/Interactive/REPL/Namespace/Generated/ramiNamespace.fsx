#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rami =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://iais.fraunhofer.de/vocabs/rami#" "rami"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:prefLabel : Admin Shellskos:prefLabel : Verwaltungsschale</para>
    ///   <para>skos:hiddenLabel : Administrative Shell</para>
    ///   <para>skos:definition : Describe the Administration Shell for Products, Components, e.g. Machines</para>
    ///   <para>skos:altLabel : Administration Shell</para>
    ///   <para>dce:source : This definition comprises material from RAMI4.0.</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#AdminShell">rami:AdminShell</a>
    /// </summary>
    let AdminShell = _prefixId.prefix "AdminShell"
    /// <summary>
    ///   <para>skos:prefLabel : Anwendungsdatenskos:prefLabel : Application Data</para>
    ///   <para>skos:definition : Hier bestimmt der Gegenstand das Formatskos:definition : The object determines the format</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#ApplicationData">rami:ApplicationData</a>
    /// </summary>
    let ApplicationData = _prefixId.prefix "ApplicationData"
    /// <summary>
    ///   <para>skos:prefLabel : Dataskos:prefLabel : Daten</para>
    ///   <para>skos:definition : Describe the different types of Data related to the I4.0 Entity/Object</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#BasicData">rami:BasicData</a>
    /// </summary>
    let BasicData = _prefixId.prefix "BasicData"
    /// <summary>
    ///   <para>skos:prefLabel : CAD Format</para>
    ///   <para>skos:definition : Different types of format files for CAD Archive of the Object/Entity</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#CADFormat">rami:CADFormat</a>
    /// </summary>
    let CADFormat = _prefixId.prefix "CADFormat"
    /// <summary>
    ///   <para>skos:prefLabel : CAD Format</para>
    ///   <para>skos:example : Neutral 2D, Neutral 3D, SolidWorks^^xsd:string</para>
    ///   <para>skos:definition : Points to the different types of CAD systems of the Object/Entity</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#CADSystem">rami:CADSystem</a>
    /// </summary>
    let CADSystem = _prefixId.prefix "CADSystem"
    /// <summary>
    ///   <para>skos:prefLabel : CAD Archive</para>
    ///   <para>skos:definition : Link(URL) to the CAD Archive of the Object/Entity</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#CADarchive">rami:CADarchive</a>
    /// </summary>
    let CADarchive = _prefixId.prefix "CADarchive"
    let ConnectedWorld = _prefixId.prefix "ConnectedWorld"
    let ControlDevice = _prefixId.prefix "ControlDevice"
    let CumulativeEnergyConsumption = _prefixId.prefix "CumulativeEnergyConsumption"
    /// <summary>
    ///   <para>skos:prefLabel : Electrical Data</para>
    ///   <para>skos:definition : Electrical Data for the Object</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#ElectricalData">rami:ElectricalData</a>
    /// </summary>
    let ElectricalData = _prefixId.prefix "ElectricalData"
    /// <summary>
    ///   <para>skos:prefLabel : Engineering Dataskos:prefLabel : Engineering-Daten</para>
    ///   <para>skos:definition : Documents such as drawings, manufacturer's specifications, standards, and other information relating to design, procurement, fabrication, test, and inspection of an item or structure.</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#EngineeringData">rami:EngineeringData</a>
    /// </summary>
    let EngineeringData = _prefixId.prefix "EngineeringData"
    let Enterprise = _prefixId.prefix "Enterprise"
    let FieldDevice = _prefixId.prefix "FieldDevice"
    /// <summary>
    ///   <para>skos:prefLabel : Firmwareskos:prefLabel : Firmware</para>
    ///   <para>skos:definition : Eingesetzte Firmware, Firmware-Moduleskos:definition : Used firmware, firmware modules</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#Firmware">rami:Firmware</a>
    /// </summary>
    let Firmware = _prefixId.prefix "Firmware"
    let Instance = _prefixId.prefix "Instance"
    /// <summary>
    ///   <para>skos:prefLabel : MCADskos:prefLabel : MCAD</para>
    ///   <para>skos:definition : Data that contain the files used for Mechanical Computer Aid Design of a given object</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#MCAD">rami:MCAD</a>
    /// </summary>
    let MCAD = _prefixId.prefix "MCAD"
    /// <summary>
    ///   <para>skos:prefLabel : Machine</para>
    ///   <para>skos:definition : A machine is ordered, designed, commissioned, operated, serviced, converted and recycled.</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#Machine">rami:Machine</a>
    /// </summary>
    let Machine = _prefixId.prefix "Machine"
    /// <summary>
    ///   <para>skos:prefLabel : Objectskos:prefLabel : Objekt</para>
    ///   <para>skos:note : Objects may be known in the form of a type or of an instance. An object in the planning phase is known as a type</para>
    ///   <para>skos:definition : Clearly identifiable object which is managed due to its importance in the world of informationskos:definition : Eindeutig identifizierbarer Gegenstand, der aufgrund seiner Bedeutung in der Informationswelt verwaltet wird</para>
    ///   <para>skos:altLabel : Entityskos:altLabel : Entität</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#Object">rami:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>skos:prefLabel : Order</para>
    ///   <para>skos:definition : Each order for manufacturing runs through a life cycle and its specifics necessarily have an impact on the production facility during performance of the order</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#Order">rami:Order</a>
    /// </summary>
    let Order = _prefixId.prefix "Order"
    let Product = _prefixId.prefix "Product"
    /// <summary>
    ///   <para>skos:prefLabel : RAMI Hierarchy Level</para>
    ///   <para>skos:definition : It describes the functional classification of various circumstances within Industrie 4.0. For classification within a factory, this axis of the reference architecture(layers) follows the IEC 62264 Standard.</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#RAMIHierarchyLevel">rami:RAMIHierarchyLevel</a>
    /// </summary>
    let RAMIHierarchyLevel = _prefixId.prefix "RAMIHierarchyLevel"
    /// <summary>
    ///   <para>skos:prefLabel : SafetyConfiguration</para>
    ///   <para>skos:definition : Safety Configuration of the Object/Entity. It contains certificate of compliance that states that the object has fullfils the safety requirements according to a given standard</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#SafetyConfiguration">rami:SafetyConfiguration</a>
    /// </summary>
    let SafetyConfiguration = _prefixId.prefix "SafetyConfiguration"
    /// <summary>
    ///   <para>rdfs:label : Sensor Data</para>
    ///   <para>rdfs:comment : Data measured by a sensor</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#SensorMeasurementData">rami:SensorMeasurementData</a>
    /// </summary>
    let SensorMeasurementData = _prefixId.prefix "SensorMeasurementData"
    /// <summary>
    ///   <para>skos:prefLabel : Standardskos:prefLabel : Standard</para>
    ///   <para>skos:definition : Standards that are used to describe the actual I4.0 Entity/Object</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#Standard">rami:Standard</a>
    /// </summary>
    let Standard = _prefixId.prefix "Standard"
    let Station = _prefixId.prefix "Station"
    /// <summary>
    ///   <para>skos:prefLabel : Fachliche Funktionalitätskos:prefLabel : Technical Functionality</para>
    ///   <para>skos:note : Technical functionality takes place in the Functional Layer of the reference architecture model RAMI4.0</para>
    ///   <para>skos:definition : Technical Functionality of the Administration Shell</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#TechnicalFunctionality">rami:TechnicalFunctionality</a>
    /// </summary>
    let TechnicalFunctionality = _prefixId.prefix "TechnicalFunctionality"
    let TraceRecordings = _prefixId.prefix "TraceRecordings"
    let Type = _prefixId.prefix "Type"
    let VideoRecording = _prefixId.prefix "VideoRecording"
    let VideoRecordings = _prefixId.prefix "VideoRecordings"
    let WorkCenter = _prefixId.prefix "WorkCenter"
    /// <summary>
    ///   <para>skos:prefLabel : Block Url</para>
    ///   <para>skos:definition : URL of the Firmware that belongs to the Object/Entity</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#blockUrl">rami:blockUrl</a>
    /// </summary>
    let blockUrl = _prefixId.prefix "blockUrl"
    /// <summary>
    ///   <para>skos:prefLabel : braking Resistance</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#brakingResistance">rami:brakingResistance</a>
    /// </summary>
    let brakingResistance = _prefixId.prefix "brakingResistance"
    /// <summary>
    ///   <para>skos:prefLabel : Certificate Name</para>
    ///   <para>skos:definition : Certificate Safety Name of the Object/Entity</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#certificateName">rami:certificateName</a>
    /// </summary>
    let certificateName = _prefixId.prefix "certificateName"
    /// <summary>
    ///   <para>skos:prefLabel : Certificate Url</para>
    ///   <para>skos:definition : Certificate Safety Url of the Object/Entity</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#certificateUrl">rami:certificateUrl</a>
    /// </summary>
    let certificateUrl = _prefixId.prefix "certificateUrl"
    /// <summary>
    ///   <para>skos:prefLabel : typeDescription</para>
    ///   <para>skos:definition : Agent(Person or Software) that contributes to the Entity/Object related data. It correspond to the Contributor concept of OMM</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#contributes">rami:contributes</a>
    /// </summary>
    let contributes = _prefixId.prefix "contributes"
    /// <summary>
    ///   <para>skos:prefLabel : hasCreator</para>
    ///   <para>skos:definition : Date when an Agent(Person or Software) contributes to the Entity/Object related data. It correspond to the Contributor concept of OMM</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#contributionDate">rami:contributionDate</a>
    /// </summary>
    let contributionDate = _prefixId.prefix "contributionDate"
    /// <summary>
    ///   <para>skos:prefLabel : hasCreator</para>
    ///   <para>skos:definition : Agent(Person or Software) that creates to the Entity/Object related data. It correspond to the Creator concept of OMM</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#createdBy">rami:createdBy</a>
    /// </summary>
    let createdBy = _prefixId.prefix "createdBy"
    /// <summary>
    ///   <para>skos:prefLabel : hasCreator</para>
    ///   <para>skos:definition : Date when an Agent(Person or Software) creates to the Entity/Object related data. It correspond to the Creator concept of OMM</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#creationDate">rami:creationDate</a>
    /// </summary>
    let creationDate = _prefixId.prefix "creationDate"
    /// <summary>
    ///   <para>skos:prefLabel : has Description</para>
    ///   <para>skos:definition : Description of the Object/Entity</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#description">rami:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>skos:prefLabel : eClassskos:prefLabel : eClass</para>
    ///   <para>skos:definition : Class to represent the connection of an I4.0 Entity/Object with the eCl@ss Standard</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#eClass">rami:eClass</a>
    /// </summary>
    let eClass = _prefixId.prefix "eClass"
    /// <summary>
    ///   <para>skos:prefLabel : eClassIRDI</para>
    ///   <para>skos:definition : Identification of an object according to the eCl@ss Standard hierarchy level</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#eClassClassification">rami:eClassClassification</a>
    /// </summary>
    let eClassClassification = _prefixId.prefix "eClassClassification"
    /// <summary>
    ///   <para>skos:prefLabel : eClassIRDI</para>
    ///   <para>skos:definition : Unique Identification of an object according to eCl@ss Standard</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#eClassIRDI">rami:eClassIRDI</a>
    /// </summary>
    let eClassIRDI = _prefixId.prefix "eClassIRDI"
    /// <summary>
    ///   <para>skos:prefLabel : firmware Date</para>
    ///   <para>skos:definition : Firmware date that belongs to the Object/Entity</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#firmwareDate">rami:firmwareDate</a>
    /// </summary>
    let firmwareDate = _prefixId.prefix "firmwareDate"
    /// <summary>
    ///   <para>skos:prefLabel : has Data</para>
    ///   <para>skos:definition : Connects the AdminShell with the different types of Data for the Object/Entity</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#hasData">rami:hasData</a>
    /// </summary>
    let hasData = _prefixId.prefix "hasData"
    /// <summary>
    ///   <para>skos:prefLabel : hasEnergyValue</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#hasEnergyValue">rami:hasEnergyValue</a>
    /// </summary>
    let hasEnergyValue = _prefixId.prefix "hasEnergyValue"
    /// <summary>
    ///   <para>skos:prefLabel : has RAMI Hierarchy Level^^xsd:string</para>
    ///   <para>skos:definition : Connects the concepts with the correspondent layer in the RAMI Hierarchy Levels</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#hasRAMIHierarchyLevel">rami:hasRAMIHierarchyLevel</a>
    /// </summary>
    let hasRAMIHierarchyLevel = _prefixId.prefix "hasRAMIHierarchyLevel"
    /// <summary>
    ///   <para>skos:prefLabel : hasSensorId</para>
    ///   <para>skos:definition : Unique Identification of the Sensor</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#hasSensorId">rami:hasSensorId</a>
    /// </summary>
    let hasSensorId = _prefixId.prefix "hasSensorId"
    /// <summary>
    ///   <para>skos:prefLabel : has Technical Funcionality</para>
    ///   <para>skos:definition : The Administrative Shell has Technical Funcionalities</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#hasTechnicalFuncionality">rami:hasTechnicalFuncionality</a>
    /// </summary>
    let hasTechnicalFuncionality = _prefixId.prefix "hasTechnicalFuncionality"
    /// <summary>
    ///   <para>skos:prefLabel : Identification</para>
    ///   <para>skos:definition : Identification for the Entity/Object related data. It correspond to the ID concept of OMM</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#identification">rami:identification</a>
    /// </summary>
    let identification = _prefixId.prefix "identification"
    /// <summary>
    ///   <para>skos:prefLabel : Input Voltage</para>
    ///   <para>skos:example : 230 V AC / 50-60 Hz^^xsd:string</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#inputVoltage">rami:inputVoltage</a>
    /// </summary>
    let inputVoltage = _prefixId.prefix "inputVoltage"
    /// <summary>
    ///   <para>skos:prefLabel : Inventory Number</para>
    ///   <para>skos:definition : Inventory number of the Entity/Object according to the identification nomenclature</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#inventoryNumber">rami:inventoryNumber</a>
    /// </summary>
    let inventoryNumber = _prefixId.prefix "inventoryNumber"
    /// <summary>
    ///   <para>skos:prefLabel : Is Described With</para>
    ///   <para>skos:definition : Points to the Standard used to describe a given object</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#isDescribedWith">rami:isDescribedWith</a>
    /// </summary>
    let isDescribedWith = _prefixId.prefix "isDescribedWith"
    /// <summary>
    ///   <para>rdfs:label : isPartOf</para>
    ///   <para>rdfs:comment : The Object can be part of of other Objects</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#isPartOf">rami:isPartOf</a>
    /// </summary>
    let isPartOf = _prefixId.prefix "isPartOf"
    /// <summary>
    ///   <para>rdfs:label : LivePicturerdfs:label : Livebilder</para>
    ///   <para>rdfs:comment : Points to an Image for the Object/Entity</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#livePicture">rami:livePicture</a>
    /// </summary>
    let livePicture = _prefixId.prefix "livePicture"
    /// <summary>
    ///   <para>skos:prefLabel : logs</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#logs">rami:logs</a>
    /// </summary>
    let logs = _prefixId.prefix "logs"
    /// <summary>
    ///   <para>skos:prefLabel : Manual</para>
    ///   <para>skos:definition : Points to the Manual document of a given Object/Entity</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#manual">rami:manual</a>
    /// </summary>
    let manual = _prefixId.prefix "manual"
    /// <summary>
    ///   <para>skos:prefLabel : has Name</para>
    ///   <para>skos:definition : Name of the Object/Entity</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#name">rami:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>skos:prefLabel : has Object Id</para>
    ///   <para>skos:definition : Unique ID for the Object/Entity</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#objectId">rami:objectId</a>
    /// </summary>
    let objectId = _prefixId.prefix "objectId"
    /// <summary>
    ///   <para>skos:prefLabel : Output Frequency</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#outputFrequency">rami:outputFrequency</a>
    /// </summary>
    let outputFrequency = _prefixId.prefix "outputFrequency"
    /// <summary>
    ///   <para>skos:prefLabel : Phases Number</para>
    ///   <para>skos:example : Single phase, three phase^^xsd:string</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#phasesNumber">rami:phasesNumber</a>
    /// </summary>
    let phasesNumber = _prefixId.prefix "phasesNumber"
    /// <summary>
    ///   <para>skos:prefLabel : Published URL</para>
    ///   <para>skos:definition : Published URL of the Standard</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#publishedURL">rami:publishedURL</a>
    /// </summary>
    let publishedURL = _prefixId.prefix "publishedURL"
    /// <summary>
    ///   <para>skos:prefLabel : Release Date</para>
    ///   <para>skos:definition : Release Date of the Standard</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#releaseDate">rami:releaseDate</a>
    /// </summary>
    let releaseDate = _prefixId.prefix "releaseDate"
    /// <summary>
    ///   <para>skos:prefLabel : Safety Name</para>
    ///   <para>skos:definition : Name of the Safety Configuration of the Object/Entity</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#safetyName">rami:safetyName</a>
    /// </summary>
    let safetyName = _prefixId.prefix "safetyName"
    /// <summary>
    ///   <para>skos:prefLabel : Standard Name</para>
    ///   <para>skos:definition : Name of the Standard that specifies the Engineering Data</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#standardName">rami:standardName</a>
    /// </summary>
    let standardName = _prefixId.prefix "standardName"
    /// <summary>
    ///   <para>skos:prefLabel : Standard URL</para>
    ///   <para>skos:definition : Points to the URL of the Standard that specifies the Engineering Data</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#standardURL">rami:standardURL</a>
    /// </summary>
    let standardURL = _prefixId.prefix "standardURL"
    /// <summary>
    ///   <para>skos:prefLabel : Standard Version</para>
    ///   <para>skos:definition : Version of the Standard that specifies the Engineering Data</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#standardVersion">rami:standardVersion</a>
    /// </summary>
    let standardVersion = _prefixId.prefix "standardVersion"
    /// <summary>
    ///   <para>skos:prefLabel : Std Name</para>
    ///   <para>skos:definition : Name of the Standard</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#stdName">rami:stdName</a>
    /// </summary>
    let stdName = _prefixId.prefix "stdName"
    /// <summary>
    ///   <para>skos:prefLabel : typeDescription</para>
    ///   <para>skos:definition : Describes the Entity/Object related data. It correspond to the Description concept of OMM</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#typeDescription">rami:typeDescription</a>
    /// </summary>
    let typeDescription = _prefixId.prefix "typeDescription"
    /// <summary>
    ///   <para>skos:prefLabel : Versionskos:prefLabel : has Version</para>
    ///   <para>skos:definition : Current version of the Standardskos:definition : Version of the Firmware that belongs to the Object/Entity</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#version">rami:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"
    /// <summary>
    ///   <para>skos:prefLabel : Video Recording Url</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#videoRecordingUrl">rami:videoRecordingUrl</a>
    /// </summary>
    let videoRecordingUrl = _prefixId.prefix "videoRecordingUrl"
    /// <summary>
    ///   <para>skos:prefLabel : videoUrl</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#videoUrl">rami:videoUrl</a>
    /// </summary>
    let videoUrl = _prefixId.prefix "videoUrl"
    /// <summary>
    ///   <para>skos:prefLabel : wraps</para>
    ///   <para>skos:definition : Connect the Object with the Admin Shell</para>
    ///   <a href="http://iais.fraunhofer.de/vocabs/rami#wraps">rami:wraps</a>
    /// </summary>
    let wraps = _prefixId.prefix "wraps"
