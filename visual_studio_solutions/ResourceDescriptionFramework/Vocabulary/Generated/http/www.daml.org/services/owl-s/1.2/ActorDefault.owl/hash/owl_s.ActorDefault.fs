namespace Owl_s.ActorDefault.Namespace
module ActorDefault =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#" (Some "http://www.daml.org/services/owl-s/1.2/ActorDefault.owl") (Some "owl_s.ActorDefault") None
    let Actor = {_prefixID with _localName = "Actor"}
    let email = {_prefixID with _localName = "email"}
    let fax = {_prefixID with _localName = "fax"}
    let name = {_prefixID with _localName = "name"}
    let phone = {_prefixID with _localName = "phone"}
    let physicalAddress = {_prefixID with _localName = "physicalAddress"}
    let title = {_prefixID with _localName = "title"}
    let webURL = {_prefixID with _localName = "webURL"}