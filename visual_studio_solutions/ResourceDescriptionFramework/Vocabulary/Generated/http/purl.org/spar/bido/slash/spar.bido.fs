namespace Spar.bido.Namespace
module bido =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/spar/bido/" (Some "http://purl.org/spar/bido.ttl") (Some "spar.bido") None
    let ``2015-07-13`` = {_prefixID with _localName = "2015-07-13"}
    let ``bido.png`` = {_prefixID with _localName = "bido.png"}