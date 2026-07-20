namespace http.w3id.org.vir.hash

open DoxAletheia

module vir =
    let _namespace_name = "http://w3id.org/vir#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A set of features considered by a viewer more salient than others and used as a key for the identification of a Representation. The attribute could correspond to iconographical elements or simple signs which the viewer uses to provide a stable identity to a visual object.
    /// <see href="http://w3id.org/vir#IC10_Attribute"></see></summary>
    let IC10_Attribute = _prefix "IC10_Attribute"
    /// <summary>
    /// A human, or anthropomorphic figure, that represents an abstract idea or a concept
    /// <see href="http://w3id.org/vir#IC11_Personification"></see></summary>
    let IC11_Personification = _prefix "IC11_Personification"
    /// <summary>
    /// This class comprises fictional individuals, or groups, appearing in a representation. Each character portrayed can have a type, for example 'Saint' or 'layman'. Every saint portrayed is considered here as a character and not as an actor.
    /// <see href="http://w3id.org/vir#IC16_Character"></see></summary>
    let IC16_Character = _prefix "IC16_Character"
    /// <summary>
    /// The activity of assigning the iconographical status to a man-made object, or to one of its parts. It takes into account the possibility to link it to a speech act or a document where the authoritative proposition is clearly made
    /// <see href="http://w3id.org/vir#IC12_Visual_Recognition"></see></summary>
    let IC12_Visual_Recognition = _prefix "IC12_Visual_Recognition"
    /// <summary>
    /// The front or face of a single sheet or the right-hand page of an open book. The feature is presents in object such as codex, books, pamphlets, documents, photographs and painting.
    /// <see href="http://w3id.org/vir#IC19_Recto"></see></summary>
    let IC19_Recto = _prefix "IC19_Recto"
    /// <summary>
    /// An Iconographical Atom is a physical arrangement of forms and colours created by human activity
    /// <see href="http://w3id.org/vir#IC1_Iconographical_Atom"></see></summary>
    let IC1_Iconographical_Atom = _prefix "IC1_Iconographical_Atom"
    /// <summary>
    /// The back or underside of a single sheet of paper, or the left-hand page of an open book. The feature is presents in object such as codex, books, pamphlets, documents, photographs and painting.
    /// <see href="http://w3id.org/vir#IC20_Verso"></see></summary>
    let IC20_Verso = _prefix "IC20_Verso"
    /// <summary>
    /// A single pictorial item or a part of it.  Single representations or region of the same representations are instance of this class.
    /// <see href="http://w3id.org/vir#IC9_Representation"></see></summary>
    let IC9_Representation = _prefix "IC9_Representation"
    /// <summary>
    /// The property describes the source used for the status assignment
    /// <see href="http://w3id.org/vir#K10_on_the_base_of"></see></summary>
    let K10_on_the_base_of = _prefix "K10_on_the_base_of"
    /// <summary>
    /// The property describes the source used for the status assignment
    /// <see href="http://w3id.org/vir#K10i_is_basis_for"></see></summary>
    let K10i_is_basis_for = _prefix "K10i_is_basis_for"
    /// <summary>
    /// The property indicates the status assigned during the visual recognition event
    /// <see href="http://w3id.org/vir#K11_assigned"></see></summary>
    let K11_assigned = _prefix "K11_assigned"
    /// <summary>
    /// The property indicates the status assigned during the visual recognition event
    /// <see href="http://w3id.org/vir#K11i_was_assigned_by"></see></summary>
    let K11i_was_assigned_by = _prefix "K11i_was_assigned_by"
    /// <summary>
    /// The property indicates the symbolic value of the attribute presents in a representation
    /// <see href="http://w3id.org/vir#K14_symbolize"></see></summary>
    let K14_symbolize = _prefix "K14_symbolize"
    /// <summary>
    /// The property indicates the symbolic value of the attribute presents in a representation
    /// <see href="http://w3id.org/vir#K14i_has_symbolic_value"></see></summary>
    let K14i_has_symbolic_value = _prefix "K14i_has_symbolic_value"
    /// <summary>
    /// The property indicates the specific attribute used during the production of a visual object
    /// <see href="http://w3id.org/vir#K15_use_feature"></see></summary>
    let K15_use_feature = _prefix "K15_use_feature"
    /// <summary>
    /// The property indicates the specific attribute used during the production of a visual object
    /// <see href="http://w3id.org/vir#K15i_has_been_used_by"></see></summary>
    let K15i_has_been_used_by = _prefix "K15i_has_been_used_by"
    /// <summary>
    /// This property associates an attribute with the iconographical object where it is depicted
    /// <see href="http://w3id.org/vir#K17_has_attribute"></see></summary>
    let K17_has_attribute = _prefix "K17_has_attribute"
    /// <summary>
    /// This property associates an attribute with the iconographical object where it is depicted
    /// <see href="http://w3id.org/vir#K17i_is_attribute_of"></see></summary>
    let K17i_is_attribute_of = _prefix "K17i_is_attribute_of"
    /// <summary>
    /// The property documents the assignment of an iconographical object to a specific physical man-made object. It is a shortcut for the more fully developed path IC12 Visual Recognition assign (K9) to a E18 Physical Thing the status of (K11) IC9 Representation
    /// <see href="http://w3id.org/vir#K1_denotes"></see></summary>
    let K1_denotes = _prefix "K1_denotes"
    /// <summary>
    /// The property documents the assignment of an iconographical object to a specific physical man-made object. It is a shortcut for the more fully developed path IC12 Visual Recognition assign (K9) to a E18 Physical Thing the status of (K11) IC9 Representation.
    /// <see href="http://w3id.org/vir#K1i_is_denoted_by"></see></summary>
    let K1i_is_denoted_by = _prefix "K1i_is_denoted_by"
    /// <summary>
    /// This property put in relation a representation with a part of itself.
    /// <see href="http://w3id.org/vir#K20_forms_part_of"></see></summary>
    let K20_forms_part_of = _prefix "K20_forms_part_of"
    /// <summary>
    /// This property put in relation a representation with a part of itself.
    /// <see href="http://w3id.org/vir#K20i_is_composed_of"></see></summary>
    let K20i_is_composed_of = _prefix "K20i_is_composed_of"
    /// <summary>
    /// This property indicates the type of object depicted by an iconographical attribute
    /// <see href="http://w3id.org/vir#K21_depict_things_of_type"></see></summary>
    let K21_depict_things_of_type = _prefix "K21_depict_things_of_type"
    /// <summary>
    /// This property indicates the type of object depicted by an iconographical attribute
    /// <see href="http://w3id.org/vir#K21i_is_depiction_of_attribute"></see></summary>
    let K21i_is_depiction_of_attribute = _prefix "K21i_is_depiction_of_attribute"
    /// <summary>
    /// This property indicates the membership of a personification in an iconographical object
    /// <see href="http://w3id.org/vir#K22_has_personification"></see></summary>
    let K22_has_personification = _prefix "K22_has_personification"
    /// <summary>
    /// This property indicates the membership of a personification in an iconographical object
    /// <see href="http://w3id.org/vir#K22i_is_present_in"></see></summary>
    let K22i_is_present_in = _prefix "K22i_is_present_in"
    /// <summary>
    /// This property indicates the connotation relationships, formalised by Barthes, between a conceptual entity and an iconographical object. It is a shortcut for the more fully developed path IC12 Visual Recognition assign (K9) to a IC9 Representation a new (K11) IC9 Representation. It doesn&amp;#8217;t offer any information about when and whom established the connotation relationship
    /// <see href="http://w3id.org/vir#K23_connote"></see></summary>
    let K23_connote = _prefix "K23_connote"
    /// <summary>
    /// This property indicates the connotation relationships, formalised by Barthes, between a conceptual entity and an iconographical object. It is a shortcut for the more fully developed path IC12 Visual Recognition assign (K9) to a IC9 Representation a new (K11) IC9 Representation. It doesn&amp;#8217;t offer any information about when and whom established the connotation relationship
    /// <see href="http://w3id.org/vir#K23i_is_connotation_of"></see></summary>
    let K23i_is_connotation_of = _prefix "K23i_is_connotation_of"
    /// <summary>
    /// This property put in relation an iconographical object with the portrayed character.
    /// <see href="http://w3id.org/vir#K24_portray"></see></summary>
    let K24_portray = _prefix "K24_portray"
    /// <summary>
    /// This property put in relation an iconographical object with the portrayed character.
    /// <see href="http://w3id.org/vir#K24i_is_portrayed_in"></see></summary>
    let K24i_is_portrayed_in = _prefix "K24i_is_portrayed_in"
    /// <summary>
    /// This property put in relation a symbolic object with a personification in a work of art
    /// <see href="http://w3id.org/vir#K25_express"></see></summary>
    let K25_express = _prefix "K25_express"
    /// <summary>
    /// This property put in relation a symbolic object with a personification in a work of art.
    /// <see href="http://w3id.org/vir#K25i_is_abstraction_of"></see></summary>
    let K25i_is_abstraction_of = _prefix "K25i_is_abstraction_of"
    /// <summary>
    /// This property associates an instance of IC16 Character with an instance of E39 Actor that the character is motivated by or is intended to represent
    /// <see href="http://w3id.org/vir#K26_has_source"></see></summary>
    let K26_has_source = _prefix "K26_has_source"
    /// <summary>
    /// This property associates an instance of IC16 Character with an instance of E39 Actor that the character is motivated by or is intended to represent
    /// <see href="http://w3id.org/vir#K26i_is_source_of"></see></summary>
    let K26i_is_source_of = _prefix "K26i_is_source_of"
    /// <summary>
    /// This property associate an information object to a iconographical representation
    /// <see href="http://w3id.org/vir#K34_illustrate"></see></summary>
    let K34_illustrate = _prefix "K34_illustrate"
    /// <summary>
    /// This property associate an information object to a iconographical representation
    /// <see href="http://w3id.org/vir#K34i_is_illustrated_by"></see></summary>
    let K34i_is_illustrated_by = _prefix "K34i_is_illustrated_by"
    /// <summary>
    ///   <see href="http://w3id.org/vir#K4_1_prototypical_model"></see>
    /// </summary>
    let K4_1_prototypical_model = _prefix "K4_1_prototypical_model"
    /// <summary>
    /// n-ary construct to document the use of a specific prototypical example for an image. The nature of the relationships helps define a map of relationships between prototypical items used in the arts. To be used together with 'K4.1_prototypical_model'
    /// <see href="http://w3id.org/vir#PCK4_is_visual_prototype_of"></see></summary>
    let PCK4_is_visual_prototype_of = _prefix "PCK4_is_visual_prototype_of"
    /// <summary>
    /// The property documents the use of a specific prototypical example for an image. The nature of the relationships helps define a map of relationships between prototypical items used in the arts.
    /// <see href="http://w3id.org/vir#K4_is_visual_prototype_of"></see></summary>
    let K4_is_visual_prototype_of = _prefix "K4_is_visual_prototype_of"
    /// <summary>
    /// The property documents the use of a specific prototypical example for an image. The nature of the relationships helps define a map of relationships between prototypical items used in the arts.
    /// <see href="http://w3id.org/vir#K4i_has_visual_prototype"></see></summary>
    let K4i_has_visual_prototype = _prefix "K4i_has_visual_prototype"
    /// <summary>
    /// The property documents the presence of a Verso or a Recto, respectively in the back or in the front of an object
    /// <see href="http://w3id.org/vir#K6_has_back"></see></summary>
    let K6_has_back = _prefix "K6_has_back"
    /// <summary>
    /// The property documents the presence of a Verso or a Recto, respectively in the back or in the front of an object.
    /// <see href="http://w3id.org/vir#K6i_has_front"></see></summary>
    let K6i_has_front = _prefix "K6i_has_front"
    /// <summary>
    /// The property indicates the presence of a recto in the described object
    /// <see href="http://w3id.org/vir#K7_is_recto_of"></see></summary>
    let K7_is_recto_of = _prefix "K7_is_recto_of"
    /// <summary>
    /// The property indicates the presence of a recto in the described object
    /// <see href="http://w3id.org/vir#K7i_has_recto"></see></summary>
    let K7i_has_recto = _prefix "K7i_has_recto"
    /// <summary>
    /// The property indicates the presence of a verso in the described object
    /// <see href="http://w3id.org/vir#K8_is_verso_of"></see></summary>
    let K8_is_verso_of = _prefix "K8_is_verso_of"
    /// <summary>
    /// The property indicates the presence of a verso in the described object
    /// <see href="http://w3id.org/vir#K8i_has_verso"></see></summary>
    let K8i_has_verso = _prefix "K8i_has_verso"
    /// <summary>
    /// The property documents the assignment of status to a specific physical thing
    /// <see href="http://w3id.org/vir#K9_Assigned_status_to"></see></summary>
    let K9_Assigned_status_to = _prefix "K9_Assigned_status_to"
    /// <summary>
    /// The property documents the assignment of status to a specific physical thing.
    /// <see href="http://w3id.org/vir#K9i_has_status_assigned_by"></see></summary>
    let K9i_has_status_assigned_by = _prefix "K9i_has_status_assigned_by"
