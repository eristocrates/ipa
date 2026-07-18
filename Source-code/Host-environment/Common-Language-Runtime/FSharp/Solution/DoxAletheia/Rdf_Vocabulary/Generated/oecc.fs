namespace http.www.oegov.org.core.owl.cc.hash

open DoxAletheia.Rdf_Vocabulary

module oecc =
    let _namespace_name = "http://www.oegov.org/core/owl/cc#"

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/cc#CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense"></see>
    /// </summary>
    let ``CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense`` =
        Namespaced_IRI.parse _namespace_name "CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/cc#attributedSource"></see>
    /// </summary>
    let attributedSource =
        Namespaced_IRI.parse _namespace_name "attributedSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/cc#TopQuadrantAttribution"></see>
    /// </summary>
    let TopQuadrantAttribution =
        Namespaced_IRI.parse _namespace_name "TopQuadrantAttribution" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/cc#revision"></see>
    /// </summary>
    let revision = Namespaced_IRI.parse _namespace_name "revision" |> NamespacedName

    /// <summary>
    /// The name, url and other details of an attribution.
    /// <see href="http://www.oegov.org/core/owl/cc#AttributedSource"></see></summary>
    let AttributedSource =
        Namespaced_IRI.parse _namespace_name "AttributedSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/cc#pointOfContact"></see>
    /// </summary>
    let pointOfContact =
        Namespaced_IRI.parse _namespace_name "pointOfContact" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/cc#image"></see>
    /// </summary>
    let image = Namespaced_IRI.parse _namespace_name "image" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/cc#licence"></see>
    /// </summary>
    let licence = Namespaced_IRI.parse _namespace_name "licence" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/cc#url"></see>
    /// </summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName
