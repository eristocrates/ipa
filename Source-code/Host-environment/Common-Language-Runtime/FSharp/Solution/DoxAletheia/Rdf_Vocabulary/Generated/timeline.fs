namespace http.purl.org.NET.c4dm.timeline.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module timeline =
    let _namespace_iri = Namespace_Iri timeline |> NamespaceIRI
    /// <summary>
    ///   <para>timeline:beginsAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#beginsAt">http://purl.org/NET/c4dm/timeline.owl#beginsAt</seealso>
    let beginsAt = Prefixed_Name(timeline, "beginsAt") |> PrefixedName
    /// <summary>
    ///   <para>timeline:start</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>refers to the beginning of a time interval, through an explicit datatype. time:hasBeginning can be used as well, if you want to associate the beginning of the interval to an explicit time point resource</para>
    /// labels<para>begins at</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#start">http://purl.org/NET/c4dm/timeline.owl#start</seealso>
    let start = Prefixed_Name(timeline, "start") |> PrefixedName
    /// <summary>
    ///   <para>timeline:delay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>associate a shift map to a particular delay</para>
    /// labels<para>delay</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#delay">http://purl.org/NET/c4dm/timeline.owl#delay</seealso>
    let delay = Prefixed_Name(timeline, "delay") |> PrefixedName
    /// <summary>
    ///   <para>timeline:during</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#during">http://purl.org/NET/c4dm/timeline.owl#during</seealso>
    let during = Prefixed_Name(timeline, "during") |> PrefixedName
    /// <summary>
    ///   <para>timeline:end</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>refers to the end of a time interval, through an explicit datatype. time:hasEnd can be used as well, if you want to associate the end of the interval to an explicit time point resource</para>
    /// labels<para>ends at</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#end">http://purl.org/NET/c4dm/timeline.owl#end</seealso>
    let end_ = Prefixed_Name(timeline, "end") |> PrefixedName
    /// <summary>
    ///   <para>timeline:endsAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#endsAt">http://purl.org/NET/c4dm/timeline.owl#endsAt</seealso>
    let endsAt = Prefixed_Name(timeline, "endsAt") |> PrefixedName
    /// <summary>
    ///   <para>timeline:timeline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>
    /// 	Relates an interval or an instant to the timeline on which it is defined.
    ///
    /// 	The 29th of August, 2007 would be linked through this property to the universal timeline, whereas
    /// 	"from 2s to 5s on this particular signal" would be defined on the signal' timeline.
    ///
    ///     </para>
    /// labels<para>on timeline</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#timeline">http://purl.org/NET/c4dm/timeline.owl#timeline</seealso>
    let timeline_ = Prefixed_Name(timeline, "timeline") |> PrefixedName
    /// <summary>
    ///   <para>timeline:AbstractInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 	An interval defined on an abstract time-line.
    ///     </para>
    /// labels<para>abstract interval</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#AbstractInterval">http://purl.org/NET/c4dm/timeline.owl#AbstractInterval</seealso>
    let AbstractInterval = Prefixed_Name(timeline, "AbstractInterval") |> PrefixedName

    /// <summary>
    ///   <para>timeline:UniformWindowingMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes the relation between a discrete time line and its windowed equivalent</para>
    /// labels<para>uniform windowing map</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#UniformWindowingMap">http://purl.org/NET/c4dm/timeline.owl#UniformWindowingMap</seealso>
    let UniformWindowingMap =
        Prefixed_Name(timeline, "UniformWindowingMap") |> PrefixedName

    /// <summary>
    ///   <para>timeline:windowLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>window length, associated to a uniform windowing map</para>
    /// labels<para>window length</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#windowLength">http://purl.org/NET/c4dm/timeline.owl#windowLength</seealso>
    let windowLength = Prefixed_Name(timeline, "windowLength") |> PrefixedName
    /// <summary>
    ///   <para>timeline:AbstractInstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instant defined on an abstract timeline</para>
    /// labels<para>abstract instant</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#AbstractInstant">http://purl.org/NET/c4dm/timeline.owl#AbstractInstant</seealso>
    let AbstractInstant = Prefixed_Name(timeline, "AbstractInstant") |> PrefixedName
    /// <summary>
    ///   <para>timeline:Instant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instant (same as in OWL-Time)</para>
    /// labels<para>instant</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#Instant">http://purl.org/NET/c4dm/timeline.owl#Instant</seealso>
    let Instant = Prefixed_Name(timeline, "Instant") |> PrefixedName
    /// <summary>
    ///   <para>timeline:TimeLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a linear and coherent piece of time -- can be either abstract (such as the one behind a score) or concrete (such as the universal time line).
    /// Two timelines can be mapped using timeline maps.</para>
    /// labels<para>timeline</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#TimeLine">http://purl.org/NET/c4dm/timeline.owl#TimeLine</seealso>
    let TimeLine = Prefixed_Name(timeline, "TimeLine") |> PrefixedName
    /// <summary>
    ///   <para>timeline:DiscreteTimeLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A discrete time line (like the time line backing a digital signal</para>
    /// labels<para>discrete time line</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#DiscreteTimeLine">http://purl.org/NET/c4dm/timeline.owl#DiscreteTimeLine</seealso>
    let DiscreteTimeLine = Prefixed_Name(timeline, "DiscreteTimeLine") |> PrefixedName
    /// <summary>
    ///   <para>timeline:atReal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>subproperty of :at, having xsd:float as a range</para>
    /// labels<para>at (real)</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#atReal">http://purl.org/NET/c4dm/timeline.owl#atReal</seealso>
    let atReal = Prefixed_Name(timeline, "atReal") |> PrefixedName
    /// <summary>
    ///   <para>timeline:before</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#before">http://purl.org/NET/c4dm/timeline.owl#before</seealso>
    let before = Prefixed_Name(timeline, "before") |> PrefixedName
    /// <summary>
    ///   <para>timeline:Interval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An interval (same as in OWL-Time). Allen's relationships are defined in OWL-Time.</para>
    /// labels<para>interval</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#Interval">http://purl.org/NET/c4dm/timeline.owl#Interval</seealso>
    let Interval = Prefixed_Name(timeline, "Interval") |> PrefixedName
    /// <summary>
    ///   <para>timeline:RelativeTimeLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Semi infinite time line...canonical coordinate system --&gt; adressed through xsd:duration since the instant 0.</para>
    /// labels<para>relative timeline</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#RelativeTimeLine">http://purl.org/NET/c4dm/timeline.owl#RelativeTimeLine</seealso>
    let RelativeTimeLine = Prefixed_Name(timeline, "RelativeTimeLine") |> PrefixedName
    /// <summary>
    ///   <para>timeline:equals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#equals">http://purl.org/NET/c4dm/timeline.owl#equals</seealso>
    let equals = Prefixed_Name(timeline, "equals") |> PrefixedName
    /// <summary>
    ///   <para>timeline:finishedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#finishedBy">http://purl.org/NET/c4dm/timeline.owl#finishedBy</seealso>
    let finishedBy = Prefixed_Name(timeline, "finishedBy") |> PrefixedName
    /// <summary>
    ///   <para>timeline:metBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#metBy">http://purl.org/NET/c4dm/timeline.owl#metBy</seealso>
    let metBy = Prefixed_Name(timeline, "metBy") |> PrefixedName
    /// <summary>
    ///   <para>timeline:overlappedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#overlappedBy">http://purl.org/NET/c4dm/timeline.owl#overlappedBy</seealso>
    let overlappedBy = Prefixed_Name(timeline, "overlappedBy") |> PrefixedName
    /// <summary>
    ///   <para>timeline:overlaps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#overlaps">http://purl.org/NET/c4dm/timeline.owl#overlaps</seealso>
    let overlaps = Prefixed_Name(timeline, "overlaps") |> PrefixedName
    /// <summary>
    ///   <para>timeline:startedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#startedBy">http://purl.org/NET/c4dm/timeline.owl#startedBy</seealso>
    let startedBy = Prefixed_Name(timeline, "startedBy") |> PrefixedName
    /// <summary>
    ///   <para>timeline:starts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#starts">http://purl.org/NET/c4dm/timeline.owl#starts</seealso>
    let starts = Prefixed_Name(timeline, "starts") |> PrefixedName

    /// <summary>
    ///   <para>timeline:ContinuousTimeLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A continuous timeline, like the universal one, or the one backing an analog signal</para>
    /// labels<para>continuous timeline</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#ContinuousTimeLine">http://purl.org/NET/c4dm/timeline.owl#ContinuousTimeLine</seealso>
    let ContinuousTimeLine =
        Prefixed_Name(timeline, "ContinuousTimeLine") |> PrefixedName

    /// <summary>
    ///   <para>timeline:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#contains">http://purl.org/NET/c4dm/timeline.owl#contains</seealso>
    let contains = Prefixed_Name(timeline, "contains") |> PrefixedName
    /// <summary>
    ///   <para>timeline:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>the duration of a time interval</para>
    /// labels<para>duration</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#duration">http://purl.org/NET/c4dm/timeline.owl#duration</seealso>
    let duration = Prefixed_Name(timeline, "duration") |> PrefixedName
    /// <summary>
    ///   <para>timeline:PhysicalTimeLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A "physical" time-line (the universal time line (UTC)) is an instance of this class. Other time zones consists in instances of this class as well, with a "shifting" time line map relating them to the universal time line map.</para>
    /// labels<para>physical timeline</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#PhysicalTimeLine">http://purl.org/NET/c4dm/timeline.owl#PhysicalTimeLine</seealso>
    let PhysicalTimeLine = Prefixed_Name(timeline, "PhysicalTimeLine") |> PrefixedName
    /// <summary>
    ///   <para>timeline:DiscreteInstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instant defined on a discrete timeline</para>
    /// labels<para>discrete instant</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#DiscreteInstant">http://purl.org/NET/c4dm/timeline.owl#DiscreteInstant</seealso>
    let DiscreteInstant = Prefixed_Name(timeline, "DiscreteInstant") |> PrefixedName
    /// <summary>
    ///   <para>timeline:beginsAtInt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A subproperty of :beginsAt, having xsd:int as a range</para>
    /// labels<para>begins at (integer)</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#beginsAtInt">http://purl.org/NET/c4dm/timeline.owl#beginsAtInt</seealso>
    let beginsAtInt = Prefixed_Name(timeline, "beginsAtInt") |> PrefixedName
    /// <summary>
    ///   <para>timeline:durationInt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A subproperty of :duration, having xsd:int as a range</para>
    /// labels<para>duration (integer)</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#durationInt">http://purl.org/NET/c4dm/timeline.owl#durationInt</seealso>
    let durationInt = Prefixed_Name(timeline, "durationInt") |> PrefixedName
    /// <summary>
    ///   <para>timeline:OriginMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A timeline map linking a physical timeline to a relative one (originating at some point on the physical timeline)</para>
    /// labels<para>origin map</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#OriginMap">http://purl.org/NET/c4dm/timeline.owl#OriginMap</seealso>
    let OriginMap = Prefixed_Name(timeline, "OriginMap") |> PrefixedName
    /// <summary>
    ///   <para>timeline:TimeLineMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Allows to map two time lines together</para>
    /// labels<para>timeline map</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#TimeLineMap">http://purl.org/NET/c4dm/timeline.owl#TimeLineMap</seealso>
    let TimeLineMap = Prefixed_Name(timeline, "TimeLineMap") |> PrefixedName
    /// <summary>
    ///   <para>timeline:rangeTimeLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>associates a timeline map to its range timeline</para>
    /// labels<para>range timeline</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#rangeTimeLine">http://purl.org/NET/c4dm/timeline.owl#rangeTimeLine</seealso>
    let rangeTimeLine = Prefixed_Name(timeline, "rangeTimeLine") |> PrefixedName
    /// <summary>
    ///   <para>timeline:RelativeInstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instant defined on a relative timeline</para>
    /// labels<para>relative instant</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#RelativeInstant">http://purl.org/NET/c4dm/timeline.owl#RelativeInstant</seealso>
    let RelativeInstant = Prefixed_Name(timeline, "RelativeInstant") |> PrefixedName
    /// <summary>
    ///   <para>timeline:RelativeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>an interval defined on a relative timeline</para>
    /// labels<para>relative interval</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#RelativeInterval">http://purl.org/NET/c4dm/timeline.owl#RelativeInterval</seealso>
    let RelativeInterval = Prefixed_Name(timeline, "RelativeInterval") |> PrefixedName
    /// <summary>
    ///   <para>timeline:atInt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A subproperty of :at, having as a specific range xsd:int</para>
    /// labels<para>at (integer)</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#atInt">http://purl.org/NET/c4dm/timeline.owl#atInt</seealso>
    let atInt = Prefixed_Name(timeline, "atInt") |> PrefixedName
    /// <summary>
    ///   <para>timeline:finishes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#finishes">http://purl.org/NET/c4dm/timeline.owl#finishes</seealso>
    let finishes = Prefixed_Name(timeline, "finishes") |> PrefixedName
    /// <summary>
    ///   <para>timeline:onTimeLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#onTimeLine">http://purl.org/NET/c4dm/timeline.owl#onTimeLine</seealso>
    let onTimeLine = Prefixed_Name(timeline, "onTimeLine") |> PrefixedName
    /// <summary>
    ///   <para>timeline:DiscreteInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An interval defined on a discrete timeline, like the one backing a digital signal</para>
    /// labels<para>discrete interval</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#DiscreteInterval">http://purl.org/NET/c4dm/timeline.owl#DiscreteInterval</seealso>
    let DiscreteInterval = Prefixed_Name(timeline, "DiscreteInterval") |> PrefixedName
    /// <summary>
    ///   <para>timeline:meets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#meets">http://purl.org/NET/c4dm/timeline.owl#meets</seealso>
    let meets = Prefixed_Name(timeline, "meets") |> PrefixedName
    /// <summary>
    ///   <para>timeline:origin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>associate an origin map to its origin on the domain physical timeline</para>
    /// labels<para>origin</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#origin">http://purl.org/NET/c4dm/timeline.owl#origin</seealso>
    let origin = Prefixed_Name(timeline, "origin") |> PrefixedName
    /// <summary>
    ///   <para>timeline:endsAtInt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A subproperty of :endsAt, having xsd:int as a range</para>
    /// labels<para>ends at (integer)</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#endsAtInt">http://purl.org/NET/c4dm/timeline.owl#endsAtInt</seealso>
    let endsAtInt = Prefixed_Name(timeline, "endsAtInt") |> PrefixedName
    /// <summary>
    ///   <para>timeline:domainTimeLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>associates a timeline map to its domain timeline</para>
    /// labels<para>domain timeline</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#domainTimeLine">http://purl.org/NET/c4dm/timeline.owl#domainTimeLine</seealso>
    let domainTimeLine = Prefixed_Name(timeline, "domainTimeLine") |> PrefixedName
    /// <summary>
    ///   <para>timeline:atDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A property enabling to adress a time point P through the duration of the interval [0,P] on a continuous timeline</para>
    /// labels<para>at (duration)</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#atDuration">http://purl.org/NET/c4dm/timeline.owl#atDuration</seealso>
    let atDuration = Prefixed_Name(timeline, "atDuration") |> PrefixedName
    /// <summary>
    ///   <para>timeline:beginsAtDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A property enabling to adress a start time point P of an interval [P,E] through the duration of the interval [0,P] on a continuous timeline</para>
    /// labels<para>begins at (xsd:duration)</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#beginsAtDuration">http://purl.org/NET/c4dm/timeline.owl#beginsAtDuration</seealso>
    let beginsAtDuration = Prefixed_Name(timeline, "beginsAtDuration") |> PrefixedName
    /// <summary>
    ///   <para>timeline:durationXSD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A subproperty of :duration, having xsd:duration as a range</para>
    /// labels<para>duration (xsd:duration)</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#durationXSD">http://purl.org/NET/c4dm/timeline.owl#durationXSD</seealso>
    let durationXSD = Prefixed_Name(timeline, "durationXSD") |> PrefixedName
    /// <summary>
    ///   <para>timeline:ShiftMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>a map just shifting one timeline to another</para>
    /// labels<para>shift map</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#ShiftMap">http://purl.org/NET/c4dm/timeline.owl#ShiftMap</seealso>
    let ShiftMap = Prefixed_Name(timeline, "ShiftMap") |> PrefixedName
    /// <summary>
    ///   <para>timeline:atDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property links an instant defined on the universal time line to an XSD date/time value</para>
    /// labels<para>at date/time</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#atDateTime">http://purl.org/NET/c4dm/timeline.owl#atDateTime</seealso>
    let atDateTime = Prefixed_Name(timeline, "atDateTime") |> PrefixedName
    /// <summary>
    ///   <para>timeline:universaltimeline</para>
    /// </summary>
    /// <remarks>
    ///   <para>timeline:PhysicalTimeLine</para>
    ///   <para>this is the `universal' time line -- can adress time intervals on it using date/dateTime -- UTC</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#universaltimeline">http://purl.org/NET/c4dm/timeline.owl#universaltimeline</seealso>
    let universaltimeline = Prefixed_Name(timeline, "universaltimeline") |> PrefixedName
    /// <summary>
    ///   <para>timeline:atYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A subproperty of :at, allowing to address a year (beginning of it for an instant, all of it for an interval)</para>
    /// labels<para>at (year)</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#atYear">http://purl.org/NET/c4dm/timeline.owl#atYear</seealso>
    let atYear = Prefixed_Name(timeline, "atYear") |> PrefixedName
    /// <summary>
    ///   <para>timeline:atDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A subproperty of :at, allowing to address a date (beginning of it for an instant, all of it for an interval)</para>
    /// labels<para>at (date)</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#atDate">http://purl.org/NET/c4dm/timeline.owl#atDate</seealso>
    let atDate = Prefixed_Name(timeline, "atDate") |> PrefixedName
    /// <summary>
    ///   <para>timeline:endsAtDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A property enabling to adress an end time point P of an interval [S,P] through the duration of the interval [0,P] on a continuous timeline</para>
    /// labels<para>ends at (xsd:duration)</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#endsAtDuration">http://purl.org/NET/c4dm/timeline.owl#endsAtDuration</seealso>
    let endsAtDuration = Prefixed_Name(timeline, "endsAtDuration") |> PrefixedName
    /// <summary>
    ///   <para>timeline:UTInstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This concept expresses that an instant defined on the universal timeline must be associated to a dateTime value</para>
    /// labels<para>instant on the universal timeline</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#UTInstant">http://purl.org/NET/c4dm/timeline.owl#UTInstant</seealso>
    let UTInstant = Prefixed_Name(timeline, "UTInstant") |> PrefixedName
    /// <summary>
    ///   <para>timeline:UTInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>an interval defined on the universal time line</para>
    /// labels<para>universal timeline interval</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#UTInterval">http://purl.org/NET/c4dm/timeline.owl#UTInterval</seealso>
    let UTInterval = Prefixed_Name(timeline, "UTInterval") |> PrefixedName
    /// <summary>
    ///   <para>timeline:atYearMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A subproperty of :at, allowing to address a year/month (beginning of it for an instant, all of it for an interval)</para>
    /// labels<para>at (year/month)</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#atYearMonth">http://purl.org/NET/c4dm/timeline.owl#atYearMonth</seealso>
    let atYearMonth = Prefixed_Name(timeline, "atYearMonth") |> PrefixedName
    /// <summary>
    ///   <para>timeline:endsAtDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A subproperty of :endsAt, allowing to address the end of an interval as a date/time</para>
    /// labels<para>ends at (date/time)</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#endsAtDateTime">http://purl.org/NET/c4dm/timeline.owl#endsAtDateTime</seealso>
    let endsAtDateTime = Prefixed_Name(timeline, "endsAtDateTime") |> PrefixedName

    /// <summary>
    ///   <para>timeline:UniformSamplingMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describe the relation between a continuous time-line and its sampled equivalent</para>
    /// labels<para>uniform sampling map</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#UniformSamplingMap">http://purl.org/NET/c4dm/timeline.owl#UniformSamplingMap</seealso>
    let UniformSamplingMap =
        Prefixed_Name(timeline, "UniformSamplingMap") |> PrefixedName

    /// <summary>
    ///   <para>timeline:sampleRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>associates a sample rate value to a uniform sampling map</para>
    /// labels<para>sample rate</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#sampleRate">http://purl.org/NET/c4dm/timeline.owl#sampleRate</seealso>
    let sampleRate = Prefixed_Name(timeline, "sampleRate") |> PrefixedName

    /// <summary>
    ///   <para>timeline:UniformSamplingWindowingMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes the relation between a continuous time-line, and a time-line that corresponds to its sampled and windowed equivalent</para>
    /// labels<para>Uniform sampling and windowing map</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#UniformSamplingWindowingMap">http://purl.org/NET/c4dm/timeline.owl#UniformSamplingWindowingMap</seealso>
    let UniformSamplingWindowingMap =
        Prefixed_Name(timeline, "UniformSamplingWindowingMap") |> PrefixedName

    /// <summary>
    ///   <para>timeline:hopSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>hop size, associated to a uniform windowing map</para>
    /// labels<para>hop size</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#hopSize">http://purl.org/NET/c4dm/timeline.owl#hopSize</seealso>
    let hopSize = Prefixed_Name(timeline, "hopSize") |> PrefixedName
    /// <summary>
    ///   <para>timeline:beginsAtDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A subproperty of :beginsAt, allowing to address the beginning of an interval as a date/time</para>
    /// labels<para>begins at (date/time)</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#beginsAtDateTime">http://purl.org/NET/c4dm/timeline.owl#beginsAtDateTime</seealso>
    let beginsAtDateTime = Prefixed_Name(timeline, "beginsAtDateTime") |> PrefixedName
    /// <summary>
    ///   <para>timeline:AbstractTimeLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     	Abstract time lines may be used as a backbone for Score, Works, ...
    /// 	This allows for TimeLine maps to relate works to a given
    /// 	performance (this part was played at this time).</para>
    /// labels<para>abstract timeline</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#AbstractTimeLine">http://purl.org/NET/c4dm/timeline.owl#AbstractTimeLine</seealso>
    let AbstractTimeLine = Prefixed_Name(timeline, "AbstractTimeLine") |> PrefixedName
    /// <summary>
    ///   <para>timeline:after</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#after">http://purl.org/NET/c4dm/timeline.owl#after</seealso>
    let after = Prefixed_Name(timeline, "after") |> PrefixedName
    /// <summary>
    ///   <para>timeline:at</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>refers to a point or an interval on the time line, through an explicit datatype</para>
    /// labels<para>at</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/timeline.owl#at">http://purl.org/NET/c4dm/timeline.owl#at</seealso>
    let at = Prefixed_Name(timeline, "at") |> PrefixedName
