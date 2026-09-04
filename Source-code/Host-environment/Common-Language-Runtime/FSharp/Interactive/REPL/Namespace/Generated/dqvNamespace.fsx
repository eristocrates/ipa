#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dqv =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/dqv#" "dqv"
    /// <summary>
    ///   <para>rdfs:label : Category</para>
    ///   <para>rdfs:comment : Represents a group of quality dimensions in which a common type of information is used as quality indicator.</para>
    ///   <a href="http://www.w3.org/ns/dqv#Category">dqv:Category</a>
    /// </summary>
    let Category = _prefixId.prefix "Category"
    /// <summary>
    ///   <para>rdfs:label : Dimension</para>
    ///   <para>rdfs:comment : Represents criteria relevant for assessing quality. Each quality dimension must have one or more metric to measure it. A dimension is linked with a category using the dqv:inCategory property.</para>
    ///   <a href="http://www.w3.org/ns/dqv#Dimension">dqv:Dimension</a>
    /// </summary>
    let Dimension = _prefixId.prefix "Dimension"
    /// <summary>
    ///   <para>rdfs:label : Metric</para>
    ///   <para>rdfs:comment : Represents a standard to measure a quality dimension. An observation (instance of dqv:QualityMeasurement) assigns a value in a given unit to a Metric.</para>
    ///   <a href="http://www.w3.org/ns/dqv#Metric">dqv:Metric</a>
    /// </summary>
    let Metric = _prefixId.prefix "Metric"
    /// <summary>
    ///   <para>rdfs:label : Quality Annotation</para>
    ///   <para>rdfs:comment : Represents quality annotations, including ratings, quality certificates or feedback that can be associated to datasets or distributions. Quality annotations must have one oa:motivatedBy statement with an instance of oa:Motivation (and skos:Concept) that reflects a quality assessment purpose. We define this instance as dqv:qualityAssessment.</para>
    ///   <a href="http://www.w3.org/ns/dqv#QualityAnnotation">dqv:QualityAnnotation</a>
    /// </summary>
    let QualityAnnotation = _prefixId.prefix "QualityAnnotation"
    /// <summary>
    ///   <para>rdfs:label : Quality Certificate</para>
    ///   <para>rdfs:comment : An annotation that associates a resource (especially, a dataset or a distribution) to another resource (for example, a document) that certifies the resource's quality according to a set of quality assessment rules.</para>
    ///   <a href="http://www.w3.org/ns/dqv#QualityCertificate">dqv:QualityCertificate</a>
    /// </summary>
    let QualityCertificate = _prefixId.prefix "QualityCertificate"
    /// <summary>
    ///   <para>vann:usageNote : The unit of measure in quality measurement should be specified through the property sdmx-attribute:unitMeasure as recommended by RDF Data Cube. The Ontology of units of Measure (OM) by Rijgersberg Et Al provides a list of HTTP dereferenceable unit of measures, which can be exploited as values for sdmx-attribute:unitMeasure.</para>
    ///   <para>rdfs:label : Quality Measurement</para>
    ///   <para>rdfs:comment : Represents the evaluation of a given dataset (or dataset distribution) against a specific quality metric.</para>
    ///   <a href="http://www.w3.org/ns/dqv#QualityMeasurement">dqv:QualityMeasurement</a>
    /// </summary>
    let QualityMeasurement = _prefixId.prefix "QualityMeasurement"
    /// <summary>
    ///   <para>rdfs:label : Quality Measurement Dataset</para>
    ///   <para>rdfs:comment : Represents a dataset of quality measurements, evaluations of one or more datasets (or dataset distributions) against specific quality metrics.</para>
    ///   <a href="http://www.w3.org/ns/dqv#QualityMeasurementDataset">dqv:QualityMeasurementDataset</a>
    /// </summary>
    let QualityMeasurementDataset = _prefixId.prefix "QualityMeasurementDataset"
    /// <summary>
    ///   <para>vann:usageNote : QualityMetadata containers do not necessary include all types of quality statements DQV can support. Implementers decide the granularity of containment. In the current version of DQV, we also leave open the choice of the containment technique. Implementers can use (RDF) graph containment. They may also use an appropriate property of their choice — for example (a subproperty of) dcterms:hasPart — to link instances of dqv:QualityMetadata with instances of other DQV classes.</para>
    ///   <para>rdfs:label : Quality Metadata</para>
    ///   <para>rdfs:comment : Represents quality metadata, it is defined to group quality certificates, policies, measurements and annotations under a named graph.</para>
    ///   <a href="http://www.w3.org/ns/dqv#QualityMetadata">dqv:QualityMetadata</a>
    /// </summary>
    let QualityMetadata = _prefixId.prefix "QualityMetadata"
    /// <summary>
    ///   <para>rdfs:label : Quality Policy</para>
    ///   <para>rdfs:comment : Represents a policy or agreement that is chiefly governed by data quality concerns.</para>
    ///   <a href="http://www.w3.org/ns/dqv#QualityPolicy">dqv:QualityPolicy</a>
    /// </summary>
    let QualityPolicy = _prefixId.prefix "QualityPolicy"
    /// <summary>
    ///   <para>rdfs:label : User Quality feedback</para>
    ///   <para>rdfs:comment : Represents feedback that users have on the quality of datasets or distributions. Besides dqv:qualityAssessment, which is the motivation required by all quality annotations, one of the predefined instances of oa:Motivation should be indicated as motivation to distinguish among the different kinds of feedback, e.g., classifications, questions.</para>
    ///   <a href="http://www.w3.org/ns/dqv#UserQualityFeedback">dqv:UserQualityFeedback</a>
    /// </summary>
    let UserQualityFeedback = _prefixId.prefix "UserQualityFeedback"
    /// <summary>
    ///   <para>rdfs:label : computed on</para>
    ///   <para>rdfs:comment : Refers to the resource (e.g., a dataset, a linkset, a graph, a set of triples) on which the quality measurement is performed. In the DQV context, this property is generally expected to be used in statements in which objects are instances of dcat:Dataset or dcat:Distribution.</para>
    ///   <a href="http://www.w3.org/ns/dqv#computedOn">dqv:computedOn</a>
    /// </summary>
    let computedOn = _prefixId.prefix "computedOn"
    /// <summary>
    ///   <para>rdfs:label : expected data type</para>
    ///   <para>rdfs:comment : Represents the expected data type for metric's observed value (e.g. xsd:boolean, xsd:double etc...)</para>
    ///   <a href="http://www.w3.org/ns/dqv#expectedDataType">dqv:expectedDataType</a>
    /// </summary>
    let expectedDataType = _prefixId.prefix "expectedDataType"
    /// <summary>
    ///   <para>rdfs:label : has quality annotation</para>
    ///   <para>rdfs:comment : Refers to a quality annotation. Quality annotation can be applied to any kind of resource, e.g., a dataset, a linkset, a graph, a set of triples. However, in the DQV context, this property is generally expected to be used in statements in which subjects are instances of dcat:Dataset or dcat:Distribution.</para>
    ///   <a href="http://www.w3.org/ns/dqv#hasQualityAnnotation">dqv:hasQualityAnnotation</a>
    /// </summary>
    let hasQualityAnnotation = _prefixId.prefix "hasQualityAnnotation"
    /// <summary>
    ///   <para>rdfs:label : has quality measurement</para>
    ///   <para>rdfs:comment : Refers to the performed quality measurements. Quality measurements can be performed to any kind of resource (e.g., a dataset, a linkset, a graph, a set of triples). However, in the DQV context, this property is generally expected to be used in statements in which subjects are instances of dcat:Dataset or dcat:Distribution.</para>
    ///   <a href="http://www.w3.org/ns/dqv#hasQualityMeasurement">dqv:hasQualityMeasurement</a>
    /// </summary>
    let hasQualityMeasurement = _prefixId.prefix "hasQualityMeasurement"
    /// <summary>
    ///   <para>rdfs:label : has quality metadata</para>
    ///   <para>rdfs:comment : Refers to a grouping of quality information such as certificates, policies, measurements and annotations as a named graph. Quality information represented in such a grouping can pertain to any kind of resource (e.g., a dataset, a linkset, a graph, a set of triples). However, in the DQV context, this property is generally expected to be used in statements in which subjects are instances of dcat:Dataset or dcat:Distribution.</para>
    ///   <a href="http://www.w3.org/ns/dqv#hasQualityMetadata">dqv:hasQualityMetadata</a>
    /// </summary>
    let hasQualityMetadata = _prefixId.prefix "hasQualityMetadata"
    /// <summary>
    ///   <para>vann:usageNote : Categories are meant to systematically organize dimensions. The Data Quality Vocabulary defines no specific cardinality constraints for dqv:inCategory, since distinct quality frameworks might have different perspectives over a dimension. A dimension may therefore be associated to more than one category. However, those who define new quality metrics should try to avoid this as much as possible and assign only one category to the dimensions they define.</para>
    ///   <para>rdfs:label : in category</para>
    ///   <para>rdfs:comment : Represents the category a dimension is grouped in.</para>
    ///   <a href="http://www.w3.org/ns/dqv#inCategory">dqv:inCategory</a>
    /// </summary>
    let inCategory = _prefixId.prefix "inCategory"
    /// <summary>
    ///   <para>vann:usageNote : Dimensions are meant to systematically organize metrics, quality certificates and quality annotations. The Data Quality Vocabulary defines no specific cardinality constraints for dqv:inDimension, since distinct quality frameworks might have different perspectives over a metric. A metric may therefore be associated to more than one dimension. However, those who define new quality metrics should try to avoid this as much as possible and assign only one dimension to the metrics they define. More than one dimension can be indicated for each quality annotation or certificate.</para>
    ///   <para>rdfs:label : in dimension</para>
    ///   <para>rdfs:comment : Represents the dimensions a quality metric, certificate and annotation allow a measurement of.</para>
    ///   <a href="http://www.w3.org/ns/dqv#inDimension">dqv:inDimension</a>
    /// </summary>
    let inDimension = _prefixId.prefix "inDimension"
    /// <summary>
    ///   <para>rdfs:label : is measurement of</para>
    ///   <para>rdfs:comment : Indicates the metric being observed.</para>
    ///   <a href="http://www.w3.org/ns/dqv#isMeasurementOf">dqv:isMeasurementOf</a>
    /// </summary>
    let isMeasurementOf = _prefixId.prefix "isMeasurementOf"
    let precision = _prefixId.prefix "precision"
    let qualityAssessment = _prefixId.prefix "qualityAssessment"
    /// <summary>
    ///   <para>rdfs:label : value</para>
    ///   <para>rdfs:comment : Refers to values computed by metric.</para>
    ///   <a href="http://www.w3.org/ns/dqv#value">dqv:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
