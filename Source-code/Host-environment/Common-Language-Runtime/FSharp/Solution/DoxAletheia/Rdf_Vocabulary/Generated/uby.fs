namespace http.purl.org.olia.ubyCat.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module uby =
    let _namespace_iri = Namespace_Iri uby |> NamespaceIRI
    /// <summary>
    ///   <para>uby:Case</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#Case">http://purl.org/olia/ubyCat.owl#Case</seealso>
    let Case = Prefixed_Name(uby, "Case") |> PrefixedName
    /// <summary>
    ///   <para>uby:Complementizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"complementizer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#Complementizer">http://purl.org/olia/ubyCat.owl#Complementizer</seealso>
    let Complementizer = Prefixed_Name(uby, "Complementizer") |> PrefixedName
    /// <summary>
    ///   <para>uby:Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#Context">http://purl.org/olia/ubyCat.owl#Context</seealso>
    let Context = Prefixed_Name(uby, "Context") |> PrefixedName
    /// <summary>
    ///   <para>uby:CoreType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"coreType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#CoreType">http://purl.org/olia/ubyCat.owl#CoreType</seealso>
    let CoreType = Prefixed_Name(uby, "CoreType") |> PrefixedName
    /// <summary>
    ///   <para>uby:Definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#Definition">http://purl.org/olia/ubyCat.owl#Definition</seealso>
    let Definition = Prefixed_Name(uby, "Definition") |> PrefixedName
    /// <summary>
    ///   <para>uby:DefinitionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"definitionType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#DefinitionType">http://purl.org/olia/ubyCat.owl#DefinitionType</seealso>
    let DefinitionType = Prefixed_Name(uby, "DefinitionType") |> PrefixedName
    /// <summary>
    ///   <para>uby:Degree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"degree"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#Degree">http://purl.org/olia/ubyCat.owl#Degree</seealso>
    let Degree = Prefixed_Name(uby, "Degree") |> PrefixedName
    /// <summary>
    ///   <para>uby:DerivationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In UBY-LMF, relType is an attribute of the RelatedForm class which encodes links to derivationally related lexical entries or senses."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"relType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#DerivationType">http://purl.org/olia/ubyCat.owl#DerivationType</seealso>
    let DerivationType = Prefixed_Name(uby, "DerivationType") |> PrefixedName

    /// <summary>
    ///   <para>uby:DerivationalMorphology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#DerivationalMorphology">http://purl.org/olia/ubyCat.owl#DerivationalMorphology</seealso>
    let DerivationalMorphology =
        Prefixed_Name(uby, "DerivationalMorphology") |> PrefixedName

    /// <summary>
    ///   <para>uby:Determiner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In UBY-LMF, determiner is an attribute of the LMF class SyntacticArgument. For noun phrase arguments, this attribute encodes specific constraints on the determiner to be used (possessive or indefinite).
    ///
    /// Example given in VerbNet (possessive): They allow our smoking.
    /// Example from VerbNet (indefinite): an indefinite determiner is required for the noun phrase complement of "echo" as in
    /// There echoed voices through the hall. (verb class sound_existence-47.4)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"determiner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#Determiner">http://purl.org/olia/ubyCat.owl#Determiner</seealso>
    let Determiner = Prefixed_Name(uby, "Determiner") |> PrefixedName
    /// <summary>
    ///   <para>uby:DictionaryFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#DictionaryFeature">http://purl.org/olia/ubyCat.owl#DictionaryFeature</seealso>
    let DictionaryFeature = Prefixed_Name(uby, "DictionaryFeature") |> PrefixedName
    /// <summary>
    ///   <para>uby:ExampleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exampleType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#ExampleType">http://purl.org/olia/ubyCat.owl#ExampleType</seealso>
    let ExampleType = Prefixed_Name(uby, "ExampleType") |> PrefixedName
    /// <summary>
    ///   <para>uby:Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This owl:Class corresponds to the LMF-class Frequency which has been introduced in UBY-LMF as an extension of ISO-LMF."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#Frequency">http://purl.org/olia/ubyCat.owl#Frequency</seealso>
    let Frequency = Prefixed_Name(uby, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>uby:GrammaticalFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"grammaticalFunction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#GrammaticalFunction">http://purl.org/olia/ubyCat.owl#GrammaticalFunction</seealso>
    let GrammaticalFunction = Prefixed_Name(uby, "GrammaticalFunction") |> PrefixedName
    /// <summary>
    ///   <para>uby:GrammaticalGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"grammaticalGender"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#GrammaticalGender">http://purl.org/olia/ubyCat.owl#GrammaticalGender</seealso>
    let GrammaticalGender = Prefixed_Name(uby, "GrammaticalGender") |> PrefixedName
    /// <summary>
    ///   <para>uby:GrammaticalNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In UBY-LMF, number is also an attribute of the UBY-LMF class SyntacticArgument and specifies the grammatical number of an argument.
    /// Example: These types of fish mix well together."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"grammaticalNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#GrammaticalNumber">http://purl.org/olia/ubyCat.owl#GrammaticalNumber</seealso>
    let GrammaticalNumber = Prefixed_Name(uby, "GrammaticalNumber") |> PrefixedName
    /// <summary>
    ///   <para>uby:Lemma</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#Lemma">http://purl.org/olia/ubyCat.owl#Lemma</seealso>
    let Lemma = Prefixed_Name(uby, "Lemma") |> PrefixedName
    /// <summary>
    ///   <para>uby:LexicalAnnotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#LexicalAnnotation">http://purl.org/olia/ubyCat.owl#LexicalAnnotation</seealso>
    let LexicalAnnotation = Prefixed_Name(uby, "LexicalAnnotation") |> PrefixedName
    /// <summary>
    ///   <para>uby:LexicalEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#LexicalEntry">http://purl.org/olia/ubyCat.owl#LexicalEntry</seealso>
    let LexicalEntry = Prefixed_Name(uby, "LexicalEntry") |> PrefixedName
    /// <summary>
    ///   <para>uby:LexicalFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"LexicalFeature groups different kinds of lexical feaures, which correspond to attributes of UBY-LMF classes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#LexicalFeature">http://purl.org/olia/ubyCat.owl#LexicalFeature</seealso>
    let LexicalFeature = Prefixed_Name(uby, "LexicalFeature") |> PrefixedName

    /// <summary>
    ///   <para>uby:LexicalFeatureStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"LexicalFeatureStructure is a complex lexical Feature Structure (with features and feature values) and corresponds to a class in LMF."</para>
    /// labels<para>"lexical feature structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"lexical data structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"complex lexical feature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#LexicalFeatureStructure">http://purl.org/olia/ubyCat.owl#LexicalFeatureStructure</seealso>
    let LexicalFeatureStructure =
        Prefixed_Name(uby, "LexicalFeatureStructure") |> PrefixedName

    /// <summary>
    ///   <para>uby:Lexicon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#Lexicon">http://purl.org/olia/ubyCat.owl#Lexicon</seealso>
    let Lexicon = Prefixed_Name(uby, "Lexicon") |> PrefixedName
    /// <summary>
    ///   <para>uby:LinkingFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#LinkingFeature">http://purl.org/olia/ubyCat.owl#LinkingFeature</seealso>
    let LinkingFeature = Prefixed_Name(uby, "LinkingFeature") |> PrefixedName
    /// <summary>
    ///   <para>uby:MetaFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#MetaFeature">http://purl.org/olia/ubyCat.owl#MetaFeature</seealso>
    let MetaFeature = Prefixed_Name(uby, "MetaFeature") |> PrefixedName

    /// <summary>
    ///   <para>uby:MonolingualExternalRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"monolingualExternalRef"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#MonolingualExternalRef">http://purl.org/olia/ubyCat.owl#MonolingualExternalRef</seealso>
    let MonolingualExternalRef =
        Prefixed_Name(uby, "MonolingualExternalRef") |> PrefixedName

    /// <summary>
    ///   <para>uby:PartOfSpeech</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"As a convention, the relation is called has_partOfSpeech, partOfSpeech is the top-level *class* of parts of speech"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"partOfSpeech"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#PartOfSpeech">http://purl.org/olia/ubyCat.owl#PartOfSpeech</seealso>
    let PartOfSpeech = Prefixed_Name(uby, "PartOfSpeech") |> PrefixedName
    /// <summary>
    ///   <para>uby:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#Person">http://purl.org/olia/ubyCat.owl#Person</seealso>
    let Person = Prefixed_Name(uby, "Person") |> PrefixedName
    /// <summary>
    ///   <para>uby:Position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#Position">http://purl.org/olia/ubyCat.owl#Position</seealso>
    let Position = Prefixed_Name(uby, "Position") |> PrefixedName
    /// <summary>
    ///   <para>uby:Quantification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In UBY-LMF, quantification is an attribute of the class SemanticLabel. It can be used, if the value of the semantic label is annotated with a score, e.g. type=sentiment, label=positive, quantification=strong.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"quantification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#Quantification">http://purl.org/olia/ubyCat.owl#Quantification</seealso>
    let Quantification = Prefixed_Name(uby, "Quantification") |> PrefixedName
    /// <summary>
    ///   <para>uby:RelType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"relType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#RelType">http://purl.org/olia/ubyCat.owl#RelType</seealso>
    let RelType = Prefixed_Name(uby, "RelType") |> PrefixedName
    /// <summary>
    ///   <para>uby:SemanticArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#SemanticArgument">http://purl.org/olia/ubyCat.owl#SemanticArgument</seealso>
    let SemanticArgument = Prefixed_Name(uby, "SemanticArgument") |> PrefixedName
    /// <summary>
    ///   <para>uby:SemanticFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#SemanticFeature">http://purl.org/olia/ubyCat.owl#SemanticFeature</seealso>
    let SemanticFeature = Prefixed_Name(uby, "SemanticFeature") |> PrefixedName
    /// <summary>
    ///   <para>uby:SemanticLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This owl:Class corresponds to the LMF-class SemanticLabel which has been introduced in UBY-LMF as an extension of ISO-LMF."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#SemanticLabel">http://purl.org/olia/ubyCat.owl#SemanticLabel</seealso>
    let SemanticLabel = Prefixed_Name(uby, "SemanticLabel") |> PrefixedName
    /// <summary>
    ///   <para>uby:SemanticPredicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#SemanticPredicate">http://purl.org/olia/ubyCat.owl#SemanticPredicate</seealso>
    let SemanticPredicate = Prefixed_Name(uby, "SemanticPredicate") |> PrefixedName
    /// <summary>
    ///   <para>uby:Sense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#Sense">http://purl.org/olia/ubyCat.owl#Sense</seealso>
    let Sense = Prefixed_Name(uby, "Sense") |> PrefixedName
    /// <summary>
    ///   <para>uby:SenseAxisType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In Uby-LMF, the attribute senseAxisType of the SenseAxis class indicates, whether the type of linking between to senses or between two synsets. Example values are monolingualSenseAlignment and crosslingualSenseAlignment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"senseAxisType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#SenseAxisType">http://purl.org/olia/ubyCat.owl#SenseAxisType</seealso>
    let SenseAxisType = Prefixed_Name(uby, "SenseAxisType") |> PrefixedName
    /// <summary>
    ///   <para>uby:SenseExample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#SenseExample">http://purl.org/olia/ubyCat.owl#SenseExample</seealso>
    let SenseExample = Prefixed_Name(uby, "SenseExample") |> PrefixedName

    /// <summary>
    ///   <para>uby:SubcategorizationFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#SubcategorizationFrame">http://purl.org/olia/ubyCat.owl#SubcategorizationFrame</seealso>
    let SubcategorizationFrame =
        Prefixed_Name(uby, "SubcategorizationFrame") |> PrefixedName

    /// <summary>
    ///   <para>uby:Synset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This owl:Class corresponds to the ISO LMF-class Synset."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#Synset">http://purl.org/olia/ubyCat.owl#Synset</seealso>
    let Synset = Prefixed_Name(uby, "Synset") |> PrefixedName
    /// <summary>
    ///   <para>uby:SyntacticArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#SyntacticArgument">http://purl.org/olia/ubyCat.owl#SyntacticArgument</seealso>
    let SyntacticArgument = Prefixed_Name(uby, "SyntacticArgument") |> PrefixedName
    /// <summary>
    ///   <para>uby:SyntacticCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"syntacticCategory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#SyntacticCategory">http://purl.org/olia/ubyCat.owl#SyntacticCategory</seealso>
    let SyntacticCategory = Prefixed_Name(uby, "SyntacticCategory") |> PrefixedName
    /// <summary>
    ///   <para>uby:SyntacticFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SyntacticFeature groups attributes of UBY-LMF classes from the ISO LMF Syntax extension package."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#SyntacticFeature">http://purl.org/olia/ubyCat.owl#SyntacticFeature</seealso>
    let SyntacticFeature = Prefixed_Name(uby, "SyntacticFeature") |> PrefixedName
    /// <summary>
    ///   <para>uby:SyntacticProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Attribute of the UBY-LMF class SubcategorizationFrame."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"syntacticProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#SyntacticProperty">http://purl.org/olia/ubyCat.owl#SyntacticProperty</seealso>
    let SyntacticProperty = Prefixed_Name(uby, "SyntacticProperty") |> PrefixedName
    /// <summary>
    ///   <para>uby:Tense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tense"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#Tense">http://purl.org/olia/ubyCat.owl#Tense</seealso>
    let Tense = Prefixed_Name(uby, "Tense") |> PrefixedName
    /// <summary>
    ///   <para>uby:Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Type is an attribute of the UBY-LMF class SemanticLabel. It encodes the name of a SemanticLabel type, e.g.
    /// type=semanticField (from WordNet or GermaNet).
    /// The label attribute of SemanticLabel holds the corresponding value of the SemanticLabel, e.g.
    /// label=animate (for type=semanticField)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#Type">http://purl.org/olia/ubyCat.owl#Type</seealso>
    let Type = Prefixed_Name(uby, "Type") |> PrefixedName
    /// <summary>
    ///   <para>uby:VerbForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies the verb form to be used in a verb phrase complement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"verbForm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#VerbForm">http://purl.org/olia/ubyCat.owl#VerbForm</seealso>
    let VerbForm = Prefixed_Name(uby, "VerbForm") |> PrefixedName
    /// <summary>
    ///   <para>uby:VerbFormMood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"verbFormMood"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#VerbFormMood">http://purl.org/olia/ubyCat.owl#VerbFormMood</seealso>
    let VerbFormMood = Prefixed_Name(uby, "VerbFormMood") |> PrefixedName
    /// <summary>
    ///   <para>uby:WordForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WordForm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#WordForm">http://purl.org/olia/ubyCat.owl#WordForm</seealso>
    let WordForm = Prefixed_Name(uby, "WordForm") |> PrefixedName
    /// <summary>
    ///   <para>uby:WordFormAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WordFormAttribute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#WordFormAttribute">http://purl.org/olia/ubyCat.owl#WordFormAttribute</seealso>
    let WordFormAttribute = Prefixed_Name(uby, "WordFormAttribute") |> PrefixedName
    /// <summary>
    ///   <para>uby:abbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"abbreviation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#abbreviation">http://purl.org/olia/ubyCat.owl#abbreviation</seealso>
    let abbreviation = Prefixed_Name(uby, "abbreviation") |> PrefixedName
    /// <summary>
    ///   <para>uby:abbreviationAcronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"abbreviationAcronym"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#abbreviationAcronym">http://purl.org/olia/ubyCat.owl#abbreviationAcronym</seealso>
    let abbreviationAcronym = Prefixed_Name(uby, "abbreviationAcronym") |> PrefixedName

    /// <summary>
    ///   <para>uby:abbreviationInitialism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"abbreviationInitialism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#abbreviationInitialism">http://purl.org/olia/ubyCat.owl#abbreviationInitialism</seealso>
    let abbreviationInitialism =
        Prefixed_Name(uby, "abbreviationInitialism") |> PrefixedName

    /// <summary>
    ///   <para>uby:accusative</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:Case</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"accusative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#accusative">http://purl.org/olia/ubyCat.owl#accusative</seealso>
    let accusative = Prefixed_Name(uby, "accusative") |> PrefixedName
    /// <summary>
    ///   <para>uby:adjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"adjective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#adjective">http://purl.org/olia/ubyCat.owl#adjective</seealso>
    let adjective = Prefixed_Name(uby, "adjective") |> PrefixedName
    /// <summary>
    ///   <para>uby:adjectivePhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:SyntacticCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"adjectivePhrase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#adjectivePhrase">http://purl.org/olia/ubyCat.owl#adjectivePhrase</seealso>
    let adjectivePhrase = Prefixed_Name(uby, "adjectivePhrase") |> PrefixedName

    /// <summary>
    ///   <para>uby:adjectivePhrase_nounPhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:SyntacticCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"adjectivePhrase_nounPhrase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#adjectivePhrase_nounPhrase">http://purl.org/olia/ubyCat.owl#adjectivePhrase_nounPhrase</seealso>
    let adjectivePhrase_nounPhrase =
        Prefixed_Name(uby, "adjectivePhrase_nounPhrase") |> PrefixedName

    /// <summary>
    ///   <para>uby:adposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"adposition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#adposition">http://purl.org/olia/ubyCat.owl#adposition</seealso>
    let adposition = Prefixed_Name(uby, "adposition") |> PrefixedName

    /// <summary>
    ///   <para>uby:adpositionCircumposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"adpositionCircumposition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#adpositionCircumposition">http://purl.org/olia/ubyCat.owl#adpositionCircumposition</seealso>
    let adpositionCircumposition =
        Prefixed_Name(uby, "adpositionCircumposition") |> PrefixedName

    /// <summary>
    ///   <para>uby:adpositionPostposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"adpositionPostposition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#adpositionPostposition">http://purl.org/olia/ubyCat.owl#adpositionPostposition</seealso>
    let adpositionPostposition =
        Prefixed_Name(uby, "adpositionPostposition") |> PrefixedName

    /// <summary>
    ///   <para>uby:adpositionPreposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"adpositionPreposition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#adpositionPreposition">http://purl.org/olia/ubyCat.owl#adpositionPreposition</seealso>
    let adpositionPreposition =
        Prefixed_Name(uby, "adpositionPreposition") |> PrefixedName

    /// <summary>
    ///   <para>uby:adverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"adverb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#adverb">http://purl.org/olia/ubyCat.owl#adverb</seealso>
    let adverb = Prefixed_Name(uby, "adverb") |> PrefixedName
    /// <summary>
    ///   <para>uby:adverbPhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:SyntacticCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"adverbPhrase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#adverbPhrase">http://purl.org/olia/ubyCat.owl#adverbPhrase</seealso>
    let adverbPhrase = Prefixed_Name(uby, "adverbPhrase") |> PrefixedName
    /// <summary>
    ///   <para>uby:adverbPronominal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"adverbPronominal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#adverbPronominal">http://purl.org/olia/ubyCat.owl#adverbPronominal</seealso>
    let adverbPronominal = Prefixed_Name(uby, "adverbPronominal") |> PrefixedName
    /// <summary>
    ///   <para>uby:adverbialComplement</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:GrammaticalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"adverbialComplement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#adverbialComplement">http://purl.org/olia/ubyCat.owl#adverbialComplement</seealso>
    let adverbialComplement = Prefixed_Name(uby, "adverbialComplement") |> PrefixedName
    /// <summary>
    ///   <para>uby:affix</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"affix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#affix">http://purl.org/olia/ubyCat.owl#affix</seealso>
    let affix = Prefixed_Name(uby, "affix") |> PrefixedName
    /// <summary>
    ///   <para>uby:affixPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"affixPrefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#affixPrefix">http://purl.org/olia/ubyCat.owl#affixPrefix</seealso>
    let affixPrefix = Prefixed_Name(uby, "affixPrefix") |> PrefixedName
    /// <summary>
    ///   <para>uby:affixSuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"affixSuffix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#affixSuffix">http://purl.org/olia/ubyCat.owl#affixSuffix</seealso>
    let affixSuffix = Prefixed_Name(uby, "affixSuffix") |> PrefixedName
    /// <summary>
    ///   <para>uby:association</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:RelType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"association"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#association">http://purl.org/olia/ubyCat.owl#association</seealso>
    let association = Prefixed_Name(uby, "association") |> PrefixedName
    /// <summary>
    ///   <para>uby:bareInfinitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:VerbForm</para>
    ///
    /// labels<para>"bareInfinitive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#bareInfinitive">http://purl.org/olia/ubyCat.owl#bareInfinitive</seealso>
    let bareInfinitive = Prefixed_Name(uby, "bareInfinitive") |> PrefixedName
    /// <summary>
    ///   <para>uby:comparative</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:Degree</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"comparative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#comparative">http://purl.org/olia/ubyCat.owl#comparative</seealso>
    let comparative = Prefixed_Name(uby, "comparative") |> PrefixedName
    /// <summary>
    ///   <para>uby:complement</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:GrammaticalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"complement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#complement">http://purl.org/olia/ubyCat.owl#complement</seealso>
    let complement = Prefixed_Name(uby, "complement") |> PrefixedName
    /// <summary>
    ///   <para>uby:complementary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:RelType</para>
    ///
    /// labels<para>"complementary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#complementary">http://purl.org/olia/ubyCat.owl#complementary</seealso>
    let complementary = Prefixed_Name(uby, "complementary") |> PrefixedName
    /// <summary>
    ///   <para>uby:compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:DerivationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#compound">http://purl.org/olia/ubyCat.owl#compound</seealso>
    let compound = Prefixed_Name(uby, "compound") |> PrefixedName
    /// <summary>
    ///   <para>uby:compoundRoot</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:DerivationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"compoundRoot"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#compoundRoot">http://purl.org/olia/ubyCat.owl#compoundRoot</seealso>
    let compoundRoot = Prefixed_Name(uby, "compoundRoot") |> PrefixedName
    /// <summary>
    ///   <para>uby:conjunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"conjunction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#conjunction">http://purl.org/olia/ubyCat.owl#conjunction</seealso>
    let conjunction = Prefixed_Name(uby, "conjunction") |> PrefixedName

    /// <summary>
    ///   <para>uby:conjunctionCoordinating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"conjunctionCoordinating"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#conjunctionCoordinating">http://purl.org/olia/ubyCat.owl#conjunctionCoordinating</seealso>
    let conjunctionCoordinating =
        Prefixed_Name(uby, "conjunctionCoordinating") |> PrefixedName

    /// <summary>
    ///   <para>uby:conjunctionSubordinating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"conjunctionSubordinating"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#conjunctionSubordinating">http://purl.org/olia/ubyCat.owl#conjunctionSubordinating</seealso>
    let conjunctionSubordinating =
        Prefixed_Name(uby, "conjunctionSubordinating") |> PrefixedName

    /// <summary>
    ///   <para>uby:contraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"contraction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#contraction">http://purl.org/olia/ubyCat.owl#contraction</seealso>
    let contraction = Prefixed_Name(uby, "contraction") |> PrefixedName
    /// <summary>
    ///   <para>uby:core</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:CoreType</para>
    ///
    /// labels<para>"core"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#core">http://purl.org/olia/ubyCat.owl#core</seealso>
    let core = Prefixed_Name(uby, "core") |> PrefixedName
    /// <summary>
    ///   <para>uby:coreUnexpressed</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:CoreType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"coreUnexpressed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#coreUnexpressed">http://purl.org/olia/ubyCat.owl#coreUnexpressed</seealso>
    let coreUnexpressed = Prefixed_Name(uby, "coreUnexpressed") |> PrefixedName
    /// <summary>
    ///   <para>uby:corpus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"corpus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#corpus">http://purl.org/olia/ubyCat.owl#corpus</seealso>
    let corpus = Prefixed_Name(uby, "corpus") |> PrefixedName

    /// <summary>
    ///   <para>uby:crosslingualSenseAlignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:SenseAxisType</para>
    ///
    /// labels<para>"crosslingualSenseAlignment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#crosslingualSenseAlignment">http://purl.org/olia/ubyCat.owl#crosslingualSenseAlignment</seealso>
    let crosslingualSenseAlignment =
        Prefixed_Name(uby, "crosslingualSenseAlignment") |> PrefixedName

    /// <summary>
    ///   <para>uby:dative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:Case</para>
    ///
    /// labels<para>"dative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#dative">http://purl.org/olia/ubyCat.owl#dative</seealso>
    let dative = Prefixed_Name(uby, "dative") |> PrefixedName
    /// <summary>
    ///   <para>uby:declarativeClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:SyntacticCategory</para>
    ///
    /// labels<para>"declarativeClause"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#declarativeClause">http://purl.org/olia/ubyCat.owl#declarativeClause</seealso>
    let declarativeClause = Prefixed_Name(uby, "declarativeClause") |> PrefixedName
    /// <summary>
    ///   <para>uby:derivationBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:DerivationType</para>
    ///
    /// labels<para>"derivationBase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#derivationBase">http://purl.org/olia/ubyCat.owl#derivationBase</seealso>
    let derivationBase = Prefixed_Name(uby, "derivationBase") |> PrefixedName
    /// <summary>
    ///   <para>uby:derivationBaseAdj</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:DerivationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"derivationBaseAdj"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#derivationBaseAdj">http://purl.org/olia/ubyCat.owl#derivationBaseAdj</seealso>
    let derivationBaseAdj = Prefixed_Name(uby, "derivationBaseAdj") |> PrefixedName
    /// <summary>
    ///   <para>uby:derivationBaseNoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:DerivationType</para>
    ///
    /// labels<para>"derivationBaseNoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#derivationBaseNoun">http://purl.org/olia/ubyCat.owl#derivationBaseNoun</seealso>
    let derivationBaseNoun = Prefixed_Name(uby, "derivationBaseNoun") |> PrefixedName
    /// <summary>
    ///   <para>uby:derivationBaseVerb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:DerivationType</para>
    ///
    /// labels<para>"derivationBaseVerb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#derivationBaseVerb">http://purl.org/olia/ubyCat.owl#derivationBaseVerb</seealso>
    let derivationBaseVerb = Prefixed_Name(uby, "derivationBaseVerb") |> PrefixedName
    /// <summary>
    ///   <para>uby:derivative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:DerivationType</para>
    ///
    /// labels<para>"derivative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#derivative">http://purl.org/olia/ubyCat.owl#derivative</seealso>
    let derivative = Prefixed_Name(uby, "derivative") |> PrefixedName
    /// <summary>
    ///   <para>uby:determiner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"determiner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#determiner">http://purl.org/olia/ubyCat.owl#determiner</seealso>
    let determiner = Prefixed_Name(uby, "determiner") |> PrefixedName
    /// <summary>
    ///   <para>uby:determinerDefinite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"determinerDefinite"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#determinerDefinite">http://purl.org/olia/ubyCat.owl#determinerDefinite</seealso>
    let determinerDefinite = Prefixed_Name(uby, "determinerDefinite") |> PrefixedName

    /// <summary>
    ///   <para>uby:determinerDemonstrative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"determinerDemonstrative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#determinerDemonstrative">http://purl.org/olia/ubyCat.owl#determinerDemonstrative</seealso>
    let determinerDemonstrative =
        Prefixed_Name(uby, "determinerDemonstrative") |> PrefixedName

    /// <summary>
    ///   <para>uby:determinerIndefinite</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"determinerIndefinite"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#determinerIndefinite">http://purl.org/olia/ubyCat.owl#determinerIndefinite</seealso>
    let determinerIndefinite =
        Prefixed_Name(uby, "determinerIndefinite") |> PrefixedName

    /// <summary>
    ///   <para>uby:determinerInterrogative</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"determinerInterrogative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#determinerInterrogative">http://purl.org/olia/ubyCat.owl#determinerInterrogative</seealso>
    let determinerInterrogative =
        Prefixed_Name(uby, "determinerInterrogative") |> PrefixedName

    /// <summary>
    ///   <para>uby:determinerPossessive</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"determinerPossessive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#determinerPossessive">http://purl.org/olia/ubyCat.owl#determinerPossessive</seealso>
    let determinerPossessive =
        Prefixed_Name(uby, "determinerPossessive") |> PrefixedName

    /// <summary>
    ///   <para>uby:directObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:GrammaticalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"directObject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#directObject">http://purl.org/olia/ubyCat.owl#directObject</seealso>
    let directObject = Prefixed_Name(uby, "directObject") |> PrefixedName
    /// <summary>
    ///   <para>uby:etymology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:DerivationType</para>
    ///
    /// labels<para>"etymology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#etymology">http://purl.org/olia/ubyCat.owl#etymology</seealso>
    let etymology = Prefixed_Name(uby, "etymology") |> PrefixedName
    /// <summary>
    ///   <para>uby:expletive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:SyntacticCategory</para>
    ///
    /// labels<para>"expletive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#expletive">http://purl.org/olia/ubyCat.owl#expletive</seealso>
    let expletive = Prefixed_Name(uby, "expletive") |> PrefixedName

    /// <summary>
    ///   <para>uby:extensionalDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:DefinitionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"extensionalDefinition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#extensionalDefinition">http://purl.org/olia/ubyCat.owl#extensionalDefinition</seealso>
    let extensionalDefinition =
        Prefixed_Name(uby, "extensionalDefinition") |> PrefixedName

    /// <summary>
    ///   <para>uby:externalReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"externalReference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#externalReference">http://purl.org/olia/ubyCat.owl#externalReference</seealso>
    let externalReference = Prefixed_Name(uby, "externalReference") |> PrefixedName
    /// <summary>
    ///   <para>uby:externalSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"externalSystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#externalSystem">http://purl.org/olia/ubyCat.owl#externalSystem</seealso>
    let externalSystem = Prefixed_Name(uby, "externalSystem") |> PrefixedName
    /// <summary>
    ///   <para>uby:extraThematic</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:CoreType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"extraThematic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#extraThematic">http://purl.org/olia/ubyCat.owl#extraThematic</seealso>
    let extraThematic = Prefixed_Name(uby, "extraThematic") |> PrefixedName
    /// <summary>
    ///   <para>uby:feminine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:GrammaticalGender</para>
    ///
    /// labels<para>"feminine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#feminine">http://purl.org/olia/ubyCat.owl#feminine</seealso>
    let feminine = Prefixed_Name(uby, "feminine") |> PrefixedName
    /// <summary>
    ///   <para>uby:first</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:Person</para>
    ///
    /// labels<para>"first"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#first">http://purl.org/olia/ubyCat.owl#first</seealso>
    let first = Prefixed_Name(uby, "first") |> PrefixedName
    /// <summary>
    ///   <para>uby:generator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"generator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#generator">http://purl.org/olia/ubyCat.owl#generator</seealso>
    let generator = Prefixed_Name(uby, "generator") |> PrefixedName
    /// <summary>
    ///   <para>uby:genitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:Case</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"genitive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#genitive">http://purl.org/olia/ubyCat.owl#genitive</seealso>
    let genitive = Prefixed_Name(uby, "genitive") |> PrefixedName
    /// <summary>
    ///   <para>uby:geographicalVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"geographicalVariant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#geographicalVariant">http://purl.org/olia/ubyCat.owl#geographicalVariant</seealso>
    let geographicalVariant = Prefixed_Name(uby, "geographicalVariant") |> PrefixedName
    /// <summary>
    ///   <para>uby:hasComplementizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"complementizer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#hasComplementizer">http://purl.org/olia/ubyCat.owl#hasComplementizer</seealso>
    let hasComplementizer = Prefixed_Name(uby, "hasComplementizer") |> PrefixedName
    /// <summary>
    ///   <para>uby:hasCoreType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"coreType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#hasCoreType">http://purl.org/olia/ubyCat.owl#hasCoreType</seealso>
    let hasCoreType = Prefixed_Name(uby, "hasCoreType") |> PrefixedName
    /// <summary>
    ///   <para>uby:hasDefinitionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"definitionType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#hasDefinitionType">http://purl.org/olia/ubyCat.owl#hasDefinitionType</seealso>
    let hasDefinitionType = Prefixed_Name(uby, "hasDefinitionType") |> PrefixedName
    /// <summary>
    ///   <para>uby:hasDerivationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In UBY-LMF, relType is an attribute of the RelatedForm class which encodes links to derivationally related lexical entries or senses."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#hasDerivationType">http://purl.org/olia/ubyCat.owl#hasDerivationType</seealso>
    let hasDerivationType = Prefixed_Name(uby, "hasDerivationType") |> PrefixedName
    /// <summary>
    ///   <para>uby:hasDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"determiner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#hasDeterminer">http://purl.org/olia/ubyCat.owl#hasDeterminer</seealso>
    let hasDeterminer = Prefixed_Name(uby, "hasDeterminer") |> PrefixedName
    /// <summary>
    ///   <para>uby:hasExampleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"exampleType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#hasExampleType">http://purl.org/olia/ubyCat.owl#hasExampleType</seealso>
    let hasExampleType = Prefixed_Name(uby, "hasExampleType") |> PrefixedName

    /// <summary>
    ///   <para>uby:hasGrammaticalFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"grammaticalFunction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#hasGrammaticalFunction">http://purl.org/olia/ubyCat.owl#hasGrammaticalFunction</seealso>
    let hasGrammaticalFunction =
        Prefixed_Name(uby, "hasGrammaticalFunction") |> PrefixedName

    /// <summary>
    ///   <para>uby:hasPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#hasPosition">http://purl.org/olia/ubyCat.owl#hasPosition</seealso>
    let hasPosition = Prefixed_Name(uby, "hasPosition") |> PrefixedName
    /// <summary>
    ///   <para>uby:hasQuantification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"In UBY-LMF, quantification is an attribute of the class SemanticLabel. It can be used, if the value of the semantic label is annotated with a score, e.g. type=sentiment, label=positive, quantification=strong.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"quantification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#hasQuantification">http://purl.org/olia/ubyCat.owl#hasQuantification</seealso>
    let hasQuantification = Prefixed_Name(uby, "hasQuantification") |> PrefixedName
    /// <summary>
    ///   <para>uby:hasRelType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"relType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#hasRelType">http://purl.org/olia/ubyCat.owl#hasRelType</seealso>
    let hasRelType = Prefixed_Name(uby, "hasRelType") |> PrefixedName
    /// <summary>
    ///   <para>uby:hasSenseAxisType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#hasSenseAxisType">http://purl.org/olia/ubyCat.owl#hasSenseAxisType</seealso>
    let hasSenseAxisType = Prefixed_Name(uby, "hasSenseAxisType") |> PrefixedName

    /// <summary>
    ///   <para>uby:hasSyntacticCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"syntacticCategory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#hasSyntacticCategory">http://purl.org/olia/ubyCat.owl#hasSyntacticCategory</seealso>
    let hasSyntacticCategory =
        Prefixed_Name(uby, "hasSyntacticCategory") |> PrefixedName

    /// <summary>
    ///   <para>uby:hasSyntacticProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"syntacticProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#hasSyntacticProperty">http://purl.org/olia/ubyCat.owl#hasSyntacticProperty</seealso>
    let hasSyntacticProperty =
        Prefixed_Name(uby, "hasSyntacticProperty") |> PrefixedName

    /// <summary>
    ///   <para>uby:hasType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Type is an attribute of the UBY-LMF class SemanticLabel. It encodes the name of a SemanticLabel type, e.g.
    /// type=semanticField (from WordNet or GermaNet).
    /// The label attribute of SemanticLabel holds the corresponding value of the SemanticLabel, e.g.
    /// label=animate (for type=semanticField)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#hasType">http://purl.org/olia/ubyCat.owl#hasType</seealso>
    let hasType = Prefixed_Name(uby, "hasType") |> PrefixedName

    /// <summary>
    ///   <para>uby:hasUbyDatatypeProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This DatatypeProperty could also be named "hasSimpleLexicalFeature".
    /// The current name "hasUbyDatatypeProperty" indicates that it groups Data Properties used in UBY-LMF."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#hasUbyDatatypeProperty">http://purl.org/olia/ubyCat.owl#hasUbyDatatypeProperty</seealso>
    let hasUbyDatatypeProperty =
        Prefixed_Name(uby, "hasUbyDatatypeProperty") |> PrefixedName

    /// <summary>
    ///   <para>uby:hasUbyObjectProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This ObjectProperty could also be named "hasTypedLexicalFeature".
    /// The current name "hasUbyObjectProperty" indicates that it groups Object Properties used in UBY-LMF."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#hasUbyObjectProperty">http://purl.org/olia/ubyCat.owl#hasUbyObjectProperty</seealso>
    let hasUbyObjectProperty =
        Prefixed_Name(uby, "hasUbyObjectProperty") |> PrefixedName

    /// <summary>
    ///   <para>uby:hasVerbForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"verbForm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#hasVerbForm">http://purl.org/olia/ubyCat.owl#hasVerbForm</seealso>
    let hasVerbForm = Prefixed_Name(uby, "hasVerbForm") |> PrefixedName

    /// <summary>
    ///   <para>uby:has_WordFormAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"WordFormAttribute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#has_WordFormAttribute">http://purl.org/olia/ubyCat.owl#has_WordFormAttribute</seealso>
    let has_WordFormAttribute =
        Prefixed_Name(uby, "has_WordFormAttribute") |> PrefixedName

    /// <summary>
    ///   <para>uby:has_case</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"case"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#has_case">http://purl.org/olia/ubyCat.owl#has_case</seealso>
    let has_case = Prefixed_Name(uby, "has_case") |> PrefixedName
    /// <summary>
    ///   <para>uby:has_degree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"degree"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#has_degree">http://purl.org/olia/ubyCat.owl#has_degree</seealso>
    let has_degree = Prefixed_Name(uby, "has_degree") |> PrefixedName

    /// <summary>
    ///   <para>uby:has_grammaticalGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"grammaticalGender"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#has_grammaticalGender">http://purl.org/olia/ubyCat.owl#has_grammaticalGender</seealso>
    let has_grammaticalGender =
        Prefixed_Name(uby, "has_grammaticalGender") |> PrefixedName

    /// <summary>
    ///   <para>uby:has_grammaticalNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"grammaticalNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#has_grammaticalNumber">http://purl.org/olia/ubyCat.owl#has_grammaticalNumber</seealso>
    let has_grammaticalNumber =
        Prefixed_Name(uby, "has_grammaticalNumber") |> PrefixedName

    /// <summary>
    ///   <para>uby:has_partOfSpeech</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"partOfSpeech"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#has_partOfSpeech">http://purl.org/olia/ubyCat.owl#has_partOfSpeech</seealso>
    let has_partOfSpeech = Prefixed_Name(uby, "has_partOfSpeech") |> PrefixedName
    /// <summary>
    ///   <para>uby:has_person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#has_person">http://purl.org/olia/ubyCat.owl#has_person</seealso>
    let has_person = Prefixed_Name(uby, "has_person") |> PrefixedName
    /// <summary>
    ///   <para>uby:has_tense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"tense"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#has_tense">http://purl.org/olia/ubyCat.owl#has_tense</seealso>
    let has_tense = Prefixed_Name(uby, "has_tense") |> PrefixedName
    /// <summary>
    ///   <para>uby:has_verbFormMood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"verbFormMood"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#has_verbFormMood">http://purl.org/olia/ubyCat.owl#has_verbFormMood</seealso>
    let has_verbFormMood = Prefixed_Name(uby, "has_verbFormMood") |> PrefixedName
    /// <summary>
    ///   <para>uby:hyphenation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hyphenation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#hyphenation">http://purl.org/olia/ubyCat.owl#hyphenation</seealso>
    let hyphenation = Prefixed_Name(uby, "hyphenation") |> PrefixedName
    /// <summary>
    ///   <para>uby:idiomaticExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:ExampleType</para>
    ///
    /// labels<para>"idiomaticExpression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#idiomaticExpression">http://purl.org/olia/ubyCat.owl#idiomaticExpression</seealso>
    let idiomaticExpression = Prefixed_Name(uby, "idiomaticExpression") |> PrefixedName
    /// <summary>
    ///   <para>uby:imperative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:VerbFormMood</para>
    ///
    /// labels<para>"imperative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#imperative">http://purl.org/olia/ubyCat.owl#imperative</seealso>
    let imperative = Prefixed_Name(uby, "imperative") |> PrefixedName
    /// <summary>
    ///   <para>uby:incorporatedSemArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"incorporatedSemArg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#incorporatedSemArg">http://purl.org/olia/ubyCat.owl#incorporatedSemArg</seealso>
    let incorporatedSemArg = Prefixed_Name(uby, "incorporatedSemArg") |> PrefixedName
    /// <summary>
    ///   <para>uby:indefinite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:Determiner</para>
    ///
    /// labels<para>"indefinite"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#indefinite">http://purl.org/olia/ubyCat.owl#indefinite</seealso>
    let indefinite = Prefixed_Name(uby, "indefinite") |> PrefixedName
    /// <summary>
    ///   <para>uby:index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Index is an attribute of the UBY-LMF class Sense.
    /// It encodes a ranking of the senses according to their frequency which is provided, e.g., by WordNet."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#index">http://purl.org/olia/ubyCat.owl#index</seealso>
    let index = Prefixed_Name(uby, "index") |> PrefixedName
    /// <summary>
    ///   <para>uby:indicative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:VerbFormMood</para>
    ///
    /// labels<para>"indicative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#indicative">http://purl.org/olia/ubyCat.owl#indicative</seealso>
    let indicative = Prefixed_Name(uby, "indicative") |> PrefixedName
    /// <summary>
    ///   <para>uby:infinitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:VerbFormMood</para>
    ///
    /// labels<para>"infinitive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#infinitive">http://purl.org/olia/ubyCat.owl#infinitive</seealso>
    let infinitive = Prefixed_Name(uby, "infinitive") |> PrefixedName
    /// <summary>
    ///   <para>uby:infinitiveZu</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:VerbFormMood</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"infinitiveZu"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#infinitiveZu">http://purl.org/olia/ubyCat.owl#infinitiveZu</seealso>
    let infinitiveZu = Prefixed_Name(uby, "infinitiveZu") |> PrefixedName
    /// <summary>
    ///   <para>uby:ingForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:VerbForm</para>
    ///   <para>uby:VerbFormMood</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ingForm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#ingForm">http://purl.org/olia/ubyCat.owl#ingForm</seealso>
    let ingForm = Prefixed_Name(uby, "ingForm") |> PrefixedName

    /// <summary>
    ///   <para>uby:intensionalDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:DefinitionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"intensionalDefinition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#intensionalDefinition">http://purl.org/olia/ubyCat.owl#intensionalDefinition</seealso>
    let intensionalDefinition =
        Prefixed_Name(uby, "intensionalDefinition") |> PrefixedName

    /// <summary>
    ///   <para>uby:interjection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"interjection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#interjection">http://purl.org/olia/ubyCat.owl#interjection</seealso>
    let interjection = Prefixed_Name(uby, "interjection") |> PrefixedName
    /// <summary>
    ///   <para>uby:isBreakBefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"isBreakBefore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#isBreakBefore">http://purl.org/olia/ubyCat.owl#isBreakBefore</seealso>
    let isBreakBefore = Prefixed_Name(uby, "isBreakBefore") |> PrefixedName
    /// <summary>
    ///   <para>uby:isHead</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"isHead"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#isHead">http://purl.org/olia/ubyCat.owl#isHead</seealso>
    let isHead = Prefixed_Name(uby, "isHead") |> PrefixedName
    /// <summary>
    ///   <para>uby:isIncorporated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"isIncorporated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#isIncorporated">http://purl.org/olia/ubyCat.owl#isIncorporated</seealso>
    let isIncorporated = Prefixed_Name(uby, "isIncorporated") |> PrefixedName
    /// <summary>
    ///   <para>uby:label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Label encodes a name (short - like a tag) and is an attribute of the UBY-LMF class SemanticLabel, SemanticPredicate, "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"label"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#label">http://purl.org/olia/ubyCat.owl#label</seealso>
    let label = Prefixed_Name(uby, "label") |> PrefixedName
    /// <summary>
    ///   <para>uby:languageIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"languageIdentifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#languageIdentifier">http://purl.org/olia/ubyCat.owl#languageIdentifier</seealso>
    let languageIdentifier = Prefixed_Name(uby, "languageIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>uby:lexeme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Lexeme is an attribute of the UBY-LMF class SyntacticArgument and specifies a particular lexeme to be used in realizations of particular complements.
    /// Example (lexeme = es, ObjectComplement realized as zu-infinitive): Er schafft es, den Termin einzuhalten.
    /// * Er schafft, den Termin einzuhalten."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"lexeme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#lexeme">http://purl.org/olia/ubyCat.owl#lexeme</seealso>
    let lexeme = Prefixed_Name(uby, "lexeme") |> PrefixedName
    /// <summary>
    ///   <para>uby:lexicalized</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"lexicalized"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#lexicalized">http://purl.org/olia/ubyCat.owl#lexicalized</seealso>
    let lexicalized = Prefixed_Name(uby, "lexicalized") |> PrefixedName
    /// <summary>
    ///   <para>uby:loanWord</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:DerivationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"loanWord"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#loanWord">http://purl.org/olia/ubyCat.owl#loanWord</seealso>
    let loanWord = Prefixed_Name(uby, "loanWord") |> PrefixedName
    /// <summary>
    ///   <para>uby:masculine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:GrammaticalGender</para>
    ///
    /// labels<para>"masculine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#masculine">http://purl.org/olia/ubyCat.owl#masculine</seealso>
    let masculine = Prefixed_Name(uby, "masculine") |> PrefixedName

    /// <summary>
    ///   <para>uby:monolingualExternalRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"monolingualExternalRef"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#monolingualExternalRef">http://purl.org/olia/ubyCat.owl#monolingualExternalRef</seealso>
    let monolingualExternalRef =
        Prefixed_Name(uby, "monolingualExternalRef") |> PrefixedName

    /// <summary>
    ///   <para>uby:monolingualSenseAlignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:SenseAxisType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"monolingualSenseAlignment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#monolingualSenseAlignment">http://purl.org/olia/ubyCat.owl#monolingualSenseAlignment</seealso>
    let monolingualSenseAlignment =
        Prefixed_Name(uby, "monolingualSenseAlignment") |> PrefixedName

    /// <summary>
    ///   <para>uby:multiwordFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#multiwordFeature">http://purl.org/olia/ubyCat.owl#multiwordFeature</seealso>
    let multiwordFeature = Prefixed_Name(uby, "multiwordFeature") |> PrefixedName
    /// <summary>
    ///   <para>uby:neuter</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:GrammaticalGender</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"neuter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#neuter">http://purl.org/olia/ubyCat.owl#neuter</seealso>
    let neuter = Prefixed_Name(uby, "neuter") |> PrefixedName
    /// <summary>
    ///   <para>uby:nominative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:Case</para>
    ///
    /// labels<para>"nominative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#nominative">http://purl.org/olia/ubyCat.owl#nominative</seealso>
    let nominative = Prefixed_Name(uby, "nominative") |> PrefixedName

    /// <summary>
    ///   <para>uby:nonPredicativeAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:SyntacticProperty</para>
    ///
    /// labels<para>"nonPredicativeAdjective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#nonPredicativeAdjective">http://purl.org/olia/ubyCat.owl#nonPredicativeAdjective</seealso>
    let nonPredicativeAdjective =
        Prefixed_Name(uby, "nonPredicativeAdjective") |> PrefixedName

    /// <summary>
    ///   <para>uby:noun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"noun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#noun">http://purl.org/olia/ubyCat.owl#noun</seealso>
    let noun = Prefixed_Name(uby, "noun") |> PrefixedName
    /// <summary>
    ///   <para>uby:nounCommon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"nounCommon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#nounCommon">http://purl.org/olia/ubyCat.owl#nounCommon</seealso>
    let nounCommon = Prefixed_Name(uby, "nounCommon") |> PrefixedName
    /// <summary>
    ///   <para>uby:nounPhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:SyntacticCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"nounPhrase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#nounPhrase">http://purl.org/olia/ubyCat.owl#nounPhrase</seealso>
    let nounPhrase = Prefixed_Name(uby, "nounPhrase") |> PrefixedName
    /// <summary>
    ///   <para>uby:nounProper</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"nounProper"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#nounProper">http://purl.org/olia/ubyCat.owl#nounProper</seealso>
    let nounProper = Prefixed_Name(uby, "nounProper") |> PrefixedName

    /// <summary>
    ///   <para>uby:nounProperFamilyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"nounProperLastName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#nounProperFamilyName">http://purl.org/olia/ubyCat.owl#nounProperFamilyName</seealso>
    let nounProperFamilyName =
        Prefixed_Name(uby, "nounProperFamilyName") |> PrefixedName

    /// <summary>
    ///   <para>uby:nounProperGivenName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"nounProperFirstName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#nounProperGivenName">http://purl.org/olia/ubyCat.owl#nounProperGivenName</seealso>
    let nounProperGivenName = Prefixed_Name(uby, "nounProperGivenName") |> PrefixedName
    /// <summary>
    ///   <para>uby:numeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"numeral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#numeral">http://purl.org/olia/ubyCat.owl#numeral</seealso>
    let numeral = Prefixed_Name(uby, "numeral") |> PrefixedName
    /// <summary>
    ///   <para>uby:objectComplement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:GrammaticalFunction</para>
    ///
    /// labels<para>"objectComplement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#objectComplement">http://purl.org/olia/ubyCat.owl#objectComplement</seealso>
    let objectComplement = Prefixed_Name(uby, "objectComplement") |> PrefixedName
    /// <summary>
    ///   <para>uby:objectControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:SyntacticProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"objectControl"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#objectControl">http://purl.org/olia/ubyCat.owl#objectControl</seealso>
    let objectControl = Prefixed_Name(uby, "objectControl") |> PrefixedName
    /// <summary>
    ///   <para>uby:objectRaising</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:SyntacticProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"objectRaising"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#objectRaising">http://purl.org/olia/ubyCat.owl#objectRaising</seealso>
    let objectRaising = Prefixed_Name(uby, "objectRaising") |> PrefixedName
    /// <summary>
    ///   <para>uby:optionalArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"optional"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#optionalArgument">http://purl.org/olia/ubyCat.owl#optionalArgument</seealso>
    let optionalArgument = Prefixed_Name(uby, "optionalArgument") |> PrefixedName
    /// <summary>
    ///   <para>uby:orthographyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"orthographyName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#orthographyName">http://purl.org/olia/ubyCat.owl#orthographyName</seealso>
    let orthographyName = Prefixed_Name(uby, "orthographyName") |> PrefixedName
    /// <summary>
    ///   <para>uby:other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:ExampleType</para>
    ///
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#other">http://purl.org/olia/ubyCat.owl#other</seealso>
    let other = Prefixed_Name(uby, "other") |> PrefixedName
    /// <summary>
    ///   <para>uby:partWhole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:RelType</para>
    ///
    /// labels<para>"partWhole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#partWhole">http://purl.org/olia/ubyCat.owl#partWhole</seealso>
    let partWhole = Prefixed_Name(uby, "partWhole") |> PrefixedName
    /// <summary>
    ///   <para>uby:participle</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:VerbFormMood</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:VerbForm</para>
    ///
    /// labels<para>"participle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#participle">http://purl.org/olia/ubyCat.owl#participle</seealso>
    let participle = Prefixed_Name(uby, "participle") |> PrefixedName
    /// <summary>
    ///   <para>uby:particle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"particle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#particle">http://purl.org/olia/ubyCat.owl#particle</seealso>
    let particle = Prefixed_Name(uby, "particle") |> PrefixedName
    /// <summary>
    ///   <para>uby:particleAnswer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"particleAnswer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#particleAnswer">http://purl.org/olia/ubyCat.owl#particleAnswer</seealso>
    let particleAnswer = Prefixed_Name(uby, "particleAnswer") |> PrefixedName
    /// <summary>
    ///   <para>uby:particleComparative</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"particleComparative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#particleComparative">http://purl.org/olia/ubyCat.owl#particleComparative</seealso>
    let particleComparative = Prefixed_Name(uby, "particleComparative") |> PrefixedName
    /// <summary>
    ///   <para>uby:particleInfinitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"particleInfinitive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#particleInfinitive">http://purl.org/olia/ubyCat.owl#particleInfinitive</seealso>
    let particleInfinitive = Prefixed_Name(uby, "particleInfinitive") |> PrefixedName
    /// <summary>
    ///   <para>uby:particleNegative</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"particleNegative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#particleNegative">http://purl.org/olia/ubyCat.owl#particleNegative</seealso>
    let particleNegative = Prefixed_Name(uby, "particleNegative") |> PrefixedName
    /// <summary>
    ///   <para>uby:partitiveDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:DefinitionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"partitiveDefinition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#partitiveDefinition">http://purl.org/olia/ubyCat.owl#partitiveDefinition</seealso>
    let partitiveDefinition = Prefixed_Name(uby, "partitiveDefinition") |> PrefixedName
    /// <summary>
    ///   <para>uby:past</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:Tense</para>
    ///
    /// labels<para>"past"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#past">http://purl.org/olia/ubyCat.owl#past</seealso>
    let past = Prefixed_Name(uby, "past") |> PrefixedName
    /// <summary>
    ///   <para>uby:peripheral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:CoreType</para>
    ///
    /// labels<para>"peripheral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#peripheral">http://purl.org/olia/ubyCat.owl#peripheral</seealso>
    let peripheral = Prefixed_Name(uby, "peripheral") |> PrefixedName
    /// <summary>
    ///   <para>uby:perspectivalized</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"perspectivalized"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#perspectivalized">http://purl.org/olia/ubyCat.owl#perspectivalized</seealso>
    let perspectivalized = Prefixed_Name(uby, "perspectivalized") |> PrefixedName
    /// <summary>
    ///   <para>uby:phoneticForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"phoneticForm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#phoneticForm">http://purl.org/olia/ubyCat.owl#phoneticForm</seealso>
    let phoneticForm = Prefixed_Name(uby, "phoneticForm") |> PrefixedName
    /// <summary>
    ///   <para>uby:phraseme</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"phraseme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#phraseme">http://purl.org/olia/ubyCat.owl#phraseme</seealso>
    let phraseme = Prefixed_Name(uby, "phraseme") |> PrefixedName
    /// <summary>
    ///   <para>uby:plural</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:GrammaticalNumber</para>
    ///
    /// labels<para>"plural"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#plural">http://purl.org/olia/ubyCat.owl#plural</seealso>
    let plural = Prefixed_Name(uby, "plural") |> PrefixedName
    /// <summary>
    ///   <para>uby:positive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:Degree</para>
    ///
    /// labels<para>"positive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#positive">http://purl.org/olia/ubyCat.owl#positive</seealso>
    let positive = Prefixed_Name(uby, "positive") |> PrefixedName
    /// <summary>
    ///   <para>uby:possessive</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:Determiner</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"possessive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#possessive">http://purl.org/olia/ubyCat.owl#possessive</seealso>
    let possessive = Prefixed_Name(uby, "possessive") |> PrefixedName

    /// <summary>
    ///   <para>uby:postpositiveAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:SyntacticProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"postpositiveAdjective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#postpositiveAdjective">http://purl.org/olia/ubyCat.owl#postpositiveAdjective</seealso>
    let postpositiveAdjective =
        Prefixed_Name(uby, "postpositiveAdjective") |> PrefixedName

    /// <summary>
    ///   <para>uby:predicativeAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:SyntacticProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"predicativeAdjective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#predicativeAdjective">http://purl.org/olia/ubyCat.owl#predicativeAdjective</seealso>
    let predicativeAdjective =
        Prefixed_Name(uby, "predicativeAdjective") |> PrefixedName

    /// <summary>
    ///   <para>uby:preposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Preposition is an attribute of the UBY-LMF class SyntacticArgument and specifies the particular preposition to be used in prepositional complements that can either be realized as PP or as preposition and subordinate clause.
    /// Example: That depends on who did it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"preposition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#preposition">http://purl.org/olia/ubyCat.owl#preposition</seealso>
    let preposition = Prefixed_Name(uby, "preposition") |> PrefixedName
    /// <summary>
    ///   <para>uby:prepositionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"PrepositionType is an attribute of the UBY-LMF class SyntacticArgument and specifies the particular preposition type (e.g. locative, directional) to be used in prepositional complements.
    /// The preposition type is specified in VerbNet."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"prepositionType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#prepositionType">http://purl.org/olia/ubyCat.owl#prepositionType</seealso>
    let prepositionType = Prefixed_Name(uby, "prepositionType") |> PrefixedName

    /// <summary>
    ///   <para>uby:prepositionalComplement</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:GrammaticalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"prepositionalComplement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#prepositionalComplement">http://purl.org/olia/ubyCat.owl#prepositionalComplement</seealso>
    let prepositionalComplement =
        Prefixed_Name(uby, "prepositionalComplement") |> PrefixedName

    /// <summary>
    ///   <para>uby:prepositionalPhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:SyntacticCategory</para>
    ///
    /// labels<para>"prepositionalPhrase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#prepositionalPhrase">http://purl.org/olia/ubyCat.owl#prepositionalPhrase</seealso>
    let prepositionalPhrase = Prefixed_Name(uby, "prepositionalPhrase") |> PrefixedName
    /// <summary>
    ///   <para>uby:present</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:Tense</para>
    ///
    /// labels<para>"present"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#present">http://purl.org/olia/ubyCat.owl#present</seealso>
    let present = Prefixed_Name(uby, "present") |> PrefixedName
    /// <summary>
    ///   <para>uby:pronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"pronoun"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#pronoun">http://purl.org/olia/ubyCat.owl#pronoun</seealso>
    let pronoun = Prefixed_Name(uby, "pronoun") |> PrefixedName

    /// <summary>
    ///   <para>uby:pronounDemonstrative</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"pronounDemonstrative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#pronounDemonstrative">http://purl.org/olia/ubyCat.owl#pronounDemonstrative</seealso>
    let pronounDemonstrative =
        Prefixed_Name(uby, "pronounDemonstrative") |> PrefixedName

    /// <summary>
    ///   <para>uby:pronounIndefinite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"pronounIndefinite"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#pronounIndefinite">http://purl.org/olia/ubyCat.owl#pronounIndefinite</seealso>
    let pronounIndefinite = Prefixed_Name(uby, "pronounIndefinite") |> PrefixedName

    /// <summary>
    ///   <para>uby:pronounInterrogative</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"pronounInterrogative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#pronounInterrogative">http://purl.org/olia/ubyCat.owl#pronounInterrogative</seealso>
    let pronounInterrogative =
        Prefixed_Name(uby, "pronounInterrogative") |> PrefixedName

    /// <summary>
    ///   <para>uby:pronounPersonal</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"pronounPersonal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#pronounPersonal">http://purl.org/olia/ubyCat.owl#pronounPersonal</seealso>
    let pronounPersonal = Prefixed_Name(uby, "pronounPersonal") |> PrefixedName

    /// <summary>
    ///   <para>uby:pronounPersonalIrreflexive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"pronounPersonalIrreflexive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#pronounPersonalIrreflexive">http://purl.org/olia/ubyCat.owl#pronounPersonalIrreflexive</seealso>
    let pronounPersonalIrreflexive =
        Prefixed_Name(uby, "pronounPersonalIrreflexive") |> PrefixedName

    /// <summary>
    ///   <para>uby:pronounPersonalReflexive</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"pronounPersonalReflexive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#pronounPersonalReflexive">http://purl.org/olia/ubyCat.owl#pronounPersonalReflexive</seealso>
    let pronounPersonalReflexive =
        Prefixed_Name(uby, "pronounPersonalReflexive") |> PrefixedName

    /// <summary>
    ///   <para>uby:pronounPossessive</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"pronounPossessive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#pronounPossessive">http://purl.org/olia/ubyCat.owl#pronounPossessive</seealso>
    let pronounPossessive = Prefixed_Name(uby, "pronounPossessive") |> PrefixedName
    /// <summary>
    ///   <para>uby:pronounRelative</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"pronounRelative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#pronounRelative">http://purl.org/olia/ubyCat.owl#pronounRelative</seealso>
    let pronounRelative = Prefixed_Name(uby, "pronounRelative") |> PrefixedName
    /// <summary>
    ///   <para>uby:quantification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In UBY-LMF, quantification is an attribute of the class SemanticLabel. It can be used, if the value of the semantic label is annotated with a score, e.g. type=sentiment, label=positive, quantification=strong.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"quantification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#quantification">http://purl.org/olia/ubyCat.owl#quantification</seealso>
    let quantification = Prefixed_Name(uby, "quantification") |> PrefixedName
    /// <summary>
    ///   <para>uby:reflexive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:SyntacticCategory</para>
    ///
    /// labels<para>"reflexive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#reflexive">http://purl.org/olia/ubyCat.owl#reflexive</seealso>
    let reflexive = Prefixed_Name(uby, "reflexive") |> PrefixedName
    /// <summary>
    ///   <para>uby:second</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"second"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#second">http://purl.org/olia/ubyCat.owl#second</seealso>
    let second = Prefixed_Name(uby, "second") |> PrefixedName
    /// <summary>
    ///   <para>uby:semanticRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"semanticRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#semanticRole">http://purl.org/olia/ubyCat.owl#semanticRole</seealso>
    let semanticRole = Prefixed_Name(uby, "semanticRole") |> PrefixedName
    /// <summary>
    ///   <para>uby:sense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#sense">http://purl.org/olia/ubyCat.owl#sense</seealso>
    let sense = Prefixed_Name(uby, "sense") |> PrefixedName
    /// <summary>
    ///   <para>uby:senseInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:ExampleType</para>
    ///
    /// labels<para>"senseInstance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#senseInstance">http://purl.org/olia/ubyCat.owl#senseInstance</seealso>
    let senseInstance = Prefixed_Name(uby, "senseInstance") |> PrefixedName
    /// <summary>
    ///   <para>uby:senseRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"SenseRelation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#senseRelation">http://purl.org/olia/ubyCat.owl#senseRelation</seealso>
    let senseRelation = Prefixed_Name(uby, "senseRelation") |> PrefixedName
    /// <summary>
    ///   <para>uby:separableParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"separableParticle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#separableParticle">http://purl.org/olia/ubyCat.owl#separableParticle</seealso>
    let separableParticle = Prefixed_Name(uby, "separableParticle") |> PrefixedName
    /// <summary>
    ///   <para>uby:singular</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:GrammaticalNumber</para>
    ///
    /// labels<para>"singular"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#singular">http://purl.org/olia/ubyCat.owl#singular</seealso>
    let singular = Prefixed_Name(uby, "singular") |> PrefixedName
    /// <summary>
    ///   <para>uby:sound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"sound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#sound">http://purl.org/olia/ubyCat.owl#sound</seealso>
    let sound = Prefixed_Name(uby, "sound") |> PrefixedName
    /// <summary>
    ///   <para>uby:subcatFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:ExampleType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"subcatFrame"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#subcatFrame">http://purl.org/olia/ubyCat.owl#subcatFrame</seealso>
    let subcatFrame = Prefixed_Name(uby, "subcatFrame") |> PrefixedName
    /// <summary>
    ///   <para>uby:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:GrammaticalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#subject">http://purl.org/olia/ubyCat.owl#subject</seealso>
    let subject = Prefixed_Name(uby, "subject") |> PrefixedName
    /// <summary>
    ///   <para>uby:subjectComplement</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:GrammaticalFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"subjectComplement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#subjectComplement">http://purl.org/olia/ubyCat.owl#subjectComplement</seealso>
    let subjectComplement = Prefixed_Name(uby, "subjectComplement") |> PrefixedName
    /// <summary>
    ///   <para>uby:subjectControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:SyntacticProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"subjectControl"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#subjectControl">http://purl.org/olia/ubyCat.owl#subjectControl</seealso>
    let subjectControl = Prefixed_Name(uby, "subjectControl") |> PrefixedName
    /// <summary>
    ///   <para>uby:subjectRaising</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:SyntacticProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"subjectRaising"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#subjectRaising">http://purl.org/olia/ubyCat.owl#subjectRaising</seealso>
    let subjectRaising = Prefixed_Name(uby, "subjectRaising") |> PrefixedName
    /// <summary>
    ///   <para>uby:subjunctive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:VerbFormMood</para>
    ///
    /// labels<para>"subjunctive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#subjunctive">http://purl.org/olia/ubyCat.owl#subjunctive</seealso>
    let subjunctive = Prefixed_Name(uby, "subjunctive") |> PrefixedName
    /// <summary>
    ///   <para>uby:subordinateClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:SyntacticCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"subordinateClause"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#subordinateClause">http://purl.org/olia/ubyCat.owl#subordinateClause</seealso>
    let subordinateClause = Prefixed_Name(uby, "subordinateClause") |> PrefixedName
    /// <summary>
    ///   <para>uby:superlative</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:Degree</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"superlative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#superlative">http://purl.org/olia/ubyCat.owl#superlative</seealso>
    let superlative = Prefixed_Name(uby, "superlative") |> PrefixedName
    /// <summary>
    ///   <para>uby:supports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:DerivationType</para>
    ///
    /// labels<para>"supports"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#supports">http://purl.org/olia/ubyCat.owl#supports</seealso>
    let supports = Prefixed_Name(uby, "supports") |> PrefixedName
    /// <summary>
    ///   <para>uby:symbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"symbol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#symbol">http://purl.org/olia/ubyCat.owl#symbol</seealso>
    let symbol = Prefixed_Name(uby, "symbol") |> PrefixedName
    /// <summary>
    ///   <para>uby:syntacticUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:ExampleType</para>
    ///
    /// labels<para>"syntacticUsage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#syntacticUsage">http://purl.org/olia/ubyCat.owl#syntacticUsage</seealso>
    let syntacticUsage = Prefixed_Name(uby, "syntacticUsage") |> PrefixedName
    /// <summary>
    ///   <para>uby:taxonomic</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:RelType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"taxonomic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#taxonomic">http://purl.org/olia/ubyCat.owl#taxonomic</seealso>
    let taxonomic = Prefixed_Name(uby, "taxonomic") |> PrefixedName
    /// <summary>
    ///   <para>uby:thatType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:Complementizer</para>
    ///
    /// labels<para>"thatType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#thatType">http://purl.org/olia/ubyCat.owl#thatType</seealso>
    let thatType = Prefixed_Name(uby, "thatType") |> PrefixedName
    /// <summary>
    ///   <para>uby:third</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"third"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#third">http://purl.org/olia/ubyCat.owl#third</seealso>
    let third = Prefixed_Name(uby, "third") |> PrefixedName
    /// <summary>
    ///   <para>uby:toInfinitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:VerbForm</para>
    ///
    /// labels<para>"toInfinitive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#toInfinitive">http://purl.org/olia/ubyCat.owl#toInfinitive</seealso>
    let toInfinitive = Prefixed_Name(uby, "toInfinitive") |> PrefixedName

    /// <summary>
    ///   <para>uby:translatedDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:DefinitionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"translatedDefinition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#translatedDefinition">http://purl.org/olia/ubyCat.owl#translatedDefinition</seealso>
    let translatedDefinition =
        Prefixed_Name(uby, "translatedDefinition") |> PrefixedName

    /// <summary>
    ///   <para>uby:transliteration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"transliteration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#transliteration">http://purl.org/olia/ubyCat.owl#transliteration</seealso>
    let transliteration = Prefixed_Name(uby, "transliteration") |> PrefixedName
    /// <summary>
    ///   <para>uby:transparentMeaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"transparentMeaning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#transparentMeaning">http://purl.org/olia/ubyCat.owl#transparentMeaning</seealso>
    let transparentMeaning = Prefixed_Name(uby, "transparentMeaning") |> PrefixedName
    /// <summary>
    ///   <para>uby:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Type is an attribute of the UBY-LMF class SemanticLabel. It encodes the name of a SemanticLabel type, e.g.
    /// type=semanticField (from WordNet or GermaNet).
    /// The label attribute of SemanticLabel holds the corresponding value of the SemanticLabel, e.g.
    /// label=animate (for type=semanticField)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#type">http://purl.org/olia/ubyCat.owl#type</seealso>
    let type_ = Prefixed_Name(uby, "type") |> PrefixedName
    /// <summary>
    ///   <para>uby:usage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"usage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#usage">http://purl.org/olia/ubyCat.owl#usage</seealso>
    let usage = Prefixed_Name(uby, "usage") |> PrefixedName
    /// <summary>
    ///   <para>uby:verb</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"verb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#verb">http://purl.org/olia/ubyCat.owl#verb</seealso>
    let verb = Prefixed_Name(uby, "verb") |> PrefixedName
    /// <summary>
    ///   <para>uby:verbAuxiliary</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"verbAuxiliary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#verbAuxiliary">http://purl.org/olia/ubyCat.owl#verbAuxiliary</seealso>
    let verbAuxiliary = Prefixed_Name(uby, "verbAuxiliary") |> PrefixedName
    /// <summary>
    ///   <para>uby:verbMain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:PartOfSpeech</para>
    ///
    /// labels<para>"verbMain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#verbMain">http://purl.org/olia/ubyCat.owl#verbMain</seealso>
    let verbMain = Prefixed_Name(uby, "verbMain") |> PrefixedName
    /// <summary>
    ///   <para>uby:verbModal</para>
    /// </summary>
    /// <remarks>
    ///   <para>uby:PartOfSpeech</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"verbModal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#verbModal">http://purl.org/olia/ubyCat.owl#verbModal</seealso>
    let verbModal = Prefixed_Name(uby, "verbModal") |> PrefixedName
    /// <summary>
    ///   <para>uby:verbPhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:SyntacticCategory</para>
    ///
    /// labels<para>"verbPhrase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#verbPhrase">http://purl.org/olia/ubyCat.owl#verbPhrase</seealso>
    let verbPhrase = Prefixed_Name(uby, "verbPhrase") |> PrefixedName
    /// <summary>
    ///   <para>uby:whType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:Complementizer</para>
    ///
    /// labels<para>"whType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#whType">http://purl.org/olia/ubyCat.owl#whType</seealso>
    let whType = Prefixed_Name(uby, "whType") |> PrefixedName
    /// <summary>
    ///   <para>uby:writtenForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"writtenForm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#writtenForm">http://purl.org/olia/ubyCat.owl#writtenForm</seealso>
    let writtenForm = Prefixed_Name(uby, "writtenForm") |> PrefixedName
    /// <summary>
    ///   <para>uby:yesNoType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>uby:Complementizer</para>
    ///
    /// labels<para>"yesNoType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/olia/ubyCat.owl#yesNoType">http://purl.org/olia/ubyCat.owl#yesNoType</seealso>
    let yesNoType = Prefixed_Name(uby, "yesNoType") |> PrefixedName
