namespace http.www.w3.org.ns.dqv.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dqv =
    let _namespace_iri = Namespace_Iri dqv |> NamespaceIRI
    /// <summary>
    ///   <para>dqv:Category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a group of quality dimensions in which a common type of information is used as quality indicator."</para>
    /// labels<para>"Category"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#Category">http://www.w3.org/ns/dqv#Category</seealso>
    let Category = Prefixed_Name(dqv, "Category") |> PrefixedName
    /// <summary>
    ///   <para>dqv:Dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents criteria relevant for assessing quality. Each quality dimension must have one or more metric to measure it. A dimension is linked with a category using the dqv:inCategory property."</para>
    /// labels<para>"Dimension"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#Dimension">http://www.w3.org/ns/dqv#Dimension</seealso>
    let Dimension = Prefixed_Name(dqv, "Dimension") |> PrefixedName
    /// <summary>
    ///   <para>dqv:Metric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a standard to measure a quality dimension. An observation (instance of dqv:QualityMeasurement) assigns a value in a given unit to a Metric."</para>
    /// labels<para>"Metric"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#Metric">http://www.w3.org/ns/dqv#Metric</seealso>
    let Metric = Prefixed_Name(dqv, "Metric") |> PrefixedName
    /// <summary>
    ///   <para>dqv:QualityAnnotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Represents quality annotations, including ratings, quality certificates or feedback that can be associated to datasets or distributions. Quality annotations must have one oa:motivatedBy statement with an instance of oa:Motivation (and skos:Concept) that reflects a quality assessment purpose. We define this instance as dqv:qualityAssessment."</para>
    /// labels<para>"Quality Annotation"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#QualityAnnotation">http://www.w3.org/ns/dqv#QualityAnnotation</seealso>
    let QualityAnnotation = Prefixed_Name(dqv, "QualityAnnotation") |> PrefixedName
    /// <summary>
    ///   <para>dqv:QualityCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An annotation that associates a resource (especially, a dataset or a distribution) to another resource (for example, a document) that certifies the resource's quality according to a set of quality assessment rules."</para>
    /// labels<para>"Quality Certificate"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#QualityCertificate">http://www.w3.org/ns/dqv#QualityCertificate</seealso>
    let QualityCertificate = Prefixed_Name(dqv, "QualityCertificate") |> PrefixedName
    /// <summary>
    ///   <para>dqv:QualityMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents the evaluation of a given dataset (or dataset distribution) against a specific quality metric."</para>
    /// labels<para>"Quality Measurement"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#QualityMeasurement">http://www.w3.org/ns/dqv#QualityMeasurement</seealso>
    let QualityMeasurement = Prefixed_Name(dqv, "QualityMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>dqv:QualityMeasurementDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a dataset of quality measurements, evaluations of one or more datasets (or dataset distributions) against specific quality metrics."</para>
    /// labels<para>"Quality Measurement Dataset"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#QualityMeasurementDataset">http://www.w3.org/ns/dqv#QualityMeasurementDataset</seealso>
    let QualityMeasurementDataset =
        Prefixed_Name(dqv, "QualityMeasurementDataset") |> PrefixedName

    /// <summary>
    ///   <para>dqv:QualityMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Represents quality metadata, it is defined to group quality certificates, policies, measurements and annotations under a named graph."</para>
    /// labels<para>"Quality Metadata"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#QualityMetadata">http://www.w3.org/ns/dqv#QualityMetadata</seealso>
    let QualityMetadata = Prefixed_Name(dqv, "QualityMetadata") |> PrefixedName
    /// <summary>
    ///   <para>dqv:QualityPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a policy or agreement that is chiefly governed by data quality concerns."</para>
    /// labels<para>"Quality Policy"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#QualityPolicy">http://www.w3.org/ns/dqv#QualityPolicy</seealso>
    let QualityPolicy = Prefixed_Name(dqv, "QualityPolicy") |> PrefixedName
    /// <summary>
    ///   <para>dqv:UserQualityFeedback</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Represents feedback that users have on the quality of datasets or distributions. Besides dqv:qualityAssessment, which is the motivation required by all quality annotations, one of the predefined instances of oa:Motivation should be indicated as motivation to distinguish among the different kinds of feedback, e.g., classifications, questions."</para>
    /// labels<para>"User Quality feedback"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#UserQualityFeedback">http://www.w3.org/ns/dqv#UserQualityFeedback</seealso>
    let UserQualityFeedback = Prefixed_Name(dqv, "UserQualityFeedback") |> PrefixedName
    /// <summary>
    ///   <para>dqv:computedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Refers to the resource (e.g., a dataset, a linkset, a graph, a set of triples) on which the quality measurement is performed. In the DQV context, this property is generally expected to be used in statements in which objects are instances of dcat:Dataset or dcat:Distribution."</para>
    /// labels<para>"computed on"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#computedOn">http://www.w3.org/ns/dqv#computedOn</seealso>
    let computedOn = Prefixed_Name(dqv, "computedOn") |> PrefixedName
    /// <summary>
    ///   <para>dqv:expectedDataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Represents the expected data type for metric's observed value (e.g. xsd:boolean, xsd:double etc...)"</para>
    /// labels<para>"expected data type"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#expectedDataType">http://www.w3.org/ns/dqv#expectedDataType</seealso>
    let expectedDataType = Prefixed_Name(dqv, "expectedDataType") |> PrefixedName

    /// <summary>
    ///   <para>dqv:hasQualityAnnotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Refers to a quality annotation. Quality annotation can be applied to any kind of resource, e.g., a dataset, a linkset, a graph, a set of triples. However, in the DQV context, this property is generally expected to be used in statements in which subjects are instances of dcat:Dataset or dcat:Distribution."</para>
    /// labels<para>"has quality annotation"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#hasQualityAnnotation">http://www.w3.org/ns/dqv#hasQualityAnnotation</seealso>
    let hasQualityAnnotation =
        Prefixed_Name(dqv, "hasQualityAnnotation") |> PrefixedName

    /// <summary>
    ///   <para>dqv:hasQualityMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Refers to the performed quality measurements. Quality measurements can be performed to any kind of resource (e.g., a dataset, a linkset, a graph, a set of triples). However, in the DQV context, this property is generally expected to be used in statements in which subjects are instances of dcat:Dataset or dcat:Distribution."</para>
    /// labels<para>"has quality measurement"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#hasQualityMeasurement">http://www.w3.org/ns/dqv#hasQualityMeasurement</seealso>
    let hasQualityMeasurement =
        Prefixed_Name(dqv, "hasQualityMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>dqv:hasQualityMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Refers to a grouping of quality information such as certificates, policies, measurements and annotations as a named graph. Quality information represented in such a grouping can pertain to any kind of resource (e.g., a dataset, a linkset, a graph, a set of triples). However, in the DQV context, this property is generally expected to be used in statements in which subjects are instances of dcat:Dataset or dcat:Distribution."</para>
    /// labels<para>"has quality metadata"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#hasQualityMetadata">http://www.w3.org/ns/dqv#hasQualityMetadata</seealso>
    let hasQualityMetadata = Prefixed_Name(dqv, "hasQualityMetadata") |> PrefixedName
    /// <summary>
    ///   <para>dqv:inCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Represents the category a dimension is grouped in."</para>
    /// labels<para>"in category"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#inCategory">http://www.w3.org/ns/dqv#inCategory</seealso>
    let inCategory = Prefixed_Name(dqv, "inCategory") |> PrefixedName
    /// <summary>
    ///   <para>dqv:inDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Represents the dimensions a quality metric, certificate and annotation allow a measurement of."</para>
    /// labels<para>"in dimension"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#inDimension">http://www.w3.org/ns/dqv#inDimension</seealso>
    let inDimension = Prefixed_Name(dqv, "inDimension") |> PrefixedName
    /// <summary>
    ///   <para>dqv:isMeasurementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates the metric being observed."</para>
    /// labels<para>"is measurement of"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#isMeasurementOf">http://www.w3.org/ns/dqv#isMeasurementOf</seealso>
    let isMeasurementOf = Prefixed_Name(dqv, "isMeasurementOf") |> PrefixedName
    /// <summary>
    ///   <para>dqv:precision</para>
    /// </summary>
    /// <remarks>
    ///   <para>dqv:Dimension</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#precision">http://www.w3.org/ns/dqv#precision</seealso>
    let precision = Prefixed_Name(dqv, "precision") |> PrefixedName
    /// <summary>
    ///   <para>dqv:qualityAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>oa:Motivation</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#qualityAssessment">http://www.w3.org/ns/dqv#qualityAssessment</seealso>
    let qualityAssessment = Prefixed_Name(dqv, "qualityAssessment") |> PrefixedName
    /// <summary>
    ///   <para>dqv:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>"Refers to values computed by metric."</para>
    /// labels<para>"value"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dqv#value">http://www.w3.org/ns/dqv#value</seealso>
    let value = Prefixed_Name(dqv, "value") |> PrefixedName
