namespace Semic.business.Namespace
module business =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://data.europa.eu/m8g/" (Some "https://github.com/SEMICeu/Core-Business-Vocabulary/raw/refs/heads/master/releases/2.2.0/voc/core-business-ap.ttl") (Some "semic.business") None
    let AccountingDocument = {_prefixID with _localName = "AccountingDocument"}
    let ContactPoint = {_prefixID with _localName = "ContactPoint"}
    let contactPage = {_prefixID with _localName = "contactPage"}
    let email = {_prefixID with _localName = "email"}
    let registrationDate = {_prefixID with _localName = "registrationDate"}
    let telephone = {_prefixID with _localName = "telephone"}