namespace http.purl.org.wf4ever.wfdesc.hash

open DoxAletheia

module wfdesc =
    let _namespace_name = "http://purl.org/wf4ever/wfdesc#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// wfdesc:Artifact is used to provide information about a class of artifacts. For example, it can be used to specify the datatype of a dataset or the structure of a document.
    ///
    /// An wfdesc:Artifact is associated with a wfdesc:Parameter using wfdesc:hasArtifact.
    ///
    /// The distinction between a parameter and artifact is that the parameter can be customized to describe the particular role the artifact plays with regards to the process (and can be linked using wfdesc:DataLink) - while the wfdesc:Artifact can describe the syntactic and semantic datatype.
    /// <see href="http://purl.org/wf4ever/wfdesc#Artifact"></see></summary>
    let Artifact = _prefix "Artifact"
    /// <summary>
    /// A configuration is a kind of parameter to a wfdesc:Process (linked using wfdesc:hasConfiguration) to indicate a setting, flag or customization which somewhat modifies or controls the behaviour of the wfdesc:Process.
    ///
    /// Different workflow systems have stronger or weaker differentiation between inputs and configurations, so a wfdesc:Configuration MAY also be a wfdesc:Input in the case of a dynamic configuration provided by the workflow itself.
    ///
    /// Note that attributes which define or specify the process to invoke, like a wf4ever:script, or a wf4ever:serviceURI of a wf4ever:WebService, are not normally considered Configurations.
    /// <see href="http://purl.org/wf4ever/wfdesc#Configuration"></see></summary>
    let Configuration = _prefix "Configuration"
    /// <summary>
    /// This class represent a parameter of a wfdesc:Process. A wfdesc:Parameter must be a wfdesc:Input, a wfdesc:Output, or a wfdesc:Configuration.
    ///
    /// Note that a parameter MAY be both an wfdesc:Input and wfdesc:Output when it is used on both sides of a subworkflow - see wfdesc:Workflow and wfdesc:DataLink for details.
    ///
    /// A wfdesc:Configuration MAY also be a wfdesc:Input, indicating that the configuration is of a dynamic nature, decided by the workflow.
    /// <see href="http://purl.org/wf4ever/wfdesc#Parameter"></see></summary>
    let Parameter = _prefix "Parameter"
    /// <summary>
    /// wfdesc:Output represents an output parameter from a wfdesc:Process. This can be compared to functional return values, stdout/stdin, files written, or results shown in a user interface.
    ///
    /// It is out of scope of wfdesc to define the nature or classification of the parameter, such as giving it a name, position or data type. This can be done with subclasses and/or subproperties.
    /// <see href="http://purl.org/wf4ever/wfdesc#Output"></see></summary>
    let Output = _prefix "Output"
    /// <summary>
    /// wfdesc:DataLink is used to represent data dependencies between wfdesc:Process descriptions. It means that the artifact generated at an wfdesc:Output (identified using wfdesc:hasSource) will be used by a wfdescInput (identified using wfdesc:hasSink).
    ///
    /// The wfdesc:Processes that owns the wfdesc:Parameter instances which are the source and sink of a wfdesc:DataLink must be wfdesc:hasSubProcess of a the same wfdesc:Workflow which wfdesc:hasDataLink the data link, or be be parameters of that same workflow.
    ///
    /// Thus links can only be made within a wfdesc:Workflow - although ports owned by the workflow itself appear both inside and outside the workflow (in opposite roles).
    /// <see href="http://purl.org/wf4ever/wfdesc#DataLink"></see></summary>
    let DataLink = _prefix "DataLink"
    /// <summary>
    /// wfdesc:Input represents an input parameter to a wfdesc:Process. This can be compared to a function parameter, command line argument, files read, or parameter set by a user interface.
    ///
    /// It is out of scope of wfdesc to define the nature or classification of the parameter, such as giving it a name, position or data type. This can be done with subclasses and/or subproperties.
    /// <see href="http://purl.org/wf4ever/wfdesc#Input"></see></summary>
    let Input = _prefix "Input"
    /// <summary>
    /// A wfdesc:Process is used to describe a class of actions that when enacted give rise to processes. A process can have 0 or more wfdesc:Parameter instances associated using wfdesc:hasInput and wfdesc:hasOutput, signifying what kind of parameters the process will require and return.
    ///
    /// It is out of scope for wfdesc to classify or specify the nature of the process, this should be done by subclassing and additional subproperties, for instance ex:perlScript or ex:restServiceURI
    /// <see href="http://purl.org/wf4ever/wfdesc#Process"></see></summary>
    let Process = _prefix "Process"
    /// <summary>
    /// The implementation that is invoked when running the wfdesc:Process, like a wf4ever:Script or wf4ever:WebService.
    ///
    /// The process specifies the implementation using wfdesc:hasImplementation.
    /// <see href="http://purl.org/wf4ever/wfdesc#ProcessImplementation"></see></summary>
    let ProcessImplementation = _prefix "ProcessImplementation"
    /// <summary>
    /// The implementation that is invoked when running the wfdesc:Process, like a wf4ever:Script or wf4ever:WebService.
    /// <see href="http://purl.org/wf4ever/wfdesc#hasImplementation"></see></summary>
    let hasImplementation = _prefix "hasImplementation"
    /// <summary>
    /// A wfdesc:Workflow is a directed graph in which the nodes are wfdesc:Process instances and the edges (wfdesc:DataLink instances) represent data dependencies between the constituent wfdesc:Process descriptions.
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
    /// From this :param4 is both an wfdesc:Input and wfdesc:Output (which is why these two classes are not disjoint)
    /// <see href="http://purl.org/wf4ever/wfdesc#Workflow"></see></summary>
    let Workflow = _prefix "Workflow"
    /// <summary>
    /// The definition that implements this workflow, typically a file natively understood by the wfdesc:WorkflowEngine. Examples include .t2flow XML files from Taverna 2 and Galaxy workflows saved as JSON.
    ///
    /// A wfdesc:Workflow description can specify its wfdesc:WorkflowDefinition using wfdesc:hasWorkflowDefinition. This is typically only done for the top-level workflow - subworkflows without a wfdesc:hasWorkflowDefinition are assumed to be embedded within the definition of the parent workflow, except where the sub-workflows are included in the parent by reference, in which case they would have a different wfdesc:hasWorkflowDefinition.
    /// <see href="http://purl.org/wf4ever/wfdesc#WorkflowDefinition"></see></summary>
    let WorkflowDefinition = _prefix "WorkflowDefinition"
    /// <summary>
    /// The definition of this workflow, typically a file natively understood by the wfdesc:WorkflowEngine.
    /// <see href="http://purl.org/wf4ever/wfdesc#hasWorkflowDefinition"></see></summary>
    let hasWorkflowDefinition = _prefix "hasWorkflowDefinition"
    /// <summary>
    /// A wfdesc:WorkflowInstance is a specialisation of a wfdesc:Workflow description which defines all data/parameters/settings that are required to form a wfprov:WorkflowRun.
    /// In other words a wdesc:WorkflowInstance is a workflow description that is ready to run.
    ///
    /// <see href="http://purl.org/wf4ever/wfdesc#WorkflowInstance"></see></summary>
    let WorkflowInstance = _prefix "WorkflowInstance"
    /// <summary>
    /// This property associates a wfdesc:Parameter with an wfdesc:Artifact which can describe the artifact which would be used/generated on execution of the workflow.
    /// <see href="http://purl.org/wf4ever/wfdesc#hasArtifact"></see></summary>
    let hasArtifact = _prefix "hasArtifact"
    /// <summary>
    /// This object property is used to specify the wfdesc:Configuration parameter of a given wfdesc:Process.
    /// <see href="http://purl.org/wf4ever/wfdesc#hasConfiguration"></see></summary>
    let hasConfiguration = _prefix "hasConfiguration"
    /// <summary>
    /// This property is used to specify the wfdesc:DataLink instances of a given wfdesc:Workflow.
    /// <see href="http://purl.org/wf4ever/wfdesc#hasDataLink"></see></summary>
    let hasDataLink = _prefix "hasDataLink"
    /// <summary>
    /// This object property is used to specify the wfdesc:Input parameter of a given wfdesc:Process.
    /// <see href="http://purl.org/wf4ever/wfdesc#hasInput"></see></summary>
    let hasInput = _prefix "hasInput"
    /// <summary>
    /// This object property is used to specify the wfdesc:Output parameter of a given wfdesc:Process.
    ///
    /// <see href="http://purl.org/wf4ever/wfdesc#hasOutput"></see></summary>
    let hasOutput = _prefix "hasOutput"
    /// <summary>
    /// This property is used to specify the wfdesc:Input parameter that acts as a sink from a given wfdesc:DataLink, consuming data from the link.
    /// <see href="http://purl.org/wf4ever/wfdesc#hasSink"></see></summary>
    let hasSink = _prefix "hasSink"
    /// <summary>
    /// This property is used to specify the wfdesc:Output parameter that acts as a source to a given wfdesc:DataLink, providing data into the link.
    /// <see href="http://purl.org/wf4ever/wfdesc#hasSource"></see></summary>
    let hasSource = _prefix "hasSource"
    /// <summary>
    /// This object property is used to specify that the given workflow  contains the given process as part of its definition.
    ///
    /// Although not a requirement, such sub processes should have wfdesc:DataLink within the containing workflow connecting their parameters with parameters of the containing workflow, or with parameters other contained wfdesc:Process instances.
    ///
    /// A specialialisation of sub process is wfdesc:hasSubWorkflow where the sub process is a nested wfdesc:Workflow.
    /// <see href="http://purl.org/wf4ever/wfdesc#hasSubProcess"></see></summary>
    let hasSubProcess = _prefix "hasSubProcess"
    /// <summary>
    /// This object property is used to associate a wfdesc:Workflow description to another wfdesc:Workflow, specifying that the first workflow has the given sub-workflow as a contained process.
    ///
    /// This is a specialisation of wfdesc:hasSubProcess.
    /// <see href="http://purl.org/wf4ever/wfdesc#hasSubWorkflow"></see></summary>
    let hasSubWorkflow = _prefix "hasSubWorkflow"
