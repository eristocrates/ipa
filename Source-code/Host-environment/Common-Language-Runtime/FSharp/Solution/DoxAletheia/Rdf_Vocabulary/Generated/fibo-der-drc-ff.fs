namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.FuturesAndForwards.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_der_drc_ff =
    let _namespace_iri = Namespace_Iri fibo_der_drc_ff |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-der-drc-ff:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Futures and Forwards Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_der_drc_ff, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-ff:BasketFuture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"basket future"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/BasketFuture">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/BasketFuture</seealso>
    let BasketFuture = Prefixed_Name(fibo_der_drc_ff, "BasketFuture") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-ff:BondFuture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bond future"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/BondFuture">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/BondFuture</seealso>
    let BondFuture = Prefixed_Name(fibo_der_drc_ff, "BondFuture") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ff:CurrencyFuture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency future"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/CurrencyFuture">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/CurrencyFuture</seealso>
    let CurrencyFuture =
        Prefixed_Name(fibo_der_drc_ff, "CurrencyFuture") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ff:DebtInstrumentFuture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"debt instrument future"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/DebtInstrumentFuture">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/DebtInstrumentFuture</seealso>
    let DebtInstrumentFuture =
        Prefixed_Name(fibo_der_drc_ff, "DebtInstrumentFuture") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ff:DividendAdjustmentPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dividend adjustment period"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/DividendAdjustmentPeriod">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/DividendAdjustmentPeriod</seealso>
    let DividendAdjustmentPeriod =
        Prefixed_Name(fibo_der_drc_ff, "DividendAdjustmentPeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ff:DividendFuture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dividend future"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/DividendFuture">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/DividendFuture</seealso>
    let DividendFuture =
        Prefixed_Name(fibo_der_drc_ff, "DividendFuture") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ff:EquityForward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equity forward"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/EquityForward">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/EquityForward</seealso>
    let EquityForward = Prefixed_Name(fibo_der_drc_ff, "EquityForward") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-ff:EquityFuture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equity future"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/EquityFuture">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/EquityFuture</seealso>
    let EquityFuture = Prefixed_Name(fibo_der_drc_ff, "EquityFuture") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ff:FinancialFuture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial future"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/FinancialFuture">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/FinancialFuture</seealso>
    let FinancialFuture =
        Prefixed_Name(fibo_der_drc_ff, "FinancialFuture") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ff:Forward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"forward"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/Forward">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/Forward</seealso>
    let Forward = Prefixed_Name(fibo_der_drc_ff, "Forward") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ff:ForwardContractAdjustmentMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"forward contract adjustment method"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/ForwardContractAdjustmentMethod">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/ForwardContractAdjustmentMethod</seealso>
    let ForwardContractAdjustmentMethod =
        Prefixed_Name(fibo_der_drc_ff, "ForwardContractAdjustmentMethod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ff:FutureOnFuture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"future on future"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/FutureOnFuture">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/FutureOnFuture</seealso>
    let FutureOnFuture =
        Prefixed_Name(fibo_der_drc_ff, "FutureOnFuture") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ff:FutureOnOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"future on option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/FutureOnOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/FutureOnOption</seealso>
    let FutureOnOption =
        Prefixed_Name(fibo_der_drc_ff, "FutureOnOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ff:FutureOnSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"future on swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/FutureOnSwap">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/FutureOnSwap</seealso>
    let FutureOnSwap = Prefixed_Name(fibo_der_drc_ff, "FutureOnSwap") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-ff:IndexFuture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"index future"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/IndexFuture">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/IndexFuture</seealso>
    let IndexFuture = Prefixed_Name(fibo_der_drc_ff, "IndexFuture") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ff:InterestRateFuture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest rate future"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/InterestRateFuture">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/InterestRateFuture</seealso>
    let InterestRateFuture =
        Prefixed_Name(fibo_der_drc_ff, "InterestRateFuture") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ff:MoneyMarketFuture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"money market future"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/MoneyMarketFuture">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/MoneyMarketFuture</seealso>
    let MoneyMarketFuture =
        Prefixed_Name(fibo_der_drc_ff, "MoneyMarketFuture") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ff:StandardizedFuturesListingTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"standardized futures listing terms"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/StandardizedFuturesListingTerms">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/StandardizedFuturesListingTerms</seealso>
    let StandardizedFuturesListingTerms =
        Prefixed_Name(fibo_der_drc_ff, "StandardizedFuturesListingTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ff:StandardizedFuturesTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"standardized futures terms"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/StandardizedFuturesTerms">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/StandardizedFuturesTerms</seealso>
    let StandardizedFuturesTerms =
        Prefixed_Name(fibo_der_drc_ff, "StandardizedFuturesTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ff:hasConversionFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has conversion factor"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/hasConversionFactor">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/hasConversionFactor</seealso>
    let hasConversionFactor =
        Prefixed_Name(fibo_der_drc_ff, "hasConversionFactor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ff:hasDividendAdjustmentPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has dividend adjustment period"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/hasDividendAdjustmentPeriod">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/hasDividendAdjustmentPeriod</seealso>
    let hasDividendAdjustmentPeriod =
        Prefixed_Name(fibo_der_drc_ff, "hasDividendAdjustmentPeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ff:hasMethodOfAdjustment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has method of adjustment"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/hasMethodOfAdjustment">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/hasMethodOfAdjustment</seealso>
    let hasMethodOfAdjustment =
        Prefixed_Name(fibo_der_drc_ff, "hasMethodOfAdjustment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ff:hasMultiple</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has multiple"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/hasMultiple">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/hasMultiple</seealso>
    let hasMultiple = Prefixed_Name(fibo_der_drc_ff, "hasMultiple") |> PrefixedName
