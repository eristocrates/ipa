#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-der-drc-raw`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/" "fibo-der-drc-raw"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : allotment right</para>
    ///   <para>skos:definition : privileges allotted to existing security holders, entitling them to receive new securities free of charge</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : Allotment generally means the distribution of equity, particularly shares granted to a participating underwriting firm during an initial public offering (IPO).</para>
    ///   <para>cmns-av:synonym : bonus right</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/AllotmentRight">fibo-der-drc-raw:AllotmentRight</a>
    /// </summary>
    let AllotmentRight = _prefixId.prefix "AllotmentRight"
    /// <summary>
    ///   <para>rdfs:label : allotment right formula</para>
    ///   <para>skos:definition : rule applied to calculate the number of securities for an allotment right, typically based on the number of these instruments that the holder holds</para>
    ///   <para>cmns-av:explanatoryNote : Note that there may be a combination of a rule expressed in text as well as an expression or more complex formula embedded in a contract for making this determination.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/AllotmentRightFormula">fibo-der-drc-raw:AllotmentRightFormula</a>
    /// </summary>
    let AllotmentRightFormula = _prefixId.prefix "AllotmentRightFormula"

    /// <summary>
    ///   <para>rdfs:label : barrier instrument-based mini-future certificate</para>
    ///   <para>skos:definition : mini-future certificate that immediately expires if the barrier instrument trading price level is breached during product lifetime</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/BarrierInstrumentBasedMiniFutureCertificate">fibo-der-drc-raw:BarrierInstrumentBasedMiniFutureCertificate</a>
    /// </summary>
    let BarrierInstrumentBasedMiniFutureCertificate =
        _prefixId.prefix "BarrierInstrumentBasedMiniFutureCertificate"

    /// <summary>
    ///   <para>rdfs:label : barrier underlying mini-future certificate</para>
    ///   <para>skos:definition : mini-future certificate that immediately expires if the barrier underlying level is breached during product lifetime</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/BarrierUnderlyingMiniFutureCertificate">fibo-der-drc-raw:BarrierUnderlyingMiniFutureCertificate</a>
    /// </summary>
    let BarrierUnderlyingMiniFutureCertificate =
        _prefixId.prefix "BarrierUnderlyingMiniFutureCertificate"

    /// <summary>
    ///   <para>rdfs:label : basket warrant</para>
    ///   <para>skos:definition : warrant that permits the holder to acquire a package or group of assets at a specified price during a specified period</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/BasketWarrant">fibo-der-drc-raw:BasketWarrant</a>
    /// </summary>
    let BasketWarrant = _prefixId.prefix "BasketWarrant"
    /// <summary>
    ///   <para>rdfs:label : bond purchase right</para>
    ///   <para>skos:definition : purchase right that gives a prospective acquiree's bondholders the right to buy bonds of the firm or bonds of anyone who acquires the firm at a deep discount to their fair market value</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/BondPurchaseRight">fibo-der-drc-raw:BondPurchaseRight</a>
    /// </summary>
    let BondPurchaseRight = _prefixId.prefix "BondPurchaseRight"
    /// <summary>
    ///   <para>rdfs:label : bond subscription right</para>
    ///   <para>skos:definition : subscription right entitling existing bond holders to subscribe to new securities at a price normally lower than the prevailing market price</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/BondSubscriptionRight">fibo-der-drc-raw:BondSubscriptionRight</a>
    /// </summary>
    let BondSubscriptionRight = _prefixId.prefix "BondSubscriptionRight"
    /// <summary>
    ///   <para>rdfs:label : call put warrant</para>
    ///   <para>skos:definition : warrant that either does not specify call or put features, or that explicitly includes both a call and put feature</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019.</para>
    ///   <para>cmns-av:explanatoryNote : The call and put code, 'B', in the CFI stands for 'Both', meaning such a warrant embodies characteristics of both a call and a put. This can appear in structured warrants or exotic warrants where payout may depend on movements in either direction (or give the holder a choice at certain triggers).</para>
    ///   <para>cmns-av:synonym : straddle warrant</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CallPutWarrant">fibo-der-drc-raw:CallPutWarrant</a>
    /// </summary>
    let CallPutWarrant = _prefixId.prefix "CallPutWarrant"
    /// <summary>
    ///   <para>rdfs:label : call warrant</para>
    ///   <para>skos:definition : warrant giving the buyer (holder) the right, but not the obligation, to acquire specific underlying assets during a specified period at a specified price</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019.</para>
    ///   <para>cmns-av:explanatoryNote : Exercising a call warrant whose underlying instrument is an equity involves buying new shares directly from the company, causing dilution.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CallWarrant">fibo-der-drc-raw:CallWarrant</a>
    /// </summary>
    let CallWarrant = _prefixId.prefix "CallWarrant"

    /// <summary>
    ///   <para>rdfs:label : combined instruments purchase right</para>
    ///   <para>skos:definition : purchase right that gives a prospective acquiree's holders of multiple securities the right to buy securities of the firm or securities of anyone who acquires the firm at a deep discount to their fair market value</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CombinedInstrumentsPurchaseRight">fibo-der-drc-raw:CombinedInstrumentsPurchaseRight</a>
    /// </summary>
    let CombinedInstrumentsPurchaseRight =
        _prefixId.prefix "CombinedInstrumentsPurchaseRight"

    /// <summary>
    ///   <para>rdfs:label : combined instruments subscription right</para>
    ///   <para>skos:definition : subscription right entitling existing holders of multiple securities to subscribe to new securities at a price normally lower than the prevailing market price</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CombinedInstrumentsSubscriptionRight">fibo-der-drc-raw:CombinedInstrumentsSubscriptionRight</a>
    /// </summary>
    let CombinedInstrumentsSubscriptionRight =
        _prefixId.prefix "CombinedInstrumentsSubscriptionRight"

    /// <summary>
    ///   <para>rdfs:label : commodity warrant</para>
    ///   <para>skos:definition : warrant that permits the holder to acquire a specified amount of a commodity during a specified period at a specified price</para>
    ///   <para>skos:example : Commodity Warrants Australia (CWA) sells warrants based on 12 commodities and financial markets - crude oil, gold, silver, live cattle, corn, orange juice, soy, coffee, cocoa, the Dow Jones Industrial Average, the NASDAQ Composite Index and the S&amp;P 500 Index.</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CommodityWarrant">fibo-der-drc-raw:CommodityWarrant</a>
    /// </summary>
    let CommodityWarrant = _prefixId.prefix "CommodityWarrant"

    /// <summary>
    ///   <para>rdfs:label : common convertible share purchase right</para>
    ///   <para>skos:definition : purchase right that gives a prospective acquiree's common, convertible shareholders the right to buy common, convertible shares of the firm or common, convertible shares of anyone who acquires the firm at a deep discount to their fair market value</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CommonConvertibleSharePurchaseRight">fibo-der-drc-raw:CommonConvertibleSharePurchaseRight</a>
    /// </summary>
    let CommonConvertibleSharePurchaseRight =
        _prefixId.prefix "CommonConvertibleSharePurchaseRight"

    /// <summary>
    ///   <para>rdfs:label : common convertible share subscription right</para>
    ///   <para>skos:definition : subscription right entitling existing common convertible shareholders to subscribe to new securities at a price normally lower than the prevailing market price</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CommonConvertibleShareSubscriptionRight">fibo-der-drc-raw:CommonConvertibleShareSubscriptionRight</a>
    /// </summary>
    let CommonConvertibleShareSubscriptionRight =
        _prefixId.prefix "CommonConvertibleShareSubscriptionRight"

    /// <summary>
    ///   <para>rdfs:label : common share purchase right</para>
    ///   <para>skos:definition : purchase right that gives a prospective acquiree's common shareholders the right to buy common shares of the firm or common shares of anyone who acquires the firm at a deep discount to their fair market value</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CommonSharePurchaseRight">fibo-der-drc-raw:CommonSharePurchaseRight</a>
    /// </summary>
    let CommonSharePurchaseRight = _prefixId.prefix "CommonSharePurchaseRight"
    /// <summary>
    ///   <para>rdfs:label : common share subscription right</para>
    ///   <para>skos:definition : subscription right entitling existing common shareholders to subscribe to new securities at a price normally lower than the prevailing market price</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CommonShareSubscriptionRight">fibo-der-drc-raw:CommonShareSubscriptionRight</a>
    /// </summary>
    let CommonShareSubscriptionRight = _prefixId.prefix "CommonShareSubscriptionRight"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CompanyWarrant">fibo-der-drc-raw:CompanyWarrant</a>
    /// </summary>
    let CompanyWarrant = _prefixId.prefix "CompanyWarrant"
    /// <summary>
    ///   <para>rdfs:label : constant leverage certificate</para>
    ///   <para>skos:definition : entitlement that combines the structure of an open-end certificate with a leverage option with no fixed term, making leverage available without a term restriction, without a knock-out barrier dependency</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/ConstantLeverageCertificate">fibo-der-drc-raw:ConstantLeverageCertificate</a>
    /// </summary>
    let ConstantLeverageCertificate = _prefixId.prefix "ConstantLeverageCertificate"
    /// <summary>
    ///   <para>rdfs:label : covered warrant</para>
    ///   <para>skos:definition : warrant that gives the holder the right, but not the obligation, to buy (call warrant) or to sell (put warrant) an underlying asset at a specified price (the strike or exercise price) by a predetermined date, issued without an accompanying security by a third party that holds as many securities as would be required if all the warrants are exercised</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : Covered warrants are very similar to options in that they can be created to allow holders to benefit from either rising prices or falling prices, by having both put and call warrants. They can also be created on a wide variety of underlying instruments, not just equities and they are fairly standardised and are mostly traded on exchanges. The main difference is that warrants tend to have longer maturity dates, typically measured in years instead of months (as with options), and are easier to access for individuals as they can be bought and sold in the same way as shares in the stock exchange.cmns-av:explanatoryNote : In contrast to traditional equity warrants, with covered warrants, no new issuance of common stock occurs if the warrant is exercised. The underlying shares of common stock are usually either owned by the issuer of the covered warrants or the issuer has a mechanism, such as owning equity warrants for the underlying shares, through which they can obtain the shares.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CoveredWarrant">fibo-der-drc-raw:CoveredWarrant</a>
    /// </summary>
    let CoveredWarrant = _prefixId.prefix "CoveredWarrant"
    /// <summary>
    ///   <para>rdfs:label : currency warrant</para>
    ///   <para>skos:definition : warrant that permits the holder to acquire a specified amount in a certain currency at a specified exchange rate during a specified period</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CurrencyWarrant">fibo-der-drc-raw:CurrencyWarrant</a>
    /// </summary>
    let CurrencyWarrant = _prefixId.prefix "CurrencyWarrant"
    /// <summary>
    ///   <para>rdfs:label : debt warrant</para>
    ///   <para>skos:definition : warrant that permits the holder to acquire a specified amount of a debt instrument or related debt observable a specified period at a specified price</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/DebtWarrant">fibo-der-drc-raw:DebtWarrant</a>
    /// </summary>
    let DebtWarrant = _prefixId.prefix "DebtWarrant"
    /// <summary>
    ///   <para>rdfs:label : equity warrant</para>
    ///   <para>skos:definition : warrant that permits the holder to acquire a specified amount of an equity instrument during a specified period at a specified price</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : An equity warrant typically enables a buyer to purchase shares of capital stock issued by the corporation whose equity is the underlying asset.</para>
    ///   <para>cmns-av:synonym : company warrant</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/EquityWarrant">fibo-der-drc-raw:EquityWarrant</a>
    /// </summary>
    let EquityWarrant = _prefixId.prefix "EquityWarrant"
    /// <summary>
    ///   <para>rdfs:label : exchange-traded warrant</para>
    ///   <para>skos:definition : warrant that is listed on a securities exchange</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/ExchangeTradedWarrant">fibo-der-drc-raw:ExchangeTradedWarrant</a>
    /// </summary>
    let ExchangeTradedWarrant = _prefixId.prefix "ExchangeTradedWarrant"
    /// <summary>
    ///   <para>rdfs:label : exotic warrant</para>
    ///   <para>skos:definition : warrant that gives the holder the right (but not the obligation) to buy (or sometimes sell) an underlying asset under non-standard or complex conditions, often involving additional features not found in a plain vanilla (standard) warrant</para>
    ///   <para>cmns-av:explanatoryNote : Exotic warrants may be created by investment banks as part of structured products to meet specific investor needs. They are often identified with an 'X' in their English stock short name.cmns-av:explanatoryNote : Features of an exotic warrant may include (1) non-standard payoffs, such as path-dependent or condition-based payouts, (2) variations in the underlying asset(s), which may include equities, indices, currencies, interest rates, baskets of assets, etc., and (3) embedded optionality in terms of features such as barriers, lookbacks, digitals, or dual-currency terms.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/ExoticWarrant">fibo-der-drc-raw:ExoticWarrant</a>
    /// </summary>
    let ExoticWarrant = _prefixId.prefix "ExoticWarrant"
    /// <summary>
    ///   <para>rdfs:label : index warrant</para>
    ///   <para>skos:definition : warrant that permits the holder to acquire a specified amount based on the performance of an index during a specified period at a specified price</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/IndexWarrant">fibo-der-drc-raw:IndexWarrant</a>
    /// </summary>
    let IndexWarrant = _prefixId.prefix "IndexWarrant"
    /// <summary>
    ///   <para>rdfs:label : long mini-future certificate</para>
    ///   <para>skos:definition : mini-future certificate that typically entitles the holder to acquire specific underlying assets during a specified period at a specified price</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/LongMiniFutureCertificate">fibo-der-drc-raw:LongMiniFutureCertificate</a>
    /// </summary>
    let LongMiniFutureCertificate = _prefixId.prefix "LongMiniFutureCertificate"
    /// <summary>
    ///   <para>rdfs:label : mini-future certificate</para>
    ///   <para>skos:definition : entitlement that combines the structure of an open-end certificate with a leverage option with no fixed term, making leverage available without a term restriction, and whose payoff depends on whether or not the underlying asset has reached or exceeded a predetermined price</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : The price of a mini-future always corresponds to its intrinsic value, i.e. the capital outlay, plus the bid-ask spread. The financing costs associated with building up the leverage effect are offset against the capital outlay on a daily basis, thereby eliminating the need for a premium. Investors have to pay only financing costs they actually utilize. In contrast to options, factors like volatility have no influence at all on the price of mini-futures.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/MiniFutureCertificate">fibo-der-drc-raw:MiniFutureCertificate</a>
    /// </summary>
    let MiniFutureCertificate = _prefixId.prefix "MiniFutureCertificate"
    /// <summary>
    ///   <para>rdfs:label : naked warrant</para>
    ///   <para>skos:definition : warrant that gives the holder the right, but not the obligation, to buy (call warrant) or to sell (put warrant) an underlying asset at a specified price (the strike or exercise price) by a predetermined date, issued without an accompanying security by a third party that does not hold as many securities as would be required if all the warrants are exercised</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/NakedWarrant">fibo-der-drc-raw:NakedWarrant</a>
    /// </summary>
    let NakedWarrant = _prefixId.prefix "NakedWarrant"
    /// <summary>
    ///   <para>rdfs:label : perpetual warrant^^xsd:string</para>
    ///   <para>skos:definition : warrant without an expiration date, giving the holder the right, but not the obligation, to buy (call warrant) or to sell (put warrant) an underlying asset at a certain strike price^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : The strike price, in the case of a perpetual warrant, is usually higher than the market value of the underlying asset at the time of issue.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PerpetualWarrant">fibo-der-drc-raw:PerpetualWarrant</a>
    /// </summary>
    let PerpetualWarrant = _prefixId.prefix "PerpetualWarrant"

    /// <summary>
    ///   <para>rdfs:label : preferred convertible share purchase right</para>
    ///   <para>skos:definition : purchase right that gives a prospective acquiree's preferred, convertible shareholders the right to buy preferred, convertible shares of the firm or preferred, convertible shares of anyone who acquires the firm at a deep discount to their fair market value</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PreferredConvertibleSharePurchaseRight">fibo-der-drc-raw:PreferredConvertibleSharePurchaseRight</a>
    /// </summary>
    let PreferredConvertibleSharePurchaseRight =
        _prefixId.prefix "PreferredConvertibleSharePurchaseRight"

    /// <summary>
    ///   <para>rdfs:label : preferred convertible share subscription right</para>
    ///   <para>skos:definition : subscription right entitling existing preferred, convertible shareholders to subscribe to new securities at a price normally lower than the prevailing market price</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PreferredConvertibleShareSubscriptionRight">fibo-der-drc-raw:PreferredConvertibleShareSubscriptionRight</a>
    /// </summary>
    let PreferredConvertibleShareSubscriptionRight =
        _prefixId.prefix "PreferredConvertibleShareSubscriptionRight"

    /// <summary>
    ///   <para>rdfs:label : preferred share purchase right</para>
    ///   <para>skos:definition : purchase right that gives a prospective acquiree's preferred shareholders the right to buy preferred shares of the firm or preferred shares of anyone who acquires the firm at a deep discount to their fair market value</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PreferredSharePurchaseRight">fibo-der-drc-raw:PreferredSharePurchaseRight</a>
    /// </summary>
    let PreferredSharePurchaseRight = _prefixId.prefix "PreferredSharePurchaseRight"

    /// <summary>
    ///   <para>rdfs:label : preferred share subscription right</para>
    ///   <para>skos:definition : subscription right entitling existing preferred shareholders to subscribe to new securities at a price normally lower than the prevailing market price</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PreferredShareSubscriptionRight">fibo-der-drc-raw:PreferredShareSubscriptionRight</a>
    /// </summary>
    let PreferredShareSubscriptionRight =
        _prefixId.prefix "PreferredShareSubscriptionRight"

    /// <summary>
    ///   <para>rdfs:label : private warrant^^xsd:string</para>
    ///   <para>skos:definition : warrant that is not tradable^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PrivateWarrant">fibo-der-drc-raw:PrivateWarrant</a>
    /// </summary>
    let PrivateWarrant = _prefixId.prefix "PrivateWarrant"
    /// <summary>
    ///   <para>rdfs:label : public warrant^^xsd:string</para>
    ///   <para>skos:definition : warrant that may be traded over the counter (OTC) or through an exchange^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PublicWarrant">fibo-der-drc-raw:PublicWarrant</a>
    /// </summary>
    let PublicWarrant = _prefixId.prefix "PublicWarrant"
    /// <summary>
    ///   <para>rdfs:label : purchase right</para>
    ///   <para>skos:definition : anti-takeover device that gives a prospective acquiree's shareholders the right to buy shares of the firm or shares of anyone who acquires the firm at a deep discount to their fair market value</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : The underlying is usually shares but this not necessarily the case. Also known as "Poison Pill".</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PurchaseRight">fibo-der-drc-raw:PurchaseRight</a>
    /// </summary>
    let PurchaseRight = _prefixId.prefix "PurchaseRight"
    /// <summary>
    ///   <para>rdfs:label : put warrant</para>
    ///   <para>skos:definition : warrant giving the buyer (holder) the right, but not the obligation, to sell the assets specified (i.e., acquire cash in exchange for the underlying assets, such as stock) back to the issuer at a fixed price or formula, on or before a specified date</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019.</para>
    ///   <para>cmns-av:explanatoryNote : A put warrant is essentially a company-issued option to sell shares back to the issuer.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PutWarrant">fibo-der-drc-raw:PutWarrant</a>
    /// </summary>
    let PutWarrant = _prefixId.prefix "PutWarrant"
    /// <summary>
    ///   <para>rdfs:label : short mini-future certificate</para>
    ///   <para>skos:definition : mini-future certificate that entitles the holder to acquire cash in exchange for specific underlying assets</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/ShortMiniFutureCertificate">fibo-der-drc-raw:ShortMiniFutureCertificate</a>
    /// </summary>
    let ShortMiniFutureCertificate = _prefixId.prefix "ShortMiniFutureCertificate"
    /// <summary>
    ///   <para>rdfs:label : structured warrant</para>
    ///   <para>skos:definition : warrant that is listed on an exchange, offering investors a way to participate in the price performance of an underlying asset without buying it directly</para>
    ///   <para>cmns-av:explanatoryNote : Unlike company-issued warrants, which are tied to corporate fundraising, structured warrants are issued by third-party financial institutions such as investment banks or brokers. They can be based on a variety of underlying assets, including individual company shares, a basket of shares, or an index.cmns-av:explanatoryNote : When structured warrants are exercised, they are typically cash-settled and do not lead to the creation of new shares, thus avoiding dilution of existing shareholders. This is in contrast with company-issued stock options, which can potentially lead to the issuance of new shares, which might dilute the value for existing shareholders.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/StructuredWarrant">fibo-der-drc-raw:StructuredWarrant</a>
    /// </summary>
    let StructuredWarrant = _prefixId.prefix "StructuredWarrant"
    /// <summary>
    ///   <para>rdfs:label : subscription right</para>
    ///   <para>skos:definition : privileges allotted to existing security holders, entitling them to subscribe to new securities at a price normally lower than the prevailing market price</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : A subscription rights issue increases the number of shares in the market, thus leading to a dilution in each share's value.</para>
    ///   <para>cmns-av:synonym : anti-dilution rightcmns-av:synonym : preemptive rightcmns-av:synonym : subscription privilege</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/SubscriptionRight">fibo-der-drc-raw:SubscriptionRight</a>
    /// </summary>
    let SubscriptionRight = _prefixId.prefix "SubscriptionRight"
    /// <summary>
    ///   <para>rdfs:label : traditional warrant</para>
    ///   <para>skos:definition : warrant that gives the holder the right, but not the obligation, to buy (call warrant) or to sell (put warrant) an underlying asset at a specified price (the strike or exercise price) by a predetermined date, issued by the issuer of the underlying instrument</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <para>cmns-av:synonym : vanilla warrant</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/TraditionalWarrant">fibo-der-drc-raw:TraditionalWarrant</a>
    /// </summary>
    let TraditionalWarrant = _prefixId.prefix "TraditionalWarrant"
    /// <summary>
    ///   <para>rdfs:label : warrant</para>
    ///   <para>skos:definition : entitlement that permits the holder to purchase a specified amount of a financial instrument, commodity, currency or other asset during a specified period at a specified price</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : Warrants are for any kind of instrument. Warrants may be privately issued and may not necessarily be traded on an exchange.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/Warrant">fibo-der-drc-raw:Warrant</a>
    /// </summary>
    let Warrant = _prefixId.prefix "Warrant"
    /// <summary>
    ///   <para>rdfs:label : has conversion ratio</para>
    ///   <para>skos:definition : indicates the factor used to determine the number of warrants needed in order to buy or sell a specific number of securities or investment units</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/hasConversionRatio">fibo-der-drc-raw:hasConversionRatio</a>
    /// </summary>
    let hasConversionRatio = _prefixId.prefix "hasConversionRatio"
    /// <summary>
    ///   <para>rdfs:label : has oversubscribe option</para>
    ///   <para>skos:definition : indicates whether the holders of the rights instrument may get securities in the event that other right holders choose not to subscribe</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/hasOversubscribeOption">fibo-der-drc-raw:hasOversubscribeOption</a>
    /// </summary>
    let hasOversubscribeOption = _prefixId.prefix "hasOversubscribeOption"
