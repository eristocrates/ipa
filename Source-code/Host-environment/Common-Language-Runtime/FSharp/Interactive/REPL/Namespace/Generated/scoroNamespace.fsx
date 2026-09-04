#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module scoro =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/spar/scoro/" "scoro"
    let _2017_09_04 = _prefixId.prefix "2017-09-04"
    /// <summary>
    ///   <para>rdfs:comment : Defines the type or nature of a contribution made with respect to the authorship of a publication such as a journal article.  Individual members of this class are used to specify particular authorship contributions.</para>
    ///   <para>rdfs:label : authorship contribution</para>
    ///   <a href="http://purl.org/spar/scoro/AuthorshipContribution">scoro:AuthorshipContribution</a>
    /// </summary>
    let AuthorshipContribution = _prefixId.prefix "AuthorshipContribution"
    /// <summary>
    ///   <para>rdfs:label : authorship role</para>
    ///   <para>rdfs:comment : A role that a person might hold as an author of a publication or the creator of a work.  Individual members of this class are used to specify particular roles.</para>
    ///   <a href="http://purl.org/spar/scoro/AuthorshipRole">scoro:AuthorshipRole</a>
    /// </summary>
    let AuthorshipRole = _prefixId.prefix "AuthorshipRole"
    /// <summary>
    ///   <para>rdfs:label : computational agent</para>
    ///   <para>rdfs:comment : A computer system or software program whose action has an effect on external events, for example a laboratory robot that undertakes your experiments, or the financial control system that controls an institution's payrole, or that, following programmed business rules, prevents the principal investigator from placing an order for research equipment because there is insufficient money left in the project budget.</para>
    ///   <a href="http://purl.org/spar/scoro/ComputationalAgent">scoro:ComputationalAgent</a>
    /// </summary>
    let ComputationalAgent = _prefixId.prefix "ComputationalAgent"
    /// <summary>
    ///   <para>rdfs:comment : Defines the type or nature of a contribution made by an agent.  Individual members of this class or its sub-classes are used to specify particular contributions.</para>
    ///   <para>rdfs:label : contribution</para>
    ///   <a href="http://purl.org/spar/scoro/Contribution">scoro:Contribution</a>
    /// </summary>
    let Contribution = _prefixId.prefix "Contribution"
    /// <summary>
    ///   <para>rdfs:label : contribution effort</para>
    ///   <para>rdfs:comment : Defines the effort expended in making a contribution.</para>
    ///   <a href="http://purl.org/spar/scoro/ContributionEffort">scoro:ContributionEffort</a>
    /// </summary>
    let ContributionEffort = _prefixId.prefix "ContributionEffort"
    /// <summary>
    ///   <para>dce:description : A contribution situation describes always:
    /// - a particular contribution C
    /// - a particular agent A making contribution C
    /// - a particular time interval T in which A makes C (optional)
    /// - a particular contribution effort E
    /// - one or more entities (e.g. an investigation or data) that defines a context for C contributed by A. (At least one contextual entity should be specified for a particular contribution).</para>
    ///   <para>rdfs:comment : The situation an agent has of making a contribution to realizing a goal or completing a task relating to a scholarly activity or entity such as journal article.  The type or nature of the contribution is defined by the object of the object property scoro:withContribution, which is an individual in the class scoro:Contribution or one of its sub-classes.  The entity to which the contribution relates is specified using the object property scoro:relatesToEntity or one of its sub-properties, and the effort expended in making that contribution is specified using the object property scoro:withContributionEffort.</para>
    ///   <para>rdfs:label : contribution situation</para>
    ///   <a href="http://purl.org/spar/scoro/ContributionSituation">scoro:ContributionSituation</a>
    /// </summary>
    let ContributionSituation = _prefixId.prefix "ContributionSituation"
    /// <summary>
    ///   <para>rdfs:label : data role</para>
    ///   <para>rdfs:comment : A role that an agent might hold with respect to data.  Individual members of this class are used to specify particular roles.</para>
    ///   <a href="http://purl.org/spar/scoro/DataRole">scoro:DataRole</a>
    /// </summary>
    let DataRole = _prefixId.prefix "DataRole"
    /// <summary>
    ///   <para>rdfs:comment : A role that an agent might hold with respect to an educational organization or activity.  Individual members of this class are used to specify particular educational roles.</para>
    ///   <para>rdfs:label : educational role</para>
    ///   <a href="http://purl.org/spar/scoro/EducationalRole">scoro:EducationalRole</a>
    /// </summary>
    let EducationalRole = _prefixId.prefix "EducationalRole"
    /// <summary>
    ///   <para>rdfs:comment : Defines the type or nature of a practical or experimental contribution made to the research.  Individual members of this class are used to specify particular contributions.</para>
    ///   <para>rdfs:label : experimental contribution</para>
    ///   <a href="http://purl.org/spar/scoro/ExperimentalContribution">scoro:ExperimentalContribution</a>
    /// </summary>
    let ExperimentalContribution = _prefixId.prefix "ExperimentalContribution"
    /// <summary>
    ///   <para>rdfs:comment : A role that an agent might hold with respect to academic and project finance.  Individual members of this class are used to specify particular roles.</para>
    ///   <para>rdfs:label : financial role</para>
    ///   <a href="http://purl.org/spar/scoro/FinancialRole">scoro:FinancialRole</a>
    /// </summary>
    let FinancialRole = _prefixId.prefix "FinancialRole"
    /// <summary>
    ///   <para>rdfs:label : intellectual contribution</para>
    ///   <para>rdfs:comment : Defines the type or nature of an intellectual contribution made to the research described in a journal article.  Individual members of this class are used to specify particular contributions.</para>
    ///   <a href="http://purl.org/spar/scoro/IntellectualContribution">scoro:IntellectualContribution</a>
    /// </summary>
    let IntellectualContribution = _prefixId.prefix "IntellectualContribution"
    /// <summary>
    ///   <para>rdfs:comment : A role that an agent might hold with respect to an investigation.  Individual members of this class are used to specify particular roles.</para>
    ///   <para>rdfs:label : investigation role</para>
    ///   <a href="http://purl.org/spar/scoro/InvestigationRole">scoro:InvestigationRole</a>
    /// </summary>
    let InvestigationRole = _prefixId.prefix "InvestigationRole"
    /// <summary>
    ///   <para>rdfs:label : organizational contribution</para>
    ///   <para>rdfs:comment : Defines the type or nature of an organizational or administrative contribution.  Individual members of this class are used to specify particular contributions.</para>
    ///   <a href="http://purl.org/spar/scoro/OrganizationalContribution">scoro:OrganizationalContribution</a>
    /// </summary>
    let OrganizationalContribution = _prefixId.prefix "OrganizationalContribution"
    /// <summary>
    ///   <para>rdfs:label : organizational role</para>
    ///   <para>rdfs:comment : A role that an agent might hold with respect to an organization and its administration, particularly within an academic context.  Individual members of this class are used to specify particular roles.</para>
    ///   <a href="http://purl.org/spar/scoro/OrganizationalRole">scoro:OrganizationalRole</a>
    /// </summary>
    let OrganizationalRole = _prefixId.prefix "OrganizationalRole"
    /// <summary>
    ///   <para>rdfs:comment : A role that an agent might hold with respect to a project.  Individual members of this class are used to specify particular roles.</para>
    ///   <para>rdfs:label : project role</para>
    ///   <a href="http://purl.org/spar/scoro/ProjectRole">scoro:ProjectRole</a>
    /// </summary>
    let ProjectRole = _prefixId.prefix "ProjectRole"
    let access_provider = _prefixId.prefix "access-provider"
    let accountant = _prefixId.prefix "accountant"
    let administrator = _prefixId.prefix "administrator"
    let affiliate = _prefixId.prefix "affiliate"
    let agent = _prefixId.prefix "agent"
    let analyses_data = _prefixId.prefix "analyses-data"
    let approves_final_manuscript = _prefixId.prefix "approves-final-manuscript"
    let article_guarantor = _prefixId.prefix "article-guarantor"
    let auditor = _prefixId.prefix "auditor"

    let builds_and_or_maintains_instruments =
        _prefixId.prefix "builds-and-or-maintains-instruments"

    let chief_executive_officer = _prefixId.prefix "chief-executive-officer"
    let chief_scientist = _prefixId.prefix "chief-scientist"
    let chief_technology_officer = _prefixId.prefix "chief-technology-officer"
    let claimant = _prefixId.prefix "claimant"
    let co_applicant = _prefixId.prefix "co-applicant"
    let co_investigator = _prefixId.prefix "co-investigator"
    let collaborator = _prefixId.prefix "collaborator"
    let collects_data = _prefixId.prefix "collects-data"
    let college_fellow = _prefixId.prefix "college-fellow"
    let college_head = _prefixId.prefix "college-head"
    let computer_programmer = _prefixId.prefix "computer-programmer"
    let conceives_project = _prefixId.prefix "conceives-project"
    let consortium_author = _prefixId.prefix "consortium-author"
    let consultant = _prefixId.prefix "consultant"
    let contact_person = _prefixId.prefix "contact-person"
    let contractor = _prefixId.prefix "contractor"
    let controls_project_finances = _prefixId.prefix "controls-project-finances"
    let corresponding_author = _prefixId.prefix "corresponding-author"

    let creates_novel_organisms_or_cells =
        _prefixId.prefix "creates-novel-organisms-or-cells"

    let creates_novel_reagents = _prefixId.prefix "creates-novel-reagents"
    let creates_software = _prefixId.prefix "creates-software"
    let curator = _prefixId.prefix "curator"
    let data_creator = _prefixId.prefix "data-creator"
    let data_curator = _prefixId.prefix "data-curator"
    let data_manager = _prefixId.prefix "data-manager"
    let data_publisher = _prefixId.prefix "data-publisher"
    let data_user = _prefixId.prefix "data-user"
    let departmental_administrator = _prefixId.prefix "departmental-administrator"
    let designs_experiments = _prefixId.prefix "designs-experiments"
    let develops_methodology = _prefixId.prefix "develops-methodology"
    let director = _prefixId.prefix "director"
    let doctoral_student = _prefixId.prefix "doctoral-student"
    let embargo_controller = _prefixId.prefix "embargo-controller"
    let employee = _prefixId.prefix "employee"
    let employer = _prefixId.prefix "employer"
    let ensures_regulatory_compliance = _prefixId.prefix "ensures-regulatory-compliance"
    let faculty_member = _prefixId.prefix "faculty-member"
    let financial_controller = _prefixId.prefix "financial-controller"
    let formulates_research_questions = _prefixId.prefix "formulates-research-questions"
    let funder = _prefixId.prefix "funder"
    let funding_recipient = _prefixId.prefix "funding-recipient"
    /// <summary>
    ///   <para>rdfs:comment : A property relating a contribution situation to an entity representing the context for that situation.</para>
    ///   <para>rdfs:label : has contribution context</para>
    ///   <a href="http://purl.org/spar/scoro/hasContributionContext">scoro:hasContributionContext</a>
    /// </summary>
    let hasContributionContext = _prefixId.prefix "hasContributionContext"
    /// <summary>
    ///   <para>rdfs:label : has ORCID</para>
    ///   <para>rdfs:comment : A data property relating an individual to his/her Open Researcher and Contributor ID (ORCID), an alphanumeric identifier for individual scholars described at http://about.orcid.org/.</para>
    ///   <para>dce:description : owl:equivalentProperty &lt;http://purl.org/spar/frapo/hasORCID&gt; .</para>
    ///   <a href="http://purl.org/spar/scoro/hasORCID">scoro:hasORCID</a>
    /// </summary>
    let hasORCID = _prefixId.prefix "hasORCID"
    /// <summary>
    ///   <para>dce:description :  owl:equivalentProperty &lt;http://purl.org/spar/frapo/hasPersonalIdentifier&gt; .dce:description :  owl:equivalentProperty &lt;http://purl.org/spar/datacite/hasPersonalIdentifier&gt; .</para>
    ///   <para>rdfs:label : has personal identifier</para>
    ///   <para>rdfs:comment : A data property specifying a unique and unambiguous identifier for an individual person within a given context, specified by the object property scoro:usesPersonalIdentifierScheme and an individual member of the class scoro:PersonalIdentifierScheme.</para>
    ///   <a href="http://purl.org/spar/scoro/hasPersonalIdentifier">scoro:hasPersonalIdentifier</a>
    /// </summary>
    let hasPersonalIdentifier = _prefixId.prefix "hasPersonalIdentifier"
    let head_of_department = _prefixId.prefix "head-of-department"
    let host_institution = _prefixId.prefix "host-institution"
    let illustrator = _prefixId.prefix "illustrator"
    let interprets_results = _prefixId.prefix "interprets-results"
    let inventor = _prefixId.prefix "inventor"
    /// <summary>
    ///   <para>rdfs:comment : The property relating the definition of a specific contribution to the contribution situation of an agent making that contribution.</para>
    ///   <para>rdfs:label : is contribution in</para>
    ///   <a href="http://purl.org/spar/scoro/isContributionIn">scoro:isContributionIn</a>
    /// </summary>
    let isContributionIn = _prefixId.prefix "isContributionIn"

    /// <summary>
    ///   <para>rdfs:comment : This property allows the link of two contribution situations that are equals for particular aspects (i.e. for type of contribution, contribution effort and context).</para>
    ///   <para>rdfs:label : is equal to contribution situation</para>
    ///   <a href="http://purl.org/spar/scoro/isEqualToContributionSituation">scoro:isEqualToContributionSituation</a>
    /// </summary>
    let isEqualToContributionSituation =
        _prefixId.prefix "isEqualToContributionSituation"

    /// <summary>
    ///   <para>rdfs:label : is equal to role in time</para>
    ///   <para>rdfs:comment : This property allows the link of two roles in time as being equal, and is particularly useful for specifying that two principal authorship roles are equal.</para>
    ///   <a href="http://purl.org/spar/scoro/isEqualToRoleInTime">scoro:isEqualToRoleInTime</a>
    /// </summary>
    let isEqualToRoleInTime = _prefixId.prefix "isEqualToRoleInTime"
    /// <summary>
    ///   <para>rdfs:comment : A property relating a contribution situation that an agent makes, to that agent.</para>
    ///   <para>rdfs:label : is made by</para>
    ///   <a href="http://purl.org/spar/scoro/isMadeBy">scoro:isMadeBy</a>
    /// </summary>
    let isMadeBy = _prefixId.prefix "isMadeBy"

    /// <summary>
    ///   <para>rdfs:label : is related to contribution situation</para>
    ///   <para>rdfs:comment : A property relating an entity to the contribution situation for which that entity provides the context.</para>
    ///   <a href="http://purl.org/spar/scoro/isRelatedToContributionSituation">scoro:isRelatedToContributionSituation</a>
    /// </summary>
    let isRelatedToContributionSituation =
        _prefixId.prefix "isRelatedToContributionSituation"

    let lead_applicant = _prefixId.prefix "lead-applicant"
    let leads_investigation = _prefixId.prefix "leads-investigation"
    let maintains_IT_Infrastructure = _prefixId.prefix "maintains-IT-Infrastructure"
    let maintains_organisms_or_cells = _prefixId.prefix "maintains-organisms-or-cells"
    let maintains_research_facility = _prefixId.prefix "maintains-research-facility"
    let major_effort = _prefixId.prefix "major-effort"
    /// <summary>
    ///   <para>rdfs:label : makes contribution</para>
    ///   <para>rdfs:comment : An object property linking an agent to a contribution.  This is done via the indirection: foaf:Agent scoro:makesContribution [ a scoro:ContributionSituation ; scoro:withContribution scoro:Contribution ; scoro:withEffort scoro:ContributionEffort ] .  The ontology permits one to specify the time period over which a contribution is made, and the other contextual entities to which that agent's contribution relates.</para>
    ///   <a href="http://purl.org/spar/scoro/makesContribution">scoro:makesContribution</a>
    /// </summary>
    let makesContribution = _prefixId.prefix "makesContribution"
    let manager = _prefixId.prefix "manager"
    let manages_project = _prefixId.prefix "manages-project"
    let master_student = _prefixId.prefix "master-student"
    let member_ = _prefixId.prefix "member"
    let minor_effort = _prefixId.prefix "minor-effort"
    let non_academic_staff_member = _prefixId.prefix "non-academic-staff-member"

    let obtains_and_or_prepares_specimens =
        _prefixId.prefix "obtains-and-or-prepares-specimens"

    let organizer = _prefixId.prefix "organizer"
    let owner = _prefixId.prefix "owner"
    let participant = _prefixId.prefix "participant"
    let partner = _prefixId.prefix "partner"
    let patent_holder = _prefixId.prefix "patent-holder"
    /// <summary>
    ///   <para>rdfs:label : percentage full-time equivalent</para>
    ///   <para>rdfs:comment : A data property permitting specification of the proportion of a person's full time activity that is dedicated to a particular role (e.g. for part-time employment, 50% FTE).</para>
    ///   <a href="http://purl.org/spar/scoro/percentageFTE">scoro:percentageFTE</a>
    /// </summary>
    let percentageFTE = _prefixId.prefix "percentageFTE"
    let performs_experiments = _prefixId.prefix "performs-experiments"
    let photographer = _prefixId.prefix "photographer"
    let possessor = _prefixId.prefix "possessor"
    let postdoctoral_researcher = _prefixId.prefix "postdoctoral-researcher"
    let postgraduate_student = _prefixId.prefix "postgraduate-student"
    let prepares_illustrations = _prefixId.prefix "prepares-illustrations"

    let prepares_supplementary_information =
        _prefixId.prefix "prepares-supplementary-information"

    let principal_author = _prefixId.prefix "principal-author"
    let principal_investigator = _prefixId.prefix "principal-investigator"
    let processes_data = _prefixId.prefix "processes-data"
    let programme_manager = _prefixId.prefix "programme-manager"
    let project_leader = _prefixId.prefix "project-leader"
    let project_manager = _prefixId.prefix "project-manager"
    let project_member = _prefixId.prefix "project-member"
    let project_student = _prefixId.prefix "project-student"

    let provides_administrative_support =
        _prefixId.prefix "provides-administrative-support"

    let provides_advice = _prefixId.prefix "provides-advice"
    let provides_exising_data = _prefixId.prefix "provides-exising-data"
    let provides_patients = _prefixId.prefix "provides-patients"

    let provides_reagents_specimens_or_materials =
        _prefixId.prefix "provides-reagents-specimens-or-materials"

    let provides_service = _prefixId.prefix "provides-service"
    let provides_software = _prefixId.prefix "provides-software"
    let provides_technical_support = _prefixId.prefix "provides-technical-support"

    let provides_tools_equipment_or_facilities =
        _prefixId.prefix "provides-tools-equipment-or-facilities"

    let publishes_data = _prefixId.prefix "publishes-data"
    let purchaser = _prefixId.prefix "purchaser"
    let registrar = _prefixId.prefix "registrar"
    let registration_agency = _prefixId.prefix "registration-agency"
    let registration_authority = _prefixId.prefix "registration-authority"
    let repository_manager = _prefixId.prefix "repository-manager"
    let research_assistant = _prefixId.prefix "research-assistant"
    let research_student = _prefixId.prefix "research-student"
    let researcher = _prefixId.prefix "researcher"
    let revises_manuscript = _prefixId.prefix "revises-manuscript"
    let rights_holder = _prefixId.prefix "rights-holder"
    let scholar = _prefixId.prefix "scholar"
    let ``scoro.png`` = _prefixId.prefix "scoro.png"
    let secures_funding = _prefixId.prefix "secures-funding"
    let senior_author = _prefixId.prefix "senior-author"
    let service_engineer = _prefixId.prefix "service-engineer"
    let solo_effort = _prefixId.prefix "solo-effort"
    let spokesperson = _prefixId.prefix "spokesperson"
    let sponsor = _prefixId.prefix "sponsor"
    let stakeholder = _prefixId.prefix "stakeholder"
    let sub_contractor = _prefixId.prefix "sub-contractor"
    let successor = _prefixId.prefix "successor"
    let supervises_colleagues = _prefixId.prefix "supervises-colleagues"
    let supervisor = _prefixId.prefix "supervisor"
    let supplier = _prefixId.prefix "supplier"
    let technician = _prefixId.prefix "technician"
    let undergraduate_student = _prefixId.prefix "undergraduate-student"
    let undertakes_modelling = _prefixId.prefix "undertakes-modelling"
    let vice_chancellor = _prefixId.prefix "vice-chancellor"
    let web_master = _prefixId.prefix "web-master"
    /// <summary>
    ///   <para>rdfs:comment : An object property connecting an agent's contribution situation to a definition of the contribution made by this agent, specified as an instance of the class scoro:Contribution or of one of its sub-classes.</para>
    ///   <para>rdfs:label : with contribution</para>
    ///   <a href="http://purl.org/spar/scoro/withContribution">scoro:withContribution</a>
    /// </summary>
    let withContribution = _prefixId.prefix "withContribution"
    /// <summary>
    ///   <para>rdfs:comment : An object property connecting an agent's contribution with respect to a particular entity to the amount of effort exerted by this agent in making that contribution, defined by individuals of the class scoro:ContributionEffort.</para>
    ///   <para>rdfs:label : with contribution effort</para>
    ///   <a href="http://purl.org/spar/scoro/withEffort">scoro:withEffort</a>
    /// </summary>
    let withEffort = _prefixId.prefix "withEffort"
    /// <summary>
    ///   <para>rdfs:comment : A data property connecting an agent's role in time to a job title that characterizes that role.  This data property complements the definition of that role in time specified by scoro:Role.  For example, for the scoro:OrganizationalRole 'Head of Department', the specific Job Title might be 'Linacre Professor of Zoology' or 'Regius Professor of Moral Philosophy'. </para>
    ///   <para>rdfs:label : with job title</para>
    ///   <a href="http://purl.org/spar/scoro/withJobTitle">scoro:withJobTitle</a>
    /// </summary>
    let withJobTitle = _prefixId.prefix "withJobTitle"
    let workpackage_leader = _prefixId.prefix "workpackage-leader"
    let writes_manuscript_draft = _prefixId.prefix "writes-manuscript-draft"
