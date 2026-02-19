namespace Rei.Namespace
module rei =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2004/06/rei#" (Some "http://www.w3.org/2004/06/rei#") (Some "rei") None
    let BNode = {_prefixID with _localName = "BNode"}
    let Formula = {_prefixID with _localName = "Formula"}
    let Literal = {_prefixID with _localName = "Literal"}
    let RDFGraph = {_prefixID with _localName = "RDFGraph"}
    let RDFTerm = {_prefixID with _localName = "RDFTerm"}
    let Statement = {_prefixID with _localName = "Statement"}
    let String = {_prefixID with _localName = "String"}
    let Symbol = {_prefixID with _localName = "Symbol"}
    let Term = {_prefixID with _localName = "Term"}
    let existentials = {_prefixID with _localName = "existentials"}
    let iteral = {_prefixID with _localName = "iteral"}
    let objURI = {_prefixID with _localName = "objURI"}
    let objValue = {_prefixID with _localName = "objValue"}
    let object = {_prefixID with _localName = "object"}
    let predURI = {_prefixID with _localName = "predURI"}
    let predValue = {_prefixID with _localName = "predValue"}
    let predicate = {_prefixID with _localName = "predicate"}
    let statements = {_prefixID with _localName = "statements"}
    let subjURI = {_prefixID with _localName = "subjURI"}
    let subjValue = {_prefixID with _localName = "subjValue"}
    let subject = {_prefixID with _localName = "subject"}
    let universals = {_prefixID with _localName = "universals"}
    let uri = {_prefixID with _localName = "uri"}
    let value = {_prefixID with _localName = "value"}