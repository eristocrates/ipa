#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-ind-mkt-bas`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/" "fibo-ind-mkt-bas"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : basket of credit risks</para>
    ///   <para>skos:definition : basket of instruments, legal entities, or a combination thereof collected for the purpose of analyzing risk</para>
    ///   <para>cmns-av:explanatoryNote : Note that the risk related to a given constituent may be calculated based on either (1) the overall credit risk associated with the entity or, (2) the combined risk associated with an entity and the specific instrument identified, or (3) risk associated with the instrument on its own. Criteria for constituents is based on sectors (emerging market, financial, sovereign, etc), spread range (investment grade, non-investment grade), or asset type (loan, bond, mortgage-backed, asset-backed), second criteria is based on maturity of protection (2,3,5,7,10 yrs). Markit manages over 2000 CDS indexes, for example.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/BasketOfCreditRisks">fibo-ind-mkt-bas:BasketOfCreditRisks</a>
    /// </summary>
    let BasketOfCreditRisks = _prefixId.prefix "BasketOfCreditRisks"
    /// <summary>
    ///   <para>rdfs:label : basket of equities</para>
    ///   <para>skos:definition : basket of securities whose constituents are listed shares</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/BasketOfEquities">fibo-ind-mkt-bas:BasketOfEquities</a>
    /// </summary>
    let BasketOfEquities = _prefixId.prefix "BasketOfEquities"

    /// <summary>
    ///   <para>rdfs:label : capitalization-based weighting function</para>
    ///   <para>skos:definition : weighting function derived from the relative market capitalization (share price times the number of shares outstanding) of the companies tracked by an index</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/CapitalizationBasedWeightingFunction">fibo-ind-mkt-bas:CapitalizationBasedWeightingFunction</a>
    /// </summary>
    let CapitalizationBasedWeightingFunction =
        _prefixId.prefix "CapitalizationBasedWeightingFunction"

    /// <summary>
    ///   <para>rdfs:label : credit index</para>
    ///   <para>skos:definition : reference index that is a function of credit events that change the value of an underlying portfolio</para>
    ///   <para>cmns-av:explanatoryNote : Such an index does not necessarily reference a static portfolio, as there may be provisions for replacing defaulted securities on which the index depends.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/CreditIndex">fibo-ind-mkt-bas:CreditIndex</a>
    /// </summary>
    let CreditIndex = _prefixId.prefix "CreditIndex"
    /// <summary>
    ///   <para>rdfs:label : credit index constituent</para>
    ///   <para>skos:definition : constituent of a basket of credit risks</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/CreditIndexConstituent">fibo-ind-mkt-bas:CreditIndexConstituent</a>
    /// </summary>
    let CreditIndexConstituent = _prefixId.prefix "CreditIndexConstituent"
    /// <summary>
    ///   <para>rdfs:label : equity index</para>
    ///   <para>skos:definition : benchmark whose constituents are exclusively equity instruments</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/EquityIndex">fibo-ind-mkt-bas:EquityIndex</a>
    /// </summary>
    let EquityIndex = _prefixId.prefix "EquityIndex"
    /// <summary>
    ///   <para>rdfs:label : market capitalization</para>
    ///   <para>skos:definition : expression representing the perceived value of a company as determined by the stock market at a specific point in time</para>
    ///   <para>cmns-av:synonym : market cap</para>
    ///   <para>cmns-qtu:describesActualExpression : number of shares outstanding x price per share</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/MarketCapitalization">fibo-ind-mkt-bas:MarketCapitalization</a>
    /// </summary>
    let MarketCapitalization = _prefixId.prefix "MarketCapitalization"
    /// <summary>
    ///   <para>rdfs:label : reference index</para>
    ///   <para>skos:definition : measure of change in the value of the contents of a basket over a given period of time</para>
    ///   <para>cmns-av:explanatoryNote : An index is a function based on a set of structured calculations with respect to a basket of credit risks, financial instruments or other indices over time. Analysis may be computed based on historical values, projected values, etc.</para>
    ///   <para>cmns-av:synonym : benchmark</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/ReferenceIndex">fibo-ind-mkt-bas:ReferenceIndex</a>
    /// </summary>
    let ReferenceIndex = _prefixId.prefix "ReferenceIndex"
    /// <summary>
    ///   <para>rdfs:label : has debt ranking</para>
    ///   <para>skos:definition : indicates the ranking of this debt instrument with respect to the credit index as a whole</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasDebtRanking">fibo-ind-mkt-bas:hasDebtRanking</a>
    /// </summary>
    let hasDebtRanking = _prefixId.prefix "hasDebtRanking"
    /// <summary>
    ///   <para>rdfs:label : has index name</para>
    ///   <para>skos:definition : specifies a formal name for the index</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasIndexName">fibo-ind-mkt-bas:hasIndexName</a>
    /// </summary>
    let hasIndexName = _prefixId.prefix "hasIndexName"
    /// <summary>
    ///   <para>rdfs:label : has index value^^xsd:string</para>
    ///   <para>skos:definition : specifies the value of a given index as of the release date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasIndexValue">fibo-ind-mkt-bas:hasIndexValue</a>
    /// </summary>
    let hasIndexValue = _prefixId.prefix "hasIndexValue"
    /// <summary>
    ///   <para>rdfs:label : has market capitalization</para>
    ///   <para>skos:definition : indicates the market capitalization of some issuer as of some date</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasMarketCapitalization">fibo-ind-mkt-bas:hasMarketCapitalization</a>
    /// </summary>
    let hasMarketCapitalization = _prefixId.prefix "hasMarketCapitalization"
    /// <summary>
    ///   <para>rdfs:label : has market capitalization value</para>
    ///   <para>skos:definition : indicates the monetary amount representing the market capitalization of some issuer as of some date</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasMarketCapitalizationValue">fibo-ind-mkt-bas:hasMarketCapitalizationValue</a>
    /// </summary>
    let hasMarketCapitalizationValue = _prefixId.prefix "hasMarketCapitalizationValue"
    /// <summary>
    ///   <para>rdfs:label : has original notional value</para>
    ///   <para>skos:definition : indicates the notional amount represented by the index when it is first constituted</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasOriginalNotionalValue">fibo-ind-mkt-bas:hasOriginalNotionalValue</a>
    /// </summary>
    let hasOriginalNotionalValue = _prefixId.prefix "hasOriginalNotionalValue"
    /// <summary>
    ///   <para>rdfs:label : has premium</para>
    ///   <para>skos:definition : indicates a premium payable for a contract based on the index</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasPremium">fibo-ind-mkt-bas:hasPremium</a>
    /// </summary>
    let hasPremium = _prefixId.prefix "hasPremium"
    /// <summary>
    ///   <para>rdfs:label : has spread range</para>
    ///   <para>skos:definition : the range of credit spread for the constituents of the index</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasSpreadRange">fibo-ind-mkt-bas:hasSpreadRange</a>
    /// </summary>
    let hasSpreadRange = _prefixId.prefix "hasSpreadRange"
    /// <summary>
    ///   <para>rdfs:label : has up front fee</para>
    ///   <para>skos:definition : specifies a fee payable by any party that wishes to participate in a contract based on the index after the start of its life</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/hasUpFrontFee">fibo-ind-mkt-bas:hasUpFrontFee</a>
    /// </summary>
    let hasUpFrontFee = _prefixId.prefix "hasUpFrontFee"
