namespace https.spec.edmcouncil.org.fibo.ontology.FND.GoalsAndObjectives.Objectives.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_gao_obj =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Aim"></see>
    /// </summary>
    let Aim = Namespaced_IRI.parse _namespace_name "Aim" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/isAddressedBy"></see>
    /// </summary>
    let isAddressedBy =
        Namespaced_IRI.parse _namespace_name "isAddressedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Approach"></see>
    /// </summary>
    let Approach = Namespaced_IRI.parse _namespace_name "Approach" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/addresses"></see>
    /// </summary>
    let addresses = Namespaced_IRI.parse _namespace_name "addresses" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/hasObjective"></see>
    /// </summary>
    let hasObjective =
        Namespaced_IRI.parse _namespace_name "hasObjective" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Objective"></see>
    /// </summary>
    let Objective = Namespaced_IRI.parse _namespace_name "Objective" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/BusinessObjective"></see>
    /// </summary>
    let BusinessObjective =
        Namespaced_IRI.parse _namespace_name "BusinessObjective" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/BusinessStrategy"></see>
    /// </summary>
    let BusinessStrategy =
        Namespaced_IRI.parse _namespace_name "BusinessStrategy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Strategy"></see>
    /// </summary>
    let Strategy = Namespaced_IRI.parse _namespace_name "Strategy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/DistributionStrategy"></see>
    /// </summary>
    let DistributionStrategy =
        Namespaced_IRI.parse _namespace_name "DistributionStrategy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/FinancialObjective"></see>
    /// </summary>
    let FinancialObjective =
        Namespaced_IRI.parse _namespace_name "FinancialObjective" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Goal"></see>
    /// </summary>
    let Goal = Namespaced_IRI.parse _namespace_name "Goal" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/InvestmentObjective"></see>
    /// </summary>
    let InvestmentObjective =
        Namespaced_IRI.parse _namespace_name "InvestmentObjective" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/LocalInvestmentObjective"></see>
    /// </summary>
    let LocalInvestmentObjective =
        Namespaced_IRI.parse _namespace_name "LocalInvestmentObjective" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Method"></see>
    /// </summary>
    let Method = Namespaced_IRI.parse _namespace_name "Method" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Program"></see>
    /// </summary>
    let Program = Namespaced_IRI.parse _namespace_name "Program" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/hasGoal"></see>
    /// </summary>
    let hasGoal = Namespaced_IRI.parse _namespace_name "hasGoal" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/ProgramIdentifier"></see>
    /// </summary>
    let ProgramIdentifier =
        Namespaced_IRI.parse _namespace_name "ProgramIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/ProgramName"></see>
    /// </summary>
    let ProgramName =
        Namespaced_IRI.parse _namespace_name "ProgramName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Project"></see>
    /// </summary>
    let Project = Namespaced_IRI.parse _namespace_name "Project" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/ProjectIdentifier"></see>
    /// </summary>
    let ProjectIdentifier =
        Namespaced_IRI.parse _namespace_name "ProjectIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/ProjectName"></see>
    /// </summary>
    let ProjectName =
        Namespaced_IRI.parse _namespace_name "ProjectName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/SalesStrategy"></see>
    /// </summary>
    let SalesStrategy =
        Namespaced_IRI.parse _namespace_name "SalesStrategy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Study"></see>
    /// </summary>
    let Study = Namespaced_IRI.parse _namespace_name "Study" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/TripleBottomLineObjective"></see>
    /// </summary>
    let TripleBottomLineObjective =
        Namespaced_IRI.parse _namespace_name "TripleBottomLineObjective" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/hasStrategy"></see>
    /// </summary>
    let hasStrategy =
        Namespaced_IRI.parse _namespace_name "hasStrategy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/usesMethod"></see>
    /// </summary>
    let usesMethod = Namespaced_IRI.parse _namespace_name "usesMethod" |> NamespacedName
