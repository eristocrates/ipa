#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cgov =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://reference.data.gov.uk/def/central-government/" "cgov"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Advisory NDPB</para>
    ///   <para>skos:prefLabel : Advisory NDPB</para>
    ///   <para>rdfs:comment : Advisory NDPBs – provide independent, expert advice to Ministers on a wide range of issues.  Examples include the Low Pay Commission and the Committee on Standards in Public Life;</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/AdvisoryNDPB">cgov:AdvisoryNDPB</a>
    /// </summary>
    let AdvisoryNDPB = _prefixId.prefix "AdvisoryNDPB"
    /// <summary>
    ///   <para>rdfs:label : Assistant Parliamentary Counsel</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/AssistantParliamentaryCounsel">cgov:AssistantParliamentaryCounsel</a>
    /// </summary>
    let AssistantParliamentaryCounsel = _prefixId.prefix "AssistantParliamentaryCounsel"
    /// <summary>
    ///   <para>skos:prefLabel : Cabinet</para>
    ///   <para>rdfs:label : Cabinet</para>
    ///   <para>rdfs:comment : Cabinet is the supreme decision-making body in government, dealing with the big issues of the day and the Government’s overall strategy.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/Cabinet">cgov:Cabinet</a>
    /// </summary>
    let Cabinet = _prefixId.prefix "Cabinet"
    /// <summary>
    ///   <para>skos:prefLabel : Cabinet Committee</para>
    ///   <para>rdfs:label : Cabinet Committee</para>
    ///   <para>rdfs:comment : Cabinet committees reduce the burden on Cabinet by enabling collective decisions to be taken by a smaller group of ministers.rdfs:comment : These are modelled as being units within government that report to a Cabinet.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/CabinetCommittee">cgov:CabinetCommittee</a>
    /// </summary>
    let CabinetCommittee = _prefixId.prefix "CabinetCommittee"
    /// <summary>
    ///   <para>rdfs:label : Civil Service</para>
    ///   <para>rdfs:comment : A civil service. In the UK there are three: the Home Civil Service, the Northern Ireland Civil Service and the Foreign Service.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/CivilService">cgov:CivilService</a>
    /// </summary>
    let CivilService = _prefixId.prefix "CivilService"
    /// <summary>
    ///   <para>rdfs:label : Civil Service Committee</para>
    ///   <para>rdfs:comment : A committee made up of civil servants.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/CivilServiceCommittee">cgov:CivilServiceCommittee</a>
    /// </summary>
    let CivilServiceCommittee = _prefixId.prefix "CivilServiceCommittee"
    /// <summary>
    ///   <para>rdfs:label : Civil Service Post</para>
    ///   <para>rdfs:comment : A post within the civil service</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/CivilServicePost">cgov:CivilServicePost</a>
    /// </summary>
    let CivilServicePost = _prefixId.prefix "CivilServicePost"
    /// <summary>
    ///   <para>rdfs:label : Committee</para>
    ///   <para>rdfs:comment : A committee is a kind of organisation that consists purely of meetings.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/Committee">cgov:Committee</a>
    /// </summary>
    let Committee = _prefixId.prefix "Committee"
    /// <summary>
    ///   <para>skos:editorialNote : This is a subclass of org:FormalOrganization by virtue of the fact that it has multiple members over a period of time, though by definition it only has one member at any one time.</para>
    ///   <para>rdfs:label : Corporation Sole</para>
    ///   <para>rdfs:comment : A legal entity consisting of a single ('sole') incorporated office, occupied by a single ('sole') man or woman.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/CorporationSole">cgov:CorporationSole</a>
    /// </summary>
    let CorporationSole = _prefixId.prefix "CorporationSole"
    /// <summary>
    ///   <para>rdfs:label : Parliamentary Counsel</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/Counsel">cgov:Counsel</a>
    /// </summary>
    let Counsel = _prefixId.prefix "Counsel"
    /// <summary>
    ///   <para>skos:prefLabel : Government Department</para>
    ///   <para>rdfs:label : Government Department</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/Department">cgov:Department</a>
    /// </summary>
    let Department = _prefixId.prefix "Department"
    /// <summary>
    ///   <para>rdfs:label : Deputy Director</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/DeputyDirector">cgov:DeputyDirector</a>
    /// </summary>
    let DeputyDirector = _prefixId.prefix "DeputyDirector"
    /// <summary>
    ///   <para>rdfs:label : Deputy Parliamentary Counsel</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/DeputyParliamentaryCounsel">cgov:DeputyParliamentaryCounsel</a>
    /// </summary>
    let DeputyParliamentaryCounsel = _prefixId.prefix "DeputyParliamentaryCounsel"
    /// <summary>
    ///   <para>skos:prefLabel : Devolved Government</para>
    ///   <para>skos:altLabel : Executive</para>
    ///   <para>rdfs:label : Devolved Government</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/DevolvedGovernment">cgov:DevolvedGovernment</a>
    /// </summary>
    let DevolvedGovernment = _prefixId.prefix "DevolvedGovernment"

    /// <summary>
    ///   <para>skos:prefLabel : Devolved Government</para>
    ///   <para>skos:altLabel : Executive</para>
    ///   <para>rdfs:label : Devolved Government</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/DevolvedGovernmentOrganisation">cgov:DevolvedGovernmentOrganisation</a>
    /// </summary>
    let DevolvedGovernmentOrganisation =
        _prefixId.prefix "DevolvedGovernmentOrganisation"

    /// <summary>
    ///   <para>rdfs:label : Director</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/Director">cgov:Director</a>
    /// </summary>
    let Director = _prefixId.prefix "Director"
    /// <summary>
    ///   <para>rdfs:label : Director General</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/DirectorGeneral">cgov:DirectorGeneral</a>
    /// </summary>
    let DirectorGeneral = _prefixId.prefix "DirectorGeneral"
    /// <summary>
    ///   <para>skos:prefLabel : Executive agency</para>
    ///   <para>rdfs:comment : An executive agency, also known as a next-step agency, is a part of a government department that is treated as managerially and budgetarily separate in order to carry out some part of the executive functions of the United Kingdom government, Scottish Government, Welsh Assembly or Northern Ireland Executive</para>
    ///   <para>rdfs:label : Executive agency</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/ExecutiveAgency">cgov:ExecutiveAgency</a>
    /// </summary>
    let ExecutiveAgency = _prefixId.prefix "ExecutiveAgency"
    /// <summary>
    ///   <para>rdfs:comment : Typically established in statute and carrying out executive, administrative, regulatory and/or commercial functions.Examples include the Environment Agency, Regional Development Agencies and national museums and galleries</para>
    ///   <para>rdfs:label : Executive NDPB</para>
    ///   <para>skos:prefLabel : Executive NDPB</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/ExecutiveNDPB">cgov:ExecutiveNDPB</a>
    /// </summary>
    let ExecutiveNDPB = _prefixId.prefix "ExecutiveNDPB"
    /// <summary>
    ///   <para>rdfs:label : Government</para>
    ///   <para>rdfs:comment : A group of ministers, headed by a Prime Minister or First Minister. In America, this would be called an Administration. Each general election brings about the creation of a new Government.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/Government">cgov:Government</a>
    /// </summary>
    let Government = _prefixId.prefix "Government"
    /// <summary>
    ///   <para>rdfs:label : Government</para>
    ///   <para>rdfs:comment : Organisations that administer public policy. They serve Governments, and persist as organisations through multiple Governments.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/GovernmentOrganisation">cgov:GovernmentOrganisation</a>
    /// </summary>
    let GovernmentOrganisation = _prefixId.prefix "GovernmentOrganisation"
    /// <summary>
    ///   <para>rdfs:label : Great Officer of State</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/GreatOfficerOfState">cgov:GreatOfficerOfState</a>
    /// </summary>
    let GreatOfficerOfState = _prefixId.prefix "GreatOfficerOfState"
    /// <summary>
    ///   <para>rdfs:label : Honorific Post</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/HonorificPost">cgov:HonorificPost</a>
    /// </summary>
    let HonorificPost = _prefixId.prefix "HonorificPost"

    /// <summary>
    ///   <para>rdfs:label : Machinery of Government Change</para>
    ///   <para>rdfs:comment : A change in one or more public bodies that may involve a renaming, a reallocation of responsibilities, the transfer of a unit, or various other changes that take place within government structure. Often these changes don't bring about </para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/MachineryOfGovernmentChangeEvent">cgov:MachineryOfGovernmentChangeEvent</a>
    /// </summary>
    let MachineryOfGovernmentChangeEvent =
        _prefixId.prefix "MachineryOfGovernmentChangeEvent"

    /// <summary>
    ///   <para>skos:prefLabel : Minister</para>
    ///   <para>skos:altLabel : Minister of the Crown</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/Minister">cgov:Minister</a>
    /// </summary>
    let Minister = _prefixId.prefix "Minister"
    /// <summary>
    ///   <para>rdfs:label : Minister of State</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/MinisterOfState">cgov:MinisterOfState</a>
    /// </summary>
    let MinisterOfState = _prefixId.prefix "MinisterOfState"
    /// <summary>
    ///   <para>rdfs:label : Ministerial Committee</para>
    ///   <para>rdfs:comment : A committee made up of ministers.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/MinisterialCommittee">cgov:MinisterialCommittee</a>
    /// </summary>
    let MinisterialCommittee = _prefixId.prefix "MinisterialCommittee"
    /// <summary>
    ///   <para>rdfs:label : Ministerial department</para>
    ///   <para>rdfs:comment : Ministerial Departments are led politically by a Government Minister, normally a member of the Cabinet and cover matters that require direct political oversight.</para>
    ///   <para>skos:prefLabel : Ministerial department</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/MinisterialDepartment">cgov:MinisterialDepartment</a>
    /// </summary>
    let MinisterialDepartment = _prefixId.prefix "MinisterialDepartment"
    /// <summary>
    ///   <para>skos:prefLabel : Monitoring NDPBs</para>
    ///   <para>rdfs:label : Monitoring NDPBs</para>
    ///   <para>rdfs:comment : Independent Monitoring Boards of Prisons, Immigration Removal Centres and Immigration Holding Rooms formerly known as Boards of Visitors, these are independent watchdogs of the prison system.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/MonitoringNDPB">cgov:MonitoringNDPB</a>
    /// </summary>
    let MonitoringNDPB = _prefixId.prefix "MonitoringNDPB"
    /// <summary>
    ///   <para>rdfs:label : Non-departmental public body</para>
    ///   <para>skos:prefLabel : Non-departmental public body</para>
    ///   <para>skos:altLabel : NDPB</para>
    ///   <para>rdfs:comment : A body which has a role in the processes of national Government, but is not a Government Department or part of one, and which accordingly operates to a greater or lesser extent at arm’s length from Ministers.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/NonDepartmentalPublicBody">cgov:NonDepartmentalPublicBody</a>
    /// </summary>
    let NonDepartmentalPublicBody = _prefixId.prefix "NonDepartmentalPublicBody"
    /// <summary>
    ///   <para>rdfs:label : Non-Disclosure</para>
    ///   <para>rdfs:comment : A representation of the non-disclosure of a piece of information.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/NonDisclosure">cgov:NonDisclosure</a>
    /// </summary>
    let NonDisclosure = _prefixId.prefix "NonDisclosure"
    /// <summary>
    ///   <para>skos:prefLabel : Non-ministerial department</para>
    ///   <para>rdfs:label : Non-ministerial department</para>
    ///   <para>rdfs:comment : A non-ministerial government department is a department or ministry of a government that is not headed by a Government Minister or Government Secretary, and answers directly to a legislature</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/NonMinisterialDepartment">cgov:NonMinisterialDepartment</a>
    /// </summary>
    let NonMinisterialDepartment = _prefixId.prefix "NonMinisterialDepartment"
    /// <summary>
    ///   <para>rdfs:label : Parliamentary Counsel</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/ParliamentaryCounsel">cgov:ParliamentaryCounsel</a>
    /// </summary>
    let ParliamentaryCounsel = _prefixId.prefix "ParliamentaryCounsel"
    /// <summary>
    ///   <para>rdfs:label : Parliamentary Under-Secretary</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/ParliamentaryUnderSecretary">cgov:ParliamentaryUnderSecretary</a>
    /// </summary>
    let ParliamentaryUnderSecretary = _prefixId.prefix "ParliamentaryUnderSecretary"
    /// <summary>
    ///   <para>rdfs:label : Permanent Secretary</para>
    ///   <para>rdfs:comment : The most senior civil servant in a department is a permanent secretary. Each supports the government minister who heads their department and who is accountable to Parliament for the department’s actions and performance.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/PermanentSecretary">cgov:PermanentSecretary</a>
    /// </summary>
    let PermanentSecretary = _prefixId.prefix "PermanentSecretary"
    /// <summary>
    ///   <para>skos:editorialNote : This is a subclass of org:Organization by virtue of the fact that a post may have multiple holders at the same time, or over a period of time.</para>
    ///   <para>rdfs:label : Post</para>
    ///   <para>rdfs:comment : A post that may be occupied by a one or more individuals at a time. This is used for when people are members of organisations ex officio. For example, the Secretary of State for Scotland attends Cabinet by virtue of being the Secretary of State for Scotland, not as an individual person.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/Post">cgov:Post</a>
    /// </summary>
    let Post = _prefixId.prefix "Post"
    /// <summary>
    ///   <para>skos:prefLabel : Principal Secretary of State</para>
    ///   <para>skos:altLabel : Her Majesty's Principal Secretary of State</para>
    ///   <para>rdfs:label : Principal Secretary of State</para>
    ///   <para>rdfs:comment : Principal Secretaries of State are the highest-ranking ministers in the government, and most government departments have one Principal Secretary of State (or more). Most Principal Secretaries of State are titled 'Secretary of State' – although some have traditional titles, such as the Chancellor of the Exchequer and the Chief Whip.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/PrincipalSecretaryOfState">cgov:PrincipalSecretaryOfState</a>
    /// </summary>
    let PrincipalSecretaryOfState = _prefixId.prefix "PrincipalSecretaryOfState"
    /// <summary>
    ///   <para>skos:prefLabel : UK Public body</para>
    ///   <para>rdfs:label : UK Public body</para>
    ///   <para>rdfs:comment : A class whose for UK Government related public bodies comprised of Executive Agenices, Ministerial and Non-Ministerial Departments and Non-departmental public bodies.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/PublicBody">cgov:PublicBody</a>
    /// </summary>
    let PublicBody = _prefixId.prefix "PublicBody"
    /// <summary>
    ///   <para>rdfs:label : Salary Range</para>
    ///   <para>rdfs:comment : A salary range.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/SalaryRange">cgov:SalaryRange</a>
    /// </summary>
    let SalaryRange = _prefixId.prefix "SalaryRange"
    /// <summary>
    ///   <para>rdfs:label : Secretariat</para>
    ///   <para>rdfs:comment : An organisation that provides advice and support to another organisation, often a committee.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/Secretariat">cgov:Secretariat</a>
    /// </summary>
    let Secretariat = _prefixId.prefix "Secretariat"

    /// <summary>
    ///   <para>rdfs:label : Senior Assistant Parliamentary Counsel</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/SeniorAssistantParliamentaryCounsel">cgov:SeniorAssistantParliamentaryCounsel</a>
    /// </summary>
    let SeniorAssistantParliamentaryCounsel =
        _prefixId.prefix "SeniorAssistantParliamentaryCounsel"

    /// <summary>
    ///   <para>rdfs:label : Senior Civil Service Post</para>
    ///   <para>rdfs:comment : A senior post within the civil service</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/SeniorCivilServicePost">cgov:SeniorCivilServicePost</a>
    /// </summary>
    let SeniorCivilServicePost = _prefixId.prefix "SeniorCivilServicePost"
    /// <summary>
    ///   <para>rdfs:label : Sinecure</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/Sinecure">cgov:Sinecure</a>
    /// </summary>
    let Sinecure = _prefixId.prefix "Sinecure"
    /// <summary>
    ///   <para>rdfs:label : Tenure</para>
    ///   <para>rdfs:comment : The tenure of an individual in a particular Post. This is used to provide some extra information about the period of time during which an individual held a post, or the salary they received, and so on.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/Tenure">cgov:Tenure</a>
    /// </summary>
    let Tenure = _prefixId.prefix "Tenure"
    /// <summary>
    ///   <para>rdfs:label : Tribunal NDPB</para>
    ///   <para>skos:prefLabel : Tribunal NDPB</para>
    ///   <para>rdfs:comment : Tribunal NDPBs have jurisdiction in a specialised field of law. Examples include Valuation Tribunals.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/TribunalNDPB">cgov:TribunalNDPB</a>
    /// </summary>
    let TribunalNDPB = _prefixId.prefix "TribunalNDPB"
    /// <summary>
    ///   <para>rdfs:label : Working Time</para>
    ///   <para>rdfs:comment : A representation of the amount that someone works.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/WorkingTime">cgov:WorkingTime</a>
    /// </summary>
    let WorkingTime = _prefixId.prefix "WorkingTime"
    /// <summary>
    ///   <para>rdfs:label : Attends Cabinet</para>
    ///   <para>rdfs:comment : The cabinet that this person attends (not as a full member).</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/attendsCabinet">cgov:attendsCabinet</a>
    /// </summary>
    let attendsCabinet = _prefixId.prefix "attendsCabinet"
    /// <summary>
    ///   <para>rdfs:label : Cabinet Committee Of</para>
    ///   <para>rdfs:comment : The government that this is a cabinet committee for.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/cabinetCommitteeOf">cgov:cabinetCommitteeOf</a>
    /// </summary>
    let cabinetCommitteeOf = _prefixId.prefix "cabinetCommitteeOf"
    /// <summary>
    ///   <para>rdfs:label : Cabinet Of</para>
    ///   <para>rdfs:comment : The government or executive that this is the cabinet of.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/cabinetOf">cgov:cabinetOf</a>
    /// </summary>
    let cabinetOf = _prefixId.prefix "cabinetOf"
    /// <summary>
    ///   <para>rdfs:label : Chairs</para>
    ///   <para>rdfs:comment : The committee that this person chairs.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/chairOf">cgov:chairOf</a>
    /// </summary>
    let chairOf = _prefixId.prefix "chairOf"
    /// <summary>
    ///   <para>rdfs:label : Currency</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/currency">cgov:currency</a>
    /// </summary>
    let currency = _prefixId.prefix "currency"
    /// <summary>
    ///   <para>rdfs:label : Deputy Chair Of</para>
    ///   <para>rdfs:comment : The committee that this person is the deputy chair of.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/deputyChairOf">cgov:deputyChairOf</a>
    /// </summary>
    let deputyChairOf = _prefixId.prefix "deputyChairOf"
    /// <summary>
    ///   <para>rdfs:label : Deputy Head of Government</para>
    ///   <para>rdfs:comment : The government that this person (the Deputy Prime Minister or Deputy First Minister) is the head of.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/deputyHeadOfGovernment">cgov:deputyHeadOfGovernment</a>
    /// </summary>
    let deputyHeadOfGovernment = _prefixId.prefix "deputyHeadOfGovernment"
    /// <summary>
    ///   <para>rdfs:label : Devolved From</para>
    ///   <para>rdfs:comment : A government organisation that this devolved government organisation is devolved from.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/devolvedFrom">cgov:devolvedFrom</a>
    /// </summary>
    let devolvedFrom = _prefixId.prefix "devolvedFrom"
    /// <summary>
    ///   <para>rdfs:label : Devolves To</para>
    ///   <para>rdfs:comment : A devolved government organisation that this government organisation devolves power to.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/devolvesTo">cgov:devolvesTo</a>
    /// </summary>
    let devolvesTo = _prefixId.prefix "devolvesTo"
    /// <summary>
    ///   <para>rdfs:label : For Every</para>
    ///   <para>rdfs:comment : The base period over which the amount of time spent working is measured.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/forEvery">cgov:forEvery</a>
    /// </summary>
    let forEvery = _prefixId.prefix "forEvery"
    /// <summary>
    ///   <para>rdfs:label : Formed At</para>
    ///   <para>rdfs:comment : The time at which the Government was formed.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/formedAt">cgov:formedAt</a>
    /// </summary>
    let formedAt = _prefixId.prefix "formedAt"
    /// <summary>
    ///   <para>rdfs:label : Full-Time Equivalent</para>
    ///   <para>rdfs:comment : The amount of time spent by the postholder in the post; a full-time equivalent of 1 indicates a full-time post.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/fullTimeEquivalent">cgov:fullTimeEquivalent</a>
    /// </summary>
    let fullTimeEquivalent = _prefixId.prefix "fullTimeEquivalent"
    /// <summary>
    ///   <para>rdfs:label : Full-time Equivalent Salary</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/fullTimeEquivalentSalary">cgov:fullTimeEquivalentSalary</a>
    /// </summary>
    let fullTimeEquivalentSalary = _prefixId.prefix "fullTimeEquivalentSalary"
    /// <summary>
    ///   <para>rdfs:label : Government Organisation Of</para>
    ///   <para>rdfs:comment : The legislature that this government organisation is associated with.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/governmentOrganisationOf">cgov:governmentOrganisationOf</a>
    /// </summary>
    let governmentOrganisationOf = _prefixId.prefix "governmentOrganisationOf"
    /// <summary>
    ///   <para>rdfs:label : Cabinet</para>
    ///   <para>rdfs:comment : The cabinet of this government.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/hasCabinet">cgov:hasCabinet</a>
    /// </summary>
    let hasCabinet = _prefixId.prefix "hasCabinet"
    /// <summary>
    ///   <para>rdfs:label : Cabinet Attendee</para>
    ///   <para>rdfs:comment : An attendee of this cabinet.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/hasCabinetAttendee">cgov:hasCabinetAttendee</a>
    /// </summary>
    let hasCabinetAttendee = _prefixId.prefix "hasCabinetAttendee"
    /// <summary>
    ///   <para>rdfs:label : Cabinet Committee</para>
    ///   <para>rdfs:comment : A cabinet committee for this government.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/hasCabinetCommittee">cgov:hasCabinetCommittee</a>
    /// </summary>
    let hasCabinetCommittee = _prefixId.prefix "hasCabinetCommittee"
    /// <summary>
    ///   <para>rdfs:label : Member of Cabinet</para>
    ///   <para>rdfs:comment : A member of this cabinet.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/hasCabinetMember">cgov:hasCabinetMember</a>
    /// </summary>
    let hasCabinetMember = _prefixId.prefix "hasCabinetMember"
    /// <summary>
    ///   <para>rdfs:label : Chair</para>
    ///   <para>rdfs:comment : The chair of this committee.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/hasChair">cgov:hasChair</a>
    /// </summary>
    let hasChair = _prefixId.prefix "hasChair"
    /// <summary>
    ///   <para>rdfs:label : Deputy Chair</para>
    ///   <para>rdfs:comment : The deputy chair of this committee.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/hasDeputyChair">cgov:hasDeputyChair</a>
    /// </summary>
    let hasDeputyChair = _prefixId.prefix "hasDeputyChair"
    /// <summary>
    ///   <para>rdfs:label : Deputy Head of Government</para>
    ///   <para>rdfs:comment : The deputy head of this government (the Deputy Prime Minister or Deputy First Minister).</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/hasGovernmentDeputyHead">cgov:hasGovernmentDeputyHead</a>
    /// </summary>
    let hasGovernmentDeputyHead = _prefixId.prefix "hasGovernmentDeputyHead"
    /// <summary>
    ///   <para>rdfs:label : Head of Government</para>
    ///   <para>rdfs:comment : The head of this government (the Prime Minister or First Minister).</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/hasGovernmentHead">cgov:hasGovernmentHead</a>
    /// </summary>
    let hasGovernmentHead = _prefixId.prefix "hasGovernmentHead"
    /// <summary>
    ///   <para>rdfs:label : Post</para>
    ///   <para>rdfs:comment : Indicates a post within the organisation.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/hasPost">cgov:hasPost</a>
    /// </summary>
    let hasPost = _prefixId.prefix "hasPost"
    /// <summary>
    ///   <para>rdfs:label : Head of Government</para>
    ///   <para>rdfs:comment : The government that this person (the Prime Minister or First Minister) is the head of.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/headOfGovernment">cgov:headOfGovernment</a>
    /// </summary>
    let headOfGovernment = _prefixId.prefix "headOfGovernment"
    /// <summary>
    ///   <para>rdfs:label : Postholder</para>
    ///   <para>rdfs:comment : Indicates the agent who holds the post.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/heldBy">cgov:heldBy</a>
    /// </summary>
    let heldBy = _prefixId.prefix "heldBy"
    /// <summary>
    ///   <para>rdfs:label : Post</para>
    ///   <para>rdfs:comment : Indicates a post held by someone.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/holdsPost">cgov:holdsPost</a>
    /// </summary>
    let holdsPost = _prefixId.prefix "holdsPost"
    /// <summary>
    ///   <para>rdfs:label : Lower Bound</para>
    ///   <para>rdfs:comment : The lower bound of a salary range.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/lowerBound">cgov:lowerBound</a>
    /// </summary>
    let lowerBound = _prefixId.prefix "lowerBound"
    /// <summary>
    ///   <para>rdfs:label : Member of Cabinet</para>
    ///   <para>rdfs:comment : The cabinet that this person a member of.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/memberOfCabinet">cgov:memberOfCabinet</a>
    /// </summary>
    let memberOfCabinet = _prefixId.prefix "memberOfCabinet"
    /// <summary>
    ///   <para>rdfs:comment : A relation between an NDPB or an Executive Agency and their parent Government Department.</para>
    ///   <para>skos:prefLabel : parent department</para>
    ///   <para>rdfs:label : parent department</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/parentDepartment">cgov:parentDepartment</a>
    /// </summary>
    let parentDepartment = _prefixId.prefix "parentDepartment"
    /// <summary>
    ///   <para>rdfs:label : Post</para>
    ///   <para>rdfs:comment : The post held in this Tenure</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/post">cgov:post</a>
    /// </summary>
    let post = _prefixId.prefix "post"
    /// <summary>
    ///   <para>rdfs:label : Organisation</para>
    ///   <para>rdfs:comment : Indicates the organisation that this is a post within.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/postIn">cgov:postIn</a>
    /// </summary>
    let postIn = _prefixId.prefix "postIn"
    /// <summary>
    ///   <para>rdfs:label : Postholder</para>
    ///   <para>rdfs:comment : The postholder in this Tenure</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/postholder">cgov:postholder</a>
    /// </summary>
    let postholder = _prefixId.prefix "postholder"
    /// <summary>
    ///   <para>rdfs:label : related body</para>
    ///   <para>skos:prefLabel : related body</para>
    ///   <para>rdfs:comment : A relation between Minsiterial Departments and their associated Executive Agencies and NDPBs</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/relatedBody">cgov:relatedBody</a>
    /// </summary>
    let relatedBody = _prefixId.prefix "relatedBody"
    /// <summary>
    ///   <para>rdfs:label : Salary</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/salary">cgov:salary</a>
    /// </summary>
    let salary = _prefixId.prefix "salary"
    /// <summary>
    ///   <para>rdfs:label : Salary Excluding Benefits</para>
    ///   <para>rdfs:comment : Salary, not including taxable benefits, and not adjusted based on working time.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/salaryExcludingBenefits">cgov:salaryExcludingBenefits</a>
    /// </summary>
    let salaryExcludingBenefits = _prefixId.prefix "salaryExcludingBenefits"
    /// <summary>
    ///   <para>rdfs:label : Salary Including Benefits</para>
    ///   <para>rdfs:comment : Salary including taxable benefits, not adjusted based on working time.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/salaryIncludingBenefits">cgov:salaryIncludingBenefits</a>
    /// </summary>
    let salaryIncludingBenefits = _prefixId.prefix "salaryIncludingBenefits"
    /// <summary>
    ///   <para>rdfs:label : Salary Range</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/salaryRange">cgov:salaryRange</a>
    /// </summary>
    let salaryRange = _prefixId.prefix "salaryRange"
    /// <summary>
    ///   <para>rdfs:label : Served By</para>
    ///   <para>rdfs:comment : The government (organisation) that this Government is served by.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/servedBy">cgov:servedBy</a>
    /// </summary>
    let servedBy = _prefixId.prefix "servedBy"
    /// <summary>
    ///   <para>rdfs:label : Serves</para>
    ///   <para>rdfs:comment : The Government that this government (as an organisation) serves.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/serves">cgov:serves</a>
    /// </summary>
    let serves = _prefixId.prefix "serves"
    /// <summary>
    ///   <para>rdfs:label : Supported By</para>
    ///   <para>rdfs:comment : This organisation is supported by object organisation.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/supportedBy">cgov:supportedBy</a>
    /// </summary>
    let supportedBy = _prefixId.prefix "supportedBy"
    /// <summary>
    ///   <para>rdfs:label : Supports</para>
    ///   <para>rdfs:comment : This organisation provides support the object organisation.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/supports">cgov:supports</a>
    /// </summary>
    let supports = _prefixId.prefix "supports"
    /// <summary>
    ///   <para>rdfs:label : Tenure</para>
    ///   <para>rdfs:comment : A description of the relationship between an individual and the post that they occupy.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/tenure">cgov:tenure</a>
    /// </summary>
    let tenure = _prefixId.prefix "tenure"
    /// <summary>
    ///   <para>skos:editorialNote : The range of gov:termsOfReference is kept deliberately open; it could be a literal string or a reference to a separate document as appropriate.</para>
    ///   <para>rdfs:label : Terms of Reference</para>
    ///   <para>rdfs:comment : The terms of reference for a committee.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/termsOfReference">cgov:termsOfReference</a>
    /// </summary>
    let termsOfReference = _prefixId.prefix "termsOfReference"
    /// <summary>
    ///   <para>rdfs:label : Time Period</para>
    ///   <para>rdfs:comment : The amount of time spent working.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/timePeriod">cgov:timePeriod</a>
    /// </summary>
    let timePeriod = _prefixId.prefix "timePeriod"
    /// <summary>
    ///   <para>rdfs:label : Upper Bound</para>
    ///   <para>rdfs:comment : The upper bound of a salary range.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/upperBound">cgov:upperBound</a>
    /// </summary>
    let upperBound = _prefixId.prefix "upperBound"
    /// <summary>
    ///   <para>rdfs:label : Working Time</para>
    ///   <para>rdfs:comment : The contracted minimum working time for the position.</para>
    ///   <a href="http://reference.data.gov.uk/def/central-government/workingTime">cgov:workingTime</a>
    /// </summary>
    let workingTime = _prefixId.prefix "workingTime"
