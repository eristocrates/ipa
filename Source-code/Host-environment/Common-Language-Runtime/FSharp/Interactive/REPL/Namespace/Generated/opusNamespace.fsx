#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module opus =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://lsdis.cs.uga.edu/projects/semdis/opus#" "opus"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Article^^xsd:string</para>
    ///   <para>rdfs:comment : An article from a journal or magazine.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#Article">opus:Article</a>
    /// </summary>
    let Article = _prefixId.prefix "Article"
    /// <summary>
    ///   <para>rdfs:label : Article in Proceedings^^xsd:string</para>
    ///   <para>rdfs:comment : An article in the proceedings of a meeting, such as a conference, workhshop and symposium.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#Article_in_Proceedings">opus:Article_in_Proceedings</a>
    /// </summary>
    let Article_in_Proceedings = _prefixId.prefix "Article_in_Proceedings"
    /// <summary>
    ///   <para>rdfs:label : Book^^xsd:string</para>
    ///   <para>rdfs:comment : A book with an explicit publisher.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#Book">opus:Book</a>
    /// </summary>
    let Book = _prefixId.prefix "Book"
    /// <summary>
    ///   <para>rdfs:label : Book Chapter^^xsd:string</para>
    ///   <para>rdfs:comment : A part of a book, such as a chapter (or section/preface) and/or a range of pages.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#Book_Chapter">opus:Book_Chapter</a>
    /// </summary>
    let Book_Chapter = _prefixId.prefix "Book_Chapter"
    /// <summary>
    ///   <para>rdfs:label : Doctoral Dissertation^^xsd:string</para>
    ///   <para>rdfs:comment : A dissertation written to receive a PhD.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#Doctoral_Dissertation">opus:Doctoral_Dissertation</a>
    /// </summary>
    let Doctoral_Dissertation = _prefixId.prefix "Doctoral_Dissertation"
    /// <summary>
    ///   <para>rdfs:label : Edited Book^^xsd:string</para>
    ///   <para>rdfs:comment : An edited book with an explicit publisher.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#Edited_Book">opus:Edited_Book</a>
    /// </summary>
    let Edited_Book = _prefixId.prefix "Edited_Book"
    /// <summary>
    ///   <para>rdfs:label : Edited Publication^^xsd:string</para>
    ///   <para>rdfs:comment : An edited publication, that is, it has one or more editors (edited books, etc)^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#Edited_Publication">opus:Edited_Publication</a>
    /// </summary>
    let Edited_Publication = _prefixId.prefix "Edited_Publication"
    /// <summary>
    ///   <para>rdfs:label : Journal^^xsd:string</para>
    ///   <para>rdfs:comment : A periodical presenting articles on a particular subject.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#Journal">opus:Journal</a>
    /// </summary>
    let Journal = _prefixId.prefix "Journal"
    /// <summary>
    ///   <para>rdfs:label : Masters Thesis^^xsd:string</para>
    ///   <para>rdfs:comment : A thesis written to receive a Master's degree.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#Masters_Thesis">opus:Masters_Thesis</a>
    /// </summary>
    let Masters_Thesis = _prefixId.prefix "Masters_Thesis"
    /// <summary>
    ///   <para>rdfs:label : Proceedings^^xsd:string</para>
    ///   <para>rdfs:comment : A written account of what transpired at a meeting.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#Proceedings">opus:Proceedings</a>
    /// </summary>
    let Proceedings = _prefixId.prefix "Proceedings"
    /// <summary>
    ///   <para>rdfs:label : Publication^^xsd:string</para>
    ///   <para>rdfs:comment : Individual documents and collections of documents such as series, journals, etc.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#Publication">opus:Publication</a>
    /// </summary>
    let Publication = _prefixId.prefix "Publication"
    /// <summary>
    ///   <para>rdfs:label : Publisher^^xsd:string</para>
    ///   <para>rdfs:comment : An organization that, among other things, creates publishing periodicals, books or music.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#Publishing_Organization">opus:Publishing_Organization</a>
    /// </summary>
    let Publishing_Organization = _prefixId.prefix "Publishing_Organization"
    /// <summary>
    ///   <para>rdfs:label : School^^xsd:string</para>
    ///   <para>rdfs:comment : An organization where individuals receive education.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#School">opus:School</a>
    /// </summary>
    let School = _prefixId.prefix "School"
    /// <summary>
    ///   <para>rdfs:label : Serial Publication^^xsd:string</para>
    ///   <para>rdfs:comment : A periodical that appears at scheduled times.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#Serial_Publication">opus:Serial_Publication</a>
    /// </summary>
    let Serial_Publication = _prefixId.prefix "Serial_Publication"
    /// <summary>
    ///   <para>rdfs:label : Series^^xsd:string</para>
    ///   <para>rdfs:comment : Publication Series, such as LNCS, WEUR Workshops, etc. (at this time debatable whether this should be subclassof Publication)^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#Series">opus:Series</a>
    /// </summary>
    let Series = _prefixId.prefix "Series"
    /// <summary>
    ///   <para>rdfs:label : Thesis^^xsd:string</para>
    ///   <para>rdfs:comment : A treatise advancing a new point of view resulting from research; usually a requirement for an advanced academic degree.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#Thesis">opus:Thesis</a>
    /// </summary>
    let Thesis = _prefixId.prefix "Thesis"
    /// <summary>
    ///   <para>rdfs:label : University^^xsd:string</para>
    ///   <para>rdfs:comment : An institution for higher learning with teaching and research facilities constituting a graduate school and professional schools that award master's degrees and doctorates and an undergraduate division that awards bachelor's degrees.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#University">opus:University</a>
    /// </summary>
    let University = _prefixId.prefix "University"
    /// <summary>
    ///   <para>rdfs:label : Webpage^^xsd:string</para>
    ///   <para>rdfs:comment : A webpage, it is subclass of Document because we want to emphasize that the URL of the webpage is used the URI.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#Webpage">opus:Webpage</a>
    /// </summary>
    let Webpage = _prefixId.prefix "Webpage"
    /// <summary>
    ///   <para>rdfs:label : abstract^^xsd:string</para>
    ///   <para>rdfs:comment : The abstract of a document^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#abstract">opus:abstract</a>
    /// </summary>
    let abstract_ = _prefixId.prefix "abstract"
    /// <summary>
    ///   <para>rdfs:label : Affiliation^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a person is affiliated to a specific organization.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#affiliation">opus:affiliation</a>
    /// </summary>
    let affiliation = _prefixId.prefix "affiliation"
    /// <summary>
    ///   <para>rdfs:label : at organization^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a publication originates or is related to a specific Organization.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#at_organization">opus:at_organization</a>
    /// </summary>
    let at_organization = _prefixId.prefix "at_organization"
    /// <summary>
    ///   <para>rdfs:label : at university^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a publication originates or is related to a specific University.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#at_university">opus:at_university</a>
    /// </summary>
    let at_university = _prefixId.prefix "at_university"
    /// <summary>
    ///   <para>rdfs:label : Author^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a publication is authored by a specific person(s).^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#author">opus:author</a>
    /// </summary>
    let author = _prefixId.prefix "author"
    /// <summary>
    ///   <para>rdfs:label : book title^^xsd:string</para>
    ///   <para>rdfs:comment : An alternative Book Title or the Book Title where an article appears, such as title of proceedings.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#book_title">opus:book_title</a>
    /// </summary>
    let book_title = _prefixId.prefix "book_title"
    /// <summary>
    ///   <para>rdfs:label : cdrom^^xsd:string</para>
    ///   <para>rdfs:comment : The CDROM location of a Publication, as used by the ACM SIGMOD Anthology.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#cdrom">opus:cdrom</a>
    /// </summary>
    let cdrom = _prefixId.prefix "cdrom"
    /// <summary>
    ///   <para>rdfs:label : chapter^^xsd:string</para>
    ///   <para>rdfs:comment : The chapter number of a publication^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#chapter">opus:chapter</a>
    /// </summary>
    let chapter = _prefixId.prefix "chapter"
    /// <summary>
    ///   <para>rdfs:label : Chapter Of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a book chapter belongs to a specific book. It is debateable whether this should be subclass of Collection.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#chapter_of">opus:chapter_of</a>
    /// </summary>
    let chapter_of = _prefixId.prefix "chapter_of"
    /// <summary>
    ///   <para>rdfs:label : Cites^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a publication cites another publication.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#cites">opus:cites</a>
    /// </summary>
    let cites = _prefixId.prefix "cites"
    /// <summary>
    ///   <para>rdfs:label : coauthor^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a person is co-author with another person^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#coauthor">opus:coauthor</a>
    /// </summary>
    let coauthor = _prefixId.prefix "coauthor"
    /// <summary>
    ///   <para>rdfs:label : coeditor^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a person is co-editor with another person^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#coeditor">opus:coeditor</a>
    /// </summary>
    let coeditor = _prefixId.prefix "coeditor"
    /// <summary>
    ///   <para>rdfs:label : Editor^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a publication has a specific editor(s).^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#editor">opus:editor</a>
    /// </summary>
    let editor = _prefixId.prefix "editor"
    /// <summary>
    ///   <para>rdfs:label : ee^^xsd:string</para>
    ///   <para>rdfs:comment : The Electronic Edition of a publication^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#ee">opus:ee</a>
    /// </summary>
    let ee = _prefixId.prefix "ee"
    /// <summary>
    ///   <para>rdfs:label : presentation^^xsd:string</para>
    ///   <para>rdfs:comment : The Electronic Edition of a Presentation of a publication^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#eepresentation">opus:eepresentation</a>
    /// </summary>
    let eepresentation = _prefixId.prefix "eepresentation"
    /// <summary>
    ///   <para>rdfs:label : gMonth^^xsd:string</para>
    ///   <para>rdfs:comment : The month part of the date of a foaf:Document represented as xsd:gMonth value^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#gMonth">opus:gMonth</a>
    /// </summary>
    let gMonth = _prefixId.prefix "gMonth"
    /// <summary>
    ///   <para>rdfs:label : In Series^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a Publication is part of a Publication Series.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#in_series">opus:in_series</a>
    /// </summary>
    let in_series = _prefixId.prefix "in_series"
    /// <summary>
    ///   <para>rdfs:label : is Included in Proceedings^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a publication is included in a specific proceedings publication.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#isIncludedIn">opus:isIncludedIn</a>
    /// </summary>
    let isIncludedIn = _prefixId.prefix "isIncludedIn"
    /// <summary>
    ///   <para>rdfs:label : isbn^^xsd:string</para>
    ///   <para>rdfs:comment : The ISBN of a publication.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#isbn">opus:isbn</a>
    /// </summary>
    let isbn = _prefixId.prefix "isbn"
    /// <summary>
    ///   <para>rdfs:label : journal name^^xsd:string</para>
    ///   <para>rdfs:comment : The name of a Journal, such as where an article appears^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#journal_name">opus:journal_name</a>
    /// </summary>
    let journal_name = _prefixId.prefix "journal_name"
    /// <summary>
    ///   <para>rdfs:label : last modified date^^xsd:string</para>
    ///   <para>rdfs:comment : The last modified date of a document.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#last_modified_date">opus:last_modified_date</a>
    /// </summary>
    let last_modified_date = _prefixId.prefix "last_modified_date"
    /// <summary>
    ///   <para>rdfs:label : month^^xsd:string</para>
    ///   <para>rdfs:comment : The month part of the date of a foaf:Document.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#month">opus:month</a>
    /// </summary>
    let month = _prefixId.prefix "month"
    /// <summary>
    ///   <para>rdfs:label : number^^xsd:string</para>
    ///   <para>rdfs:comment : The Number part of citation of a publication.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#number">opus:number</a>
    /// </summary>
    let number = _prefixId.prefix "number"
    /// <summary>
    ///   <para>rdfs:label : pages^^xsd:string</para>
    ///   <para>rdfs:comment : The Pages part of citation of a publication.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#pages">opus:pages</a>
    /// </summary>
    let pages = _prefixId.prefix "pages"
    /// <summary>
    ///   <para>rdfs:label : sameAffiliation^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a person has same affiliation than another person (this is not necessarily transitive)^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#sameAffiliation">opus:sameAffiliation</a>
    /// </summary>
    let sameAffiliation = _prefixId.prefix "sameAffiliation"
    /// <summary>
    ///   <para>rdfs:label : volume^^xsd:string</para>
    ///   <para>rdfs:comment : The Volume part of citation of a publication.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#volume">opus:volume</a>
    /// </summary>
    let volume = _prefixId.prefix "volume"
    /// <summary>
    ///   <para>rdfs:label : year^^xsd:string</para>
    ///   <para>rdfs:comment : The year part of the date of a foaf:Document.^^xsd:string</para>
    ///   <a href="http://lsdis.cs.uga.edu/projects/semdis/opus#year">opus:year</a>
    /// </summary>
    let year = _prefixId.prefix "year"
