#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module synsem =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/ns/lemon/synsem#" "synsem"

    /// <summary>
    ///   <para>rdfs:label : Ontologieabbildungrdfs:label : ontologieafbeeldingrdfs:label : applicación de l'ontologíardfs:label : отображение онтологииrdfs:label : ontology mappingrdfs:label : mappa de l'ontologiardfs:label : application de l'ontologie</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 'Отображение онтологии' (OntoMap для краткости) определяет, как синтаксический фрейм и его синтаксические аргументы сопоставляются с набором понятий и свойств в онтологии, которые вместе определяют значение синтаксического фрейма.rdfs:comment : An 'ontology mapping' (OntoMap for short) specifies how a syntactic frame and its syntactic arguments map to a set of concepts and properties in the ontology that together specify the meaning of the syntactic frame.</para>
    ///   <a href="http://www.w3.org/ns/lemon/synsem#OntoMap">synsem:OntoMap</a>
    /// </summary>
    let OntoMap = _prefixId.prefix "OntoMap"
    /// <summary>
    ///   <para>rdfs:label : syntaktiskt argumentrdfs:label : actant syntaxiquerdfs:label : argumento sintácticordfs:label : argomento sintatticordfs:label : синтаксический аргументrdfs:label : syntactisch argumentrdfs:label : argument sintacticrdfs:label : sintaktiese argumentrdfs:label : syntaktisches Argumentrdfs:label : Syntactic Argumentrdfs:label : argumento sintatico</para>
    ///   <para>rdfs:comment : 'Синтаксический аргумент' представляет собой слот, который необходимо заполнить для получения определенного синтаксического фрейма. Синтаксические аргументы обычно реализуют определенную грамматическую функцию (например, субъект, прямой объект, косвенный объект, предпозиционный объект и т.д.).rdfs:comment : A 'syntactic argument' represents a slot that needs to be filled for a certain syntactic frame to be complete. Syntactic arguments typically realize a certain grammatical function (e.g. subject, direct object, indirect object, prepositional object, etc.).</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/synsem#SyntacticArgument">synsem:SyntacticArgument</a>
    /// </summary>
    let SyntacticArgument = _prefixId.prefix "SyntacticArgument"
    /// <summary>
    ///   <para>rdfs:label : cadre syntaxiquerdfs:label : синтаксический фреймrdfs:label : ramrdfs:label : syntaktisches Framerdfs:label : cadrurdfs:label : Syntactic Framerdfs:label : raamrdfs:label : marco sintácticordfs:label : raamrdfs:label : frame</para>
    ///   <para>rdfs:comment : A 'syntactic frame' represents the syntactic behavior of an open class word in terms of the (syntactic) arguments it requires. It essentially describes the so called subcategorization structure of the word in question, in particular the syntactic arguments it requires.rdfs:comment : 'Синтаксический фрейм' представляет синтаксическое поведение открытого слова класса в терминах (синтаксических) аргументов, которые ему необходимы. Он по существу описывает так называемую структуру подкатегоризации рассматриваемого слова, в частности синтаксические аргументы, которые он требует.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/synsem#SyntacticFrame">synsem:SyntacticFrame</a>
    /// </summary>
    let SyntacticFrame = _prefixId.prefix "SyntacticFrame"
    /// <summary>
    ///   <para>rdfs:label : состояниеrdfs:label : condițierdfs:label : condiçãordfs:label : villkorrdfs:label : Bedingungrdfs:label : voorwaarderdfs:label : voorwaarderdfs:label : condizionerdfs:label : conditionrdfs:label : conditionrdfs:label : condición</para>
    ///   <para>rdfs:comment : The 'condition' property defines an evaluable constraint that derives from using a certain lexical entry to express a given ontological predicate.rdfs:comment : Свойство 'состояние' определяет оценочное ограничение, которое получается из использования определенной словарной единицы для выражения заданного онтологического предиката.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/synsem#condition">synsem:condition</a>
    /// </summary>
    let condition = _prefixId.prefix "condition"
    /// <summary>
    ///   <para>rdfs:label : instantie vanrdfs:label : instanz vonrdfs:label : é umrdfs:label : instansie vanrdfs:label : instanță ardfs:label : istanza dirdfs:label : экземплярrdfs:label : Instance derdfs:label : är enrdfs:label : Instancia de</para>
    ///   <para>rdfs:comment : Свойство 'экземпляр' представляет одиночный аргумент класса или унарный предикат.rdfs:comment : The 'is a' property represents the single argument of a class or unary  predicate.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/synsem#isA">synsem:isA</a>
    /// </summary>
    let isA = _prefixId.prefix "isA"
    /// <summary>
    ///   <para>rdfs:label : Markerrdfs:label : marqueurrdfs:label : маркерrdfs:label : marcatorrdfs:label : marcatorerdfs:label : markörrdfs:label : marcadorrdfs:label : merkerrdfs:label : merkerrdfs:label : markerrdfs:label : marcado</para>
    ///   <para>rdfs:comment : The 'marker' property indicates the marker of a syntactic argument; this can be a case marker or some other lexical entry such as a preposition or particle.rdfs:comment : Свойство 'маркер' указывает маркер синтаксического аргумента; Это может быть маркер падежа или какая-то другая словарная единица, такая как предлог или частица.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/synsem#marker">synsem:marker</a>
    /// </summary>
    let marker = _prefixId.prefix "marker"
    /// <summary>
    ///   <para>rdfs:label : obiect al proprietățiirdfs:label : object of propertyrdfs:label : voorwerp van predikaatrdfs:label : objekt av predikatrdfs:label : complemento de la propiedadrdfs:label : complément de la propriétérdfs:label : oggetto della proprietàrdfs:label : объект свойстваrdfs:label : object van predikaatrdfs:label : objekt des Prädikats</para>
    ///   <para>rdfs:comment : The 'objOfProp' represents the 2nd argument or object of a binary predicate (property) in the ontology.rdfs:comment : 'Объект свойства' представляет 2-й аргумент или объект бинарного предиката (свойства) в онтологии.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/synsem#objOfProp">synsem:objOfProp</a>
    /// </summary>
    let objOfProp = _prefixId.prefix "objOfProp"
    /// <summary>
    ///   <para>rdfs:comment : Свойство 'онтологическая переписка' связывает аргумент предиката, определенного в онтологии, с синтаксическим аргументом, который синтаксически реализует этот предикат.rdfs:comment : The 'ontoCorrespondence' property binds an argument of a predicate defined in the ontology to a syntactic argument that realizes this predicate argument syntactically.</para>
    ///   <para>rdfs:label : correspondencia ontológicardfs:label : ontologische correspondentierdfs:label : correspondance ontologiquerdfs:label : онтологическая перепискаrdfs:label : corrispondenza ontologicardfs:label : ontological correspondencerdfs:label : ontologische Korrespondenz</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/synsem#ontoCorrespondence">synsem:ontoCorrespondence</a>
    /// </summary>
    let ontoCorrespondence = _prefixId.prefix "ontoCorrespondence"
    /// <summary>
    ///   <para>rdfs:label : ontologieafbeeldingrdfs:label : Ontologieabbildungrdfs:label : application de l'ontologierdfs:label : отображение онтологииrdfs:label : applicación de l'ontologíardfs:label : mappa de l'ontologia</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The 'ontoMapping'  property relates an ontology mapping to its corresponding lexical sense.rdfs:comment : Свойство 'onMapping' связывает отображение онтологии с соответствующим ему лексическим смыслом.</para>
    ///   <a href="http://www.w3.org/ns/lemon/synsem#ontoMapping">synsem:ontoMapping</a>
    /// </summary>
    let ontoMapping = _prefixId.prefix "ontoMapping"
    /// <summary>
    ///   <para>rdfs:label : optionalrdfs:label : optionalrdfs:label : optionnelrdfs:label : opsioneelrdfs:label : optionellrdfs:label : опциональныйrdfs:label : optioneelrdfs:label : opcionalrdfs:label : opcionalrdfs:label : facultativrdfs:label : opzionale</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The 'optional' property indicates whether a syntactic argument is optional, that is, it can be syntactically omitted.rdfs:comment : Свойство 'опциональный' указывает, является ли синтаксический аргумент необязательным, то есть его можно синтаксически исключить.</para>
    ///   <a href="http://www.w3.org/ns/lemon/synsem#optional">synsem:optional</a>
    /// </summary>
    let optional = _prefixId.prefix "optional"
    /// <summary>
    ///   <para>rdfs:label : dominio di proprietàrdfs:label : property domainrdfs:label : domeniul proprietățiirdfs:label : dominio de la propiedadrdfs:label : Definitionsbereich des Prädikatsrdfs:label : relationsdomänrdfs:label : domein van predikaatrdfs:label : predikaatdefinisiegebiedrdfs:label : свойство доменаrdfs:label : ensemble de la propriété</para>
    ///   <para>rdfs:comment : 'Свойство домена' обеспечивает прагматическое ограничение на область свойства, на которое ссылается этот смысл.rdfs:comment : 'Property domain' provides a pragmatic restriction on the domain of the property referred to by this sense.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/synsem#propertyDomain">synsem:propertyDomain</a>
    /// </summary>
    let propertyDomain = _prefixId.prefix "propertyDomain"
    /// <summary>
    ///   <para>rdfs:label : rango de la propiedadrdfs:label : relationsräckviddrdfs:label : Wertemenge des Prädikatsrdfs:label : codominio di proprietàrdfs:label : predikaatwaardegebiedrdfs:label : bereik van predikaatrdfs:label : property rangerdfs:label : gama proprietățiirdfs:label : image de la propriétérdfs:label : диапазон свойства</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 'Property domain' provides a pragmatic restriction on the range of the property referred to by this sense.rdfs:comment : 'Диапазон свойства' обеспечивает прагматическое ограничение на область диапазона,на которое ссылается этот смысл.</para>
    ///   <a href="http://www.w3.org/ns/lemon/synsem#propertyRange">synsem:propertyRange</a>
    /// </summary>
    let propertyRange = _prefixId.prefix "propertyRange"
    /// <summary>
    ///   <para>rdfs:label : subiectul proprietațiirdfs:label : sujet de la propriétérdfs:label : subject of propertyrdfs:label : subjekt av predikatrdfs:label : Subjekt des Prädikatsrdfs:label : onderwerp van predikaatrdfs:label : onderwerp van predikaatrdfs:label : субъект свойстваrdfs:label : sujeto de la propiedadrdfs:label : soggetto della proprietà</para>
    ///   <para>rdfs:comment : Свойство 'subjOfProp' представляет 1-й аргумент или субъект бинарного предиката (свойства) в онтологии.rdfs:comment : The 'subjOfProp' property represents the 1st argument or subject of a binary predicate (property) in the ontology.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/synsem#subjOfProp">synsem:subjOfProp</a>
    /// </summary>
    let subjOfProp = _prefixId.prefix "subjOfProp"
    /// <summary>
    ///   <para>rdfs:comment : The 'submap' property relates a (complex) ontological mapping to a set of bindings that together bind the arguments of the involved predicates to a set of syntactic arguments that realize them syntactically.rdfs:comment : Свойство 'submap' связывает (сложное) онтологическое отображение с набором привязок, которые вместе связывают аргументы задействованных предикатов с набором синтаксических аргументов, которые реализуют их синтаксически.</para>
    ///   <para>rdfs:label : cadre composanterdfs:label : subframerdfs:label : underbetydelserdfs:label : parte del marcordfs:label : Subframerdfs:label : deelraamrdfs:label : submap</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/synsem#submap">synsem:submap</a>
    /// </summary>
    let submap = _prefixId.prefix "submap"
    /// <summary>
    ///   <para>rdfs:label : syntactic argumentrdfs:label : syntaktiskt argumentrdfs:label : syntactisch argumentrdfs:label : argument sintacticrdfs:label : argomento sintatticordfs:label : argumento sintaticordfs:label : синтаксический аргументrdfs:label : sintaktiese argumentrdfs:label : actant syntaxiquerdfs:label : syntaktisches Argumentrdfs:label : argumento sintáctico</para>
    ///   <para>rdfs:comment : The object property synArg relates a syntactic frame to one of its syntactic arguments.rdfs:comment : Свойство объекта 'synArg' связывает синтаксический фрейм с одним из его синтаксических аргументов.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/synsem#synArg">synsem:synArg</a>
    /// </summary>
    let synArg = _prefixId.prefix "synArg"
    /// <summary>
    ///   <para>rdfs:label : comportament sintacticrdfs:label : syntaktiskt beteenderdfs:label : syntaktisches Verhaltenrdfs:label : синтаксическое поведениеrdfs:label : syntactic behaviorrdfs:label : sintaktiese dedragrdfs:label : comportamento sintatticordfs:label : funcionamiento sintácticordfs:label : comportamento sintaticordfs:label : syntactisch optredenrdfs:label : conduite syntaxique</para>
    ///   <para>rdfs:comment : Свойство 'синтаксическое поведение' связывает лексическую запись с одним из ее синтаксических типов поведения, захваченных синтаксическим фреймом.rdfs:comment : The 'syntactic behavior' property relates a lexical entry to one of its syntactic behaviors as captured by a syntactic frame.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/synsem#synBehavior">synsem:synBehavior</a>
    /// </summary>
    let synBehavior = _prefixId.prefix "synBehavior"
