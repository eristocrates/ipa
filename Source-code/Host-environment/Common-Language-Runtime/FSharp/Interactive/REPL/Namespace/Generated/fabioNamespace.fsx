#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module fabio =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/spar/fabio/" "fabio"
    let _2018_05_02 = _prefixId.prefix "2018-05-02"
    let _2019_02_19 = _prefixId.prefix "2019-02-19"
    /// <summary>
    ///   <para>rdfs:label : abstract</para>
    ///   <para>rdfs:comment : A brief summary of a work on a particular subject, designed to act as the point-of-entry that will help the reader quickly to obtain an overview of the work's contents.   The abstract may be an integral part of the work itself, written by the same author(s) and appearing at the beginning of a work such as a research paper, report, review or thesis.  Alternatively it may be separate from the published work itself, and written by someone other than the author(s) of the published work, for example by a member of a professional abstracting service such as CAB Abstracts.</para>
    ///   <a href="http://purl.org/spar/fabio/Abstract">fabio:Abstract</a>
    /// </summary>
    let Abstract = _prefixId.prefix "Abstract"
    /// <summary>
    ///   <para>rdfs:label : academic proceedings</para>
    ///   <para>rdfs:comment : A document containing the programme and collected papers, or their abstracts, presented at an academic meeting.</para>
    ///   <a href="http://purl.org/spar/fabio/AcademicProceedings">fabio:AcademicProceedings</a>
    /// </summary>
    let AcademicProceedings = _prefixId.prefix "AcademicProceedings"
    /// <summary>
    ///   <para>rdfs:label : addendum</para>
    ///   <para>rdfs:comment : An item of material added at the end of a book or other publication, typically to include omitted or late-arriving material. </para>
    ///   <a href="http://purl.org/spar/fabio/Addendum">fabio:Addendum</a>
    /// </summary>
    let Addendum = _prefixId.prefix "Addendum"
    /// <summary>
    ///   <para>rdfs:comment : A precise sequential set of pre-defined logical rules or computational operations to be employed for solving a particular problem in a finite number of steps.^^xsd:string</para>
    ///   <para>rdfs:label : algorithm</para>
    ///   <a href="http://purl.org/spar/fabio/Algorithm">fabio:Algorithm</a>
    /// </summary>
    let Algorithm = _prefixId.prefix "Algorithm"
    /// <summary>
    ///   <para>rdfs:label : analog item</para>
    ///   <para>rdfs:comment : A real object that is an exemplar of a fabio:Manifestation, such as a particular copy of the book 'Alice's adventures in Wonderland', that a person may own.</para>
    ///   <para>dce:description : An analog item is an exemplar of an analog manifestation only and it is always stored in a storage medium suitable for analog objects, such as paper, vinyl discs and films.</para>
    ///   <a href="http://purl.org/spar/fabio/AnalogItem">fabio:AnalogItem</a>
    /// </summary>
    let AnalogItem = _prefixId.prefix "AnalogItem"
    /// <summary>
    ///   <para>rdfs:comment : A manifestation in an analog form.</para>
    ///   <para>rdfs:label : analog manifestation</para>
    ///   <a href="http://purl.org/spar/fabio/AnalogManifestation">fabio:AnalogManifestation</a>
    /// </summary>
    let AnalogManifestation = _prefixId.prefix "AnalogManifestation"
    /// <summary>
    ///   <para>rdfs:label : analog storage medium</para>
    ///   <para>rdfs:comment : A means of storing information in non-digital form, e.g. paper, film (for analogue photographs or movies), magnetic tape (for analogue sound recordings or video recordings) or vinyl disc.</para>
    ///   <a href="http://purl.org/spar/fabio/AnalogStorageMedium">fabio:AnalogStorageMedium</a>
    /// </summary>
    let AnalogStorageMedium = _prefixId.prefix "AnalogStorageMedium"
    /// <summary>
    ///   <para>rdfs:label : announcement</para>
    ///   <para>rdfs:comment : A formal statement about something.</para>
    ///   <a href="http://purl.org/spar/fabio/Announcement">fabio:Announcement</a>
    /// </summary>
    let Announcement = _prefixId.prefix "Announcement"
    /// <summary>
    ///   <para>rdfs:label : anthology</para>
    ///   <para>rdfs:comment : A collection of selected literary or scholastics works, for example poems, short stories, plays or research papers.</para>
    ///   <a href="http://purl.org/spar/fabio/Anthology">fabio:Anthology</a>
    /// </summary>
    let Anthology = _prefixId.prefix "Anthology"
    /// <summary>
    ///   <para>rdfs:label : application profile</para>
    ///   <para>rdfs:comment : A set of metadata elements, policies and guidelines defined for a particular application.  The metadata elements used in the application profile may be drawn from more than one element sets, including locally defined sets. </para>
    ///   <a href="http://purl.org/spar/fabio/ApplicationProfile">fabio:ApplicationProfile</a>
    /// </summary>
    let ApplicationProfile = _prefixId.prefix "ApplicationProfile"

    /// <summary>
    ///   <para>rdfs:label : application programming interfacerdfs:label : API</para>
    ///   <para>rdfs:comment :  A computer program that enables a separate computer to interact programmatically with the computer running the API.  (Commonly abbreviated 'API'.)</para>
    ///   <a href="http://purl.org/spar/fabio/ApplicationProgrammingInterface">fabio:ApplicationProgrammingInterface</a>
    /// </summary>
    let ApplicationProgrammingInterface =
        _prefixId.prefix "ApplicationProgrammingInterface"

    /// <summary>
    ///   <para>rdfs:label : archival document</para>
    ///   <para>rdfs:comment : An archival document is a realization of the content related to an archival record. It can be exemplified as a book, a document, a letter, a database, etc.</para>
    ///   <a href="http://purl.org/spar/fabio/ArchivalDocument">fabio:ArchivalDocument</a>
    /// </summary>
    let ArchivalDocument = _prefixId.prefix "ArchivalDocument"
    /// <summary>
    ///   <para>rdfs:label : archival document set</para>
    ///   <para>rdfs:comment : A collection of archival document.</para>
    ///   <a href="http://purl.org/spar/fabio/ArchivalDocumentSet">fabio:ArchivalDocumentSet</a>
    /// </summary>
    let ArchivalDocumentSet = _prefixId.prefix "ArchivalDocumentSet"
    /// <summary>
    ///   <para>rdfs:label : archival record</para>
    ///   <para>rdfs:comment : An archival record connotes a material created or received by a person, family, or organization, public or private, in the conduct of their affairs that is preserved because of the enduring value contained in the information it contains or as evidence of the function and the responsibilities of its creator.</para>
    ///   <a href="http://purl.org/spar/fabio/ArchivalRecord">fabio:ArchivalRecord</a>
    /// </summary>
    let ArchivalRecord = _prefixId.prefix "ArchivalRecord"
    /// <summary>
    ///   <para>rdfs:label : archival record set</para>
    ///   <para>rdfs:comment : A collection of archival records.</para>
    ///   <a href="http://purl.org/spar/fabio/ArchivalRecordSet">fabio:ArchivalRecordSet</a>
    /// </summary>
    let ArchivalRecordSet = _prefixId.prefix "ArchivalRecordSet"
    /// <summary>
    ///   <para>rdfs:label : article</para>
    ///   <para>rdfs:comment : The realization of a piece of writing on a particular topic, usually published within a periodical publication (e.g. journal, magazine and newspaper).</para>
    ///   <a href="http://purl.org/spar/fabio/Article">fabio:Article</a>
    /// </summary>
    let Article = _prefixId.prefix "Article"
    /// <summary>
    ///   <para>rdfs:label : artistic work</para>
    ///   <para>rdfs:comment : It describes any work regarded as art in its widest sense, including works from literature and music, visual art, etc.</para>
    ///   <a href="http://purl.org/spar/fabio/ArtisticWork">fabio:ArtisticWork</a>
    /// </summary>
    let ArtisticWork = _prefixId.prefix "ArtisticWork"
    /// <summary>
    ///   <para>rdfs:comment : The realization of a sound recording.</para>
    ///   <para>rdfs:label : audio document</para>
    ///   <a href="http://purl.org/spar/fabio/AudioDocument">fabio:AudioDocument</a>
    /// </summary>
    let AudioDocument = _prefixId.prefix "AudioDocument"
    /// <summary>
    ///   <para>rdfs:comment : A controlled vocabulary or official list that establishes, for consistency, the authoritative forms of headings, and the preferred terms or proper names to be used, when creating a catalogue or when indexing and searching a set of entities within a defined domain.</para>
    ///   <para>rdfs:label : authority file</para>
    ///   <a href="http://purl.org/spar/fabio/AuthorityFile">fabio:AuthorityFile</a>
    /// </summary>
    let AuthorityFile = _prefixId.prefix "AuthorityFile"
    /// <summary>
    ///   <para>rdfs:label : bachelor's thesis</para>
    ///   <para>rdfs:comment : A thesis reporting a research project undertaken as part of an undergraduate course of education leading to a bachelor's degree.</para>
    ///   <a href="http://purl.org/spar/fabio/BachelorsThesis">fabio:BachelorsThesis</a>
    /// </summary>
    let BachelorsThesis = _prefixId.prefix "BachelorsThesis"
    /// <summary>
    ///   <para>rdfs:label : bibliographic database</para>
    ///   <para>rdfs:comment : A database providing an authoritative source of bibliographic information, for example PubMed (http://www.ncbi.nlm.nih.gov/pubmed), CrossRef Metadata Search (http://search.crossref.org/) and PubMed Central (http://www.ncbi.nlm.nih.gov/pmc/).</para>
    ///   <a href="http://purl.org/spar/fabio/BibliographicDatabase">fabio:BibliographicDatabase</a>
    /// </summary>
    let BibliographicDatabase = _prefixId.prefix "BibliographicDatabase"
    /// <summary>
    ///   <para>rdfs:comment : Standard bibliographic metadata describing an expression of a work.  To take the example of a journal article, bibliographic metadata typically include the authors' names, the date of publication, the title of the article, the journal name and volume number, the first and last page numbers, and the Digital Object Identifier (DOI).</para>
    ///   <para>rdfs:label : bibliographic metadata</para>
    ///   <a href="http://purl.org/spar/fabio/BibliographicMetadata">fabio:BibliographicMetadata</a>
    /// </summary>
    let BibliographicMetadata = _prefixId.prefix "BibliographicMetadata"
    /// <summary>
    ///   <para>rdfs:label : biography</para>
    ///   <para>rdfs:comment : An account of the events, works and achievements, both personal and professional, of a person, either living or dead.</para>
    ///   <a href="http://purl.org/spar/fabio/Biography">fabio:Biography</a>
    /// </summary>
    let Biography = _prefixId.prefix "Biography"
    /// <summary>
    ///   <para>rdfs:label : blog</para>
    ///   <para>rdfs:comment : A Web publication medium containing blog posts.</para>
    ///   <a href="http://purl.org/spar/fabio/Blog">fabio:Blog</a>
    /// </summary>
    let Blog = _prefixId.prefix "Blog"
    /// <summary>
    ///   <para>rdfs:label : blog post</para>
    ///   <para>rdfs:comment : Information manifested in a blog, one of a set of periodic sequential entries containing commentary, descriptions of events, or other material such as images or videos, usually displayed in reverse-chronological order and usually maintained by an individual, or comments on such a post.</para>
    ///   <a href="http://purl.org/spar/fabio/BlogPost">fabio:BlogPost</a>
    /// </summary>
    let BlogPost = _prefixId.prefix "BlogPost"
    /// <summary>
    ///   <para>rdfs:label : book</para>
    ///   <para>rdfs:comment : A non-serial document that is complete in one volume or a designated finite number of volumes.  A book published by a publisher is usually  identified by an International Standard Book Number (ISBN), and may be manifested as a physical printed publication on paper bound in a hard or soft cover, or in electronic format as an 'e-book'.</para>
    ///   <a href="http://purl.org/spar/fabio/Book">fabio:Book</a>
    /// </summary>
    let Book = _prefixId.prefix "Book"
    /// <summary>
    ///   <para>rdfs:comment : A defined chapter of a book, usually with a separate title or number.</para>
    ///   <para>rdfs:label : book chapter</para>
    ///   <a href="http://purl.org/spar/fabio/BookChapter">fabio:BookChapter</a>
    /// </summary>
    let BookChapter = _prefixId.prefix "BookChapter"
    /// <summary>
    ///   <para>rdfs:comment : A written review and critical analysis of the content, scope and quality of a book or other monographic work.</para>
    ///   <para>rdfs:label : book review</para>
    ///   <a href="http://purl.org/spar/fabio/BookReview">fabio:BookReview</a>
    /// </summary>
    let BookReview = _prefixId.prefix "BookReview"
    /// <summary>
    ///   <para>rdfs:label : book series</para>
    ///   <para>rdfs:comment : A sequence of books having certain characteristics in common that are formally identified together as a group - for instance, the books in the Law, Governance and Technology Series published by Springer.</para>
    ///   <a href="http://purl.org/spar/fabio/BookSeries">fabio:BookSeries</a>
    /// </summary>
    let BookSeries = _prefixId.prefix "BookSeries"
    /// <summary>
    ///   <para>rdfs:comment : A set of books having certain characteristics in common that informally allow their identification together as a group - for instance, the books of the Harry Potter saga.</para>
    ///   <para>rdfs:label : book set</para>
    ///   <a href="http://purl.org/spar/fabio/BookSet">fabio:BookSet</a>
    /// </summary>
    let BookSet = _prefixId.prefix "BookSet"
    /// <summary>
    ///   <para>rdfs:label : brief report</para>
    ///   <para>rdfs:comment : A brief report document.  This term may also be used synonymously with Rapid Communication to mean 'A short rapidly published research article or conference paper, typically reporting significant research results that have been recently discovered, or a brief news item reporting such discoveries.'</para>
    ///   <a href="http://purl.org/spar/fabio/BriefReport">fabio:BriefReport</a>
    /// </summary>
    let BriefReport = _prefixId.prefix "BriefReport"
    /// <summary>
    ///   <para>rdfs:comment : A document published by a funding agency requesting submission of applications for financial grants to fund projects, for example to enable research investigations in areas specified in the Call.</para>
    ///   <para>rdfs:label : call for applications^^xsd:string</para>
    ///   <a href="http://purl.org/spar/fabio/CallForApplications">fabio:CallForApplications</a>
    /// </summary>
    let CallForApplications = _prefixId.prefix "CallForApplications"
    /// <summary>
    ///   <para>rdfs:label : case for support</para>
    ///   <para>rdfs:comment : A part of a grant application that provides a description of a proposed project and gives reasons why it is worthy of funding. (See also fabio:GrantApplication).</para>
    ///   <a href="http://purl.org/spar/fabio/CaseForSupport">fabio:CaseForSupport</a>
    /// </summary>
    let CaseForSupport = _prefixId.prefix "CaseForSupport"
    /// <summary>
    ///   <para>rdfs:comment : A document containing the case for support for a particular project, usually contained within a grant application document but sometimes distributed separately, without the financial and organizational information that the grant application document also contains.</para>
    ///   <para>rdfs:label : case for support document</para>
    ///   <a href="http://purl.org/spar/fabio/CaseForSupportDocument">fabio:CaseForSupportDocument</a>
    /// </summary>
    let CaseForSupportDocument = _prefixId.prefix "CaseForSupportDocument"
    /// <summary>
    ///   <para>rdfs:label : case report</para>
    ///   <para>rdfs:comment : A report about a particular case or situation.</para>
    ///   <a href="http://purl.org/spar/fabio/CaseReport">fabio:CaseReport</a>
    /// </summary>
    let CaseReport = _prefixId.prefix "CaseReport"
    /// <summary>
    ///   <para>rdfs:comment : A list of items describing the content of a resource, for example items in an exhibition, items offered for sale by a vendor, or entities contained within a library or collection.  Ideally, catalogs are created according to specific and uniform principles of construction and are under the control of an authority file.</para>
    ///   <para>rdfs:label : catalog</para>
    ///   <a href="http://purl.org/spar/fabio/Catalog">fabio:Catalog</a>
    /// </summary>
    let Catalog = _prefixId.prefix "Catalog"
    /// <summary>
    ///   <para>rdfs:label : chapter</para>
    ///   <para>rdfs:comment : A defined document section, forming part of or intended for inclusion within a larger document, usually with its own title or chapter number.  Different chapters within a document such as a book or a report may each be independently authored, or may all be authored by a single individual or group of authors.</para>
    ///   <a href="http://purl.org/spar/fabio/Chapter">fabio:Chapter</a>
    /// </summary>
    let Chapter = _prefixId.prefix "Chapter"
    /// <summary>
    ///   <para>rdfs:label : citation metadata</para>
    ///   <para>rdfs:comment : Metadata describing the citations made within a work to other works, and (optionally) some characteristics of the expressions of the cited works.</para>
    ///   <a href="http://purl.org/spar/fabio/CitationMetadata">fabio:CitationMetadata</a>
    /// </summary>
    let CitationMetadata = _prefixId.prefix "CitationMetadata"
    /// <summary>
    ///   <para>rdfs:label : clinical case report</para>
    ///   <para>rdfs:comment : A presentation of findings following a clinical or medical investigation on a human or animal patient, that may contain a diagnosis and proposals for therapeutic treatment and/or epidemiological control measures, or may propose further evaluative studies that will eventually lead to such outcomes.</para>
    ///   <a href="http://purl.org/spar/fabio/ClinicalCaseReport">fabio:ClinicalCaseReport</a>
    /// </summary>
    let ClinicalCaseReport = _prefixId.prefix "ClinicalCaseReport"
    /// <summary>
    ///   <para>rdfs:comment : A recommendation on the appropriate treatment and care of people with a specific disease or condition, based on the best available evidence, designed to help healthcare professionals in their work.</para>
    ///   <para>rdfs:label : clinical guideline</para>
    ///   <a href="http://purl.org/spar/fabio/ClinicalGuideline">fabio:ClinicalGuideline</a>
    /// </summary>
    let ClinicalGuideline = _prefixId.prefix "ClinicalGuideline"
    /// <summary>
    ///   <para>rdfs:label : clinical trial design</para>
    ///   <para>rdfs:comment : A predefined written procedural method, designed to ensure reliability of findings, for undertaking a medical or veterinary clinical study of the safety, efficacy, or optimum dosage schedule of one or more diagnostic, therapeutic or prophylactic drugs or treatments, or of devices or techniques, involving a randomized controlled trial for evidence-based assessment in humans or animals, specifying criteria of eligibility, nature of controls, sampling schedules, data collection parameters, statistical analyses, reporting standards, etc. to be employed in undertaking the clinical trial.^^xsd:string</para>
    ///   <a href="http://purl.org/spar/fabio/ClinicalTrialDesign">fabio:ClinicalTrialDesign</a>
    /// </summary>
    let ClinicalTrialDesign = _prefixId.prefix "ClinicalTrialDesign"
    /// <summary>
    ///   <para>rdfs:label : clinical trial report</para>
    ///   <para>rdfs:comment : The report of a pre-planned medical or veterinary clinical study of the safety, efficacy, or optimum dosage schedule of one or more diagnostic, therapeutic or prophylactic drugs, or of devices, treatments or techniques, involving a randomized controlled trial for evidence-based assessment in humans or animals selected according to predetermined criteria of eligibility and observed for evidence of favourable and unfavourable effects.</para>
    ///   <a href="http://purl.org/spar/fabio/ClinicalTrialReport">fabio:ClinicalTrialReport</a>
    /// </summary>
    let ClinicalTrialReport = _prefixId.prefix "ClinicalTrialReport"
    /// <summary>
    ///   <para>rdfs:label : collected works</para>
    ///   <para>rdfs:comment : A collection of the literary or scholastic works of a single person.</para>
    ///   <a href="http://purl.org/spar/fabio/CollectedWorks">fabio:CollectedWorks</a>
    /// </summary>
    let CollectedWorks = _prefixId.prefix "CollectedWorks"
    /// <summary>
    ///   <para>rdfs:comment : A verbal or written remark concerning some entity.  In written form, a comment is often appended to that entity and termed an annotation.  Within computer programs or ontologies, comments are added to enhance human understanding, and are usually prefaced by a special syntactic symbol that ensures they are ignored during execution of the program.</para>
    ///   <para>rdfs:label : comment</para>
    ///   <a href="http://purl.org/spar/fabio/Comment">fabio:Comment</a>
    /// </summary>
    let Comment = _prefixId.prefix "Comment"
    /// <summary>
    ///   <para>rdfs:label : complete works</para>
    ///   <para>rdfs:comment : A collection of all the literary or scholastic works of a single person.</para>
    ///   <a href="http://purl.org/spar/fabio/CompleteWorks">fabio:CompleteWorks</a>
    /// </summary>
    let CompleteWorks = _prefixId.prefix "CompleteWorks"
    /// <summary>
    ///   <para>rdfs:label : computer application</para>
    ///   <para>rdfs:comment : A computer program designed to assist a human user to perform one or more goal-oriented tasks such as word processing or image processing.  A computer application will typically save its output files in one or more specific formats, conforming either to proprietary or open standards.  </para>
    ///   <a href="http://purl.org/spar/fabio/ComputerApplication">fabio:ComputerApplication</a>
    /// </summary>
    let ComputerApplication = _prefixId.prefix "ComputerApplication"
    /// <summary>
    ///   <para>rdfs:comment : A digital item containing information in computer-readable form encoded in a particular format.</para>
    ///   <para>rdfs:label : computer file</para>
    ///   <a href="http://purl.org/spar/fabio/ComputerFile">fabio:ComputerFile</a>
    /// </summary>
    let ComputerFile = _prefixId.prefix "ComputerFile"
    /// <summary>
    ///   <para>rdfs:label : computer program</para>
    ///   <para>rdfs:comment : A unit of computer code in source or compiled form, employing one or more algorithms to be executed by a digital computer to undertake a particular task.  Computer programs are collectively called 'software' to distinguish them from the equipment ('hardware') upon which they run. </para>
    ///   <a href="http://purl.org/spar/fabio/ComputerProgram">fabio:ComputerProgram</a>
    /// </summary>
    let ComputerProgram = _prefixId.prefix "ComputerProgram"
    /// <summary>
    ///   <para>rdfs:label : conference paper</para>
    ///   <para>rdfs:comment : A paper, typically the realization of a research paper reporting original research findings, usually published within a conference proceedings volume.</para>
    ///   <a href="http://purl.org/spar/fabio/ConferencePaper">fabio:ConferencePaper</a>
    /// </summary>
    let ConferencePaper = _prefixId.prefix "ConferencePaper"
    /// <summary>
    ///   <para>rdfs:comment : A display poster, typically containing text with illustrative figures and/or tables, usually reporting research results or proposing hypotheses, submitted for acceptance to and/or presented at a conference, seminar, symposium, workshop or similar event.</para>
    ///   <para>rdfs:label : conference poster</para>
    ///   <a href="http://purl.org/spar/fabio/ConferencePoster">fabio:ConferencePoster</a>
    /// </summary>
    let ConferencePoster = _prefixId.prefix "ConferencePoster"
    /// <summary>
    ///   <para>rdfs:label : conference proceedings</para>
    ///   <para>rdfs:comment : A document containing the programme and collected conference papers, or their abstracts, presented at a conference, seminar, symposium or similar event.</para>
    ///   <a href="http://purl.org/spar/fabio/ConferenceProceedings">fabio:ConferenceProceedings</a>
    /// </summary>
    let ConferenceProceedings = _prefixId.prefix "ConferenceProceedings"
    /// <summary>
    ///   <para>rdfs:comment : A collection of selected words and phrases related to a particular domain of knowledge used to permit consistency of metadata annotation and improved retrieval following a search, in which homonyms, synonyms and similar ambiguities of meaning present in natural language are disambiguated.</para>
    ///   <para>rdfs:label : controlled vocabulary</para>
    ///   <a href="http://purl.org/spar/fabio/ControlledVocabulary">fabio:ControlledVocabulary</a>
    /// </summary>
    let ControlledVocabulary = _prefixId.prefix "ControlledVocabulary"
    /// <summary>
    ///   <para>rdfs:comment : A correction to an error in a previously published document.</para>
    ///   <para>rdfs:label : correction</para>
    ///   <a href="http://purl.org/spar/fabio/Correction">fabio:Correction</a>
    /// </summary>
    let Correction = _prefixId.prefix "Correction"
    /// <summary>
    ///   <para>rdfs:label : corrigendum</para>
    ///   <para>rdfs:comment : A formal correction to an error introduced by the author into a previously published document.</para>
    ///   <a href="http://purl.org/spar/fabio/Corrigendum">fabio:Corrigendum</a>
    /// </summary>
    let Corrigendum = _prefixId.prefix "Corrigendum"
    /// <summary>
    ///   <para>rdfs:comment : A protective covering used to bind together the pages of a document or the first, informative, page of a digital document.</para>
    ///   <para>rdfs:label : cover</para>
    ///   <a href="http://purl.org/spar/fabio/Cover">fabio:Cover</a>
    /// </summary>
    let Cover = _prefixId.prefix "Cover"
    /// <summary>
    ///   <para>rdfs:label : critical edition</para>
    ///   <para>rdfs:comment : A new edition of a historical publication, edited by a scholar other than the original author, containing within the body text the supposedly best version of the original work, with footnotes detailing and commenting on textual variations between different versions, typically with an introduction to the original work written by the scholar, and with a bibliography listing related publications.</para>
    ///   <a href="http://purl.org/spar/fabio/CriticalEdition">fabio:CriticalEdition</a>
    /// </summary>
    let CriticalEdition = _prefixId.prefix "CriticalEdition"
    /// <summary>
    ///   <para>rdfs:label : data file</para>
    ///   <para>rdfs:comment : A realisation of a fabio:Dataset (a frbr:Work) containing a defined collection of data with specific content and possibly with a specific version number, that can be embodied as a fabio:Digital Manifestation (a frbr:Manifestation with a specific format) and be represented by a specific fabio:ComputerFile (a frbr:Item) on someone's hard drive.</para>
    ///   <a href="http://purl.org/spar/fabio/DataFile">fabio:DataFile</a>
    /// </summary>
    let DataFile = _prefixId.prefix "DataFile"
    /// <summary>
    ///   <para>rdfs:comment : A policy that descibes and defines how data should be managed, preserved and shared.</para>
    ///   <para>rdfs:label : data management policy</para>
    ///   <a href="http://purl.org/spar/fabio/DataManagementPolicy">fabio:DataManagementPolicy</a>
    /// </summary>
    let DataManagementPolicy = _prefixId.prefix "DataManagementPolicy"
    /// <summary>
    ///   <para>rdfs:comment : A document embodying a policy that descibes and defines how data should be managed, preserved and shared.</para>
    ///   <para>rdfs:label : data management policy document</para>
    ///   <a href="http://purl.org/spar/fabio/DataManagementPolicyDocument">fabio:DataManagementPolicyDocument</a>
    /// </summary>
    let DataManagementPolicyDocument = _prefixId.prefix "DataManagementPolicyDocument"
    /// <summary>
    ///   <para>rdfs:label : data management plan</para>
    ///   <para>rdfs:comment : A structured document giving information about how data arising from a research project or other endeavour is to be manages, preserved and shared.</para>
    ///   <a href="http://purl.org/spar/fabio/DataMangementPlan">fabio:DataMangementPlan</a>
    /// </summary>
    let DataMangementPlan = _prefixId.prefix "DataMangementPlan"
    /// <summary>
    ///   <para>rdfs:label : data repository</para>
    ///   <para>rdfs:comment : A repository for storing data.</para>
    ///   <a href="http://purl.org/spar/fabio/DataRepository">fabio:DataRepository</a>
    /// </summary>
    let DataRepository = _prefixId.prefix "DataRepository"
    /// <summary>
    ///   <para>rdfs:comment : A structured collection of logically related records or data usually stored and retrieved using computer-based means.</para>
    ///   <para>rdfs:label : database</para>
    ///   <a href="http://purl.org/spar/fabio/Database">fabio:Database</a>
    /// </summary>
    let Database = _prefixId.prefix "Database"
    /// <summary>
    ///   <para>rdfs:label : database management system</para>
    ///   <para>rdfs:comment : The software used to create a database.  (Commonly abbreviated 'DBMS'.)</para>
    ///   <a href="http://purl.org/spar/fabio/DatabaseManagementSystem">fabio:DatabaseManagementSystem</a>
    /// </summary>
    let DatabaseManagementSystem = _prefixId.prefix "DatabaseManagementSystem"
    /// <summary>
    ///   <para>rdfs:comment : A collection of related facts, often expressed in numerical form and encoded in a defined structure.</para>
    ///   <para>rdfs:label : dataset</para>
    ///   <a href="http://purl.org/spar/fabio/Dataset">fabio:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>rdfs:comment : The final published expression of a work that bears the publisher's imprimatur. Typically for a journal article, the Definitive Version results from revision of an earlier submitted version of the work following peer review, and is then published in print and/or digital form after the publisher has assigned it a DOI.  The Definitive Version is also known as the Version of Record, although according to the CrossRef Glossary (http://crossref.org/02publishers/glossary.html) that term can also refer to the author's final version of a work that is not formally published. </para>
    ///   <para>rdfs:label : definitive version</para>
    ///   <a href="http://purl.org/spar/fabio/DefinitiveVersion">fabio:DefinitiveVersion</a>
    /// </summary>
    let DefinitiveVersion = _prefixId.prefix "DefinitiveVersion"
    /// <summary>
    ///   <para>rdfs:comment : A demonstration paper, typically describing a new product, service or system created as a result of research, usually presented during a conference or workshop.</para>
    ///   <para>rdfs:label : demo paper</para>
    ///   <a href="http://purl.org/spar/fabio/DemoPaper">fabio:DemoPaper</a>
    /// </summary>
    let DemoPaper = _prefixId.prefix "DemoPaper"
    /// <summary>
    ///   <para>rdfs:label : diary</para>
    ///   <para>rdfs:comment : A personal record, in a form of book, with discrete entries (often handwritten) arranged by date, reporting what has happened over the course of a day or other period of time.</para>
    ///   <a href="http://purl.org/spar/fabio/Diary">fabio:Diary</a>
    /// </summary>
    let Diary = _prefixId.prefix "Diary"
    /// <summary>
    ///   <para>rdfs:comment : A digital object, such as a computer file.</para>
    ///   <para>dce:description : A digital item is an exemplar of a digital manifestation only and it is always stored in a storage medium suitable for digital objects, such as CDs, DVDs, HDs and the Web.</para>
    ///   <para>rdfs:label : digital item</para>
    ///   <a href="http://purl.org/spar/fabio/DigitalItem">fabio:DigitalItem</a>
    /// </summary>
    let DigitalItem = _prefixId.prefix "DigitalItem"
    /// <summary>
    ///   <para>rdfs:comment : A manifestation that represents data in binary form, encoding the data as a series of 0s and 1s.</para>
    ///   <para>rdfs:label : digital manifestation</para>
    ///   <a href="http://purl.org/spar/fabio/DigitalManifestation">fabio:DigitalManifestation</a>
    /// </summary>
    let DigitalManifestation = _prefixId.prefix "DigitalManifestation"
    /// <summary>
    ///   <para>rdfs:label : digital storage medium</para>
    ///   <para>rdfs:comment : A means of storing information in digital form, involving binary encoding of data in 0s and 1s, e.g. a computer random access memory, hard disc, USB stick, CD, DVD or digital magnetic tape.</para>
    ///   <a href="http://purl.org/spar/fabio/DigitalStorageMedium">fabio:DigitalStorageMedium</a>
    /// </summary>
    let DigitalStorageMedium = _prefixId.prefix "DigitalStorageMedium"
    /// <summary>
    ///   <para>rdfs:comment : A database of information which is heavily optimized for reading.</para>
    ///   <para>rdfs:label : directory</para>
    ///   <a href="http://purl.org/spar/fabio/Directory">fabio:Directory</a>
    /// </summary>
    let Directory = _prefixId.prefix "Directory"
    /// <summary>
    ///   <para>rdfs:comment : A discipline dictionary is a collection of subject disciplines.</para>
    ///   <para>rdfs:label : discipline dictionary</para>
    ///   <a href="http://purl.org/spar/fabio/DisciplineDictionary">fabio:DisciplineDictionary</a>
    /// </summary>
    let DisciplineDictionary = _prefixId.prefix "DisciplineDictionary"
    /// <summary>
    ///   <para>rdfs:comment : A thesis reporting the research undertaken during a period of graduate study leading to a doctoral degree.</para>
    ///   <para>rdfs:label : doctoral thesis</para>
    ///   <a href="http://purl.org/spar/fabio/DoctoralThesis">fabio:DoctoralThesis</a>
    /// </summary>
    let DoctoralThesis = _prefixId.prefix "DoctoralThesis"
    /// <summary>
    ///   <para>rdfs:label : document repository</para>
    ///   <para>rdfs:comment : A repository for storing documents.</para>
    ///   <a href="http://purl.org/spar/fabio/DocumentRepository">fabio:DocumentRepository</a>
    /// </summary>
    let DocumentRepository = _prefixId.prefix "DocumentRepository"
    /// <summary>
    ///   <para>rdfs:comment : A detachable outer cover, usually made of paper and printed with text and illustrations. This outer cover has folded flaps that hold it to the cover of a document.</para>
    ///   <para>rdfs:label : dust jacket</para>
    ///   <a href="http://purl.org/spar/fabio/DustJacket">fabio:DustJacket</a>
    /// </summary>
    let DustJacket = _prefixId.prefix "DustJacket"
    /// <summary>
    ///   <para>rdfs:comment : The realization of an opinion written by an editor.</para>
    ///   <para>rdfs:label : editorial</para>
    ///   <a href="http://purl.org/spar/fabio/Editorial">fabio:Editorial</a>
    /// </summary>
    let Editorial = _prefixId.prefix "Editorial"
    /// <summary>
    ///   <para>rdfs:comment : A message transmitted over the internet as an item of electronic mail, typically based on the Simple Mail Transfer Protocol (SMTP).  Emails can have computer files containing documents, dataset and images attached to them or embedded within them.</para>
    ///   <para>rdfs:label : e-mail</para>
    ///   <a href="http://purl.org/spar/fabio/Email">fabio:Email</a>
    /// </summary>
    let Email = _prefixId.prefix "Email"
    /// <summary>
    ///   <para>rdfs:comment : Metadata describing the work itself, including for example the name of the creator(s), the title of the work, and the date and place of its creation.</para>
    ///   <para>rdfs:label : entity metadata</para>
    ///   <a href="http://purl.org/spar/fabio/EntityMetadata">fabio:EntityMetadata</a>
    /// </summary>
    let EntityMetadata = _prefixId.prefix "EntityMetadata"
    /// <summary>
    ///   <para>rdfs:comment : An item written or printed in a diary, list, account book, reference book, or database.</para>
    ///   <para>rdfs:label : entry</para>
    ///   <a href="http://purl.org/spar/fabio/Entry">fabio:Entry</a>
    /// </summary>
    let Entry = _prefixId.prefix "Entry"
    /// <summary>
    ///   <para>rdfs:label : erratum</para>
    ///   <para>rdfs:comment : A formal correction to an error introduced by the publisher into a previously published document.</para>
    ///   <a href="http://purl.org/spar/fabio/Erratum">fabio:Erratum</a>
    /// </summary>
    let Erratum = _prefixId.prefix "Erratum"
    /// <summary>
    ///   <para>rdfs:comment : A piece of non-fiction writing on a particular subject, usually of moderate length and without chapters.</para>
    ///   <para>rdfs:label : essay</para>
    ///   <a href="http://purl.org/spar/fabio/Essay">fabio:Essay</a>
    /// </summary>
    let Essay = _prefixId.prefix "Essay"
    /// <summary>
    ///   <para>rdfs:label : examination paper</para>
    ///   <para>rdfs:comment : A set of questions on a particular topic designed to test the academic, professional or technical ability of the person taking the examination, with achievement of a pass grade in the examination typically being a prerequisite for the award of an educational award such as a degree, or of a professional or technical qualification.</para>
    ///   <a href="http://purl.org/spar/fabio/ExaminationPaper">fabio:ExaminationPaper</a>
    /// </summary>
    let ExaminationPaper = _prefixId.prefix "ExaminationPaper"
    /// <summary>
    ///   <para>rdfs:label : excerpt</para>
    ///   <para>dce:description : An excerpt is more general than a quotation, and is generally used to indicate a re-published extract from a book, instruction manual, film, radio programme, etc, that need not be what someone said.
    ///
    /// For example:
    ///      Oxford    01865
    ///      Oxshott   01372
    ///      Oxted      01883
    ///      Oxton      01578
    /// is an excerpt from the UK Dialling Codes section of the Oxford Telephone Directory.
    ///
    /// Similarly, the following concluding passage from William Wordsworth's poem Lines written a Few Miles above Tintern Abbey is an excerpt rather than a quotation:
    ///                                            Nor wilt thou then forget,
    ///     That after many wanderings, many years
    ///     Of absence, these steep woods and lofty cliffs,
    ///     And this green pastoral landscape, were to me
    ///     More dear, both for themselves and for thy sake.</para>
    ///   <para>rdfs:comment : A segment or passage selected from a larger expression for use in another expression, usually with specific attribution to its original source.
    ///
    /// [Note: Use fabio:Excerpt to indicate a segment or passage selected from another expression that is not a passage of speech, and fabio:Quotation to indicate a segment or passage selected from another expression that is a passage of speech.]</para>
    ///   <a href="http://purl.org/spar/fabio/Excerpt">fabio:Excerpt</a>
    /// </summary>
    let Excerpt = _prefixId.prefix "Excerpt"
    /// <summary>
    ///   <para>rdfs:label : executive summary</para>
    ///   <para>rdfs:comment : An executive summary is a brief report summarizing a longer formal report, designed to present the key points, conclusions and recommendations arising from the study being reported, for readers too busy to take the time to read the complete report.</para>
    ///   <a href="http://purl.org/spar/fabio/ExecutiveSummary">fabio:ExecutiveSummary</a>
    /// </summary>
    let ExecutiveSummary = _prefixId.prefix "ExecutiveSummary"
    /// <summary>
    ///   <para>rdfs:comment : A predefined written procedural method, designed to ensure successful replication of results by others in the same or other laboratories, that describes the overall objectives, organization and implementation of a scientific experiment, and specifies the experimental design, experimental methods, reagents, instrumentation, sampling schedules, data collection parameters, statistical analyses, image processing procedures, safety precautions, reporting standards, etc. employed in undertaking the experiment.</para>
    ///   <para>rdfs:label : experimental protocol</para>
    ///   <a href="http://purl.org/spar/fabio/ExperimentalProtocol">fabio:ExperimentalProtocol</a>
    /// </summary>
    let ExperimentalProtocol = _prefixId.prefix "ExperimentalProtocol"
    /// <summary>
    ///   <para>rdfs:label : expression</para>
    ///   <para>dce:description : A fabio:Expression can only have part or be part of another fabio:Expression.  Moreover, it can be a representation only of a fabio:Work, and  it can be embodied only in fabio:Manifestation(s).</para>
    ///   <para>rdfs:comment : A subclass of FRBR expression, restricted to expressions of fabio:Works.  For your latest research paper, the preprint submitted to the publisher, and the final published version to which the publisher assigned a unique digital object identifier, are both expressions of the same work.  </para>
    ///   <a href="http://purl.org/spar/fabio/Expression">fabio:Expression</a>
    /// </summary>
    let Expression = _prefixId.prefix "Expression"
    /// <summary>
    ///   <para>rdfs:comment : A collection of expressions, for example a periodical or a book series.</para>
    ///   <para>rdfs:label : expression collection</para>
    ///   <a href="http://purl.org/spar/fabio/ExpressionCollection">fabio:ExpressionCollection</a>
    /// </summary>
    let ExpressionCollection = _prefixId.prefix "ExpressionCollection"

    let ``FRBR%20diagram%20with%20new%20Fabio%20verbs.png`` =
        _prefixId.prefix "FRBR%20diagram%20with%20new%20Fabio%20verbs.png"

    /// <summary>
    ///   <para>rdfs:comment : A visual communication object comprising one or more still images on a related theme.  If included within a publication, a figure is typically unaligned with the main body of text, having its own descriptive textual figure legend.</para>
    ///   <para>rdfs:label : figure</para>
    ///   <a href="http://purl.org/spar/fabio/Figure">fabio:Figure</a>
    /// </summary>
    let Figure = _prefixId.prefix "Figure"
    /// <summary>
    ///   <para>rdfs:label : film</para>
    ///   <para>rdfs:comment : A movie with an accompanying soundtrack, typically created by a professional film studio, designed to communicate a fictional story, record an artistic event, or impart information that is scientific or documentary in nature.</para>
    ///   <a href="http://purl.org/spar/fabio/Film">fabio:Film</a>
    /// </summary>
    let Film = _prefixId.prefix "Film"
    /// <summary>
    ///   <para>rdfs:label : folksonomy</para>
    ///   <para>rdfs:comment : A system of classification derived from the practice and method of collaboratively creating and managing tags to annotate and categorize content in a particular domain. [Contrast fabio:Ontology]</para>
    ///   <a href="http://purl.org/spar/fabio/Folksonomy">fabio:Folksonomy</a>
    /// </summary>
    let Folksonomy = _prefixId.prefix "Folksonomy"
    /// <summary>
    ///   <para>rdfs:label : Gantt chart</para>
    ///   <para>rdfs:comment : A horizontal bar chart used to guide project planning, execution and control, illustrating the project schedule, with a separate line indicating the start and end dates of each of the key project activities or workpackages, and optionally showing the dependencies between these items. A Gantt chart is typically part of a project plan.</para>
    ///   <a href="http://purl.org/spar/fabio/GanttChart">fabio:GanttChart</a>
    /// </summary>
    let GanttChart = _prefixId.prefix "GanttChart"
    /// <summary>
    ///   <para>rdfs:comment : A formal written request for financial support from a grant-giving body in support of a project, for example an academic research project.  (See also fabio:CaseForSupport.)</para>
    ///   <para>rdfs:label : grant application</para>
    ///   <a href="http://purl.org/spar/fabio/GrantApplication">fabio:GrantApplication</a>
    /// </summary>
    let GrantApplication = _prefixId.prefix "GrantApplication"
    /// <summary>
    ///   <para>rdfs:comment : The realization of a grant application, usually containing a case for support document.</para>
    ///   <para>rdfs:label : grant application document</para>
    ///   <a href="http://purl.org/spar/fabio/GrantApplicationDocument">fabio:GrantApplicationDocument</a>
    /// </summary>
    let GrantApplicationDocument = _prefixId.prefix "GrantApplicationDocument"
    /// <summary>
    ///   <para>rdfs:comment : A print object bound with rigid protective covers (typically of cardboard covered with cloth, heavy paper, or sometimes leather).</para>
    ///   <para>rdfs:label : hardback</para>
    ///   <a href="http://purl.org/spar/fabio/Hardback">fabio:Hardback</a>
    /// </summary>
    let Hardback = _prefixId.prefix "Hardback"
    /// <summary>
    ///   <para>rdfs:comment : A visual representation other than text, including all types of moving image and still image.</para>
    ///   <para>rdfs:label : image</para>
    ///   <a href="http://purl.org/spar/fabio/Image">fabio:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>rdfs:comment : An 'In Brief' is a journal or magazine news item that describes all the articles (or all the important articles) in that issue of the periodical. The content of an 'In Brief' may be constructed from the abstracts of the articles it highlights, but is more likely to be written by a member of the periodical staff especially for the issue.</para>
    ///   <para>rdfs:label : in brief</para>
    ///   <a href="http://purl.org/spar/fabio/InBrief">fabio:InBrief</a>
    /// </summary>
    let InBrief = _prefixId.prefix "InBrief"
    /// <summary>
    ///   <para>rdfs:label : in-use paper</para>
    ///   <para>rdfs:comment : A scholarly work that describes applied and validated solutions such as software tools, systems or architectures that benefit from the use of the technology of a particular scholarly domain. Usually, papers of this kind should also provide convincing evidence that there is use of the proposed application or tool by the target user group, preferably outside the institution that conducted its development.
    ///
    /// E.g. see http://iswc2018.semanticweb.org/call-for-in-use-track-papers/.</para>
    ///   <a href="http://purl.org/spar/fabio/InUsePaper">fabio:InUsePaper</a>
    /// </summary>
    let InUsePaper = _prefixId.prefix "InUsePaper"
    /// <summary>
    ///   <para>rdfs:label : index</para>
    ///   <para>rdfs:comment : An alphabetically-ordered list of words and phrases ('headings') and associated pointers ('locators') to where useful material relating to that heading can be found in a document.</para>
    ///   <a href="http://purl.org/spar/fabio/Index">fabio:Index</a>
    /// </summary>
    let Index = _prefixId.prefix "Index"
    /// <summary>
    ///   <para>rdfs:comment : An instructional document typically supplied with a technologically advanced consumer product, such as a car or a computer application, or with an item of complex equipment such as a microscope.</para>
    ///   <para>rdfs:label : instruction manual</para>
    ///   <a href="http://purl.org/spar/fabio/InstructionManual">fabio:InstructionManual</a>
    /// </summary>
    let InstructionManual = _prefixId.prefix "InstructionManual"
    /// <summary>
    ///   <para>rdfs:comment : A work created for the purpose of education or instruction, that may be expressed as a  text book, a lecture, a tutorial or an instruction manual.</para>
    ///   <para>rdfs:label : instructional work</para>
    ///   <a href="http://purl.org/spar/fabio/InstructionalWork">fabio:InstructionalWork</a>
    /// </summary>
    let InstructionalWork = _prefixId.prefix "InstructionalWork"
    /// <summary>
    ///   <para>dce:description : A fabio:Item can only have part or be part of another fabio:Item. Moreover, it can be an exemplar only of a fabio:Manifestation.</para>
    ///   <para>rdfs:comment : A subclass of FRBR item, restricted to exemplars of fabio:Manifestations.  An example of a fabio:Item is a printed copy of a journal article on your desk, or a PDF file of that article that you purchased from a publisher and that now resides in digital form on your computer hard drive.  </para>
    ///   <para>rdfs:label : item</para>
    ///   <a href="http://purl.org/spar/fabio/Item">fabio:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>rdfs:label : item collection</para>
    ///   <para>rdfs:comment : A collection of items.</para>
    ///   <a href="http://purl.org/spar/fabio/ItemCollection">fabio:ItemCollection</a>
    /// </summary>
    let ItemCollection = _prefixId.prefix "ItemCollection"
    /// <summary>
    ///   <para>rdfs:label : journal</para>
    ///   <para>rdfs:comment : A scholarly periodical primarily devoted to the publication of original research papers. [Printed and electronic manifestations of the same journal are usually identified by separate print and electronic International Standard Serial Numbers (ISSN or eISSN, respectively), that identifies the journal as a whole, not to individual issues of it.]</para>
    ///   <a href="http://purl.org/spar/fabio/Journal">fabio:Journal</a>
    /// </summary>
    let Journal = _prefixId.prefix "Journal"
    /// <summary>
    ///   <para>rdfs:label : journal article</para>
    ///   <para>rdfs:comment : An article, typically the realization of a research paper reporting original research findings, published in a journal issue.  </para>
    ///   <a href="http://purl.org/spar/fabio/JournalArticle">fabio:JournalArticle</a>
    /// </summary>
    let JournalArticle = _prefixId.prefix "JournalArticle"
    /// <summary>
    ///   <para>rdfs:label : journal editorial</para>
    ///   <para>rdfs:comment : An editorial published in an issue of a journal.</para>
    ///   <a href="http://purl.org/spar/fabio/JournalEditorial">fabio:JournalEditorial</a>
    /// </summary>
    let JournalEditorial = _prefixId.prefix "JournalEditorial"
    /// <summary>
    ///   <para>rdfs:label : journal issue</para>
    ///   <para>rdfs:comment : A particular published issue of a journal, one or more of which will constitute a volume of the journal.</para>
    ///   <a href="http://purl.org/spar/fabio/JournalIssue">fabio:JournalIssue</a>
    /// </summary>
    let JournalIssue = _prefixId.prefix "JournalIssue"
    /// <summary>
    ///   <para>rdfs:comment : A news report published in a journal issue.</para>
    ///   <para>rdfs:label : journal news item</para>
    ///   <a href="http://purl.org/spar/fabio/JournalNewsItem">fabio:JournalNewsItem</a>
    /// </summary>
    let JournalNewsItem = _prefixId.prefix "JournalNewsItem"
    /// <summary>
    ///   <para>rdfs:comment : A particular published volume of a journal, comprising one or more journal issues.</para>
    ///   <para>rdfs:label : journal volume</para>
    ///   <a href="http://purl.org/spar/fabio/JournalVolume">fabio:JournalVolume</a>
    /// </summary>
    let JournalVolume = _prefixId.prefix "JournalVolume"
    /// <summary>
    ///   <para>rdfs:comment : A notebook used by an individual research scientist as the primary record of his or her research activities. A researcher may use a laboratory notebook to document hypotheses, to describe experiments and to record data in various formats, to provide details of data analysis and interpretation, or to record the validation or invalidation of the original hypotheses. The laboratory notebook serves as an organizational tool and a memory aid.  It may also have a role in recording and protecting any intellectual property created during the research, and may be used in evidence when establishing priority of discoveries, for example in patent applications.  Electronic versions of laboratory notebooks are increasingly being employed by researchers, particularly in chemistry and the pharmaceutical industry.</para>
    ///   <para>rdfs:label : laboratory notebook</para>
    ///   <a href="http://purl.org/spar/fabio/LaboratoryNotebook">fabio:LaboratoryNotebook</a>
    /// </summary>
    let LaboratoryNotebook = _prefixId.prefix "LaboratoryNotebook"
    /// <summary>
    ///   <para>rdfs:comment : A document containing notes that summarize a lecture or course of lectures.</para>
    ///   <para>rdfs:label : lecture notes</para>
    ///   <a href="http://purl.org/spar/fabio/LectureNotes">fabio:LectureNotes</a>
    /// </summary>
    let LectureNotes = _prefixId.prefix "LectureNotes"
    /// <summary>
    ///   <para>rdfs:label : legal opinion</para>
    ///   <para>rdfs:comment : A written explanation by a judge or group of judges that accompanies a ruling in a legal case, laying out the reasons and legal principles for the ruling, and sometimes containing pronouncements about what the law is and how it should be interpreted.</para>
    ///   <a href="http://purl.org/spar/fabio/LegalOpinion">fabio:LegalOpinion</a>
    /// </summary>
    let LegalOpinion = _prefixId.prefix "LegalOpinion"
    /// <summary>
    ///   <para>rdfs:label : letter</para>
    ///   <para>rdfs:comment : A written or printed communication of a personal or professional nature between individuals and/or representatives of corporate bodies, usually transmitted by the postal service or published in a periodical.  In the latter case, the letter is typically addressed to the editor and comments on or discussed an item previously published by that periodical, or of interest to its readership.</para>
    ///   <a href="http://purl.org/spar/fabio/Letter">fabio:Letter</a>
    /// </summary>
    let Letter = _prefixId.prefix "Letter"
    /// <summary>
    ///   <para>rdfs:comment : The catalog of the holdings of a library, for example that of the Library of Congress (http://catalog.loc.gov/).</para>
    ///   <para>rdfs:label : library catalog</para>
    ///   <a href="http://purl.org/spar/fabio/LibraryCatalog">fabio:LibraryCatalog</a>
    /// </summary>
    let LibraryCatalog = _prefixId.prefix "LibraryCatalog"
    /// <summary>
    ///   <para>rdfs:comment : A literary creative work, such as a novel, play, poem or song.</para>
    ///   <para>rdfs:label : literary artistic work</para>
    ///   <a href="http://purl.org/spar/fabio/LiteraryArtisticWork">fabio:LiteraryArtisticWork</a>
    /// </summary>
    let LiteraryArtisticWork = _prefixId.prefix "LiteraryArtisticWork"
    /// <summary>
    ///   <para>rdfs:comment : A periodical, usually devoted to a particular topic or domain of interest, and usually published weekly or monthly, consisting primarily of  non-peer reviewed editorials, journalistic news items and more substantive articles, reviews, book reviews and discussions concerning current or recent events and publications, and matters of interest to the domain served by the magazine.  [Some scientific journals, notably Science and Nature, also secondarily serve as science magazines by containing substantive editorials and news items on vital or controversial issues].</para>
    ///   <para>rdfs:label : magazine</para>
    ///   <a href="http://purl.org/spar/fabio/Magazine">fabio:Magazine</a>
    /// </summary>
    let Magazine = _prefixId.prefix "Magazine"
    /// <summary>
    ///   <para>rdfs:comment : An article published in a magazine issue.</para>
    ///   <para>rdfs:label : magazine article</para>
    ///   <a href="http://purl.org/spar/fabio/MagazineArticle">fabio:MagazineArticle</a>
    /// </summary>
    let MagazineArticle = _prefixId.prefix "MagazineArticle"
    /// <summary>
    ///   <para>rdfs:label : magazine editorial</para>
    ///   <para>rdfs:comment : An editorial published in an issue of a magazine.</para>
    ///   <a href="http://purl.org/spar/fabio/MagazineEditorial">fabio:MagazineEditorial</a>
    /// </summary>
    let MagazineEditorial = _prefixId.prefix "MagazineEditorial"
    /// <summary>
    ///   <para>rdfs:comment : A particular published  issue of a magazine, identified by date, and sometimes also by place (e.g. 'West Coast edition') or language (e.g. 'Spanish edition').</para>
    ///   <para>rdfs:label : magazine issue</para>
    ///   <a href="http://purl.org/spar/fabio/MagazineIssue">fabio:MagazineIssue</a>
    /// </summary>
    let MagazineIssue = _prefixId.prefix "MagazineIssue"
    /// <summary>
    ///   <para>rdfs:comment : A news report published in a magazine issue.</para>
    ///   <para>rdfs:label : magazine news item</para>
    ///   <a href="http://purl.org/spar/fabio/MagazineNewsItem">fabio:MagazineNewsItem</a>
    /// </summary>
    let MagazineNewsItem = _prefixId.prefix "MagazineNewsItem"
    /// <summary>
    ///   <para>rdfs:label : manifestation</para>
    ///   <para>dce:description : A fabio:Manifestation can only have part or be part of another fabio:Manifestation.  Moreover, it can be an embodiment only of a fabio:Expression and it can be exemplified only by fabio:Item(s).</para>
    ///   <para>rdfs:comment : A subclass of FRBR manifestation, restricted to manifestations of fabio:Expressions. fabio:Manifestation specifically applies to electronic (digital) as well as to physical manifestations of expressions.
    ///
    /// Examples of different manifestations of a single 'version of record' expression of a scholarly work include an article in a print journal or the on-line version of that article as a web page.</para>
    ///   <a href="http://purl.org/spar/fabio/Manifestation">fabio:Manifestation</a>
    /// </summary>
    let Manifestation = _prefixId.prefix "Manifestation"
    /// <summary>
    ///   <para>rdfs:comment : A collection of manifestations.</para>
    ///   <para>rdfs:label : manifestation collection</para>
    ///   <a href="http://purl.org/spar/fabio/ManifestationCollection">fabio:ManifestationCollection</a>
    /// </summary>
    let ManifestationCollection = _prefixId.prefix "ManifestationCollection"
    /// <summary>
    ///   <para>rdfs:comment : A textual work prepared 'by hand', such as a typescript or word-processed pre-publication draft of a research paper or a report, or a work not otherwise reproduced in multiple copies.  [Note: fabio:Manuscript is not intended to describe a handwritten historical document on paper or parchment, for which the FRBR distinctions between work, expression, manifestation and item (individual copy) becomes blurred.].</para>
    ///   <para>rdfs:label : manuscript</para>
    ///   <a href="http://purl.org/spar/fabio/Manuscript">fabio:Manuscript</a>
    /// </summary>
    let Manuscript = _prefixId.prefix "Manuscript"
    /// <summary>
    ///   <para>rdfs:label : master's thesis</para>
    ///   <para>rdfs:comment : A thesis reporting a research project undertaken as part of a graduate course of education leading to a master's degree.</para>
    ///   <a href="http://purl.org/spar/fabio/MastersThesis">fabio:MastersThesis</a>
    /// </summary>
    let MastersThesis = _prefixId.prefix "MastersThesis"
    /// <summary>
    ///   <para>rdfs:comment : A report of a meeting of some kind.</para>
    ///   <para>rdfs:label : meeting report</para>
    ///   <a href="http://purl.org/spar/fabio/MeetingReport">fabio:MeetingReport</a>
    /// </summary>
    let MeetingReport = _prefixId.prefix "MeetingReport"
    /// <summary>
    ///   <para>rdfs:comment : A separate work that provides information describing one or more characteristics of a resource or entity.</para>
    ///   <para>rdfs:label : metadata</para>
    ///   <a href="http://purl.org/spar/fabio/Metadata">fabio:Metadata</a>
    /// </summary>
    let Metadata = _prefixId.prefix "Metadata"
    /// <summary>
    ///   <para>rdfs:label : metadata document</para>
    ///   <para>rdfs:comment : A document that contains metadata information describing one or more characteristics of an entity.</para>
    ///   <a href="http://purl.org/spar/fabio/MetadataDocument">fabio:MetadataDocument</a>
    /// </summary>
    let MetadataDocument = _prefixId.prefix "MetadataDocument"
    /// <summary>
    ///   <para>rdfs:comment : A scholarly work detailing a method, procedure or experimental protocol employed in a particular scholarly domain.</para>
    ///   <para>rdfs:label : methods paper</para>
    ///   <a href="http://purl.org/spar/fabio/MethodsPaper">fabio:MethodsPaper</a>
    /// </summary>
    let MethodsPaper = _prefixId.prefix "MethodsPaper"
    /// <summary>
    ///   <para>rdfs:comment : A social networking publication medium such as Twitter, Tumblr, FriendFeed, Facebook or MySpace. A microblog differs from a traditional blog in that its individual content items are smaller than a traditional blog posts, typically containing just a short sentence, a single image, or a URI.  These small messages are referred to as microposts.</para>
    ///   <para>rdfs:label : microblog</para>
    ///   <a href="http://purl.org/spar/fabio/Microblog">fabio:Microblog</a>
    /// </summary>
    let Microblog = _prefixId.prefix "Microblog"
    /// <summary>
    ///   <para>rdfs:comment : A content item that is published in a Microblog, typically containing just a short sentence, a single image, or a URL.</para>
    ///   <para>rdfs:label : micropost</para>
    ///   <a href="http://purl.org/spar/fabio/Micropost">fabio:Micropost</a>
    /// </summary>
    let Micropost = _prefixId.prefix "Micropost"
    /// <summary>
    ///   <para>rdfs:label : minimal information standard</para>
    ///   <para>rdfs:comment : A metadata standard specifying items to be included when creating metadata describing a dataset of a particular type, or when creating a structured summary of the main findings of an article or report in a particular domain of interest, thereby ensuring adequate descriptive information is recorded for subsequent resource discovery and/or interpretation of the information described.  [See also fabio:ReportingStandard.]^^xsd:string</para>
    ///   <a href="http://purl.org/spar/fabio/MinimalInformationStandard">fabio:MinimalInformationStandard</a>
    /// </summary>
    let MinimalInformationStandard = _prefixId.prefix "MinimalInformationStandard"
    /// <summary>
    ///   <para>rdfs:label : model</para>
    ///   <para>rdfs:comment : A mathematical, graphical or physical representation of some physical reality, conceptual idea or theoretical construct.</para>
    ///   <a href="http://purl.org/spar/fabio/Model">fabio:Model</a>
    /// </summary>
    let Model = _prefixId.prefix "Model"
    /// <summary>
    ///   <para>rdfs:label : movie</para>
    ///   <para>rdfs:comment : The realization of a moving image.</para>
    ///   <a href="http://purl.org/spar/fabio/Movie">fabio:Movie</a>
    /// </summary>
    let Movie = _prefixId.prefix "Movie"
    /// <summary>
    ///   <para>rdfs:comment : A moving display, either generated dynamically by a computer program or formed from a series of pre-recorded still images imparting an impression of motion when shown in succession.  Examples include animations, cine films, videos, and computational simulations. Expressions of moving images may incorporate synchronized soundtracks.</para>
    ///   <para>rdfs:label : moving image</para>
    ///   <a href="http://purl.org/spar/fabio/MovingImage">fabio:MovingImage</a>
    /// </summary>
    let MovingImage = _prefixId.prefix "MovingImage"
    /// <summary>
    ///   <para>rdfs:comment : A piece of music, typically in the form of a composition recorded in musical notation.</para>
    ///   <para>rdfs:label : musical composition</para>
    ///   <a href="http://purl.org/spar/fabio/MusicalComposition">fabio:MusicalComposition</a>
    /// </summary>
    let MusicalComposition = _prefixId.prefix "MusicalComposition"
    /// <summary>
    ///   <para>rdfs:label : nanopublication</para>
    ///   <para>rdfs:comment : A single, attributable and machine-readable factual assertion - the smallest unit of publishable information that can be uniquely identified and attributed to its author – typically expressed in RDF.  The minimal components of a nanopublication are as follows:
    /// * the factual assertion itself, in the form subject, predicate and object (e.g. malaria is_a disease);
    /// * provenance information about the nanopublication, defining its authorship and creation date;
    /// * supporting information (optional), providing context for the assertion;
    /// * a unique identifier for the nanopublication, in the form of a URI;
    /// * an integrity key that ensures that the nanopublication is in its original form and has not been altered.
    /// </para>
    ///   <a href="http://purl.org/spar/fabio/Nanopublication">fabio:Nanopublication</a>
    /// </summary>
    let Nanopublication = _prefixId.prefix "Nanopublication"
    /// <summary>
    ///   <para>rdfs:label : news item</para>
    ///   <para>rdfs:comment : A published news report.</para>
    ///   <a href="http://purl.org/spar/fabio/NewsItem">fabio:NewsItem</a>
    /// </summary>
    let NewsItem = _prefixId.prefix "NewsItem"
    /// <summary>
    ///   <para>rdfs:label : news report</para>
    ///   <para>rdfs:comment : A report of an item of news.</para>
    ///   <a href="http://purl.org/spar/fabio/NewsReport">fabio:NewsReport</a>
    /// </summary>
    let NewsReport = _prefixId.prefix "NewsReport"
    /// <summary>
    ///   <para>rdfs:label : newspaper</para>
    ///   <para>rdfs:comment : A non-peer reviewed periodical, usually published daily or weekly, consisting primarily of editorials and news items concerning current or recent events and matters of public interest.</para>
    ///   <a href="http://purl.org/spar/fabio/Newspaper">fabio:Newspaper</a>
    /// </summary>
    let Newspaper = _prefixId.prefix "Newspaper"
    /// <summary>
    ///   <para>rdfs:comment : An article written by a journalist and published in a newspaper.</para>
    ///   <para>rdfs:label : newspaper article</para>
    ///   <a href="http://purl.org/spar/fabio/NewspaperArticle">fabio:NewspaperArticle</a>
    /// </summary>
    let NewspaperArticle = _prefixId.prefix "NewspaperArticle"
    /// <summary>
    ///   <para>rdfs:label : newspaper editorial</para>
    ///   <para>rdfs:comment : An editorial published in an issue of a newspaper.</para>
    ///   <a href="http://purl.org/spar/fabio/NewspaperEditorial">fabio:NewspaperEditorial</a>
    /// </summary>
    let NewspaperEditorial = _prefixId.prefix "NewspaperEditorial"
    /// <summary>
    ///   <para>rdfs:label : newspaper issue</para>
    ///   <para>rdfs:comment : A particular published  issue of a newspaper, identified by date, and sometimes also by place or time (e.g. 'Late London Edition').</para>
    ///   <a href="http://purl.org/spar/fabio/NewspaperIssue">fabio:NewspaperIssue</a>
    /// </summary>
    let NewspaperIssue = _prefixId.prefix "NewspaperIssue"
    /// <summary>
    ///   <para>rdfs:label : newspaper news item</para>
    ///   <para>rdfs:comment : A news report published in a newspaper issue.</para>
    ///   <a href="http://purl.org/spar/fabio/NewspaperNewsItem">fabio:NewspaperNewsItem</a>
    /// </summary>
    let NewspaperNewsItem = _prefixId.prefix "NewspaperNewsItem"
    /// <summary>
    ///   <para>rdfs:comment : A book containing personal notes, typically created by writing into a physical book with blank pages.</para>
    ///   <para>rdfs:label : notebook</para>
    ///   <a href="http://purl.org/spar/fabio/Notebook">fabio:Notebook</a>
    /// </summary>
    let Notebook = _prefixId.prefix "Notebook"
    /// <summary>
    ///   <para>rdfs:comment : A notification of receipt of something, for example of receipt of a book that will later be the subject of a book review.</para>
    ///   <para>rdfs:label : notification of receipt</para>
    ///   <a href="http://purl.org/spar/fabio/NotificationOfReceipt">fabio:NotificationOfReceipt</a>
    /// </summary>
    let NotificationOfReceipt = _prefixId.prefix "NotificationOfReceipt"
    /// <summary>
    ///   <para>rdfs:comment : A long fictitious narrative written in literary prose.</para>
    ///   <para>rdfs:label : novel</para>
    ///   <a href="http://purl.org/spar/fabio/Novel">fabio:Novel</a>
    /// </summary>
    let Novel = _prefixId.prefix "Novel"
    /// <summary>
    ///   <para>rdfs:comment : A news item reporting the death of a person, typically accompanied by an description of that person's life and contributions to his or her profession and to society at large.</para>
    ///   <para>rdfs:label : obituary</para>
    ///   <a href="http://purl.org/spar/fabio/Obituary">fabio:Obituary</a>
    /// </summary>
    let Obituary = _prefixId.prefix "Obituary"
    /// <summary>
    ///   <para>rdfs:comment : A formal representation of a set of concepts within a domain of knowledge, and the logical relationships between those concepts.  [Contrast fabio:Folksonomy]</para>
    ///   <para>rdfs:label : ontology</para>
    ///   <a href="http://purl.org/spar/fabio/Ontology">fabio:Ontology</a>
    /// </summary>
    let Ontology = _prefixId.prefix "Ontology"
    /// <summary>
    ///   <para>rdfs:comment : A document containing an ontology, for example an OWL (Web Ontology Language) file (http://www.w3.org/TR/owl-features/).</para>
    ///   <para>rdfs:label : ontology document</para>
    ///   <a href="http://purl.org/spar/fabio/OntologyDocument">fabio:OntologyDocument</a>
    /// </summary>
    let OntologyDocument = _prefixId.prefix "OntologyDocument"
    /// <summary>
    ///   <para>rdfs:comment : An expression of a personal or professional opinion on an issue or topic.</para>
    ///   <para>rdfs:label : opinion</para>
    ///   <a href="http://purl.org/spar/fabio/Opinion">fabio:Opinion</a>
    /// </summary>
    let Opinion = _prefixId.prefix "Opinion"
    /// <summary>
    ///   <para>rdfs:label : oration</para>
    ///   <para>rdfs:comment : A formal speech, for example one delivered at a ceremonial occasion, or the written transcript of such a speech.</para>
    ///   <a href="http://purl.org/spar/fabio/Oration">fabio:Oration</a>
    /// </summary>
    let Oration = _prefixId.prefix "Oration"
    /// <summary>
    ///   <para>rdfs:label : page</para>
    ///   <para>rdfs:comment : A manifestation that represents pages either in physical (e.g., one side of a sheet of paper) or in digital form (e.g., a page in a PDF, or a web page).</para>
    ///   <a href="http://purl.org/spar/fabio/Page">fabio:Page</a>
    /// </summary>
    let Page = _prefixId.prefix "Page"
    /// <summary>
    ///   <para>rdfs:comment : A print object with a flexible cover, usually made of paper or paperboard.</para>
    ///   <para>rdfs:label : paperback</para>
    ///   <a href="http://purl.org/spar/fabio/Paperback">fabio:Paperback</a>
    /// </summary>
    let Paperback = _prefixId.prefix "Paperback"
    /// <summary>
    ///   <para>rdfs:comment : A formal disclosure of a new invention approved by a governmental patent agency, made to register intellectual property rights, and to give exclusive rights to the inventor or assignee to manufacture, use, license or sell the invention for a certain number of years.</para>
    ///   <para>rdfs:label : patent</para>
    ///   <a href="http://purl.org/spar/fabio/Patent">fabio:Patent</a>
    /// </summary>
    let Patent = _prefixId.prefix "Patent"
    /// <summary>
    ///   <para>rdfs:label : patent application</para>
    ///   <para>rdfs:comment : A formal disclosure of a new invention, made in application for a patent.</para>
    ///   <a href="http://purl.org/spar/fabio/PatentApplication">fabio:PatentApplication</a>
    /// </summary>
    let PatentApplication = _prefixId.prefix "PatentApplication"
    /// <summary>
    ///   <para>rdfs:label : patent application document</para>
    ///   <para>rdfs:comment : The physical or electronic realization of a patent application.</para>
    ///   <a href="http://purl.org/spar/fabio/PatentApplicationDocument">fabio:PatentApplicationDocument</a>
    /// </summary>
    let PatentApplicationDocument = _prefixId.prefix "PatentApplicationDocument"
    /// <summary>
    ///   <para>rdfs:comment : The physical or electronic realization of a patent.</para>
    ///   <para>rdfs:label : patent document</para>
    ///   <a href="http://purl.org/spar/fabio/PatentDocument">fabio:PatentDocument</a>
    /// </summary>
    let PatentDocument = _prefixId.prefix "PatentDocument"
    /// <summary>
    ///   <para>rdfs:comment : A publication issued on a regular and ongoing basis as a series of issues, each issue comprising separate periodical items, for example editorials, articles, news items and/or other writings.</para>
    ///   <para>rdfs:label : periodical</para>
    ///   <a href="http://purl.org/spar/fabio/Periodical">fabio:Periodical</a>
    /// </summary>
    let Periodical = _prefixId.prefix "Periodical"
    /// <summary>
    ///   <para>rdfs:comment : A particular issue of a periodical, identified and distinguished from other issues of the same publication by date and/or issue number and/or volume number, and comprising separate periodical items such as editorials, articles and news items.</para>
    ///   <para>rdfs:label : periodical issue</para>
    ///   <a href="http://purl.org/spar/fabio/PeriodicalIssue">fabio:PeriodicalIssue</a>
    /// </summary>
    let PeriodicalIssue = _prefixId.prefix "PeriodicalIssue"
    /// <summary>
    ///   <para>rdfs:label : periodical item</para>
    ///   <para>rdfs:comment : A piece of writing published in a periodical issue, typically accompanied by other items by different authors.</para>
    ///   <a href="http://purl.org/spar/fabio/PeriodicalItem">fabio:PeriodicalItem</a>
    /// </summary>
    let PeriodicalItem = _prefixId.prefix "PeriodicalItem"
    /// <summary>
    ///   <para>rdfs:label : periodical volume</para>
    ///   <para>rdfs:comment : A particular published volume of a periodical.</para>
    ///   <a href="http://purl.org/spar/fabio/PeriodicalVolume">fabio:PeriodicalVolume</a>
    /// </summary>
    let PeriodicalVolume = _prefixId.prefix "PeriodicalVolume"
    /// <summary>
    ///   <para>rdfs:comment : Information communicated personally by verbal or written means from one individual to one or more another persons or organizations.</para>
    ///   <para>rdfs:label : personal communication</para>
    ///   <a href="http://purl.org/spar/fabio/PersonalCommunication">fabio:PersonalCommunication</a>
    /// </summary>
    let PersonalCommunication = _prefixId.prefix "PersonalCommunication"
    /// <summary>
    ///   <para>rdfs:label : Ph.D. symposium paper</para>
    ///   <para>rdfs:comment : A paper, usually presented during a specific session of a conference dedicated to Ph.D. students, that describes ongoing Ph.D. student's research.</para>
    ///   <a href="http://purl.org/spar/fabio/PhDSymposiumPaper">fabio:PhDSymposiumPaper</a>
    /// </summary>
    let PhDSymposiumPaper = _prefixId.prefix "PhDSymposiumPaper"
    /// <summary>
    ///   <para>rdfs:comment : A form of literature written by a playwright, usually consisting of scripted dialogue between characters, intended for theatrical performance rather than reading.</para>
    ///   <para>rdfs:label : play</para>
    ///   <a href="http://purl.org/spar/fabio/Play">fabio:Play</a>
    /// </summary>
    let Play = _prefixId.prefix "Play"
    /// <summary>
    ///   <para>rdfs:label : poem</para>
    ///   <para>rdfs:comment : An artistic work written with an intensity or beauty of language more characteristic of poetry than of prose.</para>
    ///   <a href="http://purl.org/spar/fabio/Poem">fabio:Poem</a>
    /// </summary>
    let Poem = _prefixId.prefix "Poem"
    /// <summary>
    ///   <para>rdfs:comment : A description and definition of how something should be done.  Ideally a policy should be both effective in achieving its goals and acceptable to those who have to abide by it.</para>
    ///   <para>rdfs:label : policy</para>
    ///   <a href="http://purl.org/spar/fabio/Policy">fabio:Policy</a>
    /// </summary>
    let Policy = _prefixId.prefix "Policy"
    /// <summary>
    ///   <para>rdfs:comment : A document embodying a policy that descibes and defines how something should be done. </para>
    ///   <para>rdfs:label : policy document</para>
    ///   <a href="http://purl.org/spar/fabio/PolicyDocument">fabio:PolicyDocument</a>
    /// </summary>
    let PolicyDocument = _prefixId.prefix "PolicyDocument"
    /// <summary>
    ///   <para>rdfs:comment : A scholarly work that reports a particular intellectual position or viewpoint regarding a particular scholarly topic. Usually, these papers are dependent on the author's opinion or interpretation, do not have an evaluation, and need to present relevant and novel discussion points in a thorough manner.
    ///
    /// E.g. see https://datasciencehub.net/content/guidelines-authors</para>
    ///   <para>rdfs:label : position paper</para>
    ///   <a href="http://purl.org/spar/fabio/PositionPaper">fabio:PositionPaper</a>
    /// </summary>
    let PositionPaper = _prefixId.prefix "PositionPaper"
    /// <summary>
    ///   <para>rdfs:comment : A paper that typically accompanies a poster describing some preliminary  results of research, usually presented during a conference or a workshop.</para>
    ///   <para>rdfs:label : poster paper</para>
    ///   <a href="http://purl.org/spar/fabio/PosterPaper">fabio:PosterPaper</a>
    /// </summary>
    let PosterPaper = _prefixId.prefix "PosterPaper"
    /// <summary>
    ///   <para>rdfs:label : postprint</para>
    ///   <para>rdfs:comment : The version of an author's original scholarly work, such as a research paper or a review, re-submitted for publication after revision by the author in the light of comments from reviewers.  [Note: For the version before peer review, use fabio:Preprint. For the final piblished version, use fabio:DefinitiveVersion.]</para>
    ///   <a href="http://purl.org/spar/fabio/Postprint">fabio:Postprint</a>
    /// </summary>
    let Postprint = _prefixId.prefix "Postprint"
    /// <summary>
    ///   <para>rdfs:label : preprint</para>
    ///   <para>rdfs:comment : The version of an author's original scholarly work, such as a research paper or a review, first submitted to publisher for publication.  [Note: For that version resubmitted after peer-review and revision, use fabio:Postprint. For the final published version use fabio:DefinitiveVersion.]</para>
    ///   <a href="http://purl.org/spar/fabio/Preprint">fabio:Preprint</a>
    /// </summary>
    let Preprint = _prefixId.prefix "Preprint"
    /// <summary>
    ///   <para>rdfs:comment : A set of slides containing text, tables or figures, designed to communicate ideas or research results, for projection and viewing by an audience at a conference, symposium, seminar, lecture, workshop or other gatherings, typically embodied in a particular manifestation format such as a SlideShare or PowerPoint slideshow.</para>
    ///   <para>rdfs:label : presentation</para>
    ///   <a href="http://purl.org/spar/fabio/Presentation">fabio:Presentation</a>
    /// </summary>
    let Presentation = _prefixId.prefix "Presentation"
    /// <summary>
    ///   <para>rdfs:label : press release</para>
    ///   <para>rdfs:comment : A news report published by an organization to provide information to journalists.</para>
    ///   <a href="http://purl.org/spar/fabio/PressRelease">fabio:PressRelease</a>
    /// </summary>
    let PressRelease = _prefixId.prefix "PressRelease"
    /// <summary>
    ///   <para>rdfs:comment : An analog manifestation in physical printed form, typically on paper.</para>
    ///   <para>rdfs:label : print object</para>
    ///   <a href="http://purl.org/spar/fabio/PrintObject">fabio:PrintObject</a>
    /// </summary>
    let PrintObject = _prefixId.prefix "PrintObject"
    /// <summary>
    ///   <para>rdfs:comment : A paper, typically the realization of a research paper reporting original research findings, usually published within an academic proceedings volume.</para>
    ///   <para>rdfs:label : proceedings paper</para>
    ///   <a href="http://purl.org/spar/fabio/ProceedingsPaper">fabio:ProceedingsPaper</a>
    /// </summary>
    let ProceedingsPaper = _prefixId.prefix "ProceedingsPaper"
    /// <summary>
    ///   <para>rdfs:label : product review</para>
    ///   <para>rdfs:comment : A written review and critical analysis of the purpose, features, performance and other qualities of a product.</para>
    ///   <a href="http://purl.org/spar/fabio/ProductReview">fabio:ProductReview</a>
    /// </summary>
    let ProductReview = _prefixId.prefix "ProductReview"
    /// <summary>
    ///   <para>rdfs:comment : Metadata describing a project, for example the project name, the names of those who conducted the project, the name of the institution in which the project was conducted, and the project funding information.</para>
    ///   <para>rdfs:label : project metadata</para>
    ///   <a href="http://purl.org/spar/fabio/ProjectMetadata">fabio:ProjectMetadata</a>
    /// </summary>
    let ProjectMetadata = _prefixId.prefix "ProjectMetadata"
    /// <summary>
    ///   <para>rdfs:label : project plan</para>
    ///   <para>rdfs:comment : A document used to guide project planning, execution and control, specifying the project's goal and objectives and the activities and resources required to achieve these, setting out the project schedule, and identifying the major workpackages, milestones and deliverables.  A project plan will typically contain a Gantt chart.
    /// </para>
    ///   <a href="http://purl.org/spar/fabio/ProjectPlan">fabio:ProjectPlan</a>
    /// </summary>
    let ProjectPlan = _prefixId.prefix "ProjectPlan"
    /// <summary>
    ///   <para>rdfs:comment : A report describing the outcomes of specific project, typically listing 'deliverables' created or 'milestones' achieved during the project.</para>
    ///   <para>rdfs:label : deliverable report</para>
    ///   <a href="http://purl.org/spar/fabio/ProjectReport">fabio:ProjectReport</a>
    /// </summary>
    let ProjectReport = _prefixId.prefix "ProjectReport"
    /// <summary>
    ///   <para>rdfs:label : deliverable</para>
    ///   <para>rdfs:comment : A document containing a project report, intended to be delivered to a customer or funding agency describing the results achieved within a specific project. </para>
    ///   <a href="http://purl.org/spar/fabio/ProjectReportDocument">fabio:ProjectReportDocument</a>
    /// </summary>
    let ProjectReportDocument = _prefixId.prefix "ProjectReportDocument"
    /// <summary>
    ///   <para>rdfs:label : proof</para>
    ///   <para>rdfs:comment : In printing and publishing, a proof copy is the preliminary version of a publication, after the inclusion of any author corrections following review, and after copy editing and formatting to bring the manuscript into the house style, intended for final checking prior to publication to detect and eliminate typographical errors, omissions or transpositions of text, incorrect layout or placement of illustrations and tables, or other formatting errors.  Those who check proofs include the editor, possibly the peer-reviewers (to ensure that their requested modifications have been included to their satisfaction), possibly an in-house professional proof-reader, and / or the author, who is ultimately responsible for ensuring the published work says what (s)he means it to say.  Substantive changes to the text are not permitted once the manuscript has reached proof stage.</para>
    ///   <a href="http://purl.org/spar/fabio/Proof">fabio:Proof</a>
    /// </summary>
    let Proof = _prefixId.prefix "Proof"
    /// <summary>
    ///   <para>rdfs:label : proposition</para>
    ///   <para>rdfs:comment : A proposal or proposition of a new conceptualization, hypothesis, idea, theory, activity or organisation.</para>
    ///   <a href="http://purl.org/spar/fabio/Proposition">fabio:Proposition</a>
    /// </summary>
    let Proposition = _prefixId.prefix "Proposition"
    /// <summary>
    ///   <para>rdfs:label : questionnaire</para>
    ///   <para>rdfs:comment : A set of questions on a particular topic, usually in the form of multiple choice questions requiring the respondent to select the correct answer, or providing the ability to indicate support for or against a proposal on a numerical scale, designed for rapid numerical analysis of responses and often used in surveying public opinion.</para>
    ///   <a href="http://purl.org/spar/fabio/Questionnaire">fabio:Questionnaire</a>
    /// </summary>
    let Questionnaire = _prefixId.prefix "Questionnaire"
    /// <summary>
    ///   <para>dce:description : A quotation is a repetition of what someone has said, and is presented "within quotation marks", for example:
    ///
    /// On June 4th 1940, Winston Churchill made a speech on the radio that has since become famous, that included the words:
    ///        " . . . we shall fight on the beaches, we shall fight on the landing grounds, we shall fight in the fields and in the streets, we shall fight in the hills; we shall never surrender . . ."
    ///
    /// Similarly, the words "but Brutus is an honourable man" from Mark Antony's funeral speech in Shakespeare's play Julius Caesar is a quotation, since Mark Antony says these words in the play.</para>
    ///   <para>rdfs:comment : A passage of speech selected from a larger verbal or written expression for use in another expression, with specific attribution to its original source, and usually demarcated by quotation marks and / or by placing it in a separate indented paragraph.
    ///
    /// [Note: Use fabio:Quotation to indicate a segment or passage selected from another expression that is a passage of speech, and fabio:Excerpt to indicate a segment or passage selected from another expression that is not a passage of speech.]</para>
    ///   <para>rdfs:label : quotation</para>
    ///   <a href="http://purl.org/spar/fabio/Quotation">fabio:Quotation</a>
    /// </summary>
    let Quotation = _prefixId.prefix "Quotation"
    /// <summary>
    ///   <para>rdfs:comment : A short rapidly published research article or conference paper, typically reporting significant research results that have been recently discovered, or a brief news item reporting such discoveries.</para>
    ///   <para>rdfs:label : rapid communication</para>
    ///   <a href="http://purl.org/spar/fabio/RapidCommunication">fabio:RapidCommunication</a>
    /// </summary>
    let RapidCommunication = _prefixId.prefix "RapidCommunication"
    /// <summary>
    ///   <para>rdfs:comment : A book containing authoritative factual information, such as a dictionary, encyclopaedia, handbook or field guide, which is a realisation of a certain reference work and may contain several reference entries.</para>
    ///   <para>rdfs:label : reference book</para>
    ///   <a href="http://purl.org/spar/fabio/ReferenceBook">fabio:ReferenceBook</a>
    /// </summary>
    let ReferenceBook = _prefixId.prefix "ReferenceBook"
    /// <summary>
    ///   <para>rdfs:label : reference entry</para>
    ///   <para>rdfs:comment : A particular reference entry containing authoritative factual information on a certain topic, usually contained in a larger expression.</para>
    ///   <a href="http://purl.org/spar/fabio/ReferenceEntry">fabio:ReferenceEntry</a>
    /// </summary>
    let ReferenceEntry = _prefixId.prefix "ReferenceEntry"
    /// <summary>
    ///   <para>rdfs:label : reference work</para>
    ///   <para>rdfs:comment : A work to which people refer for authoritative factual information, such as a dictionary, encyclopaedia, entry, handbook or field guide, or an informative web page such as an institutional, research group or project home page.</para>
    ///   <a href="http://purl.org/spar/fabio/ReferenceWork">fabio:ReferenceWork</a>
    /// </summary>
    let ReferenceWork = _prefixId.prefix "ReferenceWork"
    /// <summary>
    ///   <para>rdfs:comment : A database in which the data are arranged in tables according to their common characteristics, with relationships between the tables being defined by a relational model or schema. A relational database is highly optimized for performance, and is queried using a database query language such as SQL (Structured Query Language).  The software used to create a relational database is called a relational database management system (RDBMS).</para>
    ///   <para>rdfs:label : relational database</para>
    ///   <a href="http://purl.org/spar/fabio/RelationalDatabase">fabio:RelationalDatabase</a>
    /// </summary>
    let RelationalDatabase = _prefixId.prefix "RelationalDatabase"
    /// <summary>
    ///   <para>rdfs:comment : A work that is a reply, either to a letter or other direct communication, or to feedback or comments about a piece of submitted writing.  The latter is typically written by the author of a journal article submitted for publication, or by an applicant making a grant application, in response to reviews of the work from peer reviewers prior to publication (for the journal article) or prior to funding decision (for the grant application).  Alternatively, it can be written in response to post-publication peer-review of a published journal article, or comments about it.</para>
    ///   <para>rdfs:label : reply</para>
    ///   <a href="http://purl.org/spar/fabio/Reply">fabio:Reply</a>
    /// </summary>
    let Reply = _prefixId.prefix "Reply"
    /// <summary>
    ///   <para>rdfs:comment : A formal factual, methodological, statistical, technical or research report issued by an individual, group, agency, government body or other institution.</para>
    ///   <para>rdfs:label : report</para>
    ///   <a href="http://purl.org/spar/fabio/Report">fabio:Report</a>
    /// </summary>
    let Report = _prefixId.prefix "Report"
    /// <summary>
    ///   <para>rdfs:label : report document</para>
    ///   <para>rdfs:comment : The realization of a report, usually in printed form.</para>
    ///   <a href="http://purl.org/spar/fabio/ReportDocument">fabio:ReportDocument</a>
    /// </summary>
    let ReportDocument = _prefixId.prefix "ReportDocument"
    /// <summary>
    ///   <para>rdfs:label : reporting standard</para>
    ///   <para>rdfs:comment : A set of recommendations for the minimum reporting requirements to be employed when reporting a particular type of investigation or project, for example a randomized clinical trial.  A reporting standard may involve a checklist and a flow diagram, offers a standard way for authors to prepare a complete and transparent report of their findings, and aids their critical appraisal and interpretation of their data. [See also fabio:MinimalInformationStandard.]</para>
    ///   <a href="http://purl.org/spar/fabio/ReportingStandard">fabio:ReportingStandard</a>
    /// </summary>
    let ReportingStandard = _prefixId.prefix "ReportingStandard"
    /// <summary>
    ///   <para>rdfs:label : repository</para>
    ///   <para>rdfs:comment : A computer system in which information may be stored.</para>
    ///   <a href="http://purl.org/spar/fabio/Repository">fabio:Repository</a>
    /// </summary>
    let Repository = _prefixId.prefix "Repository"
    /// <summary>
    ///   <para>rdfs:label : research paper</para>
    ///   <para>rdfs:comment : A scholarly work that reports original research contributions addressing theoretical, analytical or experimental aspects of a particular scholarly domain.
    ///
    /// E.g. see http://iswc2018.semanticweb.org/call-for-research-track-papers/.</para>
    ///   <a href="http://purl.org/spar/fabio/ResearchPaper">fabio:ResearchPaper</a>
    /// </summary>
    let ResearchPaper = _prefixId.prefix "ResearchPaper"
    /// <summary>
    ///   <para>rdfs:label : resource paper</para>
    ///   <para>rdfs:comment : A scholarly work that describes resources developed to provide experimental materials or facilities, support a research hypothesis, to provide answers to a research question, or that have contributed to the generation of novel scientific work. Examples of such resources include, for experimental sciences, mouse mutant lines and large communally used X-ray or neutron sources, and, for computer sciences, datasets, ontologies, vocabularies, ontology design patterns, evaluation benchmarks or methods, services, APIs and software frameworks, workflows, crowdsourcing task designs, protocols and metrics.
    ///
    /// E.g. see http://iswc2018.semanticweb.org/call-for-resources-track-papers/</para>
    ///   <a href="http://purl.org/spar/fabio/ResourcePaper">fabio:ResourcePaper</a>
    /// </summary>
    let ResourcePaper = _prefixId.prefix "ResourcePaper"
    /// <summary>
    ///   <para>rdfs:label : retraction</para>
    ///   <para>rdfs:comment : A formal statement retracting a statement or publication
    /// A retraction is a public statement made about an earlier statement that withdraws, cancels, refutes, diametrically reverses the original statement or ceases and desists from publishing the original statement. </para>
    ///   <a href="http://purl.org/spar/fabio/Retraction">fabio:Retraction</a>
    /// </summary>
    let Retraction = _prefixId.prefix "Retraction"
    /// <summary>
    ///   <para>rdfs:comment : A review of others' work.</para>
    ///   <para>rdfs:label : review</para>
    ///   <a href="http://purl.org/spar/fabio/Review">fabio:Review</a>
    /// </summary>
    let Review = _prefixId.prefix "Review"
    /// <summary>
    ///   <para>rdfs:comment : An article that contains a review.</para>
    ///   <para>rdfs:label : review article</para>
    ///   <a href="http://purl.org/spar/fabio/ReviewArticle">fabio:ReviewArticle</a>
    /// </summary>
    let ReviewArticle = _prefixId.prefix "ReviewArticle"
    /// <summary>
    ///   <para>rdfs:comment : A scholarly work that surveys the state of the art of topics central to a particular subject or relating to a specific domain (e.g. the scope of a certain journal or conference). Papers of this kind may contain a selective bibliography listing key papers related to the subject or providing advice on information sources, or they may strive to be comprehensive, covering all contributions to the development of a topic and exploring their different findings or views.
    ///
    /// E.g. see http://www.emeraldgrouppublishing.com/products/journals/author_guidelines.htm?id=JD</para>
    ///   <para>rdfs:label : review paper</para>
    ///   <a href="http://purl.org/spar/fabio/ReviewPaper">fabio:ReviewPaper</a>
    /// </summary>
    let ReviewPaper = _prefixId.prefix "ReviewPaper"
    /// <summary>
    ///   <para>rdfs:label : scholarly work</para>
    ///   <para>rdfs:comment : A work that reports scholarly activity on a particular topic, either published in written form, or delivered orally at a meeting.</para>
    ///   <a href="http://purl.org/spar/fabio/ScholarlyWork">fabio:ScholarlyWork</a>
    /// </summary>
    let ScholarlyWork = _prefixId.prefix "ScholarlyWork"
    /// <summary>
    ///   <para>rdfs:label : screenplay</para>
    ///   <para>rdfs:comment : A written work made especially for a film or television program. Screenplays can be original works or adaptations from existing pieces of writing, for example novels. </para>
    ///   <a href="http://purl.org/spar/fabio/Screenplay">fabio:Screenplay</a>
    /// </summary>
    let Screenplay = _prefixId.prefix "Screenplay"
    /// <summary>
    ///   <para>rdfs:label : script</para>
    ///   <para>rdfs:comment : A small computer program written in a scripting language such as JavaScript, PHP or Perl that allows control of one or more software applications.</para>
    ///   <a href="http://purl.org/spar/fabio/Script">fabio:Script</a>
    /// </summary>
    let Script = _prefixId.prefix "Script"
    /// <summary>
    ///   <para>rdfs:label : series</para>
    ///   <para>rdfs:comment : A sequence of expressions having certain characteristics in common that are formally identified together as a group.</para>
    ///   <a href="http://purl.org/spar/fabio/Series">fabio:Series</a>
    /// </summary>
    let Series = _prefixId.prefix "Series"
    /// <summary>
    ///   <para>rdfs:label : short story</para>
    ///   <para>rdfs:comment : A work of fiction that is usually written in prose, often in narrative format. This format tends to be more focused and less elaborate than longer works of fiction such as novels.</para>
    ///   <a href="http://purl.org/spar/fabio/ShortStory">fabio:ShortStory</a>
    /// </summary>
    let ShortStory = _prefixId.prefix "ShortStory"
    /// <summary>
    ///   <para>rdfs:label : song</para>
    ///   <para>rdfs:comment : A musical composition that contains vocal parts ('lyrics') that are performed ('sung').</para>
    ///   <a href="http://purl.org/spar/fabio/Song">fabio:Song</a>
    /// </summary>
    let Song = _prefixId.prefix "Song"
    /// <summary>
    ///   <para>rdfs:label : sound recording</para>
    ///   <para>rdfs:comment : The creative work of making an electrical or mechanical recording of sounds, such as the spoken voice, singing, instrumental music, animal vocalizations or sound effects. </para>
    ///   <a href="http://purl.org/spar/fabio/SoundRecording">fabio:SoundRecording</a>
    /// </summary>
    let SoundRecording = _prefixId.prefix "SoundRecording"
    /// <summary>
    ///   <para>rdfs:comment : An explicit description of, or set of requirements to be satisfied by, a material, product, resource, service or standard.</para>
    ///   <para>rdfs:label : specification</para>
    ///   <a href="http://purl.org/spar/fabio/Specification">fabio:Specification</a>
    /// </summary>
    let Specification = _prefixId.prefix "Specification"
    /// <summary>
    ///   <para>rdfs:label : specification document</para>
    ///   <para>rdfs:comment : The realization of a specification (a standard, a workflow, etc.).</para>
    ///   <a href="http://purl.org/spar/fabio/SpecificationDocument">fabio:SpecificationDocument</a>
    /// </summary>
    let SpecificationDocument = _prefixId.prefix "SpecificationDocument"
    /// <summary>
    ///   <para>rdfs:label : spreadsheet</para>
    ///   <para>rdfs:comment : An electronic form of data storage that displays a grid of rows and columns, in which each editable cell can contain alphanumeric text, a numeric value, or a formula that defines how the content of that cell is to be calculated from the content of another cell or cells.</para>
    ///   <a href="http://purl.org/spar/fabio/Spreadsheet">fabio:Spreadsheet</a>
    /// </summary>
    let Spreadsheet = _prefixId.prefix "Spreadsheet"
    /// <summary>
    ///   <para>rdfs:comment : Clear and detailed written instructions of a prescribed step-by-step procedure to be routinely followed, and decisions to be made when undertaking a specific task, process or function, to achieve consistent performance, ensure safety and/or assure data quality.  (Commonly abbreviated 'SOP'.)</para>
    ///   <para>rdfs:label : standard operating procedure</para>
    ///   <a href="http://purl.org/spar/fabio/StandardOperatingProcedure">fabio:StandardOperatingProcedure</a>
    /// </summary>
    let StandardOperatingProcedure = _prefixId.prefix "StandardOperatingProcedure"
    /// <summary>
    ///   <para>rdfs:comment : A recorded static visual representation. This class of image includes diagrams, drawings, graphs, graphic designs, plans, maps, photographs and prints.</para>
    ///   <para>rdfs:label : still image</para>
    ///   <a href="http://purl.org/spar/fabio/StillImage">fabio:StillImage</a>
    /// </summary>
    let StillImage = _prefixId.prefix "StillImage"
    /// <summary>
    ///   <para>rdfs:comment : A device for recording information or storing data.</para>
    ///   <para>rdfs:label : storage medium</para>
    ///   <a href="http://purl.org/spar/fabio/StorageMedium">fabio:StorageMedium</a>
    /// </summary>
    let StorageMedium = _prefixId.prefix "StorageMedium"
    /// <summary>
    ///   <para>rdfs:label : structured summary</para>
    ///   <para>rdfs:comment : A structured summary containing essential metadata describing a research investigation and/or the research outputs that have resulted from it, for example datasets and journal articles, structured according to some minimal information standard.  Such a structured summary can be embodied in both human-readable and machine-readable manifestations, e.g. HTML and RDF.  Such a structured summary differs from the Abstract of a journal article, in that the latter is written as a piece of continuous prose, but typically omits vital factual information about the investigation, such as when and where it was conducted, by whom, and on now many specimens or subjects.</para>
    ///   <a href="http://purl.org/spar/fabio/StructuredSummary">fabio:StructuredSummary</a>
    /// </summary>
    let StructuredSummary = _prefixId.prefix "StructuredSummary"
    /// <summary>
    ///   <para>rdfs:comment : A concept that identifies a field of knowledge or human activity defined in a controlled vocabulary, such as Computer Science, Biology, Economics, Cookery or Swimming.</para>
    ///   <para>rdfs:label : subject discipline</para>
    ///   <a href="http://purl.org/spar/fabio/SubjectDiscipline">fabio:SubjectDiscipline</a>
    /// </summary>
    let SubjectDiscipline = _prefixId.prefix "SubjectDiscipline"
    /// <summary>
    ///   <para>rdfs:comment : A concept that defines a term within the controlled vocabulary of a particular classification system, such as the ACM Computing Classification System or MeSH, the Medical Subject Headings, used as an annotation to describe the subject, meaning or content of an entity.</para>
    ///   <para>rdfs:label : subject term</para>
    ///   <a href="http://purl.org/spar/fabio/SubjectTerm">fabio:SubjectTerm</a>
    /// </summary>
    let SubjectTerm = _prefixId.prefix "SubjectTerm"
    /// <summary>
    ///   <para>rdfs:comment : A supplement to a publication such as a book, journal, magazine or newspaper, additional to the main publication.  For example, a colour supplement to a sunday newspaper, or a special supplementary issue of a journal or a journal volume containing invited articles on a special topic, or abstracts or papers presented at a scientific conference.</para>
    ///   <para>rdfs:label : supplement</para>
    ///   <a href="http://purl.org/spar/fabio/Supplement">fabio:Supplement</a>
    /// </summary>
    let Supplement = _prefixId.prefix "Supplement"
    /// <summary>
    ///   <para>rdfs:label : supplementary information file</para>
    ///   <para>rdfs:comment : A file accompanying a published journal article, containing additional information of relevance to the article, typically available from the publisher's web site via a hyperlink from the journal article itself.</para>
    ///   <a href="http://purl.org/spar/fabio/SupplementaryInformation">fabio:SupplementaryInformation</a>
    /// </summary>
    let SupplementaryInformation = _prefixId.prefix "SupplementaryInformation"
    let SupplementaryInformationFile = _prefixId.prefix "SupplementaryInformationFile"
    /// <summary>
    ///   <para>rdfs:label : systematic review</para>
    ///   <para>rdfs:comment : A literature review focused on a single question that tries to identify, appraise, select and synthesize all high quality research evidence relevant to that question. Systematic reviews of high-quality randomized controlled trials are crucial to evidence-based medicine. An understanding of systematic reviews and how to implement them in practice is becoming mandatory for all professionals involved in the delivery of health care. Systematic reviews are not limited to medicine,  and are quite common in other sciences such as psychology, educational research and sociology.</para>
    ///   <a href="http://purl.org/spar/fabio/SystematicReview">fabio:SystematicReview</a>
    /// </summary>
    let SystematicReview = _prefixId.prefix "SystematicReview"
    /// <summary>
    ///   <para>rdfs:comment : A graphical means of presenting data in a grid of rows and columns, within which the cells usually contain alphanumeric text or numeric values.  If included within a publication, a table typically appearing unaligned with the main body of text, with its own descriptive title.</para>
    ///   <para>rdfs:label : table</para>
    ///   <a href="http://purl.org/spar/fabio/Table">fabio:Table</a>
    /// </summary>
    let Table = _prefixId.prefix "Table"
    /// <summary>
    ///   <para>rdfs:label : table of contents</para>
    ///   <para>rdfs:comment : A table listing the parts of publication such as a book or technical specification, and the pages on which these content elements start (if the publication is printed or otherwise organized into pages), usually listed in order of appearance.  The Table of Contents typically includes first-level headers, such as the chapter titles of a book, and may also include second- and even third-level headers.  In electronic works, the Table of Contents entries are often internally hyperlinked to the content items, so that clicking on the entry takes the reader to that item.</para>
    ///   <a href="http://purl.org/spar/fabio/TableOfContents">fabio:TableOfContents</a>
    /// </summary>
    let TableOfContents = _prefixId.prefix "TableOfContents"
    /// <summary>
    ///   <para>rdfs:comment : A classification arranged in a hierarchical structure of classes and subclasses, showing parent-child isA relationships, or broader_than - narrower_than relationships.</para>
    ///   <para>rdfs:label : taxonomy</para>
    ///   <a href="http://purl.org/spar/fabio/Taxonomy">fabio:Taxonomy</a>
    /// </summary>
    let Taxonomy = _prefixId.prefix "Taxonomy"
    /// <summary>
    ///   <para>rdfs:label : technical report</para>
    ///   <para>rdfs:comment : A report of a technical nature.</para>
    ///   <a href="http://purl.org/spar/fabio/TechnicalReport">fabio:TechnicalReport</a>
    /// </summary>
    let TechnicalReport = _prefixId.prefix "TechnicalReport"
    /// <summary>
    ///   <para>rdfs:label : technical standard</para>
    ///   <para>rdfs:comment : An official or public specification of, or requirement for, a technical method, practice, process or protocol that is involved in, for example, manufacturing, computation, electronic communication, or digital media.</para>
    ///   <a href="http://purl.org/spar/fabio/TechnicalStandard">fabio:TechnicalStandard</a>
    /// </summary>
    let TechnicalStandard = _prefixId.prefix "TechnicalStandard"
    /// <summary>
    ///   <para>dce:description : A term dictionary is a collection of subject terms.</para>
    ///   <para>rdfs:label : term dictionary</para>
    ///   <para>rdfs:comment : A controlled vocabulary, usually referring to terms within a particular classification system, such as the ACM Computing Classification System or MeSH, the Medical Subject Headings, or a controlled vocabulary of disciplines.</para>
    ///   <a href="http://purl.org/spar/fabio/TermDictionary">fabio:TermDictionary</a>
    /// </summary>
    let TermDictionary = _prefixId.prefix "TermDictionary"
    /// <summary>
    ///   <para>rdfs:label : textbook</para>
    ///   <para>rdfs:comment : A book containing instructional material relating to a particular topic of academic study, designed to be read by students.</para>
    ///   <a href="http://purl.org/spar/fabio/Textbook">fabio:Textbook</a>
    /// </summary>
    let Textbook = _prefixId.prefix "Textbook"
    /// <summary>
    ///   <para>rdfs:comment : A type of controlled vocabulary used in information retrieval applications for indexing or tagging purposes, in which relationships between terms are made explicit. These are normally hierarchical relationships (is-a, subsumption; e.g. a cow is a mammal), equivalency relationships relating non-preferred terms to preferred terms (e.g. pitch and frequency), or associative relationships, in which the relationship that exists is neither one of hierarchy or equivalence, but rather one of similarity (e.g. sports and leisure pursuits).</para>
    ///   <para>rdfs:label : thesaurus</para>
    ///   <a href="http://purl.org/spar/fabio/Thesaurus">fabio:Thesaurus</a>
    /// </summary>
    let Thesaurus = _prefixId.prefix "Thesaurus"
    /// <summary>
    ///   <para>rdfs:label : thesis</para>
    ///   <para>rdfs:comment : A book authored by a student containing a formal presentations of research outputs submitted for examination in completion of a course of study at an institution of higher education, to fulfil the requirements for an academic degree.  Also know as a dissertation.  [For the alternative meaning of the word 'thesis', namely the formulation of a concept, hypothesis, idea, point of view or theory presented for review and/or discussion, use fabio:Proposition.]</para>
    ///   <a href="http://purl.org/spar/fabio/Thesis">fabio:Thesis</a>
    /// </summary>
    let Thesis = _prefixId.prefix "Thesis"
    /// <summary>
    ///   <para>rdfs:comment : A tabular dataset providing information about the times and locations of a planned series of events.</para>
    ///   <para>rdfs:label : timetable</para>
    ///   <a href="http://purl.org/spar/fabio/Timetable">fabio:Timetable</a>
    /// </summary>
    let Timetable = _prefixId.prefix "Timetable"
    /// <summary>
    ///   <para>rdfs:label : trial report</para>
    ///   <para>rdfs:comment : The report of a trial, for example an experimental trial or a legal trial.</para>
    ///   <a href="http://purl.org/spar/fabio/TrialReport">fabio:TrialReport</a>
    /// </summary>
    let TrialReport = _prefixId.prefix "TrialReport"
    /// <summary>
    ///   <para>rdfs:label : triplestore</para>
    ///   <para>rdfs:comment : A database specifically designed for the storage and retrieval of Resource Description Framework (RDF) data consisting of subject-predicate-object triples.  A triple store is queried using the RDF query language SPARQL.</para>
    ///   <a href="http://purl.org/spar/fabio/Triplestore">fabio:Triplestore</a>
    /// </summary>
    let Triplestore = _prefixId.prefix "Triplestore"
    /// <summary>
    ///   <para>rdfs:label : tweet</para>
    ///   <para>rdfs:comment : A posting made on the social networking site Twitter. A tweet is a text message limited to 140 characters in length, that is broadcast and readable by anyone who accesses Twitter.</para>
    ///   <a href="http://purl.org/spar/fabio/Tweet">fabio:Tweet</a>
    /// </summary>
    let Tweet = _prefixId.prefix "Tweet"
    /// <summary>
    ///   <para>rdfs:label : uncontrolled vocabulary</para>
    ///   <para>rdfs:comment : A non-defined collection of words and phrases relating to a particular domain of knowledge, usually added freely by a community, in which homonyms, synonyms and similar ambiguities of meaning present in natural language are not formally disambiguated.</para>
    ///   <a href="http://purl.org/spar/fabio/UncontrolledVocabulary">fabio:UncontrolledVocabulary</a>
    /// </summary>
    let UncontrolledVocabulary = _prefixId.prefix "UncontrolledVocabulary"
    /// <summary>
    ///   <para>rdfs:label : vocabulary</para>
    ///   <para>rdfs:comment : A set of words, either constituting a language, or more specifically used to describe a particular domain of knowledge.</para>
    ///   <a href="http://purl.org/spar/fabio/Vocabulary">fabio:Vocabulary</a>
    /// </summary>
    let Vocabulary = _prefixId.prefix "Vocabulary"
    /// <summary>
    ///   <para>rdfs:comment : A document containing a vocabulary</para>
    ///   <para>rdfs:label : vocabulary document</para>
    ///   <a href="http://purl.org/spar/fabio/VocabularyDocument">fabio:VocabularyDocument</a>
    /// </summary>
    let VocabularyDocument = _prefixId.prefix "VocabularyDocument"
    /// <summary>
    ///   <para>rdfs:label : vocabulary mapping</para>
    ///   <para>rdfs:comment : A mapping of correspondences between two vocabularies.  For controlled vocabularies, such mappings may be expressed using SKOS (http://www.w3.org/2004/02/skos/).</para>
    ///   <a href="http://purl.org/spar/fabio/VocabularyMapping">fabio:VocabularyMapping</a>
    /// </summary>
    let VocabularyMapping = _prefixId.prefix "VocabularyMapping"
    /// <summary>
    ///   <para>rdfs:comment : A document containing a vocabulary mapping</para>
    ///   <para>rdfs:label : vocabulary mapping document</para>
    ///   <a href="http://purl.org/spar/fabio/VocabularyMappingDocument">fabio:VocabularyMappingDocument</a>
    /// </summary>
    let VocabularyMappingDocument = _prefixId.prefix "VocabularyMappingDocument"
    /// <summary>
    ///   <para>rdfs:label : web archive</para>
    ///   <para>rdfs:comment : A snapshots of (part of) the World Wide Web.</para>
    ///   <a href="http://purl.org/spar/fabio/WebArchive">fabio:WebArchive</a>
    /// </summary>
    let WebArchive = _prefixId.prefix "WebArchive"
    /// <summary>
    ///   <para>rdfs:label : web content</para>
    ///   <para>rdfs:comment : Information prepared specifically and primarily for manifestation in a web page, comprising text, images, datasets and/or other works.</para>
    ///   <a href="http://purl.org/spar/fabio/WebContent">fabio:WebContent</a>
    /// </summary>
    let WebContent = _prefixId.prefix "WebContent"
    /// <summary>
    ///   <para>rdfs:label : web manifestation</para>
    ///   <para>rdfs:comment : A digital manifestation on the Web, such as a wiki, a web site, a web page or a blog.</para>
    ///   <a href="http://purl.org/spar/fabio/WebManifestation">fabio:WebManifestation</a>
    /// </summary>
    let WebManifestation = _prefixId.prefix "WebManifestation"
    /// <summary>
    ///   <para>rdfs:label : web page</para>
    ///   <para>rdfs:comment : A Web manifestation usually identified by a Uniform Resource Identifier (URI), and made accessible to a user by means of the Hypertext Transport Protocol (HTTP) in a Web browser window. Several interlinked web pages hosted together on a Web server and accessed through a single domain name or IP address constitute a web site.</para>
    ///   <a href="http://purl.org/spar/fabio/WebPage">fabio:WebPage</a>
    /// </summary>
    let WebPage = _prefixId.prefix "WebPage"
    /// <summary>
    ///   <para>rdfs:comment : A collection of related web pages containing text, images, videos and/or other digital assets that are addressed relative to a common Uniform Resource Locator (URL). A web site is hosted on at least one web server, accessible via a network such as the Internet or a private local area network.</para>
    ///   <para>rdfs:label : web site</para>
    ///   <a href="http://purl.org/spar/fabio/WebSite">fabio:WebSite</a>
    /// </summary>
    let WebSite = _prefixId.prefix "WebSite"
    /// <summary>
    ///   <para>rdfs:comment : An authoritative report or guide designed to educate readers and help people make decisions, or to explain technical problems and how to solve them. White papers are typically published by governments to propose new legislation for discussion, and by commercial companies to inform readers about products or services, as aids to marketing.</para>
    ///   <para>rdfs:label : white paper</para>
    ///   <a href="http://purl.org/spar/fabio/WhitePaper">fabio:WhitePaper</a>
    /// </summary>
    let WhitePaper = _prefixId.prefix "WhitePaper"
    /// <summary>
    ///   <para>rdfs:comment : A collaborative Web manifestation, usually maintained by a project team or group, providing easy-to-edit pages that can be used to accumulate related information for shared use by the group and/or publication.</para>
    ///   <para>rdfs:label : wiki</para>
    ///   <a href="http://purl.org/spar/fabio/Wiki">fabio:Wiki</a>
    /// </summary>
    let Wiki = _prefixId.prefix "Wiki"
    /// <summary>
    ///   <para>rdfs:comment : Information manifested in a wiki. </para>
    ///   <para>rdfs:label : wiki entry</para>
    ///   <a href="http://purl.org/spar/fabio/WikiEntry">fabio:WikiEntry</a>
    /// </summary>
    let WikiEntry = _prefixId.prefix "WikiEntry"
    /// <summary>
    ///   <para>rdfs:label : wikipedia entry</para>
    ///   <para>rdfs:comment : Information about a particular topic in one of the versions of Wikipedia, the online encyclopedia (http://www.wikipedia.org/).
    /// </para>
    ///   <a href="http://purl.org/spar/fabio/WikipediaEntry">fabio:WikipediaEntry</a>
    /// </summary>
    let WikipediaEntry = _prefixId.prefix "WikipediaEntry"
    /// <summary>
    ///   <para>rdfs:label : work</para>
    ///   <para>rdfs:comment : A subclass of FRBR work, restricted to works that are published or potentially publishable, and that contain or are referred to by bibliographic references, or entities used to define bibliographic references. FaBiO works, and their expressions and manifestations, are primarily textual publications such as books, magazines, newspapers and journals, and items of their content.  However, they also include datasets, computer algorithms, experimental protocols, formal specifications and vocabularies, legal records, governmental papers, technical and commercial reports and similar publications, and also bibliographies, reference lists, library catalogues and similar collections. For this reason, fabio:Work is not an equivalent class to frbr:ScholarlyWork.  An example of a fabio:Work is your latest research paper.</para>
    ///   <para>dce:description : A fabio:Work can only have part or be part of another fabio:Work. Moreover, it can be realized only by fabio:Expression(s).</para>
    ///   <a href="http://purl.org/spar/fabio/Work">fabio:Work</a>
    /// </summary>
    let Work = _prefixId.prefix "Work"
    /// <summary>
    ///   <para>rdfs:label : work collection</para>
    ///   <para>dce:creator : A collection of works.</para>
    ///   <a href="http://purl.org/spar/fabio/WorkCollection">fabio:WorkCollection</a>
    /// </summary>
    let WorkCollection = _prefixId.prefix "WorkCollection"
    /// <summary>
    ///   <para>rdfs:comment : A component of the case for support of a grant application, describing a particular aspect of the work to be undertaken.</para>
    ///   <para>rdfs:label : work package</para>
    ///   <a href="http://purl.org/spar/fabio/WorkPackage">fabio:WorkPackage</a>
    /// </summary>
    let WorkPackage = _prefixId.prefix "WorkPackage"
    /// <summary>
    ///   <para>rdfs:label : workflow</para>
    ///   <para>rdfs:comment : A recorded sequence of connected steps, which may be automated, specifying a reliably repeatable sequence of operations to be undertaken when conducting a particular job, for example an in silico investigation that extracts and processes information from a number of bioinformatics databases.</para>
    ///   <a href="http://purl.org/spar/fabio/Workflow">fabio:Workflow</a>
    /// </summary>
    let Workflow = _prefixId.prefix "Workflow"
    /// <summary>
    ///   <para>rdfs:comment : An unpublished paper, usually circulated privately among a small group of peers, to provide information or with a request for comments or editorial improvement.</para>
    ///   <para>rdfs:label : working paper</para>
    ///   <a href="http://purl.org/spar/fabio/WorkingPaper">fabio:WorkingPaper</a>
    /// </summary>
    let WorkingPaper = _prefixId.prefix "WorkingPaper"
    /// <summary>
    ///   <para>rdfs:comment : A paper, typically the realization of a research paper reporting original research findings, usually presented at a workshop and published within a workshop proceedings volume.</para>
    ///   <para>rdfs:label : workshop paper</para>
    ///   <a href="http://purl.org/spar/fabio/WorkshopPaper">fabio:WorkshopPaper</a>
    /// </summary>
    let WorkshopPaper = _prefixId.prefix "WorkshopPaper"
    /// <summary>
    ///   <para>rdfs:label : workshop proceedings</para>
    ///   <para>rdfs:comment : A document containing the programme and collected workshop papers, or their abstracts, presented at a workshop or similar event.</para>
    ///   <a href="http://purl.org/spar/fabio/WorkshopProceedings">fabio:WorkshopProceedings</a>
    /// </summary>
    let WorkshopProceedings = _prefixId.prefix "WorkshopProceedings"
    let analog_magnetic_tape = _prefixId.prefix "analog-magnetic-tape"
    let cd = _prefixId.prefix "cd"
    let cloud = _prefixId.prefix "cloud"
    /// <summary>
    ///   <para>rdfs:label : date last updated</para>
    ///   <para>rdfs:comment : The date on which a particular endeavour, such as an ontology, was last updated.</para>
    ///   <a href="http://purl.org/spar/fabio/dateLastUpdated">fabio:dateLastUpdated</a>
    /// </summary>
    let dateLastUpdated = _prefixId.prefix "dateLastUpdated"
    let digital_magnetic_tape = _prefixId.prefix "digital-magnetic-tape"
    let dvd = _prefixId.prefix "dvd"
    let film = _prefixId.prefix "film"
    let floppy_disk = _prefixId.prefix "floppy-disk"
    let hard_drive = _prefixId.prefix "hard-drive"
    /// <summary>
    ///   <para>rdfs:comment : The date on which a particular digital item, such as a PDF or an HTML file, has been accessed by somebody.</para>
    ///   <para>rdfs:label : has access date</para>
    ///   <a href="http://purl.org/spar/fabio/hasAccessDate">fabio:hasAccessDate</a>
    /// </summary>
    let hasAccessDate = _prefixId.prefix "hasAccessDate"
    /// <summary>
    ///   <para>rdfs:comment : An identifier used by the preprint repository ArXiv.</para>
    ///   <para>rdfs:label : has ArXiv identifier</para>
    ///   <a href="http://purl.org/spar/fabio/hasArXivId">fabio:hasArXivId</a>
    /// </summary>
    let hasArXivId = _prefixId.prefix "hasArXivId"
    /// <summary>
    ///   <para>rdfs:label : has CODEN</para>
    ///   <para>rdfs:comment : A CODEN is a six character, alphanumeric bibliographic identification code, that provides concise, unique and unambiguous identification of the titles of serials and non-serial publications.</para>
    ///   <a href="http://purl.org/spar/fabio/hasCODEN">fabio:hasCODEN</a>
    /// </summary>
    let hasCODEN = _prefixId.prefix "hasCODEN"
    /// <summary>
    ///   <para>rdfs:label : has character count</para>
    ///   <para>rdfs:comment : The count of the number of characters in a textual resource.</para>
    ///   <a href="http://purl.org/spar/fabio/hasCharacterCount">fabio:hasCharacterCount</a>
    /// </summary>
    let hasCharacterCount = _prefixId.prefix "hasCharacterCount"
    /// <summary>
    ///   <para>rdfs:comment : The year in which an entity has been copyrighted.</para>
    ///   <para>rdfs:label : has copyright year</para>
    ///   <a href="http://purl.org/spar/fabio/hasCopyrightYear">fabio:hasCopyrightYear</a>
    /// </summary>
    let hasCopyrightYear = _prefixId.prefix "hasCopyrightYear"
    /// <summary>
    ///   <para>rdfs:comment : The date on which something, for example a document, is corrected.</para>
    ///   <para>rdfs:label : has correction date</para>
    ///   <a href="http://purl.org/spar/fabio/hasCorrectionDate">fabio:hasCorrectionDate</a>
    /// </summary>
    let hasCorrectionDate = _prefixId.prefix "hasCorrectionDate"
    /// <summary>
    ///   <para>rdfs:comment : The date on which some item has been collected, for example the data gathered by means of questionnaires.</para>
    ///   <para>rdfs:label : has date collected</para>
    ///   <a href="http://purl.org/spar/fabio/hasDateCollected">fabio:hasDateCollected</a>
    /// </summary>
    let hasDateCollected = _prefixId.prefix "hasDateCollected"
    /// <summary>
    ///   <para>rdfs:comment : The date on which some item is received, for example a document being received by a publisher.</para>
    ///   <para>rdfs:label : has date received</para>
    ///   <a href="http://purl.org/spar/fabio/hasDateReceived">fabio:hasDateReceived</a>
    /// </summary>
    let hasDateReceived = _prefixId.prefix "hasDateReceived"
    /// <summary>
    ///   <para>rdfs:label : has deadline</para>
    ///   <para>rdfs:comment : A date by which something has to be done.</para>
    ///   <a href="http://purl.org/spar/fabio/hasDeadline">fabio:hasDeadline</a>
    /// </summary>
    let hasDeadline = _prefixId.prefix "hasDeadline"
    /// <summary>
    ///   <para>rdfs:comment : The date on which a particular endeavour, such as a grant application, has been or will be approved or rejected by somebody.</para>
    ///   <para>rdfs:label : has decision date</para>
    ///   <a href="http://purl.org/spar/fabio/hasDecisionDate">fabio:hasDecisionDate</a>
    /// </summary>
    let hasDecisionDate = _prefixId.prefix "hasDecisionDate"
    /// <summary>
    ///   <para>rdfs:label : has deposit date</para>
    ///   <para>rdfs:comment : The date on which an entity has been deposited, for example in a library, repository, supplementary information archive, database or similar place of document or information storage.</para>
    ///   <a href="http://purl.org/spar/fabio/hasDepositDate">fabio:hasDepositDate</a>
    /// </summary>
    let hasDepositDate = _prefixId.prefix "hasDepositDate"
    /// <summary>
    ///   <para>rdfs:comment : The discipline to which a subject vocabulary belongs.</para>
    ///   <para>rdfs:label : has discipline</para>
    ///   <a href="http://purl.org/spar/fabio/hasDiscipline">fabio:hasDiscipline</a>
    /// </summary>
    let hasDiscipline = _prefixId.prefix "hasDiscipline"
    /// <summary>
    ///   <para>rdfs:label : has preprint dissemination date</para>
    ///   <para>rdfs:comment : The date on which something is distributed, for example the date on which a preprint of a document is e-mailed to colleagues and other academics by the author(s), or the date on which a printed announcement of forthcoming theatre events is mailed to those those on the theatre's mailing list.</para>
    ///   <a href="http://purl.org/spar/fabio/hasDistributionDate">fabio:hasDistributionDate</a>
    /// </summary>
    let hasDistributionDate = _prefixId.prefix "hasDistributionDate"

    /// <summary>
    ///   <para>rdfs:comment : A local identifier for an article within an electronic (i.e. on line, in HTML format) periodical issue.  Use in preference to prism:startingPage when the article lacks page numbers</para>
    ///   <para>rdfs:label : has electronic article identifier</para>
    ///   <a href="http://purl.org/spar/fabio/hasElectronicArticleIdentifier">fabio:hasElectronicArticleIdentifier</a>
    /// </summary>
    let hasElectronicArticleIdentifier =
        _prefixId.prefix "hasElectronicArticleIdentifier"

    /// <summary>
    ///   <para>rdfs:label : has embargo date</para>
    ///   <para>rdfs:comment : The date before which an entity should not be published, or before which a press release should not be reported on.  For open-access journal articles, the embargo date is the date before which availability of the open-access version of the article is restricted by the publisher, following subscription-access availability of the published work.  The duration of the embargo period can be specified by fabio:hasEmbargoDuration.</para>
    ///   <a href="http://purl.org/spar/fabio/hasEmbargoDate">fabio:hasEmbargoDate</a>
    /// </summary>
    let hasEmbargoDate = _prefixId.prefix "hasEmbargoDate"
    /// <summary>
    ///   <para>rdfs:comment : The time period for which an entity is embargoed.  During this period, the entity should not be published or, in the case of a press release, should not be reported on.  For open-access journal articles, the embargo duration specifies that period of time during which availability of the open-access version of the article is delayed by the publisher, following subscription-access availability of the published work.  The end of the embargo period can be specified by fabio:hasEmbargoDate.</para>
    ///   <para>rdfs:label : has embargo period</para>
    ///   <a href="http://purl.org/spar/fabio/hasEmbargoDuration">fabio:hasEmbargoDuration</a>
    /// </summary>
    let hasEmbargoDuration = _prefixId.prefix "hasEmbargoDuration"
    /// <summary>
    ///   <para>rdfs:label : has handle</para>
    ///   <para>rdfs:comment : A persistent identifier of the Handel system for digital objects and other resources on the Internet.</para>
    ///   <a href="http://purl.org/spar/fabio/hasHandle">fabio:hasHandle</a>
    /// </summary>
    let hasHandle = _prefixId.prefix "hasHandle"
    /// <summary>
    ///   <para>rdfs:comment : A linking International Standard Serial Number.</para>
    ///   <para>rdfs:label : has ISSN-L</para>
    ///   <a href="http://purl.org/spar/fabio/hasIssnL">fabio:hasIssnL</a>
    /// </summary>
    let hasIssnL = _prefixId.prefix "hasIssnL"
    /// <summary>
    ///   <para>rdfs:label : has manifestation</para>
    ///   <para>rdfs:comment : A property linking a particular work to its manifestations.  This property is additional to the relationships between FRBR endeavours present in the classical FRBR data model.</para>
    ///   <a href="http://purl.org/spar/fabio/hasManifestation">fabio:hasManifestation</a>
    /// </summary>
    let hasManifestation = _prefixId.prefix "hasManifestation"

    /// <summary>
    ///   <para>rdfs:comment : An internal identifier for the abbreviation of the title of journals available from the National Library of Medicine repository.</para>
    ///   <para>rdfs:label : has National Library of Medicine journal title abbreviation</para>
    ///   <a href="http://purl.org/spar/fabio/hasNLMJournalTitleAbbreviation">fabio:hasNLMJournalTitleAbbreviation</a>
    /// </summary>
    let hasNLMJournalTitleAbbreviation =
        _prefixId.prefix "hasNLMJournalTitleAbbreviation"

    /// <summary>
    ///   <para>rdfs:label : has National Library of Medicine journal identifier</para>
    ///   <para>rdfs:comment : An internal identifier for journals available from the National Library of Medicine repository.</para>
    ///   <a href="http://purl.org/spar/fabio/hasNationalLibraryOfMedicineJournalId">fabio:hasNationalLibraryOfMedicineJournalId</a>
    /// </summary>
    let hasNationalLibraryOfMedicineJournalId =
        _prefixId.prefix "hasNationalLibraryOfMedicineJournalId"

    /// <summary>
    ///   <para>rdfs:label : has PII</para>
    ///   <para>rdfs:comment : Has Publisher Item Identifier</para>
    ///   <a href="http://purl.org/spar/fabio/hasPII">fabio:hasPII</a>
    /// </summary>
    let hasPII = _prefixId.prefix "hasPII"
    /// <summary>
    ///   <para>rdfs:label : has page count</para>
    ///   <para>rdfs:comment : The count of the number of pages in a textual resource.</para>
    ///   <a href="http://purl.org/spar/fabio/hasPageCount">fabio:hasPageCount</a>
    /// </summary>
    let hasPageCount = _prefixId.prefix "hasPageCount"
    /// <summary>
    ///   <para>rdfs:comment : A unique identifing number issued by a patent authority to identify a patent, displayed at the beginning of the patent document.</para>
    ///   <para>rdfs:label : has patent number</para>
    ///   <a href="http://purl.org/spar/fabio/hasPatentNumber">fabio:hasPatentNumber</a>
    /// </summary>
    let hasPatentNumber = _prefixId.prefix "hasPatentNumber"
    /// <summary>
    ///   <para>rdfs:label : has place of publication</para>
    ///   <para>rdfs:comment : The place (usually, the city) where the publisher of a particular bibliographic resource is located.</para>
    ///   <a href="http://purl.org/spar/fabio/hasPlaceOfPublication">fabio:hasPlaceOfPublication</a>
    /// </summary>
    let hasPlaceOfPublication = _prefixId.prefix "hasPlaceOfPublication"
    /// <summary>
    ///   <para>rdfs:label : has portrayal</para>
    ///   <para>rdfs:comment : A property linking a particular work to its items.  This property is additional to the relationships between FRBR endeavours present in the classical FRBR data model.</para>
    ///   <a href="http://purl.org/spar/fabio/hasPortrayal">fabio:hasPortrayal</a>
    /// </summary>
    let hasPortrayal = _prefixId.prefix "hasPortrayal"
    /// <summary>
    ///   <para>rdfs:label : has primary subject term</para>
    ///   <para>rdfs:comment : This property is used to associate a frbr:Endeavour to a term in a particular classification system - and the term is considered one of the main topics for the endeavour in consideration.</para>
    ///   <a href="http://purl.org/spar/fabio/hasPrimarySubjectTerm">fabio:hasPrimarySubjectTerm</a>
    /// </summary>
    let hasPrimarySubjectTerm = _prefixId.prefix "hasPrimarySubjectTerm"
    /// <summary>
    ///   <para>rdfs:label : has PubMed Central identifier</para>
    ///   <para>rdfs:comment : An identifier for bibliographic entities hosted by the PubMed Central repository.</para>
    ///   <a href="http://purl.org/spar/fabio/hasPubMedCentralId">fabio:hasPubMedCentralId</a>
    /// </summary>
    let hasPubMedCentralId = _prefixId.prefix "hasPubMedCentralId"
    /// <summary>
    ///   <para>rdfs:comment : An identifier for bibliographic records held by the PubMed repository.</para>
    ///   <para>rdfs:label : has PubMed identifier</para>
    ///   <a href="http://purl.org/spar/fabio/hasPubMedId">fabio:hasPubMedId</a>
    /// </summary>
    let hasPubMedId = _prefixId.prefix "hasPubMedId"
    /// <summary>
    ///   <para>rdfs:comment : The year in which a resource is published.</para>
    ///   <para>rdfs:label : has publication year</para>
    ///   <a href="http://purl.org/spar/fabio/hasPublicationYear">fabio:hasPublicationYear</a>
    /// </summary>
    let hasPublicationYear = _prefixId.prefix "hasPublicationYear"
    /// <summary>
    ///   <para>rdfs:comment : A property linking a particular expression to its items.  This property is additional to the relationships between FRBR endeavours present in the classical FRBR data model.</para>
    ///   <para>rdfs:label : has representation</para>
    ///   <a href="http://purl.org/spar/fabio/hasRepresentation">fabio:hasRepresentation</a>
    /// </summary>
    let hasRepresentation = _prefixId.prefix "hasRepresentation"
    /// <summary>
    ///   <para>rdfs:label : has request date</para>
    ///   <para>rdfs:comment : The date on which an agent is requested to do something, for example a reviewer is requested to write a review of a paper submitted to a journal for publication, or an author is requested to supply a revised version of the paper in response to the reviews received.</para>
    ///   <a href="http://purl.org/spar/fabio/hasRequestDate">fabio:hasRequestDate</a>
    /// </summary>
    let hasRequestDate = _prefixId.prefix "hasRequestDate"
    /// <summary>
    ///   <para>rdfs:label : has retraction date</para>
    ///   <para>rdfs:comment : The date on which something, for example a claim or a journal article, is retracted.</para>
    ///   <a href="http://purl.org/spar/fabio/hasRetractionDate">fabio:hasRetractionDate</a>
    /// </summary>
    let hasRetractionDate = _prefixId.prefix "hasRetractionDate"
    /// <summary>
    ///   <para>rdfs:label : has Serial Item and Contribution Identifierrdfs:label : has SICI</para>
    ///   <para>rdfs:comment : The Serial Item and Contribution Identifier is a code used to uniquely identify specific volumes, articles or other identifiable parts of a periodical. It is intended primarily for use by those members of the bibliographic community involved in the use or management of serial titles and their contributions.</para>
    ///   <a href="http://purl.org/spar/fabio/hasSICI">fabio:hasSICI</a>
    /// </summary>
    let hasSICI = _prefixId.prefix "hasSICI"
    /// <summary>
    ///   <para>rdfs:label : has season</para>
    ///   <para>rdfs:comment : Permits specification of the season of the year, for example spring, summer, autumn and winter in British English.</para>
    ///   <a href="http://purl.org/spar/fabio/hasSeason">fabio:hasSeason</a>
    /// </summary>
    let hasSeason = _prefixId.prefix "hasSeason"
    /// <summary>
    ///   <para>rdfs:comment : A literal (for example a number or a letter) that identifies the sequence position of a work within a particular context, for example a book in a book series, a chapter in a document, a volume in a journal.</para>
    ///   <para>rdfs:label : has number</para>
    ///   <a href="http://purl.org/spar/fabio/hasSequenceIdentifier">fabio:hasSequenceIdentifier</a>
    /// </summary>
    let hasSequenceIdentifier = _prefixId.prefix "hasSequenceIdentifier"
    /// <summary>
    ///   <para>rdfs:label : has short title</para>
    ///   <para>rdfs:comment : A short version of the title of an entity, typically used to label or refer to a particular entity in an abbreviated form, for example an abbreviated journal title in a reference, or a short title of a document used as the running title in a page header.</para>
    ///   <a href="http://purl.org/spar/fabio/hasShortTitle">fabio:hasShortTitle</a>
    /// </summary>
    let hasShortTitle = _prefixId.prefix "hasShortTitle"
    /// <summary>
    ///   <para>rdfs:label : has standard number</para>
    ///   <para>rdfs:comment : The number defining an international standard, for example Z39.96 - 201x, identifying NISO JATS, the Journal Article Tag Suite.</para>
    ///   <a href="http://purl.org/spar/fabio/hasStandardNumber">fabio:hasStandardNumber</a>
    /// </summary>
    let hasStandardNumber = _prefixId.prefix "hasStandardNumber"
    /// <summary>
    ///   <para>rdfs:label : has subject term</para>
    ///   <para>rdfs:comment : This property is used to associate a frbr:Endeavour to a term in a particular classification system.</para>
    ///   <a href="http://purl.org/spar/fabio/hasSubjectTerm">fabio:hasSubjectTerm</a>
    /// </summary>
    let hasSubjectTerm = _prefixId.prefix "hasSubjectTerm"
    /// <summary>
    ///   <para>rdfs:comment : A secondary title that follows the main title of a work.</para>
    ///   <para>rdfs:label : has subtitle</para>
    ///   <a href="http://purl.org/spar/fabio/hasSubtitle">fabio:hasSubtitle</a>
    /// </summary>
    let hasSubtitle = _prefixId.prefix "hasSubtitle"
    /// <summary>
    ///   <para>rdfs:comment : A version of the subtitle of an entity translated into another language, which may be specified using the object property dcterms:language.</para>
    ///   <para>rdfs:label : has translated subtitle</para>
    ///   <a href="http://purl.org/spar/fabio/hasTranslatedSubtitle">fabio:hasTranslatedSubtitle</a>
    /// </summary>
    let hasTranslatedSubtitle = _prefixId.prefix "hasTranslatedSubtitle"
    /// <summary>
    ///   <para>rdfs:label : has translated title</para>
    ///   <para>rdfs:comment : A version of the title of an entity translated into another language, which may be specified using the object property dcterms:language.</para>
    ///   <a href="http://purl.org/spar/fabio/hasTranslatedTitle">fabio:hasTranslatedTitle</a>
    /// </summary>
    let hasTranslatedTitle = _prefixId.prefix "hasTranslatedTitle"
    /// <summary>
    ///   <para>rdfs:label : has URL</para>
    ///   <para>rdfs:comment : An identifier, in form of an HTTP Universal Resource Locator (URL), for a particular resource on the World Wide Web.</para>
    ///   <a href="http://purl.org/spar/fabio/hasURL">fabio:hasURL</a>
    /// </summary>
    let hasURL = _prefixId.prefix "hasURL"
    /// <summary>
    ///   <para>rdfs:comment : The count of the number of volumes a work includes.</para>
    ///   <para>rdfs:label : has volume count</para>
    ///   <a href="http://purl.org/spar/fabio/hasVolumeCount">fabio:hasVolumeCount</a>
    /// </summary>
    let hasVolumeCount = _prefixId.prefix "hasVolumeCount"
    let internet = _prefixId.prefix "internet"
    let intranet = _prefixId.prefix "intranet"
    /// <summary>
    ///   <para>rdfs:label : is discipline of</para>
    ///   <para>rdfs:comment : This property relates a subject vocabulary to the discipline to which it belongs.</para>
    ///   <a href="http://purl.org/spar/fabio/isDisciplineOf">fabio:isDisciplineOf</a>
    /// </summary>
    let isDisciplineOf = _prefixId.prefix "isDisciplineOf"
    /// <summary>
    ///   <para>rdfs:label : is manifestation of</para>
    ///   <para>rdfs:comment : A property linking a particular manifestation to the work it is manifesting.  This property is additional to the relationships between FRBR endeavours present in the classical FRBR data model.</para>
    ///   <a href="http://purl.org/spar/fabio/isManifestationOf">fabio:isManifestationOf</a>
    /// </summary>
    let isManifestationOf = _prefixId.prefix "isManifestationOf"
    /// <summary>
    ///   <para>rdfs:label : is portrayal of</para>
    ///   <para>rdfs:comment : A property linking a particular item to the work it portrays.  This property is additional to the relationships between FRBR endeavours present in the classical FRBR data model.</para>
    ///   <a href="http://purl.org/spar/fabio/isPortrayalOf">fabio:isPortrayalOf</a>
    /// </summary>
    let isPortrayalOf = _prefixId.prefix "isPortrayalOf"
    /// <summary>
    ///   <para>rdfs:comment : A property linking a particular item to the expression it represents.  This property is additional to the relationships between FRBR endeavours present in the classical FRBR data model.</para>
    ///   <para>rdfs:label : is representation of</para>
    ///   <a href="http://purl.org/spar/fabio/isRepresentationOf">fabio:isRepresentationOf</a>
    /// </summary>
    let isRepresentationOf = _prefixId.prefix "isRepresentationOf"
    /// <summary>
    ///   <para>rdfs:label : is scheme of</para>
    ///   <para>rdfs:comment : This property expresses the fact that a scheme contains a concept.</para>
    ///   <a href="http://purl.org/spar/fabio/isSchemeOf">fabio:isSchemeOf</a>
    /// </summary>
    let isSchemeOf = _prefixId.prefix "isSchemeOf"
    /// <summary>
    ///   <para>rdfs:label : is stored on</para>
    ///   <para>rdfs:comment : This property relates a fabio:Item to the medium upon which it is stored.</para>
    ///   <a href="http://purl.org/spar/fabio/isStoredOn">fabio:isStoredOn</a>
    /// </summary>
    let isStoredOn = _prefixId.prefix "isStoredOn"
    let paper = _prefixId.prefix "paper"
    let ram = _prefixId.prefix "ram"
    let solid_state_memory = _prefixId.prefix "solid-state-memory"
    /// <summary>
    ///   <para>rdfs:label : stores</para>
    ///   <para>rdfs:comment : This property relates a storage medium to the fabio:Item stored upon it.</para>
    ///   <a href="http://purl.org/spar/fabio/stores">fabio:stores</a>
    /// </summary>
    let stores = _prefixId.prefix "stores"
    /// <summary>
    ///   <para>rdfs:comment : A property that identifies the calendar system used to specify a date, for example the Chinese, Gregorian, Hebrew, Islamic or Lunar calendar.</para>
    ///   <para>rdfs:label : uses calendar</para>
    ///   <a href="http://purl.org/spar/fabio/usesCalendar">fabio:usesCalendar</a>
    /// </summary>
    let usesCalendar = _prefixId.prefix "usesCalendar"
    let vinyl_disk = _prefixId.prefix "vinyl-disk"
    let web = _prefixId.prefix "web"
