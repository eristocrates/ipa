namespace https.spec.edmcouncil.org.fibo.ontology.FBC.DebtAndEquities.CreditEvents.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_dae_cre =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/Bankruptcy"></see>
    /// </summary>
    let Bankruptcy = Namespaced_IRI.parse _namespace_name "Bankruptcy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/EntitySpecificCreditEvent"></see>
    /// </summary>
    let EntitySpecificCreditEvent =
        Namespaced_IRI.parse _namespace_name "EntitySpecificCreditEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/CreditEvent"></see>
    /// </summary>
    let CreditEvent =
        Namespaced_IRI.parse _namespace_name "CreditEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/CrossDefaultProvision"></see>
    /// </summary>
    let CrossDefaultProvision =
        Namespaced_IRI.parse _namespace_name "CrossDefaultProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/hasDefaultThresholdAmount"></see>
    /// </summary>
    let hasDefaultThresholdAmount =
        Namespaced_IRI.parse _namespace_name "hasDefaultThresholdAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/DefaultEvent"></see>
    /// </summary>
    let DefaultEvent =
        Namespaced_IRI.parse _namespace_name "DefaultEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/ObligationSpecificCreditEvent"></see>
    /// </summary>
    let ObligationSpecificCreditEvent =
        Namespaced_IRI.parse _namespace_name "ObligationSpecificCreditEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/DistressedRatingsDowngrade"></see>
    /// </summary>
    let DistressedRatingsDowngrade =
        Namespaced_IRI.parse _namespace_name "DistressedRatingsDowngrade" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/Downgrade"></see>
    /// </summary>
    let Downgrade = Namespaced_IRI.parse _namespace_name "Downgrade" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/FailureToPay"></see>
    /// </summary>
    let FailureToPay =
        Namespaced_IRI.parse _namespace_name "FailureToPay" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/hasGracePeriod"></see>
    /// </summary>
    let hasGracePeriod =
        Namespaced_IRI.parse _namespace_name "hasGracePeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/FailureToPayInterest"></see>
    /// </summary>
    let FailureToPayInterest =
        Namespaced_IRI.parse _namespace_name "FailureToPayInterest" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/FailureToPayPrincipal"></see>
    /// </summary>
    let FailureToPayPrincipal =
        Namespaced_IRI.parse _namespace_name "FailureToPayPrincipal" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/FilingForBankruptcy"></see>
    /// </summary>
    let FilingForBankruptcy =
        Namespaced_IRI.parse _namespace_name "FilingForBankruptcy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/HardCreditEvent"></see>
    /// </summary>
    let HardCreditEvent =
        Namespaced_IRI.parse _namespace_name "HardCreditEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/InstallmentDefault"></see>
    /// </summary>
    let InstallmentDefault =
        Namespaced_IRI.parse _namespace_name "InstallmentDefault" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/InterestObligationInLightOfDefault"></see>
    /// </summary>
    let InterestObligationInLightOfDefault =
        Namespaced_IRI.parse _namespace_name "InterestObligationInLightOfDefault" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/hasDefaultInterestCompoundingBasis"></see>
    /// </summary>
    let hasDefaultInterestCompoundingBasis =
        Namespaced_IRI.parse _namespace_name "hasDefaultInterestCompoundingBasis" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/isDefaultInterestApplicable"></see>
    /// </summary>
    let isDefaultInterestApplicable =
        Namespaced_IRI.parse _namespace_name "isDefaultInterestApplicable" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/MaturityExtension"></see>
    /// </summary>
    let MaturityExtension =
        Namespaced_IRI.parse _namespace_name "MaturityExtension" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/Moratorium"></see>
    /// </summary>
    let Moratorium = Namespaced_IRI.parse _namespace_name "Moratorium" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/ObligationAcceleration"></see>
    /// </summary>
    let ObligationAcceleration =
        Namespaced_IRI.parse _namespace_name "ObligationAcceleration" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/ObligationDefault"></see>
    /// </summary>
    let ObligationDefault =
        Namespaced_IRI.parse _namespace_name "ObligationDefault" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/ObligationRestructuring"></see>
    /// </summary>
    let ObligationRestructuring =
        Namespaced_IRI.parse _namespace_name "ObligationRestructuring" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/Repudiation"></see>
    /// </summary>
    let Repudiation =
        Namespaced_IRI.parse _namespace_name "Repudiation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/SoftCreditEvent"></see>
    /// </summary>
    let SoftCreditEvent =
        Namespaced_IRI.parse _namespace_name "SoftCreditEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/WriteDown"></see>
    /// </summary>
    let WriteDown = Namespaced_IRI.parse _namespace_name "WriteDown" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/involvesMultipleEvents"></see>
    /// </summary>
    let involvesMultipleEvents =
        Namespaced_IRI.parse _namespace_name "involvesMultipleEvents" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/isGracePeriodExtendable"></see>
    /// </summary>
    let isGracePeriodExtendable =
        Namespaced_IRI.parse _namespace_name "isGracePeriodExtendable" |> NamespacedName
