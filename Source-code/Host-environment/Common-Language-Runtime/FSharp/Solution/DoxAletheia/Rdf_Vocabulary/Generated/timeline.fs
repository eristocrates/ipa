namespace http.purl.org.NET.c4dm.timeline.owl.hash

open DoxAletheia.Rdf_Vocabulary

module timeline =
    let _namespace_name = "http://purl.org/NET/c4dm/timeline.owl#"

    /// <summary>
    /// An instant defined on an abstract timeline
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#AbstractInstant"></see></summary>
    let AbstractInstant =
        Namespaced_IRI.parse _namespace_name "AbstractInstant" |> NamespacedName

    /// <summary>
    /// An instant (same as in OWL-Time)
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#Instant"></see></summary>
    let Instant = Namespaced_IRI.parse _namespace_name "Instant" |> NamespacedName
    /// <summary>
    ///
    /// 	Relates an interval or an instant to the timeline on which it is defined.
    ///
    /// 	The 29th of August, 2007 would be linked through this property to the universal timeline, whereas
    /// 	"from 2s to 5s on this particular signal" would be defined on the signal' timeline.
    ///
    ///
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#timeline"></see></summary>
    let timeline = Namespaced_IRI.parse _namespace_name "timeline" |> NamespacedName

    /// <summary>
    ///
    ///     	Abstract time lines may be used as a backbone for Score, Works, ...
    /// 	This allows for TimeLine maps to relate works to a given
    /// 	performance (this part was played at this time).
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#AbstractTimeLine"></see></summary>
    let AbstractTimeLine =
        Namespaced_IRI.parse _namespace_name "AbstractTimeLine" |> NamespacedName

    /// <summary>
    ///
    /// 	An interval defined on an abstract time-line.
    ///
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#AbstractInterval"></see></summary>
    let AbstractInterval =
        Namespaced_IRI.parse _namespace_name "AbstractInterval" |> NamespacedName

    /// <summary>
    /// An interval (same as in OWL-Time). Allen's relationships are defined in OWL-Time.
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#Interval"></see></summary>
    let Interval = Namespaced_IRI.parse _namespace_name "Interval" |> NamespacedName
    /// <summary>
    /// Represents a linear and coherent piece of time -- can be either abstract (such as the one behind a score) or concrete (such as the universal time line).
    /// Two timelines can be mapped using timeline maps.
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#TimeLine"></see></summary>
    let TimeLine = Namespaced_IRI.parse _namespace_name "TimeLine" |> NamespacedName

    /// <summary>
    /// A continuous timeline, like the universal one, or the one backing an analog signal
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#ContinuousTimeLine"></see></summary>
    let ContinuousTimeLine =
        Namespaced_IRI.parse _namespace_name "ContinuousTimeLine" |> NamespacedName

    /// <summary>
    /// A discrete time line (like the time line backing a digital signal
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#DiscreteTimeLine"></see></summary>
    let DiscreteTimeLine =
        Namespaced_IRI.parse _namespace_name "DiscreteTimeLine" |> NamespacedName

    /// <summary>
    /// A "physical" time-line (the universal time line (UTC)) is an instance of this class. Other time zones consists in instances of this class as well, with a "shifting" time line map relating them to the universal time line map.
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#PhysicalTimeLine"></see></summary>
    let PhysicalTimeLine =
        Namespaced_IRI.parse _namespace_name "PhysicalTimeLine" |> NamespacedName

    /// <summary>
    /// Semi infinite time line...canonical coordinate system --&gt; adressed through xsd:duration since the instant 0.
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#RelativeTimeLine"></see></summary>
    let RelativeTimeLine =
        Namespaced_IRI.parse _namespace_name "RelativeTimeLine" |> NamespacedName

    /// <summary>
    /// An instant defined on a discrete timeline
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#DiscreteInstant"></see></summary>
    let DiscreteInstant =
        Namespaced_IRI.parse _namespace_name "DiscreteInstant" |> NamespacedName

    /// <summary>
    /// A subproperty of :at, having as a specific range xsd:int
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#atInt"></see></summary>
    let atInt = Namespaced_IRI.parse _namespace_name "atInt" |> NamespacedName

    /// <summary>
    /// An interval defined on a discrete timeline, like the one backing a digital signal
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#DiscreteInterval"></see></summary>
    let DiscreteInterval =
        Namespaced_IRI.parse _namespace_name "DiscreteInterval" |> NamespacedName

    /// <summary>
    /// A subproperty of :beginsAt, having xsd:int as a range
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#beginsAtInt"></see></summary>
    let beginsAtInt =
        Namespaced_IRI.parse _namespace_name "beginsAtInt" |> NamespacedName

    /// <summary>
    /// A subproperty of :endsAt, having xsd:int as a range
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#endsAtInt"></see></summary>
    let endsAtInt = Namespaced_IRI.parse _namespace_name "endsAtInt" |> NamespacedName

    /// <summary>
    /// A subproperty of :duration, having xsd:int as a range
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#durationInt"></see></summary>
    let durationInt =
        Namespaced_IRI.parse _namespace_name "durationInt" |> NamespacedName

    /// <summary>
    /// A timeline map linking a physical timeline to a relative one (originating at some point on the physical timeline)
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#OriginMap"></see></summary>
    let OriginMap = Namespaced_IRI.parse _namespace_name "OriginMap" |> NamespacedName

    /// <summary>
    /// Allows to map two time lines together
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#TimeLineMap"></see></summary>
    let TimeLineMap =
        Namespaced_IRI.parse _namespace_name "TimeLineMap" |> NamespacedName

    /// <summary>
    /// associates a timeline map to its domain timeline
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#domainTimeLine"></see></summary>
    let domainTimeLine =
        Namespaced_IRI.parse _namespace_name "domainTimeLine" |> NamespacedName

    /// <summary>
    /// associates a timeline map to its range timeline
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#rangeTimeLine"></see></summary>
    let rangeTimeLine =
        Namespaced_IRI.parse _namespace_name "rangeTimeLine" |> NamespacedName

    /// <summary>
    /// An instant defined on a relative timeline
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#RelativeInstant"></see></summary>
    let RelativeInstant =
        Namespaced_IRI.parse _namespace_name "RelativeInstant" |> NamespacedName

    /// <summary>
    /// A property enabling to adress a time point P through the duration of the interval [0,P] on a continuous timeline
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#atDuration"></see></summary>
    let atDuration = Namespaced_IRI.parse _namespace_name "atDuration" |> NamespacedName

    /// <summary>
    /// an interval defined on a relative timeline
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#RelativeInterval"></see></summary>
    let RelativeInterval =
        Namespaced_IRI.parse _namespace_name "RelativeInterval" |> NamespacedName

    /// <summary>
    /// A property enabling to adress a start time point P of an interval [P,E] through the duration of the interval [0,P] on a continuous timeline
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#beginsAtDuration"></see></summary>
    let beginsAtDuration =
        Namespaced_IRI.parse _namespace_name "beginsAtDuration" |> NamespacedName

    /// <summary>
    /// A subproperty of :duration, having xsd:duration as a range
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#durationXSD"></see></summary>
    let durationXSD =
        Namespaced_IRI.parse _namespace_name "durationXSD" |> NamespacedName

    /// <summary>
    /// A property enabling to adress an end time point P of an interval [S,P] through the duration of the interval [0,P] on a continuous timeline
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#endsAtDuration"></see></summary>
    let endsAtDuration =
        Namespaced_IRI.parse _namespace_name "endsAtDuration" |> NamespacedName

    /// <summary>
    /// a map just shifting one timeline to another
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#ShiftMap"></see></summary>
    let ShiftMap = Namespaced_IRI.parse _namespace_name "ShiftMap" |> NamespacedName
    /// <summary>
    /// This concept expresses that an instant defined on the universal timeline must be associated to a dateTime value
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#UTInstant"></see></summary>
    let UTInstant = Namespaced_IRI.parse _namespace_name "UTInstant" |> NamespacedName
    /// <summary>
    /// This property links an instant defined on the universal time line to an XSD date/time value
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#atDateTime"></see></summary>
    let atDateTime = Namespaced_IRI.parse _namespace_name "atDateTime" |> NamespacedName

    /// <summary>
    /// this is the `universal' time line -- can adress time intervals on it using date/dateTime -- UTC
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#universaltimeline"></see></summary>
    let universaltimeline =
        Namespaced_IRI.parse _namespace_name "universaltimeline" |> NamespacedName

    /// <summary>
    /// an interval defined on the universal time line
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#UTInterval"></see></summary>
    let UTInterval = Namespaced_IRI.parse _namespace_name "UTInterval" |> NamespacedName
    /// <summary>
    /// A subproperty of :at, allowing to address a year (beginning of it for an instant, all of it for an interval)
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#atYear"></see></summary>
    let atYear = Namespaced_IRI.parse _namespace_name "atYear" |> NamespacedName

    /// <summary>
    /// A subproperty of :at, allowing to address a year/month (beginning of it for an instant, all of it for an interval)
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#atYearMonth"></see></summary>
    let atYearMonth =
        Namespaced_IRI.parse _namespace_name "atYearMonth" |> NamespacedName

    /// <summary>
    /// A subproperty of :at, allowing to address a date (beginning of it for an instant, all of it for an interval)
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#atDate"></see></summary>
    let atDate = Namespaced_IRI.parse _namespace_name "atDate" |> NamespacedName

    /// <summary>
    /// A subproperty of :beginsAt, allowing to address the beginning of an interval as a date/time
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#beginsAtDateTime"></see></summary>
    let beginsAtDateTime =
        Namespaced_IRI.parse _namespace_name "beginsAtDateTime" |> NamespacedName

    /// <summary>
    /// A subproperty of :endsAt, allowing to address the end of an interval as a date/time
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#endsAtDateTime"></see></summary>
    let endsAtDateTime =
        Namespaced_IRI.parse _namespace_name "endsAtDateTime" |> NamespacedName

    /// <summary>
    /// Describe the relation between a continuous time-line and its sampled equivalent
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#UniformSamplingMap"></see></summary>
    let UniformSamplingMap =
        Namespaced_IRI.parse _namespace_name "UniformSamplingMap" |> NamespacedName

    /// <summary>
    /// associates a sample rate value to a uniform sampling map
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#sampleRate"></see></summary>
    let sampleRate = Namespaced_IRI.parse _namespace_name "sampleRate" |> NamespacedName

    /// <summary>
    /// Describes the relation between a discrete time line and its windowed equivalent
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#UniformWindowingMap"></see></summary>
    let UniformWindowingMap =
        Namespaced_IRI.parse _namespace_name "UniformWindowingMap" |> NamespacedName

    /// <summary>
    /// Describes the relation between a continuous time-line, and a time-line that corresponds to its sampled and windowed equivalent
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#UniformSamplingWindowingMap"></see></summary>
    let UniformSamplingWindowingMap =
        Namespaced_IRI.parse _namespace_name "UniformSamplingWindowingMap" |> NamespacedName

    /// <summary>
    /// window length, associated to a uniform windowing map
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#windowLength"></see></summary>
    let windowLength =
        Namespaced_IRI.parse _namespace_name "windowLength" |> NamespacedName

    /// <summary>
    /// hop size, associated to a uniform windowing map
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#hopSize"></see></summary>
    let hopSize = Namespaced_IRI.parse _namespace_name "hopSize" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#after"></see>
    /// </summary>
    let after = Namespaced_IRI.parse _namespace_name "after" |> NamespacedName
    /// <summary>
    /// refers to a point or an interval on the time line, through an explicit datatype
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#at"></see></summary>
    let at = Namespaced_IRI.parse _namespace_name "at" |> NamespacedName
    /// <summary>
    /// subproperty of :at, having xsd:float as a range
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#atReal"></see></summary>
    let atReal = Namespaced_IRI.parse _namespace_name "atReal" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#before"></see>
    /// </summary>
    let before = Namespaced_IRI.parse _namespace_name "before" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#beginsAt"></see>
    /// </summary>
    let beginsAt = Namespaced_IRI.parse _namespace_name "beginsAt" |> NamespacedName
    /// <summary>
    /// refers to the beginning of a time interval, through an explicit datatype. time:hasBeginning can be used as well, if you want to associate the beginning of the interval to an explicit time point resource
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#start"></see></summary>
    let start = Namespaced_IRI.parse _namespace_name "start" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#contains"></see>
    /// </summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName
    /// <summary>
    /// associate a shift map to a particular delay
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#delay"></see></summary>
    let delay = Namespaced_IRI.parse _namespace_name "delay" |> NamespacedName
    /// <summary>
    /// the duration of a time interval
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#duration"></see></summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#during"></see>
    /// </summary>
    let during = Namespaced_IRI.parse _namespace_name "during" |> NamespacedName
    /// <summary>
    /// refers to the end of a time interval, through an explicit datatype. time:hasEnd can be used as well, if you want to associate the end of the interval to an explicit time point resource
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#end"></see></summary>
    let end_ = Namespaced_IRI.parse _namespace_name "end" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#endsAt"></see>
    /// </summary>
    let endsAt = Namespaced_IRI.parse _namespace_name "endsAt" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#equals"></see>
    /// </summary>
    let equals = Namespaced_IRI.parse _namespace_name "equals" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#finishedBy"></see>
    /// </summary>
    let finishedBy = Namespaced_IRI.parse _namespace_name "finishedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#finishes"></see>
    /// </summary>
    let finishes = Namespaced_IRI.parse _namespace_name "finishes" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#meets"></see>
    /// </summary>
    let meets = Namespaced_IRI.parse _namespace_name "meets" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#metBy"></see>
    /// </summary>
    let metBy = Namespaced_IRI.parse _namespace_name "metBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#onTimeLine"></see>
    /// </summary>
    let onTimeLine = Namespaced_IRI.parse _namespace_name "onTimeLine" |> NamespacedName
    /// <summary>
    /// associate an origin map to its origin on the domain physical timeline
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#origin"></see></summary>
    let origin = Namespaced_IRI.parse _namespace_name "origin" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#overlappedBy"></see>
    /// </summary>
    let overlappedBy =
        Namespaced_IRI.parse _namespace_name "overlappedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#overlaps"></see>
    /// </summary>
    let overlaps = Namespaced_IRI.parse _namespace_name "overlaps" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#startedBy"></see>
    /// </summary>
    let startedBy = Namespaced_IRI.parse _namespace_name "startedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#starts"></see>
    /// </summary>
    let starts = Namespaced_IRI.parse _namespace_name "starts" |> NamespacedName
