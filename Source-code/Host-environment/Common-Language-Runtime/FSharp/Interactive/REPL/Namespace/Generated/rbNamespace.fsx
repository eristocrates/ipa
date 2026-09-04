#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rb =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/riverbench/schema/metadata#" "rb"

    /// <summary>
    ///   <para>rdfs:label : Blank node count statistics</para>
    ///   <para>rdfs:comment : Statistics about the number of blank nodes in the dataset.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#BlankNodeCountStatistics">rb:BlankNodeCountStatistics</a>
    /// </summary>
    let BlankNodeCountStatistics = _prefixId.prefix "BlankNodeCountStatistics"
    /// <summary>
    ///   <para>rdfs:label : RiverBench dataset</para>
    ///   <para>rdfs:comment : A dataset in the RiverBench benchmark suite</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#Dataset">rb:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"

    /// <summary>
    ///   <para>rdfs:label : Datatype literal count statistics</para>
    ///   <para>rdfs:comment : Statistics about the number of datatype literals (NOT of type rdf:langString) in the dataset.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#DatatypeLiteralCountStatistics">rb:DatatypeLiteralCountStatistics</a>
    /// </summary>
    let DatatypeLiteralCountStatistics =
        _prefixId.prefix "DatatypeLiteralCountStatistics"

    /// <summary>
    ///   <para>rdfs:label : RiverBench dataset distribution</para>
    ///   <para>rdfs:comment : A distribution of a dataset in the RiverBench benchmark suite.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#Distribution">rb:Distribution</a>
    /// </summary>
    let Distribution = _prefixId.prefix "Distribution"
    /// <summary>
    ///   <para>rdfs:label : RiverBench distribution type</para>
    ///   <para>rdfs:comment : Type of dataset distribution, indicating the corresponding streaming task formulation.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#DistributionType">rb:DistributionType</a>
    /// </summary>
    let DistributionType = _prefixId.prefix "DistributionType"
    /// <summary>
    ///   <para>rdfs:label : Graph count statistics</para>
    ///   <para>rdfs:comment : Statistics about the number of RDF graphs in the dataset, including the default graph.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#GraphCountStatistics">rb:GraphCountStatistics</a>
    /// </summary>
    let GraphCountStatistics = _prefixId.prefix "GraphCountStatistics"
    /// <summary>
    ///   <para>rdfs:label : IRI count statistics</para>
    ///   <para>rdfs:comment : Statistics about the number of IRIs in the dataset.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#IriCountStatistics">rb:IriCountStatistics</a>
    /// </summary>
    let IriCountStatistics = _prefixId.prefix "IriCountStatistics"

    /// <summary>
    ///   <para>rdfs:label : Language string count statistics</para>
    ///   <para>rdfs:comment : Statistics about the number of language literals in the dataset.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#LanguageLiteralCountStatistics">rb:LanguageLiteralCountStatistics</a>
    /// </summary>
    let LanguageLiteralCountStatistics =
        _prefixId.prefix "LanguageLiteralCountStatistics"

    /// <summary>
    ///   <para>rdfs:label : Literal count statistics</para>
    ///   <para>rdfs:comment : Statistics about the number of literals in the dataset.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#LiteralCountStatistics">rb:LiteralCountStatistics</a>
    /// </summary>
    let LiteralCountStatistics = _prefixId.prefix "LiteralCountStatistics"
    /// <summary>
    ///   <para>rdfs:label : Object count statistics</para>
    ///   <para>rdfs:comment : Statistics about the number of objects in the dataset.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#ObjectCountStatistics">rb:ObjectCountStatistics</a>
    /// </summary>
    let ObjectCountStatistics = _prefixId.prefix "ObjectCountStatistics"
    /// <summary>
    ///   <para>rdfs:label : Predicate count statistics</para>
    ///   <para>rdfs:comment : Statistics about the number of predicates in the dataset.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#PredicateCountStatistics">rb:PredicateCountStatistics</a>
    /// </summary>
    let PredicateCountStatistics = _prefixId.prefix "PredicateCountStatistics"
    /// <summary>
    ///   <para>rdfs:label : Benchmark profile</para>
    ///   <para>rdfs:comment : Benchmark profile grouping several datasets in RiverBench</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#Profile">rb:Profile</a>
    /// </summary>
    let Profile = _prefixId.prefix "Profile"
    /// <summary>
    ///   <para>rdfs:label : Profile restriction</para>
    ///   <para>rdfs:comment : Resource with properties that specify conditions for datasets to be included in the profile. The conditions are joined with the OR operator.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#ProfileRestriction">rb:ProfileRestriction</a>
    /// </summary>
    let ProfileRestriction = _prefixId.prefix "ProfileRestriction"
    /// <summary>
    ///   <para>rdfs:label : Quoted triple count statistics</para>
    ///   <para>rdfs:comment : Statistics about the number of quoted triples in the dataset.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#QuotedTripleCountStatistics">rb:QuotedTripleCountStatistics</a>
    /// </summary>
    let QuotedTripleCountStatistics = _prefixId.prefix "QuotedTripleCountStatistics"
    /// <summary>
    ///   <para>rdfs:label : RiverBench suite</para>
    ///   <para>rdfs:comment : RiverBench – RDF streaming benchmark suite</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#RiverBench">rb:RiverBench</a>
    /// </summary>
    let RiverBench = _prefixId.prefix "RiverBench"
    /// <summary>
    ///   <para>rdfs:label : Simple literal count statistics</para>
    ///   <para>rdfs:comment : Statistics about the number of simple literals (of type xsd:string) in the dataset.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#SimpleLiteralCountStatistics">rb:SimpleLiteralCountStatistics</a>
    /// </summary>
    let SimpleLiteralCountStatistics = _prefixId.prefix "SimpleLiteralCountStatistics"
    /// <summary>
    ///   <para>rdfs:label : Statement count statistics</para>
    ///   <para>rdfs:comment : Statistics about the number of RDF statements in the dataset.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#StatementCountStatistics">rb:StatementCountStatistics</a>
    /// </summary>
    let StatementCountStatistics = _prefixId.prefix "StatementCountStatistics"

    /// <summary>
    ///   <para>rdfs:label : Stream elements split by statement count</para>
    ///   <para>rdfs:comment : The number of statements in an element was the criterion for splitting the stream elements.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#StatementCountStreamElementSplit">rb:StatementCountStreamElementSplit</a>
    /// </summary>
    let StatementCountStreamElementSplit =
        _prefixId.prefix "StatementCountStreamElementSplit"

    /// <summary>
    ///   <para>rdfs:label : Statistics</para>
    ///   <para>rdfs:comment : Class for statistics objects about distributions</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#Statistics">rb:Statistics</a>
    /// </summary>
    let Statistics = _prefixId.prefix "Statistics"
    /// <summary>
    ///   <para>rdfs:label : Stream element split</para>
    ///   <para>rdfs:comment : Describes how was the stream split into individual elements.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#StreamElementSplit">rb:StreamElementSplit</a>
    /// </summary>
    let StreamElementSplit = _prefixId.prefix "StreamElementSplit"
    /// <summary>
    ///   <para>rdfs:label : Stream element type</para>
    ///   <para>rdfs:comment : Indicates the type of the contents of stream elements</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#StreamElementType">rb:StreamElementType</a>
    /// </summary>
    let StreamElementType = _prefixId.prefix "StreamElementType"
    /// <summary>
    ///   <para>rdfs:label : Subject count statistics</para>
    ///   <para>rdfs:comment : Statistics about the number of subjects in the dataset.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#SubjectCountStatistics">rb:SubjectCountStatistics</a>
    /// </summary>
    let SubjectCountStatistics = _prefixId.prefix "SubjectCountStatistics"
    /// <summary>
    ///   <para>rdfs:label : Stream elements split by time</para>
    ///   <para>rdfs:comment : The elements correspond to different instants or intervals of time.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#TimeStreamElementSplit">rb:TimeStreamElementSplit</a>
    /// </summary>
    let TimeStreamElementSplit = _prefixId.prefix "TimeStreamElementSplit"
    /// <summary>
    ///   <para>rdfs:label : Stream elements split by topic</para>
    ///   <para>rdfs:comment : The elements correspond to different topics/subjects in the dataset.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#TopicStreamElementSplit">rb:TopicStreamElementSplit</a>
    /// </summary>
    let TopicStreamElementSplit = _prefixId.prefix "TopicStreamElementSplit"
    /// <summary>
    ///   <para>rdfs:label : Conformance property</para>
    ///   <para>rdfs:comment : Base property for all conformance data properties</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#conformanceProperty">rb:conformanceProperty</a>
    /// </summary>
    let conformanceProperty = _prefixId.prefix "conformanceProperty"
    /// <summary>
    ///   <para>rdfs:label : Conforms to W3C RDF 1.1 specification</para>
    ///   <para>rdfs:comment : Whether the dataset is RDF 1.1-compliant, i.e., does not use any non-standard features, like generalized triples.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#conformsToRdf11">rb:conformsToRdf11</a>
    /// </summary>
    let conformsToRdf11 = _prefixId.prefix "conformsToRdf11"

    /// <summary>
    ///   <para>rdfs:label : Conforms to W3C RDF-star draft specification as of December 17, 2021</para>
    ///   <para>rdfs:comment : Whether the dataset is RDF-star compliant, i.e., does not use any non-standard features. Note that all standard RDF 1.1 datasets also qualify, as RDF-star is a superset of RDF 1.1.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#conformsToRdfStarDraft_20211217">rb:conformsToRdfStarDraft_20211217</a>
    /// </summary>
    let conformsToRdfStarDraft_20211217 =
        _prefixId.prefix "conformsToRdfStarDraft_20211217"

    let flatDistribution = _prefixId.prefix "flatDistribution"
    let fullDistribution = _prefixId.prefix "fullDistribution"
    let graphStreamDistribution = _prefixId.prefix "graphStreamDistribution"
    let graphs = _prefixId.prefix "graphs"
    /// <summary>
    ///   <para>rdfs:label : Has distribution type</para>
    ///   <para>rdfs:comment : Indicates the type of RiverBench dataset distribution</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#hasDistributionType">rb:hasDistributionType</a>
    /// </summary>
    let hasDistributionType = _prefixId.prefix "hasDistributionType"
    /// <summary>
    ///   <para>rdfs:label : Has file name</para>
    ///   <para>rdfs:comment : Canonical file name of this distribution</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#hasFileName">rb:hasFileName</a>
    /// </summary>
    let hasFileName = _prefixId.prefix "hasFileName"
    /// <summary>
    ///   <para>rdfs:label : Has benchmark profile</para>
    ///   <para>rdfs:comment : Indicates benchmark profiles that belong to this benchmark suite.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#hasProfile">rb:hasProfile</a>
    /// </summary>
    let hasProfile = _prefixId.prefix "hasProfile"
    /// <summary>
    ///   <para>rdfs:label : Has restriction</para>
    ///   <para>rdfs:comment : Has profile restriction. The restrictions are joined with the AND operator.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#hasRestriction">rb:hasRestriction</a>
    /// </summary>
    let hasRestriction = _prefixId.prefix "hasRestriction"
    /// <summary>
    ///   <para>rdfs:label : Has statistics</para>
    ///   <para>rdfs:comment : Has a dataset statistics object</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#hasStatistics">rb:hasStatistics</a>
    /// </summary>
    let hasStatistics = _prefixId.prefix "hasStatistics"
    /// <summary>
    ///   <para>rdfs:label : Has stream element count</para>
    ///   <para>rdfs:comment : Number of elements in the stream</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#hasStreamElementCount">rb:hasStreamElementCount</a>
    /// </summary>
    let hasStreamElementCount = _prefixId.prefix "hasStreamElementCount"
    /// <summary>
    ///   <para>rdfs:label : Has stream element split</para>
    ///   <para>rdfs:comment : Indicates how the stream was split into elements.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#hasStreamElementSplit">rb:hasStreamElementSplit</a>
    /// </summary>
    let hasStreamElementSplit = _prefixId.prefix "hasStreamElementSplit"
    /// <summary>
    ///   <para>rdfs:label : Has stream element type</para>
    ///   <para>rdfs:comment : Indicates the type of contents of each stream element</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#hasStreamElementType">rb:hasStreamElementType</a>
    /// </summary>
    let hasStreamElementType = _prefixId.prefix "hasStreamElementType"
    /// <summary>
    ///   <para>rdfs:label : Has temporal property</para>
    ///   <para>rdfs:comment : The IRI of the property that is used in the stream to denote time at which the event occured.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#hasTemporalProperty">rb:hasTemporalProperty</a>
    /// </summary>
    let hasTemporalProperty = _prefixId.prefix "hasTemporalProperty"
    /// <summary>
    ///   <para>rdfs:label : Has version</para>
    ///   <para>rdfs:comment : Version tag of an artifact</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#hasVersion">rb:hasVersion</a>
    /// </summary>
    let hasVersion = _prefixId.prefix "hasVersion"
    /// <summary>
    ///   <para>rdfs:label : Is subset of profile</para>
    ///   <para>rdfs:comment : Indicates that this profile's datasets are all in the other profile</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#isSubsetOfProfile">rb:isSubsetOfProfile</a>
    /// </summary>
    let isSubsetOfProfile = _prefixId.prefix "isSubsetOfProfile"
    /// <summary>
    ///   <para>rdfs:label : Is superset of profile</para>
    ///   <para>rdfs:comment : Indicates that this profile contains all datasets of the other profile</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#isSupersetOfProfile">rb:isSupersetOfProfile</a>
    /// </summary>
    let isSupersetOfProfile = _prefixId.prefix "isSupersetOfProfile"
    /// <summary>
    ///   <para>rdfs:label : Maximum</para>
    ///   <para>rdfs:comment : Maximum value of a distribution</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#maximum">rb:maximum</a>
    /// </summary>
    let maximum = _prefixId.prefix "maximum"
    /// <summary>
    ///   <para>rdfs:label : Mean</para>
    ///   <para>rdfs:comment : Arithmetic mean of a distribution</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#mean">rb:mean</a>
    /// </summary>
    let mean = _prefixId.prefix "mean"
    /// <summary>
    ///   <para>rdfs:label : Minimum</para>
    ///   <para>rdfs:comment : Minimum value of a distribution</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#minimum">rb:minimum</a>
    /// </summary>
    let minimum = _prefixId.prefix "minimum"
    let partialDistribution = _prefixId.prefix "partialDistribution"
    let quadStreamDistribution = _prefixId.prefix "quadStreamDistribution"
    let quads = _prefixId.prefix "quads"
    /// <summary>
    ///   <para>rdfs:label : Standard deviation</para>
    ///   <para>rdfs:comment : Standard deviation of a distribution</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#standardDeviation">rb:standardDeviation</a>
    /// </summary>
    let standardDeviation = _prefixId.prefix "standardDeviation"
    /// <summary>
    ///   <para>rdfs:label : Statistical property</para>
    ///   <para>rdfs:comment : The base statistical property.^^xsd:string</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#statisticalProperty">rb:statisticalProperty</a>
    /// </summary>
    let statisticalProperty = _prefixId.prefix "statisticalProperty"
    /// <summary>
    ///   <para>rdfs:label : Sum</para>
    ///   <para>rdfs:comment : Sum of all values in the distribution. In statistics about counts, this corresponds to the total number of given elements in the dataset.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#sum">rb:sum</a>
    /// </summary>
    let sum = _prefixId.prefix "sum"
    let tripleStreamDistribution = _prefixId.prefix "tripleStreamDistribution"
    let triples = _prefixId.prefix "triples"
    /// <summary>
    ///   <para>rdfs:label : Unique count (estimated)</para>
    ///   <para>rdfs:comment : Only used for count statistics. Indicates how many unique elements are in the entire dataset. The value is estimated with a Bloom filter and is accurate to ~1%.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#uniqueCount">rb:uniqueCount</a>
    /// </summary>
    let uniqueCount = _prefixId.prefix "uniqueCount"
    /// <summary>
    ///   <para>rdfs:label : Uses generalized RDF datasets</para>
    ///   <para>rdfs:comment : Whether the dataset uses the non-standard generalized datasets feature. A "dataset" here is used in the same meaning as in the RDF 1.1 specification.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#usesGeneralizedRdfDatasets">rb:usesGeneralizedRdfDatasets</a>
    /// </summary>
    let usesGeneralizedRdfDatasets = _prefixId.prefix "usesGeneralizedRdfDatasets"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://www.w3.org/TR/rdf11-concepts/#section-generalized-rdf</para>
    ///   <para>rdfs:label : Uses generalized triples</para>
    ///   <para>rdfs:comment : Whether the dataset uses the non-standard generalized triples feature</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#usesGeneralizedTriples">rb:usesGeneralizedTriples</a>
    /// </summary>
    let usesGeneralizedTriples = _prefixId.prefix "usesGeneralizedTriples"
    /// <summary>
    ///   <para>rdfs:label : Uses ontology</para>
    ///   <para>rdfs:comment : Indicates that the dataset uses an ontology. The object must be a resource, but it doesn't neccesarily have to be an OWL ontology.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#usesOntology">rb:usesOntology</a>
    /// </summary>
    let usesOntology = _prefixId.prefix "usesOntology"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://www.w3.org/2021/12/rdf-star.html</para>
    ///   <para>rdfs:label : Uses RDF-star</para>
    ///   <para>rdfs:comment : Whether the dataset uses RDF-star features.</para>
    ///   <a href="https://w3id.org/riverbench/schema/metadata#usesRdfStar">rb:usesRdfStar</a>
    /// </summary>
    let usesRdfStar = _prefixId.prefix "usesRdfStar"
