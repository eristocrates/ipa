namespace http.www.w3.org._2006.time.hash

open DoxAletheia.Rdf_Vocabulary

module owl_time =
    let _namespace_name = "http://www.w3.org/2006/time#"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#2006"></see>
    /// </summary>
    let _2006 = Namespaced_IRI.parse _namespace_name "2006" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#2016"></see>
    /// </summary>
    let _2016 = Namespaced_IRI.parse _namespace_name "2016" |> NamespacedName

    /// <summary>
    /// Description of date and time structured with separate values for the various elements of a calendar-clock system. The temporal reference system is fixed to Gregorian Calendar, and the range of year, month, day properties restricted to corresponding XML Schema types xsd:gYear, xsd:gMonth and xsd:gDay, respectively.
    /// <see href="http://www.w3.org/2006/time#DateTimeDescription"></see></summary>
    let DateTimeDescription =
        Namespaced_IRI.parse _namespace_name "DateTimeDescription" |> NamespacedName

    /// <summary>
    /// The temporal reference system used by a temporal position or extent description.
    /// <see href="http://www.w3.org/2006/time#hasTRS"></see></summary>
    let hasTRS = Namespaced_IRI.parse _namespace_name "hasTRS" |> NamespacedName
    /// <summary>
    /// Year position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar year from any calendar.
    /// <see href="http://www.w3.org/2006/time#year"></see></summary>
    let year = Namespaced_IRI.parse _namespace_name "year" |> NamespacedName
    /// <summary>
    /// Month position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar month from any calendar.
    /// <see href="http://www.w3.org/2006/time#month"></see></summary>
    let month = Namespaced_IRI.parse _namespace_name "month" |> NamespacedName
    /// <summary>
    /// Day position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar day from any calendar.
    /// <see href="http://www.w3.org/2006/time#day"></see></summary>
    let day = Namespaced_IRI.parse _namespace_name "day" |> NamespacedName

    /// <summary>
    /// Description of date and time structured with separate values for the various elements of a calendar-clock system
    /// <see href="http://www.w3.org/2006/time#GeneralDateTimeDescription"></see></summary>
    let GeneralDateTimeDescription =
        Namespaced_IRI.parse _namespace_name "GeneralDateTimeDescription" |> NamespacedName

    /// <summary>
    /// DateTimeInterval is a subclass of ProperInterval, defined using the multi-element DateTimeDescription.
    /// <see href="http://www.w3.org/2006/time#DateTimeInterval"></see></summary>
    let DateTimeInterval =
        Namespaced_IRI.parse _namespace_name "DateTimeInterval" |> NamespacedName

    /// <summary>
    /// A temporal entity with non-zero extent or duration, i.e. for which the value of the beginning and end are different
    /// <see href="http://www.w3.org/2006/time#ProperInterval"></see></summary>
    let ProperInterval =
        Namespaced_IRI.parse _namespace_name "ProperInterval" |> NamespacedName

    /// <summary>
    /// The day of week
    /// <see href="http://www.w3.org/2006/time#DayOfWeek"></see></summary>
    let DayOfWeek = Namespaced_IRI.parse _namespace_name "DayOfWeek" |> NamespacedName
    /// <summary>
    /// Duration of a temporal extent expressed as a number scaled by a temporal unit
    /// <see href="http://www.w3.org/2006/time#Duration"></see></summary>
    let Duration = Namespaced_IRI.parse _namespace_name "Duration" |> NamespacedName
    /// <summary>
    /// The temporal unit which provides the precision of a date-time value or scale of a temporal extent
    /// <see href="http://www.w3.org/2006/time#unitType"></see></summary>
    let unitType = Namespaced_IRI.parse _namespace_name "unitType" |> NamespacedName

    /// <summary>
    /// Value of a temporal extent expressed as a decimal number scaled by a temporal unit
    /// <see href="http://www.w3.org/2006/time#numericDuration"></see></summary>
    let numericDuration =
        Namespaced_IRI.parse _namespace_name "numericDuration" |> NamespacedName

    /// <summary>
    /// Time extent; duration of a time interval separate from its particular start position
    /// <see href="http://www.w3.org/2006/time#TemporalDuration"></see></summary>
    let TemporalDuration =
        Namespaced_IRI.parse _namespace_name "TemporalDuration" |> NamespacedName

    /// <summary>
    /// Description of temporal extent structured with separate values for the various elements of a calendar-clock system. The temporal reference system is fixed to Gregorian Calendar, and the range of each of the numeric properties is restricted to xsd:decimal
    /// <see href="http://www.w3.org/2006/time#DurationDescription"></see></summary>
    let DurationDescription =
        Namespaced_IRI.parse _namespace_name "DurationDescription" |> NamespacedName

    /// <summary>
    /// Description of temporal extent structured with separate values for the various elements of a calendar-clock system.
    /// <see href="http://www.w3.org/2006/time#GeneralDurationDescription"></see></summary>
    let GeneralDurationDescription =
        Namespaced_IRI.parse _namespace_name "GeneralDurationDescription" |> NamespacedName

    /// <summary>
    /// length of, or element of the length of, a temporal extent expressed in months
    /// <see href="http://www.w3.org/2006/time#months"></see></summary>
    let months = Namespaced_IRI.parse _namespace_name "months" |> NamespacedName
    /// <summary>
    /// length of, or element of the length of, a temporal extent expressed in weeks
    /// <see href="http://www.w3.org/2006/time#weeks"></see></summary>
    let weeks = Namespaced_IRI.parse _namespace_name "weeks" |> NamespacedName
    /// <summary>
    /// length of, or element of the length of, a temporal extent expressed in days
    /// <see href="http://www.w3.org/2006/time#days"></see></summary>
    let days = Namespaced_IRI.parse _namespace_name "days" |> NamespacedName
    /// <summary>
    /// length of, or element of the length of, a temporal extent expressed in hours
    /// <see href="http://www.w3.org/2006/time#hours"></see></summary>
    let hours = Namespaced_IRI.parse _namespace_name "hours" |> NamespacedName
    /// <summary>
    /// length of, or element of the length of, a temporal extent expressed in seconds
    /// <see href="http://www.w3.org/2006/time#seconds"></see></summary>
    let seconds = Namespaced_IRI.parse _namespace_name "seconds" |> NamespacedName
    /// <summary>
    /// length, or element of, a temporal extent expressed in minutes
    /// <see href="http://www.w3.org/2006/time#minutes"></see></summary>
    let minutes = Namespaced_IRI.parse _namespace_name "minutes" |> NamespacedName
    /// <summary>
    /// length of, or element of the length of, a temporal extent expressed in years
    /// <see href="http://www.w3.org/2006/time#years"></see></summary>
    let years = Namespaced_IRI.parse _namespace_name "years" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#Friday"></see>
    /// </summary>
    let Friday = Namespaced_IRI.parse _namespace_name "Friday" |> NamespacedName
    /// <summary>
    /// The day of week, whose value is a member of the class time:DayOfWeek
    /// <see href="http://www.w3.org/2006/time#dayOfWeek"></see></summary>
    let dayOfWeek = Namespaced_IRI.parse _namespace_name "dayOfWeek" |> NamespacedName
    /// <summary>
    /// The time zone for clock elements in the temporal position
    /// <see href="http://www.w3.org/2006/time#timeZone"></see></summary>
    let timeZone = Namespaced_IRI.parse _namespace_name "timeZone" |> NamespacedName
    /// <summary>
    /// Minute position in a calendar-clock system.
    /// <see href="http://www.w3.org/2006/time#minute"></see></summary>
    let minute = Namespaced_IRI.parse _namespace_name "minute" |> NamespacedName
    /// <summary>
    /// Hour position in a calendar-clock system.
    /// <see href="http://www.w3.org/2006/time#hour"></see></summary>
    let hour = Namespaced_IRI.parse _namespace_name "hour" |> NamespacedName
    /// <summary>
    /// Week number within the year.
    /// <see href="http://www.w3.org/2006/time#week"></see></summary>
    let week = Namespaced_IRI.parse _namespace_name "week" |> NamespacedName

    /// <summary>
    /// A position on a time-line
    /// <see href="http://www.w3.org/2006/time#TemporalPosition"></see></summary>
    let TemporalPosition =
        Namespaced_IRI.parse _namespace_name "TemporalPosition" |> NamespacedName

    /// <summary>
    /// The month of the year, whose value is a member of the class time:MonthOfYear
    /// <see href="http://www.w3.org/2006/time#monthOfYear"></see></summary>
    let monthOfYear =
        Namespaced_IRI.parse _namespace_name "monthOfYear" |> NamespacedName

    /// <summary>
    /// Second position in a calendar-clock system.
    /// <see href="http://www.w3.org/2006/time#second"></see></summary>
    let second = Namespaced_IRI.parse _namespace_name "second" |> NamespacedName
    /// <summary>
    /// The number of the day within the year
    /// <see href="http://www.w3.org/2006/time#dayOfYear"></see></summary>
    let dayOfYear = Namespaced_IRI.parse _namespace_name "dayOfYear" |> NamespacedName
    /// <summary>
    /// A temporal entity with zero extent or duration
    /// <see href="http://www.w3.org/2006/time#Instant"></see></summary>
    let Instant = Namespaced_IRI.parse _namespace_name "Instant" |> NamespacedName

    /// <summary>
    /// A temporal interval or instant.
    /// <see href="http://www.w3.org/2006/time#TemporalEntity"></see></summary>
    let TemporalEntity =
        Namespaced_IRI.parse _namespace_name "TemporalEntity" |> NamespacedName

    /// <summary>
    /// A temporal entity with an extent or duration
    /// <see href="http://www.w3.org/2006/time#Interval"></see></summary>
    let Interval = Namespaced_IRI.parse _namespace_name "Interval" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#January"></see>
    /// </summary>
    let January = Namespaced_IRI.parse _namespace_name "January" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#unitMonth"></see>
    /// </summary>
    let unitMonth = Namespaced_IRI.parse _namespace_name "unitMonth" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#Monday"></see>
    /// </summary>
    let Monday = Namespaced_IRI.parse _namespace_name "Monday" |> NamespacedName

    /// <summary>
    /// The month of the year
    /// <see href="http://www.w3.org/2006/time#MonthOfYear"></see></summary>
    let MonthOfYear =
        Namespaced_IRI.parse _namespace_name "MonthOfYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#Saturday"></see>
    /// </summary>
    let Saturday = Namespaced_IRI.parse _namespace_name "Saturday" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#Sunday"></see>
    /// </summary>
    let Sunday = Namespaced_IRI.parse _namespace_name "Sunday" |> NamespacedName
    /// <summary>
    /// A temporal reference system, such as a temporal coordinate system (with an origin, direction, and scale), a calendar-clock combination, or a (possibly hierarchical) ordinal system.
    ///
    /// This is a stub class, representing the set of all temporal reference systems.
    /// <see href="http://www.w3.org/2006/time#TRS"></see></summary>
    let TRS = Namespaced_IRI.parse _namespace_name "TRS" |> NamespacedName

    /// <summary>
    /// A standard duration, which provides a scale factor for a time extent, or the granularity or precision for a time position.
    /// <see href="http://www.w3.org/2006/time#TemporalUnit"></see></summary>
    let TemporalUnit =
        Namespaced_IRI.parse _namespace_name "TemporalUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#Thursday"></see>
    /// </summary>
    let Thursday = Namespaced_IRI.parse _namespace_name "Thursday" |> NamespacedName

    /// <summary>
    /// A temporal position described using either a (nominal) value from an ordinal reference system, or a (numeric) value in a temporal coordinate system.
    /// <see href="http://www.w3.org/2006/time#TimePosition"></see></summary>
    let TimePosition =
        Namespaced_IRI.parse _namespace_name "TimePosition" |> NamespacedName

    /// <summary>
    /// The (numeric) value indicating position within a temporal coordinate system
    /// <see href="http://www.w3.org/2006/time#numericPosition"></see></summary>
    let numericPosition =
        Namespaced_IRI.parse _namespace_name "numericPosition" |> NamespacedName

    /// <summary>
    /// The (nominal) value indicating temporal position in an ordinal reference system
    /// <see href="http://www.w3.org/2006/time#nominalPosition"></see></summary>
    let nominalPosition =
        Namespaced_IRI.parse _namespace_name "nominalPosition" |> NamespacedName

    /// <summary>
    /// A Time Zone specifies the amount by which the local time is offset from UTC.
    /// 	A time zone is usually denoted geographically (e.g. Australian Eastern Daylight Time), with a constant value in a given region.
    /// The region where it applies and the offset from UTC are specified by a locally recognised governing authority.
    /// <see href="http://www.w3.org/2006/time#TimeZone"></see></summary>
    let TimeZone = Namespaced_IRI.parse _namespace_name "TimeZone" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#Tuesday"></see>
    /// </summary>
    let Tuesday = Namespaced_IRI.parse _namespace_name "Tuesday" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#Wednesday"></see>
    /// </summary>
    let Wednesday = Namespaced_IRI.parse _namespace_name "Wednesday" |> NamespacedName
    /// <summary>
    /// Year duration
    /// <see href="http://www.w3.org/2006/time#Year"></see></summary>
    let Year = Namespaced_IRI.parse _namespace_name "Year" |> NamespacedName
    /// <summary>
    /// Gives directionality to time. If a temporal entity T1 is after another temporal entity T2, then the beginning of T1 is after the end of T2.
    /// <see href="http://www.w3.org/2006/time#after"></see></summary>
    let after = Namespaced_IRI.parse _namespace_name "after" |> NamespacedName
    /// <summary>
    /// Gives directionality to time. If a temporal entity T1 is before another temporal entity T2, then the end of T1 is before the beginning of T2. Thus, "before" can be considered to be basic to instants and derived for intervals.
    /// <see href="http://www.w3.org/2006/time#before"></see></summary>
    let before = Namespaced_IRI.parse _namespace_name "before" |> NamespacedName
    /// <summary>
    /// Day of month - formulated as a text string with a pattern constraint to reproduce the same lexical form as gDay, except that values up to 99 are permitted, in order to support calendars with more than 31 days in a month.
    /// Note that the value-space is not defined, so a generic OWL2 processor cannot compute ordering relationships of values of this type.
    /// <see href="http://www.w3.org/2006/time#generalDay"></see></summary>
    let generalDay = Namespaced_IRI.parse _namespace_name "generalDay" |> NamespacedName

    /// <summary>
    /// Month of year - formulated as a text string with a pattern constraint to reproduce the same lexical form as gMonth, except that values up to 20 are permitted, in order to support calendars with more than 12 months in the year.
    /// Note that the value-space is not defined, so a generic OWL2 processor cannot compute ordering relationships of values of this type.
    /// <see href="http://www.w3.org/2006/time#generalMonth"></see></summary>
    let generalMonth =
        Namespaced_IRI.parse _namespace_name "generalMonth" |> NamespacedName

    /// <summary>
    /// Year number - formulated as a text string with a pattern constraint to reproduce the same lexical form as gYear, but not restricted to values from the Gregorian calendar.
    /// Note that the value-space is not defined, so a generic OWL2 processor cannot compute ordering relationships of values of this type.
    /// <see href="http://www.w3.org/2006/time#generalYear"></see></summary>
    let generalYear =
        Namespaced_IRI.parse _namespace_name "generalYear" |> NamespacedName

    /// <summary>
    /// Beginning of a temporal entity
    /// <see href="http://www.w3.org/2006/time#hasBeginning"></see></summary>
    let hasBeginning =
        Namespaced_IRI.parse _namespace_name "hasBeginning" |> NamespacedName

    /// <summary>
    /// Supports the association of a temporal entity (instant or interval) to any thing
    /// <see href="http://www.w3.org/2006/time#hasTime"></see></summary>
    let hasTime = Namespaced_IRI.parse _namespace_name "hasTime" |> NamespacedName

    /// <summary>
    /// Value of DateTimeInterval expressed as a structured value. The beginning and end of the interval coincide with the limits of the shortest element in the description.
    /// <see href="http://www.w3.org/2006/time#hasDateTimeDescription"></see></summary>
    let hasDateTimeDescription =
        Namespaced_IRI.parse _namespace_name "hasDateTimeDescription" |> NamespacedName

    /// <summary>
    /// Duration of a temporal entity, expressed as a scaled value or nominal value
    /// <see href="http://www.w3.org/2006/time#hasDuration"></see></summary>
    let hasDuration =
        Namespaced_IRI.parse _namespace_name "hasDuration" |> NamespacedName

    /// <summary>
    /// Duration of a temporal entity.
    /// <see href="http://www.w3.org/2006/time#hasTemporalDuration"></see></summary>
    let hasTemporalDuration =
        Namespaced_IRI.parse _namespace_name "hasTemporalDuration" |> NamespacedName

    /// <summary>
    /// Duration of a temporal entity, expressed using a structured description
    /// <see href="http://www.w3.org/2006/time#hasDurationDescription"></see></summary>
    let hasDurationDescription =
        Namespaced_IRI.parse _namespace_name "hasDurationDescription" |> NamespacedName

    /// <summary>
    /// End of a temporal entity.
    /// <see href="http://www.w3.org/2006/time#hasEnd"></see></summary>
    let hasEnd = Namespaced_IRI.parse _namespace_name "hasEnd" |> NamespacedName

    /// <summary>
    /// Extent of a temporal entity, expressed using xsd:duration
    /// <see href="http://www.w3.org/2006/time#hasXSDDuration"></see></summary>
    let hasXSDDuration =
        Namespaced_IRI.parse _namespace_name "hasXSDDuration" |> NamespacedName

    /// <summary>
    /// Position of an instant, expressed using a structured description
    /// <see href="http://www.w3.org/2006/time#inDateTime"></see></summary>
    let inDateTime = Namespaced_IRI.parse _namespace_name "inDateTime" |> NamespacedName

    /// <summary>
    /// Position of a time instant
    /// <see href="http://www.w3.org/2006/time#inTemporalPosition"></see></summary>
    let inTemporalPosition =
        Namespaced_IRI.parse _namespace_name "inTemporalPosition" |> NamespacedName

    /// <summary>
    /// Position of an instant, expressed as a temporal coordinate or nominal value
    /// <see href="http://www.w3.org/2006/time#inTimePosition"></see></summary>
    let inTimePosition =
        Namespaced_IRI.parse _namespace_name "inTimePosition" |> NamespacedName

    /// <summary>
    /// Position of an instant, expressed using xsd:date
    /// <see href="http://www.w3.org/2006/time#inXSDDate"></see></summary>
    let inXSDDate = Namespaced_IRI.parse _namespace_name "inXSDDate" |> NamespacedName

    /// <summary>
    /// Position of an instant, expressed using xsd:dateTime
    /// <see href="http://www.w3.org/2006/time#inXSDDateTime"></see></summary>
    let inXSDDateTime =
        Namespaced_IRI.parse _namespace_name "inXSDDateTime" |> NamespacedName

    /// <summary>
    /// Position of an instant, expressed using xsd:dateTimeStamp
    /// <see href="http://www.w3.org/2006/time#inXSDDateTimeStamp"></see></summary>
    let inXSDDateTimeStamp =
        Namespaced_IRI.parse _namespace_name "inXSDDateTimeStamp" |> NamespacedName

    /// <summary>
    /// Position of an instant, expressed using xsd:gYear
    /// <see href="http://www.w3.org/2006/time#inXSDgYear"></see></summary>
    let inXSDgYear = Namespaced_IRI.parse _namespace_name "inXSDgYear" |> NamespacedName

    /// <summary>
    /// Position of an instant, expressed using xsd:gYearMonth
    /// <see href="http://www.w3.org/2006/time#inXSDgYearMonth"></see></summary>
    let inXSDgYearMonth =
        Namespaced_IRI.parse _namespace_name "inXSDgYearMonth" |> NamespacedName

    /// <summary>
    /// An instant that falls inside the interval. It is not intended to include beginnings and ends of intervals.
    /// <see href="http://www.w3.org/2006/time#inside"></see></summary>
    let inside = Namespaced_IRI.parse _namespace_name "inside" |> NamespacedName

    /// <summary>
    /// If a proper interval T1 is intervalAfter another proper interval T2, then the beginning of T1 is after the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalAfter"></see></summary>
    let intervalAfter =
        Namespaced_IRI.parse _namespace_name "intervalAfter" |> NamespacedName

    /// <summary>
    /// If a proper interval T1 is intervalDisjoint another proper interval T2, then the beginning of T1 is after the end of T2, or the end of T1 is before the beginning of T2, i.e. the intervals do not overlap in any way, but their ordering relationship is not known.
    /// <see href="http://www.w3.org/2006/time#intervalDisjoint"></see></summary>
    let intervalDisjoint =
        Namespaced_IRI.parse _namespace_name "intervalDisjoint" |> NamespacedName

    /// <summary>
    /// If a proper interval T1 is intervalBefore another proper interval T2, then the end of T1 is before the beginning of T2.
    /// <see href="http://www.w3.org/2006/time#intervalBefore"></see></summary>
    let intervalBefore =
        Namespaced_IRI.parse _namespace_name "intervalBefore" |> NamespacedName

    /// <summary>
    /// If a proper interval T1 is intervalContains another proper interval T2, then the beginning of T1 is before the beginning of T2, and the end of T1 is after the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalContains"></see></summary>
    let intervalContains =
        Namespaced_IRI.parse _namespace_name "intervalContains" |> NamespacedName

    /// <summary>
    /// If a proper interval T1 is intervalDuring another proper interval T2, then the beginning of T1 is after the beginning of T2, and the end of T1 is before the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalDuring"></see></summary>
    let intervalDuring =
        Namespaced_IRI.parse _namespace_name "intervalDuring" |> NamespacedName

    /// <summary>
    /// If a proper interval T1 is intervalIn another proper interval T2, then the beginning of T1 is after the beginning of T2 or is coincident with the beginning of T2, and the end of T1 is before the end of T2, or is coincident with the end of T2, except that end of T1 may not be coincident with the end of T2 if the beginning of T1 is coincident with the beginning of T2.
    /// <see href="http://www.w3.org/2006/time#intervalIn"></see></summary>
    let intervalIn = Namespaced_IRI.parse _namespace_name "intervalIn" |> NamespacedName

    /// <summary>
    /// If a proper interval T1 is intervalEquals another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is coincident with the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalEquals"></see></summary>
    let intervalEquals =
        Namespaced_IRI.parse _namespace_name "intervalEquals" |> NamespacedName

    /// <summary>
    /// If a proper interval T1 is intervalFinishedBy another proper interval T2, then the beginning of T1 is before the beginning of T2, and the end of T1 is coincident with the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalFinishedBy"></see></summary>
    let intervalFinishedBy =
        Namespaced_IRI.parse _namespace_name "intervalFinishedBy" |> NamespacedName

    /// <summary>
    /// If a proper interval T1 is intervalFinishes another proper interval T2, then the beginning of T1 is after the beginning of T2, and the end of T1 is coincident with the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalFinishes"></see></summary>
    let intervalFinishes =
        Namespaced_IRI.parse _namespace_name "intervalFinishes" |> NamespacedName

    /// <summary>
    /// If a proper interval T1 is intervalMeets another proper interval T2, then the end of T1 is coincident with the beginning of T2.
    /// <see href="http://www.w3.org/2006/time#intervalMeets"></see></summary>
    let intervalMeets =
        Namespaced_IRI.parse _namespace_name "intervalMeets" |> NamespacedName

    /// <summary>
    /// If a proper interval T1 is intervalMetBy another proper interval T2, then the beginning of T1 is coincident with the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalMetBy"></see></summary>
    let intervalMetBy =
        Namespaced_IRI.parse _namespace_name "intervalMetBy" |> NamespacedName

    /// <summary>
    /// If a proper interval T1 is intervalOverlappedBy another proper interval T2, then the beginning of T1 is after the beginning of T2, the beginning of T1 is before the end of T2, and the end of T1 is after the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalOverlappedBy"></see></summary>
    let intervalOverlappedBy =
        Namespaced_IRI.parse _namespace_name "intervalOverlappedBy" |> NamespacedName

    /// <summary>
    /// If a proper interval T1 is intervalOverlaps another proper interval T2, then the beginning of T1 is before the beginning of T2, the end of T1 is after the beginning of T2, and the end of T1 is before the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalOverlaps"></see></summary>
    let intervalOverlaps =
        Namespaced_IRI.parse _namespace_name "intervalOverlaps" |> NamespacedName

    /// <summary>
    /// If a proper interval T1 is intervalStarted another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is after the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalStartedBy"></see></summary>
    let intervalStartedBy =
        Namespaced_IRI.parse _namespace_name "intervalStartedBy" |> NamespacedName

    /// <summary>
    /// If a proper interval T1 is intervalStarts another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is before the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalStarts"></see></summary>
    let intervalStarts =
        Namespaced_IRI.parse _namespace_name "intervalStarts" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#unitDay"></see>
    /// </summary>
    let unitDay = Namespaced_IRI.parse _namespace_name "unitDay" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#unitHour"></see>
    /// </summary>
    let unitHour = Namespaced_IRI.parse _namespace_name "unitHour" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#unitMinute"></see>
    /// </summary>
    let unitMinute = Namespaced_IRI.parse _namespace_name "unitMinute" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#unitSecond"></see>
    /// </summary>
    let unitSecond = Namespaced_IRI.parse _namespace_name "unitSecond" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#unitWeek"></see>
    /// </summary>
    let unitWeek = Namespaced_IRI.parse _namespace_name "unitWeek" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#unitYear"></see>
    /// </summary>
    let unitYear = Namespaced_IRI.parse _namespace_name "unitYear" |> NamespacedName

    /// <summary>
    /// Value of DateTimeInterval expressed as a compact value.
    /// <see href="http://www.w3.org/2006/time#xsdDateTime"></see></summary>
    let xsdDateTime =
        Namespaced_IRI.parse _namespace_name "xsdDateTime" |> NamespacedName
