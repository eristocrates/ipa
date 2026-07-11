namespace Fibo.FND.TransactionsExt.MarketTransactions.Namespace
module MarketTransactions =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/TransactionsExt/MarketTransactions/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/TransactionsExt/MarketTransactions.rdf") (Some @"fibo.FND.TransactionsExt.MarketTransactions") None
    let MarketTransaction = {_prefixID with _localName = "MarketTransaction"}
    let MarketTransactionInvoicingTerms = {_prefixID with _localName = "MarketTransactionInvoicingTerms"}
    let MarketTransactionPaymentTerms = {_prefixID with _localName = "MarketTransactionPaymentTerms"}
    let TransactionCounterparty = {_prefixID with _localName = "TransactionCounterparty"}
    let TransactionPrincipal = {_prefixID with _localName = "TransactionPrincipal"}
    let consideration = {_prefixID with _localName = "consideration"}
    let paymentTerms = {_prefixID with _localName = "paymentTerms"}