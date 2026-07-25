namespace http.www.w3.org.ns.lemon.ontolex.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ontolex =
    let _namespace_iri = Namespace_Iri ontolex |> NamespaceIRI
    /// <summary>
    ///   <para>ontolex:isSenseOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Свойство 'является смыслом' представляет собой свойство, обратное к свойству 'смысл'.</para>
    ///   <para>The property isSenseOf is the inverse property of sense.</para>
    /// labels<para>est signification de</para><para>является смыслом</para><para>är betydelse för</para><para>es acepción de</para><para>este sens a(l)</para><para>è il senso di</para><para>ist Sinn von</para><para>é sentido de</para><para>is sense of</para><para>is zin van</para><para>is sin van</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#isSenseOf">http://www.w3.org/ns/lemon/ontolex#isSenseOf</seealso>
    let isSenseOf = Prefixed_Name(ontolex, "isSenseOf") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:Form</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A form represents one grammatical realization of a lexical entry.</para>
    ///   <para>'Форма' представляет одну грамматическую реализацию словарной единицы.</para>
    /// labels<para>forme</para><para>forma</para><para>Forma</para><para>форма</para><para>formă</para><para>forma</para><para>Form</para><para>vorm</para><para>form</para><para>form</para><para>vorm</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#Form">http://www.w3.org/ns/lemon/ontolex#Form</seealso>
    let Form = Prefixed_Name(ontolex, "Form") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:writtenRep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Свойство 'письменное представление' обозначает письменное представление формы.</para>
    ///   <para>The 'written representation' property indicates the written representation of a form.</para>
    /// labels<para>schriftlijke voorstelling</para><para>rappresentazione scritta</para><para>письменное представление</para><para>schriftliche Darstellung</para><para>written representation</para><para>representación escrita</para><para>geskrewe voorstelling</para><para>représentation écrite</para><para>representação escrita</para><para>reprezentare scrisă</para><para>skriven form </para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#writtenRep">http://www.w3.org/ns/lemon/ontolex#writtenRep</seealso>
    let writtenRep = Prefixed_Name(ontolex, "writtenRep") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:usage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The 'usage' property indicates usage conditions or pragmatic implications when using the lexical entry to refer to the given ontological meaning.</para>
    ///   <para>Свойство 'употребление' обозначает условия использования или прагматическое значение при употреблении словарной единицы для соотнесения с определенным значением в онтологии.</para>
    /// labels<para>употребление</para><para>Gebrauch</para><para>gebruik</para><para>usage</para><para>usage</para><para>uso</para><para>uso</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#usage">http://www.w3.org/ns/lemon/ontolex#usage</seealso>
    let usage = Prefixed_Name(ontolex, "usage") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:phoneticRep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The 'phonetic representation' property indicates one phonetic representation of the pronunciation of the form using a scheme such as the International Phonetic Alphabet (IPA). </para>
    ///   <para>Свойство 'фонетическое представление' обозначает фонетическое представление произношения формы с использованием какой-либо схемы, например, Международного фонетического алфавита (IPA, МФА).</para>
    /// labels<para>фонетическое представление</para><para>rappresentazione fonetica</para><para>représentation phonétique</para><para>fonetisk representation </para><para>fonetische voorstelling</para><para>representación fonética</para><para>phonetic representation</para><para>phonetische Darstellung</para><para>fonetiese voorstelling</para><para>reprezentare fonetică</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#phoneticRep">http://www.w3.org/ns/lemon/ontolex#phoneticRep</seealso>
    let phoneticRep = Prefixed_Name(ontolex, "phoneticRep") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:Affix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An affix is a lexical entry that represents a morpheme (suffix, prefix, infix, circumfix) that is attached to a word stem to form a new word.</para>
    ///   <para>'Аффикс' - это словарная единица, которая представляет морфему (суффикс, префикс, инфикс, циркумфикс), добавляемую к основе слова для образования нового слова.</para>
    /// labels<para>affisso</para><para>affixe</para><para>aplică</para><para>аффикс</para><para>affiks</para><para>Affix</para><para>affix</para><para>affix</para><para>affix</para><para>afijo</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#Affix">http://www.w3.org/ns/lemon/ontolex#Affix</seealso>
    let Affix = Prefixed_Name(ontolex, "Affix") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:LexicalEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A lexical entry represents a unit of analysis of the lexicon that consists of a set of forms that are grammatically related and a set of base meanings that are associated with all of these forms. Thus, a lexical entry is a word, multiword expression or affix with a single part-of-speech, morphological pattern, etymology and set of senses.</para>
    ///   <para>'Словарная единица' представляет собой единицу анализа словаря, которая состоит из совокупности грамматически связанных форм и совокупности основных значений, ассоциирующихся со всеми этими формами. 'Словарная единица' - это слово, словосочетание или аффикс одной части речи, морфологической модели, этимологии и набора значений.</para>
    /// labels<para>înregistrare lexicală</para><para>leksikale inskrywing</para><para>словарная единица</para><para>entrata lessicale</para><para>entrée lexicale</para><para>Lexikoneintrag</para><para>entrada léxica</para><para>lexikoningång</para><para>lexical entry</para><para>lexikaal item</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#LexicalEntry">http://www.w3.org/ns/lemon/ontolex#LexicalEntry</seealso>
    let LexicalEntry = Prefixed_Name(ontolex, "LexicalEntry") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:LexicalConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>'Лексическое понятие' представляет элемент абстрактного мышления, понятие или единицу мысли, которая может быть лексикализована определенным набором смыслов.</para>
    ///   <para>A lexical concept represents a mental abstraction, concept or unit of thought that embodies the meaning of one or more lexical entries.</para>
    /// labels<para>lexikalisches Konzept</para><para>concepto lexicalizado</para><para>lexikaliskt begrepp</para><para>лексическое понятие</para><para>concetto lessicale</para><para>lexikaal concept</para><para>leksikale konsep</para><para>concept lexical</para><para>conceito léxico</para><para>concept lexical</para><para>lexical concept</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#LexicalConcept">http://www.w3.org/ns/lemon/ontolex#LexicalConcept</seealso>
    let LexicalConcept = Prefixed_Name(ontolex, "LexicalConcept") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:ConceptSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>'Набор понятий' представляет собой совокупность лексических понятий.</para>
    ///   <para>A concept set represents a collection of lexical concepts.</para>
    /// labels<para>verzameling van begrippen</para><para>conjunto de conceptos</para><para>banque de conepts</para><para>banca concetti</para><para>набор понятий</para><para>concept set</para><para>Konzeptsatz</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#ConceptSet">http://www.w3.org/ns/lemon/ontolex#ConceptSet</seealso>
    let ConceptSet = Prefixed_Name(ontolex, "ConceptSet") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:lexicalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Свойство 'лексическая форма' соотносит словарную единицу с одним вариантом грамматической формы словарной единицы.</para>
    ///   <para>The 'lexical form' property relates a lexical entry to one grammatical form variant of the lexical entry.</para>
    /// labels<para>lexikalische Form</para><para>лексическая форма</para><para>forma lessicale</para><para>leksikale vorm</para><para>forme lexicale</para><para>formă lexicală</para><para>lexikaal vorm</para><para>lexical form</para><para>forma léxica</para><para>lexikonform</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#lexicalForm">http://www.w3.org/ns/lemon/ontolex#lexicalForm</seealso>
    let lexicalForm = Prefixed_Name(ontolex, "lexicalForm") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:canonicalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Свойство 'каноническая форма' связывает словарную единицу с ее канонической или словарной формой. Она обычно обозначает "лемму" словарной единицы.</para>
    ///   <para>The 'canonical form' property relates a lexical entry to its canoncical or dictionary form. This usually indicates the "lemma" form of a lexical entry. </para>
    /// labels<para>каноническая форма</para><para>kanonische Form</para><para>forme canonique</para><para>kanoniese vorm</para><para>formă canonică</para><para>canonical form</para><para>forma canonica</para><para>canonieke vorm</para><para>forma canonica</para><para>kanonisk form </para><para>forma canónica</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#canonicalForm">http://www.w3.org/ns/lemon/ontolex#canonicalForm</seealso>
    let canonicalForm = Prefixed_Name(ontolex, "canonicalForm") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:LexicalSense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>'Лексический смысл' обозначает лексическое значение словарной единицы, когда оно понимается как относящееся к соответствующему элементу онтологии. 'Лексический смысл' представляет собой овеществление пары, состоящей из однозначно определяемой словарной единицы и однозначно определяемой сущности отнологии, к которой относится данный лексический смысл. Связь между словарной единицей и сущностью в онтологии посредством объекта 'Лексический Смысл' подразумевает, что словарная статья может быть использована для отсылки к соответствующей сущности в онтологии.</para>
    ///   <para>A lexical sense represents the lexical meaning of a lexical entry when interpreted as referring to the corresponding ontology element. A lexical sense thus represents a reification of a pair of a uniquely determined lexical entry and a uniquely determined ontology entity it refers to. A link between a lexical entry and an ontology entity via a Lexical Sense object implies that the lexical entry can be used to refer to the ontology entity in question.</para>
    /// labels<para>signification lexicale</para><para>lexikalischer Sinn</para><para>лексический смысл</para><para>lexikonbetydelse</para><para>senso lessicale</para><para>acepción léxica</para><para>leksikale sin</para><para>lexical sense</para><para>sens lexical</para><para>lexikaal zin</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#LexicalSense">http://www.w3.org/ns/lemon/ontolex#LexicalSense</seealso>
    let LexicalSense = Prefixed_Name(ontolex, "LexicalSense") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The 'reference' property relates a lexical sense to an ontological predicate that represents the denotation of the corresponding lexical entry. </para>
    ///   <para>Свойство 'референция' соотносит лексический смысл с предикатом в онтологии, который уточняет значение денотата (соответствующей словарной единицы).</para>
    /// labels<para>riferimento</para><para>референция</para><para>referencia</para><para>referência</para><para>verwysing</para><para>reference</para><para>referntie</para><para>referință</para><para>référence</para><para>Referenz</para><para>referens</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#reference">http://www.w3.org/ns/lemon/ontolex#reference</seealso>
    let reference = Prefixed_Name(ontolex, "reference") |> PrefixedName

    /// <summary>
    ///   <para>ontolex:MultiWordExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>'Словосочетание' - это словарная единица, состоящая из двух или более слов.</para>
    ///   <para>A multiword expression is a lexical entry that consists of two or more words.</para>
    /// labels<para>espressione di gruppi di parole</para><para>expresie din mai multe cuvinte</para><para>expression à mots multiples</para><para>expresión multipalabra</para><para>multiwoorduitdrukking</para><para>multi-word expression</para><para>mutliwoorduitdrukking</para><para>Mehrwortausdruck</para><para>flerordsuttryck</para><para>словосочетание</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#MultiWordExpression">http://www.w3.org/ns/lemon/ontolex#MultiWordExpression</seealso>
    let MultiWordExpression =
        Prefixed_Name(ontolex, "MultiWordExpression") |> PrefixedName

    /// <summary>
    ///   <para>ontolex:Word</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A word is a lexical entry that consists of a single token.</para>
    ///   <para>'Слово' - это словарная единица, представяющая собой единичную реализацию лексемы.</para>
    /// labels<para>palabra</para><para>cuvânt</para><para>parola</para><para>woord</para><para>woord</para><para>слово</para><para>word</para><para>Wort</para><para>ord</para><para>mot</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#Word">http://www.w3.org/ns/lemon/ontolex#Word</seealso>
    let Word = Prefixed_Name(ontolex, "Word") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:evokes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The 'evokes' property relates a lexical entry to one of the lexical concepts it evokes, i.e. the mental concept that speakers of a language might associate when hearing the lexical entry.</para>
    ///   <para>Свойство 'порождает' связывает словарную единицу с одним из лексических понятий, которую она порождает, то есть мыслительное понятие, которое возникает в сознании говорящих, когда они слышат данную словарную единицу.</para>
    /// labels<para>ruft hervor</para><para>framkallar</para><para>порождает</para><para>lokt uit</para><para>roep op</para><para>evokes</para><para>évoque</para><para>evoca</para><para>evoca</para><para>evoca</para><para>evocă</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#evokes">http://www.w3.org/ns/lemon/ontolex#evokes</seealso>
    let evokes = Prefixed_Name(ontolex, "evokes") |> PrefixedName

    /// <summary>
    ///   <para>ontolex:isLexicalizedSenseOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The object property isLexicalizedSenseOf is the inverse property of lexicalized sense.</para>
    ///   <para>Свойство объекта 'является лексикализованным смыслом' представляет собой свойство, обратное к свойству 'лексикализованный смысл'.</para>
    /// labels<para>является лексикализованным смыслом</para><para>är lexikaliserad betydelse för</para><para>es l'acepción lexicalizado de</para><para>ist lexikalisierter Sinn von</para><para>è il senso lessicalizzato di</para><para>is geleksikaliseerde sin van</para><para>est le sens lexicalisé de</para><para>este sens lexicalizat de</para><para>is lexicalized sense of</para><para>is lexikaal zin van</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#isLexicalizedSenseOf">http://www.w3.org/ns/lemon/ontolex#isLexicalizedSenseOf</seealso>
    let isLexicalizedSenseOf =
        Prefixed_Name(ontolex, "isLexicalizedSenseOf") |> PrefixedName

    /// <summary>
    ///   <para>ontolex:isDenotedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The object property isDenotedBy is the inverse of the object property denotes.</para>
    ///   <para>Свойство объекта 'обозначается' является обратным к свойству объекта 'обозначает'.</para>
    /// labels<para>wordt aangeduidet door</para><para>wird bezeichnet von</para><para>word aangedui deur</para><para>este denotat cu</para><para>es denotado por</para><para>est dénoté par</para><para>é denotado por</para><para>is denoted by</para><para>è denotato da</para><para>обозначается</para><para>betecknas av</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#isDenotedBy">http://www.w3.org/ns/lemon/ontolex#isDenotedBy</seealso>
    let isDenotedBy = Prefixed_Name(ontolex, "isDenotedBy") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:isEvokedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The inverse relation to evokes.</para>
    ///   <para>Отношение обратное к 'порождает'.</para>
    /// labels<para>wird hervorgerufen von</para><para>wordt uitgelokt door</para><para>word opgeroep deur</para><para>este evocat de</para><para>framkallas av </para><para>est évoqué par</para><para>es evocado por</para><para>è evocato da</para><para>is evoked by</para><para>порождается</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#isEvokedBy">http://www.w3.org/ns/lemon/ontolex#isEvokedBy</seealso>
    let isEvokedBy = Prefixed_Name(ontolex, "isEvokedBy") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:lexicalizedSense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The 'lexicalized sense' property relates a lexical concept to a corresponding lexical sense that lexicalizes the concept.</para>
    ///   <para>Свойство 'лексикализованный смысл' связывает лексическое понятие с соответствующим лексическим смыслом, который лексикализует понятие.</para>
    /// labels<para>signification lexicalisé</para><para>лексикализованный смысл</para><para>lexikaliserad betydelse</para><para>acepción lexicalizada</para><para>geleksikaliseerde Sin</para><para>senso lessicalizzato</para><para>lexikalisierter Sinn</para><para>lexicalized sense</para><para>sens lexicalizat</para><para>lexikaal zin</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#lexicalizedSense">http://www.w3.org/ns/lemon/ontolex#lexicalizedSense</seealso>
    let lexicalizedSense = Prefixed_Name(ontolex, "lexicalizedSense") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:isReferenceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Свойство объекта 'является референцией' представляет собой свойство, обратное к свойству 'референция'.</para>
    ///   <para>The object property isReferenceOf is the inverse property of reference.</para>
    /// labels<para>является референцией</para><para>este referință a(l)</para><para>is referentie van</para><para>is verwysing van</para><para>è riferimento di</para><para>est référence de</para><para>es referencia de</para><para>ist Referenz von</para><para>is reference of</para><para>é referência de</para><para>är referens för</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#isReferenceOf">http://www.w3.org/ns/lemon/ontolex#isReferenceOf</seealso>
    let isReferenceOf = Prefixed_Name(ontolex, "isReferenceOf") |> PrefixedName

    /// <summary>
    ///   <para>ontolex:morphologicalPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The 'morphological pattern' property indicates the morphological class of a word.</para>
    ///   <para>Свойство 'морфологическая модель' обозначает морфологический класс слова.</para>
    /// labels<para>морфологическая модель</para><para>morphologisches Muster</para><para>morphological pattern</para><para>morfologische patroon</para><para>morfologiskt mönster</para><para>patron morphologique</para><para>morfologiese patroon</para><para>patrón morfológico</para><para>motivo morfologico</para><para>model morfologic</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#morphologicalPattern">http://www.w3.org/ns/lemon/ontolex#morphologicalPattern</seealso>
    let morphologicalPattern =
        Prefixed_Name(ontolex, "morphologicalPattern") |> PrefixedName

    /// <summary>
    ///   <para>ontolex:otherForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Свойство 'другая форма' связывает словарную единицу с малоупотребительной формой ("не леммой"), которая является реализацией данной словарной единицы</para>
    ///   <para>The  'other form' property relates a lexical entry to a non-preferred ("non-lemma") form that realizes the given lexical entry.</para>
    /// labels<para>другая форма</para><para>outra forma</para><para>altra forma</para><para>autre forme</para><para>andere Form</para><para>andere vorm</para><para>ander form</para><para>other form</para><para>otra forma</para><para>annan form</para><para>altă formă</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#otherForm">http://www.w3.org/ns/lemon/ontolex#otherForm</seealso>
    let otherForm = Prefixed_Name(ontolex, "otherForm") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:representation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The 'representation' property indicates a string by which the form is represented according to some orthography. </para>
    ///   <para>Свойство 'представление' обозначает некую последовательность, с помощью которой форма может быть представлена средствами орфографии.</para>
    /// labels<para>rappresentazione</para><para>representación</para><para>representation</para><para>representation</para><para>représentation</para><para>representação</para><para>представление</para><para>voorstelling</para><para>reprezentare</para><para>voorstelling</para><para>Darstellung</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#representation">http://www.w3.org/ns/lemon/ontolex#representation</seealso>
    let representation = Prefixed_Name(ontolex, "representation") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Свойство 'понятие' связывает сущность в онтологии с лексическим понятием, которое представляет соответствующее значение.</para>
    ///   <para>The 'concept' property relates an ontological entity to a lexical concept that represents the corresponding meaning.</para>
    /// labels<para>concepto</para><para>conceito</para><para>concetto</para><para>понятие</para><para>concept</para><para>Konzept</para><para>begrepp</para><para>concept</para><para>concept</para><para>begrip</para><para>konsep</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#concept">http://www.w3.org/ns/lemon/ontolex#concept</seealso>
    let concept = Prefixed_Name(ontolex, "concept") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:isConceptOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property formalizes the meaning of a Lexical Concept by linking it to a particular ontological meaning.</para>
    ///   <para>Это свойство формализует значение 'Лексического Понятия', связывая его с отдельным значением в онтологии.</para>
    /// labels<para>est un concept pour </para><para>este concept a(l)</para><para>является понятием</para><para>ist Konzept von</para><para>es concepto de</para><para>är begrepp för</para><para>is concept van</para><para>è concetto di </para><para>is konsep van</para><para>is concept of</para><para>é conceito de</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#isConceptOf">http://www.w3.org/ns/lemon/ontolex#isConceptOf</seealso>
    let isConceptOf = Prefixed_Name(ontolex, "isConceptOf") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:denotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Свойство 'обозначает' связывает словарную единицу с предикатом в онтологии, который представляет ее значение и обладает денотативной или теоретико-модельной семантикой.</para>
    ///   <para>The 'denotes' property relates a lexical entry to a predicate in a given ontology that represents its meaning and has some denotational or model-theoretic semantics. </para>
    /// labels<para>bezeichnet</para><para>duidet aan</para><para>обозначает</para><para>betecknar</para><para>dui aan</para><para>denotes</para><para>denota</para><para>denotă</para><para>denota</para><para>dénote</para><para>denota</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#denotes">http://www.w3.org/ns/lemon/ontolex#denotes</seealso>
    let denotes = Prefixed_Name(ontolex, "denotes") |> PrefixedName
    /// <summary>
    ///   <para>ontolex:sense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The 'sense' property relates a lexical entry to one of its lexical senses. </para>
    ///   <para>Свойство 'смысл' связывает словарную единицу с одним из ее лексических смыслов.</para>
    /// labels<para>signification</para><para>betydelse</para><para>acepción</para><para>sentido</para><para>sinne</para><para>senso</para><para>sense</para><para>смысл</para><para>sens</para><para>Sinn</para><para>zin</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/ontolex#sense">http://www.w3.org/ns/lemon/ontolex#sense</seealso>
    let sense = Prefixed_Name(ontolex, "sense") |> PrefixedName
