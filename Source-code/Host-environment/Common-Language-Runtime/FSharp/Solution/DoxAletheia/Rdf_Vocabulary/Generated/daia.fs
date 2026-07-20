namespace http.purl.org.ontology.daia.slash

open DoxAletheia

module daia =
    let _namespace_name = "http://purl.org/ontology/daia/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A Limitation is something that limits the the availability of an Item.
    /// <see href="http://purl.org/ontology/daia/Limitation"></see></summary>
    let Limitation = _prefix "Limitation"
    /// <summary>
    /// A Respone contains information about document availability for a specific time and institution.
    /// <see href="http://purl.org/ontology/daia/Response"></see></summary>
    let Response = _prefix "Response"
    /// <summary>
    /// A Service is something that is provided by an Institution, typically related to an Item, for instance the service of loaning the Item.
    /// <see href="http://purl.org/ontology/daia/Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// Use mediated by another institution.
    /// <see href="http://purl.org/ontology/daia/Service/Interloan"></see></summary>
    let ``Service/Interloan`` = _prefix "Service/Interloan"
    /// <summary>
    /// Use outside of the holding institution (by lending or online access)
    /// <see href="http://purl.org/ontology/daia/Service/Loan"></see></summary>
    let ``Service/Loan`` = _prefix "Service/Loan"
    /// <summary>
    /// can be accessed freely on the Web
    /// <see href="http://purl.org/ontology/daia/Service/Openaccess"></see></summary>
    let ``Service/Openaccess`` = _prefix "Service/Openaccess"
    /// <summary>
    /// Use within the holding institution (in their rooms, in their intranet etc.)
    /// <see href="http://purl.org/ontology/daia/Service/Presentation"></see></summary>
    let ``Service/Presentation`` = _prefix "Service/Presentation"
    /// <summary>
    /// A place where instances of frbr:Item are stored.
    /// <see href="http://purl.org/ontology/daia/Storage"></see></summary>
    let Storage = _prefix "Storage"
    /// <summary>
    /// Relates an Item to a Service which the Item is available for. This property is disjoint with the unavailable property; however an Item can be available and unavailable for two different Services of the same class at the same time.
    /// <see href="http://purl.org/ontology/daia/availableFor"></see></summary>
    let availableFor = _prefix "availableFor"
    /// <summary>
    /// Relates an Item to a Service which the Item is not available for. This property is disjoint with the available property; however an Item can be available and unavailable for two different Services of the same class at the same time.
    /// <see href="http://purl.org/ontology/daia/unavailableFor"></see></summary>
    let unavailableFor = _prefix "unavailableFor"
    /// <summary>
    /// Relates an available Service to the Item which this Service refers to
    /// <see href="http://purl.org/ontology/daia/availableOf"></see></summary>
    let availableOf = _prefix "availableOf"
    /// <summary>
    /// Relates a Document to an Item that contains an exemplar of the Document as part.
    /// Relates an Item to a Document which is partly exemplified by the Item.
    /// <see href="http://purl.org/ontology/daia/broaderExemplar"></see></summary>
    let broaderExemplar = _prefix "broaderExemplar"
    /// <summary>
    ///   <see href="http://purl.org/ontology/daia/broaderExemplarOf"></see>
    /// </summary>
    let broaderExemplarOf = _prefix "broaderExemplarOf"
    /// <summary>
    /// Relates a Document to an Item that is an exemplar of the Document. This property is similar to frbr:exemplar but does not refer to the class frbr:Manifestation.
    /// <see href="http://purl.org/ontology/daia/exemplar"></see></summary>
    let exemplar = _prefix "exemplar"
    /// <summary>
    /// Relates an Item to the Document that is exemplified by the Item.
    /// <see href="http://purl.org/ontology/daia/exemplarOf"></see></summary>
    let exemplarOf = _prefix "exemplarOf"
    /// <summary>
    /// Relates a Document to an Institution which helds an iten of the Document.
    /// <see href="http://purl.org/ontology/daia/collectedBy"></see></summary>
    let collectedBy = _prefix "collectedBy"
    /// <summary>
    /// Relates an Institution to a Document which the Institution helds an item of.
    /// <see href="http://purl.org/ontology/daia/inCollection"></see></summary>
    let inCollection = _prefix "inCollection"
    /// <summary>
    /// A time period of estimated delay untill an available Service can be used. Applications should normalize all literal values not conforming to xsd:duration to 'unknown'
    /// <see href="http://purl.org/ontology/daia/delay"></see></summary>
    let delay = _prefix "delay"
    /// <summary>
    /// Relates an Item to a Document which is partly exemplified by the Item.
    /// Relates a Document to an Item that is an exemplar of a part of the Document.
    /// <see href="http://purl.org/ontology/daia/narrowerExemplar"></see></summary>
    let narrowerExemplar = _prefix "narrowerExemplar"
    /// <summary>
    ///   <see href="http://purl.org/ontology/daia/narrowerExemplarOf"></see>
    /// </summary>
    let narrowerExemplarOf = _prefix "narrowerExemplarOf"
    /// <summary>
    /// If this property is given on an unavailable Service, it is assumed that the Service will be available at the specified time. Applications should normalize all literal values not conforming to xsd:date or xsd:dateTime to 'unknown'
    /// <see href="http://purl.org/ontology/daia/expected"></see></summary>
    let expected = _prefix "expected"
    /// <summary>
    /// Relates an Item to an Institution that holds the Item.
    /// <see href="http://purl.org/ontology/daia/heldBy"></see></summary>
    let heldBy = _prefix "heldBy"
    /// <summary>
    /// Relates an Institution to an Item which the Institution holds.
    /// <see href="http://purl.org/ontology/daia/holds"></see></summary>
    let holds = _prefix "holds"
    /// <summary>
    /// A call number, shelf mark or similar label of an item
    /// <see href="http://purl.org/ontology/daia/label"></see></summary>
    let label = _prefix "label"
    /// <summary>
    /// Relates an Service to a Limitation.
    /// <see href="http://purl.org/ontology/daia/limitedBy"></see></summary>
    let limitedBy = _prefix "limitedBy"
    /// <summary>
    /// Relates a Limitation to a Service.
    /// <see href="http://purl.org/ontology/daia/limits"></see></summary>
    let limits = _prefix "limits"
    /// <summary>
    /// A link to perform, register or reserve a Service.
    /// <see href="http://purl.org/ontology/daia/perform"></see></summary>
    let perform = _prefix "perform"
    /// <summary>
    /// Relates a Service to an Institution that provides the Service.
    /// <see href="http://purl.org/ontology/daia/providedBy"></see></summary>
    let providedBy = _prefix "providedBy"
    /// <summary>
    /// Relates an Institution to a Service that is provided by the Institution.
    /// <see href="http://purl.org/ontology/daia/provides"></see></summary>
    let provides = _prefix "provides"
    /// <summary>
    /// The number number of waiting requests for this service. If this property is not given, the value zero may be assumed but applications may also distinguish zero and no value.
    /// <see href="http://purl.org/ontology/daia/queue"></see></summary>
    let queue = _prefix "queue"
    /// <summary>
    /// Date and time of a the validity of a Response
    /// <see href="http://purl.org/ontology/daia/timestamp"></see></summary>
    let timestamp = _prefix "timestamp"
    /// <summary>
    /// Relates a unavailable Service to the Item which this Service refers to
    /// <see href="http://purl.org/ontology/daia/unavailableOf"></see></summary>
    let unavailableOf = _prefix "unavailableOf"
