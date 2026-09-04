#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-der-drc-ff`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/" "fibo-der-drc-ff"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : basket future</para>
    ///   <para>skos:definition : futures contract whose underlying asset is a basket of securities and/or indices</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/BasketFuture">fibo-der-drc-ff:BasketFuture</a>
    /// </summary>
    let BasketFuture = _prefixId.prefix "BasketFuture"
    /// <summary>
    ///   <para>rdfs:label : bond future</para>
    ///   <para>skos:definition : futures contract whose underlying asset is at least one bond</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/BondFuture">fibo-der-drc-ff:BondFuture</a>
    /// </summary>
    let BondFuture = _prefixId.prefix "BondFuture"
    /// <summary>
    ///   <para>rdfs:label : currency future</para>
    ///   <para>skos:definition : futures contract whose underlying asset is an agreement to exchange a specified amount of one currency for another at some point in the future based on pricing stated in the contract</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <para>cmns-av:synonym : foreign exchange futurecmns-av:synonym : forex future</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/CurrencyFuture">fibo-der-drc-ff:CurrencyFuture</a>
    /// </summary>
    let CurrencyFuture = _prefixId.prefix "CurrencyFuture"
    /// <summary>
    ///   <para>rdfs:label : debt instrument future</para>
    ///   <para>skos:definition : futures contract whose underlying asset is at least one debt instrument</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/DebtInstrumentFuture">fibo-der-drc-ff:DebtInstrumentFuture</a>
    /// </summary>
    let DebtInstrumentFuture = _prefixId.prefix "DebtInstrumentFuture"
    /// <summary>
    ///   <para>rdfs:label : dividend adjustment period</para>
    ///   <para>skos:definition : date period used to calculate the difference, if any between an anticipated dividend and the actual dividend distributed in that period</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/DividendAdjustmentPeriod">fibo-der-drc-ff:DividendAdjustmentPeriod</a>
    /// </summary>
    let DividendAdjustmentPeriod = _prefixId.prefix "DividendAdjustmentPeriod"
    /// <summary>
    ///   <para>rdfs:label : dividend future</para>
    ///   <para>skos:definition : futures contract whose underlying asset is at least one stock dividend</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/DividendFuture">fibo-der-drc-ff:DividendFuture</a>
    /// </summary>
    let DividendFuture = _prefixId.prefix "DividendFuture"
    /// <summary>
    ///   <para>rdfs:label : equity forward</para>
    ///   <para>skos:definition : forward contract to buy or sell the underlying equity stock, equity index, basket of equity stock, equity futures contract, or equity option at a specified future date at the price specified at the outset of the contract</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/EquityForward">fibo-der-drc-ff:EquityForward</a>
    /// </summary>
    let EquityForward = _prefixId.prefix "EquityForward"
    /// <summary>
    ///   <para>rdfs:label : equity future</para>
    ///   <para>skos:definition : futures contract whose underlying asset is at least one equity security, specifically a publicly issued and traded share</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/EquityFuture">fibo-der-drc-ff:EquityFuture</a>
    /// </summary>
    let EquityFuture = _prefixId.prefix "EquityFuture"
    /// <summary>
    ///   <para>rdfs:label : financial future</para>
    ///   <para>skos:definition : futures contract based on underlying assets excluding commodities</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/FinancialFuture">fibo-der-drc-ff:FinancialFuture</a>
    /// </summary>
    let FinancialFuture = _prefixId.prefix "FinancialFuture"
    /// <summary>
    ///   <para>rdfs:label : forward</para>
    ///   <para>skos:definition : derivative instrument that is privately negotiated between parties to buy the underlier at a specified future date at the price specified in the contract</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : Certain contracts labeled 'forwards', such as London Metal Exchange (LME) Forwards, are actually futures and are exchange-traded. Some power and gas markets, such as Nord Pool, trade electricity forwards with clearinghouse support. Per the ontology, both would be classified as futures by definition, but naming blurs the lines.cmns-av:explanatoryNote : Since forward contracts are not exchange traded, there is no mark-to-market requirement, which allows a buyer to avoid almost all capital outflow initially (though some counterparties might set collateral requirements). The forward price makes the forward contract have no value when the contract is written. However, if the value of the underlying commodity changes, the value of the forward contract becomes positive or negative, depending on the position held. Forwards are priced in a manner similar to futures. Like in the case of a futures contract, the first step in pricing a forward is to add the spot price to the cost of carry (interest forgone, convenience yield, storage costs and interest/dividend received on the underlying). Unlike a futures contract though, the price may also include a premium for counterparty credit risk, and the fact that there is not daily marking to market process to minimize default risk. If there is no allowance for these credit risks, then the forward price will equal the futures price.cmns-av:explanatoryNote : The primary distinctions between futures and forwards are (1) forwards are bilateral and privately negotiated, (2) forwards are over-the-counter instruments rather than exchange traded, (3) forwards are fully customizable whereas futures are typically standardized, (4) the risk associated with a forward is assumed by the counterparties whereas it is mitigated via central clearing for futures, and (5) there is typically no margin requirement for a forward whereas futures require margin posting.</para>
    ///   <para>cmns-av:synonym : forward contract</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/Forward">fibo-der-drc-ff:Forward</a>
    /// </summary>
    let Forward = _prefixId.prefix "Forward"

    /// <summary>
    ///   <para>rdfs:label : forward contract adjustment method</para>
    ///   <para>skos:definition : method by which adjustments will be made to the contract should one or more of a number of extraordinary events occur</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/ForwardContractAdjustmentMethod">fibo-der-drc-ff:ForwardContractAdjustmentMethod</a>
    /// </summary>
    let ForwardContractAdjustmentMethod =
        _prefixId.prefix "ForwardContractAdjustmentMethod"

    /// <summary>
    ///   <para>rdfs:label : future on future</para>
    ///   <para>skos:definition : futures contract whose underlying asset is at least one (other) futures contract</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/FutureOnFuture">fibo-der-drc-ff:FutureOnFuture</a>
    /// </summary>
    let FutureOnFuture = _prefixId.prefix "FutureOnFuture"
    /// <summary>
    ///   <para>rdfs:label : future on option</para>
    ///   <para>skos:definition : futures contract whose underlying asset is at least one option contract</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/FutureOnOption">fibo-der-drc-ff:FutureOnOption</a>
    /// </summary>
    let FutureOnOption = _prefixId.prefix "FutureOnOption"
    /// <summary>
    ///   <para>rdfs:label : future on swap</para>
    ///   <para>skos:definition : futures contract whose underlying asset is at least one swap contract</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/FutureOnSwap">fibo-der-drc-ff:FutureOnSwap</a>
    /// </summary>
    let FutureOnSwap = _prefixId.prefix "FutureOnSwap"
    /// <summary>
    ///   <para>rdfs:label : index future</para>
    ///   <para>skos:definition : futures contract whose underlying asset is at least one reference index or economic indicator</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : For each index there may be a different multiple for determining the price of the futures contract.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/IndexFuture">fibo-der-drc-ff:IndexFuture</a>
    /// </summary>
    let IndexFuture = _prefixId.prefix "IndexFuture"
    /// <summary>
    ///   <para>rdfs:label : interest rate future</para>
    ///   <para>skos:definition : futures contract with an interest-bearing instrument as the underlying asset</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : Most interest rate futures that trade on American exchanges use U.S. Treasury securities, such as Treasury bills, Treasury bonds, certificates of deposit, Treasury notes, and Ginnie Mae securities, as the underlying asset.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/InterestRateFuture">fibo-der-drc-ff:InterestRateFuture</a>
    /// </summary>
    let InterestRateFuture = _prefixId.prefix "InterestRateFuture"
    /// <summary>
    ///   <para>rdfs:label : money market future</para>
    ///   <para>skos:definition : futures contract with a money market instrument as the underlying asset</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/MoneyMarketFuture">fibo-der-drc-ff:MoneyMarketFuture</a>
    /// </summary>
    let MoneyMarketFuture = _prefixId.prefix "MoneyMarketFuture"

    /// <summary>
    ///   <para>rdfs:label : standardized futures listing terms</para>
    ///   <para>skos:definition : contract terms established by a derivatives exchange that apply to any listing of a futures contract on that exchange.</para>
    ///   <para>cmns-av:explanatoryNote : Individual listings will take on these standard terms but they are not contractual terms of the futures contract, they are facts about that listing on that exchange.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/StandardizedFuturesListingTerms">fibo-der-drc-ff:StandardizedFuturesListingTerms</a>
    /// </summary>
    let StandardizedFuturesListingTerms =
        _prefixId.prefix "StandardizedFuturesListingTerms"

    /// <summary>
    ///   <para>rdfs:label : standardized futures terms</para>
    ///   <para>skos:definition : contract terms established by a derivatives exchange that apply to any futures contract traded on that exchange</para>
    ///   <para>cmns-av:explanatoryNote : Standard symbology for the commodities are standardized by the exchanges as part of their standard contracts, for example trading in standard bushels, commonly defined kinds of oil and so on. These give the units in which lot sizes are described and defined.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/StandardizedFuturesTerms">fibo-der-drc-ff:StandardizedFuturesTerms</a>
    /// </summary>
    let StandardizedFuturesTerms = _prefixId.prefix "StandardizedFuturesTerms"
    /// <summary>
    ///   <para>rdfs:label : has conversion factor</para>
    ///   <para>skos:definition : indicates the price of the delivered bond/note ($1 par value) to yield a fixed rate. The conversion factor is used to calculate a final delivery price.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/hasConversionFactor">fibo-der-drc-ff:hasConversionFactor</a>
    /// </summary>
    let hasConversionFactor = _prefixId.prefix "hasConversionFactor"
    /// <summary>
    ///   <para>rdfs:label : has dividend adjustment period</para>
    ///   <para>skos:definition : indicates at least one date period used to calculate the deviation between an anticipated/expected dividend and the actual dividend issued during that period</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/hasDividendAdjustmentPeriod">fibo-der-drc-ff:hasDividendAdjustmentPeriod</a>
    /// </summary>
    let hasDividendAdjustmentPeriod = _prefixId.prefix "hasDividendAdjustmentPeriod"
    /// <summary>
    ///   <para>rdfs:label : has method of adjustment</para>
    ///   <para>skos:definition : indicates the method used to address any changes to the contract based on events that occur over the contract lifecycle</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/hasMethodOfAdjustment">fibo-der-drc-ff:hasMethodOfAdjustment</a>
    /// </summary>
    let hasMethodOfAdjustment = _prefixId.prefix "hasMethodOfAdjustment"
    /// <summary>
    ///   <para>rdfs:label : has multiple</para>
    ///   <para>skos:definition : indicates the multiple for determining the price of the futures contract in relation to the underlying index rate</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/hasMultiple">fibo-der-drc-ff:hasMultiple</a>
    /// </summary>
    let hasMultiple = _prefixId.prefix "hasMultiple"
