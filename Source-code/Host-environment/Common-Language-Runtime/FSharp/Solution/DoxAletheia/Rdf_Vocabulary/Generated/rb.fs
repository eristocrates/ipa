namespace https.w3id.org.riverbench.schema.metadata.hash

open DoxAletheia

module rb =
    let _namespace_name = "https://w3id.org/riverbench/schema/metadata#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Statistics about the number of blank nodes in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#BlankNodeCountStatistics"></see></summary>
    let BlankNodeCountStatistics = _prefix "BlankNodeCountStatistics"
    /// <summary>
    /// Class for statistics objects about distributions
    /// <see href="https://w3id.org/riverbench/schema/metadata#Statistics"></see></summary>
    let Statistics = _prefix "Statistics"
    /// <summary>
    /// A dataset in the RiverBench benchmark suite
    /// <see href="https://w3id.org/riverbench/schema/metadata#Dataset"></see></summary>
    let Dataset = _prefix "Dataset"
    /// <summary>
    /// Statistics about the number of datatype literals (NOT of type rdf:langString) in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#DatatypeLiteralCountStatistics"></see></summary>
    let DatatypeLiteralCountStatistics = _prefix "DatatypeLiteralCountStatistics"
    /// <summary>
    /// A distribution of a dataset in the RiverBench benchmark suite.
    /// <see href="https://w3id.org/riverbench/schema/metadata#Distribution"></see></summary>
    let Distribution = _prefix "Distribution"
    /// <summary>
    /// Type of dataset distribution, indicating the corresponding streaming task formulation.
    /// <see href="https://w3id.org/riverbench/schema/metadata#DistributionType"></see></summary>
    let DistributionType = _prefix "DistributionType"
    /// <summary>
    /// Statistics about the number of RDF graphs in the dataset, including the default graph.
    /// <see href="https://w3id.org/riverbench/schema/metadata#GraphCountStatistics"></see></summary>
    let GraphCountStatistics = _prefix "GraphCountStatistics"
    /// <summary>
    /// Statistics about the number of IRIs in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#IriCountStatistics"></see></summary>
    let IriCountStatistics = _prefix "IriCountStatistics"
    /// <summary>
    /// Statistics about the number of language literals in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#LanguageLiteralCountStatistics"></see></summary>
    let LanguageLiteralCountStatistics = _prefix "LanguageLiteralCountStatistics"
    /// <summary>
    /// Statistics about the number of literals in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#LiteralCountStatistics"></see></summary>
    let LiteralCountStatistics = _prefix "LiteralCountStatistics"
    /// <summary>
    /// Statistics about the number of objects in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#ObjectCountStatistics"></see></summary>
    let ObjectCountStatistics = _prefix "ObjectCountStatistics"
    /// <summary>
    /// Statistics about the number of predicates in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#PredicateCountStatistics"></see></summary>
    let PredicateCountStatistics = _prefix "PredicateCountStatistics"
    /// <summary>
    /// Benchmark profile grouping several datasets in RiverBench
    /// <see href="https://w3id.org/riverbench/schema/metadata#Profile"></see></summary>
    let Profile = _prefix "Profile"
    /// <summary>
    /// Resource with properties that specify conditions for datasets to be included in the profile. The conditions are joined with the OR operator.
    /// <see href="https://w3id.org/riverbench/schema/metadata#ProfileRestriction"></see></summary>
    let ProfileRestriction = _prefix "ProfileRestriction"
    /// <summary>
    /// Statistics about the number of quoted triples in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#QuotedTripleCountStatistics"></see></summary>
    let QuotedTripleCountStatistics = _prefix "QuotedTripleCountStatistics"
    /// <summary>
    /// RiverBench – RDF streaming benchmark suite
    /// <see href="https://w3id.org/riverbench/schema/metadata#RiverBench"></see></summary>
    let RiverBench = _prefix "RiverBench"
    /// <summary>
    /// Statistics about the number of simple literals (of type xsd:string) in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#SimpleLiteralCountStatistics"></see></summary>
    let SimpleLiteralCountStatistics = _prefix "SimpleLiteralCountStatistics"
    /// <summary>
    /// Statistics about the number of RDF statements in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#StatementCountStatistics"></see></summary>
    let StatementCountStatistics = _prefix "StatementCountStatistics"
    /// <summary>
    /// The number of statements in an element was the criterion for splitting the stream elements.
    /// <see href="https://w3id.org/riverbench/schema/metadata#StatementCountStreamElementSplit"></see></summary>
    let StatementCountStreamElementSplit = _prefix "StatementCountStreamElementSplit"
    /// <summary>
    /// Describes how was the stream split into individual elements.
    /// <see href="https://w3id.org/riverbench/schema/metadata#StreamElementSplit"></see></summary>
    let StreamElementSplit = _prefix "StreamElementSplit"
    /// <summary>
    /// Indicates the type of the contents of stream elements
    /// <see href="https://w3id.org/riverbench/schema/metadata#StreamElementType"></see></summary>
    let StreamElementType = _prefix "StreamElementType"
    /// <summary>
    /// Statistics about the number of subjects in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#SubjectCountStatistics"></see></summary>
    let SubjectCountStatistics = _prefix "SubjectCountStatistics"
    /// <summary>
    /// The elements correspond to different instants or intervals of time.
    /// <see href="https://w3id.org/riverbench/schema/metadata#TimeStreamElementSplit"></see></summary>
    let TimeStreamElementSplit = _prefix "TimeStreamElementSplit"
    /// <summary>
    /// The elements correspond to different topics/subjects in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#TopicStreamElementSplit"></see></summary>
    let TopicStreamElementSplit = _prefix "TopicStreamElementSplit"
    /// <summary>
    /// Base property for all conformance data properties
    /// <see href="https://w3id.org/riverbench/schema/metadata#conformanceProperty"></see></summary>
    let conformanceProperty = _prefix "conformanceProperty"
    /// <summary>
    /// Whether the dataset is RDF 1.1-compliant, i.e., does not use any non-standard features, like generalized triples.
    /// <see href="https://w3id.org/riverbench/schema/metadata#conformsToRdf11"></see></summary>
    let conformsToRdf11 = _prefix "conformsToRdf11"
    /// <summary>
    /// Whether the dataset is RDF-star compliant, i.e., does not use any non-standard features. Note that all standard RDF 1.1 datasets also qualify, as RDF-star is a superset of RDF 1.1.
    /// <see href="https://w3id.org/riverbench/schema/metadata#conformsToRdfStarDraft_20211217"></see></summary>
    let conformsToRdfStarDraft_20211217 = _prefix "conformsToRdfStarDraft_20211217"
    /// <summary>
    /// The dataset is distributed as a single flat file.
    /// <see href="https://w3id.org/riverbench/schema/metadata#flatDistribution"></see></summary>
    let flatDistribution = _prefix "flatDistribution"
    /// <summary>
    /// A full distribution, including all data in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#fullDistribution"></see></summary>
    let fullDistribution = _prefix "fullDistribution"
    /// <summary>
    /// The dataset is distributed as a stream of named RDF graphs.
    /// <see href="https://w3id.org/riverbench/schema/metadata#graphStreamDistribution"></see></summary>
    let graphStreamDistribution = _prefix "graphStreamDistribution"
    /// <summary>
    /// Graph streams are a special case of quad streams, where each element contains exactly one named RDF graph.
    /// <see href="https://w3id.org/riverbench/schema/metadata#graphs"></see></summary>
    let graphs = _prefix "graphs"
    /// <summary>
    /// Indicates the type of RiverBench dataset distribution
    /// <see href="https://w3id.org/riverbench/schema/metadata#hasDistributionType"></see></summary>
    let hasDistributionType = _prefix "hasDistributionType"
    /// <summary>
    /// Canonical file name of this distribution
    /// <see href="https://w3id.org/riverbench/schema/metadata#hasFileName"></see></summary>
    let hasFileName = _prefix "hasFileName"
    /// <summary>
    /// Indicates benchmark profiles that belong to this benchmark suite.
    /// <see href="https://w3id.org/riverbench/schema/metadata#hasProfile"></see></summary>
    let hasProfile = _prefix "hasProfile"
    /// <summary>
    /// Has profile restriction. The restrictions are joined with the AND operator.
    /// <see href="https://w3id.org/riverbench/schema/metadata#hasRestriction"></see></summary>
    let hasRestriction = _prefix "hasRestriction"
    /// <summary>
    /// Has a dataset statistics object
    /// <see href="https://w3id.org/riverbench/schema/metadata#hasStatistics"></see></summary>
    let hasStatistics = _prefix "hasStatistics"
    /// <summary>
    /// Number of elements in the stream
    /// <see href="https://w3id.org/riverbench/schema/metadata#hasStreamElementCount"></see></summary>
    let hasStreamElementCount = _prefix "hasStreamElementCount"
    /// <summary>
    /// Indicates how the stream was split into elements.
    /// <see href="https://w3id.org/riverbench/schema/metadata#hasStreamElementSplit"></see></summary>
    let hasStreamElementSplit = _prefix "hasStreamElementSplit"
    /// <summary>
    /// Indicates the type of contents of each stream element
    /// <see href="https://w3id.org/riverbench/schema/metadata#hasStreamElementType"></see></summary>
    let hasStreamElementType = _prefix "hasStreamElementType"
    /// <summary>
    /// The IRI of the property that is used in the stream to denote time at which the event occured.
    /// <see href="https://w3id.org/riverbench/schema/metadata#hasTemporalProperty"></see></summary>
    let hasTemporalProperty = _prefix "hasTemporalProperty"
    /// <summary>
    /// Version tag of an artifact
    /// <see href="https://w3id.org/riverbench/schema/metadata#hasVersion"></see></summary>
    let hasVersion = _prefix "hasVersion"
    /// <summary>
    /// Indicates that this profile's datasets are all in the other profile
    /// <see href="https://w3id.org/riverbench/schema/metadata#isSubsetOfProfile"></see></summary>
    let isSubsetOfProfile = _prefix "isSubsetOfProfile"
    /// <summary>
    /// Indicates that this profile contains all datasets of the other profile
    /// <see href="https://w3id.org/riverbench/schema/metadata#isSupersetOfProfile"></see></summary>
    let isSupersetOfProfile = _prefix "isSupersetOfProfile"
    /// <summary>
    /// Maximum value of a distribution
    /// <see href="https://w3id.org/riverbench/schema/metadata#maximum"></see></summary>
    let maximum = _prefix "maximum"
    /// <summary>
    /// The base statistical property.
    /// <see href="https://w3id.org/riverbench/schema/metadata#statisticalProperty"></see></summary>
    let statisticalProperty = _prefix "statisticalProperty"
    /// <summary>
    /// Arithmetic mean of a distribution
    /// <see href="https://w3id.org/riverbench/schema/metadata#mean"></see></summary>
    let mean = _prefix "mean"
    /// <summary>
    /// Minimum value of a distribution
    /// <see href="https://w3id.org/riverbench/schema/metadata#minimum"></see></summary>
    let minimum = _prefix "minimum"
    /// <summary>
    /// A partial distribution, including only a subset of the data in the dataset. The rb:hasStreamElementCount property indicates the length of this distribution.
    /// <see href="https://w3id.org/riverbench/schema/metadata#partialDistribution"></see></summary>
    let partialDistribution = _prefix "partialDistribution"
    /// <summary>
    /// The dataset is distributed as a stream of RDF quads.
    /// <see href="https://w3id.org/riverbench/schema/metadata#quadStreamDistribution"></see></summary>
    let quadStreamDistribution = _prefix "quadStreamDistribution"
    /// <summary>
    /// Quad streams consist of elements, where each element is an RDF dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#quads"></see></summary>
    let quads = _prefix "quads"
    /// <summary>
    /// Standard deviation of a distribution
    /// <see href="https://w3id.org/riverbench/schema/metadata#standardDeviation"></see></summary>
    let standardDeviation = _prefix "standardDeviation"
    /// <summary>
    /// Sum of all values in the distribution. In statistics about counts, this corresponds to the total number of given elements in the dataset.
    /// <see href="https://w3id.org/riverbench/schema/metadata#sum"></see></summary>
    let sum = _prefix "sum"
    /// <summary>
    /// The dataset is distributed as a stream of RDF triples.
    /// <see href="https://w3id.org/riverbench/schema/metadata#tripleStreamDistribution"></see></summary>
    let tripleStreamDistribution = _prefix "tripleStreamDistribution"
    /// <summary>
    /// Triple streams consist of elements, where each element is an RDF graph.
    /// <see href="https://w3id.org/riverbench/schema/metadata#triples"></see></summary>
    let triples = _prefix "triples"
    /// <summary>
    /// Only used for count statistics. Indicates how many unique elements are in the entire dataset. The value is estimated with a Bloom filter and is accurate to ~1%.
    /// <see href="https://w3id.org/riverbench/schema/metadata#uniqueCount"></see></summary>
    let uniqueCount = _prefix "uniqueCount"
    /// <summary>
    /// Whether the dataset uses the non-standard generalized datasets feature. A "dataset" here is used in the same meaning as in the RDF 1.1 specification.
    /// <see href="https://w3id.org/riverbench/schema/metadata#usesGeneralizedRdfDatasets"></see></summary>
    let usesGeneralizedRdfDatasets = _prefix "usesGeneralizedRdfDatasets"
    /// <summary>
    /// Whether the dataset uses the non-standard generalized triples feature
    /// <see href="https://w3id.org/riverbench/schema/metadata#usesGeneralizedTriples"></see></summary>
    let usesGeneralizedTriples = _prefix "usesGeneralizedTriples"
    /// <summary>
    /// Indicates that the dataset uses an ontology. The object must be a resource, but it doesn't neccesarily have to be an OWL ontology.
    /// <see href="https://w3id.org/riverbench/schema/metadata#usesOntology"></see></summary>
    let usesOntology = _prefix "usesOntology"
    /// <summary>
    /// Whether the dataset uses RDF-star features.
    /// <see href="https://w3id.org/riverbench/schema/metadata#usesRdfStar"></see></summary>
    let usesRdfStar = _prefix "usesRdfStar"
