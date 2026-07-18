namespace http.purl.org.dpn.hash

open DoxAletheia.Rdf_Vocabulary

module dpn =
    let _namespace_name = "http://purl.org/dpn#"
    /// <summary>
    /// A catalog is a curated set of metadata about datasets
    /// <see href="http://purl.org/dpn#Catalog"></see></summary>
    let Catalog = Namespaced_IRI.parse _namespace_name "Catalog" |> NamespacedName

    /// <summary>
    /// An abstract class of data service interfaces
    /// <see href="http://purl.org/dpn#DataServiceInterface"></see></summary>
    let DataServiceInterface =
        Namespaced_IRI.parse _namespace_name "DataServiceInterface" |> NamespacedName

    /// <summary>
    /// An abstract class for defining service interface standards for which services may implement
    /// <see href="http://purl.org/dpn#ServiceInterface"></see></summary>
    let ServiceInterface =
        Namespaced_IRI.parse _namespace_name "ServiceInterface" |> NamespacedName

    /// <summary>
    /// Class to represent datasets, which are collections of data. Datasets are accessed via a means of a Distribution, e.g. via a service which can be defined as a type of distribution method or a direct download.
    /// <see href="http://purl.org/dpn#Dataset"></see></summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName
    /// <summary>
    /// Property to express the entity which hosts a given resource. This is the inverse of dpn:hosts
    /// <see href="http://purl.org/dpn#hostedBy"></see></summary>
    let hostedBy = Namespaced_IRI.parse _namespace_name "hostedBy" |> NamespacedName
    /// <summary>
    /// Property to describe who the manager of the resource is.
    /// <see href="http://purl.org/dpn#manager"></see></summary>
    let manager = Namespaced_IRI.parse _namespace_name "manager" |> NamespacedName

    /// <summary>
    /// A Feature Type Catalogue (FTC) gives an informative overview of the spatial object types (features) and data types. Generally an FTC implements a registry of feature types which allow features to be described.
    /// <see href="http://purl.org/dpn#FeatureTypeCatalogue"></see></summary>
    let FeatureTypeCatalogue =
        Namespaced_IRI.parse _namespace_name "FeatureTypeCatalogue" |> NamespacedName

    /// <summary>
    /// An abstract interface for information model services
    /// <see href="http://purl.org/dpn#InfoModelServiceInterface"></see></summary>
    let InfoModelServiceInterface =
        Namespaced_IRI.parse _namespace_name "InfoModelServiceInterface" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dpn#Html"></see>
    /// </summary>
    let Html = Namespaced_IRI.parse _namespace_name "Html" |> NamespacedName

    /// <summary>
    /// Persistent Identifier Service allows registry and deferencing identifier handles.
    /// <see href="http://purl.org/dpn#IdentifierService"></see></summary>
    let IdentifierService =
        Namespaced_IRI.parse _namespace_name "IdentifierService" |> NamespacedName

    /// <summary>
    /// Lightweight description for a Web Service through which data may be accessed
    /// <see href="http://purl.org/dpn#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/dpn#JSON"></see>
    /// </summary>
    let JSON = Namespaced_IRI.parse _namespace_name "JSON" |> NamespacedName

    /// <summary>
    /// Description of a Linked Data API operation
    /// <see href="http://purl.org/dpn#LinkedDataApiOperation"></see></summary>
    let LinkedDataApiOperation =
        Namespaced_IRI.parse _namespace_name "LinkedDataApiOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dpn#RDF"></see>
    /// </summary>
    let RDF = Namespaced_IRI.parse _namespace_name "RDF" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/dpn#XML"></see>
    /// </summary>
    let XML = Namespaced_IRI.parse _namespace_name "XML" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dpn#MessageContent_1"></see>
    /// </summary>
    let MessageContent_1 =
        Namespaced_IRI.parse _namespace_name "MessageContent_1" |> NamespacedName

    /// <summary>
    /// An abstract interface for metadata services
    /// <see href="http://purl.org/dpn#MetadataServiceInterface"></see></summary>
    let MetadataServiceInterface =
        Namespaced_IRI.parse _namespace_name "MetadataServiceInterface" |> NamespacedName

    /// <summary>
    /// A data provider node is a class of things that exposes concrete service implementations and/or describes a number of service interfaces that it supports. This allows discovery of services or service capabilities for a given data provider node.
    /// <see href="http://purl.org/dpn#Node"></see></summary>
    let Node = Namespaced_IRI.parse _namespace_name "Node" |> NamespacedName

    /// <summary>
    /// This property allows a resource to specify the services that it exposes. e.g. a Data provider node may expose a data service. The complement of this could be dpn:node to specify a Service's data provider node
    /// <see href="http://purl.org/dpn#exposesService"></see></summary>
    let exposesService =
        Namespaced_IRI.parse _namespace_name "exposesService" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dpn#providesServiceInterface"></see>
    /// </summary>
    let providesServiceInterface =
        Namespaced_IRI.parse _namespace_name "providesServiceInterface" |> NamespacedName

    /// <summary>
    /// An abstract interface for provenance services
    /// <see href="http://purl.org/dpn#ProvenanceServiceInterface"></see></summary>
    let ProvenanceServiceInterface =
        Namespaced_IRI.parse _namespace_name "ProvenanceServiceInterface" |> NamespacedName

    /// <summary>
    /// This property allows association of a service to datasets that it hosts.
    /// <see href="http://purl.org/dpn#hostsDataset"></see></summary>
    let hostsDataset =
        Namespaced_IRI.parse _namespace_name "hostsDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dpn#node"></see>
    /// </summary>
    let node = Namespaced_IRI.parse _namespace_name "node" |> NamespacedName
    /// <summary>
    /// This property captures the association between a service and its interface specification. This is the inverse to hasImplementation.
    /// <see href="http://purl.org/dpn#implements"></see></summary>
    let implements = Namespaced_IRI.parse _namespace_name "implements" |> NamespacedName
    /// <summary>
    /// Property to associate a resource with a resolvable endpoint URL. e.g. to a URL of a catalog or a GetCapabilities description.
    /// <see href="http://purl.org/dpn#endpoint"></see></summary>
    let endpoint = Namespaced_IRI.parse _namespace_name "endpoint" |> NamespacedName

    /// <summary>
    /// This property captures the association between a service interface specification and resources that has its service implementations
    /// <see href="http://purl.org/dpn#hasImplementation"></see></summary>
    let hasImplementation =
        Namespaced_IRI.parse _namespace_name "hasImplementation" |> NamespacedName

    /// <summary>
    /// An abstract interface or API for a vocabulary service, which typically hosts a set of well-governed controlled vocabularies.
    /// <see href="http://purl.org/dpn#VocabularyServiceInterface"></see></summary>
    let VocabularyServiceInterface =
        Namespaced_IRI.parse _namespace_name "VocabularyServiceInterface" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dpn#contactPoint"></see>
    /// </summary>
    let contactPoint =
        Namespaced_IRI.parse _namespace_name "contactPoint" |> NamespacedName

    /// <summary>
    /// Property to express the resource which the entity hosts. This is the inverse of dpn:hostedBy.
    /// <see href="http://purl.org/dpn#hosts"></see></summary>
    let hosts = Namespaced_IRI.parse _namespace_name "hosts" |> NamespacedName
    /// <summary>
    /// An organisation can host a data provider node
    /// <see href="http://purl.org/dpn#hostsNode"></see></summary>
    let hostsNode = Namespaced_IRI.parse _namespace_name "hostsNode" |> NamespacedName
    /// <summary>
    /// A property to describe what entities are managed by a resource
    /// <see href="http://purl.org/dpn#manages"></see></summary>
    let manages = Namespaced_IRI.parse _namespace_name "manages" |> NamespacedName
    /// <summary>
    /// Property to express the owner of a resource. This is the inverse to dpn:owns
    /// <see href="http://purl.org/dpn#owner"></see></summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName
    /// <summary>
    /// Property to express what is owned by a resource in the context of a data provider node and its datasets. This is the inverse of dpn:owner
    /// <see href="http://purl.org/dpn#owns"></see></summary>
    let owns = Namespaced_IRI.parse _namespace_name "owns" |> NamespacedName
    /// <summary>
    /// Property to express relationship between resources in a data provider node context
    /// <see href="http://purl.org/dpn#related"></see></summary>
    let related = Namespaced_IRI.parse _namespace_name "related" |> NamespacedName
    /// <summary>
    /// Property to express the related service resource
    /// <see href="http://purl.org/dpn#service"></see></summary>
    let service = Namespaced_IRI.parse _namespace_name "service" |> NamespacedName
