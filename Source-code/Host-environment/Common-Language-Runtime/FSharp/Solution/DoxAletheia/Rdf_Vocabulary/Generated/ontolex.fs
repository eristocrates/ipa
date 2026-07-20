namespace http.www.w3.org.ns.lemon.ontolex.hash

open DoxAletheia

module ontolex =
    let _namespace_name = "http://www.w3.org/ns/lemon/ontolex#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An affix is a lexical entry that represents a morpheme (suffix, prefix, infix, circumfix) that is attached to a word stem to form a new word.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#Affix"></see></summary>
    let Affix = _prefix "Affix"
    /// <summary>
    /// A lexical entry represents a unit of analysis of the lexicon that consists of a set of forms that are grammatically related and a set of base meanings that are associated with all of these forms. Thus, a lexical entry is a word, multiword expression or affix with a single part-of-speech, morphological pattern, etymology and set of senses.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#LexicalEntry"></see></summary>
    let LexicalEntry = _prefix "LexicalEntry"
    /// <summary>
    /// A concept set represents a collection of lexical concepts.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#ConceptSet"></see></summary>
    let ConceptSet = _prefix "ConceptSet"
    /// <summary>
    /// A lexical concept represents a mental abstraction, concept or unit of thought that embodies the meaning of one or more lexical entries.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#LexicalConcept"></see></summary>
    let LexicalConcept = _prefix "LexicalConcept"
    /// <summary>
    /// A form represents one grammatical realization of a lexical entry.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#Form"></see></summary>
    let Form = _prefix "Form"
    /// <summary>
    /// The 'written representation' property indicates the written representation of a form.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#writtenRep"></see></summary>
    let writtenRep = _prefix "writtenRep"
    /// <summary>
    /// The 'lexical form' property relates a lexical entry to one grammatical form variant of the lexical entry.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#lexicalForm"></see></summary>
    let lexicalForm = _prefix "lexicalForm"
    /// <summary>
    /// The 'canonical form' property relates a lexical entry to its canoncical or dictionary form. This usually indicates the "lemma" form of a lexical entry.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#canonicalForm"></see></summary>
    let canonicalForm = _prefix "canonicalForm"
    /// <summary>
    /// A lexical sense represents the lexical meaning of a lexical entry when interpreted as referring to the corresponding ontology element. A lexical sense thus represents a reification of a pair of a uniquely determined lexical entry and a uniquely determined ontology entity it refers to. A link between a lexical entry and an ontology entity via a Lexical Sense object implies that the lexical entry can be used to refer to the ontology entity in question.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#LexicalSense"></see></summary>
    let LexicalSense = _prefix "LexicalSense"
    /// <summary>
    /// The property isSenseOf is the inverse property of sense.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#isSenseOf"></see></summary>
    let isSenseOf = _prefix "isSenseOf"
    /// <summary>
    /// The 'reference' property relates a lexical sense to an ontological predicate that represents the denotation of the corresponding lexical entry.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#reference"></see></summary>
    let reference = _prefix "reference"
    /// <summary>
    /// A multiword expression is a lexical entry that consists of two or more words.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#MultiWordExpression"></see></summary>
    let MultiWordExpression = _prefix "MultiWordExpression"
    /// <summary>
    /// A word is a lexical entry that consists of a single token.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#Word"></see></summary>
    let Word = _prefix "Word"
    /// <summary>
    /// The 'concept' property relates an ontological entity to a lexical concept that represents the corresponding meaning.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#concept"></see></summary>
    let concept = _prefix "concept"
    /// <summary>
    /// This property formalizes the meaning of a Lexical Concept by linking it to a particular ontological meaning.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#isConceptOf"></see></summary>
    let isConceptOf = _prefix "isConceptOf"
    /// <summary>
    /// The 'denotes' property relates a lexical entry to a predicate in a given ontology that represents its meaning and has some denotational or model-theoretic semantics.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#denotes"></see></summary>
    let denotes = _prefix "denotes"
    /// <summary>
    /// The 'sense' property relates a lexical entry to one of its lexical senses.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#sense"></see></summary>
    let sense = _prefix "sense"
    /// <summary>
    /// The 'evokes' property relates a lexical entry to one of the lexical concepts it evokes, i.e. the mental concept that speakers of a language might associate when hearing the lexical entry.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#evokes"></see></summary>
    let evokes = _prefix "evokes"
    /// <summary>
    /// The object property isLexicalizedSenseOf is the inverse property of lexicalized sense.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#isLexicalizedSenseOf"></see></summary>
    let isLexicalizedSenseOf = _prefix "isLexicalizedSenseOf"
    /// <summary>
    /// The object property isDenotedBy is the inverse of the object property denotes.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#isDenotedBy"></see></summary>
    let isDenotedBy = _prefix "isDenotedBy"
    /// <summary>
    /// The inverse relation to evokes.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#isEvokedBy"></see></summary>
    let isEvokedBy = _prefix "isEvokedBy"
    /// <summary>
    /// The 'lexicalized sense' property relates a lexical concept to a corresponding lexical sense that lexicalizes the concept.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#lexicalizedSense"></see></summary>
    let lexicalizedSense = _prefix "lexicalizedSense"
    /// <summary>
    /// The object property isReferenceOf is the inverse property of reference.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#isReferenceOf"></see></summary>
    let isReferenceOf = _prefix "isReferenceOf"
    /// <summary>
    /// The 'morphological pattern' property indicates the morphological class of a word.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#morphologicalPattern"></see></summary>
    let morphologicalPattern = _prefix "morphologicalPattern"
    /// <summary>
    /// The  'other form' property relates a lexical entry to a non-preferred ("non-lemma") form that realizes the given lexical entry.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#otherForm"></see></summary>
    let otherForm = _prefix "otherForm"
    /// <summary>
    /// The 'phonetic representation' property indicates one phonetic representation of the pronunciation of the form using a scheme such as the International Phonetic Alphabet (IPA).
    /// <see href="http://www.w3.org/ns/lemon/ontolex#phoneticRep"></see></summary>
    let phoneticRep = _prefix "phoneticRep"
    /// <summary>
    /// The 'representation' property indicates a string by which the form is represented according to some orthography.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#representation"></see></summary>
    let representation = _prefix "representation"
    /// <summary>
    /// The 'usage' property indicates usage conditions or pragmatic implications when using the lexical entry to refer to the given ontological meaning.
    /// <see href="http://www.w3.org/ns/lemon/ontolex#usage"></see></summary>
    let usage = _prefix "usage"
