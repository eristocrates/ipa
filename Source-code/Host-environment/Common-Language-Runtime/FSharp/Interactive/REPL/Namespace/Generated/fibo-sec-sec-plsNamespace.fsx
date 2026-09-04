#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-sec-pls`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/" "fibo-sec-sec-pls"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : collective investment vehicle</para>
    ///   <para>skos:definition : assets pooled by investors whose share capital remains separate from the assets of the vehicle</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962:2019 Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : A fund is an entity created to pool money from multiple investors - often referred to as limited partners. Each investor makes an investment in the fund by purchasing an interest in the fund entity, and the adviser uses that money to make investments on behalf of the fund.cmns-av:explanatoryNote : Collective investment vehicles are typically organized and operated by management companies, banks, or trust companies. Shares or units are issued in the form of unit trusts, mutual funds, or other similar contracts. Common kinds of funds include pension funds, insurance funds, foundations, and endowments. Such pools are often invested and professionally managed, including investment pools, umbrella pools, share class pools, etc.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/CollectiveInvestmentVehicle">fibo-sec-sec-pls:CollectiveInvestmentVehicle</a>
    /// </summary>
    let CollectiveInvestmentVehicle = _prefixId.prefix "CollectiveInvestmentVehicle"
    /// <summary>
    ///   <para>rdfs:label : debt pool^^xsd:string</para>
    ///   <para>skos:definition : pool consisting of debt instruments, such as bonds, loans or mortgages^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/DebtPool">fibo-sec-sec-pls:DebtPool</a>
    /// </summary>
    let DebtPool = _prefixId.prefix "DebtPool"
    /// <summary>
    ///   <para>rdfs:label : fund family^^xsd:string</para>
    ///   <para>skos:definition : collection of managed investments that are all managed by a single investment institution^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/FundFamily">fibo-sec-sec-pls:FundFamily</a>
    /// </summary>
    let FundFamily = _prefixId.prefix "FundFamily"
    /// <summary>
    ///   <para>rdfs:label : instrument pool^^xsd:string</para>
    ///   <para>skos:definition : pool consisting of financial instruments that may be included in the same investment vehicle^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/InstrumentPool">fibo-sec-sec-pls:InstrumentPool</a>
    /// </summary>
    let InstrumentPool = _prefixId.prefix "InstrumentPool"
    /// <summary>
    ///   <para>rdfs:label : instrument pool as asset^^xsd:string</para>
    ///   <para>skos:definition : financial asset in the form of an instrument pool^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/InstrumentPoolAsAsset">fibo-sec-sec-pls:InstrumentPoolAsAsset</a>
    /// </summary>
    let InstrumentPoolAsAsset = _prefixId.prefix "InstrumentPoolAsAsset"
    /// <summary>
    ///   <para>rdfs:label : managed investment^^xsd:string</para>
    ///   <para>skos:definition : investment pool that is controlled by a professional investment manager who invests the pool in various financial instruments and assets that align with their investment objectives and is overseen by a board of directors^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Bloomberg LP^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/ManagedInvestment">fibo-sec-sec-pls:ManagedInvestment</a>
    /// </summary>
    let ManagedInvestment = _prefixId.prefix "ManagedInvestment"
    /// <summary>
    ///   <para>rdfs:label : pool^^xsd:string</para>
    ///   <para>skos:definition : combination of resources for a common purpose or benefit^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Finance and Investment Terms, Ninth Edition, 2014^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/Pool">fibo-sec-sec-pls:Pool</a>
    /// </summary>
    let Pool = _prefixId.prefix "Pool"
    /// <summary>
    ///   <para>rdfs:label : pool constituent^^xsd:string</para>
    ///   <para>skos:definition : component of a pool^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A pool may consist of almost anything brought together for some purpose. It differs from a less formal collection in that there are typically facts defined about the members of the pool and potentially regarding the proportions of those members in the pool. Pool membership may change over time, and certain facts about the pool may also vary over time. However, the basic nature of something as a member of the pool is static while that membership holds.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/PoolConstituent">fibo-sec-sec-pls:PoolConstituent</a>
    /// </summary>
    let PoolConstituent = _prefixId.prefix "PoolConstituent"
    /// <summary>
    ///   <para>rdfs:label : pooled fund^^xsd:string</para>
    ///   <para>skos:definition : pool of funds that a group of investors combines for common benefit^^xsd:string</para>
    ///   <para>skos:example : An investment club pools the funds of its members, giving them the opportunity to share in a portfolio offering greater diversification and the hope of a better return on their money than they could get individually.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The US Securities and Exchange Commission describes a fund as an entity created to pool money from multiple investors.^^xsd:string</para>
    ///   <para>cmns-av:synonym : fund^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/PooledFund">fibo-sec-sec-pls:PooledFund</a>
    /// </summary>
    let PooledFund = _prefixId.prefix "PooledFund"
    /// <summary>
    ///   <para>rdfs:label : private fund^^xsd:string</para>
    ///   <para>skos:definition : managed investment that cannot offer securities to the public^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Private funds are not required to be registered or regulated as investment companies under the U.S. federal securities laws. They raise capital from investors through exempt offerings, which means the offering must fall within an exemption from registration under the Securities Act of 1933.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/PrivateFund">fibo-sec-sec-pls:PrivateFund</a>
    /// </summary>
    let PrivateFund = _prefixId.prefix "PrivateFund"
    /// <summary>
    ///   <para>rdfs:label : securities pool^^xsd:string</para>
    ///   <para>skos:definition : pool of securities organized for the purpose of issuing notes against those securities^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/SecuritiesPool">fibo-sec-sec-pls:SecuritiesPool</a>
    /// </summary>
    let SecuritiesPool = _prefixId.prefix "SecuritiesPool"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/SecuritiesPoolConstituent">fibo-sec-sec-pls:SecuritiesPoolConstituent</a>
    /// </summary>
    let SecuritiesPoolConstituent = _prefixId.prefix "SecuritiesPoolConstituent"
