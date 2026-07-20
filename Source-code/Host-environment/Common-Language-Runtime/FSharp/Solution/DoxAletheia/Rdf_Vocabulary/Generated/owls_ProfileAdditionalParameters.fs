namespace http.www.daml.org.services.owl_s._1._2.ProfileAdditionalParameters.owl.hash

open DoxAletheia

module owls_ProfileAdditionalParameters =
    let _namespace_name =
        "http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#AverageResponseTime"></see>
    /// </summary>
    let AverageResponseTime = _prefix "AverageResponseTime"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#Duration"></see>
    /// </summary>
    let Duration = _prefix "Duration"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#GeographicRadius"></see>
    /// </summary>
    let GeographicRadius = _prefix "GeographicRadius"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#MaxResponseTime"></see>
    /// </summary>
    let MaxResponseTime = _prefix "MaxResponseTime"
    /// <summary>
    ///
    ///       Hook to the NAICS taxonomy
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#NAICS"></see></summary>
    let NAICS = _prefix "NAICS"
    /// <summary>
    ///
    ///       Hook to the UNSPSC taxonomy
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#UNSPSC"></see></summary>
    let UNSPSC = _prefix "UNSPSC"
