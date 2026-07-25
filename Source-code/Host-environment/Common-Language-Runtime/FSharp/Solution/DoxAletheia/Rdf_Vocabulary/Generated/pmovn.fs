namespace http.premon.fbk.eu.ontology.vn.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pmovn =
    let _namespace_iri = Namespace_Iri pmovn |> NamespaceIRI

    /// <summary>
    ///   <para>pmovn:AbsentAtomicRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Absent Atomic Restriction</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#AbsentAtomicRestriction">http://premon.fbk.eu/ontology/vn#AbsentAtomicRestriction</seealso>
    let AbsentAtomicRestriction =
        Prefixed_Name(pmovn, "AbsentAtomicRestriction") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:shape_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Non in the data</para>
    /// labels<para>shape</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#shape_rrp">http://premon.fbk.eu/ontology/vn#shape_rrp</seealso>
    let shape_rrp = Prefixed_Name(pmovn, "shape_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:body_part_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///
    /// labels<para>body_part</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#body_part_rrp">http://premon.fbk.eu/ontology/vn#body_part_rrp</seealso>
    let body_part_rrp = Prefixed_Name(pmovn, "body_part_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:substance_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///
    /// labels<para>substance</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#substance_rrp">http://premon.fbk.eu/ontology/vn#substance_rrp</seealso>
    let substance_rrp = Prefixed_Name(pmovn, "substance_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:concrete_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///
    /// labels<para>concrete</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#concrete_rrp">http://premon.fbk.eu/ontology/vn#concrete_rrp</seealso>
    let concrete_rrp = Prefixed_Name(pmovn, "concrete_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:biotic_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///
    /// labels<para>biotic</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#biotic_rrp">http://premon.fbk.eu/ontology/vn#biotic_rrp</seealso>
    let biotic_rrp = Prefixed_Name(pmovn, "biotic_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:vehicle_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>vehicle</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#vehicle_rrp">http://premon.fbk.eu/ontology/vn#vehicle_rrp</seealso>
    let vehicle_rrp = Prefixed_Name(pmovn, "vehicle_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:solid_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Non in the data</para>
    /// labels<para>solid</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#solid_rrp">http://premon.fbk.eu/ontology/vn#solid_rrp</seealso>
    let solid_rrp = Prefixed_Name(pmovn, "solid_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:abstract_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///
    /// labels<para>abstract</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#abstract_rrp">http://premon.fbk.eu/ontology/vn#abstract_rrp</seealso>
    let abstract_rrp = Prefixed_Name(pmovn, "abstract_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:state_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>state</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#state_rrp">http://premon.fbk.eu/ontology/vn#state_rrp</seealso>
    let state_rrp = Prefixed_Name(pmovn, "state_rrp") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:AndCompoundRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>default</para>
    /// labels<para>And Compound Restriction</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#AndCompoundRestriction">http://premon.fbk.eu/ontology/vn#AndCompoundRestriction</seealso>
    let AndCompoundRestriction =
        Prefixed_Name(pmovn, "AndCompoundRestriction") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:LexSynItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Not clear if there is an equivalent in lexInfo</para>
    /// labels<para>Lexical Syntactic Item</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#LexSynItem">http://premon.fbk.eu/ontology/vn#LexSynItem</seealso>
    let LexSynItem = Prefixed_Name(pmovn, "LexSynItem") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:NpSynItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>NP Syntactic Item</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#NpSynItem">http://premon.fbk.eu/ontology/vn#NpSynItem</seealso>
    let NpSynItem = Prefixed_Name(pmovn, "NpSynItem") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:SyntacticRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Syntactic Restriction</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#SyntacticRestriction">http://premon.fbk.eu/ontology/vn#SyntacticRestriction</seealso>
    let SyntacticRestriction =
        Prefixed_Name(pmovn, "SyntacticRestriction") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:PredType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Predicate Type</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#PredType">http://premon.fbk.eu/ontology/vn#PredType</seealso>
    let PredType = Prefixed_Name(pmovn, "PredType") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:VerbSynItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Verb Syntactic Item</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#VerbSynItem">http://premon.fbk.eu/ontology/vn#VerbSynItem</seealso>
    let VerbSynItem = Prefixed_Name(pmovn, "VerbSynItem") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:adv_loc_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>adv_loc</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#adv_loc_syrp">http://premon.fbk.eu/ontology/vn#adv_loc_syrp</seealso>
    let adv_loc_syrp = Prefixed_Name(pmovn, "adv_loc_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:np_ing_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>np_ing</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#np_ing_syrp">http://premon.fbk.eu/ontology/vn#np_ing_syrp</seealso>
    let np_ing_syrp = Prefixed_Name(pmovn, "np_ing_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:oc_ing_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>oc_ing</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#oc_ing_syrp">http://premon.fbk.eu/ontology/vn#oc_ing_syrp</seealso>
    let oc_ing_syrp = Prefixed_Name(pmovn, "oc_ing_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:sc_to_inf_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>sc_to_inf</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#sc_to_inf_syrp">http://premon.fbk.eu/ontology/vn#sc_to_inf_syrp</seealso>
    let sc_to_inf_syrp = Prefixed_Name(pmovn, "sc_to_inf_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:wheth_inf_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>wheth_inf</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#wheth_inf_syrp">http://premon.fbk.eu/ontology/vn#wheth_inf_syrp</seealso>
    let wheth_inf_syrp = Prefixed_Name(pmovn, "wheth_inf_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:oc_to_inf_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>oc_to_inf</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#oc_to_inf_syrp">http://premon.fbk.eu/ontology/vn#oc_to_inf_syrp</seealso>
    let oc_to_inf_syrp = Prefixed_Name(pmovn, "oc_to_inf_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:np_p_ing_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>np_p_ing</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#np_p_ing_syrp">http://premon.fbk.eu/ontology/vn#np_p_ing_syrp</seealso>
    let np_p_ing_syrp = Prefixed_Name(pmovn, "np_p_ing_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:wh_ing_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>wh_ing</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#wh_ing_syrp">http://premon.fbk.eu/ontology/vn#wh_ing_syrp</seealso>
    let wh_ing_syrp = Prefixed_Name(pmovn, "wh_ing_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:to_be_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>to_be</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#to_be_syrp">http://premon.fbk.eu/ontology/vn#to_be_syrp</seealso>
    let to_be_syrp = Prefixed_Name(pmovn, "to_be_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:wh_extract_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>wh_extract</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#wh_extract_syrp">http://premon.fbk.eu/ontology/vn#wh_extract_syrp</seealso>
    let wh_extract_syrp = Prefixed_Name(pmovn, "wh_extract_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:plural_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>plural</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#plural_syrp">http://premon.fbk.eu/ontology/vn#plural_syrp</seealso>
    let plural_syrp = Prefixed_Name(pmovn, "plural_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:quotation_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>quotation</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#quotation_syrp">http://premon.fbk.eu/ontology/vn#quotation_syrp</seealso>
    let quotation_syrp = Prefixed_Name(pmovn, "quotation_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:rs_to_inf_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>rs_to_inf</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#rs_to_inf_syrp">http://premon.fbk.eu/ontology/vn#rs_to_inf_syrp</seealso>
    let rs_to_inf_syrp = Prefixed_Name(pmovn, "rs_to_inf_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:np_tobe_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>np_tobe</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#np_tobe_syrp">http://premon.fbk.eu/ontology/vn#np_tobe_syrp</seealso>
    let np_tobe_syrp = Prefixed_Name(pmovn, "np_tobe_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:definite_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>definite</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#definite_syrp">http://premon.fbk.eu/ontology/vn#definite_syrp</seealso>
    let definite_syrp = Prefixed_Name(pmovn, "definite_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:poss_ing_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>poss_ing</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#poss_ing_syrp">http://premon.fbk.eu/ontology/vn#poss_ing_syrp</seealso>
    let poss_ing_syrp = Prefixed_Name(pmovn, "poss_ing_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:body_part_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>body_part</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#body_part_syrp">http://premon.fbk.eu/ontology/vn#body_part_syrp</seealso>
    let body_part_syrp = Prefixed_Name(pmovn, "body_part_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:refl_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>refl</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#refl_syrp">http://premon.fbk.eu/ontology/vn#refl_syrp</seealso>
    let refl_syrp = Prefixed_Name(pmovn, "refl_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:AtomicRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Atomic Restriction</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#AtomicRestriction">http://premon.fbk.eu/ontology/vn#AtomicRestriction</seealso>
    let AtomicRestriction = Prefixed_Name(pmovn, "AtomicRestriction") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:AdvSynItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Adverb Syntactic Item</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#AdvSynItem">http://premon.fbk.eu/ontology/vn#AdvSynItem</seealso>
    let AdvSynItem = Prefixed_Name(pmovn, "AdvSynItem") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:CompoundRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Compound Restriction</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#CompoundRestriction">http://premon.fbk.eu/ontology/vn#CompoundRestriction</seealso>
    let CompoundRestriction =
        Prefixed_Name(pmovn, "CompoundRestriction") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:time_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>time</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#time_rrp">http://premon.fbk.eu/ontology/vn#time_rrp</seealso>
    let time_rrp = Prefixed_Name(pmovn, "time_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:VerbClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Verb Class (VN)</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#VerbClass">http://premon.fbk.eu/ontology/vn#VerbClass</seealso>
    let VerbClass = Prefixed_Name(pmovn, "VerbClass") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:ThematicRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Thematic Role (VN)</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#ThematicRole">http://premon.fbk.eu/ontology/vn#ThematicRole</seealso>
    let ThematicRole = Prefixed_Name(pmovn, "ThematicRole") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:thematicRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>thematic role</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#thematicRole">http://premon.fbk.eu/ontology/vn#thematicRole</seealso>
    let thematicRole = Prefixed_Name(pmovn, "thematicRole") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Syntactic Restriction Property</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#SyntacticRestrictionProperty">http://premon.fbk.eu/ontology/vn#SyntacticRestrictionProperty</seealso>
    let SyntacticRestrictionProperty =
        Prefixed_Name(pmovn, "SyntacticRestrictionProperty") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:np_omit_ing_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>np_omit_ing</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#np_omit_ing_syrp">http://premon.fbk.eu/ontology/vn#np_omit_ing_syrp</seealso>
    let np_omit_ing_syrp = Prefixed_Name(pmovn, "np_omit_ing_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:tensed_that_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>tensed_that</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#tensed_that_syrp">http://premon.fbk.eu/ontology/vn#tensed_that_syrp</seealso>
    let tensed_that_syrp = Prefixed_Name(pmovn, "tensed_that_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:small_clause_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>small_clause</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#small_clause_syrp">http://premon.fbk.eu/ontology/vn#small_clause_syrp</seealso>
    let small_clause_syrp = Prefixed_Name(pmovn, "small_clause_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:genitive_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>genitive</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#genitive_syrp">http://premon.fbk.eu/ontology/vn#genitive_syrp</seealso>
    let genitive_syrp = Prefixed_Name(pmovn, "genitive_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:what_extract_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>what_extract</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#what_extract_syrp">http://premon.fbk.eu/ontology/vn#what_extract_syrp</seealso>
    let what_extract_syrp = Prefixed_Name(pmovn, "what_extract_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:oc_bare_inf_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>oc_bare_inf</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#oc_bare_inf_syrp">http://premon.fbk.eu/ontology/vn#oc_bare_inf_syrp</seealso>
    let oc_bare_inf_syrp = Prefixed_Name(pmovn, "oc_bare_inf_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:that_comp_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>that_comp</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#that_comp_syrp">http://premon.fbk.eu/ontology/vn#that_comp_syrp</seealso>
    let that_comp_syrp = Prefixed_Name(pmovn, "that_comp_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:ac_ing_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ac_ing</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#ac_ing_syrp">http://premon.fbk.eu/ontology/vn#ac_ing_syrp</seealso>
    let ac_ing_syrp = Prefixed_Name(pmovn, "ac_ing_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:wh_inf_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>wh_inf</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#wh_inf_syrp">http://premon.fbk.eu/ontology/vn#wh_inf_syrp</seealso>
    let wh_inf_syrp = Prefixed_Name(pmovn, "wh_inf_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:be_sc_ing_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>be_sc_ing</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#be_sc_ing_syrp">http://premon.fbk.eu/ontology/vn#be_sc_ing_syrp</seealso>
    let be_sc_ing_syrp = Prefixed_Name(pmovn, "be_sc_ing_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:VerbNetFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Syntactic Frame (VN)</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#VerbNetFrame">http://premon.fbk.eu/ontology/vn#VerbNetFrame</seealso>
    let VerbNetFrame = Prefixed_Name(pmovn, "VerbNetFrame") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>abstract, non instantiated in the dataset</para>
    /// labels<para>actor</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#actor">http://premon.fbk.eu/ontology/vn#actor</seealso>
    let actor = Prefixed_Name(pmovn, "actor") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>agent</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#agent">http://premon.fbk.eu/ontology/vn#agent</seealso>
    let agent = Prefixed_Name(pmovn, "agent") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:natural_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///
    /// labels<para>natural</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#natural_rrp">http://premon.fbk.eu/ontology/vn#natural_rrp</seealso>
    let natural_rrp = Prefixed_Name(pmovn, "natural_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:ThematicRole</para>
    ///
    /// labels<para>value</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#value">http://premon.fbk.eu/ontology/vn#value</seealso>
    let value = Prefixed_Name(pmovn, "value") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:attribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>attribute</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#attribute">http://premon.fbk.eu/ontology/vn#attribute</seealso>
    let attribute = Prefixed_Name(pmovn, "attribute") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:undergoer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>abstract, non instantiated in the dataset</para>
    /// labels<para>undergoer</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#undergoer">http://premon.fbk.eu/ontology/vn#undergoer</seealso>
    let undergoer = Prefixed_Name(pmovn, "undergoer") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:beneficiary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:ThematicRole</para>
    ///
    /// labels<para>beneficiary</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#beneficiary">http://premon.fbk.eu/ontology/vn#beneficiary</seealso>
    let beneficiary = Prefixed_Name(pmovn, "beneficiary") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:coTheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:ThematicRole</para>
    ///
    /// labels<para>co-theme</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#coTheme">http://premon.fbk.eu/ontology/vn#coTheme</seealso>
    let coTheme = Prefixed_Name(pmovn, "coTheme") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:definesFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>defines frame</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#definesFrame">http://premon.fbk.eu/ontology/vn#definesFrame</seealso>
    let definesFrame = Prefixed_Name(pmovn, "definesFrame") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:frame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>frame</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#frame">http://premon.fbk.eu/ontology/vn#frame</seealso>
    let frame = Prefixed_Name(pmovn, "frame") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:definesSemRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>defines semantic role</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#definesSemRole">http://premon.fbk.eu/ontology/vn#definesSemRole</seealso>
    let definesSemRole = Prefixed_Name(pmovn, "definesSemRole") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:destination</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>destination</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#destination">http://premon.fbk.eu/ontology/vn#destination</seealso>
    let destination = Prefixed_Name(pmovn, "destination") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:goal</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>goal</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#goal">http://premon.fbk.eu/ontology/vn#goal</seealso>
    let goal = Prefixed_Name(pmovn, "goal") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:ThematicRole</para>
    ///
    /// labels<para>location</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#location">http://premon.fbk.eu/ontology/vn#location</seealso>
    let location = Prefixed_Name(pmovn, "location") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:ThematicRole</para>
    ///
    /// labels<para>time</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#time">http://premon.fbk.eu/ontology/vn#time</seealso>
    let time = Prefixed_Name(pmovn, "time") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:experiencer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:ThematicRole</para>
    ///
    /// labels<para>experiencer</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#experiencer">http://premon.fbk.eu/ontology/vn#experiencer</seealso>
    let experiencer = Prefixed_Name(pmovn, "experiencer") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:patient</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>patient</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#patient">http://premon.fbk.eu/ontology/vn#patient</seealso>
    let patient = Prefixed_Name(pmovn, "patient") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:extent</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>extent</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#extent">http://premon.fbk.eu/ontology/vn#extent</seealso>
    let extent = Prefixed_Name(pmovn, "extent") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:finalTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>final time</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#finalTime">http://premon.fbk.eu/ontology/vn#finalTime</seealso>
    let finalTime = Prefixed_Name(pmovn, "finalTime") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:frameDescNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>frame description number</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#frameDescNumber">http://premon.fbk.eu/ontology/vn#frameDescNumber</seealso>
    let frameDescNumber = Prefixed_Name(pmovn, "frameDescNumber") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:framePrimary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>frame primary</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#framePrimary">http://premon.fbk.eu/ontology/vn#framePrimary</seealso>
    let framePrimary = Prefixed_Name(pmovn, "framePrimary") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:frameSecondary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>frame secondary</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#frameSecondary">http://premon.fbk.eu/ontology/vn#frameSecondary</seealso>
    let frameSecondary = Prefixed_Name(pmovn, "frameSecondary") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:frameSemanticsDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>String representing the semantics of the Frame</para>
    /// labels<para>frame semantics description</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#frameSemanticsDescription">http://premon.fbk.eu/ontology/vn#frameSemanticsDescription</seealso>
    let frameSemanticsDescription =
        Prefixed_Name(pmovn, "frameSemanticsDescription") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:frameSyntaxDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>String representing the syntax of the Frame</para>
    /// labels<para>frame syntax description</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#frameSyntaxDescription">http://premon.fbk.eu/ontology/vn#frameSyntaxDescription</seealso>
    let frameSyntaxDescription =
        Prefixed_Name(pmovn, "frameSyntaxDescription") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:frameXtag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>frame xtag</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#frameXtag">http://premon.fbk.eu/ontology/vn#frameXtag</seealso>
    let frameXtag = Prefixed_Name(pmovn, "frameXtag") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:ThematicRole</para>
    ///
    /// labels<para>frequency</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#frequency">http://premon.fbk.eu/ontology/vn#frequency</seealso>
    let frequency = Prefixed_Name(pmovn, "frequency") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>abstract, non instantiated in the dataset</para>
    /// labels<para>place</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#place">http://premon.fbk.eu/ontology/vn#place</seealso>
    let place = Prefixed_Name(pmovn, "place") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:idea_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>idea</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#idea_rrp">http://premon.fbk.eu/ontology/vn#idea_rrp</seealso>
    let idea_rrp = Prefixed_Name(pmovn, "idea_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:initialLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:ThematicRole</para>
    ///
    /// labels<para>initial location</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#initialLocation">http://premon.fbk.eu/ontology/vn#initialLocation</seealso>
    let initialLocation = Prefixed_Name(pmovn, "initialLocation") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:ThematicRole</para>
    ///
    /// labels<para>source</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#source">http://premon.fbk.eu/ontology/vn#source</seealso>
    let source = Prefixed_Name(pmovn, "source") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:initialTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:ThematicRole</para>
    ///
    /// labels<para>initial time</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#initialTime">http://premon.fbk.eu/ontology/vn#initialTime</seealso>
    let initialTime = Prefixed_Name(pmovn, "initialTime") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:instrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>instrument</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#instrument">http://premon.fbk.eu/ontology/vn#instrument</seealso>
    let instrument = Prefixed_Name(pmovn, "instrument") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:SynItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Syntactic Item</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#SynItem">http://premon.fbk.eu/ontology/vn#SynItem</seealso>
    let SynItem = Prefixed_Name(pmovn, "SynItem") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:ExistAtomicRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Exist Atomic Restriction</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#ExistAtomicRestriction">http://premon.fbk.eu/ontology/vn#ExistAtomicRestriction</seealso>
    let ExistAtomicRestriction =
        Prefixed_Name(pmovn, "ExistAtomicRestriction") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:Restriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Restriction</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#Restriction">http://premon.fbk.eu/ontology/vn#Restriction</seealso>
    let Restriction = Prefixed_Name(pmovn, "Restriction") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:AuxnpType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Auxiliary NP Type</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#AuxnpType">http://premon.fbk.eu/ontology/vn#AuxnpType</seealso>
    let AuxnpType = Prefixed_Name(pmovn, "AuxnpType") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:np_auxnpType</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:AuxnpType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>NP</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#np_auxnpType">http://premon.fbk.eu/ontology/vn#np_auxnpType</seealso>
    let np_auxnpType = Prefixed_Name(pmovn, "np_auxnpType") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:OrCompoundRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Or Compound Restriction</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#OrCompoundRestriction">http://premon.fbk.eu/ontology/vn#OrCompoundRestriction</seealso>
    let OrCompoundRestriction =
        Prefixed_Name(pmovn, "OrCompoundRestriction") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:EventPredArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Event Predicate Argument</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#EventPredArg">http://premon.fbk.eu/ontology/vn#EventPredArg</seealso>
    let EventPredArg = Prefixed_Name(pmovn, "EventPredArg") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:resultEventArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:EventPredArgType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>result of event</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#resultEventArg">http://premon.fbk.eu/ontology/vn#resultEventArg</seealso>
    let resultEventArg = Prefixed_Name(pmovn, "resultEventArg") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:duringEventArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:EventPredArgType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>during event</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#duringEventArg">http://premon.fbk.eu/ontology/vn#duringEventArg</seealso>
    let duringEventArg = Prefixed_Name(pmovn, "duringEventArg") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:ImplicitPredArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Implicit Predicate Argument</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#ImplicitPredArg">http://premon.fbk.eu/ontology/vn#ImplicitPredArg</seealso>
    let ImplicitPredArg = Prefixed_Name(pmovn, "ImplicitPredArg") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:NegPred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Negated Predicate</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#NegPred">http://premon.fbk.eu/ontology/vn#NegPred</seealso>
    let NegPred = Prefixed_Name(pmovn, "NegPred") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:SemanticRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Semantic Role (VN)</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#SemanticRole">http://premon.fbk.eu/ontology/vn#SemanticRole</seealso>
    let SemanticRole = Prefixed_Name(pmovn, "SemanticRole") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:restriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>restriction</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#restriction">http://premon.fbk.eu/ontology/vn#restriction</seealso>
    let restriction = Prefixed_Name(pmovn, "restriction") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:RoleSelectionalRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Role Selectional Restriction</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#RoleSelectionalRestriction">http://premon.fbk.eu/ontology/vn#RoleSelectionalRestriction</seealso>
    let RoleSelectionalRestriction =
        Prefixed_Name(pmovn, "RoleSelectionalRestriction") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:frameExample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>directly associates a VerbNet frame to its corresponding example</para>
    /// labels<para>frame example</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#frameExample">http://premon.fbk.eu/ontology/vn#frameExample</seealso>
    let frameExample = Prefixed_Name(pmovn, "frameExample") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:oblique_auxnpType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:AuxnpType</para>
    ///
    /// labels<para>Oblique</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#oblique_auxnpType">http://premon.fbk.eu/ontology/vn#oblique_auxnpType</seealso>
    let oblique_auxnpType = Prefixed_Name(pmovn, "oblique_auxnpType") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:oblique2_auxnpType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:AuxnpType</para>
    ///
    /// labels<para>Oblique2</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#oblique2_auxnpType">http://premon.fbk.eu/ontology/vn#oblique2_auxnpType</seealso>
    let oblique2_auxnpType = Prefixed_Name(pmovn, "oblique2_auxnpType") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:PredArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Predicate Argument</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#PredArg">http://premon.fbk.eu/ontology/vn#PredArg</seealso>
    let PredArg = Prefixed_Name(pmovn, "PredArg") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:EventPredArgType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Event Predicate Argument Type</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#EventPredArgType">http://premon.fbk.eu/ontology/vn#EventPredArgType</seealso>
    let EventPredArgType = Prefixed_Name(pmovn, "EventPredArgType") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:startEventArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:EventPredArgType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>start of event</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#startEventArg">http://premon.fbk.eu/ontology/vn#startEventArg</seealso>
    let startEventArg = Prefixed_Name(pmovn, "startEventArg") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:coAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>co-agent</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#coAgent">http://premon.fbk.eu/ontology/vn#coAgent</seealso>
    let coAgent = Prefixed_Name(pmovn, "coAgent") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:oblique1_auxnpType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:AuxnpType</para>
    ///
    /// labels<para>Oblique1</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#oblique1_auxnpType">http://premon.fbk.eu/ontology/vn#oblique1_auxnpType</seealso>
    let oblique1_auxnpType = Prefixed_Name(pmovn, "oblique1_auxnpType") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:vc_to_inf_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>vc_to_inf</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#vc_to_inf_syrp">http://premon.fbk.eu/ontology/vn#vc_to_inf_syrp</seealso>
    let vc_to_inf_syrp = Prefixed_Name(pmovn, "vc_to_inf_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:how_extract_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>how_extract</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#how_extract_syrp">http://premon.fbk.eu/ontology/vn#how_extract_syrp</seealso>
    let how_extract_syrp = Prefixed_Name(pmovn, "how_extract_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:np_ppart_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>np_ppart</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#np_ppart_syrp">http://premon.fbk.eu/ontology/vn#np_ppart_syrp</seealso>
    let np_ppart_syrp = Prefixed_Name(pmovn, "np_ppart_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:np_to_inf_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>np_to_inf</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#np_to_inf_syrp">http://premon.fbk.eu/ontology/vn#np_to_inf_syrp</seealso>
    let np_to_inf_syrp = Prefixed_Name(pmovn, "np_to_inf_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:sentential_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>sentential</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#sentential_syrp">http://premon.fbk.eu/ontology/vn#sentential_syrp</seealso>
    let sentential_syrp = Prefixed_Name(pmovn, "sentential_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:sc_ing_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>sc_ing</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#sc_ing_syrp">http://premon.fbk.eu/ontology/vn#sc_ing_syrp</seealso>
    let sc_ing_syrp = Prefixed_Name(pmovn, "sc_ing_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:what_inf_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>what_inf</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#what_inf_syrp">http://premon.fbk.eu/ontology/vn#what_inf_syrp</seealso>
    let what_inf_syrp = Prefixed_Name(pmovn, "what_inf_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:wh_comp_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>wh_comp</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#wh_comp_syrp">http://premon.fbk.eu/ontology/vn#wh_comp_syrp</seealso>
    let wh_comp_syrp = Prefixed_Name(pmovn, "wh_comp_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:acc_ing_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>acc_ing</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#acc_ing_syrp">http://premon.fbk.eu/ontology/vn#acc_ing_syrp</seealso>
    let acc_ing_syrp = Prefixed_Name(pmovn, "acc_ing_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:for_comp_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>for_comp</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#for_comp_syrp">http://premon.fbk.eu/ontology/vn#for_comp_syrp</seealso>
    let for_comp_syrp = Prefixed_Name(pmovn, "for_comp_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:ac_to_inf_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///
    /// labels<para>ac_to_inf</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#ac_to_inf_syrp">http://premon.fbk.eu/ontology/vn#ac_to_inf_syrp</seealso>
    let ac_to_inf_syrp = Prefixed_Name(pmovn, "ac_to_inf_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:ConstantPredArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Constant Predicate Argument</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#ConstantPredArg">http://premon.fbk.eu/ontology/vn#ConstantPredArg</seealso>
    let ConstantPredArg = Prefixed_Name(pmovn, "ConstantPredArg") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:endEventArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:EventPredArgType</para>
    ///
    /// labels<para>end of event</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#endEventArg">http://premon.fbk.eu/ontology/vn#endEventArg</seealso>
    let endEventArg = Prefixed_Name(pmovn, "endEventArg") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>duration</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#duration">http://premon.fbk.eu/ontology/vn#duration</seealso>
    let duration = Prefixed_Name(pmovn, "duration") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>abstract, non instantiated in the dataset.</para>
    /// labels<para>participant</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#participant">http://premon.fbk.eu/ontology/vn#participant</seealso>
    let participant = Prefixed_Name(pmovn, "participant") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:asset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:ThematicRole</para>
    ///
    /// labels<para>asset</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#asset">http://premon.fbk.eu/ontology/vn#asset</seealso>
    let asset = Prefixed_Name(pmovn, "asset") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:cause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:ThematicRole</para>
    ///
    /// labels<para>cause</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#cause">http://premon.fbk.eu/ontology/vn#cause</seealso>
    let cause = Prefixed_Name(pmovn, "cause") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:coPatient</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>co-patient</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#coPatient">http://premon.fbk.eu/ontology/vn#coPatient</seealso>
    let coPatient = Prefixed_Name(pmovn, "coPatient") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:Pred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Predicate</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#Pred">http://premon.fbk.eu/ontology/vn#Pred</seealso>
    let Pred = Prefixed_Name(pmovn, "Pred") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:ThemRolePredArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Thematic Role Predicate Argument</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#ThemRolePredArg">http://premon.fbk.eu/ontology/vn#ThemRolePredArg</seealso>
    let ThemRolePredArg = Prefixed_Name(pmovn, "ThemRolePredArg") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:PrepSynItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Preposition Syntactic Item</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#PrepSynItem">http://premon.fbk.eu/ontology/vn#PrepSynItem</seealso>
    let PrepSynItem = Prefixed_Name(pmovn, "PrepSynItem") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:material</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:ThematicRole</para>
    ///
    /// labels<para>material</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#material">http://premon.fbk.eu/ontology/vn#material</seealso>
    let material = Prefixed_Name(pmovn, "material") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:VerbSpecificPredArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Verb Specific Predicate Argument</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#VerbSpecificPredArg">http://premon.fbk.eu/ontology/vn#VerbSpecificPredArg</seealso>
    let VerbSpecificPredArg =
        Prefixed_Name(pmovn, "VerbSpecificPredArg") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:ThematicRole</para>
    ///
    /// labels<para>product</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#product">http://premon.fbk.eu/ontology/vn#product</seealso>
    let product = Prefixed_Name(pmovn, "product") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:pivot</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>pivot</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#pivot">http://premon.fbk.eu/ontology/vn#pivot</seealso>
    let pivot = Prefixed_Name(pmovn, "pivot") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:plural_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///
    /// labels<para>plural</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#plural_rrp">http://premon.fbk.eu/ontology/vn#plural_rrp</seealso>
    let plural_rrp = Prefixed_Name(pmovn, "plural_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:pos_ing</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>pos_ing</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#pos_ing">http://premon.fbk.eu/ontology/vn#pos_ing</seealso>
    let pos_ing = Prefixed_Name(pmovn, "pos_ing") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>predicate</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#predicate">http://premon.fbk.eu/ontology/vn#predicate</seealso>
    let predicate = Prefixed_Name(pmovn, "predicate") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:result</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>result</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#result">http://premon.fbk.eu/ontology/vn#result</seealso>
    let result = Prefixed_Name(pmovn, "result") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:recipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>recipient</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#recipient">http://premon.fbk.eu/ontology/vn#recipient</seealso>
    let recipient = Prefixed_Name(pmovn, "recipient") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:PrepositionSelectionalRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Preposition Selectional Restriction</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#PrepositionSelectionalRestriction">http://premon.fbk.eu/ontology/vn#PrepositionSelectionalRestriction</seealso>
    let PrepositionSelectionalRestriction =
        Prefixed_Name(pmovn, "PrepositionSelectionalRestriction") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:PrepositionRestrictionProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Preposition Selectional Restriction Property</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#PrepositionRestrictionProperty">http://premon.fbk.eu/ontology/vn#PrepositionRestrictionProperty</seealso>
    let PrepositionRestrictionProperty =
        Prefixed_Name(pmovn, "PrepositionRestrictionProperty") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:SelectionalRestrictionProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Selectional Restriction Property</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#SelectionalRestrictionProperty">http://premon.fbk.eu/ontology/vn#SelectionalRestrictionProperty</seealso>
    let SelectionalRestrictionProperty =
        Prefixed_Name(pmovn, "SelectionalRestrictionProperty") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:path_prp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:PrepositionRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>path</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#path_prp">http://premon.fbk.eu/ontology/vn#path_prp</seealso>
    let path_prp = Prefixed_Name(pmovn, "path_prp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:spatial_prp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:PrepositionRestrictionProperty</para>
    ///
    /// labels<para>spatial</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#spatial_prp">http://premon.fbk.eu/ontology/vn#spatial_prp</seealso>
    let spatial_prp = Prefixed_Name(pmovn, "spatial_prp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:reflexive</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>reflexive</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#reflexive">http://premon.fbk.eu/ontology/vn#reflexive</seealso>
    let reflexive = Prefixed_Name(pmovn, "reflexive") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:stimulus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:ThematicRole</para>
    ///
    /// labels<para>stimulus</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#stimulus">http://premon.fbk.eu/ontology/vn#stimulus</seealso>
    let stimulus = Prefixed_Name(pmovn, "stimulus") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:to_inf_rs_syrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:SyntacticRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>to_inf_rs</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#to_inf_rs_syrp">http://premon.fbk.eu/ontology/vn#to_inf_rs_syrp</seealso>
    let to_inf_rs_syrp = Prefixed_Name(pmovn, "to_inf_rs_syrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:trajectory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:ThematicRole</para>
    ///
    /// labels<para>trajectory</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#trajectory">http://premon.fbk.eu/ontology/vn#trajectory</seealso>
    let trajectory = Prefixed_Name(pmovn, "trajectory") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:loc_prp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:PrepositionRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>loc</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#loc_prp">http://premon.fbk.eu/ontology/vn#loc_prp</seealso>
    let loc_prp = Prefixed_Name(pmovn, "loc_prp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:dest_conf_prp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:PrepositionRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>dest_conf</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#dest_conf_prp">http://premon.fbk.eu/ontology/vn#dest_conf_prp</seealso>
    let dest_conf_prp = Prefixed_Name(pmovn, "dest_conf_prp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:dest_prp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:PrepositionRestrictionProperty</para>
    ///
    /// labels<para>dest</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#dest_prp">http://premon.fbk.eu/ontology/vn#dest_prp</seealso>
    let dest_prp = Prefixed_Name(pmovn, "dest_prp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:plural_prp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:PrepositionRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>plural</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#plural_prp">http://premon.fbk.eu/ontology/vn#plural_prp</seealso>
    let plural_prp = Prefixed_Name(pmovn, "plural_prp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:subclassOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>subclass of</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#subclassOf">http://premon.fbk.eu/ontology/vn#subclassOf</seealso>
    let subclassOf = Prefixed_Name(pmovn, "subclassOf") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:theme</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>theme</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#theme">http://premon.fbk.eu/ontology/vn#theme</seealso>
    let theme = Prefixed_Name(pmovn, "theme") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:dir_prp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:PrepositionRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>dir</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#dir_prp">http://premon.fbk.eu/ontology/vn#dir_prp</seealso>
    let dir_prp = Prefixed_Name(pmovn, "dir_prp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:ThematicRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>topic</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#topic">http://premon.fbk.eu/ontology/vn#topic</seealso>
    let topic = Prefixed_Name(pmovn, "topic") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:src_prp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:PrepositionRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>src</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#src_prp">http://premon.fbk.eu/ontology/vn#src_prp</seealso>
    let src_prp = Prefixed_Name(pmovn, "src_prp") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:SelectionalRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Selectional Restriction</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#SelectionalRestriction">http://premon.fbk.eu/ontology/vn#SelectionalRestriction</seealso>
    let SelectionalRestriction =
        Prefixed_Name(pmovn, "SelectionalRestriction") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:RestrictionProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Restriction Property</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#RestrictionProperty">http://premon.fbk.eu/ontology/vn#RestrictionProperty</seealso>
    let RestrictionProperty =
        Prefixed_Name(pmovn, "RestrictionProperty") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:pointy_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///
    /// labels<para>pointy</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#pointy_rrp">http://premon.fbk.eu/ontology/vn#pointy_rrp</seealso>
    let pointy_rrp = Prefixed_Name(pmovn, "pointy_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:scalar_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>scalar</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#scalar_rrp">http://premon.fbk.eu/ontology/vn#scalar_rrp</seealso>
    let scalar_rrp = Prefixed_Name(pmovn, "scalar_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:region_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///
    /// labels<para>region</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#region_rrp">http://premon.fbk.eu/ontology/vn#region_rrp</seealso>
    let region_rrp = Prefixed_Name(pmovn, "region_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:plant_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>Non in the data</para>
    /// labels<para>plant</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#plant_rrp">http://premon.fbk.eu/ontology/vn#plant_rrp</seealso>
    let plant_rrp = Prefixed_Name(pmovn, "plant_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:human_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>human</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#human_rrp">http://premon.fbk.eu/ontology/vn#human_rrp</seealso>
    let human_rrp = Prefixed_Name(pmovn, "human_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:organization_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>organization</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#organization_rrp">http://premon.fbk.eu/ontology/vn#organization_rrp</seealso>
    let organization_rrp = Prefixed_Name(pmovn, "organization_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:tool_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Non in the data</para>
    /// labels<para>tool</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#tool_rrp">http://premon.fbk.eu/ontology/vn#tool_rrp</seealso>
    let tool_rrp = Prefixed_Name(pmovn, "tool_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:rigid_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>Non in the data</para>
    /// labels<para>rigid</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#rigid_rrp">http://premon.fbk.eu/ontology/vn#rigid_rrp</seealso>
    let rigid_rrp = Prefixed_Name(pmovn, "rigid_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:artifact_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>Non in the data</para>
    /// labels<para>artifact</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#artifact_rrp">http://premon.fbk.eu/ontology/vn#artifact_rrp</seealso>
    let artifact_rrp = Prefixed_Name(pmovn, "artifact_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:force_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///
    /// labels<para>force</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#force_rrp">http://premon.fbk.eu/ontology/vn#force_rrp</seealso>
    let force_rrp = Prefixed_Name(pmovn, "force_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:animal_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>animal</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#animal_rrp">http://premon.fbk.eu/ontology/vn#animal_rrp</seealso>
    let animal_rrp = Prefixed_Name(pmovn, "animal_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:elongated_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>elongated</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#elongated_rrp">http://premon.fbk.eu/ontology/vn#elongated_rrp</seealso>
    let elongated_rrp = Prefixed_Name(pmovn, "elongated_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:garment_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>garment</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#garment_rrp">http://premon.fbk.eu/ontology/vn#garment_rrp</seealso>
    let garment_rrp = Prefixed_Name(pmovn, "garment_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:refl_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///
    /// labels<para>refl</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#refl_rrp">http://premon.fbk.eu/ontology/vn#refl_rrp</seealso>
    let refl_rrp = Prefixed_Name(pmovn, "refl_rrp") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Role Selectional Restriction Property</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#RoleRestrictionProperty">http://premon.fbk.eu/ontology/vn#RoleRestrictionProperty</seealso>
    let RoleRestrictionProperty =
        Prefixed_Name(pmovn, "RoleRestrictionProperty") |> PrefixedName

    /// <summary>
    ///   <para>pmovn:machine_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///
    /// labels<para>machine</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#machine_rrp">http://premon.fbk.eu/ontology/vn#machine_rrp</seealso>
    let machine_rrp = Prefixed_Name(pmovn, "machine_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:animate_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///
    /// labels<para>animate</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#animate_rrp">http://premon.fbk.eu/ontology/vn#animate_rrp</seealso>
    let animate_rrp = Prefixed_Name(pmovn, "animate_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:nonrigid_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>nonrigid</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#nonrigid_rrp">http://premon.fbk.eu/ontology/vn#nonrigid_rrp</seealso>
    let nonrigid_rrp = Prefixed_Name(pmovn, "nonrigid_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:comestible_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>comestible</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#comestible_rrp">http://premon.fbk.eu/ontology/vn#comestible_rrp</seealso>
    let comestible_rrp = Prefixed_Name(pmovn, "comestible_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:communication_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///
    /// labels<para>communication</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#communication_rrp">http://premon.fbk.eu/ontology/vn#communication_rrp</seealso>
    let communication_rrp = Prefixed_Name(pmovn, "communication_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:int_control_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>int_control</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#int_control_rrp">http://premon.fbk.eu/ontology/vn#int_control_rrp</seealso>
    let int_control_rrp = Prefixed_Name(pmovn, "int_control_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:sound_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///
    /// labels<para>sound</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#sound_rrp">http://premon.fbk.eu/ontology/vn#sound_rrp</seealso>
    let sound_rrp = Prefixed_Name(pmovn, "sound_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:location_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>location</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#location_rrp">http://premon.fbk.eu/ontology/vn#location_rrp</seealso>
    let location_rrp = Prefixed_Name(pmovn, "location_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:phys_obj_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///   <para>Non in the data</para>
    /// labels<para>physical object</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#phys_obj_rrp">http://premon.fbk.eu/ontology/vn#phys_obj_rrp</seealso>
    let phys_obj_rrp = Prefixed_Name(pmovn, "phys_obj_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:currency_rrp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pmovn:RoleRestrictionProperty</para>
    ///
    /// labels<para>currency</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#currency_rrp">http://premon.fbk.eu/ontology/vn#currency_rrp</seealso>
    let currency_rrp = Prefixed_Name(pmovn, "currency_rrp") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:AdjSynItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Adjective Syntactic Item</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#AdjSynItem">http://premon.fbk.eu/ontology/vn#AdjSynItem</seealso>
    let AdjSynItem = Prefixed_Name(pmovn, "AdjSynItem") |> PrefixedName
    /// <summary>
    ///   <para>pmovn:dest_dir_prp</para>
    /// </summary>
    /// <remarks>
    ///   <para>pmovn:PrepositionRestrictionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>dest_dir</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/vn#dest_dir_prp">http://premon.fbk.eu/ontology/vn#dest_dir_prp</seealso>
    let dest_dir_prp = Prefixed_Name(pmovn, "dest_dir_prp") |> PrefixedName
