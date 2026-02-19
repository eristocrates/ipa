namespace Spar.frbr.Namespace
module frbr =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/spar/frbr/" (Some "http://purl.org/spar/frbr.ttl") (Some "spar.frbr") None
    let ``2011-06-29`` = {_prefixID with _localName = "2011-06-29"}
    let ``2018-03-29`` = {_prefixID with _localName = "2018-03-29"}