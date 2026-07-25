namespace http.purl.org.net.wf_motifs.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wfm =
    let _namespace_iri = Namespace_Iri wfm |> NamespaceIRI
    /// <summary>
    ///   <para>wfm:DataPreparation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data, as it is originally retrieved, may need several transformations before being able to be used in a workflow step. These steps, typically known as ”Shims” [Duncan Hull et al. Treating shimantic web syndrome with ontologies. In AKT Workshop on Semantic Web Services, 2004.], can be annotated using the Data Preparation motif.</para>
    /// labels<para>Data preparation</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#DataPreparation">http://purl.org/net/wf-motifs#DataPreparation</seealso>
    let DataPreparation = Prefixed_Name(wfm, "DataPreparation") |> PrefixedName
    /// <summary>
    ///   <para>wfm:IntraWorkflowMotif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Workflow motif that describes a step or a series of steps within a single workflow.</para>
    /// labels<para>Intra-workflow motif</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#IntraWorkflowMotif">http://purl.org/net/wf-motifs#IntraWorkflowMotif</seealso>
    let IntraWorkflowMotif = Prefixed_Name(wfm, "IntraWorkflowMotif") |> PrefixedName
    /// <summary>
    ///   <para>wfm:DataOperationMotif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A data operation motif describes the data manipulation and/or transformation carried out by a step in the workflow, a collection of steps in the workflow or a sub-workflow.</para>
    /// labels<para>Data operation motif</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#DataOperationMotif">http://purl.org/net/wf-motifs#DataOperationMotif</seealso>
    let DataOperationMotif = Prefixed_Name(wfm, "DataOperationMotif") |> PrefixedName
    /// <summary>
    ///   <para>wfm:DataCleaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data operation motif that refers to the step or series of steps for cleaning and curating data in a workflow. Typically these steps are undertaken by sophisticated tooling/services, or by human interactions. A data cleaning step preserves and enriches the content of data (e.g., by a user’s annotation of a result with additional information, detecting and removing inconsistencies on the data, etc.).</para>
    /// labels<para>Data cleaning</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#DataCleaning">http://purl.org/net/wf-motifs#DataCleaning</seealso>
    let DataCleaning = Prefixed_Name(wfm, "DataCleaning") |> PrefixedName
    /// <summary>
    ///   <para>wfm:DataRetrieval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Workflows exploit heterogeneous data sources, remote databases, repositories and other web resources mostly exposed via SOAP or REST services. Scientific data deposited in these repositories are retrieved through query and retrieval steps inside workflows. The data retrieval motif identifies those tasks within the workflow which are responsible for retrieving data from external sources into the workflow environment.</para>
    /// labels<para>Data retrieval</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#DataRetrieval">http://purl.org/net/wf-motifs#DataRetrieval</seealso>
    let DataRetrieval = Prefixed_Name(wfm, "DataRetrieval") |> PrefixedName
    /// <summary>
    ///   <para>wfm:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data preparation motif that refers to the step or set of steps that reorganize the input into different groups. For example, grouping a table by a certain category.</para>
    /// labels<para>Group</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#Group">http://purl.org/net/wf-motifs#Group</seealso>
    let Group = Prefixed_Name(wfm, "Group") |> PrefixedName

    /// <summary>
    ///   <para>wfm:HumanInteractionStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Intra-workflow motif used to characterize the activities that require human inputs during their execution. For example, manual data curation of a table for a future step in the workflow, cleaning and filtering steps (such as selecting a specific dataset to continue the experiment), etc. </para>
    /// labels<para>Human interaction step</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#HumanInteractionStep">http://purl.org/net/wf-motifs#HumanInteractionStep</seealso>
    let HumanInteractionStep =
        Prefixed_Name(wfm, "HumanInteractionStep") |> PrefixedName

    /// <summary>
    ///   <para>wfm:InputAugmentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data preparation motif that refers to the step or set of steps dedicated to generate an aggregation of multiple parameters and scripts for tools and external services. For example, the generation of queries for input retrieval through an aggregation of multiple parameters, the generation of scripts to be executed in further steps, etc.</para>
    /// labels<para>Input augmentation</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#InputAugmentation">http://purl.org/net/wf-motifs#InputAugmentation</seealso>
    let InputAugmentation = Prefixed_Name(wfm, "InputAugmentation") |> PrefixedName
    /// <summary>
    ///   <para>wfm:DataMovement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Certain analysis activities that are performed via external tools or services require the submission of data to a location accessible by the service/tool (i.e., a web or a local directory respectively). In such cases the workflow contains dedicated step(s) for the upload/transfer of data to these locations. The same applies to the outputs, in which case a data download/retrieval step is used to chain the data to the next steps of the workflow.</para>
    /// labels<para>Data movement</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#DataMovement">http://purl.org/net/wf-motifs#DataMovement</seealso>
    let DataMovement = Prefixed_Name(wfm, "DataMovement") |> PrefixedName
    /// <summary>
    ///   <para>wfm:WorkflowMotif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Motif that describes how a data operation motif is realized (i.e., implemented) within a workflow. For example, a visualization step (data operation motif) can be realized in different ways: via a stateful multi-step invocation, through a single stateless invocation (depending on the environmental constraints and nature of the services), or via a sub-workflow.</para>
    /// labels<para>Workflow motif</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#WorkflowMotif">http://purl.org/net/wf-motifs#WorkflowMotif</seealso>
    let WorkflowMotif = Prefixed_Name(wfm, "WorkflowMotif") |> PrefixedName
    /// <summary>
    ///   <para>wfm:InterWorkflowMotif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Workflow motif that relates workflows with each other by determining whether different workflows are a composition of each other (composite workflow) or not (atomic workflow), or they have a very similar composition but work for different inputs (workflow overloading).</para>
    /// labels<para>Inter-workflow motif</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#InterWorkflowMotif">http://purl.org/net/wf-motifs#InterWorkflowMotif</seealso>
    let InterWorkflowMotif = Prefixed_Name(wfm, "InterWorkflowMotif") |> PrefixedName
    /// <summary>
    ///   <para>wfm:AtomicWorkflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para> Inter-workflow motif used to characterize the workflows that perform an atomic unit of functionality, which effectively requires no sub-workflow usage. Typically these workflows are designed to be included in other workflows. Atomic workflows are the main mechanism of modularizing functionality within scientific workflows.</para>
    /// labels<para>Atomic workflow</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#AtomicWorkflow">http://purl.org/net/wf-motifs#AtomicWorkflow</seealso>
    let AtomicWorkflow = Prefixed_Name(wfm, "AtomicWorkflow") |> PrefixedName
    /// <summary>
    ///   <para>wfm:CompositeWorkflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Inter-workflow motif referring to all those workflows that have one or more sub-workflows included in them (when these sub-workflows overlap they offer different views of the global workflow). </para>
    /// labels<para>Composite workflow</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#CompositeWorkflow">http://purl.org/net/wf-motifs#CompositeWorkflow</seealso>
    let CompositeWorkflow = Prefixed_Name(wfm, "CompositeWorkflow") |> PrefixedName
    /// <summary>
    ///   <para>wfm:ComputationalStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Intra-workflow motif used to refer to activities performed by a computer. This motif applies to most of the steps of the workflow, except for those being human interaction steps.</para>
    /// labels<para>Computational step</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#ComputationalStep">http://purl.org/net/wf-motifs#ComputationalStep</seealso>
    let ComputationalStep = Prefixed_Name(wfm, "ComputationalStep") |> PrefixedName
    /// <summary>
    ///   <para>wfm:Combine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data preparation motif that refers to the step or group of steps in the workflow aggregating information from different sources. For example, the joining of two tables in a new one or the merging of three different files in a bigger one.</para>
    /// labels<para>Combine</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#Combine">http://purl.org/net/wf-motifs#Combine</seealso>
    let Combine = Prefixed_Name(wfm, "Combine") |> PrefixedName
    /// <summary>
    ///   <para>wfm:DataAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data operation motif that refers to a broad category of tasks in diverse domains. An important number of workflows are designed with the purpose of analyzing different features of input data, ranging from simple comparisons between the datasets to complex protein analysis to see whether two molecules can be docked successfully or not. </para>
    /// labels<para>Data analysis</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#DataAnalysis">http://purl.org/net/wf-motifs#DataAnalysis</seealso>
    let DataAnalysis = Prefixed_Name(wfm, "DataAnalysis") |> PrefixedName
    /// <summary>
    ///   <para>wfm:DataVisualization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Being able to show the results is as important as producing them in some workflows. Scientists use visualizations to show the conclusions of their experiments and to take important decisions in the pipeline itself. Therefore certain steps in workflows are dedicated to generation of plots and graph outputs from input data. The data visualization motif also includes the generation of tables and files for browsing and reading the results of the workflow.</para>
    /// labels<para>Data visualization</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#DataVisualization">http://purl.org/net/wf-motifs#DataVisualization</seealso>
    let DataVisualization = Prefixed_Name(wfm, "DataVisualization") |> PrefixedName

    /// <summary>
    ///   <para>wfm:FormatTransformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Workflows that bring together multiple access or analysis activities usually contain steps for format transformations. These steps preserve the content of the inputs while converting its representation format. An example would be a converter from CSV to VOTable format in the astronomy domain, a converter from FASTA to Swiss-Prott sequence in biology, or an Arff formating component for Weka in the text analysis domain.</para>
    /// labels<para>Format transformation</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#FormatTransformation">http://purl.org/net/wf-motifs#FormatTransformation</seealso>
    let FormatTransformation =
        Prefixed_Name(wfm, "FormatTransformation") |> PrefixedName

    /// <summary>
    ///   <para>wfm:Motif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A motif is a domain independent conceptual abstraction of one or more steps of a given workflow.</para>
    /// labels<para>Motif</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#Motif">http://purl.org/net/wf-motifs#Motif</seealso>
    let Motif = Prefixed_Name(wfm, "Motif") |> PrefixedName
    /// <summary>
    ///   <para>wfm:Filter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data preparation motif that refers to a filtering step or set of steps. For example, A file filtered by a set of set of keywords, a table filtered by a threshold, etc.</para>
    /// labels<para>Filter
    /// </para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#Filter">http://purl.org/net/wf-motifs#Filter</seealso>
    let Filter = Prefixed_Name(wfm, "Filter") |> PrefixedName
    /// <summary>
    ///   <para>wfm:InternalMacro</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Intra-workflow motif that refers to those groups of steps in the workflow that correspond to repetitive patterns of combining tasks. For example, if a workflow has several branches with the same sequence of repeated steps, the sequence becomes an internal macro.</para>
    /// labels<para>Internal macro</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#InternalMacro">http://purl.org/net/wf-motifs#InternalMacro</seealso>
    let InternalMacro = Prefixed_Name(wfm, "InternalMacro") |> PrefixedName
    /// <summary>
    ///   <para>wfm:OutputExtraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data preparation motif that refers to the step or set of steps in the workflow retrieving only the relevant portion from the the output of a previous step. For example, retrieving the tag value of an XML fragment.</para>
    /// labels<para>Output extraction</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#OutputExtraction">http://purl.org/net/wf-motifs#OutputExtraction</seealso>
    let OutputExtraction = Prefixed_Name(wfm, "OutputExtraction") |> PrefixedName
    /// <summary>
    ///   <para>wfm:Sort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data preparation motif that refers to the step or set of steps ordering the input by certain parameter. For example, a quicksort algorithm that takes an unordered vector and produces a sorted output.</para>
    /// labels<para>Sort</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#Sort">http://purl.org/net/wf-motifs#Sort</seealso>
    let Sort = Prefixed_Name(wfm, "Sort") |> PrefixedName
    /// <summary>
    ///   <para>wfm:StatefulInvocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Certain activities such as analysis or visualizations could be performed through interaction with stateful (web) services that allow for creation of jobs over remote grid environments. These are typically performed via invocation of multiple operations at a service endpoint. An example would be a BLAST job submission where the service invoker is responsible to first create a job, then submit the data, check the status and retrieve the results once it has finished.</para>
    /// labels<para>Stateful (asynchronous) invocation</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#StatefulInvocation">http://purl.org/net/wf-motifs#StatefulInvocation</seealso>
    let StatefulInvocation = Prefixed_Name(wfm, "StatefulInvocation") |> PrefixedName

    /// <summary>
    ///   <para>wfm:hasDataOperationMotif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object property that binds a workflow step with its correspondent data operation motif.</para>
    /// labels<para>has data operation motif</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#hasDataOperationMotif">http://purl.org/net/wf-motifs#hasDataOperationMotif</seealso>
    let hasDataOperationMotif =
        Prefixed_Name(wfm, "hasDataOperationMotif") |> PrefixedName

    /// <summary>
    ///   <para>wfm:Split</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data preparation motif that refers to the step or steps in the workflow separating an input into different outputs. For example, splitting a dataset in three different subsets to be processed in parallel in a workflow.</para>
    /// labels<para>Split</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#Split">http://purl.org/net/wf-motifs#Split</seealso>
    let Split = Prefixed_Name(wfm, "Split") |> PrefixedName
    /// <summary>
    ///   <para>wfm:StatelessInvocaton</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Intra-workflow motif that requires a step in the workflow for performing a service call or tool invocation. All the steps of a workflow are by default stateless (synchronous) invocations unless they are explicitly declared to be stateful. </para>
    /// labels<para>Stateless (synchronous) invocation</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#StatelessInvocaton">http://purl.org/net/wf-motifs#StatelessInvocaton</seealso>
    let StatelessInvocaton = Prefixed_Name(wfm, "StatelessInvocaton") |> PrefixedName
    /// <summary>
    ///   <para>wfm:hasWorkflowMotif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object property that relates a workflow to its correspondent workflow motif.</para>
    /// labels<para>has workflow motif</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#hasWorkflowMotif">http://purl.org/net/wf-motifs#hasWorkflowMotif</seealso>
    let hasWorkflowMotif = Prefixed_Name(wfm, "hasWorkflowMotif") |> PrefixedName
    /// <summary>
    ///   <para>wfm:WorkflowOverload</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Inter-workflow motif used to characterize workflows that are used to operate over different input parameter types. An example is performing an analysis over a String input parameter, or performing it over the contents of a specified File. Overloading is a direct response to the heterogeneity of environments in which workflows are used.</para>
    /// labels<para>Workflow overload</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#WorkflowOverload">http://purl.org/net/wf-motifs#WorkflowOverload</seealso>
    let WorkflowOverload = Prefixed_Name(wfm, "WorkflowOverload") |> PrefixedName
    /// <summary>
    ///   <para>wfm:hasMotif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Object property that annotates a step in the workflow, a group of steps, a subworkflow, or a workflow with a motif.</para>
    /// labels<para>has motif</para></remarks>
    /// <seealso href="http://purl.org/net/wf-motifs#hasMotif">http://purl.org/net/wf-motifs#hasMotif</seealso>
    let hasMotif = Prefixed_Name(wfm, "hasMotif") |> PrefixedName
