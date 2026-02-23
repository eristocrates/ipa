namespace Fibo.FND.Accounting.CurrencyAmount.Namespace
module CurrencyAmount =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/Accounting/CurrencyAmount.rdf") (Some @"fibo.FND.Accounting.CurrencyAmount") None
    let AmountOfMoney = {_prefixID with _localName = "AmountOfMoney"}
    let CalculatedPrice = {_prefixID with _localName = "CalculatedPrice"}
    let Currency = {_prefixID with _localName = "Currency"}
    let CurrencyBasket = {_prefixID with _localName = "CurrencyBasket"}
    let CurrencyIdentifier = {_prefixID with _localName = "CurrencyIdentifier"}
    let ExchangeRate = {_prefixID with _localName = "ExchangeRate"}
    let Funds = {_prefixID with _localName = "Funds"}
    let FundsIdentifier = {_prefixID with _localName = "FundsIdentifier"}
    let InterestRate = {_prefixID with _localName = "InterestRate"}
    let MonetaryAmount = {_prefixID with _localName = "MonetaryAmount"}
    let MonetaryPrice = {_prefixID with _localName = "MonetaryPrice"}
    let PercentageMonetaryAmount = {_prefixID with _localName = "PercentageMonetaryAmount"}
    let PreciousMetal = {_prefixID with _localName = "PreciousMetal"}
    let PreciousMetalIdentifier = {_prefixID with _localName = "PreciousMetalIdentifier"}
    let Price = {_prefixID with _localName = "Price"}
    let UnitOfAccount = {_prefixID with _localName = "UnitOfAccount"}
    let UnitOfAccountIdentifier = {_prefixID with _localName = "UnitOfAccountIdentifier"}
    let UnitPrice = {_prefixID with _localName = "UnitPrice"}
    let hasAmount = {_prefixID with _localName = "hasAmount"}
    let hasBaseCurrency = {_prefixID with _localName = "hasBaseCurrency"}
    let hasCurrency = {_prefixID with _localName = "hasCurrency"}
    let hasDealtCurrency = {_prefixID with _localName = "hasDealtCurrency"}
    let hasFundsType = {_prefixID with _localName = "hasFundsType"}
    let hasMinorUnit = {_prefixID with _localName = "hasMinorUnit"}
    let hasMonetaryAmount = {_prefixID with _localName = "hasMonetaryAmount"}
    let hasNotionalAmount = {_prefixID with _localName = "hasNotionalAmount"}
    let hasNumericCode = {_prefixID with _localName = "hasNumericCode"}
    let hasPrice = {_prefixID with _localName = "hasPrice"}
    let hasRateValue = {_prefixID with _localName = "hasRateValue"}
    let isPriceFor = {_prefixID with _localName = "isPriceFor"}