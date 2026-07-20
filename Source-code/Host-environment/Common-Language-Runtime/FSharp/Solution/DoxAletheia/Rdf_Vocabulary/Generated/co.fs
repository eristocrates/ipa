namespace http.purl.org.ontology.co.core.hash

open DoxAletheia

module co =
    let _namespace_name = "http://purl.org/ontology/co/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Counter of a given object/ given objects, which are related to that counter.
    /// <see href="http://purl.org/ontology/co/core#Counter"></see></summary>
    let Counter = _prefix "Counter"
    /// <summary>
    /// Links a counter resource to the actual count
    /// <see href="http://purl.org/ontology/co/core#count"></see></summary>
    let count = _prefix "count"
    /// <summary>
    /// An event corresponding to a scrobbling (counting an activity, which includes at least a specific factor and
    /// a specific agent), e.g. a track being played by someone, a video watched by someone, a book read by
    /// someone, a sporting activity by someone, ...
    /// <see href="http://purl.org/ontology/co/core#ScrobbleEvent"></see></summary>
    let ScrobbleEvent = _prefix "ScrobbleEvent"
    /// <summary>
    /// Links an object to a counter resource. Please feel free to create further sub properties with more restricted domains.
    /// <see href="http://purl.org/ontology/co/core#counter"></see></summary>
    let counter = _prefix "counter"
    /// <summary>
    /// Links counter resources to related events.
    /// <see href="http://purl.org/ontology/co/core#event"></see></summary>
    let event_ = _prefix "event"
    /// <summary>
    /// Links a counter resource to an object. Please feel free to create further sub properties with more restricted ranges.
    /// <see href="http://purl.org/ontology/co/core#object"></see></summary>
    let object = _prefix "object"
    /// <summary>
    /// Links events to a counter resource, where they where counted in.
    /// <see href="http://purl.org/ontology/co/core#event_counter"></see></summary>
    let event_counter = _prefix "event_counter"
    /// <summary>
    /// A scrobble object of a scrobble event, e.g. a music track, a video or a described activity. That means a specific thing that is involved in this scrobbling action.
    /// <see href="http://purl.org/ontology/co/core#scrobble_object"></see></summary>
    let scrobble_object = _prefix "scrobble_object"
