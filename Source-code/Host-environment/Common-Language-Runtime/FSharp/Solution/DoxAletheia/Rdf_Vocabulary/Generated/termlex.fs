namespace https.termlex.oeg.fi.upm.es.termlex.hash

open DoxAletheia.Rdf_Vocabulary

module termlex =
    let _namespace_name = "https://termlex.oeg.fi.upm.es/termlex#"
    /// <summary>
    ///   <see href="https://termlex.oeg.fi.upm.es/termlex#1"></see>
    /// </summary>
    let _1 = Namespaced_IRI.parse _namespace_name "1" |> NamespacedName

    /// <summary>
    /// The ReliabilityCode class represents the trustworthiness degree of a determined resource, may it be a concept, a term or any other entity. This class points at a fixed set of values, from 1 to 5, for standardisation purposes.
    ///
    /// <see href="https://termlex.oeg.fi.upm.es/termlex#ReliabilityCode"></see></summary>
    let ReliabilityCode =
        Namespaced_IRI.parse _namespace_name "ReliabilityCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://termlex.oeg.fi.upm.es/termlex#2"></see>
    /// </summary>
    let _2 = Namespaced_IRI.parse _namespace_name "2" |> NamespacedName
    /// <summary>
    ///   <see href="https://termlex.oeg.fi.upm.es/termlex#3"></see>
    /// </summary>
    let _3 = Namespaced_IRI.parse _namespace_name "3" |> NamespacedName
    /// <summary>
    ///   <see href="https://termlex.oeg.fi.upm.es/termlex#4"></see>
    /// </summary>
    let _4 = Namespaced_IRI.parse _namespace_name "4" |> NamespacedName
    /// <summary>
    ///   <see href="https://termlex.oeg.fi.upm.es/termlex#5"></see>
    /// </summary>
    let _5 = Namespaced_IRI.parse _namespace_name "5" |> NamespacedName
    /// <summary>
    /// The Definition class represents the description of a resource, may it be a concept, a term or any other entity. Additional information can be attached to it, such as the source and authorship of the definition.
    /// <see href="https://termlex.oeg.fi.upm.es/termlex#Definition"></see></summary>
    let Definition = Namespaced_IRI.parse _namespace_name "Definition" |> NamespacedName
    /// <summary>
    /// The Note class represents additional information given about a resource, may it be a concept, a term or any other entity. Oher data can be attached to it, such as the source and authorship of the note.
    /// <see href="https://termlex.oeg.fi.upm.es/termlex#Note"></see></summary>
    let Note = Namespaced_IRI.parse _namespace_name "Note" |> NamespacedName
    /// <summary>
    /// The Source class represents the provenance information of an element, may it be the authorship, notes or other sources.
    /// <see href="https://termlex.oeg.fi.upm.es/termlex#Source"></see></summary>
    let Source = Namespaced_IRI.parse _namespace_name "Source" |> NamespacedName

    /// <summary>
    /// The TerminologicalConcept class represents a mental abstraction, concept or unit of thought that embodies the meaning of one or more lexical entries, that refer to the same lexical sense, thus, belong to the same area of epertise.
    /// <see href="https://termlex.oeg.fi.upm.es/termlex#TerminologicalConcept"></see></summary>
    let TerminologicalConcept =
        Namespaced_IRI.parse _namespace_name "TerminologicalConcept" |> NamespacedName

    /// <summary>
    /// The Usage class represents usage notes, advices or indications regarding the lexical sense of a given terminological concept.
    /// <see href="https://termlex.oeg.fi.upm.es/termlex#Usage"></see></summary>
    let Usage = Namespaced_IRI.parse _namespace_name "Usage" |> NamespacedName
    /// <summary>
    /// The concept property relates an ontological entity to a terminological concept that represents the corresponding meaning.
    /// <see href="https://termlex.oeg.fi.upm.es/termlex#concept"></see></summary>
    let concept = Namespaced_IRI.parse _namespace_name "concept" |> NamespacedName

    /// <summary>
    /// The isConceptOf property relates the meaning of a Terminological Concept by linking it to a particular ontological meaning.
    /// <see href="https://termlex.oeg.fi.upm.es/termlex#isConceptOf"></see></summary>
    let isConceptOf =
        Namespaced_IRI.parse _namespace_name "isConceptOf" |> NamespacedName

    /// <summary>
    /// The evokes property relates a lexical entry to the terminological concepts it evokes.
    /// <see href="https://termlex.oeg.fi.upm.es/termlex#evokes"></see></summary>
    let evokes = Namespaced_IRI.parse _namespace_name "evokes" |> NamespacedName
    /// <summary>
    /// The isEvokedBy property relates a terminological concept to one of the lexical entries that evoke it.
    /// <see href="https://termlex.oeg.fi.upm.es/termlex#isEvokedBy"></see></summary>
    let isEvokedBy = Namespaced_IRI.parse _namespace_name "isEvokedBy" |> NamespacedName

    /// <summary>
    /// The isLexicalizedSense property relates a lexical sense to a unique corresponding terminological concept.
    /// <see href="https://termlex.oeg.fi.upm.es/termlex#isLexicalizedSenseOf"></see></summary>
    let isLexicalizedSenseOf =
        Namespaced_IRI.parse _namespace_name "isLexicalizedSenseOf" |> NamespacedName

    /// <summary>
    /// The lexicalizedSense property relates a terminological concept to a unique corresponding lexical sense.
    /// <see href="https://termlex.oeg.fi.upm.es/termlex#lexicalizedSense"></see></summary>
    let lexicalizedSense =
        Namespaced_IRI.parse _namespace_name "lexicalizedSense" |> NamespacedName

    /// <summary>
    /// The reliabilityCode property relates a lexical sense to the the reliability code class.
    /// <see href="https://termlex.oeg.fi.upm.es/termlex#reliabilityCode"></see></summary>
    let reliabilityCode =
        Namespaced_IRI.parse _namespace_name "reliabilityCode" |> NamespacedName
