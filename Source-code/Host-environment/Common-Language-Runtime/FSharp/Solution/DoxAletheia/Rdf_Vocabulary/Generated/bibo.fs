namespace http.purl.org.ontology.bibo.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bibo =
    let _namespace_iri = Namespace_Iri bibo |> NamespaceIRI
    /// <summary>
    ///   <para>bibo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Bibontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/">http://purl.org/ontology/bibo/</seealso>
    let _prefix_iri = Prefixed_Name(bibo, "") |> PrefixedName
    /// <summary>
    ///   <para>bibo:AcademicArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A scholarly academic article, typically published in a journal."</para>
    /// labels<para>"Academic Article"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Academic article"</para><para>"Academic Article"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/AcademicArticle">http://purl.org/ontology/bibo/AcademicArticle</seealso>
    let AcademicArticle = Prefixed_Name(bibo, "AcademicArticle") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Article</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A written composition in prose, usually nonfiction, on a specific topic, forming an independent part of a book or other publication, as a newspaper or magazine."</para>
    /// labels<para>"Article"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Article"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Article">http://purl.org/ontology/bibo/Article</seealso>
    let Article = Prefixed_Name(bibo, "Article") |> PrefixedName
    /// <summary>
    ///   <para>bibo:AudioDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An audio document; aka record."</para>
    /// labels<para>"Audio Document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"audio document"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/AudioDocument">http://purl.org/ontology/bibo/AudioDocument</seealso>
    let AudioDocument = Prefixed_Name(bibo, "AudioDocument") |> PrefixedName
    /// <summary>
    ///   <para>bibo:AudioVisualDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An audio-visual document; film, video, and so forth."</para>
    /// labels<para>"audio-visual document"</para><para>"Audio-Visual Document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/AudioVisualDocument">http://purl.org/ontology/bibo/AudioVisualDocument</seealso>
    let AudioVisualDocument = Prefixed_Name(bibo, "AudioVisualDocument") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Bill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Draft legislation presented for discussion to a legal body."</para>
    /// labels<para>"Bill"</para><para>"Bill"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Bill">http://purl.org/ontology/bibo/Bill</seealso>
    let Bill = Prefixed_Name(bibo, "Bill") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Book</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A written or printed work of fiction or nonfiction, usually on sheets of paper fastened or bound together within covers."</para>
    /// labels<para>"Book"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Book"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Book">http://purl.org/ontology/bibo/Book</seealso>
    let Book = Prefixed_Name(bibo, "Book") |> PrefixedName
    /// <summary>
    ///   <para>bibo:BookSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A section of a book."</para>
    /// labels<para>"Book Section"</para><para>"Book Section"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/BookSection">http://purl.org/ontology/bibo/BookSection</seealso>
    let BookSection = Prefixed_Name(bibo, "BookSection") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Brief</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A written argument submitted to a court."</para>
    /// labels<para>"Brief"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Brief"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Brief">http://purl.org/ontology/bibo/Brief</seealso>
    let Brief = Prefixed_Name(bibo, "Brief") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Chapter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A chapter of a book."</para>
    /// labels<para>"Chapter"</para><para>"Chapter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Chapter">http://purl.org/ontology/bibo/Chapter</seealso>
    let Chapter = Prefixed_Name(bibo, "Chapter") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of statutes."</para>
    /// labels<para>"Code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Code"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Code">http://purl.org/ontology/bibo/Code</seealso>
    let Code = Prefixed_Name(bibo, "Code") |> PrefixedName
    /// <summary>
    ///   <para>bibo:CollectedDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document that simultaneously contains other documents."</para>
    /// labels<para>"Collected Document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Collected Document"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/CollectedDocument">http://purl.org/ontology/bibo/CollectedDocument</seealso>
    let CollectedDocument = Prefixed_Name(bibo, "CollectedDocument") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of Documents or Collections"</para>
    ///   <para>"A collection of Documents or Collections."</para>
    /// labels<para>"Collection"</para><para>"Collection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Collection">http://purl.org/ontology/bibo/Collection</seealso>
    let Collection = Prefixed_Name(bibo, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Conference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A meeting for consultation or discussion."</para>
    /// labels<para>"Conference"</para><para>"Conference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Conference">http://purl.org/ontology/bibo/Conference</seealso>
    let Conference = Prefixed_Name(bibo, "Conference") |> PrefixedName
    /// <summary>
    ///   <para>bibo:CourtReporter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of legal cases."</para>
    /// labels<para>"Court Reporter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Court Reporter"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/CourtReporter">http://purl.org/ontology/bibo/CourtReporter</seealso>
    let CourtReporter = Prefixed_Name(bibo, "CourtReporter") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The algorithm was published in what kind of literature."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A Document"</para>
    ///   <para>"A document (noun) is a bounded physical representation of body of information designed with the capacity (and usually intent) to communicate. A document may manifest symbolic, diagrammatic or sensory-representational information."</para>
    /// labels<para>"bibo:document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Document"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Document">http://purl.org/ontology/bibo/Document</seealso>
    let Document = Prefixed_Name(bibo, "Document") |> PrefixedName
    /// <summary>
    ///   <para>bibo:DocumentPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"a distinct part of a larger document or collected document."</para>
    /// labels<para>"Document Part"</para><para>"Document Part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"document part"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/DocumentPart">http://purl.org/ontology/bibo/DocumentPart</seealso>
    let DocumentPart = Prefixed_Name(bibo, "DocumentPart") |> PrefixedName
    /// <summary>
    ///   <para>bibo:DocumentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The status of the publication of a document."</para>
    /// labels<para>"Document Status"</para><para>"Document Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/DocumentStatus">http://purl.org/ontology/bibo/DocumentStatus</seealso>
    let DocumentStatus = Prefixed_Name(bibo, "DocumentStatus") |> PrefixedName
    /// <summary>
    ///   <para>bibo:EditedBook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An edited book."</para>
    /// labels<para>"Edited Book"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Edited Book"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/EditedBook">http://purl.org/ontology/bibo/EditedBook</seealso>
    let EditedBook = Prefixed_Name(bibo, "EditedBook") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A written communication addressed to a person or organization and transmitted electronically."</para>
    /// labels<para>"EMail"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Email">http://purl.org/ontology/bibo/Email</seealso>
    let Email = Prefixed_Name(bibo, "Email") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Event">http://purl.org/ontology/bibo/Event</seealso>
    let Event = Prefixed_Name(bibo, "Event") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Excerpt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A passage selected from a larger work."</para>
    /// labels<para>"Excerpt"</para><para>"Excerpt"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Excerpt">http://purl.org/ontology/bibo/Excerpt</seealso>
    let Excerpt = Prefixed_Name(bibo, "Excerpt") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Film</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"aka movie."</para>
    /// labels<para>"Film"</para><para>"Film"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Film">http://purl.org/ontology/bibo/Film</seealso>
    let Film = Prefixed_Name(bibo, "Film") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Hearing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instance or a session in which testimony and arguments are presented, esp. before an official, as a judge in a lawsuit."</para>
    /// labels<para>"Hearing"</para><para>"Hearing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Hearing">http://purl.org/ontology/bibo/Hearing</seealso>
    let Hearing = Prefixed_Name(bibo, "Hearing") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document that presents visual or diagrammatic information."</para>
    /// labels<para>"Image"</para><para>"Image"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Image">http://purl.org/ontology/bibo/Image</seealso>
    let Image = Prefixed_Name(bibo, "Image") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Interview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A formalized discussion between two or more people."</para>
    /// labels<para>"Interview"</para><para>"Interview"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Interview">http://purl.org/ontology/bibo/Interview</seealso>
    let Interview = Prefixed_Name(bibo, "Interview") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Issue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"something that is printed or published and distributed, esp. a given number of a periodical."</para>
    ///   <para>"something that is printed or published and distributed, esp. a given number of a periodical"</para>
    /// labels<para>"Issue"</para><para>"Issue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Issue">http://purl.org/ontology/bibo/Issue</seealso>
    let Issue = Prefixed_Name(bibo, "Issue") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Journal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"a periodical dedicated to a particular subject; "he reads the medical journals.""</para>
    ///   <para>"A periodical of scholarly journal Articles."</para>
    /// labels<para>"Journal"</para><para>"Journal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Journal">http://purl.org/ontology/bibo/Journal</seealso>
    let Journal = Prefixed_Name(bibo, "Journal") |> PrefixedName
    /// <summary>
    ///   <para>bibo:LegalCaseDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document accompanying a legal case."</para>
    /// labels<para>"Legal Case Document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Legal Case Document"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/LegalCaseDocument">http://purl.org/ontology/bibo/LegalCaseDocument</seealso>
    let LegalCaseDocument = Prefixed_Name(bibo, "LegalCaseDocument") |> PrefixedName
    /// <summary>
    ///   <para>bibo:LegalDecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document containing an authoritative determination (as a decree or judgment) made after consideration of facts or law."</para>
    /// labels<para>"Decision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Decision"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/LegalDecision">http://purl.org/ontology/bibo/LegalDecision</seealso>
    let LegalDecision = Prefixed_Name(bibo, "LegalDecision") |> PrefixedName
    /// <summary>
    ///   <para>bibo:LegalDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A legal document; for example, a court decision, a brief, and so forth."</para>
    /// labels<para>"Legal Document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Legal Document"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/LegalDocument">http://purl.org/ontology/bibo/LegalDocument</seealso>
    let LegalDocument = Prefixed_Name(bibo, "LegalDocument") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Legislation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A legal document proposing or enacting a law or a group of laws."</para>
    /// labels<para>"Legislation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Legislation"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Legislation">http://purl.org/ontology/bibo/Legislation</seealso>
    let Legislation = Prefixed_Name(bibo, "Legislation") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Letter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A written or printed communication addressed to a person or organization and usually transmitted by mail."</para>
    /// labels<para>"Letter"</para><para>"Letter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Letter">http://purl.org/ontology/bibo/Letter</seealso>
    let Letter = Prefixed_Name(bibo, "Letter") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Magazine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A periodical of magazine Articles. A magazine is a publication that is issued periodically, usually bound in a paper cover, and typically contains essays, stories, poems, etc., by many writers, and often photographs and drawings, frequently specializing in a particular subject or area, as hobbies, news, or sports."</para>
    ///   <para>"A periodical publication containing articles and illustrations, often on a particular subject or aimed at a particular readership."</para>
    /// labels<para>"Magazine"</para><para>"Magazine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Magazine">http://purl.org/ontology/bibo/Magazine</seealso>
    let Magazine = Prefixed_Name(bibo, "Magazine") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Manual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A small reference book, especially one giving instructions."</para>
    /// labels<para>"Manual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Manual"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Manual">http://purl.org/ontology/bibo/Manual</seealso>
    let Manual = Prefixed_Name(bibo, "Manual") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Manuscript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An unpublished Document, which may also be submitted to a publisher for publication."</para>
    /// labels<para>"manuscript"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Manuscript"</para><para>"Manuscript"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Manuscript">http://purl.org/ontology/bibo/Manuscript</seealso>
    let Manuscript = Prefixed_Name(bibo, "Manuscript") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Map</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A graphical depiction of geographic features."</para>
    /// labels<para>"Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Map"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Map">http://purl.org/ontology/bibo/Map</seealso>
    let Map = Prefixed_Name(bibo, "Map") |> PrefixedName
    /// <summary>
    ///   <para>bibo:MultiVolumeBook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A loose, thematic, collection of Documents, often Books."</para>
    /// labels<para>"Series"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/MultiVolumeBook">http://purl.org/ontology/bibo/MultiVolumeBook</seealso>
    let MultiVolumeBook = Prefixed_Name(bibo, "MultiVolumeBook") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Newspaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A periodical of documents, usually issued daily or weekly, containing current news, editorials, feature articles, and usually advertising."</para>
    /// labels<para>"Newspaper"</para><para>"Newspaper"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Newspaper">http://purl.org/ontology/bibo/Newspaper</seealso>
    let Newspaper = Prefixed_Name(bibo, "Newspaper") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Notes or annotations about a resource."</para>
    /// labels<para>"Note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Note"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Note">http://purl.org/ontology/bibo/Note</seealso>
    let Note = Prefixed_Name(bibo, "Note") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Patent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document describing the exclusive right granted by a government to an inventor to manufacture, use, or sell an invention for a certain number of years."</para>
    /// labels<para>"Patent"</para><para>"Patent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Patent">http://purl.org/ontology/bibo/Patent</seealso>
    let Patent = Prefixed_Name(bibo, "Patent") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A public performance."</para>
    /// labels<para>"Performance"</para><para>"Performance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Performance">http://purl.org/ontology/bibo/Performance</seealso>
    let Performance = Prefixed_Name(bibo, "Performance") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Periodical</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A group of related documents issued at regular intervals."</para>
    /// labels<para>"Periodical"</para><para>"Periodical"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Periodical">http://purl.org/ontology/bibo/Periodical</seealso>
    let Periodical = Prefixed_Name(bibo, "Periodical") |> PrefixedName

    /// <summary>
    ///   <para>bibo:PersonalCommunication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A communication between an agent and one or more specific recipients."</para>
    /// labels<para>"Personal Communication"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/PersonalCommunication">http://purl.org/ontology/bibo/PersonalCommunication</seealso>
    let PersonalCommunication =
        Prefixed_Name(bibo, "PersonalCommunication") |> PrefixedName

    /// <summary>
    ///   <para>bibo:PersonalCommunicationDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A personal communication manifested in some document."</para>
    /// labels<para>"Personal Communication Document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Personal Communication Document"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/PersonalCommunicationDocument">http://purl.org/ontology/bibo/PersonalCommunicationDocument</seealso>
    let PersonalCommunicationDocument =
        Prefixed_Name(bibo, "PersonalCommunicationDocument") |> PrefixedName

    /// <summary>
    ///   <para>bibo:Proceedings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A compilation of documents published from an event, such as a conference."</para>
    /// labels<para>"Proceedings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Proceedings"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Proceedings">http://purl.org/ontology/bibo/Proceedings</seealso>
    let Proceedings = Prefixed_Name(bibo, "Proceedings") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Quote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An excerpted collection of words."</para>
    /// labels<para>"Quote"</para><para>"Quote"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Quote">http://purl.org/ontology/bibo/Quote</seealso>
    let Quote = Prefixed_Name(bibo, "Quote") |> PrefixedName
    /// <summary>
    ///   <para>bibo:ReferenceSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document that presents authoritative reference information, such as a dictionary or encylopedia ."</para>
    ///   <para>"A document that presents authoritative reference information, such as a dictionary or encylopedia."</para>
    /// labels<para>"Reference Source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Reference Source"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/ReferenceSource">http://purl.org/ontology/bibo/ReferenceSource</seealso>
    let ReferenceSource = Prefixed_Name(bibo, "ReferenceSource") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Report</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document describing an account or statement describing in detail an event, situation, or the like, usually as the result of observation, inquiry, etc.."</para>
    /// labels<para>"Report"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Report"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Report">http://purl.org/ontology/bibo/Report</seealso>
    let Report = Prefixed_Name(bibo, "Report") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Series</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A loose, thematic, collection of Documents, often Books."</para>
    /// labels<para>"Series"</para><para>"Series"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Series">http://purl.org/ontology/bibo/Series</seealso>
    let Series = Prefixed_Name(bibo, "Series") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Slide</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A slide in a slideshow."</para>
    ///   <para>"A slide in a slideshow"</para>
    /// labels<para>"Slide"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Slide"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Slide">http://purl.org/ontology/bibo/Slide</seealso>
    let Slide = Prefixed_Name(bibo, "Slide") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Slideshow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A presentation of a series of slides, usually presented in front of an audience with written text and images."</para>
    /// labels<para>"Slideshow"</para><para>"Slideshow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Slideshow">http://purl.org/ontology/bibo/Slideshow</seealso>
    let Slideshow = Prefixed_Name(bibo, "Slideshow") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document describing a standard"</para>
    /// labels<para>"Standard"</para><para>"Standard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Standard">http://purl.org/ontology/bibo/Standard</seealso>
    let Standard = Prefixed_Name(bibo, "Standard") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Statute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A bill enacted into law."</para>
    /// labels<para>"Statute"</para><para>"Statute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Statute">http://purl.org/ontology/bibo/Statute</seealso>
    let Statute = Prefixed_Name(bibo, "Statute") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Thesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document created to summarize research findings associated with the completion of an academic degree."</para>
    /// labels<para>"Thesis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Thesis"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Thesis">http://purl.org/ontology/bibo/Thesis</seealso>
    let Thesis = Prefixed_Name(bibo, "Thesis") |> PrefixedName
    /// <summary>
    ///   <para>bibo:ThesisDegree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The academic degree of a Thesis"</para>
    /// labels<para>"Thesis Degree"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Thesis degree"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/ThesisDegree">http://purl.org/ontology/bibo/ThesisDegree</seealso>
    let ThesisDegree = Prefixed_Name(bibo, "ThesisDegree") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Webpage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A web page is an online document available (at least initially) on the world wide web. A web page is written first and foremost to appear on the web, as distinct from other online resources such as books, manuscripts or audio documents which use the web primarily as a distribution mechanism alongside other more traditional methods such as print."</para>
    /// labels<para>"Webpage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Webpage"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Webpage">http://purl.org/ontology/bibo/Webpage</seealso>
    let Webpage = Prefixed_Name(bibo, "Webpage") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Website</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A group of Webpages accessible on the Web."</para>
    /// labels<para>"http://purl.org/ontology/bibo/Website"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Website"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Website"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Website">http://purl.org/ontology/bibo/Website</seealso>
    let Website = Prefixed_Name(bibo, "Website") |> PrefixedName
    /// <summary>
    ///   <para>bibo:Workshop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A seminar, discussion group, or the like, that emphasizes zxchange of ideas and the demonstration and application of techniques, skills, etc."</para>
    /// labels<para>"Workshop"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Workshop"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/Workshop">http://purl.org/ontology/bibo/Workshop</seealso>
    let Workshop = Prefixed_Name(bibo, "Workshop") |> PrefixedName
    /// <summary>
    ///   <para>bibo:abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A summary of the resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"abstract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/abstract">http://purl.org/ontology/bibo/abstract</seealso>
    let abstract_ = Prefixed_Name(bibo, "abstract") |> PrefixedName
    /// <summary>
    ///   <para>bibo:accepted</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"accepted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/accepted">http://purl.org/ontology/bibo/accepted</seealso>
    let accepted = Prefixed_Name(bibo, "accepted") |> PrefixedName
    /// <summary>
    ///   <para>bibo:affirmedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A legal decision that affirms a ruling."</para>
    /// labels<para>"affirmed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/affirmedBy">http://purl.org/ontology/bibo/affirmedBy</seealso>
    let affirmedBy = Prefixed_Name(bibo, "affirmedBy") |> PrefixedName
    /// <summary>
    ///   <para>bibo:annotates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Critical or explanatory note for a Document."</para>
    /// labels<para>"annotates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"annotates"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/annotates">http://purl.org/ontology/bibo/annotates</seealso>
    let annotates = Prefixed_Name(bibo, "annotates") |> PrefixedName
    /// <summary>
    ///   <para>bibo:argued</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date on which a legal case is argued before a court. Date is of format xsd:date"</para>
    /// labels<para>"date argued"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/argued">http://purl.org/ontology/bibo/argued</seealso>
    let argued = Prefixed_Name(bibo, "argued") |> PrefixedName
    /// <summary>
    ///   <para>bibo:asin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Amazon Standard Identification Number"</para>
    /// labels<para>"Amazon Standard Identification Number (ASIN)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/asin">http://purl.org/ontology/bibo/asin</seealso>
    let asin = Prefixed_Name(bibo, "asin") |> PrefixedName
    /// <summary>
    ///   <para>bibo:authorList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"An ordered list of authors. Normally, this list is seen as a priority list that order authors by importance."</para>
    /// labels<para>"list of authors"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/authorList">http://purl.org/ontology/bibo/authorList</seealso>
    let authorList = Prefixed_Name(bibo, "authorList") |> PrefixedName
    /// <summary>
    ///   <para>bibo:bdarcus</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/bibo/bdarcus">http://purl.org/ontology/bibo/bdarcus</seealso>
    let bdarcus = Prefixed_Name(bibo, "bdarcus") |> PrefixedName
    /// <summary>
    ///   <para>bibo:chapter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"An chapter number"</para>
    /// labels<para>"chapter"</para><para>"chapter number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/chapter">http://purl.org/ontology/bibo/chapter</seealso>
    let chapter = Prefixed_Name(bibo, "chapter") |> PrefixedName
    /// <summary>
    ///   <para>bibo:citedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a document to another document that cites the
    /// first document."</para>
    /// labels<para>"cited by"</para><para>"cited by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/citedBy">http://purl.org/ontology/bibo/citedBy</seealso>
    let citedBy = Prefixed_Name(bibo, "citedBy") |> PrefixedName
    /// <summary>
    ///   <para>bibo:cites</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a document to another document that is cited
    /// by the first document as reference, comment, review, quotation or for
    /// another purpose."</para>
    /// labels<para>"cites"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"cites"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/cites">http://purl.org/ontology/bibo/cites</seealso>
    let cites = Prefixed_Name(bibo, "cites") |> PrefixedName
    /// <summary>
    ///   <para>bibo:coden</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"An identifier of serials, still in use by libraries, but replaced by ISSN for any new work"</para>
    /// labels<para>"coden"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/coden">http://purl.org/ontology/bibo/coden</seealso>
    let coden = Prefixed_Name(bibo, "coden") |> PrefixedName
    /// <summary>
    ///   <para>bibo:content</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property is for a plain-text rendering of the content of a Document. While the plain-text content of an entire document could be described by this property."</para>
    /// labels<para>"content"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/content">http://purl.org/ontology/bibo/content</seealso>
    let content = Prefixed_Name(bibo, "content") |> PrefixedName
    /// <summary>
    ///   <para>bibo:contributorList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"An ordered list of contributors. Normally, this list is seen as a priority list that order contributors by importance."</para>
    /// labels<para>"list of contributors"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/contributorList">http://purl.org/ontology/bibo/contributorList</seealso>
    let contributorList = Prefixed_Name(bibo, "contributorList") |> PrefixedName
    /// <summary>
    ///   <para>bibo:court</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A court associated with a legal document; for example, that which issues a decision."</para>
    /// labels<para>"court"</para><para>"Court"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/court">http://purl.org/ontology/bibo/court</seealso>
    let court = Prefixed_Name(bibo, "court") |> PrefixedName
    /// <summary>
    ///   <para>bibo:degree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The thesis degree."</para>
    /// labels<para>"degree"</para><para>"related degree"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/degree">http://purl.org/ontology/bibo/degree</seealso>
    let degree = Prefixed_Name(bibo, "degree") |> PrefixedName
    /// <summary>
    ///   <para>bibo:degrees/ma</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>bibo:ThesisDegree</para>
    ///   <para>"masters degree in arts"</para>
    /// labels<para>"M.A."</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/degrees/ma">http://purl.org/ontology/bibo/degrees/ma</seealso>
    let ``degrees/ma`` = Prefixed_Name(bibo, "degrees/ma") |> PrefixedName
    /// <summary>
    ///   <para>bibo:degrees/ms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>bibo:ThesisDegree</para>
    ///   <para>"masters degree in science"</para>
    /// labels<para>"M.S."</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/degrees/ms">http://purl.org/ontology/bibo/degrees/ms</seealso>
    let ``degrees/ms`` = Prefixed_Name(bibo, "degrees/ms") |> PrefixedName
    /// <summary>
    ///   <para>bibo:degrees/phd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>bibo:ThesisDegree</para>
    ///   <para>"PhD degree"</para>
    /// labels<para>"PhD degree"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/degrees/phd">http://purl.org/ontology/bibo/degrees/phd</seealso>
    let ``degrees/phd`` = Prefixed_Name(bibo, "degrees/phd") |> PrefixedName
    /// <summary>
    ///   <para>bibo:director</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Film director."</para>
    /// labels<para>"director"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/director">http://purl.org/ontology/bibo/director</seealso>
    let director = Prefixed_Name(bibo, "director") |> PrefixedName
    /// <summary>
    ///   <para>bibo:distributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Distributor of a document or a collection of documents."</para>
    /// labels<para>"distributor"</para><para>"distributor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/distributor">http://purl.org/ontology/bibo/distributor</seealso>
    let distributor = Prefixed_Name(bibo, "distributor") |> PrefixedName
    /// <summary>
    ///   <para>bibo:doi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Digital Object Identifier"</para>
    /// labels<para>"Digital Object Identifier (DOI)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/doi">http://purl.org/ontology/bibo/doi</seealso>
    let doi = Prefixed_Name(bibo, "doi") |> PrefixedName
    /// <summary>
    ///   <para>bibo:doi:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/doi:">http://purl.org/ontology/bibo/doi:</seealso>
    let ``doi:`` = Prefixed_Name(bibo, "doi:") |> PrefixedName
    /// <summary>
    ///   <para>bibo:draft</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bibo:DocumentStatus</para>
    ///
    /// labels<para>"draft"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/draft">http://purl.org/ontology/bibo/draft</seealso>
    let draft = Prefixed_Name(bibo, "draft") |> PrefixedName
    /// <summary>
    ///   <para>bibo:eanucc13</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"European Article Number/Uniform Commercier Code 13"</para>
    /// labels<para>"EAN International-Uniform Code Council (EAN-UCC) 13"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/eanucc13">http://purl.org/ontology/bibo/eanucc13</seealso>
    let eanucc13 = Prefixed_Name(bibo, "eanucc13") |> PrefixedName
    /// <summary>
    ///   <para>bibo:edition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The name defining a special edition of a document. Normally its a literal value composed of a version number and words."</para>
    /// labels<para>"edition"</para><para>"edition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/edition">http://purl.org/ontology/bibo/edition</seealso>
    let edition = Prefixed_Name(bibo, "edition") |> PrefixedName
    /// <summary>
    ///   <para>bibo:editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A person having managerial and sometimes policy-making responsibility for the editorial part of a publishing firm or of a newspaper, magazine, or other publication."</para>
    /// labels<para>"editor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/editor">http://purl.org/ontology/bibo/editor</seealso>
    let editor = Prefixed_Name(bibo, "editor") |> PrefixedName
    /// <summary>
    ///   <para>bibo:editorList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"An ordered list of editors. Normally, this list is seen as a priority list that order editors by importance."</para>
    /// labels<para>"list of editors"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/editorList">http://purl.org/ontology/bibo/editorList</seealso>
    let editorList = Prefixed_Name(bibo, "editorList") |> PrefixedName
    /// <summary>
    ///   <para>bibo:eissn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The electronic ISSN number of a periodical."</para>
    /// labels<para>"Electronic International Standard Serial Number (EISSN)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/eissn">http://purl.org/ontology/bibo/eissn</seealso>
    let eissn = Prefixed_Name(bibo, "eissn") |> PrefixedName
    /// <summary>
    ///   <para>bibo:fgiasson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/bibo/fgiasson">http://purl.org/ontology/bibo/fgiasson</seealso>
    let fgiasson = Prefixed_Name(bibo, "fgiasson") |> PrefixedName
    /// <summary>
    ///   <para>bibo:gtin14</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Global Trade Item Number 14"</para>
    /// labels<para>"Global Trade Item Number (GTIN-14)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/gtin14">http://purl.org/ontology/bibo/gtin14</seealso>
    let gtin14 = Prefixed_Name(bibo, "gtin14") |> PrefixedName
    /// <summary>
    ///   <para>bibo:handle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/bibo/handle">http://purl.org/ontology/bibo/handle</seealso>
    let handle = Prefixed_Name(bibo, "handle") |> PrefixedName
    /// <summary>
    ///   <para>bibo:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"bibo:identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/identifier">http://purl.org/ontology/bibo/identifier</seealso>
    let identifier = Prefixed_Name(bibo, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>bibo:interviewee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An agent that is interviewed by another agent."</para>
    /// labels<para>"interviewee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/interviewee">http://purl.org/ontology/bibo/interviewee</seealso>
    let interviewee = Prefixed_Name(bibo, "interviewee") |> PrefixedName
    /// <summary>
    ///   <para>bibo:interviewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An agent that interview another agent."</para>
    /// labels<para>"interviewer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/interviewer">http://purl.org/ontology/bibo/interviewer</seealso>
    let interviewer = Prefixed_Name(bibo, "interviewer") |> PrefixedName
    /// <summary>
    ///   <para>bibo:isPartOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/isPartOf">http://purl.org/ontology/bibo/isPartOf</seealso>
    let isPartOf = Prefixed_Name(bibo, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>bibo:isbn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/bibo/isbn">http://purl.org/ontology/bibo/isbn</seealso>
    let isbn = Prefixed_Name(bibo, "isbn") |> PrefixedName
    /// <summary>
    ///   <para>bibo:isbn10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"International Standard Book Number (ISBN) 10"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/isbn10">http://purl.org/ontology/bibo/isbn10</seealso>
    let isbn10 = Prefixed_Name(bibo, "isbn10") |> PrefixedName
    /// <summary>
    ///   <para>bibo:isbn13</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"International Standard Book Number (ISBN) 13"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/isbn13">http://purl.org/ontology/bibo/isbn13</seealso>
    let isbn13 = Prefixed_Name(bibo, "isbn13") |> PrefixedName
    /// <summary>
    ///   <para>bibo:issn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"International Standard Serial Number"</para>
    /// labels<para>"International Standard Serial Number (ISSN)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/issn">http://purl.org/ontology/bibo/issn</seealso>
    let issn = Prefixed_Name(bibo, "issn") |> PrefixedName
    /// <summary>
    ///   <para>bibo:issue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"An issue number"</para>
    /// labels<para>"issue"</para><para>"issue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/issue">http://purl.org/ontology/bibo/issue</seealso>
    let issue = Prefixed_Name(bibo, "issue") |> PrefixedName
    /// <summary>
    ///   <para>bibo:issuer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"An entity responsible for issuing often informally published documents such as press releases, reports, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"issuer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/issuer">http://purl.org/ontology/bibo/issuer</seealso>
    let issuer = Prefixed_Name(bibo, "issuer") |> PrefixedName
    /// <summary>
    ///   <para>bibo:lccn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Library of Congress Control Number"</para>
    /// labels<para>"Library of Congress Control Number (LCCN)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/lccn">http://purl.org/ontology/bibo/lccn</seealso>
    let lccn = Prefixed_Name(bibo, "lccn") |> PrefixedName
    /// <summary>
    ///   <para>bibo:locator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A description (often numeric) that locates an item within a containing document or collection."</para>
    /// labels<para>"locator"</para><para>"locator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/locator">http://purl.org/ontology/bibo/locator</seealso>
    let locator = Prefixed_Name(bibo, "locator") |> PrefixedName
    /// <summary>
    ///   <para>bibo:numPages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The number of pages contained in a document"</para>
    /// labels<para>"number of pages"</para><para>"number of pages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/numPages">http://purl.org/ontology/bibo/numPages</seealso>
    let numPages = Prefixed_Name(bibo, "numPages") |> PrefixedName
    /// <summary>
    ///   <para>bibo:numVolumes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The number of volumes contained in a collection of documents (usually a series, periodical, etc.)."</para>
    /// labels<para>"number of volumes"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/numVolumes">http://purl.org/ontology/bibo/numVolumes</seealso>
    let numVolumes = Prefixed_Name(bibo, "numVolumes") |> PrefixedName
    /// <summary>
    ///   <para>bibo:number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A generic item or document number. Not to be confused with issue number."</para>
    /// labels<para>"number"</para><para>"number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/number">http://purl.org/ontology/bibo/number</seealso>
    let number = Prefixed_Name(bibo, "number") |> PrefixedName
    /// <summary>
    ///   <para>bibo:oclcnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"OCLC Identifier"</para>
    /// labels<para>"Online Computer Library Center (OCLC) number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/oclcnum">http://purl.org/ontology/bibo/oclcnum</seealso>
    let oclcnum = Prefixed_Name(bibo, "oclcnum") |> PrefixedName
    /// <summary>
    ///   <para>bibo:organizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The organizer of an event; includes conference organizers, but also government agencies or other bodies that are responsible for conducting hearings."</para>
    /// labels<para>"organizer"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/organizer">http://purl.org/ontology/bibo/organizer</seealso>
    let organizer = Prefixed_Name(bibo, "organizer") |> PrefixedName
    /// <summary>
    ///   <para>bibo:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Owner of a document or a collection of documents."</para>
    /// labels<para>"owner"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/owner">http://purl.org/ontology/bibo/owner</seealso>
    let owner = Prefixed_Name(bibo, "owner") |> PrefixedName
    /// <summary>
    ///   <para>bibo:pageEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Ending page number within a continuous page range."</para>
    /// labels<para>"end page"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"page end"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/pageEnd">http://purl.org/ontology/bibo/pageEnd</seealso>
    let pageEnd = Prefixed_Name(bibo, "pageEnd") |> PrefixedName
    /// <summary>
    ///   <para>bibo:pageStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Starting page number within a continuous page range."</para>
    /// labels<para>"start page"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"page start"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/pageStart">http://purl.org/ontology/bibo/pageStart</seealso>
    let pageStart = Prefixed_Name(bibo, "pageStart") |> PrefixedName
    /// <summary>
    ///   <para>bibo:pages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A string of non-contiguous page spans that locate a Document within a Collection. Example: 23-25, 34, 54-56. For continuous page ranges, use the pageStart and pageEnd properties."</para>
    /// labels<para>"pages"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/pages">http://purl.org/ontology/bibo/pages</seealso>
    let pages = Prefixed_Name(bibo, "pages") |> PrefixedName
    /// <summary>
    ///   <para>bibo:peerReviewed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bibo:DocumentStatus</para>
    ///
    /// labels<para>"peer reviewed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/peerReviewed">http://purl.org/ontology/bibo/peerReviewed</seealso>
    let peerReviewed = Prefixed_Name(bibo, "peerReviewed") |> PrefixedName
    /// <summary>
    ///   <para>bibo:performer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"performer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/performer">http://purl.org/ontology/bibo/performer</seealso>
    let performer = Prefixed_Name(bibo, "performer") |> PrefixedName
    /// <summary>
    ///   <para>bibo:pmid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"PubMed Identifier"</para>
    /// labels<para>"PubMed ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/pmid">http://purl.org/ontology/bibo/pmid</seealso>
    let pmid = Prefixed_Name(bibo, "pmid") |> PrefixedName
    /// <summary>
    ///   <para>bibo:prefixName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The prefix of a name"</para>
    /// labels<para>"name prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"prefix name"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/prefixName">http://purl.org/ontology/bibo/prefixName</seealso>
    let prefixName = Prefixed_Name(bibo, "prefixName") |> PrefixedName
    /// <summary>
    ///   <para>bibo:presentedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a document to an event; for example, a paper to a conference."</para>
    /// labels<para>"presented at"</para><para>"presented at event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/presentedAt">http://purl.org/ontology/bibo/presentedAt</seealso>
    let presentedAt = Prefixed_Name(bibo, "presentedAt") |> PrefixedName
    /// <summary>
    ///   <para>bibo:presents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates an event to associated documents; for example, conference to a paper."</para>
    /// labels<para>"related documents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"presented at"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/presents">http://purl.org/ontology/bibo/presents</seealso>
    let presents = Prefixed_Name(bibo, "presents") |> PrefixedName
    /// <summary>
    ///   <para>bibo:producer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Producer of a document or a collection of documents."</para>
    /// labels<para>"producer"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/producer">http://purl.org/ontology/bibo/producer</seealso>
    let producer = Prefixed_Name(bibo, "producer") |> PrefixedName
    /// <summary>
    ///   <para>bibo:published</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"published"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/published">http://purl.org/ontology/bibo/published</seealso>
    let published = Prefixed_Name(bibo, "published") |> PrefixedName
    /// <summary>
    ///   <para>bibo:recipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An agent that receives a communication document."</para>
    /// labels<para>"recipient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/recipient">http://purl.org/ontology/bibo/recipient</seealso>
    let recipient = Prefixed_Name(bibo, "recipient") |> PrefixedName
    /// <summary>
    ///   <para>bibo:rejected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bibo:DocumentStatus</para>
    ///
    /// labels<para>"rejected"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/rejected">http://purl.org/ontology/bibo/rejected</seealso>
    let rejected = Prefixed_Name(bibo, "rejected") |> PrefixedName
    /// <summary>
    ///   <para>bibo:reproducedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The resource in which another resource is reproduced."</para>
    /// labels<para>"reproduced in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/reproducedIn">http://purl.org/ontology/bibo/reproducedIn</seealso>
    let reproducedIn = Prefixed_Name(bibo, "reproducedIn") |> PrefixedName
    /// <summary>
    ///   <para>bibo:reversedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A legal decision that reverses a ruling."</para>
    /// labels<para>"reversed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/reversedBy">http://purl.org/ontology/bibo/reversedBy</seealso>
    let reversedBy = Prefixed_Name(bibo, "reversedBy") |> PrefixedName
    /// <summary>
    ///   <para>bibo:reviewOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a review document to a reviewed thing (resource, item, etc.)."</para>
    /// labels<para>"review of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"review of"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/reviewOf">http://purl.org/ontology/bibo/reviewOf</seealso>
    let reviewOf = Prefixed_Name(bibo, "reviewOf") |> PrefixedName
    /// <summary>
    ///   <para>bibo:section</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An section number"</para>
    ///   <para>"A section number"</para>
    /// labels<para>"section"</para><para>"section"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/section">http://purl.org/ontology/bibo/section</seealso>
    let section = Prefixed_Name(bibo, "section") |> PrefixedName
    /// <summary>
    ///   <para>bibo:shortDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A short description of the resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"short description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/shortDescription">http://purl.org/ontology/bibo/shortDescription</seealso>
    let shortDescription = Prefixed_Name(bibo, "shortDescription") |> PrefixedName
    /// <summary>
    ///   <para>bibo:shortTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The abbreviation of a title."</para>
    /// labels<para>"short title"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/shortTitle">http://purl.org/ontology/bibo/shortTitle</seealso>
    let shortTitle = Prefixed_Name(bibo, "shortTitle") |> PrefixedName
    /// <summary>
    ///   <para>bibo:sici</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Serial Item and Contribution Identifier"</para>
    /// labels<para>"Serial Item and Contribution Identifier (SICI)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/sici">http://purl.org/ontology/bibo/sici</seealso>
    let sici = Prefixed_Name(bibo, "sici") |> PrefixedName
    /// <summary>
    ///   <para>bibo:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The publication status of (typically academic) content."</para>
    /// labels<para>"status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"status"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/status">http://purl.org/ontology/bibo/status</seealso>
    let status = Prefixed_Name(bibo, "status") |> PrefixedName
    /// <summary>
    ///   <para>bibo:status/accepted</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Accepted for publication after peer reviewing."</para>
    /// labels<para>"accepted"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/status/accepted">http://purl.org/ontology/bibo/status/accepted</seealso>
    let ``status/accepted`` = Prefixed_Name(bibo, "status/accepted") |> PrefixedName
    /// <summary>
    ///   <para>bibo:status/draft</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>"Document drafted"</para>
    /// labels<para>"draft"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/status/draft">http://purl.org/ontology/bibo/status/draft</seealso>
    let ``status/draft`` = Prefixed_Name(bibo, "status/draft") |> PrefixedName

    /// <summary>
    ///   <para>bibo:status/forthcoming</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>"Document to be published"</para>
    /// labels<para>"forthcoming"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/status/forthcoming">http://purl.org/ontology/bibo/status/forthcoming</seealso>
    let ``status/forthcoming`` =
        Prefixed_Name(bibo, "status/forthcoming") |> PrefixedName

    /// <summary>
    ///   <para>bibo:status/legal</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Legal document"</para>
    /// labels<para>"legal"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/status/legal">http://purl.org/ontology/bibo/status/legal</seealso>
    let ``status/legal`` = Prefixed_Name(bibo, "status/legal") |> PrefixedName

    /// <summary>
    ///   <para>bibo:status/nonPeerReviewed</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>owl:Thing</para>
    ///   <para>"A document that is not peer reviewed"</para>
    /// labels<para>"non peer reviewed"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/status/nonPeerReviewed">http://purl.org/ontology/bibo/status/nonPeerReviewed</seealso>
    let ``status/nonPeerReviewed`` =
        Prefixed_Name(bibo, "status/nonPeerReviewed") |> PrefixedName

    /// <summary>
    ///   <para>bibo:status/peerReviewed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>"The process by which articles are chosen to be included in a refereed journal. An editorial board consisting of experts in the same field as the author review the article and decide if it is authoritative enough for publication."</para>
    /// labels<para>"peer reviewed"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/status/peerReviewed">http://purl.org/ontology/bibo/status/peerReviewed</seealso>
    let ``status/peerReviewed`` =
        Prefixed_Name(bibo, "status/peerReviewed") |> PrefixedName

    /// <summary>
    ///   <para>bibo:status/published</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>"Published document"</para>
    /// labels<para>"published"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/status/published">http://purl.org/ontology/bibo/status/published</seealso>
    let ``status/published`` = Prefixed_Name(bibo, "status/published") |> PrefixedName
    /// <summary>
    ///   <para>bibo:status/rejected</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Rejected for publication after peer reviewing."</para>
    /// labels<para>"rejected"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/status/rejected">http://purl.org/ontology/bibo/status/rejected</seealso>
    let ``status/rejected`` = Prefixed_Name(bibo, "status/rejected") |> PrefixedName

    /// <summary>
    ///   <para>bibo:status/unpublished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>"Unpublished document"</para>
    /// labels<para>"unpublished"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/status/unpublished">http://purl.org/ontology/bibo/status/unpublished</seealso>
    let ``status/unpublished`` =
        Prefixed_Name(bibo, "status/unpublished") |> PrefixedName

    /// <summary>
    ///   <para>bibo:subsequentLegalDecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A legal decision on appeal that takes action on a case (affirming it, reversing it, etc.)."</para>
    /// labels<para>"subsequent legal decision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/subsequentLegalDecision">http://purl.org/ontology/bibo/subsequentLegalDecision</seealso>
    let subsequentLegalDecision =
        Prefixed_Name(bibo, "subsequentLegalDecision") |> PrefixedName

    /// <summary>
    ///   <para>bibo:suffixName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The suffix of a name"</para>
    /// labels<para>"suffix name"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/suffixName">http://purl.org/ontology/bibo/suffixName</seealso>
    let suffixName = Prefixed_Name(bibo, "suffixName") |> PrefixedName
    /// <summary>
    ///   <para>bibo:transcriptOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a document to some transcribed original."</para>
    /// labels<para>"transcript of"</para><para>"transcript of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/transcriptOf">http://purl.org/ontology/bibo/transcriptOf</seealso>
    let transcriptOf = Prefixed_Name(bibo, "transcriptOf") |> PrefixedName
    /// <summary>
    ///   <para>bibo:translationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a translated document to the original document."</para>
    /// labels<para>"translation of"</para><para>"translation of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/translationOf">http://purl.org/ontology/bibo/translationOf</seealso>
    let translationOf = Prefixed_Name(bibo, "translationOf") |> PrefixedName
    /// <summary>
    ///   <para>bibo:translator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A person who translates written document from one language to another."</para>
    /// labels<para>"translator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/translator">http://purl.org/ontology/bibo/translator</seealso>
    let translator = Prefixed_Name(bibo, "translator") |> PrefixedName
    /// <summary>
    ///   <para>bibo:unpublished</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"unpublished"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/unpublished">http://purl.org/ontology/bibo/unpublished</seealso>
    let unpublished = Prefixed_Name(bibo, "unpublished") |> PrefixedName
    /// <summary>
    ///   <para>bibo:upc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Universal Product Code"</para>
    /// labels<para>"Universal Product Code (UPC)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/upc">http://purl.org/ontology/bibo/upc</seealso>
    let upc = Prefixed_Name(bibo, "upc") |> PrefixedName
    /// <summary>
    ///   <para>bibo:uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Universal Resource Identifier of a document"</para>
    /// labels<para>"URI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"uri"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/uri">http://purl.org/ontology/bibo/uri</seealso>
    let uri = Prefixed_Name(bibo, "uri") |> PrefixedName
    /// <summary>
    ///   <para>bibo:volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A volume number"</para>
    /// labels<para>"volume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"volume"</para></remarks>
    /// <seealso href="http://purl.org/ontology/bibo/volume">http://purl.org/ontology/bibo/volume</seealso>
    let volume = Prefixed_Name(bibo, "volume") |> PrefixedName
