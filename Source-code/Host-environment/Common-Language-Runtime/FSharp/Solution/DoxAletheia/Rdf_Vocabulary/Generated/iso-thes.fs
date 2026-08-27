namespace http.purl.org.iso25964.skos_thes.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module iso_thes =
    let _namespace_iri = Namespace_Iri iso_thes |> NamespaceIRI

    /// <summary>
    ///   <para>iso-thes:CompoundEquivalence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ISO CompoundEquivalence
    ///
    /// iso-thes:plusUseTerm (and its inverse iso-thes:plusUFTerm) may be derived from iso-thes:CompoundEquivalence.
    ///
    /// For a iso-thes:CompoundEquivalence instance each derived iso thes:plusUseTerm has as:
    /// - subject: the iso thes:plusUF value
    /// - object: the iso thes:plusUse value
    ///
    /// An ISO 25964 compliant thesaurus only has one compound equivalence relation for each split non preferred term.
    ///
    /// In special cases where the iso-thes:SplitNonPreferredTerm has more than one decomposition, the inverse inference may not be possible.   (While this situation should not arise within a single thesaurus that complies with ISO 25964, it could occur if terms and relationships have been drawn from more than one thesaurus. For this reason the property skos:inScheme (http://www.w3.org/2004/02/skos/core#inScheme) should be used with each instance of the class Compound Equivalence, to relate it to its Thesaurus.)"</para>
    /// labels<para>"Compound Equivalence"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#CompoundEquivalence">http://purl.org/iso25964/skos-thes#CompoundEquivalence</seealso>
    let CompoundEquivalence =
        Prefixed_Name(iso_thes, "CompoundEquivalence") |> PrefixedName

    /// <summary>
    ///   <para>iso-thes:ConceptGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ISO ConceptGroup
    ///
    /// Concept groups have several applications.
    ///
    /// One such application is illustrated by the EUROVOC and the UNESCO thesaurus.  Both of these use a super structure of domain and of micro-thesaurus.  Both of these structuring elements can be modeled using ConceptGroup."</para>
    /// labels<para>"Concept Group"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#ConceptGroup">http://purl.org/iso25964/skos-thes#ConceptGroup</seealso>
    let ConceptGroup = Prefixed_Name(iso_thes, "ConceptGroup") |> PrefixedName
    /// <summary>
    ///   <para>iso-thes:PreferredTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ISO PreferredTerm:
    ///
    /// Instances of iso-thes:PreferredTerm are objects of skos-xl:prefLabel statements.
    ///
    /// Making the class explicit allows RDF/OWL consistency checks for CompoundEquivalence."</para>
    ///   <para>"By ESCO: Not directly set by ESCO applications, but inferred from the range of skos-xl:pref:Label or iso-thes:plusUse."</para>
    /// labels<para>"Preferred Term"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#PreferredTerm">http://purl.org/iso25964/skos-thes#PreferredTerm</seealso>
    let PreferredTerm = Prefixed_Name(iso_thes, "PreferredTerm") |> PrefixedName

    /// <summary>
    ///   <para>iso-thes:SimpleNonPreferredTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ISO SimpleNonPreferredTerm
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
    /// - the altLabel and hiddenLabel have the role UF."</para>
    ///   <para>"By ESCO: Not directly set by ESCO applications, but inferred from the range of skos-xl:alt:Label."</para>
    /// labels<para>"Simple Non Preferred Term"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#SimpleNonPreferredTerm">http://purl.org/iso25964/skos-thes#SimpleNonPreferredTerm</seealso>
    let SimpleNonPreferredTerm =
        Prefixed_Name(iso_thes, "SimpleNonPreferredTerm") |> PrefixedName

    /// <summary>
    ///   <para>iso-thes:SplitNonPreferredTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"By ESCO: Captures the compound terms established by the ESCO taxonomists."</para>
    ///   <para>"iso SplitNonPreferredTerm
    ///
    /// This class provides for an 'imagined' concept that may exist in a user’s mind but is not present in the thesaurus (Concept Scheme); it can, however, be represented by a combination of two or more preferred terms (skos-xl:prefLabel) in the thesaurus. (In contrast, concepts present in the thesaurus are provided for by the ThesaurusConcept class.)
    /// This label is provided by the object property iso thes:plusUF
    /// - domain: iso-thes:CompoundEquivalence
    /// - range: iso-thes:SplitNonPreferredTerm."</para>
    /// labels<para>"Split Non Preferred Term"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#SplitNonPreferredTerm">http://purl.org/iso25964/skos-thes#SplitNonPreferredTerm</seealso>
    let SplitNonPreferredTerm =
        Prefixed_Name(iso_thes, "SplitNonPreferredTerm") |> PrefixedName

    /// <summary>
    ///   <para>iso-thes:ThesaurusArray</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Thesaurus Array"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#ThesaurusArray">http://purl.org/iso25964/skos-thes#ThesaurusArray</seealso>
    let ThesaurusArray = Prefixed_Name(iso_thes, "ThesaurusArray") |> PrefixedName
    /// <summary>
    ///   <para>iso-thes:broaderGeneric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"broader term (generic)"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#broaderGeneric">http://purl.org/iso25964/skos-thes#broaderGeneric</seealso>
    let broaderGeneric = Prefixed_Name(iso_thes, "broaderGeneric") |> PrefixedName
    /// <summary>
    ///   <para>iso-thes:broaderInstantial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"broader term (instantial)"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#broaderInstantial">http://purl.org/iso25964/skos-thes#broaderInstantial</seealso>
    let broaderInstantial = Prefixed_Name(iso_thes, "broaderInstantial") |> PrefixedName
    /// <summary>
    ///   <para>iso-thes:broaderPartitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"broader term (partitive)"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#broaderPartitive">http://purl.org/iso25964/skos-thes#broaderPartitive</seealso>
    let broaderPartitive = Prefixed_Name(iso_thes, "broaderPartitive") |> PrefixedName
    /// <summary>
    ///   <para>iso-thes:microThesaurusOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"micro-thesaurus of"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#microThesaurusOf">http://purl.org/iso25964/skos-thes#microThesaurusOf</seealso>
    let microThesaurusOf = Prefixed_Name(iso_thes, "microThesaurusOf") |> PrefixedName
    /// <summary>
    ///   <para>iso-thes:narrowerGeneric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"narrower term (generic)"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#narrowerGeneric">http://purl.org/iso25964/skos-thes#narrowerGeneric</seealso>
    let narrowerGeneric = Prefixed_Name(iso_thes, "narrowerGeneric") |> PrefixedName

    /// <summary>
    ///   <para>iso-thes:narrowerInstantial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"narrower term (instantial)"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#narrowerInstantial">http://purl.org/iso25964/skos-thes#narrowerInstantial</seealso>
    let narrowerInstantial =
        Prefixed_Name(iso_thes, "narrowerInstantial") |> PrefixedName

    /// <summary>
    ///   <para>iso-thes:narrowerPartitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"narrower term (partitive)"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#narrowerPartitive">http://purl.org/iso25964/skos-thes#narrowerPartitive</seealso>
    let narrowerPartitive = Prefixed_Name(iso_thes, "narrowerPartitive") |> PrefixedName
    /// <summary>
    ///   <para>iso-thes:plusUF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"split non preferred term"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#plusUF">http://purl.org/iso25964/skos-thes#plusUF</seealso>
    let plusUF = Prefixed_Name(iso_thes, "plusUF") |> PrefixedName
    /// <summary>
    ///   <para>iso-thes:plusUFTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"UF+"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#plusUFTerm">http://purl.org/iso25964/skos-thes#plusUFTerm</seealso>
    let plusUFTerm = Prefixed_Name(iso_thes, "plusUFTerm") |> PrefixedName
    /// <summary>
    ///   <para>iso-thes:plusUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"component preferred term"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#plusUse">http://purl.org/iso25964/skos-thes#plusUse</seealso>
    let plusUse = Prefixed_Name(iso_thes, "plusUse") |> PrefixedName
    /// <summary>
    ///   <para>iso-thes:plusUseTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"USE+"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#plusUseTerm">http://purl.org/iso25964/skos-thes#plusUseTerm</seealso>
    let plusUseTerm = Prefixed_Name(iso_thes, "plusUseTerm") |> PrefixedName
    /// <summary>
    ///   <para>iso-thes:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"ISO status
    /// - on ThesaurusConcept
    /// - on ThesaurusTerm"</para>
    /// labels<para>"status"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#status">http://purl.org/iso25964/skos-thes#status</seealso>
    let status = Prefixed_Name(iso_thes, "status") |> PrefixedName
    /// <summary>
    ///   <para>iso-thes:subGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"sub group"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#subGroup">http://purl.org/iso25964/skos-thes#subGroup</seealso>
    let subGroup = Prefixed_Name(iso_thes, "subGroup") |> PrefixedName
    /// <summary>
    ///   <para>iso-thes:subordinateArray</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"subordinate array"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#subordinateArray">http://purl.org/iso25964/skos-thes#subordinateArray</seealso>
    let subordinateArray = Prefixed_Name(iso_thes, "subordinateArray") |> PrefixedName
    /// <summary>
    ///   <para>iso-thes:superGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"super group"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#superGroup">http://purl.org/iso25964/skos-thes#superGroup</seealso>
    let superGroup = Prefixed_Name(iso_thes, "superGroup") |> PrefixedName
    /// <summary>
    ///   <para>iso-thes:superOrdinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"super ordinate"</para></remarks>
    /// <seealso href="http://purl.org/iso25964/skos-thes#superOrdinate">http://purl.org/iso25964/skos-thes#superOrdinate</seealso>
    let superOrdinate = Prefixed_Name(iso_thes, "superOrdinate") |> PrefixedName
