namespace Fibo.FND.TransactionsExt.SecuritiesTransactions.Namespace
module SecuritiesTransactions =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/TransactionsExt/SecuritiesTransactions/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/TransactionsExt/SecuritiesTransactions.rdf") (Some @"fibo.FND.TransactionsExt.SecuritiesTransactions") None
    let FinancialPrimaryMarketTransaction = {_prefixID with _localName = "FinancialPrimaryMarketTransaction"}
    let FinancialSecuritiesSecondaryMarketTransaction = {_prefixID with _localName = "FinancialSecuritiesSecondaryMarketTransaction"}
    let SecuritiesTransactionContract = {_prefixID with _localName = "SecuritiesTransactionContract"}
    let SecuritiesTransactionCounterparty = {_prefixID with _localName = "SecuritiesTransactionCounterparty"}
    let SecuritiesTransactionPrincipal = {_prefixID with _localName = "SecuritiesTransactionPrincipal"}
    let SettlementProcess = {_prefixID with _localName = "SettlementProcess"}
    let WhenIssuedTransaction = {_prefixID with _localName = "WhenIssuedTransaction"}
    let embodies = {_prefixID with _localName = "embodies"}
    let follows = {_prefixID with _localName = "follows"}
    let governs = {_prefixID with _localName = "governs"}
    let offsetForWIIssueDate = {_prefixID with _localName = "offsetForWIIssueDate"}