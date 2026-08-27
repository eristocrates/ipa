namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Funds.Funds.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_fund_fund =
    let _namespace_iri = Namespace_Iri fibo_sec_fund_fund |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-fund-fund:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Funds Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_fund_fund, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:AlignedCommunityInvestmentFund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"aligned community investment fund"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/AlignedCommunityInvestmentFund">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/AlignedCommunityInvestmentFund</seealso>
    let AlignedCommunityInvestmentFund =
        Prefixed_Name(fibo_sec_fund_fund, "AlignedCommunityInvestmentFund") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:ClosedEndInvestment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"closed-end investment"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/ClosedEndInvestment">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/ClosedEndInvestment</seealso>
    let ClosedEndInvestment =
        Prefixed_Name(fibo_sec_fund_fund, "ClosedEndInvestment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:CollectiveInvestmentVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/CollectiveInvestmentVehicle">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/CollectiveInvestmentVehicle</seealso>
    let CollectiveInvestmentVehicle =
        Prefixed_Name(fibo_sec_fund_fund, "CollectiveInvestmentVehicle") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:CommunityInvestmentFund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"community investment fund"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/CommunityInvestmentFund">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/CommunityInvestmentFund</seealso>
    let CommunityInvestmentFund =
        Prefixed_Name(fibo_sec_fund_fund, "CommunityInvestmentFund") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:DiversifiedCommunityInvestmentFund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"diversified community investment fund"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/DiversifiedCommunityInvestmentFund">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/DiversifiedCommunityInvestmentFund</seealso>
    let DiversifiedCommunityInvestmentFund =
        Prefixed_Name(fibo_sec_fund_fund, "DiversifiedCommunityInvestmentFund") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:ExchangeTradedFund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exchange-traded fund"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/ExchangeTradedFund">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/ExchangeTradedFund</seealso>
    let ExchangeTradedFund =
        Prefixed_Name(fibo_sec_fund_fund, "ExchangeTradedFund") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:FundAdministrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fund administrator"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundAdministrator">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundAdministrator</seealso>
    let FundAdministrator =
        Prefixed_Name(fibo_sec_fund_fund, "FundAdministrator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:FundContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fund contract"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundContract">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundContract</seealso>
    let FundContract = Prefixed_Name(fibo_sec_fund_fund, "FundContract") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-fund-fund:FundHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fund holder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundHolder">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundHolder</seealso>
    let FundHolder = Prefixed_Name(fibo_sec_fund_fund, "FundHolder") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-fund-fund:FundHolding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fund holding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundHolding">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundHolding</seealso>
    let FundHolding = Prefixed_Name(fibo_sec_fund_fund, "FundHolding") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-fund-fund:FundManager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fund manager"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundManager">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundManager</seealso>
    let FundManager = Prefixed_Name(fibo_sec_fund_fund, "FundManager") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-fund-fund:FundOfFunds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fund of funds"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundOfFunds">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundOfFunds</seealso>
    let FundOfFunds = Prefixed_Name(fibo_sec_fund_fund, "FundOfFunds") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-fund-fund:FundPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fund position"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundPosition">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundPosition</seealso>
    let FundPosition = Prefixed_Name(fibo_sec_fund_fund, "FundPosition") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-fund-fund:FundUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fund unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundUnit">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundUnit</seealso>
    let FundUnit = Prefixed_Name(fibo_sec_fund_fund, "FundUnit") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-fund-fund:HedgeFund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hedge fund"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/HedgeFund">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/HedgeFund</seealso>
    let HedgeFund = Prefixed_Name(fibo_sec_fund_fund, "HedgeFund") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:LegalFundStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal fund structure"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/LegalFundStructure">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/LegalFundStructure</seealso>
    let LegalFundStructure =
        Prefixed_Name(fibo_sec_fund_fund, "LegalFundStructure") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:MutualFund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mutual fund"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/MutualFund">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/MutualFund</seealso>
    let MutualFund = Prefixed_Name(fibo_sec_fund_fund, "MutualFund") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:NonTradableFundUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-tradable fund unit"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/NonTradableFundUnit">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/NonTradableFundUnit</seealso>
    let NonTradableFundUnit =
        Prefixed_Name(fibo_sec_fund_fund, "NonTradableFundUnit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:NonprofitFund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nonprofit fund"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/NonprofitFund">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/NonprofitFund</seealso>
    let NonprofitFund =
        Prefixed_Name(fibo_sec_fund_fund, "NonprofitFund") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:OpenEndInvestment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"open-end investment"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/OpenEndInvestment">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/OpenEndInvestment</seealso>
    let OpenEndInvestment =
        Prefixed_Name(fibo_sec_fund_fund, "OpenEndInvestment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:PensionFund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pension fund"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/PensionFund">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/PensionFund</seealso>
    let PensionFund = Prefixed_Name(fibo_sec_fund_fund, "PensionFund") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:PrivateCreditFund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"private credit fund"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/PrivateCreditFund">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/PrivateCreditFund</seealso>
    let PrivateCreditFund =
        Prefixed_Name(fibo_sec_fund_fund, "PrivateCreditFund") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:PrivateEquityFund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"private equity fund"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/PrivateEquityFund">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/PrivateEquityFund</seealso>
    let PrivateEquityFund =
        Prefixed_Name(fibo_sec_fund_fund, "PrivateEquityFund") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:RealEstateInvestmentTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"real estate investment trust"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/RealEstateInvestmentTrust">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/RealEstateInvestmentTrust</seealso>
    let RealEstateInvestmentTrust =
        Prefixed_Name(fibo_sec_fund_fund, "RealEstateInvestmentTrust") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:SovereignWealthFund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sovereign wealth fund"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/SovereignWealthFund">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/SovereignWealthFund</seealso>
    let SovereignWealthFund =
        Prefixed_Name(fibo_sec_fund_fund, "SovereignWealthFund") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:TradableFundUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tradable fund unit"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/TradableFundUnit">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/TradableFundUnit</seealso>
    let TradableFundUnit =
        Prefixed_Name(fibo_sec_fund_fund, "TradableFundUnit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:UnitTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unit trust"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/UnitTrust">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/UnitTrust</seealso>
    let UnitTrust = Prefixed_Name(fibo_sec_fund_fund, "UnitTrust") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-fund-fund:UnitizedFund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unitized fund"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/UnitizedFund">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/UnitizedFund</seealso>
    let UnitizedFund = Prefixed_Name(fibo_sec_fund_fund, "UnitizedFund") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:hasLegalStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has legal structure"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/hasLegalStructure">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/hasLegalStructure</seealso>
    let hasLegalStructure =
        Prefixed_Name(fibo_sec_fund_fund, "hasLegalStructure") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-fund-fund:hasSubFund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has sub-fund"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/hasSubFund">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/hasSubFund</seealso>
    let hasSubFund = Prefixed_Name(fibo_sec_fund_fund, "hasSubFund") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-fund-fund:isOpenEnded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is open ended"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/isOpenEnded">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/isOpenEnded</seealso>
    let isOpenEnded = Prefixed_Name(fibo_sec_fund_fund, "isOpenEnded") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-fund-fund:isPrivate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is private"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/isPrivate">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/isPrivate</seealso>
    let isPrivate = Prefixed_Name(fibo_sec_fund_fund, "isPrivate") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-fund-fund:isSubFundOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is sub-fund of"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/isSubFundOf">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/isSubFundOf</seealso>
    let isSubFundOf = Prefixed_Name(fibo_sec_fund_fund, "isSubFundOf") |> PrefixedName
