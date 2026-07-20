namespace http.www.aktors.org.ontology.support.hash

open DoxAletheia

module akts =
    let _namespace_name = "http://www.aktors.org/ontology/support#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A point in time
    /// <see href="http://www.aktors.org/ontology/support#Calendar-Date"></see></summary>
    let ``Calendar-Date`` = _prefix "Calendar-Date"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#day-of"></see>
    /// </summary>
    let ``day-of`` = _prefix "day-of"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#hour-of"></see>
    /// </summary>
    let ``hour-of`` = _prefix "hour-of"
    /// <summary>
    /// A point in time
    /// <see href="http://www.aktors.org/ontology/support#Time-Point"></see></summary>
    let ``Time-Point`` = _prefix "Time-Point"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#year-of"></see>
    /// </summary>
    let ``year-of`` = _prefix "year-of"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#month-of"></see>
    /// </summary>
    let ``month-of`` = _prefix "month-of"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#minute-of"></see>
    /// </summary>
    let ``minute-of`` = _prefix "minute-of"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#second-of"></see>
    /// </summary>
    let ``second-of`` = _prefix "second-of"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#Day"></see>
    /// </summary>
    let Day = _prefix "Day"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#twentyfour-hour-duration"></see>
    /// </summary>
    let ``twentyfour-hour-duration`` = _prefix "twentyfour-hour-duration"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#has-duration"></see>
    /// </summary>
    let ``has-duration`` = _prefix "has-duration"
    /// <summary>
    /// An interval is defined by two time points or a duration. Classes of intervals, e.g., a day, can be defined by specifying only a duration.  A time interval has no gaps
    /// <see href="http://www.aktors.org/ontology/support#Time-Interval"></see></summary>
    let ``Time-Interval`` = _prefix "Time-Interval"
    /// <summary>
    /// A measure of time, e.g., 5 hours
    /// <see href="http://www.aktors.org/ontology/support#Duration"></see></summary>
    let Duration = _prefix "Duration"
    /// <summary>
    /// The class of all unit of measures used to measure time, e.g., minute, second, hour, etc.
    /// <see href="http://www.aktors.org/ontology/support#Time-Measure"></see></summary>
    let ``Time-Measure`` = _prefix "Time-Measure"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#has-unit-of-measure"></see>
    /// </summary>
    let ``has-unit-of-measure`` = _prefix "has-unit-of-measure"
    /// <summary>
    /// SUO: Physical Quantities are distinguished from Numbers by the fact that the former are associated with a dimension of measurement.
    /// <see href="http://www.aktors.org/ontology/support#Physical-Quantity"></see></summary>
    let ``Physical-Quantity`` = _prefix "Physical-Quantity"
    /// <summary>
    /// This comes from HPKB upper level. The collection of things that are not physical - are not made of, or encoded in, matter. Every Collection is an Intangible (even if its instances are tangible), and so are some Individuals. Caution: do not confuse `tangibility' with `perceivability' - humans can perceive light even though it's intangible - at least in a sense.
    /// <see href="http://www.aktors.org/ontology/support#Intangible-Thing"></see></summary>
    let ``Intangible-Thing`` = _prefix "Intangible-Thing"
    /// <summary>
    /// This is the top-level concept in the AKT reference ontology
    /// <see href="http://www.aktors.org/ontology/support#Thing"></see></summary>
    let Thing = _prefix "Thing"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#Month"></see>
    /// </summary>
    let Month = _prefix "Month"
    /// <summary>
    /// From SUO: Any specification of how many or how much of something there is. Accordingly, there are two subclasses of Quantity: Number (how many) and Physical-Quantity (how much).
    /// <see href="http://www.aktors.org/ontology/support#Quantity"></see></summary>
    let Quantity = _prefix "Quantity"
    /// <summary>
    /// Something which is not intangible, something which is physical, made of matter. It does not matter whether things are real of imaginary.  Therefore we consider Mickey Mouse's car and a hippogriff as  tangible things
    /// <see href="http://www.aktors.org/ontology/support#Tangible-Thing"></see></summary>
    let ``Tangible-Thing`` = _prefix "Tangible-Thing"
    /// <summary>
    /// Like in Cyc, this is something which has a temporal extent.
    /// <see href="http://www.aktors.org/ontology/support#Temporal-Thing"></see></summary>
    let ``Temporal-Thing`` = _prefix "Temporal-Thing"
    /// <summary>
    /// A time position is either a time interval or a time point. Any time position is relative to a time zone
    /// <see href="http://www.aktors.org/ontology/support#Time-Position"></see></summary>
    let ``Time-Position`` = _prefix "Time-Position"
    /// <summary>
    /// Any kind of unit of measure, metre, dollar, kilogram, etc.
    /// <see href="http://www.aktors.org/ontology/support#Unit-Of-Measure"></see></summary>
    let ``Unit-Of-Measure`` = _prefix "Unit-Of-Measure"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#Week"></see>
    /// </summary>
    let Week = _prefix "Week"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#seven-day-duration"></see>
    /// </summary>
    let ``seven-day-duration`` = _prefix "seven-day-duration"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#Year"></see>
    /// </summary>
    let Year = _prefix "Year"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#twelve-month-duration"></see>
    /// </summary>
    let ``twelve-month-duration`` = _prefix "twelve-month-duration"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#begins-at-time-point"></see>
    /// </summary>
    let ``begins-at-time-point`` = _prefix "begins-at-time-point"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#ends-at-time-point"></see>
    /// </summary>
    let ``ends-at-time-point`` = _prefix "ends-at-time-point"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#has-magnitude"></see>
    /// </summary>
    let ``has-magnitude`` = _prefix "has-magnitude"
    /// <summary>
    /// A human readable name
    /// <see href="http://www.aktors.org/ontology/support#has-pretty-name"></see></summary>
    let ``has-pretty-name`` = _prefix "has-pretty-name"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#has-time-interval"></see>
    /// </summary>
    let ``has-time-interval`` = _prefix "has-time-interval"
    /// <summary>
    /// Other variants of the human readable name
    /// <see href="http://www.aktors.org/ontology/support#has-variant-name"></see></summary>
    let ``has-variant-name`` = _prefix "has-variant-name"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#in-timezone"></see>
    /// </summary>
    let ``in-timezone`` = _prefix "in-timezone"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#time-measure-day"></see>
    /// </summary>
    let ``time-measure-day`` = _prefix "time-measure-day"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#thirty-day-duration"></see>
    /// </summary>
    let ``thirty-day-duration`` = _prefix "thirty-day-duration"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#thirtyone-day-duration"></see>
    /// </summary>
    let ``thirtyone-day-duration`` = _prefix "thirtyone-day-duration"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#time-measure-hour"></see>
    /// </summary>
    let ``time-measure-hour`` = _prefix "time-measure-hour"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#time-measure-minute"></see>
    /// </summary>
    let ``time-measure-minute`` = _prefix "time-measure-minute"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#time-measure-month"></see>
    /// </summary>
    let ``time-measure-month`` = _prefix "time-measure-month"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#time-measure-second"></see>
    /// </summary>
    let ``time-measure-second`` = _prefix "time-measure-second"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#time-measure-year"></see>
    /// </summary>
    let ``time-measure-year`` = _prefix "time-measure-year"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#twentyeight-day-duration"></see>
    /// </summary>
    let ``twentyeight-day-duration`` = _prefix "twentyeight-day-duration"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#twentynine-day-duration"></see>
    /// </summary>
    let ``twentynine-day-duration`` = _prefix "twentynine-day-duration"
