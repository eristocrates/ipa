namespace Ontolex.decomp.Namespace
module decomp =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/ns/lemon/decomp#" (Some "http://www.w3.org/ns/lemon/decomp#") (Some "ontolex.decomp") None
    let Component = {_prefixID with _localName = "Component"}
    let constituent = {_prefixID with _localName = "constituent"}
    let correspondsTo = {_prefixID with _localName = "correspondsTo"}
    let subterm = {_prefixID with _localName = "subterm"}