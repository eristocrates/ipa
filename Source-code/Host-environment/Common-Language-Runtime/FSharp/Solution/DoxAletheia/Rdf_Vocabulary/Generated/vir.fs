namespace http.w3id.org.vir.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vir =
    let _namespace_iri = Namespace_Iri vir |> NamespaceIRI
    /// <summary>
    ///   <para>vir:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"On 03/03/2019 change the range of K11 to E36_Visual_Item in order to accomodate the description of the recognition of Attributes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/vir#">http://w3id.org/vir#</seealso>
    let _prefix_iri = Prefixed_Name(vir, "") |> PrefixedName
    /// <summary>
    ///   <para>vir:IC10_Attribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Class</para>
    ///   <para>"A set of features considered by a viewer more salient than others and used as a key for the identification of a Representation. The attribute could correspond to iconographical elements or simple signs which the viewer uses to provide a stable identity to a visual object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Iconographical Attribute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#IC10_Attribute">http://w3id.org/vir#IC10_Attribute</seealso>
    let IC10_Attribute = Prefixed_Name(vir, "IC10_Attribute") |> PrefixedName

    /// <summary>
    ///   <para>vir:IC11_Personification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdf:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A human, or anthropomorphic figure, that represents an abstract idea or a concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Personification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#IC11_Personification">http://w3id.org/vir#IC11_Personification</seealso>
    let IC11_Personification =
        Prefixed_Name(vir, "IC11_Personification") |> PrefixedName

    /// <summary>
    ///   <para>vir:IC12_Visual_Recognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Class</para>
    ///   <para>"The activity of assigning the iconographical status to a man-made object, or to one of its parts. It takes into account the possibility to link it to a speech act or a document where the authoritative proposition is clearly made"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Visual Recognition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#IC12_Visual_Recognition">http://w3id.org/vir#IC12_Visual_Recognition</seealso>
    let IC12_Visual_Recognition =
        Prefixed_Name(vir, "IC12_Visual_Recognition") |> PrefixedName

    /// <summary>
    ///   <para>vir:IC16_Character</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Class</para>
    ///   <para>"This class comprises fictional individuals, or groups, appearing in a representation. Each character portrayed can have a type, for example 'Saint' or 'layman'. Every saint portrayed is considered here as a character and not as an actor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Character"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#IC16_Character">http://w3id.org/vir#IC16_Character</seealso>
    let IC16_Character = Prefixed_Name(vir, "IC16_Character") |> PrefixedName
    /// <summary>
    ///   <para>vir:IC19_Recto</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Class</para>
    ///   <para>"The front or face of a single sheet or the right-hand page of an open book. The feature is presents in object such as codex, books, pamphlets, documents, photographs and painting."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Recto"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#IC19_Recto">http://w3id.org/vir#IC19_Recto</seealso>
    let IC19_Recto = Prefixed_Name(vir, "IC19_Recto") |> PrefixedName

    /// <summary>
    ///   <para>vir:IC1_Iconographical_Atom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Class</para>
    ///   <para>"An Iconographical Atom is a physical arrangement of forms and colours created by human activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Iconographical Atom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#IC1_Iconographical_Atom">http://w3id.org/vir#IC1_Iconographical_Atom</seealso>
    let IC1_Iconographical_Atom =
        Prefixed_Name(vir, "IC1_Iconographical_Atom") |> PrefixedName

    /// <summary>
    ///   <para>vir:IC20_Verso</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Class</para>
    ///   <para>"The back or underside of a single sheet of paper, or the left-hand page of an open book. The feature is presents in object such as codex, books, pamphlets, documents, photographs and painting."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Verso"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#IC20_Verso">http://w3id.org/vir#IC20_Verso</seealso>
    let IC20_Verso = Prefixed_Name(vir, "IC20_Verso") |> PrefixedName
    /// <summary>
    ///   <para>vir:IC9_Representation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Class</para>
    ///   <para>"A single pictorial item or a part of it.  Single representations or region of the same representations are instance of this class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Representation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#IC9_Representation">http://w3id.org/vir#IC9_Representation</seealso>
    let IC9_Representation = Prefixed_Name(vir, "IC9_Representation") |> PrefixedName
    /// <summary>
    ///   <para>vir:K10_on_the_base_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property describes the source used for the status assignment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"On the base of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K10_on_the_base_of">http://w3id.org/vir#K10_on_the_base_of</seealso>
    let K10_on_the_base_of = Prefixed_Name(vir, "K10_on_the_base_of") |> PrefixedName
    /// <summary>
    ///   <para>vir:K10i_is_basis_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property describes the source used for the status assignment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is based on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K10i_is_basis_for">http://w3id.org/vir#K10i_is_basis_for</seealso>
    let K10i_is_basis_for = Prefixed_Name(vir, "K10i_is_basis_for") |> PrefixedName
    /// <summary>
    ///   <para>vir:K11_assigned</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property indicates the status assigned during the visual recognition event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"assigned"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K11_assigned">http://w3id.org/vir#K11_assigned</seealso>
    let K11_assigned = Prefixed_Name(vir, "K11_assigned") |> PrefixedName

    /// <summary>
    ///   <para>vir:K11i_was_assigned_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property indicates the status assigned during the visual recognition event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"was assigned by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K11i_was_assigned_by">http://w3id.org/vir#K11i_was_assigned_by</seealso>
    let K11i_was_assigned_by =
        Prefixed_Name(vir, "K11i_was_assigned_by") |> PrefixedName

    /// <summary>
    ///   <para>vir:K14_symbolize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property indicates the symbolic value of the attribute presents in a representation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"symbolize"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K14_symbolize">http://w3id.org/vir#K14_symbolize</seealso>
    let K14_symbolize = Prefixed_Name(vir, "K14_symbolize") |> PrefixedName

    /// <summary>
    ///   <para>vir:K14i_has_symbolic_value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property indicates the symbolic value of the attribute presents in a representation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has symbolic value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K14i_has_symbolic_value">http://w3id.org/vir#K14i_has_symbolic_value</seealso>
    let K14i_has_symbolic_value =
        Prefixed_Name(vir, "K14i_has_symbolic_value") |> PrefixedName

    /// <summary>
    ///   <para>vir:K15_use_feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property indicates the specific attribute used during the production of a visual object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"use feature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K15_use_feature">http://w3id.org/vir#K15_use_feature</seealso>
    let K15_use_feature = Prefixed_Name(vir, "K15_use_feature") |> PrefixedName

    /// <summary>
    ///   <para>vir:K15i_has_been_used_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property indicates the specific attribute used during the production of a visual object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has been used by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K15i_has_been_used_by">http://w3id.org/vir#K15i_has_been_used_by</seealso>
    let K15i_has_been_used_by =
        Prefixed_Name(vir, "K15i_has_been_used_by") |> PrefixedName

    /// <summary>
    ///   <para>vir:K17_has_attribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property associates an attribute with the iconographical object where it is depicted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has attribute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K17_has_attribute">http://w3id.org/vir#K17_has_attribute</seealso>
    let K17_has_attribute = Prefixed_Name(vir, "K17_has_attribute") |> PrefixedName

    /// <summary>
    ///   <para>vir:K17i_is_attribute_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property associates an attribute with the iconographical object where it is depicted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is attribute of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K17i_is_attribute_of">http://w3id.org/vir#K17i_is_attribute_of</seealso>
    let K17i_is_attribute_of =
        Prefixed_Name(vir, "K17i_is_attribute_of") |> PrefixedName

    /// <summary>
    ///   <para>vir:K1_denotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property documents the assignment of an iconographical object to a specific physical man-made object. It is a shortcut for the more fully developed path IC12 Visual Recognition assign (K9) to a E18 Physical Thing the status of (K11) IC9 Representation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Denote"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K1_denotes">http://w3id.org/vir#K1_denotes</seealso>
    let K1_denotes = Prefixed_Name(vir, "K1_denotes") |> PrefixedName
    /// <summary>
    ///   <para>vir:K1i_is_denoted_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property documents the assignment of an iconographical object to a specific physical man-made object. It is a shortcut for the more fully developed path IC12 Visual Recognition assign (K9) to a E18 Physical Thing the status of (K11) IC9 Representation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is denoted by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K1i_is_denoted_by">http://w3id.org/vir#K1i_is_denoted_by</seealso>
    let K1i_is_denoted_by = Prefixed_Name(vir, "K1i_is_denoted_by") |> PrefixedName
    /// <summary>
    ///   <para>vir:K20_forms_part_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property put in relation a representation with a part of itself."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"forms part of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K20_forms_part_of">http://w3id.org/vir#K20_forms_part_of</seealso>
    let K20_forms_part_of = Prefixed_Name(vir, "K20_forms_part_of") |> PrefixedName
    /// <summary>
    ///   <para>vir:K20i_is_composed_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property put in relation a representation with a part of itself."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is composed of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K20i_is_composed_of">http://w3id.org/vir#K20i_is_composed_of</seealso>
    let K20i_is_composed_of = Prefixed_Name(vir, "K20i_is_composed_of") |> PrefixedName

    /// <summary>
    ///   <para>vir:K21_depict_things_of_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property indicates the type of object depicted by an iconographical attribute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"depict things of type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K21_depict_things_of_type">http://w3id.org/vir#K21_depict_things_of_type</seealso>
    let K21_depict_things_of_type =
        Prefixed_Name(vir, "K21_depict_things_of_type") |> PrefixedName

    /// <summary>
    ///   <para>vir:K21i_is_depiction_of_attribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property indicates the type of object depicted by an iconographical attribute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is depiction of attribute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K21i_is_depiction_of_attribute">http://w3id.org/vir#K21i_is_depiction_of_attribute</seealso>
    let K21i_is_depiction_of_attribute =
        Prefixed_Name(vir, "K21i_is_depiction_of_attribute") |> PrefixedName

    /// <summary>
    ///   <para>vir:K22_has_personification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property indicates the membership of a personification in an iconographical object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has personification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K22_has_personification">http://w3id.org/vir#K22_has_personification</seealso>
    let K22_has_personification =
        Prefixed_Name(vir, "K22_has_personification") |> PrefixedName

    /// <summary>
    ///   <para>vir:K22i_is_present_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property indicates the membership of a personification in an iconographical object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is present in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K22i_is_present_in">http://w3id.org/vir#K22i_is_present_in</seealso>
    let K22i_is_present_in = Prefixed_Name(vir, "K22i_is_present_in") |> PrefixedName
    /// <summary>
    ///   <para>vir:K23_connote</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property indicates the connotation relationships, formalised by Barthes, between a conceptual entity and an iconographical object. It is a shortcut for the more fully developed path IC12 Visual Recognition assign (K9) to a IC9 Representation a new (K11) IC9 Representation. It doesn&amp;#8217;t offer any information about when and whom established the connotation relationship"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"connote"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K23_connote">http://w3id.org/vir#K23_connote</seealso>
    let K23_connote = Prefixed_Name(vir, "K23_connote") |> PrefixedName

    /// <summary>
    ///   <para>vir:K23i_is_connotation_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property indicates the connotation relationships, formalised by Barthes, between a conceptual entity and an iconographical object. It is a shortcut for the more fully developed path IC12 Visual Recognition assign (K9) to a IC9 Representation a new (K11) IC9 Representation. It doesn&amp;#8217;t offer any information about when and whom established the connotation relationship"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is connoted by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K23i_is_connotation_of">http://w3id.org/vir#K23i_is_connotation_of</seealso>
    let K23i_is_connotation_of =
        Prefixed_Name(vir, "K23i_is_connotation_of") |> PrefixedName

    /// <summary>
    ///   <para>vir:K24_portray</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property put in relation an iconographical object with the portrayed character."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"portray"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K24_portray">http://w3id.org/vir#K24_portray</seealso>
    let K24_portray = Prefixed_Name(vir, "K24_portray") |> PrefixedName

    /// <summary>
    ///   <para>vir:K24i_is_portrayed_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property put in relation an iconographical object with the portrayed character."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is portrayed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K24i_is_portrayed_in">http://w3id.org/vir#K24i_is_portrayed_in</seealso>
    let K24i_is_portrayed_in =
        Prefixed_Name(vir, "K24i_is_portrayed_in") |> PrefixedName

    /// <summary>
    ///   <para>vir:K25_express</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property put in relation a symbolic object with a personification in a work of art"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"express"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K25_express">http://w3id.org/vir#K25_express</seealso>
    let K25_express = Prefixed_Name(vir, "K25_express") |> PrefixedName

    /// <summary>
    ///   <para>vir:K25i_is_abstraction_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property put in relation a symbolic object with a personification in a work of art."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is abstraction of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K25i_is_abstraction_of">http://w3id.org/vir#K25i_is_abstraction_of</seealso>
    let K25i_is_abstraction_of =
        Prefixed_Name(vir, "K25i_is_abstraction_of") |> PrefixedName

    /// <summary>
    ///   <para>vir:K26_has_source</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property associates an instance of IC16 Character with an instance of E39 Actor that the character is motivated by or is intended to represent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K26_has_source">http://w3id.org/vir#K26_has_source</seealso>
    let K26_has_source = Prefixed_Name(vir, "K26_has_source") |> PrefixedName
    /// <summary>
    ///   <para>vir:K26i_is_source_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property associates an instance of IC16 Character with an instance of E39 Actor that the character is motivated by or is intended to represent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is source of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K26i_is_source_of">http://w3id.org/vir#K26i_is_source_of</seealso>
    let K26i_is_source_of = Prefixed_Name(vir, "K26i_is_source_of") |> PrefixedName
    /// <summary>
    ///   <para>vir:K34_illustrate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property associate an information object to a iconographical representation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"illustrate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K34_illustrate">http://w3id.org/vir#K34_illustrate</seealso>
    let K34_illustrate = Prefixed_Name(vir, "K34_illustrate") |> PrefixedName

    /// <summary>
    ///   <para>vir:K34i_is_illustrated_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property associate an information object to a iconographical representation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is illustrated by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K34i_is_illustrated_by">http://w3id.org/vir#K34i_is_illustrated_by</seealso>
    let K34i_is_illustrated_by =
        Prefixed_Name(vir, "K34i_is_illustrated_by") |> PrefixedName

    /// <summary>
    ///   <para>vir:K4_1_prototypical_model</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/vir#K4_1_prototypical_model">http://w3id.org/vir#K4_1_prototypical_model</seealso>
    let K4_1_prototypical_model =
        Prefixed_Name(vir, "K4_1_prototypical_model") |> PrefixedName

    /// <summary>
    ///   <para>vir:K4_is_visual_prototype_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property documents the use of a specific prototypical example for an image. The nature of the relationships helps define a map of relationships between prototypical items used in the arts."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is visual prototype of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K4_is_visual_prototype_of">http://w3id.org/vir#K4_is_visual_prototype_of</seealso>
    let K4_is_visual_prototype_of =
        Prefixed_Name(vir, "K4_is_visual_prototype_of") |> PrefixedName

    /// <summary>
    ///   <para>vir:K4i_has_visual_prototype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property documents the use of a specific prototypical example for an image. The nature of the relationships helps define a map of relationships between prototypical items used in the arts."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has visual prototype"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K4i_has_visual_prototype">http://w3id.org/vir#K4i_has_visual_prototype</seealso>
    let K4i_has_visual_prototype =
        Prefixed_Name(vir, "K4i_has_visual_prototype") |> PrefixedName

    /// <summary>
    ///   <para>vir:K6_has_back</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property documents the presence of a Verso or a Recto, respectively in the back or in the front of an object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has back"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K6_has_back">http://w3id.org/vir#K6_has_back</seealso>
    let K6_has_back = Prefixed_Name(vir, "K6_has_back") |> PrefixedName
    /// <summary>
    ///   <para>vir:K6i_has_front</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property documents the presence of a Verso or a Recto, respectively in the back or in the front of an object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has front"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K6i_has_front">http://w3id.org/vir#K6i_has_front</seealso>
    let K6i_has_front = Prefixed_Name(vir, "K6i_has_front") |> PrefixedName
    /// <summary>
    ///   <para>vir:K7_is_recto_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property indicates the presence of a recto in the described object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is recto of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K7_is_recto_of">http://w3id.org/vir#K7_is_recto_of</seealso>
    let K7_is_recto_of = Prefixed_Name(vir, "K7_is_recto_of") |> PrefixedName
    /// <summary>
    ///   <para>vir:K7i_has_recto</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property indicates the presence of a recto in the described object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has recto"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K7i_has_recto">http://w3id.org/vir#K7i_has_recto</seealso>
    let K7i_has_recto = Prefixed_Name(vir, "K7i_has_recto") |> PrefixedName
    /// <summary>
    ///   <para>vir:K8_is_verso_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property indicates the presence of a verso in the described object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is verso of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K8_is_verso_of">http://w3id.org/vir#K8_is_verso_of</seealso>
    let K8_is_verso_of = Prefixed_Name(vir, "K8_is_verso_of") |> PrefixedName
    /// <summary>
    ///   <para>vir:K8i_has_verso</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property indicates the presence of a verso in the described object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has verso"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K8i_has_verso">http://w3id.org/vir#K8i_has_verso</seealso>
    let K8i_has_verso = Prefixed_Name(vir, "K8i_has_verso") |> PrefixedName

    /// <summary>
    ///   <para>vir:K9_Assigned_status_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property documents the assignment of status to a specific physical thing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Assigned status to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K9_Assigned_status_to">http://w3id.org/vir#K9_Assigned_status_to</seealso>
    let K9_Assigned_status_to =
        Prefixed_Name(vir, "K9_Assigned_status_to") |> PrefixedName

    /// <summary>
    ///   <para>vir:K9i_has_status_assigned_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property documents the assignment of status to a specific physical thing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has status assigned by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/vir#K9i_has_status_assigned_by">http://w3id.org/vir#K9i_has_status_assigned_by</seealso>
    let K9i_has_status_assigned_by =
        Prefixed_Name(vir, "K9i_has_status_assigned_by") |> PrefixedName

    /// <summary>
    ///   <para>vir:PCK4_is_visual_prototype_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Class</para>
    ///   <para>"n-ary construct to document the use of a specific prototypical example for an image. The nature of the relationships helps define a map of relationships between prototypical items used in the arts. To be used together with 'K4.1_prototypical_model'"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/vir#PCK4_is_visual_prototype_of">http://w3id.org/vir#PCK4_is_visual_prototype_of</seealso>
    let PCK4_is_visual_prototype_of =
        Prefixed_Name(vir, "PCK4_is_visual_prototype_of") |> PrefixedName
