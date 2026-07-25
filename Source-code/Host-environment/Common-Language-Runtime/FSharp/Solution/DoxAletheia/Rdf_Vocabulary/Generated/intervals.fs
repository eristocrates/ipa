namespace http.reference.data.gov.uk.def.intervals.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module intervals =
    let _namespace_iri = Namespace_Iri intervals |> NamespaceIRI
    /// <summary>
    ///   <para>intervals:August</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:MonthOfYear</para>
    ///   <para>The month of August</para>
    /// labels<para>August</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/August">http://reference.data.gov.uk/def/intervals/August</seealso>
    let August = Prefixed_Name(intervals, "August") |> PrefixedName
    /// <summary>
    ///   <para>intervals:February</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:MonthOfYear</para>
    ///   <para>The month of February</para>
    /// labels<para>February</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/February">http://reference.data.gov.uk/def/intervals/February</seealso>
    let February = Prefixed_Name(intervals, "February") |> PrefixedName
    /// <summary>
    ///   <para>intervals:ordinalYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ordinal year of the year in which an instant or interval (of duration one year or less) occurs. The first year of the AD era has ordinal number 1.</para>
    /// labels<para>ordinal year</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/ordinalYear">http://reference.data.gov.uk/def/intervals/ordinalYear</seealso>
    let ordinalYear = Prefixed_Name(intervals, "ordinalYear") |> PrefixedName

    /// <summary>
    ///   <para>intervals:previousAnnualReferenceDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A reference to the companies house annual reference date at the end of the previous reporting year. Annual reporting periods are required to end with 7 days of this date. Success annual reference dates normally advance by 1 whole year each year. However, companies can always apply for an earlier reference date and under restricted circumstance request a later reference date (upto 6 months later) see http://www.companieshouse.gov.uk/about/gbhtml/gp2.shtml#ch2.</para>
    /// labels<para>Previous Annual Reference Date.</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/previousAnnualReferenceDate">http://reference.data.gov.uk/def/intervals/previousAnnualReferenceDate</seealso>
    let previousAnnualReferenceDate =
        Prefixed_Name(intervals, "previousAnnualReferenceDate") |> PrefixedName

    /// <summary>
    ///   <para>intervals:April</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:MonthOfYear</para>
    ///   <para>The month of April</para>
    /// labels<para>April</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/April">http://reference.data.gov.uk/def/intervals/April</seealso>
    let April = Prefixed_Name(intervals, "April") |> PrefixedName
    /// <summary>
    ///   <para>intervals:BusinessYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for regular annual business reporting and planning intervals, not necessarily calendar aligned.</para>
    /// labels<para>Business Year</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/BusinessYear">http://reference.data.gov.uk/def/intervals/BusinessYear</seealso>
    let BusinessYear = Prefixed_Name(intervals, "BusinessYear") |> PrefixedName
    /// <summary>
    ///   <para>intervals:BusinessInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A top-level class for business intervals</para>
    /// labels<para>Business Intervals</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/BusinessInterval">http://reference.data.gov.uk/def/intervals/BusinessInterval</seealso>
    let BusinessInterval = Prefixed_Name(intervals, "BusinessInterval") |> PrefixedName
    /// <summary>
    ///   <para>intervals:BusinessQuarter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/BusinessQuarter">http://reference.data.gov.uk/def/intervals/BusinessQuarter</seealso>
    let BusinessQuarter = Prefixed_Name(intervals, "BusinessQuarter") |> PrefixedName
    /// <summary>
    ///   <para>intervals:Year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A generic superclass for all manner of Year like intervals. The the cardinality of days in a year is set to between 351 and 380 because in the UK the end of a business reporting year must be within 7 days of an annual reference date. In the worst cases this allows a reporting interval to be shortened or extended by up to two weeks.</para>
    /// labels<para>Generic Year (Class)</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/Year">http://reference.data.gov.uk/def/intervals/Year</seealso>
    let Year = Prefixed_Name(intervals, "Year") |> PrefixedName
    /// <summary>
    ///   <para>intervals:nextInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/nextInterval">http://reference.data.gov.uk/def/intervals/nextInterval</seealso>
    let nextInterval = Prefixed_Name(intervals, "nextInterval") |> PrefixedName
    /// <summary>
    ///   <para>intervals:previousInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/previousInterval">http://reference.data.gov.uk/def/intervals/previousInterval</seealso>
    let previousInterval = Prefixed_Name(intervals, "previousInterval") |> PrefixedName
    /// <summary>
    ///   <para>intervals:CalendarInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for all calendar aligned intervals.  The start of a given interval is aligned with the start of each of its first (temporally) subordinate CalendarInterval. Halfs are align the start of the first and seventh month of a year; quarters with the first, forth, seventh and tenth months; months with calendar months sof forth for calendar days, hours,minutes and seconds align </para>
    /// labels<para>CalendarInterval (class)</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/CalendarInterval">http://reference.data.gov.uk/def/intervals/CalendarInterval</seealso>
    let CalendarInterval = Prefixed_Name(intervals, "CalendarInterval") |> PrefixedName
    /// <summary>
    ///   <para>intervals:June</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:MonthOfYear</para>
    ///   <para>The month of June</para>
    /// labels<para>January</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/June">http://reference.data.gov.uk/def/intervals/June</seealso>
    let June = Prefixed_Name(intervals, "June") |> PrefixedName
    /// <summary>
    ///   <para>intervals:CalendarYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for calendar aligned intervals of one whole year, ie. year long intervals that are aligned with a Calendar.</para>
    /// labels<para>Calendar Year</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/CalendarYear">http://reference.data.gov.uk/def/intervals/CalendarYear</seealso>
    let CalendarYear = Prefixed_Name(intervals, "CalendarYear") |> PrefixedName
    /// <summary>
    ///   <para>intervals:Half</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A generic superclass for all half-year (6 month) like intervals</para>
    /// labels<para>Generic Half (Class)</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/Half">http://reference.data.gov.uk/def/intervals/Half</seealso>
    let Half = Prefixed_Name(intervals, "Half") |> PrefixedName
    /// <summary>
    ///   <para>intervals:Quarter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A generic superclass for all Quarter (3-month) long intervals</para>
    /// labels<para>Generic Quarter (Class)</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/Quarter">http://reference.data.gov.uk/def/intervals/Quarter</seealso>
    let Quarter = Prefixed_Name(intervals, "Quarter") |> PrefixedName
    /// <summary>
    ///   <para>intervals:CalendarDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for calendar aligned one day intervals, starting at 00:00 (midnight) on the relevant day. ISO 8601(E):2004 Section 2.2.6</para>
    /// labels<para>Calendar Day</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/CalendarDay">http://reference.data.gov.uk/def/intervals/CalendarDay</seealso>
    let CalendarDay = Prefixed_Name(intervals, "CalendarDay") |> PrefixedName
    /// <summary>
    ///   <para>intervals:CalendarHalf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for calendar aligned intervals that represent a calendar half year, a year being split into two half year periods of 6 months each.</para>
    /// labels<para>CalendarHalf (class)</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/CalendarHalf">http://reference.data.gov.uk/def/intervals/CalendarHalf</seealso>
    let CalendarHalf = Prefixed_Name(intervals, "CalendarHalf") |> PrefixedName

    /// <summary>
    ///   <para>intervals:intervalContainsMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/intervalContainsMonth">http://reference.data.gov.uk/def/intervals/intervalContainsMonth</seealso>
    let intervalContainsMonth =
        Prefixed_Name(intervals, "intervalContainsMonth") |> PrefixedName

    /// <summary>
    ///   <para>intervals:IntervalList</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/IntervalList">http://reference.data.gov.uk/def/intervals/IntervalList</seealso>
    let IntervalList = Prefixed_Name(intervals, "IntervalList") |> PrefixedName

    /// <summary>
    ///   <para>intervals:IrregularInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A business interval outside of the normal pattern of business intervals. In the UK companies house allow an annual reporting interval to be extended by upto 6 months once in 5 years (and at other exceptional times)</para>
    /// labels<para>Irregular Business interval</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/IrregularInterval">http://reference.data.gov.uk/def/intervals/IrregularInterval</seealso>
    let IrregularInterval =
        Prefixed_Name(intervals, "IrregularInterval") |> PrefixedName

    /// <summary>
    ///   <para>intervals:Week</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A generic superclass for all one-week long (7 day) intervals.</para>
    /// labels<para>Generic Week (Class)</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/Week">http://reference.data.gov.uk/def/intervals/Week</seealso>
    let Week = Prefixed_Name(intervals, "Week") |> PrefixedName
    /// <summary>
    ///   <para>intervals:January</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:MonthOfYear</para>
    ///   <para>The month of January</para>
    /// labels<para>January</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/January">http://reference.data.gov.uk/def/intervals/January</seealso>
    let January = Prefixed_Name(intervals, "January") |> PrefixedName
    /// <summary>
    ///   <para>intervals:July</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:MonthOfYear</para>
    ///   <para>The month of July</para>
    /// labels<para>July</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/July">http://reference.data.gov.uk/def/intervals/July</seealso>
    let July = Prefixed_Name(intervals, "July") |> PrefixedName
    /// <summary>
    ///   <para>intervals:May</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:MonthOfYear</para>
    ///   <para>The month of May</para>
    /// labels<para>May</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/May">http://reference.data.gov.uk/def/intervals/May</seealso>
    let May = Prefixed_Name(intervals, "May") |> PrefixedName
    /// <summary>
    ///   <para>intervals:one-minute</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:DurationDescriptions</para>
    ///   <para>A duration of 1 minute</para>
    /// labels<para>1 minute</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/one-minute">http://reference.data.gov.uk/def/intervals/one-minute</seealso>
    let one_minute = Prefixed_Name(intervals, "one-minute") |> PrefixedName
    /// <summary>
    ///   <para>intervals:Day</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A generic superclass for all day like entities.</para>
    /// labels<para>Generic Day (Class)</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/Day">http://reference.data.gov.uk/def/intervals/Day</seealso>
    let Day = Prefixed_Name(intervals, "Day") |> PrefixedName
    /// <summary>
    ///   <para>intervals:March</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:MonthOfYear</para>
    ///   <para>The month of March</para>
    /// labels<para>March</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/March">http://reference.data.gov.uk/def/intervals/March</seealso>
    let March = Prefixed_Name(intervals, "March") |> PrefixedName
    /// <summary>
    ///   <para>intervals:one-month</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:DurationDescriptions</para>
    ///   <para>A duration of one month</para>
    /// labels<para>1 month</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/one-month">http://reference.data.gov.uk/def/intervals/one-month</seealso>
    let one_month = Prefixed_Name(intervals, "one-month") |> PrefixedName
    /// <summary>
    ///   <para>intervals:September</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:MonthOfYear</para>
    ///   <para>The month of September</para>
    /// labels<para>September</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/September">http://reference.data.gov.uk/def/intervals/September</seealso>
    let September = Prefixed_Name(intervals, "September") |> PrefixedName
    /// <summary>
    ///   <para>intervals:October</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:MonthOfYear</para>
    ///   <para>The month of October</para>
    /// labels<para>October</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/October">http://reference.data.gov.uk/def/intervals/October</seealso>
    let October = Prefixed_Name(intervals, "October") |> PrefixedName
    /// <summary>
    ///   <para>intervals:November</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:MonthOfYear</para>
    ///   <para>The month of Novermber</para>
    /// labels<para>November</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/November">http://reference.data.gov.uk/def/intervals/November</seealso>
    let November = Prefixed_Name(intervals, "November") |> PrefixedName
    /// <summary>
    ///   <para>intervals:Q1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for intervals that are the first quarter of a (nominally) annual cycle.</para>
    /// labels<para>Q1 Interval</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/Q1">http://reference.data.gov.uk/def/intervals/Q1</seealso>
    let Q1 = Prefixed_Name(intervals, "Q1") |> PrefixedName
    /// <summary>
    ///   <para>intervals:Q2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for intervals that are 2nd quarters of a (nominally) annual cycle</para>
    /// labels<para>Q2 Interval</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/Q2">http://reference.data.gov.uk/def/intervals/Q2</seealso>
    let Q2 = Prefixed_Name(intervals, "Q2") |> PrefixedName
    /// <summary>
    ///   <para>intervals:Q4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for intervals that are 4th quarters of a (nominally) annual cycle.</para>
    /// labels<para>Q4 Interval</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/Q4">http://reference.data.gov.uk/def/intervals/Q4</seealso>
    let Q4 = Prefixed_Name(intervals, "Q4") |> PrefixedName
    /// <summary>
    ///   <para>intervals:CalendarHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for calendar aligned hour-long intervals. ISO 8601(E):2004 Section 2.2.4</para>
    /// labels<para>Calendar Hour (Class)</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/CalendarHour">http://reference.data.gov.uk/def/intervals/CalendarHour</seealso>
    let CalendarHour = Prefixed_Name(intervals, "CalendarHour") |> PrefixedName
    /// <summary>
    ///   <para>intervals:Hour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A generic superclass for hour-long intervals. An hour may contain a positive or negative leap second (see http://en.wikipedia.org/wiki/Hour).</para>
    /// labels<para>Generic Hour (class)</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/Hour">http://reference.data.gov.uk/def/intervals/Hour</seealso>
    let Hour = Prefixed_Name(intervals, "Hour") |> PrefixedName

    /// <summary>
    ///   <para>intervals:intervalContainsWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/intervalContainsWeek">http://reference.data.gov.uk/def/intervals/intervalContainsWeek</seealso>
    let intervalContainsWeek =
        Prefixed_Name(intervals, "intervalContainsWeek") |> PrefixedName

    /// <summary>
    ///   <para>intervals:intervalContainsHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/intervalContainsHour">http://reference.data.gov.uk/def/intervals/intervalContainsHour</seealso>
    let intervalContainsHour =
        Prefixed_Name(intervals, "intervalContainsHour") |> PrefixedName

    /// <summary>
    ///   <para>intervals:intervalContainsMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/intervalContainsMinute">http://reference.data.gov.uk/def/intervals/intervalContainsMinute</seealso>
    let intervalContainsMinute =
        Prefixed_Name(intervals, "intervalContainsMinute") |> PrefixedName

    /// <summary>
    ///   <para>intervals:CalendarMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for calendar align one minute intervals. ISO 8601(E):2004 Section 2.2.3 (for units - 1 minute interval are not defined).</para>
    /// labels<para>Calendar Minute</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/CalendarMinute">http://reference.data.gov.uk/def/intervals/CalendarMinute</seealso>
    let CalendarMinute = Prefixed_Name(intervals, "CalendarMinute") |> PrefixedName
    /// <summary>
    ///   <para>intervals:CalendarInstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/CalendarInstant">http://reference.data.gov.uk/def/intervals/CalendarInstant</seealso>
    let CalendarInstant = Prefixed_Name(intervals, "CalendarInstant") |> PrefixedName
    /// <summary>
    ///   <para>intervals:Q3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for intervals that are 3rd quarters of a (nominally) annual cycle</para>
    /// labels<para>Q3 Interval</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/Q3">http://reference.data.gov.uk/def/intervals/Q3</seealso>
    let Q3 = Prefixed_Name(intervals, "Q3") |> PrefixedName
    /// <summary>
    ///   <para>intervals:Q5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for 5th quarters of an abnormally long annual interval - in the UK a buisness interval may exceptionally extent to 6 quarters.</para>
    /// labels<para>Q5 Interval</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/Q5">http://reference.data.gov.uk/def/intervals/Q5</seealso>
    let Q5 = Prefixed_Name(intervals, "Q5") |> PrefixedName
    /// <summary>
    ///   <para>intervals:one-second</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:DurationDescriptions</para>
    ///   <para>A duration of one second</para>
    /// labels<para>1 second</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/one-second">http://reference.data.gov.uk/def/intervals/one-second</seealso>
    let one_second = Prefixed_Name(intervals, "one-second") |> PrefixedName

    /// <summary>
    ///   <para>intervals:intervalContainsHalf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/intervalContainsHalf">http://reference.data.gov.uk/def/intervals/intervalContainsHalf</seealso>
    let intervalContainsHalf =
        Prefixed_Name(intervals, "intervalContainsHalf") |> PrefixedName

    /// <summary>
    ///   <para>intervals:intervalContainsSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/intervalContainsSecond">http://reference.data.gov.uk/def/intervals/intervalContainsSecond</seealso>
    let intervalContainsSecond =
        Prefixed_Name(intervals, "intervalContainsSecond") |> PrefixedName

    /// <summary>
    ///   <para>intervals:Q6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for 6th quarters of an abnormally long annual interval - in the UK a buisness interval may exceptionally extent to 6 quarters.</para>
    /// labels<para>Q6 Interval</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/Q6">http://reference.data.gov.uk/def/intervals/Q6</seealso>
    let Q6 = Prefixed_Name(intervals, "Q6") |> PrefixedName
    /// <summary>
    ///   <para>intervals:one-quarter</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:DurationDescriptions</para>
    ///   <para>A duration of one quarter, typically 3 months.</para>
    /// labels<para>1 quarter of a year</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/one-quarter">http://reference.data.gov.uk/def/intervals/one-quarter</seealso>
    let one_quarter = Prefixed_Name(intervals, "one-quarter") |> PrefixedName
    /// <summary>
    ///   <para>intervals:one-week</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:DurationDescriptions</para>
    ///   <para>A duration of one week</para>
    /// labels<para>1 week</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/one-week">http://reference.data.gov.uk/def/intervals/one-week</seealso>
    let one_week = Prefixed_Name(intervals, "one-week") |> PrefixedName

    /// <summary>
    ///   <para>intervals:intervalContainsDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/intervalContainsDay">http://reference.data.gov.uk/def/intervals/intervalContainsDay</seealso>
    let intervalContainsDay =
        Prefixed_Name(intervals, "intervalContainsDay") |> PrefixedName

    /// <summary>
    ///   <para>intervals:CalendarSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for calendar aligned one-second intervals. ISO 8601(E):2004 Section 2.2.1 (and 2.2.2 for leap seconds)(for units - 1 second interval are not defined).</para>
    /// labels<para>Calendar Second</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/CalendarSecond">http://reference.data.gov.uk/def/intervals/CalendarSecond</seealso>
    let CalendarSecond = Prefixed_Name(intervals, "CalendarSecond") |> PrefixedName
    /// <summary>
    ///   <para>intervals:Iso8601Week</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for calendar weeks. Strictly not all calendar week intervals are contained within the year to which they may be attributed. The first or last week of a given calendar year may inculde days from the preceding or following calendar year respectively. An ISO 8601 week starts at 00:00:00 in a Monday and ends at the last moment of 23:59:59 on the following Sunday.  ISO 8601(E):2004 Section 2.2.8</para>
    /// labels<para>Calendar Week</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/Iso8601Week">http://reference.data.gov.uk/def/intervals/Iso8601Week</seealso>
    let Iso8601Week = Prefixed_Name(intervals, "Iso8601Week") |> PrefixedName

    /// <summary>
    ///   <para>intervals:intervalContainsQuarter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/intervalContainsQuarter">http://reference.data.gov.uk/def/intervals/intervalContainsQuarter</seealso>
    let intervalContainsQuarter =
        Prefixed_Name(intervals, "intervalContainsQuarter") |> PrefixedName

    /// <summary>
    ///   <para>intervals:one-year</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:DurationDescriptions</para>
    ///   <para>A duration of one year</para>
    /// labels<para>1 year</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/one-year">http://reference.data.gov.uk/def/intervals/one-year</seealso>
    let one_year = Prefixed_Name(intervals, "one-year") |> PrefixedName
    /// <summary>
    ///   <para>intervals:dayOfWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The day of the week in which an instant or interval (of duration one day or less) occurs.</para>
    /// labels<para>day of week</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/dayOfWeek">http://reference.data.gov.uk/def/intervals/dayOfWeek</seealso>
    let dayOfWeek = Prefixed_Name(intervals, "dayOfWeek") |> PrefixedName
    /// <summary>
    ///   <para>intervals:CalendarMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for calendar aligned intervals of one calendar month.  ISO 8601(E):2004 Section 2.2.11</para>
    /// labels<para>Calendar Month</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/CalendarMonth">http://reference.data.gov.uk/def/intervals/CalendarMonth</seealso>
    let CalendarMonth = Prefixed_Name(intervals, "CalendarMonth") |> PrefixedName

    /// <summary>
    ///   <para>intervals:intervalContainsDays</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/intervalContainsDays">http://reference.data.gov.uk/def/intervals/intervalContainsDays</seealso>
    let intervalContainsDays =
        Prefixed_Name(intervals, "intervalContainsDays") |> PrefixedName

    /// <summary>
    ///   <para>intervals:intervalContainsHours</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/intervalContainsHours">http://reference.data.gov.uk/def/intervals/intervalContainsHours</seealso>
    let intervalContainsHours =
        Prefixed_Name(intervals, "intervalContainsHours") |> PrefixedName

    /// <summary>
    ///   <para>intervals:intervalContainsIso8601Week</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/intervalContainsIso8601Week">http://reference.data.gov.uk/def/intervals/intervalContainsIso8601Week</seealso>
    let intervalContainsIso8601Week =
        Prefixed_Name(intervals, "intervalContainsIso8601Week") |> PrefixedName

    /// <summary>
    ///   <para>intervals:intervalContainsQuarters</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/intervalContainsQuarters">http://reference.data.gov.uk/def/intervals/intervalContainsQuarters</seealso>
    let intervalContainsQuarters =
        Prefixed_Name(intervals, "intervalContainsQuarters") |> PrefixedName

    /// <summary>
    ///   <para>intervals:intervalContainsSeconds</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/intervalContainsSeconds">http://reference.data.gov.uk/def/intervals/intervalContainsSeconds</seealso>
    let intervalContainsSeconds =
        Prefixed_Name(intervals, "intervalContainsSeconds") |> PrefixedName

    /// <summary>
    ///   <para>intervals:nextAnnualReferenceDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A reference to the companies house annual reference date at the end of the previous reporting year. Annual reporting periods are required to end with 7 days of this date. Success annual reference dates normally advance by 1 whole year each year. However, companies can always apply for an earlier reference date and under restricted circumstance request a later reference date (upto 6 months later) see http://www.companieshouse.gov.uk/about/gbhtml/gp2.shtml#ch2</para>
    /// labels<para>Next Annual Reference Date.</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/nextAnnualReferenceDate">http://reference.data.gov.uk/def/intervals/nextAnnualReferenceDate</seealso>
    let nextAnnualReferenceDate =
        Prefixed_Name(intervals, "nextAnnualReferenceDate") |> PrefixedName

    /// <summary>
    ///   <para>intervals:CalendarQuarter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for calendar aligned one-quarter year (3 month) intervals</para>
    /// labels<para>Calendar Quarter</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/CalendarQuarter">http://reference.data.gov.uk/def/intervals/CalendarQuarter</seealso>
    let CalendarQuarter = Prefixed_Name(intervals, "CalendarQuarter") |> PrefixedName

    /// <summary>
    ///   <para>intervals:intervalContainsMinutes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/intervalContainsMinutes">http://reference.data.gov.uk/def/intervals/intervalContainsMinutes</seealso>
    let intervalContainsMinutes =
        Prefixed_Name(intervals, "intervalContainsMinutes") |> PrefixedName

    /// <summary>
    ///   <para>intervals:monthOfYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The month of the year in which a contained instant or interval (of duration one month or less) occurs.</para>
    /// labels<para>month of year</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/monthOfYear">http://reference.data.gov.uk/def/intervals/monthOfYear</seealso>
    let monthOfYear = Prefixed_Name(intervals, "monthOfYear") |> PrefixedName

    /// <summary>
    ///   <para>intervals:intervalContainsHalves</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/intervalContainsHalves">http://reference.data.gov.uk/def/intervals/intervalContainsHalves</seealso>
    let intervalContainsHalves =
        Prefixed_Name(intervals, "intervalContainsHalves") |> PrefixedName

    /// <summary>
    ///   <para>intervals:intervalContainsMonths</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/intervalContainsMonths">http://reference.data.gov.uk/def/intervals/intervalContainsMonths</seealso>
    let intervalContainsMonths =
        Prefixed_Name(intervals, "intervalContainsMonths") |> PrefixedName

    /// <summary>
    ///   <para>intervals:Minute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A generic superclass for all minute-long intervals. A minute may contain a positive or negative leap second.</para>
    /// labels<para>Generic Minute (Class)</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/Minute">http://reference.data.gov.uk/def/intervals/Minute</seealso>
    let Minute = Prefixed_Name(intervals, "Minute") |> PrefixedName
    /// <summary>
    ///   <para>intervals:Month</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A generic superclass class for all month-long like intervals.</para>
    /// labels<para>Generic Month (Class)</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/Month">http://reference.data.gov.uk/def/intervals/Month</seealso>
    let Month = Prefixed_Name(intervals, "Month") |> PrefixedName
    /// <summary>
    ///   <para>intervals:Second</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A generic superclass for all one-second long like intervals</para>
    /// labels<para>Generic Second (Class)</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/Second">http://reference.data.gov.uk/def/intervals/Second</seealso>
    let Second = Prefixed_Name(intervals, "Second") |> PrefixedName

    /// <summary>
    ///   <para>intervals:ordinalDayOfMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ordinal number of the day of the month in in which an instant or interval (of duration less than one day) occurs. The first day of a month has the ordinal number 1.</para>
    /// labels<para>ordinal day of month</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/ordinalDayOfMonth">http://reference.data.gov.uk/def/intervals/ordinalDayOfMonth</seealso>
    let ordinalDayOfMonth =
        Prefixed_Name(intervals, "ordinalDayOfMonth") |> PrefixedName

    /// <summary>
    ///   <para>intervals:ordinalDayOfWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ordinal number of the day of the week in which a (contained) instant or interval (of one day or less in duration) occurs. The Monday has an ordinal number of 1.</para>
    /// labels<para>ordinal day of week {en}</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/ordinalDayOfWeek">http://reference.data.gov.uk/def/intervals/ordinalDayOfWeek</seealso>
    let ordinalDayOfWeek = Prefixed_Name(intervals, "ordinalDayOfWeek") |> PrefixedName
    /// <summary>
    ///   <para>intervals:ordinalDayOfYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ordinal number of the day of the year in in which an instant or interval (of duration one day or less) occurs. The first day of a year has the ordinal number 1.</para>
    /// labels<para>ordinal day of month</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/ordinalDayOfYear">http://reference.data.gov.uk/def/intervals/ordinalDayOfYear</seealso>
    let ordinalDayOfYear = Prefixed_Name(intervals, "ordinalDayOfYear") |> PrefixedName

    /// <summary>
    ///   <para>intervals:ordinalHalfOfYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ordinal number of the half of a year in which a contained instant or interval (of duration one half year or less) occurs. The first half of a year has the ordinal number 1.</para>
    /// labels<para>has half of year</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/ordinalHalfOfYear">http://reference.data.gov.uk/def/intervals/ordinalHalfOfYear</seealso>
    let ordinalHalfOfYear =
        Prefixed_Name(intervals, "ordinalHalfOfYear") |> PrefixedName

    /// <summary>
    ///   <para>intervals:ordinalHourOfDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ordinal number of the hour of day in which a (contained) instant or interval (of less than one hour duration) occurs. The first hour of a day has ordinal number 0.</para>
    /// labels<para>ordinal hour of day</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/ordinalHourOfDay">http://reference.data.gov.uk/def/intervals/ordinalHourOfDay</seealso>
    let ordinalHourOfDay = Prefixed_Name(intervals, "ordinalHourOfDay") |> PrefixedName

    /// <summary>
    ///   <para>intervals:ordinalMinuteOfHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ordinal number of the minute of the hour in which a contained instant or interval (of duration one hour or less) occurs. The first minute of an hour has ordinal number 0.</para>
    /// labels<para>ordinal minute of hour</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/ordinalMinuteOfHour">http://reference.data.gov.uk/def/intervals/ordinalMinuteOfHour</seealso>
    let ordinalMinuteOfHour =
        Prefixed_Name(intervals, "ordinalMinuteOfHour") |> PrefixedName

    /// <summary>
    ///   <para>intervals:ordinalMonthOfYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ordinal number of the month of the year in in which an instant or interval (of duration one day or less) occurs. The January has the ordinal number 1.</para>
    /// labels<para>ordinal month of year</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/ordinalMonthOfYear">http://reference.data.gov.uk/def/intervals/ordinalMonthOfYear</seealso>
    let ordinalMonthOfYear =
        Prefixed_Name(intervals, "ordinalMonthOfYear") |> PrefixedName

    /// <summary>
    ///   <para>intervals:hasXsdDurationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>hasXsdDurationDescription: a data type property for associating an xsd:duration with an Interval. Inspired by "durationDescriptionDataType" mentioned in "http://www.w3.org/TR/owl-time" but which seems to have failed to make it into the formal ontology.</para>
    /// labels<para>hasXsdDurationDescription (DataTypeProperty)</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/hasXsdDurationDescription">http://reference.data.gov.uk/def/intervals/hasXsdDurationDescription</seealso>
    let hasXsdDurationDescription =
        Prefixed_Name(intervals, "hasXsdDurationDescription") |> PrefixedName

    /// <summary>
    ///   <para>intervals:December</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:MonthOfYear</para>
    ///   <para>The month of December</para>
    /// labels<para>December</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/December">http://reference.data.gov.uk/def/intervals/December</seealso>
    let December = Prefixed_Name(intervals, "December") |> PrefixedName
    /// <summary>
    ///   <para>intervals:H1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for intervals that the first half of a (nominally) annual cycle.</para>
    /// labels<para>H1 Interval</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/H1">http://reference.data.gov.uk/def/intervals/H1</seealso>
    let H1 = Prefixed_Name(intervals, "H1") |> PrefixedName
    /// <summary>
    ///   <para>intervals:H2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for intervals that the second half of a (nominally) annual cycle.</para>
    /// labels<para>H2 Interval</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/H2">http://reference.data.gov.uk/def/intervals/H2</seealso>
    let H2 = Prefixed_Name(intervals, "H2") |> PrefixedName

    /// <summary>
    ///   <para>intervals:ordinalQuarterOfYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ordinal number of the quarter of the year in which a contained instant or interval (of duration one quarter year or less) occurs. The ordinal number of the first quarter of a year is 1.</para>
    /// labels<para>ordinal quarter of year</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/ordinalQuarterOfYear">http://reference.data.gov.uk/def/intervals/ordinalQuarterOfYear</seealso>
    let ordinalQuarterOfYear =
        Prefixed_Name(intervals, "ordinalQuarterOfYear") |> PrefixedName

    /// <summary>
    ///   <para>intervals:ordinalSecondOfMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ordinal number of the second of the minute in which a contained instant or interval (of one second duration or less) occurs. The ordinal number of the first second of a minute is 0.</para>
    /// labels<para>ordinal second of minute</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/ordinalSecondOfMinute">http://reference.data.gov.uk/def/intervals/ordinalSecondOfMinute</seealso>
    let ordinalSecondOfMinute =
        Prefixed_Name(intervals, "ordinalSecondOfMinute") |> PrefixedName

    /// <summary>
    ///   <para>intervals:ordinalWeekOfYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ordinal number of the week of the year in which a contained instant or interval of one week duration or less occurs. The ordinal number of the first week of a year is 1. The first week of a year is the week that contains the first Thursday of the year.</para>
    /// labels<para>ordinal week of year</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/ordinalWeekOfYear">http://reference.data.gov.uk/def/intervals/ordinalWeekOfYear</seealso>
    let ordinalWeekOfYear =
        Prefixed_Name(intervals, "ordinalWeekOfYear") |> PrefixedName

    /// <summary>
    ///   <para>intervals:ordinalWeekOfYearYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ordinal number of the week of year year in which an instant or interval (of duration one week or less) occurs. The first year of the AD era has ordinal number 1.  The Week Of Year is the year to which a week of year pertains, which is usually the same as the calendar year except aorund the end of year where some days of the week may be deemed to be in the yearr following or the year previous depending on the alignment of the year boundary with the weekly cycle.</para>
    /// labels<para>ordinal week of year year</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/ordinalWeekOfYearYear">http://reference.data.gov.uk/def/intervals/ordinalWeekOfYearYear</seealso>
    let ordinalWeekOfYearYear =
        Prefixed_Name(intervals, "ordinalWeekOfYearYear") |> PrefixedName

    /// <summary>
    ///   <para>intervals:one-day</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:DurationDescriptions</para>
    ///   <para>A duration of one day, typically 24 hours)</para>
    /// labels<para>1 day</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/one-day">http://reference.data.gov.uk/def/intervals/one-day</seealso>
    let one_day = Prefixed_Name(intervals, "one-day") |> PrefixedName
    /// <summary>
    ///   <para>intervals:Interval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/Interval">http://reference.data.gov.uk/def/intervals/Interval</seealso>
    let Interval = Prefixed_Name(intervals, "Interval") |> PrefixedName

    /// <summary>
    ///   <para>intervals:DurationDescriptions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/DurationDescriptions">http://reference.data.gov.uk/def/intervals/DurationDescriptions</seealso>
    let DurationDescriptions =
        Prefixed_Name(intervals, "DurationDescriptions") |> PrefixedName

    /// <summary>
    ///   <para>intervals:H3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for 3rd half year intervals in an abnormally long annual interval - in the UK a buisness interval may exceptionally extent to 6 quarters.</para>
    /// labels<para>H3 Interval</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/H3">http://reference.data.gov.uk/def/intervals/H3</seealso>
    let H3 = Prefixed_Name(intervals, "H3") |> PrefixedName
    /// <summary>
    ///   <para>intervals:one-half</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:DurationDescriptions</para>
    ///   <para>A duration of one half year, typically 6 months</para>
    /// labels<para>1 half of a year</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/one-half">http://reference.data.gov.uk/def/intervals/one-half</seealso>
    let one_half = Prefixed_Name(intervals, "one-half") |> PrefixedName
    /// <summary>
    ///   <para>intervals:one-hour</para>
    /// </summary>
    /// <remarks>
    ///   <para>intervals:DurationDescriptions</para>
    ///   <para>A duration of one hour</para>
    /// labels<para>1 hour</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/one-hour">http://reference.data.gov.uk/def/intervals/one-hour</seealso>
    let one_hour = Prefixed_Name(intervals, "one-hour") |> PrefixedName
    /// <summary>
    ///   <para>intervals:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/">http://reference.data.gov.uk/def/intervals/</seealso>
    let _prefix_iri = Prefixed_Name(intervals, "") |> PrefixedName
    /// <summary>
    ///   <para>intervals:MonthOfYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for the months of a calendar year. A month of year is a recurring interval of about 12th of a year that re-occurs annually.</para>
    /// labels<para>month of year</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/MonthOfYear">http://reference.data.gov.uk/def/intervals/MonthOfYear</seealso>
    let MonthOfYear = Prefixed_Name(intervals, "MonthOfYear") |> PrefixedName
    /// <summary>
    ///   <para>intervals:BusinessHalf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for business half year intervals. These intervals are not necessarily calendar aligned with month boundaries.</para>
    /// labels<para>Half Year Interval</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/intervals/BusinessHalf">http://reference.data.gov.uk/def/intervals/BusinessHalf</seealso>
    let BusinessHalf = Prefixed_Name(intervals, "BusinessHalf") |> PrefixedName
