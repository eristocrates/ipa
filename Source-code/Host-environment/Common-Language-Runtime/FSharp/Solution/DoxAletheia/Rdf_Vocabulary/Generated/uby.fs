namespace http.purl.org.olia.ubyCat.owl.hash

open DoxAletheia

module uby =
    let _namespace_name = "http://purl.org/olia/ubyCat.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Case"></see>
    /// </summary>
    let Case = _prefix "Case"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#WordFormAttribute"></see>
    /// </summary>
    let WordFormAttribute = _prefix "WordFormAttribute"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Complementizer"></see>
    /// </summary>
    let Complementizer = _prefix "Complementizer"
    /// <summary>
    /// SyntacticFeature groups attributes of UBY-LMF classes from the ISO LMF Syntax extension package.
    /// <see href="http://purl.org/olia/ubyCat.owl#SyntacticFeature"></see></summary>
    let SyntacticFeature = _prefix "SyntacticFeature"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Context"></see>
    /// </summary>
    let Context = _prefix "Context"
    /// <summary>
    /// LexicalFeatureStructure is a complex lexical Feature Structure (with features and feature values) and corresponds to a class in LMF.
    /// <see href="http://purl.org/olia/ubyCat.owl#LexicalFeatureStructure"></see></summary>
    let LexicalFeatureStructure = _prefix "LexicalFeatureStructure"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#CoreType"></see>
    /// </summary>
    let CoreType = _prefix "CoreType"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#SemanticFeature"></see>
    /// </summary>
    let SemanticFeature = _prefix "SemanticFeature"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Definition"></see>
    /// </summary>
    let Definition = _prefix "Definition"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#DefinitionType"></see>
    /// </summary>
    let DefinitionType = _prefix "DefinitionType"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#DictionaryFeature"></see>
    /// </summary>
    let DictionaryFeature = _prefix "DictionaryFeature"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Degree"></see>
    /// </summary>
    let Degree = _prefix "Degree"
    /// <summary>
    /// In UBY-LMF, relType is an attribute of the RelatedForm class which encodes links to derivationally related lexical entries or senses.
    /// <see href="http://purl.org/olia/ubyCat.owl#DerivationType"></see></summary>
    let DerivationType = _prefix "DerivationType"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#DerivationalMorphology"></see>
    /// </summary>
    let DerivationalMorphology = _prefix "DerivationalMorphology"
    /// <summary>
    /// LexicalFeature groups different kinds of lexical feaures, which correspond to attributes of UBY-LMF classes.
    /// <see href="http://purl.org/olia/ubyCat.owl#LexicalFeature"></see></summary>
    let LexicalFeature = _prefix "LexicalFeature"
    /// <summary>
    /// In UBY-LMF, determiner is an attribute of the LMF class SyntacticArgument. For noun phrase arguments, this attribute encodes specific constraints on the determiner to be used (possessive or indefinite).
    ///
    /// Example given in VerbNet (possessive): They allow our smoking.
    /// Example from VerbNet (indefinite): an indefinite determiner is required for the noun phrase complement of "echo" as in
    /// There echoed voices through the hall. (verb class sound_existence-47.4)
    /// <see href="http://purl.org/olia/ubyCat.owl#Determiner"></see></summary>
    let Determiner = _prefix "Determiner"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#ExampleType"></see>
    /// </summary>
    let ExampleType = _prefix "ExampleType"
    /// <summary>
    /// This owl:Class corresponds to the LMF-class Frequency which has been introduced in UBY-LMF as an extension of ISO-LMF.
    /// <see href="http://purl.org/olia/ubyCat.owl#Frequency"></see></summary>
    let Frequency = _prefix "Frequency"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#GrammaticalFunction"></see>
    /// </summary>
    let GrammaticalFunction = _prefix "GrammaticalFunction"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#GrammaticalGender"></see>
    /// </summary>
    let GrammaticalGender = _prefix "GrammaticalGender"
    /// <summary>
    /// In UBY-LMF, number is also an attribute of the UBY-LMF class SyntacticArgument and specifies the grammatical number of an argument.
    /// Example: These types of fish mix well together.
    /// <see href="http://purl.org/olia/ubyCat.owl#GrammaticalNumber"></see></summary>
    let GrammaticalNumber = _prefix "GrammaticalNumber"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Lemma"></see>
    /// </summary>
    let Lemma = _prefix "Lemma"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#LexicalAnnotation"></see>
    /// </summary>
    let LexicalAnnotation = _prefix "LexicalAnnotation"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#LexicalEntry"></see>
    /// </summary>
    let LexicalEntry = _prefix "LexicalEntry"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Lexicon"></see>
    /// </summary>
    let Lexicon = _prefix "Lexicon"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#LinkingFeature"></see>
    /// </summary>
    let LinkingFeature = _prefix "LinkingFeature"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#MetaFeature"></see>
    /// </summary>
    let MetaFeature = _prefix "MetaFeature"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#MonolingualExternalRef"></see>
    /// </summary>
    let MonolingualExternalRef = _prefix "MonolingualExternalRef"
    /// <summary>
    /// As a convention, the relation is called has_partOfSpeech, partOfSpeech is the top-level *class* of parts of speech
    /// <see href="http://purl.org/olia/ubyCat.owl#PartOfSpeech"></see></summary>
    let PartOfSpeech = _prefix "PartOfSpeech"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Person"></see>
    /// </summary>
    let Person = _prefix "Person"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Position"></see>
    /// </summary>
    let Position = _prefix "Position"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#multiwordFeature"></see>
    /// </summary>
    let multiwordFeature = _prefix "multiwordFeature"
    /// <summary>
    /// In UBY-LMF, quantification is an attribute of the class SemanticLabel. It can be used, if the value of the semantic label is annotated with a score, e.g. type=sentiment, label=positive, quantification=strong.
    ///
    /// <see href="http://purl.org/olia/ubyCat.owl#Quantification"></see></summary>
    let Quantification = _prefix "Quantification"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#RelType"></see>
    /// </summary>
    let RelType = _prefix "RelType"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#SemanticArgument"></see>
    /// </summary>
    let SemanticArgument = _prefix "SemanticArgument"
    /// <summary>
    /// This owl:Class corresponds to the LMF-class SemanticLabel which has been introduced in UBY-LMF as an extension of ISO-LMF.
    /// <see href="http://purl.org/olia/ubyCat.owl#SemanticLabel"></see></summary>
    let SemanticLabel = _prefix "SemanticLabel"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#SemanticPredicate"></see>
    /// </summary>
    let SemanticPredicate = _prefix "SemanticPredicate"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Sense"></see>
    /// </summary>
    let Sense = _prefix "Sense"
    /// <summary>
    /// In Uby-LMF, the attribute senseAxisType of the SenseAxis class indicates, whether the type of linking between to senses or between two synsets. Example values are monolingualSenseAlignment and crosslingualSenseAlignment
    /// <see href="http://purl.org/olia/ubyCat.owl#SenseAxisType"></see></summary>
    let SenseAxisType = _prefix "SenseAxisType"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#SenseExample"></see>
    /// </summary>
    let SenseExample = _prefix "SenseExample"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#SubcategorizationFrame"></see>
    /// </summary>
    let SubcategorizationFrame = _prefix "SubcategorizationFrame"
    /// <summary>
    /// This owl:Class corresponds to the ISO LMF-class Synset.
    /// <see href="http://purl.org/olia/ubyCat.owl#Synset"></see></summary>
    let Synset = _prefix "Synset"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#SyntacticArgument"></see>
    /// </summary>
    let SyntacticArgument = _prefix "SyntacticArgument"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#SyntacticCategory"></see>
    /// </summary>
    let SyntacticCategory = _prefix "SyntacticCategory"
    /// <summary>
    /// Attribute of the UBY-LMF class SubcategorizationFrame.
    /// <see href="http://purl.org/olia/ubyCat.owl#SyntacticProperty"></see></summary>
    let SyntacticProperty = _prefix "SyntacticProperty"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#Tense"></see>
    /// </summary>
    let Tense = _prefix "Tense"
    /// <summary>
    /// Type is an attribute of the UBY-LMF class SemanticLabel. It encodes the name of a SemanticLabel type, e.g.
    /// type=semanticField (from WordNet or GermaNet).
    /// The label attribute of SemanticLabel holds the corresponding value of the SemanticLabel, e.g.
    /// label=animate (for type=semanticField).
    /// <see href="http://purl.org/olia/ubyCat.owl#Type"></see></summary>
    let Type = _prefix "Type"
    /// <summary>
    /// Specifies the verb form to be used in a verb phrase complement.
    /// <see href="http://purl.org/olia/ubyCat.owl#VerbForm"></see></summary>
    let VerbForm = _prefix "VerbForm"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#VerbFormMood"></see>
    /// </summary>
    let VerbFormMood = _prefix "VerbFormMood"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#WordForm"></see>
    /// </summary>
    let WordForm = _prefix "WordForm"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#abbreviation"></see>
    /// </summary>
    let abbreviation = _prefix "abbreviation"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#abbreviationAcronym"></see>
    /// </summary>
    let abbreviationAcronym = _prefix "abbreviationAcronym"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#abbreviationInitialism"></see>
    /// </summary>
    let abbreviationInitialism = _prefix "abbreviationInitialism"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#accusative"></see>
    /// </summary>
    let accusative = _prefix "accusative"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adjective"></see>
    /// </summary>
    let adjective = _prefix "adjective"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adjectivePhrase"></see>
    /// </summary>
    let adjectivePhrase = _prefix "adjectivePhrase"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adjectivePhrase_nounPhrase"></see>
    /// </summary>
    let adjectivePhrase_nounPhrase = _prefix "adjectivePhrase_nounPhrase"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adposition"></see>
    /// </summary>
    let adposition = _prefix "adposition"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adpositionCircumposition"></see>
    /// </summary>
    let adpositionCircumposition = _prefix "adpositionCircumposition"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adpositionPostposition"></see>
    /// </summary>
    let adpositionPostposition = _prefix "adpositionPostposition"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adpositionPreposition"></see>
    /// </summary>
    let adpositionPreposition = _prefix "adpositionPreposition"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adverb"></see>
    /// </summary>
    let adverb = _prefix "adverb"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adverbPhrase"></see>
    /// </summary>
    let adverbPhrase = _prefix "adverbPhrase"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adverbPronominal"></see>
    /// </summary>
    let adverbPronominal = _prefix "adverbPronominal"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#adverbialComplement"></see>
    /// </summary>
    let adverbialComplement = _prefix "adverbialComplement"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#affix"></see>
    /// </summary>
    let affix = _prefix "affix"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#affixPrefix"></see>
    /// </summary>
    let affixPrefix = _prefix "affixPrefix"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#affixSuffix"></see>
    /// </summary>
    let affixSuffix = _prefix "affixSuffix"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#association"></see>
    /// </summary>
    let association = _prefix "association"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#bareInfinitive"></see>
    /// </summary>
    let bareInfinitive = _prefix "bareInfinitive"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#comparative"></see>
    /// </summary>
    let comparative = _prefix "comparative"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#complement"></see>
    /// </summary>
    let complement = _prefix "complement"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#complementary"></see>
    /// </summary>
    let complementary = _prefix "complementary"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#compound"></see>
    /// </summary>
    let compound = _prefix "compound"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#compoundRoot"></see>
    /// </summary>
    let compoundRoot = _prefix "compoundRoot"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#conjunction"></see>
    /// </summary>
    let conjunction = _prefix "conjunction"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#conjunctionCoordinating"></see>
    /// </summary>
    let conjunctionCoordinating = _prefix "conjunctionCoordinating"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#conjunctionSubordinating"></see>
    /// </summary>
    let conjunctionSubordinating = _prefix "conjunctionSubordinating"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#contraction"></see>
    /// </summary>
    let contraction = _prefix "contraction"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#core"></see>
    /// </summary>
    let core = _prefix "core"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#coreUnexpressed"></see>
    /// </summary>
    let coreUnexpressed = _prefix "coreUnexpressed"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#corpus"></see>
    /// </summary>
    let corpus = _prefix "corpus"
    /// <summary>
    /// This DatatypeProperty could also be named "hasSimpleLexicalFeature".
    /// The current name "hasUbyDatatypeProperty" indicates that it groups Data Properties used in UBY-LMF.
    /// <see href="http://purl.org/olia/ubyCat.owl#hasUbyDatatypeProperty"></see></summary>
    let hasUbyDatatypeProperty = _prefix "hasUbyDatatypeProperty"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#crosslingualSenseAlignment"></see>
    /// </summary>
    let crosslingualSenseAlignment = _prefix "crosslingualSenseAlignment"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#dative"></see>
    /// </summary>
    let dative = _prefix "dative"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#declarativeClause"></see>
    /// </summary>
    let declarativeClause = _prefix "declarativeClause"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#derivationBase"></see>
    /// </summary>
    let derivationBase = _prefix "derivationBase"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#derivationBaseAdj"></see>
    /// </summary>
    let derivationBaseAdj = _prefix "derivationBaseAdj"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#derivationBaseNoun"></see>
    /// </summary>
    let derivationBaseNoun = _prefix "derivationBaseNoun"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#derivationBaseVerb"></see>
    /// </summary>
    let derivationBaseVerb = _prefix "derivationBaseVerb"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#derivative"></see>
    /// </summary>
    let derivative = _prefix "derivative"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#determiner"></see>
    /// </summary>
    let determiner = _prefix "determiner"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#determinerDefinite"></see>
    /// </summary>
    let determinerDefinite = _prefix "determinerDefinite"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#determinerDemonstrative"></see>
    /// </summary>
    let determinerDemonstrative = _prefix "determinerDemonstrative"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#determinerIndefinite"></see>
    /// </summary>
    let determinerIndefinite = _prefix "determinerIndefinite"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#determinerInterrogative"></see>
    /// </summary>
    let determinerInterrogative = _prefix "determinerInterrogative"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#determinerPossessive"></see>
    /// </summary>
    let determinerPossessive = _prefix "determinerPossessive"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#directObject"></see>
    /// </summary>
    let directObject = _prefix "directObject"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#etymology"></see>
    /// </summary>
    let etymology = _prefix "etymology"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#expletive"></see>
    /// </summary>
    let expletive = _prefix "expletive"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#extensionalDefinition"></see>
    /// </summary>
    let extensionalDefinition = _prefix "extensionalDefinition"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#externalReference"></see>
    /// </summary>
    let externalReference = _prefix "externalReference"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#externalSystem"></see>
    /// </summary>
    let externalSystem = _prefix "externalSystem"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#extraThematic"></see>
    /// </summary>
    let extraThematic = _prefix "extraThematic"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#feminine"></see>
    /// </summary>
    let feminine = _prefix "feminine"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#first"></see>
    /// </summary>
    let first = _prefix "first"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#generator"></see>
    /// </summary>
    let generator = _prefix "generator"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#genitive"></see>
    /// </summary>
    let genitive = _prefix "genitive"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#geographicalVariant"></see>
    /// </summary>
    let geographicalVariant = _prefix "geographicalVariant"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasComplementizer"></see>
    /// </summary>
    let hasComplementizer = _prefix "hasComplementizer"
    /// <summary>
    /// This ObjectProperty could also be named "hasTypedLexicalFeature".
    /// The current name "hasUbyObjectProperty" indicates that it groups Object Properties used in UBY-LMF.
    /// <see href="http://purl.org/olia/ubyCat.owl#hasUbyObjectProperty"></see></summary>
    let hasUbyObjectProperty = _prefix "hasUbyObjectProperty"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasCoreType"></see>
    /// </summary>
    let hasCoreType = _prefix "hasCoreType"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasDefinitionType"></see>
    /// </summary>
    let hasDefinitionType = _prefix "hasDefinitionType"
    /// <summary>
    /// In UBY-LMF, relType is an attribute of the RelatedForm class which encodes links to derivationally related lexical entries or senses.
    /// <see href="http://purl.org/olia/ubyCat.owl#hasDerivationType"></see></summary>
    let hasDerivationType = _prefix "hasDerivationType"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasDeterminer"></see>
    /// </summary>
    let hasDeterminer = _prefix "hasDeterminer"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasExampleType"></see>
    /// </summary>
    let hasExampleType = _prefix "hasExampleType"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasGrammaticalFunction"></see>
    /// </summary>
    let hasGrammaticalFunction = _prefix "hasGrammaticalFunction"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasPosition"></see>
    /// </summary>
    let hasPosition = _prefix "hasPosition"
    /// <summary>
    /// In UBY-LMF, quantification is an attribute of the class SemanticLabel. It can be used, if the value of the semantic label is annotated with a score, e.g. type=sentiment, label=positive, quantification=strong.
    ///
    /// <see href="http://purl.org/olia/ubyCat.owl#hasQuantification"></see></summary>
    let hasQuantification = _prefix "hasQuantification"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasRelType"></see>
    /// </summary>
    let hasRelType = _prefix "hasRelType"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasSenseAxisType"></see>
    /// </summary>
    let hasSenseAxisType = _prefix "hasSenseAxisType"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasSyntacticCategory"></see>
    /// </summary>
    let hasSyntacticCategory = _prefix "hasSyntacticCategory"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasSyntacticProperty"></see>
    /// </summary>
    let hasSyntacticProperty = _prefix "hasSyntacticProperty"
    /// <summary>
    /// Type is an attribute of the UBY-LMF class SemanticLabel. It encodes the name of a SemanticLabel type, e.g.
    /// type=semanticField (from WordNet or GermaNet).
    /// The label attribute of SemanticLabel holds the corresponding value of the SemanticLabel, e.g.
    /// label=animate (for type=semanticField).
    /// <see href="http://purl.org/olia/ubyCat.owl#hasType"></see></summary>
    let hasType = _prefix "hasType"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hasVerbForm"></see>
    /// </summary>
    let hasVerbForm = _prefix "hasVerbForm"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#has_WordFormAttribute"></see>
    /// </summary>
    let has_WordFormAttribute = _prefix "has_WordFormAttribute"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#has_case"></see>
    /// </summary>
    let has_case = _prefix "has_case"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#has_degree"></see>
    /// </summary>
    let has_degree = _prefix "has_degree"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#has_grammaticalGender"></see>
    /// </summary>
    let has_grammaticalGender = _prefix "has_grammaticalGender"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#has_grammaticalNumber"></see>
    /// </summary>
    let has_grammaticalNumber = _prefix "has_grammaticalNumber"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#has_partOfSpeech"></see>
    /// </summary>
    let has_partOfSpeech = _prefix "has_partOfSpeech"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#has_person"></see>
    /// </summary>
    let has_person = _prefix "has_person"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#has_tense"></see>
    /// </summary>
    let has_tense = _prefix "has_tense"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#has_verbFormMood"></see>
    /// </summary>
    let has_verbFormMood = _prefix "has_verbFormMood"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#hyphenation"></see>
    /// </summary>
    let hyphenation = _prefix "hyphenation"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#idiomaticExpression"></see>
    /// </summary>
    let idiomaticExpression = _prefix "idiomaticExpression"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#imperative"></see>
    /// </summary>
    let imperative = _prefix "imperative"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#incorporatedSemArg"></see>
    /// </summary>
    let incorporatedSemArg = _prefix "incorporatedSemArg"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#indefinite"></see>
    /// </summary>
    let indefinite = _prefix "indefinite"
    /// <summary>
    /// Index is an attribute of the UBY-LMF class Sense.
    /// It encodes a ranking of the senses according to their frequency which is provided, e.g., by WordNet.
    /// <see href="http://purl.org/olia/ubyCat.owl#index"></see></summary>
    let index = _prefix "index"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#indicative"></see>
    /// </summary>
    let indicative = _prefix "indicative"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#infinitive"></see>
    /// </summary>
    let infinitive = _prefix "infinitive"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#infinitiveZu"></see>
    /// </summary>
    let infinitiveZu = _prefix "infinitiveZu"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#ingForm"></see>
    /// </summary>
    let ingForm = _prefix "ingForm"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#intensionalDefinition"></see>
    /// </summary>
    let intensionalDefinition = _prefix "intensionalDefinition"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#interjection"></see>
    /// </summary>
    let interjection = _prefix "interjection"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#isBreakBefore"></see>
    /// </summary>
    let isBreakBefore = _prefix "isBreakBefore"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#isHead"></see>
    /// </summary>
    let isHead = _prefix "isHead"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#isIncorporated"></see>
    /// </summary>
    let isIncorporated = _prefix "isIncorporated"
    /// <summary>
    /// Label encodes a name (short - like a tag) and is an attribute of the UBY-LMF class SemanticLabel, SemanticPredicate,
    /// <see href="http://purl.org/olia/ubyCat.owl#label"></see></summary>
    let label = _prefix "label"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#languageIdentifier"></see>
    /// </summary>
    let languageIdentifier = _prefix "languageIdentifier"
    /// <summary>
    /// Lexeme is an attribute of the UBY-LMF class SyntacticArgument and specifies a particular lexeme to be used in realizations of particular complements.
    /// Example (lexeme = es, ObjectComplement realized as zu-infinitive): Er schafft es, den Termin einzuhalten.
    /// * Er schafft, den Termin einzuhalten.
    /// <see href="http://purl.org/olia/ubyCat.owl#lexeme"></see></summary>
    let lexeme = _prefix "lexeme"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#lexicalized"></see>
    /// </summary>
    let lexicalized = _prefix "lexicalized"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#loanWord"></see>
    /// </summary>
    let loanWord = _prefix "loanWord"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#masculine"></see>
    /// </summary>
    let masculine = _prefix "masculine"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#monolingualExternalRef"></see>
    /// </summary>
    let monolingualExternalRef = _prefix "monolingualExternalRef"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#monolingualSenseAlignment"></see>
    /// </summary>
    let monolingualSenseAlignment = _prefix "monolingualSenseAlignment"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#neuter"></see>
    /// </summary>
    let neuter = _prefix "neuter"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#nominative"></see>
    /// </summary>
    let nominative = _prefix "nominative"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#nonPredicativeAdjective"></see>
    /// </summary>
    let nonPredicativeAdjective = _prefix "nonPredicativeAdjective"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#noun"></see>
    /// </summary>
    let noun = _prefix "noun"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#nounCommon"></see>
    /// </summary>
    let nounCommon = _prefix "nounCommon"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#nounPhrase"></see>
    /// </summary>
    let nounPhrase = _prefix "nounPhrase"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#nounProper"></see>
    /// </summary>
    let nounProper = _prefix "nounProper"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#nounProperFamilyName"></see>
    /// </summary>
    let nounProperFamilyName = _prefix "nounProperFamilyName"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#nounProperGivenName"></see>
    /// </summary>
    let nounProperGivenName = _prefix "nounProperGivenName"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#numeral"></see>
    /// </summary>
    let numeral = _prefix "numeral"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#objectComplement"></see>
    /// </summary>
    let objectComplement = _prefix "objectComplement"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#objectControl"></see>
    /// </summary>
    let objectControl = _prefix "objectControl"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#objectRaising"></see>
    /// </summary>
    let objectRaising = _prefix "objectRaising"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#optionalArgument"></see>
    /// </summary>
    let optionalArgument = _prefix "optionalArgument"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#orthographyName"></see>
    /// </summary>
    let orthographyName = _prefix "orthographyName"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#other"></see>
    /// </summary>
    let other = _prefix "other"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#partWhole"></see>
    /// </summary>
    let partWhole = _prefix "partWhole"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#participle"></see>
    /// </summary>
    let participle = _prefix "participle"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#particle"></see>
    /// </summary>
    let particle = _prefix "particle"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#particleAnswer"></see>
    /// </summary>
    let particleAnswer = _prefix "particleAnswer"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#particleComparative"></see>
    /// </summary>
    let particleComparative = _prefix "particleComparative"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#particleInfinitive"></see>
    /// </summary>
    let particleInfinitive = _prefix "particleInfinitive"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#particleNegative"></see>
    /// </summary>
    let particleNegative = _prefix "particleNegative"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#partitiveDefinition"></see>
    /// </summary>
    let partitiveDefinition = _prefix "partitiveDefinition"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#past"></see>
    /// </summary>
    let past = _prefix "past"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#peripheral"></see>
    /// </summary>
    let peripheral = _prefix "peripheral"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#perspectivalized"></see>
    /// </summary>
    let perspectivalized = _prefix "perspectivalized"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#phoneticForm"></see>
    /// </summary>
    let phoneticForm = _prefix "phoneticForm"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#phraseme"></see>
    /// </summary>
    let phraseme = _prefix "phraseme"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#plural"></see>
    /// </summary>
    let plural = _prefix "plural"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#positive"></see>
    /// </summary>
    let positive = _prefix "positive"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#possessive"></see>
    /// </summary>
    let possessive = _prefix "possessive"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#postpositiveAdjective"></see>
    /// </summary>
    let postpositiveAdjective = _prefix "postpositiveAdjective"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#predicativeAdjective"></see>
    /// </summary>
    let predicativeAdjective = _prefix "predicativeAdjective"
    /// <summary>
    /// Preposition is an attribute of the UBY-LMF class SyntacticArgument and specifies the particular preposition to be used in prepositional complements that can either be realized as PP or as preposition and subordinate clause.
    /// Example: That depends on who did it.
    /// <see href="http://purl.org/olia/ubyCat.owl#preposition"></see></summary>
    let preposition = _prefix "preposition"
    /// <summary>
    /// PrepositionType is an attribute of the UBY-LMF class SyntacticArgument and specifies the particular preposition type (e.g. locative, directional) to be used in prepositional complements.
    /// The preposition type is specified in VerbNet.
    /// <see href="http://purl.org/olia/ubyCat.owl#prepositionType"></see></summary>
    let prepositionType = _prefix "prepositionType"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#prepositionalComplement"></see>
    /// </summary>
    let prepositionalComplement = _prefix "prepositionalComplement"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#prepositionalPhrase"></see>
    /// </summary>
    let prepositionalPhrase = _prefix "prepositionalPhrase"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#present"></see>
    /// </summary>
    let present = _prefix "present"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#pronoun"></see>
    /// </summary>
    let pronoun = _prefix "pronoun"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#pronounDemonstrative"></see>
    /// </summary>
    let pronounDemonstrative = _prefix "pronounDemonstrative"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#pronounIndefinite"></see>
    /// </summary>
    let pronounIndefinite = _prefix "pronounIndefinite"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#pronounInterrogative"></see>
    /// </summary>
    let pronounInterrogative = _prefix "pronounInterrogative"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#pronounPersonal"></see>
    /// </summary>
    let pronounPersonal = _prefix "pronounPersonal"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#pronounPersonalIrreflexive"></see>
    /// </summary>
    let pronounPersonalIrreflexive = _prefix "pronounPersonalIrreflexive"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#pronounPersonalReflexive"></see>
    /// </summary>
    let pronounPersonalReflexive = _prefix "pronounPersonalReflexive"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#pronounPossessive"></see>
    /// </summary>
    let pronounPossessive = _prefix "pronounPossessive"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#pronounRelative"></see>
    /// </summary>
    let pronounRelative = _prefix "pronounRelative"
    /// <summary>
    /// In UBY-LMF, quantification is an attribute of the class SemanticLabel. It can be used, if the value of the semantic label is annotated with a score, e.g. type=sentiment, label=positive, quantification=strong.
    ///
    /// <see href="http://purl.org/olia/ubyCat.owl#quantification"></see></summary>
    let quantification = _prefix "quantification"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#reflexive"></see>
    /// </summary>
    let reflexive = _prefix "reflexive"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#second"></see>
    /// </summary>
    let second = _prefix "second"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#semanticRole"></see>
    /// </summary>
    let semanticRole = _prefix "semanticRole"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#sense"></see>
    /// </summary>
    let sense = _prefix "sense"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#senseInstance"></see>
    /// </summary>
    let senseInstance = _prefix "senseInstance"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#senseRelation"></see>
    /// </summary>
    let senseRelation = _prefix "senseRelation"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#separableParticle"></see>
    /// </summary>
    let separableParticle = _prefix "separableParticle"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#singular"></see>
    /// </summary>
    let singular = _prefix "singular"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#sound"></see>
    /// </summary>
    let sound = _prefix "sound"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#subcatFrame"></see>
    /// </summary>
    let subcatFrame = _prefix "subcatFrame"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#subject"></see>
    /// </summary>
    let subject = _prefix "subject"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#subjectComplement"></see>
    /// </summary>
    let subjectComplement = _prefix "subjectComplement"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#subjectControl"></see>
    /// </summary>
    let subjectControl = _prefix "subjectControl"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#subjectRaising"></see>
    /// </summary>
    let subjectRaising = _prefix "subjectRaising"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#subjunctive"></see>
    /// </summary>
    let subjunctive = _prefix "subjunctive"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#subordinateClause"></see>
    /// </summary>
    let subordinateClause = _prefix "subordinateClause"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#superlative"></see>
    /// </summary>
    let superlative = _prefix "superlative"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#supports"></see>
    /// </summary>
    let supports = _prefix "supports"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#symbol"></see>
    /// </summary>
    let symbol = _prefix "symbol"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#syntacticUsage"></see>
    /// </summary>
    let syntacticUsage = _prefix "syntacticUsage"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#taxonomic"></see>
    /// </summary>
    let taxonomic = _prefix "taxonomic"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#thatType"></see>
    /// </summary>
    let thatType = _prefix "thatType"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#third"></see>
    /// </summary>
    let third = _prefix "third"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#toInfinitive"></see>
    /// </summary>
    let toInfinitive = _prefix "toInfinitive"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#translatedDefinition"></see>
    /// </summary>
    let translatedDefinition = _prefix "translatedDefinition"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#transliteration"></see>
    /// </summary>
    let transliteration = _prefix "transliteration"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#transparentMeaning"></see>
    /// </summary>
    let transparentMeaning = _prefix "transparentMeaning"
    /// <summary>
    /// Type is an attribute of the UBY-LMF class SemanticLabel. It encodes the name of a SemanticLabel type, e.g.
    /// type=semanticField (from WordNet or GermaNet).
    /// The label attribute of SemanticLabel holds the corresponding value of the SemanticLabel, e.g.
    /// label=animate (for type=semanticField).
    /// <see href="http://purl.org/olia/ubyCat.owl#type"></see></summary>
    let type_ = _prefix "type"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#usage"></see>
    /// </summary>
    let usage = _prefix "usage"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#verb"></see>
    /// </summary>
    let verb = _prefix "verb"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#verbAuxiliary"></see>
    /// </summary>
    let verbAuxiliary = _prefix "verbAuxiliary"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#verbMain"></see>
    /// </summary>
    let verbMain = _prefix "verbMain"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#verbModal"></see>
    /// </summary>
    let verbModal = _prefix "verbModal"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#verbPhrase"></see>
    /// </summary>
    let verbPhrase = _prefix "verbPhrase"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#whType"></see>
    /// </summary>
    let whType = _prefix "whType"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#writtenForm"></see>
    /// </summary>
    let writtenForm = _prefix "writtenForm"
    /// <summary>
    ///   <see href="http://purl.org/olia/ubyCat.owl#yesNoType"></see>
    /// </summary>
    let yesNoType = _prefix "yesNoType"
