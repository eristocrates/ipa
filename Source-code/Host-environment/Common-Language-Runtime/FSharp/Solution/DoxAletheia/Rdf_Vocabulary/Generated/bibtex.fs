namespace http.purl.org.net.nknouf.ns.bibtex.hash

open DoxAletheia.Rdf_Vocabulary

module bibtex =
    let _namespace_name = "http://purl.org/net/nknouf/ns/bibtex#"
    /// <summary>
    /// An article from a journal or magazine.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Article"></see></summary>
    let Article = Namespaced_IRI.parse _namespace_name "Article" |> NamespacedName
    /// <summary>
    /// The name(s) of the author(s), in the format described in the LaTeX book.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasAuthor"></see></summary>
    let hasAuthor = Namespaced_IRI.parse _namespace_name "hasAuthor" |> NamespacedName
    /// <summary>
    /// The work's title, typed as explained in the LaTeX book.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasTitle"></see></summary>
    let hasTitle = Namespaced_IRI.parse _namespace_name "hasTitle" |> NamespacedName
    /// <summary>
    /// A journal name. Abbreviations are provided for many journals; see the Local Guide
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasJournal"></see></summary>
    let hasJournal = Namespaced_IRI.parse _namespace_name "hasJournal" |> NamespacedName
    /// <summary>
    /// The year of publication or, for an unpublished work, the year it was written. Generally it should consist of four numerals, such as 1984, although the standard styles can handle any year whose last four nonpunctuation characters are numerals, such as '(about 1984)'.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasYear"></see></summary>
    let hasYear = Namespaced_IRI.parse _namespace_name "hasYear" |> NamespacedName
    /// <summary>
    /// Base class for all entries
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Entry"></see></summary>
    let Entry = Namespaced_IRI.parse _namespace_name "Entry" |> NamespacedName
    /// <summary>
    /// A book with an explicit publisher.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Book"></see></summary>
    let Book = Namespaced_IRI.parse _namespace_name "Book" |> NamespacedName

    /// <summary>
    /// A generic human creator category, necessary in order to contain both author and editor.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#humanCreator"></see></summary>
    let humanCreator =
        Namespaced_IRI.parse _namespace_name "humanCreator" |> NamespacedName

    /// <summary>
    /// The publisher's name.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasPublisher"></see></summary>
    let hasPublisher =
        Namespaced_IRI.parse _namespace_name "hasPublisher" |> NamespacedName

    /// <summary>
    /// A work that is printed and bound, but without a named publisher or sponsoring institution.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Booklet"></see></summary>
    let Booklet = Namespaced_IRI.parse _namespace_name "Booklet" |> NamespacedName
    /// <summary>
    /// The same as INPROCEEDINGS, included for Scribe compatibility.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Conference"></see></summary>
    let Conference = Namespaced_IRI.parse _namespace_name "Conference" |> NamespacedName

    /// <summary>
    /// An article in a conference proceedings.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Inproceedings"></see></summary>
    let Inproceedings =
        Namespaced_IRI.parse _namespace_name "Inproceedings" |> NamespacedName

    /// <summary>
    /// A part of a book, which may be a chapter (or section or whatever) and/or a range of pages.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Inbook"></see></summary>
    let Inbook = Namespaced_IRI.parse _namespace_name "Inbook" |> NamespacedName

    /// <summary>
    /// A generic property to hold page and/or chapter data.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#pageChapterData"></see></summary>
    let pageChapterData =
        Namespaced_IRI.parse _namespace_name "pageChapterData" |> NamespacedName

    /// <summary>
    /// A part of a book having its own title.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Incollection"></see></summary>
    let Incollection =
        Namespaced_IRI.parse _namespace_name "Incollection" |> NamespacedName

    /// <summary>
    /// Title of a book, part of which is being cited. See the LaTeX book for how to type titles. For book entries, use the title field instead.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasBooktitle"></see></summary>
    let hasBooktitle =
        Namespaced_IRI.parse _namespace_name "hasBooktitle" |> NamespacedName

    /// <summary>
    /// Technical documentation.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Manual"></see></summary>
    let Manual = Namespaced_IRI.parse _namespace_name "Manual" |> NamespacedName

    /// <summary>
    /// A Master's thesis.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Mastersthesis"></see></summary>
    let Mastersthesis =
        Namespaced_IRI.parse _namespace_name "Mastersthesis" |> NamespacedName

    /// <summary>
    /// The name of the school where a thesis was written.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasSchool"></see></summary>
    let hasSchool = Namespaced_IRI.parse _namespace_name "hasSchool" |> NamespacedName
    /// <summary>
    /// Use this type when nothing else fits.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Misc"></see></summary>
    let Misc = Namespaced_IRI.parse _namespace_name "Misc" |> NamespacedName
    /// <summary>
    /// A PhD thesis.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Phdthesis"></see></summary>
    let Phdthesis = Namespaced_IRI.parse _namespace_name "Phdthesis" |> NamespacedName

    /// <summary>
    /// The proceedings of a conference.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Proceedings"></see></summary>
    let Proceedings =
        Namespaced_IRI.parse _namespace_name "Proceedings" |> NamespacedName

    /// <summary>
    /// A report published by a school or other institution, usually numbered within a series.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Techreport"></see></summary>
    let Techreport = Namespaced_IRI.parse _namespace_name "Techreport" |> NamespacedName

    /// <summary>
    /// The sponsoring institution of a technical report.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasInstitution"></see></summary>
    let hasInstitution =
        Namespaced_IRI.parse _namespace_name "hasInstitution" |> NamespacedName

    /// <summary>
    /// A document having an author and title, but not formally published.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#Unpublished"></see></summary>
    let Unpublished =
        Namespaced_IRI.parse _namespace_name "Unpublished" |> NamespacedName

    /// <summary>
    /// Any additional information that can help the reader. The first word should be capitalized.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasNote"></see></summary>
    let hasNote = Namespaced_IRI.parse _namespace_name "hasNote" |> NamespacedName

    /// <summary>
    /// An abstract of the work.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasAbstract"></see></summary>
    let hasAbstract =
        Namespaced_IRI.parse _namespace_name "hasAbstract" |> NamespacedName

    /// <summary>
    /// Usually the address of the publisher or other type of institution. For major publishing houses, van Leunen recommends omitting the information entirely. For small publishers, on the other hand, you can help the reader by giving the complete address.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasAddress"></see></summary>
    let hasAddress = Namespaced_IRI.parse _namespace_name "hasAddress" |> NamespacedName

    /// <summary>
    /// The authors affiliation.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasAffiliation"></see></summary>
    let hasAffiliation =
        Namespaced_IRI.parse _namespace_name "hasAffiliation" |> NamespacedName

    /// <summary>
    /// An annotation. It is not used by the standard bibliography styles, but may be used by others that produce an annotated bibliography.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasAnnotation"></see></summary>
    let hasAnnotation =
        Namespaced_IRI.parse _namespace_name "hasAnnotation" |> NamespacedName

    /// <summary>
    /// A chapter (or section or whatever) number.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasChapter"></see></summary>
    let hasChapter = Namespaced_IRI.parse _namespace_name "hasChapter" |> NamespacedName

    /// <summary>
    /// A Table of Contents.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasContents"></see></summary>
    let hasContents =
        Namespaced_IRI.parse _namespace_name "hasContents" |> NamespacedName

    /// <summary>
    /// Copyright information.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasCopyright"></see></summary>
    let hasCopyright =
        Namespaced_IRI.parse _namespace_name "hasCopyright" |> NamespacedName

    /// <summary>
    /// The database key of the entry being cross referenced.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasCrossref"></see></summary>
    let hasCrossref =
        Namespaced_IRI.parse _namespace_name "hasCrossref" |> NamespacedName

    /// <summary>
    /// The edition of a book--for example, "Second". This should be an ordinal, and should have the first letter capitalized, as shown here; the standard styles convert to lower case when necessary.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasEdition"></see></summary>
    let hasEdition = Namespaced_IRI.parse _namespace_name "hasEdition" |> NamespacedName
    /// <summary>
    /// Name(s) of editor(s), typed as indicated in the LaTeX book. If there is also an author field, then the editor field gives the editor of the book or collection in which the reference appears.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasEditor"></see></summary>
    let hasEditor = Namespaced_IRI.parse _namespace_name "hasEditor" |> NamespacedName
    /// <summary>
    /// The International Standard Book Number.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasISBN"></see></summary>
    let hasISBN = Namespaced_IRI.parse _namespace_name "hasISBN" |> NamespacedName
    /// <summary>
    /// The International Standard Serial Number. Used to identify a journal.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasISSN"></see></summary>
    let hasISSN = Namespaced_IRI.parse _namespace_name "hasISSN" |> NamespacedName
    /// <summary>
    /// The key for a particular bibTeX entry.  Note that the rdf:ID for each Entry instance could be the bibTeX key as well, possibly making this property redundant.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasKey"></see></summary>
    let hasKey = Namespaced_IRI.parse _namespace_name "hasKey" |> NamespacedName

    /// <summary>
    /// Key words used for searching or possibly for annotation.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasKeywords"></see></summary>
    let hasKeywords =
        Namespaced_IRI.parse _namespace_name "hasKeywords" |> NamespacedName

    /// <summary>
    /// The Library of Congress Call Number.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasLCCN"></see></summary>
    let hasLCCN = Namespaced_IRI.parse _namespace_name "hasLCCN" |> NamespacedName

    /// <summary>
    /// The language the document is in.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasLanguage"></see></summary>
    let hasLanguage =
        Namespaced_IRI.parse _namespace_name "hasLanguage" |> NamespacedName

    /// <summary>
    /// A location associated with the entry, such as the city in which a conference took place.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasLocation"></see></summary>
    let hasLocation =
        Namespaced_IRI.parse _namespace_name "hasLocation" |> NamespacedName

    /// <summary>
    /// The month in which the work was published or, for an unpublished work, in which it was written. You should use the standard three-letter abbreviation, as described in Appendix B.1.3 of the LaTeX book.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasMonth"></see></summary>
    let hasMonth = Namespaced_IRI.parse _namespace_name "hasMonth" |> NamespacedName

    /// <summary>
    /// The Mathematical Reviews number.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasMrnumber"></see></summary>
    let hasMrnumber =
        Namespaced_IRI.parse _namespace_name "hasMrnumber" |> NamespacedName

    /// <summary>
    /// The number of a journal, magazine, technical report, or of a work in a series. An issue of a journal or magazine is usually identified by its volume and number; the organization that issues a technical report usually gives it a number; and sometimes books are given numbers in a named series.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasNumber"></see></summary>
    let hasNumber = Namespaced_IRI.parse _namespace_name "hasNumber" |> NamespacedName

    /// <summary>
    /// The organization that sponsors a conference or that publishes a manual.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasOrganization"></see></summary>
    let hasOrganization =
        Namespaced_IRI.parse _namespace_name "hasOrganization" |> NamespacedName

    /// <summary>
    /// One or more page numbers or range of numbers, such as 42-111 or 7,41,73-97 or 43+ (the `+' in this last example indicates pages following that don't form a simple range). To make it easier to maintain Scribe-compatible databases, the standard styles convert a single dash (as in 7-33) to the double dash used in TeX to denote number ranges (as in 7-33).
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasPages"></see></summary>
    let hasPages = Namespaced_IRI.parse _namespace_name "hasPages" |> NamespacedName
    /// <summary>
    /// The price of the document.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasPrice"></see></summary>
    let hasPrice = Namespaced_IRI.parse _namespace_name "hasPrice" |> NamespacedName
    /// <summary>
    /// The name of a series or set of books. When citing an entire book, the the title field gives its title and an optional series field gives the name of a series or multi-volume set in which the book is published.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasSeries"></see></summary>
    let hasSeries = Namespaced_IRI.parse _namespace_name "hasSeries" |> NamespacedName
    /// <summary>
    /// The physical dimensions of a work.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasSize"></see></summary>
    let hasSize = Namespaced_IRI.parse _namespace_name "hasSize" |> NamespacedName
    /// <summary>
    /// The type of a technical report--for example, "Research Note".
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasType"></see></summary>
    let hasType = Namespaced_IRI.parse _namespace_name "hasType" |> NamespacedName
    /// <summary>
    /// The WWW Universal Resource Locator that points to the item being referenced. This often is used for technical reports to point to the ftp or web site where the postscript source of the report is located.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasURL"></see></summary>
    let hasURL = Namespaced_IRI.parse _namespace_name "hasURL" |> NamespacedName
    /// <summary>
    /// The volume of a journal or multivolume book.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#hasVolume"></see></summary>
    let hasVolume = Namespaced_IRI.parse _namespace_name "hasVolume" |> NamespacedName

    /// <summary>
    /// How something strange has been published. The first word should be capitalized.
    /// <see href="http://purl.org/net/nknouf/ns/bibtex#howPublished"></see></summary>
    let howPublished =
        Namespaced_IRI.parse _namespace_name "howPublished" |> NamespacedName
