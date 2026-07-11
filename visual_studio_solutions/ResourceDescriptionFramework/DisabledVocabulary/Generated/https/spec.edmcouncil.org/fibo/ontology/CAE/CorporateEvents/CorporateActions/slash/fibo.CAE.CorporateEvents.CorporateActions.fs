namespace Fibo.CAE.CorporateEvents.CorporateActions.Namespace
module CorporateActions =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/CAE/CorporateEvents/CorporateActions.rdf") (Some @"fibo.CAE.CorporateEvents.CorporateActions") None
    let Action = {_prefixID with _localName = "Action"}
    let ActionClassificationScheme = {_prefixID with _localName = "ActionClassificationScheme"}
    let ActionClassifier = {_prefixID with _localName = "ActionClassifier"}
    let ActionStatus = {_prefixID with _localName = "ActionStatus"}
    let BusinessStrategyClassifier = {_prefixID with _localName = "BusinessStrategyClassifier"}
    let ChangeAction = {_prefixID with _localName = "ChangeAction"}
    let ClassAction = {_prefixID with _localName = "ClassAction"}
    let ConsentSolicitation = {_prefixID with _localName = "ConsentSolicitation"}
    let CorporateAction = {_prefixID with _localName = "CorporateAction"}
    let DisclosureAction = {_prefixID with _localName = "DisclosureAction"}
    let Divestiture = {_prefixID with _localName = "Divestiture"}
    let IncomeOrientedClassifier = {_prefixID with _localName = "IncomeOrientedClassifier"}
    let LegalFormChange = {_prefixID with _localName = "LegalFormChange"}
    let Liquidation = {_prefixID with _localName = "Liquidation"}
    let MandatoryCorporateAction = {_prefixID with _localName = "MandatoryCorporateAction"}
    let MandatoryWithChoiceCorporateAction = {_prefixID with _localName = "MandatoryWithChoiceCorporateAction"}
    let MarketAction = {_prefixID with _localName = "MarketAction"}
    let MergerAcquisition = {_prefixID with _localName = "MergerAcquisition"}
    let Notification = {_prefixID with _localName = "Notification"}
    let OrganizationAddressChange = {_prefixID with _localName = "OrganizationAddressChange"}
    let OrganizationNameChange = {_prefixID with _localName = "OrganizationNameChange"}
    let PriorityIssue = {_prefixID with _localName = "PriorityIssue"}
    let RegulatoryAction = {_prefixID with _localName = "RegulatoryAction"}
    let SpinOff = {_prefixID with _localName = "SpinOff"}
    let VoluntaryCorporateAction = {_prefixID with _localName = "VoluntaryCorporateAction"}