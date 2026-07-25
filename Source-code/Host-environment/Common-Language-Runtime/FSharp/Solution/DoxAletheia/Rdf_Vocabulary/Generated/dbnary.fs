namespace http.kaiko.getalp.org.dbnary.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dbnary =
    let _namespace_iri = Namespace_Iri dbnary |> NamespaceIRI
    /// <summary>
    ///   <para>dbnary:NymProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class lexico-semantic relation between LexicalEntities (Lexical entry OR Lexical Sense). Individuals are properties used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding Ontolex relation. </para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#NymProperty">http://kaiko.getalp.org/dbnary#NymProperty</seealso>
    let NymProperty = Prefixed_Name(dbnary, "NymProperty") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:antonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dbnary:NymProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An underspecified antonymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation. </para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#antonym">http://kaiko.getalp.org/dbnary#antonym</seealso>
    let antonym = Prefixed_Name(dbnary, "antonym") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:enhancementMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Name of the enhancement method for wich the confidence measures are given.</para>
    /// labels<para>Name of the enhancement method</para></remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#enhancementMethod">http://kaiko.getalp.org/dbnary#enhancementMethod</seealso>
    let enhancementMethod = Prefixed_Name(dbnary, "enhancementMethod") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:Gloss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A gloss used to represent the context in which a translation or a relation is valid.</para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#Gloss">http://kaiko.getalp.org/dbnary#Gloss</seealso>
    let Gloss = Prefixed_Name(dbnary, "Gloss") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:Translation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describe translation information for a Lexical Entry or a Lexical Sense.</para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#Translation">http://kaiko.getalp.org/dbnary#Translation</seealso>
    let Translation = Prefixed_Name(dbnary, "Translation") |> PrefixedName

    /// <summary>
    ///   <para>dbnary:translationsWithSenseNumberAndTextualGloss</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>count of the number of translations that are associated to a gloss containing both a sense number and a textual description</para>
    /// labels<para>Translations with a sense number and textual gloss</para></remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#translationsWithSenseNumberAndTextualGloss">http://kaiko.getalp.org/dbnary#translationsWithSenseNumberAndTextualGloss</seealso>
    let translationsWithSenseNumberAndTextualGloss =
        Prefixed_Name(dbnary, "translationsWithSenseNumberAndTextualGloss") |> PrefixedName

    /// <summary>
    ///   <para>dbnary:translationsWithNoGloss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>count of the number of translation that is not associated to a gloss.</para>
    /// labels<para>Translations with no gloss</para></remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#translationsWithNoGloss">http://kaiko.getalp.org/dbnary#translationsWithNoGloss</seealso>
    let translationsWithNoGloss =
        Prefixed_Name(dbnary, "translationsWithNoGloss") |> PrefixedName

    /// <summary>
    ///   <para>dbnary:translationsWithTextualGloss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>count of the number of translations that are associated with a gloss containing only a textual description.</para>
    /// labels<para>Translations with a textual gloss but no sense number</para></remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#translationsWithTextualGloss">http://kaiko.getalp.org/dbnary#translationsWithTextualGloss</seealso>
    let translationsWithTextualGloss =
        Prefixed_Name(dbnary, "translationsWithTextualGloss") |> PrefixedName

    /// <summary>
    ///   <para>dbnary:translationsWithSenseNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>count of the number of translations that are associated to a gloss containing only a sense number.</para>
    /// labels<para>Translations with a sense number but no textual gloss</para></remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#translationsWithSenseNumber">http://kaiko.getalp.org/dbnary#translationsWithSenseNumber</seealso>
    let translationsWithSenseNumber =
        Prefixed_Name(dbnary, "translationsWithSenseNumber") |> PrefixedName

    /// <summary>
    ///   <para>dbnary:meronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>dbnary:NymProperty</para>
    ///   <para>An underspecified meronymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation. </para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#meronym">http://kaiko.getalp.org/dbnary#meronym</seealso>
    let meronym = Prefixed_Name(dbnary, "meronym") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:isTranslationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>links the translation information to the Lexical Entity it belongs to.</para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#isTranslationOf">http://kaiko.getalp.org/dbnary#isTranslationOf</seealso>
    let isTranslationOf = Prefixed_Name(dbnary, "isTranslationOf") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:senseNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of the lexical Sense in the Lexical Entry, as given by Wiktionary. This property takes a String literal as an object.</para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#senseNumber">http://kaiko.getalp.org/dbnary#senseNumber</seealso>
    let senseNumber = Prefixed_Name(dbnary, "senseNumber") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:targetLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The target language of a given translation, defined as a Linguistic System.</para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#targetLanguage">http://kaiko.getalp.org/dbnary#targetLanguage</seealso>
    let targetLanguage = Prefixed_Name(dbnary, "targetLanguage") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:targetLanguageCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The target language of a given translation. This may be used when the dbnary:targetLanguage object property can not be used.</para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#targetLanguageCode">http://kaiko.getalp.org/dbnary#targetLanguageCode</seealso>
    let targetLanguageCode = Prefixed_Name(dbnary, "targetLanguageCode") |> PrefixedName

    /// <summary>
    ///   <para>dbnary:translationGlossesDataStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>qb:DataStructureDefinition</para>
    ///   <para>The DataStructure of the DataCube describing the translations and their associated glosses.</para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#translationGlossesDataStructure">http://kaiko.getalp.org/dbnary#translationGlossesDataStructure</seealso>
    let translationGlossesDataStructure =
        Prefixed_Name(dbnary, "translationGlossesDataStructure") |> PrefixedName

    /// <summary>
    ///   <para>dbnary:troponym</para>
    /// </summary>
    /// <remarks>
    ///   <para>dbnary:NymProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A verb that indicates more precisely the manner of doing something by replacing a verb of a more generalized meaning. E.g.: "Stroll" is a troponym of "walk", since it involves a slow and relaxed sort of walking.</para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#troponym">http://kaiko.getalp.org/dbnary#troponym</seealso>
    let troponym = Prefixed_Name(dbnary, "troponym") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:writtenForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The written form of a translation equivalent.</para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#writtenForm">http://kaiko.getalp.org/dbnary#writtenForm</seealso>
    let writtenForm = Prefixed_Name(dbnary, "writtenForm") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:count</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>cardinality of a certain set of Object a specific extract.</para>
    /// labels<para>count</para></remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#count">http://kaiko.getalp.org/dbnary#count</seealso>
    let count = Prefixed_Name(dbnary, "count") |> PrefixedName

    /// <summary>
    ///   <para>dbnary:observationLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The language dimension of an observation</para>
    /// labels<para>Observation Language</para></remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#observationLanguage">http://kaiko.getalp.org/dbnary#observationLanguage</seealso>
    let observationLanguage =
        Prefixed_Name(dbnary, "observationLanguage") |> PrefixedName

    /// <summary>
    ///   <para>dbnary:usage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Usage note that is used to further annotate the target of the translation.</para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#usage">http://kaiko.getalp.org/dbnary#usage</seealso>
    let usage = Prefixed_Name(dbnary, "usage") |> PrefixedName

    /// <summary>
    ///   <para>dbnary:dbnaryNymRelationsDataStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>qb:DataStructureDefinition</para>
    ///   <para>The DataStructure of the DataCube describing the count of main DBnary/Ontolex Classes.</para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#dbnaryNymRelationsDataStructure">http://kaiko.getalp.org/dbnary#dbnaryNymRelationsDataStructure</seealso>
    let dbnaryNymRelationsDataStructure =
        Prefixed_Name(dbnary, "dbnaryNymRelationsDataStructure") |> PrefixedName

    /// <summary>
    ///   <para>dbnary:lexicalSenseCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>count of ontolex Lexical Senses contained in a specific extract.</para>
    /// labels<para>count of Lexical Senses</para></remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#lexicalSenseCount">http://kaiko.getalp.org/dbnary#lexicalSenseCount</seealso>
    let lexicalSenseCount = Prefixed_Name(dbnary, "lexicalSenseCount") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:translationsCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>count of Dbnary Translations contained in a specific extract.</para>
    /// labels<para>count of Translations</para></remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#translationsCount">http://kaiko.getalp.org/dbnary#translationsCount</seealso>
    let translationsCount = Prefixed_Name(dbnary, "translationsCount") |> PrefixedName

    /// <summary>
    ///   <para>dbnary:dbnaryStatisticsDataStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>qb:DataStructureDefinition</para>
    ///   <para>The DataStructure of the DataCube describing the count of main DBnary/Ontolex Classes.</para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#dbnaryStatisticsDataStructure">http://kaiko.getalp.org/dbnary#dbnaryStatisticsDataStructure</seealso>
    let dbnaryStatisticsDataStructure =
        Prefixed_Name(dbnary, "dbnaryStatisticsDataStructure") |> PrefixedName

    /// <summary>
    ///   <para>dbnary:dbnaryTranslationsDataStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DataStructureDefinition</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The DataStructure of the DataCube describing the count of translations to a certain language in a certain extract.</para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#dbnaryTranslationsDataStructure">http://kaiko.getalp.org/dbnary#dbnaryTranslationsDataStructure</seealso>
    let dbnaryTranslationsDataStructure =
        Prefixed_Name(dbnary, "dbnaryTranslationsDataStructure") |> PrefixedName

    /// <summary>
    ///   <para>dbnary:lexicalEntryCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>count of ontolex Lexical Entries contained in a specific extract.</para>
    /// labels<para>count of Lexical Entries</para></remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#lexicalEntryCount">http://kaiko.getalp.org/dbnary#lexicalEntryCount</seealso>
    let lexicalEntryCount = Prefixed_Name(dbnary, "lexicalEntryCount") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:derivedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>This transitive relation states that a Page, Lexical Entry or Lexical Sense derives from another Page or Lexical Entry or Lexical Sense.</para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#derivedFrom">http://kaiko.getalp.org/dbnary#derivedFrom</seealso>
    let derivedFrom = Prefixed_Name(dbnary, "derivedFrom") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:pageCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>count of dbnary Pages contained in a specific extract.</para>
    /// labels<para>count of Pages</para></remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#pageCount">http://kaiko.getalp.org/dbnary#pageCount</seealso>
    let pageCount = Prefixed_Name(dbnary, "pageCount") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>links a Page to any lexical entry that share the same written form. </para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#describes">http://kaiko.getalp.org/dbnary#describes</seealso>
    let describes = Prefixed_Name(dbnary, "describes") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:recallMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The fraction of relevant instances that were actually retrieved</para>
    /// labels<para>Recall</para></remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#recallMeasure">http://kaiko.getalp.org/dbnary#recallMeasure</seealso>
    let recallMeasure = Prefixed_Name(dbnary, "recallMeasure") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:extractorVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The version number of the extraction program used to produce this DBnary dataset from the wiktionary dumps.</para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#extractorVersion">http://kaiko.getalp.org/dbnary#extractorVersion</seealso>
    let extractorVersion = Prefixed_Name(dbnary, "extractorVersion") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:gloss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A short description of the context (usually a brief definition) under which the subject Translation or Relation is valid</para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#gloss">http://kaiko.getalp.org/dbnary#gloss</seealso>
    let gloss = Prefixed_Name(dbnary, "gloss") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:holonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>dbnary:NymProperty</para>
    ///   <para>An underspecified holonymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation. </para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#holonym">http://kaiko.getalp.org/dbnary#holonym</seealso>
    let holonym = Prefixed_Name(dbnary, "holonym") |> PrefixedName

    /// <summary>
    ///   <para>dbnary:enhancementConfidenceDataStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DataStructureDefinition</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Performance of the Enhancement Process by Dump version and extractor version.</para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#enhancementConfidenceDataStructure">http://kaiko.getalp.org/dbnary#enhancementConfidenceDataStructure</seealso>
    let enhancementConfidenceDataStructure =
        Prefixed_Name(dbnary, "enhancementConfidenceDataStructure") |> PrefixedName

    /// <summary>
    ///   <para>dbnary:precisionMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>The number of correct guesses among the computed guesses</para>
    /// labels<para>Precision</para></remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#precisionMeasure">http://kaiko.getalp.org/dbnary#precisionMeasure</seealso>
    let precisionMeasure = Prefixed_Name(dbnary, "precisionMeasure") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:f1Measure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The F1 confidence value as calculated by (2xPrecxRecall)/(Prec+Recall)</para>
    /// labels<para>F1 Measure</para></remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#f1Measure">http://kaiko.getalp.org/dbnary#f1Measure</seealso>
    let f1Measure = Prefixed_Name(dbnary, "f1Measure") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:hypernym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>dbnary:NymProperty</para>
    ///   <para>An underspecified hypernymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation. </para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#hypernym">http://kaiko.getalp.org/dbnary#hypernym</seealso>
    let hypernym = Prefixed_Name(dbnary, "hypernym") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:hyponym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>dbnary:NymProperty</para>
    ///   <para>An underspecified hyponymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation. </para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#hyponym">http://kaiko.getalp.org/dbnary#hyponym</seealso>
    let hyponym = Prefixed_Name(dbnary, "hyponym") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:partOfSpeech</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The original part of speech as it was defined in the Wiktionary page. This property takes a String litteral as object.</para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#partOfSpeech">http://kaiko.getalp.org/dbnary#partOfSpeech</seealso>
    let partOfSpeech = Prefixed_Name(dbnary, "partOfSpeech") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:rank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#rank">http://kaiko.getalp.org/dbnary#rank</seealso>
    let rank = Prefixed_Name(dbnary, "rank") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:synonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dbnary:NymProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An underspecified synonymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation. </para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#synonym">http://kaiko.getalp.org/dbnary#synonym</seealso>
    let synonym = Prefixed_Name(dbnary, "synonym") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:Page</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Page corresponds to a Wiktionary web page describing a set of Lexical Entries that usually share the same written form but that do not necessarily share the same Part Of Speech. E.g. cat_n and cat_v are distinct lexical entries while the page "cat" refers to both of them.</para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#Page">http://kaiko.getalp.org/dbnary#Page</seealso>
    let Page = Prefixed_Name(dbnary, "Page") |> PrefixedName
    /// <summary>
    ///   <para>dbnary:approximateSynonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dbnary:NymProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An underspecified approximate synonymy relation between LexicalEntities (Lexical entries or Lexical Senses). This relation is used to encode an information available in a lexicon when the linked Lexical Senses are not known. When both source and target of the relation are Lexical Senses, one should use the corresponding LEMON relation. </para>
    /// </remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#approximateSynonym">http://kaiko.getalp.org/dbnary#approximateSynonym</seealso>
    let approximateSynonym = Prefixed_Name(dbnary, "approximateSynonym") |> PrefixedName

    /// <summary>
    ///   <para>dbnary:wiktionaryDumpVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>version number of the wiktionary dump from which the lexical data is extracted.</para>
    /// labels<para>Wiktionary Dump Version</para></remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#wiktionaryDumpVersion">http://kaiko.getalp.org/dbnary#wiktionaryDumpVersion</seealso>
    let wiktionaryDumpVersion =
        Prefixed_Name(dbnary, "wiktionaryDumpVersion") |> PrefixedName

    /// <summary>
    ///   <para>dbnary:nymRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>the dimension stating the counted nym relation in the Nym Count Datacube.</para>
    /// labels<para>Nym relation</para></remarks>
    /// <seealso href="http://kaiko.getalp.org/dbnary#nymRelation">http://kaiko.getalp.org/dbnary#nymRelation</seealso>
    let nymRelation = Prefixed_Name(dbnary, "nymRelation") |> PrefixedName
