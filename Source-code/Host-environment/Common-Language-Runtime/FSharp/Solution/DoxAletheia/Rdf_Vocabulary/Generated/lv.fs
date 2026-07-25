namespace http.purl.org.lobid.lv.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lv =
    let _namespace_iri = Namespace_Iri lv |> NamespaceIRI
    /// <summary>
    ///   <para>lv:Biography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A detailed description or account of a person's life</para>
    ///   <para>Die Lebensbeschreibung einer Person.</para>
    /// labels<para>Biography</para><para>Biografie</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#Biography">http://purl.org/lobid/lv#Biography</seealso>
    let Biography = Prefixed_Name(lv, "Biography") |> PrefixedName
    /// <summary>
    ///   <para>lv:Festschrift</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A publication honoring a respected person, especially an academic.</para>
    ///   <para>Einem Gelehrten gewidmete Sammlung von Aufsätzen.</para>
    /// labels<para>Festschrift</para><para>Festschrift</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#Festschrift">http://purl.org/lobid/lv#Festschrift</seealso>
    let Festschrift = Prefixed_Name(lv, "Festschrift") |> PrefixedName
    /// <summary>
    ///   <para>lv:ArchivedWebPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Das Produkt der Archivierung einer Webseite.</para>
    ///   <para>An archival resource that is product of archiving a web page.</para>
    /// labels<para>Archivierte Webseite</para><para>Archived Web Page</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#ArchivedWebPage">http://purl.org/lobid/lv#ArchivedWebPage</seealso>
    let ArchivedWebPage = Prefixed_Name(lv, "ArchivedWebPage") |> PrefixedName
    /// <summary>
    ///   <para>lv:OfficialPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A publication that records the business and proceedings of a government agency.</para>
    ///   <para>Eine behördliche Publikation für amtliche Bekanntmachungen.</para>
    /// labels<para>Amtliche Veröffentlichung</para><para>Official Publication</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#OfficialPublication">http://purl.org/lobid/lv#OfficialPublication</seealso>
    let OfficialPublication = Prefixed_Name(lv, "OfficialPublication") |> PrefixedName
    /// <summary>
    ///   <para>lv:EditedVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>a collection of scholarly or scientific articles written by different authors</para>
    ///   <para>Ein Sammelwerk mit mehreren Beiträgen.</para>
    /// labels<para>Aufsatzsammlung</para><para>Edited Volume</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#EditedVolume">http://purl.org/lobid/lv#EditedVolume</seealso>
    let EditedVolume = Prefixed_Name(lv, "EditedVolume") |> PrefixedName
    /// <summary>
    ///   <para>lv:Bibliography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of documents relevant to a particular subject or author.</para>
    ///   <para>Eine Sammlung von Literaturnachweisen.</para>
    /// labels<para>Bibliografie</para><para>Bibliography</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#Bibliography">http://purl.org/lobid/lv#Bibliography</seealso>
    let Bibliography = Prefixed_Name(lv, "Bibliography") |> PrefixedName
    /// <summary>
    ///   <para>lv:webPageArchived</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to link the product of archiving a web page to the web page being archived.</para>
    /// labels<para>Archivierte Webseite</para><para>Web page archived</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#webPageArchived">http://purl.org/lobid/lv#webPageArchived</seealso>
    let webPageArchived = Prefixed_Name(lv, "webPageArchived") |> PrefixedName
    /// <summary>
    ///   <para>lv:Miscellaneous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Diese Klasse deckt alle Publikationstypen ab, die nicht durch bestehende Klassen erfasst sind. Sie dient insbesondere dem Angebot von Facetten für jene Publikationstypen, die in Bibliothekskatalogen selten zu finden sind.</para>
    ///   <para>This class covers all publication types that are not covered by existing class definitions. It is used to enable facets over seldomly found publication types in library catalogs.</para>
    /// labels<para>Miscellaneous</para><para>Sonstige</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#Miscellaneous">http://purl.org/lobid/lv#Miscellaneous</seealso>
    let Miscellaneous = Prefixed_Name(lv, "Miscellaneous") |> PrefixedName
    /// <summary>
    ///   <para>lv:Schoolbook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A textbook used by school teachers in their classes.</para>
    ///   <para>Ein Lehrbuch, das Schullehrer im Unterricht einsetzen.</para>
    /// labels<para>Schoolbook</para><para>Schulbuch</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#Schoolbook">http://purl.org/lobid/lv#Schoolbook</seealso>
    let Schoolbook = Prefixed_Name(lv, "Schoolbook") |> PrefixedName
    /// <summary>
    ///   <para>lv:ags</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Amtlicher Gemeindeschlüssel (AGS) of the region a spatial resource is located in.</para>
    ///   <para>Amtlicher Gemeindeschlüssel (AGS) der Region, in der sich die beschriebene raum-zeitliche Ressource befindet.</para>
    /// labels<para>Community Identification Number</para><para>Amtlicher Gemeindeschlüssel</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#ags">http://purl.org/lobid/lv#ags</seealso>
    let ags = Prefixed_Name(lv, "ags") |> PrefixedName
    /// <summary>
    ///   <para>lv:dbsID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>DBS-Nummer. Der Identifier, der einer Bibliothek innerhalb der Deutschen Bibliotheksstatistik (DBS) zugewiesen wurde.</para>
    ///   <para>The identifier that was assigned to a library in the context of the German Library Statistics (DBS).</para>
    /// labels<para>DBS ID</para><para>DBS-ID</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#dbsID">http://purl.org/lobid/lv#dbsID</seealso>
    let dbsID = Prefixed_Name(lv, "dbsID") |> PrefixedName
    /// <summary>
    ///   <para>lv:fulltextOnline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a bibliographic resource to an online resource (full text in HTML, PDFs or landing pages in OA repositories, on publishers' websites etc.) that represents the full text of the bibliographic resource or contains a link to a full text of the resource. </para>
    /// labels<para>Online-Volltext</para><para>Fulltext online</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#fulltextOnline">http://purl.org/lobid/lv#fulltextOnline</seealso>
    let fulltextOnline = Prefixed_Name(lv, "fulltextOnline") |> PrefixedName
    /// <summary>
    ///   <para>lv:fundertype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates which type an institution's funder is of. It should be used with a controlled vocabulary like http://purl.org/lobid/fundertype.</para>
    /// labels<para>Type of funding organization</para><para>Art des Unterhaltträgers</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#fundertype">http://purl.org/lobid/lv#fundertype</seealso>
    let fundertype = Prefixed_Name(lv, "fundertype") |> PrefixedName
    /// <summary>
    ///   <para>lv:nwbibspatial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a resource in the Northrhine-Westphalian Bibliography (NWBib) to a concept in NWBib's spatial classification.</para>
    ///   <para>Verlinkt eine Ressource aus der Nordrhein-Westfälischen Bibliographie mit einer Systemstelle aus der NWBib-Ortssystematik.</para>
    /// labels<para>NWBib spatial subject heading</para><para>NWBib-Ortsschlagwort</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#nwbibspatial">http://purl.org/lobid/lv#nwbibspatial</seealso>
    let nwbibspatial = Prefixed_Name(lv, "nwbibspatial") |> PrefixedName
    /// <summary>
    ///   <para>lv:nwbibsubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a resource in the Northrhine-Westphalian Bibliography (NWBib) to a concept in NWBib's subject classification.</para>
    ///   <para>Verlinkt eine Ressource aus der Nordrhein-Westfälischen Bibliographie (NWBib) mit einer Systemstelle aus der NWBib-Sachsystematik.</para>
    /// labels<para>NWBib subject heading</para><para>NWBib-Sachschlagwort</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#nwbibsubject">http://purl.org/lobid/lv#nwbibsubject</seealso>
    let nwbibsubject = Prefixed_Name(lv, "nwbibsubject") |> PrefixedName
    /// <summary>
    ///   <para>lv:titleKeyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates a title keyword, possibly in a different spelling than used in the original title.</para>
    /// labels<para>Titelstichwort</para><para>Title keyword</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#titleKeyword">http://purl.org/lobid/lv#titleKeyword</seealso>
    let titleKeyword = Prefixed_Name(lv, "titleKeyword") |> PrefixedName
    /// <summary>
    ///   <para>lv:urn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property is used to indicate the uniform resource name (URN) of a bibliographic resource. The URN must be stated as a string not as URI, thus identifying the identifier itself and not the resource that is identified by the URN.</para>
    /// labels<para>URN</para><para>URN</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#urn">http://purl.org/lobid/lv#urn</seealso>
    let urn = Prefixed_Name(lv, "urn") |> PrefixedName
    /// <summary>
    ///   <para>lv:contactqr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a person, organization or other agent to a QR code that encodes the agent's contact information.</para>
    /// labels<para>Kontakt-QR-Code</para><para>Contact QR code</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#contactqr">http://purl.org/lobid/lv#contactqr</seealso>
    let contactqr = Prefixed_Name(lv, "contactqr") |> PrefixedName
    /// <summary>
    ///   <para>lv:isil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>International Standard Identifier for Libraries and Related Organizations (ISIL). 'An ISIL identifies an organization, i.e., a library or a related organization, or one of its subordinate units, which is responsible for an action or service in a bibliographic environment (e.g. creation of machine-readable information). It can be used to identify the originator or holder of a resource (e.g. library material).' The literal should conform to this regular expression: [A-Z]{1,4}-[0-9a-zA-Z:-/]{1,11} .</para>
    ///   <para>International Standard Identifier for Libraries and Related Organizations (ISIL). Ein eindeutiger Identifikator für Bibliotheken und verwandte Einrichtungen oder untergeordnete Organisationseinheiten, der durch ISIL-Agenturen vergeben wird. Das Literal sollte durch den folgenden regulären Ausdruck gematcht werden: [A-Z]{1,4}-[0-9a-zA-Z:-/]{1,11} .</para>
    /// labels<para>ISIL</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#isil">http://purl.org/lobid/lv#isil</seealso>
    let isil = Prefixed_Name(lv, "isil") |> PrefixedName
    /// <summary>
    ///   <para>lv:hbzID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>HT-Nummer. Der Identifier, der einer bibliographischen Ressource im hbz-Verbundkatalog zugewiesen wurde.</para>
    ///   <para>The identifier that is assigned to a bibliographic resource in the hbz union catalogue.</para>
    /// labels<para>hbz ID</para><para>hbz-ID</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#hbzID">http://purl.org/lobid/lv#hbzID</seealso>
    let hbzID = Prefixed_Name(lv, "hbzID") |> PrefixedName
    /// <summary>
    ///   <para>lv:subjectChain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A pipe-separated list of subject terms, optionally followed by a comma-seperated list of permutations (in parentheses).</para>
    /// labels<para>Chain of subject terms</para><para>Schlagwortfolge</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#subjectChain">http://purl.org/lobid/lv#subjectChain</seealso>
    let subjectChain = Prefixed_Name(lv, "subjectChain") |> PrefixedName
    /// <summary>
    ///   <para>lv:zdbID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The identifier that is assigned to a bibliographic resource in the German Journal Database (Zeitschriftendatenbank, ZDB).</para>
    ///   <para>ZDB-Nummer. Der Identifier, der einer bibliographischen Ressource in der Zeitschriftendatenbank (ZDB) zugewiesen wurde.</para>
    /// labels<para>ZDB-ID</para><para>ZDB ID</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#zdbID">http://purl.org/lobid/lv#zdbID</seealso>
    let zdbID = Prefixed_Name(lv, "zdbID") |> PrefixedName
    /// <summary>
    ///   <para>lv:rs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Key of the region a spatial resource is located in.</para>
    ///   <para>Regionalschlüssel der Region, in der sich die beschriebene raum-zeitliche Ressource befindet.</para>
    /// labels<para>Regionalschlüssel</para><para>Region key</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#rs">http://purl.org/lobid/lv#rs</seealso>
    let rs = Prefixed_Name(lv, "rs") |> PrefixedName
    /// <summary>
    ///   <para>lv:stocksize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates an institution's stock size. This property is especially used to indicate the size of a library's collection. It is recommended to be used with the controlled vocabulary at http://purl.org/lobid/stocksize.</para>
    /// labels<para>Bestandsgröße</para><para>Stock Size</para></remarks>
    /// <seealso href="http://purl.org/lobid/lv#stocksize">http://purl.org/lobid/lv#stocksize</seealso>
    let stocksize = Prefixed_Name(lv, "stocksize") |> PrefixedName
