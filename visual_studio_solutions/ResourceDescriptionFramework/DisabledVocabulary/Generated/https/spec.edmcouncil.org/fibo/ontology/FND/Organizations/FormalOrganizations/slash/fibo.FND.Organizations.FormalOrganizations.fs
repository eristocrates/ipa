namespace Fibo.FND.Organizations.FormalOrganizations.Namespace
module FormalOrganizations =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/Organizations/FormalOrganizations.rdf") (Some @"fibo.FND.Organizations.FormalOrganizations") None
    let Employee = {_prefixID with _localName = "Employee"}
    let Employer = {_prefixID with _localName = "Employer"}
    let Employment = {_prefixID with _localName = "Employment"}
    let Group = {_prefixID with _localName = "Group"}
    let employs = {_prefixID with _localName = "employs"}
    let hasEmployedParty = {_prefixID with _localName = "hasEmployedParty"}
    let hasEmployee = {_prefixID with _localName = "hasEmployee"}
    let hasEmployingParty = {_prefixID with _localName = "hasEmployingParty"}
    let isEmployedBy = {_prefixID with _localName = "isEmployedBy"}
    let isEmployedIn = {_prefixID with _localName = "isEmployedIn"}
    let isEmployeeOf = {_prefixID with _localName = "isEmployeeOf"}
    let isEmployingParty = {_prefixID with _localName = "isEmployingParty"}