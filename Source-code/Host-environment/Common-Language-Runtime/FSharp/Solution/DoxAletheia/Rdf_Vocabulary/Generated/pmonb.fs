namespace http.premon.fbk.eu.ontology.nb.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pmonb =
    let _namespace_iri = Namespace_Iri pmonb |> NamespaceIRI
    /// <summary>
    ///   <para>pmonb:Argument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Argument (NB)"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#Argument">http://premon.fbk.eu/ontology/nb#Argument</seealso>
    let Argument = Prefixed_Name(pmonb, "Argument") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:Modifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Modifier (NB)"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#Modifier">http://premon.fbk.eu/ontology/nb#Modifier</seealso>
    let Modifier = Prefixed_Name(pmonb, "Modifier") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:NumberedArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Numbered Argument (NB)"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#NumberedArgument">http://premon.fbk.eu/ontology/nb#NumberedArgument</seealso>
    let NumberedArgument = Prefixed_Name(pmonb, "NumberedArgument") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:Roleset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Roleset (NB)"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#Roleset">http://premon.fbk.eu/ontology/nb#Roleset</seealso>
    let Roleset = Prefixed_Name(pmonb, "Roleset") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:SemanticRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Semantic Role (NB)"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#SemanticRole">http://premon.fbk.eu/ontology/nb#SemanticRole</seealso>
    let SemanticRole = Prefixed_Name(pmonb, "SemanticRole") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:Tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Tag"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#Tag">http://premon.fbk.eu/ontology/nb#Tag</seealso>
    let Tag = Prefixed_Name(pmonb, "Tag") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:arg0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmonb:NumberedArgument</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#arg0">http://premon.fbk.eu/ontology/nb#arg0</seealso>
    let arg0 = Prefixed_Name(pmonb, "arg0") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:arg1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmonb:NumberedArgument</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#arg1">http://premon.fbk.eu/ontology/nb#arg1</seealso>
    let arg1 = Prefixed_Name(pmonb, "arg1") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:arg2</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmonb:NumberedArgument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#arg2">http://premon.fbk.eu/ontology/nb#arg2</seealso>
    let arg2 = Prefixed_Name(pmonb, "arg2") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:arg3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmonb:NumberedArgument</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#arg3">http://premon.fbk.eu/ontology/nb#arg3</seealso>
    let arg3 = Prefixed_Name(pmonb, "arg3") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:arg4</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmonb:NumberedArgument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#arg4">http://premon.fbk.eu/ontology/nb#arg4</seealso>
    let arg4 = Prefixed_Name(pmonb, "arg4") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:arg5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmonb:NumberedArgument</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#arg5">http://premon.fbk.eu/ontology/nb#arg5</seealso>
    let arg5 = Prefixed_Name(pmonb, "arg5") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:argm-adv</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmonb:Modifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#argm-adv">http://premon.fbk.eu/ontology/nb#argm-adv</seealso>
    let argm_adv = Prefixed_Name(pmonb, "argm-adv") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:argm-cau</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmonb:Modifier</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#argm-cau">http://premon.fbk.eu/ontology/nb#argm-cau</seealso>
    let argm_cau = Prefixed_Name(pmonb, "argm-cau") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:argm-dir</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmonb:Modifier</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#argm-dir">http://premon.fbk.eu/ontology/nb#argm-dir</seealso>
    let argm_dir = Prefixed_Name(pmonb, "argm-dir") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:argm-dis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmonb:Modifier</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#argm-dis">http://premon.fbk.eu/ontology/nb#argm-dis</seealso>
    let argm_dis = Prefixed_Name(pmonb, "argm-dis") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:argm-ext</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmonb:Modifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#argm-ext">http://premon.fbk.eu/ontology/nb#argm-ext</seealso>
    let argm_ext = Prefixed_Name(pmonb, "argm-ext") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:argm-loc</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmonb:Modifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#argm-loc">http://premon.fbk.eu/ontology/nb#argm-loc</seealso>
    let argm_loc = Prefixed_Name(pmonb, "argm-loc") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:argm-mnr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmonb:Modifier</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#argm-mnr">http://premon.fbk.eu/ontology/nb#argm-mnr</seealso>
    let argm_mnr = Prefixed_Name(pmonb, "argm-mnr") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:argm-neg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmonb:Modifier</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#argm-neg">http://premon.fbk.eu/ontology/nb#argm-neg</seealso>
    let argm_neg = Prefixed_Name(pmonb, "argm-neg") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:argm-pnc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmonb:Modifier</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#argm-pnc">http://premon.fbk.eu/ontology/nb#argm-pnc</seealso>
    let argm_pnc = Prefixed_Name(pmonb, "argm-pnc") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:argm-prd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmonb:Modifier</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#argm-prd">http://premon.fbk.eu/ontology/nb#argm-prd</seealso>
    let argm_prd = Prefixed_Name(pmonb, "argm-prd") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:argm-tmp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmonb:Modifier</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#argm-tmp">http://premon.fbk.eu/ontology/nb#argm-tmp</seealso>
    let argm_tmp = Prefixed_Name(pmonb, "argm-tmp") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:argument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"argument"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#argument">http://premon.fbk.eu/ontology/nb#argument</seealso>
    let argument = Prefixed_Name(pmonb, "argument") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:core</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Set to true if the semantic role explicitly occurs in a frame file"</para>
    /// labels<para>"core"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#core">http://premon.fbk.eu/ontology/nb#core</seealso>
    let core = Prefixed_Name(pmonb, "core") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"tag"</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#tag">http://premon.fbk.eu/ontology/nb#tag</seealso>
    let tag = Prefixed_Name(pmonb, "tag") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:tag-prd</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmonb:Tag</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#tag-prd">http://premon.fbk.eu/ontology/nb#tag-prd</seealso>
    let tag_prd = Prefixed_Name(pmonb, "tag-prd") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:tag-ref</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmonb:Tag</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#tag-ref">http://premon.fbk.eu/ontology/nb#tag-ref</seealso>
    let tag_ref = Prefixed_Name(pmonb, "tag-ref") |> PrefixedName
    /// <summary>
    ///   <para>pmonb:tag-support</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmonb:Tag</para>
    /// </remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/nb#tag-support">http://premon.fbk.eu/ontology/nb#tag-support</seealso>
    let tag_support = Prefixed_Name(pmonb, "tag-support") |> PrefixedName
