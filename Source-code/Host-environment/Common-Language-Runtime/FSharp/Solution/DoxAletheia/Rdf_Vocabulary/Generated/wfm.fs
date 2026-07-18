namespace http.purl.org.net.wf_motifs.hash

open DoxAletheia.Rdf_Vocabulary

module wfm =
    let _namespace_name = "http://purl.org/net/wf-motifs#"

    /// <summary>
    ///  Inter-workflow motif used to characterize the workflows that perform an atomic unit of functionality, which effectively requires no sub-workflow usage. Typically these workflows are designed to be included in other workflows. Atomic workflows are the main mechanism of modularizing functionality within scientific workflows.
    /// <see href="http://purl.org/net/wf-motifs#AtomicWorkflow"></see></summary>
    let AtomicWorkflow =
        Namespaced_IRI.parse _namespace_name "AtomicWorkflow" |> NamespacedName

    /// <summary>
    /// Workflow motif that relates workflows with each other by determining whether different workflows are a composition of each other (composite workflow) or not (atomic workflow), or they have a very similar composition but work for different inputs (workflow overloading).
    /// <see href="http://purl.org/net/wf-motifs#InterWorkflowMotif"></see></summary>
    let InterWorkflowMotif =
        Namespaced_IRI.parse _namespace_name "InterWorkflowMotif" |> NamespacedName

    /// <summary>
    /// Data preparation motif that refers to the step or group of steps in the workflow aggregating information from different sources. For example, the joining of two tables in a new one or the merging of three different files in a bigger one.
    /// <see href="http://purl.org/net/wf-motifs#Combine"></see></summary>
    let Combine = Namespaced_IRI.parse _namespace_name "Combine" |> NamespacedName

    /// <summary>
    /// Data, as it is originally retrieved, may need several transformations before being able to be used in a workflow step. These steps, typically known as ”Shims” [Duncan Hull et al. Treating shimantic web syndrome with ontologies. In AKT Workshop on Semantic Web Services, 2004.], can be annotated using the Data Preparation motif.
    /// <see href="http://purl.org/net/wf-motifs#DataPreparation"></see></summary>
    let DataPreparation =
        Namespaced_IRI.parse _namespace_name "DataPreparation" |> NamespacedName

    /// <summary>
    /// Inter-workflow motif referring to all those workflows that have one or more sub-workflows included in them (when these sub-workflows overlap they offer different views of the global workflow).
    /// <see href="http://purl.org/net/wf-motifs#CompositeWorkflow"></see></summary>
    let CompositeWorkflow =
        Namespaced_IRI.parse _namespace_name "CompositeWorkflow" |> NamespacedName

    /// <summary>
    /// Intra-workflow motif used to refer to activities performed by a computer. This motif applies to most of the steps of the workflow, except for those being human interaction steps.
    /// <see href="http://purl.org/net/wf-motifs#ComputationalStep"></see></summary>
    let ComputationalStep =
        Namespaced_IRI.parse _namespace_name "ComputationalStep" |> NamespacedName

    /// <summary>
    /// Workflow motif that describes a step or a series of steps within a single workflow.
    /// <see href="http://purl.org/net/wf-motifs#IntraWorkflowMotif"></see></summary>
    let IntraWorkflowMotif =
        Namespaced_IRI.parse _namespace_name "IntraWorkflowMotif" |> NamespacedName

    /// <summary>
    /// Data operation motif that refers to a broad category of tasks in diverse domains. An important number of workflows are designed with the purpose of analyzing different features of input data, ranging from simple comparisons between the datasets to complex protein analysis to see whether two molecules can be docked successfully or not.
    /// <see href="http://purl.org/net/wf-motifs#DataAnalysis"></see></summary>
    let DataAnalysis =
        Namespaced_IRI.parse _namespace_name "DataAnalysis" |> NamespacedName

    /// <summary>
    /// A data operation motif describes the data manipulation and/or transformation carried out by a step in the workflow, a collection of steps in the workflow or a sub-workflow.
    /// <see href="http://purl.org/net/wf-motifs#DataOperationMotif"></see></summary>
    let DataOperationMotif =
        Namespaced_IRI.parse _namespace_name "DataOperationMotif" |> NamespacedName

    /// <summary>
    /// Data operation motif that refers to the step or series of steps for cleaning and curating data in a workflow. Typically these steps are undertaken by sophisticated tooling/services, or by human interactions. A data cleaning step preserves and enriches the content of data (e.g., by a user’s annotation of a result with additional information, detecting and removing inconsistencies on the data, etc.).
    /// <see href="http://purl.org/net/wf-motifs#DataCleaning"></see></summary>
    let DataCleaning =
        Namespaced_IRI.parse _namespace_name "DataCleaning" |> NamespacedName

    /// <summary>
    /// Certain analysis activities that are performed via external tools or services require the submission of data to a location accessible by the service/tool (i.e., a web or a local directory respectively). In such cases the workflow contains dedicated step(s) for the upload/transfer of data to these locations. The same applies to the outputs, in which case a data download/retrieval step is used to chain the data to the next steps of the workflow.
    /// <see href="http://purl.org/net/wf-motifs#DataMovement"></see></summary>
    let DataMovement =
        Namespaced_IRI.parse _namespace_name "DataMovement" |> NamespacedName

    /// <summary>
    /// A motif is a domain independent conceptual abstraction of one or more steps of a given workflow.
    /// <see href="http://purl.org/net/wf-motifs#Motif"></see></summary>
    let Motif = Namespaced_IRI.parse _namespace_name "Motif" |> NamespacedName

    /// <summary>
    /// Workflows exploit heterogeneous data sources, remote databases, repositories and other web resources mostly exposed via SOAP or REST services. Scientific data deposited in these repositories are retrieved through query and retrieval steps inside workflows. The data retrieval motif identifies those tasks within the workflow which are responsible for retrieving data from external sources into the workflow environment.
    /// <see href="http://purl.org/net/wf-motifs#DataRetrieval"></see></summary>
    let DataRetrieval =
        Namespaced_IRI.parse _namespace_name "DataRetrieval" |> NamespacedName

    /// <summary>
    /// Being able to show the results is as important as producing them in some workflows. Scientists use visualizations to show the conclusions of their experiments and to take important decisions in the pipeline itself. Therefore certain steps in workflows are dedicated to generation of plots and graph outputs from input data. The data visualization motif also includes the generation of tables and files for browsing and reading the results of the workflow.
    /// <see href="http://purl.org/net/wf-motifs#DataVisualization"></see></summary>
    let DataVisualization =
        Namespaced_IRI.parse _namespace_name "DataVisualization" |> NamespacedName

    /// <summary>
    /// Data preparation motif that refers to a filtering step or set of steps. For example, A file filtered by a set of set of keywords, a table filtered by a threshold, etc.
    /// <see href="http://purl.org/net/wf-motifs#Filter"></see></summary>
    let Filter = Namespaced_IRI.parse _namespace_name "Filter" |> NamespacedName

    /// <summary>
    /// Workflows that bring together multiple access or analysis activities usually contain steps for format transformations. These steps preserve the content of the inputs while converting its representation format. An example would be a converter from CSV to VOTable format in the astronomy domain, a converter from FASTA to Swiss-Prott sequence in biology, or an Arff formating component for Weka in the text analysis domain.
    /// <see href="http://purl.org/net/wf-motifs#FormatTransformation"></see></summary>
    let FormatTransformation =
        Namespaced_IRI.parse _namespace_name "FormatTransformation" |> NamespacedName

    /// <summary>
    /// Data preparation motif that refers to the step or set of steps that reorganize the input into different groups. For example, grouping a table by a certain category.
    /// <see href="http://purl.org/net/wf-motifs#Group"></see></summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName

    /// <summary>
    /// Intra-workflow motif used to characterize the activities that require human inputs during their execution. For example, manual data curation of a table for a future step in the workflow, cleaning and filtering steps (such as selecting a specific dataset to continue the experiment), etc.
    /// <see href="http://purl.org/net/wf-motifs#HumanInteractionStep"></see></summary>
    let HumanInteractionStep =
        Namespaced_IRI.parse _namespace_name "HumanInteractionStep" |> NamespacedName

    /// <summary>
    /// Data preparation motif that refers to the step or set of steps dedicated to generate an aggregation of multiple parameters and scripts for tools and external services. For example, the generation of queries for input retrieval through an aggregation of multiple parameters, the generation of scripts to be executed in further steps, etc.
    /// <see href="http://purl.org/net/wf-motifs#InputAugmentation"></see></summary>
    let InputAugmentation =
        Namespaced_IRI.parse _namespace_name "InputAugmentation" |> NamespacedName

    /// <summary>
    /// Motif that describes how a data operation motif is realized (i.e., implemented) within a workflow. For example, a visualization step (data operation motif) can be realized in different ways: via a stateful multi-step invocation, through a single stateless invocation (depending on the environmental constraints and nature of the services), or via a sub-workflow.
    /// <see href="http://purl.org/net/wf-motifs#WorkflowMotif"></see></summary>
    let WorkflowMotif =
        Namespaced_IRI.parse _namespace_name "WorkflowMotif" |> NamespacedName

    /// <summary>
    /// Intra-workflow motif that refers to those groups of steps in the workflow that correspond to repetitive patterns of combining tasks. For example, if a workflow has several branches with the same sequence of repeated steps, the sequence becomes an internal macro.
    /// <see href="http://purl.org/net/wf-motifs#InternalMacro"></see></summary>
    let InternalMacro =
        Namespaced_IRI.parse _namespace_name "InternalMacro" |> NamespacedName

    /// <summary>
    /// Data preparation motif that refers to the step or set of steps in the workflow retrieving only the relevant portion from the the output of a previous step. For example, retrieving the tag value of an XML fragment.
    /// <see href="http://purl.org/net/wf-motifs#OutputExtraction"></see></summary>
    let OutputExtraction =
        Namespaced_IRI.parse _namespace_name "OutputExtraction" |> NamespacedName

    /// <summary>
    /// Data preparation motif that refers to the step or set of steps ordering the input by certain parameter. For example, a quicksort algorithm that takes an unordered vector and produces a sorted output.
    /// <see href="http://purl.org/net/wf-motifs#Sort"></see></summary>
    let Sort = Namespaced_IRI.parse _namespace_name "Sort" |> NamespacedName
    /// <summary>
    /// Data preparation motif that refers to the step or steps in the workflow separating an input into different outputs. For example, splitting a dataset in three different subsets to be processed in parallel in a workflow.
    /// <see href="http://purl.org/net/wf-motifs#Split"></see></summary>
    let Split = Namespaced_IRI.parse _namespace_name "Split" |> NamespacedName

    /// <summary>
    /// Certain activities such as analysis or visualizations could be performed through interaction with stateful (web) services that allow for creation of jobs over remote grid environments. These are typically performed via invocation of multiple operations at a service endpoint. An example would be a BLAST job submission where the service invoker is responsible to first create a job, then submit the data, check the status and retrieve the results once it has finished.
    /// <see href="http://purl.org/net/wf-motifs#StatefulInvocation"></see></summary>
    let StatefulInvocation =
        Namespaced_IRI.parse _namespace_name "StatefulInvocation" |> NamespacedName

    /// <summary>
    /// Intra-workflow motif that requires a step in the workflow for performing a service call or tool invocation. All the steps of a workflow are by default stateless (synchronous) invocations unless they are explicitly declared to be stateful.
    /// <see href="http://purl.org/net/wf-motifs#StatelessInvocaton"></see></summary>
    let StatelessInvocaton =
        Namespaced_IRI.parse _namespace_name "StatelessInvocaton" |> NamespacedName

    /// <summary>
    /// Inter-workflow motif used to characterize workflows that are used to operate over different input parameter types. An example is performing an analysis over a String input parameter, or performing it over the contents of a specified File. Overloading is a direct response to the heterogeneity of environments in which workflows are used.
    /// <see href="http://purl.org/net/wf-motifs#WorkflowOverload"></see></summary>
    let WorkflowOverload =
        Namespaced_IRI.parse _namespace_name "WorkflowOverload" |> NamespacedName

    /// <summary>
    /// Object property that binds a workflow step with its correspondent data operation motif.
    /// <see href="http://purl.org/net/wf-motifs#hasDataOperationMotif"></see></summary>
    let hasDataOperationMotif =
        Namespaced_IRI.parse _namespace_name "hasDataOperationMotif" |> NamespacedName

    /// <summary>
    /// Object property that annotates a step in the workflow, a group of steps, a subworkflow, or a workflow with a motif.
    /// <see href="http://purl.org/net/wf-motifs#hasMotif"></see></summary>
    let hasMotif = Namespaced_IRI.parse _namespace_name "hasMotif" |> NamespacedName

    /// <summary>
    /// Object property that relates a workflow to its correspondent workflow motif.
    /// <see href="http://purl.org/net/wf-motifs#hasWorkflowMotif"></see></summary>
    let hasWorkflowMotif =
        Namespaced_IRI.parse _namespace_name "hasWorkflowMotif" |> NamespacedName
