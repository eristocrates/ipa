namespace https.w3id.org.riverbench.schema.metadata.hash

open DoxAletheia.Rdf_Vocabulary

module rb =
    let _namespace_name = "https://w3id.org/riverbench/schema/metadata#"

    /// <summary>
    /// Statistics about the number of blank nodes in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#BlankNodeCountStatistics"></see></summary>
    let BlankNodeCountStatistics =
        Namespaced_IRI.parse _namespace_name "BlankNodeCountStatistics" |> NamespacedName

    /// <summary>
    /// Class for statistics objects about distributions
    /// <see href="https://w3id.org/riverbench/schema/metadata#Statistics"></see></summary>
    let Statistics = Namespaced_IRI.parse _namespace_name "Statistics" |> NamespacedName
    /// <summary>
    /// A dataset in the RiverBench benchmark suite
    /// <see href="https://w3id.org/riverbench/schema/metadata#Dataset"></see></summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName

    /// <summary>
    /// Statistics about the number of datatype literals (NOT of type rdf:langString) in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#DatatypeLiteralCountStatistics"></see></summary>
    let DatatypeLiteralCountStatistics =
        Namespaced_IRI.parse _namespace_name "DatatypeLiteralCountStatistics" |> NamespacedName

    /// <summary>
    /// A distribution of a dataset in the RiverBench benchmark suite.
    /// <see href="https://w3id.org/riverbench/schema/metadata#Distribution"></see></summary>
    let Distribution =
        Namespaced_IRI.parse _namespace_name "Distribution" |> NamespacedName

    /// <summary>
    /// Type of dataset distribution, indicating the corresponding streaming task formulation.
    /// <see href="https://w3id.org/riverbench/schema/metadata#DistributionType"></see></summary>
    let DistributionType =
        Namespaced_IRI.parse _namespace_name "DistributionType" |> NamespacedName

    /// <summary>
    /// Statistics about the number of RDF graphs in the dataset, including the default graph.
    /// <see href="https://w3id.org/riverbench/schema/metadata#GraphCountStatistics"></see></summary>
    let GraphCountStatistics =
        Namespaced_IRI.parse _namespace_name "GraphCountStatistics" |> NamespacedName

    /// <summary>
    /// Statistics about the number of IRIs in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#IriCountStatistics"></see></summary>
    let IriCountStatistics =
        Namespaced_IRI.parse _namespace_name "IriCountStatistics" |> NamespacedName

    /// <summary>
    /// Statistics about the number of language literals in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#LanguageLiteralCountStatistics"></see></summary>
    let LanguageLiteralCountStatistics =
        Namespaced_IRI.parse _namespace_name "LanguageLiteralCountStatistics" |> NamespacedName

    /// <summary>
    /// Statistics about the number of literals in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#LiteralCountStatistics"></see></summary>
    let LiteralCountStatistics =
        Namespaced_IRI.parse _namespace_name "LiteralCountStatistics" |> NamespacedName

    /// <summary>
    /// Statistics about the number of objects in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#ObjectCountStatistics"></see></summary>
    let ObjectCountStatistics =
        Namespaced_IRI.parse _namespace_name "ObjectCountStatistics" |> NamespacedName

    /// <summary>
    /// Statistics about the number of predicates in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#PredicateCountStatistics"></see></summary>
    let PredicateCountStatistics =
        Namespaced_IRI.parse _namespace_name "PredicateCountStatistics" |> NamespacedName

    /// <summary>
    /// Benchmark profile grouping several datasets in RiverBench
    /// <see href="https://w3id.org/riverbench/schema/metadata#Profile"></see></summary>
    let Profile = Namespaced_IRI.parse _namespace_name "Profile" |> NamespacedName

    /// <summary>
    /// Resource with properties that specify conditions for datasets to be included in the profile. The conditions are joined with the OR operator.
    /// <see href="https://w3id.org/riverbench/schema/metadata#ProfileRestriction"></see></summary>
    let ProfileRestriction =
        Namespaced_IRI.parse _namespace_name "ProfileRestriction" |> NamespacedName

    /// <summary>
    /// Statistics about the number of quoted triples in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#QuotedTripleCountStatistics"></see></summary>
    let QuotedTripleCountStatistics =
        Namespaced_IRI.parse _namespace_name "QuotedTripleCountStatistics" |> NamespacedName

    /// <summary>
    /// RiverBench – RDF streaming benchmark suite
    /// <see href="https://w3id.org/riverbench/schema/metadata#RiverBench"></see></summary>
    let RiverBench = Namespaced_IRI.parse _namespace_name "RiverBench" |> NamespacedName

    /// <summary>
    /// Statistics about the number of simple literals (of type xsd:string) in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#SimpleLiteralCountStatistics"></see></summary>
    let SimpleLiteralCountStatistics =
        Namespaced_IRI.parse _namespace_name "SimpleLiteralCountStatistics" |> NamespacedName

    /// <summary>
    /// Statistics about the number of RDF statements in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#StatementCountStatistics"></see></summary>
    let StatementCountStatistics =
        Namespaced_IRI.parse _namespace_name "StatementCountStatistics" |> NamespacedName

    /// <summary>
    /// The number of statements in an element was the criterion for splitting the stream elements.
    /// <see href="https://w3id.org/riverbench/schema/metadata#StatementCountStreamElementSplit"></see></summary>
    let StatementCountStreamElementSplit =
        Namespaced_IRI.parse _namespace_name "StatementCountStreamElementSplit" |> NamespacedName

    /// <summary>
    /// Describes how was the stream split into individual elements.
    /// <see href="https://w3id.org/riverbench/schema/metadata#StreamElementSplit"></see></summary>
    let StreamElementSplit =
        Namespaced_IRI.parse _namespace_name "StreamElementSplit" |> NamespacedName

    /// <summary>
    /// Indicates the type of the contents of stream elements
    /// <see href="https://w3id.org/riverbench/schema/metadata#StreamElementType"></see></summary>
    let StreamElementType =
        Namespaced_IRI.parse _namespace_name "StreamElementType" |> NamespacedName

    /// <summary>
    /// Statistics about the number of subjects in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#SubjectCountStatistics"></see></summary>
    let SubjectCountStatistics =
        Namespaced_IRI.parse _namespace_name "SubjectCountStatistics" |> NamespacedName

    /// <summary>
    /// The elements correspond to different instants or intervals of time.
    /// <see href="https://w3id.org/riverbench/schema/metadata#TimeStreamElementSplit"></see></summary>
    let TimeStreamElementSplit =
        Namespaced_IRI.parse _namespace_name "TimeStreamElementSplit" |> NamespacedName

    /// <summary>
    /// The elements correspond to different topics/subjects in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#TopicStreamElementSplit"></see></summary>
    let TopicStreamElementSplit =
        Namespaced_IRI.parse _namespace_name "TopicStreamElementSplit" |> NamespacedName

    /// <summary>
    /// Base property for all conformance data properties
    /// <see href="https://w3id.org/riverbench/schema/metadata#conformanceProperty"></see></summary>
    let conformanceProperty =
        Namespaced_IRI.parse _namespace_name "conformanceProperty" |> NamespacedName

    /// <summary>
    /// Whether the dataset is RDF 1.1-compliant, i.e., does not use any non-standard features, like generalized triples.
    /// <see href="https://w3id.org/riverbench/schema/metadata#conformsToRdf11"></see></summary>
    let conformsToRdf11 =
        Namespaced_IRI.parse _namespace_name "conformsToRdf11" |> NamespacedName

    /// <summary>
    /// Whether the dataset is RDF-star compliant, i.e., does not use any non-standard features. Note that all standard RDF 1.1 datasets also qualify, as RDF-star is a superset of RDF 1.1.
    /// <see href="https://w3id.org/riverbench/schema/metadata#conformsToRdfStarDraft_20211217"></see></summary>
    let conformsToRdfStarDraft_20211217 =
        Namespaced_IRI.parse _namespace_name "conformsToRdfStarDraft_20211217" |> NamespacedName

    /// <summary>
    /// The dataset is distributed as a single flat file.
    /// <see href="https://w3id.org/riverbench/schema/metadata#flatDistribution"></see></summary>
    let flatDistribution =
        Namespaced_IRI.parse _namespace_name "flatDistribution" |> NamespacedName

    /// <summary>
    /// A full distribution, including all data in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#fullDistribution"></see></summary>
    let fullDistribution =
        Namespaced_IRI.parse _namespace_name "fullDistribution" |> NamespacedName

    /// <summary>
    /// The dataset is distributed as a stream of named RDF graphs.
    /// <see href="https://w3id.org/riverbench/schema/metadata#graphStreamDistribution"></see></summary>
    let graphStreamDistribution =
        Namespaced_IRI.parse _namespace_name "graphStreamDistribution" |> NamespacedName

    /// <summary>
    /// Graph streams are a special case of quad streams, where each element contains exactly one named RDF graph.
    /// <see href="https://w3id.org/riverbench/schema/metadata#graphs"></see></summary>
    let graphs = Namespaced_IRI.parse _namespace_name "graphs" |> NamespacedName

    /// <summary>
    /// Indicates the type of RiverBench dataset distribution
    /// <see href="https://w3id.org/riverbench/schema/metadata#hasDistributionType"></see></summary>
    let hasDistributionType =
        Namespaced_IRI.parse _namespace_name "hasDistributionType" |> NamespacedName

    /// <summary>
    /// Canonical file name of this distribution
    /// <see href="https://w3id.org/riverbench/schema/metadata#hasFileName"></see></summary>
    let hasFileName =
        Namespaced_IRI.parse _namespace_name "hasFileName" |> NamespacedName

    /// <summary>
    /// Indicates benchmark profiles that belong to this benchmark suite.
    /// <see href="https://w3id.org/riverbench/schema/metadata#hasProfile"></see></summary>
    let hasProfile = Namespaced_IRI.parse _namespace_name "hasProfile" |> NamespacedName

    /// <summary>
    /// Has profile restriction. The restrictions are joined with the AND operator.
    /// <see href="https://w3id.org/riverbench/schema/metadata#hasRestriction"></see></summary>
    let hasRestriction =
        Namespaced_IRI.parse _namespace_name "hasRestriction" |> NamespacedName

    /// <summary>
    /// Has a dataset statistics object
    /// <see href="https://w3id.org/riverbench/schema/metadata#hasStatistics"></see></summary>
    let hasStatistics =
        Namespaced_IRI.parse _namespace_name "hasStatistics" |> NamespacedName

    /// <summary>
    /// Number of elements in the stream
    /// <see href="https://w3id.org/riverbench/schema/metadata#hasStreamElementCount"></see></summary>
    let hasStreamElementCount =
        Namespaced_IRI.parse _namespace_name "hasStreamElementCount" |> NamespacedName

    /// <summary>
    /// Indicates how the stream was split into elements.
    /// <see href="https://w3id.org/riverbench/schema/metadata#hasStreamElementSplit"></see></summary>
    let hasStreamElementSplit =
        Namespaced_IRI.parse _namespace_name "hasStreamElementSplit" |> NamespacedName

    /// <summary>
    /// Indicates the type of contents of each stream element
    /// <see href="https://w3id.org/riverbench/schema/metadata#hasStreamElementType"></see></summary>
    let hasStreamElementType =
        Namespaced_IRI.parse _namespace_name "hasStreamElementType" |> NamespacedName

    /// <summary>
    /// The IRI of the property that is used in the stream to denote time at which the event occured.
    /// <see href="https://w3id.org/riverbench/schema/metadata#hasTemporalProperty"></see></summary>
    let hasTemporalProperty =
        Namespaced_IRI.parse _namespace_name "hasTemporalProperty" |> NamespacedName

    /// <summary>
    /// Version tag of an artifact
    /// <see href="https://w3id.org/riverbench/schema/metadata#hasVersion"></see></summary>
    let hasVersion = Namespaced_IRI.parse _namespace_name "hasVersion" |> NamespacedName

    /// <summary>
    /// Indicates that this profile's datasets are all in the other profile
    /// <see href="https://w3id.org/riverbench/schema/metadata#isSubsetOfProfile"></see></summary>
    let isSubsetOfProfile =
        Namespaced_IRI.parse _namespace_name "isSubsetOfProfile" |> NamespacedName

    /// <summary>
    /// Indicates that this profile contains all datasets of the other profile
    /// <see href="https://w3id.org/riverbench/schema/metadata#isSupersetOfProfile"></see></summary>
    let isSupersetOfProfile =
        Namespaced_IRI.parse _namespace_name "isSupersetOfProfile" |> NamespacedName

    /// <summary>
    /// Maximum value of a distribution
    /// <see href="https://w3id.org/riverbench/schema/metadata#maximum"></see></summary>
    let maximum = Namespaced_IRI.parse _namespace_name "maximum" |> NamespacedName

    /// <summary>
    /// The base statistical property.
    /// <see href="https://w3id.org/riverbench/schema/metadata#statisticalProperty"></see></summary>
    let statisticalProperty =
        Namespaced_IRI.parse _namespace_name "statisticalProperty" |> NamespacedName

    /// <summary>
    /// Arithmetic mean of a distribution
    /// <see href="https://w3id.org/riverbench/schema/metadata#mean"></see></summary>
    let mean = Namespaced_IRI.parse _namespace_name "mean" |> NamespacedName
    /// <summary>
    /// Minimum value of a distribution
    /// <see href="https://w3id.org/riverbench/schema/metadata#minimum"></see></summary>
    let minimum = Namespaced_IRI.parse _namespace_name "minimum" |> NamespacedName

    /// <summary>
    /// A partial distribution, including only a subset of the data in the dataset. The rb:hasStreamElementCount property indicates the length of this distribution.
    /// <see href="https://w3id.org/riverbench/schema/metadata#partialDistribution"></see></summary>
    let partialDistribution =
        Namespaced_IRI.parse _namespace_name "partialDistribution" |> NamespacedName

    /// <summary>
    /// The dataset is distributed as a stream of RDF quads.
    /// <see href="https://w3id.org/riverbench/schema/metadata#quadStreamDistribution"></see></summary>
    let quadStreamDistribution =
        Namespaced_IRI.parse _namespace_name "quadStreamDistribution" |> NamespacedName

    /// <summary>
    /// Quad streams consist of elements, where each element is an RDF dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#quads"></see></summary>
    let quads = Namespaced_IRI.parse _namespace_name "quads" |> NamespacedName

    /// <summary>
    /// Standard deviation of a distribution
    /// <see href="https://w3id.org/riverbench/schema/metadata#standardDeviation"></see></summary>
    let standardDeviation =
        Namespaced_IRI.parse _namespace_name "standardDeviation" |> NamespacedName

    /// <summary>
    /// Sum of all values in the distribution. In statistics about counts, this corresponds to the total number of given elements in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#sum"></see></summary>
    let sum = Namespaced_IRI.parse _namespace_name "sum" |> NamespacedName

    /// <summary>
    /// The dataset is distributed as a stream of RDF triples.
    /// <see href="https://w3id.org/riverbench/schema/metadata#tripleStreamDistribution"></see></summary>
    let tripleStreamDistribution =
        Namespaced_IRI.parse _namespace_name "tripleStreamDistribution" |> NamespacedName

    /// <summary>
    /// Triple streams consist of elements, where each element is an RDF graph.
    /// <see href="https://w3id.org/riverbench/schema/metadata#triples"></see></summary>
    let triples = Namespaced_IRI.parse _namespace_name "triples" |> NamespacedName

    /// <summary>
    /// Only used for count statistics. Indicates how many unique elements are in the entire dataset. The value is estimated with a Bloom filter and is accurate to ~1%.
    /// <see href="https://w3id.org/riverbench/schema/metadata#uniqueCount"></see></summary>
    let uniqueCount =
        Namespaced_IRI.parse _namespace_name "uniqueCount" |> NamespacedName

    /// <summary>
    /// Whether the dataset uses the non-standard generalized datasets feature. A "dataset" here is used in the same meaning as in the RDF 1.1 specification.
    /// <see href="https://w3id.org/riverbench/schema/metadata#usesGeneralizedRdfDatasets"></see></summary>
    let usesGeneralizedRdfDatasets =
        Namespaced_IRI.parse _namespace_name "usesGeneralizedRdfDatasets" |> NamespacedName

    /// <summary>
    /// Whether the dataset uses the non-standard generalized triples feature
    /// <see href="https://w3id.org/riverbench/schema/metadata#usesGeneralizedTriples"></see></summary>
    let usesGeneralizedTriples =
        Namespaced_IRI.parse _namespace_name "usesGeneralizedTriples" |> NamespacedName

    /// <summary>
    /// Indicates that the dataset uses an ontology. The object must be a resource, but it doesn't neccesarily have to be an OWL ontology.
    /// <see href="https://w3id.org/riverbench/schema/metadata#usesOntology"></see></summary>
    let usesOntology =
        Namespaced_IRI.parse _namespace_name "usesOntology" |> NamespacedName

    /// <summary>
    /// Whether the dataset uses RDF-star features.
    /// <see href="https://w3id.org/riverbench/schema/metadata#usesRdfStar"></see></summary>
    let usesRdfStar =
        Namespaced_IRI.parse _namespace_name "usesRdfStar" |> NamespacedName
