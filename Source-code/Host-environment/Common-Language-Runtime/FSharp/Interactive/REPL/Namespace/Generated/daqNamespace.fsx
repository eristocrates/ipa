#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module daq =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/eis/vocab/daq#" "daq"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Category^^xsd:string</para>
    ///   <para>rdfs:comment : The highest level of quality metric is a category. A category groups a number of dimensions relevant to each other which aims at measuring the quality of a dataset from different aspects. Categories are provided as subclasses of this abstract class, which is not intended for direct usage.^^xsd:string</para>
    ///   <a href="http://purl.org/eis/vocab/daq#Category">daq:Category</a>
    /// </summary>
    let Category = _prefixId.prefix "Category"
    /// <summary>
    ///   <para>rdfs:label : Dimension^^xsd:string</para>
    ///   <para>rdfs:comment : Each dimension is part of a larger group called category (See daq:Category). Each dimension has a number of metrics which are associated to it. A dimension is linked with a category using the daq:hasDimension property. Dimensions are provided as subclasses of this abstract class, which is not intended for direct usage.^^xsd:string</para>
    ///   <a href="http://purl.org/eis/vocab/daq#Dimension">daq:Dimension</a>
    /// </summary>
    let Dimension = _prefixId.prefix "Dimension"
    /// <summary>
    ///   <para>rdfs:label : Metric^^xsd:string</para>
    ///   <para>rdfs:comment : The smallest unit of measuring a quality dimension is a metric. A metric belongs to exactly one dimension. Each metric has one or more observations (	exttt{daq:hasObservation}), which records data quality assessment value following a computation. Metrics are provided as subclasses of this abstract class, which is not intended for direct usage.^^xsd:string</para>
    ///   <a href="http://purl.org/eis/vocab/daq#Metric">daq:Metric</a>
    /// </summary>
    let Metric = _prefixId.prefix "Metric"
    /// <summary>
    ///   <para>rdfs:label : Quality Observation^^xsd:string</para>
    ///   <para>rdfs:comment : A quality observation represents the statistical and provenance information of the attached metric's assessment activity.^^xsd:string</para>
    ///   <a href="http://purl.org/eis/vocab/daq#Observation">daq:Observation</a>
    /// </summary>
    let Observation = _prefixId.prefix "Observation"
    /// <summary>
    ///   <para>rdfs:label : Quality Graph Statistics^^xsd:string</para>
    ///   <para>rdfs:comment : Defines a quality graph which will contain all metadata about quality metrics on the dataset.^^xsd:string</para>
    ///   <a href="http://purl.org/eis/vocab/daq#QualityGraph">daq:QualityGraph</a>
    /// </summary>
    let QualityGraph = _prefixId.prefix "QualityGraph"
    /// <summary>
    ///   <para>rdfs:comment : TODO: Define properly^^xsd:string</para>
    ///   <para>rdfs:label : computed by^^xsd:string</para>
    ///   <a href="http://purl.org/eis/vocab/daq#computedBy">daq:computedBy</a>
    /// </summary>
    let computedBy = _prefixId.prefix "computedBy"
    /// <summary>
    ///   <para>rdfs:comment : Quality metrics can be (in principle) calculated on various forms of data (such as datasets, graphs, set of triples etc...). This vocabulary allow the owner/user of such RDF data to calculate metrics on multiple (and different) resources.^^xsd:string</para>
    ///   <para>rdfs:label : computed on^^xsd:string</para>
    ///   <a href="http://purl.org/eis/vocab/daq#computedOn">daq:computedOn</a>
    /// </summary>
    let computedOn = _prefixId.prefix "computedOn"
    let dsd = _prefixId.prefix "dsd"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:comment : Each metric should have an expect data type for it's observed value (e.g. xsd:boolean, xsd:double etc...)^^xsd:string</para>
    ///   <para>rdfs:label : expected data type^^xsd:string</para>
    ///   <a href="http://purl.org/eis/vocab/daq#expectedDataType">daq:expectedDataType</a>
    /// </summary>
    let expectedDataType = _prefixId.prefix "expectedDataType"
    /// <summary>
    ///   <para>rdfs:comment : The category concept classifies dimensions related to the measurement of quality for a specific criteria. This is an abstract property and should not be used directly. Specific sub-properties should be inherited for different dimensions.^^xsd:string</para>
    ///   <para>rdfs:label : hasDimension^^xsd:string</para>
    ///   <a href="http://purl.org/eis/vocab/daq#hasDimension">daq:hasDimension</a>
    /// </summary>
    let hasDimension = _prefixId.prefix "hasDimension"
    /// <summary>
    ///   <para>rdfs:comment : A dimension is an abstract concept which groups an number of more concrete metrics to measure quality of a dataset. This is an abstract property and should not be used directly. Specific sub-properties should be inherited for different metrics.^^xsd:string</para>
    ///   <para>rdfs:label : hasMetric^^xsd:string</para>
    ///   <a href="http://purl.org/eis/vocab/daq#hasMetric">daq:hasMetric</a>
    /// </summary>
    let hasMetric = _prefixId.prefix "hasMetric"
    /// <summary>
    ///   <para>owl:minCardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:comment : Computed metrics can have 1 or more quality observations, where each computed resource has one observation.^^xsd:string</para>
    ///   <para>rdfs:label : has observation^^xsd:string</para>
    ///   <a href="http://purl.org/eis/vocab/daq#hasObservation">daq:hasObservation</a>
    /// </summary>
    let hasObservation = _prefixId.prefix "hasObservation"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:comment : This property flags true if an assessed observation of a metric gives an estimate result instead of a more accurate one.^^xsd:string</para>
    ///   <para>rdfs:label : is estimate^^xsd:string</para>
    ///   <a href="http://purl.org/eis/vocab/daq#isEstimate">daq:isEstimate</a>
    /// </summary>
    let isEstimate = _prefixId.prefix "isEstimate"
    /// <summary>
    ///   <para>owl:minCardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:comment : Represents the metric being observed.^^xsd:string</para>
    ///   <para>rdfs:label : metric^^xsd:string</para>
    ///   <a href="http://purl.org/eis/vocab/daq#metric">daq:metric</a>
    /// </summary>
    let metric = _prefixId.prefix "metric"
    /// <summary>
    ///   <para>rdfs:comment : A metric might require a number of external resources (e.g. a gold standard) in order to be able to measure the quality. In order to cater for the most generic requirement, this property links a metric to the required resource (e.g. a URI to the gold standard dataset used).^^xsd:string</para>
    ///   <para>rdfs:label : requires^^xsd:string</para>
    ///   <a href="http://purl.org/eis/vocab/daq#requires">daq:requires</a>
    /// </summary>
    let requires = _prefixId.prefix "requires"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:comment : Each metric will have a value computed. In order to deal with the different return type of the metric computation, this property links a metric with a value object (e.g. boolean, double, Literal).^^xsd:string</para>
    ///   <para>rdfs:label : value^^xsd:string</para>
    ///   <a href="http://purl.org/eis/vocab/daq#value">daq:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
