#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module uby =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/olia/ubyCat.owl#" "uby"
    /// <summary>
    ///   <para>rdfs:label : case^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-2720^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#Case">uby:Case</a>
    /// </summary>
    let Case = _prefixId.prefix "Case"
    /// <summary>
    ///   <para>rdfs:label : complementizer^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-3124^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#Complementizer">uby:Complementizer</a>
    /// </summary>
    let Complementizer = _prefixId.prefix "Complementizer"
    /// <summary>
    ///   <para>owl:versionInfo : superseded by lemon:LexicalContext^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:isDefinedBy : http://uby.googlecode.com/files/UBY_LMF_0_2_0.dtd^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#Context">uby:Context</a>
    /// </summary>
    let Context = _prefixId.prefix "Context"
    /// <summary>
    ///   <para>rdfs:label : coreType^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-4461^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#CoreType">uby:CoreType</a>
    /// </summary>
    let CoreType = _prefixId.prefix "CoreType"
    /// <summary>
    ///   <para>owl:versionInfo : superseded by lemon:SenseDefinition^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:isDefinedBy : http://uby.googlecode.com/files/UBY_LMF_0_2_0.dtd^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#Definition">uby:Definition</a>
    /// </summary>
    let Definition = _prefixId.prefix "Definition"
    /// <summary>
    ///   <para>rdfs:label : definitionType^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#DefinitionType">uby:DefinitionType</a>
    /// </summary>
    let DefinitionType = _prefixId.prefix "DefinitionType"
    /// <summary>
    ///   <para>rdfs:label : degree^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-2779^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#Degree">uby:Degree</a>
    /// </summary>
    let Degree = _prefixId.prefix "Degree"
    /// <summary>
    ///   <para>owl:versionInfo : It decides the property to use in the mapping, hence deprecated.
    /// relType="xxx" is normally uby:xxx
    /// (with some exceptions, .e.g, relType="seeAlso" is rdfs:seeAlso)^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : relType^^xsd:string</para>
    ///   <para>rdfs:comment : In UBY-LMF, relType is an attribute of the RelatedForm class which encodes links to derivationally related lexical entries or senses.^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#DerivationType">uby:DerivationType</a>
    /// </summary>
    let DerivationType = _prefixId.prefix "DerivationType"
    let DerivationalMorphology = _prefixId.prefix "DerivationalMorphology"
    /// <summary>
    ///   <para>rdfs:label : determiner^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-3159^^xsd:stringrdfs:isDefinedBy : http://www.isocat.org/datcat/DC-1272^^xsd:string</para>
    ///   <para>rdfs:comment : In UBY-LMF, determiner is an attribute of the LMF class SyntacticArgument. For noun phrase arguments, this attribute encodes specific constraints on the determiner to be used (possessive or indefinite).
    ///
    /// Example given in VerbNet (possessive): They allow our smoking.
    /// Example from VerbNet (indefinite): an indefinite determiner is required for the noun phrase complement of "echo" as in
    /// There echoed voices through the hall. (verb class sound_existence-47.4)^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#Determiner">uby:Determiner</a>
    /// </summary>
    let Determiner = _prefixId.prefix "Determiner"
    let DictionaryFeature = _prefixId.prefix "DictionaryFeature"
    /// <summary>
    ///   <para>rdfs:label : exampleType^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#ExampleType">uby:ExampleType</a>
    /// </summary>
    let ExampleType = _prefixId.prefix "ExampleType"
    /// <summary>
    ///   <para>rdfs:comment : This owl:Class corresponds to the LMF-class Frequency which has been introduced in UBY-LMF as an extension of ISO-LMF.^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#Frequency">uby:Frequency</a>
    /// </summary>
    let Frequency = _prefixId.prefix "Frequency"
    /// <summary>
    ///   <para>rdfs:label : grammaticalFunction^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-1296^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#GrammaticalFunction">uby:GrammaticalFunction</a>
    /// </summary>
    let GrammaticalFunction = _prefixId.prefix "GrammaticalFunction"
    /// <summary>
    ///   <para>rdfs:label : grammaticalGender^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-3217^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#GrammaticalGender">uby:GrammaticalGender</a>
    /// </summary>
    let GrammaticalGender = _prefixId.prefix "GrammaticalGender"
    /// <summary>
    ///   <para>rdfs:label : grammaticalNumber^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-251^^xsd:string</para>
    ///   <para>rdfs:comment : In UBY-LMF, number is also an attribute of the UBY-LMF class SyntacticArgument and specifies the grammatical number of an argument.
    /// Example: These types of fish mix well together.^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#GrammaticalNumber">uby:GrammaticalNumber</a>
    /// </summary>
    let GrammaticalNumber = _prefixId.prefix "GrammaticalNumber"
    /// <summary>
    ///   <para>owl:versionInfo : superseded by lemon:canonicalForm^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:isDefinedBy : http://uby.googlecode.com/files/UBY_LMF_0_2_0.dtd^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#Lemma">uby:Lemma</a>
    /// </summary>
    let Lemma = _prefixId.prefix "Lemma"
    let LexicalAnnotation = _prefixId.prefix "LexicalAnnotation"
    /// <summary>
    ///   <para>owl:versionInfo : superseded by lemon:LexicalEntry^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:isDefinedBy : http://uby.googlecode.com/files/UBY_LMF_0_2_0.dtd^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#LexicalEntry">uby:LexicalEntry</a>
    /// </summary>
    let LexicalEntry = _prefixId.prefix "LexicalEntry"
    /// <summary>
    ///   <para>rdfs:comment : LexicalFeature groups different kinds of lexical feaures, which correspond to attributes of UBY-LMF classes.^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#LexicalFeature">uby:LexicalFeature</a>
    /// </summary>
    let LexicalFeature = _prefixId.prefix "LexicalFeature"
    /// <summary>
    ///   <para>owl:versionInfo : TODO: check whether these may be LexicalFeatureStructures^^xsd:stringowl:versionInfo : superseded by lemon data structures, left here only as a reference</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : complex lexical feature^^xsd:stringrdfs:label : lexical feature structure^^xsd:stringrdfs:label : lexical data structure^^xsd:string</para>
    ///   <para>rdfs:comment : LexicalFeatureStructure is a complex lexical Feature Structure (with features and feature values) and corresponds to a class in LMF.</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#LexicalFeatureStructure">uby:LexicalFeatureStructure</a>
    /// </summary>
    let LexicalFeatureStructure = _prefixId.prefix "LexicalFeatureStructure"
    /// <summary>
    ///   <para>owl:versionInfo : superseded by lemon:Lexicon^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:isDefinedBy : http://uby.googlecode.com/files/UBY_LMF_0_2_0.dtd^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#Lexicon">uby:Lexicon</a>
    /// </summary>
    let Lexicon = _prefixId.prefix "Lexicon"
    let LinkingFeature = _prefixId.prefix "LinkingFeature"
    let MetaFeature = _prefixId.prefix "MetaFeature"
    /// <summary>
    ///   <para>rdfs:label : monolingualExternalRef^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-1975^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#MonolingualExternalRef">uby:MonolingualExternalRef</a>
    /// </summary>
    let MonolingualExternalRef = _prefixId.prefix "MonolingualExternalRef"
    /// <summary>
    ///   <para>rdfs:label : partOfSpeech^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/olia/ubyCat.owl^^xsd:string</para>
    ///   <para>rdfs:comment : As a convention, the relation is called has_partOfSpeech, partOfSpeech is the top-level *class* of parts of speech^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#PartOfSpeech">uby:PartOfSpeech</a>
    /// </summary>
    let PartOfSpeech = _prefixId.prefix "PartOfSpeech"
    /// <summary>
    ///   <para>rdfs:label : person^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-3385^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#Person">uby:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : position^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-2237^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#Position">uby:Position</a>
    /// </summary>
    let Position = _prefixId.prefix "Position"
    /// <summary>
    ///   <para>owl:versionInfo : should be used together with hasQuantification to replace the DatatypeProperty quantification^^xsd:string</para>
    ///   <para>rdfs:label : quantification^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-2211^^xsd:string</para>
    ///   <para>rdfs:comment : In UBY-LMF, quantification is an attribute of the class SemanticLabel. It can be used, if the value of the semantic label is annotated with a score, e.g. type=sentiment, label=positive, quantification=strong.
    /// ^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#Quantification">uby:Quantification</a>
    /// </summary>
    let Quantification = _prefixId.prefix "Quantification"
    /// <summary>
    ///   <para>rdfs:label : relType^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-1971^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#RelType">uby:RelType</a>
    /// </summary>
    let RelType = _prefixId.prefix "RelType"
    /// <summary>
    ///   <para>owl:versionInfo : subclass of lemon:semArg^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://uby.googlecode.com/files/UBY_LMF_0_2_0.dtd^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#SemanticArgument">uby:SemanticArgument</a>
    /// </summary>
    let SemanticArgument = _prefixId.prefix "SemanticArgument"
    let SemanticFeature = _prefixId.prefix "SemanticFeature"
    /// <summary>
    ///   <para>owl:versionInfo : superseded by lemon:SemanticLabel^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : This owl:Class corresponds to the LMF-class SemanticLabel which has been introduced in UBY-LMF as an extension of ISO-LMF.^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#SemanticLabel">uby:SemanticLabel</a>
    /// </summary>
    let SemanticLabel = _prefixId.prefix "SemanticLabel"
    /// <summary>
    ///   <para>owl:versionInfo : subClass of lemon:LexicalSense^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://uby.googlecode.com/files/UBY_LMF_0_2_0.dtd^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#SemanticPredicate">uby:SemanticPredicate</a>
    /// </summary>
    let SemanticPredicate = _prefixId.prefix "SemanticPredicate"
    /// <summary>
    ///   <para>owl:versionInfo : superseded by lemon:LexicalSense^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:isDefinedBy : http://uby.googlecode.com/files/UBY_LMF_0_2_0.dtd^^xsd:stringrdfs:isDefinedBy : http://www.monnet-project.eu/lemon#LexicalSense^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#Sense">uby:Sense</a>
    /// </summary>
    let Sense = _prefixId.prefix "Sense"
    /// <summary>
    ///   <para>rdfs:label : senseAxisType^^xsd:string</para>
    ///   <para>rdfs:comment : In Uby-LMF, the attribute senseAxisType of the SenseAxis class indicates, whether the type of linking between to senses or between two synsets. Example values are monolingualSenseAlignment and crosslingualSenseAlignment^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#SenseAxisType">uby:SenseAxisType</a>
    /// </summary>
    let SenseAxisType = _prefixId.prefix "SenseAxisType"
    /// <summary>
    ///   <para>owl:versionInfo : superseded by lemon:UsageExample^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:isDefinedBy : http://uby.googlecode.com/files/UBY_LMF_0_2_0.dtd^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#SenseExample">uby:SenseExample</a>
    /// </summary>
    let SenseExample = _prefixId.prefix "SenseExample"
    /// <summary>
    ///   <para>owl:versionInfo : superseded by lemon:Frame^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:isDefinedBy : http://uby.googlecode.com/files/UBY_LMF_0_2_0.dtd^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#SubcategorizationFrame">uby:SubcategorizationFrame</a>
    /// </summary>
    let SubcategorizationFrame = _prefixId.prefix "SubcategorizationFrame"
    /// <summary>
    ///   <para>owl:versionInfo : mapped onto skos:Concept^^xsd:string</para>
    ///   <para>rdfs:comment : This owl:Class corresponds to the ISO LMF-class Synset.^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#Synset">uby:Synset</a>
    /// </summary>
    let Synset = _prefixId.prefix "Synset"
    /// <summary>
    ///   <para>owl:versionInfo : see lemon:synArg^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://uby.googlecode.com/files/UBY_LMF_0_2_0.dtd^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#SyntacticArgument">uby:SyntacticArgument</a>
    /// </summary>
    let SyntacticArgument = _prefixId.prefix "SyntacticArgument"
    /// <summary>
    ///   <para>rdfs:label : syntacticCategory^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-1506^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#SyntacticCategory">uby:SyntacticCategory</a>
    /// </summary>
    let SyntacticCategory = _prefixId.prefix "SyntacticCategory"
    /// <summary>
    ///   <para>rdfs:comment : SyntacticFeature groups attributes of UBY-LMF classes from the ISO LMF Syntax extension package.^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#SyntacticFeature">uby:SyntacticFeature</a>
    /// </summary>
    let SyntacticFeature = _prefixId.prefix "SyntacticFeature"
    /// <summary>
    ///   <para>rdfs:label : syntacticProperty^^xsd:string</para>
    ///   <para>rdfs:comment : Attribute of the UBY-LMF class SubcategorizationFrame.^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#SyntacticProperty">uby:SyntacticProperty</a>
    /// </summary>
    let SyntacticProperty = _prefixId.prefix "SyntacticProperty"
    /// <summary>
    ///   <para>rdfs:label : tense^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-3519^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#Tense">uby:Tense</a>
    /// </summary>
    let Tense = _prefixId.prefix "Tense"
    /// <summary>
    ///   <para>owl:versionInfo : Should replace the DatatypeProperty type^^xsd:string</para>
    ///   <para>rdfs:label : type^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-1971^^xsd:string</para>
    ///   <para>rdfs:comment : Type is an attribute of the UBY-LMF class SemanticLabel. It encodes the name of a SemanticLabel type, e.g.
    /// type=semanticField (from WordNet or GermaNet).
    /// The label attribute of SemanticLabel holds the corresponding value of the SemanticLabel, e.g.
    /// label=animate (for type=semanticField).^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#Type">uby:Type</a>
    /// </summary>
    let Type = _prefixId.prefix "Type"
    /// <summary>
    ///   <para>rdfs:label : verbForm^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the verb form to be used in a verb phrase complement.^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#VerbForm">uby:VerbForm</a>
    /// </summary>
    let VerbForm = _prefixId.prefix "VerbForm"
    /// <summary>
    ///   <para>rdfs:label : verbFormMood^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-1427^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#VerbFormMood">uby:VerbFormMood</a>
    /// </summary>
    let VerbFormMood = _prefixId.prefix "VerbFormMood"
    /// <summary>
    ///   <para>rdfs:label : WordForm^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/olia/ubyCat.owl^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#WordForm">uby:WordForm</a>
    /// </summary>
    let WordForm = _prefixId.prefix "WordForm"
    /// <summary>
    ///   <para>rdfs:label : WordFormAttribute^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/olia/ubyCat.owl^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#WordFormAttribute">uby:WordFormAttribute</a>
    /// </summary>
    let WordFormAttribute = _prefixId.prefix "WordFormAttribute"
    let abbreviation = _prefixId.prefix "abbreviation"
    let abbreviationAcronym = _prefixId.prefix "abbreviationAcronym"
    let abbreviationInitialism = _prefixId.prefix "abbreviationInitialism"
    let accusative = _prefixId.prefix "accusative"
    let adjective = _prefixId.prefix "adjective"
    let adjectivePhrase = _prefixId.prefix "adjectivePhrase"
    let adjectivePhrase_nounPhrase = _prefixId.prefix "adjectivePhrase_nounPhrase"
    let adposition = _prefixId.prefix "adposition"
    let adpositionCircumposition = _prefixId.prefix "adpositionCircumposition"
    let adpositionPostposition = _prefixId.prefix "adpositionPostposition"
    let adpositionPreposition = _prefixId.prefix "adpositionPreposition"
    let adverb = _prefixId.prefix "adverb"
    let adverbPhrase = _prefixId.prefix "adverbPhrase"
    let adverbPronominal = _prefixId.prefix "adverbPronominal"
    let adverbialComplement = _prefixId.prefix "adverbialComplement"
    let affix = _prefixId.prefix "affix"
    let affixPrefix = _prefixId.prefix "affixPrefix"
    let affixSuffix = _prefixId.prefix "affixSuffix"
    let association = _prefixId.prefix "association"
    let bareInfinitive = _prefixId.prefix "bareInfinitive"
    let comparative = _prefixId.prefix "comparative"
    let complement = _prefixId.prefix "complement"
    let complementary = _prefixId.prefix "complementary"
    let compound = _prefixId.prefix "compound"
    let compoundRoot = _prefixId.prefix "compoundRoot"
    let conjunction = _prefixId.prefix "conjunction"
    let conjunctionCoordinating = _prefixId.prefix "conjunctionCoordinating"
    let conjunctionSubordinating = _prefixId.prefix "conjunctionSubordinating"
    let contraction = _prefixId.prefix "contraction"
    let core = _prefixId.prefix "core"
    let coreUnexpressed = _prefixId.prefix "coreUnexpressed"
    /// <summary>
    ///   <para>rdfs:label : corpus^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-4361^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#corpus">uby:corpus</a>
    /// </summary>
    let corpus = _prefixId.prefix "corpus"
    let crosslingualSenseAlignment = _prefixId.prefix "crosslingualSenseAlignment"
    let dative = _prefixId.prefix "dative"
    let declarativeClause = _prefixId.prefix "declarativeClause"
    let derivationBase = _prefixId.prefix "derivationBase"
    let derivationBaseAdj = _prefixId.prefix "derivationBaseAdj"
    let derivationBaseNoun = _prefixId.prefix "derivationBaseNoun"
    let derivationBaseVerb = _prefixId.prefix "derivationBaseVerb"
    let derivative = _prefixId.prefix "derivative"
    let determiner = _prefixId.prefix "determiner"
    let determinerDefinite = _prefixId.prefix "determinerDefinite"
    let determinerDemonstrative = _prefixId.prefix "determinerDemonstrative"
    let determinerIndefinite = _prefixId.prefix "determinerIndefinite"
    let determinerInterrogative = _prefixId.prefix "determinerInterrogative"
    let determinerPossessive = _prefixId.prefix "determinerPossessive"
    let directObject = _prefixId.prefix "directObject"
    let etymology = _prefixId.prefix "etymology"
    let expletive = _prefixId.prefix "expletive"
    let extensionalDefinition = _prefixId.prefix "extensionalDefinition"
    /// <summary>
    ///   <para>rdfs:label : externalReference^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-1975^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#externalReference">uby:externalReference</a>
    /// </summary>
    let externalReference = _prefixId.prefix "externalReference"
    /// <summary>
    ///   <para>rdfs:label : externalSystem^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-1974^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#externalSystem">uby:externalSystem</a>
    /// </summary>
    let externalSystem = _prefixId.prefix "externalSystem"
    let extraThematic = _prefixId.prefix "extraThematic"
    let feminine = _prefixId.prefix "feminine"
    let first = _prefixId.prefix "first"
    /// <summary>
    ///   <para>rdfs:label : generator^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-2511^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#generator">uby:generator</a>
    /// </summary>
    let generator = _prefixId.prefix "generator"
    let genitive = _prefixId.prefix "genitive"
    /// <summary>
    ///   <para>owl:versionInfo : moved into language tags (JMC)^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : geographicalVariant^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-1851^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#geographicalVariant">uby:geographicalVariant</a>
    /// </summary>
    let geographicalVariant = _prefixId.prefix "geographicalVariant"
    /// <summary>
    ///   <para>rdfs:label : complementizer^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#hasComplementizer">uby:hasComplementizer</a>
    /// </summary>
    let hasComplementizer = _prefixId.prefix "hasComplementizer"
    /// <summary>
    ///   <para>rdfs:label : coreType^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#hasCoreType">uby:hasCoreType</a>
    /// </summary>
    let hasCoreType = _prefixId.prefix "hasCoreType"
    /// <summary>
    ///   <para>rdfs:label : definitionType^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#hasDefinitionType">uby:hasDefinitionType</a>
    /// </summary>
    let hasDefinitionType = _prefixId.prefix "hasDefinitionType"
    /// <summary>
    ///   <para>owl:versionInfo : It decides the property to use in the mapping, hence deprecated.
    /// relType="xxx" is normally uby:xxx
    /// (with some exceptions, .e.g, relType="seeAlso" is rdfs:seeAlso)^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : In UBY-LMF, relType is an attribute of the RelatedForm class which encodes links to derivationally related lexical entries or senses.^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#hasDerivationType">uby:hasDerivationType</a>
    /// </summary>
    let hasDerivationType = _prefixId.prefix "hasDerivationType"
    /// <summary>
    ///   <para>rdfs:label : determiner^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#hasDeterminer">uby:hasDeterminer</a>
    /// </summary>
    let hasDeterminer = _prefixId.prefix "hasDeterminer"
    /// <summary>
    ///   <para>rdfs:label : exampleType^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#hasExampleType">uby:hasExampleType</a>
    /// </summary>
    let hasExampleType = _prefixId.prefix "hasExampleType"
    /// <summary>
    ///   <para>rdfs:label : grammaticalFunction^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#hasGrammaticalFunction">uby:hasGrammaticalFunction</a>
    /// </summary>
    let hasGrammaticalFunction = _prefixId.prefix "hasGrammaticalFunction"
    /// <summary>
    ///   <para>rdfs:label : position^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#hasPosition">uby:hasPosition</a>
    /// </summary>
    let hasPosition = _prefixId.prefix "hasPosition"
    /// <summary>
    ///   <para>owl:versionInfo : Should be used to replace the DatatypeProperty quantification^^xsd:string</para>
    ///   <para>rdfs:label : quantification^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-2211^^xsd:string</para>
    ///   <para>rdfs:comment : In UBY-LMF, quantification is an attribute of the class SemanticLabel. It can be used, if the value of the semantic label is annotated with a score, e.g. type=sentiment, label=positive, quantification=strong.
    /// ^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#hasQuantification">uby:hasQuantification</a>
    /// </summary>
    let hasQuantification = _prefixId.prefix "hasQuantification"
    /// <summary>
    ///   <para>rdfs:label : relType^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#hasRelType">uby:hasRelType</a>
    /// </summary>
    let hasRelType = _prefixId.prefix "hasRelType"
    let hasSenseAxisType = _prefixId.prefix "hasSenseAxisType"
    /// <summary>
    ///   <para>rdfs:label : syntacticCategory^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#hasSyntacticCategory">uby:hasSyntacticCategory</a>
    /// </summary>
    let hasSyntacticCategory = _prefixId.prefix "hasSyntacticCategory"
    /// <summary>
    ///   <para>rdfs:label : syntacticProperty^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#hasSyntacticProperty">uby:hasSyntacticProperty</a>
    /// </summary>
    let hasSyntacticProperty = _prefixId.prefix "hasSyntacticProperty"
    /// <summary>
    ///   <para>owl:versionInfo : Should replace the DatatypeProperty type^^xsd:string</para>
    ///   <para>rdfs:label : type^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-1971^^xsd:string</para>
    ///   <para>rdfs:comment : Type is an attribute of the UBY-LMF class SemanticLabel. It encodes the name of a SemanticLabel type, e.g.
    /// type=semanticField (from WordNet or GermaNet).
    /// The label attribute of SemanticLabel holds the corresponding value of the SemanticLabel, e.g.
    /// label=animate (for type=semanticField).^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#hasType">uby:hasType</a>
    /// </summary>
    let hasType = _prefixId.prefix "hasType"
    /// <summary>
    ///   <para>rdfs:comment : This DatatypeProperty could also be named "hasSimpleLexicalFeature".
    /// The current name "hasUbyDatatypeProperty" indicates that it groups Data Properties used in UBY-LMF.^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#hasUbyDatatypeProperty">uby:hasUbyDatatypeProperty</a>
    /// </summary>
    let hasUbyDatatypeProperty = _prefixId.prefix "hasUbyDatatypeProperty"
    /// <summary>
    ///   <para>rdfs:comment : This ObjectProperty could also be named "hasTypedLexicalFeature".
    /// The current name "hasUbyObjectProperty" indicates that it groups Object Properties used in UBY-LMF.^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#hasUbyObjectProperty">uby:hasUbyObjectProperty</a>
    /// </summary>
    let hasUbyObjectProperty = _prefixId.prefix "hasUbyObjectProperty"
    /// <summary>
    ///   <para>rdfs:label : verbForm^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#hasVerbForm">uby:hasVerbForm</a>
    /// </summary>
    let hasVerbForm = _prefixId.prefix "hasVerbForm"
    /// <summary>
    ///   <para>rdfs:label : WordFormAttribute^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/olia/ubyCat.owl^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#has_WordFormAttribute">uby:has_WordFormAttribute</a>
    /// </summary>
    let has_WordFormAttribute = _prefixId.prefix "has_WordFormAttribute"
    /// <summary>
    ///   <para>rdfs:label : case^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#has_case">uby:has_case</a>
    /// </summary>
    let has_case = _prefixId.prefix "has_case"
    /// <summary>
    ///   <para>rdfs:label : degree^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#has_degree">uby:has_degree</a>
    /// </summary>
    let has_degree = _prefixId.prefix "has_degree"
    /// <summary>
    ///   <para>rdfs:label : grammaticalGender^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#has_grammaticalGender">uby:has_grammaticalGender</a>
    /// </summary>
    let has_grammaticalGender = _prefixId.prefix "has_grammaticalGender"
    /// <summary>
    ///   <para>rdfs:label : grammaticalNumber^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#has_grammaticalNumber">uby:has_grammaticalNumber</a>
    /// </summary>
    let has_grammaticalNumber = _prefixId.prefix "has_grammaticalNumber"
    /// <summary>
    ///   <para>rdfs:label : partOfSpeech^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-396^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#has_partOfSpeech">uby:has_partOfSpeech</a>
    /// </summary>
    let has_partOfSpeech = _prefixId.prefix "has_partOfSpeech"
    /// <summary>
    ///   <para>rdfs:label : person^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#has_person">uby:has_person</a>
    /// </summary>
    let has_person = _prefixId.prefix "has_person"
    /// <summary>
    ///   <para>rdfs:label : tense^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#has_tense">uby:has_tense</a>
    /// </summary>
    let has_tense = _prefixId.prefix "has_tense"
    /// <summary>
    ///   <para>rdfs:label : verbFormMood^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#has_verbFormMood">uby:has_verbFormMood</a>
    /// </summary>
    let has_verbFormMood = _prefixId.prefix "has_verbFormMood"
    /// <summary>
    ///   <para>rdfs:label : hyphenation^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-264^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#hyphenation">uby:hyphenation</a>
    /// </summary>
    let hyphenation = _prefixId.prefix "hyphenation"
    let idiomaticExpression = _prefixId.prefix "idiomaticExpression"
    let imperative = _prefixId.prefix "imperative"
    /// <summary>
    ///   <para>rdfs:label : incorporatedSemArg^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-4151^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#incorporatedSemArg">uby:incorporatedSemArg</a>
    /// </summary>
    let incorporatedSemArg = _prefixId.prefix "incorporatedSemArg"
    let indefinite = _prefixId.prefix "indefinite"
    /// <summary>
    ///   <para>rdfs:label : index^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-233^^xsd:string</para>
    ///   <para>rdfs:comment : Index is an attribute of the UBY-LMF class Sense.
    /// It encodes a ranking of the senses according to their frequency which is provided, e.g., by WordNet.^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#index">uby:index</a>
    /// </summary>
    let index = _prefixId.prefix "index"
    let indicative = _prefixId.prefix "indicative"
    let infinitive = _prefixId.prefix "infinitive"
    let infinitiveZu = _prefixId.prefix "infinitiveZu"
    let ingForm = _prefixId.prefix "ingForm"
    let intensionalDefinition = _prefixId.prefix "intensionalDefinition"
    let interjection = _prefixId.prefix "interjection"
    /// <summary>
    ///   <para>rdfs:label : isBreakBefore^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-4626^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#isBreakBefore">uby:isBreakBefore</a>
    /// </summary>
    let isBreakBefore = _prefixId.prefix "isBreakBefore"
    /// <summary>
    ///   <para>rdfs:label : isHead^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-4617^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#isHead">uby:isHead</a>
    /// </summary>
    let isHead = _prefixId.prefix "isHead"
    /// <summary>
    ///   <para>rdfs:label : isIncorporated^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-4151^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#isIncorporated">uby:isIncorporated</a>
    /// </summary>
    let isIncorporated = _prefixId.prefix "isIncorporated"
    /// <summary>
    ///   <para>rdfs:label : label^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-1857^^xsd:string</para>
    ///   <para>rdfs:comment : Label encodes a name (short - like a tag) and is an attribute of the UBY-LMF class SemanticLabel, SemanticPredicate, ^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#label">uby:label</a>
    /// </summary>
    let label = _prefixId.prefix "label"
    /// <summary>
    ///   <para>owl:versionInfo : replaced by a lang-tag^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : languageIdentifier^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-279^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#languageIdentifier">uby:languageIdentifier</a>
    /// </summary>
    let languageIdentifier = _prefixId.prefix "languageIdentifier"
    /// <summary>
    ///   <para>rdfs:label : lexeme^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-1325^^xsd:string</para>
    ///   <para>rdfs:comment : Lexeme is an attribute of the UBY-LMF class SyntacticArgument and specifies a particular lexeme to be used in realizations of particular complements.
    /// Example (lexeme = es, ObjectComplement realized as zu-infinitive): Er schafft es, den Termin einzuhalten.
    /// * Er schafft, den Termin einzuhalten.^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#lexeme">uby:lexeme</a>
    /// </summary>
    let lexeme = _prefixId.prefix "lexeme"
    /// <summary>
    ///   <para>rdfs:label : lexicalized^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-3295^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#lexicalized">uby:lexicalized</a>
    /// </summary>
    let lexicalized = _prefixId.prefix "lexicalized"
    let loanWord = _prefixId.prefix "loanWord"
    let masculine = _prefixId.prefix "masculine"
    /// <summary>
    ///   <para>rdfs:label : monolingualExternalRef^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#monolingualExternalRef">uby:monolingualExternalRef</a>
    /// </summary>
    let monolingualExternalRef = _prefixId.prefix "monolingualExternalRef"
    let monolingualSenseAlignment = _prefixId.prefix "monolingualSenseAlignment"
    let multiwordFeature = _prefixId.prefix "multiwordFeature"
    let neuter = _prefixId.prefix "neuter"
    let nominative = _prefixId.prefix "nominative"
    let nonPredicativeAdjective = _prefixId.prefix "nonPredicativeAdjective"
    let noun = _prefixId.prefix "noun"
    let nounCommon = _prefixId.prefix "nounCommon"
    let nounPhrase = _prefixId.prefix "nounPhrase"
    let nounProper = _prefixId.prefix "nounProper"
    let nounProperFamilyName = _prefixId.prefix "nounProperFamilyName"
    let nounProperGivenName = _prefixId.prefix "nounProperGivenName"
    let numeral = _prefixId.prefix "numeral"
    let objectComplement = _prefixId.prefix "objectComplement"
    let objectControl = _prefixId.prefix "objectControl"
    let objectRaising = _prefixId.prefix "objectRaising"
    /// <summary>
    ///   <para>rdfs:label : optional^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-4622^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#optionalArgument">uby:optionalArgument</a>
    /// </summary>
    let optionalArgument = _prefixId.prefix "optionalArgument"
    /// <summary>
    ///   <para>rdfs:label : orthographyName^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-2176^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#orthographyName">uby:orthographyName</a>
    /// </summary>
    let orthographyName = _prefixId.prefix "orthographyName"
    let other = _prefixId.prefix "other"
    let partWhole = _prefixId.prefix "partWhole"
    let participle = _prefixId.prefix "participle"
    let particle = _prefixId.prefix "particle"
    let particleAnswer = _prefixId.prefix "particleAnswer"
    let particleComparative = _prefixId.prefix "particleComparative"
    let particleInfinitive = _prefixId.prefix "particleInfinitive"
    let particleNegative = _prefixId.prefix "particleNegative"
    let partitiveDefinition = _prefixId.prefix "partitiveDefinition"
    let past = _prefixId.prefix "past"
    let peripheral = _prefixId.prefix "peripheral"
    /// <summary>
    ///   <para>rdfs:label : perspectivalized^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-4391^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#perspectivalized">uby:perspectivalized</a>
    /// </summary>
    let perspectivalized = _prefixId.prefix "perspectivalized"
    /// <summary>
    ///   <para>rdfs:label : phoneticForm^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-1837^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#phoneticForm">uby:phoneticForm</a>
    /// </summary>
    let phoneticForm = _prefixId.prefix "phoneticForm"
    let phraseme = _prefixId.prefix "phraseme"
    let plural = _prefixId.prefix "plural"
    let positive = _prefixId.prefix "positive"
    let possessive = _prefixId.prefix "possessive"
    let postpositiveAdjective = _prefixId.prefix "postpositiveAdjective"
    let predicativeAdjective = _prefixId.prefix "predicativeAdjective"
    /// <summary>
    ///   <para>rdfs:label : preposition^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-1366^^xsd:string</para>
    ///   <para>rdfs:comment : Preposition is an attribute of the UBY-LMF class SyntacticArgument and specifies the particular preposition to be used in prepositional complements that can either be realized as PP or as preposition and subordinate clause.
    /// Example: That depends on who did it.^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#preposition">uby:preposition</a>
    /// </summary>
    let preposition = _prefixId.prefix "preposition"
    /// <summary>
    ///   <para>rdfs:label : prepositionType^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-4621^^xsd:string</para>
    ///   <para>rdfs:comment : PrepositionType is an attribute of the UBY-LMF class SyntacticArgument and specifies the particular preposition type (e.g. locative, directional) to be used in prepositional complements.
    /// The preposition type is specified in VerbNet.^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#prepositionType">uby:prepositionType</a>
    /// </summary>
    let prepositionType = _prefixId.prefix "prepositionType"
    let prepositionalComplement = _prefixId.prefix "prepositionalComplement"
    let prepositionalPhrase = _prefixId.prefix "prepositionalPhrase"
    let present = _prefixId.prefix "present"
    let pronoun = _prefixId.prefix "pronoun"
    let pronounDemonstrative = _prefixId.prefix "pronounDemonstrative"
    let pronounIndefinite = _prefixId.prefix "pronounIndefinite"
    let pronounInterrogative = _prefixId.prefix "pronounInterrogative"
    let pronounPersonal = _prefixId.prefix "pronounPersonal"
    let pronounPersonalIrreflexive = _prefixId.prefix "pronounPersonalIrreflexive"
    let pronounPersonalReflexive = _prefixId.prefix "pronounPersonalReflexive"
    let pronounPossessive = _prefixId.prefix "pronounPossessive"
    let pronounRelative = _prefixId.prefix "pronounRelative"
    /// <summary>
    ///   <para>owl:versionInfo : Should be remodelled as an ObjectProperty in future versions^^xsd:string</para>
    ///   <para>rdfs:label : quantification^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-2211^^xsd:string</para>
    ///   <para>rdfs:comment : In UBY-LMF, quantification is an attribute of the class SemanticLabel. It can be used, if the value of the semantic label is annotated with a score, e.g. type=sentiment, label=positive, quantification=strong.
    /// ^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#quantification">uby:quantification</a>
    /// </summary>
    let quantification = _prefixId.prefix "quantification"
    let reflexive = _prefixId.prefix "reflexive"
    let second = _prefixId.prefix "second"
    /// <summary>
    ///   <para>rdfs:label : semanticRole^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-3466^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#semanticRole">uby:semanticRole</a>
    /// </summary>
    let semanticRole = _prefixId.prefix "semanticRole"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://www.monnet-project.eu/lemon#sense^^xsd:stringrdfs:isDefinedBy : http://uby.googlecode.com/files/UBY_LMF_0_2_0.dtd^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#sense">uby:sense</a>
    /// </summary>
    let sense = _prefixId.prefix "sense"
    let senseInstance = _prefixId.prefix "senseInstance"
    /// <summary>
    ///   <para>owl:versionInfo : superseded by lemon:senseRelation^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : SenseRelation^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://uby.googlecode.com/files/UBY_LMF_0_2_0.dtd^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#senseRelation">uby:senseRelation</a>
    /// </summary>
    let senseRelation = _prefixId.prefix "senseRelation"
    /// <summary>
    ///   <para>rdfs:label : separableParticle^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-3546^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#separableParticle">uby:separableParticle</a>
    /// </summary>
    let separableParticle = _prefixId.prefix "separableParticle"
    let singular = _prefixId.prefix "singular"
    /// <summary>
    ///   <para>rdfs:label : sound^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-2250^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#sound">uby:sound</a>
    /// </summary>
    let sound = _prefixId.prefix "sound"
    let subcatFrame = _prefixId.prefix "subcatFrame"
    let subject = _prefixId.prefix "subject"
    let subjectComplement = _prefixId.prefix "subjectComplement"
    let subjectControl = _prefixId.prefix "subjectControl"
    let subjectRaising = _prefixId.prefix "subjectRaising"
    let subjunctive = _prefixId.prefix "subjunctive"
    let subordinateClause = _prefixId.prefix "subordinateClause"
    let superlative = _prefixId.prefix "superlative"
    let supports = _prefixId.prefix "supports"
    let symbol = _prefixId.prefix "symbol"
    let syntacticUsage = _prefixId.prefix "syntacticUsage"
    let taxonomic = _prefixId.prefix "taxonomic"
    let thatType = _prefixId.prefix "thatType"
    let third = _prefixId.prefix "third"
    let toInfinitive = _prefixId.prefix "toInfinitive"
    let translatedDefinition = _prefixId.prefix "translatedDefinition"
    /// <summary>
    ///   <para>rdfs:label : transliteration^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-1848^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#transliteration">uby:transliteration</a>
    /// </summary>
    let transliteration = _prefixId.prefix "transliteration"
    /// <summary>
    ///   <para>rdfs:label : transparentMeaning^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-4390^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#transparentMeaning">uby:transparentMeaning</a>
    /// </summary>
    let transparentMeaning = _prefixId.prefix "transparentMeaning"
    /// <summary>
    ///   <para>owl:versionInfo : Should be replaced by the ObjectProperty hasType and the Class Type^^xsd:string</para>
    ///   <para>rdfs:label : type^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-1971^^xsd:string</para>
    ///   <para>rdfs:comment : Type is an attribute of the UBY-LMF class SemanticLabel. It encodes the name of a SemanticLabel type, e.g.
    /// type=semanticField (from WordNet or GermaNet).
    /// The label attribute of SemanticLabel holds the corresponding value of the SemanticLabel, e.g.
    /// label=animate (for type=semanticField).^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#type">uby:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>owl:versionInfo : Never used^^xsd:string</para>
    ///   <para>rdfs:label : usage^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-3764^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#usage">uby:usage</a>
    /// </summary>
    let usage = _prefixId.prefix "usage"
    let verb = _prefixId.prefix "verb"
    let verbAuxiliary = _prefixId.prefix "verbAuxiliary"
    let verbMain = _prefixId.prefix "verbMain"
    let verbModal = _prefixId.prefix "verbModal"
    let verbPhrase = _prefixId.prefix "verbPhrase"
    let whType = _prefixId.prefix "whType"
    /// <summary>
    ///   <para>rdfs:label : writtenForm^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.isocat.org/datcat/DC-1836^^xsd:string</para>
    ///   <a href="http://purl.org/olia/ubyCat.owl#writtenForm">uby:writtenForm</a>
    /// </summary>
    let writtenForm = _prefixId.prefix "writtenForm"
    let yesNoType = _prefixId.prefix "yesNoType"
