namespace Fibo.SEC.Securities.EuropeanSecurities.EUSecuritiesRestrictions.Namespace
module EUSecuritiesRestrictions =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions.rdf") (Some @"fibo.SEC.Securities.EuropeanSecurities.EUSecuritiesRestrictions") None
    let AdditionalTier1Capital = {_prefixID with _localName = "AdditionalTier1Capital"}
    let BaselIIIDesignation = {_prefixID with _localName = "BaselIIIDesignation"}
    let CommonEquityTier1 = {_prefixID with _localName = "CommonEquityTier1"}
    let ``EURegulation236-2012`` = {_prefixID with _localName = "EURegulation236-2012"}
    let MiFIDRegulatedSecurity = {_prefixID with _localName = "MiFIDRegulatedSecurity"}
    let Tier1Capital = {_prefixID with _localName = "Tier1Capital"}
    let Tier2Capital = {_prefixID with _localName = "Tier2Capital"}
    let hasUpperLimitOnFloatingShares = {_prefixID with _localName = "hasUpperLimitOnFloatingShares"}
    let isMiFIDReportingRequired = {_prefixID with _localName = "isMiFIDReportingRequired"}