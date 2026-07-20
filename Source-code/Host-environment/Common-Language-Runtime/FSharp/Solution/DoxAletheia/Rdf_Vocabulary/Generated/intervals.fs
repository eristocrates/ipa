namespace http.reference.data.gov.uk.def.intervals.slash

open DoxAletheia

module intervals =
    let _namespace_name = "http://reference.data.gov.uk/def/intervals/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The month of April
    /// <see href="http://reference.data.gov.uk/def/intervals/April"></see></summary>
    let April = _prefix "April"
    /// <summary>
    /// A class for the months of a calendar year. A month of year is a recurring interval of about 12th of a year that re-occurs annually.
    /// <see href="http://reference.data.gov.uk/def/intervals/MonthOfYear"></see></summary>
    let MonthOfYear = _prefix "MonthOfYear"
    /// <summary>
    /// The month of August
    /// <see href="http://reference.data.gov.uk/def/intervals/August"></see></summary>
    let August = _prefix "August"
    /// <summary>
    /// A class for business half year intervals. These intervals are not necessarily calendar aligned with month boundaries.
    /// <see href="http://reference.data.gov.uk/def/intervals/BusinessHalf"></see></summary>
    let BusinessHalf = _prefix "BusinessHalf"
    /// <summary>
    /// A generic superclass for all half-year (6 month) like intervals
    /// <see href="http://reference.data.gov.uk/def/intervals/Half"></see></summary>
    let Half = _prefix "Half"
    /// <summary>
    /// A top-level class for business intervals
    /// <see href="http://reference.data.gov.uk/def/intervals/BusinessInterval"></see></summary>
    let BusinessInterval = _prefix "BusinessInterval"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/BusinessQuarter"></see>
    /// </summary>
    let BusinessQuarter = _prefix "BusinessQuarter"
    /// <summary>
    /// A generic superclass for all Quarter (3-month) long intervals
    /// <see href="http://reference.data.gov.uk/def/intervals/Quarter"></see></summary>
    let Quarter = _prefix "Quarter"
    /// <summary>
    /// A class for regular annual business reporting and planning intervals, not necessarily calendar aligned.
    /// <see href="http://reference.data.gov.uk/def/intervals/BusinessYear"></see></summary>
    let BusinessYear = _prefix "BusinessYear"
    /// <summary>
    /// A generic superclass for all manner of Year like intervals. The the cardinality of days in a year is set to between 351 and 380 because in the UK the end of a business reporting year must be within 7 days of an annual reference date. In the worst cases this allows a reporting interval to be shortened or extended by up to two weeks.
    /// <see href="http://reference.data.gov.uk/def/intervals/Year"></see></summary>
    let Year = _prefix "Year"
    /// <summary>
    /// A class for calendar aligned one day intervals, starting at 00:00 (midnight) on the relevant day. ISO 8601(E):2004 Section 2.2.6
    /// <see href="http://reference.data.gov.uk/def/intervals/CalendarDay"></see></summary>
    let CalendarDay = _prefix "CalendarDay"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/nextInterval"></see>
    /// </summary>
    let nextInterval = _prefix "nextInterval"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/previousInterval"></see>
    /// </summary>
    let previousInterval = _prefix "previousInterval"
    /// <summary>
    /// A class for all calendar aligned intervals.  The start of a given interval is aligned with the start of each of its first (temporally) subordinate CalendarInterval. Halfs are align the start of the first and seventh month of a year; quarters with the first, forth, seventh and tenth months; months with calendar months sof forth for calendar days, hours,minutes and seconds align
    /// <see href="http://reference.data.gov.uk/def/intervals/CalendarInterval"></see></summary>
    let CalendarInterval = _prefix "CalendarInterval"
    /// <summary>
    /// A generic superclass for all day like entities.
    /// <see href="http://reference.data.gov.uk/def/intervals/Day"></see></summary>
    let Day = _prefix "Day"
    /// <summary>
    /// A class for calendar aligned intervals that represent a calendar half year, a year being split into two half year periods of 6 months each.
    /// <see href="http://reference.data.gov.uk/def/intervals/CalendarHalf"></see></summary>
    let CalendarHalf = _prefix "CalendarHalf"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsMonth"></see>
    /// </summary>
    let intervalContainsMonth = _prefix "intervalContainsMonth"
    /// <summary>
    /// A class for calendar aligned hour-long intervals. ISO 8601(E):2004 Section 2.2.4
    /// <see href="http://reference.data.gov.uk/def/intervals/CalendarHour"></see></summary>
    let CalendarHour = _prefix "CalendarHour"
    /// <summary>
    /// A generic superclass for hour-long intervals. An hour may contain a positive or negative leap second (see http://en.wikipedia.org/wiki/Hour).
    /// <see href="http://reference.data.gov.uk/def/intervals/Hour"></see></summary>
    let Hour = _prefix "Hour"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/CalendarInstant"></see>
    /// </summary>
    let CalendarInstant = _prefix "CalendarInstant"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsHalf"></see>
    /// </summary>
    let intervalContainsHalf = _prefix "intervalContainsHalf"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsDay"></see>
    /// </summary>
    let intervalContainsDay = _prefix "intervalContainsDay"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsWeek"></see>
    /// </summary>
    let intervalContainsWeek = _prefix "intervalContainsWeek"
    /// <summary>
    /// A class for calendar weeks. Strictly not all calendar week intervals are contained within the year to which they may be attributed. The first or last week of a given calendar year may inculde days from the preceding or following calendar year respectively. An ISO 8601 week starts at 00:00:00 in a Monday and ends at the last moment of 23:59:59 on the following Sunday.  ISO 8601(E):2004 Section 2.2.8
    /// <see href="http://reference.data.gov.uk/def/intervals/Iso8601Week"></see></summary>
    let Iso8601Week = _prefix "Iso8601Week"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsSecond"></see>
    /// </summary>
    let intervalContainsSecond = _prefix "intervalContainsSecond"
    /// <summary>
    /// A class for calendar aligned one-second intervals. ISO 8601(E):2004 Section 2.2.1 (and 2.2.2 for leap seconds)(for units - 1 second interval are not defined).
    /// <see href="http://reference.data.gov.uk/def/intervals/CalendarSecond"></see></summary>
    let CalendarSecond = _prefix "CalendarSecond"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsHour"></see>
    /// </summary>
    let intervalContainsHour = _prefix "intervalContainsHour"
    /// <summary>
    /// A class for calendar aligned intervals of one calendar month.  ISO 8601(E):2004 Section 2.2.11
    /// <see href="http://reference.data.gov.uk/def/intervals/CalendarMonth"></see></summary>
    let CalendarMonth = _prefix "CalendarMonth"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsQuarter"></see>
    /// </summary>
    let intervalContainsQuarter = _prefix "intervalContainsQuarter"
    /// <summary>
    /// A class for calendar aligned one-quarter year (3 month) intervals
    /// <see href="http://reference.data.gov.uk/def/intervals/CalendarQuarter"></see></summary>
    let CalendarQuarter = _prefix "CalendarQuarter"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsMinute"></see>
    /// </summary>
    let intervalContainsMinute = _prefix "intervalContainsMinute"
    /// <summary>
    /// A class for calendar align one minute intervals. ISO 8601(E):2004 Section 2.2.3 (for units - 1 minute interval are not defined).
    /// <see href="http://reference.data.gov.uk/def/intervals/CalendarMinute"></see></summary>
    let CalendarMinute = _prefix "CalendarMinute"
    /// <summary>
    /// A generic superclass for all minute-long intervals. A minute may contain a positive or negative leap second.
    /// <see href="http://reference.data.gov.uk/def/intervals/Minute"></see></summary>
    let Minute = _prefix "Minute"
    /// <summary>
    /// A generic superclass class for all month-long like intervals.
    /// <see href="http://reference.data.gov.uk/def/intervals/Month"></see></summary>
    let Month = _prefix "Month"
    /// <summary>
    /// A generic superclass for all one-second long like intervals
    /// <see href="http://reference.data.gov.uk/def/intervals/Second"></see></summary>
    let Second = _prefix "Second"
    /// <summary>
    /// A class for calendar aligned intervals of one whole year, ie. year long intervals that are aligned with a Calendar.
    /// <see href="http://reference.data.gov.uk/def/intervals/CalendarYear"></see></summary>
    let CalendarYear = _prefix "CalendarYear"
    /// <summary>
    /// A duration of one day, typically 24 hours)
    /// <see href="http://reference.data.gov.uk/def/intervals/one-day"></see></summary>
    let ``one-day`` = _prefix "one-day"
    /// <summary>
    /// hasXsdDurationDescription: a data type property for associating an xsd:duration with an Interval. Inspired by "durationDescriptionDataType" mentioned in "http://www.w3.org/TR/owl-time" but which seems to have failed to make it into the formal ontology.
    /// <see href="http://reference.data.gov.uk/def/intervals/hasXsdDurationDescription"></see></summary>
    let hasXsdDurationDescription = _prefix "hasXsdDurationDescription"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/Interval"></see>
    /// </summary>
    let Interval = _prefix "Interval"
    /// <summary>
    /// The month of December
    /// <see href="http://reference.data.gov.uk/def/intervals/December"></see></summary>
    let December = _prefix "December"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/DurationDescriptions"></see>
    /// </summary>
    let DurationDescriptions = _prefix "DurationDescriptions"
    /// <summary>
    /// The month of February
    /// <see href="http://reference.data.gov.uk/def/intervals/February"></see></summary>
    let February = _prefix "February"
    /// <summary>
    /// A class for intervals that the first half of a (nominally) annual cycle.
    /// <see href="http://reference.data.gov.uk/def/intervals/H1"></see></summary>
    let H1 = _prefix "H1"
    /// <summary>
    /// A class for intervals that the second half of a (nominally) annual cycle.
    /// <see href="http://reference.data.gov.uk/def/intervals/H2"></see></summary>
    let H2 = _prefix "H2"
    /// <summary>
    /// A class for 3rd half year intervals in an abnormally long annual interval - in the UK a buisness interval may exceptionally extent to 6 quarters.
    /// <see href="http://reference.data.gov.uk/def/intervals/H3"></see></summary>
    let H3 = _prefix "H3"
    /// <summary>
    /// A duration of one half year, typically 6 months
    /// <see href="http://reference.data.gov.uk/def/intervals/one-half"></see></summary>
    let ``one-half`` = _prefix "one-half"
    /// <summary>
    /// A duration of one hour
    /// <see href="http://reference.data.gov.uk/def/intervals/one-hour"></see></summary>
    let ``one-hour`` = _prefix "one-hour"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/IntervalList"></see>
    /// </summary>
    let IntervalList = _prefix "IntervalList"
    /// <summary>
    /// A business interval outside of the normal pattern of business intervals. In the UK companies house allow an annual reporting interval to be extended by upto 6 months once in 5 years (and at other exceptional times)
    /// <see href="http://reference.data.gov.uk/def/intervals/IrregularInterval"></see></summary>
    let IrregularInterval = _prefix "IrregularInterval"
    /// <summary>
    /// A generic superclass for all one-week long (7 day) intervals.
    /// <see href="http://reference.data.gov.uk/def/intervals/Week"></see></summary>
    let Week = _prefix "Week"
    /// <summary>
    /// The month of January
    /// <see href="http://reference.data.gov.uk/def/intervals/January"></see></summary>
    let January = _prefix "January"
    /// <summary>
    /// The month of July
    /// <see href="http://reference.data.gov.uk/def/intervals/July"></see></summary>
    let July = _prefix "July"
    /// <summary>
    /// The month of June
    /// <see href="http://reference.data.gov.uk/def/intervals/June"></see></summary>
    let June = _prefix "June"
    /// <summary>
    /// The month of March
    /// <see href="http://reference.data.gov.uk/def/intervals/March"></see></summary>
    let March = _prefix "March"
    /// <summary>
    /// The month of May
    /// <see href="http://reference.data.gov.uk/def/intervals/May"></see></summary>
    let May = _prefix "May"
    /// <summary>
    /// A duration of 1 minute
    /// <see href="http://reference.data.gov.uk/def/intervals/one-minute"></see></summary>
    let ``one-minute`` = _prefix "one-minute"
    /// <summary>
    /// A duration of one month
    /// <see href="http://reference.data.gov.uk/def/intervals/one-month"></see></summary>
    let ``one-month`` = _prefix "one-month"
    /// <summary>
    /// The month of September
    /// <see href="http://reference.data.gov.uk/def/intervals/September"></see></summary>
    let September = _prefix "September"
    /// <summary>
    /// The month of October
    /// <see href="http://reference.data.gov.uk/def/intervals/October"></see></summary>
    let October = _prefix "October"
    /// <summary>
    /// The month of Novermber
    /// <see href="http://reference.data.gov.uk/def/intervals/November"></see></summary>
    let November = _prefix "November"
    /// <summary>
    /// A class for intervals that are the first quarter of a (nominally) annual cycle.
    /// <see href="http://reference.data.gov.uk/def/intervals/Q1"></see></summary>
    let Q1 = _prefix "Q1"
    /// <summary>
    /// A class for intervals that are 2nd quarters of a (nominally) annual cycle
    /// <see href="http://reference.data.gov.uk/def/intervals/Q2"></see></summary>
    let Q2 = _prefix "Q2"
    /// <summary>
    /// A class for intervals that are 3rd quarters of a (nominally) annual cycle
    /// <see href="http://reference.data.gov.uk/def/intervals/Q3"></see></summary>
    let Q3 = _prefix "Q3"
    /// <summary>
    /// A class for intervals that are 4th quarters of a (nominally) annual cycle.
    /// <see href="http://reference.data.gov.uk/def/intervals/Q4"></see></summary>
    let Q4 = _prefix "Q4"
    /// <summary>
    /// A class for 5th quarters of an abnormally long annual interval - in the UK a buisness interval may exceptionally extent to 6 quarters.
    /// <see href="http://reference.data.gov.uk/def/intervals/Q5"></see></summary>
    let Q5 = _prefix "Q5"
    /// <summary>
    /// A class for 6th quarters of an abnormally long annual interval - in the UK a buisness interval may exceptionally extent to 6 quarters.
    /// <see href="http://reference.data.gov.uk/def/intervals/Q6"></see></summary>
    let Q6 = _prefix "Q6"
    /// <summary>
    /// A duration of one quarter, typically 3 months.
    /// <see href="http://reference.data.gov.uk/def/intervals/one-quarter"></see></summary>
    let ``one-quarter`` = _prefix "one-quarter"
    /// <summary>
    /// A duration of one second
    /// <see href="http://reference.data.gov.uk/def/intervals/one-second"></see></summary>
    let ``one-second`` = _prefix "one-second"
    /// <summary>
    /// A duration of one week
    /// <see href="http://reference.data.gov.uk/def/intervals/one-week"></see></summary>
    let ``one-week`` = _prefix "one-week"
    /// <summary>
    /// A duration of one year
    /// <see href="http://reference.data.gov.uk/def/intervals/one-year"></see></summary>
    let ``one-year`` = _prefix "one-year"
    /// <summary>
    /// The day of the week in which an instant or interval (of duration one day or less) occurs.
    /// <see href="http://reference.data.gov.uk/def/intervals/dayOfWeek"></see></summary>
    let dayOfWeek = _prefix "dayOfWeek"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsDays"></see>
    /// </summary>
    let intervalContainsDays = _prefix "intervalContainsDays"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsHalves"></see>
    /// </summary>
    let intervalContainsHalves = _prefix "intervalContainsHalves"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsHours"></see>
    /// </summary>
    let intervalContainsHours = _prefix "intervalContainsHours"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsIso8601Week"></see>
    /// </summary>
    let intervalContainsIso8601Week = _prefix "intervalContainsIso8601Week"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsMinutes"></see>
    /// </summary>
    let intervalContainsMinutes = _prefix "intervalContainsMinutes"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsMonths"></see>
    /// </summary>
    let intervalContainsMonths = _prefix "intervalContainsMonths"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsQuarters"></see>
    /// </summary>
    let intervalContainsQuarters = _prefix "intervalContainsQuarters"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsSeconds"></see>
    /// </summary>
    let intervalContainsSeconds = _prefix "intervalContainsSeconds"
    /// <summary>
    /// The month of the year in which a contained instant or interval (of duration one month or less) occurs.
    /// <see href="http://reference.data.gov.uk/def/intervals/monthOfYear"></see></summary>
    let monthOfYear = _prefix "monthOfYear"
    /// <summary>
    /// A reference to the companies house annual reference date at the end of the previous reporting year. Annual reporting periods are required to end with 7 days of this date. Success annual reference dates normally advance by 1 whole year each year. However, companies can always apply for an earlier reference date and under restricted circumstance request a later reference date (upto 6 months later) see http://www.companieshouse.gov.uk/about/gbhtml/gp2.shtml#ch2
    /// <see href="http://reference.data.gov.uk/def/intervals/nextAnnualReferenceDate"></see></summary>
    let nextAnnualReferenceDate = _prefix "nextAnnualReferenceDate"
    /// <summary>
    /// The ordinal number of the day of the month in in which an instant or interval (of duration less than one day) occurs. The first day of a month has the ordinal number 1.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalDayOfMonth"></see></summary>
    let ordinalDayOfMonth = _prefix "ordinalDayOfMonth"
    /// <summary>
    /// The ordinal number of the day of the week in which a (contained) instant or interval (of one day or less in duration) occurs. The Monday has an ordinal number of 1.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalDayOfWeek"></see></summary>
    let ordinalDayOfWeek = _prefix "ordinalDayOfWeek"
    /// <summary>
    /// The ordinal number of the day of the year in in which an instant or interval (of duration one day or less) occurs. The first day of a year has the ordinal number 1.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalDayOfYear"></see></summary>
    let ordinalDayOfYear = _prefix "ordinalDayOfYear"
    /// <summary>
    /// The ordinal number of the half of a year in which a contained instant or interval (of duration one half year or less) occurs. The first half of a year has the ordinal number 1.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalHalfOfYear"></see></summary>
    let ordinalHalfOfYear = _prefix "ordinalHalfOfYear"
    /// <summary>
    /// The ordinal number of the hour of day in which a (contained) instant or interval (of less than one hour duration) occurs. The first hour of a day has ordinal number 0.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalHourOfDay"></see></summary>
    let ordinalHourOfDay = _prefix "ordinalHourOfDay"
    /// <summary>
    /// The ordinal number of the minute of the hour in which a contained instant or interval (of duration one hour or less) occurs. The first minute of an hour has ordinal number 0.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalMinuteOfHour"></see></summary>
    let ordinalMinuteOfHour = _prefix "ordinalMinuteOfHour"
    /// <summary>
    /// The ordinal number of the month of the year in in which an instant or interval (of duration one day or less) occurs. The January has the ordinal number 1.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalMonthOfYear"></see></summary>
    let ordinalMonthOfYear = _prefix "ordinalMonthOfYear"
    /// <summary>
    /// The ordinal number of the quarter of the year in which a contained instant or interval (of duration one quarter year or less) occurs. The ordinal number of the first quarter of a year is 1.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalQuarterOfYear"></see></summary>
    let ordinalQuarterOfYear = _prefix "ordinalQuarterOfYear"
    /// <summary>
    /// The ordinal number of the second of the minute in which a contained instant or interval (of one second duration or less) occurs. The ordinal number of the first second of a minute is 0.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalSecondOfMinute"></see></summary>
    let ordinalSecondOfMinute = _prefix "ordinalSecondOfMinute"
    /// <summary>
    /// The ordinal number of the week of the year in which a contained instant or interval of one week duration or less occurs. The ordinal number of the first week of a year is 1. The first week of a year is the week that contains the first Thursday of the year.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalWeekOfYear"></see></summary>
    let ordinalWeekOfYear = _prefix "ordinalWeekOfYear"
    /// <summary>
    /// The ordinal number of the week of year year in which an instant or interval (of duration one week or less) occurs. The first year of the AD era has ordinal number 1.  The Week Of Year is the year to which a week of year pertains, which is usually the same as the calendar year except aorund the end of year where some days of the week may be deemed to be in the yearr following or the year previous depending on the alignment of the year boundary with the weekly cycle.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalWeekOfYearYear"></see></summary>
    let ordinalWeekOfYearYear = _prefix "ordinalWeekOfYearYear"
    /// <summary>
    /// The ordinal year of the year in which an instant or interval (of duration one year or less) occurs. The first year of the AD era has ordinal number 1.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalYear"></see></summary>
    let ordinalYear = _prefix "ordinalYear"
    /// <summary>
    /// A reference to the companies house annual reference date at the end of the previous reporting year. Annual reporting periods are required to end with 7 days of this date. Success annual reference dates normally advance by 1 whole year each year. However, companies can always apply for an earlier reference date and under restricted circumstance request a later reference date (upto 6 months later) see http://www.companieshouse.gov.uk/about/gbhtml/gp2.shtml#ch2.
    /// <see href="http://reference.data.gov.uk/def/intervals/previousAnnualReferenceDate"></see></summary>
    let previousAnnualReferenceDate = _prefix "previousAnnualReferenceDate"
