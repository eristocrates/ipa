#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lemon =
    let _prefixId = PrefixId.fromNamespaceLabel "http://lemon-model.net/lemon#" "lemon"
    /// <summary>
    ///   <para>rdfs:label : Argumentrdfs:label : Argumentrdfs:label : Argumentrdfs:label : Аргументrdfs:label : Argumentordfs:label : Actant</para>
    ///   <para>rdfs:comment : A slot representing a gap that must be filled in realising a lexical entry in a given projection</para>
    ///   <a href="http://lemon-model.net/lemon#Argument">lemon:Argument</a>
    /// </summary>
    let Argument = _prefixId.prefix "Argument"
    /// <summary>
    ///   <para>rdfs:label : Компонентаrdfs:label : Composantrdfs:label : Bestanddeelrdfs:label : Komponenterdfs:label : Componentrdfs:label : Componente</para>
    ///   <para>rdfs:comment : A constituent element of a lexical entry. This may be a word in a multi-word lexical element or a constituent of a compound word</para>
    ///   <a href="http://lemon-model.net/lemon#Component">lemon:Component</a>
    /// </summary>
    let Component = _prefixId.prefix "Component"
    /// <summary>
    ///   <para>rdfs:comment : A node within a list of components. This should generally be a blank node,see rdf:List</para>
    ///   <a href="http://lemon-model.net/lemon#ComponentList">lemon:ComponentList</a>
    /// </summary>
    let ComponentList = _prefixId.prefix "ComponentList"
    /// <summary>
    ///   <para>rdfs:label : Formardfs:label : Формаrdfs:label : Vormrdfs:label : Formerdfs:label : Formrdfs:label : Form</para>
    ///   <para>rdfs:comment : A given written or spoken realisation of a lexical entry</para>
    ///   <a href="http://lemon-model.net/lemon#Form">lemon:Form</a>
    /// </summary>
    let Form = _prefixId.prefix "Form"
    /// <summary>
    ///   <para>rdfs:label : Marcordfs:label : Framerdfs:label : Rahmenrdfs:label : Cadrerdfs:label : Raamrdfs:label : Рамка</para>
    ///   <para>rdfs:comment : A stereotypical example of the usage of a given lexical entry. The most common example of projections are subcategorization frames which describe the slots taken by the arguments of a verb.</para>
    ///   <a href="http://lemon-model.net/lemon#Frame">lemon:Frame</a>
    /// </summary>
    let Frame = _prefixId.prefix "Frame"
    /// <summary>
    ///   <para>rdfs:comment : Structural element for all elements that can be tagged with a language</para>
    ///   <a href="http://lemon-model.net/lemon#HasLanguage">lemon:HasLanguage</a>
    /// </summary>
    let HasLanguage = _prefixId.prefix "HasLanguage"
    let HasPattern = _prefixId.prefix "HasPattern"
    let LemonElement = _prefixId.prefix "LemonElement"
    /// <summary>
    ///   <para>rdfs:label : Лексическое условиеrdfs:label : Lexikonbedingungrdfs:label : Lexical Conditionrdfs:label : Lexikaal Voorwaarderdfs:label : Condición léxicardfs:label : Condition lexicale</para>
    ///   <para>rdfs:comment : An evaluable condition on when a sense applies.</para>
    ///   <a href="http://lemon-model.net/lemon#LexicalCondition">lemon:LexicalCondition</a>
    /// </summary>
    let LexicalCondition = _prefixId.prefix "LexicalCondition"
    /// <summary>
    ///   <para>rdfs:label : Lexikaal Contextrdfs:label : Contexto léxicordfs:label : Contexte lexicalrdfs:label : Lexikonkontextrdfs:label : Лексический контекстrdfs:label : Lexical Context</para>
    ///   <para>rdfs:comment : Indicates the pragmatic or discourse context in which a sense applies</para>
    ///   <a href="http://lemon-model.net/lemon#LexicalContext">lemon:LexicalContext</a>
    /// </summary>
    let LexicalContext = _prefixId.prefix "LexicalContext"
    /// <summary>
    ///   <para>rdfs:label : Entrée lexicalerdfs:label : Лексическая единицаrdfs:label : Lexikoneintragrdfs:label : Lexical entryrdfs:label : Entrada léxicardfs:label : Lexikaal item</para>
    ///   <para>rdfs:comment : An entry in the lexicon. This may be any morpheme, word, compound, phrase or clause that is included in the lexicon</para>
    ///   <a href="http://lemon-model.net/lemon#LexicalEntry">lemon:LexicalEntry</a>
    /// </summary>
    let LexicalEntry = _prefixId.prefix "LexicalEntry"
    /// <summary>
    ///   <para>rdfs:label : Lexical senserdfs:label : Lexikaal zinrdfs:label : Lexikonsinnrdfs:label : Acepción léxicardfs:label : Signification lexicale</para>
    ///   <para>rdfs:comment : Represents the intersection in meaning between the lexical entry and the ontology entity. This is used as the ontology entity and lexical entry may not be in one-to-one correspondence as such the existence of a sense between them states meerly that there are some cases when this lexical entry refer to the ontology entity and vica versa. Mapping elements can be used to further specify this relation</para>
    ///   <a href="http://lemon-model.net/lemon#LexicalSense">lemon:LexicalSense</a>
    /// </summary>
    let LexicalSense = _prefixId.prefix "LexicalSense"
    /// <summary>
    ///   <para>rdfs:label : Thème lexicalerdfs:label : Tema léxicardfs:label : Lexikonthemardfs:label : Lexikaal Themardfs:label : Lexical Topic</para>
    ///   <para>rdfs:comment : Indicates the topic of a lexicon or a lexical entry</para>
    ///   <a href="http://lemon-model.net/lemon#LexicalTopic">lemon:LexicalTopic</a>
    /// </summary>
    let LexicalTopic = _prefixId.prefix "LexicalTopic"
    /// <summary>
    ///   <para>rdfs:label : Lexikonrdfs:label : Лексиконrdfs:label : Lexiquerdfs:label : Lexicónrdfs:label : Lexiconrdfs:label : Lexicon</para>
    ///   <para>rdfs:comment : The lexicon object. This object is specific to the given language and/or domain it describes</para>
    ///   <a href="http://lemon-model.net/lemon#Lexicon">lemon:Lexicon</a>
    /// </summary>
    let Lexicon = _prefixId.prefix "Lexicon"
    /// <summary>
    ///   <para>rdfs:label : Морфологический шаблонrdfs:label : Morphological patternrdfs:label : Patrón morfológicordfs:label : Morphologisch Patroonrdfs:label : Morphologische Musterrdfs:label : Patron morphologique</para>
    ///   <a href="http://lemon-model.net/lemon#MorphPattern">lemon:MorphPattern</a>
    /// </summary>
    let MorphPattern = _prefixId.prefix "MorphPattern"
    /// <summary>
    ///   <para>rdfs:label : Морфологическое преобразованиеrdfs:label : Transformation morphologiquerdfs:label : Transformación morfológicardfs:label : Morphologische Transformationrdfs:label : Morphologisch transformatierdfs:label : Morphological Transform</para>
    ///   <a href="http://lemon-model.net/lemon#MorphTransform">lemon:MorphTransform</a>
    /// </summary>
    let MorphTransform = _prefixId.prefix "MorphTransform"
    /// <summary>
    ///   <para>rdfs:label : Noderdfs:label : Puntrdfs:label : Knotenrdfs:label : Vérticerdfs:label : Узелrdfs:label : Nœud</para>
    ///   <para>rdfs:comment : A node in a phrase structure or dependency parse graph</para>
    ///   <a href="http://lemon-model.net/lemon#Node">lemon:Node</a>
    /// </summary>
    let Node = _prefixId.prefix "Node"
    /// <summary>
    ///   <para>rdfs:label : Constituyenterdfs:label : Constituentrdfs:label : Constituentrdfs:label : Constituentrdfs:label : Составляющаяrdfs:label : Konstituent</para>
    ///   <para>rdfs:comment : The class of constituents, that is types applied to nodes in a phrase structure graph</para>
    ///   <a href="http://lemon-model.net/lemon#NodeConstituent">lemon:NodeConstituent</a>
    /// </summary>
    let NodeConstituent = _prefixId.prefix "NodeConstituent"
    /// <summary>
    ///   <para>rdfs:label : Deel van een woordrdfs:label : Часть словаrdfs:label : Part of wordrdfs:label : Partie du motrdfs:label : Parte de la palabrardfs:label : Wortteil</para>
    ///   <para>rdfs:comment : An affix is a morpheme that is attached to a word stem to form a new word.  Use this for lexical entries with only abstract forms</para>
    ///   <a href="http://lemon-model.net/lemon#Part">lemon:Part</a>
    /// </summary>
    let Part = _prefixId.prefix "Part"
    /// <summary>
    ///   <para>rdfs:label : Sintagmardfs:label : Фразаrdfs:label : Phraserdfs:label : Phraserdfs:label : Zinsdeelrdfs:label : Syntagme</para>
    ///   <para>rdfs:comment : A phrase in lemon is defined in the looser sense of a sequence of words, it does not have to a fully grammatical phrase</para>
    ///   <a href="http://lemon-model.net/lemon#Phrase">lemon:Phrase</a>
    /// </summary>
    let Phrase = _prefixId.prefix "Phrase"
    /// <summary>
    ///   <para>rdfs:label : Zinselementrdfs:label : Phrase-Elementrdfs:label : Phrase elementrdfs:label : Elément du syntagmerdfs:label : Elemento del sintagma</para>
    ///   <para>rdfs:comment : A terminal node in a phrase structure graph, i.e., a realisable, lexical element.</para>
    ///   <a href="http://lemon-model.net/lemon#PhraseElement">lemon:PhraseElement</a>
    /// </summary>
    let PhraseElement = _prefixId.prefix "PhraseElement"
    /// <summary>
    ///   <para>rdfs:label : Property Valuerdfs:label : Waarde van het predikaatrdfs:label : Valor de la propiedadrdfs:label : Prädikatswertrdfs:label : Valeur de la propriétérdfs:label : Свойство</para>
    ///   <para>rdfs:comment : A value that can be used in the range of linguistic property</para>
    ///   <a href="http://lemon-model.net/lemon#PropertyValue">lemon:PropertyValue</a>
    /// </summary>
    let PropertyValue = _prefixId.prefix "PropertyValue"
    /// <summary>
    ///   <para>rdfs:label : Прототипrdfs:label : Prototyperdfs:label : Prototyperdfs:label : Prototyperdfs:label : Prototyprdfs:label : Prototipo</para>
    ///   <a href="http://lemon-model.net/lemon#Prototype">lemon:Prototype</a>
    /// </summary>
    let Prototype = _prefixId.prefix "Prototype"
    /// <summary>
    ///   <para>rdfs:label : Bedingungrdfs:label : Voorwaarderdfs:label : Условиеrdfs:label : Conditionrdfs:label : Conditionrdfs:label : Condición</para>
    ///   <para>rdfs:comment : Indicates a logical condition that is used indicate when a particular term has the given meaning</para>
    ///   <a href="http://lemon-model.net/lemon#SenseCondition">lemon:SenseCondition</a>
    /// </summary>
    let SenseCondition = _prefixId.prefix "SenseCondition"
    /// <summary>
    ///   <para>rdfs:label : Contextrdfs:label : Contextrdfs:label : Контекстrdfs:label : Contexterdfs:label : Kontextrdfs:label : Contexto</para>
    ///   <para>rdfs:comment : Indicates the context in which a term is to be used. The context refers not to the immediate syntactic context, but the document and register the document is used in</para>
    ///   <a href="http://lemon-model.net/lemon#SenseContext">lemon:SenseContext</a>
    /// </summary>
    let SenseContext = _prefixId.prefix "SenseContext"
    /// <summary>
    ///   <para>rdfs:label : Definitionrdfs:label : Definitionrdfs:label : Definitierdfs:label : Définitionrdfs:label : Definiciónrdfs:label : Определение</para>
    ///   <para>rdfs:comment : A definition of a sememe, that is the a text describing the exact meaning of the lexical entry when its sense is the given ontology reference</para>
    ///   <a href="http://lemon-model.net/lemon#SenseDefinition">lemon:SenseDefinition</a>
    /// </summary>
    let SenseDefinition = _prefixId.prefix "SenseDefinition"
    /// <summary>
    ///   <para>rdfs:label : Маркер синтаксической ролиrdfs:label : Syntactische Rolle-Markerrdfs:label : Marqueur du rôle syntaxiquerdfs:label : Syntactic role markerrdfs:label : Marcador de la función sintácticardfs:label : Syntactisch rol merker</para>
    ///   <para>rdfs:comment : The indicator of a given syntactic argument, normally a preposition or other particle marker or a linguistic property such as case</para>
    ///   <a href="http://lemon-model.net/lemon#SynRoleMarker">lemon:SynRoleMarker</a>
    /// </summary>
    let SynRoleMarker = _prefixId.prefix "SynRoleMarker"
    /// <summary>
    ///   <para>rdfs:label : Voorbeeld van het gebruikrdfs:label : Пример использованияrdfs:label : Usage Examplerdfs:label : Exemple d'utilisationrdfs:label : Ejemplo de usordfs:label : Anwendungsbeispiel</para>
    ///   <para>rdfs:comment : An example of the usage of a lexical entry when refering to the ontology entity given by the sememe's reference. This should in effect be an example of the form used in context. E.g., "this is a *usage example*"</para>
    ///   <a href="http://lemon-model.net/lemon#UsageExample">lemon:UsageExample</a>
    /// </summary>
    let UsageExample = _prefixId.prefix "UsageExample"
    /// <summary>
    ///   <para>rdfs:label : Motrdfs:label : Palabrardfs:label : Wortrdfs:label : Woordrdfs:label : Словоrdfs:label : Word</para>
    ///   <para>rdfs:comment : A word is a single unit of writing or speech. In languages written in Latin, Cyrillic, Greek, Arabic scripts etc. these are assumed to be separated by white-space characters. For Chinese, Japanese, Korean this should correspond to some agreed segmentation scheme.</para>
    ///   <a href="http://lemon-model.net/lemon#Word">lemon:Word</a>
    /// </summary>
    let Word = _prefixId.prefix "Word"
    /// <summary>
    ///   <para>rdfs:comment : A representation of a lexical entry that should not be considered canonical. This is primarily from a linguistic view for non-realisable forms such as stems but may also include misspellings and other unusual forms</para>
    ///   <para>rdfs:label : Forma abstractardfs:label : Forme abstraiterdfs:label : Abstract formrdfs:label : Abstracte vormrdfs:label : Abstrakte Form</para>
    ///   <a href="http://lemon-model.net/lemon#abstractForm">lemon:abstractForm</a>
    /// </summary>
    let abstractForm = _prefixId.prefix "abstractForm"
    /// <summary>
    ///   <para>rdfs:label : Alternatieve referentie vanrdfs:label : Alternative reference ofrdfs:label : Référence alternative derdfs:label : Alternative Referenz vonrdfs:label : Referencia alternativa de</para>
    ///   <para>rdfs:comment : The sense of a non-preferred but admissible lexicalization of a given ontology entity</para>
    ///   <a href="http://lemon-model.net/lemon#altRef">lemon:altRef</a>
    /// </summary>
    let altRef = _prefixId.prefix "altRef"
    /// <summary>
    ///   <para>rdfs:label : Plus largerdfs:label : Más ampliordfs:label : Breiterrdfs:label : Brederrdfs:label : Broader</para>
    ///   <para>rdfs:comment : Denotes that one sense is broader than another. From a lexical point of view  this means replacing one lexical entry with another generalizes the meaning of the phrase. From an ontological point of view this property makes not strong assertions. From a mapping point of view if the broader sense applies the narrower sense must also</para>
    ///   <a href="http://lemon-model.net/lemon#broader">lemon:broader</a>
    /// </summary>
    let broader = _prefixId.prefix "broader"
    /// <summary>
    ///   <para>rdfs:label : Canonical formrdfs:label : Kanonische Formrdfs:label : Canonieke vormrdfs:label : Forma canónicardfs:label : Forme canonique</para>
    ///   <para>rdfs:comment : The canonical ("dictionary") form of the lexical entry. This can be used to indicate the "lemma" form of a lexical entry</para>
    ///   <a href="http://lemon-model.net/lemon#canonicalForm">lemon:canonicalForm</a>
    /// </summary>
    let canonicalForm = _prefixId.prefix "canonicalForm"
    /// <summary>
    ///   <para>rdfs:comment : Indicates an evaluable test, the is necessary for this sense to apply</para>
    ///   <para>rdfs:label : Voorwaarderdfs:label : Condiciónrdfs:label : Bedingungrdfs:label : Conditionrdfs:label : Condition</para>
    ///   <a href="http://lemon-model.net/lemon#condition">lemon:condition</a>
    /// </summary>
    let condition = _prefixId.prefix "condition"
    /// <summary>
    ///   <para>rdfs:label : Constituyenterdfs:label : Constitutifrdfs:label : Constituentrdfs:label : Constituentrdfs:label : Konstituent</para>
    ///   <a href="http://lemon-model.net/lemon#constituent">lemon:constituent</a>
    /// </summary>
    let constituent = _prefixId.prefix "constituent"
    /// <summary>
    ///   <para>rdfs:label : Contextrdfs:label : Contextrdfs:label : Contextordfs:label : Contexterdfs:label : Kontext</para>
    ///   <para>rdfs:comment : Denotes the pragmatic or discursive context of a sense mapping or a constraint on the mapping by syntactic or semantic properites</para>
    ///   <a href="http://lemon-model.net/lemon#context">lemon:context</a>
    /// </summary>
    let context = _prefixId.prefix "context"
    /// <summary>
    ///   <para>rdfs:label : Dekompositumrdfs:label : Décompositionrdfs:label : Decompositionrdfs:label : Descomposiciónrdfs:label : Decompositie</para>
    ///   <para>rdfs:comment : Denotes a component of a lexical entry</para>
    ///   <a href="http://lemon-model.net/lemon#decomposition">lemon:decomposition</a>
    /// </summary>
    let decomposition = _prefixId.prefix "decomposition"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a natural language definition. Note there is a pseudo-node to allow for further description of the definition (e.g., source, creation date etc.). The value property should be used to indicate the string value of the definition.</para>
    ///   <para>rdfs:label : Definitionrdfs:label : Definitionrdfs:label : Definitierdfs:label : Definiciónrdfs:label : Définition</para>
    ///   <a href="http://lemon-model.net/lemon#definition">lemon:definition</a>
    /// </summary>
    let definition = _prefixId.prefix "definition"
    /// <summary>
    ///   <para>rdfs:label : Kanterdfs:label : Lijnrdfs:label : Lienrdfs:label : Aristardfs:label : Edge</para>
    ///   <para>rdfs:comment : Denotes the relation between a node in a multi-word expression structure and an edge</para>
    ///   <a href="http://lemon-model.net/lemon#edge">lemon:edge</a>
    /// </summary>
    let edge = _prefixId.prefix "edge"
    /// <summary>
    ///   <para>rdfs:label : Elémentrdfs:label : Elementordfs:label : Elementrdfs:label : Elementrdfs:label : Element</para>
    ///   <para>rdfs:comment : Denotes the lexical entry represented by the component</para>
    ///   <a href="http://lemon-model.net/lemon#element">lemon:element</a>
    /// </summary>
    let element = _prefixId.prefix "element"
    /// <summary>
    ///   <para>rdfs:comment : Indicates an entry in a lexicon</para>
    ///   <para>rdfs:label : Eintragrdfs:label : Entryrdfs:label : Entradardfs:label : Entréerdfs:label : Item</para>
    ///   <a href="http://lemon-model.net/lemon#entry">lemon:entry</a>
    /// </summary>
    let entry = _prefixId.prefix "entry"
    /// <summary>
    ///   <para>rdfs:label : Equivalenterdfs:label : Äquivalentrdfs:label : Equivalentrdfs:label : Equivalentrdfs:label : Equivalent</para>
    ///   <para>rdfs:comment : Indicates that two senses are equivalent. From a lexical point of view , this indicates that the lexical entries can be substituted for each other with no change in meaning. From an ontological point of view it means that the two references are not disjoint. From a mapping point of view it means if one mapping apply the other must necessarily apply</para>
    ///   <a href="http://lemon-model.net/lemon#equivalent">lemon:equivalent</a>
    /// </summary>
    let equivalent = _prefixId.prefix "equivalent"
    /// <summary>
    ///   <para>rdfs:label : Voorbeeldrdfs:label : Exemplerdfs:label : Examplerdfs:label : Ejemplordfs:label : Beispiel</para>
    ///   <a href="http://lemon-model.net/lemon#example">lemon:example</a>
    /// </summary>
    let example = _prefixId.prefix "example"
    /// <summary>
    ///   <para>rdfs:label : Äußerliche Argumentrdfs:label : Extrinsiek argumentrdfs:label : Extrinsic argumentrdfs:label : Argumento extrínsecordfs:label : Actant extrinsèque</para>
    ///   <para>rdfs:comment : A raisable semantic argument is not in fact the semantic argument of the current frame-sense but instead is "raised" into a frame-sense used for an argument. For example the phrase "John seemed to be happy", is interpreted as "it seemed that X" where X is "John is happy", hence the subject of "seem" is a raisable argument.</para>
    ///   <a href="http://lemon-model.net/lemon#extrinsicArg">lemon:extrinsicArg</a>
    /// </summary>
    let extrinsicArg = _prefixId.prefix "extrinsicArg"
    /// <summary>
    ///   <para>rdfs:label : Vorm variantrdfs:label : Variante de la formerdfs:label : Variante de la formardfs:label : Form-Varianterdfs:label : Form variant</para>
    ///   <a href="http://lemon-model.net/lemon#formVariant">lemon:formVariant</a>
    /// </summary>
    let formVariant = _prefixId.prefix "formVariant"
    /// <summary>
    ///   <para>rdfs:label : Genereertrdfs:label : Generardfs:label : Generatesrdfs:label : Порождаетrdfs:label : Erzeugtrdfs:label : Génère</para>
    ///   <a href="http://lemon-model.net/lemon#generates">lemon:generates</a>
    /// </summary>
    let generates = _prefixId.prefix "generates"
    /// <summary>
    ///   <para>rdfs:label : Hidden reference ofrdfs:label : Verborgen referentie vanrdfs:label : Référence cachée derdfs:label : Referencia oculta derdfs:label : Verborgene Referenz von</para>
    ///   <para>rdfs:comment : The sense of a non-admissible lexicalization for a ontology entity. This is used to denote incorrect or deprecated language that may be useful for information extraction but not generation</para>
    ///   <a href="http://lemon-model.net/lemon#hiddenRef">lemon:hiddenRef</a>
    /// </summary>
    let hiddenRef = _prefixId.prefix "hiddenRef"
    /// <summary>
    ///   <para>rdfs:label : Onverenigbaarrdfs:label : Inkompatibelrdfs:label : Incompatiblerdfs:label : Incompatiblerdfs:label : Incompatible</para>
    ///   <para>rdfs:comment : Says that the two senses are disjoint. From a lexical point of view, this means substituting the lexical entries must change the meaning of the phrase. From an ontological point of view, this property is implied if both references are also disjoint, but does not imply disjointness, but non-equivalence of the references. For the mapping point of view  there is not instance when both mappings are valid.</para>
    ///   <a href="http://lemon-model.net/lemon#incompatible">lemon:incompatible</a>
    /// </summary>
    let incompatible = _prefixId.prefix "incompatible"
    /// <summary>
    ///   <para>rdfs:label : Instance ofrdfs:label : Instancia derdfs:label : Instantie vanrdfs:label : Instance derdfs:label : Instanz von</para>
    ///   <para>rdfs:comment : Denotes that the single argument of a class predicate is represented in the lexicon by the given semantic argument. That is Class(?x) or ?x rdf:type Class</para>
    ///   <a href="http://lemon-model.net/lemon#isA">lemon:isA</a>
    /// </summary>
    let isA = _prefixId.prefix "isA"
    /// <summary>
    ///   <para>rdfs:label : Referencia derdfs:label : Referenz vonrdfs:label : Référence derdfs:label : Referentie vanrdfs:label : Reference of</para>
    ///   <para>rdfs:comment : Indicate that a reference has a given sense</para>
    ///   <a href="http://lemon-model.net/lemon#isReferenceOf">lemon:isReferenceOf</a>
    /// </summary>
    let isReferenceOf = _prefixId.prefix "isReferenceOf"
    /// <summary>
    ///   <para>rdfs:label : Acepción derdfs:label : Sense ofrdfs:label : Sinn vonrdfs:label : Signfication derdfs:label : Zin van</para>
    ///   <para>rdfs:comment : Indicate that a sense is realised by the given lexical entry</para>
    ///   <a href="http://lemon-model.net/lemon#isSenseOf">lemon:isSenseOf</a>
    /// </summary>
    let isSenseOf = _prefixId.prefix "isSenseOf"
    /// <summary>
    ///   <para>rdfs:label : Lenguardfs:label : Languerdfs:label : Taalrdfs:label : Languagerdfs:label : Sprache</para>
    ///   <para>rdfs:comment : The language of a given lexicon. This should be some ISO-639 string</para>
    ///   <a href="http://lemon-model.net/lemon#language">lemon:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>rdfs:comment : Denotes the component referred to by the lex (pre-terminal) of the phrase structure</para>
    ///   <para>rdfs:label : Blattrdfs:label : Feuillerdfs:label : Leafrdfs:label : Bladrdfs:label : Hoja</para>
    ///   <a href="http://lemon-model.net/lemon#leaf">lemon:leaf</a>
    /// </summary>
    let leaf = _prefixId.prefix "leaf"
    /// <summary>
    ///   <para>rdfs:label : Lexikalische Formrdfs:label : Lexikaal vormrdfs:label : Lexical formrdfs:label : Forma léxicardfs:label : Forme lexicale</para>
    ///   <para>rdfs:comment : Denotes a written representation of a lexical entry</para>
    ///   <a href="http://lemon-model.net/lemon#lexicalForm">lemon:lexicalForm</a>
    /// </summary>
    let lexicalForm = _prefixId.prefix "lexicalForm"
    /// <summary>
    ///   <para>rdfs:label : Variante lexicalerdfs:label : Lexikalische Varianterdfs:label : Lexical variantrdfs:label : Variante léxicardfs:label : Lexikaal variant</para>
    ///   <para>rdfs:comment : Indicates a non-semantic relationship between two lexical entries. E.g., a term is derived from another term, such as "lexical" and "lexicalize"</para>
    ///   <a href="http://lemon-model.net/lemon#lexicalVariant">lemon:lexicalVariant</a>
    /// </summary>
    let lexicalVariant = _prefixId.prefix "lexicalVariant"
    /// <summary>
    ///   <para>rdfs:label : Merkerrdfs:label : Marcadorrdfs:label : Markerrdfs:label : Markerrdfs:label : маркерrdfs:label : Marqueur</para>
    ///   <para>rdfs:comment : Denotes the marker of a semantic argument. This should generally either be a semantic property i.e., case or another lexical entry e.g., a preposition or particle</para>
    ///   <a href="http://lemon-model.net/lemon#marker">lemon:marker</a>
    /// </summary>
    let marker = _prefixId.prefix "marker"
    /// <summary>
    ///   <para>rdfs:label : Más estrechordfs:label : Plus restreintrdfs:label : Engerrdfs:label : Engerrdfs:label : Narrower</para>
    ///   <para>rdfs:comment : Denotes that one sense is narrower than another. From a lexical point of view  this means replacing one lexical entry with another specializes the meaning of the phrase. From an ontological point of view this property makes not strong assertions. From a mapping point of view if the broader sense applies the narrower sense must also</para>
    ///   <a href="http://lemon-model.net/lemon#narrower">lemon:narrower</a>
    /// </summary>
    let narrower = _prefixId.prefix "narrower"
    /// <summary>
    ///   <para>rdfs:label : Volgende transformatierdfs:label : Transformation suivanterdfs:label : Transformación siguienterdfs:label : Next transformrdfs:label : Folgende Transformation</para>
    ///   <a href="http://lemon-model.net/lemon#nextTransform">lemon:nextTransform</a>
    /// </summary>
    let nextTransform = _prefixId.prefix "nextTransform"
    /// <summary>
    ///   <para>rdfs:label : Complemento de la propiedadrdfs:label : Object of propertyrdfs:label : Object van predikaatrdfs:label : Objekt von Prädikatrdfs:label : Complément de la propiété</para>
    ///   <para>rdfs:comment : Indicates the semantic argument which represents the objects (ranges) of the property referred to by this sense</para>
    ///   <a href="http://lemon-model.net/lemon#objOfProp">lemon:objOfProp</a>
    /// </summary>
    let objOfProp = _prefixId.prefix "objOfProp"
    /// <summary>
    ///   <para>rdfs:label : Optionelerdfs:label : Optionnelrdfs:label : Opcionalrdfs:label : Optionalrdfs:label : Optional</para>
    ///   <para>rdfs:comment : Denotes that the syntactic argument is optional (may be omitted)</para>
    ///   <a href="http://lemon-model.net/lemon#optional">lemon:optional</a>
    /// </summary>
    let optional = _prefixId.prefix "optional"
    /// <summary>
    ///   <para>rdfs:label : Autre formerdfs:label : Otra formardfs:label : Andere Formrdfs:label : Other formrdfs:label : Andere vorm</para>
    ///   <para>rdfs:comment : A non-preferred ("non-dictionary") representation of a lexical entry. This should be variant that is either a morphological variant, an abbreviation, short form or acronym</para>
    ///   <a href="http://lemon-model.net/lemon#otherForm">lemon:otherForm</a>
    /// </summary>
    let otherForm = _prefixId.prefix "otherForm"
    /// <summary>
    ///   <para>rdfs:label : Musterrdfs:label : Patternrdfs:label : Patroonrdfs:label : Patronrdfs:label : Шаблонrdfs:label : Patrón</para>
    ///   <a href="http://lemon-model.net/lemon#pattern">lemon:pattern</a>
    /// </summary>
    let pattern = _prefixId.prefix "pattern"
    /// <summary>
    ///   <para>rdfs:label : Raíz del sintagmardfs:label : Phrasewurzelrdfs:label : Phrase rootrdfs:label : Base de la syntagmerdfs:label : Zinsdeel wortel</para>
    ///   <para>rdfs:comment : Indicates the head node of a phrase structure or dependency parse graph</para>
    ///   <a href="http://lemon-model.net/lemon#phraseRoot">lemon:phraseRoot</a>
    /// </summary>
    let phraseRoot = _prefixId.prefix "phraseRoot"
    /// <summary>
    ///   <para>rdfs:label : Preferred reference ofrdfs:label : Bevorzugte Referenz vonrdfs:label : Voorkeursreferentie vanrdfs:label : Référence préféré derdfs:label : Referencia preferida de</para>
    ///   <para>rdfs:comment : The sense of the preferred lexicalization of a given ontology entity</para>
    ///   <a href="http://lemon-model.net/lemon#prefRef">lemon:prefRef</a>
    /// </summary>
    let prefRef = _prefixId.prefix "prefRef"
    /// <summary>
    ///   <para>rdfs:comment : Denotes a lexical property of a lexical entry, form, component or MWE node. For the lexical entry this is assumed to be static properties e.g., part of speech and gender and for the others this is assumed to be specific properties e.g., case, number</para>
    ///   <para>rdfs:label : Lexical propertyrdfs:label : Lexikalische Prädikatrdfs:label : Propiété lexicalerdfs:label : Propiedad léxicardfs:label : Lexikaal predikaat</para>
    ///   <a href="http://lemon-model.net/lemon#property">lemon:property</a>
    /// </summary>
    let property = _prefixId.prefix "property"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a restrictions on the domain of the property. That is, this sense only applies if the property the sense refers to has a subject in the class referred to by this property</para>
    ///   <para>rdfs:label : Prädikatsbereichrdfs:label : Domein van het predikaatrdfs:label : Property domainrdfs:label : Dominio de la propiedadrdfs:label : Ensemble de la propiété</para>
    ///   <a href="http://lemon-model.net/lemon#propertyDomain">lemon:propertyDomain</a>
    /// </summary>
    let propertyDomain = _prefixId.prefix "propertyDomain"
    /// <summary>
    ///   <para>rdfs:label : Prädikatszielmengerdfs:label : Property rangerdfs:label : Bereik van het predikaatrdfs:label : Rango de la propiedadrdfs:label : Image de la propiété</para>
    ///   <para>rdfs:comment : Indicates a restrictions on the range of the property. That is, this sense only applies if the property the sense refers to has a object in the class referred to by this property</para>
    ///   <a href="http://lemon-model.net/lemon#propertyRange">lemon:propertyRange</a>
    /// </summary>
    let propertyRange = _prefixId.prefix "propertyRange"
    /// <summary>
    ///   <para>rdfs:label : Referentierdfs:label : Referencerdfs:label : Référencerdfs:label : Referenzrdfs:label : Referencia</para>
    ///   <para>rdfs:comment : A reference to an external resource</para>
    ///   <a href="http://lemon-model.net/lemon#reference">lemon:reference</a>
    /// </summary>
    let reference = _prefixId.prefix "reference"
    /// <summary>
    ///   <para>rdfs:label : Voorstellingrdfs:label : Representationrdfs:label : Darstellungrdfs:label : Representaciónrdfs:label : Représentation</para>
    ///   <para>rdfs:comment : A realisation of a given form</para>
    ///   <a href="http://lemon-model.net/lemon#representation">lemon:representation</a>
    /// </summary>
    let representation = _prefixId.prefix "representation"
    /// <summary>
    ///   <para>rdfs:label : Règlerdfs:label : Rulerdfs:label : Reglardfs:label : Regelrdfs:label : Regel</para>
    ///   <a href="http://lemon-model.net/lemon#rule">lemon:rule</a>
    /// </summary>
    let rule = _prefixId.prefix "rule"
    /// <summary>
    ///   <para>rdfs:label : Semantisch argumentrdfs:label : Semantic argumentrdfs:label : Actant sémantiquerdfs:label : Semantische Argumentrdfs:label : Argumento semántico</para>
    ///   <para>rdfs:comment : Denotes a semantic argument slot of a semantic unit</para>
    ///   <a href="http://lemon-model.net/lemon#semArg">lemon:semArg</a>
    /// </summary>
    let semArg = _prefixId.prefix "semArg"
    /// <summary>
    ///   <para>rdfs:label : Zinrdfs:label : Significationrdfs:label : Acepciónrdfs:label : Senserdfs:label : Sinn</para>
    ///   <para>rdfs:comment : Indicates the sense of a lexical entry</para>
    ///   <a href="http://lemon-model.net/lemon#sense">lemon:sense</a>
    /// </summary>
    let sense = _prefixId.prefix "sense"
    /// <summary>
    ///   <para>rdfs:label : Sense relationrdfs:label : Sinn-Relationrdfs:label : Relation de Significationrdfs:label : Relación de Acepciónrdfs:label : Zin relatie</para>
    ///   <para>rdfs:comment : Denotes a relationship between senses</para>
    ///   <a href="http://lemon-model.net/lemon#senseRelation">lemon:senseRelation</a>
    /// </summary>
    let senseRelation = _prefixId.prefix "senseRelation"
    /// <summary>
    ///   <para>rdfs:label : Separadorrdfs:label : Afscheiderrdfs:label : Separatorrdfs:label : Separatorrdfs:label : Séparateur</para>
    ///   <para>rdfs:comment : Indicates the graphical element used to seperate the subnodes of this phrase structure. It is generally recommended that you use a string value with the language tag used to indicate script, (i.e., using ISO-15924 codes, such as "Latn"), as orthographic features may change with script.</para>
    ///   <a href="http://lemon-model.net/lemon#separator">lemon:separator</a>
    /// </summary>
    let separator = _prefixId.prefix "separator"
    /// <summary>
    ///   <para>rdfs:label : Onderwerp van predikaatrdfs:label : Sujet de la propiétérdfs:label : Sujeto de la propiedadrdfs:label : Subjekt von Prädikatrdfs:label : Subject of property</para>
    ///   <para>rdfs:comment : Indicates the semantic argument which represents the subjects (domain) of the property referred to by this sense</para>
    ///   <a href="http://lemon-model.net/lemon#subjOfProp">lemon:subjOfProp</a>
    /// </summary>
    let subjOfProp = _prefixId.prefix "subjOfProp"
    /// <summary>
    ///   <para>rdfs:label : Deel van de zinrdfs:label : Parte del acepciónrdfs:label : Teil des Sinnesrdfs:label : Signification composanterdfs:label : Subsense</para>
    ///   <para>rdfs:comment : Indicates that the relation between a compound sense and its atomic subsenses</para>
    ///   <a href="http://lemon-model.net/lemon#subsense">lemon:subsense</a>
    /// </summary>
    let subsense = _prefixId.prefix "subsense"
    /// <summary>
    ///   <para>rdfs:label : Argumento sintácticordfs:label : Actant syntaxiquerdfs:label : Syntactic argumentrdfs:label : Syntactische Argumentrdfs:label : Syntactisch argument</para>
    ///   <para>rdfs:comment : Indicates a slot in a syntactic frame</para>
    ///   <a href="http://lemon-model.net/lemon#synArg">lemon:synArg</a>
    /// </summary>
    let synArg = _prefixId.prefix "synArg"
    /// <summary>
    ///   <para>rdfs:label : Syntactisch optredenrdfs:label : Funcionamiento sintácticordfs:label : Syntactische Verhaltenrdfs:label : Syntactic behaviorrdfs:label : Conduite syntaxique</para>
    ///   <para>rdfs:comment : Indicates a syntactic behavior of a lexical entry</para>
    ///   <a href="http://lemon-model.net/lemon#synBehavior">lemon:synBehavior</a>
    /// </summary>
    let synBehavior = _prefixId.prefix "synBehavior"
    /// <summary>
    ///   <para>rdfs:label : Temardfs:label : Thèmerdfs:label : Themardfs:label : Themardfs:label : Topic</para>
    ///   <para>rdfs:comment : Indicates the topic of the overrall lexicon, this is property is sometimes called "subject field". Note that in addition to the topic of a lexicon each lexical entry may belong to a given domain, this can be modelled as equal or not equal to the topic of the associated lexicon</para>
    ///   <a href="http://lemon-model.net/lemon#topic">lemon:topic</a>
    /// </summary>
    let topic = _prefixId.prefix "topic"
    /// <summary>
    ///   <para>rdfs:label : Transformationrdfs:label : Transformationrdfs:label : Transformatierdfs:label : Transformaciónrdfs:label : Transform</para>
    ///   <a href="http://lemon-model.net/lemon#transform">lemon:transform</a>
    /// </summary>
    let transform = _prefixId.prefix "transform"
    /// <summary>
    ///   <para>rdfs:label : Árbolrdfs:label : Treerdfs:label : Boomrdfs:label : Baumrdfs:label : Arbre</para>
    ///   <a href="http://lemon-model.net/lemon#tree">lemon:tree</a>
    /// </summary>
    let tree = _prefixId.prefix "tree"
    /// <summary>
    ///   <para>rdfs:label : Wertrdfs:label : Waarderdfs:label : Valuerdfs:label : Valorrdfs:label : Valeur</para>
    ///   <para>rdfs:comment : This indicates the value of a pseudo-data node. An example of this is definition where the value would generally be a string but it would not be possible to add further annotations, such as source or creation date.</para>
    ///   <a href="http://lemon-model.net/lemon#value">lemon:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
    /// <summary>
    ///   <para>rdfs:comment : Gives the written representation of a given form</para>
    ///   <para>rdfs:label : Schriftliche Darstellungrdfs:label : Représentation écriterdfs:label : Schriftelijke voorstellingrdfs:label : Written representationrdfs:label : Representación escrita</para>
    ///   <a href="http://lemon-model.net/lemon#writtenRep">lemon:writtenRep</a>
    /// </summary>
    let writtenRep = _prefixId.prefix "writtenRep"
