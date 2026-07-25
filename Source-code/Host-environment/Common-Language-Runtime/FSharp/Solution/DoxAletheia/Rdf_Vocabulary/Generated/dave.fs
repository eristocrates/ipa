namespace http.theme_e.adaptcentre.ie.dave.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dave =
    let _namespace_iri = Namespace_Iri dave |> NamespaceIRI
    /// <summary>
    ///   <para>dave:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://theme-e.adaptcentre.ie/dave#">http://theme-e.adaptcentre.ie/dave#</seealso>
    let _prefix_iri = Prefixed_Name(dave, "") |> PrefixedName
    /// <summary>
    ///   <para>dave:Description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Describes a data value metric, including the context of use, the expected result, and the approach taken within the Metric to assess data value</para>
    /// labels<para>Metric Description</para></remarks>
    /// <seealso href="http://theme-e.adaptcentre.ie/dave#Description">http://theme-e.adaptcentre.ie/dave#Description</seealso>
    let Description = Prefixed_Name(dave, "Description") |> PrefixedName
    /// <summary>
    ///   <para>dave:DataValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Defines an aggregation of data value dimensions that characterise data value for a specific context of data use.</para>
    /// labels<para>Data Value Characterisation</para></remarks>
    /// <seealso href="http://theme-e.adaptcentre.ie/dave#DataValue">http://theme-e.adaptcentre.ie/dave#DataValue</seealso>
    let DataValue = Prefixed_Name(dave, "DataValue") |> PrefixedName
    /// <summary>
    ///   <para>dave:Metric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>This is the smallest unit of characterisation of data value. It is part of a larger group called Metric Group (See dave:MetricGroup). This concept represents metrics that are heuristics designed to fit a specific assessment situation. Metrics are provided as subclasses of this abstract class, which is not intended for direct usage.</para>
    /// labels<para>Metric</para></remarks>
    /// <seealso href="http://theme-e.adaptcentre.ie/dave#Metric">http://theme-e.adaptcentre.ie/dave#Metric</seealso>
    let Metric = Prefixed_Name(dave, "Metric") |> PrefixedName
    /// <summary>
    ///   <para>dave:Toolset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Identifies a specific framework or toolset that implements data value metrics</para>
    /// labels<para>Framework or Toolset</para></remarks>
    /// <seealso href="http://theme-e.adaptcentre.ie/dave#Toolset">http://theme-e.adaptcentre.ie/dave#Toolset</seealso>
    let Toolset = Prefixed_Name(dave, "Toolset") |> PrefixedName
    /// <summary>
    ///   <para>dave:MetricGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A metric group is the second level of characterisation of data value, and represents a group of metrics that are related to each other, e.g. by being a recognised set of independent proxies for a given data value dimension. Each Metric Group is a part of a larger group called dimension (See dave:Dimension). MetricGroups are provided as subclasses of this abstract class, which is not intended for direct usage.</para>
    /// labels<para>Metric Groups</para></remarks>
    /// <seealso href="http://theme-e.adaptcentre.ie/dave#MetricGroup">http://theme-e.adaptcentre.ie/dave#MetricGroup</seealso>
    let MetricGroup = Prefixed_Name(dave, "MetricGroup") |> PrefixedName
    /// <summary>
    ///   <para>dave:computedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>This property indicates the data resource or dataset that is being analysed using a Data Value metric.</para>
    /// labels<para>computed on</para></remarks>
    /// <seealso href="http://theme-e.adaptcentre.ie/dave#computedOn">http://theme-e.adaptcentre.ie/dave#computedOn</seealso>
    let computedOn = Prefixed_Name(dave, "computedOn") |> PrefixedName
    /// <summary>
    ///   <para>dave:hasDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This property will link a metric with its relevant description.</para>
    /// labels<para>has Description</para></remarks>
    /// <seealso href="http://theme-e.adaptcentre.ie/dave#hasDescription">http://theme-e.adaptcentre.ie/dave#hasDescription</seealso>
    let hasDescription = Prefixed_Name(dave, "hasDescription") |> PrefixedName
    /// <summary>
    ///   <para>dave:hasValueGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This property will link a Dimension (dave:Dimension) to data metric groups (dave:MetricGroup).</para>
    /// labels<para>has Value Group</para></remarks>
    /// <seealso href="http://theme-e.adaptcentre.ie/dave#hasValueGroup">http://theme-e.adaptcentre.ie/dave#hasValueGroup</seealso>
    let hasValueGroup = Prefixed_Name(dave, "hasValueGroup") |> PrefixedName
    /// <summary>
    ///   <para>dave:implementsMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property will link a toolset to any metrics it implements.</para>
    /// labels<para>Implements Metric</para></remarks>
    /// <seealso href="http://theme-e.adaptcentre.ie/dave#implementsMetric">http://theme-e.adaptcentre.ie/dave#implementsMetric</seealso>
    let implementsMetric = Prefixed_Name(dave, "implementsMetric") |> PrefixedName
    /// <summary>
    ///   <para>dave:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Each metric will return a quantification of value. Since there will be different return types for different metrics, this property will link a metric with a value object, including boolean, double, literal, etc.</para>
    /// labels<para>has Value</para></remarks>
    /// <seealso href="http://theme-e.adaptcentre.ie/dave#hasValue">http://theme-e.adaptcentre.ie/dave#hasValue</seealso>
    let hasValue = Prefixed_Name(dave, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>dave:hasValueDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This property will link a Data Value object (dave:DataValue) to any data value dimensions it contains. </para>
    /// labels<para>has Value Dimension</para></remarks>
    /// <seealso href="http://theme-e.adaptcentre.ie/dave#hasValueDimension">http://theme-e.adaptcentre.ie/dave#hasValueDimension</seealso>
    let hasValueDimension = Prefixed_Name(dave, "hasValueDimension") |> PrefixedName
    /// <summary>
    ///   <para>dave:hasValueMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This property provides a link between a metric, and any number of measurements for the implementation of this metric.</para>
    /// labels<para>has Value Measurement</para></remarks>
    /// <seealso href="http://theme-e.adaptcentre.ie/dave#hasValueMeasurement">http://theme-e.adaptcentre.ie/dave#hasValueMeasurement</seealso>
    let hasValueMeasurement = Prefixed_Name(dave, "hasValueMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>dave:hasValueMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This property will link a data metric group (dave:MetricGroup) to the related metrics (dave:Metric).</para>
    /// labels<para>has Value Metric</para></remarks>
    /// <seealso href="http://theme-e.adaptcentre.ie/dave#hasValueMetric">http://theme-e.adaptcentre.ie/dave#hasValueMetric</seealso>
    let hasValueMetric = Prefixed_Name(dave, "hasValueMetric") |> PrefixedName
    /// <summary>
    ///   <para>dave:relevantToDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This property indicates the data resource or dataset that the data value metadata describes.</para>
    /// labels<para>Relevant to Dataset</para></remarks>
    /// <seealso href="http://theme-e.adaptcentre.ie/dave#relevantToDataset">http://theme-e.adaptcentre.ie/dave#relevantToDataset</seealso>
    let relevantToDataset = Prefixed_Name(dave, "relevantToDataset") |> PrefixedName
    /// <summary>
    ///   <para>dave:ValueMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Contains the measurement (quantification) of a data value metric for assessing a data resource or dataset, as well as details about the assessment execution.</para>
    /// labels<para>Value Measurement</para></remarks>
    /// <seealso href="http://theme-e.adaptcentre.ie/dave#ValueMeasurement">http://theme-e.adaptcentre.ie/dave#ValueMeasurement</seealso>
    let ValueMeasurement = Prefixed_Name(dave, "ValueMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>dave:title</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://theme-e.adaptcentre.ie/dave#title">http://theme-e.adaptcentre.ie/dave#title</seealso>
    let title = Prefixed_Name(dave, "title") |> PrefixedName
    /// <summary>
    ///   <para>dave:Dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>This represents the highest level of the characterisation of data value. A Dimension contains a number of data value Metric Groups. Dimensions are provided as subclasses of this abstract class, which is not intended for direct usage.</para>
    /// labels<para>Dimension</para></remarks>
    /// <seealso href="http://theme-e.adaptcentre.ie/dave#Dimension">http://theme-e.adaptcentre.ie/dave#Dimension</seealso>
    let Dimension = Prefixed_Name(dave, "Dimension") |> PrefixedName
