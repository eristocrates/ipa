namespace http.www.daml.org.services.owl_s._1._2.ProfileAdditionalParameters.owl.hash

open DoxAletheia.Rdf_Vocabulary

module owls_ProfileAdditionalParameters =
    let _namespace_name =
        "http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#"

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#AverageResponseTime"></see>
    /// </summary>
    let AverageResponseTime =
        Namespaced_IRI.parse _namespace_name "AverageResponseTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#Duration"></see>
    /// </summary>
    let Duration = Namespaced_IRI.parse _namespace_name "Duration" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#GeographicRadius"></see>
    /// </summary>
    let GeographicRadius =
        Namespaced_IRI.parse _namespace_name "GeographicRadius" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#MaxResponseTime"></see>
    /// </summary>
    let MaxResponseTime =
        Namespaced_IRI.parse _namespace_name "MaxResponseTime" |> NamespacedName

    /// <summary>
    ///
    ///       Hook to the NAICS taxonomy
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#NAICS"></see></summary>
    let NAICS = Namespaced_IRI.parse _namespace_name "NAICS" |> NamespacedName
    /// <summary>
    ///
    ///       Hook to the UNSPSC taxonomy
    ///
    /// <see href="http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#UNSPSC"></see></summary>
    let UNSPSC = Namespaced_IRI.parse _namespace_name "UNSPSC" |> NamespacedName
