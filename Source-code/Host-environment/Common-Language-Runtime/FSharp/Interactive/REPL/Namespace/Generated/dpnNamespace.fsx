#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dpn =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/dpn#" "dpn"
    /// <summary>
    ///   <para>rdfs:label : Catalog^^xsd:string</para>
    ///   <para>rdfs:comment : A catalog is a curated set of metadata about datasets^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#Catalog">dpn:Catalog</a>
    /// </summary>
    let Catalog = _prefixId.prefix "Catalog"
    /// <summary>
    ///   <para>rdfs:label : Data Service Interface^^xsd:string</para>
    ///   <para>rdfs:comment : An abstract class of data service interfaces^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#DataServiceInterface">dpn:DataServiceInterface</a>
    /// </summary>
    let DataServiceInterface = _prefixId.prefix "DataServiceInterface"
    /// <summary>
    ///   <para>rdfs:label : Dataset^^xsd:string</para>
    ///   <para>rdfs:comment : Class to represent datasets, which are collections of data. Datasets are accessed via a means of a Distribution, e.g. via a service which can be defined as a type of distribution method or a direct download.^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#Dataset">dpn:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>rdfs:label : Feature Type Catalogue^^xsd:string</para>
    ///   <para>rdfs:comment : A Feature Type Catalogue (FTC) gives an informative overview of the spatial object types (features) and data types. Generally an FTC implements a registry of feature types which allow features to be described.^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#FeatureTypeCatalogue">dpn:FeatureTypeCatalogue</a>
    /// </summary>
    let FeatureTypeCatalogue = _prefixId.prefix "FeatureTypeCatalogue"
    let Html = _prefixId.prefix "Html"
    /// <summary>
    ///   <para>rdfs:label : Persistent Identifier Service^^xsd:string</para>
    ///   <para>rdfs:comment : Persistent Identifier Service allows registry and deferencing identifier handles.^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#IdentifierService">dpn:IdentifierService</a>
    /// </summary>
    let IdentifierService = _prefixId.prefix "IdentifierService"
    /// <summary>
    ///   <para>rdfs:label : Information Model Service Interface^^xsd:string</para>
    ///   <para>rdfs:comment : An abstract interface for information model services^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#InfoModelServiceInterface">dpn:InfoModelServiceInterface</a>
    /// </summary>
    let InfoModelServiceInterface = _prefixId.prefix "InfoModelServiceInterface"
    let JSON = _prefixId.prefix "JSON"
    /// <summary>
    ///   <para>rdfs:label : Linked Data API Operation^^xsd:string</para>
    ///   <para>rdfs:comment : Description of a Linked Data API operation^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#LinkedDataApiOperation">dpn:LinkedDataApiOperation</a>
    /// </summary>
    let LinkedDataApiOperation = _prefixId.prefix "LinkedDataApiOperation"
    let MessageContent_1 = _prefixId.prefix "MessageContent_1"
    /// <summary>
    ///   <para>rdfs:label : Metadata Service Interface^^xsd:string</para>
    ///   <para>rdfs:comment : An abstract interface for metadata services^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#MetadataServiceInterface">dpn:MetadataServiceInterface</a>
    /// </summary>
    let MetadataServiceInterface = _prefixId.prefix "MetadataServiceInterface"
    /// <summary>
    ///   <para>rdfs:label : Data provider node^^xsd:string</para>
    ///   <para>rdfs:comment : A data provider node is a class of things that exposes concrete service implementations and/or describes a number of service interfaces that it supports. This allows discovery of services or service capabilities for a given data provider node.^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#Node">dpn:Node</a>
    /// </summary>
    let Node = _prefixId.prefix "Node"
    /// <summary>
    ///   <para>rdfs:label : Provenance Service Interface^^xsd:string</para>
    ///   <para>rdfs:comment : An abstract interface for provenance services^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#ProvenanceServiceInterface">dpn:ProvenanceServiceInterface</a>
    /// </summary>
    let ProvenanceServiceInterface = _prefixId.prefix "ProvenanceServiceInterface"
    let RDF = _prefixId.prefix "RDF"
    /// <summary>
    ///   <para>rdfs:comment : Lightweight description for a Web Service through which data may be accessed^^xsd:string</para>
    ///   <para>rdfs:label : Web Service^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#Service">dpn:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:label : Service Interface Standard^^xsd:string</para>
    ///   <para>rdfs:comment : An abstract class for defining service interface standards for which services may implement^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#ServiceInterface">dpn:ServiceInterface</a>
    /// </summary>
    let ServiceInterface = _prefixId.prefix "ServiceInterface"
    /// <summary>
    ///   <para>rdfs:label : Vocabulary Service Interface^^xsd:string</para>
    ///   <para>rdfs:comment : An abstract interface or API for a vocabulary service, which typically hosts a set of well-governed controlled vocabularies.^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#VocabularyServiceInterface">dpn:VocabularyServiceInterface</a>
    /// </summary>
    let VocabularyServiceInterface = _prefixId.prefix "VocabularyServiceInterface"
    let XML = _prefixId.prefix "XML"
    /// <summary>
    ///   <para>skos:prefLabel : contact point^^xsd:string</para>
    ///   <para>rdfs:label : Link a resource to a relevant contact provided using VCard^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#contactPoint">dpn:contactPoint</a>
    /// </summary>
    let contactPoint = _prefixId.prefix "contactPoint"
    /// <summary>
    ///   <para>rdfs:label : endpoint^^xsd:string</para>
    ///   <para>rdfs:comment : Property to associate a resource with a resolvable endpoint URL. e.g. to a URL of a catalog or a GetCapabilities description.^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#endpoint">dpn:endpoint</a>
    /// </summary>
    let endpoint = _prefixId.prefix "endpoint"
    /// <summary>
    ///   <para>rdfs:label : exposes service^^xsd:string</para>
    ///   <para>rdfs:comment : This property allows a resource to specify the services that it exposes. e.g. a Data provider node may expose a data service. The complement of this could be dpn:node to specify a Service's data provider node^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#exposesService">dpn:exposesService</a>
    /// </summary>
    let exposesService = _prefixId.prefix "exposesService"
    /// <summary>
    ///   <para>rdfs:label : has implementation^^xsd:string</para>
    ///   <para>rdfs:comment : This property captures the association between a service interface specification and resources that has its service implementations^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#hasImplementation">dpn:hasImplementation</a>
    /// </summary>
    let hasImplementation = _prefixId.prefix "hasImplementation"
    /// <summary>
    ///   <para>rdfs:label : hosted by^^xsd:string</para>
    ///   <para>rdfs:comment : Property to express the entity which hosts a given resource. This is the inverse of dpn:hosts^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#hostedBy">dpn:hostedBy</a>
    /// </summary>
    let hostedBy = _prefixId.prefix "hostedBy"
    /// <summary>
    ///   <para>rdfs:label : hosts^^xsd:string</para>
    ///   <para>rdfs:comment : Property to express the resource which the entity hosts. This is the inverse of dpn:hostedBy.^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#hosts">dpn:hosts</a>
    /// </summary>
    let hosts = _prefixId.prefix "hosts"
    /// <summary>
    ///   <para>rdfs:label : hosts dataset^^xsd:string</para>
    ///   <para>rdfs:comment : This property allows association of a service to datasets that it hosts.^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#hostsDataset">dpn:hostsDataset</a>
    /// </summary>
    let hostsDataset = _prefixId.prefix "hostsDataset"
    /// <summary>
    ///   <para>rdfs:label : hosts node^^xsd:string</para>
    ///   <para>rdfs:comment : An organisation can host a data provider node^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#hostsNode">dpn:hostsNode</a>
    /// </summary>
    let hostsNode = _prefixId.prefix "hostsNode"
    /// <summary>
    ///   <para>rdfs:label : implements^^xsd:string</para>
    ///   <para>rdfs:comment : This property captures the association between a service and its interface specification. This is the inverse to hasImplementation.^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#implements">dpn:implements</a>
    /// </summary>
    let implements = _prefixId.prefix "implements"
    /// <summary>
    ///   <para>rdfs:label : manager^^xsd:string</para>
    ///   <para>rdfs:comment : Property to describe who the manager of the resource is.^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#manager">dpn:manager</a>
    /// </summary>
    let manager = _prefixId.prefix "manager"
    /// <summary>
    ///   <para>rdfs:label : manages^^xsd:string</para>
    ///   <para>rdfs:comment : A property to describe what entities are managed by a resource^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#manages">dpn:manages</a>
    /// </summary>
    let manages = _prefixId.prefix "manages"
    /// <summary>
    ///   <para>rdfs:label : node^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#node">dpn:node</a>
    /// </summary>
    let node = _prefixId.prefix "node"
    /// <summary>
    ///   <para>rdfs:label : owner^^xsd:string</para>
    ///   <para>rdfs:comment : Property to express the owner of a resource. This is the inverse to dpn:owns^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#owner">dpn:owner</a>
    /// </summary>
    let owner = _prefixId.prefix "owner"
    /// <summary>
    ///   <para>rdfs:label : owns^^xsd:string</para>
    ///   <para>rdfs:comment : Property to express what is owned by a resource in the context of a data provider node and its datasets. This is the inverse of dpn:owner^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#owns">dpn:owns</a>
    /// </summary>
    let owns = _prefixId.prefix "owns"
    let providesServiceInterface = _prefixId.prefix "providesServiceInterface"
    /// <summary>
    ///   <para>rdfs:label : related^^xsd:string</para>
    ///   <para>rdfs:comment : Property to express relationship between resources in a data provider node context^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#related">dpn:related</a>
    /// </summary>
    let related = _prefixId.prefix "related"
    /// <summary>
    ///   <para>rdfs:label : service^^xsd:string</para>
    ///   <para>rdfs:comment : Property to express the related service resource^^xsd:string</para>
    ///   <a href="http://purl.org/dpn#service">dpn:service</a>
    /// </summary>
    let service = _prefixId.prefix "service"
