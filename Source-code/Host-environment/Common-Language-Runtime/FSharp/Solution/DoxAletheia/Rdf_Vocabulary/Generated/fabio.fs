namespace http.purl.org.spar.fabio.slash

open DoxAletheia.Rdf_Vocabulary

module fabio =
    let _namespace_name = "http://purl.org/spar/fabio/"

    /// <summary>
    /// A thesis reporting a research project undertaken as part of an undergraduate course of education leading to a bachelor's degree.
    /// <see href="http://purl.org/spar/fabio/BachelorsThesis"></see></summary>
    let BachelorsThesis =
        Namespaced_IRI.parse _namespace_name "BachelorsThesis" |> NamespacedName

    /// <summary>
    /// A thesis reporting the research undertaken during a period of graduate study leading to a doctoral degree.
    /// <see href="http://purl.org/spar/fabio/DoctoralThesis"></see></summary>
    let DoctoralThesis =
        Namespaced_IRI.parse _namespace_name "DoctoralThesis" |> NamespacedName

    /// <summary>
    /// A thesis reporting a research project undertaken as part of a graduate course of education leading to a master's degree.
    /// <see href="http://purl.org/spar/fabio/MastersThesis"></see></summary>
    let MastersThesis =
        Namespaced_IRI.parse _namespace_name "MastersThesis" |> NamespacedName

    /// <summary>
    /// A controlled vocabulary or official list that establishes, for consistency, the authoritative forms of headings, and the preferred terms or proper names to be used, when creating a catalogue or when indexing and searching a set of entities within a defined domain.
    /// <see href="http://purl.org/spar/fabio/AuthorityFile"></see></summary>
    let AuthorityFile =
        Namespaced_IRI.parse _namespace_name "AuthorityFile" |> NamespacedName

    /// <summary>
    /// A classification arranged in a hierarchical structure of classes and subclasses, showing parent-child isA relationships, or broader_than - narrower_than relationships.
    /// <see href="http://purl.org/spar/fabio/Taxonomy"></see></summary>
    let Taxonomy = Namespaced_IRI.parse _namespace_name "Taxonomy" |> NamespacedName
    /// <summary>
    /// A type of controlled vocabulary used in information retrieval applications for indexing or tagging purposes, in which relationships between terms are made explicit. These are normally hierarchical relationships (is-a, subsumption; e.g. a cow is a mammal), equivalency relationships relating non-preferred terms to preferred terms (e.g. pitch and frequency), or associative relationships, in which the relationship that exists is neither one of hierarchy or equivalence, but rather one of similarity (e.g. sports and leisure pursuits).
    /// <see href="http://purl.org/spar/fabio/Thesaurus"></see></summary>
    let Thesaurus = Namespaced_IRI.parse _namespace_name "Thesaurus" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/spar/fabio/FRBR%20diagram%20with%20new%20Fabio%20verbs.png"></see>
    /// </summary>
    let ``FRBR%20diagram%20with%20new%20Fabio%20verbs.png`` =
        Namespaced_IRI.parse _namespace_name "FRBR%20diagram%20with%20new%20Fabio%20verbs.png" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/spar/fabio/2018-05-02"></see>
    /// </summary>
    let ``_2018-05-02`` =
        Namespaced_IRI.parse _namespace_name "2018-05-02" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/spar/fabio/2019-02-19"></see>
    /// </summary>
    let ``_2019-02-19`` =
        Namespaced_IRI.parse _namespace_name "2019-02-19" |> NamespacedName

    /// <summary>
    /// A brief summary of a work on a particular subject, designed to act as the point-of-entry that will help the reader quickly to obtain an overview of the work's contents.   The abstract may be an integral part of the work itself, written by the same author(s) and appearing at the beginning of a work such as a research paper, report, review or thesis.  Alternatively it may be separate from the published work itself, and written by someone other than the author(s) of the published work, for example by a member of a professional abstracting service such as CAB Abstracts.
    /// <see href="http://purl.org/spar/fabio/Abstract"></see></summary>
    let Abstract = Namespaced_IRI.parse _namespace_name "Abstract" |> NamespacedName

    /// <summary>
    /// A structured summary containing essential metadata describing a research investigation and/or the research outputs that have resulted from it, for example datasets and journal articles, structured according to some minimal information standard.  Such a structured summary can be embodied in both human-readable and machine-readable manifestations, e.g. HTML and RDF.  Such a structured summary differs from the Abstract of a journal article, in that the latter is written as a piece of continuous prose, but typically omits vital factual information about the investigation, such as when and where it was conducted, by whom, and on now many specimens or subjects.
    /// <see href="http://purl.org/spar/fabio/StructuredSummary"></see></summary>
    let StructuredSummary =
        Namespaced_IRI.parse _namespace_name "StructuredSummary" |> NamespacedName

    /// <summary>
    /// A subclass of FRBR expression, restricted to expressions of fabio:Works.  For your latest research paper, the preprint submitted to the publisher, and the final published version to which the publisher assigned a unique digital object identifier, are both expressions of the same work.
    /// <see href="http://purl.org/spar/fabio/Expression"></see></summary>
    let Expression = Namespaced_IRI.parse _namespace_name "Expression" |> NamespacedName

    /// <summary>
    /// A document containing the programme and collected papers, or their abstracts, presented at an academic meeting.
    /// <see href="http://purl.org/spar/fabio/AcademicProceedings"></see></summary>
    let AcademicProceedings =
        Namespaced_IRI.parse _namespace_name "AcademicProceedings" |> NamespacedName

    /// <summary>
    /// A paper, typically the realization of a research paper reporting original research findings, usually published within an academic proceedings volume.
    /// <see href="http://purl.org/spar/fabio/ProceedingsPaper"></see></summary>
    let ProceedingsPaper =
        Namespaced_IRI.parse _namespace_name "ProceedingsPaper" |> NamespacedName

    /// <summary>
    /// A collection of expressions, for example a periodical or a book series.
    /// <see href="http://purl.org/spar/fabio/ExpressionCollection"></see></summary>
    let ExpressionCollection =
        Namespaced_IRI.parse _namespace_name "ExpressionCollection" |> NamespacedName

    /// <summary>
    /// An item of material added at the end of a book or other publication, typically to include omitted or late-arriving material.
    /// <see href="http://purl.org/spar/fabio/Addendum"></see></summary>
    let Addendum = Namespaced_IRI.parse _namespace_name "Addendum" |> NamespacedName
    /// <summary>
    /// A precise sequential set of pre-defined logical rules or computational operations to be employed for solving a particular problem in a finite number of steps.
    /// <see href="http://purl.org/spar/fabio/Algorithm"></see></summary>
    let Algorithm = Namespaced_IRI.parse _namespace_name "Algorithm" |> NamespacedName

    /// <summary>
    /// An explicit description of, or set of requirements to be satisfied by, a material, product, resource, service or standard.
    /// <see href="http://purl.org/spar/fabio/Specification"></see></summary>
    let Specification =
        Namespaced_IRI.parse _namespace_name "Specification" |> NamespacedName

    /// <summary>
    /// A real object that is an exemplar of a fabio:Manifestation, such as a particular copy of the book 'Alice's adventures in Wonderland', that a person may own.
    /// <see href="http://purl.org/spar/fabio/AnalogItem"></see></summary>
    let AnalogItem = Namespaced_IRI.parse _namespace_name "AnalogItem" |> NamespacedName
    /// <summary>
    /// This property relates a fabio:Item to the medium upon which it is stored.
    /// <see href="http://purl.org/spar/fabio/isStoredOn"></see></summary>
    let isStoredOn = Namespaced_IRI.parse _namespace_name "isStoredOn" |> NamespacedName

    /// <summary>
    /// A means of storing information in non-digital form, e.g. paper, film (for analogue photographs or movies), magnetic tape (for analogue sound recordings or video recordings) or vinyl disc.
    /// <see href="http://purl.org/spar/fabio/AnalogStorageMedium"></see></summary>
    let AnalogStorageMedium =
        Namespaced_IRI.parse _namespace_name "AnalogStorageMedium" |> NamespacedName

    /// <summary>
    /// A manifestation in an analog form.
    /// <see href="http://purl.org/spar/fabio/AnalogManifestation"></see></summary>
    let AnalogManifestation =
        Namespaced_IRI.parse _namespace_name "AnalogManifestation" |> NamespacedName

    /// <summary>
    /// A subclass of FRBR item, restricted to exemplars of fabio:Manifestations.  An example of a fabio:Item is a printed copy of a journal article on your desk, or a PDF file of that article that you purchased from a publisher and that now resides in digital form on your computer hard drive.
    /// <see href="http://purl.org/spar/fabio/Item"></see></summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName

    /// <summary>
    /// A digital object, such as a computer file.
    /// <see href="http://purl.org/spar/fabio/DigitalItem"></see></summary>
    let DigitalItem =
        Namespaced_IRI.parse _namespace_name "DigitalItem" |> NamespacedName

    /// <summary>
    /// A subclass of FRBR manifestation, restricted to manifestations of fabio:Expressions. fabio:Manifestation specifically applies to electronic (digital) as well as to physical manifestations of expressions.
    ///
    /// Examples of different manifestations of a single 'version of record' expression of a scholarly work include an article in a print journal or the on-line version of that article as a web page.
    /// <see href="http://purl.org/spar/fabio/Manifestation"></see></summary>
    let Manifestation =
        Namespaced_IRI.parse _namespace_name "Manifestation" |> NamespacedName

    /// <summary>
    /// A manifestation that represents data in binary form, encoding the data as a series of 0s and 1s.
    /// <see href="http://purl.org/spar/fabio/DigitalManifestation"></see></summary>
    let DigitalManifestation =
        Namespaced_IRI.parse _namespace_name "DigitalManifestation" |> NamespacedName

    /// <summary>
    /// This property relates a storage medium to the fabio:Item stored upon it.
    /// <see href="http://purl.org/spar/fabio/stores"></see></summary>
    let stores = Namespaced_IRI.parse _namespace_name "stores" |> NamespacedName

    /// <summary>
    /// A device for recording information or storing data.
    /// <see href="http://purl.org/spar/fabio/StorageMedium"></see></summary>
    let StorageMedium =
        Namespaced_IRI.parse _namespace_name "StorageMedium" |> NamespacedName

    /// <summary>
    /// A formal statement about something.
    /// <see href="http://purl.org/spar/fabio/Announcement"></see></summary>
    let Announcement =
        Namespaced_IRI.parse _namespace_name "Announcement" |> NamespacedName

    /// <summary>
    /// A subclass of FRBR work, restricted to works that are published or potentially publishable, and that contain or are referred to by bibliographic references, or entities used to define bibliographic references. FaBiO works, and their expressions and manifestations, are primarily textual publications such as books, magazines, newspapers and journals, and items of their content.  However, they also include datasets, computer algorithms, experimental protocols, formal specifications and vocabularies, legal records, governmental papers, technical and commercial reports and similar publications, and also bibliographies, reference lists, library catalogues and similar collections. For this reason, fabio:Work is not an equivalent class to frbr:ScholarlyWork.  An example of a fabio:Work is your latest research paper.
    /// <see href="http://purl.org/spar/fabio/Work"></see></summary>
    let Work = Namespaced_IRI.parse _namespace_name "Work" |> NamespacedName
    /// <summary>
    /// A collection of selected literary or scholastics works, for example poems, short stories, plays or research papers.
    /// <see href="http://purl.org/spar/fabio/Anthology"></see></summary>
    let Anthology = Namespaced_IRI.parse _namespace_name "Anthology" |> NamespacedName

    /// <summary>
    /// A set of metadata elements, policies and guidelines defined for a particular application.  The metadata elements used in the application profile may be drawn from more than one element sets, including locally defined sets.
    /// <see href="http://purl.org/spar/fabio/ApplicationProfile"></see></summary>
    let ApplicationProfile =
        Namespaced_IRI.parse _namespace_name "ApplicationProfile" |> NamespacedName

    /// <summary>
    /// A separate work that provides information describing one or more characteristics of a resource or entity.
    /// <see href="http://purl.org/spar/fabio/Metadata"></see></summary>
    let Metadata = Namespaced_IRI.parse _namespace_name "Metadata" |> NamespacedName

    /// <summary>
    ///  A computer program that enables a separate computer to interact programmatically with the computer running the API.  (Commonly abbreviated 'API'.)
    /// <see href="http://purl.org/spar/fabio/ApplicationProgrammingInterface"></see></summary>
    let ApplicationProgrammingInterface =
        Namespaced_IRI.parse _namespace_name "ApplicationProgrammingInterface" |> NamespacedName

    /// <summary>
    /// A unit of computer code in source or compiled form, employing one or more algorithms to be executed by a digital computer to undertake a particular task.  Computer programs are collectively called 'software' to distinguish them from the equipment ('hardware') upon which they run.
    /// <see href="http://purl.org/spar/fabio/ComputerProgram"></see></summary>
    let ComputerProgram =
        Namespaced_IRI.parse _namespace_name "ComputerProgram" |> NamespacedName

    /// <summary>
    /// An archival document is a realization of the content related to an archival record. It can be exemplified as a book, a document, a letter, a database, etc.
    /// <see href="http://purl.org/spar/fabio/ArchivalDocument"></see></summary>
    let ArchivalDocument =
        Namespaced_IRI.parse _namespace_name "ArchivalDocument" |> NamespacedName

    /// <summary>
    /// A collection of archival document.
    /// <see href="http://purl.org/spar/fabio/ArchivalDocumentSet"></see></summary>
    let ArchivalDocumentSet =
        Namespaced_IRI.parse _namespace_name "ArchivalDocumentSet" |> NamespacedName

    /// <summary>
    /// An archival record connotes a material created or received by a person, family, or organization, public or private, in the conduct of their affairs that is preserved because of the enduring value contained in the information it contains or as evidence of the function and the responsibilities of its creator.
    /// <see href="http://purl.org/spar/fabio/ArchivalRecord"></see></summary>
    let ArchivalRecord =
        Namespaced_IRI.parse _namespace_name "ArchivalRecord" |> NamespacedName

    /// <summary>
    /// A collection of archival records.
    /// <see href="http://purl.org/spar/fabio/ArchivalRecordSet"></see></summary>
    let ArchivalRecordSet =
        Namespaced_IRI.parse _namespace_name "ArchivalRecordSet" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/spar/fabio/WorkCollection"></see>
    /// </summary>
    let WorkCollection =
        Namespaced_IRI.parse _namespace_name "WorkCollection" |> NamespacedName

    /// <summary>
    /// The realization of a piece of writing on a particular topic, usually published within a periodical publication (e.g. journal, magazine and newspaper).
    /// <see href="http://purl.org/spar/fabio/Article"></see></summary>
    let Article = Namespaced_IRI.parse _namespace_name "Article" |> NamespacedName

    /// <summary>
    /// It describes any work regarded as art in its widest sense, including works from literature and music, visual art, etc.
    /// <see href="http://purl.org/spar/fabio/ArtisticWork"></see></summary>
    let ArtisticWork =
        Namespaced_IRI.parse _namespace_name "ArtisticWork" |> NamespacedName

    /// <summary>
    /// The realization of a sound recording.
    /// <see href="http://purl.org/spar/fabio/AudioDocument"></see></summary>
    let AudioDocument =
        Namespaced_IRI.parse _namespace_name "AudioDocument" |> NamespacedName

    /// <summary>
    /// The creative work of making an electrical or mechanical recording of sounds, such as the spoken voice, singing, instrumental music, animal vocalizations or sound effects.
    /// <see href="http://purl.org/spar/fabio/SoundRecording"></see></summary>
    let SoundRecording =
        Namespaced_IRI.parse _namespace_name "SoundRecording" |> NamespacedName

    /// <summary>
    /// A collection of selected words and phrases related to a particular domain of knowledge used to permit consistency of metadata annotation and improved retrieval following a search, in which homonyms, synonyms and similar ambiguities of meaning present in natural language are disambiguated.
    /// <see href="http://purl.org/spar/fabio/ControlledVocabulary"></see></summary>
    let ControlledVocabulary =
        Namespaced_IRI.parse _namespace_name "ControlledVocabulary" |> NamespacedName

    /// <summary>
    /// A book authored by a student containing a formal presentations of research outputs submitted for examination in completion of a course of study at an institution of higher education, to fulfil the requirements for an academic degree.  Also know as a dissertation.  [For the alternative meaning of the word 'thesis', namely the formulation of a concept, hypothesis, idea, point of view or theory presented for review and/or discussion, use fabio:Proposition.]
    /// <see href="http://purl.org/spar/fabio/Thesis"></see></summary>
    let Thesis = Namespaced_IRI.parse _namespace_name "Thesis" |> NamespacedName

    /// <summary>
    /// A database providing an authoritative source of bibliographic information, for example PubMed (http://www.ncbi.nlm.nih.gov/pubmed), CrossRef Metadata Search (http://search.crossref.org/) and PubMed Central (http://www.ncbi.nlm.nih.gov/pmc/).
    /// <see href="http://purl.org/spar/fabio/BibliographicDatabase"></see></summary>
    let BibliographicDatabase =
        Namespaced_IRI.parse _namespace_name "BibliographicDatabase" |> NamespacedName

    /// <summary>
    /// A structured collection of logically related records or data usually stored and retrieved using computer-based means.
    /// <see href="http://purl.org/spar/fabio/Database"></see></summary>
    let Database = Namespaced_IRI.parse _namespace_name "Database" |> NamespacedName

    /// <summary>
    /// Standard bibliographic metadata describing an expression of a work.  To take the example of a journal article, bibliographic metadata typically include the authors' names, the date of publication, the title of the article, the journal name and volume number, the first and last page numbers, and the Digital Object Identifier (DOI).
    /// <see href="http://purl.org/spar/fabio/BibliographicMetadata"></see></summary>
    let BibliographicMetadata =
        Namespaced_IRI.parse _namespace_name "BibliographicMetadata" |> NamespacedName

    /// <summary>
    /// An account of the events, works and achievements, both personal and professional, of a person, either living or dead.
    /// <see href="http://purl.org/spar/fabio/Biography"></see></summary>
    let Biography = Namespaced_IRI.parse _namespace_name "Biography" |> NamespacedName
    /// <summary>
    /// A Web publication medium containing blog posts.
    /// <see href="http://purl.org/spar/fabio/Blog"></see></summary>
    let Blog = Namespaced_IRI.parse _namespace_name "Blog" |> NamespacedName

    /// <summary>
    /// A digital manifestation on the Web, such as a wiki, a web site, a web page or a blog.
    /// <see href="http://purl.org/spar/fabio/WebManifestation"></see></summary>
    let WebManifestation =
        Namespaced_IRI.parse _namespace_name "WebManifestation" |> NamespacedName

    /// <summary>
    /// Information manifested in a blog, one of a set of periodic sequential entries containing commentary, descriptions of events, or other material such as images or videos, usually displayed in reverse-chronological order and usually maintained by an individual, or comments on such a post.
    /// <see href="http://purl.org/spar/fabio/BlogPost"></see></summary>
    let BlogPost = Namespaced_IRI.parse _namespace_name "BlogPost" |> NamespacedName
    /// <summary>
    /// Information prepared specifically and primarily for manifestation in a web page, comprising text, images, datasets and/or other works.
    /// <see href="http://purl.org/spar/fabio/WebContent"></see></summary>
    let WebContent = Namespaced_IRI.parse _namespace_name "WebContent" |> NamespacedName
    /// <summary>
    /// An item written or printed in a diary, list, account book, reference book, or database.
    /// <see href="http://purl.org/spar/fabio/Entry"></see></summary>
    let Entry = Namespaced_IRI.parse _namespace_name "Entry" |> NamespacedName
    /// <summary>
    /// A non-serial document that is complete in one volume or a designated finite number of volumes.  A book published by a publisher is usually  identified by an International Standard Book Number (ISBN), and may be manifested as a physical printed publication on paper bound in a hard or soft cover, or in electronic format as an 'e-book'.
    /// <see href="http://purl.org/spar/fabio/Book"></see></summary>
    let Book = Namespaced_IRI.parse _namespace_name "Book" |> NamespacedName

    /// <summary>
    /// A defined chapter of a book, usually with a separate title or number.
    /// <see href="http://purl.org/spar/fabio/BookChapter"></see></summary>
    let BookChapter =
        Namespaced_IRI.parse _namespace_name "BookChapter" |> NamespacedName

    /// <summary>
    /// A defined document section, forming part of or intended for inclusion within a larger document, usually with its own title or chapter number.  Different chapters within a document such as a book or a report may each be independently authored, or may all be authored by a single individual or group of authors.
    /// <see href="http://purl.org/spar/fabio/Chapter"></see></summary>
    let Chapter = Namespaced_IRI.parse _namespace_name "Chapter" |> NamespacedName
    /// <summary>
    /// A written review and critical analysis of the content, scope and quality of a book or other monographic work.
    /// <see href="http://purl.org/spar/fabio/BookReview"></see></summary>
    let BookReview = Namespaced_IRI.parse _namespace_name "BookReview" |> NamespacedName
    /// <summary>
    /// A review of others' work.
    /// <see href="http://purl.org/spar/fabio/Review"></see></summary>
    let Review = Namespaced_IRI.parse _namespace_name "Review" |> NamespacedName
    /// <summary>
    /// A sequence of books having certain characteristics in common that are formally identified together as a group - for instance, the books in the Law, Governance and Technology Series published by Springer.
    /// <see href="http://purl.org/spar/fabio/BookSeries"></see></summary>
    let BookSeries = Namespaced_IRI.parse _namespace_name "BookSeries" |> NamespacedName
    /// <summary>
    /// A sequence of expressions having certain characteristics in common that are formally identified together as a group.
    /// <see href="http://purl.org/spar/fabio/Series"></see></summary>
    let Series = Namespaced_IRI.parse _namespace_name "Series" |> NamespacedName
    /// <summary>
    /// A set of books having certain characteristics in common that informally allow their identification together as a group - for instance, the books of the Harry Potter saga.
    /// <see href="http://purl.org/spar/fabio/BookSet"></see></summary>
    let BookSet = Namespaced_IRI.parse _namespace_name "BookSet" |> NamespacedName

    /// <summary>
    /// A brief report document.  This term may also be used synonymously with Rapid Communication to mean 'A short rapidly published research article or conference paper, typically reporting significant research results that have been recently discovered, or a brief news item reporting such discoveries.'
    /// <see href="http://purl.org/spar/fabio/BriefReport"></see></summary>
    let BriefReport =
        Namespaced_IRI.parse _namespace_name "BriefReport" |> NamespacedName

    /// <summary>
    /// A short rapidly published research article or conference paper, typically reporting significant research results that have been recently discovered, or a brief news item reporting such discoveries.
    /// <see href="http://purl.org/spar/fabio/RapidCommunication"></see></summary>
    let RapidCommunication =
        Namespaced_IRI.parse _namespace_name "RapidCommunication" |> NamespacedName

    /// <summary>
    /// The realization of a report, usually in printed form.
    /// <see href="http://purl.org/spar/fabio/ReportDocument"></see></summary>
    let ReportDocument =
        Namespaced_IRI.parse _namespace_name "ReportDocument" |> NamespacedName

    /// <summary>
    /// A document published by a funding agency requesting submission of applications for financial grants to fund projects, for example to enable research investigations in areas specified in the Call.
    /// <see href="http://purl.org/spar/fabio/CallForApplications"></see></summary>
    let CallForApplications =
        Namespaced_IRI.parse _namespace_name "CallForApplications" |> NamespacedName

    /// <summary>
    /// A proposal or proposition of a new conceptualization, hypothesis, idea, theory, activity or organisation.
    /// <see href="http://purl.org/spar/fabio/Proposition"></see></summary>
    let Proposition =
        Namespaced_IRI.parse _namespace_name "Proposition" |> NamespacedName

    /// <summary>
    /// A part of a grant application that provides a description of a proposed project and gives reasons why it is worthy of funding. (See also fabio:GrantApplication).
    /// <see href="http://purl.org/spar/fabio/CaseForSupport"></see></summary>
    let CaseForSupport =
        Namespaced_IRI.parse _namespace_name "CaseForSupport" |> NamespacedName

    /// <summary>
    /// A document containing the case for support for a particular project, usually contained within a grant application document but sometimes distributed separately, without the financial and organizational information that the grant application document also contains.
    /// <see href="http://purl.org/spar/fabio/CaseForSupportDocument"></see></summary>
    let CaseForSupportDocument =
        Namespaced_IRI.parse _namespace_name "CaseForSupportDocument" |> NamespacedName

    /// <summary>
    /// A report about a particular case or situation.
    /// <see href="http://purl.org/spar/fabio/CaseReport"></see></summary>
    let CaseReport = Namespaced_IRI.parse _namespace_name "CaseReport" |> NamespacedName
    /// <summary>
    /// A formal factual, methodological, statistical, technical or research report issued by an individual, group, agency, government body or other institution.
    /// <see href="http://purl.org/spar/fabio/Report"></see></summary>
    let Report = Namespaced_IRI.parse _namespace_name "Report" |> NamespacedName
    /// <summary>
    /// A list of items describing the content of a resource, for example items in an exhibition, items offered for sale by a vendor, or entities contained within a library or collection.  Ideally, catalogs are created according to specific and uniform principles of construction and are under the control of an authority file.
    /// <see href="http://purl.org/spar/fabio/Catalog"></see></summary>
    let Catalog = Namespaced_IRI.parse _namespace_name "Catalog" |> NamespacedName

    /// <summary>
    /// Metadata describing the citations made within a work to other works, and (optionally) some characteristics of the expressions of the cited works.
    /// <see href="http://purl.org/spar/fabio/CitationMetadata"></see></summary>
    let CitationMetadata =
        Namespaced_IRI.parse _namespace_name "CitationMetadata" |> NamespacedName

    /// <summary>
    /// A presentation of findings following a clinical or medical investigation on a human or animal patient, that may contain a diagnosis and proposals for therapeutic treatment and/or epidemiological control measures, or may propose further evaluative studies that will eventually lead to such outcomes.
    /// <see href="http://purl.org/spar/fabio/ClinicalCaseReport"></see></summary>
    let ClinicalCaseReport =
        Namespaced_IRI.parse _namespace_name "ClinicalCaseReport" |> NamespacedName

    /// <summary>
    /// A recommendation on the appropriate treatment and care of people with a specific disease or condition, based on the best available evidence, designed to help healthcare professionals in their work.
    /// <see href="http://purl.org/spar/fabio/ClinicalGuideline"></see></summary>
    let ClinicalGuideline =
        Namespaced_IRI.parse _namespace_name "ClinicalGuideline" |> NamespacedName

    /// <summary>
    /// A work created for the purpose of education or instruction, that may be expressed as a  text book, a lecture, a tutorial or an instruction manual.
    /// <see href="http://purl.org/spar/fabio/InstructionalWork"></see></summary>
    let InstructionalWork =
        Namespaced_IRI.parse _namespace_name "InstructionalWork" |> NamespacedName

    /// <summary>
    /// A predefined written procedural method, designed to ensure reliability of findings, for undertaking a medical or veterinary clinical study of the safety, efficacy, or optimum dosage schedule of one or more diagnostic, therapeutic or prophylactic drugs or treatments, or of devices or techniques, involving a randomized controlled trial for evidence-based assessment in humans or animals, specifying criteria of eligibility, nature of controls, sampling schedules, data collection parameters, statistical analyses, reporting standards, etc. to be employed in undertaking the clinical trial.
    /// <see href="http://purl.org/spar/fabio/ClinicalTrialDesign"></see></summary>
    let ClinicalTrialDesign =
        Namespaced_IRI.parse _namespace_name "ClinicalTrialDesign" |> NamespacedName

    /// <summary>
    /// The report of a pre-planned medical or veterinary clinical study of the safety, efficacy, or optimum dosage schedule of one or more diagnostic, therapeutic or prophylactic drugs, or of devices, treatments or techniques, involving a randomized controlled trial for evidence-based assessment in humans or animals selected according to predetermined criteria of eligibility and observed for evidence of favourable and unfavourable effects.
    /// <see href="http://purl.org/spar/fabio/ClinicalTrialReport"></see></summary>
    let ClinicalTrialReport =
        Namespaced_IRI.parse _namespace_name "ClinicalTrialReport" |> NamespacedName

    /// <summary>
    /// The report of a trial, for example an experimental trial or a legal trial.
    /// <see href="http://purl.org/spar/fabio/TrialReport"></see></summary>
    let TrialReport =
        Namespaced_IRI.parse _namespace_name "TrialReport" |> NamespacedName

    /// <summary>
    /// A collection of the literary or scholastic works of a single person.
    /// <see href="http://purl.org/spar/fabio/CollectedWorks"></see></summary>
    let CollectedWorks =
        Namespaced_IRI.parse _namespace_name "CollectedWorks" |> NamespacedName

    /// <summary>
    /// A verbal or written remark concerning some entity.  In written form, a comment is often appended to that entity and termed an annotation.  Within computer programs or ontologies, comments are added to enhance human understanding, and are usually prefaced by a special syntactic symbol that ensures they are ignored during execution of the program.
    /// <see href="http://purl.org/spar/fabio/Comment"></see></summary>
    let Comment = Namespaced_IRI.parse _namespace_name "Comment" |> NamespacedName

    /// <summary>
    /// A collection of all the literary or scholastic works of a single person.
    /// <see href="http://purl.org/spar/fabio/CompleteWorks"></see></summary>
    let CompleteWorks =
        Namespaced_IRI.parse _namespace_name "CompleteWorks" |> NamespacedName

    /// <summary>
    /// A computer program designed to assist a human user to perform one or more goal-oriented tasks such as word processing or image processing.  A computer application will typically save its output files in one or more specific formats, conforming either to proprietary or open standards.
    /// <see href="http://purl.org/spar/fabio/ComputerApplication"></see></summary>
    let ComputerApplication =
        Namespaced_IRI.parse _namespace_name "ComputerApplication" |> NamespacedName

    /// <summary>
    /// A digital item containing information in computer-readable form encoded in a particular format.
    /// <see href="http://purl.org/spar/fabio/ComputerFile"></see></summary>
    let ComputerFile =
        Namespaced_IRI.parse _namespace_name "ComputerFile" |> NamespacedName

    /// <summary>
    /// A paper, typically the realization of a research paper reporting original research findings, usually published within a conference proceedings volume.
    /// <see href="http://purl.org/spar/fabio/ConferencePaper"></see></summary>
    let ConferencePaper =
        Namespaced_IRI.parse _namespace_name "ConferencePaper" |> NamespacedName

    /// <summary>
    /// A display poster, typically containing text with illustrative figures and/or tables, usually reporting research results or proposing hypotheses, submitted for acceptance to and/or presented at a conference, seminar, symposium, workshop or similar event.
    /// <see href="http://purl.org/spar/fabio/ConferencePoster"></see></summary>
    let ConferencePoster =
        Namespaced_IRI.parse _namespace_name "ConferencePoster" |> NamespacedName

    /// <summary>
    /// A document containing the programme and collected conference papers, or their abstracts, presented at a conference, seminar, symposium or similar event.
    /// <see href="http://purl.org/spar/fabio/ConferenceProceedings"></see></summary>
    let ConferenceProceedings =
        Namespaced_IRI.parse _namespace_name "ConferenceProceedings" |> NamespacedName

    /// <summary>
    /// A set of words, either constituting a language, or more specifically used to describe a particular domain of knowledge.
    /// <see href="http://purl.org/spar/fabio/Vocabulary"></see></summary>
    let Vocabulary = Namespaced_IRI.parse _namespace_name "Vocabulary" |> NamespacedName
    /// <summary>
    /// A correction to an error in a previously published document.
    /// <see href="http://purl.org/spar/fabio/Correction"></see></summary>
    let Correction = Namespaced_IRI.parse _namespace_name "Correction" |> NamespacedName

    /// <summary>
    /// A formal correction to an error introduced by the author into a previously published document.
    /// <see href="http://purl.org/spar/fabio/Corrigendum"></see></summary>
    let Corrigendum =
        Namespaced_IRI.parse _namespace_name "Corrigendum" |> NamespacedName

    /// <summary>
    /// A protective covering used to bind together the pages of a document or the first, informative, page of a digital document.
    /// <see href="http://purl.org/spar/fabio/Cover"></see></summary>
    let Cover = Namespaced_IRI.parse _namespace_name "Cover" |> NamespacedName

    /// <summary>
    /// A new edition of a historical publication, edited by a scholar other than the original author, containing within the body text the supposedly best version of the original work, with footnotes detailing and commenting on textual variations between different versions, typically with an introduction to the original work written by the scholar, and with a bibliography listing related publications.
    /// <see href="http://purl.org/spar/fabio/CriticalEdition"></see></summary>
    let CriticalEdition =
        Namespaced_IRI.parse _namespace_name "CriticalEdition" |> NamespacedName

    /// <summary>
    /// A realisation of a fabio:Dataset (a frbr:Work) containing a defined collection of data with specific content and possibly with a specific version number, that can be embodied as a fabio:Digital Manifestation (a frbr:Manifestation with a specific format) and be represented by a specific fabio:ComputerFile (a frbr:Item) on someone's hard drive.
    /// <see href="http://purl.org/spar/fabio/DataFile"></see></summary>
    let DataFile = Namespaced_IRI.parse _namespace_name "DataFile" |> NamespacedName
    /// <summary>
    /// A collection of related facts, often expressed in numerical form and encoded in a defined structure.
    /// <see href="http://purl.org/spar/fabio/Dataset"></see></summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName

    /// <summary>
    /// A policy that descibes and defines how data should be managed, preserved and shared.
    /// <see href="http://purl.org/spar/fabio/DataManagementPolicy"></see></summary>
    let DataManagementPolicy =
        Namespaced_IRI.parse _namespace_name "DataManagementPolicy" |> NamespacedName

    /// <summary>
    /// A description and definition of how something should be done.  Ideally a policy should be both effective in achieving its goals and acceptable to those who have to abide by it.
    /// <see href="http://purl.org/spar/fabio/Policy"></see></summary>
    let Policy = Namespaced_IRI.parse _namespace_name "Policy" |> NamespacedName

    /// <summary>
    /// A document embodying a policy that descibes and defines how data should be managed, preserved and shared.
    /// <see href="http://purl.org/spar/fabio/DataManagementPolicyDocument"></see></summary>
    let DataManagementPolicyDocument =
        Namespaced_IRI.parse _namespace_name "DataManagementPolicyDocument" |> NamespacedName

    /// <summary>
    /// A document embodying a policy that descibes and defines how something should be done.
    /// <see href="http://purl.org/spar/fabio/PolicyDocument"></see></summary>
    let PolicyDocument =
        Namespaced_IRI.parse _namespace_name "PolicyDocument" |> NamespacedName

    /// <summary>
    /// A structured document giving information about how data arising from a research project or other endeavour is to be manages, preserved and shared.
    /// <see href="http://purl.org/spar/fabio/DataMangementPlan"></see></summary>
    let DataMangementPlan =
        Namespaced_IRI.parse _namespace_name "DataMangementPlan" |> NamespacedName

    /// <summary>
    /// A repository for storing data.
    /// <see href="http://purl.org/spar/fabio/DataRepository"></see></summary>
    let DataRepository =
        Namespaced_IRI.parse _namespace_name "DataRepository" |> NamespacedName

    /// <summary>
    /// A computer system in which information may be stored.
    /// <see href="http://purl.org/spar/fabio/Repository"></see></summary>
    let Repository = Namespaced_IRI.parse _namespace_name "Repository" |> NamespacedName

    /// <summary>
    /// The software used to create a database.  (Commonly abbreviated 'DBMS'.)
    /// <see href="http://purl.org/spar/fabio/DatabaseManagementSystem"></see></summary>
    let DatabaseManagementSystem =
        Namespaced_IRI.parse _namespace_name "DatabaseManagementSystem" |> NamespacedName

    /// <summary>
    /// The final published expression of a work that bears the publisher's imprimatur. Typically for a journal article, the Definitive Version results from revision of an earlier submitted version of the work following peer review, and is then published in print and/or digital form after the publisher has assigned it a DOI.  The Definitive Version is also known as the Version of Record, although according to the CrossRef Glossary (http://crossref.org/02publishers/glossary.html) that term can also refer to the author's final version of a work that is not formally published.
    /// <see href="http://purl.org/spar/fabio/DefinitiveVersion"></see></summary>
    let DefinitiveVersion =
        Namespaced_IRI.parse _namespace_name "DefinitiveVersion" |> NamespacedName

    /// <summary>
    /// A textual work prepared 'by hand', such as a typescript or word-processed pre-publication draft of a research paper or a report, or a work not otherwise reproduced in multiple copies.  [Note: fabio:Manuscript is not intended to describe a handwritten historical document on paper or parchment, for which the FRBR distinctions between work, expression, manifestation and item (individual copy) becomes blurred.].
    /// <see href="http://purl.org/spar/fabio/Manuscript"></see></summary>
    let Manuscript = Namespaced_IRI.parse _namespace_name "Manuscript" |> NamespacedName
    /// <summary>
    /// A demonstration paper, typically describing a new product, service or system created as a result of research, usually presented during a conference or workshop.
    /// <see href="http://purl.org/spar/fabio/DemoPaper"></see></summary>
    let DemoPaper = Namespaced_IRI.parse _namespace_name "DemoPaper" |> NamespacedName
    /// <summary>
    /// A personal record, in a form of book, with discrete entries (often handwritten) arranged by date, reporting what has happened over the course of a day or other period of time.
    /// <see href="http://purl.org/spar/fabio/Diary"></see></summary>
    let Diary = Namespaced_IRI.parse _namespace_name "Diary" |> NamespacedName
    /// <summary>
    /// A book containing personal notes, typically created by writing into a physical book with blank pages.
    /// <see href="http://purl.org/spar/fabio/Notebook"></see></summary>
    let Notebook = Namespaced_IRI.parse _namespace_name "Notebook" |> NamespacedName

    /// <summary>
    /// A means of storing information in digital form, involving binary encoding of data in 0s and 1s, e.g. a computer random access memory, hard disc, USB stick, CD, DVD or digital magnetic tape.
    /// <see href="http://purl.org/spar/fabio/DigitalStorageMedium"></see></summary>
    let DigitalStorageMedium =
        Namespaced_IRI.parse _namespace_name "DigitalStorageMedium" |> NamespacedName

    /// <summary>
    /// A database of information which is heavily optimized for reading.
    /// <see href="http://purl.org/spar/fabio/Directory"></see></summary>
    let Directory = Namespaced_IRI.parse _namespace_name "Directory" |> NamespacedName

    /// <summary>
    /// A discipline dictionary is a collection of subject disciplines.
    /// <see href="http://purl.org/spar/fabio/DisciplineDictionary"></see></summary>
    let DisciplineDictionary =
        Namespaced_IRI.parse _namespace_name "DisciplineDictionary" |> NamespacedName

    /// <summary>
    /// This property expresses the fact that a scheme contains a concept.
    /// <see href="http://purl.org/spar/fabio/isSchemeOf"></see></summary>
    let isSchemeOf = Namespaced_IRI.parse _namespace_name "isSchemeOf" |> NamespacedName

    /// <summary>
    /// A concept that identifies a field of knowledge or human activity defined in a controlled vocabulary, such as Computer Science, Biology, Economics, Cookery or Swimming.
    /// <see href="http://purl.org/spar/fabio/SubjectDiscipline"></see></summary>
    let SubjectDiscipline =
        Namespaced_IRI.parse _namespace_name "SubjectDiscipline" |> NamespacedName

    /// <summary>
    /// A controlled vocabulary, usually referring to terms within a particular classification system, such as the ACM Computing Classification System or MeSH, the Medical Subject Headings, or a controlled vocabulary of disciplines.
    /// <see href="http://purl.org/spar/fabio/TermDictionary"></see></summary>
    let TermDictionary =
        Namespaced_IRI.parse _namespace_name "TermDictionary" |> NamespacedName

    /// <summary>
    /// A repository for storing documents.
    /// <see href="http://purl.org/spar/fabio/DocumentRepository"></see></summary>
    let DocumentRepository =
        Namespaced_IRI.parse _namespace_name "DocumentRepository" |> NamespacedName

    /// <summary>
    /// A detachable outer cover, usually made of paper and printed with text and illustrations. This outer cover has folded flaps that hold it to the cover of a document.
    /// <see href="http://purl.org/spar/fabio/DustJacket"></see></summary>
    let DustJacket = Namespaced_IRI.parse _namespace_name "DustJacket" |> NamespacedName
    /// <summary>
    /// The realization of an opinion written by an editor.
    /// <see href="http://purl.org/spar/fabio/Editorial"></see></summary>
    let Editorial = Namespaced_IRI.parse _namespace_name "Editorial" |> NamespacedName
    /// <summary>
    /// An expression of a personal or professional opinion on an issue or topic.
    /// <see href="http://purl.org/spar/fabio/Opinion"></see></summary>
    let Opinion = Namespaced_IRI.parse _namespace_name "Opinion" |> NamespacedName
    /// <summary>
    /// A message transmitted over the internet as an item of electronic mail, typically based on the Simple Mail Transfer Protocol (SMTP).  Emails can have computer files containing documents, dataset and images attached to them or embedded within them.
    /// <see href="http://purl.org/spar/fabio/Email"></see></summary>
    let Email = Namespaced_IRI.parse _namespace_name "Email" |> NamespacedName

    /// <summary>
    /// Metadata describing the work itself, including for example the name of the creator(s), the title of the work, and the date and place of its creation.
    /// <see href="http://purl.org/spar/fabio/EntityMetadata"></see></summary>
    let EntityMetadata =
        Namespaced_IRI.parse _namespace_name "EntityMetadata" |> NamespacedName

    /// <summary>
    /// A formal correction to an error introduced by the publisher into a previously published document.
    /// <see href="http://purl.org/spar/fabio/Erratum"></see></summary>
    let Erratum = Namespaced_IRI.parse _namespace_name "Erratum" |> NamespacedName
    /// <summary>
    /// A piece of non-fiction writing on a particular subject, usually of moderate length and without chapters.
    /// <see href="http://purl.org/spar/fabio/Essay"></see></summary>
    let Essay = Namespaced_IRI.parse _namespace_name "Essay" |> NamespacedName

    /// <summary>
    /// A set of questions on a particular topic designed to test the academic, professional or technical ability of the person taking the examination, with achievement of a pass grade in the examination typically being a prerequisite for the award of an educational award such as a degree, or of a professional or technical qualification.
    /// <see href="http://purl.org/spar/fabio/ExaminationPaper"></see></summary>
    let ExaminationPaper =
        Namespaced_IRI.parse _namespace_name "ExaminationPaper" |> NamespacedName

    /// <summary>
    /// A segment or passage selected from a larger expression for use in another expression, usually with specific attribution to its original source.
    ///
    /// [Note: Use fabio:Excerpt to indicate a segment or passage selected from another expression that is not a passage of speech, and fabio:Quotation to indicate a segment or passage selected from another expression that is a passage of speech.]
    /// <see href="http://purl.org/spar/fabio/Excerpt"></see></summary>
    let Excerpt = Namespaced_IRI.parse _namespace_name "Excerpt" |> NamespacedName
    /// <summary>
    /// A passage of speech selected from a larger verbal or written expression for use in another expression, with specific attribution to its original source, and usually demarcated by quotation marks and / or by placing it in a separate indented paragraph.
    ///
    /// [Note: Use fabio:Quotation to indicate a segment or passage selected from another expression that is a passage of speech, and fabio:Excerpt to indicate a segment or passage selected from another expression that is not a passage of speech.]
    /// <see href="http://purl.org/spar/fabio/Quotation"></see></summary>
    let Quotation = Namespaced_IRI.parse _namespace_name "Quotation" |> NamespacedName

    /// <summary>
    /// An executive summary is a brief report summarizing a longer formal report, designed to present the key points, conclusions and recommendations arising from the study being reported, for readers too busy to take the time to read the complete report.
    /// <see href="http://purl.org/spar/fabio/ExecutiveSummary"></see></summary>
    let ExecutiveSummary =
        Namespaced_IRI.parse _namespace_name "ExecutiveSummary" |> NamespacedName

    /// <summary>
    /// A predefined written procedural method, designed to ensure successful replication of results by others in the same or other laboratories, that describes the overall objectives, organization and implementation of a scientific experiment, and specifies the experimental design, experimental methods, reagents, instrumentation, sampling schedules, data collection parameters, statistical analyses, image processing procedures, safety precautions, reporting standards, etc. employed in undertaking the experiment.
    /// <see href="http://purl.org/spar/fabio/ExperimentalProtocol"></see></summary>
    let ExperimentalProtocol =
        Namespaced_IRI.parse _namespace_name "ExperimentalProtocol" |> NamespacedName

    /// <summary>
    /// A visual communication object comprising one or more still images on a related theme.  If included within a publication, a figure is typically unaligned with the main body of text, having its own descriptive textual figure legend.
    /// <see href="http://purl.org/spar/fabio/Figure"></see></summary>
    let Figure = Namespaced_IRI.parse _namespace_name "Figure" |> NamespacedName
    /// <summary>
    /// A recorded static visual representation. This class of image includes diagrams, drawings, graphs, graphic designs, plans, maps, photographs and prints.
    /// <see href="http://purl.org/spar/fabio/StillImage"></see></summary>
    let StillImage = Namespaced_IRI.parse _namespace_name "StillImage" |> NamespacedName
    /// <summary>
    /// A movie with an accompanying soundtrack, typically created by a professional film studio, designed to communicate a fictional story, record an artistic event, or impart information that is scientific or documentary in nature.
    /// <see href="http://purl.org/spar/fabio/Film"></see></summary>
    let Film = Namespaced_IRI.parse _namespace_name "Film" |> NamespacedName
    /// <summary>
    /// The realization of a moving image.
    /// <see href="http://purl.org/spar/fabio/Movie"></see></summary>
    let Movie = Namespaced_IRI.parse _namespace_name "Movie" |> NamespacedName
    /// <summary>
    /// A system of classification derived from the practice and method of collaboratively creating and managing tags to annotate and categorize content in a particular domain. [Contrast fabio:Ontology]
    /// <see href="http://purl.org/spar/fabio/Folksonomy"></see></summary>
    let Folksonomy = Namespaced_IRI.parse _namespace_name "Folksonomy" |> NamespacedName

    /// <summary>
    /// A non-defined collection of words and phrases relating to a particular domain of knowledge, usually added freely by a community, in which homonyms, synonyms and similar ambiguities of meaning present in natural language are not formally disambiguated.
    /// <see href="http://purl.org/spar/fabio/UncontrolledVocabulary"></see></summary>
    let UncontrolledVocabulary =
        Namespaced_IRI.parse _namespace_name "UncontrolledVocabulary" |> NamespacedName

    /// <summary>
    /// A horizontal bar chart used to guide project planning, execution and control, illustrating the project schedule, with a separate line indicating the start and end dates of each of the key project activities or workpackages, and optionally showing the dependencies between these items. A Gantt chart is typically part of a project plan.
    /// <see href="http://purl.org/spar/fabio/GanttChart"></see></summary>
    let GanttChart = Namespaced_IRI.parse _namespace_name "GanttChart" |> NamespacedName

    /// <summary>
    /// A formal written request for financial support from a grant-giving body in support of a project, for example an academic research project.  (See also fabio:CaseForSupport.)
    /// <see href="http://purl.org/spar/fabio/GrantApplication"></see></summary>
    let GrantApplication =
        Namespaced_IRI.parse _namespace_name "GrantApplication" |> NamespacedName

    /// <summary>
    /// The realization of a grant application, usually containing a case for support document.
    /// <see href="http://purl.org/spar/fabio/GrantApplicationDocument"></see></summary>
    let GrantApplicationDocument =
        Namespaced_IRI.parse _namespace_name "GrantApplicationDocument" |> NamespacedName

    /// <summary>
    /// A print object bound with rigid protective covers (typically of cardboard covered with cloth, heavy paper, or sometimes leather).
    /// <see href="http://purl.org/spar/fabio/Hardback"></see></summary>
    let Hardback = Namespaced_IRI.parse _namespace_name "Hardback" |> NamespacedName

    /// <summary>
    /// An analog manifestation in physical printed form, typically on paper.
    /// <see href="http://purl.org/spar/fabio/PrintObject"></see></summary>
    let PrintObject =
        Namespaced_IRI.parse _namespace_name "PrintObject" |> NamespacedName

    /// <summary>
    /// A visual representation other than text, including all types of moving image and still image.
    /// <see href="http://purl.org/spar/fabio/Image"></see></summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName
    /// <summary>
    /// An 'In Brief' is a journal or magazine news item that describes all the articles (or all the important articles) in that issue of the periodical. The content of an 'In Brief' may be constructed from the abstracts of the articles it highlights, but is more likely to be written by a member of the periodical staff especially for the issue.
    /// <see href="http://purl.org/spar/fabio/InBrief"></see></summary>
    let InBrief = Namespaced_IRI.parse _namespace_name "InBrief" |> NamespacedName

    /// <summary>
    /// A news report published in a journal issue.
    /// <see href="http://purl.org/spar/fabio/JournalNewsItem"></see></summary>
    let JournalNewsItem =
        Namespaced_IRI.parse _namespace_name "JournalNewsItem" |> NamespacedName

    /// <summary>
    /// A news report published in a magazine issue.
    /// <see href="http://purl.org/spar/fabio/MagazineNewsItem"></see></summary>
    let MagazineNewsItem =
        Namespaced_IRI.parse _namespace_name "MagazineNewsItem" |> NamespacedName

    /// <summary>
    /// A published news report.
    /// <see href="http://purl.org/spar/fabio/NewsItem"></see></summary>
    let NewsItem = Namespaced_IRI.parse _namespace_name "NewsItem" |> NamespacedName
    /// <summary>
    /// A scholarly work that describes applied and validated solutions such as software tools, systems or architectures that benefit from the use of the technology of a particular scholarly domain. Usually, papers of this kind should also provide convincing evidence that there is use of the proposed application or tool by the target user group, preferably outside the institution that conducted its development.
    ///
    /// E.g. see http://iswc2018.semanticweb.org/call-for-in-use-track-papers/.
    /// <see href="http://purl.org/spar/fabio/InUsePaper"></see></summary>
    let InUsePaper = Namespaced_IRI.parse _namespace_name "InUsePaper" |> NamespacedName

    /// <summary>
    /// A work that reports scholarly activity on a particular topic, either published in written form, or delivered orally at a meeting.
    /// <see href="http://purl.org/spar/fabio/ScholarlyWork"></see></summary>
    let ScholarlyWork =
        Namespaced_IRI.parse _namespace_name "ScholarlyWork" |> NamespacedName

    /// <summary>
    /// An alphabetically-ordered list of words and phrases ('headings') and associated pointers ('locators') to where useful material relating to that heading can be found in a document.
    /// <see href="http://purl.org/spar/fabio/Index"></see></summary>
    let Index = Namespaced_IRI.parse _namespace_name "Index" |> NamespacedName

    /// <summary>
    /// An instructional document typically supplied with a technologically advanced consumer product, such as a car or a computer application, or with an item of complex equipment such as a microscope.
    /// <see href="http://purl.org/spar/fabio/InstructionManual"></see></summary>
    let InstructionManual =
        Namespaced_IRI.parse _namespace_name "InstructionManual" |> NamespacedName

    /// <summary>
    /// A collection of items.
    /// <see href="http://purl.org/spar/fabio/ItemCollection"></see></summary>
    let ItemCollection =
        Namespaced_IRI.parse _namespace_name "ItemCollection" |> NamespacedName

    /// <summary>
    /// A scholarly periodical primarily devoted to the publication of original research papers. [Printed and electronic manifestations of the same journal are usually identified by separate print and electronic International Standard Serial Numbers (ISSN or eISSN, respectively), that identifies the journal as a whole, not to individual issues of it.]
    /// <see href="http://purl.org/spar/fabio/Journal"></see></summary>
    let Journal = Namespaced_IRI.parse _namespace_name "Journal" |> NamespacedName

    /// <summary>
    /// A particular published volume of a journal, comprising one or more journal issues.
    /// <see href="http://purl.org/spar/fabio/JournalVolume"></see></summary>
    let JournalVolume =
        Namespaced_IRI.parse _namespace_name "JournalVolume" |> NamespacedName

    /// <summary>
    /// A particular published issue of a journal, one or more of which will constitute a volume of the journal.
    /// <see href="http://purl.org/spar/fabio/JournalIssue"></see></summary>
    let JournalIssue =
        Namespaced_IRI.parse _namespace_name "JournalIssue" |> NamespacedName

    /// <summary>
    /// A publication issued on a regular and ongoing basis as a series of issues, each issue comprising separate periodical items, for example editorials, articles, news items and/or other writings.
    /// <see href="http://purl.org/spar/fabio/Periodical"></see></summary>
    let Periodical = Namespaced_IRI.parse _namespace_name "Periodical" |> NamespacedName

    /// <summary>
    /// An article, typically the realization of a research paper reporting original research findings, published in a journal issue.
    /// <see href="http://purl.org/spar/fabio/JournalArticle"></see></summary>
    let JournalArticle =
        Namespaced_IRI.parse _namespace_name "JournalArticle" |> NamespacedName

    /// <summary>
    /// An editorial published in an issue of a journal.
    /// <see href="http://purl.org/spar/fabio/JournalEditorial"></see></summary>
    let JournalEditorial =
        Namespaced_IRI.parse _namespace_name "JournalEditorial" |> NamespacedName

    /// <summary>
    /// A particular issue of a periodical, identified and distinguished from other issues of the same publication by date and/or issue number and/or volume number, and comprising separate periodical items such as editorials, articles and news items.
    /// <see href="http://purl.org/spar/fabio/PeriodicalIssue"></see></summary>
    let PeriodicalIssue =
        Namespaced_IRI.parse _namespace_name "PeriodicalIssue" |> NamespacedName

    /// <summary>
    /// A particular published volume of a periodical.
    /// <see href="http://purl.org/spar/fabio/PeriodicalVolume"></see></summary>
    let PeriodicalVolume =
        Namespaced_IRI.parse _namespace_name "PeriodicalVolume" |> NamespacedName

    /// <summary>
    /// A notebook used by an individual research scientist as the primary record of his or her research activities. A researcher may use a laboratory notebook to document hypotheses, to describe experiments and to record data in various formats, to provide details of data analysis and interpretation, or to record the validation or invalidation of the original hypotheses. The laboratory notebook serves as an organizational tool and a memory aid.  It may also have a role in recording and protecting any intellectual property created during the research, and may be used in evidence when establishing priority of discoveries, for example in patent applications.  Electronic versions of laboratory notebooks are increasingly being employed by researchers, particularly in chemistry and the pharmaceutical industry.
    /// <see href="http://purl.org/spar/fabio/LaboratoryNotebook"></see></summary>
    let LaboratoryNotebook =
        Namespaced_IRI.parse _namespace_name "LaboratoryNotebook" |> NamespacedName

    /// <summary>
    /// A document containing notes that summarize a lecture or course of lectures.
    /// <see href="http://purl.org/spar/fabio/LectureNotes"></see></summary>
    let LectureNotes =
        Namespaced_IRI.parse _namespace_name "LectureNotes" |> NamespacedName

    /// <summary>
    /// A written explanation by a judge or group of judges that accompanies a ruling in a legal case, laying out the reasons and legal principles for the ruling, and sometimes containing pronouncements about what the law is and how it should be interpreted.
    /// <see href="http://purl.org/spar/fabio/LegalOpinion"></see></summary>
    let LegalOpinion =
        Namespaced_IRI.parse _namespace_name "LegalOpinion" |> NamespacedName

    /// <summary>
    /// A written or printed communication of a personal or professional nature between individuals and/or representatives of corporate bodies, usually transmitted by the postal service or published in a periodical.  In the latter case, the letter is typically addressed to the editor and comments on or discussed an item previously published by that periodical, or of interest to its readership.
    /// <see href="http://purl.org/spar/fabio/Letter"></see></summary>
    let Letter = Namespaced_IRI.parse _namespace_name "Letter" |> NamespacedName

    /// <summary>
    /// The catalog of the holdings of a library, for example that of the Library of Congress (http://catalog.loc.gov/).
    /// <see href="http://purl.org/spar/fabio/LibraryCatalog"></see></summary>
    let LibraryCatalog =
        Namespaced_IRI.parse _namespace_name "LibraryCatalog" |> NamespacedName

    /// <summary>
    /// A literary creative work, such as a novel, play, poem or song.
    /// <see href="http://purl.org/spar/fabio/LiteraryArtisticWork"></see></summary>
    let LiteraryArtisticWork =
        Namespaced_IRI.parse _namespace_name "LiteraryArtisticWork" |> NamespacedName

    /// <summary>
    /// A periodical, usually devoted to a particular topic or domain of interest, and usually published weekly or monthly, consisting primarily of  non-peer reviewed editorials, journalistic news items and more substantive articles, reviews, book reviews and discussions concerning current or recent events and publications, and matters of interest to the domain served by the magazine.  [Some scientific journals, notably Science and Nature, also secondarily serve as science magazines by containing substantive editorials and news items on vital or controversial issues].
    /// <see href="http://purl.org/spar/fabio/Magazine"></see></summary>
    let Magazine = Namespaced_IRI.parse _namespace_name "Magazine" |> NamespacedName

    /// <summary>
    /// A particular published  issue of a magazine, identified by date, and sometimes also by place (e.g. 'West Coast edition') or language (e.g. 'Spanish edition').
    /// <see href="http://purl.org/spar/fabio/MagazineIssue"></see></summary>
    let MagazineIssue =
        Namespaced_IRI.parse _namespace_name "MagazineIssue" |> NamespacedName

    /// <summary>
    /// An article published in a magazine issue.
    /// <see href="http://purl.org/spar/fabio/MagazineArticle"></see></summary>
    let MagazineArticle =
        Namespaced_IRI.parse _namespace_name "MagazineArticle" |> NamespacedName

    /// <summary>
    /// An editorial published in an issue of a magazine.
    /// <see href="http://purl.org/spar/fabio/MagazineEditorial"></see></summary>
    let MagazineEditorial =
        Namespaced_IRI.parse _namespace_name "MagazineEditorial" |> NamespacedName

    /// <summary>
    /// A collection of manifestations.
    /// <see href="http://purl.org/spar/fabio/ManifestationCollection"></see></summary>
    let ManifestationCollection =
        Namespaced_IRI.parse _namespace_name "ManifestationCollection" |> NamespacedName

    /// <summary>
    /// A report of a meeting of some kind.
    /// <see href="http://purl.org/spar/fabio/MeetingReport"></see></summary>
    let MeetingReport =
        Namespaced_IRI.parse _namespace_name "MeetingReport" |> NamespacedName

    /// <summary>
    /// A document that contains metadata information describing one or more characteristics of an entity.
    /// <see href="http://purl.org/spar/fabio/MetadataDocument"></see></summary>
    let MetadataDocument =
        Namespaced_IRI.parse _namespace_name "MetadataDocument" |> NamespacedName

    /// <summary>
    /// A scholarly work detailing a method, procedure or experimental protocol employed in a particular scholarly domain.
    /// <see href="http://purl.org/spar/fabio/MethodsPaper"></see></summary>
    let MethodsPaper =
        Namespaced_IRI.parse _namespace_name "MethodsPaper" |> NamespacedName

    /// <summary>
    /// A social networking publication medium such as Twitter, Tumblr, FriendFeed, Facebook or MySpace. A microblog differs from a traditional blog in that its individual content items are smaller than a traditional blog posts, typically containing just a short sentence, a single image, or a URI.  These small messages are referred to as microposts.
    /// <see href="http://purl.org/spar/fabio/Microblog"></see></summary>
    let Microblog = Namespaced_IRI.parse _namespace_name "Microblog" |> NamespacedName
    /// <summary>
    /// A content item that is published in a Microblog, typically containing just a short sentence, a single image, or a URL.
    /// <see href="http://purl.org/spar/fabio/Micropost"></see></summary>
    let Micropost = Namespaced_IRI.parse _namespace_name "Micropost" |> NamespacedName

    /// <summary>
    /// A metadata standard specifying items to be included when creating metadata describing a dataset of a particular type, or when creating a structured summary of the main findings of an article or report in a particular domain of interest, thereby ensuring adequate descriptive information is recorded for subsequent resource discovery and/or interpretation of the information described.  [See also fabio:ReportingStandard.]
    /// <see href="http://purl.org/spar/fabio/MinimalInformationStandard"></see></summary>
    let MinimalInformationStandard =
        Namespaced_IRI.parse _namespace_name "MinimalInformationStandard" |> NamespacedName

    /// <summary>
    /// A mathematical, graphical or physical representation of some physical reality, conceptual idea or theoretical construct.
    /// <see href="http://purl.org/spar/fabio/Model"></see></summary>
    let Model = Namespaced_IRI.parse _namespace_name "Model" |> NamespacedName

    /// <summary>
    /// A moving display, either generated dynamically by a computer program or formed from a series of pre-recorded still images imparting an impression of motion when shown in succession.  Examples include animations, cine films, videos, and computational simulations. Expressions of moving images may incorporate synchronized soundtracks.
    /// <see href="http://purl.org/spar/fabio/MovingImage"></see></summary>
    let MovingImage =
        Namespaced_IRI.parse _namespace_name "MovingImage" |> NamespacedName

    /// <summary>
    /// A piece of music, typically in the form of a composition recorded in musical notation.
    /// <see href="http://purl.org/spar/fabio/MusicalComposition"></see></summary>
    let MusicalComposition =
        Namespaced_IRI.parse _namespace_name "MusicalComposition" |> NamespacedName

    /// <summary>
    /// A single, attributable and machine-readable factual assertion - the smallest unit of publishable information that can be uniquely identified and attributed to its author – typically expressed in RDF.  The minimal components of a nanopublication are as follows:
    /// * the factual assertion itself, in the form subject, predicate and object (e.g. malaria is_a disease);
    /// * provenance information about the nanopublication, defining its authorship and creation date;
    /// * supporting information (optional), providing context for the assertion;
    /// * a unique identifier for the nanopublication, in the form of a URI;
    /// * an integrity key that ensures that the nanopublication is in its original form and has not been altered.
    ///
    /// <see href="http://purl.org/spar/fabio/Nanopublication"></see></summary>
    let Nanopublication =
        Namespaced_IRI.parse _namespace_name "Nanopublication" |> NamespacedName

    /// <summary>
    /// A report of an item of news.
    /// <see href="http://purl.org/spar/fabio/NewsReport"></see></summary>
    let NewsReport = Namespaced_IRI.parse _namespace_name "NewsReport" |> NamespacedName
    /// <summary>
    /// A non-peer reviewed periodical, usually published daily or weekly, consisting primarily of editorials and news items concerning current or recent events and matters of public interest.
    /// <see href="http://purl.org/spar/fabio/Newspaper"></see></summary>
    let Newspaper = Namespaced_IRI.parse _namespace_name "Newspaper" |> NamespacedName

    /// <summary>
    /// A particular published  issue of a newspaper, identified by date, and sometimes also by place or time (e.g. 'Late London Edition').
    /// <see href="http://purl.org/spar/fabio/NewspaperIssue"></see></summary>
    let NewspaperIssue =
        Namespaced_IRI.parse _namespace_name "NewspaperIssue" |> NamespacedName

    /// <summary>
    /// An article written by a journalist and published in a newspaper.
    /// <see href="http://purl.org/spar/fabio/NewspaperArticle"></see></summary>
    let NewspaperArticle =
        Namespaced_IRI.parse _namespace_name "NewspaperArticle" |> NamespacedName

    /// <summary>
    /// An editorial published in an issue of a newspaper.
    /// <see href="http://purl.org/spar/fabio/NewspaperEditorial"></see></summary>
    let NewspaperEditorial =
        Namespaced_IRI.parse _namespace_name "NewspaperEditorial" |> NamespacedName

    /// <summary>
    /// A news report published in a newspaper issue.
    /// <see href="http://purl.org/spar/fabio/NewspaperNewsItem"></see></summary>
    let NewspaperNewsItem =
        Namespaced_IRI.parse _namespace_name "NewspaperNewsItem" |> NamespacedName

    /// <summary>
    /// A notification of receipt of something, for example of receipt of a book that will later be the subject of a book review.
    /// <see href="http://purl.org/spar/fabio/NotificationOfReceipt"></see></summary>
    let NotificationOfReceipt =
        Namespaced_IRI.parse _namespace_name "NotificationOfReceipt" |> NamespacedName

    /// <summary>
    /// A long fictitious narrative written in literary prose.
    /// <see href="http://purl.org/spar/fabio/Novel"></see></summary>
    let Novel = Namespaced_IRI.parse _namespace_name "Novel" |> NamespacedName
    /// <summary>
    /// A news item reporting the death of a person, typically accompanied by an description of that person's life and contributions to his or her profession and to society at large.
    /// <see href="http://purl.org/spar/fabio/Obituary"></see></summary>
    let Obituary = Namespaced_IRI.parse _namespace_name "Obituary" |> NamespacedName
    /// <summary>
    /// A formal representation of a set of concepts within a domain of knowledge, and the logical relationships between those concepts.  [Contrast fabio:Folksonomy]
    /// <see href="http://purl.org/spar/fabio/Ontology"></see></summary>
    let Ontology = Namespaced_IRI.parse _namespace_name "Ontology" |> NamespacedName

    /// <summary>
    /// A document containing an ontology, for example an OWL (Web Ontology Language) file (http://www.w3.org/TR/owl-features/).
    /// <see href="http://purl.org/spar/fabio/OntologyDocument"></see></summary>
    let OntologyDocument =
        Namespaced_IRI.parse _namespace_name "OntologyDocument" |> NamespacedName

    /// <summary>
    /// A document containing a vocabulary
    /// <see href="http://purl.org/spar/fabio/VocabularyDocument"></see></summary>
    let VocabularyDocument =
        Namespaced_IRI.parse _namespace_name "VocabularyDocument" |> NamespacedName

    /// <summary>
    /// A formal speech, for example one delivered at a ceremonial occasion, or the written transcript of such a speech.
    /// <see href="http://purl.org/spar/fabio/Oration"></see></summary>
    let Oration = Namespaced_IRI.parse _namespace_name "Oration" |> NamespacedName
    /// <summary>
    /// A manifestation that represents pages either in physical (e.g., one side of a sheet of paper) or in digital form (e.g., a page in a PDF, or a web page).
    /// <see href="http://purl.org/spar/fabio/Page"></see></summary>
    let Page = Namespaced_IRI.parse _namespace_name "Page" |> NamespacedName
    /// <summary>
    /// A print object with a flexible cover, usually made of paper or paperboard.
    /// <see href="http://purl.org/spar/fabio/Paperback"></see></summary>
    let Paperback = Namespaced_IRI.parse _namespace_name "Paperback" |> NamespacedName
    /// <summary>
    /// A formal disclosure of a new invention approved by a governmental patent agency, made to register intellectual property rights, and to give exclusive rights to the inventor or assignee to manufacture, use, license or sell the invention for a certain number of years.
    /// <see href="http://purl.org/spar/fabio/Patent"></see></summary>
    let Patent = Namespaced_IRI.parse _namespace_name "Patent" |> NamespacedName

    /// <summary>
    /// A formal disclosure of a new invention, made in application for a patent.
    /// <see href="http://purl.org/spar/fabio/PatentApplication"></see></summary>
    let PatentApplication =
        Namespaced_IRI.parse _namespace_name "PatentApplication" |> NamespacedName

    /// <summary>
    /// The physical or electronic realization of a patent application.
    /// <see href="http://purl.org/spar/fabio/PatentApplicationDocument"></see></summary>
    let PatentApplicationDocument =
        Namespaced_IRI.parse _namespace_name "PatentApplicationDocument" |> NamespacedName

    /// <summary>
    /// The realization of a specification (a standard, a workflow, etc.).
    /// <see href="http://purl.org/spar/fabio/SpecificationDocument"></see></summary>
    let SpecificationDocument =
        Namespaced_IRI.parse _namespace_name "SpecificationDocument" |> NamespacedName

    /// <summary>
    /// The physical or electronic realization of a patent.
    /// <see href="http://purl.org/spar/fabio/PatentDocument"></see></summary>
    let PatentDocument =
        Namespaced_IRI.parse _namespace_name "PatentDocument" |> NamespacedName

    /// <summary>
    /// A piece of writing published in a periodical issue, typically accompanied by other items by different authors.
    /// <see href="http://purl.org/spar/fabio/PeriodicalItem"></see></summary>
    let PeriodicalItem =
        Namespaced_IRI.parse _namespace_name "PeriodicalItem" |> NamespacedName

    /// <summary>
    /// Information communicated personally by verbal or written means from one individual to one or more another persons or organizations.
    /// <see href="http://purl.org/spar/fabio/PersonalCommunication"></see></summary>
    let PersonalCommunication =
        Namespaced_IRI.parse _namespace_name "PersonalCommunication" |> NamespacedName

    /// <summary>
    /// A paper, usually presented during a specific session of a conference dedicated to Ph.D. students, that describes ongoing Ph.D. student's research.
    /// <see href="http://purl.org/spar/fabio/PhDSymposiumPaper"></see></summary>
    let PhDSymposiumPaper =
        Namespaced_IRI.parse _namespace_name "PhDSymposiumPaper" |> NamespacedName

    /// <summary>
    /// A form of literature written by a playwright, usually consisting of scripted dialogue between characters, intended for theatrical performance rather than reading.
    /// <see href="http://purl.org/spar/fabio/Play"></see></summary>
    let Play = Namespaced_IRI.parse _namespace_name "Play" |> NamespacedName
    /// <summary>
    /// An artistic work written with an intensity or beauty of language more characteristic of poetry than of prose.
    /// <see href="http://purl.org/spar/fabio/Poem"></see></summary>
    let Poem = Namespaced_IRI.parse _namespace_name "Poem" |> NamespacedName

    /// <summary>
    /// A scholarly work that reports a particular intellectual position or viewpoint regarding a particular scholarly topic. Usually, these papers are dependent on the author's opinion or interpretation, do not have an evaluation, and need to present relevant and novel discussion points in a thorough manner.
    ///
    /// E.g. see https://datasciencehub.net/content/guidelines-authors
    /// <see href="http://purl.org/spar/fabio/PositionPaper"></see></summary>
    let PositionPaper =
        Namespaced_IRI.parse _namespace_name "PositionPaper" |> NamespacedName

    /// <summary>
    /// A paper that typically accompanies a poster describing some preliminary  results of research, usually presented during a conference or a workshop.
    /// <see href="http://purl.org/spar/fabio/PosterPaper"></see></summary>
    let PosterPaper =
        Namespaced_IRI.parse _namespace_name "PosterPaper" |> NamespacedName

    /// <summary>
    /// The version of an author's original scholarly work, such as a research paper or a review, re-submitted for publication after revision by the author in the light of comments from reviewers.  [Note: For the version before peer review, use fabio:Preprint. For the final piblished version, use fabio:DefinitiveVersion.]
    /// <see href="http://purl.org/spar/fabio/Postprint"></see></summary>
    let Postprint = Namespaced_IRI.parse _namespace_name "Postprint" |> NamespacedName
    /// <summary>
    /// The version of an author's original scholarly work, such as a research paper or a review, first submitted to publisher for publication.  [Note: For that version resubmitted after peer-review and revision, use fabio:Postprint. For the final published version use fabio:DefinitiveVersion.]
    /// <see href="http://purl.org/spar/fabio/Preprint"></see></summary>
    let Preprint = Namespaced_IRI.parse _namespace_name "Preprint" |> NamespacedName

    /// <summary>
    /// A set of slides containing text, tables or figures, designed to communicate ideas or research results, for projection and viewing by an audience at a conference, symposium, seminar, lecture, workshop or other gatherings, typically embodied in a particular manifestation format such as a SlideShare or PowerPoint slideshow.
    /// <see href="http://purl.org/spar/fabio/Presentation"></see></summary>
    let Presentation =
        Namespaced_IRI.parse _namespace_name "Presentation" |> NamespacedName

    /// <summary>
    /// A news report published by an organization to provide information to journalists.
    /// <see href="http://purl.org/spar/fabio/PressRelease"></see></summary>
    let PressRelease =
        Namespaced_IRI.parse _namespace_name "PressRelease" |> NamespacedName

    /// <summary>
    /// A written review and critical analysis of the purpose, features, performance and other qualities of a product.
    /// <see href="http://purl.org/spar/fabio/ProductReview"></see></summary>
    let ProductReview =
        Namespaced_IRI.parse _namespace_name "ProductReview" |> NamespacedName

    /// <summary>
    /// Metadata describing a project, for example the project name, the names of those who conducted the project, the name of the institution in which the project was conducted, and the project funding information.
    /// <see href="http://purl.org/spar/fabio/ProjectMetadata"></see></summary>
    let ProjectMetadata =
        Namespaced_IRI.parse _namespace_name "ProjectMetadata" |> NamespacedName

    /// <summary>
    /// A document used to guide project planning, execution and control, specifying the project's goal and objectives and the activities and resources required to achieve these, setting out the project schedule, and identifying the major workpackages, milestones and deliverables.  A project plan will typically contain a Gantt chart.
    ///
    /// <see href="http://purl.org/spar/fabio/ProjectPlan"></see></summary>
    let ProjectPlan =
        Namespaced_IRI.parse _namespace_name "ProjectPlan" |> NamespacedName

    /// <summary>
    /// A report describing the outcomes of specific project, typically listing 'deliverables' created or 'milestones' achieved during the project.
    /// <see href="http://purl.org/spar/fabio/ProjectReport"></see></summary>
    let ProjectReport =
        Namespaced_IRI.parse _namespace_name "ProjectReport" |> NamespacedName

    /// <summary>
    /// A document containing a project report, intended to be delivered to a customer or funding agency describing the results achieved within a specific project.
    /// <see href="http://purl.org/spar/fabio/ProjectReportDocument"></see></summary>
    let ProjectReportDocument =
        Namespaced_IRI.parse _namespace_name "ProjectReportDocument" |> NamespacedName

    /// <summary>
    /// In printing and publishing, a proof copy is the preliminary version of a publication, after the inclusion of any author corrections following review, and after copy editing and formatting to bring the manuscript into the house style, intended for final checking prior to publication to detect and eliminate typographical errors, omissions or transpositions of text, incorrect layout or placement of illustrations and tables, or other formatting errors.  Those who check proofs include the editor, possibly the peer-reviewers (to ensure that their requested modifications have been included to their satisfaction), possibly an in-house professional proof-reader, and / or the author, who is ultimately responsible for ensuring the published work says what (s)he means it to say.  Substantive changes to the text are not permitted once the manuscript has reached proof stage.
    /// <see href="http://purl.org/spar/fabio/Proof"></see></summary>
    let Proof = Namespaced_IRI.parse _namespace_name "Proof" |> NamespacedName

    /// <summary>
    /// A set of questions on a particular topic, usually in the form of multiple choice questions requiring the respondent to select the correct answer, or providing the ability to indicate support for or against a proposal on a numerical scale, designed for rapid numerical analysis of responses and often used in surveying public opinion.
    /// <see href="http://purl.org/spar/fabio/Questionnaire"></see></summary>
    let Questionnaire =
        Namespaced_IRI.parse _namespace_name "Questionnaire" |> NamespacedName

    /// <summary>
    /// A book containing authoritative factual information, such as a dictionary, encyclopaedia, handbook or field guide, which is a realisation of a certain reference work and may contain several reference entries.
    /// <see href="http://purl.org/spar/fabio/ReferenceBook"></see></summary>
    let ReferenceBook =
        Namespaced_IRI.parse _namespace_name "ReferenceBook" |> NamespacedName

    /// <summary>
    /// A work to which people refer for authoritative factual information, such as a dictionary, encyclopaedia, entry, handbook or field guide, or an informative web page such as an institutional, research group or project home page.
    /// <see href="http://purl.org/spar/fabio/ReferenceWork"></see></summary>
    let ReferenceWork =
        Namespaced_IRI.parse _namespace_name "ReferenceWork" |> NamespacedName

    /// <summary>
    /// A particular reference entry containing authoritative factual information on a certain topic, usually contained in a larger expression.
    /// <see href="http://purl.org/spar/fabio/ReferenceEntry"></see></summary>
    let ReferenceEntry =
        Namespaced_IRI.parse _namespace_name "ReferenceEntry" |> NamespacedName

    /// <summary>
    /// A database in which the data are arranged in tables according to their common characteristics, with relationships between the tables being defined by a relational model or schema. A relational database is highly optimized for performance, and is queried using a database query language such as SQL (Structured Query Language).  The software used to create a relational database is called a relational database management system (RDBMS).
    /// <see href="http://purl.org/spar/fabio/RelationalDatabase"></see></summary>
    let RelationalDatabase =
        Namespaced_IRI.parse _namespace_name "RelationalDatabase" |> NamespacedName

    /// <summary>
    /// A work that is a reply, either to a letter or other direct communication, or to feedback or comments about a piece of submitted writing.  The latter is typically written by the author of a journal article submitted for publication, or by an applicant making a grant application, in response to reviews of the work from peer reviewers prior to publication (for the journal article) or prior to funding decision (for the grant application).  Alternatively, it can be written in response to post-publication peer-review of a published journal article, or comments about it.
    /// <see href="http://purl.org/spar/fabio/Reply"></see></summary>
    let Reply = Namespaced_IRI.parse _namespace_name "Reply" |> NamespacedName

    /// <summary>
    /// A set of recommendations for the minimum reporting requirements to be employed when reporting a particular type of investigation or project, for example a randomized clinical trial.  A reporting standard may involve a checklist and a flow diagram, offers a standard way for authors to prepare a complete and transparent report of their findings, and aids their critical appraisal and interpretation of their data. [See also fabio:MinimalInformationStandard.]
    /// <see href="http://purl.org/spar/fabio/ReportingStandard"></see></summary>
    let ReportingStandard =
        Namespaced_IRI.parse _namespace_name "ReportingStandard" |> NamespacedName

    /// <summary>
    /// A scholarly work that reports original research contributions addressing theoretical, analytical or experimental aspects of a particular scholarly domain.
    ///
    /// E.g. see http://iswc2018.semanticweb.org/call-for-research-track-papers/.
    /// <see href="http://purl.org/spar/fabio/ResearchPaper"></see></summary>
    let ResearchPaper =
        Namespaced_IRI.parse _namespace_name "ResearchPaper" |> NamespacedName

    /// <summary>
    /// A scholarly work that describes resources developed to provide experimental materials or facilities, support a research hypothesis, to provide answers to a research question, or that have contributed to the generation of novel scientific work. Examples of such resources include, for experimental sciences, mouse mutant lines and large communally used X-ray or neutron sources, and, for computer sciences, datasets, ontologies, vocabularies, ontology design patterns, evaluation benchmarks or methods, services, APIs and software frameworks, workflows, crowdsourcing task designs, protocols and metrics.
    ///
    /// E.g. see http://iswc2018.semanticweb.org/call-for-resources-track-papers/
    /// <see href="http://purl.org/spar/fabio/ResourcePaper"></see></summary>
    let ResourcePaper =
        Namespaced_IRI.parse _namespace_name "ResourcePaper" |> NamespacedName

    /// <summary>
    /// A formal statement retracting a statement or publication
    /// A retraction is a public statement made about an earlier statement that withdraws, cancels, refutes, diametrically reverses the original statement or ceases and desists from publishing the original statement.
    /// <see href="http://purl.org/spar/fabio/Retraction"></see></summary>
    let Retraction = Namespaced_IRI.parse _namespace_name "Retraction" |> NamespacedName

    /// <summary>
    /// An article that contains a review.
    /// <see href="http://purl.org/spar/fabio/ReviewArticle"></see></summary>
    let ReviewArticle =
        Namespaced_IRI.parse _namespace_name "ReviewArticle" |> NamespacedName

    /// <summary>
    /// A scholarly work that surveys the state of the art of topics central to a particular subject or relating to a specific domain (e.g. the scope of a certain journal or conference). Papers of this kind may contain a selective bibliography listing key papers related to the subject or providing advice on information sources, or they may strive to be comprehensive, covering all contributions to the development of a topic and exploring their different findings or views.
    ///
    /// E.g. see http://www.emeraldgrouppublishing.com/products/journals/author_guidelines.htm?id=JD
    /// <see href="http://purl.org/spar/fabio/ReviewPaper"></see></summary>
    let ReviewPaper =
        Namespaced_IRI.parse _namespace_name "ReviewPaper" |> NamespacedName

    /// <summary>
    /// A written work made especially for a film or television program. Screenplays can be original works or adaptations from existing pieces of writing, for example novels.
    /// <see href="http://purl.org/spar/fabio/Screenplay"></see></summary>
    let Screenplay = Namespaced_IRI.parse _namespace_name "Screenplay" |> NamespacedName
    /// <summary>
    /// A small computer program written in a scripting language such as JavaScript, PHP or Perl that allows control of one or more software applications.
    /// <see href="http://purl.org/spar/fabio/Script"></see></summary>
    let Script = Namespaced_IRI.parse _namespace_name "Script" |> NamespacedName
    /// <summary>
    /// A work of fiction that is usually written in prose, often in narrative format. This format tends to be more focused and less elaborate than longer works of fiction such as novels.
    /// <see href="http://purl.org/spar/fabio/ShortStory"></see></summary>
    let ShortStory = Namespaced_IRI.parse _namespace_name "ShortStory" |> NamespacedName
    /// <summary>
    /// A musical composition that contains vocal parts ('lyrics') that are performed ('sung').
    /// <see href="http://purl.org/spar/fabio/Song"></see></summary>
    let Song = Namespaced_IRI.parse _namespace_name "Song" |> NamespacedName

    /// <summary>
    /// An electronic form of data storage that displays a grid of rows and columns, in which each editable cell can contain alphanumeric text, a numeric value, or a formula that defines how the content of that cell is to be calculated from the content of another cell or cells.
    /// <see href="http://purl.org/spar/fabio/Spreadsheet"></see></summary>
    let Spreadsheet =
        Namespaced_IRI.parse _namespace_name "Spreadsheet" |> NamespacedName

    /// <summary>
    /// Clear and detailed written instructions of a prescribed step-by-step procedure to be routinely followed, and decisions to be made when undertaking a specific task, process or function, to achieve consistent performance, ensure safety and/or assure data quality.  (Commonly abbreviated 'SOP'.)
    /// <see href="http://purl.org/spar/fabio/StandardOperatingProcedure"></see></summary>
    let StandardOperatingProcedure =
        Namespaced_IRI.parse _namespace_name "StandardOperatingProcedure" |> NamespacedName

    /// <summary>
    /// A concept that defines a term within the controlled vocabulary of a particular classification system, such as the ACM Computing Classification System or MeSH, the Medical Subject Headings, used as an annotation to describe the subject, meaning or content of an entity.
    /// <see href="http://purl.org/spar/fabio/SubjectTerm"></see></summary>
    let SubjectTerm =
        Namespaced_IRI.parse _namespace_name "SubjectTerm" |> NamespacedName

    /// <summary>
    /// A supplement to a publication such as a book, journal, magazine or newspaper, additional to the main publication.  For example, a colour supplement to a sunday newspaper, or a special supplementary issue of a journal or a journal volume containing invited articles on a special topic, or abstracts or papers presented at a scientific conference.
    /// <see href="http://purl.org/spar/fabio/Supplement"></see></summary>
    let Supplement = Namespaced_IRI.parse _namespace_name "Supplement" |> NamespacedName

    /// <summary>
    /// A file accompanying a published journal article, containing additional information of relevance to the article, typically available from the publisher's web site via a hyperlink from the journal article itself.
    /// <see href="http://purl.org/spar/fabio/SupplementaryInformation"></see></summary>
    let SupplementaryInformation =
        Namespaced_IRI.parse _namespace_name "SupplementaryInformation" |> NamespacedName

    /// <summary>
    /// A file accompanying a published journal article, containing additional information of relevance to the article, typically available from the publisher's web site via a hyperlink from the journal article itself.
    /// <see href="http://purl.org/spar/fabio/SupplementaryInformationFile"></see></summary>
    let SupplementaryInformationFile =
        Namespaced_IRI.parse _namespace_name "SupplementaryInformationFile" |> NamespacedName

    /// <summary>
    /// A literature review focused on a single question that tries to identify, appraise, select and synthesize all high quality research evidence relevant to that question. Systematic reviews of high-quality randomized controlled trials are crucial to evidence-based medicine. An understanding of systematic reviews and how to implement them in practice is becoming mandatory for all professionals involved in the delivery of health care. Systematic reviews are not limited to medicine,  and are quite common in other sciences such as psychology, educational research and sociology.
    /// <see href="http://purl.org/spar/fabio/SystematicReview"></see></summary>
    let SystematicReview =
        Namespaced_IRI.parse _namespace_name "SystematicReview" |> NamespacedName

    /// <summary>
    /// A graphical means of presenting data in a grid of rows and columns, within which the cells usually contain alphanumeric text or numeric values.  If included within a publication, a table typically appearing unaligned with the main body of text, with its own descriptive title.
    /// <see href="http://purl.org/spar/fabio/Table"></see></summary>
    let Table = Namespaced_IRI.parse _namespace_name "Table" |> NamespacedName

    /// <summary>
    /// A table listing the parts of publication such as a book or technical specification, and the pages on which these content elements start (if the publication is printed or otherwise organized into pages), usually listed in order of appearance.  The Table of Contents typically includes first-level headers, such as the chapter titles of a book, and may also include second- and even third-level headers.  In electronic works, the Table of Contents entries are often internally hyperlinked to the content items, so that clicking on the entry takes the reader to that item.
    /// <see href="http://purl.org/spar/fabio/TableOfContents"></see></summary>
    let TableOfContents =
        Namespaced_IRI.parse _namespace_name "TableOfContents" |> NamespacedName

    /// <summary>
    /// A report of a technical nature.
    /// <see href="http://purl.org/spar/fabio/TechnicalReport"></see></summary>
    let TechnicalReport =
        Namespaced_IRI.parse _namespace_name "TechnicalReport" |> NamespacedName

    /// <summary>
    /// An official or public specification of, or requirement for, a technical method, practice, process or protocol that is involved in, for example, manufacturing, computation, electronic communication, or digital media.
    /// <see href="http://purl.org/spar/fabio/TechnicalStandard"></see></summary>
    let TechnicalStandard =
        Namespaced_IRI.parse _namespace_name "TechnicalStandard" |> NamespacedName

    /// <summary>
    /// A book containing instructional material relating to a particular topic of academic study, designed to be read by students.
    /// <see href="http://purl.org/spar/fabio/Textbook"></see></summary>
    let Textbook = Namespaced_IRI.parse _namespace_name "Textbook" |> NamespacedName
    /// <summary>
    /// A tabular dataset providing information about the times and locations of a planned series of events.
    /// <see href="http://purl.org/spar/fabio/Timetable"></see></summary>
    let Timetable = Namespaced_IRI.parse _namespace_name "Timetable" |> NamespacedName

    /// <summary>
    /// A database specifically designed for the storage and retrieval of Resource Description Framework (RDF) data consisting of subject-predicate-object triples.  A triple store is queried using the RDF query language SPARQL.
    /// <see href="http://purl.org/spar/fabio/Triplestore"></see></summary>
    let Triplestore =
        Namespaced_IRI.parse _namespace_name "Triplestore" |> NamespacedName

    /// <summary>
    /// A posting made on the social networking site Twitter. A tweet is a text message limited to 140 characters in length, that is broadcast and readable by anyone who accesses Twitter.
    /// <see href="http://purl.org/spar/fabio/Tweet"></see></summary>
    let Tweet = Namespaced_IRI.parse _namespace_name "Tweet" |> NamespacedName

    /// <summary>
    /// A mapping of correspondences between two vocabularies.  For controlled vocabularies, such mappings may be expressed using SKOS (http://www.w3.org/2004/02/skos/).
    /// <see href="http://purl.org/spar/fabio/VocabularyMapping"></see></summary>
    let VocabularyMapping =
        Namespaced_IRI.parse _namespace_name "VocabularyMapping" |> NamespacedName

    /// <summary>
    /// A document containing a vocabulary mapping
    /// <see href="http://purl.org/spar/fabio/VocabularyMappingDocument"></see></summary>
    let VocabularyMappingDocument =
        Namespaced_IRI.parse _namespace_name "VocabularyMappingDocument" |> NamespacedName

    /// <summary>
    /// A snapshots of (part of) the World Wide Web.
    /// <see href="http://purl.org/spar/fabio/WebArchive"></see></summary>
    let WebArchive = Namespaced_IRI.parse _namespace_name "WebArchive" |> NamespacedName
    /// <summary>
    /// A Web manifestation usually identified by a Uniform Resource Identifier (URI), and made accessible to a user by means of the Hypertext Transport Protocol (HTTP) in a Web browser window. Several interlinked web pages hosted together on a Web server and accessed through a single domain name or IP address constitute a web site.
    /// <see href="http://purl.org/spar/fabio/WebPage"></see></summary>
    let WebPage = Namespaced_IRI.parse _namespace_name "WebPage" |> NamespacedName
    /// <summary>
    /// A collection of related web pages containing text, images, videos and/or other digital assets that are addressed relative to a common Uniform Resource Locator (URL). A web site is hosted on at least one web server, accessible via a network such as the Internet or a private local area network.
    /// <see href="http://purl.org/spar/fabio/WebSite"></see></summary>
    let WebSite = Namespaced_IRI.parse _namespace_name "WebSite" |> NamespacedName
    /// <summary>
    /// An authoritative report or guide designed to educate readers and help people make decisions, or to explain technical problems and how to solve them. White papers are typically published by governments to propose new legislation for discussion, and by commercial companies to inform readers about products or services, as aids to marketing.
    /// <see href="http://purl.org/spar/fabio/WhitePaper"></see></summary>
    let WhitePaper = Namespaced_IRI.parse _namespace_name "WhitePaper" |> NamespacedName
    /// <summary>
    /// A collaborative Web manifestation, usually maintained by a project team or group, providing easy-to-edit pages that can be used to accumulate related information for shared use by the group and/or publication.
    /// <see href="http://purl.org/spar/fabio/Wiki"></see></summary>
    let Wiki = Namespaced_IRI.parse _namespace_name "Wiki" |> NamespacedName
    /// <summary>
    /// Information manifested in a wiki.
    /// <see href="http://purl.org/spar/fabio/WikiEntry"></see></summary>
    let WikiEntry = Namespaced_IRI.parse _namespace_name "WikiEntry" |> NamespacedName

    /// <summary>
    /// Information about a particular topic in one of the versions of Wikipedia, the online encyclopedia (http://www.wikipedia.org/).
    ///
    /// <see href="http://purl.org/spar/fabio/WikipediaEntry"></see></summary>
    let WikipediaEntry =
        Namespaced_IRI.parse _namespace_name "WikipediaEntry" |> NamespacedName

    /// <summary>
    /// A component of the case for support of a grant application, describing a particular aspect of the work to be undertaken.
    /// <see href="http://purl.org/spar/fabio/WorkPackage"></see></summary>
    let WorkPackage =
        Namespaced_IRI.parse _namespace_name "WorkPackage" |> NamespacedName

    /// <summary>
    /// A recorded sequence of connected steps, which may be automated, specifying a reliably repeatable sequence of operations to be undertaken when conducting a particular job, for example an in silico investigation that extracts and processes information from a number of bioinformatics databases.
    /// <see href="http://purl.org/spar/fabio/Workflow"></see></summary>
    let Workflow = Namespaced_IRI.parse _namespace_name "Workflow" |> NamespacedName

    /// <summary>
    /// An unpublished paper, usually circulated privately among a small group of peers, to provide information or with a request for comments or editorial improvement.
    /// <see href="http://purl.org/spar/fabio/WorkingPaper"></see></summary>
    let WorkingPaper =
        Namespaced_IRI.parse _namespace_name "WorkingPaper" |> NamespacedName

    /// <summary>
    /// A paper, typically the realization of a research paper reporting original research findings, usually presented at a workshop and published within a workshop proceedings volume.
    /// <see href="http://purl.org/spar/fabio/WorkshopPaper"></see></summary>
    let WorkshopPaper =
        Namespaced_IRI.parse _namespace_name "WorkshopPaper" |> NamespacedName

    /// <summary>
    /// A document containing the programme and collected workshop papers, or their abstracts, presented at a workshop or similar event.
    /// <see href="http://purl.org/spar/fabio/WorkshopProceedings"></see></summary>
    let WorkshopProceedings =
        Namespaced_IRI.parse _namespace_name "WorkshopProceedings" |> NamespacedName

    /// <summary>
    /// An analog medium for magnetic recording of audio and video information, made of a thin magnetizable coating on a long, narrow plastic tape, typically wound on a spool.
    /// <see href="http://purl.org/spar/fabio/analog-magnetic-tape"></see></summary>
    let ``analog-magnetic-tape`` =
        Namespaced_IRI.parse _namespace_name "analog-magnetic-tape" |> NamespacedName

    /// <summary>
    /// A non-rewritable optical disc used to store digital data.
    /// <see href="http://purl.org/spar/fabio/cd"></see></summary>
    let cd = Namespaced_IRI.parse _namespace_name "cd" |> NamespacedName
    /// <summary>
    /// A distributed and commoditized Internet-based computing resource, whereby shared services, software programs, and information storage facilities are provided to computers and other devices on demand, at locations of which the user may be unaware, like the electricity grid.
    /// <see href="http://purl.org/spar/fabio/cloud"></see></summary>
    let cloud = Namespaced_IRI.parse _namespace_name "cloud" |> NamespacedName

    /// <summary>
    /// The date on which a particular endeavour, such as an ontology, was last updated.
    /// <see href="http://purl.org/spar/fabio/dateLastUpdated"></see></summary>
    let dateLastUpdated =
        Namespaced_IRI.parse _namespace_name "dateLastUpdated" |> NamespacedName

    /// <summary>
    /// A rewritable digital medium for magnetic recording of audio, video and other data, made of a thin magnetizable coating on a long, narrow strip of plastic, usually wound on a spool.
    /// <see href="http://purl.org/spar/fabio/digital-magnetic-tape"></see></summary>
    let ``digital-magnetic-tape`` =
        Namespaced_IRI.parse _namespace_name "digital-magnetic-tape" |> NamespacedName

    /// <summary>
    /// A non-rewritable optical disc storage medium resembling a compact disc (CD), usually used for video and data storage. A DVD has the same physical dimensions as a CD, but is capable of storing more than six times as much data.
    /// <see href="http://purl.org/spar/fabio/dvd"></see></summary>
    let dvd = Namespaced_IRI.parse _namespace_name "dvd" |> NamespacedName
    /// <summary>
    /// A thin flexible strip of plastic or other material coated with light-sensitive emulsion upon which images can be recorded, typically using a camera, usually used to record photographic images or motion pictures.
    /// <see href="http://purl.org/spar/fabio/film"></see></summary>
    let film = Namespaced_IRI.parse _namespace_name "film" |> NamespacedName

    /// <summary>
    /// A rewritable data storage medium that is composed of a disk of thin, flexible (floppy) magnetic storage medium encased in a square or rectangular  plastic shell.  Data are encoded magnetically by a read/write head that float on a cushion of air in close proximity to the surface of the rotated disk.
    /// <see href="http://purl.org/spar/fabio/floppy-disk"></see></summary>
    let ``floppy-disk`` =
        Namespaced_IRI.parse _namespace_name "floppy-disk" |> NamespacedName

    /// <summary>
    /// A non-volatile storage device for digital data, composed of one or more rigid discs (platters) mounted side by side on a motor-driven spindle within a metal case. Data are encoded magnetically by read/write heads that float on cushions of air in close proximity to the surfaces of the rotated platters.
    /// <see href="http://purl.org/spar/fabio/hard-drive"></see></summary>
    let ``hard-drive`` =
        Namespaced_IRI.parse _namespace_name "hard-drive" |> NamespacedName

    /// <summary>
    /// The date on which a particular digital item, such as a PDF or an HTML file, has been accessed by somebody.
    /// <see href="http://purl.org/spar/fabio/hasAccessDate"></see></summary>
    let hasAccessDate =
        Namespaced_IRI.parse _namespace_name "hasAccessDate" |> NamespacedName

    /// <summary>
    /// An identifier used by the preprint repository ArXiv.
    /// <see href="http://purl.org/spar/fabio/hasArXivId"></see></summary>
    let hasArXivId = Namespaced_IRI.parse _namespace_name "hasArXivId" |> NamespacedName
    /// <summary>
    /// A CODEN is a six character, alphanumeric bibliographic identification code, that provides concise, unique and unambiguous identification of the titles of serials and non-serial publications.
    /// <see href="http://purl.org/spar/fabio/hasCODEN"></see></summary>
    let hasCODEN = Namespaced_IRI.parse _namespace_name "hasCODEN" |> NamespacedName

    /// <summary>
    /// The count of the number of characters in a textual resource.
    /// <see href="http://purl.org/spar/fabio/hasCharacterCount"></see></summary>
    let hasCharacterCount =
        Namespaced_IRI.parse _namespace_name "hasCharacterCount" |> NamespacedName

    /// <summary>
    /// The year in which an entity has been copyrighted.
    /// <see href="http://purl.org/spar/fabio/hasCopyrightYear"></see></summary>
    let hasCopyrightYear =
        Namespaced_IRI.parse _namespace_name "hasCopyrightYear" |> NamespacedName

    /// <summary>
    /// The date on which something, for example a document, is corrected.
    /// <see href="http://purl.org/spar/fabio/hasCorrectionDate"></see></summary>
    let hasCorrectionDate =
        Namespaced_IRI.parse _namespace_name "hasCorrectionDate" |> NamespacedName

    /// <summary>
    /// The date on which some item has been collected, for example the data gathered by means of questionnaires.
    /// <see href="http://purl.org/spar/fabio/hasDateCollected"></see></summary>
    let hasDateCollected =
        Namespaced_IRI.parse _namespace_name "hasDateCollected" |> NamespacedName

    /// <summary>
    /// The date on which some item is received, for example a document being received by a publisher.
    /// <see href="http://purl.org/spar/fabio/hasDateReceived"></see></summary>
    let hasDateReceived =
        Namespaced_IRI.parse _namespace_name "hasDateReceived" |> NamespacedName

    /// <summary>
    /// A date by which something has to be done.
    /// <see href="http://purl.org/spar/fabio/hasDeadline"></see></summary>
    let hasDeadline =
        Namespaced_IRI.parse _namespace_name "hasDeadline" |> NamespacedName

    /// <summary>
    /// The date on which a particular endeavour, such as a grant application, has been or will be approved or rejected by somebody.
    /// <see href="http://purl.org/spar/fabio/hasDecisionDate"></see></summary>
    let hasDecisionDate =
        Namespaced_IRI.parse _namespace_name "hasDecisionDate" |> NamespacedName

    /// <summary>
    /// The date on which an entity has been deposited, for example in a library, repository, supplementary information archive, database or similar place of document or information storage.
    /// <see href="http://purl.org/spar/fabio/hasDepositDate"></see></summary>
    let hasDepositDate =
        Namespaced_IRI.parse _namespace_name "hasDepositDate" |> NamespacedName

    /// <summary>
    /// The discipline to which a subject vocabulary belongs.
    /// <see href="http://purl.org/spar/fabio/hasDiscipline"></see></summary>
    let hasDiscipline =
        Namespaced_IRI.parse _namespace_name "hasDiscipline" |> NamespacedName

    /// <summary>
    /// This property relates a subject vocabulary to the discipline to which it belongs.
    /// <see href="http://purl.org/spar/fabio/isDisciplineOf"></see></summary>
    let isDisciplineOf =
        Namespaced_IRI.parse _namespace_name "isDisciplineOf" |> NamespacedName

    /// <summary>
    /// The date on which something is distributed, for example the date on which a preprint of a document is e-mailed to colleagues and other academics by the author(s), or the date on which a printed announcement of forthcoming theatre events is mailed to those those on the theatre's mailing list.
    /// <see href="http://purl.org/spar/fabio/hasDistributionDate"></see></summary>
    let hasDistributionDate =
        Namespaced_IRI.parse _namespace_name "hasDistributionDate" |> NamespacedName

    /// <summary>
    /// A local identifier for an article within an electronic (i.e. on line, in HTML format) periodical issue.  Use in preference to prism:startingPage when the article lacks page numbers
    /// <see href="http://purl.org/spar/fabio/hasElectronicArticleIdentifier"></see></summary>
    let hasElectronicArticleIdentifier =
        Namespaced_IRI.parse _namespace_name "hasElectronicArticleIdentifier" |> NamespacedName

    /// <summary>
    /// The date before which an entity should not be published, or before which a press release should not be reported on.  For open-access journal articles, the embargo date is the date before which availability of the open-access version of the article is restricted by the publisher, following subscription-access availability of the published work.  The duration of the embargo period can be specified by fabio:hasEmbargoDuration.
    /// <see href="http://purl.org/spar/fabio/hasEmbargoDate"></see></summary>
    let hasEmbargoDate =
        Namespaced_IRI.parse _namespace_name "hasEmbargoDate" |> NamespacedName

    /// <summary>
    /// The time period for which an entity is embargoed.  During this period, the entity should not be published or, in the case of a press release, should not be reported on.  For open-access journal articles, the embargo duration specifies that period of time during which availability of the open-access version of the article is delayed by the publisher, following subscription-access availability of the published work.  The end of the embargo period can be specified by fabio:hasEmbargoDate.
    /// <see href="http://purl.org/spar/fabio/hasEmbargoDuration"></see></summary>
    let hasEmbargoDuration =
        Namespaced_IRI.parse _namespace_name "hasEmbargoDuration" |> NamespacedName

    /// <summary>
    /// A persistent identifier of the Handel system for digital objects and other resources on the Internet.
    /// <see href="http://purl.org/spar/fabio/hasHandle"></see></summary>
    let hasHandle = Namespaced_IRI.parse _namespace_name "hasHandle" |> NamespacedName
    /// <summary>
    /// A linking International Standard Serial Number.
    /// <see href="http://purl.org/spar/fabio/hasIssnL"></see></summary>
    let hasIssnL = Namespaced_IRI.parse _namespace_name "hasIssnL" |> NamespacedName

    /// <summary>
    /// A property linking a particular work to its manifestations.  This property is additional to the relationships between FRBR endeavours present in the classical FRBR data model.
    /// <see href="http://purl.org/spar/fabio/hasManifestation"></see></summary>
    let hasManifestation =
        Namespaced_IRI.parse _namespace_name "hasManifestation" |> NamespacedName

    /// <summary>
    /// A property linking a particular manifestation to the work it is manifesting.  This property is additional to the relationships between FRBR endeavours present in the classical FRBR data model.
    /// <see href="http://purl.org/spar/fabio/isManifestationOf"></see></summary>
    let isManifestationOf =
        Namespaced_IRI.parse _namespace_name "isManifestationOf" |> NamespacedName

    /// <summary>
    /// An internal identifier for the abbreviation of the title of journals available from the National Library of Medicine repository.
    /// <see href="http://purl.org/spar/fabio/hasNLMJournalTitleAbbreviation"></see></summary>
    let hasNLMJournalTitleAbbreviation =
        Namespaced_IRI.parse _namespace_name "hasNLMJournalTitleAbbreviation" |> NamespacedName

    /// <summary>
    /// A short version of the title of an entity, typically used to label or refer to a particular entity in an abbreviated form, for example an abbreviated journal title in a reference, or a short title of a document used as the running title in a page header.
    /// <see href="http://purl.org/spar/fabio/hasShortTitle"></see></summary>
    let hasShortTitle =
        Namespaced_IRI.parse _namespace_name "hasShortTitle" |> NamespacedName

    /// <summary>
    /// An internal identifier for journals available from the National Library of Medicine repository.
    /// <see href="http://purl.org/spar/fabio/hasNationalLibraryOfMedicineJournalId"></see></summary>
    let hasNationalLibraryOfMedicineJournalId =
        Namespaced_IRI.parse _namespace_name "hasNationalLibraryOfMedicineJournalId" |> NamespacedName

    /// <summary>
    /// Has Publisher Item Identifier
    /// <see href="http://purl.org/spar/fabio/hasPII"></see></summary>
    let hasPII = Namespaced_IRI.parse _namespace_name "hasPII" |> NamespacedName

    /// <summary>
    /// The count of the number of pages in a textual resource.
    /// <see href="http://purl.org/spar/fabio/hasPageCount"></see></summary>
    let hasPageCount =
        Namespaced_IRI.parse _namespace_name "hasPageCount" |> NamespacedName

    /// <summary>
    /// A unique identifing number issued by a patent authority to identify a patent, displayed at the beginning of the patent document.
    /// <see href="http://purl.org/spar/fabio/hasPatentNumber"></see></summary>
    let hasPatentNumber =
        Namespaced_IRI.parse _namespace_name "hasPatentNumber" |> NamespacedName

    /// <summary>
    /// The place (usually, the city) where the publisher of a particular bibliographic resource is located.
    /// <see href="http://purl.org/spar/fabio/hasPlaceOfPublication"></see></summary>
    let hasPlaceOfPublication =
        Namespaced_IRI.parse _namespace_name "hasPlaceOfPublication" |> NamespacedName

    /// <summary>
    /// A property linking a particular work to its items.  This property is additional to the relationships between FRBR endeavours present in the classical FRBR data model.
    /// <see href="http://purl.org/spar/fabio/hasPortrayal"></see></summary>
    let hasPortrayal =
        Namespaced_IRI.parse _namespace_name "hasPortrayal" |> NamespacedName

    /// <summary>
    /// A property linking a particular item to the work it portrays.  This property is additional to the relationships between FRBR endeavours present in the classical FRBR data model.
    /// <see href="http://purl.org/spar/fabio/isPortrayalOf"></see></summary>
    let isPortrayalOf =
        Namespaced_IRI.parse _namespace_name "isPortrayalOf" |> NamespacedName

    /// <summary>
    /// This property is used to associate a frbr:Endeavour to a term in a particular classification system - and the term is considered one of the main topics for the endeavour in consideration.
    /// <see href="http://purl.org/spar/fabio/hasPrimarySubjectTerm"></see></summary>
    let hasPrimarySubjectTerm =
        Namespaced_IRI.parse _namespace_name "hasPrimarySubjectTerm" |> NamespacedName

    /// <summary>
    /// This property is used to associate a frbr:Endeavour to a term in a particular classification system.
    /// <see href="http://purl.org/spar/fabio/hasSubjectTerm"></see></summary>
    let hasSubjectTerm =
        Namespaced_IRI.parse _namespace_name "hasSubjectTerm" |> NamespacedName

    /// <summary>
    /// An identifier for bibliographic entities hosted by the PubMed Central repository.
    /// <see href="http://purl.org/spar/fabio/hasPubMedCentralId"></see></summary>
    let hasPubMedCentralId =
        Namespaced_IRI.parse _namespace_name "hasPubMedCentralId" |> NamespacedName

    /// <summary>
    /// An identifier for bibliographic records held by the PubMed repository.
    /// <see href="http://purl.org/spar/fabio/hasPubMedId"></see></summary>
    let hasPubMedId =
        Namespaced_IRI.parse _namespace_name "hasPubMedId" |> NamespacedName

    /// <summary>
    /// The year in which a resource is published.
    /// <see href="http://purl.org/spar/fabio/hasPublicationYear"></see></summary>
    let hasPublicationYear =
        Namespaced_IRI.parse _namespace_name "hasPublicationYear" |> NamespacedName

    /// <summary>
    /// A property linking a particular expression to its items.  This property is additional to the relationships between FRBR endeavours present in the classical FRBR data model.
    /// <see href="http://purl.org/spar/fabio/hasRepresentation"></see></summary>
    let hasRepresentation =
        Namespaced_IRI.parse _namespace_name "hasRepresentation" |> NamespacedName

    /// <summary>
    /// A property linking a particular item to the expression it represents.  This property is additional to the relationships between FRBR endeavours present in the classical FRBR data model.
    /// <see href="http://purl.org/spar/fabio/isRepresentationOf"></see></summary>
    let isRepresentationOf =
        Namespaced_IRI.parse _namespace_name "isRepresentationOf" |> NamespacedName

    /// <summary>
    /// The date on which an agent is requested to do something, for example a reviewer is requested to write a review of a paper submitted to a journal for publication, or an author is requested to supply a revised version of the paper in response to the reviews received.
    /// <see href="http://purl.org/spar/fabio/hasRequestDate"></see></summary>
    let hasRequestDate =
        Namespaced_IRI.parse _namespace_name "hasRequestDate" |> NamespacedName

    /// <summary>
    /// The date on which something, for example a claim or a journal article, is retracted.
    /// <see href="http://purl.org/spar/fabio/hasRetractionDate"></see></summary>
    let hasRetractionDate =
        Namespaced_IRI.parse _namespace_name "hasRetractionDate" |> NamespacedName

    /// <summary>
    /// The Serial Item and Contribution Identifier is a code used to uniquely identify specific volumes, articles or other identifiable parts of a periodical. It is intended primarily for use by those members of the bibliographic community involved in the use or management of serial titles and their contributions.
    /// <see href="http://purl.org/spar/fabio/hasSICI"></see></summary>
    let hasSICI = Namespaced_IRI.parse _namespace_name "hasSICI" |> NamespacedName
    /// <summary>
    /// Permits specification of the season of the year, for example spring, summer, autumn and winter in British English.
    /// <see href="http://purl.org/spar/fabio/hasSeason"></see></summary>
    let hasSeason = Namespaced_IRI.parse _namespace_name "hasSeason" |> NamespacedName

    /// <summary>
    /// A literal (for example a number or a letter) that identifies the sequence position of a work within a particular context, for example a book in a book series, a chapter in a document, a volume in a journal.
    /// <see href="http://purl.org/spar/fabio/hasSequenceIdentifier"></see></summary>
    let hasSequenceIdentifier =
        Namespaced_IRI.parse _namespace_name "hasSequenceIdentifier" |> NamespacedName

    /// <summary>
    /// The number defining an international standard, for example Z39.96 - 201x, identifying NISO JATS, the Journal Article Tag Suite.
    /// <see href="http://purl.org/spar/fabio/hasStandardNumber"></see></summary>
    let hasStandardNumber =
        Namespaced_IRI.parse _namespace_name "hasStandardNumber" |> NamespacedName

    /// <summary>
    /// A secondary title that follows the main title of a work.
    /// <see href="http://purl.org/spar/fabio/hasSubtitle"></see></summary>
    let hasSubtitle =
        Namespaced_IRI.parse _namespace_name "hasSubtitle" |> NamespacedName

    /// <summary>
    /// A version of the subtitle of an entity translated into another language, which may be specified using the object property dcterms:language.
    /// <see href="http://purl.org/spar/fabio/hasTranslatedSubtitle"></see></summary>
    let hasTranslatedSubtitle =
        Namespaced_IRI.parse _namespace_name "hasTranslatedSubtitle" |> NamespacedName

    /// <summary>
    /// A version of the title of an entity translated into another language, which may be specified using the object property dcterms:language.
    /// <see href="http://purl.org/spar/fabio/hasTranslatedTitle"></see></summary>
    let hasTranslatedTitle =
        Namespaced_IRI.parse _namespace_name "hasTranslatedTitle" |> NamespacedName

    /// <summary>
    /// An identifier, in form of an HTTP Universal Resource Locator (URL), for a particular resource on the World Wide Web.
    /// <see href="http://purl.org/spar/fabio/hasURL"></see></summary>
    let hasURL = Namespaced_IRI.parse _namespace_name "hasURL" |> NamespacedName

    /// <summary>
    /// The count of the number of volumes a work includes.
    /// <see href="http://purl.org/spar/fabio/hasVolumeCount"></see></summary>
    let hasVolumeCount =
        Namespaced_IRI.parse _namespace_name "hasVolumeCount" |> NamespacedName

    /// <summary>
    /// A global system of interconnected computer networks that uses the standard Internet Protocol Suite (TCP/IP) to serve billions of users worldwide.  The internet connects millions of private, public, academic, business and governmental computers, that are individually attached to local networks linked together by a broad array of electronic, radio and optical networking technologies to form the internet.
    /// <see href="http://purl.org/spar/fabio/internet"></see></summary>
    let internet = Namespaced_IRI.parse _namespace_name "internet" |> NamespacedName
    /// <summary>
    /// A private computer network, unconnected to the internet or separated from it by a firewall,  that uses a network operating system and Internet Protocol technologies to permit an organization's information to be shared securely within that organization.
    /// <see href="http://purl.org/spar/fabio/intranet"></see></summary>
    let intranet = Namespaced_IRI.parse _namespace_name "intranet" |> NamespacedName
    /// <summary>
    /// A thin flat material, typically made from wood pulp, mainly used for writing upon, for printing upon or for packaging.
    /// <see href="http://purl.org/spar/fabio/paper"></see></summary>
    let paper = Namespaced_IRI.parse _namespace_name "paper" |> NamespacedName
    /// <summary>
    /// Abbreviation of Random Access Memory.  A form of rewritable computer data storage that takes the form of integrated circuits that allow data to be stored and accessed in any order (i.e. at random), thereby achieving greater speed than for access of data stored in linear form on digital magnetic tape.
    /// <see href="http://purl.org/spar/fabio/ram"></see></summary>
    let ram = Namespaced_IRI.parse _namespace_name "ram" |> NamespacedName

    /// <summary>
    /// A digital storage device built entirely from solid electronic materials with no moving parts, e.g. a USB flash drive.
    /// <see href="http://purl.org/spar/fabio/solid-state-memory"></see></summary>
    let ``solid-state-memory`` =
        Namespaced_IRI.parse _namespace_name "solid-state-memory" |> NamespacedName

    /// <summary>
    /// A property that identifies the calendar system used to specify a date, for example the Chinese, Gregorian, Hebrew, Islamic or Lunar calendar.
    /// <see href="http://purl.org/spar/fabio/usesCalendar"></see></summary>
    let usesCalendar =
        Namespaced_IRI.parse _namespace_name "usesCalendar" |> NamespacedName

    /// <summary>
    /// An analog sound storage medium consisting of a flat disc made of moulded vinyl plastic with an inscribed, modulated spiral groove.
    /// <see href="http://purl.org/spar/fabio/vinyl-disk"></see></summary>
    let ``vinyl-disk`` =
        Namespaced_IRI.parse _namespace_name "vinyl-disk" |> NamespacedName

    /// <summary>
    /// A system of interlinked hypertext documents written in HTML and accessed using the HTTP protocol via the Internet.
    /// <see href="http://purl.org/spar/fabio/web"></see></summary>
    let web = Namespaced_IRI.parse _namespace_name "web" |> NamespacedName
