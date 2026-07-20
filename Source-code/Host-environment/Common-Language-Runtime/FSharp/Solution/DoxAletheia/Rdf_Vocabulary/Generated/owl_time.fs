namespace http.www.w3.org._2006.time.hash

open DoxAletheia

module owl_time =
    let _namespace_name = "http://www.w3.org/2006/time#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#2006"></see>
    /// </summary>
    let _2006 = _prefix "2006"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#2016"></see>
    /// </summary>
    let _2016 = _prefix "2016"
    /// <summary>
    /// Description of date and time structured with separate values for the various elements of a calendar-clock system. The temporal reference system is fixed to Gregorian Calendar, and the range of year, month, day properties restricted to corresponding XML Schema types xsd:gYear, xsd:gMonth and xsd:gDay, respectively.
    /// <see href="http://www.w3.org/2006/time#DateTimeDescription"></see></summary>
    let DateTimeDescription = _prefix "DateTimeDescription"
    /// <summary>
    /// The temporal reference system used by a temporal position or extent description.
    /// <see href="http://www.w3.org/2006/time#hasTRS"></see></summary>
    let hasTRS = _prefix "hasTRS"
    /// <summary>
    /// Year position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar year from any calendar.
    /// <see href="http://www.w3.org/2006/time#year"></see></summary>
    let year = _prefix "year"
    /// <summary>
    /// Month position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar month from any calendar.
    /// <see href="http://www.w3.org/2006/time#month"></see></summary>
    let month = _prefix "month"
    /// <summary>
    /// Day position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar day from any calendar.
    /// <see href="http://www.w3.org/2006/time#day"></see></summary>
    let day = _prefix "day"
    /// <summary>
    /// Description of date and time structured with separate values for the various elements of a calendar-clock system
    /// <see href="http://www.w3.org/2006/time#GeneralDateTimeDescription"></see></summary>
    let GeneralDateTimeDescription = _prefix "GeneralDateTimeDescription"
    /// <summary>
    /// DateTimeInterval is a subclass of ProperInterval, defined using the multi-element DateTimeDescription.
    /// <see href="http://www.w3.org/2006/time#DateTimeInterval"></see></summary>
    let DateTimeInterval = _prefix "DateTimeInterval"
    /// <summary>
    /// A temporal entity with non-zero extent or duration, i.e. for which the value of the beginning and end are different
    /// <see href="http://www.w3.org/2006/time#ProperInterval"></see></summary>
    let ProperInterval = _prefix "ProperInterval"
    /// <summary>
    /// The day of week
    /// <see href="http://www.w3.org/2006/time#DayOfWeek"></see></summary>
    let DayOfWeek = _prefix "DayOfWeek"
    /// <summary>
    /// Duration of a temporal extent expressed as a number scaled by a temporal unit
    /// <see href="http://www.w3.org/2006/time#Duration"></see></summary>
    let Duration = _prefix "Duration"
    /// <summary>
    /// The temporal unit which provides the precision of a date-time value or scale of a temporal extent
    /// <see href="http://www.w3.org/2006/time#unitType"></see></summary>
    let unitType = _prefix "unitType"
    /// <summary>
    /// Value of a temporal extent expressed as a decimal number scaled by a temporal unit
    /// <see href="http://www.w3.org/2006/time#numericDuration"></see></summary>
    let numericDuration = _prefix "numericDuration"
    /// <summary>
    /// Time extent; duration of a time interval separate from its particular start position
    /// <see href="http://www.w3.org/2006/time#TemporalDuration"></see></summary>
    let TemporalDuration = _prefix "TemporalDuration"
    /// <summary>
    /// Description of temporal extent structured with separate values for the various elements of a calendar-clock system. The temporal reference system is fixed to Gregorian Calendar, and the range of each of the numeric properties is restricted to xsd:decimal
    /// <see href="http://www.w3.org/2006/time#DurationDescription"></see></summary>
    let DurationDescription = _prefix "DurationDescription"
    /// <summary>
    /// Description of temporal extent structured with separate values for the various elements of a calendar-clock system.
    /// <see href="http://www.w3.org/2006/time#GeneralDurationDescription"></see></summary>
    let GeneralDurationDescription = _prefix "GeneralDurationDescription"
    /// <summary>
    /// length of, or element of the length of, a temporal extent expressed in months
    /// <see href="http://www.w3.org/2006/time#months"></see></summary>
    let months = _prefix "months"
    /// <summary>
    /// length of, or element of the length of, a temporal extent expressed in weeks
    /// <see href="http://www.w3.org/2006/time#weeks"></see></summary>
    let weeks = _prefix "weeks"
    /// <summary>
    /// length of, or element of the length of, a temporal extent expressed in days
    /// <see href="http://www.w3.org/2006/time#days"></see></summary>
    let days = _prefix "days"
    /// <summary>
    /// length of, or element of the length of, a temporal extent expressed in hours
    /// <see href="http://www.w3.org/2006/time#hours"></see></summary>
    let hours = _prefix "hours"
    /// <summary>
    /// length of, or element of the length of, a temporal extent expressed in seconds
    /// <see href="http://www.w3.org/2006/time#seconds"></see></summary>
    let seconds = _prefix "seconds"
    /// <summary>
    /// length, or element of, a temporal extent expressed in minutes
    /// <see href="http://www.w3.org/2006/time#minutes"></see></summary>
    let minutes = _prefix "minutes"
    /// <summary>
    /// length of, or element of the length of, a temporal extent expressed in years
    /// <see href="http://www.w3.org/2006/time#years"></see></summary>
    let years = _prefix "years"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#Friday"></see>
    /// </summary>
    let Friday = _prefix "Friday"
    /// <summary>
    /// The day of week, whose value is a member of the class time:DayOfWeek
    /// <see href="http://www.w3.org/2006/time#dayOfWeek"></see></summary>
    let dayOfWeek = _prefix "dayOfWeek"
    /// <summary>
    /// The time zone for clock elements in the temporal position
    /// <see href="http://www.w3.org/2006/time#timeZone"></see></summary>
    let timeZone = _prefix "timeZone"
    /// <summary>
    /// Minute position in a calendar-clock system.
    /// <see href="http://www.w3.org/2006/time#minute"></see></summary>
    let minute = _prefix "minute"
    /// <summary>
    /// Hour position in a calendar-clock system.
    /// <see href="http://www.w3.org/2006/time#hour"></see></summary>
    let hour = _prefix "hour"
    /// <summary>
    /// Week number within the year.
    /// <see href="http://www.w3.org/2006/time#week"></see></summary>
    let week = _prefix "week"
    /// <summary>
    /// A position on a time-line
    /// <see href="http://www.w3.org/2006/time#TemporalPosition"></see></summary>
    let TemporalPosition = _prefix "TemporalPosition"
    /// <summary>
    /// The month of the year, whose value is a member of the class time:MonthOfYear
    /// <see href="http://www.w3.org/2006/time#monthOfYear"></see></summary>
    let monthOfYear = _prefix "monthOfYear"
    /// <summary>
    /// Second position in a calendar-clock system.
    /// <see href="http://www.w3.org/2006/time#second"></see></summary>
    let second = _prefix "second"
    /// <summary>
    /// The number of the day within the year
    /// <see href="http://www.w3.org/2006/time#dayOfYear"></see></summary>
    let dayOfYear = _prefix "dayOfYear"
    /// <summary>
    /// A temporal entity with zero extent or duration
    /// <see href="http://www.w3.org/2006/time#Instant"></see></summary>
    let Instant = _prefix "Instant"
    /// <summary>
    /// A temporal interval or instant.
    /// <see href="http://www.w3.org/2006/time#TemporalEntity"></see></summary>
    let TemporalEntity = _prefix "TemporalEntity"
    /// <summary>
    /// A temporal entity with an extent or duration
    /// <see href="http://www.w3.org/2006/time#Interval"></see></summary>
    let Interval = _prefix "Interval"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#January"></see>
    /// </summary>
    let January = _prefix "January"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#unitMonth"></see>
    /// </summary>
    let unitMonth = _prefix "unitMonth"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#Monday"></see>
    /// </summary>
    let Monday = _prefix "Monday"
    /// <summary>
    /// The month of the year
    /// <see href="http://www.w3.org/2006/time#MonthOfYear"></see></summary>
    let MonthOfYear = _prefix "MonthOfYear"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#Saturday"></see>
    /// </summary>
    let Saturday = _prefix "Saturday"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#Sunday"></see>
    /// </summary>
    let Sunday = _prefix "Sunday"
    /// <summary>
    /// A temporal reference system, such as a temporal coordinate system (with an origin, direction, and scale), a calendar-clock combination, or a (possibly hierarchical) ordinal system.
    ///
    /// This is a stub class, representing the set of all temporal reference systems.
    /// <see href="http://www.w3.org/2006/time#TRS"></see></summary>
    let TRS = _prefix "TRS"
    /// <summary>
    /// A standard duration, which provides a scale factor for a time extent, or the granularity or precision for a time position.
    /// <see href="http://www.w3.org/2006/time#TemporalUnit"></see></summary>
    let TemporalUnit = _prefix "TemporalUnit"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#Thursday"></see>
    /// </summary>
    let Thursday = _prefix "Thursday"
    /// <summary>
    /// A temporal position described using either a (nominal) value from an ordinal reference system, or a (numeric) value in a temporal coordinate system.
    /// <see href="http://www.w3.org/2006/time#TimePosition"></see></summary>
    let TimePosition = _prefix "TimePosition"
    /// <summary>
    /// The (numeric) value indicating position within a temporal coordinate system
    /// <see href="http://www.w3.org/2006/time#numericPosition"></see></summary>
    let numericPosition = _prefix "numericPosition"
    /// <summary>
    /// The (nominal) value indicating temporal position in an ordinal reference system
    /// <see href="http://www.w3.org/2006/time#nominalPosition"></see></summary>
    let nominalPosition = _prefix "nominalPosition"
    /// <summary>
    /// A Time Zone specifies the amount by which the local time is offset from UTC.
    /// 	A time zone is usually denoted geographically (e.g. Australian Eastern Daylight Time), with a constant value in a given region.
    /// The region where it applies and the offset from UTC are specified by a locally recognised governing authority.
    /// <see href="http://www.w3.org/2006/time#TimeZone"></see></summary>
    let TimeZone = _prefix "TimeZone"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#Tuesday"></see>
    /// </summary>
    let Tuesday = _prefix "Tuesday"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#Wednesday"></see>
    /// </summary>
    let Wednesday = _prefix "Wednesday"
    /// <summary>
    /// Year duration
    /// <see href="http://www.w3.org/2006/time#Year"></see></summary>
    let Year = _prefix "Year"
    /// <summary>
    /// Gives directionality to time. If a temporal entity T1 is after another temporal entity T2, then the beginning of T1 is after the end of T2.
    /// <see href="http://www.w3.org/2006/time#after"></see></summary>
    let after = _prefix "after"
    /// <summary>
    /// Gives directionality to time. If a temporal entity T1 is before another temporal entity T2, then the end of T1 is before the beginning of T2. Thus, "before" can be considered to be basic to instants and derived for intervals.
    /// <see href="http://www.w3.org/2006/time#before"></see></summary>
    let before = _prefix "before"
    /// <summary>
    /// Day of month - formulated as a text string with a pattern constraint to reproduce the same lexical form as gDay, except that values up to 99 are permitted, in order to support calendars with more than 31 days in a month.
    /// Note that the value-space is not defined, so a generic OWL2 processor cannot compute ordering relationships of values of this type.
    /// <see href="http://www.w3.org/2006/time#generalDay"></see></summary>
    let generalDay = _prefix "generalDay"
    /// <summary>
    /// Month of year - formulated as a text string with a pattern constraint to reproduce the same lexical form as gMonth, except that values up to 20 are permitted, in order to support calendars with more than 12 months in the year.
    /// Note that the value-space is not defined, so a generic OWL2 processor cannot compute ordering relationships of values of this type.
    /// <see href="http://www.w3.org/2006/time#generalMonth"></see></summary>
    let generalMonth = _prefix "generalMonth"
    /// <summary>
    /// Year number - formulated as a text string with a pattern constraint to reproduce the same lexical form as gYear, but not restricted to values from the Gregorian calendar.
    /// Note that the value-space is not defined, so a generic OWL2 processor cannot compute ordering relationships of values of this type.
    /// <see href="http://www.w3.org/2006/time#generalYear"></see></summary>
    let generalYear = _prefix "generalYear"
    /// <summary>
    /// Beginning of a temporal entity
    /// <see href="http://www.w3.org/2006/time#hasBeginning"></see></summary>
    let hasBeginning = _prefix "hasBeginning"
    /// <summary>
    /// Supports the association of a temporal entity (instant or interval) to any thing
    /// <see href="http://www.w3.org/2006/time#hasTime"></see></summary>
    let hasTime = _prefix "hasTime"
    /// <summary>
    /// Value of DateTimeInterval expressed as a structured value. The beginning and end of the interval coincide with the limits of the shortest element in the description.
    /// <see href="http://www.w3.org/2006/time#hasDateTimeDescription"></see></summary>
    let hasDateTimeDescription = _prefix "hasDateTimeDescription"
    /// <summary>
    /// Duration of a temporal entity, expressed as a scaled value or nominal value
    /// <see href="http://www.w3.org/2006/time#hasDuration"></see></summary>
    let hasDuration = _prefix "hasDuration"
    /// <summary>
    /// Duration of a temporal entity.
    /// <see href="http://www.w3.org/2006/time#hasTemporalDuration"></see></summary>
    let hasTemporalDuration = _prefix "hasTemporalDuration"
    /// <summary>
    /// Duration of a temporal entity, expressed using a structured description
    /// <see href="http://www.w3.org/2006/time#hasDurationDescription"></see></summary>
    let hasDurationDescription = _prefix "hasDurationDescription"
    /// <summary>
    /// End of a temporal entity.
    /// <see href="http://www.w3.org/2006/time#hasEnd"></see></summary>
    let hasEnd = _prefix "hasEnd"
    /// <summary>
    /// Extent of a temporal entity, expressed using xsd:duration
    /// <see href="http://www.w3.org/2006/time#hasXSDDuration"></see></summary>
    let hasXSDDuration = _prefix "hasXSDDuration"
    /// <summary>
    /// Position of an instant, expressed using a structured description
    /// <see href="http://www.w3.org/2006/time#inDateTime"></see></summary>
    let inDateTime = _prefix "inDateTime"
    /// <summary>
    /// Position of a time instant
    /// <see href="http://www.w3.org/2006/time#inTemporalPosition"></see></summary>
    let inTemporalPosition = _prefix "inTemporalPosition"
    /// <summary>
    /// Position of an instant, expressed as a temporal coordinate or nominal value
    /// <see href="http://www.w3.org/2006/time#inTimePosition"></see></summary>
    let inTimePosition = _prefix "inTimePosition"
    /// <summary>
    /// Position of an instant, expressed using xsd:date
    /// <see href="http://www.w3.org/2006/time#inXSDDate"></see></summary>
    let inXSDDate = _prefix "inXSDDate"
    /// <summary>
    /// Position of an instant, expressed using xsd:dateTime
    /// <see href="http://www.w3.org/2006/time#inXSDDateTime"></see></summary>
    let inXSDDateTime = _prefix "inXSDDateTime"
    /// <summary>
    /// Position of an instant, expressed using xsd:dateTimeStamp
    /// <see href="http://www.w3.org/2006/time#inXSDDateTimeStamp"></see></summary>
    let inXSDDateTimeStamp = _prefix "inXSDDateTimeStamp"
    /// <summary>
    /// Position of an instant, expressed using xsd:gYear
    /// <see href="http://www.w3.org/2006/time#inXSDgYear"></see></summary>
    let inXSDgYear = _prefix "inXSDgYear"
    /// <summary>
    /// Position of an instant, expressed using xsd:gYearMonth
    /// <see href="http://www.w3.org/2006/time#inXSDgYearMonth"></see></summary>
    let inXSDgYearMonth = _prefix "inXSDgYearMonth"
    /// <summary>
    /// An instant that falls inside the interval. It is not intended to include beginnings and ends of intervals.
    /// <see href="http://www.w3.org/2006/time#inside"></see></summary>
    let inside = _prefix "inside"
    /// <summary>
    /// If a proper interval T1 is intervalAfter another proper interval T2, then the beginning of T1 is after the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalAfter"></see></summary>
    let intervalAfter = _prefix "intervalAfter"
    /// <summary>
    /// If a proper interval T1 is intervalDisjoint another proper interval T2, then the beginning of T1 is after the end of T2, or the end of T1 is before the beginning of T2, i.e. the intervals do not overlap in any way, but their ordering relationship is not known.
    /// <see href="http://www.w3.org/2006/time#intervalDisjoint"></see></summary>
    let intervalDisjoint = _prefix "intervalDisjoint"
    /// <summary>
    /// If a proper interval T1 is intervalBefore another proper interval T2, then the end of T1 is before the beginning of T2.
    /// <see href="http://www.w3.org/2006/time#intervalBefore"></see></summary>
    let intervalBefore = _prefix "intervalBefore"
    /// <summary>
    /// If a proper interval T1 is intervalContains another proper interval T2, then the beginning of T1 is before the beginning of T2, and the end of T1 is after the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalContains"></see></summary>
    let intervalContains = _prefix "intervalContains"
    /// <summary>
    /// If a proper interval T1 is intervalDuring another proper interval T2, then the beginning of T1 is after the beginning of T2, and the end of T1 is before the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalDuring"></see></summary>
    let intervalDuring = _prefix "intervalDuring"
    /// <summary>
    /// If a proper interval T1 is intervalIn another proper interval T2, then the beginning of T1 is after the beginning of T2 or is coincident with the beginning of T2, and the end of T1 is before the end of T2, or is coincident with the end of T2, except that end of T1 may not be coincident with the end of T2 if the beginning of T1 is coincident with the beginning of T2.
    /// <see href="http://www.w3.org/2006/time#intervalIn"></see></summary>
    let intervalIn = _prefix "intervalIn"
    /// <summary>
    /// If a proper interval T1 is intervalEquals another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is coincident with the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalEquals"></see></summary>
    let intervalEquals = _prefix "intervalEquals"
    /// <summary>
    /// If a proper interval T1 is intervalFinishedBy another proper interval T2, then the beginning of T1 is before the beginning of T2, and the end of T1 is coincident with the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalFinishedBy"></see></summary>
    let intervalFinishedBy = _prefix "intervalFinishedBy"
    /// <summary>
    /// If a proper interval T1 is intervalFinishes another proper interval T2, then the beginning of T1 is after the beginning of T2, and the end of T1 is coincident with the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalFinishes"></see></summary>
    let intervalFinishes = _prefix "intervalFinishes"
    /// <summary>
    /// If a proper interval T1 is intervalMeets another proper interval T2, then the end of T1 is coincident with the beginning of T2.
    /// <see href="http://www.w3.org/2006/time#intervalMeets"></see></summary>
    let intervalMeets = _prefix "intervalMeets"
    /// <summary>
    /// If a proper interval T1 is intervalMetBy another proper interval T2, then the beginning of T1 is coincident with the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalMetBy"></see></summary>
    let intervalMetBy = _prefix "intervalMetBy"
    /// <summary>
    /// If a proper interval T1 is intervalOverlappedBy another proper interval T2, then the beginning of T1 is after the beginning of T2, the beginning of T1 is before the end of T2, and the end of T1 is after the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalOverlappedBy"></see></summary>
    let intervalOverlappedBy = _prefix "intervalOverlappedBy"
    /// <summary>
    /// If a proper interval T1 is intervalOverlaps another proper interval T2, then the beginning of T1 is before the beginning of T2, the end of T1 is after the beginning of T2, and the end of T1 is before the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalOverlaps"></see></summary>
    let intervalOverlaps = _prefix "intervalOverlaps"
    /// <summary>
    /// If a proper interval T1 is intervalStarted another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is after the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalStartedBy"></see></summary>
    let intervalStartedBy = _prefix "intervalStartedBy"
    /// <summary>
    /// If a proper interval T1 is intervalStarts another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is before the end of T2.
    /// <see href="http://www.w3.org/2006/time#intervalStarts"></see></summary>
    let intervalStarts = _prefix "intervalStarts"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#unitDay"></see>
    /// </summary>
    let unitDay = _prefix "unitDay"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#unitHour"></see>
    /// </summary>
    let unitHour = _prefix "unitHour"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#unitMinute"></see>
    /// </summary>
    let unitMinute = _prefix "unitMinute"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#unitSecond"></see>
    /// </summary>
    let unitSecond = _prefix "unitSecond"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#unitWeek"></see>
    /// </summary>
    let unitWeek = _prefix "unitWeek"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/time#unitYear"></see>
    /// </summary>
    let unitYear = _prefix "unitYear"
    /// <summary>
    /// Value of DateTimeInterval expressed as a compact value.
    /// <see href="http://www.w3.org/2006/time#xsdDateTime"></see></summary>
    let xsdDateTime = _prefix "xsdDateTime"
