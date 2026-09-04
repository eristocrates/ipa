#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module bibo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/ontology/bibo/" "bibo"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Academic Article</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A scholarly academic article, typically published in a journal.</para>
    ///   <a href="http://purl.org/ontology/bibo/AcademicArticle">bibo:AcademicArticle</a>
    /// </summary>
    let AcademicArticle = _prefixId.prefix "AcademicArticle"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Article</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A written composition in prose, usually nonfiction, on a specific topic, forming an independent part of a book or other publication, as a newspaper or magazine.</para>
    ///   <a href="http://purl.org/ontology/bibo/Article">bibo:Article</a>
    /// </summary>
    let Article = _prefixId.prefix "Article"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : audio document</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An audio document; aka record.</para>
    ///   <a href="http://purl.org/ontology/bibo/AudioDocument">bibo:AudioDocument</a>
    /// </summary>
    let AudioDocument = _prefixId.prefix "AudioDocument"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : audio-visual document</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An audio-visual document; film, video, and so forth.</para>
    ///   <a href="http://purl.org/ontology/bibo/AudioVisualDocument">bibo:AudioVisualDocument</a>
    /// </summary>
    let AudioVisualDocument = _prefixId.prefix "AudioVisualDocument"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Bill</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Draft legislation presented for discussion to a legal body.</para>
    ///   <a href="http://purl.org/ontology/bibo/Bill">bibo:Bill</a>
    /// </summary>
    let Bill = _prefixId.prefix "Bill"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Book</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A written or printed work of fiction or nonfiction, usually on sheets of paper fastened or bound together within covers.</para>
    ///   <a href="http://purl.org/ontology/bibo/Book">bibo:Book</a>
    /// </summary>
    let Book = _prefixId.prefix "Book"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Book Section</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A section of a book.</para>
    ///   <a href="http://purl.org/ontology/bibo/BookSection">bibo:BookSection</a>
    /// </summary>
    let BookSection = _prefixId.prefix "BookSection"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Brief</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A written argument submitted to a court.</para>
    ///   <a href="http://purl.org/ontology/bibo/Brief">bibo:Brief</a>
    /// </summary>
    let Brief = _prefixId.prefix "Brief"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Chapter</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A chapter of a book.</para>
    ///   <a href="http://purl.org/ontology/bibo/Chapter">bibo:Chapter</a>
    /// </summary>
    let Chapter = _prefixId.prefix "Chapter"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Code</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A collection of statutes.</para>
    ///   <a href="http://purl.org/ontology/bibo/Code">bibo:Code</a>
    /// </summary>
    let Code = _prefixId.prefix "Code"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Collected Document</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A document that simultaneously contains other documents.</para>
    ///   <a href="http://purl.org/ontology/bibo/CollectedDocument">bibo:CollectedDocument</a>
    /// </summary>
    let CollectedDocument = _prefixId.prefix "CollectedDocument"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Collection</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A collection of Documents or Collections</para>
    ///   <a href="http://purl.org/ontology/bibo/Collection">bibo:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Conference</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A meeting for consultation or discussion.</para>
    ///   <a href="http://purl.org/ontology/bibo/Conference">bibo:Conference</a>
    /// </summary>
    let Conference = _prefixId.prefix "Conference"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Court Reporter</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A collection of legal cases.</para>
    ///   <a href="http://purl.org/ontology/bibo/CourtReporter">bibo:CourtReporter</a>
    /// </summary>
    let CourtReporter = _prefixId.prefix "CourtReporter"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Document</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A document (noun) is a bounded physical representation of body of information designed with the capacity (and usually intent) to communicate. A document may manifest symbolic, diagrammatic or sensory-representational information.</para>
    ///   <a href="http://purl.org/ontology/bibo/Document">bibo:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : document part</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : a distinct part of a larger document or collected document.</para>
    ///   <a href="http://purl.org/ontology/bibo/DocumentPart">bibo:DocumentPart</a>
    /// </summary>
    let DocumentPart = _prefixId.prefix "DocumentPart"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Document Status</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The status of the publication of a document.</para>
    ///   <a href="http://purl.org/ontology/bibo/DocumentStatus">bibo:DocumentStatus</a>
    /// </summary>
    let DocumentStatus = _prefixId.prefix "DocumentStatus"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Edited Book</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An edited book.</para>
    ///   <a href="http://purl.org/ontology/bibo/EditedBook">bibo:EditedBook</a>
    /// </summary>
    let EditedBook = _prefixId.prefix "EditedBook"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : EMail</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A written communication addressed to a person or organization and transmitted electronically.</para>
    ///   <a href="http://purl.org/ontology/bibo/Email">bibo:Email</a>
    /// </summary>
    let Email = _prefixId.prefix "Email"
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Excerpt</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A passage selected from a larger work.</para>
    ///   <a href="http://purl.org/ontology/bibo/Excerpt">bibo:Excerpt</a>
    /// </summary>
    let Excerpt = _prefixId.prefix "Excerpt"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Film</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : aka movie.</para>
    ///   <a href="http://purl.org/ontology/bibo/Film">bibo:Film</a>
    /// </summary>
    let Film = _prefixId.prefix "Film"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Hearing</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An instance or a session in which testimony and arguments are presented, esp. before an official, as a judge in a lawsuit.</para>
    ///   <a href="http://purl.org/ontology/bibo/Hearing">bibo:Hearing</a>
    /// </summary>
    let Hearing = _prefixId.prefix "Hearing"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Image</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A document that presents visual or diagrammatic information.</para>
    ///   <a href="http://purl.org/ontology/bibo/Image">bibo:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Interview</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A formalized discussion between two or more people.</para>
    ///   <a href="http://purl.org/ontology/bibo/Interview">bibo:Interview</a>
    /// </summary>
    let Interview = _prefixId.prefix "Interview"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Issue</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : something that is printed or published and distributed, esp. a given number of a periodical</para>
    ///   <a href="http://purl.org/ontology/bibo/Issue">bibo:Issue</a>
    /// </summary>
    let Issue = _prefixId.prefix "Issue"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Journal</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A periodical of scholarly journal Articles.</para>
    ///   <a href="http://purl.org/ontology/bibo/Journal">bibo:Journal</a>
    /// </summary>
    let Journal = _prefixId.prefix "Journal"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Legal Case Document</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A document accompanying a legal case.</para>
    ///   <a href="http://purl.org/ontology/bibo/LegalCaseDocument">bibo:LegalCaseDocument</a>
    /// </summary>
    let LegalCaseDocument = _prefixId.prefix "LegalCaseDocument"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Decision</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A document containing an authoritative determination (as a decree or judgment) made after consideration of facts or law.</para>
    ///   <a href="http://purl.org/ontology/bibo/LegalDecision">bibo:LegalDecision</a>
    /// </summary>
    let LegalDecision = _prefixId.prefix "LegalDecision"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Legal Document</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A legal document; for example, a court decision, a brief, and so forth.</para>
    ///   <a href="http://purl.org/ontology/bibo/LegalDocument">bibo:LegalDocument</a>
    /// </summary>
    let LegalDocument = _prefixId.prefix "LegalDocument"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Legislation</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A legal document proposing or enacting a law or a group of laws.</para>
    ///   <a href="http://purl.org/ontology/bibo/Legislation">bibo:Legislation</a>
    /// </summary>
    let Legislation = _prefixId.prefix "Legislation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Letter</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A written or printed communication addressed to a person or organization and usually transmitted by mail.</para>
    ///   <a href="http://purl.org/ontology/bibo/Letter">bibo:Letter</a>
    /// </summary>
    let Letter = _prefixId.prefix "Letter"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Magazine</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A periodical of magazine Articles. A magazine is a publication that is issued periodically, usually bound in a paper cover, and typically contains essays, stories, poems, etc., by many writers, and often photographs and drawings, frequently specializing in a particular subject or area, as hobbies, news, or sports.</para>
    ///   <a href="http://purl.org/ontology/bibo/Magazine">bibo:Magazine</a>
    /// </summary>
    let Magazine = _prefixId.prefix "Magazine"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Manual</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A small reference book, especially one giving instructions.</para>
    ///   <a href="http://purl.org/ontology/bibo/Manual">bibo:Manual</a>
    /// </summary>
    let Manual = _prefixId.prefix "Manual"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Manuscript</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An unpublished Document, which may also be submitted to a publisher for publication.</para>
    ///   <a href="http://purl.org/ontology/bibo/Manuscript">bibo:Manuscript</a>
    /// </summary>
    let Manuscript = _prefixId.prefix "Manuscript"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Map</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A graphical depiction of geographic features.</para>
    ///   <a href="http://purl.org/ontology/bibo/Map">bibo:Map</a>
    /// </summary>
    let Map = _prefixId.prefix "Map"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Series</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A loose, thematic, collection of Documents, often Books.</para>
    ///   <a href="http://purl.org/ontology/bibo/MultiVolumeBook">bibo:MultiVolumeBook</a>
    /// </summary>
    let MultiVolumeBook = _prefixId.prefix "MultiVolumeBook"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Newspaper</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A periodical of documents, usually issued daily or weekly, containing current news, editorials, feature articles, and usually advertising.</para>
    ///   <a href="http://purl.org/ontology/bibo/Newspaper">bibo:Newspaper</a>
    /// </summary>
    let Newspaper = _prefixId.prefix "Newspaper"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Note</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Notes or annotations about a resource.</para>
    ///   <a href="http://purl.org/ontology/bibo/Note">bibo:Note</a>
    /// </summary>
    let Note = _prefixId.prefix "Note"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Patent</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A document describing the exclusive right granted by a government to an inventor to manufacture, use, or sell an invention for a certain number of years.</para>
    ///   <a href="http://purl.org/ontology/bibo/Patent">bibo:Patent</a>
    /// </summary>
    let Patent = _prefixId.prefix "Patent"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Performance</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A public performance.</para>
    ///   <a href="http://purl.org/ontology/bibo/Performance">bibo:Performance</a>
    /// </summary>
    let Performance = _prefixId.prefix "Performance"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Periodical</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A group of related documents issued at regular intervals.</para>
    ///   <a href="http://purl.org/ontology/bibo/Periodical">bibo:Periodical</a>
    /// </summary>
    let Periodical = _prefixId.prefix "Periodical"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Personal Communication</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A communication between an agent and one or more specific recipients.</para>
    ///   <a href="http://purl.org/ontology/bibo/PersonalCommunication">bibo:PersonalCommunication</a>
    /// </summary>
    let PersonalCommunication = _prefixId.prefix "PersonalCommunication"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Personal Communication Document</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A personal communication manifested in some document.</para>
    ///   <a href="http://purl.org/ontology/bibo/PersonalCommunicationDocument">bibo:PersonalCommunicationDocument</a>
    /// </summary>
    let PersonalCommunicationDocument = _prefixId.prefix "PersonalCommunicationDocument"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Proceedings</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A compilation of documents published from an event, such as a conference.</para>
    ///   <a href="http://purl.org/ontology/bibo/Proceedings">bibo:Proceedings</a>
    /// </summary>
    let Proceedings = _prefixId.prefix "Proceedings"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Quote</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An excerpted collection of words.</para>
    ///   <a href="http://purl.org/ontology/bibo/Quote">bibo:Quote</a>
    /// </summary>
    let Quote = _prefixId.prefix "Quote"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Reference Source</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A document that presents authoritative reference information, such as a dictionary or encylopedia .</para>
    ///   <a href="http://purl.org/ontology/bibo/ReferenceSource">bibo:ReferenceSource</a>
    /// </summary>
    let ReferenceSource = _prefixId.prefix "ReferenceSource"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Report</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A document describing an account or statement describing in detail an event, situation, or the like, usually as the result of observation, inquiry, etc..</para>
    ///   <a href="http://purl.org/ontology/bibo/Report">bibo:Report</a>
    /// </summary>
    let Report = _prefixId.prefix "Report"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Series</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A loose, thematic, collection of Documents, often Books.</para>
    ///   <a href="http://purl.org/ontology/bibo/Series">bibo:Series</a>
    /// </summary>
    let Series = _prefixId.prefix "Series"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Slide</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A slide in a slideshow</para>
    ///   <a href="http://purl.org/ontology/bibo/Slide">bibo:Slide</a>
    /// </summary>
    let Slide = _prefixId.prefix "Slide"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Slideshow</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A presentation of a series of slides, usually presented in front of an audience with written text and images.</para>
    ///   <a href="http://purl.org/ontology/bibo/Slideshow">bibo:Slideshow</a>
    /// </summary>
    let Slideshow = _prefixId.prefix "Slideshow"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Standard</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A document describing a standard</para>
    ///   <a href="http://purl.org/ontology/bibo/Standard">bibo:Standard</a>
    /// </summary>
    let Standard = _prefixId.prefix "Standard"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Statute</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A bill enacted into law.</para>
    ///   <a href="http://purl.org/ontology/bibo/Statute">bibo:Statute</a>
    /// </summary>
    let Statute = _prefixId.prefix "Statute"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Thesis</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A document created to summarize research findings associated with the completion of an academic degree.</para>
    ///   <a href="http://purl.org/ontology/bibo/Thesis">bibo:Thesis</a>
    /// </summary>
    let Thesis = _prefixId.prefix "Thesis"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Thesis degree</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The academic degree of a Thesis</para>
    ///   <a href="http://purl.org/ontology/bibo/ThesisDegree">bibo:ThesisDegree</a>
    /// </summary>
    let ThesisDegree = _prefixId.prefix "ThesisDegree"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Webpage</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A web page is an online document available (at least initially) on the world wide web. A web page is written first and foremost to appear on the web, as distinct from other online resources such as books, manuscripts or audio documents which use the web primarily as a distribution mechanism alongside other more traditional methods such as print.</para>
    ///   <a href="http://purl.org/ontology/bibo/Webpage">bibo:Webpage</a>
    /// </summary>
    let Webpage = _prefixId.prefix "Webpage"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Website</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A group of Webpages accessible on the Web.</para>
    ///   <a href="http://purl.org/ontology/bibo/Website">bibo:Website</a>
    /// </summary>
    let Website = _prefixId.prefix "Website"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Workshop</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A seminar, discussion group, or the like, that emphasizes zxchange of ideas and the demonstration and application of techniques, skills, etc.</para>
    ///   <a href="http://purl.org/ontology/bibo/Workshop">bibo:Workshop</a>
    /// </summary>
    let Workshop = _prefixId.prefix "Workshop"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : abstract^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/dc/terms/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A summary of the resource.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/bibo/abstract">bibo:abstract</a>
    /// </summary>
    let abstract_ = _prefixId.prefix "abstract"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A legal decision that affirms a ruling.</para>
    ///   <a href="http://purl.org/ontology/bibo/affirmedBy">bibo:affirmedBy</a>
    /// </summary>
    let affirmedBy = _prefixId.prefix "affirmedBy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : annotates</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Critical or explanatory note for a Document.</para>
    ///   <a href="http://purl.org/ontology/bibo/annotates">bibo:annotates</a>
    /// </summary>
    let annotates = _prefixId.prefix "annotates"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : date argued</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The date on which a legal case is argued before a court. Date is of format xsd:date</para>
    ///   <a href="http://purl.org/ontology/bibo/argued">bibo:argued</a>
    /// </summary>
    let argued = _prefixId.prefix "argued"
    let asin = _prefixId.prefix "asin"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : list of authors</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An ordered list of authors. Normally, this list is seen as a priority list that order authors by importance.</para>
    ///   <a href="http://purl.org/ontology/bibo/authorList">bibo:authorList</a>
    /// </summary>
    let authorList = _prefixId.prefix "authorList"
    let bdarcus = _prefixId.prefix "bdarcus"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : chapter</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An chapter number</para>
    ///   <a href="http://purl.org/ontology/bibo/chapter">bibo:chapter</a>
    /// </summary>
    let chapter = _prefixId.prefix "chapter"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : cited by</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Relates a document to another document that cites the
    /// first document.</para>
    ///   <a href="http://purl.org/ontology/bibo/citedBy">bibo:citedBy</a>
    /// </summary>
    let citedBy = _prefixId.prefix "citedBy"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : cites</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Relates a document to another document that is cited
    /// by the first document as reference, comment, review, quotation or for
    /// another purpose.</para>
    ///   <a href="http://purl.org/ontology/bibo/cites">bibo:cites</a>
    /// </summary>
    let cites = _prefixId.prefix "cites"
    let coden = _prefixId.prefix "coden"
    /// <summary>
    ///   <para>skos:historyNote : bibo:content has been deprecated; we recommend to use "rdf:value" for this purpose. Here is the rational behind this choice: http://www.w3.org/TR/2004/REC-rdf-primer-20040210/#rdfvalue</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : content</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : This property is for a plain-text rendering of the content of a Document. While the plain-text content of an entire document could be described by this property.</para>
    ///   <a href="http://purl.org/ontology/bibo/content">bibo:content</a>
    /// </summary>
    let content = _prefixId.prefix "content"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : list of contributors</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An ordered list of contributors. Normally, this list is seen as a priority list that order contributors by importance.</para>
    ///   <a href="http://purl.org/ontology/bibo/contributorList">bibo:contributorList</a>
    /// </summary>
    let contributorList = _prefixId.prefix "contributorList"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : court</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A court associated with a legal document; for example, that which issues a decision.</para>
    ///   <a href="http://purl.org/ontology/bibo/court">bibo:court</a>
    /// </summary>
    let court = _prefixId.prefix "court"
    /// <summary>
    ///   <para>skos:editorialNote : We are not defining, using an enumeration, the range of the bibo:degree to the defined list of bibo:ThesisDegree. We won't do it because we want people to be able to define new degress if needed by some special usecases. Creating such an enumeration would restrict this to happen.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : degree</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The thesis degree.</para>
    ///   <a href="http://purl.org/ontology/bibo/degree">bibo:degree</a>
    /// </summary>
    let degree = _prefixId.prefix "degree"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : director^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A Film director.</para>
    ///   <a href="http://purl.org/ontology/bibo/director">bibo:director</a>
    /// </summary>
    let director = _prefixId.prefix "director"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : distributor</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Distributor of a document or a collection of documents.</para>
    ///   <a href="http://purl.org/ontology/bibo/distributor">bibo:distributor</a>
    /// </summary>
    let distributor = _prefixId.prefix "distributor"
    let doi = _prefixId.prefix "doi"
    let eanucc13 = _prefixId.prefix "eanucc13"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : edition</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The name defining a special edition of a document. Normally its a literal value composed of a version number and words.</para>
    ///   <a href="http://purl.org/ontology/bibo/edition">bibo:edition</a>
    /// </summary>
    let edition = _prefixId.prefix "edition"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : editor^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A person having managerial and sometimes policy-making responsibility for the editorial part of a publishing firm or of a newspaper, magazine, or other publication.</para>
    ///   <a href="http://purl.org/ontology/bibo/editor">bibo:editor</a>
    /// </summary>
    let editor = _prefixId.prefix "editor"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : list of editors</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An ordered list of editors. Normally, this list is seen as a priority list that order editors by importance.</para>
    ///   <a href="http://purl.org/ontology/bibo/editorList">bibo:editorList</a>
    /// </summary>
    let editorList = _prefixId.prefix "editorList"
    let eissn = _prefixId.prefix "eissn"
    let fgiasson = _prefixId.prefix "fgiasson"
    let gtin14 = _prefixId.prefix "gtin14"
    let handle = _prefixId.prefix "handle"
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : interviewee^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An agent that is interviewed by another agent.</para>
    ///   <a href="http://purl.org/ontology/bibo/interviewee">bibo:interviewee</a>
    /// </summary>
    let interviewee = _prefixId.prefix "interviewee"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : interviewer^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An agent that interview another agent.</para>
    ///   <a href="http://purl.org/ontology/bibo/interviewer">bibo:interviewer</a>
    /// </summary>
    let interviewer = _prefixId.prefix "interviewer"
    let isbn = _prefixId.prefix "isbn"
    let isbn10 = _prefixId.prefix "isbn10"
    let isbn13 = _prefixId.prefix "isbn13"
    let issn = _prefixId.prefix "issn"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : issue</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An issue number</para>
    ///   <a href="http://purl.org/ontology/bibo/issue">bibo:issue</a>
    /// </summary>
    let issue = _prefixId.prefix "issue"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : issuer^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An entity responsible for issuing often informally published documents such as press releases, reports, etc.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/bibo/issuer">bibo:issuer</a>
    /// </summary>
    let issuer = _prefixId.prefix "issuer"
    let lccn = _prefixId.prefix "lccn"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : locator</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A description (often numeric) that locates an item within a containing document or collection.</para>
    ///   <a href="http://purl.org/ontology/bibo/locator">bibo:locator</a>
    /// </summary>
    let locator = _prefixId.prefix "locator"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : number of pages</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The number of pages contained in a document</para>
    ///   <a href="http://purl.org/ontology/bibo/numPages">bibo:numPages</a>
    /// </summary>
    let numPages = _prefixId.prefix "numPages"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : number of volumes</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The number of volumes contained in a collection of documents (usually a series, periodical, etc.).</para>
    ///   <a href="http://purl.org/ontology/bibo/numVolumes">bibo:numVolumes</a>
    /// </summary>
    let numVolumes = _prefixId.prefix "numVolumes"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : number</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A generic item or document number. Not to be confused with issue number.</para>
    ///   <a href="http://purl.org/ontology/bibo/number">bibo:number</a>
    /// </summary>
    let number = _prefixId.prefix "number"
    let oclcnum = _prefixId.prefix "oclcnum"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : organizer</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The organizer of an event; includes conference organizers, but also government agencies or other bodies that are responsible for conducting hearings.</para>
    ///   <a href="http://purl.org/ontology/bibo/organizer">bibo:organizer</a>
    /// </summary>
    let organizer = _prefixId.prefix "organizer"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : owner</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Owner of a document or a collection of documents.</para>
    ///   <a href="http://purl.org/ontology/bibo/owner">bibo:owner</a>
    /// </summary>
    let owner = _prefixId.prefix "owner"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : page end</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Ending page number within a continuous page range.</para>
    ///   <a href="http://purl.org/ontology/bibo/pageEnd">bibo:pageEnd</a>
    /// </summary>
    let pageEnd = _prefixId.prefix "pageEnd"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : page start</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Starting page number within a continuous page range.</para>
    ///   <a href="http://purl.org/ontology/bibo/pageStart">bibo:pageStart</a>
    /// </summary>
    let pageStart = _prefixId.prefix "pageStart"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : pages</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A string of non-contiguous page spans that locate a Document within a Collection. Example: 23-25, 34, 54-56. For continuous page ranges, use the pageStart and pageEnd properties.</para>
    ///   <a href="http://purl.org/ontology/bibo/pages">bibo:pages</a>
    /// </summary>
    let pages = _prefixId.prefix "pages"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : performer^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <a href="http://purl.org/ontology/bibo/performer">bibo:performer</a>
    /// </summary>
    let performer = _prefixId.prefix "performer"
    let pmid = _prefixId.prefix "pmid"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : prefix name</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The prefix of a name</para>
    ///   <a href="http://purl.org/ontology/bibo/prefixName">bibo:prefixName</a>
    /// </summary>
    let prefixName = _prefixId.prefix "prefixName"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : presented at</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Relates a document to an event; for example, a paper to a conference.</para>
    ///   <a href="http://purl.org/ontology/bibo/presentedAt">bibo:presentedAt</a>
    /// </summary>
    let presentedAt = _prefixId.prefix "presentedAt"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : presented at</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Relates an event to associated documents; for example, conference to a paper.</para>
    ///   <a href="http://purl.org/ontology/bibo/presents">bibo:presents</a>
    /// </summary>
    let presents = _prefixId.prefix "presents"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : producer</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Producer of a document or a collection of documents.</para>
    ///   <a href="http://purl.org/ontology/bibo/producer">bibo:producer</a>
    /// </summary>
    let producer = _prefixId.prefix "producer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : recipient^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An agent that receives a communication document.</para>
    ///   <a href="http://purl.org/ontology/bibo/recipient">bibo:recipient</a>
    /// </summary>
    let recipient = _prefixId.prefix "recipient"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The resource in which another resource is reproduced.</para>
    ///   <a href="http://purl.org/ontology/bibo/reproducedIn">bibo:reproducedIn</a>
    /// </summary>
    let reproducedIn = _prefixId.prefix "reproducedIn"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A legal decision that reverses a ruling.</para>
    ///   <a href="http://purl.org/ontology/bibo/reversedBy">bibo:reversedBy</a>
    /// </summary>
    let reversedBy = _prefixId.prefix "reversedBy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : review of</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Relates a review document to a reviewed thing (resource, item, etc.).</para>
    ///   <a href="http://purl.org/ontology/bibo/reviewOf">bibo:reviewOf</a>
    /// </summary>
    let reviewOf = _prefixId.prefix "reviewOf"
    /// <summary>
    ///   <para>skos:example : Di Rado, Alicia. 1995. Trekking through college: Classes explore
    /// modern society using the world of Star trek. Los Angeles Times, March
    /// 15, sec. A, p. 3.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : section</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A section number</para>
    ///   <a href="http://purl.org/ontology/bibo/section">bibo:section</a>
    /// </summary>
    let section = _prefixId.prefix "section"
    let shortDescription = _prefixId.prefix "shortDescription"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : short title</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The abbreviation of a title.</para>
    ///   <a href="http://purl.org/ontology/bibo/shortTitle">bibo:shortTitle</a>
    /// </summary>
    let shortTitle = _prefixId.prefix "shortTitle"
    let sici = _prefixId.prefix "sici"
    /// <summary>
    ///   <para>skos:editorialNote : We are not defining, using an enumeration, the range of the bibo:status to the defined list of bibo:DocumentStatus. We won't do it because we want people to be able to define new status if needed by some special usecases. Creating such an enumeration would restrict this to happen.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : status</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The publication status of (typically academic) content.</para>
    ///   <a href="http://purl.org/ontology/bibo/status">bibo:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A legal decision on appeal that takes action on a case (affirming it, reversing it, etc.).</para>
    ///   <a href="http://purl.org/ontology/bibo/subsequentLegalDecision">bibo:subsequentLegalDecision</a>
    /// </summary>
    let subsequentLegalDecision = _prefixId.prefix "subsequentLegalDecision"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : suffix name</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The suffix of a name</para>
    ///   <a href="http://purl.org/ontology/bibo/suffixName">bibo:suffixName</a>
    /// </summary>
    let suffixName = _prefixId.prefix "suffixName"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : transcript of</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Relates a document to some transcribed original.</para>
    ///   <a href="http://purl.org/ontology/bibo/transcriptOf">bibo:transcriptOf</a>
    /// </summary>
    let transcriptOf = _prefixId.prefix "transcriptOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : translation of</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Relates a translated document to the original document.</para>
    ///   <a href="http://purl.org/ontology/bibo/translationOf">bibo:translationOf</a>
    /// </summary>
    let translationOf = _prefixId.prefix "translationOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : translator^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A person who translates written document from one language to another.</para>
    ///   <a href="http://purl.org/ontology/bibo/translator">bibo:translator</a>
    /// </summary>
    let translator = _prefixId.prefix "translator"
    let upc = _prefixId.prefix "upc"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : uri</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Universal Resource Identifier of a document</para>
    ///   <a href="http://purl.org/ontology/bibo/uri">bibo:uri</a>
    /// </summary>
    let uri = _prefixId.prefix "uri"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : volume</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/ontology/bibo/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A volume number</para>
    ///   <a href="http://purl.org/ontology/bibo/volume">bibo:volume</a>
    /// </summary>
    let volume = _prefixId.prefix "volume"
