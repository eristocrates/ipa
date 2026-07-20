namespace http.purl.org.iso25964.skos_thes.hash

open DoxAletheia

module iso_thes =
    let _namespace_name = "http://purl.org/iso25964/skos-thes#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// ISO PreferredTerm:
    ///
    /// Instances of iso-thes:PreferredTerm are objects of skos-xl:prefLabel statements.
    ///
    /// Making the class explicit allows RDF/OWL consistency checks for CompoundEquivalence.
    /// <see href="http://purl.org/iso25964/skos-thes#PreferredTerm"></see></summary>
    let PreferredTerm = _prefix "PreferredTerm"
    /// <summary>
    /// ISO SimpleNonPreferredTerm
    ///
    /// Instances of iso:SimpleNonPreferredTerm are the object of either of skos xl:altLabel or skos xl:hiddenLabel statements.
    ///
    ///
    /// Identifying cases of Equivalence:
    ///
    /// In SKOS/-XL, Equivalence may be derived between the skos/skos xl:prefLabel statements on one hand and the skos/skos xl:altLabel or the skos/skos xl:hiddenLabel statements on the other hand where:
    /// - the subject of all these statements is the same instance of skos:Concept,
    /// - the language of all the bound labels is the same,
    /// - the prefLabel has the role USE, and
    /// - the altLabel and hiddenLabel have the role UF.
    /// <see href="http://purl.org/iso25964/skos-thes#SimpleNonPreferredTerm"></see></summary>
    let SimpleNonPreferredTerm = _prefix "SimpleNonPreferredTerm"
    /// <summary>
    /// iso SplitNonPreferredTerm
    ///
    /// This class provides for an 'imagined' concept that may exist in a user’s mind but is not present in the thesaurus (Concept Scheme); it can, however, be represented by a combination of two or more preferred terms (skos-xl:prefLabel) in the thesaurus. (In contrast, concepts present in the thesaurus are provided for by the ThesaurusConcept class.)
    /// This label is provided by the object property iso thes:plusUF
    /// - domain: iso-thes:CompoundEquivalence
    /// - range: iso-thes:SplitNonPreferredTerm.
    /// <see href="http://purl.org/iso25964/skos-thes#SplitNonPreferredTerm"></see></summary>
    let SplitNonPreferredTerm = _prefix "SplitNonPreferredTerm"
    /// <summary>
    /// ISO CompoundEquivalence
    ///
    /// iso-thes:plusUseTerm (and its inverse iso-thes:plusUFTerm) may be derived from iso-thes:CompoundEquivalence.
    ///
    /// For a iso-thes:CompoundEquivalence instance each derived iso thes:plusUseTerm has as:
    /// - subject: the iso thes:plusUF value
    /// - object: the iso thes:plusUse value
    ///
    /// An ISO 25964 compliant thesaurus only has one compound equivalence relation for each split non preferred term.
    ///
    /// In special cases where the iso-thes:SplitNonPreferredTerm has more than one decomposition, the inverse inference may not be possible.   (While this situation should not arise within a single thesaurus that complies with ISO 25964, it could occur if terms and relationships have been drawn from more than one thesaurus. For this reason the property skos:inScheme (http://www.w3.org/2004/02/skos/core#inScheme) should be used with each instance of the class Compound Equivalence, to relate it to its Thesaurus.)
    /// <see href="http://purl.org/iso25964/skos-thes#CompoundEquivalence"></see></summary>
    let CompoundEquivalence = _prefix "CompoundEquivalence"
    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#plusUF"></see>
    /// </summary>
    let plusUF = _prefix "plusUF"
    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#plusUse"></see>
    /// </summary>
    let plusUse = _prefix "plusUse"
    /// <summary>
    /// ISO ConceptGroup
    ///
    /// Concept groups have several applications.
    ///
    /// One such application is illustrated by the EUROVOC and the UNESCO thesaurus.  Both of these use a super structure of domain and of micro-thesaurus.  Both of these structuring elements can be modeled using ConceptGroup.
    /// <see href="http://purl.org/iso25964/skos-thes#ConceptGroup"></see></summary>
    let ConceptGroup = _prefix "ConceptGroup"
    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#ThesaurusArray"></see>
    /// </summary>
    let ThesaurusArray = _prefix "ThesaurusArray"
    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#broaderGeneric"></see>
    /// </summary>
    let broaderGeneric = _prefix "broaderGeneric"
    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#broaderInstantial"></see>
    /// </summary>
    let broaderInstantial = _prefix "broaderInstantial"
    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#broaderPartitive"></see>
    /// </summary>
    let broaderPartitive = _prefix "broaderPartitive"
    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#microThesaurusOf"></see>
    /// </summary>
    let microThesaurusOf = _prefix "microThesaurusOf"
    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#narrowerGeneric"></see>
    /// </summary>
    let narrowerGeneric = _prefix "narrowerGeneric"
    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#narrowerInstantial"></see>
    /// </summary>
    let narrowerInstantial = _prefix "narrowerInstantial"
    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#narrowerPartitive"></see>
    /// </summary>
    let narrowerPartitive = _prefix "narrowerPartitive"
    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#plusUFTerm"></see>
    /// </summary>
    let plusUFTerm = _prefix "plusUFTerm"
    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#plusUseTerm"></see>
    /// </summary>
    let plusUseTerm = _prefix "plusUseTerm"
    /// <summary>
    /// ISO status
    /// - on ThesaurusConcept
    /// - on ThesaurusTerm
    /// <see href="http://purl.org/iso25964/skos-thes#status"></see></summary>
    let status = _prefix "status"
    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#subGroup"></see>
    /// </summary>
    let subGroup = _prefix "subGroup"
    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#superGroup"></see>
    /// </summary>
    let superGroup = _prefix "superGroup"
    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#subordinateArray"></see>
    /// </summary>
    let subordinateArray = _prefix "subordinateArray"
    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#superOrdinate"></see>
    /// </summary>
    let superOrdinate = _prefix "superOrdinate"
