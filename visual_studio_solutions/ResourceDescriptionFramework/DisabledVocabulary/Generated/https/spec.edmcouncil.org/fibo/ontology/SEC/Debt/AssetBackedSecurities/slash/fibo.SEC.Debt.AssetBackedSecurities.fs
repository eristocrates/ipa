namespace Fibo.SEC.Debt.AssetBackedSecurities.Namespace
module AssetBackedSecurities =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Debt/AssetBackedSecurities.rdf") (Some @"fibo.SEC.Debt.AssetBackedSecurities") None
    let AutoAssetBackedSecurity = {_prefixID with _localName = "AutoAssetBackedSecurity"}
    let AutoDebtPool = {_prefixID with _localName = "AutoDebtPool"}
    let BondPool = {_prefixID with _localName = "BondPool"}
    let ConsumerAssetBackedSecurity = {_prefixID with _localName = "ConsumerAssetBackedSecurity"}
    let ControlledAmortizationAssetBackedSecurity = {_prefixID with _localName = "ControlledAmortizationAssetBackedSecurity"}
    let CreditCardAccountPool = {_prefixID with _localName = "CreditCardAccountPool"}
    let CreditCardAssetBackedSecurity = {_prefixID with _localName = "CreditCardAssetBackedSecurity"}
    let FullyAmortizingAssetBackedSecurity = {_prefixID with _localName = "FullyAmortizingAssetBackedSecurity"}
    let HomeEquityLineOfCreditPool = {_prefixID with _localName = "HomeEquityLineOfCreditPool"}
    let HomeEquityLoanAssetBackedSecurity = {_prefixID with _localName = "HomeEquityLoanAssetBackedSecurity"}
    let StudentLoanAssetBackedSecurity = {_prefixID with _localName = "StudentLoanAssetBackedSecurity"}
    let StudentLoanPool = {_prefixID with _localName = "StudentLoanPool"}