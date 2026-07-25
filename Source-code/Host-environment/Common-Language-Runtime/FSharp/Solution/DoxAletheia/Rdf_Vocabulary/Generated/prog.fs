namespace http.purl.org.prog.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module prog =
    let _namespace_iri = Namespace_Iri prog |> NamespaceIRI
    /// <summary>
    ///   <para>prog:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/prog/">http://purl.org/prog/</seealso>
    let _prefix_iri = Prefixed_Name(prog, "") |> PrefixedName
    /// <summary>
    ///   <para>prog:Programme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A programme is a description of the parts of a complex event to aid understanding it. A single event may be described by several programmes, for example one may give a break down by day, another by rooms, another by topic.
    ///
    /// A programme should not have Timeslots or Events if it subprogrammes. In effect this means there are two subclasses of Programme, but there's no need to express that in the data.
    ///
    /// A simple application only needs to operate on a single Programme at once.</para>
    /// labels<para>Programme</para></remarks>
    /// <seealso href="http://purl.org/prog/Programme">http://purl.org/prog/Programme</seealso>
    let Programme = Prefixed_Name(prog, "Programme") |> PrefixedName
    /// <summary>
    ///   <para>prog:has_programme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Connects an ev:Event with a prog:Programme which describes it.</para>
    /// labels<para>event is described by programme</para></remarks>
    /// <seealso href="http://purl.org/prog/has_programme">http://purl.org/prog/has_programme</seealso>
    let has_programme = Prefixed_Name(prog, "has_programme") |> PrefixedName
    /// <summary>
    ///   <para>prog:has_streamed_event</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates that an Event is part of the specified programme, and should appear in any relevant 'streams' based on its subject or location. If it matches no things for which the programme is prog:streamed_by_location, prog:streamed_by_parent_event or prog:streamed_by_subject then a tool may choose to report this as broken data.</para>
    /// labels<para>programme includes streamed event</para></remarks>
    /// <seealso href="http://purl.org/prog/has_streamed_event">http://purl.org/prog/has_streamed_event</seealso>
    let has_streamed_event = Prefixed_Name(prog, "has_streamed_event") |> PrefixedName

    /// <summary>
    ///   <para>prog:streamed_by_location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates that one of the streams in this visualisation is events with a event:place relating them to the geo:SpatialThing indicated. This is the most common way an programme is designed.</para>
    /// labels<para>programme has a stream for location</para></remarks>
    /// <seealso href="http://purl.org/prog/streamed_by_location">http://purl.org/prog/streamed_by_location</seealso>
    let streamed_by_location =
        Prefixed_Name(prog, "streamed_by_location") |> PrefixedName

    /// <summary>
    ///   <para>prog:Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class represents the abstract content of an event, which may be repeated many times, once or never. For example a training course, or a play. The primary purpose is to indicate that several events will have very similar content, to aid planning what to attend. It does not indicate that there is any reason people could not attend more than one realisation. It should not be used to abstract a repeating event, such as morning coffee or a monthly meeting.
    ///
    ///
    /// Multiple Events may reference that they are realises of the same Activity.
    /// Activities are not Events and may not have a time or place.</para>
    /// labels<para>Activity</para></remarks>
    /// <seealso href="http://purl.org/prog/Activity">http://purl.org/prog/Activity</seealso>
    let Activity = Prefixed_Name(prog, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>prog:has_event</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates that an Event is part of the specified programme, but not streamed in any particular way. This should not relate a programme to the event it is a programme of. This is used for events in programmes without streams, or for events which are listed in all streams, such as 'Lunch','Check into Accomodation' or 'Plenary'.</para>
    /// labels<para>programme includes event</para></remarks>
    /// <seealso href="http://purl.org/prog/has_event">http://purl.org/prog/has_event</seealso>
    let has_event = Prefixed_Name(prog, "has_event") |> PrefixedName
    /// <summary>
    ///   <para>prog:has_sidebar_event</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates that an Event is part of the specified programme, but is not part of the normal grid and should be listed separately. Evening events, for example, may be included in this way. Other users include all-day events such as 'exhibition in main hall', for which you do not want to use up 'real-estate' in a grid-display of this programme.</para>
    /// labels<para>programme includes sidebar event</para></remarks>
    /// <seealso href="http://purl.org/prog/has_sidebar_event">http://purl.org/prog/has_sidebar_event</seealso>
    let has_sidebar_event = Prefixed_Name(prog, "has_sidebar_event") |> PrefixedName
    /// <summary>
    ///   <para>prog:realises</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates a concrete event:Event to the prog:Activity that it is a realisation of. For example this would relate the training course on Thursday to the prog:Activity of the laser safety lecure. All realisations of the laser safety lecture have generally the same content, although details may vary. It is not expected that a normal attendee will attend more than one realisation of an Activity, although certainly not precluded at the level of detail we're working with here.</para>
    /// labels<para>event realises activity</para></remarks>
    /// <seealso href="http://purl.org/prog/realises">http://purl.org/prog/realises</seealso>
    let realises = Prefixed_Name(prog, "realises") |> PrefixedName

    /// <summary>
    ///   <para>prog:streamed_by_parent_event</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates that one of the streams in this visualisation is events that are event:sub_event of the event:Event indicated. This can be used to show several workshops in an event. This should only apply to things which are immediately stated explicitly as event:sub_event, it is assumed that the consumer will not treat this property as transitive, unless they are doing something weird or clever.</para>
    /// labels<para>programme has a stream for sub-events of</para></remarks>
    /// <seealso href="http://purl.org/prog/streamed_by_parent_event">http://purl.org/prog/streamed_by_parent_event</seealso>
    let streamed_by_parent_event =
        Prefixed_Name(prog, "streamed_by_parent_event") |> PrefixedName

    /// <summary>
    ///   <para>prog:TimeSlot</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This is a property of a Programme to facilitate understanding by humans. There is no semantic relationship between events in the programme and TimeSlots as complex programmes often have events which ignore the published timeslots. A timeslot is effectively an event with nothing but a time interval and label.
    ///
    /// A Timeslot must have an rdfs:label and a event:time linking it to a tl:Interval.
    ///
    /// Timeslots are purely cosmetic and it is not recommended that events should not be artificially fitted into them.</para>
    /// labels<para>TimeSlot</para></remarks>
    /// <seealso href="http://purl.org/prog/TimeSlot">http://purl.org/prog/TimeSlot</seealso>
    let TimeSlot = Prefixed_Name(prog, "TimeSlot") |> PrefixedName
    /// <summary>
    ///   <para>prog:streamed_by_subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates that one of the streams in this visualisation is events with a dcterms:subject relating them to the skos:Concept indicated.</para>
    /// labels<para>programme has a stream for subject</para></remarks>
    /// <seealso href="http://purl.org/prog/streamed_by_subject">http://purl.org/prog/streamed_by_subject</seealso>
    let streamed_by_subject = Prefixed_Name(prog, "streamed_by_subject") |> PrefixedName
    /// <summary>
    ///   <para>prog:has_timeslot</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates that a TimeSlot is part of the specified programme.</para>
    /// labels<para>programme has timeslot</para></remarks>
    /// <seealso href="http://purl.org/prog/has_timeslot">http://purl.org/prog/has_timeslot</seealso>
    let has_timeslot = Prefixed_Name(prog, "has_timeslot") |> PrefixedName
