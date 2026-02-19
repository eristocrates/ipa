namespace Sparql.Namespace
module sparql =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/ns/sparql#" (Some "http://www.w3.org/ns/sparql#") (Some "sparql") None
    let bound = {_prefixID with _localName = "bound"}