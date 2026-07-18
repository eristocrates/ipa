namespace http.premon.fbk.eu.ontology.nb.hash

open DoxAletheia.Rdf_Vocabulary

module pmonb =
    let _namespace_name = "http://premon.fbk.eu/ontology/nb#"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#Argument"></see>
    /// </summary>
    let Argument = Namespaced_IRI.parse _namespace_name "Argument" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#Modifier"></see>
    /// </summary>
    let Modifier = Namespaced_IRI.parse _namespace_name "Modifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#NumberedArgument"></see>
    /// </summary>
    let NumberedArgument =
        Namespaced_IRI.parse _namespace_name "NumberedArgument" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-cau"></see>
    /// </summary>
    let ``argm-cau`` = Namespaced_IRI.parse _namespace_name "argm-cau" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-tmp"></see>
    /// </summary>
    let ``argm-tmp`` = Namespaced_IRI.parse _namespace_name "argm-tmp" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-dis"></see>
    /// </summary>
    let ``argm-dis`` = Namespaced_IRI.parse _namespace_name "argm-dis" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-dir"></see>
    /// </summary>
    let ``argm-dir`` = Namespaced_IRI.parse _namespace_name "argm-dir" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-prd"></see>
    /// </summary>
    let ``argm-prd`` = Namespaced_IRI.parse _namespace_name "argm-prd" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-ext"></see>
    /// </summary>
    let ``argm-ext`` = Namespaced_IRI.parse _namespace_name "argm-ext" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-mnr"></see>
    /// </summary>
    let ``argm-mnr`` = Namespaced_IRI.parse _namespace_name "argm-mnr" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-loc"></see>
    /// </summary>
    let ``argm-loc`` = Namespaced_IRI.parse _namespace_name "argm-loc" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-neg"></see>
    /// </summary>
    let ``argm-neg`` = Namespaced_IRI.parse _namespace_name "argm-neg" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-pnc"></see>
    /// </summary>
    let ``argm-pnc`` = Namespaced_IRI.parse _namespace_name "argm-pnc" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-adv"></see>
    /// </summary>
    let ``argm-adv`` = Namespaced_IRI.parse _namespace_name "argm-adv" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#arg5"></see>
    /// </summary>
    let arg5 = Namespaced_IRI.parse _namespace_name "arg5" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#arg4"></see>
    /// </summary>
    let arg4 = Namespaced_IRI.parse _namespace_name "arg4" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#arg3"></see>
    /// </summary>
    let arg3 = Namespaced_IRI.parse _namespace_name "arg3" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#arg2"></see>
    /// </summary>
    let arg2 = Namespaced_IRI.parse _namespace_name "arg2" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#arg1"></see>
    /// </summary>
    let arg1 = Namespaced_IRI.parse _namespace_name "arg1" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#arg0"></see>
    /// </summary>
    let arg0 = Namespaced_IRI.parse _namespace_name "arg0" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#Roleset"></see>
    /// </summary>
    let Roleset = Namespaced_IRI.parse _namespace_name "Roleset" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#SemanticRole"></see>
    /// </summary>
    let SemanticRole =
        Namespaced_IRI.parse _namespace_name "SemanticRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argument"></see>
    /// </summary>
    let argument = Namespaced_IRI.parse _namespace_name "argument" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#Tag"></see>
    /// </summary>
    let Tag = Namespaced_IRI.parse _namespace_name "Tag" |> NamespacedName
    /// <summary>
    /// Set to true if the semantic role explicitly occurs in a frame file
    /// <see href="http://premon.fbk.eu/ontology/nb#core"></see></summary>
    let core = Namespaced_IRI.parse _namespace_name "core" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#tag"></see>
    /// </summary>
    let tag = Namespaced_IRI.parse _namespace_name "tag" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#tag-prd"></see>
    /// </summary>
    let ``tag-prd`` = Namespaced_IRI.parse _namespace_name "tag-prd" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#tag-ref"></see>
    /// </summary>
    let ``tag-ref`` = Namespaced_IRI.parse _namespace_name "tag-ref" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#tag-support"></see>
    /// </summary>
    let ``tag-support`` =
        Namespaced_IRI.parse _namespace_name "tag-support" |> NamespacedName
