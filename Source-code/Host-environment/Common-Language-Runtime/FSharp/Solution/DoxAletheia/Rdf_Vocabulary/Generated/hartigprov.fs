namespace http.purl.org.net.provenance.ns.hash

open DoxAletheia

module hartigprov =
    let _namespace_name = "http://purl.org/net/provenance/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This class is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:Actor was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use one of the more specific classes prv:HumanAgent and prv:NonHumanAgent instead; or, if such a specialization is unsuitable for the use case at hand, directly use the general class prov:Agent as defined by PROV-O.
    /// <see href="http://purl.org/net/provenance/ns#Actor"></see></summary>
    let Actor = _prefix "Actor"
    /// <summary>
    /// This class is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:Artifact was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prov:Entity (or the more specific prv:Immutable) instead.
    /// <see href="http://purl.org/net/provenance/ns#Artifact"></see></summary>
    let Artifact = _prefix "Artifact"
    /// <summary>
    /// CreationGuideline is a concept that represents a guideline used to guide the execution of a data creation. Examples for creation guidelines are transformation rules, mapping definitions, entailment rules, and database queries.
    /// <see href="http://purl.org/net/provenance/ns#CreationGuideline"></see></summary>
    let CreationGuideline = _prefix "CreationGuideline"
    /// <summary>
    /// DataItem is a general concept that represents data items of any kind.
    /// <see href="http://purl.org/net/provenance/ns#DataItem"></see></summary>
    let DataItem = _prefix "DataItem"
    /// <summary>
    /// DataAccess is a concept that represents the completed execution of an activity by which an immutable data item has been retrieved from the Web.
    /// <see href="http://purl.org/net/provenance/ns#DataAccess"></see></summary>
    let DataAccess = _prefix "DataAccess"
    /// <summary>
    /// This property refers to the Web resource that has been accessed during the execution of a data access. More precisely, the request of the referenced Web resource resulted in retrieving the representation that has been retrieved by the corresponding prv:DataAccess execution.
    /// <see href="http://purl.org/net/provenance/ns#accessedResource"></see></summary>
    let accessedResource = _prefix "accessedResource"
    /// <summary>
    /// This property refers to the service that provided the Web representation during the execution of a data access.
    /// <see href="http://purl.org/net/provenance/ns#accessedService"></see></summary>
    let accessedService = _prefix "accessedService"
    /// <summary>
    /// DataCreation is a concept that represents the execution of an activity by which data items have been created.
    /// <see href="http://purl.org/net/provenance/ns#DataCreation"></see></summary>
    let DataCreation = _prefix "DataCreation"
    /// <summary>
    /// File is a general class that represents computer files/documents of any kind.
    /// <see href="http://purl.org/net/provenance/ns#File"></see></summary>
    let File = _prefix "File"
    /// <summary>
    /// DataProvidingService is a concept that represents a non-human agent - usually a Web service or a server - that processes data access requests and actually sends the requested Web representations over the Web.
    /// <see href="http://purl.org/net/provenance/ns#DataProvidingService"></see></summary>
    let DataProvidingService = _prefix "DataProvidingService"
    /// <summary>
    /// NonHumanAgent is a general class that represents agents who are not social beings.
    /// <see href="http://purl.org/net/provenance/ns#NonHumanAgent"></see></summary>
    let NonHumanAgent = _prefix "NonHumanAgent"
    /// <summary>
    /// DataPublisher is a concept that represents entities such as persons, groups, or organizations who use a data providing service (see concept prv:DataProvidingService) to publish data on the Web.
    /// <see href="http://purl.org/net/provenance/ns#DataPublisher"></see></summary>
    let DataPublisher = _prefix "DataPublisher"
    /// <summary>
    /// HumanAgent is a general class that represents agents who are social beings such as persons, organizations, companies.
    /// <see href="http://purl.org/net/provenance/ns#HumanAgent"></see></summary>
    let HumanAgent = _prefix "HumanAgent"
    /// <summary>
    /// This class is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:Execution was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prov:Activity instead.
    /// <see href="http://purl.org/net/provenance/ns#Execution"></see></summary>
    let Execution = _prefix "Execution"
    /// <summary>
    /// This class is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:HumanActor was renamed to prv:HumanAgent in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prv:HumanAgent instead.
    /// <see href="http://purl.org/net/provenance/ns#HumanActor"></see></summary>
    let HumanActor = _prefix "HumanActor"
    /// <summary>
    /// Immutable is a concept that represents entities which are immutable.
    /// <see href="http://purl.org/net/provenance/ns#Immutable"></see></summary>
    let Immutable = _prefix "Immutable"
    /// <summary>
    /// This class is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:NonHumanActor was renamed to prv:NonHumanAgent in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prv:NonHumanAgent instead.
    /// <see href="http://purl.org/net/provenance/ns#NonHumanActor"></see></summary>
    let NonHumanActor = _prefix "NonHumanActor"
    /// <summary>
    /// This property refers to the time an activity has been completed.
    /// <see href="http://purl.org/net/provenance/ns#completedAt"></see></summary>
    let completedAt = _prefix "completedAt"
    /// <summary>
    /// This property refers to a data item that contained a data item. Hence, this property refers to another data item of a larger granularity (e.g. an RDF triple is usually contained in an RDF graph).
    /// <see href="http://purl.org/net/provenance/ns#containedBy"></see></summary>
    let containedBy = _prefix "containedBy"
    /// <summary>
    /// This property refers to the creation of a data item (or a file that serializes data items).
    /// <see href="http://purl.org/net/provenance/ns#createdBy"></see></summary>
    let createdBy = _prefix "createdBy"
    /// <summary>
    /// This property refers to a file that serialized a data item.
    /// <see href="http://purl.org/net/provenance/ns#serializedBy"></see></summary>
    let serializedBy = _prefix "serializedBy"
    /// <summary>
    /// This property refers to the software that was run by a non-human actor (usually a service).
    /// <see href="http://purl.org/net/provenance/ns#deployedSoftware"></see></summary>
    let deployedSoftware = _prefix "deployedSoftware"
    /// <summary>
    /// This property is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:employedArtifact was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prov:used instead.
    /// <see href="http://purl.org/net/provenance/ns#employedArtifact"></see></summary>
    let employedArtifact = _prefix "employedArtifact"
    /// <summary>
    /// This property is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:involvedActor was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prov:wasAssociatedWith instead.
    /// <see href="http://purl.org/net/provenance/ns#involvedActor"></see></summary>
    let involvedActor = _prefix "involvedActor"
    /// <summary>
    /// This property refers to a human agent who was operating a non-human agent. For instance, a service provider operates a data providing service (see concept prv:DataProvidingService). Another example is a human agent who operates a non-human data creating agent.
    /// <see href="http://purl.org/net/provenance/ns#operatedBy"></see></summary>
    let operatedBy = _prefix "operatedBy"
    /// <summary>
    /// This property has been renamed to prv:completedAt. Hence, prv:performedAt is deprecated and will be removed from the Provenance Vocabulary in the next revision.
    /// <see href="http://purl.org/net/provenance/ns#performedAt"></see></summary>
    let performedAt = _prefix "performedAt"
    /// <summary>
    /// This property refers to an agent that/who performed an activity.
    /// <see href="http://purl.org/net/provenance/ns#performedBy"></see></summary>
    let performedBy = _prefix "performedBy"
    /// <summary>
    /// This property may be used to make the relationship between different version of a data item explicit. More precisely, this property refers to an immediately preceding version of a data item; hence, the new version (i.e. the subject) has been created using the old version (i.e. the object). We strongly encourage to also describe this creation of the new version explicitly.
    /// <see href="http://purl.org/net/provenance/ns#precededBy"></see></summary>
    let precededBy = _prefix "precededBy"
    /// <summary>
    /// This property refers to the data access by which an immutable entity has been retrieved from the Web. Each entity that has this property is a Web representation.
    /// <see href="http://purl.org/net/provenance/ns#retrievedBy"></see></summary>
    let retrievedBy = _prefix "retrievedBy"
    /// <summary>
    /// This property refers to a data publisher who used a data providing services at the time the provenance description refers to.
    /// <see href="http://purl.org/net/provenance/ns#usedBy"></see></summary>
    let usedBy = _prefix "usedBy"
    /// <summary>
    /// This property refers to a source data item that has been used during the creation of a data item. Examples for source data are the content of a document used for machine learning, the statements in a knowledge base used to entail a new statement, and the entries in a database used to answer a query. Notice, all source data has provenance; we strongly encourage to describe this provenance as well, at least as far as available information permits.
    /// <see href="http://purl.org/net/provenance/ns#usedData"></see></summary>
    let usedData = _prefix "usedData"
    /// <summary>
    /// This property refers to a creation guideline which guided the execution of a data creation. Examples for creation guidelines are transformation rules, mapping definitions, entailment rules, and database queries. Notice, all creation guidelines have provenance; we strongly encourage to describe this provenance as well, at least as far as available information permits.
    /// <see href="http://purl.org/net/provenance/ns#usedGuideline"></see></summary>
    let usedGuideline = _prefix "usedGuideline"
    /// <summary>
    /// This property is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:yieldedBy was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prov:wasGeneratedBy instead.
    /// <see href="http://purl.org/net/provenance/ns#yieldedBy"></see></summary>
    let yieldedBy = _prefix "yieldedBy"
