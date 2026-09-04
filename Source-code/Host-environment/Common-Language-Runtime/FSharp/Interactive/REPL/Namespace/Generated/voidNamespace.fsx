#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``void`` =
    let _prefixId = PrefixId.fromNamespaceLabel "http://rdfs.org/ns/void#" "void"
    /// <summary>
    ///   <para>rdfs:comment : A set of RDF triples that are published, maintained or aggregated by a single provider.^^xsd:string</para>
    ///   <para>rdfs:label : dataset^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#Dataset">void:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>rdfs:comment : A web resource whose foaf:primaryTopic or foaf:topics include void:Datasets.^^xsd:string</para>
    ///   <para>rdfs:label : dataset description^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#DatasetDescription">void:DatasetDescription</a>
    /// </summary>
    let DatasetDescription = _prefixId.prefix "DatasetDescription"
    /// <summary>
    ///   <para>rdfs:comment : A collection of RDF links between two void:Datasets.^^xsd:string</para>
    ///   <para>rdfs:label : linkset^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#Linkset">void:Linkset</a>
    /// </summary>
    let Linkset = _prefixId.prefix "Linkset"
    /// <summary>
    ///   <para>rdfs:comment : A technical feature of a void:Dataset, such as a supported RDF serialization format.^^xsd:string</para>
    ///   <para>rdfs:label : technical feature^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#TechnicalFeature">void:TechnicalFeature</a>
    /// </summary>
    let TechnicalFeature = _prefixId.prefix "TechnicalFeature"
    /// <summary>
    ///   <para>rdfs:comment : The rdfs:Class that is the rdf:type of all entities in a class-based partition.^^xsd:string</para>
    ///   <para>rdfs:label : class^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#class">void:class</a>
    /// </summary>
    let class_ = _prefixId.prefix "class"
    /// <summary>
    ///   <para>rdfs:comment : A subset of a void:Dataset that contains only the entities of a certain rdfs:Class.^^xsd:string</para>
    ///   <para>rdfs:label : class partition^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#classPartition">void:classPartition</a>
    /// </summary>
    let classPartition = _prefixId.prefix "classPartition"
    /// <summary>
    ///   <para>rdfs:comment : The total number of distinct classes in a void:Dataset. In other words, the number of distinct resources occuring as objects of rdf:type triples in the dataset.^^xsd:string</para>
    ///   <para>rdfs:label : classes^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#classes">void:classes</a>
    /// </summary>
    let classes = _prefixId.prefix "classes"
    /// <summary>
    ///   <para>rdfs:comment : An RDF dump, partial or complete, of a void:Dataset.^^xsd:string</para>
    ///   <para>rdfs:label : Data Dump^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#dataDump">void:dataDump</a>
    /// </summary>
    let dataDump = _prefixId.prefix "dataDump"
    /// <summary>
    ///   <para>rdfs:comment : The total number of distinct objects in a void:Dataset. In other words, the number of distinct resources that occur in the object position of triples in the dataset. Literals are included in this count.^^xsd:string</para>
    ///   <para>rdfs:label : distinct objects^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#distinctObjects">void:distinctObjects</a>
    /// </summary>
    let distinctObjects = _prefixId.prefix "distinctObjects"
    /// <summary>
    ///   <para>rdfs:comment : The total number of distinct subjects in a void:Dataset. In other words, the number of distinct resources that occur in the subject position of triples in the dataset.^^xsd:string</para>
    ///   <para>rdfs:label : distinct subjects^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#distinctSubjects">void:distinctSubjects</a>
    /// </summary>
    let distinctSubjects = _prefixId.prefix "distinctSubjects"
    /// <summary>
    ///   <para>rdfs:comment : The total number of documents, for datasets that are published as a set of individual documents, such as RDF/XML documents or RDFa-annotated web pages. Non-RDF documents, such as web pages in HTML or images, are usually not included in this count. This property is intended for datasets where the total number of triples or entities is hard to determine. void:triples or void:entities should be preferred where practical.^^xsd:string</para>
    ///   <para>rdfs:label : number of documents^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#documents">void:documents</a>
    /// </summary>
    let documents = _prefixId.prefix "documents"
    /// <summary>
    ///   <para>rdfs:comment : The total number of entities that are described in a void:Dataset.^^xsd:string</para>
    ///   <para>rdfs:label : number of entities^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#entities">void:entities</a>
    /// </summary>
    let entities = _prefixId.prefix "entities"
    /// <summary>
    ///   <para>rdfs:label : example resource of dataset^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#exampleResource">void:exampleResource</a>
    /// </summary>
    let exampleResource = _prefixId.prefix "exampleResource"
    /// <summary>
    ///   <para>rdfs:label : feature^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#feature">void:feature</a>
    /// </summary>
    let feature = _prefixId.prefix "feature"
    /// <summary>
    ///   <para>rdfs:comment : Points to the void:Dataset that a document is a part of.^^xsd:string</para>
    ///   <para>rdfs:label : in dataset^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#inDataset">void:inDataset</a>
    /// </summary>
    let inDataset = _prefixId.prefix "inDataset"
    /// <summary>
    ///   <para>rdfs:label : a link predicate^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#linkPredicate">void:linkPredicate</a>
    /// </summary>
    let linkPredicate = _prefixId.prefix "linkPredicate"
    /// <summary>
    ///   <para>rdfs:comment : The dataset describing the objects of the triples contained in the Linkset.^^xsd:string</para>
    ///   <para>rdfs:label : Objects Target^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#objectsTarget">void:objectsTarget</a>
    /// </summary>
    let objectsTarget = _prefixId.prefix "objectsTarget"
    /// <summary>
    ///   <para>rdfs:comment : An OpenSearch description document for a free-text search service over a void:Dataset.^^xsd:string</para>
    ///   <para>rdfs:label : open search description^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#openSearchDescription">void:openSearchDescription</a>
    /// </summary>
    let openSearchDescription = _prefixId.prefix "openSearchDescription"
    /// <summary>
    ///   <para>rdfs:comment : The total number of distinct properties in a void:Dataset. In other words, the number of distinct resources that occur in the predicate position of triples in the dataset.^^xsd:string</para>
    ///   <para>rdfs:label : number of properties^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#properties">void:properties</a>
    /// </summary>
    let properties = _prefixId.prefix "properties"
    /// <summary>
    ///   <para>rdfs:comment : The rdf:Property that is the predicate of all triples in a property-based partition.^^xsd:string</para>
    ///   <para>rdfs:label : property^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#property">void:property</a>
    /// </summary>
    let property = _prefixId.prefix "property"
    /// <summary>
    ///   <para>rdfs:comment : A subset of a void:Dataset that contains only the triples of a certain rdf:Property.^^xsd:string</para>
    ///   <para>rdfs:label : property partition^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#propertyPartition">void:propertyPartition</a>
    /// </summary>
    let propertyPartition = _prefixId.prefix "propertyPartition"
    /// <summary>
    ///   <para>rdfs:comment : A top concept or entry point for a void:Dataset that is structured in a tree-like fashion. All resources in a dataset can be reached by following links from its root resources in a small number of steps.^^xsd:string</para>
    ///   <para>rdfs:label : root resource^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#rootResource">void:rootResource</a>
    /// </summary>
    let rootResource = _prefixId.prefix "rootResource"
    /// <summary>
    ///   <para>rdfs:label : has a SPARQL endpoint at^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#sparqlEndpoint">void:sparqlEndpoint</a>
    /// </summary>
    let sparqlEndpoint = _prefixId.prefix "sparqlEndpoint"
    /// <summary>
    ///   <para>rdfs:comment : The dataset describing the subjects of triples contained in the Linkset.^^xsd:string</para>
    ///   <para>rdfs:label : Subjects Target^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#subjectsTarget">void:subjectsTarget</a>
    /// </summary>
    let subjectsTarget = _prefixId.prefix "subjectsTarget"
    /// <summary>
    ///   <para>rdfs:label : has subset^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#subset">void:subset</a>
    /// </summary>
    let subset = _prefixId.prefix "subset"
    /// <summary>
    ///   <para>rdfs:comment : One of the two datasets linked by the Linkset.^^xsd:string</para>
    ///   <para>rdfs:label : Target^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#target">void:target</a>
    /// </summary>
    let target = _prefixId.prefix "target"
    /// <summary>
    ///   <para>rdfs:comment : The total number of triples contained in a void:Dataset.^^xsd:string</para>
    ///   <para>rdfs:label : number of triples^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#triples">void:triples</a>
    /// </summary>
    let triples = _prefixId.prefix "triples"
    /// <summary>
    ///   <para>rdfs:comment : Defines a simple URI look-up protocol for accessing a dataset.^^xsd:string</para>
    ///   <para>rdfs:label : has an URI look-up endpoint at^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#uriLookupEndpoint">void:uriLookupEndpoint</a>
    /// </summary>
    let uriLookupEndpoint = _prefixId.prefix "uriLookupEndpoint"
    /// <summary>
    ///   <para>rdfs:comment : Defines a regular expression pattern matching URIs in the dataset.^^xsd:string</para>
    ///   <para>rdfs:label : has URI regular expression pattern^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#uriRegexPattern">void:uriRegexPattern</a>
    /// </summary>
    let uriRegexPattern = _prefixId.prefix "uriRegexPattern"
    /// <summary>
    ///   <para>rdfs:comment : A URI that is a common string prefix of all the entity URIs in a void:Dataset.^^xsd:string</para>
    ///   <para>rdfs:label : URI space^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#uriSpace">void:uriSpace</a>
    /// </summary>
    let uriSpace = _prefixId.prefix "uriSpace"
    /// <summary>
    ///   <para>rdfs:comment : A vocabulary that is used in the dataset.^^xsd:string</para>
    ///   <para>rdfs:label : vocabulary^^xsd:string</para>
    ///   <a href="http://rdfs.org/ns/void#vocabulary">void:vocabulary</a>
    /// </summary>
    let vocabulary = _prefixId.prefix "vocabulary"
