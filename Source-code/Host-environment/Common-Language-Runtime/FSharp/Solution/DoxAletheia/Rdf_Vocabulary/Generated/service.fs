namespace http.purl.org.ontology.service.hash

open DoxAletheia

module service =
    let _namespace_name = "http://purl.org/ontology/service#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/service#Service"></see>
    /// </summary>
    let Service = _prefix "Service"
    /// <summary>
    ///   <see href="http://purl.org/ontology/service#ServiceConsumer"></see>
    /// </summary>
    let ServiceConsumer = _prefix "ServiceConsumer"
    /// <summary>
    ///   <see href="http://purl.org/ontology/service#ServiceLimitation"></see>
    /// </summary>
    let ServiceLimitation = _prefix "ServiceLimitation"
    /// <summary>
    ///   <see href="http://purl.org/ontology/service#ServiceProvider"></see>
    /// </summary>
    let ServiceProvider = _prefix "ServiceProvider"
    /// <summary>
    ///   <see href="http://purl.org/ontology/service#consumedBy"></see>
    /// </summary>
    let consumedBy = _prefix "consumedBy"
    /// <summary>
    ///   <see href="http://purl.org/ontology/service#consumes"></see>
    /// </summary>
    let consumes = _prefix "consumes"
    /// <summary>
    ///   <see href="http://purl.org/ontology/service#delay"></see>
    /// </summary>
    let delay = _prefix "delay"
    /// <summary>
    ///   <see href="http://purl.org/ontology/service#limitedBy"></see>
    /// </summary>
    let limitedBy = _prefix "limitedBy"
    /// <summary>
    ///   <see href="http://purl.org/ontology/service#limits"></see>
    /// </summary>
    let limits = _prefix "limits"
    /// <summary>
    ///   <see href="http://purl.org/ontology/service#providedBy"></see>
    /// </summary>
    let providedBy = _prefix "providedBy"
    /// <summary>
    ///   <see href="http://purl.org/ontology/service#provides"></see>
    /// </summary>
    let provides = _prefix "provides"
    /// <summary>
    ///   <see href="http://purl.org/ontology/service#queue"></see>
    /// </summary>
    let queue = _prefix "queue"
