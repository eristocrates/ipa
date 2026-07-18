namespace http.purl.org.iso25964.skos_thes.hash

open DoxAletheia.Rdf_Vocabulary

module iso_thes =
    let _namespace_name = "http://purl.org/iso25964/skos-thes#"

    /// <summary>
    /// ISO PreferredTerm:
    ///
    /// Instances of iso-thes:PreferredTerm are objects of skos-xl:prefLabel statements.
    ///
    /// Making the class explicit allows RDF/OWL consistency checks for CompoundEquivalence.
    /// <see href="http://purl.org/iso25964/skos-thes#PreferredTerm"></see></summary>
    let PreferredTerm =
        Namespaced_IRI.parse _namespace_name "PreferredTerm" |> NamespacedName

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
    let SimpleNonPreferredTerm =
        Namespaced_IRI.parse _namespace_name "SimpleNonPreferredTerm" |> NamespacedName

    /// <summary>
    /// iso SplitNonPreferredTerm
    ///
    /// This class provides for an 'imagined' concept that may exist in a user’s mind but is not present in the thesaurus (Concept Scheme); it can, however, be represented by a combination of two or more preferred terms (skos-xl:prefLabel) in the thesaurus. (In contrast, concepts present in the thesaurus are provided for by the ThesaurusConcept class.)
    /// This label is provided by the object property iso thes:plusUF
    /// - domain: iso-thes:CompoundEquivalence
    /// - range: iso-thes:SplitNonPreferredTerm.
    /// <see href="http://purl.org/iso25964/skos-thes#SplitNonPreferredTerm"></see></summary>
    let SplitNonPreferredTerm =
        Namespaced_IRI.parse _namespace_name "SplitNonPreferredTerm" |> NamespacedName

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
    let CompoundEquivalence =
        Namespaced_IRI.parse _namespace_name "CompoundEquivalence" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#plusUF"></see>
    /// </summary>
    let plusUF = Namespaced_IRI.parse _namespace_name "plusUF" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#plusUse"></see>
    /// </summary>
    let plusUse = Namespaced_IRI.parse _namespace_name "plusUse" |> NamespacedName

    /// <summary>
    /// ISO ConceptGroup
    ///
    /// Concept groups have several applications.
    ///
    /// One such application is illustrated by the EUROVOC and the UNESCO thesaurus.  Both of these use a super structure of domain and of micro-thesaurus.  Both of these structuring elements can be modeled using ConceptGroup.
    /// <see href="http://purl.org/iso25964/skos-thes#ConceptGroup"></see></summary>
    let ConceptGroup =
        Namespaced_IRI.parse _namespace_name "ConceptGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#ThesaurusArray"></see>
    /// </summary>
    let ThesaurusArray =
        Namespaced_IRI.parse _namespace_name "ThesaurusArray" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#broaderGeneric"></see>
    /// </summary>
    let broaderGeneric =
        Namespaced_IRI.parse _namespace_name "broaderGeneric" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#broaderInstantial"></see>
    /// </summary>
    let broaderInstantial =
        Namespaced_IRI.parse _namespace_name "broaderInstantial" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#broaderPartitive"></see>
    /// </summary>
    let broaderPartitive =
        Namespaced_IRI.parse _namespace_name "broaderPartitive" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#microThesaurusOf"></see>
    /// </summary>
    let microThesaurusOf =
        Namespaced_IRI.parse _namespace_name "microThesaurusOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#narrowerGeneric"></see>
    /// </summary>
    let narrowerGeneric =
        Namespaced_IRI.parse _namespace_name "narrowerGeneric" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#narrowerInstantial"></see>
    /// </summary>
    let narrowerInstantial =
        Namespaced_IRI.parse _namespace_name "narrowerInstantial" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#narrowerPartitive"></see>
    /// </summary>
    let narrowerPartitive =
        Namespaced_IRI.parse _namespace_name "narrowerPartitive" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#plusUFTerm"></see>
    /// </summary>
    let plusUFTerm = Namespaced_IRI.parse _namespace_name "plusUFTerm" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#plusUseTerm"></see>
    /// </summary>
    let plusUseTerm =
        Namespaced_IRI.parse _namespace_name "plusUseTerm" |> NamespacedName

    /// <summary>
    /// ISO status
    /// - on ThesaurusConcept
    /// - on ThesaurusTerm
    /// <see href="http://purl.org/iso25964/skos-thes#status"></see></summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#subGroup"></see>
    /// </summary>
    let subGroup = Namespaced_IRI.parse _namespace_name "subGroup" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#superGroup"></see>
    /// </summary>
    let superGroup = Namespaced_IRI.parse _namespace_name "superGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#subordinateArray"></see>
    /// </summary>
    let subordinateArray =
        Namespaced_IRI.parse _namespace_name "subordinateArray" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/iso25964/skos-thes#superOrdinate"></see>
    /// </summary>
    let superOrdinate =
        Namespaced_IRI.parse _namespace_name "superOrdinate" |> NamespacedName
