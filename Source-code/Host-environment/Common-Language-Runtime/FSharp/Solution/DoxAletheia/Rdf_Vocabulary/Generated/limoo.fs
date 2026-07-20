namespace http.purl.org.LiMo._0._1.hash

open DoxAletheia

module limoo =
    let _namespace_name = "http://purl.org/LiMo/0.1#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/LiMo/0.1#attributionCondition"></see>
    /// </summary>
    let attributionCondition = _prefix "attributionCondition"
    /// <summary>
    ///   <see href="http://purl.org/LiMo/0.1#createCondition"></see>
    /// </summary>
    let createCondition = _prefix "createCondition"
    /// <summary>
    ///   <see href="http://purl.org/LiMo/0.1#noCopyrightCondition"></see>
    /// </summary>
    let noCopyrightCondition = _prefix "noCopyrightCondition"
    /// <summary>
    ///   <see href="http://purl.org/LiMo/0.1#nonCommercialCondition"></see>
    /// </summary>
    let nonCommercialCondition = _prefix "nonCommercialCondition"
    /// <summary>
    ///   <see href="http://purl.org/LiMo/0.1#nonDerivativeWorksCondition"></see>
    /// </summary>
    let nonDerivativeWorksCondition = _prefix "nonDerivativeWorksCondition"
    /// <summary>
    ///   <see href="http://purl.org/LiMo/0.1#remixCondition"></see>
    /// </summary>
    let remixCondition = _prefix "remixCondition"
    /// <summary>
    ///   <see href="http://purl.org/LiMo/0.1#shareAlikeCondition"></see>
    /// </summary>
    let shareAlikeCondition = _prefix "shareAlikeCondition"
    /// <summary>
    ///   <see href="http://purl.org/LiMo/0.1#shareCondition"></see>
    /// </summary>
    let shareCondition = _prefix "shareCondition"
    /// <summary>
    ///   <see href="http://purl.org/LiMo/0.1#compatibleWith"></see>
    /// </summary>
    let compatibleWith = _prefix "compatibleWith"
