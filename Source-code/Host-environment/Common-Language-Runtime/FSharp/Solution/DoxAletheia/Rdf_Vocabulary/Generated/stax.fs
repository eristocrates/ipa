namespace https.w3id.org.stax.ontology.hash

open DoxAletheia.Rdf_Vocabulary

module stax =
    let _namespace_name = "https://w3id.org/stax/ontology#"
    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#rdfStream"></see>
    /// </summary>
    let rdfStream = Namespaced_IRI.parse _namespace_name "rdfStream" |> NamespacedName

    /// <summary>
    /// Class for abstract RDF stream types in the taxonomy. Instances of this class have abstract definitions, i.e., they cannot be used to annotate real streams. They are only intended to be used for reasoning about stream types.
    /// <see href="https://w3id.org/stax/ontology#AbstractRdfStreamType"></see></summary>
    let AbstractRdfStreamType =
        Namespaced_IRI.parse _namespace_name "AbstractRdfStreamType" |> NamespacedName

    /// <summary>
    /// Base class for RDF stream types. This class should not be used directly – use instead either stax:AbstractRdfStreamType or stax:ConcreteRdfStreamType.
    /// <see href="https://w3id.org/stax/ontology#RdfStreamType"></see></summary>
    let RdfStreamType =
        Namespaced_IRI.parse _namespace_name "RdfStreamType" |> NamespacedName

    /// <summary>
    /// Class for the concrete RDF stream types in the taxonomy. Instances of this class have concrete definitions, and they can be used to annotate real streams.
    /// <see href="https://w3id.org/stax/ontology#ConcreteRdfStreamType"></see></summary>
    let ConcreteRdfStreamType =
        Namespaced_IRI.parse _namespace_name "ConcreteRdfStreamType" |> NamespacedName

    /// <summary>
    /// Class for base types of elements in RDF streams. There are four instances of this class (triple, quad, graph, dataset) and they should not be further specialized. The instances of this class do NOT form a taxonomical structure.
    /// <see href="https://w3id.org/stax/ontology#RdfElementType"></see></summary>
    let RdfElementType =
        Namespaced_IRI.parse _namespace_name "RdfElementType" |> NamespacedName

    /// <summary>
    /// For an RDF stream type, indicates the base (primitive) type of elements in the stream (e.g., triple, quad, graph, dataset).
    /// <see href="https://w3id.org/stax/ontology#hasElementType"></see></summary>
    let hasElementType =
        Namespaced_IRI.parse _namespace_name "hasElementType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#dataset"></see>
    /// </summary>
    let dataset = Namespaced_IRI.parse _namespace_name "dataset" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#graph"></see>
    /// </summary>
    let graph = Namespaced_IRI.parse _namespace_name "graph" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#quad"></see>
    /// </summary>
    let quad = Namespaced_IRI.parse _namespace_name "quad" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#triple"></see>
    /// </summary>
    let triple = Namespaced_IRI.parse _namespace_name "triple" |> NamespacedName

    /// <summary>
    /// Class for instances of using an RDF stream type, in a program, an academic paper, or elsewhere. This class is suitable for annotating both theoretical uses and practical ones, i.e., real streams or datasets.
    ///
    /// Instances of this class should have the stax:hasStreamType property pointing to a concrete stream type. The stax:usedIn property is recommended to indicate where the stream is used – alternatively you can use its inverse (stax:hasStreamTypeUsage). The use of other properties (e.g., rdfs:label, rdfs:comment) is encouraged to give more context about the usage.
    ///
    /// Note that "stream type usage" is a subjective assertion and instances of this class may be annotated with additional provenance properties to explain who made the assertion. There can be multiple views on what type of stream is in use, depending on the involved actor, processing step, etc.
    /// <see href="https://w3id.org/stax/ontology#RdfStreamTypeUsage"></see></summary>
    let RdfStreamTypeUsage =
        Namespaced_IRI.parse _namespace_name "RdfStreamTypeUsage" |> NamespacedName

    /// <summary>
    /// For an RDF stream type usage, this property indicates which stream type is used.
    /// <see href="https://w3id.org/stax/ontology#hasStreamType"></see></summary>
    let hasStreamType =
        Namespaced_IRI.parse _namespace_name "hasStreamType" |> NamespacedName

    /// <summary>
    /// Indicates that the subject stream type can be flattened into the object.
    ///
    /// The flattening is done by enumerating all components of the stream elements in one, flat stream. For example, a graph stream can be flattened into a flat triple stream.
    /// <see href="https://w3id.org/stax/ontology#canBeFlattenedInto"></see></summary>
    let canBeFlattenedInto =
        Namespaced_IRI.parse _namespace_name "canBeFlattenedInto" |> NamespacedName

    /// <summary>
    /// This property should not be used directly, but as a super-property for all properties denoting a relationship of meaning between RDF stream types.
    /// <see href="https://w3id.org/stax/ontology#streamTypeSemanticRelation"></see></summary>
    let streamTypeSemanticRelation =
        Namespaced_IRI.parse _namespace_name "streamTypeSemanticRelation" |> NamespacedName

    /// <summary>
    /// Indicates that the subject stream type can be grouped into the object.
    ///
    /// The grouping is done by splitting the flat stream of statements into groups, which then can be used to construct elements of the grouped stream. For example, a flat triple stream can be grouped into a graph stream. In this operation, the ordering information within a group is lost.
    /// <see href="https://w3id.org/stax/ontology#canBeGroupedInto"></see></summary>
    let canBeGroupedInto =
        Namespaced_IRI.parse _namespace_name "canBeGroupedInto" |> NamespacedName

    /// <summary>
    /// Indicates that the subject stream type that uses triples or graphs can be trivially extended into the object type that uses quads or datasets.
    ///
    /// The extension is done by (in case of flat RDF streams) adding a fourth component, corresponding to the default graph. In case of grouped RDF streams, the contents of the graph are placed explicitly in the default graph.
    /// <see href="https://w3id.org/stax/ontology#canBeTriviallyExtendedInto"></see></summary>
    let canBeTriviallyExtendedInto =
        Namespaced_IRI.parse _namespace_name "canBeTriviallyExtendedInto" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#datasetStream"></see>
    /// </summary>
    let datasetStream =
        Namespaced_IRI.parse _namespace_name "datasetStream" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#groupedStream"></see>
    /// </summary>
    let groupedStream =
        Namespaced_IRI.parse _namespace_name "groupedStream" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#namedGraphStream"></see>
    /// </summary>
    let namedGraphStream =
        Namespaced_IRI.parse _namespace_name "namedGraphStream" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#flatQuadStream"></see>
    /// </summary>
    let flatQuadStream =
        Namespaced_IRI.parse _namespace_name "flatQuadStream" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#flatStream"></see>
    /// </summary>
    let flatStream = Namespaced_IRI.parse _namespace_name "flatStream" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#flatTripleStream"></see>
    /// </summary>
    let flatTripleStream =
        Namespaced_IRI.parse _namespace_name "flatTripleStream" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#graphStream"></see>
    /// </summary>
    let graphStream =
        Namespaced_IRI.parse _namespace_name "graphStream" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#subjectGraphStream"></see>
    /// </summary>
    let subjectGraphStream =
        Namespaced_IRI.parse _namespace_name "subjectGraphStream" |> NamespacedName

    /// <summary>
    /// Inverse of stax:isUsageOf – indicates that the subject is related to a usage of an RDF stream type.
    ///
    /// The subject for this property can be for example a published stream on the Web (e.g., vocals:RDFStream) or a scientific publication that discusses a usage of an RDF stream type.
    /// <see href="https://w3id.org/stax/ontology#hasStreamTypeUsage"></see></summary>
    let hasStreamTypeUsage =
        Namespaced_IRI.parse _namespace_name "hasStreamTypeUsage" |> NamespacedName

    /// <summary>
    /// For an RDF stream type usage, this property indicates where the stream was used or from where the usage was derived. The value of this property can be anything that makes sense for the desired use case. The value can be for example: the DOI URL of an academic work, URL of a piece of software, IRI of a published stream, IRI of an RDF dataset.
    ///
    /// Inverse of stax:hasStreamTypeUsage.
    /// <see href="https://w3id.org/stax/ontology#isUsageOf"></see></summary>
    let isUsageOf = Namespaced_IRI.parse _namespace_name "isUsageOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#timestampedNamedGraphStream"></see>
    /// </summary>
    let timestampedNamedGraphStream =
        Namespaced_IRI.parse _namespace_name "timestampedNamedGraphStream" |> NamespacedName
