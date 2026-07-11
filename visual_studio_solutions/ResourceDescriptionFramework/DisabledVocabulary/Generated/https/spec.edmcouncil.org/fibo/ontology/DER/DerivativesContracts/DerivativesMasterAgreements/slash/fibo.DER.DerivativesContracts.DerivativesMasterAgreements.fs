namespace Fibo.DER.DerivativesContracts.DerivativesMasterAgreements.Namespace
module DerivativesMasterAgreements =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/DER/DerivativesContracts/DerivativesMasterAgreements.rdf") (Some @"fibo.DER.DerivativesContracts.DerivativesMasterAgreements") None
    let AccountChangeNotificationObligation = {_prefixID with _localName = "AccountChangeNotificationObligation"}
    let DerivativeCreditSupportAgreement = {_prefixID with _localName = "DerivativeCreditSupportAgreement"}
    let DerivativeMasterAgreement = {_prefixID with _localName = "DerivativeMasterAgreement"}
    let MasterAgreementEarlyTerminationRight = {_prefixID with _localName = "MasterAgreementEarlyTerminationRight"}