namespace http.purl.org.spar.fabio.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fabio =
    let _namespace_iri = Namespace_Iri fabio |> NamespaceIRI
    /// <summary>
    ///   <para>fabio:</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"FaBiO (FRBR-Aligned Bibliographic Ontology)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/">http://purl.org/spar/fabio/</seealso>
    let _prefix_iri = Prefixed_Name(fabio, "") |> PrefixedName
    /// <summary>
    ///   <para>fabio:2017-05-29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/fabio/2017-05-29">http://purl.org/spar/fabio/2017-05-29</seealso>
    let _2017_05_29 = Prefixed_Name(fabio, "2017-05-29") |> PrefixedName
    /// <summary>
    ///   <para>fabio:2018-05-02</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/fabio/2018-05-02">http://purl.org/spar/fabio/2018-05-02</seealso>
    let _2018_05_02 = Prefixed_Name(fabio, "2018-05-02") |> PrefixedName
    /// <summary>
    ///   <para>fabio:2019-02-19</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/fabio/2019-02-19">http://purl.org/spar/fabio/2019-02-19</seealso>
    let _2019_02_19 = Prefixed_Name(fabio, "2019-02-19") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A brief summary of a work on a particular subject, designed to act as the point-of-entry that will help the reader quickly to obtain an overview of the work's contents.   The abstract may be an integral part of the work itself, written by the same author(s) and appearing at the beginning of a work such as a research paper, report, review or thesis.  Alternatively it may be separate from the published work itself, and written by someone other than the author(s) of the published work, for example by a member of a professional abstracting service such as CAB Abstracts."</para>
    /// labels<para>"abstract"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Abstract">http://purl.org/spar/fabio/Abstract</seealso>
    let Abstract = Prefixed_Name(fabio, "Abstract") |> PrefixedName

    /// <summary>
    ///   <para>fabio:AcademicProceedings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document containing the programme and collected papers, or their abstracts, presented at an academic meeting."</para>
    /// labels<para>"academic proceedings"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/AcademicProceedings">http://purl.org/spar/fabio/AcademicProceedings</seealso>
    let AcademicProceedings =
        Prefixed_Name(fabio, "AcademicProceedings") |> PrefixedName

    /// <summary>
    ///   <para>fabio:Addendum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An item of material added at the end of a book or other publication, typically to include omitted or late-arriving material. "</para>
    /// labels<para>"addendum"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Addendum">http://purl.org/spar/fabio/Addendum</seealso>
    let Addendum = Prefixed_Name(fabio, "Addendum") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Algorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A precise sequential set of pre-defined logical rules or computational operations to be employed for solving a particular problem in a finite number of steps."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"algorithm"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Algorithm">http://purl.org/spar/fabio/Algorithm</seealso>
    let Algorithm = Prefixed_Name(fabio, "Algorithm") |> PrefixedName
    /// <summary>
    ///   <para>fabio:AnalogItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A real object that is an exemplar of a fabio:Manifestation, such as a particular copy of the book 'Alice's adventures in Wonderland', that a person may own."</para>
    /// labels<para>"analog item"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/AnalogItem">http://purl.org/spar/fabio/AnalogItem</seealso>
    let AnalogItem = Prefixed_Name(fabio, "AnalogItem") |> PrefixedName

    /// <summary>
    ///   <para>fabio:AnalogManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A manifestation in an analog form."</para>
    /// labels<para>"analog manifestation"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/AnalogManifestation">http://purl.org/spar/fabio/AnalogManifestation</seealso>
    let AnalogManifestation =
        Prefixed_Name(fabio, "AnalogManifestation") |> PrefixedName

    /// <summary>
    ///   <para>fabio:AnalogStorageMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A means of storing information in non-digital form, e.g. paper, film (for analogue photographs or movies), magnetic tape (for analogue sound recordings or video recordings) or vinyl disc."</para>
    /// labels<para>"analog storage medium"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/AnalogStorageMedium">http://purl.org/spar/fabio/AnalogStorageMedium</seealso>
    let AnalogStorageMedium =
        Prefixed_Name(fabio, "AnalogStorageMedium") |> PrefixedName

    /// <summary>
    ///   <para>fabio:Announcement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A formal statement about something."</para>
    /// labels<para>"announcement"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Announcement">http://purl.org/spar/fabio/Announcement</seealso>
    let Announcement = Prefixed_Name(fabio, "Announcement") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Anthology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of selected literary or scholastics works, for example poems, short stories, plays or research papers."</para>
    /// labels<para>"anthology"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Anthology">http://purl.org/spar/fabio/Anthology</seealso>
    let Anthology = Prefixed_Name(fabio, "Anthology") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ApplicationProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of metadata elements, policies and guidelines defined for a particular application.  The metadata elements used in the application profile may be drawn from more than one element sets, including locally defined sets. "</para>
    /// labels<para>"application profile"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ApplicationProfile">http://purl.org/spar/fabio/ApplicationProfile</seealso>
    let ApplicationProfile = Prefixed_Name(fabio, "ApplicationProfile") |> PrefixedName

    /// <summary>
    ///   <para>fabio:ApplicationProgrammingInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>" A computer program that enables a separate computer to interact programmatically with the computer running the API.  (Commonly abbreviated 'API'.)"</para>
    /// labels<para>"application programming interface"</para><para>"API"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ApplicationProgrammingInterface">http://purl.org/spar/fabio/ApplicationProgrammingInterface</seealso>
    let ApplicationProgrammingInterface =
        Prefixed_Name(fabio, "ApplicationProgrammingInterface") |> PrefixedName

    /// <summary>
    ///   <para>fabio:ArchivalDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An archival document is a realization of the content related to an archival record. It can be exemplified as a book, a document, a letter, a database, etc."</para>
    /// labels<para>"archival document"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ArchivalDocument">http://purl.org/spar/fabio/ArchivalDocument</seealso>
    let ArchivalDocument = Prefixed_Name(fabio, "ArchivalDocument") |> PrefixedName

    /// <summary>
    ///   <para>fabio:ArchivalDocumentSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of archival document."</para>
    /// labels<para>"archival document set"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ArchivalDocumentSet">http://purl.org/spar/fabio/ArchivalDocumentSet</seealso>
    let ArchivalDocumentSet =
        Prefixed_Name(fabio, "ArchivalDocumentSet") |> PrefixedName

    /// <summary>
    ///   <para>fabio:ArchivalRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An archival record connotes a material created or received by a person, family, or organization, public or private, in the conduct of their affairs that is preserved because of the enduring value contained in the information it contains or as evidence of the function and the responsibilities of its creator."</para>
    /// labels<para>"archival record"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ArchivalRecord">http://purl.org/spar/fabio/ArchivalRecord</seealso>
    let ArchivalRecord = Prefixed_Name(fabio, "ArchivalRecord") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ArchivalRecordSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of archival records."</para>
    /// labels<para>"archival record set"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ArchivalRecordSet">http://purl.org/spar/fabio/ArchivalRecordSet</seealso>
    let ArchivalRecordSet = Prefixed_Name(fabio, "ArchivalRecordSet") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Article</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The realization of a piece of writing on a particular topic, usually published within a periodical publication (e.g. journal, magazine and newspaper)."</para>
    /// labels<para>"article"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Article">http://purl.org/spar/fabio/Article</seealso>
    let Article = Prefixed_Name(fabio, "Article") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ArtisticWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It describes any work regarded as art in its widest sense, including works from literature and music, visual art, etc."</para>
    /// labels<para>"artistic work"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ArtisticWork">http://purl.org/spar/fabio/ArtisticWork</seealso>
    let ArtisticWork = Prefixed_Name(fabio, "ArtisticWork") |> PrefixedName
    /// <summary>
    ///   <para>fabio:AudioDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The realization of a sound recording."</para>
    /// labels<para>"audio document"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/AudioDocument">http://purl.org/spar/fabio/AudioDocument</seealso>
    let AudioDocument = Prefixed_Name(fabio, "AudioDocument") |> PrefixedName
    /// <summary>
    ///   <para>fabio:AuthorityFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A controlled vocabulary or official list that establishes, for consistency, the authoritative forms of headings, and the preferred terms or proper names to be used, when creating a catalogue or when indexing and searching a set of entities within a defined domain."</para>
    /// labels<para>"authority file"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/AuthorityFile">http://purl.org/spar/fabio/AuthorityFile</seealso>
    let AuthorityFile = Prefixed_Name(fabio, "AuthorityFile") |> PrefixedName
    /// <summary>
    ///   <para>fabio:BachelorsThesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A thesis reporting a research project undertaken as part of an undergraduate course of education leading to a bachelor's degree."</para>
    /// labels<para>"bachelor's thesis"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/BachelorsThesis">http://purl.org/spar/fabio/BachelorsThesis</seealso>
    let BachelorsThesis = Prefixed_Name(fabio, "BachelorsThesis") |> PrefixedName

    /// <summary>
    ///   <para>fabio:BibliographicDatabase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A database providing an authoritative source of bibliographic information, for example PubMed (http://www.ncbi.nlm.nih.gov/pubmed), CrossRef Metadata Search (http://search.crossref.org/) and PubMed Central (http://www.ncbi.nlm.nih.gov/pmc/)."</para>
    /// labels<para>"bibliographic database"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/BibliographicDatabase">http://purl.org/spar/fabio/BibliographicDatabase</seealso>
    let BibliographicDatabase =
        Prefixed_Name(fabio, "BibliographicDatabase") |> PrefixedName

    /// <summary>
    ///   <para>fabio:BibliographicMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Standard bibliographic metadata describing an expression of a work.  To take the example of a journal article, bibliographic metadata typically include the authors' names, the date of publication, the title of the article, the journal name and volume number, the first and last page numbers, and the Digital Object Identifier (DOI)."</para>
    /// labels<para>"bibliographic metadata"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/BibliographicMetadata">http://purl.org/spar/fabio/BibliographicMetadata</seealso>
    let BibliographicMetadata =
        Prefixed_Name(fabio, "BibliographicMetadata") |> PrefixedName

    /// <summary>
    ///   <para>fabio:Biography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An account of the events, works and achievements, both personal and professional, of a person, either living or dead."</para>
    /// labels<para>"biography"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Biography">http://purl.org/spar/fabio/Biography</seealso>
    let Biography = Prefixed_Name(fabio, "Biography") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Blog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Web publication medium containing blog posts."</para>
    /// labels<para>"blog"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Blog">http://purl.org/spar/fabio/Blog</seealso>
    let Blog = Prefixed_Name(fabio, "Blog") |> PrefixedName
    /// <summary>
    ///   <para>fabio:BlogPost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Information manifested in a blog, one of a set of periodic sequential entries containing commentary, descriptions of events, or other material such as images or videos, usually displayed in reverse-chronological order and usually maintained by an individual, or comments on such a post."</para>
    /// labels<para>"blog post"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/BlogPost">http://purl.org/spar/fabio/BlogPost</seealso>
    let BlogPost = Prefixed_Name(fabio, "BlogPost") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Book</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A non-serial document that is complete in one volume or a designated finite number of volumes.  A book published by a publisher is usually  identified by an International Standard Book Number (ISBN), and may be manifested as a physical printed publication on paper bound in a hard or soft cover, or in electronic format as an 'e-book'."</para>
    /// labels<para>"book"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Book">http://purl.org/spar/fabio/Book</seealso>
    let Book = Prefixed_Name(fabio, "Book") |> PrefixedName
    /// <summary>
    ///   <para>fabio:BookChapter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A defined chapter of a book, usually with a separate title or number."</para>
    /// labels<para>"book chapter"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/BookChapter">http://purl.org/spar/fabio/BookChapter</seealso>
    let BookChapter = Prefixed_Name(fabio, "BookChapter") |> PrefixedName
    /// <summary>
    ///   <para>fabio:BookReview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A written review and critical analysis of the content, scope and quality of a book or other monographic work."</para>
    /// labels<para>"book review"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/BookReview">http://purl.org/spar/fabio/BookReview</seealso>
    let BookReview = Prefixed_Name(fabio, "BookReview") |> PrefixedName
    /// <summary>
    ///   <para>fabio:BookSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sequence of books having certain characteristics in common that are formally identified together as a group - for instance, the books in the Law, Governance and Technology Series published by Springer."</para>
    /// labels<para>"book series"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/BookSeries">http://purl.org/spar/fabio/BookSeries</seealso>
    let BookSeries = Prefixed_Name(fabio, "BookSeries") |> PrefixedName
    /// <summary>
    ///   <para>fabio:BookSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of books having certain characteristics in common that informally allow their identification together as a group - for instance, the books of the Harry Potter saga."</para>
    /// labels<para>"book set"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/BookSet">http://purl.org/spar/fabio/BookSet</seealso>
    let BookSet = Prefixed_Name(fabio, "BookSet") |> PrefixedName
    /// <summary>
    ///   <para>fabio:BriefReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A brief report document.  This term may also be used synonymously with Rapid Communication to mean 'A short rapidly published research article or conference paper, typically reporting significant research results that have been recently discovered, or a brief news item reporting such discoveries.'"</para>
    /// labels<para>"brief report"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/BriefReport">http://purl.org/spar/fabio/BriefReport</seealso>
    let BriefReport = Prefixed_Name(fabio, "BriefReport") |> PrefixedName

    /// <summary>
    ///   <para>fabio:CallForApplications</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document published by a funding agency requesting submission of applications for financial grants to fund projects, for example to enable research investigations in areas specified in the Call."</para>
    /// labels<para>"call for applications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/CallForApplications">http://purl.org/spar/fabio/CallForApplications</seealso>
    let CallForApplications =
        Prefixed_Name(fabio, "CallForApplications") |> PrefixedName

    /// <summary>
    ///   <para>fabio:CaseForSupport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A part of a grant application that provides a description of a proposed project and gives reasons why it is worthy of funding. (See also fabio:GrantApplication)."</para>
    /// labels<para>"case for support"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/CaseForSupport">http://purl.org/spar/fabio/CaseForSupport</seealso>
    let CaseForSupport = Prefixed_Name(fabio, "CaseForSupport") |> PrefixedName

    /// <summary>
    ///   <para>fabio:CaseForSupportDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document containing the case for support for a particular project, usually contained within a grant application document but sometimes distributed separately, without the financial and organizational information that the grant application document also contains."</para>
    /// labels<para>"case for support document"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/CaseForSupportDocument">http://purl.org/spar/fabio/CaseForSupportDocument</seealso>
    let CaseForSupportDocument =
        Prefixed_Name(fabio, "CaseForSupportDocument") |> PrefixedName

    /// <summary>
    ///   <para>fabio:CaseReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A report about a particular case or situation."</para>
    /// labels<para>"case report"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/CaseReport">http://purl.org/spar/fabio/CaseReport</seealso>
    let CaseReport = Prefixed_Name(fabio, "CaseReport") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Catalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A list of items describing the content of a resource, for example items in an exhibition, items offered for sale by a vendor, or entities contained within a library or collection.  Ideally, catalogs are created according to specific and uniform principles of construction and are under the control of an authority file."</para>
    /// labels<para>"catalog"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Catalog">http://purl.org/spar/fabio/Catalog</seealso>
    let Catalog = Prefixed_Name(fabio, "Catalog") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Chapter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A defined document section, forming part of or intended for inclusion within a larger document, usually with its own title or chapter number.  Different chapters within a document such as a book or a report may each be independently authored, or may all be authored by a single individual or group of authors."</para>
    /// labels<para>"chapter"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Chapter">http://purl.org/spar/fabio/Chapter</seealso>
    let Chapter = Prefixed_Name(fabio, "Chapter") |> PrefixedName
    /// <summary>
    ///   <para>fabio:CitationMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Metadata describing the citations made within a work to other works, and (optionally) some characteristics of the expressions of the cited works."</para>
    /// labels<para>"citation metadata"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/CitationMetadata">http://purl.org/spar/fabio/CitationMetadata</seealso>
    let CitationMetadata = Prefixed_Name(fabio, "CitationMetadata") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ClinicalCaseReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A presentation of findings following a clinical or medical investigation on a human or animal patient, that may contain a diagnosis and proposals for therapeutic treatment and/or epidemiological control measures, or may propose further evaluative studies that will eventually lead to such outcomes."</para>
    /// labels<para>"clinical case report"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ClinicalCaseReport">http://purl.org/spar/fabio/ClinicalCaseReport</seealso>
    let ClinicalCaseReport = Prefixed_Name(fabio, "ClinicalCaseReport") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ClinicalGuideline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A recommendation on the appropriate treatment and care of people with a specific disease or condition, based on the best available evidence, designed to help healthcare professionals in their work."</para>
    /// labels<para>"Clinical Guideline"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"clinical guideline"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ClinicalGuideline">http://purl.org/spar/fabio/ClinicalGuideline</seealso>
    let ClinicalGuideline = Prefixed_Name(fabio, "ClinicalGuideline") |> PrefixedName

    /// <summary>
    ///   <para>fabio:ClinicalTrialDesign</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A predefined written procedural method, designed to ensure reliability of findings, for undertaking a medical or veterinary clinical study of the safety, efficacy, or optimum dosage schedule of one or more diagnostic, therapeutic or prophylactic drugs or treatments, or of devices or techniques, involving a randomized controlled trial for evidence-based assessment in humans or animals, specifying criteria of eligibility, nature of controls, sampling schedules, data collection parameters, statistical analyses, reporting standards, etc. to be employed in undertaking the clinical trial."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"clinical trial design"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ClinicalTrialDesign">http://purl.org/spar/fabio/ClinicalTrialDesign</seealso>
    let ClinicalTrialDesign =
        Prefixed_Name(fabio, "ClinicalTrialDesign") |> PrefixedName

    /// <summary>
    ///   <para>fabio:ClinicalTrialReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The report of a pre-planned medical or veterinary clinical study of the safety, efficacy, or optimum dosage schedule of one or more diagnostic, therapeutic or prophylactic drugs, or of devices, treatments or techniques, involving a randomized controlled trial for evidence-based assessment in humans or animals selected according to predetermined criteria of eligibility and observed for evidence of favourable and unfavourable effects."</para>
    /// labels<para>"clinical trial report"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ClinicalTrialReport">http://purl.org/spar/fabio/ClinicalTrialReport</seealso>
    let ClinicalTrialReport =
        Prefixed_Name(fabio, "ClinicalTrialReport") |> PrefixedName

    /// <summary>
    ///   <para>fabio:CollectedWorks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of the literary or scholastic works of a single person."</para>
    /// labels<para>"collected works"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/CollectedWorks">http://purl.org/spar/fabio/CollectedWorks</seealso>
    let CollectedWorks = Prefixed_Name(fabio, "CollectedWorks") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A verbal or written remark concerning some entity.  In written form, a comment is often appended to that entity and termed an annotation.  Within computer programs or ontologies, comments are added to enhance human understanding, and are usually prefaced by a special syntactic symbol that ensures they are ignored during execution of the program."</para>
    /// labels<para>"Comment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"comment"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Comment">http://purl.org/spar/fabio/Comment</seealso>
    let Comment = Prefixed_Name(fabio, "Comment") |> PrefixedName
    /// <summary>
    ///   <para>fabio:CompleteWorks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of all the literary or scholastic works of a single person."</para>
    /// labels<para>"complete works"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/CompleteWorks">http://purl.org/spar/fabio/CompleteWorks</seealso>
    let CompleteWorks = Prefixed_Name(fabio, "CompleteWorks") |> PrefixedName

    /// <summary>
    ///   <para>fabio:ComputerApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A computer program designed to assist a human user to perform one or more goal-oriented tasks such as word processing or image processing.  A computer application will typically save its output files in one or more specific formats, conforming either to proprietary or open standards.  "</para>
    /// labels<para>"computer application"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ComputerApplication">http://purl.org/spar/fabio/ComputerApplication</seealso>
    let ComputerApplication =
        Prefixed_Name(fabio, "ComputerApplication") |> PrefixedName

    /// <summary>
    ///   <para>fabio:ComputerFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A digital item containing information in computer-readable form encoded in a particular format."</para>
    /// labels<para>"computer file"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ComputerFile">http://purl.org/spar/fabio/ComputerFile</seealso>
    let ComputerFile = Prefixed_Name(fabio, "ComputerFile") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ComputerProgram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A unit of computer code in source or compiled form, employing one or more algorithms to be executed by a digital computer to undertake a particular task.  Computer programs are collectively called 'software' to distinguish them from the equipment ('hardware') upon which they run. "</para>
    /// labels<para>"computer program"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ComputerProgram">http://purl.org/spar/fabio/ComputerProgram</seealso>
    let ComputerProgram = Prefixed_Name(fabio, "ComputerProgram") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ConferencePaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A paper, typically the realization of a research paper reporting original research findings, usually published within a conference proceedings volume."</para>
    /// labels<para>"conference paper"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ConferencePaper">http://purl.org/spar/fabio/ConferencePaper</seealso>
    let ConferencePaper = Prefixed_Name(fabio, "ConferencePaper") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ConferencePoster</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A display poster, typically containing text with illustrative figures and/or tables, usually reporting research results or proposing hypotheses, submitted for acceptance to and/or presented at a conference, seminar, symposium, workshop or similar event."</para>
    /// labels<para>"conference poster"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ConferencePoster">http://purl.org/spar/fabio/ConferencePoster</seealso>
    let ConferencePoster = Prefixed_Name(fabio, "ConferencePoster") |> PrefixedName

    /// <summary>
    ///   <para>fabio:ConferenceProceedings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document containing the programme and collected conference papers, or their abstracts, presented at a conference, seminar, symposium or similar event."</para>
    /// labels<para>"conference proceedings"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ConferenceProceedings">http://purl.org/spar/fabio/ConferenceProceedings</seealso>
    let ConferenceProceedings =
        Prefixed_Name(fabio, "ConferenceProceedings") |> PrefixedName

    /// <summary>
    ///   <para>fabio:ControlledVocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of selected words and phrases related to a particular domain of knowledge used to permit consistency of metadata annotation and improved retrieval following a search, in which homonyms, synonyms and similar ambiguities of meaning present in natural language are disambiguated."</para>
    /// labels<para>"controlled vocabulary"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ControlledVocabulary">http://purl.org/spar/fabio/ControlledVocabulary</seealso>
    let ControlledVocabulary =
        Prefixed_Name(fabio, "ControlledVocabulary") |> PrefixedName

    /// <summary>
    ///   <para>fabio:Correction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A correction to an error in a previously published document."</para>
    /// labels<para>"correction"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Correction">http://purl.org/spar/fabio/Correction</seealso>
    let Correction = Prefixed_Name(fabio, "Correction") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Corrigendum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A formal correction to an error introduced by the author into a previously published document."</para>
    /// labels<para>"corrigendum"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Corrigendum">http://purl.org/spar/fabio/Corrigendum</seealso>
    let Corrigendum = Prefixed_Name(fabio, "Corrigendum") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Cover</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A protective covering used to bind together the pages of a document or the first, informative, page of a digital document."</para>
    /// labels<para>"cover"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Cover">http://purl.org/spar/fabio/Cover</seealso>
    let Cover = Prefixed_Name(fabio, "Cover") |> PrefixedName
    /// <summary>
    ///   <para>fabio:CriticalEdition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A new edition of a historical publication, edited by a scholar other than the original author, containing within the body text the supposedly best version of the original work, with footnotes detailing and commenting on textual variations between different versions, typically with an introduction to the original work written by the scholar, and with a bibliography listing related publications."</para>
    /// labels<para>"critical edition"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/CriticalEdition">http://purl.org/spar/fabio/CriticalEdition</seealso>
    let CriticalEdition = Prefixed_Name(fabio, "CriticalEdition") |> PrefixedName
    /// <summary>
    ///   <para>fabio:DataFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A realisation of a fabio:Dataset (a frbr:Work) containing a defined collection of data with specific content and possibly with a specific version number, that can be embodied as a fabio:Digital Manifestation (a frbr:Manifestation with a specific format) and be represented by a specific fabio:ComputerFile (a frbr:Item) on someone's hard drive."</para>
    /// labels<para>"data file"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/DataFile">http://purl.org/spar/fabio/DataFile</seealso>
    let DataFile = Prefixed_Name(fabio, "DataFile") |> PrefixedName

    /// <summary>
    ///   <para>fabio:DataManagementPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A policy that descibes and defines how data should be managed, preserved and shared."</para>
    /// labels<para>"data management policy"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/DataManagementPolicy">http://purl.org/spar/fabio/DataManagementPolicy</seealso>
    let DataManagementPolicy =
        Prefixed_Name(fabio, "DataManagementPolicy") |> PrefixedName

    /// <summary>
    ///   <para>fabio:DataManagementPolicyDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document embodying a policy that descibes and defines how data should be managed, preserved and shared."</para>
    /// labels<para>"data management policy document"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/DataManagementPolicyDocument">http://purl.org/spar/fabio/DataManagementPolicyDocument</seealso>
    let DataManagementPolicyDocument =
        Prefixed_Name(fabio, "DataManagementPolicyDocument") |> PrefixedName

    /// <summary>
    ///   <para>fabio:DataMangementPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A structured document giving information about how data arising from a research project or other endeavour is to be manages, preserved and shared."</para>
    /// labels<para>"data management plan"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/DataMangementPlan">http://purl.org/spar/fabio/DataMangementPlan</seealso>
    let DataMangementPlan = Prefixed_Name(fabio, "DataMangementPlan") |> PrefixedName
    /// <summary>
    ///   <para>fabio:DataRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A repository for storing data."</para>
    /// labels<para>"data repository"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/DataRepository">http://purl.org/spar/fabio/DataRepository</seealso>
    let DataRepository = Prefixed_Name(fabio, "DataRepository") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Database</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A structured collection of logically related records or data usually stored and retrieved using computer-based means."</para>
    /// labels<para>"database"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Database">http://purl.org/spar/fabio/Database</seealso>
    let Database = Prefixed_Name(fabio, "Database") |> PrefixedName

    /// <summary>
    ///   <para>fabio:DatabaseManagementSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The software used to create a database.  (Commonly abbreviated 'DBMS'.)"</para>
    /// labels<para>"database management system"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/DatabaseManagementSystem">http://purl.org/spar/fabio/DatabaseManagementSystem</seealso>
    let DatabaseManagementSystem =
        Prefixed_Name(fabio, "DatabaseManagementSystem") |> PrefixedName

    /// <summary>
    ///   <para>fabio:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of related facts, often expressed in numerical form and encoded in a defined structure."</para>
    /// labels<para>"dataset"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Dataset">http://purl.org/spar/fabio/Dataset</seealso>
    let Dataset = Prefixed_Name(fabio, "Dataset") |> PrefixedName
    /// <summary>
    ///   <para>fabio:DefinitiveVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The final published expression of a work that bears the publisher's imprimatur. Typically for a journal article, the Definitive Version results from revision of an earlier submitted version of the work following peer review, and is then published in print and/or digital form after the publisher has assigned it a DOI.  The Definitive Version is also known as the Version of Record, although according to the CrossRef Glossary (http://crossref.org/02publishers/glossary.html) that term can also refer to the author's final version of a work that is not formally published. "</para>
    /// labels<para>"definitive version"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/DefinitiveVersion">http://purl.org/spar/fabio/DefinitiveVersion</seealso>
    let DefinitiveVersion = Prefixed_Name(fabio, "DefinitiveVersion") |> PrefixedName
    /// <summary>
    ///   <para>fabio:DemoPaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A demonstration paper, typically describing a new product, service or system created as a result of research, usually presented during a conference or workshop."</para>
    /// labels<para>"demo paper"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/DemoPaper">http://purl.org/spar/fabio/DemoPaper</seealso>
    let DemoPaper = Prefixed_Name(fabio, "DemoPaper") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Diary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A personal record, in a form of book, with discrete entries (often handwritten) arranged by date, reporting what has happened over the course of a day or other period of time."</para>
    /// labels<para>"diary"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Diary">http://purl.org/spar/fabio/Diary</seealso>
    let Diary = Prefixed_Name(fabio, "Diary") |> PrefixedName
    /// <summary>
    ///   <para>fabio:DigitalItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A digital object, such as a computer file."</para>
    /// labels<para>"digital item"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/DigitalItem">http://purl.org/spar/fabio/DigitalItem</seealso>
    let DigitalItem = Prefixed_Name(fabio, "DigitalItem") |> PrefixedName

    /// <summary>
    ///   <para>fabio:DigitalManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A manifestation that represents data in binary form, encoding the data as a series of 0s and 1s."</para>
    /// labels<para>"digital manifestation"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/DigitalManifestation">http://purl.org/spar/fabio/DigitalManifestation</seealso>
    let DigitalManifestation =
        Prefixed_Name(fabio, "DigitalManifestation") |> PrefixedName

    /// <summary>
    ///   <para>fabio:DigitalStorageMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A means of storing information in digital form, involving binary encoding of data in 0s and 1s, e.g. a computer random access memory, hard disc, USB stick, CD, DVD or digital magnetic tape."</para>
    /// labels<para>"digital storage medium"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/DigitalStorageMedium">http://purl.org/spar/fabio/DigitalStorageMedium</seealso>
    let DigitalStorageMedium =
        Prefixed_Name(fabio, "DigitalStorageMedium") |> PrefixedName

    /// <summary>
    ///   <para>fabio:Directory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A database of information which is heavily optimized for reading."</para>
    /// labels<para>"directory"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Directory">http://purl.org/spar/fabio/Directory</seealso>
    let Directory = Prefixed_Name(fabio, "Directory") |> PrefixedName

    /// <summary>
    ///   <para>fabio:DisciplineDictionary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A discipline dictionary is a collection of subject disciplines."</para>
    /// labels<para>"discipline dictionary"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/DisciplineDictionary">http://purl.org/spar/fabio/DisciplineDictionary</seealso>
    let DisciplineDictionary =
        Prefixed_Name(fabio, "DisciplineDictionary") |> PrefixedName

    /// <summary>
    ///   <para>fabio:DoctoralThesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A thesis reporting the research undertaken during a period of graduate study leading to a doctoral degree."</para>
    /// labels<para>"doctoral thesis"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/DoctoralThesis">http://purl.org/spar/fabio/DoctoralThesis</seealso>
    let DoctoralThesis = Prefixed_Name(fabio, "DoctoralThesis") |> PrefixedName
    /// <summary>
    ///   <para>fabio:DocumentRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A repository for storing documents."</para>
    /// labels<para>"document repository"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/DocumentRepository">http://purl.org/spar/fabio/DocumentRepository</seealso>
    let DocumentRepository = Prefixed_Name(fabio, "DocumentRepository") |> PrefixedName
    /// <summary>
    ///   <para>fabio:DustJacket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A detachable outer cover, usually made of paper and printed with text and illustrations. This outer cover has folded flaps that hold it to the cover of a document."</para>
    /// labels<para>"dust jacket"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/DustJacket">http://purl.org/spar/fabio/DustJacket</seealso>
    let DustJacket = Prefixed_Name(fabio, "DustJacket") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Editorial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The realization of an opinion written by an editor."</para>
    /// labels<para>"editorial"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Editorial">http://purl.org/spar/fabio/Editorial</seealso>
    let Editorial = Prefixed_Name(fabio, "Editorial") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A message transmitted over the internet as an item of electronic mail, typically based on the Simple Mail Transfer Protocol (SMTP).  Emails can have computer files containing documents, dataset and images attached to them or embedded within them."</para>
    /// labels<para>"e-mail"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Email">http://purl.org/spar/fabio/Email</seealso>
    let Email = Prefixed_Name(fabio, "Email") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Endeavour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/fabio/Endeavour">http://purl.org/spar/fabio/Endeavour</seealso>
    let Endeavour = Prefixed_Name(fabio, "Endeavour") |> PrefixedName
    /// <summary>
    ///   <para>fabio:EntityMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Metadata describing the work itself, including for example the name of the creator(s), the title of the work, and the date and place of its creation."</para>
    /// labels<para>"entity metadata"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/EntityMetadata">http://purl.org/spar/fabio/EntityMetadata</seealso>
    let EntityMetadata = Prefixed_Name(fabio, "EntityMetadata") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Entry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An item written or printed in a diary, list, account book, reference book, or database."</para>
    /// labels<para>"entry"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Entry">http://purl.org/spar/fabio/Entry</seealso>
    let Entry = Prefixed_Name(fabio, "Entry") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Erratum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A formal correction to an error introduced by the publisher into a previously published document."</para>
    /// labels<para>"erratum"</para><para>"Erratum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Erratum">http://purl.org/spar/fabio/Erratum</seealso>
    let Erratum = Prefixed_Name(fabio, "Erratum") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Essay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A piece of non-fiction writing on a particular subject, usually of moderate length and without chapters."</para>
    /// labels<para>"essay"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Essay">http://purl.org/spar/fabio/Essay</seealso>
    let Essay = Prefixed_Name(fabio, "Essay") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ExaminationPaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of questions on a particular topic designed to test the academic, professional or technical ability of the person taking the examination, with achievement of a pass grade in the examination typically being a prerequisite for the award of an educational award such as a degree, or of a professional or technical qualification."</para>
    /// labels<para>"examination paper"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ExaminationPaper">http://purl.org/spar/fabio/ExaminationPaper</seealso>
    let ExaminationPaper = Prefixed_Name(fabio, "ExaminationPaper") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Excerpt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A segment or passage selected from a larger expression for use in another expression, usually with specific attribution to its original source.
    ///
    /// [Note: Use fabio:Excerpt to indicate a segment or passage selected from another expression that is not a passage of speech, and fabio:Quotation to indicate a segment or passage selected from another expression that is a passage of speech.]"</para>
    /// labels<para>"excerpt"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Excerpt">http://purl.org/spar/fabio/Excerpt</seealso>
    let Excerpt = Prefixed_Name(fabio, "Excerpt") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ExecutiveSummary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An executive summary is a brief report summarizing a longer formal report, designed to present the key points, conclusions and recommendations arising from the study being reported, for readers too busy to take the time to read the complete report."</para>
    /// labels<para>"executive summary"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ExecutiveSummary">http://purl.org/spar/fabio/ExecutiveSummary</seealso>
    let ExecutiveSummary = Prefixed_Name(fabio, "ExecutiveSummary") |> PrefixedName

    /// <summary>
    ///   <para>fabio:ExperimentalProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A predefined written procedural method, designed to ensure successful replication of results by others in the same or other laboratories, that describes the overall objectives, organization and implementation of a scientific experiment, and specifies the experimental design, experimental methods, reagents, instrumentation, sampling schedules, data collection parameters, statistical analyses, image processing procedures, safety precautions, reporting standards, etc. employed in undertaking the experiment."</para>
    /// labels<para>"experimental protocol"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ExperimentalProtocol">http://purl.org/spar/fabio/ExperimentalProtocol</seealso>
    let ExperimentalProtocol =
        Prefixed_Name(fabio, "ExperimentalProtocol") |> PrefixedName

    /// <summary>
    ///   <para>fabio:Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A subclass of FRBR expression, restricted to expressions of fabio:Works.  For your latest research paper, the preprint submitted to the publisher, and the final published version to which the publisher assigned a unique digital object identifier, are both expressions of the same work.  "</para>
    /// labels<para>"expression"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Expression">http://purl.org/spar/fabio/Expression</seealso>
    let Expression = Prefixed_Name(fabio, "Expression") |> PrefixedName

    /// <summary>
    ///   <para>fabio:ExpressionCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of expressions, for example a periodical or a book series."</para>
    /// labels<para>"expression collection"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ExpressionCollection">http://purl.org/spar/fabio/ExpressionCollection</seealso>
    let ExpressionCollection =
        Prefixed_Name(fabio, "ExpressionCollection") |> PrefixedName

    /// <summary>
    ///   <para>fabio:FRBR%20diagram%20with%20new%20Fabio%20verbs.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/fabio/FRBR%20diagram%20with%20new%20Fabio%20verbs.png">http://purl.org/spar/fabio/FRBR%20diagram%20with%20new%20Fabio%20verbs.png</seealso>
    let ``FRBR%20diagram%20with%20new%20Fabio%20verbs.png`` =
        Prefixed_Name(fabio, "FRBR%20diagram%20with%20new%20Fabio%20verbs.png") |> PrefixedName

    /// <summary>
    ///   <para>fabio:Figure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A visual communication object comprising one or more still images on a related theme.  If included within a publication, a figure is typically unaligned with the main body of text, having its own descriptive textual figure legend."</para>
    /// labels<para>"figure"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Figure">http://purl.org/spar/fabio/Figure</seealso>
    let Figure = Prefixed_Name(fabio, "Figure") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Film</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A movie with an accompanying soundtrack, typically created by a professional film studio, designed to communicate a fictional story, record an artistic event, or impart information that is scientific or documentary in nature."</para>
    /// labels<para>"film"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Film">http://purl.org/spar/fabio/Film</seealso>
    let Film = Prefixed_Name(fabio, "Film") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Folksonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A system of classification derived from the practice and method of collaboratively creating and managing tags to annotate and categorize content in a particular domain. [Contrast fabio:Ontology]"</para>
    /// labels<para>"folksonomy"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Folksonomy">http://purl.org/spar/fabio/Folksonomy</seealso>
    let Folksonomy = Prefixed_Name(fabio, "Folksonomy") |> PrefixedName
    /// <summary>
    ///   <para>fabio:GanttChart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A horizontal bar chart used to guide project planning, execution and control, illustrating the project schedule, with a separate line indicating the start and end dates of each of the key project activities or workpackages, and optionally showing the dependencies between these items. A Gantt chart is typically part of a project plan."</para>
    /// labels<para>"Gantt chart"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/GanttChart">http://purl.org/spar/fabio/GanttChart</seealso>
    let GanttChart = Prefixed_Name(fabio, "GanttChart") |> PrefixedName
    /// <summary>
    ///   <para>fabio:GrantApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A formal written request for financial support from a grant-giving body in support of a project, for example an academic research project.  (See also fabio:CaseForSupport.)"</para>
    /// labels<para>"grant application"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/GrantApplication">http://purl.org/spar/fabio/GrantApplication</seealso>
    let GrantApplication = Prefixed_Name(fabio, "GrantApplication") |> PrefixedName

    /// <summary>
    ///   <para>fabio:GrantApplicationDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The realization of a grant application, usually containing a case for support document."</para>
    /// labels<para>"grant application document"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/GrantApplicationDocument">http://purl.org/spar/fabio/GrantApplicationDocument</seealso>
    let GrantApplicationDocument =
        Prefixed_Name(fabio, "GrantApplicationDocument") |> PrefixedName

    /// <summary>
    ///   <para>fabio:Hardback</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A print object bound with rigid protective covers (typically of cardboard covered with cloth, heavy paper, or sometimes leather)."</para>
    /// labels<para>"hardback"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Hardback">http://purl.org/spar/fabio/Hardback</seealso>
    let Hardback = Prefixed_Name(fabio, "Hardback") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A visual representation other than text, including all types of moving image and still image."</para>
    /// labels<para>"image"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Image">http://purl.org/spar/fabio/Image</seealso>
    let Image = Prefixed_Name(fabio, "Image") |> PrefixedName
    /// <summary>
    ///   <para>fabio:InBrief</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An 'In Brief' is a journal or magazine news item that describes all the articles (or all the important articles) in that issue of the periodical. The content of an 'In Brief' may be constructed from the abstracts of the articles it highlights, but is more likely to be written by a member of the periodical staff especially for the issue."</para>
    /// labels<para>"in brief"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/InBrief">http://purl.org/spar/fabio/InBrief</seealso>
    let InBrief = Prefixed_Name(fabio, "InBrief") |> PrefixedName
    /// <summary>
    ///   <para>fabio:InUsePaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A scholarly work that describes applied and validated solutions such as software tools, systems or architectures that benefit from the use of the technology of a particular scholarly domain. Usually, papers of this kind should also provide convincing evidence that there is use of the proposed application or tool by the target user group, preferably outside the institution that conducted its development.
    ///
    /// E.g. see http://iswc2018.semanticweb.org/call-for-in-use-track-papers/."</para>
    /// labels<para>"in-use paper"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/InUsePaper">http://purl.org/spar/fabio/InUsePaper</seealso>
    let InUsePaper = Prefixed_Name(fabio, "InUsePaper") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An alphabetically-ordered list of words and phrases ('headings') and associated pointers ('locators') to where useful material relating to that heading can be found in a document."</para>
    /// labels<para>"index"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Index">http://purl.org/spar/fabio/Index</seealso>
    let Index = Prefixed_Name(fabio, "Index") |> PrefixedName
    /// <summary>
    ///   <para>fabio:InstructionManual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instructional document typically supplied with a technologically advanced consumer product, such as a car or a computer application, or with an item of complex equipment such as a microscope."</para>
    /// labels<para>"instruction manual"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/InstructionManual">http://purl.org/spar/fabio/InstructionManual</seealso>
    let InstructionManual = Prefixed_Name(fabio, "InstructionManual") |> PrefixedName
    /// <summary>
    ///   <para>fabio:InstructionalWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A work created for the purpose of education or instruction, that may be expressed as a  text book, a lecture, a tutorial or an instruction manual."</para>
    /// labels<para>"instructional work"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/InstructionalWork">http://purl.org/spar/fabio/InstructionalWork</seealso>
    let InstructionalWork = Prefixed_Name(fabio, "InstructionalWork") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A subclass of FRBR item, restricted to exemplars of fabio:Manifestations.  An example of a fabio:Item is a printed copy of a journal article on your desk, or a PDF file of that article that you purchased from a publisher and that now resides in digital form on your computer hard drive.  "</para>
    /// labels<para>"item"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Item">http://purl.org/spar/fabio/Item</seealso>
    let Item = Prefixed_Name(fabio, "Item") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ItemCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of items."</para>
    /// labels<para>"item collection"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ItemCollection">http://purl.org/spar/fabio/ItemCollection</seealso>
    let ItemCollection = Prefixed_Name(fabio, "ItemCollection") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Journal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A scholarly periodical primarily devoted to the publication of original research papers. [Printed and electronic manifestations of the same journal are usually identified by separate print and electronic International Standard Serial Numbers (ISSN or eISSN, respectively), that identifies the journal as a whole, not to individual issues of it.]"</para>
    /// labels<para>"journal"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Journal">http://purl.org/spar/fabio/Journal</seealso>
    let Journal = Prefixed_Name(fabio, "Journal") |> PrefixedName
    /// <summary>
    ///   <para>fabio:JournalArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An article, typically the realization of a research paper reporting original research findings, published in a journal issue.  "</para>
    /// labels<para>"journal article"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/JournalArticle">http://purl.org/spar/fabio/JournalArticle</seealso>
    let JournalArticle = Prefixed_Name(fabio, "JournalArticle") |> PrefixedName
    /// <summary>
    ///   <para>fabio:JournalEditorial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An editorial published in an issue of a journal."</para>
    /// labels<para>"journal editorial"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/JournalEditorial">http://purl.org/spar/fabio/JournalEditorial</seealso>
    let JournalEditorial = Prefixed_Name(fabio, "JournalEditorial") |> PrefixedName
    /// <summary>
    ///   <para>fabio:JournalIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A particular published issue of a journal, one or more of which will constitute a volume of the journal."</para>
    /// labels<para>"journal issue"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/JournalIssue">http://purl.org/spar/fabio/JournalIssue</seealso>
    let JournalIssue = Prefixed_Name(fabio, "JournalIssue") |> PrefixedName
    /// <summary>
    ///   <para>fabio:JournalNewsItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A news report published in a journal issue."</para>
    /// labels<para>"journal news item"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/JournalNewsItem">http://purl.org/spar/fabio/JournalNewsItem</seealso>
    let JournalNewsItem = Prefixed_Name(fabio, "JournalNewsItem") |> PrefixedName
    /// <summary>
    ///   <para>fabio:JournalVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A particular published volume of a journal, comprising one or more journal issues."</para>
    /// labels<para>"journal volume"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/JournalVolume">http://purl.org/spar/fabio/JournalVolume</seealso>
    let JournalVolume = Prefixed_Name(fabio, "JournalVolume") |> PrefixedName
    /// <summary>
    ///   <para>fabio:LaboratoryNotebook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A notebook used by an individual research scientist as the primary record of his or her research activities. A researcher may use a laboratory notebook to document hypotheses, to describe experiments and to record data in various formats, to provide details of data analysis and interpretation, or to record the validation or invalidation of the original hypotheses. The laboratory notebook serves as an organizational tool and a memory aid.  It may also have a role in recording and protecting any intellectual property created during the research, and may be used in evidence when establishing priority of discoveries, for example in patent applications.  Electronic versions of laboratory notebooks are increasingly being employed by researchers, particularly in chemistry and the pharmaceutical industry."</para>
    /// labels<para>"laboratory notebook"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/LaboratoryNotebook">http://purl.org/spar/fabio/LaboratoryNotebook</seealso>
    let LaboratoryNotebook = Prefixed_Name(fabio, "LaboratoryNotebook") |> PrefixedName
    /// <summary>
    ///   <para>fabio:LectureNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document containing notes that summarize a lecture or course of lectures."</para>
    /// labels<para>"lecture notes"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/LectureNotes">http://purl.org/spar/fabio/LectureNotes</seealso>
    let LectureNotes = Prefixed_Name(fabio, "LectureNotes") |> PrefixedName
    /// <summary>
    ///   <para>fabio:LegalOpinion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A written explanation by a judge or group of judges that accompanies a ruling in a legal case, laying out the reasons and legal principles for the ruling, and sometimes containing pronouncements about what the law is and how it should be interpreted."</para>
    /// labels<para>"legal opinion"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/LegalOpinion">http://purl.org/spar/fabio/LegalOpinion</seealso>
    let LegalOpinion = Prefixed_Name(fabio, "LegalOpinion") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Letter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A written or printed communication of a personal or professional nature between individuals and/or representatives of corporate bodies, usually transmitted by the postal service or published in a periodical.  In the latter case, the letter is typically addressed to the editor and comments on or discussed an item previously published by that periodical, or of interest to its readership."</para>
    /// labels<para>"letter"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Letter">http://purl.org/spar/fabio/Letter</seealso>
    let Letter = Prefixed_Name(fabio, "Letter") |> PrefixedName
    /// <summary>
    ///   <para>fabio:LibraryCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The catalog of the holdings of a library, for example that of the Library of Congress (http://catalog.loc.gov/)."</para>
    /// labels<para>"library catalog"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/LibraryCatalog">http://purl.org/spar/fabio/LibraryCatalog</seealso>
    let LibraryCatalog = Prefixed_Name(fabio, "LibraryCatalog") |> PrefixedName

    /// <summary>
    ///   <para>fabio:LiteraryArtisticWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A literary creative work, such as a novel, play, poem or song."</para>
    /// labels<para>"literary artistic work"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/LiteraryArtisticWork">http://purl.org/spar/fabio/LiteraryArtisticWork</seealso>
    let LiteraryArtisticWork =
        Prefixed_Name(fabio, "LiteraryArtisticWork") |> PrefixedName

    /// <summary>
    ///   <para>fabio:Magazine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A periodical, usually devoted to a particular topic or domain of interest, and usually published weekly or monthly, consisting primarily of  non-peer reviewed editorials, journalistic news items and more substantive articles, reviews, book reviews and discussions concerning current or recent events and publications, and matters of interest to the domain served by the magazine.  [Some scientific journals, notably Science and Nature, also secondarily serve as science magazines by containing substantive editorials and news items on vital or controversial issues]."</para>
    /// labels<para>"magazine"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Magazine">http://purl.org/spar/fabio/Magazine</seealso>
    let Magazine = Prefixed_Name(fabio, "Magazine") |> PrefixedName
    /// <summary>
    ///   <para>fabio:MagazineArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An article published in a magazine issue."</para>
    /// labels<para>"magazine article"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/MagazineArticle">http://purl.org/spar/fabio/MagazineArticle</seealso>
    let MagazineArticle = Prefixed_Name(fabio, "MagazineArticle") |> PrefixedName
    /// <summary>
    ///   <para>fabio:MagazineEditorial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An editorial published in an issue of a magazine."</para>
    /// labels<para>"magazine editorial"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/MagazineEditorial">http://purl.org/spar/fabio/MagazineEditorial</seealso>
    let MagazineEditorial = Prefixed_Name(fabio, "MagazineEditorial") |> PrefixedName
    /// <summary>
    ///   <para>fabio:MagazineIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A particular published  issue of a magazine, identified by date, and sometimes also by place (e.g. 'West Coast edition') or language (e.g. 'Spanish edition')."</para>
    /// labels<para>"magazine issue"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/MagazineIssue">http://purl.org/spar/fabio/MagazineIssue</seealso>
    let MagazineIssue = Prefixed_Name(fabio, "MagazineIssue") |> PrefixedName
    /// <summary>
    ///   <para>fabio:MagazineNewsItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A news report published in a magazine issue."</para>
    /// labels<para>"magazine news item"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/MagazineNewsItem">http://purl.org/spar/fabio/MagazineNewsItem</seealso>
    let MagazineNewsItem = Prefixed_Name(fabio, "MagazineNewsItem") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Manifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A subclass of FRBR manifestation, restricted to manifestations of fabio:Expressions. fabio:Manifestation specifically applies to electronic (digital) as well as to physical manifestations of expressions.
    ///
    /// Examples of different manifestations of a single 'version of record' expression of a scholarly work include an article in a print journal or the on-line version of that article as a web page."</para>
    /// labels<para>"manifestation"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Manifestation">http://purl.org/spar/fabio/Manifestation</seealso>
    let Manifestation = Prefixed_Name(fabio, "Manifestation") |> PrefixedName

    /// <summary>
    ///   <para>fabio:ManifestationCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of manifestations."</para>
    /// labels<para>"manifestation collection"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ManifestationCollection">http://purl.org/spar/fabio/ManifestationCollection</seealso>
    let ManifestationCollection =
        Prefixed_Name(fabio, "ManifestationCollection") |> PrefixedName

    /// <summary>
    ///   <para>fabio:Manuscript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A textual work prepared 'by hand', such as a typescript or word-processed pre-publication draft of a research paper or a report, or a work not otherwise reproduced in multiple copies.  [Note: fabio:Manuscript is not intended to describe a handwritten historical document on paper or parchment, for which the FRBR distinctions between work, expression, manifestation and item (individual copy) becomes blurred.]."</para>
    /// labels<para>"manuscript"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Manuscript">http://purl.org/spar/fabio/Manuscript</seealso>
    let Manuscript = Prefixed_Name(fabio, "Manuscript") |> PrefixedName
    /// <summary>
    ///   <para>fabio:MastersThesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A thesis reporting a research project undertaken as part of a graduate course of education leading to a master's degree."</para>
    /// labels<para>"master's thesis"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/MastersThesis">http://purl.org/spar/fabio/MastersThesis</seealso>
    let MastersThesis = Prefixed_Name(fabio, "MastersThesis") |> PrefixedName
    /// <summary>
    ///   <para>fabio:MeetingReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A report of a meeting of some kind."</para>
    /// labels<para>"meeting report"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/MeetingReport">http://purl.org/spar/fabio/MeetingReport</seealso>
    let MeetingReport = Prefixed_Name(fabio, "MeetingReport") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Metadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A separate work that provides information describing one or more characteristics of a resource or entity."</para>
    /// labels<para>"metadata"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Metadata">http://purl.org/spar/fabio/Metadata</seealso>
    let Metadata = Prefixed_Name(fabio, "Metadata") |> PrefixedName
    /// <summary>
    ///   <para>fabio:MetadataDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document that contains metadata information describing one or more characteristics of an entity."</para>
    /// labels<para>"metadata document"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/MetadataDocument">http://purl.org/spar/fabio/MetadataDocument</seealso>
    let MetadataDocument = Prefixed_Name(fabio, "MetadataDocument") |> PrefixedName
    /// <summary>
    ///   <para>fabio:MethodsPaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A scholarly work detailing a method, procedure or experimental protocol employed in a particular scholarly domain."</para>
    /// labels<para>"methods paper"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/MethodsPaper">http://purl.org/spar/fabio/MethodsPaper</seealso>
    let MethodsPaper = Prefixed_Name(fabio, "MethodsPaper") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Microblog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A social networking publication medium such as Twitter, Tumblr, FriendFeed, Facebook or MySpace. A microblog differs from a traditional blog in that its individual content items are smaller than a traditional blog posts, typically containing just a short sentence, a single image, or a URI.  These small messages are referred to as microposts."</para>
    /// labels<para>"microblog"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Microblog">http://purl.org/spar/fabio/Microblog</seealso>
    let Microblog = Prefixed_Name(fabio, "Microblog") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Micropost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A content item that is published in a Microblog, typically containing just a short sentence, a single image, or a URL."</para>
    /// labels<para>"micropost"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Micropost">http://purl.org/spar/fabio/Micropost</seealso>
    let Micropost = Prefixed_Name(fabio, "Micropost") |> PrefixedName

    /// <summary>
    ///   <para>fabio:MinimalInformationStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A metadata standard specifying items to be included when creating metadata describing a dataset of a particular type, or when creating a structured summary of the main findings of an article or report in a particular domain of interest, thereby ensuring adequate descriptive information is recorded for subsequent resource discovery and/or interpretation of the information described.  [See also fabio:ReportingStandard.]"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"minimal information standard"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/MinimalInformationStandard">http://purl.org/spar/fabio/MinimalInformationStandard</seealso>
    let MinimalInformationStandard =
        Prefixed_Name(fabio, "MinimalInformationStandard") |> PrefixedName

    /// <summary>
    ///   <para>fabio:Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A mathematical, graphical or physical representation of some physical reality, conceptual idea or theoretical construct."</para>
    /// labels<para>"model"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Model">http://purl.org/spar/fabio/Model</seealso>
    let Model = Prefixed_Name(fabio, "Model") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Movie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The realization of a moving image."</para>
    /// labels<para>"movie"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Movie">http://purl.org/spar/fabio/Movie</seealso>
    let Movie = Prefixed_Name(fabio, "Movie") |> PrefixedName
    /// <summary>
    ///   <para>fabio:MovingImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A moving display, either generated dynamically by a computer program or formed from a series of pre-recorded still images imparting an impression of motion when shown in succession.  Examples include animations, cine films, videos, and computational simulations. Expressions of moving images may incorporate synchronized soundtracks."</para>
    /// labels<para>"moving image"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/MovingImage">http://purl.org/spar/fabio/MovingImage</seealso>
    let MovingImage = Prefixed_Name(fabio, "MovingImage") |> PrefixedName
    /// <summary>
    ///   <para>fabio:MusicalComposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A piece of music, typically in the form of a composition recorded in musical notation."</para>
    /// labels<para>"musical composition"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/MusicalComposition">http://purl.org/spar/fabio/MusicalComposition</seealso>
    let MusicalComposition = Prefixed_Name(fabio, "MusicalComposition") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Nanopublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A single, attributable and machine-readable factual assertion - the smallest unit of publishable information that can be uniquely identified and attributed to its author – typically expressed in RDF.  The minimal components of a nanopublication are as follows:
    /// * the factual assertion itself, in the form subject, predicate and object (e.g. malaria is_a disease);
    /// * provenance information about the nanopublication, defining its authorship and creation date;
    /// * supporting information (optional), providing context for the assertion;
    /// * a unique identifier for the nanopublication, in the form of a URI;
    /// * an integrity key that ensures that the nanopublication is in its original form and has not been altered.
    /// "</para>
    /// labels<para>"nanopublication"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Nanopublication">http://purl.org/spar/fabio/Nanopublication</seealso>
    let Nanopublication = Prefixed_Name(fabio, "Nanopublication") |> PrefixedName
    /// <summary>
    ///   <para>fabio:NewsItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A published news report."</para>
    /// labels<para>"news item"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/NewsItem">http://purl.org/spar/fabio/NewsItem</seealso>
    let NewsItem = Prefixed_Name(fabio, "NewsItem") |> PrefixedName
    /// <summary>
    ///   <para>fabio:NewsReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A report of an item of news."</para>
    /// labels<para>"news report"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/NewsReport">http://purl.org/spar/fabio/NewsReport</seealso>
    let NewsReport = Prefixed_Name(fabio, "NewsReport") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Newspaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A non-peer reviewed periodical, usually published daily or weekly, consisting primarily of editorials and news items concerning current or recent events and matters of public interest."</para>
    /// labels<para>"newspaper"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Newspaper">http://purl.org/spar/fabio/Newspaper</seealso>
    let Newspaper = Prefixed_Name(fabio, "Newspaper") |> PrefixedName
    /// <summary>
    ///   <para>fabio:NewspaperArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An article written by a journalist and published in a newspaper."</para>
    /// labels<para>"newspaper article"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/NewspaperArticle">http://purl.org/spar/fabio/NewspaperArticle</seealso>
    let NewspaperArticle = Prefixed_Name(fabio, "NewspaperArticle") |> PrefixedName
    /// <summary>
    ///   <para>fabio:NewspaperEditorial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An editorial published in an issue of a newspaper."</para>
    /// labels<para>"newspaper editorial"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/NewspaperEditorial">http://purl.org/spar/fabio/NewspaperEditorial</seealso>
    let NewspaperEditorial = Prefixed_Name(fabio, "NewspaperEditorial") |> PrefixedName
    /// <summary>
    ///   <para>fabio:NewspaperIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A particular published  issue of a newspaper, identified by date, and sometimes also by place or time (e.g. 'Late London Edition')."</para>
    /// labels<para>"newspaper issue"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/NewspaperIssue">http://purl.org/spar/fabio/NewspaperIssue</seealso>
    let NewspaperIssue = Prefixed_Name(fabio, "NewspaperIssue") |> PrefixedName
    /// <summary>
    ///   <para>fabio:NewspaperNewsItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A news report published in a newspaper issue."</para>
    /// labels<para>"newspaper news item"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/NewspaperNewsItem">http://purl.org/spar/fabio/NewspaperNewsItem</seealso>
    let NewspaperNewsItem = Prefixed_Name(fabio, "NewspaperNewsItem") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Notebook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A book containing personal notes, typically created by writing into a physical book with blank pages."</para>
    /// labels<para>"notebook"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Notebook">http://purl.org/spar/fabio/Notebook</seealso>
    let Notebook = Prefixed_Name(fabio, "Notebook") |> PrefixedName

    /// <summary>
    ///   <para>fabio:NotificationOfReceipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A notification of receipt of something, for example of receipt of a book that will later be the subject of a book review."</para>
    /// labels<para>"notification of receipt"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/NotificationOfReceipt">http://purl.org/spar/fabio/NotificationOfReceipt</seealso>
    let NotificationOfReceipt =
        Prefixed_Name(fabio, "NotificationOfReceipt") |> PrefixedName

    /// <summary>
    ///   <para>fabio:Novel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A long fictitious narrative written in literary prose."</para>
    /// labels<para>"novel"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Novel">http://purl.org/spar/fabio/Novel</seealso>
    let Novel = Prefixed_Name(fabio, "Novel") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Obituary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A news item reporting the death of a person, typically accompanied by an description of that person's life and contributions to his or her profession and to society at large."</para>
    /// labels<para>"obituary"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Obituary">http://purl.org/spar/fabio/Obituary</seealso>
    let Obituary = Prefixed_Name(fabio, "Obituary") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A formal representation of a set of concepts within a domain of knowledge, and the logical relationships between those concepts.  [Contrast fabio:Folksonomy]"</para>
    /// labels<para>"ontology"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Ontology">http://purl.org/spar/fabio/Ontology</seealso>
    let Ontology = Prefixed_Name(fabio, "Ontology") |> PrefixedName
    /// <summary>
    ///   <para>fabio:OntologyDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document containing an ontology, for example an OWL (Web Ontology Language) file (http://www.w3.org/TR/owl-features/)."</para>
    /// labels<para>"ontology document"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/OntologyDocument">http://purl.org/spar/fabio/OntologyDocument</seealso>
    let OntologyDocument = Prefixed_Name(fabio, "OntologyDocument") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Opinion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An expression of a personal or professional opinion on an issue or topic."</para>
    /// labels<para>"opinion"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Opinion">http://purl.org/spar/fabio/Opinion</seealso>
    let Opinion = Prefixed_Name(fabio, "Opinion") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Oration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A formal speech, for example one delivered at a ceremonial occasion, or the written transcript of such a speech."</para>
    /// labels<para>"oration"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Oration">http://purl.org/spar/fabio/Oration</seealso>
    let Oration = Prefixed_Name(fabio, "Oration") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Page</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A manifestation that represents pages either in physical (e.g., one side of a sheet of paper) or in digital form (e.g., a page in a PDF, or a web page)."</para>
    /// labels<para>"page"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Page">http://purl.org/spar/fabio/Page</seealso>
    let Page = Prefixed_Name(fabio, "Page") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Paperback</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A print object with a flexible cover, usually made of paper or paperboard."</para>
    /// labels<para>"paperback"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Paperback">http://purl.org/spar/fabio/Paperback</seealso>
    let Paperback = Prefixed_Name(fabio, "Paperback") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Patent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A formal disclosure of a new invention approved by a governmental patent agency, made to register intellectual property rights, and to give exclusive rights to the inventor or assignee to manufacture, use, license or sell the invention for a certain number of years."</para>
    /// labels<para>"patent"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Patent">http://purl.org/spar/fabio/Patent</seealso>
    let Patent = Prefixed_Name(fabio, "Patent") |> PrefixedName
    /// <summary>
    ///   <para>fabio:PatentApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A formal disclosure of a new invention, made in application for a patent."</para>
    /// labels<para>"patent application"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/PatentApplication">http://purl.org/spar/fabio/PatentApplication</seealso>
    let PatentApplication = Prefixed_Name(fabio, "PatentApplication") |> PrefixedName

    /// <summary>
    ///   <para>fabio:PatentApplicationDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The physical or electronic realization of a patent application."</para>
    /// labels<para>"patent application document"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/PatentApplicationDocument">http://purl.org/spar/fabio/PatentApplicationDocument</seealso>
    let PatentApplicationDocument =
        Prefixed_Name(fabio, "PatentApplicationDocument") |> PrefixedName

    /// <summary>
    ///   <para>fabio:PatentDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The physical or electronic realization of a patent."</para>
    /// labels<para>"patent document"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/PatentDocument">http://purl.org/spar/fabio/PatentDocument</seealso>
    let PatentDocument = Prefixed_Name(fabio, "PatentDocument") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Periodical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A publication issued on a regular and ongoing basis as a series of issues, each issue comprising separate periodical items, for example editorials, articles, news items and/or other writings."</para>
    /// labels<para>"periodical"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Periodical">http://purl.org/spar/fabio/Periodical</seealso>
    let Periodical = Prefixed_Name(fabio, "Periodical") |> PrefixedName
    /// <summary>
    ///   <para>fabio:PeriodicalIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A particular issue of a periodical, identified and distinguished from other issues of the same publication by date and/or issue number and/or volume number, and comprising separate periodical items such as editorials, articles and news items."</para>
    /// labels<para>"periodical issue"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/PeriodicalIssue">http://purl.org/spar/fabio/PeriodicalIssue</seealso>
    let PeriodicalIssue = Prefixed_Name(fabio, "PeriodicalIssue") |> PrefixedName
    /// <summary>
    ///   <para>fabio:PeriodicalItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A piece of writing published in a periodical issue, typically accompanied by other items by different authors."</para>
    /// labels<para>"periodical item"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/PeriodicalItem">http://purl.org/spar/fabio/PeriodicalItem</seealso>
    let PeriodicalItem = Prefixed_Name(fabio, "PeriodicalItem") |> PrefixedName
    /// <summary>
    ///   <para>fabio:PeriodicalVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A particular published volume of a periodical."</para>
    /// labels<para>"periodical volume"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/PeriodicalVolume">http://purl.org/spar/fabio/PeriodicalVolume</seealso>
    let PeriodicalVolume = Prefixed_Name(fabio, "PeriodicalVolume") |> PrefixedName

    /// <summary>
    ///   <para>fabio:PersonalCommunication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Information communicated personally by verbal or written means from one individual to one or more another persons or organizations."</para>
    /// labels<para>"personal communication"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/PersonalCommunication">http://purl.org/spar/fabio/PersonalCommunication</seealso>
    let PersonalCommunication =
        Prefixed_Name(fabio, "PersonalCommunication") |> PrefixedName

    /// <summary>
    ///   <para>fabio:PhDSymposiumPaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A paper, usually presented during a specific session of a conference dedicated to Ph.D. students, that describes ongoing Ph.D. student's research."</para>
    /// labels<para>"Ph.D. symposium paper"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/PhDSymposiumPaper">http://purl.org/spar/fabio/PhDSymposiumPaper</seealso>
    let PhDSymposiumPaper = Prefixed_Name(fabio, "PhDSymposiumPaper") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Play</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A form of literature written by a playwright, usually consisting of scripted dialogue between characters, intended for theatrical performance rather than reading."</para>
    /// labels<para>"play"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Play">http://purl.org/spar/fabio/Play</seealso>
    let Play = Prefixed_Name(fabio, "Play") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Poem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An artistic work written with an intensity or beauty of language more characteristic of poetry than of prose."</para>
    /// labels<para>"poem"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Poem">http://purl.org/spar/fabio/Poem</seealso>
    let Poem = Prefixed_Name(fabio, "Poem") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Policy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A description and definition of how something should be done.  Ideally a policy should be both effective in achieving its goals and acceptable to those who have to abide by it."</para>
    /// labels<para>"policy"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Policy">http://purl.org/spar/fabio/Policy</seealso>
    let Policy = Prefixed_Name(fabio, "Policy") |> PrefixedName
    /// <summary>
    ///   <para>fabio:PolicyDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document embodying a policy that descibes and defines how something should be done. "</para>
    /// labels<para>"policy document"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/PolicyDocument">http://purl.org/spar/fabio/PolicyDocument</seealso>
    let PolicyDocument = Prefixed_Name(fabio, "PolicyDocument") |> PrefixedName
    /// <summary>
    ///   <para>fabio:PositionPaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A scholarly work that reports a particular intellectual position or viewpoint regarding a particular scholarly topic. Usually, these papers are dependent on the author's opinion or interpretation, do not have an evaluation, and need to present relevant and novel discussion points in a thorough manner.
    ///
    /// E.g. see https://datasciencehub.net/content/guidelines-authors"</para>
    /// labels<para>"position paper"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/PositionPaper">http://purl.org/spar/fabio/PositionPaper</seealso>
    let PositionPaper = Prefixed_Name(fabio, "PositionPaper") |> PrefixedName
    /// <summary>
    ///   <para>fabio:PosterPaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A paper that typically accompanies a poster describing some preliminary  results of research, usually presented during a conference or a workshop."</para>
    /// labels<para>"poster paper"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/PosterPaper">http://purl.org/spar/fabio/PosterPaper</seealso>
    let PosterPaper = Prefixed_Name(fabio, "PosterPaper") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Postprint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The version of an author's original scholarly work, such as a research paper or a review, re-submitted for publication after revision by the author in the light of comments from reviewers.  [Note: For the version before peer review, use fabio:Preprint. For the final piblished version, use fabio:DefinitiveVersion.]"</para>
    /// labels<para>"postprint"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Postprint">http://purl.org/spar/fabio/Postprint</seealso>
    let Postprint = Prefixed_Name(fabio, "Postprint") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Preprint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The version of an author's original scholarly work, such as a research paper or a review, first submitted to publisher for publication.  [Note: For that version resubmitted after peer-review and revision, use fabio:Postprint. For the final published version use fabio:DefinitiveVersion.]"</para>
    /// labels<para>"preprint"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Preprint">http://purl.org/spar/fabio/Preprint</seealso>
    let Preprint = Prefixed_Name(fabio, "Preprint") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Presentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of slides containing text, tables or figures, designed to communicate ideas or research results, for projection and viewing by an audience at a conference, symposium, seminar, lecture, workshop or other gatherings, typically embodied in a particular manifestation format such as a SlideShare or PowerPoint slideshow."</para>
    /// labels<para>"presentation"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Presentation">http://purl.org/spar/fabio/Presentation</seealso>
    let Presentation = Prefixed_Name(fabio, "Presentation") |> PrefixedName
    /// <summary>
    ///   <para>fabio:PressRelease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A news report published by an organization to provide information to journalists."</para>
    /// labels<para>"press release"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/PressRelease">http://purl.org/spar/fabio/PressRelease</seealso>
    let PressRelease = Prefixed_Name(fabio, "PressRelease") |> PrefixedName
    /// <summary>
    ///   <para>fabio:PrintObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An analog manifestation in physical printed form, typically on paper."</para>
    /// labels<para>"print object"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/PrintObject">http://purl.org/spar/fabio/PrintObject</seealso>
    let PrintObject = Prefixed_Name(fabio, "PrintObject") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ProceedingsPaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A paper, typically the realization of a research paper reporting original research findings, usually published within an academic proceedings volume."</para>
    /// labels<para>"proceedings paper"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ProceedingsPaper">http://purl.org/spar/fabio/ProceedingsPaper</seealso>
    let ProceedingsPaper = Prefixed_Name(fabio, "ProceedingsPaper") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ProductReview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A written review and critical analysis of the purpose, features, performance and other qualities of a product."</para>
    /// labels<para>"product review"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ProductReview">http://purl.org/spar/fabio/ProductReview</seealso>
    let ProductReview = Prefixed_Name(fabio, "ProductReview") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ProjectMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Metadata describing a project, for example the project name, the names of those who conducted the project, the name of the institution in which the project was conducted, and the project funding information."</para>
    /// labels<para>"project metadata"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ProjectMetadata">http://purl.org/spar/fabio/ProjectMetadata</seealso>
    let ProjectMetadata = Prefixed_Name(fabio, "ProjectMetadata") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ProjectPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document used to guide project planning, execution and control, specifying the project's goal and objectives and the activities and resources required to achieve these, setting out the project schedule, and identifying the major workpackages, milestones and deliverables.  A project plan will typically contain a Gantt chart.
    /// "</para>
    /// labels<para>"project plan"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ProjectPlan">http://purl.org/spar/fabio/ProjectPlan</seealso>
    let ProjectPlan = Prefixed_Name(fabio, "ProjectPlan") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ProjectReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A report describing the outcomes of specific project, typically listing 'deliverables' created or 'milestones' achieved during the project."</para>
    /// labels<para>"deliverable report"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ProjectReport">http://purl.org/spar/fabio/ProjectReport</seealso>
    let ProjectReport = Prefixed_Name(fabio, "ProjectReport") |> PrefixedName

    /// <summary>
    ///   <para>fabio:ProjectReportDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document containing a project report, intended to be delivered to a customer or funding agency describing the results achieved within a specific project. "</para>
    /// labels<para>"deliverable"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ProjectReportDocument">http://purl.org/spar/fabio/ProjectReportDocument</seealso>
    let ProjectReportDocument =
        Prefixed_Name(fabio, "ProjectReportDocument") |> PrefixedName

    /// <summary>
    ///   <para>fabio:ProjectReportSummary</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ProjectReportSummary">http://purl.org/spar/fabio/ProjectReportSummary</seealso>
    let ProjectReportSummary =
        Prefixed_Name(fabio, "ProjectReportSummary") |> PrefixedName

    /// <summary>
    ///   <para>fabio:Proof</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In printing and publishing, a proof copy is the preliminary version of a publication, after the inclusion of any author corrections following review, and after copy editing and formatting to bring the manuscript into the house style, intended for final checking prior to publication to detect and eliminate typographical errors, omissions or transpositions of text, incorrect layout or placement of illustrations and tables, or other formatting errors.  Those who check proofs include the editor, possibly the peer-reviewers (to ensure that their requested modifications have been included to their satisfaction), possibly an in-house professional proof-reader, and / or the author, who is ultimately responsible for ensuring the published work says what (s)he means it to say.  Substantive changes to the text are not permitted once the manuscript has reached proof stage."</para>
    /// labels<para>"proof"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Proof">http://purl.org/spar/fabio/Proof</seealso>
    let Proof = Prefixed_Name(fabio, "Proof") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Proposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A proposal or proposition of a new conceptualization, hypothesis, idea, theory, activity or organisation."</para>
    /// labels<para>"proposition"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Proposition">http://purl.org/spar/fabio/Proposition</seealso>
    let Proposition = Prefixed_Name(fabio, "Proposition") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Questionnaire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of questions on a particular topic, usually in the form of multiple choice questions requiring the respondent to select the correct answer, or providing the ability to indicate support for or against a proposal on a numerical scale, designed for rapid numerical analysis of responses and often used in surveying public opinion."</para>
    /// labels<para>"questionnaire"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Questionnaire">http://purl.org/spar/fabio/Questionnaire</seealso>
    let Questionnaire = Prefixed_Name(fabio, "Questionnaire") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Quotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A passage of speech selected from a larger verbal or written expression for use in another expression, with specific attribution to its original source, and usually demarcated by quotation marks and / or by placing it in a separate indented paragraph.
    ///
    /// [Note: Use fabio:Quotation to indicate a segment or passage selected from another expression that is a passage of speech, and fabio:Excerpt to indicate a segment or passage selected from another expression that is not a passage of speech.]"</para>
    /// labels<para>"quotation"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Quotation">http://purl.org/spar/fabio/Quotation</seealso>
    let Quotation = Prefixed_Name(fabio, "Quotation") |> PrefixedName
    /// <summary>
    ///   <para>fabio:RapidCommunication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A short rapidly published research article or conference paper, typically reporting significant research results that have been recently discovered, or a brief news item reporting such discoveries."</para>
    /// labels<para>"rapid communication"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/RapidCommunication">http://purl.org/spar/fabio/RapidCommunication</seealso>
    let RapidCommunication = Prefixed_Name(fabio, "RapidCommunication") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ReferenceBook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A book containing authoritative factual information, such as a dictionary, encyclopaedia, handbook or field guide, which is a realisation of a certain reference work and may contain several reference entries."</para>
    /// labels<para>"reference book"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ReferenceBook">http://purl.org/spar/fabio/ReferenceBook</seealso>
    let ReferenceBook = Prefixed_Name(fabio, "ReferenceBook") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ReferenceEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A particular reference entry containing authoritative factual information on a certain topic, usually contained in a larger expression."</para>
    /// labels<para>"reference entry"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ReferenceEntry">http://purl.org/spar/fabio/ReferenceEntry</seealso>
    let ReferenceEntry = Prefixed_Name(fabio, "ReferenceEntry") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ReferenceWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A work to which people refer for authoritative factual information, such as a dictionary, encyclopaedia, entry, handbook or field guide, or an informative web page such as an institutional, research group or project home page."</para>
    /// labels<para>"reference work"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ReferenceWork">http://purl.org/spar/fabio/ReferenceWork</seealso>
    let ReferenceWork = Prefixed_Name(fabio, "ReferenceWork") |> PrefixedName
    /// <summary>
    ///   <para>fabio:RelationalDatabase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A database in which the data are arranged in tables according to their common characteristics, with relationships between the tables being defined by a relational model or schema. A relational database is highly optimized for performance, and is queried using a database query language such as SQL (Structured Query Language).  The software used to create a relational database is called a relational database management system (RDBMS)."</para>
    /// labels<para>"relational database"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/RelationalDatabase">http://purl.org/spar/fabio/RelationalDatabase</seealso>
    let RelationalDatabase = Prefixed_Name(fabio, "RelationalDatabase") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Reply</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A work that is a reply, either to a letter or other direct communication, or to feedback or comments about a piece of submitted writing.  The latter is typically written by the author of a journal article submitted for publication, or by an applicant making a grant application, in response to reviews of the work from peer reviewers prior to publication (for the journal article) or prior to funding decision (for the grant application).  Alternatively, it can be written in response to post-publication peer-review of a published journal article, or comments about it."</para>
    /// labels<para>"reply"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Reply">http://purl.org/spar/fabio/Reply</seealso>
    let Reply = Prefixed_Name(fabio, "Reply") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Report</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A formal factual, methodological, statistical, technical or research report issued by an individual, group, agency, government body or other institution."</para>
    /// labels<para>"report"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Report">http://purl.org/spar/fabio/Report</seealso>
    let Report = Prefixed_Name(fabio, "Report") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ReportDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The realization of a report, usually in printed form."</para>
    /// labels<para>"report document"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ReportDocument">http://purl.org/spar/fabio/ReportDocument</seealso>
    let ReportDocument = Prefixed_Name(fabio, "ReportDocument") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ReportingStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of recommendations for the minimum reporting requirements to be employed when reporting a particular type of investigation or project, for example a randomized clinical trial.  A reporting standard may involve a checklist and a flow diagram, offers a standard way for authors to prepare a complete and transparent report of their findings, and aids their critical appraisal and interpretation of their data. [See also fabio:MinimalInformationStandard.]"</para>
    /// labels<para>"reporting standard"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ReportingStandard">http://purl.org/spar/fabio/ReportingStandard</seealso>
    let ReportingStandard = Prefixed_Name(fabio, "ReportingStandard") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Repository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A computer system in which information may be stored."</para>
    /// labels<para>"repository"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Repository">http://purl.org/spar/fabio/Repository</seealso>
    let Repository = Prefixed_Name(fabio, "Repository") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ResearchPaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A scholarly work that reports original research contributions addressing theoretical, analytical or experimental aspects of a particular scholarly domain.
    ///
    /// E.g. see http://iswc2018.semanticweb.org/call-for-research-track-papers/."</para>
    /// labels<para>"research paper"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ResearchPaper">http://purl.org/spar/fabio/ResearchPaper</seealso>
    let ResearchPaper = Prefixed_Name(fabio, "ResearchPaper") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ResourcePaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A scholarly work that describes resources developed to provide experimental materials or facilities, support a research hypothesis, to provide answers to a research question, or that have contributed to the generation of novel scientific work. Examples of such resources include, for experimental sciences, mouse mutant lines and large communally used X-ray or neutron sources, and, for computer sciences, datasets, ontologies, vocabularies, ontology design patterns, evaluation benchmarks or methods, services, APIs and software frameworks, workflows, crowdsourcing task designs, protocols and metrics.
    ///
    /// E.g. see http://iswc2018.semanticweb.org/call-for-resources-track-papers/"</para>
    /// labels<para>"resource paper"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ResourcePaper">http://purl.org/spar/fabio/ResourcePaper</seealso>
    let ResourcePaper = Prefixed_Name(fabio, "ResourcePaper") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Retraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A formal statement retracting a statement or publication
    /// A retraction is a public statement made about an earlier statement that withdraws, cancels, refutes, diametrically reverses the original statement or ceases and desists from publishing the original statement. "</para>
    /// labels<para>"retraction"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Retraction">http://purl.org/spar/fabio/Retraction</seealso>
    let Retraction = Prefixed_Name(fabio, "Retraction") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Review</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A review of others' work."</para>
    /// labels<para>"review"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Review">http://purl.org/spar/fabio/Review</seealso>
    let Review = Prefixed_Name(fabio, "Review") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ReviewArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An article that contains a review."</para>
    /// labels<para>"review article"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ReviewArticle">http://purl.org/spar/fabio/ReviewArticle</seealso>
    let ReviewArticle = Prefixed_Name(fabio, "ReviewArticle") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ReviewPaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A scholarly work that surveys the state of the art of topics central to a particular subject or relating to a specific domain (e.g. the scope of a certain journal or conference). Papers of this kind may contain a selective bibliography listing key papers related to the subject or providing advice on information sources, or they may strive to be comprehensive, covering all contributions to the development of a topic and exploring their different findings or views.
    ///
    /// E.g. see http://www.emeraldgrouppublishing.com/products/journals/author_guidelines.htm?id=JD"</para>
    /// labels<para>"review paper"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ReviewPaper">http://purl.org/spar/fabio/ReviewPaper</seealso>
    let ReviewPaper = Prefixed_Name(fabio, "ReviewPaper") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ScholarlyWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A work that reports scholarly activity on a particular topic, either published in written form, or delivered orally at a meeting."</para>
    /// labels<para>"scholarly work"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ScholarlyWork">http://purl.org/spar/fabio/ScholarlyWork</seealso>
    let ScholarlyWork = Prefixed_Name(fabio, "ScholarlyWork") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Screenplay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A written work made especially for a film or television program. Screenplays can be original works or adaptations from existing pieces of writing, for example novels. "</para>
    /// labels<para>"screenplay"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Screenplay">http://purl.org/spar/fabio/Screenplay</seealso>
    let Screenplay = Prefixed_Name(fabio, "Screenplay") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Script</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A small computer program written in a scripting language such as JavaScript, PHP or Perl that allows control of one or more software applications."</para>
    /// labels<para>"script"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Script">http://purl.org/spar/fabio/Script</seealso>
    let Script = Prefixed_Name(fabio, "Script") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Series</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sequence of expressions having certain characteristics in common that are formally identified together as a group."</para>
    /// labels<para>"series"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Series">http://purl.org/spar/fabio/Series</seealso>
    let Series = Prefixed_Name(fabio, "Series") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ShortStory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A work of fiction that is usually written in prose, often in narrative format. This format tends to be more focused and less elaborate than longer works of fiction such as novels."</para>
    /// labels<para>"short story"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ShortStory">http://purl.org/spar/fabio/ShortStory</seealso>
    let ShortStory = Prefixed_Name(fabio, "ShortStory") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Song</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A musical composition that contains vocal parts ('lyrics') that are performed ('sung')."</para>
    /// labels<para>"song"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Song">http://purl.org/spar/fabio/Song</seealso>
    let Song = Prefixed_Name(fabio, "Song") |> PrefixedName
    /// <summary>
    ///   <para>fabio:SoundRecording</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The creative work of making an electrical or mechanical recording of sounds, such as the spoken voice, singing, instrumental music, animal vocalizations or sound effects. "</para>
    /// labels<para>"sound recording"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/SoundRecording">http://purl.org/spar/fabio/SoundRecording</seealso>
    let SoundRecording = Prefixed_Name(fabio, "SoundRecording") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Specification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An explicit description of, or set of requirements to be satisfied by, a material, product, resource, service or standard."</para>
    /// labels<para>"specification"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Specification">http://purl.org/spar/fabio/Specification</seealso>
    let Specification = Prefixed_Name(fabio, "Specification") |> PrefixedName

    /// <summary>
    ///   <para>fabio:SpecificationDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The realization of a specification (a standard, a workflow, etc.)."</para>
    /// labels<para>"specification document"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/SpecificationDocument">http://purl.org/spar/fabio/SpecificationDocument</seealso>
    let SpecificationDocument =
        Prefixed_Name(fabio, "SpecificationDocument") |> PrefixedName

    /// <summary>
    ///   <para>fabio:Spreadsheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An electronic form of data storage that displays a grid of rows and columns, in which each editable cell can contain alphanumeric text, a numeric value, or a formula that defines how the content of that cell is to be calculated from the content of another cell or cells."</para>
    /// labels<para>"spreadsheet"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Spreadsheet">http://purl.org/spar/fabio/Spreadsheet</seealso>
    let Spreadsheet = Prefixed_Name(fabio, "Spreadsheet") |> PrefixedName

    /// <summary>
    ///   <para>fabio:StandardOperatingProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Clear and detailed written instructions of a prescribed step-by-step procedure to be routinely followed, and decisions to be made when undertaking a specific task, process or function, to achieve consistent performance, ensure safety and/or assure data quality.  (Commonly abbreviated 'SOP'.)"</para>
    /// labels<para>"standard operating procedure"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/StandardOperatingProcedure">http://purl.org/spar/fabio/StandardOperatingProcedure</seealso>
    let StandardOperatingProcedure =
        Prefixed_Name(fabio, "StandardOperatingProcedure") |> PrefixedName

    /// <summary>
    ///   <para>fabio:StillImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A recorded static visual representation. This class of image includes diagrams, drawings, graphs, graphic designs, plans, maps, photographs and prints."</para>
    /// labels<para>"still image"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/StillImage">http://purl.org/spar/fabio/StillImage</seealso>
    let StillImage = Prefixed_Name(fabio, "StillImage") |> PrefixedName
    /// <summary>
    ///   <para>fabio:StorageMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A device for recording information or storing data."</para>
    /// labels<para>"storage medium"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/StorageMedium">http://purl.org/spar/fabio/StorageMedium</seealso>
    let StorageMedium = Prefixed_Name(fabio, "StorageMedium") |> PrefixedName
    /// <summary>
    ///   <para>fabio:StructuredSummary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A structured summary containing essential metadata describing a research investigation and/or the research outputs that have resulted from it, for example datasets and journal articles, structured according to some minimal information standard.  Such a structured summary can be embodied in both human-readable and machine-readable manifestations, e.g. HTML and RDF.  Such a structured summary differs from the Abstract of a journal article, in that the latter is written as a piece of continuous prose, but typically omits vital factual information about the investigation, such as when and where it was conducted, by whom, and on now many specimens or subjects."</para>
    /// labels<para>"structured summary"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/StructuredSummary">http://purl.org/spar/fabio/StructuredSummary</seealso>
    let StructuredSummary = Prefixed_Name(fabio, "StructuredSummary") |> PrefixedName
    /// <summary>
    ///   <para>fabio:SubjectDiscipline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A concept that identifies a field of knowledge or human activity defined in a controlled vocabulary, such as Computer Science, Biology, Economics, Cookery or Swimming."</para>
    /// labels<para>"subject discipline"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/SubjectDiscipline">http://purl.org/spar/fabio/SubjectDiscipline</seealso>
    let SubjectDiscipline = Prefixed_Name(fabio, "SubjectDiscipline") |> PrefixedName
    /// <summary>
    ///   <para>fabio:SubjectTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A concept that defines a term within the controlled vocabulary of a particular classification system, such as the ACM Computing Classification System or MeSH, the Medical Subject Headings, used as an annotation to describe the subject, meaning or content of an entity."</para>
    /// labels<para>"subject term"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/SubjectTerm">http://purl.org/spar/fabio/SubjectTerm</seealso>
    let SubjectTerm = Prefixed_Name(fabio, "SubjectTerm") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Supplement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A supplement to a publication such as a book, journal, magazine or newspaper, additional to the main publication.  For example, a colour supplement to a sunday newspaper, or a special supplementary issue of a journal or a journal volume containing invited articles on a special topic, or abstracts or papers presented at a scientific conference."</para>
    /// labels<para>"supplement"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Supplement">http://purl.org/spar/fabio/Supplement</seealso>
    let Supplement = Prefixed_Name(fabio, "Supplement") |> PrefixedName

    /// <summary>
    ///   <para>fabio:SupplementaryInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A file accompanying a published journal article, containing additional information of relevance to the article, typically available from the publisher's web site via a hyperlink from the journal article itself."</para>
    /// labels<para>"supplementary information file"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/SupplementaryInformation">http://purl.org/spar/fabio/SupplementaryInformation</seealso>
    let SupplementaryInformation =
        Prefixed_Name(fabio, "SupplementaryInformation") |> PrefixedName

    /// <summary>
    ///   <para>fabio:SupplementaryInformationFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A file accompanying a published journal article, containing additional information of relevance to the article, typically available from the publisher's web site via a hyperlink from the journal article itself."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/fabio/SupplementaryInformationFile">http://purl.org/spar/fabio/SupplementaryInformationFile</seealso>
    let SupplementaryInformationFile =
        Prefixed_Name(fabio, "SupplementaryInformationFile") |> PrefixedName

    /// <summary>
    ///   <para>fabio:SystematicReview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A literature review focused on a single question that tries to identify, appraise, select and synthesize all high quality research evidence relevant to that question. Systematic reviews of high-quality randomized controlled trials are crucial to evidence-based medicine. An understanding of systematic reviews and how to implement them in practice is becoming mandatory for all professionals involved in the delivery of health care. Systematic reviews are not limited to medicine,  and are quite common in other sciences such as psychology, educational research and sociology."</para>
    /// labels<para>"systematic review"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/SystematicReview">http://purl.org/spar/fabio/SystematicReview</seealso>
    let SystematicReview = Prefixed_Name(fabio, "SystematicReview") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Table</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A graphical means of presenting data in a grid of rows and columns, within which the cells usually contain alphanumeric text or numeric values.  If included within a publication, a table typically appearing unaligned with the main body of text, with its own descriptive title."</para>
    /// labels<para>"table"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Table">http://purl.org/spar/fabio/Table</seealso>
    let Table = Prefixed_Name(fabio, "Table") |> PrefixedName
    /// <summary>
    ///   <para>fabio:TableOfContents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A table listing the parts of publication such as a book or technical specification, and the pages on which these content elements start (if the publication is printed or otherwise organized into pages), usually listed in order of appearance.  The Table of Contents typically includes first-level headers, such as the chapter titles of a book, and may also include second- and even third-level headers.  In electronic works, the Table of Contents entries are often internally hyperlinked to the content items, so that clicking on the entry takes the reader to that item."</para>
    /// labels<para>"table of contents"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/TableOfContents">http://purl.org/spar/fabio/TableOfContents</seealso>
    let TableOfContents = Prefixed_Name(fabio, "TableOfContents") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Taxonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A classification arranged in a hierarchical structure of classes and subclasses, showing parent-child isA relationships, or broader_than - narrower_than relationships."</para>
    /// labels<para>"taxonomy"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Taxonomy">http://purl.org/spar/fabio/Taxonomy</seealso>
    let Taxonomy = Prefixed_Name(fabio, "Taxonomy") |> PrefixedName
    /// <summary>
    ///   <para>fabio:TechnicalReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A report of a technical nature."</para>
    /// labels<para>"technical report"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/TechnicalReport">http://purl.org/spar/fabio/TechnicalReport</seealso>
    let TechnicalReport = Prefixed_Name(fabio, "TechnicalReport") |> PrefixedName
    /// <summary>
    ///   <para>fabio:TechnicalStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An official or public specification of, or requirement for, a technical method, practice, process or protocol that is involved in, for example, manufacturing, computation, electronic communication, or digital media."</para>
    /// labels<para>"technical standard"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/TechnicalStandard">http://purl.org/spar/fabio/TechnicalStandard</seealso>
    let TechnicalStandard = Prefixed_Name(fabio, "TechnicalStandard") |> PrefixedName
    /// <summary>
    ///   <para>fabio:TermDictionary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A controlled vocabulary, usually referring to terms within a particular classification system, such as the ACM Computing Classification System or MeSH, the Medical Subject Headings, or a controlled vocabulary of disciplines."</para>
    /// labels<para>"term dictionary"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/TermDictionary">http://purl.org/spar/fabio/TermDictionary</seealso>
    let TermDictionary = Prefixed_Name(fabio, "TermDictionary") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Textbook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A book containing instructional material relating to a particular topic of academic study, designed to be read by students."</para>
    /// labels<para>"textbook"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Textbook">http://purl.org/spar/fabio/Textbook</seealso>
    let Textbook = Prefixed_Name(fabio, "Textbook") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Thesaurus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of controlled vocabulary used in information retrieval applications for indexing or tagging purposes, in which relationships between terms are made explicit. These are normally hierarchical relationships (is-a, subsumption; e.g. a cow is a mammal), equivalency relationships relating non-preferred terms to preferred terms (e.g. pitch and frequency), or associative relationships, in which the relationship that exists is neither one of hierarchy or equivalence, but rather one of similarity (e.g. sports and leisure pursuits)."</para>
    /// labels<para>"thesaurus"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Thesaurus">http://purl.org/spar/fabio/Thesaurus</seealso>
    let Thesaurus = Prefixed_Name(fabio, "Thesaurus") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Thesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A book authored by a student containing a formal presentations of research outputs submitted for examination in completion of a course of study at an institution of higher education, to fulfil the requirements for an academic degree.  Also know as a dissertation.  [For the alternative meaning of the word 'thesis', namely the formulation of a concept, hypothesis, idea, point of view or theory presented for review and/or discussion, use fabio:Proposition.]"</para>
    /// labels<para>"thesis"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Thesis">http://purl.org/spar/fabio/Thesis</seealso>
    let Thesis = Prefixed_Name(fabio, "Thesis") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Timetable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tabular dataset providing information about the times and locations of a planned series of events."</para>
    /// labels<para>"timetable"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Timetable">http://purl.org/spar/fabio/Timetable</seealso>
    let Timetable = Prefixed_Name(fabio, "Timetable") |> PrefixedName
    /// <summary>
    ///   <para>fabio:TrialReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The report of a trial, for example an experimental trial or a legal trial."</para>
    /// labels<para>"trial report"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/TrialReport">http://purl.org/spar/fabio/TrialReport</seealso>
    let TrialReport = Prefixed_Name(fabio, "TrialReport") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Triplestore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A database specifically designed for the storage and retrieval of Resource Description Framework (RDF) data consisting of subject-predicate-object triples.  A triple store is queried using the RDF query language SPARQL."</para>
    /// labels<para>"triplestore"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Triplestore">http://purl.org/spar/fabio/Triplestore</seealso>
    let Triplestore = Prefixed_Name(fabio, "Triplestore") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Tweet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A posting made on the social networking site Twitter. A tweet is a text message limited to 140 characters in length, that is broadcast and readable by anyone who accesses Twitter."</para>
    /// labels<para>"tweet"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Tweet">http://purl.org/spar/fabio/Tweet</seealso>
    let Tweet = Prefixed_Name(fabio, "Tweet") |> PrefixedName

    /// <summary>
    ///   <para>fabio:UncontrolledVocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A non-defined collection of words and phrases relating to a particular domain of knowledge, usually added freely by a community, in which homonyms, synonyms and similar ambiguities of meaning present in natural language are not formally disambiguated."</para>
    /// labels<para>"uncontrolled vocabulary"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/UncontrolledVocabulary">http://purl.org/spar/fabio/UncontrolledVocabulary</seealso>
    let UncontrolledVocabulary =
        Prefixed_Name(fabio, "UncontrolledVocabulary") |> PrefixedName

    /// <summary>
    ///   <para>fabio:Vocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of words, either constituting a language, or more specifically used to describe a particular domain of knowledge."</para>
    /// labels<para>"vocabulary"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Vocabulary">http://purl.org/spar/fabio/Vocabulary</seealso>
    let Vocabulary = Prefixed_Name(fabio, "Vocabulary") |> PrefixedName
    /// <summary>
    ///   <para>fabio:VocabularyDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document containing a vocabulary"</para>
    /// labels<para>"vocabulary document"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/VocabularyDocument">http://purl.org/spar/fabio/VocabularyDocument</seealso>
    let VocabularyDocument = Prefixed_Name(fabio, "VocabularyDocument") |> PrefixedName
    /// <summary>
    ///   <para>fabio:VocabularyMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A mapping of correspondences between two vocabularies.  For controlled vocabularies, such mappings may be expressed using SKOS (http://www.w3.org/2004/02/skos/)."</para>
    /// labels<para>"vocabulary mapping"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/VocabularyMapping">http://purl.org/spar/fabio/VocabularyMapping</seealso>
    let VocabularyMapping = Prefixed_Name(fabio, "VocabularyMapping") |> PrefixedName

    /// <summary>
    ///   <para>fabio:VocabularyMappingDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document containing a vocabulary mapping"</para>
    /// labels<para>"vocabulary mapping document"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/VocabularyMappingDocument">http://purl.org/spar/fabio/VocabularyMappingDocument</seealso>
    let VocabularyMappingDocument =
        Prefixed_Name(fabio, "VocabularyMappingDocument") |> PrefixedName

    /// <summary>
    ///   <para>fabio:WebArchive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A snapshots of (part of) the World Wide Web."</para>
    /// labels<para>"web archive"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/WebArchive">http://purl.org/spar/fabio/WebArchive</seealso>
    let WebArchive = Prefixed_Name(fabio, "WebArchive") |> PrefixedName
    /// <summary>
    ///   <para>fabio:WebContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Information prepared specifically and primarily for manifestation in a web page, comprising text, images, datasets and/or other works."</para>
    /// labels<para>"web content"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/WebContent">http://purl.org/spar/fabio/WebContent</seealso>
    let WebContent = Prefixed_Name(fabio, "WebContent") |> PrefixedName
    /// <summary>
    ///   <para>fabio:WebManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A digital manifestation on the Web, such as a wiki, a web site, a web page or a blog."</para>
    /// labels<para>"web manifestation"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/WebManifestation">http://purl.org/spar/fabio/WebManifestation</seealso>
    let WebManifestation = Prefixed_Name(fabio, "WebManifestation") |> PrefixedName
    /// <summary>
    ///   <para>fabio:WebPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Web manifestation usually identified by a Uniform Resource Identifier (URI), and made accessible to a user by means of the Hypertext Transport Protocol (HTTP) in a Web browser window. Several interlinked web pages hosted together on a Web server and accessed through a single domain name or IP address constitute a web site."</para>
    /// labels<para>"web page"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/WebPage">http://purl.org/spar/fabio/WebPage</seealso>
    let WebPage = Prefixed_Name(fabio, "WebPage") |> PrefixedName
    /// <summary>
    ///   <para>fabio:WebSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of related web pages containing text, images, videos and/or other digital assets that are addressed relative to a common Uniform Resource Locator (URL). A web site is hosted on at least one web server, accessible via a network such as the Internet or a private local area network."</para>
    /// labels<para>"web site"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/WebSite">http://purl.org/spar/fabio/WebSite</seealso>
    let WebSite = Prefixed_Name(fabio, "WebSite") |> PrefixedName
    /// <summary>
    ///   <para>fabio:WhitePaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An authoritative report or guide designed to educate readers and help people make decisions, or to explain technical problems and how to solve them. White papers are typically published by governments to propose new legislation for discussion, and by commercial companies to inform readers about products or services, as aids to marketing."</para>
    /// labels<para>"white paper"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/WhitePaper">http://purl.org/spar/fabio/WhitePaper</seealso>
    let WhitePaper = Prefixed_Name(fabio, "WhitePaper") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Wiki</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collaborative Web manifestation, usually maintained by a project team or group, providing easy-to-edit pages that can be used to accumulate related information for shared use by the group and/or publication."</para>
    /// labels<para>"wiki"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Wiki">http://purl.org/spar/fabio/Wiki</seealso>
    let Wiki = Prefixed_Name(fabio, "Wiki") |> PrefixedName
    /// <summary>
    ///   <para>fabio:WikiEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Information manifested in a wiki. "</para>
    /// labels<para>"wiki entry"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/WikiEntry">http://purl.org/spar/fabio/WikiEntry</seealso>
    let WikiEntry = Prefixed_Name(fabio, "WikiEntry") |> PrefixedName
    /// <summary>
    ///   <para>fabio:WikipediaEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Information about a particular topic in one of the versions of Wikipedia, the online encyclopedia (http://www.wikipedia.org/).
    /// "</para>
    /// labels<para>"wikipedia entry"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/WikipediaEntry">http://purl.org/spar/fabio/WikipediaEntry</seealso>
    let WikipediaEntry = Prefixed_Name(fabio, "WikipediaEntry") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A subclass of FRBR work, restricted to works that are published or potentially publishable, and that contain or are referred to by bibliographic references, or entities used to define bibliographic references. FaBiO works, and their expressions and manifestations, are primarily textual publications such as books, magazines, newspapers and journals, and items of their content.  However, they also include datasets, computer algorithms, experimental protocols, formal specifications and vocabularies, legal records, governmental papers, technical and commercial reports and similar publications, and also bibliographies, reference lists, library catalogues and similar collections. For this reason, fabio:Work is not an equivalent class to frbr:ScholarlyWork.  An example of a fabio:Work is your latest research paper."</para>
    /// labels<para>"work"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Work">http://purl.org/spar/fabio/Work</seealso>
    let Work = Prefixed_Name(fabio, "Work") |> PrefixedName
    /// <summary>
    ///   <para>fabio:WorkCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"work collection"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/WorkCollection">http://purl.org/spar/fabio/WorkCollection</seealso>
    let WorkCollection = Prefixed_Name(fabio, "WorkCollection") |> PrefixedName
    /// <summary>
    ///   <para>fabio:WorkPackage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A component of the case for support of a grant application, describing a particular aspect of the work to be undertaken."</para>
    /// labels<para>"work package"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/WorkPackage">http://purl.org/spar/fabio/WorkPackage</seealso>
    let WorkPackage = Prefixed_Name(fabio, "WorkPackage") |> PrefixedName
    /// <summary>
    ///   <para>fabio:Workflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A recorded sequence of connected steps, which may be automated, specifying a reliably repeatable sequence of operations to be undertaken when conducting a particular job, for example an in silico investigation that extracts and processes information from a number of bioinformatics databases."</para>
    /// labels<para>"workflow"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/Workflow">http://purl.org/spar/fabio/Workflow</seealso>
    let Workflow = Prefixed_Name(fabio, "Workflow") |> PrefixedName
    /// <summary>
    ///   <para>fabio:WorkingPaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An unpublished paper, usually circulated privately among a small group of peers, to provide information or with a request for comments or editorial improvement."</para>
    /// labels<para>"working paper"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/WorkingPaper">http://purl.org/spar/fabio/WorkingPaper</seealso>
    let WorkingPaper = Prefixed_Name(fabio, "WorkingPaper") |> PrefixedName
    /// <summary>
    ///   <para>fabio:WorkshopPaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A paper, typically the realization of a research paper reporting original research findings, usually presented at a workshop and published within a workshop proceedings volume."</para>
    /// labels<para>"workshop paper"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/WorkshopPaper">http://purl.org/spar/fabio/WorkshopPaper</seealso>
    let WorkshopPaper = Prefixed_Name(fabio, "WorkshopPaper") |> PrefixedName

    /// <summary>
    ///   <para>fabio:WorkshopProceedings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document containing the programme and collected workshop papers, or their abstracts, presented at a workshop or similar event."</para>
    /// labels<para>"workshop proceedings"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/WorkshopProceedings">http://purl.org/spar/fabio/WorkshopProceedings</seealso>
    let WorkshopProceedings =
        Prefixed_Name(fabio, "WorkshopProceedings") |> PrefixedName

    /// <summary>
    ///   <para>fabio:analog-magnetic-tape</para>
    /// </summary>
    /// <remarks>
    ///   <para>fabio:StorageMedium</para>
    ///   <para>fabio:AnalogStorageMedium</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An analog medium for magnetic recording of audio and video information, made of a thin magnetizable coating on a long, narrow plastic tape, typically wound on a spool. "</para>
    /// labels<para>"analog magnetic tape"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/analog-magnetic-tape">http://purl.org/spar/fabio/analog-magnetic-tape</seealso>
    let analog_magnetic_tape =
        Prefixed_Name(fabio, "analog-magnetic-tape") |> PrefixedName

    /// <summary>
    ///   <para>fabio:cd</para>
    /// </summary>
    /// <remarks>
    ///   <para>fabio:StorageMedium</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fabio:DigitalStorageMedium</para>
    ///   <para>"A non-rewritable optical disc used to store digital data."</para>
    /// labels<para>"CD"</para><para>"compact disk"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/cd">http://purl.org/spar/fabio/cd</seealso>
    let cd = Prefixed_Name(fabio, "cd") |> PrefixedName
    /// <summary>
    ///   <para>fabio:cloud</para>
    /// </summary>
    /// <remarks>
    ///   <para>fabio:StorageMedium</para>
    ///   <para>fabio:DigitalStorageMedium</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A distributed and commoditized Internet-based computing resource, whereby shared services, software programs, and information storage facilities are provided to computers and other devices on demand, at locations of which the user may be unaware, like the electricity grid."</para>
    /// labels<para>"cloud"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/cloud">http://purl.org/spar/fabio/cloud</seealso>
    let cloud = Prefixed_Name(fabio, "cloud") |> PrefixedName
    /// <summary>
    ///   <para>fabio:dateLastUpdated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The date on which a particular endeavour, such as an ontology, was last updated."</para>
    /// labels<para>"date last updated"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/dateLastUpdated">http://purl.org/spar/fabio/dateLastUpdated</seealso>
    let dateLastUpdated = Prefixed_Name(fabio, "dateLastUpdated") |> PrefixedName

    /// <summary>
    ///   <para>fabio:digital-magnetic-tape</para>
    /// </summary>
    /// <remarks>
    ///   <para>fabio:DigitalStorageMedium</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fabio:StorageMedium</para>
    ///   <para>"A rewritable digital medium for magnetic recording of audio, video and other data, made of a thin magnetizable coating on a long, narrow strip of plastic, usually wound on a spool."</para>
    /// labels<para>"digital magnetic tape"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/digital-magnetic-tape">http://purl.org/spar/fabio/digital-magnetic-tape</seealso>
    let digital_magnetic_tape =
        Prefixed_Name(fabio, "digital-magnetic-tape") |> PrefixedName

    /// <summary>
    ///   <para>fabio:dvd</para>
    /// </summary>
    /// <remarks>
    ///   <para>fabio:StorageMedium</para>
    ///   <para>fabio:DigitalStorageMedium</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A non-rewritable optical disc storage medium resembling a compact disc (CD), usually used for video and data storage. A DVD has the same physical dimensions as a CD, but is capable of storing more than six times as much data."</para>
    /// labels<para>"digital video disc"</para><para>"digital versatile disc"</para><para>"DVD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/dvd">http://purl.org/spar/fabio/dvd</seealso>
    let dvd = Prefixed_Name(fabio, "dvd") |> PrefixedName
    /// <summary>
    ///   <para>fabio:film</para>
    /// </summary>
    /// <remarks>
    ///   <para>fabio:AnalogStorageMedium</para>
    ///   <para>fabio:StorageMedium</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A thin flexible strip of plastic or other material coated with light-sensitive emulsion upon which images can be recorded, typically using a camera, usually used to record photographic images or motion pictures."</para>
    /// labels<para>"film"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/film">http://purl.org/spar/fabio/film</seealso>
    let film = Prefixed_Name(fabio, "film") |> PrefixedName
    /// <summary>
    ///   <para>fabio:floppy-disk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fabio:DigitalStorageMedium</para>
    ///   <para>fabio:StorageMedium</para>
    ///   <para>"A rewritable data storage medium that is composed of a disk of thin, flexible (floppy) magnetic storage medium encased in a square or rectangular  plastic shell.  Data are encoded magnetically by a read/write head that float on a cushion of air in close proximity to the surface of the rotated disk."</para>
    /// labels<para>"floppy disk"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/floppy-disk">http://purl.org/spar/fabio/floppy-disk</seealso>
    let floppy_disk = Prefixed_Name(fabio, "floppy-disk") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hard-drive</para>
    /// </summary>
    /// <remarks>
    ///   <para>fabio:StorageMedium</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fabio:DigitalStorageMedium</para>
    ///   <para>"A non-volatile storage device for digital data, composed of one or more rigid discs (platters) mounted side by side on a motor-driven spindle within a metal case. Data are encoded magnetically by read/write heads that float on cushions of air in close proximity to the surfaces of the rotated platters."</para>
    /// labels<para>"hard drive"</para><para>"HD"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hard-drive">http://purl.org/spar/fabio/hard-drive</seealso>
    let hard_drive = Prefixed_Name(fabio, "hard-drive") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasAccessDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date on which a particular digital item, such as a PDF or an HTML file, has been accessed by somebody."</para>
    /// labels<para>"has access date"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasAccessDate">http://purl.org/spar/fabio/hasAccessDate</seealso>
    let hasAccessDate = Prefixed_Name(fabio, "hasAccessDate") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasArXivId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An identifier used by the preprint repository ArXiv."</para>
    /// labels<para>"has ArXiv identifier"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasArXivId">http://purl.org/spar/fabio/hasArXivId</seealso>
    let hasArXivId = Prefixed_Name(fabio, "hasArXivId") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasCODEN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A CODEN is a six character, alphanumeric bibliographic identification code, that provides concise, unique and unambiguous identification of the titles of serials and non-serial publications."</para>
    /// labels<para>"has CODEN"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasCODEN">http://purl.org/spar/fabio/hasCODEN</seealso>
    let hasCODEN = Prefixed_Name(fabio, "hasCODEN") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasCharacterCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The count of the number of characters in a textual resource."</para>
    /// labels<para>"has character count"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasCharacterCount">http://purl.org/spar/fabio/hasCharacterCount</seealso>
    let hasCharacterCount = Prefixed_Name(fabio, "hasCharacterCount") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasCopyrightYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The year in which an entity has been copyrighted."</para>
    /// labels<para>"has copyright year"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasCopyrightYear">http://purl.org/spar/fabio/hasCopyrightYear</seealso>
    let hasCopyrightYear = Prefixed_Name(fabio, "hasCopyrightYear") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasCorrectionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date on which something, for example a document, is corrected."</para>
    /// labels<para>"has correction date"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasCorrectionDate">http://purl.org/spar/fabio/hasCorrectionDate</seealso>
    let hasCorrectionDate = Prefixed_Name(fabio, "hasCorrectionDate") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasDateCollected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date on which some item has been collected, for example the data gathered by means of questionnaires."</para>
    /// labels<para>"has date collected"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasDateCollected">http://purl.org/spar/fabio/hasDateCollected</seealso>
    let hasDateCollected = Prefixed_Name(fabio, "hasDateCollected") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasDateReceived</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date on which some item is received, for example a document being received by a publisher."</para>
    /// labels<para>"has date received"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasDateReceived">http://purl.org/spar/fabio/hasDateReceived</seealso>
    let hasDateReceived = Prefixed_Name(fabio, "hasDateReceived") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasDeadline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A date by which something has to be done."</para>
    /// labels<para>"has deadline"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasDeadline">http://purl.org/spar/fabio/hasDeadline</seealso>
    let hasDeadline = Prefixed_Name(fabio, "hasDeadline") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasDecisionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date on which a particular endeavour, such as a grant application, has been or will be approved or rejected by somebody."</para>
    /// labels<para>"has decision date"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasDecisionDate">http://purl.org/spar/fabio/hasDecisionDate</seealso>
    let hasDecisionDate = Prefixed_Name(fabio, "hasDecisionDate") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasDepositDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date on which an entity has been deposited, for example in a library, repository, supplementary information archive, database or similar place of document or information storage."</para>
    /// labels<para>"has deposit date"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasDepositDate">http://purl.org/spar/fabio/hasDepositDate</seealso>
    let hasDepositDate = Prefixed_Name(fabio, "hasDepositDate") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasDiscipline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The discipline to which a subject vocabulary belongs."</para>
    /// labels<para>"has discipline"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasDiscipline">http://purl.org/spar/fabio/hasDiscipline</seealso>
    let hasDiscipline = Prefixed_Name(fabio, "hasDiscipline") |> PrefixedName

    /// <summary>
    ///   <para>fabio:hasDistributionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date on which something is distributed, for example the date on which a preprint of a document is e-mailed to colleagues and other academics by the author(s), or the date on which a printed announcement of forthcoming theatre events is mailed to those those on the theatre's mailing list."</para>
    /// labels<para>"has preprint dissemination date"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasDistributionDate">http://purl.org/spar/fabio/hasDistributionDate</seealso>
    let hasDistributionDate =
        Prefixed_Name(fabio, "hasDistributionDate") |> PrefixedName

    /// <summary>
    ///   <para>fabio:hasElectronicArticleIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A local identifier for an article within an electronic (i.e. on line, in HTML format) periodical issue.  Use in preference to prism:startingPage when the article lacks page numbers"</para>
    /// labels<para>"has electronic article identifier"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasElectronicArticleIdentifier">http://purl.org/spar/fabio/hasElectronicArticleIdentifier</seealso>
    let hasElectronicArticleIdentifier =
        Prefixed_Name(fabio, "hasElectronicArticleIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fabio:hasEmbargoDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date before which an entity should not be published, or before which a press release should not be reported on.  For open-access journal articles, the embargo date is the date before which availability of the open-access version of the article is restricted by the publisher, following subscription-access availability of the published work.  The duration of the embargo period can be specified by fabio:hasEmbargoDuration."</para>
    /// labels<para>"has embargo date"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasEmbargoDate">http://purl.org/spar/fabio/hasEmbargoDate</seealso>
    let hasEmbargoDate = Prefixed_Name(fabio, "hasEmbargoDate") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasEmbargoDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The time period for which an entity is embargoed.  During this period, the entity should not be published or, in the case of a press release, should not be reported on.  For open-access journal articles, the embargo duration specifies that period of time during which availability of the open-access version of the article is delayed by the publisher, following subscription-access availability of the published work.  The end of the embargo period can be specified by fabio:hasEmbargoDate."</para>
    /// labels<para>"has embargo period"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasEmbargoDuration">http://purl.org/spar/fabio/hasEmbargoDuration</seealso>
    let hasEmbargoDuration = Prefixed_Name(fabio, "hasEmbargoDuration") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasHandle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A persistent identifier of the Handel system for digital objects and other resources on the Internet."</para>
    /// labels<para>"has handle"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasHandle">http://purl.org/spar/fabio/hasHandle</seealso>
    let hasHandle = Prefixed_Name(fabio, "hasHandle") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasIssnL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A linking International Standard Serial Number."</para>
    /// labels<para>"has ISSN-L"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasIssnL">http://purl.org/spar/fabio/hasIssnL</seealso>
    let hasIssnL = Prefixed_Name(fabio, "hasIssnL") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property linking a particular work to its manifestations.  This property is additional to the relationships between FRBR endeavours present in the classical FRBR data model."</para>
    /// labels<para>"has manifestation"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasManifestation">http://purl.org/spar/fabio/hasManifestation</seealso>
    let hasManifestation = Prefixed_Name(fabio, "hasManifestation") |> PrefixedName

    /// <summary>
    ///   <para>fabio:hasNLMJournalTitleAbbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"An internal identifier for the abbreviation of the title of journals available from the National Library of Medicine repository."</para>
    /// labels<para>"has National Library of Medicine journal title abbreviation"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasNLMJournalTitleAbbreviation">http://purl.org/spar/fabio/hasNLMJournalTitleAbbreviation</seealso>
    let hasNLMJournalTitleAbbreviation =
        Prefixed_Name(fabio, "hasNLMJournalTitleAbbreviation") |> PrefixedName

    /// <summary>
    ///   <para>fabio:hasNationalLibraryOfMedicineJournalId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"An internal identifier for journals available from the National Library of Medicine repository."</para>
    /// labels<para>"has National Library of Medicine journal identifier"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasNationalLibraryOfMedicineJournalId">http://purl.org/spar/fabio/hasNationalLibraryOfMedicineJournalId</seealso>
    let hasNationalLibraryOfMedicineJournalId =
        Prefixed_Name(fabio, "hasNationalLibraryOfMedicineJournalId") |> PrefixedName

    /// <summary>
    ///   <para>fabio:hasPII</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Has Publisher Item Identifier"</para>
    /// labels<para>"has PII"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasPII">http://purl.org/spar/fabio/hasPII</seealso>
    let hasPII = Prefixed_Name(fabio, "hasPII") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasPageCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The count of the number of pages in a textual resource."</para>
    /// labels<para>"has page count"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasPageCount">http://purl.org/spar/fabio/hasPageCount</seealso>
    let hasPageCount = Prefixed_Name(fabio, "hasPageCount") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasPatentNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A unique identifing number issued by a patent authority to identify a patent, displayed at the beginning of the patent document."</para>
    /// labels<para>"has patent number"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasPatentNumber">http://purl.org/spar/fabio/hasPatentNumber</seealso>
    let hasPatentNumber = Prefixed_Name(fabio, "hasPatentNumber") |> PrefixedName

    /// <summary>
    ///   <para>fabio:hasPlaceOfPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The place (usually, the city) where the publisher of a particular bibliographic resource is located."</para>
    /// labels<para>"has place of publication"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasPlaceOfPublication">http://purl.org/spar/fabio/hasPlaceOfPublication</seealso>
    let hasPlaceOfPublication =
        Prefixed_Name(fabio, "hasPlaceOfPublication") |> PrefixedName

    /// <summary>
    ///   <para>fabio:hasPortrayal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property linking a particular work to its items.  This property is additional to the relationships between FRBR endeavours present in the classical FRBR data model."</para>
    /// labels<para>"has portrayal"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasPortrayal">http://purl.org/spar/fabio/hasPortrayal</seealso>
    let hasPortrayal = Prefixed_Name(fabio, "hasPortrayal") |> PrefixedName

    /// <summary>
    ///   <para>fabio:hasPrimarySubjectTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to associate a frbr:Endeavour to a term in a particular classification system - and the term is considered one of the main topics for the endeavour in consideration."</para>
    /// labels<para>"has primary subject term"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasPrimarySubjectTerm">http://purl.org/spar/fabio/hasPrimarySubjectTerm</seealso>
    let hasPrimarySubjectTerm =
        Prefixed_Name(fabio, "hasPrimarySubjectTerm") |> PrefixedName

    /// <summary>
    ///   <para>fabio:hasPubMedCentralId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"An identifier for bibliographic entities hosted by the PubMed Central repository."</para>
    /// labels<para>"has PubMed Central identifier"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasPubMedCentralId">http://purl.org/spar/fabio/hasPubMedCentralId</seealso>
    let hasPubMedCentralId = Prefixed_Name(fabio, "hasPubMedCentralId") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasPubMedId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"An identifier for bibliographic records held by the PubMed repository."</para>
    /// labels<para>"has PubMed identifier"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasPubMedId">http://purl.org/spar/fabio/hasPubMedId</seealso>
    let hasPubMedId = Prefixed_Name(fabio, "hasPubMedId") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasPublicationYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The year in which a resource is published."</para>
    /// labels<para>"has publication year"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasPublicationYear">http://purl.org/spar/fabio/hasPublicationYear</seealso>
    let hasPublicationYear = Prefixed_Name(fabio, "hasPublicationYear") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property linking a particular expression to its items.  This property is additional to the relationships between FRBR endeavours present in the classical FRBR data model."</para>
    /// labels<para>"has representation"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasRepresentation">http://purl.org/spar/fabio/hasRepresentation</seealso>
    let hasRepresentation = Prefixed_Name(fabio, "hasRepresentation") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasRequestDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date on which an agent is requested to do something, for example a reviewer is requested to write a review of a paper submitted to a journal for publication, or an author is requested to supply a revised version of the paper in response to the reviews received."</para>
    /// labels<para>"has request date"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasRequestDate">http://purl.org/spar/fabio/hasRequestDate</seealso>
    let hasRequestDate = Prefixed_Name(fabio, "hasRequestDate") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasRetractionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The date on which something, for example a claim or a journal article, is retracted."</para>
    /// labels<para>"has retraction date"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasRetractionDate">http://purl.org/spar/fabio/hasRetractionDate</seealso>
    let hasRetractionDate = Prefixed_Name(fabio, "hasRetractionDate") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasSICI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The Serial Item and Contribution Identifier is a code used to uniquely identify specific volumes, articles or other identifiable parts of a periodical. It is intended primarily for use by those members of the bibliographic community involved in the use or management of serial titles and their contributions."</para>
    /// labels<para>"has Serial Item and Contribution Identifier"</para><para>"has SICI"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasSICI">http://purl.org/spar/fabio/hasSICI</seealso>
    let hasSICI = Prefixed_Name(fabio, "hasSICI") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasSeason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Permits specification of the season of the year, for example spring, summer, autumn and winter in British English."</para>
    /// labels<para>"has season"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasSeason">http://purl.org/spar/fabio/hasSeason</seealso>
    let hasSeason = Prefixed_Name(fabio, "hasSeason") |> PrefixedName

    /// <summary>
    ///   <para>fabio:hasSequenceIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A literal (for example a number or a letter) that identifies the sequence position of a work within a particular context, for example a book in a book series, a chapter in a document, a volume in a journal."</para>
    /// labels<para>"has number"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasSequenceIdentifier">http://purl.org/spar/fabio/hasSequenceIdentifier</seealso>
    let hasSequenceIdentifier =
        Prefixed_Name(fabio, "hasSequenceIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fabio:hasShortTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A short version of the title of an entity, typically used to label or refer to a particular entity in an abbreviated form, for example an abbreviated journal title in a reference, or a short title of a document used as the running title in a page header."</para>
    /// labels<para>"has short title"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasShortTitle">http://purl.org/spar/fabio/hasShortTitle</seealso>
    let hasShortTitle = Prefixed_Name(fabio, "hasShortTitle") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasStandardNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The number defining an international standard, for example Z39.96 - 201x, identifying NISO JATS, the Journal Article Tag Suite."</para>
    /// labels<para>"has standard number"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasStandardNumber">http://purl.org/spar/fabio/hasStandardNumber</seealso>
    let hasStandardNumber = Prefixed_Name(fabio, "hasStandardNumber") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasSubjectTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to associate a frbr:Endeavour to a term in a particular classification system."</para>
    /// labels<para>"has subject term"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasSubjectTerm">http://purl.org/spar/fabio/hasSubjectTerm</seealso>
    let hasSubjectTerm = Prefixed_Name(fabio, "hasSubjectTerm") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasSubtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A secondary title that follows the main title of a work."</para>
    /// labels<para>"has subtitle"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasSubtitle">http://purl.org/spar/fabio/hasSubtitle</seealso>
    let hasSubtitle = Prefixed_Name(fabio, "hasSubtitle") |> PrefixedName

    /// <summary>
    ///   <para>fabio:hasTranslatedSubtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A version of the subtitle of an entity translated into another language, which may be specified using the object property dcterms:language."</para>
    /// labels<para>"has translated subtitle"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasTranslatedSubtitle">http://purl.org/spar/fabio/hasTranslatedSubtitle</seealso>
    let hasTranslatedSubtitle =
        Prefixed_Name(fabio, "hasTranslatedSubtitle") |> PrefixedName

    /// <summary>
    ///   <para>fabio:hasTranslatedTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A version of the title of an entity translated into another language, which may be specified using the object property dcterms:language."</para>
    /// labels<para>"has translated title"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasTranslatedTitle">http://purl.org/spar/fabio/hasTranslatedTitle</seealso>
    let hasTranslatedTitle = Prefixed_Name(fabio, "hasTranslatedTitle") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An identifier, in form of an HTTP Universal Resource Locator (URL), for a particular resource on the World Wide Web."</para>
    /// labels<para>"has URL"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasURL">http://purl.org/spar/fabio/hasURL</seealso>
    let hasURL = Prefixed_Name(fabio, "hasURL") |> PrefixedName
    /// <summary>
    ///   <para>fabio:hasVolumeCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The count of the number of volumes a work includes."</para>
    /// labels<para>"has volume count"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/hasVolumeCount">http://purl.org/spar/fabio/hasVolumeCount</seealso>
    let hasVolumeCount = Prefixed_Name(fabio, "hasVolumeCount") |> PrefixedName
    /// <summary>
    ///   <para>fabio:internet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fabio:StorageMedium</para>
    ///   <para>fabio:DigitalStorageMedium</para>
    ///   <para>"A global system of interconnected computer networks that uses the standard Internet Protocol Suite (TCP/IP) to serve billions of users worldwide.  The internet connects millions of private, public, academic, business and governmental computers, that are individually attached to local networks linked together by a broad array of electronic, radio and optical networking technologies to form the internet. "</para>
    /// labels<para>"internet"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/internet">http://purl.org/spar/fabio/internet</seealso>
    let internet = Prefixed_Name(fabio, "internet") |> PrefixedName
    /// <summary>
    ///   <para>fabio:intranet</para>
    /// </summary>
    /// <remarks>
    ///   <para>fabio:StorageMedium</para>
    ///   <para>fabio:DigitalStorageMedium</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A private computer network, unconnected to the internet or separated from it by a firewall,  that uses a network operating system and Internet Protocol technologies to permit an organization's information to be shared securely within that organization."</para>
    /// labels<para>"intranet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/intranet">http://purl.org/spar/fabio/intranet</seealso>
    let intranet = Prefixed_Name(fabio, "intranet") |> PrefixedName
    /// <summary>
    ///   <para>fabio:isDisciplineOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a subject vocabulary to the discipline to which it belongs."</para>
    /// labels<para>"is discipline of"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/isDisciplineOf">http://purl.org/spar/fabio/isDisciplineOf</seealso>
    let isDisciplineOf = Prefixed_Name(fabio, "isDisciplineOf") |> PrefixedName
    /// <summary>
    ///   <para>fabio:isManifestationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property linking a particular manifestation to the work it is manifesting.  This property is additional to the relationships between FRBR endeavours present in the classical FRBR data model."</para>
    /// labels<para>"is manifestation of"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/isManifestationOf">http://purl.org/spar/fabio/isManifestationOf</seealso>
    let isManifestationOf = Prefixed_Name(fabio, "isManifestationOf") |> PrefixedName
    /// <summary>
    ///   <para>fabio:isPortrayalOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property linking a particular item to the work it portrays.  This property is additional to the relationships between FRBR endeavours present in the classical FRBR data model."</para>
    /// labels<para>"is portrayal of"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/isPortrayalOf">http://purl.org/spar/fabio/isPortrayalOf</seealso>
    let isPortrayalOf = Prefixed_Name(fabio, "isPortrayalOf") |> PrefixedName
    /// <summary>
    ///   <para>fabio:isRepresentationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A property linking a particular item to the expression it represents.  This property is additional to the relationships between FRBR endeavours present in the classical FRBR data model."</para>
    /// labels<para>"is representation of"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/isRepresentationOf">http://purl.org/spar/fabio/isRepresentationOf</seealso>
    let isRepresentationOf = Prefixed_Name(fabio, "isRepresentationOf") |> PrefixedName
    /// <summary>
    ///   <para>fabio:isSchemeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property expresses the fact that a scheme contains a concept."</para>
    /// labels<para>"is scheme of"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/isSchemeOf">http://purl.org/spar/fabio/isSchemeOf</seealso>
    let isSchemeOf = Prefixed_Name(fabio, "isSchemeOf") |> PrefixedName
    /// <summary>
    ///   <para>fabio:isStoredOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a fabio:Item to the medium upon which it is stored."</para>
    /// labels<para>"is stored on"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/isStoredOn">http://purl.org/spar/fabio/isStoredOn</seealso>
    let isStoredOn = Prefixed_Name(fabio, "isStoredOn") |> PrefixedName
    /// <summary>
    ///   <para>fabio:paper</para>
    /// </summary>
    /// <remarks>
    ///   <para>fabio:AnalogStorageMedium</para>
    ///   <para>fabio:StorageMedium</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A thin flat material, typically made from wood pulp, mainly used for writing upon, for printing upon or for packaging."</para>
    /// labels<para>"paper"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/paper">http://purl.org/spar/fabio/paper</seealso>
    let paper = Prefixed_Name(fabio, "paper") |> PrefixedName
    /// <summary>
    ///   <para>fabio:ram</para>
    /// </summary>
    /// <remarks>
    ///   <para>fabio:DigitalStorageMedium</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fabio:StorageMedium</para>
    ///   <para>"Abbreviation of Random Access Memory.  A form of rewritable computer data storage that takes the form of integrated circuits that allow data to be stored and accessed in any order (i.e. at random), thereby achieving greater speed than for access of data stored in linear form on digital magnetic tape."</para>
    /// labels<para>"RAM"</para><para>"random access memory"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/ram">http://purl.org/spar/fabio/ram</seealso>
    let ram = Prefixed_Name(fabio, "ram") |> PrefixedName
    /// <summary>
    ///   <para>fabio:solid-state-memory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fabio:StorageMedium</para>
    ///   <para>fabio:DigitalStorageMedium</para>
    ///   <para>"A digital storage device built entirely from solid electronic materials with no moving parts, e.g. a USB flash drive."</para>
    /// labels<para>"solid state memory"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/solid-state-memory">http://purl.org/spar/fabio/solid-state-memory</seealso>
    let solid_state_memory = Prefixed_Name(fabio, "solid-state-memory") |> PrefixedName
    /// <summary>
    ///   <para>fabio:stores</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property relates a storage medium to the fabio:Item stored upon it."</para>
    /// labels<para>"stores"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/stores">http://purl.org/spar/fabio/stores</seealso>
    let stores = Prefixed_Name(fabio, "stores") |> PrefixedName
    /// <summary>
    ///   <para>fabio:usesCalendar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A property that identifies the calendar system used to specify a date, for example the Chinese, Gregorian, Hebrew, Islamic or Lunar calendar."</para>
    /// labels<para>"uses calendar"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/usesCalendar">http://purl.org/spar/fabio/usesCalendar</seealso>
    let usesCalendar = Prefixed_Name(fabio, "usesCalendar") |> PrefixedName
    /// <summary>
    ///   <para>fabio:vinyl-disk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fabio:AnalogStorageMedium</para>
    ///   <para>fabio:StorageMedium</para>
    ///   <para>"An analog sound storage medium consisting of a flat disc made of moulded vinyl plastic with an inscribed, modulated spiral groove."</para>
    /// labels<para>"vinyl disk"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/vinyl-disk">http://purl.org/spar/fabio/vinyl-disk</seealso>
    let vinyl_disk = Prefixed_Name(fabio, "vinyl-disk") |> PrefixedName
    /// <summary>
    ///   <para>fabio:web</para>
    /// </summary>
    /// <remarks>
    ///   <para>fabio:StorageMedium</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fabio:DigitalStorageMedium</para>
    ///   <para>"A system of interlinked hypertext documents written in HTML and accessed using the HTTP protocol via the Internet."</para>
    /// labels<para>"Web"</para><para>"WWW"</para><para>"World Wide Web"</para></remarks>
    /// <seealso href="http://purl.org/spar/fabio/web">http://purl.org/spar/fabio/web</seealso>
    let web = Prefixed_Name(fabio, "web") |> PrefixedName
