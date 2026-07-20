namespace http.kaiko.getalp.org.dbnary.hash

open DoxAletheia

module dbnary =
    let _namespace_name = "http://kaiko.getalp.org/dbnary#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A gloss used to represent the context in which a translation or a relation is valid.
    /// <see href="http://kaiko.getalp.org/dbnary#Gloss"></see></summary>
    let Gloss = _prefix "Gloss"
    /// <summary>
    /// The class lexico-semantic relation between LexicalEntities (Lexical entry OR Lexical Sense). Individuals are properties used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding Ontolex relation.
    /// <see href="http://kaiko.getalp.org/dbnary#NymProperty"></see></summary>
    let NymProperty = _prefix "NymProperty"
    /// <summary>
    /// A Page corresponds to a Wiktionary web page describing a set of Lexical Entries that usually share the same written form but that do not necessarily share the same Part Of Speech. E.g. cat_n and cat_v are distinct lexical entries while the page "cat" refers to both of them.
    /// <see href="http://kaiko.getalp.org/dbnary#Page"></see></summary>
    let Page = _prefix "Page"
    /// <summary>
    /// Describe translation information for a Lexical Entry or a Lexical Sense.
    /// <see href="http://kaiko.getalp.org/dbnary#Translation"></see></summary>
    let Translation = _prefix "Translation"
    /// <summary>
    /// An underspecified antonymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation.
    /// <see href="http://kaiko.getalp.org/dbnary#antonym"></see></summary>
    let antonym = _prefix "antonym"
    /// <summary>
    /// An underspecified approximate synonymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation.
    /// <see href="http://kaiko.getalp.org/dbnary#approximateSynonym"></see></summary>
    let approximateSynonym = _prefix "approximateSynonym"
    /// <summary>
    /// cardinality of a certain set of Object a specific extract.
    /// <see href="http://kaiko.getalp.org/dbnary#count"></see></summary>
    let count = _prefix "count"
    /// <summary>
    /// The language dimension of an observation
    /// <see href="http://kaiko.getalp.org/dbnary#observationLanguage"></see></summary>
    let observationLanguage = _prefix "observationLanguage"
    /// <summary>
    /// The DataStructure of the DataCube describing the count of main DBnary/Ontolex Classes.
    /// <see href="http://kaiko.getalp.org/dbnary#dbnaryNymRelationsDataStructure"></see></summary>
    let dbnaryNymRelationsDataStructure = _prefix "dbnaryNymRelationsDataStructure"
    /// <summary>
    /// version number of the wiktionary dump from which the lexical data is extracted.
    /// <see href="http://kaiko.getalp.org/dbnary#wiktionaryDumpVersion"></see></summary>
    let wiktionaryDumpVersion = _prefix "wiktionaryDumpVersion"
    /// <summary>
    /// the dimension stating the counted nym relation in the Nym Count Datacube.
    /// <see href="http://kaiko.getalp.org/dbnary#nymRelation"></see></summary>
    let nymRelation = _prefix "nymRelation"
    /// <summary>
    /// The DataStructure of the DataCube describing the count of main DBnary/Ontolex Classes.
    /// <see href="http://kaiko.getalp.org/dbnary#dbnaryStatisticsDataStructure"></see></summary>
    let dbnaryStatisticsDataStructure = _prefix "dbnaryStatisticsDataStructure"
    /// <summary>
    /// count of ontolex Lexical Entries contained in a specific extract.
    /// <see href="http://kaiko.getalp.org/dbnary#lexicalEntryCount"></see></summary>
    let lexicalEntryCount = _prefix "lexicalEntryCount"
    /// <summary>
    /// count of ontolex Lexical Senses contained in a specific extract.
    /// <see href="http://kaiko.getalp.org/dbnary#lexicalSenseCount"></see></summary>
    let lexicalSenseCount = _prefix "lexicalSenseCount"
    /// <summary>
    /// count of dbnary Pages contained in a specific extract.
    /// <see href="http://kaiko.getalp.org/dbnary#pageCount"></see></summary>
    let pageCount = _prefix "pageCount"
    /// <summary>
    /// count of Dbnary Translations contained in a specific extract.
    /// <see href="http://kaiko.getalp.org/dbnary#translationsCount"></see></summary>
    let translationsCount = _prefix "translationsCount"
    /// <summary>
    /// The DataStructure of the DataCube describing the count of translations to a certain language in a certain extract.
    /// <see href="http://kaiko.getalp.org/dbnary#dbnaryTranslationsDataStructure"></see></summary>
    let dbnaryTranslationsDataStructure = _prefix "dbnaryTranslationsDataStructure"
    /// <summary>
    /// This transitive relation states that a Page, Lexical Entry or Lexical Sense derives from another Page or Lexical Entry or Lexical Sense.
    /// <see href="http://kaiko.getalp.org/dbnary#derivedFrom"></see></summary>
    let derivedFrom = _prefix "derivedFrom"
    /// <summary>
    /// links a Page to any lexical entry that share the same written form.
    /// <see href="http://kaiko.getalp.org/dbnary#describes"></see></summary>
    let describes = _prefix "describes"

    /// <summary>
    /// Performance of the Enhancement Process by Dump version and extractor version.
    /// <see href="http://kaiko.getalp.org/dbnary#enhancementConfidenceDataStructure"></see></summary>
    let enhancementConfidenceDataStructure =
        _prefix "enhancementConfidenceDataStructure"

    /// <summary>
    /// Name of the enhancement method for wich the confidence measures are given.
    /// <see href="http://kaiko.getalp.org/dbnary#enhancementMethod"></see></summary>
    let enhancementMethod = _prefix "enhancementMethod"
    /// <summary>
    /// The F1 confidence value as calculated by (2xPrecxRecall)/(Prec+Recall)
    /// <see href="http://kaiko.getalp.org/dbnary#f1Measure"></see></summary>
    let f1Measure = _prefix "f1Measure"
    /// <summary>
    /// The number of correct guesses among the computed guesses
    /// <see href="http://kaiko.getalp.org/dbnary#precisionMeasure"></see></summary>
    let precisionMeasure = _prefix "precisionMeasure"
    /// <summary>
    /// The fraction of relevant instances that were actually retrieved
    /// <see href="http://kaiko.getalp.org/dbnary#recallMeasure"></see></summary>
    let recallMeasure = _prefix "recallMeasure"
    /// <summary>
    /// The version number of the extraction program used to produce this DBnary dataset from the wiktionary dumps.
    /// <see href="http://kaiko.getalp.org/dbnary#extractorVersion"></see></summary>
    let extractorVersion = _prefix "extractorVersion"
    /// <summary>
    /// A short description of the context (usually a brief definition) under which the subject Translation or Relation is valid
    /// <see href="http://kaiko.getalp.org/dbnary#gloss"></see></summary>
    let gloss = _prefix "gloss"
    /// <summary>
    /// An underspecified holonymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation.
    /// <see href="http://kaiko.getalp.org/dbnary#holonym"></see></summary>
    let holonym = _prefix "holonym"
    /// <summary>
    /// An underspecified hypernymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation.
    /// <see href="http://kaiko.getalp.org/dbnary#hypernym"></see></summary>
    let hypernym = _prefix "hypernym"
    /// <summary>
    /// An underspecified hyponymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation.
    /// <see href="http://kaiko.getalp.org/dbnary#hyponym"></see></summary>
    let hyponym = _prefix "hyponym"
    /// <summary>
    /// links the translation information to the Lexical Entity it belongs to.
    /// <see href="http://kaiko.getalp.org/dbnary#isTranslationOf"></see></summary>
    let isTranslationOf = _prefix "isTranslationOf"
    /// <summary>
    /// An underspecified meronymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation.
    /// <see href="http://kaiko.getalp.org/dbnary#meronym"></see></summary>
    let meronym = _prefix "meronym"
    /// <summary>
    /// The original part of speech as it was defined in the Wiktionary page. This property takes a String litteral as object.
    /// <see href="http://kaiko.getalp.org/dbnary#partOfSpeech"></see></summary>
    let partOfSpeech = _prefix "partOfSpeech"
    /// <summary>
    ///   <see href="http://kaiko.getalp.org/dbnary#rank"></see>
    /// </summary>
    let rank = _prefix "rank"
    /// <summary>
    /// The number of the lexical Sense in the Lexical Entry, as given by Wiktionary. This property takes a String literal as an object.
    /// <see href="http://kaiko.getalp.org/dbnary#senseNumber"></see></summary>
    let senseNumber = _prefix "senseNumber"
    /// <summary>
    /// An underspecified synonymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation.
    /// <see href="http://kaiko.getalp.org/dbnary#synonym"></see></summary>
    let synonym = _prefix "synonym"
    /// <summary>
    /// The target language of a given translation, defined as a Linguistic System.
    /// <see href="http://kaiko.getalp.org/dbnary#targetLanguage"></see></summary>
    let targetLanguage = _prefix "targetLanguage"
    /// <summary>
    /// The target language of a given translation. This may be used when the dbnary:targetLanguage object property can not be used.
    /// <see href="http://kaiko.getalp.org/dbnary#targetLanguageCode"></see></summary>
    let targetLanguageCode = _prefix "targetLanguageCode"

    /// <summary>
    /// count of the number of translations that are associated to a gloss containing both a sense number and a textual description
    /// <see href="http://kaiko.getalp.org/dbnary#translationsWithSenseNumberAndTextualGloss"></see></summary>
    let translationsWithSenseNumberAndTextualGloss =
        _prefix "translationsWithSenseNumberAndTextualGloss"

    /// <summary>
    /// The DataStructure of the DataCube describing the translations and their associated glosses.
    /// <see href="http://kaiko.getalp.org/dbnary#translationGlossesDataStructure"></see></summary>
    let translationGlossesDataStructure = _prefix "translationGlossesDataStructure"
    /// <summary>
    /// count of the number of translation that is not associated to a gloss.
    /// <see href="http://kaiko.getalp.org/dbnary#translationsWithNoGloss"></see></summary>
    let translationsWithNoGloss = _prefix "translationsWithNoGloss"
    /// <summary>
    /// count of the number of translations that are associated with a gloss containing only a textual description.
    /// <see href="http://kaiko.getalp.org/dbnary#translationsWithTextualGloss"></see></summary>
    let translationsWithTextualGloss = _prefix "translationsWithTextualGloss"
    /// <summary>
    /// count of the number of translations that are associated to a gloss containing only a sense number.
    /// <see href="http://kaiko.getalp.org/dbnary#translationsWithSenseNumber"></see></summary>
    let translationsWithSenseNumber = _prefix "translationsWithSenseNumber"
    /// <summary>
    /// A verb that indicates more precisely the manner of doing something by replacing a verb of a more generalized meaning. E.g.: "Stroll" is a troponym of "walk", since it involves a slow and relaxed sort of walking.
    /// <see href="http://kaiko.getalp.org/dbnary#troponym"></see></summary>
    let troponym = _prefix "troponym"
    /// <summary>
    /// Usage note that is used to further annotate the target of the translation.
    /// <see href="http://kaiko.getalp.org/dbnary#usage"></see></summary>
    let usage = _prefix "usage"
    /// <summary>
    /// The written form of a translation equivalent.
    /// <see href="http://kaiko.getalp.org/dbnary#writtenForm"></see></summary>
    let writtenForm = _prefix "writtenForm"
