namespace http.www.daml.org.services.owl_s._1._2.Service.owl.hash

open DoxAletheia.Rdf_Vocabulary

module owls_Service =
    let _namespace_name = "http://www.daml.org/services/owl-s/1.2/Service.owl#"
    /// <summary>
    /// See comments above
    ///
    ///     A service has 0 or 1 models.  (But note that a service with 0 models
    ///     does not provide automated online access; it exists only for
    ///     discovery purposes; that is, it exists so as to provide a Profile.)
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Service.owl#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Service.owl#describedBy"></see>
    /// </summary>
    let describedBy =
        Namespaced_IRI.parse _namespace_name "describedBy" |> NamespacedName

    /// <summary>
    /// See comments above
    ///
    ///     A Grounding must be associated with exactly one service.
    ///     (Also, that service must have a model - but that constraint
    ///     isn't expressed here.)
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Service.owl#ServiceGrounding"></see></summary>
    let ServiceGrounding =
        Namespaced_IRI.parse _namespace_name "ServiceGrounding" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Service.owl#supportedBy"></see>
    /// </summary>
    let supportedBy =
        Namespaced_IRI.parse _namespace_name "supportedBy" |> NamespacedName

    /// <summary>
    /// See comments above
    /// <see href="http://www.daml.org/services/owl-s/1.2/Service.owl#ServiceModel"></see></summary>
    let ServiceModel =
        Namespaced_IRI.parse _namespace_name "ServiceModel" |> NamespacedName

    /// <summary>
    /// See comments above
    /// <see href="http://www.daml.org/services/owl-s/1.2/Service.owl#ServiceProfile"></see></summary>
    let ServiceProfile =
        Namespaced_IRI.parse _namespace_name "ServiceProfile" |> NamespacedName

    /// <summary>
    ///
    ///     There are no cardinality restrictions on this property. That is,
    ///     the same service model can be used by many different services.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Service.owl#describes"></see></summary>
    let describes = Namespaced_IRI.parse _namespace_name "describes" |> NamespacedName

    /// <summary>
    ///
    ///     There are no cardinality restrictions on this property.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Service.owl#presentedBy"></see></summary>
    let presentedBy =
        Namespaced_IRI.parse _namespace_name "presentedBy" |> NamespacedName

    /// <summary>
    ///
    ///     There are no cardinality restrictions on this property.
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Service.owl#presents"></see></summary>
    let presents = Namespaced_IRI.parse _namespace_name "presents" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Service.owl#providedBy"></see>
    /// </summary>
    let providedBy = Namespaced_IRI.parse _namespace_name "providedBy" |> NamespacedName
    /// <summary>
    ///
    ///     OWL-S is completely agnostic at present about what kind of thing
    ///     provides a service (hence, no domain declared here).
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Service.owl#provides"></see></summary>
    let provides = Namespaced_IRI.parse _namespace_name "provides" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Service.owl#supports"></see>
    /// </summary>
    let supports = Namespaced_IRI.parse _namespace_name "supports" |> NamespacedName
