namespace Dcmi.lrmi.interact.Namespace
module interact =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/dcx/lrmi-vocabs/interactivityType/" (Some @"http://dublincore.org/vocabs/interactivityType.ttl") (Some @"dcmi.lrmi.interact") None
    let active = {_prefixID with _localName = "active"}
    let expositive = {_prefixID with _localName = "expositive"}
    let mixed = {_prefixID with _localName = "mixed"}