namespace Fibo.SEC.Funds.Funds.Namespace
module Funds =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Funds/Funds.rdf") (Some @"fibo.SEC.Funds.Funds") None
    let AlignedCommunityInvestmentFund = {_prefixID with _localName = "AlignedCommunityInvestmentFund"}
    let ClosedEndInvestment = {_prefixID with _localName = "ClosedEndInvestment"}
    let CollectiveInvestmentVehicle = {_prefixID with _localName = "CollectiveInvestmentVehicle"}
    let CommunityInvestmentFund = {_prefixID with _localName = "CommunityInvestmentFund"}
    let DiversifiedCommunityInvestmentFund = {_prefixID with _localName = "DiversifiedCommunityInvestmentFund"}
    let ExchangeTradedFund = {_prefixID with _localName = "ExchangeTradedFund"}
    let FundAdministrator = {_prefixID with _localName = "FundAdministrator"}
    let FundContract = {_prefixID with _localName = "FundContract"}
    let FundHolder = {_prefixID with _localName = "FundHolder"}
    let FundHolding = {_prefixID with _localName = "FundHolding"}
    let FundManager = {_prefixID with _localName = "FundManager"}
    let FundOfFunds = {_prefixID with _localName = "FundOfFunds"}
    let FundPosition = {_prefixID with _localName = "FundPosition"}
    let FundUnit = {_prefixID with _localName = "FundUnit"}
    let HedgeFund = {_prefixID with _localName = "HedgeFund"}
    let LegalFundStructure = {_prefixID with _localName = "LegalFundStructure"}
    let MutualFund = {_prefixID with _localName = "MutualFund"}
    let NonTradableFundUnit = {_prefixID with _localName = "NonTradableFundUnit"}
    let NonprofitFund = {_prefixID with _localName = "NonprofitFund"}
    let OpenEndInvestment = {_prefixID with _localName = "OpenEndInvestment"}
    let PensionFund = {_prefixID with _localName = "PensionFund"}
    let PrivateCreditFund = {_prefixID with _localName = "PrivateCreditFund"}
    let PrivateEquityFund = {_prefixID with _localName = "PrivateEquityFund"}
    let RealEstateInvestmentTrust = {_prefixID with _localName = "RealEstateInvestmentTrust"}
    let SovereignWealthFund = {_prefixID with _localName = "SovereignWealthFund"}
    let TradableFundUnit = {_prefixID with _localName = "TradableFundUnit"}
    let UnitTrust = {_prefixID with _localName = "UnitTrust"}
    let UnitizedFund = {_prefixID with _localName = "UnitizedFund"}
    let hasLegalStructure = {_prefixID with _localName = "hasLegalStructure"}
    let hasSubFund = {_prefixID with _localName = "hasSubFund"}
    let isOpenEnded = {_prefixID with _localName = "isOpenEnded"}
    let isPrivate = {_prefixID with _localName = "isPrivate"}
    let isSubFundOf = {_prefixID with _localName = "isSubFundOf"}