namespace http.purl.org.dpn.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dpn =
    let _namespace_iri = Namespace_Iri dpn |> NamespaceIRI
    /// <summary>
    ///   <para>dpn:Catalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A catalog is a curated set of metadata about datasets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Catalog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#Catalog">http://purl.org/dpn#Catalog</seealso>
    let Catalog = Prefixed_Name(dpn, "Catalog") |> PrefixedName

    /// <summary>
    ///   <para>dpn:DataServiceInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An abstract class of data service interfaces"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Service Interface"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#DataServiceInterface">http://purl.org/dpn#DataServiceInterface</seealso>
    let DataServiceInterface =
        Prefixed_Name(dpn, "DataServiceInterface") |> PrefixedName

    /// <summary>
    ///   <para>dpn:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class to represent datasets, which are collections of data. Datasets are accessed via a means of a Distribution, e.g. via a service which can be defined as a type of distribution method or a direct download."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#Dataset">http://purl.org/dpn#Dataset</seealso>
    let Dataset = Prefixed_Name(dpn, "Dataset") |> PrefixedName

    /// <summary>
    ///   <para>dpn:FeatureTypeCatalogue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Feature Type Catalogue (FTC) gives an informative overview of the spatial object types (features) and data types. Generally an FTC implements a registry of feature types which allow features to be described."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Feature Type Catalogue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#FeatureTypeCatalogue">http://purl.org/dpn#FeatureTypeCatalogue</seealso>
    let FeatureTypeCatalogue =
        Prefixed_Name(dpn, "FeatureTypeCatalogue") |> PrefixedName

    /// <summary>
    ///   <para>dpn:Html</para>
    /// </summary>
    /// <remarks>
    ///   <para>wsl:Message</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dpn#Html">http://purl.org/dpn#Html</seealso>
    let Html = Prefixed_Name(dpn, "Html") |> PrefixedName
    /// <summary>
    ///   <para>dpn:IdentifierService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Persistent Identifier Service allows registry and deferencing identifier handles."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Persistent Identifier Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#IdentifierService">http://purl.org/dpn#IdentifierService</seealso>
    let IdentifierService = Prefixed_Name(dpn, "IdentifierService") |> PrefixedName

    /// <summary>
    ///   <para>dpn:InfoModelServiceInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An abstract interface for information model services"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Information Model Service Interface"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#InfoModelServiceInterface">http://purl.org/dpn#InfoModelServiceInterface</seealso>
    let InfoModelServiceInterface =
        Prefixed_Name(dpn, "InfoModelServiceInterface") |> PrefixedName

    /// <summary>
    ///   <para>dpn:JSON</para>
    /// </summary>
    /// <remarks>
    ///   <para>wsl:Message</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dpn#JSON">http://purl.org/dpn#JSON</seealso>
    let JSON = Prefixed_Name(dpn, "JSON") |> PrefixedName

    /// <summary>
    ///   <para>dpn:LinkedDataApiOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Description of a Linked Data API operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Linked Data API Operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#LinkedDataApiOperation">http://purl.org/dpn#LinkedDataApiOperation</seealso>
    let LinkedDataApiOperation =
        Prefixed_Name(dpn, "LinkedDataApiOperation") |> PrefixedName

    /// <summary>
    ///   <para>dpn:MessageContent_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>msm:MessageContent</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dpn#MessageContent_1">http://purl.org/dpn#MessageContent_1</seealso>
    let MessageContent_1 = Prefixed_Name(dpn, "MessageContent_1") |> PrefixedName

    /// <summary>
    ///   <para>dpn:MetadataServiceInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An abstract interface for metadata services"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Metadata Service Interface"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#MetadataServiceInterface">http://purl.org/dpn#MetadataServiceInterface</seealso>
    let MetadataServiceInterface =
        Prefixed_Name(dpn, "MetadataServiceInterface") |> PrefixedName

    /// <summary>
    ///   <para>dpn:Node</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A data provider node is a class of things that exposes concrete service implementations and/or describes a number of service interfaces that it supports. This allows discovery of services or service capabilities for a given data provider node."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data provider node"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#Node">http://purl.org/dpn#Node</seealso>
    let Node = Prefixed_Name(dpn, "Node") |> PrefixedName

    /// <summary>
    ///   <para>dpn:ProvenanceServiceInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An abstract interface for provenance services"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Provenance Service Interface"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#ProvenanceServiceInterface">http://purl.org/dpn#ProvenanceServiceInterface</seealso>
    let ProvenanceServiceInterface =
        Prefixed_Name(dpn, "ProvenanceServiceInterface") |> PrefixedName

    /// <summary>
    ///   <para>dpn:RDF</para>
    /// </summary>
    /// <remarks>
    ///   <para>wsl:Message</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dpn#RDF">http://purl.org/dpn#RDF</seealso>
    let RDF = Prefixed_Name(dpn, "RDF") |> PrefixedName
    /// <summary>
    ///   <para>dpn:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lightweight description for a Web Service through which data may be accessed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Web Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#Service">http://purl.org/dpn#Service</seealso>
    let Service = Prefixed_Name(dpn, "Service") |> PrefixedName
    /// <summary>
    ///   <para>dpn:ServiceInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An abstract class for defining service interface standards for which services may implement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Service Interface Standard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#ServiceInterface">http://purl.org/dpn#ServiceInterface</seealso>
    let ServiceInterface = Prefixed_Name(dpn, "ServiceInterface") |> PrefixedName

    /// <summary>
    ///   <para>dpn:VocabularyServiceInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An abstract interface or API for a vocabulary service, which typically hosts a set of well-governed controlled vocabularies."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Vocabulary Service Interface"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#VocabularyServiceInterface">http://purl.org/dpn#VocabularyServiceInterface</seealso>
    let VocabularyServiceInterface =
        Prefixed_Name(dpn, "VocabularyServiceInterface") |> PrefixedName

    /// <summary>
    ///   <para>dpn:XML</para>
    /// </summary>
    /// <remarks>
    ///   <para>wsl:Message</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dpn#XML">http://purl.org/dpn#XML</seealso>
    let XML = Prefixed_Name(dpn, "XML") |> PrefixedName
    /// <summary>
    ///   <para>dpn:contactPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Link a resource to a relevant contact provided using VCard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#contactPoint">http://purl.org/dpn#contactPoint</seealso>
    let contactPoint = Prefixed_Name(dpn, "contactPoint") |> PrefixedName
    /// <summary>
    ///   <para>dpn:endpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property to associate a resource with a resolvable endpoint URL. e.g. to a URL of a catalog or a GetCapabilities description."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"endpoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#endpoint">http://purl.org/dpn#endpoint</seealso>
    let endpoint = Prefixed_Name(dpn, "endpoint") |> PrefixedName
    /// <summary>
    ///   <para>dpn:exposesService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property allows a resource to specify the services that it exposes. e.g. a Data provider node may expose a data service. The complement of this could be dpn:node to specify a Service's data provider node"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"exposes service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#exposesService">http://purl.org/dpn#exposesService</seealso>
    let exposesService = Prefixed_Name(dpn, "exposesService") |> PrefixedName
    /// <summary>
    ///   <para>dpn:hasImplementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property captures the association between a service interface specification and resources that has its service implementations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has implementation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#hasImplementation">http://purl.org/dpn#hasImplementation</seealso>
    let hasImplementation = Prefixed_Name(dpn, "hasImplementation") |> PrefixedName
    /// <summary>
    ///   <para>dpn:hostedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property to express the entity which hosts a given resource. This is the inverse of dpn:hosts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hosted by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#hostedBy">http://purl.org/dpn#hostedBy</seealso>
    let hostedBy = Prefixed_Name(dpn, "hostedBy") |> PrefixedName
    /// <summary>
    ///   <para>dpn:hosts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property to express the resource which the entity hosts. This is the inverse of dpn:hostedBy."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hosts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#hosts">http://purl.org/dpn#hosts</seealso>
    let hosts = Prefixed_Name(dpn, "hosts") |> PrefixedName
    /// <summary>
    ///   <para>dpn:hostsDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property allows association of a service to datasets that it hosts."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hosts dataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#hostsDataset">http://purl.org/dpn#hostsDataset</seealso>
    let hostsDataset = Prefixed_Name(dpn, "hostsDataset") |> PrefixedName
    /// <summary>
    ///   <para>dpn:hostsNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An organisation can host a data provider node"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hosts node"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#hostsNode">http://purl.org/dpn#hostsNode</seealso>
    let hostsNode = Prefixed_Name(dpn, "hostsNode") |> PrefixedName
    /// <summary>
    ///   <para>dpn:implements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property captures the association between a service and its interface specification. This is the inverse to hasImplementation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"implements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#implements">http://purl.org/dpn#implements</seealso>
    let implements = Prefixed_Name(dpn, "implements") |> PrefixedName
    /// <summary>
    ///   <para>dpn:manager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property to describe who the manager of the resource is."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"manager"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#manager">http://purl.org/dpn#manager</seealso>
    let manager = Prefixed_Name(dpn, "manager") |> PrefixedName
    /// <summary>
    ///   <para>dpn:manages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property to describe what entities are managed by a resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"manages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#manages">http://purl.org/dpn#manages</seealso>
    let manages = Prefixed_Name(dpn, "manages") |> PrefixedName
    /// <summary>
    ///   <para>dpn:node</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"node"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#node">http://purl.org/dpn#node</seealso>
    let node = Prefixed_Name(dpn, "node") |> PrefixedName
    /// <summary>
    ///   <para>dpn:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property to express the owner of a resource. This is the inverse to dpn:owns"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"owner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#owner">http://purl.org/dpn#owner</seealso>
    let owner = Prefixed_Name(dpn, "owner") |> PrefixedName
    /// <summary>
    ///   <para>dpn:owns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property to express what is owned by a resource in the context of a data provider node and its datasets. This is the inverse of dpn:owner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"owns"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#owns">http://purl.org/dpn#owns</seealso>
    let owns = Prefixed_Name(dpn, "owns") |> PrefixedName

    /// <summary>
    ///   <para>dpn:providesServiceInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dpn#providesServiceInterface">http://purl.org/dpn#providesServiceInterface</seealso>
    let providesServiceInterface =
        Prefixed_Name(dpn, "providesServiceInterface") |> PrefixedName

    /// <summary>
    ///   <para>dpn:related</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property to express relationship between resources in a data provider node context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"related"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#related">http://purl.org/dpn#related</seealso>
    let related = Prefixed_Name(dpn, "related") |> PrefixedName
    /// <summary>
    ///   <para>dpn:service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property to express the related service resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dpn#service">http://purl.org/dpn#service</seealso>
    let service = Prefixed_Name(dpn, "service") |> PrefixedName
