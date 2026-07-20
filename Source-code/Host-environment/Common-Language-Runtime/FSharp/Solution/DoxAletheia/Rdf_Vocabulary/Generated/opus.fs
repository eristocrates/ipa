namespace http.lsdis.cs.uga.edu.projects.semdis.opus.hash

open DoxAletheia

module opus =
    let _namespace_name = "http://lsdis.cs.uga.edu/projects/semdis/opus#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An article from a journal or magazine.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Article"></see></summary>
    let Article = _prefix "Article"
    /// <summary>
    /// Individual documents and collections of documents such as series, journals, etc.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Publication"></see></summary>
    let Publication = _prefix "Publication"
    /// <summary>
    /// An article in the proceedings of a meeting, such as a conference, workhshop and symposium.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Article_in_Proceedings"></see></summary>
    let Article_in_Proceedings = _prefix "Article_in_Proceedings"
    /// <summary>
    /// A book with an explicit publisher.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Book"></see></summary>
    let Book = _prefix "Book"
    /// <summary>
    /// A part of a book, such as a chapter (or section/preface) and/or a range of pages.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Book_Chapter"></see></summary>
    let Book_Chapter = _prefix "Book_Chapter"
    /// <summary>
    /// A dissertation written to receive a PhD.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Doctoral_Dissertation"></see></summary>
    let Doctoral_Dissertation = _prefix "Doctoral_Dissertation"
    /// <summary>
    /// A treatise advancing a new point of view resulting from research; usually a requirement for an advanced academic degree.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Thesis"></see></summary>
    let Thesis = _prefix "Thesis"
    /// <summary>
    /// An edited book with an explicit publisher.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Edited_Book"></see></summary>
    let Edited_Book = _prefix "Edited_Book"
    /// <summary>
    /// An edited publication, that is, it has one or more editors (edited books, etc)
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Edited_Publication"></see></summary>
    let Edited_Publication = _prefix "Edited_Publication"
    /// <summary>
    /// A periodical presenting articles on a particular subject.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Journal"></see></summary>
    let Journal = _prefix "Journal"
    /// <summary>
    /// A periodical that appears at scheduled times.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Serial_Publication"></see></summary>
    let Serial_Publication = _prefix "Serial_Publication"
    /// <summary>
    /// A thesis written to receive a Master's degree.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Masters_Thesis"></see></summary>
    let Masters_Thesis = _prefix "Masters_Thesis"
    /// <summary>
    /// A written account of what transpired at a meeting.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Proceedings"></see></summary>
    let Proceedings = _prefix "Proceedings"
    /// <summary>
    /// An organization that, among other things, creates publishing periodicals, books or music.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Publishing_Organization"></see></summary>
    let Publishing_Organization = _prefix "Publishing_Organization"
    /// <summary>
    /// An organization where individuals receive education.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#School"></see></summary>
    let School = _prefix "School"
    /// <summary>
    /// Publication Series, such as LNCS, WEUR Workshops, etc. (at this time debatable whether this should be subclassof Publication)
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Series"></see></summary>
    let Series = _prefix "Series"
    /// <summary>
    /// An institution for higher learning with teaching and research facilities constituting a graduate school and professional schools that award master's degrees and doctorates and an undergraduate division that awards bachelor's degrees.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#University"></see></summary>
    let University = _prefix "University"
    /// <summary>
    /// A webpage, it is subclass of Document because we want to emphasize that the URL of the webpage is used the URI.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Webpage"></see></summary>
    let Webpage = _prefix "Webpage"
    /// <summary>
    /// The abstract of a document
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#abstract"></see></summary>
    let abstract_ = _prefix "abstract"
    /// <summary>
    /// Indicates that a person is affiliated to a specific organization.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#affiliation"></see></summary>
    let affiliation = _prefix "affiliation"
    /// <summary>
    /// Indicates that a publication originates or is related to a specific Organization.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#at_organization"></see></summary>
    let at_organization = _prefix "at_organization"
    /// <summary>
    /// Indicates that a publication originates or is related to a specific University.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#at_university"></see></summary>
    let at_university = _prefix "at_university"
    /// <summary>
    /// Indicates that a publication is authored by a specific person(s).
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#author"></see></summary>
    let author = _prefix "author"
    /// <summary>
    /// An alternative Book Title or the Book Title where an article appears, such as title of proceedings.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#book_title"></see></summary>
    let book_title = _prefix "book_title"
    /// <summary>
    /// The CDROM location of a Publication, as used by the ACM SIGMOD Anthology.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#cdrom"></see></summary>
    let cdrom = _prefix "cdrom"
    /// <summary>
    /// The chapter number of a publication
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#chapter"></see></summary>
    let chapter = _prefix "chapter"
    /// <summary>
    /// Indicates that a book chapter belongs to a specific book. It is debateable whether this should be subclass of Collection.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#chapter_of"></see></summary>
    let chapter_of = _prefix "chapter_of"
    /// <summary>
    /// Indicates that a publication cites another publication.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#cites"></see></summary>
    let cites = _prefix "cites"
    /// <summary>
    /// Indicates that a person is co-author with another person
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#coauthor"></see></summary>
    let coauthor = _prefix "coauthor"
    /// <summary>
    /// Indicates that a person is co-editor with another person
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#coeditor"></see></summary>
    let coeditor = _prefix "coeditor"
    /// <summary>
    /// Indicates that a publication has a specific editor(s).
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#editor"></see></summary>
    let editor = _prefix "editor"
    /// <summary>
    /// The Electronic Edition of a publication
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#ee"></see></summary>
    let ee = _prefix "ee"
    /// <summary>
    /// The Electronic Edition of a Presentation of a publication
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#eepresentation"></see></summary>
    let eepresentation = _prefix "eepresentation"
    /// <summary>
    /// The month part of the date of a foaf:Document represented as xsd:gMonth value
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#gMonth"></see></summary>
    let gMonth = _prefix "gMonth"
    /// <summary>
    /// Indicates that a Publication is part of a Publication Series.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#in_series"></see></summary>
    let in_series = _prefix "in_series"
    /// <summary>
    /// Indicates that a publication is included in a specific proceedings publication.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#isIncludedIn"></see></summary>
    let isIncludedIn = _prefix "isIncludedIn"
    /// <summary>
    /// The ISBN of a publication.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#isbn"></see></summary>
    let isbn = _prefix "isbn"
    /// <summary>
    /// The name of a Journal, such as where an article appears
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#journal_name"></see></summary>
    let journal_name = _prefix "journal_name"
    /// <summary>
    /// The last modified date of a document.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#last_modified_date"></see></summary>
    let last_modified_date = _prefix "last_modified_date"
    /// <summary>
    /// The month part of the date of a foaf:Document.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#month"></see></summary>
    let month = _prefix "month"
    /// <summary>
    /// The Number part of citation of a publication.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#number"></see></summary>
    let number = _prefix "number"
    /// <summary>
    /// The Pages part of citation of a publication.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#pages"></see></summary>
    let pages = _prefix "pages"
    /// <summary>
    /// Indicates that a person has same affiliation than another person (this is not necessarily transitive)
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#sameAffiliation"></see></summary>
    let sameAffiliation = _prefix "sameAffiliation"
    /// <summary>
    /// The Volume part of citation of a publication.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#volume"></see></summary>
    let volume = _prefix "volume"
    /// <summary>
    /// The year part of the date of a foaf:Document.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#year"></see></summary>
    let year = _prefix "year"
