namespace http.www.w3.org.ns.lemon.vartrans.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vartrans =
    let _namespace_iri = Namespace_Iri vartrans |> NamespaceIRI

    /// <summary>
    ///   <para>vartrans:ConceptualRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A relationship between two concepts"</para>
    ///   <para>"Отношение между двумя понятиями"</para>
    /// labels<para>"conceptual relation"</para><para>"Konzeptbeziehung"</para><para>"relazione di concetti"</para><para>"relación entre conceptos"</para><para>"conceptrelatie"</para><para>"отношение понятий"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/vartrans#ConceptualRelation">http://www.w3.org/ns/lemon/vartrans#ConceptualRelation</seealso>
    let ConceptualRelation =
        Prefixed_Name(vartrans, "ConceptualRelation") |> PrefixedName

    /// <summary>
    ///   <para>vartrans:LexicalRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"'Лексическое отношение' - это лексико-семантическое отношение, которое представляет собой отношение между двумя словарными единицами, поверхностные формы которых связаны грамматически, стилистически или неким процессом, обусловленным лингвистической экономией."</para>
    ///   <para>"A 'lexical relation' is a lexico-semantic relation that represents the relation between two lexical entries the surface forms of which are related grammatically, stylistically or by some operation motivated by linguistic economy."</para>
    /// labels<para>"lexikaal relatie"</para><para>"relation lexicale"</para><para>"relazione lessicale"</para><para>"lexical relation"</para><para>"relación léxica"</para><para>"lexikalisk relation"</para><para>"лексическое отношение"</para><para>"leksikale relasie"</para><para>"relație lexicală"</para><para>"lexikalische Beziehung"</para><para>"relação semantica"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/vartrans#LexicalRelation">http://www.w3.org/ns/lemon/vartrans#LexicalRelation</seealso>
    let LexicalRelation = Prefixed_Name(vartrans, "LexicalRelation") |> PrefixedName

    /// <summary>
    ///   <para>vartrans:LexicoSemanticRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A 'lexico-semantic relation' represents the relation between two lexical entries or lexical senses that are related by some lexical or semantic relationship."</para>
    ///   <para>"'Лексико-семантическое отношение' представляет собой связь между двумя словарными единицами или лексическими смыслами, которые связаны некими лексическими или семантическими отношениями."</para>
    /// labels<para>"lexikalisk-semantisk relation"</para><para>"relation lexico-sémantique"</para><para>"лексико-семантическое отношение"</para><para>"lexikosemantische Beziehung"</para><para>"relație lexico-semantică"</para><para>"leksikosemantiese relasie"</para><para>"lexikosemantische relatie"</para><para>"relazione lessico-semantica"</para><para>"lexico-semantic relation"</para><para>"relación léxico semántica"</para><para>"relação lexica semantica"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/vartrans#LexicoSemanticRelation">http://www.w3.org/ns/lemon/vartrans#LexicoSemanticRelation</seealso>
    let LexicoSemanticRelation =
        Prefixed_Name(vartrans, "LexicoSemanticRelation") |> PrefixedName

    /// <summary>
    ///   <para>vartrans:SenseRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"'Отношение смыслов' (SenseRelation) - это лексико-семантическое отношение, которое представляет собой связь между двумя лексическими смыслами, значения которых связаны между собой."</para>
    ///   <para>"A 'sense relation' is a lexico-semantic relation that represents the relation between two lexical senses the meanings of which are related."</para>
    /// labels<para>"relazione di sensi"</para><para>"betydelserelation"</para><para>"relação semantica"</para><para>"отношение смыслов"</para><para>"Sinnbeziehung"</para><para>"sinnrelatie"</para><para>"sinsrelasie"</para><para>"relație de sens"</para><para>"sense relation"</para><para>"relación entre acepciones"</para><para>"relation sémantique"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/vartrans#SenseRelation">http://www.w3.org/ns/lemon/vartrans#SenseRelation</seealso>
    let SenseRelation = Prefixed_Name(vartrans, "SenseRelation") |> PrefixedName

    /// <summary>
    ///   <para>vartrans:TerminologicalRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"'Терминологическое отношение' - это смысловое отношение, которое связывает два лексических смысла терминов, семантически связанных в том смысле, что они могут взаимозаменяться в большинстве контекстов, но их поверхностные (внешние) формы непосредственно не связаны. В форматах, не фиксируемых в данной онтологии и намеренно (прагматически) обусловленных, данные варианты разнятся (отличаются)."</para>
    ///   <para>"A 'terminological relation' is a sense relation that relates two lexical senses of terms that are semantically related in the sense that they can be exchanged in most contexts, but their surface forms are not directly related. The variants vary along dimensions that are not captured by the given ontology and are intentionally (pragmatically) caused."</para>
    /// labels<para>"terminologische Variante"</para><para>"variantă terminologică"</para><para>"терминологическое отношение"</para><para>"terminologische variant"</para><para>"variante terminológica"</para><para>"terminological relation"</para><para>"variante terminologique"</para><para>"terminologivariant"</para><para>"terminologiese variant"</para><para>"variante terminologica"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/vartrans#TerminologicalRelation">http://www.w3.org/ns/lemon/vartrans#TerminologicalRelation</seealso>
    let TerminologicalRelation =
        Prefixed_Name(vartrans, "TerminologicalRelation") |> PrefixedName

    /// <summary>
    ///   <para>vartrans:Translation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A 'translation' is a 'sense relation' expressing that two lexical senses corresponding to two lexical entries in different languages can be translated to each other without any major meaning shifts."</para>
    ///   <para>"'Перевод' представляет собой 'отношение смыслов', показывающее, что два лексических смысла, соответствующие двум словарным единицам в разных языках, могут быть взаимно переведены без каких-либо существенных искажений смысла."</para>
    /// labels<para>"tradução"</para><para>"перевод"</para><para>"vertaling"</para><para>"traducere"</para><para>"traduzione"</para><para>"Übersetzung"</para><para>"traduction"</para><para>"traducción"</para><para>"translation"</para><para>"versättning"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/vartrans#Translation">http://www.w3.org/ns/lemon/vartrans#Translation</seealso>
    let Translation = Prefixed_Name(vartrans, "Translation") |> PrefixedName
    /// <summary>
    ///   <para>vartrans:TranslationSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"'Набор переводов' - это совокупность переводов, которые имеют общий источник."</para>
    ///   <para>"A 'translation set' is a set of translations that have some common source."</para>
    /// labels<para>"conjunto de traducciones"</para><para>"translation set"</para><para>"bance traduzioni"</para><para>"набор переводов"</para><para>"Übersetzungsatz"</para><para>"banque de traductions"</para><para>"verzameling van vertalingen"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/vartrans#TranslationSet">http://www.w3.org/ns/lemon/vartrans#TranslationSet</seealso>
    let TranslationSet = Prefixed_Name(vartrans, "TranslationSet") |> PrefixedName
    /// <summary>
    ///   <para>vartrans:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The 'category' property indicates the specific type of relation by which two lexical entries or two lexical senses are related."</para>
    ///   <para>"Свойство 'категория' указывает конкретный тип отношения, которым связаны две словарные единицы или два лексических смысла."</para>
    /// labels<para>"kategorie"</para><para>"Kategorie"</para><para>"categoria"</para><para>"categorie"</para><para>"contexte"</para><para>"категория"</para><para>"kategori"</para><para>"category"</para><para>"categoría"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/vartrans#category">http://www.w3.org/ns/lemon/vartrans#category</seealso>
    let category = Prefixed_Name(vartrans, "category") |> PrefixedName
    /// <summary>
    ///   <para>vartrans:conceptRel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between two concepts"</para>
    ///   <para>"Отношения между двумя понятиями"</para>
    /// labels<para>"conceptrelatie"</para><para>"relación entre conceptos"</para><para>"relazione di concetti"</para><para>"concept relation"</para><para>"отношение понятий"</para><para>"Konzeptbeziehung"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/vartrans#conceptRel">http://www.w3.org/ns/lemon/vartrans#conceptRel</seealso>
    let conceptRel = Prefixed_Name(vartrans, "conceptRel") |> PrefixedName
    /// <summary>
    ///   <para>vartrans:imports</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/vartrans#imports">http://www.w3.org/ns/lemon/vartrans#imports</seealso>
    let imports = Prefixed_Name(vartrans, "imports") |> PrefixedName
    /// <summary>
    ///   <para>vartrans:lexicalRel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Свойство 'lexicalRel' связывает две словарных единицы, которые находятся в некотором лексическом отношении."</para>
    ///   <para>"The 'lexicalRel' property relates two lexical entries that stand in some lexical relation."</para>
    /// labels<para>"lexical relation"</para><para>"lexikalische Beziehung"</para><para>"relación léxica"</para><para>"relation lexicale"</para><para>"лексическое отношение"</para><para>"lexikaal relatie"</para><para>"relazione lessicale"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/vartrans#lexicalRel">http://www.w3.org/ns/lemon/vartrans#lexicalRel</seealso>
    let lexicalRel = Prefixed_Name(vartrans, "lexicalRel") |> PrefixedName
    /// <summary>
    ///   <para>vartrans:relates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Свойство 'связывает' связывает лексико-семантическим отношением две словарные единицы или два лексических смысла, между которыми оно (данное свойство) устанавливает отношение."</para>
    ///   <para>"The 'relates' property links a lexico-semantic relation to the two lexical entries or lexical senses between which it establishes the relation."</para>
    /// labels<para>"relate"</para><para>"relaciona"</para><para>"связывает"</para><para>"relates"</para><para>"relateert"</para><para>"bezieht"</para><para>"rapporta"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/vartrans#relates">http://www.w3.org/ns/lemon/vartrans#relates</seealso>
    let relates = Prefixed_Name(vartrans, "relates") |> PrefixedName
    /// <summary>
    ///   <para>vartrans:senseRel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Свойство 'отношение смыслов' (senseRel) связывает два лексических смысла, которые находятся в некоторой смысловой связи."</para>
    ///   <para>"The 'senseRel' property relates two lexical senses that stand in some sense relation."</para>
    /// labels<para>"sense relation"</para><para>"отношение смыслов"</para><para>"relación entre acepciones"</para><para>"relation sémantique"</para><para>"relazione di sensi"</para><para>"Sinnbeziehung"</para><para>"sinnrelatie"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/vartrans#senseRel">http://www.w3.org/ns/lemon/vartrans#senseRel</seealso>
    let senseRel = Prefixed_Name(vartrans, "senseRel") |> PrefixedName
    /// <summary>
    ///   <para>vartrans:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Свойство 'источник' обозначает лексический смысл или словарную единицу, вовлеченную в лексико-семантическое отношение как 'источник'."</para>
    ///   <para>"The 'source' property indicates the lexical sense or lexical entry involved in a lexico-semantic relation as a 'source'."</para>
    /// labels<para>"origen"</para><para>"Quelle"</para><para>"source"</para><para>"origine"</para><para>"источник"</para><para>"origem"</para><para>"sursă"</para><para>"bron"</para><para>"källa"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/vartrans#source">http://www.w3.org/ns/lemon/vartrans#source</seealso>
    let source = Prefixed_Name(vartrans, "source") |> PrefixedName
    /// <summary>
    ///   <para>vartrans:target</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The 'target' property indicates the lexical sense or lexical entry involved in a lexico-semantic relation as a 'target'."</para>
    ///   <para>"Свойство 'цель' обозначает лексический смысл или словарную единицу, вовлеченную в лексико-семантическое отношение как 'цель'."</para>
    /// labels<para>"target"</para><para>"destino"</para><para>"Ziel"</para><para>"цель"</para><para>"destination"</para><para>"mål"</para><para>"destinazione"</para><para>"doel"</para><para>"ţintă"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/vartrans#target">http://www.w3.org/ns/lemon/vartrans#target</seealso>
    let target = Prefixed_Name(vartrans, "target") |> PrefixedName
    /// <summary>
    ///   <para>vartrans:trans</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property 'trans' relates a TranslationSet to one of its translations."</para>
    ///   <para>"Свойство 'перевод' связывает НаборПереводов с одним из его переводов."</para>
    /// labels<para>"traduzione"</para><para>"vertaling"</para><para>"translation"</para><para>"перевод"</para><para>"tradução"</para><para>"versättning"</para><para>"traducere"</para><para>"traduction"</para><para>"Übersetzung"</para><para>"traducción"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/vartrans#trans">http://www.w3.org/ns/lemon/vartrans#trans</seealso>
    let trans = Prefixed_Name(vartrans, "trans") |> PrefixedName
    /// <summary>
    ///   <para>vartrans:translatableAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The 'translatableAs' property relates a lexical entry in some language to a lexical entry in another language that it can be translated as depending on the particular context and specific senses of the involved lexical entries."</para>
    ///   <para>"Свойство 'переводится как' связывает словарную единицу на каком-либо языке со словарной единицей на другом языке, на который она может быть переведена соответствующим образом в зависимости от конкретного контекста и специфических смыслов данных словарных единиц."</para>
    /// labels<para>"traducibile como"</para><para>"traducibile come"</para><para>"vertaalbar als"</para><para>"translatable as"</para><para>"переводится как"</para><para>"traductibil ca"</para><para>"vertaalbaar As"</para><para>"traduisible par"</para><para>"översättbar som"</para><para>"traduzivel como"</para><para>"übersetzbar als"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/vartrans#translatableAs">http://www.w3.org/ns/lemon/vartrans#translatableAs</seealso>
    let translatableAs = Prefixed_Name(vartrans, "translatableAs") |> PrefixedName
    /// <summary>
    ///   <para>vartrans:translation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The 'translation' property relates two lexical senses of two lexical entries that stand in a translation relation to one another. "</para>
    ///   <para>"Свойство 'перевод' связывает два лексических смысла двух словарных единиц, которые находятся в отношении перевода друг к другу."</para>
    /// labels<para>"tradução"</para><para>"translation"</para><para>"versättning"</para><para>"перевод"</para><para>"vertaling"</para><para>"traducción"</para><para>"traduction"</para><para>"traduzione"</para><para>"Übersetzung"</para><para>"traducere"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/vartrans#translation">http://www.w3.org/ns/lemon/vartrans#translation</seealso>
    let translation = Prefixed_Name(vartrans, "translation") |> PrefixedName
    /// <summary>
    ///   <para>vartrans:versionInfo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/vartrans#versionInfo">http://www.w3.org/ns/lemon/vartrans#versionInfo</seealso>
    let versionInfo = Prefixed_Name(vartrans, "versionInfo") |> PrefixedName
