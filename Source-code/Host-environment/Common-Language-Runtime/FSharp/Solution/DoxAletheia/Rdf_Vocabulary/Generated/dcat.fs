namespace http.www.w3.org.ns.dcat.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dcat =
    let _namespace_iri = Namespace_Iri dcat |> NamespaceIRI
    /// <summary>
    ///   <para>dcat:accessService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Un sito o end-point che dà accesso alla distribuzione del set di dati.</para>
    ///   <para>Umístění či přístupový bod zpřístupňující distribuci datové sady.</para>
    ///   <para>A site or end-point that gives access to the distribution of the dataset.</para>
    ///   <para>Un sitio o end-point que da acceso a la distribución de un conjunto de datos.</para>
    /// labels<para>servizio di accesso ai dati</para><para>servicio de acceso de datos</para><para>služba pro přístup k datům</para><para>data access service</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#accessService">http://www.w3.org/ns/dcat#accessService</seealso>
    let accessService = Prefixed_Name(dcat, "accessService") |> PrefixedName
    /// <summary>
    ///   <para>dcat:contactPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Relevant contact information for the catalogued resource. Use of vCard is recommended.</para>
    ///   <para>データセットを、VCardを用いて提供されている適切な連絡先情報にリンクします。</para>
    ///   <para>Informazioni di contatto rilevanti per la risorsa catalogata. Si raccomanda l'uso di vCard.</para>
    ///   <para>تربط قائمة البيانات بعنوان اتصال موصف  باستخدام VCard</para>
    ///   <para>Relevantní kontaktní informace pro katalogizovaný zdroj. Doporučuje se použít slovník VCard.</para>
    ///   <para>Relie un jeu de données à une information de contact utile en utilisant VCard.</para>
    ///   <para>Συνδέει ένα σύνολο δεδομένων με ένα σχετικό σημείο επικοινωνίας, μέσω VCard.</para>
    ///   <para>Información relevante de contacto para el recurso catalogado. Se recomienda el uso de vCard.</para>
    /// labels<para>σημείο επικοινωνίας</para><para>Punto de contacto</para><para>punto di contatto</para><para>point de contact</para><para>contact point</para><para>kontaktní bod</para><para>عنوان اتصال</para><para>窓口</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#contactPoint">http://www.w3.org/ns/dcat#contactPoint</seealso>
    let contactPoint = Prefixed_Name(dcat, "contactPoint") |> PrefixedName
    /// <summary>
    ///   <para>dcat:dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Kolekce dat, která je katalogizována v katalogu.</para>
    ///   <para>Συνδέει έναν κατάλογο με ένα σύνολο δεδομένων το οποίο ανήκει στον εν λόγω κατάλογο.</para>
    ///   <para>カタログの一部であるデータセット。</para>
    ///   <para>تربط الفهرس بقائمة بيانات ضمنه</para>
    ///   <para>Una raccolta di dati che è elencata nel catalogo.</para>
    ///   <para>Relie un catalogue à un jeu de données faisant partie de ce catalogue.</para>
    ///   <para>A collection of data that is listed in the catalog.</para>
    ///   <para>Un conjunto de datos que se lista en el catálogo.</para>
    /// labels<para>conjunto de datos</para><para>σύνολο δεδομένων</para><para>jeu de données</para><para>قائمة بيانات</para><para>datová sada</para><para>dataset</para><para>dataset</para><para>データセット</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#dataset">http://www.w3.org/ns/dcat#dataset</seealso>
    let dataset = Prefixed_Name(dcat, "dataset") |> PrefixedName
    /// <summary>
    ///   <para>dcat:distribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Una distribuzione disponibile per il set di dati.</para>
    ///   <para>Dostupná distribuce datové sady.</para>
    ///   <para>An available distribution of the dataset.</para>
    ///   <para>データセットを、その利用可能な配信に接続します。</para>
    ///   <para>Συνδέει ένα σύνολο δεδομένων με μία από τις διαθέσιμες διανομές του.</para>
    ///   <para>تربط قائمة البيانات بطريقة أو بشكل يسمح  الوصول الى البيانات</para>
    ///   <para>Connecte un jeu de données à des distributions disponibles.</para>
    ///   <para>Una distribución disponible del conjunto de datos.</para>
    /// labels<para>distribuzione</para><para>distribution</para><para>distribution</para><para>distribución</para><para>distribuce</para><para>データセット配信</para><para>διανομή</para><para>توزيع</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#distribution">http://www.w3.org/ns/dcat#distribution</seealso>
    let distribution = Prefixed_Name(dcat, "distribution") |> PrefixedName
    /// <summary>
    ///   <para>dcat:downloadURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Είναι ένας σύνδεσμος άμεσης μεταφόρτωσης ενός αρχείου σε μια δεδομένη μορφή. Π.χ. ένα αρχείο CSV ή RDF. Η μορφη αρχείου περιγράφεται από τις ιδιότητες dct:format ή/και dcat:mediaType της διανομής.</para>
    ///   <para>Questo è un link diretto al file scaricabile in un dato formato. E.g. un file CSV o un file RDF. Il formato è descritto dal dct:format e/o dal dcat:mediaType della distribuzione.</para>
    ///   <para>dcat:downloadURLはdcat:accessURLの特定の形式です。しかし、DCATプロファイルが非ダウンロード・ロケーションに対してのみaccessURLを用いる場合には、より強い分離を課すことを望む可能性があるため、この含意を強化しないように、DCATは、dcat:downloadURLをdcat:accessURLのサブプロパティーであると定義しません。</para>
    ///   <para>رابط مباشر لملف يمكن تحميله. نوع الملف يتم توصيفه باستخدام الخاصية dct:format dcat:mediaType </para>
    ///   <para>The URL of the downloadable file in a given format. E.g. CSV file or RDF file. The format is indicated by the distribution's dct:format and/or dcat:mediaType.</para>
    ///   <para>Ceci est un lien direct à un fichier téléchargeable en un format donnée. Exple fichier CSV ou RDF. Le format est décrit par les propriétés de distribution dct:format et/ou dcat:mediaType.</para>
    ///   <para>La URL de un archivo descargable en el formato dato. Por ejemplo, archivo CSV o archivo RDF. El formato se describe con las propiedades de la distribución dct:format y/o dcat:mediaType.</para>
    ///   <para>URL souboru ke stažení v daném formátu, například CSV nebo RDF soubor. Formát je popsán vlastností distribuce dct:format a/nebo dcat:mediaType.</para>
    /// labels<para>URL souboru ke stažení</para><para>URL de téléchargement</para><para>URL μεταφόρτωσης</para><para>URL de descarga</para><para>URL di scarico</para><para>download URL</para><para>رابط تحميل</para><para>ダウンロードURL</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#downloadURL">http://www.w3.org/ns/dcat#downloadURL</seealso>
    let downloadURL = Prefixed_Name(dcat, "downloadURL") |> PrefixedName
    /// <summary>
    ///   <para>dcat:endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>data di fine</para><para>datum konce</para><para>fecha final</para><para>end date</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#endDate">http://www.w3.org/ns/dcat#endDate</seealso>
    let endDate = Prefixed_Name(dcat, "endDate") |> PrefixedName
    /// <summary>
    ///   <para>dcat:endpointDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Una descrizione dell'endpoint del servizio, incluse le sue operazioni, parametri, ecc.</para>
    ///   <para>A description of the service end-point, including its operations, parameters etc.</para>
    ///   <para>Una descripción del end-point del servicio, incluyendo sus operaciones, parámetros, etc.</para>
    ///   <para>Popis přístupového bodu služby včetně operací, parametrů apod.</para>
    /// labels<para>descripción del end-point del servicio</para><para>descrizione dell'endpoint del servizio</para><para>description of service end-point</para><para>popis přístupového bodu služby</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#endpointDescription">http://www.w3.org/ns/dcat#endpointDescription</seealso>
    let endpointDescription = Prefixed_Name(dcat, "endpointDescription") |> PrefixedName
    /// <summary>
    ///   <para>dcat:keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Klíčové slovo nebo značka popisující zdroj.</para>
    ///   <para>Una palabra clave o etiqueta que describe un recurso.</para>
    ///   <para>データセットを記述しているキーワードまたはタグ。</para>
    ///   <para>Una parola chiave o un'etichetta per descrivere la risorsa.</para>
    ///   <para>كلمة  مفتاحيه توصف قائمة البيانات</para>
    ///   <para>A keyword or tag describing a resource.</para>
    ///   <para>Μία λέξη-κλειδί ή μία ετικέτα που περιγράφει το σύνολο δεδομένων.</para>
    ///   <para>Un mot-clé ou étiquette décrivant une ressource.</para>
    /// labels<para>كلمة  مفتاحية </para><para>parola chiave</para><para>klíčové slovo</para><para>palabra clave</para><para>λέξη-κλειδί</para><para>mot-clés </para><para>キーワード/タグ</para><para>keyword</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#keyword">http://www.w3.org/ns/dcat#keyword</seealso>
    let keyword = Prefixed_Name(dcat, "keyword") |> PrefixedName
    /// <summary>
    ///   <para>dcat:landingPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Une page Web accessible par un navigateur Web donnant accès au catalogue, un jeu de données, ses distributions et/ou des informations additionnelles.</para>
    ///   <para>Webová stránka, na kterou lze pro získání přístupu ke katalogu, datové sadě, jejím distribucím a/nebo dalším informacím přistoupit webovým prohlížečem.</para>
    ///   <para>Una pagina web che può essere navigata per ottenere l'accesso al catalogo, ad un dataset, alle distribuzioni del dataset e/o ad informazioni addizionali.</para>
    ///   <para>データセット、その配信および（または）追加情報にアクセスするためにウエブ・ブラウザでナビゲートできるウェブページ。</para>
    ///   <para>Μία ιστοσελίδα πλοηγίσιμη μέσω ενός φυλλομετρητή (Web browser) που δίνει πρόσβαση στο σύνολο δεδομένων, τις διανομές αυτού ή/και επιπρόσθετες πληροφορίες.</para>
    ///   <para>صفحة وب يمكن من خلالها الوصول الى قائمة البيانات أو إلى معلومات إضافية متعلقة بها </para>
    ///   <para>Una página web que puede ser visitada en un explorador Web para tener acceso el catálogo, un conjunto de datos, sus distribuciones y/o información adicional.</para>
    ///   <para>A Web page that can be navigated to in a Web browser to gain access to the catalog, a dataset, its distributions and/or additional information.</para>
    /// labels<para>ιστοσελίδα αρχικής πρόσβασης</para><para>pagina di destinazione</para><para>page d'atterrissage</para><para>página de destino</para><para>vstupní stránka</para><para>landing page</para><para>ランディング・ページ</para><para>صفحة وصول</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#landingPage">http://www.w3.org/ns/dcat#landingPage</seealso>
    let landingPage = Prefixed_Name(dcat, "landingPage") |> PrefixedName
    /// <summary>
    ///   <para>dcat:mediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The media type of the distribution as defined by IANA</para>
    ///   <para>Η ιδιότητα αυτή ΘΑ ΠΡΕΠΕΙ να χρησιμοποιείται όταν ο τύπος μέσου μίας διανομής είναι ορισμένος στο IANA, αλλιώς η ιδιότητα dct:format ΔΥΝΑΤΑΙ να χρησιμοποιηθεί με διαφορετικές τιμές.</para>
    ///   <para>Esta propiedad debe ser usada cuando está definido el tipo de media de la distribución en IANA, de otra manera dct:format puede ser utilizado con diferentes valores</para>
    ///   <para>Cette propriété doit être utilisée quand c'est définit le type de média de la distribution en IANA, sinon dct:format DOIT être utilisé avec différentes valeurs.</para>
    ///   <para>このプロパティーは、配信のメディア・タイプがIANAで定義されているときに使用すべきで（SHOULD）、そうでない場合には、dct:formatを様々な値と共に使用できます（MAY）。</para>
    ///   <para>Il tipo di media della distribuzione come definito da IANA</para>
    ///   <para>يجب استخدام هذه الخاصية إذا كان نوع الملف معرف ضمن IANA</para>
    ///   <para>Typ média distribuce definovaný v IANA.</para>
    /// labels<para>tipo di media</para><para>type de média</para><para>tipo de media</para><para>τύπος μέσου</para><para>نوع الميديا</para><para>media type</para><para>typ média</para><para>メディア・タイプ</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#mediaType">http://www.w3.org/ns/dcat#mediaType</seealso>
    let mediaType = Prefixed_Name(dcat, "mediaType") |> PrefixedName
    /// <summary>
    ///   <para>dcat:packageFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The package format of the distribution in which one or more data files are grouped together, e.g. to enable a set of related files to be downloaded together.</para>
    ///   <para>El formato del archivo en que se agrupan uno o más archivos de datos, e.g. para permitir que un conjunto de archivos relacionados se bajen juntos.</para>
    ///   <para>Balíčkový formát souboru, ve kterém je jeden či více souborů seskupeno dohromady, např. aby bylo možné stáhnout sadu souvisejících souborů naráz.</para>
    ///   <para>Il formato di impacchettamento della distribuzione in cui uno o più file di dati sono raggruppati insieme, ad es. per abilitare un insieme di file correlati da scaricare insieme.</para>
    /// labels<para>formato di impacchettamento</para><para>formato de empaquetado</para><para>packaging format</para><para>formát balíčku</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#packageFormat">http://www.w3.org/ns/dcat#packageFormat</seealso>
    let packageFormat = Prefixed_Name(dcat, "packageFormat") |> PrefixedName
    /// <summary>
    ///   <para>dcat:qualifiedRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Link a una descrizione di una relazione con un'altra risorsa.</para>
    ///   <para>Link to a description of a relationship with another resource.</para>
    ///   <para>Odkaz na popis vztahu s jiným zdrojem.</para>
    ///   <para>Enlace a una descripción de la relación con otro recurso.</para>
    /// labels<para>relazione qualificata</para><para>kvalifikovaný vztah</para><para>relación calificada</para><para>qualified relation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#qualifiedRelation">http://www.w3.org/ns/dcat#qualifiedRelation</seealso>
    let qualifiedRelation = Prefixed_Name(dcat, "qualifiedRelation") |> PrefixedName
    /// <summary>
    ///   <para>dcat:record</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Relie un catalogue à ses registres.</para>
    ///   <para>カタログの一部であるカタログ・レコード。</para>
    ///   <para>Un record che descrive la registrazione di un singolo set di dati o di un servizio dati che fa parte del catalogo.</para>
    ///   <para>Propojuje katalog a jeho záznamy.</para>
    ///   <para>Záznam popisující registraci jedné datové sady či datové služby jakožto součásti katalogu.</para>
    ///   <para>A record describing the registration of a single dataset or data service that is part of the catalog.</para>
    ///   <para>Συνδέει έναν κατάλογο με τις καταγραφές του.</para>
    ///   <para>Describe la registración de un conjunto de datos o un servicio de datos en el catálogo.</para>
    ///   <para>تربط الفهرس بسجل ضمنه</para>
    /// labels<para>カタログ・レコード</para><para>καταγραφή</para><para>registre</para><para>registro</para><para>záznam</para><para>record</para><para>record</para><para>سجل</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#record">http://www.w3.org/ns/dcat#record</seealso>
    let record = Prefixed_Name(dcat, "record") |> PrefixedName
    /// <summary>
    ///   <para>dcat:servesDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A collection of data that this DataService can distribute.</para>
    ///   <para>Kolekce dat, kterou je tato Datová služba schopna poskytnout.</para>
    ///   <para>Una raccolta di dati che questo DataService può distribuire.</para>
    ///   <para>Una colección de datos que este Servicio de Datos puede distribuir.</para>
    /// labels<para>provee conjunto de datos</para><para>poskytuje datovou sadu</para><para>serve set di dati</para><para>serves dataset</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#servesDataset">http://www.w3.org/ns/dcat#servesDataset</seealso>
    let servesDataset = Prefixed_Name(dcat, "servesDataset") |> PrefixedName
    /// <summary>
    ///   <para>dcat:service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A site or endpoint that is listed in the catalog.</para>
    ///   <para>Un sito o endpoint elencato nel catalogo.</para>
    ///   <para>Umístění či přístupový bod registrovaný v katalogu.</para>
    ///   <para>Un sitio o 'endpoint' que está listado en el catálogo.</para>
    /// labels<para>servizio</para><para>servicio</para><para>service</para><para>služba</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#service">http://www.w3.org/ns/dcat#service</seealso>
    let service = Prefixed_Name(dcat, "service") |> PrefixedName

    /// <summary>
    ///   <para>dcat:spatialResolutionInMeters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>minimum spatial separation resolvable in a dataset, measured in meters.</para>
    ///   <para>separazione spaziale minima risolvibile in un set di dati, misurata in metri.</para>
    ///   <para>mínima separacíon espacial disponible en un conjunto de datos, medida en metros.</para>
    ///   <para>minimální prostorový rozestup rozeznatelný v datové sadě, měřeno v metrech.</para>
    ///   <para>minimum spatial separation resolvable in a dataset, measured in metres.</para>
    /// labels<para>risoluzione spaziale (metros)</para><para>resolución espacial (metros)</para><para>prostorové rozlišení (metry)</para><para>spatial resolution (meters)</para><para>spatial resolution (metres)</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#spatialResolutionInMeters">http://www.w3.org/ns/dcat#spatialResolutionInMeters</seealso>
    let spatialResolutionInMeters =
        Prefixed_Name(dcat, "spatialResolutionInMeters") |> PrefixedName

    /// <summary>
    ///   <para>dcat:startDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>data di inizio</para><para>datum začátku</para><para>start date</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#startDate">http://www.w3.org/ns/dcat#startDate</seealso>
    let startDate = Prefixed_Name(dcat, "startDate") |> PrefixedName
    /// <summary>
    ///   <para>dcat:Catalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>مجموعة من توصيفات قوائم البيانات</para>
    ///   <para>Μια επιμελημένη συλλογή μεταδεδομένων περί συνόλων δεδομένων</para>
    ///   <para>Řízená kolekce metadat o datových sadách a datových službách</para>
    ///   <para>データ・カタログは、データセットに関するキュレートされたメタデータの集合です。</para>
    ///   <para>Une collection élaborée de métadonnées sur les jeux de données</para>
    ///   <para>A curated collection of metadata about resources (e.g., datasets and data services in the context of a data catalog).</para>
    ///   <para>Una colección curada de metadatos sobre recursos (por ejemplo, conjuntos de datos y servicios de datos en el contexto de un catálogo de datos).</para>
    ///   <para>Una raccolta curata di metadati sulle risorse (ad es. sui dataset e relativi servizi nel contesto di cataloghi di dati).</para>
    /// labels<para>فهرس قوائم البيانات</para><para>Catalogue</para><para>Κατάλογος</para><para>Catálogo</para><para>Catalogo</para><para>Katalog</para><para>Catalog</para><para>カタログ</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#Catalog">http://www.w3.org/ns/dcat#Catalog</seealso>
    let Catalog = Prefixed_Name(dcat, "Catalog") |> PrefixedName
    /// <summary>
    ///   <para>dcat:DataService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Umístění či přístupový bod poskytující operace související s hledáním, přistupem k, či výkonem funkcí na datech či souvisejících zdrojích.</para>
    ///   <para>A site or end-point providing operations related to the discovery of, access to, or processing functions on, data or related resources.</para>
    ///   <para>Un sito o end-point che fornisce operazioni relative alla scoperta, all'accesso o all'elaborazione di funzioni su dati o risorse correlate.</para>
    ///   <para>Un sitio o end-point que provee operaciones relacionadas a funciones de descubrimiento, acceso, o procesamiento de datos o recursos relacionados.</para>
    /// labels<para>Servicio de datos</para><para>Servizio di dati</para><para>Data service</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#DataService">http://www.w3.org/ns/dcat#DataService</seealso>
    let DataService = Prefixed_Name(dcat, "DataService") |> PrefixedName
    /// <summary>
    ///   <para>dcat:theme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>La categoria principale della risorsa. Una risorsa può avere più temi.</para>
    ///   <para>Η κύρια κατηγορία του συνόλου δεδομένων. Ένα σύνολο δεδομένων δύναται να έχει πολλαπλά θέματα.</para>
    ///   <para>A main category of the resource. A resource can have multiple themes.</para>
    ///   <para>データセットの主要カテゴリー。データセットは複数のテーマを持つことができます。</para>
    ///   <para>La categoría principal del recurso. Un recurso puede tener varios temas.</para>
    ///   <para>Hlavní téma zdroje. Zdroj může mít více témat.</para>
    ///   <para>التصنيف الرئيسي لقائمة البيانات. قائمة البيانات يمكن أن تملك أكثر من تصنيف رئيسي واحد.</para>
    ///   <para>La catégorie principale de la ressource. Une ressource peut avoir plusieurs thèmes.</para>
    /// labels<para>テーマ/カテゴリー</para><para>التصنيف</para><para>theme</para><para>thème</para><para>tema</para><para>tema</para><para>Θέμα</para><para>téma</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#theme">http://www.w3.org/ns/dcat#theme</seealso>
    let theme = Prefixed_Name(dcat, "theme") |> PrefixedName
    /// <summary>
    ///   <para>dcat:themeTaxonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Το σύστημα οργάνωσης γνώσης που χρησιμοποιείται για την κατηγοριοποίηση των συνόλων δεδομένων του καταλόγου.</para>
    ///   <para>لائحة التصنيفات المستخدمه لتصنيف قوائم البيانات ضمن الفهرس</para>
    ///   <para>Le systhème d'ogranisation de connaissances utilisé pour classifier les jeux de données du catalogue.</para>
    ///   <para>The knowledge organization system (KOS) used to classify catalog's datasets.</para>
    ///   <para>El sistema de organización del conocimiento utilizado para clasificar conjuntos de datos de catálogos.</para>
    ///   <para>Systém organizace znalostí (KOS) použitý pro klasifikaci datových sad v katalogu.</para>
    ///   <para>Il sistema di organizzazione della conoscenza (KOS) usato per classificare i dataset del catalogo.</para>
    ///   <para>カタログのデータセットを分類するために用いられる知識組織化体系（KOS；knowledge organization system）。</para>
    /// labels<para>Ταξινομία θεματικών κατηγοριών.</para><para>taxonomie de thèmes</para><para>tassonomia dei temi</para><para>taxonomía de temas</para><para>taxonomie témat</para><para>قائمة التصنيفات</para><para>theme taxonomy</para><para>テーマ</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#themeTaxonomy">http://www.w3.org/ns/dcat#themeTaxonomy</seealso>
    let themeTaxonomy = Prefixed_Name(dcat, "themeTaxonomy") |> PrefixedName
    /// <summary>
    ///   <para>dcat:byteSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The size of a distribution in bytes.</para>
    ///   <para>Το μέγεθος μιας διανομής σε bytes.</para>
    ///   <para>Velikost distribuce v bajtech.</para>
    ///   <para>バイトによる配信のサイズ。</para>
    ///   <para>الحجم بالبايتات </para>
    ///   <para>La dimensione di una distribuzione in byte.</para>
    ///   <para>El tamaño de una distribución en bytes.</para>
    ///   <para>La taille de la distribution en octects</para>
    /// labels<para>velikost v bajtech</para><para>dimensione in byte</para><para>taille en octects</para><para>μέγεθος σε bytes</para><para>tamaño en bytes</para><para>الحجم بالبايت</para><para>byte size</para><para>バイト・サイズ</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#byteSize">http://www.w3.org/ns/dcat#byteSize</seealso>
    let byteSize = Prefixed_Name(dcat, "byteSize") |> PrefixedName
    /// <summary>
    ///   <para>dcat:catalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Katalog, jehož obsah je v kontextu tohoto katalogu zajímavý.</para>
    ///   <para>A catalog whose contents are of interest in the context of this catalog.</para>
    ///   <para>Un catálogo cuyo contenido es de interés en el contexto del catálogo que está siendo descripto.</para>
    ///   <para>Un catalogo i cui contenuti sono di interesse nel contesto di questo catalogo.</para>
    /// labels<para>catalogo</para><para>catálogo</para><para>catalog</para><para>katalog</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#catalog">http://www.w3.org/ns/dcat#catalog</seealso>
    let catalog = Prefixed_Name(dcat, "catalog") |> PrefixedName
    /// <summary>
    ///   <para>dcat:centroid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>centroide</para><para>centroide</para><para>centroid</para><para>centroid</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#centroid">http://www.w3.org/ns/dcat#centroid</seealso>
    let centroid = Prefixed_Name(dcat, "centroid") |> PrefixedName
    /// <summary>
    ///   <para>dcat:compressFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>El formato de la distribución en el que los datos están en forma comprimida, e.g. para reducir el tamaño del archivo a bajar.</para>
    ///   <para>Il formato di compressione della distribuzione nel quale i dati sono in forma compressa, ad es. per ridurre le dimensioni del file da scaricare.</para>
    ///   <para>The compression format of the distribution in which the data is contained in a compressed form, e.g. to reduce the size of the downloadable file.</para>
    ///   <para>Formát komprese souboru, ve kterém jsou data poskytována v komprimované podobě, např. ke snížení velikosti souboru ke stažení.</para>
    /// labels<para>formato di compressione</para><para>formato de compresión</para><para>compression format</para><para>formát komprese</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#compressFormat">http://www.w3.org/ns/dcat#compressFormat</seealso>
    let compressFormat = Prefixed_Name(dcat, "compressFormat") |> PrefixedName
    /// <summary>
    ///   <para>dcat:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>قائمة بيانات منشورة أو مجموعة من قبل مصدر ما و متاح الوصول إليها أو تحميلها</para>
    ///   <para>1つのエージェントによって公開またはキュレートされ、1つ以上の形式でアクセスまたはダウンロードできるデータの集合。</para>
    ///   <para>A collection of data, published or curated by a single source, and available for access or download in one or more represenations.</para>
    ///   <para>Une collection de données, publiée ou élaborée par une seule source, et disponible pour accès ou téléchargement dans un ou plusieurs formats.</para>
    ///   <para>Μία συλλογή από δεδομένα, δημοσιευμένη ή επιμελημένη από μία και μόνο πηγή, διαθέσιμη δε προς πρόσβαση ή μεταφόρτωση σε μία ή περισσότερες μορφές.</para>
    ///   <para>Kolekce dat poskytovaná či řízená jedním zdrojem, která je k dispozici pro přístup či stažení v jednom či více formátech.</para>
    ///   <para>Raccolta di dati, pubblicati o curati da un'unica fonte, disponibili per l'accesso o il download in uno o più formati.</para>
    ///   <para>Una colección de datos, publicados o conservados por una única fuente, y disponibles para ser accedidos o descargados en uno o más formatos.</para>
    /// labels<para>Conjunto de datos</para><para>Σύνολο Δεδομένων</para><para>Jeu de données</para><para>قائمة بيانات</para><para>Datová sada</para><para>Dataset</para><para>Dataset</para><para>データセット</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#Dataset">http://www.w3.org/ns/dcat#Dataset</seealso>
    let Dataset = Prefixed_Name(dcat, "Dataset") |> PrefixedName
    /// <summary>
    ///   <para>dcat:CatalogRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Záznam v datovém katalogu popisující jednu datovou sadu či datovou službu.</para>
    ///   <para>Μία καταγραφή ενός καταλόγου, η οποία περιγράφει ένα συγκεκριμένο σύνολο δεδομένων.</para>
    ///   <para>Un registro en un catálogo de datos que describe un solo conjunto de datos o un servicio de datos.</para>
    ///   <para>Un registre du catalogue ou une entrée du catalogue, décrivant un seul jeu de données.</para>
    ///   <para>1つのデータセットを記述したデータ・カタログ内のレコード。</para>
    ///   <para>Un record in un catalogo di dati che descrive un singolo dataset o servizio di dati.</para>
    ///   <para>A record in a data catalog, describing the registration of a single dataset or data service.</para>
    /// labels<para>Registre du catalogue</para><para>Registro del catálogo</para><para>Katalogizační záznam</para><para>Καταγραφή καταλόγου</para><para>Record di catalogo</para><para>Catalog Record</para><para>カタログ・レコード</para><para>سجل</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#CatalogRecord">http://www.w3.org/ns/dcat#CatalogRecord</seealso>
    let CatalogRecord = Prefixed_Name(dcat, "CatalogRecord") |> PrefixedName
    /// <summary>
    ///   <para>dcat:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Resource published or curated by a single agent.</para>
    ///   <para>Zdroj publikovaný či řízený jediným činitelem.</para>
    ///   <para>Risorsa pubblicata o curata da un singolo agente.</para>
    ///   <para>Recurso publicado o curado por un agente único.</para>
    /// labels<para>Katalogizovaný zdroj</para><para>Catalogued resource</para><para>Recurso catalogado</para><para>Risorsa catalogata</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#Resource">http://www.w3.org/ns/dcat#Resource</seealso>
    let Resource = Prefixed_Name(dcat, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>dcat:endpointURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La locazione principale o l'endpoint primario del servizio (un IRI risolvibile via web).</para>
    ///   <para>The root location or primary endpoint of the service (a web-resolvable IRI).</para>
    ///   <para>La posición raíz o end-point principal del servicio (una IRI web).</para>
    ///   <para>Kořenové umístění nebo hlavní přístupový bod služby (IRI přístupné přes Web).</para>
    /// labels<para>end-point del servicio</para><para>end-point del servizio</para><para>přístupový bod služby</para><para>service end-point</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#endpointURL">http://www.w3.org/ns/dcat#endpointURL</seealso>
    let endpointURL = Prefixed_Name(dcat, "endpointURL") |> PrefixedName
    /// <summary>
    ///   <para>dcat:temporalResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>período de tiempo mínimo en el conjunto de datos.</para>
    ///   <para>minimum time period resolvable in a dataset.</para>
    ///   <para>minimální doba trvání rozlišitelná v datové sadě.</para>
    ///   <para>periodo di tempo minimo risolvibile in un set di dati.</para>
    /// labels<para>risoluzione temporale</para><para>resolución temporal</para><para>temporal resolution</para><para>časové rozlišení</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#temporalResolution">http://www.w3.org/ns/dcat#temporalResolution</seealso>
    let temporalResolution = Prefixed_Name(dcat, "temporalResolution") |> PrefixedName
    /// <summary>
    ///   <para>dcat:Distribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Rappresenta una forma disponibile e specifica del dataset. Ciascun dataset può essere disponibile in forme differenti, che possono rappresentare formati diversi o diversi punti di accesso per un dataset. Esempi di distribuzioni sono un file CSV scaricabile, una API o un RSS feed.</para>
    ///   <para>Konkrétní reprezentace datové sady. Datová sada může být dostupná v různých serializacích, které se mohou navzájem lišit různými způsoby, mimo jiné přirozeným jazykem, media-typem či formátem, schematickou organizací, časovým a prostorovým rozlišením, úrovní detailu či profily (které mohou specifikovat některé či všechny tyto rozdíly).</para>
    ///   <para>A specific representation of a dataset. A dataset might be available in multiple serializations that may differ in various ways, including natural language, media-type or format, schematic organization, temporal and spatial resolution, level of detail or profiles (which might specify any or all of the above).</para>
    ///   <para>شكل محدد لقائمة البيانات يمكن الوصول إليه. قائمة بيانات ما يمكن أن تكون متاحه باشكال و أنواع متعددة.  ملف يمكن تحميله أو واجهة برمجية يمكن من خلالها الوصول إلى البيانات هي أمثلة على ذلك.</para>
    ///   <para>データセットの特定の利用可能な形式を表わします。各データセットは、異なる形式で利用できることがあり、これらの形式は、データセットの異なる形式や、異なるエンドポイントを表わす可能性があります。配信の例には、ダウンロード可能なCSVファイル、API、RSSフィードが含まれます。</para>
    ///   <para>Αναπαριστά μία συγκεκριμένη διαθέσιμη μορφή ενός συνόλου δεδομένων. Κάθε σύνολο δεδομενων μπορεί να είναι διαθέσιμο σε διαφορετικές μορφές, οι μορφές αυτές μπορεί να αναπαριστούν διαφορετικές μορφές αρχείων ή διαφορετικά σημεία διάθεσης. Παραδείγματα διανομών συμπεριλαμβάνουν ένα μεταφορτώσιμο αρχείο μορφής CSV, ένα API ή ένα RSS feed.</para>
    ///   <para>Représente une forme spécifique d'un jeu de données. Caque jeu de données peut être disponible sous différentes formes, celles-ci pouvant représenter différents formats du jeu de données ou différents endpoint. Des exemples de distribution sont des fichirs CSV, des API ou des flux RSS.</para>
    ///   <para>Una representación específica de los datos. Cada conjunto de datos puede estar disponible en formas diferentes, las cuáles pueden variar en distintas formas, incluyendo el idioma, 'media-type' o formato, organización esquemática, resolución temporal y espacial, nivel de detalle o perfiles (que pueden especificar cualquiera o todas las diferencias anteriores).</para>
    /// labels<para>Distribuzione</para><para>Distribución</para><para>Distribution</para><para>Distribution</para><para>Distribuce</para><para>Διανομή</para><para>التوزيع</para><para>配信</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#Distribution">http://www.w3.org/ns/dcat#Distribution</seealso>
    let Distribution = Prefixed_Name(dcat, "Distribution") |> PrefixedName
    /// <summary>
    ///   <para>dcat:Relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An association class for attaching additional information to a relationship between DCAT Resources.</para>
    ///   <para>Una classe di associazione per il collegamento di informazioni aggiuntive a una relazione tra le risorse DCAT.</para>
    ///   <para>Asociační třída pro připojení dodatečných informací ke vztahu mezi zdroji DCAT.</para>
    ///   <para>Una clase de asociación para adjuntar información adicional a una relación entre recursos DCAT.</para>
    /// labels<para>Relationship</para><para>Relazione</para><para>Relación</para><para>Vztah</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#Relationship">http://www.w3.org/ns/dcat#Relationship</seealso>
    let Relationship = Prefixed_Name(dcat, "Relationship") |> PrefixedName
    /// <summary>
    ///   <para>dcat:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A role is the function of a resource or agent with respect to another resource, in the context of resource attribution or resource relationships.</para>
    ///   <para>Un rol es la función de un recurso o agente con respecto a otro recuros, en el contexto de atribución del recurso o de las relaciones entre recursos.</para>
    ///   <para>Role je funkce zdroje či agenta ve vztahu k jinému zdroji, v kontextu přiřazení zdrojů či vztahů mezi zdroji.</para>
    ///   <para>Un ruolo è la funzione di una risorsa o di un agente rispetto ad un'altra risorsa, nel contesto dell'attribuzione delle risorse o delle relazioni tra risorse.</para>
    /// labels<para>Ruolo</para><para>Role</para><para>Role</para><para>Rol</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#Role">http://www.w3.org/ns/dcat#Role</seealso>
    let Role = Prefixed_Name(dcat, "Role") |> PrefixedName
    /// <summary>
    ///   <para>dcat:hadRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La funzione di un'entità o un agente rispetto ad un'altra entità o risorsa.</para>
    ///   <para>La función de una entidad o agente con respecto a otra entidad o recurso.</para>
    ///   <para>Funkce entity či agenta ve vztahu k jiné entitě či zdroji.</para>
    ///   <para>The function of an entity or agent with respect to another entity or resource.</para>
    /// labels<para>sehraná role</para><para>tiene rol</para><para>hadRole</para><para>haRuolo</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#hadRole">http://www.w3.org/ns/dcat#hadRole</seealso>
    let hadRole = Prefixed_Name(dcat, "hadRole") |> PrefixedName
    /// <summary>
    ///   <para>dcat:accessURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>أي رابط يتيح الوصول إلى البيانات. إذا كان الرابط هو ربط مباشر لملف يمكن تحميله استخدم الخاصية downloadURL</para>
    ///   <para>Un URL di una risorsa che consente di accedere a una distribuzione del set di dati. Per esempio, pagina di destinazione, feed, endpoint SPARQL. Da utilizzare per tutti i casi, tranne  quando  si tratta di un semplice link per il download nel qual caso è preferito downloadURL.</para>
    ///   <para>URL zdroje, přes které je přístupná distribuce datové sady. Příkladem může být vstupní stránka, RSS kanál či SPARQL endpoint. Použijte ve všech případech kromě URL souboru ke stažení, pro které je lepší použít dcat:downloadURL.</para>
    ///   <para>Ceci peut être tout type d'URL qui donne accès à une distribution du jeu de données. Par exemple, un lien à une page HTML contenant un lien au jeu de données, un Flux RSS, un point d'accès SPARQL. Utilisez le lorsque votre catalogue ne contient pas d'information sur quoi il est ou quand ce n'est pas téléchargeable.</para>
    ///   <para>Μπορεί να είναι οποιουδήποτε είδους URL που δίνει πρόσβαση στη διανομή ενός συνόλου δεδομένων. Π.χ. ιστοσελίδα αρχικής πρόσβασης, μεταφόρτωση, feed URL, σημείο διάθεσης SPARQL. Να χρησιμοποιείται όταν ο κατάλογος δεν περιέχει πληροφορίες εαν πρόκειται ή όχι για μεταφορτώσιμο αρχείο.</para>
    ///   <para>データセットの配信にアクセス権を与えるランディング・ページ、フィード、SPARQLエンドポイント、その他の種類の資源。</para>
    ///   <para>A URL of a resource that gives access to a distribution of the dataset. E.g. landing page, feed, SPARQL endpoint. Use for all cases except a simple download link, in which case downloadURL is preferred.</para>
    ///   <para>Puede ser cualquier tipo de URL que de acceso a una distribución del conjunto de datos, e.g., página de destino, descarga, URL feed, punto de acceso SPARQL. Esta propriedad se debe usar cuando su catálogo de datos no tiene información sobre donde está o cuando no se puede descargar.</para>
    /// labels<para>indirizzo di accesso</para><para>přístupová adresa</para><para>access address</para><para>URL πρόσβασης</para><para>URL de acceso</para><para>URL d'accès</para><para>رابط وصول</para><para>アクセスURL</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#accessURL">http://www.w3.org/ns/dcat#accessURL</seealso>
    let accessURL = Prefixed_Name(dcat, "accessURL") |> PrefixedName
    /// <summary>
    ///   <para>dcat:bbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>quadro di delimitazione</para><para>ohraničení oblasti</para><para>cuadro delimitador</para><para>bounding box</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dcat#bbox">http://www.w3.org/ns/dcat#bbox</seealso>
    let bbox = Prefixed_Name(dcat, "bbox") |> PrefixedName
