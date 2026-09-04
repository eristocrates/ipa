#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-der-rtd-rtd`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/" "fibo-der-rtd-rtd"

    let _namespaceIri = _prefixId.prefix ""

    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/EconomicRateBasedDerivativeInstrument">fibo-der-rtd-rtd:EconomicRateBasedDerivativeInstrument</a>
    /// </summary>
    let EconomicRateBasedDerivativeInstrument =
        _prefixId.prefix "EconomicRateBasedDerivativeInstrument"

    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/EconomicRateObservable">fibo-der-rtd-rtd:EconomicRateObservable</a>
    /// </summary>
    let EconomicRateObservable = _prefixId.prefix "EconomicRateObservable"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/ForeignExchangeRateObservable">fibo-der-rtd-rtd:ForeignExchangeRateObservable</a>
    /// </summary>
    let ForeignExchangeRateObservable = _prefixId.prefix "ForeignExchangeRateObservable"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/ForwardRateAgreement">fibo-der-rtd-rtd:ForwardRateAgreement</a>
    /// </summary>
    let ForwardRateAgreement = _prefixId.prefix "ForwardRateAgreement"

    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/InterestRateDerivativeInstrument">fibo-der-rtd-rtd:InterestRateDerivativeInstrument</a>
    /// </summary>
    let InterestRateDerivativeInstrument =
        _prefixId.prefix "InterestRateDerivativeInstrument"

    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/InterestRateObservable">fibo-der-rtd-rtd:InterestRateObservable</a>
    /// </summary>
    let InterestRateObservable = _prefixId.prefix "InterestRateObservable"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/RateBasedDerivativeInstrument">fibo-der-rtd-rtd:RateBasedDerivativeInstrument</a>
    /// </summary>
    let RateBasedDerivativeInstrument = _prefixId.prefix "RateBasedDerivativeInstrument"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/RateBasedObservable">fibo-der-rtd-rtd:RateBasedObservable</a>
    /// </summary>
    let RateBasedObservable = _prefixId.prefix "RateBasedObservable"
