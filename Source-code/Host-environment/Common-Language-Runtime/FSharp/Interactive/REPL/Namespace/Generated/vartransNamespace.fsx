#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vartrans =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/ns/lemon/vartrans#" "vartrans"

    /// <summary>
    ///   <para>rdfs:label : relación entre conceptosrdfs:label : Konzeptbeziehungrdfs:label : conceptual relationrdfs:label : relazione di concettirdfs:label : отношение понятийrdfs:label : conceptrelatie</para>
    ///   <para>rdfs:comment : Отношение между двумя понятиямиrdfs:comment : A relationship between two concepts</para>
    ///   <a href="http://www.w3.org/ns/lemon/vartrans#ConceptualRelation">vartrans:ConceptualRelation</a>
    /// </summary>
    let ConceptualRelation = _prefixId.prefix "ConceptualRelation"
    /// <summary>
    ///   <para>rdfs:label : lexical relationrdfs:label : lexikalische Beziehungrdfs:label : lexikaal relatierdfs:label : relation lexicalerdfs:label : relație lexicalărdfs:label : lexikalisk relationrdfs:label : relação semanticardfs:label : лексическое отношениеrdfs:label : relación léxicardfs:label : relazione lessicalerdfs:label : leksikale relasie</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 'Лексическое отношение' - это лексико-семантическое отношение, которое представляет собой отношение между двумя словарными единицами, поверхностные формы которых связаны грамматически, стилистически или неким процессом, обусловленным лингвистической экономией.rdfs:comment : A 'lexical relation' is a lexico-semantic relation that represents the relation between two lexical entries the surface forms of which are related grammatically, stylistically or by some operation motivated by linguistic economy.</para>
    ///   <a href="http://www.w3.org/ns/lemon/vartrans#LexicalRelation">vartrans:LexicalRelation</a>
    /// </summary>
    let LexicalRelation = _prefixId.prefix "LexicalRelation"
    /// <summary>
    ///   <para>rdfs:label : relação lexica semanticardfs:label : relație lexico-semanticărdfs:label : лексико-семантическое отношениеrdfs:label : lexikalisk-semantisk relationrdfs:label : lexikosemantische Beziehungrdfs:label : lexico-semantic relationrdfs:label : lexikosemantische relatierdfs:label : leksikosemantiese relasierdfs:label : relation lexico-sémantiquerdfs:label : relazione lessico-semanticardfs:label : relación léxico semántica</para>
    ///   <para>rdfs:comment : 'Лексико-семантическое отношение' представляет собой связь между двумя словарными единицами или лексическими смыслами, которые связаны некими лексическими или семантическими отношениями.rdfs:comment : A 'lexico-semantic relation' represents the relation between two lexical entries or lexical senses that are related by some lexical or semantic relationship.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/vartrans#LexicoSemanticRelation">vartrans:LexicoSemanticRelation</a>
    /// </summary>
    let LexicoSemanticRelation = _prefixId.prefix "LexicoSemanticRelation"
    /// <summary>
    ///   <para>rdfs:comment : 'Отношение смыслов' (SenseRelation) - это лексико-семантическое отношение, которое представляет собой связь между двумя лексическими смыслами, значения которых связаны между собой.rdfs:comment : A 'sense relation' is a lexico-semantic relation that represents the relation between two lexical senses the meanings of which are related.</para>
    ///   <para>rdfs:label : отношение смысловrdfs:label : relación entre acepcionesrdfs:label : relație de sensrdfs:label : sense relationrdfs:label : betydelserelationrdfs:label : relation sémantiquerdfs:label : relação semanticardfs:label : sinnrelatierdfs:label : relazione di sensirdfs:label : Sinnbeziehungrdfs:label : sinsrelasie</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/vartrans#SenseRelation">vartrans:SenseRelation</a>
    /// </summary>
    let SenseRelation = _prefixId.prefix "SenseRelation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : variante terminológicardfs:label : variantă terminologicărdfs:label : variante terminologiquerdfs:label : terminologiese variantrdfs:label : terminologische variantrdfs:label : terminologische Varianterdfs:label : variante terminologicardfs:label : variante terminologicardfs:label : terminological relationrdfs:label : terminologivariantrdfs:label : терминологическое отношение</para>
    ///   <para>rdfs:comment : A 'terminological relation' is a sense relation that relates two lexical senses of terms that are semantically related in the sense that they can be exchanged in most contexts, but their surface forms are not directly related. The variants vary along dimensions that are not captured by the given ontology and are intentionally (pragmatically) caused.rdfs:comment : 'Терминологическое отношение' - это смысловое отношение, которое связывает два лексических смысла терминов, семантически связанных в том смысле, что они могут взаимозаменяться в большинстве контекстов, но их поверхностные (внешние) формы непосредственно не связаны. В форматах, не фиксируемых в данной онтологии и намеренно (прагматически) обусловленных, данные варианты разнятся (отличаются).</para>
    ///   <a href="http://www.w3.org/ns/lemon/vartrans#TerminologicalRelation">vartrans:TerminologicalRelation</a>
    /// </summary>
    let TerminologicalRelation = _prefixId.prefix "TerminologicalRelation"
    /// <summary>
    ///   <para>rdfs:label : Übersetzungrdfs:label : traduçãordfs:label : vertalingrdfs:label : vertalingrdfs:label : переводrdfs:label : traducciónrdfs:label : traductionrdfs:label : translationrdfs:label : traducererdfs:label : versättningrdfs:label : traduzione</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : 'Перевод' представляет собой 'отношение смыслов', показывающее, что два лексических смысла, соответствующие двум словарным единицам в разных языках, могут быть взаимно переведены без каких-либо существенных искажений смысла.rdfs:comment : A 'translation' is a 'sense relation' expressing that two lexical senses corresponding to two lexical entries in different languages can be translated to each other without any major meaning shifts.</para>
    ///   <a href="http://www.w3.org/ns/lemon/vartrans#Translation">vartrans:Translation</a>
    /// </summary>
    let Translation = _prefixId.prefix "Translation"
    /// <summary>
    ///   <para>rdfs:label : conjunto de traduccionesrdfs:label : banque de traductionsrdfs:label : Übersetzungsatzrdfs:label : translation setrdfs:label : bance traduzionirdfs:label : verzameling van vertalingenrdfs:label : набор переводов</para>
    ///   <para>rdfs:comment : 'Набор переводов' - это совокупность переводов, которые имеют общий источник.rdfs:comment : A 'translation set' is a set of translations that have some common source.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/vartrans#TranslationSet">vartrans:TranslationSet</a>
    /// </summary>
    let TranslationSet = _prefixId.prefix "TranslationSet"
    /// <summary>
    ///   <para>rdfs:comment : The 'category' property indicates the specific type of relation by which two lexical entries or two lexical senses are related.rdfs:comment : Свойство 'категория' указывает конкретный тип отношения, которым связаны две словарные единицы или два лексических смысла.</para>
    ///   <para>rdfs:label : kategorirdfs:label : contexterdfs:label : categoryrdfs:label : categoríardfs:label : categoriardfs:label : categoriardfs:label : Kategorierdfs:label : kategorierdfs:label : categorierdfs:label : categorierdfs:label : категория</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/vartrans#category">vartrans:category</a>
    /// </summary>
    let category = _prefixId.prefix "category"
    /// <summary>
    ///   <para>rdfs:label : relación entre conceptosrdfs:label : relazione di concettirdfs:label : отношение понятийrdfs:label : Konzeptbeziehungrdfs:label : concept relationrdfs:label : conceptrelatie</para>
    ///   <para>rdfs:comment : A relationship between two conceptsrdfs:comment : Отношения между двумя понятиями</para>
    ///   <a href="http://www.w3.org/ns/lemon/vartrans#conceptRel">vartrans:conceptRel</a>
    /// </summary>
    let conceptRel = _prefixId.prefix "conceptRel"
    let imports = _prefixId.prefix "imports"
    /// <summary>
    ///   <para>rdfs:comment : The 'lexicalRel' property relates two lexical entries that stand in some lexical relation.rdfs:comment : Свойство 'lexicalRel' связывает две словарных единицы, которые находятся в некотором лексическом отношении.</para>
    ///   <para>rdfs:label : лексическое отношениеrdfs:label : lexikalische Beziehungrdfs:label : lexikaal relatierdfs:label : relación léxicardfs:label : lexical relationrdfs:label : relation lexicalerdfs:label : relazione lessicale</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/vartrans#lexicalRel">vartrans:lexicalRel</a>
    /// </summary>
    let lexicalRel = _prefixId.prefix "lexicalRel"
    /// <summary>
    ///   <para>rdfs:label : relatesrdfs:label : relateertrdfs:label : beziehtrdfs:label : relaterdfs:label : связываетrdfs:label : relacionardfs:label : rapporta</para>
    ///   <para>rdfs:comment : The 'relates' property links a lexico-semantic relation to the two lexical entries or lexical senses between which it establishes the relation.rdfs:comment : Свойство 'связывает' связывает лексико-семантическим отношением две словарные единицы или два лексических смысла, между которыми оно (данное свойство) устанавливает отношение.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/vartrans#relates">vartrans:relates</a>
    /// </summary>
    let relates = _prefixId.prefix "relates"
    /// <summary>
    ///   <para>rdfs:label : Sinnbeziehungrdfs:label : sinnrelatierdfs:label : отношение смысловrdfs:label : sense relationrdfs:label : relation sémantiquerdfs:label : relación entre acepcionesrdfs:label : relazione di sensi</para>
    ///   <para>rdfs:comment : Свойство 'отношение смыслов' (senseRel) связывает два лексических смысла, которые находятся в некоторой смысловой связи.rdfs:comment : The 'senseRel' property relates two lexical senses that stand in some sense relation.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/vartrans#senseRel">vartrans:senseRel</a>
    /// </summary>
    let senseRel = _prefixId.prefix "senseRel"
    /// <summary>
    ///   <para>rdfs:comment : Свойство 'источник' обозначает лексический смысл или словарную единицу, вовлеченную в лексико-семантическое отношение как 'источник'.rdfs:comment : The 'source' property indicates the lexical sense or lexical entry involved in a lexico-semantic relation as a 'source'.</para>
    ///   <para>rdfs:label : sourcerdfs:label : sourcerdfs:label : källardfs:label : источникrdfs:label : originerdfs:label : sursărdfs:label : origemrdfs:label : origenrdfs:label : Quellerdfs:label : bronrdfs:label : bron</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/vartrans#source">vartrans:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:label : doelrdfs:label : doelrdfs:label : målrdfs:label : цельrdfs:label : destinordfs:label : destinordfs:label : destinazionerdfs:label : Zielrdfs:label : targetrdfs:label : destinationrdfs:label : ţintă</para>
    ///   <para>rdfs:comment : Свойство 'цель' обозначает лексический смысл или словарную единицу, вовлеченную в лексико-семантическое отношение как 'цель'.rdfs:comment : The 'target' property indicates the lexical sense or lexical entry involved in a lexico-semantic relation as a 'target'.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/vartrans#target">vartrans:target</a>
    /// </summary>
    let target = _prefixId.prefix "target"
    /// <summary>
    ///   <para>rdfs:label : translationrdfs:label : traducererdfs:label : traducciónrdfs:label : versättningrdfs:label : traductionrdfs:label : traduzionerdfs:label : traduçãordfs:label : переводrdfs:label : Übersetzungrdfs:label : vertalingrdfs:label : vertaling</para>
    ///   <para>rdfs:comment : Свойство 'перевод' связывает НаборПереводов с одним из его переводов.rdfs:comment : The property 'trans' relates a TranslationSet to one of its translations.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/vartrans#trans">vartrans:trans</a>
    /// </summary>
    let trans = _prefixId.prefix "trans"
    /// <summary>
    ///   <para>rdfs:label : übersetzbar alsrdfs:label : traducibile comerdfs:label : traduzivel comordfs:label : vertaalbar alsrdfs:label : traductibil cardfs:label : traducibile comordfs:label : översättbar somrdfs:label : переводится какrdfs:label : traduisible parrdfs:label : vertaalbaar Asrdfs:label : translatable as</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Свойство 'переводится как' связывает словарную единицу на каком-либо языке со словарной единицей на другом языке, на который она может быть переведена соответствующим образом в зависимости от конкретного контекста и специфических смыслов данных словарных единиц.rdfs:comment : The 'translatableAs' property relates a lexical entry in some language to a lexical entry in another language that it can be translated as depending on the particular context and specific senses of the involved lexical entries.</para>
    ///   <a href="http://www.w3.org/ns/lemon/vartrans#translatableAs">vartrans:translatableAs</a>
    /// </summary>
    let translatableAs = _prefixId.prefix "translatableAs"
    /// <summary>
    ///   <para>rdfs:label : Übersetzungrdfs:label : traducciónrdfs:label : traduzionerdfs:label : vertalingrdfs:label : translationrdfs:label : vertalingrdfs:label : traduçãordfs:label : versättningrdfs:label : traducererdfs:label : переводrdfs:label : traduction</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The 'translation' property relates two lexical senses of two lexical entries that stand in a translation relation to one another. rdfs:comment : Свойство 'перевод' связывает два лексических смысла двух словарных единиц, которые находятся в отношении перевода друг к другу.</para>
    ///   <a href="http://www.w3.org/ns/lemon/vartrans#translation">vartrans:translation</a>
    /// </summary>
    let translation = _prefixId.prefix "translation"
    let versionInfo = _prefixId.prefix "versionInfo"
