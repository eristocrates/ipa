namespace http.purl.org.net.nknouf.ns.bibtex.hash

open DoxAletheia

module bibtex =
    let _namespace_name = "http://purl.org/net/nknouf/ns/bibtex#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An article from a journal or magazine.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Article"></see></summary>
    let Article = _prefix "Article"
    /// <summary>
    /// The name(s) of the author(s), in the format described in the LaTeX book.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasAuthor"></see></summary>
    let hasAuthor = _prefix "hasAuthor"
    /// <summary>
    /// The work's title, typed as explained in the LaTeX book.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasTitle"></see></summary>
    let hasTitle = _prefix "hasTitle"
    /// <summary>
    /// A journal name. Abbreviations are provided for many journals; see the Local Guide
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasJournal"></see></summary>
    let hasJournal = _prefix "hasJournal"
    /// <summary>
    /// The year of publication or, for an unpublished work, the year it was written. Generally it should consist of four numerals, such as 1984, although the standard styles can handle any year whose last four nonpunctuation characters are numerals, such as '(about 1984)'.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasYear"></see></summary>
    let hasYear = _prefix "hasYear"
    /// <summary>
    /// Base class for all entries
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Entry"></see></summary>
    let Entry = _prefix "Entry"
    /// <summary>
    /// A book with an explicit publisher.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Book"></see></summary>
    let Book = _prefix "Book"
    /// <summary>
    /// A generic human creator category, necessary in order to contain both author and editor.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#humanCreator"></see></summary>
    let humanCreator = _prefix "humanCreator"
    /// <summary>
    /// The publisher's name.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasPublisher"></see></summary>
    let hasPublisher = _prefix "hasPublisher"
    /// <summary>
    /// A work that is printed and bound, but without a named publisher or sponsoring institution.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Booklet"></see></summary>
    let Booklet = _prefix "Booklet"
    /// <summary>
    /// The same as INPROCEEDINGS, included for Scribe compatibility.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Conference"></see></summary>
    let Conference = _prefix "Conference"
    /// <summary>
    /// An article in a conference proceedings.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Inproceedings"></see></summary>
    let Inproceedings = _prefix "Inproceedings"
    /// <summary>
    /// A part of a book, which may be a chapter (or section or whatever) and/or a range of pages.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Inbook"></see></summary>
    let Inbook = _prefix "Inbook"
    /// <summary>
    /// A generic property to hold page and/or chapter data.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#pageChapterData"></see></summary>
    let pageChapterData = _prefix "pageChapterData"
    /// <summary>
    /// A part of a book having its own title.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Incollection"></see></summary>
    let Incollection = _prefix "Incollection"
    /// <summary>
    /// Title of a book, part of which is being cited. See the LaTeX book for how to type titles. For book entries, use the title field instead.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasBooktitle"></see></summary>
    let hasBooktitle = _prefix "hasBooktitle"
    /// <summary>
    /// Technical documentation.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Manual"></see></summary>
    let Manual = _prefix "Manual"
    /// <summary>
    /// A Master's thesis.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Mastersthesis"></see></summary>
    let Mastersthesis = _prefix "Mastersthesis"
    /// <summary>
    /// The name of the school where a thesis was written.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasSchool"></see></summary>
    let hasSchool = _prefix "hasSchool"
    /// <summary>
    /// Use this type when nothing else fits.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Misc"></see></summary>
    let Misc = _prefix "Misc"
    /// <summary>
    /// A PhD thesis.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Phdthesis"></see></summary>
    let Phdthesis = _prefix "Phdthesis"
    /// <summary>
    /// The proceedings of a conference.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Proceedings"></see></summary>
    let Proceedings = _prefix "Proceedings"
    /// <summary>
    /// A report published by a school or other institution, usually numbered within a series.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Techreport"></see></summary>
    let Techreport = _prefix "Techreport"
    /// <summary>
    /// The sponsoring institution of a technical report.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasInstitution"></see></summary>
    let hasInstitution = _prefix "hasInstitution"
    /// <summary>
    /// A document having an author and title, but not formally published.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Unpublished"></see></summary>
    let Unpublished = _prefix "Unpublished"
    /// <summary>
    /// Any additional information that can help the reader. The first word should be capitalized.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasNote"></see></summary>
    let hasNote = _prefix "hasNote"
    /// <summary>
    /// An abstract of the work.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasAbstract"></see></summary>
    let hasAbstract = _prefix "hasAbstract"
    /// <summary>
    /// Usually the address of the publisher or other type of institution. For major publishing houses, van Leunen recommends omitting the information entirely. For small publishers, on the other hand, you can help the reader by giving the complete address.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasAddress"></see></summary>
    let hasAddress = _prefix "hasAddress"
    /// <summary>
    /// The authors affiliation.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasAffiliation"></see></summary>
    let hasAffiliation = _prefix "hasAffiliation"
    /// <summary>
    /// An annotation. It is not used by the standard bibliography styles, but may be used by others that produce an annotated bibliography.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasAnnotation"></see></summary>
    let hasAnnotation = _prefix "hasAnnotation"
    /// <summary>
    /// A chapter (or section or whatever) number.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasChapter"></see></summary>
    let hasChapter = _prefix "hasChapter"
    /// <summary>
    /// A Table of Contents.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasContents"></see></summary>
    let hasContents = _prefix "hasContents"
    /// <summary>
    /// Copyright information.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasCopyright"></see></summary>
    let hasCopyright = _prefix "hasCopyright"
    /// <summary>
    /// The database key of the entry being cross referenced.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasCrossref"></see></summary>
    let hasCrossref = _prefix "hasCrossref"
    /// <summary>
    /// The edition of a book--for example, "Second". This should be an ordinal, and should have the first letter capitalized, as shown here; the standard styles convert to lower case when necessary.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasEdition"></see></summary>
    let hasEdition = _prefix "hasEdition"
    /// <summary>
    /// Name(s) of editor(s), typed as indicated in the LaTeX book. If there is also an author field, then the editor field gives the editor of the book or collection in which the reference appears.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasEditor"></see></summary>
    let hasEditor = _prefix "hasEditor"
    /// <summary>
    /// The International Standard Book Number.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasISBN"></see></summary>
    let hasISBN = _prefix "hasISBN"
    /// <summary>
    /// The International Standard Serial Number. Used to identify a journal.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasISSN"></see></summary>
    let hasISSN = _prefix "hasISSN"
    /// <summary>
    /// The key for a particular bibTeX entry.  Note that the rdf:ID for each Entry instance could be the bibTeX key as well, possibly making this property redundant.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasKey"></see></summary>
    let hasKey = _prefix "hasKey"
    /// <summary>
    /// Key words used for searching or possibly for annotation.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasKeywords"></see></summary>
    let hasKeywords = _prefix "hasKeywords"
    /// <summary>
    /// The Library of Congress Call Number.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasLCCN"></see></summary>
    let hasLCCN = _prefix "hasLCCN"
    /// <summary>
    /// The language the document is in.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasLanguage"></see></summary>
    let hasLanguage = _prefix "hasLanguage"
    /// <summary>
    /// A location associated with the entry, such as the city in which a conference took place.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasLocation"></see></summary>
    let hasLocation = _prefix "hasLocation"
    /// <summary>
    /// The month in which the work was published or, for an unpublished work, in which it was written. You should use the standard three-letter abbreviation, as described in Appendix B.1.3 of the LaTeX book.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasMonth"></see></summary>
    let hasMonth = _prefix "hasMonth"
    /// <summary>
    /// The Mathematical Reviews number.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasMrnumber"></see></summary>
    let hasMrnumber = _prefix "hasMrnumber"
    /// <summary>
    /// The number of a journal, magazine, technical report, or of a work in a series. An issue of a journal or magazine is usually identified by its volume and number; the organization that issues a technical report usually gives it a number; and sometimes books are given numbers in a named series.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasNumber"></see></summary>
    let hasNumber = _prefix "hasNumber"
    /// <summary>
    /// The organization that sponsors a conference or that publishes a manual.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasOrganization"></see></summary>
    let hasOrganization = _prefix "hasOrganization"
    /// <summary>
    /// One or more page numbers or range of numbers, such as 42-111 or 7,41,73-97 or 43+ (the `+' in this last example indicates pages following that don't form a simple range). To make it easier to maintain Scribe-compatible databases, the standard styles convert a single dash (as in 7-33) to the double dash used in TeX to denote number ranges (as in 7-33).
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasPages"></see></summary>
    let hasPages = _prefix "hasPages"
    /// <summary>
    /// The price of the document.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasPrice"></see></summary>
    let hasPrice = _prefix "hasPrice"
    /// <summary>
    /// The name of a series or set of books. When citing an entire book, the the title field gives its title and an optional series field gives the name of a series or multi-volume set in which the book is published.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasSeries"></see></summary>
    let hasSeries = _prefix "hasSeries"
    /// <summary>
    /// The physical dimensions of a work.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasSize"></see></summary>
    let hasSize = _prefix "hasSize"
    /// <summary>
    /// The type of a technical report--for example, "Research Note".
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasType"></see></summary>
    let hasType = _prefix "hasType"
    /// <summary>
    /// The WWW Universal Resource Locator that points to the item being referenced. This often is used for technical reports to point to the ftp or web site where the postscript source of the report is located.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasURL"></see></summary>
    let hasURL = _prefix "hasURL"
    /// <summary>
    /// The volume of a journal or multivolume book.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasVolume"></see></summary>
    let hasVolume = _prefix "hasVolume"
    /// <summary>
    /// How something strange has been published. The first word should be capitalized.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#howPublished"></see></summary>
    let howPublished = _prefix "howPublished"
