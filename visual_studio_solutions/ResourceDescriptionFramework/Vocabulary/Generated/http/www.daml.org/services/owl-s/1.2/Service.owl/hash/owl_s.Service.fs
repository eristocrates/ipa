namespace Owl_s.Service.Namespace
module Service =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.daml.org/services/owl-s/1.2/Service.owl#" (Some "https://www.daml.org/services/owl-s/1.2/Service.owl") (Some "owl_s.Service") None
    let Service = {_prefixID with _localName = "Service"}
    let ServiceGrounding = {_prefixID with _localName = "ServiceGrounding"}
    let ServiceModel = {_prefixID with _localName = "ServiceModel"}
    let ServiceProfile = {_prefixID with _localName = "ServiceProfile"}
    let describedBy = {_prefixID with _localName = "describedBy"}
    let describes = {_prefixID with _localName = "describes"}
    let presentedBy = {_prefixID with _localName = "presentedBy"}
    let presents = {_prefixID with _localName = "presents"}
    let providedBy = {_prefixID with _localName = "providedBy"}
    let provides = {_prefixID with _localName = "provides"}
    let supportedBy = {_prefixID with _localName = "supportedBy"}
    let supports = {_prefixID with _localName = "supports"}