#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vir =
    let _prefixId = PrefixId.fromNamespaceLabel "http://w3id.org/vir#" "vir"
    let _namespaceIri = _prefixId.prefix ""
    let IC10_Attribute = _prefixId.prefix "IC10_Attribute"
    let IC11_Personification = _prefixId.prefix "IC11_Personification"
    let IC12_Visual_Recognition = _prefixId.prefix "IC12_Visual_Recognition"
    let IC16_Character = _prefixId.prefix "IC16_Character"
    let IC19_Recto = _prefixId.prefix "IC19_Recto"
    let IC1_Iconographical_Atom = _prefixId.prefix "IC1_Iconographical_Atom"
    let IC20_Verso = _prefixId.prefix "IC20_Verso"
    let IC9_Representation = _prefixId.prefix "IC9_Representation"
    /// <summary>
    ///   <para>rdfs:label : On the base of^^xsd:string</para>
    ///   <para>rdfs:comment : The property describes the source used for the status assignment^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K10_on_the_base_of">vir:K10_on_the_base_of</a>
    /// </summary>
    let K10_on_the_base_of = _prefixId.prefix "K10_on_the_base_of"
    /// <summary>
    ///   <para>rdfs:label : is based on^^xsd:string</para>
    ///   <para>rdfs:comment : The property describes the source used for the status assignment^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K10i_is_basis_for">vir:K10i_is_basis_for</a>
    /// </summary>
    let K10i_is_basis_for = _prefixId.prefix "K10i_is_basis_for"
    /// <summary>
    ///   <para>rdfs:label : assigned^^xsd:string</para>
    ///   <para>rdfs:comment : The property indicates the status assigned during the visual recognition event^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K11_assigned">vir:K11_assigned</a>
    /// </summary>
    let K11_assigned = _prefixId.prefix "K11_assigned"
    /// <summary>
    ///   <para>rdfs:label : was assigned by^^xsd:string</para>
    ///   <para>rdfs:comment : The property indicates the status assigned during the visual recognition event^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K11i_was_assigned_by">vir:K11i_was_assigned_by</a>
    /// </summary>
    let K11i_was_assigned_by = _prefixId.prefix "K11i_was_assigned_by"
    /// <summary>
    ///   <para>rdfs:label : symbolize^^xsd:string</para>
    ///   <para>rdfs:comment : The property indicates the symbolic value of the attribute presents in a representation^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K14_symbolize">vir:K14_symbolize</a>
    /// </summary>
    let K14_symbolize = _prefixId.prefix "K14_symbolize"
    /// <summary>
    ///   <para>rdfs:label : has symbolic value^^xsd:string</para>
    ///   <para>rdfs:comment : The property indicates the symbolic value of the attribute presents in a representation^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K14i_has_symbolic_value">vir:K14i_has_symbolic_value</a>
    /// </summary>
    let K14i_has_symbolic_value = _prefixId.prefix "K14i_has_symbolic_value"
    /// <summary>
    ///   <para>rdfs:label : use feature^^xsd:string</para>
    ///   <para>rdfs:comment : The property indicates the specific attribute used during the production of a visual object^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K15_use_feature">vir:K15_use_feature</a>
    /// </summary>
    let K15_use_feature = _prefixId.prefix "K15_use_feature"
    /// <summary>
    ///   <para>rdfs:label : has been used by^^xsd:string</para>
    ///   <para>rdfs:comment : The property indicates the specific attribute used during the production of a visual object^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K15i_has_been_used_by">vir:K15i_has_been_used_by</a>
    /// </summary>
    let K15i_has_been_used_by = _prefixId.prefix "K15i_has_been_used_by"
    /// <summary>
    ///   <para>rdfs:label : has attribute^^xsd:string</para>
    ///   <para>rdfs:comment : This property associates an attribute with the iconographical object where it is depicted^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K17_has_attribute">vir:K17_has_attribute</a>
    /// </summary>
    let K17_has_attribute = _prefixId.prefix "K17_has_attribute"
    /// <summary>
    ///   <para>rdfs:label : is attribute of^^xsd:string</para>
    ///   <para>rdfs:comment : This property associates an attribute with the iconographical object where it is depicted^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K17i_is_attribute_of">vir:K17i_is_attribute_of</a>
    /// </summary>
    let K17i_is_attribute_of = _prefixId.prefix "K17i_is_attribute_of"
    /// <summary>
    ///   <para>rdfs:label : Denote^^xsd:string</para>
    ///   <para>rdfs:comment : The property documents the assignment of an iconographical object to a specific physical man-made object. It is a shortcut for the more fully developed path IC12 Visual Recognition assign (K9) to a E18 Physical Thing the status of (K11) IC9 Representation^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K1_denotes">vir:K1_denotes</a>
    /// </summary>
    let K1_denotes = _prefixId.prefix "K1_denotes"
    /// <summary>
    ///   <para>rdfs:label : is denoted by^^xsd:string</para>
    ///   <para>rdfs:comment : The property documents the assignment of an iconographical object to a specific physical man-made object. It is a shortcut for the more fully developed path IC12 Visual Recognition assign (K9) to a E18 Physical Thing the status of (K11) IC9 Representation.^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K1i_is_denoted_by">vir:K1i_is_denoted_by</a>
    /// </summary>
    let K1i_is_denoted_by = _prefixId.prefix "K1i_is_denoted_by"
    /// <summary>
    ///   <para>rdfs:label : forms part of^^xsd:string</para>
    ///   <para>rdfs:comment : This property put in relation a representation with a part of itself.^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K20_forms_part_of">vir:K20_forms_part_of</a>
    /// </summary>
    let K20_forms_part_of = _prefixId.prefix "K20_forms_part_of"
    /// <summary>
    ///   <para>rdfs:label : is composed of^^xsd:string</para>
    ///   <para>rdfs:comment : This property put in relation a representation with a part of itself.^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K20i_is_composed_of">vir:K20i_is_composed_of</a>
    /// </summary>
    let K20i_is_composed_of = _prefixId.prefix "K20i_is_composed_of"
    /// <summary>
    ///   <para>rdfs:label : depict things of type^^xsd:string</para>
    ///   <para>rdfs:comment : This property indicates the type of object depicted by an iconographical attribute^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K21_depict_things_of_type">vir:K21_depict_things_of_type</a>
    /// </summary>
    let K21_depict_things_of_type = _prefixId.prefix "K21_depict_things_of_type"

    /// <summary>
    ///   <para>rdfs:label : is depiction of attribute^^xsd:string</para>
    ///   <para>rdfs:comment : This property indicates the type of object depicted by an iconographical attribute^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K21i_is_depiction_of_attribute">vir:K21i_is_depiction_of_attribute</a>
    /// </summary>
    let K21i_is_depiction_of_attribute =
        _prefixId.prefix "K21i_is_depiction_of_attribute"

    /// <summary>
    ///   <para>rdfs:label : has personification^^xsd:string</para>
    ///   <para>rdfs:comment : This property indicates the membership of a personification in an iconographical object^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K22_has_personification">vir:K22_has_personification</a>
    /// </summary>
    let K22_has_personification = _prefixId.prefix "K22_has_personification"
    /// <summary>
    ///   <para>rdfs:label : is present in^^xsd:string</para>
    ///   <para>rdfs:comment : This property indicates the membership of a personification in an iconographical object^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K22i_is_present_in">vir:K22i_is_present_in</a>
    /// </summary>
    let K22i_is_present_in = _prefixId.prefix "K22i_is_present_in"
    /// <summary>
    ///   <para>rdfs:label : connote^^xsd:string</para>
    ///   <para>rdfs:comment : This property indicates the connotation relationships, formalised by Barthes, between a conceptual entity and an iconographical object. It is a shortcut for the more fully developed path IC12 Visual Recognition assign (K9) to a IC9 Representation a new (K11) IC9 Representation. It doesn&amp;#8217;t offer any information about when and whom established the connotation relationship^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K23_connote">vir:K23_connote</a>
    /// </summary>
    let K23_connote = _prefixId.prefix "K23_connote"
    /// <summary>
    ///   <para>rdfs:label : is connoted by^^xsd:string</para>
    ///   <para>rdfs:comment : This property indicates the connotation relationships, formalised by Barthes, between a conceptual entity and an iconographical object. It is a shortcut for the more fully developed path IC12 Visual Recognition assign (K9) to a IC9 Representation a new (K11) IC9 Representation. It doesn&amp;#8217;t offer any information about when and whom established the connotation relationship^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K23i_is_connotation_of">vir:K23i_is_connotation_of</a>
    /// </summary>
    let K23i_is_connotation_of = _prefixId.prefix "K23i_is_connotation_of"
    /// <summary>
    ///   <para>rdfs:label : portray^^xsd:string</para>
    ///   <para>rdfs:comment : This property put in relation an iconographical object with the portrayed character.^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K24_portray">vir:K24_portray</a>
    /// </summary>
    let K24_portray = _prefixId.prefix "K24_portray"
    /// <summary>
    ///   <para>rdfs:label : is portrayed by^^xsd:string</para>
    ///   <para>rdfs:comment : This property put in relation an iconographical object with the portrayed character.^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K24i_is_portrayed_in">vir:K24i_is_portrayed_in</a>
    /// </summary>
    let K24i_is_portrayed_in = _prefixId.prefix "K24i_is_portrayed_in"
    /// <summary>
    ///   <para>rdfs:label : express^^xsd:string</para>
    ///   <para>rdfs:comment : This property put in relation a symbolic object with a personification in a work of art^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K25_express">vir:K25_express</a>
    /// </summary>
    let K25_express = _prefixId.prefix "K25_express"
    /// <summary>
    ///   <para>rdfs:label : is abstraction of^^xsd:string</para>
    ///   <para>rdfs:comment : This property put in relation a symbolic object with a personification in a work of art.^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K25i_is_abstraction_of">vir:K25i_is_abstraction_of</a>
    /// </summary>
    let K25i_is_abstraction_of = _prefixId.prefix "K25i_is_abstraction_of"
    /// <summary>
    ///   <para>rdfs:label : has source^^xsd:string</para>
    ///   <para>rdfs:comment : This property associates an instance of IC16 Character with an instance of E39 Actor that the character is motivated by or is intended to represent^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K26_has_source">vir:K26_has_source</a>
    /// </summary>
    let K26_has_source = _prefixId.prefix "K26_has_source"
    /// <summary>
    ///   <para>rdfs:label : is source of^^xsd:string</para>
    ///   <para>rdfs:comment : This property associates an instance of IC16 Character with an instance of E39 Actor that the character is motivated by or is intended to represent^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K26i_is_source_of">vir:K26i_is_source_of</a>
    /// </summary>
    let K26i_is_source_of = _prefixId.prefix "K26i_is_source_of"
    /// <summary>
    ///   <para>rdfs:label : illustrate^^xsd:string</para>
    ///   <para>rdfs:comment : This property associate an information object to a iconographical representation^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K34_illustrate">vir:K34_illustrate</a>
    /// </summary>
    let K34_illustrate = _prefixId.prefix "K34_illustrate"
    /// <summary>
    ///   <para>rdfs:label : is illustrated by^^xsd:string</para>
    ///   <para>rdfs:comment : This property associate an information object to a iconographical representation^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K34i_is_illustrated_by">vir:K34i_is_illustrated_by</a>
    /// </summary>
    let K34i_is_illustrated_by = _prefixId.prefix "K34i_is_illustrated_by"
    let K4_1_prototypical_model = _prefixId.prefix "K4_1_prototypical_model"
    /// <summary>
    ///   <para>rdfs:label : is visual prototype of^^xsd:string</para>
    ///   <para>rdfs:comment : The property documents the use of a specific prototypical example for an image. The nature of the relationships helps define a map of relationships between prototypical items used in the arts.^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K4_is_visual_prototype_of">vir:K4_is_visual_prototype_of</a>
    /// </summary>
    let K4_is_visual_prototype_of = _prefixId.prefix "K4_is_visual_prototype_of"
    /// <summary>
    ///   <para>rdfs:label : has visual prototype^^xsd:string</para>
    ///   <para>rdfs:comment : The property documents the use of a specific prototypical example for an image. The nature of the relationships helps define a map of relationships between prototypical items used in the arts.^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K4i_has_visual_prototype">vir:K4i_has_visual_prototype</a>
    /// </summary>
    let K4i_has_visual_prototype = _prefixId.prefix "K4i_has_visual_prototype"
    /// <summary>
    ///   <para>rdfs:label : has back^^xsd:string</para>
    ///   <para>rdfs:comment : The property documents the presence of a Verso or a Recto, respectively in the back or in the front of an object^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K6_has_back">vir:K6_has_back</a>
    /// </summary>
    let K6_has_back = _prefixId.prefix "K6_has_back"
    /// <summary>
    ///   <para>rdfs:label : has front^^xsd:string</para>
    ///   <para>rdfs:comment : The property documents the presence of a Verso or a Recto, respectively in the back or in the front of an object.^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K6i_has_front">vir:K6i_has_front</a>
    /// </summary>
    let K6i_has_front = _prefixId.prefix "K6i_has_front"
    /// <summary>
    ///   <para>rdfs:label : is recto of^^xsd:string</para>
    ///   <para>rdfs:comment : The property indicates the presence of a recto in the described object^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K7_is_recto_of">vir:K7_is_recto_of</a>
    /// </summary>
    let K7_is_recto_of = _prefixId.prefix "K7_is_recto_of"
    /// <summary>
    ///   <para>rdfs:label : has recto^^xsd:string</para>
    ///   <para>rdfs:comment : The property indicates the presence of a recto in the described object^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K7i_has_recto">vir:K7i_has_recto</a>
    /// </summary>
    let K7i_has_recto = _prefixId.prefix "K7i_has_recto"
    /// <summary>
    ///   <para>rdfs:label : is verso of^^xsd:string</para>
    ///   <para>rdfs:comment : The property indicates the presence of a verso in the described object^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K8_is_verso_of">vir:K8_is_verso_of</a>
    /// </summary>
    let K8_is_verso_of = _prefixId.prefix "K8_is_verso_of"
    /// <summary>
    ///   <para>rdfs:label : has verso^^xsd:string</para>
    ///   <para>rdfs:comment : The property indicates the presence of a verso in the described object^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K8i_has_verso">vir:K8i_has_verso</a>
    /// </summary>
    let K8i_has_verso = _prefixId.prefix "K8i_has_verso"
    /// <summary>
    ///   <para>rdfs:label : Assigned status to^^xsd:string</para>
    ///   <para>rdfs:comment : The property documents the assignment of status to a specific physical thing^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K9_Assigned_status_to">vir:K9_Assigned_status_to</a>
    /// </summary>
    let K9_Assigned_status_to = _prefixId.prefix "K9_Assigned_status_to"
    /// <summary>
    ///   <para>rdfs:label : has status assigned by^^xsd:string</para>
    ///   <para>rdfs:comment : The property documents the assignment of status to a specific physical thing.^^xsd:string</para>
    ///   <a href="http://w3id.org/vir#K9i_has_status_assigned_by">vir:K9i_has_status_assigned_by</a>
    /// </summary>
    let K9i_has_status_assigned_by = _prefixId.prefix "K9i_has_status_assigned_by"
    let PCK4_is_visual_prototype_of = _prefixId.prefix "PCK4_is_visual_prototype_of"
