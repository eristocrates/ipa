namespace Ottr.bOTTR.Namespace
module bOTTR =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://ns.ottr.xyz/0.4/" (Some @"https://spec.ottr.xyz/bOTTR/0.1.2/core-vocabulary.owl.ttl") (Some @"ottr.bOTTR") None
    let ArgumentMap = {_prefixID with _localName = "ArgumentMap"}
    let H2Source = {_prefixID with _localName = "H2Source"}
    let InstanceMap = {_prefixID with _localName = "InstanceMap"}
    let JDBCSource = {_prefixID with _localName = "JDBCSource"}
    let RDFFileSource = {_prefixID with _localName = "RDFFileSource"}
    let RDFSource = {_prefixID with _localName = "RDFSource"}
    let SPARQLEndpointSource = {_prefixID with _localName = "SPARQLEndpointSource"}
    let Source = {_prefixID with _localName = "Source"}
    let StringSource = {_prefixID with _localName = "StringSource"}
    let Type = {_prefixID with _localName = "Type"}
    let argumentMaps = {_prefixID with _localName = "argumentMaps"}
    let fetchSize = {_prefixID with _localName = "fetchSize"}
    let jdbcDriver = {_prefixID with _localName = "jdbcDriver"}
    let labelledBlankPrefix = {_prefixID with _localName = "labelledBlankPrefix"}
    let languageTag = {_prefixID with _localName = "languageTag"}
    let listEnd = {_prefixID with _localName = "listEnd"}
    let listSep = {_prefixID with _localName = "listSep"}
    let listStart = {_prefixID with _localName = "listStart"}
    let nullValue = {_prefixID with _localName = "nullValue"}
    let password = {_prefixID with _localName = "password"}
    let query = {_prefixID with _localName = "query"}
    let source = {_prefixID with _localName = "source"}
    let sourceURL = {_prefixID with _localName = "sourceURL"}
    let template = {_prefixID with _localName = "template"}
    let ``type`` = {_prefixID with _localName = "type"}
    let username = {_prefixID with _localName = "username"}