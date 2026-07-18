namespace http.purl.org.ontology.daia.slash

open DoxAletheia.Rdf_Vocabulary

module daia =
    let _namespace_name = "http://purl.org/ontology/daia/"
    /// <summary>
    /// A Limitation is something that limits the the availability of an Item.
    /// <see href="http://purl.org/ontology/daia/Limitation"></see></summary>
    let Limitation = Namespaced_IRI.parse _namespace_name "Limitation" |> NamespacedName
    /// <summary>
    /// A Respone contains information about document availability for a specific time and institution.
    /// <see href="http://purl.org/ontology/daia/Response"></see></summary>
    let Response = Namespaced_IRI.parse _namespace_name "Response" |> NamespacedName
    /// <summary>
    /// A Service is something that is provided by an Institution, typically related to an Item, for instance the service of loaning the Item.
    /// <see href="http://purl.org/ontology/daia/Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    /// Use mediated by another institution.
    /// <see href="http://purl.org/ontology/daia/Service/Interloan"></see></summary>
    let ``Service/Interloan`` =
        Namespaced_IRI.parse _namespace_name "Service/Interloan" |> NamespacedName

    /// <summary>
    /// Use outside of the holding institution (by lending or online access)
    /// <see href="http://purl.org/ontology/daia/Service/Loan"></see></summary>
    let ``Service/Loan`` =
        Namespaced_IRI.parse _namespace_name "Service/Loan" |> NamespacedName

    /// <summary>
    /// can be accessed freely on the Web
    /// <see href="http://purl.org/ontology/daia/Service/Openaccess"></see></summary>
    let ``Service/Openaccess`` =
        Namespaced_IRI.parse _namespace_name "Service/Openaccess" |> NamespacedName

    /// <summary>
    /// Use within the holding institution (in their rooms, in their intranet etc.)
    /// <see href="http://purl.org/ontology/daia/Service/Presentation"></see></summary>
    let ``Service/Presentation`` =
        Namespaced_IRI.parse _namespace_name "Service/Presentation" |> NamespacedName

    /// <summary>
    /// A place where instances of frbr:Item are stored.
    /// <see href="http://purl.org/ontology/daia/Storage"></see></summary>
    let Storage = Namespaced_IRI.parse _namespace_name "Storage" |> NamespacedName

    /// <summary>
    /// Relates an Item to a Service which the Item is available for. This property is disjoint with the unavailable property; however an Item can be available and unavailable for two different Services of the same class at the same time.
    /// <see href="http://purl.org/ontology/daia/availableFor"></see></summary>
    let availableFor =
        Namespaced_IRI.parse _namespace_name "availableFor" |> NamespacedName

    /// <summary>
    /// Relates an Item to a Service which the Item is not available for. This property is disjoint with the available property; however an Item can be available and unavailable for two different Services of the same class at the same time.
    /// <see href="http://purl.org/ontology/daia/unavailableFor"></see></summary>
    let unavailableFor =
        Namespaced_IRI.parse _namespace_name "unavailableFor" |> NamespacedName

    /// <summary>
    /// Relates an available Service to the Item which this Service refers to
    /// <see href="http://purl.org/ontology/daia/availableOf"></see></summary>
    let availableOf =
        Namespaced_IRI.parse _namespace_name "availableOf" |> NamespacedName

    /// <summary>
    /// Relates a Document to an Item that contains an exemplar of the Document as part.
    /// Relates an Item to a Document which is partly exemplified by the Item.
    /// <see href="http://purl.org/ontology/daia/broaderExemplar"></see></summary>
    let broaderExemplar =
        Namespaced_IRI.parse _namespace_name "broaderExemplar" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/daia/broaderExemplarOf"></see>
    /// </summary>
    let broaderExemplarOf =
        Namespaced_IRI.parse _namespace_name "broaderExemplarOf" |> NamespacedName

    /// <summary>
    /// Relates a Document to an Item that is an exemplar of the Document. This property is similar to frbr:exemplar but does not refer to the class frbr:Manifestation.
    /// <see href="http://purl.org/ontology/daia/exemplar"></see></summary>
    let exemplar = Namespaced_IRI.parse _namespace_name "exemplar" |> NamespacedName
    /// <summary>
    /// Relates an Item to the Document that is exemplified by the Item.
    /// <see href="http://purl.org/ontology/daia/exemplarOf"></see></summary>
    let exemplarOf = Namespaced_IRI.parse _namespace_name "exemplarOf" |> NamespacedName

    /// <summary>
    /// Relates a Document to an Institution which helds an iten of the Document.
    /// <see href="http://purl.org/ontology/daia/collectedBy"></see></summary>
    let collectedBy =
        Namespaced_IRI.parse _namespace_name "collectedBy" |> NamespacedName

    /// <summary>
    /// Relates an Institution to a Document which the Institution helds an item of.
    /// <see href="http://purl.org/ontology/daia/inCollection"></see></summary>
    let inCollection =
        Namespaced_IRI.parse _namespace_name "inCollection" |> NamespacedName

    /// <summary>
    /// A time period of estimated delay untill an available Service can be used. Applications should normalize all literal values not conforming to xsd:duration to 'unknown'
    /// <see href="http://purl.org/ontology/daia/delay"></see></summary>
    let delay = Namespaced_IRI.parse _namespace_name "delay" |> NamespacedName

    /// <summary>
    /// Relates an Item to a Document which is partly exemplified by the Item.
    /// Relates a Document to an Item that is an exemplar of a part of the Document.
    /// <see href="http://purl.org/ontology/daia/narrowerExemplar"></see></summary>
    let narrowerExemplar =
        Namespaced_IRI.parse _namespace_name "narrowerExemplar" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/daia/narrowerExemplarOf"></see>
    /// </summary>
    let narrowerExemplarOf =
        Namespaced_IRI.parse _namespace_name "narrowerExemplarOf" |> NamespacedName

    /// <summary>
    /// If this property is given on an unavailable Service, it is assumed that the Service will be available at the specified time. Applications should normalize all literal values not conforming to xsd:date or xsd:dateTime to 'unknown'
    /// <see href="http://purl.org/ontology/daia/expected"></see></summary>
    let expected = Namespaced_IRI.parse _namespace_name "expected" |> NamespacedName
    /// <summary>
    /// Relates an Item to an Institution that holds the Item.
    /// <see href="http://purl.org/ontology/daia/heldBy"></see></summary>
    let heldBy = Namespaced_IRI.parse _namespace_name "heldBy" |> NamespacedName
    /// <summary>
    /// Relates an Institution to an Item which the Institution holds.
    /// <see href="http://purl.org/ontology/daia/holds"></see></summary>
    let holds = Namespaced_IRI.parse _namespace_name "holds" |> NamespacedName
    /// <summary>
    /// A call number, shelf mark or similar label of an item
    /// <see href="http://purl.org/ontology/daia/label"></see></summary>
    let label = Namespaced_IRI.parse _namespace_name "label" |> NamespacedName
    /// <summary>
    /// Relates an Service to a Limitation.
    /// <see href="http://purl.org/ontology/daia/limitedBy"></see></summary>
    let limitedBy = Namespaced_IRI.parse _namespace_name "limitedBy" |> NamespacedName
    /// <summary>
    /// Relates a Limitation to a Service.
    /// <see href="http://purl.org/ontology/daia/limits"></see></summary>
    let limits = Namespaced_IRI.parse _namespace_name "limits" |> NamespacedName
    /// <summary>
    /// A link to perform, register or reserve a Service.
    /// <see href="http://purl.org/ontology/daia/perform"></see></summary>
    let perform = Namespaced_IRI.parse _namespace_name "perform" |> NamespacedName
    /// <summary>
    /// Relates a Service to an Institution that provides the Service.
    /// <see href="http://purl.org/ontology/daia/providedBy"></see></summary>
    let providedBy = Namespaced_IRI.parse _namespace_name "providedBy" |> NamespacedName
    /// <summary>
    /// Relates an Institution to a Service that is provided by the Institution.
    /// <see href="http://purl.org/ontology/daia/provides"></see></summary>
    let provides = Namespaced_IRI.parse _namespace_name "provides" |> NamespacedName
    /// <summary>
    /// The number number of waiting requests for this service. If this property is not given, the value zero may be assumed but applications may also distinguish zero and no value.
    /// <see href="http://purl.org/ontology/daia/queue"></see></summary>
    let queue = Namespaced_IRI.parse _namespace_name "queue" |> NamespacedName
    /// <summary>
    /// Date and time of a the validity of a Response
    /// <see href="http://purl.org/ontology/daia/timestamp"></see></summary>
    let timestamp = Namespaced_IRI.parse _namespace_name "timestamp" |> NamespacedName

    /// <summary>
    /// Relates a unavailable Service to the Item which this Service refers to
    /// <see href="http://purl.org/ontology/daia/unavailableOf"></see></summary>
    let unavailableOf =
        Namespaced_IRI.parse _namespace_name "unavailableOf" |> NamespacedName
