namespace Fibo.BP.Process.FinancialContextAndProcess.Namespace
module FinancialContextAndProcess =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BP/Process/FinancialContextAndProcess/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BP/Process/FinancialContextAndProcess.rdf") (Some @"fibo.BP.Process.FinancialContextAndProcess") None
    let Clearing = {_prefixID with _localName = "Clearing"}
    let ClearingAndSettlement = {_prefixID with _localName = "ClearingAndSettlement"}
    let FinancialIndustryContext = {_prefixID with _localName = "FinancialIndustryContext"}
    let FinancialMarketsRegulation = {_prefixID with _localName = "FinancialMarketsRegulation"}
    let InvestmentManagement = {_prefixID with _localName = "InvestmentManagement"}
    let MarketDataProvision = {_prefixID with _localName = "MarketDataProvision"}
    let PortfolioManagement = {_prefixID with _localName = "PortfolioManagement"}
    let PreTrade = {_prefixID with _localName = "PreTrade"}
    let PretradeQuotes = {_prefixID with _localName = "PretradeQuotes"}
    let PretradeReferenceDataProvision = {_prefixID with _localName = "PretradeReferenceDataProvision"}
    let PrimaryMarket = {_prefixID with _localName = "PrimaryMarket"}
    let PrimaryMarketClosing = {_prefixID with _localName = "PrimaryMarketClosing"}
    let PrimaryMarketIndicationsOfInterest = {_prefixID with _localName = "PrimaryMarketIndicationsOfInterest"}
    let SecondaryMarketTradingContext = {_prefixID with _localName = "SecondaryMarketTradingContext"}
    let SecuritiesCustody = {_prefixID with _localName = "SecuritiesCustody"}
    let SecuritiesPostTrade = {_prefixID with _localName = "SecuritiesPostTrade"}
    let SecuritiesPostTradePositionManagement = {_prefixID with _localName = "SecuritiesPostTradePositionManagement"}
    let SecuritiesTrade = {_prefixID with _localName = "SecuritiesTrade"}
    let SecuritiesTradeAllocation = {_prefixID with _localName = "SecuritiesTradeAllocation"}
    let SecuritiesTradeCaptureAndValidation = {_prefixID with _localName = "SecuritiesTradeCaptureAndValidation"}
    let SecuritiesTradeConfirmationAffirmation = {_prefixID with _localName = "SecuritiesTradeConfirmationAffirmation"}
    let SecuritiesTradeDatePositionReporting = {_prefixID with _localName = "SecuritiesTradeDatePositionReporting"}
    let SecuritiesTradeExecution = {_prefixID with _localName = "SecuritiesTradeExecution"}
    let SecuritiesTradeOrderRouting = {_prefixID with _localName = "SecuritiesTradeOrderRouting"}
    let SecuritiesTradesMatching = {_prefixID with _localName = "SecuritiesTradesMatching"}
    let SecuritiesTradesReporting = {_prefixID with _localName = "SecuritiesTradesReporting"}
    let SecurityRetirement = {_prefixID with _localName = "SecurityRetirement"}
    let ShortSaleLocate = {_prefixID with _localName = "ShortSaleLocate"}
    let TradeAdvertisements = {_prefixID with _localName = "TradeAdvertisements"}
    let TradedSecurityLifecycle = {_prefixID with _localName = "TradedSecurityLifecycle"}
    let TradesReferenceDataProvision = {_prefixID with _localName = "TradesReferenceDataProvision"}
    let WhenIssuedTrading = {_prefixID with _localName = "WhenIssuedTrading"}
    let isRetirementOf = {_prefixID with _localName = "isRetirementOf"}