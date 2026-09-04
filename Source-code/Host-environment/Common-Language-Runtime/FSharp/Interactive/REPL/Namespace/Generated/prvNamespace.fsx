#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module prv =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/net/provenance/ns#" "prv"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Actor</para>
    ///   <para>rdfs:comment : This class is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:Actor was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use one of the more specific classes prv:HumanAgent and prv:NonHumanAgent instead; or, if such a specialization is unsuitable for the use case at hand, directly use the general class prov:Agent as defined by PROV-O.</para>
    ///   <a href="http://purl.org/net/provenance/ns#Actor">prv:Actor</a>
    /// </summary>
    let Actor = _prefixId.prefix "Actor"
    /// <summary>
    ///   <para>rdfs:label : Artifact</para>
    ///   <para>rdfs:comment : This class is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:Artifact was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prov:Entity (or the more specific prv:Immutable) instead.</para>
    ///   <a href="http://purl.org/net/provenance/ns#Artifact">prv:Artifact</a>
    /// </summary>
    let Artifact = _prefixId.prefix "Artifact"
    /// <summary>
    ///   <para>rdfs:label : Creation Guideline</para>
    ///   <para>rdfs:comment : CreationGuideline is a concept that represents a guideline used to guide the execution of a data creation. Examples for creation guidelines are transformation rules, mapping definitions, entailment rules, and database queries.</para>
    ///   <a href="http://purl.org/net/provenance/ns#CreationGuideline">prv:CreationGuideline</a>
    /// </summary>
    let CreationGuideline = _prefixId.prefix "CreationGuideline"
    /// <summary>
    ///   <para>rdfs:label : Data Access</para>
    ///   <para>rdfs:comment : DataAccess is a concept that represents the completed execution of an activity by which an immutable data item has been retrieved from the Web.</para>
    ///   <a href="http://purl.org/net/provenance/ns#DataAccess">prv:DataAccess</a>
    /// </summary>
    let DataAccess = _prefixId.prefix "DataAccess"
    /// <summary>
    ///   <para>rdfs:label : Data Creation</para>
    ///   <para>rdfs:comment : DataCreation is a concept that represents the execution of an activity by which data items have been created.</para>
    ///   <a href="http://purl.org/net/provenance/ns#DataCreation">prv:DataCreation</a>
    /// </summary>
    let DataCreation = _prefixId.prefix "DataCreation"
    /// <summary>
    ///   <para>rdfs:label : Data Item</para>
    ///   <para>rdfs:comment : DataItem is a general concept that represents data items of any kind.</para>
    ///   <a href="http://purl.org/net/provenance/ns#DataItem">prv:DataItem</a>
    /// </summary>
    let DataItem = _prefixId.prefix "DataItem"
    /// <summary>
    ///   <para>rdfs:label : Data Providing Service</para>
    ///   <para>rdfs:comment : DataProvidingService is a concept that represents a non-human agent - usually a Web service or a server - that processes data access requests and actually sends the requested Web representations over the Web.</para>
    ///   <a href="http://purl.org/net/provenance/ns#DataProvidingService">prv:DataProvidingService</a>
    /// </summary>
    let DataProvidingService = _prefixId.prefix "DataProvidingService"
    /// <summary>
    ///   <para>rdfs:label : Data Publisher</para>
    ///   <para>rdfs:comment : DataPublisher is a concept that represents entities such as persons, groups, or organizations who use a data providing service (see concept prv:DataProvidingService) to publish data on the Web.</para>
    ///   <a href="http://purl.org/net/provenance/ns#DataPublisher">prv:DataPublisher</a>
    /// </summary>
    let DataPublisher = _prefixId.prefix "DataPublisher"
    /// <summary>
    ///   <para>rdfs:label : Execution</para>
    ///   <para>rdfs:comment : This class is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:Execution was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prov:Activity instead.</para>
    ///   <a href="http://purl.org/net/provenance/ns#Execution">prv:Execution</a>
    /// </summary>
    let Execution = _prefixId.prefix "Execution"
    /// <summary>
    ///   <para>rdfs:label : File</para>
    ///   <para>rdfs:comment : File is a general class that represents computer files/documents of any kind.</para>
    ///   <a href="http://purl.org/net/provenance/ns#File">prv:File</a>
    /// </summary>
    let File = _prefixId.prefix "File"
    /// <summary>
    ///   <para>rdfs:label : Human Actor</para>
    ///   <para>rdfs:comment : This class is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:HumanActor was renamed to prv:HumanAgent in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prv:HumanAgent instead.</para>
    ///   <a href="http://purl.org/net/provenance/ns#HumanActor">prv:HumanActor</a>
    /// </summary>
    let HumanActor = _prefixId.prefix "HumanActor"
    /// <summary>
    ///   <para>rdfs:label : Human Agent</para>
    ///   <para>rdfs:comment : HumanAgent is a general class that represents agents who are social beings such as persons, organizations, companies.</para>
    ///   <a href="http://purl.org/net/provenance/ns#HumanAgent">prv:HumanAgent</a>
    /// </summary>
    let HumanAgent = _prefixId.prefix "HumanAgent"
    /// <summary>
    ///   <para>rdfs:label : Data Item</para>
    ///   <para>rdfs:comment : Immutable is a concept that represents entities which are immutable.</para>
    ///   <a href="http://purl.org/net/provenance/ns#Immutable">prv:Immutable</a>
    /// </summary>
    let Immutable = _prefixId.prefix "Immutable"
    /// <summary>
    ///   <para>rdfs:label : Non-Human Actor</para>
    ///   <para>rdfs:comment : This class is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:NonHumanActor was renamed to prv:NonHumanAgent in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prv:NonHumanAgent instead.</para>
    ///   <a href="http://purl.org/net/provenance/ns#NonHumanActor">prv:NonHumanActor</a>
    /// </summary>
    let NonHumanActor = _prefixId.prefix "NonHumanActor"
    /// <summary>
    ///   <para>rdfs:label : Non-Human Agent</para>
    ///   <para>rdfs:comment : NonHumanAgent is a general class that represents agents who are not social beings.</para>
    ///   <a href="http://purl.org/net/provenance/ns#NonHumanAgent">prv:NonHumanAgent</a>
    /// </summary>
    let NonHumanAgent = _prefixId.prefix "NonHumanAgent"
    /// <summary>
    ///   <para>rdfs:label : accessed</para>
    ///   <para>rdfs:comment : This property refers to the Web resource that has been accessed during the execution of a data access. More precisely, the request of the referenced Web resource resulted in retrieving the representation that has been retrieved by the corresponding prv:DataAccess execution.</para>
    ///   <a href="http://purl.org/net/provenance/ns#accessedResource">prv:accessedResource</a>
    /// </summary>
    let accessedResource = _prefixId.prefix "accessedResource"
    /// <summary>
    ///   <para>rdfs:label : accessed</para>
    ///   <para>rdfs:comment : This property refers to the service that provided the Web representation during the execution of a data access.</para>
    ///   <a href="http://purl.org/net/provenance/ns#accessedService">prv:accessedService</a>
    /// </summary>
    let accessedService = _prefixId.prefix "accessedService"
    /// <summary>
    ///   <para>rdfs:label : completed at</para>
    ///   <para>rdfs:comment : This property refers to the time an activity has been completed.</para>
    ///   <a href="http://purl.org/net/provenance/ns#completedAt">prv:completedAt</a>
    /// </summary>
    let completedAt = _prefixId.prefix "completedAt"
    /// <summary>
    ///   <para>rdfs:label : contained in</para>
    ///   <para>rdfs:comment : This property refers to a data item that contained a data item. Hence, this property refers to another data item of a larger granularity (e.g. an RDF triple is usually contained in an RDF graph).</para>
    ///   <a href="http://purl.org/net/provenance/ns#containedBy">prv:containedBy</a>
    /// </summary>
    let containedBy = _prefixId.prefix "containedBy"
    /// <summary>
    ///   <para>rdfs:label : created by</para>
    ///   <para>rdfs:comment : This property refers to the creation of a data item (or a file that serializes data items).</para>
    ///   <a href="http://purl.org/net/provenance/ns#createdBy">prv:createdBy</a>
    /// </summary>
    let createdBy = _prefixId.prefix "createdBy"
    /// <summary>
    ///   <para>rdfs:label : runs</para>
    ///   <para>rdfs:comment : This property refers to the software that was run by a non-human actor (usually a service).</para>
    ///   <a href="http://purl.org/net/provenance/ns#deployedSoftware">prv:deployedSoftware</a>
    /// </summary>
    let deployedSoftware = _prefixId.prefix "deployedSoftware"
    /// <summary>
    ///   <para>rdfs:label : used</para>
    ///   <para>rdfs:comment : This property is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:employedArtifact was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prov:used instead.</para>
    ///   <a href="http://purl.org/net/provenance/ns#employedArtifact">prv:employedArtifact</a>
    /// </summary>
    let employedArtifact = _prefixId.prefix "employedArtifact"
    /// <summary>
    ///   <para>rdfs:label : involved</para>
    ///   <para>rdfs:comment : This property is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:involvedActor was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prov:wasAssociatedWith instead.</para>
    ///   <a href="http://purl.org/net/provenance/ns#involvedActor">prv:involvedActor</a>
    /// </summary>
    let involvedActor = _prefixId.prefix "involvedActor"
    /// <summary>
    ///   <para>rdfs:label : operated by</para>
    ///   <para>rdfs:comment : This property refers to a human agent who was operating a non-human agent. For instance, a service provider operates a data providing service (see concept prv:DataProvidingService). Another example is a human agent who operates a non-human data creating agent.</para>
    ///   <a href="http://purl.org/net/provenance/ns#operatedBy">prv:operatedBy</a>
    /// </summary>
    let operatedBy = _prefixId.prefix "operatedBy"
    /// <summary>
    ///   <para>rdfs:label : executed at</para>
    ///   <para>rdfs:comment : This property has been renamed to prv:completedAt. Hence, prv:performedAt is deprecated and will be removed from the Provenance Vocabulary in the next revision.</para>
    ///   <a href="http://purl.org/net/provenance/ns#performedAt">prv:performedAt</a>
    /// </summary>
    let performedAt = _prefixId.prefix "performedAt"
    /// <summary>
    ///   <para>rdfs:label : performed by</para>
    ///   <para>rdfs:comment : This property refers to an agent that/who performed an activity.</para>
    ///   <a href="http://purl.org/net/provenance/ns#performedBy">prv:performedBy</a>
    /// </summary>
    let performedBy = _prefixId.prefix "performedBy"
    /// <summary>
    ///   <para>rdfs:label : immediately preceded by</para>
    ///   <para>rdfs:comment : This property may be used to make the relationship between different version of a data item explicit. More precisely, this property refers to an immediately preceding version of a data item; hence, the new version (i.e. the subject) has been created using the old version (i.e. the object). We strongly encourage to also describe this creation of the new version explicitly.</para>
    ///   <a href="http://purl.org/net/provenance/ns#precededBy">prv:precededBy</a>
    /// </summary>
    let precededBy = _prefixId.prefix "precededBy"
    /// <summary>
    ///   <para>rdfs:comment : This property refers to the data access by which an immutable entity has been retrieved from the Web. Each entity that has this property is a Web representation.</para>
    ///   <para>rdfs:label : retrieved by</para>
    ///   <a href="http://purl.org/net/provenance/ns#retrievedBy">prv:retrievedBy</a>
    /// </summary>
    let retrievedBy = _prefixId.prefix "retrievedBy"
    /// <summary>
    ///   <para>rdfs:label : serialized by</para>
    ///   <para>rdfs:comment : This property refers to a file that serialized a data item.</para>
    ///   <a href="http://purl.org/net/provenance/ns#serializedBy">prv:serializedBy</a>
    /// </summary>
    let serializedBy = _prefixId.prefix "serializedBy"
    /// <summary>
    ///   <para>rdfs:label : used by</para>
    ///   <para>rdfs:comment : This property refers to a data publisher who used a data providing services at the time the provenance description refers to.</para>
    ///   <a href="http://purl.org/net/provenance/ns#usedBy">prv:usedBy</a>
    /// </summary>
    let usedBy = _prefixId.prefix "usedBy"
    /// <summary>
    ///   <para>rdfs:label : used</para>
    ///   <para>rdfs:comment : This property refers to a source data item that has been used during the creation of a data item. Examples for source data are the content of a document used for machine learning, the statements in a knowledge base used to entail a new statement, and the entries in a database used to answer a query. Notice, all source data has provenance; we strongly encourage to describe this provenance as well, at least as far as available information permits.</para>
    ///   <a href="http://purl.org/net/provenance/ns#usedData">prv:usedData</a>
    /// </summary>
    let usedData = _prefixId.prefix "usedData"
    /// <summary>
    ///   <para>rdfs:label : guided by</para>
    ///   <para>rdfs:comment : This property refers to a creation guideline which guided the execution of a data creation. Examples for creation guidelines are transformation rules, mapping definitions, entailment rules, and database queries. Notice, all creation guidelines have provenance; we strongly encourage to describe this provenance as well, at least as far as available information permits.</para>
    ///   <a href="http://purl.org/net/provenance/ns#usedGuideline">prv:usedGuideline</a>
    /// </summary>
    let usedGuideline = _prefixId.prefix "usedGuideline"
    /// <summary>
    ///   <para>rdfs:label : yielded by</para>
    ///   <para>rdfs:comment : This property is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:yieldedBy was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prov:wasGeneratedBy instead.</para>
    ///   <a href="http://purl.org/net/provenance/ns#yieldedBy">prv:yieldedBy</a>
    /// </summary>
    let yieldedBy = _prefixId.prefix "yieldedBy"
