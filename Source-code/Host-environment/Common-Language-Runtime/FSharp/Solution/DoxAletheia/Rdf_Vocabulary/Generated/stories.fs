namespace http.purl.org.ontology.stories.slash

open DoxAletheia.Rdf_Vocabulary

module stories =
    let _namespace_name = "http://purl.org/ontology/stories/"
    /// <summary>
    /// Contains a set of statements in the form of an RDF graph, thus allowing for interpretations to assert beliefs about the state of the system.
    /// <see href="http://purl.org/ontology/stories/Assertion"></see></summary>
    let Assertion = Namespaced_IRI.parse _namespace_name "Assertion" |> NamespacedName
    /// <summary>
    /// Provides a means to create an ordered list of events that occur within a story - effectively a pairing of an Event and a numeric position.
    /// <see href="http://purl.org/ontology/stories/EventList"></see></summary>
    let EventList = Namespaced_IRI.parse _namespace_name "EventList" |> NamespacedName
    /// <summary>
    /// Places an Event in an EventList, with index and neighbouring Event information.
    /// <see href="http://purl.org/ontology/stories/EventSlot"></see></summary>
    let EventSlot = Namespaced_IRI.parse _namespace_name "EventSlot" |> NamespacedName

    /// <summary>
    /// An interpretation of something in the context of a story, given some supporting material. This is the viewpoint of the interpretation's creator, and may assert statements about the item.
    /// <see href="http://purl.org/ontology/stories/Interpretation"></see></summary>
    let Interpretation =
        Namespaced_IRI.parse _namespace_name "Interpretation" |> NamespacedName

    /// <summary>
    /// A story that may be told, contain other stories, and have a sequence of events.
    /// <see href="http://purl.org/ontology/stories/Story"></see></summary>
    let Story = Namespaced_IRI.parse _namespace_name "Story" |> NamespacedName
    /// <summary>
    /// The Assertion which is asserted by this interpretation.
    /// <see href="http://purl.org/ontology/stories/asserts"></see></summary>
    let asserts = Namespaced_IRI.parse _namespace_name "asserts" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/stories/contextualises"></see>
    /// </summary>
    let contextualises =
        Namespaced_IRI.parse _namespace_name "contextualises" |> NamespacedName

    /// <summary>
    /// The inverse of describes, this is an Event describedBy a Thing (e.g. a programme, photo)
    /// <see href="http://purl.org/ontology/stories/describedBy"></see></summary>
    let describedBy =
        Namespaced_IRI.parse _namespace_name "describedBy" |> NamespacedName

    /// <summary>
    /// A Thing which describes an Event. This could be a Media Fragment, an Image, etc.
    /// <see href="http://purl.org/ontology/stories/describes"></see></summary>
    let describes = Namespaced_IRI.parse _namespace_name "describes" |> NamespacedName
    /// <summary>
    /// An ordered list of Events within this story.
    /// <see href="http://purl.org/ontology/stories/events"></see></summary>
    let events = Namespaced_IRI.parse _namespace_name "events" |> NamespacedName
    /// <summary>
    /// Facts asserted by this assertion, in the form of an RDF graph.
    /// <see href="http://purl.org/ontology/stories/facts"></see></summary>
    let facts = Namespaced_IRI.parse _namespace_name "facts" |> NamespacedName
    /// <summary>
    /// The thing which is interpreted by this interpretation.
    /// <see href="http://purl.org/ontology/stories/interprets"></see></summary>
    let interprets = Namespaced_IRI.parse _namespace_name "interprets" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/stories/item"></see>
    /// </summary>
    let item = Namespaced_IRI.parse _namespace_name "item" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/stories/slot"></see>
    /// </summary>
    let slot = Namespaced_IRI.parse _namespace_name "slot" |> NamespacedName
    /// <summary>
    /// A story which is contained within this story. For example, a TV episode may contain stories for different characters, or one overarching story may contain several other smaller stories.
    /// <see href="http://purl.org/ontology/stories/sub_story"></see></summary>
    let sub_story = Namespaced_IRI.parse _namespace_name "sub_story" |> NamespacedName
    /// <summary>
    /// The subject(s) of the story. e.g. characters, events, skos concepts.
    /// <see href="http://purl.org/ontology/stories/subject"></see></summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName
    /// <summary>
    /// A Thing which supports an Interpretation (e.g. a supporting document, Event, etc).
    /// <see href="http://purl.org/ontology/stories/supports"></see></summary>
    let supports = Namespaced_IRI.parse _namespace_name "supports" |> NamespacedName
    /// <summary>
    /// A story told by this Thing. The Thing could be a photograph which has a story attached to it, a person, a country, a monument, etc.
    /// <see href="http://purl.org/ontology/stories/tells"></see></summary>
    let tells = Namespaced_IRI.parse _namespace_name "tells" |> NamespacedName
