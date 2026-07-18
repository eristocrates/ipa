namespace http.premon.fbk.eu.ontology.pb.hash

open DoxAletheia.Rdf_Vocabulary

module pmopb =
    let _namespace_name = "http://premon.fbk.eu/ontology/pb#"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#Argument"></see>
    /// </summary>
    let Argument = Namespaced_IRI.parse _namespace_name "Argument" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#Modifier"></see>
    /// </summary>
    let Modifier = Namespaced_IRI.parse _namespace_name "Modifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#NumberedArgument"></see>
    /// </summary>
    let NumberedArgument =
        Namespaced_IRI.parse _namespace_name "NumberedArgument" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#SecondaryAgent"></see>
    /// </summary>
    let SecondaryAgent =
        Namespaced_IRI.parse _namespace_name "SecondaryAgent" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#Aspect"></see>
    /// </summary>
    let Aspect = Namespaced_IRI.parse _namespace_name "Aspect" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#perfect"></see>
    /// </summary>
    let perfect = Namespaced_IRI.parse _namespace_name "perfect" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#progressive"></see>
    /// </summary>
    let progressive =
        Namespaced_IRI.parse _namespace_name "progressive" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#Form"></see>
    /// </summary>
    let Form = Namespaced_IRI.parse _namespace_name "Form" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#gerund"></see>
    /// </summary>
    let gerund = Namespaced_IRI.parse _namespace_name "gerund" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#full"></see>
    /// </summary>
    let full = Namespaced_IRI.parse _namespace_name "full" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#participle"></see>
    /// </summary>
    let participle = Namespaced_IRI.parse _namespace_name "participle" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#infinitive"></see>
    /// </summary>
    let infinitive = Namespaced_IRI.parse _namespace_name "infinitive" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#Inflection"></see>
    /// </summary>
    let Inflection = Namespaced_IRI.parse _namespace_name "Inflection" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-lvb"></see>
    /// </summary>
    let ``argm-lvb`` = Namespaced_IRI.parse _namespace_name "argm-lvb" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-cau"></see>
    /// </summary>
    let ``argm-cau`` = Namespaced_IRI.parse _namespace_name "argm-cau" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-tmp"></see>
    /// </summary>
    let ``argm-tmp`` = Namespaced_IRI.parse _namespace_name "argm-tmp" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-rcl"></see>
    /// </summary>
    let ``argm-rcl`` = Namespaced_IRI.parse _namespace_name "argm-rcl" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-loc"></see>
    /// </summary>
    let ``argm-loc`` = Namespaced_IRI.parse _namespace_name "argm-loc" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-gol"></see>
    /// </summary>
    let ``argm-gol`` = Namespaced_IRI.parse _namespace_name "argm-gol" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-mod"></see>
    /// </summary>
    let ``argm-mod`` = Namespaced_IRI.parse _namespace_name "argm-mod" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-prd"></see>
    /// </summary>
    let ``argm-prd`` = Namespaced_IRI.parse _namespace_name "argm-prd" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-com"></see>
    /// </summary>
    let ``argm-com`` = Namespaced_IRI.parse _namespace_name "argm-com" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-dsp"></see>
    /// </summary>
    let ``argm-dsp`` = Namespaced_IRI.parse _namespace_name "argm-dsp" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-ext"></see>
    /// </summary>
    let ``argm-ext`` = Namespaced_IRI.parse _namespace_name "argm-ext" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-adj"></see>
    /// </summary>
    let ``argm-adj`` = Namespaced_IRI.parse _namespace_name "argm-adj" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-pnc"></see>
    /// </summary>
    let ``argm-pnc`` = Namespaced_IRI.parse _namespace_name "argm-pnc" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-slc"></see>
    /// </summary>
    let ``argm-slc`` = Namespaced_IRI.parse _namespace_name "argm-slc" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-neg"></see>
    /// </summary>
    let ``argm-neg`` = Namespaced_IRI.parse _namespace_name "argm-neg" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-rec"></see>
    /// </summary>
    let ``argm-rec`` = Namespaced_IRI.parse _namespace_name "argm-rec" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-dis"></see>
    /// </summary>
    let ``argm-dis`` = Namespaced_IRI.parse _namespace_name "argm-dis" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-prp"></see>
    /// </summary>
    let ``argm-prp`` = Namespaced_IRI.parse _namespace_name "argm-prp" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-dir"></see>
    /// </summary>
    let ``argm-dir`` = Namespaced_IRI.parse _namespace_name "argm-dir" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-adv"></see>
    /// </summary>
    let ``argm-adv`` = Namespaced_IRI.parse _namespace_name "argm-adv" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-mnr"></see>
    /// </summary>
    let ``argm-mnr`` = Namespaced_IRI.parse _namespace_name "argm-mnr" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-prn"></see>
    /// </summary>
    let ``argm-prn`` = Namespaced_IRI.parse _namespace_name "argm-prn" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-cxn"></see>
    /// </summary>
    let ``argm-cxn`` = Namespaced_IRI.parse _namespace_name "argm-cxn" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-vsp"></see>
    /// </summary>
    let ``argm-vsp`` = Namespaced_IRI.parse _namespace_name "argm-vsp" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#arg4"></see>
    /// </summary>
    let arg4 = Namespaced_IRI.parse _namespace_name "arg4" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#arg3"></see>
    /// </summary>
    let arg3 = Namespaced_IRI.parse _namespace_name "arg3" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#arg2"></see>
    /// </summary>
    let arg2 = Namespaced_IRI.parse _namespace_name "arg2" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#arg1"></see>
    /// </summary>
    let arg1 = Namespaced_IRI.parse _namespace_name "arg1" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#arg0"></see>
    /// </summary>
    let arg0 = Namespaced_IRI.parse _namespace_name "arg0" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#arg5"></see>
    /// </summary>
    let arg5 = Namespaced_IRI.parse _namespace_name "arg5" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#arg6"></see>
    /// </summary>
    let arg6 = Namespaced_IRI.parse _namespace_name "arg6" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#Person"></see>
    /// </summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#other"></see>
    /// </summary>
    let other = Namespaced_IRI.parse _namespace_name "other" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#third"></see>
    /// </summary>
    let third = Namespaced_IRI.parse _namespace_name "third" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#Roleset"></see>
    /// </summary>
    let Roleset = Namespaced_IRI.parse _namespace_name "Roleset" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#SemanticRole"></see>
    /// </summary>
    let SemanticRole =
        Namespaced_IRI.parse _namespace_name "SemanticRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argument"></see>
    /// </summary>
    let argument = Namespaced_IRI.parse _namespace_name "argument" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#Tag"></see>
    /// </summary>
    let Tag = Namespaced_IRI.parse _namespace_name "Tag" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#Tense"></see>
    /// </summary>
    let Tense = Namespaced_IRI.parse _namespace_name "Tense" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#future"></see>
    /// </summary>
    let future = Namespaced_IRI.parse _namespace_name "future" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#past"></see>
    /// </summary>
    let past = Namespaced_IRI.parse _namespace_name "past" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#present"></see>
    /// </summary>
    let present = Namespaced_IRI.parse _namespace_name "present" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#Voice"></see>
    /// </summary>
    let Voice = Namespaced_IRI.parse _namespace_name "Voice" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#passive"></see>
    /// </summary>
    let passive = Namespaced_IRI.parse _namespace_name "passive" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#active"></see>
    /// </summary>
    let active = Namespaced_IRI.parse _namespace_name "active" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#arga"></see>
    /// </summary>
    let arga = Namespaced_IRI.parse _namespace_name "arga" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#aspect"></see>
    /// </summary>
    let aspect = Namespaced_IRI.parse _namespace_name "aspect" |> NamespacedName
    /// <summary>
    /// Set to true if the semantic role explicitly occurs in a frame file
    /// <see href="http://premon.fbk.eu/ontology/pb#core"></see></summary>
    let core = Namespaced_IRI.parse _namespace_name "core" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#form"></see>
    /// </summary>
    let form = Namespaced_IRI.parse _namespace_name "form" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#inflection"></see>
    /// </summary>
    let inflection = Namespaced_IRI.parse _namespace_name "inflection" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#person"></see>
    /// </summary>
    let person = Namespaced_IRI.parse _namespace_name "person" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#tag"></see>
    /// </summary>
    let tag = Namespaced_IRI.parse _namespace_name "tag" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#tag-pag"></see>
    /// </summary>
    let ``tag-pag`` = Namespaced_IRI.parse _namespace_name "tag-pag" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#tag-ppt"></see>
    /// </summary>
    let ``tag-ppt`` = Namespaced_IRI.parse _namespace_name "tag-ppt" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#tag-vsp"></see>
    /// </summary>
    let ``tag-vsp`` = Namespaced_IRI.parse _namespace_name "tag-vsp" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#tense"></see>
    /// </summary>
    let tense = Namespaced_IRI.parse _namespace_name "tense" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#voice"></see>
    /// </summary>
    let voice = Namespaced_IRI.parse _namespace_name "voice" |> NamespacedName
