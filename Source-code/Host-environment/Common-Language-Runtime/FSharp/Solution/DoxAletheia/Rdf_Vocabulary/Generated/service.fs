namespace http.purl.org.ontology.service.hash

open DoxAletheia.Rdf_Vocabulary

module service =
    let _namespace_name = "http://purl.org/ontology/service#"
    /// <summary>
    ///   <see href="http://purl.org/ontology/service#Service"></see>
    /// </summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/service#ServiceConsumer"></see>
    /// </summary>
    let ServiceConsumer =
        Namespaced_IRI.parse _namespace_name "ServiceConsumer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/service#ServiceLimitation"></see>
    /// </summary>
    let ServiceLimitation =
        Namespaced_IRI.parse _namespace_name "ServiceLimitation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/service#ServiceProvider"></see>
    /// </summary>
    let ServiceProvider =
        Namespaced_IRI.parse _namespace_name "ServiceProvider" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/service#consumedBy"></see>
    /// </summary>
    let consumedBy = Namespaced_IRI.parse _namespace_name "consumedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/service#consumes"></see>
    /// </summary>
    let consumes = Namespaced_IRI.parse _namespace_name "consumes" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/service#delay"></see>
    /// </summary>
    let delay = Namespaced_IRI.parse _namespace_name "delay" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/service#limitedBy"></see>
    /// </summary>
    let limitedBy = Namespaced_IRI.parse _namespace_name "limitedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/service#limits"></see>
    /// </summary>
    let limits = Namespaced_IRI.parse _namespace_name "limits" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/service#providedBy"></see>
    /// </summary>
    let providedBy = Namespaced_IRI.parse _namespace_name "providedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/service#provides"></see>
    /// </summary>
    let provides = Namespaced_IRI.parse _namespace_name "provides" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/service#queue"></see>
    /// </summary>
    let queue = Namespaced_IRI.parse _namespace_name "queue" |> NamespacedName
