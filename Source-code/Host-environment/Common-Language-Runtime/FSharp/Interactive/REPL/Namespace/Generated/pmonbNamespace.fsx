#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pmonb =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://premon.fbk.eu/ontology/nb#" "pmonb"

    /// <summary>
    ///   <para>rdfs:label : Argument (NB)</para>
    ///   <a href="http://premon.fbk.eu/ontology/nb#Argument">pmonb:Argument</a>
    /// </summary>
    let Argument = _prefixId.prefix "Argument"
    /// <summary>
    ///   <para>rdfs:label : Modifier (NB)</para>
    ///   <a href="http://premon.fbk.eu/ontology/nb#Modifier">pmonb:Modifier</a>
    /// </summary>
    let Modifier = _prefixId.prefix "Modifier"
    /// <summary>
    ///   <para>rdfs:label : Numbered Argument (NB)</para>
    ///   <a href="http://premon.fbk.eu/ontology/nb#NumberedArgument">pmonb:NumberedArgument</a>
    /// </summary>
    let NumberedArgument = _prefixId.prefix "NumberedArgument"
    /// <summary>
    ///   <para>rdfs:label : Roleset (NB)</para>
    ///   <a href="http://premon.fbk.eu/ontology/nb#Roleset">pmonb:Roleset</a>
    /// </summary>
    let Roleset = _prefixId.prefix "Roleset"
    /// <summary>
    ///   <para>rdfs:label : Semantic Role (NB)</para>
    ///   <a href="http://premon.fbk.eu/ontology/nb#SemanticRole">pmonb:SemanticRole</a>
    /// </summary>
    let SemanticRole = _prefixId.prefix "SemanticRole"
    /// <summary>
    ///   <para>rdfs:label : Tag</para>
    ///   <a href="http://premon.fbk.eu/ontology/nb#Tag">pmonb:Tag</a>
    /// </summary>
    let Tag = _prefixId.prefix "Tag"
    let arg0 = _prefixId.prefix "arg0"
    let arg1 = _prefixId.prefix "arg1"
    let arg2 = _prefixId.prefix "arg2"
    let arg3 = _prefixId.prefix "arg3"
    let arg4 = _prefixId.prefix "arg4"
    let arg5 = _prefixId.prefix "arg5"
    let argm_adv = _prefixId.prefix "argm-adv"
    let argm_cau = _prefixId.prefix "argm-cau"
    let argm_dir = _prefixId.prefix "argm-dir"
    let argm_dis = _prefixId.prefix "argm-dis"
    let argm_ext = _prefixId.prefix "argm-ext"
    let argm_loc = _prefixId.prefix "argm-loc"
    let argm_mnr = _prefixId.prefix "argm-mnr"
    let argm_neg = _prefixId.prefix "argm-neg"
    let argm_pnc = _prefixId.prefix "argm-pnc"
    let argm_prd = _prefixId.prefix "argm-prd"
    let argm_tmp = _prefixId.prefix "argm-tmp"
    /// <summary>
    ///   <para>rdfs:label : argument</para>
    ///   <a href="http://premon.fbk.eu/ontology/nb#argument">pmonb:argument</a>
    /// </summary>
    let argument = _prefixId.prefix "argument"
    /// <summary>
    ///   <para>rdfs:label : core</para>
    ///   <para>rdfs:comment : Set to true if the semantic role explicitly occurs in a frame file</para>
    ///   <a href="http://premon.fbk.eu/ontology/nb#core">pmonb:core</a>
    /// </summary>
    let core = _prefixId.prefix "core"
    /// <summary>
    ///   <para>rdfs:label : tag</para>
    ///   <a href="http://premon.fbk.eu/ontology/nb#tag">pmonb:tag</a>
    /// </summary>
    let tag = _prefixId.prefix "tag"
    let tag_prd = _prefixId.prefix "tag-prd"
    let tag_ref = _prefixId.prefix "tag-ref"
    let tag_support = _prefixId.prefix "tag-support"
