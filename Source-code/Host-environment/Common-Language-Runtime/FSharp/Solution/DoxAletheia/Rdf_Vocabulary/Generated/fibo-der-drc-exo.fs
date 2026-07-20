namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.ExoticOptions.slash

open DoxAletheia

module fibo_der_drc_exo =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/ArithmeticCalculationStrategy"></see>
    /// </summary>
    let ArithmeticCalculationStrategy = _prefix "ArithmeticCalculationStrategy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/AveragingStrategy"></see>
    /// </summary>
    let AveragingStrategy = _prefix "AveragingStrategy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/AsianOption"></see>
    /// </summary>
    let AsianOption = _prefix "AsianOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/AsianOptionClassifier"></see>
    /// </summary>
    let AsianOptionClassifier = _prefix "AsianOptionClassifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/usesCurrencyInAveraging"></see>
    /// </summary>
    let usesCurrencyInAveraging = _prefix "usesCurrencyInAveraging"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasAsianTailPeriod"></see>
    /// </summary>
    let hasAsianTailPeriod = _prefix "hasAsianTailPeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/usesWeightedAverage"></see>
    /// </summary>
    let usesWeightedAverage = _prefix "usesWeightedAverage"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/AverageRate"></see>
    /// </summary>
    let AverageRate = _prefix "AverageRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/AverageStrike"></see>
    /// </summary>
    let AverageStrike = _prefix "AverageStrike"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/BarrierOption"></see>
    /// </summary>
    let BarrierOption = _prefix "BarrierOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasMonitoringFrequency"></see>
    /// </summary>
    let hasMonitoringFrequency = _prefix "hasMonitoringFrequency"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasMonitoringPeriod"></see>
    /// </summary>
    let hasMonitoringPeriod = _prefix "hasMonitoringPeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/isAboveStrikePrice"></see>
    /// </summary>
    let isAboveStrikePrice = _prefix "isAboveStrikePrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/ChooserOption"></see>
    /// </summary>
    let ChooserOption = _prefix "ChooserOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasOptionTypeElectionDate"></see>
    /// </summary>
    let hasOptionTypeElectionDate = _prefix "hasOptionTypeElectionDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/CliquetOption"></see>
    /// </summary>
    let CliquetOption = _prefix "CliquetOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/ForwardStartOption"></see>
    /// </summary>
    let ForwardStartOption = _prefix "ForwardStartOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/CommodoreOption"></see>
    /// </summary>
    let CommodoreOption = _prefix "CommodoreOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/DigitalOption"></see>
    /// </summary>
    let DigitalOption = _prefix "DigitalOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/CompoundOption"></see>
    /// </summary>
    let CompoundOption = _prefix "CompoundOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/DoubleBarrierOption"></see>
    /// </summary>
    let DoubleBarrierOption = _prefix "DoubleBarrierOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasFirstRebateAmount"></see>
    /// </summary>
    let hasFirstRebateAmount = _prefix "hasFirstRebateAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasSecondRebateAmount"></see>
    /// </summary>
    let hasSecondRebateAmount = _prefix "hasSecondRebateAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasFirstBarrierPrice"></see>
    /// </summary>
    let hasFirstBarrierPrice = _prefix "hasFirstBarrierPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasSecondBarrierPrice"></see>
    /// </summary>
    let hasSecondBarrierPrice = _prefix "hasSecondBarrierPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/FixedLookbackStrikeExpression"></see>
    /// </summary>
    let FixedLookbackStrikeExpression = _prefix "FixedLookbackStrikeExpression"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/ObservedBestValue"></see>
    /// </summary>
    let ObservedBestValue = _prefix "ObservedBestValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/FloatingLookbackStrikeExpression"></see>
    /// </summary>
    let FloatingLookbackStrikeExpression = _prefix "FloatingLookbackStrikeExpression"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/ProjectedValueAtMaturity"></see>
    /// </summary>
    let ProjectedValueAtMaturity = _prefix "ProjectedValueAtMaturity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/GeometricCalculationStrategy"></see>
    /// </summary>
    let GeometricCalculationStrategy = _prefix "GeometricCalculationStrategy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/InterestRateCapOption"></see>
    /// </summary>
    let InterestRateCapOption = _prefix "InterestRateCapOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/InterestRateFloorOption"></see>
    /// </summary>
    let InterestRateFloorOption = _prefix "InterestRateFloorOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/KnockInOption"></see>
    /// </summary>
    let KnockInOption = _prefix "KnockInOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/KnockOutOption"></see>
    /// </summary>
    let KnockOutOption = _prefix "KnockOutOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/LookbackOption"></see>
    /// </summary>
    let LookbackOption = _prefix "LookbackOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/LookbackStrikeTerms"></see>
    /// </summary>
    let LookbackStrikeTerms = _prefix "LookbackStrikeTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasLookbackPeriod"></see>
    /// </summary>
    let hasLookbackPeriod = _prefix "hasLookbackPeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/LowExercisePriceOption"></see>
    /// </summary>
    let LowExercisePriceOption = _prefix "LowExercisePriceOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/MountainRangeOption"></see>
    /// </summary>
    let MountainRangeOption = _prefix "MountainRangeOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/RainbowOption"></see>
    /// </summary>
    let RainbowOption = _prefix "RainbowOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/Swaption"></see>
    /// </summary>
    let Swaption = _prefix "Swaption"
