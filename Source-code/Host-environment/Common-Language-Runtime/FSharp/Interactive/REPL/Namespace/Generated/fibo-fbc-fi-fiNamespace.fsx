#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-fi-fi`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/" "fibo-fbc-fi-fi"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : calculation agent</para>
    ///   <para>skos:definition : party that is responsible for determining the value of an instrument and in some cases, determines how much the parties owe one another</para>
    ///   <para>cmns-av:explanatoryNote : A calculation agent is an entity responsible for performing calculations and determinations outlined in financial agreements, often related to derivatives or structured products. They ensure accuracy and timeliness in calculating payments, interest rates, or other terms based on predefined formulas and market conditions. The agent can establish the price for a given instrument and may act as its guarantor and issuer. If the counterparty in a derivative transaction is a broker-dealer, then the broker-dealer will often act as the calculation agent.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/CalculationAgent">fibo-fbc-fi-fi:CalculationAgent</a>
    /// </summary>
    let CalculationAgent = _prefixId.prefix "CalculationAgent"
    /// <summary>
    ///   <para>rdfs:label : cash instrument^^xsd:string</para>
    ///   <para>skos:definition : financial instrument whose value is determined by the market and that is readily transferable (highly liquid)^^xsd:string</para>
    ///   <para>skos:scopeNote : Cash instruments can be classified into two subgroups, as securities and other cash instruments such as loans and deposits.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/CashInstrument">fibo-fbc-fi-fi:CashInstrument</a>
    /// </summary>
    let CashInstrument = _prefixId.prefix "CashInstrument"
    /// <summary>
    ///   <para>rdfs:label : commodity instrument^^xsd:string</para>
    ///   <para>skos:definition : financial instrument representing an ownership interest in bulk goods, such as raw materials and primary agricultural products^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of Financial Instruments (CFI code), Fourth edition, 2019-10.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The value of the contract is derived from the market value of an underlying commodity or commodity index. Commodity derivatives can be physically or cash settled. Primary underliers include metals, agricultural goods and energy.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/CommodityInstrument">fibo-fbc-fi-fi:CommodityInstrument</a>
    /// </summary>
    let CommodityInstrument = _prefixId.prefix "CommodityInstrument"
    /// <summary>
    ///   <para>rdfs:label : currency instrument^^xsd:string</para>
    ///   <para>skos:definition : financial instrument used for the purposes of currency trading^^xsd:string</para>
    ///   <para>skos:example : Example currencies include UK pounds, US dollars, Euro. An example currency instrument is spot currency instrument.^^xsd:string</para>
    ///   <para>skos:scopeNote : Each instance of a currency instrument has a one to one relationship with its associated currency.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Parameswaran, Sunil. Fundamentals of Financial Instruments: An Introduction to Stocks, Bonds, Foreign Exchange, and Derivatives. John Wiley and Sons (Asia) Pte. Lte., Singapore, 2011.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/CurrencyInstrument">fibo-fbc-fi-fi:CurrencyInstrument</a>
    /// </summary>
    let CurrencyInstrument = _prefixId.prefix "CurrencyInstrument"
    /// <summary>
    ///   <para>rdfs:label : debt instrument^^xsd:string</para>
    ///   <para>skos:definition : financial instrument and credit agreement evidencing monies owed by the issuer to the holder on terms as specified^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of Financial Instruments (CFI code), Fourth edition, 2019-10.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/DebtInstrument">fibo-fbc-fi-fi:DebtInstrument</a>
    /// </summary>
    let DebtInstrument = _prefixId.prefix "DebtInstrument"
    /// <summary>
    ///   <para>rdfs:label : derivative instrument^^xsd:string</para>
    ///   <para>skos:definition : financial instrument that confers on its holders certain rights or obligations, whose value is derived from one or more underlying assets^^xsd:string</para>
    ///   <para>skos:example : The three major categories of derivatives are (1) forward and future contracts, (2) options contracts, and (3) swaps. The most common underlying assets include stocks, bonds, commodities, currencies, interest rates and market indexes.^^xsd:string</para>
    ///   <para>skos:scopeNote : Derivatives can be characterized by whether they are exchange-traded or traded over-the-counter (OTC).^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Parameswaran, Sunil. Fundamentals of Financial Instruments: An Introduction to Stocks, Bonds, Foreign Exchange, and Derivatives. John Wiley and Sons (Asia) Pte. Lte., Singapore, 2011.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Derivative contracts owe their availability to the existence of markets for an underlying asset or a portfolio of assets on which such agreements are written. The derivative itself is merely a contract between two or more parties. Its value is determined by fluctuations in the underlying asset. Most derivatives are characterized by high leverage.^^xsd:string</para>
    ///   <para>cmns-av:synonym : derivative contract^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/DerivativeInstrument">fibo-fbc-fi-fi:DerivativeInstrument</a>
    /// </summary>
    let DerivativeInstrument = _prefixId.prefix "DerivativeInstrument"
    /// <summary>
    ///   <para>rdfs:label : entitlement^^xsd:string</para>
    ///   <para>skos:definition : financial instrument that provides the holder an interest in, or the privilege to subscribe to, or to receive specific assets under terms specified^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of Financial Instruments (CFI code), Fourth edition, 2019-10.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that certain fund units, including but not limited to units in pension funds and other non-public investment structures may be considered entitlements but not securities. They may or may not be identified using traditional financial instrument identifiers. Some entitlements, such as warrants, whose value changes based on the value of some underlier, are considered derivative instruments.^^xsd:string</para>
    ///   <para>cmns-av:synonym : right^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Entitlement">fibo-fbc-fi-fi:Entitlement</a>
    /// </summary>
    let Entitlement = _prefixId.prefix "Entitlement"
    /// <summary>
    ///   <para>rdfs:label : equity instrument^^xsd:string</para>
    ///   <para>skos:definition : financial instrument representing an ownership interest in an entity or pool of assets^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of Financial Instruments (CFI code), Fourth edition, 2019-10.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/EquityInstrument">fibo-fbc-fi-fi:EquityInstrument</a>
    /// </summary>
    let EquityInstrument = _prefixId.prefix "EquityInstrument"
    /// <summary>
    ///   <para>rdfs:label : exempt security^^xsd:string</para>
    ///   <para>skos:definition : security that is exempt from certain regulatory rules^^xsd:string</para>
    ///   <para>skos:example : Some exemptions from the registration requirement include: private offerings to a limited number of persons or institutions; offerings of limited size; intrastate offerings; and securities of municipal, state, and federal governments.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Securities Act of 1933^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Generally, securities must be filed with the appropriate regulatory agencies in the jurisdiction in which they are sold. The registration forms companies file provide essential facts while minimizing the burden and expense of complying with the law. Not all securities must be registered, however. By exempting many small offerings from the registration process, regulators seek to foster capital formation by lowering the cost of offering securities to the public.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/ExemptSecurity">fibo-fbc-fi-fi:ExemptSecurity</a>
    /// </summary>
    let ExemptSecurity = _prefixId.prefix "ExemptSecurity"
    /// <summary>
    ///   <para>rdfs:label : financial instrument^^xsd:string</para>
    ///   <para>skos:definition : written contract that gives rise to both a financial asset of one entity and a financial liability of another entity^^xsd:string</para>
    ///   <para>skos:example : Examples of financial instruments include: cash, evidence of an ownership interest in an entity, or a contractual right to receive (or deliver) cash, or another financial instrument.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ifrs.org/content/dam/ifrs/publications/pdf-standards/english/2021/issued/part-a/ias-32-financial-instruments-presentation.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : A financial instrument can be thought of as a template that defines an arrangement structure that remains to be fleshed out with terms and parameters in order to establish a specific instance of the contract.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/FinancialInstrument">fibo-fbc-fi-fi:FinancialInstrument</a>
    /// </summary>
    let FinancialInstrument = _prefixId.prefix "FinancialInstrument"
    /// <summary>
    ///   <para>rdfs:label : financial instrument identifier^^xsd:string</para>
    ///   <para>skos:definition : sequence of characters uniquely identifying a financial instrument for some purpose and within a specified context^^xsd:string</para>
    ///   <para>skos:scopeNote : Identifiers for financial instruments may include an ISIN, Sedol, CUSIP, BBGID, FIGI, or other identifier issued approximately when the instrument itself is issued, and based on the kind of instrument and jurisdiction in which it is issued.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/FinancialInstrumentIdentifier">fibo-fbc-fi-fi:FinancialInstrumentIdentifier</a>
    /// </summary>
    let FinancialInstrumentIdentifier = _prefixId.prefix "FinancialInstrumentIdentifier"
    /// <summary>
    ///   <para>rdfs:label : future^^xsd:string</para>
    ///   <para>skos:definition : derivative instrument that obligates the buyer to receive and the seller to deliver the assets specified at an agreed price, at some later point in time^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of Financial Instruments (CFI code), Fourth edition, 2019-10.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Future">fibo-fbc-fi-fi:Future</a>
    /// </summary>
    let Future = _prefixId.prefix "Future"
    /// <summary>
    ///   <para>rdfs:label : issuer^^xsd:string</para>
    ///   <para>skos:definition : role of a party that issues (or proposes to issue in a formal filing) one or more financial instruments^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Securities Exchange Act of 1934, as amended 12 August 2012^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : An issuer can be any legal person, including a legally competent natural person, company, government, or political subdivision, agency, or instrumentality of a government, depending on the nature of the instrument. A person might provide a loan directly to another party, but most instruments are issued by legal entities.^^xsd:stringcmns-av:explanatoryNote : With respect to certificates of deposit for securities, voting-trust certificates, or collateral- trust certificates, or with respect to certificates of interest or shares in an unincorporated investment trust not having a board of directors or of the fixed, restricted management, or unit type, the term issuer means the person or persons performing the acts and assuming the duties of depositor or manager pursuant to the provisions of the trust or other agreement or instrument under which such securities are issued; and except that with respect to equipment-trust certificates or like securities, the term issuer means the person by whom the equipment or property is, or is to be, used.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Issuer">fibo-fbc-fi-fi:Issuer</a>
    /// </summary>
    let Issuer = _prefixId.prefix "Issuer"
    /// <summary>
    ///   <para>rdfs:label : negotiable security^^xsd:string</para>
    ///   <para>skos:definition : security that can be transferred to another party^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/NegotiableSecurity">fibo-fbc-fi-fi:NegotiableSecurity</a>
    /// </summary>
    let NegotiableSecurity = _prefixId.prefix "NegotiableSecurity"
    /// <summary>
    ///   <para>rdfs:label : non-negotiable security^^xsd:string</para>
    ///   <para>skos:definition : security that is not transferable to another party^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Certain securities that can be redeemed by the issuer may not be 'negotiable', such as savings bonds and certificates of deposit.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/NonNegotiableSecurity">fibo-fbc-fi-fi:NonNegotiableSecurity</a>
    /// </summary>
    let NonNegotiableSecurity = _prefixId.prefix "NonNegotiableSecurity"
    /// <summary>
    ///   <para>rdfs:label : option^^xsd:string</para>
    ///   <para>skos:definition : derivative instrument that grants to the holder either the privilege to purchase or the privilege to sell the assets specified at a predetermined price or formula at or within a time period in the future^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of Financial Instruments (CFI code), Fourth edition, 2019-10.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Option">fibo-fbc-fi-fi:Option</a>
    /// </summary>
    let Option = _prefixId.prefix "Option"
    /// <summary>
    ///   <para>rdfs:label : packaged financial product^^xsd:string</para>
    ///   <para>skos:definition : financial product that acts as a container for at least one financial instrument, including other financial products, and whose value is derived from, or based on a reference asset, market measure, or investment strategy^^xsd:string</para>
    ///   <para>skos:scopeNote : Packaged products are typically included in an institution's approved product catalog, i.e., pre-approved by compliance organizations for sale to clients. Not all institutions maintain such a catalog, with internal identifiers for such products, but many do. Such core products may have as attributes: Type (product and possibly asset class), product identifier, status and approval date, product family approval (as appropriate), and so forth.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Certain properties of the instruments, such as their term, interest rate, eligibility of the client, etc., may be set as a part of the product specification. Some of these are intrinsic but variable properties of the instrument, for example the exact interest rate, whereas others are extrinsic, such as client eligibility. Product offerings have prices, which may build in various fees, that are components of the cost of carry on a trader's books.^^xsd:stringcmns-av:explanatoryNote : Reference assets and market measures may include single equity or debt securities, indexes, commodities, interest rates and/or foreign currencies, as well as baskets of these reference assets or market measures. Like other well-known market instruments such as convertible bonds, many structured products are hybrid securities. Structured products typically have two components - a debt instrument and a derivative, which is often an option. The debt instrument, in some instances, may pay interest at a specified rate and interval. The derivative component establishes payment at maturity, which may give the issuer the right to buy from you, or sell you, the referenced security or securities at a predetermined price. For example, structured products may combine characteristics of debt and equity or of debt and commodities.^^xsd:stringcmns-av:explanatoryNote : SEC Rule 434 defines structured securities as 'securities whose cash flow characteristics depend upon one or more indices or that have embedded forwards or options or securities where an investor's investment return and the issuer's payment obligations are contingent on, or highly sensitive to, changes in the value of underlying assets, indices, interest rates or cash flows'.^^xsd:string</para>
    ///   <para>cmns-av:synonym : market-linked investment^^xsd:stringcmns-av:synonym : structured product^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/PackagedFinancialProduct">fibo-fbc-fi-fi:PackagedFinancialProduct</a>
    /// </summary>
    let PackagedFinancialProduct = _prefixId.prefix "PackagedFinancialProduct"
    /// <summary>
    ///   <para>rdfs:label : promissory note^^xsd:string</para>
    ///   <para>skos:definition : debt instrument that is a written promise by one party to another that commits that party to pay a specified sum on demand or within a specified time frame under specified terms^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Promissory notes are generally fully fungible. They may or may not be negotiable.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/PromissoryNote">fibo-fbc-fi-fi:PromissoryNote</a>
    /// </summary>
    let PromissoryNote = _prefixId.prefix "PromissoryNote"
    /// <summary>
    ///   <para>rdfs:label : redemption provision^^xsd:string</para>
    ///   <para>skos:definition : contract provision enabling the issuer (writer) to regain possession through repayment of some stipulated price^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In general, redemption is synonymous with 'buy back' or 'cash in', depending on the kind of instrument. Redemption provisions are commonly applicable to the process of annulling a defeasible title, such as for a mortgage or tax sale, by paying the debt or fulfilling an obligation.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/RedemptionProvision">fibo-fbc-fi-fi:RedemptionProvision</a>
    /// </summary>
    let RedemptionProvision = _prefixId.prefix "RedemptionProvision"
    /// <summary>
    ///   <para>rdfs:label : securities transaction^^xsd:string</para>
    ///   <para>skos:definition : transaction between two or more parties involving the exchange of commonly defined financial products^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 23897:2020, Financial services - Unique transaction identifier (UTI), clause 3.3^^xsd:string</para>
    ///   <para>cmns-av:synonym : financial transaction^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/SecuritiesTransaction">fibo-fbc-fi-fi:SecuritiesTransaction</a>
    /// </summary>
    let SecuritiesTransaction = _prefixId.prefix "SecuritiesTransaction"
    /// <summary>
    ///   <para>rdfs:label : security^^xsd:string</para>
    ///   <para>skos:definition : financial instrument that can be bought or sold^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Securities Exchange Act of 1934, as amended 12 August 2012^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A security can be any note, stock, treasury stock, security future, security-based swap, bond, debenture,certificate of interest or participation in any profit-sharing agreement or in any oil, gas, or other mineral royalty or lease, any collateral-trust certificate, preorganization certificate or subscription, transferable share, investment contract, voting-trust certificate, certificate of deposit for a security, any put, call, straddle, option, or privilege on any security, certificate of deposit, or group or index of securities (including any interest therein or based on the value thereof), or any put, call, straddle, option, or privilege entered into on a national securities exchange relating to foreign currency, or in general, any instrument commonly known as a security, or any certificate of interest or participation in, temporary or interim certificate for, receipt for, or warrant or right to subscribe to or purchase, any of the foregoing; but shall not include currency or any note, draft, bill of exchange, or bankers' acceptance which has a maturity at the time of issuance of not exceeding nine months, exclusive of days of grace, or any renewal thereof the maturity of which is likewise limited.^^xsd:stringcmns-av:explanatoryNote : In the U.S., the Supreme Court has adopted a flexible and liberal approach in determining what constitutes a security. In its famous decision of SEC v. W.J. Howey Co., 328 U.S. 293, 90 L.Ed. 1244, 66 S.Ct. 1100 (1946), the Court held that land sales contracts for citrus groves in Florida, coupled with warranty deeds for the land and a contract to service the land, were 'investment contracts' and thus securities. The Court stated that [a]n investment contract for purposes of the Securities Act means a contract, transaction or scheme whereby a person invests his money in a common enterprise and is led to expect profits solely from the efforts of the promoter or a third party. 66 S.Ct. at 1103. According to the Court, it is immaterial whether the shares in the enterprise are evidenced by formal certificates or by nominal interests in the physical assets employed in the enterprise. 66 S.Ct. at 1104.^^xsd:stringcmns-av:explanatoryNote : Some securities may be traded over the counter, or through an exchange, or via some other trading venue such as an electronic trading platform.^^xsd:stringcmns-av:explanatoryNote : Whether a contract or other economic right is a security essentially depends on whether the holder of the contract is acting as an investor who seeks financial benefits based on the work of a promoter or a third party.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Security">fibo-fbc-fi-fi:Security</a>
    /// </summary>
    let Security = _prefixId.prefix "Security"
    /// <summary>
    ///   <para>rdfs:label : spot contract</para>
    ///   <para>skos:definition : financial instrument that settles for immediate delivery on a specified date</para>
    ///   <para>cmns-av:explanatoryNote : A spot transaction is a transaction in which some goods or instrument(s) are exchanged for some other goods or instruments, including currency, with no future delivery provision, i.e., within the minimum number of days possible. Examples include currency spots and commodity spot transactions, whose settlement convention is determined by the relevant market.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/SpotContract">fibo-fbc-fi-fi:SpotContract</a>
    /// </summary>
    let SpotContract = _prefixId.prefix "SpotContract"
    /// <summary>
    ///   <para>rdfs:label : standardized terms^^xsd:string</para>
    ///   <para>skos:definition : contract terms that, grouped together, that are generally and consistently reused across many contracts, published by some organization, and capable of being incorporated into a contract by reference^^xsd:string</para>
    ///   <para>skos:example : Each exchange has a set of terms they apply to membership agreements and with respect to the instruments that may be traded on that exchange. For example, there is a set expiration date that exchanges will publish for exchange-traded options - in the US it is the Saturday following the third Friday of every month. Similarly, there are set incremental dates for strike for exchange traded options. Contract sizes are also stipulated, for example in the US these are standardized by the OPRA Convention (Options Pricing Reporting Authority).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/StandardizedTerms">fibo-fbc-fi-fi:StandardizedTerms</a>
    /// </summary>
    let StandardizedTerms = _prefixId.prefix "StandardizedTerms"
    /// <summary>
    ///   <para>rdfs:label : underlier^^xsd:string</para>
    ///   <para>skos:definition : something that can be assigned a value in the marketplace that forms the basis for a derivative or pool-backed instrument^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Underlier means any rate (including interest and foreign exchange rates), currency, commodity, security, instrument of indebtedness, index, quantitative measure, occurrence or non-occurrence of an event, or other financial or economic interest, or property of any kind, or any interest therein or based on the value thereof, in or by reference to which any payment or delivery under a transaction is to be made or determined.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Underlier">fibo-fbc-fi-fi:Underlier</a>
    /// </summary>
    let Underlier = _prefixId.prefix "Underlier"
    /// <summary>
    ///   <para>rdfs:label : has buying currency</para>
    ///   <para>skos:definition : indicates the currency purchased with respect to a currency or related instrument</para>
    ///   <para>cmns-av:explanatoryNote : Note that the buying and selling currencies could be the same under certain circumstances.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasBuyingCurrency">fibo-fbc-fi-fi:hasBuyingCurrency</a>
    /// </summary>
    let hasBuyingCurrency = _prefixId.prefix "hasBuyingCurrency"
    /// <summary>
    ///   <para>rdfs:label : has calculation agent</para>
    ///   <para>skos:definition : indicates a party (role) responsible for determining the value of an instrument^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasCalculationAgent">fibo-fbc-fi-fi:hasCalculationAgent</a>
    /// </summary>
    let hasCalculationAgent = _prefixId.prefix "hasCalculationAgent"

    /// <summary>
    ///   <para>rdfs:label : has commodity value as of execution date^^xsd:string</para>
    ///   <para>skos:definition : indicates the per unit value of a given commodity as of the date that the contract is executed^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasCommodityValueAsOfExecutionDate">fibo-fbc-fi-fi:hasCommodityValueAsOfExecutionDate</a>
    /// </summary>
    let hasCommodityValueAsOfExecutionDate =
        _prefixId.prefix "hasCommodityValueAsOfExecutionDate"

    /// <summary>
    ///   <para>rdfs:label : has nominal value^^xsd:string</para>
    ///   <para>skos:definition : indicates the face value of a contract^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Nominal value of a security is its redemption price and will vary from its market value. A preferred stock's nominal (par) value is important in that it is used to calculate its dividend while the nominal value of common stock is an arbitrary value assigned for balance sheet purposes.^^xsd:stringcmns-av:explanatoryNote : The nominal amount of a financial instrument is the face amount used to calculate payments made on that instrument. This amount generally does not change.
    ///
    /// 		For securities the nominal value is often referred to as the face or par value. This is the redemption price of the security and is normally stated on the front of that security. With respect to bonds and stocks, it is the stated value of an issued security, as opposed to its market value.^^xsd:string</para>
    ///   <para>cmns-av:synonym : has face value^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasNominalValue">fibo-fbc-fi-fi:hasNominalValue</a>
    /// </summary>
    let hasNominalValue = _prefixId.prefix "hasNominalValue"

    /// <summary>
    ///   <para>rdfs:label : has principal executive office address^^xsd:string</para>
    ///   <para>skos:definition : relates an organization, specifically the issuer of a financial instrument, to its principal executive address, as required for issuance of that instrument^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that in most cases, the principal executive office address is also the headquarters address for a company.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasPrincipalExecutiveOfficeAddress">fibo-fbc-fi-fi:hasPrincipalExecutiveOfficeAddress</a>
    /// </summary>
    let hasPrincipalExecutiveOfficeAddress =
        _prefixId.prefix "hasPrincipalExecutiveOfficeAddress"

    /// <summary>
    ///   <para>rdfs:label : has redemption terms^^xsd:string</para>
    ///   <para>skos:definition : indicates the specific terms related to redemption as specified in the instrument or a related contract document^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasRedemptionProvision">fibo-fbc-fi-fi:hasRedemptionProvision</a>
    /// </summary>
    let hasRedemptionProvision = _prefixId.prefix "hasRedemptionProvision"
    /// <summary>
    ///   <para>rdfs:label : has selling currency</para>
    ///   <para>skos:definition : indicates the currency sold with respect to a currency or related instrument</para>
    ///   <para>cmns-av:explanatoryNote : Note that the buying and selling currencies could be the same under certain circumstances.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasSellingCurrency">fibo-fbc-fi-fi:hasSellingCurrency</a>
    /// </summary>
    let hasSellingCurrency = _prefixId.prefix "hasSellingCurrency"
    /// <summary>
    ///   <para>rdfs:label : has shareholder^^xsd:string</para>
    ///   <para>skos:definition : indicates a party that holds shares in the issuer^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasShareholder">fibo-fbc-fi-fi:hasShareholder</a>
    /// </summary>
    let hasShareholder = _prefixId.prefix "hasShareholder"
    /// <summary>
    ///   <para>rdfs:label : has underlier^^xsd:string</para>
    ///   <para>skos:definition : relates a derivative to something on which the contract is based^^xsd:string</para>
    ///   <para>cmns-av:usageNote : The domain of this property can be either a derivative instrument or, in the case of a swap contract, one leg of the swap.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasUnderlier">fibo-fbc-fi-fi:hasUnderlier</a>
    /// </summary>
    let hasUnderlier = _prefixId.prefix "hasUnderlier"
    /// <summary>
    ///   <para>rdfs:label : has value expressed in^^xsd:string</para>
    ///   <para>skos:definition : relates something, such as an instrument or index, to the currency its value is typically expressed in^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This should be the same currency that was declared at the time of issuance.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasValueExpressedIn">fibo-fbc-fi-fi:hasValueExpressedIn</a>
    /// </summary>
    let hasValueExpressedIn = _prefixId.prefix "hasValueExpressedIn"
    /// <summary>
    ///   <para>rdfs:label : holds shares in^^xsd:string</para>
    ///   <para>skos:definition : specifies the issuer in which a shareholder holds an equity position^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/holdsSharesIn">fibo-fbc-fi-fi:holdsSharesIn</a>
    /// </summary>
    let holdsSharesIn = _prefixId.prefix "holdsSharesIn"
    /// <summary>
    ///   <para>rdfs:label : is denominated in^^xsd:string</para>
    ///   <para>skos:definition : indicates the currency in which the financial instrument was issued^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/isDenominatedIn">fibo-fbc-fi-fi:isDenominatedIn</a>
    /// </summary>
    let isDenominatedIn = _prefixId.prefix "isDenominatedIn"
    /// <summary>
    ///   <para>rdfs:label : is legally recorded in^^xsd:string</para>
    ///   <para>skos:definition : jurisdiction (country, county, state, province, city) in which the financial instrument is legally recorded for regulatory and/or tax purposes^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/isLegallyRecordedIn">fibo-fbc-fi-fi:isLegallyRecordedIn</a>
    /// </summary>
    let isLegallyRecordedIn = _prefixId.prefix "isLegallyRecordedIn"
    /// <summary>
    ///   <para>rdfs:label : is negotiable^^xsd:string</para>
    ///   <para>skos:definition : specifies whether a particular financial instrument is or is not transferable^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/isNegotiable">fibo-fbc-fi-fi:isNegotiable</a>
    /// </summary>
    let isNegotiable = _prefixId.prefix "isNegotiable"
