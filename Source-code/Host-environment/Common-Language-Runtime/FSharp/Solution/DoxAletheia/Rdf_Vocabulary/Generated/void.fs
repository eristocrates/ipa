namespace http.rdfs.org.ns._void.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module void_ =
    let _namespace_iri = Namespace_Iri void_ |> NamespaceIRI
    /// <summary>
    ///   <para>void:Linkset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A collection of RDF links between two void:Datasets.</para>
    /// labels<para>linkset</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#Linkset">http://rdfs.org/ns/void#Linkset</seealso>
    let Linkset = Prefixed_Name(void_, "Linkset") |> PrefixedName

    /// <summary>
    ///   <para>void:openSearchDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An OpenSearch description document for a free-text search service over a void:Dataset.</para>
    /// labels<para>open search description</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#openSearchDescription">http://rdfs.org/ns/void#openSearchDescription</seealso>
    let openSearchDescription =
        Prefixed_Name(void_, "openSearchDescription") |> PrefixedName

    /// <summary>
    ///   <para>void:propertyPartition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A subset of a void:Dataset that contains only the triples of a certain rdf:Property.</para>
    /// labels<para>property partition</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#propertyPartition">http://rdfs.org/ns/void#propertyPartition</seealso>
    let propertyPartition = Prefixed_Name(void_, "propertyPartition") |> PrefixedName
    /// <summary>
    ///   <para>void:sparqlEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has a SPARQL endpoint at</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#sparqlEndpoint">http://rdfs.org/ns/void#sparqlEndpoint</seealso>
    let sparqlEndpoint = Prefixed_Name(void_, "sparqlEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>void:class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The rdfs:Class that is the rdf:type of all entities in a class-based partition.</para>
    /// labels<para>class</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#class">http://rdfs.org/ns/void#class</seealso>
    let class_ = Prefixed_Name(void_, "class") |> PrefixedName
    /// <summary>
    ///   <para>void:DatasetDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A web resource whose foaf:primaryTopic or foaf:topics include void:Datasets.</para>
    /// labels<para>dataset description</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#DatasetDescription">http://rdfs.org/ns/void#DatasetDescription</seealso>
    let DatasetDescription = Prefixed_Name(void_, "DatasetDescription") |> PrefixedName
    /// <summary>
    ///   <para>void:TechnicalFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A technical feature of a void:Dataset, such as a supported RDF serialization format.</para>
    /// labels<para>technical feature</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#TechnicalFeature">http://rdfs.org/ns/void#TechnicalFeature</seealso>
    let TechnicalFeature = Prefixed_Name(void_, "TechnicalFeature") |> PrefixedName
    /// <summary>
    ///   <para>void:classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The total number of distinct classes in a void:Dataset. In other words, the number of distinct resources occuring as objects of rdf:type triples in the dataset.</para>
    /// labels<para>classes</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#classes">http://rdfs.org/ns/void#classes</seealso>
    let classes = Prefixed_Name(void_, "classes") |> PrefixedName
    /// <summary>
    ///   <para>void:distinctObjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total number of distinct objects in a void:Dataset. In other words, the number of distinct resources that occur in the object position of triples in the dataset. Literals are included in this count.</para>
    /// labels<para>distinct objects</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#distinctObjects">http://rdfs.org/ns/void#distinctObjects</seealso>
    let distinctObjects = Prefixed_Name(void_, "distinctObjects") |> PrefixedName
    /// <summary>
    ///   <para>void:distinctSubjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The total number of distinct subjects in a void:Dataset. In other words, the number of distinct resources that occur in the subject position of triples in the dataset.</para>
    /// labels<para>distinct subjects</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#distinctSubjects">http://rdfs.org/ns/void#distinctSubjects</seealso>
    let distinctSubjects = Prefixed_Name(void_, "distinctSubjects") |> PrefixedName
    /// <summary>
    ///   <para>void:entities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The total number of entities that are described in a void:Dataset.</para>
    /// labels<para>number of entities</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#entities">http://rdfs.org/ns/void#entities</seealso>
    let entities = Prefixed_Name(void_, "entities") |> PrefixedName
    /// <summary>
    ///   <para>void:feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>feature</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#feature">http://rdfs.org/ns/void#feature</seealso>
    let feature = Prefixed_Name(void_, "feature") |> PrefixedName
    /// <summary>
    ///   <para>void:linkPredicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>a link predicate</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#linkPredicate">http://rdfs.org/ns/void#linkPredicate</seealso>
    let linkPredicate = Prefixed_Name(void_, "linkPredicate") |> PrefixedName
    /// <summary>
    ///   <para>void:properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total number of distinct properties in a void:Dataset. In other words, the number of distinct resources that occur in the predicate position of triples in the dataset.</para>
    /// labels<para>number of properties</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#properties">http://rdfs.org/ns/void#properties</seealso>
    let properties = Prefixed_Name(void_, "properties") |> PrefixedName
    /// <summary>
    ///   <para>void:classPartition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A subset of a void:Dataset that contains only the entities of a certain rdfs:Class.</para>
    /// labels<para>class partition</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#classPartition">http://rdfs.org/ns/void#classPartition</seealso>
    let classPartition = Prefixed_Name(void_, "classPartition") |> PrefixedName
    /// <summary>
    ///   <para>void:dataDump</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An RDF dump, partial or complete, of a void:Dataset.</para>
    /// labels<para>Data Dump</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#dataDump">http://rdfs.org/ns/void#dataDump</seealso>
    let dataDump = Prefixed_Name(void_, "dataDump") |> PrefixedName
    /// <summary>
    ///   <para>void:subset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has subset</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#subset">http://rdfs.org/ns/void#subset</seealso>
    let subset = Prefixed_Name(void_, "subset") |> PrefixedName
    /// <summary>
    ///   <para>void:documents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The total number of documents, for datasets that are published as a set of individual documents, such as RDF/XML documents or RDFa-annotated web pages. Non-RDF documents, such as web pages in HTML or images, are usually not included in this count. This property is intended for datasets where the total number of triples or entities is hard to determine. void:triples or void:entities should be preferred where practical.</para>
    /// labels<para>number of documents</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#documents">http://rdfs.org/ns/void#documents</seealso>
    let documents = Prefixed_Name(void_, "documents") |> PrefixedName
    /// <summary>
    ///   <para>void:exampleResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>example resource of dataset</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#exampleResource">http://rdfs.org/ns/void#exampleResource</seealso>
    let exampleResource = Prefixed_Name(void_, "exampleResource") |> PrefixedName
    /// <summary>
    ///   <para>void:objectsTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The dataset describing the objects of the triples contained in the Linkset.</para>
    /// labels<para>Objects Target</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#objectsTarget">http://rdfs.org/ns/void#objectsTarget</seealso>
    let objectsTarget = Prefixed_Name(void_, "objectsTarget") |> PrefixedName
    /// <summary>
    ///   <para>void:target</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>One of the two datasets linked by the Linkset.</para>
    /// labels<para>Target</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#target">http://rdfs.org/ns/void#target</seealso>
    let target = Prefixed_Name(void_, "target") |> PrefixedName
    /// <summary>
    ///   <para>void:inDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Points to the void:Dataset that a document is a part of.</para>
    /// labels<para>in dataset</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#inDataset">http://rdfs.org/ns/void#inDataset</seealso>
    let inDataset = Prefixed_Name(void_, "inDataset") |> PrefixedName
    /// <summary>
    ///   <para>void:property</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The rdf:Property that is the predicate of all triples in a property-based partition.</para>
    /// labels<para>property</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#property">http://rdfs.org/ns/void#property</seealso>
    let property = Prefixed_Name(void_, "property") |> PrefixedName
    /// <summary>
    ///   <para>void:rootResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A top concept or entry point for a void:Dataset that is structured in a tree-like fashion. All resources in a dataset can be reached by following links from its root resources in a small number of steps.</para>
    /// labels<para>root resource</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#rootResource">http://rdfs.org/ns/void#rootResource</seealso>
    let rootResource = Prefixed_Name(void_, "rootResource") |> PrefixedName
    /// <summary>
    ///   <para>void:subjectsTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The dataset describing the subjects of triples contained in the Linkset.</para>
    /// labels<para>Subjects Target</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#subjectsTarget">http://rdfs.org/ns/void#subjectsTarget</seealso>
    let subjectsTarget = Prefixed_Name(void_, "subjectsTarget") |> PrefixedName
    /// <summary>
    ///   <para>void:uriLookupEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Defines a simple URI look-up protocol for accessing a dataset.</para>
    /// labels<para>has an URI look-up endpoint at</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#uriLookupEndpoint">http://rdfs.org/ns/void#uriLookupEndpoint</seealso>
    let uriLookupEndpoint = Prefixed_Name(void_, "uriLookupEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>void:uriSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A URI that is a common string prefix of all the entity URIs in a void:Dataset.</para>
    /// labels<para>URI space</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#uriSpace">http://rdfs.org/ns/void#uriSpace</seealso>
    let uriSpace = Prefixed_Name(void_, "uriSpace") |> PrefixedName
    /// <summary>
    ///   <para>void:vocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A vocabulary that is used in the dataset.</para>
    /// labels<para>vocabulary</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#vocabulary">http://rdfs.org/ns/void#vocabulary</seealso>
    let vocabulary = Prefixed_Name(void_, "vocabulary") |> PrefixedName
    /// <summary>
    ///   <para>void:triples</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total number of triples contained in a void:Dataset.</para>
    /// labels<para>number of triples</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#triples">http://rdfs.org/ns/void#triples</seealso>
    let triples = Prefixed_Name(void_, "triples") |> PrefixedName
    /// <summary>
    ///   <para>void:uriRegexPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Defines a regular expression pattern matching URIs in the dataset.</para>
    /// labels<para>has URI regular expression pattern</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#uriRegexPattern">http://rdfs.org/ns/void#uriRegexPattern</seealso>
    let uriRegexPattern = Prefixed_Name(void_, "uriRegexPattern") |> PrefixedName
    /// <summary>
    ///   <para>void:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A set of RDF triples that are published, maintained or aggregated by a single provider.</para>
    /// labels<para>dataset</para></remarks>
    /// <seealso href="http://rdfs.org/ns/void#Dataset">http://rdfs.org/ns/void#Dataset</seealso>
    let Dataset = Prefixed_Name(void_, "Dataset") |> PrefixedName
