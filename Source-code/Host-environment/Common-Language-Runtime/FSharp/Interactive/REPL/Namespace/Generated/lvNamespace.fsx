#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lv =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/lobid/lv#" "lv"
    /// <summary>
    ///   <para>rdfs:comment : Das Produkt der Archivierung einer Webseite.rdfs:comment : An archival resource that is product of archiving a web page.</para>
    ///   <para>rdfs:label : Archivierte Webseiterdfs:label : Archived Web Page</para>
    ///   <a href="http://purl.org/lobid/lv#ArchivedWebPage">lv:ArchivedWebPage</a>
    /// </summary>
    let ArchivedWebPage = _prefixId.prefix "ArchivedWebPage"
    /// <summary>
    ///   <para>rdfs:comment : Eine Sammlung von Literaturnachweisen.rdfs:comment : A collection of documents relevant to a particular subject or author.</para>
    ///   <para>rdfs:label : Bibliografierdfs:label : Bibliography</para>
    ///   <a href="http://purl.org/lobid/lv#Bibliography">lv:Bibliography</a>
    /// </summary>
    let Bibliography = _prefixId.prefix "Bibliography"
    /// <summary>
    ///   <para>rdfs:comment : Die Lebensbeschreibung einer Person.rdfs:comment : A detailed description or account of a person's life</para>
    ///   <para>rdfs:label : Biografierdfs:label : Biography</para>
    ///   <a href="http://purl.org/lobid/lv#Biography">lv:Biography</a>
    /// </summary>
    let Biography = _prefixId.prefix "Biography"
    /// <summary>
    ///   <para>rdfs:comment : Ein Sammelwerk mit mehreren Beiträgen.rdfs:comment : a collection of scholarly or scientific articles written by different authors</para>
    ///   <para>rdfs:label : Aufsatzsammlungrdfs:label : Edited Volume</para>
    ///   <a href="http://purl.org/lobid/lv#EditedVolume">lv:EditedVolume</a>
    /// </summary>
    let EditedVolume = _prefixId.prefix "EditedVolume"
    /// <summary>
    ///   <para>rdfs:comment : Einem Gelehrten gewidmete Sammlung von Aufsätzen.rdfs:comment : A publication honoring a respected person, especially an academic.</para>
    ///   <para>rdfs:label : Festschriftrdfs:label : Festschrift</para>
    ///   <a href="http://purl.org/lobid/lv#Festschrift">lv:Festschrift</a>
    /// </summary>
    let Festschrift = _prefixId.prefix "Festschrift"
    /// <summary>
    ///   <para>rdfs:comment : Diese Klasse deckt alle Publikationstypen ab, die nicht durch bestehende Klassen erfasst sind. Sie dient insbesondere dem Angebot von Facetten für jene Publikationstypen, die in Bibliothekskatalogen selten zu finden sind.rdfs:comment : This class covers all publication types that are not covered by existing class definitions. It is used to enable facets over seldomly found publication types in library catalogs.</para>
    ///   <para>rdfs:label : Sonstigerdfs:label : Miscellaneous</para>
    ///   <a href="http://purl.org/lobid/lv#Miscellaneous">lv:Miscellaneous</a>
    /// </summary>
    let Miscellaneous = _prefixId.prefix "Miscellaneous"
    /// <summary>
    ///   <para>rdfs:comment : Eine behördliche Publikation für amtliche Bekanntmachungen.rdfs:comment : A publication that records the business and proceedings of a government agency.</para>
    ///   <para>rdfs:label : Amtliche Veröffentlichungrdfs:label : Official Publication</para>
    ///   <a href="http://purl.org/lobid/lv#OfficialPublication">lv:OfficialPublication</a>
    /// </summary>
    let OfficialPublication = _prefixId.prefix "OfficialPublication"
    /// <summary>
    ///   <para>rdfs:comment : Ein Lehrbuch, das Schullehrer im Unterricht einsetzen.rdfs:comment : A textbook used by school teachers in their classes.</para>
    ///   <para>rdfs:label : Schulbuchrdfs:label : Schoolbook</para>
    ///   <a href="http://purl.org/lobid/lv#Schoolbook">lv:Schoolbook</a>
    /// </summary>
    let Schoolbook = _prefixId.prefix "Schoolbook"
    /// <summary>
    ///   <para>rdfs:comment : Amtlicher Gemeindeschlüssel (AGS) der Region, in der sich die beschriebene raum-zeitliche Ressource befindet.rdfs:comment : Amtlicher Gemeindeschlüssel (AGS) of the region a spatial resource is located in.</para>
    ///   <para>rdfs:label : Community Identification Numberrdfs:label : Amtlicher Gemeindeschlüssel</para>
    ///   <a href="http://purl.org/lobid/lv#ags">lv:ags</a>
    /// </summary>
    let ags = _prefixId.prefix "ags"
    /// <summary>
    ///   <para>rdfs:comment : Relates a person, organization or other agent to a QR code that encodes the agent's contact information.</para>
    ///   <para>rdfs:label : Kontakt-QR-Coderdfs:label : Contact QR code</para>
    ///   <a href="http://purl.org/lobid/lv#contactqr">lv:contactqr</a>
    /// </summary>
    let contactqr = _prefixId.prefix "contactqr"
    /// <summary>
    ///   <para>rdfs:comment : The identifier that was assigned to a library in the context of the German Library Statistics (DBS).rdfs:comment : DBS-Nummer. Der Identifier, der einer Bibliothek innerhalb der Deutschen Bibliotheksstatistik (DBS) zugewiesen wurde.</para>
    ///   <para>rdfs:label : DBS IDrdfs:label : DBS-ID</para>
    ///   <a href="http://purl.org/lobid/lv#dbsID">lv:dbsID</a>
    /// </summary>
    let dbsID = _prefixId.prefix "dbsID"
    /// <summary>
    ///   <para>rdfs:comment : Relates a bibliographic resource to an online resource (full text in HTML, PDFs or landing pages in OA repositories, on publishers' websites etc.) that represents the full text of the bibliographic resource or contains a link to a full text of the resource. </para>
    ///   <para>rdfs:label : Online-Volltextrdfs:label : Fulltext online</para>
    ///   <a href="http://purl.org/lobid/lv#fulltextOnline">lv:fulltextOnline</a>
    /// </summary>
    let fulltextOnline = _prefixId.prefix "fulltextOnline"
    /// <summary>
    ///   <para>rdfs:comment : Indicates which type an institution's funder is of. It should be used with a controlled vocabulary like http://purl.org/lobid/fundertype.</para>
    ///   <para>rdfs:label : Art des Unterhaltträgersrdfs:label : Type of funding organization</para>
    ///   <a href="http://purl.org/lobid/lv#fundertype">lv:fundertype</a>
    /// </summary>
    let fundertype = _prefixId.prefix "fundertype"
    /// <summary>
    ///   <para>rdfs:comment : The identifier that is assigned to a bibliographic resource in the hbz union catalogue.rdfs:comment : HT-Nummer. Der Identifier, der einer bibliographischen Ressource im hbz-Verbundkatalog zugewiesen wurde.</para>
    ///   <para>rdfs:label : hbz IDrdfs:label : hbz-ID</para>
    ///   <a href="http://purl.org/lobid/lv#hbzID">lv:hbzID</a>
    /// </summary>
    let hbzID = _prefixId.prefix "hbzID"
    /// <summary>
    ///   <para>rdfs:comment : International Standard Identifier for Libraries and Related Organizations (ISIL). 'An ISIL identifies an organization, i.e., a library or a related organization, or one of its subordinate units, which is responsible for an action or service in a bibliographic environment (e.g. creation of machine-readable information). It can be used to identify the originator or holder of a resource (e.g. library material).' The literal should conform to this regular expression: [A-Z]{1,4}-[0-9a-zA-Z:-/]{1,11} .rdfs:comment : International Standard Identifier for Libraries and Related Organizations (ISIL). Ein eindeutiger Identifikator für Bibliotheken und verwandte Einrichtungen oder untergeordnete Organisationseinheiten, der durch ISIL-Agenturen vergeben wird. Das Literal sollte durch den folgenden regulären Ausdruck gematcht werden: [A-Z]{1,4}-[0-9a-zA-Z:-/]{1,11} .</para>
    ///   <para>rdfs:label : ISIL^^xsd:string</para>
    ///   <a href="http://purl.org/lobid/lv#isil">lv:isil</a>
    /// </summary>
    let isil = _prefixId.prefix "isil"
    /// <summary>
    ///   <para>rdfs:comment : Links a resource in the Northrhine-Westphalian Bibliography (NWBib) to a concept in NWBib's spatial classification.rdfs:comment : Verlinkt eine Ressource aus der Nordrhein-Westfälischen Bibliographie mit einer Systemstelle aus der NWBib-Ortssystematik.</para>
    ///   <para>rdfs:label : NWBib spatial subject headingrdfs:label : NWBib-Ortsschlagwort</para>
    ///   <a href="http://purl.org/lobid/lv#nwbibspatial">lv:nwbibspatial</a>
    /// </summary>
    let nwbibspatial = _prefixId.prefix "nwbibspatial"
    /// <summary>
    ///   <para>rdfs:comment : Links a resource in the Northrhine-Westphalian Bibliography (NWBib) to a concept in NWBib's subject classification.rdfs:comment : Verlinkt eine Ressource aus der Nordrhein-Westfälischen Bibliographie (NWBib) mit einer Systemstelle aus der NWBib-Sachsystematik.</para>
    ///   <para>rdfs:label : NWBib subject headingrdfs:label : NWBib-Sachschlagwort</para>
    ///   <a href="http://purl.org/lobid/lv#nwbibsubject">lv:nwbibsubject</a>
    /// </summary>
    let nwbibsubject = _prefixId.prefix "nwbibsubject"
    /// <summary>
    ///   <para>rdfs:comment : Regionalschlüssel der Region, in der sich die beschriebene raum-zeitliche Ressource befindet.rdfs:comment : Key of the region a spatial resource is located in.</para>
    ///   <para>rdfs:label : Region keyrdfs:label : Regionalschlüssel</para>
    ///   <a href="http://purl.org/lobid/lv#rs">lv:rs</a>
    /// </summary>
    let rs = _prefixId.prefix "rs"
    /// <summary>
    ///   <para>rdfs:comment : Indicates an institution's stock size. This property is especially used to indicate the size of a library's collection. It is recommended to be used with the controlled vocabulary at http://purl.org/lobid/stocksize.</para>
    ///   <para>rdfs:label : Bestandsgrößerdfs:label : Stock Size</para>
    ///   <a href="http://purl.org/lobid/lv#stocksize">lv:stocksize</a>
    /// </summary>
    let stocksize = _prefixId.prefix "stocksize"
    /// <summary>
    ///   <para>rdfs:comment : A pipe-separated list of subject terms, optionally followed by a comma-seperated list of permutations (in parentheses).</para>
    ///   <para>rdfs:label : Schlagwortfolgerdfs:label : Chain of subject terms</para>
    ///   <a href="http://purl.org/lobid/lv#subjectChain">lv:subjectChain</a>
    /// </summary>
    let subjectChain = _prefixId.prefix "subjectChain"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a title keyword, possibly in a different spelling than used in the original title.</para>
    ///   <para>rdfs:label : Titelstichwortrdfs:label : Title keyword</para>
    ///   <a href="http://purl.org/lobid/lv#titleKeyword">lv:titleKeyword</a>
    /// </summary>
    let titleKeyword = _prefixId.prefix "titleKeyword"
    /// <summary>
    ///   <para>rdfs:comment : This property is used to indicate the uniform resource name (URN) of a bibliographic resource. The URN must be stated as a string not as URI, thus identifying the identifier itself and not the resource that is identified by the URN.</para>
    ///   <para>rdfs:label : URNrdfs:label : URN</para>
    ///   <a href="http://purl.org/lobid/lv#urn">lv:urn</a>
    /// </summary>
    let urn = _prefixId.prefix "urn"
    /// <summary>
    ///   <para>rdfs:comment : This property is used to link the product of archiving a web page to the web page being archived.</para>
    ///   <para>rdfs:label : Archivierte Webseiterdfs:label : Web page archived</para>
    ///   <a href="http://purl.org/lobid/lv#webPageArchived">lv:webPageArchived</a>
    /// </summary>
    let webPageArchived = _prefixId.prefix "webPageArchived"
    /// <summary>
    ///   <para>rdfs:comment : The identifier that is assigned to a bibliographic resource in the German Journal Database (Zeitschriftendatenbank, ZDB).rdfs:comment : ZDB-Nummer. Der Identifier, der einer bibliographischen Ressource in der Zeitschriftendatenbank (ZDB) zugewiesen wurde.</para>
    ///   <para>rdfs:label : ZDB IDrdfs:label : ZDB-ID</para>
    ///   <a href="http://purl.org/lobid/lv#zdbID">lv:zdbID</a>
    /// </summary>
    let zdbID = _prefixId.prefix "zdbID"
