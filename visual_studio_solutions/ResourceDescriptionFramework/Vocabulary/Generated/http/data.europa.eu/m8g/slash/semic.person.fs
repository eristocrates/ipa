namespace Semic.person.Namespace
module person =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://data.europa.eu/m8g/" (Some "https://github.com/SEMICeu/Core-Person-Vocabulary/raw/refs/heads/master/releases/2.1.1/voc/core-person-ap.ttl") (Some "semic.person") None
    let ContactPoint = {_prefixID with _localName = "ContactPoint"}
    let GenericDate = {_prefixID with _localName = "GenericDate"}
    let birthDate = {_prefixID with _localName = "birthDate"}
    let contactPage = {_prefixID with _localName = "contactPage"}
    let deathDate = {_prefixID with _localName = "deathDate"}
    let email = {_prefixID with _localName = "email"}
    let gender = {_prefixID with _localName = "gender"}
    let matronymicName = {_prefixID with _localName = "matronymicName"}
    let sex = {_prefixID with _localName = "sex"}
    let telephone = {_prefixID with _localName = "telephone"}