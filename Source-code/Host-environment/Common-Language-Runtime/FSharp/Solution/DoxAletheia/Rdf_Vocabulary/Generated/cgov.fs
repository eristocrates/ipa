namespace http.reference.data.gov.uk.def.central_government.slash

open DoxAletheia

module cgov =
    let _namespace_name = "http://reference.data.gov.uk/def/central-government/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A class whose for UK Government related public bodies comprised of Executive Agenices, Ministerial and Non-Ministerial Departments and Non-departmental public bodies.
    /// <see href="http://reference.data.gov.uk/def/central-government/PublicBody"></see></summary>
    let PublicBody = _prefix "PublicBody"
    /// <summary>
    /// Ministerial Departments are led politically by a Government Minister, normally a member of the Cabinet and cover matters that require direct political oversight.
    /// <see href="http://reference.data.gov.uk/def/central-government/MinisterialDepartment"></see></summary>
    let MinisterialDepartment = _prefix "MinisterialDepartment"
    /// <summary>
    /// Cabinet is the supreme decision-making body in government, dealing with the big issues of the day and the Government’s overall strategy.
    /// <see href="http://reference.data.gov.uk/def/central-government/Cabinet"></see></summary>
    let Cabinet = _prefix "Cabinet"
    /// <summary>
    /// Organisations that administer public policy. They serve Governments, and persist as organisations through multiple Governments.
    /// <see href="http://reference.data.gov.uk/def/central-government/GovernmentOrganisation"></see></summary>
    let GovernmentOrganisation = _prefix "GovernmentOrganisation"
    /// <summary>
    /// A group of ministers, headed by a Prime Minister or First Minister. In America, this would be called an Administration. Each general election brings about the creation of a new Government.
    /// <see href="http://reference.data.gov.uk/def/central-government/Government"></see></summary>
    let Government = _prefix "Government"
    /// <summary>
    /// Advisory NDPBs – provide independent, expert advice to Ministers on a wide range of issues.  Examples include the Low Pay Commission and the Committee on Standards in Public Life;
    /// <see href="http://reference.data.gov.uk/def/central-government/AdvisoryNDPB"></see></summary>
    let AdvisoryNDPB = _prefix "AdvisoryNDPB"
    /// <summary>
    /// A body which has a role in the processes of national Government, but is not a Government Department or part of one, and which accordingly operates to a greater or lesser extent at arm’s length from Ministers.
    /// <see href="http://reference.data.gov.uk/def/central-government/NonDepartmentalPublicBody"></see></summary>
    let NonDepartmentalPublicBody = _prefix "NonDepartmentalPublicBody"
    /// <summary>
    /// Independent Monitoring Boards of Prisons, Immigration Removal Centres and Immigration Holding Rooms formerly known as Boards of Visitors, these are independent watchdogs of the prison system.
    /// <see href="http://reference.data.gov.uk/def/central-government/MonitoringNDPB"></see></summary>
    let MonitoringNDPB = _prefix "MonitoringNDPB"
    /// <summary>
    /// Tribunal NDPBs have jurisdiction in a specialised field of law. Examples include Valuation Tribunals.
    /// <see href="http://reference.data.gov.uk/def/central-government/TribunalNDPB"></see></summary>
    let TribunalNDPB = _prefix "TribunalNDPB"
    /// <summary>
    /// Typically established in statute and carrying out executive, administrative, regulatory and/or commercial functions.Examples include the Environment Agency, Regional Development Agencies and national museums and galleries
    /// <see href="http://reference.data.gov.uk/def/central-government/ExecutiveNDPB"></see></summary>
    let ExecutiveNDPB = _prefix "ExecutiveNDPB"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/AssistantParliamentaryCounsel"></see>
    /// </summary>
    let AssistantParliamentaryCounsel = _prefix "AssistantParliamentaryCounsel"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/Counsel"></see>
    /// </summary>
    let Counsel = _prefix "Counsel"
    /// <summary>
    /// A committee made up of ministers.
    /// <see href="http://reference.data.gov.uk/def/central-government/MinisterialCommittee"></see></summary>
    let MinisterialCommittee = _prefix "MinisterialCommittee"
    /// <summary>
    /// Cabinet committees reduce the burden on Cabinet by enabling collective decisions to be taken by a smaller group of ministers.
    /// These are modelled as being units within government that report to a Cabinet.
    /// <see href="http://reference.data.gov.uk/def/central-government/CabinetCommittee"></see></summary>
    let CabinetCommittee = _prefix "CabinetCommittee"
    /// <summary>
    /// A civil service. In the UK there are three: the Home Civil Service, the Northern Ireland Civil Service and the Foreign Service.
    /// <see href="http://reference.data.gov.uk/def/central-government/CivilService"></see></summary>
    let CivilService = _prefix "CivilService"
    /// <summary>
    /// A committee made up of civil servants.
    /// <see href="http://reference.data.gov.uk/def/central-government/CivilServiceCommittee"></see></summary>
    let CivilServiceCommittee = _prefix "CivilServiceCommittee"
    /// <summary>
    /// A committee is a kind of organisation that consists purely of meetings.
    /// <see href="http://reference.data.gov.uk/def/central-government/Committee"></see></summary>
    let Committee = _prefix "Committee"
    /// <summary>
    /// A post within the civil service
    /// <see href="http://reference.data.gov.uk/def/central-government/CivilServicePost"></see></summary>
    let CivilServicePost = _prefix "CivilServicePost"
    /// <summary>
    /// A post that may be occupied by a one or more individuals at a time. This is used for when people are members of organisations ex officio. For example, the Secretary of State for Scotland attends Cabinet by virtue of being the Secretary of State for Scotland, not as an individual person.
    /// <see href="http://reference.data.gov.uk/def/central-government/Post"></see></summary>
    let Post = _prefix "Post"
    /// <summary>
    /// A legal entity consisting of a single ('sole') incorporated office, occupied by a single ('sole') man or woman.
    /// <see href="http://reference.data.gov.uk/def/central-government/CorporationSole"></see></summary>
    let CorporationSole = _prefix "CorporationSole"
    /// <summary>
    /// A senior post within the civil service
    /// <see href="http://reference.data.gov.uk/def/central-government/SeniorCivilServicePost"></see></summary>
    let SeniorCivilServicePost = _prefix "SeniorCivilServicePost"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/Department"></see>
    /// </summary>
    let Department = _prefix "Department"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/DeputyDirector"></see>
    /// </summary>
    let DeputyDirector = _prefix "DeputyDirector"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/DeputyParliamentaryCounsel"></see>
    /// </summary>
    let DeputyParliamentaryCounsel = _prefix "DeputyParliamentaryCounsel"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/DevolvedGovernment"></see>
    /// </summary>
    let DevolvedGovernment = _prefix "DevolvedGovernment"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/DevolvedGovernmentOrganisation"></see>
    /// </summary>
    let DevolvedGovernmentOrganisation = _prefix "DevolvedGovernmentOrganisation"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/Director"></see>
    /// </summary>
    let Director = _prefix "Director"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/DirectorGeneral"></see>
    /// </summary>
    let DirectorGeneral = _prefix "DirectorGeneral"
    /// <summary>
    /// An executive agency, also known as a next-step agency, is a part of a government department that is treated as managerially and budgetarily separate in order to carry out some part of the executive functions of the United Kingdom government, Scottish Government, Welsh Assembly or Northern Ireland Executive
    /// <see href="http://reference.data.gov.uk/def/central-government/ExecutiveAgency"></see></summary>
    let ExecutiveAgency = _prefix "ExecutiveAgency"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/GreatOfficerOfState"></see>
    /// </summary>
    let GreatOfficerOfState = _prefix "GreatOfficerOfState"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/HonorificPost"></see>
    /// </summary>
    let HonorificPost = _prefix "HonorificPost"
    /// <summary>
    /// A change in one or more public bodies that may involve a renaming, a reallocation of responsibilities, the transfer of a unit, or various other changes that take place within government structure. Often these changes don't bring about
    /// <see href="http://reference.data.gov.uk/def/central-government/MachineryOfGovernmentChangeEvent"></see></summary>
    let MachineryOfGovernmentChangeEvent = _prefix "MachineryOfGovernmentChangeEvent"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/Minister"></see>
    /// </summary>
    let Minister = _prefix "Minister"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/MinisterOfState"></see>
    /// </summary>
    let MinisterOfState = _prefix "MinisterOfState"
    /// <summary>
    /// A non-ministerial government department is a department or ministry of a government that is not headed by a Government Minister or Government Secretary, and answers directly to a legislature
    /// <see href="http://reference.data.gov.uk/def/central-government/NonMinisterialDepartment"></see></summary>
    let NonMinisterialDepartment = _prefix "NonMinisterialDepartment"
    /// <summary>
    /// A representation of the non-disclosure of a piece of information.
    /// <see href="http://reference.data.gov.uk/def/central-government/NonDisclosure"></see></summary>
    let NonDisclosure = _prefix "NonDisclosure"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/ParliamentaryCounsel"></see>
    /// </summary>
    let ParliamentaryCounsel = _prefix "ParliamentaryCounsel"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/ParliamentaryUnderSecretary"></see>
    /// </summary>
    let ParliamentaryUnderSecretary = _prefix "ParliamentaryUnderSecretary"
    /// <summary>
    /// The most senior civil servant in a department is a permanent secretary. Each supports the government minister who heads their department and who is accountable to Parliament for the department’s actions and performance.
    /// <see href="http://reference.data.gov.uk/def/central-government/PermanentSecretary"></see></summary>
    let PermanentSecretary = _prefix "PermanentSecretary"
    /// <summary>
    /// Principal Secretaries of State are the highest-ranking ministers in the government, and most government departments have one Principal Secretary of State (or more). Most Principal Secretaries of State are titled 'Secretary of State' – although some have traditional titles, such as the Chancellor of the Exchequer and the Chief Whip.
    /// <see href="http://reference.data.gov.uk/def/central-government/PrincipalSecretaryOfState"></see></summary>
    let PrincipalSecretaryOfState = _prefix "PrincipalSecretaryOfState"
    /// <summary>
    /// A salary range.
    /// <see href="http://reference.data.gov.uk/def/central-government/SalaryRange"></see></summary>
    let SalaryRange = _prefix "SalaryRange"
    /// <summary>
    /// An organisation that provides advice and support to another organisation, often a committee.
    /// <see href="http://reference.data.gov.uk/def/central-government/Secretariat"></see></summary>
    let Secretariat = _prefix "Secretariat"

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/SeniorAssistantParliamentaryCounsel"></see>
    /// </summary>
    let SeniorAssistantParliamentaryCounsel =
        _prefix "SeniorAssistantParliamentaryCounsel"

    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/Sinecure"></see>
    /// </summary>
    let Sinecure = _prefix "Sinecure"
    /// <summary>
    /// The tenure of an individual in a particular Post. This is used to provide some extra information about the period of time during which an individual held a post, or the salary they received, and so on.
    /// <see href="http://reference.data.gov.uk/def/central-government/Tenure"></see></summary>
    let Tenure = _prefix "Tenure"
    /// <summary>
    /// A representation of the amount that someone works.
    /// <see href="http://reference.data.gov.uk/def/central-government/WorkingTime"></see></summary>
    let WorkingTime = _prefix "WorkingTime"
    /// <summary>
    /// The cabinet that this person attends (not as a full member).
    /// <see href="http://reference.data.gov.uk/def/central-government/attendsCabinet"></see></summary>
    let attendsCabinet = _prefix "attendsCabinet"
    /// <summary>
    /// An attendee of this cabinet.
    /// <see href="http://reference.data.gov.uk/def/central-government/hasCabinetAttendee"></see></summary>
    let hasCabinetAttendee = _prefix "hasCabinetAttendee"
    /// <summary>
    /// The government that this is a cabinet committee for.
    /// <see href="http://reference.data.gov.uk/def/central-government/cabinetCommitteeOf"></see></summary>
    let cabinetCommitteeOf = _prefix "cabinetCommitteeOf"
    /// <summary>
    /// A cabinet committee for this government.
    /// <see href="http://reference.data.gov.uk/def/central-government/hasCabinetCommittee"></see></summary>
    let hasCabinetCommittee = _prefix "hasCabinetCommittee"
    /// <summary>
    /// The government or executive that this is the cabinet of.
    /// <see href="http://reference.data.gov.uk/def/central-government/cabinetOf"></see></summary>
    let cabinetOf = _prefix "cabinetOf"
    /// <summary>
    /// The cabinet of this government.
    /// <see href="http://reference.data.gov.uk/def/central-government/hasCabinet"></see></summary>
    let hasCabinet = _prefix "hasCabinet"
    /// <summary>
    /// The committee that this person chairs.
    /// <see href="http://reference.data.gov.uk/def/central-government/chairOf"></see></summary>
    let chairOf = _prefix "chairOf"
    /// <summary>
    /// The chair of this committee.
    /// <see href="http://reference.data.gov.uk/def/central-government/hasChair"></see></summary>
    let hasChair = _prefix "hasChair"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/currency"></see>
    /// </summary>
    let currency = _prefix "currency"
    /// <summary>
    /// The committee that this person is the deputy chair of.
    /// <see href="http://reference.data.gov.uk/def/central-government/deputyChairOf"></see></summary>
    let deputyChairOf = _prefix "deputyChairOf"
    /// <summary>
    /// The deputy chair of this committee.
    /// <see href="http://reference.data.gov.uk/def/central-government/hasDeputyChair"></see></summary>
    let hasDeputyChair = _prefix "hasDeputyChair"
    /// <summary>
    /// The government that this person (the Deputy Prime Minister or Deputy First Minister) is the head of.
    /// <see href="http://reference.data.gov.uk/def/central-government/deputyHeadOfGovernment"></see></summary>
    let deputyHeadOfGovernment = _prefix "deputyHeadOfGovernment"
    /// <summary>
    /// The deputy head of this government (the Deputy Prime Minister or Deputy First Minister).
    /// <see href="http://reference.data.gov.uk/def/central-government/hasGovernmentDeputyHead"></see></summary>
    let hasGovernmentDeputyHead = _prefix "hasGovernmentDeputyHead"
    /// <summary>
    /// A government organisation that this devolved government organisation is devolved from.
    /// <see href="http://reference.data.gov.uk/def/central-government/devolvedFrom"></see></summary>
    let devolvedFrom = _prefix "devolvedFrom"
    /// <summary>
    /// A devolved government organisation that this government organisation devolves power to.
    /// <see href="http://reference.data.gov.uk/def/central-government/devolvesTo"></see></summary>
    let devolvesTo = _prefix "devolvesTo"
    /// <summary>
    /// The base period over which the amount of time spent working is measured.
    /// <see href="http://reference.data.gov.uk/def/central-government/forEvery"></see></summary>
    let forEvery = _prefix "forEvery"
    /// <summary>
    /// The time at which the Government was formed.
    /// <see href="http://reference.data.gov.uk/def/central-government/formedAt"></see></summary>
    let formedAt = _prefix "formedAt"
    /// <summary>
    /// The amount of time spent by the postholder in the post; a full-time equivalent of 1 indicates a full-time post.
    /// <see href="http://reference.data.gov.uk/def/central-government/fullTimeEquivalent"></see></summary>
    let fullTimeEquivalent = _prefix "fullTimeEquivalent"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/fullTimeEquivalentSalary"></see>
    /// </summary>
    let fullTimeEquivalentSalary = _prefix "fullTimeEquivalentSalary"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/salaryRange"></see>
    /// </summary>
    let salaryRange = _prefix "salaryRange"
    /// <summary>
    /// The legislature that this government organisation is associated with.
    /// <see href="http://reference.data.gov.uk/def/central-government/governmentOrganisationOf"></see></summary>
    let governmentOrganisationOf = _prefix "governmentOrganisationOf"
    /// <summary>
    /// A member of this cabinet.
    /// <see href="http://reference.data.gov.uk/def/central-government/hasCabinetMember"></see></summary>
    let hasCabinetMember = _prefix "hasCabinetMember"
    /// <summary>
    /// The cabinet that this person a member of.
    /// <see href="http://reference.data.gov.uk/def/central-government/memberOfCabinet"></see></summary>
    let memberOfCabinet = _prefix "memberOfCabinet"
    /// <summary>
    /// The head of this government (the Prime Minister or First Minister).
    /// <see href="http://reference.data.gov.uk/def/central-government/hasGovernmentHead"></see></summary>
    let hasGovernmentHead = _prefix "hasGovernmentHead"
    /// <summary>
    /// The government that this person (the Prime Minister or First Minister) is the head of.
    /// <see href="http://reference.data.gov.uk/def/central-government/headOfGovernment"></see></summary>
    let headOfGovernment = _prefix "headOfGovernment"
    /// <summary>
    /// Indicates a post within the organisation.
    /// <see href="http://reference.data.gov.uk/def/central-government/hasPost"></see></summary>
    let hasPost = _prefix "hasPost"
    /// <summary>
    /// Indicates the organisation that this is a post within.
    /// <see href="http://reference.data.gov.uk/def/central-government/postIn"></see></summary>
    let postIn = _prefix "postIn"
    /// <summary>
    /// Indicates the agent who holds the post.
    /// <see href="http://reference.data.gov.uk/def/central-government/heldBy"></see></summary>
    let heldBy = _prefix "heldBy"
    /// <summary>
    /// Indicates a post held by someone.
    /// <see href="http://reference.data.gov.uk/def/central-government/holdsPost"></see></summary>
    let holdsPost = _prefix "holdsPost"
    /// <summary>
    /// The lower bound of a salary range.
    /// <see href="http://reference.data.gov.uk/def/central-government/lowerBound"></see></summary>
    let lowerBound = _prefix "lowerBound"
    /// <summary>
    /// A relation between an NDPB or an Executive Agency and their parent Government Department.
    /// <see href="http://reference.data.gov.uk/def/central-government/parentDepartment"></see></summary>
    let parentDepartment = _prefix "parentDepartment"
    /// <summary>
    /// A relation between Minsiterial Departments and their associated Executive Agencies and NDPBs
    /// <see href="http://reference.data.gov.uk/def/central-government/relatedBody"></see></summary>
    let relatedBody = _prefix "relatedBody"
    /// <summary>
    /// The post held in this Tenure
    /// <see href="http://reference.data.gov.uk/def/central-government/post"></see></summary>
    let post = _prefix "post"
    /// <summary>
    /// The postholder in this Tenure
    /// <see href="http://reference.data.gov.uk/def/central-government/postholder"></see></summary>
    let postholder = _prefix "postholder"
    /// <summary>
    /// A description of the relationship between an individual and the post that they occupy.
    /// <see href="http://reference.data.gov.uk/def/central-government/tenure"></see></summary>
    let tenure = _prefix "tenure"
    /// <summary>
    ///   <see href="http://reference.data.gov.uk/def/central-government/salary"></see>
    /// </summary>
    let salary = _prefix "salary"
    /// <summary>
    /// Salary, not including taxable benefits, and not adjusted based on working time.
    /// <see href="http://reference.data.gov.uk/def/central-government/salaryExcludingBenefits"></see></summary>
    let salaryExcludingBenefits = _prefix "salaryExcludingBenefits"
    /// <summary>
    /// Salary including taxable benefits, not adjusted based on working time.
    /// <see href="http://reference.data.gov.uk/def/central-government/salaryIncludingBenefits"></see></summary>
    let salaryIncludingBenefits = _prefix "salaryIncludingBenefits"
    /// <summary>
    /// The government (organisation) that this Government is served by.
    /// <see href="http://reference.data.gov.uk/def/central-government/servedBy"></see></summary>
    let servedBy = _prefix "servedBy"
    /// <summary>
    /// The Government that this government (as an organisation) serves.
    /// <see href="http://reference.data.gov.uk/def/central-government/serves"></see></summary>
    let serves = _prefix "serves"
    /// <summary>
    /// This organisation is supported by object organisation.
    /// <see href="http://reference.data.gov.uk/def/central-government/supportedBy"></see></summary>
    let supportedBy = _prefix "supportedBy"
    /// <summary>
    /// This organisation provides support the object organisation.
    /// <see href="http://reference.data.gov.uk/def/central-government/supports"></see></summary>
    let supports = _prefix "supports"
    /// <summary>
    /// The terms of reference for a committee.
    /// <see href="http://reference.data.gov.uk/def/central-government/termsOfReference"></see></summary>
    let termsOfReference = _prefix "termsOfReference"
    /// <summary>
    /// The amount of time spent working.
    /// <see href="http://reference.data.gov.uk/def/central-government/timePeriod"></see></summary>
    let timePeriod = _prefix "timePeriod"
    /// <summary>
    /// The upper bound of a salary range.
    /// <see href="http://reference.data.gov.uk/def/central-government/upperBound"></see></summary>
    let upperBound = _prefix "upperBound"
    /// <summary>
    /// The contracted minimum working time for the position.
    /// <see href="http://reference.data.gov.uk/def/central-government/workingTime"></see></summary>
    let workingTime = _prefix "workingTime"
