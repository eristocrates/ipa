namespace http.purl.org.net.provenance.ns.hash

open DoxAletheia.Rdf_Vocabulary

module hartigprov =
    let _namespace_name = "http://purl.org/net/provenance/ns#"
    /// <summary>
    /// This class is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:Actor was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use one of the more specific classes prv:HumanAgent and prv:NonHumanAgent instead; or, if such a specialization is unsuitable for the use case at hand, directly use the general class prov:Agent as defined by PROV-O.
    /// <see href="http://purl.org/net/provenance/ns#Actor"></see></summary>
    let Actor = Namespaced_IRI.parse _namespace_name "Actor" |> NamespacedName
    /// <summary>
    /// This class is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:Artifact was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prov:Entity (or the more specific prv:Immutable) instead.
    /// <see href="http://purl.org/net/provenance/ns#Artifact"></see></summary>
    let Artifact = Namespaced_IRI.parse _namespace_name "Artifact" |> NamespacedName

    /// <summary>
    /// CreationGuideline is a concept that represents a guideline used to guide the execution of a data creation. Examples for creation guidelines are transformation rules, mapping definitions, entailment rules, and database queries.
    /// <see href="http://purl.org/net/provenance/ns#CreationGuideline"></see></summary>
    let CreationGuideline =
        Namespaced_IRI.parse _namespace_name "CreationGuideline" |> NamespacedName

    /// <summary>
    /// DataItem is a general concept that represents data items of any kind.
    /// <see href="http://purl.org/net/provenance/ns#DataItem"></see></summary>
    let DataItem = Namespaced_IRI.parse _namespace_name "DataItem" |> NamespacedName
    /// <summary>
    /// DataAccess is a concept that represents the completed execution of an activity by which an immutable data item has been retrieved from the Web.
    /// <see href="http://purl.org/net/provenance/ns#DataAccess"></see></summary>
    let DataAccess = Namespaced_IRI.parse _namespace_name "DataAccess" |> NamespacedName

    /// <summary>
    /// This property refers to the Web resource that has been accessed during the execution of a data access. More precisely, the request of the referenced Web resource resulted in retrieving the representation that has been retrieved by the corresponding prv:DataAccess execution.
    /// <see href="http://purl.org/net/provenance/ns#accessedResource"></see></summary>
    let accessedResource =
        Namespaced_IRI.parse _namespace_name "accessedResource" |> NamespacedName

    /// <summary>
    /// This property refers to the service that provided the Web representation during the execution of a data access.
    /// <see href="http://purl.org/net/provenance/ns#accessedService"></see></summary>
    let accessedService =
        Namespaced_IRI.parse _namespace_name "accessedService" |> NamespacedName

    /// <summary>
    /// DataCreation is a concept that represents the execution of an activity by which data items have been created.
    /// <see href="http://purl.org/net/provenance/ns#DataCreation"></see></summary>
    let DataCreation =
        Namespaced_IRI.parse _namespace_name "DataCreation" |> NamespacedName

    /// <summary>
    /// File is a general class that represents computer files/documents of any kind.
    /// <see href="http://purl.org/net/provenance/ns#File"></see></summary>
    let File = Namespaced_IRI.parse _namespace_name "File" |> NamespacedName

    /// <summary>
    /// DataProvidingService is a concept that represents a non-human agent - usually a Web service or a server - that processes data access requests and actually sends the requested Web representations over the Web.
    /// <see href="http://purl.org/net/provenance/ns#DataProvidingService"></see></summary>
    let DataProvidingService =
        Namespaced_IRI.parse _namespace_name "DataProvidingService" |> NamespacedName

    /// <summary>
    /// NonHumanAgent is a general class that represents agents who are not social beings.
    /// <see href="http://purl.org/net/provenance/ns#NonHumanAgent"></see></summary>
    let NonHumanAgent =
        Namespaced_IRI.parse _namespace_name "NonHumanAgent" |> NamespacedName

    /// <summary>
    /// DataPublisher is a concept that represents entities such as persons, groups, or organizations who use a data providing service (see concept prv:DataProvidingService) to publish data on the Web.
    /// <see href="http://purl.org/net/provenance/ns#DataPublisher"></see></summary>
    let DataPublisher =
        Namespaced_IRI.parse _namespace_name "DataPublisher" |> NamespacedName

    /// <summary>
    /// HumanAgent is a general class that represents agents who are social beings such as persons, organizations, companies.
    /// <see href="http://purl.org/net/provenance/ns#HumanAgent"></see></summary>
    let HumanAgent = Namespaced_IRI.parse _namespace_name "HumanAgent" |> NamespacedName
    /// <summary>
    /// This class is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:Execution was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prov:Activity instead.
    /// <see href="http://purl.org/net/provenance/ns#Execution"></see></summary>
    let Execution = Namespaced_IRI.parse _namespace_name "Execution" |> NamespacedName
    /// <summary>
    /// This class is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:HumanActor was renamed to prv:HumanAgent in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prv:HumanAgent instead.
    /// <see href="http://purl.org/net/provenance/ns#HumanActor"></see></summary>
    let HumanActor = Namespaced_IRI.parse _namespace_name "HumanActor" |> NamespacedName
    /// <summary>
    /// Immutable is a concept that represents entities which are immutable.
    /// <see href="http://purl.org/net/provenance/ns#Immutable"></see></summary>
    let Immutable = Namespaced_IRI.parse _namespace_name "Immutable" |> NamespacedName

    /// <summary>
    /// This class is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:NonHumanActor was renamed to prv:NonHumanAgent in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prv:NonHumanAgent instead.
    /// <see href="http://purl.org/net/provenance/ns#NonHumanActor"></see></summary>
    let NonHumanActor =
        Namespaced_IRI.parse _namespace_name "NonHumanActor" |> NamespacedName

    /// <summary>
    /// This property refers to the time an activity has been completed.
    /// <see href="http://purl.org/net/provenance/ns#completedAt"></see></summary>
    let completedAt =
        Namespaced_IRI.parse _namespace_name "completedAt" |> NamespacedName

    /// <summary>
    /// This property refers to a data item that contained a data item. Hence, this property refers to another data item of a larger granularity (e.g. an RDF triple is usually contained in an RDF graph).
    /// <see href="http://purl.org/net/provenance/ns#containedBy"></see></summary>
    let containedBy =
        Namespaced_IRI.parse _namespace_name "containedBy" |> NamespacedName

    /// <summary>
    /// This property refers to the creation of a data item (or a file that serializes data items).
    /// <see href="http://purl.org/net/provenance/ns#createdBy"></see></summary>
    let createdBy = Namespaced_IRI.parse _namespace_name "createdBy" |> NamespacedName

    /// <summary>
    /// This property refers to a file that serialized a data item.
    /// <see href="http://purl.org/net/provenance/ns#serializedBy"></see></summary>
    let serializedBy =
        Namespaced_IRI.parse _namespace_name "serializedBy" |> NamespacedName

    /// <summary>
    /// This property refers to the software that was run by a non-human actor (usually a service).
    /// <see href="http://purl.org/net/provenance/ns#deployedSoftware"></see></summary>
    let deployedSoftware =
        Namespaced_IRI.parse _namespace_name "deployedSoftware" |> NamespacedName

    /// <summary>
    /// This property is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:employedArtifact was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prov:used instead.
    /// <see href="http://purl.org/net/provenance/ns#employedArtifact"></see></summary>
    let employedArtifact =
        Namespaced_IRI.parse _namespace_name "employedArtifact" |> NamespacedName

    /// <summary>
    /// This property is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:involvedActor was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prov:wasAssociatedWith instead.
    /// <see href="http://purl.org/net/provenance/ns#involvedActor"></see></summary>
    let involvedActor =
        Namespaced_IRI.parse _namespace_name "involvedActor" |> NamespacedName

    /// <summary>
    /// This property refers to a human agent who was operating a non-human agent. For instance, a service provider operates a data providing service (see concept prv:DataProvidingService). Another example is a human agent who operates a non-human data creating agent.
    /// <see href="http://purl.org/net/provenance/ns#operatedBy"></see></summary>
    let operatedBy = Namespaced_IRI.parse _namespace_name "operatedBy" |> NamespacedName

    /// <summary>
    /// This property has been renamed to prv:completedAt. Hence, prv:performedAt is deprecated and will be removed from the Provenance Vocabulary in the next revision.
    /// <see href="http://purl.org/net/provenance/ns#performedAt"></see></summary>
    let performedAt =
        Namespaced_IRI.parse _namespace_name "performedAt" |> NamespacedName

    /// <summary>
    /// This property refers to an agent that/who performed an activity.
    /// <see href="http://purl.org/net/provenance/ns#performedBy"></see></summary>
    let performedBy =
        Namespaced_IRI.parse _namespace_name "performedBy" |> NamespacedName

    /// <summary>
    /// This property may be used to make the relationship between different version of a data item explicit. More precisely, this property refers to an immediately preceding version of a data item; hence, the new version (i.e. the subject) has been created using the old version (i.e. the object). We strongly encourage to also describe this creation of the new version explicitly.
    /// <see href="http://purl.org/net/provenance/ns#precededBy"></see></summary>
    let precededBy = Namespaced_IRI.parse _namespace_name "precededBy" |> NamespacedName

    /// <summary>
    /// This property refers to the data access by which an immutable entity has been retrieved from the Web. Each entity that has this property is a Web representation.
    /// <see href="http://purl.org/net/provenance/ns#retrievedBy"></see></summary>
    let retrievedBy =
        Namespaced_IRI.parse _namespace_name "retrievedBy" |> NamespacedName

    /// <summary>
    /// This property refers to a data publisher who used a data providing services at the time the provenance description refers to.
    /// <see href="http://purl.org/net/provenance/ns#usedBy"></see></summary>
    let usedBy = Namespaced_IRI.parse _namespace_name "usedBy" |> NamespacedName
    /// <summary>
    /// This property refers to a source data item that has been used during the creation of a data item. Examples for source data are the content of a document used for machine learning, the statements in a knowledge base used to entail a new statement, and the entries in a database used to answer a query. Notice, all source data has provenance; we strongly encourage to describe this provenance as well, at least as far as available information permits.
    /// <see href="http://purl.org/net/provenance/ns#usedData"></see></summary>
    let usedData = Namespaced_IRI.parse _namespace_name "usedData" |> NamespacedName

    /// <summary>
    /// This property refers to a creation guideline which guided the execution of a data creation. Examples for creation guidelines are transformation rules, mapping definitions, entailment rules, and database queries. Notice, all creation guidelines have provenance; we strongly encourage to describe this provenance as well, at least as far as available information permits.
    /// <see href="http://purl.org/net/provenance/ns#usedGuideline"></see></summary>
    let usedGuideline =
        Namespaced_IRI.parse _namespace_name "usedGuideline" |> NamespacedName

    /// <summary>
    /// This property is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:yieldedBy was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prov:wasGeneratedBy instead.
    /// <see href="http://purl.org/net/provenance/ns#yieldedBy"></see></summary>
    let yieldedBy = Namespaced_IRI.parse _namespace_name "yieldedBy" |> NamespacedName
