namespace http.www.daml.org.services.owl_s._1._2.Profile.owl.hash

open DoxAletheia.Rdf_Vocabulary

module owls_Profile =
    let _namespace_name = "http://www.daml.org/services/owl-s/1.2/Profile.owl#"
    /// <summary>
    ///
    ///       Definition of Profile
    ///
    ///
    ///     A profile can have only one name
    ///
    ///
    ///     A profile can have only one text description
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#Profile"></see></summary>
    let Profile = Namespaced_IRI.parse _namespace_name "Profile" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceName"></see>
    /// </summary>
    let serviceName =
        Namespaced_IRI.parse _namespace_name "serviceName" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#textDescription"></see>
    /// </summary>
    let textDescription =
        Namespaced_IRI.parse _namespace_name "textDescription" |> NamespacedName

    /// <summary>
    ///
    ///     a ServiceCategory is restricted to refer to only onename
    ///
    ///
    ///     a ServiceCategory is restricted to refer to only one taxonomy
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#ServiceCategory"></see></summary>
    let ServiceCategory =
        Namespaced_IRI.parse _namespace_name "ServiceCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#categoryName"></see>
    /// </summary>
    let categoryName =
        Namespaced_IRI.parse _namespace_name "categoryName" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#taxonomy"></see>
    /// </summary>
    let taxonomy = Namespaced_IRI.parse _namespace_name "taxonomy" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#value"></see>
    /// </summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#code"></see>
    /// </summary>
    let code = Namespaced_IRI.parse _namespace_name "code" |> NamespacedName

    /// <summary>
    ///
    ///     A ServiceParameter should have at most 1 name (more precisely only
    ///       one serviceParameterName)
    ///
    ///
    ///     a Parameter is restricted to refer to only one concept in some
    ///     ontology
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#ServiceParameter"></see></summary>
    let ServiceParameter =
        Namespaced_IRI.parse _namespace_name "ServiceParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceParameterName"></see>
    /// </summary>
    let serviceParameterName =
        Namespaced_IRI.parse _namespace_name "serviceParameterName" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#sParameter"></see>
    /// </summary>
    let sParameter = Namespaced_IRI.parse _namespace_name "sParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#contactInformation"></see>
    /// </summary>
    let contactInformation =
        Namespaced_IRI.parse _namespace_name "contactInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#hasInput"></see>
    /// </summary>
    let hasInput = Namespaced_IRI.parse _namespace_name "hasInput" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#hasParameter"></see>
    /// </summary>
    let hasParameter =
        Namespaced_IRI.parse _namespace_name "hasParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#hasOutput"></see>
    /// </summary>
    let hasOutput = Namespaced_IRI.parse _namespace_name "hasOutput" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#hasPrecondition"></see>
    /// </summary>
    let hasPrecondition =
        Namespaced_IRI.parse _namespace_name "hasPrecondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#hasResult"></see>
    /// </summary>
    let hasResult = Namespaced_IRI.parse _namespace_name "hasResult" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#has_process"></see>
    /// </summary>
    let has_process =
        Namespaced_IRI.parse _namespace_name "has_process" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceCategory"></see>
    /// </summary>
    let serviceCategory =
        Namespaced_IRI.parse _namespace_name "serviceCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceClassification"></see>
    /// </summary>
    let serviceClassification =
        Namespaced_IRI.parse _namespace_name "serviceClassification" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceParameter"></see>
    /// </summary>
    let serviceParameter =
        Namespaced_IRI.parse _namespace_name "serviceParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceProduct"></see>
    /// </summary>
    let serviceProduct =
        Namespaced_IRI.parse _namespace_name "serviceProduct" |> NamespacedName
