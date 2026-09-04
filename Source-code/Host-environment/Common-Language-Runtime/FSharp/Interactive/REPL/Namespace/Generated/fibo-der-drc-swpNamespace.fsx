#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-der-drc-swp`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/" "fibo-der-drc-swp"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : basis swap^^xsd:string</para>
    ///   <para>skos:definition : swap in which payment streams are referenced to different bases^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A basis swap can have two legs of the same tenor but different indices, e.g., 3 month LIBOR vs. 3 month TIBOR. The difference in this case is not driven by different interest rate periods but from different markets, i.e., the difference in efficiency between the two markets. The objective is to hedge against basis risk which is the difference in price between two markets. See also forward swap, as a means for controlling interest rate.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/BasisSwap">fibo-der-drc-swp:BasisSwap</a>
    /// </summary>
    let BasisSwap = _prefixId.prefix "BasisSwap"
    /// <summary>
    ///   <para>rdfs:label : correlation leg</para>
    ///   <para>skos:definition : floating leg of a correlation swap that pays an amount based on the observed average correlation of the prices of a collection of underlying products</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/CorrelationLeg">fibo-der-drc-swp:CorrelationLeg</a>
    /// </summary>
    let CorrelationLeg = _prefixId.prefix "CorrelationLeg"
    /// <summary>
    ///   <para>rdfs:label : correlation swap</para>
    ///   <para>skos:definition : over-the-counter statistical derivative that allows one to hedge risks associated with the observed average correlation of a collection of underlying products</para>
    ///   <para>cmns-av:explanatoryNote : Each product that can act as the underlier on which the correlation is based has periodically observable prices, such as a commodity, exchange rate, interest rate, or stock index. Correlation trading is a strategy in which the investor receives exposure to the average correlation of an index.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/CorrelationSwap">fibo-der-drc-swp:CorrelationSwap</a>
    /// </summary>
    let CorrelationSwap = _prefixId.prefix "CorrelationSwap"
    /// <summary>
    ///   <para>rdfs:label : dispersion leg</para>
    ///   <para>skos:definition : floating leg of a dispersion swap that pays an amount based on the realized dispersion of the price changes of the underlying product^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Underlying assets may include, for example, exchange rates, interest rates, or the price of an index.</para>
    ///   <para>cmns-av:synonym : variance leg</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/DispersionLeg">fibo-der-drc-swp:DispersionLeg</a>
    /// </summary>
    let DispersionLeg = _prefixId.prefix "DispersionLeg"
    /// <summary>
    ///   <para>rdfs:label : dispersion swap</para>
    ///   <para>skos:definition : statistical derivative used to hedge on the magnitude of a price movement of an underlying asset</para>
    ///   <para>cmns-av:explanatoryNote : A variance swap is an instrument that allows investors to trade future realized (or historical) volatility against current implied volatility.^^xsd:stringcmns-av:explanatoryNote : Some strategies involve selling a variance swap on an index and buying the variance swaps on the individual constituents; this particular kind of spread trade is called a variance dispersion trade.^^xsd:string</para>
    ///   <para>cmns-av:synonym : variance swap</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/DispersionSwap">fibo-der-drc-swp:DispersionSwap</a>
    /// </summary>
    let DispersionSwap = _prefixId.prefix "DispersionSwap"
    /// <summary>
    ///   <para>rdfs:label : excess return swap</para>
    ///   <para>skos:definition : return swap in which the change in the level of the index will be equal to the returns generated primarily by the changes in price of each of the contracts that comprise the index</para>
    ///   <para>cmns-av:adaptedFrom : ISDA Disclosure Annex for Commodity Derivative Transactions. See https://globalmarkets.bnpparibas.com/gm/features/docs/dfdisclosures/ISDA_Commodity_Derivatives_Disclosure_Annex_04_2013.pdf</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/ExcessReturnSwap">fibo-der-drc-swp:ExcessReturnSwap</a>
    /// </summary>
    let ExcessReturnSwap = _prefixId.prefix "ExcessReturnSwap"
    /// <summary>
    ///   <para>rdfs:label : fixed leg^^xsd:string</para>
    ///   <para>skos:definition : swap leg whose paying party is obligated to make payments from time to time over the term of a swap calculated by reference to a fixed annual rate or consisting of at least one payment of a fixed amount^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : 2006 ISDA Definitionscmns-av:adaptedFrom : ISDA Disclosure Annex for Commodity Derivative Transactions. See https://globalmarkets.bnpparibas.com/gm/features/docs/dfdisclosures/ISDA_Commodity_Derivatives_Disclosure_Annex_04_2013.pdf</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/FixedLeg">fibo-der-drc-swp:FixedLeg</a>
    /// </summary>
    let FixedLeg = _prefixId.prefix "FixedLeg"
    /// <summary>
    ///   <para>rdfs:label : fixed payment leg^^xsd:string</para>
    ///   <para>skos:definition : swap leg that specifies contractual terms associated with a schedule of payments for any swap calculated by reference to a fixed annual rate^^xsd:string</para>
    ///   <para>cmns-av:synonym : fixed payment stream terms^^xsd:stringcmns-av:synonym : funding leg^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Payments may be fixed or variable, which is independent from the function of the leg (payments, return etc.). The schedule may be expressed in one of two ways: as an explicit schedule of dates or as a formula for determining payment dates in advance (taking into account for example roll rules for non working days).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/FixedPaymentLeg">fibo-der-drc-swp:FixedPaymentLeg</a>
    /// </summary>
    let FixedPaymentLeg = _prefixId.prefix "FixedPaymentLeg"
    /// <summary>
    ///   <para>rdfs:label : floating leg^^xsd:string</para>
    ///   <para>skos:definition : swap leg whose paying party is obligated to make payments from time to time over the term of a swap calculated by reference to some variable rate, calculated based on the change in value of some underlying asset, or consisting of at least one payment of some floating amount^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : 2006 ISDA Definitionscmns-av:adaptedFrom : ISDA Disclosure Annex for Commodity Derivative Transactions. See https://globalmarkets.bnpparibas.com/gm/features/docs/dfdisclosures/ISDA_Commodity_Derivatives_Disclosure_Annex_04_2013.pdf</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/FloatingLeg">fibo-der-drc-swp:FloatingLeg</a>
    /// </summary>
    let FloatingLeg = _prefixId.prefix "FloatingLeg"
    /// <summary>
    ///   <para>rdfs:label : index return swap</para>
    ///   <para>skos:definition : return swap in which payments are based on a fee paid to the seller of the swap and on a floating reference price based on changes in the level of an index from an initial level to a level observed on some valuation date(s)</para>
    ///   <para>cmns-av:adaptedFrom : ISDA Disclosure Annex for Commodity Derivative Transactions. See https://globalmarkets.bnpparibas.com/gm/features/docs/dfdisclosures/ISDA_Commodity_Derivatives_Disclosure_Annex_04_2013.pdf</para>
    ///   <para>cmns-av:explanatoryNote : Payments to the parties may be made either on a periodic basis or on termination of the transaction. One party will receive a payment based upon the change in the level of the index between two valuation dates (multiplied by the notional amount of the swap), as modified by the fee paid to the seller of the swap. If the level of the index increases, the buyer of the swap will be entitled to a payment based on this performance, as such payment may be reduced (or negated) by the fee paid to the seller of the swap. If the level of the index decreases, the seller of the swap will be entitled to a payment based on this performance, as such payment may be increased by the fee paid to the seller of the swap.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/IndexReturnSwap">fibo-der-drc-swp:IndexReturnSwap</a>
    /// </summary>
    let IndexReturnSwap = _prefixId.prefix "IndexReturnSwap"
    /// <summary>
    ///   <para>rdfs:label : major swap participant^^xsd:string</para>
    ///   <para>skos:definition : financial service provider that maintains a substantial position in swaps for any of the major swap categories^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : MSP^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.cftc.gov/IndustryOversight/Intermediaries/index.htm^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : This excludes positions held for hedging or mitigating commercial risk and positions maintained by an employee benefit plan for the primary purpose of hedging or mitigating any risk directly associated with the operation of the plan.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/MajorSwapParticipant">fibo-der-drc-swp:MajorSwapParticipant</a>
    /// </summary>
    let MajorSwapParticipant = _prefixId.prefix "MajorSwapParticipant"
    /// <summary>
    ///   <para>rdfs:label : performance-based variable leg^^xsd:string</para>
    ///   <para>skos:definition : floating leg of a swap that depends on some statistical measure of the performance of the underlier^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/PerformanceBasedVariableLeg">fibo-der-drc-swp:PerformanceBasedVariableLeg</a>
    /// </summary>
    let PerformanceBasedVariableLeg = _prefixId.prefix "PerformanceBasedVariableLeg"
    /// <summary>
    ///   <para>rdfs:label : rate-based leg</para>
    ///   <para>skos:definition : swap leg of a rate-based swap based on a floating interest, floating inflation or fixed interest rate</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/RateBasedLeg">fibo-der-drc-swp:RateBasedLeg</a>
    /// </summary>
    let RateBasedLeg = _prefixId.prefix "RateBasedLeg"
    /// <summary>
    ///   <para>rdfs:label : rates swap^^xsd:string</para>
    ///   <para>skos:definition : swap in two counterparties each agree to pay the other cash flows on defined dates during an agreed period, based on a specified notional amount and a floating interest, floating inflation or fixed interest rate^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fifth edition, 2021-06-15^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/RatesSwap">fibo-der-drc-swp:RatesSwap</a>
    /// </summary>
    let RatesSwap = _prefixId.prefix "RatesSwap"
    /// <summary>
    ///   <para>rdfs:label : realized variable leg^^xsd:string</para>
    ///   <para>skos:definition : performance-based leg wherein the payment is netted at maturity rather than periodically^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In this case there is a single payment at maturity/settlement and so there is no stream of cashflows either way. The other leg of these swaps is implied, and is simply the strike price.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/RealizedVariableLeg">fibo-der-drc-swp:RealizedVariableLeg</a>
    /// </summary>
    let RealizedVariableLeg = _prefixId.prefix "RealizedVariableLeg"
    /// <summary>
    ///   <para>rdfs:label : return leg</para>
    ///   <para>skos:definition : leg of a swap in which the income generated by some underlier is paid</para>
    ///   <para>cmns-av:explanatoryNote : The return, including income from a tangible asset, the constituents of an index, or a notional/specified amount of some asset (e.g. number of shares, amount of a commodity, etc.), may be limited to the dividend or interest amounts on the underlying (simple return), or total return including capital gains and/or the appreciation or decrease in value of the asset (or index constituents).</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/ReturnLeg">fibo-der-drc-swp:ReturnLeg</a>
    /// </summary>
    let ReturnLeg = _prefixId.prefix "ReturnLeg"
    /// <summary>
    ///   <para>rdfs:label : return swap</para>
    ///   <para>skos:definition : swap in which one leg, the return leg, is based on income generated from some underlier</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/ReturnSwap">fibo-der-drc-swp:ReturnSwap</a>
    /// </summary>
    let ReturnSwap = _prefixId.prefix "ReturnSwap"
    /// <summary>
    ///   <para>rdfs:label : simple return leg</para>
    ///   <para>skos:definition : return leg based strictly on the income generated by the underlying asset, excluding appreciation, decrease in value, capital gains, and fees on any increase in value</para>
    ///   <para>cmns-av:explanatoryNote : Payments may include interest payments on a debt instrument or the dividends on an equity, for example.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SimpleReturnLeg">fibo-der-drc-swp:SimpleReturnLeg</a>
    /// </summary>
    let SimpleReturnLeg = _prefixId.prefix "SimpleReturnLeg"
    /// <summary>
    ///   <para>rdfs:label : statistical swap^^xsd:string</para>
    ///   <para>skos:definition : swap that depends on some statistical measure of the performance of the underlier^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/StatisticalSwap">fibo-der-drc-swp:StatisticalSwap</a>
    /// </summary>
    let StatisticalSwap = _prefixId.prefix "StatisticalSwap"
    /// <summary>
    ///   <para>rdfs:label : strike leg</para>
    ///   <para>skos:definition : swap leg that specifies a fixed amount, 'the strike', quoted at the time of execution</para>
    ///   <para>cmns-av:explanatoryNote : The fixed amount may be with respect to some variable or a monetary amount. The realization of a strike leg is not a cashflow per se, but a netting out against the terms defined in the other leg of a statistical swap.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/StrikeLeg">fibo-der-drc-swp:StrikeLeg</a>
    /// </summary>
    let StrikeLeg = _prefixId.prefix "StrikeLeg"
    /// <summary>
    ///   <para>rdfs:label : swap^^xsd:string</para>
    ///   <para>skos:definition : derivative instrument whereby counterparties agree to exchange periodic streams of cash flows or liabilities from two different financial instruments with each other^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fifth edition, 2021-06-15^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The notional amount, effective date and termination date are some of the properties that each swap leg has that are taken from the swap contract.^^xsd:stringcmns-av:explanatoryNote : The underlying instruments can be almost anything, representing various asset classes, but most swaps involve cash flows (streams of payments or other commitments over time) based on a notional principal amount that both parties agree to.^^xsd:stringcmns-av:explanatoryNote : Usually, the principal does not change hands. Each cash flow comprises one leg of the swap. One cash flow is generally fixed, while the other is variable, that is, based on a a benchmark interest rate, floating currency exchange rate or index price.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/Swap">fibo-der-drc-swp:Swap</a>
    /// </summary>
    let Swap = _prefixId.prefix "Swap"
    /// <summary>
    ///   <para>rdfs:label : swap confirmation^^xsd:string</para>
    ///   <para>skos:definition : formal confirmation that codifies the terms and conditions specific to a lifecycle event with respect to the overall transaction between the parties^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapConfirmation">fibo-der-drc-swp:SwapConfirmation</a>
    /// </summary>
    let SwapConfirmation = _prefixId.prefix "SwapConfirmation"
    /// <summary>
    ///   <para>rdfs:label : swap data repository^^xsd:string</para>
    ///   <para>skos:definition : financial service provider that provides a central facility for swap data reporting and recordkeeping^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : SDR^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.cftc.gov/IndustryOversight/DataRepositories/index.htm^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Swap data repositories ('SDRs') are new entities created by the Dodd-Frank Wall Street Reform and Consumer Protection Act ('Dodd-Frank Act') in order to provide a central facility for swap data reporting and recordkeeping. Under the Dodd- Frank Act, all swaps, whether cleared or uncleared, are required to be reported to registered SDRs. The Dodd-Frank Act added new Section 21 to the Commodity Exchange Act ('CEA'), governing registration and regulation of SDRs and establishing registration requirements and core duties and responsibilities for SDRs.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapDataRepository">fibo-der-drc-swp:SwapDataRepository</a>
    /// </summary>
    let SwapDataRepository = _prefixId.prefix "SwapDataRepository"
    /// <summary>
    ///   <para>rdfs:label : swap dealer^^xsd:string</para>
    ///   <para>skos:definition : non-depository institution such as one that deals in swaps, makes a market in swaps, regularly enters into swaps with counterparties as an ordinary course of business for its own account, and engages in any activity causing the person to be commonly known in the trade as a dealer/market maker in swaps^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : SD^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.cftc.gov/IndustryOversight/Intermediaries/index.htm^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapDealer">fibo-der-drc-swp:SwapDealer</a>
    /// </summary>
    let SwapDealer = _prefixId.prefix "SwapDealer"
    /// <summary>
    ///   <para>rdfs:label : swap leg^^xsd:string</para>
    ///   <para>skos:definition : terms defining and the commitment to fulfill cashflow requirements (e.g., interest payments, coupon payments, etc.) for a component of a swap^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A one-leg financing swap (also known as a single-leg financing swap) is a type of financial derivative, typically used by institutional investors or corporations, in which one party makes a series of fixed or floating payments to another party in exchange for a single upfront cash payment or financing.^^xsd:stringcmns-av:explanatoryNote : A three-leg financial swap is a more complex type of swap agreement where three different payment streams (or 'legs') are involved, as opposed to the traditional two-leg swaps (like fixed-for-floating interest rate swaps). This structure can be useful for sophisticated risk management or hedging strategies, particularly when exposure to multiple interest rates or currencies is desired.^^xsd:stringcmns-av:explanatoryNote : A two-leg financial swap is the most common type of swap agreement, where two counterparties exchange cash flows or obligations based on different financial variables. Each leg represents a stream of payments or flows tied to specific terms, such as fixed or floating interest rates, currencies, or commodities. The classic example of a two-leg swap is the interest rate swap, where one party pays a fixed interest rate while the other pays a floating interest rate.^^xsd:stringcmns-av:explanatoryNote : For some swaps this may be a commitment to net up the difference between a strike and an outcome, rather than to make a series of cashflows over time. For credit default swaps there are conditional commitments, contingent on the occurrence of a credit event.^^xsd:stringcmns-av:explanatoryNote : In most cases, a swap has two legs, one expressing the obligations of the seller and one expressing the obligations of the buyer. However, it is possible to represent more complex swaps, with one, three or more legs. The legs can be almost anything but usually one leg involves cash flows based on a notional principal amount that both parties agree to.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapLeg">fibo-der-drc-swp:SwapLeg</a>
    /// </summary>
    let SwapLeg = _prefixId.prefix "SwapLeg"
    /// <summary>
    ///   <para>rdfs:label : swap leg event^^xsd:string</para>
    ///   <para>skos:definition : swap lifecycle event, such as a payment or rate reset event, that applies to one leg of a swap^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapLegEvent">fibo-der-drc-swp:SwapLegEvent</a>
    /// </summary>
    let SwapLegEvent = _prefixId.prefix "SwapLegEvent"
    /// <summary>
    ///   <para>rdfs:label : swap lifecycle event^^xsd:string</para>
    ///   <para>skos:definition : event that occurs during the lifecycle of a swap, where the overall set of events includes those specific to the issuer, front office, middle office, and/or back office processes^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapLifecycleEvent">fibo-der-drc-swp:SwapLifecycleEvent</a>
    /// </summary>
    let SwapLifecycleEvent = _prefixId.prefix "SwapLifecycleEvent"
    /// <summary>
    ///   <para>rdfs:label : swap lifecycle event identifier^^xsd:string</para>
    ///   <para>skos:definition : identifier that uniquely identifies a specific event in the lifecycle of a swap^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapLifecycleEventIdentifier">fibo-der-drc-swp:SwapLifecycleEventIdentifier</a>
    /// </summary>
    let SwapLifecycleEventIdentifier = _prefixId.prefix "SwapLifecycleEventIdentifier"
    /// <summary>
    ///   <para>rdfs:label : swap party^^xsd:string</para>
    ///   <para>skos:definition : party to a swap and therefore a legal party to the contract that embodies that transaction^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapParty">fibo-der-drc-swp:SwapParty</a>
    /// </summary>
    let SwapParty = _prefixId.prefix "SwapParty"
    /// <summary>
    ///   <para>rdfs:label : swap paying party^^xsd:string</para>
    ///   <para>skos:definition : swap party responsible for making payments for a given leg of the transaction as defined in the contract^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapPayingParty">fibo-der-drc-swp:SwapPayingParty</a>
    /// </summary>
    let SwapPayingParty = _prefixId.prefix "SwapPayingParty"
    /// <summary>
    ///   <para>rdfs:label : swap receiving party^^xsd:string</para>
    ///   <para>skos:definition : swap party that receives payments for a given leg of the transaction as defined in the contract^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapReceivingParty">fibo-der-drc-swp:SwapReceivingParty</a>
    /// </summary>
    let SwapReceivingParty = _prefixId.prefix "SwapReceivingParty"
    /// <summary>
    ///   <para>rdfs:label : swap terms^^xsd:string</para>
    ///   <para>skos:definition : legal contractual terms of a swap transaction^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapTerms">fibo-der-drc-swp:SwapTerms</a>
    /// </summary>
    let SwapTerms = _prefixId.prefix "SwapTerms"
    /// <summary>
    ///   <para>rdfs:label : total return leg</para>
    ///   <para>skos:definition : return leg based on the income generated by the underlying asset as well as any appreciation, decrease in value, capital gains, and fees on any increase in value</para>
    ///   <para>cmns-av:explanatoryNote : This is distinguished from the more general Return Leg by the addition of increase or decrease in the value of the underlying asset.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/TotalReturnLeg">fibo-der-drc-swp:TotalReturnLeg</a>
    /// </summary>
    let TotalReturnLeg = _prefixId.prefix "TotalReturnLeg"
    /// <summary>
    ///   <para>rdfs:label : total return swap</para>
    ///   <para>skos:definition : return swap where the seller agrees to pay the other party the difference in value of some underlying asset multiplied by an agreed-upon notional value should the asset value increase between specified periods of time</para>
    ///   <para>skos:example : For example the parties may enter into a two year agreement where every three months they compare the value of the Barclays Capital Aggregate Bond Index to its value three months previously. If the agreed upon notional was US $10,000,000 and the value increased 0.04%, or 4 basis points (bps), the seller would pay the buyer US $4,000. If, after another three months, the value decreased by 3bps, the buyer would pay the seller US $3,000. As part of the agreement, the buyer may also make an additional payment each period to the seller based on a floating rate index multiplied by the notional value.</para>
    ///   <para>cmns-av:adaptedFrom : CFTC Data Dictionary. See https://www.cftc.gov/MarketReports/SwapsReports/DataDictionary/index.htmcmns-av:adaptedFrom : ISDA Disclosure Annex for Commodity Derivative Transactions. See https://globalmarkets.bnpparibas.com/gm/features/docs/dfdisclosures/ISDA_Commodity_Derivatives_Disclosure_Annex_04_2013.pdf</para>
    ///   <para>cmns-av:explanatoryNote : In a total return swap that is index-based, the change in the level of the index will be equal to the returns generated by the change in price of each of the contracts that comprise the index plus a return based upon interest earned on any cash collateral posted upon the purchase of the contracts comprising the index.cmns-av:explanatoryNote : In exchange, the other party, the buyer of the credit risk, agrees to pay the difference in value of the specified asset multiplied by the notional value should that value decrease between the same specified periods of time. Total return swaps often appear in asset classes other than the credit asset class; however, for the purpose of the CFTC Swaps Report, all total return swaps are counted only in the credit asset class.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/TotalReturnSwap">fibo-der-drc-swp:TotalReturnSwap</a>
    /// </summary>
    let TotalReturnSwap = _prefixId.prefix "TotalReturnSwap"
    /// <summary>
    ///   <para>rdfs:label : unique swap identifier^^xsd:string</para>
    ///   <para>skos:definition : identifier for a swap that is used in recordkeeping and swap data reporting^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : USI^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : CFTC Data Management Branch 'Unique Swap Identifier (USI) Data Standard', October 1, 2012, usidatastandards100112.pdf^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/UniqueSwapIdentifier">fibo-der-drc-swp:UniqueSwapIdentifier</a>
    /// </summary>
    let UniqueSwapIdentifier = _prefixId.prefix "UniqueSwapIdentifier"
    /// <summary>
    ///   <para>rdfs:label : has funding leg</para>
    ///   <para>skos:definition : indicates the leg of a return swap that specifies a set payment rate, typically benchmark based but possibly a fixed rate^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/hasFundingLeg">fibo-der-drc-swp:hasFundingLeg</a>
    /// </summary>
    let hasFundingLeg = _prefixId.prefix "hasFundingLeg"
    /// <summary>
    ///   <para>rdfs:label : has leg^^xsd:string</para>
    ///   <para>skos:definition : relates a swap contract to a leg that is part of that swap^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/hasLeg">fibo-der-drc-swp:hasLeg</a>
    /// </summary>
    let hasLeg = _prefixId.prefix "hasLeg"
    /// <summary>
    ///   <para>rdfs:label : has return leg</para>
    ///   <para>skos:definition : indicates the leg of a return swap whose payments are based on the return of an underlying asset^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/hasReturnLeg">fibo-der-drc-swp:hasReturnLeg</a>
    /// </summary>
    let hasReturnLeg = _prefixId.prefix "hasReturnLeg"
    /// <summary>
    ///   <para>rdfs:label : has swap identifier^^xsd:string</para>
    ///   <para>skos:definition : relates a swap lifecycle event to the identifier for the swap^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/hasSwapIdentifier">fibo-der-drc-swp:hasSwapIdentifier</a>
    /// </summary>
    let hasSwapIdentifier = _prefixId.prefix "hasSwapIdentifier"
    /// <summary>
    ///   <para>rdfs:label : is leg of^^xsd:string</para>
    ///   <para>skos:definition : relates a swap leg to the to the swap that includes it^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/isLegOf">fibo-der-drc-swp:isLegOf</a>
    /// </summary>
    let isLegOf = _prefixId.prefix "isLegOf"
