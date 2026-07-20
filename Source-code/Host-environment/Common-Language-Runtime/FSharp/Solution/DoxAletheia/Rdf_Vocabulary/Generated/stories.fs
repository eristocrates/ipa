namespace http.purl.org.ontology.stories.slash

open DoxAletheia

module stories =
    let _namespace_name = "http://purl.org/ontology/stories/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Contains a set of statements in the form of an RDF graph, thus allowing for interpretations to assert beliefs about the state of the system.
    /// <see href="http://purl.org/ontology/stories/Assertion"></see></summary>
    let Assertion = _prefix "Assertion"
    /// <summary>
    /// Provides a means to create an ordered list of events that occur within a story - effectively a pairing of an Event and a numeric position.
    /// <see href="http://purl.org/ontology/stories/EventList"></see></summary>
    let EventList = _prefix "EventList"
    /// <summary>
    /// Places an Event in an EventList, with index and neighbouring Event information.
    /// <see href="http://purl.org/ontology/stories/EventSlot"></see></summary>
    let EventSlot = _prefix "EventSlot"
    /// <summary>
    /// An interpretation of something in the context of a story, given some supporting material. This is the viewpoint of the interpretation's creator, and may assert statements about the item.
    /// <see href="http://purl.org/ontology/stories/Interpretation"></see></summary>
    let Interpretation = _prefix "Interpretation"
    /// <summary>
    /// A story that may be told, contain other stories, and have a sequence of events.
    /// <see href="http://purl.org/ontology/stories/Story"></see></summary>
    let Story = _prefix "Story"
    /// <summary>
    /// The Assertion which is asserted by this interpretation.
    /// <see href="http://purl.org/ontology/stories/asserts"></see></summary>
    let asserts = _prefix "asserts"
    /// <summary>
    ///   <see href="http://purl.org/ontology/stories/contextualises"></see>
    /// </summary>
    let contextualises = _prefix "contextualises"
    /// <summary>
    /// The inverse of describes, this is an Event describedBy a Thing (e.g. a programme, photo)
    /// <see href="http://purl.org/ontology/stories/describedBy"></see></summary>
    let describedBy = _prefix "describedBy"
    /// <summary>
    /// A Thing which describes an Event. This could be a Media Fragment, an Image, etc.
    /// <see href="http://purl.org/ontology/stories/describes"></see></summary>
    let describes = _prefix "describes"
    /// <summary>
    /// An ordered list of Events within this story.
    /// <see href="http://purl.org/ontology/stories/events"></see></summary>
    let events = _prefix "events"
    /// <summary>
    /// Facts asserted by this assertion, in the form of an RDF graph.
    /// <see href="http://purl.org/ontology/stories/facts"></see></summary>
    let facts = _prefix "facts"
    /// <summary>
    /// The thing which is interpreted by this interpretation.
    /// <see href="http://purl.org/ontology/stories/interprets"></see></summary>
    let interprets = _prefix "interprets"
    /// <summary>
    ///   <see href="http://purl.org/ontology/stories/item"></see>
    /// </summary>
    let item = _prefix "item"
    /// <summary>
    ///   <see href="http://purl.org/ontology/stories/slot"></see>
    /// </summary>
    let slot = _prefix "slot"
    /// <summary>
    /// A story which is contained within this story. For example, a TV episode may contain stories for different characters, or one overarching story may contain several other smaller stories.
    /// <see href="http://purl.org/ontology/stories/sub_story"></see></summary>
    let sub_story = _prefix "sub_story"
    /// <summary>
    /// The subject(s) of the story. e.g. characters, events, skos concepts.
    /// <see href="http://purl.org/ontology/stories/subject"></see></summary>
    let subject = _prefix "subject"
    /// <summary>
    /// A Thing which supports an Interpretation (e.g. a supporting document, Event, etc).
    /// <see href="http://purl.org/ontology/stories/supports"></see></summary>
    let supports = _prefix "supports"
    /// <summary>
    /// A story told by this Thing. The Thing could be a photograph which has a story attached to it, a person, a country, a monument, etc.
    /// <see href="http://purl.org/ontology/stories/tells"></see></summary>
    let tells = _prefix "tells"
