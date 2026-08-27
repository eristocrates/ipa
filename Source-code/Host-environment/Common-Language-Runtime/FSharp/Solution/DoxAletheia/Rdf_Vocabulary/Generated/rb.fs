namespace https.w3id.org.riverbench.schema.metadata.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rb =
    let _namespace_iri = Namespace_Iri rb |> NamespaceIRI

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#BlankNodeCountStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Statistics about the number of blank nodes in the dataset."</para>
    /// labels<para>"Blank node count statistics"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#BlankNodeCountStatistics">https://w3id.org/riverbench/schema/metadata#BlankNodeCountStatistics</seealso>
    let BlankNodeCountStatistics =
        Prefixed_Name(rb, "BlankNodeCountStatistics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A dataset in the RiverBench benchmark suite"</para>
    /// labels<para>"RiverBench dataset"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#Dataset">https://w3id.org/riverbench/schema/metadata#Dataset</seealso>
    let Dataset = Prefixed_Name(rb, "Dataset") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#DatatypeLiteralCountStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Statistics about the number of datatype literals (NOT of type rdf:langString) in the dataset."</para>
    /// labels<para>"Datatype literal count statistics"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#DatatypeLiteralCountStatistics">https://w3id.org/riverbench/schema/metadata#DatatypeLiteralCountStatistics</seealso>
    let DatatypeLiteralCountStatistics =
        Prefixed_Name(rb, "DatatypeLiteralCountStatistics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#Distribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A distribution of a dataset in the RiverBench benchmark suite."</para>
    /// labels<para>"RiverBench dataset distribution"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#Distribution">https://w3id.org/riverbench/schema/metadata#Distribution</seealso>
    let Distribution = Prefixed_Name(rb, "Distribution") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#DistributionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Type of dataset distribution, indicating the corresponding streaming task formulation."</para>
    /// labels<para>"RiverBench distribution type"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#DistributionType">https://w3id.org/riverbench/schema/metadata#DistributionType</seealso>
    let DistributionType = Prefixed_Name(rb, "DistributionType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#GraphCountStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Statistics about the number of RDF graphs in the dataset, including the default graph."</para>
    /// labels<para>"Graph count statistics"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#GraphCountStatistics">https://w3id.org/riverbench/schema/metadata#GraphCountStatistics</seealso>
    let GraphCountStatistics = Prefixed_Name(rb, "GraphCountStatistics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#IriCountStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Statistics about the number of IRIs in the dataset."</para>
    /// labels<para>"IRI count statistics"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#IriCountStatistics">https://w3id.org/riverbench/schema/metadata#IriCountStatistics</seealso>
    let IriCountStatistics = Prefixed_Name(rb, "IriCountStatistics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#LanguageLiteralCountStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Statistics about the number of language literals in the dataset."</para>
    /// labels<para>"Language string count statistics"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#LanguageLiteralCountStatistics">https://w3id.org/riverbench/schema/metadata#LanguageLiteralCountStatistics</seealso>
    let LanguageLiteralCountStatistics =
        Prefixed_Name(rb, "LanguageLiteralCountStatistics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#LiteralCountStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Statistics about the number of literals in the dataset."</para>
    /// labels<para>"Literal count statistics"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#LiteralCountStatistics">https://w3id.org/riverbench/schema/metadata#LiteralCountStatistics</seealso>
    let LiteralCountStatistics =
        Prefixed_Name(rb, "LiteralCountStatistics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#ObjectCountStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Statistics about the number of objects in the dataset."</para>
    /// labels<para>"Object count statistics"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#ObjectCountStatistics">https://w3id.org/riverbench/schema/metadata#ObjectCountStatistics</seealso>
    let ObjectCountStatistics =
        Prefixed_Name(rb, "ObjectCountStatistics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#PredicateCountStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Statistics about the number of predicates in the dataset."</para>
    /// labels<para>"Predicate count statistics"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#PredicateCountStatistics">https://w3id.org/riverbench/schema/metadata#PredicateCountStatistics</seealso>
    let PredicateCountStatistics =
        Prefixed_Name(rb, "PredicateCountStatistics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#Profile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Benchmark profile grouping several datasets in RiverBench"</para>
    /// labels<para>"Benchmark profile"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#Profile">https://w3id.org/riverbench/schema/metadata#Profile</seealso>
    let Profile = Prefixed_Name(rb, "Profile") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#ProfileRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Resource with properties that specify conditions for datasets to be included in the profile. The conditions are joined with the OR operator."</para>
    /// labels<para>"Profile restriction"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#ProfileRestriction">https://w3id.org/riverbench/schema/metadata#ProfileRestriction</seealso>
    let ProfileRestriction = Prefixed_Name(rb, "ProfileRestriction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#QuotedTripleCountStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Statistics about the number of quoted triples in the dataset."</para>
    /// labels<para>"Quoted triple count statistics"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#QuotedTripleCountStatistics">https://w3id.org/riverbench/schema/metadata#QuotedTripleCountStatistics</seealso>
    let QuotedTripleCountStatistics =
        Prefixed_Name(rb, "QuotedTripleCountStatistics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#RiverBench</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"RiverBench – RDF streaming benchmark suite"</para>
    /// labels<para>"RiverBench suite"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#RiverBench">https://w3id.org/riverbench/schema/metadata#RiverBench</seealso>
    let RiverBench = Prefixed_Name(rb, "RiverBench") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#SimpleLiteralCountStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Statistics about the number of simple literals (of type xsd:string) in the dataset."</para>
    /// labels<para>"Simple literal count statistics"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#SimpleLiteralCountStatistics">https://w3id.org/riverbench/schema/metadata#SimpleLiteralCountStatistics</seealso>
    let SimpleLiteralCountStatistics =
        Prefixed_Name(rb, "SimpleLiteralCountStatistics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#StatementCountStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Statistics about the number of RDF statements in the dataset."</para>
    /// labels<para>"Statement count statistics"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#StatementCountStatistics">https://w3id.org/riverbench/schema/metadata#StatementCountStatistics</seealso>
    let StatementCountStatistics =
        Prefixed_Name(rb, "StatementCountStatistics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#StatementCountStreamElementSplit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The number of statements in an element was the criterion for splitting the stream elements."</para>
    /// labels<para>"Stream elements split by statement count"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#StatementCountStreamElementSplit">https://w3id.org/riverbench/schema/metadata#StatementCountStreamElementSplit</seealso>
    let StatementCountStreamElementSplit =
        Prefixed_Name(rb, "StatementCountStreamElementSplit") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#Statistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class for statistics objects about distributions"</para>
    /// labels<para>"Statistics"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#Statistics">https://w3id.org/riverbench/schema/metadata#Statistics</seealso>
    let Statistics = Prefixed_Name(rb, "Statistics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#StreamElementSplit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes how was the stream split into individual elements."</para>
    /// labels<para>"Stream element split"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#StreamElementSplit">https://w3id.org/riverbench/schema/metadata#StreamElementSplit</seealso>
    let StreamElementSplit = Prefixed_Name(rb, "StreamElementSplit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#StreamElementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the type of the contents of stream elements"</para>
    /// labels<para>"Stream element type"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#StreamElementType">https://w3id.org/riverbench/schema/metadata#StreamElementType</seealso>
    let StreamElementType = Prefixed_Name(rb, "StreamElementType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#SubjectCountStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Statistics about the number of subjects in the dataset."</para>
    /// labels<para>"Subject count statistics"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#SubjectCountStatistics">https://w3id.org/riverbench/schema/metadata#SubjectCountStatistics</seealso>
    let SubjectCountStatistics =
        Prefixed_Name(rb, "SubjectCountStatistics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#TimeStreamElementSplit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The elements correspond to different instants or intervals of time."</para>
    /// labels<para>"Stream elements split by time"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#TimeStreamElementSplit">https://w3id.org/riverbench/schema/metadata#TimeStreamElementSplit</seealso>
    let TimeStreamElementSplit =
        Prefixed_Name(rb, "TimeStreamElementSplit") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#TopicStreamElementSplit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The elements correspond to different topics/subjects in the dataset."</para>
    /// labels<para>"Stream elements split by topic"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#TopicStreamElementSplit">https://w3id.org/riverbench/schema/metadata#TopicStreamElementSplit</seealso>
    let TopicStreamElementSplit =
        Prefixed_Name(rb, "TopicStreamElementSplit") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#conformanceProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Base property for all conformance data properties"</para>
    /// labels<para>"Conformance property"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#conformanceProperty">https://w3id.org/riverbench/schema/metadata#conformanceProperty</seealso>
    let conformanceProperty = Prefixed_Name(rb, "conformanceProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#conformsToRdf11</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Whether the dataset is RDF 1.1-compliant, i.e., does not use any non-standard features, like generalized triples."</para>
    /// labels<para>"Conforms to W3C RDF 1.1 specification"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#conformsToRdf11">https://w3id.org/riverbench/schema/metadata#conformsToRdf11</seealso>
    let conformsToRdf11 = Prefixed_Name(rb, "conformsToRdf11") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#conformsToRdfStarDraft_20211217</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Whether the dataset is RDF-star compliant, i.e., does not use any non-standard features. Note that all standard RDF 1.1 datasets also qualify, as RDF-star is a superset of RDF 1.1."</para>
    /// labels<para>"Conforms to W3C RDF-star draft specification as of December 17, 2021"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#conformsToRdfStarDraft_20211217">https://w3id.org/riverbench/schema/metadata#conformsToRdfStarDraft_20211217</seealso>
    let conformsToRdfStarDraft_20211217 =
        Prefixed_Name(rb, "conformsToRdfStarDraft_20211217") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#flatDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:riverbench/schema/metadata#DistributionType</para>
    ///   <para>"The dataset is distributed as a single flat file."</para>
    /// labels<para>"Flat distribution"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#flatDistribution">https://w3id.org/riverbench/schema/metadata#flatDistribution</seealso>
    let flatDistribution = Prefixed_Name(rb, "flatDistribution") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#fullDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:riverbench/schema/metadata#DistributionType</para>
    ///   <para>"A full distribution, including all data in the dataset."</para>
    /// labels<para>"Full distribution"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#fullDistribution">https://w3id.org/riverbench/schema/metadata#fullDistribution</seealso>
    let fullDistribution = Prefixed_Name(rb, "fullDistribution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#graphStreamDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:riverbench/schema/metadata#DistributionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The dataset is distributed as a stream of named RDF graphs."</para>
    /// labels<para>"Graph stream distribution"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#graphStreamDistribution">https://w3id.org/riverbench/schema/metadata#graphStreamDistribution</seealso>
    let graphStreamDistribution =
        Prefixed_Name(rb, "graphStreamDistribution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#graphs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:riverbench/schema/metadata#StreamElementType</para>
    ///   <para>"Graph streams are a special case of quad streams, where each element contains exactly one named RDF graph."</para>
    /// labels<para>"Graphs"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#graphs">https://w3id.org/riverbench/schema/metadata#graphs</seealso>
    let graphs = Prefixed_Name(rb, "graphs") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#hasDistributionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the type of RiverBench dataset distribution"</para>
    /// labels<para>"Has distribution type"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#hasDistributionType">https://w3id.org/riverbench/schema/metadata#hasDistributionType</seealso>
    let hasDistributionType = Prefixed_Name(rb, "hasDistributionType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#hasFileName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Canonical file name of this distribution"</para>
    /// labels<para>"Has file name"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#hasFileName">https://w3id.org/riverbench/schema/metadata#hasFileName</seealso>
    let hasFileName = Prefixed_Name(rb, "hasFileName") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#hasProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates benchmark profiles that belong to this benchmark suite."</para>
    /// labels<para>"Has benchmark profile"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#hasProfile">https://w3id.org/riverbench/schema/metadata#hasProfile</seealso>
    let hasProfile = Prefixed_Name(rb, "hasProfile") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#hasRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Has profile restriction. The restrictions are joined with the AND operator."</para>
    /// labels<para>"Has restriction"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#hasRestriction">https://w3id.org/riverbench/schema/metadata#hasRestriction</seealso>
    let hasRestriction = Prefixed_Name(rb, "hasRestriction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#hasStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Has a dataset statistics object"</para>
    /// labels<para>"Has statistics"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#hasStatistics">https://w3id.org/riverbench/schema/metadata#hasStatistics</seealso>
    let hasStatistics = Prefixed_Name(rb, "hasStatistics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#hasStreamElementCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of elements in the stream"</para>
    /// labels<para>"Has stream element count"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#hasStreamElementCount">https://w3id.org/riverbench/schema/metadata#hasStreamElementCount</seealso>
    let hasStreamElementCount =
        Prefixed_Name(rb, "hasStreamElementCount") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#hasStreamElementSplit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates how the stream was split into elements."</para>
    /// labels<para>"Has stream element split"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#hasStreamElementSplit">https://w3id.org/riverbench/schema/metadata#hasStreamElementSplit</seealso>
    let hasStreamElementSplit =
        Prefixed_Name(rb, "hasStreamElementSplit") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#hasStreamElementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the type of contents of each stream element"</para>
    /// labels<para>"Has stream element type"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#hasStreamElementType">https://w3id.org/riverbench/schema/metadata#hasStreamElementType</seealso>
    let hasStreamElementType = Prefixed_Name(rb, "hasStreamElementType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#hasTemporalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The IRI of the property that is used in the stream to denote time at which the event occured."</para>
    /// labels<para>"Has temporal property"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#hasTemporalProperty">https://w3id.org/riverbench/schema/metadata#hasTemporalProperty</seealso>
    let hasTemporalProperty = Prefixed_Name(rb, "hasTemporalProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#hasVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Version tag of an artifact"</para>
    /// labels<para>"Has version"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#hasVersion">https://w3id.org/riverbench/schema/metadata#hasVersion</seealso>
    let hasVersion = Prefixed_Name(rb, "hasVersion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#isSubsetOfProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Indicates that this profile's datasets are all in the other profile"</para>
    /// labels<para>"Is subset of profile"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#isSubsetOfProfile">https://w3id.org/riverbench/schema/metadata#isSubsetOfProfile</seealso>
    let isSubsetOfProfile = Prefixed_Name(rb, "isSubsetOfProfile") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#isSupersetOfProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Indicates that this profile contains all datasets of the other profile"</para>
    /// labels<para>"Is superset of profile"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#isSupersetOfProfile">https://w3id.org/riverbench/schema/metadata#isSupersetOfProfile</seealso>
    let isSupersetOfProfile = Prefixed_Name(rb, "isSupersetOfProfile") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#maximum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Maximum value of a distribution"</para>
    /// labels<para>"Maximum"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#maximum">https://w3id.org/riverbench/schema/metadata#maximum</seealso>
    let maximum = Prefixed_Name(rb, "maximum") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#mean</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Arithmetic mean of a distribution"</para>
    /// labels<para>"Mean"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#mean">https://w3id.org/riverbench/schema/metadata#mean</seealso>
    let mean = Prefixed_Name(rb, "mean") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#minimum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Minimum value of a distribution"</para>
    /// labels<para>"Minimum"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#minimum">https://w3id.org/riverbench/schema/metadata#minimum</seealso>
    let minimum = Prefixed_Name(rb, "minimum") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#partialDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:riverbench/schema/metadata#DistributionType</para>
    ///   <para>"A partial distribution, including only a subset of the data in the dataset. The rb:hasStreamElementCount property indicates the length of this distribution."</para>
    /// labels<para>"Partial distribution"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#partialDistribution">https://w3id.org/riverbench/schema/metadata#partialDistribution</seealso>
    let partialDistribution = Prefixed_Name(rb, "partialDistribution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#quadStreamDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:riverbench/schema/metadata#DistributionType</para>
    ///   <para>"The dataset is distributed as a stream of RDF quads."</para>
    /// labels<para>"Quad stream distribution"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#quadStreamDistribution">https://w3id.org/riverbench/schema/metadata#quadStreamDistribution</seealso>
    let quadStreamDistribution =
        Prefixed_Name(rb, "quadStreamDistribution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#quads</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:riverbench/schema/metadata#StreamElementType</para>
    ///   <para>"Quad streams consist of elements, where each element is an RDF dataset."</para>
    /// labels<para>"Quads"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#quads">https://w3id.org/riverbench/schema/metadata#quads</seealso>
    let quads = Prefixed_Name(rb, "quads") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#standardDeviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Standard deviation of a distribution"</para>
    /// labels<para>"Standard deviation"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#standardDeviation">https://w3id.org/riverbench/schema/metadata#standardDeviation</seealso>
    let standardDeviation = Prefixed_Name(rb, "standardDeviation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#statisticalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The base statistical property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Statistical property"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#statisticalProperty">https://w3id.org/riverbench/schema/metadata#statisticalProperty</seealso>
    let statisticalProperty = Prefixed_Name(rb, "statisticalProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#sum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Sum of all values in the distribution. In statistics about counts, this corresponds to the total number of given elements in the dataset."</para>
    /// labels<para>"Sum"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#sum">https://w3id.org/riverbench/schema/metadata#sum</seealso>
    let sum = Prefixed_Name(rb, "sum") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#tripleStreamDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:riverbench/schema/metadata#DistributionType</para>
    ///   <para>"The dataset is distributed as a stream of RDF triples."</para>
    /// labels<para>"Triple stream distribution"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#tripleStreamDistribution">https://w3id.org/riverbench/schema/metadata#tripleStreamDistribution</seealso>
    let tripleStreamDistribution =
        Prefixed_Name(rb, "tripleStreamDistribution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#triples</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:riverbench/schema/metadata#StreamElementType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Triple streams consist of elements, where each element is an RDF graph."</para>
    /// labels<para>"Triples"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#triples">https://w3id.org/riverbench/schema/metadata#triples</seealso>
    let triples = Prefixed_Name(rb, "triples") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#uniqueCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Only used for count statistics. Indicates how many unique elements are in the entire dataset. The value is estimated with a Bloom filter and is accurate to ~1%."</para>
    /// labels<para>"Unique count (estimated)"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#uniqueCount">https://w3id.org/riverbench/schema/metadata#uniqueCount</seealso>
    let uniqueCount = Prefixed_Name(rb, "uniqueCount") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#usesGeneralizedRdfDatasets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Whether the dataset uses the non-standard generalized datasets feature. A "dataset" here is used in the same meaning as in the RDF 1.1 specification."</para>
    /// labels<para>"Uses generalized RDF datasets"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#usesGeneralizedRdfDatasets">https://w3id.org/riverbench/schema/metadata#usesGeneralizedRdfDatasets</seealso>
    let usesGeneralizedRdfDatasets =
        Prefixed_Name(rb, "usesGeneralizedRdfDatasets") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#usesGeneralizedTriples</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Whether the dataset uses the non-standard generalized triples feature"</para>
    /// labels<para>"Uses generalized triples"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#usesGeneralizedTriples">https://w3id.org/riverbench/schema/metadata#usesGeneralizedTriples</seealso>
    let usesGeneralizedTriples =
        Prefixed_Name(rb, "usesGeneralizedTriples") |> PrefixedName

    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#usesOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that the dataset uses an ontology. The object must be a resource, but it doesn't neccesarily have to be an OWL ontology."</para>
    /// labels<para>"Uses ontology"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#usesOntology">https://w3id.org/riverbench/schema/metadata#usesOntology</seealso>
    let usesOntology = Prefixed_Name(rb, "usesOntology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:riverbench/schema/metadata#usesRdfStar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Whether the dataset uses RDF-star features."</para>
    /// labels<para>"Uses RDF-star"</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/metadata#usesRdfStar">https://w3id.org/riverbench/schema/metadata#usesRdfStar</seealso>
    let usesRdfStar = Prefixed_Name(rb, "usesRdfStar") |> PrefixedName
