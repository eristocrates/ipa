namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansSpecific.GreenLoans.slash

open DoxAletheia

module fibo_loan_spc_grn =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/AssessmentBoundary"></see>
    /// </summary>
    let AssessmentBoundary = _prefix "AssessmentBoundary"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/hasSpatialBoundary"></see>
    /// </summary>
    let hasSpatialBoundary = _prefix "hasSpatialBoundary"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/EnvironmentalProgram"></see>
    /// </summary>
    let EnvironmentalProgram = _prefix "EnvironmentalProgram"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/EnvironmentalProject"></see>
    /// </summary>
    let EnvironmentalProject = _prefix "EnvironmentalProject"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityKeyPerformanceIndicator"></see>
    /// </summary>
    let SustainabilityKeyPerformanceIndicator =
        _prefix "SustainabilityKeyPerformanceIndicator"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/hasAssessmentBoundary"></see>
    /// </summary>
    let hasAssessmentBoundary = _prefix "hasAssessmentBoundary"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/GreenLoan"></see>
    /// </summary>
    let GreenLoan = _prefix "GreenLoan"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/GreenProjectUseOfProceedsProvision"></see>
    /// </summary>
    let GreenProjectUseOfProceedsProvision =
        _prefix "GreenProjectUseOfProceedsProvision"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/GreenProject"></see>
    /// </summary>
    let GreenProject = _prefix "GreenProject"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/ObservedIndicatorValue"></see>
    /// </summary>
    let ObservedIndicatorValue = _prefix "ObservedIndicatorValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/ObservedIndicatorValueStructure"></see>
    /// </summary>
    let ObservedIndicatorValueStructure = _prefix "ObservedIndicatorValueStructure"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityBusinessObjective"></see>
    /// </summary>
    let SustainabilityBusinessObjective = _prefix "SustainabilityBusinessObjective"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityBusinessStrategy"></see>
    /// </summary>
    let SustainabilityBusinessStrategy = _prefix "SustainabilityBusinessStrategy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityPerformanceTarget"></see>
    /// </summary>
    let SustainabilityPerformanceTarget = _prefix "SustainabilityPerformanceTarget"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityKeyPerformanceIndicatorIdentifier"></see>
    /// </summary>
    let SustainabilityKeyPerformanceIndicatorIdentifier =
        _prefix "SustainabilityKeyPerformanceIndicatorIdentifier"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityLinkedLoan"></see>
    /// </summary>
    let SustainabilityLinkedLoan = _prefix "SustainabilityLinkedLoan"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityPerformanceTargetIdentifier"></see>
    /// </summary>
    let SustainabilityPerformanceTargetIdentifier =
        _prefix "SustainabilityPerformanceTargetIdentifier"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TargetIndicatorValue"></see>
    /// </summary>
    let TargetIndicatorValue = _prefix "TargetIndicatorValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityStructuringAgent"></see>
    /// </summary>
    let SustainabilityStructuringAgent = _prefix "SustainabilityStructuringAgent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TransitionLoan"></see>
    /// </summary>
    let TransitionLoan = _prefix "TransitionLoan"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TransitionUseOfProceedsProvision"></see>
    /// </summary>
    let TransitionUseOfProceedsProvision = _prefix "TransitionUseOfProceedsProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TransitionStrategy"></see>
    /// </summary>
    let TransitionStrategy = _prefix "TransitionStrategy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TransitionProject"></see>
    /// </summary>
    let TransitionProject = _prefix "TransitionProject"
