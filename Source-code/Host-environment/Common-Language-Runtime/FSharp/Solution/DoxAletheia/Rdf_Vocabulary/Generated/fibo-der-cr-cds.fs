namespace https.spec.edmcouncil.org.fibo.ontology.DER.CreditDerivatives.CreditDefaultSwaps.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_der_cr_cds =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/AssetBackedCreditDefaultSwap"></see>
    /// </summary>
    let AssetBackedCreditDefaultSwap =
        Namespaced_IRI.parse _namespace_name "AssetBackedCreditDefaultSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CreditDefaultSwap"></see>
    /// </summary>
    let CreditDefaultSwap =
        Namespaced_IRI.parse _namespace_name "CreditDefaultSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/BasketCreditDefaultSwap"></see>
    /// </summary>
    let BasketCreditDefaultSwap =
        Namespaced_IRI.parse _namespace_name "BasketCreditDefaultSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/MultiNameCreditDefaultSwap"></see>
    /// </summary>
    let MultiNameCreditDefaultSwap =
        Namespaced_IRI.parse _namespace_name "MultiNameCreditDefaultSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/BasketOfCreditDefaultSwaps"></see>
    /// </summary>
    let BasketOfCreditDefaultSwaps =
        Namespaced_IRI.parse _namespace_name "BasketOfCreditDefaultSwaps" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CashSettlementMethod"></see>
    /// </summary>
    let CashSettlementMethod =
        Namespaced_IRI.parse _namespace_name "CashSettlementMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/ContingentCreditDefaultSwap"></see>
    /// </summary>
    let ContingentCreditDefaultSwap =
        Namespaced_IRI.parse _namespace_name "ContingentCreditDefaultSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/SettlementAuction"></see>
    /// </summary>
    let SettlementAuction =
        Namespaced_IRI.parse _namespace_name "SettlementAuction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/hasContractPrice"></see>
    /// </summary>
    let hasContractPrice =
        Namespaced_IRI.parse _namespace_name "hasContractPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CreditProtectionTerms"></see>
    /// </summary>
    let CreditProtectionTerms =
        Namespaced_IRI.parse _namespace_name "CreditProtectionTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/TriggeringEvent"></see>
    /// </summary>
    let TriggeringEvent =
        Namespaced_IRI.parse _namespace_name "TriggeringEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CreditDefaultSwapIndex"></see>
    /// </summary>
    let CreditDefaultSwapIndex =
        Namespaced_IRI.parse _namespace_name "CreditDefaultSwapIndex" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CreditEventNotice"></see>
    /// </summary>
    let CreditEventNotice =
        Namespaced_IRI.parse _namespace_name "CreditEventNotice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/NotifyingParty"></see>
    /// </summary>
    let NotifyingParty =
        Namespaced_IRI.parse _namespace_name "NotifyingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/hasScheduledTerminationDate"></see>
    /// </summary>
    let hasScheduledTerminationDate =
        Namespaced_IRI.parse _namespace_name "hasScheduledTerminationDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/allowsSubstitution"></see>
    /// </summary>
    let allowsSubstitution =
        Namespaced_IRI.parse _namespace_name "allowsSubstitution" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/DeliverableObligationBuyer"></see>
    /// </summary>
    let DeliverableObligationBuyer =
        Namespaced_IRI.parse _namespace_name "DeliverableObligationBuyer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/DeliverableObligationSeller"></see>
    /// </summary>
    let DeliverableObligationSeller =
        Namespaced_IRI.parse _namespace_name "DeliverableObligationSeller" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/DeliverableObligation"></see>
    /// </summary>
    let DeliverableObligation =
        Namespaced_IRI.parse _namespace_name "DeliverableObligation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/EscrowAgent"></see>
    /// </summary>
    let EscrowAgent =
        Namespaced_IRI.parse _namespace_name "EscrowAgent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/IndexCreditDefaultSwap"></see>
    /// </summary>
    let IndexCreditDefaultSwap =
        Namespaced_IRI.parse _namespace_name "IndexCreditDefaultSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/IndexTrancheCreditDefaultSwap"></see>
    /// </summary>
    let IndexTrancheCreditDefaultSwap =
        Namespaced_IRI.parse _namespace_name "IndexTrancheCreditDefaultSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/LoanCreditDefaultSwap"></see>
    /// </summary>
    let LoanCreditDefaultSwap =
        Namespaced_IRI.parse _namespace_name "LoanCreditDefaultSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/SingleNameCreditDefaultSwap"></see>
    /// </summary>
    let SingleNameCreditDefaultSwap =
        Namespaced_IRI.parse _namespace_name "SingleNameCreditDefaultSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/hasMinimumQuotationAmount"></see>
    /// </summary>
    let hasMinimumQuotationAmount =
        Namespaced_IRI.parse _namespace_name "hasMinimumQuotationAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/hasQuotationMethod"></see>
    /// </summary>
    let hasQuotationMethod =
        Namespaced_IRI.parse _namespace_name "hasQuotationMethod" |> NamespacedName
