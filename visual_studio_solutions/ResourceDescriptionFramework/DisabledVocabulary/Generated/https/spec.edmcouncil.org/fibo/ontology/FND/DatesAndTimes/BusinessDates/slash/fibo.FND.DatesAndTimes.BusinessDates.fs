namespace Fibo.FND.DatesAndTimes.BusinessDates.Namespace
module BusinessDates =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/DatesAndTimes/BusinessDates.rdf") (Some @"fibo.FND.DatesAndTimes.BusinessDates") None
    let BusinessDayConvention = {_prefixID with _localName = "BusinessDayConvention"}
    let BusinessDayFollowing = {_prefixID with _localName = "BusinessDayFollowing"}
    let BusinessDayModifiedFollowing = {_prefixID with _localName = "BusinessDayModifiedFollowing"}
    let BusinessDayModifiedPreceding = {_prefixID with _localName = "BusinessDayModifiedPreceding"}
    let BusinessDayNearest = {_prefixID with _localName = "BusinessDayNearest"}
    let BusinessDayNone = {_prefixID with _localName = "BusinessDayNone"}
    let BusinessDayPreceding = {_prefixID with _localName = "BusinessDayPreceding"}
    let BusinessRecurrenceInterval = {_prefixID with _localName = "BusinessRecurrenceInterval"}
    let BusinessRecurrenceIntervalConvention = {_prefixID with _localName = "BusinessRecurrenceIntervalConvention"}
    let Convention = {_prefixID with _localName = "Convention"}
    let DayOfMonth = {_prefixID with _localName = "DayOfMonth"}
    let DayOfWeek = {_prefixID with _localName = "DayOfWeek"}
    let EndOfMonth = {_prefixID with _localName = "EndOfMonth"}
    let hasBusinessDayConvention = {_prefixID with _localName = "hasBusinessDayConvention"}
    let hasBusinessRecurrenceIntervalConvention = {_prefixID with _localName = "hasBusinessRecurrenceIntervalConvention"}