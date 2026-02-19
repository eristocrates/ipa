namespace Vann.Namespace
module vann =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/vocab/vann/" (Some "http://purl.org/vocab/vann/") (Some "vann") None
    let ``vann-vocab-20100607.rdf`` = {_prefixID with _localName = "vann-vocab-20100607.rdf"}