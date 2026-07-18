namespace http.www.w3.org._2006.time_entry.hash

open DoxAletheia.Rdf_Vocabulary

module te =
    let _namespace_name = "http://www.w3.org/2006/time-entry#"

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#CalendarClockDescription"></see>
    /// </summary>
    let CalendarClockDescription =
        Namespaced_IRI.parse _namespace_name "CalendarClockDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#dayOfYearField"></see>
    /// </summary>
    let dayOfYearField =
        Namespaced_IRI.parse _namespace_name "dayOfYearField" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#month"></see>
    /// </summary>
    let month = Namespaced_IRI.parse _namespace_name "month" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#week"></see>
    /// </summary>
    let week = Namespaced_IRI.parse _namespace_name "week" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#day"></see>
    /// </summary>
    let day = Namespaced_IRI.parse _namespace_name "day" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#second"></see>
    /// </summary>
    let second = Namespaced_IRI.parse _namespace_name "second" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#hour"></see>
    /// </summary>
    let hour = Namespaced_IRI.parse _namespace_name "hour" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#minute"></see>
    /// </summary>
    let minute = Namespaced_IRI.parse _namespace_name "minute" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#unitType"></see>
    /// </summary>
    let unitType = Namespaced_IRI.parse _namespace_name "unitType" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#timeZone"></see>
    /// </summary>
    let timeZone = Namespaced_IRI.parse _namespace_name "timeZone" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#year"></see>
    /// </summary>
    let year = Namespaced_IRI.parse _namespace_name "year" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#dayOfWeekField"></see>
    /// </summary>
    let dayOfWeekField =
        Namespaced_IRI.parse _namespace_name "dayOfWeekField" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#CalendarClockInterval"></see>
    /// </summary>
    let CalendarClockInterval =
        Namespaced_IRI.parse _namespace_name "CalendarClockInterval" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#ProperInterval"></see>
    /// </summary>
    let ProperInterval =
        Namespaced_IRI.parse _namespace_name "ProperInterval" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#DurationDescription"></see>
    /// </summary>
    let DurationDescription =
        Namespaced_IRI.parse _namespace_name "DurationDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#hours"></see>
    /// </summary>
    let hours = Namespaced_IRI.parse _namespace_name "hours" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#years"></see>
    /// </summary>
    let years = Namespaced_IRI.parse _namespace_name "years" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#months"></see>
    /// </summary>
    let months = Namespaced_IRI.parse _namespace_name "months" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#days"></see>
    /// </summary>
    let days = Namespaced_IRI.parse _namespace_name "days" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#weeks"></see>
    /// </summary>
    let weeks = Namespaced_IRI.parse _namespace_name "weeks" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#minutes"></see>
    /// </summary>
    let minutes = Namespaced_IRI.parse _namespace_name "minutes" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#seconds"></see>
    /// </summary>
    let seconds = Namespaced_IRI.parse _namespace_name "seconds" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#Event"></see>
    /// </summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#TemporalThing"></see>
    /// </summary>
    let TemporalThing =
        Namespaced_IRI.parse _namespace_name "TemporalThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#InstantEvent"></see>
    /// </summary>
    let InstantEvent =
        Namespaced_IRI.parse _namespace_name "InstantEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#IntervalEvent"></see>
    /// </summary>
    let IntervalEvent =
        Namespaced_IRI.parse _namespace_name "IntervalEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#Instant"></see>
    /// </summary>
    let Instant = Namespaced_IRI.parse _namespace_name "Instant" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#InstantThing"></see>
    /// </summary>
    let InstantThing =
        Namespaced_IRI.parse _namespace_name "InstantThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#TemporalEntity"></see>
    /// </summary>
    let TemporalEntity =
        Namespaced_IRI.parse _namespace_name "TemporalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#InstantThingPair"></see>
    /// </summary>
    let InstantThingPair =
        Namespaced_IRI.parse _namespace_name "InstantThingPair" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#secondInstantThing"></see>
    /// </summary>
    let secondInstantThing =
        Namespaced_IRI.parse _namespace_name "secondInstantThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#firstInstantThing"></see>
    /// </summary>
    let firstInstantThing =
        Namespaced_IRI.parse _namespace_name "firstInstantThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#Interval"></see>
    /// </summary>
    let Interval = Namespaced_IRI.parse _namespace_name "Interval" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#IntervalThing"></see>
    /// </summary>
    let IntervalThing =
        Namespaced_IRI.parse _namespace_name "IntervalThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#ProperIntervalThing"></see>
    /// </summary>
    let ProperIntervalThing =
        Namespaced_IRI.parse _namespace_name "ProperIntervalThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#TemporalUnit"></see>
    /// </summary>
    let TemporalUnit =
        Namespaced_IRI.parse _namespace_name "TemporalUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#unitSecond"></see>
    /// </summary>
    let unitSecond = Namespaced_IRI.parse _namespace_name "unitSecond" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#unitMinute"></see>
    /// </summary>
    let unitMinute = Namespaced_IRI.parse _namespace_name "unitMinute" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#unitHour"></see>
    /// </summary>
    let unitHour = Namespaced_IRI.parse _namespace_name "unitHour" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#unitDay"></see>
    /// </summary>
    let unitDay = Namespaced_IRI.parse _namespace_name "unitDay" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#unitWeek"></see>
    /// </summary>
    let unitWeek = Namespaced_IRI.parse _namespace_name "unitWeek" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#unitMonth"></see>
    /// </summary>
    let unitMonth = Namespaced_IRI.parse _namespace_name "unitMonth" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#unitYear"></see>
    /// </summary>
    let unitYear = Namespaced_IRI.parse _namespace_name "unitYear" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#after"></see>
    /// </summary>
    let after = Namespaced_IRI.parse _namespace_name "after" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#before"></see>
    /// </summary>
    let before = Namespaced_IRI.parse _namespace_name "before" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#begins"></see>
    /// </summary>
    let begins = Namespaced_IRI.parse _namespace_name "begins" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#calendarClockDescriptionDataType"></see>
    /// </summary>
    let calendarClockDescriptionDataType =
        Namespaced_IRI.parse _namespace_name "calendarClockDescriptionDataType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#calendarClockDescriptionOf"></see>
    /// </summary>
    let calendarClockDescriptionOf =
        Namespaced_IRI.parse _namespace_name "calendarClockDescriptionOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#durationDescriptionDataType"></see>
    /// </summary>
    let durationDescriptionDataType =
        Namespaced_IRI.parse _namespace_name "durationDescriptionDataType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#durationDescriptionOf"></see>
    /// </summary>
    let durationDescriptionOf =
        Namespaced_IRI.parse _namespace_name "durationDescriptionOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#ends"></see>
    /// </summary>
    let ends = Namespaced_IRI.parse _namespace_name "ends" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#inCalendarClock"></see>
    /// </summary>
    let inCalendarClock =
        Namespaced_IRI.parse _namespace_name "inCalendarClock" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#inCalendarClockDataType"></see>
    /// </summary>
    let inCalendarClockDataType =
        Namespaced_IRI.parse _namespace_name "inCalendarClockDataType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#inside"></see>
    /// </summary>
    let inside = Namespaced_IRI.parse _namespace_name "inside" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#instantPairDurationDescriptionDataType"></see>
    /// </summary>
    let instantPairDurationDescriptionDataType =
        Namespaced_IRI.parse _namespace_name "instantPairDurationDescriptionDataType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#instantPairDurationDescriptionOf"></see>
    /// </summary>
    let instantPairDurationDescriptionOf =
        Namespaced_IRI.parse _namespace_name "instantPairDurationDescriptionOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intAfter"></see>
    /// </summary>
    let intAfter = Namespaced_IRI.parse _namespace_name "intAfter" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#nonoverlap"></see>
    /// </summary>
    let nonoverlap = Namespaced_IRI.parse _namespace_name "nonoverlap" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intBefore"></see>
    /// </summary>
    let intBefore = Namespaced_IRI.parse _namespace_name "intBefore" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intContains"></see>
    /// </summary>
    let intContains =
        Namespaced_IRI.parse _namespace_name "intContains" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intDuring"></see>
    /// </summary>
    let intDuring = Namespaced_IRI.parse _namespace_name "intDuring" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#startsOrDuring"></see>
    /// </summary>
    let startsOrDuring =
        Namespaced_IRI.parse _namespace_name "startsOrDuring" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intEquals"></see>
    /// </summary>
    let intEquals = Namespaced_IRI.parse _namespace_name "intEquals" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intFinishedBy"></see>
    /// </summary>
    let intFinishedBy =
        Namespaced_IRI.parse _namespace_name "intFinishedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intFinishes"></see>
    /// </summary>
    let intFinishes =
        Namespaced_IRI.parse _namespace_name "intFinishes" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intMeets"></see>
    /// </summary>
    let intMeets = Namespaced_IRI.parse _namespace_name "intMeets" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intMetBy"></see>
    /// </summary>
    let intMetBy = Namespaced_IRI.parse _namespace_name "intMetBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intOverlappedBy"></see>
    /// </summary>
    let intOverlappedBy =
        Namespaced_IRI.parse _namespace_name "intOverlappedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intOverlaps"></see>
    /// </summary>
    let intOverlaps =
        Namespaced_IRI.parse _namespace_name "intOverlaps" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intStartedBy"></see>
    /// </summary>
    let intStartedBy =
        Namespaced_IRI.parse _namespace_name "intStartedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time-entry#intStarts"></see>
    /// </summary>
    let intStarts = Namespaced_IRI.parse _namespace_name "intStarts" |> NamespacedName
