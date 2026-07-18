namespace http.purl.org.olia.ubyCat.owl.hash

open DoxAletheia.Rdf_Vocabulary

module uby =
    let _namespace_name = "http://purl.org/olia/ubyCat.owl#"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Case"></see>
    /// </summary>
    let Case = Namespaced_IRI.parse _namespace_name "Case" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#WordFormAttribute"></see>
    /// </summary>
    let WordFormAttribute =
        Namespaced_IRI.parse _namespace_name "WordFormAttribute" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Complementizer"></see>
    /// </summary>
    let Complementizer =
        Namespaced_IRI.parse _namespace_name "Complementizer" |> NamespacedName

    /// <summary>
    /// SyntacticFeature groups attributes of UBY-LMF classes from the ISO LMF Syntax extension package.
    /// <see href="http://purl.org/olia/ubyCat.owl#SyntacticFeature"></see></summary>
    let SyntacticFeature =
        Namespaced_IRI.parse _namespace_name "SyntacticFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Context"></see>
    /// </summary>
    let Context = Namespaced_IRI.parse _namespace_name "Context" |> NamespacedName

    /// <summary>
    /// LexicalFeatureStructure is a complex lexical Feature Structure (with features and feature values) and corresponds to a class in LMF.
    /// <see href="http://purl.org/olia/ubyCat.owl#LexicalFeatureStructure"></see></summary>
    let LexicalFeatureStructure =
        Namespaced_IRI.parse _namespace_name "LexicalFeatureStructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#CoreType"></see>
    /// </summary>
    let CoreType = Namespaced_IRI.parse _namespace_name "CoreType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#SemanticFeature"></see>
    /// </summary>
    let SemanticFeature =
        Namespaced_IRI.parse _namespace_name "SemanticFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Definition"></see>
    /// </summary>
    let Definition = Namespaced_IRI.parse _namespace_name "Definition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#DefinitionType"></see>
    /// </summary>
    let DefinitionType =
        Namespaced_IRI.parse _namespace_name "DefinitionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#DictionaryFeature"></see>
    /// </summary>
    let DictionaryFeature =
        Namespaced_IRI.parse _namespace_name "DictionaryFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Degree"></see>
    /// </summary>
    let Degree = Namespaced_IRI.parse _namespace_name "Degree" |> NamespacedName

    /// <summary>
    /// In UBY-LMF, relType is an attribute of the RelatedForm class which encodes links to derivationally related lexical entries or senses.
    /// <see href="http://purl.org/olia/ubyCat.owl#DerivationType"></see></summary>
    let DerivationType =
        Namespaced_IRI.parse _namespace_name "DerivationType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#DerivationalMorphology"></see>
    /// </summary>
    let DerivationalMorphology =
        Namespaced_IRI.parse _namespace_name "DerivationalMorphology" |> NamespacedName

    /// <summary>
    /// LexicalFeature groups different kinds of lexical feaures, which correspond to attributes of UBY-LMF classes.
    /// <see href="http://purl.org/olia/ubyCat.owl#LexicalFeature"></see></summary>
    let LexicalFeature =
        Namespaced_IRI.parse _namespace_name "LexicalFeature" |> NamespacedName

    /// <summary>
    /// In UBY-LMF, determiner is an attribute of the LMF class SyntacticArgument. For noun phrase arguments, this attribute encodes specific constraints on the determiner to be used (possessive or indefinite).
    ///
    /// Example given in VerbNet (possessive): They allow our smoking.
    /// Example from VerbNet (indefinite): an indefinite determiner is required for the noun phrase complement of "echo" as in
    /// There echoed voices through the hall. (verb class sound_existence-47.4)
    /// <see href="http://purl.org/olia/ubyCat.owl#Determiner"></see></summary>
    let Determiner = Namespaced_IRI.parse _namespace_name "Determiner" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#ExampleType"></see>
    /// </summary>
    let ExampleType =
        Namespaced_IRI.parse _namespace_name "ExampleType" |> NamespacedName

    /// <summary>
    /// This owl:Class corresponds to the LMF-class Frequency which has been introduced in UBY-LMF as an extension of ISO-LMF.
    /// <see href="http://purl.org/olia/ubyCat.owl#Frequency"></see></summary>
    let Frequency = Namespaced_IRI.parse _namespace_name "Frequency" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#GrammaticalFunction"></see>
    /// </summary>
    let GrammaticalFunction =
        Namespaced_IRI.parse _namespace_name "GrammaticalFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#GrammaticalGender"></see>
    /// </summary>
    let GrammaticalGender =
        Namespaced_IRI.parse _namespace_name "GrammaticalGender" |> NamespacedName

    /// <summary>
    /// In UBY-LMF, number is also an attribute of the UBY-LMF class SyntacticArgument and specifies the grammatical number of an argument.
    /// Example: These types of fish mix well together.
    /// <see href="http://purl.org/olia/ubyCat.owl#GrammaticalNumber"></see></summary>
    let GrammaticalNumber =
        Namespaced_IRI.parse _namespace_name "GrammaticalNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Lemma"></see>
    /// </summary>
    let Lemma = Namespaced_IRI.parse _namespace_name "Lemma" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#LexicalAnnotation"></see>
    /// </summary>
    let LexicalAnnotation =
        Namespaced_IRI.parse _namespace_name "LexicalAnnotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#LexicalEntry"></see>
    /// </summary>
    let LexicalEntry =
        Namespaced_IRI.parse _namespace_name "LexicalEntry" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Lexicon"></see>
    /// </summary>
    let Lexicon = Namespaced_IRI.parse _namespace_name "Lexicon" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#LinkingFeature"></see>
    /// </summary>
    let LinkingFeature =
        Namespaced_IRI.parse _namespace_name "LinkingFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#MetaFeature"></see>
    /// </summary>
    let MetaFeature =
        Namespaced_IRI.parse _namespace_name "MetaFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#MonolingualExternalRef"></see>
    /// </summary>
    let MonolingualExternalRef =
        Namespaced_IRI.parse _namespace_name "MonolingualExternalRef" |> NamespacedName

    /// <summary>
    /// As a convention, the relation is called has_partOfSpeech, partOfSpeech is the top-level *class* of parts of speech
    /// <see href="http://purl.org/olia/ubyCat.owl#PartOfSpeech"></see></summary>
    let PartOfSpeech =
        Namespaced_IRI.parse _namespace_name "PartOfSpeech" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Person"></see>
    /// </summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Position"></see>
    /// </summary>
    let Position = Namespaced_IRI.parse _namespace_name "Position" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#multiwordFeature"></see>
    /// </summary>
    let multiwordFeature =
        Namespaced_IRI.parse _namespace_name "multiwordFeature" |> NamespacedName

    /// <summary>
    /// In UBY-LMF, quantification is an attribute of the class SemanticLabel. It can be used, if the value of the semantic label is annotated with a score, e.g. type=sentiment, label=positive, quantification=strong.
    ///
    /// <see href="http://purl.org/olia/ubyCat.owl#Quantification"></see></summary>
    let Quantification =
        Namespaced_IRI.parse _namespace_name "Quantification" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#RelType"></see>
    /// </summary>
    let RelType = Namespaced_IRI.parse _namespace_name "RelType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#SemanticArgument"></see>
    /// </summary>
    let SemanticArgument =
        Namespaced_IRI.parse _namespace_name "SemanticArgument" |> NamespacedName

    /// <summary>
    /// This owl:Class corresponds to the LMF-class SemanticLabel which has been introduced in UBY-LMF as an extension of ISO-LMF.
    /// <see href="http://purl.org/olia/ubyCat.owl#SemanticLabel"></see></summary>
    let SemanticLabel =
        Namespaced_IRI.parse _namespace_name "SemanticLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#SemanticPredicate"></see>
    /// </summary>
    let SemanticPredicate =
        Namespaced_IRI.parse _namespace_name "SemanticPredicate" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Sense"></see>
    /// </summary>
    let Sense = Namespaced_IRI.parse _namespace_name "Sense" |> NamespacedName

    /// <summary>
    /// In Uby-LMF, the attribute senseAxisType of the SenseAxis class indicates, whether the type of linking between to senses or between two synsets. Example values are monolingualSenseAlignment and crosslingualSenseAlignment
    /// <see href="http://purl.org/olia/ubyCat.owl#SenseAxisType"></see></summary>
    let SenseAxisType =
        Namespaced_IRI.parse _namespace_name "SenseAxisType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#SenseExample"></see>
    /// </summary>
    let SenseExample =
        Namespaced_IRI.parse _namespace_name "SenseExample" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#SubcategorizationFrame"></see>
    /// </summary>
    let SubcategorizationFrame =
        Namespaced_IRI.parse _namespace_name "SubcategorizationFrame" |> NamespacedName

    /// <summary>
    /// This owl:Class corresponds to the ISO LMF-class Synset.
    /// <see href="http://purl.org/olia/ubyCat.owl#Synset"></see></summary>
    let Synset = Namespaced_IRI.parse _namespace_name "Synset" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#SyntacticArgument"></see>
    /// </summary>
    let SyntacticArgument =
        Namespaced_IRI.parse _namespace_name "SyntacticArgument" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#SyntacticCategory"></see>
    /// </summary>
    let SyntacticCategory =
        Namespaced_IRI.parse _namespace_name "SyntacticCategory" |> NamespacedName

    /// <summary>
    /// Attribute of the UBY-LMF class SubcategorizationFrame.
    /// <see href="http://purl.org/olia/ubyCat.owl#SyntacticProperty"></see></summary>
    let SyntacticProperty =
        Namespaced_IRI.parse _namespace_name "SyntacticProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Tense"></see>
    /// </summary>
    let Tense = Namespaced_IRI.parse _namespace_name "Tense" |> NamespacedName
    /// <summary>
    /// Type is an attribute of the UBY-LMF class SemanticLabel. It encodes the name of a SemanticLabel type, e.g.
    /// type=semanticField (from WordNet or GermaNet).
    /// The label attribute of SemanticLabel holds the corresponding value of the SemanticLabel, e.g.
    /// label=animate (for type=semanticField).
    /// <see href="http://purl.org/olia/ubyCat.owl#Type"></see></summary>
    let Type = Namespaced_IRI.parse _namespace_name "Type" |> NamespacedName
    /// <summary>
    /// Specifies the verb form to be used in a verb phrase complement.
    /// <see href="http://purl.org/olia/ubyCat.owl#VerbForm"></see></summary>
    let VerbForm = Namespaced_IRI.parse _namespace_name "VerbForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#VerbFormMood"></see>
    /// </summary>
    let VerbFormMood =
        Namespaced_IRI.parse _namespace_name "VerbFormMood" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#WordForm"></see>
    /// </summary>
    let WordForm = Namespaced_IRI.parse _namespace_name "WordForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#abbreviation"></see>
    /// </summary>
    let abbreviation =
        Namespaced_IRI.parse _namespace_name "abbreviation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#abbreviationAcronym"></see>
    /// </summary>
    let abbreviationAcronym =
        Namespaced_IRI.parse _namespace_name "abbreviationAcronym" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#abbreviationInitialism"></see>
    /// </summary>
    let abbreviationInitialism =
        Namespaced_IRI.parse _namespace_name "abbreviationInitialism" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#accusative"></see>
    /// </summary>
    let accusative = Namespaced_IRI.parse _namespace_name "accusative" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adjective"></see>
    /// </summary>
    let adjective = Namespaced_IRI.parse _namespace_name "adjective" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adjectivePhrase"></see>
    /// </summary>
    let adjectivePhrase =
        Namespaced_IRI.parse _namespace_name "adjectivePhrase" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adjectivePhrase_nounPhrase"></see>
    /// </summary>
    let adjectivePhrase_nounPhrase =
        Namespaced_IRI.parse _namespace_name "adjectivePhrase_nounPhrase" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adposition"></see>
    /// </summary>
    let adposition = Namespaced_IRI.parse _namespace_name "adposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adpositionCircumposition"></see>
    /// </summary>
    let adpositionCircumposition =
        Namespaced_IRI.parse _namespace_name "adpositionCircumposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adpositionPostposition"></see>
    /// </summary>
    let adpositionPostposition =
        Namespaced_IRI.parse _namespace_name "adpositionPostposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adpositionPreposition"></see>
    /// </summary>
    let adpositionPreposition =
        Namespaced_IRI.parse _namespace_name "adpositionPreposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adverb"></see>
    /// </summary>
    let adverb = Namespaced_IRI.parse _namespace_name "adverb" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adverbPhrase"></see>
    /// </summary>
    let adverbPhrase =
        Namespaced_IRI.parse _namespace_name "adverbPhrase" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adverbPronominal"></see>
    /// </summary>
    let adverbPronominal =
        Namespaced_IRI.parse _namespace_name "adverbPronominal" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adverbialComplement"></see>
    /// </summary>
    let adverbialComplement =
        Namespaced_IRI.parse _namespace_name "adverbialComplement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#affix"></see>
    /// </summary>
    let affix = Namespaced_IRI.parse _namespace_name "affix" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#affixPrefix"></see>
    /// </summary>
    let affixPrefix =
        Namespaced_IRI.parse _namespace_name "affixPrefix" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#affixSuffix"></see>
    /// </summary>
    let affixSuffix =
        Namespaced_IRI.parse _namespace_name "affixSuffix" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#association"></see>
    /// </summary>
    let association =
        Namespaced_IRI.parse _namespace_name "association" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#bareInfinitive"></see>
    /// </summary>
    let bareInfinitive =
        Namespaced_IRI.parse _namespace_name "bareInfinitive" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#comparative"></see>
    /// </summary>
    let comparative =
        Namespaced_IRI.parse _namespace_name "comparative" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#complement"></see>
    /// </summary>
    let complement = Namespaced_IRI.parse _namespace_name "complement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#complementary"></see>
    /// </summary>
    let complementary =
        Namespaced_IRI.parse _namespace_name "complementary" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#compound"></see>
    /// </summary>
    let compound = Namespaced_IRI.parse _namespace_name "compound" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#compoundRoot"></see>
    /// </summary>
    let compoundRoot =
        Namespaced_IRI.parse _namespace_name "compoundRoot" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#conjunction"></see>
    /// </summary>
    let conjunction =
        Namespaced_IRI.parse _namespace_name "conjunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#conjunctionCoordinating"></see>
    /// </summary>
    let conjunctionCoordinating =
        Namespaced_IRI.parse _namespace_name "conjunctionCoordinating" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#conjunctionSubordinating"></see>
    /// </summary>
    let conjunctionSubordinating =
        Namespaced_IRI.parse _namespace_name "conjunctionSubordinating" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#contraction"></see>
    /// </summary>
    let contraction =
        Namespaced_IRI.parse _namespace_name "contraction" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#core"></see>
    /// </summary>
    let core = Namespaced_IRI.parse _namespace_name "core" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#coreUnexpressed"></see>
    /// </summary>
    let coreUnexpressed =
        Namespaced_IRI.parse _namespace_name "coreUnexpressed" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#corpus"></see>
    /// </summary>
    let corpus = Namespaced_IRI.parse _namespace_name "corpus" |> NamespacedName

    /// <summary>
    /// This DatatypeProperty could also be named "hasSimpleLexicalFeature".
    /// The current name "hasUbyDatatypeProperty" indicates that it groups Data Properties used in UBY-LMF.
    /// <see href="http://purl.org/olia/ubyCat.owl#hasUbyDatatypeProperty"></see></summary>
    let hasUbyDatatypeProperty =
        Namespaced_IRI.parse _namespace_name "hasUbyDatatypeProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#crosslingualSenseAlignment"></see>
    /// </summary>
    let crosslingualSenseAlignment =
        Namespaced_IRI.parse _namespace_name "crosslingualSenseAlignment" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#dative"></see>
    /// </summary>
    let dative = Namespaced_IRI.parse _namespace_name "dative" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#declarativeClause"></see>
    /// </summary>
    let declarativeClause =
        Namespaced_IRI.parse _namespace_name "declarativeClause" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#derivationBase"></see>
    /// </summary>
    let derivationBase =
        Namespaced_IRI.parse _namespace_name "derivationBase" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#derivationBaseAdj"></see>
    /// </summary>
    let derivationBaseAdj =
        Namespaced_IRI.parse _namespace_name "derivationBaseAdj" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#derivationBaseNoun"></see>
    /// </summary>
    let derivationBaseNoun =
        Namespaced_IRI.parse _namespace_name "derivationBaseNoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#derivationBaseVerb"></see>
    /// </summary>
    let derivationBaseVerb =
        Namespaced_IRI.parse _namespace_name "derivationBaseVerb" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#derivative"></see>
    /// </summary>
    let derivative = Namespaced_IRI.parse _namespace_name "derivative" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#determiner"></see>
    /// </summary>
    let determiner = Namespaced_IRI.parse _namespace_name "determiner" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#determinerDefinite"></see>
    /// </summary>
    let determinerDefinite =
        Namespaced_IRI.parse _namespace_name "determinerDefinite" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#determinerDemonstrative"></see>
    /// </summary>
    let determinerDemonstrative =
        Namespaced_IRI.parse _namespace_name "determinerDemonstrative" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#determinerIndefinite"></see>
    /// </summary>
    let determinerIndefinite =
        Namespaced_IRI.parse _namespace_name "determinerIndefinite" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#determinerInterrogative"></see>
    /// </summary>
    let determinerInterrogative =
        Namespaced_IRI.parse _namespace_name "determinerInterrogative" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#determinerPossessive"></see>
    /// </summary>
    let determinerPossessive =
        Namespaced_IRI.parse _namespace_name "determinerPossessive" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#directObject"></see>
    /// </summary>
    let directObject =
        Namespaced_IRI.parse _namespace_name "directObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#etymology"></see>
    /// </summary>
    let etymology = Namespaced_IRI.parse _namespace_name "etymology" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#expletive"></see>
    /// </summary>
    let expletive = Namespaced_IRI.parse _namespace_name "expletive" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#extensionalDefinition"></see>
    /// </summary>
    let extensionalDefinition =
        Namespaced_IRI.parse _namespace_name "extensionalDefinition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#externalReference"></see>
    /// </summary>
    let externalReference =
        Namespaced_IRI.parse _namespace_name "externalReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#externalSystem"></see>
    /// </summary>
    let externalSystem =
        Namespaced_IRI.parse _namespace_name "externalSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#extraThematic"></see>
    /// </summary>
    let extraThematic =
        Namespaced_IRI.parse _namespace_name "extraThematic" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#feminine"></see>
    /// </summary>
    let feminine = Namespaced_IRI.parse _namespace_name "feminine" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#first"></see>
    /// </summary>
    let first = Namespaced_IRI.parse _namespace_name "first" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#generator"></see>
    /// </summary>
    let generator = Namespaced_IRI.parse _namespace_name "generator" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#genitive"></see>
    /// </summary>
    let genitive = Namespaced_IRI.parse _namespace_name "genitive" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#geographicalVariant"></see>
    /// </summary>
    let geographicalVariant =
        Namespaced_IRI.parse _namespace_name "geographicalVariant" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasComplementizer"></see>
    /// </summary>
    let hasComplementizer =
        Namespaced_IRI.parse _namespace_name "hasComplementizer" |> NamespacedName

    /// <summary>
    /// This ObjectProperty could also be named "hasTypedLexicalFeature".
    /// The current name "hasUbyObjectProperty" indicates that it groups Object Properties used in UBY-LMF.
    /// <see href="http://purl.org/olia/ubyCat.owl#hasUbyObjectProperty"></see></summary>
    let hasUbyObjectProperty =
        Namespaced_IRI.parse _namespace_name "hasUbyObjectProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasCoreType"></see>
    /// </summary>
    let hasCoreType =
        Namespaced_IRI.parse _namespace_name "hasCoreType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasDefinitionType"></see>
    /// </summary>
    let hasDefinitionType =
        Namespaced_IRI.parse _namespace_name "hasDefinitionType" |> NamespacedName

    /// <summary>
    /// In UBY-LMF, relType is an attribute of the RelatedForm class which encodes links to derivationally related lexical entries or senses.
    /// <see href="http://purl.org/olia/ubyCat.owl#hasDerivationType"></see></summary>
    let hasDerivationType =
        Namespaced_IRI.parse _namespace_name "hasDerivationType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasDeterminer"></see>
    /// </summary>
    let hasDeterminer =
        Namespaced_IRI.parse _namespace_name "hasDeterminer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasExampleType"></see>
    /// </summary>
    let hasExampleType =
        Namespaced_IRI.parse _namespace_name "hasExampleType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasGrammaticalFunction"></see>
    /// </summary>
    let hasGrammaticalFunction =
        Namespaced_IRI.parse _namespace_name "hasGrammaticalFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasPosition"></see>
    /// </summary>
    let hasPosition =
        Namespaced_IRI.parse _namespace_name "hasPosition" |> NamespacedName

    /// <summary>
    /// In UBY-LMF, quantification is an attribute of the class SemanticLabel. It can be used, if the value of the semantic label is annotated with a score, e.g. type=sentiment, label=positive, quantification=strong.
    ///
    /// <see href="http://purl.org/olia/ubyCat.owl#hasQuantification"></see></summary>
    let hasQuantification =
        Namespaced_IRI.parse _namespace_name "hasQuantification" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasRelType"></see>
    /// </summary>
    let hasRelType = Namespaced_IRI.parse _namespace_name "hasRelType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasSenseAxisType"></see>
    /// </summary>
    let hasSenseAxisType =
        Namespaced_IRI.parse _namespace_name "hasSenseAxisType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasSyntacticCategory"></see>
    /// </summary>
    let hasSyntacticCategory =
        Namespaced_IRI.parse _namespace_name "hasSyntacticCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasSyntacticProperty"></see>
    /// </summary>
    let hasSyntacticProperty =
        Namespaced_IRI.parse _namespace_name "hasSyntacticProperty" |> NamespacedName

    /// <summary>
    /// Type is an attribute of the UBY-LMF class SemanticLabel. It encodes the name of a SemanticLabel type, e.g.
    /// type=semanticField (from WordNet or GermaNet).
    /// The label attribute of SemanticLabel holds the corresponding value of the SemanticLabel, e.g.
    /// label=animate (for type=semanticField).
    /// <see href="http://purl.org/olia/ubyCat.owl#hasType"></see></summary>
    let hasType = Namespaced_IRI.parse _namespace_name "hasType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasVerbForm"></see>
    /// </summary>
    let hasVerbForm =
        Namespaced_IRI.parse _namespace_name "hasVerbForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#has_WordFormAttribute"></see>
    /// </summary>
    let has_WordFormAttribute =
        Namespaced_IRI.parse _namespace_name "has_WordFormAttribute" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#has_case"></see>
    /// </summary>
    let has_case = Namespaced_IRI.parse _namespace_name "has_case" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#has_degree"></see>
    /// </summary>
    let has_degree = Namespaced_IRI.parse _namespace_name "has_degree" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#has_grammaticalGender"></see>
    /// </summary>
    let has_grammaticalGender =
        Namespaced_IRI.parse _namespace_name "has_grammaticalGender" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#has_grammaticalNumber"></see>
    /// </summary>
    let has_grammaticalNumber =
        Namespaced_IRI.parse _namespace_name "has_grammaticalNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#has_partOfSpeech"></see>
    /// </summary>
    let has_partOfSpeech =
        Namespaced_IRI.parse _namespace_name "has_partOfSpeech" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#has_person"></see>
    /// </summary>
    let has_person = Namespaced_IRI.parse _namespace_name "has_person" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#has_tense"></see>
    /// </summary>
    let has_tense = Namespaced_IRI.parse _namespace_name "has_tense" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#has_verbFormMood"></see>
    /// </summary>
    let has_verbFormMood =
        Namespaced_IRI.parse _namespace_name "has_verbFormMood" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hyphenation"></see>
    /// </summary>
    let hyphenation =
        Namespaced_IRI.parse _namespace_name "hyphenation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#idiomaticExpression"></see>
    /// </summary>
    let idiomaticExpression =
        Namespaced_IRI.parse _namespace_name "idiomaticExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#imperative"></see>
    /// </summary>
    let imperative = Namespaced_IRI.parse _namespace_name "imperative" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#incorporatedSemArg"></see>
    /// </summary>
    let incorporatedSemArg =
        Namespaced_IRI.parse _namespace_name "incorporatedSemArg" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#indefinite"></see>
    /// </summary>
    let indefinite = Namespaced_IRI.parse _namespace_name "indefinite" |> NamespacedName
    /// <summary>
    /// Index is an attribute of the UBY-LMF class Sense.
    /// It encodes a ranking of the senses according to their frequency which is provided, e.g., by WordNet.
    /// <see href="http://purl.org/olia/ubyCat.owl#index"></see></summary>
    let index = Namespaced_IRI.parse _namespace_name "index" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#indicative"></see>
    /// </summary>
    let indicative = Namespaced_IRI.parse _namespace_name "indicative" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#infinitive"></see>
    /// </summary>
    let infinitive = Namespaced_IRI.parse _namespace_name "infinitive" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#infinitiveZu"></see>
    /// </summary>
    let infinitiveZu =
        Namespaced_IRI.parse _namespace_name "infinitiveZu" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#ingForm"></see>
    /// </summary>
    let ingForm = Namespaced_IRI.parse _namespace_name "ingForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#intensionalDefinition"></see>
    /// </summary>
    let intensionalDefinition =
        Namespaced_IRI.parse _namespace_name "intensionalDefinition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#interjection"></see>
    /// </summary>
    let interjection =
        Namespaced_IRI.parse _namespace_name "interjection" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#isBreakBefore"></see>
    /// </summary>
    let isBreakBefore =
        Namespaced_IRI.parse _namespace_name "isBreakBefore" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#isHead"></see>
    /// </summary>
    let isHead = Namespaced_IRI.parse _namespace_name "isHead" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#isIncorporated"></see>
    /// </summary>
    let isIncorporated =
        Namespaced_IRI.parse _namespace_name "isIncorporated" |> NamespacedName

    /// <summary>
    /// Label encodes a name (short - like a tag) and is an attribute of the UBY-LMF class SemanticLabel, SemanticPredicate,
    /// <see href="http://purl.org/olia/ubyCat.owl#label"></see></summary>
    let label = Namespaced_IRI.parse _namespace_name "label" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#languageIdentifier"></see>
    /// </summary>
    let languageIdentifier =
        Namespaced_IRI.parse _namespace_name "languageIdentifier" |> NamespacedName

    /// <summary>
    /// Lexeme is an attribute of the UBY-LMF class SyntacticArgument and specifies a particular lexeme to be used in realizations of particular complements.
    /// Example (lexeme = es, ObjectComplement realized as zu-infinitive): Er schafft es, den Termin einzuhalten.
    /// * Er schafft, den Termin einzuhalten.
    /// <see href="http://purl.org/olia/ubyCat.owl#lexeme"></see></summary>
    let lexeme = Namespaced_IRI.parse _namespace_name "lexeme" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#lexicalized"></see>
    /// </summary>
    let lexicalized =
        Namespaced_IRI.parse _namespace_name "lexicalized" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#loanWord"></see>
    /// </summary>
    let loanWord = Namespaced_IRI.parse _namespace_name "loanWord" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#masculine"></see>
    /// </summary>
    let masculine = Namespaced_IRI.parse _namespace_name "masculine" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#monolingualExternalRef"></see>
    /// </summary>
    let monolingualExternalRef =
        Namespaced_IRI.parse _namespace_name "monolingualExternalRef" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#monolingualSenseAlignment"></see>
    /// </summary>
    let monolingualSenseAlignment =
        Namespaced_IRI.parse _namespace_name "monolingualSenseAlignment" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#neuter"></see>
    /// </summary>
    let neuter = Namespaced_IRI.parse _namespace_name "neuter" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#nominative"></see>
    /// </summary>
    let nominative = Namespaced_IRI.parse _namespace_name "nominative" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#nonPredicativeAdjective"></see>
    /// </summary>
    let nonPredicativeAdjective =
        Namespaced_IRI.parse _namespace_name "nonPredicativeAdjective" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#noun"></see>
    /// </summary>
    let noun = Namespaced_IRI.parse _namespace_name "noun" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#nounCommon"></see>
    /// </summary>
    let nounCommon = Namespaced_IRI.parse _namespace_name "nounCommon" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#nounPhrase"></see>
    /// </summary>
    let nounPhrase = Namespaced_IRI.parse _namespace_name "nounPhrase" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#nounProper"></see>
    /// </summary>
    let nounProper = Namespaced_IRI.parse _namespace_name "nounProper" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#nounProperFamilyName"></see>
    /// </summary>
    let nounProperFamilyName =
        Namespaced_IRI.parse _namespace_name "nounProperFamilyName" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#nounProperGivenName"></see>
    /// </summary>
    let nounProperGivenName =
        Namespaced_IRI.parse _namespace_name "nounProperGivenName" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#numeral"></see>
    /// </summary>
    let numeral = Namespaced_IRI.parse _namespace_name "numeral" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#objectComplement"></see>
    /// </summary>
    let objectComplement =
        Namespaced_IRI.parse _namespace_name "objectComplement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#objectControl"></see>
    /// </summary>
    let objectControl =
        Namespaced_IRI.parse _namespace_name "objectControl" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#objectRaising"></see>
    /// </summary>
    let objectRaising =
        Namespaced_IRI.parse _namespace_name "objectRaising" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#optionalArgument"></see>
    /// </summary>
    let optionalArgument =
        Namespaced_IRI.parse _namespace_name "optionalArgument" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#orthographyName"></see>
    /// </summary>
    let orthographyName =
        Namespaced_IRI.parse _namespace_name "orthographyName" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#other"></see>
    /// </summary>
    let other = Namespaced_IRI.parse _namespace_name "other" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#partWhole"></see>
    /// </summary>
    let partWhole = Namespaced_IRI.parse _namespace_name "partWhole" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#participle"></see>
    /// </summary>
    let participle = Namespaced_IRI.parse _namespace_name "participle" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#particle"></see>
    /// </summary>
    let particle = Namespaced_IRI.parse _namespace_name "particle" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#particleAnswer"></see>
    /// </summary>
    let particleAnswer =
        Namespaced_IRI.parse _namespace_name "particleAnswer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#particleComparative"></see>
    /// </summary>
    let particleComparative =
        Namespaced_IRI.parse _namespace_name "particleComparative" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#particleInfinitive"></see>
    /// </summary>
    let particleInfinitive =
        Namespaced_IRI.parse _namespace_name "particleInfinitive" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#particleNegative"></see>
    /// </summary>
    let particleNegative =
        Namespaced_IRI.parse _namespace_name "particleNegative" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#partitiveDefinition"></see>
    /// </summary>
    let partitiveDefinition =
        Namespaced_IRI.parse _namespace_name "partitiveDefinition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#past"></see>
    /// </summary>
    let past = Namespaced_IRI.parse _namespace_name "past" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#peripheral"></see>
    /// </summary>
    let peripheral = Namespaced_IRI.parse _namespace_name "peripheral" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#perspectivalized"></see>
    /// </summary>
    let perspectivalized =
        Namespaced_IRI.parse _namespace_name "perspectivalized" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#phoneticForm"></see>
    /// </summary>
    let phoneticForm =
        Namespaced_IRI.parse _namespace_name "phoneticForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#phraseme"></see>
    /// </summary>
    let phraseme = Namespaced_IRI.parse _namespace_name "phraseme" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#plural"></see>
    /// </summary>
    let plural = Namespaced_IRI.parse _namespace_name "plural" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#positive"></see>
    /// </summary>
    let positive = Namespaced_IRI.parse _namespace_name "positive" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#possessive"></see>
    /// </summary>
    let possessive = Namespaced_IRI.parse _namespace_name "possessive" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#postpositiveAdjective"></see>
    /// </summary>
    let postpositiveAdjective =
        Namespaced_IRI.parse _namespace_name "postpositiveAdjective" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#predicativeAdjective"></see>
    /// </summary>
    let predicativeAdjective =
        Namespaced_IRI.parse _namespace_name "predicativeAdjective" |> NamespacedName

    /// <summary>
    /// Preposition is an attribute of the UBY-LMF class SyntacticArgument and specifies the particular preposition to be used in prepositional complements that can either be realized as PP or as preposition and subordinate clause.
    /// Example: That depends on who did it.
    /// <see href="http://purl.org/olia/ubyCat.owl#preposition"></see></summary>
    let preposition =
        Namespaced_IRI.parse _namespace_name "preposition" |> NamespacedName

    /// <summary>
    /// PrepositionType is an attribute of the UBY-LMF class SyntacticArgument and specifies the particular preposition type (e.g. locative, directional) to be used in prepositional complements.
    /// The preposition type is specified in VerbNet.
    /// <see href="http://purl.org/olia/ubyCat.owl#prepositionType"></see></summary>
    let prepositionType =
        Namespaced_IRI.parse _namespace_name "prepositionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#prepositionalComplement"></see>
    /// </summary>
    let prepositionalComplement =
        Namespaced_IRI.parse _namespace_name "prepositionalComplement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#prepositionalPhrase"></see>
    /// </summary>
    let prepositionalPhrase =
        Namespaced_IRI.parse _namespace_name "prepositionalPhrase" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#present"></see>
    /// </summary>
    let present = Namespaced_IRI.parse _namespace_name "present" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#pronoun"></see>
    /// </summary>
    let pronoun = Namespaced_IRI.parse _namespace_name "pronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#pronounDemonstrative"></see>
    /// </summary>
    let pronounDemonstrative =
        Namespaced_IRI.parse _namespace_name "pronounDemonstrative" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#pronounIndefinite"></see>
    /// </summary>
    let pronounIndefinite =
        Namespaced_IRI.parse _namespace_name "pronounIndefinite" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#pronounInterrogative"></see>
    /// </summary>
    let pronounInterrogative =
        Namespaced_IRI.parse _namespace_name "pronounInterrogative" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#pronounPersonal"></see>
    /// </summary>
    let pronounPersonal =
        Namespaced_IRI.parse _namespace_name "pronounPersonal" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#pronounPersonalIrreflexive"></see>
    /// </summary>
    let pronounPersonalIrreflexive =
        Namespaced_IRI.parse _namespace_name "pronounPersonalIrreflexive" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#pronounPersonalReflexive"></see>
    /// </summary>
    let pronounPersonalReflexive =
        Namespaced_IRI.parse _namespace_name "pronounPersonalReflexive" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#pronounPossessive"></see>
    /// </summary>
    let pronounPossessive =
        Namespaced_IRI.parse _namespace_name "pronounPossessive" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#pronounRelative"></see>
    /// </summary>
    let pronounRelative =
        Namespaced_IRI.parse _namespace_name "pronounRelative" |> NamespacedName

    /// <summary>
    /// In UBY-LMF, quantification is an attribute of the class SemanticLabel. It can be used, if the value of the semantic label is annotated with a score, e.g. type=sentiment, label=positive, quantification=strong.
    ///
    /// <see href="http://purl.org/olia/ubyCat.owl#quantification"></see></summary>
    let quantification =
        Namespaced_IRI.parse _namespace_name "quantification" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#reflexive"></see>
    /// </summary>
    let reflexive = Namespaced_IRI.parse _namespace_name "reflexive" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#second"></see>
    /// </summary>
    let second = Namespaced_IRI.parse _namespace_name "second" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#semanticRole"></see>
    /// </summary>
    let semanticRole =
        Namespaced_IRI.parse _namespace_name "semanticRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#sense"></see>
    /// </summary>
    let sense = Namespaced_IRI.parse _namespace_name "sense" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#senseInstance"></see>
    /// </summary>
    let senseInstance =
        Namespaced_IRI.parse _namespace_name "senseInstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#senseRelation"></see>
    /// </summary>
    let senseRelation =
        Namespaced_IRI.parse _namespace_name "senseRelation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#separableParticle"></see>
    /// </summary>
    let separableParticle =
        Namespaced_IRI.parse _namespace_name "separableParticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#singular"></see>
    /// </summary>
    let singular = Namespaced_IRI.parse _namespace_name "singular" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#sound"></see>
    /// </summary>
    let sound = Namespaced_IRI.parse _namespace_name "sound" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#subcatFrame"></see>
    /// </summary>
    let subcatFrame =
        Namespaced_IRI.parse _namespace_name "subcatFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#subject"></see>
    /// </summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#subjectComplement"></see>
    /// </summary>
    let subjectComplement =
        Namespaced_IRI.parse _namespace_name "subjectComplement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#subjectControl"></see>
    /// </summary>
    let subjectControl =
        Namespaced_IRI.parse _namespace_name "subjectControl" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#subjectRaising"></see>
    /// </summary>
    let subjectRaising =
        Namespaced_IRI.parse _namespace_name "subjectRaising" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#subjunctive"></see>
    /// </summary>
    let subjunctive =
        Namespaced_IRI.parse _namespace_name "subjunctive" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#subordinateClause"></see>
    /// </summary>
    let subordinateClause =
        Namespaced_IRI.parse _namespace_name "subordinateClause" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#superlative"></see>
    /// </summary>
    let superlative =
        Namespaced_IRI.parse _namespace_name "superlative" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#supports"></see>
    /// </summary>
    let supports = Namespaced_IRI.parse _namespace_name "supports" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#symbol"></see>
    /// </summary>
    let symbol = Namespaced_IRI.parse _namespace_name "symbol" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#syntacticUsage"></see>
    /// </summary>
    let syntacticUsage =
        Namespaced_IRI.parse _namespace_name "syntacticUsage" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#taxonomic"></see>
    /// </summary>
    let taxonomic = Namespaced_IRI.parse _namespace_name "taxonomic" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#thatType"></see>
    /// </summary>
    let thatType = Namespaced_IRI.parse _namespace_name "thatType" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#third"></see>
    /// </summary>
    let third = Namespaced_IRI.parse _namespace_name "third" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#toInfinitive"></see>
    /// </summary>
    let toInfinitive =
        Namespaced_IRI.parse _namespace_name "toInfinitive" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#translatedDefinition"></see>
    /// </summary>
    let translatedDefinition =
        Namespaced_IRI.parse _namespace_name "translatedDefinition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#transliteration"></see>
    /// </summary>
    let transliteration =
        Namespaced_IRI.parse _namespace_name "transliteration" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#transparentMeaning"></see>
    /// </summary>
    let transparentMeaning =
        Namespaced_IRI.parse _namespace_name "transparentMeaning" |> NamespacedName

    /// <summary>
    /// Type is an attribute of the UBY-LMF class SemanticLabel. It encodes the name of a SemanticLabel type, e.g.
    /// type=semanticField (from WordNet or GermaNet).
    /// The label attribute of SemanticLabel holds the corresponding value of the SemanticLabel, e.g.
    /// label=animate (for type=semanticField).
    /// <see href="http://purl.org/olia/ubyCat.owl#type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#usage"></see>
    /// </summary>
    let usage = Namespaced_IRI.parse _namespace_name "usage" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#verb"></see>
    /// </summary>
    let verb = Namespaced_IRI.parse _namespace_name "verb" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#verbAuxiliary"></see>
    /// </summary>
    let verbAuxiliary =
        Namespaced_IRI.parse _namespace_name "verbAuxiliary" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#verbMain"></see>
    /// </summary>
    let verbMain = Namespaced_IRI.parse _namespace_name "verbMain" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#verbModal"></see>
    /// </summary>
    let verbModal = Namespaced_IRI.parse _namespace_name "verbModal" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#verbPhrase"></see>
    /// </summary>
    let verbPhrase = Namespaced_IRI.parse _namespace_name "verbPhrase" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#whType"></see>
    /// </summary>
    let whType = Namespaced_IRI.parse _namespace_name "whType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#writtenForm"></see>
    /// </summary>
    let writtenForm =
        Namespaced_IRI.parse _namespace_name "writtenForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#yesNoType"></see>
    /// </summary>
    let yesNoType = Namespaced_IRI.parse _namespace_name "yesNoType" |> NamespacedName
