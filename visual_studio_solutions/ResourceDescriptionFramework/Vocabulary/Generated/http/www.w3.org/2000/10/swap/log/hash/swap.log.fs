namespace Swap.log.Namespace
module log =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2000/10/swap/log#" (Some "http://www.w3.org/2000/10/swap/log") (Some "swap.log") None
    let Chaff = {_prefixID with _localName = "Chaff"}
    let Formula = {_prefixID with _localName = "Formula"}
    let List = {_prefixID with _localName = "List"}
    let N3Document = {_prefixID with _localName = "N3Document"}
    let Other = {_prefixID with _localName = "Other"}
    let String = {_prefixID with _localName = "String"}
    let Truth = {_prefixID with _localName = "Truth"}
    let conclusion = {_prefixID with _localName = "conclusion"}
    let conjunction = {_prefixID with _localName = "conjunction"}
    let content = {_prefixID with _localName = "content"}
    let definitiveDocument = {_prefixID with _localName = "definitiveDocument"}
    let definitiveService = {_prefixID with _localName = "definitiveService"}
    let dtlit = {_prefixID with _localName = "dtlit"}
    let equalTo = {_prefixID with _localName = "equalTo"}
    let implies = {_prefixID with _localName = "implies"}
    let includes = {_prefixID with _localName = "includes"}
    let n3String = {_prefixID with _localName = "n3String"}
    let notEqualTo = {_prefixID with _localName = "notEqualTo"}
    let notIncludes = {_prefixID with _localName = "notIncludes"}
    let outputString = {_prefixID with _localName = "outputString"}
    let parsedAsN3 = {_prefixID with _localName = "parsedAsN3"}
    let racine = {_prefixID with _localName = "racine"}
    let rawType = {_prefixID with _localName = "rawType"}
    let rawUri = {_prefixID with _localName = "rawUri"}
    let semantics = {_prefixID with _localName = "semantics"}
    let semanticsOrError = {_prefixID with _localName = "semanticsOrError"}
    let uri = {_prefixID with _localName = "uri"}