namespace https.spec.edmcouncil.org.fibo.ontology.DER.RateDerivatives.RateDerivatives.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_der_rtd_rtd =
    let _namespace_iri = Namespace_Iri fibo_der_rtd_rtd |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-der-rtd-rtd:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Rate Derivatives Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_der_rtd_rtd, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-rtd:EconomicRateBasedDerivativeInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/EconomicRateBasedDerivativeInstrument">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/EconomicRateBasedDerivativeInstrument</seealso>
    let EconomicRateBasedDerivativeInstrument =
        Prefixed_Name(fibo_der_rtd_rtd, "EconomicRateBasedDerivativeInstrument") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-rtd:EconomicRateObservable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/EconomicRateObservable">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/EconomicRateObservable</seealso>
    let EconomicRateObservable =
        Prefixed_Name(fibo_der_rtd_rtd, "EconomicRateObservable") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-rtd:ForeignExchangeRateObservable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/ForeignExchangeRateObservable">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/ForeignExchangeRateObservable</seealso>
    let ForeignExchangeRateObservable =
        Prefixed_Name(fibo_der_rtd_rtd, "ForeignExchangeRateObservable") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-rtd:ForwardRateAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/ForwardRateAgreement">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/ForwardRateAgreement</seealso>
    let ForwardRateAgreement =
        Prefixed_Name(fibo_der_rtd_rtd, "ForwardRateAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-rtd:InterestRateDerivativeInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/InterestRateDerivativeInstrument">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/InterestRateDerivativeInstrument</seealso>
    let InterestRateDerivativeInstrument =
        Prefixed_Name(fibo_der_rtd_rtd, "InterestRateDerivativeInstrument") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-rtd:InterestRateObservable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/InterestRateObservable">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/InterestRateObservable</seealso>
    let InterestRateObservable =
        Prefixed_Name(fibo_der_rtd_rtd, "InterestRateObservable") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-rtd:RateBasedDerivativeInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/RateBasedDerivativeInstrument">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/RateBasedDerivativeInstrument</seealso>
    let RateBasedDerivativeInstrument =
        Prefixed_Name(fibo_der_rtd_rtd, "RateBasedDerivativeInstrument") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-rtd:RateBasedObservable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/RateBasedObservable">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/RateBasedObservable</seealso>
    let RateBasedObservable =
        Prefixed_Name(fibo_der_rtd_rtd, "RateBasedObservable") |> PrefixedName
