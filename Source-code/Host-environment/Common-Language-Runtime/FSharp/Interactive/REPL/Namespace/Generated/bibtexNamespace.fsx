#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module bibtex =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/net/nknouf/ns/bibtex#" "bibtex"

    /// <summary>
    ///   <para>rdfs:label : Article</para>
    ///   <para>rdfs:comment : An article from a journal or magazine.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#Article">bibtex:Article</a>
    /// </summary>
    let Article = _prefixId.prefix "Article"
    /// <summary>
    ///   <para>rdfs:label : Book</para>
    ///   <para>rdfs:comment : A book with an explicit publisher.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#Book">bibtex:Book</a>
    /// </summary>
    let Book = _prefixId.prefix "Book"
    /// <summary>
    ///   <para>rdfs:label : Booklet</para>
    ///   <para>rdfs:comment : A work that is printed and bound, but without a named publisher or sponsoring institution.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#Booklet">bibtex:Booklet</a>
    /// </summary>
    let Booklet = _prefixId.prefix "Booklet"
    /// <summary>
    ///   <para>rdfs:label : Conference</para>
    ///   <para>rdfs:comment : The same as INPROCEEDINGS, included for Scribe compatibility.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#Conference">bibtex:Conference</a>
    /// </summary>
    let Conference = _prefixId.prefix "Conference"
    /// <summary>
    ///   <para>rdfs:label : Entry</para>
    ///   <para>rdfs:comment : Base class for all entries</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#Entry">bibtex:Entry</a>
    /// </summary>
    let Entry = _prefixId.prefix "Entry"
    /// <summary>
    ///   <para>rdfs:label : Inbook</para>
    ///   <para>rdfs:comment : A part of a book, which may be a chapter (or section or whatever) and/or a range of pages. </para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#Inbook">bibtex:Inbook</a>
    /// </summary>
    let Inbook = _prefixId.prefix "Inbook"
    /// <summary>
    ///   <para>rdfs:label : Incollection</para>
    ///   <para>rdfs:comment : A part of a book having its own title.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#Incollection">bibtex:Incollection</a>
    /// </summary>
    let Incollection = _prefixId.prefix "Incollection"
    /// <summary>
    ///   <para>rdfs:label : Inproceedings</para>
    ///   <para>rdfs:comment : An article in a conference proceedings.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#Inproceedings">bibtex:Inproceedings</a>
    /// </summary>
    let Inproceedings = _prefixId.prefix "Inproceedings"
    /// <summary>
    ///   <para>rdfs:label : Manual</para>
    ///   <para>rdfs:comment : Technical documentation.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#Manual">bibtex:Manual</a>
    /// </summary>
    let Manual = _prefixId.prefix "Manual"
    /// <summary>
    ///   <para>rdfs:label : Mastersthesis</para>
    ///   <para>rdfs:comment : A Master's thesis.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#Mastersthesis">bibtex:Mastersthesis</a>
    /// </summary>
    let Mastersthesis = _prefixId.prefix "Mastersthesis"
    /// <summary>
    ///   <para>rdfs:label : Misc</para>
    ///   <para>rdfs:comment : Use this type when nothing else fits.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#Misc">bibtex:Misc</a>
    /// </summary>
    let Misc = _prefixId.prefix "Misc"
    /// <summary>
    ///   <para>rdfs:label : Phdthesis</para>
    ///   <para>rdfs:comment : A PhD thesis.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#Phdthesis">bibtex:Phdthesis</a>
    /// </summary>
    let Phdthesis = _prefixId.prefix "Phdthesis"
    /// <summary>
    ///   <para>rdfs:label : Proceedings</para>
    ///   <para>rdfs:comment : The proceedings of a conference.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#Proceedings">bibtex:Proceedings</a>
    /// </summary>
    let Proceedings = _prefixId.prefix "Proceedings"
    /// <summary>
    ///   <para>rdfs:label : Techreport</para>
    ///   <para>rdfs:comment : A report published by a school or other institution, usually numbered within a series.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#Techreport">bibtex:Techreport</a>
    /// </summary>
    let Techreport = _prefixId.prefix "Techreport"
    /// <summary>
    ///   <para>rdfs:label : Unpublished</para>
    ///   <para>rdfs:comment : A document having an author and title, but not formally published.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#Unpublished">bibtex:Unpublished</a>
    /// </summary>
    let Unpublished = _prefixId.prefix "Unpublished"
    /// <summary>
    ///   <para>rdfs:label : has abstract</para>
    ///   <para>rdfs:comment : An abstract of the work.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasAbstract">bibtex:hasAbstract</a>
    /// </summary>
    let hasAbstract = _prefixId.prefix "hasAbstract"
    /// <summary>
    ///   <para>rdfs:label : has address</para>
    ///   <para>rdfs:comment : Usually the address of the publisher or other type of institution. For major publishing houses, van Leunen recommends omitting the information entirely. For small publishers, on the other hand, you can help the reader by giving the complete address.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasAddress">bibtex:hasAddress</a>
    /// </summary>
    let hasAddress = _prefixId.prefix "hasAddress"
    /// <summary>
    ///   <para>rdfs:label : has affiliation</para>
    ///   <para>rdfs:comment : The authors affiliation.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasAffiliation">bibtex:hasAffiliation</a>
    /// </summary>
    let hasAffiliation = _prefixId.prefix "hasAffiliation"
    /// <summary>
    ///   <para>rdfs:label : has annotation</para>
    ///   <para>rdfs:comment : An annotation. It is not used by the standard bibliography styles, but may be used by others that produce an annotated bibliography.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasAnnotation">bibtex:hasAnnotation</a>
    /// </summary>
    let hasAnnotation = _prefixId.prefix "hasAnnotation"
    /// <summary>
    ///   <para>dce:description : This is tricky due to the fact that order is not (generally) preserved in RDF documents.  The problem arises when you want to have an author list where the order is _extremely_ important.  How shall we do that?  Perhaps we want to define "hasPrimaryAuthor", "hasSecondaryAuthor", "hasTertiaryAuthor", and "hasRemainingAuthors", or something of that sort.  This will be have to given more thought.^^xsd:string</para>
    ///   <para>rdfs:label : has author</para>
    ///   <para>rdfs:comment : The name(s) of the author(s), in the format described in the LaTeX book.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasAuthor">bibtex:hasAuthor</a>
    /// </summary>
    let hasAuthor = _prefixId.prefix "hasAuthor"
    /// <summary>
    ///   <para>rdfs:label : has booktitle</para>
    ///   <para>rdfs:comment : Title of a book, part of which is being cited. See the LaTeX book for how to type titles. For book entries, use the title field instead.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasBooktitle">bibtex:hasBooktitle</a>
    /// </summary>
    let hasBooktitle = _prefixId.prefix "hasBooktitle"
    /// <summary>
    ///   <para>rdfs:label : has chapter</para>
    ///   <para>rdfs:comment : A chapter (or section or whatever) number.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasChapter">bibtex:hasChapter</a>
    /// </summary>
    let hasChapter = _prefixId.prefix "hasChapter"
    /// <summary>
    ///   <para>rdfs:label : has contents</para>
    ///   <para>rdfs:comment : A Table of Contents.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasContents">bibtex:hasContents</a>
    /// </summary>
    let hasContents = _prefixId.prefix "hasContents"
    /// <summary>
    ///   <para>rdfs:label : has copyright</para>
    ///   <para>rdfs:comment : Copyright information.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasCopyright">bibtex:hasCopyright</a>
    /// </summary>
    let hasCopyright = _prefixId.prefix "hasCopyright"
    /// <summary>
    ///   <para>rdfs:label : has crossref</para>
    ///   <para>rdfs:comment : The database key of the entry being cross referenced.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasCrossref">bibtex:hasCrossref</a>
    /// </summary>
    let hasCrossref = _prefixId.prefix "hasCrossref"
    /// <summary>
    ///   <para>rdfs:label : has edition</para>
    ///   <para>rdfs:comment : The edition of a book--for example, "Second". This should be an ordinal, and should have the first letter capitalized, as shown here; the standard styles convert to lower case when necessary.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasEdition">bibtex:hasEdition</a>
    /// </summary>
    let hasEdition = _prefixId.prefix "hasEdition"
    /// <summary>
    ///   <para>dce:description : Again, the same issues that arose with the "hasAuthor" property apply here.^^xsd:string</para>
    ///   <para>rdfs:label : has editor</para>
    ///   <para>rdfs:comment : Name(s) of editor(s), typed as indicated in the LaTeX book. If there is also an author field, then the editor field gives the editor of the book or collection in which the reference appears.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasEditor">bibtex:hasEditor</a>
    /// </summary>
    let hasEditor = _prefixId.prefix "hasEditor"
    /// <summary>
    ///   <para>rdfs:label : has ISBN</para>
    ///   <para>rdfs:comment : The International Standard Book Number.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasISBN">bibtex:hasISBN</a>
    /// </summary>
    let hasISBN = _prefixId.prefix "hasISBN"
    /// <summary>
    ///   <para>rdfs:label : has ISSN</para>
    ///   <para>rdfs:comment : The International Standard Serial Number. Used to identify a journal.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasISSN">bibtex:hasISSN</a>
    /// </summary>
    let hasISSN = _prefixId.prefix "hasISSN"
    /// <summary>
    ///   <para>dce:description : This could be an object property that refers to an external set of institution instances.^^xsd:string</para>
    ///   <para>rdfs:label : has institution</para>
    ///   <para>rdfs:comment : The sponsoring institution of a technical report.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasInstitution">bibtex:hasInstitution</a>
    /// </summary>
    let hasInstitution = _prefixId.prefix "hasInstitution"
    /// <summary>
    ///   <para>dce:description : This could optionally be an object property, whereby the range would refer to an external set of journal instances, thus providing standardized abbreviations for different bibliographic styles.^^xsd:string</para>
    ///   <para>rdfs:label : has journal</para>
    ///   <para>rdfs:comment : A journal name. Abbreviations are provided for many journals; see the Local Guide</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasJournal">bibtex:hasJournal</a>
    /// </summary>
    let hasJournal = _prefixId.prefix "hasJournal"
    /// <summary>
    ///   <para>rdfs:label : has key</para>
    ///   <para>rdfs:comment : The key for a particular bibTeX entry.  Note that the rdf:ID for each Entry instance could be the bibTeX key as well, possibly making this property redundant.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasKey">bibtex:hasKey</a>
    /// </summary>
    let hasKey = _prefixId.prefix "hasKey"
    /// <summary>
    ///   <para>rdfs:label : has keywords</para>
    ///   <para>rdfs:comment : Key words used for searching or possibly for annotation.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasKeywords">bibtex:hasKeywords</a>
    /// </summary>
    let hasKeywords = _prefixId.prefix "hasKeywords"
    /// <summary>
    ///   <para>rdfs:label : has LCCN</para>
    ///   <para>rdfs:comment : The Library of Congress Call Number.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasLCCN">bibtex:hasLCCN</a>
    /// </summary>
    let hasLCCN = _prefixId.prefix "hasLCCN"
    /// <summary>
    ///   <para>rdfs:label : has language</para>
    ///   <para>rdfs:comment : The language the document is in.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasLanguage">bibtex:hasLanguage</a>
    /// </summary>
    let hasLanguage = _prefixId.prefix "hasLanguage"
    /// <summary>
    ///   <para>rdfs:label : has location</para>
    ///   <para>rdfs:comment : A location associated with the entry, such as the city in which a conference took place.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasLocation">bibtex:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    /// <summary>
    ///   <para>rdfs:label : has month</para>
    ///   <para>rdfs:comment : The month in which the work was published or, for an unpublished work, in which it was written. You should use the standard three-letter abbreviation, as described in Appendix B.1.3 of the LaTeX book.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasMonth">bibtex:hasMonth</a>
    /// </summary>
    let hasMonth = _prefixId.prefix "hasMonth"
    /// <summary>
    ///   <para>rdfs:label : has mrnumber</para>
    ///   <para>rdfs:comment : The Mathematical Reviews number.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasMrnumber">bibtex:hasMrnumber</a>
    /// </summary>
    let hasMrnumber = _prefixId.prefix "hasMrnumber"
    /// <summary>
    ///   <para>rdfs:label : has note</para>
    ///   <para>rdfs:comment : Any additional information that can help the reader. The first word should be capitalized.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasNote">bibtex:hasNote</a>
    /// </summary>
    let hasNote = _prefixId.prefix "hasNote"
    /// <summary>
    ///   <para>rdfs:label : has number</para>
    ///   <para>rdfs:comment : The number of a journal, magazine, technical report, or of a work in a series. An issue of a journal or magazine is usually identified by its volume and number; the organization that issues a technical report usually gives it a number; and sometimes books are given numbers in a named series.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasNumber">bibtex:hasNumber</a>
    /// </summary>
    let hasNumber = _prefixId.prefix "hasNumber"
    /// <summary>
    ///   <para>rdfs:label : has organization</para>
    ///   <para>rdfs:comment : The organization that sponsors a conference or that publishes a manual.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasOrganization">bibtex:hasOrganization</a>
    /// </summary>
    let hasOrganization = _prefixId.prefix "hasOrganization"
    /// <summary>
    ///   <para>rdfs:label : has pages</para>
    ///   <para>rdfs:comment : One or more page numbers or range of numbers, such as 42-111 or 7,41,73-97 or 43+ (the `+' in this last example indicates pages following that don't form a simple range). To make it easier to maintain Scribe-compatible databases, the standard styles convert a single dash (as in 7-33) to the double dash used in TeX to denote number ranges (as in 7-33).</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasPages">bibtex:hasPages</a>
    /// </summary>
    let hasPages = _prefixId.prefix "hasPages"
    /// <summary>
    ///   <para>rdfs:label : has price</para>
    ///   <para>rdfs:comment : The price of the document.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasPrice">bibtex:hasPrice</a>
    /// </summary>
    let hasPrice = _prefixId.prefix "hasPrice"
    /// <summary>
    ///   <para>dce:description : This is a case where an ObjectProperty might be a better choice, where the range is some set of publisher names defined in another ontology.  That would allow all of the metadata for the publisher to be incorporated as needed.^^xsd:string</para>
    ///   <para>rdfs:label : has publisher</para>
    ///   <para>rdfs:comment : The publisher's name.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasPublisher">bibtex:hasPublisher</a>
    /// </summary>
    let hasPublisher = _prefixId.prefix "hasPublisher"
    /// <summary>
    ///   <para>dce:description : As with "hasPublisher", this could be an ObjectProperty that refers to an external set of school instances.^^xsd:string</para>
    ///   <para>rdfs:label : has school</para>
    ///   <para>rdfs:comment : The name of the school where a thesis was written.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasSchool">bibtex:hasSchool</a>
    /// </summary>
    let hasSchool = _prefixId.prefix "hasSchool"
    /// <summary>
    ///   <para>rdfs:label : has series</para>
    ///   <para>rdfs:comment : The name of a series or set of books. When citing an entire book, the the title field gives its title and an optional series field gives the name of a series or multi-volume set in which the book is published.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasSeries">bibtex:hasSeries</a>
    /// </summary>
    let hasSeries = _prefixId.prefix "hasSeries"
    /// <summary>
    ///   <para>rdfs:label : has size</para>
    ///   <para>rdfs:comment : The physical dimensions of a work.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasSize">bibtex:hasSize</a>
    /// </summary>
    let hasSize = _prefixId.prefix "hasSize"
    /// <summary>
    ///   <para>rdfs:label : has title</para>
    ///   <para>rdfs:comment : The work's title, typed as explained in the LaTeX book.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasTitle">bibtex:hasTitle</a>
    /// </summary>
    let hasTitle = _prefixId.prefix "hasTitle"
    /// <summary>
    ///   <para>rdfs:label : has type</para>
    ///   <para>rdfs:comment : The type of a technical report--for example, "Research Note".</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasType">bibtex:hasType</a>
    /// </summary>
    let hasType = _prefixId.prefix "hasType"
    /// <summary>
    ///   <para>rdfs:label : has URL</para>
    ///   <para>rdfs:comment : The WWW Universal Resource Locator that points to the item being referenced. This often is used for technical reports to point to the ftp or web site where the postscript source of the report is located.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasURL">bibtex:hasURL</a>
    /// </summary>
    let hasURL = _prefixId.prefix "hasURL"
    /// <summary>
    ///   <para>rdfs:label : has volume</para>
    ///   <para>rdfs:comment : The volume of a journal or multivolume book.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasVolume">bibtex:hasVolume</a>
    /// </summary>
    let hasVolume = _prefixId.prefix "hasVolume"
    /// <summary>
    ///   <para>rdfs:label : has year</para>
    ///   <para>rdfs:comment : The year of publication or, for an unpublished work, the year it was written. Generally it should consist of four numerals, such as 1984, although the standard styles can handle any year whose last four nonpunctuation characters are numerals, such as '(about 1984)'.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#hasYear">bibtex:hasYear</a>
    /// </summary>
    let hasYear = _prefixId.prefix "hasYear"
    /// <summary>
    ///   <para>rdfs:label : how published</para>
    ///   <para>rdfs:comment : How something strange has been published. The first word should be capitalized.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#howPublished">bibtex:howPublished</a>
    /// </summary>
    let howPublished = _prefixId.prefix "howPublished"
    /// <summary>
    ///   <para>rdfs:label : human creator</para>
    ///   <para>rdfs:comment : A generic human creator category, necessary in order to contain both author and editor.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#humanCreator">bibtex:humanCreator</a>
    /// </summary>
    let humanCreator = _prefixId.prefix "humanCreator"
    /// <summary>
    ///   <para>rdfs:label : page and/or chapter data</para>
    ///   <para>rdfs:comment : A generic property to hold page and/or chapter data.</para>
    ///   <a href="http://purl.org/net/nknouf/ns/bibtex#pageChapterData">bibtex:pageChapterData</a>
    /// </summary>
    let pageChapterData = _prefixId.prefix "pageChapterData"
