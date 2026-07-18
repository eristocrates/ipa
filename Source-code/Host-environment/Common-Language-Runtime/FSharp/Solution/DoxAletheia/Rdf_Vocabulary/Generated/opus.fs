namespace http.lsdis.cs.uga.edu.projects.semdis.opus.hash

open DoxAletheia.Rdf_Vocabulary

module opus =
    let _namespace_name = "http://lsdis.cs.uga.edu/projects/semdis/opus#"
    /// <summary>
    /// An article from a journal or magazine.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Article"></see></summary>
    let Article = Namespaced_IRI.parse _namespace_name "Article" |> NamespacedName

    /// <summary>
    /// Individual documents and collections of documents such as series, journals, etc.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Publication"></see></summary>
    let Publication =
        Namespaced_IRI.parse _namespace_name "Publication" |> NamespacedName

    /// <summary>
    /// An article in the proceedings of a meeting, such as a conference, workhshop and symposium.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Article_in_Proceedings"></see></summary>
    let Article_in_Proceedings =
        Namespaced_IRI.parse _namespace_name "Article_in_Proceedings" |> NamespacedName

    /// <summary>
    /// A book with an explicit publisher.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Book"></see></summary>
    let Book = Namespaced_IRI.parse _namespace_name "Book" |> NamespacedName

    /// <summary>
    /// A part of a book, such as a chapter (or section/preface) and/or a range of pages.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Book_Chapter"></see></summary>
    let Book_Chapter =
        Namespaced_IRI.parse _namespace_name "Book_Chapter" |> NamespacedName

    /// <summary>
    /// A dissertation written to receive a PhD.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Doctoral_Dissertation"></see></summary>
    let Doctoral_Dissertation =
        Namespaced_IRI.parse _namespace_name "Doctoral_Dissertation" |> NamespacedName

    /// <summary>
    /// A treatise advancing a new point of view resulting from research; usually a requirement for an advanced academic degree.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Thesis"></see></summary>
    let Thesis = Namespaced_IRI.parse _namespace_name "Thesis" |> NamespacedName

    /// <summary>
    /// An edited book with an explicit publisher.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Edited_Book"></see></summary>
    let Edited_Book =
        Namespaced_IRI.parse _namespace_name "Edited_Book" |> NamespacedName

    /// <summary>
    /// An edited publication, that is, it has one or more editors (edited books, etc)
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Edited_Publication"></see></summary>
    let Edited_Publication =
        Namespaced_IRI.parse _namespace_name "Edited_Publication" |> NamespacedName

    /// <summary>
    /// A periodical presenting articles on a particular subject.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Journal"></see></summary>
    let Journal = Namespaced_IRI.parse _namespace_name "Journal" |> NamespacedName

    /// <summary>
    /// A periodical that appears at scheduled times.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Serial_Publication"></see></summary>
    let Serial_Publication =
        Namespaced_IRI.parse _namespace_name "Serial_Publication" |> NamespacedName

    /// <summary>
    /// A thesis written to receive a Master's degree.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Masters_Thesis"></see></summary>
    let Masters_Thesis =
        Namespaced_IRI.parse _namespace_name "Masters_Thesis" |> NamespacedName

    /// <summary>
    /// A written account of what transpired at a meeting.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Proceedings"></see></summary>
    let Proceedings =
        Namespaced_IRI.parse _namespace_name "Proceedings" |> NamespacedName

    /// <summary>
    /// An organization that, among other things, creates publishing periodicals, books or music.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Publishing_Organization"></see></summary>
    let Publishing_Organization =
        Namespaced_IRI.parse _namespace_name "Publishing_Organization" |> NamespacedName

    /// <summary>
    /// An organization where individuals receive education.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#School"></see></summary>
    let School = Namespaced_IRI.parse _namespace_name "School" |> NamespacedName
    /// <summary>
    /// Publication Series, such as LNCS, WEUR Workshops, etc. (at this time debatable whether this should be subclassof Publication)
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Series"></see></summary>
    let Series = Namespaced_IRI.parse _namespace_name "Series" |> NamespacedName
    /// <summary>
    /// An institution for higher learning with teaching and research facilities constituting a graduate school and professional schools that award master's degrees and doctorates and an undergraduate division that awards bachelor's degrees.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#University"></see></summary>
    let University = Namespaced_IRI.parse _namespace_name "University" |> NamespacedName
    /// <summary>
    /// A webpage, it is subclass of Document because we want to emphasize that the URL of the webpage is used the URI.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#Webpage"></see></summary>
    let Webpage = Namespaced_IRI.parse _namespace_name "Webpage" |> NamespacedName
    /// <summary>
    /// The abstract of a document
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#abstract"></see></summary>
    let abstract_ = Namespaced_IRI.parse _namespace_name "abstract" |> NamespacedName

    /// <summary>
    /// Indicates that a person is affiliated to a specific organization.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#affiliation"></see></summary>
    let affiliation =
        Namespaced_IRI.parse _namespace_name "affiliation" |> NamespacedName

    /// <summary>
    /// Indicates that a publication originates or is related to a specific Organization.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#at_organization"></see></summary>
    let at_organization =
        Namespaced_IRI.parse _namespace_name "at_organization" |> NamespacedName

    /// <summary>
    /// Indicates that a publication originates or is related to a specific University.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#at_university"></see></summary>
    let at_university =
        Namespaced_IRI.parse _namespace_name "at_university" |> NamespacedName

    /// <summary>
    /// Indicates that a publication is authored by a specific person(s).
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#author"></see></summary>
    let author = Namespaced_IRI.parse _namespace_name "author" |> NamespacedName
    /// <summary>
    /// An alternative Book Title or the Book Title where an article appears, such as title of proceedings.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#book_title"></see></summary>
    let book_title = Namespaced_IRI.parse _namespace_name "book_title" |> NamespacedName
    /// <summary>
    /// The CDROM location of a Publication, as used by the ACM SIGMOD Anthology.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#cdrom"></see></summary>
    let cdrom = Namespaced_IRI.parse _namespace_name "cdrom" |> NamespacedName
    /// <summary>
    /// The chapter number of a publication
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#chapter"></see></summary>
    let chapter = Namespaced_IRI.parse _namespace_name "chapter" |> NamespacedName
    /// <summary>
    /// Indicates that a book chapter belongs to a specific book. It is debateable whether this should be subclass of Collection.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#chapter_of"></see></summary>
    let chapter_of = Namespaced_IRI.parse _namespace_name "chapter_of" |> NamespacedName
    /// <summary>
    /// Indicates that a publication cites another publication.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#cites"></see></summary>
    let cites = Namespaced_IRI.parse _namespace_name "cites" |> NamespacedName
    /// <summary>
    /// Indicates that a person is co-author with another person
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#coauthor"></see></summary>
    let coauthor = Namespaced_IRI.parse _namespace_name "coauthor" |> NamespacedName
    /// <summary>
    /// Indicates that a person is co-editor with another person
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#coeditor"></see></summary>
    let coeditor = Namespaced_IRI.parse _namespace_name "coeditor" |> NamespacedName
    /// <summary>
    /// Indicates that a publication has a specific editor(s).
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#editor"></see></summary>
    let editor = Namespaced_IRI.parse _namespace_name "editor" |> NamespacedName
    /// <summary>
    /// The Electronic Edition of a publication
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#ee"></see></summary>
    let ee = Namespaced_IRI.parse _namespace_name "ee" |> NamespacedName

    /// <summary>
    /// The Electronic Edition of a Presentation of a publication
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#eepresentation"></see></summary>
    let eepresentation =
        Namespaced_IRI.parse _namespace_name "eepresentation" |> NamespacedName

    /// <summary>
    /// The month part of the date of a foaf:Document represented as xsd:gMonth value
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#gMonth"></see></summary>
    let gMonth = Namespaced_IRI.parse _namespace_name "gMonth" |> NamespacedName
    /// <summary>
    /// Indicates that a Publication is part of a Publication Series.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#in_series"></see></summary>
    let in_series = Namespaced_IRI.parse _namespace_name "in_series" |> NamespacedName

    /// <summary>
    /// Indicates that a publication is included in a specific proceedings publication.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#isIncludedIn"></see></summary>
    let isIncludedIn =
        Namespaced_IRI.parse _namespace_name "isIncludedIn" |> NamespacedName

    /// <summary>
    /// The ISBN of a publication.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#isbn"></see></summary>
    let isbn = Namespaced_IRI.parse _namespace_name "isbn" |> NamespacedName

    /// <summary>
    /// The name of a Journal, such as where an article appears
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#journal_name"></see></summary>
    let journal_name =
        Namespaced_IRI.parse _namespace_name "journal_name" |> NamespacedName

    /// <summary>
    /// The last modified date of a document.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#last_modified_date"></see></summary>
    let last_modified_date =
        Namespaced_IRI.parse _namespace_name "last_modified_date" |> NamespacedName

    /// <summary>
    /// The month part of the date of a foaf:Document.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#month"></see></summary>
    let month = Namespaced_IRI.parse _namespace_name "month" |> NamespacedName
    /// <summary>
    /// The Number part of citation of a publication.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#number"></see></summary>
    let number = Namespaced_IRI.parse _namespace_name "number" |> NamespacedName
    /// <summary>
    /// The Pages part of citation of a publication.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#pages"></see></summary>
    let pages = Namespaced_IRI.parse _namespace_name "pages" |> NamespacedName

    /// <summary>
    /// Indicates that a person has same affiliation than another person (this is not necessarily transitive)
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#sameAffiliation"></see></summary>
    let sameAffiliation =
        Namespaced_IRI.parse _namespace_name "sameAffiliation" |> NamespacedName

    /// <summary>
    /// The Volume part of citation of a publication.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#volume"></see></summary>
    let volume = Namespaced_IRI.parse _namespace_name "volume" |> NamespacedName
    /// <summary>
    /// The year part of the date of a foaf:Document.
    /// <see href="http://lsdis.cs.uga.edu/projects/semdis/opus#year"></see></summary>
    let year = Namespaced_IRI.parse _namespace_name "year" |> NamespacedName
