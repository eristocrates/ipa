#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dave =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://theme-e.adaptcentre.ie/dave#" "dave"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Data Value Characterisation</para>
    ///   <para>rdfs:comment : Defines an aggregation of data value dimensions that characterise data value for a specific context of data use.</para>
    ///   <a href="http://theme-e.adaptcentre.ie/dave#DataValue">dave:DataValue</a>
    /// </summary>
    let DataValue = _prefixId.prefix "DataValue"
    /// <summary>
    ///   <para>rdfs:label : Metric Description</para>
    ///   <para>rdfs:comment : Describes a data value metric, including the context of use, the expected result, and the approach taken within the Metric to assess data value</para>
    ///   <a href="http://theme-e.adaptcentre.ie/dave#Description">dave:Description</a>
    /// </summary>
    let Description = _prefixId.prefix "Description"
    /// <summary>
    ///   <para>rdfs:label : Dimension</para>
    ///   <para>rdfs:comment : This represents the highest level of the characterisation of data value. A Dimension contains a number of data value Metric Groups. Dimensions are provided as subclasses of this abstract class, which is not intended for direct usage.</para>
    ///   <a href="http://theme-e.adaptcentre.ie/dave#Dimension">dave:Dimension</a>
    /// </summary>
    let Dimension = _prefixId.prefix "Dimension"
    /// <summary>
    ///   <para>rdfs:label : Metric</para>
    ///   <para>rdfs:comment : This is the smallest unit of characterisation of data value. It is part of a larger group called Metric Group (See dave:MetricGroup). This concept represents metrics that are heuristics designed to fit a specific assessment situation. Metrics are provided as subclasses of this abstract class, which is not intended for direct usage.</para>
    ///   <a href="http://theme-e.adaptcentre.ie/dave#Metric">dave:Metric</a>
    /// </summary>
    let Metric = _prefixId.prefix "Metric"
    /// <summary>
    ///   <para>rdfs:label : Metric Groups</para>
    ///   <para>rdfs:comment : A metric group is the second level of characterisation of data value, and represents a group of metrics that are related to each other, e.g. by being a recognised set of independent proxies for a given data value dimension. Each Metric Group is a part of a larger group called dimension (See dave:Dimension). MetricGroups are provided as subclasses of this abstract class, which is not intended for direct usage.</para>
    ///   <a href="http://theme-e.adaptcentre.ie/dave#MetricGroup">dave:MetricGroup</a>
    /// </summary>
    let MetricGroup = _prefixId.prefix "MetricGroup"
    /// <summary>
    ///   <para>rdfs:label : Framework or Toolset</para>
    ///   <para>rdfs:comment : Identifies a specific framework or toolset that implements data value metrics</para>
    ///   <a href="http://theme-e.adaptcentre.ie/dave#Toolset">dave:Toolset</a>
    /// </summary>
    let Toolset = _prefixId.prefix "Toolset"
    /// <summary>
    ///   <para>rdfs:label : Value Measurement</para>
    ///   <para>rdfs:comment : Contains the measurement (quantification) of a data value metric for assessing a data resource or dataset, as well as details about the assessment execution.</para>
    ///   <a href="http://theme-e.adaptcentre.ie/dave#ValueMeasurement">dave:ValueMeasurement</a>
    /// </summary>
    let ValueMeasurement = _prefixId.prefix "ValueMeasurement"
    /// <summary>
    ///   <para>rdfs:label : computed on</para>
    ///   <para>rdfs:comment : This property indicates the data resource or dataset that is being analysed using a Data Value metric.</para>
    ///   <a href="http://theme-e.adaptcentre.ie/dave#computedOn">dave:computedOn</a>
    /// </summary>
    let computedOn = _prefixId.prefix "computedOn"
    /// <summary>
    ///   <para>rdfs:label : has Description</para>
    ///   <para>rdfs:comment : This property will link a metric with its relevant description.</para>
    ///   <a href="http://theme-e.adaptcentre.ie/dave#hasDescription">dave:hasDescription</a>
    /// </summary>
    let hasDescription = _prefixId.prefix "hasDescription"
    /// <summary>
    ///   <para>rdfs:label : has Value</para>
    ///   <para>rdfs:comment : Each metric will return a quantification of value. Since there will be different return types for different metrics, this property will link a metric with a value object, including boolean, double, literal, etc.</para>
    ///   <a href="http://theme-e.adaptcentre.ie/dave#hasValue">dave:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:label : has Value Dimension</para>
    ///   <para>rdfs:comment : This property will link a Data Value object (dave:DataValue) to any data value dimensions it contains. </para>
    ///   <a href="http://theme-e.adaptcentre.ie/dave#hasValueDimension">dave:hasValueDimension</a>
    /// </summary>
    let hasValueDimension = _prefixId.prefix "hasValueDimension"
    /// <summary>
    ///   <para>rdfs:label : has Value Group</para>
    ///   <para>rdfs:comment : This property will link a Dimension (dave:Dimension) to data metric groups (dave:MetricGroup).</para>
    ///   <a href="http://theme-e.adaptcentre.ie/dave#hasValueGroup">dave:hasValueGroup</a>
    /// </summary>
    let hasValueGroup = _prefixId.prefix "hasValueGroup"
    /// <summary>
    ///   <para>rdfs:label : has Value Measurement</para>
    ///   <para>rdfs:comment : This property provides a link between a metric, and any number of measurements for the implementation of this metric.</para>
    ///   <a href="http://theme-e.adaptcentre.ie/dave#hasValueMeasurement">dave:hasValueMeasurement</a>
    /// </summary>
    let hasValueMeasurement = _prefixId.prefix "hasValueMeasurement"
    /// <summary>
    ///   <para>rdfs:label : has Value Metric</para>
    ///   <para>rdfs:comment : This property will link a data metric group (dave:MetricGroup) to the related metrics (dave:Metric).</para>
    ///   <a href="http://theme-e.adaptcentre.ie/dave#hasValueMetric">dave:hasValueMetric</a>
    /// </summary>
    let hasValueMetric = _prefixId.prefix "hasValueMetric"
    /// <summary>
    ///   <para>rdfs:label : Implements Metric</para>
    ///   <para>rdfs:comment : This property will link a toolset to any metrics it implements.</para>
    ///   <a href="http://theme-e.adaptcentre.ie/dave#implementsMetric">dave:implementsMetric</a>
    /// </summary>
    let implementsMetric = _prefixId.prefix "implementsMetric"
    /// <summary>
    ///   <para>rdfs:label : Relevant to Dataset</para>
    ///   <para>rdfs:comment : This property indicates the data resource or dataset that the data value metadata describes.</para>
    ///   <a href="http://theme-e.adaptcentre.ie/dave#relevantToDataset">dave:relevantToDataset</a>
    /// </summary>
    let relevantToDataset = _prefixId.prefix "relevantToDataset"
    let title = _prefixId.prefix "title"
