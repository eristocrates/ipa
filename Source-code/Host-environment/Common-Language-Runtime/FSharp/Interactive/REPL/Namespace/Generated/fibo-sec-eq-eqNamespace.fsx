#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-eq-eq`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/" "fibo-sec-eq-eq"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : adjustable rate dividend^^xsd:string</para>
    ///   <para>skos:definition : dividend that varies with a benchmark^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The value of the dividend from the preferred share is set by a predetermined formula to move with rates, and because of this flexibility preferred prices are often more stable then fixed-rate preferred stocks.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/AdjustableRateDividend">fibo-sec-eq-eq:AdjustableRateDividend</a>
    /// </summary>
    let AdjustableRateDividend = _prefixId.prefix "AdjustableRateDividend"
    /// <summary>
    ///   <para>rdfs:label : auction rate dividend^^xsd:string</para>
    ///   <para>skos:definition : preferred share dividend whose rate is periodically reset through an auction, typically every 7, 14, 28, or 35 days^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/AuctionRateDividend">fibo-sec-eq-eq:AuctionRateDividend</a>
    /// </summary>
    let AuctionRateDividend = _prefixId.prefix "AuctionRateDividend"
    /// <summary>
    ///   <para>rdfs:label : common share</para>
    ///   <para>skos:definition : share that signifies a unit of ownership in a corporation and represents a claim on part of the corporation's assets and earnings^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In the event that the corporation is liquidated, claims of secured and unsecured creditors and owners of bonds and preferred shares take precedence over claims of common share holders.^^xsd:string</para>
    ///   <para>cmns-av:synonym : ordinary share</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/CommonShare">fibo-sec-eq-eq:CommonShare</a>
    /// </summary>
    let CommonShare = _prefixId.prefix "CommonShare"
    /// <summary>
    ///   <para>rdfs:label : convertible common share^^xsd:string</para>
    ///   <para>skos:definition : common share that is convertible into another security^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ConvertibleCommonShare">fibo-sec-eq-eq:ConvertibleCommonShare</a>
    /// </summary>
    let ConvertibleCommonShare = _prefixId.prefix "ConvertibleCommonShare"
    /// <summary>
    ///   <para>rdfs:label : convertible preferred share^^xsd:string</para>
    ///   <para>skos:definition : preferred share that includes an option for the holder to convert the shares into a fixed number of common shares after a predetermined date^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Most convertible preferred stock is exchanged at the request of the shareholder, but sometimes there is a provision that allows the company, or issuer, to force conversion. The value of a convertible preferred stock is ultimately based on the performance of the common stock.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ConvertiblePreferredShare">fibo-sec-eq-eq:ConvertiblePreferredShare</a>
    /// </summary>
    let ConvertiblePreferredShare = _prefixId.prefix "ConvertiblePreferredShare"
    /// <summary>
    ///   <para>rdfs:label : cumulative preferred share^^xsd:string</para>
    ///   <para>skos:definition : preferred share whose dividends, if not paid on time, accumulate until paid out^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : These dividends have precedence over ordinary dividends which cannot be paid until any cumulative dividend obligations have been paid. Dividends are typically deferred due to insufficient earnings or other business reasons.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/CumulativePreferredShare">fibo-sec-eq-eq:CumulativePreferredShare</a>
    /// </summary>
    let CumulativePreferredShare = _prefixId.prefix "CumulativePreferredShare"
    /// <summary>
    ///   <para>rdfs:label : custodian^^xsd:string</para>
    ///   <para>skos:definition : financial institution that holds customers' securities for safekeeping</para>
    ///   <para>cmns-av:adaptedFrom : https://www.investopedia.com/terms/c/custodian.asp^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : The custodian may hold stocks or other assets in electronic or physical form for mutual funds, individuals, and organizational clients.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/Custodian">fibo-sec-eq-eq:Custodian</a>
    /// </summary>
    let Custodian = _prefixId.prefix "Custodian"
    let DistributionByCashPayment = _prefixId.prefix "DistributionByCashPayment"
    let DistributionByReinvestment = _prefixId.prefix "DistributionByReinvestment"
    /// <summary>
    ///   <para>rdfs:label : dividend^^xsd:string</para>
    ///   <para>skos:definition : announced commitment to make a specific distribution of a portion of earnings to shareholders, prorated by class of security^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The amount and timing of payment is set by the board of directors, typically quarterly. Dividends may be paid in the form of money, shares, scrip, or on rare occasion, property.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/Dividend">fibo-sec-eq-eq:Dividend</a>
    /// </summary>
    let Dividend = _prefixId.prefix "Dividend"
    /// <summary>
    ///   <para>rdfs:label : dividend distribution method^^xsd:string</para>
    ///   <para>skos:definition : convention by which dividends are provided to shareholders^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Distribution may be by payment of a monetary amount or by reinvestment, as specified by the board of directors at the time a decision to issue a dividend is made.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/DividendDistributionMethod">fibo-sec-eq-eq:DividendDistributionMethod</a>
    /// </summary>
    let DividendDistributionMethod = _prefixId.prefix "DividendDistributionMethod"
    /// <summary>
    ///   <para>rdfs:label : dividend schedule^^xsd:string</para>
    ///   <para>skos:definition : payment schedule indicating the dates on which dividends are due to be paid^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/DividendSchedule">fibo-sec-eq-eq:DividendSchedule</a>
    /// </summary>
    let DividendSchedule = _prefixId.prefix "DividendSchedule"
    /// <summary>
    ///   <para>rdfs:label : enhanced voting share</para>
    ///   <para>skos:definition : share that confers more than one vote per share</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EnhancedVotingShare">fibo-sec-eq-eq:EnhancedVotingShare</a>
    /// </summary>
    let EnhancedVotingShare = _prefixId.prefix "EnhancedVotingShare"
    /// <summary>
    ///   <para>rdfs:label : equity conversion terms^^xsd:string</para>
    ///   <para>skos:definition : conversion terms specifying the details regarding conversion of shares into other securities^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EquityConversionTerms">fibo-sec-eq-eq:EquityConversionTerms</a>
    /// </summary>
    let EquityConversionTerms = _prefixId.prefix "EquityConversionTerms"
    /// <summary>
    ///   <para>rdfs:label : equity position</para>
    ///   <para>skos:definition : position in an equity instrument</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EquityPosition">fibo-sec-eq-eq:EquityPosition</a>
    /// </summary>
    let EquityPosition = _prefixId.prefix "EquityPosition"
    /// <summary>
    ///   <para>rdfs:label : equity redemption provision</para>
    ///   <para>skos:definition : redemption provision that specifies the conditions under which the issuer or shareholder may redeem the shares</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EquityRedemptionProvision">fibo-sec-eq-eq:EquityRedemptionProvision</a>
    /// </summary>
    let EquityRedemptionProvision = _prefixId.prefix "EquityRedemptionProvision"

    /// <summary>
    ///   <para>rdfs:label : equity redemption provision with extendable redemption date</para>
    ///   <para>skos:definition : equity redemption provision that allows modification of the redemption date beyond the original specified date</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/EquityRedemptionProvisionWithExtendableRedemptionDate">fibo-sec-eq-eq:EquityRedemptionProvisionWithExtendableRedemptionDate</a>
    /// </summary>
    let EquityRedemptionProvisionWithExtendableRedemptionDate =
        _prefixId.prefix "EquityRedemptionProvisionWithExtendableRedemptionDate"

    /// <summary>
    ///   <para>rdfs:label : exchangeable preferred share^^xsd:string</para>
    ///   <para>skos:definition : preferred share that may be exchanged for a security of another issuer^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ExchangeablePreferredShare">fibo-sec-eq-eq:ExchangeablePreferredShare</a>
    /// </summary>
    let ExchangeablePreferredShare = _prefixId.prefix "ExchangeablePreferredShare"
    /// <summary>
    ///   <para>rdfs:label : extendable preferred share^^xsd:string</para>
    ///   <para>skos:definition : preferred share whose redemption date can be extended at the issuer or holder option^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : An extendable preferred share may be redeemed at the option of the issuer and/or of the shareholder with an extendable redemption (meturity) date.^^xsd:string</para>
    ///   <para>cmns-av:synonym : extendible preferred share^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ExtendablePreferredShare">fibo-sec-eq-eq:ExtendablePreferredShare</a>
    /// </summary>
    let ExtendablePreferredShare = _prefixId.prefix "ExtendablePreferredShare"
    /// <summary>
    ///   <para>rdfs:label : fixed rate dividend^^xsd:string</para>
    ///   <para>skos:definition : dividend that provides a specified annual return on the nominal value (and any premium) paid on shares^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In other words, the return is not variable depending on whether or not the company makes a profit. Annual dividends are calculated as a percentage of the par value, which is the price of the preferred stock at the time it was issued. Most preferred shares have fixed rate dividends.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/FixedRateDividend">fibo-sec-eq-eq:FixedRateDividend</a>
    /// </summary>
    let FixedRateDividend = _prefixId.prefix "FixedRateDividend"
    /// <summary>
    ///   <para>rdfs:label : fully paid share</para>
    ///   <para>skos:definition : share whose payment status indicates that no additional money is owed to the company by shareholders on the value of the shares</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/FullyPaidShare">fibo-sec-eq-eq:FullyPaidShare</a>
    /// </summary>
    let FullyPaidShare = _prefixId.prefix "FullyPaidShare"
    let FullyPaidShareStatus = _prefixId.prefix "FullyPaidShareStatus"
    /// <summary>
    ///   <para>rdfs:label : hard retractable preferred share^^xsd:string</para>
    ///   <para>skos:definition : retractable preferred share whose retraction value must be paid in cash^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/HardRetractablePreferredShare">fibo-sec-eq-eq:HardRetractablePreferredShare</a>
    /// </summary>
    let HardRetractablePreferredShare = _prefixId.prefix "HardRetractablePreferredShare"
    /// <summary>
    ///   <para>rdfs:label : limited partnership unit</para>
    ///   <para>skos:definition : share in a form of partnership similar to a general partnership, except that in addition to one or more general partners (GPs), there are one or more limited partners (LPs)</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : Like shareholders in a corporation, the LPs have limited liability, i.e., they are only liable on debts incurred by the firm to the extent of their registered investment and they have no management authority. The GPs pay the LPs the equivalent of a dividend on their investment, the nature and extent of which is usually defined in the partnership agreement.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/LimitedPartnershipUnit">fibo-sec-eq-eq:LimitedPartnershipUnit</a>
    /// </summary>
    let LimitedPartnershipUnit = _prefixId.prefix "LimitedPartnershipUnit"
    /// <summary>
    ///   <para>rdfs:label : listed share</para>
    ///   <para>skos:definition : share that is listed on at least one platform</para>
    ///   <para>cmns-av:explanatoryNote : Listing requirements vary by exchange and include minimum stockholder's equity, a minimum share price and a minimum number of shareholders. Exchanges have listing requirements to ensure that only high quality securities are traded on them and to uphold the exchange's reputation among investors.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ListedShare">fibo-sec-eq-eq:ListedShare</a>
    /// </summary>
    let ListedShare = _prefixId.prefix "ListedShare"
    /// <summary>
    ///   <para>rdfs:label : nil paid share</para>
    ///   <para>skos:definition : share whose payment status indicates that none of the market value has been received by the company for the shares</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NilPaidShare">fibo-sec-eq-eq:NilPaidShare</a>
    /// </summary>
    let NilPaidShare = _prefixId.prefix "NilPaidShare"
    let NilPaidShareStatus = _prefixId.prefix "NilPaidShareStatus"
    /// <summary>
    ///   <para>rdfs:label : non-cumulative preferred share^^xsd:string</para>
    ///   <para>skos:definition : preferred share whose dividend payments are not carried forward^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NonCumulativePreferredShare">fibo-sec-eq-eq:NonCumulativePreferredShare</a>
    /// </summary>
    let NonCumulativePreferredShare = _prefixId.prefix "NonCumulativePreferredShare"

    /// <summary>
    ///   <para>rdfs:label : non-participating preferred share^^xsd:string</para>
    ///   <para>skos:definition : preferred share that is not a participating preferred share^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NonParticipatingPreferredShare">fibo-sec-eq-eq:NonParticipatingPreferredShare</a>
    /// </summary>
    let NonParticipatingPreferredShare =
        _prefixId.prefix "NonParticipatingPreferredShare"

    /// <summary>
    ///   <para>rdfs:label : non-voting share</para>
    ///   <para>skos:definition : share that has no voting right</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/NonVotingShare">fibo-sec-eq-eq:NonVotingShare</a>
    /// </summary>
    let NonVotingShare = _prefixId.prefix "NonVotingShare"
    /// <summary>
    ///   <para>rdfs:label : ordinary dividend^^xsd:string</para>
    ///   <para>skos:definition : dividend that is paid to shareholders periodically^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Most dividends are considered ordinary, unless they are specifically designated as qualified dividends.^^xsd:stringcmns-av:explanatoryNote : Note that the terms related to ordinary dividend payment are typically specified in the context of a board resolution rather than contractually.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/OrdinaryDividend">fibo-sec-eq-eq:OrdinaryDividend</a>
    /// </summary>
    let OrdinaryDividend = _prefixId.prefix "OrdinaryDividend"
    /// <summary>
    ///   <para>rdfs:label : partially paid share</para>
    ///   <para>skos:definition : share whose payment status indicates that only a portion of the market value has been received by the company for the shares</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PartiallyPaidShare">fibo-sec-eq-eq:PartiallyPaidShare</a>
    /// </summary>
    let PartiallyPaidShare = _prefixId.prefix "PartiallyPaidShare"
    let PartiallyPaidShareStatus = _prefixId.prefix "PartiallyPaidShareStatus"
    /// <summary>
    ///   <para>rdfs:label : participating preferred share^^xsd:string</para>
    ///   <para>skos:definition : preferred share that, in addition to paying a stipulated dividend, gives the holder the right to participate with common share holders in additional distributions of earnings under specified conditions^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Participating preferred shares are rare, typically only issued when needed to attract investors.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ParticipatingPreferredShare">fibo-sec-eq-eq:ParticipatingPreferredShare</a>
    /// </summary>
    let ParticipatingPreferredShare = _prefixId.prefix "ParticipatingPreferredShare"
    /// <summary>
    ///   <para>rdfs:label : perpetual preferred share^^xsd:string</para>
    ///   <para>skos:definition : preferred share that has no fixed maturity date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PerpetualPreferredShare">fibo-sec-eq-eq:PerpetualPreferredShare</a>
    /// </summary>
    let PerpetualPreferredShare = _prefixId.prefix "PerpetualPreferredShare"
    /// <summary>
    ///   <para>rdfs:label : precedence right^^xsd:string</para>
    ///   <para>skos:definition : right that give the shareholder higher priority with respect to certain pre-defined dividend payments over other shareholders and that pay out first in the case of liquidation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PrecedenceRight">fibo-sec-eq-eq:PrecedenceRight</a>
    /// </summary>
    let PrecedenceRight = _prefixId.prefix "PrecedenceRight"
    /// <summary>
    ///   <para>rdfs:label : preferred dividend^^xsd:string</para>
    ///   <para>skos:definition : commitment to distribute a portion of earnings to shareholders, similar to a dividend but often with a fixed payment amount and schedule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredDividend">fibo-sec-eq-eq:PreferredDividend</a>
    /// </summary>
    let PreferredDividend = _prefixId.prefix "PreferredDividend"
    /// <summary>
    ///   <para>rdfs:label : preferred share^^xsd:string</para>
    ///   <para>skos:definition : share that pays dividends at a specified rate and has preference over common shares in the payment of dividends and liquidation of corporate assets^^xsd:string</para>
    ///   <para>cmns-av:synonym : preference share^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShare">fibo-sec-eq-eq:PreferredShare</a>
    /// </summary>
    let PreferredShare = _prefixId.prefix "PreferredShare"

    /// <summary>
    ///   <para>rdfs:label : preferred share with adjustable rate dividend^^xsd:string</para>
    ///   <para>skos:definition : preferred share whose dividend rate varies according to some benchmark^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShareWithAdjustableRateDividend">fibo-sec-eq-eq:PreferredShareWithAdjustableRateDividend</a>
    /// </summary>
    let PreferredShareWithAdjustableRateDividend =
        _prefixId.prefix "PreferredShareWithAdjustableRateDividend"

    /// <summary>
    ///   <para>rdfs:label : preferred share with auction rate dividend^^xsd:string</para>
    ///   <para>skos:definition : preferred share whose dividend rate is periodically reset through an auction, such as a Dutch auction^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShareWithAuctionRateDividend">fibo-sec-eq-eq:PreferredShareWithAuctionRateDividend</a>
    /// </summary>
    let PreferredShareWithAuctionRateDividend =
        _prefixId.prefix "PreferredShareWithAuctionRateDividend"

    /// <summary>
    ///   <para>rdfs:label : preferred share with fixed maturity date^^xsd:string</para>
    ///   <para>skos:definition : preferred share whose maturity date is set, typically according to the terms of the prospectus^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShareWithFixedMaturityDate">fibo-sec-eq-eq:PreferredShareWithFixedMaturityDate</a>
    /// </summary>
    let PreferredShareWithFixedMaturityDate =
        _prefixId.prefix "PreferredShareWithFixedMaturityDate"

    /// <summary>
    ///   <para>rdfs:label : preferred share with fixed rate dividend^^xsd:string</para>
    ///   <para>skos:definition : preferred share whose dividends are set, typically according to the terms of the prospectus^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PreferredShareWithFixedRateDividend">fibo-sec-eq-eq:PreferredShareWithFixedRateDividend</a>
    /// </summary>
    let PreferredShareWithFixedRateDividend =
        _prefixId.prefix "PreferredShareWithFixedRateDividend"

    /// <summary>
    ///   <para>rdfs:label : price per share^^xsd:string</para>
    ///   <para>skos:definition : price for one share of a given security at some point in time^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : PPS^^xsd:string</para>
    ///   <para>cmns-av:synonym : share price^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PricePerShare">fibo-sec-eq-eq:PricePerShare</a>
    /// </summary>
    let PricePerShare = _prefixId.prefix "PricePerShare"
    /// <summary>
    ///   <para>rdfs:label : privately held share</para>
    ///   <para>skos:definition : share in a security that signifies ownership in an entity that is not publicly traded</para>
    ///   <para>cmns-av:explanatoryNote : Privately owned companies include family-owned businesses, sole proprietorships and the vast majority of small and medium-sized businesses. These companies are often too small for an initial public offering (IPO) due, for example to a small market capitalization and/or low trading volume, and fulfill their financing requirements in other ways, including through smaller offerings.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/PrivatelyHeldShare">fibo-sec-eq-eq:PrivatelyHeldShare</a>
    /// </summary>
    let PrivatelyHeldShare = _prefixId.prefix "PrivatelyHeldShare"
    /// <summary>
    ///   <para>rdfs:label : qualified dividend^^xsd:string</para>
    ///   <para>skos:definition : dividend that falls under capital gains tax rates that are lower than the income tax rates on unqualified (ordinary) dividends^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/QualifiedDividend">fibo-sec-eq-eq:QualifiedDividend</a>
    /// </summary>
    let QualifiedDividend = _prefixId.prefix "QualifiedDividend"
    /// <summary>
    ///   <para>rdfs:label : redeemable preferred share^^xsd:string</para>
    ///   <para>skos:definition : preferred share that gives the issuer the right to redeem the stock under specified conditions^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RedeemablePreferredShare">fibo-sec-eq-eq:RedeemablePreferredShare</a>
    /// </summary>
    let RedeemablePreferredShare = _prefixId.prefix "RedeemablePreferredShare"

    /// <summary>
    ///   <para>rdfs:label : redeemable preferred share with extendable maturity date^^xsd:string</para>
    ///   <para>skos:definition : redeemable preferred share with a fixed maturity date whose issuer has the option to extend the maturity date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RedeemablePreferredShareWithExtendableMaturityDate">fibo-sec-eq-eq:RedeemablePreferredShareWithExtendableMaturityDate</a>
    /// </summary>
    let RedeemablePreferredShareWithExtendableMaturityDate =
        _prefixId.prefix "RedeemablePreferredShareWithExtendableMaturityDate"

    /// <summary>
    ///   <para>rdfs:label : redeemable preferred share with extendable redemption date^^xsd:string</para>
    ///   <para>skos:definition : redeemable preferred share whose redemption date can be modified^^xsd:string</para>
    ///   <para>cmns-av:synonym : extendible preferred share^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RedeemablePreferredShareWithExtendableRedemptionDate">fibo-sec-eq-eq:RedeemablePreferredShareWithExtendableRedemptionDate</a>
    /// </summary>
    let RedeemablePreferredShareWithExtendableRedemptionDate =
        _prefixId.prefix "RedeemablePreferredShareWithExtendableRedemptionDate"

    /// <summary>
    ///   <para>rdfs:label : restricted share</para>
    ///   <para>skos:definition : share whose ownership/transfer/sale is subject to special conditions including country-specific restrictions</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RestrictedShare">fibo-sec-eq-eq:RestrictedShare</a>
    /// </summary>
    let RestrictedShare = _prefixId.prefix "RestrictedShare"
    /// <summary>
    ///   <para>rdfs:label : restricted voting share</para>
    ///   <para>skos:definition : share that confers less than one vote per share</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RestrictedVotingShare">fibo-sec-eq-eq:RestrictedVotingShare</a>
    /// </summary>
    let RestrictedVotingShare = _prefixId.prefix "RestrictedVotingShare"
    /// <summary>
    ///   <para>rdfs:label : retractable preferred share^^xsd:string</para>
    ///   <para>skos:definition : preferred share that gives the owner (shareholder) the right to redeem the stock under specified conditions^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : When retractable preferred shares reach maturity, the shareholder has the right to sell them back to the stock issuer at the price stated on the agreement. In some cases, the issuer can force the shareholder to sell, and may have the option of exchanging retractable preferred shares for common shares instead of cash.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RetractablePreferredShare">fibo-sec-eq-eq:RetractablePreferredShare</a>
    /// </summary>
    let RetractablePreferredShare = _prefixId.prefix "RetractablePreferredShare"

    /// <summary>
    ///   <para>rdfs:label : retractable preferred share with extendable maturity date^^xsd:string</para>
    ///   <para>skos:definition : retractable preferred share with a fixed maturity date whose issuer and/or holders have the option to extend the maturity date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RetractablePreferredShareWithExtendableMaturityDate">fibo-sec-eq-eq:RetractablePreferredShareWithExtendableMaturityDate</a>
    /// </summary>
    let RetractablePreferredShareWithExtendableMaturityDate =
        _prefixId.prefix "RetractablePreferredShareWithExtendableMaturityDate"

    /// <summary>
    ///   <para>rdfs:label : retractable preferred share with extendable redemption date^^xsd:string</para>
    ///   <para>skos:definition : retractable preferred share whose redemption date can be modified^^xsd:string</para>
    ///   <para>cmns-av:synonym : extendible preferred share^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/RetractablePreferredShareWithExtendableRedemptionDate">fibo-sec-eq-eq:RetractablePreferredShareWithExtendableRedemptionDate</a>
    /// </summary>
    let RetractablePreferredShareWithExtendableRedemptionDate =
        _prefixId.prefix "RetractablePreferredShareWithExtendableRedemptionDate"

    /// <summary>
    ///   <para>rdfs:label : share</para>
    ///   <para>skos:definition : financial instrument that signifies a unit of equity ownership in a corporation, or a unit of ownership in a mutual fund, or interest in a general or limited partnership, or a unit of ownership in a structured product, such as a real estate investment trust</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/Share">fibo-sec-eq-eq:Share</a>
    /// </summary>
    let Share = _prefixId.prefix "Share"
    /// <summary>
    ///   <para>rdfs:label : share issuer^^xsd:string</para>
    ///   <para>skos:definition : issuer of securities that represent an ownership interest in something^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This includes shares that represent equity ownership in a corporation, or ownership in a mutual fund, or an interest in a general or limited partnership, or ownership in a structured product, such as a real estate investment trust.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ShareIssuer">fibo-sec-eq-eq:ShareIssuer</a>
    /// </summary>
    let ShareIssuer = _prefixId.prefix "ShareIssuer"
    /// <summary>
    ///   <para>rdfs:label : share payment status^^xsd:string</para>
    ///   <para>skos:definition : classifier that specifies the overall payment status for shares issued^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : When a company issues shares upon incorporation or through an initial or secondary issuance, shareholders are required to pay a set amount for those shares. Once the company has received the full amount from shareholders, the shares become fully paid shares.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/SharePaymentStatus">fibo-sec-eq-eq:SharePaymentStatus</a>
    /// </summary>
    let SharePaymentStatus = _prefixId.prefix "SharePaymentStatus"
    /// <summary>
    ///   <para>rdfs:label : share yield</para>
    ///   <para>skos:definition : ratio of the annualized dividend per share divided by the (current) price per share</para>
    ///   <para>cmns-av:synonym : dividend yieldcmns-av:synonym : dividend-price ratio</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/ShareYield">fibo-sec-eq-eq:ShareYield</a>
    /// </summary>
    let ShareYield = _prefixId.prefix "ShareYield"
    /// <summary>
    ///   <para>rdfs:label : single voting share</para>
    ///   <para>skos:definition : share that has the right to exactly one vote</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/SingleVotingShare">fibo-sec-eq-eq:SingleVotingShare</a>
    /// </summary>
    let SingleVotingShare = _prefixId.prefix "SingleVotingShare"
    /// <summary>
    ///   <para>rdfs:label : soft retractable preferred share^^xsd:string</para>
    ///   <para>skos:definition : retractable preferred share whose retraction value may be paid in cash or in an equal value of common stock of the issuer, at the option of the issuer^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/SoftRetractablePreferredShare">fibo-sec-eq-eq:SoftRetractablePreferredShare</a>
    /// </summary>
    let SoftRetractablePreferredShare = _prefixId.prefix "SoftRetractablePreferredShare"
    /// <summary>
    ///   <para>rdfs:label : special dividend^^xsd:string</para>
    ///   <para>skos:definition : dividend that is paid to shareholders on a one-time basis^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Special dividends may be included in a dividend schedule as an ad-hoc entry, since they still need to be tracked based on the date of issuance.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/SpecialDividend">fibo-sec-eq-eq:SpecialDividend</a>
    /// </summary>
    let SpecialDividend = _prefixId.prefix "SpecialDividend"
    /// <summary>
    ///   <para>rdfs:label : unrestricted share</para>
    ///   <para>skos:definition : share whose ownership/transfer/sale is not subject to special conditions including country-specific restrictions</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/UnrestrictedShare">fibo-sec-eq-eq:UnrestrictedShare</a>
    /// </summary>
    let UnrestrictedShare = _prefixId.prefix "UnrestrictedShare"
    /// <summary>
    ///   <para>rdfs:label : variable interest entity share</para>
    ///   <para>skos:definition : share that certifies ownership of a contractual right to a percentage of a company's profits^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Unlike a traditional stock certificate, the VIE share provides a legal proprietary interest in a completely separate company's assets, sometimes referred to as a shell company. The contractual right certified by the VIE share is derived from a contract between (1) the company named on the VIE share and (2) the shell company. In other words, VIE shareholders only have a traditional stock certificate in the completely separate shell company, which is entitled to a percentage of the named company's profits via a private contract.^^xsd:string</para>
    ///   <para>cmns-av:synonym : VIE share</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/VariableInterestEntityShare">fibo-sec-eq-eq:VariableInterestEntityShare</a>
    /// </summary>
    let VariableInterestEntityShare = _prefixId.prefix "VariableInterestEntityShare"
    /// <summary>
    ///   <para>rdfs:label : voting right^^xsd:string</para>
    ///   <para>skos:definition : contractual right that specifies shareholder voting entitlements, such as to elect directors, elect outside auditors, and vote on matters of corporate policy^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Voting may involve decisions on issuing securities, initiating stock splits, and making substantial changes in the corporation's operations. Note that a given share may not have voting rights, in which case the number of votes per share would be zero.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/VotingRight">fibo-sec-eq-eq:VotingRight</a>
    /// </summary>
    let VotingRight = _prefixId.prefix "VotingRight"
    /// <summary>
    ///   <para>rdfs:label : number of votes per share</para>
    ///   <para>skos:definition : grants the right to vote on a per share basis to the shareholder</para>
    ///   <para>cmns-av:explanatoryNote : A given share may have zero, fractional, one, or more votes per share, depending on the contract.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/confersNumberOfVotesPerShare">fibo-sec-eq-eq:confersNumberOfVotesPerShare</a>
    /// </summary>
    let confersNumberOfVotesPerShare = _prefixId.prefix "confersNumberOfVotesPerShare"
    /// <summary>
    ///   <para>rdfs:label : confers ownership of^^xsd:string</para>
    ///   <para>skos:definition : grants ownership via contract</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/confersOwnershipOf">fibo-sec-eq-eq:confersOwnershipOf</a>
    /// </summary>
    let confersOwnershipOf = _prefixId.prefix "confersOwnershipOf"
    /// <summary>
    ///   <para>rdfs:label : has adjustable dividend rate^^xsd:string</para>
    ///   <para>skos:definition : indicates a variable dividend rate, typically specified in the prospectus as a formula based on a benchmark or set at auction^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasAdjustableDividendRate">fibo-sec-eq-eq:hasAdjustableDividendRate</a>
    /// </summary>
    let hasAdjustableDividendRate = _prefixId.prefix "hasAdjustableDividendRate"
    /// <summary>
    ///   <para>rdfs:label : has available shares</para>
    ///   <para>skos:definition : indicates the number of shares outstanding less those shares that are restricted, i.e., those that are available for trading</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasAvailableShares">fibo-sec-eq-eq:hasAvailableShares</a>
    /// </summary>
    let hasAvailableShares = _prefixId.prefix "hasAvailableShares"
    /// <summary>
    ///   <para>rdfs:label : has distribution method^^xsd:string</para>
    ///   <para>skos:definition : indicates the method by which dividend payments are to be distributed^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasDistributionMethod">fibo-sec-eq-eq:hasDistributionMethod</a>
    /// </summary>
    let hasDistributionMethod = _prefixId.prefix "hasDistributionMethod"
    /// <summary>
    ///   <para>rdfs:label : has dividend^^xsd:string</para>
    ///   <para>skos:definition : relates a share to a dividend that applies to that share, or that the share may pay^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasDividend">fibo-sec-eq-eq:hasDividend</a>
    /// </summary>
    let hasDividend = _prefixId.prefix "hasDividend"
    /// <summary>
    ///   <para>rdfs:label : has declaration date^^xsd:string</para>
    ///   <para>skos:definition : indicates a date on which an organization states that a dividend payment may be anticipated, including the the dividend amount and the ex-dividend and payment dates^^xsd:string</para>
    ///   <para>cmns-av:synonym : has announcement date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasDividendDeclarationDate">fibo-sec-eq-eq:hasDividendDeclarationDate</a>
    /// </summary>
    let hasDividendDeclarationDate = _prefixId.prefix "hasDividendDeclarationDate"
    /// <summary>
    ///   <para>rdfs:label : has dividend grace period^^xsd:string</para>
    ///   <para>skos:definition : indicates a period of time after a dividend payment becomes due, before the issuer is subject to penalties^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasDividendGracePeriod">fibo-sec-eq-eq:hasDividendGracePeriod</a>
    /// </summary>
    let hasDividendGracePeriod = _prefixId.prefix "hasDividendGracePeriod"
    /// <summary>
    ///   <para>rdfs:label : has earliest redemption date^^xsd:string</para>
    ///   <para>skos:definition : indicates a date on or after which a stock can be redeemed^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasEarliestRedemptionDate">fibo-sec-eq-eq:hasEarliestRedemptionDate</a>
    /// </summary>
    let hasEarliestRedemptionDate = _prefixId.prefix "hasEarliestRedemptionDate"
    /// <summary>
    ///   <para>rdfs:label : has ex-dividend date^^xsd:string</para>
    ///   <para>skos:definition : indicates a date on which a stock 'goes ex-dividend', typically about three weeks before the dividend is paid to shareholders of record^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.investor.gov/introduction-investing/investing-basics/glossary/ex-dividend-dates-when-are-you-entitled-stock-and^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Once the company sets the record date, the ex-dividend date is set based on stock exchange rules. If you purchase a stock on its ex-dividend date or after, you will not receive the next dividend payment.^^xsd:stringcmns-av:explanatoryNote : Shares listed on the New York Stock Exchange go ex-dividend four business days prior to the record date.^^xsd:string</para>
    ///   <para>cmns-av:synonym : has ex-date^^xsd:stringcmns-av:synonym : has expected dividend date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasExDividendDate">fibo-sec-eq-eq:hasExDividendDate</a>
    /// </summary>
    let hasExDividendDate = _prefixId.prefix "hasExDividendDate"
    /// <summary>
    ///   <para>rdfs:label : has extendable maturity date^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the issuer and/or holders of redeemable shares with a fixed maturity date have the option to extend the maturity date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasExtendableMaturityDate">fibo-sec-eq-eq:hasExtendableMaturityDate</a>
    /// </summary>
    let hasExtendableMaturityDate = _prefixId.prefix "hasExtendableMaturityDate"
    /// <summary>
    ///   <para>rdfs:label : has extendable redemption date^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the issuer and/or holders of redeemable shares with a specified redemption date have the option to extend that date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasExtendableRedemptionDate">fibo-sec-eq-eq:hasExtendableRedemptionDate</a>
    /// </summary>
    let hasExtendableRedemptionDate = _prefixId.prefix "hasExtendableRedemptionDate"
    /// <summary>
    ///   <para>rdfs:label : has fixed dividend rate^^xsd:string</para>
    ///   <para>skos:definition : indicates a pre-arranged fixed dividend rate, typically specified in the prospectus, for a preferred share^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasFixedDividendRate">fibo-sec-eq-eq:hasFixedDividendRate</a>
    /// </summary>
    let hasFixedDividendRate = _prefixId.prefix "hasFixedDividendRate"
    /// <summary>
    ///   <para>rdfs:label : has floating stock</para>
    ///   <para>skos:definition : indicates the number of shares that are available for trading, i.e., the number of shares outstanding less closely held shares (those held by insiders) and restricted shares</para>
    ///   <para>cmns-av:explanatoryNote : A relatively small float results in higher volatility, as a large purchase or sell order will have significant influence on the value of the stock.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasFloatingStock">fibo-sec-eq-eq:hasFloatingStock</a>
    /// </summary>
    let hasFloatingStock = _prefixId.prefix "hasFloatingStock"
    /// <summary>
    ///   <para>rdfs:label : has minimum redemption price^^xsd:string</para>
    ///   <para>skos:definition : indicates the lowest market price above which a share may be redeemed^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasMinimumRedemptionPrice">fibo-sec-eq-eq:hasMinimumRedemptionPrice</a>
    /// </summary>
    let hasMinimumRedemptionPrice = _prefixId.prefix "hasMinimumRedemptionPrice"
    /// <summary>
    ///   <para>rdfs:label : has record date^^xsd:string</para>
    ///   <para>skos:definition : indicates the date on which the issuer checks to determine whether a party was on the company's books as a shareholder when required (i.e., they must have been on the books prior to the ex-dividend date), to identify who is eligible to receive the next dividend^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.investor.gov/introduction-investing/investing-basics/glossary/ex-dividend-dates-when-are-you-entitled-stock-and^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Companies also use this date to determine who is sent proxy statements, financial reports, and other information.^^xsd:string</para>
    ///   <para>cmns-av:synonym : has date of record^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasRecordDate">fibo-sec-eq-eq:hasRecordDate</a>
    /// </summary>
    let hasRecordDate = _prefixId.prefix "hasRecordDate"
    /// <summary>
    ///   <para>rdfs:label : has redemption premium^^xsd:string</para>
    ///   <para>skos:definition : indicates the premium price per share over the market price, if any, that must be paid in order to redeem the stock^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasRedemptionPremium">fibo-sec-eq-eq:hasRedemptionPremium</a>
    /// </summary>
    let hasRedemptionPremium = _prefixId.prefix "hasRedemptionPremium"
    /// <summary>
    ///   <para>rdfs:label : has share class</para>
    ///   <para>skos:definition : indicates the class to which the share belongs, typically differentiated by privileges, such as voting rights</para>
    ///   <para>cmns-av:explanatoryNote : Classes of shares, including shares in a mutual fund, are designated by name or a character (letter), such as A, B, C, etc. In the case of a mutual fund, different classes of shares may incur different fees and expenses.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasShareClass">fibo-sec-eq-eq:hasShareClass</a>
    /// </summary>
    let hasShareClass = _prefixId.prefix "hasShareClass"
    /// <summary>
    ///   <para>rdfs:label : has share payment status</para>
    ///   <para>skos:definition : indicates the payment status for shares issued</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasSharePaymentStatus">fibo-sec-eq-eq:hasSharePaymentStatus</a>
    /// </summary>
    let hasSharePaymentStatus = _prefixId.prefix "hasSharePaymentStatus"
    /// <summary>
    ///   <para>rdfs:label : has shares issued</para>
    ///   <para>skos:definition : indicates the actual number of shares held by shareholders (i.e., shares outstanding) and treasury shares</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasSharesIssued">fibo-sec-eq-eq:hasSharesIssued</a>
    /// </summary>
    let hasSharesIssued = _prefixId.prefix "hasSharesIssued"
    /// <summary>
    ///   <para>rdfs:label : has shares outstanding</para>
    ///   <para>skos:definition : indicates the number of shares currently held by shareholders, including those held by retail investors, institutional investors and insiders, and typically available for trading</para>
    ///   <para>cmns-av:explanatoryNote : The number of outstanding shares is used in calculating key metrics such as a company's market capitalization, as well as its earnings per share (EPS) and cash flow per share (CFPS).</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasSharesOutstanding">fibo-sec-eq-eq:hasSharesOutstanding</a>
    /// </summary>
    let hasSharesOutstanding = _prefixId.prefix "hasSharesOutstanding"
    /// <summary>
    ///   <para>rdfs:label : has treasury shares</para>
    ///   <para>skos:definition : indicates the number of shares issued but not outstanding, including those that were available in the market at one time but have been repurchased by the company</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasTreasuryShares">fibo-sec-eq-eq:hasTreasuryShares</a>
    /// </summary>
    let hasTreasuryShares = _prefixId.prefix "hasTreasuryShares"
    /// <summary>
    ///   <para>rdfs:label : has voting restriction</para>
    ///   <para>skos:definition : specifies restrictions on voting rights, if any^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Such restrictions may apply regardless of the number of votes per share.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/hasVotingRestriction">fibo-sec-eq-eq:hasVotingRestriction</a>
    /// </summary>
    let hasVotingRestriction = _prefixId.prefix "hasVotingRestriction"
    /// <summary>
    ///   <para>rdfs:label : is redeemable at issuer option^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the issuer has the option of initiating the buy-back, similar to a call feature^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/isRedeemableAtIssuerOption">fibo-sec-eq-eq:isRedeemableAtIssuerOption</a>
    /// </summary>
    let isRedeemableAtIssuerOption = _prefixId.prefix "isRedeemableAtIssuerOption"

    /// <summary>
    ///   <para>rdfs:label : is redeemable at shareholder option^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the shareholder has the option of initiating the buy-back, similar to a put feature^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/isRedeemableAtShareholderOption">fibo-sec-eq-eq:isRedeemableAtShareholderOption</a>
    /// </summary>
    let isRedeemableAtShareholderOption =
        _prefixId.prefix "isRedeemableAtShareholderOption"

    /// <summary>
    ///   <para>rdfs:label : is senior to^^xsd:string</para>
    ///   <para>skos:definition : indicates that a given share (share class) has higher seniority than the related share, meaning that it gives the holder a higher claim on the assets of the issuer^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/isSeniorTo">fibo-sec-eq-eq:isSeniorTo</a>
    /// </summary>
    let isSeniorTo = _prefixId.prefix "isSeniorTo"
    /// <summary>
    ///   <para>rdfs:label : specifies conversion date^^xsd:string</para>
    ///   <para>skos:definition : indicates the date on which, or after which, conversion may occur^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/specifiesConversionDate">fibo-sec-eq-eq:specifiesConversionDate</a>
    /// </summary>
    let specifiesConversionDate = _prefixId.prefix "specifiesConversionDate"
