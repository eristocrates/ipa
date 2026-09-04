#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dsn =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/dsnotify/vocab/eventset/" "dsn"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : create event</para>
    ///   <para>rdfs:comment : An event class describing that a particular resource was 'created' in a dataset. This means that one or more triples having the associated resource as subject or object were created in the corresponding RDF model.</para>
    ///   <a href="http://purl.org/dsnotify/vocab/eventset/CreateEvent">dsn:CreateEvent</a>
    /// </summary>
    let CreateEvent = _prefixId.prefix "CreateEvent"
    /// <summary>
    ///   <para>rdfs:label : Eventset</para>
    ///   <para>rdfs:comment : An eventset is a container of events that occur in a dataset.</para>
    ///   <a href="http://purl.org/dsnotify/vocab/eventset/Eventset">dsn:Eventset</a>
    /// </summary>
    let Eventset = _prefixId.prefix "Eventset"
    /// <summary>
    ///   <para>rdfs:label : Move event</para>
    ///   <para>rdfs:comment : An event class describing that a particular resource was 'moved' in a dataset or between datasets. This means that all triples having the associated older resource as subject/object were replaced by triples having the target resource as subject/object in the corresponding RDF models. </para>
    ///   <a href="http://purl.org/dsnotify/vocab/eventset/MoveEvent">dsn:MoveEvent</a>
    /// </summary>
    let MoveEvent = _prefixId.prefix "MoveEvent"
    /// <summary>
    ///   <para>rdfs:label : Remove event</para>
    ///   <para>rdfs:comment : An event class describing that a particular resource was 'removed' from a dataset. This means that all triples having the associated resource as subject or object were removed from the corresponding RDF model.</para>
    ///   <a href="http://purl.org/dsnotify/vocab/eventset/RemoveEvent">dsn:RemoveEvent</a>
    /// </summary>
    let RemoveEvent = _prefixId.prefix "RemoveEvent"
    /// <summary>
    ///   <para>rdfs:label : Resource change event</para>
    ///   <para>rdfs:comment : An event that changes the representations of a resource in an RDF dataset. ResourceChangeEvents are lode:Events and the lode:atTime or the lode:circa properties should be used to describe the time when the event took place.</para>
    ///   <a href="http://purl.org/dsnotify/vocab/eventset/ResourceChangeEvent">dsn:ResourceChangeEvent</a>
    /// </summary>
    let ResourceChangeEvent = _prefixId.prefix "ResourceChangeEvent"
    /// <summary>
    ///   <para>rdfs:label : Unknown event</para>
    ///   <para>rdfs:comment : An event class describing that a not further specified event occurred to a resource in a dataset. </para>
    ///   <a href="http://purl.org/dsnotify/vocab/eventset/UnknownEvent">dsn:UnknownEvent</a>
    /// </summary>
    let UnknownEvent = _prefixId.prefix "UnknownEvent"
    /// <summary>
    ///   <para>rdfs:label : Update event</para>
    ///   <para>rdfs:comment : An event class describing that a particular resource was 'updated' in a dataset. This means that some triples having the associated resource as subject or object were modified/created/removed in the corresponding RDF model.</para>
    ///   <a href="http://purl.org/dsnotify/vocab/eventset/UpdateEvent">dsn:UpdateEvent</a>
    /// </summary>
    let UpdateEvent = _prefixId.prefix "UpdateEvent"
    /// <summary>
    ///   <para>rdfs:label : has affected triples</para>
    ///   <para>rdfs:comment : A link to a resource that further specifies the actual triples that were added/removed in consequence of the respective ResourceChangeEvent. For example one could attach a Talis changeset here. This property is under-specified in this version on purpose.</para>
    ///   <a href="http://purl.org/dsnotify/vocab/eventset/hasAffectedTriples">dsn:hasAffectedTriples</a>
    /// </summary>
    let hasAffectedTriples = _prefixId.prefix "hasAffectedTriples"
    /// <summary>
    ///   <para>rdfs:label : has confidence</para>
    ///   <para>rdfs:comment : Optional property for capturing the confidence (a float value between 0 and 1) the event detecting actor has that the corresponding event really took place. If omited, applications should assume a confidence of 1.0.</para>
    ///   <a href="http://purl.org/dsnotify/vocab/eventset/hasConfidence">dsn:hasConfidence</a>
    /// </summary>
    let hasConfidence = _prefixId.prefix "hasConfidence"
    /// <summary>
    ///   <para>rdfs:label : has event</para>
    ///   <para>rdfs:comment : An event that is part of an eventset.</para>
    ///   <a href="http://purl.org/dsnotify/vocab/eventset/hasEvent">dsn:hasEvent</a>
    /// </summary>
    let hasEvent = _prefixId.prefix "hasEvent"
    /// <summary>
    ///   <para>rdfs:label : has reason</para>
    ///   <para>rdfs:comment : A link to a resource that further specifies the reason for the respective ResourceChangeEvent. For example one could attach a textual description or link to another event here. This property is under-specified in this version on purpose.</para>
    ///   <a href="http://purl.org/dsnotify/vocab/eventset/hasReason">dsn:hasReason</a>
    /// </summary>
    let hasReason = _prefixId.prefix "hasReason"
    /// <summary>
    ///   <para>rdfs:label : source dataset</para>
    ///   <para>rdfs:comment : A void:Dataset that is considered as 'source' dataset of the associated eventset. When the eventset is 'complete' and all events in this  eventset are applied in their timely order to this and all other source datasets, it will become equal to the corresponding target dataset(s).
    /// Example: a static snapshot of a dataset at time t0, e.g., the DBpedia snapshot 3.2</para>
    ///   <a href="http://purl.org/dsnotify/vocab/eventset/sourceDataset">dsn:sourceDataset</a>
    /// </summary>
    let sourceDataset = _prefixId.prefix "sourceDataset"
    /// <summary>
    ///   <para>rdfs:label : source resource</para>
    ///   <para>rdfs:comment : The identifier (URI) of a resource that was published under a new URI (i.e., when a MoveEvent occurred).</para>
    ///   <a href="http://purl.org/dsnotify/vocab/eventset/sourceResource">dsn:sourceResource</a>
    /// </summary>
    let sourceResource = _prefixId.prefix "sourceResource"
    /// <summary>
    ///   <para>rdfs:label : target dataset</para>
    ///   <para>rdfs:comment : A void:Dataset that is considered as 'target' dataset of the associated eventset. When the eventset is 'complete' and all events are applied in their timely order to the corresponding source dataset(s), this dataset (and all other target datasets) should be the result.
    /// Example: a static snapshot of a dataset at time t0+delta, e.g., the DBpedia snapshot 3.3</para>
    ///   <a href="http://purl.org/dsnotify/vocab/eventset/targetDataset">dsn:targetDataset</a>
    /// </summary>
    let targetDataset = _prefixId.prefix "targetDataset"
    /// <summary>
    ///   <para>rdfs:label : target resource</para>
    ///   <para>rdfs:comment : The identifier (URI) of a resource that was affected by the corresponding event.</para>
    ///   <a href="http://purl.org/dsnotify/vocab/eventset/targetResource">dsn:targetResource</a>
    /// </summary>
    let targetResource = _prefixId.prefix "targetResource"
