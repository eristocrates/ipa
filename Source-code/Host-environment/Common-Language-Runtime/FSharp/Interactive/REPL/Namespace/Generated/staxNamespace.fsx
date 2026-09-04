#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module stax =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/stax/ontology#" "stax"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Abstract RDF stream type</para>
    ///   <para>rdfs:comment : Class for abstract RDF stream types in the taxonomy. Instances of this class have abstract definitions, i.e., they cannot be used to annotate real streams. They are only intended to be used for reasoning about stream types.</para>
    ///   <a href="https://w3id.org/stax/ontology#AbstractRdfStreamType">stax:AbstractRdfStreamType</a>
    /// </summary>
    let AbstractRdfStreamType = _prefixId.prefix "AbstractRdfStreamType"
    /// <summary>
    ///   <para>rdfs:label : Concrete RDF stream type</para>
    ///   <para>rdfs:comment : Class for the concrete RDF stream types in the taxonomy. Instances of this class have concrete definitions, and they can be used to annotate real streams.</para>
    ///   <a href="https://w3id.org/stax/ontology#ConcreteRdfStreamType">stax:ConcreteRdfStreamType</a>
    /// </summary>
    let ConcreteRdfStreamType = _prefixId.prefix "ConcreteRdfStreamType"
    /// <summary>
    ///   <para>rdfs:label : RDF element type</para>
    ///   <para>rdfs:comment : Class for base types of elements in RDF streams. There are four instances of this class (triple, quad, graph, dataset) and they should not be further specialized. The instances of this class do NOT form a taxonomical structure.</para>
    ///   <a href="https://w3id.org/stax/ontology#RdfElementType">stax:RdfElementType</a>
    /// </summary>
    let RdfElementType = _prefixId.prefix "RdfElementType"
    /// <summary>
    ///   <para>rdfs:label : RDF stream type</para>
    ///   <para>rdfs:comment : Base class for RDF stream types. This class should not be used directly – use instead either stax:AbstractRdfStreamType or stax:ConcreteRdfStreamType.</para>
    ///   <a href="https://w3id.org/stax/ontology#RdfStreamType">stax:RdfStreamType</a>
    /// </summary>
    let RdfStreamType = _prefixId.prefix "RdfStreamType"
    /// <summary>
    ///   <para>rdfs:label : RDF stream type usage</para>
    ///   <para>rdfs:comment : Class for instances of using an RDF stream type, in a program, an academic paper, or elsewhere. This class is suitable for annotating both theoretical uses and practical ones, i.e., real streams or datasets.
    ///
    /// Instances of this class should have the stax:hasStreamType property pointing to a concrete stream type. The stax:usedIn property is recommended to indicate where the stream is used – alternatively you can use its inverse (stax:hasStreamTypeUsage). The use of other properties (e.g., rdfs:label, rdfs:comment) is encouraged to give more context about the usage.
    ///
    /// Note that "stream type usage" is a subjective assertion and instances of this class may be annotated with additional provenance properties to explain who made the assertion. There can be multiple views on what type of stream is in use, depending on the involved actor, processing step, etc.</para>
    ///   <a href="https://w3id.org/stax/ontology#RdfStreamTypeUsage">stax:RdfStreamTypeUsage</a>
    /// </summary>
    let RdfStreamTypeUsage = _prefixId.prefix "RdfStreamTypeUsage"
    /// <summary>
    ///   <para>rdfs:label : can be flattened into</para>
    ///   <para>rdfs:comment : Indicates that the subject stream type can be flattened into the object.
    ///
    /// The flattening is done by enumerating all components of the stream elements in one, flat stream. For example, a graph stream can be flattened into a flat triple stream.</para>
    ///   <a href="https://w3id.org/stax/ontology#canBeFlattenedInto">stax:canBeFlattenedInto</a>
    /// </summary>
    let canBeFlattenedInto = _prefixId.prefix "canBeFlattenedInto"
    /// <summary>
    ///   <para>rdfs:label : can be grouped into</para>
    ///   <para>rdfs:comment : Indicates that the subject stream type can be grouped into the object.
    ///
    /// The grouping is done by splitting the flat stream of statements into groups, which then can be used to construct elements of the grouped stream. For example, a flat triple stream can be grouped into a graph stream. In this operation, the ordering information within a group is lost.</para>
    ///   <a href="https://w3id.org/stax/ontology#canBeGroupedInto">stax:canBeGroupedInto</a>
    /// </summary>
    let canBeGroupedInto = _prefixId.prefix "canBeGroupedInto"
    /// <summary>
    ///   <para>rdfs:label : can be trivially extended into</para>
    ///   <para>rdfs:comment : Indicates that the subject stream type that uses triples or graphs can be trivially extended into the object type that uses quads or datasets.
    ///
    /// The extension is done by (in case of flat RDF streams) adding a fourth component, corresponding to the default graph. In case of grouped RDF streams, the contents of the graph are placed explicitly in the default graph.</para>
    ///   <a href="https://w3id.org/stax/ontology#canBeTriviallyExtendedInto">stax:canBeTriviallyExtendedInto</a>
    /// </summary>
    let canBeTriviallyExtendedInto = _prefixId.prefix "canBeTriviallyExtendedInto"
    let dataset = _prefixId.prefix "dataset"
    let datasetStream = _prefixId.prefix "datasetStream"
    let flatQuadStream = _prefixId.prefix "flatQuadStream"
    let flatStream = _prefixId.prefix "flatStream"
    let flatTripleStream = _prefixId.prefix "flatTripleStream"
    let graph = _prefixId.prefix "graph"
    let graphStream = _prefixId.prefix "graphStream"
    let groupedStream = _prefixId.prefix "groupedStream"
    /// <summary>
    ///   <para>rdfs:label : has element type</para>
    ///   <para>rdfs:comment : For an RDF stream type, indicates the base (primitive) type of elements in the stream (e.g., triple, quad, graph, dataset).</para>
    ///   <a href="https://w3id.org/stax/ontology#hasElementType">stax:hasElementType</a>
    /// </summary>
    let hasElementType = _prefixId.prefix "hasElementType"
    /// <summary>
    ///   <para>rdfs:label : has stream type</para>
    ///   <para>rdfs:comment : For an RDF stream type usage, this property indicates which stream type is used.</para>
    ///   <a href="https://w3id.org/stax/ontology#hasStreamType">stax:hasStreamType</a>
    /// </summary>
    let hasStreamType = _prefixId.prefix "hasStreamType"
    /// <summary>
    ///   <para>rdfs:label : has stream type usage</para>
    ///   <para>rdfs:comment : Inverse of stax:isUsageOf – indicates that the subject is related to a usage of an RDF stream type.
    ///
    /// The subject for this property can be for example a published stream on the Web (e.g., vocals:RDFStream) or a scientific publication that discusses a usage of an RDF stream type.</para>
    ///   <a href="https://w3id.org/stax/ontology#hasStreamTypeUsage">stax:hasStreamTypeUsage</a>
    /// </summary>
    let hasStreamTypeUsage = _prefixId.prefix "hasStreamTypeUsage"
    /// <summary>
    ///   <para>rdfs:label : is usage of</para>
    ///   <para>rdfs:comment : For an RDF stream type usage, this property indicates where the stream was used or from where the usage was derived. The value of this property can be anything that makes sense for the desired use case. The value can be for example: the DOI URL of an academic work, URL of a piece of software, IRI of a published stream, IRI of an RDF dataset.
    ///
    /// Inverse of stax:hasStreamTypeUsage.</para>
    ///   <a href="https://w3id.org/stax/ontology#isUsageOf">stax:isUsageOf</a>
    /// </summary>
    let isUsageOf = _prefixId.prefix "isUsageOf"
    let namedGraphStream = _prefixId.prefix "namedGraphStream"
    let quad = _prefixId.prefix "quad"
    let rdfStream = _prefixId.prefix "rdfStream"
    /// <summary>
    ///   <para>rdfs:label : is in stream type semantic relation with</para>
    ///   <para>rdfs:comment : This property should not be used directly, but as a super-property for all properties denoting a relationship of meaning between RDF stream types.</para>
    ///   <a href="https://w3id.org/stax/ontology#streamTypeSemanticRelation">stax:streamTypeSemanticRelation</a>
    /// </summary>
    let streamTypeSemanticRelation = _prefixId.prefix "streamTypeSemanticRelation"
    let subjectGraphStream = _prefixId.prefix "subjectGraphStream"
    let timestampedNamedGraphStream = _prefixId.prefix "timestampedNamedGraphStream"
    let triple = _prefixId.prefix "triple"
