namespace Fibo.SEC.Debt.SyntheticCDOs.Namespace
module SyntheticCDOs =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/SyntheticCDOs/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Debt/SyntheticCDOs.rdf") (Some @"fibo.SEC.Debt.SyntheticCDOs") None
    let ArbitrageSyntheticCDO = {_prefixID with _localName = "ArbitrageSyntheticCDO"}
    let SyntheticAmortizingSecurity = {_prefixID with _localName = "SyntheticAmortizingSecurity"}
    let SyntheticBalanceSheetCDO = {_prefixID with _localName = "SyntheticBalanceSheetCDO"}
    let SyntheticCDO = {_prefixID with _localName = "SyntheticCDO"}
    let SyntheticCDOPortfolio = {_prefixID with _localName = "SyntheticCDOPortfolio"}
    let SyntheticCDOPortfolioConstituent = {_prefixID with _localName = "SyntheticCDOPortfolioConstituent"}
    let SyntheticCDOTranche = {_prefixID with _localName = "SyntheticCDOTranche"}
    let SyntheticDebtInstrumentPool = {_prefixID with _localName = "SyntheticDebtInstrumentPool"}
    let SyntheticDebtInstrumentPoolFundingAsset = {_prefixID with _localName = "SyntheticDebtInstrumentPoolFundingAsset"}
    let SyntheticDebtSPV = {_prefixID with _localName = "SyntheticDebtSPV"}
    let SyntheticPoolAsset = {_prefixID with _localName = "SyntheticPoolAsset"}
    let SyntheticStructuredFinanceInstrument = {_prefixID with _localName = "SyntheticStructuredFinanceInstrument"}
    let assetsManagedBy = {_prefixID with _localName = "assetsManagedBy"}
    let fundedBy = {_prefixID with _localName = "fundedBy"}
    let hasInvestmentGrade = {_prefixID with _localName = "hasInvestmentGrade"}
    let hasUnderlyingContract = {_prefixID with _localName = "hasUnderlyingContract"}
    let holds = {_prefixID with _localName = "holds"}
    let isCash = {_prefixID with _localName = "isCash"}
    let isTrancheOf = {_prefixID with _localName = "isTrancheOf"}
    let issues = {_prefixID with _localName = "issues"}
    let makesReferenceTo = {_prefixID with _localName = "makesReferenceTo"}
    let notionallyHolds = {_prefixID with _localName = "notionallyHolds"}
    let percentageOfDefaultsThisTranche = {_prefixID with _localName = "percentageOfDefaultsThisTranche"}
    let simulatedBy = {_prefixID with _localName = "simulatedBy"}
    let simulates = {_prefixID with _localName = "simulates"}
    let ``simulates.1`` = {_prefixID with _localName = "simulates.1"}
    let trancheType = {_prefixID with _localName = "trancheType"}