namespace http.premon.fbk.eu.ontology.vn.hash

open DoxAletheia

module pmovn =
    let _namespace_name = "http://premon.fbk.eu/ontology/vn#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#AbsentAtomicRestriction"></see>
    /// </summary>
    let AbsentAtomicRestriction = _prefix "AbsentAtomicRestriction"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#AtomicRestriction"></see>
    /// </summary>
    let AtomicRestriction = _prefix "AtomicRestriction"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#AdjSynItem"></see>
    /// </summary>
    let AdjSynItem = _prefix "AdjSynItem"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#SynItem"></see>
    /// </summary>
    let SynItem = _prefix "SynItem"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#AdvSynItem"></see>
    /// </summary>
    let AdvSynItem = _prefix "AdvSynItem"
    /// <summary>
    /// default
    /// <see href="http://premon.fbk.eu/ontology/vn#AndCompoundRestriction"></see></summary>
    let AndCompoundRestriction = _prefix "AndCompoundRestriction"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#CompoundRestriction"></see>
    /// </summary>
    let CompoundRestriction = _prefix "CompoundRestriction"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#Restriction"></see>
    /// </summary>
    let Restriction = _prefix "Restriction"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#ExistAtomicRestriction"></see>
    /// </summary>
    let ExistAtomicRestriction = _prefix "ExistAtomicRestriction"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#AuxnpType"></see>
    /// </summary>
    let AuxnpType = _prefix "AuxnpType"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#oblique_auxnpType"></see>
    /// </summary>
    let oblique_auxnpType = _prefix "oblique_auxnpType"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#oblique2_auxnpType"></see>
    /// </summary>
    let oblique2_auxnpType = _prefix "oblique2_auxnpType"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#oblique1_auxnpType"></see>
    /// </summary>
    let oblique1_auxnpType = _prefix "oblique1_auxnpType"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#np_auxnpType"></see>
    /// </summary>
    let np_auxnpType = _prefix "np_auxnpType"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#OrCompoundRestriction"></see>
    /// </summary>
    let OrCompoundRestriction = _prefix "OrCompoundRestriction"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#ConstantPredArg"></see>
    /// </summary>
    let ConstantPredArg = _prefix "ConstantPredArg"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#PredArg"></see>
    /// </summary>
    let PredArg = _prefix "PredArg"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#EventPredArg"></see>
    /// </summary>
    let EventPredArg = _prefix "EventPredArg"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#EventPredArgType"></see>
    /// </summary>
    let EventPredArgType = _prefix "EventPredArgType"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#startEventArg"></see>
    /// </summary>
    let startEventArg = _prefix "startEventArg"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#resultEventArg"></see>
    /// </summary>
    let resultEventArg = _prefix "resultEventArg"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#endEventArg"></see>
    /// </summary>
    let endEventArg = _prefix "endEventArg"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#duringEventArg"></see>
    /// </summary>
    let duringEventArg = _prefix "duringEventArg"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#ImplicitPredArg"></see>
    /// </summary>
    let ImplicitPredArg = _prefix "ImplicitPredArg"
    /// <summary>
    /// Not clear if there is an equivalent in lexInfo
    /// <see href="http://premon.fbk.eu/ontology/vn#LexSynItem"></see></summary>
    let LexSynItem = _prefix "LexSynItem"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#NegPred"></see>
    /// </summary>
    let NegPred = _prefix "NegPred"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#Pred"></see>
    /// </summary>
    let Pred = _prefix "Pred"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#NpSynItem"></see>
    /// </summary>
    let NpSynItem = _prefix "NpSynItem"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#SemanticRole"></see>
    /// </summary>
    let SemanticRole = _prefix "SemanticRole"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#restriction"></see>
    /// </summary>
    let restriction = _prefix "restriction"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#RoleSelectionalRestriction"></see>
    /// </summary>
    let RoleSelectionalRestriction = _prefix "RoleSelectionalRestriction"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#SyntacticRestriction"></see>
    /// </summary>
    let SyntacticRestriction = _prefix "SyntacticRestriction"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#PredType"></see>
    /// </summary>
    let PredType = _prefix "PredType"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#ThemRolePredArg"></see>
    /// </summary>
    let ThemRolePredArg = _prefix "ThemRolePredArg"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#VerbSpecificPredArg"></see>
    /// </summary>
    let VerbSpecificPredArg = _prefix "VerbSpecificPredArg"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#PrepSynItem"></see>
    /// </summary>
    let PrepSynItem = _prefix "PrepSynItem"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#PrepositionSelectionalRestriction"></see>
    /// </summary>
    let PrepositionSelectionalRestriction = _prefix "PrepositionSelectionalRestriction"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#PrepositionRestrictionProperty"></see>
    /// </summary>
    let PrepositionRestrictionProperty = _prefix "PrepositionRestrictionProperty"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#SelectionalRestrictionProperty"></see>
    /// </summary>
    let SelectionalRestrictionProperty = _prefix "SelectionalRestrictionProperty"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#dest_prp"></see>
    /// </summary>
    let dest_prp = _prefix "dest_prp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#path_prp"></see>
    /// </summary>
    let path_prp = _prefix "path_prp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#dir_prp"></see>
    /// </summary>
    let dir_prp = _prefix "dir_prp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#loc_prp"></see>
    /// </summary>
    let loc_prp = _prefix "loc_prp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#spatial_prp"></see>
    /// </summary>
    let spatial_prp = _prefix "spatial_prp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#plural_prp"></see>
    /// </summary>
    let plural_prp = _prefix "plural_prp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#src_prp"></see>
    /// </summary>
    let src_prp = _prefix "src_prp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#dest_dir_prp"></see>
    /// </summary>
    let dest_dir_prp = _prefix "dest_dir_prp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#dest_conf_prp"></see>
    /// </summary>
    let dest_conf_prp = _prefix "dest_conf_prp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#SelectionalRestriction"></see>
    /// </summary>
    let SelectionalRestriction = _prefix "SelectionalRestriction"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#RestrictionProperty"></see>
    /// </summary>
    let RestrictionProperty = _prefix "RestrictionProperty"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#RoleRestrictionProperty"></see>
    /// </summary>
    let RoleRestrictionProperty = _prefix "RoleRestrictionProperty"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#machine_rrp"></see>
    /// </summary>
    let machine_rrp = _prefix "machine_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#pointy_rrp"></see>
    /// </summary>
    let pointy_rrp = _prefix "pointy_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#animate_rrp"></see>
    /// </summary>
    let animate_rrp = _prefix "animate_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#comestible_rrp"></see>
    /// </summary>
    let comestible_rrp = _prefix "comestible_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#scalar_rrp"></see>
    /// </summary>
    let scalar_rrp = _prefix "scalar_rrp"
    /// <summary>
    /// Non in the data
    /// <see href="http://premon.fbk.eu/ontology/vn#shape_rrp"></see></summary>
    let shape_rrp = _prefix "shape_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#region_rrp"></see>
    /// </summary>
    let region_rrp = _prefix "region_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#communication_rrp"></see>
    /// </summary>
    let communication_rrp = _prefix "communication_rrp"
    /// <summary>
    /// Non in the data
    /// <see href="http://premon.fbk.eu/ontology/vn#plant_rrp"></see></summary>
    let plant_rrp = _prefix "plant_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#body_part_rrp"></see>
    /// </summary>
    let body_part_rrp = _prefix "body_part_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#nonrigid_rrp"></see>
    /// </summary>
    let nonrigid_rrp = _prefix "nonrigid_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#human_rrp"></see>
    /// </summary>
    let human_rrp = _prefix "human_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#int_control_rrp"></see>
    /// </summary>
    let int_control_rrp = _prefix "int_control_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#substance_rrp"></see>
    /// </summary>
    let substance_rrp = _prefix "substance_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#organization_rrp"></see>
    /// </summary>
    let organization_rrp = _prefix "organization_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#concrete_rrp"></see>
    /// </summary>
    let concrete_rrp = _prefix "concrete_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#biotic_rrp"></see>
    /// </summary>
    let biotic_rrp = _prefix "biotic_rrp"
    /// <summary>
    /// Non in the data
    /// <see href="http://premon.fbk.eu/ontology/vn#tool_rrp"></see></summary>
    let tool_rrp = _prefix "tool_rrp"
    /// <summary>
    /// Non in the data
    /// <see href="http://premon.fbk.eu/ontology/vn#rigid_rrp"></see></summary>
    let rigid_rrp = _prefix "rigid_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#sound_rrp"></see>
    /// </summary>
    let sound_rrp = _prefix "sound_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#vehicle_rrp"></see>
    /// </summary>
    let vehicle_rrp = _prefix "vehicle_rrp"
    /// <summary>
    /// Non in the data
    /// <see href="http://premon.fbk.eu/ontology/vn#solid_rrp"></see></summary>
    let solid_rrp = _prefix "solid_rrp"
    /// <summary>
    /// Non in the data
    /// <see href="http://premon.fbk.eu/ontology/vn#artifact_rrp"></see></summary>
    let artifact_rrp = _prefix "artifact_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#force_rrp"></see>
    /// </summary>
    let force_rrp = _prefix "force_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#location_rrp"></see>
    /// </summary>
    let location_rrp = _prefix "location_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#time_rrp"></see>
    /// </summary>
    let time_rrp = _prefix "time_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#animal_rrp"></see>
    /// </summary>
    let animal_rrp = _prefix "animal_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#elongated_rrp"></see>
    /// </summary>
    let elongated_rrp = _prefix "elongated_rrp"
    /// <summary>
    /// Non in the data
    /// <see href="http://premon.fbk.eu/ontology/vn#phys_obj_rrp"></see></summary>
    let phys_obj_rrp = _prefix "phys_obj_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#abstract_rrp"></see>
    /// </summary>
    let abstract_rrp = _prefix "abstract_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#state_rrp"></see>
    /// </summary>
    let state_rrp = _prefix "state_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#currency_rrp"></see>
    /// </summary>
    let currency_rrp = _prefix "currency_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#garment_rrp"></see>
    /// </summary>
    let garment_rrp = _prefix "garment_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#refl_rrp"></see>
    /// </summary>
    let refl_rrp = _prefix "refl_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#VerbClass"></see>
    /// </summary>
    let VerbClass = _prefix "VerbClass"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#ThematicRole"></see>
    /// </summary>
    let ThematicRole = _prefix "ThematicRole"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#thematicRole"></see>
    /// </summary>
    let thematicRole = _prefix "thematicRole"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#VerbSynItem"></see>
    /// </summary>
    let VerbSynItem = _prefix "VerbSynItem"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#SyntacticRestrictionProperty"></see>
    /// </summary>
    let SyntacticRestrictionProperty = _prefix "SyntacticRestrictionProperty"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#adv_loc_syrp"></see>
    /// </summary>
    let adv_loc_syrp = _prefix "adv_loc_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#np_omit_ing_syrp"></see>
    /// </summary>
    let np_omit_ing_syrp = _prefix "np_omit_ing_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#tensed_that_syrp"></see>
    /// </summary>
    let tensed_that_syrp = _prefix "tensed_that_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#np_ing_syrp"></see>
    /// </summary>
    let np_ing_syrp = _prefix "np_ing_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#oc_ing_syrp"></see>
    /// </summary>
    let oc_ing_syrp = _prefix "oc_ing_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#sc_to_inf_syrp"></see>
    /// </summary>
    let sc_to_inf_syrp = _prefix "sc_to_inf_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#vc_to_inf_syrp"></see>
    /// </summary>
    let vc_to_inf_syrp = _prefix "vc_to_inf_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#small_clause_syrp"></see>
    /// </summary>
    let small_clause_syrp = _prefix "small_clause_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#genitive_syrp"></see>
    /// </summary>
    let genitive_syrp = _prefix "genitive_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#wheth_inf_syrp"></see>
    /// </summary>
    let wheth_inf_syrp = _prefix "wheth_inf_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#oc_to_inf_syrp"></see>
    /// </summary>
    let oc_to_inf_syrp = _prefix "oc_to_inf_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#what_extract_syrp"></see>
    /// </summary>
    let what_extract_syrp = _prefix "what_extract_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#oc_bare_inf_syrp"></see>
    /// </summary>
    let oc_bare_inf_syrp = _prefix "oc_bare_inf_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#np_p_ing_syrp"></see>
    /// </summary>
    let np_p_ing_syrp = _prefix "np_p_ing_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#wh_ing_syrp"></see>
    /// </summary>
    let wh_ing_syrp = _prefix "wh_ing_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#how_extract_syrp"></see>
    /// </summary>
    let how_extract_syrp = _prefix "how_extract_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#to_be_syrp"></see>
    /// </summary>
    let to_be_syrp = _prefix "to_be_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#wh_extract_syrp"></see>
    /// </summary>
    let wh_extract_syrp = _prefix "wh_extract_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#what_inf_syrp"></see>
    /// </summary>
    let what_inf_syrp = _prefix "what_inf_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#np_ppart_syrp"></see>
    /// </summary>
    let np_ppart_syrp = _prefix "np_ppart_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#that_comp_syrp"></see>
    /// </summary>
    let that_comp_syrp = _prefix "that_comp_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#ac_ing_syrp"></see>
    /// </summary>
    let ac_ing_syrp = _prefix "ac_ing_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#plural_syrp"></see>
    /// </summary>
    let plural_syrp = _prefix "plural_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#quotation_syrp"></see>
    /// </summary>
    let quotation_syrp = _prefix "quotation_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#wh_comp_syrp"></see>
    /// </summary>
    let wh_comp_syrp = _prefix "wh_comp_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#np_to_inf_syrp"></see>
    /// </summary>
    let np_to_inf_syrp = _prefix "np_to_inf_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#acc_ing_syrp"></see>
    /// </summary>
    let acc_ing_syrp = _prefix "acc_ing_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#rs_to_inf_syrp"></see>
    /// </summary>
    let rs_to_inf_syrp = _prefix "rs_to_inf_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#np_tobe_syrp"></see>
    /// </summary>
    let np_tobe_syrp = _prefix "np_tobe_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#for_comp_syrp"></see>
    /// </summary>
    let for_comp_syrp = _prefix "for_comp_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#wh_inf_syrp"></see>
    /// </summary>
    let wh_inf_syrp = _prefix "wh_inf_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#be_sc_ing_syrp"></see>
    /// </summary>
    let be_sc_ing_syrp = _prefix "be_sc_ing_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#sentential_syrp"></see>
    /// </summary>
    let sentential_syrp = _prefix "sentential_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#definite_syrp"></see>
    /// </summary>
    let definite_syrp = _prefix "definite_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#poss_ing_syrp"></see>
    /// </summary>
    let poss_ing_syrp = _prefix "poss_ing_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#sc_ing_syrp"></see>
    /// </summary>
    let sc_ing_syrp = _prefix "sc_ing_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#ac_to_inf_syrp"></see>
    /// </summary>
    let ac_to_inf_syrp = _prefix "ac_to_inf_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#body_part_syrp"></see>
    /// </summary>
    let body_part_syrp = _prefix "body_part_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#refl_syrp"></see>
    /// </summary>
    let refl_syrp = _prefix "refl_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#VerbNetFrame"></see>
    /// </summary>
    let VerbNetFrame = _prefix "VerbNetFrame"
    /// <summary>
    /// abstract, non instantiated in the dataset
    /// <see href="http://premon.fbk.eu/ontology/vn#actor"></see></summary>
    let actor = _prefix "actor"
    /// <summary>
    /// abstract, non instantiated in the dataset.
    /// <see href="http://premon.fbk.eu/ontology/vn#participant"></see></summary>
    let participant = _prefix "participant"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#agent"></see>
    /// </summary>
    let agent = _prefix "agent"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#natural_rrp"></see>
    /// </summary>
    let natural_rrp = _prefix "natural_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#asset"></see>
    /// </summary>
    let asset = _prefix "asset"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#value"></see>
    /// </summary>
    let value = _prefix "value"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#attribute"></see>
    /// </summary>
    let attribute = _prefix "attribute"
    /// <summary>
    /// abstract, non instantiated in the dataset
    /// <see href="http://premon.fbk.eu/ontology/vn#undergoer"></see></summary>
    let undergoer = _prefix "undergoer"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#beneficiary"></see>
    /// </summary>
    let beneficiary = _prefix "beneficiary"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#cause"></see>
    /// </summary>
    let cause = _prefix "cause"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#coAgent"></see>
    /// </summary>
    let coAgent = _prefix "coAgent"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#coPatient"></see>
    /// </summary>
    let coPatient = _prefix "coPatient"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#coTheme"></see>
    /// </summary>
    let coTheme = _prefix "coTheme"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#definesFrame"></see>
    /// </summary>
    let definesFrame = _prefix "definesFrame"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#frame"></see>
    /// </summary>
    let frame = _prefix "frame"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#definesSemRole"></see>
    /// </summary>
    let definesSemRole = _prefix "definesSemRole"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#destination"></see>
    /// </summary>
    let destination = _prefix "destination"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#goal"></see>
    /// </summary>
    let goal = _prefix "goal"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#location"></see>
    /// </summary>
    let location = _prefix "location"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#duration"></see>
    /// </summary>
    let duration = _prefix "duration"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#time"></see>
    /// </summary>
    let time = _prefix "time"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#experiencer"></see>
    /// </summary>
    let experiencer = _prefix "experiencer"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#patient"></see>
    /// </summary>
    let patient = _prefix "patient"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#extent"></see>
    /// </summary>
    let extent = _prefix "extent"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#finalTime"></see>
    /// </summary>
    let finalTime = _prefix "finalTime"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#frameDescNumber"></see>
    /// </summary>
    let frameDescNumber = _prefix "frameDescNumber"
    /// <summary>
    /// directly associates a VerbNet frame to its corresponding example
    /// <see href="http://premon.fbk.eu/ontology/vn#frameExample"></see></summary>
    let frameExample = _prefix "frameExample"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#framePrimary"></see>
    /// </summary>
    let framePrimary = _prefix "framePrimary"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#frameSecondary"></see>
    /// </summary>
    let frameSecondary = _prefix "frameSecondary"
    /// <summary>
    /// String representing the semantics of the Frame
    /// <see href="http://premon.fbk.eu/ontology/vn#frameSemanticsDescription"></see></summary>
    let frameSemanticsDescription = _prefix "frameSemanticsDescription"
    /// <summary>
    /// String representing the syntax of the Frame
    /// <see href="http://premon.fbk.eu/ontology/vn#frameSyntaxDescription"></see></summary>
    let frameSyntaxDescription = _prefix "frameSyntaxDescription"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#frameXtag"></see>
    /// </summary>
    let frameXtag = _prefix "frameXtag"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#frequency"></see>
    /// </summary>
    let frequency = _prefix "frequency"
    /// <summary>
    /// abstract, non instantiated in the dataset
    /// <see href="http://premon.fbk.eu/ontology/vn#place"></see></summary>
    let place = _prefix "place"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#idea_rrp"></see>
    /// </summary>
    let idea_rrp = _prefix "idea_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#initialLocation"></see>
    /// </summary>
    let initialLocation = _prefix "initialLocation"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#source"></see>
    /// </summary>
    let source = _prefix "source"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#initialTime"></see>
    /// </summary>
    let initialTime = _prefix "initialTime"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#instrument"></see>
    /// </summary>
    let instrument = _prefix "instrument"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#material"></see>
    /// </summary>
    let material = _prefix "material"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#pivot"></see>
    /// </summary>
    let pivot = _prefix "pivot"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#plural_rrp"></see>
    /// </summary>
    let plural_rrp = _prefix "plural_rrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#pos_ing"></see>
    /// </summary>
    let pos_ing = _prefix "pos_ing"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#predicate"></see>
    /// </summary>
    let predicate = _prefix "predicate"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#product"></see>
    /// </summary>
    let product = _prefix "product"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#result"></see>
    /// </summary>
    let result = _prefix "result"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#recipient"></see>
    /// </summary>
    let recipient = _prefix "recipient"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#reflexive"></see>
    /// </summary>
    let reflexive = _prefix "reflexive"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#stimulus"></see>
    /// </summary>
    let stimulus = _prefix "stimulus"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#subclassOf"></see>
    /// </summary>
    let subclassOf = _prefix "subclassOf"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#theme"></see>
    /// </summary>
    let theme = _prefix "theme"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#to_inf_rs_syrp"></see>
    /// </summary>
    let to_inf_rs_syrp = _prefix "to_inf_rs_syrp"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#topic"></see>
    /// </summary>
    let topic = _prefix "topic"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#trajectory"></see>
    /// </summary>
    let trajectory = _prefix "trajectory"
