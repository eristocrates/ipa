#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RDFErgonomics.fsx"
open RDFErgonomics

module ontolex =

    let _prefix = prefix_label "ontolex"

    /// An affix is a lexical entry that represents a morpheme (suffix, prefix, infix, circumfix) that is attached to a word stem to form a new word.
    let Affix = _prefix "Affix"


    let ConceptSet = _prefix "ConceptSet"


    /// A form represents one grammatical realization of a lexical entry.
    let Form = _prefix "Form"


    let LexicalConcept = _prefix "LexicalConcept"


    /// A lexical entry represents a unit of analysis of the lexicon that consists of a set of forms that are grammatically related and a set of base meanings that are associated with all of these forms. Thus, a lexical entry is a word, multiword expression or affix with a single part-of-speech, morphological pattern, etymology and set of senses.
    let LexicalEntry = _prefix "LexicalEntry"


    /// A lexical sense represents the lexical meaning of a lexical entry when interpreted as referring to the corresponding ontology element. A lexical sense thus represents a reification of a pair of a uniquely determined lexical entry and a uniquely determined ontology entity it refers to. A link between a lexical entry and an ontology entity via a Lexical Sense object implies that the lexical entry can be used to refer to the ontology entity in question.
    let LexicalSense = _prefix "LexicalSense"


    let MultiWordExpression = _prefix "MultiWordExpression"


    let Word = _prefix "Word"


    let canonicalForm = _prefix "canonicalForm"


    /// The 'concept' property relates an ontological entity to a lexical concept that represents the corresponding meaning.
    let concept = _prefix "concept"


    let denotes = _prefix "denotes"


    let evokes = _prefix "evokes"


    let isConceptOf = _prefix "isConceptOf"


    /// The object property isDenotedBy is the inverse of the object property denotes.
    let isDenotedBy = _prefix "isDenotedBy"


    /// The inverse relation to evokes.
    let isEvokedBy = _prefix "isEvokedBy"


    /// The object property isLexicalizedSenseOf is the inverse property of lexicalized sense.
    let isLexicalizedSenseOf = _prefix "isLexicalizedSenseOf"


    /// The object property isReferenceOf is the inverse property of reference.
    let isReferenceOf = _prefix "isReferenceOf"


    /// The property isSenseOf is the inverse property of sense.
    let isSenseOf = _prefix "isSenseOf"


    /// The 'lexical form' property relates a lexical entry to one grammatical form variant of the lexical entry.
    let lexicalForm = _prefix "lexicalForm"


    let lexicalizedSense = _prefix "lexicalizedSense"


    /// The 'morphological pattern' property indicates the morphological class of a word.
    let morphologicalPattern = _prefix "morphologicalPattern"


    /// The  'other form' property relates a lexical entry to a non-preferred ("non-lemma") form that realizes the given lexical entry.
    let otherForm = _prefix "otherForm"


    let phoneticRep = _prefix "phoneticRep"


    let reference = _prefix "reference"


    /// The 'representation' property indicates a string by which the form is represented according to some orthography.
    let representation = _prefix "representation"


    /// The 'sense' property relates a lexical entry to one of its lexical senses.
    let sense = _prefix "sense"


    /// The 'usage' property indicates usage conditions or pragmatic implications when using the lexical entry to refer to the given ontological meaning.
    let usage = _prefix "usage"


    let writtenRep = _prefix "writtenRep"
