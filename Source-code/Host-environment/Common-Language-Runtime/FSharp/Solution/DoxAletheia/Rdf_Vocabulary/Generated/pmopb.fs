namespace http.premon.fbk.eu.ontology.pb.hash

open DoxAletheia

module pmopb =
    let _namespace_name = "http://premon.fbk.eu/ontology/pb#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#Argument"></see>
    /// </summary>
    let Argument = _prefix "Argument"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#Modifier"></see>
    /// </summary>
    let Modifier = _prefix "Modifier"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#NumberedArgument"></see>
    /// </summary>
    let NumberedArgument = _prefix "NumberedArgument"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#SecondaryAgent"></see>
    /// </summary>
    let SecondaryAgent = _prefix "SecondaryAgent"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#Aspect"></see>
    /// </summary>
    let Aspect = _prefix "Aspect"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#perfect"></see>
    /// </summary>
    let perfect = _prefix "perfect"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#progressive"></see>
    /// </summary>
    let progressive = _prefix "progressive"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#Form"></see>
    /// </summary>
    let Form = _prefix "Form"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#gerund"></see>
    /// </summary>
    let gerund = _prefix "gerund"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#full"></see>
    /// </summary>
    let full = _prefix "full"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#participle"></see>
    /// </summary>
    let participle = _prefix "participle"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#infinitive"></see>
    /// </summary>
    let infinitive = _prefix "infinitive"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#Inflection"></see>
    /// </summary>
    let Inflection = _prefix "Inflection"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-lvb"></see>
    /// </summary>
    let ``argm-lvb`` = _prefix "argm-lvb"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-cau"></see>
    /// </summary>
    let ``argm-cau`` = _prefix "argm-cau"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-tmp"></see>
    /// </summary>
    let ``argm-tmp`` = _prefix "argm-tmp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-rcl"></see>
    /// </summary>
    let ``argm-rcl`` = _prefix "argm-rcl"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-loc"></see>
    /// </summary>
    let ``argm-loc`` = _prefix "argm-loc"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-gol"></see>
    /// </summary>
    let ``argm-gol`` = _prefix "argm-gol"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-mod"></see>
    /// </summary>
    let ``argm-mod`` = _prefix "argm-mod"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-prd"></see>
    /// </summary>
    let ``argm-prd`` = _prefix "argm-prd"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-com"></see>
    /// </summary>
    let ``argm-com`` = _prefix "argm-com"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-dsp"></see>
    /// </summary>
    let ``argm-dsp`` = _prefix "argm-dsp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-ext"></see>
    /// </summary>
    let ``argm-ext`` = _prefix "argm-ext"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-adj"></see>
    /// </summary>
    let ``argm-adj`` = _prefix "argm-adj"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-pnc"></see>
    /// </summary>
    let ``argm-pnc`` = _prefix "argm-pnc"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-slc"></see>
    /// </summary>
    let ``argm-slc`` = _prefix "argm-slc"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-neg"></see>
    /// </summary>
    let ``argm-neg`` = _prefix "argm-neg"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-rec"></see>
    /// </summary>
    let ``argm-rec`` = _prefix "argm-rec"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-dis"></see>
    /// </summary>
    let ``argm-dis`` = _prefix "argm-dis"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-prp"></see>
    /// </summary>
    let ``argm-prp`` = _prefix "argm-prp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-dir"></see>
    /// </summary>
    let ``argm-dir`` = _prefix "argm-dir"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-adv"></see>
    /// </summary>
    let ``argm-adv`` = _prefix "argm-adv"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-mnr"></see>
    /// </summary>
    let ``argm-mnr`` = _prefix "argm-mnr"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-prn"></see>
    /// </summary>
    let ``argm-prn`` = _prefix "argm-prn"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-cxn"></see>
    /// </summary>
    let ``argm-cxn`` = _prefix "argm-cxn"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argm-vsp"></see>
    /// </summary>
    let ``argm-vsp`` = _prefix "argm-vsp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#arg4"></see>
    /// </summary>
    let arg4 = _prefix "arg4"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#arg3"></see>
    /// </summary>
    let arg3 = _prefix "arg3"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#arg2"></see>
    /// </summary>
    let arg2 = _prefix "arg2"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#arg1"></see>
    /// </summary>
    let arg1 = _prefix "arg1"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#arg0"></see>
    /// </summary>
    let arg0 = _prefix "arg0"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#arg5"></see>
    /// </summary>
    let arg5 = _prefix "arg5"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#arg6"></see>
    /// </summary>
    let arg6 = _prefix "arg6"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#Person"></see>
    /// </summary>
    let Person = _prefix "Person"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#other"></see>
    /// </summary>
    let other = _prefix "other"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#third"></see>
    /// </summary>
    let third = _prefix "third"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#Roleset"></see>
    /// </summary>
    let Roleset = _prefix "Roleset"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#SemanticRole"></see>
    /// </summary>
    let SemanticRole = _prefix "SemanticRole"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#argument"></see>
    /// </summary>
    let argument = _prefix "argument"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#Tag"></see>
    /// </summary>
    let Tag = _prefix "Tag"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#Tense"></see>
    /// </summary>
    let Tense = _prefix "Tense"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#future"></see>
    /// </summary>
    let future = _prefix "future"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#past"></see>
    /// </summary>
    let past = _prefix "past"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#present"></see>
    /// </summary>
    let present = _prefix "present"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#Voice"></see>
    /// </summary>
    let Voice = _prefix "Voice"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#passive"></see>
    /// </summary>
    let passive = _prefix "passive"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#active"></see>
    /// </summary>
    let active = _prefix "active"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#arga"></see>
    /// </summary>
    let arga = _prefix "arga"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#aspect"></see>
    /// </summary>
    let aspect = _prefix "aspect"
    /// <summary>
    /// Set to true if the semantic role explicitly occurs in a frame file
    /// <see href="http://premon.fbk.eu/ontology/pb#core"></see></summary>
    let core = _prefix "core"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#form"></see>
    /// </summary>
    let form = _prefix "form"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#inflection"></see>
    /// </summary>
    let inflection = _prefix "inflection"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#person"></see>
    /// </summary>
    let person = _prefix "person"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#tag"></see>
    /// </summary>
    let tag = _prefix "tag"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#tag-pag"></see>
    /// </summary>
    let ``tag-pag`` = _prefix "tag-pag"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#tag-ppt"></see>
    /// </summary>
    let ``tag-ppt`` = _prefix "tag-ppt"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#tag-vsp"></see>
    /// </summary>
    let ``tag-vsp`` = _prefix "tag-vsp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#tense"></see>
    /// </summary>
    let tense = _prefix "tense"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/pb#voice"></see>
    /// </summary>
    let voice = _prefix "voice"
