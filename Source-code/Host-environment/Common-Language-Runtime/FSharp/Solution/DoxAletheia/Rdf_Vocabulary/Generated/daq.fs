namespace http.purl.org.eis.vocab.daq.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module daq =
    let _namespace_iri = Namespace_Iri daq |> NamespaceIRI
    /// <summary>
    ///   <para>daq:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>The Dataset Quality Vocabulary (daQ) is a lightweight, extensible core vocabulary for attaching the result of quality benchmarking of a linked open dataset (usually an expensive process) to that dataset.  daQ is designed to be extended by custom quality metrics.  Use cases include filtering and ranking datasets by quality.</para>
    /// labels<para>Dataset Quality Vocabulary (daQ)</para></remarks>
    /// <seealso href="http://purl.org/eis/vocab/daq#">http://purl.org/eis/vocab/daq#</seealso>
    let _prefix_iri = Prefixed_Name(daq, "") |> PrefixedName
    /// <summary>
    ///   <para>daq:Category</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>The highest level of quality metric is a category. A category groups a number of dimensions relevant to each other which aims at measuring the quality of a dataset from different aspects. Categories are provided as subclasses of this abstract class, which is not intended for direct usage.</para>
    /// labels<para>Category</para></remarks>
    /// <seealso href="http://purl.org/eis/vocab/daq#Category">http://purl.org/eis/vocab/daq#Category</seealso>
    let Category = Prefixed_Name(daq, "Category") |> PrefixedName
    /// <summary>
    ///   <para>daq:Dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Each dimension is part of a larger group called category (See daq:Category). Each dimension has a number of metrics which are associated to it. A dimension is linked with a category using the daq:hasDimension property. Dimensions are provided as subclasses of this abstract class, which is not intended for direct usage.</para>
    /// labels<para>Dimension</para></remarks>
    /// <seealso href="http://purl.org/eis/vocab/daq#Dimension">http://purl.org/eis/vocab/daq#Dimension</seealso>
    let Dimension = Prefixed_Name(daq, "Dimension") |> PrefixedName
    /// <summary>
    ///   <para>daq:Metric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>The smallest unit of measuring a quality dimension is a metric. A metric belongs to exactly one dimension. Each metric has one or more observations (	exttt{daq:hasObservation}), which records data quality assessment value following a computation. Metrics are provided as subclasses of this abstract class, which is not intended for direct usage.</para>
    /// labels<para>Metric</para></remarks>
    /// <seealso href="http://purl.org/eis/vocab/daq#Metric">http://purl.org/eis/vocab/daq#Metric</seealso>
    let Metric = Prefixed_Name(daq, "Metric") |> PrefixedName
    /// <summary>
    ///   <para>daq:Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A quality observation represents the statistical and provenance information of the attached metric's assessment activity.</para>
    /// labels<para>Quality Observation</para></remarks>
    /// <seealso href="http://purl.org/eis/vocab/daq#Observation">http://purl.org/eis/vocab/daq#Observation</seealso>
    let Observation = Prefixed_Name(daq, "Observation") |> PrefixedName
    /// <summary>
    ///   <para>daq:QualityGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Defines a quality graph which will contain all metadata about quality metrics on the dataset.</para>
    /// labels<para>Quality Graph Statistics</para></remarks>
    /// <seealso href="http://purl.org/eis/vocab/daq#QualityGraph">http://purl.org/eis/vocab/daq#QualityGraph</seealso>
    let QualityGraph = Prefixed_Name(daq, "QualityGraph") |> PrefixedName
    /// <summary>
    ///   <para>daq:dsd</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DataStructureDefinition</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eis/vocab/daq#dsd">http://purl.org/eis/vocab/daq#dsd</seealso>
    let dsd = Prefixed_Name(daq, "dsd") |> PrefixedName
    /// <summary>
    ///   <para>daq:computedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>TODO: Define properly</para>
    /// labels<para>computed by</para></remarks>
    /// <seealso href="http://purl.org/eis/vocab/daq#computedBy">http://purl.org/eis/vocab/daq#computedBy</seealso>
    let computedBy = Prefixed_Name(daq, "computedBy") |> PrefixedName
    /// <summary>
    ///   <para>daq:computedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Quality metrics can be (in principle) calculated on various forms of data (such as datasets, graphs, set of triples etc...). This vocabulary allow the owner/user of such RDF data to calculate metrics on multiple (and different) resources.</para>
    /// labels<para>computed on</para></remarks>
    /// <seealso href="http://purl.org/eis/vocab/daq#computedOn">http://purl.org/eis/vocab/daq#computedOn</seealso>
    let computedOn = Prefixed_Name(daq, "computedOn") |> PrefixedName
    /// <summary>
    ///   <para>daq:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Each metric will have a value computed. In order to deal with the different return type of the metric computation, this property links a metric with a value object (e.g. boolean, double, Literal).</para>
    /// labels<para>value</para></remarks>
    /// <seealso href="http://purl.org/eis/vocab/daq#value">http://purl.org/eis/vocab/daq#value</seealso>
    let value = Prefixed_Name(daq, "value") |> PrefixedName
    /// <summary>
    ///   <para>daq:metric</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Represents the metric being observed.</para>
    /// labels<para>metric</para></remarks>
    /// <seealso href="http://purl.org/eis/vocab/daq#metric">http://purl.org/eis/vocab/daq#metric</seealso>
    let metric = Prefixed_Name(daq, "metric") |> PrefixedName
    /// <summary>
    ///   <para>daq:expectedDataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Each metric should have an expect data type for it's observed value (e.g. xsd:boolean, xsd:double etc...)</para>
    /// labels<para>expected data type</para></remarks>
    /// <seealso href="http://purl.org/eis/vocab/daq#expectedDataType">http://purl.org/eis/vocab/daq#expectedDataType</seealso>
    let expectedDataType = Prefixed_Name(daq, "expectedDataType") |> PrefixedName
    /// <summary>
    ///   <para>daq:hasDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The category concept classifies dimensions related to the measurement of quality for a specific criteria. This is an abstract property and should not be used directly. Specific sub-properties should be inherited for different dimensions.</para>
    /// labels<para>hasDimension</para></remarks>
    /// <seealso href="http://purl.org/eis/vocab/daq#hasDimension">http://purl.org/eis/vocab/daq#hasDimension</seealso>
    let hasDimension = Prefixed_Name(daq, "hasDimension") |> PrefixedName
    /// <summary>
    ///   <para>daq:hasMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A dimension is an abstract concept which groups an number of more concrete metrics to measure quality of a dataset. This is an abstract property and should not be used directly. Specific sub-properties should be inherited for different metrics.</para>
    /// labels<para>hasMetric</para></remarks>
    /// <seealso href="http://purl.org/eis/vocab/daq#hasMetric">http://purl.org/eis/vocab/daq#hasMetric</seealso>
    let hasMetric = Prefixed_Name(daq, "hasMetric") |> PrefixedName
    /// <summary>
    ///   <para>daq:hasObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Computed metrics can have 1 or more quality observations, where each computed resource has one observation.</para>
    /// labels<para>has observation</para></remarks>
    /// <seealso href="http://purl.org/eis/vocab/daq#hasObservation">http://purl.org/eis/vocab/daq#hasObservation</seealso>
    let hasObservation = Prefixed_Name(daq, "hasObservation") |> PrefixedName
    /// <summary>
    ///   <para>daq:isEstimate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This property flags true if an assessed observation of a metric gives an estimate result instead of a more accurate one.</para>
    /// labels<para>is estimate</para></remarks>
    /// <seealso href="http://purl.org/eis/vocab/daq#isEstimate">http://purl.org/eis/vocab/daq#isEstimate</seealso>
    let isEstimate = Prefixed_Name(daq, "isEstimate") |> PrefixedName
    /// <summary>
    ///   <para>daq:requires</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A metric might require a number of external resources (e.g. a gold standard) in order to be able to measure the quality. In order to cater for the most generic requirement, this property links a metric to the required resource (e.g. a URI to the gold standard dataset used).</para>
    /// labels<para>requires</para></remarks>
    /// <seealso href="http://purl.org/eis/vocab/daq#requires">http://purl.org/eis/vocab/daq#requires</seealso>
    let requires = Prefixed_Name(daq, "requires") |> PrefixedName
