#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module wfprov =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/wf4ever/wfprov#" "wfprov"

    /// <summary>
    ///   <para>rdfs:comment : Artifact is a general concept that represents immutable piece of state, which may have a physical embodiment in a physical object, or a digital representation in a computer system. In the case of wfprov, an artifact is used as input to a process run, or produced by the output of a process run.</para>
    ///   <a href="http://purl.org/wf4ever/wfprov#Artifact">wfprov:Artifact</a>
    /// </summary>
    let Artifact = _prefixId.prefix "Artifact"
    /// <summary>
    ///   <para>rdfs:comment : A process run is a particular execution of a wfdesc:Process description (wfprov:describedByProcess), which can wfprov:usedInput some wfprov:Artifact instances, and produce new artifacts (wfprov:wasOutputFrom). A wfprov:WorkflowRun is a specialisation of this class.</para>
    ///   <a href="http://purl.org/wf4ever/wfprov#ProcessRun">wfprov:ProcessRun</a>
    /// </summary>
    let ProcessRun = _prefixId.prefix "ProcessRun"
    /// <summary>
    ///   <para>rdfs:comment : A workflow engine is an foaf:Agent that is responsible for enacting a workflow definition (which could be described in a wfdesc:Workflow). The result of workflow enactment gives rise to a wfprov:WorkflowRun.</para>
    ///   <a href="http://purl.org/wf4ever/wfprov#WorkflowEngine">wfprov:WorkflowEngine</a>
    /// </summary>
    let WorkflowEngine = _prefixId.prefix "WorkflowEngine"
    /// <summary>
    ///   <para>rdfs:comment : A workflow run is a wfprov:ProcessRun which have been enacted by a wfprov:WorkflowEngine, according to a workflow definition (which could be wfdesc:describedByWorkflow a wfdesc:Workflow). Such a process typically contains several subprocesses (wfprov:wasPartOfWorkflowRun) corresponding to wfdesc:Process descriptions</para>
    ///   <a href="http://purl.org/wf4ever/wfprov#WorkflowRun">wfprov:WorkflowRun</a>
    /// </summary>
    let WorkflowRun = _prefixId.prefix "WorkflowRun"
    /// <summary>
    ///   <para>rdfs:comment : This object property is used to associate a wfprov:Artifact to the wfdesc:Parameter description.</para>
    ///   <a href="http://purl.org/wf4ever/wfprov#describedByParameter">wfprov:describedByParameter</a>
    /// </summary>
    let describedByParameter = _prefixId.prefix "describedByParameter"
    /// <summary>
    ///   <para>rdfs:comment : This object property associate a wfprov:Processrun to its wfdesc:Process description .</para>
    ///   <a href="http://purl.org/wf4ever/wfprov#describedByProcess">wfprov:describedByProcess</a>
    /// </summary>
    let describedByProcess = _prefixId.prefix "describedByProcess"
    /// <summary>
    ///   <para>rdfs:comment : This property associates a wfprov:WorkflowRun to its corresponding wfdesc:Workflow description.</para>
    ///   <a href="http://purl.org/wf4ever/wfprov#describedByWorkflow">wfprov:describedByWorkflow</a>
    /// </summary>
    let describedByWorkflow = _prefixId.prefix "describedByWorkflow"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies that a wfprov:ProcessRun used an wfprov:Artifact as an input</para>
    ///   <a href="http://purl.org/wf4ever/wfprov#usedInput">wfprov:usedInput</a>
    /// </summary>
    let usedInput = _prefixId.prefix "usedInput"
    /// <summary>
    ///   <para>rdfs:comment : wfprov:wasEnactedBy associates a wfprov:ProcessRun with a wfprov:WorkflowEngine, specifying that the execution of the process was enacted by the engine.</para>
    ///   <a href="http://purl.org/wf4ever/wfprov#wasEnactedBy">wfprov:wasEnactedBy</a>
    /// </summary>
    let wasEnactedBy = _prefixId.prefix "wasEnactedBy"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies that a wfprov:Artifact was generated as an output from a wfprov:ProcessRun</para>
    ///   <a href="http://purl.org/wf4ever/wfprov#wasOutputFrom">wfprov:wasOutputFrom</a>
    /// </summary>
    let wasOutputFrom = _prefixId.prefix "wasOutputFrom"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies that a wfprov:ProcessRun was executed as part of a wfprov:WorkflowRun. This typically corresponds to wfdesc:hasSubProcess in the workflow description.</para>
    ///   <a href="http://purl.org/wf4ever/wfprov#wasPartOfWorkflowRun">wfprov:wasPartOfWorkflowRun</a>
    /// </summary>
    let wasPartOfWorkflowRun = _prefixId.prefix "wasPartOfWorkflowRun"
    let workflowRun = _prefixId.prefix "workflowRun"
