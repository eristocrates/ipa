namespace http.premon.fbk.eu.ontology.pb.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pmopb =
    let _namespace_iri = Namespace_Iri pmopb |> NamespaceIRI
    /// <summary>
    ///   <para>pmopb:Argument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Argument (PB)"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#Argument">http://premon.fbk.eu/ontology/pb#Argument</seealso>
    let Argument = Prefixed_Name(pmopb, "Argument") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:Aspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Aspect"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#Aspect">http://premon.fbk.eu/ontology/pb#Aspect</seealso>
    let Aspect = Prefixed_Name(pmopb, "Aspect") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:Form</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Form"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#Form">http://premon.fbk.eu/ontology/pb#Form</seealso>
    let Form = Prefixed_Name(pmopb, "Form") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:Inflection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Inflection"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#Inflection">http://premon.fbk.eu/ontology/pb#Inflection</seealso>
    let Inflection = Prefixed_Name(pmopb, "Inflection") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:Modifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Modifier (PB)"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#Modifier">http://premon.fbk.eu/ontology/pb#Modifier</seealso>
    let Modifier = Prefixed_Name(pmopb, "Modifier") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:NumberedArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Numbered Argument (PB)"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#NumberedArgument">http://premon.fbk.eu/ontology/pb#NumberedArgument</seealso>
    let NumberedArgument = Prefixed_Name(pmopb, "NumberedArgument") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Person"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#Person">http://premon.fbk.eu/ontology/pb#Person</seealso>
    let Person = Prefixed_Name(pmopb, "Person") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:Roleset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Roleset (PB)"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#Roleset">http://premon.fbk.eu/ontology/pb#Roleset</seealso>
    let Roleset = Prefixed_Name(pmopb, "Roleset") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:SecondaryAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Secondary Agent"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#SecondaryAgent">http://premon.fbk.eu/ontology/pb#SecondaryAgent</seealso>
    let SecondaryAgent = Prefixed_Name(pmopb, "SecondaryAgent") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:SemanticRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Semantic Role (PB)"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#SemanticRole">http://premon.fbk.eu/ontology/pb#SemanticRole</seealso>
    let SemanticRole = Prefixed_Name(pmopb, "SemanticRole") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:Tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Tag"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#Tag">http://premon.fbk.eu/ontology/pb#Tag</seealso>
    let Tag = Prefixed_Name(pmopb, "Tag") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:Tense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Tense"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#Tense">http://premon.fbk.eu/ontology/pb#Tense</seealso>
    let Tense = Prefixed_Name(pmopb, "Tense") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:Voice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Voice"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#Voice">http://premon.fbk.eu/ontology/pb#Voice</seealso>
    let Voice = Prefixed_Name(pmopb, "Voice") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:active</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmopb:Voice</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#active">http://premon.fbk.eu/ontology/pb#active</seealso>
    let active = Prefixed_Name(pmopb, "active") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:arg0</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:NumberedArgument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#arg0">http://premon.fbk.eu/ontology/pb#arg0</seealso>
    let arg0 = Prefixed_Name(pmopb, "arg0") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:arg1</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:NumberedArgument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#arg1">http://premon.fbk.eu/ontology/pb#arg1</seealso>
    let arg1 = Prefixed_Name(pmopb, "arg1") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:arg2</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:NumberedArgument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#arg2">http://premon.fbk.eu/ontology/pb#arg2</seealso>
    let arg2 = Prefixed_Name(pmopb, "arg2") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:arg3</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:NumberedArgument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#arg3">http://premon.fbk.eu/ontology/pb#arg3</seealso>
    let arg3 = Prefixed_Name(pmopb, "arg3") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:arg4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmopb:NumberedArgument</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#arg4">http://premon.fbk.eu/ontology/pb#arg4</seealso>
    let arg4 = Prefixed_Name(pmopb, "arg4") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:arg5</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:NumberedArgument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#arg5">http://premon.fbk.eu/ontology/pb#arg5</seealso>
    let arg5 = Prefixed_Name(pmopb, "arg5") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:arg6</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:NumberedArgument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#arg6">http://premon.fbk.eu/ontology/pb#arg6</seealso>
    let arg6 = Prefixed_Name(pmopb, "arg6") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:arga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmopb:SecondaryAgent</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#arga">http://premon.fbk.eu/ontology/pb#arga</seealso>
    let arga = Prefixed_Name(pmopb, "arga") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-adj</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Modifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-adj">http://premon.fbk.eu/ontology/pb#argm-adj</seealso>
    let argm_adj = Prefixed_Name(pmopb, "argm-adj") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-adv</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Modifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-adv">http://premon.fbk.eu/ontology/pb#argm-adv</seealso>
    let argm_adv = Prefixed_Name(pmopb, "argm-adv") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-cau</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmopb:Modifier</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-cau">http://premon.fbk.eu/ontology/pb#argm-cau</seealso>
    let argm_cau = Prefixed_Name(pmopb, "argm-cau") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-com</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Modifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-com">http://premon.fbk.eu/ontology/pb#argm-com</seealso>
    let argm_com = Prefixed_Name(pmopb, "argm-com") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-cxn</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Modifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-cxn">http://premon.fbk.eu/ontology/pb#argm-cxn</seealso>
    let argm_cxn = Prefixed_Name(pmopb, "argm-cxn") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-dir</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmopb:Modifier</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-dir">http://premon.fbk.eu/ontology/pb#argm-dir</seealso>
    let argm_dir = Prefixed_Name(pmopb, "argm-dir") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-dis</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Modifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-dis">http://premon.fbk.eu/ontology/pb#argm-dis</seealso>
    let argm_dis = Prefixed_Name(pmopb, "argm-dis") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-dsp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmopb:Modifier</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-dsp">http://premon.fbk.eu/ontology/pb#argm-dsp</seealso>
    let argm_dsp = Prefixed_Name(pmopb, "argm-dsp") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-ext</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Modifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-ext">http://premon.fbk.eu/ontology/pb#argm-ext</seealso>
    let argm_ext = Prefixed_Name(pmopb, "argm-ext") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-gol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmopb:Modifier</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-gol">http://premon.fbk.eu/ontology/pb#argm-gol</seealso>
    let argm_gol = Prefixed_Name(pmopb, "argm-gol") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-loc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmopb:Modifier</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-loc">http://premon.fbk.eu/ontology/pb#argm-loc</seealso>
    let argm_loc = Prefixed_Name(pmopb, "argm-loc") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-lvb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmopb:Modifier</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-lvb">http://premon.fbk.eu/ontology/pb#argm-lvb</seealso>
    let argm_lvb = Prefixed_Name(pmopb, "argm-lvb") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-mnr</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Modifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-mnr">http://premon.fbk.eu/ontology/pb#argm-mnr</seealso>
    let argm_mnr = Prefixed_Name(pmopb, "argm-mnr") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-mod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmopb:Modifier</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-mod">http://premon.fbk.eu/ontology/pb#argm-mod</seealso>
    let argm_mod = Prefixed_Name(pmopb, "argm-mod") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-neg</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Modifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-neg">http://premon.fbk.eu/ontology/pb#argm-neg</seealso>
    let argm_neg = Prefixed_Name(pmopb, "argm-neg") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-pnc</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Modifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-pnc">http://premon.fbk.eu/ontology/pb#argm-pnc</seealso>
    let argm_pnc = Prefixed_Name(pmopb, "argm-pnc") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-prd</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Modifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-prd">http://premon.fbk.eu/ontology/pb#argm-prd</seealso>
    let argm_prd = Prefixed_Name(pmopb, "argm-prd") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-prn</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Modifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-prn">http://premon.fbk.eu/ontology/pb#argm-prn</seealso>
    let argm_prn = Prefixed_Name(pmopb, "argm-prn") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-prp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Modifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-prp">http://premon.fbk.eu/ontology/pb#argm-prp</seealso>
    let argm_prp = Prefixed_Name(pmopb, "argm-prp") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-rcl</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Modifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-rcl">http://premon.fbk.eu/ontology/pb#argm-rcl</seealso>
    let argm_rcl = Prefixed_Name(pmopb, "argm-rcl") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-rec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmopb:Modifier</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-rec">http://premon.fbk.eu/ontology/pb#argm-rec</seealso>
    let argm_rec = Prefixed_Name(pmopb, "argm-rec") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-slc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmopb:Modifier</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-slc">http://premon.fbk.eu/ontology/pb#argm-slc</seealso>
    let argm_slc = Prefixed_Name(pmopb, "argm-slc") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-tmp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmopb:Modifier</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-tmp">http://premon.fbk.eu/ontology/pb#argm-tmp</seealso>
    let argm_tmp = Prefixed_Name(pmopb, "argm-tmp") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argm-vsp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Modifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argm-vsp">http://premon.fbk.eu/ontology/pb#argm-vsp</seealso>
    let argm_vsp = Prefixed_Name(pmopb, "argm-vsp") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:argument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"argument"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#argument">http://premon.fbk.eu/ontology/pb#argument</seealso>
    let argument = Prefixed_Name(pmopb, "argument") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:aspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"aspect"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#aspect">http://premon.fbk.eu/ontology/pb#aspect</seealso>
    let aspect = Prefixed_Name(pmopb, "aspect") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:core</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Set to true if the semantic role explicitly occurs in a frame file"</para>
    /// labels<para>"core"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#core">http://premon.fbk.eu/ontology/pb#core</seealso>
    let core = Prefixed_Name(pmopb, "core") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:form</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"form"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#form">http://premon.fbk.eu/ontology/pb#form</seealso>
    let form = Prefixed_Name(pmopb, "form") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:full</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Form</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#full">http://premon.fbk.eu/ontology/pb#full</seealso>
    let full = Prefixed_Name(pmopb, "full") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:future</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Tense</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#future">http://premon.fbk.eu/ontology/pb#future</seealso>
    let future = Prefixed_Name(pmopb, "future") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:gerund</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Form</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#gerund">http://premon.fbk.eu/ontology/pb#gerund</seealso>
    let gerund = Prefixed_Name(pmopb, "gerund") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:infinitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Form</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#infinitive">http://premon.fbk.eu/ontology/pb#infinitive</seealso>
    let infinitive = Prefixed_Name(pmopb, "infinitive") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:inflection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"inflection"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#inflection">http://premon.fbk.eu/ontology/pb#inflection</seealso>
    let inflection = Prefixed_Name(pmopb, "inflection") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmopb:Person</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#other">http://premon.fbk.eu/ontology/pb#other</seealso>
    let other = Prefixed_Name(pmopb, "other") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:participle</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Form</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#participle">http://premon.fbk.eu/ontology/pb#participle</seealso>
    let participle = Prefixed_Name(pmopb, "participle") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:passive</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Voice</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#passive">http://premon.fbk.eu/ontology/pb#passive</seealso>
    let passive = Prefixed_Name(pmopb, "passive") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:past</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Tense</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#past">http://premon.fbk.eu/ontology/pb#past</seealso>
    let past = Prefixed_Name(pmopb, "past") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:perfect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmopb:Aspect</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#perfect">http://premon.fbk.eu/ontology/pb#perfect</seealso>
    let perfect = Prefixed_Name(pmopb, "perfect") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"person"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#person">http://premon.fbk.eu/ontology/pb#person</seealso>
    let person = Prefixed_Name(pmopb, "person") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:present</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmopb:Tense</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#present">http://premon.fbk.eu/ontology/pb#present</seealso>
    let present = Prefixed_Name(pmopb, "present") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:progressive</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Aspect</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#progressive">http://premon.fbk.eu/ontology/pb#progressive</seealso>
    let progressive = Prefixed_Name(pmopb, "progressive") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"tag"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#tag">http://premon.fbk.eu/ontology/pb#tag</seealso>
    let tag = Prefixed_Name(pmopb, "tag") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:tag-pag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmopb:Tag</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#tag-pag">http://premon.fbk.eu/ontology/pb#tag-pag</seealso>
    let tag_pag = Prefixed_Name(pmopb, "tag-pag") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:tag-ppt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmopb:Tag</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#tag-ppt">http://premon.fbk.eu/ontology/pb#tag-ppt</seealso>
    let tag_ppt = Prefixed_Name(pmopb, "tag-ppt") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:tag-vsp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmopb:Tag</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#tag-vsp">http://premon.fbk.eu/ontology/pb#tag-vsp</seealso>
    let tag_vsp = Prefixed_Name(pmopb, "tag-vsp") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:tense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"tense"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#tense">http://premon.fbk.eu/ontology/pb#tense</seealso>
    let tense = Prefixed_Name(pmopb, "tense") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:third</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmopb:Person</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#third">http://premon.fbk.eu/ontology/pb#third</seealso>
    let third = Prefixed_Name(pmopb, "third") |> PrefixedName
    /// <summary>
    ///   <para>pmopb:voice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"voice"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/pb#voice">http://premon.fbk.eu/ontology/pb#voice</seealso>
    let voice = Prefixed_Name(pmopb, "voice") |> PrefixedName
