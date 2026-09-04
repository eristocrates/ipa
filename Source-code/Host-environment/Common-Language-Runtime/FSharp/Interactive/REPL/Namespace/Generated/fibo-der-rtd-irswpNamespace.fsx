#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-der-rtd-irswp`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/" "fibo-der-rtd-irswp"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : cross-currency interest rate swap^^xsd:string</para>
    ///   <para>skos:definition : interest rate swap in which the two streams of interest payments are in different currencies^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/CrossCurrencyInterestRateSwap">fibo-der-rtd-irswp:CrossCurrencyInterestRateSwap</a>
    /// </summary>
    let CrossCurrencyInterestRateSwap = _prefixId.prefix "CrossCurrencyInterestRateSwap"
    /// <summary>
    ///   <para>rdfs:label : fixed fixed interest rate swap^^xsd:string</para>
    ///   <para>skos:definition : interest rate swap in which both parties pay a fixed interest rate that they could not otherwise obtain outside of a swap arrangement^^xsd:string</para>
    ///   <para>skos:example : For example, each counterparty uses a different native currency, but wants to borrow money in the other counterparty's native currency.^^xsd:string</para>
    ///   <para>skos:note : Fixed-fixed swaps generally take the form of either a zero coupon swap or a cross-currency swap.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of Financial Instruments (CFI code), Fourth edition, 2019-10.^^xsd:string</para>
    ///   <para>cmns-av:synonym : fixed-fixed interest rate swap^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedFixedInterestRateSwap">fibo-der-rtd-irswp:FixedFixedInterestRateSwap</a>
    /// </summary>
    let FixedFixedInterestRateSwap = _prefixId.prefix "FixedFixedInterestRateSwap"

    /// <summary>
    ///   <para>rdfs:label : fixed float cross-currency interest rate swap^^xsd:string</para>
    ///   <para>skos:definition : interest rate swap in which fixed interest payments on the notional are exchanged for floating interest payments and the two streams of interest payments are in different currencies^^xsd:string</para>
    ///   <para>cmns-av:synonym : fixed float cross currency interest rate swap^^xsd:stringcmns-av:synonym : fixed-float cross-currency interest rate swap^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedFloatCrossCurrencyInterestRateSwap">fibo-der-rtd-irswp:FixedFloatCrossCurrencyInterestRateSwap</a>
    /// </summary>
    let FixedFloatCrossCurrencyInterestRateSwap =
        _prefixId.prefix "FixedFloatCrossCurrencyInterestRateSwap"

    /// <summary>
    ///   <para>rdfs:label : fixed float interest rate swap^^xsd:string</para>
    ///   <para>skos:definition : interest rate swap in which fixed interest payments on the notional are exchanged for floating interest payments^^xsd:string</para>
    ///   <para>cmns-av:synonym : fixed-float interest rate swap^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedFloatInterestRateSwap">fibo-der-rtd-irswp:FixedFloatInterestRateSwap</a>
    /// </summary>
    let FixedFloatInterestRateSwap = _prefixId.prefix "FixedFloatInterestRateSwap"

    /// <summary>
    ///   <para>rdfs:label : fixed float single currency interest rate swap^^xsd:string</para>
    ///   <para>skos:definition : interest rate swap in which fixed interest payments on the notional are exchanged for floating interest payments and where both payment streams are expressed in terms of the same currency^^xsd:string</para>
    ///   <para>cmns-av:synonym : fixed-float single-currency interest rate swap^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedFloatSingleCurrencyInterestRateSwap">fibo-der-rtd-irswp:FixedFloatSingleCurrencyInterestRateSwap</a>
    /// </summary>
    let FixedFloatSingleCurrencyInterestRateSwap =
        _prefixId.prefix "FixedFloatSingleCurrencyInterestRateSwap"

    /// <summary>
    ///   <para>rdfs:label : fixed interest rate leg^^xsd:string</para>
    ///   <para>skos:definition : fixed leg that specifies fixed interest amounts and terms for the payment of that interest^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This may be the funding leg of some swaps (i.e. one party agrees to pay fixed interest amounts in exchange for whatever is the other leg) or it may be one or both sides of an interest rate swap, where the two parties exchange different interest payment streams.^^xsd:string</para>
    ///   <para>cmns-av:synonym : fixed interest rate payment stream^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FixedInterestRateLeg">fibo-der-rtd-irswp:FixedInterestRateLeg</a>
    /// </summary>
    let FixedInterestRateLeg = _prefixId.prefix "FixedInterestRateLeg"

    /// <summary>
    ///   <para>rdfs:label : float float cross-currency interest rate swap^^xsd:string</para>
    ///   <para>skos:definition : interest rate swap that exchanges cashflows based on two different interest rates in different currencies^^xsd:string</para>
    ///   <para>cmns-av:synonym : float-float cross-currency interest rate swap^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FloatFloatCrossCurrencyInterestRateSwap">fibo-der-rtd-irswp:FloatFloatCrossCurrencyInterestRateSwap</a>
    /// </summary>
    let FloatFloatCrossCurrencyInterestRateSwap =
        _prefixId.prefix "FloatFloatCrossCurrencyInterestRateSwap"

    /// <summary>
    ///   <para>rdfs:label : float float interest rate swap^^xsd:string</para>
    ///   <para>skos:definition : interest rate swap that exchanges cashflows based on two different floating interest rates^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.investopedia.com/terms/b/basisrateswap.asp^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : This is a swap in which two parties swap variable interest rates based on different money markets, and this is usually done to limit interest-rate risk that a company faces as a result of having differing lending and borrowing rates.^^xsd:string</para>
    ///   <para>cmns-av:synonym : basis rate swap^^xsd:stringcmns-av:synonym : float-float interest rate swap^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FloatFloatInterestRateSwap">fibo-der-rtd-irswp:FloatFloatInterestRateSwap</a>
    /// </summary>
    let FloatFloatInterestRateSwap = _prefixId.prefix "FloatFloatInterestRateSwap"

    /// <summary>
    ///   <para>rdfs:label : float float single currency interest rate swap^^xsd:string</para>
    ///   <para>skos:definition : interest rate swap that exchanges cashflows based on two different floating interest rates in the same currency^^xsd:string</para>
    ///   <para>cmns-av:synonym : float-float single-currency interest rate swap^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FloatFloatSingleCurrencyInterestRateSwap">fibo-der-rtd-irswp:FloatFloatSingleCurrencyInterestRateSwap</a>
    /// </summary>
    let FloatFloatSingleCurrencyInterestRateSwap =
        _prefixId.prefix "FloatFloatSingleCurrencyInterestRateSwap"

    /// <summary>
    ///   <para>rdfs:label : floating interest rate leg^^xsd:string</para>
    ///   <para>skos:definition : floating leg in which variable interest is paid on some notional amount, linked to some underlying interest reference rate^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Instead of an absolute rate you have either a variable reference rate or fixed reference rate and an offset that varies in some way, called a spread (same as margin in floating rate notes).^^xsd:string</para>
    ///   <para>cmns-av:synonym : floating interest rate swap stream^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/FloatingInterestRateLeg">fibo-der-rtd-irswp:FloatingInterestRateLeg</a>
    /// </summary>
    let FloatingInterestRateLeg = _prefixId.prefix "FloatingInterestRateLeg"
    /// <summary>
    ///   <para>rdfs:label : inflation leg</para>
    ///   <para>skos:definition : floating rate leg of an inflation swap linked to an inflation index, such as the Consumer Price Index (CPI)</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/InflationLeg">fibo-der-rtd-irswp:InflationLeg</a>
    /// </summary>
    let InflationLeg = _prefixId.prefix "InflationLeg"
    /// <summary>
    ///   <para>rdfs:label : inflation swap</para>
    ///   <para>skos:definition : rate swap in which one party pays an amount calculated using an inflation rate index, and the other party pays an amount calculated using another inflation rate index, or a fixed or floating interest rate</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fifth edition, 2021-06-15</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/InflationSwap">fibo-der-rtd-irswp:InflationSwap</a>
    /// </summary>
    let InflationSwap = _prefixId.prefix "InflationSwap"
    /// <summary>
    ///   <para>rdfs:label : interest rate swap^^xsd:string</para>
    ///   <para>skos:definition : swap in which the reference (underlier) for at least one leg is an interest rate^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/InterestRateSwap">fibo-der-rtd-irswp:InterestRateSwap</a>
    /// </summary>
    let InterestRateSwap = _prefixId.prefix "InterestRateSwap"
    /// <summary>
    ///   <para>rdfs:label : interest rate swap leg^^xsd:string</para>
    ///   <para>skos:definition : swap leg that has an interest rate payment stream, including both a parametric and cashflow representation for the stream of payments^^xsd:string</para>
    ///   <para>cmns-av:synonym : interest rate swap stream^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/InterestRateSwapLeg">fibo-der-rtd-irswp:InterestRateSwapLeg</a>
    /// </summary>
    let InterestRateSwapLeg = _prefixId.prefix "InterestRateSwapLeg"
    /// <summary>
    ///   <para>rdfs:label : notional step amount^^xsd:string</para>
    ///   <para>skos:definition : the amount of money that is subtracted from the notional on each step date^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that this is an actual concrete sum of money, which may be specified either as a monetary amount (e.g. dollars and cents) or as a percentage of either the original notional amount or the previous notional amount.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/NotionalStepAmount">fibo-der-rtd-irswp:NotionalStepAmount</a>
    /// </summary>
    let NotionalStepAmount = _prefixId.prefix "NotionalStepAmount"
    /// <summary>
    ///   <para>rdfs:label : notional step change event^^xsd:string</para>
    ///   <para>skos:definition : event in which a step change in the notional amount for a given swap leg occurs^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The frequency / period length of the steps in the step schedule is a multiple of the calculation period or frequency. For example, if the notional is recalculated on every calculation date, applying a new interest rate to the new notional amount, then the two frequencies are the same. If notional is updated every second calculation period, then the step schedule specifies periods that are twice as long, and so on.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/NotionalStepChangeEvent">fibo-der-rtd-irswp:NotionalStepChangeEvent</a>
    /// </summary>
    let NotionalStepChangeEvent = _prefixId.prefix "NotionalStepChangeEvent"
    /// <summary>
    ///   <para>rdfs:label : notional step period length^^xsd:string</para>
    ///   <para>skos:definition : recurrence interval indicating the frequency with which step changes occur, which is a multiple of the calculation period in the calculation schedule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/NotionalStepPeriodLength">fibo-der-rtd-irswp:NotionalStepPeriodLength</a>
    /// </summary>
    let NotionalStepPeriodLength = _prefixId.prefix "NotionalStepPeriodLength"
    /// <summary>
    ///   <para>rdfs:label : notional step schedule^^xsd:string</para>
    ///   <para>skos:definition : schedule of changes in the notional amount on which interest is paid, comprising the regular sequence of step events^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/NotionalStepSchedule">fibo-der-rtd-irswp:NotionalStepSchedule</a>
    /// </summary>
    let NotionalStepSchedule = _prefixId.prefix "NotionalStepSchedule"
    /// <summary>
    ///   <para>rdfs:label : overnight index swap</para>
    ///   <para>skos:definition : swap in which the periodic payments for one leg are based on an overnight interest rate index multiplied by the same notional amount upon which payments for the other leg of the swap are based</para>
    ///   <para>cmns-av:abbreviation : OIS swap</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fifth edition, 2021-06-15</para>
    ///   <para>cmns-av:explanatoryNote : The interest of the overnight rate portion of the swap is compounded and paid at reset dates. The present value for the leg is determined by either compounding of the overnight rate or by taking the geometric average of the rate over a given period.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/OvernightIndexSwap">fibo-der-rtd-irswp:OvernightIndexSwap</a>
    /// </summary>
    let OvernightIndexSwap = _prefixId.prefix "OvernightIndexSwap"
    /// <summary>
    ///   <para>rdfs:label : overnight rate index leg^^xsd:string</para>
    ///   <para>skos:definition : floating leg in which periodic payments are based on an overnight interest rate index multiplied by the same notional amount on which the payments for the other leg of the swap are based^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fifth edition, 2021-06-15</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/OvernightRateIndexLeg">fibo-der-rtd-irswp:OvernightRateIndexLeg</a>
    /// </summary>
    let OvernightRateIndexLeg = _prefixId.prefix "OvernightRateIndexLeg"
    /// <summary>
    ///   <para>rdfs:label : plain vanilla interest rate swap^^xsd:string</para>
    ///   <para>skos:definition : fixed-float single currency interest rate swap in which interest payments are netted, the notional principal does not change, and there are no embedded options^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/PlainVanillaInterestRateSwap">fibo-der-rtd-irswp:PlainVanillaInterestRateSwap</a>
    /// </summary>
    let PlainVanillaInterestRateSwap = _prefixId.prefix "PlainVanillaInterestRateSwap"

    /// <summary>
    ///   <para>rdfs:label : single currency interest rate swap^^xsd:string</para>
    ///   <para>skos:definition : interest rate swap in which the two streams of interest payments are in the same currency^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/SingleCurrencyInterestRateSwap">fibo-der-rtd-irswp:SingleCurrencyInterestRateSwap</a>
    /// </summary>
    let SingleCurrencyInterestRateSwap =
        _prefixId.prefix "SingleCurrencyInterestRateSwap"

    /// <summary>
    ///   <para>rdfs:label : zero coupon interest rate swap^^xsd:string</para>
    ///   <para>skos:definition : interest rate swap in which the fixed rate cash flows are compounded and paid once on the expiration date, rather than periodically; the payments on the other side (which can be based on a floating interest rate or a fixed rate) follow typical swap payment schedules^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fifth edition, 2021-06-15</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/ZeroCouponInterestRateSwap">fibo-der-rtd-irswp:ZeroCouponInterestRateSwap</a>
    /// </summary>
    let ZeroCouponInterestRateSwap = _prefixId.prefix "ZeroCouponInterestRateSwap"
    /// <summary>
    ///   <para>rdfs:label : has first notional step date^^xsd:string</para>
    ///   <para>skos:definition : indicates the initial date in a notional step schedule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasFirstNotionalStepDate">fibo-der-rtd-irswp:hasFirstNotionalStepDate</a>
    /// </summary>
    let hasFirstNotionalStepDate = _prefixId.prefix "hasFirstNotionalStepDate"
    /// <summary>
    ///   <para>rdfs:label : has floating rate cap^^xsd:string</para>
    ///   <para>skos:definition : indicates an optional ceiling (cap) on interest rates on floating rate debts^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Rate caps can be viewed as insurance, ensuring that the maximum borrowing rate never exceeds the specified cap level.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasFloatingRateCap">fibo-der-rtd-irswp:hasFloatingRateCap</a>
    /// </summary>
    let hasFloatingRateCap = _prefixId.prefix "hasFloatingRateCap"
    /// <summary>
    ///   <para>rdfs:label : has floating rate floor^^xsd:string</para>
    ///   <para>skos:definition : indicates an optional lower bound on interest rates on floating rate debts^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasFloatingRateFloor">fibo-der-rtd-irswp:hasFloatingRateFloor</a>
    /// </summary>
    let hasFloatingRateFloor = _prefixId.prefix "hasFloatingRateFloor"
    /// <summary>
    ///   <para>rdfs:label : has floating rate spread^^xsd:string</para>
    ///   <para>skos:definition : defines the spread rate that can optionally be used to adjust the floating rate^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Such adjustments may be added to or subtracted from the floating rate.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasFloatingRateSpread">fibo-der-rtd-irswp:hasFloatingRateSpread</a>
    /// </summary>
    let hasFloatingRateSpread = _prefixId.prefix "hasFloatingRateSpread"
    /// <summary>
    ///   <para>rdfs:label : has last notional step date^^xsd:string</para>
    ///   <para>skos:definition : indicates the final date in a notional step schedule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasLastNotionalStepDate">fibo-der-rtd-irswp:hasLastNotionalStepDate</a>
    /// </summary>
    let hasLastNotionalStepDate = _prefixId.prefix "hasLastNotionalStepDate"
    /// <summary>
    ///   <para>rdfs:label : has rate multiplier^^xsd:string</para>
    ///   <para>skos:definition : indicates a multiplier applied to the coupon before adding the floating rate spread^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/hasRateMultiplier">fibo-der-rtd-irswp:hasRateMultiplier</a>
    /// </summary>
    let hasRateMultiplier = _prefixId.prefix "hasRateMultiplier"
