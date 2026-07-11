namespace Rdf.Namespace
module rdf =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/1999/02/22-rdf-syntax-ns#" (Some "http://www.w3.org/1999/02/22-rdf-syntax-ns#") (Some "rdf") None
    let Alt = {_prefixID with _localName = "Alt"}
    let Bag = {_prefixID with _localName = "Bag"}
    let CompoundLiteral = {_prefixID with _localName = "CompoundLiteral"}
    let HTML = {_prefixID with _localName = "HTML"}
    let JSON = {_prefixID with _localName = "JSON"}
    let List = {_prefixID with _localName = "List"}
    let PlainLiteral = {_prefixID with _localName = "PlainLiteral"}
    let Property = {_prefixID with _localName = "Property"}
    let Seq = {_prefixID with _localName = "Seq"}
    let Statement = {_prefixID with _localName = "Statement"}
    let XMLLiteral = {_prefixID with _localName = "XMLLiteral"}
    let direction = {_prefixID with _localName = "direction"}
    let first = {_prefixID with _localName = "first"}
    let langString = {_prefixID with _localName = "langString"}
    let language = {_prefixID with _localName = "language"}
    let nil = {_prefixID with _localName = "nil"}
    let object = {_prefixID with _localName = "object"}
    let predicate = {_prefixID with _localName = "predicate"}
    let rest = {_prefixID with _localName = "rest"}
    let subject = {_prefixID with _localName = "subject"}
    let ``type`` = {_prefixID with _localName = "type"}
    let value = {_prefixID with _localName = "value"}