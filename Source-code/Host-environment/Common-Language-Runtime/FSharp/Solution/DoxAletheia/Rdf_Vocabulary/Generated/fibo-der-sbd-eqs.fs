namespace https.spec.edmcouncil.org.fibo.ontology.DER.SecurityBasedDerivatives.EquitySwaps.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_der_sbd_eqs =
    let _namespace_iri = Namespace_Iri fibo_der_sbd_eqs |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-der-sbd-eqs:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Equity Swaps Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_der_sbd_eqs, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-eqs:DispersionSwapIndexConstituentsLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dispersion swap index constituents leg"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/DispersionSwapIndexConstituentsLeg">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/DispersionSwapIndexConstituentsLeg</seealso>
    let DispersionSwapIndexConstituentsLeg =
        Prefixed_Name(fibo_der_sbd_eqs, "DispersionSwapIndexConstituentsLeg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-eqs:DispersionSwapIndexLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dispersion swap index leg"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/DispersionSwapIndexLeg">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/DispersionSwapIndexLeg</seealso>
    let DispersionSwapIndexLeg =
        Prefixed_Name(fibo_der_sbd_eqs, "DispersionSwapIndexLeg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-eqs:DividendLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dividend leg"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/DividendLeg">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/DividendLeg</seealso>
    let DividendLeg = Prefixed_Name(fibo_der_sbd_eqs, "DividendLeg") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-sbd-eqs:DividendSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dividend swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/DividendSwap">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/DividendSwap</seealso>
    let DividendSwap = Prefixed_Name(fibo_der_sbd_eqs, "DividendSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-eqs:EquityCorrelationSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equity correlation swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityCorrelationSwap">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityCorrelationSwap</seealso>
    let EquityCorrelationSwap =
        Prefixed_Name(fibo_der_sbd_eqs, "EquityCorrelationSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-eqs:EquityPriceReturnSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equity price return swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityPriceReturnSwap">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityPriceReturnSwap</seealso>
    let EquityPriceReturnSwap =
        Prefixed_Name(fibo_der_sbd_eqs, "EquityPriceReturnSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-eqs:EquityReturnLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equity return leg"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityReturnLeg">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityReturnLeg</seealso>
    let EquityReturnLeg =
        Prefixed_Name(fibo_der_sbd_eqs, "EquityReturnLeg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-eqs:EquitySwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equity swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquitySwap">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquitySwap</seealso>
    let EquitySwap = Prefixed_Name(fibo_der_sbd_eqs, "EquitySwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-eqs:EquityTotalReturnSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equity total return swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityTotalReturnSwap">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityTotalReturnSwap</seealso>
    let EquityTotalReturnSwap =
        Prefixed_Name(fibo_der_sbd_eqs, "EquityTotalReturnSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-eqs:EquityVarianceSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equity variance swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityVarianceSwap">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityVarianceSwap</seealso>
    let EquityVarianceSwap =
        Prefixed_Name(fibo_der_sbd_eqs, "EquityVarianceSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-eqs:EquityVolatilitySwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equity volatility swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityVolatilitySwap">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityVolatilitySwap</seealso>
    let EquityVolatilitySwap =
        Prefixed_Name(fibo_der_sbd_eqs, "EquityVolatilitySwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-eqs:QualifyingDividendPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"qualifying dividend period"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/QualifyingDividendPeriod">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/QualifyingDividendPeriod</seealso>
    let QualifyingDividendPeriod =
        Prefixed_Name(fibo_der_sbd_eqs, "QualifyingDividendPeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-eqs:SpecialDividendLegTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"special dividend leg terms"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/SpecialDividendLegTerms">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/SpecialDividendLegTerms</seealso>
    let SpecialDividendLegTerms =
        Prefixed_Name(fibo_der_sbd_eqs, "SpecialDividendLegTerms") |> PrefixedName
