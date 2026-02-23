namespace Fibo.FBC.FunctionalEntities.RegulatoryAgencies.Namespace
module RegulatoryAgencies =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FBC/FunctionalEntities/RegulatoryAgencies.rdf") (Some @"fibo.FBC.FunctionalEntities.RegulatoryAgencies") None
    let Examiner = {_prefixID with _localName = "Examiner"}
    let GovernmentIssuedLicense = {_prefixID with _localName = "GovernmentIssuedLicense"}
    let RegulationIdentificationScheme = {_prefixID with _localName = "RegulationIdentificationScheme"}
    let RegulationIdentifier = {_prefixID with _localName = "RegulationIdentifier"}
    let RegulatoryCapacity = {_prefixID with _localName = "RegulatoryCapacity"}
    let TaxAuthority = {_prefixID with _localName = "TaxAuthority"}