namespace http.purl.org.net.p_plan.hash

open DoxAletheia.Rdf_Vocabulary

module p_plan =
    let _namespace_name = "http://purl.org/net/p-plan#"
    /// <summary>
    /// A p-plan:Activity represents the execution process planned in a p-plan:Step
    /// <see href="http://purl.org/net/p-plan#Activity"></see></summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#Bundle"></see>
    /// </summary>
    let Bundle = Namespaced_IRI.parse _namespace_name "Bundle" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#Entity"></see>
    /// </summary>
    let Entity = Namespaced_IRI.parse _namespace_name "Entity" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#MultiStep"></see>
    /// </summary>
    let MultiStep = Namespaced_IRI.parse _namespace_name "MultiStep" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#Step"></see>
    /// </summary>
    let Step = Namespaced_IRI.parse _namespace_name "Step" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#Plan"></see>
    /// </summary>
    let Plan = Namespaced_IRI.parse _namespace_name "Plan" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#Variable"></see>
    /// </summary>
    let Variable = Namespaced_IRI.parse _namespace_name "Variable" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#correspondsToStep"></see>
    /// </summary>
    let correspondsToStep =
        Namespaced_IRI.parse _namespace_name "correspondsToStep" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#correspondsToVariable"></see>
    /// </summary>
    let correspondsToVariable =
        Namespaced_IRI.parse _namespace_name "correspondsToVariable" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#hasInputVar"></see>
    /// </summary>
    let hasInputVar =
        Namespaced_IRI.parse _namespace_name "hasInputVar" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#hasOutputVar"></see>
    /// </summary>
    let hasOutputVar =
        Namespaced_IRI.parse _namespace_name "hasOutputVar" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#isOutputVarOf"></see>
    /// </summary>
    let isOutputVarOf =
        Namespaced_IRI.parse _namespace_name "isOutputVarOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#isDecomposedAsPlan"></see>
    /// </summary>
    let isDecomposedAsPlan =
        Namespaced_IRI.parse _namespace_name "isDecomposedAsPlan" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#isInputVarOf"></see>
    /// </summary>
    let isInputVarOf =
        Namespaced_IRI.parse _namespace_name "isInputVarOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#isPreceededBy"></see>
    /// </summary>
    let isPreceededBy =
        Namespaced_IRI.parse _namespace_name "isPreceededBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#isStepOfPlan"></see>
    /// </summary>
    let isStepOfPlan =
        Namespaced_IRI.parse _namespace_name "isStepOfPlan" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#isSubPlanOfPlan"></see>
    /// </summary>
    let isSubPlanOfPlan =
        Namespaced_IRI.parse _namespace_name "isSubPlanOfPlan" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/p-plan#isVariableOfPlan"></see>
    /// </summary>
    let isVariableOfPlan =
        Namespaced_IRI.parse _namespace_name "isVariableOfPlan" |> NamespacedName
