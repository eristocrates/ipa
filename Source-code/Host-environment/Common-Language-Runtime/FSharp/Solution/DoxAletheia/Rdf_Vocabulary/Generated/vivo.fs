namespace http.vivoweb.org.ontology.core.hash

open DoxAletheia.Rdf_Vocabulary

module vivo =
    let _namespace_name = "http://vivoweb.org/ontology/core#"

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#GeographicRegion"></see>
    /// </summary>
    let GeographicRegion =
        Namespaced_IRI.parse _namespace_name "GeographicRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#GeopoliticalEntity"></see>
    /// </summary>
    let GeopoliticalEntity =
        Namespaced_IRI.parse _namespace_name "GeopoliticalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Country"></see>
    /// </summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#identifier"></see>
    /// </summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hideFromDisplay"></see>
    /// </summary>
    let hideFromDisplay =
        Namespaced_IRI.parse _namespace_name "hideFromDisplay" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#dateTimeInterval"></see>
    /// </summary>
    let dateTimeInterval =
        Namespaced_IRI.parse _namespace_name "dateTimeInterval" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#DateTimeInterval"></see>
    /// </summary>
    let DateTimeInterval =
        Namespaced_IRI.parse _namespace_name "DateTimeInterval" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#description"></see>
    /// </summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Project"></see>
    /// </summary>
    let Project = Namespaced_IRI.parse _namespace_name "Project" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Center"></see>
    /// </summary>
    let Center = Namespaced_IRI.parse _namespace_name "Center" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Laboratory"></see>
    /// </summary>
    let Laboratory = Namespaced_IRI.parse _namespace_name "Laboratory" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasFundingVehicle"></see>
    /// </summary>
    let hasFundingVehicle =
        Namespaced_IRI.parse _namespace_name "hasFundingVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Grant"></see>
    /// </summary>
    let Grant = Namespaced_IRI.parse _namespace_name "Grant" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#contactInformation"></see>
    /// </summary>
    let contactInformation =
        Namespaced_IRI.parse _namespace_name "contactInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#freetextKeyword"></see>
    /// </summary>
    let freetextKeyword =
        Namespaced_IRI.parse _namespace_name "freetextKeyword" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasSubjectArea"></see>
    /// </summary>
    let hasSubjectArea =
        Namespaced_IRI.parse _namespace_name "hasSubjectArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#geographicFocus"></see>
    /// </summary>
    let geographicFocus =
        Namespaced_IRI.parse _namespace_name "geographicFocus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#dateTimeValue"></see>
    /// </summary>
    let dateTimeValue =
        Namespaced_IRI.parse _namespace_name "dateTimeValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#DateTimeValue"></see>
    /// </summary>
    let DateTimeValue =
        Namespaced_IRI.parse _namespace_name "DateTimeValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#GeographicLocation"></see>
    /// </summary>
    let GeographicLocation =
        Namespaced_IRI.parse _namespace_name "GeographicLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasPublicationVenue"></see>
    /// </summary>
    let hasPublicationVenue =
        Namespaced_IRI.parse _namespace_name "hasPublicationVenue" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#placeOfPublication"></see>
    /// </summary>
    let placeOfPublication =
        Namespaced_IRI.parse _namespace_name "placeOfPublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#publisher"></see>
    /// </summary>
    let publisher = Namespaced_IRI.parse _namespace_name "publisher" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#abbreviation"></see>
    /// </summary>
    let abbreviation =
        Namespaced_IRI.parse _namespace_name "abbreviation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#features"></see>
    /// </summary>
    let features = Namespaced_IRI.parse _namespace_name "features" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Dataset"></see>
    /// </summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#dateIssued"></see>
    /// </summary>
    let dateIssued = Namespaced_IRI.parse _namespace_name "dateIssued" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AcademicDegree"></see>
    /// </summary>
    let AcademicDegree =
        Namespaced_IRI.parse _namespace_name "AcademicDegree" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#reviewedIn"></see>
    /// </summary>
    let reviewedIn = Namespaced_IRI.parse _namespace_name "reviewedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#translatorOf"></see>
    /// </summary>
    let translatorOf =
        Namespaced_IRI.parse _namespace_name "translatorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Abstract"></see>
    /// </summary>
    let Abstract = Namespaced_IRI.parse _namespace_name "Abstract" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AcademicDepartment"></see>
    /// </summary>
    let AcademicDepartment =
        Namespaced_IRI.parse _namespace_name "AcademicDepartment" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Department"></see>
    /// </summary>
    let Department = Namespaced_IRI.parse _namespace_name "Department" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AcademicTerm"></see>
    /// </summary>
    let AcademicTerm =
        Namespaced_IRI.parse _namespace_name "AcademicTerm" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AcademicYear"></see>
    /// </summary>
    let AcademicYear =
        Namespaced_IRI.parse _namespace_name "AcademicYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AdministratorRole"></see>
    /// </summary>
    let AdministratorRole =
        Namespaced_IRI.parse _namespace_name "AdministratorRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AdviseeRole"></see>
    /// </summary>
    let AdviseeRole =
        Namespaced_IRI.parse _namespace_name "AdviseeRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AdvisingProcess"></see>
    /// </summary>
    let AdvisingProcess =
        Namespaced_IRI.parse _namespace_name "AdvisingProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AdvisingRelationship"></see>
    /// </summary>
    let AdvisingRelationship =
        Namespaced_IRI.parse _namespace_name "AdvisingRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#relates"></see>
    /// </summary>
    let relates = Namespaced_IRI.parse _namespace_name "relates" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Relationship"></see>
    /// </summary>
    let Relationship =
        Namespaced_IRI.parse _namespace_name "Relationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AdvisorRole"></see>
    /// </summary>
    let AdvisorRole =
        Namespaced_IRI.parse _namespace_name "AdvisorRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Association"></see>
    /// </summary>
    let Association =
        Namespaced_IRI.parse _namespace_name "Association" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AttendeeRole"></see>
    /// </summary>
    let AttendeeRole =
        Namespaced_IRI.parse _namespace_name "AttendeeRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AttendingProcess"></see>
    /// </summary>
    let AttendingProcess =
        Namespaced_IRI.parse _namespace_name "AttendingProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Authorship"></see>
    /// </summary>
    let Authorship = Namespaced_IRI.parse _namespace_name "Authorship" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Award"></see>
    /// </summary>
    let Award = Namespaced_IRI.parse _namespace_name "Award" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AwardReceipt"></see>
    /// </summary>
    let AwardReceipt =
        Namespaced_IRI.parse _namespace_name "AwardReceipt" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#assignedBy"></see>
    /// </summary>
    let assignedBy = Namespaced_IRI.parse _namespace_name "assignedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#AwardedDegree"></see>
    /// </summary>
    let AwardedDegree =
        Namespaced_IRI.parse _namespace_name "AwardedDegree" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Blog"></see>
    /// </summary>
    let Blog = Namespaced_IRI.parse _namespace_name "Blog" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#BlogPosting"></see>
    /// </summary>
    let BlogPosting =
        Namespaced_IRI.parse _namespace_name "BlogPosting" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Building"></see>
    /// </summary>
    let Building = Namespaced_IRI.parse _namespace_name "Building" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Room"></see>
    /// </summary>
    let Room = Namespaced_IRI.parse _namespace_name "Room" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Facility"></see>
    /// </summary>
    let Facility = Namespaced_IRI.parse _namespace_name "Facility" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Campus"></see>
    /// </summary>
    let Campus = Namespaced_IRI.parse _namespace_name "Campus" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#CaseStudy"></see>
    /// </summary>
    let CaseStudy = Namespaced_IRI.parse _namespace_name "CaseStudy" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Catalog"></see>
    /// </summary>
    let Catalog = Namespaced_IRI.parse _namespace_name "Catalog" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Certificate"></see>
    /// </summary>
    let Certificate =
        Namespaced_IRI.parse _namespace_name "Certificate" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Credential"></see>
    /// </summary>
    let Credential = Namespaced_IRI.parse _namespace_name "Credential" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Certification"></see>
    /// </summary>
    let Certification =
        Namespaced_IRI.parse _namespace_name "Certification" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#IssuedCredential"></see>
    /// </summary>
    let IssuedCredential =
        Namespaced_IRI.parse _namespace_name "IssuedCredential" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ClinicalOrganization"></see>
    /// </summary>
    let ClinicalOrganization =
        Namespaced_IRI.parse _namespace_name "ClinicalOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ClinicalRole"></see>
    /// </summary>
    let ClinicalRole =
        Namespaced_IRI.parse _namespace_name "ClinicalRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#CoPrincipalInvestigatorRole"></see>
    /// </summary>
    let CoPrincipalInvestigatorRole =
        Namespaced_IRI.parse _namespace_name "CoPrincipalInvestigatorRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#InvestigatorRole"></see>
    /// </summary>
    let InvestigatorRole =
        Namespaced_IRI.parse _namespace_name "InvestigatorRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#College"></see>
    /// </summary>
    let College = Namespaced_IRI.parse _namespace_name "College" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Committee"></see>
    /// </summary>
    let Committee = Namespaced_IRI.parse _namespace_name "Committee" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Company"></see>
    /// </summary>
    let Company = Namespaced_IRI.parse _namespace_name "Company" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Competition"></see>
    /// </summary>
    let Competition =
        Namespaced_IRI.parse _namespace_name "Competition" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ConferencePaper"></see>
    /// </summary>
    let ConferencePaper =
        Namespaced_IRI.parse _namespace_name "ConferencePaper" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ConferencePoster"></see>
    /// </summary>
    let ConferencePoster =
        Namespaced_IRI.parse _namespace_name "ConferencePoster" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ConferenceSeries"></see>
    /// </summary>
    let ConferenceSeries =
        Namespaced_IRI.parse _namespace_name "ConferenceSeries" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#EventSeries"></see>
    /// </summary>
    let EventSeries =
        Namespaced_IRI.parse _namespace_name "EventSeries" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Consortium"></see>
    /// </summary>
    let Consortium = Namespaced_IRI.parse _namespace_name "Consortium" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Continent"></see>
    /// </summary>
    let Continent = Namespaced_IRI.parse _namespace_name "Continent" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Contract"></see>
    /// </summary>
    let Contract = Namespaced_IRI.parse _namespace_name "Contract" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#supportedInformationResource"></see>
    /// </summary>
    let supportedInformationResource =
        Namespaced_IRI.parse _namespace_name "supportedInformationResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#CoreLaboratory"></see>
    /// </summary>
    let CoreLaboratory =
        Namespaced_IRI.parse _namespace_name "CoreLaboratory" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ServiceProvidingLaboratory"></see>
    /// </summary>
    let ServiceProvidingLaboratory =
        Namespaced_IRI.parse _namespace_name "ServiceProvidingLaboratory" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#County"></see>
    /// </summary>
    let County = Namespaced_IRI.parse _namespace_name "County" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Course"></see>
    /// </summary>
    let Course = Namespaced_IRI.parse _namespace_name "Course" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#courseCredits"></see>
    /// </summary>
    let courseCredits =
        Namespaced_IRI.parse _namespace_name "courseCredits" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#validIn"></see>
    /// </summary>
    let validIn = Namespaced_IRI.parse _namespace_name "validIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasGoverningAuthority"></see>
    /// </summary>
    let hasGoverningAuthority =
        Namespaced_IRI.parse _namespace_name "hasGoverningAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Database"></see>
    /// </summary>
    let Database = Namespaced_IRI.parse _namespace_name "Database" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#DateTimeValuePrecision"></see>
    /// </summary>
    let DateTimeValuePrecision =
        Namespaced_IRI.parse _namespace_name "DateTimeValuePrecision" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Division"></see>
    /// </summary>
    let Division = Namespaced_IRI.parse _namespace_name "Division" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ExtensionUnit"></see>
    /// </summary>
    let ExtensionUnit =
        Namespaced_IRI.parse _namespace_name "ExtensionUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#EditorRole"></see>
    /// </summary>
    let EditorRole = Namespaced_IRI.parse _namespace_name "EditorRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#EditorialArticle"></see>
    /// </summary>
    let EditorialArticle =
        Namespaced_IRI.parse _namespace_name "EditorialArticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Editorship"></see>
    /// </summary>
    let Editorship = Namespaced_IRI.parse _namespace_name "Editorship" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#EducationalProcess"></see>
    /// </summary>
    let EducationalProcess =
        Namespaced_IRI.parse _namespace_name "EducationalProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#supplementalInformation"></see>
    /// </summary>
    let supplementalInformation =
        Namespaced_IRI.parse _namespace_name "supplementalInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#EmeritusFaculty"></see>
    /// </summary>
    let EmeritusFaculty =
        Namespaced_IRI.parse _namespace_name "EmeritusFaculty" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#EmeritusLibrarian"></see>
    /// </summary>
    let EmeritusLibrarian =
        Namespaced_IRI.parse _namespace_name "EmeritusLibrarian" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#EmeritusProfessor"></see>
    /// </summary>
    let EmeritusProfessor =
        Namespaced_IRI.parse _namespace_name "EmeritusProfessor" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Equipment"></see>
    /// </summary>
    let Equipment = Namespaced_IRI.parse _namespace_name "Equipment" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Exhibit"></see>
    /// </summary>
    let Exhibit = Namespaced_IRI.parse _namespace_name "Exhibit" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#F1000Link"></see>
    /// </summary>
    let F1000Link = Namespaced_IRI.parse _namespace_name "F1000Link" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#FacultyAdministrativePosition"></see>
    /// </summary>
    let FacultyAdministrativePosition =
        Namespaced_IRI.parse _namespace_name "FacultyAdministrativePosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Position"></see>
    /// </summary>
    let Position = Namespaced_IRI.parse _namespace_name "Position" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#FacultyMember"></see>
    /// </summary>
    let FacultyMember =
        Namespaced_IRI.parse _namespace_name "FacultyMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#FacultyMentoringRelationship"></see>
    /// </summary>
    let FacultyMentoringRelationship =
        Namespaced_IRI.parse _namespace_name "FacultyMentoringRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#FacultyPosition"></see>
    /// </summary>
    let FacultyPosition =
        Namespaced_IRI.parse _namespace_name "FacultyPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Foundation"></see>
    /// </summary>
    let Foundation = Namespaced_IRI.parse _namespace_name "Foundation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#FundingOrganization"></see>
    /// </summary>
    let FundingOrganization =
        Namespaced_IRI.parse _namespace_name "FundingOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#assigns"></see>
    /// </summary>
    let assigns = Namespaced_IRI.parse _namespace_name "assigns" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Location"></see>
    /// </summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#GovernmentAgency"></see>
    /// </summary>
    let GovernmentAgency =
        Namespaced_IRI.parse _namespace_name "GovernmentAgency" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#GraduateAdvisingRelationship"></see>
    /// </summary>
    let GraduateAdvisingRelationship =
        Namespaced_IRI.parse _namespace_name "GraduateAdvisingRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#GraduateStudent"></see>
    /// </summary>
    let GraduateStudent =
        Namespaced_IRI.parse _namespace_name "GraduateStudent" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Student"></see>
    /// </summary>
    let Student = Namespaced_IRI.parse _namespace_name "Student" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Hospital"></see>
    /// </summary>
    let Hospital = Namespaced_IRI.parse _namespace_name "Hospital" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Institute"></see>
    /// </summary>
    let Institute = Namespaced_IRI.parse _namespace_name "Institute" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Internship"></see>
    /// </summary>
    let Internship = Namespaced_IRI.parse _namespace_name "Internship" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ResearcherRole"></see>
    /// </summary>
    let ResearcherRole =
        Namespaced_IRI.parse _namespace_name "ResearcherRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#InvitedTalk"></see>
    /// </summary>
    let InvitedTalk =
        Namespaced_IRI.parse _namespace_name "InvitedTalk" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Presentation"></see>
    /// </summary>
    let Presentation =
        Namespaced_IRI.parse _namespace_name "Presentation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#expirationDate"></see>
    /// </summary>
    let expirationDate =
        Namespaced_IRI.parse _namespace_name "expirationDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#LeaderRole"></see>
    /// </summary>
    let LeaderRole = Namespaced_IRI.parse _namespace_name "LeaderRole" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Librarian"></see>
    /// </summary>
    let Librarian = Namespaced_IRI.parse _namespace_name "Librarian" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#LibrarianPosition"></see>
    /// </summary>
    let LibrarianPosition =
        Namespaced_IRI.parse _namespace_name "LibrarianPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Library"></see>
    /// </summary>
    let Library = Namespaced_IRI.parse _namespace_name "Library" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#License"></see>
    /// </summary>
    let License = Namespaced_IRI.parse _namespace_name "License" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Licensure"></see>
    /// </summary>
    let Licensure = Namespaced_IRI.parse _namespace_name "Licensure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#MedicalResidency"></see>
    /// </summary>
    let MedicalResidency =
        Namespaced_IRI.parse _namespace_name "MedicalResidency" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Meeting"></see>
    /// </summary>
    let Meeting = Namespaced_IRI.parse _namespace_name "Meeting" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#MemberRole"></see>
    /// </summary>
    let MemberRole = Namespaced_IRI.parse _namespace_name "MemberRole" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Museum"></see>
    /// </summary>
    let Museum = Namespaced_IRI.parse _namespace_name "Museum" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#NewsRelease"></see>
    /// </summary>
    let NewsRelease =
        Namespaced_IRI.parse _namespace_name "NewsRelease" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Newsletter"></see>
    /// </summary>
    let Newsletter = Namespaced_IRI.parse _namespace_name "Newsletter" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#NonAcademic"></see>
    /// </summary>
    let NonAcademic =
        Namespaced_IRI.parse _namespace_name "NonAcademic" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#NonAcademicPosition"></see>
    /// </summary>
    let NonAcademicPosition =
        Namespaced_IRI.parse _namespace_name "NonAcademicPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#NonFacultyAcademic"></see>
    /// </summary>
    let NonFacultyAcademic =
        Namespaced_IRI.parse _namespace_name "NonFacultyAcademic" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#NonFacultyAcademicPosition"></see>
    /// </summary>
    let NonFacultyAcademicPosition =
        Namespaced_IRI.parse _namespace_name "NonFacultyAcademicPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#OrganizerRole"></see>
    /// </summary>
    let OrganizerRole =
        Namespaced_IRI.parse _namespace_name "OrganizerRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#OrganizingProcess"></see>
    /// </summary>
    let OrganizingProcess =
        Namespaced_IRI.parse _namespace_name "OrganizingProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#OutreachProviderRole"></see>
    /// </summary>
    let OutreachProviderRole =
        Namespaced_IRI.parse _namespace_name "OutreachProviderRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#PeerReviewerRole"></see>
    /// </summary>
    let PeerReviewerRole =
        Namespaced_IRI.parse _namespace_name "PeerReviewerRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ReviewerRole"></see>
    /// </summary>
    let ReviewerRole =
        Namespaced_IRI.parse _namespace_name "ReviewerRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#PopulatedPlace"></see>
    /// </summary>
    let PopulatedPlace =
        Namespaced_IRI.parse _namespace_name "PopulatedPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#rank"></see>
    /// </summary>
    let rank = Namespaced_IRI.parse _namespace_name "rank" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Postdoc"></see>
    /// </summary>
    let Postdoc = Namespaced_IRI.parse _namespace_name "Postdoc" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#PostdocOrFellowAdvisingRelationship"></see>
    /// </summary>
    let PostdocOrFellowAdvisingRelationship =
        Namespaced_IRI.parse _namespace_name "PostdocOrFellowAdvisingRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#PostdocPosition"></see>
    /// </summary>
    let PostdocPosition =
        Namespaced_IRI.parse _namespace_name "PostdocPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#PostdoctoralTraining"></see>
    /// </summary>
    let PostdoctoralTraining =
        Namespaced_IRI.parse _namespace_name "PostdoctoralTraining" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#PresenterRole"></see>
    /// </summary>
    let PresenterRole =
        Namespaced_IRI.parse _namespace_name "PresenterRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#PresentingProcess"></see>
    /// </summary>
    let PresentingProcess =
        Namespaced_IRI.parse _namespace_name "PresentingProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#PrimaryPosition"></see>
    /// </summary>
    let PrimaryPosition =
        Namespaced_IRI.parse _namespace_name "PrimaryPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#PrincipalInvestigatorRole"></see>
    /// </summary>
    let PrincipalInvestigatorRole =
        Namespaced_IRI.parse _namespace_name "PrincipalInvestigatorRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#PrivateCompany"></see>
    /// </summary>
    let PrivateCompany =
        Namespaced_IRI.parse _namespace_name "PrivateCompany" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Program"></see>
    /// </summary>
    let Program = Namespaced_IRI.parse _namespace_name "Program" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Publisher"></see>
    /// </summary>
    let Publisher = Namespaced_IRI.parse _namespace_name "Publisher" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ResearchOrganization"></see>
    /// </summary>
    let ResearchOrganization =
        Namespaced_IRI.parse _namespace_name "ResearchOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#ResearchProposal"></see>
    /// </summary>
    let ResearchProposal =
        Namespaced_IRI.parse _namespace_name "ResearchProposal" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Review"></see>
    /// </summary>
    let Review = Namespaced_IRI.parse _namespace_name "Review" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#School"></see>
    /// </summary>
    let School = Namespaced_IRI.parse _namespace_name "School" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Score"></see>
    /// </summary>
    let Score = Namespaced_IRI.parse _namespace_name "Score" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Screenplay"></see>
    /// </summary>
    let Screenplay = Namespaced_IRI.parse _namespace_name "Screenplay" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#SeminarSeries"></see>
    /// </summary>
    let SeminarSeries =
        Namespaced_IRI.parse _namespace_name "SeminarSeries" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Speech"></see>
    /// </summary>
    let Speech = Namespaced_IRI.parse _namespace_name "Speech" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#StateOrProvince"></see>
    /// </summary>
    let StateOrProvince =
        Namespaced_IRI.parse _namespace_name "StateOrProvince" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#StudentOrganization"></see>
    /// </summary>
    let StudentOrganization =
        Namespaced_IRI.parse _namespace_name "StudentOrganization" |> NamespacedName

    /// <summary>
    /// For example, the Midwest, northeast U.S.
    /// <see href="http://vivoweb.org/ontology/core#SubnationalRegion"></see></summary>
    let SubnationalRegion =
        Namespaced_IRI.parse _namespace_name "SubnationalRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#TeacherRole"></see>
    /// </summary>
    let TeacherRole =
        Namespaced_IRI.parse _namespace_name "TeacherRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Team"></see>
    /// </summary>
    let Team = Namespaced_IRI.parse _namespace_name "Team" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Translation"></see>
    /// </summary>
    let Translation =
        Namespaced_IRI.parse _namespace_name "Translation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#UndergraduateAdvisingRelationship"></see>
    /// </summary>
    let UndergraduateAdvisingRelationship =
        Namespaced_IRI.parse _namespace_name "UndergraduateAdvisingRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#UndergraduateStudent"></see>
    /// </summary>
    let UndergraduateStudent =
        Namespaced_IRI.parse _namespace_name "UndergraduateStudent" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#University"></see>
    /// </summary>
    let University = Namespaced_IRI.parse _namespace_name "University" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#Video"></see>
    /// </summary>
    let Video = Namespaced_IRI.parse _namespace_name "Video" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#WorkingPaper"></see>
    /// </summary>
    let WorkingPaper =
        Namespaced_IRI.parse _namespace_name "WorkingPaper" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#WorkshopSeries"></see>
    /// </summary>
    let WorkshopSeries =
        Namespaced_IRI.parse _namespace_name "WorkshopSeries" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#affiliatedOrganization"></see>
    /// </summary>
    let affiliatedOrganization =
        Namespaced_IRI.parse _namespace_name "affiliatedOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#assignee"></see>
    /// </summary>
    let assignee = Namespaced_IRI.parse _namespace_name "assignee" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#assigneeFor"></see>
    /// </summary>
    let assigneeFor =
        Namespaced_IRI.parse _namespace_name "assigneeFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#cclCode"></see>
    /// </summary>
    let cclCode = Namespaced_IRI.parse _namespace_name "cclCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#conceptAssociatedWith"></see>
    /// </summary>
    let conceptAssociatedWith =
        Namespaced_IRI.parse _namespace_name "conceptAssociatedWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#contributingRole"></see>
    /// </summary>
    let contributingRole =
        Namespaced_IRI.parse _namespace_name "contributingRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#roleContributesTo"></see>
    /// </summary>
    let roleContributesTo =
        Namespaced_IRI.parse _namespace_name "roleContributesTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#dateFiled"></see>
    /// </summary>
    let dateFiled = Namespaced_IRI.parse _namespace_name "dateFiled" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#dateTime"></see>
    /// </summary>
    let dateTime = Namespaced_IRI.parse _namespace_name "dateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#dateTimePrecision"></see>
    /// </summary>
    let dateTimePrecision =
        Namespaced_IRI.parse _namespace_name "dateTimePrecision" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#degreeCandidacy"></see>
    /// </summary>
    let degreeCandidacy =
        Namespaced_IRI.parse _namespace_name "degreeCandidacy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#departmentOrSchool"></see>
    /// </summary>
    let departmentOrSchool =
        Namespaced_IRI.parse _namespace_name "departmentOrSchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#distributes"></see>
    /// </summary>
    let distributes =
        Namespaced_IRI.parse _namespace_name "distributes" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#distributesFundingFrom"></see>
    /// </summary>
    let distributesFundingFrom =
        Namespaced_IRI.parse _namespace_name "distributesFundingFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#providesFundingThrough"></see>
    /// </summary>
    let providesFundingThrough =
        Namespaced_IRI.parse _namespace_name "providesFundingThrough" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#eRACommonsId"></see>
    /// </summary>
    let eRACommonsId =
        Namespaced_IRI.parse _namespace_name "eRACommonsId" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#eligibleFor"></see>
    /// </summary>
    let eligibleFor =
        Namespaced_IRI.parse _namespace_name "eligibleFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#end"></see>
    /// </summary>
    let end_ = Namespaced_IRI.parse _namespace_name "end" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#entryTerm"></see>
    /// </summary>
    let entryTerm = Namespaced_IRI.parse _namespace_name "entryTerm" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#equipmentFor"></see>
    /// </summary>
    let equipmentFor =
        Namespaced_IRI.parse _namespace_name "equipmentFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#facilityFor"></see>
    /// </summary>
    let facilityFor =
        Namespaced_IRI.parse _namespace_name "facilityFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasFacility"></see>
    /// </summary>
    let hasFacility =
        Namespaced_IRI.parse _namespace_name "hasFacility" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#featuredIn"></see>
    /// </summary>
    let featuredIn = Namespaced_IRI.parse _namespace_name "featuredIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#fundingVehicleFor"></see>
    /// </summary>
    let fundingVehicleFor =
        Namespaced_IRI.parse _namespace_name "fundingVehicleFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#supports"></see>
    /// </summary>
    let supports = Namespaced_IRI.parse _namespace_name "supports" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#geographicFocusOf"></see>
    /// </summary>
    let geographicFocusOf =
        Namespaced_IRI.parse _namespace_name "geographicFocusOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#governingAuthorityFor"></see>
    /// </summary>
    let governingAuthorityFor =
        Namespaced_IRI.parse _namespace_name "governingAuthorityFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#grantDirectCosts"></see>
    /// </summary>
    let grantDirectCosts =
        Namespaced_IRI.parse _namespace_name "grantDirectCosts" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#grantSubcontractedThrough"></see>
    /// </summary>
    let grantSubcontractedThrough =
        Namespaced_IRI.parse _namespace_name "grantSubcontractedThrough" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasAssociatedConcept"></see>
    /// </summary>
    let hasAssociatedConcept =
        Namespaced_IRI.parse _namespace_name "hasAssociatedConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasCollaborator"></see>
    /// </summary>
    let hasCollaborator =
        Namespaced_IRI.parse _namespace_name "hasCollaborator" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasEquipment"></see>
    /// </summary>
    let hasEquipment =
        Namespaced_IRI.parse _namespace_name "hasEquipment" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasMonetaryAmount"></see>
    /// </summary>
    let hasMonetaryAmount =
        Namespaced_IRI.parse _namespace_name "hasMonetaryAmount" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasPredecessorOrganization"></see>
    /// </summary>
    let hasPredecessorOrganization =
        Namespaced_IRI.parse _namespace_name "hasPredecessorOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasSuccessorOrganization"></see>
    /// </summary>
    let hasSuccessorOrganization =
        Namespaced_IRI.parse _namespace_name "hasSuccessorOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasPrerequisite"></see>
    /// </summary>
    let hasPrerequisite =
        Namespaced_IRI.parse _namespace_name "hasPrerequisite" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#prerequisiteFor"></see>
    /// </summary>
    let prerequisiteFor =
        Namespaced_IRI.parse _namespace_name "prerequisiteFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasProceedings"></see>
    /// </summary>
    let hasProceedings =
        Namespaced_IRI.parse _namespace_name "hasProceedings" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#publicationVenueFor"></see>
    /// </summary>
    let publicationVenueFor =
        Namespaced_IRI.parse _namespace_name "publicationVenueFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasResearchArea"></see>
    /// </summary>
    let hasResearchArea =
        Namespaced_IRI.parse _namespace_name "hasResearchArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#researchAreaOf"></see>
    /// </summary>
    let researchAreaOf =
        Namespaced_IRI.parse _namespace_name "researchAreaOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#subjectAreaOf"></see>
    /// </summary>
    let subjectAreaOf =
        Namespaced_IRI.parse _namespace_name "subjectAreaOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasTranslation"></see>
    /// </summary>
    let hasTranslation =
        Namespaced_IRI.parse _namespace_name "hasTranslation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hasValue"></see>
    /// </summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#hrJobTitle"></see>
    /// </summary>
    let hrJobTitle = Namespaced_IRI.parse _namespace_name "hrJobTitle" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#iclCode"></see>
    /// </summary>
    let iclCode = Namespaced_IRI.parse _namespace_name "iclCode" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#inPress"></see>
    /// </summary>
    let inPress = Namespaced_IRI.parse _namespace_name "inPress" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#informationResourceSupportedBy"></see>
    /// </summary>
    let informationResourceSupportedBy =
        Namespaced_IRI.parse _namespace_name "informationResourceSupportedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#supportedBy"></see>
    /// </summary>
    let supportedBy =
        Namespaced_IRI.parse _namespace_name "supportedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#invited"></see>
    /// </summary>
    let invited = Namespaced_IRI.parse _namespace_name "invited" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#isCorrespondingAuthor"></see>
    /// </summary>
    let isCorrespondingAuthor =
        Namespaced_IRI.parse _namespace_name "isCorrespondingAuthor" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#licenseNumber"></see>
    /// </summary>
    let licenseNumber =
        Namespaced_IRI.parse _namespace_name "licenseNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#localAwardId"></see>
    /// </summary>
    let localAwardId =
        Namespaced_IRI.parse _namespace_name "localAwardId" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#majorField"></see>
    /// </summary>
    let majorField = Namespaced_IRI.parse _namespace_name "majorField" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#middleName"></see>
    /// </summary>
    let middleName = Namespaced_IRI.parse _namespace_name "middleName" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#nihmsid"></see>
    /// </summary>
    let nihmsid = Namespaced_IRI.parse _namespace_name "nihmsid" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#offeredBy"></see>
    /// </summary>
    let offeredBy = Namespaced_IRI.parse _namespace_name "offeredBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#offers"></see>
    /// </summary>
    let offers = Namespaced_IRI.parse _namespace_name "offers" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#orcidId"></see>
    /// </summary>
    let orcidId = Namespaced_IRI.parse _namespace_name "orcidId" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#outreachOverview"></see>
    /// </summary>
    let outreachOverview =
        Namespaced_IRI.parse _namespace_name "outreachOverview" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#overview"></see>
    /// </summary>
    let overview = Namespaced_IRI.parse _namespace_name "overview" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#patentNumber"></see>
    /// </summary>
    let patentNumber =
        Namespaced_IRI.parse _namespace_name "patentNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#pmcid"></see>
    /// </summary>
    let pmcid = Namespaced_IRI.parse _namespace_name "pmcid" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#preferredDisplayOrder"></see>
    /// </summary>
    let preferredDisplayOrder =
        Namespaced_IRI.parse _namespace_name "preferredDisplayOrder" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#proceedingsOf"></see>
    /// </summary>
    let proceedingsOf =
        Namespaced_IRI.parse _namespace_name "proceedingsOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#publisherOf"></see>
    /// </summary>
    let publisherOf =
        Namespaced_IRI.parse _namespace_name "publisherOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#relatedBy"></see>
    /// </summary>
    let relatedBy = Namespaced_IRI.parse _namespace_name "relatedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#reportId"></see>
    /// </summary>
    let reportId = Namespaced_IRI.parse _namespace_name "reportId" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#reproduces"></see>
    /// </summary>
    let reproduces = Namespaced_IRI.parse _namespace_name "reproduces" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#researchOverview"></see>
    /// </summary>
    let researchOverview =
        Namespaced_IRI.parse _namespace_name "researchOverview" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#researcherId"></see>
    /// </summary>
    let researcherId =
        Namespaced_IRI.parse _namespace_name "researcherId" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#scopusId"></see>
    /// </summary>
    let scopusId = Namespaced_IRI.parse _namespace_name "scopusId" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#seatingCapacity"></see>
    /// </summary>
    let seatingCapacity =
        Namespaced_IRI.parse _namespace_name "seatingCapacity" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#sponsorAwardId"></see>
    /// </summary>
    let sponsorAwardId =
        Namespaced_IRI.parse _namespace_name "sponsorAwardId" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#sponsoredBy"></see>
    /// </summary>
    let sponsoredBy =
        Namespaced_IRI.parse _namespace_name "sponsoredBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#sponsors"></see>
    /// </summary>
    let sponsors = Namespaced_IRI.parse _namespace_name "sponsors" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#start"></see>
    /// </summary>
    let start = Namespaced_IRI.parse _namespace_name "start" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#subcontractsGrant"></see>
    /// </summary>
    let subcontractsGrant =
        Namespaced_IRI.parse _namespace_name "subcontractsGrant" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#submitted"></see>
    /// </summary>
    let submitted = Namespaced_IRI.parse _namespace_name "submitted" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#teachingOverview"></see>
    /// </summary>
    let teachingOverview =
        Namespaced_IRI.parse _namespace_name "teachingOverview" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#termLabel"></see>
    /// </summary>
    let termLabel = Namespaced_IRI.parse _namespace_name "termLabel" |> NamespacedName
    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#termType"></see>
    /// </summary>
    let termType = Namespaced_IRI.parse _namespace_name "termType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#totalAwardAmount"></see>
    /// </summary>
    let totalAwardAmount =
        Namespaced_IRI.parse _namespace_name "totalAwardAmount" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#yearMonthDayPrecision"></see>
    /// </summary>
    let yearMonthDayPrecision =
        Namespaced_IRI.parse _namespace_name "yearMonthDayPrecision" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#yearMonthDayTimePrecision"></see>
    /// </summary>
    let yearMonthDayTimePrecision =
        Namespaced_IRI.parse _namespace_name "yearMonthDayTimePrecision" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#yearMonthPrecision"></see>
    /// </summary>
    let yearMonthPrecision =
        Namespaced_IRI.parse _namespace_name "yearMonthPrecision" |> NamespacedName

    /// <summary>
    ///   <see href="http://vivoweb.org/ontology/core#yearPrecision"></see>
    /// </summary>
    let yearPrecision =
        Namespaced_IRI.parse _namespace_name "yearPrecision" |> NamespacedName
