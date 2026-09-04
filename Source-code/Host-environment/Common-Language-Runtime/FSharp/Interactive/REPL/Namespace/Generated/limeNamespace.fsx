#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lime =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/ns/lemon/lime#" "lime"

    /// <summary>
    ///   <para>rdfs:label : banca concettualizzazionirdfs:label : conjuto de conceptualizacionesrdfs:label : conceptualization setrdfs:label : banque de concepitalisationsrdfs:label : набор концепцийrdfs:label : Konzeptualisierungsatzrdfs:label : verzameling van conceptialisaties</para>
    ///   <para>rdfs:isDefinedBy : http://www.w3.org/ns/lemon/lime^^xsd:string</para>
    ///   <para>rdfs:comment : Набор концепций представляет собой набор связей между словарными единицами в лексиконе и лексическими понятиями в наборе понятий, которые они вызывают.rdfs:comment : A conceptualization set represents a collection of links between lexical entries in a Lexicon and lexical concepts in a Concept Set they evoke.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#ConceptualizationSet">lime:ConceptualizationSet</a>
    /// </summary>
    let ConceptualizationSet = _prefixId.prefix "ConceptualizationSet"
    /// <summary>
    ///   <para>rdfs:label : banca di link lessicalirdfs:label : conjunto de enlacesrdfs:label : verzameling van lexicale linksrdfs:label : banque de liens lexicalsrdfs:label : лексический набор ссылокrdfs:label : lexical linksetrdfs:label : leksikale skakelstelrdfs:label : linkset lexicalrdfs:label : lexikalisk länkmängdrdfs:label : Lexikonlinksatz</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Лексический набор связей представляет собой набор связей между набором ссылок и набором лексических понятий (например, synsets of wordnet)rdfs:comment : A lexical linkset represents a collection of links between a reference dataset and a set of lexical concepts (e.g. synsets of a wordnet).</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#LexicalLinkset">lime:LexicalLinkset</a>
    /// </summary>
    let LexicalLinkset = _prefixId.prefix "LexicalLinkset"
    /// <summary>
    ///   <para>rdfs:label : lexicalization setrdfs:label : набор лексикализаций</para>
    ///   <para>rdfs:comment : A 'lexicalization set' is a dataset that comprises a collection of lexicalizations, that is pairs of lexical entry and corresponding reference in the associated ontology/vocabulary/dataset.rdfs:comment : 'Набор лексикализации' - это набор данных, который содержит набор лексикализаций, т.е. пары словарной единицы и соответствующей ссылки в связанной онтологии/словаре/наборе данных.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#LexicalizationSet">lime:LexicalizationSet</a>
    /// </summary>
    let LexicalizationSet = _prefixId.prefix "LexicalizationSet"
    /// <summary>
    ///   <para>rdfs:label : Lessicordfs:label : lexicónrdfs:label : lexikonrdfs:label : лексиконrdfs:label : leksikonrdfs:label : Lexiquerdfs:label : Lexiconrdfs:label : Lexikonrdfs:label : lexiconrdfs:label : lexicon</para>
    ///   <para>rdfs:comment : Лексикон представляет собой набор словарных единиц для определенного языка или домена.rdfs:comment : A lexicon represents a collection of lexical entries for a particular language or domain.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.w3.org/ns/lemon/lime^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#Lexicon">lime:Lexicon</a>
    /// </summary>
    let Lexicon = _prefixId.prefix "Lexicon"
    /// <summary>
    ///   <para>rdfs:label : gemiddelde ambiguïteitrdfs:label : Durchschnittliche Amiguitätrdfs:label : ambiguità mediardfs:label : средняя неоднозначностьrdfs:label : ambiguïté moyennerdfs:label : average ambiguityrdfs:label : ambigüedad promedia</para>
    ///   <para>rdfs:isDefinedBy : http://www.w3.org/ns/lemon/lime^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Свойство 'средней неоднозначности' указывает среднее число лексических понятий, вызываемых каждой леммой/канонической формой в лексиконе.rdfs:comment : The 'average ambiguity' property indicates the average number of lexical concepts evoked by each lemma/canonical form in the lexicon.</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#avgAmbiguity">lime:avgAmbiguity</a>
    /// </summary>
    let avgAmbiguity = _prefixId.prefix "avgAmbiguity"
    /// <summary>
    ///   <para>rdfs:label : Durchschnittliche Anzahl von Lexikalisierungenrdfs:label : numărul mediu de lexicalizarirdfs:label : среднее количество лексикализацийrdfs:label : average number of lexicalizationsrdfs:label : numero medio di lessicalizzazionirdfs:label : nombre moyen de lexicalisationsrdfs:label : gemiddelde aantal leksikaliseringsrdfs:label : numero medio de lexicalizaçõesrdfs:label : gemiddeld aantal van lexicalisatierdfs:label : promedio de lexicalizacionesrdfs:label : genomsnittligt antal lexikaliseringar</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The 'average number of lexicalizations' property indicate the average number of lexicalizations per ontology element. The exact formula for calculating the average is indicated in the specification: https://www.w3.org/community/ontolex/wiki/Final_Model_Specification#LexicalizationSetrdfs:comment : Свойство 'среднее количество лексикализаций' указывает среднее число лексикализаций на элемент онтологии. Точная формула для вычисления среднего значения указана в спецификации: https://www.w3.org/community/ontolex/wiki/Final_Model_Specification#LexicalizationSet</para>
    ///   <para>rdfs:isDefinedBy : http://www.w3.org/ns/lemon/lime^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#avgNumOfLexicalizations">lime:avgNumOfLexicalizations</a>
    /// </summary>
    let avgNumOfLexicalizations = _prefixId.prefix "avgNumOfLexicalizations"
    /// <summary>
    ///   <para>rdfs:comment : The 'average number of links' property indicates the average number of links for each entity in the conceptual dataset.rdfs:comment : Свойство 'среднее количество ссылок' указывает среднее число ссылок для каждого объекта в концептуальном наборе данных.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : gemiddeld aantal van linksrdfs:label : Durchschnittliche Anzahl von Linksrdfs:label : average number of linksrdfs:label : promedio de enlacesrdfs:label : numero medio di linkrdfs:label : среднее количество ссылокrdfs:label : nombre moyen de liens</para>
    ///   <para>rdfs:isDefinedBy : http://www.w3.org/ns/lemon/lime^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#avgNumOfLinks">lime:avgNumOfLinks</a>
    /// </summary>
    let avgNumOfLinks = _prefixId.prefix "avgNumOfLinks"
    /// <summary>
    ///   <para>rdfs:label : gemiddelde synonymierdfs:label : sinóminedad promediardfs:label : synonymie moyennerdfs:label : sinonimità mediardfs:label : average synonymyrdfs:label : средняя синонимияrdfs:label : Durchschnittliche Synonymie</para>
    ///   <para>rdfs:comment : Свойство 'средняя синонимия' указывает среднее число словарных единиц, вызывающих каждое лексическое понятие в наборе понятий.rdfs:comment : The 'average synonymy' property indicates the average number of lexical entries evoking each lexical concept in the concept set.</para>
    ///   <para>rdfs:isDefinedBy : http://www.w3.org/ns/lemon/lime^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#avgSynonymy">lime:avgSynonymy</a>
    /// </summary>
    let avgSynonymy = _prefixId.prefix "avgSynonymy"
    /// <summary>
    ///   <para>rdfs:label : понятияrdfs:label : conceptosrdfs:label : Konzepterdfs:label : begrippenrdfs:label : conceptsrdfs:label : conceptsrdfs:label : concetti</para>
    ///   <para>rdfs:comment : The 'concepts' property indicates the number of lexical concepts defined in a concept set or involved in either a LexicalLinkset or ConceptualizationSet.rdfs:comment : Свойство 'понятия' указывает количество лексических понятий, определенных в наборе понятий или участвующих либо в LexicalLinkset, либо в ConceptualizationSet.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.w3.org/ns/lemon/lime</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#concepts">lime:concepts</a>
    /// </summary>
    let concepts = _prefixId.prefix "concepts"
    /// <summary>
    ///   <para>rdfs:label : Konzeptdatensatzrdfs:label : conceptual datasetrdfs:label : концептуальный набор данныхrdfs:label : banca concettirdfs:label : conjunto de conceptosrdfs:label : dataset van begrippenrdfs:label : banque de concepts</para>
    ///   <para>rdfs:isDefinedBy : http://www.w3.org/ns/lemon/lime^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Свойство 'концептуальный набор данных' связывает набор лексической связи или концептуализацию с соответствующим набором понятий.rdfs:comment : The 'conceptual dataset' property relates a lexical link set or a conceptualization set to a corresponding concept set.</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#conceptualDataset">lime:conceptualDataset</a>
    /// </summary>
    let conceptualDataset = _prefixId.prefix "conceptualDataset"
    /// <summary>
    ///   <para>rdfs:label : концептуализацииrdfs:label : conceptualisationsrdfs:label : concettualizzazionirdfs:label : conceptualizacionesrdfs:label : conceptualisatiesrdfs:label : Konzeptualisierungenrdfs:label : conceptualizations</para>
    ///   <para>rdfs:isDefinedBy : http://www.w3.org/ns/lemon/lime^^xsd:string</para>
    ///   <para>rdfs:comment : The 'conceptualizations' property indicates the number of distinct conceptualizations in a conceptualization set.rdfs:comment : Свойство 'концептуализации' указывает на число различных концептуализаций в наборе концептуализаций.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#conceptualizations">lime:conceptualizations</a>
    /// </summary>
    let conceptualizations = _prefixId.prefix "conceptualizations"
    /// <summary>
    ///   <para>rdfs:label : entréerdfs:label : записьrdfs:label : ingångrdfs:label : înregistrarerdfs:label : inskrywingrdfs:label : entryrdfs:label : entradardfs:label : Itemrdfs:label : entradardfs:label : entratardfs:label : Eintrag</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.w3.org/ns/lemon/lime^^xsd:string</para>
    ///   <para>rdfs:comment : Свойство 'запись' связывает лексикон с одной из содержащихся в нем словарных единиц.rdfs:comment : The 'entry' property relates a lexicon to one of the lexical entries contained in it.</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#entry">lime:entry</a>
    /// </summary>
    let entry = _prefixId.prefix "entry"
    /// <summary>
    ///   <para>rdfs:label : Spracherdfs:label : limbărdfs:label : languerdfs:label : языкrdfs:label : idiomardfs:label : linguardfs:label : språkrdfs:label : taalrdfs:label : taalrdfs:label : languagerdfs:label : lengua</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The  'language' property indicates the language of a lexicon, a lexical entry, a concept set or a lexicalization set.rdfs:comment : Свойство 'язык' указывает язык лексикона, словарной единицы, набора понятий или набора лексикализаций.</para>
    ///   <para>rdfs:isDefinedBy : http://www.w3.org/ns/lemon/lime^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#language">lime:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>rdfs:comment : The 'lexical entries' property indicates the number of distinct lexical entries contained in a lexicon or lexicalization set.rdfs:comment : Свойство 'словарная единица' указывает количество различных словарных единиц, содержащихся в лексиконе или наборе лексикализаций.</para>
    ///   <para>rdfs:label : entradas lexicasrdfs:label : lexierdfs:label : entradas léxicasrdfs:label : lexikaal itemsrdfs:label : lexikoningångarrdfs:label : înregistrari lexicalerdfs:label : leksikale inskrywingrdfs:label : словарная единицаrdfs:label : entrate lessicalirdfs:label : Lexikoneinträgerdfs:label : lexical entries</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.w3.org/ns/lemon/lime^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#lexicalEntries">lime:lexicalEntries</a>
    /// </summary>
    let lexicalEntries = _prefixId.prefix "lexicalEntries"
    /// <summary>
    ///   <para>rdfs:label : modello di lessicalizzazionerdfs:label : Lexikalisierungmodellrdfs:label : model van lexicalisatierdfs:label : lexicalization modelrdfs:label : modelo de lexicalizaciónrdfs:label : модель лексикализацииrdfs:label : modèle de lexicalisation</para>
    ///   <para>rdfs:isDefinedBy : http://www.w3.org/ns/lemon/lime^^xsd:string</para>
    ///   <para>rdfs:comment : The 'lexicalization model' property indicates the model used for representing lexical information. Possible values include (but are not limited to) http://www.w3.org/2000/01/rdf-schema# (for the use of rdfs:label), http://www.w3.org/2004/02/skos/core (for the use of skos:pref/alt/hiddenLabel), http://www.w3.org/2008/05/skos-xl (for the use of skosxl:pref/alt/hiddenLabel) and http://www.w3.org/ns/lemon/all for lemon.rdfs:comment : Свойство 'модель лексикализации' указывает модель, используемую для представления лексической информации. Возможные значения включают (но не ограничиваются) http://www.w3.org/2000/01/rdf-schema# (for the use of rdfs:label), http://www.w3.org/2004/02/skos/core (for the use of skos:pref/alt/hiddenLabel), http://www.w3.org/2008/05/skos-xl (for the use of skosxl:pref/alt/hiddenLabel) and http://www.w3.org/ns/lemon/all for lemon.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#lexicalizationModel">lime:lexicalizationModel</a>
    /// </summary>
    let lexicalizationModel = _prefixId.prefix "lexicalizationModel"
    /// <summary>
    ///   <para>rdfs:label : lexikaliseringarrdfs:label : lexicalisationsrdfs:label : lexicalisatiesrdfs:label : lessicalizzazionirdfs:label : lexicalizationsrdfs:label : lexicalizarirdfs:label : lexicalizacionesrdfs:label : lexicalizaçõesrdfs:label : leksikaliseringsrdfs:label : лексикализацииrdfs:label : Lexikalisierungen</para>
    ///   <para>rdfs:comment : The 'lexicalizations' property indicates the total number of lexicalizations in a lexicalization set, that is the number of unique pairs of lexical entry and denoted ontology element.rdfs:comment : Свойство 'лексикализации' указывает общее число лексикализаций в наборе лексикализаций, то есть количество уникальных пар словарных единиц и обозначенного элемента онтологии.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#lexicalizations">lime:lexicalizations</a>
    /// </summary>
    let lexicalizations = _prefixId.prefix "lexicalizations"
    /// <summary>
    ///   <para>rdfs:label : лексический набор данныхrdfs:label : conjunto de datos del lexicónrdfs:label : lexikondatamängdrdfs:label : leksikale datastelrdfs:label : Lexikondatensatzrdfs:label : lexicale datasetrdfs:label : banca dati lessicalerdfs:label : lexicon datasetrdfs:label : set de date de lexiconrdfs:label : banque de données lexicales</para>
    ///   <para>rdfs:comment : The 'lexicon dataset' property indicates the lexicon that contains the entries refered to in a lexicalization set or a conceptualization set.rdfs:comment : Свойство 'лексический набор данных' указывает лексику, которая содержит записи, упомянутые в наборе лексикализации или наборе концептуализации.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#lexiconDataset">lime:lexiconDataset</a>
    /// </summary>
    let lexiconDataset = _prefixId.prefix "lexiconDataset"
    /// <summary>
    ///   <para>rdfs:label : linguistische Kategorienmodellrdfs:label : banca categorie linguisticherdfs:label : лингвистический каталогrdfs:label : conjunto de categoríes lingüísticasrdfs:label : banque de catégories linguistiquesrdfs:label : verzameling van taalkundige categoriesrdfs:label : lingustic catalog</para>
    ///   <para>rdfs:comment : Свойство 'лингвистический каталог' указывает каталог языковых категорий, используемых в лексиконе, для определения лингвистических свойств словарных единиц.rdfs:comment : The 'linguistic catalog' property indicates the catalog of linguistic categories used in a lexicon to define linguistic properties of lexical entries.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.w3.org/ns/lemon/lime^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#linguisticCatalog">lime:linguisticCatalog</a>
    /// </summary>
    let linguisticCatalog = _prefixId.prefix "linguisticCatalog"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : enlacesrdfs:label : linksrdfs:label : linksrdfs:label : linkrdfs:label : liensrdfs:label : связиrdfs:label : Links</para>
    ///   <para>rdfs:comment : Свойство 'связи' указывает количество связей между понятиями в наборе понятий и объектами в ссылочном наборе данных.rdfs:comment : The 'links' property indicates the number of links between concepts in the concept set and entities in the reference dataset.</para>
    ///   <para>rdfs:isDefinedBy : http://www.w3.org/ns/lemon/lime^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#links">lime:links</a>
    /// </summary>
    let links = _prefixId.prefix "links"
    /// <summary>
    ///   <para>rdfs:label : particiónrdfs:label : partitionrdfs:label : partitionrdfs:label : verdelingrdfs:label : partizionerdfs:label : разделrdfs:label : Teilung</para>
    ///   <para>rdfs:comment : The 'partition' property relates a lexicalization set or lexical linkset to a logical subset that contains lexicalizations for a given ontological type only.rdfs:comment : Свойство 'раздел' связывает набор лексикализации или лексический набор ссылок с логическим подмножеством, который содержит лексикализацию только для данного онтологического типа.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#partition">lime:partition</a>
    /// </summary>
    let partition = _prefixId.prefix "partition"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://www.w3.org/ns/lemon/lime^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The 'percentage' property expresses the percentage of entities in the reference dataset which have at least one lexicalization in a lexicalization set or are linked to a lexical concept in a lexical linkset.rdfs:comment : Свойство 'процент' выражает процент объектов в наборе справочных данных, которые имеют хотя бы одну лексикализацию в наборе лексикализации или связаны с лексической концепцией в лексическом наборе ссылок.</para>
    ///   <para>rdfs:label : porcentajerdfs:label : percentualerdfs:label : процентrdfs:label : Prozentsatzrdfs:label : percentagerdfs:label : percentagerdfs:label : pourcentage</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#percentage">lime:percentage</a>
    /// </summary>
    let percentage = _prefixId.prefix "percentage"
    /// <summary>
    ///   <para>rdfs:label : referensdatamängdrdfs:label : verzameling van referentiesrdfs:label : banca riferimentirdfs:label : reference datasetrdfs:label : Referenzdatensatzrdfs:label : conjunto de datos de referenciardfs:label : verwysingsdatastelrdfs:label : справочный набор данныхrdfs:label : setul de date de referințărdfs:label : banque de réfèrences</para>
    ///   <para>rdfs:comment : The 'reference dataset' property indicates the dataset that contains the domain objects or vocabulary elements that are either referenced by a given lexicon, providing the grounding vocabulary for the meaning of the lexical entries, or linked to lexical concepts in a concept set by means of a lexical link set.rdfs:comment : Свойство 'справочный набор данных' указывает набор данных, который содержит объекты домена или элементы словаря, на которые либо ссылается данный лексикон, обеспечивая базовый словарь для значения словарных единиц или связывая лексическими понятия с понятийными наборами, заданными с помощью набора лексических ссылок.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#referenceDataset">lime:referenceDataset</a>
    /// </summary>
    let referenceDataset = _prefixId.prefix "referenceDataset"
    /// <summary>
    ///   <para>rdfs:label : Referenzenrdfs:label : referenciasrdfs:label : referenciasrdfs:label : référencesrdfs:label : referencesrdfs:label : ссылкиrdfs:label : referenserrdfs:label : riferimentirdfs:label : referințerdfs:label : verwysingsrdfs:label : referenties</para>
    ///   <para>rdfs:comment : Свойство 'ссылки' указывает количество отдельных онтологий или элементов словаря, которые либо связаны с лексическими элементами через набор лексикализации, либо связаны с лексическими понятиями посредством набора лексической связи.rdfs:comment : The 'references' property indicates the number of distinct ontology or vocabulary elements that are either associated with lexical entries via a lexicalization set or linked to lexical concepts via a lexical link set.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#references">lime:references</a>
    /// </summary>
    let references = _prefixId.prefix "references"
    /// <summary>
    ///   <para>rdfs:label : tipo di risorsardfs:label : type de ressourcerdfs:label : тип ресурсаrdfs:label : type van ressourcerdfs:label : resource typerdfs:label : tipo de recursordfs:label : Ressourcentyp</para>
    ///   <para>rdfs:isDefinedBy : http://www.w3.org/ns/lemon/lime^^xsd:string</para>
    ///   <para>rdfs:comment : The 'resource type' property indicates the type of ontological entity of a lexicalization set or lexical linkset.rdfs:comment : Свойство 'тип ресурса' указывает тип онтологического объекта набора лексикализации или лексического набора ссылок.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/lemon/lime#resourceType">lime:resourceType</a>
    /// </summary>
    let resourceType = _prefixId.prefix "resourceType"
