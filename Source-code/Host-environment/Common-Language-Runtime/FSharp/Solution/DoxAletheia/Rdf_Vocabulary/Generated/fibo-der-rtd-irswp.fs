namespace https.spec.edmcouncil.org.fibo.ontology.DER.RateDerivatives.IRSwaps.slash

open DoxAletheia

module fibo_der_rtd_irswp =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/CrossCurrencyInterestRateSwap"></see>
    /// </summary>
    let CrossCurrencyInterestRateSwap = _prefix "CrossCurrencyInterestRateSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/InterestRateSwap"></see>
    /// </summary>
    let InterestRateSwap = _prefix "InterestRateSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedFixedInterestRateSwap"></see>
    /// </summary>
    let FixedFixedInterestRateSwap = _prefix "FixedFixedInterestRateSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedInterestRateLeg"></see>
    /// </summary>
    let FixedInterestRateLeg = _prefix "FixedInterestRateLeg"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedFloatCrossCurrencyInterestRateSwap"></see>
    /// </summary>
    let FixedFloatCrossCurrencyInterestRateSwap =
        _prefix "FixedFloatCrossCurrencyInterestRateSwap"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedFloatInterestRateSwap"></see>
    /// </summary>
    let FixedFloatInterestRateSwap = _prefix "FixedFloatInterestRateSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FloatingInterestRateLeg"></see>
    /// </summary>
    let FloatingInterestRateLeg = _prefix "FloatingInterestRateLeg"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedFloatSingleCurrencyInterestRateSwap"></see>
    /// </summary>
    let FixedFloatSingleCurrencyInterestRateSwap =
        _prefix "FixedFloatSingleCurrencyInterestRateSwap"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/SingleCurrencyInterestRateSwap"></see>
    /// </summary>
    let SingleCurrencyInterestRateSwap = _prefix "SingleCurrencyInterestRateSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/InterestRateSwapLeg"></see>
    /// </summary>
    let InterestRateSwapLeg = _prefix "InterestRateSwapLeg"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FloatFloatCrossCurrencyInterestRateSwap"></see>
    /// </summary>
    let FloatFloatCrossCurrencyInterestRateSwap =
        _prefix "FloatFloatCrossCurrencyInterestRateSwap"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FloatFloatInterestRateSwap"></see>
    /// </summary>
    let FloatFloatInterestRateSwap = _prefix "FloatFloatInterestRateSwap"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FloatFloatSingleCurrencyInterestRateSwap"></see>
    /// </summary>
    let FloatFloatSingleCurrencyInterestRateSwap =
        _prefix "FloatFloatSingleCurrencyInterestRateSwap"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/InflationLeg"></see>
    /// </summary>
    let InflationLeg = _prefix "InflationLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/InflationSwap"></see>
    /// </summary>
    let InflationSwap = _prefix "InflationSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/NotionalStepSchedule"></see>
    /// </summary>
    let NotionalStepSchedule = _prefix "NotionalStepSchedule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/NotionalStepAmount"></see>
    /// </summary>
    let NotionalStepAmount = _prefix "NotionalStepAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/NotionalStepChangeEvent"></see>
    /// </summary>
    let NotionalStepChangeEvent = _prefix "NotionalStepChangeEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/NotionalStepPeriodLength"></see>
    /// </summary>
    let NotionalStepPeriodLength = _prefix "NotionalStepPeriodLength"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/OvernightIndexSwap"></see>
    /// </summary>
    let OvernightIndexSwap = _prefix "OvernightIndexSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/OvernightRateIndexLeg"></see>
    /// </summary>
    let OvernightRateIndexLeg = _prefix "OvernightRateIndexLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/PlainVanillaInterestRateSwap"></see>
    /// </summary>
    let PlainVanillaInterestRateSwap = _prefix "PlainVanillaInterestRateSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/ZeroCouponInterestRateSwap"></see>
    /// </summary>
    let ZeroCouponInterestRateSwap = _prefix "ZeroCouponInterestRateSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasFirstNotionalStepDate"></see>
    /// </summary>
    let hasFirstNotionalStepDate = _prefix "hasFirstNotionalStepDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasFloatingRateCap"></see>
    /// </summary>
    let hasFloatingRateCap = _prefix "hasFloatingRateCap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasFloatingRateFloor"></see>
    /// </summary>
    let hasFloatingRateFloor = _prefix "hasFloatingRateFloor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasFloatingRateSpread"></see>
    /// </summary>
    let hasFloatingRateSpread = _prefix "hasFloatingRateSpread"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasLastNotionalStepDate"></see>
    /// </summary>
    let hasLastNotionalStepDate = _prefix "hasLastNotionalStepDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasRateMultiplier"></see>
    /// </summary>
    let hasRateMultiplier = _prefix "hasRateMultiplier"
