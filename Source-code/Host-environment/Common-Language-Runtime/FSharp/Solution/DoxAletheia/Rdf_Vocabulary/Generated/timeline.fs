namespace http.purl.org.NET.c4dm.timeline.owl.hash

open DoxAletheia

module timeline =
    let _namespace_name = "http://purl.org/NET/c4dm/timeline.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An instant defined on an abstract timeline
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#AbstractInstant"></see></summary>
    let AbstractInstant = _prefix "AbstractInstant"
    /// <summary>
    /// An instant (same as in OWL-Time)
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#Instant"></see></summary>
    let Instant = _prefix "Instant"
    /// <summary>
    ///
    /// 	Relates an interval or an instant to the timeline on which it is defined.
    ///
    /// 	The 29th of August, 2007 would be linked through this property to the universal timeline, whereas
    /// 	"from 2s to 5s on this particular signal" would be defined on the signal' timeline.
    ///
    ///
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#timeline"></see></summary>
    let timeline = _prefix "timeline"
    /// <summary>
    ///
    ///     	Abstract time lines may be used as a backbone for Score, Works, ...
    /// 	This allows for TimeLine maps to relate works to a given
    /// 	performance (this part was played at this time).
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#AbstractTimeLine"></see></summary>
    let AbstractTimeLine = _prefix "AbstractTimeLine"
    /// <summary>
    ///
    /// 	An interval defined on an abstract time-line.
    ///
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#AbstractInterval"></see></summary>
    let AbstractInterval = _prefix "AbstractInterval"
    /// <summary>
    /// An interval (same as in OWL-Time). Allen's relationships are defined in OWL-Time.
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#Interval"></see></summary>
    let Interval = _prefix "Interval"
    /// <summary>
    /// Represents a linear and coherent piece of time -- can be either abstract (such as the one behind a score) or concrete (such as the universal time line).
    /// Two timelines can be mapped using timeline maps.
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#TimeLine"></see></summary>
    let TimeLine = _prefix "TimeLine"
    /// <summary>
    /// A continuous timeline, like the universal one, or the one backing an analog signal
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#ContinuousTimeLine"></see></summary>
    let ContinuousTimeLine = _prefix "ContinuousTimeLine"
    /// <summary>
    /// A discrete time line (like the time line backing a digital signal
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#DiscreteTimeLine"></see></summary>
    let DiscreteTimeLine = _prefix "DiscreteTimeLine"
    /// <summary>
    /// A "physical" time-line (the universal time line (UTC)) is an instance of this class. Other time zones consists in instances of this class as well, with a "shifting" time line map relating them to the universal time line map.
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#PhysicalTimeLine"></see></summary>
    let PhysicalTimeLine = _prefix "PhysicalTimeLine"
    /// <summary>
    /// Semi infinite time line...canonical coordinate system --&gt; adressed through xsd:duration since the instant 0.
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#RelativeTimeLine"></see></summary>
    let RelativeTimeLine = _prefix "RelativeTimeLine"
    /// <summary>
    /// An instant defined on a discrete timeline
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#DiscreteInstant"></see></summary>
    let DiscreteInstant = _prefix "DiscreteInstant"
    /// <summary>
    /// A subproperty of :at, having as a specific range xsd:int
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#atInt"></see></summary>
    let atInt = _prefix "atInt"
    /// <summary>
    /// An interval defined on a discrete timeline, like the one backing a digital signal
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#DiscreteInterval"></see></summary>
    let DiscreteInterval = _prefix "DiscreteInterval"
    /// <summary>
    /// A subproperty of :beginsAt, having xsd:int as a range
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#beginsAtInt"></see></summary>
    let beginsAtInt = _prefix "beginsAtInt"
    /// <summary>
    /// A subproperty of :endsAt, having xsd:int as a range
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#endsAtInt"></see></summary>
    let endsAtInt = _prefix "endsAtInt"
    /// <summary>
    /// A subproperty of :duration, having xsd:int as a range
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#durationInt"></see></summary>
    let durationInt = _prefix "durationInt"
    /// <summary>
    /// A timeline map linking a physical timeline to a relative one (originating at some point on the physical timeline)
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#OriginMap"></see></summary>
    let OriginMap = _prefix "OriginMap"
    /// <summary>
    /// Allows to map two time lines together
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#TimeLineMap"></see></summary>
    let TimeLineMap = _prefix "TimeLineMap"
    /// <summary>
    /// associates a timeline map to its domain timeline
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#domainTimeLine"></see></summary>
    let domainTimeLine = _prefix "domainTimeLine"
    /// <summary>
    /// associates a timeline map to its range timeline
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#rangeTimeLine"></see></summary>
    let rangeTimeLine = _prefix "rangeTimeLine"
    /// <summary>
    /// An instant defined on a relative timeline
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#RelativeInstant"></see></summary>
    let RelativeInstant = _prefix "RelativeInstant"
    /// <summary>
    /// A property enabling to adress a time point P through the duration of the interval [0,P] on a continuous timeline
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#atDuration"></see></summary>
    let atDuration = _prefix "atDuration"
    /// <summary>
    /// an interval defined on a relative timeline
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#RelativeInterval"></see></summary>
    let RelativeInterval = _prefix "RelativeInterval"
    /// <summary>
    /// A property enabling to adress a start time point P of an interval [P,E] through the duration of the interval [0,P] on a continuous timeline
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#beginsAtDuration"></see></summary>
    let beginsAtDuration = _prefix "beginsAtDuration"
    /// <summary>
    /// A subproperty of :duration, having xsd:duration as a range
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#durationXSD"></see></summary>
    let durationXSD = _prefix "durationXSD"
    /// <summary>
    /// A property enabling to adress an end time point P of an interval [S,P] through the duration of the interval [0,P] on a continuous timeline
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#endsAtDuration"></see></summary>
    let endsAtDuration = _prefix "endsAtDuration"
    /// <summary>
    /// a map just shifting one timeline to another
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#ShiftMap"></see></summary>
    let ShiftMap = _prefix "ShiftMap"
    /// <summary>
    /// This concept expresses that an instant defined on the universal timeline must be associated to a dateTime value
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#UTInstant"></see></summary>
    let UTInstant = _prefix "UTInstant"
    /// <summary>
    /// This property links an instant defined on the universal time line to an XSD date/time value
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#atDateTime"></see></summary>
    let atDateTime = _prefix "atDateTime"
    /// <summary>
    /// this is the `universal' time line -- can adress time intervals on it using date/dateTime -- UTC
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#universaltimeline"></see></summary>
    let universaltimeline = _prefix "universaltimeline"
    /// <summary>
    /// an interval defined on the universal time line
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#UTInterval"></see></summary>
    let UTInterval = _prefix "UTInterval"
    /// <summary>
    /// A subproperty of :at, allowing to address a year (beginning of it for an instant, all of it for an interval)
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#atYear"></see></summary>
    let atYear = _prefix "atYear"
    /// <summary>
    /// A subproperty of :at, allowing to address a year/month (beginning of it for an instant, all of it for an interval)
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#atYearMonth"></see></summary>
    let atYearMonth = _prefix "atYearMonth"
    /// <summary>
    /// A subproperty of :at, allowing to address a date (beginning of it for an instant, all of it for an interval)
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#atDate"></see></summary>
    let atDate = _prefix "atDate"
    /// <summary>
    /// A subproperty of :beginsAt, allowing to address the beginning of an interval as a date/time
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#beginsAtDateTime"></see></summary>
    let beginsAtDateTime = _prefix "beginsAtDateTime"
    /// <summary>
    /// A subproperty of :endsAt, allowing to address the end of an interval as a date/time
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#endsAtDateTime"></see></summary>
    let endsAtDateTime = _prefix "endsAtDateTime"
    /// <summary>
    /// Describe the relation between a continuous time-line and its sampled equivalent
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#UniformSamplingMap"></see></summary>
    let UniformSamplingMap = _prefix "UniformSamplingMap"
    /// <summary>
    /// associates a sample rate value to a uniform sampling map
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#sampleRate"></see></summary>
    let sampleRate = _prefix "sampleRate"
    /// <summary>
    /// Describes the relation between a discrete time line and its windowed equivalent
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#UniformWindowingMap"></see></summary>
    let UniformWindowingMap = _prefix "UniformWindowingMap"
    /// <summary>
    /// Describes the relation between a continuous time-line, and a time-line that corresponds to its sampled and windowed equivalent
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#UniformSamplingWindowingMap"></see></summary>
    let UniformSamplingWindowingMap = _prefix "UniformSamplingWindowingMap"
    /// <summary>
    /// window length, associated to a uniform windowing map
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#windowLength"></see></summary>
    let windowLength = _prefix "windowLength"
    /// <summary>
    /// hop size, associated to a uniform windowing map
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#hopSize"></see></summary>
    let hopSize = _prefix "hopSize"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#after"></see>
    /// </summary>
    let after = _prefix "after"
    /// <summary>
    /// refers to a point or an interval on the time line, through an explicit datatype
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#at"></see></summary>
    let at = _prefix "at"
    /// <summary>
    /// subproperty of :at, having xsd:float as a range
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#atReal"></see></summary>
    let atReal = _prefix "atReal"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#before"></see>
    /// </summary>
    let before = _prefix "before"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#beginsAt"></see>
    /// </summary>
    let beginsAt = _prefix "beginsAt"
    /// <summary>
    /// refers to the beginning of a time interval, through an explicit datatype. time:hasBeginning can be used as well, if you want to associate the beginning of the interval to an explicit time point resource
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#start"></see></summary>
    let start = _prefix "start"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#contains"></see>
    /// </summary>
    let contains = _prefix "contains"
    /// <summary>
    /// associate a shift map to a particular delay
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#delay"></see></summary>
    let delay = _prefix "delay"
    /// <summary>
    /// the duration of a time interval
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#during"></see>
    /// </summary>
    let during = _prefix "during"
    /// <summary>
    /// refers to the end of a time interval, through an explicit datatype. time:hasEnd can be used as well, if you want to associate the end of the interval to an explicit time point resource
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#end"></see></summary>
    let end_ = _prefix "end"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#endsAt"></see>
    /// </summary>
    let endsAt = _prefix "endsAt"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#equals"></see>
    /// </summary>
    let equals = _prefix "equals"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#finishedBy"></see>
    /// </summary>
    let finishedBy = _prefix "finishedBy"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#finishes"></see>
    /// </summary>
    let finishes = _prefix "finishes"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#meets"></see>
    /// </summary>
    let meets = _prefix "meets"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#metBy"></see>
    /// </summary>
    let metBy = _prefix "metBy"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#onTimeLine"></see>
    /// </summary>
    let onTimeLine = _prefix "onTimeLine"
    /// <summary>
    /// associate an origin map to its origin on the domain physical timeline
    /// <see href="http://purl.org/NET/c4dm/timeline.owl#origin"></see></summary>
    let origin = _prefix "origin"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#overlappedBy"></see>
    /// </summary>
    let overlappedBy = _prefix "overlappedBy"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#overlaps"></see>
    /// </summary>
    let overlaps = _prefix "overlaps"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#startedBy"></see>
    /// </summary>
    let startedBy = _prefix "startedBy"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/timeline.owl#starts"></see>
    /// </summary>
    let starts = _prefix "starts"
