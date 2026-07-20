namespace https.spec.edmcouncil.org.fibo.ontology.DER.SecurityBasedDerivatives.SecurityBasedDerivatives.slash

open DoxAletheia

module fibo_der_sbd_sbd =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/BasketOfDebtInstruments"></see>
    /// </summary>
    let BasketOfDebtInstruments = _prefix "BasketOfDebtInstruments"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/CapitalizedLeaseObligationDebtBasket"></see>
    /// </summary>
    let CapitalizedLeaseObligationDebtBasket =
        _prefix "CapitalizedLeaseObligationDebtBasket"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/ContributionDebtBasket"></see>
    /// </summary>
    let ContributionDebtBasket = _prefix "ContributionDebtBasket"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/CreditFacilityDebtBasket"></see>
    /// </summary>
    let CreditFacilityDebtBasket = _prefix "CreditFacilityDebtBasket"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/DebtInstrumentDerivative"></see>
    /// </summary>
    let DebtInstrumentDerivative = _prefix "DebtInstrumentDerivative"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/SecurityBasedDerivative"></see>
    /// </summary>
    let SecurityBasedDerivative = _prefix "SecurityBasedDerivative"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/EquityDerivative"></see>
    /// </summary>
    let EquityDerivative = _prefix "EquityDerivative"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/GeneralDebtBasket"></see>
    /// </summary>
    let GeneralDebtBasket = _prefix "GeneralDebtBasket"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/IncrementalFacilityDebtBasket"></see>
    /// </summary>
    let IncrementalFacilityDebtBasket = _prefix "IncrementalFacilityDebtBasket"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/LocalLinesOfCreditDebtBasket"></see>
    /// </summary>
    let LocalLinesOfCreditDebtBasket = _prefix "LocalLinesOfCreditDebtBasket"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/Non-GuarantorDebtBasket"></see>
    /// </summary>
    let ``Non-GuarantorDebtBasket`` = _prefix "Non-GuarantorDebtBasket"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/RatioDebtBasket"></see>
    /// </summary>
    let RatioDebtBasket = _prefix "RatioDebtBasket"
