namespace http.purl.org.ontology.storyline.slash

open DoxAletheia

module nsl =
    let _namespace_name = "http://purl.org/ontology/storyline/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/storyline/0.2"></see>
    /// </summary>
    let ``_0.2`` = _prefix "0.2"
    /// <summary>
    ///   <see href="http://purl.org/ontology/storyline/0.3"></see>
    /// </summary>
    let ``_0.3`` = _prefix "0.3"
    /// <summary>
    /// Attribution of a storyline used for attributing the interpretation of the storyline to some agent. An interface class, that doesn't restrict the implementation of an attribution.
    /// <see href="http://purl.org/ontology/storyline/Attribution"></see></summary>
    let Attribution = _prefix "Attribution"
    /// <summary>
    /// A newsworthy event. An un-disputable real world event.
    /// <see href="http://purl.org/ontology/storyline/Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// An abstract parent class of storyline components.
    /// <see href="http://purl.org/ontology/storyline/StorylineComponent"></see></summary>
    let StorylineComponent = _prefix "StorylineComponent"
    /// <summary>
    /// A news storyline.
    /// <see href="http://purl.org/ontology/storyline/Storyline"></see></summary>
    let Storyline = _prefix "Storyline"
    /// <summary>
    /// A storyline slot, used as a container for storyline components.
    /// <see href="http://purl.org/ontology/storyline/StorylineSlot"></see></summary>
    let StorylineSlot = _prefix "StorylineSlot"
    /// <summary>
    /// The topic of a storyline. An interface to some concept in a knowledge domain.
    /// <see href="http://purl.org/ontology/storyline/Topic"></see></summary>
    let Topic = _prefix "Topic"
    /// <summary>
    /// Associates a storyline to its attribution. Provides for interpretation provenance through attribution
    /// <see href="http://purl.org/ontology/storyline/attributedTo"></see></summary>
    let attributedTo = _prefix "attributedTo"
    /// <summary>
    /// An editorial comment on a storyline
    /// <see href="http://purl.org/ontology/storyline/comment"></see></summary>
    let comment = _prefix "comment"
    /// <summary>
    /// Associates a Slot to a StorylineComponent contained therein. Can be a news event or another storyline
    /// <see href="http://purl.org/ontology/storyline/contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    /// The date a storyline was created
    /// <see href="http://purl.org/ontology/storyline/dateCreated"></see></summary>
    let dateCreated = _prefix "dateCreated"
    /// <summary>
    /// Allows one or more slots to be sequenced. Slot A follows Slot B.
    /// <see href="http://purl.org/ontology/storyline/follows"></see></summary>
    let follows = _prefix "follows"
    /// <summary>
    /// Associates a slot to a storyline as a chapter of an existing storyline.
    /// <see href="http://purl.org/ontology/storyline/hasChapter"></see></summary>
    let hasChapter = _prefix "hasChapter"
    /// <summary>
    /// Associates a slot to a storyline. A storyline can have many slots
    /// <see href="http://purl.org/ontology/storyline/hasSlot"></see></summary>
    let hasSlot = _prefix "hasSlot"
    /// <summary>
    /// Associates a slot to a storyline as a development of an existing storyline.
    /// <see href="http://purl.org/ontology/storyline/hasDevelopment"></see></summary>
    let hasDevelopment = _prefix "hasDevelopment"
    /// <summary>
    /// Associates a slot to a storyline as an update to an existing storyline.
    /// <see href="http://purl.org/ontology/storyline/hasUpdate"></see></summary>
    let hasUpdate = _prefix "hasUpdate"
    /// <summary>
    /// A slot index. Allows slots to be ordered numerically
    /// <see href="http://purl.org/ontology/storyline/index"></see></summary>
    let index = _prefix "index"
    /// <summary>
    /// The synopsis of a storyline
    /// <see href="http://purl.org/ontology/storyline/synopsis"></see></summary>
    let synopsis = _prefix "synopsis"
    /// <summary>
    /// The time of a slot. A Temporal entity, an interval. Allows slots to be ordered temporally.
    /// <see href="http://purl.org/ontology/storyline/time"></see></summary>
    let time = _prefix "time"
    /// <summary>
    /// A title of a storyline
    /// <see href="http://purl.org/ontology/storyline/title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// Associates a slot to a topic
    /// <see href="http://purl.org/ontology/storyline/topic"></see></summary>
    let topic = _prefix "topic"
