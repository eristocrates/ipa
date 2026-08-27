namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.Options.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_der_drc_opt =
    let _namespace_iri = Namespace_Iri fibo_der_drc_opt |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-der-drc-opt:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Options Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_der_drc_opt, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-opt:AtTheMoney</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-der-drc-opt:Moneyness</para>
    ///
    /// labels<para>"at-the-money"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/AtTheMoney">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/AtTheMoney</seealso>
    let AtTheMoney = Prefixed_Name(fibo_der_drc_opt, "AtTheMoney") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-opt:BasketOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"basket option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/BasketOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/BasketOption</seealso>
    let BasketOption = Prefixed_Name(fibo_der_drc_opt, "BasketOption") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-opt:BondOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bond option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/BondOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/BondOption</seealso>
    let BondOption = Prefixed_Name(fibo_der_drc_opt, "BondOption") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-opt:Butterfly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"butterfly"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Butterfly">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Butterfly</seealso>
    let Butterfly = Prefixed_Name(fibo_der_drc_opt, "Butterfly") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-opt:CallOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"call option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/CallOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/CallOption</seealso>
    let CallOption = Prefixed_Name(fibo_der_drc_opt, "CallOption") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-opt:CappedOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"capped option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/CappedOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/CappedOption</seealso>
    let CappedOption = Prefixed_Name(fibo_der_drc_opt, "CappedOption") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-opt:Collar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"collar"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Collar">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Collar</seealso>
    let Collar = Prefixed_Name(fibo_der_drc_opt, "Collar") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-opt:CondorSpread</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"condor spread"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/CondorSpread">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/CondorSpread</seealso>
    let CondorSpread = Prefixed_Name(fibo_der_drc_opt, "CondorSpread") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-opt:CoveredCall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"covered call"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/CoveredCall">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/CoveredCall</seealso>
    let CoveredCall = Prefixed_Name(fibo_der_drc_opt, "CoveredCall") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-opt:EquityOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equity option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/EquityOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/EquityOption</seealso>
    let EquityOption = Prefixed_Name(fibo_der_drc_opt, "EquityOption") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-opt:ExoticOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exotic option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/ExoticOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/ExoticOption</seealso>
    let ExoticOption = Prefixed_Name(fibo_der_drc_opt, "ExoticOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:ExtrinsicValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"extrinsic value"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/ExtrinsicValue">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/ExtrinsicValue</seealso>
    let ExtrinsicValue =
        Prefixed_Name(fibo_der_drc_opt, "ExtrinsicValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:Fence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fence"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Fence">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Fence</seealso>
    let Fence = Prefixed_Name(fibo_der_drc_opt, "Fence") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:FixedIncomeOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fixed income option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/FixedIncomeOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/FixedIncomeOption</seealso>
    let FixedIncomeOption =
        Prefixed_Name(fibo_der_drc_opt, "FixedIncomeOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:InTheMoney</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-der-drc-opt:Moneyness</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"in-the-money"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/InTheMoney">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/InTheMoney</seealso>
    let InTheMoney = Prefixed_Name(fibo_der_drc_opt, "InTheMoney") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:InterestRateOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest rate option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/InterestRateOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/InterestRateOption</seealso>
    let InterestRateOption =
        Prefixed_Name(fibo_der_drc_opt, "InterestRateOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:IntrinsicValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"intrinsic value"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/IntrinsicValue">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/IntrinsicValue</seealso>
    let IntrinsicValue =
        Prefixed_Name(fibo_der_drc_opt, "IntrinsicValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:IronButterfly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"iron butterfly"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/IronButterfly">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/IronButterfly</seealso>
    let IronButterfly = Prefixed_Name(fibo_der_drc_opt, "IronButterfly") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-opt:IronCondor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"iron condor"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/IronCondor">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/IronCondor</seealso>
    let IronCondor = Prefixed_Name(fibo_der_drc_opt, "IronCondor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:LongTermEquityAnticipationSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"long-term equity anticipation security"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/LongTermEquityAnticipationSecurity">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/LongTermEquityAnticipationSecurity</seealso>
    let LongTermEquityAnticipationSecurity =
        Prefixed_Name(fibo_der_drc_opt, "LongTermEquityAnticipationSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:Moneyness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"moneyness"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Moneyness">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Moneyness</seealso>
    let Moneyness = Prefixed_Name(fibo_der_drc_opt, "Moneyness") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-opt:OptionHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"option holder"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionHolder">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionHolder</seealso>
    let OptionHolder = Prefixed_Name(fibo_der_drc_opt, "OptionHolder") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-opt:OptionIssuer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"option issuer"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionIssuer">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionIssuer</seealso>
    let OptionIssuer = Prefixed_Name(fibo_der_drc_opt, "OptionIssuer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:OptionOnFuture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"option on future"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionOnFuture">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionOnFuture</seealso>
    let OptionOnFuture =
        Prefixed_Name(fibo_der_drc_opt, "OptionOnFuture") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:OptionPremium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"option premium"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionPremium">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionPremium</seealso>
    let OptionPremium = Prefixed_Name(fibo_der_drc_opt, "OptionPremium") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:OptionPremiumFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"option premium formula"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionPremiumFormula">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionPremiumFormula</seealso>
    let OptionPremiumFormula =
        Prefixed_Name(fibo_der_drc_opt, "OptionPremiumFormula") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:OptionTradingStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"option trading strategy"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionTradingStrategy">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionTradingStrategy</seealso>
    let OptionTradingStrategy =
        Prefixed_Name(fibo_der_drc_opt, "OptionTradingStrategy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:OutOfTheMoney</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-der-drc-opt:Moneyness</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"out-of-the-money"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OutOfTheMoney">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OutOfTheMoney</seealso>
    let OutOfTheMoney = Prefixed_Name(fibo_der_drc_opt, "OutOfTheMoney") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:ProtectiveCollar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"protective collar"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/ProtectiveCollar">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/ProtectiveCollar</seealso>
    let ProtectiveCollar =
        Prefixed_Name(fibo_der_drc_opt, "ProtectiveCollar") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:ProtectivePut</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"protective put"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/ProtectivePut">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/ProtectivePut</seealso>
    let ProtectivePut = Prefixed_Name(fibo_der_drc_opt, "ProtectivePut") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-opt:PutOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"put option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/PutOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/PutOption</seealso>
    let PutOption = Prefixed_Name(fibo_der_drc_opt, "PutOption") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-opt:RiskReversal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"risk reversal"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/RiskReversal">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/RiskReversal</seealso>
    let RiskReversal = Prefixed_Name(fibo_der_drc_opt, "RiskReversal") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:StandardizedOptionsTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"standardized options terms"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/StandardizedOptionsTerms">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/StandardizedOptionsTerms</seealso>
    let StandardizedOptionsTerms =
        Prefixed_Name(fibo_der_drc_opt, "StandardizedOptionsTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:Straddle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"straddle"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Straddle">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Straddle</seealso>
    let Straddle = Prefixed_Name(fibo_der_drc_opt, "Straddle") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-opt:Strangle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"strangle"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Strangle">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Strangle</seealso>
    let Strangle = Prefixed_Name(fibo_der_drc_opt, "Strangle") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-opt:StrikePrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"strike price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/StrikePrice">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/StrikePrice</seealso>
    let StrikePrice = Prefixed_Name(fibo_der_drc_opt, "StrikePrice") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-opt:StripStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"strip strategy"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/StripStrategy">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/StripStrategy</seealso>
    let StripStrategy = Prefixed_Name(fibo_der_drc_opt, "StripStrategy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-opt:VanillaOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"vanilla option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/VanillaOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/VanillaOption</seealso>
    let VanillaOption = Prefixed_Name(fibo_der_drc_opt, "VanillaOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:hasCalculatedMarketValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has calculated market value"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasCalculatedMarketValue">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasCalculatedMarketValue</seealso>
    let hasCalculatedMarketValue =
        Prefixed_Name(fibo_der_drc_opt, "hasCalculatedMarketValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:hasCapPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has cap price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasCapPrice">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasCapPrice</seealso>
    let hasCapPrice = Prefixed_Name(fibo_der_drc_opt, "hasCapPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:hasExerciseDateOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has exercise date offset"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasExerciseDateOffset">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasExerciseDateOffset</seealso>
    let hasExerciseDateOffset =
        Prefixed_Name(fibo_der_drc_opt, "hasExerciseDateOffset") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:hasExercisePrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has exercise price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasExercisePrice">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasExercisePrice</seealso>
    let hasExercisePrice =
        Prefixed_Name(fibo_der_drc_opt, "hasExercisePrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:hasExerciseSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has exercise schedule"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasExerciseSchedule">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasExerciseSchedule</seealso>
    let hasExerciseSchedule =
        Prefixed_Name(fibo_der_drc_opt, "hasExerciseSchedule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:hasExerciseStyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has exercise style"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasExerciseStyle">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasExerciseStyle</seealso>
    let hasExerciseStyle =
        Prefixed_Name(fibo_der_drc_opt, "hasExerciseStyle") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:hasInterestAccrualDateOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has interest accrual date offset"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasInterestAccrualDateOffset">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasInterestAccrualDateOffset</seealso>
    let hasInterestAccrualDateOffset =
        Prefixed_Name(fibo_der_drc_opt, "hasInterestAccrualDateOffset") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:hasOptionHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has option holder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasOptionHolder">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasOptionHolder</seealso>
    let hasOptionHolder =
        Prefixed_Name(fibo_der_drc_opt, "hasOptionHolder") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:hasOptionWriter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has option writer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasOptionWriter">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasOptionWriter</seealso>
    let hasOptionWriter =
        Prefixed_Name(fibo_der_drc_opt, "hasOptionWriter") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:hasSettlementDateOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has settlement date offset"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasSettlementDateOffset">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasSettlementDateOffset</seealso>
    let hasSettlementDateOffset =
        Prefixed_Name(fibo_der_drc_opt, "hasSettlementDateOffset") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:hasStrikePercentageAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has strike percentage amount"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasStrikePercentageAmount">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasStrikePercentageAmount</seealso>
    let hasStrikePercentageAmount =
        Prefixed_Name(fibo_der_drc_opt, "hasStrikePercentageAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-opt:hasStrikeRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has strike rate"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasStrikeRate">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasStrikeRate</seealso>
    let hasStrikeRate = Prefixed_Name(fibo_der_drc_opt, "hasStrikeRate") |> PrefixedName
