namespace Fibo.BE.OwnershipAndControl.ControlParties.Namespace
module ControlParties =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BE/OwnershipAndControl/ControlParties.rdf") (Some @"fibo.BE.OwnershipAndControl.ControlParties") None
    let ContractualControl = {_prefixID with _localName = "ContractualControl"}
    let ControlledParty = {_prefixID with _localName = "ControlledParty"}
    let ControllingAlliance = {_prefixID with _localName = "ControllingAlliance"}
    let CourtAppointedControl = {_prefixID with _localName = "CourtAppointedControl"}
    let DeFactoControllingInterestParty = {_prefixID with _localName = "DeFactoControllingInterestParty"}
    let DeJureControllingInterestParty = {_prefixID with _localName = "DeJureControllingInterestParty"}
    let EntityControllingParty = {_prefixID with _localName = "EntityControllingParty"}
    let InfluenceBasedDeFactoControl = {_prefixID with _localName = "InfluenceBasedDeFactoControl"}
    let InfluenceBasedDeFactoControllingParty = {_prefixID with _localName = "InfluenceBasedDeFactoControllingParty"}
    let InvestmentBasedDeFactoControl = {_prefixID with _localName = "InvestmentBasedDeFactoControl"}
    let InvestmentBasedDeFactoControllingInterestParty = {_prefixID with _localName = "InvestmentBasedDeFactoControllingInterestParty"}
    let JointControllingParty = {_prefixID with _localName = "JointControllingParty"}
    let MajorityControllingParty = {_prefixID with _localName = "MajorityControllingParty"}
    let Receiver = {_prefixID with _localName = "Receiver"}
    let SoleControllingParty = {_prefixID with _localName = "SoleControllingParty"}
    let TotalOwner = {_prefixID with _localName = "TotalOwner"}
    let advises = {_prefixID with _localName = "advises"}
    let hasControllingOrganizationMember = {_prefixID with _localName = "hasControllingOrganizationMember"}
    let hasMajorityControllingParty = {_prefixID with _localName = "hasMajorityControllingParty"}
    let isAdvisedBy = {_prefixID with _localName = "isAdvisedBy"}
    let isBasedOnInvestmentEquity = {_prefixID with _localName = "isBasedOnInvestmentEquity"}
    let isControllingMemberOf = {_prefixID with _localName = "isControllingMemberOf"}