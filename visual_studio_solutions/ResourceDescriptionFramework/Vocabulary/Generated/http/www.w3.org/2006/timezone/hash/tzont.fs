namespace Tzont.Namespace
module tzont =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2006/timezone#" (Some "http://www.w3.org/2006/timezone#") (Some "tzont") None
    let City = {_prefixID with _localName = "City"}
    let Country = {_prefixID with _localName = "Country"}
    let County = {_prefixID with _localName = "County"}
    let DLSendDate = {_prefixID with _localName = "DLSendDate"}
    let DLSstartDate = {_prefixID with _localName = "DLSstartDate"}
    let DaylightSavingsPolicy = {_prefixID with _localName = "DaylightSavingsPolicy"}
    let EnumeratedDaylightSavingsPolicy = {_prefixID with _localName = "EnumeratedDaylightSavingsPolicy"}
    let GMToffset = {_prefixID with _localName = "GMToffset"}
    let PoliticalRegion = {_prefixID with _localName = "PoliticalRegion"}
    let Region = {_prefixID with _localName = "Region"}
    let Reservation = {_prefixID with _localName = "Reservation"}
    let State = {_prefixID with _localName = "State"}
    let TimeZone = {_prefixID with _localName = "TimeZone"}
    let countryOf = {_prefixID with _localName = "countryOf"}
    let exceptionalRegion = {_prefixID with _localName = "exceptionalRegion"}
    let hasAncestorRegion = {_prefixID with _localName = "hasAncestorRegion"}
    let hasDaylightSavingsPolicy = {_prefixID with _localName = "hasDaylightSavingsPolicy"}
    let hasParentRegion = {_prefixID with _localName = "hasParentRegion"}
    let hasTimeZone = {_prefixID with _localName = "hasTimeZone"}
    let name = {_prefixID with _localName = "name"}
    let observesDaylightSavingsTime = {_prefixID with _localName = "observesDaylightSavingsTime"}
    let stateOf = {_prefixID with _localName = "stateOf"}
    let timeZonePart = {_prefixID with _localName = "timeZonePart"}