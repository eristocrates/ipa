namespace https.w3id.org.pep.slash

open DoxAletheia.Rdf_Vocabulary

module pep =
    let _namespace_name = "https://w3id.org/pep/"
    /// <summary>
    ///   <see href="https://w3id.org/pep/pep-1.0"></see>
    /// </summary>
    let ``pep-1.0`` = Namespaced_IRI.parse _namespace_name "pep-1.0" |> NamespacedName
    /// <summary>
    /// The description of a process. A process generalizes the concept of `ssn:Sensing` in the SSN ontology, and of `san:Acting` in the SAN ontology. Examples of processes include sensing, acting, planning, or forecasting.
    ///
    /// In the first version of the SSN ontology, `ssn:Process` was a subclass of `dul:Method`.
    ///
    /// A `dul:Method` is a Description that defines or uses concepts in order to guide carrying out actions aimed at a solution with respect to a problem. It is different from a Plan, because plans could be carried out in order to follow a method, but a method can be followed by executing alternative plans.
    /// <see href="https://w3id.org/pep/Process"></see></summary>
    let Process = Namespaced_IRI.parse _namespace_name "Process" |> NamespacedName

    /// <summary>
    /// A process execution is the execution activity that is led by the Process Executor. This concept generalizes ssn:Observation, which describes an activity in the newest versoin of the SSN ontology and is hence now aligned with the O&amp;M concept of Observation.
    ///
    /// A process execution links to:
    ///
    /// - the process executor it is associated to;
    /// - the process method used;
    /// - the input and the output of the process execution.
    ///
    /// <see href="https://w3id.org/pep/ProcessExecution"></see></summary>
    let ProcessExecution =
        Namespaced_IRI.parse _namespace_name "ProcessExecution" |> NamespacedName

    /// <summary>
    /// A Process Executor can execute (implement) processes. A Process Executor may be a physical device, a computational method, a web service, a laboratory setup with a person following a method, or any other thing that can follow a Process. This concept generalizes ssn:Sensor, which in the latest version of the SSN ontology is a subclass of dul:Object. A dul:Object is any physical, social, or mental object, or a substance.
    ///
    /// Prototypical process executors are Sensor, Actuator, Estimator.
    ///
    /// Links to ProcessExecution describe the Executions made.
    ///
    /// Links to Processes define how the executor can make Executions (it may implement several Processes). A Process Executor implements each of the methods used by the Executions it made.
    ///
    /// Other metadata may detail geolocation, vendor, operator, consumed power, etc.
    /// <see href="https://w3id.org/pep/ProcessExecutor"></see></summary>
    let ProcessExecutor =
        Namespaced_IRI.parse _namespace_name "ProcessExecutor" |> NamespacedName

    /// <summary>
    /// The class of Process Executor Containers. They are Web container of Process Execution ressources, where one may operate HTTP POST requests to execute a given process.
    /// <see href="https://w3id.org/pep/ProcessExecutionContainer"></see></summary>
    let ProcessExecutionContainer =
        Namespaced_IRI.parse _namespace_name "ProcessExecutionContainer" |> NamespacedName

    /// <summary>
    /// Relationship between a process executor and an execution it was assigned to.
    /// <see href="https://w3id.org/pep/executed"></see></summary>
    let executed = Namespaced_IRI.parse _namespace_name "executed" |> NamespacedName
    /// <summary>
    /// Relationship between an execution and the agent that made it. This concept generalizes `ssn:observedBy`, which in the first version of the SSN ontology is a sub property of `dul:includesObject`.
    ///
    /// `dul:includesObject` is a relation between situations and objects, e.g. 'this morning I've prepared my coffee and had my fingers burnt' (i.e.: the preparation of my coffee this morning included me).
    /// <see href="https://w3id.org/pep/executedBy"></see></summary>
    let executedBy = Namespaced_IRI.parse _namespace_name "executedBy" |> NamespacedName
    /// <summary>
    /// Relationship between a process execution container and the process executor that controls it.
    /// <see href="https://w3id.org/pep/executor"></see></summary>
    let executor = Namespaced_IRI.parse _namespace_name "executor" |> NamespacedName
    /// <summary>
    /// Links a Process Execution Container to the Process that is executed when one operate a create operation request to it.
    /// <see href="https://w3id.org/pep/forProcess"></see></summary>
    let forProcess = Namespaced_IRI.parse _namespace_name "forProcess" |> NamespacedName
    /// <summary>
    /// Links a process, process executor, or process execution, to some description of their input.
    ///
    /// Intuitively:
    ///
    /// - the input description of some process executor specializes the input description of the process it implements;
    /// - the input description of some process execution specializes both the input description of the process executor that executed it, and of the process  method used.
    ///
    ///
    /// <see href="https://w3id.org/pep/hasInput"></see></summary>
    let hasInput = Namespaced_IRI.parse _namespace_name "hasInput" |> NamespacedName
    /// <summary>
    /// Links a process, process executor, or process execution, to some description of their output.
    ///
    /// Intuitively:
    ///
    /// - the output description of some process executor specializes the output description of the process it implements;
    /// - the output description of some process execution specializes both the output description of the process executor that executed it, and of the process  method used.
    ///
    ///
    /// <see href="https://w3id.org/pep/hasOutput"></see></summary>
    let hasOutput = Namespaced_IRI.parse _namespace_name "hasOutput" |> NamespacedName
    /// <summary>
    /// A relation between an Process Executor and a method it implements. This concept generalizes `ssn:implements`, which in the first version of the SSN ontology is a subproperty of `dul:isDescribedBy`.
    ///
    /// `dul:isDescribedBy` is the relation between an Entity and a Description. A Description gives a unity to a Collection of parts (the components), or constituents, by assigning a Role to each of them in the context of a whole Object (the system).
    /// <see href="https://w3id.org/pep/implements"></see></summary>
    let implements = Namespaced_IRI.parse _namespace_name "implements" |> NamespacedName
    /// <summary>
    /// Relation between a ProcessExecution and the Process it executes. This concept generalizes `ssn:sensingMethodUsed`, which in the first version of the SSN ontology is a sub property of `dul:satisfies`.
    ///
    ///   `dul:satisfies` is a relation between a Situation and a Description, e.g. the execution of a Plan satisfies that plan.
    /// <see href="https://w3id.org/pep/methodUsed"></see></summary>
    let methodUsed = Namespaced_IRI.parse _namespace_name "methodUsed" |> NamespacedName

    /// <summary>
    /// Links a Process Executor to a Web container of Process Execution ressources, where one may operate HTTP POST requests to execute the process.
    /// <see href="https://w3id.org/pep/processExecutionContainer"></see></summary>
    let processExecutionContainer =
        Namespaced_IRI.parse _namespace_name "processExecutionContainer" |> NamespacedName
