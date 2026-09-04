#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module wfdesc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/wf4ever/wfdesc#" "wfdesc"

    /// <summary>
    ///   <para>rdfs:comment : wfdesc:Artifact is used to provide information about a class of artifacts. For example, it can be used to specify the datatype of a dataset or the structure of a document.
    ///
    /// An wfdesc:Artifact is associated with a wfdesc:Parameter using wfdesc:hasArtifact.
    ///
    /// The distinction between a parameter and artifact is that the parameter can be customized to describe the particular role the artifact plays with regards to the process (and can be linked using wfdesc:DataLink) - while the wfdesc:Artifact can describe the syntactic and semantic datatype.</para>
    ///   <para>rdfs:label : Artifact</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#Artifact">wfdesc:Artifact</a>
    /// </summary>
    let Artifact = _prefixId.prefix "Artifact"
    /// <summary>
    ///   <para>rdfs:comment : A configuration is a kind of parameter to a wfdesc:Process (linked using wfdesc:hasConfiguration) to indicate a setting, flag or customization which somewhat modifies or controls the behaviour of the wfdesc:Process.
    ///
    /// Different workflow systems have stronger or weaker differentiation between inputs and configurations, so a wfdesc:Configuration MAY also be a wfdesc:Input in the case of a dynamic configuration provided by the workflow itself.
    ///
    /// Note that attributes which define or specify the process to invoke, like a wf4ever:script, or a wf4ever:serviceURI of a wf4ever:WebService, are not normally considered Configurations.</para>
    ///   <para>rdfs:label : Configuration</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#Configuration">wfdesc:Configuration</a>
    /// </summary>
    let Configuration = _prefixId.prefix "Configuration"
    /// <summary>
    ///   <para>rdfs:comment : wfdesc:DataLink is used to represent data dependencies between wfdesc:Process descriptions. It means that the artifact generated at an wfdesc:Output (identified using wfdesc:hasSource) will be used by a wfdescInput (identified using wfdesc:hasSink).
    ///
    /// The wfdesc:Processes that owns the wfdesc:Parameter instances which are the source and sink of a wfdesc:DataLink must be wfdesc:hasSubProcess of a the same wfdesc:Workflow which wfdesc:hasDataLink the data link, or be be parameters of that same workflow.
    ///
    /// Thus links can only be made within a wfdesc:Workflow - although ports owned by the workflow itself appear both inside and outside the workflow (in opposite roles).</para>
    ///   <para>rdfs:label : Data Link</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#DataLink">wfdesc:DataLink</a>
    /// </summary>
    let DataLink = _prefixId.prefix "DataLink"
    /// <summary>
    ///   <para>rdfs:comment : wfdesc:Input represents an input parameter to a wfdesc:Process. This can be compared to a function parameter, command line argument, files read, or parameter set by a user interface.
    ///
    /// It is out of scope of wfdesc to define the nature or classification of the parameter, such as giving it a name, position or data type. This can be done with subclasses and/or subproperties.</para>
    ///   <para>rdfs:label : Input</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#Input">wfdesc:Input</a>
    /// </summary>
    let Input = _prefixId.prefix "Input"
    /// <summary>
    ///   <para>rdfs:comment : wfdesc:Output represents an output parameter from a wfdesc:Process. This can be compared to functional return values, stdout/stdin, files written, or results shown in a user interface.
    ///
    /// It is out of scope of wfdesc to define the nature or classification of the parameter, such as giving it a name, position or data type. This can be done with subclasses and/or subproperties.</para>
    ///   <para>rdfs:label : Output</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#Output">wfdesc:Output</a>
    /// </summary>
    let Output = _prefixId.prefix "Output"
    /// <summary>
    ///   <para>rdfs:comment : This class represent a parameter of a wfdesc:Process. A wfdesc:Parameter must be a wfdesc:Input, a wfdesc:Output, or a wfdesc:Configuration.
    ///
    /// Note that a parameter MAY be both an wfdesc:Input and wfdesc:Output when it is used on both sides of a subworkflow - see wfdesc:Workflow and wfdesc:DataLink for details.
    ///
    /// A wfdesc:Configuration MAY also be a wfdesc:Input, indicating that the configuration is of a dynamic nature, decided by the workflow.</para>
    ///   <para>rdfs:label : Parameter</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#Parameter">wfdesc:Parameter</a>
    /// </summary>
    let Parameter = _prefixId.prefix "Parameter"
    /// <summary>
    ///   <para>rdfs:comment : A wfdesc:Process is used to describe a class of actions that when enacted give rise to processes. A process can have 0 or more wfdesc:Parameter instances associated using wfdesc:hasInput and wfdesc:hasOutput, signifying what kind of parameters the process will require and return.
    ///
    /// It is out of scope for wfdesc to classify or specify the nature of the process, this should be done by subclassing and additional subproperties, for instance ex:perlScript or ex:restServiceURI</para>
    ///   <para>rdfs:label : Process</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#Process">wfdesc:Process</a>
    /// </summary>
    let Process = _prefixId.prefix "Process"
    /// <summary>
    ///   <para>rdfs:comment : The implementation that is invoked when running the wfdesc:Process, like a wf4ever:Script or wf4ever:WebService.
    ///
    /// The process specifies the implementation using wfdesc:hasImplementation.</para>
    ///   <para>rdfs:label : Process Implementation</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#ProcessImplementation">wfdesc:ProcessImplementation</a>
    /// </summary>
    let ProcessImplementation = _prefixId.prefix "ProcessImplementation"
    /// <summary>
    ///   <para>rdfs:comment : A wfdesc:Workflow is a directed graph in which the nodes are wfdesc:Process instances and the edges (wfdesc:DataLink instances) represent data dependencies between the constituent wfdesc:Process descriptions.
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
    ///   <para>rdfs:label : Workflow</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#Workflow">wfdesc:Workflow</a>
    /// </summary>
    let Workflow = _prefixId.prefix "Workflow"
    /// <summary>
    ///   <para>rdfs:comment : The definition that implements this workflow, typically a file natively understood by the wfdesc:WorkflowEngine. Examples include .t2flow XML files from Taverna 2 and Galaxy workflows saved as JSON.
    ///
    /// A wfdesc:Workflow description can specify its wfdesc:WorkflowDefinition using wfdesc:hasWorkflowDefinition. This is typically only done for the top-level workflow - subworkflows without a wfdesc:hasWorkflowDefinition are assumed to be embedded within the definition of the parent workflow, except where the sub-workflows are included in the parent by reference, in which case they would have a different wfdesc:hasWorkflowDefinition.</para>
    ///   <para>rdfs:label : Workflow Definition</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#WorkflowDefinition">wfdesc:WorkflowDefinition</a>
    /// </summary>
    let WorkflowDefinition = _prefixId.prefix "WorkflowDefinition"
    /// <summary>
    ///   <para>rdfs:comment : A wfdesc:WorkflowInstance is a specialisation of a wfdesc:Workflow description which defines all data/parameters/settings that are required to form a wfprov:WorkflowRun.
    /// In other words a wdesc:WorkflowInstance is a workflow description that is ready to run.
    ///         </para>
    ///   <para>rdfs:label : Workflow Instance</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#WorkflowInstance">wfdesc:WorkflowInstance</a>
    /// </summary>
    let WorkflowInstance = _prefixId.prefix "WorkflowInstance"
    /// <summary>
    ///   <para>rdfs:comment : This property associates a wfdesc:Parameter with an wfdesc:Artifact which can describe the artifact which would be used/generated on execution of the workflow.</para>
    ///   <para>rdfs:label : has artifact</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#hasArtifact">wfdesc:hasArtifact</a>
    /// </summary>
    let hasArtifact = _prefixId.prefix "hasArtifact"
    /// <summary>
    ///   <para>rdfs:comment : This object property is used to specify the wfdesc:Configuration parameter of a given wfdesc:Process.</para>
    ///   <para>rdfs:label : has configuration</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#hasConfiguration">wfdesc:hasConfiguration</a>
    /// </summary>
    let hasConfiguration = _prefixId.prefix "hasConfiguration"
    /// <summary>
    ///   <para>rdfs:comment : This property is used to specify the wfdesc:DataLink instances of a given wfdesc:Workflow.</para>
    ///   <para>rdfs:label : has datalink</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#hasDataLink">wfdesc:hasDataLink</a>
    /// </summary>
    let hasDataLink = _prefixId.prefix "hasDataLink"
    /// <summary>
    ///   <para>rdfs:comment : The implementation that is invoked when running the wfdesc:Process, like a wf4ever:Script or wf4ever:WebService. </para>
    ///   <para>rdfs:label : has implementation</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#hasImplementation">wfdesc:hasImplementation</a>
    /// </summary>
    let hasImplementation = _prefixId.prefix "hasImplementation"
    /// <summary>
    ///   <para>rdfs:comment : This object property is used to specify the wfdesc:Input parameter of a given wfdesc:Process.</para>
    ///   <para>rdfs:label : has input</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#hasInput">wfdesc:hasInput</a>
    /// </summary>
    let hasInput = _prefixId.prefix "hasInput"
    /// <summary>
    ///   <para>rdfs:comment : This object property is used to specify the wfdesc:Output parameter of a given wfdesc:Process.
    /// </para>
    ///   <para>rdfs:label : has output</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#hasOutput">wfdesc:hasOutput</a>
    /// </summary>
    let hasOutput = _prefixId.prefix "hasOutput"
    /// <summary>
    ///   <para>rdfs:comment : This property is used to specify the wfdesc:Input parameter that acts as a sink from a given wfdesc:DataLink, consuming data from the link.</para>
    ///   <para>rdfs:label : has sink</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#hasSink">wfdesc:hasSink</a>
    /// </summary>
    let hasSink = _prefixId.prefix "hasSink"
    /// <summary>
    ///   <para>rdfs:comment : This property is used to specify the wfdesc:Output parameter that acts as a source to a given wfdesc:DataLink, providing data into the link.</para>
    ///   <para>rdfs:label : has source</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#hasSource">wfdesc:hasSource</a>
    /// </summary>
    let hasSource = _prefixId.prefix "hasSource"
    /// <summary>
    ///   <para>rdfs:comment : This object property is used to specify that the given workflow  contains the given process as part of its definition.
    ///
    /// Although not a requirement, such sub processes should have wfdesc:DataLink within the containing workflow connecting their parameters with parameters of the containing workflow, or with parameters other contained wfdesc:Process instances.
    ///
    /// A specialialisation of sub process is wfdesc:hasSubWorkflow where the sub process is a nested wfdesc:Workflow.</para>
    ///   <para>rdfs:label : has sub-process</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#hasSubProcess">wfdesc:hasSubProcess</a>
    /// </summary>
    let hasSubProcess = _prefixId.prefix "hasSubProcess"
    /// <summary>
    ///   <para>rdfs:comment : This object property is used to associate a wfdesc:Workflow description to another wfdesc:Workflow, specifying that the first workflow has the given sub-workflow as a contained process.
    ///
    /// This is a specialisation of wfdesc:hasSubProcess.</para>
    ///   <para>rdfs:label : has sub-workflow</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#hasSubWorkflow">wfdesc:hasSubWorkflow</a>
    /// </summary>
    let hasSubWorkflow = _prefixId.prefix "hasSubWorkflow"
    /// <summary>
    ///   <para>rdfs:comment : The definition of this workflow, typically a file natively understood by the wfdesc:WorkflowEngine.</para>
    ///   <para>rdfs:label : has workflow definition</para>
    ///   <a href="http://purl.org/wf4ever/wfdesc#hasWorkflowDefinition">wfdesc:hasWorkflowDefinition</a>
    /// </summary>
    let hasWorkflowDefinition = _prefixId.prefix "hasWorkflowDefinition"
