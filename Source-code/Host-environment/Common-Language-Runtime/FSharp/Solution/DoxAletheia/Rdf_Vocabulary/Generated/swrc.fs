namespace http.swrc.ontoware.org.ontology.hash

open DoxAletheia.Rdf_Vocabulary

module swrc =
    let _namespace_name = "http://swrc.ontoware.org/ontology#"
    /// <summary>
    /// Dublin Core elements added.
    /// See: http://dublincore.org/documents/dces/
    ///
    /// for document types see:
    /// http://www.bsz-bw.de/diglib/medserv/konvent/metadat/dcresour.html
    /// <see href="http://swrc.ontoware.org/ontology#Document"></see></summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Product"></see>
    /// </summary>
    let Product = Namespaced_IRI.parse _namespace_name "Product" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Project"></see>
    /// </summary>
    let Project = Namespaced_IRI.parse _namespace_name "Project" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Person"></see>
    /// </summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Organization"></see>
    /// </summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    /// check domain. Olivier 2006-06-07
    /// Philipp: checked.
    /// check range. Olivier 2006-06-07
    /// Philipp: checked.
    /// <see href="http://swrc.ontoware.org/ontology#publisherOf"></see></summary>
    let publisherOf =
        Namespaced_IRI.parse _namespace_name "publisherOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#AcademicStaff"></see>
    /// </summary>
    let AcademicStaff =
        Namespaced_IRI.parse _namespace_name "AcademicStaff" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#editor"></see>
    /// </summary>
    let editor = Namespaced_IRI.parse _namespace_name "editor" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Publication"></see>
    /// </summary>
    let Publication =
        Namespaced_IRI.parse _namespace_name "Publication" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#headOf"></see>
    /// </summary>
    let headOf = Namespaced_IRI.parse _namespace_name "headOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#worksAtProject"></see>
    /// </summary>
    let worksAtProject =
        Namespaced_IRI.parse _namespace_name "worksAtProject" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#memberOfPC"></see>
    /// </summary>
    let memberOfPC = Namespaced_IRI.parse _namespace_name "memberOfPC" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Event"></see>
    /// </summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Employee"></see>
    /// </summary>
    let Employee = Namespaced_IRI.parse _namespace_name "Employee" |> NamespacedName

    /// <summary>
    /// added domain and range. Olivier 2006-06-07
    /// made a subproperty of headOf. Olivier 2006-06-07
    /// <see href="http://swrc.ontoware.org/ontology#headOfGroup"></see></summary>
    let headOfGroup =
        Namespaced_IRI.parse _namespace_name "headOfGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#ResearchGroup"></see>
    /// </summary>
    let ResearchGroup =
        Namespaced_IRI.parse _namespace_name "ResearchGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#cooperateWith"></see>
    /// </summary>
    let cooperateWith =
        Namespaced_IRI.parse _namespace_name "cooperateWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#organizerOrChairOf"></see>
    /// </summary>
    let organizerOrChairOf =
        Namespaced_IRI.parse _namespace_name "organizerOrChairOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#supervises"></see>
    /// </summary>
    let supervises = Namespaced_IRI.parse _namespace_name "supervises" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#PhDStudent"></see>
    /// </summary>
    let PhDStudent = Namespaced_IRI.parse _namespace_name "PhDStudent" |> NamespacedName

    /// <summary>
    /// hasPublication (?). Olivier 2006-06-07
    /// Philipp: Yes, I think it is meant as "hasPublication". Anytime you have just the verb, it is meant as has + verb in a property.
    /// check domain. Olivier 2006-06-07
    /// Philipp: checked.
    /// <see href="http://swrc.ontoware.org/ontology#publication"></see></summary>
    let publication =
        Namespaced_IRI.parse _namespace_name "publication" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#AdministrativeStaff"></see>
    /// </summary>
    let AdministrativeStaff =
        Namespaced_IRI.parse _namespace_name "AdministrativeStaff" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Manager"></see>
    /// </summary>
    let Manager = Namespaced_IRI.parse _namespace_name "Manager" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#TechnicalStaff"></see>
    /// </summary>
    let TechnicalStaff =
        Namespaced_IRI.parse _namespace_name "TechnicalStaff" |> NamespacedName

    /// <summary>
    /// A peer reviewed , refereed article from a journal.
    /// <see href="http://swrc.ontoware.org/ontology#Article"></see></summary>
    let Article = Namespaced_IRI.parse _namespace_name "Article" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#AssistantProfessor"></see>
    /// </summary>
    let AssistantProfessor =
        Namespaced_IRI.parse _namespace_name "AssistantProfessor" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#FacultyMember"></see>
    /// </summary>
    let FacultyMember =
        Namespaced_IRI.parse _namespace_name "FacultyMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#AssociateProfessor"></see>
    /// </summary>
    let AssociateProfessor =
        Namespaced_IRI.parse _namespace_name "AssociateProfessor" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Association"></see>
    /// </summary>
    let Association =
        Namespaced_IRI.parse _namespace_name "Association" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Department"></see>
    /// </summary>
    let Department = Namespaced_IRI.parse _namespace_name "Department" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Enterprise"></see>
    /// </summary>
    let Enterprise = Namespaced_IRI.parse _namespace_name "Enterprise" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#University"></see>
    /// </summary>
    let University = Namespaced_IRI.parse _namespace_name "University" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Institute"></see>
    /// </summary>
    let Institute = Namespaced_IRI.parse _namespace_name "Institute" |> NamespacedName
    /// <summary>
    /// A complete book, not formed from separate papers.
    /// <see href="http://swrc.ontoware.org/ontology#Book"></see></summary>
    let Book = Namespaced_IRI.parse _namespace_name "Book" |> NamespacedName
    /// <summary>
    /// A work that is printed and bound but without a named publisher or sponsering institution.
    /// <see href="http://swrc.ontoware.org/ontology#Booklet"></see></summary>
    let Booklet = Namespaced_IRI.parse _namespace_name "Booklet" |> NamespacedName
    /// <summary>
    /// A book produced from a collection of separate papers.
    /// <see href="http://swrc.ontoware.org/ontology#Collection"></see></summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Colloquium"></see>
    /// </summary>
    let Colloquium = Namespaced_IRI.parse _namespace_name "Colloquium" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#participant"></see>
    /// </summary>
    let participant =
        Namespaced_IRI.parse _namespace_name "participant" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Seminar"></see>
    /// </summary>
    let Seminar = Namespaced_IRI.parse _namespace_name "Seminar" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Workshop"></see>
    /// </summary>
    let Workshop = Namespaced_IRI.parse _namespace_name "Workshop" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Lecture"></see>
    /// </summary>
    let Lecture = Namespaced_IRI.parse _namespace_name "Lecture" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Conference"></see>
    /// </summary>
    let Conference = Namespaced_IRI.parse _namespace_name "Conference" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Exhibition"></see>
    /// </summary>
    let Exhibition = Namespaced_IRI.parse _namespace_name "Exhibition" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Meeting"></see>
    /// </summary>
    let Meeting = Namespaced_IRI.parse _namespace_name "Meeting" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#hasParts"></see>
    /// </summary>
    let hasParts = Namespaced_IRI.parse _namespace_name "hasParts" |> NamespacedName

    /// <summary>
    /// disjoint with researchProject? maybe not. Olivier 2006-06-07
    /// <see href="http://swrc.ontoware.org/ontology#DevelopmentProject"></see></summary>
    let DevelopmentProject =
        Namespaced_IRI.parse _namespace_name "DevelopmentProject" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#DiplomaThesis"></see>
    /// </summary>
    let DiplomaThesis =
        Namespaced_IRI.parse _namespace_name "DiplomaThesis" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Thesis"></see>
    /// </summary>
    let Thesis = Namespaced_IRI.parse _namespace_name "Thesis" |> NamespacedName
    /// <summary>
    /// A university Doctoral thesis.
    /// <see href="http://swrc.ontoware.org/ontology#PhDThesis"></see></summary>
    let PhDThesis = Namespaced_IRI.parse _namespace_name "PhDThesis" |> NamespacedName

    /// <summary>
    /// A university Masters thesis.
    /// <see href="http://swrc.ontoware.org/ontology#MasterThesis"></see></summary>
    let MasterThesis =
        Namespaced_IRI.parse _namespace_name "MasterThesis" |> NamespacedName

    /// <summary>
    /// meaning not clear. Olivier 2006-06-07
    /// Philipp: This property appears in the class definition of swrc:Document. I think it is obsolete, since you may link a document via the dc:creator, dc:contributor or dc:publisher property to an organization.
    /// <see href="http://swrc.ontoware.org/ontology#organization"></see></summary>
    let organization =
        Namespaced_IRI.parse _namespace_name "organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#affiliation"></see>
    /// </summary>
    let affiliation =
        Namespaced_IRI.parse _namespace_name "affiliation" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#atEvent"></see>
    /// </summary>
    let atEvent = Namespaced_IRI.parse _namespace_name "atEvent" |> NamespacedName

    /// <summary>
    /// Example: FIFA World Cup 2006 hasPartEvent Final
    /// <see href="http://swrc.ontoware.org/ontology#hasPartEvent"></see></summary>
    let hasPartEvent =
        Namespaced_IRI.parse _namespace_name "hasPartEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#ExchangeProfessor"></see>
    /// </summary>
    let ExchangeProfessor =
        Namespaced_IRI.parse _namespace_name "ExchangeProfessor" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#FullProfessor"></see>
    /// </summary>
    let FullProfessor =
        Namespaced_IRI.parse _namespace_name "FullProfessor" |> NamespacedName

    /// <summary>
    /// disjoint with undergrad? Olivier 2006-06-07
    /// Philipp: I wouldn't make it disjoint, since someone can be a bachelor-graduate, but if he is doing his master he is a master-undergraduate at the same time.
    /// <see href="http://swrc.ontoware.org/ontology#Graduate"></see></summary>
    let Graduate = Namespaced_IRI.parse _namespace_name "Graduate" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Student"></see>
    /// </summary>
    let Student = Namespaced_IRI.parse _namespace_name "Student" |> NamespacedName

    /// <summary>
    /// see: http://www.neurolabor.de/socrate/ects_ganz.htm
    /// <see href="http://swrc.ontoware.org/ontology#GraduateClass"></see></summary>
    let GraduateClass =
        Namespaced_IRI.parse _namespace_name "GraduateClass" |> NamespacedName

    /// <summary>
    /// see: http://www.neurolabor.de/socrate/ects_ganz.htm
    /// <see href="http://swrc.ontoware.org/ontology#UndergraduateAdvancedClass"></see></summary>
    let UndergraduateAdvancedClass =
        Namespaced_IRI.parse _namespace_name "UndergraduateAdvancedClass" |> NamespacedName

    /// <summary>
    /// see: http://www.neurolabor.de/socrate/ects_ganz.htm
    ///
    /// http://dict.leo.org/cgi-bin/dict/urlexp/20030705201638
    /// <see href="http://swrc.ontoware.org/ontology#UndergraduateIntermediateClass"></see></summary>
    let UndergraduateIntermediateClass =
        Namespaced_IRI.parse _namespace_name "UndergraduateIntermediateClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#HonoraryProfessor"></see>
    /// </summary>
    let HonoraryProfessor =
        Namespaced_IRI.parse _namespace_name "HonoraryProfessor" |> NamespacedName

    /// <summary>
    /// A part of a book, which may be a chapter and/or range of pages.
    /// <see href="http://swrc.ontoware.org/ontology#InBook"></see></summary>
    let InBook = Namespaced_IRI.parse _namespace_name "InBook" |> NamespacedName

    /// <summary>
    /// A single paper or article from a published collection.
    /// <see href="http://swrc.ontoware.org/ontology#InCollection"></see></summary>
    let InCollection =
        Namespaced_IRI.parse _namespace_name "InCollection" |> NamespacedName

    /// <summary>
    /// A single paper from a published workshop or conference proceedings.
    /// <see href="http://swrc.ontoware.org/ontology#InProceedings"></see></summary>
    let InProceedings =
        Namespaced_IRI.parse _namespace_name "InProceedings" |> NamespacedName

    /// <summary>
    /// An entire issue of a refereed learned journal.
    /// <see href="http://swrc.ontoware.org/ontology#Journal"></see></summary>
    let Journal = Namespaced_IRI.parse _namespace_name "Journal" |> NamespacedName
    /// <summary>
    /// check domain. Olivier 2006-06-07
    /// Philipp: checked.
    /// <see href="http://swrc.ontoware.org/ontology#givenBy"></see></summary>
    let givenBy = Namespaced_IRI.parse _namespace_name "givenBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Lecturer"></see>
    /// </summary>
    let Lecturer = Namespaced_IRI.parse _namespace_name "Lecturer" |> NamespacedName
    /// <summary>
    /// An entire issue of an unrefereed journal or magazine.
    /// <see href="http://swrc.ontoware.org/ontology#Magazine"></see></summary>
    let Magazine = Namespaced_IRI.parse _namespace_name "Magazine" |> NamespacedName
    /// <summary>
    /// An operations manual for a product.
    /// <see href="http://swrc.ontoware.org/ontology#Manual"></see></summary>
    let Manual = Namespaced_IRI.parse _namespace_name "Manual" |> NamespacedName
    /// <summary>
    /// Work of another or undetermined type. This is the default scheme value if the scheme is not explicitly stated.
    /// <see href="http://swrc.ontoware.org/ontology#Misc"></see></summary>
    let Misc = Namespaced_IRI.parse _namespace_name "Misc" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#develops"></see>
    /// </summary>
    let develops = Namespaced_IRI.parse _namespace_name "develops" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#carriesOut"></see>
    /// </summary>
    let carriesOut = Namespaced_IRI.parse _namespace_name "carriesOut" |> NamespacedName

    /// <summary>
    /// check domain. Olivier 2006-06-07
    /// Philipp: checked.
    ///
    /// <see href="http://swrc.ontoware.org/ontology#technicalReport"></see></summary>
    let technicalReport =
        Namespaced_IRI.parse _namespace_name "technicalReport" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#TechnicalReport"></see>
    /// </summary>
    let TechnicalReport =
        Namespaced_IRI.parse _namespace_name "TechnicalReport" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#employs"></see>
    /// </summary>
    let employs = Namespaced_IRI.parse _namespace_name "employs" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#finances"></see>
    /// </summary>
    let finances = Namespaced_IRI.parse _namespace_name "finances" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#lastName"></see>
    /// </summary>
    let lastName = Namespaced_IRI.parse _namespace_name "lastName" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#firstName"></see>
    /// </summary>
    let firstName = Namespaced_IRI.parse _namespace_name "firstName" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#address"></see>
    /// </summary>
    let address = Namespaced_IRI.parse _namespace_name "address" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#phone"></see>
    /// </summary>
    let phone = Namespaced_IRI.parse _namespace_name "phone" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#email"></see>
    /// </summary>
    let email = Namespaced_IRI.parse _namespace_name "email" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#fax"></see>
    /// </summary>
    let fax = Namespaced_IRI.parse _namespace_name "fax" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#homepage"></see>
    /// </summary>
    let homepage = Namespaced_IRI.parse _namespace_name "homepage" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#supervisor"></see>
    /// </summary>
    let supervisor = Namespaced_IRI.parse _namespace_name "supervisor" |> NamespacedName

    /// <summary>
    /// A whole published workshop or conference proceedings.
    /// <see href="http://swrc.ontoware.org/ontology#Proceedings"></see></summary>
    let Proceedings =
        Namespaced_IRI.parse _namespace_name "Proceedings" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#price"></see>
    /// </summary>
    let price = Namespaced_IRI.parse _namespace_name "price" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#vendor"></see>
    /// </summary>
    let vendor = Namespaced_IRI.parse _namespace_name "vendor" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#developedBy"></see>
    /// </summary>
    let developedBy =
        Namespaced_IRI.parse _namespace_name "developedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#creationDate"></see>
    /// </summary>
    let creationDate =
        Namespaced_IRI.parse _namespace_name "creationDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#ProfessorEmeritus"></see>
    /// </summary>
    let ProfessorEmeritus =
        Namespaced_IRI.parse _namespace_name "ProfessorEmeritus" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#status"></see>
    /// </summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#projectInfo"></see>
    /// </summary>
    let projectInfo =
        Namespaced_IRI.parse _namespace_name "projectInfo" |> NamespacedName

    /// <summary>
    /// can an organization be a member of another organization? olivier 2006-06-07
    /// Philipp: Hmm could be possible. Therefore I added Organization to the range that one can state: Organization (has)member Organization.
    /// <see href="http://swrc.ontoware.org/ontology#member"></see></summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#outcomeProduct"></see>
    /// </summary>
    let outcomeProduct =
        Namespaced_IRI.parse _namespace_name "outcomeProduct" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#head"></see>
    /// </summary>
    let head = Namespaced_IRI.parse _namespace_name "head" |> NamespacedName
    /// <summary>
    /// check domain. Olivier 2006-06-07
    /// Philipp: checked.
    /// <see href="http://swrc.ontoware.org/ontology#isAbout"></see></summary>
    let isAbout = Namespaced_IRI.parse _namespace_name "isAbout" |> NamespacedName
    /// <summary>
    /// If changing this concept (or its subconcepts) consider that the swrc topic ontology depends on the foresaid one.
    /// The swrc topic ontology can be found at:
    /// http://ontoware.org/frs/download.php/187/swrc-swtopics.owl
    /// <see href="http://swrc.ontoware.org/ontology#Topic"></see></summary>
    let Topic = Namespaced_IRI.parse _namespace_name "Topic" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#startDate"></see>
    /// </summary>
    let startDate = Namespaced_IRI.parse _namespace_name "startDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#carriedOutBy"></see>
    /// </summary>
    let carriedOutBy =
        Namespaced_IRI.parse _namespace_name "carriedOutBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#outcomeDocument"></see>
    /// </summary>
    let outcomeDocument =
        Namespaced_IRI.parse _namespace_name "outcomeDocument" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#financedBy"></see>
    /// </summary>
    let financedBy = Namespaced_IRI.parse _namespace_name "financedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#endDate"></see>
    /// </summary>
    let endDate = Namespaced_IRI.parse _namespace_name "endDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#ProjectMeeting"></see>
    /// </summary>
    let ProjectMeeting =
        Namespaced_IRI.parse _namespace_name "ProjectMeeting" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#ProjectReport"></see>
    /// </summary>
    let ProjectReport =
        Namespaced_IRI.parse _namespace_name "ProjectReport" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#describesProject"></see>
    /// </summary>
    let describesProject =
        Namespaced_IRI.parse _namespace_name "describesProject" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Report"></see>
    /// </summary>
    let Report = Namespaced_IRI.parse _namespace_name "Report" |> NamespacedName
    /// <summary>
    /// check domain. Olivier 2006-06-07
    /// Philipp: checked.
    /// <see href="http://swrc.ontoware.org/ontology#cite"></see></summary>
    let cite = Namespaced_IRI.parse _namespace_name "cite" |> NamespacedName

    /// <summary>
    /// A document with an author and title, but not formally published.
    /// <see href="http://swrc.ontoware.org/ontology#Unpublished"></see></summary>
    let Unpublished =
        Namespaced_IRI.parse _namespace_name "Unpublished" |> NamespacedName

    /// <summary>
    /// A piece of research work.
    /// <see href="http://swrc.ontoware.org/ontology#ResearchPaper"></see></summary>
    let ResearchPaper =
        Namespaced_IRI.parse _namespace_name "ResearchPaper" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#ResearchProject"></see>
    /// </summary>
    let ResearchProject =
        Namespaced_IRI.parse _namespace_name "ResearchProject" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#ResearchTopic"></see>
    /// </summary>
    let ResearchTopic =
        Namespaced_IRI.parse _namespace_name "ResearchTopic" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#isWorkedOnBy"></see>
    /// </summary>
    let isWorkedOnBy =
        Namespaced_IRI.parse _namespace_name "isWorkedOnBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#dealtWithIn"></see>
    /// </summary>
    let dealtWithIn =
        Namespaced_IRI.parse _namespace_name "dealtWithIn" |> NamespacedName

    /// <summary>
    /// meaning not clear. Olivier 2006-06-07
    /// Philipp: Hmm, I didn't create that property, therefore i don't know the intention of it.
    ///
    /// <see href="http://swrc.ontoware.org/ontology#Root"></see></summary>
    let Root = Namespaced_IRI.parse _namespace_name "Root" |> NamespacedName

    /// <summary>
    /// meaning not clear. Olivier 2006-06-07
    /// Philipp: Hmm, I didn't create that property, therefore i don't know the intention of it.
    ///
    /// <see href="http://swrc.ontoware.org/ontology#RootRelation"></see></summary>
    let RootRelation =
        Namespaced_IRI.parse _namespace_name "RootRelation" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#SoftwareComponent"></see>
    /// </summary>
    let SoftwareComponent =
        Namespaced_IRI.parse _namespace_name "SoftwareComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#SoftwareProject"></see>
    /// </summary>
    let SoftwareProject =
        Namespaced_IRI.parse _namespace_name "SoftwareProject" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#studiesAt"></see>
    /// </summary>
    let studiesAt = Namespaced_IRI.parse _namespace_name "studiesAt" |> NamespacedName
    /// <summary>
    /// meaning is not clear. Olivier 2006-06-07
    /// Philipp: This property appears in the class description of Thesis and I think should relate a Thesis to the associated university.
    /// <see href="http://swrc.ontoware.org/ontology#school"></see></summary>
    let school = Namespaced_IRI.parse _namespace_name "school" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Undergraduate"></see>
    /// </summary>
    let Undergraduate =
        Namespaced_IRI.parse _namespace_name "Undergraduate" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#student"></see>
    /// </summary>
    let student = Namespaced_IRI.parse _namespace_name "student" |> NamespacedName

    /// <summary>
    /// An unrefereed article from a journal, magazine or newspaper.
    ///
    /// possible german translation for "unrefereed", also: unredigiert ?!
    /// <see href="http://swrc.ontoware.org/ontology#UnrefereedArticle"></see></summary>
    let UnrefereedArticle =
        Namespaced_IRI.parse _namespace_name "UnrefereedArticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#VisitingProfessor"></see>
    /// </summary>
    let VisitingProfessor =
        Namespaced_IRI.parse _namespace_name "VisitingProfessor" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#abstract"></see>
    /// </summary>
    let abstract_ = Namespaced_IRI.parse _namespace_name "abstract" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#chapter"></see>
    /// </summary>
    let chapter = Namespaced_IRI.parse _namespace_name "chapter" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#citedBy"></see>
    /// </summary>
    let citedBy = Namespaced_IRI.parse _namespace_name "citedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#date"></see>
    /// </summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#edition"></see>
    /// </summary>
    let edition = Namespaced_IRI.parse _namespace_name "edition" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#eventTitle"></see>
    /// </summary>
    let eventTitle = Namespaced_IRI.parse _namespace_name "eventTitle" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#title"></see>
    /// </summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#howpublished"></see>
    /// </summary>
    let howpublished =
        Namespaced_IRI.parse _namespace_name "howpublished" |> NamespacedName

    /// <summary>
    /// meaning not clear
    /// Philipp: Hmm, I didn't create that property, therefore i don't know the intention of it.
    /// <see href="http://swrc.ontoware.org/ontology#institution"></see></summary>
    let institution =
        Namespaced_IRI.parse _namespace_name "institution" |> NamespacedName

    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#isbn"></see>
    /// </summary>
    let isbn = Namespaced_IRI.parse _namespace_name "isbn" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#journal"></see>
    /// </summary>
    let journal = Namespaced_IRI.parse _namespace_name "journal" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#keywords"></see>
    /// </summary>
    let keywords = Namespaced_IRI.parse _namespace_name "keywords" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#location"></see>
    /// </summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#month"></see>
    /// </summary>
    let month = Namespaced_IRI.parse _namespace_name "month" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#note"></see>
    /// </summary>
    let note = Namespaced_IRI.parse _namespace_name "note" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#number"></see>
    /// </summary>
    let number = Namespaced_IRI.parse _namespace_name "number" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#pages"></see>
    /// </summary>
    let pages = Namespaced_IRI.parse _namespace_name "pages" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#photo"></see>
    /// </summary>
    let photo = Namespaced_IRI.parse _namespace_name "photo" |> NamespacedName
    /// <summary>
    /// meaning not clear. Olivier 2006-06-07
    /// Philipp: Hmm, I didn't create that property, therefore i don't know the intention of it.
    /// <see href="http://swrc.ontoware.org/ontology#product"></see></summary>
    let product = Namespaced_IRI.parse _namespace_name "product" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#series"></see>
    /// </summary>
    let series = Namespaced_IRI.parse _namespace_name "series" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#source"></see>
    /// </summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#type"></see>
    /// </summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#volume"></see>
    /// </summary>
    let volume = Namespaced_IRI.parse _namespace_name "volume" |> NamespacedName
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#year"></see>
    /// </summary>
    let year = Namespaced_IRI.parse _namespace_name "year" |> NamespacedName
