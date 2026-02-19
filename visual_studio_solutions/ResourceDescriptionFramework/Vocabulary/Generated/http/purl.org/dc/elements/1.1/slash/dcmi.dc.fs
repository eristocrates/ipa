namespace Dcmi.dc.Namespace
module dc =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/dc/elements/1.1/" (Some @"http://purl.org/dc/elements/1.1/") (Some @"dcmi.dc") None
    let contributor = {_prefixID with _localName = "contributor"}
    let coverage = {_prefixID with _localName = "coverage"}
    let creator = {_prefixID with _localName = "creator"}
    let date = {_prefixID with _localName = "date"}
    let description = {_prefixID with _localName = "description"}
    let format = {_prefixID with _localName = "format"}
    let identifier = {_prefixID with _localName = "identifier"}
    let language = {_prefixID with _localName = "language"}
    let publisher = {_prefixID with _localName = "publisher"}
    let relation = {_prefixID with _localName = "relation"}
    let rights = {_prefixID with _localName = "rights"}
    let source = {_prefixID with _localName = "source"}
    let subject = {_prefixID with _localName = "subject"}
    let title = {_prefixID with _localName = "title"}
    let ``type`` = {_prefixID with _localName = "type"}