#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``iso-thes`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/iso25964/skos-thes#" "iso-thes"

    /// <summary>
    ///   <para>dcterms:modified : 2013-12-09^^xsd:date</para>
    ///   <para>rdfs:comment : ISO CompoundEquivalence
    ///
    /// iso-thes:plusUseTerm (and its inverse iso-thes:plusUFTerm) may be derived from iso-thes:CompoundEquivalence.
    ///
    /// For a iso-thes:CompoundEquivalence instance each derived iso thes:plusUseTerm has as:
    /// - subject: the iso thes:plusUF value
    /// - object: the iso thes:plusUse value
    ///
    /// An ISO 25964 compliant thesaurus only has one compound equivalence relation for each split non preferred term.
    ///
    /// In special cases where the iso-thes:SplitNonPreferredTerm has more than one decomposition, the inverse inference may not be possible.   (While this situation should not arise within a single thesaurus that complies with ISO 25964, it could occur if terms and relationships have been drawn from more than one thesaurus. For this reason the property skos:inScheme (http://www.w3.org/2004/02/skos/core#inScheme) should be used with each instance of the class Compound Equivalence, to relate it to its Thesaurus.)</para>
    ///   <para>rdfs:label : Compound Equivalence</para>
    ///   <para>vs:term_status : released^^xsd:string</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#CompoundEquivalence">iso-thes:CompoundEquivalence</a>
    /// </summary>
    let CompoundEquivalence = _prefixId.prefix "CompoundEquivalence"
    /// <summary>
    ///   <para>dcterms:modified : 2013-12-09^^xsd:date</para>
    ///   <para>skos:definition : Definition: A concept group is a group of concepts making up a subset of the thesaurus. Member concepts may be drawn from many different facets or hierarchies of the thesaurus. While almost any criterion may be used to select the members, this construct is commonly used to define a micro-thesaurus that will be used by a particular user group or domain.
    ///
    /// The skos:inScheme (http://www.w3.org/2004/02/skos/core#inScheme) property should be used to indicate the thesaurus to which an instance of skos:Collection applies (see ISO 25964: isPartOf).
    ///
    /// Use rdfs:label or xl:prefLabel for the ConceptGroup label (1 per language).
    /// Optional label attributes typically are mapped to dc: (or dct:) properties:
    /// - dct:created
    /// - dct:modified
    /// These can be attached to the xl:Label instance that is the value of the xl:prefLabel.
    ///
    /// Depending on the value of the ISO conceptGroupType a sub-class of iso thes:ConceptGroup should be defined.
    /// e.g.: EUROVOC and UNESCO use
    /// - Domain
    /// - MicroThesaurus (an iso-thes:hasSubGroup of a Domain)</para>
    ///   <para>rdfs:comment : ISO ConceptGroup
    ///
    /// Concept groups have several applications.
    ///
    /// One such application is illustrated by the EUROVOC and the UNESCO thesaurus.  Both of these use a super structure of domain and of micro-thesaurus.  Both of these structuring elements can be modeled using ConceptGroup.</para>
    ///   <para>rdfs:label : Concept Group</para>
    ///   <para>vs:term_status : released^^xsd:string</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#ConceptGroup">iso-thes:ConceptGroup</a>
    /// </summary>
    let ConceptGroup = _prefixId.prefix "ConceptGroup"
    /// <summary>
    ///   <para>dcterms:modified : 2013-12-09^^xsd:date</para>
    ///   <para>rdfs:comment : ISO PreferredTerm:
    ///
    /// Instances of iso-thes:PreferredTerm are objects of skos-xl:prefLabel statements.
    ///
    /// Making the class explicit allows RDF/OWL consistency checks for CompoundEquivalence.</para>
    ///   <para>rdfs:label : Preferred Term</para>
    ///   <para>vs:term_status : released^^xsd:string</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#PreferredTerm">iso-thes:PreferredTerm</a>
    /// </summary>
    let PreferredTerm = _prefixId.prefix "PreferredTerm"
    /// <summary>
    ///   <para>dcterms:modified : 2013-12-09^^xsd:date</para>
    ///   <para>rdfs:comment : ISO SimpleNonPreferredTerm
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
    /// - the altLabel and hiddenLabel have the role UF.</para>
    ///   <para>rdfs:label : Simple Non Preferred Term</para>
    ///   <para>vs:term_status : released^^xsd:string</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#SimpleNonPreferredTerm">iso-thes:SimpleNonPreferredTerm</a>
    /// </summary>
    let SimpleNonPreferredTerm = _prefixId.prefix "SimpleNonPreferredTerm"
    /// <summary>
    ///   <para>dcterms:modified : 2013-12-09^^xsd:date</para>
    ///   <para>rdfs:comment : iso SplitNonPreferredTerm
    ///
    /// This class provides for an 'imagined' concept that may exist in a user’s mind but is not present in the thesaurus (Concept Scheme); it can, however, be represented by a combination of two or more preferred terms (skos-xl:prefLabel) in the thesaurus. (In contrast, concepts present in the thesaurus are provided for by the ThesaurusConcept class.)
    /// This label is provided by the object property iso thes:plusUF
    /// - domain: iso-thes:CompoundEquivalence
    /// - range: iso-thes:SplitNonPreferredTerm.</para>
    ///   <para>rdfs:label : Split Non Preferred Term</para>
    ///   <para>vs:term_status : released^^xsd:string</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#SplitNonPreferredTerm">iso-thes:SplitNonPreferredTerm</a>
    /// </summary>
    let SplitNonPreferredTerm = _prefixId.prefix "SplitNonPreferredTerm"
    /// <summary>
    ///   <para>dcterms:modified : 2013-12-09^^xsd:date</para>
    ///   <para>skos:definition : Definition: ISO ThesaurusArray
    /// An array is a group of sibling concepts
    ///
    /// Instances of ThesaurusArray can be mapped to instances of skos:OrderedCollection (a subclass of skos:Collection) if and only if the array needs to be an ordered array (in the ISO-25964 model the value of its Boolean attribute "ordered" is true).
    /// It is advised to use the skos:inScheme (http://www.w3.org/2004/02/skos/core#inScheme) property on such a skos:Collection to relate it to its Thesaurus (see ISO 25964: isPartOf).
    ///
    /// Concepts in a thesaurus array are sibling concepts in the thesaurus.
    ///
    /// If present, the node label of a thesaurus array is mapped to rdfs:label or xl:prefLabel.
    /// Optional node label attributes typically are mapped to dc: (or dct:) properties:
    /// - dct:created
    /// - dct:modified
    /// These can be attached (if needed) to the xl:Label instance that is the value of xl:prefLabel.</para>
    ///   <para>rdfs:label : Thesaurus Array</para>
    ///   <para>vs:term_status : released^^xsd:string</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#ThesaurusArray">iso-thes:ThesaurusArray</a>
    /// </summary>
    let ThesaurusArray = _prefixId.prefix "ThesaurusArray"
    /// <summary>
    ///   <para>dcterms:modified : 2013-11-11^^xsd:date</para>
    ///   <para>skos:definition : Definition: ISO 25964-1: BTG
    /// The immediate (direct or one-step) class - generalized class relationship.</para>
    ///   <para>rdfs:label : broader term (generic)</para>
    ///   <para>vs:term_status : proposed^^xsd:string</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#broaderGeneric">iso-thes:broaderGeneric</a>
    /// </summary>
    let broaderGeneric = _prefixId.prefix "broaderGeneric"
    /// <summary>
    ///   <para>skos:changeNote : The URI has been renamed: #broaderInstantive is replaced by #broaderInstantial according to the observed usage of these words in English. (2013-12-09)</para>
    ///   <para>skos:definition : Definition: ISO 25964-1: BTI
    /// The immediate (direct or one-step) instance - class relationship.</para>
    ///   <para>dcterms:modified : 2013-12-09^^xsd:date</para>
    ///   <para>rdfs:label : broader term (instantial)</para>
    ///   <para>vs:term_status : proposed^^xsd:string</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#broaderInstantial">iso-thes:broaderInstantial</a>
    /// </summary>
    let broaderInstantial = _prefixId.prefix "broaderInstantial"
    /// <summary>
    ///   <para>dcterms:modified : 2013-11-18^^xsd:date</para>
    ///   <para>skos:example : A "bicycle wheel" for instance belongs uniquely to a "bicycle" while a "wheel" does not.
    /// A BTP/NTP relationship should not be established between "bicycles" and "wheels" because a wheel could be part of a motor car, a wheelbarrow or one of many other artefacts.</para>
    ///   <para>rdfs:label : broader term (partitive)</para>
    ///   <para>vs:term_status : proposed^^xsd:string</para>
    ///   <para>skos:definition : Definition: ISO 25964-1: BTP
    /// When the ISO 25964 standard is followed, the BTP/NTP relationship should qualify for a transitive closure.</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#broaderPartitive">iso-thes:broaderPartitive</a>
    /// </summary>
    let broaderPartitive = _prefixId.prefix "broaderPartitive"
    /// <summary>
    ///   <para>dcterms:modified : 2013-10-04^^xsd:date</para>
    ///   <para>skos:definition : Definition: Concept groups published as sub-thesauri (e.g., having micro-thesaurus as ISO conceptGroupType) </para>
    ///   <para>rdfs:label : micro-thesaurus of</para>
    ///   <para>vs:term_status : released^^xsd:string</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#microThesaurusOf">iso-thes:microThesaurusOf</a>
    /// </summary>
    let microThesaurusOf = _prefixId.prefix "microThesaurusOf"
    /// <summary>
    ///   <para>vs:term_status : proposed^^xsd:string</para>
    ///   <para>rdfs:label : narrower term (generic)</para>
    ///   <para>dcterms:modified : 2013-11-11^^xsd:date</para>
    ///   <para>skos:definition : Definition: ISO 25964-1: NTG
    /// The immediate (direct or one-step) class - specialized class relationship.</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#narrowerGeneric">iso-thes:narrowerGeneric</a>
    /// </summary>
    let narrowerGeneric = _prefixId.prefix "narrowerGeneric"
    /// <summary>
    ///   <para>dcterms:modified : 2013-12-09^^xsd:date</para>
    ///   <para>skos:definition : Definition: ISO 25964-1: NTI
    /// The immediate (direct or one-step) class - instance relationship.</para>
    ///   <para>skos:changeNote : The URI has been renamed: #narrowerInstantive is replaced by #narrowerInstantial according to the observed usage of these words in English. (2013-12-09)</para>
    ///   <para>vs:term_status : proposed^^xsd:string</para>
    ///   <para>rdfs:label : narrower term (instantial)</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#narrowerInstantial">iso-thes:narrowerInstantial</a>
    /// </summary>
    let narrowerInstantial = _prefixId.prefix "narrowerInstantial"
    /// <summary>
    ///   <para>skos:example : A "bicycle wheel" for instance belongs uniquely to a "bicycle" while a "wheel" does not.
    /// A BTP/NTP relationship should not be established between "bicycles" and "wheels" because a wheel could be part of a motor car, a wheelbarrow or one of many other artefacts.</para>
    ///   <para>vs:term_status : proposed^^xsd:string</para>
    ///   <para>skos:definition : Definition: ISO 25964-1: NTP
    /// When the ISO 25964 standard is followed, the BTP/NTP relationship should qualify for a transitive closure.</para>
    ///   <para>rdfs:label : narrower term (partitive)</para>
    ///   <para>dcterms:modified : 2013-11-18^^xsd:date</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#narrowerPartitive">iso-thes:narrowerPartitive</a>
    /// </summary>
    let narrowerPartitive = _prefixId.prefix "narrowerPartitive"
    /// <summary>
    ///   <para>dcterms:modified : 2013-10-04^^xsd:date</para>
    ///   <para>skos:definition : Definition: ISO 25964-1: UF+
    /// The non preferred term labeling a complex concept.
    /// The complex concept will be identified by splitting the non preferred term into 2 or more (component) preferred terms.</para>
    ///   <para>rdfs:label : split non preferred term</para>
    ///   <para>vs:term_status : released^^xsd:string</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#plusUF">iso-thes:plusUF</a>
    /// </summary>
    let plusUF = _prefixId.prefix "plusUF"
    /// <summary>
    ///   <para>dcterms:modified : 2013-12-09^^xsd:date</para>
    ///   <para>rdfs:label : UF+</para>
    ///   <para>skos:definition : Definition: ISO 25964-1: UF+
    /// The non-preferred term expressing a compound concept that should be represented by a combination of preferred terms</para>
    ///   <para>vs:term_status : released^^xsd:string</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#plusUFTerm">iso-thes:plusUFTerm</a>
    /// </summary>
    let plusUFTerm = _prefixId.prefix "plusUFTerm"
    /// <summary>
    ///   <para>dcterms:modified : 2013-10-04^^xsd:date</para>
    ///   <para>skos:scopeNote : ISO 25964-1: USE+
    /// One of two or more (component) preferred terms used together to represent the (complex) concept labeled by a (split) non preferred term.</para>
    ///   <para>rdfs:label : component preferred term</para>
    ///   <para>vs:term_status : released^^xsd:string</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#plusUse">iso-thes:plusUse</a>
    /// </summary>
    let plusUse = _prefixId.prefix "plusUse"
    /// <summary>
    ///   <para>dcterms:modified : 2013-10-04^^xsd:date</para>
    ///   <para>skos:scopeNote : iso-thes:plusUseTerm (and its inverse iso-thes:plusUFTerm) may be derived from iso-thes:CompoundEquivalence.
    ///
    /// For an iso-thes:CompoundEquivalence instance each derived iso-thes:plusUseTerm has as:
    /// - subject: the iso-thes:plusUF value
    /// - object: the iso-thes:plusUse value
    ///
    /// In special cases where the iso-thes:SplitNonPreferredTerm has more than one decomposition, the inverse inference may not be possible.
    /// </para>
    ///   <para>skos:definition : Definition: ISO 25964-1: USE+
    /// The two or more (component) preferred terms following should be used together to represent the concept indicated by the (split) non preferred term.</para>
    ///   <para>rdfs:label : USE+</para>
    ///   <para>vs:term_status : released^^xsd:string</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#plusUseTerm">iso-thes:plusUseTerm</a>
    /// </summary>
    let plusUseTerm = _prefixId.prefix "plusUseTerm"
    /// <summary>
    ///   <para>dcterms:modified : 2013-10-04^^xsd:date</para>
    ///   <para>rdfs:comment : ISO status
    /// - on ThesaurusConcept
    /// - on ThesaurusTerm</para>
    ///   <para>rdfs:label : status</para>
    ///   <para>vs:term_status : released^^xsd:string</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#status">iso-thes:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>skos:definition : Definition: All members of the (object) subGroup are members of the (subject) group.</para>
    ///   <para>rdfs:label : sub group</para>
    ///   <para>dcterms:modified : 2013-10-04^^xsd:date</para>
    ///   <para>vs:term_status : released^^xsd:string</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#subGroup">iso-thes:subGroup</a>
    /// </summary>
    let subGroup = _prefixId.prefix "subGroup"
    /// <summary>
    ///   <para>dcterms:modified : 2013-12-09^^xsd:date</para>
    ///   <para>skos:definition : Definition: Explicitly links a (superordinate) concept to one or more subordinate arrays. Each array may either be composed of narrower concepts of the superordinate concept (in which case there may be an associated node label with a characteristic of division) or by concepts that need not be narrower concepts of the superordinate concept (in which case a node label may provide a facet name).
    ///
    /// In other words, though each array only contains sibling concepts, no hierarchical relation may be automatically derived between a concept and the concepts in any of its subordinate arrays. The hierarchical relationship between these concepts has to be asserted explicitly.</para>
    ///   <para>rdfs:label : subordinate array</para>
    ///   <para>vs:term_status : released^^xsd:string</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#subordinateArray">iso-thes:subordinateArray</a>
    /// </summary>
    let subordinateArray = _prefixId.prefix "subordinateArray"
    /// <summary>
    ///   <para>dcterms:modified : 2013-11-11^^xsd:date</para>
    ///   <para>skos:definition : Definition: All members of the (subject) group are members of the (object) superGroup.</para>
    ///   <para>rdfs:label : super group</para>
    ///   <para>vs:term_status : released^^xsd:string</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#superGroup">iso-thes:superGroup</a>
    /// </summary>
    let superGroup = _prefixId.prefix "superGroup"
    /// <summary>
    ///   <para>dcterms:modified : 2013-11-09^^xsd:date</para>
    ///   <para>skos:definition : Definition: ISO 25964: hasSuperOrdinateConcept
    /// The (subject) array organizes a set of sibling concepts under the (object) concept.</para>
    ///   <para>rdfs:label : super ordinate</para>
    ///   <para>vs:term_status : released^^xsd:string</para>
    ///   <a href="http://purl.org/iso25964/skos-thes#superOrdinate">iso-thes:superOrdinate</a>
    /// </summary>
    let superOrdinate = _prefixId.prefix "superOrdinate"
