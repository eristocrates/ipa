namespace https.spec.edmcouncil.org.fibo.ontology.DER.SecurityBasedDerivatives.EquitySwaps.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_der_sbd_eqs =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/DispersionSwapIndexConstituentsLeg"></see>
    /// </summary>
    let DispersionSwapIndexConstituentsLeg =
        Namespaced_IRI.parse _namespace_name "DispersionSwapIndexConstituentsLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/DispersionSwapIndexLeg"></see>
    /// </summary>
    let DispersionSwapIndexLeg =
        Namespaced_IRI.parse _namespace_name "DispersionSwapIndexLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/DividendLeg"></see>
    /// </summary>
    let DividendLeg =
        Namespaced_IRI.parse _namespace_name "DividendLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/SpecialDividendLegTerms"></see>
    /// </summary>
    let SpecialDividendLegTerms =
        Namespaced_IRI.parse _namespace_name "SpecialDividendLegTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/QualifyingDividendPeriod"></see>
    /// </summary>
    let QualifyingDividendPeriod =
        Namespaced_IRI.parse _namespace_name "QualifyingDividendPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/DividendSwap"></see>
    /// </summary>
    let DividendSwap =
        Namespaced_IRI.parse _namespace_name "DividendSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquitySwap"></see>
    /// </summary>
    let EquitySwap = Namespaced_IRI.parse _namespace_name "EquitySwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityCorrelationSwap"></see>
    /// </summary>
    let EquityCorrelationSwap =
        Namespaced_IRI.parse _namespace_name "EquityCorrelationSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityPriceReturnSwap"></see>
    /// </summary>
    let EquityPriceReturnSwap =
        Namespaced_IRI.parse _namespace_name "EquityPriceReturnSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityReturnLeg"></see>
    /// </summary>
    let EquityReturnLeg =
        Namespaced_IRI.parse _namespace_name "EquityReturnLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityTotalReturnSwap"></see>
    /// </summary>
    let EquityTotalReturnSwap =
        Namespaced_IRI.parse _namespace_name "EquityTotalReturnSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityVarianceSwap"></see>
    /// </summary>
    let EquityVarianceSwap =
        Namespaced_IRI.parse _namespace_name "EquityVarianceSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityVolatilitySwap"></see>
    /// </summary>
    let EquityVolatilitySwap =
        Namespaced_IRI.parse _namespace_name "EquityVolatilitySwap" |> NamespacedName
