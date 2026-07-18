namespace https.spec.edmcouncil.org.fibo.ontology.DER.RateDerivatives.IRSwaps.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_der_rtd_irswp =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/CrossCurrencyInterestRateSwap"></see>
    /// </summary>
    let CrossCurrencyInterestRateSwap =
        Namespaced_IRI.parse _namespace_name "CrossCurrencyInterestRateSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/InterestRateSwap"></see>
    /// </summary>
    let InterestRateSwap =
        Namespaced_IRI.parse _namespace_name "InterestRateSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedFixedInterestRateSwap"></see>
    /// </summary>
    let FixedFixedInterestRateSwap =
        Namespaced_IRI.parse _namespace_name "FixedFixedInterestRateSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedInterestRateLeg"></see>
    /// </summary>
    let FixedInterestRateLeg =
        Namespaced_IRI.parse _namespace_name "FixedInterestRateLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedFloatCrossCurrencyInterestRateSwap"></see>
    /// </summary>
    let FixedFloatCrossCurrencyInterestRateSwap =
        Namespaced_IRI.parse _namespace_name "FixedFloatCrossCurrencyInterestRateSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedFloatInterestRateSwap"></see>
    /// </summary>
    let FixedFloatInterestRateSwap =
        Namespaced_IRI.parse _namespace_name "FixedFloatInterestRateSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FloatingInterestRateLeg"></see>
    /// </summary>
    let FloatingInterestRateLeg =
        Namespaced_IRI.parse _namespace_name "FloatingInterestRateLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedFloatSingleCurrencyInterestRateSwap"></see>
    /// </summary>
    let FixedFloatSingleCurrencyInterestRateSwap =
        Namespaced_IRI.parse _namespace_name "FixedFloatSingleCurrencyInterestRateSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/SingleCurrencyInterestRateSwap"></see>
    /// </summary>
    let SingleCurrencyInterestRateSwap =
        Namespaced_IRI.parse _namespace_name "SingleCurrencyInterestRateSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/InterestRateSwapLeg"></see>
    /// </summary>
    let InterestRateSwapLeg =
        Namespaced_IRI.parse _namespace_name "InterestRateSwapLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FloatFloatCrossCurrencyInterestRateSwap"></see>
    /// </summary>
    let FloatFloatCrossCurrencyInterestRateSwap =
        Namespaced_IRI.parse _namespace_name "FloatFloatCrossCurrencyInterestRateSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FloatFloatInterestRateSwap"></see>
    /// </summary>
    let FloatFloatInterestRateSwap =
        Namespaced_IRI.parse _namespace_name "FloatFloatInterestRateSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FloatFloatSingleCurrencyInterestRateSwap"></see>
    /// </summary>
    let FloatFloatSingleCurrencyInterestRateSwap =
        Namespaced_IRI.parse _namespace_name "FloatFloatSingleCurrencyInterestRateSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/InflationLeg"></see>
    /// </summary>
    let InflationLeg =
        Namespaced_IRI.parse _namespace_name "InflationLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/InflationSwap"></see>
    /// </summary>
    let InflationSwap =
        Namespaced_IRI.parse _namespace_name "InflationSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/NotionalStepSchedule"></see>
    /// </summary>
    let NotionalStepSchedule =
        Namespaced_IRI.parse _namespace_name "NotionalStepSchedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/NotionalStepAmount"></see>
    /// </summary>
    let NotionalStepAmount =
        Namespaced_IRI.parse _namespace_name "NotionalStepAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/NotionalStepChangeEvent"></see>
    /// </summary>
    let NotionalStepChangeEvent =
        Namespaced_IRI.parse _namespace_name "NotionalStepChangeEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/NotionalStepPeriodLength"></see>
    /// </summary>
    let NotionalStepPeriodLength =
        Namespaced_IRI.parse _namespace_name "NotionalStepPeriodLength" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/OvernightIndexSwap"></see>
    /// </summary>
    let OvernightIndexSwap =
        Namespaced_IRI.parse _namespace_name "OvernightIndexSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/OvernightRateIndexLeg"></see>
    /// </summary>
    let OvernightRateIndexLeg =
        Namespaced_IRI.parse _namespace_name "OvernightRateIndexLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/PlainVanillaInterestRateSwap"></see>
    /// </summary>
    let PlainVanillaInterestRateSwap =
        Namespaced_IRI.parse _namespace_name "PlainVanillaInterestRateSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/ZeroCouponInterestRateSwap"></see>
    /// </summary>
    let ZeroCouponInterestRateSwap =
        Namespaced_IRI.parse _namespace_name "ZeroCouponInterestRateSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasFirstNotionalStepDate"></see>
    /// </summary>
    let hasFirstNotionalStepDate =
        Namespaced_IRI.parse _namespace_name "hasFirstNotionalStepDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasFloatingRateCap"></see>
    /// </summary>
    let hasFloatingRateCap =
        Namespaced_IRI.parse _namespace_name "hasFloatingRateCap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasFloatingRateFloor"></see>
    /// </summary>
    let hasFloatingRateFloor =
        Namespaced_IRI.parse _namespace_name "hasFloatingRateFloor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasFloatingRateSpread"></see>
    /// </summary>
    let hasFloatingRateSpread =
        Namespaced_IRI.parse _namespace_name "hasFloatingRateSpread" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasLastNotionalStepDate"></see>
    /// </summary>
    let hasLastNotionalStepDate =
        Namespaced_IRI.parse _namespace_name "hasLastNotionalStepDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasRateMultiplier"></see>
    /// </summary>
    let hasRateMultiplier =
        Namespaced_IRI.parse _namespace_name "hasRateMultiplier" |> NamespacedName
