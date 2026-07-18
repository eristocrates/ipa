namespace http.reference.data.gov.uk.def.intervals.slash

open DoxAletheia.Rdf_Vocabulary

module intervals =
    let _namespace_name = "http://reference.data.gov.uk/def/intervals/"
    /// <summary>
    /// The month of April
    /// <see href="http://reference.data.gov.uk/def/intervals/April"></see></summary>
    let April = Namespaced_IRI.parse _namespace_name "April" |> NamespacedName

    /// <summary>
    /// A class for the months of a calendar year. A month of year is a recurring interval of about 12th of a year that re-occurs annually.
    /// <see href="http://reference.data.gov.uk/def/intervals/MonthOfYear"></see></summary>
    let MonthOfYear =
        Namespaced_IRI.parse _namespace_name "MonthOfYear" |> NamespacedName

    /// <summary>
    /// The month of August
    /// <see href="http://reference.data.gov.uk/def/intervals/August"></see></summary>
    let August = Namespaced_IRI.parse _namespace_name "August" |> NamespacedName

    /// <summary>
    /// A class for business half year intervals. These intervals are not necessarily calendar aligned with month boundaries.
    /// <see href="http://reference.data.gov.uk/def/intervals/BusinessHalf"></see></summary>
    let BusinessHalf =
        Namespaced_IRI.parse _namespace_name "BusinessHalf" |> NamespacedName

    /// <summary>
    /// A generic superclass for all half-year (6 month) like intervals
    /// <see href="http://reference.data.gov.uk/def/intervals/Half"></see></summary>
    let Half = Namespaced_IRI.parse _namespace_name "Half" |> NamespacedName

    /// <summary>
    /// A top-level class for business intervals
    /// <see href="http://reference.data.gov.uk/def/intervals/BusinessInterval"></see></summary>
    let BusinessInterval =
        Namespaced_IRI.parse _namespace_name "BusinessInterval" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/BusinessQuarter"></see>
    /// </summary>
    let BusinessQuarter =
        Namespaced_IRI.parse _namespace_name "BusinessQuarter" |> NamespacedName

    /// <summary>
    /// A generic superclass for all Quarter (3-month) long intervals
    /// <see href="http://reference.data.gov.uk/def/intervals/Quarter"></see></summary>
    let Quarter = Namespaced_IRI.parse _namespace_name "Quarter" |> NamespacedName

    /// <summary>
    /// A class for regular annual business reporting and planning intervals, not necessarily calendar aligned.
    /// <see href="http://reference.data.gov.uk/def/intervals/BusinessYear"></see></summary>
    let BusinessYear =
        Namespaced_IRI.parse _namespace_name "BusinessYear" |> NamespacedName

    /// <summary>
    /// A generic superclass for all manner of Year like intervals. The the cardinality of days in a year is set to between 351 and 380 because in the UK the end of a business reporting year must be within 7 days of an annual reference date. In the worst cases this allows a reporting interval to be shortened or extended by up to two weeks.
    /// <see href="http://reference.data.gov.uk/def/intervals/Year"></see></summary>
    let Year = Namespaced_IRI.parse _namespace_name "Year" |> NamespacedName

    /// <summary>
    /// A class for calendar aligned one day intervals, starting at 00:00 (midnight) on the relevant day. ISO 8601(E):2004 Section 2.2.6
    /// <see href="http://reference.data.gov.uk/def/intervals/CalendarDay"></see></summary>
    let CalendarDay =
        Namespaced_IRI.parse _namespace_name "CalendarDay" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/nextInterval"></see>
    /// </summary>
    let nextInterval =
        Namespaced_IRI.parse _namespace_name "nextInterval" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/previousInterval"></see>
    /// </summary>
    let previousInterval =
        Namespaced_IRI.parse _namespace_name "previousInterval" |> NamespacedName

    /// <summary>
    /// A class for all calendar aligned intervals.  The start of a given interval is aligned with the start of each of its first (temporally) subordinate CalendarInterval. Halfs are align the start of the first and seventh month of a year; quarters with the first, forth, seventh and tenth months; months with calendar months sof forth for calendar days, hours,minutes and seconds align
    /// <see href="http://reference.data.gov.uk/def/intervals/CalendarInterval"></see></summary>
    let CalendarInterval =
        Namespaced_IRI.parse _namespace_name "CalendarInterval" |> NamespacedName

    /// <summary>
    /// A generic superclass for all day like entities.
    /// <see href="http://reference.data.gov.uk/def/intervals/Day"></see></summary>
    let Day = Namespaced_IRI.parse _namespace_name "Day" |> NamespacedName

    /// <summary>
    /// A class for calendar aligned intervals that represent a calendar half year, a year being split into two half year periods of 6 months each.
    /// <see href="http://reference.data.gov.uk/def/intervals/CalendarHalf"></see></summary>
    let CalendarHalf =
        Namespaced_IRI.parse _namespace_name "CalendarHalf" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsMonth"></see>
    /// </summary>
    let intervalContainsMonth =
        Namespaced_IRI.parse _namespace_name "intervalContainsMonth" |> NamespacedName

    /// <summary>
    /// A class for calendar aligned hour-long intervals. ISO 8601(E):2004 Section 2.2.4
    /// <see href="http://reference.data.gov.uk/def/intervals/CalendarHour"></see></summary>
    let CalendarHour =
        Namespaced_IRI.parse _namespace_name "CalendarHour" |> NamespacedName

    /// <summary>
    /// A generic superclass for hour-long intervals. An hour may contain a positive or negative leap second (see http://en.wikipedia.org/wiki/Hour).
    /// <see href="http://reference.data.gov.uk/def/intervals/Hour"></see></summary>
    let Hour = Namespaced_IRI.parse _namespace_name "Hour" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/CalendarInstant"></see>
    /// </summary>
    let CalendarInstant =
        Namespaced_IRI.parse _namespace_name "CalendarInstant" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsHalf"></see>
    /// </summary>
    let intervalContainsHalf =
        Namespaced_IRI.parse _namespace_name "intervalContainsHalf" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsDay"></see>
    /// </summary>
    let intervalContainsDay =
        Namespaced_IRI.parse _namespace_name "intervalContainsDay" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsWeek"></see>
    /// </summary>
    let intervalContainsWeek =
        Namespaced_IRI.parse _namespace_name "intervalContainsWeek" |> NamespacedName

    /// <summary>
    /// A class for calendar weeks. Strictly not all calendar week intervals are contained within the year to which they may be attributed. The first or last week of a given calendar year may inculde days from the preceding or following calendar year respectively. An ISO 8601 week starts at 00:00:00 in a Monday and ends at the last moment of 23:59:59 on the following Sunday.  ISO 8601(E):2004 Section 2.2.8
    /// <see href="http://reference.data.gov.uk/def/intervals/Iso8601Week"></see></summary>
    let Iso8601Week =
        Namespaced_IRI.parse _namespace_name "Iso8601Week" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsSecond"></see>
    /// </summary>
    let intervalContainsSecond =
        Namespaced_IRI.parse _namespace_name "intervalContainsSecond" |> NamespacedName

    /// <summary>
    /// A class for calendar aligned one-second intervals. ISO 8601(E):2004 Section 2.2.1 (and 2.2.2 for leap seconds)(for units - 1 second interval are not defined).
    /// <see href="http://reference.data.gov.uk/def/intervals/CalendarSecond"></see></summary>
    let CalendarSecond =
        Namespaced_IRI.parse _namespace_name "CalendarSecond" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsHour"></see>
    /// </summary>
    let intervalContainsHour =
        Namespaced_IRI.parse _namespace_name "intervalContainsHour" |> NamespacedName

    /// <summary>
    /// A class for calendar aligned intervals of one calendar month.  ISO 8601(E):2004 Section 2.2.11
    /// <see href="http://reference.data.gov.uk/def/intervals/CalendarMonth"></see></summary>
    let CalendarMonth =
        Namespaced_IRI.parse _namespace_name "CalendarMonth" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsQuarter"></see>
    /// </summary>
    let intervalContainsQuarter =
        Namespaced_IRI.parse _namespace_name "intervalContainsQuarter" |> NamespacedName

    /// <summary>
    /// A class for calendar aligned one-quarter year (3 month) intervals
    /// <see href="http://reference.data.gov.uk/def/intervals/CalendarQuarter"></see></summary>
    let CalendarQuarter =
        Namespaced_IRI.parse _namespace_name "CalendarQuarter" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsMinute"></see>
    /// </summary>
    let intervalContainsMinute =
        Namespaced_IRI.parse _namespace_name "intervalContainsMinute" |> NamespacedName

    /// <summary>
    /// A class for calendar align one minute intervals. ISO 8601(E):2004 Section 2.2.3 (for units - 1 minute interval are not defined).
    /// <see href="http://reference.data.gov.uk/def/intervals/CalendarMinute"></see></summary>
    let CalendarMinute =
        Namespaced_IRI.parse _namespace_name "CalendarMinute" |> NamespacedName

    /// <summary>
    /// A generic superclass for all minute-long intervals. A minute may contain a positive or negative leap second.
    /// <see href="http://reference.data.gov.uk/def/intervals/Minute"></see></summary>
    let Minute = Namespaced_IRI.parse _namespace_name "Minute" |> NamespacedName
    /// <summary>
    /// A generic superclass class for all month-long like intervals.
    /// <see href="http://reference.data.gov.uk/def/intervals/Month"></see></summary>
    let Month = Namespaced_IRI.parse _namespace_name "Month" |> NamespacedName
    /// <summary>
    /// A generic superclass for all one-second long like intervals
    /// <see href="http://reference.data.gov.uk/def/intervals/Second"></see></summary>
    let Second = Namespaced_IRI.parse _namespace_name "Second" |> NamespacedName

    /// <summary>
    /// A class for calendar aligned intervals of one whole year, ie. year long intervals that are aligned with a Calendar.
    /// <see href="http://reference.data.gov.uk/def/intervals/CalendarYear"></see></summary>
    let CalendarYear =
        Namespaced_IRI.parse _namespace_name "CalendarYear" |> NamespacedName

    /// <summary>
    /// A duration of one day, typically 24 hours)
    /// <see href="http://reference.data.gov.uk/def/intervals/one-day"></see></summary>
    let ``one-day`` = Namespaced_IRI.parse _namespace_name "one-day" |> NamespacedName

    /// <summary>
    /// hasXsdDurationDescription: a data type property for associating an xsd:duration with an Interval. Inspired by "durationDescriptionDataType" mentioned in "http://www.w3.org/TR/owl-time" but which seems to have failed to make it into the formal ontology.
    /// <see href="http://reference.data.gov.uk/def/intervals/hasXsdDurationDescription"></see></summary>
    let hasXsdDurationDescription =
        Namespaced_IRI.parse _namespace_name "hasXsdDurationDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/Interval"></see>
    /// </summary>
    let Interval = Namespaced_IRI.parse _namespace_name "Interval" |> NamespacedName
    /// <summary>
    /// The month of December
    /// <see href="http://reference.data.gov.uk/def/intervals/December"></see></summary>
    let December = Namespaced_IRI.parse _namespace_name "December" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/DurationDescriptions"></see>
    /// </summary>
    let DurationDescriptions =
        Namespaced_IRI.parse _namespace_name "DurationDescriptions" |> NamespacedName

    /// <summary>
    /// The month of February
    /// <see href="http://reference.data.gov.uk/def/intervals/February"></see></summary>
    let February = Namespaced_IRI.parse _namespace_name "February" |> NamespacedName
    /// <summary>
    /// A class for intervals that the first half of a (nominally) annual cycle.
    /// <see href="http://reference.data.gov.uk/def/intervals/H1"></see></summary>
    let H1 = Namespaced_IRI.parse _namespace_name "H1" |> NamespacedName
    /// <summary>
    /// A class for intervals that the second half of a (nominally) annual cycle.
    /// <see href="http://reference.data.gov.uk/def/intervals/H2"></see></summary>
    let H2 = Namespaced_IRI.parse _namespace_name "H2" |> NamespacedName
    /// <summary>
    /// A class for 3rd half year intervals in an abnormally long annual interval - in the UK a buisness interval may exceptionally extent to 6 quarters.
    /// <see href="http://reference.data.gov.uk/def/intervals/H3"></see></summary>
    let H3 = Namespaced_IRI.parse _namespace_name "H3" |> NamespacedName
    /// <summary>
    /// A duration of one half year, typically 6 months
    /// <see href="http://reference.data.gov.uk/def/intervals/one-half"></see></summary>
    let ``one-half`` = Namespaced_IRI.parse _namespace_name "one-half" |> NamespacedName
    /// <summary>
    /// A duration of one hour
    /// <see href="http://reference.data.gov.uk/def/intervals/one-hour"></see></summary>
    let ``one-hour`` = Namespaced_IRI.parse _namespace_name "one-hour" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/IntervalList"></see>
    /// </summary>
    let IntervalList =
        Namespaced_IRI.parse _namespace_name "IntervalList" |> NamespacedName

    /// <summary>
    /// A business interval outside of the normal pattern of business intervals. In the UK companies house allow an annual reporting interval to be extended by upto 6 months once in 5 years (and at other exceptional times)
    /// <see href="http://reference.data.gov.uk/def/intervals/IrregularInterval"></see></summary>
    let IrregularInterval =
        Namespaced_IRI.parse _namespace_name "IrregularInterval" |> NamespacedName

    /// <summary>
    /// A generic superclass for all one-week long (7 day) intervals.
    /// <see href="http://reference.data.gov.uk/def/intervals/Week"></see></summary>
    let Week = Namespaced_IRI.parse _namespace_name "Week" |> NamespacedName
    /// <summary>
    /// The month of January
    /// <see href="http://reference.data.gov.uk/def/intervals/January"></see></summary>
    let January = Namespaced_IRI.parse _namespace_name "January" |> NamespacedName
    /// <summary>
    /// The month of July
    /// <see href="http://reference.data.gov.uk/def/intervals/July"></see></summary>
    let July = Namespaced_IRI.parse _namespace_name "July" |> NamespacedName
    /// <summary>
    /// The month of June
    /// <see href="http://reference.data.gov.uk/def/intervals/June"></see></summary>
    let June = Namespaced_IRI.parse _namespace_name "June" |> NamespacedName
    /// <summary>
    /// The month of March
    /// <see href="http://reference.data.gov.uk/def/intervals/March"></see></summary>
    let March = Namespaced_IRI.parse _namespace_name "March" |> NamespacedName
    /// <summary>
    /// The month of May
    /// <see href="http://reference.data.gov.uk/def/intervals/May"></see></summary>
    let May = Namespaced_IRI.parse _namespace_name "May" |> NamespacedName

    /// <summary>
    /// A duration of 1 minute
    /// <see href="http://reference.data.gov.uk/def/intervals/one-minute"></see></summary>
    let ``one-minute`` =
        Namespaced_IRI.parse _namespace_name "one-minute" |> NamespacedName

    /// <summary>
    /// A duration of one month
    /// <see href="http://reference.data.gov.uk/def/intervals/one-month"></see></summary>
    let ``one-month`` =
        Namespaced_IRI.parse _namespace_name "one-month" |> NamespacedName

    /// <summary>
    /// The month of September
    /// <see href="http://reference.data.gov.uk/def/intervals/September"></see></summary>
    let September = Namespaced_IRI.parse _namespace_name "September" |> NamespacedName
    /// <summary>
    /// The month of October
    /// <see href="http://reference.data.gov.uk/def/intervals/October"></see></summary>
    let October = Namespaced_IRI.parse _namespace_name "October" |> NamespacedName
    /// <summary>
    /// The month of Novermber
    /// <see href="http://reference.data.gov.uk/def/intervals/November"></see></summary>
    let November = Namespaced_IRI.parse _namespace_name "November" |> NamespacedName
    /// <summary>
    /// A class for intervals that are the first quarter of a (nominally) annual cycle.
    /// <see href="http://reference.data.gov.uk/def/intervals/Q1"></see></summary>
    let Q1 = Namespaced_IRI.parse _namespace_name "Q1" |> NamespacedName
    /// <summary>
    /// A class for intervals that are 2nd quarters of a (nominally) annual cycle
    /// <see href="http://reference.data.gov.uk/def/intervals/Q2"></see></summary>
    let Q2 = Namespaced_IRI.parse _namespace_name "Q2" |> NamespacedName
    /// <summary>
    /// A class for intervals that are 3rd quarters of a (nominally) annual cycle
    /// <see href="http://reference.data.gov.uk/def/intervals/Q3"></see></summary>
    let Q3 = Namespaced_IRI.parse _namespace_name "Q3" |> NamespacedName
    /// <summary>
    /// A class for intervals that are 4th quarters of a (nominally) annual cycle.
    /// <see href="http://reference.data.gov.uk/def/intervals/Q4"></see></summary>
    let Q4 = Namespaced_IRI.parse _namespace_name "Q4" |> NamespacedName
    /// <summary>
    /// A class for 5th quarters of an abnormally long annual interval - in the UK a buisness interval may exceptionally extent to 6 quarters.
    /// <see href="http://reference.data.gov.uk/def/intervals/Q5"></see></summary>
    let Q5 = Namespaced_IRI.parse _namespace_name "Q5" |> NamespacedName
    /// <summary>
    /// A class for 6th quarters of an abnormally long annual interval - in the UK a buisness interval may exceptionally extent to 6 quarters.
    /// <see href="http://reference.data.gov.uk/def/intervals/Q6"></see></summary>
    let Q6 = Namespaced_IRI.parse _namespace_name "Q6" |> NamespacedName

    /// <summary>
    /// A duration of one quarter, typically 3 months.
    /// <see href="http://reference.data.gov.uk/def/intervals/one-quarter"></see></summary>
    let ``one-quarter`` =
        Namespaced_IRI.parse _namespace_name "one-quarter" |> NamespacedName

    /// <summary>
    /// A duration of one second
    /// <see href="http://reference.data.gov.uk/def/intervals/one-second"></see></summary>
    let ``one-second`` =
        Namespaced_IRI.parse _namespace_name "one-second" |> NamespacedName

    /// <summary>
    /// A duration of one week
    /// <see href="http://reference.data.gov.uk/def/intervals/one-week"></see></summary>
    let ``one-week`` = Namespaced_IRI.parse _namespace_name "one-week" |> NamespacedName
    /// <summary>
    /// A duration of one year
    /// <see href="http://reference.data.gov.uk/def/intervals/one-year"></see></summary>
    let ``one-year`` = Namespaced_IRI.parse _namespace_name "one-year" |> NamespacedName
    /// <summary>
    /// The day of the week in which an instant or interval (of duration one day or less) occurs.
    /// <see href="http://reference.data.gov.uk/def/intervals/dayOfWeek"></see></summary>
    let dayOfWeek = Namespaced_IRI.parse _namespace_name "dayOfWeek" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsDays"></see>
    /// </summary>
    let intervalContainsDays =
        Namespaced_IRI.parse _namespace_name "intervalContainsDays" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsHalves"></see>
    /// </summary>
    let intervalContainsHalves =
        Namespaced_IRI.parse _namespace_name "intervalContainsHalves" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsHours"></see>
    /// </summary>
    let intervalContainsHours =
        Namespaced_IRI.parse _namespace_name "intervalContainsHours" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsIso8601Week"></see>
    /// </summary>
    let intervalContainsIso8601Week =
        Namespaced_IRI.parse _namespace_name "intervalContainsIso8601Week" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsMinutes"></see>
    /// </summary>
    let intervalContainsMinutes =
        Namespaced_IRI.parse _namespace_name "intervalContainsMinutes" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsMonths"></see>
    /// </summary>
    let intervalContainsMonths =
        Namespaced_IRI.parse _namespace_name "intervalContainsMonths" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsQuarters"></see>
    /// </summary>
    let intervalContainsQuarters =
        Namespaced_IRI.parse _namespace_name "intervalContainsQuarters" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/intervals/intervalContainsSeconds"></see>
    /// </summary>
    let intervalContainsSeconds =
        Namespaced_IRI.parse _namespace_name "intervalContainsSeconds" |> NamespacedName

    /// <summary>
    /// The month of the year in which a contained instant or interval (of duration one month or less) occurs.
    /// <see href="http://reference.data.gov.uk/def/intervals/monthOfYear"></see></summary>
    let monthOfYear =
        Namespaced_IRI.parse _namespace_name "monthOfYear" |> NamespacedName

    /// <summary>
    /// A reference to the companies house annual reference date at the end of the previous reporting year. Annual reporting periods are required to end with 7 days of this date. Success annual reference dates normally advance by 1 whole year each year. However, companies can always apply for an earlier reference date and under restricted circumstance request a later reference date (upto 6 months later) see http://www.companieshouse.gov.uk/about/gbhtml/gp2.shtml#ch2
    /// <see href="http://reference.data.gov.uk/def/intervals/nextAnnualReferenceDate"></see></summary>
    let nextAnnualReferenceDate =
        Namespaced_IRI.parse _namespace_name "nextAnnualReferenceDate" |> NamespacedName

    /// <summary>
    /// The ordinal number of the day of the month in in which an instant or interval (of duration less than one day) occurs. The first day of a month has the ordinal number 1.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalDayOfMonth"></see></summary>
    let ordinalDayOfMonth =
        Namespaced_IRI.parse _namespace_name "ordinalDayOfMonth" |> NamespacedName

    /// <summary>
    /// The ordinal number of the day of the week in which a (contained) instant or interval (of one day or less in duration) occurs. The Monday has an ordinal number of 1.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalDayOfWeek"></see></summary>
    let ordinalDayOfWeek =
        Namespaced_IRI.parse _namespace_name "ordinalDayOfWeek" |> NamespacedName

    /// <summary>
    /// The ordinal number of the day of the year in in which an instant or interval (of duration one day or less) occurs. The first day of a year has the ordinal number 1.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalDayOfYear"></see></summary>
    let ordinalDayOfYear =
        Namespaced_IRI.parse _namespace_name "ordinalDayOfYear" |> NamespacedName

    /// <summary>
    /// The ordinal number of the half of a year in which a contained instant or interval (of duration one half year or less) occurs. The first half of a year has the ordinal number 1.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalHalfOfYear"></see></summary>
    let ordinalHalfOfYear =
        Namespaced_IRI.parse _namespace_name "ordinalHalfOfYear" |> NamespacedName

    /// <summary>
    /// The ordinal number of the hour of day in which a (contained) instant or interval (of less than one hour duration) occurs. The first hour of a day has ordinal number 0.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalHourOfDay"></see></summary>
    let ordinalHourOfDay =
        Namespaced_IRI.parse _namespace_name "ordinalHourOfDay" |> NamespacedName

    /// <summary>
    /// The ordinal number of the minute of the hour in which a contained instant or interval (of duration one hour or less) occurs. The first minute of an hour has ordinal number 0.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalMinuteOfHour"></see></summary>
    let ordinalMinuteOfHour =
        Namespaced_IRI.parse _namespace_name "ordinalMinuteOfHour" |> NamespacedName

    /// <summary>
    /// The ordinal number of the month of the year in in which an instant or interval (of duration one day or less) occurs. The January has the ordinal number 1.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalMonthOfYear"></see></summary>
    let ordinalMonthOfYear =
        Namespaced_IRI.parse _namespace_name "ordinalMonthOfYear" |> NamespacedName

    /// <summary>
    /// The ordinal number of the quarter of the year in which a contained instant or interval (of duration one quarter year or less) occurs. The ordinal number of the first quarter of a year is 1.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalQuarterOfYear"></see></summary>
    let ordinalQuarterOfYear =
        Namespaced_IRI.parse _namespace_name "ordinalQuarterOfYear" |> NamespacedName

    /// <summary>
    /// The ordinal number of the second of the minute in which a contained instant or interval (of one second duration or less) occurs. The ordinal number of the first second of a minute is 0.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalSecondOfMinute"></see></summary>
    let ordinalSecondOfMinute =
        Namespaced_IRI.parse _namespace_name "ordinalSecondOfMinute" |> NamespacedName

    /// <summary>
    /// The ordinal number of the week of the year in which a contained instant or interval of one week duration or less occurs. The ordinal number of the first week of a year is 1. The first week of a year is the week that contains the first Thursday of the year.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalWeekOfYear"></see></summary>
    let ordinalWeekOfYear =
        Namespaced_IRI.parse _namespace_name "ordinalWeekOfYear" |> NamespacedName

    /// <summary>
    /// The ordinal number of the week of year year in which an instant or interval (of duration one week or less) occurs. The first year of the AD era has ordinal number 1.  The Week Of Year is the year to which a week of year pertains, which is usually the same as the calendar year except aorund the end of year where some days of the week may be deemed to be in the yearr following or the year previous depending on the alignment of the year boundary with the weekly cycle.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalWeekOfYearYear"></see></summary>
    let ordinalWeekOfYearYear =
        Namespaced_IRI.parse _namespace_name "ordinalWeekOfYearYear" |> NamespacedName

    /// <summary>
    /// The ordinal year of the year in which an instant or interval (of duration one year or less) occurs. The first year of the AD era has ordinal number 1.
    /// <see href="http://reference.data.gov.uk/def/intervals/ordinalYear"></see></summary>
    let ordinalYear =
        Namespaced_IRI.parse _namespace_name "ordinalYear" |> NamespacedName

    /// <summary>
    /// A reference to the companies house annual reference date at the end of the previous reporting year. Annual reporting periods are required to end with 7 days of this date. Success annual reference dates normally advance by 1 whole year each year. However, companies can always apply for an earlier reference date and under restricted circumstance request a later reference date (upto 6 months later) see http://www.companieshouse.gov.uk/about/gbhtml/gp2.shtml#ch2.
    /// <see href="http://reference.data.gov.uk/def/intervals/previousAnnualReferenceDate"></see></summary>
    let previousAnnualReferenceDate =
        Namespaced_IRI.parse _namespace_name "previousAnnualReferenceDate" |> NamespacedName
