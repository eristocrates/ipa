namespace Fibo.BE.FunctionalEntities.FunctionalEntities.Namespace
module FunctionalEntities =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BE/FunctionalEntities/FunctionalEntities.rdf") (Some @"fibo.BE.FunctionalEntities.FunctionalEntities") None
    let Association = {_prefixID with _localName = "Association"}
    let CooperativeSociety = {_prefixID with _localName = "CooperativeSociety"}
    let FamilyOffice = {_prefixID with _localName = "FamilyOffice"}
    let FunctionalBusinessEntity = {_prefixID with _localName = "FunctionalBusinessEntity"}
    let FunctionalEntity = {_prefixID with _localName = "FunctionalEntity"}
    let Merchant = {_prefixID with _localName = "Merchant"}
    let MerchantCategoryCode = {_prefixID with _localName = "MerchantCategoryCode"}
    let MerchantCategoryCodeScheme = {_prefixID with _localName = "MerchantCategoryCodeScheme"}
    let MerchantIdentifier = {_prefixID with _localName = "MerchantIdentifier"}
    let Syndicate = {_prefixID with _localName = "Syndicate"}
    let SyndicateMember = {_prefixID with _localName = "SyndicateMember"}
    let hasMerchantCategoryDescription = {_prefixID with _localName = "hasMerchantCategoryDescription"}