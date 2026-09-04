#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pmovn =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://premon.fbk.eu/ontology/vn#" "pmovn"

    /// <summary>
    ///   <para>rdfs:label : Absent Atomic Restriction</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#AbsentAtomicRestriction">pmovn:AbsentAtomicRestriction</a>
    /// </summary>
    let AbsentAtomicRestriction = _prefixId.prefix "AbsentAtomicRestriction"
    /// <summary>
    ///   <para>rdfs:label : Adjective Syntactic Item</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#AdjSynItem">pmovn:AdjSynItem</a>
    /// </summary>
    let AdjSynItem = _prefixId.prefix "AdjSynItem"
    /// <summary>
    ///   <para>rdfs:label : Adverb Syntactic Item</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#AdvSynItem">pmovn:AdvSynItem</a>
    /// </summary>
    let AdvSynItem = _prefixId.prefix "AdvSynItem"
    /// <summary>
    ///   <para>rdfs:label : And Compound Restriction</para>
    ///   <para>rdfs:comment : default^^xsd:string</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#AndCompoundRestriction">pmovn:AndCompoundRestriction</a>
    /// </summary>
    let AndCompoundRestriction = _prefixId.prefix "AndCompoundRestriction"
    /// <summary>
    ///   <para>rdfs:label : Atomic Restriction</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#AtomicRestriction">pmovn:AtomicRestriction</a>
    /// </summary>
    let AtomicRestriction = _prefixId.prefix "AtomicRestriction"
    /// <summary>
    ///   <para>rdfs:label : Auxiliary NP Type</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#AuxnpType">pmovn:AuxnpType</a>
    /// </summary>
    let AuxnpType = _prefixId.prefix "AuxnpType"
    /// <summary>
    ///   <para>rdfs:label : Compound Restriction</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#CompoundRestriction">pmovn:CompoundRestriction</a>
    /// </summary>
    let CompoundRestriction = _prefixId.prefix "CompoundRestriction"
    /// <summary>
    ///   <para>rdfs:label : Constant Predicate Argument</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#ConstantPredArg">pmovn:ConstantPredArg</a>
    /// </summary>
    let ConstantPredArg = _prefixId.prefix "ConstantPredArg"
    /// <summary>
    ///   <para>rdfs:label : Event Predicate Argument</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#EventPredArg">pmovn:EventPredArg</a>
    /// </summary>
    let EventPredArg = _prefixId.prefix "EventPredArg"
    /// <summary>
    ///   <para>rdfs:label : Event Predicate Argument Type</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#EventPredArgType">pmovn:EventPredArgType</a>
    /// </summary>
    let EventPredArgType = _prefixId.prefix "EventPredArgType"
    /// <summary>
    ///   <para>rdfs:label : Exist Atomic Restriction</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#ExistAtomicRestriction">pmovn:ExistAtomicRestriction</a>
    /// </summary>
    let ExistAtomicRestriction = _prefixId.prefix "ExistAtomicRestriction"
    /// <summary>
    ///   <para>rdfs:label : Implicit Predicate Argument</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#ImplicitPredArg">pmovn:ImplicitPredArg</a>
    /// </summary>
    let ImplicitPredArg = _prefixId.prefix "ImplicitPredArg"
    /// <summary>
    ///   <para>rdfs:label : Lexical Syntactic Item</para>
    ///   <para>rdfs:comment : Not clear if there is an equivalent in lexInfo^^xsd:string</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#LexSynItem">pmovn:LexSynItem</a>
    /// </summary>
    let LexSynItem = _prefixId.prefix "LexSynItem"
    /// <summary>
    ///   <para>rdfs:label : Negated Predicate</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#NegPred">pmovn:NegPred</a>
    /// </summary>
    let NegPred = _prefixId.prefix "NegPred"
    /// <summary>
    ///   <para>rdfs:label : NP Syntactic Item</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#NpSynItem">pmovn:NpSynItem</a>
    /// </summary>
    let NpSynItem = _prefixId.prefix "NpSynItem"
    /// <summary>
    ///   <para>rdfs:label : Or Compound Restriction</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#OrCompoundRestriction">pmovn:OrCompoundRestriction</a>
    /// </summary>
    let OrCompoundRestriction = _prefixId.prefix "OrCompoundRestriction"
    /// <summary>
    ///   <para>rdfs:label : Predicate</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#Pred">pmovn:Pred</a>
    /// </summary>
    let Pred = _prefixId.prefix "Pred"
    /// <summary>
    ///   <para>rdfs:label : Predicate Argument</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#PredArg">pmovn:PredArg</a>
    /// </summary>
    let PredArg = _prefixId.prefix "PredArg"
    /// <summary>
    ///   <para>rdfs:label : Predicate Type</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#PredType">pmovn:PredType</a>
    /// </summary>
    let PredType = _prefixId.prefix "PredType"
    /// <summary>
    ///   <para>rdfs:label : Preposition Syntactic Item</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#PrepSynItem">pmovn:PrepSynItem</a>
    /// </summary>
    let PrepSynItem = _prefixId.prefix "PrepSynItem"

    /// <summary>
    ///   <para>rdfs:label : Preposition Selectional Restriction Property</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#PrepositionRestrictionProperty">pmovn:PrepositionRestrictionProperty</a>
    /// </summary>
    let PrepositionRestrictionProperty =
        _prefixId.prefix "PrepositionRestrictionProperty"

    /// <summary>
    ///   <para>rdfs:label : Preposition Selectional Restriction</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#PrepositionSelectionalRestriction">pmovn:PrepositionSelectionalRestriction</a>
    /// </summary>
    let PrepositionSelectionalRestriction =
        _prefixId.prefix "PrepositionSelectionalRestriction"

    /// <summary>
    ///   <para>rdfs:label : Restriction</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#Restriction">pmovn:Restriction</a>
    /// </summary>
    let Restriction = _prefixId.prefix "Restriction"
    /// <summary>
    ///   <para>rdfs:label : Restriction Property</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#RestrictionProperty">pmovn:RestrictionProperty</a>
    /// </summary>
    let RestrictionProperty = _prefixId.prefix "RestrictionProperty"
    /// <summary>
    ///   <para>rdfs:label : Role Selectional Restriction Property</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#RoleRestrictionProperty">pmovn:RoleRestrictionProperty</a>
    /// </summary>
    let RoleRestrictionProperty = _prefixId.prefix "RoleRestrictionProperty"
    /// <summary>
    ///   <para>rdfs:label : Role Selectional Restriction</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#RoleSelectionalRestriction">pmovn:RoleSelectionalRestriction</a>
    /// </summary>
    let RoleSelectionalRestriction = _prefixId.prefix "RoleSelectionalRestriction"
    /// <summary>
    ///   <para>rdfs:label : Selectional Restriction</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#SelectionalRestriction">pmovn:SelectionalRestriction</a>
    /// </summary>
    let SelectionalRestriction = _prefixId.prefix "SelectionalRestriction"

    /// <summary>
    ///   <para>rdfs:label : Selectional Restriction Property</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#SelectionalRestrictionProperty">pmovn:SelectionalRestrictionProperty</a>
    /// </summary>
    let SelectionalRestrictionProperty =
        _prefixId.prefix "SelectionalRestrictionProperty"

    /// <summary>
    ///   <para>rdfs:label : Semantic Role (VN)</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#SemanticRole">pmovn:SemanticRole</a>
    /// </summary>
    let SemanticRole = _prefixId.prefix "SemanticRole"
    /// <summary>
    ///   <para>rdfs:label : Syntactic Item</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#SynItem">pmovn:SynItem</a>
    /// </summary>
    let SynItem = _prefixId.prefix "SynItem"
    /// <summary>
    ///   <para>rdfs:label : Syntactic Restriction</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#SyntacticRestriction">pmovn:SyntacticRestriction</a>
    /// </summary>
    let SyntacticRestriction = _prefixId.prefix "SyntacticRestriction"
    /// <summary>
    ///   <para>rdfs:label : Syntactic Restriction Property^^xsd:string</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#SyntacticRestrictionProperty">pmovn:SyntacticRestrictionProperty</a>
    /// </summary>
    let SyntacticRestrictionProperty = _prefixId.prefix "SyntacticRestrictionProperty"
    /// <summary>
    ///   <para>rdfs:label : Thematic Role Predicate Argument</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#ThemRolePredArg">pmovn:ThemRolePredArg</a>
    /// </summary>
    let ThemRolePredArg = _prefixId.prefix "ThemRolePredArg"
    /// <summary>
    ///   <para>rdfs:label : Thematic Role (VN)</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#ThematicRole">pmovn:ThematicRole</a>
    /// </summary>
    let ThematicRole = _prefixId.prefix "ThematicRole"
    /// <summary>
    ///   <para>rdfs:label : Verb Class (VN)</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#VerbClass">pmovn:VerbClass</a>
    /// </summary>
    let VerbClass = _prefixId.prefix "VerbClass"
    /// <summary>
    ///   <para>rdfs:label : Syntactic Frame (VN)</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#VerbNetFrame">pmovn:VerbNetFrame</a>
    /// </summary>
    let VerbNetFrame = _prefixId.prefix "VerbNetFrame"
    /// <summary>
    ///   <para>rdfs:label : Verb Specific Predicate Argument</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#VerbSpecificPredArg">pmovn:VerbSpecificPredArg</a>
    /// </summary>
    let VerbSpecificPredArg = _prefixId.prefix "VerbSpecificPredArg"
    /// <summary>
    ///   <para>rdfs:label : Verb Syntactic Item</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#VerbSynItem">pmovn:VerbSynItem</a>
    /// </summary>
    let VerbSynItem = _prefixId.prefix "VerbSynItem"
    let abstract_rrp = _prefixId.prefix "abstract_rrp"
    let ac_ing_syrp = _prefixId.prefix "ac_ing_syrp"
    let ac_to_inf_syrp = _prefixId.prefix "ac_to_inf_syrp"
    let acc_ing_syrp = _prefixId.prefix "acc_ing_syrp"
    let actor = _prefixId.prefix "actor"
    let adv_loc_syrp = _prefixId.prefix "adv_loc_syrp"
    let agent = _prefixId.prefix "agent"
    let animal_rrp = _prefixId.prefix "animal_rrp"
    let animate_rrp = _prefixId.prefix "animate_rrp"
    let artifact_rrp = _prefixId.prefix "artifact_rrp"
    let asset = _prefixId.prefix "asset"
    let attribute = _prefixId.prefix "attribute"
    let be_sc_ing_syrp = _prefixId.prefix "be_sc_ing_syrp"
    let beneficiary = _prefixId.prefix "beneficiary"
    let biotic_rrp = _prefixId.prefix "biotic_rrp"
    let body_part_rrp = _prefixId.prefix "body_part_rrp"
    let body_part_syrp = _prefixId.prefix "body_part_syrp"
    let cause = _prefixId.prefix "cause"
    let coAgent = _prefixId.prefix "coAgent"
    let coPatient = _prefixId.prefix "coPatient"
    let coTheme = _prefixId.prefix "coTheme"
    let comestible_rrp = _prefixId.prefix "comestible_rrp"
    let communication_rrp = _prefixId.prefix "communication_rrp"
    let concrete_rrp = _prefixId.prefix "concrete_rrp"
    let currency_rrp = _prefixId.prefix "currency_rrp"
    /// <summary>
    ///   <para>rdfs:label : defines frame</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#definesFrame">pmovn:definesFrame</a>
    /// </summary>
    let definesFrame = _prefixId.prefix "definesFrame"
    /// <summary>
    ///   <para>rdfs:label : defines semantic role</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#definesSemRole">pmovn:definesSemRole</a>
    /// </summary>
    let definesSemRole = _prefixId.prefix "definesSemRole"
    let definite_syrp = _prefixId.prefix "definite_syrp"
    let dest_conf_prp = _prefixId.prefix "dest_conf_prp"
    let dest_dir_prp = _prefixId.prefix "dest_dir_prp"
    let dest_prp = _prefixId.prefix "dest_prp"
    let destination = _prefixId.prefix "destination"
    let dir_prp = _prefixId.prefix "dir_prp"
    let duration = _prefixId.prefix "duration"
    let duringEventArg = _prefixId.prefix "duringEventArg"
    let elongated_rrp = _prefixId.prefix "elongated_rrp"
    let endEventArg = _prefixId.prefix "endEventArg"
    let experiencer = _prefixId.prefix "experiencer"
    let extent = _prefixId.prefix "extent"
    let finalTime = _prefixId.prefix "finalTime"
    let for_comp_syrp = _prefixId.prefix "for_comp_syrp"
    let force_rrp = _prefixId.prefix "force_rrp"
    /// <summary>
    ///   <para>rdfs:label : frame</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#frame">pmovn:frame</a>
    /// </summary>
    let frame = _prefixId.prefix "frame"
    /// <summary>
    ///   <para>rdfs:label : frame description number</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#frameDescNumber">pmovn:frameDescNumber</a>
    /// </summary>
    let frameDescNumber = _prefixId.prefix "frameDescNumber"
    /// <summary>
    ///   <para>rdfs:label : frame example</para>
    ///   <para>rdfs:comment : directly associates a VerbNet frame to its corresponding example</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#frameExample">pmovn:frameExample</a>
    /// </summary>
    let frameExample = _prefixId.prefix "frameExample"
    /// <summary>
    ///   <para>rdfs:label : frame primary</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#framePrimary">pmovn:framePrimary</a>
    /// </summary>
    let framePrimary = _prefixId.prefix "framePrimary"
    /// <summary>
    ///   <para>rdfs:label : frame secondary</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#frameSecondary">pmovn:frameSecondary</a>
    /// </summary>
    let frameSecondary = _prefixId.prefix "frameSecondary"
    /// <summary>
    ///   <para>rdfs:label : frame semantics description</para>
    ///   <para>rdfs:comment : String representing the semantics of the Frame</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#frameSemanticsDescription">pmovn:frameSemanticsDescription</a>
    /// </summary>
    let frameSemanticsDescription = _prefixId.prefix "frameSemanticsDescription"
    /// <summary>
    ///   <para>rdfs:label : frame syntax description</para>
    ///   <para>rdfs:comment : String representing the syntax of the Frame</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#frameSyntaxDescription">pmovn:frameSyntaxDescription</a>
    /// </summary>
    let frameSyntaxDescription = _prefixId.prefix "frameSyntaxDescription"
    /// <summary>
    ///   <para>rdfs:label : frame xtag</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#frameXtag">pmovn:frameXtag</a>
    /// </summary>
    let frameXtag = _prefixId.prefix "frameXtag"
    let frequency = _prefixId.prefix "frequency"
    let garment_rrp = _prefixId.prefix "garment_rrp"
    let genitive_syrp = _prefixId.prefix "genitive_syrp"
    let goal = _prefixId.prefix "goal"
    let how_extract_syrp = _prefixId.prefix "how_extract_syrp"
    let human_rrp = _prefixId.prefix "human_rrp"
    let idea_rrp = _prefixId.prefix "idea_rrp"
    let initialLocation = _prefixId.prefix "initialLocation"
    let initialTime = _prefixId.prefix "initialTime"
    let instrument = _prefixId.prefix "instrument"
    let int_control_rrp = _prefixId.prefix "int_control_rrp"
    let loc_prp = _prefixId.prefix "loc_prp"
    let location = _prefixId.prefix "location"
    let location_rrp = _prefixId.prefix "location_rrp"
    let machine_rrp = _prefixId.prefix "machine_rrp"
    let material = _prefixId.prefix "material"
    let natural_rrp = _prefixId.prefix "natural_rrp"
    let nonrigid_rrp = _prefixId.prefix "nonrigid_rrp"
    let np_auxnpType = _prefixId.prefix "np_auxnpType"
    let np_ing_syrp = _prefixId.prefix "np_ing_syrp"
    let np_omit_ing_syrp = _prefixId.prefix "np_omit_ing_syrp"
    let np_p_ing_syrp = _prefixId.prefix "np_p_ing_syrp"
    let np_ppart_syrp = _prefixId.prefix "np_ppart_syrp"
    let np_to_inf_syrp = _prefixId.prefix "np_to_inf_syrp"
    let np_tobe_syrp = _prefixId.prefix "np_tobe_syrp"
    let oblique1_auxnpType = _prefixId.prefix "oblique1_auxnpType"
    let oblique2_auxnpType = _prefixId.prefix "oblique2_auxnpType"
    let oblique_auxnpType = _prefixId.prefix "oblique_auxnpType"
    let oc_bare_inf_syrp = _prefixId.prefix "oc_bare_inf_syrp"
    let oc_ing_syrp = _prefixId.prefix "oc_ing_syrp"
    let oc_to_inf_syrp = _prefixId.prefix "oc_to_inf_syrp"
    let organization_rrp = _prefixId.prefix "organization_rrp"
    let participant = _prefixId.prefix "participant"
    let path_prp = _prefixId.prefix "path_prp"
    let patient = _prefixId.prefix "patient"
    let phys_obj_rrp = _prefixId.prefix "phys_obj_rrp"
    let pivot = _prefixId.prefix "pivot"
    let place = _prefixId.prefix "place"
    let plant_rrp = _prefixId.prefix "plant_rrp"
    let plural_prp = _prefixId.prefix "plural_prp"
    let plural_rrp = _prefixId.prefix "plural_rrp"
    let plural_syrp = _prefixId.prefix "plural_syrp"
    let pointy_rrp = _prefixId.prefix "pointy_rrp"
    let pos_ing = _prefixId.prefix "pos_ing"
    let poss_ing_syrp = _prefixId.prefix "poss_ing_syrp"
    let predicate = _prefixId.prefix "predicate"
    let product = _prefixId.prefix "product"
    let quotation_syrp = _prefixId.prefix "quotation_syrp"
    let recipient = _prefixId.prefix "recipient"
    let refl_rrp = _prefixId.prefix "refl_rrp"
    let refl_syrp = _prefixId.prefix "refl_syrp"
    let reflexive = _prefixId.prefix "reflexive"
    let region_rrp = _prefixId.prefix "region_rrp"
    /// <summary>
    ///   <para>rdfs:label : restriction</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#restriction">pmovn:restriction</a>
    /// </summary>
    let restriction = _prefixId.prefix "restriction"
    let result = _prefixId.prefix "result"
    let resultEventArg = _prefixId.prefix "resultEventArg"
    let rigid_rrp = _prefixId.prefix "rigid_rrp"
    let rs_to_inf_syrp = _prefixId.prefix "rs_to_inf_syrp"
    let sc_ing_syrp = _prefixId.prefix "sc_ing_syrp"
    let sc_to_inf_syrp = _prefixId.prefix "sc_to_inf_syrp"
    let scalar_rrp = _prefixId.prefix "scalar_rrp"
    let sentential_syrp = _prefixId.prefix "sentential_syrp"
    let shape_rrp = _prefixId.prefix "shape_rrp"
    let small_clause_syrp = _prefixId.prefix "small_clause_syrp"
    let solid_rrp = _prefixId.prefix "solid_rrp"
    let sound_rrp = _prefixId.prefix "sound_rrp"
    let source = _prefixId.prefix "source"
    let spatial_prp = _prefixId.prefix "spatial_prp"
    let src_prp = _prefixId.prefix "src_prp"
    let startEventArg = _prefixId.prefix "startEventArg"
    let state_rrp = _prefixId.prefix "state_rrp"
    let stimulus = _prefixId.prefix "stimulus"
    /// <summary>
    ///   <para>rdfs:label : subclass of</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#subclassOf">pmovn:subclassOf</a>
    /// </summary>
    let subclassOf = _prefixId.prefix "subclassOf"
    let substance_rrp = _prefixId.prefix "substance_rrp"
    let tensed_that_syrp = _prefixId.prefix "tensed_that_syrp"
    let that_comp_syrp = _prefixId.prefix "that_comp_syrp"
    /// <summary>
    ///   <para>rdfs:label : thematic role</para>
    ///   <a href="http://premon.fbk.eu/ontology/vn#thematicRole">pmovn:thematicRole</a>
    /// </summary>
    let thematicRole = _prefixId.prefix "thematicRole"
    let theme = _prefixId.prefix "theme"
    let time = _prefixId.prefix "time"
    let time_rrp = _prefixId.prefix "time_rrp"
    let to_be_syrp = _prefixId.prefix "to_be_syrp"
    let to_inf_rs_syrp = _prefixId.prefix "to_inf_rs_syrp"
    let tool_rrp = _prefixId.prefix "tool_rrp"
    let topic = _prefixId.prefix "topic"
    let trajectory = _prefixId.prefix "trajectory"
    let undergoer = _prefixId.prefix "undergoer"
    let value = _prefixId.prefix "value"
    let vc_to_inf_syrp = _prefixId.prefix "vc_to_inf_syrp"
    let vehicle_rrp = _prefixId.prefix "vehicle_rrp"
    let wh_comp_syrp = _prefixId.prefix "wh_comp_syrp"
    let wh_extract_syrp = _prefixId.prefix "wh_extract_syrp"
    let wh_inf_syrp = _prefixId.prefix "wh_inf_syrp"
    let wh_ing_syrp = _prefixId.prefix "wh_ing_syrp"
    let what_extract_syrp = _prefixId.prefix "what_extract_syrp"
    let what_inf_syrp = _prefixId.prefix "what_inf_syrp"
    let wheth_inf_syrp = _prefixId.prefix "wheth_inf_syrp"
