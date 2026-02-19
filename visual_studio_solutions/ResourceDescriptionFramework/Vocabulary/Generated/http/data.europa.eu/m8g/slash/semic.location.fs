namespace Semic.location.Namespace
module location =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://data.europa.eu/m8g/" (Some "https://github.com/SEMICeu/Core-Location-Vocabulary/raw/refs/heads/master/releases/2.1.0/voc/core-location.ttl") (Some "semic.location") None
    let AdminUnit = {_prefixID with _localName = "AdminUnit"}
    let code = {_prefixID with _localName = "code"}
    let coordinates = {_prefixID with _localName = "coordinates"}
    let crs = {_prefixID with _localName = "crs"}
    let geometryType = {_prefixID with _localName = "geometryType"}
    let latitude = {_prefixID with _localName = "latitude"}
    let level = {_prefixID with _localName = "level"}
    let longitude = {_prefixID with _localName = "longitude"}