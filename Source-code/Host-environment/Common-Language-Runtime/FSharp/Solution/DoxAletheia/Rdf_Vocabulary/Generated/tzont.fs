namespace http.www.w3.org._2006.timezone.hash

open DoxAletheia

module tzont =
    let _namespace_name = "http://www.w3.org/2006/timezone#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#City"></see>
    /// </summary>
    let City = _prefix "City"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#PoliticalRegion"></see>
    /// </summary>
    let PoliticalRegion = _prefix "PoliticalRegion"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#Country"></see>
    /// </summary>
    let Country = _prefix "Country"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#County"></see>
    /// </summary>
    let County = _prefix "County"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#hasParentRegion"></see>
    /// </summary>
    let hasParentRegion = _prefix "hasParentRegion"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#State"></see>
    /// </summary>
    let State = _prefix "State"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#DLSendDate"></see>
    /// </summary>
    let DLSendDate = _prefix "DLSendDate"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#DLSstartDate"></see>
    /// </summary>
    let DLSstartDate = _prefix "DLSstartDate"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#DaylightSavingsPolicy"></see>
    /// </summary>
    let DaylightSavingsPolicy = _prefix "DaylightSavingsPolicy"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#EnumeratedDaylightSavingsPolicy"></see>
    /// </summary>
    let EnumeratedDaylightSavingsPolicy = _prefix "EnumeratedDaylightSavingsPolicy"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#GMToffset"></see>
    /// </summary>
    let GMToffset = _prefix "GMToffset"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#TimeZone"></see>
    /// </summary>
    let TimeZone = _prefix "TimeZone"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#hasTimeZone"></see>
    /// </summary>
    let hasTimeZone = _prefix "hasTimeZone"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#observesDaylightSavingsTime"></see>
    /// </summary>
    let observesDaylightSavingsTime = _prefix "observesDaylightSavingsTime"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#hasDaylightSavingsPolicy"></see>
    /// </summary>
    let hasDaylightSavingsPolicy = _prefix "hasDaylightSavingsPolicy"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#exceptionalRegion"></see>
    /// </summary>
    let exceptionalRegion = _prefix "exceptionalRegion"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#timeZonePart"></see>
    /// </summary>
    let timeZonePart = _prefix "timeZonePart"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#Region"></see>
    /// </summary>
    let Region = _prefix "Region"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#Reservation"></see>
    /// </summary>
    let Reservation = _prefix "Reservation"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#countryOf"></see>
    /// </summary>
    let countryOf = _prefix "countryOf"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#hasAncestorRegion"></see>
    /// </summary>
    let hasAncestorRegion = _prefix "hasAncestorRegion"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#stateOf"></see>
    /// </summary>
    let stateOf = _prefix "stateOf"
