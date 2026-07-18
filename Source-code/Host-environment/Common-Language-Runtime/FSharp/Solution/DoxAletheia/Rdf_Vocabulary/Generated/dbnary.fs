namespace http.kaiko.getalp.org.dbnary.hash

open DoxAletheia.Rdf_Vocabulary

module dbnary =
    let _namespace_name = "http://kaiko.getalp.org/dbnary#"
    /// <summary>
    /// A gloss used to represent the context in which a translation or a relation is valid.
    /// <see href="http://kaiko.getalp.org/dbnary#Gloss"></see></summary>
    let Gloss = Namespaced_IRI.parse _namespace_name "Gloss" |> NamespacedName

    /// <summary>
    /// The class lexico-semantic relation between LexicalEntities (Lexical entry OR Lexical Sense). Individuals are properties used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding Ontolex relation.
    /// <see href="http://kaiko.getalp.org/dbnary#NymProperty"></see></summary>
    let NymProperty =
        Namespaced_IRI.parse _namespace_name "NymProperty" |> NamespacedName

    /// <summary>
    /// A Page corresponds to a Wiktionary web page describing a set of Lexical Entries that usually share the same written form but that do not necessarily share the same Part Of Speech. E.g. cat_n and cat_v are distinct lexical entries while the page "cat" refers to both of them.
    /// <see href="http://kaiko.getalp.org/dbnary#Page"></see></summary>
    let Page = Namespaced_IRI.parse _namespace_name "Page" |> NamespacedName

    /// <summary>
    /// Describe translation information for a Lexical Entry or a Lexical Sense.
    /// <see href="http://kaiko.getalp.org/dbnary#Translation"></see></summary>
    let Translation =
        Namespaced_IRI.parse _namespace_name "Translation" |> NamespacedName

    /// <summary>
    /// An underspecified antonymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation.
    /// <see href="http://kaiko.getalp.org/dbnary#antonym"></see></summary>
    let antonym = Namespaced_IRI.parse _namespace_name "antonym" |> NamespacedName

    /// <summary>
    /// An underspecified approximate synonymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation.
    /// <see href="http://kaiko.getalp.org/dbnary#approximateSynonym"></see></summary>
    let approximateSynonym =
        Namespaced_IRI.parse _namespace_name "approximateSynonym" |> NamespacedName

    /// <summary>
    /// cardinality of a certain set of Object a specific extract.
    /// <see href="http://kaiko.getalp.org/dbnary#count"></see></summary>
    let count = Namespaced_IRI.parse _namespace_name "count" |> NamespacedName

    /// <summary>
    /// The language dimension of an observation
    /// <see href="http://kaiko.getalp.org/dbnary#observationLanguage"></see></summary>
    let observationLanguage =
        Namespaced_IRI.parse _namespace_name "observationLanguage" |> NamespacedName

    /// <summary>
    /// The DataStructure of the DataCube describing the count of main DBnary/Ontolex Classes.
    /// <see href="http://kaiko.getalp.org/dbnary#dbnaryNymRelationsDataStructure"></see></summary>
    let dbnaryNymRelationsDataStructure =
        Namespaced_IRI.parse _namespace_name "dbnaryNymRelationsDataStructure" |> NamespacedName

    /// <summary>
    /// version number of the wiktionary dump from which the lexical data is extracted.
    /// <see href="http://kaiko.getalp.org/dbnary#wiktionaryDumpVersion"></see></summary>
    let wiktionaryDumpVersion =
        Namespaced_IRI.parse _namespace_name "wiktionaryDumpVersion" |> NamespacedName

    /// <summary>
    /// the dimension stating the counted nym relation in the Nym Count Datacube.
    /// <see href="http://kaiko.getalp.org/dbnary#nymRelation"></see></summary>
    let nymRelation =
        Namespaced_IRI.parse _namespace_name "nymRelation" |> NamespacedName

    /// <summary>
    /// The DataStructure of the DataCube describing the count of main DBnary/Ontolex Classes.
    /// <see href="http://kaiko.getalp.org/dbnary#dbnaryStatisticsDataStructure"></see></summary>
    let dbnaryStatisticsDataStructure =
        Namespaced_IRI.parse _namespace_name "dbnaryStatisticsDataStructure" |> NamespacedName

    /// <summary>
    /// count of ontolex Lexical Entries contained in a specific extract.
    /// <see href="http://kaiko.getalp.org/dbnary#lexicalEntryCount"></see></summary>
    let lexicalEntryCount =
        Namespaced_IRI.parse _namespace_name "lexicalEntryCount" |> NamespacedName

    /// <summary>
    /// count of ontolex Lexical Senses contained in a specific extract.
    /// <see href="http://kaiko.getalp.org/dbnary#lexicalSenseCount"></see></summary>
    let lexicalSenseCount =
        Namespaced_IRI.parse _namespace_name "lexicalSenseCount" |> NamespacedName

    /// <summary>
    /// count of dbnary Pages contained in a specific extract.
    /// <see href="http://kaiko.getalp.org/dbnary#pageCount"></see></summary>
    let pageCount = Namespaced_IRI.parse _namespace_name "pageCount" |> NamespacedName

    /// <summary>
    /// count of Dbnary Translations contained in a specific extract.
    /// <see href="http://kaiko.getalp.org/dbnary#translationsCount"></see></summary>
    let translationsCount =
        Namespaced_IRI.parse _namespace_name "translationsCount" |> NamespacedName

    /// <summary>
    /// The DataStructure of the DataCube describing the count of translations to a certain language in a certain extract.
    /// <see href="http://kaiko.getalp.org/dbnary#dbnaryTranslationsDataStructure"></see></summary>
    let dbnaryTranslationsDataStructure =
        Namespaced_IRI.parse _namespace_name "dbnaryTranslationsDataStructure" |> NamespacedName

    /// <summary>
    /// This transitive relation states that a Page, Lexical Entry or Lexical Sense derives from another Page or Lexical Entry or Lexical Sense.
    /// <see href="http://kaiko.getalp.org/dbnary#derivedFrom"></see></summary>
    let derivedFrom =
        Namespaced_IRI.parse _namespace_name "derivedFrom" |> NamespacedName

    /// <summary>
    /// links a Page to any lexical entry that share the same written form.
    /// <see href="http://kaiko.getalp.org/dbnary#describes"></see></summary>
    let describes = Namespaced_IRI.parse _namespace_name "describes" |> NamespacedName

    /// <summary>
    /// Performance of the Enhancement Process by Dump version and extractor version.
    /// <see href="http://kaiko.getalp.org/dbnary#enhancementConfidenceDataStructure"></see></summary>
    let enhancementConfidenceDataStructure =
        Namespaced_IRI.parse _namespace_name "enhancementConfidenceDataStructure" |> NamespacedName

    /// <summary>
    /// Name of the enhancement method for wich the confidence measures are given.
    /// <see href="http://kaiko.getalp.org/dbnary#enhancementMethod"></see></summary>
    let enhancementMethod =
        Namespaced_IRI.parse _namespace_name "enhancementMethod" |> NamespacedName

    /// <summary>
    /// The F1 confidence value as calculated by (2xPrecxRecall)/(Prec+Recall)
    /// <see href="http://kaiko.getalp.org/dbnary#f1Measure"></see></summary>
    let f1Measure = Namespaced_IRI.parse _namespace_name "f1Measure" |> NamespacedName

    /// <summary>
    /// The number of correct guesses among the computed guesses
    /// <see href="http://kaiko.getalp.org/dbnary#precisionMeasure"></see></summary>
    let precisionMeasure =
        Namespaced_IRI.parse _namespace_name "precisionMeasure" |> NamespacedName

    /// <summary>
    /// The fraction of relevant instances that were actually retrieved
    /// <see href="http://kaiko.getalp.org/dbnary#recallMeasure"></see></summary>
    let recallMeasure =
        Namespaced_IRI.parse _namespace_name "recallMeasure" |> NamespacedName

    /// <summary>
    /// The version number of the extraction program used to produce this DBnary dataset from the wiktionary dumps.
    /// <see href="http://kaiko.getalp.org/dbnary#extractorVersion"></see></summary>
    let extractorVersion =
        Namespaced_IRI.parse _namespace_name "extractorVersion" |> NamespacedName

    /// <summary>
    /// A short description of the context (usually a brief definition) under which the subject Translation or Relation is valid
    /// <see href="http://kaiko.getalp.org/dbnary#gloss"></see></summary>
    let gloss = Namespaced_IRI.parse _namespace_name "gloss" |> NamespacedName
    /// <summary>
    /// An underspecified holonymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation.
    /// <see href="http://kaiko.getalp.org/dbnary#holonym"></see></summary>
    let holonym = Namespaced_IRI.parse _namespace_name "holonym" |> NamespacedName
    /// <summary>
    /// An underspecified hypernymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation.
    /// <see href="http://kaiko.getalp.org/dbnary#hypernym"></see></summary>
    let hypernym = Namespaced_IRI.parse _namespace_name "hypernym" |> NamespacedName
    /// <summary>
    /// An underspecified hyponymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation.
    /// <see href="http://kaiko.getalp.org/dbnary#hyponym"></see></summary>
    let hyponym = Namespaced_IRI.parse _namespace_name "hyponym" |> NamespacedName

    /// <summary>
    /// links the translation information to the Lexical Entity it belongs to.
    /// <see href="http://kaiko.getalp.org/dbnary#isTranslationOf"></see></summary>
    let isTranslationOf =
        Namespaced_IRI.parse _namespace_name "isTranslationOf" |> NamespacedName

    /// <summary>
    /// An underspecified meronymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation.
    /// <see href="http://kaiko.getalp.org/dbnary#meronym"></see></summary>
    let meronym = Namespaced_IRI.parse _namespace_name "meronym" |> NamespacedName

    /// <summary>
    /// The original part of speech as it was defined in the Wiktionary page. This property takes a String litteral as object.
    /// <see href="http://kaiko.getalp.org/dbnary#partOfSpeech"></see></summary>
    let partOfSpeech =
        Namespaced_IRI.parse _namespace_name "partOfSpeech" |> NamespacedName

    /// <summary>
    ///   <see href="http://kaiko.getalp.org/dbnary#rank"></see>
    /// </summary>
    let rank = Namespaced_IRI.parse _namespace_name "rank" |> NamespacedName

    /// <summary>
    /// The number of the lexical Sense in the Lexical Entry, as given by Wiktionary. This property takes a String literal as an object.
    /// <see href="http://kaiko.getalp.org/dbnary#senseNumber"></see></summary>
    let senseNumber =
        Namespaced_IRI.parse _namespace_name "senseNumber" |> NamespacedName

    /// <summary>
    /// An underspecified synonymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation.
    /// <see href="http://kaiko.getalp.org/dbnary#synonym"></see></summary>
    let synonym = Namespaced_IRI.parse _namespace_name "synonym" |> NamespacedName

    /// <summary>
    /// The target language of a given translation, defined as a Linguistic System.
    /// <see href="http://kaiko.getalp.org/dbnary#targetLanguage"></see></summary>
    let targetLanguage =
        Namespaced_IRI.parse _namespace_name "targetLanguage" |> NamespacedName

    /// <summary>
    /// The target language of a given translation. This may be used when the dbnary:targetLanguage object property can not be used.
    /// <see href="http://kaiko.getalp.org/dbnary#targetLanguageCode"></see></summary>
    let targetLanguageCode =
        Namespaced_IRI.parse _namespace_name "targetLanguageCode" |> NamespacedName

    /// <summary>
    /// count of the number of translations that are associated to a gloss containing both a sense number and a textual description
    /// <see href="http://kaiko.getalp.org/dbnary#translationsWithSenseNumberAndTextualGloss"></see></summary>
    let translationsWithSenseNumberAndTextualGloss =
        Namespaced_IRI.parse _namespace_name "translationsWithSenseNumberAndTextualGloss" |> NamespacedName

    /// <summary>
    /// The DataStructure of the DataCube describing the translations and their associated glosses.
    /// <see href="http://kaiko.getalp.org/dbnary#translationGlossesDataStructure"></see></summary>
    let translationGlossesDataStructure =
        Namespaced_IRI.parse _namespace_name "translationGlossesDataStructure" |> NamespacedName

    /// <summary>
    /// count of the number of translation that is not associated to a gloss.
    /// <see href="http://kaiko.getalp.org/dbnary#translationsWithNoGloss"></see></summary>
    let translationsWithNoGloss =
        Namespaced_IRI.parse _namespace_name "translationsWithNoGloss" |> NamespacedName

    /// <summary>
    /// count of the number of translations that are associated with a gloss containing only a textual description.
    /// <see href="http://kaiko.getalp.org/dbnary#translationsWithTextualGloss"></see></summary>
    let translationsWithTextualGloss =
        Namespaced_IRI.parse _namespace_name "translationsWithTextualGloss" |> NamespacedName

    /// <summary>
    /// count of the number of translations that are associated to a gloss containing only a sense number.
    /// <see href="http://kaiko.getalp.org/dbnary#translationsWithSenseNumber"></see></summary>
    let translationsWithSenseNumber =
        Namespaced_IRI.parse _namespace_name "translationsWithSenseNumber" |> NamespacedName

    /// <summary>
    /// A verb that indicates more precisely the manner of doing something by replacing a verb of a more generalized meaning. E.g.: "Stroll" is a troponym of "walk", since it involves a slow and relaxed sort of walking.
    /// <see href="http://kaiko.getalp.org/dbnary#troponym"></see></summary>
    let troponym = Namespaced_IRI.parse _namespace_name "troponym" |> NamespacedName
    /// <summary>
    /// Usage note that is used to further annotate the target of the translation.
    /// <see href="http://kaiko.getalp.org/dbnary#usage"></see></summary>
    let usage = Namespaced_IRI.parse _namespace_name "usage" |> NamespacedName

    /// <summary>
    /// The written form of a translation equivalent.
    /// <see href="http://kaiko.getalp.org/dbnary#writtenForm"></see></summary>
    let writtenForm =
        Namespaced_IRI.parse _namespace_name "writtenForm" |> NamespacedName
