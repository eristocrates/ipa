namespace http.www.w3.org.ns.lemon.lime.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lime =
    let _namespace_iri = Namespace_Iri lime |> NamespaceIRI

    /// <summary>
    ///   <para>lime:ConceptualizationSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Набор концепций представляет собой набор связей между словарными единицами в лексиконе и лексическими понятиями в наборе понятий, которые они вызывают."</para>
    ///   <para>"A conceptualization set represents a collection of links between lexical entries in a Lexicon and lexical concepts in a Concept Set they evoke."</para>
    /// labels<para>"banca concettualizzazioni"</para><para>"banque de concepitalisations"</para><para>"набор концепций"</para><para>"verzameling van conceptialisaties"</para><para>"conjuto de conceptualizaciones"</para><para>"conceptualization set"</para><para>"Konzeptualisierungsatz"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#ConceptualizationSet">http://www.w3.org/ns/lemon/lime#ConceptualizationSet</seealso>
    let ConceptualizationSet =
        Prefixed_Name(lime, "ConceptualizationSet") |> PrefixedName

    /// <summary>
    ///   <para>lime:LexicalLinkset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Лексический набор связей представляет собой набор связей между набором ссылок и набором лексических понятий (например, synsets of wordnet)"</para>
    ///   <para>"A lexical linkset represents a collection of links between a reference dataset and a set of lexical concepts (e.g. synsets of a wordnet)."</para>
    /// labels<para>"Lexikonlinksatz"</para><para>"verzameling van lexicale links"</para><para>"лексический набор ссылок"</para><para>"lexical linkset"</para><para>"lexikalisk länkmängd"</para><para>"leksikale skakelstel"</para><para>"linkset lexical"</para><para>"banque de liens lexicals"</para><para>"conjunto de enlaces"</para><para>"banca di link lessicali"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#LexicalLinkset">http://www.w3.org/ns/lemon/lime#LexicalLinkset</seealso>
    let LexicalLinkset = Prefixed_Name(lime, "LexicalLinkset") |> PrefixedName
    /// <summary>
    ///   <para>lime:LexicalizationSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"'Набор лексикализации' - это набор данных, который содержит набор лексикализаций, т.е. пары словарной единицы и соответствующей ссылки в связанной онтологии/словаре/наборе данных."</para>
    ///   <para>"A 'lexicalization set' is a dataset that comprises a collection of lexicalizations, that is pairs of lexical entry and corresponding reference in the associated ontology/vocabulary/dataset."</para>
    /// labels<para>"набор лексикализаций"</para><para>"lexicalization set"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#LexicalizationSet">http://www.w3.org/ns/lemon/lime#LexicalizationSet</seealso>
    let LexicalizationSet = Prefixed_Name(lime, "LexicalizationSet") |> PrefixedName
    /// <summary>
    ///   <para>lime:Lexicon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A lexicon represents a collection of lexical entries for a particular language or domain."</para>
    ///   <para>"Лексикон представляет собой набор словарных единиц для определенного языка или домена."</para>
    /// labels<para>"лексикон"</para><para>"Lessico"</para><para>"lexicon"</para><para>"lexicón"</para><para>"lexikon"</para><para>"leksikon"</para><para>"Lexicon"</para><para>"Lexique"</para><para>"Lexikon"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#Lexicon">http://www.w3.org/ns/lemon/lime#Lexicon</seealso>
    let Lexicon = Prefixed_Name(lime, "Lexicon") |> PrefixedName
    /// <summary>
    ///   <para>lime:avgAmbiguity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The 'average ambiguity' property indicates the average number of lexical concepts evoked by each lemma/canonical form in the lexicon."</para>
    ///   <para>"Свойство 'средней неоднозначности' указывает среднее число лексических понятий, вызываемых каждой леммой/канонической формой в лексиконе."</para>
    /// labels<para>"ambiguità media"</para><para>"average ambiguity"</para><para>"gemiddelde ambiguïteit"</para><para>"Durchschnittliche Amiguität"</para><para>"ambigüedad promedia"</para><para>"средняя неоднозначность"</para><para>"ambiguïté moyenne"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#avgAmbiguity">http://www.w3.org/ns/lemon/lime#avgAmbiguity</seealso>
    let avgAmbiguity = Prefixed_Name(lime, "avgAmbiguity") |> PrefixedName

    /// <summary>
    ///   <para>lime:avgNumOfLexicalizations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Свойство 'среднее количество лексикализаций' указывает среднее число лексикализаций на элемент онтологии. Точная формула для вычисления среднего значения указана в спецификации: https://www.w3.org/community/ontolex/wiki/Final_Model_Specification#LexicalizationSet"</para>
    ///   <para>"The 'average number of lexicalizations' property indicate the average number of lexicalizations per ontology element. The exact formula for calculating the average is indicated in the specification: https://www.w3.org/community/ontolex/wiki/Final_Model_Specification#LexicalizationSet"</para>
    /// labels<para>"gemiddelde aantal leksikaliserings"</para><para>"promedio de lexicalizaciones"</para><para>"nombre moyen de lexicalisations"</para><para>"numero medio de lexicalizações"</para><para>"genomsnittligt antal lexikaliseringar"</para><para>"numărul mediu de lexicalizari"</para><para>"average number of lexicalizations"</para><para>"Durchschnittliche Anzahl von Lexikalisierungen"</para><para>"gemiddeld aantal van lexicalisatie"</para><para>"среднее количество лексикализаций"</para><para>"numero medio di lessicalizzazioni"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#avgNumOfLexicalizations">http://www.w3.org/ns/lemon/lime#avgNumOfLexicalizations</seealso>
    let avgNumOfLexicalizations =
        Prefixed_Name(lime, "avgNumOfLexicalizations") |> PrefixedName

    /// <summary>
    ///   <para>lime:avgNumOfLinks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Свойство 'среднее количество ссылок' указывает среднее число ссылок для каждого объекта в концептуальном наборе данных."</para>
    ///   <para>"The 'average number of links' property indicates the average number of links for each entity in the conceptual dataset."</para>
    /// labels<para>"среднее количество ссылок"</para><para>"Durchschnittliche Anzahl von Links"</para><para>"numero medio di link"</para><para>"nombre moyen de liens"</para><para>"promedio de enlaces"</para><para>"gemiddeld aantal van links"</para><para>"average number of links"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#avgNumOfLinks">http://www.w3.org/ns/lemon/lime#avgNumOfLinks</seealso>
    let avgNumOfLinks = Prefixed_Name(lime, "avgNumOfLinks") |> PrefixedName
    /// <summary>
    ///   <para>lime:avgSynonymy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Свойство 'средняя синонимия' указывает среднее число словарных единиц, вызывающих каждое лексическое понятие в наборе понятий."</para>
    ///   <para>"The 'average synonymy' property indicates the average number of lexical entries evoking each lexical concept in the concept set."</para>
    /// labels<para>"gemiddelde synonymie"</para><para>"Durchschnittliche Synonymie"</para><para>"sinóminedad promedia"</para><para>"synonymie moyenne"</para><para>"средняя синонимия"</para><para>"sinonimità media"</para><para>"average synonymy"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#avgSynonymy">http://www.w3.org/ns/lemon/lime#avgSynonymy</seealso>
    let avgSynonymy = Prefixed_Name(lime, "avgSynonymy") |> PrefixedName
    /// <summary>
    ///   <para>lime:concepts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The 'concepts' property indicates the number of lexical concepts defined in a concept set or involved in either a LexicalLinkset or ConceptualizationSet."</para>
    ///   <para>"Свойство 'понятия' указывает количество лексических понятий, определенных в наборе понятий или участвующих либо в LexicalLinkset, либо в ConceptualizationSet."</para>
    /// labels<para>"concepts"</para><para>"begrippen"</para><para>"Konzepte"</para><para>"concetti"</para><para>"понятия"</para><para>"conceptos"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#concepts">http://www.w3.org/ns/lemon/lime#concepts</seealso>
    let concepts = Prefixed_Name(lime, "concepts") |> PrefixedName
    /// <summary>
    ///   <para>lime:conceptualDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The 'conceptual dataset' property relates a lexical link set or a conceptualization set to a corresponding concept set."</para>
    ///   <para>"Свойство 'концептуальный набор данных' связывает набор лексической связи или концептуализацию с соответствующим набором понятий."</para>
    /// labels<para>"conjunto de conceptos"</para><para>"conceptual dataset"</para><para>"концептуальный набор данных"</para><para>"banca concetti"</para><para>"dataset van begrippen"</para><para>"Konzeptdatensatz"</para><para>"banque de concepts"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#conceptualDataset">http://www.w3.org/ns/lemon/lime#conceptualDataset</seealso>
    let conceptualDataset = Prefixed_Name(lime, "conceptualDataset") |> PrefixedName
    /// <summary>
    ///   <para>lime:conceptualizations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Свойство 'концептуализации' указывает на число различных концептуализаций в наборе концептуализаций."</para>
    ///   <para>"The 'conceptualizations' property indicates the number of distinct conceptualizations in a conceptualization set."</para>
    /// labels<para>"концептуализации"</para><para>"conceptualizations"</para><para>"Konzeptualisierungen"</para><para>"concettualizzazioni"</para><para>"conceptualizaciones"</para><para>"conceptualisaties"</para><para>"conceptualisations"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#conceptualizations">http://www.w3.org/ns/lemon/lime#conceptualizations</seealso>
    let conceptualizations = Prefixed_Name(lime, "conceptualizations") |> PrefixedName
    /// <summary>
    ///   <para>lime:entry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The 'entry' property relates a lexicon to one of the lexical entries contained in it."</para>
    ///   <para>"Свойство 'запись' связывает лексикон с одной из содержащихся в нем словарных единиц."</para>
    /// labels<para>"Eintrag"</para><para>"entry"</para><para>"inskrywing"</para><para>"entrada"</para><para>"entrata"</para><para>"înregistrare"</para><para>"Item"</para><para>"entrée"</para><para>"запись"</para><para>"ingång"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#entry">http://www.w3.org/ns/lemon/lime#entry</seealso>
    let entry = Prefixed_Name(lime, "entry") |> PrefixedName
    /// <summary>
    ///   <para>lime:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Свойство 'язык' указывает язык лексикона, словарной единицы, набора понятий или набора лексикализаций."</para>
    ///   <para>"The  'language' property indicates the language of a lexicon, a lexical entry, a concept set or a lexicalization set."</para>
    /// labels<para>"idioma"</para><para>"taal"</para><para>"lengua"</para><para>"language"</para><para>"limbă"</para><para>"langue"</para><para>"Sprache"</para><para>"lingua"</para><para>"språk"</para><para>"язык"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#language">http://www.w3.org/ns/lemon/lime#language</seealso>
    let language = Prefixed_Name(lime, "language") |> PrefixedName
    /// <summary>
    ///   <para>lime:lexicalEntries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Свойство 'словарная единица' указывает количество различных словарных единиц, содержащихся в лексиконе или наборе лексикализаций."</para>
    ///   <para>"The 'lexical entries' property indicates the number of distinct lexical entries contained in a lexicon or lexicalization set."</para>
    /// labels<para>"lexikoningångar"</para><para>"lexie"</para><para>"Lexikoneinträge"</para><para>"înregistrari lexicale"</para><para>"entradas léxicas"</para><para>"entradas lexicas"</para><para>"leksikale inskrywing"</para><para>"lexikaal items"</para><para>"словарная единица"</para><para>"lexical entries"</para><para>"entrate lessicali"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#lexicalEntries">http://www.w3.org/ns/lemon/lime#lexicalEntries</seealso>
    let lexicalEntries = Prefixed_Name(lime, "lexicalEntries") |> PrefixedName
    /// <summary>
    ///   <para>lime:lexicalizationModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Свойство 'модель лексикализации' указывает модель, используемую для представления лексической информации. Возможные значения включают (но не ограничиваются) http://www.w3.org/2000/01/rdf-schema# (for the use of rdfs:label), http://www.w3.org/2004/02/skos/core (for the use of skos:pref/alt/hiddenLabel), http://www.w3.org/2008/05/skos-xl (for the use of skosxl:pref/alt/hiddenLabel) and http://www.w3.org/ns/lemon/all for lemon."</para>
    ///   <para>"The 'lexicalization model' property indicates the model used for representing lexical information. Possible values include (but are not limited to) http://www.w3.org/2000/01/rdf-schema# (for the use of rdfs:label), http://www.w3.org/2004/02/skos/core (for the use of skos:pref/alt/hiddenLabel), http://www.w3.org/2008/05/skos-xl (for the use of skosxl:pref/alt/hiddenLabel) and http://www.w3.org/ns/lemon/all for lemon."</para>
    /// labels<para>"модель лексикализации"</para><para>"Lexikalisierungmodell"</para><para>"modèle de lexicalisation"</para><para>"modelo de lexicalización"</para><para>"lexicalization model"</para><para>"modello di lessicalizzazione"</para><para>"model van lexicalisatie"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#lexicalizationModel">http://www.w3.org/ns/lemon/lime#lexicalizationModel</seealso>
    let lexicalizationModel = Prefixed_Name(lime, "lexicalizationModel") |> PrefixedName
    /// <summary>
    ///   <para>lime:lexicalizations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Свойство 'лексикализации' указывает общее число лексикализаций в наборе лексикализаций, то есть количество уникальных пар словарных единиц и обозначенного элемента онтологии."</para>
    ///   <para>"The 'lexicalizations' property indicates the total number of lexicalizations in a lexicalization set, that is the number of unique pairs of lexical entry and denoted ontology element."</para>
    /// labels<para>"лексикализации"</para><para>"leksikaliserings"</para><para>"lexikaliseringar"</para><para>"lexicalisaties"</para><para>"lessicalizzazioni"</para><para>"lexicalizari"</para><para>"Lexikalisierungen"</para><para>"lexicalizations"</para><para>"lexicalisations"</para><para>"lexicalizações"</para><para>"lexicalizaciones"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#lexicalizations">http://www.w3.org/ns/lemon/lime#lexicalizations</seealso>
    let lexicalizations = Prefixed_Name(lime, "lexicalizations") |> PrefixedName
    /// <summary>
    ///   <para>lime:lexiconDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Свойство 'лексический набор данных' указывает лексику, которая содержит записи, упомянутые в наборе лексикализации или наборе концептуализации."</para>
    ///   <para>"The 'lexicon dataset' property indicates the lexicon that contains the entries refered to in a lexicalization set or a conceptualization set."</para>
    /// labels<para>"banque de données lexicales"</para><para>"Lexikondatensatz"</para><para>"conjunto de datos del lexicón"</para><para>"lexikondatamängd"</para><para>"leksikale datastel"</para><para>"lexicon dataset"</para><para>"лексический набор данных"</para><para>"lexicale dataset"</para><para>"set de date de lexicon"</para><para>"banca dati lessicale"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#lexiconDataset">http://www.w3.org/ns/lemon/lime#lexiconDataset</seealso>
    let lexiconDataset = Prefixed_Name(lime, "lexiconDataset") |> PrefixedName
    /// <summary>
    ///   <para>lime:linguisticCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The 'linguistic catalog' property indicates the catalog of linguistic categories used in a lexicon to define linguistic properties of lexical entries."</para>
    ///   <para>"Свойство 'лингвистический каталог' указывает каталог языковых категорий, используемых в лексиконе, для определения лингвистических свойств словарных единиц."</para>
    /// labels<para>"verzameling van taalkundige categories"</para><para>"лингвистический каталог"</para><para>"banca categorie linguistiche"</para><para>"conjunto de categoríes lingüísticas"</para><para>"linguistische Kategorienmodell"</para><para>"banque de catégories linguistiques"</para><para>"lingustic catalog"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#linguisticCatalog">http://www.w3.org/ns/lemon/lime#linguisticCatalog</seealso>
    let linguisticCatalog = Prefixed_Name(lime, "linguisticCatalog") |> PrefixedName
    /// <summary>
    ///   <para>lime:links</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Свойство 'связи' указывает количество связей между понятиями в наборе понятий и объектами в ссылочном наборе данных."</para>
    ///   <para>"The 'links' property indicates the number of links between concepts in the concept set and entities in the reference dataset."</para>
    /// labels<para>"liens"</para><para>"связи"</para><para>"link"</para><para>"links"</para><para>"enlaces"</para><para>"Links"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#links">http://www.w3.org/ns/lemon/lime#links</seealso>
    let links = Prefixed_Name(lime, "links") |> PrefixedName
    /// <summary>
    ///   <para>lime:partition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Свойство 'раздел' связывает набор лексикализации или лексический набор ссылок с логическим подмножеством, который содержит лексикализацию только для данного онтологического типа."</para>
    ///   <para>"The 'partition' property relates a lexicalization set or lexical linkset to a logical subset that contains lexicalizations for a given ontological type only."</para>
    /// labels<para>"partition"</para><para>"Teilung"</para><para>"verdeling"</para><para>"partición"</para><para>"partizione"</para><para>"раздел"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#partition">http://www.w3.org/ns/lemon/lime#partition</seealso>
    let partition = Prefixed_Name(lime, "partition") |> PrefixedName
    /// <summary>
    ///   <para>lime:percentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Свойство 'процент' выражает процент объектов в наборе справочных данных, которые имеют хотя бы одну лексикализацию в наборе лексикализации или связаны с лексической концепцией в лексическом наборе ссылок."</para>
    ///   <para>"The 'percentage' property expresses the percentage of entities in the reference dataset which have at least one lexicalization in a lexicalization set or are linked to a lexical concept in a lexical linkset."</para>
    /// labels<para>"pourcentage"</para><para>"Prozentsatz"</para><para>"percentage"</para><para>"процент"</para><para>"percentuale"</para><para>"porcentaje"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#percentage">http://www.w3.org/ns/lemon/lime#percentage</seealso>
    let percentage = Prefixed_Name(lime, "percentage") |> PrefixedName
    /// <summary>
    ///   <para>lime:referenceDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Свойство 'справочный набор данных' указывает набор данных, который содержит объекты домена или элементы словаря, на которые либо ссылается данный лексикон, обеспечивая базовый словарь для значения словарных единиц или связывая лексическими понятия с понятийными наборами, заданными с помощью набора лексических ссылок."</para>
    ///   <para>"The 'reference dataset' property indicates the dataset that contains the domain objects or vocabulary elements that are either referenced by a given lexicon, providing the grounding vocabulary for the meaning of the lexical entries, or linked to lexical concepts in a concept set by means of a lexical link set."</para>
    /// labels<para>"banca riferimenti"</para><para>"banque de réfèrences"</para><para>"справочный набор данных"</para><para>"conjunto de datos de referencia"</para><para>"verwysingsdatastel"</para><para>"setul de date de referință"</para><para>"reference dataset"</para><para>"referensdatamängd"</para><para>"verzameling van referenties"</para><para>"Referenzdatensatz"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#referenceDataset">http://www.w3.org/ns/lemon/lime#referenceDataset</seealso>
    let referenceDataset = Prefixed_Name(lime, "referenceDataset") |> PrefixedName
    /// <summary>
    ///   <para>lime:references</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Свойство 'ссылки' указывает количество отдельных онтологий или элементов словаря, которые либо связаны с лексическими элементами через набор лексикализации, либо связаны с лексическими понятиями посредством набора лексической связи."</para>
    ///   <para>"The 'references' property indicates the number of distinct ontology or vocabulary elements that are either associated with lexical entries via a lexicalization set or linked to lexical concepts via a lexical link set."</para>
    /// labels<para>"Referenzen"</para><para>"verwysings"</para><para>"références"</para><para>"referințe"</para><para>"ссылки"</para><para>"referencias"</para><para>"referenties"</para><para>"riferimenti"</para><para>"references"</para><para>"referenser"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#references">http://www.w3.org/ns/lemon/lime#references</seealso>
    let references = Prefixed_Name(lime, "references") |> PrefixedName
    /// <summary>
    ///   <para>lime:resourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The 'resource type' property indicates the type of ontological entity of a lexicalization set or lexical linkset."</para>
    ///   <para>"Свойство 'тип ресурса' указывает тип онтологического объекта набора лексикализации или лексического набора ссылок."</para>
    /// labels<para>"type de ressource"</para><para>"tipo de recurso"</para><para>"тип ресурса"</para><para>"type van ressource"</para><para>"tipo di risorsa"</para><para>"resource type"</para><para>"Ressourcentyp"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/lemon/lime#resourceType">http://www.w3.org/ns/lemon/lime#resourceType</seealso>
    let resourceType = Prefixed_Name(lime, "resourceType") |> PrefixedName
