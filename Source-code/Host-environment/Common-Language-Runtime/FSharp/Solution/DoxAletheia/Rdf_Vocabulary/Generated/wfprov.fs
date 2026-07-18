namespace http.purl.org.wf4ever.wfprov.hash

open DoxAletheia.Rdf_Vocabulary

module wfprov =
    let _namespace_name = "http://purl.org/wf4ever/wfprov#"
    /// <summary>
    /// Artifact is a general concept that represents immutable piece of state, which may have a physical embodiment in a physical object, or a digital representation in a computer system. In the case of wfprov, an artifact is used as input to a process run, or produced by the output of a process run.
    /// <see href="http://purl.org/wf4ever/wfprov#Artifact"></see></summary>
    let Artifact = Namespaced_IRI.parse _namespace_name "Artifact" |> NamespacedName
    /// <summary>
    /// A process run is a particular execution of a wfdesc:Process description (wfprov:describedByProcess), which can wfprov:usedInput some wfprov:Artifact instances, and produce new artifacts (wfprov:wasOutputFrom). A wfprov:WorkflowRun is a specialisation of this class.
    /// <see href="http://purl.org/wf4ever/wfprov#ProcessRun"></see></summary>
    let ProcessRun = Namespaced_IRI.parse _namespace_name "ProcessRun" |> NamespacedName
    /// <summary>
    /// This property specifies that a wfprov:ProcessRun used an wfprov:Artifact as an input
    /// <see href="http://purl.org/wf4ever/wfprov#usedInput"></see></summary>
    let usedInput = Namespaced_IRI.parse _namespace_name "usedInput" |> NamespacedName

    /// <summary>
    /// This property specifies that a wfprov:Artifact was generated as an output from a wfprov:ProcessRun
    /// <see href="http://purl.org/wf4ever/wfprov#wasOutputFrom"></see></summary>
    let wasOutputFrom =
        Namespaced_IRI.parse _namespace_name "wasOutputFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/wf4ever/wfprov#workflowRun"></see>
    /// </summary>
    let workflowRun =
        Namespaced_IRI.parse _namespace_name "workflowRun" |> NamespacedName

    /// <summary>
    /// A workflow run is a wfprov:ProcessRun which have been enacted by a wfprov:WorkflowEngine, according to a workflow definition (which could be wfdesc:describedByWorkflow a wfdesc:Workflow). Such a process typically contains several subprocesses (wfprov:wasPartOfWorkflowRun) corresponding to wfdesc:Process descriptions
    /// <see href="http://purl.org/wf4ever/wfprov#WorkflowRun"></see></summary>
    let WorkflowRun =
        Namespaced_IRI.parse _namespace_name "WorkflowRun" |> NamespacedName

    /// <summary>
    /// This object property associate a wfprov:Processrun to its wfdesc:Process description .
    /// <see href="http://purl.org/wf4ever/wfprov#describedByProcess"></see></summary>
    let describedByProcess =
        Namespaced_IRI.parse _namespace_name "describedByProcess" |> NamespacedName

    /// <summary>
    /// A workflow engine is an foaf:Agent that is responsible for enacting a workflow definition (which could be described in a wfdesc:Workflow). The result of workflow enactment gives rise to a wfprov:WorkflowRun.
    /// <see href="http://purl.org/wf4ever/wfprov#WorkflowEngine"></see></summary>
    let WorkflowEngine =
        Namespaced_IRI.parse _namespace_name "WorkflowEngine" |> NamespacedName

    /// <summary>
    /// This object property is used to associate a wfprov:Artifact to the wfdesc:Parameter description.
    /// <see href="http://purl.org/wf4ever/wfprov#describedByParameter"></see></summary>
    let describedByParameter =
        Namespaced_IRI.parse _namespace_name "describedByParameter" |> NamespacedName

    /// <summary>
    /// This property associates a wfprov:WorkflowRun to its corresponding wfdesc:Workflow description.
    /// <see href="http://purl.org/wf4ever/wfprov#describedByWorkflow"></see></summary>
    let describedByWorkflow =
        Namespaced_IRI.parse _namespace_name "describedByWorkflow" |> NamespacedName

    /// <summary>
    /// wfprov:wasEnactedBy associates a wfprov:ProcessRun with a wfprov:WorkflowEngine, specifying that the execution of the process was enacted by the engine.
    /// <see href="http://purl.org/wf4ever/wfprov#wasEnactedBy"></see></summary>
    let wasEnactedBy =
        Namespaced_IRI.parse _namespace_name "wasEnactedBy" |> NamespacedName

    /// <summary>
    /// This property specifies that a wfprov:ProcessRun was executed as part of a wfprov:WorkflowRun. This typically corresponds to wfdesc:hasSubProcess in the workflow description.
    /// <see href="http://purl.org/wf4ever/wfprov#wasPartOfWorkflowRun"></see></summary>
    let wasPartOfWorkflowRun =
        Namespaced_IRI.parse _namespace_name "wasPartOfWorkflowRun" |> NamespacedName
