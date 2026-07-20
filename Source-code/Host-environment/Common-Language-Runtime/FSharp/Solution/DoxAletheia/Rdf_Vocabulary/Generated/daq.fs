namespace http.purl.org.eis.vocab.daq.hash

open DoxAletheia

module daq =
    let _namespace_name = "http://purl.org/eis/vocab/daq#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The highest level of quality metric is a category. A category groups a number of dimensions relevant to each other which aims at measuring the quality of a dataset from different aspects. Categories are provided as subclasses of this abstract class, which is not intended for direct usage.
    /// <see href="http://purl.org/eis/vocab/daq#Category"></see></summary>
    let Category = _prefix "Category"
    /// <summary>
    /// Each dimension is part of a larger group called category (See daq:Category). Each dimension has a number of metrics which are associated to it. A dimension is linked with a category using the daq:hasDimension property. Dimensions are provided as subclasses of this abstract class, which is not intended for direct usage.
    /// <see href="http://purl.org/eis/vocab/daq#Dimension"></see></summary>
    let Dimension = _prefix "Dimension"
    /// <summary>
    /// The smallest unit of measuring a quality dimension is a metric. A metric belongs to exactly one dimension. Each metric has one or more observations (	exttt{daq:hasObservation}), which records data quality assessment value following a computation. Metrics are provided as subclasses of this abstract class, which is not intended for direct usage.
    /// <see href="http://purl.org/eis/vocab/daq#Metric"></see></summary>
    let Metric = _prefix "Metric"
    /// <summary>
    /// A quality observation represents the statistical and provenance information of the attached metric's assessment activity.
    /// <see href="http://purl.org/eis/vocab/daq#Observation"></see></summary>
    let Observation = _prefix "Observation"
    /// <summary>
    /// Defines a quality graph which will contain all metadata about quality metrics on the dataset.
    /// <see href="http://purl.org/eis/vocab/daq#QualityGraph"></see></summary>
    let QualityGraph = _prefix "QualityGraph"
    /// <summary>
    ///   <see href="http://purl.org/eis/vocab/daq#dsd"></see>
    /// </summary>
    let dsd = _prefix "dsd"
    /// <summary>
    /// TODO: Define properly
    /// <see href="http://purl.org/eis/vocab/daq#computedBy"></see></summary>
    let computedBy = _prefix "computedBy"
    /// <summary>
    /// Quality metrics can be (in principle) calculated on various forms of data (such as datasets, graphs, set of triples etc...). This vocabulary allow the owner/user of such RDF data to calculate metrics on multiple (and different) resources.
    /// <see href="http://purl.org/eis/vocab/daq#computedOn"></see></summary>
    let computedOn = _prefix "computedOn"
    /// <summary>
    /// Each metric will have a value computed. In order to deal with the different return type of the metric computation, this property links a metric with a value object (e.g. boolean, double, Literal).
    /// <see href="http://purl.org/eis/vocab/daq#value"></see></summary>
    let value = _prefix "value"
    /// <summary>
    /// Represents the metric being observed.
    /// <see href="http://purl.org/eis/vocab/daq#metric"></see></summary>
    let metric = _prefix "metric"
    /// <summary>
    /// Each metric should have an expect data type for it's observed value (e.g. xsd:boolean, xsd:double etc...)
    /// <see href="http://purl.org/eis/vocab/daq#expectedDataType"></see></summary>
    let expectedDataType = _prefix "expectedDataType"
    /// <summary>
    /// The category concept classifies dimensions related to the measurement of quality for a specific criteria. This is an abstract property and should not be used directly. Specific sub-properties should be inherited for different dimensions.
    /// <see href="http://purl.org/eis/vocab/daq#hasDimension"></see></summary>
    let hasDimension = _prefix "hasDimension"
    /// <summary>
    /// A dimension is an abstract concept which groups an number of more concrete metrics to measure quality of a dataset. This is an abstract property and should not be used directly. Specific sub-properties should be inherited for different metrics.
    /// <see href="http://purl.org/eis/vocab/daq#hasMetric"></see></summary>
    let hasMetric = _prefix "hasMetric"
    /// <summary>
    /// Computed metrics can have 1 or more quality observations, where each computed resource has one observation.
    /// <see href="http://purl.org/eis/vocab/daq#hasObservation"></see></summary>
    let hasObservation = _prefix "hasObservation"
    /// <summary>
    /// This property flags true if an assessed observation of a metric gives an estimate result instead of a more accurate one.
    /// <see href="http://purl.org/eis/vocab/daq#isEstimate"></see></summary>
    let isEstimate = _prefix "isEstimate"
    /// <summary>
    /// A metric might require a number of external resources (e.g. a gold standard) in order to be able to measure the quality. In order to cater for the most generic requirement, this property links a metric to the required resource (e.g. a URI to the gold standard dataset used).
    /// <see href="http://purl.org/eis/vocab/daq#requires"></see></summary>
    let requires = _prefix "requires"
