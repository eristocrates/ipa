namespace Fibo.BE.PrivateLimitedCompanies.PrivateLimitedCompanies.Namespace
module PrivateLimitedCompanies =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BE/PrivateLimitedCompanies/PrivateLimitedCompanies.rdf") (Some @"fibo.BE.PrivateLimitedCompanies.PrivateLimitedCompanies") None
    let LimitedLiabilityCompany = {_prefixID with _localName = "LimitedLiabilityCompany"}
    let LimitedLiabilityCompanyMember = {_prefixID with _localName = "LimitedLiabilityCompanyMember"}
    let LimitedLiabilityCompanyTaxedAsACorporation = {_prefixID with _localName = "LimitedLiabilityCompanyTaxedAsACorporation"}
    let ManagerManagedLimitedLiabilityCompany = {_prefixID with _localName = "ManagerManagedLimitedLiabilityCompany"}
    let ManagingMember = {_prefixID with _localName = "ManagingMember"}
    let PrivateCompanyWithLimitedLiability = {_prefixID with _localName = "PrivateCompanyWithLimitedLiability"}
    let PrivateLimitedCompany = {_prefixID with _localName = "PrivateLimitedCompany"}
    let hasManagingMember = {_prefixID with _localName = "hasManagingMember"}
    let isManagingMemberOf = {_prefixID with _localName = "isManagingMemberOf"}