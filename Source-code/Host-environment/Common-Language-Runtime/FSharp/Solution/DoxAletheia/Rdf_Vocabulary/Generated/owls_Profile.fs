namespace http.www.daml.org.services.owl_s._1._2.Profile.owl.hash

open DoxAletheia

module owls_Profile =
    let _namespace_name = "http://www.daml.org/services/owl-s/1.2/Profile.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

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
    let Profile = _prefix "Profile"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceName"></see>
    /// </summary>
    let serviceName = _prefix "serviceName"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#textDescription"></see>
    /// </summary>
    let textDescription = _prefix "textDescription"
    /// <summary>
    ///
    ///     a ServiceCategory is restricted to refer to only onename
    ///
    ///
    ///     a ServiceCategory is restricted to refer to only one taxonomy
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#ServiceCategory"></see></summary>
    let ServiceCategory = _prefix "ServiceCategory"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#categoryName"></see>
    /// </summary>
    let categoryName = _prefix "categoryName"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#taxonomy"></see>
    /// </summary>
    let taxonomy = _prefix "taxonomy"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#value"></see>
    /// </summary>
    let value = _prefix "value"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#code"></see>
    /// </summary>
    let code = _prefix "code"
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
    let ServiceParameter = _prefix "ServiceParameter"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceParameterName"></see>
    /// </summary>
    let serviceParameterName = _prefix "serviceParameterName"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#sParameter"></see>
    /// </summary>
    let sParameter = _prefix "sParameter"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#contactInformation"></see>
    /// </summary>
    let contactInformation = _prefix "contactInformation"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#hasInput"></see>
    /// </summary>
    let hasInput = _prefix "hasInput"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#hasParameter"></see>
    /// </summary>
    let hasParameter = _prefix "hasParameter"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#hasOutput"></see>
    /// </summary>
    let hasOutput = _prefix "hasOutput"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#hasPrecondition"></see>
    /// </summary>
    let hasPrecondition = _prefix "hasPrecondition"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#hasResult"></see>
    /// </summary>
    let hasResult = _prefix "hasResult"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#has_process"></see>
    /// </summary>
    let has_process = _prefix "has_process"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceCategory"></see>
    /// </summary>
    let serviceCategory = _prefix "serviceCategory"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceClassification"></see>
    /// </summary>
    let serviceClassification = _prefix "serviceClassification"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceParameter"></see>
    /// </summary>
    let serviceParameter = _prefix "serviceParameter"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Profile.owl#serviceProduct"></see>
    /// </summary>
    let serviceProduct = _prefix "serviceProduct"
