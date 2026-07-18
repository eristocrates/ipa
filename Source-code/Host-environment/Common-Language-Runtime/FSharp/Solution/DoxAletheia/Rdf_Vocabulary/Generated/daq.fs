namespace http.purl.org.eis.vocab.daq.hash

open DoxAletheia.Rdf_Vocabulary

module daq =
    let _namespace_name = "http://purl.org/eis/vocab/daq#"
    /// <summary>
    /// The highest level of quality metric is a category. A category groups a number of dimensions relevant to each other which aims at measuring the quality of a dataset from different aspects. Categories are provided as subclasses of this abstract class, which is not intended for direct usage.
    /// <see href="http://purl.org/eis/vocab/daq#Category"></see></summary>
    let Category = Namespaced_IRI.parse _namespace_name "Category" |> NamespacedName
    /// <summary>
    /// Each dimension is part of a larger group called category (See daq:Category). Each dimension has a number of metrics which are associated to it. A dimension is linked with a category using the daq:hasDimension property. Dimensions are provided as subclasses of this abstract class, which is not intended for direct usage.
    /// <see href="http://purl.org/eis/vocab/daq#Dimension"></see></summary>
    let Dimension = Namespaced_IRI.parse _namespace_name "Dimension" |> NamespacedName
    /// <summary>
    /// The smallest unit of measuring a quality dimension is a metric. A metric belongs to exactly one dimension. Each metric has one or more observations (	exttt{daq:hasObservation}), which records data quality assessment value following a computation. Metrics are provided as subclasses of this abstract class, which is not intended for direct usage.
    /// <see href="http://purl.org/eis/vocab/daq#Metric"></see></summary>
    let Metric = Namespaced_IRI.parse _namespace_name "Metric" |> NamespacedName

    /// <summary>
    /// A quality observation represents the statistical and provenance information of the attached metric's assessment activity.
    /// <see href="http://purl.org/eis/vocab/daq#Observation"></see></summary>
    let Observation =
        Namespaced_IRI.parse _namespace_name "Observation" |> NamespacedName

    /// <summary>
    /// Defines a quality graph which will contain all metadata about quality metrics on the dataset.
    /// <see href="http://purl.org/eis/vocab/daq#QualityGraph"></see></summary>
    let QualityGraph =
        Namespaced_IRI.parse _namespace_name "QualityGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eis/vocab/daq#dsd"></see>
    /// </summary>
    let dsd = Namespaced_IRI.parse _namespace_name "dsd" |> NamespacedName
    /// <summary>
    /// TODO: Define properly
    /// <see href="http://purl.org/eis/vocab/daq#computedBy"></see></summary>
    let computedBy = Namespaced_IRI.parse _namespace_name "computedBy" |> NamespacedName
    /// <summary>
    /// Quality metrics can be (in principle) calculated on various forms of data (such as datasets, graphs, set of triples etc...). This vocabulary allow the owner/user of such RDF data to calculate metrics on multiple (and different) resources.
    /// <see href="http://purl.org/eis/vocab/daq#computedOn"></see></summary>
    let computedOn = Namespaced_IRI.parse _namespace_name "computedOn" |> NamespacedName
    /// <summary>
    /// Each metric will have a value computed. In order to deal with the different return type of the metric computation, this property links a metric with a value object (e.g. boolean, double, Literal).
    /// <see href="http://purl.org/eis/vocab/daq#value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
    /// <summary>
    /// Represents the metric being observed.
    /// <see href="http://purl.org/eis/vocab/daq#metric"></see></summary>
    let metric = Namespaced_IRI.parse _namespace_name "metric" |> NamespacedName

    /// <summary>
    /// Each metric should have an expect data type for it's observed value (e.g. xsd:boolean, xsd:double etc...)
    /// <see href="http://purl.org/eis/vocab/daq#expectedDataType"></see></summary>
    let expectedDataType =
        Namespaced_IRI.parse _namespace_name "expectedDataType" |> NamespacedName

    /// <summary>
    /// The category concept classifies dimensions related to the measurement of quality for a specific criteria. This is an abstract property and should not be used directly. Specific sub-properties should be inherited for different dimensions.
    /// <see href="http://purl.org/eis/vocab/daq#hasDimension"></see></summary>
    let hasDimension =
        Namespaced_IRI.parse _namespace_name "hasDimension" |> NamespacedName

    /// <summary>
    /// A dimension is an abstract concept which groups an number of more concrete metrics to measure quality of a dataset. This is an abstract property and should not be used directly. Specific sub-properties should be inherited for different metrics.
    /// <see href="http://purl.org/eis/vocab/daq#hasMetric"></see></summary>
    let hasMetric = Namespaced_IRI.parse _namespace_name "hasMetric" |> NamespacedName

    /// <summary>
    /// Computed metrics can have 1 or more quality observations, where each computed resource has one observation.
    /// <see href="http://purl.org/eis/vocab/daq#hasObservation"></see></summary>
    let hasObservation =
        Namespaced_IRI.parse _namespace_name "hasObservation" |> NamespacedName

    /// <summary>
    /// This property flags true if an assessed observation of a metric gives an estimate result instead of a more accurate one.
    /// <see href="http://purl.org/eis/vocab/daq#isEstimate"></see></summary>
    let isEstimate = Namespaced_IRI.parse _namespace_name "isEstimate" |> NamespacedName
    /// <summary>
    /// A metric might require a number of external resources (e.g. a gold standard) in order to be able to measure the quality. In order to cater for the most generic requirement, this property links a metric to the required resource (e.g. a URI to the gold standard dataset used).
    /// <see href="http://purl.org/eis/vocab/daq#requires"></see></summary>
    let requires = Namespaced_IRI.parse _namespace_name "requires" |> NamespacedName
