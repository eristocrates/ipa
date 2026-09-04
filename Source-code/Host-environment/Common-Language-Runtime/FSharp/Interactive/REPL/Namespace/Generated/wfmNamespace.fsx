#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module wfm =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/net/wf-motifs#" "wfm"
    /// <summary>
    ///   <para>rdfs:label : Atomic workflow</para>
    ///   <para>rdfs:comment :  Inter-workflow motif used to characterize the workflows that perform an atomic unit of functionality, which effectively requires no sub-workflow usage. Typically these workflows are designed to be included in other workflows. Atomic workflows are the main mechanism of modularizing functionality within scientific workflows.^^xsd:string</para>
    ///   <a href="http://purl.org/net/wf-motifs#AtomicWorkflow">wfm:AtomicWorkflow</a>
    /// </summary>
    let AtomicWorkflow = _prefixId.prefix "AtomicWorkflow"
    /// <summary>
    ///   <para>rdfs:label : Combine</para>
    ///   <para>rdfs:comment : Data preparation motif that refers to the step or group of steps in the workflow aggregating information from different sources. For example, the joining of two tables in a new one or the merging of three different files in a bigger one.</para>
    ///   <a href="http://purl.org/net/wf-motifs#Combine">wfm:Combine</a>
    /// </summary>
    let Combine = _prefixId.prefix "Combine"
    /// <summary>
    ///   <para>rdfs:label : Composite workflow</para>
    ///   <para>rdfs:comment : Inter-workflow motif referring to all those workflows that have one or more sub-workflows included in them (when these sub-workflows overlap they offer different views of the global workflow). </para>
    ///   <a href="http://purl.org/net/wf-motifs#CompositeWorkflow">wfm:CompositeWorkflow</a>
    /// </summary>
    let CompositeWorkflow = _prefixId.prefix "CompositeWorkflow"
    /// <summary>
    ///   <para>rdfs:label : Computational step</para>
    ///   <para>rdfs:comment : Intra-workflow motif used to refer to activities performed by a computer. This motif applies to most of the steps of the workflow, except for those being human interaction steps.</para>
    ///   <a href="http://purl.org/net/wf-motifs#ComputationalStep">wfm:ComputationalStep</a>
    /// </summary>
    let ComputationalStep = _prefixId.prefix "ComputationalStep"
    /// <summary>
    ///   <para>rdfs:label : Data analysis</para>
    ///   <para>rdfs:comment : Data operation motif that refers to a broad category of tasks in diverse domains. An important number of workflows are designed with the purpose of analyzing different features of input data, ranging from simple comparisons between the datasets to complex protein analysis to see whether two molecules can be docked successfully or not. </para>
    ///   <a href="http://purl.org/net/wf-motifs#DataAnalysis">wfm:DataAnalysis</a>
    /// </summary>
    let DataAnalysis = _prefixId.prefix "DataAnalysis"
    /// <summary>
    ///   <para>rdfs:label : Data cleaning</para>
    ///   <para>rdfs:comment : Data operation motif that refers to the step or series of steps for cleaning and curating data in a workflow. Typically these steps are undertaken by sophisticated tooling/services, or by human interactions. A data cleaning step preserves and enriches the content of data (e.g., by a user’s annotation of a result with additional information, detecting and removing inconsistencies on the data, etc.).^^xsd:string</para>
    ///   <a href="http://purl.org/net/wf-motifs#DataCleaning">wfm:DataCleaning</a>
    /// </summary>
    let DataCleaning = _prefixId.prefix "DataCleaning"
    /// <summary>
    ///   <para>rdfs:label : Data movement</para>
    ///   <para>rdfs:comment : Certain analysis activities that are performed via external tools or services require the submission of data to a location accessible by the service/tool (i.e., a web or a local directory respectively). In such cases the workflow contains dedicated step(s) for the upload/transfer of data to these locations. The same applies to the outputs, in which case a data download/retrieval step is used to chain the data to the next steps of the workflow.</para>
    ///   <a href="http://purl.org/net/wf-motifs#DataMovement">wfm:DataMovement</a>
    /// </summary>
    let DataMovement = _prefixId.prefix "DataMovement"
    /// <summary>
    ///   <para>rdfs:label : Data operation motif</para>
    ///   <para>rdfs:comment : A data operation motif describes the data manipulation and/or transformation carried out by a step in the workflow, a collection of steps in the workflow or a sub-workflow.</para>
    ///   <a href="http://purl.org/net/wf-motifs#DataOperationMotif">wfm:DataOperationMotif</a>
    /// </summary>
    let DataOperationMotif = _prefixId.prefix "DataOperationMotif"
    /// <summary>
    ///   <para>rdfs:label : Data preparation</para>
    ///   <para>rdfs:comment : Data, as it is originally retrieved, may need several transformations before being able to be used in a workflow step. These steps, typically known as ”Shims” [Duncan Hull et al. Treating shimantic web syndrome with ontologies. In AKT Workshop on Semantic Web Services, 2004.], can be annotated using the Data Preparation motif.</para>
    ///   <a href="http://purl.org/net/wf-motifs#DataPreparation">wfm:DataPreparation</a>
    /// </summary>
    let DataPreparation = _prefixId.prefix "DataPreparation"
    /// <summary>
    ///   <para>rdfs:label : Data retrieval</para>
    ///   <para>rdfs:comment : Workflows exploit heterogeneous data sources, remote databases, repositories and other web resources mostly exposed via SOAP or REST services. Scientific data deposited in these repositories are retrieved through query and retrieval steps inside workflows. The data retrieval motif identifies those tasks within the workflow which are responsible for retrieving data from external sources into the workflow environment.^^xsd:string</para>
    ///   <a href="http://purl.org/net/wf-motifs#DataRetrieval">wfm:DataRetrieval</a>
    /// </summary>
    let DataRetrieval = _prefixId.prefix "DataRetrieval"
    /// <summary>
    ///   <para>rdfs:label : Data visualization</para>
    ///   <para>rdfs:comment : Being able to show the results is as important as producing them in some workflows. Scientists use visualizations to show the conclusions of their experiments and to take important decisions in the pipeline itself. Therefore certain steps in workflows are dedicated to generation of plots and graph outputs from input data. The data visualization motif also includes the generation of tables and files for browsing and reading the results of the workflow.</para>
    ///   <a href="http://purl.org/net/wf-motifs#DataVisualization">wfm:DataVisualization</a>
    /// </summary>
    let DataVisualization = _prefixId.prefix "DataVisualization"
    /// <summary>
    ///   <para>rdfs:label : Filter
    /// </para>
    ///   <para>rdfs:comment : Data preparation motif that refers to a filtering step or set of steps. For example, A file filtered by a set of set of keywords, a table filtered by a threshold, etc.</para>
    ///   <a href="http://purl.org/net/wf-motifs#Filter">wfm:Filter</a>
    /// </summary>
    let Filter = _prefixId.prefix "Filter"
    /// <summary>
    ///   <para>rdfs:label : Format transformation</para>
    ///   <para>rdfs:comment : Workflows that bring together multiple access or analysis activities usually contain steps for format transformations. These steps preserve the content of the inputs while converting its representation format. An example would be a converter from CSV to VOTable format in the astronomy domain, a converter from FASTA to Swiss-Prott sequence in biology, or an Arff formating component for Weka in the text analysis domain.</para>
    ///   <a href="http://purl.org/net/wf-motifs#FormatTransformation">wfm:FormatTransformation</a>
    /// </summary>
    let FormatTransformation = _prefixId.prefix "FormatTransformation"
    /// <summary>
    ///   <para>rdfs:label : Group</para>
    ///   <para>rdfs:comment : Data preparation motif that refers to the step or set of steps that reorganize the input into different groups. For example, grouping a table by a certain category.</para>
    ///   <a href="http://purl.org/net/wf-motifs#Group">wfm:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>rdfs:label : Human interaction step</para>
    ///   <para>rdfs:comment : Intra-workflow motif used to characterize the activities that require human inputs during their execution. For example, manual data curation of a table for a future step in the workflow, cleaning and filtering steps (such as selecting a specific dataset to continue the experiment), etc. </para>
    ///   <a href="http://purl.org/net/wf-motifs#HumanInteractionStep">wfm:HumanInteractionStep</a>
    /// </summary>
    let HumanInteractionStep = _prefixId.prefix "HumanInteractionStep"
    /// <summary>
    ///   <para>rdfs:label : Input augmentation</para>
    ///   <para>rdfs:comment : Data preparation motif that refers to the step or set of steps dedicated to generate an aggregation of multiple parameters and scripts for tools and external services. For example, the generation of queries for input retrieval through an aggregation of multiple parameters, the generation of scripts to be executed in further steps, etc.</para>
    ///   <a href="http://purl.org/net/wf-motifs#InputAugmentation">wfm:InputAugmentation</a>
    /// </summary>
    let InputAugmentation = _prefixId.prefix "InputAugmentation"
    /// <summary>
    ///   <para>rdfs:label : Inter-workflow motif</para>
    ///   <para>rdfs:comment : Workflow motif that relates workflows with each other by determining whether different workflows are a composition of each other (composite workflow) or not (atomic workflow), or they have a very similar composition but work for different inputs (workflow overloading).</para>
    ///   <a href="http://purl.org/net/wf-motifs#InterWorkflowMotif">wfm:InterWorkflowMotif</a>
    /// </summary>
    let InterWorkflowMotif = _prefixId.prefix "InterWorkflowMotif"
    /// <summary>
    ///   <para>rdfs:label : Internal macro</para>
    ///   <para>rdfs:comment : Intra-workflow motif that refers to those groups of steps in the workflow that correspond to repetitive patterns of combining tasks. For example, if a workflow has several branches with the same sequence of repeated steps, the sequence becomes an internal macro.</para>
    ///   <a href="http://purl.org/net/wf-motifs#InternalMacro">wfm:InternalMacro</a>
    /// </summary>
    let InternalMacro = _prefixId.prefix "InternalMacro"
    /// <summary>
    ///   <para>rdfs:label : Intra-workflow motif</para>
    ///   <para>rdfs:comment : Workflow motif that describes a step or a series of steps within a single workflow.</para>
    ///   <a href="http://purl.org/net/wf-motifs#IntraWorkflowMotif">wfm:IntraWorkflowMotif</a>
    /// </summary>
    let IntraWorkflowMotif = _prefixId.prefix "IntraWorkflowMotif"
    /// <summary>
    ///   <para>rdfs:label : Motif</para>
    ///   <para>rdfs:comment : A motif is a domain independent conceptual abstraction of one or more steps of a given workflow.</para>
    ///   <a href="http://purl.org/net/wf-motifs#Motif">wfm:Motif</a>
    /// </summary>
    let Motif = _prefixId.prefix "Motif"
    /// <summary>
    ///   <para>rdfs:label : Output extraction</para>
    ///   <para>rdfs:comment : Data preparation motif that refers to the step or set of steps in the workflow retrieving only the relevant portion from the the output of a previous step. For example, retrieving the tag value of an XML fragment.</para>
    ///   <a href="http://purl.org/net/wf-motifs#OutputExtraction">wfm:OutputExtraction</a>
    /// </summary>
    let OutputExtraction = _prefixId.prefix "OutputExtraction"
    /// <summary>
    ///   <para>rdfs:label : Sort</para>
    ///   <para>rdfs:comment : Data preparation motif that refers to the step or set of steps ordering the input by certain parameter. For example, a quicksort algorithm that takes an unordered vector and produces a sorted output.</para>
    ///   <a href="http://purl.org/net/wf-motifs#Sort">wfm:Sort</a>
    /// </summary>
    let Sort = _prefixId.prefix "Sort"
    /// <summary>
    ///   <para>rdfs:label : Split</para>
    ///   <para>rdfs:comment : Data preparation motif that refers to the step or steps in the workflow separating an input into different outputs. For example, splitting a dataset in three different subsets to be processed in parallel in a workflow.</para>
    ///   <a href="http://purl.org/net/wf-motifs#Split">wfm:Split</a>
    /// </summary>
    let Split = _prefixId.prefix "Split"
    /// <summary>
    ///   <para>rdfs:label : Stateful (asynchronous) invocation</para>
    ///   <para>rdfs:comment : Certain activities such as analysis or visualizations could be performed through interaction with stateful (web) services that allow for creation of jobs over remote grid environments. These are typically performed via invocation of multiple operations at a service endpoint. An example would be a BLAST job submission where the service invoker is responsible to first create a job, then submit the data, check the status and retrieve the results once it has finished.</para>
    ///   <a href="http://purl.org/net/wf-motifs#StatefulInvocation">wfm:StatefulInvocation</a>
    /// </summary>
    let StatefulInvocation = _prefixId.prefix "StatefulInvocation"
    /// <summary>
    ///   <para>rdfs:label : Stateless (synchronous) invocation</para>
    ///   <para>rdfs:comment : Intra-workflow motif that requires a step in the workflow for performing a service call or tool invocation. All the steps of a workflow are by default stateless (synchronous) invocations unless they are explicitly declared to be stateful. </para>
    ///   <a href="http://purl.org/net/wf-motifs#StatelessInvocaton">wfm:StatelessInvocaton</a>
    /// </summary>
    let StatelessInvocaton = _prefixId.prefix "StatelessInvocaton"
    /// <summary>
    ///   <para>rdfs:label : Workflow motif</para>
    ///   <para>rdfs:comment : Motif that describes how a data operation motif is realized (i.e., implemented) within a workflow. For example, a visualization step (data operation motif) can be realized in different ways: via a stateful multi-step invocation, through a single stateless invocation (depending on the environmental constraints and nature of the services), or via a sub-workflow.</para>
    ///   <a href="http://purl.org/net/wf-motifs#WorkflowMotif">wfm:WorkflowMotif</a>
    /// </summary>
    let WorkflowMotif = _prefixId.prefix "WorkflowMotif"
    /// <summary>
    ///   <para>rdfs:label : Workflow overload</para>
    ///   <para>rdfs:comment : Inter-workflow motif used to characterize workflows that are used to operate over different input parameter types. An example is performing an analysis over a String input parameter, or performing it over the contents of a specified File. Overloading is a direct response to the heterogeneity of environments in which workflows are used.</para>
    ///   <a href="http://purl.org/net/wf-motifs#WorkflowOverload">wfm:WorkflowOverload</a>
    /// </summary>
    let WorkflowOverload = _prefixId.prefix "WorkflowOverload"
    /// <summary>
    ///   <para>rdfs:label : has data operation motif</para>
    ///   <para>rdfs:comment : Object property that binds a workflow step with its correspondent data operation motif.</para>
    ///   <a href="http://purl.org/net/wf-motifs#hasDataOperationMotif">wfm:hasDataOperationMotif</a>
    /// </summary>
    let hasDataOperationMotif = _prefixId.prefix "hasDataOperationMotif"
    /// <summary>
    ///   <para>rdfs:label : has motif</para>
    ///   <para>rdfs:comment : Object property that annotates a step in the workflow, a group of steps, a subworkflow, or a workflow with a motif.</para>
    ///   <a href="http://purl.org/net/wf-motifs#hasMotif">wfm:hasMotif</a>
    /// </summary>
    let hasMotif = _prefixId.prefix "hasMotif"
    /// <summary>
    ///   <para>rdfs:label : has workflow motif</para>
    ///   <para>rdfs:comment : Object property that relates a workflow to its correspondent workflow motif.</para>
    ///   <a href="http://purl.org/net/wf-motifs#hasWorkflowMotif">wfm:hasWorkflowMotif</a>
    /// </summary>
    let hasWorkflowMotif = _prefixId.prefix "hasWorkflowMotif"
