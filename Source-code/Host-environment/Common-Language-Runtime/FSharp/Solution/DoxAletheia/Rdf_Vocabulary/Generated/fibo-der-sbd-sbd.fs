namespace https.spec.edmcouncil.org.fibo.ontology.DER.SecurityBasedDerivatives.SecurityBasedDerivatives.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_der_sbd_sbd =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/BasketOfDebtInstruments"></see>
    /// </summary>
    let BasketOfDebtInstruments =
        Namespaced_IRI.parse _namespace_name "BasketOfDebtInstruments" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/CapitalizedLeaseObligationDebtBasket"></see>
    /// </summary>
    let CapitalizedLeaseObligationDebtBasket =
        Namespaced_IRI.parse _namespace_name "CapitalizedLeaseObligationDebtBasket" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/ContributionDebtBasket"></see>
    /// </summary>
    let ContributionDebtBasket =
        Namespaced_IRI.parse _namespace_name "ContributionDebtBasket" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/CreditFacilityDebtBasket"></see>
    /// </summary>
    let CreditFacilityDebtBasket =
        Namespaced_IRI.parse _namespace_name "CreditFacilityDebtBasket" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/DebtInstrumentDerivative"></see>
    /// </summary>
    let DebtInstrumentDerivative =
        Namespaced_IRI.parse _namespace_name "DebtInstrumentDerivative" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/SecurityBasedDerivative"></see>
    /// </summary>
    let SecurityBasedDerivative =
        Namespaced_IRI.parse _namespace_name "SecurityBasedDerivative" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/EquityDerivative"></see>
    /// </summary>
    let EquityDerivative =
        Namespaced_IRI.parse _namespace_name "EquityDerivative" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/GeneralDebtBasket"></see>
    /// </summary>
    let GeneralDebtBasket =
        Namespaced_IRI.parse _namespace_name "GeneralDebtBasket" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/IncrementalFacilityDebtBasket"></see>
    /// </summary>
    let IncrementalFacilityDebtBasket =
        Namespaced_IRI.parse _namespace_name "IncrementalFacilityDebtBasket" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/LocalLinesOfCreditDebtBasket"></see>
    /// </summary>
    let LocalLinesOfCreditDebtBasket =
        Namespaced_IRI.parse _namespace_name "LocalLinesOfCreditDebtBasket" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/Non-GuarantorDebtBasket"></see>
    /// </summary>
    let ``Non-GuarantorDebtBasket`` =
        Namespaced_IRI.parse _namespace_name "Non-GuarantorDebtBasket" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/RatioDebtBasket"></see>
    /// </summary>
    let RatioDebtBasket =
        Namespaced_IRI.parse _namespace_name "RatioDebtBasket" |> NamespacedName
