namespace http.swrc.ontoware.org.ontology.hash

open DoxAletheia

module swrc =
    let _namespace_name = "http://swrc.ontoware.org/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Dublin Core elements added.
    /// See: http://dublincore.org/documents/dces/
    ///
    /// for document types see:
    /// http://www.bsz-bw.de/diglib/medserv/konvent/metadat/dcresour.html
    /// <see href="http://swrc.ontoware.org/ontology#Document"></see></summary>
    let Document = _prefix "Document"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Product"></see>
    /// </summary>
    let Product = _prefix "Product"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Project"></see>
    /// </summary>
    let Project = _prefix "Project"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Person"></see>
    /// </summary>
    let Person = _prefix "Person"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Organization"></see>
    /// </summary>
    let Organization = _prefix "Organization"
    /// <summary>
    /// check domain. Olivier 2006-06-07
    /// Philipp: checked.
    /// check range. Olivier 2006-06-07
    /// Philipp: checked.
    /// <see href="http://swrc.ontoware.org/ontology#publisherOf"></see></summary>
    let publisherOf = _prefix "publisherOf"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#AcademicStaff"></see>
    /// </summary>
    let AcademicStaff = _prefix "AcademicStaff"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#editor"></see>
    /// </summary>
    let editor = _prefix "editor"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Publication"></see>
    /// </summary>
    let Publication = _prefix "Publication"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#headOf"></see>
    /// </summary>
    let headOf = _prefix "headOf"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#worksAtProject"></see>
    /// </summary>
    let worksAtProject = _prefix "worksAtProject"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#memberOfPC"></see>
    /// </summary>
    let memberOfPC = _prefix "memberOfPC"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Event"></see>
    /// </summary>
    let Event = _prefix "Event"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Employee"></see>
    /// </summary>
    let Employee = _prefix "Employee"
    /// <summary>
    /// added domain and range. Olivier 2006-06-07
    /// made a subproperty of headOf. Olivier 2006-06-07
    /// <see href="http://swrc.ontoware.org/ontology#headOfGroup"></see></summary>
    let headOfGroup = _prefix "headOfGroup"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#ResearchGroup"></see>
    /// </summary>
    let ResearchGroup = _prefix "ResearchGroup"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#cooperateWith"></see>
    /// </summary>
    let cooperateWith = _prefix "cooperateWith"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#organizerOrChairOf"></see>
    /// </summary>
    let organizerOrChairOf = _prefix "organizerOrChairOf"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#supervises"></see>
    /// </summary>
    let supervises = _prefix "supervises"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#PhDStudent"></see>
    /// </summary>
    let PhDStudent = _prefix "PhDStudent"
    /// <summary>
    /// hasPublication (?). Olivier 2006-06-07
    /// Philipp: Yes, I think it is meant as "hasPublication". Anytime you have just the verb, it is meant as has + verb in a property.
    /// check domain. Olivier 2006-06-07
    /// Philipp: checked.
    /// <see href="http://swrc.ontoware.org/ontology#publication"></see></summary>
    let publication = _prefix "publication"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#AdministrativeStaff"></see>
    /// </summary>
    let AdministrativeStaff = _prefix "AdministrativeStaff"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Manager"></see>
    /// </summary>
    let Manager = _prefix "Manager"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#TechnicalStaff"></see>
    /// </summary>
    let TechnicalStaff = _prefix "TechnicalStaff"
    /// <summary>
    /// A peer reviewed , refereed article from a journal.
    /// <see href="http://swrc.ontoware.org/ontology#Article"></see></summary>
    let Article = _prefix "Article"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#AssistantProfessor"></see>
    /// </summary>
    let AssistantProfessor = _prefix "AssistantProfessor"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#FacultyMember"></see>
    /// </summary>
    let FacultyMember = _prefix "FacultyMember"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#AssociateProfessor"></see>
    /// </summary>
    let AssociateProfessor = _prefix "AssociateProfessor"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Association"></see>
    /// </summary>
    let Association = _prefix "Association"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Department"></see>
    /// </summary>
    let Department = _prefix "Department"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Enterprise"></see>
    /// </summary>
    let Enterprise = _prefix "Enterprise"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#University"></see>
    /// </summary>
    let University = _prefix "University"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Institute"></see>
    /// </summary>
    let Institute = _prefix "Institute"
    /// <summary>
    /// A complete book, not formed from separate papers.
    /// <see href="http://swrc.ontoware.org/ontology#Book"></see></summary>
    let Book = _prefix "Book"
    /// <summary>
    /// A work that is printed and bound but without a named publisher or sponsering institution.
    /// <see href="http://swrc.ontoware.org/ontology#Booklet"></see></summary>
    let Booklet = _prefix "Booklet"
    /// <summary>
    /// A book produced from a collection of separate papers.
    /// <see href="http://swrc.ontoware.org/ontology#Collection"></see></summary>
    let Collection = _prefix "Collection"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Colloquium"></see>
    /// </summary>
    let Colloquium = _prefix "Colloquium"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#participant"></see>
    /// </summary>
    let participant = _prefix "participant"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Seminar"></see>
    /// </summary>
    let Seminar = _prefix "Seminar"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Workshop"></see>
    /// </summary>
    let Workshop = _prefix "Workshop"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Lecture"></see>
    /// </summary>
    let Lecture = _prefix "Lecture"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Conference"></see>
    /// </summary>
    let Conference = _prefix "Conference"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Exhibition"></see>
    /// </summary>
    let Exhibition = _prefix "Exhibition"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Meeting"></see>
    /// </summary>
    let Meeting = _prefix "Meeting"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#hasParts"></see>
    /// </summary>
    let hasParts = _prefix "hasParts"
    /// <summary>
    /// disjoint with researchProject? maybe not. Olivier 2006-06-07
    /// <see href="http://swrc.ontoware.org/ontology#DevelopmentProject"></see></summary>
    let DevelopmentProject = _prefix "DevelopmentProject"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#DiplomaThesis"></see>
    /// </summary>
    let DiplomaThesis = _prefix "DiplomaThesis"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Thesis"></see>
    /// </summary>
    let Thesis = _prefix "Thesis"
    /// <summary>
    /// A university Doctoral thesis.
    /// <see href="http://swrc.ontoware.org/ontology#PhDThesis"></see></summary>
    let PhDThesis = _prefix "PhDThesis"
    /// <summary>
    /// A university Masters thesis.
    /// <see href="http://swrc.ontoware.org/ontology#MasterThesis"></see></summary>
    let MasterThesis = _prefix "MasterThesis"
    /// <summary>
    /// meaning not clear. Olivier 2006-06-07
    /// Philipp: This property appears in the class definition of swrc:Document. I think it is obsolete, since you may link a document via the dc:creator, dc:contributor or dc:publisher property to an organization.
    /// <see href="http://swrc.ontoware.org/ontology#organization"></see></summary>
    let organization = _prefix "organization"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#affiliation"></see>
    /// </summary>
    let affiliation = _prefix "affiliation"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#atEvent"></see>
    /// </summary>
    let atEvent = _prefix "atEvent"
    /// <summary>
    /// Example: FIFA World Cup 2006 hasPartEvent Final
    /// <see href="http://swrc.ontoware.org/ontology#hasPartEvent"></see></summary>
    let hasPartEvent = _prefix "hasPartEvent"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#ExchangeProfessor"></see>
    /// </summary>
    let ExchangeProfessor = _prefix "ExchangeProfessor"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#FullProfessor"></see>
    /// </summary>
    let FullProfessor = _prefix "FullProfessor"
    /// <summary>
    /// disjoint with undergrad? Olivier 2006-06-07
    /// Philipp: I wouldn't make it disjoint, since someone can be a bachelor-graduate, but if he is doing his master he is a master-undergraduate at the same time.
    /// <see href="http://swrc.ontoware.org/ontology#Graduate"></see></summary>
    let Graduate = _prefix "Graduate"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Student"></see>
    /// </summary>
    let Student = _prefix "Student"
    /// <summary>
    /// see: http://www.neurolabor.de/socrate/ects_ganz.htm
    /// <see href="http://swrc.ontoware.org/ontology#GraduateClass"></see></summary>
    let GraduateClass = _prefix "GraduateClass"
    /// <summary>
    /// see: http://www.neurolabor.de/socrate/ects_ganz.htm
    /// <see href="http://swrc.ontoware.org/ontology#UndergraduateAdvancedClass"></see></summary>
    let UndergraduateAdvancedClass = _prefix "UndergraduateAdvancedClass"
    /// <summary>
    /// see: http://www.neurolabor.de/socrate/ects_ganz.htm
    ///
    /// http://dict.leo.org/cgi-bin/dict/urlexp/20030705201638
    /// <see href="http://swrc.ontoware.org/ontology#UndergraduateIntermediateClass"></see></summary>
    let UndergraduateIntermediateClass = _prefix "UndergraduateIntermediateClass"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#HonoraryProfessor"></see>
    /// </summary>
    let HonoraryProfessor = _prefix "HonoraryProfessor"
    /// <summary>
    /// A part of a book, which may be a chapter and/or range of pages.
    /// <see href="http://swrc.ontoware.org/ontology#InBook"></see></summary>
    let InBook = _prefix "InBook"
    /// <summary>
    /// A single paper or article from a published collection.
    /// <see href="http://swrc.ontoware.org/ontology#InCollection"></see></summary>
    let InCollection = _prefix "InCollection"
    /// <summary>
    /// A single paper from a published workshop or conference proceedings.
    /// <see href="http://swrc.ontoware.org/ontology#InProceedings"></see></summary>
    let InProceedings = _prefix "InProceedings"
    /// <summary>
    /// An entire issue of a refereed learned journal.
    /// <see href="http://swrc.ontoware.org/ontology#Journal"></see></summary>
    let Journal = _prefix "Journal"
    /// <summary>
    /// check domain. Olivier 2006-06-07
    /// Philipp: checked.
    /// <see href="http://swrc.ontoware.org/ontology#givenBy"></see></summary>
    let givenBy = _prefix "givenBy"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Lecturer"></see>
    /// </summary>
    let Lecturer = _prefix "Lecturer"
    /// <summary>
    /// An entire issue of an unrefereed journal or magazine.
    /// <see href="http://swrc.ontoware.org/ontology#Magazine"></see></summary>
    let Magazine = _prefix "Magazine"
    /// <summary>
    /// An operations manual for a product.
    /// <see href="http://swrc.ontoware.org/ontology#Manual"></see></summary>
    let Manual = _prefix "Manual"
    /// <summary>
    /// Work of another or undetermined type. This is the default scheme value if the scheme is not explicitly stated.
    /// <see href="http://swrc.ontoware.org/ontology#Misc"></see></summary>
    let Misc = _prefix "Misc"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#develops"></see>
    /// </summary>
    let develops = _prefix "develops"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#carriesOut"></see>
    /// </summary>
    let carriesOut = _prefix "carriesOut"
    /// <summary>
    /// check domain. Olivier 2006-06-07
    /// Philipp: checked.
    ///
    /// <see href="http://swrc.ontoware.org/ontology#technicalReport"></see></summary>
    let technicalReport = _prefix "technicalReport"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#TechnicalReport"></see>
    /// </summary>
    let TechnicalReport = _prefix "TechnicalReport"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#employs"></see>
    /// </summary>
    let employs = _prefix "employs"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#finances"></see>
    /// </summary>
    let finances = _prefix "finances"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#lastName"></see>
    /// </summary>
    let lastName = _prefix "lastName"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#firstName"></see>
    /// </summary>
    let firstName = _prefix "firstName"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#address"></see>
    /// </summary>
    let address = _prefix "address"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#phone"></see>
    /// </summary>
    let phone = _prefix "phone"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#email"></see>
    /// </summary>
    let email = _prefix "email"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#fax"></see>
    /// </summary>
    let fax = _prefix "fax"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#homepage"></see>
    /// </summary>
    let homepage = _prefix "homepage"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#supervisor"></see>
    /// </summary>
    let supervisor = _prefix "supervisor"
    /// <summary>
    /// A whole published workshop or conference proceedings.
    /// <see href="http://swrc.ontoware.org/ontology#Proceedings"></see></summary>
    let Proceedings = _prefix "Proceedings"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#price"></see>
    /// </summary>
    let price = _prefix "price"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#vendor"></see>
    /// </summary>
    let vendor = _prefix "vendor"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#developedBy"></see>
    /// </summary>
    let developedBy = _prefix "developedBy"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#creationDate"></see>
    /// </summary>
    let creationDate = _prefix "creationDate"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#ProfessorEmeritus"></see>
    /// </summary>
    let ProfessorEmeritus = _prefix "ProfessorEmeritus"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#status"></see>
    /// </summary>
    let status = _prefix "status"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#projectInfo"></see>
    /// </summary>
    let projectInfo = _prefix "projectInfo"
    /// <summary>
    /// can an organization be a member of another organization? olivier 2006-06-07
    /// Philipp: Hmm could be possible. Therefore I added Organization to the range that one can state: Organization (has)member Organization.
    /// <see href="http://swrc.ontoware.org/ontology#member"></see></summary>
    let member_ = _prefix "member"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#outcomeProduct"></see>
    /// </summary>
    let outcomeProduct = _prefix "outcomeProduct"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#head"></see>
    /// </summary>
    let head = _prefix "head"
    /// <summary>
    /// check domain. Olivier 2006-06-07
    /// Philipp: checked.
    /// <see href="http://swrc.ontoware.org/ontology#isAbout"></see></summary>
    let isAbout = _prefix "isAbout"
    /// <summary>
    /// If changing this concept (or its subconcepts) consider that the swrc topic ontology depends on the foresaid one.
    /// The swrc topic ontology can be found at:
    /// http://ontoware.org/frs/download.php/187/swrc-swtopics.owl
    /// <see href="http://swrc.ontoware.org/ontology#Topic"></see></summary>
    let Topic = _prefix "Topic"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#startDate"></see>
    /// </summary>
    let startDate = _prefix "startDate"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#carriedOutBy"></see>
    /// </summary>
    let carriedOutBy = _prefix "carriedOutBy"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#outcomeDocument"></see>
    /// </summary>
    let outcomeDocument = _prefix "outcomeDocument"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#financedBy"></see>
    /// </summary>
    let financedBy = _prefix "financedBy"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#endDate"></see>
    /// </summary>
    let endDate = _prefix "endDate"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#ProjectMeeting"></see>
    /// </summary>
    let ProjectMeeting = _prefix "ProjectMeeting"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#ProjectReport"></see>
    /// </summary>
    let ProjectReport = _prefix "ProjectReport"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#describesProject"></see>
    /// </summary>
    let describesProject = _prefix "describesProject"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Report"></see>
    /// </summary>
    let Report = _prefix "Report"
    /// <summary>
    /// check domain. Olivier 2006-06-07
    /// Philipp: checked.
    /// <see href="http://swrc.ontoware.org/ontology#cite"></see></summary>
    let cite = _prefix "cite"
    /// <summary>
    /// A document with an author and title, but not formally published.
    /// <see href="http://swrc.ontoware.org/ontology#Unpublished"></see></summary>
    let Unpublished = _prefix "Unpublished"
    /// <summary>
    /// A piece of research work.
    /// <see href="http://swrc.ontoware.org/ontology#ResearchPaper"></see></summary>
    let ResearchPaper = _prefix "ResearchPaper"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#ResearchProject"></see>
    /// </summary>
    let ResearchProject = _prefix "ResearchProject"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#ResearchTopic"></see>
    /// </summary>
    let ResearchTopic = _prefix "ResearchTopic"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#isWorkedOnBy"></see>
    /// </summary>
    let isWorkedOnBy = _prefix "isWorkedOnBy"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#dealtWithIn"></see>
    /// </summary>
    let dealtWithIn = _prefix "dealtWithIn"
    /// <summary>
    /// meaning not clear. Olivier 2006-06-07
    /// Philipp: Hmm, I didn't create that property, therefore i don't know the intention of it.
    ///
    /// <see href="http://swrc.ontoware.org/ontology#Root"></see></summary>
    let Root = _prefix "Root"
    /// <summary>
    /// meaning not clear. Olivier 2006-06-07
    /// Philipp: Hmm, I didn't create that property, therefore i don't know the intention of it.
    ///
    /// <see href="http://swrc.ontoware.org/ontology#RootRelation"></see></summary>
    let RootRelation = _prefix "RootRelation"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#SoftwareComponent"></see>
    /// </summary>
    let SoftwareComponent = _prefix "SoftwareComponent"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#SoftwareProject"></see>
    /// </summary>
    let SoftwareProject = _prefix "SoftwareProject"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#studiesAt"></see>
    /// </summary>
    let studiesAt = _prefix "studiesAt"
    /// <summary>
    /// meaning is not clear. Olivier 2006-06-07
    /// Philipp: This property appears in the class description of Thesis and I think should relate a Thesis to the associated university.
    /// <see href="http://swrc.ontoware.org/ontology#school"></see></summary>
    let school = _prefix "school"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#Undergraduate"></see>
    /// </summary>
    let Undergraduate = _prefix "Undergraduate"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#student"></see>
    /// </summary>
    let student = _prefix "student"
    /// <summary>
    /// An unrefereed article from a journal, magazine or newspaper.
    ///
    /// possible german translation for "unrefereed", also: unredigiert ?!
    /// <see href="http://swrc.ontoware.org/ontology#UnrefereedArticle"></see></summary>
    let UnrefereedArticle = _prefix "UnrefereedArticle"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#VisitingProfessor"></see>
    /// </summary>
    let VisitingProfessor = _prefix "VisitingProfessor"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#abstract"></see>
    /// </summary>
    let abstract_ = _prefix "abstract"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#chapter"></see>
    /// </summary>
    let chapter = _prefix "chapter"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#citedBy"></see>
    /// </summary>
    let citedBy = _prefix "citedBy"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#date"></see>
    /// </summary>
    let date = _prefix "date"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#edition"></see>
    /// </summary>
    let edition = _prefix "edition"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#eventTitle"></see>
    /// </summary>
    let eventTitle = _prefix "eventTitle"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#title"></see>
    /// </summary>
    let title = _prefix "title"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#howpublished"></see>
    /// </summary>
    let howpublished = _prefix "howpublished"
    /// <summary>
    /// meaning not clear
    /// Philipp: Hmm, I didn't create that property, therefore i don't know the intention of it.
    /// <see href="http://swrc.ontoware.org/ontology#institution"></see></summary>
    let institution = _prefix "institution"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#isbn"></see>
    /// </summary>
    let isbn = _prefix "isbn"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#journal"></see>
    /// </summary>
    let journal = _prefix "journal"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#keywords"></see>
    /// </summary>
    let keywords = _prefix "keywords"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#location"></see>
    /// </summary>
    let location = _prefix "location"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#month"></see>
    /// </summary>
    let month = _prefix "month"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#note"></see>
    /// </summary>
    let note = _prefix "note"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#number"></see>
    /// </summary>
    let number = _prefix "number"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#pages"></see>
    /// </summary>
    let pages = _prefix "pages"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#photo"></see>
    /// </summary>
    let photo = _prefix "photo"
    /// <summary>
    /// meaning not clear. Olivier 2006-06-07
    /// Philipp: Hmm, I didn't create that property, therefore i don't know the intention of it.
    /// <see href="http://swrc.ontoware.org/ontology#product"></see></summary>
    let product = _prefix "product"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#series"></see>
    /// </summary>
    let series = _prefix "series"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#source"></see>
    /// </summary>
    let source = _prefix "source"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#type"></see>
    /// </summary>
    let type_ = _prefix "type"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#volume"></see>
    /// </summary>
    let volume = _prefix "volume"
    /// <summary>
    ///   <see href="http://swrc.ontoware.org/ontology#year"></see>
    /// </summary>
    let year = _prefix "year"
