namespace http.purl.org.ontology.stories.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module stories =
    let _namespace_iri = Namespace_Iri stories |> NamespaceIRI
    /// <summary>
    ///   <para>stories:Assertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contains a set of statements in the form of an RDF graph, thus allowing for interpretations to assert beliefs about the state of the system.</para>
    /// labels<para>Assertion</para></remarks>
    /// <seealso href="http://purl.org/ontology/stories/Assertion">http://purl.org/ontology/stories/Assertion</seealso>
    let Assertion = Prefixed_Name(stories, "Assertion") |> PrefixedName
    /// <summary>
    ///   <para>stories:EventSlot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Places an Event in an EventList, with index and neighbouring Event information.</para>
    /// labels<para>EventSlot</para></remarks>
    /// <seealso href="http://purl.org/ontology/stories/EventSlot">http://purl.org/ontology/stories/EventSlot</seealso>
    let EventSlot = Prefixed_Name(stories, "EventSlot") |> PrefixedName
    /// <summary>
    ///   <para>stories:contextualises</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>contextualises</para></remarks>
    /// <seealso href="http://purl.org/ontology/stories/contextualises">http://purl.org/ontology/stories/contextualises</seealso>
    let contextualises = Prefixed_Name(stories, "contextualises") |> PrefixedName
    /// <summary>
    ///   <para>stories:interprets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The thing which is interpreted by this interpretation.</para>
    /// labels<para>interprets</para></remarks>
    /// <seealso href="http://purl.org/ontology/stories/interprets">http://purl.org/ontology/stories/interprets</seealso>
    let interprets = Prefixed_Name(stories, "interprets") |> PrefixedName
    /// <summary>
    ///   <para>stories:Story</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A story that may be told, contain other stories, and have a sequence of events.</para>
    /// labels<para>Story</para></remarks>
    /// <seealso href="http://purl.org/ontology/stories/Story">http://purl.org/ontology/stories/Story</seealso>
    let Story = Prefixed_Name(stories, "Story") |> PrefixedName
    /// <summary>
    ///   <para>stories:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The subject(s) of the story. e.g. characters, events, skos concepts.</para>
    /// labels<para>subject</para></remarks>
    /// <seealso href="http://purl.org/ontology/stories/subject">http://purl.org/ontology/stories/subject</seealso>
    let subject = Prefixed_Name(stories, "subject") |> PrefixedName
    /// <summary>
    ///   <para>stories:tells</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A story told by this Thing. The Thing could be a photograph which has a story attached to it, a person, a country, a monument, etc.</para>
    /// labels<para>tells</para></remarks>
    /// <seealso href="http://purl.org/ontology/stories/tells">http://purl.org/ontology/stories/tells</seealso>
    let tells = Prefixed_Name(stories, "tells") |> PrefixedName
    /// <summary>
    ///   <para>stories:describedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The inverse of describes, this is an Event describedBy a Thing (e.g. a programme, photo)</para>
    /// labels<para>describedBy</para></remarks>
    /// <seealso href="http://purl.org/ontology/stories/describedBy">http://purl.org/ontology/stories/describedBy</seealso>
    let describedBy = Prefixed_Name(stories, "describedBy") |> PrefixedName
    /// <summary>
    ///   <para>stories:sub_story</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A story which is contained within this story. For example, a TV episode may contain stories for different characters, or one overarching story may contain several other smaller stories.</para>
    /// labels<para>sub_story</para></remarks>
    /// <seealso href="http://purl.org/ontology/stories/sub_story">http://purl.org/ontology/stories/sub_story</seealso>
    let sub_story = Prefixed_Name(stories, "sub_story") |> PrefixedName
    /// <summary>
    ///   <para>stories:supports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Thing which supports an Interpretation (e.g. a supporting document, Event, etc).</para>
    /// labels<para>supports</para></remarks>
    /// <seealso href="http://purl.org/ontology/stories/supports">http://purl.org/ontology/stories/supports</seealso>
    let supports = Prefixed_Name(stories, "supports") |> PrefixedName
    /// <summary>
    ///   <para>stories:slot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>slot</para></remarks>
    /// <seealso href="http://purl.org/ontology/stories/slot">http://purl.org/ontology/stories/slot</seealso>
    let slot = Prefixed_Name(stories, "slot") |> PrefixedName
    /// <summary>
    ///   <para>stories:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>Stories Ontology</para></remarks>
    /// <seealso href="http://purl.org/ontology/stories/">http://purl.org/ontology/stories/</seealso>
    let _prefix_iri = Prefixed_Name(stories, "") |> PrefixedName
    /// <summary>
    ///   <para>stories:EventList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provides a means to create an ordered list of events that occur within a story - effectively a pairing of an Event and a numeric position.</para>
    /// labels<para>EventList</para></remarks>
    /// <seealso href="http://purl.org/ontology/stories/EventList">http://purl.org/ontology/stories/EventList</seealso>
    let EventList = Prefixed_Name(stories, "EventList") |> PrefixedName
    /// <summary>
    ///   <para>stories:Interpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An interpretation of something in the context of a story, given some supporting material. This is the viewpoint of the interpretation's creator, and may assert statements about the item.</para>
    /// labels<para>Interpretation</para></remarks>
    /// <seealso href="http://purl.org/ontology/stories/Interpretation">http://purl.org/ontology/stories/Interpretation</seealso>
    let Interpretation = Prefixed_Name(stories, "Interpretation") |> PrefixedName
    /// <summary>
    ///   <para>stories:asserts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Assertion which is asserted by this interpretation.</para>
    /// labels<para>asserts</para></remarks>
    /// <seealso href="http://purl.org/ontology/stories/asserts">http://purl.org/ontology/stories/asserts</seealso>
    let asserts = Prefixed_Name(stories, "asserts") |> PrefixedName
    /// <summary>
    ///   <para>stories:describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Thing which describes an Event. This could be a Media Fragment, an Image, etc.</para>
    /// labels<para>describes</para></remarks>
    /// <seealso href="http://purl.org/ontology/stories/describes">http://purl.org/ontology/stories/describes</seealso>
    let describes = Prefixed_Name(stories, "describes") |> PrefixedName
    /// <summary>
    ///   <para>stories:events</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An ordered list of Events within this story.</para>
    /// labels<para>event</para></remarks>
    /// <seealso href="http://purl.org/ontology/stories/events">http://purl.org/ontology/stories/events</seealso>
    let events = Prefixed_Name(stories, "events") |> PrefixedName
    /// <summary>
    ///   <para>stories:facts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Facts asserted by this assertion, in the form of an RDF graph.</para>
    /// labels<para>facts</para></remarks>
    /// <seealso href="http://purl.org/ontology/stories/facts">http://purl.org/ontology/stories/facts</seealso>
    let facts = Prefixed_Name(stories, "facts") |> PrefixedName
    /// <summary>
    ///   <para>stories:item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>item</para></remarks>
    /// <seealso href="http://purl.org/ontology/stories/item">http://purl.org/ontology/stories/item</seealso>
    let item = Prefixed_Name(stories, "item") |> PrefixedName
