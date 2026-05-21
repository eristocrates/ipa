#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RDFErgonomics.fsx"
open RDFErgonomics

module termlex =

    let _prefix = prefix_label "termlex"


    let one = _prefix "1"



    let two = _prefix "2"



    let three = _prefix "3"



    let four = _prefix "4"



    let five = _prefix "5"


    /// The Definition class represents the description of a resource, may it be a concept, a term or any other entity. Additional information can be attached to it, such as the source and authorship of the definition.
    let Definition = _prefix "Definition"


    /// The Note class represents additional information given about a resource, may it be a concept, a term or any other entity. Oher data can be attached to it, such as the source and authorship of the note.
    let Note = _prefix "Note"


    /// The ReliabilityCode class represents the trustworthiness degree of a determined resource, may it be a concept, a term or any other entity. This class points at a fixed set of values, from 1 to 5, for standardisation purposes.
    ///
    let ReliabilityCode = _prefix "ReliabilityCode"


    /// The Source class represents the provenance information of an element, may it be the authorship, notes or other sources.
    let Source = _prefix "Source"


    /// The TerminologicalConcept class represents a mental abstraction, concept or unit of thought that embodies the meaning of one or more lexical entries, that refer to the same lexical sense, thus, belong to the same area of epertise.
    let TerminologicalConcept = _prefix "TerminologicalConcept"


    /// The Usage class represents usage notes, advices or indications regarding the lexical sense of a given terminological concept.
    let Usage = _prefix "Usage"


    /// The concept property relates an ontological entity to a terminological concept that represents the corresponding meaning.
    let concept = _prefix "concept"


    /// The evokes property relates a lexical entry to the terminological concepts it evokes.
    let evokes = _prefix "evokes"


    /// The isConceptOf property relates the meaning of a Terminological Concept by linking it to a particular ontological meaning.
    let isConceptOf = _prefix "isConceptOf"


    /// The isEvokedBy property relates a terminological concept to one of the lexical entries that evoke it.
    let isEvokedBy = _prefix "isEvokedBy"


    /// The isLexicalizedSense property relates a lexical sense to a unique corresponding terminological concept.
    let isLexicalizedSenseOf = _prefix "isLexicalizedSenseOf"


    /// The lexicalizedSense property relates a terminological concept to a unique corresponding lexical sense.
    let lexicalizedSense = _prefix "lexicalizedSense"


    /// The reliabilityCode property relates a lexical sense to the the reliability code class.
    let reliabilityCode = _prefix "reliabilityCode"
