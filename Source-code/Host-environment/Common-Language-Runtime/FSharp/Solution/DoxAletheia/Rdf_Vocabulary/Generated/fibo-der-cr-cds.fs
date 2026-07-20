namespace https.spec.edmcouncil.org.fibo.ontology.DER.CreditDerivatives.CreditDefaultSwaps.slash

open DoxAletheia

module fibo_der_cr_cds =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/AssetBackedCreditDefaultSwap"></see>
    /// </summary>
    let AssetBackedCreditDefaultSwap = _prefix "AssetBackedCreditDefaultSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CreditDefaultSwap"></see>
    /// </summary>
    let CreditDefaultSwap = _prefix "CreditDefaultSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/BasketCreditDefaultSwap"></see>
    /// </summary>
    let BasketCreditDefaultSwap = _prefix "BasketCreditDefaultSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/MultiNameCreditDefaultSwap"></see>
    /// </summary>
    let MultiNameCreditDefaultSwap = _prefix "MultiNameCreditDefaultSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/BasketOfCreditDefaultSwaps"></see>
    /// </summary>
    let BasketOfCreditDefaultSwaps = _prefix "BasketOfCreditDefaultSwaps"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CashSettlementMethod"></see>
    /// </summary>
    let CashSettlementMethod = _prefix "CashSettlementMethod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/ContingentCreditDefaultSwap"></see>
    /// </summary>
    let ContingentCreditDefaultSwap = _prefix "ContingentCreditDefaultSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/SettlementAuction"></see>
    /// </summary>
    let SettlementAuction = _prefix "SettlementAuction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/hasContractPrice"></see>
    /// </summary>
    let hasContractPrice = _prefix "hasContractPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CreditProtectionTerms"></see>
    /// </summary>
    let CreditProtectionTerms = _prefix "CreditProtectionTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/TriggeringEvent"></see>
    /// </summary>
    let TriggeringEvent = _prefix "TriggeringEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CreditDefaultSwapIndex"></see>
    /// </summary>
    let CreditDefaultSwapIndex = _prefix "CreditDefaultSwapIndex"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CreditEventNotice"></see>
    /// </summary>
    let CreditEventNotice = _prefix "CreditEventNotice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/NotifyingParty"></see>
    /// </summary>
    let NotifyingParty = _prefix "NotifyingParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/hasScheduledTerminationDate"></see>
    /// </summary>
    let hasScheduledTerminationDate = _prefix "hasScheduledTerminationDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/allowsSubstitution"></see>
    /// </summary>
    let allowsSubstitution = _prefix "allowsSubstitution"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/DeliverableObligationBuyer"></see>
    /// </summary>
    let DeliverableObligationBuyer = _prefix "DeliverableObligationBuyer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/DeliverableObligationSeller"></see>
    /// </summary>
    let DeliverableObligationSeller = _prefix "DeliverableObligationSeller"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/DeliverableObligation"></see>
    /// </summary>
    let DeliverableObligation = _prefix "DeliverableObligation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/EscrowAgent"></see>
    /// </summary>
    let EscrowAgent = _prefix "EscrowAgent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/IndexCreditDefaultSwap"></see>
    /// </summary>
    let IndexCreditDefaultSwap = _prefix "IndexCreditDefaultSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/IndexTrancheCreditDefaultSwap"></see>
    /// </summary>
    let IndexTrancheCreditDefaultSwap = _prefix "IndexTrancheCreditDefaultSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/LoanCreditDefaultSwap"></see>
    /// </summary>
    let LoanCreditDefaultSwap = _prefix "LoanCreditDefaultSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/SingleNameCreditDefaultSwap"></see>
    /// </summary>
    let SingleNameCreditDefaultSwap = _prefix "SingleNameCreditDefaultSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/hasMinimumQuotationAmount"></see>
    /// </summary>
    let hasMinimumQuotationAmount = _prefix "hasMinimumQuotationAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/hasQuotationMethod"></see>
    /// </summary>
    let hasQuotationMethod = _prefix "hasQuotationMethod"
