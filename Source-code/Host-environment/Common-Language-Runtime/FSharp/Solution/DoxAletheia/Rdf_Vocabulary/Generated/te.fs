namespace http.www.w3.org._2006.time_entry.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module te =
    let _namespace_iri = Namespace_Iri te |> NamespaceIRI
    /// <summary>
    ///   <para>te:month</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#month">http://www.w3.org/2006/time-entry#month</seealso>
    let month = Prefixed_Name(te, "month") |> PrefixedName
    /// <summary>
    ///   <para>te:second</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#second">http://www.w3.org/2006/time-entry#second</seealso>
    let second = Prefixed_Name(te, "second") |> PrefixedName
    /// <summary>
    ///   <para>te:hour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#hour">http://www.w3.org/2006/time-entry#hour</seealso>
    let hour = Prefixed_Name(te, "hour") |> PrefixedName
    /// <summary>
    ///   <para>te:unitType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#unitType">http://www.w3.org/2006/time-entry#unitType</seealso>
    let unitType = Prefixed_Name(te, "unitType") |> PrefixedName
    /// <summary>
    ///   <para>te:begins</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#begins">http://www.w3.org/2006/time-entry#begins</seealso>
    let begins = Prefixed_Name(te, "begins") |> PrefixedName
    /// <summary>
    ///   <para>te:week</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#week">http://www.w3.org/2006/time-entry#week</seealso>
    let week = Prefixed_Name(te, "week") |> PrefixedName
    /// <summary>
    ///   <para>te:unitYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>te:TemporalUnit</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#unitYear">http://www.w3.org/2006/time-entry#unitYear</seealso>
    let unitYear = Prefixed_Name(te, "unitYear") |> PrefixedName
    /// <summary>
    ///   <para>te:dayOfYearField</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#dayOfYearField">http://www.w3.org/2006/time-entry#dayOfYearField</seealso>
    let dayOfYearField = Prefixed_Name(te, "dayOfYearField") |> PrefixedName
    /// <summary>
    ///   <para>te:minutes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#minutes">http://www.w3.org/2006/time-entry#minutes</seealso>
    let minutes = Prefixed_Name(te, "minutes") |> PrefixedName
    /// <summary>
    ///   <para>te:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#Event">http://www.w3.org/2006/time-entry#Event</seealso>
    let Event = Prefixed_Name(te, "Event") |> PrefixedName
    /// <summary>
    ///   <para>te:InstantThingPair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#InstantThingPair">http://www.w3.org/2006/time-entry#InstantThingPair</seealso>
    let InstantThingPair = Prefixed_Name(te, "InstantThingPair") |> PrefixedName
    /// <summary>
    ///   <para>te:minute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#minute">http://www.w3.org/2006/time-entry#minute</seealso>
    let minute = Prefixed_Name(te, "minute") |> PrefixedName
    /// <summary>
    ///   <para>te:startsOrDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#startsOrDuring">http://www.w3.org/2006/time-entry#startsOrDuring</seealso>
    let startsOrDuring = Prefixed_Name(te, "startsOrDuring") |> PrefixedName
    /// <summary>
    ///   <para>te:intOverlaps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#intOverlaps">http://www.w3.org/2006/time-entry#intOverlaps</seealso>
    let intOverlaps = Prefixed_Name(te, "intOverlaps") |> PrefixedName
    /// <summary>
    ///   <para>te:timeZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#timeZone">http://www.w3.org/2006/time-entry#timeZone</seealso>
    let timeZone = Prefixed_Name(te, "timeZone") |> PrefixedName
    /// <summary>
    ///   <para>te:year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#year">http://www.w3.org/2006/time-entry#year</seealso>
    let year = Prefixed_Name(te, "year") |> PrefixedName
    /// <summary>
    ///   <para>te:ProperInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#ProperInterval">http://www.w3.org/2006/time-entry#ProperInterval</seealso>
    let ProperInterval = Prefixed_Name(te, "ProperInterval") |> PrefixedName
    /// <summary>
    ///   <para>te:hours</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#hours">http://www.w3.org/2006/time-entry#hours</seealso>
    let hours = Prefixed_Name(te, "hours") |> PrefixedName
    /// <summary>
    ///   <para>te:months</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#months">http://www.w3.org/2006/time-entry#months</seealso>
    let months = Prefixed_Name(te, "months") |> PrefixedName
    /// <summary>
    ///   <para>te:weeks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#weeks">http://www.w3.org/2006/time-entry#weeks</seealso>
    let weeks = Prefixed_Name(te, "weeks") |> PrefixedName
    /// <summary>
    ///   <para>te:seconds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#seconds">http://www.w3.org/2006/time-entry#seconds</seealso>
    let seconds = Prefixed_Name(te, "seconds") |> PrefixedName
    /// <summary>
    ///   <para>te:InstantEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#InstantEvent">http://www.w3.org/2006/time-entry#InstantEvent</seealso>
    let InstantEvent = Prefixed_Name(te, "InstantEvent") |> PrefixedName
    /// <summary>
    ///   <para>te:Instant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#Instant">http://www.w3.org/2006/time-entry#Instant</seealso>
    let Instant = Prefixed_Name(te, "Instant") |> PrefixedName
    /// <summary>
    ///   <para>te:InstantThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#InstantThing">http://www.w3.org/2006/time-entry#InstantThing</seealso>
    let InstantThing = Prefixed_Name(te, "InstantThing") |> PrefixedName
    /// <summary>
    ///   <para>te:secondInstantThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#secondInstantThing">http://www.w3.org/2006/time-entry#secondInstantThing</seealso>
    let secondInstantThing = Prefixed_Name(te, "secondInstantThing") |> PrefixedName
    /// <summary>
    ///   <para>te:Interval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#Interval">http://www.w3.org/2006/time-entry#Interval</seealso>
    let Interval = Prefixed_Name(te, "Interval") |> PrefixedName
    /// <summary>
    ///   <para>te:IntervalThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#IntervalThing">http://www.w3.org/2006/time-entry#IntervalThing</seealso>
    let IntervalThing = Prefixed_Name(te, "IntervalThing") |> PrefixedName
    /// <summary>
    ///   <para>te:ProperIntervalThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#ProperIntervalThing">http://www.w3.org/2006/time-entry#ProperIntervalThing</seealso>
    let ProperIntervalThing = Prefixed_Name(te, "ProperIntervalThing") |> PrefixedName
    /// <summary>
    ///   <para>te:TemporalThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#TemporalThing">http://www.w3.org/2006/time-entry#TemporalThing</seealso>
    let TemporalThing = Prefixed_Name(te, "TemporalThing") |> PrefixedName
    /// <summary>
    ///   <para>te:IntervalEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#IntervalEvent">http://www.w3.org/2006/time-entry#IntervalEvent</seealso>
    let IntervalEvent = Prefixed_Name(te, "IntervalEvent") |> PrefixedName
    /// <summary>
    ///   <para>te:TemporalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#TemporalEntity">http://www.w3.org/2006/time-entry#TemporalEntity</seealso>
    let TemporalEntity = Prefixed_Name(te, "TemporalEntity") |> PrefixedName
    /// <summary>
    ///   <para>te:firstInstantThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#firstInstantThing">http://www.w3.org/2006/time-entry#firstInstantThing</seealso>
    let firstInstantThing = Prefixed_Name(te, "firstInstantThing") |> PrefixedName
    /// <summary>
    ///   <para>te:unitSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>te:TemporalUnit</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#unitSecond">http://www.w3.org/2006/time-entry#unitSecond</seealso>
    let unitSecond = Prefixed_Name(te, "unitSecond") |> PrefixedName
    /// <summary>
    ///   <para>te:unitDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>te:TemporalUnit</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#unitDay">http://www.w3.org/2006/time-entry#unitDay</seealso>
    let unitDay = Prefixed_Name(te, "unitDay") |> PrefixedName
    /// <summary>
    ///   <para>te:unitMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>te:TemporalUnit</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#unitMonth">http://www.w3.org/2006/time-entry#unitMonth</seealso>
    let unitMonth = Prefixed_Name(te, "unitMonth") |> PrefixedName
    /// <summary>
    ///   <para>te:TemporalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#TemporalUnit">http://www.w3.org/2006/time-entry#TemporalUnit</seealso>
    let TemporalUnit = Prefixed_Name(te, "TemporalUnit") |> PrefixedName
    /// <summary>
    ///   <para>te:unitHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>te:TemporalUnit</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#unitHour">http://www.w3.org/2006/time-entry#unitHour</seealso>
    let unitHour = Prefixed_Name(te, "unitHour") |> PrefixedName
    /// <summary>
    ///   <para>te:unitWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>te:TemporalUnit</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#unitWeek">http://www.w3.org/2006/time-entry#unitWeek</seealso>
    let unitWeek = Prefixed_Name(te, "unitWeek") |> PrefixedName
    /// <summary>
    ///   <para>te:unitMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>te:TemporalUnit</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#unitMinute">http://www.w3.org/2006/time-entry#unitMinute</seealso>
    let unitMinute = Prefixed_Name(te, "unitMinute") |> PrefixedName
    /// <summary>
    ///   <para>te:after</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#after">http://www.w3.org/2006/time-entry#after</seealso>
    let after = Prefixed_Name(te, "after") |> PrefixedName
    /// <summary>
    ///   <para>te:before</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#before">http://www.w3.org/2006/time-entry#before</seealso>
    let before = Prefixed_Name(te, "before") |> PrefixedName

    /// <summary>
    ///   <para>te:calendarClockDescriptionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#calendarClockDescriptionOf">http://www.w3.org/2006/time-entry#calendarClockDescriptionOf</seealso>
    let calendarClockDescriptionOf =
        Prefixed_Name(te, "calendarClockDescriptionOf") |> PrefixedName

    /// <summary>
    ///   <para>te:durationDescriptionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#durationDescriptionOf">http://www.w3.org/2006/time-entry#durationDescriptionOf</seealso>
    let durationDescriptionOf =
        Prefixed_Name(te, "durationDescriptionOf") |> PrefixedName

    /// <summary>
    ///   <para>te:calendarClockDescriptionDataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#calendarClockDescriptionDataType">http://www.w3.org/2006/time-entry#calendarClockDescriptionDataType</seealso>
    let calendarClockDescriptionDataType =
        Prefixed_Name(te, "calendarClockDescriptionDataType") |> PrefixedName

    /// <summary>
    ///   <para>te:durationDescriptionDataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#durationDescriptionDataType">http://www.w3.org/2006/time-entry#durationDescriptionDataType</seealso>
    let durationDescriptionDataType =
        Prefixed_Name(te, "durationDescriptionDataType") |> PrefixedName

    /// <summary>
    ///   <para>te:inCalendarClock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#inCalendarClock">http://www.w3.org/2006/time-entry#inCalendarClock</seealso>
    let inCalendarClock = Prefixed_Name(te, "inCalendarClock") |> PrefixedName

    /// <summary>
    ///   <para>te:instantPairDurationDescriptionDataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#instantPairDurationDescriptionDataType">http://www.w3.org/2006/time-entry#instantPairDurationDescriptionDataType</seealso>
    let instantPairDurationDescriptionDataType =
        Prefixed_Name(te, "instantPairDurationDescriptionDataType") |> PrefixedName

    /// <summary>
    ///   <para>te:intBefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#intBefore">http://www.w3.org/2006/time-entry#intBefore</seealso>
    let intBefore = Prefixed_Name(te, "intBefore") |> PrefixedName
    /// <summary>
    ///   <para>te:intEquals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#intEquals">http://www.w3.org/2006/time-entry#intEquals</seealso>
    let intEquals = Prefixed_Name(te, "intEquals") |> PrefixedName
    /// <summary>
    ///   <para>te:intMeets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#intMeets">http://www.w3.org/2006/time-entry#intMeets</seealso>
    let intMeets = Prefixed_Name(te, "intMeets") |> PrefixedName
    /// <summary>
    ///   <para>te:ends</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#ends">http://www.w3.org/2006/time-entry#ends</seealso>
    let ends = Prefixed_Name(te, "ends") |> PrefixedName
    /// <summary>
    ///   <para>te:inside</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#inside">http://www.w3.org/2006/time-entry#inside</seealso>
    let inside = Prefixed_Name(te, "inside") |> PrefixedName

    /// <summary>
    ///   <para>te:instantPairDurationDescriptionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#instantPairDurationDescriptionOf">http://www.w3.org/2006/time-entry#instantPairDurationDescriptionOf</seealso>
    let instantPairDurationDescriptionOf =
        Prefixed_Name(te, "instantPairDurationDescriptionOf") |> PrefixedName

    /// <summary>
    ///   <para>te:nonoverlap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#nonoverlap">http://www.w3.org/2006/time-entry#nonoverlap</seealso>
    let nonoverlap = Prefixed_Name(te, "nonoverlap") |> PrefixedName
    /// <summary>
    ///   <para>te:intDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#intDuring">http://www.w3.org/2006/time-entry#intDuring</seealso>
    let intDuring = Prefixed_Name(te, "intDuring") |> PrefixedName
    /// <summary>
    ///   <para>te:intFinishes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#intFinishes">http://www.w3.org/2006/time-entry#intFinishes</seealso>
    let intFinishes = Prefixed_Name(te, "intFinishes") |> PrefixedName
    /// <summary>
    ///   <para>te:intOverlappedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#intOverlappedBy">http://www.w3.org/2006/time-entry#intOverlappedBy</seealso>
    let intOverlappedBy = Prefixed_Name(te, "intOverlappedBy") |> PrefixedName
    /// <summary>
    ///   <para>te:intStarts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#intStarts">http://www.w3.org/2006/time-entry#intStarts</seealso>
    let intStarts = Prefixed_Name(te, "intStarts") |> PrefixedName

    /// <summary>
    ///   <para>te:inCalendarClockDataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#inCalendarClockDataType">http://www.w3.org/2006/time-entry#inCalendarClockDataType</seealso>
    let inCalendarClockDataType =
        Prefixed_Name(te, "inCalendarClockDataType") |> PrefixedName

    /// <summary>
    ///   <para>te:intAfter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#intAfter">http://www.w3.org/2006/time-entry#intAfter</seealso>
    let intAfter = Prefixed_Name(te, "intAfter") |> PrefixedName
    /// <summary>
    ///   <para>te:intContains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#intContains">http://www.w3.org/2006/time-entry#intContains</seealso>
    let intContains = Prefixed_Name(te, "intContains") |> PrefixedName
    /// <summary>
    ///   <para>te:intFinishedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#intFinishedBy">http://www.w3.org/2006/time-entry#intFinishedBy</seealso>
    let intFinishedBy = Prefixed_Name(te, "intFinishedBy") |> PrefixedName
    /// <summary>
    ///   <para>te:intMetBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#intMetBy">http://www.w3.org/2006/time-entry#intMetBy</seealso>
    let intMetBy = Prefixed_Name(te, "intMetBy") |> PrefixedName
    /// <summary>
    ///   <para>te:intStartedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#intStartedBy">http://www.w3.org/2006/time-entry#intStartedBy</seealso>
    let intStartedBy = Prefixed_Name(te, "intStartedBy") |> PrefixedName

    /// <summary>
    ///   <para>te:CalendarClockDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#CalendarClockDescription">http://www.w3.org/2006/time-entry#CalendarClockDescription</seealso>
    let CalendarClockDescription =
        Prefixed_Name(te, "CalendarClockDescription") |> PrefixedName

    /// <summary>
    ///   <para>te:day</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#day">http://www.w3.org/2006/time-entry#day</seealso>
    let day = Prefixed_Name(te, "day") |> PrefixedName
    /// <summary>
    ///   <para>te:dayOfWeekField</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#dayOfWeekField">http://www.w3.org/2006/time-entry#dayOfWeekField</seealso>
    let dayOfWeekField = Prefixed_Name(te, "dayOfWeekField") |> PrefixedName

    /// <summary>
    ///   <para>te:CalendarClockInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#CalendarClockInterval">http://www.w3.org/2006/time-entry#CalendarClockInterval</seealso>
    let CalendarClockInterval =
        Prefixed_Name(te, "CalendarClockInterval") |> PrefixedName

    /// <summary>
    ///   <para>te:DurationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#DurationDescription">http://www.w3.org/2006/time-entry#DurationDescription</seealso>
    let DurationDescription = Prefixed_Name(te, "DurationDescription") |> PrefixedName
    /// <summary>
    ///   <para>te:years</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#years">http://www.w3.org/2006/time-entry#years</seealso>
    let years = Prefixed_Name(te, "years") |> PrefixedName
    /// <summary>
    ///   <para>te:days</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/time-entry#days">http://www.w3.org/2006/time-entry#days</seealso>
    let days = Prefixed_Name(te, "days") |> PrefixedName
