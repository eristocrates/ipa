namespace http.purl.org.wf4ever.wfdesc.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wfdesc =
    let _namespace_iri = Namespace_Iri wfdesc |> NamespaceIRI
    /// <summary>
    ///   <para>wfdesc:Parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represent a parameter of a wfdesc:Process. A wfdesc:Parameter must be a wfdesc:Input, a wfdesc:Output, or a wfdesc:Configuration.
    ///
    /// Note that a parameter MAY be both an wfdesc:Input and wfdesc:Output when it is used on both sides of a subworkflow - see wfdesc:Workflow and wfdesc:DataLink for details.
    ///
    /// A wfdesc:Configuration MAY also be a wfdesc:Input, indicating that the configuration is of a dynamic nature, decided by the workflow.</para>
    /// labels<para>Parameter</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#Parameter">http://purl.org/wf4ever/wfdesc#Parameter</seealso>
    let Parameter = Prefixed_Name(wfdesc, "Parameter") |> PrefixedName

    /// <summary>
    ///   <para>wfdesc:ProcessImplementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The implementation that is invoked when running the wfdesc:Process, like a wf4ever:Script or wf4ever:WebService.
    ///
    /// The process specifies the implementation using wfdesc:hasImplementation.</para>
    /// labels<para>Process Implementation</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#ProcessImplementation">http://purl.org/wf4ever/wfdesc#ProcessImplementation</seealso>
    let ProcessImplementation =
        Prefixed_Name(wfdesc, "ProcessImplementation") |> PrefixedName

    /// <summary>
    ///   <para>wfdesc:Workflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A wfdesc:Workflow is a directed graph in which the nodes are wfdesc:Process instances and the edges (wfdesc:DataLink instances) represent data dependencies between the constituent wfdesc:Process descriptions.
    ///
    /// The resource that contains the wfdesc:WorkflowDefinition (say the XML file saved from a workflow designer tool) can be specified with wfdesc:hasWorkflowDefinition. Research objects might aggregate a wfdesc:Workflow, a wfdesc:WorkflowDefinition, or (recommended) both.
    ///
    /// A wfdesc:Workflow defines associated wfdesc:Process using wfdesc:hasSubProcess. A specialisation of this property is wfdesc:hasSubWorkflow, signifying that the process is a wfdesc:Workflow itself, which is further described in a similar fashion.
    ///
    /// As a subclass of wfdesc:Process a wfdesc:Workflow can also define wfdesc:hasInput/wfdesc:hasOutput parameters - these would be inputs taken at workflow execution time, and final outputs of the workflow. (Note: Not all dataflow systems have this concept of workflow parameters)
    ///
    /// wfdesc:Parameter descriptions are linked using wfdesc:DataLink descriptions associated with the wfdesc:Workflow using wfdesc:hasDataLink.
    ///
    /// A wfdesc:Parameter defined with wfdesc:hasInput on a wfdesc:Workflow is considered an wfdesc:Input "outside" the workflow (ie. if it is a subworkflow), but an wfdesc:Output "inside" the workflow (where it can be connected to a wfdesc:Input of a wfdesc:Process). Thus such parameters can be linked "through" the workflow without having a "mirrored" port inside.
    ///
    ///
    /// Example:
    ///
    /// ```
    /// @prefix wfdesc: &lt;http://purl.org/wf4ever/wfdesc#&gt; .
    /// :outerWorkflow a wfdesc:Workflow ;
    ///   wfdesc:hasSubWorkflow :innerWorkflow ;
    ///   wfdesc:hasSubProcess :procA, :procC .
    ///
    /// :procA a wfdesc:Process ;
    ///   wfdesc:hasOutput :param1 .
    ///
    /// :procC a wfdesc:Process ;
    ///   wfdesc:hasInput :param2 ;
    ///   wfdesc:hasOutput :param3 .
    ///
    ///
    /// :innerWorkflow a wfdesc:Workflow ;
    ///   wfdesc:hasInput :param4 ;
    ///   wfdesc:hasOutput :param5 ;
    ///   wfdesc:hasProcess :procB .
    ///
    /// :procB a wfdesc:Process ;
    ///   wfdesc:hasInput :param6 ;
    ///   wfdesc:hasOutput :param7 .
    ///
    /// :innerWorkflow wfdesc:hasDataLink
    ///    [ wfdesc:hasSource :param4; wfdesc:hasSink :param6 ],
    ///    [ wfdesc:hasSource :param7; wfdesc:hasSink :param5 ] .
    ///
    /// :outerWorkflow wfdesc:hasDataLink
    ///   [ wfdesc:hasSource :param1; wfdesc:hasSink :param4 ],
    ///   [ wfdesc:hasSource :param5; wfdesc:hasSink :param2 ] .
    /// ```
    ///
    ///
    /// In this example :param1 is the output of :procA. :param1 is the source in a datalink that goes to the input :param4 of the :innerWorkflow. :param4 is however also the source of an inner datalink, going to input :param6 of the nested :procB.
    ///
    /// From this :param4 is both an wfdesc:Input and wfdesc:Output (which is why these two classes are not disjoint)</para>
    /// labels<para>Workflow</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#Workflow">http://purl.org/wf4ever/wfdesc#Workflow</seealso>
    let Workflow = Prefixed_Name(wfdesc, "Workflow") |> PrefixedName
    /// <summary>
    ///   <para>wfdesc:Artifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>wfdesc:Artifact is used to provide information about a class of artifacts. For example, it can be used to specify the datatype of a dataset or the structure of a document.
    ///
    /// An wfdesc:Artifact is associated with a wfdesc:Parameter using wfdesc:hasArtifact.
    ///
    /// The distinction between a parameter and artifact is that the parameter can be customized to describe the particular role the artifact plays with regards to the process (and can be linked using wfdesc:DataLink) - while the wfdesc:Artifact can describe the syntactic and semantic datatype.</para>
    /// labels<para>Artifact</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#Artifact">http://purl.org/wf4ever/wfdesc#Artifact</seealso>
    let Artifact = Prefixed_Name(wfdesc, "Artifact") |> PrefixedName
    /// <summary>
    ///   <para>wfdesc:Configuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A configuration is a kind of parameter to a wfdesc:Process (linked using wfdesc:hasConfiguration) to indicate a setting, flag or customization which somewhat modifies or controls the behaviour of the wfdesc:Process.
    ///
    /// Different workflow systems have stronger or weaker differentiation between inputs and configurations, so a wfdesc:Configuration MAY also be a wfdesc:Input in the case of a dynamic configuration provided by the workflow itself.
    ///
    /// Note that attributes which define or specify the process to invoke, like a wf4ever:script, or a wf4ever:serviceURI of a wf4ever:WebService, are not normally considered Configurations.</para>
    /// labels<para>Configuration</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#Configuration">http://purl.org/wf4ever/wfdesc#Configuration</seealso>
    let Configuration = Prefixed_Name(wfdesc, "Configuration") |> PrefixedName
    /// <summary>
    ///   <para>wfdesc:DataLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>wfdesc:DataLink is used to represent data dependencies between wfdesc:Process descriptions. It means that the artifact generated at an wfdesc:Output (identified using wfdesc:hasSource) will be used by a wfdescInput (identified using wfdesc:hasSink).
    ///
    /// The wfdesc:Processes that owns the wfdesc:Parameter instances which are the source and sink of a wfdesc:DataLink must be wfdesc:hasSubProcess of a the same wfdesc:Workflow which wfdesc:hasDataLink the data link, or be be parameters of that same workflow.
    ///
    /// Thus links can only be made within a wfdesc:Workflow - although ports owned by the workflow itself appear both inside and outside the workflow (in opposite roles).</para>
    /// labels<para>Data Link</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#DataLink">http://purl.org/wf4ever/wfdesc#DataLink</seealso>
    let DataLink = Prefixed_Name(wfdesc, "DataLink") |> PrefixedName
    /// <summary>
    ///   <para>wfdesc:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A wfdesc:Process is used to describe a class of actions that when enacted give rise to processes. A process can have 0 or more wfdesc:Parameter instances associated using wfdesc:hasInput and wfdesc:hasOutput, signifying what kind of parameters the process will require and return.
    ///
    /// It is out of scope for wfdesc to classify or specify the nature of the process, this should be done by subclassing and additional subproperties, for instance ex:perlScript or ex:restServiceURI</para>
    /// labels<para>Process</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#Process">http://purl.org/wf4ever/wfdesc#Process</seealso>
    let Process = Prefixed_Name(wfdesc, "Process") |> PrefixedName
    /// <summary>
    ///   <para>wfdesc:hasImplementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The implementation that is invoked when running the wfdesc:Process, like a wf4ever:Script or wf4ever:WebService. </para>
    /// labels<para>has implementation</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#hasImplementation">http://purl.org/wf4ever/wfdesc#hasImplementation</seealso>
    let hasImplementation = Prefixed_Name(wfdesc, "hasImplementation") |> PrefixedName
    /// <summary>
    ///   <para>wfdesc:WorkflowDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The definition that implements this workflow, typically a file natively understood by the wfdesc:WorkflowEngine. Examples include .t2flow XML files from Taverna 2 and Galaxy workflows saved as JSON.
    ///
    /// A wfdesc:Workflow description can specify its wfdesc:WorkflowDefinition using wfdesc:hasWorkflowDefinition. This is typically only done for the top-level workflow - subworkflows without a wfdesc:hasWorkflowDefinition are assumed to be embedded within the definition of the parent workflow, except where the sub-workflows are included in the parent by reference, in which case they would have a different wfdesc:hasWorkflowDefinition.</para>
    /// labels<para>Workflow Definition</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#WorkflowDefinition">http://purl.org/wf4ever/wfdesc#WorkflowDefinition</seealso>
    let WorkflowDefinition = Prefixed_Name(wfdesc, "WorkflowDefinition") |> PrefixedName

    /// <summary>
    ///   <para>wfdesc:hasWorkflowDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The definition of this workflow, typically a file natively understood by the wfdesc:WorkflowEngine.</para>
    /// labels<para>has workflow definition</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#hasWorkflowDefinition">http://purl.org/wf4ever/wfdesc#hasWorkflowDefinition</seealso>
    let hasWorkflowDefinition =
        Prefixed_Name(wfdesc, "hasWorkflowDefinition") |> PrefixedName

    /// <summary>
    ///   <para>wfdesc:hasArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property associates a wfdesc:Parameter with an wfdesc:Artifact which can describe the artifact which would be used/generated on execution of the workflow.</para>
    /// labels<para>has artifact</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#hasArtifact">http://purl.org/wf4ever/wfdesc#hasArtifact</seealso>
    let hasArtifact = Prefixed_Name(wfdesc, "hasArtifact") |> PrefixedName
    /// <summary>
    ///   <para>wfdesc:hasConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This object property is used to specify the wfdesc:Configuration parameter of a given wfdesc:Process.</para>
    /// labels<para>has configuration</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#hasConfiguration">http://purl.org/wf4ever/wfdesc#hasConfiguration</seealso>
    let hasConfiguration = Prefixed_Name(wfdesc, "hasConfiguration") |> PrefixedName
    /// <summary>
    ///   <para>wfdesc:hasInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This object property is used to specify the wfdesc:Input parameter of a given wfdesc:Process.</para>
    /// labels<para>has input</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#hasInput">http://purl.org/wf4ever/wfdesc#hasInput</seealso>
    let hasInput = Prefixed_Name(wfdesc, "hasInput") |> PrefixedName
    /// <summary>
    ///   <para>wfdesc:hasSink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to specify the wfdesc:Input parameter that acts as a sink from a given wfdesc:DataLink, consuming data from the link.</para>
    /// labels<para>has sink</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#hasSink">http://purl.org/wf4ever/wfdesc#hasSink</seealso>
    let hasSink = Prefixed_Name(wfdesc, "hasSink") |> PrefixedName
    /// <summary>
    ///   <para>wfdesc:hasSubProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This object property is used to specify that the given workflow  contains the given process as part of its definition.
    ///
    /// Although not a requirement, such sub processes should have wfdesc:DataLink within the containing workflow connecting their parameters with parameters of the containing workflow, or with parameters other contained wfdesc:Process instances.
    ///
    /// A specialialisation of sub process is wfdesc:hasSubWorkflow where the sub process is a nested wfdesc:Workflow.</para>
    /// labels<para>has sub-process</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#hasSubProcess">http://purl.org/wf4ever/wfdesc#hasSubProcess</seealso>
    let hasSubProcess = Prefixed_Name(wfdesc, "hasSubProcess") |> PrefixedName
    /// <summary>
    ///   <para>wfdesc:hasSubWorkflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This object property is used to associate a wfdesc:Workflow description to another wfdesc:Workflow, specifying that the first workflow has the given sub-workflow as a contained process.
    ///
    /// This is a specialisation of wfdesc:hasSubProcess.</para>
    /// labels<para>has sub-workflow</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#hasSubWorkflow">http://purl.org/wf4ever/wfdesc#hasSubWorkflow</seealso>
    let hasSubWorkflow = Prefixed_Name(wfdesc, "hasSubWorkflow") |> PrefixedName
    /// <summary>
    ///   <para>wfdesc:WorkflowInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A wfdesc:WorkflowInstance is a specialisation of a wfdesc:Workflow description which defines all data/parameters/settings that are required to form a wfprov:WorkflowRun.
    /// In other words a wdesc:WorkflowInstance is a workflow description that is ready to run.
    ///         </para>
    /// labels<para>Workflow Instance</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#WorkflowInstance">http://purl.org/wf4ever/wfdesc#WorkflowInstance</seealso>
    let WorkflowInstance = Prefixed_Name(wfdesc, "WorkflowInstance") |> PrefixedName
    /// <summary>
    ///   <para>wfdesc:hasDataLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to specify the wfdesc:DataLink instances of a given wfdesc:Workflow.</para>
    /// labels<para>has datalink</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#hasDataLink">http://purl.org/wf4ever/wfdesc#hasDataLink</seealso>
    let hasDataLink = Prefixed_Name(wfdesc, "hasDataLink") |> PrefixedName
    /// <summary>
    ///   <para>wfdesc:hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This object property is used to specify the wfdesc:Output parameter of a given wfdesc:Process.
    /// </para>
    /// labels<para>has output</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#hasOutput">http://purl.org/wf4ever/wfdesc#hasOutput</seealso>
    let hasOutput = Prefixed_Name(wfdesc, "hasOutput") |> PrefixedName
    /// <summary>
    ///   <para>wfdesc:hasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to specify the wfdesc:Output parameter that acts as a source to a given wfdesc:DataLink, providing data into the link.</para>
    /// labels<para>has source</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#hasSource">http://purl.org/wf4ever/wfdesc#hasSource</seealso>
    let hasSource = Prefixed_Name(wfdesc, "hasSource") |> PrefixedName
    /// <summary>
    ///   <para>wfdesc:Output</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>wfdesc:Output represents an output parameter from a wfdesc:Process. This can be compared to functional return values, stdout/stdin, files written, or results shown in a user interface.
    ///
    /// It is out of scope of wfdesc to define the nature or classification of the parameter, such as giving it a name, position or data type. This can be done with subclasses and/or subproperties.</para>
    /// labels<para>Output</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#Output">http://purl.org/wf4ever/wfdesc#Output</seealso>
    let Output = Prefixed_Name(wfdesc, "Output") |> PrefixedName
    /// <summary>
    ///   <para>wfdesc:Input</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>wfdesc:Input represents an input parameter to a wfdesc:Process. This can be compared to a function parameter, command line argument, files read, or parameter set by a user interface.
    ///
    /// It is out of scope of wfdesc to define the nature or classification of the parameter, such as giving it a name, position or data type. This can be done with subclasses and/or subproperties.</para>
    /// labels<para>Input</para></remarks>
    /// <seealso href="http://purl.org/wf4ever/wfdesc#Input">http://purl.org/wf4ever/wfdesc#Input</seealso>
    let Input = Prefixed_Name(wfdesc, "Input") |> PrefixedName
