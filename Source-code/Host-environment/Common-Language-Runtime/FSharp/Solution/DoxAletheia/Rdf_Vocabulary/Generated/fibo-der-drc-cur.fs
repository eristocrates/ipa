namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.CurrencyContracts.slash

open DoxAletheia

module fibo_der_drc_cur =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyDerivative"></see>
    /// </summary>
    let CurrencyDerivative = _prefix "CurrencyDerivative"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyForward"></see>
    /// </summary>
    let CurrencyForward = _prefix "CurrencyForward"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/hasForwardExchangeRate"></see>
    /// </summary>
    let hasForwardExchangeRate = _prefix "hasForwardExchangeRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyForwardOutright"></see>
    /// </summary>
    let CurrencyForwardOutright = _prefix "CurrencyForwardOutright"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencySpotContract"></see>
    /// </summary>
    let CurrencySpotContract = _prefix "CurrencySpotContract"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencySwap"></see>
    /// </summary>
    let CurrencySwap = _prefix "CurrencySwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyOption"></see>
    /// </summary>
    let CurrencyOption = _prefix "CurrencyOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/hasSpotExchangeRate"></see>
    /// </summary>
    let hasSpotExchangeRate = _prefix "hasSpotExchangeRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencySpotForwardSwap"></see>
    /// </summary>
    let CurrencySpotForwardSwap = _prefix "CurrencySpotForwardSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyVolatilityOption"></see>
    /// </summary>
    let CurrencyVolatilityOption = _prefix "CurrencyVolatilityOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/ForeignExchangeMasterAgreement"></see>
    /// </summary>
    let ForeignExchangeMasterAgreement = _prefix "ForeignExchangeMasterAgreement"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/ForeignExchangeSettlementNettingProvision"></see>
    /// </summary>
    let ForeignExchangeSettlementNettingProvision =
        _prefix "ForeignExchangeSettlementNettingProvision"
