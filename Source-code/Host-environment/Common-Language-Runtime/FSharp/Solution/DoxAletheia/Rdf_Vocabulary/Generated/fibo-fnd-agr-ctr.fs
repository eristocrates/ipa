namespace https.spec.edmcouncil.org.fibo.ontology.FND.Agreements.Contracts.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_agr_ctr =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isEvidenceFor"></see>
    /// </summary>
    let isEvidenceFor =
        Namespaced_IRI.parse _namespace_name "isEvidenceFor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/AssignableContract"></see>
    /// </summary>
    let AssignableContract =
        Namespaced_IRI.parse _namespace_name "AssignableContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/TransferableContract"></see>
    /// </summary>
    let TransferableContract =
        Namespaced_IRI.parse _namespace_name "TransferableContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isAssignable"></see>
    /// </summary>
    let isAssignable =
        Namespaced_IRI.parse _namespace_name "isAssignable" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/BilateralContract"></see>
    /// </summary>
    let BilateralContract =
        Namespaced_IRI.parse _namespace_name "BilateralContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/WrittenContract"></see>
    /// </summary>
    let WrittenContract =
        Namespaced_IRI.parse _namespace_name "WrittenContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/BilateralNettingProvision"></see>
    /// </summary>
    let BilateralNettingProvision =
        Namespaced_IRI.parse _namespace_name "BilateralNettingProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NettingProvision"></see>
    /// </summary>
    let NettingProvision =
        Namespaced_IRI.parse _namespace_name "NettingProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/BreachOfContract"></see>
    /// </summary>
    let BreachOfContract =
        Namespaced_IRI.parse _namespace_name "BreachOfContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/Contract"></see>
    /// </summary>
    let Contract = Namespaced_IRI.parse _namespace_name "Contract" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractualCommitment"></see>
    /// </summary>
    let ContractualCommitment =
        Namespaced_IRI.parse _namespace_name "ContractualCommitment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/BreachOfCovenant"></see>
    /// </summary>
    let BreachOfCovenant =
        Namespaced_IRI.parse _namespace_name "BreachOfCovenant" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/CloseOutNettingProvision"></see>
    /// </summary>
    let CloseOutNettingProvision =
        Namespaced_IRI.parse _namespace_name "CloseOutNettingProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/SettlementNettingProvision"></see>
    /// </summary>
    let SettlementNettingProvision =
        Namespaced_IRI.parse _namespace_name "SettlementNettingProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/CollateralAgreement"></see>
    /// </summary>
    let CollateralAgreement =
        Namespaced_IRI.parse _namespace_name "CollateralAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isSubordinateTo"></see>
    /// </summary>
    let isSubordinateTo =
        Namespaced_IRI.parse _namespace_name "isSubordinateTo" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ConditionPrecedent"></see>
    /// </summary>
    let ConditionPrecedent =
        Namespaced_IRI.parse _namespace_name "ConditionPrecedent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractualElement"></see>
    /// </summary>
    let ContractualElement =
        Namespaced_IRI.parse _namespace_name "ContractualElement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasEffectiveDate"></see>
    /// </summary>
    let hasEffectiveDate =
        Namespaced_IRI.parse _namespace_name "hasEffectiveDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasContractParty"></see>
    /// </summary>
    let hasContractParty =
        Namespaced_IRI.parse _namespace_name "hasContractParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractParty"></see>
    /// </summary>
    let ContractParty =
        Namespaced_IRI.parse _namespace_name "ContractParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasContractualElement"></see>
    /// </summary>
    let hasContractualElement =
        Namespaced_IRI.parse _namespace_name "hasContractualElement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractDocument"></see>
    /// </summary>
    let ContractDocument =
        Namespaced_IRI.parse _namespace_name "ContractDocument" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractMilestone"></see>
    /// </summary>
    let ContractMilestone =
        Namespaced_IRI.parse _namespace_name "ContractMilestone" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MilestoneEvent"></see>
    /// </summary>
    let MilestoneEvent =
        Namespaced_IRI.parse _namespace_name "MilestoneEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractPrincipal"></see>
    /// </summary>
    let ContractPrincipal =
        Namespaced_IRI.parse _namespace_name "ContractPrincipal" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractThirdParty"></see>
    /// </summary>
    let ContractThirdParty =
        Namespaced_IRI.parse _namespace_name "ContractThirdParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractualDefinition"></see>
    /// </summary>
    let ContractualDefinition =
        Namespaced_IRI.parse _namespace_name "ContractualDefinition" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasLegalDescription"></see>
    /// </summary>
    let hasLegalDescription =
        Namespaced_IRI.parse _namespace_name "hasLegalDescription" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/Counterparty"></see>
    /// </summary>
    let Counterparty =
        Namespaced_IRI.parse _namespace_name "Counterparty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/DisclosureProvision"></see>
    /// </summary>
    let DisclosureProvision =
        Namespaced_IRI.parse _namespace_name "DisclosureProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/EarlyTerminationProvision"></see>
    /// </summary>
    let EarlyTerminationProvision =
        Namespaced_IRI.parse _namespace_name "EarlyTerminationProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/TerminationProvision"></see>
    /// </summary>
    let TerminationProvision =
        Namespaced_IRI.parse _namespace_name "TerminationProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ExtensionProvision"></see>
    /// </summary>
    let ExtensionProvision =
        Namespaced_IRI.parse _namespace_name "ExtensionProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasExtendablePeriod"></see>
    /// </summary>
    let hasExtendablePeriod =
        Namespaced_IRI.parse _namespace_name "hasExtendablePeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MasterAgreement"></see>
    /// </summary>
    let MasterAgreement =
        Namespaced_IRI.parse _namespace_name "MasterAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MilestoneSchedule"></see>
    /// </summary>
    let MilestoneSchedule =
        Namespaced_IRI.parse _namespace_name "MilestoneSchedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MultilateralContract"></see>
    /// </summary>
    let MultilateralContract =
        Namespaced_IRI.parse _namespace_name "MultilateralContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MultilateralNettingProvision"></see>
    /// </summary>
    let MultilateralNettingProvision =
        Namespaced_IRI.parse _namespace_name "MultilateralNettingProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MutualContractualAgreement"></see>
    /// </summary>
    let MutualContractualAgreement =
        Namespaced_IRI.parse _namespace_name "MutualContractualAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NonBindingTerm"></see>
    /// </summary>
    let NonBindingTerm =
        Namespaced_IRI.parse _namespace_name "NonBindingTerm" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NonTransferableContract"></see>
    /// </summary>
    let NonTransferableContract =
        Namespaced_IRI.parse _namespace_name "NonTransferableContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NotificationProvision"></see>
    /// </summary>
    let NotificationProvision =
        Namespaced_IRI.parse _namespace_name "NotificationProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NovateableContract"></see>
    /// </summary>
    let NovateableContract =
        Namespaced_IRI.parse _namespace_name "NovateableContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NovationNettingProvision"></see>
    /// </summary>
    let NovationNettingProvision =
        Namespaced_IRI.parse _namespace_name "NovationNettingProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/PaymentNettingProvision"></see>
    /// </summary>
    let PaymentNettingProvision =
        Namespaced_IRI.parse _namespace_name "PaymentNettingProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/Representation"></see>
    /// </summary>
    let Representation =
        Namespaced_IRI.parse _namespace_name "Representation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/TermSheet"></see>
    /// </summary>
    let TermSheet = Namespaced_IRI.parse _namespace_name "TermSheet" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasNonBindingTerm"></see>
    /// </summary>
    let hasNonBindingTerm =
        Namespaced_IRI.parse _namespace_name "hasNonBindingTerm" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/UnilateralContract"></see>
    /// </summary>
    let UnilateralContract =
        Namespaced_IRI.parse _namespace_name "UnilateralContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/UseOfProceedsProvision"></see>
    /// </summary>
    let UseOfProceedsProvision =
        Namespaced_IRI.parse _namespace_name "UseOfProceedsProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/VerbalContract"></see>
    /// </summary>
    let VerbalContract =
        Namespaced_IRI.parse _namespace_name "VerbalContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/Warranty"></see>
    /// </summary>
    let Warranty = Namespaced_IRI.parse _namespace_name "Warranty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasExecutionDate"></see>
    /// </summary>
    let hasExecutionDate =
        Namespaced_IRI.parse _namespace_name "hasExecutionDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasEffectiveDateTimeStamp"></see>
    /// </summary>
    let hasEffectiveDateTimeStamp =
        Namespaced_IRI.parse _namespace_name "hasEffectiveDateTimeStamp" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasExecutionDateTimeStamp"></see>
    /// </summary>
    let hasExecutionDateTimeStamp =
        Namespaced_IRI.parse _namespace_name "hasExecutionDateTimeStamp" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasCounterparty"></see>
    /// </summary>
    let hasCounterparty =
        Namespaced_IRI.parse _namespace_name "hasCounterparty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasPrincipalParty"></see>
    /// </summary>
    let hasPrincipalParty =
        Namespaced_IRI.parse _namespace_name "hasPrincipalParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isEvidencedBy"></see>
    /// </summary>
    let isEvidencedBy =
        Namespaced_IRI.parse _namespace_name "isEvidencedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/definesTermsFor"></see>
    /// </summary>
    let definesTermsFor =
        Namespaced_IRI.parse _namespace_name "definesTermsFor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasBeneficiary"></see>
    /// </summary>
    let hasBeneficiary =
        Namespaced_IRI.parse _namespace_name "hasBeneficiary" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasContractDuration"></see>
    /// </summary>
    let hasContractDuration =
        Namespaced_IRI.parse _namespace_name "hasContractDuration" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasTerm"></see>
    /// </summary>
    let hasTerm = Namespaced_IRI.parse _namespace_name "hasTerm" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasEarlyTerminationDate"></see>
    /// </summary>
    let hasEarlyTerminationDate =
        Namespaced_IRI.parse _namespace_name "hasEarlyTerminationDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasExtensionProvision"></see>
    /// </summary>
    let hasExtensionProvision =
        Namespaced_IRI.parse _namespace_name "hasExtensionProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasGoverningJurisdiction"></see>
    /// </summary>
    let hasGoverningJurisdiction =
        Namespaced_IRI.parse _namespace_name "hasGoverningJurisdiction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasMilestoneProvision"></see>
    /// </summary>
    let hasMilestoneProvision =
        Namespaced_IRI.parse _namespace_name "hasMilestoneProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasThirdParty"></see>
    /// </summary>
    let hasThirdParty =
        Namespaced_IRI.parse _namespace_name "hasThirdParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isBeneficiaryOf"></see>
    /// </summary>
    let isBeneficiaryOf =
        Namespaced_IRI.parse _namespace_name "isBeneficiaryOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isNettingAutomatic"></see>
    /// </summary>
    let isNettingAutomatic =
        Namespaced_IRI.parse _namespace_name "isNettingAutomatic" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isPrimaryContractFor"></see>
    /// </summary>
    let isPrimaryContractFor =
        Namespaced_IRI.parse _namespace_name "isPrimaryContractFor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isQualifiedBy"></see>
    /// </summary>
    let isQualifiedBy =
        Namespaced_IRI.parse _namespace_name "isQualifiedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/qualifies"></see>
    /// </summary>
    let qualifies = Namespaced_IRI.parse _namespace_name "qualifies" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/supersedes"></see>
    /// </summary>
    let supersedes = Namespaced_IRI.parse _namespace_name "supersedes" |> NamespacedName
