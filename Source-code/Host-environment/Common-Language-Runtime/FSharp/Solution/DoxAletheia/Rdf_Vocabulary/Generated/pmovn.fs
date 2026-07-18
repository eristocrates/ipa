namespace http.premon.fbk.eu.ontology.vn.hash

open DoxAletheia.Rdf_Vocabulary

module pmovn =
    let _namespace_name = "http://premon.fbk.eu/ontology/vn#"

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#AbsentAtomicRestriction"></see>
    /// </summary>
    let AbsentAtomicRestriction =
        Namespaced_IRI.parse _namespace_name "AbsentAtomicRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#AtomicRestriction"></see>
    /// </summary>
    let AtomicRestriction =
        Namespaced_IRI.parse _namespace_name "AtomicRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#AdjSynItem"></see>
    /// </summary>
    let AdjSynItem = Namespaced_IRI.parse _namespace_name "AdjSynItem" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#SynItem"></see>
    /// </summary>
    let SynItem = Namespaced_IRI.parse _namespace_name "SynItem" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#AdvSynItem"></see>
    /// </summary>
    let AdvSynItem = Namespaced_IRI.parse _namespace_name "AdvSynItem" |> NamespacedName

    /// <summary>
    /// default
    /// <see href="http://premon.fbk.eu/ontology/vn#AndCompoundRestriction"></see></summary>
    let AndCompoundRestriction =
        Namespaced_IRI.parse _namespace_name "AndCompoundRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#CompoundRestriction"></see>
    /// </summary>
    let CompoundRestriction =
        Namespaced_IRI.parse _namespace_name "CompoundRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#Restriction"></see>
    /// </summary>
    let Restriction =
        Namespaced_IRI.parse _namespace_name "Restriction" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#ExistAtomicRestriction"></see>
    /// </summary>
    let ExistAtomicRestriction =
        Namespaced_IRI.parse _namespace_name "ExistAtomicRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#AuxnpType"></see>
    /// </summary>
    let AuxnpType = Namespaced_IRI.parse _namespace_name "AuxnpType" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#oblique_auxnpType"></see>
    /// </summary>
    let oblique_auxnpType =
        Namespaced_IRI.parse _namespace_name "oblique_auxnpType" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#oblique2_auxnpType"></see>
    /// </summary>
    let oblique2_auxnpType =
        Namespaced_IRI.parse _namespace_name "oblique2_auxnpType" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#oblique1_auxnpType"></see>
    /// </summary>
    let oblique1_auxnpType =
        Namespaced_IRI.parse _namespace_name "oblique1_auxnpType" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#np_auxnpType"></see>
    /// </summary>
    let np_auxnpType =
        Namespaced_IRI.parse _namespace_name "np_auxnpType" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#OrCompoundRestriction"></see>
    /// </summary>
    let OrCompoundRestriction =
        Namespaced_IRI.parse _namespace_name "OrCompoundRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#ConstantPredArg"></see>
    /// </summary>
    let ConstantPredArg =
        Namespaced_IRI.parse _namespace_name "ConstantPredArg" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#PredArg"></see>
    /// </summary>
    let PredArg = Namespaced_IRI.parse _namespace_name "PredArg" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#EventPredArg"></see>
    /// </summary>
    let EventPredArg =
        Namespaced_IRI.parse _namespace_name "EventPredArg" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#EventPredArgType"></see>
    /// </summary>
    let EventPredArgType =
        Namespaced_IRI.parse _namespace_name "EventPredArgType" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#startEventArg"></see>
    /// </summary>
    let startEventArg =
        Namespaced_IRI.parse _namespace_name "startEventArg" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#resultEventArg"></see>
    /// </summary>
    let resultEventArg =
        Namespaced_IRI.parse _namespace_name "resultEventArg" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#endEventArg"></see>
    /// </summary>
    let endEventArg =
        Namespaced_IRI.parse _namespace_name "endEventArg" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#duringEventArg"></see>
    /// </summary>
    let duringEventArg =
        Namespaced_IRI.parse _namespace_name "duringEventArg" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#ImplicitPredArg"></see>
    /// </summary>
    let ImplicitPredArg =
        Namespaced_IRI.parse _namespace_name "ImplicitPredArg" |> NamespacedName

    /// <summary>
    /// Not clear if there is an equivalent in lexInfo
    /// <see href="http://premon.fbk.eu/ontology/vn#LexSynItem"></see></summary>
    let LexSynItem = Namespaced_IRI.parse _namespace_name "LexSynItem" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#NegPred"></see>
    /// </summary>
    let NegPred = Namespaced_IRI.parse _namespace_name "NegPred" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#Pred"></see>
    /// </summary>
    let Pred = Namespaced_IRI.parse _namespace_name "Pred" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#NpSynItem"></see>
    /// </summary>
    let NpSynItem = Namespaced_IRI.parse _namespace_name "NpSynItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#SemanticRole"></see>
    /// </summary>
    let SemanticRole =
        Namespaced_IRI.parse _namespace_name "SemanticRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#restriction"></see>
    /// </summary>
    let restriction =
        Namespaced_IRI.parse _namespace_name "restriction" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#RoleSelectionalRestriction"></see>
    /// </summary>
    let RoleSelectionalRestriction =
        Namespaced_IRI.parse _namespace_name "RoleSelectionalRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#SyntacticRestriction"></see>
    /// </summary>
    let SyntacticRestriction =
        Namespaced_IRI.parse _namespace_name "SyntacticRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#PredType"></see>
    /// </summary>
    let PredType = Namespaced_IRI.parse _namespace_name "PredType" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#ThemRolePredArg"></see>
    /// </summary>
    let ThemRolePredArg =
        Namespaced_IRI.parse _namespace_name "ThemRolePredArg" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#VerbSpecificPredArg"></see>
    /// </summary>
    let VerbSpecificPredArg =
        Namespaced_IRI.parse _namespace_name "VerbSpecificPredArg" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#PrepSynItem"></see>
    /// </summary>
    let PrepSynItem =
        Namespaced_IRI.parse _namespace_name "PrepSynItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#PrepositionSelectionalRestriction"></see>
    /// </summary>
    let PrepositionSelectionalRestriction =
        Namespaced_IRI.parse _namespace_name "PrepositionSelectionalRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#PrepositionRestrictionProperty"></see>
    /// </summary>
    let PrepositionRestrictionProperty =
        Namespaced_IRI.parse _namespace_name "PrepositionRestrictionProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#SelectionalRestrictionProperty"></see>
    /// </summary>
    let SelectionalRestrictionProperty =
        Namespaced_IRI.parse _namespace_name "SelectionalRestrictionProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#dest_prp"></see>
    /// </summary>
    let dest_prp = Namespaced_IRI.parse _namespace_name "dest_prp" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#path_prp"></see>
    /// </summary>
    let path_prp = Namespaced_IRI.parse _namespace_name "path_prp" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#dir_prp"></see>
    /// </summary>
    let dir_prp = Namespaced_IRI.parse _namespace_name "dir_prp" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#loc_prp"></see>
    /// </summary>
    let loc_prp = Namespaced_IRI.parse _namespace_name "loc_prp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#spatial_prp"></see>
    /// </summary>
    let spatial_prp =
        Namespaced_IRI.parse _namespace_name "spatial_prp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#plural_prp"></see>
    /// </summary>
    let plural_prp = Namespaced_IRI.parse _namespace_name "plural_prp" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#src_prp"></see>
    /// </summary>
    let src_prp = Namespaced_IRI.parse _namespace_name "src_prp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#dest_dir_prp"></see>
    /// </summary>
    let dest_dir_prp =
        Namespaced_IRI.parse _namespace_name "dest_dir_prp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#dest_conf_prp"></see>
    /// </summary>
    let dest_conf_prp =
        Namespaced_IRI.parse _namespace_name "dest_conf_prp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#SelectionalRestriction"></see>
    /// </summary>
    let SelectionalRestriction =
        Namespaced_IRI.parse _namespace_name "SelectionalRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#RestrictionProperty"></see>
    /// </summary>
    let RestrictionProperty =
        Namespaced_IRI.parse _namespace_name "RestrictionProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#RoleRestrictionProperty"></see>
    /// </summary>
    let RoleRestrictionProperty =
        Namespaced_IRI.parse _namespace_name "RoleRestrictionProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#machine_rrp"></see>
    /// </summary>
    let machine_rrp =
        Namespaced_IRI.parse _namespace_name "machine_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#pointy_rrp"></see>
    /// </summary>
    let pointy_rrp = Namespaced_IRI.parse _namespace_name "pointy_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#animate_rrp"></see>
    /// </summary>
    let animate_rrp =
        Namespaced_IRI.parse _namespace_name "animate_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#comestible_rrp"></see>
    /// </summary>
    let comestible_rrp =
        Namespaced_IRI.parse _namespace_name "comestible_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#scalar_rrp"></see>
    /// </summary>
    let scalar_rrp = Namespaced_IRI.parse _namespace_name "scalar_rrp" |> NamespacedName
    /// <summary>
    /// Non in the data
    /// <see href="http://premon.fbk.eu/ontology/vn#shape_rrp"></see></summary>
    let shape_rrp = Namespaced_IRI.parse _namespace_name "shape_rrp" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#region_rrp"></see>
    /// </summary>
    let region_rrp = Namespaced_IRI.parse _namespace_name "region_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#communication_rrp"></see>
    /// </summary>
    let communication_rrp =
        Namespaced_IRI.parse _namespace_name "communication_rrp" |> NamespacedName

    /// <summary>
    /// Non in the data
    /// <see href="http://premon.fbk.eu/ontology/vn#plant_rrp"></see></summary>
    let plant_rrp = Namespaced_IRI.parse _namespace_name "plant_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#body_part_rrp"></see>
    /// </summary>
    let body_part_rrp =
        Namespaced_IRI.parse _namespace_name "body_part_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#nonrigid_rrp"></see>
    /// </summary>
    let nonrigid_rrp =
        Namespaced_IRI.parse _namespace_name "nonrigid_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#human_rrp"></see>
    /// </summary>
    let human_rrp = Namespaced_IRI.parse _namespace_name "human_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#int_control_rrp"></see>
    /// </summary>
    let int_control_rrp =
        Namespaced_IRI.parse _namespace_name "int_control_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#substance_rrp"></see>
    /// </summary>
    let substance_rrp =
        Namespaced_IRI.parse _namespace_name "substance_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#organization_rrp"></see>
    /// </summary>
    let organization_rrp =
        Namespaced_IRI.parse _namespace_name "organization_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#concrete_rrp"></see>
    /// </summary>
    let concrete_rrp =
        Namespaced_IRI.parse _namespace_name "concrete_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#biotic_rrp"></see>
    /// </summary>
    let biotic_rrp = Namespaced_IRI.parse _namespace_name "biotic_rrp" |> NamespacedName
    /// <summary>
    /// Non in the data
    /// <see href="http://premon.fbk.eu/ontology/vn#tool_rrp"></see></summary>
    let tool_rrp = Namespaced_IRI.parse _namespace_name "tool_rrp" |> NamespacedName
    /// <summary>
    /// Non in the data
    /// <see href="http://premon.fbk.eu/ontology/vn#rigid_rrp"></see></summary>
    let rigid_rrp = Namespaced_IRI.parse _namespace_name "rigid_rrp" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#sound_rrp"></see>
    /// </summary>
    let sound_rrp = Namespaced_IRI.parse _namespace_name "sound_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#vehicle_rrp"></see>
    /// </summary>
    let vehicle_rrp =
        Namespaced_IRI.parse _namespace_name "vehicle_rrp" |> NamespacedName

    /// <summary>
    /// Non in the data
    /// <see href="http://premon.fbk.eu/ontology/vn#solid_rrp"></see></summary>
    let solid_rrp = Namespaced_IRI.parse _namespace_name "solid_rrp" |> NamespacedName

    /// <summary>
    /// Non in the data
    /// <see href="http://premon.fbk.eu/ontology/vn#artifact_rrp"></see></summary>
    let artifact_rrp =
        Namespaced_IRI.parse _namespace_name "artifact_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#force_rrp"></see>
    /// </summary>
    let force_rrp = Namespaced_IRI.parse _namespace_name "force_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#location_rrp"></see>
    /// </summary>
    let location_rrp =
        Namespaced_IRI.parse _namespace_name "location_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#time_rrp"></see>
    /// </summary>
    let time_rrp = Namespaced_IRI.parse _namespace_name "time_rrp" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#animal_rrp"></see>
    /// </summary>
    let animal_rrp = Namespaced_IRI.parse _namespace_name "animal_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#elongated_rrp"></see>
    /// </summary>
    let elongated_rrp =
        Namespaced_IRI.parse _namespace_name "elongated_rrp" |> NamespacedName

    /// <summary>
    /// Non in the data
    /// <see href="http://premon.fbk.eu/ontology/vn#phys_obj_rrp"></see></summary>
    let phys_obj_rrp =
        Namespaced_IRI.parse _namespace_name "phys_obj_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#abstract_rrp"></see>
    /// </summary>
    let abstract_rrp =
        Namespaced_IRI.parse _namespace_name "abstract_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#state_rrp"></see>
    /// </summary>
    let state_rrp = Namespaced_IRI.parse _namespace_name "state_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#currency_rrp"></see>
    /// </summary>
    let currency_rrp =
        Namespaced_IRI.parse _namespace_name "currency_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#garment_rrp"></see>
    /// </summary>
    let garment_rrp =
        Namespaced_IRI.parse _namespace_name "garment_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#refl_rrp"></see>
    /// </summary>
    let refl_rrp = Namespaced_IRI.parse _namespace_name "refl_rrp" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#VerbClass"></see>
    /// </summary>
    let VerbClass = Namespaced_IRI.parse _namespace_name "VerbClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#ThematicRole"></see>
    /// </summary>
    let ThematicRole =
        Namespaced_IRI.parse _namespace_name "ThematicRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#thematicRole"></see>
    /// </summary>
    let thematicRole =
        Namespaced_IRI.parse _namespace_name "thematicRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#VerbSynItem"></see>
    /// </summary>
    let VerbSynItem =
        Namespaced_IRI.parse _namespace_name "VerbSynItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#SyntacticRestrictionProperty"></see>
    /// </summary>
    let SyntacticRestrictionProperty =
        Namespaced_IRI.parse _namespace_name "SyntacticRestrictionProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#adv_loc_syrp"></see>
    /// </summary>
    let adv_loc_syrp =
        Namespaced_IRI.parse _namespace_name "adv_loc_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#np_omit_ing_syrp"></see>
    /// </summary>
    let np_omit_ing_syrp =
        Namespaced_IRI.parse _namespace_name "np_omit_ing_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#tensed_that_syrp"></see>
    /// </summary>
    let tensed_that_syrp =
        Namespaced_IRI.parse _namespace_name "tensed_that_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#np_ing_syrp"></see>
    /// </summary>
    let np_ing_syrp =
        Namespaced_IRI.parse _namespace_name "np_ing_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#oc_ing_syrp"></see>
    /// </summary>
    let oc_ing_syrp =
        Namespaced_IRI.parse _namespace_name "oc_ing_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#sc_to_inf_syrp"></see>
    /// </summary>
    let sc_to_inf_syrp =
        Namespaced_IRI.parse _namespace_name "sc_to_inf_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#vc_to_inf_syrp"></see>
    /// </summary>
    let vc_to_inf_syrp =
        Namespaced_IRI.parse _namespace_name "vc_to_inf_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#small_clause_syrp"></see>
    /// </summary>
    let small_clause_syrp =
        Namespaced_IRI.parse _namespace_name "small_clause_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#genitive_syrp"></see>
    /// </summary>
    let genitive_syrp =
        Namespaced_IRI.parse _namespace_name "genitive_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#wheth_inf_syrp"></see>
    /// </summary>
    let wheth_inf_syrp =
        Namespaced_IRI.parse _namespace_name "wheth_inf_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#oc_to_inf_syrp"></see>
    /// </summary>
    let oc_to_inf_syrp =
        Namespaced_IRI.parse _namespace_name "oc_to_inf_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#what_extract_syrp"></see>
    /// </summary>
    let what_extract_syrp =
        Namespaced_IRI.parse _namespace_name "what_extract_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#oc_bare_inf_syrp"></see>
    /// </summary>
    let oc_bare_inf_syrp =
        Namespaced_IRI.parse _namespace_name "oc_bare_inf_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#np_p_ing_syrp"></see>
    /// </summary>
    let np_p_ing_syrp =
        Namespaced_IRI.parse _namespace_name "np_p_ing_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#wh_ing_syrp"></see>
    /// </summary>
    let wh_ing_syrp =
        Namespaced_IRI.parse _namespace_name "wh_ing_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#how_extract_syrp"></see>
    /// </summary>
    let how_extract_syrp =
        Namespaced_IRI.parse _namespace_name "how_extract_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#to_be_syrp"></see>
    /// </summary>
    let to_be_syrp = Namespaced_IRI.parse _namespace_name "to_be_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#wh_extract_syrp"></see>
    /// </summary>
    let wh_extract_syrp =
        Namespaced_IRI.parse _namespace_name "wh_extract_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#what_inf_syrp"></see>
    /// </summary>
    let what_inf_syrp =
        Namespaced_IRI.parse _namespace_name "what_inf_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#np_ppart_syrp"></see>
    /// </summary>
    let np_ppart_syrp =
        Namespaced_IRI.parse _namespace_name "np_ppart_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#that_comp_syrp"></see>
    /// </summary>
    let that_comp_syrp =
        Namespaced_IRI.parse _namespace_name "that_comp_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#ac_ing_syrp"></see>
    /// </summary>
    let ac_ing_syrp =
        Namespaced_IRI.parse _namespace_name "ac_ing_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#plural_syrp"></see>
    /// </summary>
    let plural_syrp =
        Namespaced_IRI.parse _namespace_name "plural_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#quotation_syrp"></see>
    /// </summary>
    let quotation_syrp =
        Namespaced_IRI.parse _namespace_name "quotation_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#wh_comp_syrp"></see>
    /// </summary>
    let wh_comp_syrp =
        Namespaced_IRI.parse _namespace_name "wh_comp_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#np_to_inf_syrp"></see>
    /// </summary>
    let np_to_inf_syrp =
        Namespaced_IRI.parse _namespace_name "np_to_inf_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#acc_ing_syrp"></see>
    /// </summary>
    let acc_ing_syrp =
        Namespaced_IRI.parse _namespace_name "acc_ing_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#rs_to_inf_syrp"></see>
    /// </summary>
    let rs_to_inf_syrp =
        Namespaced_IRI.parse _namespace_name "rs_to_inf_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#np_tobe_syrp"></see>
    /// </summary>
    let np_tobe_syrp =
        Namespaced_IRI.parse _namespace_name "np_tobe_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#for_comp_syrp"></see>
    /// </summary>
    let for_comp_syrp =
        Namespaced_IRI.parse _namespace_name "for_comp_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#wh_inf_syrp"></see>
    /// </summary>
    let wh_inf_syrp =
        Namespaced_IRI.parse _namespace_name "wh_inf_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#be_sc_ing_syrp"></see>
    /// </summary>
    let be_sc_ing_syrp =
        Namespaced_IRI.parse _namespace_name "be_sc_ing_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#sentential_syrp"></see>
    /// </summary>
    let sentential_syrp =
        Namespaced_IRI.parse _namespace_name "sentential_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#definite_syrp"></see>
    /// </summary>
    let definite_syrp =
        Namespaced_IRI.parse _namespace_name "definite_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#poss_ing_syrp"></see>
    /// </summary>
    let poss_ing_syrp =
        Namespaced_IRI.parse _namespace_name "poss_ing_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#sc_ing_syrp"></see>
    /// </summary>
    let sc_ing_syrp =
        Namespaced_IRI.parse _namespace_name "sc_ing_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#ac_to_inf_syrp"></see>
    /// </summary>
    let ac_to_inf_syrp =
        Namespaced_IRI.parse _namespace_name "ac_to_inf_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#body_part_syrp"></see>
    /// </summary>
    let body_part_syrp =
        Namespaced_IRI.parse _namespace_name "body_part_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#refl_syrp"></see>
    /// </summary>
    let refl_syrp = Namespaced_IRI.parse _namespace_name "refl_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#VerbNetFrame"></see>
    /// </summary>
    let VerbNetFrame =
        Namespaced_IRI.parse _namespace_name "VerbNetFrame" |> NamespacedName

    /// <summary>
    /// abstract, non instantiated in the dataset
    /// <see href="http://premon.fbk.eu/ontology/vn#actor"></see></summary>
    let actor = Namespaced_IRI.parse _namespace_name "actor" |> NamespacedName

    /// <summary>
    /// abstract, non instantiated in the dataset.
    /// <see href="http://premon.fbk.eu/ontology/vn#participant"></see></summary>
    let participant =
        Namespaced_IRI.parse _namespace_name "participant" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#agent"></see>
    /// </summary>
    let agent = Namespaced_IRI.parse _namespace_name "agent" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#natural_rrp"></see>
    /// </summary>
    let natural_rrp =
        Namespaced_IRI.parse _namespace_name "natural_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#asset"></see>
    /// </summary>
    let asset = Namespaced_IRI.parse _namespace_name "asset" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#value"></see>
    /// </summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#attribute"></see>
    /// </summary>
    let attribute = Namespaced_IRI.parse _namespace_name "attribute" |> NamespacedName
    /// <summary>
    /// abstract, non instantiated in the dataset
    /// <see href="http://premon.fbk.eu/ontology/vn#undergoer"></see></summary>
    let undergoer = Namespaced_IRI.parse _namespace_name "undergoer" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#beneficiary"></see>
    /// </summary>
    let beneficiary =
        Namespaced_IRI.parse _namespace_name "beneficiary" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#cause"></see>
    /// </summary>
    let cause = Namespaced_IRI.parse _namespace_name "cause" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#coAgent"></see>
    /// </summary>
    let coAgent = Namespaced_IRI.parse _namespace_name "coAgent" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#coPatient"></see>
    /// </summary>
    let coPatient = Namespaced_IRI.parse _namespace_name "coPatient" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#coTheme"></see>
    /// </summary>
    let coTheme = Namespaced_IRI.parse _namespace_name "coTheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#definesFrame"></see>
    /// </summary>
    let definesFrame =
        Namespaced_IRI.parse _namespace_name "definesFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#frame"></see>
    /// </summary>
    let frame = Namespaced_IRI.parse _namespace_name "frame" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#definesSemRole"></see>
    /// </summary>
    let definesSemRole =
        Namespaced_IRI.parse _namespace_name "definesSemRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#destination"></see>
    /// </summary>
    let destination =
        Namespaced_IRI.parse _namespace_name "destination" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#goal"></see>
    /// </summary>
    let goal = Namespaced_IRI.parse _namespace_name "goal" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#location"></see>
    /// </summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#duration"></see>
    /// </summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#time"></see>
    /// </summary>
    let time = Namespaced_IRI.parse _namespace_name "time" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#experiencer"></see>
    /// </summary>
    let experiencer =
        Namespaced_IRI.parse _namespace_name "experiencer" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#patient"></see>
    /// </summary>
    let patient = Namespaced_IRI.parse _namespace_name "patient" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#extent"></see>
    /// </summary>
    let extent = Namespaced_IRI.parse _namespace_name "extent" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#finalTime"></see>
    /// </summary>
    let finalTime = Namespaced_IRI.parse _namespace_name "finalTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#frameDescNumber"></see>
    /// </summary>
    let frameDescNumber =
        Namespaced_IRI.parse _namespace_name "frameDescNumber" |> NamespacedName

    /// <summary>
    /// directly associates a VerbNet frame to its corresponding example
    /// <see href="http://premon.fbk.eu/ontology/vn#frameExample"></see></summary>
    let frameExample =
        Namespaced_IRI.parse _namespace_name "frameExample" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#framePrimary"></see>
    /// </summary>
    let framePrimary =
        Namespaced_IRI.parse _namespace_name "framePrimary" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#frameSecondary"></see>
    /// </summary>
    let frameSecondary =
        Namespaced_IRI.parse _namespace_name "frameSecondary" |> NamespacedName

    /// <summary>
    /// String representing the semantics of the Frame
    /// <see href="http://premon.fbk.eu/ontology/vn#frameSemanticsDescription"></see></summary>
    let frameSemanticsDescription =
        Namespaced_IRI.parse _namespace_name "frameSemanticsDescription" |> NamespacedName

    /// <summary>
    /// String representing the syntax of the Frame
    /// <see href="http://premon.fbk.eu/ontology/vn#frameSyntaxDescription"></see></summary>
    let frameSyntaxDescription =
        Namespaced_IRI.parse _namespace_name "frameSyntaxDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#frameXtag"></see>
    /// </summary>
    let frameXtag = Namespaced_IRI.parse _namespace_name "frameXtag" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#frequency"></see>
    /// </summary>
    let frequency = Namespaced_IRI.parse _namespace_name "frequency" |> NamespacedName
    /// <summary>
    /// abstract, non instantiated in the dataset
    /// <see href="http://premon.fbk.eu/ontology/vn#place"></see></summary>
    let place = Namespaced_IRI.parse _namespace_name "place" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#idea_rrp"></see>
    /// </summary>
    let idea_rrp = Namespaced_IRI.parse _namespace_name "idea_rrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#initialLocation"></see>
    /// </summary>
    let initialLocation =
        Namespaced_IRI.parse _namespace_name "initialLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#source"></see>
    /// </summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#initialTime"></see>
    /// </summary>
    let initialTime =
        Namespaced_IRI.parse _namespace_name "initialTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#instrument"></see>
    /// </summary>
    let instrument = Namespaced_IRI.parse _namespace_name "instrument" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#material"></see>
    /// </summary>
    let material = Namespaced_IRI.parse _namespace_name "material" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#pivot"></see>
    /// </summary>
    let pivot = Namespaced_IRI.parse _namespace_name "pivot" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#plural_rrp"></see>
    /// </summary>
    let plural_rrp = Namespaced_IRI.parse _namespace_name "plural_rrp" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#pos_ing"></see>
    /// </summary>
    let pos_ing = Namespaced_IRI.parse _namespace_name "pos_ing" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#predicate"></see>
    /// </summary>
    let predicate = Namespaced_IRI.parse _namespace_name "predicate" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#product"></see>
    /// </summary>
    let product = Namespaced_IRI.parse _namespace_name "product" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#result"></see>
    /// </summary>
    let result = Namespaced_IRI.parse _namespace_name "result" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#recipient"></see>
    /// </summary>
    let recipient = Namespaced_IRI.parse _namespace_name "recipient" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#reflexive"></see>
    /// </summary>
    let reflexive = Namespaced_IRI.parse _namespace_name "reflexive" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#stimulus"></see>
    /// </summary>
    let stimulus = Namespaced_IRI.parse _namespace_name "stimulus" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#subclassOf"></see>
    /// </summary>
    let subclassOf = Namespaced_IRI.parse _namespace_name "subclassOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#theme"></see>
    /// </summary>
    let theme = Namespaced_IRI.parse _namespace_name "theme" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#to_inf_rs_syrp"></see>
    /// </summary>
    let to_inf_rs_syrp =
        Namespaced_IRI.parse _namespace_name "to_inf_rs_syrp" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#topic"></see>
    /// </summary>
    let topic = Namespaced_IRI.parse _namespace_name "topic" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/vn#trajectory"></see>
    /// </summary>
    let trajectory = Namespaced_IRI.parse _namespace_name "trajectory" |> NamespacedName
