namespace http.purl.org.net.provenance.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module hartigprov =
    let _namespace_iri = Namespace_Iri hartigprov |> NamespaceIRI
    /// <summary>
    ///   <para>hartigprov:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#">http://purl.org/net/provenance/ns#</seealso>
    let _prefix_iri = Prefixed_Name(hartigprov, "") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:Actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>"This class is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:Actor was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use one of the more specific classes prv:HumanAgent and prv:NonHumanAgent instead; or, if such a specialization is unsuitable for the use case at hand, directly use the general class prov:Agent as defined by PROV-O."</para>
    /// labels<para>"Actor"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#Actor">http://purl.org/net/provenance/ns#Actor</seealso>
    let Actor = Prefixed_Name(hartigprov, "Actor") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:Artifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>owl:Class</para>
    ///   <para>"This class is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:Artifact was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prov:Entity (or the more specific prv:Immutable) instead."</para>
    /// labels<para>"Artifact"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#Artifact">http://purl.org/net/provenance/ns#Artifact</seealso>
    let Artifact = Prefixed_Name(hartigprov, "Artifact") |> PrefixedName

    /// <summary>
    ///   <para>hartigprov:CreationGuideline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"CreationGuideline is a concept that represents a guideline used to guide the execution of a data creation. Examples for creation guidelines are transformation rules, mapping definitions, entailment rules, and database queries."</para>
    /// labels<para>"Creation Guideline"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#CreationGuideline">http://purl.org/net/provenance/ns#CreationGuideline</seealso>
    let CreationGuideline =
        Prefixed_Name(hartigprov, "CreationGuideline") |> PrefixedName

    /// <summary>
    ///   <para>hartigprov:DataAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DataAccess is a concept that represents the completed execution of an activity by which an immutable data item has been retrieved from the Web."</para>
    /// labels<para>"Data Access"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#DataAccess">http://purl.org/net/provenance/ns#DataAccess</seealso>
    let DataAccess = Prefixed_Name(hartigprov, "DataAccess") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:DataCreation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DataCreation is a concept that represents the execution of an activity by which data items have been created."</para>
    /// labels<para>"Data Creation"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#DataCreation">http://purl.org/net/provenance/ns#DataCreation</seealso>
    let DataCreation = Prefixed_Name(hartigprov, "DataCreation") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:DataItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DataItem is a general concept that represents data items of any kind."</para>
    /// labels<para>"Data Item"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#DataItem">http://purl.org/net/provenance/ns#DataItem</seealso>
    let DataItem = Prefixed_Name(hartigprov, "DataItem") |> PrefixedName

    /// <summary>
    ///   <para>hartigprov:DataProvidingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DataProvidingService is a concept that represents a non-human agent - usually a Web service or a server - that processes data access requests and actually sends the requested Web representations over the Web."</para>
    /// labels<para>"Data Providing Service"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#DataProvidingService">http://purl.org/net/provenance/ns#DataProvidingService</seealso>
    let DataProvidingService =
        Prefixed_Name(hartigprov, "DataProvidingService") |> PrefixedName

    /// <summary>
    ///   <para>hartigprov:DataPublisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DataPublisher is a concept that represents entities such as persons, groups, or organizations who use a data providing service (see concept prv:DataProvidingService) to publish data on the Web."</para>
    /// labels<para>"Data Publisher"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#DataPublisher">http://purl.org/net/provenance/ns#DataPublisher</seealso>
    let DataPublisher = Prefixed_Name(hartigprov, "DataPublisher") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:Execution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>"This class is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:Execution was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prov:Activity instead."</para>
    /// labels<para>"Execution"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#Execution">http://purl.org/net/provenance/ns#Execution</seealso>
    let Execution = Prefixed_Name(hartigprov, "Execution") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:File</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"File is a general class that represents computer files/documents of any kind."</para>
    /// labels<para>"File"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#File">http://purl.org/net/provenance/ns#File</seealso>
    let File = Prefixed_Name(hartigprov, "File") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:HumanActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>owl:Class</para>
    ///   <para>"This class is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:HumanActor was renamed to prv:HumanAgent in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prv:HumanAgent instead."</para>
    /// labels<para>"Human Actor"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#HumanActor">http://purl.org/net/provenance/ns#HumanActor</seealso>
    let HumanActor = Prefixed_Name(hartigprov, "HumanActor") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:HumanAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"HumanAgent is a general class that represents agents who are social beings such as persons, organizations, companies."</para>
    /// labels<para>"Human Agent"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#HumanAgent">http://purl.org/net/provenance/ns#HumanAgent</seealso>
    let HumanAgent = Prefixed_Name(hartigprov, "HumanAgent") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:Immutable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Immutable is a concept that represents entities which are immutable."</para>
    /// labels<para>"Data Item"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#Immutable">http://purl.org/net/provenance/ns#Immutable</seealso>
    let Immutable = Prefixed_Name(hartigprov, "Immutable") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:NonHumanActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>owl:Class</para>
    ///   <para>"This class is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:NonHumanActor was renamed to prv:NonHumanAgent in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prv:NonHumanAgent instead."</para>
    /// labels<para>"Non-Human Actor"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#NonHumanActor">http://purl.org/net/provenance/ns#NonHumanActor</seealso>
    let NonHumanActor = Prefixed_Name(hartigprov, "NonHumanActor") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:NonHumanAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"NonHumanAgent is a general class that represents agents who are not social beings."</para>
    /// labels<para>"Non-Human Agent"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#NonHumanAgent">http://purl.org/net/provenance/ns#NonHumanAgent</seealso>
    let NonHumanAgent = Prefixed_Name(hartigprov, "NonHumanAgent") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:accessedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property refers to the Web resource that has been accessed during the execution of a data access. More precisely, the request of the referenced Web resource resulted in retrieving the representation that has been retrieved by the corresponding prv:DataAccess execution."</para>
    /// labels<para>"accessed"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#accessedResource">http://purl.org/net/provenance/ns#accessedResource</seealso>
    let accessedResource = Prefixed_Name(hartigprov, "accessedResource") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:accessedService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property refers to the service that provided the Web representation during the execution of a data access."</para>
    /// labels<para>"accessed"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#accessedService">http://purl.org/net/provenance/ns#accessedService</seealso>
    let accessedService = Prefixed_Name(hartigprov, "accessedService") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:completedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property refers to the time an activity has been completed."</para>
    /// labels<para>"completed at"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#completedAt">http://purl.org/net/provenance/ns#completedAt</seealso>
    let completedAt = Prefixed_Name(hartigprov, "completedAt") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:containedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property refers to a data item that contained a data item. Hence, this property refers to another data item of a larger granularity (e.g. an RDF triple is usually contained in an RDF graph)."</para>
    /// labels<para>"contained in"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#containedBy">http://purl.org/net/provenance/ns#containedBy</seealso>
    let containedBy = Prefixed_Name(hartigprov, "containedBy") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:createdBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property refers to the creation of a data item (or a file that serializes data items)."</para>
    /// labels<para>"created by"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#createdBy">http://purl.org/net/provenance/ns#createdBy</seealso>
    let createdBy = Prefixed_Name(hartigprov, "createdBy") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:deployedSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property refers to the software that was run by a non-human actor (usually a service)."</para>
    /// labels<para>"runs"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#deployedSoftware">http://purl.org/net/provenance/ns#deployedSoftware</seealso>
    let deployedSoftware = Prefixed_Name(hartigprov, "deployedSoftware") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:employedArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:employedArtifact was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prov:used instead."</para>
    /// labels<para>"used"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#employedArtifact">http://purl.org/net/provenance/ns#employedArtifact</seealso>
    let employedArtifact = Prefixed_Name(hartigprov, "employedArtifact") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:involvedActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>"This property is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:involvedActor was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prov:wasAssociatedWith instead."</para>
    /// labels<para>"involved"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#involvedActor">http://purl.org/net/provenance/ns#involvedActor</seealso>
    let involvedActor = Prefixed_Name(hartigprov, "involvedActor") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:operatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property refers to a human agent who was operating a non-human agent. For instance, a service provider operates a data providing service (see concept prv:DataProvidingService). Another example is a human agent who operates a non-human data creating agent."</para>
    /// labels<para>"operated by"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#operatedBy">http://purl.org/net/provenance/ns#operatedBy</seealso>
    let operatedBy = Prefixed_Name(hartigprov, "operatedBy") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:performedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property has been renamed to prv:completedAt. Hence, prv:performedAt is deprecated and will be removed from the Provenance Vocabulary in the next revision."</para>
    /// labels<para>"executed at"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#performedAt">http://purl.org/net/provenance/ns#performedAt</seealso>
    let performedAt = Prefixed_Name(hartigprov, "performedAt") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:performedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property refers to an agent that/who performed an activity."</para>
    /// labels<para>"performed by"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#performedBy">http://purl.org/net/provenance/ns#performedBy</seealso>
    let performedBy = Prefixed_Name(hartigprov, "performedBy") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:precededBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property may be used to make the relationship between different version of a data item explicit. More precisely, this property refers to an immediately preceding version of a data item; hence, the new version (i.e. the subject) has been created using the old version (i.e. the object). We strongly encourage to also describe this creation of the new version explicitly."</para>
    /// labels<para>"immediately preceded by"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#precededBy">http://purl.org/net/provenance/ns#precededBy</seealso>
    let precededBy = Prefixed_Name(hartigprov, "precededBy") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:retrievedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property refers to the data access by which an immutable entity has been retrieved from the Web. Each entity that has this property is a Web representation."</para>
    /// labels<para>"retrieved by"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#retrievedBy">http://purl.org/net/provenance/ns#retrievedBy</seealso>
    let retrievedBy = Prefixed_Name(hartigprov, "retrievedBy") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:serializedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property refers to a file that serialized a data item."</para>
    /// labels<para>"serialized by"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#serializedBy">http://purl.org/net/provenance/ns#serializedBy</seealso>
    let serializedBy = Prefixed_Name(hartigprov, "serializedBy") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:usedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property refers to a data publisher who used a data providing services at the time the provenance description refers to."</para>
    /// labels<para>"used by"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#usedBy">http://purl.org/net/provenance/ns#usedBy</seealso>
    let usedBy = Prefixed_Name(hartigprov, "usedBy") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:usedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property refers to a source data item that has been used during the creation of a data item. Examples for source data are the content of a document used for machine learning, the statements in a knowledge base used to entail a new statement, and the entries in a database used to answer a query. Notice, all source data has provenance; we strongly encourage to describe this provenance as well, at least as far as available information permits."</para>
    /// labels<para>"used"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#usedData">http://purl.org/net/provenance/ns#usedData</seealso>
    let usedData = Prefixed_Name(hartigprov, "usedData") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:usedGuideline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property refers to a creation guideline which guided the execution of a data creation. Examples for creation guidelines are transformation rules, mapping definitions, entailment rules, and database queries. Notice, all creation guidelines have provenance; we strongly encourage to describe this provenance as well, at least as far as available information permits."</para>
    /// labels<para>"guided by"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#usedGuideline">http://purl.org/net/provenance/ns#usedGuideline</seealso>
    let usedGuideline = Prefixed_Name(hartigprov, "usedGuideline") |> PrefixedName
    /// <summary>
    ///   <para>hartigprov:yieldedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>"This property is deprecated and will be removed from the Provenance Vocabulary in the next revision. prv:yieldedBy was deprecated in the process of making the Provenance Vocabulary a specialization of W3C's PROV-O. Hence, use prov:wasGeneratedBy instead."</para>
    /// labels<para>"yielded by"</para></remarks>
    /// <seealso href="http://purl.org/net/provenance/ns#yieldedBy">http://purl.org/net/provenance/ns#yieldedBy</seealso>
    let yieldedBy = Prefixed_Name(hartigprov, "yieldedBy") |> PrefixedName
