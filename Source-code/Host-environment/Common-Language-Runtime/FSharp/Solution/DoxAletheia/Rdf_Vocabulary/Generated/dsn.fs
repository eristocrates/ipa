namespace http.purl.org.dsnotify.vocab.eventset.slash

open DoxAletheia

module dsn =
    let _namespace_name = "http://purl.org/dsnotify/vocab/eventset/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An event class describing that a particular resource was 'created' in a dataset. This means that one or more triples having the associated resource as subject or object were created in the corresponding RDF model.
    /// <see href="http://purl.org/dsnotify/vocab/eventset/CreateEvent"></see></summary>
    let CreateEvent = _prefix "CreateEvent"
    /// <summary>
    /// An event that changes the representations of a resource in an RDF dataset. ResourceChangeEvents are lode:Events and the lode:atTime or the lode:circa properties should be used to describe the time when the event took place.
    /// <see href="http://purl.org/dsnotify/vocab/eventset/ResourceChangeEvent"></see></summary>
    let ResourceChangeEvent = _prefix "ResourceChangeEvent"
    /// <summary>
    /// An eventset is a container of events that occur in a dataset.
    /// <see href="http://purl.org/dsnotify/vocab/eventset/Eventset"></see></summary>
    let Eventset = _prefix "Eventset"
    /// <summary>
    /// An event class describing that a particular resource was 'moved' in a dataset or between datasets. This means that all triples having the associated older resource as subject/object were replaced by triples having the target resource as subject/object in the corresponding RDF models.
    /// <see href="http://purl.org/dsnotify/vocab/eventset/MoveEvent"></see></summary>
    let MoveEvent = _prefix "MoveEvent"
    /// <summary>
    /// An event class describing that a particular resource was 'removed' from a dataset. This means that all triples having the associated resource as subject or object were removed from the corresponding RDF model.
    /// <see href="http://purl.org/dsnotify/vocab/eventset/RemoveEvent"></see></summary>
    let RemoveEvent = _prefix "RemoveEvent"
    /// <summary>
    /// An event class describing that a not further specified event occurred to a resource in a dataset.
    /// <see href="http://purl.org/dsnotify/vocab/eventset/UnknownEvent"></see></summary>
    let UnknownEvent = _prefix "UnknownEvent"
    /// <summary>
    /// An event class describing that a particular resource was 'updated' in a dataset. This means that some triples having the associated resource as subject or object were modified/created/removed in the corresponding RDF model.
    /// <see href="http://purl.org/dsnotify/vocab/eventset/UpdateEvent"></see></summary>
    let UpdateEvent = _prefix "UpdateEvent"
    /// <summary>
    /// A link to a resource that further specifies the actual triples that were added/removed in consequence of the respective ResourceChangeEvent. For example one could attach a Talis changeset here. This property is under-specified in this version on purpose.
    /// <see href="http://purl.org/dsnotify/vocab/eventset/hasAffectedTriples"></see></summary>
    let hasAffectedTriples = _prefix "hasAffectedTriples"
    /// <summary>
    /// Optional property for capturing the confidence (a float value between 0 and 1) the event detecting actor has that the corresponding event really took place. If omited, applications should assume a confidence of 1.0.
    /// <see href="http://purl.org/dsnotify/vocab/eventset/hasConfidence"></see></summary>
    let hasConfidence = _prefix "hasConfidence"
    /// <summary>
    /// An event that is part of an eventset.
    /// <see href="http://purl.org/dsnotify/vocab/eventset/hasEvent"></see></summary>
    let hasEvent = _prefix "hasEvent"
    /// <summary>
    /// A link to a resource that further specifies the reason for the respective ResourceChangeEvent. For example one could attach a textual description or link to another event here. This property is under-specified in this version on purpose.
    /// <see href="http://purl.org/dsnotify/vocab/eventset/hasReason"></see></summary>
    let hasReason = _prefix "hasReason"
    /// <summary>
    /// A void:Dataset that is considered as 'source' dataset of the associated eventset. When the eventset is 'complete' and all events in this  eventset are applied in their timely order to this and all other source datasets, it will become equal to the corresponding target dataset(s).
    /// Example: a static snapshot of a dataset at time t0, e.g., the DBpedia snapshot 3.2
    /// <see href="http://purl.org/dsnotify/vocab/eventset/sourceDataset"></see></summary>
    let sourceDataset = _prefix "sourceDataset"
    /// <summary>
    /// The identifier (URI) of a resource that was published under a new URI (i.e., when a MoveEvent occurred).
    /// <see href="http://purl.org/dsnotify/vocab/eventset/sourceResource"></see></summary>
    let sourceResource = _prefix "sourceResource"
    /// <summary>
    /// A void:Dataset that is considered as 'target' dataset of the associated eventset. When the eventset is 'complete' and all events are applied in their timely order to the corresponding source dataset(s), this dataset (and all other target datasets) should be the result.
    /// Example: a static snapshot of a dataset at time t0+delta, e.g., the DBpedia snapshot 3.3
    /// <see href="http://purl.org/dsnotify/vocab/eventset/targetDataset"></see></summary>
    let targetDataset = _prefix "targetDataset"
    /// <summary>
    /// The identifier (URI) of a resource that was affected by the corresponding event.
    /// <see href="http://purl.org/dsnotify/vocab/eventset/targetResource"></see></summary>
    let targetResource = _prefix "targetResource"
