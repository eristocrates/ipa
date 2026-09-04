#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module doco =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/spar/doco/" "doco"
    /// <summary>
    ///   <para>rdfs:comment : A brief summary of a book, a research article, thesis, review, conference proceeding or any in-depth analysis of a particular subject or discipline, the purpose of which is to help the reader quickly ascertain the publication's purpose.^^xsd:string</para>
    ///   <para>rdfs:label : abstract^^xsd:string</para>
    ///   <a href="http://purl.org/spar/doco/Abstract">doco:Abstract</a>
    /// </summary>
    let Abstract = _prefixId.prefix "Abstract"
    /// <summary>
    ///   <para>rdfs:comment : A literary device that is often found at the end of a piece of literature. It generally covers the story of how the book came into being, or how the idea for the book was developed. Alternatively, it may be written by someone other than the author of the book, and may discuss the work's historical or cultural context, if the work is being reissued many years after its original publication.</para>
    ///   <para>rdfs:label : afterword</para>
    ///   <a href="http://purl.org/spar/doco/Afterword">doco:Afterword</a>
    /// </summary>
    let Afterword = _prefixId.prefix "Afterword"
    /// <summary>
    ///   <para>rdfs:comment : A supplemental addition to the main work. It may contain data, more detailed information about methods and materials, or provide additional detail concerning the information found in the main work.</para>
    ///   <para>rdfs:label : appendix</para>
    ///   <a href="http://purl.org/spar/doco/Appendix">doco:Appendix</a>
    /// </summary>
    let Appendix = _prefixId.prefix "Appendix"
    /// <summary>
    ///   <para>rdfs:comment : The final principle part of a document, in which is usually found the bibliography, index, appendixes, etc.</para>
    ///   <para>rdfs:label : back matter</para>
    ///   <a href="http://purl.org/spar/doco/BackMatter">doco:BackMatter</a>
    /// </summary>
    let BackMatter = _prefixId.prefix "BackMatter"
    /// <summary>
    ///   <para>rdfs:comment : A list, usually within a bibliography, of all the references within the citing document that refer to  journal articles, books, book chapters, Web sites or similar publications.</para>
    ///   <para>rdfs:label : bibliographic reference list</para>
    ///   <a href="http://purl.org/spar/doco/BibliographicReferenceList">doco:BibliographicReferenceList</a>
    /// </summary>
    let BibliographicReferenceList = _prefixId.prefix "BibliographicReferenceList"
    /// <summary>
    ///   <para>rdfs:comment : A document section containing a list of bibliographic references.</para>
    ///   <para>rdfs:label : bibliography</para>
    ///   <a href="http://purl.org/spar/doco/Bibliography">doco:Bibliography</a>
    /// </summary>
    let Bibliography = _prefixId.prefix "Bibliography"
    /// <summary>
    ///   <para>rdfs:comment : A block quotation (also known as a long quotation or extract) is a quotation in a written document which is set off from the main text as a container for distinct paragraphs, which is typically distinguished visually using indentation, a different font, or smaller size. Block quotations are used for longer passages than run-in quotations (which are set off with quotation marks).</para>
    ///   <para>rdfs:label : block quotation</para>
    ///   <a href="http://purl.org/spar/doco/BlockQuotation">doco:BlockQuotation</a>
    /// </summary>
    let BlockQuotation = _prefixId.prefix "BlockQuotation"
    /// <summary>
    ///   <para>rdfs:comment : The central principle part of a document, that contains the real content. It may be subdivided hierarchically by the use of chapters and sections.</para>
    ///   <para>rdfs:label : body matter</para>
    ///   <a href="http://purl.org/spar/doco/BodyMatter">doco:BodyMatter</a>
    /// </summary>
    let BodyMatter = _prefixId.prefix "BodyMatter"
    /// <summary>
    ///   <para>rdfs:comment : A rectangle space within a page that contains an object and its related caption.</para>
    ///   <para>rdfs:label : captioned box</para>
    ///   <a href="http://purl.org/spar/doco/CaptionedBox">doco:CaptionedBox</a>
    /// </summary>
    let CaptionedBox = _prefixId.prefix "CaptionedBox"
    /// <summary>
    ///   <para>rdfs:comment : A principle division of the body matter of a large document, such as a book, a report or a legislative document.</para>
    ///   <para>rdfs:label : chapter</para>
    ///   <a href="http://purl.org/spar/doco/Chapter">doco:Chapter</a>
    /// </summary>
    let Chapter = _prefixId.prefix "Chapter"
    /// <summary>
    ///   <para>rdfs:comment : A block containing a label for the chapter, that may include the chapter number.</para>
    ///   <para>rdfs:label : chapter label</para>
    ///   <a href="http://purl.org/spar/doco/ChapterLabel">doco:ChapterLabel</a>
    /// </summary>
    let ChapterLabel = _prefixId.prefix "ChapterLabel"
    /// <summary>
    ///   <para>rdfs:comment : The subtitle of a chapter.</para>
    ///   <para>rdfs:label : chapter subtitle</para>
    ///   <a href="http://purl.org/spar/doco/ChapterSubtitle">doco:ChapterSubtitle</a>
    /// </summary>
    let ChapterSubtitle = _prefixId.prefix "ChapterSubtitle"
    /// <summary>
    ///   <para>rdfs:comment : The title of a chapter.</para>
    ///   <para>rdfs:label : chapter title</para>
    ///   <a href="http://purl.org/spar/doco/ChapterTitle">doco:ChapterTitle</a>
    /// </summary>
    let ChapterTitle = _prefixId.prefix "ChapterTitle"
    /// <summary>
    ///   <para>rdfs:comment : A brief description of publication or production notes relevant to the document.</para>
    ///   <para>rdfs:label : colophon</para>
    ///   <a href="http://purl.org/spar/doco/Colophon">doco:Colophon</a>
    /// </summary>
    let Colophon = _prefixId.prefix "Colophon"
    /// <summary>
    ///   <para>rdfs:comment : A quotation with a complex structure, that is included inline and is usually enclosed within quotation marks.</para>
    ///   <para>rdfs:label : complex run-in quotation</para>
    ///   <a href="http://purl.org/spar/doco/ComplexRunInQuotation">doco:ComplexRunInQuotation</a>
    /// </summary>
    let ComplexRunInQuotation = _prefixId.prefix "ComplexRunInQuotation"
    /// <summary>
    ///   <para>rdfs:comment : A communication object comprising one or more graphics, drawings, images, or other visual representations..</para>
    ///   <para>rdfs:label : figure</para>
    ///   <a href="http://purl.org/spar/doco/Figure">doco:Figure</a>
    /// </summary>
    let Figure = _prefixId.prefix "Figure"
    /// <summary>
    ///   <para>rdfs:comment : A space within a document that contains a figure and its caption.</para>
    ///   <para>rdfs:label : figure box</para>
    ///   <a href="http://purl.org/spar/doco/FigureBox">doco:FigureBox</a>
    /// </summary>
    let FigureBox = _prefixId.prefix "FigureBox"
    /// <summary>
    ///   <para>rdfs:comment : A block containing a label for the figure box, that may include the figure number.</para>
    ///   <para>rdfs:label : figure label</para>
    ///   <a href="http://purl.org/spar/doco/FigureLabel">doco:FigureLabel</a>
    /// </summary>
    let FigureLabel = _prefixId.prefix "FigureLabel"
    /// <summary>
    ///   <para>rdfs:comment : A structure within a sentence that permits the author to make a comment or to cite another publication in support of the text, or both. A footnote is normally flagged by a superscript number immediately following that portion of the text to which it relates. For convenience of reading, the text of the footnote is usually printed at the bottom of the page or at the end of a text.</para>
    ///   <para>rdfs:label : footnote</para>
    ///   <a href="http://purl.org/spar/doco/Footnote">doco:Footnote</a>
    /// </summary>
    let Footnote = _prefixId.prefix "Footnote"
    /// <summary>
    ///   <para>rdfs:comment : A section in a book or report, usually written by someone other than the author, that introduces or commends the document to the reader. It may include description of the interaction between the writer of the foreword and the author.</para>
    ///   <para>rdfs:label : foreword</para>
    ///   <a href="http://purl.org/spar/doco/Foreword">doco:Foreword</a>
    /// </summary>
    let Foreword = _prefixId.prefix "Foreword"
    /// <summary>
    ///   <para>rdfs:comment : A unit of information expressed in mathematical, chemical or logical symbols and language.</para>
    ///   <para>rdfs:label : formula</para>
    ///   <a href="http://purl.org/spar/doco/Formula">doco:Formula</a>
    /// </summary>
    let Formula = _prefixId.prefix "Formula"
    /// <summary>
    ///   <para>rdfs:comment : A space within a document that contains one or more formulae.</para>
    ///   <para>rdfs:label : formula box</para>
    ///   <a href="http://purl.org/spar/doco/FormulaBox">doco:FormulaBox</a>
    /// </summary>
    let FormulaBox = _prefixId.prefix "FormulaBox"
    /// <summary>
    ///   <para>rdfs:comment : The initial principle part of a document, usually containing self-referential metadata. In a book, this typically includes its title, authors, publisher, publication date, ISBN and copyright declaration, together with the preface, foreword, table of content, etc. In a journal article, the front matter is normally restricted to the title, authors and the authors' affiliation details, although the latter may alternatively be included in a footnote or the back matter. In books, the front matter pages may be numbered in lowercase Roman numerals.</para>
    ///   <para>rdfs:label : front matter</para>
    ///   <a href="http://purl.org/spar/doco/FrontMatter">doco:FrontMatter</a>
    /// </summary>
    let FrontMatter = _prefixId.prefix "FrontMatter"
    /// <summary>
    ///   <para>rdfs:comment : A set of definitions of words or phrases of importance to the work, normally alphabetized. In longer works of fiction, the entries may contains places and characters.</para>
    ///   <para>rdfs:label : glossary</para>
    ///   <a href="http://purl.org/spar/doco/Glossary">doco:Glossary</a>
    /// </summary>
    let Glossary = _prefixId.prefix "Glossary"
    /// <summary>
    ///   <para>rdfs:comment : A section containing a list of references to information on the named topic of importance to the content of the document. The references may be to page numbers, paragraph numbers, section numbers or chapter numbers within the document.</para>
    ///   <para>rdfs:label : index</para>
    ///   <a href="http://purl.org/spar/doco/Index">doco:Index</a>
    /// </summary>
    let Index = _prefixId.prefix "Index"
    /// <summary>
    ///   <para>rdfs:comment : A block containing text, that may include a number (e.g., "Chapter Three", "3.2", "Figure 1", "Table"), used to identify an item within the document, for example a chapter, a figure, a section or a table.</para>
    ///   <para>rdfs:label : label</para>
    ///   <a href="http://purl.org/spar/doco/Label">doco:Label</a>
    /// </summary>
    let Label = _prefixId.prefix "Label"
    /// <summary>
    ///   <para>rdfs:comment : A line in poetry is a unit of language into which a poem is divided which operates on principles which are distinct from and not necessarily coincident with grammatical structures, such as the sentence or clauses in sentences.
    ///
    /// A distinct numbered group of lines in verse is normally called a stanza.</para>
    ///   <para>rdfs:label : line</para>
    ///   <a href="http://purl.org/spar/doco/Line">doco:Line</a>
    /// </summary>
    let Line = _prefixId.prefix "Line"
    /// <summary>
    ///   <para>rdfs:comment : An enumeration of items.</para>
    ///   <para>rdfs:label : list</para>
    ///   <a href="http://purl.org/spar/doco/List">doco:List</a>
    /// </summary>
    let List = _prefixId.prefix "List"
    /// <summary>
    ///   <para>rdfs:comment : A list of items each denoting an agent, such as an author, a contributor or an organization, related to a particular publication.</para>
    ///   <para>rdfs:label : list of agents</para>
    ///   <a href="http://purl.org/spar/doco/ListOfAgents">doco:ListOfAgents</a>
    /// </summary>
    let ListOfAgents = _prefixId.prefix "ListOfAgents"
    /// <summary>
    ///   <para>rdfs:comment : A list of items each denoting an author of a particular publication.</para>
    ///   <para>rdfs:label : list of authors</para>
    ///   <a href="http://purl.org/spar/doco/ListOfAuthors">doco:ListOfAuthors</a>
    /// </summary>
    let ListOfAuthors = _prefixId.prefix "ListOfAuthors"
    /// <summary>
    ///   <para>rdfs:comment : A list of items, each denoting a contributor to a publication such as an encyclopedia or a text book, where such contributions are insufficient to warrant classification as author.</para>
    ///   <para>rdfs:label : list of contributors</para>
    ///   <a href="http://purl.org/spar/doco/ListOfContributors">doco:ListOfContributors</a>
    /// </summary>
    let ListOfContributors = _prefixId.prefix "ListOfContributors"
    /// <summary>
    ///   <para>rdfs:comment : A section of the document listing all the figures, identified by their titles and referenced to their locations in the document. May also be referred to as 'List of illustrations'.</para>
    ///   <para>rdfs:label : list of figures</para>
    ///   <a href="http://purl.org/spar/doco/ListOfFigures">doco:ListOfFigures</a>
    /// </summary>
    let ListOfFigures = _prefixId.prefix "ListOfFigures"
    /// <summary>
    ///   <para>rdfs:comment : A list of items, each denoting an organization or institution related to the publication, for example the authors' affiliations, or the suppliers of information, software, equipment or consumables used in the work described in the publication.</para>
    ///   <para>rdfs:label : list of organizations</para>
    ///   <a href="http://purl.org/spar/doco/ListOfOrganizations">doco:ListOfOrganizations</a>
    /// </summary>
    let ListOfOrganizations = _prefixId.prefix "ListOfOrganizations"
    /// <summary>
    ///   <para>rdfs:comment : A list of items each representing a reference to a specific part of the same document, or to another publication.</para>
    ///   <para>rdfs:label : list of references</para>
    ///   <a href="http://purl.org/spar/doco/ListOfReferences">doco:ListOfReferences</a>
    /// </summary>
    let ListOfReferences = _prefixId.prefix "ListOfReferences"
    /// <summary>
    ///   <para>rdfs:comment : A section of the document listing all the tables, identified by their titles and referenced to their locations in the document.</para>
    ///   <para>rdfs:label : list of tables</para>
    ///   <a href="http://purl.org/spar/doco/ListOfTables">doco:ListOfTables</a>
    /// </summary>
    let ListOfTables = _prefixId.prefix "ListOfTables"
    /// <summary>
    ///   <para>rdfs:comment : A self-contained unit of discourse that deals with a particular point or idea. Paragraphs contains one or more sentences. The start of a paragraph is indicated by beginning on a new line, which may be indented or separated by a small vertical space by the preceding paragraph. </para>
    ///   <para>rdfs:label : paragraph</para>
    ///   <a href="http://purl.org/spar/doco/Paragraph">doco:Paragraph</a>
    /// </summary>
    let Paragraph = _prefixId.prefix "Paragraph"
    /// <summary>
    ///   <para>rdfs:comment : A container of a semantic subdivision of a document. For example, chapters of a novel may be grouped into distinct parts that may be named 'Part 1', 'Part 2', etc., 'Book 1', 'Book 2', etc., or 'Genesis', 'Exodus', etc.</para>
    ///   <para>rdfs:label : part</para>
    ///   <a href="http://purl.org/spar/doco/Part">doco:Part</a>
    /// </summary>
    let Part = _prefixId.prefix "Part"
    /// <summary>
    ///   <para>rdfs:comment : A section describing how the document came into being, or how the idea for it was developed. The preface may contains acknowledgements. The preface to a later edition of the work often explains in what respect that edition differs from previous ones.</para>
    ///   <para>rdfs:label : preface</para>
    ///   <a href="http://purl.org/spar/doco/Preface">doco:Preface</a>
    /// </summary>
    let Preface = _prefixId.prefix "Preface"
    /// <summary>
    ///   <para>rdfs:comment : A logical division of the text, usually numbered and/or titled, which may contain subsections.</para>
    ///   <para>rdfs:label : section</para>
    ///   <a href="http://purl.org/spar/doco/Section">doco:Section</a>
    /// </summary>
    let Section = _prefixId.prefix "Section"
    /// <summary>
    ///   <para>rdfs:comment : A block containing a label for the section, that may include the section number.</para>
    ///   <para>rdfs:label : section label</para>
    ///   <a href="http://purl.org/spar/doco/SectionLabel">doco:SectionLabel</a>
    /// </summary>
    let SectionLabel = _prefixId.prefix "SectionLabel"
    /// <summary>
    ///   <para>rdfs:comment : The subtitle of a section.</para>
    ///   <para>rdfs:label : section subtitle</para>
    ///   <a href="http://purl.org/spar/doco/SectionSubtitle">doco:SectionSubtitle</a>
    /// </summary>
    let SectionSubtitle = _prefixId.prefix "SectionSubtitle"
    /// <summary>
    ///   <para>rdfs:comment : The title of a section.</para>
    ///   <para>rdfs:label : section title</para>
    ///   <a href="http://purl.org/spar/doco/SectionTitle">doco:SectionTitle</a>
    /// </summary>
    let SectionTitle = _prefixId.prefix "SectionTitle"
    /// <summary>
    ///   <para>rdfs:comment : An expression in natural language forming a single grammatical unit. A sentence minimally consists of a subject and an intransitive verb, or a subject, a transitive verb and an object, and may include additional dependent clauses. In written text, a sentence is always terminated by a full stop. A sentence can include words grouped meaningfully to express a statement, a question, an exclamation, a request or a command.</para>
    ///   <para>rdfs:label : sentence</para>
    ///   <a href="http://purl.org/spar/doco/Sentence">doco:Sentence</a>
    /// </summary>
    let Sentence = _prefixId.prefix "Sentence"
    /// <summary>
    ///   <para>rdfs:comment : A textual quotation that is included inline and is usually enclosed within quotation marks.</para>
    ///   <para>rdfs:label : simple run-in quotation</para>
    ///   <a href="http://purl.org/spar/doco/SimpleRunInQuotation">doco:SimpleRunInQuotation</a>
    /// </summary>
    let SimpleRunInQuotation = _prefixId.prefix "SimpleRunInQuotation"
    /// <summary>
    ///   <para>rdfs:comment : A unit within a larger poem. A stanza consists of a grouping of lines, set off by a vertical space from other stanzas, that usually has a set pattern of meter and rhyme.</para>
    ///   <para>rdfs:label : stanza</para>
    ///   <a href="http://purl.org/spar/doco/Stanza">doco:Stanza</a>
    /// </summary>
    let Stanza = _prefixId.prefix "Stanza"
    /// <summary>
    ///   <para>rdfs:comment : An explanatory or alternative title of a publication. For example, Mary Shelley uses the alternative title 'The Modern Prometheus' to hint at the theme of her most famous novel 'Frankenstein'; Nick Efford uses the subtitle 'a practical introduction using Java' to qualify the title of his book 'Digital Image Processing'.</para>
    ///   <para>rdfs:label : subtitle</para>
    ///   <a href="http://purl.org/spar/doco/Subtitle">doco:Subtitle</a>
    /// </summary>
    let Subtitle = _prefixId.prefix "Subtitle"
    /// <summary>
    ///   <para>rdfs:comment : A set of data arranged in cells within rows and columns.</para>
    ///   <para>rdfs:label : table</para>
    ///   <a href="http://purl.org/spar/doco/Table">doco:Table</a>
    /// </summary>
    let Table = _prefixId.prefix "Table"
    /// <summary>
    ///   <para>rdfs:comment : A space within a document that contains a table and its caption.</para>
    ///   <para>rdfs:label : table box</para>
    ///   <a href="http://purl.org/spar/doco/TableBox">doco:TableBox</a>
    /// </summary>
    let TableBox = _prefixId.prefix "TableBox"
    /// <summary>
    ///   <para>rdfs:comment : A block containing a label for the table box, that may include the table number.</para>
    ///   <para>rdfs:label : table label</para>
    ///   <a href="http://purl.org/spar/doco/TableLabel">doco:TableLabel</a>
    /// </summary>
    let TableLabel = _prefixId.prefix "TableLabel"
    /// <summary>
    ///   <para>rdfs:comment : A section of the document listing all the chapters and sections, identified by their titles and referenced to their locations in the document. The table of contents may include a list of the front-matter and back-matter items, in addition to the body-matter items.  Where the document is a journal or magazine issue, the table of content lists the constituent items contained in that issue, typically by title, authors and first page number.</para>
    ///   <para>rdfs:label : table of contents</para>
    ///   <a href="http://purl.org/spar/doco/TableOfContents">doco:TableOfContents</a>
    /// </summary>
    let TableOfContents = _prefixId.prefix "TableOfContents"
    /// <summary>
    ///   <para>rdfs:comment : A space within a document that contains textual content relating to, quoting from or expanding upon the main text. Usually a textbox is delimited by a border or use of a background colour distinct from that of the main text.</para>
    ///   <para>rdfs:label : text box</para>
    ///   <a href="http://purl.org/spar/doco/TextBox">doco:TextBox</a>
    /// </summary>
    let TextBox = _prefixId.prefix "TextBox"
    /// <summary>
    ///   <para>rdfs:comment : A piece of text defined by a start point and an end point.</para>
    ///   <para>rdfs:label : text chunk</para>
    ///   <a href="http://purl.org/spar/doco/TextChunk">doco:TextChunk</a>
    /// </summary>
    let TextChunk = _prefixId.prefix "TextChunk"
    /// <summary>
    ///   <para>rdfs:comment : A word, phrase or sentence that precedes and indicates the subject of a document or a document component - e.g., a book, a report, a news article, a chapter, a section or a table.</para>
    ///   <para>rdfs:label : title</para>
    ///   <a href="http://purl.org/spar/doco/Title">doco:Title</a>
    /// </summary>
    let Title = _prefixId.prefix "Title"
