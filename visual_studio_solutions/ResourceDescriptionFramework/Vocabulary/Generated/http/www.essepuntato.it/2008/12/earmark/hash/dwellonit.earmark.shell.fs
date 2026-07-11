namespace Dwellonit.earmark.shell.Namespace
module shell =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.essepuntato.it/2008/12/earmark#" (Some "https://sourceforge.net/p/dwellonit/code/HEAD/tree/EARMARK/Current%20Version/earmark_shell-2_0.owl?format=raw") (Some "dwellonit.earmark.shell") None
    let Attribute = {_prefixID with _localName = "Attribute"}
    let Comment = {_prefixID with _localName = "Comment"}
    let Docuverse = {_prefixID with _localName = "Docuverse"}
    let Element = {_prefixID with _localName = "Element"}
    let MarkupItem = {_prefixID with _localName = "MarkupItem"}
    let PointerRange = {_prefixID with _localName = "PointerRange"}
    let Range = {_prefixID with _localName = "Range"}
    let StringDocuverse = {_prefixID with _localName = "StringDocuverse"}
    let URIDocuverse = {_prefixID with _localName = "URIDocuverse"}
    let XPathPointerRange = {_prefixID with _localName = "XPathPointerRange"}
    let XPathRange = {_prefixID with _localName = "XPathRange"}
    let begins = {_prefixID with _localName = "begins"}
    let ends = {_prefixID with _localName = "ends"}
    let hasContent = {_prefixID with _localName = "hasContent"}
    let hasXPathContext = {_prefixID with _localName = "hasXPathContext"}
    let refersTo = {_prefixID with _localName = "refersTo"}