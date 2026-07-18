namespace http.www.w3.org.ns.lemon.vartrans.hash

open DoxAletheia.Rdf_Vocabulary

module vartrans =
    let _namespace_name = "http://www.w3.org/ns/lemon/vartrans#"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/lemon/vartrans#imports"></see>
    /// </summary>
    let imports = Namespaced_IRI.parse _namespace_name "imports" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/lemon/vartrans#versionInfo"></see>
    /// </summary>
    let versionInfo =
        Namespaced_IRI.parse _namespace_name "versionInfo" |> NamespacedName

    /// <summary>
    /// A relationship between two concepts
    /// <see href="http://www.w3.org/ns/lemon/vartrans#ConceptualRelation"></see></summary>
    let ConceptualRelation =
        Namespaced_IRI.parse _namespace_name "ConceptualRelation" |> NamespacedName

    /// <summary>
    /// A 'lexico-semantic relation' represents the relation between two lexical entries or lexical senses that are related by some lexical or semantic relationship.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#LexicoSemanticRelation"></see></summary>
    let LexicoSemanticRelation =
        Namespaced_IRI.parse _namespace_name "LexicoSemanticRelation" |> NamespacedName

    /// <summary>
    /// The 'relates' property links a lexico-semantic relation to the two lexical entries or lexical senses between which it establishes the relation.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#relates"></see></summary>
    let relates = Namespaced_IRI.parse _namespace_name "relates" |> NamespacedName

    /// <summary>
    /// A 'lexical relation' is a lexico-semantic relation that represents the relation between two lexical entries the surface forms of which are related grammatically, stylistically or by some operation motivated by linguistic economy.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#LexicalRelation"></see></summary>
    let LexicalRelation =
        Namespaced_IRI.parse _namespace_name "LexicalRelation" |> NamespacedName

    /// <summary>
    /// A 'sense relation' is a lexico-semantic relation that represents the relation between two lexical senses the meanings of which are related.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#SenseRelation"></see></summary>
    let SenseRelation =
        Namespaced_IRI.parse _namespace_name "SenseRelation" |> NamespacedName

    /// <summary>
    /// A 'terminological relation' is a sense relation that relates two lexical senses of terms that are semantically related in the sense that they can be exchanged in most contexts, but their surface forms are not directly related. The variants vary along dimensions that are not captured by the given ontology and are intentionally (pragmatically) caused.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#TerminologicalRelation"></see></summary>
    let TerminologicalRelation =
        Namespaced_IRI.parse _namespace_name "TerminologicalRelation" |> NamespacedName

    /// <summary>
    /// A 'translation' is a 'sense relation' expressing that two lexical senses corresponding to two lexical entries in different languages can be translated to each other without any major meaning shifts.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#Translation"></see></summary>
    let Translation =
        Namespaced_IRI.parse _namespace_name "Translation" |> NamespacedName

    /// <summary>
    /// The 'target' property indicates the lexical sense or lexical entry involved in a lexico-semantic relation as a 'target'.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#target"></see></summary>
    let target = Namespaced_IRI.parse _namespace_name "target" |> NamespacedName

    /// <summary>
    /// A 'translation set' is a set of translations that have some common source.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#TranslationSet"></see></summary>
    let TranslationSet =
        Namespaced_IRI.parse _namespace_name "TranslationSet" |> NamespacedName

    /// <summary>
    /// The 'category' property indicates the specific type of relation by which two lexical entries or two lexical senses are related.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#category"></see></summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName
    /// <summary>
    /// A relationship between two concepts
    /// <see href="http://www.w3.org/ns/lemon/vartrans#conceptRel"></see></summary>
    let conceptRel = Namespaced_IRI.parse _namespace_name "conceptRel" |> NamespacedName
    /// <summary>
    /// The 'lexicalRel' property relates two lexical entries that stand in some lexical relation.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#lexicalRel"></see></summary>
    let lexicalRel = Namespaced_IRI.parse _namespace_name "lexicalRel" |> NamespacedName
    /// <summary>
    /// The 'senseRel' property relates two lexical senses that stand in some sense relation.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#senseRel"></see></summary>
    let senseRel = Namespaced_IRI.parse _namespace_name "senseRel" |> NamespacedName
    /// <summary>
    /// The 'source' property indicates the lexical sense or lexical entry involved in a lexico-semantic relation as a 'source'.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#source"></see></summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName
    /// <summary>
    /// The property 'trans' relates a TranslationSet to one of its translations.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#trans"></see></summary>
    let trans = Namespaced_IRI.parse _namespace_name "trans" |> NamespacedName

    /// <summary>
    /// The 'translatableAs' property relates a lexical entry in some language to a lexical entry in another language that it can be translated as depending on the particular context and specific senses of the involved lexical entries.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#translatableAs"></see></summary>
    let translatableAs =
        Namespaced_IRI.parse _namespace_name "translatableAs" |> NamespacedName

    /// <summary>
    /// The 'translation' property relates two lexical senses of two lexical entries that stand in a translation relation to one another.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#translation"></see></summary>
    let translation =
        Namespaced_IRI.parse _namespace_name "translation" |> NamespacedName
