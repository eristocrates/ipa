namespace https.spec.edmcouncil.org.fibo.ontology.DER.RateDerivatives.IRSwaps.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_der_rtd_irswp =
    let _namespace_iri = Namespace_Iri fibo_der_rtd_irswp |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-der-rtd-irswp:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Interest Rate Swaps Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_der_rtd_irswp, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:CrossCurrencyInterestRateSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cross-currency interest rate swap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/CrossCurrencyInterestRateSwap">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/CrossCurrencyInterestRateSwap</seealso>
    let CrossCurrencyInterestRateSwap =
        Prefixed_Name(fibo_der_rtd_irswp, "CrossCurrencyInterestRateSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:FixedFixedInterestRateSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fixed fixed interest rate swap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedFixedInterestRateSwap">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedFixedInterestRateSwap</seealso>
    let FixedFixedInterestRateSwap =
        Prefixed_Name(fibo_der_rtd_irswp, "FixedFixedInterestRateSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:FixedFloatCrossCurrencyInterestRateSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fixed float cross-currency interest rate swap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedFloatCrossCurrencyInterestRateSwap">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedFloatCrossCurrencyInterestRateSwap</seealso>
    let FixedFloatCrossCurrencyInterestRateSwap =
        Prefixed_Name(fibo_der_rtd_irswp, "FixedFloatCrossCurrencyInterestRateSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:FixedFloatInterestRateSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fixed float interest rate swap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedFloatInterestRateSwap">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedFloatInterestRateSwap</seealso>
    let FixedFloatInterestRateSwap =
        Prefixed_Name(fibo_der_rtd_irswp, "FixedFloatInterestRateSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:FixedFloatSingleCurrencyInterestRateSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fixed float single currency interest rate swap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedFloatSingleCurrencyInterestRateSwap">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedFloatSingleCurrencyInterestRateSwap</seealso>
    let FixedFloatSingleCurrencyInterestRateSwap =
        Prefixed_Name(fibo_der_rtd_irswp, "FixedFloatSingleCurrencyInterestRateSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:FixedInterestRateLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fixed interest rate leg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedInterestRateLeg">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedInterestRateLeg</seealso>
    let FixedInterestRateLeg =
        Prefixed_Name(fibo_der_rtd_irswp, "FixedInterestRateLeg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:FloatFloatCrossCurrencyInterestRateSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"float float cross-currency interest rate swap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FloatFloatCrossCurrencyInterestRateSwap">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FloatFloatCrossCurrencyInterestRateSwap</seealso>
    let FloatFloatCrossCurrencyInterestRateSwap =
        Prefixed_Name(fibo_der_rtd_irswp, "FloatFloatCrossCurrencyInterestRateSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:FloatFloatInterestRateSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"float float interest rate swap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FloatFloatInterestRateSwap">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FloatFloatInterestRateSwap</seealso>
    let FloatFloatInterestRateSwap =
        Prefixed_Name(fibo_der_rtd_irswp, "FloatFloatInterestRateSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:FloatFloatSingleCurrencyInterestRateSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"float float single currency interest rate swap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FloatFloatSingleCurrencyInterestRateSwap">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FloatFloatSingleCurrencyInterestRateSwap</seealso>
    let FloatFloatSingleCurrencyInterestRateSwap =
        Prefixed_Name(fibo_der_rtd_irswp, "FloatFloatSingleCurrencyInterestRateSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:FloatingInterestRateLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"floating interest rate leg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FloatingInterestRateLeg">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FloatingInterestRateLeg</seealso>
    let FloatingInterestRateLeg =
        Prefixed_Name(fibo_der_rtd_irswp, "FloatingInterestRateLeg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:InflationLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"inflation leg"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/InflationLeg">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/InflationLeg</seealso>
    let InflationLeg = Prefixed_Name(fibo_der_rtd_irswp, "InflationLeg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:InflationSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"inflation swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/InflationSwap">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/InflationSwap</seealso>
    let InflationSwap =
        Prefixed_Name(fibo_der_rtd_irswp, "InflationSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:InterestRateSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest rate swap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/InterestRateSwap">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/InterestRateSwap</seealso>
    let InterestRateSwap =
        Prefixed_Name(fibo_der_rtd_irswp, "InterestRateSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:InterestRateSwapLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest rate swap leg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/InterestRateSwapLeg">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/InterestRateSwapLeg</seealso>
    let InterestRateSwapLeg =
        Prefixed_Name(fibo_der_rtd_irswp, "InterestRateSwapLeg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:NotionalStepAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"notional step amount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/NotionalStepAmount">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/NotionalStepAmount</seealso>
    let NotionalStepAmount =
        Prefixed_Name(fibo_der_rtd_irswp, "NotionalStepAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:NotionalStepChangeEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"notional step change event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/NotionalStepChangeEvent">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/NotionalStepChangeEvent</seealso>
    let NotionalStepChangeEvent =
        Prefixed_Name(fibo_der_rtd_irswp, "NotionalStepChangeEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:NotionalStepPeriodLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"notional step period length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/NotionalStepPeriodLength">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/NotionalStepPeriodLength</seealso>
    let NotionalStepPeriodLength =
        Prefixed_Name(fibo_der_rtd_irswp, "NotionalStepPeriodLength") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:NotionalStepSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"notional step schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/NotionalStepSchedule">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/NotionalStepSchedule</seealso>
    let NotionalStepSchedule =
        Prefixed_Name(fibo_der_rtd_irswp, "NotionalStepSchedule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:OvernightIndexSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"overnight index swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/OvernightIndexSwap">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/OvernightIndexSwap</seealso>
    let OvernightIndexSwap =
        Prefixed_Name(fibo_der_rtd_irswp, "OvernightIndexSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:OvernightRateIndexLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"overnight rate index leg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/OvernightRateIndexLeg">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/OvernightRateIndexLeg</seealso>
    let OvernightRateIndexLeg =
        Prefixed_Name(fibo_der_rtd_irswp, "OvernightRateIndexLeg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:PlainVanillaInterestRateSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"plain vanilla interest rate swap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/PlainVanillaInterestRateSwap">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/PlainVanillaInterestRateSwap</seealso>
    let PlainVanillaInterestRateSwap =
        Prefixed_Name(fibo_der_rtd_irswp, "PlainVanillaInterestRateSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:SingleCurrencyInterestRateSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"single currency interest rate swap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/SingleCurrencyInterestRateSwap">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/SingleCurrencyInterestRateSwap</seealso>
    let SingleCurrencyInterestRateSwap =
        Prefixed_Name(fibo_der_rtd_irswp, "SingleCurrencyInterestRateSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:ZeroCouponInterestRateSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"zero coupon interest rate swap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/ZeroCouponInterestRateSwap">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/ZeroCouponInterestRateSwap</seealso>
    let ZeroCouponInterestRateSwap =
        Prefixed_Name(fibo_der_rtd_irswp, "ZeroCouponInterestRateSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:hasFirstNotionalStepDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has first notional step date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasFirstNotionalStepDate">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasFirstNotionalStepDate</seealso>
    let hasFirstNotionalStepDate =
        Prefixed_Name(fibo_der_rtd_irswp, "hasFirstNotionalStepDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:hasFloatingRateCap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has floating rate cap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasFloatingRateCap">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasFloatingRateCap</seealso>
    let hasFloatingRateCap =
        Prefixed_Name(fibo_der_rtd_irswp, "hasFloatingRateCap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:hasFloatingRateFloor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has floating rate floor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasFloatingRateFloor">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasFloatingRateFloor</seealso>
    let hasFloatingRateFloor =
        Prefixed_Name(fibo_der_rtd_irswp, "hasFloatingRateFloor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:hasFloatingRateSpread</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has floating rate spread"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasFloatingRateSpread">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasFloatingRateSpread</seealso>
    let hasFloatingRateSpread =
        Prefixed_Name(fibo_der_rtd_irswp, "hasFloatingRateSpread") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:hasLastNotionalStepDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has last notional step date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasLastNotionalStepDate">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasLastNotionalStepDate</seealso>
    let hasLastNotionalStepDate =
        Prefixed_Name(fibo_der_rtd_irswp, "hasLastNotionalStepDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rtd-irswp:hasRateMultiplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has rate multiplier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasRateMultiplier">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasRateMultiplier</seealso>
    let hasRateMultiplier =
        Prefixed_Name(fibo_der_rtd_irswp, "hasRateMultiplier") |> PrefixedName
