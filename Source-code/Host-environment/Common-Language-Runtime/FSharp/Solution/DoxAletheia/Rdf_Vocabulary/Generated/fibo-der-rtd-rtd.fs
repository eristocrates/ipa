namespace https.spec.edmcouncil.org.fibo.ontology.DER.RateDerivatives.RateDerivatives.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_der_rtd_rtd =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/EconomicRateBasedDerivativeInstrument"></see>
    /// </summary>
    let EconomicRateBasedDerivativeInstrument =
        Namespaced_IRI.parse _namespace_name "EconomicRateBasedDerivativeInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/EconomicRateObservable"></see>
    /// </summary>
    let EconomicRateObservable =
        Namespaced_IRI.parse _namespace_name "EconomicRateObservable" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/ForeignExchangeRateObservable"></see>
    /// </summary>
    let ForeignExchangeRateObservable =
        Namespaced_IRI.parse _namespace_name "ForeignExchangeRateObservable" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/ForwardRateAgreement"></see>
    /// </summary>
    let ForwardRateAgreement =
        Namespaced_IRI.parse _namespace_name "ForwardRateAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/InterestRateDerivativeInstrument"></see>
    /// </summary>
    let InterestRateDerivativeInstrument =
        Namespaced_IRI.parse _namespace_name "InterestRateDerivativeInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/InterestRateObservable"></see>
    /// </summary>
    let InterestRateObservable =
        Namespaced_IRI.parse _namespace_name "InterestRateObservable" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/RateBasedDerivativeInstrument"></see>
    /// </summary>
    let RateBasedDerivativeInstrument =
        Namespaced_IRI.parse _namespace_name "RateBasedDerivativeInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/RateBasedObservable"></see>
    /// </summary>
    let RateBasedObservable =
        Namespaced_IRI.parse _namespace_name "RateBasedObservable" |> NamespacedName
