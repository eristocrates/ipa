namespace http.purl.org.ontology.storyline.slash

open DoxAletheia.Rdf_Vocabulary

module nsl =
    let _namespace_name = "http://purl.org/ontology/storyline/"
    /// <summary>
    ///   <see href="http://purl.org/ontology/storyline/0.2"></see>
    /// </summary>
    let ``_0.2`` = Namespaced_IRI.parse _namespace_name "0.2" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/storyline/0.3"></see>
    /// </summary>
    let ``_0.3`` = Namespaced_IRI.parse _namespace_name "0.3" |> NamespacedName

    /// <summary>
    /// Attribution of a storyline used for attributing the interpretation of the storyline to some agent. An interface class, that doesn't restrict the implementation of an attribution.
    /// <see href="http://purl.org/ontology/storyline/Attribution"></see></summary>
    let Attribution =
        Namespaced_IRI.parse _namespace_name "Attribution" |> NamespacedName

    /// <summary>
    /// A newsworthy event. An un-disputable real world event.
    /// <see href="http://purl.org/ontology/storyline/Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    /// An abstract parent class of storyline components.
    /// <see href="http://purl.org/ontology/storyline/StorylineComponent"></see></summary>
    let StorylineComponent =
        Namespaced_IRI.parse _namespace_name "StorylineComponent" |> NamespacedName

    /// <summary>
    /// A news storyline.
    /// <see href="http://purl.org/ontology/storyline/Storyline"></see></summary>
    let Storyline = Namespaced_IRI.parse _namespace_name "Storyline" |> NamespacedName

    /// <summary>
    /// A storyline slot, used as a container for storyline components.
    /// <see href="http://purl.org/ontology/storyline/StorylineSlot"></see></summary>
    let StorylineSlot =
        Namespaced_IRI.parse _namespace_name "StorylineSlot" |> NamespacedName

    /// <summary>
    /// The topic of a storyline. An interface to some concept in a knowledge domain.
    /// <see href="http://purl.org/ontology/storyline/Topic"></see></summary>
    let Topic = Namespaced_IRI.parse _namespace_name "Topic" |> NamespacedName

    /// <summary>
    /// Associates a storyline to its attribution. Provides for interpretation provenance through attribution
    /// <see href="http://purl.org/ontology/storyline/attributedTo"></see></summary>
    let attributedTo =
        Namespaced_IRI.parse _namespace_name "attributedTo" |> NamespacedName

    /// <summary>
    /// An editorial comment on a storyline
    /// <see href="http://purl.org/ontology/storyline/comment"></see></summary>
    let comment = Namespaced_IRI.parse _namespace_name "comment" |> NamespacedName
    /// <summary>
    /// Associates a Slot to a StorylineComponent contained therein. Can be a news event or another storyline
    /// <see href="http://purl.org/ontology/storyline/contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName

    /// <summary>
    /// The date a storyline was created
    /// <see href="http://purl.org/ontology/storyline/dateCreated"></see></summary>
    let dateCreated =
        Namespaced_IRI.parse _namespace_name "dateCreated" |> NamespacedName

    /// <summary>
    /// Allows one or more slots to be sequenced. Slot A follows Slot B.
    /// <see href="http://purl.org/ontology/storyline/follows"></see></summary>
    let follows = Namespaced_IRI.parse _namespace_name "follows" |> NamespacedName
    /// <summary>
    /// Associates a slot to a storyline as a chapter of an existing storyline.
    /// <see href="http://purl.org/ontology/storyline/hasChapter"></see></summary>
    let hasChapter = Namespaced_IRI.parse _namespace_name "hasChapter" |> NamespacedName
    /// <summary>
    /// Associates a slot to a storyline. A storyline can have many slots
    /// <see href="http://purl.org/ontology/storyline/hasSlot"></see></summary>
    let hasSlot = Namespaced_IRI.parse _namespace_name "hasSlot" |> NamespacedName

    /// <summary>
    /// Associates a slot to a storyline as a development of an existing storyline.
    /// <see href="http://purl.org/ontology/storyline/hasDevelopment"></see></summary>
    let hasDevelopment =
        Namespaced_IRI.parse _namespace_name "hasDevelopment" |> NamespacedName

    /// <summary>
    /// Associates a slot to a storyline as an update to an existing storyline.
    /// <see href="http://purl.org/ontology/storyline/hasUpdate"></see></summary>
    let hasUpdate = Namespaced_IRI.parse _namespace_name "hasUpdate" |> NamespacedName
    /// <summary>
    /// A slot index. Allows slots to be ordered numerically
    /// <see href="http://purl.org/ontology/storyline/index"></see></summary>
    let index = Namespaced_IRI.parse _namespace_name "index" |> NamespacedName
    /// <summary>
    /// The synopsis of a storyline
    /// <see href="http://purl.org/ontology/storyline/synopsis"></see></summary>
    let synopsis = Namespaced_IRI.parse _namespace_name "synopsis" |> NamespacedName
    /// <summary>
    /// The time of a slot. A Temporal entity, an interval. Allows slots to be ordered temporally.
    /// <see href="http://purl.org/ontology/storyline/time"></see></summary>
    let time = Namespaced_IRI.parse _namespace_name "time" |> NamespacedName
    /// <summary>
    /// A title of a storyline
    /// <see href="http://purl.org/ontology/storyline/title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    /// Associates a slot to a topic
    /// <see href="http://purl.org/ontology/storyline/topic"></see></summary>
    let topic = Namespaced_IRI.parse _namespace_name "topic" |> NamespacedName
