namespace http.purl.org.LiMo._0._1.hash

open DoxAletheia.Rdf_Vocabulary

module limoo =
    let _namespace_name = "http://purl.org/LiMo/0.1#"

    /// <summary>
    ///   <see href="http://purl.org/LiMo/0.1#attributionCondition"></see>
    /// </summary>
    let attributionCondition =
        Namespaced_IRI.parse _namespace_name "attributionCondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/LiMo/0.1#createCondition"></see>
    /// </summary>
    let createCondition =
        Namespaced_IRI.parse _namespace_name "createCondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/LiMo/0.1#noCopyrightCondition"></see>
    /// </summary>
    let noCopyrightCondition =
        Namespaced_IRI.parse _namespace_name "noCopyrightCondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/LiMo/0.1#nonCommercialCondition"></see>
    /// </summary>
    let nonCommercialCondition =
        Namespaced_IRI.parse _namespace_name "nonCommercialCondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/LiMo/0.1#nonDerivativeWorksCondition"></see>
    /// </summary>
    let nonDerivativeWorksCondition =
        Namespaced_IRI.parse _namespace_name "nonDerivativeWorksCondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/LiMo/0.1#remixCondition"></see>
    /// </summary>
    let remixCondition =
        Namespaced_IRI.parse _namespace_name "remixCondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/LiMo/0.1#shareAlikeCondition"></see>
    /// </summary>
    let shareAlikeCondition =
        Namespaced_IRI.parse _namespace_name "shareAlikeCondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/LiMo/0.1#shareCondition"></see>
    /// </summary>
    let shareCondition =
        Namespaced_IRI.parse _namespace_name "shareCondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/LiMo/0.1#compatibleWith"></see>
    /// </summary>
    let compatibleWith =
        Namespaced_IRI.parse _namespace_name "compatibleWith" |> NamespacedName
