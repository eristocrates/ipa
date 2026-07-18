namespace http.rdfs.org.ns._void.hash

open DoxAletheia.Rdf_Vocabulary

module void_ =
    let _namespace_name = "http://rdfs.org/ns/void#"
    /// <summary>
    /// A set of RDF triples that are published, maintained or aggregated by a single provider.
    /// <see href="http://rdfs.org/ns/void#Dataset"></see></summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName

    /// <summary>
    /// A web resource whose foaf:primaryTopic or foaf:topics include void:Datasets.
    /// <see href="http://rdfs.org/ns/void#DatasetDescription"></see></summary>
    let DatasetDescription =
        Namespaced_IRI.parse _namespace_name "DatasetDescription" |> NamespacedName

    /// <summary>
    /// A collection of RDF links between two void:Datasets.
    /// <see href="http://rdfs.org/ns/void#Linkset"></see></summary>
    let Linkset = Namespaced_IRI.parse _namespace_name "Linkset" |> NamespacedName

    /// <summary>
    /// A technical feature of a void:Dataset, such as a supported RDF serialization format.
    /// <see href="http://rdfs.org/ns/void#TechnicalFeature"></see></summary>
    let TechnicalFeature =
        Namespaced_IRI.parse _namespace_name "TechnicalFeature" |> NamespacedName

    /// <summary>
    /// The rdfs:Class that is the rdf:type of all entities in a class-based partition.
    /// <see href="http://rdfs.org/ns/void#class"></see></summary>
    let class_ = Namespaced_IRI.parse _namespace_name "class" |> NamespacedName

    /// <summary>
    /// A subset of a void:Dataset that contains only the entities of a certain rdfs:Class.
    /// <see href="http://rdfs.org/ns/void#classPartition"></see></summary>
    let classPartition =
        Namespaced_IRI.parse _namespace_name "classPartition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.org/ns/void#subset"></see>
    /// </summary>
    let subset = Namespaced_IRI.parse _namespace_name "subset" |> NamespacedName
    /// <summary>
    /// The total number of distinct classes in a void:Dataset. In other words, the number of distinct resources occuring as objects of rdf:type triples in the dataset.
    /// <see href="http://rdfs.org/ns/void#classes"></see></summary>
    let classes = Namespaced_IRI.parse _namespace_name "classes" |> NamespacedName
    /// <summary>
    /// An RDF dump, partial or complete, of a void:Dataset.
    /// <see href="http://rdfs.org/ns/void#dataDump"></see></summary>
    let dataDump = Namespaced_IRI.parse _namespace_name "dataDump" |> NamespacedName

    /// <summary>
    /// The total number of distinct objects in a void:Dataset. In other words, the number of distinct resources that occur in the object position of triples in the dataset. Literals are included in this count.
    /// <see href="http://rdfs.org/ns/void#distinctObjects"></see></summary>
    let distinctObjects =
        Namespaced_IRI.parse _namespace_name "distinctObjects" |> NamespacedName

    /// <summary>
    /// The total number of distinct subjects in a void:Dataset. In other words, the number of distinct resources that occur in the subject position of triples in the dataset.
    /// <see href="http://rdfs.org/ns/void#distinctSubjects"></see></summary>
    let distinctSubjects =
        Namespaced_IRI.parse _namespace_name "distinctSubjects" |> NamespacedName

    /// <summary>
    /// The total number of documents, for datasets that are published as a set of individual documents, such as RDF/XML documents or RDFa-annotated web pages. Non-RDF documents, such as web pages in HTML or images, are usually not included in this count. This property is intended for datasets where the total number of triples or entities is hard to determine. void:triples or void:entities should be preferred where practical.
    /// <see href="http://rdfs.org/ns/void#documents"></see></summary>
    let documents = Namespaced_IRI.parse _namespace_name "documents" |> NamespacedName
    /// <summary>
    /// The total number of entities that are described in a void:Dataset.
    /// <see href="http://rdfs.org/ns/void#entities"></see></summary>
    let entities = Namespaced_IRI.parse _namespace_name "entities" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.org/ns/void#exampleResource"></see>
    /// </summary>
    let exampleResource =
        Namespaced_IRI.parse _namespace_name "exampleResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.org/ns/void#feature"></see>
    /// </summary>
    let feature = Namespaced_IRI.parse _namespace_name "feature" |> NamespacedName
    /// <summary>
    /// Points to the void:Dataset that a document is a part of.
    /// <see href="http://rdfs.org/ns/void#inDataset"></see></summary>
    let inDataset = Namespaced_IRI.parse _namespace_name "inDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.org/ns/void#linkPredicate"></see>
    /// </summary>
    let linkPredicate =
        Namespaced_IRI.parse _namespace_name "linkPredicate" |> NamespacedName

    /// <summary>
    /// The dataset describing the objects of the triples contained in the Linkset.
    /// <see href="http://rdfs.org/ns/void#objectsTarget"></see></summary>
    let objectsTarget =
        Namespaced_IRI.parse _namespace_name "objectsTarget" |> NamespacedName

    /// <summary>
    /// One of the two datasets linked by the Linkset.
    /// <see href="http://rdfs.org/ns/void#target"></see></summary>
    let target = Namespaced_IRI.parse _namespace_name "target" |> NamespacedName

    /// <summary>
    /// An OpenSearch description document for a free-text search service over a void:Dataset.
    /// <see href="http://rdfs.org/ns/void#openSearchDescription"></see></summary>
    let openSearchDescription =
        Namespaced_IRI.parse _namespace_name "openSearchDescription" |> NamespacedName

    /// <summary>
    /// The total number of distinct properties in a void:Dataset. In other words, the number of distinct resources that occur in the predicate position of triples in the dataset.
    /// <see href="http://rdfs.org/ns/void#properties"></see></summary>
    let properties = Namespaced_IRI.parse _namespace_name "properties" |> NamespacedName
    /// <summary>
    /// The rdf:Property that is the predicate of all triples in a property-based partition.
    /// <see href="http://rdfs.org/ns/void#property"></see></summary>
    let property = Namespaced_IRI.parse _namespace_name "property" |> NamespacedName

    /// <summary>
    /// A subset of a void:Dataset that contains only the triples of a certain rdf:Property.
    /// <see href="http://rdfs.org/ns/void#propertyPartition"></see></summary>
    let propertyPartition =
        Namespaced_IRI.parse _namespace_name "propertyPartition" |> NamespacedName

    /// <summary>
    /// A top concept or entry point for a void:Dataset that is structured in a tree-like fashion. All resources in a dataset can be reached by following links from its root resources in a small number of steps.
    /// <see href="http://rdfs.org/ns/void#rootResource"></see></summary>
    let rootResource =
        Namespaced_IRI.parse _namespace_name "rootResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.org/ns/void#sparqlEndpoint"></see>
    /// </summary>
    let sparqlEndpoint =
        Namespaced_IRI.parse _namespace_name "sparqlEndpoint" |> NamespacedName

    /// <summary>
    /// The dataset describing the subjects of triples contained in the Linkset.
    /// <see href="http://rdfs.org/ns/void#subjectsTarget"></see></summary>
    let subjectsTarget =
        Namespaced_IRI.parse _namespace_name "subjectsTarget" |> NamespacedName

    /// <summary>
    /// The total number of triples contained in a void:Dataset.
    /// <see href="http://rdfs.org/ns/void#triples"></see></summary>
    let triples = Namespaced_IRI.parse _namespace_name "triples" |> NamespacedName

    /// <summary>
    /// Defines a simple URI look-up protocol for accessing a dataset.
    /// <see href="http://rdfs.org/ns/void#uriLookupEndpoint"></see></summary>
    let uriLookupEndpoint =
        Namespaced_IRI.parse _namespace_name "uriLookupEndpoint" |> NamespacedName

    /// <summary>
    /// Defines a regular expression pattern matching URIs in the dataset.
    /// <see href="http://rdfs.org/ns/void#uriRegexPattern"></see></summary>
    let uriRegexPattern =
        Namespaced_IRI.parse _namespace_name "uriRegexPattern" |> NamespacedName

    /// <summary>
    /// A URI that is a common string prefix of all the entity URIs in a void:Dataset.
    /// <see href="http://rdfs.org/ns/void#uriSpace"></see></summary>
    let uriSpace = Namespaced_IRI.parse _namespace_name "uriSpace" |> NamespacedName
    /// <summary>
    /// A vocabulary that is used in the dataset.
    /// <see href="http://rdfs.org/ns/void#vocabulary"></see></summary>
    let vocabulary = Namespaced_IRI.parse _namespace_name "vocabulary" |> NamespacedName
