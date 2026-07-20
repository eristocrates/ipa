namespace https.spec.edmcouncil.org.fibo.ontology.FBC.DebtAndEquities.CreditEvents.slash

open DoxAletheia

module fibo_fbc_dae_cre =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/Bankruptcy"></see>
    /// </summary>
    let Bankruptcy = _prefix "Bankruptcy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/EntitySpecificCreditEvent"></see>
    /// </summary>
    let EntitySpecificCreditEvent = _prefix "EntitySpecificCreditEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/CreditEvent"></see>
    /// </summary>
    let CreditEvent = _prefix "CreditEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/CrossDefaultProvision"></see>
    /// </summary>
    let CrossDefaultProvision = _prefix "CrossDefaultProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/hasDefaultThresholdAmount"></see>
    /// </summary>
    let hasDefaultThresholdAmount = _prefix "hasDefaultThresholdAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/DefaultEvent"></see>
    /// </summary>
    let DefaultEvent = _prefix "DefaultEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/ObligationSpecificCreditEvent"></see>
    /// </summary>
    let ObligationSpecificCreditEvent = _prefix "ObligationSpecificCreditEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/DistressedRatingsDowngrade"></see>
    /// </summary>
    let DistressedRatingsDowngrade = _prefix "DistressedRatingsDowngrade"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/Downgrade"></see>
    /// </summary>
    let Downgrade = _prefix "Downgrade"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/FailureToPay"></see>
    /// </summary>
    let FailureToPay = _prefix "FailureToPay"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/hasGracePeriod"></see>
    /// </summary>
    let hasGracePeriod = _prefix "hasGracePeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/FailureToPayInterest"></see>
    /// </summary>
    let FailureToPayInterest = _prefix "FailureToPayInterest"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/FailureToPayPrincipal"></see>
    /// </summary>
    let FailureToPayPrincipal = _prefix "FailureToPayPrincipal"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/FilingForBankruptcy"></see>
    /// </summary>
    let FilingForBankruptcy = _prefix "FilingForBankruptcy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/HardCreditEvent"></see>
    /// </summary>
    let HardCreditEvent = _prefix "HardCreditEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/InstallmentDefault"></see>
    /// </summary>
    let InstallmentDefault = _prefix "InstallmentDefault"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/InterestObligationInLightOfDefault"></see>
    /// </summary>
    let InterestObligationInLightOfDefault =
        _prefix "InterestObligationInLightOfDefault"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/hasDefaultInterestCompoundingBasis"></see>
    /// </summary>
    let hasDefaultInterestCompoundingBasis =
        _prefix "hasDefaultInterestCompoundingBasis"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/isDefaultInterestApplicable"></see>
    /// </summary>
    let isDefaultInterestApplicable = _prefix "isDefaultInterestApplicable"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/MaturityExtension"></see>
    /// </summary>
    let MaturityExtension = _prefix "MaturityExtension"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/Moratorium"></see>
    /// </summary>
    let Moratorium = _prefix "Moratorium"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/ObligationAcceleration"></see>
    /// </summary>
    let ObligationAcceleration = _prefix "ObligationAcceleration"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/ObligationDefault"></see>
    /// </summary>
    let ObligationDefault = _prefix "ObligationDefault"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/ObligationRestructuring"></see>
    /// </summary>
    let ObligationRestructuring = _prefix "ObligationRestructuring"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/Repudiation"></see>
    /// </summary>
    let Repudiation = _prefix "Repudiation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/SoftCreditEvent"></see>
    /// </summary>
    let SoftCreditEvent = _prefix "SoftCreditEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/WriteDown"></see>
    /// </summary>
    let WriteDown = _prefix "WriteDown"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/involvesMultipleEvents"></see>
    /// </summary>
    let involvesMultipleEvents = _prefix "involvesMultipleEvents"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/isGracePeriodExtendable"></see>
    /// </summary>
    let isGracePeriodExtendable = _prefix "isGracePeriodExtendable"
