namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Funds.Funds.slash

open DoxAletheia

module fibo_sec_fund_fund =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/AlignedCommunityInvestmentFund"></see>
    /// </summary>
    let AlignedCommunityInvestmentFund = _prefix "AlignedCommunityInvestmentFund"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/CommunityInvestmentFund"></see>
    /// </summary>
    let CommunityInvestmentFund = _prefix "CommunityInvestmentFund"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/ClosedEndInvestment"></see>
    /// </summary>
    let ClosedEndInvestment = _prefix "ClosedEndInvestment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/isOpenEnded"></see>
    /// </summary>
    let isOpenEnded = _prefix "isOpenEnded"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/CollectiveInvestmentVehicle"></see>
    /// </summary>
    let CollectiveInvestmentVehicle = _prefix "CollectiveInvestmentVehicle"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/DiversifiedCommunityInvestmentFund"></see>
    /// </summary>
    let DiversifiedCommunityInvestmentFund =
        _prefix "DiversifiedCommunityInvestmentFund"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/ExchangeTradedFund"></see>
    /// </summary>
    let ExchangeTradedFund = _prefix "ExchangeTradedFund"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/OpenEndInvestment"></see>
    /// </summary>
    let OpenEndInvestment = _prefix "OpenEndInvestment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundAdministrator"></see>
    /// </summary>
    let FundAdministrator = _prefix "FundAdministrator"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundContract"></see>
    /// </summary>
    let FundContract = _prefix "FundContract"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundHolder"></see>
    /// </summary>
    let FundHolder = _prefix "FundHolder"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundHolding"></see>
    /// </summary>
    let FundHolding = _prefix "FundHolding"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundUnit"></see>
    /// </summary>
    let FundUnit = _prefix "FundUnit"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundManager"></see>
    /// </summary>
    let FundManager = _prefix "FundManager"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundOfFunds"></see>
    /// </summary>
    let FundOfFunds = _prefix "FundOfFunds"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/hasSubFund"></see>
    /// </summary>
    let hasSubFund = _prefix "hasSubFund"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/FundPosition"></see>
    /// </summary>
    let FundPosition = _prefix "FundPosition"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/HedgeFund"></see>
    /// </summary>
    let HedgeFund = _prefix "HedgeFund"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/LegalFundStructure"></see>
    /// </summary>
    let LegalFundStructure = _prefix "LegalFundStructure"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/MutualFund"></see>
    /// </summary>
    let MutualFund = _prefix "MutualFund"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/NonTradableFundUnit"></see>
    /// </summary>
    let NonTradableFundUnit = _prefix "NonTradableFundUnit"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/TradableFundUnit"></see>
    /// </summary>
    let TradableFundUnit = _prefix "TradableFundUnit"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/NonprofitFund"></see>
    /// </summary>
    let NonprofitFund = _prefix "NonprofitFund"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/PensionFund"></see>
    /// </summary>
    let PensionFund = _prefix "PensionFund"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/PrivateCreditFund"></see>
    /// </summary>
    let PrivateCreditFund = _prefix "PrivateCreditFund"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/PrivateEquityFund"></see>
    /// </summary>
    let PrivateEquityFund = _prefix "PrivateEquityFund"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/RealEstateInvestmentTrust"></see>
    /// </summary>
    let RealEstateInvestmentTrust = _prefix "RealEstateInvestmentTrust"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/hasLegalStructure"></see>
    /// </summary>
    let hasLegalStructure = _prefix "hasLegalStructure"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/SovereignWealthFund"></see>
    /// </summary>
    let SovereignWealthFund = _prefix "SovereignWealthFund"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/UnitTrust"></see>
    /// </summary>
    let UnitTrust = _prefix "UnitTrust"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/UnitizedFund"></see>
    /// </summary>
    let UnitizedFund = _prefix "UnitizedFund"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/isPrivate"></see>
    /// </summary>
    let isPrivate = _prefix "isPrivate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/isSubFundOf"></see>
    /// </summary>
    let isSubFundOf = _prefix "isSubFundOf"
