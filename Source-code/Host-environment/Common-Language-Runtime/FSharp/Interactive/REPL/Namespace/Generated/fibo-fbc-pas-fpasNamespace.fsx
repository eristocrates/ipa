#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-pas-fpas`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/" "fibo-fbc-pas-fpas"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : agency agreement^^xsd:string</para>
    ///   <para>skos:definition : agreement that designates a party as a registered agent to represent and act on behalf of another party in some, typically legal, financial, or medical capacity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/AgencyAgreement">fibo-fbc-pas-fpas:AgencyAgreement</a>
    /// </summary>
    let AgencyAgreement = _prefixId.prefix "AgencyAgreement"
    /// <summary>
    ///   <para>rdfs:label : agent for service of process^^xsd:string</para>
    ///   <para>skos:definition : registered agent (person or organization) designated by a business entity, such as a corporation, to receive legal correspondence on behalf of the business entity in the jurisdiction in which the agent's address is located^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The person may be an officer of the corporation or a third party, such as the corporation's attorney, or a company providing such agency services.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/AgentForServiceOfProcess">fibo-fbc-pas-fpas:AgentForServiceOfProcess</a>
    /// </summary>
    let AgentForServiceOfProcess = _prefixId.prefix "AgentForServiceOfProcess"
    let AmendedTrade = _prefixId.prefix "AmendedTrade"
    /// <summary>
    ///   <para>rdfs:label : basket^^xsd:string</para>
    ///   <para>skos:definition : collection of goods, services, or other things (e.g., financial contracts) that can be purchased and sold in some marketplace^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A basket may be associated with a specific market sector, and may be delineated for the purposes of statistical analysis, such as for calculating CPI. According to the US Bureau of Labor Statistics (BLS), with respect to the CPI, a market basket is a package of goods and services that consumers purchase for day-to-day living. The weight of each item is based on the amount of expenditure reported by a sample of households.^^xsd:stringcmns-av:explanatoryNote : From a securities perspective, a basket is a collection of products or securities that are designated to mimic the performance of a market. For investors, the market basket is the principal idea behind index funds, which are essentially a broad sample of stocks, bonds or other securities in the market; this provides investors with a benchmark against which to compare their investment returns.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Basket">fibo-fbc-pas-fpas:Basket</a>
    /// </summary>
    let Basket = _prefixId.prefix "Basket"
    /// <summary>
    ///   <para>rdfs:label : basket constituent^^xsd:string</para>
    ///   <para>skos:definition : component of a basket^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/BasketConstituent">fibo-fbc-pas-fpas:BasketConstituent</a>
    /// </summary>
    let BasketConstituent = _prefixId.prefix "BasketConstituent"
    /// <summary>
    ///   <para>rdfs:label : broker^^xsd:string</para>
    ///   <para>skos:definition : any party that acts as an intermediary between a buyer and a seller, usually charging a commission^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : 17 CFR 45.1, Definitions - see the definition of agent^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A broker that specializes in stocks, bonds, commodities, or certain derivatives must be registered with the exchange in which the securities are traded.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Broker">fibo-fbc-pas-fpas:Broker</a>
    /// </summary>
    let Broker = _prefixId.prefix "Broker"
    /// <summary>
    ///   <para>rdfs:label : broker-dealer^^xsd:string</para>
    ///   <para>skos:definition : any party in the business of buying and selling securities, operating as both a broker and a dealer, depending on the transaction^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Office of Financial Research (OFR) Annual Report, 2012, Glossary^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/BrokerDealer">fibo-fbc-pas-fpas:BrokerDealer</a>
    /// </summary>
    let BrokerDealer = _prefixId.prefix "BrokerDealer"
    /// <summary>
    ///   <para>rdfs:label : catalog^^xsd:string</para>
    ///   <para>skos:definition : publication including a list of products available for sale with their descriptions and possibly prices^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Catalog">fibo-fbc-pas-fpas:Catalog</a>
    /// </summary>
    let Catalog = _prefixId.prefix "Catalog"
    let ClearedTrade = _prefixId.prefix "ClearedTrade"
    let ClosedTrade = _prefixId.prefix "ClosedTrade"
    /// <summary>
    ///   <para>rdfs:label : contract lifecycle^^xsd:string</para>
    ///   <para>skos:definition : lifecycle of an agreement, including, but not limited to a credit agreement, financial instrument, or other formal contract, from initial stages through retirement^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Certain business agreements, such as partnership agreements,may involve planning, drafting/review/revision, execution and management, renewal, and possibly sunsetting phases. Financial contracts, such as loans and other instruments have specific stages and events during the execution and management phase, i.e. from the effective date of the contract through maturity and redemption.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycle">fibo-fbc-pas-fpas:ContractLifecycle</a>
    /// </summary>
    let ContractLifecycle = _prefixId.prefix "ContractLifecycle"
    /// <summary>
    ///   <para>rdfs:label : contract lifecycle event^^xsd:string</para>
    ///   <para>skos:definition : kind of event that occurs during one or more stages of the lifecycle of an agreement^^xsd:string</para>
    ///   <para>skos:example : a call notification or coupon payment as a part of a bond lifecycle^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleEvent">fibo-fbc-pas-fpas:ContractLifecycleEvent</a>
    /// </summary>
    let ContractLifecycleEvent = _prefixId.prefix "ContractLifecycleEvent"

    /// <summary>
    ///   <para>rdfs:label : contract lifecycle event occurrence^^xsd:string</para>
    ///   <para>skos:definition : actual occurrence of an event during a specific stage of a specific contract lifecycle^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleEventOccurrence">fibo-fbc-pas-fpas:ContractLifecycleEventOccurrence</a>
    /// </summary>
    let ContractLifecycleEventOccurrence =
        _prefixId.prefix "ContractLifecycleEventOccurrence"

    /// <summary>
    ///   <para>rdfs:label : contract lifecycle occurrence^^xsd:string</para>
    ///   <para>skos:definition : realization of the lifecycle of a specific contract^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleOccurrence">fibo-fbc-pas-fpas:ContractLifecycleOccurrence</a>
    /// </summary>
    let ContractLifecycleOccurrence = _prefixId.prefix "ContractLifecycleOccurrence"
    /// <summary>
    ///   <para>rdfs:label : contract lifecycle stage^^xsd:string</para>
    ///   <para>skos:definition : phase in the lifecycle of an agreement^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleStage">fibo-fbc-pas-fpas:ContractLifecycleStage</a>
    /// </summary>
    let ContractLifecycleStage = _prefixId.prefix "ContractLifecycleStage"

    /// <summary>
    ///   <para>rdfs:label : contract lifecycle stage occurrence^^xsd:string</para>
    ///   <para>skos:definition : realization, from start to finish of a phase in an occurrence of a specific contract lifecycle^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleStageOccurrence">fibo-fbc-pas-fpas:ContractLifecycleStageOccurrence</a>
    /// </summary>
    let ContractLifecycleStageOccurrence =
        _prefixId.prefix "ContractLifecycleStageOccurrence"

    /// <summary>
    ///   <para>rdfs:label : dealer^^xsd:string</para>
    ///   <para>skos:definition : any party that purchases goods or services for resale and acts on their own behalf in a transaction^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A dealer is a counterparty or principal in the transaction with the customer.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Dealer">fibo-fbc-pas-fpas:Dealer</a>
    /// </summary>
    let Dealer = _prefixId.prefix "Dealer"
    /// <summary>
    ///   <para>rdfs:label : exposure^^xsd:string</para>
    ///   <para>skos:definition : means by which an individual or organization is unprotected and open to damage, danger, risk of suffering a loss, or uncertainty^^xsd:string</para>
    ///   <para>skos:example : Examples include financial exposure, credit exposure, legal exposure, credit rating exposure, reputational exposure, and so forth.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Exposure">fibo-fbc-pas-fpas:Exposure</a>
    /// </summary>
    let Exposure = _prefixId.prefix "Exposure"
    /// <summary>
    ///   <para>rdfs:label : exposure bearer^^xsd:string</para>
    ///   <para>skos:definition : party subject to influence or risk arising from a specific contract, instrument, or arrangement^^xsd:string</para>
    ///   <para>skos:note : Note that the name given to the party at risk is dependent on the jurisdiction and nature of the risk. Different regulations use differing terminology for this party, and exposure bearer is considered more general that some synonyms.^^xsd:string</para>
    ///   <para>cmns-av:synonym : exposed party^^xsd:stringcmns-av:synonym : risk bearer^^xsd:stringcmns-av:synonym : risk-bearing party^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ExposureBearer">fibo-fbc-pas-fpas:ExposureBearer</a>
    /// </summary>
    let ExposureBearer = _prefixId.prefix "ExposureBearer"
    /// <summary>
    ///   <para>rdfs:label : exposure situation</para>
    ///   <para>skos:definition : state of affairs in which some party is subject to influence or risk arising from a specific contract, instrument, or arrangement^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ExposureSituation">fibo-fbc-pas-fpas:ExposureSituation</a>
    /// </summary>
    let ExposureSituation = _prefixId.prefix "ExposureSituation"
    /// <summary>
    ///   <para>rdfs:label : financial exposure^^xsd:string</para>
    ///   <para>skos:definition : the extent to which an individual or organization is open to risk of suffering a loss in a transaction, or with respect to some investment or set of investments, e.g., some holding; the amount one stands to lose in that transaction or investment^^xsd:string</para>
    ///   <para>skos:example : Examples in banking include the total amount of unsecured loans, the amount of loans advanced to a single borrower, group, industry, or country, and the probability of loss from devaluation, revaluation, or foreign exchange fluctuations.^^xsd:string</para>
    ///   <para>skos:note : Financial exposure may be related to a holding, involving ownership, or may involve rights or obligations related to borrowing or derivatives.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialExposure">fibo-fbc-pas-fpas:FinancialExposure</a>
    /// </summary>
    let FinancialExposure = _prefixId.prefix "FinancialExposure"

    /// <summary>
    ///   <para>rdfs:label : financial intermediation service^^xsd:string</para>
    ///   <para>skos:definition : any financial service in which a third party (the intermediary) matches lenders and investors with entrepreneurs and other borrowers in need of capital^^xsd:string</para>
    ///   <para>fibo-fnd-utl-av:definitionOrigin : Office of Financial Research (OFR) Annual Report, 2012, Glossary^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Often investors and borrowers do not have precisely matching needs, and the intermediary's capital is put at risk to transform the credit risk and maturity of the liabilities to meet the needs of investors.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialIntermediationService">fibo-fbc-pas-fpas:FinancialIntermediationService</a>
    /// </summary>
    let FinancialIntermediationService =
        _prefixId.prefix "FinancialIntermediationService"

    /// <summary>
    ///   <para>rdfs:label : financial product^^xsd:string</para>
    ///   <para>skos:definition : product provided to consumers and businesses by financial institutions such as banks, insurance companies, brokerage firms, consumer finance companies, and investment companies^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialProduct">fibo-fbc-pas-fpas:FinancialProduct</a>
    /// </summary>
    let FinancialProduct = _prefixId.prefix "FinancialProduct"
    /// <summary>
    ///   <para>rdfs:label : financial product catalog^^xsd:string</para>
    ///   <para>skos:definition : catalog of financial products and/or services available for sale with their description and other product details^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Nordea Bank^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialProductCatalog">fibo-fbc-pas-fpas:FinancialProductCatalog</a>
    /// </summary>
    let FinancialProductCatalog = _prefixId.prefix "FinancialProductCatalog"
    /// <summary>
    ///   <para>rdfs:label : financial service^^xsd:string</para>
    ///   <para>skos:definition : service provided to consumers and businesses by financial institutions such as banks, insurance companies, brokerage firms, consumer finance companies, and investment companies^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialService">fibo-fbc-pas-fpas:FinancialService</a>
    /// </summary>
    let FinancialService = _prefixId.prefix "FinancialService"
    /// <summary>
    ///   <para>rdfs:label : financial service provider^^xsd:string</para>
    ///   <para>skos:definition : functional entity either licensed to provide financial services to consumers and/or businesses or established by law to provide financial services, such as a central bank^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialServiceProvider">fibo-fbc-pas-fpas:FinancialServiceProvider</a>
    /// </summary>
    let FinancialServiceProvider = _prefixId.prefix "FinancialServiceProvider"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Holding">fibo-fbc-pas-fpas:Holding</a>
    /// </summary>
    let Holding = _prefixId.prefix "Holding"
    /// <summary>
    ///   <para>rdfs:label : legal agent^^xsd:string</para>
    ///   <para>skos:definition : any party that has been legally empowered to act on behalf of another party^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : 17 CFR 45.1, Definitions - see the definition of agent^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/LegalAgent">fibo-fbc-pas-fpas:LegalAgent</a>
    /// </summary>
    let LegalAgent = _prefixId.prefix "LegalAgent"
    /// <summary>
    ///   <para>rdfs:label : licensed agent^^xsd:string</para>
    ///   <para>skos:definition : any individual who is licensed to perform a legally binding function, and who has been legally empowered to act on behalf of another party^^xsd:string</para>
    ///   <para>skos:example : Insurance agents, realtors, financial advisors, certain attorneys, and brokers are examples of legal agents.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : 17 CFR 45.1, Definitions - see the definition of agent^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/LicensedAgent">fibo-fbc-pas-fpas:LicensedAgent</a>
    /// </summary>
    let LicensedAgent = _prefixId.prefix "LicensedAgent"
    let MaturedTrade = _prefixId.prefix "MaturedTrade"
    /// <summary>
    ///   <para>rdfs:label : offeree^^xsd:string</para>
    ///   <para>skos:definition : party that receives an offer from something from someone (i.e., an offerer) based on the terms of the offering^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Offeree">fibo-fbc-pas-fpas:Offeree</a>
    /// </summary>
    let Offeree = _prefixId.prefix "Offeree"
    /// <summary>
    ///   <para>rdfs:label : offering^^xsd:string</para>
    ///   <para>skos:definition : expression of interest in providing something to someone that is contingent upon acceptance, forbearance, or some other consideration, as might be desired by an offeree(s)^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The making of an offer is the first of three steps in the traditional process of forming a valid contract: an offer, an acceptance of the offer, and an exchange of consideration. (Consideration is the act of doing something or promising to do something that a person is not legally required to do, or the forbearance or the promise to forbear from doing something that he or she has the legal right to do.)^^xsd:string</para>
    ///   <para>cmns-av:usageNote : An offering may or may not be considered a 'state of affairs' or situation, depending on the circumstances. In some cases such as a prospectus or other offering in the context of financial services, an offering may also be classified as a situation. Users may choose to model an individual offering as both an offering and situation, depending on the circumstances, in other words.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Offering">fibo-fbc-pas-fpas:Offering</a>
    /// </summary>
    let Offering = _prefixId.prefix "Offering"
    /// <summary>
    ///   <para>rdfs:label : offeror^^xsd:string</para>
    ///   <para>skos:definition : party that proposes to make something available to someone (i.e., an offeree) based on the terms of the offering^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Offeror">fibo-fbc-pas-fpas:Offeror</a>
    /// </summary>
    let Offeror = _prefixId.prefix "Offeror"
    let OpenTrade = _prefixId.prefix "OpenTrade"
    /// <summary>
    ///   <para>rdfs:label : position^^xsd:string</para>
    ///   <para>skos:definition : financial exposure resulting from owning, borrowing, shorting, or entering into a contract (e.g., derivatives)^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A position can be long or short, and it can be in any asset class, such as stocks, bonds, futures, or options. A position can be open (current) or closed (past), but in general use, unless a position is specifically referred to as closed, the assumption is that it references an open position.^^xsd:stringcmns-av:explanatoryNote : Regulators use 'position' when speaking about exposure with respect to
    /// - CFTC futures/options positions
    /// - Basel risk-weighted exposures
    /// - Short-selling regulations (net short position)
    /// - Derivatives reporting (swap positions)
    ///
    /// A position may exist without a holding (e.g., short sale, swap exposure). A holding always implies a long position, but a position does not always imply a holding.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Position">fibo-fbc-pas-fpas:Position</a>
    /// </summary>
    let Position = _prefixId.prefix "Position"
    /// <summary>
    ///   <para>rdfs:label : product lifecycle^^xsd:string</para>
    ///   <para>skos:definition : lifecycle specific to a product or product family^^xsd:string</para>
    ///   <para>skos:example : The product life cycle describes the period of time over which an item is developed, brought to market and eventually removed from the market. The cycle is broken into four stages: introduction, growth, maturity and decline. The idea of the product life cycle is used in marketing to decide when it is appropriate to advertise, reduce prices, explore new markets or create new packaging.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycle">fibo-fbc-pas-fpas:ProductLifecycle</a>
    /// </summary>
    let ProductLifecycle = _prefixId.prefix "ProductLifecycle"
    /// <summary>
    ///   <para>rdfs:label : product lifecycle event^^xsd:string</para>
    ///   <para>skos:definition : kind of event that occurs during one or more stages of a product lifecycle^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleEvent">fibo-fbc-pas-fpas:ProductLifecycleEvent</a>
    /// </summary>
    let ProductLifecycleEvent = _prefixId.prefix "ProductLifecycleEvent"

    /// <summary>
    ///   <para>rdfs:label : product lifecycle event occurrence^^xsd:string</para>
    ///   <para>skos:definition : actual occurrence of an event that happens during a specific stage of a specific product lifecycle^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleEventOccurrence">fibo-fbc-pas-fpas:ProductLifecycleEventOccurrence</a>
    /// </summary>
    let ProductLifecycleEventOccurrence =
        _prefixId.prefix "ProductLifecycleEventOccurrence"

    /// <summary>
    ///   <para>rdfs:label : product lifecycle occurrence^^xsd:string</para>
    ///   <para>skos:definition : realization of the lifecycle of a specific product^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleOccurrence">fibo-fbc-pas-fpas:ProductLifecycleOccurrence</a>
    /// </summary>
    let ProductLifecycleOccurrence = _prefixId.prefix "ProductLifecycleOccurrence"
    /// <summary>
    ///   <para>rdfs:label : product lifecycle stage^^xsd:string</para>
    ///   <para>skos:definition : phase in a product lifecycle^^xsd:string</para>
    ///   <para>skos:example : research and development phase of a product lifecycle or the introduction phase in a marketing lifecycle, growth stage in an economic lifecycle for a product^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleStage">fibo-fbc-pas-fpas:ProductLifecycleStage</a>
    /// </summary>
    let ProductLifecycleStage = _prefixId.prefix "ProductLifecycleStage"

    /// <summary>
    ///   <para>rdfs:label : product lifecycle stage occurrence^^xsd:string</para>
    ///   <para>skos:definition : realization of a specific stage in the lifecycle of a given product^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleStageOccurrence">fibo-fbc-pas-fpas:ProductLifecycleStageOccurrence</a>
    /// </summary>
    let ProductLifecycleStageOccurrence =
        _prefixId.prefix "ProductLifecycleStageOccurrence"

    /// <summary>
    ///   <para>rdfs:label : registered agent^^xsd:string</para>
    ///   <para>skos:definition : legal agent designated by some party to represent them and act on their behalf under a formal agency agreement^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Agency capacity, as specified in an agency agreement, may include power of attorney, the ability to act as an agent in certain kinds of transactions such as real estate, tax, audit or other financial or legal transactions, as a fiduciary, including as a trustee or legal guardian, for service of process, and so forth.^^xsd:string</para>
    ///   <para>cmns-av:synonym : resident agent^^xsd:stringcmns-av:synonym : statutory agent^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/RegisteredAgent">fibo-fbc-pas-fpas:RegisteredAgent</a>
    /// </summary>
    let RegisteredAgent = _prefixId.prefix "RegisteredAgent"
    /// <summary>
    ///   <para>rdfs:label : regulated commodity^^xsd:string</para>
    ///   <para>skos:definition : commodity under the jurisdiction of the regulatory agency, such as the Commodities Futures Trading Commission (CFTF) in the United States, which includes any commodity traded in an organized contracts market^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The CFTC polices matters of information and disclosure, fair trading practices, registration of firms and individuals, protection of customer funds, record keeping, and maintenance of orderly options and futures markets in the United States.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/RegulatedCommodity">fibo-fbc-pas-fpas:RegulatedCommodity</a>
    /// </summary>
    let RegulatedCommodity = _prefixId.prefix "RegulatedCommodity"
    /// <summary>
    ///   <para>rdfs:label : settlement terms^^xsd:string</para>
    ///   <para>skos:definition : contract terms that define the commitment to and mechanism for settling one or more sides of a transaction^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In general, settlement involves arrangement of disposition of property, typically for legal reasons. With respect to financial transactions, it involves completion of a trade, either between brokers or agents, or between a broker and client. This may include settlement in cash, either for the entire transaction or for the cash leg of a transaction, either now or at some specified time in the future.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/SettlementTerms">fibo-fbc-pas-fpas:SettlementTerms</a>
    /// </summary>
    let SettlementTerms = _prefixId.prefix "SettlementTerms"
    let TerminatedTrade = _prefixId.prefix "TerminatedTrade"
    /// <summary>
    ///   <para>rdfs:label : third-party agent^^xsd:string</para>
    ///   <para>skos:definition : any service provider that is licensed to perform a legally binding function and has been legally empowered to act on behalf of another party^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : 17 CFR 45.1, Definitions - see the definition of agent^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Note that third-party agent is defined as a service provider (organization) acting in an agency capacity, such as a law firm, accountancy, or investment bank. This is distinct from the concept of an individual (licensed agent), for example one who works for a broker-dealer, that is a registered agent licensed to sell securities.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ThirdPartyAgent">fibo-fbc-pas-fpas:ThirdPartyAgent</a>
    /// </summary>
    let ThirdPartyAgent = _prefixId.prefix "ThirdPartyAgent"
    /// <summary>
    ///   <para>rdfs:label : trade^^xsd:string</para>
    ///   <para>skos:definition : situation that realizes an agreement between parties participating in a voluntary action of buying and selling goods and services^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Deutsche Bank Presentation on the Lifecycle of a Trade, available at http://www.slideshare.net/ahaline/23512555-tradelifecycle^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The advent of money as a medium of exchange has allowed trade to be conducted in a manner that is much simpler and effective compared to earlier forms of trade, such as bartering. In financial markets, trading also can mean performing a transaction that involves the selling and purchasing of a security.^^xsd:stringcmns-av:explanatoryNote : The seller must deliver the commodity sold to the buyer; the buyer must pay the agreed purchase price, which could be in the form of other goods or services, on the agreed date.^^xsd:stringcmns-av:explanatoryNote : Trading activities typically include (a) regularly underwriting or dealing in securities; interest rate, foreign exchange rate, commodity, equity, and credit derivative contracts; other financial instruments; and other assets for resale, (b) acquiring or taking positions in such items principally for the purpose of selling in the near term or otherwise with the intent to resell in order to profit from short-term price movements, and (c) acquiring or taking positions in such items as an accommodation to customers or for other trading purposes. (Source: Instructions for Preparation of Consolidated Reports of Condition and Income (FFIEC 031 and 041), Schedule RC-D - Trading Assets and Liabilities, 2013.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Trade">fibo-fbc-pas-fpas:Trade</a>
    /// </summary>
    let Trade = _prefixId.prefix "Trade"
    /// <summary>
    ///   <para>rdfs:label : trade identifier^^xsd:string</para>
    ///   <para>skos:definition : sequence of characters identifying a trade within some context^^xsd:string</para>
    ///   <para>skos:note : Note that a given trade may consist of multiple transactions, and thus there may be multiple identifiers for such transactions associated with a specific trade.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeIdentifier">fibo-fbc-pas-fpas:TradeIdentifier</a>
    /// </summary>
    let TradeIdentifier = _prefixId.prefix "TradeIdentifier"
    /// <summary>
    ///   <para>rdfs:label : trade lifecycle^^xsd:string</para>
    ///   <para>skos:definition : lifecycle that defines the evolution of a trade, from initiation through settlement^^xsd:string</para>
    ///   <para>skos:example : The trade life cycle covers the period of time over which a trade is initiated, typically as a part of a broader deal, is consumated, processed and executed, is settled or closed for other reasons, and is reported. Parts of a trade lifecycle may include or overlap with the lifecycle of one or more contracts.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycle">fibo-fbc-pas-fpas:TradeLifecycle</a>
    /// </summary>
    let TradeLifecycle = _prefixId.prefix "TradeLifecycle"
    /// <summary>
    ///   <para>rdfs:label : trade lifecycle event^^xsd:string</para>
    ///   <para>skos:definition : kind of event that occurs during one or more stages of the lifecycle of a trade^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleEvent">fibo-fbc-pas-fpas:TradeLifecycleEvent</a>
    /// </summary>
    let TradeLifecycleEvent = _prefixId.prefix "TradeLifecycleEvent"
    /// <summary>
    ///   <para>rdfs:label : trade lifecycle event occurrence^^xsd:string</para>
    ///   <para>skos:definition : realization of an event that happens during a specific stage of a specific trade lifecycle^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleEventOccurrence">fibo-fbc-pas-fpas:TradeLifecycleEventOccurrence</a>
    /// </summary>
    let TradeLifecycleEventOccurrence = _prefixId.prefix "TradeLifecycleEventOccurrence"
    /// <summary>
    ///   <para>rdfs:label : trade lifecycle occurrence^^xsd:string</para>
    ///   <para>skos:definition : realization of the lifecycle for a specific trade^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleOccurrence">fibo-fbc-pas-fpas:TradeLifecycleOccurrence</a>
    /// </summary>
    let TradeLifecycleOccurrence = _prefixId.prefix "TradeLifecycleOccurrence"
    /// <summary>
    ///   <para>rdfs:label : trade lifecycle stage^^xsd:string</para>
    ///   <para>skos:definition : phase in the lifecycle of a trade^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleStage">fibo-fbc-pas-fpas:TradeLifecycleStage</a>
    /// </summary>
    let TradeLifecycleStage = _prefixId.prefix "TradeLifecycleStage"
    /// <summary>
    ///   <para>rdfs:label : trade lifecycle stage occurrence^^xsd:string</para>
    ///   <para>skos:definition : realization of a phase in the lifecycle of a specific trade^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleStageOccurrence">fibo-fbc-pas-fpas:TradeLifecycleStageOccurrence</a>
    /// </summary>
    let TradeLifecycleStageOccurrence = _prefixId.prefix "TradeLifecycleStageOccurrence"
    /// <summary>
    ///   <para>rdfs:label : trader^^xsd:string</para>
    ///   <para>skos:definition : party that engages in the transfer of financial assets in any financial market on behalf of a client or the financial services provider^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Trader">fibo-fbc-pas-fpas:Trader</a>
    /// </summary>
    let Trader = _prefixId.prefix "Trader"
    /// <summary>
    ///   <para>rdfs:label : trading strategy^^xsd:string</para>
    ///   <para>skos:definition : approach used for buying and selling in the securities markets^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A trading strategy is a plan whose aim is to make a profit or hedge against risk, based on rules and other criteria used when making trading decisions. A trading strategy may be simple or complex, and involve considerations such as investment style (e.g., value vs. growth), market cap, technical indicators, fundamental analysis, industry sector, level of portfolio diversification, time horizon or holding period, risk tolerance, leverage, tax considerations, and so on.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradingStrategy">fibo-fbc-pas-fpas:TradingStrategy</a>
    /// </summary>
    let TradingStrategy = _prefixId.prefix "TradingStrategy"
    /// <summary>
    ///   <para>rdfs:label : unique transaction identifier^^xsd:string</para>
    ///   <para>skos:definition : sequence of characters identifying a financial transaction uniquely whenever useful and agreed by the parties or community involved in the transaction^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : UTI^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Harmonization of the Unique Transaction Identifier - Technical Guidance, 20 Feb 2017, described in https://www.bis.org/cpmi/publ/d158.pdf^^xsd:stringcmns-av:adaptedFrom : ISO 23897:2020, Financial services - Unique transaction identifier (UTI)^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In particular, a UTI will help to ensure the consistent aggregation of OTC derivatives and other securities transactions by minimising the likelihood that the same transaction will be counted more than once (for instance, because it is reported by more than one counterparty to a transaction, or to more than one trade repository (TR)).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/UniqueTransactionIdentifier">fibo-fbc-pas-fpas:UniqueTransactionIdentifier</a>
    /// </summary>
    let UniqueTransactionIdentifier = _prefixId.prefix "UniqueTransactionIdentifier"
    /// <summary>
    ///   <para>rdfs:label : weighted basket^^xsd:string</para>
    ///   <para>skos:definition : basket whose constituents have some relative importance with respect to one another^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/WeightedBasket">fibo-fbc-pas-fpas:WeightedBasket</a>
    /// </summary>
    let WeightedBasket = _prefixId.prefix "WeightedBasket"
    /// <summary>
    ///   <para>rdfs:label : weighted basket constituent^^xsd:string</para>
    ///   <para>skos:definition : component of a basket whose relative importance with respect to other basket constituents is known^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/WeightedBasketConstituent">fibo-fbc-pas-fpas:WeightedBasketConstituent</a>
    /// </summary>
    let WeightedBasketConstituent = _prefixId.prefix "WeightedBasketConstituent"
    /// <summary>
    ///   <para>rdfs:label : exposes in^^xsd:string</para>
    ///   <para>skos:definition : indicates the state of affairs in which exposure occurs^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/exposesIn">fibo-fbc-pas-fpas:exposesIn</a>
    /// </summary>
    let exposesIn = _prefixId.prefix "exposesIn"
    /// <summary>
    ///   <para>rdfs:label : facilitates^^xsd:string</para>
    ///   <para>skos:definition : acts as an enabler in a situation in which an event, a task, a conversation or something else occurs^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/facilitates">fibo-fbc-pas-fpas:facilitates</a>
    /// </summary>
    let facilitates = _prefixId.prefix "facilitates"
    /// <summary>
    ///   <para>rdfs:label : has exposed party^^xsd:string</para>
    ///   <para>skos:definition : indicates the party subject to influence or risk in^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasExposedParty">fibo-fbc-pas-fpas:hasExposedParty</a>
    /// </summary>
    let hasExposedParty = _prefixId.prefix "hasExposedParty"
    /// <summary>
    ///   <para>rdfs:label : has exposure to^^xsd:string</para>
    ///   <para>skos:definition : involves influence or risk from^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasExposureTo">fibo-fbc-pas-fpas:hasExposureTo</a>
    /// </summary>
    let hasExposureTo = _prefixId.prefix "hasExposureTo"
    /// <summary>
    ///   <para>rdfs:label : has generating entity^^xsd:string</para>
    ///   <para>skos:definition : specifies a legal entity that generates something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasGeneratingEntity">fibo-fbc-pas-fpas:hasGeneratingEntity</a>
    /// </summary>
    let hasGeneratingEntity = _prefixId.prefix "hasGeneratingEntity"
    /// <summary>
    ///   <para>rdfs:label : has generating entity identifier^^xsd:string</para>
    ///   <para>skos:definition : specifies an identifier for the entity that generated a unique transaction identifier^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that the range of is identified by must be that entity's LEI in the context of a UTI.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasGeneratingEntityIdentifier">fibo-fbc-pas-fpas:hasGeneratingEntityIdentifier</a>
    /// </summary>
    let hasGeneratingEntityIdentifier = _prefixId.prefix "hasGeneratingEntityIdentifier"
    /// <summary>
    ///   <para>rdfs:label : has registered agent^^xsd:string</para>
    ///   <para>skos:definition : identifies a party as one that has the legal, medical or financial capacity to act on behalf of someone else under specific circumstances^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasLegalAgent">fibo-fbc-pas-fpas:hasLegalAgent</a>
    /// </summary>
    let hasLegalAgent = _prefixId.prefix "hasLegalAgent"
    /// <summary>
    ///   <para>rdfs:label : has nominal number of units^^xsd:string</para>
    ///   <para>skos:definition : indicates the base number of units of something associated with some offering^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasNominalNumberOfUnits">fibo-fbc-pas-fpas:hasNominalNumberOfUnits</a>
    /// </summary>
    let hasNominalNumberOfUnits = _prefixId.prefix "hasNominalNumberOfUnits"
    /// <summary>
    ///   <para>rdfs:label : has offering^^xsd:string</para>
    ///   <para>skos:definition : relates something to a voluntary but conditional promise submitted by a buyer or seller (offeror) to another (offeree) for acceptance, and which becomes legally enforceable if accepted by the offeree^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasOffering">fibo-fbc-pas-fpas:hasOffering</a>
    /// </summary>
    let hasOffering = _prefixId.prefix "hasOffering"
    /// <summary>
    ///   <para>rdfs:label : has offering amount^^xsd:string</para>
    ///   <para>skos:definition : indicates the notional monetary amount, determined based on reference data, market rates or some other agreed method associated with some offering^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasOfferingAmount">fibo-fbc-pas-fpas:hasOfferingAmount</a>
    /// </summary>
    let hasOfferingAmount = _prefixId.prefix "hasOfferingAmount"
    /// <summary>
    ///   <para>rdfs:label : has offering price^^xsd:string</para>
    ///   <para>skos:definition : indicates the price associated with an offering, which may be an explicit or calculated price^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasOfferingPrice">fibo-fbc-pas-fpas:hasOfferingPrice</a>
    /// </summary>
    let hasOfferingPrice = _prefixId.prefix "hasOfferingPrice"
    /// <summary>
    ///   <para>rdfs:label : has offering units^^xsd:string</para>
    ///   <para>skos:definition : indicates the actual number of units of something, including any premium on the number of units, associated with some offering^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasOfferingUnits">fibo-fbc-pas-fpas:hasOfferingUnits</a>
    /// </summary>
    let hasOfferingUnits = _prefixId.prefix "hasOfferingUnits"
    /// <summary>
    ///   <para>rdfs:label : has selecting party^^xsd:string</para>
    ///   <para>skos:definition : indicates the person(s) or organization(s) responsible for determining the contents of a basket^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasSelectingParty">fibo-fbc-pas-fpas:hasSelectingParty</a>
    /// </summary>
    let hasSelectingParty = _prefixId.prefix "hasSelectingParty"
    /// <summary>
    ///   <para>rdfs:label : has selection criteria^^xsd:string</para>
    ///   <para>skos:definition : describes the methodology or program used to determine the membership of a collection^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasSelectionCriteria">fibo-fbc-pas-fpas:hasSelectionCriteria</a>
    /// </summary>
    let hasSelectionCriteria = _prefixId.prefix "hasSelectionCriteria"
    /// <summary>
    ///   <para>rdfs:label : has settlement date^^xsd:string</para>
    ///   <para>skos:definition : indicates the date by which an executed order or transaction must be settled^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Settlement might involve either a buyer paying in cash or a seller delivering the relevant instrument(s) and receiving the proceeds as specified by the terms of a given transaction.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasSettlementDate">fibo-fbc-pas-fpas:hasSettlementDate</a>
    /// </summary>
    let hasSettlementDate = _prefixId.prefix "hasSettlementDate"
    /// <summary>
    ///   <para>rdfs:label : has trade date^^xsd:string</para>
    ///   <para>skos:definition : indicates the date on which a security or other instrument-specific trade actually takes place^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasTradeDate">fibo-fbc-pas-fpas:hasTradeDate</a>
    /// </summary>
    let hasTradeDate = _prefixId.prefix "hasTradeDate"
    /// <summary>
    ///   <para>rdfs:label : is embodied in^^xsd:string</para>
    ///   <para>skos:definition : identifies the representation or tangible form of something in some context^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isEmbodiedIn">fibo-fbc-pas-fpas:isEmbodiedIn</a>
    /// </summary>
    let isEmbodiedIn = _prefixId.prefix "isEmbodiedIn"
    /// <summary>
    ///   <para>rdfs:label : is exposed party in^^xsd:string</para>
    ///   <para>skos:definition : indicates the state of affairs in which the party bears the risk^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isExposedPartyIn">fibo-fbc-pas-fpas:isExposedPartyIn</a>
    /// </summary>
    let isExposedPartyIn = _prefixId.prefix "isExposedPartyIn"
    /// <summary>
    ///   <para>rdfs:label : is exposed to^^xsd:string</para>
    ///   <para>skos:definition : is subject to influence or risk from^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isExposedTo">fibo-fbc-pas-fpas:isExposedTo</a>
    /// </summary>
    let isExposedTo = _prefixId.prefix "isExposedTo"
    /// <summary>
    ///   <para>rdfs:label : is exposure of^^xsd:string</para>
    ///   <para>skos:definition : is the influence or risk borne by^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isExposureOf">fibo-fbc-pas-fpas:isExposureOf</a>
    /// </summary>
    let isExposureOf = _prefixId.prefix "isExposureOf"
    /// <summary>
    ///   <para>rdfs:label : is facilitated by^^xsd:string</para>
    ///   <para>skos:definition : identifies someone or something that expedites some event, transaction, conversation or something else in some context^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isFacilitatedBy">fibo-fbc-pas-fpas:isFacilitatedBy</a>
    /// </summary>
    let isFacilitatedBy = _prefixId.prefix "isFacilitatedBy"
    /// <summary>
    ///   <para>rdfs:label : is offering of^^xsd:string</para>
    ///   <para>skos:definition : relates an offering to one or things that are the subject of the offer^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isOfferingOf">fibo-fbc-pas-fpas:isOfferingOf</a>
    /// </summary>
    let isOfferingOf = _prefixId.prefix "isOfferingOf"
    /// <summary>
    ///   <para>rdfs:label : relates to^^xsd:string</para>
    ///   <para>skos:definition : has a logical or causal connection with^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/relatesTo">fibo-fbc-pas-fpas:relatesTo</a>
    /// </summary>
    let relatesTo = _prefixId.prefix "relatesTo"
