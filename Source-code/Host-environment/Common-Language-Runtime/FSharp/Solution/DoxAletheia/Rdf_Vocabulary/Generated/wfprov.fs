namespace http.purl.org.wf4ever.wfprov.hash

open DoxAletheia

module wfprov =
    let _namespace_name = "http://purl.org/wf4ever/wfprov#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Artifact is a general concept that represents immutable piece of state, which may have a physical embodiment in a physical object, or a digital representation in a computer system. In the case of wfprov, an artifact is used as input to a process run, or produced by the output of a process run.
    /// <see href="http://purl.org/wf4ever/wfprov#Artifact"></see></summary>
    let Artifact = _prefix "Artifact"
    /// <summary>
    /// A process run is a particular execution of a wfdesc:Process description (wfprov:describedByProcess), which can wfprov:usedInput some wfprov:Artifact instances, and produce new artifacts (wfprov:wasOutputFrom). A wfprov:WorkflowRun is a specialisation of this class.
    /// <see href="http://purl.org/wf4ever/wfprov#ProcessRun"></see></summary>
    let ProcessRun = _prefix "ProcessRun"
    /// <summary>
    /// This property specifies that a wfprov:ProcessRun used an wfprov:Artifact as an input
    /// <see href="http://purl.org/wf4ever/wfprov#usedInput"></see></summary>
    let usedInput = _prefix "usedInput"
    /// <summary>
    /// This property specifies that a wfprov:Artifact was generated as an output from a wfprov:ProcessRun
    /// <see href="http://purl.org/wf4ever/wfprov#wasOutputFrom"></see></summary>
    let wasOutputFrom = _prefix "wasOutputFrom"
    /// <summary>
    ///   <see href="http://purl.org/wf4ever/wfprov#workflowRun"></see>
    /// </summary>
    let workflowRun = _prefix "workflowRun"
    /// <summary>
    /// A workflow run is a wfprov:ProcessRun which have been enacted by a wfprov:WorkflowEngine, according to a workflow definition (which could be wfdesc:describedByWorkflow a wfdesc:Workflow). Such a process typically contains several subprocesses (wfprov:wasPartOfWorkflowRun) corresponding to wfdesc:Process descriptions
    /// <see href="http://purl.org/wf4ever/wfprov#WorkflowRun"></see></summary>
    let WorkflowRun = _prefix "WorkflowRun"
    /// <summary>
    /// This object property associate a wfprov:Processrun to its wfdesc:Process description .
    /// <see href="http://purl.org/wf4ever/wfprov#describedByProcess"></see></summary>
    let describedByProcess = _prefix "describedByProcess"
    /// <summary>
    /// A workflow engine is an foaf:Agent that is responsible for enacting a workflow definition (which could be described in a wfdesc:Workflow). The result of workflow enactment gives rise to a wfprov:WorkflowRun.
    /// <see href="http://purl.org/wf4ever/wfprov#WorkflowEngine"></see></summary>
    let WorkflowEngine = _prefix "WorkflowEngine"
    /// <summary>
    /// This object property is used to associate a wfprov:Artifact to the wfdesc:Parameter description.
    /// <see href="http://purl.org/wf4ever/wfprov#describedByParameter"></see></summary>
    let describedByParameter = _prefix "describedByParameter"
    /// <summary>
    /// This property associates a wfprov:WorkflowRun to its corresponding wfdesc:Workflow description.
    /// <see href="http://purl.org/wf4ever/wfprov#describedByWorkflow"></see></summary>
    let describedByWorkflow = _prefix "describedByWorkflow"
    /// <summary>
    /// wfprov:wasEnactedBy associates a wfprov:ProcessRun with a wfprov:WorkflowEngine, specifying that the execution of the process was enacted by the engine.
    /// <see href="http://purl.org/wf4ever/wfprov#wasEnactedBy"></see></summary>
    let wasEnactedBy = _prefix "wasEnactedBy"
    /// <summary>
    /// This property specifies that a wfprov:ProcessRun was executed as part of a wfprov:WorkflowRun. This typically corresponds to wfdesc:hasSubProcess in the workflow description.
    /// <see href="http://purl.org/wf4ever/wfprov#wasPartOfWorkflowRun"></see></summary>
    let wasPartOfWorkflowRun = _prefix "wasPartOfWorkflowRun"
