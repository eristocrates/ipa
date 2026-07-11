#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RDFErgonomics.fsx"
open RDFErgonomics

module vartrans =

    let _prefix = prefix_label "vartrans"

    let ConceptualRelation = _prefix "ConceptualRelation"


    let LexicalRelation = _prefix "LexicalRelation"


    let LexicoSemanticRelation = _prefix "LexicoSemanticRelation"


    let SenseRelation = _prefix "SenseRelation"


    /// A 'terminological relation' is a sense relation that relates two lexical senses of terms that are semantically related in the sense that they can be exchanged in most contexts, but their surface forms are not directly related. The variants vary along dimensions that are not captured by the given ontology and are intentionally (pragmatically) caused.
    let TerminologicalRelation = _prefix "TerminologicalRelation"


    let Translation = _prefix "Translation"


    let TranslationSet = _prefix "TranslationSet"


    /// The 'category' property indicates the specific type of relation by which two lexical entries or two lexical senses are related.
    let category = _prefix "category"


    /// A relationship between two concepts
    let conceptRel = _prefix "conceptRel"



    let imports = _prefix "imports"


    /// The 'lexicalRel' property relates two lexical entries that stand in some lexical relation.
    let lexicalRel = _prefix "lexicalRel"


    /// The 'relates' property links a lexico-semantic relation to the two lexical entries or lexical senses between which it establishes the relation.
    let relates = _prefix "relates"


    let senseRel = _prefix "senseRel"


    let source = _prefix "source"


    let target = _prefix "target"


    let trans = _prefix "trans"


    let translatableAs = _prefix "translatableAs"


    /// The 'translation' property relates two lexical senses of two lexical entries that stand in a translation relation to one another.
    let translation = _prefix "translation"



    let versionInfo = _prefix "versionInfo"
