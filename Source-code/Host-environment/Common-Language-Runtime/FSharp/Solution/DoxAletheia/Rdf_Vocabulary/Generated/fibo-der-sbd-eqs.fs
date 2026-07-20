namespace https.spec.edmcouncil.org.fibo.ontology.DER.SecurityBasedDerivatives.EquitySwaps.slash

open DoxAletheia

module fibo_der_sbd_eqs =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/DispersionSwapIndexConstituentsLeg"></see>
    /// </summary>
    let DispersionSwapIndexConstituentsLeg =
        _prefix "DispersionSwapIndexConstituentsLeg"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/DispersionSwapIndexLeg"></see>
    /// </summary>
    let DispersionSwapIndexLeg = _prefix "DispersionSwapIndexLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/DividendLeg"></see>
    /// </summary>
    let DividendLeg = _prefix "DividendLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/SpecialDividendLegTerms"></see>
    /// </summary>
    let SpecialDividendLegTerms = _prefix "SpecialDividendLegTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/QualifyingDividendPeriod"></see>
    /// </summary>
    let QualifyingDividendPeriod = _prefix "QualifyingDividendPeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/DividendSwap"></see>
    /// </summary>
    let DividendSwap = _prefix "DividendSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquitySwap"></see>
    /// </summary>
    let EquitySwap = _prefix "EquitySwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityCorrelationSwap"></see>
    /// </summary>
    let EquityCorrelationSwap = _prefix "EquityCorrelationSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityPriceReturnSwap"></see>
    /// </summary>
    let EquityPriceReturnSwap = _prefix "EquityPriceReturnSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityReturnLeg"></see>
    /// </summary>
    let EquityReturnLeg = _prefix "EquityReturnLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityTotalReturnSwap"></see>
    /// </summary>
    let EquityTotalReturnSwap = _prefix "EquityTotalReturnSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityVarianceSwap"></see>
    /// </summary>
    let EquityVarianceSwap = _prefix "EquityVarianceSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityVolatilitySwap"></see>
    /// </summary>
    let EquityVolatilitySwap = _prefix "EquityVolatilitySwap"
