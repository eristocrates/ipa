namespace Fibo.DER.RateDerivatives.IRSwaps.Namespace
module IRSwaps =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/DER/RateDerivatives/IRSwaps.rdf") (Some @"fibo.DER.RateDerivatives.IRSwaps") None
    let CrossCurrencyInterestRateSwap = {_prefixID with _localName = "CrossCurrencyInterestRateSwap"}
    let FixedFixedInterestRateSwap = {_prefixID with _localName = "FixedFixedInterestRateSwap"}
    let FixedFloatCrossCurrencyInterestRateSwap = {_prefixID with _localName = "FixedFloatCrossCurrencyInterestRateSwap"}
    let FixedFloatInterestRateSwap = {_prefixID with _localName = "FixedFloatInterestRateSwap"}
    let FixedFloatSingleCurrencyInterestRateSwap = {_prefixID with _localName = "FixedFloatSingleCurrencyInterestRateSwap"}
    let FixedInterestRateLeg = {_prefixID with _localName = "FixedInterestRateLeg"}
    let FloatFloatCrossCurrencyInterestRateSwap = {_prefixID with _localName = "FloatFloatCrossCurrencyInterestRateSwap"}
    let FloatFloatInterestRateSwap = {_prefixID with _localName = "FloatFloatInterestRateSwap"}
    let FloatFloatSingleCurrencyInterestRateSwap = {_prefixID with _localName = "FloatFloatSingleCurrencyInterestRateSwap"}
    let FloatingInterestRateLeg = {_prefixID with _localName = "FloatingInterestRateLeg"}
    let InflationLeg = {_prefixID with _localName = "InflationLeg"}
    let InflationSwap = {_prefixID with _localName = "InflationSwap"}
    let InterestRateSwap = {_prefixID with _localName = "InterestRateSwap"}
    let InterestRateSwapLeg = {_prefixID with _localName = "InterestRateSwapLeg"}
    let NotionalStepAmount = {_prefixID with _localName = "NotionalStepAmount"}
    let NotionalStepChangeEvent = {_prefixID with _localName = "NotionalStepChangeEvent"}
    let NotionalStepPeriodLength = {_prefixID with _localName = "NotionalStepPeriodLength"}
    let NotionalStepSchedule = {_prefixID with _localName = "NotionalStepSchedule"}
    let OvernightIndexSwap = {_prefixID with _localName = "OvernightIndexSwap"}
    let OvernightRateIndexLeg = {_prefixID with _localName = "OvernightRateIndexLeg"}
    let PlainVanillaInterestRateSwap = {_prefixID with _localName = "PlainVanillaInterestRateSwap"}
    let SingleCurrencyInterestRateSwap = {_prefixID with _localName = "SingleCurrencyInterestRateSwap"}
    let ZeroCouponInterestRateSwap = {_prefixID with _localName = "ZeroCouponInterestRateSwap"}
    let hasFirstNotionalStepDate = {_prefixID with _localName = "hasFirstNotionalStepDate"}
    let hasFloatingRateCap = {_prefixID with _localName = "hasFloatingRateCap"}
    let hasFloatingRateFloor = {_prefixID with _localName = "hasFloatingRateFloor"}
    let hasFloatingRateSpread = {_prefixID with _localName = "hasFloatingRateSpread"}
    let hasLastNotionalStepDate = {_prefixID with _localName = "hasLastNotionalStepDate"}
    let hasRateMultiplier = {_prefixID with _localName = "hasRateMultiplier"}