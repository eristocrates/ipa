#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module swrc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://swrc.ontoware.org/ontology#" "swrc"

    /// <summary>
    ///   <para>rdfs:label : Wissenschaftlicher_Mitarbeiter</para>
    ///   <a href="http://swrc.ontoware.org/ontology#AcademicStaff">swrc:AcademicStaff</a>
    /// </summary>
    let AcademicStaff = _prefixId.prefix "AcademicStaff"
    /// <summary>
    ///   <para>rdfs:label : Verwaltungsangestellter</para>
    ///   <a href="http://swrc.ontoware.org/ontology#AdministrativeStaff">swrc:AdministrativeStaff</a>
    /// </summary>
    let AdministrativeStaff = _prefixId.prefix "AdministrativeStaff"
    /// <summary>
    ///   <para>rdfs:label : Artikel</para>
    ///   <para>rdfs:comment : A peer reviewed , refereed article from a journal.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Article">swrc:Article</a>
    /// </summary>
    let Article = _prefixId.prefix "Article"
    /// <summary>
    ///   <para>rdfs:label : Privatdozent</para>
    ///   <a href="http://swrc.ontoware.org/ontology#AssistantProfessor">swrc:AssistantProfessor</a>
    /// </summary>
    let AssistantProfessor = _prefixId.prefix "AssistantProfessor"
    /// <summary>
    ///   <para>rdfs:label : Ausserordentlicher_Professor</para>
    ///   <a href="http://swrc.ontoware.org/ontology#AssociateProfessor">swrc:AssociateProfessor</a>
    /// </summary>
    let AssociateProfessor = _prefixId.prefix "AssociateProfessor"
    /// <summary>
    ///   <para>rdfs:label : Verband</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Association">swrc:Association</a>
    /// </summary>
    let Association = _prefixId.prefix "Association"
    /// <summary>
    ///   <para>rdfs:label : Buch</para>
    ///   <para>rdfs:comment : A complete book, not formed from separate papers.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Book">swrc:Book</a>
    /// </summary>
    let Book = _prefixId.prefix "Book"
    /// <summary>
    ///   <para>rdfs:label : Broschuere</para>
    ///   <para>rdfs:comment : A work that is printed and bound but without a named publisher or sponsering institution.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Booklet">swrc:Booklet</a>
    /// </summary>
    let Booklet = _prefixId.prefix "Booklet"
    /// <summary>
    ///   <para>rdfs:label : Sammelband</para>
    ///   <para>rdfs:comment : A book produced from a collection of separate papers.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Collection">swrc:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>rdfs:label : Kolloquium</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Colloquium">swrc:Colloquium</a>
    /// </summary>
    let Colloquium = _prefixId.prefix "Colloquium"
    /// <summary>
    ///   <para>rdfs:label : Konferenz</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Conference">swrc:Conference</a>
    /// </summary>
    let Conference = _prefixId.prefix "Conference"
    /// <summary>
    ///   <para>rdfs:label : Fachbereich</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Department">swrc:Department</a>
    /// </summary>
    let Department = _prefixId.prefix "Department"
    /// <summary>
    ///   <para>rdfs:label : Entwicklungsvorhaben</para>
    ///   <para>rdfs:comment : disjoint with researchProject? maybe not. Olivier 2006-06-07^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#DevelopmentProject">swrc:DevelopmentProject</a>
    /// </summary>
    let DevelopmentProject = _prefixId.prefix "DevelopmentProject"
    /// <summary>
    ///   <para>rdfs:label : Diplomarbeit</para>
    ///   <a href="http://swrc.ontoware.org/ontology#DiplomaThesis">swrc:DiplomaThesis</a>
    /// </summary>
    let DiplomaThesis = _prefixId.prefix "DiplomaThesis"
    /// <summary>
    ///   <para>rdfs:comment : Dublin Core elements added.
    /// See: http://dublincore.org/documents/dces/
    ///
    /// for document types see:
    /// http://www.bsz-bw.de/diglib/medserv/konvent/metadat/dcresour.html^^xsd:string</para>
    ///   <para>rdfs:label : Dokument</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Document">swrc:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>rdfs:label : Mitarbeiter</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Employee">swrc:Employee</a>
    /// </summary>
    let Employee = _prefixId.prefix "Employee"
    /// <summary>
    ///   <para>rdfs:label : Unternehmen</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Enterprise">swrc:Enterprise</a>
    /// </summary>
    let Enterprise = _prefixId.prefix "Enterprise"
    /// <summary>
    ///   <para>rdfs:label : Ereignis</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Event">swrc:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:label : Austauschprofessor</para>
    ///   <a href="http://swrc.ontoware.org/ontology#ExchangeProfessor">swrc:ExchangeProfessor</a>
    /// </summary>
    let ExchangeProfessor = _prefixId.prefix "ExchangeProfessor"
    /// <summary>
    ///   <para>rdfs:label : Messe</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Exhibition">swrc:Exhibition</a>
    /// </summary>
    let Exhibition = _prefixId.prefix "Exhibition"
    /// <summary>
    ///   <para>rdfs:label : Fakultaetsmitglied</para>
    ///   <a href="http://swrc.ontoware.org/ontology#FacultyMember">swrc:FacultyMember</a>
    /// </summary>
    let FacultyMember = _prefixId.prefix "FacultyMember"
    /// <summary>
    ///   <para>rdfs:label : Ordentlicher_Professor</para>
    ///   <a href="http://swrc.ontoware.org/ontology#FullProfessor">swrc:FullProfessor</a>
    /// </summary>
    let FullProfessor = _prefixId.prefix "FullProfessor"
    /// <summary>
    ///   <para>rdfs:label : Absolvent</para>
    ///   <para>rdfs:comment : disjoint with undergrad? Olivier 2006-06-07
    /// Philipp: I wouldn't make it disjoint, since someone can be a bachelor-graduate, but if he is doing his master he is a master-undergraduate at the same time.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Graduate">swrc:Graduate</a>
    /// </summary>
    let Graduate = _prefixId.prefix "Graduate"
    /// <summary>
    ///   <para>rdfs:label : Oberseminar</para>
    ///   <para>rdfs:comment : see: http://www.neurolabor.de/socrate/ects_ganz.htm^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#GraduateClass">swrc:GraduateClass</a>
    /// </summary>
    let GraduateClass = _prefixId.prefix "GraduateClass"
    /// <summary>
    ///   <para>rdfs:label : Honorarprofessor</para>
    ///   <a href="http://swrc.ontoware.org/ontology#HonoraryProfessor">swrc:HonoraryProfessor</a>
    /// </summary>
    let HonoraryProfessor = _prefixId.prefix "HonoraryProfessor"
    /// <summary>
    ///   <para>rdfs:label : Teil_eines_Buches</para>
    ///   <para>rdfs:comment : A part of a book, which may be a chapter and/or range of pages.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#InBook">swrc:InBook</a>
    /// </summary>
    let InBook = _prefixId.prefix "InBook"
    /// <summary>
    ///   <para>rdfs:label : Teil_eines_Buches_mit_eigenem_Titel</para>
    ///   <para>rdfs:comment : A single paper or article from a published collection.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#InCollection">swrc:InCollection</a>
    /// </summary>
    let InCollection = _prefixId.prefix "InCollection"
    /// <summary>
    ///   <para>rdfs:label : Artikel_eines_Tagungsbandes</para>
    ///   <para>rdfs:comment : A single paper from a published workshop or conference proceedings.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#InProceedings">swrc:InProceedings</a>
    /// </summary>
    let InProceedings = _prefixId.prefix "InProceedings"
    /// <summary>
    ///   <para>rdfs:label : Institut</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Institute">swrc:Institute</a>
    /// </summary>
    let Institute = _prefixId.prefix "Institute"
    /// <summary>
    ///   <para>rdfs:label : Journal</para>
    ///   <para>rdfs:comment : An entire issue of a refereed learned journal.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Journal">swrc:Journal</a>
    /// </summary>
    let Journal = _prefixId.prefix "Journal"
    /// <summary>
    ///   <para>rdfs:label : Vortrag</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Lecture">swrc:Lecture</a>
    /// </summary>
    let Lecture = _prefixId.prefix "Lecture"
    /// <summary>
    ///   <para>rdfs:label : Lehrbeauftragter</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Lecturer">swrc:Lecturer</a>
    /// </summary>
    let Lecturer = _prefixId.prefix "Lecturer"
    /// <summary>
    ///   <para>rdfs:label : Magazin</para>
    ///   <para>rdfs:comment : An entire issue of an unrefereed journal or magazine.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Magazine">swrc:Magazine</a>
    /// </summary>
    let Magazine = _prefixId.prefix "Magazine"
    /// <summary>
    ///   <para>rdfs:label : Manager</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Manager">swrc:Manager</a>
    /// </summary>
    let Manager = _prefixId.prefix "Manager"
    /// <summary>
    ///   <para>rdfs:label : Handbuch</para>
    ///   <para>rdfs:comment : An operations manual for a product.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Manual">swrc:Manual</a>
    /// </summary>
    let Manual = _prefixId.prefix "Manual"
    /// <summary>
    ///   <para>rdfs:label : Master_Thesis</para>
    ///   <para>rdfs:comment : A university Masters thesis.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#MasterThesis">swrc:MasterThesis</a>
    /// </summary>
    let MasterThesis = _prefixId.prefix "MasterThesis"
    /// <summary>
    ///   <para>rdfs:label : Besprechung</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Meeting">swrc:Meeting</a>
    /// </summary>
    let Meeting = _prefixId.prefix "Meeting"
    /// <summary>
    ///   <para>rdfs:label : Sonstiges</para>
    ///   <para>rdfs:comment : Work of another or undetermined type. This is the default scheme value if the scheme is not explicitly stated.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Misc">swrc:Misc</a>
    /// </summary>
    let Misc = _prefixId.prefix "Misc"
    /// <summary>
    ///   <para>rdfs:label : Organisation</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Organization">swrc:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>rdfs:label : Person</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Person">swrc:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : Doktorand</para>
    ///   <a href="http://swrc.ontoware.org/ontology#PhDStudent">swrc:PhDStudent</a>
    /// </summary>
    let PhDStudent = _prefixId.prefix "PhDStudent"
    /// <summary>
    ///   <para>rdfs:label : Doktorarbeit</para>
    ///   <para>rdfs:comment : A university Doctoral thesis.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#PhDThesis">swrc:PhDThesis</a>
    /// </summary>
    let PhDThesis = _prefixId.prefix "PhDThesis"
    /// <summary>
    ///   <para>rdfs:label : Tagungsband</para>
    ///   <para>rdfs:comment : A whole published workshop or conference proceedings.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Proceedings">swrc:Proceedings</a>
    /// </summary>
    let Proceedings = _prefixId.prefix "Proceedings"
    /// <summary>
    ///   <para>rdfs:label : Produkt</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Product">swrc:Product</a>
    /// </summary>
    let Product = _prefixId.prefix "Product"
    /// <summary>
    ///   <para>rdfs:label : Emeritierter_Professor</para>
    ///   <a href="http://swrc.ontoware.org/ontology#ProfessorEmeritus">swrc:ProfessorEmeritus</a>
    /// </summary>
    let ProfessorEmeritus = _prefixId.prefix "ProfessorEmeritus"
    /// <summary>
    ///   <para>rdfs:label : Projekt</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Project">swrc:Project</a>
    /// </summary>
    let Project = _prefixId.prefix "Project"
    /// <summary>
    ///   <para>rdfs:label : Projektbesprechung</para>
    ///   <a href="http://swrc.ontoware.org/ontology#ProjectMeeting">swrc:ProjectMeeting</a>
    /// </summary>
    let ProjectMeeting = _prefixId.prefix "ProjectMeeting"
    /// <summary>
    ///   <para>rdfs:label : Projekt_Bericht</para>
    ///   <a href="http://swrc.ontoware.org/ontology#ProjectReport">swrc:ProjectReport</a>
    /// </summary>
    let ProjectReport = _prefixId.prefix "ProjectReport"
    /// <summary>
    ///   <para>rdfs:label : Publikation</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Publication">swrc:Publication</a>
    /// </summary>
    let Publication = _prefixId.prefix "Publication"
    /// <summary>
    ///   <para>rdfs:label : Bericht</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Report">swrc:Report</a>
    /// </summary>
    let Report = _prefixId.prefix "Report"
    /// <summary>
    ///   <para>rdfs:label : Forschungsgruppe</para>
    ///   <a href="http://swrc.ontoware.org/ontology#ResearchGroup">swrc:ResearchGroup</a>
    /// </summary>
    let ResearchGroup = _prefixId.prefix "ResearchGroup"
    /// <summary>
    ///   <para>rdfs:label : Forschungsarbeit</para>
    ///   <para>rdfs:comment : A piece of research work.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#ResearchPaper">swrc:ResearchPaper</a>
    /// </summary>
    let ResearchPaper = _prefixId.prefix "ResearchPaper"
    /// <summary>
    ///   <para>rdfs:label : Forschungsprojekt</para>
    ///   <a href="http://swrc.ontoware.org/ontology#ResearchProject">swrc:ResearchProject</a>
    /// </summary>
    let ResearchProject = _prefixId.prefix "ResearchProject"
    /// <summary>
    ///   <para>rdfs:label : Forschungsthema</para>
    ///   <a href="http://swrc.ontoware.org/ontology#ResearchTopic">swrc:ResearchTopic</a>
    /// </summary>
    let ResearchTopic = _prefixId.prefix "ResearchTopic"
    /// <summary>
    ///   <para>rdfs:label : wurzel</para>
    ///   <para>rdfs:comment : meaning not clear. Olivier 2006-06-07
    /// Philipp: Hmm, I didn't create that property, therefore i don't know the intention of it.
    /// ^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Root">swrc:Root</a>
    /// </summary>
    let Root = _prefixId.prefix "Root"
    /// <summary>
    ///   <para>rdfs:label : wurzelRelation</para>
    ///   <para>rdfs:comment : meaning not clear. Olivier 2006-06-07
    /// Philipp: Hmm, I didn't create that property, therefore i don't know the intention of it.
    /// ^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#RootRelation">swrc:RootRelation</a>
    /// </summary>
    let RootRelation = _prefixId.prefix "RootRelation"
    /// <summary>
    ///   <para>rdfs:label : Seminar</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Seminar">swrc:Seminar</a>
    /// </summary>
    let Seminar = _prefixId.prefix "Seminar"
    /// <summary>
    ///   <para>rdfs:label : Softwarekomponente</para>
    ///   <a href="http://swrc.ontoware.org/ontology#SoftwareComponent">swrc:SoftwareComponent</a>
    /// </summary>
    let SoftwareComponent = _prefixId.prefix "SoftwareComponent"
    /// <summary>
    ///   <para>rdfs:label : Softwareprojekt</para>
    ///   <a href="http://swrc.ontoware.org/ontology#SoftwareProject">swrc:SoftwareProject</a>
    /// </summary>
    let SoftwareProject = _prefixId.prefix "SoftwareProject"
    /// <summary>
    ///   <para>rdfs:label : Student</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Student">swrc:Student</a>
    /// </summary>
    let Student = _prefixId.prefix "Student"
    /// <summary>
    ///   <para>rdfs:label : technischer_Bericht</para>
    ///   <a href="http://swrc.ontoware.org/ontology#TechnicalReport">swrc:TechnicalReport</a>
    /// </summary>
    let TechnicalReport = _prefixId.prefix "TechnicalReport"
    /// <summary>
    ///   <para>rdfs:label : Technischer_Angestellter</para>
    ///   <a href="http://swrc.ontoware.org/ontology#TechnicalStaff">swrc:TechnicalStaff</a>
    /// </summary>
    let TechnicalStaff = _prefixId.prefix "TechnicalStaff"
    /// <summary>
    ///   <para>rdfs:label : Abschlussarbeit</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Thesis">swrc:Thesis</a>
    /// </summary>
    let Thesis = _prefixId.prefix "Thesis"
    /// <summary>
    ///   <para>rdfs:label : Thema</para>
    ///   <para>rdfs:comment : If changing this concept (or its subconcepts) consider that the swrc topic ontology depends on the foresaid one.
    /// The swrc topic ontology can be found at:
    /// http://ontoware.org/frs/download.php/187/swrc-swtopics.owl^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Topic">swrc:Topic</a>
    /// </summary>
    let Topic = _prefixId.prefix "Topic"
    /// <summary>
    ///   <para>rdfs:label : Student_ohne_Abschluss</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Undergraduate">swrc:Undergraduate</a>
    /// </summary>
    let Undergraduate = _prefixId.prefix "Undergraduate"
    /// <summary>
    ///   <para>rdfs:label : Hauptseminar</para>
    ///   <para>rdfs:comment : see: http://www.neurolabor.de/socrate/ects_ganz.htm^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#UndergraduateAdvancedClass">swrc:UndergraduateAdvancedClass</a>
    /// </summary>
    let UndergraduateAdvancedClass = _prefixId.prefix "UndergraduateAdvancedClass"

    /// <summary>
    ///   <para>rdfs:label : Proseminar </para>
    ///   <para>rdfs:comment : see: http://www.neurolabor.de/socrate/ects_ganz.htm
    ///
    /// http://dict.leo.org/cgi-bin/dict/urlexp/20030705201638^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#UndergraduateIntermediateClass">swrc:UndergraduateIntermediateClass</a>
    /// </summary>
    let UndergraduateIntermediateClass =
        _prefixId.prefix "UndergraduateIntermediateClass"

    /// <summary>
    ///   <para>rdfs:label : Unversität</para>
    ///   <a href="http://swrc.ontoware.org/ontology#University">swrc:University</a>
    /// </summary>
    let University = _prefixId.prefix "University"
    /// <summary>
    ///   <para>rdfs:label : Ein_nicht_formell_publiziertes_Dokument</para>
    ///   <para>rdfs:comment : A document with an author and title, but not formally published.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Unpublished">swrc:Unpublished</a>
    /// </summary>
    let Unpublished = _prefixId.prefix "Unpublished"
    /// <summary>
    ///   <para>rdfs:label : Nicht_begutachteter_Artikel</para>
    ///   <para>rdfs:comment : An unrefereed article from a journal, magazine or newspaper.
    ///
    /// possible german translation for "unrefereed", also: unredigiert ?!^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#UnrefereedArticle">swrc:UnrefereedArticle</a>
    /// </summary>
    let UnrefereedArticle = _prefixId.prefix "UnrefereedArticle"
    /// <summary>
    ///   <para>rdfs:label : Gastdozent</para>
    ///   <a href="http://swrc.ontoware.org/ontology#VisitingProfessor">swrc:VisitingProfessor</a>
    /// </summary>
    let VisitingProfessor = _prefixId.prefix "VisitingProfessor"
    /// <summary>
    ///   <para>rdfs:label : Workshop</para>
    ///   <a href="http://swrc.ontoware.org/ontology#Workshop">swrc:Workshop</a>
    /// </summary>
    let Workshop = _prefixId.prefix "Workshop"
    /// <summary>
    ///   <para>rdfs:label : zusammenfassung</para>
    ///   <a href="http://swrc.ontoware.org/ontology#abstract">swrc:abstract</a>
    /// </summary>
    let abstract_ = _prefixId.prefix "abstract"
    /// <summary>
    ///   <para>rdfs:label : adresse</para>
    ///   <a href="http://swrc.ontoware.org/ontology#address">swrc:address</a>
    /// </summary>
    let address = _prefixId.prefix "address"
    /// <summary>
    ///   <para>rdfs:label : zugehoerigkeit</para>
    ///   <a href="http://swrc.ontoware.org/ontology#affiliation">swrc:affiliation</a>
    /// </summary>
    let affiliation = _prefixId.prefix "affiliation"
    /// <summary>
    ///   <para>rdfs:label : beiEreignis</para>
    ///   <a href="http://swrc.ontoware.org/ontology#atEvent">swrc:atEvent</a>
    /// </summary>
    let atEvent = _prefixId.prefix "atEvent"
    /// <summary>
    ///   <para>rdfs:label : durchgefuehrtVon</para>
    ///   <a href="http://swrc.ontoware.org/ontology#carriedOutBy">swrc:carriedOutBy</a>
    /// </summary>
    let carriedOutBy = _prefixId.prefix "carriedOutBy"
    /// <summary>
    ///   <para>rdfs:label : durchfuehren</para>
    ///   <a href="http://swrc.ontoware.org/ontology#carriesOut">swrc:carriesOut</a>
    /// </summary>
    let carriesOut = _prefixId.prefix "carriesOut"
    /// <summary>
    ///   <para>rdfs:label : kapitel</para>
    ///   <a href="http://swrc.ontoware.org/ontology#chapter">swrc:chapter</a>
    /// </summary>
    let chapter = _prefixId.prefix "chapter"
    /// <summary>
    ///   <para>rdfs:label : zitiert</para>
    ///   <para>rdfs:comment : check domain. Olivier 2006-06-07
    /// Philipp: checked.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#cite">swrc:cite</a>
    /// </summary>
    let cite = _prefixId.prefix "cite"
    /// <summary>
    ///   <para>rdfs:label : zitiertVon</para>
    ///   <a href="http://swrc.ontoware.org/ontology#citedBy">swrc:citedBy</a>
    /// </summary>
    let citedBy = _prefixId.prefix "citedBy"
    /// <summary>
    ///   <para>rdfs:label : zusammenarbeitenMit</para>
    ///   <a href="http://swrc.ontoware.org/ontology#cooperateWith">swrc:cooperateWith</a>
    /// </summary>
    let cooperateWith = _prefixId.prefix "cooperateWith"
    /// <summary>
    ///   <para>rdfs:label : Herstellungsdatum</para>
    ///   <a href="http://swrc.ontoware.org/ontology#creationDate">swrc:creationDate</a>
    /// </summary>
    let creationDate = _prefixId.prefix "creationDate"
    /// <summary>
    ///   <para>rdfs:label : datum</para>
    ///   <a href="http://swrc.ontoware.org/ontology#date">swrc:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>rdfs:label : behandeltIn</para>
    ///   <a href="http://swrc.ontoware.org/ontology#dealtWithIn">swrc:dealtWithIn</a>
    /// </summary>
    let dealtWithIn = _prefixId.prefix "dealtWithIn"
    /// <summary>
    ///   <para>rdfs:label : beschreibtProjekt</para>
    ///   <a href="http://swrc.ontoware.org/ontology#describesProject">swrc:describesProject</a>
    /// </summary>
    let describesProject = _prefixId.prefix "describesProject"
    /// <summary>
    ///   <para>rdfs:label : entwickeltVon</para>
    ///   <a href="http://swrc.ontoware.org/ontology#developedBy">swrc:developedBy</a>
    /// </summary>
    let developedBy = _prefixId.prefix "developedBy"
    /// <summary>
    ///   <para>rdfs:label : entwickelt</para>
    ///   <a href="http://swrc.ontoware.org/ontology#develops">swrc:develops</a>
    /// </summary>
    let develops = _prefixId.prefix "develops"
    /// <summary>
    ///   <para>rdfs:label : ausgabe</para>
    ///   <a href="http://swrc.ontoware.org/ontology#edition">swrc:edition</a>
    /// </summary>
    let edition = _prefixId.prefix "edition"
    /// <summary>
    ///   <para>rdfs:label : editor</para>
    ///   <a href="http://swrc.ontoware.org/ontology#editor">swrc:editor</a>
    /// </summary>
    let editor = _prefixId.prefix "editor"
    /// <summary>
    ///   <para>rdfs:label : email</para>
    ///   <a href="http://swrc.ontoware.org/ontology#email">swrc:email</a>
    /// </summary>
    let email = _prefixId.prefix "email"
    /// <summary>
    ///   <para>rdfs:label : beschaeftigt</para>
    ///   <a href="http://swrc.ontoware.org/ontology#employs">swrc:employs</a>
    /// </summary>
    let employs = _prefixId.prefix "employs"
    /// <summary>
    ///   <para>rdfs:label : endDatum</para>
    ///   <a href="http://swrc.ontoware.org/ontology#endDate">swrc:endDate</a>
    /// </summary>
    let endDate = _prefixId.prefix "endDate"
    /// <summary>
    ///   <para>rdfs:label : ereignisTitel</para>
    ///   <a href="http://swrc.ontoware.org/ontology#eventTitle">swrc:eventTitle</a>
    /// </summary>
    let eventTitle = _prefixId.prefix "eventTitle"
    /// <summary>
    ///   <para>rdfs:label : fax</para>
    ///   <a href="http://swrc.ontoware.org/ontology#fax">swrc:fax</a>
    /// </summary>
    let fax = _prefixId.prefix "fax"
    /// <summary>
    ///   <para>rdfs:label : finanziertVon</para>
    ///   <a href="http://swrc.ontoware.org/ontology#financedBy">swrc:financedBy</a>
    /// </summary>
    let financedBy = _prefixId.prefix "financedBy"
    /// <summary>
    ///   <para>rdfs:label : finanziert</para>
    ///   <a href="http://swrc.ontoware.org/ontology#finances">swrc:finances</a>
    /// </summary>
    let finances = _prefixId.prefix "finances"
    /// <summary>
    ///   <para>rdfs:label : vorname</para>
    ///   <a href="http://swrc.ontoware.org/ontology#firstName">swrc:firstName</a>
    /// </summary>
    let firstName = _prefixId.prefix "firstName"
    /// <summary>
    ///   <para>rdfs:label : gehaltenVon</para>
    ///   <para>rdfs:comment : check domain. Olivier 2006-06-07
    /// Philipp: checked.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#givenBy">swrc:givenBy</a>
    /// </summary>
    let givenBy = _prefixId.prefix "givenBy"
    /// <summary>
    ///   <para>rdfs:label : hatTeilEreignis</para>
    ///   <para>rdfs:comment : Example: FIFA World Cup 2006 hasPartEvent Final^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#hasPartEvent">swrc:hasPartEvent</a>
    /// </summary>
    let hasPartEvent = _prefixId.prefix "hasPartEvent"
    /// <summary>
    ///   <para>rdfs:label : hatTeile</para>
    ///   <a href="http://swrc.ontoware.org/ontology#hasParts">swrc:hasParts</a>
    /// </summary>
    let hasParts = _prefixId.prefix "hasParts"
    /// <summary>
    ///   <para>rdfs:label : leiter</para>
    ///   <a href="http://swrc.ontoware.org/ontology#head">swrc:head</a>
    /// </summary>
    let head = _prefixId.prefix "head"
    /// <summary>
    ///   <para>rdfs:label : leiterVon</para>
    ///   <a href="http://swrc.ontoware.org/ontology#headOf">swrc:headOf</a>
    /// </summary>
    let headOf = _prefixId.prefix "headOf"
    /// <summary>
    ///   <para>rdfs:label : leiterVonGruppe</para>
    ///   <para>rdfs:comment : added domain and range. Olivier 2006-06-07^^xsd:stringrdfs:comment : made a subproperty of headOf. Olivier 2006-06-07^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#headOfGroup">swrc:headOfGroup</a>
    /// </summary>
    let headOfGroup = _prefixId.prefix "headOfGroup"
    /// <summary>
    ///   <para>rdfs:label : homepage</para>
    ///   <a href="http://swrc.ontoware.org/ontology#homepage">swrc:homepage</a>
    /// </summary>
    let homepage = _prefixId.prefix "homepage"
    /// <summary>
    ///   <para>rdfs:label : veroeffentlichungsArt</para>
    ///   <a href="http://swrc.ontoware.org/ontology#howpublished">swrc:howpublished</a>
    /// </summary>
    let howpublished = _prefixId.prefix "howpublished"
    /// <summary>
    ///   <para>rdfs:label : einrichtung</para>
    ///   <para>rdfs:comment : meaning not clear
    /// Philipp: Hmm, I didn't create that property, therefore i don't know the intention of it.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#institution">swrc:institution</a>
    /// </summary>
    let institution = _prefixId.prefix "institution"
    /// <summary>
    ///   <para>rdfs:label : ueber</para>
    ///   <para>rdfs:comment : check domain. Olivier 2006-06-07
    /// Philipp: checked.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#isAbout">swrc:isAbout</a>
    /// </summary>
    let isAbout = _prefixId.prefix "isAbout"
    /// <summary>
    ///   <para>rdfs:label : wirdBearbeitetVon</para>
    ///   <a href="http://swrc.ontoware.org/ontology#isWorkedOnBy">swrc:isWorkedOnBy</a>
    /// </summary>
    let isWorkedOnBy = _prefixId.prefix "isWorkedOnBy"
    /// <summary>
    ///   <para>rdfs:label : isbn</para>
    ///   <a href="http://swrc.ontoware.org/ontology#isbn">swrc:isbn</a>
    /// </summary>
    let isbn = _prefixId.prefix "isbn"
    /// <summary>
    ///   <para>rdfs:label : journal</para>
    ///   <a href="http://swrc.ontoware.org/ontology#journal">swrc:journal</a>
    /// </summary>
    let journal = _prefixId.prefix "journal"
    /// <summary>
    ///   <para>rdfs:label : schlagwoerter</para>
    ///   <a href="http://swrc.ontoware.org/ontology#keywords">swrc:keywords</a>
    /// </summary>
    let keywords = _prefixId.prefix "keywords"
    /// <summary>
    ///   <para>rdfs:label : nachname</para>
    ///   <a href="http://swrc.ontoware.org/ontology#lastName">swrc:lastName</a>
    /// </summary>
    let lastName = _prefixId.prefix "lastName"
    /// <summary>
    ///   <para>rdfs:label : ort</para>
    ///   <a href="http://swrc.ontoware.org/ontology#location">swrc:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>rdfs:label : hatMitglied</para>
    ///   <para>rdfs:comment : can an organization be a member of another organization? olivier 2006-06-07
    /// Philipp: Hmm could be possible. Therefore I added Organization to the range that one can state: Organization (has)member Organization.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#member">swrc:member</a>
    /// </summary>
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>rdfs:label : mitgliedVonPC</para>
    ///   <a href="http://swrc.ontoware.org/ontology#memberOfPC">swrc:memberOfPC</a>
    /// </summary>
    let memberOfPC = _prefixId.prefix "memberOfPC"
    /// <summary>
    ///   <para>rdfs:label : monat</para>
    ///   <a href="http://swrc.ontoware.org/ontology#month">swrc:month</a>
    /// </summary>
    let month = _prefixId.prefix "month"
    /// <summary>
    ///   <para>rdfs:label : name</para>
    ///   <a href="http://swrc.ontoware.org/ontology#name">swrc:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : bemerkung</para>
    ///   <a href="http://swrc.ontoware.org/ontology#note">swrc:note</a>
    /// </summary>
    let note = _prefixId.prefix "note"
    /// <summary>
    ///   <para>rdfs:label : nummer</para>
    ///   <a href="http://swrc.ontoware.org/ontology#number">swrc:number</a>
    /// </summary>
    let number = _prefixId.prefix "number"
    /// <summary>
    ///   <para>rdfs:label : organisation</para>
    ///   <para>rdfs:comment : meaning not clear. Olivier 2006-06-07
    /// Philipp: This property appears in the class definition of swrc:Document. I think it is obsolete, since you may link a document via the dc:creator, dc:contributor or dc:publisher property to an organization.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#organization">swrc:organization</a>
    /// </summary>
    let organization = _prefixId.prefix "organization"
    /// <summary>
    ///   <para>rdfs:label : veranstalterOderVorsitzenderVon</para>
    ///   <a href="http://swrc.ontoware.org/ontology#organizerOrChairOf">swrc:organizerOrChairOf</a>
    /// </summary>
    let organizerOrChairOf = _prefixId.prefix "organizerOrChairOf"
    /// <summary>
    ///   <para>rdfs:label : ergebnisDokument</para>
    ///   <a href="http://swrc.ontoware.org/ontology#outcomeDocument">swrc:outcomeDocument</a>
    /// </summary>
    let outcomeDocument = _prefixId.prefix "outcomeDocument"
    /// <summary>
    ///   <para>rdfs:label : ergebnisProdukt</para>
    ///   <a href="http://swrc.ontoware.org/ontology#outcomeProduct">swrc:outcomeProduct</a>
    /// </summary>
    let outcomeProduct = _prefixId.prefix "outcomeProduct"
    /// <summary>
    ///   <para>rdfs:label : seiten</para>
    ///   <a href="http://swrc.ontoware.org/ontology#pages">swrc:pages</a>
    /// </summary>
    let pages = _prefixId.prefix "pages"
    /// <summary>
    ///   <para>rdfs:label : teilnehmer</para>
    ///   <a href="http://swrc.ontoware.org/ontology#participant">swrc:participant</a>
    /// </summary>
    let participant = _prefixId.prefix "participant"
    /// <summary>
    ///   <para>rdfs:label : telefon</para>
    ///   <a href="http://swrc.ontoware.org/ontology#phone">swrc:phone</a>
    /// </summary>
    let phone = _prefixId.prefix "phone"
    /// <summary>
    ///   <para>rdfs:label : foto</para>
    ///   <a href="http://swrc.ontoware.org/ontology#photo">swrc:photo</a>
    /// </summary>
    let photo = _prefixId.prefix "photo"
    /// <summary>
    ///   <para>rdfs:label : preis</para>
    ///   <a href="http://swrc.ontoware.org/ontology#price">swrc:price</a>
    /// </summary>
    let price = _prefixId.prefix "price"
    /// <summary>
    ///   <para>rdfs:label : produkt</para>
    ///   <para>rdfs:comment : meaning not clear. Olivier 2006-06-07
    /// Philipp: Hmm, I didn't create that property, therefore i don't know the intention of it.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#product">swrc:product</a>
    /// </summary>
    let product = _prefixId.prefix "product"
    /// <summary>
    ///   <para>rdfs:label : projektInfo</para>
    ///   <a href="http://swrc.ontoware.org/ontology#projectInfo">swrc:projectInfo</a>
    /// </summary>
    let projectInfo = _prefixId.prefix "projectInfo"
    /// <summary>
    ///   <para>rdfs:label : publikation</para>
    ///   <para>rdfs:comment : hasPublication (?). Olivier 2006-06-07
    /// Philipp: Yes, I think it is meant as "hasPublication". Anytime you have just the verb, it is meant as has + verb in a property.^^xsd:stringrdfs:comment : check domain. Olivier 2006-06-07
    /// Philipp: checked.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#publication">swrc:publication</a>
    /// </summary>
    let publication = _prefixId.prefix "publication"
    /// <summary>
    ///   <para>rdfs:label : herausgeberVon</para>
    ///   <para>rdfs:comment : check domain. Olivier 2006-06-07
    /// Philipp: checked.^^xsd:stringrdfs:comment : check range. Olivier 2006-06-07
    /// Philipp: checked.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#publisherOf">swrc:publisherOf</a>
    /// </summary>
    let publisherOf = _prefixId.prefix "publisherOf"
    /// <summary>
    ///   <para>rdfs:label : schule</para>
    ///   <para>rdfs:comment : meaning is not clear. Olivier 2006-06-07
    /// Philipp: This property appears in the class description of Thesis and I think should relate a Thesis to the associated university.^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#school">swrc:school</a>
    /// </summary>
    let school = _prefixId.prefix "school"
    /// <summary>
    ///   <para>rdfs:label : serie</para>
    ///   <a href="http://swrc.ontoware.org/ontology#series">swrc:series</a>
    /// </summary>
    let series = _prefixId.prefix "series"
    /// <summary>
    ///   <para>rdfs:label : quelle</para>
    ///   <a href="http://swrc.ontoware.org/ontology#source">swrc:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:label : startDatum</para>
    ///   <a href="http://swrc.ontoware.org/ontology#startDate">swrc:startDate</a>
    /// </summary>
    let startDate = _prefixId.prefix "startDate"
    /// <summary>
    ///   <para>rdfs:label : status</para>
    ///   <a href="http://swrc.ontoware.org/ontology#status">swrc:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfs:label : student</para>
    ///   <a href="http://swrc.ontoware.org/ontology#student">swrc:student</a>
    /// </summary>
    let student = _prefixId.prefix "student"
    /// <summary>
    ///   <para>rdfs:label : studiertAn</para>
    ///   <a href="http://swrc.ontoware.org/ontology#studiesAt">swrc:studiesAt</a>
    /// </summary>
    let studiesAt = _prefixId.prefix "studiesAt"
    /// <summary>
    ///   <para>rdfs:label : betreut</para>
    ///   <a href="http://swrc.ontoware.org/ontology#supervises">swrc:supervises</a>
    /// </summary>
    let supervises = _prefixId.prefix "supervises"
    /// <summary>
    ///   <para>rdfs:label : hatBetreuer</para>
    ///   <a href="http://swrc.ontoware.org/ontology#supervisor">swrc:supervisor</a>
    /// </summary>
    let supervisor = _prefixId.prefix "supervisor"
    /// <summary>
    ///   <para>rdfs:label : fachbericht</para>
    ///   <para>rdfs:comment : check domain. Olivier 2006-06-07
    /// Philipp: checked.
    /// ^^xsd:string</para>
    ///   <a href="http://swrc.ontoware.org/ontology#technicalReport">swrc:technicalReport</a>
    /// </summary>
    let technicalReport = _prefixId.prefix "technicalReport"
    /// <summary>
    ///   <para>rdfs:label : titel</para>
    ///   <a href="http://swrc.ontoware.org/ontology#title">swrc:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : typ</para>
    ///   <a href="http://swrc.ontoware.org/ontology#type">swrc:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>rdfs:label : verkaeufer</para>
    ///   <a href="http://swrc.ontoware.org/ontology#vendor">swrc:vendor</a>
    /// </summary>
    let vendor = _prefixId.prefix "vendor"
    /// <summary>
    ///   <para>rdfs:label : volume</para>
    ///   <a href="http://swrc.ontoware.org/ontology#volume">swrc:volume</a>
    /// </summary>
    let volume = _prefixId.prefix "volume"
    /// <summary>
    ///   <para>rdfs:label : arbeitetAnProjekt</para>
    ///   <a href="http://swrc.ontoware.org/ontology#worksAtProject">swrc:worksAtProject</a>
    /// </summary>
    let worksAtProject = _prefixId.prefix "worksAtProject"
    /// <summary>
    ///   <para>rdfs:label : jahr</para>
    ///   <a href="http://swrc.ontoware.org/ontology#year">swrc:year</a>
    /// </summary>
    let year = _prefixId.prefix "year"
