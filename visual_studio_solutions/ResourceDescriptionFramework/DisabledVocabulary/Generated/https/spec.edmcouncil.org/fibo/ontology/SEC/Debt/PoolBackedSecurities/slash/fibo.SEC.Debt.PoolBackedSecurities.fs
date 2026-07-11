namespace Fibo.SEC.Debt.PoolBackedSecurities.Namespace
module PoolBackedSecurities =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Debt/PoolBackedSecurities.rdf") (Some @"fibo.SEC.Debt.PoolBackedSecurities") None
    let AbsolutePrepaymentRate = {_prefixID with _localName = "AbsolutePrepaymentRate"}
    let AssetBackedSecurity = {_prefixID with _localName = "AssetBackedSecurity"}
    let AttachmentPoint = {_prefixID with _localName = "AttachmentPoint"}
    let DebtPoolStatisticalMeasure = {_prefixID with _localName = "DebtPoolStatisticalMeasure"}
    let DefaultRate = {_prefixID with _localName = "DefaultRate"}
    let DetachmentPoint = {_prefixID with _localName = "DetachmentPoint"}
    let PoolBackedSecurity = {_prefixID with _localName = "PoolBackedSecurity"}
    let PrepaymentSpeed = {_prefixID with _localName = "PrepaymentSpeed"}
    let PrincipalProtectedNote = {_prefixID with _localName = "PrincipalProtectedNote"}
    let SingleMonthlyMortality = {_prefixID with _localName = "SingleMonthlyMortality"}
    let StructuredFinanceInstrument = {_prefixID with _localName = "StructuredFinanceInstrument"}
    let StructuredFinanceWithoutPrincipalProtection = {_prefixID with _localName = "StructuredFinanceWithoutPrincipalProtection"}
    let Tranche = {_prefixID with _localName = "Tranche"}
    let WeightedAverageCoupon = {_prefixID with _localName = "WeightedAverageCoupon"}
    let WeightedAverageLife = {_prefixID with _localName = "WeightedAverageLife"}
    let WeightedAverageLoanAge = {_prefixID with _localName = "WeightedAverageLoanAge"}
    let WeightedAverageMaturity = {_prefixID with _localName = "WeightedAverageMaturity"}
    let WeightedAverageRemainingTerm = {_prefixID with _localName = "WeightedAverageRemainingTerm"}
    let hasAttachmentPoint = {_prefixID with _localName = "hasAttachmentPoint"}
    let hasDetachmentPoint = {_prefixID with _localName = "hasDetachmentPoint"}
    let hasEstimatedTotalCollateralValueAtIssuance = {_prefixID with _localName = "hasEstimatedTotalCollateralValueAtIssuance"}
    let isPassThrough = {_prefixID with _localName = "isPassThrough"}