namespace Semic.``public``.``event``.Namespace
module ``event`` =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://data.europa.eu/m8g/" (Some "https://github.com/SEMICeu/Core-Public-Event-Vocabulary/raw/refs/heads/master/releases/1.1.0/voc/core-public-event.ttl") (Some "semic.public.event") None
    let ContactPoint = {_prefixID with _localName = "ContactPoint"}
    let Participation = {_prefixID with _localName = "Participation"}
    let PublicEvent = {_prefixID with _localName = "PublicEvent"}
    let accessibility = {_prefixID with _localName = "accessibility"}
    let audience = {_prefixID with _localName = "audience"}
    let contactPage = {_prefixID with _localName = "contactPage"}
    let email = {_prefixID with _localName = "email"}
    let eventNumber = {_prefixID with _localName = "eventNumber"}
    let eventStatus = {_prefixID with _localName = "eventStatus"}
    let expectedNumberOfParticipants = {_prefixID with _localName = "expectedNumberOfParticipants"}
    let format = {_prefixID with _localName = "format"}
    let frequency = {_prefixID with _localName = "frequency"}
    let registrationPage = {_prefixID with _localName = "registrationPage"}
    let role = {_prefixID with _localName = "role"}
    let telephone = {_prefixID with _localName = "telephone"}