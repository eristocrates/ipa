#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ontolex =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/ns/lemon/ontolex#" "ontolex"

    /// <summary>
    ///   <para>rdfs:label : Affixrdfs:label : aplicărdfs:label : affiksrdfs:label : affixerdfs:label : afijordfs:label : affissordfs:label : аффиксrdfs:label : affixrdfs:label : affixrdfs:label : affix</para>
    ///   <para>rdfs:comment : An affix is a lexical entry that represents a morpheme (suffix, prefix, infix, circumfix) that is attached to a word stem to form a new word.rdfs:comment : 'Аффикс' - это словарная единица, которая представляет морфему (суффикс, префикс, инфикс, циркумфикс), добавляемую к основе слова для образования нового слова.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#Affix">ontolex:Affix</a>
    /// </summary>
    let Affix = _prefixId.prefix "Affix"
    /// <summary>
    ///   <para>rdfs:label : verzameling van begrippenrdfs:label : concept setrdfs:label : banque de coneptsrdfs:label : набор понятийrdfs:label : conjunto de conceptosrdfs:label : banca concettirdfs:label : Konzeptsatz</para>
    ///   <para>rdfs:comment : 'Набор понятий' представляет собой совокупность лексических понятий.rdfs:comment : A concept set represents a collection of lexical concepts.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#ConceptSet">ontolex:ConceptSet</a>
    /// </summary>
    let ConceptSet = _prefixId.prefix "ConceptSet"
    /// <summary>
    ///   <para>rdfs:label : формаrdfs:label : vormrdfs:label : vormrdfs:label : formardfs:label : formardfs:label : formărdfs:label : Formardfs:label : formrdfs:label : formrdfs:label : Formrdfs:label : forme</para>
    ///   <para>rdfs:comment : A form represents one grammatical realization of a lexical entry.rdfs:comment : 'Форма' представляет одну грамматическую реализацию словарной единицы.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#Form">ontolex:Form</a>
    /// </summary>
    let Form = _prefixId.prefix "Form"
    /// <summary>
    ///   <para>rdfs:label : concetto lessicalerdfs:label : лексическое понятиеrdfs:label : leksikale konseprdfs:label : lexical conceptrdfs:label : lexikalisches Konzeptrdfs:label : lexikaliskt begrepprdfs:label : concept lexicalrdfs:label : concept lexicalrdfs:label : lexikaal conceptrdfs:label : concepto lexicalizadordfs:label : conceito léxico</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 'Лексическое понятие' представляет элемент абстрактного мышления, понятие или единицу мысли, которая может быть лексикализована определенным набором смыслов.rdfs:comment : A lexical concept represents a mental abstraction, concept or unit of thought that embodies the meaning of one or more lexical entries.</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#LexicalConcept">ontolex:LexicalConcept</a>
    /// </summary>
    let LexicalConcept = _prefixId.prefix "LexicalConcept"
    /// <summary>
    ///   <para>rdfs:label : entrata lessicalerdfs:label : lexical entryrdfs:label : înregistrare lexicalărdfs:label : lexikoningångrdfs:label : словарная единицаrdfs:label : entrada léxicardfs:label : entrée lexicalerdfs:label : leksikale inskrywingrdfs:label : lexikaal itemrdfs:label : Lexikoneintrag</para>
    ///   <para>rdfs:comment : A lexical entry represents a unit of analysis of the lexicon that consists of a set of forms that are grammatically related and a set of base meanings that are associated with all of these forms. Thus, a lexical entry is a word, multiword expression or affix with a single part-of-speech, morphological pattern, etymology and set of senses.rdfs:comment : 'Словарная единица' представляет собой единицу анализа словаря, которая состоит из совокупности грамматически связанных форм и совокупности основных значений, ассоциирующихся со всеми этими формами. 'Словарная единица' - это слово, словосочетание или аффикс одной части речи, морфологической модели, этимологии и набора значений.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#LexicalEntry">ontolex:LexicalEntry</a>
    /// </summary>
    let LexicalEntry = _prefixId.prefix "LexicalEntry"
    /// <summary>
    ///   <para>rdfs:comment : A lexical sense represents the lexical meaning of a lexical entry when interpreted as referring to the corresponding ontology element. A lexical sense thus represents a reification of a pair of a uniquely determined lexical entry and a uniquely determined ontology entity it refers to. A link between a lexical entry and an ontology entity via a Lexical Sense object implies that the lexical entry can be used to refer to the ontology entity in question.rdfs:comment : 'Лексический смысл' обозначает лексическое значение словарной единицы, когда оно понимается как относящееся к соответствующему элементу онтологии. 'Лексический смысл' представляет собой овеществление пары, состоящей из однозначно определяемой словарной единицы и однозначно определяемой сущности отнологии, к которой относится данный лексический смысл. Связь между словарной единицей и сущностью в онтологии посредством объекта 'Лексический Смысл' подразумевает, что словарная статья может быть использована для отсылки к соответствующей сущности в онтологии.</para>
    ///   <para>rdfs:label : leksikale sinrdfs:label : acepción léxicardfs:label : senso lessicalerdfs:label : sens lexicalrdfs:label : signification lexicalerdfs:label : лексический смыслrdfs:label : lexikalischer Sinnrdfs:label : lexikaal zinrdfs:label : lexikonbetydelserdfs:label : lexical sense</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#LexicalSense">ontolex:LexicalSense</a>
    /// </summary>
    let LexicalSense = _prefixId.prefix "LexicalSense"
    /// <summary>
    ///   <para>rdfs:label : multi-word expressionrdfs:label : expresie din mai multe cuvinterdfs:label : mutliwoorduitdrukkingrdfs:label : словосочетаниеrdfs:label : expression à mots multiplesrdfs:label : espressione di gruppi di parolerdfs:label : expresión multipalabrardfs:label : flerordsuttryckrdfs:label : multiwoorduitdrukkingrdfs:label : Mehrwortausdruck</para>
    ///   <para>rdfs:comment : 'Словосочетание' - это словарная единица, состоящая из двух или более слов.rdfs:comment : A multiword expression is a lexical entry that consists of two or more words.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#MultiWordExpression">ontolex:MultiWordExpression</a>
    /// </summary>
    let MultiWordExpression = _prefixId.prefix "MultiWordExpression"
    /// <summary>
    ///   <para>rdfs:label : woordrdfs:label : woordrdfs:label : ordrdfs:label : wordrdfs:label : parolardfs:label : palabrardfs:label : Wortrdfs:label : motrdfs:label : словоrdfs:label : cuvânt</para>
    ///   <para>rdfs:comment : 'Слово' - это словарная единица, представяющая собой единичную реализацию лексемы.rdfs:comment : A word is a lexical entry that consists of a single token.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#Word">ontolex:Word</a>
    /// </summary>
    let Word = _prefixId.prefix "Word"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : forma canónicardfs:label : kanonisk form rdfs:label : kanoniese vormrdfs:label : formă canonicărdfs:label : forme canoniquerdfs:label : каноническая формаrdfs:label : canonical formrdfs:label : canonieke vormrdfs:label : kanonische Formrdfs:label : forma canonicardfs:label : forma canonica</para>
    ///   <para>rdfs:comment : Свойство 'каноническая форма' связывает словарную единицу с ее канонической или словарной формой. Она обычно обозначает "лемму" словарной единицы.rdfs:comment : The 'canonical form' property relates a lexical entry to its canoncical or dictionary form. This usually indicates the "lemma" form of a lexical entry. </para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#canonicalForm">ontolex:canonicalForm</a>
    /// </summary>
    let canonicalForm = _prefixId.prefix "canonicalForm"
    /// <summary>
    ///   <para>rdfs:comment : The 'concept' property relates an ontological entity to a lexical concept that represents the corresponding meaning.rdfs:comment : Свойство 'понятие' связывает сущность в онтологии с лексическим понятием, которое представляет соответствующее значение.</para>
    ///   <para>rdfs:label : konseprdfs:label : conceptrdfs:label : conceptrdfs:label : conceptrdfs:label : Konzeptrdfs:label : begrepprdfs:label : conceitordfs:label : begriprdfs:label : conceptordfs:label : concettordfs:label : понятие</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#concept">ontolex:concept</a>
    /// </summary>
    let concept = _prefixId.prefix "concept"
    /// <summary>
    ///   <para>rdfs:label : dui aanrdfs:label : denotardfs:label : denotardfs:label : denotardfs:label : denotărdfs:label : denotesrdfs:label : dénoterdfs:label : обозначаетrdfs:label : betecknarrdfs:label : bezeichnetrdfs:label : duidet aan</para>
    ///   <para>rdfs:comment : Свойство 'обозначает' связывает словарную единицу с предикатом в онтологии, который представляет ее значение и обладает денотативной или теоретико-модельной семантикой.rdfs:comment : The 'denotes' property relates a lexical entry to a predicate in a given ontology that represents its meaning and has some denotational or model-theoretic semantics. </para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#denotes">ontolex:denotes</a>
    /// </summary>
    let denotes = _prefixId.prefix "denotes"
    /// <summary>
    ///   <para>rdfs:label : roep oprdfs:label : evocardfs:label : evocardfs:label : evocardfs:label : evocărdfs:label : évoquerdfs:label : lokt uitrdfs:label : evokesrdfs:label : ruft hervorrdfs:label : порождаетrdfs:label : framkallar</para>
    ///   <para>rdfs:comment : Свойство 'порождает' связывает словарную единицу с одним из лексических понятий, которую она порождает, то есть мыслительное понятие, которое возникает в сознании говорящих, когда они слышат данную словарную единицу.rdfs:comment : The 'evokes' property relates a lexical entry to one of the lexical concepts it evokes, i.e. the mental concept that speakers of a language might associate when hearing the lexical entry.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#evokes">ontolex:evokes</a>
    /// </summary>
    let evokes = _prefixId.prefix "evokes"
    /// <summary>
    ///   <para>rdfs:label : is concept ofrdfs:label : est un concept pour rdfs:label : ist Konzept vonrdfs:label : является понятиемrdfs:label : is concept vanrdfs:label : is konsep vanrdfs:label : este concept a(l)rdfs:label : es concepto derdfs:label : é conceito derdfs:label : è concetto di rdfs:label : är begrepp för</para>
    ///   <para>rdfs:comment : Это свойство формализует значение 'Лексического Понятия', связывая его с отдельным значением в онтологии.rdfs:comment : This property formalizes the meaning of a Lexical Concept by linking it to a particular ontological meaning.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#isConceptOf">ontolex:isConceptOf</a>
    /// </summary>
    let isConceptOf = _prefixId.prefix "isConceptOf"
    /// <summary>
    ///   <para>rdfs:label : est dénoté parrdfs:label : wordt aangeduidet doorrdfs:label : es denotado porrdfs:label : è denotato dardfs:label : is denoted byrdfs:label : é denotado porrdfs:label : este denotat curdfs:label : word aangedui deurrdfs:label : обозначаетсяrdfs:label : betecknas avrdfs:label : wird bezeichnet von</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The object property isDenotedBy is the inverse of the object property denotes.rdfs:comment : Свойство объекта 'обозначается' является обратным к свойству объекта 'обозначает'.</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#isDenotedBy">ontolex:isDenotedBy</a>
    /// </summary>
    let isDenotedBy = _prefixId.prefix "isDenotedBy"
    /// <summary>
    ///   <para>rdfs:label : est évoqué parrdfs:label : порождаетсяrdfs:label : word opgeroep deurrdfs:label : framkallas av rdfs:label : is evoked byrdfs:label : wordt uitgelokt doorrdfs:label : wird hervorgerufen vonrdfs:label : è evocato dardfs:label : es evocado porrdfs:label : este evocat de</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The inverse relation to evokes.rdfs:comment : Отношение обратное к 'порождает'.</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#isEvokedBy">ontolex:isEvokedBy</a>
    /// </summary>
    let isEvokedBy = _prefixId.prefix "isEvokedBy"
    /// <summary>
    ///   <para>rdfs:label : is lexicalized sense ofrdfs:label : is lexikaal zin vanrdfs:label : является лексикализованным смысломrdfs:label : är lexikaliserad betydelse förrdfs:label : is geleksikaliseerde sin vanrdfs:label : es l'acepción lexicalizado derdfs:label : ist lexikalisierter Sinn vonrdfs:label : est le sens lexicalisé derdfs:label : este sens lexicalizat derdfs:label : è il senso lessicalizzato di</para>
    ///   <para>rdfs:comment : The object property isLexicalizedSenseOf is the inverse property of lexicalized sense.rdfs:comment : Свойство объекта 'является лексикализованным смыслом' представляет собой свойство, обратное к свойству 'лексикализованный смысл'.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#isLexicalizedSenseOf">ontolex:isLexicalizedSenseOf</a>
    /// </summary>
    let isLexicalizedSenseOf = _prefixId.prefix "isLexicalizedSenseOf"
    /// <summary>
    ///   <para>rdfs:label : is referentie vanrdfs:label : est référence derdfs:label : является референциейrdfs:label : är referens förrdfs:label : é referência derdfs:label : è riferimento dirdfs:label : is reference ofrdfs:label : is verwysing vanrdfs:label : es referencia derdfs:label : este referință a(l)rdfs:label : ist Referenz von</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The object property isReferenceOf is the inverse property of reference.rdfs:comment : Свойство объекта 'является референцией' представляет собой свойство, обратное к свойству 'референция'.</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#isReferenceOf">ontolex:isReferenceOf</a>
    /// </summary>
    let isReferenceOf = _prefixId.prefix "isReferenceOf"
    /// <summary>
    ///   <para>rdfs:label : é sentido derdfs:label : is zin vanrdfs:label : is sin vanrdfs:label : è il senso dirdfs:label : es acepción derdfs:label : är betydelse förrdfs:label : est signification derdfs:label : является смысломrdfs:label : is sense ofrdfs:label : este sens a(l)rdfs:label : ist Sinn von</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The property isSenseOf is the inverse property of sense.rdfs:comment : Свойство 'является смыслом' представляет собой свойство, обратное к свойству 'смысл'.</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#isSenseOf">ontolex:isSenseOf</a>
    /// </summary>
    let isSenseOf = _prefixId.prefix "isSenseOf"
    /// <summary>
    ///   <para>rdfs:label : lexikonformrdfs:label : forma léxicardfs:label : forme lexicalerdfs:label : formă lexicalărdfs:label : лексическая формаrdfs:label : lexical formrdfs:label : leksikale vormrdfs:label : forma lessicalerdfs:label : lexikalische Formrdfs:label : lexikaal vorm</para>
    ///   <para>rdfs:comment : The 'lexical form' property relates a lexical entry to one grammatical form variant of the lexical entry.rdfs:comment : Свойство 'лексическая форма' соотносит словарную единицу с одним вариантом грамматической формы словарной единицы.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#lexicalForm">ontolex:lexicalForm</a>
    /// </summary>
    let lexicalForm = _prefixId.prefix "lexicalForm"
    /// <summary>
    ///   <para>rdfs:comment : Свойство 'лексикализованный смысл' связывает лексическое понятие с соответствующим лексическим смыслом, который лексикализует понятие.rdfs:comment : The 'lexicalized sense' property relates a lexical concept to a corresponding lexical sense that lexicalizes the concept.</para>
    ///   <para>rdfs:label : лексикализованный смыслrdfs:label : geleksikaliseerde Sinrdfs:label : sens lexicalizatrdfs:label : signification lexicalisérdfs:label : lexicalized senserdfs:label : lexikaliserad betydelserdfs:label : acepción lexicalizadardfs:label : lexikalisierter Sinnrdfs:label : senso lessicalizzatordfs:label : lexikaal zin</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#lexicalizedSense">ontolex:lexicalizedSense</a>
    /// </summary>
    let lexicalizedSense = _prefixId.prefix "lexicalizedSense"
    /// <summary>
    ///   <para>rdfs:comment : The 'morphological pattern' property indicates the morphological class of a word.rdfs:comment : Свойство 'морфологическая модель' обозначает морфологический класс слова.</para>
    ///   <para>rdfs:label : morfologiskt mönsterrdfs:label : morfologiese patroonrdfs:label : patron morphologiquerdfs:label : morphological patternrdfs:label : model morfologicrdfs:label : morphologisches Musterrdfs:label : morfologische patroonrdfs:label : patrón morfológicordfs:label : морфологическая модельrdfs:label : motivo morfologico</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#morphologicalPattern">ontolex:morphologicalPattern</a>
    /// </summary>
    let morphologicalPattern = _prefixId.prefix "morphologicalPattern"
    /// <summary>
    ///   <para>rdfs:label : autre formerdfs:label : другая формаrdfs:label : annan formrdfs:label : andere Formrdfs:label : ander formrdfs:label : outra formardfs:label : other formrdfs:label : altă formărdfs:label : andere vormrdfs:label : otra formardfs:label : altra forma</para>
    ///   <para>rdfs:comment : The  'other form' property relates a lexical entry to a non-preferred ("non-lemma") form that realizes the given lexical entry.rdfs:comment : Свойство 'другая форма' связывает словарную единицу с малоупотребительной формой ("не леммой"), которая является реализацией данной словарной единицы</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#otherForm">ontolex:otherForm</a>
    /// </summary>
    let otherForm = _prefixId.prefix "otherForm"
    /// <summary>
    ///   <para>rdfs:label : phonetische Darstellungrdfs:label : fonetisk representation rdfs:label : représentation phonétiquerdfs:label : reprezentare foneticărdfs:label : phonetic representationrdfs:label : фонетическое представлениеrdfs:label : fonetiese voorstellingrdfs:label : representación fonéticardfs:label : rappresentazione foneticardfs:label : fonetische voorstelling</para>
    ///   <para>rdfs:comment : Свойство 'фонетическое представление' обозначает фонетическое представление произношения формы с использованием какой-либо схемы, например, Международного фонетического алфавита (IPA, МФА).rdfs:comment : The 'phonetic representation' property indicates one phonetic representation of the pronunciation of the form using a scheme such as the International Phonetic Alphabet (IPA). </para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#phoneticRep">ontolex:phoneticRep</a>
    /// </summary>
    let phoneticRep = _prefixId.prefix "phoneticRep"
    /// <summary>
    ///   <para>rdfs:label : referințărdfs:label : Referenzrdfs:label : verwysingrdfs:label : референцияrdfs:label : referensrdfs:label : referencerdfs:label : referntierdfs:label : referênciardfs:label : riferimentordfs:label : référencerdfs:label : referencia</para>
    ///   <para>rdfs:comment : Свойство 'референция' соотносит лексический смысл с предикатом в онтологии, который уточняет значение денотата (соответствующей словарной единицы).rdfs:comment : The 'reference' property relates a lexical sense to an ontological predicate that represents the denotation of the corresponding lexical entry. </para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#reference">ontolex:reference</a>
    /// </summary>
    let reference = _prefixId.prefix "reference"
    /// <summary>
    ///   <para>rdfs:label : représentationrdfs:label : representationrdfs:label : representationrdfs:label : voorstellingrdfs:label : voorstellingrdfs:label : rappresentazionerdfs:label : reprezentarerdfs:label : representaçãordfs:label : representaciónrdfs:label : Darstellungrdfs:label : представление</para>
    ///   <para>rdfs:comment : The 'representation' property indicates a string by which the form is represented according to some orthography. rdfs:comment : Свойство 'представление' обозначает некую последовательность, с помощью которой форма может быть представлена средствами орфографии.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#representation">ontolex:representation</a>
    /// </summary>
    let representation = _prefixId.prefix "representation"
    /// <summary>
    ///   <para>rdfs:label : sentidordfs:label : sinnerdfs:label : sensrdfs:label : significationrdfs:label : zinrdfs:label : acepciónrdfs:label : betydelserdfs:label : смыслrdfs:label : Sinnrdfs:label : senserdfs:label : senso</para>
    ///   <para>rdfs:comment : The 'sense' property relates a lexical entry to one of its lexical senses. rdfs:comment : Свойство 'смысл' связывает словарную единицу с одним из ее лексических смыслов.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#sense">ontolex:sense</a>
    /// </summary>
    let sense = _prefixId.prefix "sense"
    /// <summary>
    ///   <para>rdfs:comment : The 'usage' property indicates usage conditions or pragmatic implications when using the lexical entry to refer to the given ontological meaning.rdfs:comment : Свойство 'употребление' обозначает условия использования или прагматическое значение при употреблении словарной единицы для соотнесения с определенным значением в онтологии.</para>
    ///   <para>rdfs:label : gebruikrdfs:label : Gebrauchrdfs:label : usagerdfs:label : usagerdfs:label : usordfs:label : usordfs:label : употребление</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#usage">ontolex:usage</a>
    /// </summary>
    let usage = _prefixId.prefix "usage"
    /// <summary>
    ///   <para>rdfs:label : skriven form rdfs:label : représentation écriterdfs:label : reprezentare scrisărdfs:label : geskrewe voorstellingrdfs:label : schriftlijke voorstellingrdfs:label : rappresentazione scrittardfs:label : representação escritardfs:label : письменное представлениеrdfs:label : written representationrdfs:label : schriftliche Darstellungrdfs:label : representación escrita</para>
    ///   <para>rdfs:comment : Свойство 'письменное представление' обозначает письменное представление формы.rdfs:comment : The 'written representation' property indicates the written representation of a form.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/ontolex#writtenRep">ontolex:writtenRep</a>
    /// </summary>
    let writtenRep = _prefixId.prefix "writtenRep"
