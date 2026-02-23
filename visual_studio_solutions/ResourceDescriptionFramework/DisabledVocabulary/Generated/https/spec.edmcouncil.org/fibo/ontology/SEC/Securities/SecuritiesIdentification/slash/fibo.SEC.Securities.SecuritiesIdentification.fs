namespace Fibo.SEC.Securities.SecuritiesIdentification.Namespace
module SecuritiesIdentification =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Securities/SecuritiesIdentification.rdf") (Some @"fibo.SEC.Securities.SecuritiesIdentification") None
    let FinancialInstrumentIdentificationScheme = {_prefixID with _localName = "FinancialInstrumentIdentificationScheme"}
    let InternationalSecuritiesIdentificationNumber = {_prefixID with _localName = "InternationalSecuritiesIdentificationNumber"}
    let InternationalSecuritiesIdentificationNumberingScheme = {_prefixID with _localName = "InternationalSecuritiesIdentificationNumberingScheme"}
    let ListedSecurityIdentifier = {_prefixID with _localName = "ListedSecurityIdentifier"}
    let NationalNumberingAgency = {_prefixID with _localName = "NationalNumberingAgency"}
    let NationalSecuritiesIdentifyingNumber = {_prefixID with _localName = "NationalSecuritiesIdentifyingNumber"}
    let NationalSecuritiesIdentifyingNumberRegistry = {_prefixID with _localName = "NationalSecuritiesIdentifyingNumberRegistry"}
    let NationalSecuritiesIdentifyingNumberRegistryEntry = {_prefixID with _localName = "NationalSecuritiesIdentifyingNumberRegistryEntry"}
    let NationalSecurityIdentificationScheme = {_prefixID with _localName = "NationalSecurityIdentificationScheme"}
    let ProprietarySecurityIdentificationScheme = {_prefixID with _localName = "ProprietarySecurityIdentificationScheme"}
    let ProprietarySecurityIdentifier = {_prefixID with _localName = "ProprietarySecurityIdentifier"}
    let SecurityIdentificationScheme = {_prefixID with _localName = "SecurityIdentificationScheme"}
    let SecurityIdentifier = {_prefixID with _localName = "SecurityIdentifier"}
    let SecurityRegistry = {_prefixID with _localName = "SecurityRegistry"}
    let SecurityRegistryEntry = {_prefixID with _localName = "SecurityRegistryEntry"}
    let TickerSymbol = {_prefixID with _localName = "TickerSymbol"}