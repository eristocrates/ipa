namespace https.w3id.org.stax.ontology.hash

open DoxAletheia

module stax =
    let _namespace_name = "https://w3id.org/stax/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#rdfStream"></see>
    /// </summary>
    let rdfStream = _prefix "rdfStream"
    /// <summary>
    /// Class for abstract RDF stream types in the taxonomy. Instances of this class have abstract definitions, i.e., they cannot be used to annotate real streams. They are only intended to be used for reasoning about stream types.
    /// <see href="https://w3id.org/stax/ontology#AbstractRdfStreamType"></see></summary>
    let AbstractRdfStreamType = _prefix "AbstractRdfStreamType"
    /// <summary>
    /// Base class for RDF stream types. This class should not be used directly – use instead either stax:AbstractRdfStreamType or stax:ConcreteRdfStreamType.
    /// <see href="https://w3id.org/stax/ontology#RdfStreamType"></see></summary>
    let RdfStreamType = _prefix "RdfStreamType"
    /// <summary>
    /// Class for the concrete RDF stream types in the taxonomy. Instances of this class have concrete definitions, and they can be used to annotate real streams.
    /// <see href="https://w3id.org/stax/ontology#ConcreteRdfStreamType"></see></summary>
    let ConcreteRdfStreamType = _prefix "ConcreteRdfStreamType"
    /// <summary>
    /// Class for base types of elements in RDF streams. There are four instances of this class (triple, quad, graph, dataset) and they should not be further specialized. The instances of this class do NOT form a taxonomical structure.
    /// <see href="https://w3id.org/stax/ontology#RdfElementType"></see></summary>
    let RdfElementType = _prefix "RdfElementType"
    /// <summary>
    /// For an RDF stream type, indicates the base (primitive) type of elements in the stream (e.g., triple, quad, graph, dataset).
    /// <see href="https://w3id.org/stax/ontology#hasElementType"></see></summary>
    let hasElementType = _prefix "hasElementType"
    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#dataset"></see>
    /// </summary>
    let dataset = _prefix "dataset"
    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#graph"></see>
    /// </summary>
    let graph = _prefix "graph"
    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#quad"></see>
    /// </summary>
    let quad = _prefix "quad"
    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#triple"></see>
    /// </summary>
    let triple = _prefix "triple"
    /// <summary>
    /// Class for instances of using an RDF stream type, in a program, an academic paper, or elsewhere. This class is suitable for annotating both theoretical uses and practical ones, i.e., real streams or datasets.
    ///
    /// Instances of this class should have the stax:hasStreamType property pointing to a concrete stream type. The stax:usedIn property is recommended to indicate where the stream is used – alternatively you can use its inverse (stax:hasStreamTypeUsage). The use of other properties (e.g., rdfs:label, rdfs:comment) is encouraged to give more context about the usage.
    ///
    /// Note that "stream type usage" is a subjective assertion and instances of this class may be annotated with additional provenance properties to explain who made the assertion. There can be multiple views on what type of stream is in use, depending on the involved actor, processing step, etc.
    /// <see href="https://w3id.org/stax/ontology#RdfStreamTypeUsage"></see></summary>
    let RdfStreamTypeUsage = _prefix "RdfStreamTypeUsage"
    /// <summary>
    /// For an RDF stream type usage, this property indicates which stream type is used.
    /// <see href="https://w3id.org/stax/ontology#hasStreamType"></see></summary>
    let hasStreamType = _prefix "hasStreamType"
    /// <summary>
    /// Indicates that the subject stream type can be flattened into the object.
    ///
    /// The flattening is done by enumerating all components of the stream elements in one, flat stream. For example, a graph stream can be flattened into a flat triple stream.
    /// <see href="https://w3id.org/stax/ontology#canBeFlattenedInto"></see></summary>
    let canBeFlattenedInto = _prefix "canBeFlattenedInto"
    /// <summary>
    /// This property should not be used directly, but as a super-property for all properties denoting a relationship of meaning between RDF stream types.
    /// <see href="https://w3id.org/stax/ontology#streamTypeSemanticRelation"></see></summary>
    let streamTypeSemanticRelation = _prefix "streamTypeSemanticRelation"
    /// <summary>
    /// Indicates that the subject stream type can be grouped into the object.
    ///
    /// The grouping is done by splitting the flat stream of statements into groups, which then can be used to construct elements of the grouped stream. For example, a flat triple stream can be grouped into a graph stream. In this operation, the ordering information within a group is lost.
    /// <see href="https://w3id.org/stax/ontology#canBeGroupedInto"></see></summary>
    let canBeGroupedInto = _prefix "canBeGroupedInto"
    /// <summary>
    /// Indicates that the subject stream type that uses triples or graphs can be trivially extended into the object type that uses quads or datasets.
    ///
    /// The extension is done by (in case of flat RDF streams) adding a fourth component, corresponding to the default graph. In case of grouped RDF streams, the contents of the graph are placed explicitly in the default graph.
    /// <see href="https://w3id.org/stax/ontology#canBeTriviallyExtendedInto"></see></summary>
    let canBeTriviallyExtendedInto = _prefix "canBeTriviallyExtendedInto"
    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#datasetStream"></see>
    /// </summary>
    let datasetStream = _prefix "datasetStream"
    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#groupedStream"></see>
    /// </summary>
    let groupedStream = _prefix "groupedStream"
    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#namedGraphStream"></see>
    /// </summary>
    let namedGraphStream = _prefix "namedGraphStream"
    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#flatQuadStream"></see>
    /// </summary>
    let flatQuadStream = _prefix "flatQuadStream"
    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#flatStream"></see>
    /// </summary>
    let flatStream = _prefix "flatStream"
    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#flatTripleStream"></see>
    /// </summary>
    let flatTripleStream = _prefix "flatTripleStream"
    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#graphStream"></see>
    /// </summary>
    let graphStream = _prefix "graphStream"
    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#subjectGraphStream"></see>
    /// </summary>
    let subjectGraphStream = _prefix "subjectGraphStream"
    /// <summary>
    /// Inverse of stax:isUsageOf – indicates that the subject is related to a usage of an RDF stream type.
    ///
    /// The subject for this property can be for example a published stream on the Web (e.g., vocals:RDFStream) or a scientific publication that discusses a usage of an RDF stream type.
    /// <see href="https://w3id.org/stax/ontology#hasStreamTypeUsage"></see></summary>
    let hasStreamTypeUsage = _prefix "hasStreamTypeUsage"
    /// <summary>
    /// For an RDF stream type usage, this property indicates where the stream was used or from where the usage was derived. The value of this property can be anything that makes sense for the desired use case. The value can be for example: the DOI URL of an academic work, URL of a piece of software, IRI of a published stream, IRI of an RDF dataset.
    ///
    /// Inverse of stax:hasStreamTypeUsage.
    /// <see href="https://w3id.org/stax/ontology#isUsageOf"></see></summary>
    let isUsageOf = _prefix "isUsageOf"
    /// <summary>
    ///   <see href="https://w3id.org/stax/ontology#timestampedNamedGraphStream"></see>
    /// </summary>
    let timestampedNamedGraphStream = _prefix "timestampedNamedGraphStream"
