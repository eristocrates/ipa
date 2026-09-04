#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pmopb =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://premon.fbk.eu/ontology/pb#" "pmopb"

    /// <summary>
    ///   <para>rdfs:label : Argument (PB)</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#Argument">pmopb:Argument</a>
    /// </summary>
    let Argument = _prefixId.prefix "Argument"
    /// <summary>
    ///   <para>rdfs:label : Aspect</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#Aspect">pmopb:Aspect</a>
    /// </summary>
    let Aspect = _prefixId.prefix "Aspect"
    /// <summary>
    ///   <para>rdfs:label : Form</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#Form">pmopb:Form</a>
    /// </summary>
    let Form = _prefixId.prefix "Form"
    /// <summary>
    ///   <para>rdfs:label : Inflection</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#Inflection">pmopb:Inflection</a>
    /// </summary>
    let Inflection = _prefixId.prefix "Inflection"
    /// <summary>
    ///   <para>rdfs:label : Modifier (PB)</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#Modifier">pmopb:Modifier</a>
    /// </summary>
    let Modifier = _prefixId.prefix "Modifier"
    /// <summary>
    ///   <para>rdfs:label : Numbered Argument (PB)</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#NumberedArgument">pmopb:NumberedArgument</a>
    /// </summary>
    let NumberedArgument = _prefixId.prefix "NumberedArgument"
    /// <summary>
    ///   <para>rdfs:label : Person</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#Person">pmopb:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : Roleset (PB)</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#Roleset">pmopb:Roleset</a>
    /// </summary>
    let Roleset = _prefixId.prefix "Roleset"
    /// <summary>
    ///   <para>rdfs:label : Secondary Agent</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#SecondaryAgent">pmopb:SecondaryAgent</a>
    /// </summary>
    let SecondaryAgent = _prefixId.prefix "SecondaryAgent"
    /// <summary>
    ///   <para>rdfs:label : Semantic Role (PB)</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#SemanticRole">pmopb:SemanticRole</a>
    /// </summary>
    let SemanticRole = _prefixId.prefix "SemanticRole"
    /// <summary>
    ///   <para>rdfs:label : Tag</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#Tag">pmopb:Tag</a>
    /// </summary>
    let Tag = _prefixId.prefix "Tag"
    /// <summary>
    ///   <para>rdfs:label : Tense</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#Tense">pmopb:Tense</a>
    /// </summary>
    let Tense = _prefixId.prefix "Tense"
    /// <summary>
    ///   <para>rdfs:label : Voice</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#Voice">pmopb:Voice</a>
    /// </summary>
    let Voice = _prefixId.prefix "Voice"
    let active = _prefixId.prefix "active"
    let arg0 = _prefixId.prefix "arg0"
    let arg1 = _prefixId.prefix "arg1"
    let arg2 = _prefixId.prefix "arg2"
    let arg3 = _prefixId.prefix "arg3"
    let arg4 = _prefixId.prefix "arg4"
    let arg5 = _prefixId.prefix "arg5"
    let arg6 = _prefixId.prefix "arg6"
    let arga = _prefixId.prefix "arga"
    let argm_adj = _prefixId.prefix "argm-adj"
    let argm_adv = _prefixId.prefix "argm-adv"
    let argm_cau = _prefixId.prefix "argm-cau"
    let argm_com = _prefixId.prefix "argm-com"
    let argm_cxn = _prefixId.prefix "argm-cxn"
    let argm_dir = _prefixId.prefix "argm-dir"
    let argm_dis = _prefixId.prefix "argm-dis"
    let argm_dsp = _prefixId.prefix "argm-dsp"
    let argm_ext = _prefixId.prefix "argm-ext"
    let argm_gol = _prefixId.prefix "argm-gol"
    let argm_loc = _prefixId.prefix "argm-loc"
    let argm_lvb = _prefixId.prefix "argm-lvb"
    let argm_mnr = _prefixId.prefix "argm-mnr"
    let argm_mod = _prefixId.prefix "argm-mod"
    let argm_neg = _prefixId.prefix "argm-neg"
    let argm_pnc = _prefixId.prefix "argm-pnc"
    let argm_prd = _prefixId.prefix "argm-prd"
    let argm_prn = _prefixId.prefix "argm-prn"
    let argm_prp = _prefixId.prefix "argm-prp"
    let argm_rcl = _prefixId.prefix "argm-rcl"
    let argm_rec = _prefixId.prefix "argm-rec"
    let argm_slc = _prefixId.prefix "argm-slc"
    let argm_tmp = _prefixId.prefix "argm-tmp"
    let argm_vsp = _prefixId.prefix "argm-vsp"
    /// <summary>
    ///   <para>rdfs:label : argument</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#argument">pmopb:argument</a>
    /// </summary>
    let argument = _prefixId.prefix "argument"
    /// <summary>
    ///   <para>rdfs:label : aspect</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#aspect">pmopb:aspect</a>
    /// </summary>
    let aspect = _prefixId.prefix "aspect"
    /// <summary>
    ///   <para>rdfs:label : core</para>
    ///   <para>rdfs:comment : Set to true if the semantic role explicitly occurs in a frame file</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#core">pmopb:core</a>
    /// </summary>
    let core = _prefixId.prefix "core"
    /// <summary>
    ///   <para>rdfs:label : form</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#form">pmopb:form</a>
    /// </summary>
    let form = _prefixId.prefix "form"
    let full = _prefixId.prefix "full"
    let future = _prefixId.prefix "future"
    let gerund = _prefixId.prefix "gerund"
    let infinitive = _prefixId.prefix "infinitive"
    /// <summary>
    ///   <para>rdfs:label : inflection</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#inflection">pmopb:inflection</a>
    /// </summary>
    let inflection = _prefixId.prefix "inflection"
    let other = _prefixId.prefix "other"
    let participle = _prefixId.prefix "participle"
    let passive = _prefixId.prefix "passive"
    let past = _prefixId.prefix "past"
    let perfect = _prefixId.prefix "perfect"
    /// <summary>
    ///   <para>rdfs:label : person</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#person">pmopb:person</a>
    /// </summary>
    let person = _prefixId.prefix "person"
    let present = _prefixId.prefix "present"
    let progressive = _prefixId.prefix "progressive"
    /// <summary>
    ///   <para>rdfs:label : tag</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#tag">pmopb:tag</a>
    /// </summary>
    let tag = _prefixId.prefix "tag"
    let tag_pag = _prefixId.prefix "tag-pag"
    let tag_ppt = _prefixId.prefix "tag-ppt"
    let tag_vsp = _prefixId.prefix "tag-vsp"
    /// <summary>
    ///   <para>rdfs:label : tense</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#tense">pmopb:tense</a>
    /// </summary>
    let tense = _prefixId.prefix "tense"
    let third = _prefixId.prefix "third"
    /// <summary>
    ///   <para>rdfs:label : voice</para>
    ///   <a href="http://premon.fbk.eu/ontology/pb#voice">pmopb:voice</a>
    /// </summary>
    let voice = _prefixId.prefix "voice"
