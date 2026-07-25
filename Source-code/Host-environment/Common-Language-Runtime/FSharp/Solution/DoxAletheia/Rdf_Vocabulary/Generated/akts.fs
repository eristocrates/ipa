namespace http.www.aktors.org.ontology.support.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module akts =
    let _namespace_iri = Namespace_Iri akts |> NamespaceIRI
    /// <summary>
    ///   <para>akts:minute-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>minute of</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#minute-of">http://www.aktors.org/ontology/support#minute-of</seealso>
    let minute_of = Prefixed_Name(akts, "minute-of") |> PrefixedName

    /// <summary>
    ///   <para>akts:thirtyone-day-duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>akts:Duration</para>
    ///
    /// labels<para>31 day duration</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#thirtyone-day-duration">http://www.aktors.org/ontology/support#thirtyone-day-duration</seealso>
    let thirtyone_day_duration =
        Prefixed_Name(akts, "thirtyone-day-duration") |> PrefixedName

    /// <summary>
    ///   <para>akts:time-measure-minute</para>
    /// </summary>
    /// <remarks>
    ///   <para>akts:Time-Measure</para>
    ///
    /// labels<para>minute</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#time-measure-minute">http://www.aktors.org/ontology/support#time-measure-minute</seealso>
    let time_measure_minute = Prefixed_Name(akts, "time-measure-minute") |> PrefixedName
    /// <summary>
    ///   <para>akts:time-measure-second</para>
    /// </summary>
    /// <remarks>
    ///   <para>akts:Time-Measure</para>
    ///
    /// labels<para>second</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#time-measure-second">http://www.aktors.org/ontology/support#time-measure-second</seealso>
    let time_measure_second = Prefixed_Name(akts, "time-measure-second") |> PrefixedName

    /// <summary>
    ///   <para>akts:twentyeight-day-duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>akts:Duration</para>
    ///
    /// labels<para>28 day duration</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#twentyeight-day-duration">http://www.aktors.org/ontology/support#twentyeight-day-duration</seealso>
    let twentyeight_day_duration =
        Prefixed_Name(akts, "twentyeight-day-duration") |> PrefixedName

    /// <summary>
    ///   <para>akts:Calendar-Date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point in time</para>
    /// labels<para>Calendar Date</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#Calendar-Date">http://www.aktors.org/ontology/support#Calendar-Date</seealso>
    let Calendar_Date = Prefixed_Name(akts, "Calendar-Date") |> PrefixedName
    /// <summary>
    ///   <para>akts:hour-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hour of</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#hour-of">http://www.aktors.org/ontology/support#hour-of</seealso>
    let hour_of = Prefixed_Name(akts, "hour-of") |> PrefixedName
    /// <summary>
    ///   <para>akts:year-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>year of</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#year-of">http://www.aktors.org/ontology/support#year-of</seealso>
    let year_of = Prefixed_Name(akts, "year-of") |> PrefixedName
    /// <summary>
    ///   <para>akts:Time-Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point in time</para>
    /// labels<para>Time Point</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#Time-Point">http://www.aktors.org/ontology/support#Time-Point</seealso>
    let Time_Point = Prefixed_Name(akts, "Time-Point") |> PrefixedName
    /// <summary>
    ///   <para>akts:day-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>day of</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#day-of">http://www.aktors.org/ontology/support#day-of</seealso>
    let day_of = Prefixed_Name(akts, "day-of") |> PrefixedName
    /// <summary>
    ///   <para>akts:month-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>month of</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#month-of">http://www.aktors.org/ontology/support#month-of</seealso>
    let month_of = Prefixed_Name(akts, "month-of") |> PrefixedName
    /// <summary>
    ///   <para>akts:second-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>second of</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#second-of">http://www.aktors.org/ontology/support#second-of</seealso>
    let second_of = Prefixed_Name(akts, "second-of") |> PrefixedName
    /// <summary>
    ///   <para>akts:Duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measure of time, e.g., 5 hours</para>
    /// labels<para>Duration</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#Duration">http://www.aktors.org/ontology/support#Duration</seealso>
    let Duration = Prefixed_Name(akts, "Duration") |> PrefixedName
    /// <summary>
    ///   <para>akts:has-unit-of-measure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has unit of measure</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#has-unit-of-measure">http://www.aktors.org/ontology/support#has-unit-of-measure</seealso>
    let has_unit_of_measure = Prefixed_Name(akts, "has-unit-of-measure") |> PrefixedName
    /// <summary>
    ///   <para>akts:Thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This is the top-level concept in the AKT reference ontology</para>
    /// labels<para>Thing</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#Thing">http://www.aktors.org/ontology/support#Thing</seealso>
    let Thing = Prefixed_Name(akts, "Thing") |> PrefixedName
    /// <summary>
    ///   <para>akts:Quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>From SUO: Any specification of how many or how much of something there is. Accordingly, there are two subclasses of Quantity: Number (how many) and Physical-Quantity (how much).</para>
    /// labels<para>Quantity</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#Quantity">http://www.aktors.org/ontology/support#Quantity</seealso>
    let Quantity = Prefixed_Name(akts, "Quantity") |> PrefixedName
    /// <summary>
    ///   <para>akts:Temporal-Thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Like in Cyc, this is something which has a temporal extent.</para>
    /// labels<para>Temporal Thing</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#Temporal-Thing">http://www.aktors.org/ontology/support#Temporal-Thing</seealso>
    let Temporal_Thing = Prefixed_Name(akts, "Temporal-Thing") |> PrefixedName
    /// <summary>
    ///   <para>akts:Day</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Day</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#Day">http://www.aktors.org/ontology/support#Day</seealso>
    let Day = Prefixed_Name(akts, "Day") |> PrefixedName
    /// <summary>
    ///   <para>akts:Time-Interval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An interval is defined by two time points or a duration. Classes of intervals, e.g., a day, can be defined by specifying only a duration.  A time interval has no gaps</para>
    /// labels<para>Time Interval</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#Time-Interval">http://www.aktors.org/ontology/support#Time-Interval</seealso>
    let Time_Interval = Prefixed_Name(akts, "Time-Interval") |> PrefixedName
    /// <summary>
    ///   <para>akts:Physical-Quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>SUO: Physical Quantities are distinguished from Numbers by the fact that the former are associated with a dimension of measurement.</para>
    /// labels<para>Physical Quantity</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#Physical-Quantity">http://www.aktors.org/ontology/support#Physical-Quantity</seealso>
    let Physical_Quantity = Prefixed_Name(akts, "Physical-Quantity") |> PrefixedName
    /// <summary>
    ///   <para>akts:Month</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Month</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#Month">http://www.aktors.org/ontology/support#Month</seealso>
    let Month = Prefixed_Name(akts, "Month") |> PrefixedName
    /// <summary>
    ///   <para>akts:has-duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has duration</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#has-duration">http://www.aktors.org/ontology/support#has-duration</seealso>
    let has_duration = Prefixed_Name(akts, "has-duration") |> PrefixedName
    /// <summary>
    ///   <para>akts:Time-Measure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of all unit of measures used to measure time, e.g., minute, second, hour, etc.</para>
    /// labels<para>Time Measure</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#Time-Measure">http://www.aktors.org/ontology/support#Time-Measure</seealso>
    let Time_Measure = Prefixed_Name(akts, "Time-Measure") |> PrefixedName
    /// <summary>
    ///   <para>akts:Intangible-Thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This comes from HPKB upper level. The collection of things that are not physical - are not made of, or encoded in, matter. Every Collection is an Intangible (even if its instances are tangible), and so are some Individuals. Caution: do not confuse `tangibility' with `perceivability' - humans can perceive light even though it's intangible - at least in a sense.</para>
    /// labels<para>Intangible Thing</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#Intangible-Thing">http://www.aktors.org/ontology/support#Intangible-Thing</seealso>
    let Intangible_Thing = Prefixed_Name(akts, "Intangible-Thing") |> PrefixedName

    /// <summary>
    ///   <para>akts:twentyfour-hour-duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>akts:Duration</para>
    ///
    /// labels<para>24 hour duration</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#twentyfour-hour-duration">http://www.aktors.org/ontology/support#twentyfour-hour-duration</seealso>
    let twentyfour_hour_duration =
        Prefixed_Name(akts, "twentyfour-hour-duration") |> PrefixedName

    /// <summary>
    ///   <para>akts:Tangible-Thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Something which is not intangible, something which is physical, made of matter. It does not matter whether things are real of imaginary.  Therefore we consider Mickey Mouse's car and a hippogriff as  tangible things</para>
    /// labels<para>Tangible Thing</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#Tangible-Thing">http://www.aktors.org/ontology/support#Tangible-Thing</seealso>
    let Tangible_Thing = Prefixed_Name(akts, "Tangible-Thing") |> PrefixedName
    /// <summary>
    ///   <para>akts:Time-Position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A time position is either a time interval or a time point. Any time position is relative to a time zone</para>
    /// labels<para>Time Position</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#Time-Position">http://www.aktors.org/ontology/support#Time-Position</seealso>
    let Time_Position = Prefixed_Name(akts, "Time-Position") |> PrefixedName
    /// <summary>
    ///   <para>akts:Unit-Of-Measure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any kind of unit of measure, metre, dollar, kilogram, etc.</para>
    /// labels<para>Unit of Measure</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#Unit-Of-Measure">http://www.aktors.org/ontology/support#Unit-Of-Measure</seealso>
    let Unit_Of_Measure = Prefixed_Name(akts, "Unit-Of-Measure") |> PrefixedName
    /// <summary>
    ///   <para>akts:Week</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Week</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#Week">http://www.aktors.org/ontology/support#Week</seealso>
    let Week = Prefixed_Name(akts, "Week") |> PrefixedName
    /// <summary>
    ///   <para>akts:Year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Year</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#Year">http://www.aktors.org/ontology/support#Year</seealso>
    let Year = Prefixed_Name(akts, "Year") |> PrefixedName
    /// <summary>
    ///   <para>akts:seven-day-duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>akts:Duration</para>
    ///
    /// labels<para>7 day duration</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#seven-day-duration">http://www.aktors.org/ontology/support#seven-day-duration</seealso>
    let seven_day_duration = Prefixed_Name(akts, "seven-day-duration") |> PrefixedName

    /// <summary>
    ///   <para>akts:begins-at-time-point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>begins at time point</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#begins-at-time-point">http://www.aktors.org/ontology/support#begins-at-time-point</seealso>
    let begins_at_time_point =
        Prefixed_Name(akts, "begins-at-time-point") |> PrefixedName

    /// <summary>
    ///   <para>akts:ends-at-time-point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ends at time point</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#ends-at-time-point">http://www.aktors.org/ontology/support#ends-at-time-point</seealso>
    let ends_at_time_point = Prefixed_Name(akts, "ends-at-time-point") |> PrefixedName
    /// <summary>
    ///   <para>akts:has-pretty-name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A human readable name</para>
    /// labels<para>has pretty name</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#has-pretty-name">http://www.aktors.org/ontology/support#has-pretty-name</seealso>
    let has_pretty_name = Prefixed_Name(akts, "has-pretty-name") |> PrefixedName
    /// <summary>
    ///   <para>akts:has-variant-name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Other variants of the human readable name</para>
    /// labels<para>has variant name</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#has-variant-name">http://www.aktors.org/ontology/support#has-variant-name</seealso>
    let has_variant_name = Prefixed_Name(akts, "has-variant-name") |> PrefixedName
    /// <summary>
    ///   <para>akts:in-timezone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>in timezone</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#in-timezone">http://www.aktors.org/ontology/support#in-timezone</seealso>
    let in_timezone = Prefixed_Name(akts, "in-timezone") |> PrefixedName
    /// <summary>
    ///   <para>akts:thirty-day-duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>akts:Duration</para>
    ///
    /// labels<para>30 day duration</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#thirty-day-duration">http://www.aktors.org/ontology/support#thirty-day-duration</seealso>
    let thirty_day_duration = Prefixed_Name(akts, "thirty-day-duration") |> PrefixedName
    /// <summary>
    ///   <para>akts:has-time-interval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has time interval</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#has-time-interval">http://www.aktors.org/ontology/support#has-time-interval</seealso>
    let has_time_interval = Prefixed_Name(akts, "has-time-interval") |> PrefixedName
    /// <summary>
    ///   <para>akts:time-measure-day</para>
    /// </summary>
    /// <remarks>
    ///   <para>akts:Time-Measure</para>
    ///
    /// labels<para>day</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#time-measure-day">http://www.aktors.org/ontology/support#time-measure-day</seealso>
    let time_measure_day = Prefixed_Name(akts, "time-measure-day") |> PrefixedName
    /// <summary>
    ///   <para>akts:time-measure-hour</para>
    /// </summary>
    /// <remarks>
    ///   <para>akts:Time-Measure</para>
    ///
    /// labels<para>hour</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#time-measure-hour">http://www.aktors.org/ontology/support#time-measure-hour</seealso>
    let time_measure_hour = Prefixed_Name(akts, "time-measure-hour") |> PrefixedName
    /// <summary>
    ///   <para>akts:time-measure-year</para>
    /// </summary>
    /// <remarks>
    ///   <para>akts:Time-Measure</para>
    ///
    /// labels<para>year</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#time-measure-year">http://www.aktors.org/ontology/support#time-measure-year</seealso>
    let time_measure_year = Prefixed_Name(akts, "time-measure-year") |> PrefixedName
    /// <summary>
    ///   <para>akts:time-measure-month</para>
    /// </summary>
    /// <remarks>
    ///   <para>akts:Time-Measure</para>
    ///
    /// labels<para>month</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#time-measure-month">http://www.aktors.org/ontology/support#time-measure-month</seealso>
    let time_measure_month = Prefixed_Name(akts, "time-measure-month") |> PrefixedName

    /// <summary>
    ///   <para>akts:twentynine-day-duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>akts:Duration</para>
    ///
    /// labels<para>29 day duration</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#twentynine-day-duration">http://www.aktors.org/ontology/support#twentynine-day-duration</seealso>
    let twentynine_day_duration =
        Prefixed_Name(akts, "twentynine-day-duration") |> PrefixedName

    /// <summary>
    ///   <para>akts:twelve-month-duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>akts:Duration</para>
    ///
    /// labels<para>12 month duration</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#twelve-month-duration">http://www.aktors.org/ontology/support#twelve-month-duration</seealso>
    let twelve_month_duration =
        Prefixed_Name(akts, "twelve-month-duration") |> PrefixedName

    /// <summary>
    ///   <para>akts:has-magnitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has magnitude</para></remarks>
    /// <seealso href="http://www.aktors.org/ontology/support#has-magnitude">http://www.aktors.org/ontology/support#has-magnitude</seealso>
    let has_magnitude = Prefixed_Name(akts, "has-magnitude") |> PrefixedName
