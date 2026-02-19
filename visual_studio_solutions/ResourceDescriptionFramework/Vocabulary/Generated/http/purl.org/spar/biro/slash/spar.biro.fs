namespace Spar.biro.Namespace
module biro =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/spar/biro/" (Some "http://purl.org/spar/biro.ttl") (Some "spar.biro") None
    let ``2013-05-11`` = {_prefixID with _localName = "2013-05-11"}
    let BibliographicCollection = {_prefixID with _localName = "BibliographicCollection"}
    let BibliographicList = {_prefixID with _localName = "BibliographicList"}
    let BibliographicRecord = {_prefixID with _localName = "BibliographicRecord"}
    let BibliographicReference = {_prefixID with _localName = "BibliographicReference"}
    let LibraryCatalogue = {_prefixID with _localName = "LibraryCatalogue"}
    let ReferenceList = {_prefixID with _localName = "ReferenceList"}
    let ``biro.png`` = {_prefixID with _localName = "biro.png"}
    let isReferencedBy = {_prefixID with _localName = "isReferencedBy"}
    let references = {_prefixID with _localName = "references"}