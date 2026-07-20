namespace http.www.oegov.org.core.owl.cc.hash

open DoxAletheia

module oecc =
    let _namespace_name = "http://www.oegov.org/core/owl/cc#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/cc#CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense"></see>
    /// </summary>
    let ``CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense`` =
        _prefix "CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense"

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/cc#attributedSource"></see>
    /// </summary>
    let attributedSource = _prefix "attributedSource"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/cc#TopQuadrantAttribution"></see>
    /// </summary>
    let TopQuadrantAttribution = _prefix "TopQuadrantAttribution"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/cc#revision"></see>
    /// </summary>
    let revision = _prefix "revision"
    /// <summary>
    /// The name, url and other details of an attribution.
    /// <see href="http://www.oegov.org/core/owl/cc#AttributedSource"></see></summary>
    let AttributedSource = _prefix "AttributedSource"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/cc#pointOfContact"></see>
    /// </summary>
    let pointOfContact = _prefix "pointOfContact"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/cc#image"></see>
    /// </summary>
    let image = _prefix "image"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/cc#licence"></see>
    /// </summary>
    let licence = _prefix "licence"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/cc#url"></see>
    /// </summary>
    let url = _prefix "url"
