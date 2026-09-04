#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-der-drc-bsc`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/" "fibo-der-drc-bsc"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : cashflow expression^^xsd:string</para>
    ///   <para>skos:definition : expression that specifies a calculation of a cash flow as a component of a cashflow formula^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CashflowExpression">fibo-der-drc-bsc:CashflowExpression</a>
    /// </summary>
    let CashflowExpression = _prefixId.prefix "CashflowExpression"
    /// <summary>
    ///   <para>rdfs:label : cashflow formula^^xsd:string</para>
    ///   <para>skos:definition : formula for determining cashflows for a derivative instrument^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CashflowFormula">fibo-der-drc-bsc:CashflowFormula</a>
    /// </summary>
    let CashflowFormula = _prefixId.prefix "CashflowFormula"
    /// <summary>
    ///   <para>rdfs:label : cashflow terms^^xsd:string</para>
    ///   <para>skos:definition : terms setting out a cashflow structure of payments committed to by one party to a contract^^xsd:string</para>
    ///   <para>skos:editorialNote : Swap cashflows are known as Swapstreams and are the terms for payment to and from either party. These are defined in swap transaction messages and represent the terms of the contract implied by that transaction. Options (Nordea reviews): Cashflows are defined as Payouts. This is not the same as a model of a cashflow which is a consequence of applying some legal term for payment of interest or principal, but is a commitment expressed in purely cashflow terms. Review this though. Payout terms include: Values - values can only go up or down; Static values are defined for limits and the like. i.e. Constraints (and direction) - this covers caps and floors - these are read upward or downward Conditionality Formula relations (Input and Output): - these are values - these may have a cap or a floor on them also - these also may have Multiplication - there is also fixed margin - may have addition or substraction between these Linearity in covered in the above Timing / expiry Observaton (not terms): Probability Sensitivity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CashflowTerms">fibo-der-drc-bsc:CashflowTerms</a>
    /// </summary>
    let CashflowTerms = _prefixId.prefix "CashflowTerms"
    /// <summary>
    ///   <para>rdfs:label : contract for difference</para>
    ///   <para>skos:definition : cash-settled derivative where the parties agree to exchange on the maturity of the contract the difference between the current value of the underlying asset and the initial value of that asset when the contract is initiated</para>
    ///   <para>skos:example : For example, suppose the initial price of share XYZ is $100 and a CFD for 1000 shares is exchanged. Both the buyer and seller must post some margin. If the price goes to $105, then the buyer gets $5,000 from the seller. If the price goes to $95, the buyer pays the seller $5,000. This contract avoids ownership of the stock and all the associated transactions issues (like stamp taxes). The contract also allows for leverage (typically 10:1) because the margin that must be posted is only a fraction of the value of the underlying asset.</para>
    ///   <para>cmns-av:abbreviation : CFD</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962:2019, Securities and related financial instruments - Classification of financial instruments (CFI) code^^xsd:stringcmns-av:adaptedFrom : https://www.nasdaq.com/glossary/c/contract-for-difference^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : These contracts can also be on the difference of two assets' prices. They can also be on the difference of a single asset of different maturities (like a bond or futures contracts).</para>
    ///   <para>cmns-av:synonym : spread trading</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ContractForDifference">fibo-der-drc-bsc:ContractForDifference</a>
    /// </summary>
    let ContractForDifference = _prefixId.prefix "ContractForDifference"
    /// <summary>
    ///   <para>rdfs:label : credit derivative</para>
    ///   <para>skos:definition : derivative instrument that is a privately held, negotiable bilateral contract traded over-the-counter (OTC) between two parties in a creditor/debtor relationship, enabling the creditor to effectively transfer some or all of the risk of a debtor defaulting to a third party</para>
    ///   <para>skos:example : Examples include credit default swaps (CDS), collateralized debt obligations (CDO), total return swaps, and credit spread options and forwards.</para>
    ///   <para>cmns-av:explanatoryNote : The third party accepts the risk in return for payment, known as the premium.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CreditDerivative">fibo-der-drc-bsc:CreditDerivative</a>
    /// </summary>
    let CreditDerivative = _prefixId.prefix "CreditDerivative"
    /// <summary>
    ///   <para>rdfs:label : derivative settlement terms^^xsd:string</para>
    ///   <para>skos:definition : settlement terms specifying additional details with respect to what is to be delivered when, to whom, under what conditions at the time of settlement^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/DerivativeSettlementTerms">fibo-der-drc-bsc:DerivativeSettlementTerms</a>
    /// </summary>
    let DerivativeSettlementTerms = _prefixId.prefix "DerivativeSettlementTerms"
    /// <summary>
    ///   <para>rdfs:label : derivative terms^^xsd:string</para>
    ///   <para>skos:definition : contractual terms specific to derivative contracts, including terms related to payments and delivery between parties^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/DerivativeTerms">fibo-der-drc-bsc:DerivativeTerms</a>
    /// </summary>
    let DerivativeTerms = _prefixId.prefix "DerivativeTerms"

    /// <summary>
    ///   <para>rdfs:label : derivatives clearing organization^^xsd:string</para>
    ///   <para>skos:definition : clearing house that enables parties to substitute the credit of the DCO for the credit of the parties^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : DCO^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.cftc.gov/IndustryOversight/ClearingOrganizations/index.htm^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Substitution may be done through contract novation, for example. A derivatives clearing organization (DCO) also arranges or provides, on a multilateral basis, for the settlement or netting of obligations, or otherwise provides clearing services or arrangements that mutualize or transfer credit risk among participants.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/DerivativesClearingOrganization">fibo-der-drc-bsc:DerivativesClearingOrganization</a>
    /// </summary>
    let DerivativesClearingOrganization =
        _prefixId.prefix "DerivativesClearingOrganization"

    /// <summary>
    ///   <para>rdfs:label : economic rate-based derivative^^xsd:string</para>
    ///   <para>skos:definition : rate-based derivative whose underlier is some economic indicator^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/EconomicRateBasedDerivative">fibo-der-drc-bsc:EconomicRateBasedDerivative</a>
    /// </summary>
    let EconomicRateBasedDerivative = _prefixId.prefix "EconomicRateBasedDerivative"
    /// <summary>
    ///   <para>rdfs:label : forward rate agreement</para>
    ///   <para>skos:definition : agreement to exchange an interest rate commitment on a notional amount at a future date</para>
    ///   <para>cmns-av:abbreviation : FRA</para>
    ///   <para>cmns-av:explanatoryNote : The FRA determines the rates to be used along with the termination date and notional value. FRAs are cash-settled with the payment based on the net difference between the interest rate of the contract and the floating rate in the market called the reference rate. The notional amount is not exchanged, but rather a cash amount based on the rate differentials and the notional value of the contract.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ForwardRateAgreement">fibo-der-drc-bsc:ForwardRateAgreement</a>
    /// </summary>
    let ForwardRateAgreement = _prefixId.prefix "ForwardRateAgreement"
    /// <summary>
    ///   <para>rdfs:label : interest rate derivative^^xsd:string</para>
    ///   <para>skos:definition : rate-based derivative whose underlier is an interest rate^^xsd:string</para>
    ///   <para>skos:example : For example, interest rate derivative strategies are the simultaneous trading of two or more rate contracts in which two counterparties agree to exchange interest rate cash flows on defined dates during an agreed period, based on a specified notional amount, from a fixed rate to a floating rate, floating to fixed, fixed to fixed, or floating to floating.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962:2019, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth edition, 2019-10^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/InterestRateDerivative">fibo-der-drc-bsc:InterestRateDerivative</a>
    /// </summary>
    let InterestRateDerivative = _prefixId.prefix "InterestRateDerivative"
    /// <summary>
    ///   <para>rdfs:label : introducing broker^^xsd:string</para>
    ///   <para>skos:definition : broker that solicits or accepts orders for derivatives that are traded on or subject to the rules of an exchange^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : IB^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.cftc.gov/IndustryOversight/Intermediaries/index.htm^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Introducing brokers do not accept money, securities, or property (or extend credit in lieu thereof) to margin, guarantee, or secure any trades or contracts that result or may result.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/IntroducingBroker">fibo-der-drc-bsc:IntroducingBroker</a>
    /// </summary>
    let IntroducingBroker = _prefixId.prefix "IntroducingBroker"
    /// <summary>
    ///   <para>rdfs:label : observable value^^xsd:string</para>
    ///   <para>skos:definition : specification for the value for something discernible and for which evidence can be obtained^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Derivatives, such as certain exotics, can be based on values ascribed to virtually anything, including weather. Typically, however, an observable value refers to something that can be readily observed in the marketplace, such as a quoted rate (e.g., interest rate, exchange rate), index value, commodity price, stock price, economic indicator, or something similar as of some point in time.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ObservableValue">fibo-der-drc-bsc:ObservableValue</a>
    /// </summary>
    let ObservableValue = _prefixId.prefix "ObservableValue"

    /// <summary>
    ///   <para>rdfs:label : over-the-counter derivative instrument^^xsd:string</para>
    ///   <para>dcterms:source : ISO 4914:2021(en), Financial services - Unique product identifier (UPI)^^xsd:string</para>
    ///   <para>skos:definition : derivative instrument that is not listed on an organized exchange^^xsd:string</para>
    ///   <para>skos:note : ISO 4914 defines an OTC derivative instrument as a financial instrument that is, or would be, identified by an ISIN with the prefix 'EZ' or 'ZZ'. Details regarding how the prefix of an ISIN is determined can be found in ISO 6166:2020, Annex A.^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : OTC derivative instrument^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/OverTheCounterDerivativeInstrument">fibo-der-drc-bsc:OverTheCounterDerivativeInstrument</a>
    /// </summary>
    let OverTheCounterDerivativeInstrument =
        _prefixId.prefix "OverTheCounterDerivativeInstrument"

    /// <summary>
    ///   <para>rdfs:label : over-the-counter instrument^^xsd:string</para>
    ///   <para>skos:definition : financial instrument and bilateral contract that is not listed on an organized exchange^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : OTC instrument^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/OverTheCounterInstrument">fibo-der-drc-bsc:OverTheCounterInstrument</a>
    /// </summary>
    let OverTheCounterInstrument = _prefixId.prefix "OverTheCounterInstrument"
    /// <summary>
    ///   <para>rdfs:label : parametric cashflow terms^^xsd:string</para>
    ///   <para>skos:definition : terms for a set of cashflows defined according to a mathematical formula^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ParametricCashflowTerms">fibo-der-drc-bsc:ParametricCashflowTerms</a>
    /// </summary>
    let ParametricCashflowTerms = _prefixId.prefix "ParametricCashflowTerms"
    /// <summary>
    ///   <para>rdfs:label : paying party^^xsd:string</para>
    ///   <para>skos:definition : party responsible for making payments in a transaction specified in a contract^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/PayingParty">fibo-der-drc-bsc:PayingParty</a>
    /// </summary>
    let PayingParty = _prefixId.prefix "PayingParty"
    /// <summary>
    ///   <para>rdfs:label : rate-based derivative^^xsd:string</para>
    ///   <para>skos:definition : derivative instrument where the holder has the right but may not have the obligation, depending on the nature of the instrument, to enter into the underlying contract, or pay or receive payment related to the underlying financial rate (or rate contract) on a specified future date based on a specified future rate and term^^xsd:string</para>
    ///   <para>skos:example : Examples of rate-based derivatives include interest rate swaps, forward rate agreements (FRAs), and interest rate options such as caps, floors, and collars.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962:2019, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth edition, 2019-10^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Rate-based derivatives derive their value from movements in some rate, e.g, an interest rate, market rate, economic indicator, statistical measure calculated over some collection of indices, rather than from traditional assets like stocks or commodities. They are commonly used by institutions to manage risks associated with interest rate fluctuations.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/RateBasedDerivative">fibo-der-drc-bsc:RateBasedDerivative</a>
    /// </summary>
    let RateBasedDerivative = _prefixId.prefix "RateBasedDerivative"
    /// <summary>
    ///   <para>rdfs:label : receiving counterparty^^xsd:string</para>
    ///   <para>skos:definition : party that receives payments in a transaction specified in a contract^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ReceivingParty">fibo-der-drc-bsc:ReceivingParty</a>
    /// </summary>
    let ReceivingParty = _prefixId.prefix "ReceivingParty"
    /// <summary>
    ///   <para>rdfs:label : underlying asset valuation</para>
    ///   <para>skos:definition : assessment activity to estimate the value of an underlying asset of a derivative</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UnderlyingAssetValuation">fibo-der-drc-bsc:UnderlyingAssetValuation</a>
    /// </summary>
    let UnderlyingAssetValuation = _prefixId.prefix "UnderlyingAssetValuation"
    /// <summary>
    ///   <para>rdfs:label : unique product identifier^^xsd:string</para>
    ///   <para>dcterms:source : ISO 4914:2021(en), Financial services - Unique product identifier (UPI)^^xsd:string</para>
    ///   <para>skos:definition : sequence of characters uniquely identifying an OTC derivative product that is reportable to a trade repository^^xsd:string</para>
    ///   <para>skos:scopeNote : At a minimum, the UPI code is applicable to OTC derivative instruments falling under the following categories of the Classification of Financial Instruments (ISO 10962):
    /// 		- Swaps (S)
    /// 		- Forwards (J)
    /// 		- Non-listed and complex listed options (H)
    /// 		- Others (miscellaneous) (M)^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : UPI^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The UPI code consists of 12 alphanumeric characters decomposed as follows:
    /// 		- the two-character prefix 'QZ'
    /// 		- nine alphanumeric characters (upper case A-Z and 0-9 only, excluding the vowel characters (A, E, I, O, U) and the character Y) without separators or special characters
    /// 		- one alphanumeric check character (A-Z and 0-9 only, excluding the vowel characters (A, E, I, O, U) and the character Y), calculated using the method specified in Annex C of the specification document.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UniqueProductIdentifier">fibo-der-drc-bsc:UniqueProductIdentifier</a>
    /// </summary>
    let UniqueProductIdentifier = _prefixId.prefix "UniqueProductIdentifier"

    let UniqueProductIdentifierReferenceDataLibrary =
        _prefixId.prefix "UniqueProductIdentifierReferenceDataLibrary"

    /// <summary>
    ///   <para>rdfs:label : unique product identifier registry entry^^xsd:string</para>
    ///   <para>skos:definition : entry in a unique product identifier registry^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The Reference Data Library (RDL) is a set of reference data elements, together with their values, which is properly organized and maintained by the UPI service provider. The library associates UPI codes with the values of the reference data elements characterizing the product. Each entry in the library (the registry entry) contains a minimum number of elements as defined in the ISO standard, and may be extended by the service provider.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UniqueProductIdentifierRegistryEntry">fibo-der-drc-bsc:UniqueProductIdentifierRegistryEntry</a>
    /// </summary>
    let UniqueProductIdentifierRegistryEntry =
        _prefixId.prefix "UniqueProductIdentifierRegistryEntry"

    /// <summary>
    ///   <para>rdfs:label : unique product identifier service provider^^xsd:string</para>
    ///   <para>dcterms:source : ISO 4914:2021(en), Financial services - Unique product identifier (UPI)^^xsd:string</para>
    ///   <para>skos:definition : organization designated by an external body of financial regulators to assign UPIs and operate a UPI reference data library^^xsd:string</para>
    ///   <para>skos:scopeNote : At the time of publication of the ISO 4914 standard, there was only one such provider, the Regulatory Oversight Committee, confirmed by the Financial Stability Board as the International Governance Body for globally harmonised identifiers used to track OTC derivatives transactions.^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : UPI service provider^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UniqueProductIdentifierServiceProvider">fibo-der-drc-bsc:UniqueProductIdentifierServiceProvider</a>
    /// </summary>
    let UniqueProductIdentifierServiceProvider =
        _prefixId.prefix "UniqueProductIdentifierServiceProvider"

    /// <summary>
    ///   <para>rdfs:label : valuation terms^^xsd:string</para>
    ///   <para>skos:definition : contract terms specific to valuation of the underlying asset(s)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ValuationTerms">fibo-der-drc-bsc:ValuationTerms</a>
    /// </summary>
    let ValuationTerms = _prefixId.prefix "ValuationTerms"
    /// <summary>
    ///   <para>rdfs:label : has accreting notional amount</para>
    ///   <para>skos:definition : indicates that the notional amount increases through the life of the contract^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962:2019, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10, clause 6.8.2^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasAccretingNotionalAmount">fibo-der-drc-bsc:hasAccretingNotionalAmount</a>
    /// </summary>
    let hasAccretingNotionalAmount = _prefixId.prefix "hasAccretingNotionalAmount"
    /// <summary>
    ///   <para>rdfs:label : has additional costs</para>
    ///   <para>skos:definition : indicates costs, such as up front costs, brokerage fees and the like, that must be paid on delivery</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasAdditionalCosts">fibo-der-drc-bsc:hasAdditionalCosts</a>
    /// </summary>
    let hasAdditionalCosts = _prefixId.prefix "hasAdditionalCosts"
    /// <summary>
    ///   <para>rdfs:label : has amortizing notional amount</para>
    ///   <para>skos:definition : indicates that the notional amount decreases through the life of the contract^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962:2019, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10, clause 6.8.2^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasAmortizingNotionalAmount">fibo-der-drc-bsc:hasAmortizingNotionalAmount</a>
    /// </summary>
    let hasAmortizingNotionalAmount = _prefixId.prefix "hasAmortizingNotionalAmount"
    /// <summary>
    ///   <para>rdfs:label : has constant notional amount</para>
    ///   <para>skos:definition : indicates that the notional amount is constant through the life of the contract^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962:2019, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10, clause 6.8.2^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasConstantNotionalAmount">fibo-der-drc-bsc:hasConstantNotionalAmount</a>
    /// </summary>
    let hasConstantNotionalAmount = _prefixId.prefix "hasConstantNotionalAmount"
    /// <summary>
    ///   <para>rdfs:label : has custom notional amount</para>
    ///   <para>skos:definition : indicates that the notional amount is customized per a notional step schedule^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962:2019, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10, clause 6.8.2^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasCustomNotionalAmount">fibo-der-drc-bsc:hasCustomNotionalAmount</a>
    /// </summary>
    let hasCustomNotionalAmount = _prefixId.prefix "hasCustomNotionalAmount"
    /// <summary>
    ///   <para>rdfs:label : has first delivery date</para>
    ///   <para>skos:definition : specifies the initial date in a range of dates by which the underlying asset (or some portion thereof) must be delivered in order for the terms of the contract to be fulfilled</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasFirstDeliveryDate">fibo-der-drc-bsc:hasFirstDeliveryDate</a>
    /// </summary>
    let hasFirstDeliveryDate = _prefixId.prefix "hasFirstDeliveryDate"
    /// <summary>
    ///   <para>rdfs:label : has first notice date</para>
    ///   <para>skos:definition : specifies the initial date on which a delivery notice can be issued</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasFirstNoticeDate">fibo-der-drc-bsc:hasFirstNoticeDate</a>
    /// </summary>
    let hasFirstNoticeDate = _prefixId.prefix "hasFirstNoticeDate"
    /// <summary>
    ///   <para>rdfs:label : has last delivery date</para>
    ///   <para>skos:definition : specifies the final date in a range of dates by which the underlying asset (or some portion thereof) must be delivered in order for the terms of the contract to be fulfilled</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasLastDeliveryDate">fibo-der-drc-bsc:hasLastDeliveryDate</a>
    /// </summary>
    let hasLastDeliveryDate = _prefixId.prefix "hasLastDeliveryDate"
    /// <summary>
    ///   <para>rdfs:label : has last notice date</para>
    ///   <para>skos:definition : specifies the final date on which a delivery notice can be issued</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasLastNoticeDate">fibo-der-drc-bsc:hasLastNoticeDate</a>
    /// </summary>
    let hasLastNoticeDate = _prefixId.prefix "hasLastNoticeDate"
    /// <summary>
    ///   <para>rdfs:label : has settlement terms</para>
    ///   <para>skos:definition : relates a derivative to contractual terms specific to the settlement process^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasSettlementTerms">fibo-der-drc-bsc:hasSettlementTerms</a>
    /// </summary>
    let hasSettlementTerms = _prefixId.prefix "hasSettlementTerms"
    /// <summary>
    ///   <para>rdfs:label : has tick value</para>
    ///   <para>skos:definition : indicates the cash value of one tick, i.e., the minimum price change of the contract</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasTickValue">fibo-der-drc-bsc:hasTickValue</a>
    /// </summary>
    let hasTickValue = _prefixId.prefix "hasTickValue"
    /// <summary>
    ///   <para>rdfs:label : has underlying asset price^^xsd:string</para>
    ///   <para>skos:definition : specifies a price for something on which the contract is based^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasUnderlyingAssetPrice">fibo-der-drc-bsc:hasUnderlyingAssetPrice</a>
    /// </summary>
    let hasUnderlyingAssetPrice = _prefixId.prefix "hasUnderlyingAssetPrice"
    /// <summary>
    ///   <para>rdfs:label : has valuation terms</para>
    ///   <para>skos:definition : relates a derivative to contractual terms specific to valuation of the underlying asset(s)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasValuationTerms">fibo-der-drc-bsc:hasValuationTerms</a>
    /// </summary>
    let hasValuationTerms = _prefixId.prefix "hasValuationTerms"
    /// <summary>
    ///   <para>rdfs:label : specifies value of</para>
    ///   <para>skos:definition : relates a derivative to contractual terms specific to valuation of the underlying asset(s)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/specifiesValueOf">fibo-der-drc-bsc:specifiesValueOf</a>
    /// </summary>
    let specifiesValueOf = _prefixId.prefix "specifiesValueOf"
