namespace http.eulersharp.sourceforge.net._2003._03swap.workflow.hash

open DoxAletheia

module swap_workflow =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/workflow#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Both plan and execution.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Action"></see></summary>
    let Action = _prefix "Action"
    /// <summary>
    /// Agent can be e.g. person, group, organization, mechanism.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#ExclusiveChoice"></see>
    /// </summary>
    let ExclusiveChoice = _prefix "ExclusiveChoice"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Pattern"></see>
    /// </summary>
    let Pattern = _prefix "Pattern"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Input"></see>
    /// </summary>
    let Input = _prefix "Input"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Output"></see>
    /// </summary>
    let Output = _prefix "Output"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#ParallelSplit"></see>
    /// </summary>
    let ParallelSplit = _prefix "ParallelSplit"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Resource"></see>
    /// </summary>
    let Resource = _prefix "Resource"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Role"></see>
    /// </summary>
    let Role = _prefix "Role"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Sequence"></see>
    /// </summary>
    let Sequence = _prefix "Sequence"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#SimpleMerge"></see>
    /// </summary>
    let SimpleMerge = _prefix "SimpleMerge"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Synchronization"></see>
    /// </summary>
    let Synchronization = _prefix "Synchronization"
    /// <summary>
    /// Both plan and execution.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Workflow"></see></summary>
    let Workflow = _prefix "Workflow"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#actionOf"></see>
    /// </summary>
    let actionOf = _prefix "actionOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#hasAction"></see>
    /// </summary>
    let hasAction = _prefix "hasAction"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/workflow#hasWorkflow"></see>
    /// </summary>
    let hasWorkflow = _prefix "hasWorkflow"
