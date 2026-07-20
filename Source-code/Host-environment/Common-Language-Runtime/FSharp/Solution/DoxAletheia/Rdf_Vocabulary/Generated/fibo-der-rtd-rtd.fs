namespace https.spec.edmcouncil.org.fibo.ontology.DER.RateDerivatives.RateDerivatives.slash

open DoxAletheia

module fibo_der_rtd_rtd =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/EconomicRateBasedDerivativeInstrument"></see>
    /// </summary>
    let EconomicRateBasedDerivativeInstrument =
        _prefix "EconomicRateBasedDerivativeInstrument"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/EconomicRateObservable"></see>
    /// </summary>
    let EconomicRateObservable = _prefix "EconomicRateObservable"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/ForeignExchangeRateObservable"></see>
    /// </summary>
    let ForeignExchangeRateObservable = _prefix "ForeignExchangeRateObservable"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/ForwardRateAgreement"></see>
    /// </summary>
    let ForwardRateAgreement = _prefix "ForwardRateAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/InterestRateDerivativeInstrument"></see>
    /// </summary>
    let InterestRateDerivativeInstrument = _prefix "InterestRateDerivativeInstrument"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/InterestRateObservable"></see>
    /// </summary>
    let InterestRateObservable = _prefix "InterestRateObservable"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/RateBasedDerivativeInstrument"></see>
    /// </summary>
    let RateBasedDerivativeInstrument = _prefix "RateBasedDerivativeInstrument"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/RateBasedObservable"></see>
    /// </summary>
    let RateBasedObservable = _prefix "RateBasedObservable"
