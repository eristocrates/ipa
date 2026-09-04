#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-der-drc-opt`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/" "fibo-der-drc-opt"

    let _namespaceIri = _prefixId.prefix ""
    let AtTheMoney = _prefixId.prefix "AtTheMoney"
    /// <summary>
    ///   <para>rdfs:label : basket option</para>
    ///   <para>skos:definition : option whose underlying asset is a group, or basket, of commodities, securities, indices, or currencies</para>
    ///   <para>cmns-av:explanatoryNote : As with other options, a basket option gives the holder the right, but not the obligation, to buy or sell the basket at a specific price, on or before a certain date. This exotic option has all the characteristics of a standard option, but with the basis of the strike price on the weighted value of its components. Currency baskets are the most popular type of basket option, and they will settle in the holder's home currency. Because it involves just one transaction, a basket option often costs less than multiple single options as it saves on commissions and fees.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/BasketOption">fibo-der-drc-opt:BasketOption</a>
    /// </summary>
    let BasketOption = _prefixId.prefix "BasketOption"
    /// <summary>
    ///   <para>rdfs:label : bond option</para>
    ///   <para>skos:definition : option giving the buyer (holder) the right, but not the obligation, to buy or sell (depending on whether it is a call or a put) a bond at a certain price on or before a specified date</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/BondOption">fibo-der-drc-opt:BondOption</a>
    /// </summary>
    let BondOption = _prefixId.prefix "BondOption"
    /// <summary>
    ///   <para>rdfs:label : butterfly</para>
    ///   <para>skos:definition : strategy that combines bull and bear spreads with a fixed risk and capped profit</para>
    ///   <para>cmns-av:explanatoryNote : These spreads are intended as a market-neutral strategy and pay off the most if the underlying asset does not move prior to option expiration. They involve either four calls, four puts, or a combination of puts and calls with three strike prices. Butterfly spreads pay off the most if the underlying asset price doesn't change before the option expires. The upper and lower strike prices are equal distance from the middle, or at-the-money, strike price.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Butterfly">fibo-der-drc-opt:Butterfly</a>
    /// </summary>
    let Butterfly = _prefixId.prefix "Butterfly"
    /// <summary>
    ///   <para>rdfs:label : call option</para>
    ///   <para>skos:definition : option giving the buyer (holder) the right, but not the obligation, to buy the assets specified at a fixed price or formula, on or before a specified date</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019.</para>
    ///   <para>cmns-av:explanatoryNote : The seller (issuer) of the call option assumes the obligation of delivering the assets specified should the buyer exercise the option.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/CallOption">fibo-der-drc-opt:CallOption</a>
    /// </summary>
    let CallOption = _prefixId.prefix "CallOption"
    /// <summary>
    ///   <para>rdfs:label : capped option</para>
    ///   <para>skos:definition : option with an established profit cap or cap price</para>
    ///   <para>cmns-av:explanatoryNote : The cap price is equal to the option's strike price plus a cap interval for a call option or the strike price minus a cap interval for a put option. A capped option is automatically exercised when the underlying security closes at or above (for a call) or at or below (for a put) the option's cap price.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/CappedOption">fibo-der-drc-opt:CappedOption</a>
    /// </summary>
    let CappedOption = _prefixId.prefix "CappedOption"
    /// <summary>
    ///   <para>rdfs:label : collar</para>
    ///   <para>skos:definition : option trading strategy that involves buying a downside put and selling an upside call that is implemented to protect against large losses, but which also limits large upside gains</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Collar">fibo-der-drc-opt:Collar</a>
    /// </summary>
    let Collar = _prefixId.prefix "Collar"
    /// <summary>
    ///   <para>rdfs:label : condor spread</para>
    ///   <para>skos:definition : non-directional options strategy that limits both gains and losses while seeking to profit from either low or high volatility</para>
    ///   <para>cmns-av:explanatoryNote : There are two types of condor spreads. A long condor seeks to profit from low volatility and little to no movement in the underlying asset. A short condor seeks to profit from high volatility and a sizable move in the underlying asset in either direction. A Condor Spread uses either all calls or all puts.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/CondorSpread">fibo-der-drc-opt:CondorSpread</a>
    /// </summary>
    let CondorSpread = _prefixId.prefix "CondorSpread"
    /// <summary>
    ///   <para>rdfs:label : covered call</para>
    ///   <para>skos:definition : call option in which the seller (investor) owns an equivalent amount of the underlying security</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/CoveredCall">fibo-der-drc-opt:CoveredCall</a>
    /// </summary>
    let CoveredCall = _prefixId.prefix "CoveredCall"
    /// <summary>
    ///   <para>rdfs:label : equity option</para>
    ///   <para>skos:definition : option giving the buyer (holder) the right, but not the obligation, to buy (via a call option) or sell (via a put option) the underlying equity assets specified at a pre-determined price (i.e., the strike price, fixed or calculated), on or before a specified date (the expiration date)</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019.</para>
    ///   <para>cmns-av:explanatoryNote : For an Equity Option, one contract represents 100 shares of stock. Equity options settle in 'American style'.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/EquityOption">fibo-der-drc-opt:EquityOption</a>
    /// </summary>
    let EquityOption = _prefixId.prefix "EquityOption"
    /// <summary>
    ///   <para>rdfs:label : exotic option</para>
    ///   <para>skos:definition : option that has a non-standard payout structure or other feature</para>
    ///   <para>cmns-av:adaptedFrom : Commodity Futures Trading Commission (CFTC) glossary, https://www.cftc.gov/LearnAndProtect/EducationCenter/CFTCGlossary/glossary_e.html</para>
    ///   <para>cmns-av:explanatoryNote : Exotic options include Asian options and lookback options, and are mostly traded in the over-the-counter market.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/ExoticOption">fibo-der-drc-opt:ExoticOption</a>
    /// </summary>
    let ExoticOption = _prefixId.prefix "ExoticOption"
    /// <summary>
    ///   <para>rdfs:label : extrinsic value</para>
    ///   <para>skos:definition : measure of the difference between the market price of an option, called the premium, and its intrinsic value</para>
    ///   <para>cmns-av:explanatoryNote : Extrinsic value is also the portion of the worth that has been assigned to an option by factors other than the underlying asset's price. The opposite of extrinsic value is intrinsic value, which is the inherent worth of an option.</para>
    ///   <para>cmns-av:synonym : option time value</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/ExtrinsicValue">fibo-der-drc-opt:ExtrinsicValue</a>
    /// </summary>
    let ExtrinsicValue = _prefixId.prefix "ExtrinsicValue"
    /// <summary>
    ///   <para>rdfs:label : fence</para>
    ///   <para>skos:definition : option trading strategy that uses options to limit the range of possible returns on a financial instrument</para>
    ///   <para>cmns-av:explanatoryNote : A fence consists of the following elements:
    /// - long position in a financial instrument (e.g., a share, index or currency)
    /// - long put (normally with a strike price close to or at the current spot price of the financial instrument)
    /// - short put (with a strike price lower than the bought put - e.g., 80% of the current spot price)
    /// - short call (with a strike price higher than the current spot price).cmns-av:explanatoryNote : The expiration dates of all the options are usually the same. The call strike is normally chosen in such a way that the sum total of the three option premiums is equal to zero. This investment strategy will ensure that the value of the investment at expiry will be between the strike price on the short call and the strike price on the long put. Thus, possible gains and losses (the value of the financial instrument minus the cost of acquiring it) are confined to a specified range. However, if the price of the financial instrument falls below the strike level of the sold put the investor will start participating in any further price declines of the financial instrument.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Fence">fibo-der-drc-opt:Fence</a>
    /// </summary>
    let Fence = _prefixId.prefix "Fence"
    /// <summary>
    ///   <para>rdfs:label : fixed income option</para>
    ///   <para>skos:definition : option giving the buyer (holder) the right, but not the obligation, to buy (via a call option) or sell (via a put option) the underlying fixed income assets specified at a pre-determined price (i.e., the strike price, fixed or calculated), on or before a specified date (the expiration date)</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019.</para>
    ///   <para>cmns-av:explanatoryNote : Fixed income options, or debt options, are derivatives contracts that use bonds or other fixed-income securities as their underlying asset.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/FixedIncomeOption">fibo-der-drc-opt:FixedIncomeOption</a>
    /// </summary>
    let FixedIncomeOption = _prefixId.prefix "FixedIncomeOption"
    let InTheMoney = _prefixId.prefix "InTheMoney"
    /// <summary>
    ///   <para>rdfs:label : interest rate option</para>
    ///   <para>skos:definition : option that giving the buyer (holder) the right, but not the obligation, to receive a cash payment if market interest rate of a reference rate is higher or lower, depending on the option, than the strike rate of the option</para>
    ///   <para>cmns-av:explanatoryNote : The amount of the payment will be based on the difference between the market rate on the exercise date and the strike rate, multiplied by the notional principal specified in the option contract, to calculate the total payment.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/InterestRateOption">fibo-der-drc-opt:InterestRateOption</a>
    /// </summary>
    let InterestRateOption = _prefixId.prefix "InterestRateOption"
    /// <summary>
    ///   <para>rdfs:label : intrinsic value</para>
    ///   <para>skos:definition : measure of what an asset is worth, i.e. with respect to its current price</para>
    ///   <para>cmns-av:explanatoryNote : This measure is arrived at by means of an objective calculation or complex financial model. In financial analysis this term is used in conjunction with the work of identifying, as nearly as possible, the underlying value of a company and its cash flow. In options pricing it refers to the difference between the strike price of the option and the current price of the underlying asset.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/IntrinsicValue">fibo-der-drc-opt:IntrinsicValue</a>
    /// </summary>
    let IntrinsicValue = _prefixId.prefix "IntrinsicValue"
    /// <summary>
    ///   <para>rdfs:label : iron butterfly</para>
    ///   <para>skos:definition : butterfly strategy that consists of two call options and two put options, three strike prices and the same expiration date</para>
    ///   <para>cmns-av:explanatoryNote : The key to using this trade as part of a successful trading strategy is to forecast a time when option prices are likely to decline in value generally. This usually occurs during periods of sideways movement or a mild upward trend.</para>
    ///   <para>cmns-av:synonym : iron fly</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/IronButterfly">fibo-der-drc-opt:IronButterfly</a>
    /// </summary>
    let IronButterfly = _prefixId.prefix "IronButterfly"
    /// <summary>
    ///   <para>rdfs:label : iron condor</para>
    ///   <para>skos:definition : condor strategy consisting of two puts (one long and one short) and two calls (one long and one short), and four strike prices, all with the same expiration date</para>
    ///   <para>cmns-av:explanatoryNote : The iron condor earns the maximum profit when the underlying asset closes between the middle strike prices at expiration. In other words, the goal is to profit from low volatility in the underlying asset.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/IronCondor">fibo-der-drc-opt:IronCondor</a>
    /// </summary>
    let IronCondor = _prefixId.prefix "IronCondor"

    /// <summary>
    ///   <para>rdfs:label : long-term equity anticipation security</para>
    ///   <para>skos:definition : equity option that allows the holder to buy or sell shares of stock with expiration dates that are longer than one year, and typically up to three years from issue</para>
    ///   <para>cmns-av:abbreviation : LEAP</para>
    ///   <para>cmns-av:explanatoryNote : By providing opportunities to control and manage risk or even to speculate, LEAPS are virtually identical to regular options. Expiration dates on LEAPs can range from nine months to three years, which is longer than the holding period for a traditional call or put option. Although they are not available on all stocks, LEAPS are available on most widely held issues.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/LongTermEquityAnticipationSecurity">fibo-der-drc-opt:LongTermEquityAnticipationSecurity</a>
    /// </summary>
    let LongTermEquityAnticipationSecurity =
        _prefixId.prefix "LongTermEquityAnticipationSecurity"

    /// <summary>
    ///   <para>rdfs:label : moneyness</para>
    ///   <para>skos:definition : classifier for a derivative relating its strike price to the price of its underlying asset</para>
    ///   <para>cmns-av:explanatoryNote : Moneyness describes the intrinsic value of an option in its current state. The term moneyness is most commonly used with put and call options and is an indicator as to the comparative value of the option with respect to its exercise/strike price. Moneyness can be measured with respect to the underlying stock or other asset's current/spot price or its future price.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Moneyness">fibo-der-drc-opt:Moneyness</a>
    /// </summary>
    let Moneyness = _prefixId.prefix "Moneyness"
    /// <summary>
    ///   <para>rdfs:label : option holder</para>
    ///   <para>skos:definition : party that owns an option</para>
    ///   <para>cmns-av:explanatoryNote : In a call, the option holder has the right, but not the obligation, to buy the underlying asset, while, in a put, the option holder has the right to sell the underlying asset. An option holder may sell the option contract itself, at which point the buyer becomes the option holder. Once the instrument is exercised there are typically additional, relevant obligations with regard to settlement.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionHolder">fibo-der-drc-opt:OptionHolder</a>
    /// </summary>
    let OptionHolder = _prefixId.prefix "OptionHolder"
    /// <summary>
    ///   <para>rdfs:label : option issuer</para>
    ///   <para>skos:definition : issuer granting the rights defined in the option in exchange for some consideration</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionIssuer">fibo-der-drc-opt:OptionIssuer</a>
    /// </summary>
    let OptionIssuer = _prefixId.prefix "OptionIssuer"
    /// <summary>
    ///   <para>rdfs:label : option on future</para>
    ///   <para>skos:definition : option that gives the holder the right, but not the obligation, to buy or sell a specific futures contract at a specified price on or before the option's expiration date</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionOnFuture">fibo-der-drc-opt:OptionOnFuture</a>
    /// </summary>
    let OptionOnFuture = _prefixId.prefix "OptionOnFuture"
    /// <summary>
    ///   <para>rdfs:label : option premium</para>
    ///   <para>skos:definition : current market price of an option contract</para>
    ///   <para>cmns-av:explanatoryNote : The option premium is the income received by the seller (writer) of an option contract to another party. In-the-money option premiums are composed of two factors: intrinsic and extrinsic value. Out-of-the-money options' premiums consist solely of extrinsic value. For stock options, the premium is quoted as a dollar amount per share, and most contracts represent the commitment of 100 shares.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionPremium">fibo-der-drc-opt:OptionPremium</a>
    /// </summary>
    let OptionPremium = _prefixId.prefix "OptionPremium"
    /// <summary>
    ///   <para>rdfs:label : option premium formula</para>
    ///   <para>skos:definition : expression used to calculate the premium based either on the price per option or percentage of the notional amount</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionPremiumFormula">fibo-der-drc-opt:OptionPremiumFormula</a>
    /// </summary>
    let OptionPremiumFormula = _prefixId.prefix "OptionPremiumFormula"
    /// <summary>
    ///   <para>rdfs:label : option trading strategy</para>
    ///   <para>skos:definition : trading tactic involving more than one option type, strike price, or expiration date on the same underlying asset</para>
    ///   <para>cmns-av:explanatoryNote : Note that some trading strategies may be considered financial instruments in their own right, but most strategies are not. The critical differentiators include whether the strategy itself can be traded, whether it has a financial instrument identifier independently from the identifier(s) of the embedded instrument(s), such as a FIGI or ISIN, and so forth.cmns-av:explanatoryNote : Option trading strategies refer to buying calls or put options or selling calls or put options or both together for the purpose of limiting losses and/or optimizing profits. Basically, these strategies utilize one or more combinations for the best outcome possible based on defined parameters. Simple combinations include option spread trades such as vertical spreads, calendar (or horizontal) spreads, and diagonal spreads. More involved combinations include trades such as condor or butterfly spreads which are actually combinations of two vertical spreads.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/OptionTradingStrategy">fibo-der-drc-opt:OptionTradingStrategy</a>
    /// </summary>
    let OptionTradingStrategy = _prefixId.prefix "OptionTradingStrategy"
    let OutOfTheMoney = _prefixId.prefix "OutOfTheMoney"
    /// <summary>
    ///   <para>rdfs:label : protective collar</para>
    ///   <para>skos:definition : collar that consists of a covered call and protective put</para>
    ///   <para>cmns-av:explanatoryNote : A protective collar consists of a long position in the underlying security, a put option purchased to hedge the downside risk on a stock, a call option written on the stock to finance the put purchase.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/ProtectiveCollar">fibo-der-drc-opt:ProtectiveCollar</a>
    /// </summary>
    let ProtectiveCollar = _prefixId.prefix "ProtectiveCollar"
    /// <summary>
    ///   <para>rdfs:label : protective put</para>
    ///   <para>skos:definition : put option giving the buyer (holder) the right, but not the obligation, to sell the assets specified at with a strike price equal or close to the current price of the underlying asset, on or before a specified date</para>
    ///   <para>cmns-av:explanatoryNote : A protective put is a risk management and options strategy that involves holding a long position in the underlying asset (e.g., stock). A protective put strategy is analogous to the nature of insurance. The main goal of a protective put is to limit potential losses that may result from an unexpected price drop of the underlying asset</para>
    ///   <para>cmns-av:synonym : synthetic call</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/ProtectivePut">fibo-der-drc-opt:ProtectivePut</a>
    /// </summary>
    let ProtectivePut = _prefixId.prefix "ProtectivePut"
    /// <summary>
    ///   <para>rdfs:label : put option</para>
    ///   <para>skos:definition : option giving the buyer (holder) the right, but not the obligation, to sell the assets specified at a fixed price or formula, on or before a specified date</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019.</para>
    ///   <para>cmns-av:explanatoryNote : The seller of the put option assumes the obligation of buying the assets specified should the buyer exercise the option.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/PutOption">fibo-der-drc-opt:PutOption</a>
    /// </summary>
    let PutOption = _prefixId.prefix "PutOption"
    /// <summary>
    ///   <para>rdfs:label : risk reversal</para>
    ///   <para>skos:definition : option trading strategy that consists of being short (selling) an out of the money put and being long (i.e., buying) an out of the money call, both with the same maturity</para>
    ///   <para>cmns-av:explanatoryNote : A risk reversal is a position which simulates profit and loss behavior of owning an underlying security; therefore, it is sometimes called a synthetic long. This is an investment strategy that amounts to both buying and selling out-of-money options simultaneously. In this strategy, the investor will first make a market hunch; if that hunch is bullish, he will want to go long. However, instead of going long on the stock, he will buy an out of the money call option, and simultaneously sell an out of the money put option. Presumably he will use the money from the sale of the put option to purchase the call option. Then as the stock goes up in price, the call option will be worth more, and the put option will be worth less.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/RiskReversal">fibo-der-drc-opt:RiskReversal</a>
    /// </summary>
    let RiskReversal = _prefixId.prefix "RiskReversal"
    /// <summary>
    ///   <para>rdfs:label : standardized options terms</para>
    ///   <para>skos:definition : standardized contract terms established by a securities or options exchange or by an options clearing entity</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019.</para>
    ///   <para>cmns-av:explanatoryNote : Such terms may relate to the underlying instruments, exercise price, expiration date, and contract size, for example.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/StandardizedOptionsTerms">fibo-der-drc-opt:StandardizedOptionsTerms</a>
    /// </summary>
    let StandardizedOptionsTerms = _prefixId.prefix "StandardizedOptionsTerms"
    /// <summary>
    ///   <para>rdfs:label : straddle</para>
    ///   <para>skos:definition : neutral option trading strategy that involves simultaneously buying both a put option and a call option for the underlying security with the same strike price and the same expiration date</para>
    ///   <para>cmns-av:explanatoryNote : The strategy is profitable only when the value of the underlier varies (rises or falls) from the strike price by more than the total premium paid.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Straddle">fibo-der-drc-opt:Straddle</a>
    /// </summary>
    let Straddle = _prefixId.prefix "Straddle"
    /// <summary>
    ///   <para>rdfs:label : strangle</para>
    ///   <para>skos:definition : option trading strategy in which the investor holds a position in both a call and a put option with different strike prices, but with the same expiration date and underlying asset</para>
    ///   <para>cmns-av:explanatoryNote : A strangle is a good strategy if you think the underlying security will experience a large price movement in the near future but are unsure of the direction. However, it is profitable mainly if the asset swings sharply in price.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/Strangle">fibo-der-drc-opt:Strangle</a>
    /// </summary>
    let Strangle = _prefixId.prefix "Strangle"
    /// <summary>
    ///   <para>rdfs:label : strike price</para>
    ///   <para>skos:definition : price at which a lot of the underlying asset may be bought or sold when the contract is exercised</para>
    ///   <para>cmns-av:explanatoryNote : For call options, the strike price is the price at which the security may be purchased by the option holder; for put options, the strike price is the price at which the security may be sold.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/StrikePrice">fibo-der-drc-opt:StrikePrice</a>
    /// </summary>
    let StrikePrice = _prefixId.prefix "StrikePrice"
    /// <summary>
    ///   <para>rdfs:label : strip strategy</para>
    ///   <para>skos:definition : option trading strategy that involves a sequential set of options with periodic reset dates, such that each period between resets behaves like an individual option</para>
    ///   <para>cmns-av:explanatoryNote : Typically, a strip is a strategy that involves being long in one call position and two put options, all with the same strike price on a single underlying stock. The investor who adopts this strategy believes that the underlying price of the stock will plummet in the near-term future. All three of the options will have the same expiration date and the same strike price. If the investor is correct and the price drastically decreases, the puts will pay out substantially. If the investor is wrong and the price of the underlying asset increases, the call option will mitigate the loss. The period between resets may be called a Caplet or Floorlet.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/StripStrategy">fibo-der-drc-opt:StripStrategy</a>
    /// </summary>
    let StripStrategy = _prefixId.prefix "StripStrategy"
    /// <summary>
    ///   <para>rdfs:label : vanilla option</para>
    ///   <para>skos:definition : common option giving the buyer (holder) the right, but not the obligation, to buy (via a call option) or sell (via a put option) the underlying assets specified at a pre-determined price (i.e., the strike price, fixed or calculated), on or before a specified date (the expiration date)</para>
    ///   <para>cmns-av:explanatoryNote : Vanilla options include call or put options that have no special or unusual features, and are typically exchange traded.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/VanillaOption">fibo-der-drc-opt:VanillaOption</a>
    /// </summary>
    let VanillaOption = _prefixId.prefix "VanillaOption"
    /// <summary>
    ///   <para>rdfs:label : has calculated market value</para>
    ///   <para>skos:definition : indicates a calculated price as of some relative date considered the market value of the option at that point in time</para>
    ///   <para>cmns-av:synonym : has premium</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasCalculatedMarketValue">fibo-der-drc-opt:hasCalculatedMarketValue</a>
    /// </summary>
    let hasCalculatedMarketValue = _prefixId.prefix "hasCalculatedMarketValue"
    /// <summary>
    ///   <para>rdfs:label : has cap price</para>
    ///   <para>skos:definition : price at which the contract may be exercised</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasCapPrice">fibo-der-drc-opt:hasCapPrice</a>
    /// </summary>
    let hasCapPrice = _prefixId.prefix "hasCapPrice"
    /// <summary>
    ///   <para>rdfs:label : has exercise date offset</para>
    ///   <para>skos:definition : indicates the period in days between the reset date and the exercise date</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasExerciseDateOffset">fibo-der-drc-opt:hasExerciseDateOffset</a>
    /// </summary>
    let hasExerciseDateOffset = _prefixId.prefix "hasExerciseDateOffset"
    /// <summary>
    ///   <para>rdfs:label : has exercise price</para>
    ///   <para>skos:definition : specifies a predetermined price at which the holder commits to buy or sell an underlying asset</para>
    ///   <para>cmns-av:synonym : has strike price</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasExercisePrice">fibo-der-drc-opt:hasExercisePrice</a>
    /// </summary>
    let hasExercisePrice = _prefixId.prefix "hasExercisePrice"
    /// <summary>
    ///   <para>rdfs:label : has exercise schedule</para>
    ///   <para>skos:definition : links an option to the schedule specified in the contract that constrains when it may be exercised</para>
    ///   <para>cmns-av:explanatoryNote : An exercise schedule may be as simple as a single date or date period. However, in more complex cases, it may be an ad hoc schedule of individual dates, or a regular schedule of periodic exercise dates.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasExerciseSchedule">fibo-der-drc-opt:hasExerciseSchedule</a>
    /// </summary>
    let hasExerciseSchedule = _prefixId.prefix "hasExerciseSchedule"
    /// <summary>
    ///   <para>rdfs:label : has exercise style^^xsd:string</para>
    ///   <para>skos:definition : indicates the exercise convention specified for the option^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasExerciseStyle">fibo-der-drc-opt:hasExerciseStyle</a>
    /// </summary>
    let hasExerciseStyle = _prefixId.prefix "hasExerciseStyle"
    /// <summary>
    ///   <para>rdfs:label : has interest accrual date offset</para>
    ///   <para>skos:definition : indicates the period in days between each reset date and the commencement of interest accrual for the next period</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasInterestAccrualDateOffset">fibo-der-drc-opt:hasInterestAccrualDateOffset</a>
    /// </summary>
    let hasInterestAccrualDateOffset = _prefixId.prefix "hasInterestAccrualDateOffset"
    /// <summary>
    ///   <para>rdfs:label : has option holder^^xsd:string</para>
    ///   <para>skos:definition : indicates the owner of the option^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasOptionHolder">fibo-der-drc-opt:hasOptionHolder</a>
    /// </summary>
    let hasOptionHolder = _prefixId.prefix "hasOptionHolder"
    /// <summary>
    ///   <para>rdfs:label : has option writer^^xsd:string</para>
    ///   <para>skos:definition : indicates the issuer of the option^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Typically, the option writer collects the premium when the option is initially sold.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasOptionWriter">fibo-der-drc-opt:hasOptionWriter</a>
    /// </summary>
    let hasOptionWriter = _prefixId.prefix "hasOptionWriter"
    /// <summary>
    ///   <para>rdfs:label : has settlement date offset</para>
    ///   <para>skos:definition : indicats the period in days between each reset date and the corresponding settlement date</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasSettlementDateOffset">fibo-der-drc-opt:hasSettlementDateOffset</a>
    /// </summary>
    let hasSettlementDateOffset = _prefixId.prefix "hasSettlementDateOffset"
    /// <summary>
    ///   <para>rdfs:label : has strike percentage amount</para>
    ///   <para>skos:definition : indicates a strike price or level expressed as a percentage of the value of the underlying asset</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasStrikePercentageAmount">fibo-der-drc-opt:hasStrikePercentageAmount</a>
    /// </summary>
    let hasStrikePercentageAmount = _prefixId.prefix "hasStrikePercentageAmount"
    /// <summary>
    ///   <para>rdfs:label : has strike rate</para>
    ///   <para>skos:definition : rate at which the contract may be exercised</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/hasStrikeRate">fibo-der-drc-opt:hasStrikeRate</a>
    /// </summary>
    let hasStrikeRate = _prefixId.prefix "hasStrikeRate"
