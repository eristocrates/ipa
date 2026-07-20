namespace http.www.w3.org._2006.time_entry.hash

open DoxAletheia

module te =
    let _namespace_name = "http://www.w3.org/2006/time-entry#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#CalendarClockDescription"></see>
    /// </summary>
    let CalendarClockDescription = _prefix "CalendarClockDescription"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#dayOfYearField"></see>
    /// </summary>
    let dayOfYearField = _prefix "dayOfYearField"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#month"></see>
    /// </summary>
    let month = _prefix "month"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#week"></see>
    /// </summary>
    let week = _prefix "week"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#day"></see>
    /// </summary>
    let day = _prefix "day"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#second"></see>
    /// </summary>
    let second = _prefix "second"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#hour"></see>
    /// </summary>
    let hour = _prefix "hour"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#minute"></see>
    /// </summary>
    let minute = _prefix "minute"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#unitType"></see>
    /// </summary>
    let unitType = _prefix "unitType"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#timeZone"></see>
    /// </summary>
    let timeZone = _prefix "timeZone"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#year"></see>
    /// </summary>
    let year = _prefix "year"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#dayOfWeekField"></see>
    /// </summary>
    let dayOfWeekField = _prefix "dayOfWeekField"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#CalendarClockInterval"></see>
    /// </summary>
    let CalendarClockInterval = _prefix "CalendarClockInterval"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#ProperInterval"></see>
    /// </summary>
    let ProperInterval = _prefix "ProperInterval"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#DurationDescription"></see>
    /// </summary>
    let DurationDescription = _prefix "DurationDescription"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#hours"></see>
    /// </summary>
    let hours = _prefix "hours"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#years"></see>
    /// </summary>
    let years = _prefix "years"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#months"></see>
    /// </summary>
    let months = _prefix "months"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#days"></see>
    /// </summary>
    let days = _prefix "days"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#weeks"></see>
    /// </summary>
    let weeks = _prefix "weeks"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#minutes"></see>
    /// </summary>
    let minutes = _prefix "minutes"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#seconds"></see>
    /// </summary>
    let seconds = _prefix "seconds"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#Event"></see>
    /// </summary>
    let Event = _prefix "Event"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#TemporalThing"></see>
    /// </summary>
    let TemporalThing = _prefix "TemporalThing"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#InstantEvent"></see>
    /// </summary>
    let InstantEvent = _prefix "InstantEvent"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#IntervalEvent"></see>
    /// </summary>
    let IntervalEvent = _prefix "IntervalEvent"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#Instant"></see>
    /// </summary>
    let Instant = _prefix "Instant"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#InstantThing"></see>
    /// </summary>
    let InstantThing = _prefix "InstantThing"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#TemporalEntity"></see>
    /// </summary>
    let TemporalEntity = _prefix "TemporalEntity"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#InstantThingPair"></see>
    /// </summary>
    let InstantThingPair = _prefix "InstantThingPair"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#secondInstantThing"></see>
    /// </summary>
    let secondInstantThing = _prefix "secondInstantThing"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#firstInstantThing"></see>
    /// </summary>
    let firstInstantThing = _prefix "firstInstantThing"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#Interval"></see>
    /// </summary>
    let Interval = _prefix "Interval"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#IntervalThing"></see>
    /// </summary>
    let IntervalThing = _prefix "IntervalThing"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#ProperIntervalThing"></see>
    /// </summary>
    let ProperIntervalThing = _prefix "ProperIntervalThing"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#TemporalUnit"></see>
    /// </summary>
    let TemporalUnit = _prefix "TemporalUnit"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#unitSecond"></see>
    /// </summary>
    let unitSecond = _prefix "unitSecond"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#unitMinute"></see>
    /// </summary>
    let unitMinute = _prefix "unitMinute"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#unitHour"></see>
    /// </summary>
    let unitHour = _prefix "unitHour"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#unitDay"></see>
    /// </summary>
    let unitDay = _prefix "unitDay"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#unitWeek"></see>
    /// </summary>
    let unitWeek = _prefix "unitWeek"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#unitMonth"></see>
    /// </summary>
    let unitMonth = _prefix "unitMonth"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#unitYear"></see>
    /// </summary>
    let unitYear = _prefix "unitYear"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#after"></see>
    /// </summary>
    let after = _prefix "after"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#before"></see>
    /// </summary>
    let before = _prefix "before"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#begins"></see>
    /// </summary>
    let begins = _prefix "begins"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#calendarClockDescriptionDataType"></see>
    /// </summary>
    let calendarClockDescriptionDataType = _prefix "calendarClockDescriptionDataType"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#calendarClockDescriptionOf"></see>
    /// </summary>
    let calendarClockDescriptionOf = _prefix "calendarClockDescriptionOf"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#durationDescriptionDataType"></see>
    /// </summary>
    let durationDescriptionDataType = _prefix "durationDescriptionDataType"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#durationDescriptionOf"></see>
    /// </summary>
    let durationDescriptionOf = _prefix "durationDescriptionOf"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#ends"></see>
    /// </summary>
    let ends = _prefix "ends"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#inCalendarClock"></see>
    /// </summary>
    let inCalendarClock = _prefix "inCalendarClock"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#inCalendarClockDataType"></see>
    /// </summary>
    let inCalendarClockDataType = _prefix "inCalendarClockDataType"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#inside"></see>
    /// </summary>
    let inside = _prefix "inside"

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#instantPairDurationDescriptionDataType"></see>
    /// </summary>
    let instantPairDurationDescriptionDataType =
        _prefix "instantPairDurationDescriptionDataType"

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#instantPairDurationDescriptionOf"></see>
    /// </summary>
    let instantPairDurationDescriptionOf = _prefix "instantPairDurationDescriptionOf"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intAfter"></see>
    /// </summary>
    let intAfter = _prefix "intAfter"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#nonoverlap"></see>
    /// </summary>
    let nonoverlap = _prefix "nonoverlap"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intBefore"></see>
    /// </summary>
    let intBefore = _prefix "intBefore"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intContains"></see>
    /// </summary>
    let intContains = _prefix "intContains"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intDuring"></see>
    /// </summary>
    let intDuring = _prefix "intDuring"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#startsOrDuring"></see>
    /// </summary>
    let startsOrDuring = _prefix "startsOrDuring"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intEquals"></see>
    /// </summary>
    let intEquals = _prefix "intEquals"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intFinishedBy"></see>
    /// </summary>
    let intFinishedBy = _prefix "intFinishedBy"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intFinishes"></see>
    /// </summary>
    let intFinishes = _prefix "intFinishes"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intMeets"></see>
    /// </summary>
    let intMeets = _prefix "intMeets"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intMetBy"></see>
    /// </summary>
    let intMetBy = _prefix "intMetBy"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intOverlappedBy"></see>
    /// </summary>
    let intOverlappedBy = _prefix "intOverlappedBy"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intOverlaps"></see>
    /// </summary>
    let intOverlaps = _prefix "intOverlaps"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intStartedBy"></see>
    /// </summary>
    let intStartedBy = _prefix "intStartedBy"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intStarts"></see>
    /// </summary>
    let intStarts = _prefix "intStarts"
