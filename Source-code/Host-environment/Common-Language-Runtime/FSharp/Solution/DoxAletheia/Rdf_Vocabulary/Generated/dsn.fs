namespace http.purl.org.dsnotify.vocab.eventset.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dsn =
    let _namespace_iri = Namespace_Iri dsn |> NamespaceIRI
    /// <summary>
    ///   <para>dsn:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>DSNotify Eventsets is a vocabulary for events that change resources in linked data sources.</para>
    /// labels<para>DSNotify Eventsets: A vocabulary for change events in linked data sources</para></remarks>
    /// <seealso href="http://purl.org/dsnotify/vocab/eventset/">http://purl.org/dsnotify/vocab/eventset/</seealso>
    let _prefix_iri = Prefixed_Name(dsn, "") |> PrefixedName
    /// <summary>
    ///   <para>dsn:CreateEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An event class describing that a particular resource was 'created' in a dataset. This means that one or more triples having the associated resource as subject or object were created in the corresponding RDF model.</para>
    /// labels<para>create event</para></remarks>
    /// <seealso href="http://purl.org/dsnotify/vocab/eventset/CreateEvent">http://purl.org/dsnotify/vocab/eventset/CreateEvent</seealso>
    let CreateEvent = Prefixed_Name(dsn, "CreateEvent") |> PrefixedName
    /// <summary>
    ///   <para>dsn:ResourceChangeEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An event that changes the representations of a resource in an RDF dataset. ResourceChangeEvents are lode:Events and the lode:atTime or the lode:circa properties should be used to describe the time when the event took place.</para>
    /// labels<para>Resource change event</para></remarks>
    /// <seealso href="http://purl.org/dsnotify/vocab/eventset/ResourceChangeEvent">http://purl.org/dsnotify/vocab/eventset/ResourceChangeEvent</seealso>
    let ResourceChangeEvent = Prefixed_Name(dsn, "ResourceChangeEvent") |> PrefixedName
    /// <summary>
    ///   <para>dsn:Eventset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An eventset is a container of events that occur in a dataset.</para>
    /// labels<para>Eventset</para></remarks>
    /// <seealso href="http://purl.org/dsnotify/vocab/eventset/Eventset">http://purl.org/dsnotify/vocab/eventset/Eventset</seealso>
    let Eventset = Prefixed_Name(dsn, "Eventset") |> PrefixedName
    /// <summary>
    ///   <para>dsn:MoveEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An event class describing that a particular resource was 'moved' in a dataset or between datasets. This means that all triples having the associated older resource as subject/object were replaced by triples having the target resource as subject/object in the corresponding RDF models. </para>
    /// labels<para>Move event</para></remarks>
    /// <seealso href="http://purl.org/dsnotify/vocab/eventset/MoveEvent">http://purl.org/dsnotify/vocab/eventset/MoveEvent</seealso>
    let MoveEvent = Prefixed_Name(dsn, "MoveEvent") |> PrefixedName
    /// <summary>
    ///   <para>dsn:RemoveEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An event class describing that a particular resource was 'removed' from a dataset. This means that all triples having the associated resource as subject or object were removed from the corresponding RDF model.</para>
    /// labels<para>Remove event</para></remarks>
    /// <seealso href="http://purl.org/dsnotify/vocab/eventset/RemoveEvent">http://purl.org/dsnotify/vocab/eventset/RemoveEvent</seealso>
    let RemoveEvent = Prefixed_Name(dsn, "RemoveEvent") |> PrefixedName
    /// <summary>
    ///   <para>dsn:UnknownEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An event class describing that a not further specified event occurred to a resource in a dataset. </para>
    /// labels<para>Unknown event</para></remarks>
    /// <seealso href="http://purl.org/dsnotify/vocab/eventset/UnknownEvent">http://purl.org/dsnotify/vocab/eventset/UnknownEvent</seealso>
    let UnknownEvent = Prefixed_Name(dsn, "UnknownEvent") |> PrefixedName
    /// <summary>
    ///   <para>dsn:UpdateEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An event class describing that a particular resource was 'updated' in a dataset. This means that some triples having the associated resource as subject or object were modified/created/removed in the corresponding RDF model.</para>
    /// labels<para>Update event</para></remarks>
    /// <seealso href="http://purl.org/dsnotify/vocab/eventset/UpdateEvent">http://purl.org/dsnotify/vocab/eventset/UpdateEvent</seealso>
    let UpdateEvent = Prefixed_Name(dsn, "UpdateEvent") |> PrefixedName
    /// <summary>
    ///   <para>dsn:hasAffectedTriples</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A link to a resource that further specifies the actual triples that were added/removed in consequence of the respective ResourceChangeEvent. For example one could attach a Talis changeset here. This property is under-specified in this version on purpose.</para>
    /// labels<para>has affected triples</para></remarks>
    /// <seealso href="http://purl.org/dsnotify/vocab/eventset/hasAffectedTriples">http://purl.org/dsnotify/vocab/eventset/hasAffectedTriples</seealso>
    let hasAffectedTriples = Prefixed_Name(dsn, "hasAffectedTriples") |> PrefixedName
    /// <summary>
    ///   <para>dsn:hasConfidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Optional property for capturing the confidence (a float value between 0 and 1) the event detecting actor has that the corresponding event really took place. If omited, applications should assume a confidence of 1.0.</para>
    /// labels<para>has confidence</para></remarks>
    /// <seealso href="http://purl.org/dsnotify/vocab/eventset/hasConfidence">http://purl.org/dsnotify/vocab/eventset/hasConfidence</seealso>
    let hasConfidence = Prefixed_Name(dsn, "hasConfidence") |> PrefixedName
    /// <summary>
    ///   <para>dsn:hasEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An event that is part of an eventset.</para>
    /// labels<para>has event</para></remarks>
    /// <seealso href="http://purl.org/dsnotify/vocab/eventset/hasEvent">http://purl.org/dsnotify/vocab/eventset/hasEvent</seealso>
    let hasEvent = Prefixed_Name(dsn, "hasEvent") |> PrefixedName
    /// <summary>
    ///   <para>dsn:hasReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A link to a resource that further specifies the reason for the respective ResourceChangeEvent. For example one could attach a textual description or link to another event here. This property is under-specified in this version on purpose.</para>
    /// labels<para>has reason</para></remarks>
    /// <seealso href="http://purl.org/dsnotify/vocab/eventset/hasReason">http://purl.org/dsnotify/vocab/eventset/hasReason</seealso>
    let hasReason = Prefixed_Name(dsn, "hasReason") |> PrefixedName
    /// <summary>
    ///   <para>dsn:sourceDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A void:Dataset that is considered as 'source' dataset of the associated eventset. When the eventset is 'complete' and all events in this  eventset are applied in their timely order to this and all other source datasets, it will become equal to the corresponding target dataset(s).
    /// Example: a static snapshot of a dataset at time t0, e.g., the DBpedia snapshot 3.2</para>
    /// labels<para>source dataset</para></remarks>
    /// <seealso href="http://purl.org/dsnotify/vocab/eventset/sourceDataset">http://purl.org/dsnotify/vocab/eventset/sourceDataset</seealso>
    let sourceDataset = Prefixed_Name(dsn, "sourceDataset") |> PrefixedName
    /// <summary>
    ///   <para>dsn:sourceResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The identifier (URI) of a resource that was published under a new URI (i.e., when a MoveEvent occurred).</para>
    /// labels<para>source resource</para></remarks>
    /// <seealso href="http://purl.org/dsnotify/vocab/eventset/sourceResource">http://purl.org/dsnotify/vocab/eventset/sourceResource</seealso>
    let sourceResource = Prefixed_Name(dsn, "sourceResource") |> PrefixedName
    /// <summary>
    ///   <para>dsn:targetDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A void:Dataset that is considered as 'target' dataset of the associated eventset. When the eventset is 'complete' and all events are applied in their timely order to the corresponding source dataset(s), this dataset (and all other target datasets) should be the result.
    /// Example: a static snapshot of a dataset at time t0+delta, e.g., the DBpedia snapshot 3.3</para>
    /// labels<para>target dataset</para></remarks>
    /// <seealso href="http://purl.org/dsnotify/vocab/eventset/targetDataset">http://purl.org/dsnotify/vocab/eventset/targetDataset</seealso>
    let targetDataset = Prefixed_Name(dsn, "targetDataset") |> PrefixedName
    /// <summary>
    ///   <para>dsn:targetResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The identifier (URI) of a resource that was affected by the corresponding event.</para>
    /// labels<para>target resource</para></remarks>
    /// <seealso href="http://purl.org/dsnotify/vocab/eventset/targetResource">http://purl.org/dsnotify/vocab/eventset/targetResource</seealso>
    let targetResource = Prefixed_Name(dsn, "targetResource") |> PrefixedName
