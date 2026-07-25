namespace http.vocab.getty.edu.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gvp =
    let _namespace_iri = Namespace_Iri gvp |> NamespaceIRI

    /// <summary>
    ///   <para>gvp:ulan2651_publisher_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2651_publisher_of">http://vocab.getty.edu/ontology#ulan2651_publisher_of</seealso>
    let ulan2651_publisher_of =
        Prefixed_Name(gvp, "ulan2651_publisher_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2219_have_form</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2219_have_form">http://vocab.getty.edu/ontology#aat2219_have_form</seealso>
    let aat2219_have_form = Prefixed_Name(gvp, "aat2219_have_form") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2221_act_upon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2221_act_upon">http://vocab.getty.edu/ontology#aat2221_act_upon</seealso>
    let aat2221_act_upon = Prefixed_Name(gvp, "aat2221_act_upon") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2281_have_counterpart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2281_have_counterpart">http://vocab.getty.edu/ontology#aat2281_have_counterpart</seealso>
    let aat2281_have_counterpart =
        Prefixed_Name(gvp, "aat2281_have_counterpart") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2885_involves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2885_involves">http://vocab.getty.edu/ontology#aat2885_involves</seealso>
    let aat2885_involves = Prefixed_Name(gvp, "aat2885_involves") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2895_example_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2895_example_of">http://vocab.getty.edu/ontology#aat2895_example_of</seealso>
    let aat2895_example_of = Prefixed_Name(gvp, "aat2895_example_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:agentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Type of a ULAN PersonConcept or GroupConcept. Domain is ULAN concept, range is AAT concept</para>
    /// labels<para>agentType</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#agentType">http://vocab.getty.edu/ontology#agentType</seealso>
    let agentType = Prefixed_Name(gvp, "agentType") |> PrefixedName

    /// <summary>
    ///   <para>gvp:agentTypeNonPreferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A secondary type of a ULAN Person or Corporate body. Domain is ULAN concept, range is AAT concept</para>
    /// labels<para>agentTypeNonPreferred</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#agentTypeNonPreferred">http://vocab.getty.edu/ontology#agentTypeNonPreferred</seealso>
    let agentTypeNonPreferred =
        Prefixed_Name(gvp, "agentTypeNonPreferred") |> PrefixedName

    /// <summary>
    ///   <para>gvp:biographyNonPreferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Non-preferred biography of an ULAN agent. Domain is schema:Person/Organization, range is gvp:Biography</para>
    /// labels<para>biographyNonPreferred</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#biographyNonPreferred">http://vocab.getty.edu/ontology#biographyNonPreferred</seealso>
    let biographyNonPreferred =
        Prefixed_Name(gvp, "biographyNonPreferred") |> PrefixedName

    /// <summary>
    ///   <para>gvp:biographyPreferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Preferred biography of an ULAN agent. Domain is schema:Person/Organization, range is gvp:Biography. The biography fields are also directly available in the Person/Organization</para>
    /// labels<para>biographyPreferred</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#biographyPreferred">http://vocab.getty.edu/ontology#biographyPreferred</seealso>
    let biographyPreferred = Prefixed_Name(gvp, "biographyPreferred") |> PrefixedName
    /// <summary>
    ///   <para>gvp:broaderNonPreferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Auxiliary parents of a subject. Very often there are several non-preferred parents (poly-hierarchy). Can use to mark such parents with [N] in displays </para>
    /// labels<para>broaderNonPreferred</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#broaderNonPreferred">http://vocab.getty.edu/ontology#broaderNonPreferred</seealso>
    let broaderNonPreferred = Prefixed_Name(gvp, "broaderNonPreferred") |> PrefixedName
    /// <summary>
    ///   <para>gvp:broaderPartitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>BTP (Part/Whole, "part of") relation. We also infer iso-thes:broaderPartitive, which goes only between Concepts</para>
    /// labels<para>broaderPartitive</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#broaderPartitive">http://vocab.getty.edu/ontology#broaderPartitive</seealso>
    let broaderPartitive = Prefixed_Name(gvp, "broaderPartitive") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2821_based_on</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2821_based_on">http://vocab.getty.edu/ontology#aat2821_based_on</seealso>
    let aat2821_based_on = Prefixed_Name(gvp, "aat2821_based_on") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2824_has_parallels_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2824_has_parallels_with">http://vocab.getty.edu/ontology#aat2824_has_parallels_with</seealso>
    let aat2824_has_parallels_with =
        Prefixed_Name(gvp, "aat2824_has_parallels_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2826_used_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2826_used_with">http://vocab.getty.edu/ontology#aat2826_used_with</seealso>
    let aat2826_used_with = Prefixed_Name(gvp, "aat2826_used_with") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2216_require</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2216_require">http://vocab.getty.edu/ontology#aat2216_require</seealso>
    let aat2216_require = Prefixed_Name(gvp, "aat2216_require") |> PrefixedName

    /// <summary>
    ///   <para>gvp:contributorPreferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Contributor for which the term is Preferred. Range is foaf:Agent</para>
    /// labels<para>contributorPreferred</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#contributorPreferred">http://vocab.getty.edu/ontology#contributorPreferred</seealso>
    let contributorPreferred =
        Prefixed_Name(gvp, "contributorPreferred") |> PrefixedName

    /// <summary>
    ///   <para>gvp:estEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Estimated end date of term, relation, type assignment, event, biography</para>
    /// labels<para>estEnd</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#estEnd">http://vocab.getty.edu/ontology#estEnd</seealso>
    let estEnd = Prefixed_Name(gvp, "estEnd") |> PrefixedName
    /// <summary>
    ///   <para>gvp:estStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Estimated start date of term, relation, type assignment, event, biography</para>
    /// labels<para>estStart</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#estStart">http://vocab.getty.edu/ontology#estStart</seealso>
    let estStart = Prefixed_Name(gvp, "estStart") |> PrefixedName
    /// <summary>
    ///   <para>gvp:historicFlag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>historicFlag</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#historicFlag">http://vocab.getty.edu/ontology#historicFlag</seealso>
    let historicFlag = Prefixed_Name(gvp, "historicFlag") |> PrefixedName

    /// <summary>
    ///   <para>gvp:nationalityNonPreferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Non-preferred nationality/culture/race/ethnicity/religion/sexual orientation of an ULAN agent. Domain is schema:Person/Organization, range is AAT concept</para>
    /// labels<para>nationalityNonPreferred</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#nationalityNonPreferred">http://vocab.getty.edu/ontology#nationalityNonPreferred</seealso>
    let nationalityNonPreferred =
        Prefixed_Name(gvp, "nationalityNonPreferred") |> PrefixedName

    /// <summary>
    ///   <para>gvp:placeTypeNonPreferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A secondary type for a TGN Place. Domain is TGN concept, range is AAT concept</para>
    /// labels<para>placeTypeNonPreferred</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#placeTypeNonPreferred">http://vocab.getty.edu/ontology#placeTypeNonPreferred</seealso>
    let placeTypeNonPreferred =
        Prefixed_Name(gvp, "placeTypeNonPreferred") |> PrefixedName

    /// <summary>
    ///   <para>gvp:prefLabelLoC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Term preferred by Library of Congress, thus used for cataloging according to AACR2. Applicable to AAT and ULAN. Used with skosxl:prefLabel</para>
    /// labels<para>prefLabelLoC</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#prefLabelLoC">http://vocab.getty.edu/ontology#prefLabelLoC</seealso>
    let prefLabelLoC = Prefixed_Name(gvp, "prefLabelLoC") |> PrefixedName
    /// <summary>
    ///   <para>gvp:qualifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Clarifies and disambiguates terms with the same spelling but different meaning.
    /// Appended in parentheses to gvp:term, forming skosxsl:literalForm.
    /// Every qualifier is in the same language as the term</para>
    /// labels<para>qualifier</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#qualifier">http://vocab.getty.edu/ontology#qualifier</seealso>
    let qualifier = Prefixed_Name(gvp, "qualifier") |> PrefixedName
    /// <summary>
    ///   <para>gvp:sourceNonPreferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Source for which the term is Non-preferred. Range is bibo:Document or bibo:DocumentPart</para>
    /// labels<para>sourceNonPreferred</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#sourceNonPreferred">http://vocab.getty.edu/ontology#sourceNonPreferred</seealso>
    let sourceNonPreferred = Prefixed_Name(gvp, "sourceNonPreferred") |> PrefixedName
    /// <summary>
    ///   <para>gvp:term</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Term (label), used as the basic (prefix) part of skosxsl:literalForm</para>
    /// labels<para>term</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#term">http://vocab.getty.edu/ontology#term</seealso>
    let term = Prefixed_Name(gvp, "term") |> PrefixedName
    /// <summary>
    ///   <para>gvp:termDisplay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>termDisplay</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#termDisplay">http://vocab.getty.edu/ontology#termDisplay</seealso>
    let termDisplay = Prefixed_Name(gvp, "termDisplay") |> PrefixedName
    /// <summary>
    ///   <para>gvp:termFlag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>termFlag</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#termFlag">http://vocab.getty.edu/ontology#termFlag</seealso>
    let termFlag = Prefixed_Name(gvp, "termFlag") |> PrefixedName
    /// <summary>
    ///   <para>gvp:termKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>termKind</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#termKind">http://vocab.getty.edu/ontology#termKind</seealso>
    let termKind = Prefixed_Name(gvp, "termKind") |> PrefixedName
    /// <summary>
    ///   <para>gvp:termPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>termPOS</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#termPOS">http://vocab.getty.edu/ontology#termPOS</seealso>
    let termPOS = Prefixed_Name(gvp, "termPOS") |> PrefixedName
    /// <summary>
    ///   <para>gvp:tgn3000_related_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#tgn3000_related_to">http://vocab.getty.edu/ontology#tgn3000_related_to</seealso>
    let tgn3000_related_to = Prefixed_Name(gvp, "tgn3000_related_to") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan2828_student_at</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2828_student_at">http://vocab.getty.edu/ontology#ulan2828_student_at</seealso>
    let ulan2828_student_at = Prefixed_Name(gvp, "ulan2828_student_at") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2829_student_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2829_student_was">http://vocab.getty.edu/ontology#ulan2829_student_was</seealso>
    let ulan2829_student_was =
        Prefixed_Name(gvp, "ulan2829_student_was") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2840_performer_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2840_performer_with">http://vocab.getty.edu/ontology#ulan2840_performer_with</seealso>
    let ulan2840_performer_with =
        Prefixed_Name(gvp, "ulan2840_performer_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2215_required_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2215_required_for">http://vocab.getty.edu/ontology#aat2215_required_for</seealso>
    let aat2215_required_for =
        Prefixed_Name(gvp, "aat2215_required_for") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2218_used-function_as</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2218_used-function_as">http://vocab.getty.edu/ontology#aat2218_used-function_as</seealso>
    let aat2218_used_function_as =
        Prefixed_Name(gvp, "aat2218_used-function_as") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2222_are_acted_upon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2222_are_acted_upon">http://vocab.getty.edu/ontology#aat2222_are_acted_upon</seealso>
    let aat2222_are_acted_upon =
        Prefixed_Name(gvp, "aat2222_are_acted_upon") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2285_practiced-studied_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2285_practiced-studied_by">http://vocab.getty.edu/ontology#aat2285_practiced-studied_by</seealso>
    let aat2285_practiced_studied_by =
        Prefixed_Name(gvp, "aat2285_practiced-studied_by") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2291_locus-setting_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2291_locus-setting_for">http://vocab.getty.edu/ontology#aat2291_locus-setting_for</seealso>
    let aat2291_locus_setting_for =
        Prefixed_Name(gvp, "aat2291_locus-setting_for") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2892_example_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2892_example_of">http://vocab.getty.edu/ontology#aat2892_example_of</seealso>
    let aat2892_example_of = Prefixed_Name(gvp, "aat2892_example_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2900_miscellaneous_relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2900_miscellaneous_relationship">http://vocab.getty.edu/ontology#aat2900_miscellaneous_relationship</seealso>
    let aat2900_miscellaneous_relationship =
        Prefixed_Name(gvp, "aat2900_miscellaneous_relationship") |> PrefixedName

    /// <summary>
    ///   <para>gvp:agentTypePreferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>agentTypePreferred</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#agentTypePreferred">http://vocab.getty.edu/ontology#agentTypePreferred</seealso>
    let agentTypePreferred = Prefixed_Name(gvp, "agentTypePreferred") |> PrefixedName
    /// <summary>
    ///   <para>gvp:biography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Biography of an ULAN agent. Domain is schema:Person/Organization, range is gvp:Biography. The preferred biography fields are also directly available in the Person/Organization</para>
    /// labels<para>biography</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#biography">http://vocab.getty.edu/ontology#biography</seealso>
    let biography = Prefixed_Name(gvp, "biography") |> PrefixedName
    /// <summary>
    ///   <para>gvp:broaderGeneric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>BTG (Genus/Species, "is a") relation. We also infer iso-thes:broaderGeneric, which goes only between Concepts</para>
    /// labels<para>broaderGeneric</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#broaderGeneric">http://vocab.getty.edu/ontology#broaderGeneric</seealso>
    let broaderGeneric = Prefixed_Name(gvp, "broaderGeneric") |> PrefixedName
    /// <summary>
    ///   <para>gvp:broaderInstantial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>BTI (Kind/Instance, "example of") relation. We also infer iso-thes:broaderInstantial, which goes only between Concepts</para>
    /// labels<para>broaderInstantial</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#broaderInstantial">http://vocab.getty.edu/ontology#broaderInstantial</seealso>
    let broaderInstantial = Prefixed_Name(gvp, "broaderInstantial") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1590_possibly_related_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1590_possibly_related_to">http://vocab.getty.edu/ontology#ulan1590_possibly_related_to</seealso>
    let ulan1590_possibly_related_to =
        Prefixed_Name(gvp, "ulan1590_possibly_related_to") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2550_friend_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2550_friend_of">http://vocab.getty.edu/ontology#ulan2550_friend_of</seealso>
    let ulan2550_friend_of = Prefixed_Name(gvp, "ulan2550_friend_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan2572_founder_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2572_founder_of">http://vocab.getty.edu/ontology#ulan2572_founder_of</seealso>
    let ulan2572_founder_of = Prefixed_Name(gvp, "ulan2572_founder_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan2573_founded_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2573_founded_by">http://vocab.getty.edu/ontology#ulan2573_founded_by</seealso>
    let ulan2573_founded_by = Prefixed_Name(gvp, "ulan2573_founded_by") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2575_directed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2575_directed_by">http://vocab.getty.edu/ontology#ulan2575_directed_by</seealso>
    let ulan2575_directed_by =
        Prefixed_Name(gvp, "ulan2575_directed_by") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2577_patron_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2577_patron_was">http://vocab.getty.edu/ontology#ulan2577_patron_was</seealso>
    let ulan2577_patron_was = Prefixed_Name(gvp, "ulan2577_patron_was") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan2578_trustee_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2578_trustee_of">http://vocab.getty.edu/ontology#ulan2578_trustee_of</seealso>
    let ulan2578_trustee_of = Prefixed_Name(gvp, "ulan2578_trustee_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2579_trustee_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2579_trustee_was">http://vocab.getty.edu/ontology#ulan2579_trustee_was</seealso>
    let ulan2579_trustee_was =
        Prefixed_Name(gvp, "ulan2579_trustee_was") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2581_administrator_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2581_administrator_of">http://vocab.getty.edu/ontology#ulan2581_administrator_of</seealso>
    let ulan2581_administrator_of =
        Prefixed_Name(gvp, "ulan2581_administrator_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2582_administered_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2582_administered_by">http://vocab.getty.edu/ontology#ulan2582_administered_by</seealso>
    let ulan2582_administered_by =
        Prefixed_Name(gvp, "ulan2582_administered_by") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2650_publisher_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2650_publisher_was">http://vocab.getty.edu/ontology#ulan2650_publisher_was</seealso>
    let ulan2650_publisher_was =
        Prefixed_Name(gvp, "ulan2650_publisher_was") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2674_professor_at</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2674_professor_at">http://vocab.getty.edu/ontology#ulan2674_professor_at</seealso>
    let ulan2674_professor_at =
        Prefixed_Name(gvp, "ulan2674_professor_at") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2675_professor_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2675_professor_was">http://vocab.getty.edu/ontology#ulan2675_professor_was</seealso>
    let ulan2675_professor_was =
        Prefixed_Name(gvp, "ulan2675_professor_was") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2676_teacher_at</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2676_teacher_at">http://vocab.getty.edu/ontology#ulan2676_teacher_at</seealso>
    let ulan2676_teacher_at = Prefixed_Name(gvp, "ulan2676_teacher_at") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2677_teacher_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2677_teacher_was">http://vocab.getty.edu/ontology#ulan2677_teacher_was</seealso>
    let ulan2677_teacher_was =
        Prefixed_Name(gvp, "ulan2677_teacher_was") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2692_president_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2692_president_of">http://vocab.getty.edu/ontology#ulan2692_president_of</seealso>
    let ulan2692_president_of =
        Prefixed_Name(gvp, "ulan2692_president_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2696_leader_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2696_leader_of">http://vocab.getty.edu/ontology#ulan2696_leader_of</seealso>
    let ulan2696_leader_of = Prefixed_Name(gvp, "ulan2696_leader_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan2697_leader_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2697_leader_was">http://vocab.getty.edu/ontology#ulan2697_leader_was</seealso>
    let ulan2697_leader_was = Prefixed_Name(gvp, "ulan2697_leader_was") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2294_locus-setting_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2294_locus-setting_for">http://vocab.getty.edu/ontology#aat2294_locus-setting_for</seealso>
    let aat2294_locus_setting_for =
        Prefixed_Name(gvp, "aat2294_locus-setting_for") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2295_located_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2295_located_in">http://vocab.getty.edu/ontology#aat2295_located_in</seealso>
    let aat2295_located_in = Prefixed_Name(gvp, "aat2295_located_in") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2312_perform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2312_perform">http://vocab.getty.edu/ontology#aat2312_perform</seealso>
    let aat2312_perform = Prefixed_Name(gvp, "aat2312_perform") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2316_use</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2316_use">http://vocab.getty.edu/ontology#aat2316_use</seealso>
    let aat2316_use = Prefixed_Name(gvp, "aat2316_use") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2319_involves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2319_involves">http://vocab.getty.edu/ontology#aat2319_involves</seealso>
    let aat2319_involves = Prefixed_Name(gvp, "aat2319_involves") |> PrefixedName

    /// <summary>
    ///   <para>gvp:contributorAlternatePreferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Contributor for which the term is Alternate Preferred. Range is foaf:Agent</para>
    /// labels<para>contributorAlternatePreferred</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#contributorAlternatePreferred">http://vocab.getty.edu/ontology#contributorAlternatePreferred</seealso>
    let contributorAlternatePreferred =
        Prefixed_Name(gvp, "contributorAlternatePreferred") |> PrefixedName

    /// <summary>
    ///   <para>gvp:contributorNonPreferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Contributor for which the term is Non-preferred. Range is foaf:Agent</para>
    /// labels<para>contributorNonPreferred</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#contributorNonPreferred">http://vocab.getty.edu/ontology#contributorNonPreferred</seealso>
    let contributorNonPreferred =
        Prefixed_Name(gvp, "contributorNonPreferred") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2286_practice-study</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2286_practice-study">http://vocab.getty.edu/ontology#aat2286_practice-study</seealso>
    let aat2286_practice_study =
        Prefixed_Name(gvp, "aat2286_practice-study") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2292_work-live_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2292_work-live_in">http://vocab.getty.edu/ontology#aat2292_work-live_in</seealso>
    let aat2292_work_live_in =
        Prefixed_Name(gvp, "aat2292_work-live_in") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2311_performed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2311_performed_by">http://vocab.getty.edu/ontology#aat2311_performed_by</seealso>
    let aat2311_performed_by =
        Prefixed_Name(gvp, "aat2311_performed_by") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2315_used_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2315_used_by">http://vocab.getty.edu/ontology#aat2315_used_by</seealso>
    let aat2315_used_by = Prefixed_Name(gvp, "aat2315_used_by") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2318_involved_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2318_involved_in">http://vocab.getty.edu/ontology#aat2318_involved_in</seealso>
    let aat2318_involved_in = Prefixed_Name(gvp, "aat2318_involved_in") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2321_used_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2321_used_by">http://vocab.getty.edu/ontology#aat2321_used_by</seealso>
    let aat2321_used_by = Prefixed_Name(gvp, "aat2321_used_by") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2322_use</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2322_use">http://vocab.getty.edu/ontology#aat2322_use</seealso>
    let aat2322_use = Prefixed_Name(gvp, "aat2322_use") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2325_created_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2325_created_by">http://vocab.getty.edu/ontology#aat2325_created_by</seealso>
    let aat2325_created_by = Prefixed_Name(gvp, "aat2325_created_by") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2328_involved_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2328_involved_with">http://vocab.getty.edu/ontology#aat2328_involved_with</seealso>
    let aat2328_involved_with =
        Prefixed_Name(gvp, "aat2328_involved_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:displayOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Display order of subject or term amongst its siblings.
    /// If all are 1 then use alphabetical. Domain is gvp:Subject or skosxl:Label</para>
    /// labels<para>displayOrder</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#displayOrder">http://vocab.getty.edu/ontology#displayOrder</seealso>
    let displayOrder = Prefixed_Name(gvp, "displayOrder") |> PrefixedName
    /// <summary>
    ///   <para>gvp:eventNonPreferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Non-preferred life event of an ULAN agent. Domain is schema:Person/Organization, range is bio:Event</para>
    /// labels<para>eventNonPreferred</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#eventNonPreferred">http://vocab.getty.edu/ontology#eventNonPreferred</seealso>
    let eventNonPreferred = Prefixed_Name(gvp, "eventNonPreferred") |> PrefixedName
    /// <summary>
    ///   <para>gvp:eventPreferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Preferred life event of an ULAN agent. Domain is schema:Person/Organization, range is bio:Event</para>
    /// labels<para>eventPreferred</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#eventPreferred">http://vocab.getty.edu/ontology#eventPreferred</seealso>
    let eventPreferred = Prefixed_Name(gvp, "eventPreferred") |> PrefixedName

    /// <summary>
    ///   <para>gvp:nationalityPreferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Preferred nationality/culture/race/ethnicity/religion/sexual orientation of an ULAN agent. Domain is schema:Person/Organization, range is AAT concept</para>
    /// labels<para>nationalityPreferred</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#nationalityPreferred">http://vocab.getty.edu/ontology#nationalityPreferred</seealso>
    let nationalityPreferred =
        Prefixed_Name(gvp, "nationalityPreferred") |> PrefixedName

    /// <summary>
    ///   <para>gvp:parentString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Preferred labels of *all* of the subject's preferred ancestors, listed bottom up. Useful to show the subject's full context</para>
    /// labels<para>parentString</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#parentString">http://vocab.getty.edu/ontology#parentString</seealso>
    let parentString = Prefixed_Name(gvp, "parentString") |> PrefixedName
    /// <summary>
    ///   <para>gvp:parentStringAbbrev</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Preferred labels of *some* of the subject's preferred ancestors, listed bottom up. Useful to show the subject's context</para>
    /// labels<para>parentStringAbbrev</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#parentStringAbbrev">http://vocab.getty.edu/ontology#parentStringAbbrev</seealso>
    let parentStringAbbrev = Prefixed_Name(gvp, "parentStringAbbrev") |> PrefixedName
    /// <summary>
    ///   <para>gvp:placeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Type for a TGN place. Domain is TGN concept (AdminPlaceConcept or PhysPlaceConcept), range is AAT Concept</para>
    /// labels<para>placeType</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#placeType">http://vocab.getty.edu/ontology#placeType</seealso>
    let placeType = Prefixed_Name(gvp, "placeType") |> PrefixedName
    /// <summary>
    ///   <para>gvp:placeTypePreferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The primary type of a TGN Place. Domain is TGN concept, range is AAT concept</para>
    /// labels<para>placeTypePreferred</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#placeTypePreferred">http://vocab.getty.edu/ontology#placeTypePreferred</seealso>
    let placeTypePreferred = Prefixed_Name(gvp, "placeTypePreferred") |> PrefixedName
    /// <summary>
    ///   <para>gvp:prefLabelGVP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Term preferred by the Getty Vocabulary Program. The language is usually English. Applicable to AAT, ULAN, TGN. Used with skosxl:prefLabel</para>
    /// labels<para>prefLabelGVP</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#prefLabelGVP">http://vocab.getty.edu/ontology#prefLabelGVP</seealso>
    let prefLabelGVP = Prefixed_Name(gvp, "prefLabelGVP") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan2778_owner_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2778_owner_of">http://vocab.getty.edu/ontology#ulan2778_owner_of</seealso>
    let ulan2778_owner_of = Prefixed_Name(gvp, "ulan2778_owner_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan2779_owned_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2779_owned_by">http://vocab.getty.edu/ontology#ulan2779_owned_by</seealso>
    let ulan2779_owned_by = Prefixed_Name(gvp, "ulan2779_owned_by") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2781_dedicatee_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2781_dedicatee_of">http://vocab.getty.edu/ontology#ulan2781_dedicatee_of</seealso>
    let ulan2781_dedicatee_of =
        Prefixed_Name(gvp, "ulan2781_dedicatee_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2782_dedicated_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2782_dedicated_to">http://vocab.getty.edu/ontology#ulan2782_dedicated_to</seealso>
    let ulan2782_dedicated_to =
        Prefixed_Name(gvp, "ulan2782_dedicated_to") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2794_representative_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2794_representative_of">http://vocab.getty.edu/ontology#ulan2794_representative_of</seealso>
    let ulan2794_representative_of =
        Prefixed_Name(gvp, "ulan2794_representative_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2795_representative_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2795_representative_was">http://vocab.getty.edu/ontology#ulan2795_representative_was</seealso>
    let ulan2795_representative_was =
        Prefixed_Name(gvp, "ulan2795_representative_was") |> PrefixedName

    /// <summary>
    ///   <para>gvp:Subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Node in a GVP vocabulary hierarchy.
    /// May be Facet, GuideTerm, Hierarchy, Concept, AdminPlaceConcept, PhysPlaceConcept, PhysAdminPlaceConcept, or ObsoleteSubject.
    /// Implemented as skos:Concept or iso:ThesaurusArray and skos:Collection</para>
    /// labels<para>Subject</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#Subject">http://vocab.getty.edu/ontology#Subject</seealso>
    let Subject = Prefixed_Name(gvp, "Subject") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2335_associated_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2335_associated_with">http://vocab.getty.edu/ontology#aat2335_associated_with</seealso>
    let aat2335_associated_with =
        Prefixed_Name(gvp, "aat2335_associated_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2397_focus_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2397_focus_of">http://vocab.getty.edu/ontology#aat2397_focus_of</seealso>
    let aat2397_focus_of = Prefixed_Name(gvp, "aat2397_focus_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2408_locus-setting_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2408_locus-setting_for">http://vocab.getty.edu/ontology#aat2408_locus-setting_for</seealso>
    let aat2408_locus_setting_for =
        Prefixed_Name(gvp, "aat2408_locus-setting_for") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2412_involves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2412_involves">http://vocab.getty.edu/ontology#aat2412_involves</seealso>
    let aat2412_involves = Prefixed_Name(gvp, "aat2412_involves") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2416_requires</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2416_requires">http://vocab.getty.edu/ontology#aat2416_requires</seealso>
    let aat2416_requires = Prefixed_Name(gvp, "aat2416_requires") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2419_used_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2419_used_for">http://vocab.getty.edu/ontology#aat2419_used_for</seealso>
    let aat2419_used_for = Prefixed_Name(gvp, "aat2419_used_for") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2421_locus-setting_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2421_locus-setting_for">http://vocab.getty.edu/ontology#aat2421_locus-setting_for</seealso>
    let aat2421_locus_setting_for =
        Prefixed_Name(gvp, "aat2421_locus-setting_for") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2424_produced_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2424_produced_by">http://vocab.getty.edu/ontology#aat2424_produced_by</seealso>
    let aat2424_produced_by = Prefixed_Name(gvp, "aat2424_produced_by") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2427_produced_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2427_produced_by">http://vocab.getty.edu/ontology#aat2427_produced_by</seealso>
    let aat2427_produced_by = Prefixed_Name(gvp, "aat2427_produced_by") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2431_required_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2431_required_for">http://vocab.getty.edu/ontology#aat2431_required_for</seealso>
    let aat2431_required_for =
        Prefixed_Name(gvp, "aat2431_required_for") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2432_requires</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2432_requires">http://vocab.getty.edu/ontology#aat2432_requires</seealso>
    let aat2432_requires = Prefixed_Name(gvp, "aat2432_requires") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2434_contextualized_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2434_contextualized_in">http://vocab.getty.edu/ontology#aat2434_contextualized_in</seealso>
    let aat2434_contextualized_in =
        Prefixed_Name(gvp, "aat2434_contextualized_in") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2435_context_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2435_context_for">http://vocab.getty.edu/ontology#aat2435_context_for</seealso>
    let aat2435_context_for = Prefixed_Name(gvp, "aat2435_context_for") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2502_material_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2502_material_for">http://vocab.getty.edu/ontology#aat2502_material_for</seealso>
    let aat2502_material_for =
        Prefixed_Name(gvp, "aat2502_material_for") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2574_director_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2574_director_of">http://vocab.getty.edu/ontology#ulan2574_director_of</seealso>
    let ulan2574_director_of =
        Prefixed_Name(gvp, "ulan2574_director_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2576_patron_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2576_patron_of">http://vocab.getty.edu/ontology#ulan2576_patron_of</seealso>
    let ulan2576_patron_of = Prefixed_Name(gvp, "ulan2576_patron_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:AdminPlaceConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Place defined by administrative boundaries and conditions, including inhabited places, nations, and empires. Used in TGN only</para>
    /// labels<para>AdminPlaceConcept</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#AdminPlaceConcept">http://vocab.getty.edu/ontology#AdminPlaceConcept</seealso>
    let AdminPlaceConcept = Prefixed_Name(gvp, "AdminPlaceConcept") |> PrefixedName
    /// <summary>
    ///   <para>gvp:GroupConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Two or more people who generally worked together to collectively create art. Not necessarily legally incorporated. A family of artists may be considered a "corporate body". Corresponds to crm:E74_Group, not its subclass crm:E40_Legal_Body</para>
    /// labels<para>GroupConcept</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#GroupConcept">http://vocab.getty.edu/ontology#GroupConcept</seealso>
    let GroupConcept = Prefixed_Name(gvp, "GroupConcept") |> PrefixedName
    /// <summary>
    ///   <para>gvp:GuideTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Guide Term: place holder to create a level in the hierarchy. Used in AAT and ULAN. Not used for indexing or cataloguing.</para>
    /// labels<para>GuideTerm</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#GuideTerm">http://vocab.getty.edu/ontology#GuideTerm</seealso>
    let GuideTerm = Prefixed_Name(gvp, "GuideTerm") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2398_focuses_on</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2398_focuses_on">http://vocab.getty.edu/ontology#aat2398_focuses_on</seealso>
    let aat2398_focuses_on = Prefixed_Name(gvp, "aat2398_focuses_on") |> PrefixedName

    /// <summary>
    ///   <para>gvp:sourceAlternatePreferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Source for which the term is Alternate Preferred. Range is bibo:Document or bibo:DocumentPart</para>
    /// labels<para>sourceAlternatePreferred</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#sourceAlternatePreferred">http://vocab.getty.edu/ontology#sourceAlternatePreferred</seealso>
    let sourceAlternatePreferred =
        Prefixed_Name(gvp, "sourceAlternatePreferred") |> PrefixedName

    /// <summary>
    ///   <para>gvp:sourcePreferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Source for which the term is Preferred. Range is bibo:Document or bibo:DocumentPart</para>
    /// labels<para>sourcePreferred</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#sourcePreferred">http://vocab.getty.edu/ontology#sourcePreferred</seealso>
    let sourcePreferred = Prefixed_Name(gvp, "sourcePreferred") |> PrefixedName
    /// <summary>
    ///   <para>gvp:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Proper concept. Used in AAT only; TGN &amp; ULAN have their own, e.g. gvp:PhysPlaceConcept &amp; gvp:PersonConcept. Used for indexing and cataloguing</para>
    /// labels<para>Concept</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#Concept">http://vocab.getty.edu/ontology#Concept</seealso>
    let Concept = Prefixed_Name(gvp, "Concept") |> PrefixedName
    /// <summary>
    ///   <para>gvp:Hierarchy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Top of a hierarchy. Used in AAT only. Not used for indexing or cataloguing</para>
    /// labels<para>Hierarchy</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#Hierarchy">http://vocab.getty.edu/ontology#Hierarchy</seealso>
    let Hierarchy = Prefixed_Name(gvp, "Hierarchy") |> PrefixedName
    /// <summary>
    ///   <para>gvp:broaderNonConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Chain of gvp:broader from Concept to GuideTerms, without intervening Concept</para>
    /// labels<para>broaderNonConcept</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#broaderNonConcept">http://vocab.getty.edu/ontology#broaderNonConcept</seealso>
    let broaderNonConcept = Prefixed_Name(gvp, "broaderNonConcept") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2415_required_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2415_required_for">http://vocab.getty.edu/ontology#aat2415_required_for</seealso>
    let aat2415_required_for =
        Prefixed_Name(gvp, "aat2415_required_for") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2418_uses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2418_uses">http://vocab.getty.edu/ontology#aat2418_uses</seealso>
    let aat2418_uses = Prefixed_Name(gvp, "aat2418_uses") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2422_takes_place_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2422_takes_place_in">http://vocab.getty.edu/ontology#aat2422_takes_place_in</seealso>
    let aat2422_takes_place_in =
        Prefixed_Name(gvp, "aat2422_takes_place_in") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2425_produces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2425_produces">http://vocab.getty.edu/ontology#aat2425_produces</seealso>
    let aat2425_produces = Prefixed_Name(gvp, "aat2425_produces") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2428_produces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2428_produces">http://vocab.getty.edu/ontology#aat2428_produces</seealso>
    let aat2428_produces = Prefixed_Name(gvp, "aat2428_produces") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2841_performer_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2841_performer_was">http://vocab.getty.edu/ontology#ulan2841_performer_was</seealso>
    let ulan2841_performer_was =
        Prefixed_Name(gvp, "ulan2841_performer_was") |> PrefixedName

    /// <summary>
    ///   <para>gvp:Biography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Biography of a ULAN agent (schema:Person|Organization). Depending on the agent, has these fields:
    /// - schema:description: one-line-biography
    /// - gvp:estStart
    /// - schema:birthPlace | foundationLocation, pointing to TGN
    /// - gvp:estEnd
    /// - schema:deathPlace | dissolutionLocation, pointing to TGN
    /// - schema:gender, pointing to AAT (male, female, other)
    /// - dct:contributor
    /// The fields of the preferred biogrpahy are also available in the agent.</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#Biography">http://vocab.getty.edu/ontology#Biography</seealso>
    let Biography = Prefixed_Name(gvp, "Biography") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2326_create</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2326_create">http://vocab.getty.edu/ontology#aat2326_create</seealso>
    let aat2326_create = Prefixed_Name(gvp, "aat2326_create") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2329_involves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2329_involves">http://vocab.getty.edu/ontology#aat2329_involves</seealso>
    let aat2329_involves = Prefixed_Name(gvp, "aat2329_involves") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2332_affiliated_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2332_affiliated_with">http://vocab.getty.edu/ontology#aat2332_affiliated_with</seealso>
    let aat2332_affiliated_with =
        Prefixed_Name(gvp, "aat2332_affiliated_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2333_have_affiliates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2333_have_affiliates">http://vocab.getty.edu/ontology#aat2333_have_affiliates</seealso>
    let aat2333_have_affiliates =
        Prefixed_Name(gvp, "aat2333_have_affiliates") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2336_has_associates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2336_has_associates">http://vocab.getty.edu/ontology#aat2336_has_associates</seealso>
    let aat2336_has_associates =
        Prefixed_Name(gvp, "aat2336_has_associates") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan2693_president_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan2693_president_was">http://vocab.getty.edu/ontology#ulan2693_president_was</seealso>
    let ulan2693_president_was =
        Prefixed_Name(gvp, "ulan2693_president_was") |> PrefixedName

    /// <summary>
    ///   <para>gvp:Facet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>One of the major divisions of a vocabulary</para>
    /// labels<para>Facet</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#Facet">http://vocab.getty.edu/ontology#Facet</seealso>
    let Facet = Prefixed_Name(gvp, "Facet") |> PrefixedName

    /// <summary>
    ///   <para>gvp:Infer_broaderNonConcept_PropChainType2</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protontop#PropChainType2</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#Infer_broaderNonConcept_PropChainType2">http://vocab.getty.edu/ontology#Infer_broaderNonConcept_PropChainType2</seealso>
    let Infer_broaderNonConcept_PropChainType2 =
        Prefixed_Name(gvp, "Infer_broaderNonConcept_PropChainType2") |> PrefixedName

    /// <summary>
    ///   <para>gvp:broader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Parents of a subject. Each broader is also Preferred|NonPreferred and Partitive|Instantial|Generic</para>
    /// labels<para>broader</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#broader">http://vocab.getty.edu/ontology#broader</seealso>
    let broader = Prefixed_Name(gvp, "broader") |> PrefixedName

    /// <summary>
    ///   <para>gvp:Infer_broaderNonConcept_TypeRestr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>onto:proton/protontop#TypeRestr</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#Infer_broaderNonConcept_TypeRestr">http://vocab.getty.edu/ontology#Infer_broaderNonConcept_TypeRestr</seealso>
    let Infer_broaderNonConcept_TypeRestr =
        Prefixed_Name(gvp, "Infer_broaderNonConcept_TypeRestr") |> PrefixedName

    /// <summary>
    ///   <para>gvp:broaderPreferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Main parent of a subject. Needed to display the hierarchy</para>
    /// labels<para>broaderPreferred</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#broaderPreferred">http://vocab.getty.edu/ontology#broaderPreferred</seealso>
    let broaderPreferred = Prefixed_Name(gvp, "broaderPreferred") |> PrefixedName

    /// <summary>
    ///   <para>gvp:broaderPartitiveExtended</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Ancestors (Partitive). Meaningful closure of gvp:broaderPartitive. Infers iso:broaderPartitive for pairs of directly related skos:Concepts</para>
    /// labels<para>broaderPartitiveExtended</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#broaderPartitiveExtended">http://vocab.getty.edu/ontology#broaderPartitiveExtended</seealso>
    let broaderPartitiveExtended =
        Prefixed_Name(gvp, "broaderPartitiveExtended") |> PrefixedName

    /// <summary>
    ///   <para>gvp:Infer_skosBroader_PropChainType2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>onto:proton/protontop#PropChainType2</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#Infer_skosBroader_PropChainType2">http://vocab.getty.edu/ontology#Infer_skosBroader_PropChainType2</seealso>
    let Infer_skosBroader_PropChainType2 =
        Prefixed_Name(gvp, "Infer_skosBroader_PropChainType2") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2563_located_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2563_located_in">http://vocab.getty.edu/ontology#aat2563_located_in</seealso>
    let aat2563_located_in = Prefixed_Name(gvp, "aat2563_located_in") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2602_possess-exist_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2602_possess-exist_in">http://vocab.getty.edu/ontology#aat2602_possess-exist_in</seealso>
    let aat2602_possess_exist_in =
        Prefixed_Name(gvp, "aat2602_possess-exist_in") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2409_takes_place_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2409_takes_place_in">http://vocab.getty.edu/ontology#aat2409_takes_place_in</seealso>
    let aat2409_takes_place_in =
        Prefixed_Name(gvp, "aat2409_takes_place_in") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2411_involved_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2411_involved_in">http://vocab.getty.edu/ontology#aat2411_involved_in</seealso>
    let aat2411_involved_in = Prefixed_Name(gvp, "aat2411_involved_in") |> PrefixedName
    /// <summary>
    ///   <para>gvp:termType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>termType</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#termType">http://vocab.getty.edu/ontology#termType</seealso>
    let termType = Prefixed_Name(gvp, "termType") |> PrefixedName

    /// <summary>
    ///   <para>gvp:tgn3005_possibly_identified_as</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#tgn3005_possibly_identified_as">http://vocab.getty.edu/ontology#tgn3005_possibly_identified_as</seealso>
    let tgn3005_possibly_identified_as =
        Prefixed_Name(gvp, "tgn3005_possibly_identified_as") |> PrefixedName

    /// <summary>
    ///   <para>gvp:tgn3102_coextensive_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#tgn3102_coextensive_with">http://vocab.getty.edu/ontology#tgn3102_coextensive_with</seealso>
    let tgn3102_coextensive_with =
        Prefixed_Name(gvp, "tgn3102_coextensive_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:tgn3201_capital_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#tgn3201_capital_of">http://vocab.getty.edu/ontology#tgn3201_capital_of</seealso>
    let tgn3201_capital_of = Prefixed_Name(gvp, "tgn3201_capital_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:tgn3202_capital_is</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#tgn3202_capital_is">http://vocab.getty.edu/ontology#tgn3202_capital_is</seealso>
    let tgn3202_capital_is = Prefixed_Name(gvp, "tgn3202_capital_is") |> PrefixedName
    /// <summary>
    ///   <para>gvp:tgn3317_member_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#tgn3317_member_of">http://vocab.getty.edu/ontology#tgn3317_member_of</seealso>
    let tgn3317_member_of = Prefixed_Name(gvp, "tgn3317_member_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:tgn3401_moved_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#tgn3401_moved_from">http://vocab.getty.edu/ontology#tgn3401_moved_from</seealso>
    let tgn3401_moved_from = Prefixed_Name(gvp, "tgn3401_moved_from") |> PrefixedName

    /// <summary>
    ///   <para>gvp:Infer_broaderPreferredExtended</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>onto:proton/protontop#PropChainRestr</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#Infer_broaderPreferredExtended">http://vocab.getty.edu/ontology#Infer_broaderPreferredExtended</seealso>
    let Infer_broaderPreferredExtended =
        Prefixed_Name(gvp, "Infer_broaderPreferredExtended") |> PrefixedName

    /// <summary>
    ///   <para>gvp:broaderGenericExtended</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Ancestors (Generic). Meaningful closure of gvp:broaderGeneric. Infers iso:broaderGeneric for pairs of directly related skos:Concepts</para>
    /// labels<para>broaderGenericExtended</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#broaderGenericExtended">http://vocab.getty.edu/ontology#broaderGenericExtended</seealso>
    let broaderGenericExtended =
        Prefixed_Name(gvp, "broaderGenericExtended") |> PrefixedName

    /// <summary>
    ///   <para>gvp:broaderInstantialExtended</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>broaderInstantialExtended</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#broaderInstantialExtended">http://vocab.getty.edu/ontology#broaderInstantialExtended</seealso>
    let broaderInstantialExtended =
        Prefixed_Name(gvp, "broaderInstantialExtended") |> PrefixedName

    /// <summary>
    ///   <para>gvp:Infer_skosBroader_TypeRestr</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protontop#TypeRestr</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#Infer_skosBroader_TypeRestr">http://vocab.getty.edu/ontology#Infer_skosBroader_TypeRestr</seealso>
    let Infer_skosBroader_TypeRestr =
        Prefixed_Name(gvp, "Infer_skosBroader_TypeRestr") |> PrefixedName

    /// <summary>
    ///   <para>gvp:PersonConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A single individual. Usually people engaged in the design or creation of art or architecture ("Artists"); but may also include donors, patrons, rulers, sitters, art historians, etc ("Non-Artists")</para>
    /// labels<para>PersonConcept</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#PersonConcept">http://vocab.getty.edu/ontology#PersonConcept</seealso>
    let PersonConcept = Prefixed_Name(gvp, "PersonConcept") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ScopeNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Defines a GVP subject or provides usage information. Has fields:
    /// - dc:identifier: numeric ID, also used in the URL.
    /// - rdf:value: the note itself (as per SKOS Primer: 4.2 Advanced Documentation Features) with language tag
    /// - dct:language: matches the language tag
    /// - gvp:displayOrder, order of this note amongst others
    /// - gvp:historicFlag, gvp:estStart, gvp:estEnd, rdfs:comment: Historic Information about applicability
    /// - dct:source or subproperties thereof
    /// - dct:contributor or subproperties thereof</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ScopeNote">http://vocab.getty.edu/ontology#ScopeNote</seealso>
    let ScopeNote = Prefixed_Name(gvp, "ScopeNote") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2805_contextualized_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2805_contextualized_in">http://vocab.getty.edu/ontology#aat2805_contextualized_in</seealso>
    let aat2805_contextualized_in =
        Prefixed_Name(gvp, "aat2805_contextualized_in") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2806_provide_context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2806_provide_context">http://vocab.getty.edu/ontology#aat2806_provide_context</seealso>
    let aat2806_provide_context =
        Prefixed_Name(gvp, "aat2806_provide_context") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2811_preceded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2811_preceded">http://vocab.getty.edu/ontology#aat2811_preceded</seealso>
    let aat2811_preceded = Prefixed_Name(gvp, "aat2811_preceded") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2814_constituent_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2814_constituent_of">http://vocab.getty.edu/ontology#aat2814_constituent_of</seealso>
    let aat2814_constituent_of =
        Prefixed_Name(gvp, "aat2814_constituent_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2815_composed_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2815_composed_of">http://vocab.getty.edu/ontology#aat2815_composed_of</seealso>
    let aat2815_composed_of = Prefixed_Name(gvp, "aat2815_composed_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2817_derived-made_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2817_derived-made_from">http://vocab.getty.edu/ontology#aat2817_derived-made_from</seealso>
    let aat2817_derived_made_from =
        Prefixed_Name(gvp, "aat2817_derived-made_from") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2818_source_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2818_source_for">http://vocab.getty.edu/ontology#aat2818_source_for</seealso>
    let aat2818_source_for = Prefixed_Name(gvp, "aat2818_source_for") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1516_great-grandchild_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1516_great-grandchild_of">http://vocab.getty.edu/ontology#ulan1516_great-grandchild_of</seealso>
    let ulan1516_great_grandchild_of =
        Prefixed_Name(gvp, "ulan1516_great-grandchild_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:broaderPreferredExtended</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Preferred Ancestors. Meaningful closure of gvp:broaderPreferred. Needed to display the hierarchy</para>
    /// labels<para>broaderPreferredExtended</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#broaderPreferredExtended">http://vocab.getty.edu/ontology#broaderPreferredExtended</seealso>
    let broaderPreferredExtended =
        Prefixed_Name(gvp, "broaderPreferredExtended") |> PrefixedName

    /// <summary>
    ///   <para>gvp:Infer_isoBroaderGeneric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>onto:proton/protontop#PropRestr</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#Infer_isoBroaderGeneric">http://vocab.getty.edu/ontology#Infer_isoBroaderGeneric</seealso>
    let Infer_isoBroaderGeneric =
        Prefixed_Name(gvp, "Infer_isoBroaderGeneric") |> PrefixedName

    /// <summary>
    ///   <para>gvp:tgn3001_distinguished_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#tgn3001_distinguished_from">http://vocab.getty.edu/ontology#tgn3001_distinguished_from</seealso>
    let tgn3001_distinguished_from =
        Prefixed_Name(gvp, "tgn3001_distinguished_from") |> PrefixedName

    /// <summary>
    ///   <para>gvp:tgn3006_formerly_identified_as</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#tgn3006_formerly_identified_as">http://vocab.getty.edu/ontology#tgn3006_formerly_identified_as</seealso>
    let tgn3006_formerly_identified_as =
        Prefixed_Name(gvp, "tgn3006_formerly_identified_as") |> PrefixedName

    /// <summary>
    ///   <para>gvp:tgn3101_near-adjacent_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#tgn3101_near-adjacent_to">http://vocab.getty.edu/ontology#tgn3101_near-adjacent_to</seealso>
    let tgn3101_near_adjacent_to =
        Prefixed_Name(gvp, "tgn3101_near-adjacent_to") |> PrefixedName

    /// <summary>
    ///   <para>gvp:tgn3110_meaning-usage_overlaps_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#tgn3110_meaning-usage_overlaps_with">http://vocab.getty.edu/ontology#tgn3110_meaning-usage_overlaps_with</seealso>
    let tgn3110_meaning_usage_overlaps_with =
        Prefixed_Name(gvp, "tgn3110_meaning-usage_overlaps_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:tgn3301_ally_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#tgn3301_ally_of">http://vocab.getty.edu/ontology#tgn3301_ally_of</seealso>
    let tgn3301_ally_of = Prefixed_Name(gvp, "tgn3301_ally_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:tgn3318_member_is</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#tgn3318_member_is">http://vocab.getty.edu/ontology#tgn3318_member_is</seealso>
    let tgn3318_member_is = Prefixed_Name(gvp, "tgn3318_member_is") |> PrefixedName
    /// <summary>
    ///   <para>gvp:tgn3402_moved_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#tgn3402_moved_to">http://vocab.getty.edu/ontology#tgn3402_moved_to</seealso>
    let tgn3402_moved_to = Prefixed_Name(gvp, "tgn3402_moved_to") |> PrefixedName
    /// <summary>
    ///   <para>gvp:broaderExtended</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Appropriate ancestors. Meaningful closure of gvp:broader for query expansion. Use this, not skos:broaderTransitive</para>
    /// labels<para>broaderExtended</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#broaderExtended">http://vocab.getty.edu/ontology#broaderExtended</seealso>
    let broaderExtended = Prefixed_Name(gvp, "broaderExtended") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2501_made_of-require</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2501_made_of-require">http://vocab.getty.edu/ontology#aat2501_made_of-require</seealso>
    let aat2501_made_of_require =
        Prefixed_Name(gvp, "aat2501_made_of-require") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2505_locus-setting_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2505_locus-setting_for">http://vocab.getty.edu/ontology#aat2505_locus-setting_for</seealso>
    let aat2505_locus_setting_for =
        Prefixed_Name(gvp, "aat2505_locus-setting_for") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2507_produce-process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2507_produce-process">http://vocab.getty.edu/ontology#aat2507_produce-process</seealso>
    let aat2507_produce_process =
        Prefixed_Name(gvp, "aat2507_produce-process") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2552_reflected_in-produces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2552_reflected_in-produces">http://vocab.getty.edu/ontology#aat2552_reflected_in-produces</seealso>
    let aat2552_reflected_in_produces =
        Prefixed_Name(gvp, "aat2552_reflected_in-produces") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2554_reflects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2554_reflects">http://vocab.getty.edu/ontology#aat2554_reflects</seealso>
    let aat2554_reflects = Prefixed_Name(gvp, "aat2554_reflects") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2555_reflected_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2555_reflected_in">http://vocab.getty.edu/ontology#aat2555_reflected_in</seealso>
    let aat2555_reflected_in =
        Prefixed_Name(gvp, "aat2555_reflected_in") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2558_reflected_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2558_reflected_in">http://vocab.getty.edu/ontology#aat2558_reflected_in</seealso>
    let aat2558_reflected_in =
        Prefixed_Name(gvp, "aat2558_reflected_in") |> PrefixedName

    /// <summary>
    ///   <para>gvp:Infer_isoBroaderPartitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>onto:proton/protontop#PropRestr</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#Infer_isoBroaderPartitive">http://vocab.getty.edu/ontology#Infer_isoBroaderPartitive</seealso>
    let Infer_isoBroaderPartitive =
        Prefixed_Name(gvp, "Infer_isoBroaderPartitive") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ObsoleteSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Obsolete subject: moved out of the publishable hierarchy, or merged to another (pointed by dct:isReplacedBy)</para>
    /// labels<para>ObsoleteSubject</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ObsoleteSubject">http://vocab.getty.edu/ontology#ObsoleteSubject</seealso>
    let ObsoleteSubject = Prefixed_Name(gvp, "ObsoleteSubject") |> PrefixedName

    /// <summary>
    ///   <para>gvp:PhysAdminPlaceConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Place that is both administrative and physical. Rarely used. Used in TGN only</para>
    /// labels<para>PhysAdminPlaceConcept</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#PhysAdminPlaceConcept">http://vocab.getty.edu/ontology#PhysAdminPlaceConcept</seealso>
    let PhysAdminPlaceConcept =
        Prefixed_Name(gvp, "PhysAdminPlaceConcept") |> PrefixedName

    /// <summary>
    ///   <para>gvp:PhysPlaceConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Physical feature, defined by its physical characteristics on planet Earth, including mountains, rivers, and oceans. Used in TGN only</para>
    /// labels<para>PhysPlaceConcept</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#PhysPlaceConcept">http://vocab.getty.edu/ontology#PhysPlaceConcept</seealso>
    let PhysPlaceConcept = Prefixed_Name(gvp, "PhysPlaceConcept") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2110_meaning-usage_overlaps_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2110_meaning-usage_overlaps_with">http://vocab.getty.edu/ontology#aat2110_meaning-usage_overlaps_with</seealso>
    let aat2110_meaning_usage_overlaps_with =
        Prefixed_Name(gvp, "aat2110_meaning-usage_overlaps_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2205_causes-is_required</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2205_causes-is_required">http://vocab.getty.edu/ontology#aat2205_causes-is_required</seealso>
    let aat2205_causes_is_required =
        Prefixed_Name(gvp, "aat2205_causes-is_required") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2828_use-require</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2828_use-require">http://vocab.getty.edu/ontology#aat2828_use-require</seealso>
    let aat2828_use_require = Prefixed_Name(gvp, "aat2828_use-require") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2831_associated_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2831_associated_with">http://vocab.getty.edu/ontology#aat2831_associated_with</seealso>
    let aat2831_associated_with =
        Prefixed_Name(gvp, "aat2831_associated_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1544_significant_other_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1544_significant_other_of">http://vocab.getty.edu/ontology#ulan1544_significant_other_of</seealso>
    let ulan1544_significant_other_of =
        Prefixed_Name(gvp, "ulan1544_significant_other_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1547_romantic_partner_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1547_romantic_partner_of">http://vocab.getty.edu/ontology#ulan1547_romantic_partner_of</seealso>
    let ulan1547_romantic_partner_of =
        Prefixed_Name(gvp, "ulan1547_romantic_partner_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1550_relative_by_marriage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1550_relative_by_marriage">http://vocab.getty.edu/ontology#ulan1550_relative_by_marriage</seealso>
    let ulan1550_relative_by_marriage =
        Prefixed_Name(gvp, "ulan1550_relative_by_marriage") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1552_parent_by_marriage_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1552_parent_by_marriage_of">http://vocab.getty.edu/ontology#ulan1552_parent_by_marriage_of</seealso>
    let ulan1552_parent_by_marriage_of =
        Prefixed_Name(gvp, "ulan1552_parent_by_marriage_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2557_reflects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2557_reflects">http://vocab.getty.edu/ontology#aat2557_reflects</seealso>
    let aat2557_reflects = Prefixed_Name(gvp, "aat2557_reflects") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2562_locus-setting_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2562_locus-setting_for">http://vocab.getty.edu/ontology#aat2562_locus-setting_for</seealso>
    let aat2562_locus_setting_for =
        Prefixed_Name(gvp, "aat2562_locus-setting_for") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2601_possessed_by-existing_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2601_possessed_by-existing_in">http://vocab.getty.edu/ontology#aat2601_possessed_by-existing_in</seealso>
    let aat2601_possessed_by_existing_in =
        Prefixed_Name(gvp, "aat2601_possessed_by-existing_in") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2604_possessed_by-existing_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2604_possessed_by-existing_in">http://vocab.getty.edu/ontology#aat2604_possessed_by-existing_in</seealso>
    let aat2604_possessed_by_existing_in =
        Prefixed_Name(gvp, "aat2604_possessed_by-existing_in") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2608_causes-required_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2608_causes-required_for">http://vocab.getty.edu/ontology#aat2608_causes-required_for</seealso>
    let aat2608_causes_required_for =
        Prefixed_Name(gvp, "aat2608_causes-required_for") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2613_possess-exist_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2613_possess-exist_in">http://vocab.getty.edu/ontology#aat2613_possess-exist_in</seealso>
    let aat2613_possess_exist_in =
        Prefixed_Name(gvp, "aat2613_possess-exist_in") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1006_formerly_identified_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1006_formerly_identified_with">http://vocab.getty.edu/ontology#ulan1006_formerly_identified_with</seealso>
    let ulan1006_formerly_identified_with =
        Prefixed_Name(gvp, "ulan1006_formerly_identified_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1008_meaning_-usage_overlaps_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1008_meaning_-usage_overlaps_with">http://vocab.getty.edu/ontology#ulan1008_meaning_-usage_overlaps_with</seealso>
    let ulan1008_meaning__usage_overlaps_with =
        Prefixed_Name(gvp, "ulan1008_meaning_-usage_overlaps_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1105_apprentice_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1105_apprentice_of">http://vocab.getty.edu/ontology#ulan1105_apprentice_of</seealso>
    let ulan1105_apprentice_of =
        Prefixed_Name(gvp, "ulan1105_apprentice_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1107_influenced</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1107_influenced">http://vocab.getty.edu/ontology#ulan1107_influenced</seealso>
    let ulan1107_influenced = Prefixed_Name(gvp, "ulan1107_influenced") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1108_influenced_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1108_influenced_by">http://vocab.getty.edu/ontology#ulan1108_influenced_by</seealso>
    let ulan1108_influenced_by =
        Prefixed_Name(gvp, "ulan1108_influenced_by") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1112_master_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1112_master_was">http://vocab.getty.edu/ontology#ulan1112_master_was</seealso>
    let ulan1112_master_was = Prefixed_Name(gvp, "ulan1112_master_was") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1113_fellow_student_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1113_fellow_student_of">http://vocab.getty.edu/ontology#ulan1113_fellow_student_of</seealso>
    let ulan1113_fellow_student_of =
        Prefixed_Name(gvp, "ulan1113_fellow_student_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1203_donor_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1203_donor_of">http://vocab.getty.edu/ontology#ulan1203_donor_of</seealso>
    let ulan1203_donor_of = Prefixed_Name(gvp, "ulan1203_donor_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1204_donor_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1204_donor_was">http://vocab.getty.edu/ontology#ulan1204_donor_was</seealso>
    let ulan1204_donor_was = Prefixed_Name(gvp, "ulan1204_donor_was") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1211_artist_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1211_artist_to">http://vocab.getty.edu/ontology#ulan1211_artist_to</seealso>
    let ulan1211_artist_to = Prefixed_Name(gvp, "ulan1211_artist_to") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1212_artist_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1212_artist_was">http://vocab.getty.edu/ontology#ulan1212_artist_was</seealso>
    let ulan1212_artist_was = Prefixed_Name(gvp, "ulan1212_artist_was") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1217_employee_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1217_employee_of">http://vocab.getty.edu/ontology#ulan1217_employee_of</seealso>
    let ulan1217_employee_of =
        Prefixed_Name(gvp, "ulan1217_employee_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1223_crowned_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1223_crowned_by">http://vocab.getty.edu/ontology#ulan1223_crowned_by</seealso>
    let ulan1223_crowned_by = Prefixed_Name(gvp, "ulan1223_crowned_by") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1224_crowned</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1224_crowned">http://vocab.getty.edu/ontology#ulan1224_crowned</seealso>
    let ulan1224_crowned = Prefixed_Name(gvp, "ulan1224_crowned") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1305_worked_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1305_worked_with">http://vocab.getty.edu/ontology#ulan1305_worked_with</seealso>
    let ulan1305_worked_with =
        Prefixed_Name(gvp, "ulan1305_worked_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1306_performs_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1306_performs_with">http://vocab.getty.edu/ontology#ulan1306_performs_with</seealso>
    let ulan1306_performs_with =
        Prefixed_Name(gvp, "ulan1306_performs_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1307_assistant_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1307_assistant_of">http://vocab.getty.edu/ontology#ulan1307_assistant_of</seealso>
    let ulan1307_assistant_of =
        Prefixed_Name(gvp, "ulan1307_assistant_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1311_partner_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1311_partner_of">http://vocab.getty.edu/ontology#ulan1311_partner_of</seealso>
    let ulan1311_partner_of = Prefixed_Name(gvp, "ulan1311_partner_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1313_partner_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1313_partner_in">http://vocab.getty.edu/ontology#ulan1313_partner_in</seealso>
    let ulan1313_partner_in = Prefixed_Name(gvp, "ulan1313_partner_in") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1317_member_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1317_member_of">http://vocab.getty.edu/ontology#ulan1317_member_of</seealso>
    let ulan1317_member_of = Prefixed_Name(gvp, "ulan1317_member_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1318_member_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1318_member_was">http://vocab.getty.edu/ontology#ulan1318_member_was</seealso>
    let ulan1318_member_was = Prefixed_Name(gvp, "ulan1318_member_was") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1332_worker_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1332_worker_was">http://vocab.getty.edu/ontology#ulan1332_worker_was</seealso>
    let ulan1332_worker_was = Prefixed_Name(gvp, "ulan1332_worker_was") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1411_successor_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1411_successor_of">http://vocab.getty.edu/ontology#ulan1411_successor_of</seealso>
    let ulan1411_successor_of =
        Prefixed_Name(gvp, "ulan1411_successor_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1412_predecessor_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1412_predecessor_of">http://vocab.getty.edu/ontology#ulan1412_predecessor_of</seealso>
    let ulan1412_predecessor_of =
        Prefixed_Name(gvp, "ulan1412_predecessor_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:tgn3412_predecessor_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#tgn3412_predecessor_of">http://vocab.getty.edu/ontology#tgn3412_predecessor_of</seealso>
    let tgn3412_predecessor_of =
        Prefixed_Name(gvp, "tgn3412_predecessor_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2803_example_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2803_example_of">http://vocab.getty.edu/ontology#aat2803_example_of</seealso>
    let aat2803_example_of = Prefixed_Name(gvp, "aat2803_example_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2605_possess-exist_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2605_possess-exist_in">http://vocab.getty.edu/ontology#aat2605_possess-exist_in</seealso>
    let aat2605_possess_exist_in =
        Prefixed_Name(gvp, "aat2605_possess-exist_in") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2607_caused_by-requires</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2607_caused_by-requires">http://vocab.getty.edu/ontology#aat2607_caused_by-requires</seealso>
    let aat2607_caused_by_requires =
        Prefixed_Name(gvp, "aat2607_caused_by-requires") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2612_possessed_by-existing_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2612_possessed_by-existing_in">http://vocab.getty.edu/ontology#aat2612_possessed_by-existing_in</seealso>
    let aat2612_possessed_by_existing_in =
        Prefixed_Name(gvp, "aat2612_possessed_by-existing_in") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2801_conjuncted_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2801_conjuncted_with">http://vocab.getty.edu/ontology#aat2801_conjuncted_with</seealso>
    let aat2801_conjuncted_with =
        Prefixed_Name(gvp, "aat2801_conjuncted_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2802_exemplified_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2802_exemplified_by">http://vocab.getty.edu/ontology#aat2802_exemplified_by</seealso>
    let aat2802_exemplified_by =
        Prefixed_Name(gvp, "aat2802_exemplified_by") |> PrefixedName

    /// <summary>
    ///   <para>gvp:UnknownPersonConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Unknown person representing a nationality/culture (the Unknown People by Culture facet)</para>
    /// labels<para>UnknownPersonConcept</para></remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#UnknownPersonConcept">http://vocab.getty.edu/ontology#UnknownPersonConcept</seealso>
    let UnknownPersonConcept =
        Prefixed_Name(gvp, "UnknownPersonConcept") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2001_formerly_referred_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2001_formerly_referred_to">http://vocab.getty.edu/ontology#aat2001_formerly_referred_to</seealso>
    let aat2001_formerly_referred_to =
        Prefixed_Name(gvp, "aat2001_formerly_referred_to") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2000_related_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2000_related_to">http://vocab.getty.edu/ontology#aat2000_related_to</seealso>
    let aat2000_related_to = Prefixed_Name(gvp, "aat2000_related_to") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2100_distinguished_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2100_distinguished_from">http://vocab.getty.edu/ontology#aat2100_distinguished_from</seealso>
    let aat2100_distinguished_from =
        Prefixed_Name(gvp, "aat2100_distinguished_from") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2203_associated_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2203_associated_with">http://vocab.getty.edu/ontology#aat2203_associated_with</seealso>
    let aat2203_associated_with =
        Prefixed_Name(gvp, "aat2203_associated_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2206_caused_by-requires</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2206_caused_by-requires">http://vocab.getty.edu/ontology#aat2206_caused_by-requires</seealso>
    let aat2206_caused_by_requires =
        Prefixed_Name(gvp, "aat2206_caused_by-requires") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2209_used-located_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2209_used-located_in">http://vocab.getty.edu/ontology#aat2209_used-located_in</seealso>
    let aat2209_used_located_in =
        Prefixed_Name(gvp, "aat2209_used-located_in") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2211_produce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2211_produce">http://vocab.getty.edu/ontology#aat2211_produce</seealso>
    let aat2211_produce = Prefixed_Name(gvp, "aat2211_produce") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2848_involved_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2848_involved_in">http://vocab.getty.edu/ontology#aat2848_involved_in</seealso>
    let aat2848_involved_in = Prefixed_Name(gvp, "aat2848_involved_in") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2849_involves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2849_involves">http://vocab.getty.edu/ontology#aat2849_involves</seealso>
    let aat2849_involves = Prefixed_Name(gvp, "aat2849_involves") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2853_involve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2853_involve">http://vocab.getty.edu/ontology#aat2853_involve</seealso>
    let aat2853_involve = Prefixed_Name(gvp, "aat2853_involve") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2876_characterized_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2876_characterized_by">http://vocab.getty.edu/ontology#aat2876_characterized_by</seealso>
    let aat2876_characterized_by =
        Prefixed_Name(gvp, "aat2876_characterized_by") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2879_followed-developed_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2879_followed-developed_from">http://vocab.getty.edu/ontology#aat2879_followed-developed_from</seealso>
    let aat2879_followed_developed_from =
        Prefixed_Name(gvp, "aat2879_followed-developed_from") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2881_reflected_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2881_reflected_in">http://vocab.getty.edu/ontology#aat2881_reflected_in</seealso>
    let aat2881_reflected_in =
        Prefixed_Name(gvp, "aat2881_reflected_in") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1573_ward_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1573_ward_of">http://vocab.getty.edu/ontology#ulan1573_ward_of</seealso>
    let ulan1573_ward_of = Prefixed_Name(gvp, "ulan1573_ward_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2807_derived_from_common_source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2807_derived_from_common_source">http://vocab.getty.edu/ontology#aat2807_derived_from_common_source</seealso>
    let aat2807_derived_from_common_source =
        Prefixed_Name(gvp, "aat2807_derived_from_common_source") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2809_coexisted_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2809_coexisted_with">http://vocab.getty.edu/ontology#aat2809_coexisted_with</seealso>
    let aat2809_coexisted_with =
        Prefixed_Name(gvp, "aat2809_coexisted_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2812_followed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2812_followed">http://vocab.getty.edu/ontology#aat2812_followed</seealso>
    let aat2812_followed = Prefixed_Name(gvp, "aat2812_followed") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2208_locus-setting_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2208_locus-setting_for">http://vocab.getty.edu/ontology#aat2208_locus-setting_for</seealso>
    let aat2208_locus_setting_for =
        Prefixed_Name(gvp, "aat2208_locus-setting_for") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2837_source_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2837_source_for">http://vocab.getty.edu/ontology#aat2837_source_for</seealso>
    let aat2837_source_for = Prefixed_Name(gvp, "aat2837_source_for") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1548_domestic_partner_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1548_domestic_partner_of">http://vocab.getty.edu/ontology#ulan1548_domestic_partner_of</seealso>
    let ulan1548_domestic_partner_of =
        Prefixed_Name(gvp, "ulan1548_domestic_partner_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1551_sibling_by_marriage_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1551_sibling_by_marriage_of">http://vocab.getty.edu/ontology#ulan1551_sibling_by_marriage_of</seealso>
    let ulan1551_sibling_by_marriage_of =
        Prefixed_Name(gvp, "ulan1551_sibling_by_marriage_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2822_basis_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2822_basis_of">http://vocab.getty.edu/ontology#aat2822_basis_of</seealso>
    let aat2822_basis_of = Prefixed_Name(gvp, "aat2822_basis_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2829_used-required_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2829_used-required_for">http://vocab.getty.edu/ontology#aat2829_used-required_for</seealso>
    let aat2829_used_required_for =
        Prefixed_Name(gvp, "aat2829_used-required_for") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2833_ancestor_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2833_ancestor_of">http://vocab.getty.edu/ontology#aat2833_ancestor_of</seealso>
    let aat2833_ancestor_of = Prefixed_Name(gvp, "aat2833_ancestor_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2834_decendant_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2834_decendant_of">http://vocab.getty.edu/ontology#aat2834_decendant_of</seealso>
    let aat2834_decendant_of =
        Prefixed_Name(gvp, "aat2834_decendant_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2836_derived-made_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2836_derived-made_from">http://vocab.getty.edu/ontology#aat2836_derived-made_from</seealso>
    let aat2836_derived_made_from =
        Prefixed_Name(gvp, "aat2836_derived-made_from") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2841_derived-made_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2841_derived-made_from">http://vocab.getty.edu/ontology#aat2841_derived-made_from</seealso>
    let aat2841_derived_made_from =
        Prefixed_Name(gvp, "aat2841_derived-made_from") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2845_used-located_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2845_used-located_in">http://vocab.getty.edu/ontology#aat2845_used-located_in</seealso>
    let aat2845_used_located_in =
        Prefixed_Name(gvp, "aat2845_used-located_in") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2846_locus-setting_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2846_locus-setting_for">http://vocab.getty.edu/ontology#aat2846_locus-setting_for</seealso>
    let aat2846_locus_setting_for =
        Prefixed_Name(gvp, "aat2846_locus-setting_for") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1553_child_by_marriage_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1553_child_by_marriage_of">http://vocab.getty.edu/ontology#ulan1553_child_by_marriage_of</seealso>
    let ulan1553_child_by_marriage_of =
        Prefixed_Name(gvp, "ulan1553_child_by_marriage_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1554_adoptive_parent_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1554_adoptive_parent_of">http://vocab.getty.edu/ontology#ulan1554_adoptive_parent_of</seealso>
    let ulan1554_adoptive_parent_of =
        Prefixed_Name(gvp, "ulan1554_adoptive_parent_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1555_adopted_child_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1555_adopted_child_of">http://vocab.getty.edu/ontology#ulan1555_adopted_child_of</seealso>
    let ulan1555_adopted_child_of =
        Prefixed_Name(gvp, "ulan1555_adopted_child_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1557_step-sibling_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1557_step-sibling_of">http://vocab.getty.edu/ontology#ulan1557_step-sibling_of</seealso>
    let ulan1557_step_sibling_of =
        Prefixed_Name(gvp, "ulan1557_step-sibling_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1561_step-child_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1561_step-child_of">http://vocab.getty.edu/ontology#ulan1561_step-child_of</seealso>
    let ulan1561_step_child_of =
        Prefixed_Name(gvp, "ulan1561_step-child_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1562_step-parent_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1562_step-parent_of">http://vocab.getty.edu/ontology#ulan1562_step-parent_of</seealso>
    let ulan1562_step_parent_of =
        Prefixed_Name(gvp, "ulan1562_step-parent_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1574_godparent_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1574_godparent_of">http://vocab.getty.edu/ontology#ulan1574_godparent_of</seealso>
    let ulan1574_godparent_of =
        Prefixed_Name(gvp, "ulan1574_godparent_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1575_godchild_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1575_godchild_of">http://vocab.getty.edu/ontology#ulan1575_godchild_of</seealso>
    let ulan1575_godchild_of =
        Prefixed_Name(gvp, "ulan1575_godchild_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1582_ancestor_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1582_ancestor_of">http://vocab.getty.edu/ontology#ulan1582_ancestor_of</seealso>
    let ulan1582_ancestor_of =
        Prefixed_Name(gvp, "ulan1582_ancestor_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2842_source_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2842_source_for">http://vocab.getty.edu/ontology#aat2842_source_for</seealso>
    let aat2842_source_for = Prefixed_Name(gvp, "aat2842_source_for") |> PrefixedName
    /// <summary>
    ///   <para>gvp:aat2212_produced_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2212_produced_by">http://vocab.getty.edu/ontology#aat2212_produced_by</seealso>
    let aat2212_produced_by = Prefixed_Name(gvp, "aat2212_produced_by") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2852_involved_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2852_involved_with">http://vocab.getty.edu/ontology#aat2852_involved_with</seealso>
    let aat2852_involved_with =
        Prefixed_Name(gvp, "aat2852_involved_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2875_characteristic_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2875_characteristic_of">http://vocab.getty.edu/ontology#aat2875_characteristic_of</seealso>
    let aat2875_characteristic_of =
        Prefixed_Name(gvp, "aat2875_characteristic_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2878_preceded-source_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2878_preceded-source_for">http://vocab.getty.edu/ontology#aat2878_preceded-source_for</seealso>
    let aat2878_preceded_source_for =
        Prefixed_Name(gvp, "aat2878_preceded-source_for") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2882_reflect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2882_reflect">http://vocab.getty.edu/ontology#aat2882_reflect</seealso>
    let aat2882_reflect = Prefixed_Name(gvp, "aat2882_reflect") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2884_involved_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2884_involved_with">http://vocab.getty.edu/ontology#aat2884_involved_with</seealso>
    let aat2884_involved_with =
        Prefixed_Name(gvp, "aat2884_involved_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2891_exemplified_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2891_exemplified_by">http://vocab.getty.edu/ontology#aat2891_exemplified_by</seealso>
    let aat2891_exemplified_by =
        Prefixed_Name(gvp, "aat2891_exemplified_by") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2894_exemplified_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2894_exemplified_by">http://vocab.getty.edu/ontology#aat2894_exemplified_by</seealso>
    let aat2894_exemplified_by =
        Prefixed_Name(gvp, "aat2894_exemplified_by") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1581_descendant_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1581_descendant_of">http://vocab.getty.edu/ontology#ulan1581_descendant_of</seealso>
    let ulan1581_descendant_of =
        Prefixed_Name(gvp, "ulan1581_descendant_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1556_half-sibling_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1556_half-sibling_of">http://vocab.getty.edu/ontology#ulan1556_half-sibling_of</seealso>
    let ulan1556_half_sibling_of =
        Prefixed_Name(gvp, "ulan1556_half-sibling_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1571_guardian_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1571_guardian_of">http://vocab.getty.edu/ontology#ulan1571_guardian_of</seealso>
    let ulan1571_guardian_of =
        Prefixed_Name(gvp, "ulan1571_guardian_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:Infer_isoBroaderInstantial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>onto:proton/protontop#PropRestr</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#Infer_isoBroaderInstantial">http://vocab.getty.edu/ontology#Infer_isoBroaderInstantial</seealso>
    let Infer_isoBroaderInstantial =
        Prefixed_Name(gvp, "Infer_isoBroaderInstantial") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2504_used-located_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2504_used-located_in">http://vocab.getty.edu/ontology#aat2504_used-located_in</seealso>
    let aat2504_used_located_in =
        Prefixed_Name(gvp, "aat2504_used-located_in") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2508_produced-processed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2508_produced-processed_by">http://vocab.getty.edu/ontology#aat2508_produced-processed_by</seealso>
    let aat2508_produced_processed_by =
        Prefixed_Name(gvp, "aat2508_produced-processed_by") |> PrefixedName

    /// <summary>
    ///   <para>gvp:aat2551_reflect-produced_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#aat2551_reflect-produced_by">http://vocab.getty.edu/ontology#aat2551_reflect-produced_by</seealso>
    let aat2551_reflect_produced_by =
        Prefixed_Name(gvp, "aat2551_reflect-produced_by") |> PrefixedName

    /// <summary>
    ///   <para>gvp:tgn3411_successor_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#tgn3411_successor_of">http://vocab.getty.edu/ontology#tgn3411_successor_of</seealso>
    let tgn3411_successor_of =
        Prefixed_Name(gvp, "tgn3411_successor_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:tgn3510_historical_connection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#tgn3510_historical_connection">http://vocab.getty.edu/ontology#tgn3510_historical_connection</seealso>
    let tgn3510_historical_connection =
        Prefixed_Name(gvp, "tgn3510_historical_connection") |> PrefixedName

    /// <summary>
    ///   <para>gvp:tgn3611_administrative_dependent_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#tgn3611_administrative_dependent_of">http://vocab.getty.edu/ontology#tgn3611_administrative_dependent_of</seealso>
    let tgn3611_administrative_dependent_of =
        Prefixed_Name(gvp, "tgn3611_administrative_dependent_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:tgn3612_administrative_entity_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#tgn3612_administrative_entity_for">http://vocab.getty.edu/ontology#tgn3612_administrative_entity_for</seealso>
    let tgn3612_administrative_entity_for =
        Prefixed_Name(gvp, "tgn3612_administrative_entity_for") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1000_related_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1000_related_to">http://vocab.getty.edu/ontology#ulan1000_related_to</seealso>
    let ulan1000_related_to = Prefixed_Name(gvp, "ulan1000_related_to") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1003_associated_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1003_associated_with">http://vocab.getty.edu/ontology#ulan1003_associated_with</seealso>
    let ulan1003_associated_with =
        Prefixed_Name(gvp, "ulan1003_associated_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1005_possibly_identified_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1005_possibly_identified_with">http://vocab.getty.edu/ontology#ulan1005_possibly_identified_with</seealso>
    let ulan1005_possibly_identified_with =
        Prefixed_Name(gvp, "ulan1005_possibly_identified_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1007_distinguished_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1007_distinguished_from">http://vocab.getty.edu/ontology#ulan1007_distinguished_from</seealso>
    let ulan1007_distinguished_from =
        Prefixed_Name(gvp, "ulan1007_distinguished_from") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1101_teacher_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1101_teacher_of">http://vocab.getty.edu/ontology#ulan1101_teacher_of</seealso>
    let ulan1101_teacher_of = Prefixed_Name(gvp, "ulan1101_teacher_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1102_student_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1102_student_of">http://vocab.getty.edu/ontology#ulan1102_student_of</seealso>
    let ulan1102_student_of = Prefixed_Name(gvp, "ulan1102_student_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1106_apprentice_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1106_apprentice_was">http://vocab.getty.edu/ontology#ulan1106_apprentice_was</seealso>
    let ulan1106_apprentice_was =
        Prefixed_Name(gvp, "ulan1106_apprentice_was") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1111_master_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1111_master_of">http://vocab.getty.edu/ontology#ulan1111_master_of</seealso>
    let ulan1111_master_of = Prefixed_Name(gvp, "ulan1111_master_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1201_patron_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1201_patron_of">http://vocab.getty.edu/ontology#ulan1201_patron_of</seealso>
    let ulan1201_patron_of = Prefixed_Name(gvp, "ulan1201_patron_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1202_patron_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1202_patron_was">http://vocab.getty.edu/ontology#ulan1202_patron_was</seealso>
    let ulan1202_patron_was = Prefixed_Name(gvp, "ulan1202_patron_was") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1205_client_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1205_client_of">http://vocab.getty.edu/ontology#ulan1205_client_of</seealso>
    let ulan1205_client_of = Prefixed_Name(gvp, "ulan1205_client_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1206_client_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1206_client_was">http://vocab.getty.edu/ontology#ulan1206_client_was</seealso>
    let ulan1206_client_was = Prefixed_Name(gvp, "ulan1206_client_was") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1213_court_artist_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1213_court_artist_to">http://vocab.getty.edu/ontology#ulan1213_court_artist_to</seealso>
    let ulan1213_court_artist_to =
        Prefixed_Name(gvp, "ulan1213_court_artist_to") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1214_court_artist_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1214_court_artist_was">http://vocab.getty.edu/ontology#ulan1214_court_artist_was</seealso>
    let ulan1214_court_artist_was =
        Prefixed_Name(gvp, "ulan1214_court_artist_was") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1218_employee_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1218_employee_was">http://vocab.getty.edu/ontology#ulan1218_employee_was</seealso>
    let ulan1218_employee_was =
        Prefixed_Name(gvp, "ulan1218_employee_was") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1221_appointed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1221_appointed_by">http://vocab.getty.edu/ontology#ulan1221_appointed_by</seealso>
    let ulan1221_appointed_by =
        Prefixed_Name(gvp, "ulan1221_appointed_by") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1222_appointee_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1222_appointee_of">http://vocab.getty.edu/ontology#ulan1222_appointee_of</seealso>
    let ulan1222_appointee_of =
        Prefixed_Name(gvp, "ulan1222_appointee_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1301_colleague_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1301_colleague_of">http://vocab.getty.edu/ontology#ulan1301_colleague_of</seealso>
    let ulan1301_colleague_of =
        Prefixed_Name(gvp, "ulan1301_colleague_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1302_associate_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1302_associate_of">http://vocab.getty.edu/ontology#ulan1302_associate_of</seealso>
    let ulan1302_associate_of =
        Prefixed_Name(gvp, "ulan1302_associate_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1303_collaborated_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1303_collaborated_with">http://vocab.getty.edu/ontology#ulan1303_collaborated_with</seealso>
    let ulan1303_collaborated_with =
        Prefixed_Name(gvp, "ulan1303_collaborated_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1308_assisted_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1308_assisted_by">http://vocab.getty.edu/ontology#ulan1308_assisted_by</seealso>
    let ulan1308_assisted_by =
        Prefixed_Name(gvp, "ulan1308_assisted_by") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1309_advisor_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1309_advisor_of">http://vocab.getty.edu/ontology#ulan1309_advisor_of</seealso>
    let ulan1309_advisor_of = Prefixed_Name(gvp, "ulan1309_advisor_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1310_advised_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1310_advised_by">http://vocab.getty.edu/ontology#ulan1310_advised_by</seealso>
    let ulan1310_advised_by = Prefixed_Name(gvp, "ulan1310_advised_by") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1314_partner_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1314_partner_was">http://vocab.getty.edu/ontology#ulan1314_partner_was</seealso>
    let ulan1314_partner_was =
        Prefixed_Name(gvp, "ulan1314_partner_was") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1315_principal_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1315_principal_in">http://vocab.getty.edu/ontology#ulan1315_principal_in</seealso>
    let ulan1315_principal_in =
        Prefixed_Name(gvp, "ulan1315_principal_in") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1316_principal_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1316_principal_was">http://vocab.getty.edu/ontology#ulan1316_principal_was</seealso>
    let ulan1316_principal_was =
        Prefixed_Name(gvp, "ulan1316_principal_was") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1321_school_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1321_school_of">http://vocab.getty.edu/ontology#ulan1321_school_of</seealso>
    let ulan1321_school_of = Prefixed_Name(gvp, "ulan1321_school_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1322_school_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1322_school_was">http://vocab.getty.edu/ontology#ulan1322_school_was</seealso>
    let ulan1322_school_was = Prefixed_Name(gvp, "ulan1322_school_was") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1331_worked_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1331_worked_with">http://vocab.getty.edu/ontology#ulan1331_worked_with</seealso>
    let ulan1331_worked_with =
        Prefixed_Name(gvp, "ulan1331_worked_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1413_administration_overlaps_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1413_administration_overlaps_with">http://vocab.getty.edu/ontology#ulan1413_administration_overlaps_with</seealso>
    let ulan1413_administration_overlaps_with =
        Prefixed_Name(gvp, "ulan1413_administration_overlaps_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1414_joint_venture_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1414_joint_venture_with">http://vocab.getty.edu/ontology#ulan1414_joint_venture_with</seealso>
    let ulan1414_joint_venture_with =
        Prefixed_Name(gvp, "ulan1414_joint_venture_with") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1421_founded_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1421_founded_by">http://vocab.getty.edu/ontology#ulan1421_founded_by</seealso>
    let ulan1421_founded_by = Prefixed_Name(gvp, "ulan1421_founded_by") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1422_founded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1422_founded">http://vocab.getty.edu/ontology#ulan1422_founded</seealso>
    let ulan1422_founded = Prefixed_Name(gvp, "ulan1422_founded") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1500_related_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1500_related_to">http://vocab.getty.edu/ontology#ulan1500_related_to</seealso>
    let ulan1500_related_to = Prefixed_Name(gvp, "ulan1500_related_to") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1501_sibling_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1501_sibling_of">http://vocab.getty.edu/ontology#ulan1501_sibling_of</seealso>
    let ulan1501_sibling_of = Prefixed_Name(gvp, "ulan1501_sibling_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1511_child_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1511_child_of">http://vocab.getty.edu/ontology#ulan1511_child_of</seealso>
    let ulan1511_child_of = Prefixed_Name(gvp, "ulan1511_child_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1512_parent_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1512_parent_of">http://vocab.getty.edu/ontology#ulan1512_parent_of</seealso>
    let ulan1512_parent_of = Prefixed_Name(gvp, "ulan1512_parent_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1513_grandchild_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1513_grandchild_of">http://vocab.getty.edu/ontology#ulan1513_grandchild_of</seealso>
    let ulan1513_grandchild_of =
        Prefixed_Name(gvp, "ulan1513_grandchild_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1514_gandparent_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1514_gandparent_of">http://vocab.getty.edu/ontology#ulan1514_gandparent_of</seealso>
    let ulan1514_gandparent_of =
        Prefixed_Name(gvp, "ulan1514_gandparent_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1515_great-grandparent_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1515_great-grandparent_of">http://vocab.getty.edu/ontology#ulan1515_great-grandparent_of</seealso>
    let ulan1515_great_grandparent_of =
        Prefixed_Name(gvp, "ulan1515_great-grandparent_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1521_cousin_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1521_cousin_of">http://vocab.getty.edu/ontology#ulan1521_cousin_of</seealso>
    let ulan1521_cousin_of = Prefixed_Name(gvp, "ulan1521_cousin_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1531_nephew-niece_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1531_nephew-niece_of">http://vocab.getty.edu/ontology#ulan1531_nephew-niece_of</seealso>
    let ulan1531_nephew_niece_of =
        Prefixed_Name(gvp, "ulan1531_nephew-niece_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1532_uncle-aunt_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1532_uncle-aunt_of">http://vocab.getty.edu/ontology#ulan1532_uncle-aunt_of</seealso>
    let ulan1532_uncle_aunt_of =
        Prefixed_Name(gvp, "ulan1532_uncle-aunt_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1541_spouse_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1541_spouse_of">http://vocab.getty.edu/ontology#ulan1541_spouse_of</seealso>
    let ulan1541_spouse_of = Prefixed_Name(gvp, "ulan1541_spouse_of") |> PrefixedName
    /// <summary>
    ///   <para>gvp:ulan1542_consort_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1542_consort_of">http://vocab.getty.edu/ontology#ulan1542_consort_of</seealso>
    let ulan1542_consort_of = Prefixed_Name(gvp, "ulan1542_consort_of") |> PrefixedName

    /// <summary>
    ///   <para>gvp:ulan1543_consort_was</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.getty.edu/ontology#ulan1543_consort_was">http://vocab.getty.edu/ontology#ulan1543_consort_was</seealso>
    let ulan1543_consort_was =
        Prefixed_Name(gvp, "ulan1543_consort_was") |> PrefixedName
