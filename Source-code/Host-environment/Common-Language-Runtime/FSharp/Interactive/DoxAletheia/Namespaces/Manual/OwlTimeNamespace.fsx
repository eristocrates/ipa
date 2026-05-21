#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RDFErgonomics.fsx"
open RDFErgonomics

module owl_time =

    let _prefix = prefix_label "owl_time"







    /// Description of date and time structured with separate values for the various elements of a calendar-clock system. The temporal reference system is fixed to Gregorian Calendar, and the range of year, month, day properties restricted to corresponding XML Schema types xsd:gYear, xsd:gMonth and xsd:gDay, respectively.
    let DateTimeDescription = _prefix "DateTimeDescription"


    /// DateTimeInterval is a subclass of ProperInterval, defined using the multi-element DateTimeDescription.
    let DateTimeInterval = _prefix "DateTimeInterval"


    /// The day of week
    let DayOfWeek = _prefix "DayOfWeek"


    /// Duration of a temporal extent expressed as a number scaled by a temporal unit
    let Duration = _prefix "Duration"


    /// Description of temporal extent structured with separate values for the various elements of a calendar-clock system. The temporal reference system is fixed to Gregorian Calendar, and the range of each of the numeric properties is restricted to xsd:decimal
    let DurationDescription = _prefix "DurationDescription"



    let Friday = _prefix "Friday"


    /// Description of date and time structured with separate values for the various elements of a calendar-clock system
    let GeneralDateTimeDescription = _prefix "GeneralDateTimeDescription"


    /// Description of temporal extent structured with separate values for the various elements of a calendar-clock system.
    let GeneralDurationDescription = _prefix "GeneralDurationDescription"


    /// A temporal entity with zero extent or duration
    let Instant = _prefix "Instant"


    /// A temporal entity with an extent or duration
    let Interval = _prefix "Interval"



    let January = _prefix "January"



    let Monday = _prefix "Monday"


    /// The month of the year
    let MonthOfYear = _prefix "MonthOfYear"


    /// A temporal entity with non-zero extent or duration, i.e. for which the value of the beginning and end are different
    let ProperInterval = _prefix "ProperInterval"



    let Saturday = _prefix "Saturday"



    let Sunday = _prefix "Sunday"


    /// A temporal reference system, such as a temporal coordinate system (with an origin, direction, and scale), a calendar-clock combination, or a (possibly hierarchical) ordinal system.
    ///
    /// This is a stub class, representing the set of all temporal reference systems.
    let TRS = _prefix "TRS"


    /// Time extent; duration of a time interval separate from its particular start position
    let TemporalDuration = _prefix "TemporalDuration"


    /// A temporal interval or instant.
    let TemporalEntity = _prefix "TemporalEntity"


    /// A position on a time-line
    let TemporalPosition = _prefix "TemporalPosition"


    /// A standard duration, which provides a scale factor for a time extent, or the granularity or precision for a time position.
    let TemporalUnit = _prefix "TemporalUnit"



    let Thursday = _prefix "Thursday"


    /// A temporal position described using either a (nominal) value from an ordinal reference system, or a (numeric) value in a temporal coordinate system.
    let TimePosition = _prefix "TimePosition"


    /// A Time Zone specifies the amount by which the local time is offset from UTC.
    /// 	A time zone is usually denoted geographically (e.g. Australian Eastern Daylight Time), with a constant value in a given region.
    /// The region where it applies and the offset from UTC are specified by a locally recognised governing authority.
    let TimeZone = _prefix "TimeZone"



    let Tuesday = _prefix "Tuesday"



    let Wednesday = _prefix "Wednesday"


    /// Year duration
    let Year = _prefix "Year"


    /// Gives directionality to time. If a temporal entity T1 is after another temporal entity T2, then the beginning of T1 is after the end of T2.
    let after = _prefix "after"


    /// Gives directionality to time. If a temporal entity T1 is before another temporal entity T2, then the end of T1 is before the beginning of T2. Thus, "before" can be considered to be basic to instants and derived for intervals.
    let before = _prefix "before"


    /// Day position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar day from any calendar.
    let day = _prefix "day"


    /// The day of week, whose value is a member of the class time:DayOfWeek
    let dayOfWeek = _prefix "dayOfWeek"


    /// The number of the day within the year
    let dayOfYear = _prefix "dayOfYear"


    /// length of, or element of the length of, a temporal extent expressed in days
    let days = _prefix "days"


    /// Day of month - formulated as a text string with a pattern constraint to reproduce the same lexical form as gDay, except that values up to 99 are permitted, in order to support calendars with more than 31 days in a month.
    /// Note that the value-space is not defined, so a generic OWL2 processor cannot compute ordering relationships of values of this type.
    let generalDay = _prefix "generalDay"


    /// Month of year - formulated as a text string with a pattern constraint to reproduce the same lexical form as gMonth, except that values up to 20 are permitted, in order to support calendars with more than 12 months in the year.
    /// Note that the value-space is not defined, so a generic OWL2 processor cannot compute ordering relationships of values of this type.
    let generalMonth = _prefix "generalMonth"


    /// Year number - formulated as a text string with a pattern constraint to reproduce the same lexical form as gYear, but not restricted to values from the Gregorian calendar.
    /// Note that the value-space is not defined, so a generic OWL2 processor cannot compute ordering relationships of values of this type.
    let generalYear = _prefix "generalYear"


    /// Beginning of a temporal entity
    let hasBeginning = _prefix "hasBeginning"


    /// Value of DateTimeInterval expressed as a structured value. The beginning and end of the interval coincide with the limits of the shortest element in the description.
    let hasDateTimeDescription = _prefix "hasDateTimeDescription"


    /// Duration of a temporal entity, expressed as a scaled value or nominal value
    let hasDuration = _prefix "hasDuration"


    /// Duration of a temporal entity, expressed using a structured description
    let hasDurationDescription = _prefix "hasDurationDescription"


    /// End of a temporal entity.
    let hasEnd = _prefix "hasEnd"


    /// The temporal reference system used by a temporal position or extent description.
    let hasTRS = _prefix "hasTRS"


    /// Duration of a temporal entity.
    let hasTemporalDuration = _prefix "hasTemporalDuration"


    /// Supports the association of a temporal entity (instant or interval) to any thing
    let hasTime = _prefix "hasTime"


    /// Extent of a temporal entity, expressed using xsd:duration
    let hasXSDDuration = _prefix "hasXSDDuration"


    /// Hour position in a calendar-clock system.
    let hour = _prefix "hour"


    /// length of, or element of the length of, a temporal extent expressed in hours
    let hours = _prefix "hours"


    /// Position of an instant, expressed using a structured description
    let inDateTime = _prefix "inDateTime"


    /// Position of a time instant
    let inTemporalPosition = _prefix "inTemporalPosition"


    /// Position of an instant, expressed as a temporal coordinate or nominal value
    let inTimePosition = _prefix "inTimePosition"


    /// Position of an instant, expressed using xsd:date
    let inXSDDate = _prefix "inXSDDate"


    /// Position of an instant, expressed using xsd:dateTime
    let inXSDDateTime = _prefix "inXSDDateTime"


    /// Position of an instant, expressed using xsd:dateTimeStamp
    let inXSDDateTimeStamp = _prefix "inXSDDateTimeStamp"


    /// Position of an instant, expressed using xsd:gYear
    let inXSDgYear = _prefix "inXSDgYear"


    /// Position of an instant, expressed using xsd:gYearMonth
    let inXSDgYearMonth = _prefix "inXSDgYearMonth"


    /// An instant that falls inside the interval. It is not intended to include beginnings and ends of intervals.
    let inside = _prefix "inside"


    /// If a proper interval T1 is intervalAfter another proper interval T2, then the beginning of T1 is after the end of T2.
    let intervalAfter = _prefix "intervalAfter"


    /// If a proper interval T1 is intervalBefore another proper interval T2, then the end of T1 is before the beginning of T2.
    let intervalBefore = _prefix "intervalBefore"


    /// If a proper interval T1 is intervalContains another proper interval T2, then the beginning of T1 is before the beginning of T2, and the end of T1 is after the end of T2.
    let intervalContains = _prefix "intervalContains"


    /// If a proper interval T1 is intervalDisjoint another proper interval T2, then the beginning of T1 is after the end of T2, or the end of T1 is before the beginning of T2, i.e. the intervals do not overlap in any way, but their ordering relationship is not known.
    let intervalDisjoint = _prefix "intervalDisjoint"


    /// If a proper interval T1 is intervalDuring another proper interval T2, then the beginning of T1 is after the beginning of T2, and the end of T1 is before the end of T2.
    let intervalDuring = _prefix "intervalDuring"


    /// If a proper interval T1 is intervalEquals another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is coincident with the end of T2.
    let intervalEquals = _prefix "intervalEquals"


    /// If a proper interval T1 is intervalFinishedBy another proper interval T2, then the beginning of T1 is before the beginning of T2, and the end of T1 is coincident with the end of T2.
    let intervalFinishedBy = _prefix "intervalFinishedBy"


    /// If a proper interval T1 is intervalFinishes another proper interval T2, then the beginning of T1 is after the beginning of T2, and the end of T1 is coincident with the end of T2.
    let intervalFinishes = _prefix "intervalFinishes"


    /// If a proper interval T1 is intervalIn another proper interval T2, then the beginning of T1 is after the beginning of T2 or is coincident with the beginning of T2, and the end of T1 is before the end of T2, or is coincident with the end of T2, except that end of T1 may not be coincident with the end of T2 if the beginning of T1 is coincident with the beginning of T2.
    let intervalIn = _prefix "intervalIn"


    /// If a proper interval T1 is intervalMeets another proper interval T2, then the end of T1 is coincident with the beginning of T2.
    let intervalMeets = _prefix "intervalMeets"


    /// If a proper interval T1 is intervalMetBy another proper interval T2, then the beginning of T1 is coincident with the end of T2.
    let intervalMetBy = _prefix "intervalMetBy"


    /// If a proper interval T1 is intervalOverlappedBy another proper interval T2, then the beginning of T1 is after the beginning of T2, the beginning of T1 is before the end of T2, and the end of T1 is after the end of T2.
    let intervalOverlappedBy = _prefix "intervalOverlappedBy"


    /// If a proper interval T1 is intervalOverlaps another proper interval T2, then the beginning of T1 is before the beginning of T2, the end of T1 is after the beginning of T2, and the end of T1 is before the end of T2.
    let intervalOverlaps = _prefix "intervalOverlaps"


    /// If a proper interval T1 is intervalStarted another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is after the end of T2.
    let intervalStartedBy = _prefix "intervalStartedBy"


    /// If a proper interval T1 is intervalStarts another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is before the end of T2.
    let intervalStarts = _prefix "intervalStarts"


    /// Minute position in a calendar-clock system.
    let minute = _prefix "minute"


    /// length, or element of, a temporal extent expressed in minutes
    let minutes = _prefix "minutes"


    /// Month position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar month from any calendar.
    let month = _prefix "month"


    /// The month of the year, whose value is a member of the class time:MonthOfYear
    let monthOfYear = _prefix "monthOfYear"


    /// length of, or element of the length of, a temporal extent expressed in months
    let months = _prefix "months"


    /// The (nominal) value indicating temporal position in an ordinal reference system
    let nominalPosition = _prefix "nominalPosition"


    /// Value of a temporal extent expressed as a decimal number scaled by a temporal unit
    let numericDuration = _prefix "numericDuration"


    /// The (numeric) value indicating position within a temporal coordinate system
    let numericPosition = _prefix "numericPosition"


    /// Second position in a calendar-clock system.
    let second = _prefix "second"


    /// length of, or element of the length of, a temporal extent expressed in seconds
    let seconds = _prefix "seconds"


    /// The time zone for clock elements in the temporal position
    let timeZone = _prefix "timeZone"



    let unitDay = _prefix "unitDay"



    let unitHour = _prefix "unitHour"



    let unitMinute = _prefix "unitMinute"



    let unitMonth = _prefix "unitMonth"



    let unitSecond = _prefix "unitSecond"


    /// The temporal unit which provides the precision of a date-time value or scale of a temporal extent
    let unitType = _prefix "unitType"



    let unitWeek = _prefix "unitWeek"



    let unitYear = _prefix "unitYear"


    /// Week number within the year.
    let week = _prefix "week"


    /// length of, or element of the length of, a temporal extent expressed in weeks
    let weeks = _prefix "weeks"


    /// Value of DateTimeInterval expressed as a compact value.
    let xsdDateTime = _prefix "xsdDateTime"


    /// Year position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar year from any calendar.
    let year = _prefix "year"


    /// length of, or element of the length of, a temporal extent expressed in years
    let years = _prefix "years"
