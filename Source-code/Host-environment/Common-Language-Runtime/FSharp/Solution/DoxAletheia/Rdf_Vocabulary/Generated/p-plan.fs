namespace http.purl.org.net.p_plan.hash

open DoxAletheia

module p_plan =
    let _namespace_name = "http://purl.org/net/p-plan#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A p-plan:Activity represents the execution process planned in a p-plan:Step
    /// <see href="http://purl.org/net/p-plan#Activity"></see></summary>
    let Activity = _prefix "Activity"
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#Bundle"></see>
    /// </summary>
    let Bundle = _prefix "Bundle"
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#Entity"></see>
    /// </summary>
    let Entity = _prefix "Entity"
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#MultiStep"></see>
    /// </summary>
    let MultiStep = _prefix "MultiStep"
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#Step"></see>
    /// </summary>
    let Step = _prefix "Step"
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#Plan"></see>
    /// </summary>
    let Plan = _prefix "Plan"
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#Variable"></see>
    /// </summary>
    let Variable = _prefix "Variable"
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#correspondsToStep"></see>
    /// </summary>
    let correspondsToStep = _prefix "correspondsToStep"
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#correspondsToVariable"></see>
    /// </summary>
    let correspondsToVariable = _prefix "correspondsToVariable"
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#hasInputVar"></see>
    /// </summary>
    let hasInputVar = _prefix "hasInputVar"
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#hasOutputVar"></see>
    /// </summary>
    let hasOutputVar = _prefix "hasOutputVar"
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#isOutputVarOf"></see>
    /// </summary>
    let isOutputVarOf = _prefix "isOutputVarOf"
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#isDecomposedAsPlan"></see>
    /// </summary>
    let isDecomposedAsPlan = _prefix "isDecomposedAsPlan"
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#isInputVarOf"></see>
    /// </summary>
    let isInputVarOf = _prefix "isInputVarOf"
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#isPreceededBy"></see>
    /// </summary>
    let isPreceededBy = _prefix "isPreceededBy"
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#isStepOfPlan"></see>
    /// </summary>
    let isStepOfPlan = _prefix "isStepOfPlan"
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#isSubPlanOfPlan"></see>
    /// </summary>
    let isSubPlanOfPlan = _prefix "isSubPlanOfPlan"
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#isVariableOfPlan"></see>
    /// </summary>
    let isVariableOfPlan = _prefix "isVariableOfPlan"
