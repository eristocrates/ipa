namespace http.www.w3.org.ns.lemon.ontolex.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ontolex =
    let _namespace_iri = Namespace_Iri ontolex |> NamespaceIRI
    /// <summary>
    ///   <para>ontolex:Affix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"'Аффикс' - это словарная единица, которая представляет морфему (суффикс, префикс, инфикс, циркумфикс), добавляемую к основе слова для образования нового слова."</para>
    ///   <para>"An affix is a lexical entry that represents a morpheme (suffix, prefix, infix, circumfix) that is attached to a word stem to form a new word."</para>
    /// labels<para>"Affix"</para><para>"affix"</para><para>"afijo"</para><para>"affiks"</para><para>"аффикс"</para><para>"aplică"</para><para>"affixe"</para><para>"affisso"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#Affix">http://www.w3.org/ns/lemon/ontolex#Affix</seealso>
    let Affix = Prefixed_Name(ontolex, "Affix") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:ConceptSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A concept set represents a collection of lexical concepts."</para>
    ///   <para>"'Набор понятий' представляет собой совокупность лексических понятий."</para>
    /// labels<para>"набор понятий"</para><para>"banca concetti"</para><para>"banque de conepts"</para><para>"conjunto de conceptos"</para><para>"Konzeptsatz"</para><para>"concept set"</para><para>"verzameling van begrippen"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#ConceptSet">http://www.w3.org/ns/lemon/ontolex#ConceptSet</seealso>
    let ConceptSet = Prefixed_Name(ontolex, "ConceptSet") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:Form</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A form represents one grammatical realization of a lexical entry."</para>
    ///   <para>"'Форма' представляет одну грамматическую реализацию словарной единицы."</para>
    /// labels<para>"vorm"</para><para>"Form"</para><para>"form"</para><para>"forme"</para><para>"Forma"</para><para>"forma"</para><para>"formă"</para><para>"форма"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#Form">http://www.w3.org/ns/lemon/ontolex#Form</seealso>
    let Form = Prefixed_Name(ontolex, "Form") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:LexicalConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A lexical concept represents a mental abstraction, concept or unit of thought that embodies the meaning of one or more lexical entries."</para>
    ///   <para>"'Лексическое понятие' представляет элемент абстрактного мышления, понятие или единицу мысли, которая может быть лексикализована определенным набором смыслов."</para>
    /// labels<para>"concept lexical"</para><para>"lexikalisches Konzept"</para><para>"lexical concept"</para><para>"concetto lessicale"</para><para>"lexikaal concept"</para><para>"conceito léxico"</para><para>"concepto lexicalizado"</para><para>"лексическое понятие"</para><para>"lexikaliskt begrepp"</para><para>"leksikale konsep"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#LexicalConcept">http://www.w3.org/ns/lemon/ontolex#LexicalConcept</seealso>
    let LexicalConcept = Prefixed_Name(ontolex, "LexicalConcept") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:LexicalEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"'Словарная единица' представляет собой единицу анализа словаря, которая состоит из совокупности грамматически связанных форм и совокупности основных значений, ассоциирующихся со всеми этими формами. 'Словарная единица' - это слово, словосочетание или аффикс одной части речи, морфологической модели, этимологии и набора значений."</para>
    ///   <para>"A lexical entry represents a unit of analysis of the lexicon that consists of a set of forms that are grammatically related and a set of base meanings that are associated with all of these forms. Thus, a lexical entry is a word, multiword expression or affix with a single part-of-speech, morphological pattern, etymology and set of senses."</para>
    /// labels<para>"entrée lexicale"</para><para>"entrata lessicale"</para><para>"leksikale inskrywing"</para><para>"înregistrare lexicală"</para><para>"lexikoningång"</para><para>"lexikaal item"</para><para>"словарная единица"</para><para>"Lexikoneintrag"</para><para>"lexical entry"</para><para>"entrada léxica"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#LexicalEntry">http://www.w3.org/ns/lemon/ontolex#LexicalEntry</seealso>
    let LexicalEntry = Prefixed_Name(ontolex, "LexicalEntry") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:LexicalSense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"'Лексический смысл' обозначает лексическое значение словарной единицы, когда оно понимается как относящееся к соответствующему элементу онтологии. 'Лексический смысл' представляет собой овеществление пары, состоящей из однозначно определяемой словарной единицы и однозначно определяемой сущности отнологии, к которой относится данный лексический смысл. Связь между словарной единицей и сущностью в онтологии посредством объекта 'Лексический Смысл' подразумевает, что словарная статья может быть использована для отсылки к соответствующей сущности в онтологии."</para>
    ///   <para>"A lexical sense represents the lexical meaning of a lexical entry when interpreted as referring to the corresponding ontology element. A lexical sense thus represents a reification of a pair of a uniquely determined lexical entry and a uniquely determined ontology entity it refers to. A link between a lexical entry and an ontology entity via a Lexical Sense object implies that the lexical entry can be used to refer to the ontology entity in question."</para>
    /// labels<para>"acepción léxica"</para><para>"лексический смысл"</para><para>"lexical sense"</para><para>"lexikaal zin"</para><para>"leksikale sin"</para><para>"lexikalischer Sinn"</para><para>"lexikonbetydelse"</para><para>"senso lessicale"</para><para>"signification lexicale"</para><para>"sens lexical"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#LexicalSense">http://www.w3.org/ns/lemon/ontolex#LexicalSense</seealso>
    let LexicalSense = Prefixed_Name(ontolex, "LexicalSense") |> PrefixedName

    /// <summary>
    ///   <para>ontolex:MultiWordExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A multiword expression is a lexical entry that consists of two or more words."</para>
    ///   <para>"'Словосочетание' - это словарная единица, состоящая из двух или более слов."</para>
    /// labels<para>"mutliwoorduitdrukking"</para><para>"expresie din mai multe cuvinte"</para><para>"Mehrwortausdruck"</para><para>"словосочетание"</para><para>"expression à mots multiples"</para><para>"expresión multipalabra"</para><para>"espressione di gruppi di parole"</para><para>"flerordsuttryck"</para><para>"multiwoorduitdrukking"</para><para>"multi-word expression"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#MultiWordExpression">http://www.w3.org/ns/lemon/ontolex#MultiWordExpression</seealso>
    let MultiWordExpression =
        Prefixed_Name(ontolex, "MultiWordExpression") |> PrefixedName

    /// <summary>
    ///   <para>ontolex:Word</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"'Слово' - это словарная единица, представяющая собой единичную реализацию лексемы."</para>
    ///   <para>"A word is a lexical entry that consists of a single token."</para>
    /// labels<para>"woord"</para><para>"palabra"</para><para>"parola"</para><para>"ord"</para><para>"слово"</para><para>"cuvânt"</para><para>"Wort"</para><para>"word"</para><para>"mot"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#Word">http://www.w3.org/ns/lemon/ontolex#Word</seealso>
    let Word = Prefixed_Name(ontolex, "Word") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:canonicalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Свойство 'каноническая форма' связывает словарную единицу с ее канонической или словарной формой. Она обычно обозначает "лемму" словарной единицы."</para>
    ///   <para>"The 'canonical form' property relates a lexical entry to its canoncical or dictionary form. This usually indicates the "lemma" form of a lexical entry. "</para>
    /// labels<para>"forma canonica"</para><para>"formă canonică"</para><para>"kanonische Form"</para><para>"kanoniese vorm"</para><para>"kanonisk form "</para><para>"forma canónica"</para><para>"каноническая форма"</para><para>"canonieke vorm"</para><para>"forme canonique"</para><para>"canonical form"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#canonicalForm">http://www.w3.org/ns/lemon/ontolex#canonicalForm</seealso>
    let canonicalForm = Prefixed_Name(ontolex, "canonicalForm") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Свойство 'понятие' связывает сущность в онтологии с лексическим понятием, которое представляет соответствующее значение."</para>
    ///   <para>"The 'concept' property relates an ontological entity to a lexical concept that represents the corresponding meaning."</para>
    /// labels<para>"concetto"</para><para>"понятие"</para><para>"concepto"</para><para>"begrepp"</para><para>"conceito"</para><para>"concept"</para><para>"Konzept"</para><para>"konsep"</para><para>"begrip"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#concept">http://www.w3.org/ns/lemon/ontolex#concept</seealso>
    let concept = Prefixed_Name(ontolex, "concept") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:denotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The 'denotes' property relates a lexical entry to a predicate in a given ontology that represents its meaning and has some denotational or model-theoretic semantics. "</para>
    ///   <para>"Свойство 'обозначает' связывает словарную единицу с предикатом в онтологии, который представляет ее значение и обладает денотативной или теоретико-модельной семантикой."</para>
    /// labels<para>"denota"</para><para>"denotă"</para><para>"denotes"</para><para>"dui aan"</para><para>"dénote"</para><para>"bezeichnet"</para><para>"duidet aan"</para><para>"обозначает"</para><para>"betecknar"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#denotes">http://www.w3.org/ns/lemon/ontolex#denotes</seealso>
    let denotes = Prefixed_Name(ontolex, "denotes") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:evokes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Свойство 'порождает' связывает словарную единицу с одним из лексических понятий, которую она порождает, то есть мыслительное понятие, которое возникает в сознании говорящих, когда они слышат данную словарную единицу."</para>
    ///   <para>"The 'evokes' property relates a lexical entry to one of the lexical concepts it evokes, i.e. the mental concept that speakers of a language might associate when hearing the lexical entry."</para>
    /// labels<para>"evocă"</para><para>"framkallar"</para><para>"roep op"</para><para>"evoca"</para><para>"évoque"</para><para>"порождает"</para><para>"ruft hervor"</para><para>"evokes"</para><para>"lokt uit"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#evokes">http://www.w3.org/ns/lemon/ontolex#evokes</seealso>
    let evokes = Prefixed_Name(ontolex, "evokes") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:isConceptOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property formalizes the meaning of a Lexical Concept by linking it to a particular ontological meaning."</para>
    ///   <para>"Это свойство формализует значение 'Лексического Понятия', связывая его с отдельным значением в онтологии."</para>
    /// labels<para>"is konsep van"</para><para>"является понятием"</para><para>"is concept van"</para><para>"este concept a(l)"</para><para>"est un concept pour "</para><para>"es concepto de"</para><para>"is concept of"</para><para>"ist Konzept von"</para><para>"é conceito de"</para><para>"är begrepp för"</para><para>"è concetto di "</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#isConceptOf">http://www.w3.org/ns/lemon/ontolex#isConceptOf</seealso>
    let isConceptOf = Prefixed_Name(ontolex, "isConceptOf") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:isDenotedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Свойство объекта 'обозначается' является обратным к свойству объекта 'обозначает'."</para>
    ///   <para>"The object property isDenotedBy is the inverse of the object property denotes."</para>
    /// labels<para>"wordt aangeduidet door"</para><para>"este denotat cu"</para><para>"é denotado por"</para><para>"betecknas av"</para><para>"word aangedui deur"</para><para>"обозначается"</para><para>"is denoted by"</para><para>"est dénoté par"</para><para>"wird bezeichnet von"</para><para>"è denotato da"</para><para>"es denotado por"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#isDenotedBy">http://www.w3.org/ns/lemon/ontolex#isDenotedBy</seealso>
    let isDenotedBy = Prefixed_Name(ontolex, "isDenotedBy") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:isEvokedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The inverse relation to evokes."</para>
    ///   <para>"Отношение обратное к 'порождает'."</para>
    /// labels<para>"word opgeroep deur"</para><para>"est évoqué par"</para><para>"wird hervorgerufen von"</para><para>"este evocat de"</para><para>"порождается"</para><para>"framkallas av "</para><para>"wordt uitgelokt door"</para><para>"es evocado por"</para><para>"is evoked by"</para><para>"è evocato da"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#isEvokedBy">http://www.w3.org/ns/lemon/ontolex#isEvokedBy</seealso>
    let isEvokedBy = Prefixed_Name(ontolex, "isEvokedBy") |> PrefixedName

    /// <summary>
    ///   <para>ontolex:isLexicalizedSenseOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Свойство объекта 'является лексикализованным смыслом' представляет собой свойство, обратное к свойству 'лексикализованный смысл'."</para>
    ///   <para>"The object property isLexicalizedSenseOf is the inverse property of lexicalized sense."</para>
    /// labels<para>"является лексикализованным смыслом"</para><para>"es l'acepción lexicalizado de"</para><para>"is lexikaal zin van"</para><para>"este sens lexicalizat de"</para><para>"is geleksikaliseerde sin van"</para><para>"è il senso lessicalizzato di"</para><para>"is lexicalized sense of"</para><para>"är lexikaliserad betydelse för"</para><para>"est le sens lexicalisé de"</para><para>"ist lexikalisierter Sinn von"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#isLexicalizedSenseOf">http://www.w3.org/ns/lemon/ontolex#isLexicalizedSenseOf</seealso>
    let isLexicalizedSenseOf =
        Prefixed_Name(ontolex, "isLexicalizedSenseOf") |> PrefixedName

    /// <summary>
    ///   <para>ontolex:isReferenceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"Свойство объекта 'является референцией' представляет собой свойство, обратное к свойству 'референция'."</para>
    ///   <para>"The object property isReferenceOf is the inverse property of reference."</para>
    /// labels<para>"è riferimento di"</para><para>"är referens för"</para><para>"is verwysing van"</para><para>"is referentie van"</para><para>"est référence de"</para><para>"является референцией"</para><para>"este referință a(l)"</para><para>"es referencia de"</para><para>"ist Referenz von"</para><para>"is reference of"</para><para>"é referência de"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#isReferenceOf">http://www.w3.org/ns/lemon/ontolex#isReferenceOf</seealso>
    let isReferenceOf = Prefixed_Name(ontolex, "isReferenceOf") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:isSenseOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Свойство 'является смыслом' представляет собой свойство, обратное к свойству 'смысл'."</para>
    ///   <para>"The property isSenseOf is the inverse property of sense."</para>
    /// labels<para>"is sense of"</para><para>"is zin van"</para><para>"è il senso di"</para><para>"este sens a(l)"</para><para>"é sentido de"</para><para>"является смыслом"</para><para>"ist Sinn von"</para><para>"is sin van"</para><para>"är betydelse för"</para><para>"est signification de"</para><para>"es acepción de"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#isSenseOf">http://www.w3.org/ns/lemon/ontolex#isSenseOf</seealso>
    let isSenseOf = Prefixed_Name(ontolex, "isSenseOf") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:lexicalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Свойство 'лексическая форма' соотносит словарную единицу с одним вариантом грамматической формы словарной единицы."</para>
    ///   <para>"The 'lexical form' property relates a lexical entry to one grammatical form variant of the lexical entry."</para>
    /// labels<para>"leksikale vorm"</para><para>"forme lexicale"</para><para>"forma léxica"</para><para>"forma lessicale"</para><para>"lexical form"</para><para>"lexikaal vorm"</para><para>"lexikonform"</para><para>"лексическая форма"</para><para>"lexikalische Form"</para><para>"formă lexicală"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#lexicalForm">http://www.w3.org/ns/lemon/ontolex#lexicalForm</seealso>
    let lexicalForm = Prefixed_Name(ontolex, "lexicalForm") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:lexicalizedSense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The 'lexicalized sense' property relates a lexical concept to a corresponding lexical sense that lexicalizes the concept."</para>
    ///   <para>"Свойство 'лексикализованный смысл' связывает лексическое понятие с соответствующим лексическим смыслом, который лексикализует понятие."</para>
    /// labels<para>"signification lexicalisé"</para><para>"lexikaal zin"</para><para>"lexicalized sense"</para><para>"senso lessicalizzato"</para><para>"лексикализованный смысл"</para><para>"lexikalisierter Sinn"</para><para>"geleksikaliseerde Sin"</para><para>"lexikaliserad betydelse"</para><para>"sens lexicalizat"</para><para>"acepción lexicalizada"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#lexicalizedSense">http://www.w3.org/ns/lemon/ontolex#lexicalizedSense</seealso>
    let lexicalizedSense = Prefixed_Name(ontolex, "lexicalizedSense") |> PrefixedName

    /// <summary>
    ///   <para>ontolex:morphologicalPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Свойство 'морфологическая модель' обозначает морфологический класс слова."</para>
    ///   <para>"The 'morphological pattern' property indicates the morphological class of a word."</para>
    /// labels<para>"patrón morfológico"</para><para>"motivo morfologico"</para><para>"morphological pattern"</para><para>"model morfologic"</para><para>"morfologische patroon"</para><para>"morfologiskt mönster"</para><para>"morfologiese patroon"</para><para>"morphologisches Muster"</para><para>"patron morphologique"</para><para>"морфологическая модель"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#morphologicalPattern">http://www.w3.org/ns/lemon/ontolex#morphologicalPattern</seealso>
    let morphologicalPattern =
        Prefixed_Name(ontolex, "morphologicalPattern") |> PrefixedName

    /// <summary>
    ///   <para>ontolex:otherForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Свойство 'другая форма' связывает словарную единицу с малоупотребительной формой ("не леммой"), которая является реализацией данной словарной единицы"</para>
    ///   <para>"The  'other form' property relates a lexical entry to a non-preferred ("non-lemma") form that realizes the given lexical entry."</para>
    /// labels<para>"autre forme"</para><para>"andere Form"</para><para>"outra forma"</para><para>"ander form"</para><para>"andere vorm"</para><para>"other form"</para><para>"annan form"</para><para>"altra forma"</para><para>"другая форма"</para><para>"otra forma"</para><para>"altă formă"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#otherForm">http://www.w3.org/ns/lemon/ontolex#otherForm</seealso>
    let otherForm = Prefixed_Name(ontolex, "otherForm") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:phoneticRep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The 'phonetic representation' property indicates one phonetic representation of the pronunciation of the form using a scheme such as the International Phonetic Alphabet (IPA). "</para>
    ///   <para>"Свойство 'фонетическое представление' обозначает фонетическое представление произношения формы с использованием какой-либо схемы, например, Международного фонетического алфавита (IPA, МФА)."</para>
    /// labels<para>"représentation phonétique"</para><para>"phonetische Darstellung"</para><para>"fonetisk representation "</para><para>"rappresentazione fonetica"</para><para>"fonetische voorstelling"</para><para>"representación fonética"</para><para>"phonetic representation"</para><para>"fonetiese voorstelling"</para><para>"фонетическое представление"</para><para>"reprezentare fonetică"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#phoneticRep">http://www.w3.org/ns/lemon/ontolex#phoneticRep</seealso>
    let phoneticRep = Prefixed_Name(ontolex, "phoneticRep") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Свойство 'референция' соотносит лексический смысл с предикатом в онтологии, который уточняет значение денотата (соответствующей словарной единицы)."</para>
    ///   <para>"The 'reference' property relates a lexical sense to an ontological predicate that represents the denotation of the corresponding lexical entry. "</para>
    /// labels<para>"референция"</para><para>"riferimento"</para><para>"referência"</para><para>"Referenz"</para><para>"reference"</para><para>"referencia"</para><para>"referens"</para><para>"referntie"</para><para>"verwysing"</para><para>"referință"</para><para>"référence"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#reference">http://www.w3.org/ns/lemon/ontolex#reference</seealso>
    let reference = Prefixed_Name(ontolex, "reference") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:representation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Свойство 'представление' обозначает некую последовательность, с помощью которой форма может быть представлена средствами орфографии."</para>
    ///   <para>"The 'representation' property indicates a string by which the form is represented according to some orthography. "</para>
    /// labels<para>"representation"</para><para>"представление"</para><para>"representación"</para><para>"Darstellung"</para><para>"representação"</para><para>"voorstelling"</para><para>"rappresentazione"</para><para>"représentation"</para><para>"reprezentare"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#representation">http://www.w3.org/ns/lemon/ontolex#representation</seealso>
    let representation = Prefixed_Name(ontolex, "representation") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:sense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"Свойство 'смысл' связывает словарную единицу с одним из ее лексических смыслов."</para>
    ///   <para>"The 'sense' property relates a lexical entry to one of its lexical senses. "</para>
    /// labels<para>"senso"</para><para>"zin"</para><para>"sentido"</para><para>"смысл"</para><para>"sense"</para><para>"betydelse"</para><para>"Sinn"</para><para>"sinne"</para><para>"signification"</para><para>"sens"</para><para>"acepción"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#sense">http://www.w3.org/ns/lemon/ontolex#sense</seealso>
    let sense = Prefixed_Name(ontolex, "sense") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:usage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The 'usage' property indicates usage conditions or pragmatic implications when using the lexical entry to refer to the given ontological meaning."</para>
    ///   <para>"Свойство 'употребление' обозначает условия использования или прагматическое значение при употреблении словарной единицы для соотнесения с определенным значением в онтологии."</para>
    /// labels<para>"usage"</para><para>"Gebrauch"</para><para>"uso"</para><para>"gebruik"</para><para>"употребление"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#usage">http://www.w3.org/ns/lemon/ontolex#usage</seealso>
    let usage = Prefixed_Name(ontolex, "usage") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:writtenRep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The 'written representation' property indicates the written representation of a form."</para>
    ///   <para>"Свойство 'письменное представление' обозначает письменное представление формы."</para>
    /// labels<para>"письменное представление"</para><para>"geskrewe voorstelling"</para><para>"rappresentazione scritta"</para><para>"représentation écrite"</para><para>"schriftliche Darstellung"</para><para>"schriftlijke voorstelling"</para><para>"reprezentare scrisă"</para><para>"representação escrita"</para><para>"skriven form "</para><para>"representación escrita"</para><para>"written representation"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#writtenRep">http://www.w3.org/ns/lemon/ontolex#writtenRep</seealso>
    let writtenRep = Prefixed_Name(ontolex, "writtenRep") |> PrefixedName
