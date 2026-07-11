namespace Fibo.BE.FunctionalEntities.Publishers.Namespace
module Publishers =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BE/FunctionalEntities/Publishers.rdf") (Some @"fibo.BE.FunctionalEntities.Publishers") None
    let MarketDataProvider = {_prefixID with _localName = "MarketDataProvider"}
    let Publication = {_prefixID with _localName = "Publication"}
    let Publisher = {_prefixID with _localName = "Publisher"}
    let hasPublisher = {_prefixID with _localName = "hasPublisher"}
    let isPublishedBy = {_prefixID with _localName = "isPublishedBy"}
    let publishes = {_prefixID with _localName = "publishes"}