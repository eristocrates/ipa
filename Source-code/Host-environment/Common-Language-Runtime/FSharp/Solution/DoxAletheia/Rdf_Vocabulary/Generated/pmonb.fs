namespace http.premon.fbk.eu.ontology.nb.hash

open DoxAletheia

module pmonb =
    let _namespace_name = "http://premon.fbk.eu/ontology/nb#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#Argument"></see>
    /// </summary>
    let Argument = _prefix "Argument"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#Modifier"></see>
    /// </summary>
    let Modifier = _prefix "Modifier"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#NumberedArgument"></see>
    /// </summary>
    let NumberedArgument = _prefix "NumberedArgument"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-cau"></see>
    /// </summary>
    let ``argm-cau`` = _prefix "argm-cau"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-tmp"></see>
    /// </summary>
    let ``argm-tmp`` = _prefix "argm-tmp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-dis"></see>
    /// </summary>
    let ``argm-dis`` = _prefix "argm-dis"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-dir"></see>
    /// </summary>
    let ``argm-dir`` = _prefix "argm-dir"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-prd"></see>
    /// </summary>
    let ``argm-prd`` = _prefix "argm-prd"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-ext"></see>
    /// </summary>
    let ``argm-ext`` = _prefix "argm-ext"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-mnr"></see>
    /// </summary>
    let ``argm-mnr`` = _prefix "argm-mnr"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-loc"></see>
    /// </summary>
    let ``argm-loc`` = _prefix "argm-loc"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-neg"></see>
    /// </summary>
    let ``argm-neg`` = _prefix "argm-neg"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-pnc"></see>
    /// </summary>
    let ``argm-pnc`` = _prefix "argm-pnc"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argm-adv"></see>
    /// </summary>
    let ``argm-adv`` = _prefix "argm-adv"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#arg5"></see>
    /// </summary>
    let arg5 = _prefix "arg5"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#arg4"></see>
    /// </summary>
    let arg4 = _prefix "arg4"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#arg3"></see>
    /// </summary>
    let arg3 = _prefix "arg3"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#arg2"></see>
    /// </summary>
    let arg2 = _prefix "arg2"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#arg1"></see>
    /// </summary>
    let arg1 = _prefix "arg1"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#arg0"></see>
    /// </summary>
    let arg0 = _prefix "arg0"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#Roleset"></see>
    /// </summary>
    let Roleset = _prefix "Roleset"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#SemanticRole"></see>
    /// </summary>
    let SemanticRole = _prefix "SemanticRole"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#argument"></see>
    /// </summary>
    let argument = _prefix "argument"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#Tag"></see>
    /// </summary>
    let Tag = _prefix "Tag"
    /// <summary>
    /// Set to true if the semantic role explicitly occurs in a frame file
    /// <see href="http://premon.fbk.eu/ontology/nb#core"></see></summary>
    let core = _prefix "core"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#tag"></see>
    /// </summary>
    let tag = _prefix "tag"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#tag-prd"></see>
    /// </summary>
    let ``tag-prd`` = _prefix "tag-prd"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#tag-ref"></see>
    /// </summary>
    let ``tag-ref`` = _prefix "tag-ref"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/nb#tag-support"></see>
    /// </summary>
    let ``tag-support`` = _prefix "tag-support"
