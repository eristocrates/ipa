#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pep =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/pep/" "pep"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Process</para>
    ///   <para>rdfs:comment : The description of a process. A process generalizes the concept of `ssn:Sensing` in the SSN ontology, and of `san:Acting` in the SAN ontology. Examples of processes include sensing, acting, planning, or forecasting.
    ///
    /// In the first version of the SSN ontology, `ssn:Process` was a subclass of `dul:Method`.
    ///
    /// A `dul:Method` is a Description that defines or uses concepts in order to guide carrying out actions aimed at a solution with respect to a problem. It is different from a Plan, because plans could be carried out in order to follow a method, but a method can be followed by executing alternative plans.</para>
    ///   <a href="https://w3id.org/pep/Process">pep:Process</a>
    /// </summary>
    let Process = _prefixId.prefix "Process"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Process Execution^^xsd:string</para>
    ///   <para>rdfs:comment : A process execution is the execution activity that is led by the Process Executor. This concept generalizes ssn:Observation, which describes an activity in the newest versoin of the SSN ontology and is hence now aligned with the O&amp;M concept of Observation.
    ///
    /// A process execution links to:
    ///
    /// - the process executor it is associated to;
    /// - the process method used;
    /// - the input and the output of the process execution.
    /// </para>
    ///   <a href="https://w3id.org/pep/ProcessExecution">pep:ProcessExecution</a>
    /// </summary>
    let ProcessExecution = _prefixId.prefix "ProcessExecution"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Process Execution Container^^xsd:string</para>
    ///   <para>rdfs:comment : The class of Process Executor Containers. They are Web container of Process Execution ressources, where one may operate HTTP POST requests to execute a given process.</para>
    ///   <a href="https://w3id.org/pep/ProcessExecutionContainer">pep:ProcessExecutionContainer</a>
    /// </summary>
    let ProcessExecutionContainer = _prefixId.prefix "ProcessExecutionContainer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Process Executor^^xsd:string</para>
    ///   <para>rdfs:comment : A Process Executor can execute (implement) processes. A Process Executor may be a physical device, a computational method, a web service, a laboratory setup with a person following a method, or any other thing that can follow a Process. This concept generalizes ssn:Sensor, which in the latest version of the SSN ontology is a subclass of dul:Object. A dul:Object is any physical, social, or mental object, or a substance.
    ///
    /// Prototypical process executors are Sensor, Actuator, Estimator.
    ///
    /// Links to ProcessExecution describe the Executions made.
    ///
    /// Links to Processes define how the executor can make Executions (it may implement several Processes). A Process Executor implements each of the methods used by the Executions it made.
    ///
    /// Other metadata may detail geolocation, vendor, operator, consumed power, etc.</para>
    ///   <a href="https://w3id.org/pep/ProcessExecutor">pep:ProcessExecutor</a>
    /// </summary>
    let ProcessExecutor = _prefixId.prefix "ProcessExecutor"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : executed^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a process executor and an execution it was assigned to.</para>
    ///   <a href="https://w3id.org/pep/executed">pep:executed</a>
    /// </summary>
    let executed = _prefixId.prefix "executed"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : executed by^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an execution and the agent that made it. This concept generalizes `ssn:observedBy`, which in the first version of the SSN ontology is a sub property of `dul:includesObject`.
    ///
    /// `dul:includesObject` is a relation between situations and objects, e.g. 'this morning I've prepared my coffee and had my fingers burnt' (i.e.: the preparation of my coffee this morning included me).</para>
    ///   <a href="https://w3id.org/pep/executedBy">pep:executedBy</a>
    /// </summary>
    let executedBy = _prefixId.prefix "executedBy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : executor^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a process execution container and the process executor that controls it.</para>
    ///   <a href="https://w3id.org/pep/executor">pep:executor</a>
    /// </summary>
    let executor = _prefixId.prefix "executor"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : for process^^xsd:string</para>
    ///   <para>rdfs:comment : Links a Process Execution Container to the Process that is executed when one operate a create operation request to it.</para>
    ///   <a href="https://w3id.org/pep/forProcess">pep:forProcess</a>
    /// </summary>
    let forProcess = _prefixId.prefix "forProcess"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has input^^xsd:string</para>
    ///   <para>rdfs:comment : Links a process, process executor, or process execution, to some description of their input.
    ///
    /// Intuitively:
    ///
    /// - the input description of some process executor specializes the input description of the process it implements;
    /// - the input description of some process execution specializes both the input description of the process executor that executed it, and of the process  method used.
    ///
    /// </para>
    ///   <a href="https://w3id.org/pep/hasInput">pep:hasInput</a>
    /// </summary>
    let hasInput = _prefixId.prefix "hasInput"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has output^^xsd:string</para>
    ///   <para>rdfs:comment : Links a process, process executor, or process execution, to some description of their output.
    ///
    /// Intuitively:
    ///
    /// - the output description of some process executor specializes the output description of the process it implements;
    /// - the output description of some process execution specializes both the output description of the process executor that executed it, and of the process  method used.
    ///
    /// </para>
    ///   <a href="https://w3id.org/pep/hasOutput">pep:hasOutput</a>
    /// </summary>
    let hasOutput = _prefixId.prefix "hasOutput"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : implements^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between an Process Executor and a method it implements. This concept generalizes `ssn:implements`, which in the first version of the SSN ontology is a subproperty of `dul:isDescribedBy`.
    ///
    /// `dul:isDescribedBy` is the relation between an Entity and a Description. A Description gives a unity to a Collection of parts (the components), or constituents, by assigning a Role to each of them in the context of a whole Object (the system).</para>
    ///   <a href="https://w3id.org/pep/implements">pep:implements</a>
    /// </summary>
    let implements = _prefixId.prefix "implements"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : method used^^xsd:string</para>
    ///   <para>rdfs:comment : Relation between a ProcessExecution and the Process it executes. This concept generalizes `ssn:sensingMethodUsed`, which in the first version of the SSN ontology is a sub property of `dul:satisfies`.
    ///
    ///   `dul:satisfies` is a relation between a Situation and a Description, e.g. the execution of a Plan satisfies that plan.</para>
    ///   <a href="https://w3id.org/pep/methodUsed">pep:methodUsed</a>
    /// </summary>
    let methodUsed = _prefixId.prefix "methodUsed"
    let ``pep_1.0`` = _prefixId.prefix "pep-1.0"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : process execution container^^xsd:string</para>
    ///   <para>rdfs:comment : Links a Process Executor to a Web container of Process Execution ressources, where one may operate HTTP POST requests to execute the process.</para>
    ///   <a href="https://w3id.org/pep/processExecutionContainer">pep:processExecutionContainer</a>
    /// </summary>
    let processExecutionContainer = _prefixId.prefix "processExecutionContainer"
