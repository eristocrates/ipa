namespace Semic.``public``.organization.Namespace
module organization =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://data.europa.eu/m8g/" (Some "https://github.com/SEMICeu/CPOV/raw/refs/heads/master/releases/2.1.1/voc/core-public-organisation-ap.ttl") (Some "semic.public.organization") None
    let ContactPoint = {_prefixID with _localName = "ContactPoint"}
    let ImageObject = {_prefixID with _localName = "ImageObject"}
    let PublicOrganisation = {_prefixID with _localName = "PublicOrganisation"}
    let ReferenceFramework = {_prefixID with _localName = "ReferenceFramework"}
    let contactPage = {_prefixID with _localName = "contactPage"}
    let email = {_prefixID with _localName = "email"}
    let frequency = {_prefixID with _localName = "frequency"}
    let telephone = {_prefixID with _localName = "telephone"}