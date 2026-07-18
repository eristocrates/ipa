namespace http.w3id.org.ioc.hash

open DoxAletheia.Rdf_Vocabulary

module ioc =
    let _namespace_name = "http://w3id.org/ioc#"

    /// <summary>
    /// object property to link a specific version of an actor links to the process actor.
    /// <see href="http://w3id.org/ioc#hasActorValue"></see></summary>
    let hasActorValue =
        Namespaced_IRI.parse _namespace_name "hasActorValue" |> NamespacedName

    /// <summary>
    /// object property to link a specific version of an capability requirement  to one or more capabilities describring a process requirement
    /// <see href="http://w3id.org/ioc#hasCapabilityRequirementValue"></see></summary>
    let hasCapabilityRequirementValue =
        Namespaced_IRI.parse _namespace_name "hasCapabilityRequirementValue" |> NamespacedName

    /// <summary>
    /// object property to link a specific version of an capability of a resource  to one or more capabilities
    /// <see href="http://w3id.org/ioc#hasCapabilityValue"></see></summary>
    let hasCapabilityValue =
        Namespaced_IRI.parse _namespace_name "hasCapabilityValue" |> NamespacedName

    /// <summary>
    /// object property to link a specific version of an Element  to one or more elements
    /// <see href="http://w3id.org/ioc#hasElementValue"></see></summary>
    let hasElementValue =
        Namespaced_IRI.parse _namespace_name "hasElementValue" |> NamespacedName

    /// <summary>
    /// object property to link a specific version of an inistial space to the class describing its exact value
    /// <see href="http://w3id.org/ioc#hasInitialSpaceValue"></see></summary>
    let hasInitialSpaceValue =
        Namespaced_IRI.parse _namespace_name "hasInitialSpaceValue" |> NamespacedName

    /// <summary>
    /// Property for linking a version of an element that the process transforms to the speciffic element classes.
    /// <see href="http://w3id.org/ioc#hasInputElementValue"></see></summary>
    let hasInputElementValue =
        Namespaced_IRI.parse _namespace_name "hasInputElementValue" |> NamespacedName

    /// <summary>
    /// object property to link a specific version of an piece of input information to one or more pieces of information
    /// <see href="http://w3id.org/ioc#hasInputInformationValue"></see></summary>
    let hasInputInformationValue =
        Namespaced_IRI.parse _namespace_name "hasInputInformationValue" |> NamespacedName

    /// <summary>
    /// object property to link a specific version of a location  to one or more location instances
    /// <see href="http://w3id.org/ioc#hasLocationValue"></see></summary>
    let hasLocationValue =
        Namespaced_IRI.parse _namespace_name "hasLocationValue" |> NamespacedName

    /// <summary>
    /// object property to link a specific version of a method  to one or more instanciated Methods
    /// <see href="http://w3id.org/ioc#hasMethodValue"></see></summary>
    let hasMethodValue =
        Namespaced_IRI.parse _namespace_name "hasMethodValue" |> NamespacedName

    /// <summary>
    /// Property for linking a version of an element that the process has transformed to the speciffic element classes.
    /// <see href="http://w3id.org/ioc#hasOutputElementValue"></see></summary>
    let hasOutputElementValue =
        Namespaced_IRI.parse _namespace_name "hasOutputElementValue" |> NamespacedName

    /// <summary>
    /// object property to link a specific version of an piece of output information to one or more pieces of information
    /// <see href="http://w3id.org/ioc#hasOutputInformationValue"></see></summary>
    let hasOutputInformationValue =
        Namespaced_IRI.parse _namespace_name "hasOutputInformationValue" |> NamespacedName

    /// <summary>
    /// Object property to link a  version of a resource, which is defined as pysical or tangible item, material, equipment or asset that is necessary for the successful execution of a construction process, to instanciated class
    /// <see href="http://w3id.org/ioc#hasResourceValue"></see></summary>
    let hasResourceValue =
        Namespaced_IRI.parse _namespace_name "hasResourceValue" |> NamespacedName

    /// <summary>
    /// Object property to connect a version of a detailed and organized plan that outlines the sequence and timing of tasks, activities, and events required to complete a specific proces to a instanciated Schedule
    /// <see href="http://w3id.org/ioc#hasScheduleValue"></see></summary>
    let hasScheduleValue =
        Namespaced_IRI.parse _namespace_name "hasScheduleValue" |> NamespacedName

    /// <summary>
    /// Object property to connect a version of a condition or state of the process to a single, instanciated status. It is descirbed with a combination of bools.
    /// <see href="http://w3id.org/ioc#hasStatusValue"></see></summary>
    let hasStatusValue =
        Namespaced_IRI.parse _namespace_name "hasStatusValue" |> NamespacedName

    /// <summary>
    /// Property to add a isingle instance to a version of an output space, thus defining the transformed location or space of the process
    /// <see href="http://w3id.org/ioc#hasTargetSpaceValue"></see></summary>
    let hasTargetSpaceValue =
        Namespaced_IRI.parse _namespace_name "hasTargetSpaceValue" |> NamespacedName

    /// <summary>
    /// Object Property to describe the containment of Locations, Resources or Elements in Spatial Zones from version to instance
    /// <see href="http://w3id.org/ioc#isContainedInValue"></see></summary>
    let isContainedInValue =
        Namespaced_IRI.parse _namespace_name "isContainedInValue" |> NamespacedName

    /// <summary>
    /// A responsible person or organization. can be assigned to a process
    /// <see href="http://w3id.org/ioc#Actor"></see></summary>
    let Actor = Namespaced_IRI.parse _namespace_name "Actor" |> NamespacedName
    /// <summary>
    /// Refers to the ability or capacity of an individual, organization, system, or entity to perform a specific action, task, or function effectively.
    /// <see href="http://w3id.org/ioc#Capability"></see></summary>
    let Capability = Namespaced_IRI.parse _namespace_name "Capability" |> NamespacedName
    /// <summary>
    /// A element or a group of elements.
    /// <see href="http://w3id.org/ioc#Element"></see></summary>
    let Element = Namespaced_IRI.parse _namespace_name "Element" |> NamespacedName

    /// <summary>
    /// Structured Process Data. This class is meant to be a loose connection to other files and information containers.
    /// <see href="http://w3id.org/ioc#Information"></see></summary>
    let Information =
        Namespaced_IRI.parse _namespace_name "Information" |> NamespacedName

    /// <summary>
    /// The Method that is used to perform the process described. Used as Interface to mor specific domain ontologies.
    /// <see href="http://w3id.org/ioc#Method"></see></summary>
    let Method = Namespaced_IRI.parse _namespace_name "Method" |> NamespacedName
    /// <summary>
    /// refers to any physical or tangible item, material, equipment or asset that is necessary for the successful execution of a construction process.
    /// <see href="http://w3id.org/ioc#Resource"></see></summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName
    /// <summary>
    /// A process schedule is a detailed and organized plan that outlines the sequence and timing of tasks, activities, and events required to complete a specific process.
    /// <see href="http://w3id.org/ioc#Schedule"></see></summary>
    let Schedule = Namespaced_IRI.parse _namespace_name "Schedule" |> NamespacedName
    /// <summary>
    /// Generic Superclass for Spatial Information
    /// <see href="http://w3id.org/ioc#Space"></see></summary>
    let Space = Namespaced_IRI.parse _namespace_name "Space" |> NamespacedName
    /// <summary>
    /// Status refers to the current conditionor state of the process. It is descirbed with a combination of bools.
    /// <see href="http://w3id.org/ioc#Status"></see></summary>
    let Status = Namespaced_IRI.parse _namespace_name "Status" |> NamespacedName

    /// <summary>
    /// A secondary element that is not part of the realized building afterwards.
    /// <see href="http://w3id.org/ioc#AuxiliaryElement"></see></summary>
    let AuxiliaryElement =
        Namespaced_IRI.parse _namespace_name "AuxiliaryElement" |> NamespacedName

    /// <summary>
    /// A basic, unprocessed material that is used to produce goods
    /// <see href="http://w3id.org/ioc#RawMaterial"></see></summary>
    let RawMaterial =
        Namespaced_IRI.parse _namespace_name "RawMaterial" |> NamespacedName

    /// <summary>
    /// A responsible person or organization can be assigned to a process with the object property "hasActor"
    /// <see href="http://w3id.org/ioc#hasActor"></see></summary>
    let hasActor = Namespaced_IRI.parse _namespace_name "hasActor" |> NamespacedName

    /// <summary>
    /// Property for adding a version of a capability requirement to a process
    /// <see href="http://w3id.org/ioc#hasCapabilityRequirement"></see></summary>
    let hasCapabilityRequirement =
        Namespaced_IRI.parse _namespace_name "hasCapabilityRequirement" |> NamespacedName

    /// <summary>
    /// Property to add a version of a initial space, which defines the input of a location or space which the process requires
    /// <see href="http://w3id.org/ioc#hasInitialSpace"></see></summary>
    let hasInitialSpace =
        Namespaced_IRI.parse _namespace_name "hasInitialSpace" |> NamespacedName

    /// <summary>
    /// Version of an element that the process transforms
    /// <see href="http://w3id.org/ioc#hasInputElement"></see></summary>
    let hasInputElement =
        Namespaced_IRI.parse _namespace_name "hasInputElement" |> NamespacedName

    /// <summary>
    /// Property for connecting a version of a piece of information or a infromation container to a process
    /// <see href="http://w3id.org/ioc#hasInputInformation"></see></summary>
    let hasInputInformation =
        Namespaced_IRI.parse _namespace_name "hasInputInformation" |> NamespacedName

    /// <summary>
    /// Property for connecting a version of a Method. Method can describe an uninstanciated process in general, like "milling" or "fixing"
    /// <see href="http://w3id.org/ioc#hasMethod"></see></summary>
    let hasMethod = Namespaced_IRI.parse _namespace_name "hasMethod" |> NamespacedName

    /// <summary>
    /// Version of an element that the process has transformed
    /// <see href="http://w3id.org/ioc#hasOutputElement"></see></summary>
    let hasOutputElement =
        Namespaced_IRI.parse _namespace_name "hasOutputElement" |> NamespacedName

    /// <summary>
    /// Property for connecting a version of a piece of information or a infromation container to a process which was transformed by the process
    /// <see href="http://w3id.org/ioc#hasOutputInformation"></see></summary>
    let hasOutputInformation =
        Namespaced_IRI.parse _namespace_name "hasOutputInformation" |> NamespacedName

    /// <summary>
    /// Object property to link a resource, which is defined as pysical or tangible item, material, equipment or asset that is necessary for the successful execution of a construction process.
    /// <see href="http://w3id.org/ioc#hasResource"></see></summary>
    let hasResource =
        Namespaced_IRI.parse _namespace_name "hasResource" |> NamespacedName

    /// <summary>
    /// Object property to connect  a detailed and organized plan that outlines the sequence and timing of tasks, activities, and events required to complete a specific process.
    /// <see href="http://w3id.org/ioc#hasSchedule"></see></summary>
    let hasSchedule =
        Namespaced_IRI.parse _namespace_name "hasSchedule" |> NamespacedName

    /// <summary>
    /// Object property to connect a version of a condition or state of the process. It is descirbed with a combination of bools.
    /// <see href="http://w3id.org/ioc#hasStatus"></see></summary>
    let hasStatus = Namespaced_IRI.parse _namespace_name "hasStatus" |> NamespacedName

    /// <summary>
    /// Property to add a version of an output space, thus defining the transformed location or space of the process
    /// <see href="http://w3id.org/ioc#hasTargetSpace"></see></summary>
    let hasTargetSpace =
        Namespaced_IRI.parse _namespace_name "hasTargetSpace" |> NamespacedName

    /// <summary>
    /// A location in the sense of a describable,precise point in space
    /// <see href="http://w3id.org/ioc#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/ioc#ProcessData"></see>
    /// </summary>
    let ProcessData =
        Namespaced_IRI.parse _namespace_name "ProcessData" |> NamespacedName

    /// <summary>
    /// The current Intermediate Node which helps to add metadata to the object property connecting the Process to its sepcific ProcessData. Functionality adapted form opm ontology.
    /// <see href="http://w3id.org/ioc#CurrentProcessDataState"></see></summary>
    let CurrentProcessDataState =
        Namespaced_IRI.parse _namespace_name "CurrentProcessDataState" |> NamespacedName

    /// <summary>
    /// Intermediate Node which helps to add metadata to the object property connecting the Process to its sepcific ProcessData
    /// <see href="http://w3id.org/ioc#ProcessDataState"></see></summary>
    let ProcessDataState =
        Namespaced_IRI.parse _namespace_name "ProcessDataState" |> NamespacedName

    /// <summary>
    /// The generic class process serves as the central element of the construction process ontology. It can represent a classical process or a subfield common in some definitions such as an activity or a task. Due to the problem of the subjectivity of classifications of the term, no further distinction will be made here.
    /// <see href="http://w3id.org/ioc#Process"></see></summary>
    let Process = Namespaced_IRI.parse _namespace_name "Process" |> NamespacedName

    /// <summary>
    /// The ioc:Actor that generated the information branch
    /// <see href="http://w3id.org/ioc#generatedByActor"></see></summary>
    let generatedByActor =
        Namespaced_IRI.parse _namespace_name "generatedByActor" |> NamespacedName

    /// <summary>
    /// Generalized property to connect a process to a dynamic, version of its process data.
    /// <see href="http://w3id.org/ioc#hasProcessDataState"></see></summary>
    let hasProcessDataState =
        Namespaced_IRI.parse _namespace_name "hasProcessDataState" |> NamespacedName

    /// <summary>
    /// Generic Property to connect ProcessDataStates, which can be versioned, to the actual classes that describe ProcessData.
    /// <see href="http://w3id.org/ioc#hasValue"></see></summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName

    /// <summary>
    /// The version of a capability a resource inherits
    /// <see href="http://w3id.org/ioc#hasCapability"></see></summary>
    let hasCapability =
        Namespaced_IRI.parse _namespace_name "hasCapability" |> NamespacedName

    /// <summary>
    /// Child process of a process. A process can have a undeifned number of children
    /// <see href="http://w3id.org/ioc#hasChild"></see></summary>
    let hasChild = Namespaced_IRI.parse _namespace_name "hasChild" |> NamespacedName
    /// <summary>
    /// Parent of a Process. A Process can at most have one parent.
    /// <see href="http://w3id.org/ioc#hasParent"></see></summary>
    let hasParent = Namespaced_IRI.parse _namespace_name "hasParent" |> NamespacedName

    /// <summary>
    /// Duration of a Process Schedule
    /// <see href="http://w3id.org/ioc#hasDuration"></see></summary>
    let hasDuration =
        Namespaced_IRI.parse _namespace_name "hasDuration" |> NamespacedName

    /// <summary>
    /// Points to a version of an element grouping
    /// <see href="http://w3id.org/ioc#hasElement"></see></summary>
    let hasElement = Namespaced_IRI.parse _namespace_name "hasElement" |> NamespacedName

    /// <summary>
    /// A optional, internal process mark that can be used to add custom functionality to the process model
    /// <see href="http://w3id.org/ioc#hasInternalProcessMark"></see></summary>
    let hasInternalProcessMark =
        Namespaced_IRI.parse _namespace_name "hasInternalProcessMark" |> NamespacedName

    /// <summary>
    /// Property to connect a element, resource or spatial zone.
    /// <see href="http://w3id.org/ioc#hasLocation"></see></summary>
    let hasLocation =
        Namespaced_IRI.parse _namespace_name "hasLocation" |> NamespacedName

    /// <summary>
    /// Logical Predecessor of a process. Must be finished for the process to be ready.
    /// <see href="http://w3id.org/ioc#hasPredecessor"></see></summary>
    let hasPredecessor =
        Namespaced_IRI.parse _namespace_name "hasPredecessor" |> NamespacedName

    /// <summary>
    /// Logical Successor of a process. The process must be  finished for the sucessor to be ready.
    /// <see href="http://w3id.org/ioc#hasSuccessor"></see></summary>
    let hasSuccessor =
        Namespaced_IRI.parse _namespace_name "hasSuccessor" |> NamespacedName

    /// <summary>
    /// A boolean that describes if the process was canceled.
    /// <see href="http://w3id.org/ioc#isCancelled"></see></summary>
    let isCancelled =
        Namespaced_IRI.parse _namespace_name "isCancelled" |> NamespacedName

    /// <summary>
    /// Object Property to describe the containment of Locations, Resources or Elements in Spatial Zones
    /// <see href="http://w3id.org/ioc#isContainedIn"></see></summary>
    let isContainedIn =
        Namespaced_IRI.parse _namespace_name "isContainedIn" |> NamespacedName

    /// <summary>
    /// A boolean that describes if the process was finished.
    /// <see href="http://w3id.org/ioc#isFinished"></see></summary>
    let isFinished = Namespaced_IRI.parse _namespace_name "isFinished" |> NamespacedName
    /// <summary>
    /// A boolean that describes if the process is canceled.
    /// <see href="http://w3id.org/ioc#isPaused"></see></summary>
    let isPaused = Namespaced_IRI.parse _namespace_name "isPaused" |> NamespacedName
    /// <summary>
    /// A boolean that describes if the process is ready to start.
    /// <see href="http://w3id.org/ioc#isReady"></see></summary>
    let isReady = Namespaced_IRI.parse _namespace_name "isReady" |> NamespacedName
    /// <summary>
    /// A boolean that describes if the process was started.
    /// <see href="http://w3id.org/ioc#isStarted"></see></summary>
    let isStarted = Namespaced_IRI.parse _namespace_name "isStarted" |> NamespacedName
    /// <summary>
    /// A boolean that describes if a ProcessDataState os considered valid trhough extra validation. WIP
    /// <see href="http://w3id.org/ioc#isvalid"></see></summary>
    let isvalid = Namespaced_IRI.parse _namespace_name "isvalid" |> NamespacedName
