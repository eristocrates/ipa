#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tl =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/NET/c4dm/timeline.owl#" "tl"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : An instant defined on an abstract timeline^^xsd:string</para>
    ///   <para>rdfs:label : abstract instant^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#AbstractInstant">tl:AbstractInstant</a>
    /// </summary>
    let AbstractInstant = _prefixId.prefix "AbstractInstant"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 	An interval defined on an abstract time-line.
    ///     ^^xsd:string</para>
    ///   <para>rdfs:label : abstract interval^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#AbstractInterval">tl:AbstractInterval</a>
    /// </summary>
    let AbstractInterval = _prefixId.prefix "AbstractInterval"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///     	Abstract time lines may be used as a backbone for Score, Works, ...
    /// 	This allows for TimeLine maps to relate works to a given
    /// 	performance (this part was played at this time).^^xsd:string</para>
    ///   <para>rdfs:label : abstract timeline^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#AbstractTimeLine">tl:AbstractTimeLine</a>
    /// </summary>
    let AbstractTimeLine = _prefixId.prefix "AbstractTimeLine"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A continuous timeline, like the universal one, or the one backing an analog signal^^xsd:string</para>
    ///   <para>rdfs:label : continuous timeline^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#ContinuousTimeLine">tl:ContinuousTimeLine</a>
    /// </summary>
    let ContinuousTimeLine = _prefixId.prefix "ContinuousTimeLine"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : An instant defined on a discrete timeline^^xsd:string</para>
    ///   <para>rdfs:label : discrete instant^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#DiscreteInstant">tl:DiscreteInstant</a>
    /// </summary>
    let DiscreteInstant = _prefixId.prefix "DiscreteInstant"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : An interval defined on a discrete timeline, like the one backing a digital signal^^xsd:string</para>
    ///   <para>rdfs:label : discrete interval^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#DiscreteInterval">tl:DiscreteInterval</a>
    /// </summary>
    let DiscreteInterval = _prefixId.prefix "DiscreteInterval"
    /// <summary>
    ///   <para>rdfs:comment : A discrete time line (like the time line backing a digital signal^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : discrete time line^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#DiscreteTimeLine">tl:DiscreteTimeLine</a>
    /// </summary>
    let DiscreteTimeLine = _prefixId.prefix "DiscreteTimeLine"
    /// <summary>
    ///   <para>rdfs:comment : An instant (same as in OWL-Time)^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : instant^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#Instant">tl:Instant</a>
    /// </summary>
    let Instant = _prefixId.prefix "Instant"
    /// <summary>
    ///   <para>rdfs:comment : An interval (same as in OWL-Time). Allen's relationships are defined in OWL-Time.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : interval^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#Interval">tl:Interval</a>
    /// </summary>
    let Interval = _prefixId.prefix "Interval"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A timeline map linking a physical timeline to a relative one (originating at some point on the physical timeline)^^xsd:string</para>
    ///   <para>rdfs:label : origin map^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#OriginMap">tl:OriginMap</a>
    /// </summary>
    let OriginMap = _prefixId.prefix "OriginMap"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A "physical" time-line (the universal time line (UTC)) is an instance of this class. Other time zones consists in instances of this class as well, with a "shifting" time line map relating them to the universal time line map.^^xsd:string</para>
    ///   <para>rdfs:label : physical timeline^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#PhysicalTimeLine">tl:PhysicalTimeLine</a>
    /// </summary>
    let PhysicalTimeLine = _prefixId.prefix "PhysicalTimeLine"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : An instant defined on a relative timeline^^xsd:string</para>
    ///   <para>rdfs:label : relative instant^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#RelativeInstant">tl:RelativeInstant</a>
    /// </summary>
    let RelativeInstant = _prefixId.prefix "RelativeInstant"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : an interval defined on a relative timeline^^xsd:string</para>
    ///   <para>rdfs:label : relative interval^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#RelativeInterval">tl:RelativeInterval</a>
    /// </summary>
    let RelativeInterval = _prefixId.prefix "RelativeInterval"
    /// <summary>
    ///   <para>rdfs:comment : Semi infinite time line...canonical coordinate system --&gt; adressed through xsd:duration since the instant 0.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : relative timeline^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#RelativeTimeLine">tl:RelativeTimeLine</a>
    /// </summary>
    let RelativeTimeLine = _prefixId.prefix "RelativeTimeLine"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : shift map^^xsd:string</para>
    ///   <para>rdfs:comment : a map just shifting one timeline to another^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#ShiftMap">tl:ShiftMap</a>
    /// </summary>
    let ShiftMap = _prefixId.prefix "ShiftMap"
    /// <summary>
    ///   <para>rdfs:comment : Represents a linear and coherent piece of time -- can be either abstract (such as the one behind a score) or concrete (such as the universal time line).
    /// Two timelines can be mapped using timeline maps.^^xsd:string</para>
    ///   <para>rdfs:label : timeline^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#TimeLine">tl:TimeLine</a>
    /// </summary>
    let TimeLine = _prefixId.prefix "TimeLine"
    /// <summary>
    ///   <para>rdfs:comment : Allows to map two time lines together^^xsd:string</para>
    ///   <para>rdfs:label : timeline map^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#TimeLineMap">tl:TimeLineMap</a>
    /// </summary>
    let TimeLineMap = _prefixId.prefix "TimeLineMap"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This concept expresses that an instant defined on the universal timeline must be associated to a dateTime value^^xsd:string</para>
    ///   <para>rdfs:label : instant on the universal timeline^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#UTInstant">tl:UTInstant</a>
    /// </summary>
    let UTInstant = _prefixId.prefix "UTInstant"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : an interval defined on the universal time line^^xsd:string</para>
    ///   <para>rdfs:label : universal timeline interval^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#UTInterval">tl:UTInterval</a>
    /// </summary>
    let UTInterval = _prefixId.prefix "UTInterval"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Describe the relation between a continuous time-line and its sampled equivalent^^xsd:string</para>
    ///   <para>rdfs:label : uniform sampling map^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#UniformSamplingMap">tl:UniformSamplingMap</a>
    /// </summary>
    let UniformSamplingMap = _prefixId.prefix "UniformSamplingMap"
    /// <summary>
    ///   <para>rdfs:comment : Describes the relation between a continuous time-line, and a time-line that corresponds to its sampled and windowed equivalent^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Uniform sampling and windowing map^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#UniformSamplingWindowingMap">tl:UniformSamplingWindowingMap</a>
    /// </summary>
    let UniformSamplingWindowingMap = _prefixId.prefix "UniformSamplingWindowingMap"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : uniform windowing map^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the relation between a discrete time line and its windowed equivalent^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#UniformWindowingMap">tl:UniformWindowingMap</a>
    /// </summary>
    let UniformWindowingMap = _prefixId.prefix "UniformWindowingMap"
    let after = _prefixId.prefix "after"
    /// <summary>
    ///   <para>rdfs:comment : refers to a point or an interval on the time line, through an explicit datatype^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : at^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#at">tl:at</a>
    /// </summary>
    let at = _prefixId.prefix "at"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A subproperty of :at, allowing to address a date (beginning of it for an instant, all of it for an interval)^^xsd:string</para>
    ///   <para>rdfs:label : at (date)^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#atDate">tl:atDate</a>
    /// </summary>
    let atDate = _prefixId.prefix "atDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property links an instant defined on the universal time line to an XSD date/time value^^xsd:string</para>
    ///   <para>rdfs:label : at date/time^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#atDateTime">tl:atDateTime</a>
    /// </summary>
    let atDateTime = _prefixId.prefix "atDateTime"
    /// <summary>
    ///   <para>rdfs:comment : A property enabling to adress a time point P through the duration of the interval [0,P] on a continuous timeline^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : at (duration)^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#atDuration">tl:atDuration</a>
    /// </summary>
    let atDuration = _prefixId.prefix "atDuration"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A subproperty of :at, having as a specific range xsd:int^^xsd:string</para>
    ///   <para>rdfs:label : at (integer)^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#atInt">tl:atInt</a>
    /// </summary>
    let atInt = _prefixId.prefix "atInt"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : subproperty of :at, having xsd:float as a range^^xsd:string</para>
    ///   <para>rdfs:label : at (real)^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#atReal">tl:atReal</a>
    /// </summary>
    let atReal = _prefixId.prefix "atReal"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A subproperty of :at, allowing to address a year (beginning of it for an instant, all of it for an interval)^^xsd:string</para>
    ///   <para>rdfs:label : at (year)^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#atYear">tl:atYear</a>
    /// </summary>
    let atYear = _prefixId.prefix "atYear"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A subproperty of :at, allowing to address a year/month (beginning of it for an instant, all of it for an interval)^^xsd:string</para>
    ///   <para>rdfs:label : at (year/month)^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#atYearMonth">tl:atYearMonth</a>
    /// </summary>
    let atYearMonth = _prefixId.prefix "atYearMonth"
    let before = _prefixId.prefix "before"
    let beginsAt = _prefixId.prefix "beginsAt"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A subproperty of :beginsAt, allowing to address the beginning of an interval as a date/time^^xsd:string</para>
    ///   <para>rdfs:label : begins at (date/time)^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#beginsAtDateTime">tl:beginsAtDateTime</a>
    /// </summary>
    let beginsAtDateTime = _prefixId.prefix "beginsAtDateTime"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A property enabling to adress a start time point P of an interval [P,E] through the duration of the interval [0,P] on a continuous timeline^^xsd:string</para>
    ///   <para>rdfs:label : begins at (xsd:duration)^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#beginsAtDuration">tl:beginsAtDuration</a>
    /// </summary>
    let beginsAtDuration = _prefixId.prefix "beginsAtDuration"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A subproperty of :beginsAt, having xsd:int as a range^^xsd:string</para>
    ///   <para>rdfs:label : begins at (integer)^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#beginsAtInt">tl:beginsAtInt</a>
    /// </summary>
    let beginsAtInt = _prefixId.prefix "beginsAtInt"
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : associate a shift map to a particular delay^^xsd:string</para>
    ///   <para>rdfs:label : delay^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#delay">tl:delay</a>
    /// </summary>
    let delay = _prefixId.prefix "delay"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : associates a timeline map to its domain timeline^^xsd:string</para>
    ///   <para>rdfs:label : domain timeline^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#domainTimeLine">tl:domainTimeLine</a>
    /// </summary>
    let domainTimeLine = _prefixId.prefix "domainTimeLine"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : the duration of a time interval^^xsd:string</para>
    ///   <para>rdfs:label : duration^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#duration">tl:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A subproperty of :duration, having xsd:int as a range^^xsd:string</para>
    ///   <para>rdfs:label : duration (integer)^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#durationInt">tl:durationInt</a>
    /// </summary>
    let durationInt = _prefixId.prefix "durationInt"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A subproperty of :duration, having xsd:duration as a range^^xsd:string</para>
    ///   <para>rdfs:label : duration (xsd:duration)^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#durationXSD">tl:durationXSD</a>
    /// </summary>
    let durationXSD = _prefixId.prefix "durationXSD"
    let during = _prefixId.prefix "during"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : refers to the end of a time interval, through an explicit datatype. time:hasEnd can be used as well, if you want to associate the end of the interval to an explicit time point resource^^xsd:string</para>
    ///   <para>rdfs:label : ends at^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#end">tl:end</a>
    /// </summary>
    let end_ = _prefixId.prefix "end"
    let endsAt = _prefixId.prefix "endsAt"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A subproperty of :endsAt, allowing to address the end of an interval as a date/time^^xsd:string</para>
    ///   <para>rdfs:label : ends at (date/time)^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#endsAtDateTime">tl:endsAtDateTime</a>
    /// </summary>
    let endsAtDateTime = _prefixId.prefix "endsAtDateTime"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A property enabling to adress an end time point P of an interval [S,P] through the duration of the interval [0,P] on a continuous timeline^^xsd:string</para>
    ///   <para>rdfs:label : ends at (xsd:duration)^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#endsAtDuration">tl:endsAtDuration</a>
    /// </summary>
    let endsAtDuration = _prefixId.prefix "endsAtDuration"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A subproperty of :endsAt, having xsd:int as a range^^xsd:string</para>
    ///   <para>rdfs:label : ends at (integer)^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#endsAtInt">tl:endsAtInt</a>
    /// </summary>
    let endsAtInt = _prefixId.prefix "endsAtInt"
    let equals = _prefixId.prefix "equals"
    let finishedBy = _prefixId.prefix "finishedBy"
    let finishes = _prefixId.prefix "finishes"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : hop size, associated to a uniform windowing map^^xsd:string</para>
    ///   <para>rdfs:label : hop size^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#hopSize">tl:hopSize</a>
    /// </summary>
    let hopSize = _prefixId.prefix "hopSize"
    let meets = _prefixId.prefix "meets"
    let metBy = _prefixId.prefix "metBy"
    let onTimeLine = _prefixId.prefix "onTimeLine"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : associate an origin map to its origin on the domain physical timeline^^xsd:string</para>
    ///   <para>rdfs:label : origin^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#origin">tl:origin</a>
    /// </summary>
    let origin = _prefixId.prefix "origin"
    let overlappedBy = _prefixId.prefix "overlappedBy"
    let overlaps = _prefixId.prefix "overlaps"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : associates a timeline map to its range timeline^^xsd:string</para>
    ///   <para>rdfs:label : range timeline^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#rangeTimeLine">tl:rangeTimeLine</a>
    /// </summary>
    let rangeTimeLine = _prefixId.prefix "rangeTimeLine"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : associates a sample rate value to a uniform sampling map^^xsd:string</para>
    ///   <para>rdfs:label : sample rate^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#sampleRate">tl:sampleRate</a>
    /// </summary>
    let sampleRate = _prefixId.prefix "sampleRate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : refers to the beginning of a time interval, through an explicit datatype. time:hasBeginning can be used as well, if you want to associate the beginning of the interval to an explicit time point resource^^xsd:string</para>
    ///   <para>rdfs:label : begins at^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#start">tl:start</a>
    /// </summary>
    let start = _prefixId.prefix "start"
    let startedBy = _prefixId.prefix "startedBy"
    let starts = _prefixId.prefix "starts"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 	Relates an interval or an instant to the timeline on which it is defined.
    ///
    /// 	The 29th of August, 2007 would be linked through this property to the universal timeline, whereas
    /// 	"from 2s to 5s on this particular signal" would be defined on the signal' timeline.
    ///
    ///     ^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : on timeline^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#timeline">tl:timeline</a>
    /// </summary>
    let timeline = _prefixId.prefix "timeline"
    let universaltimeline = _prefixId.prefix "universaltimeline"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : window length, associated to a uniform windowing map^^xsd:string</para>
    ///   <para>rdfs:label : window length^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/timeline.owl#windowLength">tl:windowLength</a>
    /// </summary>
    let windowLength = _prefixId.prefix "windowLength"
