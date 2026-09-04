#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dg =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/dingo#" "dg"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : AcademicDegree^^xsd:string</para>
    ///   <para>rdfs:comment : The class for academic degrees: college or university diploma.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#AcademicDegree">dg:AcademicDegree</a>
    /// </summary>
    let AcademicDegree = _prefixId.prefix "AcademicDegree"
    /// <summary>
    ///   <para>rdfs:label : AgeCriterion^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies that grants are awarded to projects on the basis of age limits.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#AgeCriterion">dg:AgeCriterion</a>
    /// </summary>
    let AgeCriterion = _prefixId.prefix "AgeCriterion"
    /// <summary>
    ///   <para>rdfs:label : ArchiveOrganisation^^xsd:string</para>
    ///   <para>rdfs:comment : Institution that holds artifacts and other objects of scientific, artistic, cultural, historical, or other importance.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#ArchiveOrganisation">dg:ArchiveOrganisation</a>
    /// </summary>
    let ArchiveOrganisation = _prefixId.prefix "ArchiveOrganisation"
    /// <summary>
    ///   <para>rdfs:label : BottomUpCriterion^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies that grants are awarded to projects on the basis of the research proposal itself without restriction on theme/subject or research area. The funding body does not specifies beforehand missions, targets nor topics of the research projects that can apply.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#BottomUpCriterion">dg:BottomUpCriterion</a>
    /// </summary>
    let BottomUpCriterion = _prefixId.prefix "BottomUpCriterion"
    /// <summary>
    ///   <para>rdfs:label : CareerPurposeCriterion^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies that grants are awarded on the basis of career-related goals and applicants must be at a defined career stage (defined academic degree) to be achieved.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#CareerPurposeCriterion">dg:CareerPurposeCriterion</a>
    /// </summary>
    let CareerPurposeCriterion = _prefixId.prefix "CareerPurposeCriterion"
    /// <summary>
    ///   <para>rdfs:label : CareerStageCriterion^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies that grants are awarded to projects on the basis of career stage limits.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#CareerStageCriterion">dg:CareerStageCriterion</a>
    /// </summary>
    let CareerStageCriterion = _prefixId.prefix "CareerStageCriterion"
    /// <summary>
    ///   <para>rdfs:label : Company^^xsd:string</para>
    ///   <para>rdfs:comment : A commercial business.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#Company">dg:Company</a>
    /// </summary>
    let Company = _prefixId.prefix "Company"
    /// <summary>
    ///   <para>rdfs:label : Criterion^^xsd:string</para>
    ///   <para>rdfs:comment : Specification of Grant coverage, Grant eligibility, Grant reimbursement rates, Grant specific criteria for funding, Grant population targets, and similar features.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#Criterion">dg:Criterion</a>
    /// </summary>
    let Criterion = _prefixId.prefix "Criterion"
    /// <summary>
    ///   <para>rdfs:label : CulturalOrganisation^^xsd:string</para>
    ///   <para>rdfs:comment : Cultural institution or cultural organization is an organization within a culture/subculture that works for the preservation or promotion of culture.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#CulturalOrganisation">dg:CulturalOrganisation</a>
    /// </summary>
    let CulturalOrganisation = _prefixId.prefix "CulturalOrganisation"
    /// <summary>
    ///   <para>rdfs:label : EducationOrganisation^^xsd:string</para>
    ///   <para>rdfs:comment : Institution that provides education.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#EducationOrganisation">dg:EducationOrganisation</a>
    /// </summary>
    let EducationOrganisation = _prefixId.prefix "EducationOrganisation"
    /// <summary>
    ///   <para>rdfs:label : EmploymentCriterion^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies that grants are awarded on the basis of employment conditions by an organisation eligible for funding at the time of applying or receiving the funds.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#EmploymentCriterion">dg:EmploymentCriterion</a>
    /// </summary>
    let EmploymentCriterion = _prefixId.prefix "EmploymentCriterion"
    /// <summary>
    ///   <para>rdfs:label : FacilityOrganisation^^xsd:string</para>
    ///   <para>rdfs:comment : A place providing for a particular purpose.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#FacilityOrganisation">dg:FacilityOrganisation</a>
    /// </summary>
    let FacilityOrganisation = _prefixId.prefix "FacilityOrganisation"
    /// <summary>
    ///   <para>rdfs:label : ForProfictOrganisation^^xsd:string</para>
    ///   <para>rdfs:comment : For profit entity.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#ForProfitOrganisation">dg:ForProfitOrganisation</a>
    /// </summary>
    let ForProfitOrganisation = _prefixId.prefix "ForProfitOrganisation"
    /// <summary>
    ///   <para>rdfs:label : FundingAgency^^xsd:string</para>
    ///   <para>rdfs:comment : The class for funding agencies: organisations that materially disburse and administer the Grant process.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#FundingAgency">dg:FundingAgency</a>
    /// </summary>
    let FundingAgency = _prefixId.prefix "FundingAgency"
    /// <summary>
    ///   <para>rdfs:label : FundingScheme^^xsd:string</para>
    ///   <para>rdfs:comment : The class for funding schemes: plans, designs, and/or programs that determines and organizes the funding.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#FundingScheme">dg:FundingScheme</a>
    /// </summary>
    let FundingScheme = _prefixId.prefix "FundingScheme"
    /// <summary>
    ///   <para>rdfs:label : GeographicCriterion^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies that grants are awarded to projects on the basis of geographic areas, either where the project has to be implemented, or where the researcher must have been operating before applying for funding, or where the participants must be resident or citizens.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#GeographicCriterion">dg:GeographicCriterion</a>
    /// </summary>
    let GeographicCriterion = _prefixId.prefix "GeographicCriterion"
    /// <summary>
    ///   <para>rdfs:label : GovernmentalOrganisation^^xsd:string</para>
    ///   <para>rdfs:comment : Organisation or agency depending on a government, State or other supranational organisation and mainly operated by the government.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#GovernmentalOrganisation">dg:GovernmentalOrganisation</a>
    /// </summary>
    let GovernmentalOrganisation = _prefixId.prefix "GovernmentalOrganisation"
    /// <summary>
    ///   <para>rdfs:label : Grant^^xsd:string</para>
    ///   <para>rdfs:comment : The class for grant: a disbursed fund payed to a recipient or beneficiary and the process for it.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#Grant">dg:Grant</a>
    /// </summary>
    let Grant = _prefixId.prefix "Grant"
    /// <summary>
    ///   <para>rdfs:label : GrantPayment^^xsd:string</para>
    ///   <para>rdfs:comment : The class for grant payments: a single payment to a recipient or beneficiary within a Grant.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#GrantPayment">dg:GrantPayment</a>
    /// </summary>
    let GrantPayment = _prefixId.prefix "GrantPayment"
    /// <summary>
    ///   <para>rdfs:label : GrantShare^^xsd:string</para>
    ///   <para>rdfs:comment : The class for grant shares: the full or proper portion or part allotted or belonging to or contributed to an individual entity within a Grant.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#GrantShare">dg:GrantShare</a>
    /// </summary>
    let GrantShare = _prefixId.prefix "GrantShare"
    /// <summary>
    ///   <para>rdfs:label : HealthcareOrganisation^^xsd:string</para>
    ///   <para>rdfs:comment : Organization that provides health care and related services.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#HealthcareOrganisation">dg:HealthcareOrganisation</a>
    /// </summary>
    let HealthcareOrganisation = _prefixId.prefix "HealthcareOrganisation"
    /// <summary>
    ///   <para>rdfs:label : HigherEducationOrganisation^^xsd:string</para>
    ///   <para>rdfs:comment : Place of postsecondary education (e.g., universities, vocational universities, community colleges, liberal arts colleges, institutes of technology, and others).^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#HigherEducationOrganisation">dg:HigherEducationOrganisation</a>
    /// </summary>
    let HigherEducationOrganisation = _prefixId.prefix "HigherEducationOrganisation"
    /// <summary>
    ///   <para>rdfs:label : Identifier^^xsd:string</para>
    ///   <para>rdfs:comment : The class for identifiers.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#Identifier">dg:Identifier</a>
    /// </summary>
    let Identifier = _prefixId.prefix "Identifier"
    /// <summary>
    ///   <para>rdfs:label : InformationBase^^xsd:string</para>
    ///   <para>rdfs:comment : An organized collection of data and/or information. It can use any available technology. The temr can also indicate in general the information system built integrating such information bases.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#InformationBase">dg:InformationBase</a>
    /// </summary>
    let InformationBase = _prefixId.prefix "InformationBase"

    /// <summary>
    ///   <para>rdfs:label : InfrastructurePurposeCriterion^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies that grants are awarded to cover for the expenses of infrastructure.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#InfrastructurePurposeCriterion">dg:InfrastructurePurposeCriterion</a>
    /// </summary>
    let InfrastructurePurposeCriterion =
        _prefixId.prefix "InfrastructurePurposeCriterion"

    /// <summary>
    ///   <para>rdfs:label : IntergovernmentalOrganisation^^xsd:string</para>
    ///   <para>rdfs:comment : Organization composed primarily of sovereign states. Example: United Nations.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#IntergovernmentalOrganisation">dg:IntergovernmentalOrganisation</a>
    /// </summary>
    let IntergovernmentalOrganisation = _prefixId.prefix "IntergovernmentalOrganisation"
    /// <summary>
    ///   <para>rdfs:label : NonprofitOrganisation^^xsd:string</para>
    ///   <para>rdfs:comment : Business entity that pays no income tax, as it furthers a religious, scientific or social cause, providing a public benefit.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#NonprofitOrganisation">dg:NonprofitOrganisation</a>
    /// </summary>
    let NonprofitOrganisation = _prefixId.prefix "NonprofitOrganisation"
    /// <summary>
    ///   <para>rdfs:label : Organisation^^xsd:string</para>
    ///   <para>rdfs:comment : The class for organisations: social entities with a collective goal.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#Organisation">dg:Organisation</a>
    /// </summary>
    let Organisation = _prefixId.prefix "Organisation"
    /// <summary>
    ///   <para>rdfs:label : OrganisationRole^^xsd:string</para>
    ///   <para>rdfs:comment : The class for organisation roles: function assumed by or ascribed to an organisation that takes part in something.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#OrganisationRole">dg:OrganisationRole</a>
    /// </summary>
    let OrganisationRole = _prefixId.prefix "OrganisationRole"
    /// <summary>
    ///   <para>rdfs:label : OrganisationalCriterion^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies that grants are awarded on the basis of specified organisational form of the project, for instance demanding for participation of different research groups (synergy).^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#OrganisationalCriterion">dg:OrganisationalCriterion</a>
    /// </summary>
    let OrganisationalCriterion = _prefixId.prefix "OrganisationalCriterion"
    /// <summary>
    ///   <para>rdfs:label : PerformingGroup^^xsd:string</para>
    ///   <para>rdfs:comment : A performance group, such as a band, an orchestra, or a circus.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#PerformingGroup">dg:PerformingGroup</a>
    /// </summary>
    let PerformingGroup = _prefixId.prefix "PerformingGroup"
    /// <summary>
    ///   <para>rdfs:label : Person^^xsd:string</para>
    ///   <para>rdfs:comment : The class for persons: alive, dead, undead, or fictional.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#Person">dg:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : PersonRole^^xsd:string</para>
    ///   <para>rdfs:comment : The class for person roles: function assumed by or ascribed to a person that takes part in something.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#PersonRole">dg:PersonRole</a>
    /// </summary>
    let PersonRole = _prefixId.prefix "PersonRole"
    /// <summary>
    ///   <para>rdfs:label : Project^^xsd:string</para>
    ///   <para>rdfs:comment : The class for projects: an organised endeavour (collective or individual) planned to reach a particular aim or achieve a result.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#Project">dg:Project</a>
    /// </summary>
    let Project = _prefixId.prefix "Project"

    /// <summary>
    ///   <para>rdfs:label : ResearchPerformingOrganisation^^xsd:string</para>
    ///   <para>rdfs:comment : Organisations devoted to research activities.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#ResearchPerformingOrganisation">dg:ResearchPerformingOrganisation</a>
    /// </summary>
    let ResearchPerformingOrganisation =
        _prefixId.prefix "ResearchPerformingOrganisation"

    /// <summary>
    ///   <para>rdfs:label : Role^^xsd:string</para>
    ///   <para>rdfs:comment : The class for roles: the function assumed by or ascribed to an entity (typically person, group of persons or organisation) in a particular situation.
    /// It can be used to precise or represent additional information about a relationship or property such as participation or membership. The class should be only used to derive subclasses.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#Role">dg:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : SportsOrganisation^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the class of all sports organizations, including sports teams, governing bodies, and sports associations.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#SportsOrganisation">dg:SportsOrganisation</a>
    /// </summary>
    let SportsOrganisation = _prefixId.prefix "SportsOrganisation"
    /// <summary>
    ///   <para>rdfs:label : SupranationalOrganisation^^xsd:string</para>
    ///   <para>rdfs:comment : International organisation with power and influence in the jurisdictions of its member states. Example: European Union.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#SupranationalOrganisation">dg:SupranationalOrganisation</a>
    /// </summary>
    let SupranationalOrganisation = _prefixId.prefix "SupranationalOrganisation"
    /// <summary>
    ///   <para>rdfs:label : ThematicCriterion^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies that grants are awarded to projects on the basis of specified thematic/subject areas or well-defined areas of investigation indicated by the funding body.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#ThematicCriterion">dg:ThematicCriterion</a>
    /// </summary>
    let ThematicCriterion = _prefixId.prefix "ThematicCriterion"
    /// <summary>
    ///   <para>rdfs:label : WorkingTimeCriterion^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies that grants are awarded to projects on the basis of percentage of work time specifically devoted to the funded research.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#WorkingTimeCriterion">dg:WorkingTimeCriterion</a>
    /// </summary>
    let WorkingTimeCriterion = _prefixId.prefix "WorkingTimeCriterion"

    /// <summary>
    ///   <para>rdfs:label : abstract_or_summary_description^^xsd:string</para>
    ///   <para>rdfs:comment : Short summary description of a project.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#abstract_or_summary_description">dg:abstract_or_summary_description</a>
    /// </summary>
    let abstract_or_summary_description =
        _prefixId.prefix "abstract_or_summary_description"

    /// <summary>
    ///   <para>rdfs:label : academic_degree^^xsd:string</para>
    ///   <para>rdfs:comment : Qualification awarded to the person taking the role by a higher education organisation, normally at a college or university.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#academic_degree">dg:academic_degree</a>
    /// </summary>
    let academic_degree = _prefixId.prefix "academic_degree"
    /// <summary>
    ///   <para>rdfs:label : additionalName^^xsd:string</para>
    ///   <para>rdfs:comment : Additional part of a person's beyond given name and surname, can be used for a middle name.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#additionalName">dg:additionalName</a>
    /// </summary>
    let additionalName = _prefixId.prefix "additionalName"
    /// <summary>
    ///   <para>rdfs:label : affiliation^^xsd:string</para>
    ///   <para>rdfs:comment : An organization that this person is affiliated with. For example, a school/university, a club, or a team.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#affiliation">dg:affiliation</a>
    /// </summary>
    let affiliation = _prefixId.prefix "affiliation"
    /// <summary>
    ///   <para>rdfs:label : agency_identifier^^xsd:string</para>
    ///   <para>rdfs:comment : Identifier (for example of Project, Grant, GrantPayment, PersonRole instance, OrganizationRole instance, FundingScheme, Person, Organisation) in the database/archive of the funding agency/funding body/funder.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#agency_identifier">dg:agency_identifier</a>
    /// </summary>
    let agency_identifier = _prefixId.prefix "agency_identifier"
    /// <summary>
    ///   <para>rdfs:label : baseline_academic_degree^^xsd:string</para>
    ///   <para>rdfs:comment : Academic degree used as minimal/reference point for establishing a set of age limits or other classification.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#baseline_academic_degree">dg:baseline_academic_degree</a>
    /// </summary>
    let baseline_academic_degree = _prefixId.prefix "baseline_academic_degree"
    /// <summary>
    ///   <para>rdfs:label : beneficiary^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between the Grant (subject) and a (one of the) person(s) or organisation(s) receiving benefits from it identified by his/her/its role.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#beneficiary">dg:beneficiary</a>
    /// </summary>
    let beneficiary = _prefixId.prefix "beneficiary"
    /// <summary>
    ///   <para>rdfs:label : beneficiary_of^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between a (one of the) person(s) or organisation(s) receiving benefits from a Grant identified by his/her/its role (subject), and the Grant.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#beneficiary_of">dg:beneficiary_of</a>
    /// </summary>
    let beneficiary_of = _prefixId.prefix "beneficiary_of"
    /// <summary>
    ///   <para>rdfs:label : budget^^xsd:string</para>
    ///   <para>rdfs:comment : Amount of money necessary or planned for a determined project/activity.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#budget">dg:budget</a>
    /// </summary>
    let budget = _prefixId.prefix "budget"
    /// <summary>
    ///   <para>rdfs:label : country^^xsd:string</para>
    ///   <para>rdfs:comment : Country where the organisation is located ufficially.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#country">dg:country</a>
    /// </summary>
    let country = _prefixId.prefix "country"
    /// <summary>
    ///   <para>rdfs:label : criterion^^xsd:string</para>
    ///   <para>rdfs:comment : Property by which a distinction or classification is made. When applied to, for instance, FundingScheme items it indicates criterion item establishing the eligibility conditions, target and other relevant points of the FundingScheme to fund an application.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#criterion">dg:criterion</a>
    /// </summary>
    let criterion = _prefixId.prefix "criterion"
    /// <summary>
    ///   <para>rdfs:label : criterion_description^^xsd:string</para>
    ///   <para>rdfs:comment : Description of the eligibility, targets and other relevant points of the FundingScheme.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#criterion_description">dg:criterion_description</a>
    /// </summary>
    let criterion_description = _prefixId.prefix "criterion_description"
    /// <summary>
    ///   <para>rdfs:label : crossref_grantid^^xsd:string</para>
    ///   <para>rdfs:comment : Identifier for funding in the Crossref registry.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#crossref_grantid">dg:crossref_grantid</a>
    /// </summary>
    let crossref_grantid = _prefixId.prefix "crossref_grantid"
    /// <summary>
    ///   <para>rdfs:label : crossref_id^^xsd:string</para>
    ///   <para>rdfs:comment : Identifier for an organisation that funds research, in the Crossref registry.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#crossref_id">dg:crossref_id</a>
    /// </summary>
    let crossref_id = _prefixId.prefix "crossref_id"
    /// <summary>
    ///   <para>rdfs:label : degree_title^^xsd:string</para>
    ///   <para>rdfs:comment : Title denoting the academic degree.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#degree_title">dg:degree_title</a>
    /// </summary>
    let degree_title = _prefixId.prefix "degree_title"
    /// <summary>
    ///   <para>rdfs:label : disbursed_by^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between the disbursed grant (subject) and the funding agency (object).^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#disbursed_by">dg:disbursed_by</a>
    /// </summary>
    let disbursed_by = _prefixId.prefix "disbursed_by"
    /// <summary>
    ///   <para>rdfs:label : disburses^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between the funding agency (subject) and the disbursed grant (object).^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#disburses">dg:disburses</a>
    /// </summary>
    let disburses = _prefixId.prefix "disburses"
    /// <summary>
    ///   <para>rdfs:label : early_termination^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates if the role was ended ahead of time with respect to the grant contract of project ending.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#early_termination">dg:early_termination</a>
    /// </summary>
    let early_termination = _prefixId.prefix "early_termination"
    /// <summary>
    ///   <para>rdfs:label : economic_value^^xsd:string</para>
    ///   <para>rdfs:comment : Amount or value expressed in a specific currency (relationship between the item and a value expressed in a currency unit).^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#economic_value">dg:economic_value</a>
    /// </summary>
    let economic_value = _prefixId.prefix "economic_value"
    /// <summary>
    ///   <para>rdfs:label : employer^^xsd:string</para>
    ///   <para>rdfs:comment : A person or company that provides a job (possibly paying wages or a salary) to the person taking the role.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#employer">dg:employer</a>
    /// </summary>
    let employer = _prefixId.prefix "employer"
    /// <summary>
    ///   <para>rdfs:label : end_time^^xsd:string</para>
    ///   <para>rdfs:comment : The time an item ceases to exist or a statement stops being valid.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#end_time">dg:end_time</a>
    /// </summary>
    let end_time = _prefixId.prefix "end_time"
    /// <summary>
    ///   <para>rdfs:label : entity_taking_role^^xsd:string</para>
    ///   <para>rdfs:comment : The person or organisation or entity (object) assuming or to whom is assigned the role (subject).^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#entity_taking_role">dg:entity_taking_role</a>
    /// </summary>
    let entity_taking_role = _prefixId.prefix "entity_taking_role"
    /// <summary>
    ///   <para>rdfs:label : excluded_academic_degree^^xsd:string</para>
    ///   <para>rdfs:comment : Academic degree possessing which the subject of the statement cannot apply to the funding program.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#excluded_academic_degree">dg:excluded_academic_degree</a>
    /// </summary>
    let excluded_academic_degree = _prefixId.prefix "excluded_academic_degree"
    /// <summary>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <para>rdfs:comment : Specialisation of a person, project or organisation.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#field_of_work">dg:field_of_work</a>
    /// </summary>
    let field_of_work = _prefixId.prefix "field_of_work"
    /// <summary>
    ///   <para>rdfs:label : finances^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between the Grant (subject) and the Project (object).^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#finances">dg:finances</a>
    /// </summary>
    let finances = _prefixId.prefix "finances"
    /// <summary>
    ///   <para>rdfs:label : funded_by^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between the Project (subject) and the Grant (object).^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#funded_by">dg:funded_by</a>
    /// </summary>
    let funded_by = _prefixId.prefix "funded_by"
    /// <summary>
    ///   <para>rdfs:label : funder^^xsd:string</para>
    ///   <para>rdfs:comment : The ultimate funder who decided and is ultimately responsible for the funding scheme.
    /// (Example: FundingScheme Horizon2020 dg:funder European Commission).^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#funder">dg:funder</a>
    /// </summary>
    let funder = _prefixId.prefix "funder"
    /// <summary>
    ///   <para>rdfs:label : givenName^^xsd:string</para>
    ///   <para>rdfs:comment : Part of a person's name that individuates the person within the (typically closest) group that shares the same surname.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#givenName">dg:givenName</a>
    /// </summary>
    let givenName = _prefixId.prefix "givenName"
    /// <summary>
    ///   <para>rdfs:label : grid_id^^xsd:string</para>
    ///   <para>rdfs:comment : Institutional identifier from the GRID.ac global research identifier database.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#grid_id">dg:grid_id</a>
    /// </summary>
    let grid_id = _prefixId.prefix "grid_id"
    /// <summary>
    ///   <para>rdfs:label : hasPart^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between a superset and its direct subset(s). Indicates an item that is a part (also in generalised sense) of the subject item.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#hasPart">dg:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>rdfs:label : has_implementation^^xsd:string</para>
    ///   <para>rdfs:comment : The relationship between the decision, plan, program (subject) and the grant (object) that the grant is the concrete realisation of.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#has_implementation">dg:has_implementation</a>
    /// </summary>
    let has_implementation = _prefixId.prefix "has_implementation"
    /// <summary>
    ///   <para>rdfs:label : headquarters_location^^xsd:string</para>
    ///   <para>rdfs:comment : Address of the headquarters of the organisation.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#headquarters_location">dg:headquarters_location</a>
    /// </summary>
    let headquarters_location = _prefixId.prefix "headquarters_location"
    /// <summary>
    ///   <para>rdfs:label : id_context_agent^^xsd:string</para>
    ///   <para>rdfs:comment : Organization, Person, Agency related to the identifiers (for instance, creator, attributor, curator, maintainer, or similar). The specific semantic should be indicated with dedicated ontologies, such as PROV-O.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#id_context_agent">dg:id_context_agent</a>
    /// </summary>
    let id_context_agent = _prefixId.prefix "id_context_agent"
    /// <summary>
    ///   <para>rdfs:label : id_value^^xsd:string</para>
    ///   <para>rdfs:comment : String representing the identifier.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#id_value">dg:id_value</a>
    /// </summary>
    let id_value = _prefixId.prefix "id_value"
    /// <summary>
    ///   <para>rdfs:label : implementation_country^^xsd:string</para>
    ///   <para>rdfs:comment : Country where the project must be implemented.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#implementation_country">dg:implementation_country</a>
    /// </summary>
    let implementation_country = _prefixId.prefix "implementation_country"
    /// <summary>
    ///   <para>rdfs:label : implementation_of^^xsd:string</para>
    ///   <para>rdfs:comment : The relationship between the grant (subject) and the decision, plan, program (object) that the grant is the concrete realisation of.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#implementation_of">dg:implementation_of</a>
    /// </summary>
    let implementation_of = _prefixId.prefix "implementation_of"
    /// <summary>
    ///   <para>rdfs:label : implemented_by^^xsd:string</para>
    ///   <para>rdfs:comment : The relationship between the decision, plan, program (subject) and the funding agency (object) that the funding agency implements and administers.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#implemented_by">dg:implemented_by</a>
    /// </summary>
    let implemented_by = _prefixId.prefix "implemented_by"
    /// <summary>
    ///   <para>rdfs:label : implements^^xsd:string</para>
    ///   <para>rdfs:comment : The relationship between the funding agency (subject) and the decision, plan, program (object) that the funding agency implements and administers.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#implements">dg:implements</a>
    /// </summary>
    let implements = _prefixId.prefix "implements"
    /// <summary>
    ///   <para>rdfs:label : inception^^xsd:string</para>
    ///   <para>rdfs:comment : Date or point in time when the subject was founded/created.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#inception">dg:inception</a>
    /// </summary>
    let inception = _prefixId.prefix "inception"
    /// <summary>
    ///   <para>rdfs:label : isPartOf^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between a subset and its direct superset(s). Indicates an item that is a part (also in generalised sense) of the object item.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#isPartOf">dg:isPartOf</a>
    /// </summary>
    let isPartOf = _prefixId.prefix "isPartOf"
    /// <summary>
    ///   <para>rdfs:label : legalName^^xsd:string</para>
    ///   <para>rdfs:comment : The official name of the organization, for example the registered company name.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#legalName">dg:legalName</a>
    /// </summary>
    let legalName = _prefixId.prefix "legalName"
    /// <summary>
    ///   <para>rdfs:label : max_age^^xsd:string</para>
    ///   <para>rdfs:comment : Maximum age allowed.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#max_age">dg:max_age</a>
    /// </summary>
    let max_age = _prefixId.prefix "max_age"

    /// <summary>
    ///   <para>rdfs:label : max_years_from_baseline_degree^^xsd:string</para>
    ///   <para>rdfs:comment : Maximum number of years counting from the year of when the dg:baseline_academic_degree was obtained.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#max_years_from_baseline_degree">dg:max_years_from_baseline_degree</a>
    /// </summary>
    let max_years_from_baseline_degree =
        _prefixId.prefix "max_years_from_baseline_degree"

    /// <summary>
    ///   <para>rdfs:label : min_age^^xsd:string</para>
    ///   <para>rdfs:comment : Minimum age required.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#min_age">dg:min_age</a>
    /// </summary>
    let min_age = _prefixId.prefix "min_age"
    /// <summary>
    ///   <para>rdfs:label : min_research_years^^xsd:string</para>
    ///   <para>rdfs:comment : Minimum number of research years required.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#min_research_years">dg:min_research_years</a>
    /// </summary>
    let min_research_years = _prefixId.prefix "min_research_years"

    /// <summary>
    ///   <para>rdfs:label : min_years_from_baseline_degree^^xsd:string</para>
    ///   <para>rdfs:comment : Minimum number of years counting from the year of when the dg:baseline_academic_degree was obtained.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#min_years_from_baseline_degree">dg:min_years_from_baseline_degree</a>
    /// </summary>
    let min_years_from_baseline_degree =
        _prefixId.prefix "min_years_from_baseline_degree"

    /// <summary>
    ///   <para>rdfs:label : objective^^xsd:string</para>
    ///   <para>rdfs:comment : Desired result or outcome.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#objective">dg:objective</a>
    /// </summary>
    let objective = _prefixId.prefix "objective"
    /// <summary>
    ///   <para>rdfs:label : official_website^^xsd:string</para>
    ///   <para>rdfs:comment : URL of the official website of an item.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#official_website">dg:official_website</a>
    /// </summary>
    let official_website = _prefixId.prefix "official_website"
    /// <summary>
    ///   <para>rdfs:label : orcid_id^^xsd:string</para>
    ///   <para>rdfs:comment : Nonproprietary alphanumeric code to uniquely identify scientific and other academic authors.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#orcid_id">dg:orcid_id</a>
    /// </summary>
    let orcid_id = _prefixId.prefix "orcid_id"
    /// <summary>
    ///   <para>rdfs:label : organisation_location^^xsd:string</para>
    ///   <para>rdfs:comment : Country or geographical administrative entity where an organisation must be established to apply for funding.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#organisation_location">dg:organisation_location</a>
    /// </summary>
    let organisation_location = _prefixId.prefix "organisation_location"
    /// <summary>
    ///   <para>rdfs:label : participant^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between the Project (subject) and a (one of the) person(s) or organisation(s) contributing to or taking part in it identified by his/her/its role.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#participant">dg:participant</a>
    /// </summary>
    let participant = _prefixId.prefix "participant"
    /// <summary>
    ///   <para>rdfs:label : participant_of^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between a (one of the) person(s) or organisation(s) participant of a Project identified by his/her/its role (subject), and the Project.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#participant_of">dg:participant_of</a>
    /// </summary>
    let participant_of = _prefixId.prefix "participant_of"
    /// <summary>
    ///   <para>rdfs:label : percentage_employment^^xsd:string</para>
    ///   <para>rdfs:comment : Minimum percentage of employment required (for example to be eligible for funding).^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#percentage_employment">dg:percentage_employment</a>
    /// </summary>
    let percentage_employment = _prefixId.prefix "percentage_employment"
    /// <summary>
    ///   <para>rdfs:label : percentage_working_time^^xsd:string</para>
    ///   <para>rdfs:comment : Amount of working time in percentage.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#percentage_working_time">dg:percentage_working_time</a>
    /// </summary>
    let percentage_working_time = _prefixId.prefix "percentage_working_time"
    /// <summary>
    ///   <para>rdfs:label : person_location^^xsd:string</para>
    ///   <para>rdfs:comment : Country or geographical administrative entity where the person must reside or be citizen or have undertaken research up to the moment of applying for funding.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#person_location">dg:person_location</a>
    /// </summary>
    let person_location = _prefixId.prefix "person_location"
    /// <summary>
    ///   <para>rdfs:label : point_in_time^^xsd:string</para>
    ///   <para>rdfs:comment : The moment in time when an event occurs.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#point_in_time">dg:point_in_time</a>
    /// </summary>
    let point_in_time = _prefixId.prefix "point_in_time"
    /// <summary>
    ///   <para>rdfs:label : product_or_material_produced^^xsd:string</para>
    ///   <para>rdfs:comment : Material, product or output produced by a Project.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#product_or_material_produced">dg:product_or_material_produced</a>
    /// </summary>
    let product_or_material_produced = _prefixId.prefix "product_or_material_produced"
    /// <summary>
    ///   <para>rdfs:label : recipient^^xsd:string</para>
    ///   <para>rdfs:comment : The receiver of a GrantPayment or receiver/beneficiary of a GrantShare.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#recipient">dg:recipient</a>
    /// </summary>
    let recipient = _prefixId.prefix "recipient"
    /// <summary>
    ///   <para>rdfs:label : role_label^^xsd:string</para>
    ///   <para>rdfs:comment : Label (name) of a Role.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#role_label">dg:role_label</a>
    /// </summary>
    let role_label = _prefixId.prefix "role_label"
    /// <summary>
    ///   <para>rdfs:label : role_type^^xsd:string</para>
    ///   <para>rdfs:comment : Item representing the specific class of a Role.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#role_type">dg:role_type</a>
    /// </summary>
    let role_type = _prefixId.prefix "role_type"
    /// <summary>
    ///   <para>rdfs:label : short_name^^xsd:string</para>
    ///   <para>rdfs:comment : Acronym or short name of an organisation or project or funding scheme.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#short_name">dg:short_name</a>
    /// </summary>
    let short_name = _prefixId.prefix "short_name"
    /// <summary>
    ///   <para>rdfs:label : start_time^^xsd:string</para>
    ///   <para>rdfs:comment : The time an item starts to exist/operate or a statement starts being valid.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#start_time">dg:start_time</a>
    /// </summary>
    let start_time = _prefixId.prefix "start_time"
    /// <summary>
    ///   <para>rdfs:label : surname^^xsd:string</para>
    ///   <para>rdfs:comment : Part of a person's name shared with a group (typically family or tribe or clan depending on the culture), and/or used in formal contexts or with people that do not know the person well.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#surname">dg:surname</a>
    /// </summary>
    let surname = _prefixId.prefix "surname"
    /// <summary>
    ///   <para>rdfs:label : takes_role^^xsd:string</para>
    ///   <para>rdfs:comment : The role (object) assumed or assigned to a person or organisation or entity (subject).^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#takes_role">dg:takes_role</a>
    /// </summary>
    let takes_role = _prefixId.prefix "takes_role"
    /// <summary>
    ///   <para>rdfs:label : thematic_area^^xsd:string</para>
    ///   <para>rdfs:comment : Topics and/or area of interest.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#thematic_area">dg:thematic_area</a>
    /// </summary>
    let thematic_area = _prefixId.prefix "thematic_area"
    /// <summary>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <para>rdfs:comment : The title of a project (original or translated).^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#title">dg:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : used_in^^xsd:string</para>
    ///   <para>rdfs:comment : Database or information system where the identifier is/was used.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#used_in">dg:used_in</a>
    /// </summary>
    let used_in = _prefixId.prefix "used_in"
    /// <summary>
    ///   <para>rdfs:label : wikidata_item_id^^xsd:string</para>
    ///   <para>rdfs:comment : Identifier for a class or item existing in Wikidata.^^xsd:string</para>
    ///   <a href="https://w3id.org/dingo#wikidata_item_id">dg:wikidata_item_id</a>
    /// </summary>
    let wikidata_item_id = _prefixId.prefix "wikidata_item_id"
