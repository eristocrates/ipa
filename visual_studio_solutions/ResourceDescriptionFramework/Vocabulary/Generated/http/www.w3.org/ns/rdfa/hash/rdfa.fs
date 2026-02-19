namespace Rdfa.Namespace
module rdfa =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/ns/rdfa#" (Some "http://www.w3.org/ns/rdfa#") (Some "rdfa") None
    let DocumentError = {_prefixID with _localName = "DocumentError"}
    let Error = {_prefixID with _localName = "Error"}
    let Info = {_prefixID with _localName = "Info"}
    let PGClass = {_prefixID with _localName = "PGClass"}
    let Pattern = {_prefixID with _localName = "Pattern"}
    let PrefixMapping = {_prefixID with _localName = "PrefixMapping"}
    let PrefixOrTermMapping = {_prefixID with _localName = "PrefixOrTermMapping"}
    let PrefixRedefinition = {_prefixID with _localName = "PrefixRedefinition"}
    let TermMapping = {_prefixID with _localName = "TermMapping"}
    let UnresolvedCURIE = {_prefixID with _localName = "UnresolvedCURIE"}
    let UnresolvedTerm = {_prefixID with _localName = "UnresolvedTerm"}
    let VocabReferenceError = {_prefixID with _localName = "VocabReferenceError"}
    let Warning = {_prefixID with _localName = "Warning"}
    let context = {_prefixID with _localName = "context"}
    let copy = {_prefixID with _localName = "copy"}
    let prefix = {_prefixID with _localName = "prefix"}
    let term = {_prefixID with _localName = "term"}
    let uri = {_prefixID with _localName = "uri"}
    let usesVocabulary = {_prefixID with _localName = "usesVocabulary"}
    let vocabulary = {_prefixID with _localName = "vocabulary"}