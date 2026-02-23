namespace Fibo.BE.GovernmentEntities.GovernmentEntities.Namespace
module GovernmentEntities =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BE/GovernmentEntities/GovernmentEntities.rdf") (Some @"fibo.BE.GovernmentEntities.GovernmentEntities") None
    let BranchOfGovernment = {_prefixID with _localName = "BranchOfGovernment"}
    let DevolvedGovernment = {_prefixID with _localName = "DevolvedGovernment"}
    let ExecutiveBranch = {_prefixID with _localName = "ExecutiveBranch"}
    let FederalGovernment = {_prefixID with _localName = "FederalGovernment"}
    let FederatedSovereignty = {_prefixID with _localName = "FederatedSovereignty"}
    let Government = {_prefixID with _localName = "Government"}
    let GovernmentAgency = {_prefixID with _localName = "GovernmentAgency"}
    let GovernmentAppointee = {_prefixID with _localName = "GovernmentAppointee"}
    let GovernmentBody = {_prefixID with _localName = "GovernmentBody"}
    let GovernmentDepartment = {_prefixID with _localName = "GovernmentDepartment"}
    let GovernmentMinister = {_prefixID with _localName = "GovernmentMinister"}
    let GovernmentOfficial = {_prefixID with _localName = "GovernmentOfficial"}
    let Instrumentality = {_prefixID with _localName = "Instrumentality"}
    let Judiciary = {_prefixID with _localName = "Judiciary"}
    let Legislature = {_prefixID with _localName = "Legislature"}
    let MunicipalEntity = {_prefixID with _localName = "MunicipalEntity"}
    let MunicipalGovernment = {_prefixID with _localName = "MunicipalGovernment"}
    let NationalGovernment = {_prefixID with _localName = "NationalGovernment"}
    let Polity = {_prefixID with _localName = "Polity"}
    let RegionalGovernment = {_prefixID with _localName = "RegionalGovernment"}
    let RegionalSovereignty = {_prefixID with _localName = "RegionalSovereignty"}
    let SovereignState = {_prefixID with _localName = "SovereignState"}
    let SupranationalEntity = {_prefixID with _localName = "SupranationalEntity"}
    let TribalArea = {_prefixID with _localName = "TribalArea"}
    let TribalEntity = {_prefixID with _localName = "TribalEntity"}
    let TribalGovernment = {_prefixID with _localName = "TribalGovernment"}
    let hasFullSovereigntyOver = {_prefixID with _localName = "hasFullSovereigntyOver"}
    let hasSharedSovereigntyOver = {_prefixID with _localName = "hasSharedSovereigntyOver"}
    let hasSovereigntyOver = {_prefixID with _localName = "hasSovereigntyOver"}
    let isElectedBy = {_prefixID with _localName = "isElectedBy"}
    let isInstrumentOf = {_prefixID with _localName = "isInstrumentOf"}
    let isRepresentedBy = {_prefixID with _localName = "isRepresentedBy"}