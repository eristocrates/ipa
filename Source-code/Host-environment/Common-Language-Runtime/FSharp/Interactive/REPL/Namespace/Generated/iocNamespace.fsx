#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ioc =
    let _prefixId = PrefixId.fromNamespaceLabel "http://w3id.org/ioc#" "ioc"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Actor^^xsd:string</para>
    ///   <para>rdfs:comment : A responsible person or organization. can be assigned to a process^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#Actor">ioc:Actor</a>
    /// </summary>
    let Actor = _prefixId.prefix "Actor"
    /// <summary>
    ///   <para>rdfs:label : AuxiliaryElement^^xsd:string</para>
    ///   <para>rdfs:comment : A secondary element that is not part of the realized building afterwards.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#AuxiliaryElement">ioc:AuxiliaryElement</a>
    /// </summary>
    let AuxiliaryElement = _prefixId.prefix "AuxiliaryElement"
    /// <summary>
    ///   <para>rdfs:label : Capability^^xsd:string</para>
    ///   <para>rdfs:comment : Refers to the ability or capacity of an individual, organization, system, or entity to perform a specific action, task, or function effectively.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#Capability">ioc:Capability</a>
    /// </summary>
    let Capability = _prefixId.prefix "Capability"
    /// <summary>
    ///   <para>rdfs:label : CurrentProcessDataState^^xsd:string</para>
    ///   <para>rdfs:comment : The current Intermediate Node which helps to add metadata to the object property connecting the Process to its sepcific ProcessData. Functionality adapted form opm ontology.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#CurrentProcessDataState">ioc:CurrentProcessDataState</a>
    /// </summary>
    let CurrentProcessDataState = _prefixId.prefix "CurrentProcessDataState"
    /// <summary>
    ///   <para>rdfs:label : Element^^xsd:string</para>
    ///   <para>rdfs:comment : A element or a group of elements.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#Element">ioc:Element</a>
    /// </summary>
    let Element = _prefixId.prefix "Element"
    /// <summary>
    ///   <para>rdfs:label : Information^^xsd:string</para>
    ///   <para>rdfs:comment : Structured Process Data. This class is meant to be a loose connection to other files and information containers.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#Information">ioc:Information</a>
    /// </summary>
    let Information = _prefixId.prefix "Information"
    /// <summary>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <para>rdfs:comment : A location in the sense of a describable,precise point in space^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#Location">ioc:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:label : Method^^xsd:string</para>
    ///   <para>rdfs:comment : The Method that is used to perform the process described. Used as Interface to mor specific domain ontologies.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#Method">ioc:Method</a>
    /// </summary>
    let Method = _prefixId.prefix "Method"
    /// <summary>
    ///   <para>rdfs:label : Process^^xsd:string</para>
    ///   <para>rdfs:comment : The generic class process serves as the central element of the construction process ontology. It can represent a classical process or a subfield common in some definitions such as an activity or a task. Due to the problem of the subjectivity of classifications of the term, no further distinction will be made here.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#Process">ioc:Process</a>
    /// </summary>
    let Process = _prefixId.prefix "Process"
    let ProcessData = _prefixId.prefix "ProcessData"
    /// <summary>
    ///   <para>rdfs:label : ProcessDataState^^xsd:string</para>
    ///   <para>rdfs:comment : Intermediate Node which helps to add metadata to the object property connecting the Process to its sepcific ProcessData^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#ProcessDataState">ioc:ProcessDataState</a>
    /// </summary>
    let ProcessDataState = _prefixId.prefix "ProcessDataState"
    /// <summary>
    ///   <para>rdfs:label : RawMaterial^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://w3id.org/ioc#^^xsd:string</para>
    ///   <para>rdfs:comment : A basic, unprocessed material that is used to produce goods^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#RawMaterial">ioc:RawMaterial</a>
    /// </summary>
    let RawMaterial = _prefixId.prefix "RawMaterial"
    /// <summary>
    ///   <para>rdfs:label : Resource^^xsd:string</para>
    ///   <para>rdfs:comment : refers to any physical or tangible item, material, equipment or asset that is necessary for the successful execution of a construction process.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#Resource">ioc:Resource</a>
    /// </summary>
    let Resource = _prefixId.prefix "Resource"
    /// <summary>
    ///   <para>rdfs:label : Schedule^^xsd:string</para>
    ///   <para>rdfs:comment : A process schedule is a detailed and organized plan that outlines the sequence and timing of tasks, activities, and events required to complete a specific process.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#Schedule">ioc:Schedule</a>
    /// </summary>
    let Schedule = _prefixId.prefix "Schedule"
    /// <summary>
    ///   <para>rdfs:label : Space^^xsd:string</para>
    ///   <para>rdfs:comment : Generic Superclass for Spatial Information^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#Space">ioc:Space</a>
    /// </summary>
    let Space = _prefixId.prefix "Space"
    /// <summary>
    ///   <para>rdfs:label : Status^^xsd:string</para>
    ///   <para>rdfs:comment : Status refers to the current conditionor state of the process. It is descirbed with a combination of bools.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#Status">ioc:Status</a>
    /// </summary>
    let Status = _prefixId.prefix "Status"
    /// <summary>
    ///   <para>rdfs:label : generatedByActor^^xsd:string</para>
    ///   <para>rdfs:comment : The ioc:Actor that generated the information branch^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#generatedByActor">ioc:generatedByActor</a>
    /// </summary>
    let generatedByActor = _prefixId.prefix "generatedByActor"
    /// <summary>
    ///   <para>rdfs:label : hasActor^^xsd:string</para>
    ///   <para>rdfs:comment : A responsible person or organization can be assigned to a process with the object property "hasActor" ^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasActor">ioc:hasActor</a>
    /// </summary>
    let hasActor = _prefixId.prefix "hasActor"
    /// <summary>
    ///   <para>rdfs:label : hasActorValue^^xsd:string</para>
    ///   <para>rdfs:comment : object property to link a specific version of an actor links to the process actor.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasActorValue">ioc:hasActorValue</a>
    /// </summary>
    let hasActorValue = _prefixId.prefix "hasActorValue"
    /// <summary>
    ///   <para>rdfs:label : hasCapability^^xsd:string</para>
    ///   <para>rdfs:comment : The version of a capability a resource inherits^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasCapability">ioc:hasCapability</a>
    /// </summary>
    let hasCapability = _prefixId.prefix "hasCapability"
    /// <summary>
    ///   <para>rdfs:label : hasCapabilityRequirement^^xsd:string</para>
    ///   <para>rdfs:comment : Property for adding a version of a capability requirement to a process^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasCapabilityRequirement">ioc:hasCapabilityRequirement</a>
    /// </summary>
    let hasCapabilityRequirement = _prefixId.prefix "hasCapabilityRequirement"
    /// <summary>
    ///   <para>rdfs:label : hasCapabilityRequirementValue^^xsd:string</para>
    ///   <para>rdfs:comment : object property to link a specific version of an capability requirement  to one or more capabilities describring a process requirement^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasCapabilityRequirementValue">ioc:hasCapabilityRequirementValue</a>
    /// </summary>
    let hasCapabilityRequirementValue = _prefixId.prefix "hasCapabilityRequirementValue"
    /// <summary>
    ///   <para>rdfs:label : hasCapabilityValue^^xsd:string</para>
    ///   <para>rdfs:comment : object property to link a specific version of an capability of a resource  to one or more capabilities^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasCapabilityValue">ioc:hasCapabilityValue</a>
    /// </summary>
    let hasCapabilityValue = _prefixId.prefix "hasCapabilityValue"
    /// <summary>
    ///   <para>rdfs:label : hasChild^^xsd:string</para>
    ///   <para>rdfs:comment : Child process of a process. A process can have a undeifned number of children^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasChild">ioc:hasChild</a>
    /// </summary>
    let hasChild = _prefixId.prefix "hasChild"
    /// <summary>
    ///   <para>rdfs:comment : Duration of a Process Schedule^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasDuration">ioc:hasDuration</a>
    /// </summary>
    let hasDuration = _prefixId.prefix "hasDuration"
    /// <summary>
    ///   <para>rdfs:label : hasElement^^xsd:string</para>
    ///   <para>rdfs:comment : Points to a version of an element grouping^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasElement">ioc:hasElement</a>
    /// </summary>
    let hasElement = _prefixId.prefix "hasElement"
    /// <summary>
    ///   <para>rdfs:label : hasElementValue^^xsd:string</para>
    ///   <para>rdfs:comment : object property to link a specific version of an Element  to one or more elements^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasElementValue">ioc:hasElementValue</a>
    /// </summary>
    let hasElementValue = _prefixId.prefix "hasElementValue"
    /// <summary>
    ///   <para>rdfs:label : hasInitialSpace^^xsd:string</para>
    ///   <para>rdfs:comment : Property to add a version of a initial space, which defines the input of a location or space which the process requires^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasInitialSpace">ioc:hasInitialSpace</a>
    /// </summary>
    let hasInitialSpace = _prefixId.prefix "hasInitialSpace"
    /// <summary>
    ///   <para>rdfs:label : hasInitialSpaceValue^^xsd:string</para>
    ///   <para>rdfs:comment : object property to link a specific version of an inistial space to the class describing its exact value^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasInitialSpaceValue">ioc:hasInitialSpaceValue</a>
    /// </summary>
    let hasInitialSpaceValue = _prefixId.prefix "hasInitialSpaceValue"
    /// <summary>
    ///   <para>rdfs:label : hasInputElement^^xsd:string</para>
    ///   <para>rdfs:comment : Version of an element that the process transforms^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasInputElement">ioc:hasInputElement</a>
    /// </summary>
    let hasInputElement = _prefixId.prefix "hasInputElement"
    /// <summary>
    ///   <para>rdfs:label : hasInputElementValue^^xsd:string</para>
    ///   <para>rdfs:comment : Property for linking a version of an element that the process transforms to the speciffic element classes.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasInputElementValue">ioc:hasInputElementValue</a>
    /// </summary>
    let hasInputElementValue = _prefixId.prefix "hasInputElementValue"
    /// <summary>
    ///   <para>rdfs:label : hasInputInformation^^xsd:string</para>
    ///   <para>rdfs:comment : Property for connecting a version of a piece of information or a infromation container to a process^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasInputInformation">ioc:hasInputInformation</a>
    /// </summary>
    let hasInputInformation = _prefixId.prefix "hasInputInformation"
    /// <summary>
    ///   <para>rdfs:label : hasInputInformationValue^^xsd:string</para>
    ///   <para>rdfs:comment : object property to link a specific version of an piece of input information to one or more pieces of information^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasInputInformationValue">ioc:hasInputInformationValue</a>
    /// </summary>
    let hasInputInformationValue = _prefixId.prefix "hasInputInformationValue"
    /// <summary>
    ///   <para>rdfs:label : hasInternalProcessMark^^xsd:string</para>
    ///   <para>rdfs:comment : A optional, internal process mark that can be used to add custom functionality to the process model^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasInternalProcessMark">ioc:hasInternalProcessMark</a>
    /// </summary>
    let hasInternalProcessMark = _prefixId.prefix "hasInternalProcessMark"
    /// <summary>
    ///   <para>rdfs:label : hasLocation^^xsd:string</para>
    ///   <para>rdfs:comment : Property to connect a element, resource or spatial zone.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasLocation">ioc:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    /// <summary>
    ///   <para>rdfs:label : hasLocationValue^^xsd:string</para>
    ///   <para>rdfs:comment : object property to link a specific version of a location  to one or more location instances^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasLocationValue">ioc:hasLocationValue</a>
    /// </summary>
    let hasLocationValue = _prefixId.prefix "hasLocationValue"
    /// <summary>
    ///   <para>rdfs:label : hasMethod^^xsd:string</para>
    ///   <para>rdfs:comment : Property for connecting a version of a Method. Method can describe an uninstanciated process in general, like "milling" or "fixing"^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasMethod">ioc:hasMethod</a>
    /// </summary>
    let hasMethod = _prefixId.prefix "hasMethod"
    /// <summary>
    ///   <para>rdfs:label : hasMethodValue^^xsd:string</para>
    ///   <para>rdfs:comment : object property to link a specific version of a method  to one or more instanciated Methods^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasMethodValue">ioc:hasMethodValue</a>
    /// </summary>
    let hasMethodValue = _prefixId.prefix "hasMethodValue"
    /// <summary>
    ///   <para>rdfs:label : hasOutputElement^^xsd:string</para>
    ///   <para>rdfs:comment : Version of an element that the process has transformed^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasOutputElement">ioc:hasOutputElement</a>
    /// </summary>
    let hasOutputElement = _prefixId.prefix "hasOutputElement"
    /// <summary>
    ///   <para>rdfs:label : hasOutputElementValue^^xsd:string</para>
    ///   <para>rdfs:comment : Property for linking a version of an element that the process has transformed to the speciffic element classes.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasOutputElementValue">ioc:hasOutputElementValue</a>
    /// </summary>
    let hasOutputElementValue = _prefixId.prefix "hasOutputElementValue"
    /// <summary>
    ///   <para>rdfs:label : hasOutputInformation^^xsd:string</para>
    ///   <para>rdfs:comment : Property for connecting a version of a piece of information or a infromation container to a process which was transformed by the process^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasOutputInformation">ioc:hasOutputInformation</a>
    /// </summary>
    let hasOutputInformation = _prefixId.prefix "hasOutputInformation"
    /// <summary>
    ///   <para>rdfs:label : hasOutputInformationValue^^xsd:string</para>
    ///   <para>rdfs:comment : object property to link a specific version of an piece of output information to one or more pieces of information^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasOutputInformationValue">ioc:hasOutputInformationValue</a>
    /// </summary>
    let hasOutputInformationValue = _prefixId.prefix "hasOutputInformationValue"
    /// <summary>
    ///   <para>rdfs:label : hasParent^^xsd:string</para>
    ///   <para>rdfs:comment : Parent of a Process. A Process can at most have one parent.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasParent">ioc:hasParent</a>
    /// </summary>
    let hasParent = _prefixId.prefix "hasParent"
    /// <summary>
    ///   <para>rdfs:label : hasPredecessor^^xsd:string</para>
    ///   <para>rdfs:comment : Logical Predecessor of a process. Must be finished for the process to be ready.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasPredecessor">ioc:hasPredecessor</a>
    /// </summary>
    let hasPredecessor = _prefixId.prefix "hasPredecessor"
    /// <summary>
    ///   <para>rdfs:label : hasProcessDataState^^xsd:string</para>
    ///   <para>rdfs:comment : Generalized property to connect a process to a dynamic, version of its process data.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasProcessDataState">ioc:hasProcessDataState</a>
    /// </summary>
    let hasProcessDataState = _prefixId.prefix "hasProcessDataState"
    /// <summary>
    ///   <para>rdfs:label : hasResource^^xsd:string</para>
    ///   <para>rdfs:comment : Object property to link a resource, which is defined as pysical or tangible item, material, equipment or asset that is necessary for the successful execution of a construction process.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasResource">ioc:hasResource</a>
    /// </summary>
    let hasResource = _prefixId.prefix "hasResource"
    /// <summary>
    ///   <para>rdfs:label : hasResourceValue^^xsd:string</para>
    ///   <para>rdfs:comment : Object property to link a  version of a resource, which is defined as pysical or tangible item, material, equipment or asset that is necessary for the successful execution of a construction process, to instanciated class^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasResourceValue">ioc:hasResourceValue</a>
    /// </summary>
    let hasResourceValue = _prefixId.prefix "hasResourceValue"
    /// <summary>
    ///   <para>rdfs:label : hasSchedule^^xsd:string</para>
    ///   <para>rdfs:comment : Object property to connect  a detailed and organized plan that outlines the sequence and timing of tasks, activities, and events required to complete a specific process.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasSchedule">ioc:hasSchedule</a>
    /// </summary>
    let hasSchedule = _prefixId.prefix "hasSchedule"
    /// <summary>
    ///   <para>rdfs:label : hasScheduleValue^^xsd:string</para>
    ///   <para>rdfs:comment : Object property to connect a version of a detailed and organized plan that outlines the sequence and timing of tasks, activities, and events required to complete a specific proces to a instanciated Schedule^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasScheduleValue">ioc:hasScheduleValue</a>
    /// </summary>
    let hasScheduleValue = _prefixId.prefix "hasScheduleValue"
    /// <summary>
    ///   <para>rdfs:label : hasStatus^^xsd:string</para>
    ///   <para>rdfs:comment : Object property to connect a version of a condition or state of the process. It is descirbed with a combination of bools.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasStatus">ioc:hasStatus</a>
    /// </summary>
    let hasStatus = _prefixId.prefix "hasStatus"
    /// <summary>
    ///   <para>rdfs:label : hasStatusValue^^xsd:string</para>
    ///   <para>rdfs:comment : Object property to connect a version of a condition or state of the process to a single, instanciated status. It is descirbed with a combination of bools.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasStatusValue">ioc:hasStatusValue</a>
    /// </summary>
    let hasStatusValue = _prefixId.prefix "hasStatusValue"
    /// <summary>
    ///   <para>rdfs:label : hasSuccessor^^xsd:string</para>
    ///   <para>rdfs:comment : Logical Successor of a process. The process must be  finished for the sucessor to be ready.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasSuccessor">ioc:hasSuccessor</a>
    /// </summary>
    let hasSuccessor = _prefixId.prefix "hasSuccessor"
    /// <summary>
    ///   <para>rdfs:label : hasTargetSpace^^xsd:string</para>
    ///   <para>rdfs:comment : Property to add a version of an output space, thus defining the transformed location or space of the process^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasTargetSpace">ioc:hasTargetSpace</a>
    /// </summary>
    let hasTargetSpace = _prefixId.prefix "hasTargetSpace"
    /// <summary>
    ///   <para>rdfs:label : hasTargetSpaceValue^^xsd:string</para>
    ///   <para>rdfs:comment : Property to add a isingle instance to a version of an output space, thus defining the transformed location or space of the process^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasTargetSpaceValue">ioc:hasTargetSpaceValue</a>
    /// </summary>
    let hasTargetSpaceValue = _prefixId.prefix "hasTargetSpaceValue"
    /// <summary>
    ///   <para>rdfs:label : hasValue^^xsd:string</para>
    ///   <para>rdfs:comment : Generic Property to connect ProcessDataStates, which can be versioned, to the actual classes that describe ProcessData.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#hasValue">ioc:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:label : isCancelled^^xsd:string</para>
    ///   <para>rdfs:comment : A boolean that describes if the process was canceled.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#isCancelled">ioc:isCancelled</a>
    /// </summary>
    let isCancelled = _prefixId.prefix "isCancelled"
    /// <summary>
    ///   <para>rdfs:label : isContainedIn^^xsd:string</para>
    ///   <para>rdfs:comment : Object Property to describe the containment of Locations, Resources or Elements in Spatial Zones^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#isContainedIn">ioc:isContainedIn</a>
    /// </summary>
    let isContainedIn = _prefixId.prefix "isContainedIn"
    /// <summary>
    ///   <para>rdfs:label : isContainedInValue^^xsd:string</para>
    ///   <para>rdfs:comment : Object Property to describe the containment of Locations, Resources or Elements in Spatial Zones from version to instance^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#isContainedInValue">ioc:isContainedInValue</a>
    /// </summary>
    let isContainedInValue = _prefixId.prefix "isContainedInValue"
    /// <summary>
    ///   <para>rdfs:label : isFinished^^xsd:string</para>
    ///   <para>rdfs:comment : A boolean that describes if the process was finished.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#isFinished">ioc:isFinished</a>
    /// </summary>
    let isFinished = _prefixId.prefix "isFinished"
    /// <summary>
    ///   <para>rdfs:label : isPaused^^xsd:string</para>
    ///   <para>rdfs:comment : A boolean that describes if the process is canceled.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#isPaused">ioc:isPaused</a>
    /// </summary>
    let isPaused = _prefixId.prefix "isPaused"
    /// <summary>
    ///   <para>rdfs:label : isReady^^xsd:string</para>
    ///   <para>rdfs:comment : A boolean that describes if the process is ready to start.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#isReady">ioc:isReady</a>
    /// </summary>
    let isReady = _prefixId.prefix "isReady"
    /// <summary>
    ///   <para>rdfs:label : isStarted^^xsd:string</para>
    ///   <para>rdfs:comment : A boolean that describes if the process was started.^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#isStarted">ioc:isStarted</a>
    /// </summary>
    let isStarted = _prefixId.prefix "isStarted"
    /// <summary>
    ///   <para>rdfs:label : isvalid^^xsd:string</para>
    ///   <para>rdfs:comment : A boolean that describes if a ProcessDataState os considered valid trhough extra validation. WIP^^xsd:string</para>
    ///   <a href="http://w3id.org/ioc#isvalid">ioc:isvalid</a>
    /// </summary>
    let isvalid = _prefixId.prefix "isvalid"
