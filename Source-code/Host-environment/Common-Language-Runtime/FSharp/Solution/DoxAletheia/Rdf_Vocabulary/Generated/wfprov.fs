namespace http.purl.org.wf4ever.wfprov.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wfprov =
    let _namespace_iri = Namespace_Iri wfprov |> NamespaceIRI
    /// <summary>
    ///   <para>wfprov:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfprov#">http://purl.org/wf4ever/wfprov#</seealso>
    let _prefix_iri = Prefixed_Name(wfprov, "") |> PrefixedName
    /// <summary>
    ///   <para>wfprov:Artifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Artifact is a general concept that represents immutable piece of state, which may have a physical embodiment in a physical object, or a digital representation in a computer system. In the case of wfprov, an artifact is used as input to a process run, or produced by the output of a process run."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/wf4ever/wfprov#Artifact">http://purl.org/wf4ever/wfprov#Artifact</seealso>
    let Artifact = Prefixed_Name(wfprov, "Artifact") |> PrefixedName
    /// <summary>
    ///   <para>wfprov:ProcessRun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A process run is a particular execution of a wfdesc:Process description (wfprov:describedByProcess), which can wfprov:usedInput some wfprov:Artifact instances, and produce new artifacts (wfprov:wasOutputFrom). A wfprov:WorkflowRun is a specialisation of this class."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/wf4ever/wfprov#ProcessRun">http://purl.org/wf4ever/wfprov#ProcessRun</seealso>
    let ProcessRun = Prefixed_Name(wfprov, "ProcessRun") |> PrefixedName
    /// <summary>
    ///   <para>wfprov:WorkflowEngine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A workflow engine is an foaf:Agent that is responsible for enacting a workflow definition (which could be described in a wfdesc:Workflow). The result of workflow enactment gives rise to a wfprov:WorkflowRun."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/wf4ever/wfprov#WorkflowEngine">http://purl.org/wf4ever/wfprov#WorkflowEngine</seealso>
    let WorkflowEngine = Prefixed_Name(wfprov, "WorkflowEngine") |> PrefixedName
    /// <summary>
    ///   <para>wfprov:WorkflowRun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A workflow run is a wfprov:ProcessRun which have been enacted by a wfprov:WorkflowEngine, according to a workflow definition (which could be wfdesc:describedByWorkflow a wfdesc:Workflow). Such a process typically contains several subprocesses (wfprov:wasPartOfWorkflowRun) corresponding to wfdesc:Process descriptions"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/wf4ever/wfprov#WorkflowRun">http://purl.org/wf4ever/wfprov#WorkflowRun</seealso>
    let WorkflowRun = Prefixed_Name(wfprov, "WorkflowRun") |> PrefixedName

    /// <summary>
    ///   <para>wfprov:describedByParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This object property is used to associate a wfprov:Artifact to the wfdesc:Parameter description."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/wf4ever/wfprov#describedByParameter">http://purl.org/wf4ever/wfprov#describedByParameter</seealso>
    let describedByParameter =
        Prefixed_Name(wfprov, "describedByParameter") |> PrefixedName

    /// <summary>
    ///   <para>wfprov:describedByProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This object property associate a wfprov:Processrun to its wfdesc:Process description ."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/wf4ever/wfprov#describedByProcess">http://purl.org/wf4ever/wfprov#describedByProcess</seealso>
    let describedByProcess = Prefixed_Name(wfprov, "describedByProcess") |> PrefixedName

    /// <summary>
    ///   <para>wfprov:describedByWorkflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property associates a wfprov:WorkflowRun to its corresponding wfdesc:Workflow description."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/wf4ever/wfprov#describedByWorkflow">http://purl.org/wf4ever/wfprov#describedByWorkflow</seealso>
    let describedByWorkflow =
        Prefixed_Name(wfprov, "describedByWorkflow") |> PrefixedName

    /// <summary>
    ///   <para>wfprov:usedInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies that a wfprov:ProcessRun used an wfprov:Artifact as an input"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/wf4ever/wfprov#usedInput">http://purl.org/wf4ever/wfprov#usedInput</seealso>
    let usedInput = Prefixed_Name(wfprov, "usedInput") |> PrefixedName
    /// <summary>
    ///   <para>wfprov:wasEnactedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"wfprov:wasEnactedBy associates a wfprov:ProcessRun with a wfprov:WorkflowEngine, specifying that the execution of the process was enacted by the engine."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/wf4ever/wfprov#wasEnactedBy">http://purl.org/wf4ever/wfprov#wasEnactedBy</seealso>
    let wasEnactedBy = Prefixed_Name(wfprov, "wasEnactedBy") |> PrefixedName
    /// <summary>
    ///   <para>wfprov:wasOutputFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies that a wfprov:Artifact was generated as an output from a wfprov:ProcessRun"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/wf4ever/wfprov#wasOutputFrom">http://purl.org/wf4ever/wfprov#wasOutputFrom</seealso>
    let wasOutputFrom = Prefixed_Name(wfprov, "wasOutputFrom") |> PrefixedName

    /// <summary>
    ///   <para>wfprov:wasPartOfWorkflowRun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies that a wfprov:ProcessRun was executed as part of a wfprov:WorkflowRun. This typically corresponds to wfdesc:hasSubProcess in the workflow description."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/wf4ever/wfprov#wasPartOfWorkflowRun">http://purl.org/wf4ever/wfprov#wasPartOfWorkflowRun</seealso>
    let wasPartOfWorkflowRun =
        Prefixed_Name(wfprov, "wasPartOfWorkflowRun") |> PrefixedName

    /// <summary>
    ///   <para>wfprov:workflowRun</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfprov#workflowRun">http://purl.org/wf4ever/wfprov#workflowRun</seealso>
    let workflowRun = Prefixed_Name(wfprov, "workflowRun") |> PrefixedName
