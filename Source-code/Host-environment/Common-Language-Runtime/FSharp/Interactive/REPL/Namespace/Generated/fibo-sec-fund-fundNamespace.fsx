#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-fund-fund`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/" "fibo-sec-fund-fund"

    let _namespaceIri = _prefixId.prefix ""

    /// <summary>
    ///   <para>rdfs:label : aligned community investment fund</para>
    ///   <para>dcterms:source : Aligned Community Investment Fund, available at https://www.nc3now.org/uploads/1/4/0/1/140134350/acif_overview.pdf.</para>
    ///   <para>skos:definition : community investment fund that raises capital publicly from community members and deploys some of that capital via investments into its client businesses or other businesses in the community</para>
    ///   <para>cmns-av:abbreviation : ACIF</para>
    ///   <para>cmns-av:explanatoryNote : For example, an entrepreneurial support organization (ESO) that derives most of its income from providing consulting services to early stage businesses, can raise capital publicly from its community and deploy some of that capital via investments into its client businesses. These investments would comprise its ACIF.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/AlignedCommunityInvestmentFund">fibo-sec-fund-fund:AlignedCommunityInvestmentFund</a>
    /// </summary>
    let AlignedCommunityInvestmentFund =
        _prefixId.prefix "AlignedCommunityInvestmentFund"

    /// <summary>
    ///   <para>rdfs:label : closed-end investment</para>
    ///   <para>skos:definition : investment fund that has a fixed number of shares offered by an investment company through an initial public offering</para>
    ///   <para>cmns-av:synonym : closed-end fund</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/ClosedEndInvestment">fibo-sec-fund-fund:ClosedEndInvestment</a>
    /// </summary>
    let ClosedEndInvestment = _prefixId.prefix "ClosedEndInvestment"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/CollectiveInvestmentVehicle">fibo-sec-fund-fund:CollectiveInvestmentVehicle</a>
    /// </summary>
    let CollectiveInvestmentVehicle = _prefixId.prefix "CollectiveInvestmentVehicle"
    /// <summary>
    ///   <para>rdfs:label : community investment fund</para>
    ///   <para>skos:definition : professionally-managed investment fund with three essential characteristics: capital is sourced from people in the community (ideally from retail/non-accredited investors); capital is invested into local people, projects, and businesses; and capital is deployed by individuals in the community, typically but not necessarily a nonprofit fund</para>
    ///   <para>cmns-av:abbreviation : CIF</para>
    ///   <para>cmns-av:adaptedFrom : Community Investment Fund Handbook and Toolkit, available at https://www.nc3now.org/community-investment-fund-handbook--toolkit.html.</para>
    ///   <para>cmns-av:explanatoryNote : A community investment fund is typically but not necessarily a nonprofit fund.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/CommunityInvestmentFund">fibo-sec-fund-fund:CommunityInvestmentFund</a>
    /// </summary>
    let CommunityInvestmentFund = _prefixId.prefix "CommunityInvestmentFund"

    /// <summary>
    ///   <para>rdfs:label : diversified community investment fund</para>
    ///   <para>dcterms:source : Diversified Community Investment Fund, available at https://www.nc3now.org/uploads/1/4/0/1/140134350/dcif_overview.pdf.</para>
    ///   <para>skos:definition : community investment fund that invests primarily in real estate but can also invest in any local business or project, and can do so with investment capital raised publicly from within the fund's own community, including community investors</para>
    ///   <para>cmns-av:abbreviation : DCIF</para>
    ///   <para>cmns-av:explanatoryNote : A Diversified Community Investment Fund (DCIF) is a specialized community-scale investment vehicle structured to both support local development and comply with U.S. securities laws - particularly the Investment Company Act of 1940 (the 'ICA'). This type of fund must meet two requirements: (1) its primary business is investing in real estate, rather than securities (e.g., stock) issued by other companies; and (2) real estate and other non-securities assets must comprise at least 60% of the fund's assets. The DCIF structure is intentionally calibrated to circumvent classification as an investment company - which would trigger certain SEC registration and disclosure requirements. Under the ICA, if a fund is 'primarily engaged in ... investing ... in securities,' it must register as an investment company. By meeting the 60/40 real estate-to-business allocation, the DCIF qualifies instead as a real estate fund, avoiding that designation.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/DiversifiedCommunityInvestmentFund">fibo-sec-fund-fund:DiversifiedCommunityInvestmentFund</a>
    /// </summary>
    let DiversifiedCommunityInvestmentFund =
        _prefixId.prefix "DiversifiedCommunityInvestmentFund"

    /// <summary>
    ///   <para>rdfs:label : exchange-traded fund</para>
    ///   <para>skos:definition : investment fund whose fund units are traded on an exchange, much like stocks</para>
    ///   <para>cmns-av:abbreviation : ETF</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962:2019 Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : An ETF holds assets such as stocks, commodities, or bonds, and trades close to its net asset value over the course of the trading day. Most ETFs track an index, such as a stock, bond, or commodity index.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/ExchangeTradedFund">fibo-sec-fund-fund:ExchangeTradedFund</a>
    /// </summary>
    let ExchangeTradedFund = _prefixId.prefix "ExchangeTradedFund"
    /// <summary>
    ///   <para>rdfs:label : fund administrator</para>
    ///   <para>skos:definition : role of the party responsible for managing the operational, accounting, and compliance functions of an investment fund</para>
    ///   <para>cmns-av:explanatoryNote : A fund administrator performs administrative tasks on behalf of an investment fund, including net asset value (NAV) calculation, financial reporting, investor servicing, and regulatory compliance. The role supports operational efficiency and transparency, enabling fund managers to focus on investment strategy.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundAdministrator">fibo-sec-fund-fund:FundAdministrator</a>
    /// </summary>
    let FundAdministrator = _prefixId.prefix "FundAdministrator"
    /// <summary>
    ///   <para>rdfs:label : fund contract</para>
    ///   <para>skos:definition : contract that embodies and defines the fund legal form in cases where there is no independent organization</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundContract">fibo-sec-fund-fund:FundContract</a>
    /// </summary>
    let FundContract = _prefixId.prefix "FundContract"
    /// <summary>
    ///   <para>rdfs:label : fund holder^^xsd:string</para>
    ///   <para>skos:definition : party that owns units in or a percentage of and has rights and responsibilities with respect to some fund, provided in exchange for investment^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that in some cases the concept of 'fund holder' may be synonymous with shareholder, but not all.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundHolder">fibo-sec-fund-fund:FundHolder</a>
    /// </summary>
    let FundHolder = _prefixId.prefix "FundHolder"
    /// <summary>
    ///   <para>rdfs:label : fund holding^^xsd:string</para>
    ///   <para>skos:definition : ownership interest in a fund, which may represented by fund units that confer financial rights and governance privileges^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundHolding">fibo-sec-fund-fund:FundHolding</a>
    /// </summary>
    let FundHolding = _prefixId.prefix "FundHolding"
    /// <summary>
    ///   <para>rdfs:label : fund manager</para>
    ///   <para>skos:definition : role of the party responsible for making investment decisions and managing the portfolio of an investment fund</para>
    ///   <para>cmns-av:explanatoryNote : A fund manager is an individual or entity that oversees the investment strategy and asset allocation of a fund, with the objective of achieving financial returns in accordance with the fund's mandate. The fund manager may operate under regulatory oversight and fiduciary obligations, and may be supported by analysts, traders, and compliance officers.cmns-av:explanatoryNote : A fund manager, often a mutual fund company, a brokerage firm, an investment adviser, or an insurance company, handles all of the transactions and investments within the plan.</para>
    ///   <para>cmns-av:synonym : plan managercmns-av:synonym : program manager</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundManager">fibo-sec-fund-fund:FundManager</a>
    /// </summary>
    let FundManager = _prefixId.prefix "FundManager"
    /// <summary>
    ///   <para>rdfs:label : fund of funds</para>
    ///   <para>skos:definition : investment fund that invests directly in other investment funds rather than investing in stocks, bonds, and other securities</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962:2019 Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth edition, October 2019</para>
    ///   <para>cmns-av:synonym : umbrella fund</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundOfFunds">fibo-sec-fund-fund:FundOfFunds</a>
    /// </summary>
    let FundOfFunds = _prefixId.prefix "FundOfFunds"
    /// <summary>
    ///   <para>rdfs:label : fund position</para>
    ///   <para>skos:definition : position in some fund, which may be defined in terms of fund units</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundPosition">fibo-sec-fund-fund:FundPosition</a>
    /// </summary>
    let FundPosition = _prefixId.prefix "FundPosition"
    /// <summary>
    ///   <para>rdfs:label : fund unit^^xsd:string</para>
    ///   <para>skos:definition : quantified share of beneficial interest in a pooled fund, representing a proportional claim on the fund's assets, income, or entitlements^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A fund unit may be tradable or non-tradable depending on the legal form, regulatory status, and operational framework of the fund.^^xsd:stringcmns-av:explanatoryNote : Fund units are allocated to a participant, investor, or beneficiary according to the fund's governing structure.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundUnit">fibo-sec-fund-fund:FundUnit</a>
    /// </summary>
    let FundUnit = _prefixId.prefix "FundUnit"
    /// <summary>
    ///   <para>rdfs:label : hedge fund</para>
    ///   <para>skos:definition : investment fund that pursues a total return and is usually open to qualified investors only</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962:2019 Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth edition, October 2019</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/HedgeFund">fibo-sec-fund-fund:HedgeFund</a>
    /// </summary>
    let HedgeFund = _prefixId.prefix "HedgeFund"
    /// <summary>
    ///   <para>rdfs:label : legal fund structure</para>
    ///   <para>skos:definition : structure of a fund with respect to its legal formation in some jurisdiction</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/LegalFundStructure">fibo-sec-fund-fund:LegalFundStructure</a>
    /// </summary>
    let LegalFundStructure = _prefixId.prefix "LegalFundStructure"
    /// <summary>
    ///   <para>rdfs:label : mutual fund</para>
    ///   <para>skos:definition : open-end professionally managed investment fund established for the purpose of investing in securities such as stocks, bonds, money market instruments and similar assets</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962:2019 Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth edition, October 2019</para>
    ///   <para>cmns-av:synonym : standard (vanilla) investment fund</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/MutualFund">fibo-sec-fund-fund:MutualFund</a>
    /// </summary>
    let MutualFund = _prefixId.prefix "MutualFund"
    /// <summary>
    ///   <para>rdfs:label : non-tradable fund unit</para>
    ///   <para>skos:definition : security representing an interest in a fund that cannot be traded ontside of the fund itself</para>
    ///   <para>cmns-av:explanatoryNote : Non-tradable fund units are commonly found in pension funds, insurance pools, or internal benefit plans, where units serve as accounting or entitlement mechanisms without market transferability.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/NonTradableFundUnit">fibo-sec-fund-fund:NonTradableFundUnit</a>
    /// </summary>
    let NonTradableFundUnit = _prefixId.prefix "NonTradableFundUnit"
    /// <summary>
    ///   <para>rdfs:label : nonprofit fund</para>
    ///   <para>skos:definition : investment vehicle designed to support a nonprofit mission, whose objectives include environmental stewardship and/or social responsibility in addition to financial performance</para>
    ///   <para>skos:example : Common examples include endowment funds (permanently invested, only earnings are spent), operating funds (used for day-to-day expenses), and special project funds (earmarked for particular initiatives).</para>
    ///   <para>cmns-av:explanatoryNote : A nonprofit fund is a pool of financial resources that is established and managed by a nonprofit organization to support its mission and activities, organized for charitable, educational, religious, cultural, or other purposes recognized as serving the public good. Some nonprofit funds are restricted by donors for a specific use (such as an endowment for scholarships), while others are unrestricted and can be used at the nonprofit's discretion.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/NonprofitFund">fibo-sec-fund-fund:NonprofitFund</a>
    /// </summary>
    let NonprofitFund = _prefixId.prefix "NonprofitFund"
    /// <summary>
    ///   <para>rdfs:label : open-end investment</para>
    ///   <para>skos:definition : investment fund that offered through a fund company that sells shares directly to investors</para>
    ///   <para>cmns-av:synonym : open-end fund</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/OpenEndInvestment">fibo-sec-fund-fund:OpenEndInvestment</a>
    /// </summary>
    let OpenEndInvestment = _prefixId.prefix "OpenEndInvestment"
    /// <summary>
    ///   <para>rdfs:label : pension fund</para>
    ///   <para>skos:definition : investment fund run by a financial intermediary on behalf of an organization and its employees/members</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962:2019 Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : A pension fund is a common asset pool meant to generate stable growth over a long-term investment horizon.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/PensionFund">fibo-sec-fund-fund:PensionFund</a>
    /// </summary>
    let PensionFund = _prefixId.prefix "PensionFund"
    /// <summary>
    ///   <para>rdfs:label : private credit fund</para>
    ///   <para>skos:definition : investment vehicle that provides loans or other forms of credit to companies, typically outside of the traditional banking system</para>
    ///   <para>cmns-av:explanatoryNote : These funds are managed by asset managers, private equity firms or specialized lenders (both nonprofit and for-profit) and cater to institutional investors, high-net-worth individuals, family offices, and, in some cases, retail investors. The kinds of loans they provide include senior secured loans, mezzanine debt, unitranche loans, and special situations financing through direct lending to companies. These funds are typically illiquid, with long investment horizons (5–10 years). They generally provide higher returns than traditional fixed-income instruments, but with greater risk due to borrower default potential. Nonprofit funds may provide lower returns because of the mission to provide affordable funding to disadvantaged borrowers. Key features of private credit funds include:
    /// - Loans are held on the fund's balance sheet
    /// - Returns come primarily from interest income and potential capital appreciation
    /// - Often involve direct negotiations and customized loan terms.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/PrivateCreditFund">fibo-sec-fund-fund:PrivateCreditFund</a>
    /// </summary>
    let PrivateCreditFund = _prefixId.prefix "PrivateCreditFund"
    /// <summary>
    ///   <para>rdfs:label : private equity fund</para>
    ///   <para>skos:definition : investment fund used for making investments in various equity (and to a lesser extent debt) securities according to an investment strategy associated with private equity</para>
    ///   <para>cmns-av:abbreviation : PE fund</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962:2019 Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : Private equity funds are typically structured as limited partnerships or limited liability companies, wherein investors are limited partners, and the fund is managed by one or more general partners. It is composed of investors and funds that invest directly in private companies, or that engage in buyouts of public companies, resulting in the delisting of the public equity.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/PrivateEquityFund">fibo-sec-fund-fund:PrivateEquityFund</a>
    /// </summary>
    let PrivateEquityFund = _prefixId.prefix "PrivateEquityFund"
    /// <summary>
    ///   <para>rdfs:label : real estate investment trust</para>
    ///   <para>skos:definition : investment fund that offers shares/units to the public and invests in real estate directly</para>
    ///   <para>cmns-av:abbreviation : REIT</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962:2019 Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : Real estate investment trusts own, and in most cases operate, income-producing real estate. REITs own many types of commercial real estate, ranging from office and apartment buildings to warehouses, hospitals, shopping centers, hotels and commercial forests. Some REITs engage in financing real estate.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/RealEstateInvestmentTrust">fibo-sec-fund-fund:RealEstateInvestmentTrust</a>
    /// </summary>
    let RealEstateInvestmentTrust = _prefixId.prefix "RealEstateInvestmentTrust"
    /// <summary>
    ///   <para>rdfs:label : sovereign wealth fund</para>
    ///   <para>skos:definition : state-owned investment fund that consists of pools of money derived from a country's reserves</para>
    ///   <para>cmns-av:explanatoryNote : Sovereign wealth funds include the International Monetary Fund, whose corresponding legal entity is a polity.</para>
    ///   <para>cmns-av:synonym : social wealth fundcmns-av:synonym : sovereign investment fund</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/SovereignWealthFund">fibo-sec-fund-fund:SovereignWealthFund</a>
    /// </summary>
    let SovereignWealthFund = _prefixId.prefix "SovereignWealthFund"
    /// <summary>
    ///   <para>rdfs:label : tradable fund unit</para>
    ///   <para>skos:definition : security representing a tradable interest in a fund</para>
    ///   <para>cmns-av:explanatoryNote : Tradable fund units typically occur in collective investment schemes such as mutual funds or exchange-traded funds (ETFs), where units are bought and sold on regulated markets.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/TradableFundUnit">fibo-sec-fund-fund:TradableFundUnit</a>
    /// </summary>
    let TradableFundUnit = _prefixId.prefix "TradableFundUnit"
    /// <summary>
    ///   <para>rdfs:label : unit trust</para>
    ///   <para>skos:definition : pooled investment vehicle in which investors hold units that represent beneficial ownership in a trust-managed portfolio of assets</para>
    ///   <para>cmns-av:explanatoryNote : A unit trust is established under a trust deed, with a trustee holding legal title to the assets and a fund manager making investment decisions. They are common in the UK, Australia, Singapore, and other Commonwealth countries.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/UnitTrust">fibo-sec-fund-fund:UnitTrust</a>
    /// </summary>
    let UnitTrust = _prefixId.prefix "UnitTrust"
    /// <summary>
    ///   <para>rdfs:label : unitized fund</para>
    ///   <para>skos:definition : pooled investment vehicle in which investors hold units that represent a proportional share of the fund's underlying assets, typically used in pensions or insurance-based products</para>
    ///   <para>skos:example : Examples include authorized unit trusts (AUTs), investment companies with variable capital (ICVCs), and insurance-linked unitized funds.</para>
    ///   <para>cmns-av:explanatoryNote : The concept of a 'unitized fund' comes up in the context of the Financial Conduct Authority (FCA)'s framework for collective investment schemes (CIS) in the United Kingdom, particularly in the context of authorized unit trusts (AUTs) and insurance-based investments.cmns-av:explanatoryNote : The differentiator with respect to a unitized fund is that investors hold units, rather than a direct shareholding or segregated account.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/UnitizedFund">fibo-sec-fund-fund:UnitizedFund</a>
    /// </summary>
    let UnitizedFund = _prefixId.prefix "UnitizedFund"
    /// <summary>
    ///   <para>rdfs:label : has legal structure</para>
    ///   <para>skos:definition : indicates the legal form that the fund takes</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/hasLegalStructure">fibo-sec-fund-fund:hasLegalStructure</a>
    /// </summary>
    let hasLegalStructure = _prefixId.prefix "hasLegalStructure"
    /// <summary>
    ///   <para>rdfs:label : has sub-fund</para>
    ///   <para>skos:definition : relates a pooled fund to a sub-fund that is a constituent of the parent fund</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/hasSubFund">fibo-sec-fund-fund:hasSubFund</a>
    /// </summary>
    let hasSubFund = _prefixId.prefix "hasSubFund"
    /// <summary>
    ///   <para>rdfs:label : is open ended</para>
    ///   <para>skos:definition : indicates whether the fund is an open-end/closed-end fund</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/isOpenEnded">fibo-sec-fund-fund:isOpenEnded</a>
    /// </summary>
    let isOpenEnded = _prefixId.prefix "isOpenEnded"
    /// <summary>
    ///   <para>rdfs:label : is private</para>
    ///   <para>skos:definition : indicates that the fund does not offer its securities to the general public</para>
    ///   <para>cmns-av:explanatoryNote : In the U.S., private funds are exempt from certain regulations under the Investment Company Act of 1940. Common types include venture capital funds, private equity funds, and some hedge funds. They often target illiquid assets or use aggressive strategies, offering flexibility compared to public funds.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/isPrivate">fibo-sec-fund-fund:isPrivate</a>
    /// </summary>
    let isPrivate = _prefixId.prefix "isPrivate"
    /// <summary>
    ///   <para>rdfs:label : is sub-fund of</para>
    ///   <para>skos:definition : relates a pooled fund to a parent fund</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/isSubFundOf">fibo-sec-fund-fund:isSubFundOf</a>
    /// </summary>
    let isSubFundOf = _prefixId.prefix "isSubFundOf"
