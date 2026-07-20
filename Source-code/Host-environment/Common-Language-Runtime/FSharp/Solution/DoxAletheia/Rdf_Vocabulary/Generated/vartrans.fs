namespace http.www.w3.org.ns.lemon.vartrans.hash

open DoxAletheia

module vartrans =
    let _namespace_name = "http://www.w3.org/ns/lemon/vartrans#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/lemon/vartrans#imports"></see>
    /// </summary>
    let imports = _prefix "imports"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/lemon/vartrans#versionInfo"></see>
    /// </summary>
    let versionInfo = _prefix "versionInfo"
    /// <summary>
    /// A relationship between two concepts
    /// <see href="http://www.w3.org/ns/lemon/vartrans#ConceptualRelation"></see></summary>
    let ConceptualRelation = _prefix "ConceptualRelation"
    /// <summary>
    /// A 'lexico-semantic relation' represents the relation between two lexical entries or lexical senses that are related by some lexical or semantic relationship.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#LexicoSemanticRelation"></see></summary>
    let LexicoSemanticRelation = _prefix "LexicoSemanticRelation"
    /// <summary>
    /// The 'relates' property links a lexico-semantic relation to the two lexical entries or lexical senses between which it establishes the relation.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#relates"></see></summary>
    let relates = _prefix "relates"
    /// <summary>
    /// A 'lexical relation' is a lexico-semantic relation that represents the relation between two lexical entries the surface forms of which are related grammatically, stylistically or by some operation motivated by linguistic economy.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#LexicalRelation"></see></summary>
    let LexicalRelation = _prefix "LexicalRelation"
    /// <summary>
    /// A 'sense relation' is a lexico-semantic relation that represents the relation between two lexical senses the meanings of which are related.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#SenseRelation"></see></summary>
    let SenseRelation = _prefix "SenseRelation"
    /// <summary>
    /// A 'terminological relation' is a sense relation that relates two lexical senses of terms that are semantically related in the sense that they can be exchanged in most contexts, but their surface forms are not directly related. The variants vary along dimensions that are not captured by the given ontology and are intentionally (pragmatically) caused.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#TerminologicalRelation"></see></summary>
    let TerminologicalRelation = _prefix "TerminologicalRelation"
    /// <summary>
    /// A 'translation' is a 'sense relation' expressing that two lexical senses corresponding to two lexical entries in different languages can be translated to each other without any major meaning shifts.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#Translation"></see></summary>
    let Translation = _prefix "Translation"
    /// <summary>
    /// The 'target' property indicates the lexical sense or lexical entry involved in a lexico-semantic relation as a 'target'.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#target"></see></summary>
    let target = _prefix "target"
    /// <summary>
    /// A 'translation set' is a set of translations that have some common source.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#TranslationSet"></see></summary>
    let TranslationSet = _prefix "TranslationSet"
    /// <summary>
    /// The 'category' property indicates the specific type of relation by which two lexical entries or two lexical senses are related.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#category"></see></summary>
    let category = _prefix "category"
    /// <summary>
    /// A relationship between two concepts
    /// <see href="http://www.w3.org/ns/lemon/vartrans#conceptRel"></see></summary>
    let conceptRel = _prefix "conceptRel"
    /// <summary>
    /// The 'lexicalRel' property relates two lexical entries that stand in some lexical relation.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#lexicalRel"></see></summary>
    let lexicalRel = _prefix "lexicalRel"
    /// <summary>
    /// The 'senseRel' property relates two lexical senses that stand in some sense relation.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#senseRel"></see></summary>
    let senseRel = _prefix "senseRel"
    /// <summary>
    /// The 'source' property indicates the lexical sense or lexical entry involved in a lexico-semantic relation as a 'source'.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#source"></see></summary>
    let source = _prefix "source"
    /// <summary>
    /// The property 'trans' relates a TranslationSet to one of its translations.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#trans"></see></summary>
    let trans = _prefix "trans"
    /// <summary>
    /// The 'translatableAs' property relates a lexical entry in some language to a lexical entry in another language that it can be translated as depending on the particular context and specific senses of the involved lexical entries.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#translatableAs"></see></summary>
    let translatableAs = _prefix "translatableAs"
    /// <summary>
    /// The 'translation' property relates two lexical senses of two lexical entries that stand in a translation relation to one another.
    /// <see href="http://www.w3.org/ns/lemon/vartrans#translation"></see></summary>
    let translation = _prefix "translation"
