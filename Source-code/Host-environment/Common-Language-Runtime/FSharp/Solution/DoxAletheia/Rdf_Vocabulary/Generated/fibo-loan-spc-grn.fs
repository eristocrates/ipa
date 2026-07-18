namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansSpecific.GreenLoans.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_loan_spc_grn =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/AssessmentBoundary"></see>
    /// </summary>
    let AssessmentBoundary =
        Namespaced_IRI.parse _namespace_name "AssessmentBoundary" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/hasSpatialBoundary"></see>
    /// </summary>
    let hasSpatialBoundary =
        Namespaced_IRI.parse _namespace_name "hasSpatialBoundary" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/EnvironmentalProgram"></see>
    /// </summary>
    let EnvironmentalProgram =
        Namespaced_IRI.parse _namespace_name "EnvironmentalProgram" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/EnvironmentalProject"></see>
    /// </summary>
    let EnvironmentalProject =
        Namespaced_IRI.parse _namespace_name "EnvironmentalProject" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityKeyPerformanceIndicator"></see>
    /// </summary>
    let SustainabilityKeyPerformanceIndicator =
        Namespaced_IRI.parse _namespace_name "SustainabilityKeyPerformanceIndicator" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/hasAssessmentBoundary"></see>
    /// </summary>
    let hasAssessmentBoundary =
        Namespaced_IRI.parse _namespace_name "hasAssessmentBoundary" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/GreenLoan"></see>
    /// </summary>
    let GreenLoan = Namespaced_IRI.parse _namespace_name "GreenLoan" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/GreenProjectUseOfProceedsProvision"></see>
    /// </summary>
    let GreenProjectUseOfProceedsProvision =
        Namespaced_IRI.parse _namespace_name "GreenProjectUseOfProceedsProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/GreenProject"></see>
    /// </summary>
    let GreenProject =
        Namespaced_IRI.parse _namespace_name "GreenProject" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/ObservedIndicatorValue"></see>
    /// </summary>
    let ObservedIndicatorValue =
        Namespaced_IRI.parse _namespace_name "ObservedIndicatorValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/ObservedIndicatorValueStructure"></see>
    /// </summary>
    let ObservedIndicatorValueStructure =
        Namespaced_IRI.parse _namespace_name "ObservedIndicatorValueStructure" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityBusinessObjective"></see>
    /// </summary>
    let SustainabilityBusinessObjective =
        Namespaced_IRI.parse _namespace_name "SustainabilityBusinessObjective" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityBusinessStrategy"></see>
    /// </summary>
    let SustainabilityBusinessStrategy =
        Namespaced_IRI.parse _namespace_name "SustainabilityBusinessStrategy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityPerformanceTarget"></see>
    /// </summary>
    let SustainabilityPerformanceTarget =
        Namespaced_IRI.parse _namespace_name "SustainabilityPerformanceTarget" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityKeyPerformanceIndicatorIdentifier"></see>
    /// </summary>
    let SustainabilityKeyPerformanceIndicatorIdentifier =
        Namespaced_IRI.parse _namespace_name "SustainabilityKeyPerformanceIndicatorIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityLinkedLoan"></see>
    /// </summary>
    let SustainabilityLinkedLoan =
        Namespaced_IRI.parse _namespace_name "SustainabilityLinkedLoan" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityPerformanceTargetIdentifier"></see>
    /// </summary>
    let SustainabilityPerformanceTargetIdentifier =
        Namespaced_IRI.parse _namespace_name "SustainabilityPerformanceTargetIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TargetIndicatorValue"></see>
    /// </summary>
    let TargetIndicatorValue =
        Namespaced_IRI.parse _namespace_name "TargetIndicatorValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityStructuringAgent"></see>
    /// </summary>
    let SustainabilityStructuringAgent =
        Namespaced_IRI.parse _namespace_name "SustainabilityStructuringAgent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TransitionLoan"></see>
    /// </summary>
    let TransitionLoan =
        Namespaced_IRI.parse _namespace_name "TransitionLoan" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TransitionUseOfProceedsProvision"></see>
    /// </summary>
    let TransitionUseOfProceedsProvision =
        Namespaced_IRI.parse _namespace_name "TransitionUseOfProceedsProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TransitionStrategy"></see>
    /// </summary>
    let TransitionStrategy =
        Namespaced_IRI.parse _namespace_name "TransitionStrategy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TransitionProject"></see>
    /// </summary>
    let TransitionProject =
        Namespaced_IRI.parse _namespace_name "TransitionProject" |> NamespacedName
