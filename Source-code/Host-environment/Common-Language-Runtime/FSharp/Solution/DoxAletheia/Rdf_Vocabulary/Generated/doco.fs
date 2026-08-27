namespace http.purl.org.spar.doco.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module doco =
    let _namespace_iri = Namespace_Iri doco |> NamespaceIRI
    /// <summary>
    ///   <para>doco:2015-07-03</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/doco/2015-07-03">http://purl.org/spar/doco/2015-07-03</seealso>
    let _2015_07_03 = Prefixed_Name(doco, "2015-07-03") |> PrefixedName
    /// <summary>
    ///   <para>doco:Abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A brief summary of a book, a research article, thesis, review, conference proceeding or any in-depth analysis of a particular subject or discipline, the purpose of which is to help the reader quickly ascertain the publication's purpose."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"abstract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Abstract">http://purl.org/spar/doco/Abstract</seealso>
    let Abstract = Prefixed_Name(doco, "Abstract") |> PrefixedName
    /// <summary>
    ///   <para>doco:Afterword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A literary device that is often found at the end of a piece of literature. It generally covers the story of how the book came into being, or how the idea for the book was developed. Alternatively, it may be written by someone other than the author of the book, and may discuss the work's historical or cultural context, if the work is being reissued many years after its original publication."</para>
    /// labels<para>"afterword"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Afterword">http://purl.org/spar/doco/Afterword</seealso>
    let Afterword = Prefixed_Name(doco, "Afterword") |> PrefixedName
    /// <summary>
    ///   <para>doco:Appendix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A supplemental addition to the main work. It may contain data, more detailed information about methods and materials, or provide additional detail concerning the information found in the main work."</para>
    /// labels<para>"appendix"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Appendix">http://purl.org/spar/doco/Appendix</seealso>
    let Appendix = Prefixed_Name(doco, "Appendix") |> PrefixedName
    /// <summary>
    ///   <para>doco:BackMatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The final principle part of a document, in which is usually found the bibliography, index, appendixes, etc."</para>
    /// labels<para>"back matter"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/BackMatter">http://purl.org/spar/doco/BackMatter</seealso>
    let BackMatter = Prefixed_Name(doco, "BackMatter") |> PrefixedName

    /// <summary>
    ///   <para>doco:BibliographicReferenceList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A list, usually within a bibliography, of all the references within the citing document that refer to  journal articles, books, book chapters, Web sites or similar publications."</para>
    /// labels<para>"bibliographic reference list"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/BibliographicReferenceList">http://purl.org/spar/doco/BibliographicReferenceList</seealso>
    let BibliographicReferenceList =
        Prefixed_Name(doco, "BibliographicReferenceList") |> PrefixedName

    /// <summary>
    ///   <para>doco:Bibliography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document section containing a list of bibliographic references."</para>
    /// labels<para>"bibliography"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Bibliography">http://purl.org/spar/doco/Bibliography</seealso>
    let Bibliography = Prefixed_Name(doco, "Bibliography") |> PrefixedName
    /// <summary>
    ///   <para>doco:BlockQuotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A block quotation (also known as a long quotation or extract) is a quotation in a written document which is set off from the main text as a container for distinct paragraphs, which is typically distinguished visually using indentation, a different font, or smaller size. Block quotations are used for longer passages than run-in quotations (which are set off with quotation marks)."</para>
    /// labels<para>"block quotation"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/BlockQuotation">http://purl.org/spar/doco/BlockQuotation</seealso>
    let BlockQuotation = Prefixed_Name(doco, "BlockQuotation") |> PrefixedName
    /// <summary>
    ///   <para>doco:BodyMatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The central principle part of a document, that contains the real content. It may be subdivided hierarchically by the use of chapters and sections."</para>
    /// labels<para>"body matter"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/BodyMatter">http://purl.org/spar/doco/BodyMatter</seealso>
    let BodyMatter = Prefixed_Name(doco, "BodyMatter") |> PrefixedName
    /// <summary>
    ///   <para>doco:CaptionedBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A rectangle space within a page that contains an object and its related caption."</para>
    /// labels<para>"captioned box"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/CaptionedBox">http://purl.org/spar/doco/CaptionedBox</seealso>
    let CaptionedBox = Prefixed_Name(doco, "CaptionedBox") |> PrefixedName
    /// <summary>
    ///   <para>doco:Chapter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A principle division of the body matter of a large document, such as a book, a report or a legislative document."</para>
    /// labels<para>"chapter"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Chapter">http://purl.org/spar/doco/Chapter</seealso>
    let Chapter = Prefixed_Name(doco, "Chapter") |> PrefixedName
    /// <summary>
    ///   <para>doco:ChapterLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A block containing a label for the chapter, that may include the chapter number."</para>
    /// labels<para>"chapter label"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/ChapterLabel">http://purl.org/spar/doco/ChapterLabel</seealso>
    let ChapterLabel = Prefixed_Name(doco, "ChapterLabel") |> PrefixedName
    /// <summary>
    ///   <para>doco:ChapterSubtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The subtitle of a chapter."</para>
    /// labels<para>"chapter subtitle"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/ChapterSubtitle">http://purl.org/spar/doco/ChapterSubtitle</seealso>
    let ChapterSubtitle = Prefixed_Name(doco, "ChapterSubtitle") |> PrefixedName
    /// <summary>
    ///   <para>doco:ChapterTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The title of a chapter."</para>
    /// labels<para>"chapter title"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/ChapterTitle">http://purl.org/spar/doco/ChapterTitle</seealso>
    let ChapterTitle = Prefixed_Name(doco, "ChapterTitle") |> PrefixedName
    /// <summary>
    ///   <para>doco:Colophon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A brief description of publication or production notes relevant to the document."</para>
    /// labels<para>"colophon"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Colophon">http://purl.org/spar/doco/Colophon</seealso>
    let Colophon = Prefixed_Name(doco, "Colophon") |> PrefixedName

    /// <summary>
    ///   <para>doco:ComplexRunInQuotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A quotation with a complex structure, that is included inline and is usually enclosed within quotation marks."</para>
    /// labels<para>"complex run-in quotation"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/ComplexRunInQuotation">http://purl.org/spar/doco/ComplexRunInQuotation</seealso>
    let ComplexRunInQuotation =
        Prefixed_Name(doco, "ComplexRunInQuotation") |> PrefixedName

    /// <summary>
    ///   <para>doco:Figure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A communication object comprising one or more graphics, drawings, images, or other visual representations.."</para>
    /// labels<para>"figure"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Figure">http://purl.org/spar/doco/Figure</seealso>
    let Figure = Prefixed_Name(doco, "Figure") |> PrefixedName
    /// <summary>
    ///   <para>doco:FigureBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A space within a document that contains a figure and its caption."</para>
    /// labels<para>"figure box"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/FigureBox">http://purl.org/spar/doco/FigureBox</seealso>
    let FigureBox = Prefixed_Name(doco, "FigureBox") |> PrefixedName
    /// <summary>
    ///   <para>doco:FigureLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A block containing a label for the figure box, that may include the figure number."</para>
    /// labels<para>"figure label"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/FigureLabel">http://purl.org/spar/doco/FigureLabel</seealso>
    let FigureLabel = Prefixed_Name(doco, "FigureLabel") |> PrefixedName
    /// <summary>
    ///   <para>doco:Footnote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A structure within a sentence that permits the author to make a comment or to cite another publication in support of the text, or both. A footnote is normally flagged by a superscript number immediately following that portion of the text to which it relates. For convenience of reading, the text of the footnote is usually printed at the bottom of the page or at the end of a text."</para>
    /// labels<para>"footnote"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Footnote">http://purl.org/spar/doco/Footnote</seealso>
    let Footnote = Prefixed_Name(doco, "Footnote") |> PrefixedName
    /// <summary>
    ///   <para>doco:Foreword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A section in a book or report, usually written by someone other than the author, that introduces or commends the document to the reader. It may include description of the interaction between the writer of the foreword and the author."</para>
    /// labels<para>"foreword"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Foreword">http://purl.org/spar/doco/Foreword</seealso>
    let Foreword = Prefixed_Name(doco, "Foreword") |> PrefixedName
    /// <summary>
    ///   <para>doco:Formula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A unit of information expressed in mathematical, chemical or logical symbols and language."</para>
    /// labels<para>"formula"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Formula">http://purl.org/spar/doco/Formula</seealso>
    let Formula = Prefixed_Name(doco, "Formula") |> PrefixedName
    /// <summary>
    ///   <para>doco:FormulaBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A space within a document that contains one or more formulae."</para>
    /// labels<para>"formula box"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/FormulaBox">http://purl.org/spar/doco/FormulaBox</seealso>
    let FormulaBox = Prefixed_Name(doco, "FormulaBox") |> PrefixedName
    /// <summary>
    ///   <para>doco:FrontMatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The initial principle part of a document, usually containing self-referential metadata. In a book, this typically includes its title, authors, publisher, publication date, ISBN and copyright declaration, together with the preface, foreword, table of content, etc. In a journal article, the front matter is normally restricted to the title, authors and the authors' affiliation details, although the latter may alternatively be included in a footnote or the back matter. In books, the front matter pages may be numbered in lowercase Roman numerals."</para>
    /// labels<para>"front matter"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/FrontMatter">http://purl.org/spar/doco/FrontMatter</seealso>
    let FrontMatter = Prefixed_Name(doco, "FrontMatter") |> PrefixedName
    /// <summary>
    ///   <para>doco:Glossary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of definitions of words or phrases of importance to the work, normally alphabetized. In longer works of fiction, the entries may contains places and characters."</para>
    /// labels<para>"glossary"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Glossary">http://purl.org/spar/doco/Glossary</seealso>
    let Glossary = Prefixed_Name(doco, "Glossary") |> PrefixedName
    /// <summary>
    ///   <para>doco:Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A section containing a list of references to information on the named topic of importance to the content of the document. The references may be to page numbers, paragraph numbers, section numbers or chapter numbers within the document."</para>
    /// labels<para>"index"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Index">http://purl.org/spar/doco/Index</seealso>
    let Index = Prefixed_Name(doco, "Index") |> PrefixedName
    /// <summary>
    ///   <para>doco:Label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A block containing text, that may include a number (e.g., "Chapter Three", "3.2", "Figure 1", "Table"), used to identify an item within the document, for example a chapter, a figure, a section or a table."</para>
    /// labels<para>"label"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Label">http://purl.org/spar/doco/Label</seealso>
    let Label = Prefixed_Name(doco, "Label") |> PrefixedName
    /// <summary>
    ///   <para>doco:Line</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A line in poetry is a unit of language into which a poem is divided which operates on principles which are distinct from and not necessarily coincident with grammatical structures, such as the sentence or clauses in sentences.
    ///
    /// A distinct numbered group of lines in verse is normally called a stanza."</para>
    /// labels<para>"line"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Line">http://purl.org/spar/doco/Line</seealso>
    let Line = Prefixed_Name(doco, "Line") |> PrefixedName
    /// <summary>
    ///   <para>doco:List</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An enumeration of items."</para>
    /// labels<para>"list"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/List">http://purl.org/spar/doco/List</seealso>
    let List = Prefixed_Name(doco, "List") |> PrefixedName
    /// <summary>
    ///   <para>doco:ListOfAgents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A list of items each denoting an agent, such as an author, a contributor or an organization, related to a particular publication."</para>
    /// labels<para>"list of agents"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/ListOfAgents">http://purl.org/spar/doco/ListOfAgents</seealso>
    let ListOfAgents = Prefixed_Name(doco, "ListOfAgents") |> PrefixedName
    /// <summary>
    ///   <para>doco:ListOfAuthors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A list of items each denoting an author of a particular publication."</para>
    /// labels<para>"list of authors"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/ListOfAuthors">http://purl.org/spar/doco/ListOfAuthors</seealso>
    let ListOfAuthors = Prefixed_Name(doco, "ListOfAuthors") |> PrefixedName
    /// <summary>
    ///   <para>doco:ListOfContributors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A list of items, each denoting a contributor to a publication such as an encyclopedia or a text book, where such contributions are insufficient to warrant classification as author."</para>
    /// labels<para>"list of contributors"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/ListOfContributors">http://purl.org/spar/doco/ListOfContributors</seealso>
    let ListOfContributors = Prefixed_Name(doco, "ListOfContributors") |> PrefixedName
    /// <summary>
    ///   <para>doco:ListOfFigures</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A section of the document listing all the figures, identified by their titles and referenced to their locations in the document. May also be referred to as 'List of illustrations'."</para>
    /// labels<para>"list of figures"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/ListOfFigures">http://purl.org/spar/doco/ListOfFigures</seealso>
    let ListOfFigures = Prefixed_Name(doco, "ListOfFigures") |> PrefixedName
    /// <summary>
    ///   <para>doco:ListOfOrganizations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A list of items, each denoting an organization or institution related to the publication, for example the authors' affiliations, or the suppliers of information, software, equipment or consumables used in the work described in the publication."</para>
    /// labels<para>"list of organizations"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/ListOfOrganizations">http://purl.org/spar/doco/ListOfOrganizations</seealso>
    let ListOfOrganizations = Prefixed_Name(doco, "ListOfOrganizations") |> PrefixedName
    /// <summary>
    ///   <para>doco:ListOfReferences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A list of items each representing a reference to a specific part of the same document, or to another publication."</para>
    /// labels<para>"list of references"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/ListOfReferences">http://purl.org/spar/doco/ListOfReferences</seealso>
    let ListOfReferences = Prefixed_Name(doco, "ListOfReferences") |> PrefixedName
    /// <summary>
    ///   <para>doco:ListOfTables</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A section of the document listing all the tables, identified by their titles and referenced to their locations in the document."</para>
    /// labels<para>"list of tables"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/ListOfTables">http://purl.org/spar/doco/ListOfTables</seealso>
    let ListOfTables = Prefixed_Name(doco, "ListOfTables") |> PrefixedName
    /// <summary>
    ///   <para>doco:Paragraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A self-contained unit of discourse that deals with a particular point or idea. Paragraphs contains one or more sentences. The start of a paragraph is indicated by beginning on a new line, which may be indented or separated by a small vertical space by the preceding paragraph. "</para>
    /// labels<para>"paragraph"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Paragraph">http://purl.org/spar/doco/Paragraph</seealso>
    let Paragraph = Prefixed_Name(doco, "Paragraph") |> PrefixedName
    /// <summary>
    ///   <para>doco:Part</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A container of a semantic subdivision of a document. For example, chapters of a novel may be grouped into distinct parts that may be named 'Part 1', 'Part 2', etc., 'Book 1', 'Book 2', etc., or 'Genesis', 'Exodus', etc."</para>
    /// labels<para>"part"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Part">http://purl.org/spar/doco/Part</seealso>
    let Part = Prefixed_Name(doco, "Part") |> PrefixedName
    /// <summary>
    ///   <para>doco:Preface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A section describing how the document came into being, or how the idea for it was developed. The preface may contains acknowledgements. The preface to a later edition of the work often explains in what respect that edition differs from previous ones."</para>
    /// labels<para>"preface"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Preface">http://purl.org/spar/doco/Preface</seealso>
    let Preface = Prefixed_Name(doco, "Preface") |> PrefixedName
    /// <summary>
    ///   <para>doco:Section</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A logical division of the text, usually numbered and/or titled, which may contain subsections."</para>
    /// labels<para>"section"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Section">http://purl.org/spar/doco/Section</seealso>
    let Section = Prefixed_Name(doco, "Section") |> PrefixedName
    /// <summary>
    ///   <para>doco:SectionLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A block containing a label for the section, that may include the section number."</para>
    /// labels<para>"section label"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/SectionLabel">http://purl.org/spar/doco/SectionLabel</seealso>
    let SectionLabel = Prefixed_Name(doco, "SectionLabel") |> PrefixedName
    /// <summary>
    ///   <para>doco:SectionSubtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The subtitle of a section."</para>
    /// labels<para>"section subtitle"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/SectionSubtitle">http://purl.org/spar/doco/SectionSubtitle</seealso>
    let SectionSubtitle = Prefixed_Name(doco, "SectionSubtitle") |> PrefixedName
    /// <summary>
    ///   <para>doco:SectionTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The title of a section."</para>
    /// labels<para>"section title"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/SectionTitle">http://purl.org/spar/doco/SectionTitle</seealso>
    let SectionTitle = Prefixed_Name(doco, "SectionTitle") |> PrefixedName
    /// <summary>
    ///   <para>doco:Sentence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An expression in natural language forming a single grammatical unit. A sentence minimally consists of a subject and an intransitive verb, or a subject, a transitive verb and an object, and may include additional dependent clauses. In written text, a sentence is always terminated by a full stop. A sentence can include words grouped meaningfully to express a statement, a question, an exclamation, a request or a command."</para>
    /// labels<para>"sentence"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Sentence">http://purl.org/spar/doco/Sentence</seealso>
    let Sentence = Prefixed_Name(doco, "Sentence") |> PrefixedName

    /// <summary>
    ///   <para>doco:SimpleRunInQuotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A textual quotation that is included inline and is usually enclosed within quotation marks."</para>
    /// labels<para>"simple run-in quotation"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/SimpleRunInQuotation">http://purl.org/spar/doco/SimpleRunInQuotation</seealso>
    let SimpleRunInQuotation =
        Prefixed_Name(doco, "SimpleRunInQuotation") |> PrefixedName

    /// <summary>
    ///   <para>doco:Stanza</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A unit within a larger poem. A stanza consists of a grouping of lines, set off by a vertical space from other stanzas, that usually has a set pattern of meter and rhyme."</para>
    /// labels<para>"stanza"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Stanza">http://purl.org/spar/doco/Stanza</seealso>
    let Stanza = Prefixed_Name(doco, "Stanza") |> PrefixedName
    /// <summary>
    ///   <para>doco:Subtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An explanatory or alternative title of a publication. For example, Mary Shelley uses the alternative title 'The Modern Prometheus' to hint at the theme of her most famous novel 'Frankenstein'; Nick Efford uses the subtitle 'a practical introduction using Java' to qualify the title of his book 'Digital Image Processing'."</para>
    /// labels<para>"subtitle"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Subtitle">http://purl.org/spar/doco/Subtitle</seealso>
    let Subtitle = Prefixed_Name(doco, "Subtitle") |> PrefixedName
    /// <summary>
    ///   <para>doco:Table</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of data arranged in cells within rows and columns."</para>
    /// labels<para>"table"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Table">http://purl.org/spar/doco/Table</seealso>
    let Table = Prefixed_Name(doco, "Table") |> PrefixedName
    /// <summary>
    ///   <para>doco:TableBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A space within a document that contains a table and its caption."</para>
    /// labels<para>"table box"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/TableBox">http://purl.org/spar/doco/TableBox</seealso>
    let TableBox = Prefixed_Name(doco, "TableBox") |> PrefixedName
    /// <summary>
    ///   <para>doco:TableLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A block containing a label for the table box, that may include the table number."</para>
    /// labels<para>"table label"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/TableLabel">http://purl.org/spar/doco/TableLabel</seealso>
    let TableLabel = Prefixed_Name(doco, "TableLabel") |> PrefixedName
    /// <summary>
    ///   <para>doco:TableOfContents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A section of the document listing all the chapters and sections, identified by their titles and referenced to their locations in the document. The table of contents may include a list of the front-matter and back-matter items, in addition to the body-matter items.  Where the document is a journal or magazine issue, the table of content lists the constituent items contained in that issue, typically by title, authors and first page number."</para>
    /// labels<para>"table of contents"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/TableOfContents">http://purl.org/spar/doco/TableOfContents</seealso>
    let TableOfContents = Prefixed_Name(doco, "TableOfContents") |> PrefixedName
    /// <summary>
    ///   <para>doco:TextBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A space within a document that contains textual content relating to, quoting from or expanding upon the main text. Usually a textbox is delimited by a border or use of a background colour distinct from that of the main text."</para>
    /// labels<para>"text box"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/TextBox">http://purl.org/spar/doco/TextBox</seealso>
    let TextBox = Prefixed_Name(doco, "TextBox") |> PrefixedName
    /// <summary>
    ///   <para>doco:TextChunk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A piece of text defined by a start point and an end point."</para>
    /// labels<para>"text chunk"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/TextChunk">http://purl.org/spar/doco/TextChunk</seealso>
    let TextChunk = Prefixed_Name(doco, "TextChunk") |> PrefixedName
    /// <summary>
    ///   <para>doco:Title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A word, phrase or sentence that precedes and indicates the subject of a document or a document component - e.g., a book, a report, a news article, a chapter, a section or a table."</para>
    /// labels<para>"title"</para></remarks>
    /// <seealso href="http://purl.org/spar/doco/Title">http://purl.org/spar/doco/Title</seealso>
    let Title = Prefixed_Name(doco, "Title") |> PrefixedName
