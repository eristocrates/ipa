#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tzont =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/2006/timezone#" "tzont"

    let City = _prefixId.prefix "City"
    let Country = _prefixId.prefix "Country"
    let County = _prefixId.prefix "County"
    let DLSendDate = _prefixId.prefix "DLSendDate"
    let DLSstartDate = _prefixId.prefix "DLSstartDate"
    let DaylightSavingsPolicy = _prefixId.prefix "DaylightSavingsPolicy"

    let EnumeratedDaylightSavingsPolicy =
        _prefixId.prefix "EnumeratedDaylightSavingsPolicy"

    let GMToffset = _prefixId.prefix "GMToffset"
    let PoliticalRegion = _prefixId.prefix "PoliticalRegion"
    let Region = _prefixId.prefix "Region"
    let Reservation = _prefixId.prefix "Reservation"
    let State = _prefixId.prefix "State"
    let TimeZone = _prefixId.prefix "TimeZone"
    let countryOf = _prefixId.prefix "countryOf"
    let exceptionalRegion = _prefixId.prefix "exceptionalRegion"
    let hasAncestorRegion = _prefixId.prefix "hasAncestorRegion"
    let hasDaylightSavingsPolicy = _prefixId.prefix "hasDaylightSavingsPolicy"
    let hasParentRegion = _prefixId.prefix "hasParentRegion"
    let hasTimeZone = _prefixId.prefix "hasTimeZone"
    let name = _prefixId.prefix "name"
    let observesDaylightSavingsTime = _prefixId.prefix "observesDaylightSavingsTime"
    let stateOf = _prefixId.prefix "stateOf"
    let timeZonePart = _prefixId.prefix "timeZonePart"
