namespace http.www.w3.org._2006._03.wn.wn20.schema.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wn20schema =
    let _namespace_iri = Namespace_Iri wn20schema |> NamespaceIRI

    /// <summary>
    ///   <para>wn20schema:AdjectiveSatelliteSynset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A Synset in an adjective cluster representing a concept that is similar in meaning to the concept represented by its head synset .</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/AdjectiveSatelliteSynset">http://www.w3.org/2006/03/wn/wn20/schema/AdjectiveSatelliteSynset</seealso>
    let AdjectiveSatelliteSynset =
        Prefixed_Name(wn20schema, "AdjectiveSatelliteSynset") |> PrefixedName

    /// <summary>
    ///   <para>wn20schema:AdjectiveWordSense</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A sense of an adjective word.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/AdjectiveWordSense">http://www.w3.org/2006/03/wn/wn20/schema/AdjectiveWordSense</seealso>
    let AdjectiveWordSense =
        Prefixed_Name(wn20schema, "AdjectiveWordSense") |> PrefixedName

    /// <summary>
    ///   <para>wn20schema:Synset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A synonym set; a set of words that are interchangeable in some context.
    ///
    /// ******************************
    /// Word and WordSenses are distinguished in this datamodel for two reasons:
    /// 1) WordNet uses the distinction in the database, and several relations are defined for WordSenses rather than for Synsets.
    /// 2) For the sake of ontological clarity, here it is assumed that Synsets include word senses, in order to partition the logical space of the lexicon (words as forms, which belong to different natural language lexica, words as meanings, which also can be peculiar to different natural languages, but usually exist in several of them, and synsets, which cluster word senses by abstracting out their distributional context.
    /// ******************************</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/Synset">http://www.w3.org/2006/03/wn/wn20/schema/Synset</seealso>
    let Synset = Prefixed_Name(wn20schema, "Synset") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:AdverbSynset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A synset including adverb word senses.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/AdverbSynset">http://www.w3.org/2006/03/wn/wn20/schema/AdverbSynset</seealso>
    let AdverbSynset = Prefixed_Name(wn20schema, "AdverbSynset") |> PrefixedName

    /// <summary>
    ///   <para>wn20schema:containsWordSense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>****A relation added here to link synsets and word senses explicitly (in the WordNet db, it is implicit in the sense tag record)****</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/containsWordSense">http://www.w3.org/2006/03/wn/wn20/schema/containsWordSense</seealso>
    let containsWordSense =
        Prefixed_Name(wn20schema, "containsWordSense") |> PrefixedName

    /// <summary>
    ///   <para>wn20schema:frame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>It specifies a generic sentence frame for one or all words in a synset. The operator is defined only for verbs.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/frame">http://www.w3.org/2006/03/wn/wn20/schema/frame</seealso>
    let frame = Prefixed_Name(wn20schema, "frame") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:lexicalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A datatype relation between Word and its lexical form.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/lexicalForm">http://www.w3.org/2006/03/wn/wn20/schema/lexicalForm</seealso>
    let lexicalForm = Prefixed_Name(wn20schema, "lexicalForm") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:memberMeronymOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/memberMeronymOf">http://www.w3.org/2006/03/wn/wn20/schema/memberMeronymOf</seealso>
    let memberMeronymOf = Prefixed_Name(wn20schema, "memberMeronymOf") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:participleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>It specifies that the adjective first word is a participle of the verb second word.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/participleOf">http://www.w3.org/2006/03/wn/wn20/schema/participleOf</seealso>
    let participleOf = Prefixed_Name(wn20schema, "participleOf") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:similarTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>It specifies that the second synset is similar in meaning to the first synset. This means that the second synset is a satellite of the first synset, which is the cluster head. This relation only holds for adjective synsets contained in adjective clusters.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/similarTo">http://www.w3.org/2006/03/wn/wn20/schema/similarTo</seealso>
    let similarTo = Prefixed_Name(wn20schema, "similarTo") |> PrefixedName

    /// <summary>
    ///   <para>wn20schema:substanceMeronymOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/substanceMeronymOf">http://www.w3.org/2006/03/wn/wn20/schema/substanceMeronymOf</seealso>
    let substanceMeronymOf =
        Prefixed_Name(wn20schema, "substanceMeronymOf") |> PrefixedName

    /// <summary>
    ///   <para>wn20schema:tagCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A datatype relation between word senses and their tags within synsets.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/tagCount">http://www.w3.org/2006/03/wn/wn20/schema/tagCount</seealso>
    let tagCount = Prefixed_Name(wn20schema, "tagCount") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:Collocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A collocation in WordNet is a string of two or more words, connected by spaces or hyphens. Examples are: man-eating shark , blue-collar , depend on , line of products . In the database files spaces are represented as underscore (_ ) characters.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/Collocation">http://www.w3.org/2006/03/wn/wn20/schema/Collocation</seealso>
    let Collocation = Prefixed_Name(wn20schema, "Collocation") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:AdverbWordSense</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A meaning of an adverb word.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/AdverbWordSense">http://www.w3.org/2006/03/wn/wn20/schema/AdverbWordSense</seealso>
    let AdverbWordSense = Prefixed_Name(wn20schema, "AdverbWordSense") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:Word</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Any word or composed term (collocation) deputed to have a sense in WordNet.
    /// ****For the sake of ontological clarity, here it is assumed that synsets include word senses, in order to partition the logical space of the lexicon (words as forms, which belong to different natural language lexica, words as meanings, which also can be peculiar to different natural languages, but usually exist in several of them, and synsets, which cluster word senses by abstracting out their distributional context.****</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/Word">http://www.w3.org/2006/03/wn/wn20/schema/Word</seealso>
    let Word = Prefixed_Name(wn20schema, "Word") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:NounSynset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A synset including noun word senses.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/NounSynset">http://www.w3.org/2006/03/wn/wn20/schema/NounSynset</seealso>
    let NounSynset = Prefixed_Name(wn20schema, "NounSynset") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:VerbSynset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A synset including verb word senses.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/VerbSynset">http://www.w3.org/2006/03/wn/wn20/schema/VerbSynset</seealso>
    let VerbSynset = Prefixed_Name(wn20schema, "VerbSynset") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:NounWordSense</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A meaning of a noun word.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/NounWordSense">http://www.w3.org/2006/03/wn/wn20/schema/NounWordSense</seealso>
    let NounWordSense = Prefixed_Name(wn20schema, "NounWordSense") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:VerbWordSense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A meaning of a verb word.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/VerbWordSense">http://www.w3.org/2006/03/wn/wn20/schema/VerbWordSense</seealso>
    let VerbWordSense = Prefixed_Name(wn20schema, "VerbWordSense") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:sense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>****A relation added here to link words and word senses explicitly (in the WordNet db, it is implicit in the synset record)****</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/sense">http://www.w3.org/2006/03/wn/wn20/schema/sense</seealso>
    let sense = Prefixed_Name(wn20schema, "sense") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:word</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>****A relation added here to link word senses and words explicitly (in the WordNet db, it is implicit in the synset record)****</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/word">http://www.w3.org/2006/03/wn/wn20/schema/word</seealso>
    let word = Prefixed_Name(wn20schema, "word") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:adverbPertainsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>It specifies an adverb word sense that pertains to the adjective second word sense.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/adverbPertainsTo">http://www.w3.org/2006/03/wn/wn20/schema/adverbPertainsTo</seealso>
    let adverbPertainsTo = Prefixed_Name(wn20schema, "adverbPertainsTo") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:causedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It specifies that the second synset is a cause of the first synset. This relation only holds for verbs.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/causedBy">http://www.w3.org/2006/03/wn/wn20/schema/causedBy</seealso>
    let causedBy = Prefixed_Name(wn20schema, "causedBy") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:classifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>It specifies that the first synset has been classified as a member of the class (either as topic or 'category', as region, or as usage) represented by the second (noun) synset.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/classifiedBy">http://www.w3.org/2006/03/wn/wn20/schema/classifiedBy</seealso>
    let classifiedBy = Prefixed_Name(wn20schema, "classifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:classifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/classifies">http://www.w3.org/2006/03/wn/wn20/schema/classifies</seealso>
    let classifies = Prefixed_Name(wn20schema, "classifies") |> PrefixedName

    /// <summary>
    ///   <para>wn20schema:classifiedByRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/classifiedByRegion">http://www.w3.org/2006/03/wn/wn20/schema/classifiedByRegion</seealso>
    let classifiedByRegion =
        Prefixed_Name(wn20schema, "classifiedByRegion") |> PrefixedName

    /// <summary>
    ///   <para>wn20schema:derivationallyRelated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>It specifies that there exists a symmetric lexical morphosemantic relation between the first and second synset terms representing derivational morphology.
    /// ***In the WordNet database this relation extends over word senses within synsets***</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/derivationallyRelated">http://www.w3.org/2006/03/wn/wn20/schema/derivationallyRelated</seealso>
    let derivationallyRelated =
        Prefixed_Name(wn20schema, "derivationallyRelated") |> PrefixedName

    /// <summary>
    ///   <para>wn20schema:entailedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/entailedBy">http://www.w3.org/2006/03/wn/wn20/schema/entailedBy</seealso>
    let entailedBy = Prefixed_Name(wn20schema, "entailedBy") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:gloss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>It specifies the gloss for a synset.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/gloss">http://www.w3.org/2006/03/wn/wn20/schema/gloss</seealso>
    let gloss = Prefixed_Name(wn20schema, "gloss") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:meronymOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>noun/noun, e.g. nose/face</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/meronymOf">http://www.w3.org/2006/03/wn/wn20/schema/meronymOf</seealso>
    let meronymOf = Prefixed_Name(wn20schema, "meronymOf") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:hypernymOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/hypernymOf">http://www.w3.org/2006/03/wn/wn20/schema/hypernymOf</seealso>
    let hypernymOf = Prefixed_Name(wn20schema, "hypernymOf") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:hyponymOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>It specifies that the second synset is a hypernym of the first synset. This relation holds for nouns and verbs. The symmetric operator, hyponym, implies that the first synset is a hyponym of the second synset.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/hyponymOf">http://www.w3.org/2006/03/wn/wn20/schema/hyponymOf</seealso>
    let hyponymOf = Prefixed_Name(wn20schema, "hyponymOf") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:partHolonymOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It specifies that the second synset is a part meronym of the first synset. This relation only holds for nouns.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/partHolonymOf">http://www.w3.org/2006/03/wn/wn20/schema/partHolonymOf</seealso>
    let partHolonymOf = Prefixed_Name(wn20schema, "partHolonymOf") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:partMeronymOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/partMeronymOf">http://www.w3.org/2006/03/wn/wn20/schema/partMeronymOf</seealso>
    let partMeronymOf = Prefixed_Name(wn20schema, "partMeronymOf") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:sameVerbGroupAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>It specifies verb synsets that are similar in meaning and should be grouped together when displayed in response to a grouped synset search.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/sameVerbGroupAs">http://www.w3.org/2006/03/wn/wn20/schema/sameVerbGroupAs</seealso>
    let sameVerbGroupAs = Prefixed_Name(wn20schema, "sameVerbGroupAs") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:seeAlso</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>It specifies that additional information about the first word can be obtained by seeing the second word. This operator is only defined for verbs and adjectives.
    /// There is no symmetric relation (ie. it cannot be inferred that the additional information about the second word can be obtained from the first word).</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/seeAlso">http://www.w3.org/2006/03/wn/wn20/schema/seeAlso</seealso>
    let seeAlso = Prefixed_Name(wn20schema, "seeAlso") |> PrefixedName

    /// <summary>
    ///   <para>wn20schema:adjectivePertainsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>It specifies an adjective word sense that pertains to either the noun or adjective second word sense.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/adjectivePertainsTo">http://www.w3.org/2006/03/wn/wn20/schema/adjectivePertainsTo</seealso>
    let adjectivePertainsTo =
        Prefixed_Name(wn20schema, "adjectivePertainsTo") |> PrefixedName

    /// <summary>
    ///   <para>wn20schema:antonymOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>It specifies antonymous word senses. This is a lexical relation that holds for all syntactic categories. For each antonymous pair, both relations are listed.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/antonymOf">http://www.w3.org/2006/03/wn/wn20/schema/antonymOf</seealso>
    let antonymOf = Prefixed_Name(wn20schema, "antonymOf") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:attributeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/attributeOf">http://www.w3.org/2006/03/wn/wn20/schema/attributeOf</seealso>
    let attributeOf = Prefixed_Name(wn20schema, "attributeOf") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:attribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>It defines the attribute relation between noun and adjective synset pairs in which the adjective is a value of the noun.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/attribute">http://www.w3.org/2006/03/wn/wn20/schema/attribute</seealso>
    let attribute = Prefixed_Name(wn20schema, "attribute") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:causes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>inverse of causedBy</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/causes">http://www.w3.org/2006/03/wn/wn20/schema/causes</seealso>
    let causes = Prefixed_Name(wn20schema, "causes") |> PrefixedName

    /// <summary>
    ///   <para>wn20schema:classifiedByUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/classifiedByUsage">http://www.w3.org/2006/03/wn/wn20/schema/classifiedByUsage</seealso>
    let classifiedByUsage =
        Prefixed_Name(wn20schema, "classifiedByUsage") |> PrefixedName

    /// <summary>
    ///   <para>wn20schema:classifiedByTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/classifiedByTopic">http://www.w3.org/2006/03/wn/wn20/schema/classifiedByTopic</seealso>
    let classifiedByTopic =
        Prefixed_Name(wn20schema, "classifiedByTopic") |> PrefixedName

    /// <summary>
    ///   <para>wn20schema:entails</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>A verb X entails Y if X cannot be done unless Y is, or has been, done.
    /// It specifies that the second synset is an entailment of first synset. This relation only holds for verbs.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/entails">http://www.w3.org/2006/03/wn/wn20/schema/entails</seealso>
    let entails = Prefixed_Name(wn20schema, "entails") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:holonymOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It specifies that the second synset is a meronym of the first synset. This relation only holds for nouns.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/holonymOf">http://www.w3.org/2006/03/wn/wn20/schema/holonymOf</seealso>
    let holonymOf = Prefixed_Name(wn20schema, "holonymOf") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:memberHolonymOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It specifies that the second synset is a member meronym of the first synset. This relation only holds for nouns.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/memberHolonymOf">http://www.w3.org/2006/03/wn/wn20/schema/memberHolonymOf</seealso>
    let memberHolonymOf = Prefixed_Name(wn20schema, "memberHolonymOf") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:participle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/participle">http://www.w3.org/2006/03/wn/wn20/schema/participle</seealso>
    let participle = Prefixed_Name(wn20schema, "participle") |> PrefixedName

    /// <summary>
    ///   <para>wn20schema:substanceHolonymOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It specifies that the second synset is a substance meronym of the first synset. This relation only holds for nouns.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/substanceHolonymOf">http://www.w3.org/2006/03/wn/wn20/schema/substanceHolonymOf</seealso>
    let substanceHolonymOf =
        Prefixed_Name(wn20schema, "substanceHolonymOf") |> PrefixedName

    /// <summary>
    ///   <para>wn20schema:synsetId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A datatype relation between synsets and their integer identifiers.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/synsetId">http://www.w3.org/2006/03/wn/wn20/schema/synsetId</seealso>
    let synsetId = Prefixed_Name(wn20schema, "synsetId") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>From WordNet documentation (http://wordnet.princeton.edu/man/wngloss.7WN):               Information in WordNet is organized around logical groupings called synsets. Each synset consists of a list of synonymous words or collocations (eg. "fountain pen" , "take in" ), and pointers that describe the relations between this synset and other synsets. A word or collocation may appear in more than one synset, and in more than one part of speech. The words in a synset are logically grouped such that they are interchangeable in some context.   Two kinds of relations are represented by pointers: lexical and semantic. Lexical relations hold between word forms; semantic relations hold between word meanings. These relations include (but are not limited to) hypernymy/hyponymy, antonymy, entailment, and meronymy/holonymy.   Nouns and verbs are organized into hierarchies based on the hypernymy/hyponymy relation between synsets. Additional pointers are be used to indicate other relations.   Adjectives are arranged in clusters containing head synsets and satellite synsets. Each cluster is organized around antonymous pairs (and occasionally antonymous triplets). The antonymous pairs (or triplets) are indicated in the head synsets of a cluster. Most head synsets have one or more satellite synsets, each of which represents a concept that is similar in meaning to the concept represented by the head synset. One way to think of the adjective cluster organization is to visualize a wheel, with a head synset as the hub and satellite synsets as the spokes. Two or more wheels are logically connected via antonymy, which can be thought of as an axle between the wheels.   Pertainyms are relational adjectives and do not follow the structure just described. Pertainyms do not have antonyms; the synset for a pertainym most often contains only one word or collocation and a lexical pointer to the noun that the adjective is "of or pertaining to". Participial adjectives have lexical pointers to the verbs that they are derived from.   Adverbs are often derived from adjectives, and sometimes have antonyms; therefore the synset for an adverb usually contains a lexical pointer to the adjective from which it is derived.</para>
    ///   <para>WordNet2.0 datamodel, version 7.       This ontology is an attempt to encode part of the WordNet 2.0 datamodel into OWL. It is part of the work made by the WNET Task Force of the SWBPD Working Group of W3C.       First version has been edited by Guus Schreiber, then revised by Brian McBride. Current version (4) has been enlarged, commented, and       checked after the original WordNet specifications by Aldo Gangemi. V5: Minor adaptations/additions for RDFS/OWL compatibility by Mark van Assem.
    ///     Changes from V5 to V6 of the datamodel: added some missing inverse properties, added owl:SymmetricProperty for wn:sameVerbGroupAs, wn:derivationallyRelated.
    ///     Removed two nameless classes. V6 to V7: added class AdjectiveSatelliteWordSense.
    /// </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/">http://www.w3.org/2006/03/wn/wn20/schema/</seealso>
    let _prefix_iri = Prefixed_Name(wn20schema, "") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:AdjectiveSynset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A synset including adjective word senses.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/AdjectiveSynset">http://www.w3.org/2006/03/wn/wn20/schema/AdjectiveSynset</seealso>
    let AdjectiveSynset = Prefixed_Name(wn20schema, "AdjectiveSynset") |> PrefixedName

    /// <summary>
    ///   <para>wn20schema:AdjectiveSatelliteWordSense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A sense of an adjective satellite word.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/AdjectiveSatelliteWordSense">http://www.w3.org/2006/03/wn/wn20/schema/AdjectiveSatelliteWordSense</seealso>
    let AdjectiveSatelliteWordSense =
        Prefixed_Name(wn20schema, "AdjectiveSatelliteWordSense") |> PrefixedName

    /// <summary>
    ///   <para>wn20schema:inSynset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>****A relation added here to link word senses and synsets explicitly (in the WordNet db, it is implicit in the sense tag record)****</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/inSynset">http://www.w3.org/2006/03/wn/wn20/schema/inSynset</seealso>
    let inSynset = Prefixed_Name(wn20schema, "inSynset") |> PrefixedName
    /// <summary>
    ///   <para>wn20schema:WordSense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A meaning of a word in WordNet. Each sense of a word is in a different synset. Each word sense is contained in exactly one synset.
    ///
    /// ******************************
    /// Word and WordSenses are distinguished in this datamodel for two reasons:
    /// 1) WordNet uses the distinction in the database, and several relations are defined for WordSenses rather than for Synsets.
    /// 2) For the sake of ontological clarity, here it is assumed that synsets include word senses, in order to partition the logical space of the lexicon (words as forms, which belong to different natural language lexica, words as meanings, which also can be peculiar to different natural languages, but usually exist in several of them, and synsets, which cluster word senses by abstracting out their distributional context.
    /// ******************************</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/03/wn/wn20/schema/WordSense">http://www.w3.org/2006/03/wn/wn20/schema/WordSense</seealso>
    let WordSense = Prefixed_Name(wn20schema, "WordSense") |> PrefixedName
