namespace http.lsdis.cs.uga.edu.projects.semdis.opus.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module opus =
    let _namespace_iri = Namespace_Iri opus |> NamespaceIRI
    /// <summary>
    ///   <para>opus:Webpage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A webpage, it is subclass of Document because we want to emphasize that the URL of the webpage is used the URI.</para>
    /// labels<para>Webpage</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#Webpage">http://lsdis.cs.uga.edu/projects/semdis/opus#Webpage</seealso>
    let Webpage = Prefixed_Name(opus, "Webpage") |> PrefixedName
    /// <summary>
    ///   <para>opus:at_organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a publication originates or is related to a specific Organization.</para>
    /// labels<para>at organization</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#at_organization">http://lsdis.cs.uga.edu/projects/semdis/opus#at_organization</seealso>
    let at_organization = Prefixed_Name(opus, "at_organization") |> PrefixedName
    /// <summary>
    ///   <para>opus:book_title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An alternative Book Title or the Book Title where an article appears, such as title of proceedings.</para>
    /// labels<para>book title</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#book_title">http://lsdis.cs.uga.edu/projects/semdis/opus#book_title</seealso>
    let book_title = Prefixed_Name(opus, "book_title") |> PrefixedName
    /// <summary>
    ///   <para>opus:in_series</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a Publication is part of a Publication Series.</para>
    /// labels<para>In Series</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#in_series">http://lsdis.cs.uga.edu/projects/semdis/opus#in_series</seealso>
    let in_series = Prefixed_Name(opus, "in_series") |> PrefixedName
    /// <summary>
    ///   <para>opus:abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The abstract of a document</para>
    /// labels<para>abstract</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#abstract">http://lsdis.cs.uga.edu/projects/semdis/opus#abstract</seealso>
    let abstract_ = Prefixed_Name(opus, "abstract") |> PrefixedName
    /// <summary>
    ///   <para>opus:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>This file specifies in RDF Schema format the classes and properties for SwetoDblp.
    ///     These classes and properties are based on the internal LSDIS Library portal engine.
    ///     Contact Person is Boanerges Aleman-Meza (baleman at uga dot edu).
    ///     </para>
    /// labels<para>SwetoDblp Ontology</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#">http://lsdis.cs.uga.edu/projects/semdis/opus#</seealso>
    let _prefix_iri = Prefixed_Name(opus, "") |> PrefixedName
    /// <summary>
    ///   <para>opus:Article</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An article from a journal or magazine.</para>
    /// labels<para>Article</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#Article">http://lsdis.cs.uga.edu/projects/semdis/opus#Article</seealso>
    let Article = Prefixed_Name(opus, "Article") |> PrefixedName
    /// <summary>
    ///   <para>opus:Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Individual documents and collections of documents such as series, journals, etc.</para>
    /// labels<para>Publication</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#Publication">http://lsdis.cs.uga.edu/projects/semdis/opus#Publication</seealso>
    let Publication = Prefixed_Name(opus, "Publication") |> PrefixedName

    /// <summary>
    ///   <para>opus:Article_in_Proceedings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An article in the proceedings of a meeting, such as a conference, workhshop and symposium.</para>
    /// labels<para>Article in Proceedings</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#Article_in_Proceedings">http://lsdis.cs.uga.edu/projects/semdis/opus#Article_in_Proceedings</seealso>
    let Article_in_Proceedings =
        Prefixed_Name(opus, "Article_in_Proceedings") |> PrefixedName

    /// <summary>
    ///   <para>opus:Book</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A book with an explicit publisher.</para>
    /// labels<para>Book</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#Book">http://lsdis.cs.uga.edu/projects/semdis/opus#Book</seealso>
    let Book = Prefixed_Name(opus, "Book") |> PrefixedName
    /// <summary>
    ///   <para>opus:Book_Chapter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A part of a book, such as a chapter (or section/preface) and/or a range of pages.</para>
    /// labels<para>Book Chapter</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#Book_Chapter">http://lsdis.cs.uga.edu/projects/semdis/opus#Book_Chapter</seealso>
    let Book_Chapter = Prefixed_Name(opus, "Book_Chapter") |> PrefixedName

    /// <summary>
    ///   <para>opus:Doctoral_Dissertation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A dissertation written to receive a PhD.</para>
    /// labels<para>Doctoral Dissertation</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#Doctoral_Dissertation">http://lsdis.cs.uga.edu/projects/semdis/opus#Doctoral_Dissertation</seealso>
    let Doctoral_Dissertation =
        Prefixed_Name(opus, "Doctoral_Dissertation") |> PrefixedName

    /// <summary>
    ///   <para>opus:Thesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A treatise advancing a new point of view resulting from research; usually a requirement for an advanced academic degree.</para>
    /// labels<para>Thesis</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#Thesis">http://lsdis.cs.uga.edu/projects/semdis/opus#Thesis</seealso>
    let Thesis = Prefixed_Name(opus, "Thesis") |> PrefixedName
    /// <summary>
    ///   <para>opus:Edited_Book</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An edited book with an explicit publisher.</para>
    /// labels<para>Edited Book</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#Edited_Book">http://lsdis.cs.uga.edu/projects/semdis/opus#Edited_Book</seealso>
    let Edited_Book = Prefixed_Name(opus, "Edited_Book") |> PrefixedName
    /// <summary>
    ///   <para>opus:Edited_Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An edited publication, that is, it has one or more editors (edited books, etc)</para>
    /// labels<para>Edited Publication</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#Edited_Publication">http://lsdis.cs.uga.edu/projects/semdis/opus#Edited_Publication</seealso>
    let Edited_Publication = Prefixed_Name(opus, "Edited_Publication") |> PrefixedName
    /// <summary>
    ///   <para>opus:Journal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A periodical presenting articles on a particular subject.</para>
    /// labels<para>Journal</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#Journal">http://lsdis.cs.uga.edu/projects/semdis/opus#Journal</seealso>
    let Journal = Prefixed_Name(opus, "Journal") |> PrefixedName
    /// <summary>
    ///   <para>opus:Serial_Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A periodical that appears at scheduled times.</para>
    /// labels<para>Serial Publication</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#Serial_Publication">http://lsdis.cs.uga.edu/projects/semdis/opus#Serial_Publication</seealso>
    let Serial_Publication = Prefixed_Name(opus, "Serial_Publication") |> PrefixedName
    /// <summary>
    ///   <para>opus:Masters_Thesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A thesis written to receive a Master's degree.</para>
    /// labels<para>Masters Thesis</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#Masters_Thesis">http://lsdis.cs.uga.edu/projects/semdis/opus#Masters_Thesis</seealso>
    let Masters_Thesis = Prefixed_Name(opus, "Masters_Thesis") |> PrefixedName
    /// <summary>
    ///   <para>opus:Proceedings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A written account of what transpired at a meeting.</para>
    /// labels<para>Proceedings</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#Proceedings">http://lsdis.cs.uga.edu/projects/semdis/opus#Proceedings</seealso>
    let Proceedings = Prefixed_Name(opus, "Proceedings") |> PrefixedName

    /// <summary>
    ///   <para>opus:Publishing_Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An organization that, among other things, creates publishing periodicals, books or music.</para>
    /// labels<para>Publisher</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#Publishing_Organization">http://lsdis.cs.uga.edu/projects/semdis/opus#Publishing_Organization</seealso>
    let Publishing_Organization =
        Prefixed_Name(opus, "Publishing_Organization") |> PrefixedName

    /// <summary>
    ///   <para>opus:School</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An organization where individuals receive education.</para>
    /// labels<para>School</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#School">http://lsdis.cs.uga.edu/projects/semdis/opus#School</seealso>
    let School = Prefixed_Name(opus, "School") |> PrefixedName
    /// <summary>
    ///   <para>opus:Series</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Publication Series, such as LNCS, WEUR Workshops, etc. (at this time debatable whether this should be subclassof Publication)</para>
    /// labels<para>Series</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#Series">http://lsdis.cs.uga.edu/projects/semdis/opus#Series</seealso>
    let Series = Prefixed_Name(opus, "Series") |> PrefixedName
    /// <summary>
    ///   <para>opus:University</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An institution for higher learning with teaching and research facilities constituting a graduate school and professional schools that award master's degrees and doctorates and an undergraduate division that awards bachelor's degrees.</para>
    /// labels<para>University</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#University">http://lsdis.cs.uga.edu/projects/semdis/opus#University</seealso>
    let University = Prefixed_Name(opus, "University") |> PrefixedName
    /// <summary>
    ///   <para>opus:affiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a person is affiliated to a specific organization.</para>
    /// labels<para>Affiliation</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#affiliation">http://lsdis.cs.uga.edu/projects/semdis/opus#affiliation</seealso>
    let affiliation = Prefixed_Name(opus, "affiliation") |> PrefixedName
    /// <summary>
    ///   <para>opus:at_university</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a publication originates or is related to a specific University.</para>
    /// labels<para>at university</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#at_university">http://lsdis.cs.uga.edu/projects/semdis/opus#at_university</seealso>
    let at_university = Prefixed_Name(opus, "at_university") |> PrefixedName
    /// <summary>
    ///   <para>opus:author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a publication is authored by a specific person(s).</para>
    /// labels<para>Author</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#author">http://lsdis.cs.uga.edu/projects/semdis/opus#author</seealso>
    let author = Prefixed_Name(opus, "author") |> PrefixedName
    /// <summary>
    ///   <para>opus:cdrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The CDROM location of a Publication, as used by the ACM SIGMOD Anthology.</para>
    /// labels<para>cdrom</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#cdrom">http://lsdis.cs.uga.edu/projects/semdis/opus#cdrom</seealso>
    let cdrom = Prefixed_Name(opus, "cdrom") |> PrefixedName
    /// <summary>
    ///   <para>opus:chapter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The chapter number of a publication</para>
    /// labels<para>chapter</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#chapter">http://lsdis.cs.uga.edu/projects/semdis/opus#chapter</seealso>
    let chapter = Prefixed_Name(opus, "chapter") |> PrefixedName
    /// <summary>
    ///   <para>opus:chapter_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a book chapter belongs to a specific book. It is debateable whether this should be subclass of Collection.</para>
    /// labels<para>Chapter Of</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#chapter_of">http://lsdis.cs.uga.edu/projects/semdis/opus#chapter_of</seealso>
    let chapter_of = Prefixed_Name(opus, "chapter_of") |> PrefixedName
    /// <summary>
    ///   <para>opus:cites</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a publication cites another publication.</para>
    /// labels<para>Cites</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#cites">http://lsdis.cs.uga.edu/projects/semdis/opus#cites</seealso>
    let cites = Prefixed_Name(opus, "cites") |> PrefixedName
    /// <summary>
    ///   <para>opus:coauthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a person is co-author with another person</para>
    /// labels<para>coauthor</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#coauthor">http://lsdis.cs.uga.edu/projects/semdis/opus#coauthor</seealso>
    let coauthor = Prefixed_Name(opus, "coauthor") |> PrefixedName
    /// <summary>
    ///   <para>opus:coeditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a person is co-editor with another person</para>
    /// labels<para>coeditor</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#coeditor">http://lsdis.cs.uga.edu/projects/semdis/opus#coeditor</seealso>
    let coeditor = Prefixed_Name(opus, "coeditor") |> PrefixedName
    /// <summary>
    ///   <para>opus:editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a publication has a specific editor(s).</para>
    /// labels<para>Editor</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#editor">http://lsdis.cs.uga.edu/projects/semdis/opus#editor</seealso>
    let editor = Prefixed_Name(opus, "editor") |> PrefixedName
    /// <summary>
    ///   <para>opus:ee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Electronic Edition of a publication</para>
    /// labels<para>ee</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#ee">http://lsdis.cs.uga.edu/projects/semdis/opus#ee</seealso>
    let ee = Prefixed_Name(opus, "ee") |> PrefixedName
    /// <summary>
    ///   <para>opus:eepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Electronic Edition of a Presentation of a publication</para>
    /// labels<para>presentation</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#eepresentation">http://lsdis.cs.uga.edu/projects/semdis/opus#eepresentation</seealso>
    let eepresentation = Prefixed_Name(opus, "eepresentation") |> PrefixedName
    /// <summary>
    ///   <para>opus:gMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The month part of the date of a foaf:Document represented as xsd:gMonth value</para>
    /// labels<para>gMonth</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#gMonth">http://lsdis.cs.uga.edu/projects/semdis/opus#gMonth</seealso>
    let gMonth = Prefixed_Name(opus, "gMonth") |> PrefixedName
    /// <summary>
    ///   <para>opus:isIncludedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a publication is included in a specific proceedings publication.</para>
    /// labels<para>is Included in Proceedings</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#isIncludedIn">http://lsdis.cs.uga.edu/projects/semdis/opus#isIncludedIn</seealso>
    let isIncludedIn = Prefixed_Name(opus, "isIncludedIn") |> PrefixedName
    /// <summary>
    ///   <para>opus:isbn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ISBN of a publication.</para>
    /// labels<para>isbn</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#isbn">http://lsdis.cs.uga.edu/projects/semdis/opus#isbn</seealso>
    let isbn = Prefixed_Name(opus, "isbn") |> PrefixedName
    /// <summary>
    ///   <para>opus:journal_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of a Journal, such as where an article appears</para>
    /// labels<para>journal name</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#journal_name">http://lsdis.cs.uga.edu/projects/semdis/opus#journal_name</seealso>
    let journal_name = Prefixed_Name(opus, "journal_name") |> PrefixedName
    /// <summary>
    ///   <para>opus:last_modified_date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The last modified date of a document.</para>
    /// labels<para>last modified date</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#last_modified_date">http://lsdis.cs.uga.edu/projects/semdis/opus#last_modified_date</seealso>
    let last_modified_date = Prefixed_Name(opus, "last_modified_date") |> PrefixedName
    /// <summary>
    ///   <para>opus:month</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The month part of the date of a foaf:Document.</para>
    /// labels<para>month</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#month">http://lsdis.cs.uga.edu/projects/semdis/opus#month</seealso>
    let month = Prefixed_Name(opus, "month") |> PrefixedName
    /// <summary>
    ///   <para>opus:number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Number part of citation of a publication.</para>
    /// labels<para>number</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#number">http://lsdis.cs.uga.edu/projects/semdis/opus#number</seealso>
    let number = Prefixed_Name(opus, "number") |> PrefixedName
    /// <summary>
    ///   <para>opus:pages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Pages part of citation of a publication.</para>
    /// labels<para>pages</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#pages">http://lsdis.cs.uga.edu/projects/semdis/opus#pages</seealso>
    let pages = Prefixed_Name(opus, "pages") |> PrefixedName
    /// <summary>
    ///   <para>opus:sameAffiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a person has same affiliation than another person (this is not necessarily transitive)</para>
    /// labels<para>sameAffiliation</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#sameAffiliation">http://lsdis.cs.uga.edu/projects/semdis/opus#sameAffiliation</seealso>
    let sameAffiliation = Prefixed_Name(opus, "sameAffiliation") |> PrefixedName
    /// <summary>
    ///   <para>opus:volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Volume part of citation of a publication.</para>
    /// labels<para>volume</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#volume">http://lsdis.cs.uga.edu/projects/semdis/opus#volume</seealso>
    let volume = Prefixed_Name(opus, "volume") |> PrefixedName
    /// <summary>
    ///   <para>opus:year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The year part of the date of a foaf:Document.</para>
    /// labels<para>year</para></remarks>
    /// <seealso href="http://lsdis.cs.uga.edu/projects/semdis/opus#year">http://lsdis.cs.uga.edu/projects/semdis/opus#year</seealso>
    let year = Prefixed_Name(opus, "year") |> PrefixedName
