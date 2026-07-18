namespace http.purl.org.ontology.bibo.slash

open DoxAletheia.Rdf_Vocabulary

module bibo =
    let _namespace_name = "http://purl.org/ontology/bibo/"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/doi"></see>
    /// </summary>
    let doi = Namespaced_IRI.parse _namespace_name "doi" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/eissn"></see>
    /// </summary>
    let eissn = Namespaced_IRI.parse _namespace_name "eissn" |> NamespacedName
    /// <summary>
    /// The name defining a special edition of a document. Normally its a literal value composed of a version number and words.
    /// <see href="http://purl.org/ontology/bibo/edition"></see></summary>
    let edition = Namespaced_IRI.parse _namespace_name "edition" |> NamespacedName
    /// <summary>
    /// Ending page number within a continuous page range.
    /// <see href="http://purl.org/ontology/bibo/pageEnd"></see></summary>
    let pageEnd = Namespaced_IRI.parse _namespace_name "pageEnd" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/isbn"></see>
    /// </summary>
    let isbn = Namespaced_IRI.parse _namespace_name "isbn" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/issn"></see>
    /// </summary>
    let issn = Namespaced_IRI.parse _namespace_name "issn" |> NamespacedName
    /// <summary>
    /// An issue number
    /// <see href="http://purl.org/ontology/bibo/issue"></see></summary>
    let issue = Namespaced_IRI.parse _namespace_name "issue" |> NamespacedName
    /// <summary>
    /// A description (often numeric) that locates an item within a containing document or collection.
    /// <see href="http://purl.org/ontology/bibo/locator"></see></summary>
    let locator = Namespaced_IRI.parse _namespace_name "locator" |> NamespacedName
    /// <summary>
    /// Starting page number within a continuous page range.
    /// <see href="http://purl.org/ontology/bibo/pageStart"></see></summary>
    let pageStart = Namespaced_IRI.parse _namespace_name "pageStart" |> NamespacedName
    /// <summary>
    /// A volume number
    /// <see href="http://purl.org/ontology/bibo/volume"></see></summary>
    let volume = Namespaced_IRI.parse _namespace_name "volume" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/bdarcus"></see>
    /// </summary>
    let bdarcus = Namespaced_IRI.parse _namespace_name "bdarcus" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/fgiasson"></see>
    /// </summary>
    let fgiasson = Namespaced_IRI.parse _namespace_name "fgiasson" |> NamespacedName

    /// <summary>
    /// A scholarly academic article, typically published in a journal.
    /// <see href="http://purl.org/ontology/bibo/AcademicArticle"></see></summary>
    let AcademicArticle =
        Namespaced_IRI.parse _namespace_name "AcademicArticle" |> NamespacedName

    /// <summary>
    /// A written composition in prose, usually nonfiction, on a specific topic, forming an independent part of a book or other publication, as a newspaper or magazine.
    /// <see href="http://purl.org/ontology/bibo/Article"></see></summary>
    let Article = Namespaced_IRI.parse _namespace_name "Article" |> NamespacedName
    /// <summary>
    /// A document (noun) is a bounded physical representation of body of information designed with the capacity (and usually intent) to communicate. A document may manifest symbolic, diagrammatic or sensory-representational information.
    /// <see href="http://purl.org/ontology/bibo/Document"></see></summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName

    /// <summary>
    /// An audio document; aka record.
    /// <see href="http://purl.org/ontology/bibo/AudioDocument"></see></summary>
    let AudioDocument =
        Namespaced_IRI.parse _namespace_name "AudioDocument" |> NamespacedName

    /// <summary>
    /// An audio-visual document; film, video, and so forth.
    /// <see href="http://purl.org/ontology/bibo/AudioVisualDocument"></see></summary>
    let AudioVisualDocument =
        Namespaced_IRI.parse _namespace_name "AudioVisualDocument" |> NamespacedName

    /// <summary>
    /// Draft legislation presented for discussion to a legal body.
    /// <see href="http://purl.org/ontology/bibo/Bill"></see></summary>
    let Bill = Namespaced_IRI.parse _namespace_name "Bill" |> NamespacedName

    /// <summary>
    /// A legal document proposing or enacting a law or a group of laws.
    /// <see href="http://purl.org/ontology/bibo/Legislation"></see></summary>
    let Legislation =
        Namespaced_IRI.parse _namespace_name "Legislation" |> NamespacedName

    /// <summary>
    /// A written or printed work of fiction or nonfiction, usually on sheets of paper fastened or bound together within covers.
    /// <see href="http://purl.org/ontology/bibo/Book"></see></summary>
    let Book = Namespaced_IRI.parse _namespace_name "Book" |> NamespacedName

    /// <summary>
    /// A section of a book.
    /// <see href="http://purl.org/ontology/bibo/BookSection"></see></summary>
    let BookSection =
        Namespaced_IRI.parse _namespace_name "BookSection" |> NamespacedName

    /// <summary>
    /// a distinct part of a larger document or collected document.
    /// <see href="http://purl.org/ontology/bibo/DocumentPart"></see></summary>
    let DocumentPart =
        Namespaced_IRI.parse _namespace_name "DocumentPart" |> NamespacedName

    /// <summary>
    /// A written argument submitted to a court.
    /// <see href="http://purl.org/ontology/bibo/Brief"></see></summary>
    let Brief = Namespaced_IRI.parse _namespace_name "Brief" |> NamespacedName

    /// <summary>
    /// A document accompanying a legal case.
    /// <see href="http://purl.org/ontology/bibo/LegalCaseDocument"></see></summary>
    let LegalCaseDocument =
        Namespaced_IRI.parse _namespace_name "LegalCaseDocument" |> NamespacedName

    /// <summary>
    /// A chapter of a book.
    /// <see href="http://purl.org/ontology/bibo/Chapter"></see></summary>
    let Chapter = Namespaced_IRI.parse _namespace_name "Chapter" |> NamespacedName
    /// <summary>
    /// A collection of statutes.
    /// <see href="http://purl.org/ontology/bibo/Code"></see></summary>
    let Code = Namespaced_IRI.parse _namespace_name "Code" |> NamespacedName
    /// <summary>
    /// A group of related documents issued at regular intervals.
    /// <see href="http://purl.org/ontology/bibo/Periodical"></see></summary>
    let Periodical = Namespaced_IRI.parse _namespace_name "Periodical" |> NamespacedName

    /// <summary>
    /// A document that simultaneously contains other documents.
    /// <see href="http://purl.org/ontology/bibo/CollectedDocument"></see></summary>
    let CollectedDocument =
        Namespaced_IRI.parse _namespace_name "CollectedDocument" |> NamespacedName

    /// <summary>
    /// A collection of Documents or Collections
    /// <see href="http://purl.org/ontology/bibo/Collection"></see></summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName
    /// <summary>
    /// A meeting for consultation or discussion.
    /// <see href="http://purl.org/ontology/bibo/Conference"></see></summary>
    let Conference = Namespaced_IRI.parse _namespace_name "Conference" |> NamespacedName

    /// <summary>
    /// A collection of legal cases.
    /// <see href="http://purl.org/ontology/bibo/CourtReporter"></see></summary>
    let CourtReporter =
        Namespaced_IRI.parse _namespace_name "CourtReporter" |> NamespacedName

    /// <summary>
    /// A legal document; for example, a court decision, a brief, and so forth.
    /// <see href="http://purl.org/ontology/bibo/LegalDocument"></see></summary>
    let LegalDocument =
        Namespaced_IRI.parse _namespace_name "LegalDocument" |> NamespacedName

    /// <summary>
    /// The status of the publication of a document.
    /// <see href="http://purl.org/ontology/bibo/DocumentStatus"></see></summary>
    let DocumentStatus =
        Namespaced_IRI.parse _namespace_name "DocumentStatus" |> NamespacedName

    /// <summary>
    /// An edited book.
    /// <see href="http://purl.org/ontology/bibo/EditedBook"></see></summary>
    let EditedBook = Namespaced_IRI.parse _namespace_name "EditedBook" |> NamespacedName
    /// <summary>
    /// A written communication addressed to a person or organization and transmitted electronically.
    /// <see href="http://purl.org/ontology/bibo/Email"></see></summary>
    let Email = Namespaced_IRI.parse _namespace_name "Email" |> NamespacedName

    /// <summary>
    /// A personal communication manifested in some document.
    /// <see href="http://purl.org/ontology/bibo/PersonalCommunicationDocument"></see></summary>
    let PersonalCommunicationDocument =
        Namespaced_IRI.parse _namespace_name "PersonalCommunicationDocument" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/Event"></see>
    /// </summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    /// A passage selected from a larger work.
    /// <see href="http://purl.org/ontology/bibo/Excerpt"></see></summary>
    let Excerpt = Namespaced_IRI.parse _namespace_name "Excerpt" |> NamespacedName
    /// <summary>
    /// aka movie.
    /// <see href="http://purl.org/ontology/bibo/Film"></see></summary>
    let Film = Namespaced_IRI.parse _namespace_name "Film" |> NamespacedName
    /// <summary>
    /// An instance or a session in which testimony and arguments are presented, esp. before an official, as a judge in a lawsuit.
    /// <see href="http://purl.org/ontology/bibo/Hearing"></see></summary>
    let Hearing = Namespaced_IRI.parse _namespace_name "Hearing" |> NamespacedName
    /// <summary>
    /// A document that presents visual or diagrammatic information.
    /// <see href="http://purl.org/ontology/bibo/Image"></see></summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName
    /// <summary>
    /// A formalized discussion between two or more people.
    /// <see href="http://purl.org/ontology/bibo/Interview"></see></summary>
    let Interview = Namespaced_IRI.parse _namespace_name "Interview" |> NamespacedName
    /// <summary>
    /// something that is printed or published and distributed, esp. a given number of a periodical
    /// <see href="http://purl.org/ontology/bibo/Issue"></see></summary>
    let Issue = Namespaced_IRI.parse _namespace_name "Issue" |> NamespacedName
    /// <summary>
    /// A periodical of scholarly journal Articles.
    /// <see href="http://purl.org/ontology/bibo/Journal"></see></summary>
    let Journal = Namespaced_IRI.parse _namespace_name "Journal" |> NamespacedName

    /// <summary>
    /// A document containing an authoritative determination (as a decree or judgment) made after consideration of facts or law.
    /// <see href="http://purl.org/ontology/bibo/LegalDecision"></see></summary>
    let LegalDecision =
        Namespaced_IRI.parse _namespace_name "LegalDecision" |> NamespacedName

    /// <summary>
    /// A written or printed communication addressed to a person or organization and usually transmitted by mail.
    /// <see href="http://purl.org/ontology/bibo/Letter"></see></summary>
    let Letter = Namespaced_IRI.parse _namespace_name "Letter" |> NamespacedName
    /// <summary>
    /// A periodical of magazine Articles. A magazine is a publication that is issued periodically, usually bound in a paper cover, and typically contains essays, stories, poems, etc., by many writers, and often photographs and drawings, frequently specializing in a particular subject or area, as hobbies, news, or sports.
    /// <see href="http://purl.org/ontology/bibo/Magazine"></see></summary>
    let Magazine = Namespaced_IRI.parse _namespace_name "Magazine" |> NamespacedName
    /// <summary>
    /// A small reference book, especially one giving instructions.
    /// <see href="http://purl.org/ontology/bibo/Manual"></see></summary>
    let Manual = Namespaced_IRI.parse _namespace_name "Manual" |> NamespacedName
    /// <summary>
    /// An unpublished Document, which may also be submitted to a publisher for publication.
    /// <see href="http://purl.org/ontology/bibo/Manuscript"></see></summary>
    let Manuscript = Namespaced_IRI.parse _namespace_name "Manuscript" |> NamespacedName
    /// <summary>
    /// A graphical depiction of geographic features.
    /// <see href="http://purl.org/ontology/bibo/Map"></see></summary>
    let Map = Namespaced_IRI.parse _namespace_name "Map" |> NamespacedName

    /// <summary>
    /// A loose, thematic, collection of Documents, often Books.
    /// <see href="http://purl.org/ontology/bibo/MultiVolumeBook"></see></summary>
    let MultiVolumeBook =
        Namespaced_IRI.parse _namespace_name "MultiVolumeBook" |> NamespacedName

    /// <summary>
    /// A periodical of documents, usually issued daily or weekly, containing current news, editorials, feature articles, and usually advertising.
    /// <see href="http://purl.org/ontology/bibo/Newspaper"></see></summary>
    let Newspaper = Namespaced_IRI.parse _namespace_name "Newspaper" |> NamespacedName
    /// <summary>
    /// Notes or annotations about a resource.
    /// <see href="http://purl.org/ontology/bibo/Note"></see></summary>
    let Note = Namespaced_IRI.parse _namespace_name "Note" |> NamespacedName
    /// <summary>
    /// A document describing the exclusive right granted by a government to an inventor to manufacture, use, or sell an invention for a certain number of years.
    /// <see href="http://purl.org/ontology/bibo/Patent"></see></summary>
    let Patent = Namespaced_IRI.parse _namespace_name "Patent" |> NamespacedName

    /// <summary>
    /// A public performance.
    /// <see href="http://purl.org/ontology/bibo/Performance"></see></summary>
    let Performance =
        Namespaced_IRI.parse _namespace_name "Performance" |> NamespacedName

    /// <summary>
    /// A communication between an agent and one or more specific recipients.
    /// <see href="http://purl.org/ontology/bibo/PersonalCommunication"></see></summary>
    let PersonalCommunication =
        Namespaced_IRI.parse _namespace_name "PersonalCommunication" |> NamespacedName

    /// <summary>
    /// A compilation of documents published from an event, such as a conference.
    /// <see href="http://purl.org/ontology/bibo/Proceedings"></see></summary>
    let Proceedings =
        Namespaced_IRI.parse _namespace_name "Proceedings" |> NamespacedName

    /// <summary>
    /// An excerpted collection of words.
    /// <see href="http://purl.org/ontology/bibo/Quote"></see></summary>
    let Quote = Namespaced_IRI.parse _namespace_name "Quote" |> NamespacedName

    /// <summary>
    /// A document that presents authoritative reference information, such as a dictionary or encylopedia .
    /// <see href="http://purl.org/ontology/bibo/ReferenceSource"></see></summary>
    let ReferenceSource =
        Namespaced_IRI.parse _namespace_name "ReferenceSource" |> NamespacedName

    /// <summary>
    /// A document describing an account or statement describing in detail an event, situation, or the like, usually as the result of observation, inquiry, etc..
    /// <see href="http://purl.org/ontology/bibo/Report"></see></summary>
    let Report = Namespaced_IRI.parse _namespace_name "Report" |> NamespacedName
    /// <summary>
    /// A loose, thematic, collection of Documents, often Books.
    /// <see href="http://purl.org/ontology/bibo/Series"></see></summary>
    let Series = Namespaced_IRI.parse _namespace_name "Series" |> NamespacedName
    /// <summary>
    /// A slide in a slideshow
    /// <see href="http://purl.org/ontology/bibo/Slide"></see></summary>
    let Slide = Namespaced_IRI.parse _namespace_name "Slide" |> NamespacedName
    /// <summary>
    /// A presentation of a series of slides, usually presented in front of an audience with written text and images.
    /// <see href="http://purl.org/ontology/bibo/Slideshow"></see></summary>
    let Slideshow = Namespaced_IRI.parse _namespace_name "Slideshow" |> NamespacedName
    /// <summary>
    /// A document describing a standard
    /// <see href="http://purl.org/ontology/bibo/Standard"></see></summary>
    let Standard = Namespaced_IRI.parse _namespace_name "Standard" |> NamespacedName
    /// <summary>
    /// A bill enacted into law.
    /// <see href="http://purl.org/ontology/bibo/Statute"></see></summary>
    let Statute = Namespaced_IRI.parse _namespace_name "Statute" |> NamespacedName
    /// <summary>
    /// A document created to summarize research findings associated with the completion of an academic degree.
    /// <see href="http://purl.org/ontology/bibo/Thesis"></see></summary>
    let Thesis = Namespaced_IRI.parse _namespace_name "Thesis" |> NamespacedName

    /// <summary>
    /// The academic degree of a Thesis
    /// <see href="http://purl.org/ontology/bibo/ThesisDegree"></see></summary>
    let ThesisDegree =
        Namespaced_IRI.parse _namespace_name "ThesisDegree" |> NamespacedName

    /// <summary>
    /// A web page is an online document available (at least initially) on the world wide web. A web page is written first and foremost to appear on the web, as distinct from other online resources such as books, manuscripts or audio documents which use the web primarily as a distribution mechanism alongside other more traditional methods such as print.
    /// <see href="http://purl.org/ontology/bibo/Webpage"></see></summary>
    let Webpage = Namespaced_IRI.parse _namespace_name "Webpage" |> NamespacedName
    /// <summary>
    /// A group of Webpages accessible on the Web.
    /// <see href="http://purl.org/ontology/bibo/Website"></see></summary>
    let Website = Namespaced_IRI.parse _namespace_name "Website" |> NamespacedName
    /// <summary>
    /// A seminar, discussion group, or the like, that emphasizes zxchange of ideas and the demonstration and application of techniques, skills, etc.
    /// <see href="http://purl.org/ontology/bibo/Workshop"></see></summary>
    let Workshop = Namespaced_IRI.parse _namespace_name "Workshop" |> NamespacedName
    /// <summary>
    /// A summary of the resource.
    /// <see href="http://purl.org/ontology/bibo/abstract"></see></summary>
    let abstract_ = Namespaced_IRI.parse _namespace_name "abstract" |> NamespacedName
    /// <summary>
    /// A legal decision that affirms a ruling.
    /// <see href="http://purl.org/ontology/bibo/affirmedBy"></see></summary>
    let affirmedBy = Namespaced_IRI.parse _namespace_name "affirmedBy" |> NamespacedName

    /// <summary>
    /// A legal decision on appeal that takes action on a case (affirming it, reversing it, etc.).
    /// <see href="http://purl.org/ontology/bibo/subsequentLegalDecision"></see></summary>
    let subsequentLegalDecision =
        Namespaced_IRI.parse _namespace_name "subsequentLegalDecision" |> NamespacedName

    /// <summary>
    /// Critical or explanatory note for a Document.
    /// <see href="http://purl.org/ontology/bibo/annotates"></see></summary>
    let annotates = Namespaced_IRI.parse _namespace_name "annotates" |> NamespacedName
    /// <summary>
    /// The date on which a legal case is argued before a court. Date is of format xsd:date
    /// <see href="http://purl.org/ontology/bibo/argued"></see></summary>
    let argued = Namespaced_IRI.parse _namespace_name "argued" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/asin"></see>
    /// </summary>
    let asin = Namespaced_IRI.parse _namespace_name "asin" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/identifier"></see>
    /// </summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName
    /// <summary>
    /// An ordered list of authors. Normally, this list is seen as a priority list that order authors by importance.
    /// <see href="http://purl.org/ontology/bibo/authorList"></see></summary>
    let authorList = Namespaced_IRI.parse _namespace_name "authorList" |> NamespacedName

    /// <summary>
    /// An ordered list of contributors. Normally, this list is seen as a priority list that order contributors by importance.
    /// <see href="http://purl.org/ontology/bibo/contributorList"></see></summary>
    let contributorList =
        Namespaced_IRI.parse _namespace_name "contributorList" |> NamespacedName

    /// <summary>
    /// An chapter number
    /// <see href="http://purl.org/ontology/bibo/chapter"></see></summary>
    let chapter = Namespaced_IRI.parse _namespace_name "chapter" |> NamespacedName
    /// <summary>
    /// Relates a document to another document that cites the
    /// first document.
    /// <see href="http://purl.org/ontology/bibo/citedBy"></see></summary>
    let citedBy = Namespaced_IRI.parse _namespace_name "citedBy" |> NamespacedName
    /// <summary>
    /// Relates a document to another document that is cited
    /// by the first document as reference, comment, review, quotation or for
    /// another purpose.
    /// <see href="http://purl.org/ontology/bibo/cites"></see></summary>
    let cites = Namespaced_IRI.parse _namespace_name "cites" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/coden"></see>
    /// </summary>
    let coden = Namespaced_IRI.parse _namespace_name "coden" |> NamespacedName
    /// <summary>
    /// This property is for a plain-text rendering of the content of a Document. While the plain-text content of an entire document could be described by this property.
    /// <see href="http://purl.org/ontology/bibo/content"></see></summary>
    let content = Namespaced_IRI.parse _namespace_name "content" |> NamespacedName
    /// <summary>
    /// A court associated with a legal document; for example, that which issues a decision.
    /// <see href="http://purl.org/ontology/bibo/court"></see></summary>
    let court = Namespaced_IRI.parse _namespace_name "court" |> NamespacedName
    /// <summary>
    /// The thesis degree.
    /// <see href="http://purl.org/ontology/bibo/degree"></see></summary>
    let degree = Namespaced_IRI.parse _namespace_name "degree" |> NamespacedName

    /// <summary>
    /// masters degree in arts
    /// <see href="http://purl.org/ontology/bibo/degrees/ma"></see></summary>
    let ``degrees/ma`` =
        Namespaced_IRI.parse _namespace_name "degrees/ma" |> NamespacedName

    /// <summary>
    /// masters degree in science
    /// <see href="http://purl.org/ontology/bibo/degrees/ms"></see></summary>
    let ``degrees/ms`` =
        Namespaced_IRI.parse _namespace_name "degrees/ms" |> NamespacedName

    /// <summary>
    /// PhD degree
    /// <see href="http://purl.org/ontology/bibo/degrees/phd"></see></summary>
    let ``degrees/phd`` =
        Namespaced_IRI.parse _namespace_name "degrees/phd" |> NamespacedName

    /// <summary>
    /// A Film director.
    /// <see href="http://purl.org/ontology/bibo/director"></see></summary>
    let director = Namespaced_IRI.parse _namespace_name "director" |> NamespacedName

    /// <summary>
    /// Distributor of a document or a collection of documents.
    /// <see href="http://purl.org/ontology/bibo/distributor"></see></summary>
    let distributor =
        Namespaced_IRI.parse _namespace_name "distributor" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/eanucc13"></see>
    /// </summary>
    let eanucc13 = Namespaced_IRI.parse _namespace_name "eanucc13" |> NamespacedName
    /// <summary>
    /// A person having managerial and sometimes policy-making responsibility for the editorial part of a publishing firm or of a newspaper, magazine, or other publication.
    /// <see href="http://purl.org/ontology/bibo/editor"></see></summary>
    let editor = Namespaced_IRI.parse _namespace_name "editor" |> NamespacedName
    /// <summary>
    /// An ordered list of editors. Normally, this list is seen as a priority list that order editors by importance.
    /// <see href="http://purl.org/ontology/bibo/editorList"></see></summary>
    let editorList = Namespaced_IRI.parse _namespace_name "editorList" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/gtin14"></see>
    /// </summary>
    let gtin14 = Namespaced_IRI.parse _namespace_name "gtin14" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/handle"></see>
    /// </summary>
    let handle = Namespaced_IRI.parse _namespace_name "handle" |> NamespacedName

    /// <summary>
    /// An agent that is interviewed by another agent.
    /// <see href="http://purl.org/ontology/bibo/interviewee"></see></summary>
    let interviewee =
        Namespaced_IRI.parse _namespace_name "interviewee" |> NamespacedName

    /// <summary>
    /// An agent that interview another agent.
    /// <see href="http://purl.org/ontology/bibo/interviewer"></see></summary>
    let interviewer =
        Namespaced_IRI.parse _namespace_name "interviewer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/isbn10"></see>
    /// </summary>
    let isbn10 = Namespaced_IRI.parse _namespace_name "isbn10" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/isbn13"></see>
    /// </summary>
    let isbn13 = Namespaced_IRI.parse _namespace_name "isbn13" |> NamespacedName
    /// <summary>
    /// An entity responsible for issuing often informally published documents such as press releases, reports, etc.
    /// <see href="http://purl.org/ontology/bibo/issuer"></see></summary>
    let issuer = Namespaced_IRI.parse _namespace_name "issuer" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/lccn"></see>
    /// </summary>
    let lccn = Namespaced_IRI.parse _namespace_name "lccn" |> NamespacedName
    /// <summary>
    /// The number of pages contained in a document
    /// <see href="http://purl.org/ontology/bibo/numPages"></see></summary>
    let numPages = Namespaced_IRI.parse _namespace_name "numPages" |> NamespacedName
    /// <summary>
    /// The number of volumes contained in a collection of documents (usually a series, periodical, etc.).
    /// <see href="http://purl.org/ontology/bibo/numVolumes"></see></summary>
    let numVolumes = Namespaced_IRI.parse _namespace_name "numVolumes" |> NamespacedName
    /// <summary>
    /// A generic item or document number. Not to be confused with issue number.
    /// <see href="http://purl.org/ontology/bibo/number"></see></summary>
    let number = Namespaced_IRI.parse _namespace_name "number" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/oclcnum"></see>
    /// </summary>
    let oclcnum = Namespaced_IRI.parse _namespace_name "oclcnum" |> NamespacedName
    /// <summary>
    /// The organizer of an event; includes conference organizers, but also government agencies or other bodies that are responsible for conducting hearings.
    /// <see href="http://purl.org/ontology/bibo/organizer"></see></summary>
    let organizer = Namespaced_IRI.parse _namespace_name "organizer" |> NamespacedName
    /// <summary>
    /// Owner of a document or a collection of documents.
    /// <see href="http://purl.org/ontology/bibo/owner"></see></summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName
    /// <summary>
    /// A string of non-contiguous page spans that locate a Document within a Collection. Example: 23-25, 34, 54-56. For continuous page ranges, use the pageStart and pageEnd properties.
    /// <see href="http://purl.org/ontology/bibo/pages"></see></summary>
    let pages = Namespaced_IRI.parse _namespace_name "pages" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/performer"></see>
    /// </summary>
    let performer = Namespaced_IRI.parse _namespace_name "performer" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/pmid"></see>
    /// </summary>
    let pmid = Namespaced_IRI.parse _namespace_name "pmid" |> NamespacedName
    /// <summary>
    /// The prefix of a name
    /// <see href="http://purl.org/ontology/bibo/prefixName"></see></summary>
    let prefixName = Namespaced_IRI.parse _namespace_name "prefixName" |> NamespacedName

    /// <summary>
    /// Relates a document to an event; for example, a paper to a conference.
    /// <see href="http://purl.org/ontology/bibo/presentedAt"></see></summary>
    let presentedAt =
        Namespaced_IRI.parse _namespace_name "presentedAt" |> NamespacedName

    /// <summary>
    /// Relates an event to associated documents; for example, conference to a paper.
    /// <see href="http://purl.org/ontology/bibo/presents"></see></summary>
    let presents = Namespaced_IRI.parse _namespace_name "presents" |> NamespacedName
    /// <summary>
    /// Producer of a document or a collection of documents.
    /// <see href="http://purl.org/ontology/bibo/producer"></see></summary>
    let producer = Namespaced_IRI.parse _namespace_name "producer" |> NamespacedName
    /// <summary>
    /// An agent that receives a communication document.
    /// <see href="http://purl.org/ontology/bibo/recipient"></see></summary>
    let recipient = Namespaced_IRI.parse _namespace_name "recipient" |> NamespacedName

    /// <summary>
    /// The resource in which another resource is reproduced.
    /// <see href="http://purl.org/ontology/bibo/reproducedIn"></see></summary>
    let reproducedIn =
        Namespaced_IRI.parse _namespace_name "reproducedIn" |> NamespacedName

    /// <summary>
    /// A legal decision that reverses a ruling.
    /// <see href="http://purl.org/ontology/bibo/reversedBy"></see></summary>
    let reversedBy = Namespaced_IRI.parse _namespace_name "reversedBy" |> NamespacedName
    /// <summary>
    /// Relates a review document to a reviewed thing (resource, item, etc.).
    /// <see href="http://purl.org/ontology/bibo/reviewOf"></see></summary>
    let reviewOf = Namespaced_IRI.parse _namespace_name "reviewOf" |> NamespacedName
    /// <summary>
    /// A section number
    /// <see href="http://purl.org/ontology/bibo/section"></see></summary>
    let section = Namespaced_IRI.parse _namespace_name "section" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/shortDescription"></see>
    /// </summary>
    let shortDescription =
        Namespaced_IRI.parse _namespace_name "shortDescription" |> NamespacedName

    /// <summary>
    /// The abbreviation of a title.
    /// <see href="http://purl.org/ontology/bibo/shortTitle"></see></summary>
    let shortTitle = Namespaced_IRI.parse _namespace_name "shortTitle" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/sici"></see>
    /// </summary>
    let sici = Namespaced_IRI.parse _namespace_name "sici" |> NamespacedName
    /// <summary>
    /// The publication status of (typically academic) content.
    /// <see href="http://purl.org/ontology/bibo/status"></see></summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName

    /// <summary>
    /// Accepted for publication after peer reviewing.
    /// <see href="http://purl.org/ontology/bibo/status/accepted"></see></summary>
    let ``status/accepted`` =
        Namespaced_IRI.parse _namespace_name "status/accepted" |> NamespacedName

    /// <summary>
    /// Document drafted
    /// <see href="http://purl.org/ontology/bibo/status/draft"></see></summary>
    let ``status/draft`` =
        Namespaced_IRI.parse _namespace_name "status/draft" |> NamespacedName

    /// <summary>
    /// Document to be published
    /// <see href="http://purl.org/ontology/bibo/status/forthcoming"></see></summary>
    let ``status/forthcoming`` =
        Namespaced_IRI.parse _namespace_name "status/forthcoming" |> NamespacedName

    /// <summary>
    /// Legal document
    /// <see href="http://purl.org/ontology/bibo/status/legal"></see></summary>
    let ``status/legal`` =
        Namespaced_IRI.parse _namespace_name "status/legal" |> NamespacedName

    /// <summary>
    /// A document that is not peer reviewed
    /// <see href="http://purl.org/ontology/bibo/status/nonPeerReviewed"></see></summary>
    let ``status/nonPeerReviewed`` =
        Namespaced_IRI.parse _namespace_name "status/nonPeerReviewed" |> NamespacedName

    /// <summary>
    /// The process by which articles are chosen to be included in a refereed journal. An editorial board consisting of experts in the same field as the author review the article and decide if it is authoritative enough for publication.
    /// <see href="http://purl.org/ontology/bibo/status/peerReviewed"></see></summary>
    let ``status/peerReviewed`` =
        Namespaced_IRI.parse _namespace_name "status/peerReviewed" |> NamespacedName

    /// <summary>
    /// Published document
    /// <see href="http://purl.org/ontology/bibo/status/published"></see></summary>
    let ``status/published`` =
        Namespaced_IRI.parse _namespace_name "status/published" |> NamespacedName

    /// <summary>
    /// Rejected for publication after peer reviewing.
    /// <see href="http://purl.org/ontology/bibo/status/rejected"></see></summary>
    let ``status/rejected`` =
        Namespaced_IRI.parse _namespace_name "status/rejected" |> NamespacedName

    /// <summary>
    /// Unpublished document
    /// <see href="http://purl.org/ontology/bibo/status/unpublished"></see></summary>
    let ``status/unpublished`` =
        Namespaced_IRI.parse _namespace_name "status/unpublished" |> NamespacedName

    /// <summary>
    /// The suffix of a name
    /// <see href="http://purl.org/ontology/bibo/suffixName"></see></summary>
    let suffixName = Namespaced_IRI.parse _namespace_name "suffixName" |> NamespacedName

    /// <summary>
    /// Relates a document to some transcribed original.
    /// <see href="http://purl.org/ontology/bibo/transcriptOf"></see></summary>
    let transcriptOf =
        Namespaced_IRI.parse _namespace_name "transcriptOf" |> NamespacedName

    /// <summary>
    /// Relates a translated document to the original document.
    /// <see href="http://purl.org/ontology/bibo/translationOf"></see></summary>
    let translationOf =
        Namespaced_IRI.parse _namespace_name "translationOf" |> NamespacedName

    /// <summary>
    /// A person who translates written document from one language to another.
    /// <see href="http://purl.org/ontology/bibo/translator"></see></summary>
    let translator = Namespaced_IRI.parse _namespace_name "translator" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/upc"></see>
    /// </summary>
    let upc = Namespaced_IRI.parse _namespace_name "upc" |> NamespacedName
    /// <summary>
    /// Universal Resource Identifier of a document
    /// <see href="http://purl.org/ontology/bibo/uri"></see></summary>
    let uri = Namespaced_IRI.parse _namespace_name "uri" |> NamespacedName
