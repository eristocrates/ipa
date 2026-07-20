namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.Options.slash

open DoxAletheia

module fibo_der_drc_opt =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/AtTheMoney"></see>
    /// </summary>
    let AtTheMoney = _prefix "AtTheMoney"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Moneyness"></see>
    /// </summary>
    let Moneyness = _prefix "Moneyness"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/BasketOption"></see>
    /// </summary>
    let BasketOption = _prefix "BasketOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/ExoticOption"></see>
    /// </summary>
    let ExoticOption = _prefix "ExoticOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/BondOption"></see>
    /// </summary>
    let BondOption = _prefix "BondOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/FixedIncomeOption"></see>
    /// </summary>
    let FixedIncomeOption = _prefix "FixedIncomeOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Butterfly"></see>
    /// </summary>
    let Butterfly = _prefix "Butterfly"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionTradingStrategy"></see>
    /// </summary>
    let OptionTradingStrategy = _prefix "OptionTradingStrategy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasExercisePrice"></see>
    /// </summary>
    let hasExercisePrice = _prefix "hasExercisePrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/StrikePrice"></see>
    /// </summary>
    let StrikePrice = _prefix "StrikePrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/CallOption"></see>
    /// </summary>
    let CallOption = _prefix "CallOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/CappedOption"></see>
    /// </summary>
    let CappedOption = _prefix "CappedOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/VanillaOption"></see>
    /// </summary>
    let VanillaOption = _prefix "VanillaOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasCapPrice"></see>
    /// </summary>
    let hasCapPrice = _prefix "hasCapPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Collar"></see>
    /// </summary>
    let Collar = _prefix "Collar"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/PutOption"></see>
    /// </summary>
    let PutOption = _prefix "PutOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/CondorSpread"></see>
    /// </summary>
    let CondorSpread = _prefix "CondorSpread"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/CoveredCall"></see>
    /// </summary>
    let CoveredCall = _prefix "CoveredCall"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/EquityOption"></see>
    /// </summary>
    let EquityOption = _prefix "EquityOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasExerciseStyle"></see>
    /// </summary>
    let hasExerciseStyle = _prefix "hasExerciseStyle"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/ExtrinsicValue"></see>
    /// </summary>
    let ExtrinsicValue = _prefix "ExtrinsicValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/IntrinsicValue"></see>
    /// </summary>
    let IntrinsicValue = _prefix "IntrinsicValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Fence"></see>
    /// </summary>
    let Fence = _prefix "Fence"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/InTheMoney"></see>
    /// </summary>
    let InTheMoney = _prefix "InTheMoney"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/InterestRateOption"></see>
    /// </summary>
    let InterestRateOption = _prefix "InterestRateOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasStrikeRate"></see>
    /// </summary>
    let hasStrikeRate = _prefix "hasStrikeRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/IronButterfly"></see>
    /// </summary>
    let IronButterfly = _prefix "IronButterfly"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/IronCondor"></see>
    /// </summary>
    let IronCondor = _prefix "IronCondor"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/LongTermEquityAnticipationSecurity"></see>
    /// </summary>
    let LongTermEquityAnticipationSecurity =
        _prefix "LongTermEquityAnticipationSecurity"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionHolder"></see>
    /// </summary>
    let OptionHolder = _prefix "OptionHolder"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionIssuer"></see>
    /// </summary>
    let OptionIssuer = _prefix "OptionIssuer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionOnFuture"></see>
    /// </summary>
    let OptionOnFuture = _prefix "OptionOnFuture"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionPremium"></see>
    /// </summary>
    let OptionPremium = _prefix "OptionPremium"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionPremiumFormula"></see>
    /// </summary>
    let OptionPremiumFormula = _prefix "OptionPremiumFormula"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OutOfTheMoney"></see>
    /// </summary>
    let OutOfTheMoney = _prefix "OutOfTheMoney"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/ProtectiveCollar"></see>
    /// </summary>
    let ProtectiveCollar = _prefix "ProtectiveCollar"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/ProtectivePut"></see>
    /// </summary>
    let ProtectivePut = _prefix "ProtectivePut"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasCalculatedMarketValue"></see>
    /// </summary>
    let hasCalculatedMarketValue = _prefix "hasCalculatedMarketValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/RiskReversal"></see>
    /// </summary>
    let RiskReversal = _prefix "RiskReversal"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/StandardizedOptionsTerms"></see>
    /// </summary>
    let StandardizedOptionsTerms = _prefix "StandardizedOptionsTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Straddle"></see>
    /// </summary>
    let Straddle = _prefix "Straddle"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Strangle"></see>
    /// </summary>
    let Strangle = _prefix "Strangle"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/StripStrategy"></see>
    /// </summary>
    let StripStrategy = _prefix "StripStrategy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasExerciseDateOffset"></see>
    /// </summary>
    let hasExerciseDateOffset = _prefix "hasExerciseDateOffset"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasExerciseSchedule"></see>
    /// </summary>
    let hasExerciseSchedule = _prefix "hasExerciseSchedule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasInterestAccrualDateOffset"></see>
    /// </summary>
    let hasInterestAccrualDateOffset = _prefix "hasInterestAccrualDateOffset"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasOptionHolder"></see>
    /// </summary>
    let hasOptionHolder = _prefix "hasOptionHolder"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasOptionWriter"></see>
    /// </summary>
    let hasOptionWriter = _prefix "hasOptionWriter"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasSettlementDateOffset"></see>
    /// </summary>
    let hasSettlementDateOffset = _prefix "hasSettlementDateOffset"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasStrikePercentageAmount"></see>
    /// </summary>
    let hasStrikePercentageAmount = _prefix "hasStrikePercentageAmount"
