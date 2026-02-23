namespace Fibo.FND.Accounting.AccountingEquity.Namespace
module AccountingEquity =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/Accounting/AccountingEquity.rdf") (Some @"fibo.FND.Accounting.AccountingEquity") None
    let CapitalSurplus = {_prefixID with _localName = "CapitalSurplus"}
    let EarningsBeforeInterestTaxesDepreciationAmortization = {_prefixID with _localName = "EarningsBeforeInterestTaxesDepreciationAmortization"}
    let FinancialAsset = {_prefixID with _localName = "FinancialAsset"}
    let Income = {_prefixID with _localName = "Income"}
    let OwnersEquity = {_prefixID with _localName = "OwnersEquity"}
    let PaidInCapital = {_prefixID with _localName = "PaidInCapital"}
    let PhysicalAsset = {_prefixID with _localName = "PhysicalAsset"}
    let RetainedEarnings = {_prefixID with _localName = "RetainedEarnings"}
    let ShareholdersEquity = {_prefixID with _localName = "ShareholdersEquity"}