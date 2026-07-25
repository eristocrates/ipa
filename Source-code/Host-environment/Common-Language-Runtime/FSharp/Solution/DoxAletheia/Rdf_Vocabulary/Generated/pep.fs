namespace https.w3id.org.pep.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pep =
    let _namespace_iri = Namespace_Iri pep |> NamespaceIRI
    /// <summary>
    ///   <para>pep:pep-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/pep/pep-1.0">https://w3id.org/pep/pep-1.0</seealso>
    let ``pep_1.0`` = Prefixed_Name(pep, "pep-1.0") |> PrefixedName
    /// <summary>
    ///   <para>pep:ProcessExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process execution is the execution activity that is led by the Process Executor. This concept generalizes ssn:Observation, which describes an activity in the newest versoin of the SSN ontology and is hence now aligned with the O&amp;M concept of Observation.
    ///
    /// A process execution links to:
    ///
    /// - the process executor it is associated to;
    /// - the process method used;
    /// - the input and the output of the process execution.
    /// </para>
    /// labels<para>Process Execution</para></remarks>
    /// <seealso href="https://w3id.org/pep/ProcessExecution">https://w3id.org/pep/ProcessExecution</seealso>
    let ProcessExecution = Prefixed_Name(pep, "ProcessExecution") |> PrefixedName

    /// <summary>
    ///   <para>pep:ProcessExecutionContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The class of Process Executor Containers. They are Web container of Process Execution ressources, where one may operate HTTP POST requests to execute a given process.</para>
    /// labels<para>Process Execution Container</para></remarks>
    /// <seealso href="https://w3id.org/pep/ProcessExecutionContainer">https://w3id.org/pep/ProcessExecutionContainer</seealso>
    let ProcessExecutionContainer =
        Prefixed_Name(pep, "ProcessExecutionContainer") |> PrefixedName

    /// <summary>
    ///   <para>pep:executed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a process executor and an execution it was assigned to.</para>
    /// labels<para>executed</para></remarks>
    /// <seealso href="https://w3id.org/pep/executed">https://w3id.org/pep/executed</seealso>
    let executed = Prefixed_Name(pep, "executed") |> PrefixedName
    /// <summary>
    ///   <para>pep:executedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Relationship between an execution and the agent that made it. This concept generalizes `ssn:observedBy`, which in the first version of the SSN ontology is a sub property of `dul:includesObject`.
    ///
    /// `dul:includesObject` is a relation between situations and objects, e.g. 'this morning I've prepared my coffee and had my fingers burnt' (i.e.: the preparation of my coffee this morning included me).</para>
    /// labels<para>executed by</para></remarks>
    /// <seealso href="https://w3id.org/pep/executedBy">https://w3id.org/pep/executedBy</seealso>
    let executedBy = Prefixed_Name(pep, "executedBy") |> PrefixedName
    /// <summary>
    ///   <para>pep:hasInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Links a process, process executor, or process execution, to some description of their input.
    ///
    /// Intuitively:
    ///
    /// - the input description of some process executor specializes the input description of the process it implements;
    /// - the input description of some process execution specializes both the input description of the process executor that executed it, and of the process  method used.
    ///
    /// </para>
    /// labels<para>has input</para></remarks>
    /// <seealso href="https://w3id.org/pep/hasInput">https://w3id.org/pep/hasInput</seealso>
    let hasInput = Prefixed_Name(pep, "hasInput") |> PrefixedName
    /// <summary>
    ///   <para>pep:methodUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a ProcessExecution and the Process it executes. This concept generalizes `ssn:sensingMethodUsed`, which in the first version of the SSN ontology is a sub property of `dul:satisfies`.
    ///
    ///   `dul:satisfies` is a relation between a Situation and a Description, e.g. the execution of a Plan satisfies that plan.</para>
    /// labels<para>method used</para></remarks>
    /// <seealso href="https://w3id.org/pep/methodUsed">https://w3id.org/pep/methodUsed</seealso>
    let methodUsed = Prefixed_Name(pep, "methodUsed") |> PrefixedName
    /// <summary>
    ///   <para>pep:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>foaf:Document</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pep/">https://w3id.org/pep/</seealso>
    let _prefix_iri = Prefixed_Name(pep, "") |> PrefixedName
    /// <summary>
    ///   <para>pep:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The description of a process. A process generalizes the concept of `ssn:Sensing` in the SSN ontology, and of `san:Acting` in the SAN ontology. Examples of processes include sensing, acting, planning, or forecasting.
    ///
    /// In the first version of the SSN ontology, `ssn:Process` was a subclass of `dul:Method`.
    ///
    /// A `dul:Method` is a Description that defines or uses concepts in order to guide carrying out actions aimed at a solution with respect to a problem. It is different from a Plan, because plans could be carried out in order to follow a method, but a method can be followed by executing alternative plans.</para>
    /// labels<para>Process</para></remarks>
    /// <seealso href="https://w3id.org/pep/Process">https://w3id.org/pep/Process</seealso>
    let Process = Prefixed_Name(pep, "Process") |> PrefixedName
    /// <summary>
    ///   <para>pep:ProcessExecutor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Process Executor can execute (implement) processes. A Process Executor may be a physical device, a computational method, a web service, a laboratory setup with a person following a method, or any other thing that can follow a Process. This concept generalizes ssn:Sensor, which in the latest version of the SSN ontology is a subclass of dul:Object. A dul:Object is any physical, social, or mental object, or a substance.
    ///
    /// Prototypical process executors are Sensor, Actuator, Estimator.
    ///
    /// Links to ProcessExecution describe the Executions made.
    ///
    /// Links to Processes define how the executor can make Executions (it may implement several Processes). A Process Executor implements each of the methods used by the Executions it made.
    ///
    /// Other metadata may detail geolocation, vendor, operator, consumed power, etc.</para>
    /// labels<para>Process Executor</para></remarks>
    /// <seealso href="https://w3id.org/pep/ProcessExecutor">https://w3id.org/pep/ProcessExecutor</seealso>
    let ProcessExecutor = Prefixed_Name(pep, "ProcessExecutor") |> PrefixedName
    /// <summary>
    ///   <para>pep:executor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a process execution container and the process executor that controls it.</para>
    /// labels<para>executor</para></remarks>
    /// <seealso href="https://w3id.org/pep/executor">https://w3id.org/pep/executor</seealso>
    let executor = Prefixed_Name(pep, "executor") |> PrefixedName
    /// <summary>
    ///   <para>pep:forProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a Process Execution Container to the Process that is executed when one operate a create operation request to it.</para>
    /// labels<para>for process</para></remarks>
    /// <seealso href="https://w3id.org/pep/forProcess">https://w3id.org/pep/forProcess</seealso>
    let forProcess = Prefixed_Name(pep, "forProcess") |> PrefixedName
    /// <summary>
    ///   <para>pep:hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a process, process executor, or process execution, to some description of their output.
    ///
    /// Intuitively:
    ///
    /// - the output description of some process executor specializes the output description of the process it implements;
    /// - the output description of some process execution specializes both the output description of the process executor that executed it, and of the process  method used.
    ///
    /// </para>
    /// labels<para>has output</para></remarks>
    /// <seealso href="https://w3id.org/pep/hasOutput">https://w3id.org/pep/hasOutput</seealso>
    let hasOutput = Prefixed_Name(pep, "hasOutput") |> PrefixedName
    /// <summary>
    ///   <para>pep:implements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between an Process Executor and a method it implements. This concept generalizes `ssn:implements`, which in the first version of the SSN ontology is a subproperty of `dul:isDescribedBy`.
    ///
    /// `dul:isDescribedBy` is the relation between an Entity and a Description. A Description gives a unity to a Collection of parts (the components), or constituents, by assigning a Role to each of them in the context of a whole Object (the system).</para>
    /// labels<para>implements</para></remarks>
    /// <seealso href="https://w3id.org/pep/implements">https://w3id.org/pep/implements</seealso>
    let implements = Prefixed_Name(pep, "implements") |> PrefixedName

    /// <summary>
    ///   <para>pep:processExecutionContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a Process Executor to a Web container of Process Execution ressources, where one may operate HTTP POST requests to execute the process.</para>
    /// labels<para>process execution container</para></remarks>
    /// <seealso href="https://w3id.org/pep/processExecutionContainer">https://w3id.org/pep/processExecutionContainer</seealso>
    let processExecutionContainer =
        Prefixed_Name(pep, "processExecutionContainer") |> PrefixedName
