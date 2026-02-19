namespace Ottr.rOTTR.puntypes.Namespace
module puntypes =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://ns.ottr.xyz/0.4/" (Some @"https://spec.ottr.xyz/rOTTR/0.2.0/puntypes.owl.ttl") (Some @"ottr.rOTTR.puntypes") None
    let Bot = {_prefixID with _localName = "Bot"}
    let subTypeOf = {_prefixID with _localName = "subTypeOf"}