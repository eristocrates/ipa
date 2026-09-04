#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-dbt-dbti`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/" "fibo-sec-dbt-dbti"

    let _namespaceIri = _prefixId.prefix ""
    let AtADiscount = _prefixId.prefix "AtADiscount"
    let AtAPremium = _prefixId.prefix "AtAPremium"
    /// <summary>
    ///   <para>rdfs:label : call event^^xsd:string</para>
    ///   <para>skos:definition : an event associated with the call schedule for a debt instrument^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallEvent">fibo-sec-dbt-dbti:CallEvent</a>
    /// </summary>
    let CallEvent = _prefixId.prefix "CallEvent"
    /// <summary>
    ///   <para>rdfs:label : call feature^^xsd:string</para>
    ///   <para>skos:definition : redemption provision defining the rights of the issuer to buy back a security at a call price after a call protection period^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Most corporate and municipal bonds have ten-year call features (termed call protection by holders); government securities typically have none.^^xsd:string</para>
    ///   <para>cmns-av:synonym : call provision^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallFeature">fibo-sec-dbt-dbti:CallFeature</a>
    /// </summary>
    let CallFeature = _prefixId.prefix "CallFeature"
    /// <summary>
    ///   <para>rdfs:label : call notification provision^^xsd:string</para>
    ///   <para>skos:definition : provision of a call feature defining notification requirements^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallNotificationProvision">fibo-sec-dbt-dbti:CallNotificationProvision</a>
    /// </summary>
    let CallNotificationProvision = _prefixId.prefix "CallNotificationProvision"
    /// <summary>
    ///   <para>rdfs:label : call premium^^xsd:string</para>
    ///   <para>skos:definition : the price over par paid by an issuer to redeem securities when exercising a call provision^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallPremium">fibo-sec-dbt-dbti:CallPremium</a>
    /// </summary>
    let CallPremium = _prefixId.prefix "CallPremium"
    /// <summary>
    ///   <para>rdfs:label : call schedule^^xsd:string</para>
    ///   <para>skos:definition : a schedule of call prices and when they are in effect^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallSchedule">fibo-sec-dbt-dbti:CallSchedule</a>
    /// </summary>
    let CallSchedule = _prefixId.prefix "CallSchedule"
    /// <summary>
    ///   <para>rdfs:label : call window^^xsd:string</para>
    ///   <para>skos:definition : an explicit period of time prior to a call date during which an issuer or agent must give notice to holders^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/CallWindow">fibo-sec-dbt-dbti:CallWindow</a>
    /// </summary>
    let CallWindow = _prefixId.prefix "CallWindow"
    /// <summary>
    ///   <para>rdfs:label : debt offering^^xsd:string</para>
    ///   <para>skos:definition : an offering of one or more debt instruments for sale^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/DebtOffering">fibo-sec-dbt-dbti:DebtOffering</a>
    /// </summary>
    let DebtOffering = _prefixId.prefix "DebtOffering"
    /// <summary>
    ///   <para>rdfs:label : fixed income security^^xsd:string</para>
    ///   <para>skos:definition : tradeable debt instrument that provides a return in the form of fixed periodic payments and typically the return of principal at maturity^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Fixed income securities provide payments according to a regular schedule. This does not necessarily mean that the payments themselves are of a fixed amount, however.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/FixedIncomeSecurity">fibo-sec-dbt-dbti:FixedIncomeSecurity</a>
    /// </summary>
    let FixedIncomeSecurity = _prefixId.prefix "FixedIncomeSecurity"
    /// <summary>
    ///   <para>rdfs:label : fully-indexed interest rate^^xsd:string</para>
    ///   <para>skos:definition : a variable interest rate that is calculated by adding a margin to a specified index rate^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Fully indexed interest rates are used for variable rate credit products. The interest rate on a variable (adjustable) rate mortgage corresponds to a specific benchmark (often the prime rate, but sometimes LIBOR, the one-year constant-maturity Treasury, or other benchmarks) plus a spread (also called the margin. The margin on a fully indexed interest rate product is determined by the underwriter and based on the borrower's credit quality.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/FullyIndexedInterestRate">fibo-sec-dbt-dbti:FullyIndexedInterestRate</a>
    /// </summary>
    let FullyIndexedInterestRate = _prefixId.prefix "FullyIndexedInterestRate"
    /// <summary>
    ///   <para>rdfs:label : interest-only strip</para>
    ///   <para>skos:definition : a strip that represents the non-principal portion of the monthly payments on the underlying debt instrument, such as a bond</para>
    ///   <para>skos:example : An interest-only strip can be reintegrated into other synthetic or engineered products. For example, interest-only strips can be pooled to create or make up a portion of a larger collateralized mortgage obligation (CMO), asset-backed security (ABS) or collateralized debt obligation (CDO) structure.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : An interest-only strip holder is interested in rising rates and no prepayment, as prepayment would cause them forfeit future interest payments and receive nothing from the return of the principal.^^xsd:string</para>
    ///   <para>cmns-av:synonym : IO strip</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/InterestOnlyStrip">fibo-sec-dbt-dbti:InterestOnlyStrip</a>
    /// </summary>
    let InterestOnlyStrip = _prefixId.prefix "InterestOnlyStrip"
    /// <summary>
    ///   <para>rdfs:label : issued debt^^xsd:string</para>
    ///   <para>skos:definition : debt that is set out by the borrower in some form of financial security in which the lender is the holder or counterparty of that security^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/IssuedDebt">fibo-sec-dbt-dbti:IssuedDebt</a>
    /// </summary>
    let IssuedDebt = _prefixId.prefix "IssuedDebt"
    /// <summary>
    ///   <para>rdfs:label : make whole feature^^xsd:string</para>
    ///   <para>skos:definition : a call provision allowing the issuer to pay off remaining debt early^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The issuer typically has to make a lump sum payment to the investor derived from a formula based on the net present value (NPV) of future interest or coupon payments that will not be paid incrementally because of the call combined with the principal payment the investor would have received at maturity.^^xsd:string</para>
    ///   <para>cmns-av:synonym : make whole provision^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/MakeWholeFeature">fibo-sec-dbt-dbti:MakeWholeFeature</a>
    /// </summary>
    let MakeWholeFeature = _prefixId.prefix "MakeWholeFeature"
    /// <summary>
    ///   <para>rdfs:label : margin^^xsd:string</para>
    ///   <para>skos:definition : a variable that is added to a specified index rate to determine the fully indexed interest rate charged to a borrower on a credit balance^^xsd:string</para>
    ///   <para>cmns-av:synonym : spread^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/Margin">fibo-sec-dbt-dbti:Margin</a>
    /// </summary>
    let Margin = _prefixId.prefix "Margin"
    /// <summary>
    ///   <para>rdfs:label : non-tradable debt instrument^^xsd:string</para>
    ///   <para>skos:definition : a debt instrument that may not be bought or sold^^xsd:string</para>
    ///   <para>skos:example : Low-risk instruments such as savings bonds are examples of nonnegotiable debt instruments.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Generally, a nonnegotiable instrument may be redeemed by the issuer, but this is often subject to some limitations.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/NonTradableDebtInstrument">fibo-sec-dbt-dbti:NonTradableDebtInstrument</a>
    /// </summary>
    let NonTradableDebtInstrument = _prefixId.prefix "NonTradableDebtInstrument"
    /// <summary>
    ///   <para>rdfs:label : notification provision^^xsd:string</para>
    ///   <para>skos:definition : provision of a redemption feature defining notification requirements^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/NotificationProvision">fibo-sec-dbt-dbti:NotificationProvision</a>
    /// </summary>
    let NotificationProvision = _prefixId.prefix "NotificationProvision"
    let ParValue = _prefixId.prefix "ParValue"
    /// <summary>
    ///   <para>rdfs:label : prescriptive event^^xsd:string</para>
    ///   <para>skos:definition : event related to the imposition or enforcement of a rule, method, formula, etc.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PrescriptiveEvent">fibo-sec-dbt-dbti:PrescriptiveEvent</a>
    /// </summary>
    let PrescriptiveEvent = _prefixId.prefix "PrescriptiveEvent"
    /// <summary>
    ///   <para>rdfs:label : principal-only strip</para>
    ///   <para>skos:definition : a strip that represents the principal portion of the monthly payments on the underlying debt instrument, such as a bond</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PrincipalOnlyStrip">fibo-sec-dbt-dbti:PrincipalOnlyStrip</a>
    /// </summary>
    let PrincipalOnlyStrip = _prefixId.prefix "PrincipalOnlyStrip"
    /// <summary>
    ///   <para>rdfs:label : publicly issued debt^^xsd:string</para>
    ///   <para>skos:definition : an issued debt in the form of a tradable debt instrument (security)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PubliclyIssuedDebt">fibo-sec-dbt-dbti:PubliclyIssuedDebt</a>
    /// </summary>
    let PubliclyIssuedDebt = _prefixId.prefix "PubliclyIssuedDebt"
    /// <summary>
    ///   <para>rdfs:label : put event^^xsd:string</para>
    ///   <para>skos:definition : an event associated with the put schedule for a debt instrument, i.e., an event involving the 'put', or surrender of the instrument by the holder^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutEvent">fibo-sec-dbt-dbti:PutEvent</a>
    /// </summary>
    let PutEvent = _prefixId.prefix "PutEvent"
    /// <summary>
    ///   <para>rdfs:label : put feature^^xsd:string</para>
    ///   <para>skos:definition : redemption provision giving the holder the right, but not the obligation, to sell a specified amount of the debt instrument (i.e., redeem it), prior to maturity^^xsd:string</para>
    ///   <para>skos:editorialNote : FIBIM has term "Putable Date" which (by implication, and comparing with definition for "Next Call Date") is presumably a single calendar date in the future, at a given point in time. That does not cover the definition of formal terms defining when and how the issue may be put, which is what is modeled here.^^xsd:string</para>
    ///   <para>cmns-av:synonym : put provision^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutFeature">fibo-sec-dbt-dbti:PutFeature</a>
    /// </summary>
    let PutFeature = _prefixId.prefix "PutFeature"
    /// <summary>
    ///   <para>rdfs:label : put notification provision^^xsd:string</para>
    ///   <para>skos:definition : a provision of a put feature defining notification requirements^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutNotificationProvision">fibo-sec-dbt-dbti:PutNotificationProvision</a>
    /// </summary>
    let PutNotificationProvision = _prefixId.prefix "PutNotificationProvision"
    /// <summary>
    ///   <para>rdfs:label : put premium^^xsd:string</para>
    ///   <para>skos:definition : an amount over par that a debt instrument holder must pay to sell the security early^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutPremium">fibo-sec-dbt-dbti:PutPremium</a>
    /// </summary>
    let PutPremium = _prefixId.prefix "PutPremium"
    /// <summary>
    ///   <para>rdfs:label : put schedule^^xsd:string</para>
    ///   <para>skos:definition : a schedule that defines the events associated with the put feature of a debt instrument, i.e, the dates on which the debt instrument may be sold at what price by the holder^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutSchedule">fibo-sec-dbt-dbti:PutSchedule</a>
    /// </summary>
    let PutSchedule = _prefixId.prefix "PutSchedule"
    /// <summary>
    ///   <para>rdfs:label : put window^^xsd:string</para>
    ///   <para>skos:definition : an explicit period of time prior to a put date during which holder or agent must give notice to an issuer^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/PutWindow">fibo-sec-dbt-dbti:PutWindow</a>
    /// </summary>
    let PutWindow = _prefixId.prefix "PutWindow"
    /// <summary>
    ///   <para>rdfs:label : redemption event^^xsd:string</para>
    ///   <para>skos:definition : a prescriptive event involving the return of an investor's principal in a fixed-income security, such as a preferred stock or bond, or the sale of units in a mutual fund^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/RedemptionEvent">fibo-sec-dbt-dbti:RedemptionEvent</a>
    /// </summary>
    let RedemptionEvent = _prefixId.prefix "RedemptionEvent"
    /// <summary>
    ///   <para>rdfs:label : relative price^^xsd:string</para>
    ///   <para>skos:definition : security price specified in comparison with either a stated or market value for a debt instrument at some point in time^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/RelativePrice">fibo-sec-dbt-dbti:RelativePrice</a>
    /// </summary>
    let RelativePrice = _prefixId.prefix "RelativePrice"
    /// <summary>
    ///   <para>rdfs:label : step event^^xsd:string</para>
    ///   <para>skos:definition : event that prescribes a change in a contractual term, such as a rate or notional amount, for a given contract^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/StepEvent">fibo-sec-dbt-dbti:StepEvent</a>
    /// </summary>
    let StepEvent = _prefixId.prefix "StepEvent"
    /// <summary>
    ///   <para>rdfs:label : step schedule^^xsd:string</para>
    ///   <para>skos:definition : schedule specifying the date(s) and change in a contractual term(s), e.g., rate or notional amount, for a contract that has a feature where stipulated changes occur at specified intervals or on specified dates^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/StepSchedule">fibo-sec-dbt-dbti:StepSchedule</a>
    /// </summary>
    let StepSchedule = _prefixId.prefix "StepSchedule"
    /// <summary>
    ///   <para>rdfs:label : strip</para>
    ///   <para>skos:definition : a tradeable debt instrument created either through the process of removing coupons from a bond and then selling the separate parts as a zero coupon bond and an interest paying coupon bond or through taking the opposite position from some variant in the options market</para>
    ///   <para>cmns-av:explanatoryNote : STRIPS is an acronym for Separate Trading of Registered Interest and Principal of Securities, which has come to be used as a term in its own right.</para>
    ///   <para>cmns-av:synonym : Separate Trading of Registered Interest and Principal of Securities</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/Strip">fibo-sec-dbt-dbti:Strip</a>
    /// </summary>
    let Strip = _prefixId.prefix "Strip"
    /// <summary>
    ///   <para>rdfs:label : tradable debt instrument^^xsd:string</para>
    ///   <para>skos:definition : a debt instrument that is also a security, i.e., that can be bought and sold by the holder^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Details from Ecofin: A [debt] instrument can be traded, if its features depend only on one borrower. If the instrument has no bilateral or multilateral obligations, the investor can easily transfer it to another investor without asking the borrower (except the terms prohibit this explicitly). This is simplified with securitised instruments, where the debt is already split into handy denominations which trade easily (e.g. in round thousands or millions as with bonds, commercial paper, etc.). But in principle it works also with interbank loans and similar instruments. FIBIM Definition: Financial instruments evidencing moneys owed by the issuer to the holder on terms as specified.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/TradableDebtInstrument">fibo-sec-dbt-dbti:TradableDebtInstrument</a>
    /// </summary>
    let TradableDebtInstrument = _prefixId.prefix "TradableDebtInstrument"
    /// <summary>
    ///   <para>rdfs:label : variable income security^^xsd:string</para>
    ///   <para>skos:definition : tradeable debt instrument that provide their owners with a rate of return that is dynamic and determined by market forces^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Variable-income securities provide investors with both greater risks as well as rewards.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/VariableIncomeSecurity">fibo-sec-dbt-dbti:VariableIncomeSecurity</a>
    /// </summary>
    let VariableIncomeSecurity = _prefixId.prefix "VariableIncomeSecurity"
    /// <summary>
    ///   <para>rdfs:label : allows auto-reinvestment^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the security allows automatically re-investing the interest on that security towards purchasing additional shares or units of the same security^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/allowsAutoReinvestment">fibo-sec-dbt-dbti:allowsAutoReinvestment</a>
    /// </summary>
    let allowsAutoReinvestment = _prefixId.prefix "allowsAutoReinvestment"
    /// <summary>
    ///   <para>rdfs:label : allows payment in kind^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the principal may be repaid in kind (i.e., replaced with another instrument) rather than in cash^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/allowsPaymentInKind">fibo-sec-dbt-dbti:allowsPaymentInKind</a>
    /// </summary>
    let allowsPaymentInKind = _prefixId.prefix "allowsPaymentInKind"
    /// <summary>
    ///   <para>rdfs:label : has call feature^^xsd:string</para>
    ///   <para>skos:definition : indicates the specific terms related to any inherent call feature as specified in the offering/instrument^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasCallFeature">fibo-sec-dbt-dbti:hasCallFeature</a>
    /// </summary>
    let hasCallFeature = _prefixId.prefix "hasCallFeature"
    /// <summary>
    ///   <para>rdfs:label : has dated date^^xsd:string</para>
    ///   <para>skos:definition : specifies the date on which interest begins to accrue on a fixed-income security^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Investors who purchase a fixed-income security between interest payment dates must also pay the seller or issuer any interest that has accrued from the dated date to the purchase date, or settlement date, in addition to the face value.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasDatedDate">fibo-sec-dbt-dbti:hasDatedDate</a>
    /// </summary>
    let hasDatedDate = _prefixId.prefix "hasDatedDate"
    /// <summary>
    ///   <para>rdfs:label : has default lot size^^xsd:string</para>
    ///   <para>skos:definition : indicates the default number of units of the security that may be held at any one time^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This is the minimum denomination required for transfer or change of ownership of a tradable debt security.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasDefaultLotSize">fibo-sec-dbt-dbti:hasDefaultLotSize</a>
    /// </summary>
    let hasDefaultLotSize = _prefixId.prefix "hasDefaultLotSize"
    /// <summary>
    ///   <para>rdfs:label : has estate or death put feature^^xsd:string</para>
    ///   <para>skos:definition : indicates that a security is subject to redemption upon the passing of the holder^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasEstateOrDeathPutFeature">fibo-sec-dbt-dbti:hasEstateOrDeathPutFeature</a>
    /// </summary>
    let hasEstateOrDeathPutFeature = _prefixId.prefix "hasEstateOrDeathPutFeature"
    /// <summary>
    ///   <para>rdfs:label : has interest payment terms^^xsd:string</para>
    ///   <para>skos:definition : indicates the specific terms related to interest payments on the principal as specified in the instrument or a related contract document^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasInterestPaymentTerms">fibo-sec-dbt-dbti:hasInterestPaymentTerms</a>
    /// </summary>
    let hasInterestPaymentTerms = _prefixId.prefix "hasInterestPaymentTerms"
    /// <summary>
    ///   <para>rdfs:label : has notification provision^^xsd:string</para>
    ///   <para>skos:definition : relates the redemption provision of a debt instrument to a notification provision (e.g., call or put notification)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasNotificationProvision">fibo-sec-dbt-dbti:hasNotificationProvision</a>
    /// </summary>
    let hasNotificationProvision = _prefixId.prefix "hasNotificationProvision"
    /// <summary>
    ///   <para>rdfs:label : has pool number^^xsd:string</para>
    ///   <para>skos:definition : indicates the pool number of the debt^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasPoolNumber">fibo-sec-dbt-dbti:hasPoolNumber</a>
    /// </summary>
    let hasPoolNumber = _prefixId.prefix "hasPoolNumber"

    /// <summary>
    ///   <para>rdfs:label : has price and yield day count convention^^xsd:string</para>
    ///   <para>skos:definition : indicates the convention used to determine the number of days in a month and days in a year that are counted when performing calculations for yield and price figures^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasPriceAndYieldDayCountConvention">fibo-sec-dbt-dbti:hasPriceAndYieldDayCountConvention</a>
    /// </summary>
    let hasPriceAndYieldDayCountConvention =
        _prefixId.prefix "hasPriceAndYieldDayCountConvention"

    /// <summary>
    ///   <para>rdfs:label : has put feature^^xsd:string</para>
    ///   <para>skos:definition : indicates the specific terms related to any inherent put feature as specified in the offering/instrument^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasPutFeature">fibo-sec-dbt-dbti:hasPutFeature</a>
    /// </summary>
    let hasPutFeature = _prefixId.prefix "hasPutFeature"
    /// <summary>
    ///   <para>rdfs:label : has relative price at issue^^xsd:string</para>
    ///   <para>skos:definition : indicates a relative price with respect to the face value at which an instrument is issued, namely par, premium or discount^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRelativePriceAtIssue">fibo-sec-dbt-dbti:hasRelativePriceAtIssue</a>
    /// </summary>
    let hasRelativePriceAtIssue = _prefixId.prefix "hasRelativePriceAtIssue"
    /// <summary>
    ///   <para>rdfs:label : has relative price at maturity^^xsd:string</para>
    ///   <para>skos:definition : indicates a relative price with respect to the face value at the time an instrument matures, namely par, discount or premium^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRelativePriceAtMaturity">fibo-sec-dbt-dbti:hasRelativePriceAtMaturity</a>
    /// </summary>
    let hasRelativePriceAtMaturity = _prefixId.prefix "hasRelativePriceAtMaturity"
    /// <summary>
    ///   <para>rdfs:label : has relative price at redemption^^xsd:string</para>
    ///   <para>skos:definition : indicates a relative price with respect to the face value at the time an instrument is redeemed, namely par, discount or premium^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRelativePriceAtRedemption">fibo-sec-dbt-dbti:hasRelativePriceAtRedemption</a>
    /// </summary>
    let hasRelativePriceAtRedemption = _prefixId.prefix "hasRelativePriceAtRedemption"
    /// <summary>
    ///   <para>rdfs:label : has repayment terms^^xsd:string</para>
    ///   <para>skos:definition : indicates the specific terms related to repayment of principal as specified in the instrument or a related contract document^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRepaymentTerms">fibo-sec-dbt-dbti:hasRepaymentTerms</a>
    /// </summary>
    let hasRepaymentTerms = _prefixId.prefix "hasRepaymentTerms"
    /// <summary>
    ///   <para>rdfs:label : right to retain^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the holder has an option to retain the security in the event of an issuer exercising the put feature^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/hasRightToRetain">fibo-sec-dbt-dbti:hasRightToRetain</a>
    /// </summary>
    let hasRightToRetain = _prefixId.prefix "hasRightToRetain"
    /// <summary>
    ///   <para>rdfs:label : is callable^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the issuer (writer) of the debt contract (the debtor) can call the debt prior to maturity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isCallable">fibo-sec-dbt-dbti:isCallable</a>
    /// </summary>
    let isCallable = _prefixId.prefix "isCallable"
    /// <summary>
    ///   <para>rdfs:label : is exchangeable^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the security can be exchanged for another security at the issuers discretion^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isExchangeable">fibo-sec-dbt-dbti:isExchangeable</a>
    /// </summary>
    let isExchangeable = _prefixId.prefix "isExchangeable"
    /// <summary>
    ///   <para>rdfs:label : is extendable by holder^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the expiration date or maturity date can be extended by the holder^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isExtendableByHolder">fibo-sec-dbt-dbti:isExtendableByHolder</a>
    /// </summary>
    let isExtendableByHolder = _prefixId.prefix "isExtendableByHolder"
    /// <summary>
    ///   <para>rdfs:label : is extendable by issuer^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the issuer has the option to extend the debt rather than refinancing^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : If not, the issuer may only refinance the debt by calling the issue and creating a new issue.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isExtendableByIssuer">fibo-sec-dbt-dbti:isExtendableByIssuer</a>
    /// </summary>
    let isExtendableByIssuer = _prefixId.prefix "isExtendableByIssuer"
    /// <summary>
    ///   <para>rdfs:label : is putable^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the holder has the right to ask for redemption of the security prior to final maturity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isPutable">fibo-sec-dbt-dbti:isPutable</a>
    /// </summary>
    let isPutable = _prefixId.prefix "isPutable"
    /// <summary>
    ///   <para>rdfs:label : is strippable^^xsd:string</para>
    ///   <para>skos:definition : indicates whether or not the instrument can be stripped, so that interest and principal may be traded separately^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isStrippable">fibo-sec-dbt-dbti:isStrippable</a>
    /// </summary>
    let isStrippable = _prefixId.prefix "isStrippable"
    /// <summary>
    ///   <para>rdfs:label : is subordinated^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the security is a subordinated security, meaning that the security has a lower priority than another security so that when the assets are liquidated this one is not first in line^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isSubordinated">fibo-sec-dbt-dbti:isSubordinated</a>
    /// </summary>
    let isSubordinated = _prefixId.prefix "isSubordinated"
    /// <summary>
    ///   <para>rdfs:label : is subordinated to^^xsd:string</para>
    ///   <para>skos:definition : indicates the target security (i.e., the one in the range) has a higher priority than the security in question^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/isSubordinatedTo">fibo-sec-dbt-dbti:isSubordinatedTo</a>
    /// </summary>
    let isSubordinatedTo = _prefixId.prefix "isSubordinatedTo"
