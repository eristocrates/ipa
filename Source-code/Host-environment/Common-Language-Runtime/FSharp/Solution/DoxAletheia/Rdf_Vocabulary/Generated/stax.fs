namespace https.w3id.org.stax.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module stax =
    let _namespace_iri = Namespace_Iri stax |> NamespaceIRI
    /// <summary>
    ///   <para>stax:hasStreamType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>For an RDF stream type usage, this property indicates which stream type is used.</para>
    /// labels<para>has stream type</para></remarks>
    /// <seealso href="https://w3id.org/stax/ontology#hasStreamType">https://w3id.org/stax/ontology#hasStreamType</seealso>
    let hasStreamType = Prefixed_Name(stax, "hasStreamType") |> PrefixedName
    /// <summary>
    ///   <para>stax:canBeFlattenedInto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the subject stream type can be flattened into the object.
    ///
    /// The flattening is done by enumerating all components of the stream elements in one, flat stream. For example, a graph stream can be flattened into a flat triple stream.</para>
    /// labels<para>can be flattened into</para></remarks>
    /// <seealso href="https://w3id.org/stax/ontology#canBeFlattenedInto">https://w3id.org/stax/ontology#canBeFlattenedInto</seealso>
    let canBeFlattenedInto = Prefixed_Name(stax, "canBeFlattenedInto") |> PrefixedName

    /// <summary>
    ///   <para>stax:streamTypeSemanticRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property should not be used directly, but as a super-property for all properties denoting a relationship of meaning between RDF stream types.</para>
    /// labels<para>is in stream type semantic relation with</para></remarks>
    /// <seealso href="https://w3id.org/stax/ontology#streamTypeSemanticRelation">https://w3id.org/stax/ontology#streamTypeSemanticRelation</seealso>
    let streamTypeSemanticRelation =
        Prefixed_Name(stax, "streamTypeSemanticRelation") |> PrefixedName

    /// <summary>
    ///   <para>stax:AbstractRdfStreamType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class for abstract RDF stream types in the taxonomy. Instances of this class have abstract definitions, i.e., they cannot be used to annotate real streams. They are only intended to be used for reasoning about stream types.</para>
    /// labels<para>Abstract RDF stream type</para></remarks>
    /// <seealso href="https://w3id.org/stax/ontology#AbstractRdfStreamType">https://w3id.org/stax/ontology#AbstractRdfStreamType</seealso>
    let AbstractRdfStreamType =
        Prefixed_Name(stax, "AbstractRdfStreamType") |> PrefixedName

    /// <summary>
    ///   <para>stax:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/stax/ontology#">https://w3id.org/stax/ontology#</seealso>
    let _prefix_iri = Prefixed_Name(stax, "") |> PrefixedName

    /// <summary>
    ///   <para>stax:ConcreteRdfStreamType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class for the concrete RDF stream types in the taxonomy. Instances of this class have concrete definitions, and they can be used to annotate real streams.</para>
    /// labels<para>Concrete RDF stream type</para></remarks>
    /// <seealso href="https://w3id.org/stax/ontology#ConcreteRdfStreamType">https://w3id.org/stax/ontology#ConcreteRdfStreamType</seealso>
    let ConcreteRdfStreamType =
        Prefixed_Name(stax, "ConcreteRdfStreamType") |> PrefixedName

    /// <summary>
    ///   <para>stax:RdfElementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class for base types of elements in RDF streams. There are four instances of this class (triple, quad, graph, dataset) and they should not be further specialized. The instances of this class do NOT form a taxonomical structure.</para>
    /// labels<para>RDF element type</para></remarks>
    /// <seealso href="https://w3id.org/stax/ontology#RdfElementType">https://w3id.org/stax/ontology#RdfElementType</seealso>
    let RdfElementType = Prefixed_Name(stax, "RdfElementType") |> PrefixedName
    /// <summary>
    ///   <para>stax:triple</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:stax/ontology#RdfElementType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/stax/ontology#triple">https://w3id.org/stax/ontology#triple</seealso>
    let triple = Prefixed_Name(stax, "triple") |> PrefixedName
    /// <summary>
    ///   <para>stax:RdfStreamTypeUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class for instances of using an RDF stream type, in a program, an academic paper, or elsewhere. This class is suitable for annotating both theoretical uses and practical ones, i.e., real streams or datasets.
    ///
    /// Instances of this class should have the stax:hasStreamType property pointing to a concrete stream type. The stax:usedIn property is recommended to indicate where the stream is used – alternatively you can use its inverse (stax:hasStreamTypeUsage). The use of other properties (e.g., rdfs:label, rdfs:comment) is encouraged to give more context about the usage.
    ///
    /// Note that "stream type usage" is a subjective assertion and instances of this class may be annotated with additional provenance properties to explain who made the assertion. There can be multiple views on what type of stream is in use, depending on the involved actor, processing step, etc.</para>
    /// labels<para>RDF stream type usage</para></remarks>
    /// <seealso href="https://w3id.org/stax/ontology#RdfStreamTypeUsage">https://w3id.org/stax/ontology#RdfStreamTypeUsage</seealso>
    let RdfStreamTypeUsage = Prefixed_Name(stax, "RdfStreamTypeUsage") |> PrefixedName
    /// <summary>
    ///   <para>stax:rdfStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:stax/ontology#AbstractRdfStreamType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/stax/ontology#rdfStream">https://w3id.org/stax/ontology#rdfStream</seealso>
    let rdfStream = Prefixed_Name(stax, "rdfStream") |> PrefixedName
    /// <summary>
    ///   <para>stax:RdfStreamType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Base class for RDF stream types. This class should not be used directly – use instead either stax:AbstractRdfStreamType or stax:ConcreteRdfStreamType.</para>
    /// labels<para>RDF stream type</para></remarks>
    /// <seealso href="https://w3id.org/stax/ontology#RdfStreamType">https://w3id.org/stax/ontology#RdfStreamType</seealso>
    let RdfStreamType = Prefixed_Name(stax, "RdfStreamType") |> PrefixedName
    /// <summary>
    ///   <para>stax:hasElementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>For an RDF stream type, indicates the base (primitive) type of elements in the stream (e.g., triple, quad, graph, dataset).</para>
    /// labels<para>has element type</para></remarks>
    /// <seealso href="https://w3id.org/stax/ontology#hasElementType">https://w3id.org/stax/ontology#hasElementType</seealso>
    let hasElementType = Prefixed_Name(stax, "hasElementType") |> PrefixedName
    /// <summary>
    ///   <para>stax:graph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:stax/ontology#RdfElementType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/stax/ontology#graph">https://w3id.org/stax/ontology#graph</seealso>
    let graph = Prefixed_Name(stax, "graph") |> PrefixedName
    /// <summary>
    ///   <para>stax:dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:stax/ontology#RdfElementType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/stax/ontology#dataset">https://w3id.org/stax/ontology#dataset</seealso>
    let dataset = Prefixed_Name(stax, "dataset") |> PrefixedName
    /// <summary>
    ///   <para>stax:quad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:stax/ontology#RdfElementType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/stax/ontology#quad">https://w3id.org/stax/ontology#quad</seealso>
    let quad = Prefixed_Name(stax, "quad") |> PrefixedName
    /// <summary>
    ///   <para>stax:canBeGroupedInto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the subject stream type can be grouped into the object.
    ///
    /// The grouping is done by splitting the flat stream of statements into groups, which then can be used to construct elements of the grouped stream. For example, a flat triple stream can be grouped into a graph stream. In this operation, the ordering information within a group is lost.</para>
    /// labels<para>can be grouped into</para></remarks>
    /// <seealso href="https://w3id.org/stax/ontology#canBeGroupedInto">https://w3id.org/stax/ontology#canBeGroupedInto</seealso>
    let canBeGroupedInto = Prefixed_Name(stax, "canBeGroupedInto") |> PrefixedName

    /// <summary>
    ///   <para>stax:canBeTriviallyExtendedInto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the subject stream type that uses triples or graphs can be trivially extended into the object type that uses quads or datasets.
    ///
    /// The extension is done by (in case of flat RDF streams) adding a fourth component, corresponding to the default graph. In case of grouped RDF streams, the contents of the graph are placed explicitly in the default graph.</para>
    /// labels<para>can be trivially extended into</para></remarks>
    /// <seealso href="https://w3id.org/stax/ontology#canBeTriviallyExtendedInto">https://w3id.org/stax/ontology#canBeTriviallyExtendedInto</seealso>
    let canBeTriviallyExtendedInto =
        Prefixed_Name(stax, "canBeTriviallyExtendedInto") |> PrefixedName

    /// <summary>
    ///   <para>stax:groupedStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:stax/ontology#AbstractRdfStreamType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/stax/ontology#groupedStream">https://w3id.org/stax/ontology#groupedStream</seealso>
    let groupedStream = Prefixed_Name(stax, "groupedStream") |> PrefixedName
    /// <summary>
    ///   <para>stax:flatQuadStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:stax/ontology#ConcreteRdfStreamType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/stax/ontology#flatQuadStream">https://w3id.org/stax/ontology#flatQuadStream</seealso>
    let flatQuadStream = Prefixed_Name(stax, "flatQuadStream") |> PrefixedName
    /// <summary>
    ///   <para>stax:flatTripleStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:stax/ontology#ConcreteRdfStreamType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/stax/ontology#flatTripleStream">https://w3id.org/stax/ontology#flatTripleStream</seealso>
    let flatTripleStream = Prefixed_Name(stax, "flatTripleStream") |> PrefixedName
    /// <summary>
    ///   <para>stax:subjectGraphStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:stax/ontology#ConcreteRdfStreamType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/stax/ontology#subjectGraphStream">https://w3id.org/stax/ontology#subjectGraphStream</seealso>
    let subjectGraphStream = Prefixed_Name(stax, "subjectGraphStream") |> PrefixedName
    /// <summary>
    ///   <para>stax:datasetStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:stax/ontology#ConcreteRdfStreamType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/stax/ontology#datasetStream">https://w3id.org/stax/ontology#datasetStream</seealso>
    let datasetStream = Prefixed_Name(stax, "datasetStream") |> PrefixedName
    /// <summary>
    ///   <para>stax:namedGraphStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:stax/ontology#ConcreteRdfStreamType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/stax/ontology#namedGraphStream">https://w3id.org/stax/ontology#namedGraphStream</seealso>
    let namedGraphStream = Prefixed_Name(stax, "namedGraphStream") |> PrefixedName
    /// <summary>
    ///   <para>stax:flatStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:stax/ontology#AbstractRdfStreamType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/stax/ontology#flatStream">https://w3id.org/stax/ontology#flatStream</seealso>
    let flatStream = Prefixed_Name(stax, "flatStream") |> PrefixedName
    /// <summary>
    ///   <para>stax:graphStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:stax/ontology#ConcreteRdfStreamType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/stax/ontology#graphStream">https://w3id.org/stax/ontology#graphStream</seealso>
    let graphStream = Prefixed_Name(stax, "graphStream") |> PrefixedName
    /// <summary>
    ///   <para>stax:hasStreamTypeUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse of stax:isUsageOf – indicates that the subject is related to a usage of an RDF stream type.
    ///
    /// The subject for this property can be for example a published stream on the Web (e.g., vocals:RDFStream) or a scientific publication that discusses a usage of an RDF stream type.</para>
    /// labels<para>has stream type usage</para></remarks>
    /// <seealso href="https://w3id.org/stax/ontology#hasStreamTypeUsage">https://w3id.org/stax/ontology#hasStreamTypeUsage</seealso>
    let hasStreamTypeUsage = Prefixed_Name(stax, "hasStreamTypeUsage") |> PrefixedName
    /// <summary>
    ///   <para>stax:isUsageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>For an RDF stream type usage, this property indicates where the stream was used or from where the usage was derived. The value of this property can be anything that makes sense for the desired use case. The value can be for example: the DOI URL of an academic work, URL of a piece of software, IRI of a published stream, IRI of an RDF dataset.
    ///
    /// Inverse of stax:hasStreamTypeUsage.</para>
    /// labels<para>is usage of</para></remarks>
    /// <seealso href="https://w3id.org/stax/ontology#isUsageOf">https://w3id.org/stax/ontology#isUsageOf</seealso>
    let isUsageOf = Prefixed_Name(stax, "isUsageOf") |> PrefixedName

    /// <summary>
    ///   <para>stax:timestampedNamedGraphStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:stax/ontology#ConcreteRdfStreamType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/stax/ontology#timestampedNamedGraphStream">https://w3id.org/stax/ontology#timestampedNamedGraphStream</seealso>
    let timestampedNamedGraphStream =
        Prefixed_Name(stax, "timestampedNamedGraphStream") |> PrefixedName
