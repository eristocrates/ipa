#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module interval =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://reference.data.gov.uk/def/intervals/" "interval"

    let _namespaceIri = _prefixId.prefix ""
    let April = _prefixId.prefix "April"
    let August = _prefixId.prefix "August"
    /// <summary>
    ///   <para>skos:prefLabel : Half Year Interval</para>
    ///   <para>rdfs:label : Half Year Interval</para>
    ///   <para>rdfs:comment : A class for business half year intervals. These intervals are not necessarily calendar aligned with month boundaries.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/BusinessHalf">interval:BusinessHalf</a>
    /// </summary>
    let BusinessHalf = _prefixId.prefix "BusinessHalf"
    /// <summary>
    ///   <para>skos:prefLabel : Business Intervals</para>
    ///   <para>rdfs:label : Business Intervals</para>
    ///   <para>rdfs:comment : A top-level class for business intervals</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/BusinessInterval">interval:BusinessInterval</a>
    /// </summary>
    let BusinessInterval = _prefixId.prefix "BusinessInterval"
    let BusinessQuarter = _prefixId.prefix "BusinessQuarter"
    /// <summary>
    ///   <para>skos:prefLabel : Business Year</para>
    ///   <para>rdfs:label : Business Year</para>
    ///   <para>rdfs:comment : A class for regular annual business reporting and planning intervals, not necessarily calendar aligned.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/BusinessYear">interval:BusinessYear</a>
    /// </summary>
    let BusinessYear = _prefixId.prefix "BusinessYear"
    /// <summary>
    ///   <para>skos:prefLabel : Calendar Day</para>
    ///   <para>rdfs:label : Calendar Day</para>
    ///   <para>rdfs:comment : A class for calendar aligned one day intervals, starting at 00:00 (midnight) on the relevant day. ISO 8601(E):2004 Section 2.2.6</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/CalendarDay">interval:CalendarDay</a>
    /// </summary>
    let CalendarDay = _prefixId.prefix "CalendarDay"
    /// <summary>
    ///   <para>skos:prefLabel : CalendarHalf (class)</para>
    ///   <para>rdfs:label : CalendarHalf (class)</para>
    ///   <para>rdfs:comment : A class for calendar aligned intervals that represent a calendar half year, a year being split into two half year periods of 6 months each.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/CalendarHalf">interval:CalendarHalf</a>
    /// </summary>
    let CalendarHalf = _prefixId.prefix "CalendarHalf"
    /// <summary>
    ///   <para>skos:prefLabel : Calendar Hour (Class)</para>
    ///   <para>rdfs:label : Calendar Hour (Class)</para>
    ///   <para>rdfs:comment : A class for calendar aligned hour-long intervals. ISO 8601(E):2004 Section 2.2.4</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/CalendarHour">interval:CalendarHour</a>
    /// </summary>
    let CalendarHour = _prefixId.prefix "CalendarHour"
    let CalendarInstant = _prefixId.prefix "CalendarInstant"
    /// <summary>
    ///   <para>skos:prefLabel : CalendarInterval (class)</para>
    ///   <para>rdfs:label : CalendarInterval (class)</para>
    ///   <para>rdfs:comment : A class for all calendar aligned intervals.  The start of a given interval is aligned with the start of each of its first (temporally) subordinate CalendarInterval. Halfs are align the start of the first and seventh month of a year; quarters with the first, forth, seventh and tenth months; months with calendar months sof forth for calendar days, hours,minutes and seconds align </para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/CalendarInterval">interval:CalendarInterval</a>
    /// </summary>
    let CalendarInterval = _prefixId.prefix "CalendarInterval"
    /// <summary>
    ///   <para>skos:prefLabel : Calendar Minute</para>
    ///   <para>rdfs:label : Calendar Minute</para>
    ///   <para>rdfs:comment : A class for calendar align one minute intervals. ISO 8601(E):2004 Section 2.2.3 (for units - 1 minute interval are not defined).</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/CalendarMinute">interval:CalendarMinute</a>
    /// </summary>
    let CalendarMinute = _prefixId.prefix "CalendarMinute"
    /// <summary>
    ///   <para>skos:prefLabel : Calendar Month</para>
    ///   <para>rdfs:label : Calendar Month</para>
    ///   <para>rdfs:comment : A class for calendar aligned intervals of one calendar month.  ISO 8601(E):2004 Section 2.2.11</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/CalendarMonth">interval:CalendarMonth</a>
    /// </summary>
    let CalendarMonth = _prefixId.prefix "CalendarMonth"
    /// <summary>
    ///   <para>skos:prefLabel : Calendar Quarter</para>
    ///   <para>rdfs:label : Calendar Quarter</para>
    ///   <para>rdfs:comment : A class for calendar aligned one-quarter year (3 month) intervals</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/CalendarQuarter">interval:CalendarQuarter</a>
    /// </summary>
    let CalendarQuarter = _prefixId.prefix "CalendarQuarter"
    /// <summary>
    ///   <para>skos:prefLabel : Calendar Second</para>
    ///   <para>rdfs:label : Calendar Second</para>
    ///   <para>rdfs:comment : A class for calendar aligned one-second intervals. ISO 8601(E):2004 Section 2.2.1 (and 2.2.2 for leap seconds)(for units - 1 second interval are not defined).</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/CalendarSecond">interval:CalendarSecond</a>
    /// </summary>
    let CalendarSecond = _prefixId.prefix "CalendarSecond"
    /// <summary>
    ///   <para>rdfs:comment : A class for calendar aligned intervals of one whole year, ie. year long intervals that are aligned with a Calendar.</para>
    ///   <para>skos:prefLabel : Calendar Year</para>
    ///   <para>rdfs:label : Calendar Year</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/CalendarYear">interval:CalendarYear</a>
    /// </summary>
    let CalendarYear = _prefixId.prefix "CalendarYear"
    /// <summary>
    ///   <para>skos:prefLabel : Generic Day (Class)</para>
    ///   <para>rdfs:label : Generic Day (Class)</para>
    ///   <para>rdfs:comment : A generic superclass for all day like entities.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/Day">interval:Day</a>
    /// </summary>
    let Day = _prefixId.prefix "Day"
    let December = _prefixId.prefix "December"
    let DurationDescriptions = _prefixId.prefix "DurationDescriptions"
    let February = _prefixId.prefix "February"
    /// <summary>
    ///   <para>skos:prefLabel : H1 Interval</para>
    ///   <para>rdfs:label : H1 Interval</para>
    ///   <para>rdfs:comment : A class for intervals that the first half of a (nominally) annual cycle.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/H1">interval:H1</a>
    /// </summary>
    let H1 = _prefixId.prefix "H1"
    /// <summary>
    ///   <para>skos:prefLabel : H2 Interval</para>
    ///   <para>rdfs:label : H2 Interval</para>
    ///   <para>rdfs:comment : A class for intervals that the second half of a (nominally) annual cycle.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/H2">interval:H2</a>
    /// </summary>
    let H2 = _prefixId.prefix "H2"
    /// <summary>
    ///   <para>skos:prefLabel : H3 Interval</para>
    ///   <para>rdfs:label : H3 Interval</para>
    ///   <para>rdfs:comment : A class for 3rd half year intervals in an abnormally long annual interval - in the UK a buisness interval may exceptionally extent to 6 quarters.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/H3">interval:H3</a>
    /// </summary>
    let H3 = _prefixId.prefix "H3"
    /// <summary>
    ///   <para>rdfs:label : Generic Half (Class)</para>
    ///   <para>rdfs:comment : A generic superclass for all half-year (6 month) like intervals</para>
    ///   <para>skos:prefLabel : Generic Half (Class)</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/Half">interval:Half</a>
    /// </summary>
    let Half = _prefixId.prefix "Half"
    /// <summary>
    ///   <para>rdfs:label : Generic Hour (class)</para>
    ///   <para>rdfs:comment : A generic superclass for hour-long intervals. An hour may contain a positive or negative leap second (see http://en.wikipedia.org/wiki/Hour).</para>
    ///   <para>skos:prefLabel : Generic Hour (class)</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/Hour">interval:Hour</a>
    /// </summary>
    let Hour = _prefixId.prefix "Hour"
    let Interval = _prefixId.prefix "Interval"
    let IntervalList = _prefixId.prefix "IntervalList"
    /// <summary>
    ///   <para>skos:prefLabel : Irregular Business interval</para>
    ///   <para>rdfs:label : Irregular Business interval</para>
    ///   <para>rdfs:comment : A business interval outside of the normal pattern of business intervals. In the UK companies house allow an annual reporting interval to be extended by upto 6 months once in 5 years (and at other exceptional times)</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/IrregularInterval">interval:IrregularInterval</a>
    /// </summary>
    let IrregularInterval = _prefixId.prefix "IrregularInterval"
    /// <summary>
    ///   <para>rdfs:label : Calendar Week</para>
    ///   <para>skos:prefLabel : ISO 8601 Week</para>
    ///   <para>rdfs:comment : A class for calendar weeks. Strictly not all calendar week intervals are contained within the year to which they may be attributed. The first or last week of a given calendar year may inculde days from the preceding or following calendar year respectively. An ISO 8601 week starts at 00:00:00 in a Monday and ends at the last moment of 23:59:59 on the following Sunday.  ISO 8601(E):2004 Section 2.2.8</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/Iso8601Week">interval:Iso8601Week</a>
    /// </summary>
    let Iso8601Week = _prefixId.prefix "Iso8601Week"
    let January = _prefixId.prefix "January"
    let July = _prefixId.prefix "July"
    let June = _prefixId.prefix "June"
    let March = _prefixId.prefix "March"
    let May = _prefixId.prefix "May"
    /// <summary>
    ///   <para>rdfs:comment : A generic superclass for all minute-long intervals. A minute may contain a positive or negative leap second.</para>
    ///   <para>skos:prefLabel : Generic Minute (Class)</para>
    ///   <para>rdfs:label : Generic Minute (Class)</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/Minute">interval:Minute</a>
    /// </summary>
    let Minute = _prefixId.prefix "Minute"
    /// <summary>
    ///   <para>skos:prefLabel : Generic Month (Class)</para>
    ///   <para>rdfs:label : Generic Month (Class)</para>
    ///   <para>rdfs:comment : A generic superclass class for all month-long like intervals.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/Month">interval:Month</a>
    /// </summary>
    let Month = _prefixId.prefix "Month"
    /// <summary>
    ///   <para>skos:prefLabel : month of year</para>
    ///   <para>rdfs:label : month of year</para>
    ///   <para>rdfs:comment : A class for the months of a calendar year. A month of year is a recurring interval of about 12th of a year that re-occurs annually.^^xsd:string</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/MonthOfYear">interval:MonthOfYear</a>
    /// </summary>
    let MonthOfYear = _prefixId.prefix "MonthOfYear"
    let November = _prefixId.prefix "November"
    let October = _prefixId.prefix "October"
    /// <summary>
    ///   <para>skos:prefLabel : Q1 Interval</para>
    ///   <para>rdfs:label : Q1 Interval</para>
    ///   <para>rdfs:comment : A class for intervals that are the first quarter of a (nominally) annual cycle.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/Q1">interval:Q1</a>
    /// </summary>
    let Q1 = _prefixId.prefix "Q1"
    /// <summary>
    ///   <para>skos:prefLabel : Q2 Interval</para>
    ///   <para>rdfs:label : Q2 Interval</para>
    ///   <para>rdfs:comment : A class for intervals that are 2nd quarters of a (nominally) annual cycle</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/Q2">interval:Q2</a>
    /// </summary>
    let Q2 = _prefixId.prefix "Q2"
    /// <summary>
    ///   <para>skos:prefLabel : Q3 Interval</para>
    ///   <para>rdfs:label : Q3 Interval</para>
    ///   <para>rdfs:comment : A class for intervals that are 3rd quarters of a (nominally) annual cycle</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/Q3">interval:Q3</a>
    /// </summary>
    let Q3 = _prefixId.prefix "Q3"
    /// <summary>
    ///   <para>skos:prefLabel : Q4 Interval</para>
    ///   <para>rdfs:label : Q4 Interval</para>
    ///   <para>rdfs:comment : A class for intervals that are 4th quarters of a (nominally) annual cycle.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/Q4">interval:Q4</a>
    /// </summary>
    let Q4 = _prefixId.prefix "Q4"
    /// <summary>
    ///   <para>skos:prefLabel : Q5 Interval</para>
    ///   <para>rdfs:label : Q5 Interval</para>
    ///   <para>rdfs:comment : A class for 5th quarters of an abnormally long annual interval - in the UK a buisness interval may exceptionally extent to 6 quarters.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/Q5">interval:Q5</a>
    /// </summary>
    let Q5 = _prefixId.prefix "Q5"
    /// <summary>
    ///   <para>skos:prefLabel : Q6 Interval</para>
    ///   <para>rdfs:label : Q6 Interval</para>
    ///   <para>rdfs:comment : A class for 6th quarters of an abnormally long annual interval - in the UK a buisness interval may exceptionally extent to 6 quarters.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/Q6">interval:Q6</a>
    /// </summary>
    let Q6 = _prefixId.prefix "Q6"
    /// <summary>
    ///   <para>skos:prefLabel : Generic Quarter (Class)</para>
    ///   <para>rdfs:label : Generic Quarter (Class)</para>
    ///   <para>rdfs:comment : A generic superclass for all Quarter (3-month) long intervals</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/Quarter">interval:Quarter</a>
    /// </summary>
    let Quarter = _prefixId.prefix "Quarter"
    /// <summary>
    ///   <para>skos:prefLabel : Generic Second (Class)</para>
    ///   <para>rdfs:label : Generic Second (Class)</para>
    ///   <para>rdfs:comment : A generic superclass for all one-second long like intervals</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/Second">interval:Second</a>
    /// </summary>
    let Second = _prefixId.prefix "Second"
    let September = _prefixId.prefix "September"
    /// <summary>
    ///   <para>rdfs:comment : A generic superclass for all one-week long (7 day) intervals.</para>
    ///   <para>skos:prefLabel : Generice Week (Class)</para>
    ///   <para>rdfs:label : Generic Week (Class)</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/Week">interval:Week</a>
    /// </summary>
    let Week = _prefixId.prefix "Week"
    /// <summary>
    ///   <para>rdfs:comment : A generic superclass for all manner of Year like intervals. The the cardinality of days in a year is set to between 351 and 380 because in the UK the end of a business reporting year must be within 7 days of an annual reference date. In the worst cases this allows a reporting interval to be shortened or extended by up to two weeks.</para>
    ///   <para>rdfs:label : Generic Year (Class)</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/Year">interval:Year</a>
    /// </summary>
    let Year = _prefixId.prefix "Year"
    /// <summary>
    ///   <para>skos:prefLabel : day of week</para>
    ///   <para>rdfs:label : day of week</para>
    ///   <para>rdfs:comment : The day of the week in which an instant or interval (of duration one day or less) occurs.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/dayOfWeek">interval:dayOfWeek</a>
    /// </summary>
    let dayOfWeek = _prefixId.prefix "dayOfWeek"
    /// <summary>
    ///   <para>rdfs:label : hasXsdDurationDescription (DataTypeProperty)</para>
    ///   <para>rdfs:comment : hasXsdDurationDescription: a data type property for associating an xsd:duration with an Interval. Inspired by "durationDescriptionDataType" mentioned in "http://www.w3.org/TR/owl-time" but which seems to have failed to make it into the formal ontology.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/hasXsdDurationDescription">interval:hasXsdDurationDescription</a>
    /// </summary>
    let hasXsdDurationDescription = _prefixId.prefix "hasXsdDurationDescription"
    let intervalContainsDay = _prefixId.prefix "intervalContainsDay"
    let intervalContainsDays = _prefixId.prefix "intervalContainsDays"
    let intervalContainsHalf = _prefixId.prefix "intervalContainsHalf"
    let intervalContainsHalves = _prefixId.prefix "intervalContainsHalves"
    let intervalContainsHour = _prefixId.prefix "intervalContainsHour"
    let intervalContainsHours = _prefixId.prefix "intervalContainsHours"
    let intervalContainsIso8601Week = _prefixId.prefix "intervalContainsIso8601Week"
    let intervalContainsMinute = _prefixId.prefix "intervalContainsMinute"
    let intervalContainsMinutes = _prefixId.prefix "intervalContainsMinutes"
    let intervalContainsMonth = _prefixId.prefix "intervalContainsMonth"
    let intervalContainsMonths = _prefixId.prefix "intervalContainsMonths"
    let intervalContainsQuarter = _prefixId.prefix "intervalContainsQuarter"
    let intervalContainsQuarters = _prefixId.prefix "intervalContainsQuarters"
    let intervalContainsSecond = _prefixId.prefix "intervalContainsSecond"
    let intervalContainsSeconds = _prefixId.prefix "intervalContainsSeconds"
    let intervalContainsWeek = _prefixId.prefix "intervalContainsWeek"
    /// <summary>
    ///   <para>skos:prefLabel : month of year</para>
    ///   <para>rdfs:label : month of year</para>
    ///   <para>rdfs:comment : The month of the year in which a contained instant or interval (of duration one month or less) occurs.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/monthOfYear">interval:monthOfYear</a>
    /// </summary>
    let monthOfYear = _prefixId.prefix "monthOfYear"
    let nextAnnualReferenceDate = _prefixId.prefix "nextAnnualReferenceDate"
    let nextInterval = _prefixId.prefix "nextInterval"
    let one_day = _prefixId.prefix "one-day"
    let one_half = _prefixId.prefix "one-half"
    let one_hour = _prefixId.prefix "one-hour"
    let one_minute = _prefixId.prefix "one-minute"
    let one_month = _prefixId.prefix "one-month"
    let one_quarter = _prefixId.prefix "one-quarter"
    let one_second = _prefixId.prefix "one-second"
    let one_week = _prefixId.prefix "one-week"
    let one_year = _prefixId.prefix "one-year"
    /// <summary>
    ///   <para>skos:prefLabel : ordinal day of month</para>
    ///   <para>rdfs:label : ordinal day of month</para>
    ///   <para>rdfs:comment : The ordinal number of the day of the month in in which an instant or interval (of duration less than one day) occurs. The first day of a month has the ordinal number 1.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/ordinalDayOfMonth">interval:ordinalDayOfMonth</a>
    /// </summary>
    let ordinalDayOfMonth = _prefixId.prefix "ordinalDayOfMonth"
    /// <summary>
    ///   <para>skos:prefLabel : ordinal day of week {en}^^xsd:string</para>
    ///   <para>rdfs:label : ordinal day of week {en}^^xsd:string</para>
    ///   <para>rdfs:comment : The ordinal number of the day of the week in which a (contained) instant or interval (of one day or less in duration) occurs. The Monday has an ordinal number of 1.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/ordinalDayOfWeek">interval:ordinalDayOfWeek</a>
    /// </summary>
    let ordinalDayOfWeek = _prefixId.prefix "ordinalDayOfWeek"
    /// <summary>
    ///   <para>skos:prefLabel : ordinal day of month</para>
    ///   <para>rdfs:label : ordinal day of month</para>
    ///   <para>rdfs:comment : The ordinal number of the day of the year in in which an instant or interval (of duration one day or less) occurs. The first day of a year has the ordinal number 1.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/ordinalDayOfYear">interval:ordinalDayOfYear</a>
    /// </summary>
    let ordinalDayOfYear = _prefixId.prefix "ordinalDayOfYear"
    /// <summary>
    ///   <para>skos:prefLabel : has half of year</para>
    ///   <para>rdfs:label : has half of year</para>
    ///   <para>rdfs:comment : The ordinal number of the half of a year in which a contained instant or interval (of duration one half year or less) occurs. The first half of a year has the ordinal number 1.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/ordinalHalfOfYear">interval:ordinalHalfOfYear</a>
    /// </summary>
    let ordinalHalfOfYear = _prefixId.prefix "ordinalHalfOfYear"
    /// <summary>
    ///   <para>skos:prefLabel : ordinal hour of day</para>
    ///   <para>rdfs:label : ordinal hour of day^^xsd:string</para>
    ///   <para>rdfs:comment : The ordinal number of the hour of day in which a (contained) instant or interval (of less than one hour duration) occurs. The first hour of a day has ordinal number 0.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/ordinalHourOfDay">interval:ordinalHourOfDay</a>
    /// </summary>
    let ordinalHourOfDay = _prefixId.prefix "ordinalHourOfDay"
    /// <summary>
    ///   <para>skos:prefLabel : ordinal minute of hour</para>
    ///   <para>rdfs:label : ordinal minute of hour</para>
    ///   <para>rdfs:comment : The ordinal number of the minute of the hour in which a contained instant or interval (of duration one hour or less) occurs. The first minute of an hour has ordinal number 0.^^xsd:string</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/ordinalMinuteOfHour">interval:ordinalMinuteOfHour</a>
    /// </summary>
    let ordinalMinuteOfHour = _prefixId.prefix "ordinalMinuteOfHour"
    /// <summary>
    ///   <para>skos:prefLabel : ordinal month of year</para>
    ///   <para>rdfs:label : ordinal month of year</para>
    ///   <para>rdfs:comment : The ordinal number of the month of the year in in which an instant or interval (of duration one day or less) occurs. The January has the ordinal number 1.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/ordinalMonthOfYear">interval:ordinalMonthOfYear</a>
    /// </summary>
    let ordinalMonthOfYear = _prefixId.prefix "ordinalMonthOfYear"
    /// <summary>
    ///   <para>skos:prefLabel : ordinal quarter of year</para>
    ///   <para>rdfs:label : ordinal quarter of year</para>
    ///   <para>rdfs:comment : The ordinal number of the quarter of the year in which a contained instant or interval (of duration one quarter year or less) occurs. The ordinal number of the first quarter of a year is 1.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/ordinalQuarterOfYear">interval:ordinalQuarterOfYear</a>
    /// </summary>
    let ordinalQuarterOfYear = _prefixId.prefix "ordinalQuarterOfYear"
    /// <summary>
    ///   <para>skos:prefLabel : ordinal second of minute</para>
    ///   <para>rdfs:label : ordinal second of minute</para>
    ///   <para>rdfs:comment : The ordinal number of the second of the minute in which a contained instant or interval (of one second duration or less) occurs. The ordinal number of the first second of a minute is 0.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/ordinalSecondOfMinute">interval:ordinalSecondOfMinute</a>
    /// </summary>
    let ordinalSecondOfMinute = _prefixId.prefix "ordinalSecondOfMinute"
    /// <summary>
    ///   <para>skos:prefLabel : ordinal week of year</para>
    ///   <para>rdfs:label : ordinal week of year</para>
    ///   <para>rdfs:comment : The ordinal number of the week of the year in which a contained instant or interval of one week duration or less occurs. The ordinal number of the first week of a year is 1. The first week of a year is the week that contains the first Thursday of the year.^^xsd:string</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/ordinalWeekOfYear">interval:ordinalWeekOfYear</a>
    /// </summary>
    let ordinalWeekOfYear = _prefixId.prefix "ordinalWeekOfYear"
    /// <summary>
    ///   <para>skos:prefLabel : ordinal week of year year</para>
    ///   <para>rdfs:label : ordinal week of year year</para>
    ///   <para>rdfs:comment : The ordinal number of the week of year year in which an instant or interval (of duration one week or less) occurs. The first year of the AD era has ordinal number 1.  The Week Of Year is the year to which a week of year pertains, which is usually the same as the calendar year except aorund the end of year where some days of the week may be deemed to be in the yearr following or the year previous depending on the alignment of the year boundary with the weekly cycle.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/ordinalWeekOfYearYear">interval:ordinalWeekOfYearYear</a>
    /// </summary>
    let ordinalWeekOfYearYear = _prefixId.prefix "ordinalWeekOfYearYear"
    /// <summary>
    ///   <para>skos:prefLabel : ordinal year</para>
    ///   <para>rdfs:label : ordinal year</para>
    ///   <para>rdfs:comment : The ordinal year of the year in which an instant or interval (of duration one year or less) occurs. The first year of the AD era has ordinal number 1.</para>
    ///   <a href="http://reference.data.gov.uk/def/intervals/ordinalYear">interval:ordinalYear</a>
    /// </summary>
    let ordinalYear = _prefixId.prefix "ordinalYear"
    let previousAnnualReferenceDate = _prefixId.prefix "previousAnnualReferenceDate"
    let previousInterval = _prefixId.prefix "previousInterval"
