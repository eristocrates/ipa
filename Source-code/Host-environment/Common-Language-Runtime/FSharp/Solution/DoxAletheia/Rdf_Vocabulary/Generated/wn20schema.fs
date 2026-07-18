namespace http.www.w3.org._2006._03.wn.wn20.schema.slash

open DoxAletheia.Rdf_Vocabulary

module wn20schema =
    let _namespace_name = "http://www.w3.org/2006/03/wn/wn20/schema/"

    /// <summary>
    /// A Synset in an adjective cluster representing a concept that is similar in meaning to the concept represented by its head synset .
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/AdjectiveSatelliteSynset"></see></summary>
    let AdjectiveSatelliteSynset =
        Namespaced_IRI.parse _namespace_name "AdjectiveSatelliteSynset" |> NamespacedName

    /// <summary>
    /// A synset including adjective word senses.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/AdjectiveSynset"></see></summary>
    let AdjectiveSynset =
        Namespaced_IRI.parse _namespace_name "AdjectiveSynset" |> NamespacedName

    /// <summary>
    /// ****A relation added here to link synsets and word senses explicitly (in the WordNet db, it is implicit in the sense tag record)****
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/containsWordSense"></see></summary>
    let containsWordSense =
        Namespaced_IRI.parse _namespace_name "containsWordSense" |> NamespacedName

    /// <summary>
    /// A sense of an adjective satellite word.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/AdjectiveSatelliteWordSense"></see></summary>
    let AdjectiveSatelliteWordSense =
        Namespaced_IRI.parse _namespace_name "AdjectiveSatelliteWordSense" |> NamespacedName

    /// <summary>
    /// A sense of an adjective word.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/AdjectiveWordSense"></see></summary>
    let AdjectiveWordSense =
        Namespaced_IRI.parse _namespace_name "AdjectiveWordSense" |> NamespacedName

    /// <summary>
    /// ****A relation added here to link word senses and synsets explicitly (in the WordNet db, it is implicit in the sense tag record)****
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/inSynset"></see></summary>
    let inSynset = Namespaced_IRI.parse _namespace_name "inSynset" |> NamespacedName
    /// <summary>
    /// A synonym set; a set of words that are interchangeable in some context.
    ///
    /// ******************************
    /// Word and WordSenses are distinguished in this datamodel for two reasons:
    /// 1) WordNet uses the distinction in the database, and several relations are defined for WordSenses rather than for Synsets.
    /// 2) For the sake of ontological clarity, here it is assumed that Synsets include word senses, in order to partition the logical space of the lexicon (words as forms, which belong to different natural language lexica, words as meanings, which also can be peculiar to different natural languages, but usually exist in several of them, and synsets, which cluster word senses by abstracting out their distributional context.
    /// ******************************
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/Synset"></see></summary>
    let Synset = Namespaced_IRI.parse _namespace_name "Synset" |> NamespacedName
    /// <summary>
    /// A meaning of a word in WordNet. Each sense of a word is in a different synset. Each word sense is contained in exactly one synset.
    ///
    /// ******************************
    /// Word and WordSenses are distinguished in this datamodel for two reasons:
    /// 1) WordNet uses the distinction in the database, and several relations are defined for WordSenses rather than for Synsets.
    /// 2) For the sake of ontological clarity, here it is assumed that synsets include word senses, in order to partition the logical space of the lexicon (words as forms, which belong to different natural language lexica, words as meanings, which also can be peculiar to different natural languages, but usually exist in several of them, and synsets, which cluster word senses by abstracting out their distributional context.
    /// ******************************
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/WordSense"></see></summary>
    let WordSense = Namespaced_IRI.parse _namespace_name "WordSense" |> NamespacedName

    /// <summary>
    /// A synset including adverb word senses.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/AdverbSynset"></see></summary>
    let AdverbSynset =
        Namespaced_IRI.parse _namespace_name "AdverbSynset" |> NamespacedName

    /// <summary>
    /// A meaning of an adverb word.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/AdverbWordSense"></see></summary>
    let AdverbWordSense =
        Namespaced_IRI.parse _namespace_name "AdverbWordSense" |> NamespacedName

    /// <summary>
    /// A collocation in WordNet is a string of two or more words, connected by spaces or hyphens. Examples are: man-eating shark , blue-collar , depend on , line of products . In the database files spaces are represented as underscore (_ ) characters.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/Collocation"></see></summary>
    let Collocation =
        Namespaced_IRI.parse _namespace_name "Collocation" |> NamespacedName

    /// <summary>
    /// Any word or composed term (collocation) deputed to have a sense in WordNet.
    /// ****For the sake of ontological clarity, here it is assumed that synsets include word senses, in order to partition the logical space of the lexicon (words as forms, which belong to different natural language lexica, words as meanings, which also can be peculiar to different natural languages, but usually exist in several of them, and synsets, which cluster word senses by abstracting out their distributional context.****
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/Word"></see></summary>
    let Word = Namespaced_IRI.parse _namespace_name "Word" |> NamespacedName
    /// <summary>
    /// A synset including noun word senses.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/NounSynset"></see></summary>
    let NounSynset = Namespaced_IRI.parse _namespace_name "NounSynset" |> NamespacedName

    /// <summary>
    /// A meaning of a noun word.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/NounWordSense"></see></summary>
    let NounWordSense =
        Namespaced_IRI.parse _namespace_name "NounWordSense" |> NamespacedName

    /// <summary>
    /// A synset including verb word senses.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/VerbSynset"></see></summary>
    let VerbSynset = Namespaced_IRI.parse _namespace_name "VerbSynset" |> NamespacedName

    /// <summary>
    /// A meaning of a verb word.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/VerbWordSense"></see></summary>
    let VerbWordSense =
        Namespaced_IRI.parse _namespace_name "VerbWordSense" |> NamespacedName

    /// <summary>
    /// ****A relation added here to link words and word senses explicitly (in the WordNet db, it is implicit in the synset record)****
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/sense"></see></summary>
    let sense = Namespaced_IRI.parse _namespace_name "sense" |> NamespacedName
    /// <summary>
    /// ****A relation added here to link word senses and words explicitly (in the WordNet db, it is implicit in the synset record)****
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/word"></see></summary>
    let word = Namespaced_IRI.parse _namespace_name "word" |> NamespacedName

    /// <summary>
    /// It specifies an adjective word sense that pertains to either the noun or adjective second word sense.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/adjectivePertainsTo"></see></summary>
    let adjectivePertainsTo =
        Namespaced_IRI.parse _namespace_name "adjectivePertainsTo" |> NamespacedName

    /// <summary>
    /// It specifies an adverb word sense that pertains to the adjective second word sense.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/adverbPertainsTo"></see></summary>
    let adverbPertainsTo =
        Namespaced_IRI.parse _namespace_name "adverbPertainsTo" |> NamespacedName

    /// <summary>
    /// It specifies antonymous word senses. This is a lexical relation that holds for all syntactic categories. For each antonymous pair, both relations are listed.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/antonymOf"></see></summary>
    let antonymOf = Namespaced_IRI.parse _namespace_name "antonymOf" |> NamespacedName
    /// <summary>
    /// It defines the attribute relation between noun and adjective synset pairs in which the adjective is a value of the noun.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/attribute"></see></summary>
    let attribute = Namespaced_IRI.parse _namespace_name "attribute" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/03/wn/wn20/schema/attributeOf"></see>
    /// </summary>
    let attributeOf =
        Namespaced_IRI.parse _namespace_name "attributeOf" |> NamespacedName

    /// <summary>
    /// It specifies that the second synset is a cause of the first synset. This relation only holds for verbs.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/causedBy"></see></summary>
    let causedBy = Namespaced_IRI.parse _namespace_name "causedBy" |> NamespacedName
    /// <summary>
    /// inverse of causedBy
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/causes"></see></summary>
    let causes = Namespaced_IRI.parse _namespace_name "causes" |> NamespacedName

    /// <summary>
    /// It specifies that the first synset has been classified as a member of the class (either as topic or 'category', as region, or as usage) represented by the second (noun) synset.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/classifiedBy"></see></summary>
    let classifiedBy =
        Namespaced_IRI.parse _namespace_name "classifiedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/03/wn/wn20/schema/classifies"></see>
    /// </summary>
    let classifies = Namespaced_IRI.parse _namespace_name "classifies" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/03/wn/wn20/schema/classifiedByRegion"></see>
    /// </summary>
    let classifiedByRegion =
        Namespaced_IRI.parse _namespace_name "classifiedByRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/03/wn/wn20/schema/classifiedByTopic"></see>
    /// </summary>
    let classifiedByTopic =
        Namespaced_IRI.parse _namespace_name "classifiedByTopic" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/03/wn/wn20/schema/classifiedByUsage"></see>
    /// </summary>
    let classifiedByUsage =
        Namespaced_IRI.parse _namespace_name "classifiedByUsage" |> NamespacedName

    /// <summary>
    /// It specifies that there exists a symmetric lexical morphosemantic relation between the first and second synset terms representing derivational morphology.
    /// ***In the WordNet database this relation extends over word senses within synsets***
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/derivationallyRelated"></see></summary>
    let derivationallyRelated =
        Namespaced_IRI.parse _namespace_name "derivationallyRelated" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/03/wn/wn20/schema/entailedBy"></see>
    /// </summary>
    let entailedBy = Namespaced_IRI.parse _namespace_name "entailedBy" |> NamespacedName
    /// <summary>
    /// A verb X entails Y if X cannot be done unless Y is, or has been, done.
    /// It specifies that the second synset is an entailment of first synset. This relation only holds for verbs.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/entails"></see></summary>
    let entails = Namespaced_IRI.parse _namespace_name "entails" |> NamespacedName
    /// <summary>
    /// It specifies a generic sentence frame for one or all words in a synset. The operator is defined only for verbs.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/frame"></see></summary>
    let frame = Namespaced_IRI.parse _namespace_name "frame" |> NamespacedName
    /// <summary>
    /// It specifies the gloss for a synset.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/gloss"></see></summary>
    let gloss = Namespaced_IRI.parse _namespace_name "gloss" |> NamespacedName
    /// <summary>
    /// It specifies that the second synset is a meronym of the first synset. This relation only holds for nouns.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/holonymOf"></see></summary>
    let holonymOf = Namespaced_IRI.parse _namespace_name "holonymOf" |> NamespacedName
    /// <summary>
    /// noun/noun, e.g. nose/face
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/meronymOf"></see></summary>
    let meronymOf = Namespaced_IRI.parse _namespace_name "meronymOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/03/wn/wn20/schema/hypernymOf"></see>
    /// </summary>
    let hypernymOf = Namespaced_IRI.parse _namespace_name "hypernymOf" |> NamespacedName
    /// <summary>
    /// It specifies that the second synset is a hypernym of the first synset. This relation holds for nouns and verbs. The symmetric operator, hyponym, implies that the first synset is a hyponym of the second synset.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/hyponymOf"></see></summary>
    let hyponymOf = Namespaced_IRI.parse _namespace_name "hyponymOf" |> NamespacedName

    /// <summary>
    /// A datatype relation between Word and its lexical form.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/lexicalForm"></see></summary>
    let lexicalForm =
        Namespaced_IRI.parse _namespace_name "lexicalForm" |> NamespacedName

    /// <summary>
    /// It specifies that the second synset is a member meronym of the first synset. This relation only holds for nouns.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/memberHolonymOf"></see></summary>
    let memberHolonymOf =
        Namespaced_IRI.parse _namespace_name "memberHolonymOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/03/wn/wn20/schema/memberMeronymOf"></see>
    /// </summary>
    let memberMeronymOf =
        Namespaced_IRI.parse _namespace_name "memberMeronymOf" |> NamespacedName

    /// <summary>
    /// It specifies that the second synset is a part meronym of the first synset. This relation only holds for nouns.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/partHolonymOf"></see></summary>
    let partHolonymOf =
        Namespaced_IRI.parse _namespace_name "partHolonymOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/03/wn/wn20/schema/partMeronymOf"></see>
    /// </summary>
    let partMeronymOf =
        Namespaced_IRI.parse _namespace_name "partMeronymOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/03/wn/wn20/schema/participle"></see>
    /// </summary>
    let participle = Namespaced_IRI.parse _namespace_name "participle" |> NamespacedName

    /// <summary>
    /// It specifies that the adjective first word is a participle of the verb second word.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/participleOf"></see></summary>
    let participleOf =
        Namespaced_IRI.parse _namespace_name "participleOf" |> NamespacedName

    /// <summary>
    /// It specifies verb synsets that are similar in meaning and should be grouped together when displayed in response to a grouped synset search.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/sameVerbGroupAs"></see></summary>
    let sameVerbGroupAs =
        Namespaced_IRI.parse _namespace_name "sameVerbGroupAs" |> NamespacedName

    /// <summary>
    /// It specifies that additional information about the first word can be obtained by seeing the second word. This operator is only defined for verbs and adjectives.
    /// There is no symmetric relation (ie. it cannot be inferred that the additional information about the second word can be obtained from the first word).
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/seeAlso"></see></summary>
    let seeAlso = Namespaced_IRI.parse _namespace_name "seeAlso" |> NamespacedName
    /// <summary>
    /// It specifies that the second synset is similar in meaning to the first synset. This means that the second synset is a satellite of the first synset, which is the cluster head. This relation only holds for adjective synsets contained in adjective clusters.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/similarTo"></see></summary>
    let similarTo = Namespaced_IRI.parse _namespace_name "similarTo" |> NamespacedName

    /// <summary>
    /// It specifies that the second synset is a substance meronym of the first synset. This relation only holds for nouns.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/substanceHolonymOf"></see></summary>
    let substanceHolonymOf =
        Namespaced_IRI.parse _namespace_name "substanceHolonymOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/03/wn/wn20/schema/substanceMeronymOf"></see>
    /// </summary>
    let substanceMeronymOf =
        Namespaced_IRI.parse _namespace_name "substanceMeronymOf" |> NamespacedName

    /// <summary>
    /// A datatype relation between synsets and their integer identifiers.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/synsetId"></see></summary>
    let synsetId = Namespaced_IRI.parse _namespace_name "synsetId" |> NamespacedName
    /// <summary>
    /// A datatype relation between word senses and their tags within synsets.
    /// <see href="http://www.w3.org/2006/03/wn/wn20/schema/tagCount"></see></summary>
    let tagCount = Namespaced_IRI.parse _namespace_name "tagCount" |> NamespacedName
