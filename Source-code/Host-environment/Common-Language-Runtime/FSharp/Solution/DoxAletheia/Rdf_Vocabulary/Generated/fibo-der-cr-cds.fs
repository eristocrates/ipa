namespace https.spec.edmcouncil.org.fibo.ontology.DER.CreditDerivatives.CreditDefaultSwaps.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_der_cr_cds =
    let _namespace_iri = Namespace_Iri fibo_der_cr_cds |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-der-cr-cds:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Credit Default Swaps Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_der_cr_cds, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:AssetBackedCreditDefaultSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"asset-backed credit default swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/AssetBackedCreditDefaultSwap">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/AssetBackedCreditDefaultSwap</seealso>
    let AssetBackedCreditDefaultSwap =
        Prefixed_Name(fibo_der_cr_cds, "AssetBackedCreditDefaultSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:BasketCreditDefaultSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"basket credit default swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/BasketCreditDefaultSwap">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/BasketCreditDefaultSwap</seealso>
    let BasketCreditDefaultSwap =
        Prefixed_Name(fibo_der_cr_cds, "BasketCreditDefaultSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:BasketOfCreditDefaultSwaps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"basket of credit default swaps"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/BasketOfCreditDefaultSwaps">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/BasketOfCreditDefaultSwaps</seealso>
    let BasketOfCreditDefaultSwaps =
        Prefixed_Name(fibo_der_cr_cds, "BasketOfCreditDefaultSwaps") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:CashSettlementMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cash settlement method"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CashSettlementMethod">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CashSettlementMethod</seealso>
    let CashSettlementMethod =
        Prefixed_Name(fibo_der_cr_cds, "CashSettlementMethod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:ContingentCreditDefaultSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contingent credit default swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/ContingentCreditDefaultSwap">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/ContingentCreditDefaultSwap</seealso>
    let ContingentCreditDefaultSwap =
        Prefixed_Name(fibo_der_cr_cds, "ContingentCreditDefaultSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:CreditDefaultSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit default swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CreditDefaultSwap">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CreditDefaultSwap</seealso>
    let CreditDefaultSwap =
        Prefixed_Name(fibo_der_cr_cds, "CreditDefaultSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:CreditDefaultSwapIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit default swap index"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CreditDefaultSwapIndex">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CreditDefaultSwapIndex</seealso>
    let CreditDefaultSwapIndex =
        Prefixed_Name(fibo_der_cr_cds, "CreditDefaultSwapIndex") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:CreditEventNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit event notice"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CreditEventNotice">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CreditEventNotice</seealso>
    let CreditEventNotice =
        Prefixed_Name(fibo_der_cr_cds, "CreditEventNotice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:CreditProtectionTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit protection terms"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CreditProtectionTerms">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/CreditProtectionTerms</seealso>
    let CreditProtectionTerms =
        Prefixed_Name(fibo_der_cr_cds, "CreditProtectionTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:DeliverableObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"deliverable asset"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/DeliverableObligation">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/DeliverableObligation</seealso>
    let DeliverableObligation =
        Prefixed_Name(fibo_der_cr_cds, "DeliverableObligation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:DeliverableObligationBuyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"deliverable obligation buyer"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/DeliverableObligationBuyer">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/DeliverableObligationBuyer</seealso>
    let DeliverableObligationBuyer =
        Prefixed_Name(fibo_der_cr_cds, "DeliverableObligationBuyer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:DeliverableObligationSeller</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"deliverable obligation seller"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/DeliverableObligationSeller">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/DeliverableObligationSeller</seealso>
    let DeliverableObligationSeller =
        Prefixed_Name(fibo_der_cr_cds, "DeliverableObligationSeller") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:EscrowAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"escrow agent"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/EscrowAgent">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/EscrowAgent</seealso>
    let EscrowAgent = Prefixed_Name(fibo_der_cr_cds, "EscrowAgent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:IndexCreditDefaultSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"index credit default swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/IndexCreditDefaultSwap">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/IndexCreditDefaultSwap</seealso>
    let IndexCreditDefaultSwap =
        Prefixed_Name(fibo_der_cr_cds, "IndexCreditDefaultSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:IndexTrancheCreditDefaultSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"index tranche credit default swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/IndexTrancheCreditDefaultSwap">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/IndexTrancheCreditDefaultSwap</seealso>
    let IndexTrancheCreditDefaultSwap =
        Prefixed_Name(fibo_der_cr_cds, "IndexTrancheCreditDefaultSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:LoanCreditDefaultSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"loan credit default swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/LoanCreditDefaultSwap">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/LoanCreditDefaultSwap</seealso>
    let LoanCreditDefaultSwap =
        Prefixed_Name(fibo_der_cr_cds, "LoanCreditDefaultSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:MultiNameCreditDefaultSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"multi-name credit default swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/MultiNameCreditDefaultSwap">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/MultiNameCreditDefaultSwap</seealso>
    let MultiNameCreditDefaultSwap =
        Prefixed_Name(fibo_der_cr_cds, "MultiNameCreditDefaultSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:NotifyingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"notifying party"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/NotifyingParty">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/NotifyingParty</seealso>
    let NotifyingParty =
        Prefixed_Name(fibo_der_cr_cds, "NotifyingParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:SettlementAuction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"settlement auction"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/SettlementAuction">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/SettlementAuction</seealso>
    let SettlementAuction =
        Prefixed_Name(fibo_der_cr_cds, "SettlementAuction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:SingleNameCreditDefaultSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"single name credit default swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/SingleNameCreditDefaultSwap">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/SingleNameCreditDefaultSwap</seealso>
    let SingleNameCreditDefaultSwap =
        Prefixed_Name(fibo_der_cr_cds, "SingleNameCreditDefaultSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:TriggeringEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"triggering event"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/TriggeringEvent">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/TriggeringEvent</seealso>
    let TriggeringEvent =
        Prefixed_Name(fibo_der_cr_cds, "TriggeringEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:allowsSubstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"allows substitution"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/allowsSubstitution">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/allowsSubstitution</seealso>
    let allowsSubstitution =
        Prefixed_Name(fibo_der_cr_cds, "allowsSubstitution") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:hasContractPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has contract price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/hasContractPrice">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/hasContractPrice</seealso>
    let hasContractPrice =
        Prefixed_Name(fibo_der_cr_cds, "hasContractPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:hasMinimumQuotationAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has minimum quotation amount"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/hasMinimumQuotationAmount">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/hasMinimumQuotationAmount</seealso>
    let hasMinimumQuotationAmount =
        Prefixed_Name(fibo_der_cr_cds, "hasMinimumQuotationAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:hasQuotationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has quotation method"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/hasQuotationMethod">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/hasQuotationMethod</seealso>
    let hasQuotationMethod =
        Prefixed_Name(fibo_der_cr_cds, "hasQuotationMethod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-cds:hasScheduledTerminationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has scheduled termination date"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/hasScheduledTerminationDate">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/hasScheduledTerminationDate</seealso>
    let hasScheduledTerminationDate =
        Prefixed_Name(fibo_der_cr_cds, "hasScheduledTerminationDate") |> PrefixedName
