namespace http.www.w3.org._2006.time.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module owl_time =
    let _namespace_iri = Namespace_Iri owl_time |> NamespaceIRI
    /// <summary>
    ///   <para>owl_time:2016</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2006/time#2016">http://www.w3.org/2006/time#2016</seealso>
    let _2016 = Prefixed_Name(owl_time, "2016") |> PrefixedName

    /// <summary>
    ///   <para>owl_time:DateTimeDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of date and time structured with separate values for the various elements of a calendar-clock system. The temporal reference system is fixed to Gregorian Calendar, and the range of year, month, day properties restricted to corresponding XML Schema types xsd:gYear, xsd:gMonth and xsd:gDay, respectively.</para>
    /// labels<para>Date-Time description</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#DateTimeDescription">http://www.w3.org/2006/time#DateTimeDescription</seealso>
    let DateTimeDescription =
        Prefixed_Name(owl_time, "DateTimeDescription") |> PrefixedName

    /// <summary>
    ///   <para>owl_time:2006</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2006/time#2006">http://www.w3.org/2006/time#2006</seealso>
    let _2006 = Prefixed_Name(owl_time, "2006") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:Friday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl_time:DayOfWeek</para>
    ///
    /// labels<para>Friday</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#Friday">http://www.w3.org/2006/time#Friday</seealso>
    let Friday = Prefixed_Name(owl_time, "Friday") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:dayOfWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The day of week, whose value is a member of the class time:DayOfWeek</para>
    /// labels<para>day of week</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#dayOfWeek">http://www.w3.org/2006/time#dayOfWeek</seealso>
    let dayOfWeek = Prefixed_Name(owl_time, "dayOfWeek") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:timeZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The time zone for clock elements in the temporal position</para>
    /// labels<para>in time zone</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#timeZone">http://www.w3.org/2006/time#timeZone</seealso>
    let timeZone = Prefixed_Name(owl_time, "timeZone") |> PrefixedName

    /// <summary>
    ///   <para>owl_time:hasDateTimeDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Value of DateTimeInterval expressed as a structured value. The beginning and end of the interval coincide with the limits of the shortest element in the description.</para>
    /// labels<para>has Date-Time description</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#hasDateTimeDescription">http://www.w3.org/2006/time#hasDateTimeDescription</seealso>
    let hasDateTimeDescription =
        Prefixed_Name(owl_time, "hasDateTimeDescription") |> PrefixedName

    /// <summary>
    ///   <para>owl_time:hasDurationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Duration of a temporal entity, expressed using a structured description</para>
    /// labels<para>has duration description</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#hasDurationDescription">http://www.w3.org/2006/time#hasDurationDescription</seealso>
    let hasDurationDescription =
        Prefixed_Name(owl_time, "hasDurationDescription") |> PrefixedName

    /// <summary>
    ///   <para>owl_time:hasTRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The temporal reference system used by a temporal position or extent description. </para>
    /// labels<para>Temporal reference system used</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#hasTRS">http://www.w3.org/2006/time#hasTRS</seealso>
    let hasTRS = Prefixed_Name(owl_time, "hasTRS") |> PrefixedName

    /// <summary>
    ///   <para>owl_time:intervalFinishedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If a proper interval T1 is intervalFinishedBy another proper interval T2, then the beginning of T1 is before the beginning of T2, and the end of T1 is coincident with the end of T2.</para>
    /// labels<para>interval finished by</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#intervalFinishedBy">http://www.w3.org/2006/time#intervalFinishedBy</seealso>
    let intervalFinishedBy =
        Prefixed_Name(owl_time, "intervalFinishedBy") |> PrefixedName

    /// <summary>
    ///   <para>owl_time:intervalStarts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If a proper interval T1 is intervalStarts another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is before the end of T2.</para>
    /// labels<para>interval starts</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#intervalStarts">http://www.w3.org/2006/time#intervalStarts</seealso>
    let intervalStarts = Prefixed_Name(owl_time, "intervalStarts") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:hasXSDDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Extent of a temporal entity, expressed using xsd:duration</para>
    /// labels<para>has XSD duration</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#hasXSDDuration">http://www.w3.org/2006/time#hasXSDDuration</seealso>
    let hasXSDDuration = Prefixed_Name(owl_time, "hasXSDDuration") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:inDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Position of an instant, expressed using a structured description</para>
    /// labels<para>in date-time description</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#inDateTime">http://www.w3.org/2006/time#inDateTime</seealso>
    let inDateTime = Prefixed_Name(owl_time, "inDateTime") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:inTimePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Position of an instant, expressed as a temporal coordinate or nominal value</para>
    /// labels<para>Time position</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#inTimePosition">http://www.w3.org/2006/time#inTimePosition</seealso>
    let inTimePosition = Prefixed_Name(owl_time, "inTimePosition") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:inXSDgYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Position of an instant, expressed using xsd:gYear</para>
    /// labels<para>in XSD g-Year</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#inXSDgYear">http://www.w3.org/2006/time#inXSDgYear</seealso>
    let inXSDgYear = Prefixed_Name(owl_time, "inXSDgYear") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:inside</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An instant that falls inside the interval. It is not intended to include beginnings and ends of intervals.</para>
    /// labels<para>has time instant inside</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#inside">http://www.w3.org/2006/time#inside</seealso>
    let inside = Prefixed_Name(owl_time, "inside") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:intervalAfter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If a proper interval T1 is intervalAfter another proper interval T2, then the beginning of T1 is after the end of T2.</para>
    /// labels<para>interval after</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#intervalAfter">http://www.w3.org/2006/time#intervalAfter</seealso>
    let intervalAfter = Prefixed_Name(owl_time, "intervalAfter") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:intervalDisjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If a proper interval T1 is intervalDisjoint another proper interval T2, then the beginning of T1 is after the end of T2, or the end of T1 is before the beginning of T2, i.e. the intervals do not overlap in any way, but their ordering relationship is not known.</para>
    /// labels<para>interval disjoint</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#intervalDisjoint">http://www.w3.org/2006/time#intervalDisjoint</seealso>
    let intervalDisjoint = Prefixed_Name(owl_time, "intervalDisjoint") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:intervalContains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If a proper interval T1 is intervalContains another proper interval T2, then the beginning of T1 is before the beginning of T2, and the end of T1 is after the end of T2.</para>
    /// labels<para>interval contains</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#intervalContains">http://www.w3.org/2006/time#intervalContains</seealso>
    let intervalContains = Prefixed_Name(owl_time, "intervalContains") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:intervalDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If a proper interval T1 is intervalDuring another proper interval T2, then the beginning of T1 is after the beginning of T2, and the end of T1 is before the end of T2.</para>
    /// labels<para>interval during</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#intervalDuring">http://www.w3.org/2006/time#intervalDuring</seealso>
    let intervalDuring = Prefixed_Name(owl_time, "intervalDuring") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:intervalEquals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If a proper interval T1 is intervalEquals another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is coincident with the end of T2.</para>
    /// labels<para>interval equals</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#intervalEquals">http://www.w3.org/2006/time#intervalEquals</seealso>
    let intervalEquals = Prefixed_Name(owl_time, "intervalEquals") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:intervalMeets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If a proper interval T1 is intervalMeets another proper interval T2, then the end of T1 is coincident with the beginning of T2.</para>
    /// labels<para>interval meets</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#intervalMeets">http://www.w3.org/2006/time#intervalMeets</seealso>
    let intervalMeets = Prefixed_Name(owl_time, "intervalMeets") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:intervalMetBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If a proper interval T1 is intervalMetBy another proper interval T2, then the beginning of T1 is coincident with the end of T2.</para>
    /// labels<para>interval met by</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#intervalMetBy">http://www.w3.org/2006/time#intervalMetBy</seealso>
    let intervalMetBy = Prefixed_Name(owl_time, "intervalMetBy") |> PrefixedName

    /// <summary>
    ///   <para>owl_time:intervalOverlappedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If a proper interval T1 is intervalOverlappedBy another proper interval T2, then the beginning of T1 is after the beginning of T2, the beginning of T1 is before the end of T2, and the end of T1 is after the end of T2.</para>
    /// labels<para>interval overlapped by</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#intervalOverlappedBy">http://www.w3.org/2006/time#intervalOverlappedBy</seealso>
    let intervalOverlappedBy =
        Prefixed_Name(owl_time, "intervalOverlappedBy") |> PrefixedName

    /// <summary>
    ///   <para>owl_time:intervalOverlaps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If a proper interval T1 is intervalOverlaps another proper interval T2, then the beginning of T1 is before the beginning of T2, the end of T1 is after the beginning of T2, and the end of T1 is before the end of T2.</para>
    /// labels<para>interval overlaps</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#intervalOverlaps">http://www.w3.org/2006/time#intervalOverlaps</seealso>
    let intervalOverlaps = Prefixed_Name(owl_time, "intervalOverlaps") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:intervalStartedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If a proper interval T1 is intervalStarted another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is after the end of T2.</para>
    /// labels<para>interval started by</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#intervalStartedBy">http://www.w3.org/2006/time#intervalStartedBy</seealso>
    let intervalStartedBy = Prefixed_Name(owl_time, "intervalStartedBy") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:unitHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl_time:TemporalUnit</para>
    ///
    /// labels<para>Hour (unit of temporal duration)</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#unitHour">http://www.w3.org/2006/time#unitHour</seealso>
    let unitHour = Prefixed_Name(owl_time, "unitHour") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:unitMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl_time:TemporalUnit</para>
    ///
    /// labels<para>Minute (unit of temporal duration)</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#unitMinute">http://www.w3.org/2006/time#unitMinute</seealso>
    let unitMinute = Prefixed_Name(owl_time, "unitMinute") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:unitSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl_time:TemporalUnit</para>
    ///
    /// labels<para>Second (unit of temporal duration)</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#unitSecond">http://www.w3.org/2006/time#unitSecond</seealso>
    let unitSecond = Prefixed_Name(owl_time, "unitSecond") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:unitWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl_time:TemporalUnit</para>
    ///
    /// labels<para>Week (unit of temporal duration)</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#unitWeek">http://www.w3.org/2006/time#unitWeek</seealso>
    let unitWeek = Prefixed_Name(owl_time, "unitWeek") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:unitYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl_time:TemporalUnit</para>
    ///
    /// labels<para>Year (unit of temporal duration)</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#unitYear">http://www.w3.org/2006/time#unitYear</seealso>
    let unitYear = Prefixed_Name(owl_time, "unitYear") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:xsdDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Value of DateTimeInterval expressed as a compact value.</para>
    /// labels<para>has XSD date-time</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#xsdDateTime">http://www.w3.org/2006/time#xsdDateTime</seealso>
    let xsdDateTime = Prefixed_Name(owl_time, "xsdDateTime") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Year position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar year from any calendar. </para>
    /// labels<para>year</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#year">http://www.w3.org/2006/time#year</seealso>
    let year = Prefixed_Name(owl_time, "year") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:Instant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A temporal entity with zero extent or duration</para>
    /// labels<para>Time instant</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#Instant">http://www.w3.org/2006/time#Instant</seealso>
    let Instant = Prefixed_Name(owl_time, "Instant") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:January</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>January</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#January">http://www.w3.org/2006/time#January</seealso>
    let January = Prefixed_Name(owl_time, "January") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:unitDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl_time:TemporalUnit</para>
    ///
    /// labels<para>Day (unit of temporal duration)</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#unitDay">http://www.w3.org/2006/time#unitDay</seealso>
    let unitDay = Prefixed_Name(owl_time, "unitDay") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:month</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Month position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar month from any calendar. </para>
    /// labels<para>month</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#month">http://www.w3.org/2006/time#month</seealso>
    let month = Prefixed_Name(owl_time, "month") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:DateTimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>DateTimeInterval is a subclass of ProperInterval, defined using the multi-element DateTimeDescription.</para>
    /// labels<para>Date-time interval</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#DateTimeInterval">http://www.w3.org/2006/time#DateTimeInterval</seealso>
    let DateTimeInterval = Prefixed_Name(owl_time, "DateTimeInterval") |> PrefixedName

    /// <summary>
    ///   <para>owl_time:GeneralDateTimeDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of date and time structured with separate values for the various elements of a calendar-clock system</para>
    /// labels<para>Generalized date-time description</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#GeneralDateTimeDescription">http://www.w3.org/2006/time#GeneralDateTimeDescription</seealso>
    let GeneralDateTimeDescription =
        Prefixed_Name(owl_time, "GeneralDateTimeDescription") |> PrefixedName

    /// <summary>
    ///   <para>owl_time:unitType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The temporal unit which provides the precision of a date-time value or scale of a temporal extent</para>
    /// labels<para>temporal unit type</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#unitType">http://www.w3.org/2006/time#unitType</seealso>
    let unitType = Prefixed_Name(owl_time, "unitType") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:DayOfWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The day of week</para>
    /// labels<para>Day of week</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#DayOfWeek">http://www.w3.org/2006/time#DayOfWeek</seealso>
    let DayOfWeek = Prefixed_Name(owl_time, "DayOfWeek") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:months</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>length of, or element of the length of, a temporal extent expressed in months</para>
    /// labels<para>months duration</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#months">http://www.w3.org/2006/time#months</seealso>
    let months = Prefixed_Name(owl_time, "months") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:Wednesday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl_time:DayOfWeek</para>
    ///
    /// labels<para>Wednesday</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#Wednesday">http://www.w3.org/2006/time#Wednesday</seealso>
    let Wednesday = Prefixed_Name(owl_time, "Wednesday") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:days</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>length of, or element of the length of, a temporal extent expressed in days</para>
    /// labels<para>days duration</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#days">http://www.w3.org/2006/time#days</seealso>
    let days = Prefixed_Name(owl_time, "days") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:seconds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>length of, or element of the length of, a temporal extent expressed in seconds</para>
    /// labels<para>seconds duration</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#seconds">http://www.w3.org/2006/time#seconds</seealso>
    let seconds = Prefixed_Name(owl_time, "seconds") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:generalYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>Year number - formulated as a text string with a pattern constraint to reproduce the same lexical form as gYear, but not restricted to values from the Gregorian calendar.
    /// Note that the value-space is not defined, so a generic OWL2 processor cannot compute ordering relationships of values of this type.</para>
    /// labels<para>Generalized year</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#generalYear">http://www.w3.org/2006/time#generalYear</seealso>
    let generalYear = Prefixed_Name(owl_time, "generalYear") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:hasBeginning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Beginning of a temporal entity</para>
    /// labels<para>has beginning</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#hasBeginning">http://www.w3.org/2006/time#hasBeginning</seealso>
    let hasBeginning = Prefixed_Name(owl_time, "hasBeginning") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:hasTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Supports the association of a temporal entity (instant or interval) to any thing</para>
    /// labels<para>has time</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#hasTime">http://www.w3.org/2006/time#hasTime</seealso>
    let hasTime = Prefixed_Name(owl_time, "hasTime") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:hasDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Duration of a temporal entity, expressed as a scaled value or nominal value</para>
    /// labels<para>has duration</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#hasDuration">http://www.w3.org/2006/time#hasDuration</seealso>
    let hasDuration = Prefixed_Name(owl_time, "hasDuration") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:Year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>owl:Class</para>
    ///   <para>Year duration</para>
    /// labels<para>Year</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#Year">http://www.w3.org/2006/time#Year</seealso>
    let Year = Prefixed_Name(owl_time, "Year") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:generalMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>Month of year - formulated as a text string with a pattern constraint to reproduce the same lexical form as gMonth, except that values up to 20 are permitted, in order to support calendars with more than 12 months in the year.
    /// Note that the value-space is not defined, so a generic OWL2 processor cannot compute ordering relationships of values of this type.</para>
    /// labels<para>Generalized month</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#generalMonth">http://www.w3.org/2006/time#generalMonth</seealso>
    let generalMonth = Prefixed_Name(owl_time, "generalMonth") |> PrefixedName

    /// <summary>
    ///   <para>owl_time:hasTemporalDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Duration of a temporal entity.</para>
    /// labels<para>has temporal duration</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#hasTemporalDuration">http://www.w3.org/2006/time#hasTemporalDuration</seealso>
    let hasTemporalDuration =
        Prefixed_Name(owl_time, "hasTemporalDuration") |> PrefixedName

    /// <summary>
    ///   <para>owl_time:hasEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>End of a temporal entity.</para>
    /// labels<para>has end</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#hasEnd">http://www.w3.org/2006/time#hasEnd</seealso>
    let hasEnd = Prefixed_Name(owl_time, "hasEnd") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:minute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Minute position in a calendar-clock system.</para>
    /// labels<para>minute</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#minute">http://www.w3.org/2006/time#minute</seealso>
    let minute = Prefixed_Name(owl_time, "minute") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:hour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Hour position in a calendar-clock system.</para>
    /// labels<para>hour</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#hour">http://www.w3.org/2006/time#hour</seealso>
    let hour = Prefixed_Name(owl_time, "hour") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:week</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Week number within the year.</para>
    /// labels<para>week</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#week">http://www.w3.org/2006/time#week</seealso>
    let week = Prefixed_Name(owl_time, "week") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:TemporalPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A position on a time-line</para>
    /// labels<para>Temporal position</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#TemporalPosition">http://www.w3.org/2006/time#TemporalPosition</seealso>
    let TemporalPosition = Prefixed_Name(owl_time, "TemporalPosition") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:monthOfYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The month of the year, whose value is a member of the class time:MonthOfYear</para>
    /// labels<para>month of year</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#monthOfYear">http://www.w3.org/2006/time#monthOfYear</seealso>
    let monthOfYear = Prefixed_Name(owl_time, "monthOfYear") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:second</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Second position in a calendar-clock system.</para>
    /// labels<para>second</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#second">http://www.w3.org/2006/time#second</seealso>
    let second = Prefixed_Name(owl_time, "second") |> PrefixedName

    /// <summary>
    ///   <para>owl_time:inTemporalPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Position of a time instant</para>
    /// labels<para>Temporal position</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#inTemporalPosition">http://www.w3.org/2006/time#inTemporalPosition</seealso>
    let inTemporalPosition =
        Prefixed_Name(owl_time, "inTemporalPosition") |> PrefixedName

    /// <summary>
    ///   <para>owl_time:inXSDDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Position of an instant, expressed using xsd:date</para>
    /// labels<para>in XSD date</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#inXSDDate">http://www.w3.org/2006/time#inXSDDate</seealso>
    let inXSDDate = Prefixed_Name(owl_time, "inXSDDate") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:inXSDDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Position of an instant, expressed using xsd:dateTime</para>
    /// labels<para>in XSD Date-Time</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#inXSDDateTime">http://www.w3.org/2006/time#inXSDDateTime</seealso>
    let inXSDDateTime = Prefixed_Name(owl_time, "inXSDDateTime") |> PrefixedName

    /// <summary>
    ///   <para>owl_time:inXSDDateTimeStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Position of an instant, expressed using xsd:dateTimeStamp</para>
    /// labels<para>in XSD Date-Time-Stamp</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#inXSDDateTimeStamp">http://www.w3.org/2006/time#inXSDDateTimeStamp</seealso>
    let inXSDDateTimeStamp =
        Prefixed_Name(owl_time, "inXSDDateTimeStamp") |> PrefixedName

    /// <summary>
    ///   <para>owl_time:inXSDgYearMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Position of an instant, expressed using xsd:gYearMonth</para>
    /// labels<para>in XSD g-YearMonth</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#inXSDgYearMonth">http://www.w3.org/2006/time#inXSDgYearMonth</seealso>
    let inXSDgYearMonth = Prefixed_Name(owl_time, "inXSDgYearMonth") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:intervalBefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If a proper interval T1 is intervalBefore another proper interval T2, then the end of T1 is before the beginning of T2.</para>
    /// labels<para>interval before</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#intervalBefore">http://www.w3.org/2006/time#intervalBefore</seealso>
    let intervalBefore = Prefixed_Name(owl_time, "intervalBefore") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:intervalIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If a proper interval T1 is intervalIn another proper interval T2, then the beginning of T1 is after the beginning of T2 or is coincident with the beginning of T2, and the end of T1 is before the end of T2, or is coincident with the end of T2, except that end of T1 may not be coincident with the end of T2 if the beginning of T1 is coincident with the beginning of T2.</para>
    /// labels<para>interval in</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#intervalIn">http://www.w3.org/2006/time#intervalIn</seealso>
    let intervalIn = Prefixed_Name(owl_time, "intervalIn") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:intervalFinishes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If a proper interval T1 is intervalFinishes another proper interval T2, then the beginning of T1 is after the beginning of T2, and the end of T1 is coincident with the end of T2.</para>
    /// labels<para>interval finishes</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#intervalFinishes">http://www.w3.org/2006/time#intervalFinishes</seealso>
    let intervalFinishes = Prefixed_Name(owl_time, "intervalFinishes") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:dayOfYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of the day within the year</para>
    /// labels<para>day of year</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#dayOfYear">http://www.w3.org/2006/time#dayOfYear</seealso>
    let dayOfYear = Prefixed_Name(owl_time, "dayOfYear") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:TemporalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A temporal interval or instant.</para>
    /// labels<para>Temporal entity</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#TemporalEntity">http://www.w3.org/2006/time#TemporalEntity</seealso>
    let TemporalEntity = Prefixed_Name(owl_time, "TemporalEntity") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:unitMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl_time:TemporalUnit</para>
    ///
    /// labels<para>Month (unit of temporal duration)</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#unitMonth">http://www.w3.org/2006/time#unitMonth</seealso>
    let unitMonth = Prefixed_Name(owl_time, "unitMonth") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:Monday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl_time:DayOfWeek</para>
    ///
    /// labels<para>Monday</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#Monday">http://www.w3.org/2006/time#Monday</seealso>
    let Monday = Prefixed_Name(owl_time, "Monday") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:MonthOfYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The month of the year</para>
    /// labels<para>Month of year</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#MonthOfYear">http://www.w3.org/2006/time#MonthOfYear</seealso>
    let MonthOfYear = Prefixed_Name(owl_time, "MonthOfYear") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:Saturday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl_time:DayOfWeek</para>
    ///
    /// labels<para>Saturday</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#Saturday">http://www.w3.org/2006/time#Saturday</seealso>
    let Saturday = Prefixed_Name(owl_time, "Saturday") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:TRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A temporal reference system, such as a temporal coordinate system (with an origin, direction, and scale), a calendar-clock combination, or a (possibly hierarchical) ordinal system.
    ///
    /// This is a stub class, representing the set of all temporal reference systems.</para>
    /// labels<para>Temporal Reference System</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#TRS">http://www.w3.org/2006/time#TRS</seealso>
    let TRS = Prefixed_Name(owl_time, "TRS") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:TemporalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A standard duration, which provides a scale factor for a time extent, or the granularity or precision for a time position.</para>
    /// labels<para>Temporal unit</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#TemporalUnit">http://www.w3.org/2006/time#TemporalUnit</seealso>
    let TemporalUnit = Prefixed_Name(owl_time, "TemporalUnit") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:Thursday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl_time:DayOfWeek</para>
    ///
    /// labels<para>Thursday</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#Thursday">http://www.w3.org/2006/time#Thursday</seealso>
    let Thursday = Prefixed_Name(owl_time, "Thursday") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:TimePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A temporal position described using either a (nominal) value from an ordinal reference system, or a (numeric) value in a temporal coordinate system. </para>
    /// labels<para>Time position</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#TimePosition">http://www.w3.org/2006/time#TimePosition</seealso>
    let TimePosition = Prefixed_Name(owl_time, "TimePosition") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:numericPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The (numeric) value indicating position within a temporal coordinate system </para>
    /// labels<para>Numeric value of temporal position</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#numericPosition">http://www.w3.org/2006/time#numericPosition</seealso>
    let numericPosition = Prefixed_Name(owl_time, "numericPosition") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:nominalPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The (nominal) value indicating temporal position in an ordinal reference system </para>
    /// labels<para>Name of temporal position</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#nominalPosition">http://www.w3.org/2006/time#nominalPosition</seealso>
    let nominalPosition = Prefixed_Name(owl_time, "nominalPosition") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:TimeZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Time Zone specifies the amount by which the local time is offset from UTC.
    /// 	A time zone is usually denoted geographically (e.g. Australian Eastern Daylight Time), with a constant value in a given region.
    /// The region where it applies and the offset from UTC are specified by a locally recognised governing authority.</para>
    /// labels<para>Time Zone</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#TimeZone">http://www.w3.org/2006/time#TimeZone</seealso>
    let TimeZone = Prefixed_Name(owl_time, "TimeZone") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:Tuesday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl_time:DayOfWeek</para>
    ///
    /// labels<para>Tuesday</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#Tuesday">http://www.w3.org/2006/time#Tuesday</seealso>
    let Tuesday = Prefixed_Name(owl_time, "Tuesday") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:Interval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A temporal entity with an extent or duration</para>
    /// labels<para>Time interval</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#Interval">http://www.w3.org/2006/time#Interval</seealso>
    let Interval = Prefixed_Name(owl_time, "Interval") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:Sunday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl_time:DayOfWeek</para>
    ///
    /// labels<para>Sunday</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#Sunday">http://www.w3.org/2006/time#Sunday</seealso>
    let Sunday = Prefixed_Name(owl_time, "Sunday") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:day</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Day position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar day from any calendar. </para>
    /// labels<para>day</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#day">http://www.w3.org/2006/time#day</seealso>
    let day = Prefixed_Name(owl_time, "day") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:ProperInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A temporal entity with non-zero extent or duration, i.e. for which the value of the beginning and end are different</para>
    /// labels<para>Proper interval</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#ProperInterval">http://www.w3.org/2006/time#ProperInterval</seealso>
    let ProperInterval = Prefixed_Name(owl_time, "ProperInterval") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:Duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Duration of a temporal extent expressed as a number scaled by a temporal unit</para>
    /// labels<para>Time duration</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#Duration">http://www.w3.org/2006/time#Duration</seealso>
    let Duration = Prefixed_Name(owl_time, "Duration") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:numericDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Value of a temporal extent expressed as a decimal number scaled by a temporal unit</para>
    /// labels<para>Numeric value of temporal duration</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#numericDuration">http://www.w3.org/2006/time#numericDuration</seealso>
    let numericDuration = Prefixed_Name(owl_time, "numericDuration") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:TemporalDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Time extent; duration of a time interval separate from its particular start position</para>
    /// labels<para>Temporal duration</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#TemporalDuration">http://www.w3.org/2006/time#TemporalDuration</seealso>
    let TemporalDuration = Prefixed_Name(owl_time, "TemporalDuration") |> PrefixedName

    /// <summary>
    ///   <para>owl_time:DurationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of temporal extent structured with separate values for the various elements of a calendar-clock system. The temporal reference system is fixed to Gregorian Calendar, and the range of each of the numeric properties is restricted to xsd:decimal</para>
    /// labels<para>Duration description</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#DurationDescription">http://www.w3.org/2006/time#DurationDescription</seealso>
    let DurationDescription =
        Prefixed_Name(owl_time, "DurationDescription") |> PrefixedName

    /// <summary>
    ///   <para>owl_time:GeneralDurationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of temporal extent structured with separate values for the various elements of a calendar-clock system.</para>
    /// labels<para>Generalized duration description</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#GeneralDurationDescription">http://www.w3.org/2006/time#GeneralDurationDescription</seealso>
    let GeneralDurationDescription =
        Prefixed_Name(owl_time, "GeneralDurationDescription") |> PrefixedName

    /// <summary>
    ///   <para>owl_time:weeks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>length of, or element of the length of, a temporal extent expressed in weeks</para>
    /// labels<para>weeks duration</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#weeks">http://www.w3.org/2006/time#weeks</seealso>
    let weeks = Prefixed_Name(owl_time, "weeks") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:hours</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>length of, or element of the length of, a temporal extent expressed in hours</para>
    /// labels<para>hours duration</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#hours">http://www.w3.org/2006/time#hours</seealso>
    let hours = Prefixed_Name(owl_time, "hours") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:minutes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>length, or element of, a temporal extent expressed in minutes</para>
    /// labels<para>minutes</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#minutes">http://www.w3.org/2006/time#minutes</seealso>
    let minutes = Prefixed_Name(owl_time, "minutes") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:years</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>length of, or element of the length of, a temporal extent expressed in years</para>
    /// labels<para>years duration</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#years">http://www.w3.org/2006/time#years</seealso>
    let years = Prefixed_Name(owl_time, "years") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:after</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Gives directionality to time. If a temporal entity T1 is after another temporal entity T2, then the beginning of T1 is after the end of T2.</para>
    /// labels<para>after</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#after">http://www.w3.org/2006/time#after</seealso>
    let after = Prefixed_Name(owl_time, "after") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:before</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Gives directionality to time. If a temporal entity T1 is before another temporal entity T2, then the end of T1 is before the beginning of T2. Thus, "before" can be considered to be basic to instants and derived for intervals.</para>
    /// labels<para>before</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#before">http://www.w3.org/2006/time#before</seealso>
    let before = Prefixed_Name(owl_time, "before") |> PrefixedName
    /// <summary>
    ///   <para>owl_time:generalDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>Day of month - formulated as a text string with a pattern constraint to reproduce the same lexical form as gDay, except that values up to 99 are permitted, in order to support calendars with more than 31 days in a month.
    /// Note that the value-space is not defined, so a generic OWL2 processor cannot compute ordering relationships of values of this type.</para>
    /// labels<para>Generalized day</para></remarks>
    /// <seealso href="http://www.w3.org/2006/time#generalDay">http://www.w3.org/2006/time#generalDay</seealso>
    let generalDay = Prefixed_Name(owl_time, "generalDay") |> PrefixedName
