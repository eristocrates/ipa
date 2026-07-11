namespace Ontolex.lexicog.Namespace
module lexicog =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/ns/lemon/lexicog#" (Some "http://www.w3.org/ns/lemon/lexicog#") (Some "ontolex.lexicog") None
    let Entry = {_prefixID with _localName = "Entry"}
    let FormRestriction = {_prefixID with _localName = "FormRestriction"}
    let LexicographicComponent = {_prefixID with _localName = "LexicographicComponent"}
    let LexicographicResource = {_prefixID with _localName = "LexicographicResource"}
    let UsageExample = {_prefixID with _localName = "UsageExample"}
    let describes = {_prefixID with _localName = "describes"}
    let entry = {_prefixID with _localName = "entry"}
    let restrictedTo = {_prefixID with _localName = "restrictedTo"}
    let subComponent = {_prefixID with _localName = "subComponent"}
    let usageExample = {_prefixID with _localName = "usageExample"}