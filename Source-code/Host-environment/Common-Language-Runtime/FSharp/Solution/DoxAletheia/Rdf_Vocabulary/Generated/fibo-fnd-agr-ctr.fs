namespace https.spec.edmcouncil.org.fibo.ontology.FND.Agreements.Contracts.slash

open DoxAletheia

module fibo_fnd_agr_ctr =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isEvidenceFor"></see>
    /// </summary>
    let isEvidenceFor = _prefix "isEvidenceFor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/AssignableContract"></see>
    /// </summary>
    let AssignableContract = _prefix "AssignableContract"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/TransferableContract"></see>
    /// </summary>
    let TransferableContract = _prefix "TransferableContract"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isAssignable"></see>
    /// </summary>
    let isAssignable = _prefix "isAssignable"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/BilateralContract"></see>
    /// </summary>
    let BilateralContract = _prefix "BilateralContract"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/WrittenContract"></see>
    /// </summary>
    let WrittenContract = _prefix "WrittenContract"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/BilateralNettingProvision"></see>
    /// </summary>
    let BilateralNettingProvision = _prefix "BilateralNettingProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NettingProvision"></see>
    /// </summary>
    let NettingProvision = _prefix "NettingProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/BreachOfContract"></see>
    /// </summary>
    let BreachOfContract = _prefix "BreachOfContract"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/Contract"></see>
    /// </summary>
    let Contract = _prefix "Contract"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractualCommitment"></see>
    /// </summary>
    let ContractualCommitment = _prefix "ContractualCommitment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/BreachOfCovenant"></see>
    /// </summary>
    let BreachOfCovenant = _prefix "BreachOfCovenant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/CloseOutNettingProvision"></see>
    /// </summary>
    let CloseOutNettingProvision = _prefix "CloseOutNettingProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/SettlementNettingProvision"></see>
    /// </summary>
    let SettlementNettingProvision = _prefix "SettlementNettingProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/CollateralAgreement"></see>
    /// </summary>
    let CollateralAgreement = _prefix "CollateralAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isSubordinateTo"></see>
    /// </summary>
    let isSubordinateTo = _prefix "isSubordinateTo"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ConditionPrecedent"></see>
    /// </summary>
    let ConditionPrecedent = _prefix "ConditionPrecedent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractualElement"></see>
    /// </summary>
    let ContractualElement = _prefix "ContractualElement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasEffectiveDate"></see>
    /// </summary>
    let hasEffectiveDate = _prefix "hasEffectiveDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasContractParty"></see>
    /// </summary>
    let hasContractParty = _prefix "hasContractParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractParty"></see>
    /// </summary>
    let ContractParty = _prefix "ContractParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasContractualElement"></see>
    /// </summary>
    let hasContractualElement = _prefix "hasContractualElement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractDocument"></see>
    /// </summary>
    let ContractDocument = _prefix "ContractDocument"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractMilestone"></see>
    /// </summary>
    let ContractMilestone = _prefix "ContractMilestone"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MilestoneEvent"></see>
    /// </summary>
    let MilestoneEvent = _prefix "MilestoneEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractPrincipal"></see>
    /// </summary>
    let ContractPrincipal = _prefix "ContractPrincipal"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractThirdParty"></see>
    /// </summary>
    let ContractThirdParty = _prefix "ContractThirdParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ContractualDefinition"></see>
    /// </summary>
    let ContractualDefinition = _prefix "ContractualDefinition"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasLegalDescription"></see>
    /// </summary>
    let hasLegalDescription = _prefix "hasLegalDescription"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/Counterparty"></see>
    /// </summary>
    let Counterparty = _prefix "Counterparty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/DisclosureProvision"></see>
    /// </summary>
    let DisclosureProvision = _prefix "DisclosureProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/EarlyTerminationProvision"></see>
    /// </summary>
    let EarlyTerminationProvision = _prefix "EarlyTerminationProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/TerminationProvision"></see>
    /// </summary>
    let TerminationProvision = _prefix "TerminationProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/ExtensionProvision"></see>
    /// </summary>
    let ExtensionProvision = _prefix "ExtensionProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasExtendablePeriod"></see>
    /// </summary>
    let hasExtendablePeriod = _prefix "hasExtendablePeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MasterAgreement"></see>
    /// </summary>
    let MasterAgreement = _prefix "MasterAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MilestoneSchedule"></see>
    /// </summary>
    let MilestoneSchedule = _prefix "MilestoneSchedule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MultilateralContract"></see>
    /// </summary>
    let MultilateralContract = _prefix "MultilateralContract"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MultilateralNettingProvision"></see>
    /// </summary>
    let MultilateralNettingProvision = _prefix "MultilateralNettingProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/MutualContractualAgreement"></see>
    /// </summary>
    let MutualContractualAgreement = _prefix "MutualContractualAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NonBindingTerm"></see>
    /// </summary>
    let NonBindingTerm = _prefix "NonBindingTerm"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NonTransferableContract"></see>
    /// </summary>
    let NonTransferableContract = _prefix "NonTransferableContract"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NotificationProvision"></see>
    /// </summary>
    let NotificationProvision = _prefix "NotificationProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NovateableContract"></see>
    /// </summary>
    let NovateableContract = _prefix "NovateableContract"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/NovationNettingProvision"></see>
    /// </summary>
    let NovationNettingProvision = _prefix "NovationNettingProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/PaymentNettingProvision"></see>
    /// </summary>
    let PaymentNettingProvision = _prefix "PaymentNettingProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/Representation"></see>
    /// </summary>
    let Representation = _prefix "Representation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/TermSheet"></see>
    /// </summary>
    let TermSheet = _prefix "TermSheet"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasNonBindingTerm"></see>
    /// </summary>
    let hasNonBindingTerm = _prefix "hasNonBindingTerm"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/UnilateralContract"></see>
    /// </summary>
    let UnilateralContract = _prefix "UnilateralContract"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/UseOfProceedsProvision"></see>
    /// </summary>
    let UseOfProceedsProvision = _prefix "UseOfProceedsProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/VerbalContract"></see>
    /// </summary>
    let VerbalContract = _prefix "VerbalContract"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/Warranty"></see>
    /// </summary>
    let Warranty = _prefix "Warranty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasExecutionDate"></see>
    /// </summary>
    let hasExecutionDate = _prefix "hasExecutionDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasEffectiveDateTimeStamp"></see>
    /// </summary>
    let hasEffectiveDateTimeStamp = _prefix "hasEffectiveDateTimeStamp"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasExecutionDateTimeStamp"></see>
    /// </summary>
    let hasExecutionDateTimeStamp = _prefix "hasExecutionDateTimeStamp"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasCounterparty"></see>
    /// </summary>
    let hasCounterparty = _prefix "hasCounterparty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasPrincipalParty"></see>
    /// </summary>
    let hasPrincipalParty = _prefix "hasPrincipalParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isEvidencedBy"></see>
    /// </summary>
    let isEvidencedBy = _prefix "isEvidencedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/definesTermsFor"></see>
    /// </summary>
    let definesTermsFor = _prefix "definesTermsFor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasBeneficiary"></see>
    /// </summary>
    let hasBeneficiary = _prefix "hasBeneficiary"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasContractDuration"></see>
    /// </summary>
    let hasContractDuration = _prefix "hasContractDuration"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasTerm"></see>
    /// </summary>
    let hasTerm = _prefix "hasTerm"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasEarlyTerminationDate"></see>
    /// </summary>
    let hasEarlyTerminationDate = _prefix "hasEarlyTerminationDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasExtensionProvision"></see>
    /// </summary>
    let hasExtensionProvision = _prefix "hasExtensionProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasGoverningJurisdiction"></see>
    /// </summary>
    let hasGoverningJurisdiction = _prefix "hasGoverningJurisdiction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasMilestoneProvision"></see>
    /// </summary>
    let hasMilestoneProvision = _prefix "hasMilestoneProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/hasThirdParty"></see>
    /// </summary>
    let hasThirdParty = _prefix "hasThirdParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isBeneficiaryOf"></see>
    /// </summary>
    let isBeneficiaryOf = _prefix "isBeneficiaryOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isNettingAutomatic"></see>
    /// </summary>
    let isNettingAutomatic = _prefix "isNettingAutomatic"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isPrimaryContractFor"></see>
    /// </summary>
    let isPrimaryContractFor = _prefix "isPrimaryContractFor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/isQualifiedBy"></see>
    /// </summary>
    let isQualifiedBy = _prefix "isQualifiedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/qualifies"></see>
    /// </summary>
    let qualifies = _prefix "qualifies"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/supersedes"></see>
    /// </summary>
    let supersedes = _prefix "supersedes"
