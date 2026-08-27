namespace http.www.w3.org.ns.dcat.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dcat =
    let _namespace_iri = Namespace_Iri dcat |> NamespaceIRI
    /// <summary>
    ///   <para>dcat:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#">http://www.w3.org/ns/dcat#</seealso>
    let _prefix_iri = Prefixed_Name(dcat, "") |> PrefixedName
    /// <summary>
    ///   <para>dcat:Catalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Une collection élaborée de métadonnées sur les jeux de données"</para>
    ///   <para>"مجموعة من توصيفات قوائم البيانات"</para>
    ///   <para>"Μια επιμελημένη συλλογή μεταδεδομένων περί συνόλων δεδομένων"</para>
    ///   <para>"Una raccolta curata di metadati sulle risorse (ad es. sui dataset e relativi servizi nel contesto di cataloghi di dati)."</para>
    ///   <para>"Una colección curada de metadatos sobre recursos (por ejemplo, conjuntos de datos y servicios de datos en el contexto de un catálogo de datos)."</para>
    ///   <para>"データ・カタログは、データセットに関するキュレートされたメタデータの集合です。"</para>
    ///   <para>"A curated collection of metadata about resources (e.g., datasets and data services in the context of a data catalog)."</para>
    ///   <para>"Řízená kolekce metadat o datových sadách a datových službách"</para>
    /// labels<para>"فهرس قوائم البيانات"</para><para>"Κατάλογος"</para><para>"Katalog"</para><para>"Catalog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Catálogo"</para><para>"Catalog"</para><para>"カタログ"</para><para>"Catalogue"</para><para>"Catalogo"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#Catalog">http://www.w3.org/ns/dcat#Catalog</seealso>
    let Catalog = Prefixed_Name(dcat, "Catalog") |> PrefixedName
    /// <summary>
    ///   <para>dcat:CatalogRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A record in a data catalog, describing the registration of a single dataset or data service."</para>
    ///   <para>"Μία καταγραφή ενός καταλόγου, η οποία περιγράφει ένα συγκεκριμένο σύνολο δεδομένων."</para>
    ///   <para>"A record in a catalog, describing the registration of a single dcat:Resource."</para>
    ///   <para>"Záznam v datovém katalogu popisující jednu datovou sadu či datovou službu."</para>
    ///   <para>"Un record in un catalogo di dati che descrive un singolo dataset o servizio di dati."</para>
    ///   <para>"1つのデータセットを記述したデータ・カタログ内のレコード。"</para>
    ///   <para>"Un registro en un catálogo de datos que describe un solo conjunto de datos o un servicio de datos."</para>
    ///   <para>"Un registre du catalogue ou une entrée du catalogue, décrivant un seul jeu de données."</para>
    /// labels<para>"سجل"</para><para>"カタログ・レコード"</para><para>"Registro del catálogo"</para><para>"Catalog Record"</para><para>"Record di catalogo"</para><para>"Καταγραφή καταλόγου"</para><para>"Registre du catalogue"</para><para>"Katalogizační záznam"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#CatalogRecord">http://www.w3.org/ns/dcat#CatalogRecord</seealso>
    let CatalogRecord = Prefixed_Name(dcat, "CatalogRecord") |> PrefixedName
    /// <summary>
    ///   <para>dcat:DataService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Un sito o end-point che fornisce operazioni relative alla scoperta, all'accesso o all'elaborazione di funzioni su dati o risorse correlate."</para>
    ///   <para>"Umístění či přístupový bod poskytující operace související s hledáním, přistupem k, či výkonem funkcí na datech či souvisejících zdrojích."</para>
    ///   <para>"A site or end-point providing operations related to the discovery of, access to, or processing functions on, data or related resources."</para>
    ///   <para>"Un sitio o end-point que provee operaciones relacionadas a funciones de descubrimiento, acceso, o procesamiento de datos o recursos relacionados."</para>
    /// labels<para>"Data service"</para><para>"Servizio di dati"</para><para>"Data Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Servicio de datos"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#DataService">http://www.w3.org/ns/dcat#DataService</seealso>
    let DataService = Prefixed_Name(dcat, "DataService") |> PrefixedName
    /// <summary>
    ///   <para>dcat:DataSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#DataSet">http://www.w3.org/ns/dcat#DataSet</seealso>
    let DataSet = Prefixed_Name(dcat, "DataSet") |> PrefixedName
    /// <summary>
    ///   <para>dcat:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Une collection de données, publiée ou élaborée par une seule source, et disponible pour accès ou téléchargement dans un ou plusieurs formats."</para>
    ///   <para>"Μία συλλογή από δεδομένα, δημοσιευμένη ή επιμελημένη από μία και μόνο πηγή, διαθέσιμη δε προς πρόσβαση ή μεταφόρτωση σε μία ή περισσότερες μορφές."</para>
    ///   <para>"Una colección de datos, publicados o conservados por una única fuente, y disponibles para ser accedidos o descargados en uno o más formatos."</para>
    ///   <para>"Kolekce dat poskytovaná či řízená jedním zdrojem, která je k dispozici pro přístup či stažení v jednom či více formátech."</para>
    ///   <para>"قائمة بيانات منشورة أو مجموعة من قبل مصدر ما و متاح الوصول إليها أو تحميلها"</para>
    ///   <para>"A collection of data, published or curated by a single source, and available for access or download in one or more represenations."</para>
    ///   <para>"1つのエージェントによって公開またはキュレートされ、1つ以上の形式でアクセスまたはダウンロードできるデータの集合。"</para>
    ///   <para>"A collection of data, published or curated by a single source, and available for access or download in one or more representations."</para>
    ///   <para>"Raccolta di dati, pubblicati o curati da un'unica fonte, disponibili per l'accesso o il download in uno o più formati."</para>
    /// labels<para>"Conjunto de datos"</para><para>"Σύνολο Δεδομένων"</para><para>"Jeu de données"</para><para>"Dataset"</para><para>"Dataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Datová sada"</para><para>"データセット"</para><para>"قائمة بيانات"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#Dataset">http://www.w3.org/ns/dcat#Dataset</seealso>
    let Dataset = Prefixed_Name(dcat, "Dataset") |> PrefixedName
    /// <summary>
    ///   <para>dcat:DatasetSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Dataset series"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#DatasetSeries">http://www.w3.org/ns/dcat#DatasetSeries</seealso>
    let DatasetSeries = Prefixed_Name(dcat, "DatasetSeries") |> PrefixedName
    /// <summary>
    ///   <para>dcat:Distribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Una representación específica de los datos. Cada conjunto de datos puede estar disponible en formas diferentes, las cuáles pueden variar en distintas formas, incluyendo el idioma, 'media-type' o formato, organización esquemática, resolución temporal y espacial, nivel de detalle o perfiles (que pueden especificar cualquiera o todas las diferencias anteriores)."</para>
    ///   <para>"Rappresenta una forma disponibile e specifica del dataset. Ciascun dataset può essere disponibile in forme differenti, che possono rappresentare formati diversi o diversi punti di accesso per un dataset. Esempi di distribuzioni sono un file CSV scaricabile, una API o un RSS feed."</para>
    ///   <para>"A specific representation of a dataset. A dataset might be available in multiple serializations that may differ in various ways, including natural language, media-type or format, schematic organization, temporal and spatial resolution, level of detail or profiles (which might specify any or all of the above)."</para>
    ///   <para>"Konkrétní reprezentace datové sady. Datová sada může být dostupná v různých serializacích, které se mohou navzájem lišit různými způsoby, mimo jiné přirozeným jazykem, media-typem či formátem, schematickou organizací, časovým a prostorovým rozlišením, úrovní detailu či profily (které mohou specifikovat některé či všechny tyto rozdíly)."</para>
    ///   <para>"شكل محدد لقائمة البيانات يمكن الوصول إليه. قائمة بيانات ما يمكن أن تكون متاحه باشكال و أنواع متعددة.  ملف يمكن تحميله أو واجهة برمجية يمكن من خلالها الوصول إلى البيانات هي أمثلة على ذلك."</para>
    ///   <para>"Représente une forme spécifique d'un jeu de données. Caque jeu de données peut être disponible sous différentes formes, celles-ci pouvant représenter différents formats du jeu de données ou différents endpoint. Des exemples de distribution sont des fichirs CSV, des API ou des flux RSS."</para>
    ///   <para>"データセットの特定の利用可能な形式を表わします。各データセットは、異なる形式で利用できることがあり、これらの形式は、データセットの異なる形式や、異なるエンドポイントを表わす可能性があります。配信の例には、ダウンロード可能なCSVファイル、API、RSSフィードが含まれます。"</para>
    ///   <para>"Αναπαριστά μία συγκεκριμένη διαθέσιμη μορφή ενός συνόλου δεδομένων. Κάθε σύνολο δεδομενων μπορεί να είναι διαθέσιμο σε διαφορετικές μορφές, οι μορφές αυτές μπορεί να αναπαριστούν διαφορετικές μορφές αρχείων ή διαφορετικά σημεία διάθεσης. Παραδείγματα διανομών συμπεριλαμβάνουν ένα μεταφορτώσιμο αρχείο μορφής CSV, ένα API ή ένα RSS feed."</para>
    /// labels<para>"Distribución"</para><para>"配信"</para><para>"التوزيع"</para><para>"Distribution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Distribuzione"</para><para>"Distribution"</para><para>"Distribuce"</para><para>"Διανομή"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#Distribution">http://www.w3.org/ns/dcat#Distribution</seealso>
    let Distribution = Prefixed_Name(dcat, "Distribution") |> PrefixedName
    /// <summary>
    ///   <para>dcat:Relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#Relation">http://www.w3.org/ns/dcat#Relation</seealso>
    let Relation = Prefixed_Name(dcat, "Relation") |> PrefixedName
    /// <summary>
    ///   <para>dcat:Relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Asociační třída pro připojení dodatečných informací ke vztahu mezi zdroji DCAT."</para>
    ///   <para>"Una classe di associazione per il collegamento di informazioni aggiuntive a una relazione tra le risorse DCAT."</para>
    ///   <para>"An association class for attaching additional information to a relationship between DCAT Resources."</para>
    ///   <para>"Una clase de asociación para adjuntar información adicional a una relación entre recursos DCAT."</para>
    /// labels<para>"Vztah"</para><para>"Relación"</para><para>"Relazione"</para><para>"Relationship"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#Relationship">http://www.w3.org/ns/dcat#Relationship</seealso>
    let Relationship = Prefixed_Name(dcat, "Relationship") |> PrefixedName
    /// <summary>
    ///   <para>dcat:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Resource of data from DCAT ontology"</para>
    ///   <para>"Recurso publicado o curado por un agente único."</para>
    ///   <para>"Zdroj publikovaný či řízený jediným činitelem."</para>
    ///   <para>"Risorsa pubblicata o curata da un singolo agente."</para>
    ///   <para>"Resource published or curated by a single agent."</para>
    /// labels<para>"Resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Katalogizovaný zdroj"</para><para>"Recurso catalogado"</para><para>"Resource"</para><para>"Catalogued resource"</para><para>"Risorsa catalogata"</para><para>"Cataloged Resource"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#Resource">http://www.w3.org/ns/dcat#Resource</seealso>
    let Resource = Prefixed_Name(dcat, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>dcat:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Un ruolo è la funzione di una risorsa o di un agente rispetto ad un'altra risorsa, nel contesto dell'attribuzione delle risorse o delle relazioni tra risorse."</para>
    ///   <para>"Un rol es la función de un recurso o agente con respecto a otro recuros, en el contexto de atribución del recurso o de las relaciones entre recursos."</para>
    ///   <para>"Role je funkce zdroje či agenta ve vztahu k jinému zdroji, v kontextu přiřazení zdrojů či vztahů mezi zdroji."</para>
    ///   <para>"A role is the function of a resource or agent with respect to another resource, in the context of resource attribution or resource relationships."</para>
    /// labels<para>"Ruolo"</para><para>"Role"</para><para>"Rol"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#Role">http://www.w3.org/ns/dcat#Role</seealso>
    let Role = Prefixed_Name(dcat, "Role") |> PrefixedName
    /// <summary>
    ///   <para>dcat:accessRights</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#accessRights">http://www.w3.org/ns/dcat#accessRights</seealso>
    let accessRights = Prefixed_Name(dcat, "accessRights") |> PrefixedName
    /// <summary>
    ///   <para>dcat:accessSerive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A data service that gives access to the distribution of the dataset."</para>
    /// labels<para>"access service"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#accessSerive">http://www.w3.org/ns/dcat#accessSerive</seealso>
    let accessSerive = Prefixed_Name(dcat, "accessSerive") |> PrefixedName
    /// <summary>
    ///   <para>dcat:accessService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Un sito o end-point che dà accesso alla distribuzione del set di dati."</para>
    ///   <para>"Umístění či přístupový bod zpřístupňující distribuci datové sady."</para>
    ///   <para>"A site or end-point that gives access to the distribution of the dataset."</para>
    ///   <para>"Un sitio o end-point que da acceso a la distribución de un conjunto de datos."</para>
    ///   <para>"A data service that gives access to the distribution of the dataset."</para>
    /// labels<para>"servizio di accesso ai dati"</para><para>"access service"</para><para>"access service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"servicio de acceso de datos"</para><para>"služba pro přístup k datům"</para><para>"data access service"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#accessService">http://www.w3.org/ns/dcat#accessService</seealso>
    let accessService = Prefixed_Name(dcat, "accessService") |> PrefixedName
    /// <summary>
    ///   <para>dcat:accessURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"データセットの配信にアクセス権を与えるランディング・ページ、フィード、SPARQLエンドポイント、その他の種類の資源。"</para>
    ///   <para>"URL zdroje, přes které je přístupná distribuce datové sady. Příkladem může být vstupní stránka, RSS kanál či SPARQL endpoint. Použijte ve všech případech kromě URL souboru ke stažení, pro které je lepší použít dcat:downloadURL."</para>
    ///   <para>"A URL of the resource that gives access to a distribution of the dataset. E.g. landing page, feed, SPARQL endpoint."</para>
    ///   <para>"Ceci peut être tout type d'URL qui donne accès à une distribution du jeu de données. Par exemple, un lien à une page HTML contenant un lien au jeu de données, un Flux RSS, un point d'accès SPARQL. Utilisez le lorsque votre catalogue ne contient pas d'information sur quoi il est ou quand ce n'est pas téléchargeable."</para>
    ///   <para>"Puede ser cualquier tipo de URL que de acceso a una distribución del conjunto de datos, e.g., página de destino, descarga, URL feed, punto de acceso SPARQL. Esta propriedad se debe usar cuando su catálogo de datos no tiene información sobre donde está o cuando no se puede descargar."</para>
    ///   <para>"أي رابط يتيح الوصول إلى البيانات. إذا كان الرابط هو ربط مباشر لملف يمكن تحميله استخدم الخاصية downloadURL"</para>
    ///   <para>"dcat:accessURL SHOULD be used for the URL of a service or location that can provide access to this distribution, typically through a Web form, query or API call.
    ///
    /// dcat:downloadURL is preferred for direct links to downloadable resources.
    ///
    /// If the distribution(s) are accessible only through a landing page (i.e. direct download URLs are not known), then the landing page URL associated with the dcat:Dataset SHOULD be duplicated as access URL on a distribution (see § 5.7 Dataset available only behind some Web page)."</para>
    ///   <para>"Μπορεί να είναι οποιουδήποτε είδους URL που δίνει πρόσβαση στη διανομή ενός συνόλου δεδομένων. Π.χ. ιστοσελίδα αρχικής πρόσβασης, μεταφόρτωση, feed URL, σημείο διάθεσης SPARQL. Να χρησιμοποιείται όταν ο κατάλογος δεν περιέχει πληροφορίες εαν πρόκειται ή όχι για μεταφορτώσιμο αρχείο."</para>
    ///   <para>"A URL of a resource that gives access to a distribution of the dataset. E.g. landing page, feed, SPARQL endpoint. Use for all cases except a simple download link, in which case downloadURL is preferred."</para>
    ///   <para>"Un URL di una risorsa che consente di accedere a una distribuzione del set di dati. Per esempio, pagina di destinazione, feed, endpoint SPARQL. Da utilizzare per tutti i casi, tranne  quando  si tratta di un semplice link per il download nel qual caso è preferito downloadURL."</para>
    /// labels<para>"URL πρόσβασης"</para><para>"přístupová adresa"</para><para>"access address"</para><para>"URL de acceso"</para><para>"رابط وصول"</para><para>"indirizzo di accesso"</para><para>"access u r l"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"access URL"</para><para>"access url"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"アクセスURL"</para><para>"URL d'accès"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#accessURL">http://www.w3.org/ns/dcat#accessURL</seealso>
    let accessURL = Prefixed_Name(dcat, "accessURL") |> PrefixedName
    /// <summary>
    ///   <para>dcat:accrualPeriodicity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#accrualPeriodicity">http://www.w3.org/ns/dcat#accrualPeriodicity</seealso>
    let accrualPeriodicity = Prefixed_Name(dcat, "accrualPeriodicity") |> PrefixedName
    /// <summary>
    ///   <para>dcat:bbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"cuadro delimitador"</para><para>"ohraničení oblasti"</para><para>"bounding box"</para><para>"quadro di delimitazione"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#bbox">http://www.w3.org/ns/dcat#bbox</seealso>
    let bbox = Prefixed_Name(dcat, "bbox") |> PrefixedName
    /// <summary>
    ///   <para>dcat:byteSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"الحجم بالبايتات "</para>
    ///   <para>"Velikost distribuce v bajtech."</para>
    ///   <para>"La dimensione di una distribuzione in byte."</para>
    ///   <para>"The size in bytes can be approximated (as a decimal) when the precise size is not known."</para>
    ///   <para>"Το μέγεθος μιας διανομής σε bytes."</para>
    ///   <para>"El tamaño de una distribución en bytes."</para>
    ///   <para>"バイトによる配信のサイズ。"</para>
    ///   <para>"La taille de la distribution en octects"</para>
    ///   <para>"The size of a distribution in bytes."</para>
    /// labels<para>"dimensione in byte"</para><para>"taille en octects"</para><para>"byte size"</para><para>"tamaño en bytes"</para><para>"バイト・サイズ"</para><para>"velikost v bajtech"</para><para>"الحجم بالبايت"</para><para>"μέγεθος σε bytes"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#byteSize">http://www.w3.org/ns/dcat#byteSize</seealso>
    let byteSize = Prefixed_Name(dcat, "byteSize") |> PrefixedName
    /// <summary>
    ///   <para>dcat:catalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Katalog, jehož obsah je v kontextu tohoto katalogu zajímavý."</para>
    ///   <para>"Un catálogo cuyo contenido es de interés en el contexto del catálogo que está siendo descripto."</para>
    ///   <para>"Un catalogo i cui contenuti sono di interesse nel contesto di questo catalogo."</para>
    ///   <para>"A catalog whose contents are of interest in the context of this catalog."</para>
    /// labels<para>"catalogo"</para><para>"catalog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"catálogo"</para><para>"katalog"</para><para>"catalog"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#catalog">http://www.w3.org/ns/dcat#catalog</seealso>
    let catalog = Prefixed_Name(dcat, "catalog") |> PrefixedName
    /// <summary>
    ///   <para>dcat:centroid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"centroid"</para><para>"centroide"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#centroid">http://www.w3.org/ns/dcat#centroid</seealso>
    let centroid = Prefixed_Name(dcat, "centroid") |> PrefixedName
    /// <summary>
    ///   <para>dcat:compressFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The compression format of the distribution in which the data is contained in a compressed form, e.g. to reduce the size of the downloadable file."</para>
    ///   <para>"Formát komprese souboru, ve kterém jsou data poskytována v komprimované podobě, např. ke snížení velikosti souboru ke stažení."</para>
    ///   <para>"Il formato di compressione della distribuzione nel quale i dati sono in forma compressa, ad es. per ridurre le dimensioni del file da scaricare."</para>
    ///   <para>"El formato de la distribución en el que los datos están en forma comprimida, e.g. para reducir el tamaño del archivo a bajar."</para>
    ///   <para>"This property to be used when the files in the distribution are compressed, e.g. in a ZIP file. The format SHOULD be expressed using a media type as defined by IANA [IANA-MEDIA-TYPES], if available."</para>
    /// labels<para>"compression format"</para><para>"formato de compresión"</para><para>"formát komprese"</para><para>"formato di compressione"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#compressFormat">http://www.w3.org/ns/dcat#compressFormat</seealso>
    let compressFormat = Prefixed_Name(dcat, "compressFormat") |> PrefixedName
    /// <summary>
    ///   <para>dcat:conformsTo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#conformsTo">http://www.w3.org/ns/dcat#conformsTo</seealso>
    let conformsTo = Prefixed_Name(dcat, "conformsTo") |> PrefixedName
    /// <summary>
    ///   <para>dcat:contactPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"データセットを、VCardを用いて提供されている適切な連絡先情報にリンクします。"</para>
    ///   <para>"Relevantní kontaktní informace pro katalogizovaný zdroj. Doporučuje se použít slovník VCard."</para>
    ///   <para>"Identifies a vcard:vCard that contains information on how to contact an agent responsible for the dataset. We required that at least an email is provided."</para>
    ///   <para>"Información relevante de contacto para el recurso catalogado. Se recomienda el uso de vCard."</para>
    ///   <para>"Relevant contact information for the cataloged resource. Use of vCard is recommended."</para>
    ///   <para>"Relevant contact information for the catalogued resource. Use of vCard is recommended."</para>
    ///   <para>"Relie un jeu de données à une information de contact utile en utilisant VCard."</para>
    ///   <para>"Συνδέει ένα σύνολο δεδομένων με ένα σχετικό σημείο επικοινωνίας, μέσω VCard."</para>
    ///   <para>"Informazioni di contatto rilevanti per la risorsa catalogata. Si raccomanda l'uso di vCard."</para>
    ///   <para>"تربط قائمة البيانات بعنوان اتصال موصف  باستخدام VCard"</para>
    /// labels<para>"Punto de contacto"</para><para>"σημείο επικοινωνίας"</para><para>"point de contact"</para><para>"عنوان اتصال"</para><para>"contact point"</para><para>"kontaktní bod"</para><para>"punto di contatto"</para><para>"窓口"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#contactPoint">http://www.w3.org/ns/dcat#contactPoint</seealso>
    let contactPoint = Prefixed_Name(dcat, "contactPoint") |> PrefixedName
    /// <summary>
    ///   <para>dcat:contributor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#contributor">http://www.w3.org/ns/dcat#contributor</seealso>
    let contributor = Prefixed_Name(dcat, "contributor") |> PrefixedName
    /// <summary>
    ///   <para>dcat:dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relie un catalogue à un jeu de données faisant partie de ce catalogue."</para>
    ///   <para>"A collection of data that is listed in the catalog."</para>
    ///   <para>"Kolekce dat, která je katalogizována v katalogu."</para>
    ///   <para>"カタログの一部であるデータセット。"</para>
    ///   <para>"Una raccolta di dati che è elencata nel catalogo."</para>
    ///   <para>"Un conjunto de datos que se lista en el catálogo."</para>
    ///   <para>"تربط الفهرس بقائمة بيانات ضمنه"</para>
    ///   <para>"Συνδέει έναν κατάλογο με ένα σύνολο δεδομένων το οποίο ανήκει στον εν λόγω κατάλογο."</para>
    ///   <para>"Identifies a mod:SemanticArtefact listed in the catalog."</para>
    /// labels<para>"conjunto de datos"</para><para>"データセット"</para><para>"σύνολο δεδομένων"</para><para>"jeu de données"</para><para>"قائمة بيانات"</para><para>"dataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"dataset"</para><para>"datová sada"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#dataset">http://www.w3.org/ns/dcat#dataset</seealso>
    let dataset = Prefixed_Name(dcat, "dataset") |> PrefixedName
    /// <summary>
    ///   <para>dcat:distribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Dostupná distribuce datové sady."</para>
    ///   <para>"Connecte un jeu de données à des distributions disponibles."</para>
    ///   <para>"データセットを、その利用可能な配信に接続します。"</para>
    ///   <para>"Una distribución disponible del conjunto de datos."</para>
    ///   <para>"An available distribution of the dataset."</para>
    ///   <para>"تربط قائمة البيانات بطريقة أو بشكل يسمح  الوصول الى البيانات"</para>
    ///   <para>"Una distribuzione disponibile per il set di dati."</para>
    ///   <para>"Identifies an available dcat:Distribution of the dataset."</para>
    ///   <para>"Συνδέει ένα σύνολο δεδομένων με μία από τις διαθέσιμες διανομές του."</para>
    /// labels<para>"distribution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"διανομή"</para><para>"distribuce"</para><para>"توزيع"</para><para>"distribución"</para><para>"distribution"</para><para>"distribuzione"</para><para>"データセット配信"</para><para>"dataset distribution"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#distribution">http://www.w3.org/ns/dcat#distribution</seealso>
    let distribution = Prefixed_Name(dcat, "distribution") |> PrefixedName
    /// <summary>
    ///   <para>dcat:downloadURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"URL souboru ke stažení v daném formátu, například CSV nebo RDF soubor. Formát je popsán vlastností distribuce dct:format a/nebo dcat:mediaType."</para>
    ///   <para>"Defines a relation between a Dataset and the URL that contains the distribution of the dataset in a given format."</para>
    ///   <para>"Είναι ένας σύνδεσμος άμεσης μεταφόρτωσης ενός αρχείου σε μια δεδομένη μορφή. Π.χ. ένα αρχείο CSV ή RDF. Η μορφη αρχείου περιγράφεται από τις ιδιότητες dct:format ή/και dcat:mediaType της διανομής."</para>
    ///   <para>"رابط مباشر لملف يمكن تحميله. نوع الملف يتم توصيفه باستخدام الخاصية dct:format dcat:mediaType "</para>
    ///   <para>"Questo è un link diretto al file scaricabile in un dato formato. E.g. un file CSV o un file RDF. Il formato è descritto dal dct:format e/o dal dcat:mediaType della distribuzione."</para>
    ///   <para>"Ceci est un lien direct à un fichier téléchargeable en un format donnée. Exple fichier CSV ou RDF. Le format est décrit par les propriétés de distribution dct:format et/ou dcat:mediaType."</para>
    ///   <para>"Identifies a URL that can be used to download the distribution."</para>
    ///   <para>"The URL of the downloadable file in a given format. E.g. CSV file or RDF file. The format is indicated by the distribution's dct:format and/or dcat:mediaType"</para>
    ///   <para>"The URL of the downloadable file in a given format. E.g. CSV file or RDF file. The format is indicated by the distribution's dct:format and/or dcat:mediaType."</para>
    ///   <para>"dcat:downloadURLはdcat:accessURLの特定の形式です。しかし、DCATプロファイルが非ダウンロード・ロケーションに対してのみaccessURLを用いる場合には、より強い分離を課すことを望む可能性があるため、この含意を強化しないように、DCATは、dcat:downloadURLをdcat:accessURLのサブプロパティーであると定義しません。"</para>
    ///   <para>"La URL de un archivo descargable en el formato dato. Por ejemplo, archivo CSV o archivo RDF. El formato se describe con las propiedades de la distribución dct:format y/o dcat:mediaType."</para>
    /// labels<para>"ダウンロードURL"</para><para>"download URL"</para><para>"URL de descarga"</para><para>"URL souboru ke stažení"</para><para>"رابط تحميل"</para><para>"URL de téléchargement"</para><para>"URL di scarico"</para><para>"URL μεταφόρτωσης"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#downloadURL">http://www.w3.org/ns/dcat#downloadURL</seealso>
    let downloadURL = Prefixed_Name(dcat, "downloadURL") |> PrefixedName
    /// <summary>
    ///   <para>dcat:downloadUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#downloadUrl">http://www.w3.org/ns/dcat#downloadUrl</seealso>
    let downloadUrl = Prefixed_Name(dcat, "downloadUrl") |> PrefixedName
    /// <summary>
    ///   <para>dcat:endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"end date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"end date"</para><para>"datum konce"</para><para>"fecha final"</para><para>"data di fine"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#endDate">http://www.w3.org/ns/dcat#endDate</seealso>
    let endDate = Prefixed_Name(dcat, "endDate") |> PrefixedName
    /// <summary>
    ///   <para>dcat:endpointDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A description of the service end-point, including its operations, parameters etc."</para>
    ///   <para>"Una descrizione dell'endpoint del servizio, incluse le sue operazioni, parametri, ecc."</para>
    ///   <para>"Una descripción del end-point del servicio, incluyendo sus operaciones, parámetros, etc."</para>
    ///   <para>"Popis přístupového bodu služby včetně operací, parametrů apod."</para>
    /// labels<para>"descripción del end-point del servicio"</para><para>"popis přístupového bodu služby"</para><para>"descrizione dell'endpoint del servizio"</para><para>"description of service end-point"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#endpointDescription">http://www.w3.org/ns/dcat#endpointDescription</seealso>
    let endpointDescription = Prefixed_Name(dcat, "endpointDescription") |> PrefixedName
    /// <summary>
    ///   <para>dcat:endpointURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"La posición raíz o end-point principal del servicio (una IRI web)."</para>
    ///   <para>"The root location or primary endpoint of the service (a web-resolvable IRI)."</para>
    ///   <para>"La locazione principale o l'endpoint primario del servizio (un IRI risolvibile via web)."</para>
    ///   <para>"Kořenové umístění nebo hlavní přístupový bod služby (IRI přístupné přes Web)."</para>
    /// labels<para>"end-point del servizio"</para><para>"přístupový bod služby"</para><para>"service end-point"</para><para>"endpoint url"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"end-point del servicio"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#endpointURL">http://www.w3.org/ns/dcat#endpointURL</seealso>
    let endpointURL = Prefixed_Name(dcat, "endpointURL") |> PrefixedName
    /// <summary>
    ///   <para>dcat:first</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#first">http://www.w3.org/ns/dcat#first</seealso>
    let first = Prefixed_Name(dcat, "first") |> PrefixedName
    /// <summary>
    ///   <para>dcat:format</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#format">http://www.w3.org/ns/dcat#format</seealso>
    let format = Prefixed_Name(dcat, "format") |> PrefixedName
    /// <summary>
    ///   <para>dcat:hadRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"La función de una entidad o agente con respecto a otra entidad o recurso."</para>
    ///   <para>"Funkce entity či agenta ve vztahu k jiné entitě či zdroji."</para>
    ///   <para>"The function of an entity or agent with respect to another entity or resource."</para>
    ///   <para>"La funzione di un'entità o un agente rispetto ad un'altra entità o risorsa."</para>
    /// labels<para>"haRuolo"</para><para>"tiene rol"</para><para>"hadRole"</para><para>"sehraná role"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#hadRole">http://www.w3.org/ns/dcat#hadRole</seealso>
    let hadRole = Prefixed_Name(dcat, "hadRole") |> PrefixedName
    /// <summary>
    ///   <para>dcat:hasCurrentVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has current version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#hasCurrentVersion">http://www.w3.org/ns/dcat#hasCurrentVersion</seealso>
    let hasCurrentVersion = Prefixed_Name(dcat, "hasCurrentVersion") |> PrefixedName

    /// <summary>
    ///   <para>dcat:hasQualityAnnotation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#hasQualityAnnotation">http://www.w3.org/ns/dcat#hasQualityAnnotation</seealso>
    let hasQualityAnnotation =
        Prefixed_Name(dcat, "hasQualityAnnotation") |> PrefixedName

    /// <summary>
    ///   <para>dcat:hasQualityMeasurement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#hasQualityMeasurement">http://www.w3.org/ns/dcat#hasQualityMeasurement</seealso>
    let hasQualityMeasurement =
        Prefixed_Name(dcat, "hasQualityMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>dcat:hasVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#hasVersion">http://www.w3.org/ns/dcat#hasVersion</seealso>
    let hasVersion = Prefixed_Name(dcat, "hasVersion") |> PrefixedName
    /// <summary>
    ///   <para>dcat:inCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the benchmark suite to which a dataset or profile belongs"</para>
    /// labels<para>"In suite"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#inCatalog">http://www.w3.org/ns/dcat#inCatalog</seealso>
    let inCatalog = Prefixed_Name(dcat, "inCatalog") |> PrefixedName
    /// <summary>
    ///   <para>dcat:inSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Normally, child datasets in dataset series are represented as dcat:Dataset. The use of dcat:Distribution for typing child datasets is however recognized as a possible alternative, whenever it addresses more effectively the requirements of a given application scenario."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#inSeries">http://www.w3.org/ns/dcat#inSeries</seealso>
    let inSeries = Prefixed_Name(dcat, "inSeries") |> PrefixedName
    /// <summary>
    ///   <para>dcat:isVersionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is version of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#isVersionOf">http://www.w3.org/ns/dcat#isVersionOf</seealso>
    let isVersionOf = Prefixed_Name(dcat, "isVersionOf") |> PrefixedName
    /// <summary>
    ///   <para>dcat:issued</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#issued">http://www.w3.org/ns/dcat#issued</seealso>
    let issued = Prefixed_Name(dcat, "issued") |> PrefixedName
    /// <summary>
    ///   <para>dcat:keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Klíčové slovo nebo značka popisující zdroj."</para>
    ///   <para>"データセットを記述しているキーワードまたはタグ。"</para>
    ///   <para>"A keyword or tag describing a resource."</para>
    ///   <para>"Un mot-clé ou étiquette décrivant une ressource."</para>
    ///   <para>"Una parola chiave o un'etichetta per descrivere la risorsa."</para>
    ///   <para>"Una palabra clave o etiqueta que describe un recurso."</para>
    ///   <para>"Determines a domain (partially) described by the semantic artefact. Accepts xsd:string and rdf:langString literals. E.g., the User Feedback Ontology is described with the keywords 'online user feedback', 'software engineering', and 'requirements engineering'."</para>
    ///   <para>"Μία λέξη-κλειδί ή μία ετικέτα που περιγράφει το σύνολο δεδομένων."</para>
    ///   <para>"كلمة  مفتاحيه توصف قائمة البيانات"</para>
    ///   <para>"A keyword or tag describing the resource."</para>
    /// labels<para>"keyword"</para><para>"palabra clave"</para><para>"كلمة  مفتاحية "</para><para>"λέξη-κλειδί"</para><para>"keyword"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"parola chiave"</para><para>"klíčové slovo"</para><para>"キーワード/タグ"</para><para>"mot-clés "</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#keyword">http://www.w3.org/ns/dcat#keyword</seealso>
    let keyword = Prefixed_Name(dcat, "keyword") |> PrefixedName
    /// <summary>
    ///   <para>dcat:landingPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Una página web que puede ser visitada en un explorador Web para tener acceso el catálogo, un conjunto de datos, sus distribuciones y/o información adicional."</para>
    ///   <para>"A Web page that can be navigated to in a Web browser to gain access to the catalog, a dataset, its distributions and/or additional information."</para>
    ///   <para>"Une page Web accessible par un navigateur Web donnant accès au catalogue, un jeu de données, ses distributions et/ou des informations additionnelles."</para>
    ///   <para>"Μία ιστοσελίδα πλοηγίσιμη μέσω ενός φυλλομετρητή (Web browser) που δίνει πρόσβαση στο σύνολο δεδομένων, τις διανομές αυτού ή/και επιπρόσθετες πληροφορίες."</para>
    ///   <para>"Identifies a web page where one can access the dataset, its metadata, its distributions, and additional information about it. E.g., https://www.model-a-platform.com is the landing page of the Digital Platform Ontology."</para>
    ///   <para>"データセット、その配信および（または）追加情報にアクセスするためにウエブ・ブラウザでナビゲートできるウェブページ。"</para>
    ///   <para>"Webová stránka, na kterou lze pro získání přístupu ke katalogu, datové sadě, jejím distribucím a/nebo dalším informacím přistoupit webovým prohlížečem."</para>
    ///   <para>"Una pagina web che può essere navigata per ottenere l'accesso al catalogo, ad un dataset, alle distribuzioni del dataset e/o ad informazioni addizionali."</para>
    ///   <para>"صفحة وب يمكن من خلالها الوصول الى قائمة البيانات أو إلى معلومات إضافية متعلقة بها "</para>
    /// labels<para>"vstupní stránka"</para><para>"صفحة وصول"</para><para>"pagina di destinazione"</para><para>"landingPage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"página de destino"</para><para>"page d'atterrissage"</para><para>"ιστοσελίδα αρχικής πρόσβασης"</para><para>"landing page"</para><para>"ランディング・ページ"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#landingPage">http://www.w3.org/ns/dcat#landingPage</seealso>
    let landingPage = Prefixed_Name(dcat, "landingPage") |> PrefixedName
    /// <summary>
    ///   <para>dcat:language</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#language">http://www.w3.org/ns/dcat#language</seealso>
    let language = Prefixed_Name(dcat, "language") |> PrefixedName
    /// <summary>
    ///   <para>dcat:last</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#last">http://www.w3.org/ns/dcat#last</seealso>
    let last = Prefixed_Name(dcat, "last") |> PrefixedName
    /// <summary>
    ///   <para>dcat:license</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#license">http://www.w3.org/ns/dcat#license</seealso>
    let license = Prefixed_Name(dcat, "license") |> PrefixedName
    /// <summary>
    ///   <para>dcat:mediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Typ média distribuce definovaný v IANA."</para>
    ///   <para>"Η ιδιότητα αυτή ΘΑ ΠΡΕΠΕΙ να χρησιμοποιείται όταν ο τύπος μέσου μίας διανομής είναι ορισμένος στο IANA, αλλιώς η ιδιότητα dct:format ΔΥΝΑΤΑΙ να χρησιμοποιηθεί με διαφορετικές τιμές."</para>
    ///   <para>"Identifies the media type of the distribution. Valid media types are only those defined by IANA, such as https://www.iana.org/assignments/media-types/application/json. If there is no media type for the format of the distribution, the type application/octet-stream must be used for binary files and the type text/plain must be used for text files."</para>
    ///   <para>"Cette propriété doit être utilisée quand c'est définit le type de média de la distribution en IANA, sinon dct:format DOIT être utilisé avec différentes valeurs."</para>
    ///   <para>"Il tipo di media della distribuzione come definito da IANA"</para>
    ///   <para>"The media type of the distribution as defined by IANA"</para>
    ///   <para>"このプロパティーは、配信のメディア・タイプがIANAで定義されているときに使用すべきで（SHOULD）、そうでない場合には、dct:formatを様々な値と共に使用できます（MAY）。"</para>
    ///   <para>"يجب استخدام هذه الخاصية إذا كان نوع الملف معرف ضمن IANA"</para>
    ///   <para>"Esta propiedad debe ser usada cuando está definido el tipo de media de la distribución en IANA, de otra manera dct:format puede ser utilizado con diferentes valores"</para>
    ///   <para>"The media type of the distribution as defined by IANA [IANA-MEDIA-TYPES]."</para>
    /// labels<para>"typ média"</para><para>"メディア・タイプ"</para><para>"media type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"media type"</para><para>"tipo de media"</para><para>"نوع الميديا"</para><para>"tipo di media"</para><para>"τύπος μέσου"</para><para>"type de média"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#mediaType">http://www.w3.org/ns/dcat#mediaType</seealso>
    let mediaType = Prefixed_Name(dcat, "mediaType") |> PrefixedName
    /// <summary>
    ///   <para>dcat:next</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#next">http://www.w3.org/ns/dcat#next</seealso>
    let next = Prefixed_Name(dcat, "next") |> PrefixedName
    /// <summary>
    ///   <para>dcat:packageFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The package format of the distribution in which one or more data files are grouped together, e.g. to enable a set of related files to be downloaded together."</para>
    ///   <para>"Balíčkový formát souboru, ve kterém je jeden či více souborů seskupeno dohromady, např. aby bylo možné stáhnout sadu souvisejících souborů naráz."</para>
    ///   <para>"El formato del archivo en que se agrupan uno o más archivos de datos, e.g. para permitir que un conjunto de archivos relacionados se bajen juntos."</para>
    ///   <para>"Il formato di impacchettamento della distribuzione in cui uno o più file di dati sono raggruppati insieme, ad es. per abilitare un insieme di file correlati da scaricare insieme."</para>
    /// labels<para>"formato de empaquetado"</para><para>"packaging format"</para><para>"formát balíčku"</para><para>"formato di impacchettamento"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#packageFormat">http://www.w3.org/ns/dcat#packageFormat</seealso>
    let packageFormat = Prefixed_Name(dcat, "packageFormat") |> PrefixedName
    /// <summary>
    ///   <para>dcat:prev</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#prev">http://www.w3.org/ns/dcat#prev</seealso>
    let prev = Prefixed_Name(dcat, "prev") |> PrefixedName
    /// <summary>
    ///   <para>dcat:previousVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"previous version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#previousVersion">http://www.w3.org/ns/dcat#previousVersion</seealso>
    let previousVersion = Prefixed_Name(dcat, "previousVersion") |> PrefixedName
    /// <summary>
    ///   <para>dcat:publisher</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#publisher">http://www.w3.org/ns/dcat#publisher</seealso>
    let publisher = Prefixed_Name(dcat, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>dcat:qualifiedRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Link a una descrizione di una relazione con un'altra risorsa."</para>
    ///   <para>"Link to a description of a relationship with another resource."</para>
    ///   <para>"Enlace a una descripción de la relación con otro recurso."</para>
    ///   <para>"Odkaz na popis vztahu s jiným zdrojem."</para>
    /// labels<para>"qualified relation"</para><para>"kvalifikovaný vztah"</para><para>"relación calificada"</para><para>"relazione qualificata"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#qualifiedRelation">http://www.w3.org/ns/dcat#qualifiedRelation</seealso>
    let qualifiedRelation = Prefixed_Name(dcat, "qualifiedRelation") |> PrefixedName
    /// <summary>
    ///   <para>dcat:record</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Describe la registración de un conjunto de datos o un servicio de datos en el catálogo."</para>
    ///   <para>"Propojuje katalog a jeho záznamy."</para>
    ///   <para>"A record describing the registration of a single resource (e.g., a dataset, a data service) that is part of the catalog."</para>
    ///   <para>"Relie un catalogue à ses registres."</para>
    ///   <para>"A record describing the registration of a single dataset or data service that is part of the catalog."</para>
    ///   <para>"Záznam popisující registraci jedné datové sady či datové služby jakožto součásti katalogu."</para>
    ///   <para>"تربط الفهرس بسجل ضمنه"</para>
    ///   <para>"Συνδέει έναν κατάλογο με τις καταγραφές του."</para>
    ///   <para>"Un record che descrive la registrazione di un singolo set di dati o di un servizio dati che fa parte del catalogo."</para>
    ///   <para>"カタログの一部であるカタログ・レコード。"</para>
    /// labels<para>"カタログ・レコード"</para><para>"registro"</para><para>"catalog record"</para><para>"registre"</para><para>"record"</para><para>"záznam"</para><para>"سجل"</para><para>"καταγραφή"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#record">http://www.w3.org/ns/dcat#record</seealso>
    let record = Prefixed_Name(dcat, "record") |> PrefixedName
    /// <summary>
    ///   <para>dcat:resource</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#resource">http://www.w3.org/ns/dcat#resource</seealso>
    let resource = Prefixed_Name(dcat, "resource") |> PrefixedName
    /// <summary>
    ///   <para>dcat:rights</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#rights">http://www.w3.org/ns/dcat#rights</seealso>
    let rights = Prefixed_Name(dcat, "rights") |> PrefixedName
    /// <summary>
    ///   <para>dcat:seriesMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates which datasets are included in the profile"</para>
    /// labels<para>"Includes dataset"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#seriesMember">http://www.w3.org/ns/dcat#seriesMember</seealso>
    let seriesMember = Prefixed_Name(dcat, "seriesMember") |> PrefixedName
    /// <summary>
    ///   <para>dcat:servesDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Una colección de datos que este Servicio de Datos puede distribuir."</para>
    ///   <para>"A collection of data that this DataService can distribute."</para>
    ///   <para>"Kolekce dat, kterou je tato Datová služba schopna poskytnout."</para>
    ///   <para>"Una raccolta di dati che questo DataService può distribuire."</para>
    ///   <para>"A collection of data that this data service can distribute."</para>
    /// labels<para>"poskytuje datovou sadu"</para><para>"serves dataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"serves dataset"</para><para>"serve set di dati"</para><para>"provee conjunto de datos"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#servesDataset">http://www.w3.org/ns/dcat#servesDataset</seealso>
    let servesDataset = Prefixed_Name(dcat, "servesDataset") |> PrefixedName
    /// <summary>
    ///   <para>dcat:service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Umístění či přístupový bod registrovaný v katalogu."</para>
    ///   <para>"Un sito o endpoint elencato nel catalogo."</para>
    ///   <para>"A site or end-point that is listed in the catalog."</para>
    ///   <para>"Un sitio o 'endpoint' que está listado en el catálogo."</para>
    ///   <para>"A site or endpoint that is listed in the catalog."</para>
    /// labels<para>"service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"servizio"</para><para>"servicio"</para><para>"služba"</para><para>"service"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#service">http://www.w3.org/ns/dcat#service</seealso>
    let service = Prefixed_Name(dcat, "service") |> PrefixedName
    /// <summary>
    ///   <para>dcat:spatial</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#spatial">http://www.w3.org/ns/dcat#spatial</seealso>
    let spatial = Prefixed_Name(dcat, "spatial") |> PrefixedName

    /// <summary>
    ///   <para>dcat:spatialResolutionInMeters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"separazione spaziale minima risolvibile in un set di dati, misurata in metri."</para>
    ///   <para>"minimum spatial separation resolvable in a dataset, measured in metres."</para>
    ///   <para>"minimální prostorový rozestup rozeznatelný v datové sadě, měřeno v metrech."</para>
    ///   <para>"Minimum spatial separation resolvable in a dataset, measured in meters."</para>
    ///   <para>"mínima separacíon espacial disponible en un conjunto de datos, medida en metros."</para>
    ///   <para>"minimum spatial separation resolvable in a dataset, measured in meters."</para>
    /// labels<para>"resolución espacial (metros)"</para><para>"spatial resolution (metres)"</para><para>"spatial resolution (meters)"</para><para>"prostorové rozlišení (metry)"</para><para>"spatial resolution in meters"</para><para>"risoluzione spaziale (metros)"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#spatialResolutionInMeters">http://www.w3.org/ns/dcat#spatialResolutionInMeters</seealso>
    let spatialResolutionInMeters =
        Prefixed_Name(dcat, "spatialResolutionInMeters") |> PrefixedName

    /// <summary>
    ///   <para>dcat:startDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"data di inizio"</para><para>"datum začátku"</para><para>"start date"</para><para>"start date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#startDate">http://www.w3.org/ns/dcat#startDate</seealso>
    let startDate = Prefixed_Name(dcat, "startDate") |> PrefixedName
    /// <summary>
    ///   <para>dcat:temporal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#temporal">http://www.w3.org/ns/dcat#temporal</seealso>
    let temporal = Prefixed_Name(dcat, "temporal") |> PrefixedName
    /// <summary>
    ///   <para>dcat:temporalResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"minimální doba trvání rozlišitelná v datové sadě."</para>
    ///   <para>"Minimum time period resolvable in the dataset."</para>
    ///   <para>"periodo di tempo minimo risolvibile in un set di dati."</para>
    ///   <para>"minimum time period resolvable in a dataset."</para>
    ///   <para>"período de tiempo mínimo en el conjunto de datos."</para>
    /// labels<para>"risoluzione temporale"</para><para>"časové rozlišení"</para><para>"temporal resolution"</para><para>"resolución temporal"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#temporalResolution">http://www.w3.org/ns/dcat#temporalResolution</seealso>
    let temporalResolution = Prefixed_Name(dcat, "temporalResolution") |> PrefixedName
    /// <summary>
    ///   <para>dcat:theme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"La categoría principal del recurso. Un recurso puede tener varios temas."</para>
    ///   <para>"Identifies the central theme of the semantic artefact according to a theme taxonomy. In our catalog, the theme of an artefact must be a skos:Concept from the LCC. E.g., 'Class S - Agriculture', 'Class T - Technology'."</para>
    ///   <para>"データセットの主要カテゴリー。データセットは複数のテーマを持つことができます。"</para>
    ///   <para>"Hlavní téma zdroje. Zdroj může mít více témat."</para>
    ///   <para>"La categoria principale della risorsa. Una risorsa può avere più temi."</para>
    ///   <para>"Η κύρια κατηγορία του συνόλου δεδομένων. Ένα σύνολο δεδομένων δύναται να έχει πολλαπλά θέματα."</para>
    ///   <para>"التصنيف الرئيسي لقائمة البيانات. قائمة البيانات يمكن أن تملك أكثر من تصنيف رئيسي واحد."</para>
    ///   <para>"A main category of the resource. A resource can have multiple themes."</para>
    ///   <para>"La catégorie principale de la ressource. Une ressource peut avoir plusieurs thèmes."</para>
    /// labels<para>"theme"</para><para>"التصنيف"</para><para>"theme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"tema"</para><para>"Θέμα"</para><para>"téma"</para><para>"テーマ/カテゴリー"</para><para>"thème"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#theme">http://www.w3.org/ns/dcat#theme</seealso>
    let theme = Prefixed_Name(dcat, "theme") |> PrefixedName
    /// <summary>
    ///   <para>dcat:themeTaxonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Systém organizace znalostí (KOS) použitý pro klasifikaci datových sad v katalogu."</para>
    ///   <para>"Identifies a knowledge organization system used to classify the semantic artefacts in the catalog. In our catalog, we use the Library of Congress Classification (LCC) system, which exists as a skos:ConceptScheme."</para>
    ///   <para>"The knowledge organization system (KOS) used to classify catalog's datasets."</para>
    ///   <para>"Le systhème d'ogranisation de connaissances utilisé pour classifier les jeux de données du catalogue."</para>
    ///   <para>"カタログのデータセットを分類するために用いられる知識組織化体系（KOS；knowledge organization system）。"</para>
    ///   <para>"Il sistema di organizzazione della conoscenza (KOS) usato per classificare i dataset del catalogo."</para>
    ///   <para>"El sistema de organización del conocimiento utilizado para clasificar conjuntos de datos de catálogos."</para>
    ///   <para>"لائحة التصنيفات المستخدمه لتصنيف قوائم البيانات ضمن الفهرس"</para>
    ///   <para>"Το σύστημα οργάνωσης γνώσης που χρησιμοποιείται για την κατηγοριοποίηση των συνόλων δεδομένων του καταλόγου."</para>
    /// labels<para>"theme taxonomy"</para><para>"tassonomia dei temi"</para><para>"Ταξινομία θεματικών κατηγοριών."</para><para>"theme taxonomy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"テーマ"</para><para>"taxonomie de thèmes"</para><para>"taxonomie témat"</para><para>"قائمة التصنيفات"</para><para>"taxonomía de temas"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#themeTaxonomy">http://www.w3.org/ns/dcat#themeTaxonomy</seealso>
    let themeTaxonomy = Prefixed_Name(dcat, "themeTaxonomy") |> PrefixedName
    /// <summary>
    ///   <para>dcat:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The version number of a resource."</para>
    /// labels<para>"version"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#version">http://www.w3.org/ns/dcat#version</seealso>
    let version = Prefixed_Name(dcat, "version") |> PrefixedName
