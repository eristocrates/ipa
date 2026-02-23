namespace Fibo.BP.SecuritiesIssuance.IssuanceDocuments.Namespace
module IssuanceDocuments =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BP/SecuritiesIssuance/IssuanceDocuments/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BP/SecuritiesIssuance/IssuanceDocuments.rdf") (Some @"fibo.BP.SecuritiesIssuance.IssuanceDocuments") None
    let FinalProspectus = {_prefixID with _localName = "FinalProspectus"}
    let Indenture = {_prefixID with _localName = "Indenture"}
    let IssuanceTrustAgreement = {_prefixID with _localName = "IssuanceTrustAgreement"}
    let OfferingDocumentTerms = {_prefixID with _localName = "OfferingDocumentTerms"}
    let PreliminaryProspectus = {_prefixID with _localName = "PreliminaryProspectus"}
    let SecuritiesIssuanceAgreement = {_prefixID with _localName = "SecuritiesIssuanceAgreement"}