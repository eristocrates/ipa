#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module prog =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/prog/" "prog"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Activity^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the abstract content of an event, which may be repeated many times, once or never. For example a training course, or a play. The primary purpose is to indicate that several events will have very similar content, to aid planning what to attend. It does not indicate that there is any reason people could not attend more than one realisation. It should not be used to abstract a repeating event, such as morning coffee or a monthly meeting.
    ///
    ///
    /// Multiple Events may reference that they are realises of the same Activity.
    /// Activities are not Events and may not have a time or place.^^xsd:string</para>
    ///   <a href="http://purl.org/prog/Activity">prog:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    /// <summary>
    ///   <para>rdfs:label : Programme^^xsd:string</para>
    ///   <para>rdfs:comment : A programme is a description of the parts of a complex event to aid understanding it. A single event may be described by several programmes, for example one may give a break down by day, another by rooms, another by topic.
    ///
    /// A programme should not have Timeslots or Events if it subprogrammes. In effect this means there are two subclasses of Programme, but there's no need to express that in the data.
    ///
    /// A simple application only needs to operate on a single Programme at once.^^xsd:string</para>
    ///   <a href="http://purl.org/prog/Programme">prog:Programme</a>
    /// </summary>
    let Programme = _prefixId.prefix "Programme"
    /// <summary>
    ///   <para>rdfs:label : TimeSlot^^xsd:string</para>
    ///   <para>rdfs:comment : This is a property of a Programme to facilitate understanding by humans. There is no semantic relationship between events in the programme and TimeSlots as complex programmes often have events which ignore the published timeslots. A timeslot is effectively an event with nothing but a time interval and label.
    ///
    /// A Timeslot must have an rdfs:label and a event:time linking it to a tl:Interval.
    ///
    /// Timeslots are purely cosmetic and it is not recommended that events should not be artificially fitted into them.^^xsd:string</para>
    ///   <a href="http://purl.org/prog/TimeSlot">prog:TimeSlot</a>
    /// </summary>
    let TimeSlot = _prefixId.prefix "TimeSlot"
    /// <summary>
    ///   <para>rdfs:label : programme includes event^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that an Event is part of the specified programme, but not streamed in any particular way. This should not relate a programme to the event it is a programme of. This is used for events in programmes without streams, or for events which are listed in all streams, such as 'Lunch','Check into Accomodation' or 'Plenary'.^^xsd:string</para>
    ///   <a href="http://purl.org/prog/has_event">prog:has_event</a>
    /// </summary>
    let has_event = _prefixId.prefix "has_event"
    /// <summary>
    ///   <para>rdfs:label : event is described by programme^^xsd:string</para>
    ///   <para>rdfs:comment : Connects an ev:Event with a prog:Programme which describes it.^^xsd:string</para>
    ///   <a href="http://purl.org/prog/has_programme">prog:has_programme</a>
    /// </summary>
    let has_programme = _prefixId.prefix "has_programme"
    /// <summary>
    ///   <para>rdfs:label : programme includes sidebar event^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that an Event is part of the specified programme, but is not part of the normal grid and should be listed separately. Evening events, for example, may be included in this way. Other users include all-day events such as 'exhibition in main hall', for which you do not want to use up 'real-estate' in a grid-display of this programme.^^xsd:string</para>
    ///   <a href="http://purl.org/prog/has_sidebar_event">prog:has_sidebar_event</a>
    /// </summary>
    let has_sidebar_event = _prefixId.prefix "has_sidebar_event"
    /// <summary>
    ///   <para>rdfs:label : programme includes streamed event^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that an Event is part of the specified programme, and should appear in any relevant 'streams' based on its subject or location. If it matches no things for which the programme is prog:streamed_by_location, prog:streamed_by_parent_event or prog:streamed_by_subject then a tool may choose to report this as broken data.^^xsd:string</para>
    ///   <a href="http://purl.org/prog/has_streamed_event">prog:has_streamed_event</a>
    /// </summary>
    let has_streamed_event = _prefixId.prefix "has_streamed_event"
    /// <summary>
    ///   <para>rdfs:label : programme has timeslot^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a TimeSlot is part of the specified programme.^^xsd:string</para>
    ///   <a href="http://purl.org/prog/has_timeslot">prog:has_timeslot</a>
    /// </summary>
    let has_timeslot = _prefixId.prefix "has_timeslot"
    /// <summary>
    ///   <para>rdfs:label : event realises activity^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a concrete event:Event to the prog:Activity that it is a realisation of. For example this would relate the training course on Thursday to the prog:Activity of the laser safety lecure. All realisations of the laser safety lecture have generally the same content, although details may vary. It is not expected that a normal attendee will attend more than one realisation of an Activity, although certainly not precluded at the level of detail we're working with here.^^xsd:string</para>
    ///   <a href="http://purl.org/prog/realises">prog:realises</a>
    /// </summary>
    let realises = _prefixId.prefix "realises"
    /// <summary>
    ///   <para>rdfs:label : programme has a stream for location^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that one of the streams in this visualisation is events with a event:place relating them to the geo:SpatialThing indicated. This is the most common way an programme is designed.^^xsd:string</para>
    ///   <a href="http://purl.org/prog/streamed_by_location">prog:streamed_by_location</a>
    /// </summary>
    let streamed_by_location = _prefixId.prefix "streamed_by_location"
    /// <summary>
    ///   <para>rdfs:label : programme has a stream for sub-events of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that one of the streams in this visualisation is events that are event:sub_event of the event:Event indicated. This can be used to show several workshops in an event. This should only apply to things which are immediately stated explicitly as event:sub_event, it is assumed that the consumer will not treat this property as transitive, unless they are doing something weird or clever.^^xsd:string</para>
    ///   <a href="http://purl.org/prog/streamed_by_parent_event">prog:streamed_by_parent_event</a>
    /// </summary>
    let streamed_by_parent_event = _prefixId.prefix "streamed_by_parent_event"
    /// <summary>
    ///   <para>rdfs:label : programme has a stream for subject^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that one of the streams in this visualisation is events with a dcterms:subject relating them to the skos:Concept indicated.^^xsd:string</para>
    ///   <a href="http://purl.org/prog/streamed_by_subject">prog:streamed_by_subject</a>
    /// </summary>
    let streamed_by_subject = _prefixId.prefix "streamed_by_subject"
