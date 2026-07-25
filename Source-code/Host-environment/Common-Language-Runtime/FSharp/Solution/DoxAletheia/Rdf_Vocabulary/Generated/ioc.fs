namespace http.w3id.org.ioc.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ioc =
    let _namespace_iri = Namespace_Iri ioc |> NamespaceIRI
    /// <summary>
    ///   <para>ioc:hasActorValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>object property to link a specific version of an actor links to the process actor.</para>
    /// labels<para>hasActorValue</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasActorValue">http://w3id.org/ioc#hasActorValue</seealso>
    let hasActorValue = Prefixed_Name(ioc, "hasActorValue") |> PrefixedName

    /// <summary>
    ///   <para>ioc:hasInitialSpaceValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>object property to link a specific version of an inistial space to the class describing its exact value</para>
    /// labels<para>hasInitialSpaceValue</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasInitialSpaceValue">http://w3id.org/ioc#hasInitialSpaceValue</seealso>
    let hasInitialSpaceValue =
        Prefixed_Name(ioc, "hasInitialSpaceValue") |> PrefixedName

    /// <summary>
    ///   <para>ioc:hasLocationValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>object property to link a specific version of a location  to one or more location instances</para>
    /// labels<para>hasLocationValue</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasLocationValue">http://w3id.org/ioc#hasLocationValue</seealso>
    let hasLocationValue = Prefixed_Name(ioc, "hasLocationValue") |> PrefixedName

    /// <summary>
    ///   <para>ioc:hasOutputElementValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property for linking a version of an element that the process has transformed to the speciffic element classes.</para>
    /// labels<para>hasOutputElementValue</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasOutputElementValue">http://w3id.org/ioc#hasOutputElementValue</seealso>
    let hasOutputElementValue =
        Prefixed_Name(ioc, "hasOutputElementValue") |> PrefixedName

    /// <summary>
    ///   <para>ioc:AuxiliaryElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A secondary element that is not part of the realized building afterwards.</para>
    /// labels<para>AuxiliaryElement</para></remarks>
    /// <seealso href="http://w3id.org/ioc#AuxiliaryElement">http://w3id.org/ioc#AuxiliaryElement</seealso>
    let AuxiliaryElement = Prefixed_Name(ioc, "AuxiliaryElement") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasInitialSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property to add a version of a initial space, which defines the input of a location or space which the process requires</para>
    /// labels<para>hasInitialSpace</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasInitialSpace">http://w3id.org/ioc#hasInitialSpace</seealso>
    let hasInitialSpace = Prefixed_Name(ioc, "hasInitialSpace") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Object property to link a resource, which is defined as pysical or tangible item, material, equipment or asset that is necessary for the successful execution of a construction process.</para>
    /// labels<para>hasResource</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasResource">http://w3id.org/ioc#hasResource</seealso>
    let hasResource = Prefixed_Name(ioc, "hasResource") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Object property to connect a version of a condition or state of the process. It is descirbed with a combination of bools.</para>
    /// labels<para>hasStatus</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasStatus">http://w3id.org/ioc#hasStatus</seealso>
    let hasStatus = Prefixed_Name(ioc, "hasStatus") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasCapabilityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>object property to link a specific version of an capability of a resource  to one or more capabilities</para>
    /// labels<para>hasCapabilityValue</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasCapabilityValue">http://w3id.org/ioc#hasCapabilityValue</seealso>
    let hasCapabilityValue = Prefixed_Name(ioc, "hasCapabilityValue") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasMethodValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>object property to link a specific version of a method  to one or more instanciated Methods</para>
    /// labels<para>hasMethodValue</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasMethodValue">http://w3id.org/ioc#hasMethodValue</seealso>
    let hasMethodValue = Prefixed_Name(ioc, "hasMethodValue") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasResourceValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object property to link a  version of a resource, which is defined as pysical or tangible item, material, equipment or asset that is necessary for the successful execution of a construction process, to instanciated class</para>
    /// labels<para>hasResourceValue</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasResourceValue">http://w3id.org/ioc#hasResourceValue</seealso>
    let hasResourceValue = Prefixed_Name(ioc, "hasResourceValue") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasStatusValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object property to connect a version of a condition or state of the process to a single, instanciated status. It is descirbed with a combination of bools.</para>
    /// labels<para>hasStatusValue</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasStatusValue">http://w3id.org/ioc#hasStatusValue</seealso>
    let hasStatusValue = Prefixed_Name(ioc, "hasStatusValue") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasTargetSpaceValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property to add a isingle instance to a version of an output space, thus defining the transformed location or space of the process</para>
    /// labels<para>hasTargetSpaceValue</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasTargetSpaceValue">http://w3id.org/ioc#hasTargetSpaceValue</seealso>
    let hasTargetSpaceValue = Prefixed_Name(ioc, "hasTargetSpaceValue") |> PrefixedName
    /// <summary>
    ///   <para>ioc:Actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A responsible person or organization. can be assigned to a process</para>
    /// labels<para>Actor</para></remarks>
    /// <seealso href="http://w3id.org/ioc#Actor">http://w3id.org/ioc#Actor</seealso>
    let Actor = Prefixed_Name(ioc, "Actor") |> PrefixedName

    /// <summary>
    ///   <para>ioc:hasInputElementValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property for linking a version of an element that the process transforms to the speciffic element classes.</para>
    /// labels<para>hasInputElementValue</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasInputElementValue">http://w3id.org/ioc#hasInputElementValue</seealso>
    let hasInputElementValue =
        Prefixed_Name(ioc, "hasInputElementValue") |> PrefixedName

    /// <summary>
    ///   <para>ioc:hasOutputInformationValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>object property to link a specific version of an piece of output information to one or more pieces of information</para>
    /// labels<para>hasOutputInformationValue</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasOutputInformationValue">http://w3id.org/ioc#hasOutputInformationValue</seealso>
    let hasOutputInformationValue =
        Prefixed_Name(ioc, "hasOutputInformationValue") |> PrefixedName

    /// <summary>
    ///   <para>ioc:hasDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Duration of a Process Schedule</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/ioc#hasDuration">http://w3id.org/ioc#hasDuration</seealso>
    let hasDuration = Prefixed_Name(ioc, "hasDuration") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasScheduleValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Object property to connect a version of a detailed and organized plan that outlines the sequence and timing of tasks, activities, and events required to complete a specific proces to a instanciated Schedule</para>
    /// labels<para>hasScheduleValue</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasScheduleValue">http://w3id.org/ioc#hasScheduleValue</seealso>
    let hasScheduleValue = Prefixed_Name(ioc, "hasScheduleValue") |> PrefixedName
    /// <summary>
    ///   <para>ioc:Element</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A element or a group of elements.</para>
    /// labels<para>Element</para></remarks>
    /// <seealso href="http://w3id.org/ioc#Element">http://w3id.org/ioc#Element</seealso>
    let Element = Prefixed_Name(ioc, "Element") |> PrefixedName
    /// <summary>
    ///   <para>ioc:Capability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Refers to the ability or capacity of an individual, organization, system, or entity to perform a specific action, task, or function effectively.</para>
    /// labels<para>Capability</para></remarks>
    /// <seealso href="http://w3id.org/ioc#Capability">http://w3id.org/ioc#Capability</seealso>
    let Capability = Prefixed_Name(ioc, "Capability") |> PrefixedName
    /// <summary>
    ///   <para>ioc:Method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Method that is used to perform the process described. Used as Interface to mor specific domain ontologies.</para>
    /// labels<para>Method</para></remarks>
    /// <seealso href="http://w3id.org/ioc#Method">http://w3id.org/ioc#Method</seealso>
    let Method = Prefixed_Name(ioc, "Method") |> PrefixedName
    /// <summary>
    ///   <para>ioc:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>refers to any physical or tangible item, material, equipment or asset that is necessary for the successful execution of a construction process.</para>
    /// labels<para>Resource</para></remarks>
    /// <seealso href="http://w3id.org/ioc#Resource">http://w3id.org/ioc#Resource</seealso>
    let Resource = Prefixed_Name(ioc, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>ioc:Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Status refers to the current conditionor state of the process. It is descirbed with a combination of bools.</para>
    /// labels<para>Status</para></remarks>
    /// <seealso href="http://w3id.org/ioc#Status">http://w3id.org/ioc#Status</seealso>
    let Status = Prefixed_Name(ioc, "Status") |> PrefixedName
    /// <summary>
    ///   <para>ioc:isCancelled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A boolean that describes if the process was canceled.</para>
    /// labels<para>isCancelled</para></remarks>
    /// <seealso href="http://w3id.org/ioc#isCancelled">http://w3id.org/ioc#isCancelled</seealso>
    let isCancelled = Prefixed_Name(ioc, "isCancelled") |> PrefixedName
    /// <summary>
    ///   <para>ioc:isContainedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Object Property to describe the containment of Locations, Resources or Elements in Spatial Zones</para>
    /// labels<para>isContainedIn</para></remarks>
    /// <seealso href="http://w3id.org/ioc#isContainedIn">http://w3id.org/ioc#isContainedIn</seealso>
    let isContainedIn = Prefixed_Name(ioc, "isContainedIn") |> PrefixedName
    /// <summary>
    ///   <para>ioc:Information</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Structured Process Data. This class is meant to be a loose connection to other files and information containers.</para>
    /// labels<para>Information</para></remarks>
    /// <seealso href="http://w3id.org/ioc#Information">http://w3id.org/ioc#Information</seealso>
    let Information = Prefixed_Name(ioc, "Information") |> PrefixedName
    /// <summary>
    ///   <para>ioc:Space</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Generic Superclass for Spatial Information</para>
    /// labels<para>Space</para></remarks>
    /// <seealso href="http://w3id.org/ioc#Space">http://w3id.org/ioc#Space</seealso>
    let Space = Prefixed_Name(ioc, "Space") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A responsible person or organization can be assigned to a process with the object property "hasActor" </para>
    /// labels<para>hasActor</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasActor">http://w3id.org/ioc#hasActor</seealso>
    let hasActor = Prefixed_Name(ioc, "hasActor") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasInputElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Version of an element that the process transforms</para>
    /// labels<para>hasInputElement</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasInputElement">http://w3id.org/ioc#hasInputElement</seealso>
    let hasInputElement = Prefixed_Name(ioc, "hasInputElement") |> PrefixedName
    /// <summary>
    ///   <para>ioc:isFinished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A boolean that describes if the process was finished.</para>
    /// labels<para>isFinished</para></remarks>
    /// <seealso href="http://w3id.org/ioc#isFinished">http://w3id.org/ioc#isFinished</seealso>
    let isFinished = Prefixed_Name(ioc, "isFinished") |> PrefixedName
    /// <summary>
    ///   <para>ioc:isPaused</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A boolean that describes if the process is canceled.</para>
    /// labels<para>isPaused</para></remarks>
    /// <seealso href="http://w3id.org/ioc#isPaused">http://w3id.org/ioc#isPaused</seealso>
    let isPaused = Prefixed_Name(ioc, "isPaused") |> PrefixedName
    /// <summary>
    ///   <para>ioc:isReady</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A boolean that describes if the process is ready to start.</para>
    /// labels<para>isReady</para></remarks>
    /// <seealso href="http://w3id.org/ioc#isReady">http://w3id.org/ioc#isReady</seealso>
    let isReady = Prefixed_Name(ioc, "isReady") |> PrefixedName
    /// <summary>
    ///   <para>ioc:isStarted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A boolean that describes if the process was started.</para>
    /// labels<para>isStarted</para></remarks>
    /// <seealso href="http://w3id.org/ioc#isStarted">http://w3id.org/ioc#isStarted</seealso>
    let isStarted = Prefixed_Name(ioc, "isStarted") |> PrefixedName
    /// <summary>
    ///   <para>ioc:isvalid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A boolean that describes if a ProcessDataState os considered valid trhough extra validation. WIP</para>
    /// labels<para>isvalid</para></remarks>
    /// <seealso href="http://w3id.org/ioc#isvalid">http://w3id.org/ioc#isvalid</seealso>
    let isvalid = Prefixed_Name(ioc, "isvalid") |> PrefixedName
    /// <summary>
    ///   <para>ioc:Schedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process schedule is a detailed and organized plan that outlines the sequence and timing of tasks, activities, and events required to complete a specific process.</para>
    /// labels<para>Schedule</para></remarks>
    /// <seealso href="http://w3id.org/ioc#Schedule">http://w3id.org/ioc#Schedule</seealso>
    let Schedule = Prefixed_Name(ioc, "Schedule") |> PrefixedName

    /// <summary>
    ///   <para>ioc:hasCapabilityRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Property for adding a version of a capability requirement to a process</para>
    /// labels<para>hasCapabilityRequirement</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasCapabilityRequirement">http://w3id.org/ioc#hasCapabilityRequirement</seealso>
    let hasCapabilityRequirement =
        Prefixed_Name(ioc, "hasCapabilityRequirement") |> PrefixedName

    /// <summary>
    ///   <para>ioc:RawMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A basic, unprocessed material that is used to produce goods</para>
    /// labels<para>RawMaterial</para></remarks>
    /// <seealso href="http://w3id.org/ioc#RawMaterial">http://w3id.org/ioc#RawMaterial</seealso>
    let RawMaterial = Prefixed_Name(ioc, "RawMaterial") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasInputInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Property for connecting a version of a piece of information or a infromation container to a process</para>
    /// labels<para>hasInputInformation</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasInputInformation">http://w3id.org/ioc#hasInputInformation</seealso>
    let hasInputInformation = Prefixed_Name(ioc, "hasInputInformation") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property for connecting a version of a Method. Method can describe an uninstanciated process in general, like "milling" or "fixing"</para>
    /// labels<para>hasMethod</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasMethod">http://w3id.org/ioc#hasMethod</seealso>
    let hasMethod = Prefixed_Name(ioc, "hasMethod") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Object property to connect  a detailed and organized plan that outlines the sequence and timing of tasks, activities, and events required to complete a specific process.</para>
    /// labels<para>hasSchedule</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasSchedule">http://w3id.org/ioc#hasSchedule</seealso>
    let hasSchedule = Prefixed_Name(ioc, "hasSchedule") |> PrefixedName
    /// <summary>
    ///   <para>ioc:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A location in the sense of a describable,precise point in space</para>
    /// labels<para>Location</para></remarks>
    /// <seealso href="http://w3id.org/ioc#Location">http://w3id.org/ioc#Location</seealso>
    let Location = Prefixed_Name(ioc, "Location") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasOutputElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Version of an element that the process has transformed</para>
    /// labels<para>hasOutputElement</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasOutputElement">http://w3id.org/ioc#hasOutputElement</seealso>
    let hasOutputElement = Prefixed_Name(ioc, "hasOutputElement") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasTargetSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Property to add a version of an output space, thus defining the transformed location or space of the process</para>
    /// labels<para>hasTargetSpace</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasTargetSpace">http://w3id.org/ioc#hasTargetSpace</seealso>
    let hasTargetSpace = Prefixed_Name(ioc, "hasTargetSpace") |> PrefixedName
    /// <summary>
    ///   <para>ioc:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/ioc#">http://w3id.org/ioc#</seealso>
    let _prefix_iri = Prefixed_Name(ioc, "") |> PrefixedName
    /// <summary>
    ///   <para>ioc:ProcessDataState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Intermediate Node which helps to add metadata to the object property connecting the Process to its sepcific ProcessData</para>
    /// labels<para>ProcessDataState</para></remarks>
    /// <seealso href="http://w3id.org/ioc#ProcessDataState">http://w3id.org/ioc#ProcessDataState</seealso>
    let ProcessDataState = Prefixed_Name(ioc, "ProcessDataState") |> PrefixedName
    /// <summary>
    ///   <para>ioc:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The generic class process serves as the central element of the construction process ontology. It can represent a classical process or a subfield common in some definitions such as an activity or a task. Due to the problem of the subjectivity of classifications of the term, no further distinction will be made here.</para>
    /// labels<para>Process</para></remarks>
    /// <seealso href="http://w3id.org/ioc#Process">http://w3id.org/ioc#Process</seealso>
    let Process = Prefixed_Name(ioc, "Process") |> PrefixedName

    /// <summary>
    ///   <para>ioc:hasOutputInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property for connecting a version of a piece of information or a infromation container to a process which was transformed by the process</para>
    /// labels<para>hasOutputInformation</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasOutputInformation">http://w3id.org/ioc#hasOutputInformation</seealso>
    let hasOutputInformation =
        Prefixed_Name(ioc, "hasOutputInformation") |> PrefixedName

    /// <summary>
    ///   <para>ioc:CurrentProcessDataState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The current Intermediate Node which helps to add metadata to the object property connecting the Process to its sepcific ProcessData. Functionality adapted form opm ontology.</para>
    /// labels<para>CurrentProcessDataState</para></remarks>
    /// <seealso href="http://w3id.org/ioc#CurrentProcessDataState">http://w3id.org/ioc#CurrentProcessDataState</seealso>
    let CurrentProcessDataState =
        Prefixed_Name(ioc, "CurrentProcessDataState") |> PrefixedName

    /// <summary>
    ///   <para>ioc:ProcessData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/ioc#ProcessData">http://w3id.org/ioc#ProcessData</seealso>
    let ProcessData = Prefixed_Name(ioc, "ProcessData") |> PrefixedName
    /// <summary>
    ///   <para>ioc:generatedByActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>The ioc:Actor that generated the information branch</para>
    /// labels<para>generatedByActor</para></remarks>
    /// <seealso href="http://w3id.org/ioc#generatedByActor">http://w3id.org/ioc#generatedByActor</seealso>
    let generatedByActor = Prefixed_Name(ioc, "generatedByActor") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Generic Property to connect ProcessDataStates, which can be versioned, to the actual classes that describe ProcessData.</para>
    /// labels<para>hasValue</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasValue">http://w3id.org/ioc#hasValue</seealso>
    let hasValue = Prefixed_Name(ioc, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>The version of a capability a resource inherits</para>
    /// labels<para>hasCapability</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasCapability">http://w3id.org/ioc#hasCapability</seealso>
    let hasCapability = Prefixed_Name(ioc, "hasCapability") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasProcessDataState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Generalized property to connect a process to a dynamic, version of its process data.</para>
    /// labels<para>hasProcessDataState</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasProcessDataState">http://w3id.org/ioc#hasProcessDataState</seealso>
    let hasProcessDataState = Prefixed_Name(ioc, "hasProcessDataState") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Points to a version of an element grouping</para>
    /// labels<para>hasElement</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasElement">http://w3id.org/ioc#hasElement</seealso>
    let hasElement = Prefixed_Name(ioc, "hasElement") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasChild</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Child process of a process. A process can have a undeifned number of children</para>
    /// labels<para>hasChild</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasChild">http://w3id.org/ioc#hasChild</seealso>
    let hasChild = Prefixed_Name(ioc, "hasChild") |> PrefixedName

    /// <summary>
    ///   <para>ioc:hasInternalProcessMark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A optional, internal process mark that can be used to add custom functionality to the process model</para>
    /// labels<para>hasInternalProcessMark</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasInternalProcessMark">http://w3id.org/ioc#hasInternalProcessMark</seealso>
    let hasInternalProcessMark =
        Prefixed_Name(ioc, "hasInternalProcessMark") |> PrefixedName

    /// <summary>
    ///   <para>ioc:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property to connect a element, resource or spatial zone.</para>
    /// labels<para>hasLocation</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasLocation">http://w3id.org/ioc#hasLocation</seealso>
    let hasLocation = Prefixed_Name(ioc, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Parent of a Process. A Process can at most have one parent.</para>
    /// labels<para>hasParent</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasParent">http://w3id.org/ioc#hasParent</seealso>
    let hasParent = Prefixed_Name(ioc, "hasParent") |> PrefixedName

    /// <summary>
    ///   <para>ioc:hasCapabilityRequirementValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>object property to link a specific version of an capability requirement  to one or more capabilities describring a process requirement</para>
    /// labels<para>hasCapabilityRequirementValue</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasCapabilityRequirementValue">http://w3id.org/ioc#hasCapabilityRequirementValue</seealso>
    let hasCapabilityRequirementValue =
        Prefixed_Name(ioc, "hasCapabilityRequirementValue") |> PrefixedName

    /// <summary>
    ///   <para>ioc:hasElementValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>object property to link a specific version of an Element  to one or more elements</para>
    /// labels<para>hasElementValue</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasElementValue">http://w3id.org/ioc#hasElementValue</seealso>
    let hasElementValue = Prefixed_Name(ioc, "hasElementValue") |> PrefixedName

    /// <summary>
    ///   <para>ioc:hasInputInformationValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>object property to link a specific version of an piece of input information to one or more pieces of information</para>
    /// labels<para>hasInputInformationValue</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasInputInformationValue">http://w3id.org/ioc#hasInputInformationValue</seealso>
    let hasInputInformationValue =
        Prefixed_Name(ioc, "hasInputInformationValue") |> PrefixedName

    /// <summary>
    ///   <para>ioc:isContainedInValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object Property to describe the containment of Locations, Resources or Elements in Spatial Zones from version to instance</para>
    /// labels<para>isContainedInValue</para></remarks>
    /// <seealso href="http://w3id.org/ioc#isContainedInValue">http://w3id.org/ioc#isContainedInValue</seealso>
    let isContainedInValue = Prefixed_Name(ioc, "isContainedInValue") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasPredecessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Logical Predecessor of a process. Must be finished for the process to be ready.</para>
    /// labels<para>hasPredecessor</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasPredecessor">http://w3id.org/ioc#hasPredecessor</seealso>
    let hasPredecessor = Prefixed_Name(ioc, "hasPredecessor") |> PrefixedName
    /// <summary>
    ///   <para>ioc:hasSuccessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Logical Successor of a process. The process must be  finished for the sucessor to be ready.</para>
    /// labels<para>hasSuccessor</para></remarks>
    /// <seealso href="http://w3id.org/ioc#hasSuccessor">http://w3id.org/ioc#hasSuccessor</seealso>
    let hasSuccessor = Prefixed_Name(ioc, "hasSuccessor") |> PrefixedName
