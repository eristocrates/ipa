#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module akts =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.aktors.org/ontology/support#" "akts"

    /// <summary>
    ///   <para>rdfs:label : Calendar Date^^xsd:string</para>
    ///   <para>rdfs:comment : A point in time^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#Calendar-Date">akts:Calendar-Date</a>
    /// </summary>
    let Calendar_Date = _prefixId.prefix "Calendar-Date"
    /// <summary>
    ///   <para>rdfs:label : Day^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#Day">akts:Day</a>
    /// </summary>
    let Day = _prefixId.prefix "Day"
    /// <summary>
    ///   <para>rdfs:comment : A measure of time, e.g., 5 hours^^xsd:string</para>
    ///   <para>rdfs:label : Duration^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#Duration">akts:Duration</a>
    /// </summary>
    let Duration = _prefixId.prefix "Duration"
    /// <summary>
    ///   <para>rdfs:comment : This comes from HPKB upper level. The collection of things that are not physical - are not made of, or encoded in, matter. Every Collection is an Intangible (even if its instances are tangible), and so are some Individuals. Caution: do not confuse `tangibility' with `perceivability' - humans can perceive light even though it's intangible - at least in a sense.^^xsd:string</para>
    ///   <para>rdfs:label : Intangible Thing^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#Intangible-Thing">akts:Intangible-Thing</a>
    /// </summary>
    let Intangible_Thing = _prefixId.prefix "Intangible-Thing"
    /// <summary>
    ///   <para>rdfs:label : Month^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#Month">akts:Month</a>
    /// </summary>
    let Month = _prefixId.prefix "Month"
    /// <summary>
    ///   <para>rdfs:comment : SUO: Physical Quantities are distinguished from Numbers by the fact that the former are associated with a dimension of measurement.^^xsd:string</para>
    ///   <para>rdfs:label : Physical Quantity^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#Physical-Quantity">akts:Physical-Quantity</a>
    /// </summary>
    let Physical_Quantity = _prefixId.prefix "Physical-Quantity"
    /// <summary>
    ///   <para>rdfs:comment : From SUO: Any specification of how many or how much of something there is. Accordingly, there are two subclasses of Quantity: Number (how many) and Physical-Quantity (how much).^^xsd:string</para>
    ///   <para>rdfs:label : Quantity^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#Quantity">akts:Quantity</a>
    /// </summary>
    let Quantity = _prefixId.prefix "Quantity"
    /// <summary>
    ///   <para>rdfs:comment : Something which is not intangible, something which is physical, made of matter. It does not matter whether things are real of imaginary.  Therefore we consider Mickey Mouse's car and a hippogriff as  tangible things^^xsd:string</para>
    ///   <para>rdfs:label : Tangible Thing^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#Tangible-Thing">akts:Tangible-Thing</a>
    /// </summary>
    let Tangible_Thing = _prefixId.prefix "Tangible-Thing"
    /// <summary>
    ///   <para>rdfs:comment : Like in Cyc, this is something which has a temporal extent.^^xsd:string</para>
    ///   <para>rdfs:label : Temporal Thing^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#Temporal-Thing">akts:Temporal-Thing</a>
    /// </summary>
    let Temporal_Thing = _prefixId.prefix "Temporal-Thing"
    /// <summary>
    ///   <para>rdfs:comment : This is the top-level concept in the AKT reference ontology^^xsd:string</para>
    ///   <para>rdfs:label : Thing^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#Thing">akts:Thing</a>
    /// </summary>
    let Thing = _prefixId.prefix "Thing"
    /// <summary>
    ///   <para>rdfs:comment : An interval is defined by two time points or a duration. Classes of intervals, e.g., a day, can be defined by specifying only a duration.  A time interval has no gaps^^xsd:string</para>
    ///   <para>rdfs:label : Time Interval^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#Time-Interval">akts:Time-Interval</a>
    /// </summary>
    let Time_Interval = _prefixId.prefix "Time-Interval"
    /// <summary>
    ///   <para>rdfs:comment : The class of all unit of measures used to measure time, e.g., minute, second, hour, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Time Measure^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#Time-Measure">akts:Time-Measure</a>
    /// </summary>
    let Time_Measure = _prefixId.prefix "Time-Measure"
    /// <summary>
    ///   <para>rdfs:comment : A point in time^^xsd:string</para>
    ///   <para>rdfs:label : Time Point^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#Time-Point">akts:Time-Point</a>
    /// </summary>
    let Time_Point = _prefixId.prefix "Time-Point"
    /// <summary>
    ///   <para>rdfs:comment : A time position is either a time interval or a time point. Any time position is relative to a time zone^^xsd:string</para>
    ///   <para>rdfs:label : Time Position^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#Time-Position">akts:Time-Position</a>
    /// </summary>
    let Time_Position = _prefixId.prefix "Time-Position"
    /// <summary>
    ///   <para>rdfs:comment : Any kind of unit of measure, metre, dollar, kilogram, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Unit of Measure^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#Unit-Of-Measure">akts:Unit-Of-Measure</a>
    /// </summary>
    let Unit_Of_Measure = _prefixId.prefix "Unit-Of-Measure"
    /// <summary>
    ///   <para>rdfs:label : Week^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#Week">akts:Week</a>
    /// </summary>
    let Week = _prefixId.prefix "Week"
    /// <summary>
    ///   <para>rdfs:label : Year^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#Year">akts:Year</a>
    /// </summary>
    let Year = _prefixId.prefix "Year"
    /// <summary>
    ///   <para>rdfs:label : begins at time point^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#begins-at-time-point">akts:begins-at-time-point</a>
    /// </summary>
    let begins_at_time_point = _prefixId.prefix "begins-at-time-point"
    /// <summary>
    ///   <para>rdfs:label : day of^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#day-of">akts:day-of</a>
    /// </summary>
    let day_of = _prefixId.prefix "day-of"
    /// <summary>
    ///   <para>rdfs:label : ends at time point^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#ends-at-time-point">akts:ends-at-time-point</a>
    /// </summary>
    let ends_at_time_point = _prefixId.prefix "ends-at-time-point"
    /// <summary>
    ///   <para>rdfs:label : has duration^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#has-duration">akts:has-duration</a>
    /// </summary>
    let has_duration = _prefixId.prefix "has-duration"
    /// <summary>
    ///   <para>rdfs:label : has magnitude^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#has-magnitude">akts:has-magnitude</a>
    /// </summary>
    let has_magnitude = _prefixId.prefix "has-magnitude"
    /// <summary>
    ///   <para>rdfs:comment : A human readable name^^xsd:string</para>
    ///   <para>rdfs:label : has pretty name^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#has-pretty-name">akts:has-pretty-name</a>
    /// </summary>
    let has_pretty_name = _prefixId.prefix "has-pretty-name"
    /// <summary>
    ///   <para>rdfs:label : has time interval^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#has-time-interval">akts:has-time-interval</a>
    /// </summary>
    let has_time_interval = _prefixId.prefix "has-time-interval"
    /// <summary>
    ///   <para>rdfs:label : has unit of measure^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#has-unit-of-measure">akts:has-unit-of-measure</a>
    /// </summary>
    let has_unit_of_measure = _prefixId.prefix "has-unit-of-measure"
    /// <summary>
    ///   <para>rdfs:comment : Other variants of the human readable name^^xsd:string</para>
    ///   <para>rdfs:label : has variant name^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#has-variant-name">akts:has-variant-name</a>
    /// </summary>
    let has_variant_name = _prefixId.prefix "has-variant-name"
    /// <summary>
    ///   <para>rdfs:label : hour of^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#hour-of">akts:hour-of</a>
    /// </summary>
    let hour_of = _prefixId.prefix "hour-of"
    /// <summary>
    ///   <para>rdfs:label : in timezone^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#in-timezone">akts:in-timezone</a>
    /// </summary>
    let in_timezone = _prefixId.prefix "in-timezone"
    /// <summary>
    ///   <para>rdfs:label : minute of^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#minute-of">akts:minute-of</a>
    /// </summary>
    let minute_of = _prefixId.prefix "minute-of"
    /// <summary>
    ///   <para>rdfs:label : month of^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#month-of">akts:month-of</a>
    /// </summary>
    let month_of = _prefixId.prefix "month-of"
    /// <summary>
    ///   <para>rdfs:label : second of^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#second-of">akts:second-of</a>
    /// </summary>
    let second_of = _prefixId.prefix "second-of"
    let seven_day_duration = _prefixId.prefix "seven-day-duration"
    let thirty_day_duration = _prefixId.prefix "thirty-day-duration"
    let thirtyone_day_duration = _prefixId.prefix "thirtyone-day-duration"
    let time_measure_day = _prefixId.prefix "time-measure-day"
    let time_measure_hour = _prefixId.prefix "time-measure-hour"
    let time_measure_minute = _prefixId.prefix "time-measure-minute"
    let time_measure_month = _prefixId.prefix "time-measure-month"
    let time_measure_second = _prefixId.prefix "time-measure-second"
    let time_measure_year = _prefixId.prefix "time-measure-year"
    let twelve_month_duration = _prefixId.prefix "twelve-month-duration"
    let twentyeight_day_duration = _prefixId.prefix "twentyeight-day-duration"
    let twentyfour_hour_duration = _prefixId.prefix "twentyfour-hour-duration"
    let twentynine_day_duration = _prefixId.prefix "twentynine-day-duration"
    /// <summary>
    ///   <para>rdfs:label : year of^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/support#year-of">akts:year-of</a>
    /// </summary>
    let year_of = _prefixId.prefix "year-of"
