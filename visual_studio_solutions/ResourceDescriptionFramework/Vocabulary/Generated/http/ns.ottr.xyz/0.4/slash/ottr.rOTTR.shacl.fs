namespace Ottr.rOTTR.shacl.Namespace
module shacl =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://ns.ottr.xyz/0.4/" (Some @"https://spec.ottr.xyz/rOTTR/0.2.0/types.shacl.ttl") (Some @"ottr.rOTTR.shacl") None
    let BasicTypeShape = {_prefixID with _localName = "BasicTypeShape"}
    let Bot = {_prefixID with _localName = "Bot"}
    let IRI = {_prefixID with _localName = "IRI"}
    let LUB = {_prefixID with _localName = "LUB"}
    let ListTypeShape = {_prefixID with _localName = "ListTypeShape"}
    let NEList = {_prefixID with _localName = "NEList"}
    let TypeShape = {_prefixID with _localName = "TypeShape"}