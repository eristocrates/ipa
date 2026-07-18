namespace http.reference.data.gov.uk.def.central_government.slash

open DoxAletheia.Rdf_Vocabulary

module cgov =
    let _namespace_name = "http://reference.data.gov.uk/def/central-government/"
    /// <summary>
    /// A class whose for UK Government related public bodies comprised of Executive Agenices, Ministerial and Non-Ministerial Departments and Non-departmental public bodies.
    /// <see href="http://reference.data.gov.uk/def/central-government/PublicBody"></see></summary>
    let PublicBody = Namespaced_IRI.parse _namespace_name "PublicBody" |> NamespacedName

    /// <summary>
    /// Ministerial Departments are led politically by a Government Minister, normally a member of the Cabinet and cover matters that require direct political oversight.
    /// <see href="http://reference.data.gov.uk/def/central-government/MinisterialDepartment"></see></summary>
    let MinisterialDepartment =
        Namespaced_IRI.parse _namespace_name "MinisterialDepartment" |> NamespacedName

    /// <summary>
    /// Cabinet is the supreme decision-making body in government, dealing with the big issues of the day and the Government’s overall strategy.
    /// <see href="http://reference.data.gov.uk/def/central-government/Cabinet"></see></summary>
    let Cabinet = Namespaced_IRI.parse _namespace_name "Cabinet" |> NamespacedName

    /// <summary>
    /// Organisations that administer public policy. They serve Governments, and persist as organisations through multiple Governments.
    /// <see href="http://reference.data.gov.uk/def/central-government/GovernmentOrganisation"></see></summary>
    let GovernmentOrganisation =
        Namespaced_IRI.parse _namespace_name "GovernmentOrganisation" |> NamespacedName

    /// <summary>
    /// A group of ministers, headed by a Prime Minister or First Minister. In America, this would be called an Administration. Each general election brings about the creation of a new Government.
    /// <see href="http://reference.data.gov.uk/def/central-government/Government"></see></summary>
    let Government = Namespaced_IRI.parse _namespace_name "Government" |> NamespacedName

    /// <summary>
    /// Advisory NDPBs – provide independent, expert advice to Ministers on a wide range of issues.  Examples include the Low Pay Commission and the Committee on Standards in Public Life;
    /// <see href="http://reference.data.gov.uk/def/central-government/AdvisoryNDPB"></see></summary>
    let AdvisoryNDPB =
        Namespaced_IRI.parse _namespace_name "AdvisoryNDPB" |> NamespacedName

    /// <summary>
    /// A body which has a role in the processes of national Government, but is not a Government Department or part of one, and which accordingly operates to a greater or lesser extent at arm’s length from Ministers.
    /// <see href="http://reference.data.gov.uk/def/central-government/NonDepartmentalPublicBody"></see></summary>
    let NonDepartmentalPublicBody =
        Namespaced_IRI.parse _namespace_name "NonDepartmentalPublicBody" |> NamespacedName

    /// <summary>
    /// Independent Monitoring Boards of Prisons, Immigration Removal Centres and Immigration Holding Rooms formerly known as Boards of Visitors, these are independent watchdogs of the prison system.
    /// <see href="http://reference.data.gov.uk/def/central-government/MonitoringNDPB"></see></summary>
    let MonitoringNDPB =
        Namespaced_IRI.parse _namespace_name "MonitoringNDPB" |> NamespacedName

    /// <summary>
    /// Tribunal NDPBs have jurisdiction in a specialised field of law. Examples include Valuation Tribunals.
    /// <see href="http://reference.data.gov.uk/def/central-government/TribunalNDPB"></see></summary>
    let TribunalNDPB =
        Namespaced_IRI.parse _namespace_name "TribunalNDPB" |> NamespacedName

    /// <summary>
    /// Typically established in statute and carrying out executive, administrative, regulatory and/or commercial functions.Examples include the Environment Agency, Regional Development Agencies and national museums and galleries
    /// <see href="http://reference.data.gov.uk/def/central-government/ExecutiveNDPB"></see></summary>
    let ExecutiveNDPB =
        Namespaced_IRI.parse _namespace_name "ExecutiveNDPB" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/AssistantParliamentaryCounsel"></see>
    /// </summary>
    let AssistantParliamentaryCounsel =
        Namespaced_IRI.parse _namespace_name "AssistantParliamentaryCounsel" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/Counsel"></see>
    /// </summary>
    let Counsel = Namespaced_IRI.parse _namespace_name "Counsel" |> NamespacedName

    /// <summary>
    /// A committee made up of ministers.
    /// <see href="http://reference.data.gov.uk/def/central-government/MinisterialCommittee"></see></summary>
    let MinisterialCommittee =
        Namespaced_IRI.parse _namespace_name "MinisterialCommittee" |> NamespacedName

    /// <summary>
    /// Cabinet committees reduce the burden on Cabinet by enabling collective decisions to be taken by a smaller group of ministers.
    /// These are modelled as being units within government that report to a Cabinet.
    /// <see href="http://reference.data.gov.uk/def/central-government/CabinetCommittee"></see></summary>
    let CabinetCommittee =
        Namespaced_IRI.parse _namespace_name "CabinetCommittee" |> NamespacedName

    /// <summary>
    /// A civil service. In the UK there are three: the Home Civil Service, the Northern Ireland Civil Service and the Foreign Service.
    /// <see href="http://reference.data.gov.uk/def/central-government/CivilService"></see></summary>
    let CivilService =
        Namespaced_IRI.parse _namespace_name "CivilService" |> NamespacedName

    /// <summary>
    /// A committee made up of civil servants.
    /// <see href="http://reference.data.gov.uk/def/central-government/CivilServiceCommittee"></see></summary>
    let CivilServiceCommittee =
        Namespaced_IRI.parse _namespace_name "CivilServiceCommittee" |> NamespacedName

    /// <summary>
    /// A committee is a kind of organisation that consists purely of meetings.
    /// <see href="http://reference.data.gov.uk/def/central-government/Committee"></see></summary>
    let Committee = Namespaced_IRI.parse _namespace_name "Committee" |> NamespacedName

    /// <summary>
    /// A post within the civil service
    /// <see href="http://reference.data.gov.uk/def/central-government/CivilServicePost"></see></summary>
    let CivilServicePost =
        Namespaced_IRI.parse _namespace_name "CivilServicePost" |> NamespacedName

    /// <summary>
    /// A post that may be occupied by a one or more individuals at a time. This is used for when people are members of organisations ex officio. For example, the Secretary of State for Scotland attends Cabinet by virtue of being the Secretary of State for Scotland, not as an individual person.
    /// <see href="http://reference.data.gov.uk/def/central-government/Post"></see></summary>
    let Post = Namespaced_IRI.parse _namespace_name "Post" |> NamespacedName

    /// <summary>
    /// A legal entity consisting of a single ('sole') incorporated office, occupied by a single ('sole') man or woman.
    /// <see href="http://reference.data.gov.uk/def/central-government/CorporationSole"></see></summary>
    let CorporationSole =
        Namespaced_IRI.parse _namespace_name "CorporationSole" |> NamespacedName

    /// <summary>
    /// A senior post within the civil service
    /// <see href="http://reference.data.gov.uk/def/central-government/SeniorCivilServicePost"></see></summary>
    let SeniorCivilServicePost =
        Namespaced_IRI.parse _namespace_name "SeniorCivilServicePost" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/Department"></see>
    /// </summary>
    let Department = Namespaced_IRI.parse _namespace_name "Department" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/DeputyDirector"></see>
    /// </summary>
    let DeputyDirector =
        Namespaced_IRI.parse _namespace_name "DeputyDirector" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/DeputyParliamentaryCounsel"></see>
    /// </summary>
    let DeputyParliamentaryCounsel =
        Namespaced_IRI.parse _namespace_name "DeputyParliamentaryCounsel" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/DevolvedGovernment"></see>
    /// </summary>
    let DevolvedGovernment =
        Namespaced_IRI.parse _namespace_name "DevolvedGovernment" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/DevolvedGovernmentOrganisation"></see>
    /// </summary>
    let DevolvedGovernmentOrganisation =
        Namespaced_IRI.parse _namespace_name "DevolvedGovernmentOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/Director"></see>
    /// </summary>
    let Director = Namespaced_IRI.parse _namespace_name "Director" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/DirectorGeneral"></see>
    /// </summary>
    let DirectorGeneral =
        Namespaced_IRI.parse _namespace_name "DirectorGeneral" |> NamespacedName

    /// <summary>
    /// An executive agency, also known as a next-step agency, is a part of a government department that is treated as managerially and budgetarily separate in order to carry out some part of the executive functions of the United Kingdom government, Scottish Government, Welsh Assembly or Northern Ireland Executive
    /// <see href="http://reference.data.gov.uk/def/central-government/ExecutiveAgency"></see></summary>
    let ExecutiveAgency =
        Namespaced_IRI.parse _namespace_name "ExecutiveAgency" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/GreatOfficerOfState"></see>
    /// </summary>
    let GreatOfficerOfState =
        Namespaced_IRI.parse _namespace_name "GreatOfficerOfState" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/HonorificPost"></see>
    /// </summary>
    let HonorificPost =
        Namespaced_IRI.parse _namespace_name "HonorificPost" |> NamespacedName

    /// <summary>
    /// A change in one or more public bodies that may involve a renaming, a reallocation of responsibilities, the transfer of a unit, or various other changes that take place within government structure. Often these changes don't bring about
    /// <see href="http://reference.data.gov.uk/def/central-government/MachineryOfGovernmentChangeEvent"></see></summary>
    let MachineryOfGovernmentChangeEvent =
        Namespaced_IRI.parse _namespace_name "MachineryOfGovernmentChangeEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/Minister"></see>
    /// </summary>
    let Minister = Namespaced_IRI.parse _namespace_name "Minister" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/MinisterOfState"></see>
    /// </summary>
    let MinisterOfState =
        Namespaced_IRI.parse _namespace_name "MinisterOfState" |> NamespacedName

    /// <summary>
    /// A non-ministerial government department is a department or ministry of a government that is not headed by a Government Minister or Government Secretary, and answers directly to a legislature
    /// <see href="http://reference.data.gov.uk/def/central-government/NonMinisterialDepartment"></see></summary>
    let NonMinisterialDepartment =
        Namespaced_IRI.parse _namespace_name "NonMinisterialDepartment" |> NamespacedName

    /// <summary>
    /// A representation of the non-disclosure of a piece of information.
    /// <see href="http://reference.data.gov.uk/def/central-government/NonDisclosure"></see></summary>
    let NonDisclosure =
        Namespaced_IRI.parse _namespace_name "NonDisclosure" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/ParliamentaryCounsel"></see>
    /// </summary>
    let ParliamentaryCounsel =
        Namespaced_IRI.parse _namespace_name "ParliamentaryCounsel" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/ParliamentaryUnderSecretary"></see>
    /// </summary>
    let ParliamentaryUnderSecretary =
        Namespaced_IRI.parse _namespace_name "ParliamentaryUnderSecretary" |> NamespacedName

    /// <summary>
    /// The most senior civil servant in a department is a permanent secretary. Each supports the government minister who heads their department and who is accountable to Parliament for the department’s actions and performance.
    /// <see href="http://reference.data.gov.uk/def/central-government/PermanentSecretary"></see></summary>
    let PermanentSecretary =
        Namespaced_IRI.parse _namespace_name "PermanentSecretary" |> NamespacedName

    /// <summary>
    /// Principal Secretaries of State are the highest-ranking ministers in the government, and most government departments have one Principal Secretary of State (or more). Most Principal Secretaries of State are titled 'Secretary of State' – although some have traditional titles, such as the Chancellor of the Exchequer and the Chief Whip.
    /// <see href="http://reference.data.gov.uk/def/central-government/PrincipalSecretaryOfState"></see></summary>
    let PrincipalSecretaryOfState =
        Namespaced_IRI.parse _namespace_name "PrincipalSecretaryOfState" |> NamespacedName

    /// <summary>
    /// A salary range.
    /// <see href="http://reference.data.gov.uk/def/central-government/SalaryRange"></see></summary>
    let SalaryRange =
        Namespaced_IRI.parse _namespace_name "SalaryRange" |> NamespacedName

    /// <summary>
    /// An organisation that provides advice and support to another organisation, often a committee.
    /// <see href="http://reference.data.gov.uk/def/central-government/Secretariat"></see></summary>
    let Secretariat =
        Namespaced_IRI.parse _namespace_name "Secretariat" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/SeniorAssistantParliamentaryCounsel"></see>
    /// </summary>
    let SeniorAssistantParliamentaryCounsel =
        Namespaced_IRI.parse _namespace_name "SeniorAssistantParliamentaryCounsel" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/Sinecure"></see>
    /// </summary>
    let Sinecure = Namespaced_IRI.parse _namespace_name "Sinecure" |> NamespacedName
    /// <summary>
    /// The tenure of an individual in a particular Post. This is used to provide some extra information about the period of time during which an individual held a post, or the salary they received, and so on.
    /// <see href="http://reference.data.gov.uk/def/central-government/Tenure"></see></summary>
    let Tenure = Namespaced_IRI.parse _namespace_name "Tenure" |> NamespacedName

    /// <summary>
    /// A representation of the amount that someone works.
    /// <see href="http://reference.data.gov.uk/def/central-government/WorkingTime"></see></summary>
    let WorkingTime =
        Namespaced_IRI.parse _namespace_name "WorkingTime" |> NamespacedName

    /// <summary>
    /// The cabinet that this person attends (not as a full member).
    /// <see href="http://reference.data.gov.uk/def/central-government/attendsCabinet"></see></summary>
    let attendsCabinet =
        Namespaced_IRI.parse _namespace_name "attendsCabinet" |> NamespacedName

    /// <summary>
    /// An attendee of this cabinet.
    /// <see href="http://reference.data.gov.uk/def/central-government/hasCabinetAttendee"></see></summary>
    let hasCabinetAttendee =
        Namespaced_IRI.parse _namespace_name "hasCabinetAttendee" |> NamespacedName

    /// <summary>
    /// The government that this is a cabinet committee for.
    /// <see href="http://reference.data.gov.uk/def/central-government/cabinetCommitteeOf"></see></summary>
    let cabinetCommitteeOf =
        Namespaced_IRI.parse _namespace_name "cabinetCommitteeOf" |> NamespacedName

    /// <summary>
    /// A cabinet committee for this government.
    /// <see href="http://reference.data.gov.uk/def/central-government/hasCabinetCommittee"></see></summary>
    let hasCabinetCommittee =
        Namespaced_IRI.parse _namespace_name "hasCabinetCommittee" |> NamespacedName

    /// <summary>
    /// The government or executive that this is the cabinet of.
    /// <see href="http://reference.data.gov.uk/def/central-government/cabinetOf"></see></summary>
    let cabinetOf = Namespaced_IRI.parse _namespace_name "cabinetOf" |> NamespacedName
    /// <summary>
    /// The cabinet of this government.
    /// <see href="http://reference.data.gov.uk/def/central-government/hasCabinet"></see></summary>
    let hasCabinet = Namespaced_IRI.parse _namespace_name "hasCabinet" |> NamespacedName
    /// <summary>
    /// The committee that this person chairs.
    /// <see href="http://reference.data.gov.uk/def/central-government/chairOf"></see></summary>
    let chairOf = Namespaced_IRI.parse _namespace_name "chairOf" |> NamespacedName
    /// <summary>
    /// The chair of this committee.
    /// <see href="http://reference.data.gov.uk/def/central-government/hasChair"></see></summary>
    let hasChair = Namespaced_IRI.parse _namespace_name "hasChair" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/currency"></see>
    /// </summary>
    let currency = Namespaced_IRI.parse _namespace_name "currency" |> NamespacedName

    /// <summary>
    /// The committee that this person is the deputy chair of.
    /// <see href="http://reference.data.gov.uk/def/central-government/deputyChairOf"></see></summary>
    let deputyChairOf =
        Namespaced_IRI.parse _namespace_name "deputyChairOf" |> NamespacedName

    /// <summary>
    /// The deputy chair of this committee.
    /// <see href="http://reference.data.gov.uk/def/central-government/hasDeputyChair"></see></summary>
    let hasDeputyChair =
        Namespaced_IRI.parse _namespace_name "hasDeputyChair" |> NamespacedName

    /// <summary>
    /// The government that this person (the Deputy Prime Minister or Deputy First Minister) is the head of.
    /// <see href="http://reference.data.gov.uk/def/central-government/deputyHeadOfGovernment"></see></summary>
    let deputyHeadOfGovernment =
        Namespaced_IRI.parse _namespace_name "deputyHeadOfGovernment" |> NamespacedName

    /// <summary>
    /// The deputy head of this government (the Deputy Prime Minister or Deputy First Minister).
    /// <see href="http://reference.data.gov.uk/def/central-government/hasGovernmentDeputyHead"></see></summary>
    let hasGovernmentDeputyHead =
        Namespaced_IRI.parse _namespace_name "hasGovernmentDeputyHead" |> NamespacedName

    /// <summary>
    /// A government organisation that this devolved government organisation is devolved from.
    /// <see href="http://reference.data.gov.uk/def/central-government/devolvedFrom"></see></summary>
    let devolvedFrom =
        Namespaced_IRI.parse _namespace_name "devolvedFrom" |> NamespacedName

    /// <summary>
    /// A devolved government organisation that this government organisation devolves power to.
    /// <see href="http://reference.data.gov.uk/def/central-government/devolvesTo"></see></summary>
    let devolvesTo = Namespaced_IRI.parse _namespace_name "devolvesTo" |> NamespacedName
    /// <summary>
    /// The base period over which the amount of time spent working is measured.
    /// <see href="http://reference.data.gov.uk/def/central-government/forEvery"></see></summary>
    let forEvery = Namespaced_IRI.parse _namespace_name "forEvery" |> NamespacedName
    /// <summary>
    /// The time at which the Government was formed.
    /// <see href="http://reference.data.gov.uk/def/central-government/formedAt"></see></summary>
    let formedAt = Namespaced_IRI.parse _namespace_name "formedAt" |> NamespacedName

    /// <summary>
    /// The amount of time spent by the postholder in the post; a full-time equivalent of 1 indicates a full-time post.
    /// <see href="http://reference.data.gov.uk/def/central-government/fullTimeEquivalent"></see></summary>
    let fullTimeEquivalent =
        Namespaced_IRI.parse _namespace_name "fullTimeEquivalent" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/fullTimeEquivalentSalary"></see>
    /// </summary>
    let fullTimeEquivalentSalary =
        Namespaced_IRI.parse _namespace_name "fullTimeEquivalentSalary" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/salaryRange"></see>
    /// </summary>
    let salaryRange =
        Namespaced_IRI.parse _namespace_name "salaryRange" |> NamespacedName

    /// <summary>
    /// The legislature that this government organisation is associated with.
    /// <see href="http://reference.data.gov.uk/def/central-government/governmentOrganisationOf"></see></summary>
    let governmentOrganisationOf =
        Namespaced_IRI.parse _namespace_name "governmentOrganisationOf" |> NamespacedName

    /// <summary>
    /// A member of this cabinet.
    /// <see href="http://reference.data.gov.uk/def/central-government/hasCabinetMember"></see></summary>
    let hasCabinetMember =
        Namespaced_IRI.parse _namespace_name "hasCabinetMember" |> NamespacedName

    /// <summary>
    /// The cabinet that this person a member of.
    /// <see href="http://reference.data.gov.uk/def/central-government/memberOfCabinet"></see></summary>
    let memberOfCabinet =
        Namespaced_IRI.parse _namespace_name "memberOfCabinet" |> NamespacedName

    /// <summary>
    /// The head of this government (the Prime Minister or First Minister).
    /// <see href="http://reference.data.gov.uk/def/central-government/hasGovernmentHead"></see></summary>
    let hasGovernmentHead =
        Namespaced_IRI.parse _namespace_name "hasGovernmentHead" |> NamespacedName

    /// <summary>
    /// The government that this person (the Prime Minister or First Minister) is the head of.
    /// <see href="http://reference.data.gov.uk/def/central-government/headOfGovernment"></see></summary>
    let headOfGovernment =
        Namespaced_IRI.parse _namespace_name "headOfGovernment" |> NamespacedName

    /// <summary>
    /// Indicates a post within the organisation.
    /// <see href="http://reference.data.gov.uk/def/central-government/hasPost"></see></summary>
    let hasPost = Namespaced_IRI.parse _namespace_name "hasPost" |> NamespacedName
    /// <summary>
    /// Indicates the organisation that this is a post within.
    /// <see href="http://reference.data.gov.uk/def/central-government/postIn"></see></summary>
    let postIn = Namespaced_IRI.parse _namespace_name "postIn" |> NamespacedName
    /// <summary>
    /// Indicates the agent who holds the post.
    /// <see href="http://reference.data.gov.uk/def/central-government/heldBy"></see></summary>
    let heldBy = Namespaced_IRI.parse _namespace_name "heldBy" |> NamespacedName
    /// <summary>
    /// Indicates a post held by someone.
    /// <see href="http://reference.data.gov.uk/def/central-government/holdsPost"></see></summary>
    let holdsPost = Namespaced_IRI.parse _namespace_name "holdsPost" |> NamespacedName
    /// <summary>
    /// The lower bound of a salary range.
    /// <see href="http://reference.data.gov.uk/def/central-government/lowerBound"></see></summary>
    let lowerBound = Namespaced_IRI.parse _namespace_name "lowerBound" |> NamespacedName

    /// <summary>
    /// A relation between an NDPB or an Executive Agency and their parent Government Department.
    /// <see href="http://reference.data.gov.uk/def/central-government/parentDepartment"></see></summary>
    let parentDepartment =
        Namespaced_IRI.parse _namespace_name "parentDepartment" |> NamespacedName

    /// <summary>
    /// A relation between Minsiterial Departments and their associated Executive Agencies and NDPBs
    /// <see href="http://reference.data.gov.uk/def/central-government/relatedBody"></see></summary>
    let relatedBody =
        Namespaced_IRI.parse _namespace_name "relatedBody" |> NamespacedName

    /// <summary>
    /// The post held in this Tenure
    /// <see href="http://reference.data.gov.uk/def/central-government/post"></see></summary>
    let post = Namespaced_IRI.parse _namespace_name "post" |> NamespacedName
    /// <summary>
    /// The postholder in this Tenure
    /// <see href="http://reference.data.gov.uk/def/central-government/postholder"></see></summary>
    let postholder = Namespaced_IRI.parse _namespace_name "postholder" |> NamespacedName
    /// <summary>
    /// A description of the relationship between an individual and the post that they occupy.
    /// <see href="http://reference.data.gov.uk/def/central-government/tenure"></see></summary>
    let tenure = Namespaced_IRI.parse _namespace_name "tenure" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/salary"></see>
    /// </summary>
    let salary = Namespaced_IRI.parse _namespace_name "salary" |> NamespacedName

    /// <summary>
    /// Salary, not including taxable benefits, and not adjusted based on working time.
    /// <see href="http://reference.data.gov.uk/def/central-government/salaryExcludingBenefits"></see></summary>
    let salaryExcludingBenefits =
        Namespaced_IRI.parse _namespace_name "salaryExcludingBenefits" |> NamespacedName

    /// <summary>
    /// Salary including taxable benefits, not adjusted based on working time.
    /// <see href="http://reference.data.gov.uk/def/central-government/salaryIncludingBenefits"></see></summary>
    let salaryIncludingBenefits =
        Namespaced_IRI.parse _namespace_name "salaryIncludingBenefits" |> NamespacedName

    /// <summary>
    /// The government (organisation) that this Government is served by.
    /// <see href="http://reference.data.gov.uk/def/central-government/servedBy"></see></summary>
    let servedBy = Namespaced_IRI.parse _namespace_name "servedBy" |> NamespacedName
    /// <summary>
    /// The Government that this government (as an organisation) serves.
    /// <see href="http://reference.data.gov.uk/def/central-government/serves"></see></summary>
    let serves = Namespaced_IRI.parse _namespace_name "serves" |> NamespacedName

    /// <summary>
    /// This organisation is supported by object organisation.
    /// <see href="http://reference.data.gov.uk/def/central-government/supportedBy"></see></summary>
    let supportedBy =
        Namespaced_IRI.parse _namespace_name "supportedBy" |> NamespacedName

    /// <summary>
    /// This organisation provides support the object organisation.
    /// <see href="http://reference.data.gov.uk/def/central-government/supports"></see></summary>
    let supports = Namespaced_IRI.parse _namespace_name "supports" |> NamespacedName

    /// <summary>
    /// The terms of reference for a committee.
    /// <see href="http://reference.data.gov.uk/def/central-government/termsOfReference"></see></summary>
    let termsOfReference =
        Namespaced_IRI.parse _namespace_name "termsOfReference" |> NamespacedName

    /// <summary>
    /// The amount of time spent working.
    /// <see href="http://reference.data.gov.uk/def/central-government/timePeriod"></see></summary>
    let timePeriod = Namespaced_IRI.parse _namespace_name "timePeriod" |> NamespacedName
    /// <summary>
    /// The upper bound of a salary range.
    /// <see href="http://reference.data.gov.uk/def/central-government/upperBound"></see></summary>
    let upperBound = Namespaced_IRI.parse _namespace_name "upperBound" |> NamespacedName

    /// <summary>
    /// The contracted minimum working time for the position.
    /// <see href="http://reference.data.gov.uk/def/central-government/workingTime"></see></summary>
    let workingTime =
        Namespaced_IRI.parse _namespace_name "workingTime" |> NamespacedName
