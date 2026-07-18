namespace http.www.w3.org.ns.dqv.hash

open DoxAletheia.Rdf_Vocabulary

module dqv =
    let _namespace_name = "http://www.w3.org/ns/dqv#"

    /// <summary>
    /// Represents the dimensions a quality metric, certificate and annotation allow a measurement of.
    /// <see href="http://www.w3.org/ns/dqv#inDimension"></see></summary>
    let inDimension =
        Namespaced_IRI.parse _namespace_name "inDimension" |> NamespacedName

    /// <summary>
    /// Represents a group of quality dimensions in which a common type of information is used as quality indicator.
    /// <see href="http://www.w3.org/ns/dqv#Category"></see></summary>
    let Category = Namespaced_IRI.parse _namespace_name "Category" |> NamespacedName
    /// <summary>
    /// Represents criteria relevant for assessing quality. Each quality dimension must have one or more metric to measure it. A dimension is linked with a category using the dqv:inCategory property.
    /// <see href="http://www.w3.org/ns/dqv#Dimension"></see></summary>
    let Dimension = Namespaced_IRI.parse _namespace_name "Dimension" |> NamespacedName
    /// <summary>
    /// Represents a standard to measure a quality dimension. An observation (instance of dqv:QualityMeasurement) assigns a value in a given unit to a Metric.
    /// <see href="http://www.w3.org/ns/dqv#Metric"></see></summary>
    let Metric = Namespaced_IRI.parse _namespace_name "Metric" |> NamespacedName

    /// <summary>
    /// Represents quality annotations, including ratings, quality certificates or feedback that can be associated to datasets or distributions. Quality annotations must have one oa:motivatedBy statement with an instance of oa:Motivation (and skos:Concept) that reflects a quality assessment purpose. We define this instance as dqv:qualityAssessment.
    /// <see href="http://www.w3.org/ns/dqv#QualityAnnotation"></see></summary>
    let QualityAnnotation =
        Namespaced_IRI.parse _namespace_name "QualityAnnotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/dqv#qualityAssessment"></see>
    /// </summary>
    let qualityAssessment =
        Namespaced_IRI.parse _namespace_name "qualityAssessment" |> NamespacedName

    /// <summary>
    /// An annotation that associates a resource (especially, a dataset or a distribution) to another resource (for example, a document) that certifies the resource's quality according to a set of quality assessment rules.
    /// <see href="http://www.w3.org/ns/dqv#QualityCertificate"></see></summary>
    let QualityCertificate =
        Namespaced_IRI.parse _namespace_name "QualityCertificate" |> NamespacedName

    /// <summary>
    /// Represents the evaluation of a given dataset (or dataset distribution) against a specific quality metric.
    /// <see href="http://www.w3.org/ns/dqv#QualityMeasurement"></see></summary>
    let QualityMeasurement =
        Namespaced_IRI.parse _namespace_name "QualityMeasurement" |> NamespacedName

    /// <summary>
    /// Represents a dataset of quality measurements, evaluations of one or more datasets (or dataset distributions) against specific quality metrics.
    /// <see href="http://www.w3.org/ns/dqv#QualityMeasurementDataset"></see></summary>
    let QualityMeasurementDataset =
        Namespaced_IRI.parse _namespace_name "QualityMeasurementDataset" |> NamespacedName

    /// <summary>
    /// Represents quality metadata, it is defined to group quality certificates, policies, measurements and annotations under a named graph.
    /// <see href="http://www.w3.org/ns/dqv#QualityMetadata"></see></summary>
    let QualityMetadata =
        Namespaced_IRI.parse _namespace_name "QualityMetadata" |> NamespacedName

    /// <summary>
    /// Represents a policy or agreement that is chiefly governed by data quality concerns.
    /// <see href="http://www.w3.org/ns/dqv#QualityPolicy"></see></summary>
    let QualityPolicy =
        Namespaced_IRI.parse _namespace_name "QualityPolicy" |> NamespacedName

    /// <summary>
    /// Represents feedback that users have on the quality of datasets or distributions. Besides dqv:qualityAssessment, which is the motivation required by all quality annotations, one of the predefined instances of oa:Motivation should be indicated as motivation to distinguish among the different kinds of feedback, e.g., classifications, questions.
    /// <see href="http://www.w3.org/ns/dqv#UserQualityFeedback"></see></summary>
    let UserQualityFeedback =
        Namespaced_IRI.parse _namespace_name "UserQualityFeedback" |> NamespacedName

    /// <summary>
    /// Refers to the resource (e.g., a dataset, a linkset, a graph, a set of triples) on which the quality measurement is performed. In the DQV context, this property is generally expected to be used in statements in which objects are instances of dcat:Dataset or dcat:Distribution.
    /// <see href="http://www.w3.org/ns/dqv#computedOn"></see></summary>
    let computedOn = Namespaced_IRI.parse _namespace_name "computedOn" |> NamespacedName

    /// <summary>
    /// Refers to the performed quality measurements. Quality measurements can be performed to any kind of resource (e.g., a dataset, a linkset, a graph, a set of triples). However, in the DQV context, this property is generally expected to be used in statements in which subjects are instances of dcat:Dataset or dcat:Distribution.
    /// <see href="http://www.w3.org/ns/dqv#hasQualityMeasurement"></see></summary>
    let hasQualityMeasurement =
        Namespaced_IRI.parse _namespace_name "hasQualityMeasurement" |> NamespacedName

    /// <summary>
    /// Represents the expected data type for metric's observed value (e.g. xsd:boolean, xsd:double etc...)
    /// <see href="http://www.w3.org/ns/dqv#expectedDataType"></see></summary>
    let expectedDataType =
        Namespaced_IRI.parse _namespace_name "expectedDataType" |> NamespacedName

    /// <summary>
    /// Refers to a quality annotation. Quality annotation can be applied to any kind of resource, e.g., a dataset, a linkset, a graph, a set of triples. However, in the DQV context, this property is generally expected to be used in statements in which subjects are instances of dcat:Dataset or dcat:Distribution.
    /// <see href="http://www.w3.org/ns/dqv#hasQualityAnnotation"></see></summary>
    let hasQualityAnnotation =
        Namespaced_IRI.parse _namespace_name "hasQualityAnnotation" |> NamespacedName

    /// <summary>
    /// Refers to a grouping of quality information such as certificates, policies, measurements and annotations as a named graph. Quality information represented in such a grouping can pertain to any kind of resource (e.g., a dataset, a linkset, a graph, a set of triples). However, in the DQV context, this property is generally expected to be used in statements in which subjects are instances of dcat:Dataset or dcat:Distribution.
    /// <see href="http://www.w3.org/ns/dqv#hasQualityMetadata"></see></summary>
    let hasQualityMetadata =
        Namespaced_IRI.parse _namespace_name "hasQualityMetadata" |> NamespacedName

    /// <summary>
    /// Represents the category a dimension is grouped in.
    /// <see href="http://www.w3.org/ns/dqv#inCategory"></see></summary>
    let inCategory = Namespaced_IRI.parse _namespace_name "inCategory" |> NamespacedName

    /// <summary>
    /// Indicates the metric being observed.
    /// <see href="http://www.w3.org/ns/dqv#isMeasurementOf"></see></summary>
    let isMeasurementOf =
        Namespaced_IRI.parse _namespace_name "isMeasurementOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/dqv#precision"></see>
    /// </summary>
    let precision = Namespaced_IRI.parse _namespace_name "precision" |> NamespacedName
    /// <summary>
    /// Refers to values computed by metric.
    /// <see href="http://www.w3.org/ns/dqv#value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
