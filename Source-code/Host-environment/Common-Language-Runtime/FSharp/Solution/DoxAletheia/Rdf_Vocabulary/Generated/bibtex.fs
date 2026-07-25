namespace http.purl.org.net.nknouf.ns.bibtex.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bibtex =
    let _namespace_iri = Namespace_Iri bibtex |> NamespaceIRI
    /// <summary>
    ///   <para>bibtex:Misc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Use this type when nothing else fits.</para>
    /// labels<para>Misc</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#Misc">http://purl.org/net/nknouf/ns/bibtex#Misc</seealso>
    let Misc = Prefixed_Name(bibtex, "Misc") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:pageChapterData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A generic property to hold page and/or chapter data.</para>
    /// labels<para>page and/or chapter data</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#pageChapterData">http://purl.org/net/nknouf/ns/bibtex#pageChapterData</seealso>
    let pageChapterData = Prefixed_Name(bibtex, "pageChapterData") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The work's title, typed as explained in the LaTeX book.</para>
    /// labels<para>has title</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasTitle">http://purl.org/net/nknouf/ns/bibtex#hasTitle</seealso>
    let hasTitle = Prefixed_Name(bibtex, "hasTitle") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:Article</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An article from a journal or magazine.</para>
    /// labels<para>Article</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#Article">http://purl.org/net/nknouf/ns/bibtex#Article</seealso>
    let Article = Prefixed_Name(bibtex, "Article") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name(s) of the author(s), in the format described in the LaTeX book.</para>
    /// labels<para>has author</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasAuthor">http://purl.org/net/nknouf/ns/bibtex#hasAuthor</seealso>
    let hasAuthor = Prefixed_Name(bibtex, "hasAuthor") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasLCCN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Library of Congress Call Number.</para>
    /// labels<para>has LCCN</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasLCCN">http://purl.org/net/nknouf/ns/bibtex#hasLCCN</seealso>
    let hasLCCN = Prefixed_Name(bibtex, "hasLCCN") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The month in which the work was published or, for an unpublished work, in which it was written. You should use the standard three-letter abbreviation, as described in Appendix B.1.3 of the LaTeX book.</para>
    /// labels<para>has month</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasMonth">http://purl.org/net/nknouf/ns/bibtex#hasMonth</seealso>
    let hasMonth = Prefixed_Name(bibtex, "hasMonth") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of a journal, magazine, technical report, or of a work in a series. An issue of a journal or magazine is usually identified by its volume and number; the organization that issues a technical report usually gives it a number; and sometimes books are given numbers in a named series.</para>
    /// labels<para>has number</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasNumber">http://purl.org/net/nknouf/ns/bibtex#hasNumber</seealso>
    let hasNumber = Prefixed_Name(bibtex, "hasNumber") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasPages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>One or more page numbers or range of numbers, such as 42-111 or 7,41,73-97 or 43+ (the `+' in this last example indicates pages following that don't form a simple range). To make it easier to maintain Scribe-compatible databases, the standard styles convert a single dash (as in 7-33) to the double dash used in TeX to denote number ranges (as in 7-33).</para>
    /// labels<para>has pages</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasPages">http://purl.org/net/nknouf/ns/bibtex#hasPages</seealso>
    let hasPages = Prefixed_Name(bibtex, "hasPages") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of a series or set of books. When citing an entire book, the the title field gives its title and an optional series field gives the name of a series or multi-volume set in which the book is published.</para>
    /// labels<para>has series</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasSeries">http://purl.org/net/nknouf/ns/bibtex#hasSeries</seealso>
    let hasSeries = Prefixed_Name(bibtex, "hasSeries") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The volume of a journal or multivolume book.</para>
    /// labels<para>has volume</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasVolume">http://purl.org/net/nknouf/ns/bibtex#hasVolume</seealso>
    let hasVolume = Prefixed_Name(bibtex, "hasVolume") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:Entry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Base class for all entries</para>
    /// labels<para>Entry</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#Entry">http://purl.org/net/nknouf/ns/bibtex#Entry</seealso>
    let Entry = Prefixed_Name(bibtex, "Entry") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:humanCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A generic human creator category, necessary in order to contain both author and editor.</para>
    /// labels<para>human creator</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#humanCreator">http://purl.org/net/nknouf/ns/bibtex#humanCreator</seealso>
    let humanCreator = Prefixed_Name(bibtex, "humanCreator") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasJournal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A journal name. Abbreviations are provided for many journals; see the Local Guide</para>
    /// labels<para>has journal</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasJournal">http://purl.org/net/nknouf/ns/bibtex#hasJournal</seealso>
    let hasJournal = Prefixed_Name(bibtex, "hasJournal") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:Book</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A book with an explicit publisher.</para>
    /// labels<para>Book</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#Book">http://purl.org/net/nknouf/ns/bibtex#Book</seealso>
    let Book = Prefixed_Name(bibtex, "Book") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The physical dimensions of a work.</para>
    /// labels<para>has size</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasSize">http://purl.org/net/nknouf/ns/bibtex#hasSize</seealso>
    let hasSize = Prefixed_Name(bibtex, "hasSize") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The year of publication or, for an unpublished work, the year it was written. Generally it should consist of four numerals, such as 1984, although the standard styles can handle any year whose last four nonpunctuation characters are numerals, such as '(about 1984)'.</para>
    /// labels<para>has year</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasYear">http://purl.org/net/nknouf/ns/bibtex#hasYear</seealso>
    let hasYear = Prefixed_Name(bibtex, "hasYear") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasISBN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The International Standard Book Number.</para>
    /// labels<para>has ISBN</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasISBN">http://purl.org/net/nknouf/ns/bibtex#hasISBN</seealso>
    let hasISBN = Prefixed_Name(bibtex, "hasISBN") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasISSN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The International Standard Serial Number. Used to identify a journal.</para>
    /// labels<para>has ISSN</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasISSN">http://purl.org/net/nknouf/ns/bibtex#hasISSN</seealso>
    let hasISSN = Prefixed_Name(bibtex, "hasISSN") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The key for a particular bibTeX entry.  Note that the rdf:ID for each Entry instance could be the bibTeX key as well, possibly making this property redundant.</para>
    /// labels<para>has key</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasKey">http://purl.org/net/nknouf/ns/bibtex#hasKey</seealso>
    let hasKey = Prefixed_Name(bibtex, "hasKey") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The language the document is in.</para>
    /// labels<para>has language</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasLanguage">http://purl.org/net/nknouf/ns/bibtex#hasLanguage</seealso>
    let hasLanguage = Prefixed_Name(bibtex, "hasLanguage") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasPublisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The publisher's name.</para>
    /// labels<para>has publisher</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasPublisher">http://purl.org/net/nknouf/ns/bibtex#hasPublisher</seealso>
    let hasPublisher = Prefixed_Name(bibtex, "hasPublisher") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:Booklet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A work that is printed and bound, but without a named publisher or sponsoring institution.</para>
    /// labels<para>Booklet</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#Booklet">http://purl.org/net/nknouf/ns/bibtex#Booklet</seealso>
    let Booklet = Prefixed_Name(bibtex, "Booklet") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:Inproceedings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An article in a conference proceedings.</para>
    /// labels<para>Inproceedings</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#Inproceedings">http://purl.org/net/nknouf/ns/bibtex#Inproceedings</seealso>
    let Inproceedings = Prefixed_Name(bibtex, "Inproceedings") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:Incollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A part of a book having its own title.</para>
    /// labels<para>Incollection</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#Incollection">http://purl.org/net/nknouf/ns/bibtex#Incollection</seealso>
    let Incollection = Prefixed_Name(bibtex, "Incollection") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:Conference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The same as INPROCEEDINGS, included for Scribe compatibility.</para>
    /// labels<para>Conference</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#Conference">http://purl.org/net/nknouf/ns/bibtex#Conference</seealso>
    let Conference = Prefixed_Name(bibtex, "Conference") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:Inbook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A part of a book, which may be a chapter (or section or whatever) and/or a range of pages. </para>
    /// labels<para>Inbook</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#Inbook">http://purl.org/net/nknouf/ns/bibtex#Inbook</seealso>
    let Inbook = Prefixed_Name(bibtex, "Inbook") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasBooktitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Title of a book, part of which is being cited. See the LaTeX book for how to type titles. For book entries, use the title field instead.</para>
    /// labels<para>has booktitle</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasBooktitle">http://purl.org/net/nknouf/ns/bibtex#hasBooktitle</seealso>
    let hasBooktitle = Prefixed_Name(bibtex, "hasBooktitle") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:Manual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Technical documentation.</para>
    /// labels<para>Manual</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#Manual">http://purl.org/net/nknouf/ns/bibtex#Manual</seealso>
    let Manual = Prefixed_Name(bibtex, "Manual") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:Mastersthesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Master's thesis.</para>
    /// labels<para>Mastersthesis</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#Mastersthesis">http://purl.org/net/nknouf/ns/bibtex#Mastersthesis</seealso>
    let Mastersthesis = Prefixed_Name(bibtex, "Mastersthesis") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of the school where a thesis was written.</para>
    /// labels<para>has school</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasSchool">http://purl.org/net/nknouf/ns/bibtex#hasSchool</seealso>
    let hasSchool = Prefixed_Name(bibtex, "hasSchool") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:Phdthesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A PhD thesis.</para>
    /// labels<para>Phdthesis</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#Phdthesis">http://purl.org/net/nknouf/ns/bibtex#Phdthesis</seealso>
    let Phdthesis = Prefixed_Name(bibtex, "Phdthesis") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:Proceedings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The proceedings of a conference.</para>
    /// labels<para>Proceedings</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#Proceedings">http://purl.org/net/nknouf/ns/bibtex#Proceedings</seealso>
    let Proceedings = Prefixed_Name(bibtex, "Proceedings") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:Techreport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A report published by a school or other institution, usually numbered within a series.</para>
    /// labels<para>Techreport</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#Techreport">http://purl.org/net/nknouf/ns/bibtex#Techreport</seealso>
    let Techreport = Prefixed_Name(bibtex, "Techreport") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The sponsoring institution of a technical report.</para>
    /// labels<para>has institution</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasInstitution">http://purl.org/net/nknouf/ns/bibtex#hasInstitution</seealso>
    let hasInstitution = Prefixed_Name(bibtex, "hasInstitution") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:Unpublished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A document having an author and title, but not formally published.</para>
    /// labels<para>Unpublished</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#Unpublished">http://purl.org/net/nknouf/ns/bibtex#Unpublished</seealso>
    let Unpublished = Prefixed_Name(bibtex, "Unpublished") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Any additional information that can help the reader. The first word should be capitalized.</para>
    /// labels<para>has note</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasNote">http://purl.org/net/nknouf/ns/bibtex#hasNote</seealso>
    let hasNote = Prefixed_Name(bibtex, "hasNote") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasAffiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The authors affiliation.</para>
    /// labels<para>has affiliation</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasAffiliation">http://purl.org/net/nknouf/ns/bibtex#hasAffiliation</seealso>
    let hasAffiliation = Prefixed_Name(bibtex, "hasAffiliation") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasAbstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An abstract of the work.</para>
    /// labels<para>has abstract</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasAbstract">http://purl.org/net/nknouf/ns/bibtex#hasAbstract</seealso>
    let hasAbstract = Prefixed_Name(bibtex, "hasAbstract") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasAnnotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An annotation. It is not used by the standard bibliography styles, but may be used by others that produce an annotated bibliography.</para>
    /// labels<para>has annotation</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasAnnotation">http://purl.org/net/nknouf/ns/bibtex#hasAnnotation</seealso>
    let hasAnnotation = Prefixed_Name(bibtex, "hasAnnotation") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Usually the address of the publisher or other type of institution. For major publishing houses, van Leunen recommends omitting the information entirely. For small publishers, on the other hand, you can help the reader by giving the complete address.</para>
    /// labels<para>has address</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasAddress">http://purl.org/net/nknouf/ns/bibtex#hasAddress</seealso>
    let hasAddress = Prefixed_Name(bibtex, "hasAddress") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasChapter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A chapter (or section or whatever) number.</para>
    /// labels<para>has chapter</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasChapter">http://purl.org/net/nknouf/ns/bibtex#hasChapter</seealso>
    let hasChapter = Prefixed_Name(bibtex, "hasChapter") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasContents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A Table of Contents.</para>
    /// labels<para>has contents</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasContents">http://purl.org/net/nknouf/ns/bibtex#hasContents</seealso>
    let hasContents = Prefixed_Name(bibtex, "hasContents") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasCrossref</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The database key of the entry being cross referenced.</para>
    /// labels<para>has crossref</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasCrossref">http://purl.org/net/nknouf/ns/bibtex#hasCrossref</seealso>
    let hasCrossref = Prefixed_Name(bibtex, "hasCrossref") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasEditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Name(s) of editor(s), typed as indicated in the LaTeX book. If there is also an author field, then the editor field gives the editor of the book or collection in which the reference appears.</para>
    /// labels<para>has editor</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasEditor">http://purl.org/net/nknouf/ns/bibtex#hasEditor</seealso>
    let hasEditor = Prefixed_Name(bibtex, "hasEditor") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasKeywords</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Key words used for searching or possibly for annotation.</para>
    /// labels<para>has keywords</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasKeywords">http://purl.org/net/nknouf/ns/bibtex#hasKeywords</seealso>
    let hasKeywords = Prefixed_Name(bibtex, "hasKeywords") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A location associated with the entry, such as the city in which a conference took place.</para>
    /// labels<para>has location</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasLocation">http://purl.org/net/nknouf/ns/bibtex#hasLocation</seealso>
    let hasLocation = Prefixed_Name(bibtex, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasMrnumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Mathematical Reviews number.</para>
    /// labels<para>has mrnumber</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasMrnumber">http://purl.org/net/nknouf/ns/bibtex#hasMrnumber</seealso>
    let hasMrnumber = Prefixed_Name(bibtex, "hasMrnumber") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The organization that sponsors a conference or that publishes a manual.</para>
    /// labels<para>has organization</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasOrganization">http://purl.org/net/nknouf/ns/bibtex#hasOrganization</seealso>
    let hasOrganization = Prefixed_Name(bibtex, "hasOrganization") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The price of the document.</para>
    /// labels<para>has price</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasPrice">http://purl.org/net/nknouf/ns/bibtex#hasPrice</seealso>
    let hasPrice = Prefixed_Name(bibtex, "hasPrice") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of a technical report--for example, "Research Note".</para>
    /// labels<para>has type</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasType">http://purl.org/net/nknouf/ns/bibtex#hasType</seealso>
    let hasType = Prefixed_Name(bibtex, "hasType") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The WWW Universal Resource Locator that points to the item being referenced. This often is used for technical reports to point to the ftp or web site where the postscript source of the report is located.</para>
    /// labels<para>has URL</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasURL">http://purl.org/net/nknouf/ns/bibtex#hasURL</seealso>
    let hasURL = Prefixed_Name(bibtex, "hasURL") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:howPublished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>How something strange has been published. The first word should be capitalized.</para>
    /// labels<para>how published</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#howPublished">http://purl.org/net/nknouf/ns/bibtex#howPublished</seealso>
    let howPublished = Prefixed_Name(bibtex, "howPublished") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasCopyright</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Copyright information.</para>
    /// labels<para>has copyright</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasCopyright">http://purl.org/net/nknouf/ns/bibtex#hasCopyright</seealso>
    let hasCopyright = Prefixed_Name(bibtex, "hasCopyright") |> PrefixedName
    /// <summary>
    ///   <para>bibtex:hasEdition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The edition of a book--for example, "Second". This should be an ordinal, and should have the first letter capitalized, as shown here; the standard styles convert to lower case when necessary.</para>
    /// labels<para>has edition</para></remarks>
    /// <seealso href="http://purl.org/net/nknouf/ns/bibtex#hasEdition">http://purl.org/net/nknouf/ns/bibtex#hasEdition</seealso>
    let hasEdition = Prefixed_Name(bibtex, "hasEdition") |> PrefixedName
