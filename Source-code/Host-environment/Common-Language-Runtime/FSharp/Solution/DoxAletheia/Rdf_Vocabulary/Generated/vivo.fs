namespace http.vivoweb.org.ontology.core.hash

open DoxAletheia

module vivo =
    let _namespace_name = "http://vivoweb.org/ontology/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#GeographicRegion"></see>
    /// </summary>
    let GeographicRegion = _prefix "GeographicRegion"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#GeopoliticalEntity"></see>
    /// </summary>
    let GeopoliticalEntity = _prefix "GeopoliticalEntity"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Country"></see>
    /// </summary>
    let Country = _prefix "Country"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#identifier"></see>
    /// </summary>
    let identifier = _prefix "identifier"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hideFromDisplay"></see>
    /// </summary>
    let hideFromDisplay = _prefix "hideFromDisplay"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#dateTimeInterval"></see>
    /// </summary>
    let dateTimeInterval = _prefix "dateTimeInterval"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#DateTimeInterval"></see>
    /// </summary>
    let DateTimeInterval = _prefix "DateTimeInterval"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#description"></see>
    /// </summary>
    let description = _prefix "description"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Project"></see>
    /// </summary>
    let Project = _prefix "Project"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Center"></see>
    /// </summary>
    let Center = _prefix "Center"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Laboratory"></see>
    /// </summary>
    let Laboratory = _prefix "Laboratory"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasFundingVehicle"></see>
    /// </summary>
    let hasFundingVehicle = _prefix "hasFundingVehicle"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Grant"></see>
    /// </summary>
    let Grant = _prefix "Grant"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#contactInformation"></see>
    /// </summary>
    let contactInformation = _prefix "contactInformation"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#freetextKeyword"></see>
    /// </summary>
    let freetextKeyword = _prefix "freetextKeyword"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasSubjectArea"></see>
    /// </summary>
    let hasSubjectArea = _prefix "hasSubjectArea"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#geographicFocus"></see>
    /// </summary>
    let geographicFocus = _prefix "geographicFocus"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#dateTimeValue"></see>
    /// </summary>
    let dateTimeValue = _prefix "dateTimeValue"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#DateTimeValue"></see>
    /// </summary>
    let DateTimeValue = _prefix "DateTimeValue"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#GeographicLocation"></see>
    /// </summary>
    let GeographicLocation = _prefix "GeographicLocation"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasPublicationVenue"></see>
    /// </summary>
    let hasPublicationVenue = _prefix "hasPublicationVenue"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#placeOfPublication"></see>
    /// </summary>
    let placeOfPublication = _prefix "placeOfPublication"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#publisher"></see>
    /// </summary>
    let publisher = _prefix "publisher"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#abbreviation"></see>
    /// </summary>
    let abbreviation = _prefix "abbreviation"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#features"></see>
    /// </summary>
    let features = _prefix "features"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Dataset"></see>
    /// </summary>
    let Dataset = _prefix "Dataset"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#dateIssued"></see>
    /// </summary>
    let dateIssued = _prefix "dateIssued"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AcademicDegree"></see>
    /// </summary>
    let AcademicDegree = _prefix "AcademicDegree"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#reviewedIn"></see>
    /// </summary>
    let reviewedIn = _prefix "reviewedIn"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#translatorOf"></see>
    /// </summary>
    let translatorOf = _prefix "translatorOf"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Abstract"></see>
    /// </summary>
    let Abstract = _prefix "Abstract"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AcademicDepartment"></see>
    /// </summary>
    let AcademicDepartment = _prefix "AcademicDepartment"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Department"></see>
    /// </summary>
    let Department = _prefix "Department"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AcademicTerm"></see>
    /// </summary>
    let AcademicTerm = _prefix "AcademicTerm"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AcademicYear"></see>
    /// </summary>
    let AcademicYear = _prefix "AcademicYear"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AdministratorRole"></see>
    /// </summary>
    let AdministratorRole = _prefix "AdministratorRole"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AdviseeRole"></see>
    /// </summary>
    let AdviseeRole = _prefix "AdviseeRole"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AdvisingProcess"></see>
    /// </summary>
    let AdvisingProcess = _prefix "AdvisingProcess"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AdvisingRelationship"></see>
    /// </summary>
    let AdvisingRelationship = _prefix "AdvisingRelationship"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#relates"></see>
    /// </summary>
    let relates = _prefix "relates"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Relationship"></see>
    /// </summary>
    let Relationship = _prefix "Relationship"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AdvisorRole"></see>
    /// </summary>
    let AdvisorRole = _prefix "AdvisorRole"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Association"></see>
    /// </summary>
    let Association = _prefix "Association"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AttendeeRole"></see>
    /// </summary>
    let AttendeeRole = _prefix "AttendeeRole"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AttendingProcess"></see>
    /// </summary>
    let AttendingProcess = _prefix "AttendingProcess"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Authorship"></see>
    /// </summary>
    let Authorship = _prefix "Authorship"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Award"></see>
    /// </summary>
    let Award = _prefix "Award"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AwardReceipt"></see>
    /// </summary>
    let AwardReceipt = _prefix "AwardReceipt"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#assignedBy"></see>
    /// </summary>
    let assignedBy = _prefix "assignedBy"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AwardedDegree"></see>
    /// </summary>
    let AwardedDegree = _prefix "AwardedDegree"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Blog"></see>
    /// </summary>
    let Blog = _prefix "Blog"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#BlogPosting"></see>
    /// </summary>
    let BlogPosting = _prefix "BlogPosting"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Building"></see>
    /// </summary>
    let Building = _prefix "Building"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Room"></see>
    /// </summary>
    let Room = _prefix "Room"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Facility"></see>
    /// </summary>
    let Facility = _prefix "Facility"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Campus"></see>
    /// </summary>
    let Campus = _prefix "Campus"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#CaseStudy"></see>
    /// </summary>
    let CaseStudy = _prefix "CaseStudy"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Catalog"></see>
    /// </summary>
    let Catalog = _prefix "Catalog"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Certificate"></see>
    /// </summary>
    let Certificate = _prefix "Certificate"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Credential"></see>
    /// </summary>
    let Credential = _prefix "Credential"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Certification"></see>
    /// </summary>
    let Certification = _prefix "Certification"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#IssuedCredential"></see>
    /// </summary>
    let IssuedCredential = _prefix "IssuedCredential"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ClinicalOrganization"></see>
    /// </summary>
    let ClinicalOrganization = _prefix "ClinicalOrganization"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ClinicalRole"></see>
    /// </summary>
    let ClinicalRole = _prefix "ClinicalRole"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#CoPrincipalInvestigatorRole"></see>
    /// </summary>
    let CoPrincipalInvestigatorRole = _prefix "CoPrincipalInvestigatorRole"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#InvestigatorRole"></see>
    /// </summary>
    let InvestigatorRole = _prefix "InvestigatorRole"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#College"></see>
    /// </summary>
    let College = _prefix "College"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Committee"></see>
    /// </summary>
    let Committee = _prefix "Committee"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Company"></see>
    /// </summary>
    let Company = _prefix "Company"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Competition"></see>
    /// </summary>
    let Competition = _prefix "Competition"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ConferencePaper"></see>
    /// </summary>
    let ConferencePaper = _prefix "ConferencePaper"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ConferencePoster"></see>
    /// </summary>
    let ConferencePoster = _prefix "ConferencePoster"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ConferenceSeries"></see>
    /// </summary>
    let ConferenceSeries = _prefix "ConferenceSeries"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#EventSeries"></see>
    /// </summary>
    let EventSeries = _prefix "EventSeries"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Consortium"></see>
    /// </summary>
    let Consortium = _prefix "Consortium"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Continent"></see>
    /// </summary>
    let Continent = _prefix "Continent"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Contract"></see>
    /// </summary>
    let Contract = _prefix "Contract"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#supportedInformationResource"></see>
    /// </summary>
    let supportedInformationResource = _prefix "supportedInformationResource"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#CoreLaboratory"></see>
    /// </summary>
    let CoreLaboratory = _prefix "CoreLaboratory"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ServiceProvidingLaboratory"></see>
    /// </summary>
    let ServiceProvidingLaboratory = _prefix "ServiceProvidingLaboratory"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#County"></see>
    /// </summary>
    let County = _prefix "County"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Course"></see>
    /// </summary>
    let Course = _prefix "Course"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#courseCredits"></see>
    /// </summary>
    let courseCredits = _prefix "courseCredits"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#validIn"></see>
    /// </summary>
    let validIn = _prefix "validIn"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasGoverningAuthority"></see>
    /// </summary>
    let hasGoverningAuthority = _prefix "hasGoverningAuthority"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Database"></see>
    /// </summary>
    let Database = _prefix "Database"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#DateTimeValuePrecision"></see>
    /// </summary>
    let DateTimeValuePrecision = _prefix "DateTimeValuePrecision"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Division"></see>
    /// </summary>
    let Division = _prefix "Division"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ExtensionUnit"></see>
    /// </summary>
    let ExtensionUnit = _prefix "ExtensionUnit"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#EditorRole"></see>
    /// </summary>
    let EditorRole = _prefix "EditorRole"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#EditorialArticle"></see>
    /// </summary>
    let EditorialArticle = _prefix "EditorialArticle"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Editorship"></see>
    /// </summary>
    let Editorship = _prefix "Editorship"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#EducationalProcess"></see>
    /// </summary>
    let EducationalProcess = _prefix "EducationalProcess"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#supplementalInformation"></see>
    /// </summary>
    let supplementalInformation = _prefix "supplementalInformation"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#EmeritusFaculty"></see>
    /// </summary>
    let EmeritusFaculty = _prefix "EmeritusFaculty"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#EmeritusLibrarian"></see>
    /// </summary>
    let EmeritusLibrarian = _prefix "EmeritusLibrarian"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#EmeritusProfessor"></see>
    /// </summary>
    let EmeritusProfessor = _prefix "EmeritusProfessor"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Equipment"></see>
    /// </summary>
    let Equipment = _prefix "Equipment"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Exhibit"></see>
    /// </summary>
    let Exhibit = _prefix "Exhibit"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#F1000Link"></see>
    /// </summary>
    let F1000Link = _prefix "F1000Link"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#FacultyAdministrativePosition"></see>
    /// </summary>
    let FacultyAdministrativePosition = _prefix "FacultyAdministrativePosition"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Position"></see>
    /// </summary>
    let Position = _prefix "Position"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#FacultyMember"></see>
    /// </summary>
    let FacultyMember = _prefix "FacultyMember"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#FacultyMentoringRelationship"></see>
    /// </summary>
    let FacultyMentoringRelationship = _prefix "FacultyMentoringRelationship"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#FacultyPosition"></see>
    /// </summary>
    let FacultyPosition = _prefix "FacultyPosition"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Foundation"></see>
    /// </summary>
    let Foundation = _prefix "Foundation"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#FundingOrganization"></see>
    /// </summary>
    let FundingOrganization = _prefix "FundingOrganization"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#assigns"></see>
    /// </summary>
    let assigns = _prefix "assigns"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Location"></see>
    /// </summary>
    let Location = _prefix "Location"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#GovernmentAgency"></see>
    /// </summary>
    let GovernmentAgency = _prefix "GovernmentAgency"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#GraduateAdvisingRelationship"></see>
    /// </summary>
    let GraduateAdvisingRelationship = _prefix "GraduateAdvisingRelationship"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#GraduateStudent"></see>
    /// </summary>
    let GraduateStudent = _prefix "GraduateStudent"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Student"></see>
    /// </summary>
    let Student = _prefix "Student"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Hospital"></see>
    /// </summary>
    let Hospital = _prefix "Hospital"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Institute"></see>
    /// </summary>
    let Institute = _prefix "Institute"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Internship"></see>
    /// </summary>
    let Internship = _prefix "Internship"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ResearcherRole"></see>
    /// </summary>
    let ResearcherRole = _prefix "ResearcherRole"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#InvitedTalk"></see>
    /// </summary>
    let InvitedTalk = _prefix "InvitedTalk"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Presentation"></see>
    /// </summary>
    let Presentation = _prefix "Presentation"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#expirationDate"></see>
    /// </summary>
    let expirationDate = _prefix "expirationDate"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#LeaderRole"></see>
    /// </summary>
    let LeaderRole = _prefix "LeaderRole"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Librarian"></see>
    /// </summary>
    let Librarian = _prefix "Librarian"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#LibrarianPosition"></see>
    /// </summary>
    let LibrarianPosition = _prefix "LibrarianPosition"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Library"></see>
    /// </summary>
    let Library = _prefix "Library"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#License"></see>
    /// </summary>
    let License = _prefix "License"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Licensure"></see>
    /// </summary>
    let Licensure = _prefix "Licensure"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#MedicalResidency"></see>
    /// </summary>
    let MedicalResidency = _prefix "MedicalResidency"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Meeting"></see>
    /// </summary>
    let Meeting = _prefix "Meeting"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#MemberRole"></see>
    /// </summary>
    let MemberRole = _prefix "MemberRole"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Museum"></see>
    /// </summary>
    let Museum = _prefix "Museum"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#NewsRelease"></see>
    /// </summary>
    let NewsRelease = _prefix "NewsRelease"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Newsletter"></see>
    /// </summary>
    let Newsletter = _prefix "Newsletter"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#NonAcademic"></see>
    /// </summary>
    let NonAcademic = _prefix "NonAcademic"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#NonAcademicPosition"></see>
    /// </summary>
    let NonAcademicPosition = _prefix "NonAcademicPosition"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#NonFacultyAcademic"></see>
    /// </summary>
    let NonFacultyAcademic = _prefix "NonFacultyAcademic"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#NonFacultyAcademicPosition"></see>
    /// </summary>
    let NonFacultyAcademicPosition = _prefix "NonFacultyAcademicPosition"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#OrganizerRole"></see>
    /// </summary>
    let OrganizerRole = _prefix "OrganizerRole"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#OrganizingProcess"></see>
    /// </summary>
    let OrganizingProcess = _prefix "OrganizingProcess"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#OutreachProviderRole"></see>
    /// </summary>
    let OutreachProviderRole = _prefix "OutreachProviderRole"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#PeerReviewerRole"></see>
    /// </summary>
    let PeerReviewerRole = _prefix "PeerReviewerRole"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ReviewerRole"></see>
    /// </summary>
    let ReviewerRole = _prefix "ReviewerRole"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#PopulatedPlace"></see>
    /// </summary>
    let PopulatedPlace = _prefix "PopulatedPlace"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#rank"></see>
    /// </summary>
    let rank = _prefix "rank"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Postdoc"></see>
    /// </summary>
    let Postdoc = _prefix "Postdoc"

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#PostdocOrFellowAdvisingRelationship"></see>
    /// </summary>
    let PostdocOrFellowAdvisingRelationship =
        _prefix "PostdocOrFellowAdvisingRelationship"

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#PostdocPosition"></see>
    /// </summary>
    let PostdocPosition = _prefix "PostdocPosition"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#PostdoctoralTraining"></see>
    /// </summary>
    let PostdoctoralTraining = _prefix "PostdoctoralTraining"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#PresenterRole"></see>
    /// </summary>
    let PresenterRole = _prefix "PresenterRole"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#PresentingProcess"></see>
    /// </summary>
    let PresentingProcess = _prefix "PresentingProcess"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#PrimaryPosition"></see>
    /// </summary>
    let PrimaryPosition = _prefix "PrimaryPosition"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#PrincipalInvestigatorRole"></see>
    /// </summary>
    let PrincipalInvestigatorRole = _prefix "PrincipalInvestigatorRole"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#PrivateCompany"></see>
    /// </summary>
    let PrivateCompany = _prefix "PrivateCompany"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Program"></see>
    /// </summary>
    let Program = _prefix "Program"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Publisher"></see>
    /// </summary>
    let Publisher = _prefix "Publisher"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ResearchOrganization"></see>
    /// </summary>
    let ResearchOrganization = _prefix "ResearchOrganization"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ResearchProposal"></see>
    /// </summary>
    let ResearchProposal = _prefix "ResearchProposal"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Review"></see>
    /// </summary>
    let Review = _prefix "Review"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#School"></see>
    /// </summary>
    let School = _prefix "School"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Score"></see>
    /// </summary>
    let Score = _prefix "Score"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Screenplay"></see>
    /// </summary>
    let Screenplay = _prefix "Screenplay"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#SeminarSeries"></see>
    /// </summary>
    let SeminarSeries = _prefix "SeminarSeries"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Speech"></see>
    /// </summary>
    let Speech = _prefix "Speech"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#StateOrProvince"></see>
    /// </summary>
    let StateOrProvince = _prefix "StateOrProvince"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#StudentOrganization"></see>
    /// </summary>
    let StudentOrganization = _prefix "StudentOrganization"
    /// <summary>
    /// For example, the Midwest, northeast U.S.
    /// <see href="http://vivoweb.org/ontology/core#SubnationalRegion"></see></summary>
    let SubnationalRegion = _prefix "SubnationalRegion"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#TeacherRole"></see>
    /// </summary>
    let TeacherRole = _prefix "TeacherRole"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Team"></see>
    /// </summary>
    let Team = _prefix "Team"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Translation"></see>
    /// </summary>
    let Translation = _prefix "Translation"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#UndergraduateAdvisingRelationship"></see>
    /// </summary>
    let UndergraduateAdvisingRelationship = _prefix "UndergraduateAdvisingRelationship"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#UndergraduateStudent"></see>
    /// </summary>
    let UndergraduateStudent = _prefix "UndergraduateStudent"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#University"></see>
    /// </summary>
    let University = _prefix "University"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Video"></see>
    /// </summary>
    let Video = _prefix "Video"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#WorkingPaper"></see>
    /// </summary>
    let WorkingPaper = _prefix "WorkingPaper"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#WorkshopSeries"></see>
    /// </summary>
    let WorkshopSeries = _prefix "WorkshopSeries"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#affiliatedOrganization"></see>
    /// </summary>
    let affiliatedOrganization = _prefix "affiliatedOrganization"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#assignee"></see>
    /// </summary>
    let assignee = _prefix "assignee"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#assigneeFor"></see>
    /// </summary>
    let assigneeFor = _prefix "assigneeFor"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#cclCode"></see>
    /// </summary>
    let cclCode = _prefix "cclCode"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#conceptAssociatedWith"></see>
    /// </summary>
    let conceptAssociatedWith = _prefix "conceptAssociatedWith"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#contributingRole"></see>
    /// </summary>
    let contributingRole = _prefix "contributingRole"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#roleContributesTo"></see>
    /// </summary>
    let roleContributesTo = _prefix "roleContributesTo"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#dateFiled"></see>
    /// </summary>
    let dateFiled = _prefix "dateFiled"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#dateTime"></see>
    /// </summary>
    let dateTime = _prefix "dateTime"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#dateTimePrecision"></see>
    /// </summary>
    let dateTimePrecision = _prefix "dateTimePrecision"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#degreeCandidacy"></see>
    /// </summary>
    let degreeCandidacy = _prefix "degreeCandidacy"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#departmentOrSchool"></see>
    /// </summary>
    let departmentOrSchool = _prefix "departmentOrSchool"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#distributes"></see>
    /// </summary>
    let distributes = _prefix "distributes"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#distributesFundingFrom"></see>
    /// </summary>
    let distributesFundingFrom = _prefix "distributesFundingFrom"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#providesFundingThrough"></see>
    /// </summary>
    let providesFundingThrough = _prefix "providesFundingThrough"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#eRACommonsId"></see>
    /// </summary>
    let eRACommonsId = _prefix "eRACommonsId"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#eligibleFor"></see>
    /// </summary>
    let eligibleFor = _prefix "eligibleFor"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#end"></see>
    /// </summary>
    let end_ = _prefix "end"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#entryTerm"></see>
    /// </summary>
    let entryTerm = _prefix "entryTerm"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#equipmentFor"></see>
    /// </summary>
    let equipmentFor = _prefix "equipmentFor"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#facilityFor"></see>
    /// </summary>
    let facilityFor = _prefix "facilityFor"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasFacility"></see>
    /// </summary>
    let hasFacility = _prefix "hasFacility"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#featuredIn"></see>
    /// </summary>
    let featuredIn = _prefix "featuredIn"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#fundingVehicleFor"></see>
    /// </summary>
    let fundingVehicleFor = _prefix "fundingVehicleFor"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#supports"></see>
    /// </summary>
    let supports = _prefix "supports"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#geographicFocusOf"></see>
    /// </summary>
    let geographicFocusOf = _prefix "geographicFocusOf"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#governingAuthorityFor"></see>
    /// </summary>
    let governingAuthorityFor = _prefix "governingAuthorityFor"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#grantDirectCosts"></see>
    /// </summary>
    let grantDirectCosts = _prefix "grantDirectCosts"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#grantSubcontractedThrough"></see>
    /// </summary>
    let grantSubcontractedThrough = _prefix "grantSubcontractedThrough"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasAssociatedConcept"></see>
    /// </summary>
    let hasAssociatedConcept = _prefix "hasAssociatedConcept"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasCollaborator"></see>
    /// </summary>
    let hasCollaborator = _prefix "hasCollaborator"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasEquipment"></see>
    /// </summary>
    let hasEquipment = _prefix "hasEquipment"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasMonetaryAmount"></see>
    /// </summary>
    let hasMonetaryAmount = _prefix "hasMonetaryAmount"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasPredecessorOrganization"></see>
    /// </summary>
    let hasPredecessorOrganization = _prefix "hasPredecessorOrganization"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasSuccessorOrganization"></see>
    /// </summary>
    let hasSuccessorOrganization = _prefix "hasSuccessorOrganization"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasPrerequisite"></see>
    /// </summary>
    let hasPrerequisite = _prefix "hasPrerequisite"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#prerequisiteFor"></see>
    /// </summary>
    let prerequisiteFor = _prefix "prerequisiteFor"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasProceedings"></see>
    /// </summary>
    let hasProceedings = _prefix "hasProceedings"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#publicationVenueFor"></see>
    /// </summary>
    let publicationVenueFor = _prefix "publicationVenueFor"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasResearchArea"></see>
    /// </summary>
    let hasResearchArea = _prefix "hasResearchArea"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#researchAreaOf"></see>
    /// </summary>
    let researchAreaOf = _prefix "researchAreaOf"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#subjectAreaOf"></see>
    /// </summary>
    let subjectAreaOf = _prefix "subjectAreaOf"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasTranslation"></see>
    /// </summary>
    let hasTranslation = _prefix "hasTranslation"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasValue"></see>
    /// </summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hrJobTitle"></see>
    /// </summary>
    let hrJobTitle = _prefix "hrJobTitle"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#iclCode"></see>
    /// </summary>
    let iclCode = _prefix "iclCode"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#inPress"></see>
    /// </summary>
    let inPress = _prefix "inPress"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#informationResourceSupportedBy"></see>
    /// </summary>
    let informationResourceSupportedBy = _prefix "informationResourceSupportedBy"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#supportedBy"></see>
    /// </summary>
    let supportedBy = _prefix "supportedBy"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#invited"></see>
    /// </summary>
    let invited = _prefix "invited"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#isCorrespondingAuthor"></see>
    /// </summary>
    let isCorrespondingAuthor = _prefix "isCorrespondingAuthor"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#licenseNumber"></see>
    /// </summary>
    let licenseNumber = _prefix "licenseNumber"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#localAwardId"></see>
    /// </summary>
    let localAwardId = _prefix "localAwardId"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#majorField"></see>
    /// </summary>
    let majorField = _prefix "majorField"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#middleName"></see>
    /// </summary>
    let middleName = _prefix "middleName"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#nihmsid"></see>
    /// </summary>
    let nihmsid = _prefix "nihmsid"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#offeredBy"></see>
    /// </summary>
    let offeredBy = _prefix "offeredBy"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#offers"></see>
    /// </summary>
    let offers = _prefix "offers"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#orcidId"></see>
    /// </summary>
    let orcidId = _prefix "orcidId"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#outreachOverview"></see>
    /// </summary>
    let outreachOverview = _prefix "outreachOverview"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#overview"></see>
    /// </summary>
    let overview = _prefix "overview"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#patentNumber"></see>
    /// </summary>
    let patentNumber = _prefix "patentNumber"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#pmcid"></see>
    /// </summary>
    let pmcid = _prefix "pmcid"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#preferredDisplayOrder"></see>
    /// </summary>
    let preferredDisplayOrder = _prefix "preferredDisplayOrder"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#proceedingsOf"></see>
    /// </summary>
    let proceedingsOf = _prefix "proceedingsOf"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#publisherOf"></see>
    /// </summary>
    let publisherOf = _prefix "publisherOf"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#relatedBy"></see>
    /// </summary>
    let relatedBy = _prefix "relatedBy"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#reportId"></see>
    /// </summary>
    let reportId = _prefix "reportId"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#reproduces"></see>
    /// </summary>
    let reproduces = _prefix "reproduces"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#researchOverview"></see>
    /// </summary>
    let researchOverview = _prefix "researchOverview"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#researcherId"></see>
    /// </summary>
    let researcherId = _prefix "researcherId"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#scopusId"></see>
    /// </summary>
    let scopusId = _prefix "scopusId"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#seatingCapacity"></see>
    /// </summary>
    let seatingCapacity = _prefix "seatingCapacity"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#sponsorAwardId"></see>
    /// </summary>
    let sponsorAwardId = _prefix "sponsorAwardId"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#sponsoredBy"></see>
    /// </summary>
    let sponsoredBy = _prefix "sponsoredBy"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#sponsors"></see>
    /// </summary>
    let sponsors = _prefix "sponsors"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#start"></see>
    /// </summary>
    let start = _prefix "start"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#subcontractsGrant"></see>
    /// </summary>
    let subcontractsGrant = _prefix "subcontractsGrant"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#submitted"></see>
    /// </summary>
    let submitted = _prefix "submitted"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#teachingOverview"></see>
    /// </summary>
    let teachingOverview = _prefix "teachingOverview"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#termLabel"></see>
    /// </summary>
    let termLabel = _prefix "termLabel"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#termType"></see>
    /// </summary>
    let termType = _prefix "termType"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#totalAwardAmount"></see>
    /// </summary>
    let totalAwardAmount = _prefix "totalAwardAmount"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#yearMonthDayPrecision"></see>
    /// </summary>
    let yearMonthDayPrecision = _prefix "yearMonthDayPrecision"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#yearMonthDayTimePrecision"></see>
    /// </summary>
    let yearMonthDayTimePrecision = _prefix "yearMonthDayTimePrecision"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#yearMonthPrecision"></see>
    /// </summary>
    let yearMonthPrecision = _prefix "yearMonthPrecision"
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#yearPrecision"></see>
    /// </summary>
    let yearPrecision = _prefix "yearPrecision"
