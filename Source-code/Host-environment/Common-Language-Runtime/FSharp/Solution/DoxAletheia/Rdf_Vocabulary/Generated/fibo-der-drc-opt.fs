namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.Options.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_der_drc_opt =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/AtTheMoney"></see>
    /// </summary>
    let AtTheMoney = Namespaced_IRI.parse _namespace_name "AtTheMoney" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Moneyness"></see>
    /// </summary>
    let Moneyness = Namespaced_IRI.parse _namespace_name "Moneyness" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/BasketOption"></see>
    /// </summary>
    let BasketOption =
        Namespaced_IRI.parse _namespace_name "BasketOption" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/ExoticOption"></see>
    /// </summary>
    let ExoticOption =
        Namespaced_IRI.parse _namespace_name "ExoticOption" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/BondOption"></see>
    /// </summary>
    let BondOption = Namespaced_IRI.parse _namespace_name "BondOption" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/FixedIncomeOption"></see>
    /// </summary>
    let FixedIncomeOption =
        Namespaced_IRI.parse _namespace_name "FixedIncomeOption" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Butterfly"></see>
    /// </summary>
    let Butterfly = Namespaced_IRI.parse _namespace_name "Butterfly" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionTradingStrategy"></see>
    /// </summary>
    let OptionTradingStrategy =
        Namespaced_IRI.parse _namespace_name "OptionTradingStrategy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasExercisePrice"></see>
    /// </summary>
    let hasExercisePrice =
        Namespaced_IRI.parse _namespace_name "hasExercisePrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/StrikePrice"></see>
    /// </summary>
    let StrikePrice =
        Namespaced_IRI.parse _namespace_name "StrikePrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/CallOption"></see>
    /// </summary>
    let CallOption = Namespaced_IRI.parse _namespace_name "CallOption" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/CappedOption"></see>
    /// </summary>
    let CappedOption =
        Namespaced_IRI.parse _namespace_name "CappedOption" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/VanillaOption"></see>
    /// </summary>
    let VanillaOption =
        Namespaced_IRI.parse _namespace_name "VanillaOption" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasCapPrice"></see>
    /// </summary>
    let hasCapPrice =
        Namespaced_IRI.parse _namespace_name "hasCapPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Collar"></see>
    /// </summary>
    let Collar = Namespaced_IRI.parse _namespace_name "Collar" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/PutOption"></see>
    /// </summary>
    let PutOption = Namespaced_IRI.parse _namespace_name "PutOption" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/CondorSpread"></see>
    /// </summary>
    let CondorSpread =
        Namespaced_IRI.parse _namespace_name "CondorSpread" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/CoveredCall"></see>
    /// </summary>
    let CoveredCall =
        Namespaced_IRI.parse _namespace_name "CoveredCall" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/EquityOption"></see>
    /// </summary>
    let EquityOption =
        Namespaced_IRI.parse _namespace_name "EquityOption" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasExerciseStyle"></see>
    /// </summary>
    let hasExerciseStyle =
        Namespaced_IRI.parse _namespace_name "hasExerciseStyle" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/ExtrinsicValue"></see>
    /// </summary>
    let ExtrinsicValue =
        Namespaced_IRI.parse _namespace_name "ExtrinsicValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/IntrinsicValue"></see>
    /// </summary>
    let IntrinsicValue =
        Namespaced_IRI.parse _namespace_name "IntrinsicValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Fence"></see>
    /// </summary>
    let Fence = Namespaced_IRI.parse _namespace_name "Fence" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/InTheMoney"></see>
    /// </summary>
    let InTheMoney = Namespaced_IRI.parse _namespace_name "InTheMoney" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/InterestRateOption"></see>
    /// </summary>
    let InterestRateOption =
        Namespaced_IRI.parse _namespace_name "InterestRateOption" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasStrikeRate"></see>
    /// </summary>
    let hasStrikeRate =
        Namespaced_IRI.parse _namespace_name "hasStrikeRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/IronButterfly"></see>
    /// </summary>
    let IronButterfly =
        Namespaced_IRI.parse _namespace_name "IronButterfly" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/IronCondor"></see>
    /// </summary>
    let IronCondor = Namespaced_IRI.parse _namespace_name "IronCondor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/LongTermEquityAnticipationSecurity"></see>
    /// </summary>
    let LongTermEquityAnticipationSecurity =
        Namespaced_IRI.parse _namespace_name "LongTermEquityAnticipationSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionHolder"></see>
    /// </summary>
    let OptionHolder =
        Namespaced_IRI.parse _namespace_name "OptionHolder" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionIssuer"></see>
    /// </summary>
    let OptionIssuer =
        Namespaced_IRI.parse _namespace_name "OptionIssuer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionOnFuture"></see>
    /// </summary>
    let OptionOnFuture =
        Namespaced_IRI.parse _namespace_name "OptionOnFuture" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionPremium"></see>
    /// </summary>
    let OptionPremium =
        Namespaced_IRI.parse _namespace_name "OptionPremium" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionPremiumFormula"></see>
    /// </summary>
    let OptionPremiumFormula =
        Namespaced_IRI.parse _namespace_name "OptionPremiumFormula" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OutOfTheMoney"></see>
    /// </summary>
    let OutOfTheMoney =
        Namespaced_IRI.parse _namespace_name "OutOfTheMoney" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/ProtectiveCollar"></see>
    /// </summary>
    let ProtectiveCollar =
        Namespaced_IRI.parse _namespace_name "ProtectiveCollar" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/ProtectivePut"></see>
    /// </summary>
    let ProtectivePut =
        Namespaced_IRI.parse _namespace_name "ProtectivePut" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasCalculatedMarketValue"></see>
    /// </summary>
    let hasCalculatedMarketValue =
        Namespaced_IRI.parse _namespace_name "hasCalculatedMarketValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/RiskReversal"></see>
    /// </summary>
    let RiskReversal =
        Namespaced_IRI.parse _namespace_name "RiskReversal" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/StandardizedOptionsTerms"></see>
    /// </summary>
    let StandardizedOptionsTerms =
        Namespaced_IRI.parse _namespace_name "StandardizedOptionsTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Straddle"></see>
    /// </summary>
    let Straddle = Namespaced_IRI.parse _namespace_name "Straddle" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Strangle"></see>
    /// </summary>
    let Strangle = Namespaced_IRI.parse _namespace_name "Strangle" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/StripStrategy"></see>
    /// </summary>
    let StripStrategy =
        Namespaced_IRI.parse _namespace_name "StripStrategy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasExerciseDateOffset"></see>
    /// </summary>
    let hasExerciseDateOffset =
        Namespaced_IRI.parse _namespace_name "hasExerciseDateOffset" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasExerciseSchedule"></see>
    /// </summary>
    let hasExerciseSchedule =
        Namespaced_IRI.parse _namespace_name "hasExerciseSchedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasInterestAccrualDateOffset"></see>
    /// </summary>
    let hasInterestAccrualDateOffset =
        Namespaced_IRI.parse _namespace_name "hasInterestAccrualDateOffset" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasOptionHolder"></see>
    /// </summary>
    let hasOptionHolder =
        Namespaced_IRI.parse _namespace_name "hasOptionHolder" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasOptionWriter"></see>
    /// </summary>
    let hasOptionWriter =
        Namespaced_IRI.parse _namespace_name "hasOptionWriter" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasSettlementDateOffset"></see>
    /// </summary>
    let hasSettlementDateOffset =
        Namespaced_IRI.parse _namespace_name "hasSettlementDateOffset" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasStrikePercentageAmount"></see>
    /// </summary>
    let hasStrikePercentageAmount =
        Namespaced_IRI.parse _namespace_name "hasStrikePercentageAmount" |> NamespacedName
