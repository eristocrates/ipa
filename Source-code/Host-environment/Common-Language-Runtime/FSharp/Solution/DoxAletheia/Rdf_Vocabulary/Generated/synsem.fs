namespace http.www.w3.org.ns.lemon.synsem.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module synsem =
    let _namespace_iri = Namespace_Iri synsem |> NamespaceIRI
    /// <summary>
    ///   <para>synsem:condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The 'condition' property defines an evaluable constraint that derives from using a certain lexical entry to express a given ontological predicate.</para>
    ///   <para>Свойство 'состояние' определяет оценочное ограничение, которое получается из использования определенной словарной единицы для выражения заданного онтологического предиката.</para>
    /// labels<para>condizione</para><para>voorwaarde</para><para>voorwaarde</para><para>condition</para><para>состояние</para><para>Bedingung</para><para>condición</para><para>condition</para><para>condiție</para><para>condição</para><para>villkor</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/synsem#condition">http://www.w3.org/ns/lemon/synsem#condition</seealso>
    let condition = Prefixed_Name(synsem, "condition") |> PrefixedName
    /// <summary>
    ///   <para>synsem:OntoMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An 'ontology mapping' (OntoMap for short) specifies how a syntactic frame and its syntactic arguments map to a set of concepts and properties in the ontology that together specify the meaning of the syntactic frame.</para>
    ///   <para>'Отображение онтологии' (OntoMap для краткости) определяет, как синтаксический фрейм и его синтаксические аргументы сопоставляются с набором понятий и свойств в онтологии, которые вместе определяют значение синтаксического фрейма.</para>
    /// labels<para>applicación de l'ontología</para><para>application de l'ontologie</para><para>отображение онтологии</para><para>mappa de l'ontologia</para><para>ontologieafbeelding</para><para>Ontologieabbildung</para><para>ontology mapping</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/synsem#OntoMap">http://www.w3.org/ns/lemon/synsem#OntoMap</seealso>
    let OntoMap = Prefixed_Name(synsem, "OntoMap") |> PrefixedName
    /// <summary>
    ///   <para>synsem:SyntacticArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>'Синтаксический аргумент' представляет собой слот, который необходимо заполнить для получения определенного синтаксического фрейма. Синтаксические аргументы обычно реализуют определенную грамматическую функцию (например, субъект, прямой объект, косвенный объект, предпозиционный объект и т.д.).</para>
    ///   <para>A 'syntactic argument' represents a slot that needs to be filled for a certain syntactic frame to be complete. Syntactic arguments typically realize a certain grammatical function (e.g. subject, direct object, indirect object, prepositional object, etc.).</para>
    /// labels<para>синтаксический аргумент</para><para>syntaktisches Argument</para><para>sintaktiese argument</para><para>argumento sintáctico</para><para>syntaktiskt argument</para><para>argomento sintattico</para><para>syntactisch argument</para><para>argumento sintatico</para><para>argument sintactic</para><para>Syntactic Argument</para><para>actant syntaxique</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/synsem#SyntacticArgument">http://www.w3.org/ns/lemon/synsem#SyntacticArgument</seealso>
    let SyntacticArgument = Prefixed_Name(synsem, "SyntacticArgument") |> PrefixedName
    /// <summary>
    ///   <para>synsem:SyntacticFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A 'syntactic frame' represents the syntactic behavior of an open class word in terms of the (syntactic) arguments it requires. It essentially describes the so called subcategorization structure of the word in question, in particular the syntactic arguments it requires.</para>
    ///   <para>'Синтаксический фрейм' представляет синтаксическое поведение открытого слова класса в терминах (синтаксических) аргументов, которые ему необходимы. Он по существу описывает так называемую структуру подкатегоризации рассматриваемого слова, в частности синтаксические аргументы, которые он требует.</para>
    /// labels<para>синтаксический фрейм</para><para>syntaktisches Frame</para><para>marco sintáctico</para><para>cadre syntaxique</para><para>Syntactic Frame</para><para>frame</para><para>cadru</para><para>raam</para><para>raam</para><para>ram</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/synsem#SyntacticFrame">http://www.w3.org/ns/lemon/synsem#SyntacticFrame</seealso>
    let SyntacticFrame = Prefixed_Name(synsem, "SyntacticFrame") |> PrefixedName
    /// <summary>
    ///   <para>synsem:isA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The 'is a' property represents the single argument of a class or unary  predicate.</para>
    ///   <para>Свойство 'экземпляр' представляет одиночный аргумент класса или унарный предикат.</para>
    /// labels<para>instantie van</para><para>instansie van</para><para>Instancia de</para><para>instanz von</para><para>Instance de</para><para>instanță a</para><para>istanza di</para><para>экземпляр</para><para>är en</para><para>é um</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/synsem#isA">http://www.w3.org/ns/lemon/synsem#isA</seealso>
    let isA = Prefixed_Name(synsem, "isA") |> PrefixedName
    /// <summary>
    ///   <para>synsem:ontoCorrespondence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Свойство 'онтологическая переписка' связывает аргумент предиката, определенного в онтологии, с синтаксическим аргументом, который синтаксически реализует этот предикат.</para>
    ///   <para>The 'ontoCorrespondence' property binds an argument of a predicate defined in the ontology to a syntactic argument that realizes this predicate argument syntactically.</para>
    /// labels<para>ontologische correspondentie</para><para>correspondencia ontológica</para><para>ontological correspondence</para><para>ontologische Korrespondenz</para><para>correspondance ontologique</para><para>corrispondenza ontologica</para><para>онтологическая переписка</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/synsem#ontoCorrespondence">http://www.w3.org/ns/lemon/synsem#ontoCorrespondence</seealso>
    let ontoCorrespondence = Prefixed_Name(synsem, "ontoCorrespondence") |> PrefixedName
    /// <summary>
    ///   <para>synsem:marker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Свойство 'маркер' указывает маркер синтаксического аргумента; Это может быть маркер падежа или какая-то другая словарная единица, такая как предлог или частица.</para>
    ///   <para>The 'marker' property indicates the marker of a syntactic argument; this can be a case marker or some other lexical entry such as a preposition or particle.</para>
    /// labels<para>marcatore</para><para>marqueur</para><para>marcator</para><para>marcador</para><para>marcado</para><para>merker</para><para>маркер</para><para>Marker</para><para>marker</para><para>markör</para><para>merker</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/synsem#marker">http://www.w3.org/ns/lemon/synsem#marker</seealso>
    let marker = Prefixed_Name(synsem, "marker") |> PrefixedName
    /// <summary>
    ///   <para>synsem:ontoMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Свойство 'onMapping' связывает отображение онтологии с соответствующим ему лексическим смыслом.</para>
    ///   <para>The 'ontoMapping'  property relates an ontology mapping to its corresponding lexical sense.</para>
    /// labels<para>applicación de l'ontología</para><para>application de l'ontologie</para><para>отображение онтологии</para><para>mappa de l'ontologia</para><para>ontologieafbeelding</para><para>Ontologieabbildung</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/synsem#ontoMapping">http://www.w3.org/ns/lemon/synsem#ontoMapping</seealso>
    let ontoMapping = Prefixed_Name(synsem, "ontoMapping") |> PrefixedName
    /// <summary>
    ///   <para>synsem:objOfProp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The 'objOfProp' represents the 2nd argument or object of a binary predicate (property) in the ontology.</para>
    ///   <para>'Объект свойства' представляет 2-й аргумент или объект бинарного предиката (свойства) в онтологии.</para>
    /// labels<para>complemento de la propiedad</para><para>complément de la propriété</para><para>oggetto della proprietà</para><para>obiect al proprietății</para><para>voorwerp van predikaat</para><para>objekt des Prädikats</para><para>object van predikaat</para><para>objekt av predikat</para><para>object of property</para><para>объект свойства</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/synsem#objOfProp">http://www.w3.org/ns/lemon/synsem#objOfProp</seealso>
    let objOfProp = Prefixed_Name(synsem, "objOfProp") |> PrefixedName
    /// <summary>
    ///   <para>synsem:optional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The 'optional' property indicates whether a syntactic argument is optional, that is, it can be syntactically omitted.</para>
    ///   <para>Свойство 'опциональный' указывает, является ли синтаксический аргумент необязательным, то есть его можно синтаксически исключить.</para>
    /// labels<para>опциональный</para><para>facultativ</para><para>optionell</para><para>opzionale</para><para>optioneel</para><para>opsioneel</para><para>optionnel</para><para>optional</para><para>opcional</para><para>optional</para><para>opcional</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/synsem#optional">http://www.w3.org/ns/lemon/synsem#optional</seealso>
    let optional = Prefixed_Name(synsem, "optional") |> PrefixedName
    /// <summary>
    ///   <para>synsem:propertyDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>'Property domain' provides a pragmatic restriction on the domain of the property referred to by this sense.</para>
    ///   <para>'Свойство домена' обеспечивает прагматическое ограничение на область свойства, на которое ссылается этот смысл.</para>
    /// labels<para>Definitionsbereich des Prädikats</para><para>ensemble de la propriété</para><para>predikaatdefinisiegebied</para><para>dominio de la propiedad</para><para>domeniul proprietății</para><para>domein van predikaat</para><para>dominio di proprietà</para><para>property domain</para><para>свойство домена</para><para>relationsdomän</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/synsem#propertyDomain">http://www.w3.org/ns/lemon/synsem#propertyDomain</seealso>
    let propertyDomain = Prefixed_Name(synsem, "propertyDomain") |> PrefixedName
    /// <summary>
    ///   <para>synsem:propertyRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>'Property domain' provides a pragmatic restriction on the range of the property referred to by this sense.</para>
    ///   <para>'Диапазон свойства' обеспечивает прагматическое ограничение на область диапазона,на которое ссылается этот смысл.</para>
    /// labels<para>Wertemenge des Prädikats</para><para>codominio di proprietà</para><para>image de la propriété</para><para>predikaatwaardegebied</para><para>rango de la propiedad</para><para>bereik van predikaat</para><para>relationsräckvidd</para><para>диапазон свойства</para><para>gama proprietății</para><para>property range</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/synsem#propertyRange">http://www.w3.org/ns/lemon/synsem#propertyRange</seealso>
    let propertyRange = Prefixed_Name(synsem, "propertyRange") |> PrefixedName
    /// <summary>
    ///   <para>synsem:submap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Свойство 'submap' связывает (сложное) онтологическое отображение с набором привязок, которые вместе связывают аргументы задействованных предикатов с набором синтаксических аргументов, которые реализуют их синтаксически.</para>
    ///   <para>The 'submap' property relates a (complex) ontological mapping to a set of bindings that together bind the arguments of the involved predicates to a set of syntactic arguments that realize them syntactically.</para>
    /// labels<para>cadre composante</para><para>parte del marco</para><para>underbetydelse</para><para>deelraam</para><para>subframe</para><para>Subframe</para><para>submap</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/synsem#submap">http://www.w3.org/ns/lemon/synsem#submap</seealso>
    let submap = Prefixed_Name(synsem, "submap") |> PrefixedName
    /// <summary>
    ///   <para>synsem:subjOfProp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The 'subjOfProp' property represents the 1st argument or subject of a binary predicate (property) in the ontology.</para>
    ///   <para>Свойство 'subjOfProp' представляет 1-й аргумент или субъект бинарного предиката (свойства) в онтологии.</para>
    /// labels<para>soggetto della proprietà</para><para>onderwerp van predikaat</para><para>onderwerp van predikaat</para><para>sujeto de la propiedad</para><para>subiectul proprietații</para><para>Subjekt des Prädikats</para><para>sujet de la propriété</para><para>subject of property</para><para>subjekt av predikat</para><para>субъект свойства</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/synsem#subjOfProp">http://www.w3.org/ns/lemon/synsem#subjOfProp</seealso>
    let subjOfProp = Prefixed_Name(synsem, "subjOfProp") |> PrefixedName
    /// <summary>
    ///   <para>synsem:synBehavior</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The 'syntactic behavior' property relates a lexical entry to one of its syntactic behaviors as captured by a syntactic frame.</para>
    ///   <para>Свойство 'синтаксическое поведение' связывает лексическую запись с одним из ее синтаксических типов поведения, захваченных синтаксическим фреймом.</para>
    /// labels<para>funcionamiento sintáctico</para><para>синтаксическое поведение</para><para>comportamento sintattico</para><para>comportamento sintatico</para><para>syntaktisches Verhalten</para><para>comportament sintactic</para><para>syntactisch optreden</para><para>syntaktiskt beteende</para><para>conduite syntaxique</para><para>syntactic behavior</para><para>sintaktiese dedrag</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/synsem#synBehavior">http://www.w3.org/ns/lemon/synsem#synBehavior</seealso>
    let synBehavior = Prefixed_Name(synsem, "synBehavior") |> PrefixedName
    /// <summary>
    ///   <para>synsem:synArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Свойство объекта 'synArg' связывает синтаксический фрейм с одним из его синтаксических аргументов.</para>
    ///   <para>The object property synArg relates a syntactic frame to one of its syntactic arguments.</para>
    /// labels<para>синтаксический аргумент</para><para>syntaktisches Argument</para><para>syntaktiskt argument</para><para>sintaktiese argument</para><para>syntactisch argument</para><para>argumento sintáctico</para><para>argomento sintattico</para><para>argumento sintatico</para><para>syntactic argument</para><para>argument sintactic</para><para>actant syntaxique</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/synsem#synArg">http://www.w3.org/ns/lemon/synsem#synArg</seealso>
    let synArg = Prefixed_Name(synsem, "synArg") |> PrefixedName
