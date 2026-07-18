namespace http.theme_e.adaptcentre.ie.dave.hash

open DoxAletheia.Rdf_Vocabulary

module dave =
    let _namespace_name = "http://theme-e.adaptcentre.ie/dave#"

    /// <summary>
    /// Contains the measurement (quantification) of a data value metric for assessing a data resource or dataset, as well as details about the assessment execution.
    /// <see href="http://theme-e.adaptcentre.ie/dave#ValueMeasurement"></see></summary>
    let ValueMeasurement =
        Namespaced_IRI.parse _namespace_name "ValueMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://theme-e.adaptcentre.ie/dave#title"></see>
    /// </summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    /// Defines an aggregation of data value dimensions that characterise data value for a specific context of data use.
    /// <see href="http://theme-e.adaptcentre.ie/dave#DataValue"></see></summary>
    let DataValue = Namespaced_IRI.parse _namespace_name "DataValue" |> NamespacedName

    /// <summary>
    /// Describes a data value metric, including the context of use, the expected result, and the approach taken within the Metric to assess data value
    /// <see href="http://theme-e.adaptcentre.ie/dave#Description"></see></summary>
    let Description =
        Namespaced_IRI.parse _namespace_name "Description" |> NamespacedName

    /// <summary>
    /// This represents the highest level of the characterisation of data value. A Dimension contains a number of data value Metric Groups. Dimensions are provided as subclasses of this abstract class, which is not intended for direct usage.
    /// <see href="http://theme-e.adaptcentre.ie/dave#Dimension"></see></summary>
    let Dimension = Namespaced_IRI.parse _namespace_name "Dimension" |> NamespacedName
    /// <summary>
    /// This is the smallest unit of characterisation of data value. It is part of a larger group called Metric Group (See dave:MetricGroup). This concept represents metrics that are heuristics designed to fit a specific assessment situation. Metrics are provided as subclasses of this abstract class, which is not intended for direct usage.
    /// <see href="http://theme-e.adaptcentre.ie/dave#Metric"></see></summary>
    let Metric = Namespaced_IRI.parse _namespace_name "Metric" |> NamespacedName

    /// <summary>
    /// A metric group is the second level of characterisation of data value, and represents a group of metrics that are related to each other, e.g. by being a recognised set of independent proxies for a given data value dimension. Each Metric Group is a part of a larger group called dimension (See dave:Dimension). MetricGroups are provided as subclasses of this abstract class, which is not intended for direct usage.
    /// <see href="http://theme-e.adaptcentre.ie/dave#MetricGroup"></see></summary>
    let MetricGroup =
        Namespaced_IRI.parse _namespace_name "MetricGroup" |> NamespacedName

    /// <summary>
    /// Identifies a specific framework or toolset that implements data value metrics
    /// <see href="http://theme-e.adaptcentre.ie/dave#Toolset"></see></summary>
    let Toolset = Namespaced_IRI.parse _namespace_name "Toolset" |> NamespacedName
    /// <summary>
    /// This property indicates the data resource or dataset that is being analysed using a Data Value metric.
    /// <see href="http://theme-e.adaptcentre.ie/dave#computedOn"></see></summary>
    let computedOn = Namespaced_IRI.parse _namespace_name "computedOn" |> NamespacedName
    /// <summary>
    /// Each metric will return a quantification of value. Since there will be different return types for different metrics, this property will link a metric with a value object, including boolean, double, literal, etc.
    /// <see href="http://theme-e.adaptcentre.ie/dave#hasValue"></see></summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName

    /// <summary>
    /// This property will link a metric with its relevant description.
    /// <see href="http://theme-e.adaptcentre.ie/dave#hasDescription"></see></summary>
    let hasDescription =
        Namespaced_IRI.parse _namespace_name "hasDescription" |> NamespacedName

    /// <summary>
    /// This property will link a Data Value object (dave:DataValue) to any data value dimensions it contains.
    /// <see href="http://theme-e.adaptcentre.ie/dave#hasValueDimension"></see></summary>
    let hasValueDimension =
        Namespaced_IRI.parse _namespace_name "hasValueDimension" |> NamespacedName

    /// <summary>
    /// This property will link a Dimension (dave:Dimension) to data metric groups (dave:MetricGroup).
    /// <see href="http://theme-e.adaptcentre.ie/dave#hasValueGroup"></see></summary>
    let hasValueGroup =
        Namespaced_IRI.parse _namespace_name "hasValueGroup" |> NamespacedName

    /// <summary>
    /// This property provides a link between a metric, and any number of measurements for the implementation of this metric.
    /// <see href="http://theme-e.adaptcentre.ie/dave#hasValueMeasurement"></see></summary>
    let hasValueMeasurement =
        Namespaced_IRI.parse _namespace_name "hasValueMeasurement" |> NamespacedName

    /// <summary>
    /// This property will link a data metric group (dave:MetricGroup) to the related metrics (dave:Metric).
    /// <see href="http://theme-e.adaptcentre.ie/dave#hasValueMetric"></see></summary>
    let hasValueMetric =
        Namespaced_IRI.parse _namespace_name "hasValueMetric" |> NamespacedName

    /// <summary>
    /// This property will link a toolset to any metrics it implements.
    /// <see href="http://theme-e.adaptcentre.ie/dave#implementsMetric"></see></summary>
    let implementsMetric =
        Namespaced_IRI.parse _namespace_name "implementsMetric" |> NamespacedName

    /// <summary>
    /// This property indicates the data resource or dataset that the data value metadata describes.
    /// <see href="http://theme-e.adaptcentre.ie/dave#relevantToDataset"></see></summary>
    let relevantToDataset =
        Namespaced_IRI.parse _namespace_name "relevantToDataset" |> NamespacedName
