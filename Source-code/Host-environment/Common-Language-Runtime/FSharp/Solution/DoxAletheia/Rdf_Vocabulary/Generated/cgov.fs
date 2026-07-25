namespace http.reference.data.gov.uk.def.central_government.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cgov =
    let _namespace_iri = Namespace_Iri cgov |> NamespaceIRI
    /// <summary>
    ///   <para>cgov:PublicBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A class whose for UK Government related public bodies comprised of Executive Agenices, Ministerial and Non-Ministerial Departments and Non-departmental public bodies.</para>
    /// labels<para>UK Public body</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/PublicBody">http://reference.data.gov.uk/def/central-government/PublicBody</seealso>
    let PublicBody = Prefixed_Name(cgov, "PublicBody") |> PrefixedName

    /// <summary>
    ///   <para>cgov:GovernmentOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Organisations that administer public policy. They serve Governments, and persist as organisations through multiple Governments.</para>
    /// labels<para>Government</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/GovernmentOrganisation">http://reference.data.gov.uk/def/central-government/GovernmentOrganisation</seealso>
    let GovernmentOrganisation =
        Prefixed_Name(cgov, "GovernmentOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>cgov:CivilServicePost</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A post within the civil service</para>
    /// labels<para>Civil Service Post</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/CivilServicePost">http://reference.data.gov.uk/def/central-government/CivilServicePost</seealso>
    let CivilServicePost = Prefixed_Name(cgov, "CivilServicePost") |> PrefixedName

    /// <summary>
    ///   <para>cgov:SeniorCivilServicePost</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A senior post within the civil service</para>
    /// labels<para>Senior Civil Service Post</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/SeniorCivilServicePost">http://reference.data.gov.uk/def/central-government/SeniorCivilServicePost</seealso>
    let SeniorCivilServicePost =
        Prefixed_Name(cgov, "SeniorCivilServicePost") |> PrefixedName

    /// <summary>
    ///   <para>cgov:Department</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Government Department</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/Department">http://reference.data.gov.uk/def/central-government/Department</seealso>
    let Department = Prefixed_Name(cgov, "Department") |> PrefixedName
    /// <summary>
    ///   <para>cgov:holdsPost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a post held by someone.</para>
    /// labels<para>Post</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/holdsPost">http://reference.data.gov.uk/def/central-government/holdsPost</seealso>
    let holdsPost = Prefixed_Name(cgov, "holdsPost") |> PrefixedName
    /// <summary>
    ///   <para>cgov:parentDepartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between an NDPB or an Executive Agency and their parent Government Department.</para>
    /// labels<para>parent department</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/parentDepartment">http://reference.data.gov.uk/def/central-government/parentDepartment</seealso>
    let parentDepartment = Prefixed_Name(cgov, "parentDepartment") |> PrefixedName
    /// <summary>
    ///   <para>cgov:relatedBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A relation between Minsiterial Departments and their associated Executive Agencies and NDPBs</para>
    /// labels<para>related body</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/relatedBody">http://reference.data.gov.uk/def/central-government/relatedBody</seealso>
    let relatedBody = Prefixed_Name(cgov, "relatedBody") |> PrefixedName
    /// <summary>
    ///   <para>cgov:post</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The post held in this Tenure</para>
    /// labels<para>Post</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/post">http://reference.data.gov.uk/def/central-government/post</seealso>
    let post = Prefixed_Name(cgov, "post") |> PrefixedName
    /// <summary>
    ///   <para>cgov:postholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The postholder in this Tenure</para>
    /// labels<para>Postholder</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/postholder">http://reference.data.gov.uk/def/central-government/postholder</seealso>
    let postholder = Prefixed_Name(cgov, "postholder") |> PrefixedName
    /// <summary>
    ///   <para>cgov:salary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Salary</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/salary">http://reference.data.gov.uk/def/central-government/salary</seealso>
    let salary = Prefixed_Name(cgov, "salary") |> PrefixedName

    /// <summary>
    ///   <para>cgov:salaryIncludingBenefits</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Salary including taxable benefits, not adjusted based on working time.</para>
    /// labels<para>Salary Including Benefits</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/salaryIncludingBenefits">http://reference.data.gov.uk/def/central-government/salaryIncludingBenefits</seealso>
    let salaryIncludingBenefits =
        Prefixed_Name(cgov, "salaryIncludingBenefits") |> PrefixedName

    /// <summary>
    ///   <para>cgov:servedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The government (organisation) that this Government is served by.</para>
    /// labels<para>Served By</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/servedBy">http://reference.data.gov.uk/def/central-government/servedBy</seealso>
    let servedBy = Prefixed_Name(cgov, "servedBy") |> PrefixedName
    /// <summary>
    ///   <para>cgov:supportedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This organisation is supported by object organisation.</para>
    /// labels<para>Supported By</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/supportedBy">http://reference.data.gov.uk/def/central-government/supportedBy</seealso>
    let supportedBy = Prefixed_Name(cgov, "supportedBy") |> PrefixedName
    /// <summary>
    ///   <para>cgov:termsOfReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The terms of reference for a committee.</para>
    /// labels<para>Terms of Reference</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/termsOfReference">http://reference.data.gov.uk/def/central-government/termsOfReference</seealso>
    let termsOfReference = Prefixed_Name(cgov, "termsOfReference") |> PrefixedName
    /// <summary>
    ///   <para>cgov:Cabinet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Cabinet is the supreme decision-making body in government, dealing with the big issues of the day and the Government’s overall strategy.</para>
    /// labels<para>Cabinet</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/Cabinet">http://reference.data.gov.uk/def/central-government/Cabinet</seealso>
    let Cabinet = Prefixed_Name(cgov, "Cabinet") |> PrefixedName
    /// <summary>
    ///   <para>cgov:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/">http://reference.data.gov.uk/def/central-government/</seealso>
    let _prefix_iri = Prefixed_Name(cgov, "") |> PrefixedName
    /// <summary>
    ///   <para>cgov:hasCabinetCommittee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A cabinet committee for this government.</para>
    /// labels<para>Cabinet Committee</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/hasCabinetCommittee">http://reference.data.gov.uk/def/central-government/hasCabinetCommittee</seealso>
    let hasCabinetCommittee = Prefixed_Name(cgov, "hasCabinetCommittee") |> PrefixedName
    /// <summary>
    ///   <para>cgov:chairOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The committee that this person chairs.</para>
    /// labels<para>Chairs</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/chairOf">http://reference.data.gov.uk/def/central-government/chairOf</seealso>
    let chairOf = Prefixed_Name(cgov, "chairOf") |> PrefixedName
    /// <summary>
    ///   <para>cgov:AdvisoryNDPB</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Advisory NDPBs – provide independent, expert advice to Ministers on a wide range of issues.  Examples include the Low Pay Commission and the Committee on Standards in Public Life;</para>
    /// labels<para>Advisory NDPB</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/AdvisoryNDPB">http://reference.data.gov.uk/def/central-government/AdvisoryNDPB</seealso>
    let AdvisoryNDPB = Prefixed_Name(cgov, "AdvisoryNDPB") |> PrefixedName

    /// <summary>
    ///   <para>cgov:NonDepartmentalPublicBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A body which has a role in the processes of national Government, but is not a Government Department or part of one, and which accordingly operates to a greater or lesser extent at arm’s length from Ministers.</para>
    /// labels<para>Non-departmental public body</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/NonDepartmentalPublicBody">http://reference.data.gov.uk/def/central-government/NonDepartmentalPublicBody</seealso>
    let NonDepartmentalPublicBody =
        Prefixed_Name(cgov, "NonDepartmentalPublicBody") |> PrefixedName

    /// <summary>
    ///   <para>cgov:ExecutiveNDPB</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Typically established in statute and carrying out executive, administrative, regulatory and/or commercial functions.Examples include the Environment Agency, Regional Development Agencies and national museums and galleries</para>
    /// labels<para>Executive NDPB</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/ExecutiveNDPB">http://reference.data.gov.uk/def/central-government/ExecutiveNDPB</seealso>
    let ExecutiveNDPB = Prefixed_Name(cgov, "ExecutiveNDPB") |> PrefixedName

    /// <summary>
    ///   <para>cgov:MinisterialCommittee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A committee made up of ministers.</para>
    /// labels<para>Ministerial Committee</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/MinisterialCommittee">http://reference.data.gov.uk/def/central-government/MinisterialCommittee</seealso>
    let MinisterialCommittee =
        Prefixed_Name(cgov, "MinisterialCommittee") |> PrefixedName

    /// <summary>
    ///   <para>cgov:CabinetCommittee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Cabinet committees reduce the burden on Cabinet by enabling collective decisions to be taken by a smaller group of ministers.</para>
    ///   <para>These are modelled as being units within government that report to a Cabinet.</para>
    /// labels<para>Cabinet Committee</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/CabinetCommittee">http://reference.data.gov.uk/def/central-government/CabinetCommittee</seealso>
    let CabinetCommittee = Prefixed_Name(cgov, "CabinetCommittee") |> PrefixedName
    /// <summary>
    ///   <para>cgov:Committee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A committee is a kind of organisation that consists purely of meetings.</para>
    /// labels<para>Committee</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/Committee">http://reference.data.gov.uk/def/central-government/Committee</seealso>
    let Committee = Prefixed_Name(cgov, "Committee") |> PrefixedName
    /// <summary>
    ///   <para>cgov:CorporationSole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A legal entity consisting of a single ('sole') incorporated office, occupied by a single ('sole') man or woman.</para>
    /// labels<para>Corporation Sole</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/CorporationSole">http://reference.data.gov.uk/def/central-government/CorporationSole</seealso>
    let CorporationSole = Prefixed_Name(cgov, "CorporationSole") |> PrefixedName
    /// <summary>
    ///   <para>cgov:DeputyDirector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Deputy Director</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/DeputyDirector">http://reference.data.gov.uk/def/central-government/DeputyDirector</seealso>
    let DeputyDirector = Prefixed_Name(cgov, "DeputyDirector") |> PrefixedName

    /// <summary>
    ///   <para>cgov:DeputyParliamentaryCounsel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Deputy Parliamentary Counsel</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/DeputyParliamentaryCounsel">http://reference.data.gov.uk/def/central-government/DeputyParliamentaryCounsel</seealso>
    let DeputyParliamentaryCounsel =
        Prefixed_Name(cgov, "DeputyParliamentaryCounsel") |> PrefixedName

    /// <summary>
    ///   <para>cgov:DevolvedGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Devolved Government</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/DevolvedGovernment">http://reference.data.gov.uk/def/central-government/DevolvedGovernment</seealso>
    let DevolvedGovernment = Prefixed_Name(cgov, "DevolvedGovernment") |> PrefixedName
    /// <summary>
    ///   <para>cgov:Director</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Director</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/Director">http://reference.data.gov.uk/def/central-government/Director</seealso>
    let Director = Prefixed_Name(cgov, "Director") |> PrefixedName
    /// <summary>
    ///   <para>cgov:DirectorGeneral</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Director General</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/DirectorGeneral">http://reference.data.gov.uk/def/central-government/DirectorGeneral</seealso>
    let DirectorGeneral = Prefixed_Name(cgov, "DirectorGeneral") |> PrefixedName
    /// <summary>
    ///   <para>cgov:ExecutiveAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An executive agency, also known as a next-step agency, is a part of a government department that is treated as managerially and budgetarily separate in order to carry out some part of the executive functions of the United Kingdom government, Scottish Government, Welsh Assembly or Northern Ireland Executive</para>
    /// labels<para>Executive agency</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/ExecutiveAgency">http://reference.data.gov.uk/def/central-government/ExecutiveAgency</seealso>
    let ExecutiveAgency = Prefixed_Name(cgov, "ExecutiveAgency") |> PrefixedName
    /// <summary>
    ///   <para>cgov:GreatOfficerOfState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Great Officer of State</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/GreatOfficerOfState">http://reference.data.gov.uk/def/central-government/GreatOfficerOfState</seealso>
    let GreatOfficerOfState = Prefixed_Name(cgov, "GreatOfficerOfState") |> PrefixedName
    /// <summary>
    ///   <para>cgov:MonitoringNDPB</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Independent Monitoring Boards of Prisons, Immigration Removal Centres and Immigration Holding Rooms formerly known as Boards of Visitors, these are independent watchdogs of the prison system.</para>
    /// labels<para>Monitoring NDPBs</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/MonitoringNDPB">http://reference.data.gov.uk/def/central-government/MonitoringNDPB</seealso>
    let MonitoringNDPB = Prefixed_Name(cgov, "MonitoringNDPB") |> PrefixedName
    /// <summary>
    ///   <para>cgov:Counsel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Parliamentary Counsel</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/Counsel">http://reference.data.gov.uk/def/central-government/Counsel</seealso>
    let Counsel = Prefixed_Name(cgov, "Counsel") |> PrefixedName
    /// <summary>
    ///   <para>cgov:devolvesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A devolved government organisation that this government organisation devolves power to.</para>
    /// labels<para>Devolves To</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/devolvesTo">http://reference.data.gov.uk/def/central-government/devolvesTo</seealso>
    let devolvesTo = Prefixed_Name(cgov, "devolvesTo") |> PrefixedName
    /// <summary>
    ///   <para>cgov:formedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The time at which the Government was formed.</para>
    /// labels<para>Formed At</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/formedAt">http://reference.data.gov.uk/def/central-government/formedAt</seealso>
    let formedAt = Prefixed_Name(cgov, "formedAt") |> PrefixedName
    /// <summary>
    ///   <para>cgov:fullTimeEquivalent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The amount of time spent by the postholder in the post; a full-time equivalent of 1 indicates a full-time post.</para>
    /// labels<para>Full-Time Equivalent</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/fullTimeEquivalent">http://reference.data.gov.uk/def/central-government/fullTimeEquivalent</seealso>
    let fullTimeEquivalent = Prefixed_Name(cgov, "fullTimeEquivalent") |> PrefixedName

    /// <summary>
    ///   <para>cgov:fullTimeEquivalentSalary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Full-time Equivalent Salary</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/fullTimeEquivalentSalary">http://reference.data.gov.uk/def/central-government/fullTimeEquivalentSalary</seealso>
    let fullTimeEquivalentSalary =
        Prefixed_Name(cgov, "fullTimeEquivalentSalary") |> PrefixedName

    /// <summary>
    ///   <para>cgov:governmentOrganisationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The legislature that this government organisation is associated with.</para>
    /// labels<para>Government Organisation Of</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/governmentOrganisationOf">http://reference.data.gov.uk/def/central-government/governmentOrganisationOf</seealso>
    let governmentOrganisationOf =
        Prefixed_Name(cgov, "governmentOrganisationOf") |> PrefixedName

    /// <summary>
    ///   <para>cgov:TribunalNDPB</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Tribunal NDPBs have jurisdiction in a specialised field of law. Examples include Valuation Tribunals.</para>
    /// labels<para>Tribunal NDPB</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/TribunalNDPB">http://reference.data.gov.uk/def/central-government/TribunalNDPB</seealso>
    let TribunalNDPB = Prefixed_Name(cgov, "TribunalNDPB") |> PrefixedName

    /// <summary>
    ///   <para>cgov:AssistantParliamentaryCounsel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Assistant Parliamentary Counsel</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/AssistantParliamentaryCounsel">http://reference.data.gov.uk/def/central-government/AssistantParliamentaryCounsel</seealso>
    let AssistantParliamentaryCounsel =
        Prefixed_Name(cgov, "AssistantParliamentaryCounsel") |> PrefixedName

    /// <summary>
    ///   <para>cgov:CivilService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A civil service. In the UK there are three: the Home Civil Service, the Northern Ireland Civil Service and the Foreign Service.</para>
    /// labels<para>Civil Service</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/CivilService">http://reference.data.gov.uk/def/central-government/CivilService</seealso>
    let CivilService = Prefixed_Name(cgov, "CivilService") |> PrefixedName

    /// <summary>
    ///   <para>cgov:CivilServiceCommittee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A committee made up of civil servants.</para>
    /// labels<para>Civil Service Committee</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/CivilServiceCommittee">http://reference.data.gov.uk/def/central-government/CivilServiceCommittee</seealso>
    let CivilServiceCommittee =
        Prefixed_Name(cgov, "CivilServiceCommittee") |> PrefixedName

    /// <summary>
    ///   <para>cgov:Post</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A post that may be occupied by a one or more individuals at a time. This is used for when people are members of organisations ex officio. For example, the Secretary of State for Scotland attends Cabinet by virtue of being the Secretary of State for Scotland, not as an individual person.</para>
    /// labels<para>Post</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/Post">http://reference.data.gov.uk/def/central-government/Post</seealso>
    let Post = Prefixed_Name(cgov, "Post") |> PrefixedName
    /// <summary>
    ///   <para>cgov:hasPost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a post within the organisation.</para>
    /// labels<para>Post</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/hasPost">http://reference.data.gov.uk/def/central-government/hasPost</seealso>
    let hasPost = Prefixed_Name(cgov, "hasPost") |> PrefixedName
    /// <summary>
    ///   <para>cgov:heldBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the agent who holds the post.</para>
    /// labels<para>Postholder</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/heldBy">http://reference.data.gov.uk/def/central-government/heldBy</seealso>
    let heldBy = Prefixed_Name(cgov, "heldBy") |> PrefixedName
    /// <summary>
    ///   <para>cgov:lowerBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The lower bound of a salary range.</para>
    /// labels<para>Lower Bound</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/lowerBound">http://reference.data.gov.uk/def/central-government/lowerBound</seealso>
    let lowerBound = Prefixed_Name(cgov, "lowerBound") |> PrefixedName
    /// <summary>
    ///   <para>cgov:tenure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A description of the relationship between an individual and the post that they occupy.</para>
    /// labels<para>Tenure</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/tenure">http://reference.data.gov.uk/def/central-government/tenure</seealso>
    let tenure = Prefixed_Name(cgov, "tenure") |> PrefixedName

    /// <summary>
    ///   <para>cgov:salaryExcludingBenefits</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Salary, not including taxable benefits, and not adjusted based on working time.</para>
    /// labels<para>Salary Excluding Benefits</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/salaryExcludingBenefits">http://reference.data.gov.uk/def/central-government/salaryExcludingBenefits</seealso>
    let salaryExcludingBenefits =
        Prefixed_Name(cgov, "salaryExcludingBenefits") |> PrefixedName

    /// <summary>
    ///   <para>cgov:serves</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Government that this government (as an organisation) serves.</para>
    /// labels<para>Serves</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/serves">http://reference.data.gov.uk/def/central-government/serves</seealso>
    let serves = Prefixed_Name(cgov, "serves") |> PrefixedName
    /// <summary>
    ///   <para>cgov:supports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This organisation provides support the object organisation.</para>
    /// labels<para>Supports</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/supports">http://reference.data.gov.uk/def/central-government/supports</seealso>
    let supports = Prefixed_Name(cgov, "supports") |> PrefixedName
    /// <summary>
    ///   <para>cgov:timePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The amount of time spent working.</para>
    /// labels<para>Time Period</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/timePeriod">http://reference.data.gov.uk/def/central-government/timePeriod</seealso>
    let timePeriod = Prefixed_Name(cgov, "timePeriod") |> PrefixedName
    /// <summary>
    ///   <para>cgov:upperBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The upper bound of a salary range.</para>
    /// labels<para>Upper Bound</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/upperBound">http://reference.data.gov.uk/def/central-government/upperBound</seealso>
    let upperBound = Prefixed_Name(cgov, "upperBound") |> PrefixedName
    /// <summary>
    ///   <para>cgov:workingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The contracted minimum working time for the position.</para>
    /// labels<para>Working Time</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/workingTime">http://reference.data.gov.uk/def/central-government/workingTime</seealso>
    let workingTime = Prefixed_Name(cgov, "workingTime") |> PrefixedName
    /// <summary>
    ///   <para>cgov:hasDeputyChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The deputy chair of this committee.</para>
    /// labels<para>Deputy Chair</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/hasDeputyChair">http://reference.data.gov.uk/def/central-government/hasDeputyChair</seealso>
    let hasDeputyChair = Prefixed_Name(cgov, "hasDeputyChair") |> PrefixedName
    /// <summary>
    ///   <para>cgov:forEvery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The base period over which the amount of time spent working is measured.</para>
    /// labels<para>For Every</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/forEvery">http://reference.data.gov.uk/def/central-government/forEvery</seealso>
    let forEvery = Prefixed_Name(cgov, "forEvery") |> PrefixedName
    /// <summary>
    ///   <para>cgov:salaryRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Salary Range</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/salaryRange">http://reference.data.gov.uk/def/central-government/salaryRange</seealso>
    let salaryRange = Prefixed_Name(cgov, "salaryRange") |> PrefixedName
    /// <summary>
    ///   <para>cgov:hasCabinetMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A member of this cabinet.</para>
    /// labels<para>Member of Cabinet</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/hasCabinetMember">http://reference.data.gov.uk/def/central-government/hasCabinetMember</seealso>
    let hasCabinetMember = Prefixed_Name(cgov, "hasCabinetMember") |> PrefixedName
    /// <summary>
    ///   <para>cgov:memberOfCabinet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The cabinet that this person a member of.</para>
    /// labels<para>Member of Cabinet</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/memberOfCabinet">http://reference.data.gov.uk/def/central-government/memberOfCabinet</seealso>
    let memberOfCabinet = Prefixed_Name(cgov, "memberOfCabinet") |> PrefixedName
    /// <summary>
    ///   <para>cgov:hasGovernmentHead</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The head of this government (the Prime Minister or First Minister).</para>
    /// labels<para>Head of Government</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/hasGovernmentHead">http://reference.data.gov.uk/def/central-government/hasGovernmentHead</seealso>
    let hasGovernmentHead = Prefixed_Name(cgov, "hasGovernmentHead") |> PrefixedName
    /// <summary>
    ///   <para>cgov:headOfGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The government that this person (the Prime Minister or First Minister) is the head of.</para>
    /// labels<para>Head of Government</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/headOfGovernment">http://reference.data.gov.uk/def/central-government/headOfGovernment</seealso>
    let headOfGovernment = Prefixed_Name(cgov, "headOfGovernment") |> PrefixedName
    /// <summary>
    ///   <para>cgov:postIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the organisation that this is a post within.</para>
    /// labels<para>Organisation</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/postIn">http://reference.data.gov.uk/def/central-government/postIn</seealso>
    let postIn = Prefixed_Name(cgov, "postIn") |> PrefixedName

    /// <summary>
    ///   <para>cgov:DevolvedGovernmentOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Devolved Government</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/DevolvedGovernmentOrganisation">http://reference.data.gov.uk/def/central-government/DevolvedGovernmentOrganisation</seealso>
    let DevolvedGovernmentOrganisation =
        Prefixed_Name(cgov, "DevolvedGovernmentOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>cgov:MinisterOfState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Minister of State</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/MinisterOfState">http://reference.data.gov.uk/def/central-government/MinisterOfState</seealso>
    let MinisterOfState = Prefixed_Name(cgov, "MinisterOfState") |> PrefixedName

    /// <summary>
    ///   <para>cgov:NonMinisterialDepartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A non-ministerial government department is a department or ministry of a government that is not headed by a Government Minister or Government Secretary, and answers directly to a legislature</para>
    /// labels<para>Non-ministerial department</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/NonMinisterialDepartment">http://reference.data.gov.uk/def/central-government/NonMinisterialDepartment</seealso>
    let NonMinisterialDepartment =
        Prefixed_Name(cgov, "NonMinisterialDepartment") |> PrefixedName

    /// <summary>
    ///   <para>cgov:HonorificPost</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Honorific Post</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/HonorificPost">http://reference.data.gov.uk/def/central-government/HonorificPost</seealso>
    let HonorificPost = Prefixed_Name(cgov, "HonorificPost") |> PrefixedName

    /// <summary>
    ///   <para>cgov:MachineryOfGovernmentChangeEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A change in one or more public bodies that may involve a renaming, a reallocation of responsibilities, the transfer of a unit, or various other changes that take place within government structure. Often these changes don't bring about </para>
    /// labels<para>Machinery of Government Change</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/MachineryOfGovernmentChangeEvent">http://reference.data.gov.uk/def/central-government/MachineryOfGovernmentChangeEvent</seealso>
    let MachineryOfGovernmentChangeEvent =
        Prefixed_Name(cgov, "MachineryOfGovernmentChangeEvent") |> PrefixedName

    /// <summary>
    ///   <para>cgov:Minister</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/Minister">http://reference.data.gov.uk/def/central-government/Minister</seealso>
    let Minister = Prefixed_Name(cgov, "Minister") |> PrefixedName
    /// <summary>
    ///   <para>cgov:NonDisclosure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A representation of the non-disclosure of a piece of information.</para>
    /// labels<para>Non-Disclosure</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/NonDisclosure">http://reference.data.gov.uk/def/central-government/NonDisclosure</seealso>
    let NonDisclosure = Prefixed_Name(cgov, "NonDisclosure") |> PrefixedName

    /// <summary>
    ///   <para>cgov:ParliamentaryUnderSecretary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Parliamentary Under-Secretary</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/ParliamentaryUnderSecretary">http://reference.data.gov.uk/def/central-government/ParliamentaryUnderSecretary</seealso>
    let ParliamentaryUnderSecretary =
        Prefixed_Name(cgov, "ParliamentaryUnderSecretary") |> PrefixedName

    /// <summary>
    ///   <para>cgov:Secretariat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An organisation that provides advice and support to another organisation, often a committee.</para>
    /// labels<para>Secretariat</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/Secretariat">http://reference.data.gov.uk/def/central-government/Secretariat</seealso>
    let Secretariat = Prefixed_Name(cgov, "Secretariat") |> PrefixedName
    /// <summary>
    ///   <para>cgov:Sinecure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Sinecure</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/Sinecure">http://reference.data.gov.uk/def/central-government/Sinecure</seealso>
    let Sinecure = Prefixed_Name(cgov, "Sinecure") |> PrefixedName

    /// <summary>
    ///   <para>cgov:MinisterialDepartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Ministerial Departments are led politically by a Government Minister, normally a member of the Cabinet and cover matters that require direct political oversight.</para>
    /// labels<para>Ministerial department</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/MinisterialDepartment">http://reference.data.gov.uk/def/central-government/MinisterialDepartment</seealso>
    let MinisterialDepartment =
        Prefixed_Name(cgov, "MinisterialDepartment") |> PrefixedName

    /// <summary>
    ///   <para>cgov:Government</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A group of ministers, headed by a Prime Minister or First Minister. In America, this would be called an Administration. Each general election brings about the creation of a new Government.</para>
    /// labels<para>Government</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/Government">http://reference.data.gov.uk/def/central-government/Government</seealso>
    let Government = Prefixed_Name(cgov, "Government") |> PrefixedName

    /// <summary>
    ///   <para>cgov:ParliamentaryCounsel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Parliamentary Counsel</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/ParliamentaryCounsel">http://reference.data.gov.uk/def/central-government/ParliamentaryCounsel</seealso>
    let ParliamentaryCounsel =
        Prefixed_Name(cgov, "ParliamentaryCounsel") |> PrefixedName

    /// <summary>
    ///   <para>cgov:PermanentSecretary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The most senior civil servant in a department is a permanent secretary. Each supports the government minister who heads their department and who is accountable to Parliament for the department’s actions and performance.</para>
    /// labels<para>Permanent Secretary</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/PermanentSecretary">http://reference.data.gov.uk/def/central-government/PermanentSecretary</seealso>
    let PermanentSecretary = Prefixed_Name(cgov, "PermanentSecretary") |> PrefixedName

    /// <summary>
    ///   <para>cgov:PrincipalSecretaryOfState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Principal Secretaries of State are the highest-ranking ministers in the government, and most government departments have one Principal Secretary of State (or more). Most Principal Secretaries of State are titled 'Secretary of State' – although some have traditional titles, such as the Chancellor of the Exchequer and the Chief Whip.</para>
    /// labels<para>Principal Secretary of State</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/PrincipalSecretaryOfState">http://reference.data.gov.uk/def/central-government/PrincipalSecretaryOfState</seealso>
    let PrincipalSecretaryOfState =
        Prefixed_Name(cgov, "PrincipalSecretaryOfState") |> PrefixedName

    /// <summary>
    ///   <para>cgov:SalaryRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A salary range.</para>
    /// labels<para>Salary Range</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/SalaryRange">http://reference.data.gov.uk/def/central-government/SalaryRange</seealso>
    let SalaryRange = Prefixed_Name(cgov, "SalaryRange") |> PrefixedName

    /// <summary>
    ///   <para>cgov:SeniorAssistantParliamentaryCounsel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Senior Assistant Parliamentary Counsel</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/SeniorAssistantParliamentaryCounsel">http://reference.data.gov.uk/def/central-government/SeniorAssistantParliamentaryCounsel</seealso>
    let SeniorAssistantParliamentaryCounsel =
        Prefixed_Name(cgov, "SeniorAssistantParliamentaryCounsel") |> PrefixedName

    /// <summary>
    ///   <para>cgov:Tenure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The tenure of an individual in a particular Post. This is used to provide some extra information about the period of time during which an individual held a post, or the salary they received, and so on.</para>
    /// labels<para>Tenure</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/Tenure">http://reference.data.gov.uk/def/central-government/Tenure</seealso>
    let Tenure = Prefixed_Name(cgov, "Tenure") |> PrefixedName
    /// <summary>
    ///   <para>cgov:WorkingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A representation of the amount that someone works.</para>
    /// labels<para>Working Time</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/WorkingTime">http://reference.data.gov.uk/def/central-government/WorkingTime</seealso>
    let WorkingTime = Prefixed_Name(cgov, "WorkingTime") |> PrefixedName
    /// <summary>
    ///   <para>cgov:attendsCabinet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The cabinet that this person attends (not as a full member).</para>
    /// labels<para>Attends Cabinet</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/attendsCabinet">http://reference.data.gov.uk/def/central-government/attendsCabinet</seealso>
    let attendsCabinet = Prefixed_Name(cgov, "attendsCabinet") |> PrefixedName
    /// <summary>
    ///   <para>cgov:hasCabinetAttendee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>An attendee of this cabinet.</para>
    /// labels<para>Cabinet Attendee</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/hasCabinetAttendee">http://reference.data.gov.uk/def/central-government/hasCabinetAttendee</seealso>
    let hasCabinetAttendee = Prefixed_Name(cgov, "hasCabinetAttendee") |> PrefixedName
    /// <summary>
    ///   <para>cgov:cabinetCommitteeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The government that this is a cabinet committee for.</para>
    /// labels<para>Cabinet Committee Of</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/cabinetCommitteeOf">http://reference.data.gov.uk/def/central-government/cabinetCommitteeOf</seealso>
    let cabinetCommitteeOf = Prefixed_Name(cgov, "cabinetCommitteeOf") |> PrefixedName
    /// <summary>
    ///   <para>cgov:cabinetOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The government or executive that this is the cabinet of.</para>
    /// labels<para>Cabinet Of</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/cabinetOf">http://reference.data.gov.uk/def/central-government/cabinetOf</seealso>
    let cabinetOf = Prefixed_Name(cgov, "cabinetOf") |> PrefixedName
    /// <summary>
    ///   <para>cgov:hasCabinet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The cabinet of this government.</para>
    /// labels<para>Cabinet</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/hasCabinet">http://reference.data.gov.uk/def/central-government/hasCabinet</seealso>
    let hasCabinet = Prefixed_Name(cgov, "hasCabinet") |> PrefixedName
    /// <summary>
    ///   <para>cgov:hasChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The chair of this committee.</para>
    /// labels<para>Chair</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/hasChair">http://reference.data.gov.uk/def/central-government/hasChair</seealso>
    let hasChair = Prefixed_Name(cgov, "hasChair") |> PrefixedName
    /// <summary>
    ///   <para>cgov:currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Currency</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/currency">http://reference.data.gov.uk/def/central-government/currency</seealso>
    let currency = Prefixed_Name(cgov, "currency") |> PrefixedName
    /// <summary>
    ///   <para>cgov:deputyChairOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The committee that this person is the deputy chair of.</para>
    /// labels<para>Deputy Chair Of</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/deputyChairOf">http://reference.data.gov.uk/def/central-government/deputyChairOf</seealso>
    let deputyChairOf = Prefixed_Name(cgov, "deputyChairOf") |> PrefixedName

    /// <summary>
    ///   <para>cgov:deputyHeadOfGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The government that this person (the Deputy Prime Minister or Deputy First Minister) is the head of.</para>
    /// labels<para>Deputy Head of Government</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/deputyHeadOfGovernment">http://reference.data.gov.uk/def/central-government/deputyHeadOfGovernment</seealso>
    let deputyHeadOfGovernment =
        Prefixed_Name(cgov, "deputyHeadOfGovernment") |> PrefixedName

    /// <summary>
    ///   <para>cgov:hasGovernmentDeputyHead</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The deputy head of this government (the Deputy Prime Minister or Deputy First Minister).</para>
    /// labels<para>Deputy Head of Government</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/hasGovernmentDeputyHead">http://reference.data.gov.uk/def/central-government/hasGovernmentDeputyHead</seealso>
    let hasGovernmentDeputyHead =
        Prefixed_Name(cgov, "hasGovernmentDeputyHead") |> PrefixedName

    /// <summary>
    ///   <para>cgov:devolvedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A government organisation that this devolved government organisation is devolved from.</para>
    /// labels<para>Devolved From</para></remarks>
    /// <seealso href="http://reference.data.gov.uk/def/central-government/devolvedFrom">http://reference.data.gov.uk/def/central-government/devolvedFrom</seealso>
    let devolvedFrom = Prefixed_Name(cgov, "devolvedFrom") |> PrefixedName
