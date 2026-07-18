namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.CurrencyContracts.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_der_drc_cur =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyDerivative"></see>
    /// </summary>
    let CurrencyDerivative =
        Namespaced_IRI.parse _namespace_name "CurrencyDerivative" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyForward"></see>
    /// </summary>
    let CurrencyForward =
        Namespaced_IRI.parse _namespace_name "CurrencyForward" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/hasForwardExchangeRate"></see>
    /// </summary>
    let hasForwardExchangeRate =
        Namespaced_IRI.parse _namespace_name "hasForwardExchangeRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyForwardOutright"></see>
    /// </summary>
    let CurrencyForwardOutright =
        Namespaced_IRI.parse _namespace_name "CurrencyForwardOutright" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencySpotContract"></see>
    /// </summary>
    let CurrencySpotContract =
        Namespaced_IRI.parse _namespace_name "CurrencySpotContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencySwap"></see>
    /// </summary>
    let CurrencySwap =
        Namespaced_IRI.parse _namespace_name "CurrencySwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyOption"></see>
    /// </summary>
    let CurrencyOption =
        Namespaced_IRI.parse _namespace_name "CurrencyOption" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/hasSpotExchangeRate"></see>
    /// </summary>
    let hasSpotExchangeRate =
        Namespaced_IRI.parse _namespace_name "hasSpotExchangeRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencySpotForwardSwap"></see>
    /// </summary>
    let CurrencySpotForwardSwap =
        Namespaced_IRI.parse _namespace_name "CurrencySpotForwardSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyVolatilityOption"></see>
    /// </summary>
    let CurrencyVolatilityOption =
        Namespaced_IRI.parse _namespace_name "CurrencyVolatilityOption" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/ForeignExchangeMasterAgreement"></see>
    /// </summary>
    let ForeignExchangeMasterAgreement =
        Namespaced_IRI.parse _namespace_name "ForeignExchangeMasterAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/ForeignExchangeSettlementNettingProvision"></see>
    /// </summary>
    let ForeignExchangeSettlementNettingProvision =
        Namespaced_IRI.parse _namespace_name "ForeignExchangeSettlementNettingProvision" |> NamespacedName
