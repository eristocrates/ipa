namespace Ottr.rOTTR.types.Namespace
module types =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://ns.ottr.xyz/0.4/" (Some @"https://spec.ottr.xyz/rOTTR/0.2.0/types.owl.ttl") (Some @"ottr.rOTTR.types") None
    let Bot = {_prefixID with _localName = "Bot"}
    let IRI = {_prefixID with _localName = "IRI"}
    let LUB = {_prefixID with _localName = "LUB"}
    let NEList = {_prefixID with _localName = "NEList"}
    let Type = {_prefixID with _localName = "Type"}
    let subTypeOf = {_prefixID with _localName = "subTypeOf"}