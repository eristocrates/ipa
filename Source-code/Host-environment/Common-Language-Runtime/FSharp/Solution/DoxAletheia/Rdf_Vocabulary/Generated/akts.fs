namespace http.www.aktors.org.ontology.support.hash

open DoxAletheia.Rdf_Vocabulary

module akts =
    let _namespace_name = "http://www.aktors.org/ontology/support#"

    /// <summary>
    /// A point in time
    /// <see href="http://www.aktors.org/ontology/support#Calendar-Date"></see></summary>
    let ``Calendar-Date`` =
        Namespaced_IRI.parse _namespace_name "Calendar-Date" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#day-of"></see>
    /// </summary>
    let ``day-of`` = Namespaced_IRI.parse _namespace_name "day-of" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#hour-of"></see>
    /// </summary>
    let ``hour-of`` = Namespaced_IRI.parse _namespace_name "hour-of" |> NamespacedName

    /// <summary>
    /// A point in time
    /// <see href="http://www.aktors.org/ontology/support#Time-Point"></see></summary>
    let ``Time-Point`` =
        Namespaced_IRI.parse _namespace_name "Time-Point" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#year-of"></see>
    /// </summary>
    let ``year-of`` = Namespaced_IRI.parse _namespace_name "year-of" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#month-of"></see>
    /// </summary>
    let ``month-of`` = Namespaced_IRI.parse _namespace_name "month-of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#minute-of"></see>
    /// </summary>
    let ``minute-of`` =
        Namespaced_IRI.parse _namespace_name "minute-of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#second-of"></see>
    /// </summary>
    let ``second-of`` =
        Namespaced_IRI.parse _namespace_name "second-of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#Day"></see>
    /// </summary>
    let Day = Namespaced_IRI.parse _namespace_name "Day" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#twentyfour-hour-duration"></see>
    /// </summary>
    let ``twentyfour-hour-duration`` =
        Namespaced_IRI.parse _namespace_name "twentyfour-hour-duration" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#has-duration"></see>
    /// </summary>
    let ``has-duration`` =
        Namespaced_IRI.parse _namespace_name "has-duration" |> NamespacedName

    /// <summary>
    /// An interval is defined by two time points or a duration. Classes of intervals, e.g., a day, can be defined by specifying only a duration.  A time interval has no gaps
    /// <see href="http://www.aktors.org/ontology/support#Time-Interval"></see></summary>
    let ``Time-Interval`` =
        Namespaced_IRI.parse _namespace_name "Time-Interval" |> NamespacedName

    /// <summary>
    /// A measure of time, e.g., 5 hours
    /// <see href="http://www.aktors.org/ontology/support#Duration"></see></summary>
    let Duration = Namespaced_IRI.parse _namespace_name "Duration" |> NamespacedName

    /// <summary>
    /// The class of all unit of measures used to measure time, e.g., minute, second, hour, etc.
    /// <see href="http://www.aktors.org/ontology/support#Time-Measure"></see></summary>
    let ``Time-Measure`` =
        Namespaced_IRI.parse _namespace_name "Time-Measure" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#has-unit-of-measure"></see>
    /// </summary>
    let ``has-unit-of-measure`` =
        Namespaced_IRI.parse _namespace_name "has-unit-of-measure" |> NamespacedName

    /// <summary>
    /// SUO: Physical Quantities are distinguished from Numbers by the fact that the former are associated with a dimension of measurement.
    /// <see href="http://www.aktors.org/ontology/support#Physical-Quantity"></see></summary>
    let ``Physical-Quantity`` =
        Namespaced_IRI.parse _namespace_name "Physical-Quantity" |> NamespacedName

    /// <summary>
    /// This comes from HPKB upper level. The collection of things that are not physical - are not made of, or encoded in, matter. Every Collection is an Intangible (even if its instances are tangible), and so are some Individuals. Caution: do not confuse `tangibility' with `perceivability' - humans can perceive light even though it's intangible - at least in a sense.
    /// <see href="http://www.aktors.org/ontology/support#Intangible-Thing"></see></summary>
    let ``Intangible-Thing`` =
        Namespaced_IRI.parse _namespace_name "Intangible-Thing" |> NamespacedName

    /// <summary>
    /// This is the top-level concept in the AKT reference ontology
    /// <see href="http://www.aktors.org/ontology/support#Thing"></see></summary>
    let Thing = Namespaced_IRI.parse _namespace_name "Thing" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#Month"></see>
    /// </summary>
    let Month = Namespaced_IRI.parse _namespace_name "Month" |> NamespacedName
    /// <summary>
    /// From SUO: Any specification of how many or how much of something there is. Accordingly, there are two subclasses of Quantity: Number (how many) and Physical-Quantity (how much).
    /// <see href="http://www.aktors.org/ontology/support#Quantity"></see></summary>
    let Quantity = Namespaced_IRI.parse _namespace_name "Quantity" |> NamespacedName

    /// <summary>
    /// Something which is not intangible, something which is physical, made of matter. It does not matter whether things are real of imaginary.  Therefore we consider Mickey Mouse's car and a hippogriff as  tangible things
    /// <see href="http://www.aktors.org/ontology/support#Tangible-Thing"></see></summary>
    let ``Tangible-Thing`` =
        Namespaced_IRI.parse _namespace_name "Tangible-Thing" |> NamespacedName

    /// <summary>
    /// Like in Cyc, this is something which has a temporal extent.
    /// <see href="http://www.aktors.org/ontology/support#Temporal-Thing"></see></summary>
    let ``Temporal-Thing`` =
        Namespaced_IRI.parse _namespace_name "Temporal-Thing" |> NamespacedName

    /// <summary>
    /// A time position is either a time interval or a time point. Any time position is relative to a time zone
    /// <see href="http://www.aktors.org/ontology/support#Time-Position"></see></summary>
    let ``Time-Position`` =
        Namespaced_IRI.parse _namespace_name "Time-Position" |> NamespacedName

    /// <summary>
    /// Any kind of unit of measure, metre, dollar, kilogram, etc.
    /// <see href="http://www.aktors.org/ontology/support#Unit-Of-Measure"></see></summary>
    let ``Unit-Of-Measure`` =
        Namespaced_IRI.parse _namespace_name "Unit-Of-Measure" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#Week"></see>
    /// </summary>
    let Week = Namespaced_IRI.parse _namespace_name "Week" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#seven-day-duration"></see>
    /// </summary>
    let ``seven-day-duration`` =
        Namespaced_IRI.parse _namespace_name "seven-day-duration" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#Year"></see>
    /// </summary>
    let Year = Namespaced_IRI.parse _namespace_name "Year" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#twelve-month-duration"></see>
    /// </summary>
    let ``twelve-month-duration`` =
        Namespaced_IRI.parse _namespace_name "twelve-month-duration" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#begins-at-time-point"></see>
    /// </summary>
    let ``begins-at-time-point`` =
        Namespaced_IRI.parse _namespace_name "begins-at-time-point" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#ends-at-time-point"></see>
    /// </summary>
    let ``ends-at-time-point`` =
        Namespaced_IRI.parse _namespace_name "ends-at-time-point" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#has-magnitude"></see>
    /// </summary>
    let ``has-magnitude`` =
        Namespaced_IRI.parse _namespace_name "has-magnitude" |> NamespacedName

    /// <summary>
    /// A human readable name
    /// <see href="http://www.aktors.org/ontology/support#has-pretty-name"></see></summary>
    let ``has-pretty-name`` =
        Namespaced_IRI.parse _namespace_name "has-pretty-name" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#has-time-interval"></see>
    /// </summary>
    let ``has-time-interval`` =
        Namespaced_IRI.parse _namespace_name "has-time-interval" |> NamespacedName

    /// <summary>
    /// Other variants of the human readable name
    /// <see href="http://www.aktors.org/ontology/support#has-variant-name"></see></summary>
    let ``has-variant-name`` =
        Namespaced_IRI.parse _namespace_name "has-variant-name" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#in-timezone"></see>
    /// </summary>
    let ``in-timezone`` =
        Namespaced_IRI.parse _namespace_name "in-timezone" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#time-measure-day"></see>
    /// </summary>
    let ``time-measure-day`` =
        Namespaced_IRI.parse _namespace_name "time-measure-day" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#thirty-day-duration"></see>
    /// </summary>
    let ``thirty-day-duration`` =
        Namespaced_IRI.parse _namespace_name "thirty-day-duration" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#thirtyone-day-duration"></see>
    /// </summary>
    let ``thirtyone-day-duration`` =
        Namespaced_IRI.parse _namespace_name "thirtyone-day-duration" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#time-measure-hour"></see>
    /// </summary>
    let ``time-measure-hour`` =
        Namespaced_IRI.parse _namespace_name "time-measure-hour" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#time-measure-minute"></see>
    /// </summary>
    let ``time-measure-minute`` =
        Namespaced_IRI.parse _namespace_name "time-measure-minute" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#time-measure-month"></see>
    /// </summary>
    let ``time-measure-month`` =
        Namespaced_IRI.parse _namespace_name "time-measure-month" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#time-measure-second"></see>
    /// </summary>
    let ``time-measure-second`` =
        Namespaced_IRI.parse _namespace_name "time-measure-second" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#time-measure-year"></see>
    /// </summary>
    let ``time-measure-year`` =
        Namespaced_IRI.parse _namespace_name "time-measure-year" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#twentyeight-day-duration"></see>
    /// </summary>
    let ``twentyeight-day-duration`` =
        Namespaced_IRI.parse _namespace_name "twentyeight-day-duration" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/support#twentynine-day-duration"></see>
    /// </summary>
    let ``twentynine-day-duration`` =
        Namespaced_IRI.parse _namespace_name "twentynine-day-duration" |> NamespacedName
