namespace http.eulersharp.sourceforge.net._2003._03swap.workflow.hash

open DoxAletheia.Rdf_Vocabulary

module swap_workflow =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/workflow#"
    /// <summary>
    /// Both plan and execution.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Action"></see></summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName
    /// <summary>
    /// Agent can be e.g. person, group, organization, mechanism.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#ExclusiveChoice"></see>
    /// </summary>
    let ExclusiveChoice =
        Namespaced_IRI.parse _namespace_name "ExclusiveChoice" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Pattern"></see>
    /// </summary>
    let Pattern = Namespaced_IRI.parse _namespace_name "Pattern" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Input"></see>
    /// </summary>
    let Input = Namespaced_IRI.parse _namespace_name "Input" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Output"></see>
    /// </summary>
    let Output = Namespaced_IRI.parse _namespace_name "Output" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#ParallelSplit"></see>
    /// </summary>
    let ParallelSplit =
        Namespaced_IRI.parse _namespace_name "ParallelSplit" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Resource"></see>
    /// </summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Role"></see>
    /// </summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Sequence"></see>
    /// </summary>
    let Sequence = Namespaced_IRI.parse _namespace_name "Sequence" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#SimpleMerge"></see>
    /// </summary>
    let SimpleMerge =
        Namespaced_IRI.parse _namespace_name "SimpleMerge" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Synchronization"></see>
    /// </summary>
    let Synchronization =
        Namespaced_IRI.parse _namespace_name "Synchronization" |> NamespacedName

    /// <summary>
    /// Both plan and execution.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Workflow"></see></summary>
    let Workflow = Namespaced_IRI.parse _namespace_name "Workflow" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#actionOf"></see>
    /// </summary>
    let actionOf = Namespaced_IRI.parse _namespace_name "actionOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#hasAction"></see>
    /// </summary>
    let hasAction = Namespaced_IRI.parse _namespace_name "hasAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#hasWorkflow"></see>
    /// </summary>
    let hasWorkflow =
        Namespaced_IRI.parse _namespace_name "hasWorkflow" |> NamespacedName
