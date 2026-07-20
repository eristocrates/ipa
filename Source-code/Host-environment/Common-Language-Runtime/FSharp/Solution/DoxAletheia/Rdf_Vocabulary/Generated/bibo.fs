namespace http.purl.org.ontology.bibo.slash

open DoxAletheia

module bibo =
    let _namespace_name = "http://purl.org/ontology/bibo/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/doi"></see>
    /// </summary>
    let doi = _prefix "doi"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/eissn"></see>
    /// </summary>
    let eissn = _prefix "eissn"
    /// <summary>
    /// The name defining a special edition of a document. Normally its a literal value composed of a version number and words.
    /// <see href="http://purl.org/ontology/bibo/edition"></see></summary>
    let edition = _prefix "edition"
    /// <summary>
    /// Ending page number within a continuous page range.
    /// <see href="http://purl.org/ontology/bibo/pageEnd"></see></summary>
    let pageEnd = _prefix "pageEnd"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/isbn"></see>
    /// </summary>
    let isbn = _prefix "isbn"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/issn"></see>
    /// </summary>
    let issn = _prefix "issn"
    /// <summary>
    /// An issue number
    /// <see href="http://purl.org/ontology/bibo/issue"></see></summary>
    let issue = _prefix "issue"
    /// <summary>
    /// A description (often numeric) that locates an item within a containing document or collection.
    /// <see href="http://purl.org/ontology/bibo/locator"></see></summary>
    let locator = _prefix "locator"
    /// <summary>
    /// Starting page number within a continuous page range.
    /// <see href="http://purl.org/ontology/bibo/pageStart"></see></summary>
    let pageStart = _prefix "pageStart"
    /// <summary>
    /// A volume number
    /// <see href="http://purl.org/ontology/bibo/volume"></see></summary>
    let volume = _prefix "volume"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/bdarcus"></see>
    /// </summary>
    let bdarcus = _prefix "bdarcus"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/fgiasson"></see>
    /// </summary>
    let fgiasson = _prefix "fgiasson"
    /// <summary>
    /// A scholarly academic article, typically published in a journal.
    /// <see href="http://purl.org/ontology/bibo/AcademicArticle"></see></summary>
    let AcademicArticle = _prefix "AcademicArticle"
    /// <summary>
    /// A written composition in prose, usually nonfiction, on a specific topic, forming an independent part of a book or other publication, as a newspaper or magazine.
    /// <see href="http://purl.org/ontology/bibo/Article"></see></summary>
    let Article = _prefix "Article"
    /// <summary>
    /// A document (noun) is a bounded physical representation of body of information designed with the capacity (and usually intent) to communicate. A document may manifest symbolic, diagrammatic or sensory-representational information.
    /// <see href="http://purl.org/ontology/bibo/Document"></see></summary>
    let Document = _prefix "Document"
    /// <summary>
    /// An audio document; aka record.
    /// <see href="http://purl.org/ontology/bibo/AudioDocument"></see></summary>
    let AudioDocument = _prefix "AudioDocument"
    /// <summary>
    /// An audio-visual document; film, video, and so forth.
    /// <see href="http://purl.org/ontology/bibo/AudioVisualDocument"></see></summary>
    let AudioVisualDocument = _prefix "AudioVisualDocument"
    /// <summary>
    /// Draft legislation presented for discussion to a legal body.
    /// <see href="http://purl.org/ontology/bibo/Bill"></see></summary>
    let Bill = _prefix "Bill"
    /// <summary>
    /// A legal document proposing or enacting a law or a group of laws.
    /// <see href="http://purl.org/ontology/bibo/Legislation"></see></summary>
    let Legislation = _prefix "Legislation"
    /// <summary>
    /// A written or printed work of fiction or nonfiction, usually on sheets of paper fastened or bound together within covers.
    /// <see href="http://purl.org/ontology/bibo/Book"></see></summary>
    let Book = _prefix "Book"
    /// <summary>
    /// A section of a book.
    /// <see href="http://purl.org/ontology/bibo/BookSection"></see></summary>
    let BookSection = _prefix "BookSection"
    /// <summary>
    /// a distinct part of a larger document or collected document.
    /// <see href="http://purl.org/ontology/bibo/DocumentPart"></see></summary>
    let DocumentPart = _prefix "DocumentPart"
    /// <summary>
    /// A written argument submitted to a court.
    /// <see href="http://purl.org/ontology/bibo/Brief"></see></summary>
    let Brief = _prefix "Brief"
    /// <summary>
    /// A document accompanying a legal case.
    /// <see href="http://purl.org/ontology/bibo/LegalCaseDocument"></see></summary>
    let LegalCaseDocument = _prefix "LegalCaseDocument"
    /// <summary>
    /// A chapter of a book.
    /// <see href="http://purl.org/ontology/bibo/Chapter"></see></summary>
    let Chapter = _prefix "Chapter"
    /// <summary>
    /// A collection of statutes.
    /// <see href="http://purl.org/ontology/bibo/Code"></see></summary>
    let Code = _prefix "Code"
    /// <summary>
    /// A group of related documents issued at regular intervals.
    /// <see href="http://purl.org/ontology/bibo/Periodical"></see></summary>
    let Periodical = _prefix "Periodical"
    /// <summary>
    /// A document that simultaneously contains other documents.
    /// <see href="http://purl.org/ontology/bibo/CollectedDocument"></see></summary>
    let CollectedDocument = _prefix "CollectedDocument"
    /// <summary>
    /// A collection of Documents or Collections
    /// <see href="http://purl.org/ontology/bibo/Collection"></see></summary>
    let Collection = _prefix "Collection"
    /// <summary>
    /// A meeting for consultation or discussion.
    /// <see href="http://purl.org/ontology/bibo/Conference"></see></summary>
    let Conference = _prefix "Conference"
    /// <summary>
    /// A collection of legal cases.
    /// <see href="http://purl.org/ontology/bibo/CourtReporter"></see></summary>
    let CourtReporter = _prefix "CourtReporter"
    /// <summary>
    /// A legal document; for example, a court decision, a brief, and so forth.
    /// <see href="http://purl.org/ontology/bibo/LegalDocument"></see></summary>
    let LegalDocument = _prefix "LegalDocument"
    /// <summary>
    /// The status of the publication of a document.
    /// <see href="http://purl.org/ontology/bibo/DocumentStatus"></see></summary>
    let DocumentStatus = _prefix "DocumentStatus"
    /// <summary>
    /// An edited book.
    /// <see href="http://purl.org/ontology/bibo/EditedBook"></see></summary>
    let EditedBook = _prefix "EditedBook"
    /// <summary>
    /// A written communication addressed to a person or organization and transmitted electronically.
    /// <see href="http://purl.org/ontology/bibo/Email"></see></summary>
    let Email = _prefix "Email"
    /// <summary>
    /// A personal communication manifested in some document.
    /// <see href="http://purl.org/ontology/bibo/PersonalCommunicationDocument"></see></summary>
    let PersonalCommunicationDocument = _prefix "PersonalCommunicationDocument"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/Event"></see>
    /// </summary>
    let Event = _prefix "Event"
    /// <summary>
    /// A passage selected from a larger work.
    /// <see href="http://purl.org/ontology/bibo/Excerpt"></see></summary>
    let Excerpt = _prefix "Excerpt"
    /// <summary>
    /// aka movie.
    /// <see href="http://purl.org/ontology/bibo/Film"></see></summary>
    let Film = _prefix "Film"
    /// <summary>
    /// An instance or a session in which testimony and arguments are presented, esp. before an official, as a judge in a lawsuit.
    /// <see href="http://purl.org/ontology/bibo/Hearing"></see></summary>
    let Hearing = _prefix "Hearing"
    /// <summary>
    /// A document that presents visual or diagrammatic information.
    /// <see href="http://purl.org/ontology/bibo/Image"></see></summary>
    let Image = _prefix "Image"
    /// <summary>
    /// A formalized discussion between two or more people.
    /// <see href="http://purl.org/ontology/bibo/Interview"></see></summary>
    let Interview = _prefix "Interview"
    /// <summary>
    /// something that is printed or published and distributed, esp. a given number of a periodical
    /// <see href="http://purl.org/ontology/bibo/Issue"></see></summary>
    let Issue = _prefix "Issue"
    /// <summary>
    /// A periodical of scholarly journal Articles.
    /// <see href="http://purl.org/ontology/bibo/Journal"></see></summary>
    let Journal = _prefix "Journal"
    /// <summary>
    /// A document containing an authoritative determination (as a decree or judgment) made after consideration of facts or law.
    /// <see href="http://purl.org/ontology/bibo/LegalDecision"></see></summary>
    let LegalDecision = _prefix "LegalDecision"
    /// <summary>
    /// A written or printed communication addressed to a person or organization and usually transmitted by mail.
    /// <see href="http://purl.org/ontology/bibo/Letter"></see></summary>
    let Letter = _prefix "Letter"
    /// <summary>
    /// A periodical of magazine Articles. A magazine is a publication that is issued periodically, usually bound in a paper cover, and typically contains essays, stories, poems, etc., by many writers, and often photographs and drawings, frequently specializing in a particular subject or area, as hobbies, news, or sports.
    /// <see href="http://purl.org/ontology/bibo/Magazine"></see></summary>
    let Magazine = _prefix "Magazine"
    /// <summary>
    /// A small reference book, especially one giving instructions.
    /// <see href="http://purl.org/ontology/bibo/Manual"></see></summary>
    let Manual = _prefix "Manual"
    /// <summary>
    /// An unpublished Document, which may also be submitted to a publisher for publication.
    /// <see href="http://purl.org/ontology/bibo/Manuscript"></see></summary>
    let Manuscript = _prefix "Manuscript"
    /// <summary>
    /// A graphical depiction of geographic features.
    /// <see href="http://purl.org/ontology/bibo/Map"></see></summary>
    let Map = _prefix "Map"
    /// <summary>
    /// A loose, thematic, collection of Documents, often Books.
    /// <see href="http://purl.org/ontology/bibo/MultiVolumeBook"></see></summary>
    let MultiVolumeBook = _prefix "MultiVolumeBook"
    /// <summary>
    /// A periodical of documents, usually issued daily or weekly, containing current news, editorials, feature articles, and usually advertising.
    /// <see href="http://purl.org/ontology/bibo/Newspaper"></see></summary>
    let Newspaper = _prefix "Newspaper"
    /// <summary>
    /// Notes or annotations about a resource.
    /// <see href="http://purl.org/ontology/bibo/Note"></see></summary>
    let Note = _prefix "Note"
    /// <summary>
    /// A document describing the exclusive right granted by a government to an inventor to manufacture, use, or sell an invention for a certain number of years.
    /// <see href="http://purl.org/ontology/bibo/Patent"></see></summary>
    let Patent = _prefix "Patent"
    /// <summary>
    /// A public performance.
    /// <see href="http://purl.org/ontology/bibo/Performance"></see></summary>
    let Performance = _prefix "Performance"
    /// <summary>
    /// A communication between an agent and one or more specific recipients.
    /// <see href="http://purl.org/ontology/bibo/PersonalCommunication"></see></summary>
    let PersonalCommunication = _prefix "PersonalCommunication"
    /// <summary>
    /// A compilation of documents published from an event, such as a conference.
    /// <see href="http://purl.org/ontology/bibo/Proceedings"></see></summary>
    let Proceedings = _prefix "Proceedings"
    /// <summary>
    /// An excerpted collection of words.
    /// <see href="http://purl.org/ontology/bibo/Quote"></see></summary>
    let Quote = _prefix "Quote"
    /// <summary>
    /// A document that presents authoritative reference information, such as a dictionary or encylopedia .
    /// <see href="http://purl.org/ontology/bibo/ReferenceSource"></see></summary>
    let ReferenceSource = _prefix "ReferenceSource"
    /// <summary>
    /// A document describing an account or statement describing in detail an event, situation, or the like, usually as the result of observation, inquiry, etc..
    /// <see href="http://purl.org/ontology/bibo/Report"></see></summary>
    let Report = _prefix "Report"
    /// <summary>
    /// A loose, thematic, collection of Documents, often Books.
    /// <see href="http://purl.org/ontology/bibo/Series"></see></summary>
    let Series = _prefix "Series"
    /// <summary>
    /// A slide in a slideshow
    /// <see href="http://purl.org/ontology/bibo/Slide"></see></summary>
    let Slide = _prefix "Slide"
    /// <summary>
    /// A presentation of a series of slides, usually presented in front of an audience with written text and images.
    /// <see href="http://purl.org/ontology/bibo/Slideshow"></see></summary>
    let Slideshow = _prefix "Slideshow"
    /// <summary>
    /// A document describing a standard
    /// <see href="http://purl.org/ontology/bibo/Standard"></see></summary>
    let Standard = _prefix "Standard"
    /// <summary>
    /// A bill enacted into law.
    /// <see href="http://purl.org/ontology/bibo/Statute"></see></summary>
    let Statute = _prefix "Statute"
    /// <summary>
    /// A document created to summarize research findings associated with the completion of an academic degree.
    /// <see href="http://purl.org/ontology/bibo/Thesis"></see></summary>
    let Thesis = _prefix "Thesis"
    /// <summary>
    /// The academic degree of a Thesis
    /// <see href="http://purl.org/ontology/bibo/ThesisDegree"></see></summary>
    let ThesisDegree = _prefix "ThesisDegree"
    /// <summary>
    /// A web page is an online document available (at least initially) on the world wide web. A web page is written first and foremost to appear on the web, as distinct from other online resources such as books, manuscripts or audio documents which use the web primarily as a distribution mechanism alongside other more traditional methods such as print.
    /// <see href="http://purl.org/ontology/bibo/Webpage"></see></summary>
    let Webpage = _prefix "Webpage"
    /// <summary>
    /// A group of Webpages accessible on the Web.
    /// <see href="http://purl.org/ontology/bibo/Website"></see></summary>
    let Website = _prefix "Website"
    /// <summary>
    /// A seminar, discussion group, or the like, that emphasizes zxchange of ideas and the demonstration and application of techniques, skills, etc.
    /// <see href="http://purl.org/ontology/bibo/Workshop"></see></summary>
    let Workshop = _prefix "Workshop"
    /// <summary>
    /// A summary of the resource.
    /// <see href="http://purl.org/ontology/bibo/abstract"></see></summary>
    let abstract_ = _prefix "abstract"
    /// <summary>
    /// A legal decision that affirms a ruling.
    /// <see href="http://purl.org/ontology/bibo/affirmedBy"></see></summary>
    let affirmedBy = _prefix "affirmedBy"
    /// <summary>
    /// A legal decision on appeal that takes action on a case (affirming it, reversing it, etc.).
    /// <see href="http://purl.org/ontology/bibo/subsequentLegalDecision"></see></summary>
    let subsequentLegalDecision = _prefix "subsequentLegalDecision"
    /// <summary>
    /// Critical or explanatory note for a Document.
    /// <see href="http://purl.org/ontology/bibo/annotates"></see></summary>
    let annotates = _prefix "annotates"
    /// <summary>
    /// The date on which a legal case is argued before a court. Date is of format xsd:date
    /// <see href="http://purl.org/ontology/bibo/argued"></see></summary>
    let argued = _prefix "argued"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/asin"></see>
    /// </summary>
    let asin = _prefix "asin"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/identifier"></see>
    /// </summary>
    let identifier = _prefix "identifier"
    /// <summary>
    /// An ordered list of authors. Normally, this list is seen as a priority list that order authors by importance.
    /// <see href="http://purl.org/ontology/bibo/authorList"></see></summary>
    let authorList = _prefix "authorList"
    /// <summary>
    /// An ordered list of contributors. Normally, this list is seen as a priority list that order contributors by importance.
    /// <see href="http://purl.org/ontology/bibo/contributorList"></see></summary>
    let contributorList = _prefix "contributorList"
    /// <summary>
    /// An chapter number
    /// <see href="http://purl.org/ontology/bibo/chapter"></see></summary>
    let chapter = _prefix "chapter"
    /// <summary>
    /// Relates a document to another document that cites the
    /// first document.
    /// <see href="http://purl.org/ontology/bibo/citedBy"></see></summary>
    let citedBy = _prefix "citedBy"
    /// <summary>
    /// Relates a document to another document that is cited
    /// by the first document as reference, comment, review, quotation or for
    /// another purpose.
    /// <see href="http://purl.org/ontology/bibo/cites"></see></summary>
    let cites = _prefix "cites"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/coden"></see>
    /// </summary>
    let coden = _prefix "coden"
    /// <summary>
    /// This property is for a plain-text rendering of the content of a Document. While the plain-text content of an entire document could be described by this property.
    /// <see href="http://purl.org/ontology/bibo/content"></see></summary>
    let content = _prefix "content"
    /// <summary>
    /// A court associated with a legal document; for example, that which issues a decision.
    /// <see href="http://purl.org/ontology/bibo/court"></see></summary>
    let court = _prefix "court"
    /// <summary>
    /// The thesis degree.
    /// <see href="http://purl.org/ontology/bibo/degree"></see></summary>
    let degree = _prefix "degree"
    /// <summary>
    /// masters degree in arts
    /// <see href="http://purl.org/ontology/bibo/degrees/ma"></see></summary>
    let ``degrees/ma`` = _prefix "degrees/ma"
    /// <summary>
    /// masters degree in science
    /// <see href="http://purl.org/ontology/bibo/degrees/ms"></see></summary>
    let ``degrees/ms`` = _prefix "degrees/ms"
    /// <summary>
    /// PhD degree
    /// <see href="http://purl.org/ontology/bibo/degrees/phd"></see></summary>
    let ``degrees/phd`` = _prefix "degrees/phd"
    /// <summary>
    /// A Film director.
    /// <see href="http://purl.org/ontology/bibo/director"></see></summary>
    let director = _prefix "director"
    /// <summary>
    /// Distributor of a document or a collection of documents.
    /// <see href="http://purl.org/ontology/bibo/distributor"></see></summary>
    let distributor = _prefix "distributor"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/eanucc13"></see>
    /// </summary>
    let eanucc13 = _prefix "eanucc13"
    /// <summary>
    /// A person having managerial and sometimes policy-making responsibility for the editorial part of a publishing firm or of a newspaper, magazine, or other publication.
    /// <see href="http://purl.org/ontology/bibo/editor"></see></summary>
    let editor = _prefix "editor"
    /// <summary>
    /// An ordered list of editors. Normally, this list is seen as a priority list that order editors by importance.
    /// <see href="http://purl.org/ontology/bibo/editorList"></see></summary>
    let editorList = _prefix "editorList"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/gtin14"></see>
    /// </summary>
    let gtin14 = _prefix "gtin14"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/handle"></see>
    /// </summary>
    let handle = _prefix "handle"
    /// <summary>
    /// An agent that is interviewed by another agent.
    /// <see href="http://purl.org/ontology/bibo/interviewee"></see></summary>
    let interviewee = _prefix "interviewee"
    /// <summary>
    /// An agent that interview another agent.
    /// <see href="http://purl.org/ontology/bibo/interviewer"></see></summary>
    let interviewer = _prefix "interviewer"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/isbn10"></see>
    /// </summary>
    let isbn10 = _prefix "isbn10"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/isbn13"></see>
    /// </summary>
    let isbn13 = _prefix "isbn13"
    /// <summary>
    /// An entity responsible for issuing often informally published documents such as press releases, reports, etc.
    /// <see href="http://purl.org/ontology/bibo/issuer"></see></summary>
    let issuer = _prefix "issuer"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/lccn"></see>
    /// </summary>
    let lccn = _prefix "lccn"
    /// <summary>
    /// The number of pages contained in a document
    /// <see href="http://purl.org/ontology/bibo/numPages"></see></summary>
    let numPages = _prefix "numPages"
    /// <summary>
    /// The number of volumes contained in a collection of documents (usually a series, periodical, etc.).
    /// <see href="http://purl.org/ontology/bibo/numVolumes"></see></summary>
    let numVolumes = _prefix "numVolumes"
    /// <summary>
    /// A generic item or document number. Not to be confused with issue number.
    /// <see href="http://purl.org/ontology/bibo/number"></see></summary>
    let number = _prefix "number"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/oclcnum"></see>
    /// </summary>
    let oclcnum = _prefix "oclcnum"
    /// <summary>
    /// The organizer of an event; includes conference organizers, but also government agencies or other bodies that are responsible for conducting hearings.
    /// <see href="http://purl.org/ontology/bibo/organizer"></see></summary>
    let organizer = _prefix "organizer"
    /// <summary>
    /// Owner of a document or a collection of documents.
    /// <see href="http://purl.org/ontology/bibo/owner"></see></summary>
    let owner = _prefix "owner"
    /// <summary>
    /// A string of non-contiguous page spans that locate a Document within a Collection. Example: 23-25, 34, 54-56. For continuous page ranges, use the pageStart and pageEnd properties.
    /// <see href="http://purl.org/ontology/bibo/pages"></see></summary>
    let pages = _prefix "pages"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/performer"></see>
    /// </summary>
    let performer = _prefix "performer"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/pmid"></see>
    /// </summary>
    let pmid = _prefix "pmid"
    /// <summary>
    /// The prefix of a name
    /// <see href="http://purl.org/ontology/bibo/prefixName"></see></summary>
    let prefixName = _prefix "prefixName"
    /// <summary>
    /// Relates a document to an event; for example, a paper to a conference.
    /// <see href="http://purl.org/ontology/bibo/presentedAt"></see></summary>
    let presentedAt = _prefix "presentedAt"
    /// <summary>
    /// Relates an event to associated documents; for example, conference to a paper.
    /// <see href="http://purl.org/ontology/bibo/presents"></see></summary>
    let presents = _prefix "presents"
    /// <summary>
    /// Producer of a document or a collection of documents.
    /// <see href="http://purl.org/ontology/bibo/producer"></see></summary>
    let producer = _prefix "producer"
    /// <summary>
    /// An agent that receives a communication document.
    /// <see href="http://purl.org/ontology/bibo/recipient"></see></summary>
    let recipient = _prefix "recipient"
    /// <summary>
    /// The resource in which another resource is reproduced.
    /// <see href="http://purl.org/ontology/bibo/reproducedIn"></see></summary>
    let reproducedIn = _prefix "reproducedIn"
    /// <summary>
    /// A legal decision that reverses a ruling.
    /// <see href="http://purl.org/ontology/bibo/reversedBy"></see></summary>
    let reversedBy = _prefix "reversedBy"
    /// <summary>
    /// Relates a review document to a reviewed thing (resource, item, etc.).
    /// <see href="http://purl.org/ontology/bibo/reviewOf"></see></summary>
    let reviewOf = _prefix "reviewOf"
    /// <summary>
    /// A section number
    /// <see href="http://purl.org/ontology/bibo/section"></see></summary>
    let section = _prefix "section"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/shortDescription"></see>
    /// </summary>
    let shortDescription = _prefix "shortDescription"
    /// <summary>
    /// The abbreviation of a title.
    /// <see href="http://purl.org/ontology/bibo/shortTitle"></see></summary>
    let shortTitle = _prefix "shortTitle"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/sici"></see>
    /// </summary>
    let sici = _prefix "sici"
    /// <summary>
    /// The publication status of (typically academic) content.
    /// <see href="http://purl.org/ontology/bibo/status"></see></summary>
    let status = _prefix "status"
    /// <summary>
    /// Accepted for publication after peer reviewing.
    /// <see href="http://purl.org/ontology/bibo/status/accepted"></see></summary>
    let ``status/accepted`` = _prefix "status/accepted"
    /// <summary>
    /// Document drafted
    /// <see href="http://purl.org/ontology/bibo/status/draft"></see></summary>
    let ``status/draft`` = _prefix "status/draft"
    /// <summary>
    /// Document to be published
    /// <see href="http://purl.org/ontology/bibo/status/forthcoming"></see></summary>
    let ``status/forthcoming`` = _prefix "status/forthcoming"
    /// <summary>
    /// Legal document
    /// <see href="http://purl.org/ontology/bibo/status/legal"></see></summary>
    let ``status/legal`` = _prefix "status/legal"
    /// <summary>
    /// A document that is not peer reviewed
    /// <see href="http://purl.org/ontology/bibo/status/nonPeerReviewed"></see></summary>
    let ``status/nonPeerReviewed`` = _prefix "status/nonPeerReviewed"
    /// <summary>
    /// The process by which articles are chosen to be included in a refereed journal. An editorial board consisting of experts in the same field as the author review the article and decide if it is authoritative enough for publication.
    /// <see href="http://purl.org/ontology/bibo/status/peerReviewed"></see></summary>
    let ``status/peerReviewed`` = _prefix "status/peerReviewed"
    /// <summary>
    /// Published document
    /// <see href="http://purl.org/ontology/bibo/status/published"></see></summary>
    let ``status/published`` = _prefix "status/published"
    /// <summary>
    /// Rejected for publication after peer reviewing.
    /// <see href="http://purl.org/ontology/bibo/status/rejected"></see></summary>
    let ``status/rejected`` = _prefix "status/rejected"
    /// <summary>
    /// Unpublished document
    /// <see href="http://purl.org/ontology/bibo/status/unpublished"></see></summary>
    let ``status/unpublished`` = _prefix "status/unpublished"
    /// <summary>
    /// The suffix of a name
    /// <see href="http://purl.org/ontology/bibo/suffixName"></see></summary>
    let suffixName = _prefix "suffixName"
    /// <summary>
    /// Relates a document to some transcribed original.
    /// <see href="http://purl.org/ontology/bibo/transcriptOf"></see></summary>
    let transcriptOf = _prefix "transcriptOf"
    /// <summary>
    /// Relates a translated document to the original document.
    /// <see href="http://purl.org/ontology/bibo/translationOf"></see></summary>
    let translationOf = _prefix "translationOf"
    /// <summary>
    /// A person who translates written document from one language to another.
    /// <see href="http://purl.org/ontology/bibo/translator"></see></summary>
    let translator = _prefix "translator"
    /// <summary>
    ///   <see href="http://purl.org/ontology/bibo/upc"></see>
    /// </summary>
    let upc = _prefix "upc"
    /// <summary>
    /// Universal Resource Identifier of a document
    /// <see href="http://purl.org/ontology/bibo/uri"></see></summary>
    let uri = _prefix "uri"
