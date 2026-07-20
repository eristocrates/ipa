namespace https.w3id.org.dingo.hash

open DoxAletheia

module dg =
    let _namespace_name = "https://w3id.org/dingo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The class for academic degrees: college or university diploma.
    /// <see href="https://w3id.org/dingo#AcademicDegree"></see></summary>
    let AcademicDegree = _prefix "AcademicDegree"
    /// <summary>
    /// Specifies that grants are awarded to projects on the basis of age limits.
    /// <see href="https://w3id.org/dingo#AgeCriterion"></see></summary>
    let AgeCriterion = _prefix "AgeCriterion"
    /// <summary>
    /// Specification of Grant coverage, Grant eligibility, Grant reimbursement rates, Grant specific criteria for funding, Grant population targets, and similar features.
    /// <see href="https://w3id.org/dingo#Criterion"></see></summary>
    let Criterion = _prefix "Criterion"
    /// <summary>
    /// Institution that holds artifacts and other objects of scientific, artistic, cultural, historical, or other importance.
    /// <see href="https://w3id.org/dingo#ArchiveOrganisation"></see></summary>
    let ArchiveOrganisation = _prefix "ArchiveOrganisation"
    /// <summary>
    /// The class for organisations: social entities with a collective goal.
    /// <see href="https://w3id.org/dingo#Organisation"></see></summary>
    let Organisation = _prefix "Organisation"
    /// <summary>
    /// Specifies that grants are awarded to projects on the basis of the research proposal itself without restriction on theme/subject or research area. The funding body does not specifies beforehand missions, targets nor topics of the research projects that can apply.
    /// <see href="https://w3id.org/dingo#BottomUpCriterion"></see></summary>
    let BottomUpCriterion = _prefix "BottomUpCriterion"
    /// <summary>
    /// Specifies that grants are awarded on the basis of career-related goals and applicants must be at a defined career stage (defined academic degree) to be achieved.
    /// <see href="https://w3id.org/dingo#CareerPurposeCriterion"></see></summary>
    let CareerPurposeCriterion = _prefix "CareerPurposeCriterion"
    /// <summary>
    /// Specifies that grants are awarded to projects on the basis of career stage limits.
    /// <see href="https://w3id.org/dingo#CareerStageCriterion"></see></summary>
    let CareerStageCriterion = _prefix "CareerStageCriterion"
    /// <summary>
    /// A commercial business.
    /// <see href="https://w3id.org/dingo#Company"></see></summary>
    let Company = _prefix "Company"
    /// <summary>
    /// Cultural institution or cultural organization is an organization within a culture/subculture that works for the preservation or promotion of culture.
    /// <see href="https://w3id.org/dingo#CulturalOrganisation"></see></summary>
    let CulturalOrganisation = _prefix "CulturalOrganisation"
    /// <summary>
    /// Institution that provides education.
    /// <see href="https://w3id.org/dingo#EducationOrganisation"></see></summary>
    let EducationOrganisation = _prefix "EducationOrganisation"
    /// <summary>
    /// Specifies that grants are awarded on the basis of employment conditions by an organisation eligible for funding at the time of applying or receiving the funds.
    /// <see href="https://w3id.org/dingo#EmploymentCriterion"></see></summary>
    let EmploymentCriterion = _prefix "EmploymentCriterion"
    /// <summary>
    /// A place providing for a particular purpose.
    /// <see href="https://w3id.org/dingo#FacilityOrganisation"></see></summary>
    let FacilityOrganisation = _prefix "FacilityOrganisation"
    /// <summary>
    /// For profit entity.
    /// <see href="https://w3id.org/dingo#ForProfitOrganisation"></see></summary>
    let ForProfitOrganisation = _prefix "ForProfitOrganisation"
    /// <summary>
    /// The class for funding agencies: organisations that materially disburse and administer the Grant process.
    /// <see href="https://w3id.org/dingo#FundingAgency"></see></summary>
    let FundingAgency = _prefix "FundingAgency"
    /// <summary>
    /// The class for funding schemes: plans, designs, and/or programs that determines and organizes the funding.
    /// <see href="https://w3id.org/dingo#FundingScheme"></see></summary>
    let FundingScheme = _prefix "FundingScheme"
    /// <summary>
    /// Specifies that grants are awarded to projects on the basis of geographic areas, either where the project has to be implemented, or where the researcher must have been operating before applying for funding, or where the participants must be resident or citizens.
    /// <see href="https://w3id.org/dingo#GeographicCriterion"></see></summary>
    let GeographicCriterion = _prefix "GeographicCriterion"
    /// <summary>
    /// Organisation or agency depending on a government, State or other supranational organisation and mainly operated by the government.
    /// <see href="https://w3id.org/dingo#GovernmentalOrganisation"></see></summary>
    let GovernmentalOrganisation = _prefix "GovernmentalOrganisation"
    /// <summary>
    /// The class for grant: a disbursed fund payed to a recipient or beneficiary and the process for it.
    /// <see href="https://w3id.org/dingo#Grant"></see></summary>
    let Grant = _prefix "Grant"
    /// <summary>
    /// The class for grant payments: a single payment to a recipient or beneficiary within a Grant.
    /// <see href="https://w3id.org/dingo#GrantPayment"></see></summary>
    let GrantPayment = _prefix "GrantPayment"
    /// <summary>
    /// The class for grant shares: the full or proper portion or part allotted or belonging to or contributed to an individual entity within a Grant.
    /// <see href="https://w3id.org/dingo#GrantShare"></see></summary>
    let GrantShare = _prefix "GrantShare"
    /// <summary>
    /// Organization that provides health care and related services.
    /// <see href="https://w3id.org/dingo#HealthcareOrganisation"></see></summary>
    let HealthcareOrganisation = _prefix "HealthcareOrganisation"
    /// <summary>
    /// Place of postsecondary education (e.g., universities, vocational universities, community colleges, liberal arts colleges, institutes of technology, and others).
    /// <see href="https://w3id.org/dingo#HigherEducationOrganisation"></see></summary>
    let HigherEducationOrganisation = _prefix "HigherEducationOrganisation"
    /// <summary>
    /// The class for identifiers.
    /// <see href="https://w3id.org/dingo#Identifier"></see></summary>
    let Identifier = _prefix "Identifier"
    /// <summary>
    /// An organized collection of data and/or information. It can use any available technology. The temr can also indicate in general the information system built integrating such information bases.
    /// <see href="https://w3id.org/dingo#InformationBase"></see></summary>
    let InformationBase = _prefix "InformationBase"
    /// <summary>
    /// Specifies that grants are awarded to cover for the expenses of infrastructure.
    /// <see href="https://w3id.org/dingo#InfrastructurePurposeCriterion"></see></summary>
    let InfrastructurePurposeCriterion = _prefix "InfrastructurePurposeCriterion"
    /// <summary>
    /// Organization composed primarily of sovereign states. Example: United Nations.
    /// <see href="https://w3id.org/dingo#IntergovernmentalOrganisation"></see></summary>
    let IntergovernmentalOrganisation = _prefix "IntergovernmentalOrganisation"
    /// <summary>
    /// Business entity that pays no income tax, as it furthers a religious, scientific or social cause, providing a public benefit.
    /// <see href="https://w3id.org/dingo#NonprofitOrganisation"></see></summary>
    let NonprofitOrganisation = _prefix "NonprofitOrganisation"
    /// <summary>
    /// The class for organisation roles: function assumed by or ascribed to an organisation that takes part in something.
    /// <see href="https://w3id.org/dingo#OrganisationRole"></see></summary>
    let OrganisationRole = _prefix "OrganisationRole"
    /// <summary>
    /// The class for roles: the function assumed by or ascribed to an entity (typically person, group of persons or organisation) in a particular situation.
    /// It can be used to precise or represent additional information about a relationship or property such as participation or membership. The class should be only used to derive subclasses.
    /// <see href="https://w3id.org/dingo#Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// Specifies that grants are awarded on the basis of specified organisational form of the project, for instance demanding for participation of different research groups (synergy).
    /// <see href="https://w3id.org/dingo#OrganisationalCriterion"></see></summary>
    let OrganisationalCriterion = _prefix "OrganisationalCriterion"
    /// <summary>
    /// A performance group, such as a band, an orchestra, or a circus.
    /// <see href="https://w3id.org/dingo#PerformingGroup"></see></summary>
    let PerformingGroup = _prefix "PerformingGroup"
    /// <summary>
    /// The class for persons: alive, dead, undead, or fictional.
    /// <see href="https://w3id.org/dingo#Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// The class for person roles: function assumed by or ascribed to a person that takes part in something.
    /// <see href="https://w3id.org/dingo#PersonRole"></see></summary>
    let PersonRole = _prefix "PersonRole"
    /// <summary>
    /// The class for projects: an organised endeavour (collective or individual) planned to reach a particular aim or achieve a result.
    /// <see href="https://w3id.org/dingo#Project"></see></summary>
    let Project = _prefix "Project"
    /// <summary>
    /// Organisations devoted to research activities.
    /// <see href="https://w3id.org/dingo#ResearchPerformingOrganisation"></see></summary>
    let ResearchPerformingOrganisation = _prefix "ResearchPerformingOrganisation"
    /// <summary>
    /// Represents the class of all sports organizations, including sports teams, governing bodies, and sports associations.
    /// <see href="https://w3id.org/dingo#SportsOrganisation"></see></summary>
    let SportsOrganisation = _prefix "SportsOrganisation"
    /// <summary>
    /// International organisation with power and influence in the jurisdictions of its member states. Example: European Union.
    /// <see href="https://w3id.org/dingo#SupranationalOrganisation"></see></summary>
    let SupranationalOrganisation = _prefix "SupranationalOrganisation"
    /// <summary>
    /// Specifies that grants are awarded to projects on the basis of specified thematic/subject areas or well-defined areas of investigation indicated by the funding body.
    /// <see href="https://w3id.org/dingo#ThematicCriterion"></see></summary>
    let ThematicCriterion = _prefix "ThematicCriterion"
    /// <summary>
    /// Specifies that grants are awarded to projects on the basis of percentage of work time specifically devoted to the funded research.
    /// <see href="https://w3id.org/dingo#WorkingTimeCriterion"></see></summary>
    let WorkingTimeCriterion = _prefix "WorkingTimeCriterion"
    /// <summary>
    /// Short summary description of a project.
    /// <see href="https://w3id.org/dingo#abstract_or_summary_description"></see></summary>
    let abstract_or_summary_description = _prefix "abstract_or_summary_description"
    /// <summary>
    /// Qualification awarded to the person taking the role by a higher education organisation, normally at a college or university.
    /// <see href="https://w3id.org/dingo#academic_degree"></see></summary>
    let academic_degree = _prefix "academic_degree"
    /// <summary>
    /// Additional part of a person's beyond given name and surname, can be used for a middle name.
    /// <see href="https://w3id.org/dingo#additionalName"></see></summary>
    let additionalName = _prefix "additionalName"
    /// <summary>
    /// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
    /// <see href="https://w3id.org/dingo#affiliation"></see></summary>
    let affiliation = _prefix "affiliation"
    /// <summary>
    /// Identifier (for example of Project, Grant, GrantPayment, PersonRole instance, OrganizationRole instance, FundingScheme, Person, Organisation) in the database/archive of the funding agency/funding body/funder.
    /// <see href="https://w3id.org/dingo#agency_identifier"></see></summary>
    let agency_identifier = _prefix "agency_identifier"
    /// <summary>
    /// Academic degree used as minimal/reference point for establishing a set of age limits or other classification.
    /// <see href="https://w3id.org/dingo#baseline_academic_degree"></see></summary>
    let baseline_academic_degree = _prefix "baseline_academic_degree"
    /// <summary>
    /// The relation between the Grant (subject) and a (one of the) person(s) or organisation(s) receiving benefits from it identified by his/her/its role.
    /// <see href="https://w3id.org/dingo#beneficiary"></see></summary>
    let beneficiary = _prefix "beneficiary"
    /// <summary>
    /// The relation between a (one of the) person(s) or organisation(s) receiving benefits from a Grant identified by his/her/its role (subject), and the Grant.
    /// <see href="https://w3id.org/dingo#beneficiary_of"></see></summary>
    let beneficiary_of = _prefix "beneficiary_of"
    /// <summary>
    /// Amount of money necessary or planned for a determined project/activity.
    /// <see href="https://w3id.org/dingo#budget"></see></summary>
    let budget = _prefix "budget"
    /// <summary>
    /// Country where the organisation is located ufficially.
    /// <see href="https://w3id.org/dingo#country"></see></summary>
    let country = _prefix "country"
    /// <summary>
    /// Property by which a distinction or classification is made. When applied to, for instance, FundingScheme items it indicates criterion item establishing the eligibility conditions, target and other relevant points of the FundingScheme to fund an application.
    /// <see href="https://w3id.org/dingo#criterion"></see></summary>
    let criterion = _prefix "criterion"
    /// <summary>
    /// Description of the eligibility, targets and other relevant points of the FundingScheme.
    /// <see href="https://w3id.org/dingo#criterion_description"></see></summary>
    let criterion_description = _prefix "criterion_description"
    /// <summary>
    /// Identifier for funding in the Crossref registry.
    /// <see href="https://w3id.org/dingo#crossref_grantid"></see></summary>
    let crossref_grantid = _prefix "crossref_grantid"
    /// <summary>
    /// Identifier for an organisation that funds research, in the Crossref registry.
    /// <see href="https://w3id.org/dingo#crossref_id"></see></summary>
    let crossref_id = _prefix "crossref_id"
    /// <summary>
    /// Title denoting the academic degree.
    /// <see href="https://w3id.org/dingo#degree_title"></see></summary>
    let degree_title = _prefix "degree_title"
    /// <summary>
    /// The relation between the disbursed grant (subject) and the funding agency (object).
    /// <see href="https://w3id.org/dingo#disbursed_by"></see></summary>
    let disbursed_by = _prefix "disbursed_by"
    /// <summary>
    /// The relation between the funding agency (subject) and the disbursed grant (object).
    /// <see href="https://w3id.org/dingo#disburses"></see></summary>
    let disburses = _prefix "disburses"
    /// <summary>
    /// Indicates if the role was ended ahead of time with respect to the grant contract of project ending.
    /// <see href="https://w3id.org/dingo#early_termination"></see></summary>
    let early_termination = _prefix "early_termination"
    /// <summary>
    /// Amount or value expressed in a specific currency (relationship between the item and a value expressed in a currency unit).
    /// <see href="https://w3id.org/dingo#economic_value"></see></summary>
    let economic_value = _prefix "economic_value"
    /// <summary>
    /// A person or company that provides a job (possibly paying wages or a salary) to the person taking the role.
    /// <see href="https://w3id.org/dingo#employer"></see></summary>
    let employer = _prefix "employer"
    /// <summary>
    /// The time an item ceases to exist or a statement stops being valid.
    /// <see href="https://w3id.org/dingo#end_time"></see></summary>
    let end_time = _prefix "end_time"
    /// <summary>
    /// The person or organisation or entity (object) assuming or to whom is assigned the role (subject).
    /// <see href="https://w3id.org/dingo#entity_taking_role"></see></summary>
    let entity_taking_role = _prefix "entity_taking_role"
    /// <summary>
    /// The role (object) assumed or assigned to a person or organisation or entity (subject).
    /// <see href="https://w3id.org/dingo#takes_role"></see></summary>
    let takes_role = _prefix "takes_role"
    /// <summary>
    /// Academic degree possessing which the subject of the statement cannot apply to the funding program.
    /// <see href="https://w3id.org/dingo#excluded_academic_degree"></see></summary>
    let excluded_academic_degree = _prefix "excluded_academic_degree"
    /// <summary>
    /// Specialisation of a person, project or organisation.
    /// <see href="https://w3id.org/dingo#field_of_work"></see></summary>
    let field_of_work = _prefix "field_of_work"
    /// <summary>
    /// The relation between the Grant (subject) and the Project (object).
    /// <see href="https://w3id.org/dingo#finances"></see></summary>
    let finances = _prefix "finances"
    /// <summary>
    /// The relation between the Project (subject) and the Grant (object).
    /// <see href="https://w3id.org/dingo#funded_by"></see></summary>
    let funded_by = _prefix "funded_by"
    /// <summary>
    /// The ultimate funder who decided and is ultimately responsible for the funding scheme.
    /// (Example: FundingScheme Horizon2020 dg:funder European Commission).
    /// <see href="https://w3id.org/dingo#funder"></see></summary>
    let funder = _prefix "funder"
    /// <summary>
    /// Part of a person's name that individuates the person within the (typically closest) group that shares the same surname.
    /// <see href="https://w3id.org/dingo#givenName"></see></summary>
    let givenName = _prefix "givenName"
    /// <summary>
    /// Institutional identifier from the GRID.ac global research identifier database.
    /// <see href="https://w3id.org/dingo#grid_id"></see></summary>
    let grid_id = _prefix "grid_id"
    /// <summary>
    /// The relation between a superset and its direct subset(s). Indicates an item that is a part (also in generalised sense) of the subject item.
    /// <see href="https://w3id.org/dingo#hasPart"></see></summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    /// The relation between a subset and its direct superset(s). Indicates an item that is a part (also in generalised sense) of the object item.
    /// <see href="https://w3id.org/dingo#isPartOf"></see></summary>
    let isPartOf = _prefix "isPartOf"
    /// <summary>
    /// The relationship between the decision, plan, program (subject) and the grant (object) that the grant is the concrete realisation of.
    /// <see href="https://w3id.org/dingo#has_implementation"></see></summary>
    let has_implementation = _prefix "has_implementation"
    /// <summary>
    /// The relationship between the grant (subject) and the decision, plan, program (object) that the grant is the concrete realisation of.
    /// <see href="https://w3id.org/dingo#implementation_of"></see></summary>
    let implementation_of = _prefix "implementation_of"
    /// <summary>
    /// Address of the headquarters of the organisation.
    /// <see href="https://w3id.org/dingo#headquarters_location"></see></summary>
    let headquarters_location = _prefix "headquarters_location"
    /// <summary>
    /// Organization, Person, Agency related to the identifiers (for instance, creator, attributor, curator, maintainer, or similar). The specific semantic should be indicated with dedicated ontologies, such as PROV-O.
    /// <see href="https://w3id.org/dingo#id_context_agent"></see></summary>
    let id_context_agent = _prefix "id_context_agent"
    /// <summary>
    /// String representing the identifier.
    /// <see href="https://w3id.org/dingo#id_value"></see></summary>
    let id_value = _prefix "id_value"
    /// <summary>
    /// Country where the project must be implemented.
    /// <see href="https://w3id.org/dingo#implementation_country"></see></summary>
    let implementation_country = _prefix "implementation_country"
    /// <summary>
    /// The relationship between the decision, plan, program (subject) and the funding agency (object) that the funding agency implements and administers.
    /// <see href="https://w3id.org/dingo#implemented_by"></see></summary>
    let implemented_by = _prefix "implemented_by"
    /// <summary>
    /// The relationship between the funding agency (subject) and the decision, plan, program (object) that the funding agency implements and administers.
    /// <see href="https://w3id.org/dingo#implements"></see></summary>
    let implements = _prefix "implements"
    /// <summary>
    /// Date or point in time when the subject was founded/created.
    /// <see href="https://w3id.org/dingo#inception"></see></summary>
    let inception = _prefix "inception"
    /// <summary>
    /// The official name of the organization, for example the registered company name.
    /// <see href="https://w3id.org/dingo#legalName"></see></summary>
    let legalName = _prefix "legalName"
    /// <summary>
    /// Maximum age allowed.
    /// <see href="https://w3id.org/dingo#max_age"></see></summary>
    let max_age = _prefix "max_age"
    /// <summary>
    /// Maximum number of years counting from the year of when the dg:baseline_academic_degree was obtained.
    /// <see href="https://w3id.org/dingo#max_years_from_baseline_degree"></see></summary>
    let max_years_from_baseline_degree = _prefix "max_years_from_baseline_degree"
    /// <summary>
    /// Minimum age required.
    /// <see href="https://w3id.org/dingo#min_age"></see></summary>
    let min_age = _prefix "min_age"
    /// <summary>
    /// Minimum number of research years required.
    /// <see href="https://w3id.org/dingo#min_research_years"></see></summary>
    let min_research_years = _prefix "min_research_years"
    /// <summary>
    /// Minimum number of years counting from the year of when the dg:baseline_academic_degree was obtained.
    /// <see href="https://w3id.org/dingo#min_years_from_baseline_degree"></see></summary>
    let min_years_from_baseline_degree = _prefix "min_years_from_baseline_degree"
    /// <summary>
    /// Desired result or outcome.
    /// <see href="https://w3id.org/dingo#objective"></see></summary>
    let objective = _prefix "objective"
    /// <summary>
    /// URL of the official website of an item.
    /// <see href="https://w3id.org/dingo#official_website"></see></summary>
    let official_website = _prefix "official_website"
    /// <summary>
    /// Nonproprietary alphanumeric code to uniquely identify scientific and other academic authors.
    /// <see href="https://w3id.org/dingo#orcid_id"></see></summary>
    let orcid_id = _prefix "orcid_id"
    /// <summary>
    /// Country or geographical administrative entity where an organisation must be established to apply for funding.
    /// <see href="https://w3id.org/dingo#organisation_location"></see></summary>
    let organisation_location = _prefix "organisation_location"
    /// <summary>
    /// The relation between the Project (subject) and a (one of the) person(s) or organisation(s) contributing to or taking part in it identified by his/her/its role.
    /// <see href="https://w3id.org/dingo#participant"></see></summary>
    let participant = _prefix "participant"
    /// <summary>
    /// The relation between a (one of the) person(s) or organisation(s) participant of a Project identified by his/her/its role (subject), and the Project.
    /// <see href="https://w3id.org/dingo#participant_of"></see></summary>
    let participant_of = _prefix "participant_of"
    /// <summary>
    /// Minimum percentage of employment required (for example to be eligible for funding).
    /// <see href="https://w3id.org/dingo#percentage_employment"></see></summary>
    let percentage_employment = _prefix "percentage_employment"
    /// <summary>
    /// Amount of working time in percentage.
    /// <see href="https://w3id.org/dingo#percentage_working_time"></see></summary>
    let percentage_working_time = _prefix "percentage_working_time"
    /// <summary>
    /// Country or geographical administrative entity where the person must reside or be citizen or have undertaken research up to the moment of applying for funding.
    /// <see href="https://w3id.org/dingo#person_location"></see></summary>
    let person_location = _prefix "person_location"
    /// <summary>
    /// The moment in time when an event occurs.
    /// <see href="https://w3id.org/dingo#point_in_time"></see></summary>
    let point_in_time = _prefix "point_in_time"
    /// <summary>
    /// Material, product or output produced by a Project.
    /// <see href="https://w3id.org/dingo#product_or_material_produced"></see></summary>
    let product_or_material_produced = _prefix "product_or_material_produced"
    /// <summary>
    /// The receiver of a GrantPayment or receiver/beneficiary of a GrantShare.
    /// <see href="https://w3id.org/dingo#recipient"></see></summary>
    let recipient = _prefix "recipient"
    /// <summary>
    /// Label (name) of a Role.
    /// <see href="https://w3id.org/dingo#role_label"></see></summary>
    let role_label = _prefix "role_label"
    /// <summary>
    /// Item representing the specific class of a Role.
    /// <see href="https://w3id.org/dingo#role_type"></see></summary>
    let role_type = _prefix "role_type"
    /// <summary>
    /// Acronym or short name of an organisation or project or funding scheme.
    /// <see href="https://w3id.org/dingo#short_name"></see></summary>
    let short_name = _prefix "short_name"
    /// <summary>
    /// The time an item starts to exist/operate or a statement starts being valid.
    /// <see href="https://w3id.org/dingo#start_time"></see></summary>
    let start_time = _prefix "start_time"
    /// <summary>
    /// Part of a person's name shared with a group (typically family or tribe or clan depending on the culture), and/or used in formal contexts or with people that do not know the person well.
    /// <see href="https://w3id.org/dingo#surname"></see></summary>
    let surname = _prefix "surname"
    /// <summary>
    /// Topics and/or area of interest.
    /// <see href="https://w3id.org/dingo#thematic_area"></see></summary>
    let thematic_area = _prefix "thematic_area"
    /// <summary>
    /// The title of a project (original or translated).
    /// <see href="https://w3id.org/dingo#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// Database or information system where the identifier is/was used.
    /// <see href="https://w3id.org/dingo#used_in"></see></summary>
    let used_in = _prefix "used_in"
    /// <summary>
    /// Identifier for a class or item existing in Wikidata.
    /// <see href="https://w3id.org/dingo#wikidata_item_id"></see></summary>
    let wikidata_item_id = _prefix "wikidata_item_id"
