#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module wn20schema =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/2006/03/wn/wn20/schema/" "wn20schema"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : A Synset in an adjective cluster representing a concept that is similar in meaning to the concept represented by its head synset .^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/AdjectiveSatelliteSynset">wn20schema:AdjectiveSatelliteSynset</a>
    /// </summary>
    let AdjectiveSatelliteSynset = _prefixId.prefix "AdjectiveSatelliteSynset"
    /// <summary>
    ///   <para>rdfs:comment : A sense of an adjective satellite word.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/AdjectiveSatelliteWordSense">wn20schema:AdjectiveSatelliteWordSense</a>
    /// </summary>
    let AdjectiveSatelliteWordSense = _prefixId.prefix "AdjectiveSatelliteWordSense"
    /// <summary>
    ///   <para>rdfs:comment : A synset including adjective word senses.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/AdjectiveSynset">wn20schema:AdjectiveSynset</a>
    /// </summary>
    let AdjectiveSynset = _prefixId.prefix "AdjectiveSynset"
    /// <summary>
    ///   <para>rdfs:comment : A sense of an adjective word.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/AdjectiveWordSense">wn20schema:AdjectiveWordSense</a>
    /// </summary>
    let AdjectiveWordSense = _prefixId.prefix "AdjectiveWordSense"
    /// <summary>
    ///   <para>rdfs:comment : A synset including adverb word senses.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/AdverbSynset">wn20schema:AdverbSynset</a>
    /// </summary>
    let AdverbSynset = _prefixId.prefix "AdverbSynset"
    /// <summary>
    ///   <para>rdfs:comment : A meaning of an adverb word.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/AdverbWordSense">wn20schema:AdverbWordSense</a>
    /// </summary>
    let AdverbWordSense = _prefixId.prefix "AdverbWordSense"
    /// <summary>
    ///   <para>rdfs:comment : A collocation in WordNet is a string of two or more words, connected by spaces or hyphens. Examples are: man-eating shark , blue-collar , depend on , line of products . In the database files spaces are represented as underscore (_ ) characters.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/Collocation">wn20schema:Collocation</a>
    /// </summary>
    let Collocation = _prefixId.prefix "Collocation"
    /// <summary>
    ///   <para>rdfs:comment : A synset including noun word senses.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/NounSynset">wn20schema:NounSynset</a>
    /// </summary>
    let NounSynset = _prefixId.prefix "NounSynset"
    /// <summary>
    ///   <para>rdfs:comment : A meaning of a noun word.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/NounWordSense">wn20schema:NounWordSense</a>
    /// </summary>
    let NounWordSense = _prefixId.prefix "NounWordSense"
    /// <summary>
    ///   <para>rdfs:comment : A synonym set; a set of words that are interchangeable in some context.
    ///
    /// ******************************
    /// Word and WordSenses are distinguished in this datamodel for two reasons:
    /// 1) WordNet uses the distinction in the database, and several relations are defined for WordSenses rather than for Synsets.
    /// 2) For the sake of ontological clarity, here it is assumed that Synsets include word senses, in order to partition the logical space of the lexicon (words as forms, which belong to different natural language lexica, words as meanings, which also can be peculiar to different natural languages, but usually exist in several of them, and synsets, which cluster word senses by abstracting out their distributional context.
    /// ******************************^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/Synset">wn20schema:Synset</a>
    /// </summary>
    let Synset = _prefixId.prefix "Synset"
    /// <summary>
    ///   <para>rdfs:comment : A synset including verb word senses.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/VerbSynset">wn20schema:VerbSynset</a>
    /// </summary>
    let VerbSynset = _prefixId.prefix "VerbSynset"
    /// <summary>
    ///   <para>rdfs:comment : A meaning of a verb word.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/VerbWordSense">wn20schema:VerbWordSense</a>
    /// </summary>
    let VerbWordSense = _prefixId.prefix "VerbWordSense"
    /// <summary>
    ///   <para>rdfs:comment : Any word or composed term (collocation) deputed to have a sense in WordNet.
    /// ****For the sake of ontological clarity, here it is assumed that synsets include word senses, in order to partition the logical space of the lexicon (words as forms, which belong to different natural language lexica, words as meanings, which also can be peculiar to different natural languages, but usually exist in several of them, and synsets, which cluster word senses by abstracting out their distributional context.****^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/Word">wn20schema:Word</a>
    /// </summary>
    let Word = _prefixId.prefix "Word"
    /// <summary>
    ///   <para>rdfs:comment : A meaning of a word in WordNet. Each sense of a word is in a different synset. Each word sense is contained in exactly one synset.
    ///
    /// ******************************
    /// Word and WordSenses are distinguished in this datamodel for two reasons:
    /// 1) WordNet uses the distinction in the database, and several relations are defined for WordSenses rather than for Synsets.
    /// 2) For the sake of ontological clarity, here it is assumed that synsets include word senses, in order to partition the logical space of the lexicon (words as forms, which belong to different natural language lexica, words as meanings, which also can be peculiar to different natural languages, but usually exist in several of them, and synsets, which cluster word senses by abstracting out their distributional context.
    /// ******************************^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/WordSense">wn20schema:WordSense</a>
    /// </summary>
    let WordSense = _prefixId.prefix "WordSense"
    /// <summary>
    ///   <para>rdfs:comment : It specifies an adjective word sense that pertains to either the noun or adjective second word sense.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/adjectivePertainsTo">wn20schema:adjectivePertainsTo</a>
    /// </summary>
    let adjectivePertainsTo = _prefixId.prefix "adjectivePertainsTo"
    /// <summary>
    ///   <para>rdfs:comment : It specifies an adverb word sense that pertains to the adjective second word sense.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/adverbPertainsTo">wn20schema:adverbPertainsTo</a>
    /// </summary>
    let adverbPertainsTo = _prefixId.prefix "adverbPertainsTo"
    /// <summary>
    ///   <para>rdfs:comment : It specifies antonymous word senses. This is a lexical relation that holds for all syntactic categories. For each antonymous pair, both relations are listed.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/antonymOf">wn20schema:antonymOf</a>
    /// </summary>
    let antonymOf = _prefixId.prefix "antonymOf"
    /// <summary>
    ///   <para>rdfs:comment : It defines the attribute relation between noun and adjective synset pairs in which the adjective is a value of the noun.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/attribute">wn20schema:attribute</a>
    /// </summary>
    let attribute = _prefixId.prefix "attribute"
    let attributeOf = _prefixId.prefix "attributeOf"
    /// <summary>
    ///   <para>rdfs:comment : It specifies that the second synset is a cause of the first synset. This relation only holds for verbs.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/causedBy">wn20schema:causedBy</a>
    /// </summary>
    let causedBy = _prefixId.prefix "causedBy"
    /// <summary>
    ///   <para>rdfs:comment : inverse of causedBy^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/causes">wn20schema:causes</a>
    /// </summary>
    let causes = _prefixId.prefix "causes"
    /// <summary>
    ///   <para>rdfs:comment : It specifies that the first synset has been classified as a member of the class (either as topic or 'category', as region, or as usage) represented by the second (noun) synset.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/classifiedBy">wn20schema:classifiedBy</a>
    /// </summary>
    let classifiedBy = _prefixId.prefix "classifiedBy"
    let classifiedByRegion = _prefixId.prefix "classifiedByRegion"
    let classifiedByTopic = _prefixId.prefix "classifiedByTopic"
    let classifiedByUsage = _prefixId.prefix "classifiedByUsage"
    let classifies = _prefixId.prefix "classifies"
    /// <summary>
    ///   <para>rdfs:comment : ****A relation added here to link synsets and word senses explicitly (in the WordNet db, it is implicit in the sense tag record)****^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/containsWordSense">wn20schema:containsWordSense</a>
    /// </summary>
    let containsWordSense = _prefixId.prefix "containsWordSense"
    /// <summary>
    ///   <para>rdfs:comment : It specifies that there exists a symmetric lexical morphosemantic relation between the first and second synset terms representing derivational morphology.
    /// ***In the WordNet database this relation extends over word senses within synsets***^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/derivationallyRelated">wn20schema:derivationallyRelated</a>
    /// </summary>
    let derivationallyRelated = _prefixId.prefix "derivationallyRelated"
    let entailedBy = _prefixId.prefix "entailedBy"
    /// <summary>
    ///   <para>rdfs:comment : A verb X entails Y if X cannot be done unless Y is, or has been, done.
    /// It specifies that the second synset is an entailment of first synset. This relation only holds for verbs.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/entails">wn20schema:entails</a>
    /// </summary>
    let entails = _prefixId.prefix "entails"
    /// <summary>
    ///   <para>rdfs:comment : It specifies a generic sentence frame for one or all words in a synset. The operator is defined only for verbs.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/frame">wn20schema:frame</a>
    /// </summary>
    let frame = _prefixId.prefix "frame"
    /// <summary>
    ///   <para>rdfs:comment : It specifies the gloss for a synset.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/gloss">wn20schema:gloss</a>
    /// </summary>
    let gloss = _prefixId.prefix "gloss"
    /// <summary>
    ///   <para>rdfs:comment : It specifies that the second synset is a meronym of the first synset. This relation only holds for nouns.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/holonymOf">wn20schema:holonymOf</a>
    /// </summary>
    let holonymOf = _prefixId.prefix "holonymOf"
    let hypernymOf = _prefixId.prefix "hypernymOf"
    /// <summary>
    ///   <para>rdfs:comment : It specifies that the second synset is a hypernym of the first synset. This relation holds for nouns and verbs. The symmetric operator, hyponym, implies that the first synset is a hyponym of the second synset.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/hyponymOf">wn20schema:hyponymOf</a>
    /// </summary>
    let hyponymOf = _prefixId.prefix "hyponymOf"
    /// <summary>
    ///   <para>rdfs:comment : ****A relation added here to link word senses and synsets explicitly (in the WordNet db, it is implicit in the sense tag record)****^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/inSynset">wn20schema:inSynset</a>
    /// </summary>
    let inSynset = _prefixId.prefix "inSynset"
    /// <summary>
    ///   <para>rdfs:comment : A datatype relation between Word and its lexical form.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/lexicalForm">wn20schema:lexicalForm</a>
    /// </summary>
    let lexicalForm = _prefixId.prefix "lexicalForm"
    /// <summary>
    ///   <para>rdfs:comment : It specifies that the second synset is a member meronym of the first synset. This relation only holds for nouns.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/memberHolonymOf">wn20schema:memberHolonymOf</a>
    /// </summary>
    let memberHolonymOf = _prefixId.prefix "memberHolonymOf"
    let memberMeronymOf = _prefixId.prefix "memberMeronymOf"
    /// <summary>
    ///   <para>rdfs:comment : noun/noun, e.g. nose/face^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/meronymOf">wn20schema:meronymOf</a>
    /// </summary>
    let meronymOf = _prefixId.prefix "meronymOf"
    /// <summary>
    ///   <para>rdfs:comment : It specifies that the second synset is a part meronym of the first synset. This relation only holds for nouns.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/partHolonymOf">wn20schema:partHolonymOf</a>
    /// </summary>
    let partHolonymOf = _prefixId.prefix "partHolonymOf"
    let partMeronymOf = _prefixId.prefix "partMeronymOf"
    let participle = _prefixId.prefix "participle"
    /// <summary>
    ///   <para>rdfs:comment : It specifies that the adjective first word is a participle of the verb second word.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/participleOf">wn20schema:participleOf</a>
    /// </summary>
    let participleOf = _prefixId.prefix "participleOf"
    /// <summary>
    ///   <para>rdfs:comment : It specifies verb synsets that are similar in meaning and should be grouped together when displayed in response to a grouped synset search.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/sameVerbGroupAs">wn20schema:sameVerbGroupAs</a>
    /// </summary>
    let sameVerbGroupAs = _prefixId.prefix "sameVerbGroupAs"
    /// <summary>
    ///   <para>rdfs:comment : It specifies that additional information about the first word can be obtained by seeing the second word. This operator is only defined for verbs and adjectives.
    /// There is no symmetric relation (ie. it cannot be inferred that the additional information about the second word can be obtained from the first word).^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/seeAlso">wn20schema:seeAlso</a>
    /// </summary>
    let seeAlso = _prefixId.prefix "seeAlso"
    /// <summary>
    ///   <para>rdfs:comment : ****A relation added here to link words and word senses explicitly (in the WordNet db, it is implicit in the synset record)****^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/sense">wn20schema:sense</a>
    /// </summary>
    let sense = _prefixId.prefix "sense"
    /// <summary>
    ///   <para>rdfs:comment : It specifies that the second synset is similar in meaning to the first synset. This means that the second synset is a satellite of the first synset, which is the cluster head. This relation only holds for adjective synsets contained in adjective clusters.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/similarTo">wn20schema:similarTo</a>
    /// </summary>
    let similarTo = _prefixId.prefix "similarTo"
    /// <summary>
    ///   <para>rdfs:comment : It specifies that the second synset is a substance meronym of the first synset. This relation only holds for nouns.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/substanceHolonymOf">wn20schema:substanceHolonymOf</a>
    /// </summary>
    let substanceHolonymOf = _prefixId.prefix "substanceHolonymOf"
    let substanceMeronymOf = _prefixId.prefix "substanceMeronymOf"
    /// <summary>
    ///   <para>rdfs:comment : A datatype relation between synsets and their integer identifiers.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/synsetId">wn20schema:synsetId</a>
    /// </summary>
    let synsetId = _prefixId.prefix "synsetId"
    /// <summary>
    ///   <para>rdfs:comment : A datatype relation between word senses and their tags within synsets.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/tagCount">wn20schema:tagCount</a>
    /// </summary>
    let tagCount = _prefixId.prefix "tagCount"
    /// <summary>
    ///   <para>rdfs:comment : ****A relation added here to link word senses and words explicitly (in the WordNet db, it is implicit in the synset record)****^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/03/wn/wn20/schema/word">wn20schema:word</a>
    /// </summary>
    let word = _prefixId.prefix "word"
