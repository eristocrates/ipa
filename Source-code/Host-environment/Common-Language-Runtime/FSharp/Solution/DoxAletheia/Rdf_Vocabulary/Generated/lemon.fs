namespace http.lemon_model.net.lemon.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lemon =
    let _namespace_iri = Namespace_Iri lemon |> NamespaceIRI
    /// <summary>
    ///   <para>lemon:Argument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A slot representing a gap that must be filled in realising a lexical entry in a given projection"</para>
    /// labels<para>"Argument"</para><para>"Аргумент"</para><para>"Actant"</para><para>"Argumento"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#Argument">http://lemon-model.net/lemon#Argument</seealso>
    let Argument = Prefixed_Name(lemon, "Argument") |> PrefixedName
    /// <summary>
    ///   <para>lemon:Component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A constituent element of a lexical entry. This may be a word in a multi-word lexical element or a constituent of a compound word"</para>
    /// labels<para>"Componente"</para><para>"Bestanddeel"</para><para>"Component"</para><para>"Komponente"</para><para>"Компонента"</para><para>"Composant"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#Component">http://lemon-model.net/lemon#Component</seealso>
    let Component = Prefixed_Name(lemon, "Component") |> PrefixedName
    /// <summary>
    ///   <para>lemon:ComponentList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A node within a list of components. This should generally be a blank node,see rdf:List"</para>
    /// </remarks>
    /// <seealso href="http://lemon-model.net/lemon#ComponentList">http://lemon-model.net/lemon#ComponentList</seealso>
    let ComponentList = Prefixed_Name(lemon, "ComponentList") |> PrefixedName
    /// <summary>
    ///   <para>lemon:Form</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A given written or spoken realisation of a lexical entry"</para>
    /// labels<para>"Form"</para><para>"Forme"</para><para>"Forma"</para><para>"Vorm"</para><para>"Форма"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#Form">http://lemon-model.net/lemon#Form</seealso>
    let Form = Prefixed_Name(lemon, "Form") |> PrefixedName
    /// <summary>
    ///   <para>lemon:Frame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A stereotypical example of the usage of a given lexical entry. The most common example of projections are subcategorization frames which describe the slots taken by the arguments of a verb."</para>
    /// labels<para>"Rahmen"</para><para>"Cadre"</para><para>"Marco"</para><para>"Raam"</para><para>"Frame"</para><para>"Рамка"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#Frame">http://lemon-model.net/lemon#Frame</seealso>
    let Frame = Prefixed_Name(lemon, "Frame") |> PrefixedName
    /// <summary>
    ///   <para>lemon:HasLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Structural element for all elements that can be tagged with a language"</para>
    /// </remarks>
    /// <seealso href="http://lemon-model.net/lemon#HasLanguage">http://lemon-model.net/lemon#HasLanguage</seealso>
    let HasLanguage = Prefixed_Name(lemon, "HasLanguage") |> PrefixedName
    /// <summary>
    ///   <para>lemon:HasPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://lemon-model.net/lemon#HasPattern">http://lemon-model.net/lemon#HasPattern</seealso>
    let HasPattern = Prefixed_Name(lemon, "HasPattern") |> PrefixedName
    /// <summary>
    ///   <para>lemon:LemonElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://lemon-model.net/lemon#LemonElement">http://lemon-model.net/lemon#LemonElement</seealso>
    let LemonElement = Prefixed_Name(lemon, "LemonElement") |> PrefixedName
    /// <summary>
    ///   <para>lemon:LexicalCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An evaluable condition on when a sense applies."</para>
    /// labels<para>"Lexikonbedingung"</para><para>"Lexikaal Voorwaarde"</para><para>"Лексическое условие"</para><para>"Lexical Condition"</para><para>"Condición léxica"</para><para>"Condition lexicale"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#LexicalCondition">http://lemon-model.net/lemon#LexicalCondition</seealso>
    let LexicalCondition = Prefixed_Name(lemon, "LexicalCondition") |> PrefixedName
    /// <summary>
    ///   <para>lemon:LexicalContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Indicates the pragmatic or discourse context in which a sense applies"</para>
    /// labels<para>"Lexical Context"</para><para>"Lexikaal Context"</para><para>"Лексический контекст"</para><para>"Contexte lexical"</para><para>"Contexto léxico"</para><para>"Lexikonkontext"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#LexicalContext">http://lemon-model.net/lemon#LexicalContext</seealso>
    let LexicalContext = Prefixed_Name(lemon, "LexicalContext") |> PrefixedName
    /// <summary>
    ///   <para>lemon:LexicalEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An entry in the lexicon. This may be any morpheme, word, compound, phrase or clause that is included in the lexicon"</para>
    /// labels<para>"Лексическая единица"</para><para>"Entrada léxica"</para><para>"Entrée lexicale"</para><para>"Lexikoneintrag"</para><para>"Lexikaal item"</para><para>"Lexical entry"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#LexicalEntry">http://lemon-model.net/lemon#LexicalEntry</seealso>
    let LexicalEntry = Prefixed_Name(lemon, "LexicalEntry") |> PrefixedName
    /// <summary>
    ///   <para>lemon:LexicalSense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents the intersection in meaning between the lexical entry and the ontology entity. This is used as the ontology entity and lexical entry may not be in one-to-one correspondence as such the existence of a sense between them states meerly that there are some cases when this lexical entry refer to the ontology entity and vica versa. Mapping elements can be used to further specify this relation"</para>
    /// labels<para>"Lexikaal zin"</para><para>"Acepción léxica"</para><para>"Lexical sense"</para><para>"Signification lexicale"</para><para>"Lexikonsinn"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#LexicalSense">http://lemon-model.net/lemon#LexicalSense</seealso>
    let LexicalSense = Prefixed_Name(lemon, "LexicalSense") |> PrefixedName
    /// <summary>
    ///   <para>lemon:LexicalTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Indicates the topic of a lexicon or a lexical entry"</para>
    /// labels<para>"Lexikonthema"</para><para>"Lexikaal Thema"</para><para>"Thème lexicale"</para><para>"Tema léxica"</para><para>"Lexical Topic"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#LexicalTopic">http://lemon-model.net/lemon#LexicalTopic</seealso>
    let LexicalTopic = Prefixed_Name(lemon, "LexicalTopic") |> PrefixedName
    /// <summary>
    ///   <para>lemon:Lexicon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The lexicon object. This object is specific to the given language and/or domain it describes"</para>
    /// labels<para>"Lexikon"</para><para>"Lexique"</para><para>"Лексикон"</para><para>"Lexicon"</para><para>"Lexicón"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#Lexicon">http://lemon-model.net/lemon#Lexicon</seealso>
    let Lexicon = Prefixed_Name(lemon, "Lexicon") |> PrefixedName
    /// <summary>
    ///   <para>lemon:MorphPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Morphologische Muster"</para><para>"Morphologisch Patroon"</para><para>"Morphological pattern"</para><para>"Patron morphologique"</para><para>"Морфологический шаблон"</para><para>"Patrón morfológico"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#MorphPattern">http://lemon-model.net/lemon#MorphPattern</seealso>
    let MorphPattern = Prefixed_Name(lemon, "MorphPattern") |> PrefixedName
    /// <summary>
    ///   <para>lemon:MorphTransform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Morphological Transform"</para><para>"Transformación morfológica"</para><para>"Morphologische Transformation"</para><para>"Transformation morphologique"</para><para>"Морфологическое преобразование"</para><para>"Morphologisch transformatie"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#MorphTransform">http://lemon-model.net/lemon#MorphTransform</seealso>
    let MorphTransform = Prefixed_Name(lemon, "MorphTransform") |> PrefixedName
    /// <summary>
    ///   <para>lemon:Node</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A node in a phrase structure or dependency parse graph"</para>
    /// labels<para>"Nœud"</para><para>"Node"</para><para>"Knoten"</para><para>"Vértice"</para><para>"Узел"</para><para>"Punt"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#Node">http://lemon-model.net/lemon#Node</seealso>
    let Node = Prefixed_Name(lemon, "Node") |> PrefixedName
    /// <summary>
    ///   <para>lemon:NodeConstituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of constituents, that is types applied to nodes in a phrase structure graph"</para>
    /// labels<para>"Constituent"</para><para>"Konstituent"</para><para>"Constituyente"</para><para>"Составляющая"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#NodeConstituent">http://lemon-model.net/lemon#NodeConstituent</seealso>
    let NodeConstituent = Prefixed_Name(lemon, "NodeConstituent") |> PrefixedName
    /// <summary>
    ///   <para>lemon:Part</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An affix is a morpheme that is attached to a word stem to form a new word.  Use this for lexical entries with only abstract forms"</para>
    /// labels<para>"Partie du mot"</para><para>"Part of word"</para><para>"Parte de la palabra"</para><para>"Wortteil"</para><para>"Deel van een woord"</para><para>"Часть слова"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#Part">http://lemon-model.net/lemon#Part</seealso>
    let Part = Prefixed_Name(lemon, "Part") |> PrefixedName
    /// <summary>
    ///   <para>lemon:Phrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A phrase in lemon is defined in the looser sense of a sequence of words, it does not have to a fully grammatical phrase"</para>
    /// labels<para>"Sintagma"</para><para>"Syntagme"</para><para>"Phrase"</para><para>"Фраза"</para><para>"Zinsdeel"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#Phrase">http://lemon-model.net/lemon#Phrase</seealso>
    let Phrase = Prefixed_Name(lemon, "Phrase") |> PrefixedName
    /// <summary>
    ///   <para>lemon:PhraseElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A terminal node in a phrase structure graph, i.e., a realisable, lexical element."</para>
    /// labels<para>"Phrase-Element"</para><para>"Elemento del sintagma"</para><para>"Zinselement"</para><para>"Phrase element"</para><para>"Elément du syntagme"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#PhraseElement">http://lemon-model.net/lemon#PhraseElement</seealso>
    let PhraseElement = Prefixed_Name(lemon, "PhraseElement") |> PrefixedName
    /// <summary>
    ///   <para>lemon:PropertyValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A value that can be used in the range of linguistic property"</para>
    /// labels<para>"Waarde van het predikaat"</para><para>"Property Value"</para><para>"Prädikatswert"</para><para>"Valeur de la propriété"</para><para>"Свойство"</para><para>"Valor de la propiedad"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#PropertyValue">http://lemon-model.net/lemon#PropertyValue</seealso>
    let PropertyValue = Prefixed_Name(lemon, "PropertyValue") |> PrefixedName
    /// <summary>
    ///   <para>lemon:Prototype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Prototype"</para><para>"Прототип"</para><para>"Prototyp"</para><para>"Prototipo"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#Prototype">http://lemon-model.net/lemon#Prototype</seealso>
    let Prototype = Prefixed_Name(lemon, "Prototype") |> PrefixedName
    /// <summary>
    ///   <para>lemon:RaisableArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://lemon-model.net/lemon#RaisableArgument">http://lemon-model.net/lemon#RaisableArgument</seealso>
    let RaisableArgument = Prefixed_Name(lemon, "RaisableArgument") |> PrefixedName
    /// <summary>
    ///   <para>lemon:SenseCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Indicates a logical condition that is used indicate when a particular term has the given meaning"</para>
    /// labels<para>"Condición"</para><para>"Условие"</para><para>"Bedingung"</para><para>"Condition"</para><para>"Voorwaarde"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#SenseCondition">http://lemon-model.net/lemon#SenseCondition</seealso>
    let SenseCondition = Prefixed_Name(lemon, "SenseCondition") |> PrefixedName
    /// <summary>
    ///   <para>lemon:SenseContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the context in which a term is to be used. The context refers not to the immediate syntactic context, but the document and register the document is used in"</para>
    /// labels<para>"Contexte"</para><para>"Контекст"</para><para>"Context"</para><para>"Contexto"</para><para>"Kontext"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#SenseContext">http://lemon-model.net/lemon#SenseContext</seealso>
    let SenseContext = Prefixed_Name(lemon, "SenseContext") |> PrefixedName
    /// <summary>
    ///   <para>lemon:SenseDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A definition of a sememe, that is the a text describing the exact meaning of the lexical entry when its sense is the given ontology reference"</para>
    /// labels<para>"Définition"</para><para>"Definition"</para><para>"Definitie"</para><para>"Определение"</para><para>"Definición"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#SenseDefinition">http://lemon-model.net/lemon#SenseDefinition</seealso>
    let SenseDefinition = Prefixed_Name(lemon, "SenseDefinition") |> PrefixedName
    /// <summary>
    ///   <para>lemon:SynRoleMarker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The indicator of a given syntactic argument, normally a preposition or other particle marker or a linguistic property such as case"</para>
    /// labels<para>"Marqueur du rôle syntaxique"</para><para>"Syntactische Rolle-Marker"</para><para>"Маркер синтаксической роли"</para><para>"Marcador de la función sintáctica"</para><para>"Syntactic role marker"</para><para>"Syntactisch rol merker"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#SynRoleMarker">http://lemon-model.net/lemon#SynRoleMarker</seealso>
    let SynRoleMarker = Prefixed_Name(lemon, "SynRoleMarker") |> PrefixedName
    /// <summary>
    ///   <para>lemon:UsageExample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"An example of the usage of a lexical entry when refering to the ontology entity given by the sememe's reference. This should in effect be an example of the form used in context. E.g., "this is a *usage example*""</para>
    /// labels<para>"Пример использования"</para><para>"Voorbeeld van het gebruik"</para><para>"Usage Example"</para><para>"Ejemplo de uso"</para><para>"Exemple d'utilisation"</para><para>"Anwendungsbeispiel"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#UsageExample">http://lemon-model.net/lemon#UsageExample</seealso>
    let UsageExample = Prefixed_Name(lemon, "UsageExample") |> PrefixedName
    /// <summary>
    ///   <para>lemon:Word</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A word is a single unit of writing or speech. In languages written in Latin, Cyrillic, Greek, Arabic scripts etc. these are assumed to be separated by white-space characters. For Chinese, Japanese, Korean this should correspond to some agreed segmentation scheme."</para>
    /// labels<para>"Woord"</para><para>"Palabra"</para><para>"Word"</para><para>"Wort"</para><para>"Слово"</para><para>"Mot"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#Word">http://lemon-model.net/lemon#Word</seealso>
    let Word = Prefixed_Name(lemon, "Word") |> PrefixedName
    /// <summary>
    ///   <para>lemon:abstractForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A representation of a lexical entry that should not be considered canonical. This is primarily from a linguistic view for non-realisable forms such as stems but may also include misspellings and other unusual forms"</para>
    /// labels<para>"Abstrakte Form"</para><para>"Abstract form"</para><para>"Abstracte vorm"</para><para>"Forma abstracta"</para><para>"Forme abstraite"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#abstractForm">http://lemon-model.net/lemon#abstractForm</seealso>
    let abstractForm = Prefixed_Name(lemon, "abstractForm") |> PrefixedName
    /// <summary>
    ///   <para>lemon:altRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The sense of a non-preferred but admissible lexicalization of a given ontology entity"</para>
    /// labels<para>"Référence alternative de"</para><para>"Alternative Referenz von"</para><para>"Alternatieve referentie van"</para><para>"Referencia alternativa de"</para><para>"Alternative reference of"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#altRef">http://lemon-model.net/lemon#altRef</seealso>
    let altRef = Prefixed_Name(lemon, "altRef") |> PrefixedName
    /// <summary>
    ///   <para>lemon:broader</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes that one sense is broader than another. From a lexical point of view  this means replacing one lexical entry with another generalizes the meaning of the phrase. From an ontological point of view this property makes not strong assertions. From a mapping point of view if the broader sense applies the narrower sense must also"</para>
    /// labels<para>"Plus large"</para><para>"Breiter"</para><para>"Broader"</para><para>"Más amplio"</para><para>"Breder"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#broader">http://lemon-model.net/lemon#broader</seealso>
    let broader = Prefixed_Name(lemon, "broader") |> PrefixedName
    /// <summary>
    ///   <para>lemon:canonicalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The canonical ("dictionary") form of the lexical entry. This can be used to indicate the "lemma" form of a lexical entry"</para>
    /// labels<para>"Forma canónica"</para><para>"Canonical form"</para><para>"Kanonische Form"</para><para>"Forme canonique"</para><para>"Canonieke vorm"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#canonicalForm">http://lemon-model.net/lemon#canonicalForm</seealso>
    let canonicalForm = Prefixed_Name(lemon, "canonicalForm") |> PrefixedName
    /// <summary>
    ///   <para>lemon:condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates an evaluable test, the is necessary for this sense to apply"</para>
    /// labels<para>"Bedingung"</para><para>"Condition"</para><para>"Condición"</para><para>"Voorwaarde"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#condition">http://lemon-model.net/lemon#condition</seealso>
    let condition = Prefixed_Name(lemon, "condition") |> PrefixedName
    /// <summary>
    ///   <para>lemon:constituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Konstituent"</para><para>"Constituent"</para><para>"Constituyente"</para><para>"Constitutif"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#constituent">http://lemon-model.net/lemon#constituent</seealso>
    let constituent = Prefixed_Name(lemon, "constituent") |> PrefixedName
    /// <summary>
    ///   <para>lemon:context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Denotes the pragmatic or discursive context of a sense mapping or a constraint on the mapping by syntactic or semantic properites"</para>
    /// labels<para>"Contexto"</para><para>"Context"</para><para>"Kontext"</para><para>"Contexte"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#context">http://lemon-model.net/lemon#context</seealso>
    let context = Prefixed_Name(lemon, "context") |> PrefixedName
    /// <summary>
    ///   <para>lemon:decomposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Denotes a component of a lexical entry"</para>
    /// labels<para>"Decompositie"</para><para>"Descomposición"</para><para>"Décomposition"</para><para>"Decomposition"</para><para>"Dekompositum"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#decomposition">http://lemon-model.net/lemon#decomposition</seealso>
    let decomposition = Prefixed_Name(lemon, "decomposition") |> PrefixedName
    /// <summary>
    ///   <para>lemon:definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates a natural language definition. Note there is a pseudo-node to allow for further description of the definition (e.g., source, creation date etc.). The value property should be used to indicate the string value of the definition."</para>
    /// labels<para>"Definition"</para><para>"Definición"</para><para>"Définition"</para><para>"Definitie"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#definition">http://lemon-model.net/lemon#definition</seealso>
    let definition = Prefixed_Name(lemon, "definition") |> PrefixedName
    /// <summary>
    ///   <para>lemon:edge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Denotes the relation between a node in a multi-word expression structure and an edge"</para>
    /// labels<para>"Arista"</para><para>"Edge"</para><para>"Lien"</para><para>"Kante"</para><para>"Lijn"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#edge">http://lemon-model.net/lemon#edge</seealso>
    let edge = Prefixed_Name(lemon, "edge") |> PrefixedName
    /// <summary>
    ///   <para>lemon:element</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Denotes the lexical entry represented by the component"</para>
    /// labels<para>"Element"</para><para>"Elément"</para><para>"Elemento"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#element">http://lemon-model.net/lemon#element</seealso>
    let element = Prefixed_Name(lemon, "element") |> PrefixedName
    /// <summary>
    ///   <para>lemon:entry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates an entry in a lexicon"</para>
    /// labels<para>"Entrée"</para><para>"Eintrag"</para><para>"Item"</para><para>"Entry"</para><para>"Entrada"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#entry">http://lemon-model.net/lemon#entry</seealso>
    let entry = Prefixed_Name(lemon, "entry") |> PrefixedName
    /// <summary>
    ///   <para>lemon:equivalent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates that two senses are equivalent. From a lexical point of view , this indicates that the lexical entries can be substituted for each other with no change in meaning. From an ontological point of view it means that the two references are not disjoint. From a mapping point of view it means if one mapping apply the other must necessarily apply"</para>
    /// labels<para>"Equivalent"</para><para>"Equivalente"</para><para>"Äquivalent"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#equivalent">http://lemon-model.net/lemon#equivalent</seealso>
    let equivalent = Prefixed_Name(lemon, "equivalent") |> PrefixedName
    /// <summary>
    ///   <para>lemon:example</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Beispiel"</para><para>"Ejemplo"</para><para>"Voorbeeld"</para><para>"Exemple"</para><para>"Example"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#example">http://lemon-model.net/lemon#example</seealso>
    let example = Prefixed_Name(lemon, "example") |> PrefixedName
    /// <summary>
    ///   <para>lemon:extrinsicArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A raisable semantic argument is not in fact the semantic argument of the current frame-sense but instead is "raised" into a frame-sense used for an argument. For example the phrase "John seemed to be happy", is interpreted as "it seemed that X" where X is "John is happy", hence the subject of "seem" is a raisable argument."</para>
    /// labels<para>"Extrinsic argument"</para><para>"Actant extrinsèque"</para><para>"Extrinsiek argument"</para><para>"Argumento extrínseco"</para><para>"Äußerliche Argument"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#extrinsicArg">http://lemon-model.net/lemon#extrinsicArg</seealso>
    let extrinsicArg = Prefixed_Name(lemon, "extrinsicArg") |> PrefixedName
    /// <summary>
    ///   <para>lemon:formVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Vorm variant"</para><para>"Variante de la forme"</para><para>"Variante de la forma"</para><para>"Form-Variante"</para><para>"Form variant"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#formVariant">http://lemon-model.net/lemon#formVariant</seealso>
    let formVariant = Prefixed_Name(lemon, "formVariant") |> PrefixedName
    /// <summary>
    ///   <para>lemon:generates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Génère"</para><para>"Genera"</para><para>"Порождает"</para><para>"Genereert"</para><para>"Erzeugt"</para><para>"Generates"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#generates">http://lemon-model.net/lemon#generates</seealso>
    let generates = Prefixed_Name(lemon, "generates") |> PrefixedName
    /// <summary>
    ///   <para>lemon:hiddenRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The sense of a non-admissible lexicalization for a ontology entity. This is used to denote incorrect or deprecated language that may be useful for information extraction but not generation"</para>
    /// labels<para>"Verborgen referentie van"</para><para>"Référence cachée de"</para><para>"Verborgene Referenz von"</para><para>"Referencia oculta de"</para><para>"Hidden reference of"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#hiddenRef">http://lemon-model.net/lemon#hiddenRef</seealso>
    let hiddenRef = Prefixed_Name(lemon, "hiddenRef") |> PrefixedName
    /// <summary>
    ///   <para>lemon:incompatible</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Says that the two senses are disjoint. From a lexical point of view, this means substituting the lexical entries must change the meaning of the phrase. From an ontological point of view, this property is implied if both references are also disjoint, but does not imply disjointness, but non-equivalence of the references. For the mapping point of view  there is not instance when both mappings are valid."</para>
    /// labels<para>"Incompatible"</para><para>"Inkompatibel"</para><para>"Onverenigbaar"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#incompatible">http://lemon-model.net/lemon#incompatible</seealso>
    let incompatible = Prefixed_Name(lemon, "incompatible") |> PrefixedName
    /// <summary>
    ///   <para>lemon:isA</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes that the single argument of a class predicate is represented in the lexicon by the given semantic argument. That is Class(?x) or ?x rdf:type Class"</para>
    /// labels<para>"Instantie van"</para><para>"Instanz von"</para><para>"Instancia de"</para><para>"Instance de"</para><para>"Instance of"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#isA">http://lemon-model.net/lemon#isA</seealso>
    let isA = Prefixed_Name(lemon, "isA") |> PrefixedName
    /// <summary>
    ///   <para>lemon:isReferenceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicate that a reference has a given sense"</para>
    /// labels<para>"Referencia de"</para><para>"Referenz von"</para><para>"Referentie van"</para><para>"Reference of"</para><para>"Référence de"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#isReferenceOf">http://lemon-model.net/lemon#isReferenceOf</seealso>
    let isReferenceOf = Prefixed_Name(lemon, "isReferenceOf") |> PrefixedName
    /// <summary>
    ///   <para>lemon:isSenseOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicate that a sense is realised by the given lexical entry"</para>
    /// labels<para>"Acepción de"</para><para>"Sense of"</para><para>"Zin van"</para><para>"Sinn von"</para><para>"Signfication de"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#isSenseOf">http://lemon-model.net/lemon#isSenseOf</seealso>
    let isSenseOf = Prefixed_Name(lemon, "isSenseOf") |> PrefixedName
    /// <summary>
    ///   <para>lemon:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The language of a given lexicon. This should be some ISO-639 string"</para>
    /// labels<para>"Taal"</para><para>"Language"</para><para>"Sprache"</para><para>"Lengua"</para><para>"Langue"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#language">http://lemon-model.net/lemon#language</seealso>
    let language = Prefixed_Name(lemon, "language") |> PrefixedName
    /// <summary>
    ///   <para>lemon:leaf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Denotes the component referred to by the lex (pre-terminal) of the phrase structure"</para>
    /// labels<para>"Blad"</para><para>"Hoja"</para><para>"Leaf"</para><para>"Blatt"</para><para>"Feuille"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#leaf">http://lemon-model.net/lemon#leaf</seealso>
    let leaf = Prefixed_Name(lemon, "leaf") |> PrefixedName
    /// <summary>
    ///   <para>lemon:lexicalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Denotes a written representation of a lexical entry"</para>
    /// labels<para>"Forma léxica"</para><para>"Lexical form"</para><para>"Forme lexicale"</para><para>"Lexikalische Form"</para><para>"Lexikaal vorm"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#lexicalForm">http://lemon-model.net/lemon#lexicalForm</seealso>
    let lexicalForm = Prefixed_Name(lemon, "lexicalForm") |> PrefixedName
    /// <summary>
    ///   <para>lemon:lexicalVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates a non-semantic relationship between two lexical entries. E.g., a term is derived from another term, such as "lexical" and "lexicalize""</para>
    /// labels<para>"Lexikaal variant"</para><para>"Variante lexicale"</para><para>"Lexical variant"</para><para>"Lexikalische Variante"</para><para>"Variante léxica"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#lexicalVariant">http://lemon-model.net/lemon#lexicalVariant</seealso>
    let lexicalVariant = Prefixed_Name(lemon, "lexicalVariant") |> PrefixedName
    /// <summary>
    ///   <para>lemon:marker</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the marker of a semantic argument. This should generally either be a semantic property i.e., case or another lexical entry e.g., a preposition or particle"</para>
    /// labels<para>"маркер"</para><para>"Merker"</para><para>"Marcador"</para><para>"Marker"</para><para>"Marqueur"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#marker">http://lemon-model.net/lemon#marker</seealso>
    let marker = Prefixed_Name(lemon, "marker") |> PrefixedName
    /// <summary>
    ///   <para>lemon:narrower</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes that one sense is narrower than another. From a lexical point of view  this means replacing one lexical entry with another specializes the meaning of the phrase. From an ontological point of view this property makes not strong assertions. From a mapping point of view if the broader sense applies the narrower sense must also"</para>
    /// labels<para>"Plus restreint"</para><para>"Enger"</para><para>"Narrower"</para><para>"Más estrecho"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#narrower">http://lemon-model.net/lemon#narrower</seealso>
    let narrower = Prefixed_Name(lemon, "narrower") |> PrefixedName
    /// <summary>
    ///   <para>lemon:nextTransform</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Transformación siguiente"</para><para>"Volgende transformatie"</para><para>"Next transform"</para><para>"Folgende Transformation"</para><para>"Transformation suivante"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#nextTransform">http://lemon-model.net/lemon#nextTransform</seealso>
    let nextTransform = Prefixed_Name(lemon, "nextTransform") |> PrefixedName
    /// <summary>
    ///   <para>lemon:objOfProp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the semantic argument which represents the objects (ranges) of the property referred to by this sense"</para>
    /// labels<para>"Objekt von Prädikat"</para><para>"Complément de la propiété"</para><para>"Object van predikaat"</para><para>"Object of property"</para><para>"Complemento de la propiedad"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#objOfProp">http://lemon-model.net/lemon#objOfProp</seealso>
    let objOfProp = Prefixed_Name(lemon, "objOfProp") |> PrefixedName
    /// <summary>
    ///   <para>lemon:optional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Denotes that the syntactic argument is optional (may be omitted)"</para>
    /// labels<para>"Optionele"</para><para>"Optionnel"</para><para>"Optional"</para><para>"Opcional"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#optional">http://lemon-model.net/lemon#optional</seealso>
    let optional = Prefixed_Name(lemon, "optional") |> PrefixedName
    /// <summary>
    ///   <para>lemon:otherForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A non-preferred ("non-dictionary") representation of a lexical entry. This should be variant that is either a morphological variant, an abbreviation, short form or acronym"</para>
    /// labels<para>"Autre forme"</para><para>"Otra forma"</para><para>"Andere Form"</para><para>"Andere vorm"</para><para>"Other form"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#otherForm">http://lemon-model.net/lemon#otherForm</seealso>
    let otherForm = Prefixed_Name(lemon, "otherForm") |> PrefixedName
    /// <summary>
    ///   <para>lemon:pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Patroon"</para><para>"Patrón"</para><para>"Шаблон"</para><para>"Muster"</para><para>"Patron"</para><para>"Pattern"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#pattern">http://lemon-model.net/lemon#pattern</seealso>
    let pattern = Prefixed_Name(lemon, "pattern") |> PrefixedName
    /// <summary>
    ///   <para>lemon:phraseRoot</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the head node of a phrase structure or dependency parse graph"</para>
    /// labels<para>"Zinsdeel wortel"</para><para>"Base de la syntagme"</para><para>"Raíz del sintagma"</para><para>"Phrasewurzel"</para><para>"Phrase root"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#phraseRoot">http://lemon-model.net/lemon#phraseRoot</seealso>
    let phraseRoot = Prefixed_Name(lemon, "phraseRoot") |> PrefixedName
    /// <summary>
    ///   <para>lemon:prefRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The sense of the preferred lexicalization of a given ontology entity"</para>
    /// labels<para>"Referencia preferida de"</para><para>"Référence préféré de"</para><para>"Voorkeursreferentie van"</para><para>"Preferred reference of"</para><para>"Bevorzugte Referenz von"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#prefRef">http://lemon-model.net/lemon#prefRef</seealso>
    let prefRef = Prefixed_Name(lemon, "prefRef") |> PrefixedName
    /// <summary>
    ///   <para>lemon:property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Denotes a lexical property of a lexical entry, form, component or MWE node. For the lexical entry this is assumed to be static properties e.g., part of speech and gender and for the others this is assumed to be specific properties e.g., case, number"</para>
    /// labels<para>"Lexikalische Prädikat"</para><para>"Lexikaal predikaat"</para><para>"Propiedad léxica"</para><para>"Lexical property"</para><para>"Propiété lexicale"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#property">http://lemon-model.net/lemon#property</seealso>
    let property = Prefixed_Name(lemon, "property") |> PrefixedName
    /// <summary>
    ///   <para>lemon:propertyDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates a restrictions on the domain of the property. That is, this sense only applies if the property the sense refers to has a subject in the class referred to by this property"</para>
    /// labels<para>"Domein van het predikaat"</para><para>"Property domain"</para><para>"Dominio de la propiedad"</para><para>"Ensemble de la propiété"</para><para>"Prädikatsbereich"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#propertyDomain">http://lemon-model.net/lemon#propertyDomain</seealso>
    let propertyDomain = Prefixed_Name(lemon, "propertyDomain") |> PrefixedName
    /// <summary>
    ///   <para>lemon:propertyRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates a restrictions on the range of the property. That is, this sense only applies if the property the sense refers to has a object in the class referred to by this property"</para>
    /// labels<para>"Bereik van het predikaat"</para><para>"Prädikatszielmenge"</para><para>"Property range"</para><para>"Rango de la propiedad"</para><para>"Image de la propiété"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#propertyRange">http://lemon-model.net/lemon#propertyRange</seealso>
    let propertyRange = Prefixed_Name(lemon, "propertyRange") |> PrefixedName
    /// <summary>
    ///   <para>lemon:reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A reference to an external resource"</para>
    /// labels<para>"Referenz"</para><para>"Reference"</para><para>"Referencia"</para><para>"Référence"</para><para>"Referentie"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#reference">http://lemon-model.net/lemon#reference</seealso>
    let reference = Prefixed_Name(lemon, "reference") |> PrefixedName
    /// <summary>
    ///   <para>lemon:representation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A realisation of a given form"</para>
    /// labels<para>"Representación"</para><para>"Representation"</para><para>"Voorstelling"</para><para>"Darstellung"</para><para>"Représentation"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#representation">http://lemon-model.net/lemon#representation</seealso>
    let representation = Prefixed_Name(lemon, "representation") |> PrefixedName
    /// <summary>
    ///   <para>lemon:rule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Rule"</para><para>"Regla"</para><para>"Regel"</para><para>"Règle"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#rule">http://lemon-model.net/lemon#rule</seealso>
    let rule = Prefixed_Name(lemon, "rule") |> PrefixedName
    /// <summary>
    ///   <para>lemon:semArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Denotes a semantic argument slot of a semantic unit"</para>
    /// labels<para>"Semantic argument"</para><para>"Semantische Argument"</para><para>"Actant sémantique"</para><para>"Semantisch argument"</para><para>"Argumento semántico"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#semArg">http://lemon-model.net/lemon#semArg</seealso>
    let semArg = Prefixed_Name(lemon, "semArg") |> PrefixedName
    /// <summary>
    ///   <para>lemon:sense</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the sense of a lexical entry"</para>
    /// labels<para>"Signification"</para><para>"Zin"</para><para>"Sinn"</para><para>"Acepción"</para><para>"Sense"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#sense">http://lemon-model.net/lemon#sense</seealso>
    let sense = Prefixed_Name(lemon, "sense") |> PrefixedName
    /// <summary>
    ///   <para>lemon:senseRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Denotes a relationship between senses"</para>
    /// labels<para>"Sinn-Relation"</para><para>"Relación de Acepción"</para><para>"Zin relatie"</para><para>"Sense relation"</para><para>"Relation de Signification"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#senseRelation">http://lemon-model.net/lemon#senseRelation</seealso>
    let senseRelation = Prefixed_Name(lemon, "senseRelation") |> PrefixedName
    /// <summary>
    ///   <para>lemon:separator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the graphical element used to seperate the subnodes of this phrase structure. It is generally recommended that you use a string value with the language tag used to indicate script, (i.e., using ISO-15924 codes, such as "Latn"), as orthographic features may change with script."</para>
    /// labels<para>"Separator"</para><para>"Séparateur"</para><para>"Separador"</para><para>"Afscheider"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#separator">http://lemon-model.net/lemon#separator</seealso>
    let separator = Prefixed_Name(lemon, "separator") |> PrefixedName
    /// <summary>
    ///   <para>lemon:subjOfProp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates the semantic argument which represents the subjects (domain) of the property referred to by this sense"</para>
    /// labels<para>"Sujet de la propiété"</para><para>"Onderwerp van predikaat"</para><para>"Subjekt von Prädikat"</para><para>"Subject of property"</para><para>"Sujeto de la propiedad"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#subjOfProp">http://lemon-model.net/lemon#subjOfProp</seealso>
    let subjOfProp = Prefixed_Name(lemon, "subjOfProp") |> PrefixedName
    /// <summary>
    ///   <para>lemon:subsense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates that the relation between a compound sense and its atomic subsenses"</para>
    /// labels<para>"Parte del acepción"</para><para>"Teil des Sinnes"</para><para>"Deel van de zin"</para><para>"Subsense"</para><para>"Signification composante"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#subsense">http://lemon-model.net/lemon#subsense</seealso>
    let subsense = Prefixed_Name(lemon, "subsense") |> PrefixedName
    /// <summary>
    ///   <para>lemon:synArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates a slot in a syntactic frame"</para>
    /// labels<para>"Syntactic argument"</para><para>"Syntactisch argument"</para><para>"Actant syntaxique"</para><para>"Syntactische Argument"</para><para>"Argumento sintáctico"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#synArg">http://lemon-model.net/lemon#synArg</seealso>
    let synArg = Prefixed_Name(lemon, "synArg") |> PrefixedName
    /// <summary>
    ///   <para>lemon:synBehavior</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates a syntactic behavior of a lexical entry"</para>
    /// labels<para>"Syntactische Verhalten"</para><para>"Funcionamiento sintáctico"</para><para>"Conduite syntaxique"</para><para>"Syntactic behavior"</para><para>"Syntactisch optreden"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#synBehavior">http://lemon-model.net/lemon#synBehavior</seealso>
    let synBehavior = Prefixed_Name(lemon, "synBehavior") |> PrefixedName
    /// <summary>
    ///   <para>lemon:topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Indicates the topic of the overrall lexicon, this is property is sometimes called "subject field". Note that in addition to the topic of a lexicon each lexical entry may belong to a given domain, this can be modelled as equal or not equal to the topic of the associated lexicon"</para>
    /// labels<para>"Thema"</para><para>"Topic"</para><para>"Thème"</para><para>"Tema"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#topic">http://lemon-model.net/lemon#topic</seealso>
    let topic = Prefixed_Name(lemon, "topic") |> PrefixedName
    /// <summary>
    ///   <para>lemon:transform</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Transformation"</para><para>"Transformatie"</para><para>"Transformación"</para><para>"Transform"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#transform">http://lemon-model.net/lemon#transform</seealso>
    let transform = Prefixed_Name(lemon, "transform") |> PrefixedName
    /// <summary>
    ///   <para>lemon:tree</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Boom"</para><para>"Tree"</para><para>"Baum"</para><para>"Árbol"</para><para>"Arbre"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#tree">http://lemon-model.net/lemon#tree</seealso>
    let tree = Prefixed_Name(lemon, "tree") |> PrefixedName
    /// <summary>
    ///   <para>lemon:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"This indicates the value of a pseudo-data node. An example of this is definition where the value would generally be a string but it would not be possible to add further annotations, such as source or creation date."</para>
    /// labels<para>"Waarde"</para><para>"Wert"</para><para>"Value"</para><para>"Valeur"</para><para>"Valor"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#value">http://lemon-model.net/lemon#value</seealso>
    let value = Prefixed_Name(lemon, "value") |> PrefixedName
    /// <summary>
    ///   <para>lemon:writtenRep</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Gives the written representation of a given form"</para>
    /// labels<para>"Représentation écrite"</para><para>"Schriftelijke voorstelling"</para><para>"Written representation"</para><para>"Representación escrita"</para><para>"Schriftliche Darstellung"</para></remarks>
    /// <seealso href="http://lemon-model.net/lemon#writtenRep">http://lemon-model.net/lemon#writtenRep</seealso>
    let writtenRep = Prefixed_Name(lemon, "writtenRep") |> PrefixedName
