namespace http.purl.org.spar.doco.slash

open DoxAletheia

module doco =
    let _namespace_name = "http://purl.org/spar/doco/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A block containing text, that may include a number (e.g., "Chapter Three", "3.2", "Figure 1", "Table"), used to identify an item within the document, for example a chapter, a figure, a section or a table.
    /// <see href="http://purl.org/spar/doco/Label"></see></summary>
    let Label = _prefix "Label"
    /// <summary>
    /// A self-contained unit of discourse that deals with a particular point or idea. Paragraphs contains one or more sentences. The start of a paragraph is indicated by beginning on a new line, which may be indented or separated by a small vertical space by the preceding paragraph.
    /// <see href="http://purl.org/spar/doco/Paragraph"></see></summary>
    let Paragraph = _prefix "Paragraph"
    /// <summary>
    /// An explanatory or alternative title of a publication. For example, Mary Shelley uses the alternative title 'The Modern Prometheus' to hint at the theme of her most famous novel 'Frankenstein'; Nick Efford uses the subtitle 'a practical introduction using Java' to qualify the title of his book 'Digital Image Processing'.
    /// <see href="http://purl.org/spar/doco/Subtitle"></see></summary>
    let Subtitle = _prefix "Subtitle"
    /// <summary>
    /// A word, phrase or sentence that precedes and indicates the subject of a document or a document component - e.g., a book, a report, a news article, a chapter, a section or a table.
    /// <see href="http://purl.org/spar/doco/Title"></see></summary>
    let Title = _prefix "Title"
    /// <summary>
    /// A list of items each denoting an author of a particular publication.
    /// <see href="http://purl.org/spar/doco/ListOfAuthors"></see></summary>
    let ListOfAuthors = _prefix "ListOfAuthors"
    /// <summary>
    /// A list of items, each denoting a contributor to a publication such as an encyclopedia or a text book, where such contributions are insufficient to warrant classification as author.
    /// <see href="http://purl.org/spar/doco/ListOfContributors"></see></summary>
    let ListOfContributors = _prefix "ListOfContributors"
    /// <summary>
    /// A list of items, each denoting an organization or institution related to the publication, for example the authors' affiliations, or the suppliers of information, software, equipment or consumables used in the work described in the publication.
    /// <see href="http://purl.org/spar/doco/ListOfOrganizations"></see></summary>
    let ListOfOrganizations = _prefix "ListOfOrganizations"
    /// <summary>
    /// An expression in natural language forming a single grammatical unit. A sentence minimally consists of a subject and an intransitive verb, or a subject, a transitive verb and an object, and may include additional dependent clauses. In written text, a sentence is always terminated by a full stop. A sentence can include words grouped meaningfully to express a statement, a question, an exclamation, a request or a command.
    /// <see href="http://purl.org/spar/doco/Sentence"></see></summary>
    let Sentence = _prefix "Sentence"
    /// <summary>
    /// A textual quotation that is included inline and is usually enclosed within quotation marks.
    /// <see href="http://purl.org/spar/doco/SimpleRunInQuotation"></see></summary>
    let SimpleRunInQuotation = _prefix "SimpleRunInQuotation"
    /// <summary>
    /// A piece of text defined by a start point and an end point.
    /// <see href="http://purl.org/spar/doco/TextChunk"></see></summary>
    let TextChunk = _prefix "TextChunk"
    /// <summary>
    /// The final principle part of a document, in which is usually found the bibliography, index, appendixes, etc.
    /// <see href="http://purl.org/spar/doco/BackMatter"></see></summary>
    let BackMatter = _prefix "BackMatter"
    /// <summary>
    /// The central principle part of a document, that contains the real content. It may be subdivided hierarchically by the use of chapters and sections.
    /// <see href="http://purl.org/spar/doco/BodyMatter"></see></summary>
    let BodyMatter = _prefix "BodyMatter"
    /// <summary>
    /// A rectangle space within a page that contains an object and its related caption.
    /// <see href="http://purl.org/spar/doco/CaptionedBox"></see></summary>
    let CaptionedBox = _prefix "CaptionedBox"
    /// <summary>
    /// A principle division of the body matter of a large document, such as a book, a report or a legislative document.
    /// <see href="http://purl.org/spar/doco/Chapter"></see></summary>
    let Chapter = _prefix "Chapter"
    /// <summary>
    /// A quotation with a complex structure, that is included inline and is usually enclosed within quotation marks.
    /// <see href="http://purl.org/spar/doco/ComplexRunInQuotation"></see></summary>
    let ComplexRunInQuotation = _prefix "ComplexRunInQuotation"
    /// <summary>
    /// A structure within a sentence that permits the author to make a comment or to cite another publication in support of the text, or both. A footnote is normally flagged by a superscript number immediately following that portion of the text to which it relates. For convenience of reading, the text of the footnote is usually printed at the bottom of the page or at the end of a text.
    /// <see href="http://purl.org/spar/doco/Footnote"></see></summary>
    let Footnote = _prefix "Footnote"
    /// <summary>
    /// A unit of information expressed in mathematical, chemical or logical symbols and language.
    /// <see href="http://purl.org/spar/doco/Formula"></see></summary>
    let Formula = _prefix "Formula"
    /// <summary>
    /// A space within a document that contains one or more formulae.
    /// <see href="http://purl.org/spar/doco/FormulaBox"></see></summary>
    let FormulaBox = _prefix "FormulaBox"
    /// <summary>
    /// The initial principle part of a document, usually containing self-referential metadata. In a book, this typically includes its title, authors, publisher, publication date, ISBN and copyright declaration, together with the preface, foreword, table of content, etc. In a journal article, the front matter is normally restricted to the title, authors and the authors' affiliation details, although the latter may alternatively be included in a footnote or the back matter. In books, the front matter pages may be numbered in lowercase Roman numerals.
    /// <see href="http://purl.org/spar/doco/FrontMatter"></see></summary>
    let FrontMatter = _prefix "FrontMatter"
    /// <summary>
    /// An enumeration of items.
    /// <see href="http://purl.org/spar/doco/List"></see></summary>
    let List = _prefix "List"
    /// <summary>
    /// A container of a semantic subdivision of a document. For example, chapters of a novel may be grouped into distinct parts that may be named 'Part 1', 'Part 2', etc., 'Book 1', 'Book 2', etc., or 'Genesis', 'Exodus', etc.
    /// <see href="http://purl.org/spar/doco/Part"></see></summary>
    let Part = _prefix "Part"
    /// <summary>
    /// A logical division of the text, usually numbered and/or titled, which may contain subsections.
    /// <see href="http://purl.org/spar/doco/Section"></see></summary>
    let Section = _prefix "Section"
    /// <summary>
    /// A set of data arranged in cells within rows and columns.
    /// <see href="http://purl.org/spar/doco/Table"></see></summary>
    let Table = _prefix "Table"
    /// <summary>
    /// A brief summary of a book, a research article, thesis, review, conference proceeding or any in-depth analysis of a particular subject or discipline, the purpose of which is to help the reader quickly ascertain the publication's purpose.
    /// <see href="http://purl.org/spar/doco/Abstract"></see></summary>
    let Abstract = _prefix "Abstract"
    /// <summary>
    /// A literary device that is often found at the end of a piece of literature. It generally covers the story of how the book came into being, or how the idea for the book was developed. Alternatively, it may be written by someone other than the author of the book, and may discuss the work's historical or cultural context, if the work is being reissued many years after its original publication.
    /// <see href="http://purl.org/spar/doco/Afterword"></see></summary>
    let Afterword = _prefix "Afterword"
    /// <summary>
    /// A supplemental addition to the main work. It may contain data, more detailed information about methods and materials, or provide additional detail concerning the information found in the main work.
    /// <see href="http://purl.org/spar/doco/Appendix"></see></summary>
    let Appendix = _prefix "Appendix"
    /// <summary>
    /// A brief description of publication or production notes relevant to the document.
    /// <see href="http://purl.org/spar/doco/Colophon"></see></summary>
    let Colophon = _prefix "Colophon"
    /// <summary>
    /// A section in a book or report, usually written by someone other than the author, that introduces or commends the document to the reader. It may include description of the interaction between the writer of the foreword and the author.
    /// <see href="http://purl.org/spar/doco/Foreword"></see></summary>
    let Foreword = _prefix "Foreword"
    /// <summary>
    /// A set of definitions of words or phrases of importance to the work, normally alphabetized. In longer works of fiction, the entries may contains places and characters.
    /// <see href="http://purl.org/spar/doco/Glossary"></see></summary>
    let Glossary = _prefix "Glossary"
    /// <summary>
    /// A section containing a list of references to information on the named topic of importance to the content of the document. The references may be to page numbers, paragraph numbers, section numbers or chapter numbers within the document.
    /// <see href="http://purl.org/spar/doco/Index"></see></summary>
    let Index = _prefix "Index"
    /// <summary>
    /// A section of the document listing all the figures, identified by their titles and referenced to their locations in the document. May also be referred to as 'List of illustrations'.
    /// <see href="http://purl.org/spar/doco/ListOfFigures"></see></summary>
    let ListOfFigures = _prefix "ListOfFigures"
    /// <summary>
    /// A section of the document listing all the tables, identified by their titles and referenced to their locations in the document.
    /// <see href="http://purl.org/spar/doco/ListOfTables"></see></summary>
    let ListOfTables = _prefix "ListOfTables"
    /// <summary>
    /// A section describing how the document came into being, or how the idea for it was developed. The preface may contains acknowledgements. The preface to a later edition of the work often explains in what respect that edition differs from previous ones.
    /// <see href="http://purl.org/spar/doco/Preface"></see></summary>
    let Preface = _prefix "Preface"
    /// <summary>
    /// A section of the document listing all the chapters and sections, identified by their titles and referenced to their locations in the document. The table of contents may include a list of the front-matter and back-matter items, in addition to the body-matter items.  Where the document is a journal or magazine issue, the table of content lists the constituent items contained in that issue, typically by title, authors and first page number.
    /// <see href="http://purl.org/spar/doco/TableOfContents"></see></summary>
    let TableOfContents = _prefix "TableOfContents"
    /// <summary>
    /// A list, usually within a bibliography, of all the references within the citing document that refer to  journal articles, books, book chapters, Web sites or similar publications.
    /// <see href="http://purl.org/spar/doco/BibliographicReferenceList"></see></summary>
    let BibliographicReferenceList = _prefix "BibliographicReferenceList"
    /// <summary>
    /// A list of items each representing a reference to a specific part of the same document, or to another publication.
    /// <see href="http://purl.org/spar/doco/ListOfReferences"></see></summary>
    let ListOfReferences = _prefix "ListOfReferences"
    /// <summary>
    /// A document section containing a list of bibliographic references.
    /// <see href="http://purl.org/spar/doco/Bibliography"></see></summary>
    let Bibliography = _prefix "Bibliography"
    /// <summary>
    /// A block quotation (also known as a long quotation or extract) is a quotation in a written document which is set off from the main text as a container for distinct paragraphs, which is typically distinguished visually using indentation, a different font, or smaller size. Block quotations are used for longer passages than run-in quotations (which are set off with quotation marks).
    /// <see href="http://purl.org/spar/doco/BlockQuotation"></see></summary>
    let BlockQuotation = _prefix "BlockQuotation"
    /// <summary>
    /// A block containing a label for the chapter, that may include the chapter number.
    /// <see href="http://purl.org/spar/doco/ChapterLabel"></see></summary>
    let ChapterLabel = _prefix "ChapterLabel"
    /// <summary>
    /// A block containing a label for the section, that may include the section number.
    /// <see href="http://purl.org/spar/doco/SectionLabel"></see></summary>
    let SectionLabel = _prefix "SectionLabel"
    /// <summary>
    /// The subtitle of a chapter.
    /// <see href="http://purl.org/spar/doco/ChapterSubtitle"></see></summary>
    let ChapterSubtitle = _prefix "ChapterSubtitle"
    /// <summary>
    /// The subtitle of a section.
    /// <see href="http://purl.org/spar/doco/SectionSubtitle"></see></summary>
    let SectionSubtitle = _prefix "SectionSubtitle"
    /// <summary>
    /// The title of a chapter.
    /// <see href="http://purl.org/spar/doco/ChapterTitle"></see></summary>
    let ChapterTitle = _prefix "ChapterTitle"
    /// <summary>
    /// The title of a section.
    /// <see href="http://purl.org/spar/doco/SectionTitle"></see></summary>
    let SectionTitle = _prefix "SectionTitle"
    /// <summary>
    /// A communication object comprising one or more graphics, drawings, images, or other visual representations..
    /// <see href="http://purl.org/spar/doco/Figure"></see></summary>
    let Figure = _prefix "Figure"
    /// <summary>
    /// A space within a document that contains a figure and its caption.
    /// <see href="http://purl.org/spar/doco/FigureBox"></see></summary>
    let FigureBox = _prefix "FigureBox"
    /// <summary>
    /// A space within a document that contains a table and its caption.
    /// <see href="http://purl.org/spar/doco/TableBox"></see></summary>
    let TableBox = _prefix "TableBox"
    /// <summary>
    /// A block containing a label for the figure box, that may include the figure number.
    /// <see href="http://purl.org/spar/doco/FigureLabel"></see></summary>
    let FigureLabel = _prefix "FigureLabel"
    /// <summary>
    /// A line in poetry is a unit of language into which a poem is divided which operates on principles which are distinct from and not necessarily coincident with grammatical structures, such as the sentence or clauses in sentences.
    ///
    /// A distinct numbered group of lines in verse is normally called a stanza.
    /// <see href="http://purl.org/spar/doco/Line"></see></summary>
    let Line = _prefix "Line"
    /// <summary>
    /// A list of items each denoting an agent, such as an author, a contributor or an organization, related to a particular publication.
    /// <see href="http://purl.org/spar/doco/ListOfAgents"></see></summary>
    let ListOfAgents = _prefix "ListOfAgents"
    /// <summary>
    /// A unit within a larger poem. A stanza consists of a grouping of lines, set off by a vertical space from other stanzas, that usually has a set pattern of meter and rhyme.
    /// <see href="http://purl.org/spar/doco/Stanza"></see></summary>
    let Stanza = _prefix "Stanza"
    /// <summary>
    /// A block containing a label for the table box, that may include the table number.
    /// <see href="http://purl.org/spar/doco/TableLabel"></see></summary>
    let TableLabel = _prefix "TableLabel"
    /// <summary>
    /// A space within a document that contains textual content relating to, quoting from or expanding upon the main text. Usually a textbox is delimited by a border or use of a background colour distinct from that of the main text.
    /// <see href="http://purl.org/spar/doco/TextBox"></see></summary>
    let TextBox = _prefix "TextBox"
