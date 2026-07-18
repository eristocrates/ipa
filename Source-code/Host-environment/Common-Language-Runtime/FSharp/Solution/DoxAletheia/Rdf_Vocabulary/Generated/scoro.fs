namespace http.purl.org.spar.scoro.slash

open DoxAletheia.Rdf_Vocabulary

module scoro =
    let _namespace_name = "http://purl.org/spar/scoro/"

    /// <summary>
    /// A role that a person might hold as an author of a publication or the creator of a work.  Individual members of this class are used to specify particular roles.
    /// <see href="http://purl.org/spar/scoro/AuthorshipRole"></see></summary>
    let AuthorshipRole =
        Namespaced_IRI.parse _namespace_name "AuthorshipRole" |> NamespacedName

    /// <summary>
    /// A role that an agent might hold with respect to data.  Individual members of this class are used to specify particular roles.
    /// <see href="http://purl.org/spar/scoro/DataRole"></see></summary>
    let DataRole = Namespaced_IRI.parse _namespace_name "DataRole" |> NamespacedName

    /// <summary>
    /// A role that an agent might hold with respect to academic and project finance.  Individual members of this class are used to specify particular roles.
    /// <see href="http://purl.org/spar/scoro/FinancialRole"></see></summary>
    let FinancialRole =
        Namespaced_IRI.parse _namespace_name "FinancialRole" |> NamespacedName

    /// <summary>
    /// A role that an agent might hold with respect to an investigation.  Individual members of this class are used to specify particular roles.
    /// <see href="http://purl.org/spar/scoro/InvestigationRole"></see></summary>
    let InvestigationRole =
        Namespaced_IRI.parse _namespace_name "InvestigationRole" |> NamespacedName

    /// <summary>
    /// A role that an agent might hold with respect to an organization and its administration, particularly within an academic context.  Individual members of this class are used to specify particular roles.
    /// <see href="http://purl.org/spar/scoro/OrganizationalRole"></see></summary>
    let OrganizationalRole =
        Namespaced_IRI.parse _namespace_name "OrganizationalRole" |> NamespacedName

    /// <summary>
    /// A role that an agent might hold with respect to a project.  Individual members of this class are used to specify particular roles.
    /// <see href="http://purl.org/spar/scoro/ProjectRole"></see></summary>
    let ProjectRole =
        Namespaced_IRI.parse _namespace_name "ProjectRole" |> NamespacedName

    /// <summary>
    /// The role of a person who takes responsibility for the integrity of the work as a whole, from the inception of the research investigation to the published research article.
    /// <see href="http://purl.org/spar/scoro/article-guarantor"></see></summary>
    let ``article-guarantor`` =
        Namespaced_IRI.parse _namespace_name "article-guarantor" |> NamespacedName

    /// <summary>
    /// Defines the type or nature of a contribution made with respect to the authorship of a publication such as a journal article.  Individual members of this class are used to specify particular authorship contributions.
    /// <see href="http://purl.org/spar/scoro/AuthorshipContribution"></see></summary>
    let AuthorshipContribution =
        Namespaced_IRI.parse _namespace_name "AuthorshipContribution" |> NamespacedName

    /// <summary>
    /// Defines the type or nature of a practical or experimental contribution made to the research.  Individual members of this class are used to specify particular contributions.
    /// <see href="http://purl.org/spar/scoro/ExperimentalContribution"></see></summary>
    let ExperimentalContribution =
        Namespaced_IRI.parse _namespace_name "ExperimentalContribution" |> NamespacedName

    /// <summary>
    /// Defines the type or nature of an intellectual contribution made to the research described in a journal article.  Individual members of this class are used to specify particular contributions.
    /// <see href="http://purl.org/spar/scoro/IntellectualContribution"></see></summary>
    let IntellectualContribution =
        Namespaced_IRI.parse _namespace_name "IntellectualContribution" |> NamespacedName

    /// <summary>
    /// Defines the type or nature of an organizational or administrative contribution.  Individual members of this class are used to specify particular contributions.
    /// <see href="http://purl.org/spar/scoro/OrganizationalContribution"></see></summary>
    let OrganizationalContribution =
        Namespaced_IRI.parse _namespace_name "OrganizationalContribution" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/spar/scoro/scoro.png"></see>
    /// </summary>
    let ``scoro.png`` =
        Namespaced_IRI.parse _namespace_name "scoro.png" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/spar/scoro/2017-09-04"></see>
    /// </summary>
    let ``_2017-09-04`` =
        Namespaced_IRI.parse _namespace_name "2017-09-04" |> NamespacedName

    /// <summary>
    /// Defines the type or nature of a contribution made by an agent.  Individual members of this class or its sub-classes are used to specify particular contributions.
    /// <see href="http://purl.org/spar/scoro/Contribution"></see></summary>
    let Contribution =
        Namespaced_IRI.parse _namespace_name "Contribution" |> NamespacedName

    /// <summary>
    /// A computer system or software program whose action has an effect on external events, for example a laboratory robot that undertakes your experiments, or the financial control system that controls an institution's payrole, or that, following programmed business rules, prevents the principal investigator from placing an order for research equipment because there is insufficient money left in the project budget.
    /// <see href="http://purl.org/spar/scoro/ComputationalAgent"></see></summary>
    let ComputationalAgent =
        Namespaced_IRI.parse _namespace_name "ComputationalAgent" |> NamespacedName

    /// <summary>
    /// Defines the effort expended in making a contribution.
    /// <see href="http://purl.org/spar/scoro/ContributionEffort"></see></summary>
    let ContributionEffort =
        Namespaced_IRI.parse _namespace_name "ContributionEffort" |> NamespacedName

    /// <summary>
    /// The situation an agent has of making a contribution to realizing a goal or completing a task relating to a scholarly activity or entity such as journal article.  The type or nature of the contribution is defined by the object of the object property scoro:withContribution, which is an individual in the class scoro:Contribution or one of its sub-classes.  The entity to which the contribution relates is specified using the object property scoro:relatesToEntity or one of its sub-properties, and the effort expended in making that contribution is specified using the object property scoro:withContributionEffort.
    /// <see href="http://purl.org/spar/scoro/ContributionSituation"></see></summary>
    let ContributionSituation =
        Namespaced_IRI.parse _namespace_name "ContributionSituation" |> NamespacedName

    /// <summary>
    /// An object property connecting an agent's contribution situation to a definition of the contribution made by this agent, specified as an instance of the class scoro:Contribution or of one of its sub-classes.
    /// <see href="http://purl.org/spar/scoro/withContribution"></see></summary>
    let withContribution =
        Namespaced_IRI.parse _namespace_name "withContribution" |> NamespacedName

    /// <summary>
    /// A role that an agent might hold with respect to an educational organization or activity.  Individual members of this class are used to specify particular educational roles.
    /// <see href="http://purl.org/spar/scoro/EducationalRole"></see></summary>
    let EducationalRole =
        Namespaced_IRI.parse _namespace_name "EducationalRole" |> NamespacedName

    /// <summary>
    /// The role of an agent who provides access to a resource, for example an online data repository.
    /// <see href="http://purl.org/spar/scoro/access-provider"></see></summary>
    let ``access-provider`` =
        Namespaced_IRI.parse _namespace_name "access-provider" |> NamespacedName

    /// <summary>
    /// The role held by a person whose job is to manage financial accounts, for example the accounts of an organization, or of a particular funded project or activity of that organization.
    /// <see href="http://purl.org/spar/scoro/accountant"></see></summary>
    let accountant = Namespaced_IRI.parse _namespace_name "accountant" |> NamespacedName

    /// <summary>
    /// The role held by an agent responsible for the day-to-day management and running of an organization or activity.
    /// <see href="http://purl.org/spar/scoro/administrator"></see></summary>
    let administrator =
        Namespaced_IRI.parse _namespace_name "administrator" |> NamespacedName

    /// <summary>
    /// The role an agent has of being affiliated to some organization or institution in a context of some entity or activity, for example a document, a project or an internship.
    /// <see href="http://purl.org/spar/scoro/affiliate"></see></summary>
    let affiliate = Namespaced_IRI.parse _namespace_name "affiliate" |> NamespacedName
    /// <summary>
    /// An agent that acts on behalf of another agent.
    /// <see href="http://purl.org/spar/scoro/agent"></see></summary>
    let agent = Namespaced_IRI.parse _namespace_name "agent" |> NamespacedName

    /// <summary>
    /// The contribution of data analysis.  This might include statistical analysis, bioinformatics analysis, or image analysis.
    /// <see href="http://purl.org/spar/scoro/analyses-data"></see></summary>
    let ``analyses-data`` =
        Namespaced_IRI.parse _namespace_name "analyses-data" |> NamespacedName

    /// <summary>
    /// The contribution of approving the final version of the manuscript, prior to submission for publication.
    /// <see href="http://purl.org/spar/scoro/approves-final-manuscript"></see></summary>
    let ``approves-final-manuscript`` =
        Namespaced_IRI.parse _namespace_name "approves-final-manuscript" |> NamespacedName

    /// <summary>
    /// The role held by a person who conducts a formal audit of financial accounts.
    /// <see href="http://purl.org/spar/scoro/auditor"></see></summary>
    let auditor = Namespaced_IRI.parse _namespace_name "auditor" |> NamespacedName

    /// <summary>
    /// The contribution of building instruments, equipment or scientific apparatus and/or maintaining the same in a workable condition for use in experiments.
    /// <see href="http://purl.org/spar/scoro/builds-and-or-maintains-instruments"></see></summary>
    let ``builds-and-or-maintains-instruments`` =
        Namespaced_IRI.parse _namespace_name "builds-and-or-maintains-instruments" |> NamespacedName

    /// <summary>
    /// The role held by a person who is the chief executive officer of an organization, responsible for directing and managing the business of that organization.
    /// <see href="http://purl.org/spar/scoro/chief-executive-officer"></see></summary>
    let ``chief-executive-officer`` =
        Namespaced_IRI.parse _namespace_name "chief-executive-officer" |> NamespacedName

    /// <summary>
    /// A senior scientist who takes a leadership role in an organization or group.
    /// <see href="http://purl.org/spar/scoro/chief-scientist"></see></summary>
    let ``chief-scientist`` =
        Namespaced_IRI.parse _namespace_name "chief-scientist" |> NamespacedName

    /// <summary>
    /// The role held by a person who is the chief technology officer of an organization, responsible for directing and managing technical developments for that organization.
    /// <see href="http://purl.org/spar/scoro/chief-technology-officer"></see></summary>
    let ``chief-technology-officer`` =
        Namespaced_IRI.parse _namespace_name "chief-technology-officer" |> NamespacedName

    /// <summary>
    /// The role held by a person making a financial claim, for example for refund of travel expenses from a project grant.
    /// <see href="http://purl.org/spar/scoro/claimant"></see></summary>
    let claimant = Namespaced_IRI.parse _namespace_name "claimant" |> NamespacedName

    /// <summary>
    /// The role a person has of being a co-applicant on the grant application to obtain funding to fund an endeavour such as a research project.
    /// <see href="http://purl.org/spar/scoro/co-applicant"></see></summary>
    let ``co-applicant`` =
        Namespaced_IRI.parse _namespace_name "co-applicant" |> NamespacedName

    /// <summary>
    /// The role a person has of being a co-investigator for a research investigation.
    /// <see href="http://purl.org/spar/scoro/co-investigator"></see></summary>
    let ``co-investigator`` =
        Namespaced_IRI.parse _namespace_name "co-investigator" |> NamespacedName

    /// <summary>
    /// The role a person, typically from another research group or institution, who collaborates with the team undertaking a research investigation.
    /// <see href="http://purl.org/spar/scoro/collaborator"></see></summary>
    let collaborator =
        Namespaced_IRI.parse _namespace_name "collaborator" |> NamespacedName

    /// <summary>
    /// The contribution of making experimental observations and collecting data, for example using a telescope, a microscope or an analytical instrument.
    /// <see href="http://purl.org/spar/scoro/collects-data"></see></summary>
    let ``collects-data`` =
        Namespaced_IRI.parse _namespace_name "collects-data" |> NamespacedName

    /// <summary>
    /// The role held by an academic as a senior member of a college.
    /// <see href="http://purl.org/spar/scoro/college-fellow"></see></summary>
    let ``college-fellow`` =
        Namespaced_IRI.parse _namespace_name "college-fellow" |> NamespacedName

    /// <summary>
    /// The role held by a senior academic who heads a college and acts as its CEO.  Among the many alternative titles give to this role, the most common are President or Master of the college.
    /// <see href="http://purl.org/spar/scoro/college-head"></see></summary>
    let ``college-head`` =
        Namespaced_IRI.parse _namespace_name "college-head" |> NamespacedName

    /// <summary>
    /// The role a person has of being someone who develops computer software.
    /// <see href="http://purl.org/spar/scoro/computer-programmer"></see></summary>
    let ``computer-programmer`` =
        Namespaced_IRI.parse _namespace_name "computer-programmer" |> NamespacedName

    /// <summary>
    /// The contribution of conceiving the research project in the first place.
    ///
    /// Note that an individual other than the lead applicant and the co-applicants on a grant application may make considerable contributions to conceiving a research project, but may be prevented from being a formal applicant by reason of affiliation or status (e.g. as a non-academic partner, or a research student).
    /// <see href="http://purl.org/spar/scoro/conceives-project"></see></summary>
    let ``conceives-project`` =
        Namespaced_IRI.parse _namespace_name "conceives-project" |> NamespacedName

    /// <summary>
    /// The authorship role of an organisation or consortium that has contributed collectively to the work described in the publication and is named in the list of authors, e.g. 'Wellcome Trust Case Control Consortium' or 'Malaria Genomic Epidemiology Network'.  (The members of such a group should be separately listed elsewhere in the document).
    /// <see href="http://purl.org/spar/scoro/consortium-author"></see></summary>
    let ``consortium-author`` =
        Namespaced_IRI.parse _namespace_name "consortium-author" |> NamespacedName

    /// <summary>
    /// The role a person has of being a consultant who is providing expertise or services.
    /// <see href="http://purl.org/spar/scoro/consultant"></see></summary>
    let consultant = Namespaced_IRI.parse _namespace_name "consultant" |> NamespacedName

    /// <summary>
    /// The role of a person who serves as the primary contact and information provider for third parties wishing to find out more about an organization or an activity.
    /// <see href="http://purl.org/spar/scoro/contact-person"></see></summary>
    let ``contact-person`` =
        Namespaced_IRI.parse _namespace_name "contact-person" |> NamespacedName

    /// <summary>
    /// The role held by an agent who enters into a contract to undertake specified work or to supply specified services in return for payment.
    /// <see href="http://purl.org/spar/scoro/contractor"></see></summary>
    let contractor = Namespaced_IRI.parse _namespace_name "contractor" |> NamespacedName

    /// <summary>
    /// The contribution of controlling the financial aspects of the research project, including authorizing expenditure, creating and managing budgets, and submitting financial reports to the funding agency.
    /// <see href="http://purl.org/spar/scoro/controls-project-finances"></see></summary>
    let ``controls-project-finances`` =
        Namespaced_IRI.parse _namespace_name "controls-project-finances" |> NamespacedName

    /// <summary>
    /// The role an author has of being the corresponding author of the document, with whom editors and readers should correspond concerning it.
    /// <see href="http://purl.org/spar/scoro/corresponding-author"></see></summary>
    let ``corresponding-author`` =
        Namespaced_IRI.parse _namespace_name "corresponding-author" |> NamespacedName

    /// <summary>
    /// The contribution of creating novel organisms (e.g. mouse mutants) or cells (e.g. tranformed cell lines), either for use in the research, or as a research output of use to others.
    /// <see href="http://purl.org/spar/scoro/creates-novel-organisms-or-cells"></see></summary>
    let ``creates-novel-organisms-or-cells`` =
        Namespaced_IRI.parse _namespace_name "creates-novel-organisms-or-cells" |> NamespacedName

    /// <summary>
    /// The contribution of creating novel physical or chemical compounds, or molecular biology constructs, either for use in the research, or as a research output of use to others.
    /// <see href="http://purl.org/spar/scoro/creates-novel-reagents"></see></summary>
    let ``creates-novel-reagents`` =
        Namespaced_IRI.parse _namespace_name "creates-novel-reagents" |> NamespacedName

    /// <summary>
    /// The contribution of creating computer software, including software for experimental control, analytical tools, mathematical model and computational simulations for use in the research, or of creating an IT service (e.g. a bioinformatics database or Web service) of use to others.
    /// <see href="http://purl.org/spar/scoro/creates-software"></see></summary>
    let ``creates-software`` =
        Namespaced_IRI.parse _namespace_name "creates-software" |> NamespacedName

    /// <summary>
    /// The role of an agent that documents, cares for and manages collections of objects (for example in a museum) or of data (as in a data repository or database).  [A data curator is a curator who specializes in digital data, while a librarian is a type of curator specializing in textual publications.]
    /// <see href="http://purl.org/spar/scoro/curator"></see></summary>
    let curator = Namespaced_IRI.parse _namespace_name "curator" |> NamespacedName

    /// <summary>
    /// The role a person has of being a creator, originator, gatherer or collector of new data.
    /// <see href="http://purl.org/spar/scoro/data-creator"></see></summary>
    let ``data-creator`` =
        Namespaced_IRI.parse _namespace_name "data-creator" |> NamespacedName

    /// <summary>
    /// The role a person has of being a data curator, responsible reviewing, enhancing, cleaning, or standardizing data and their associated metadata, for example those arising from the research project, and for their long-term preservation.
    /// <see href="http://purl.org/spar/scoro/data-curator"></see></summary>
    let ``data-curator`` =
        Namespaced_IRI.parse _namespace_name "data-curator" |> NamespacedName

    /// <summary>
    /// The role a person has of being a data manager, responsible for day-to-day management, maintenance and back-up of data, for example those arising from the research project or held in a repository.
    /// <see href="http://purl.org/spar/scoro/data-manager"></see></summary>
    let ``data-manager`` =
        Namespaced_IRI.parse _namespace_name "data-manager" |> NamespacedName

    /// <summary>
    /// The role of an agent who publishes data.
    /// <see href="http://purl.org/spar/scoro/data-publisher"></see></summary>
    let ``data-publisher`` =
        Namespaced_IRI.parse _namespace_name "data-publisher" |> NamespacedName

    /// <summary>
    /// The role a person has of being a user or re-user of existing data.
    /// <see href="http://purl.org/spar/scoro/data-user"></see></summary>
    let ``data-user`` =
        Namespaced_IRI.parse _namespace_name "data-user" |> NamespacedName

    /// <summary>
    /// The role held by a person who is the administrator of a department within a larger organization, for example of a university academic department.
    /// <see href="http://purl.org/spar/scoro/departmental-administrator"></see></summary>
    let ``departmental-administrator`` =
        Namespaced_IRI.parse _namespace_name "departmental-administrator" |> NamespacedName

    /// <summary>
    /// The contribution of experimental design and planning.
    /// <see href="http://purl.org/spar/scoro/designs-experiments"></see></summary>
    let ``designs-experiments`` =
        Namespaced_IRI.parse _namespace_name "designs-experiments" |> NamespacedName

    /// <summary>
    /// The contribution of developing experimental methodology that enables research.
    /// <see href="http://purl.org/spar/scoro/develops-methodology"></see></summary>
    let ``develops-methodology`` =
        Namespaced_IRI.parse _namespace_name "develops-methodology" |> NamespacedName

    /// <summary>
    /// The role held by a person who is in charge of an organization or activity, for example a research institute or a dramatic performance.
    /// <see href="http://purl.org/spar/scoro/director"></see></summary>
    let director = Namespaced_IRI.parse _namespace_name "director" |> NamespacedName

    /// <summary>
    /// The role of a person registerd for a Ph.D. degree at a university.
    /// <see href="http://purl.org/spar/scoro/doctoral-student"></see></summary>
    let ``doctoral-student`` =
        Namespaced_IRI.parse _namespace_name "doctoral-student" |> NamespacedName

    /// <summary>
    /// The role of the person who has responsibility for setting and lifting embargos that restrict access to a dataset (or a document) for a specified period of time.
    /// <see href="http://purl.org/spar/scoro/embargo-controller"></see></summary>
    let ``embargo-controller`` =
        Namespaced_IRI.parse _namespace_name "embargo-controller" |> NamespacedName

    /// <summary>
    /// The role held by a person employed for wages or a salary by an organization, to undertake work for that organization.
    /// <see href="http://purl.org/spar/scoro/employee"></see></summary>
    let employee = Namespaced_IRI.parse _namespace_name "employee" |> NamespacedName
    /// <summary>
    /// The role held by an agent that employs one or more people to undertake work on that agent's behalf.
    /// <see href="http://purl.org/spar/scoro/employer"></see></summary>
    let employer = Namespaced_IRI.parse _namespace_name "employer" |> NamespacedName

    /// <summary>
    /// The contribution of ensuring regulatory compliance for the research undertaken, for example in obtaining informed consent from patients, approval from research ethics or radiation safety committees, or a license for animal experimentation.
    /// <see href="http://purl.org/spar/scoro/ensures-regulatory-compliance"></see></summary>
    let ``ensures-regulatory-compliance`` =
        Namespaced_IRI.parse _namespace_name "ensures-regulatory-compliance" |> NamespacedName

    /// <summary>
    /// The role of an academic employed to undertake research and teaching within a university department, school or institute.
    /// <see href="http://purl.org/spar/scoro/faculty-member"></see></summary>
    let ``faculty-member`` =
        Namespaced_IRI.parse _namespace_name "faculty-member" |> NamespacedName

    /// <summary>
    /// The role held by an agent of controlling the finances, for example the finances of an organization, a building project or a research project.  This role extends to the control of or the authorisation of expenditure from a budget, and may be undertaken by a computational agent.
    /// <see href="http://purl.org/spar/scoro/financial-controller"></see></summary>
    let ``financial-controller`` =
        Namespaced_IRI.parse _namespace_name "financial-controller" |> NamespacedName

    /// <summary>
    /// The contribution of formulating the questions to be answered and the hypotheses to be tested by the research to be undertaken.
    /// <see href="http://purl.org/spar/scoro/formulates-research-questions"></see></summary>
    let ``formulates-research-questions`` =
        Namespaced_IRI.parse _namespace_name "formulates-research-questions" |> NamespacedName

    /// <summary>
    /// The role held by an agent of providing funds, for example for a research project.
    /// <see href="http://purl.org/spar/scoro/funder"></see></summary>
    let funder = Namespaced_IRI.parse _namespace_name "funder" |> NamespacedName

    /// <summary>
    /// The role held by an agent who is the official recipient of funding, for example the university of which a funded research project leader is a member.
    /// <see href="http://purl.org/spar/scoro/funding-recipient"></see></summary>
    let ``funding-recipient`` =
        Namespaced_IRI.parse _namespace_name "funding-recipient" |> NamespacedName

    /// <summary>
    /// A property relating a contribution situation to an entity representing the context for that situation.
    /// <see href="http://purl.org/spar/scoro/hasContributionContext"></see></summary>
    let hasContributionContext =
        Namespaced_IRI.parse _namespace_name "hasContributionContext" |> NamespacedName

    /// <summary>
    /// A property relating an entity to the contribution situation for which that entity provides the context.
    /// <see href="http://purl.org/spar/scoro/isRelatedToContributionSituation"></see></summary>
    let isRelatedToContributionSituation =
        Namespaced_IRI.parse _namespace_name "isRelatedToContributionSituation" |> NamespacedName

    /// <summary>
    /// A data property relating an individual to his/her Open Researcher and Contributor ID (ORCID), an alphanumeric identifier for individual scholars described at http://about.orcid.org/.
    /// <see href="http://purl.org/spar/scoro/hasORCID"></see></summary>
    let hasORCID = Namespaced_IRI.parse _namespace_name "hasORCID" |> NamespacedName

    /// <summary>
    /// A data property specifying a unique and unambiguous identifier for an individual person within a given context, specified by the object property scoro:usesPersonalIdentifierScheme and an individual member of the class scoro:PersonalIdentifierScheme.
    /// <see href="http://purl.org/spar/scoro/hasPersonalIdentifier"></see></summary>
    let hasPersonalIdentifier =
        Namespaced_IRI.parse _namespace_name "hasPersonalIdentifier" |> NamespacedName

    /// <summary>
    /// The role held by a person who is the chief executive officer of a department within a larger organization, for example a senior academic who is head of a university academic department.
    /// <see href="http://purl.org/spar/scoro/head-of-department"></see></summary>
    let ``head-of-department`` =
        Namespaced_IRI.parse _namespace_name "head-of-department" |> NamespacedName

    /// <summary>
    /// The role held by a institution of hosting some initiative, people, or event.
    /// <see href="http://purl.org/spar/scoro/host-institution"></see></summary>
    let ``host-institution`` =
        Namespaced_IRI.parse _namespace_name "host-institution" |> NamespacedName

    /// <summary>
    /// The role a person has of being an illustrator of, or for, some entity.
    /// <see href="http://purl.org/spar/scoro/illustrator"></see></summary>
    let illustrator =
        Namespaced_IRI.parse _namespace_name "illustrator" |> NamespacedName

    /// <summary>
    /// The contribution of interpretation of experimental results.
    /// <see href="http://purl.org/spar/scoro/interprets-results"></see></summary>
    let ``interprets-results`` =
        Namespaced_IRI.parse _namespace_name "interprets-results" |> NamespacedName

    /// <summary>
    /// The role a person has of being the inventor or some entity (for example a computer algorithm, or an experimental procedure).
    /// <see href="http://purl.org/spar/scoro/inventor"></see></summary>
    let inventor = Namespaced_IRI.parse _namespace_name "inventor" |> NamespacedName

    /// <summary>
    /// The property relating the definition of a specific contribution to the contribution situation of an agent making that contribution.
    /// <see href="http://purl.org/spar/scoro/isContributionIn"></see></summary>
    let isContributionIn =
        Namespaced_IRI.parse _namespace_name "isContributionIn" |> NamespacedName

    /// <summary>
    /// This property allows the link of two contribution situations that are equals for particular aspects (i.e. for type of contribution, contribution effort and context).
    /// <see href="http://purl.org/spar/scoro/isEqualToContributionSituation"></see></summary>
    let isEqualToContributionSituation =
        Namespaced_IRI.parse _namespace_name "isEqualToContributionSituation" |> NamespacedName

    /// <summary>
    /// This property allows the link of two roles in time as being equal, and is particularly useful for specifying that two principal authorship roles are equal.
    /// <see href="http://purl.org/spar/scoro/isEqualToRoleInTime"></see></summary>
    let isEqualToRoleInTime =
        Namespaced_IRI.parse _namespace_name "isEqualToRoleInTime" |> NamespacedName

    /// <summary>
    /// A property relating a contribution situation that an agent makes, to that agent.
    /// <see href="http://purl.org/spar/scoro/isMadeBy"></see></summary>
    let isMadeBy = Namespaced_IRI.parse _namespace_name "isMadeBy" |> NamespacedName

    /// <summary>
    /// An object property linking an agent to a contribution.  This is done via the indirection: foaf:Agent scoro:makesContribution [ a scoro:ContributionSituation ; scoro:withContribution scoro:Contribution ; scoro:withEffort scoro:ContributionEffort ] .  The ontology permits one to specify the time period over which a contribution is made, and the other contextual entities to which that agent's contribution relates.
    /// <see href="http://purl.org/spar/scoro/makesContribution"></see></summary>
    let makesContribution =
        Namespaced_IRI.parse _namespace_name "makesContribution" |> NamespacedName

    /// <summary>
    /// The role a person has of being the lead applicant on the grant application to obtain funding to fund an endeavour such as a research project.
    /// <see href="http://purl.org/spar/scoro/lead-applicant"></see></summary>
    let ``lead-applicant`` =
        Namespaced_IRI.parse _namespace_name "lead-applicant" |> NamespacedName

    /// <summary>
    /// The contribution of providing intellectual leadership and direction for the research.
    ///
    /// Note that an individual other than the principal investigator and the co-investigators may make considerable leadership contributions to a research investigation.
    /// <see href="http://purl.org/spar/scoro/leads-investigation"></see></summary>
    let ``leads-investigation`` =
        Namespaced_IRI.parse _namespace_name "leads-investigation" |> NamespacedName

    /// <summary>
    /// The contribution of maintaining the IT infrastructure required for the research.
    /// <see href="http://purl.org/spar/scoro/maintains-IT-Infrastructure"></see></summary>
    let ``maintains-IT-Infrastructure`` =
        Namespaced_IRI.parse _namespace_name "maintains-IT-Infrastructure" |> NamespacedName

    /// <summary>
    /// The contribution of maintaining multicellular organisms (plants, animals or fungi) or cell cultures used as experimental subjects, and of breeding these where appropriate.
    ///
    /// [Note that there may be occasions when it is inappropriate to acknowledge such contributions, for fear of personal reprisals on the individuals involved from animal rights activists].
    /// <see href="http://purl.org/spar/scoro/maintains-organisms-or-cells"></see></summary>
    let ``maintains-organisms-or-cells`` =
        Namespaced_IRI.parse _namespace_name "maintains-organisms-or-cells" |> NamespacedName

    /// <summary>
    /// The contribution of managing and operating a research facility, for example a confocal microscopy facility.
    /// <see href="http://purl.org/spar/scoro/maintains-research-facility"></see></summary>
    let ``maintains-research-facility`` =
        Namespaced_IRI.parse _namespace_name "maintains-research-facility" |> NamespacedName

    /// <summary>
    /// The contributor provided a major effort towards achieving this contribution.  (It would be unusual for more than three contributors to be described as providing major effort towards achieving any particular contribution).
    /// <see href="http://purl.org/spar/scoro/major-effort"></see></summary>
    let ``major-effort`` =
        Namespaced_IRI.parse _namespace_name "major-effort" |> NamespacedName

    /// <summary>
    /// The role held by a person responsible for managing the day-to-day activities of an activity, enterprise or organization.
    /// <see href="http://purl.org/spar/scoro/manager"></see></summary>
    let manager = Namespaced_IRI.parse _namespace_name "manager" |> NamespacedName

    /// <summary>
    /// The contribution of project management.
    ///
    /// Note that an individual other than the person holding the formal role of project manager may make considerable contributions to the management of a research project.
    /// <see href="http://purl.org/spar/scoro/manages-project"></see></summary>
    let ``manages-project`` =
        Namespaced_IRI.parse _namespace_name "manages-project" |> NamespacedName

    /// <summary>
    /// The role of a person registerd for a master degree at a university.
    /// <see href="http://purl.org/spar/scoro/master-student"></see></summary>
    let ``master-student`` =
        Namespaced_IRI.parse _namespace_name "master-student" |> NamespacedName

    /// <summary>
    /// The role held by an agent of belonging to a group or organization.
    /// <see href="http://purl.org/spar/scoro/member"></see></summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName

    /// <summary>
    /// The contributor provided a minor effort towards achieving this contribution.
    /// <see href="http://purl.org/spar/scoro/minor-effort"></see></summary>
    let ``minor-effort`` =
        Namespaced_IRI.parse _namespace_name "minor-effort" |> NamespacedName

    /// <summary>
    /// The role of a person employed within a university department, school or institute who is not a member of the academic faculty.
    /// <see href="http://purl.org/spar/scoro/non-academic-staff-member"></see></summary>
    let ``non-academic-staff-member`` =
        Namespaced_IRI.parse _namespace_name "non-academic-staff-member" |> NamespacedName

    /// <summary>
    /// The contribution of obtaining and/or preparing specimens in a manner requiring research expertise or skill, for example collecting and preparing fossils, or preparing electron microscope specimens for examination.
    /// <see href="http://purl.org/spar/scoro/obtains-and-or-prepares-specimens"></see></summary>
    let ``obtains-and-or-prepares-specimens`` =
        Namespaced_IRI.parse _namespace_name "obtains-and-or-prepares-specimens" |> NamespacedName

    /// <summary>
    /// The role held by an agent who organizes something, such as a conference, a private meeting or a public event.
    /// <see href="http://purl.org/spar/scoro/organizer"></see></summary>
    let organizer = Namespaced_IRI.parse _namespace_name "organizer" |> NamespacedName
    /// <summary>
    /// The role held by an agent who is the owner of something with actual or potential financial value, for example a building, a piece of equipment, the copyright of a document, or the intellectual property rights relating to an idea or discovery.
    /// <see href="http://purl.org/spar/scoro/owner"></see></summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName

    /// <summary>
    /// The role held by an agent who takes part in something, for example a conference, a private meeting or a public event.
    /// <see href="http://purl.org/spar/scoro/participant"></see></summary>
    let participant =
        Namespaced_IRI.parse _namespace_name "participant" |> NamespacedName

    /// <summary>
    /// The role held by a person who is a partner with one or more other people in an organization, project, endeavour, activity or sphere of common interest.
    /// <see href="http://purl.org/spar/scoro/partner"></see></summary>
    let partner = Namespaced_IRI.parse _namespace_name "partner" |> NamespacedName

    /// <summary>
    /// The role held by an agent who holds a patent.
    ///
    /// [See also http://purl.org/spar/scoro/rights-holder and http://purl.org/spar/pro/copyright-owner].
    /// <see href="http://purl.org/spar/scoro/patent-holder"></see></summary>
    let ``patent-holder`` =
        Namespaced_IRI.parse _namespace_name "patent-holder" |> NamespacedName

    /// <summary>
    /// A data property permitting specification of the proportion of a person's full time activity that is dedicated to a particular role (e.g. for part-time employment, 50% FTE).
    /// <see href="http://purl.org/spar/scoro/percentageFTE"></see></summary>
    let percentageFTE =
        Namespaced_IRI.parse _namespace_name "percentageFTE" |> NamespacedName

    /// <summary>
    /// The contribution of performing experiments.
    /// <see href="http://purl.org/spar/scoro/performs-experiments"></see></summary>
    let ``performs-experiments`` =
        Namespaced_IRI.parse _namespace_name "performs-experiments" |> NamespacedName

    /// <summary>
    /// The role a person has of being a photographer of, or for, some entity.
    /// <see href="http://purl.org/spar/scoro/photographer"></see></summary>
    let photographer =
        Namespaced_IRI.parse _namespace_name "photographer" |> NamespacedName

    /// <summary>
    /// The role held by an agent as possessor or owner of some entity such as an address or a telephone number.
    /// <see href="http://purl.org/spar/scoro/possessor"></see></summary>
    let possessor = Namespaced_IRI.parse _namespace_name "possessor" |> NamespacedName

    /// <summary>
    /// The role a person has of being a post-doctoral researcher involved in a research investigation.
    /// <see href="http://purl.org/spar/scoro/postdoctoral-researcher"></see></summary>
    let ``postdoctoral-researcher`` =
        Namespaced_IRI.parse _namespace_name "postdoctoral-researcher" |> NamespacedName

    /// <summary>
    /// The role of a person registerd for a graduate (masters or doctoral) degree at a university.
    /// <see href="http://purl.org/spar/scoro/postgraduate-student"></see></summary>
    let ``postgraduate-student`` =
        Namespaced_IRI.parse _namespace_name "postgraduate-student" |> NamespacedName

    /// <summary>
    /// The contribution of selecting the data and preparing the figures and tables presenting these data for inclusion in the publication.
    /// <see href="http://purl.org/spar/scoro/prepares-illustrations"></see></summary>
    let ``prepares-illustrations`` =
        Namespaced_IRI.parse _namespace_name "prepares-illustrations" |> NamespacedName

    /// <summary>
    /// The contribution of preparing the supplementary information files submitted with the manuscript.
    /// <see href="http://purl.org/spar/scoro/prepares-supplementary-information"></see></summary>
    let ``prepares-supplementary-information`` =
        Namespaced_IRI.parse _namespace_name "prepares-supplementary-information" |> NamespacedName

    /// <summary>
    /// The role an author has of being the principal or primary author of the document, who has contributed most to the work described.
    ///
    /// (In some communities, but not all, the principal author is named first in the author list.  Two or more authors can have the role of principal author if they contributed equally to the work.  This role should not be employed in communities in which no primacy of authorship is asserted, but where all authors are deemed to have made an equal contribution to the work.)
    /// <see href="http://purl.org/spar/scoro/principal-author"></see></summary>
    let ``principal-author`` =
        Namespaced_IRI.parse _namespace_name "principal-author" |> NamespacedName

    /// <summary>
    /// The role a person has of being the principal investigator for a research investigation.
    /// <see href="http://purl.org/spar/scoro/principal-investigator"></see></summary>
    let ``principal-investigator`` =
        Namespaced_IRI.parse _namespace_name "principal-investigator" |> NamespacedName

    /// <summary>
    /// The contribution of processing, cleaning, assembling, condensing or refining the data.
    /// <see href="http://purl.org/spar/scoro/processes-data"></see></summary>
    let ``processes-data`` =
        Namespaced_IRI.parse _namespace_name "processes-data" |> NamespacedName

    /// <summary>
    /// The role held by a person who is in charge of a programme of related activities or projects, for example on behalf of a funding agency.
    /// <see href="http://purl.org/spar/scoro/programme-manager"></see></summary>
    let ``programme-manager`` =
        Namespaced_IRI.parse _namespace_name "programme-manager" |> NamespacedName

    /// <summary>
    /// The role a person or an institution has of being project leader for a resource or a project such as a research project.
    /// <see href="http://purl.org/spar/scoro/project-leader"></see></summary>
    let ``project-leader`` =
        Namespaced_IRI.parse _namespace_name "project-leader" |> NamespacedName

    /// <summary>
    /// The role a person has of being project manager for a project such as a research project.
    /// <see href="http://purl.org/spar/scoro/project-manager"></see></summary>
    let ``project-manager`` =
        Namespaced_IRI.parse _namespace_name "project-manager" |> NamespacedName

    /// <summary>
    /// The role a person has of being a member of a project such as a research project.
    /// <see href="http://purl.org/spar/scoro/project-member"></see></summary>
    let ``project-member`` =
        Namespaced_IRI.parse _namespace_name "project-member" |> NamespacedName

    /// <summary>
    /// The role a person has of being a project student, namely someone engaged in an undergraduate research project as part of studying for an undergraduate degree at a university, whose research will be presented in an undergraduate research project report in part fulfilment of the requirements of that degree.
    /// <see href="http://purl.org/spar/scoro/project-student"></see></summary>
    let ``project-student`` =
        Namespaced_IRI.parse _namespace_name "project-student" |> NamespacedName

    /// <summary>
    /// The contribution of providing administrative support for the research project.
    /// <see href="http://purl.org/spar/scoro/provides-administrative-support"></see></summary>
    let ``provides-administrative-support`` =
        Namespaced_IRI.parse _namespace_name "provides-administrative-support" |> NamespacedName

    /// <summary>
    /// The contribution of providing advice to facilitate the research, while not actively participating in the work.
    /// <see href="http://purl.org/spar/scoro/provides-advice"></see></summary>
    let ``provides-advice`` =
        Namespaced_IRI.parse _namespace_name "provides-advice" |> NamespacedName

    /// <summary>
    /// The contribution of providing pre-existing data for re-use in the research.
    /// <see href="http://purl.org/spar/scoro/provides-exising-data"></see></summary>
    let ``provides-exising-data`` =
        Namespaced_IRI.parse _namespace_name "provides-exising-data" |> NamespacedName

    /// <summary>
    /// The contribution of providing access to medical or veterinary patients, to make possible the research.
    /// <see href="http://purl.org/spar/scoro/provides-patients"></see></summary>
    let ``provides-patients`` =
        Namespaced_IRI.parse _namespace_name "provides-patients" |> NamespacedName

    /// <summary>
    /// The contribution of providing reagents, specimens or materials, including living organisms and cells, for example those not readily obtainable from commercial sources, to make possible the research.
    /// <see href="http://purl.org/spar/scoro/provides-reagents-specimens-or-materials"></see></summary>
    let ``provides-reagents-specimens-or-materials`` =
        Namespaced_IRI.parse _namespace_name "provides-reagents-specimens-or-materials" |> NamespacedName

    /// <summary>
    /// The contribution of providing a research service, for example a DNA sequencing service or a custom peptide synthesis service.
    /// <see href="http://purl.org/spar/scoro/provides-service"></see></summary>
    let ``provides-service`` =
        Namespaced_IRI.parse _namespace_name "provides-service" |> NamespacedName

    /// <summary>
    /// The contribution of providing software to facilitate the research, while not actively participating in the work.
    /// <see href="http://purl.org/spar/scoro/provides-software"></see></summary>
    let ``provides-software`` =
        Namespaced_IRI.parse _namespace_name "provides-software" |> NamespacedName

    /// <summary>
    /// The contribution of providing technical support that facilitates research.
    /// <see href="http://purl.org/spar/scoro/provides-technical-support"></see></summary>
    let ``provides-technical-support`` =
        Namespaced_IRI.parse _namespace_name "provides-technical-support" |> NamespacedName

    /// <summary>
    /// The contribution of providing tools, equipment or facilities for the research, while not actively participating in the work.
    /// <see href="http://purl.org/spar/scoro/provides-tools-equipment-or-facilities"></see></summary>
    let ``provides-tools-equipment-or-facilities`` =
        Namespaced_IRI.parse _namespace_name "provides-tools-equipment-or-facilities" |> NamespacedName

    /// <summary>
    /// The contribution of publishing in a public database or data repository data arising from the research.
    ///
    /// Note that this activity is distinct from that of publishing a journal article containing a selection of these data.
    /// <see href="http://purl.org/spar/scoro/publishes-data"></see></summary>
    let ``publishes-data`` =
        Namespaced_IRI.parse _namespace_name "publishes-data" |> NamespacedName

    /// <summary>
    /// The role held by an agent of making purchases of goods or services, the cost of which is typically charged to a particular academic budget, for example a project manager placing an order to purchase equipment funded from a research grant.
    /// <see href="http://purl.org/spar/scoro/purchaser"></see></summary>
    let purchaser = Namespaced_IRI.parse _namespace_name "purchaser" |> NamespacedName
    /// <summary>
    /// The role held by an agent responsible for maintaining official records, for example the records of student enrollment and academic standing held by a college or university, or the records of securities owned by a financial institution.
    /// <see href="http://purl.org/spar/scoro/registrar"></see></summary>
    let registrar = Namespaced_IRI.parse _namespace_name "registrar" |> NamespacedName

    /// <summary>
    /// The role of an agent officially appointed by a Registration Authority that acts to register things. For example, CrossRef is a registration agency for DOIs relating to documents, while DataCite is a registration agency for DOIs relating to datasets, both acting for the Registration Authority for DOIs, namely the International DOI Foundation (IDF).
    /// <see href="http://purl.org/spar/scoro/registration-agency"></see></summary>
    let ``registration-agency`` =
        Namespaced_IRI.parse _namespace_name "registration-agency" |> NamespacedName

    /// <summary>
    /// The role of an agent with responsibility for registering and maintaining international standards, internet domain names, patents, controlled vocabularies and other similar entities required for reliable international cooperatative activities.  For example, the International DOI Foundation (IDF) is the Registration Authority for DOIs.
    /// <see href="http://purl.org/spar/scoro/registration-authority"></see></summary>
    let ``registration-authority`` =
        Namespaced_IRI.parse _namespace_name "registration-authority" |> NamespacedName

    /// <summary>
    /// The role a person has of being a manager of a repository where entities are given secure long-term storage, typically digital repository for information objects, for example a data repository.
    /// <see href="http://purl.org/spar/scoro/repository-manager"></see></summary>
    let ``repository-manager`` =
        Namespaced_IRI.parse _namespace_name "repository-manager" |> NamespacedName

    /// <summary>
    /// The role a person has of being a research assistant involved in a research investigation.
    /// <see href="http://purl.org/spar/scoro/research-assistant"></see></summary>
    let ``research-assistant`` =
        Namespaced_IRI.parse _namespace_name "research-assistant" |> NamespacedName

    /// <summary>
    /// The role a person has of being a research student, namely someone engaged in research as part of studying for a higher degree at a university or research institute, whose research will be presented in a thesis in part fulfilment of the requirements of that degree.
    /// <see href="http://purl.org/spar/scoro/research-student"></see></summary>
    let ``research-student`` =
        Namespaced_IRI.parse _namespace_name "research-student" |> NamespacedName

    /// <summary>
    /// The role a person has of being a researcher involved in a research investigation, for example by conducting experiments, collecting and analyzing data, or undertaking formal study.
    /// <see href="http://purl.org/spar/scoro/researcher"></see></summary>
    let researcher = Namespaced_IRI.parse _namespace_name "researcher" |> NamespacedName

    /// <summary>
    /// The contribution of critically reviewing and revising drafts of the manuscript of the research paper.
    /// <see href="http://purl.org/spar/scoro/revises-manuscript"></see></summary>
    let ``revises-manuscript`` =
        Namespaced_IRI.parse _namespace_name "revises-manuscript" |> NamespacedName

    /// <summary>
    /// The role held by an agent who holds, owns and manages the legal rights to a project or activity and its products and outcomes, for example the exploitation, licensing and intellectual property rights.
    ///
    /// [See also http://purl.org/spar/scoro/patent-holder and http://purl.org/spar/pro/copyright-owner].
    /// <see href="http://purl.org/spar/scoro/rights-holder"></see></summary>
    let ``rights-holder`` =
        Namespaced_IRI.parse _namespace_name "rights-holder" |> NamespacedName

    /// <summary>
    /// The role of an academic who undertakes scholarly activities, including research investigations.  This role is particularly used to describe endeavours in the arts and humanites that are frequently undertaken without financial support from a particular funded project dedicated to these scholarly activities.
    /// <see href="http://purl.org/spar/scoro/scholar"></see></summary>
    let scholar = Namespaced_IRI.parse _namespace_name "scholar" |> NamespacedName

    /// <summary>
    /// The contribution of securing funding for the research project.
    ///
    /// Note that an individual other than the lead applicant and the co-applicants on a grant application may make contributions to securing funding for a research project, for example by assisting in writing the grant application.
    /// <see href="http://purl.org/spar/scoro/secures-funding"></see></summary>
    let ``secures-funding`` =
        Namespaced_IRI.parse _namespace_name "secures-funding" |> NamespacedName

    /// <summary>
    /// The role an author has of being the senior author of the document.
    /// <see href="http://purl.org/spar/scoro/senior-author"></see></summary>
    let ``senior-author`` =
        Namespaced_IRI.parse _namespace_name "senior-author" |> NamespacedName

    /// <summary>
    /// The role held by a person who services, maintains and repairs equipment, facilities or technical infrastructure.
    /// <see href="http://purl.org/spar/scoro/service-engineer"></see></summary>
    let ``service-engineer`` =
        Namespaced_IRI.parse _namespace_name "service-engineer" |> NamespacedName

    /// <summary>
    /// The contributor was the only person who provided effort in achieving this contribution, which was entirely due to this contributor.
    /// <see href="http://purl.org/spar/scoro/solo-effort"></see></summary>
    let ``solo-effort`` =
        Namespaced_IRI.parse _namespace_name "solo-effort" |> NamespacedName

    /// <summary>
    /// The role held by a person who makes statements on behalf of another individual, a group, a project or an institution
    /// <see href="http://purl.org/spar/scoro/spokesperson"></see></summary>
    let spokesperson =
        Namespaced_IRI.parse _namespace_name "spokesperson" |> NamespacedName

    /// <summary>
    /// The role held by an agent that provides funds or support for a person, project or activity, often in return for access to the exploitable commercial potential associated with that person’s work, or that project or activity’s output, for example through equity sharing or publicity.
    ///
    /// [Note: there are also several other non-financial meaning of 'sponsor'.]
    /// <see href="http://purl.org/spar/scoro/sponsor"></see></summary>
    let sponsor = Namespaced_IRI.parse _namespace_name "sponsor" |> NamespacedName

    /// <summary>
    /// The role held by an agent with an interest or concern in something, for example the creation of a new university.
    /// <see href="http://purl.org/spar/scoro/stakeholder"></see></summary>
    let stakeholder =
        Namespaced_IRI.parse _namespace_name "stakeholder" |> NamespacedName

    /// <summary>
    /// The role held by an agent who enters into a contract to take over part of another contractor's obligation to undertake specified work or supply specified services in return for payment.
    /// <see href="http://purl.org/spar/scoro/sub-contractor"></see></summary>
    let ``sub-contractor`` =
        Namespaced_IRI.parse _namespace_name "sub-contractor" |> NamespacedName

    /// <summary>
    /// The relationship held by an entity that succeeds another, for example a new electron microscope that replaces an out-dated one, a research project that follows on from a preceding project, or a faculty member who succeeds a colleague as head of department.
    /// <see href="http://purl.org/spar/scoro/successor"></see></summary>
    let successor = Namespaced_IRI.parse _namespace_name "successor" |> NamespacedName

    /// <summary>
    /// The contribution of supervising, mentoring, instructing or training colleagues, particularly junior research assistants and research students, in aspects of the research or its methodologies.
    /// <see href="http://purl.org/spar/scoro/supervises-colleagues"></see></summary>
    let ``supervises-colleagues`` =
        Namespaced_IRI.parse _namespace_name "supervises-colleagues" |> NamespacedName

    /// <summary>
    /// The role of a person who guides and oversees the research activities of a team member, or who formally supervises a student during that student's research project undertaken as part of a degree course at a university.
    /// <see href="http://purl.org/spar/scoro/supervisor"></see></summary>
    let supervisor = Namespaced_IRI.parse _namespace_name "supervisor" |> NamespacedName
    /// <summary>
    /// The role held by an agent of providing goods or services in exchange for payment.
    /// <see href="http://purl.org/spar/scoro/supplier"></see></summary>
    let supplier = Namespaced_IRI.parse _namespace_name "supplier" |> NamespacedName
    /// <summary>
    /// The role a person has of being a technician, providing technical assistance in some endeavour such as a research investigation.
    /// <see href="http://purl.org/spar/scoro/technician"></see></summary>
    let technician = Namespaced_IRI.parse _namespace_name "technician" |> NamespacedName

    /// <summary>
    /// The role of a person registerd for an undergraduate degree at a university.
    /// <see href="http://purl.org/spar/scoro/undergraduate-student"></see></summary>
    let ``undergraduate-student`` =
        Namespaced_IRI.parse _namespace_name "undergraduate-student" |> NamespacedName

    /// <summary>
    /// The contribution of design, implementation and analysis of mathematical models or computer simulations.
    /// <see href="http://purl.org/spar/scoro/undertakes-modelling"></see></summary>
    let ``undertakes-modelling`` =
        Namespaced_IRI.parse _namespace_name "undertakes-modelling" |> NamespacedName

    /// <summary>
    /// The role held by the chief executive officer of a university, responsible for directing and managing its business and academic activities.
    /// <see href="http://purl.org/spar/scoro/vice-chancellor"></see></summary>
    let ``vice-chancellor`` =
        Namespaced_IRI.parse _namespace_name "vice-chancellor" |> NamespacedName

    /// <summary>
    /// The role of a person responsible for maintaining a web site and its content.
    /// <see href="http://purl.org/spar/scoro/web-master"></see></summary>
    let ``web-master`` =
        Namespaced_IRI.parse _namespace_name "web-master" |> NamespacedName

    /// <summary>
    /// An object property connecting an agent's contribution with respect to a particular entity to the amount of effort exerted by this agent in making that contribution, defined by individuals of the class scoro:ContributionEffort.
    /// <see href="http://purl.org/spar/scoro/withEffort"></see></summary>
    let withEffort = Namespaced_IRI.parse _namespace_name "withEffort" |> NamespacedName

    /// <summary>
    /// A data property connecting an agent's role in time to a job title that characterizes that role.  This data property complements the definition of that role in time specified by scoro:Role.  For example, for the scoro:OrganizationalRole 'Head of Department', the specific Job Title might be 'Linacre Professor of Zoology' or 'Regius Professor of Moral Philosophy'.
    /// <see href="http://purl.org/spar/scoro/withJobTitle"></see></summary>
    let withJobTitle =
        Namespaced_IRI.parse _namespace_name "withJobTitle" |> NamespacedName

    /// <summary>
    /// The role a person or institution has of being leader for a workpackage or sub-project within a project such as a research project, with responsibility for ensuring that the proposed work is undertaken and documented, the generated data are properly curated and archived, and the results are published and reported to the funding agency.
    /// <see href="http://purl.org/spar/scoro/workpackage-leader"></see></summary>
    let ``workpackage-leader`` =
        Namespaced_IRI.parse _namespace_name "workpackage-leader" |> NamespacedName

    /// <summary>
    /// The contribution of writing the initial draft of the manuscript of the research paper.
    /// <see href="http://purl.org/spar/scoro/writes-manuscript-draft"></see></summary>
    let ``writes-manuscript-draft`` =
        Namespaced_IRI.parse _namespace_name "writes-manuscript-draft" |> NamespacedName
