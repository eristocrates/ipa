namespace http.w3id.org.roh.hash

open DoxAletheia

module roh =
    let _namespace_name = "http://w3id.org/roh#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#PatentExpense"></see>
    /// </summary>
    let PatentExpense = _prefix "PatentExpense"
    /// <summary>
    /// A ProjectExpense is carried out by a Researcher (by default the principal researcher) in charge of a Project, which indirectly links it to Funding, understood as a set of FundingAmounts. The types of expenses considered are: Personnel Expenses, Subcontracting, Travel, Equipment, Research Infrastructure and Other Goods and Services."^^rdfs:Literal
    /// <see href="http://w3id.org/roh#PersonExpense"></see></summary>
    let PersonExpense = _prefix "PersonExpense"
    /// <summary>
    /// A ProjectExpense is carried out by a Researcher (by default the principal researcher) in charge of a Project, which indirectly links it to Funding, understood as a set of FundingAmounts. The types of expenses considered are: Personnel Expenses, Subcontracting, Travel, Equipment, Research Infrastructure and Other Goods and Services.
    /// <see href="http://w3id.org/roh#ProjectExpense"></see></summary>
    let ProjectExpense = _prefix "ProjectExpense"
    /// <summary>
    ///   <see href="http://w3id.org/roh#ResearchObjectExpense"></see>
    /// </summary>
    let ResearchObjectExpense = _prefix "ResearchObjectExpense"
    /// <summary>
    /// A roh:Activity is participated by Persons (roh:participates) and organized by Organizations through roh:hasRole connecting to intermediary entity vivo:OrganizerRole. Each activity is usually linked to a Project through relationship (roh:participates) and causes a ProjectExpense linked through (vivo:relates). A thorough hierarchy of roh:Activity subtypes is defined: bibo:Conference, vivo:Intership, roh:ThesisViva.
    /// <see href="http://w3id.org/roh#Activity"></see></summary>
    let Activity = _prefix "Activity"
    /// <summary>
    ///   <see href="http://w3id.org/roh#ExperimentalProtocol"></see>
    /// </summary>
    let ExperimentalProtocol = _prefix "ExperimentalProtocol"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Repository"></see>
    /// </summary>
    let Repository = _prefix "Repository"
    /// <summary>
    ///   <see href="http://w3id.org/roh#ResearchContribution"></see>
    /// </summary>
    let ResearchContribution = _prefix "ResearchContribution"
    /// <summary>
    ///   <see href="http://w3id.org/roh#ResearchMethod"></see>
    /// </summary>
    let ResearchMethod = _prefix "ResearchMethod"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Invoice"></see>
    /// </summary>
    let Invoice = _prefix "Invoice"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Award"></see>
    /// </summary>
    let Award = _prefix "Award"
    /// <summary>
    ///   <see href="http://w3id.org/roh#CourseCertificate"></see>
    /// </summary>
    let CourseCertificate = _prefix "CourseCertificate"
    /// <summary>
    /// A language certificate from the Common European Framework of Reference for Languages: Learning, Teaching, Assessment.
    /// <see href="http://w3id.org/roh#LanguageCertificate"></see></summary>
    let LanguageCertificate = _prefix "LanguageCertificate"
    /// <summary>
    ///   <see href="http://w3id.org/roh#AuditeeRole"></see>
    /// </summary>
    let AuditeeRole = _prefix "AuditeeRole"
    /// <summary>
    ///   <see href="http://w3id.org/roh#AuditorRole"></see>
    /// </summary>
    let AuditorRole = _prefix "AuditorRole"
    /// <summary>
    /// A member who works in a Project or participates in an Activity but do not belong to the main Organization.
    /// <see href="http://w3id.org/roh#ExternalMemberRole"></see></summary>
    let ExternalMemberRole = _prefix "ExternalMemberRole"
    /// <summary>
    ///   <see href="http://w3id.org/roh#ReservableConsumerRole"></see>
    /// </summary>
    let ReservableConsumerRole = _prefix "ReservableConsumerRole"
    /// <summary>
    ///   <see href="http://w3id.org/roh#ReservableProviderRole"></see>
    /// </summary>
    let ReservableProviderRole = _prefix "ReservableProviderRole"
    /// <summary>
    ///   <see href="http://w3id.org/roh#SuperviseeRole"></see>
    /// </summary>
    let SuperviseeRole = _prefix "SuperviseeRole"
    /// <summary>
    ///   <see href="http://w3id.org/roh#SupervisorRole"></see>
    /// </summary>
    let SupervisorRole = _prefix "SupervisorRole"
    /// <summary>
    /// A role of contracting someone to perform a job.
    /// <see href="http://w3id.org/roh#ThirdPartyContractorRole"></see></summary>
    let ThirdPartyContractorRole = _prefix "ThirdPartyContractorRole"
    /// <summary>
    /// An attestation of qualification, competence, or authority issued to an individual by a third party with a relevant or  de facto authority or assumed competence to do so in the academic field.
    /// <see href="http://w3id.org/roh#AcademicAccreditation"></see></summary>
    let AcademicAccreditation = _prefix "AcademicAccreditation"
    /// <summary>
    ///   <see href="http://w3id.org/roh#DegreeHomologation"></see>
    /// </summary>
    let DegreeHomologation = _prefix "DegreeHomologation"
    /// <summary>
    /// An attestation of qualification, competence, or authority issued to an individual by a third party with a relevant or  de facto authority or assumed competence to do so in the research field.
    /// <see href="http://w3id.org/roh#ResearchAccreditation"></see></summary>
    let ResearchAccreditation = _prefix "ResearchAccreditation"
    /// <summary>
    ///   <see href="http://w3id.org/roh#AcademicSubject"></see>
    /// </summary>
    let AcademicSubject = _prefix "AcademicSubject"
    /// <summary>
    ///   <see href="http://w3id.org/roh#CompanyClassification"></see>
    /// </summary>
    let CompanyClassification = _prefix "CompanyClassification"
    /// <summary>
    /// A region legally identified as a distinct entity in political geography.
    /// <see href="http://w3id.org/roh#Country"></see></summary>
    let Country = _prefix "Country"
    /// <summary>
    ///   <see href="http://w3id.org/roh#ExpenseClassification"></see>
    /// </summary>
    let ExpenseClassification = _prefix "ExpenseClassification"
    /// <summary>
    ///   <see href="http://w3id.org/roh#FundingProgramClassification"></see>
    /// </summary>
    let FundingProgramClassification = _prefix "FundingProgramClassification"
    /// <summary>
    ///   <see href="http://w3id.org/roh#HRClassification"></see>
    /// </summary>
    let HRClassification = _prefix "HRClassification"
    /// <summary>
    /// ROH will be populated with instance data of UNESCO skos concepts. A Person, Activity, Project and Organization can be qualified by a KnowledgeArea
    /// <see href="http://w3id.org/roh#KnowledgeArea"></see></summary>
    let KnowledgeArea = _prefix "KnowledgeArea"
    /// <summary>
    ///   <see href="http://w3id.org/roh#ProjectClassification"></see>
    /// </summary>
    let ProjectClassification = _prefix "ProjectClassification"
    /// <summary>
    ///   <see href="http://w3id.org/roh#PropertyClassification"></see>
    /// </summary>
    let PropertyClassification = _prefix "PropertyClassification"
    /// <summary>
    ///   <see href="http://w3id.org/roh#ResearchProblem"></see>
    /// </summary>
    let ResearchProblem = _prefix "ResearchProblem"
    /// <summary>
    ///   <see href="http://w3id.org/roh#AuthorMetric"></see>
    /// </summary>
    let AuthorMetric = _prefix "AuthorMetric"
    /// <summary>
    ///   <see href="http://w3id.org/roh#DegreeMetric"></see>
    /// </summary>
    let DegreeMetric = _prefix "DegreeMetric"
    /// <summary>
    /// An article is cited roh:citationCount times in the roh:metricName network. Example: if an article is cited 5 times in the Web of Science, then the roh:metricName should be Web of Science and the roh:citationCount 5. Thus, a roh:metricName can be roh and the value of roh:citationCount the number of times that article has been cited in the knowledge graph of this ontology.
    /// <see href="http://w3id.org/roh#PublicationMetric"></see></summary>
    let PublicationMetric = _prefix "PublicationMetric"
    /// <summary>
    ///   <see href="http://w3id.org/roh#ResearchGroupMetric"></see>
    /// </summary>
    let ResearchGroupMetric = _prefix "ResearchGroupMetric"
    /// <summary>
    /// An evaluation summary provided by a funding organization.
    /// <see href="http://w3id.org/roh#EvaluationSummary"></see></summary>
    let EvaluationSummary = _prefix "EvaluationSummary"
    /// <summary>
    /// A Justification is a bibo:Report used to justify eithet technically, economically or both a project.
    /// <see href="http://w3id.org/roh#Justification"></see></summary>
    let Justification = _prefix "Justification"
    /// <summary>
    /// An undergraduate academic degree awarded by colleges and universities upon completion of a course of study lasting three to four years (depending on institution and academic discipline).
    /// <see href="http://w3id.org/roh#BachelorsDegree"></see></summary>
    let BachelorsDegree = _prefix "BachelorsDegree"
    /// <summary>
    ///   <see href="http://w3id.org/roh#DoctoralDegree"></see>
    /// </summary>
    let DoctoralDegree = _prefix "DoctoralDegree"
    /// <summary>
    ///   <see href="http://w3id.org/roh#MastersDegree"></see>
    /// </summary>
    let MastersDegree = _prefix "MastersDegree"
    /// <summary>
    /// An Accreditation models research and academic position accreditations. Qualification goes beyond Accreditation because it also refers to degrees and other qualifications a person may have.  Accreditation has an important data property which is dateIssued which links Accreditation with vivo:DataTimeValue
    /// <see href="http://w3id.org/roh#Accreditation"></see></summary>
    let Accreditation = _prefix "Accreditation"
    /// <summary>
    /// A roh:Expense is carried out in a vivo:Project or by foaf:Person and associated through relationship roh:spends. It timestamps each expense with a vivo:DateTimeValue and has attributes roh:monetaryAmount, roh:currency, roh:title and roh:description and expenseAmount . The types of expenses considered are: Personnel Expenses, Subcontracting, Travel, Equipment, Research Infrastructure and Other Goods and Services. Some of these classes still not defined.
    /// <see href="http://w3id.org/roh#Expense"></see></summary>
    let Expense = _prefix "Expense"
    /// <summary>
    /// A roh:Funding is the funding associated to a vivo:Project whose funding is associated to a roh:FundingProgram, which in turn is associated to a vivo:FundingOrganization. A roh:Funding consists of several roh:FundingAmounts, associated to the different entities that participate in a project and to the annuities in which they do it.  Funding gathers information about the total funding received for a Project and its currency through properties roh:monetaryAmount and roh:currency. A roh:FundingSource funds a roh:FundingProgram. A roh:Funding supports a vivo:Project or a roh:PersonContract. A Funding can be tagged as public or private, by updating the data property roh:publicFunding.
    /// <see href="http://w3id.org/roh#Funding"></see></summary>
    let Funding = _prefix "Funding"
    /// <summary>
    /// A roh:FundingAmount is linked to a roh:Funding which is roh:fundedBy a roh:FundingProgram and finances a Project (through roh:supports relationship). Each FundingAmount is associated to an Organization participating in the Project (through roh:grants relationship) for each project specific annuity.
    /// <see href="http://w3id.org/roh#FundingAmount"></see></summary>
    let FundingAmount = _prefix "FundingAmount"
    /// <summary>
    /// A roh:FundingProgram is promoted (roh:promotedBy) by a Funding Organization (vivo:FundingOrganization) and it is in place for a time interval (vivo:dateTimeInterval)
    /// A programme of related funded projects, typically established by a funding organization.
    /// <see href="http://w3id.org/roh#FundingProgram"></see></summary>
    let FundingProgram = _prefix "FundingProgram"
    /// <summary>
    /// We have just considered a subset of the available funding sources, taking into account the sample datasets provided by University of Murcia
    ///
    /// A roh:FundingSource roh:feeds a roh:Funding with funds to sponsor some projects.
    /// <see href="http://w3id.org/roh#FundingSource"></see></summary>
    let FundingSource = _prefix "FundingSource"
    /// <summary>
    /// Invention
    /// A new device, method, or process developed from study and experimentation in the framework of research.
    /// <see href="http://w3id.org/roh#Invention"></see></summary>
    let Invention = _prefix "Invention"
    /// <summary>
    /// An roh:Metric indicates qualifies a roh:ResearchObject according to common established quality measurement metrics, e.g. impact factor or mark in an PhD viva.
    /// <see href="http://w3id.org/roh#Metric"></see></summary>
    let Metric = _prefix "Metric"
    /// <summary>
    /// A product as outcome of a project.
    /// <see href="http://w3id.org/roh#Product"></see></summary>
    let Product = _prefix "Product"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Status"></see>
    /// </summary>
    let Status = _prefix "Status"
    /// <summary>
    ///   <see href="http://w3id.org/roh#LargeEnterprise"></see>
    /// </summary>
    let LargeEnterprise = _prefix "LargeEnterprise"
    /// <summary>
    /// An enterprise which employ fewer than 250 persons and which have an annual turnover not exceeding EUR 50 million, and/or an annual balance sheet total not exceeding EUR 43 million.
    /// <see href="http://w3id.org/roh#MediumEnterprise"></see></summary>
    let MediumEnterprise = _prefix "MediumEnterprise"
    /// <summary>
    /// An enterprise which employs fewer than 10 persons and whose annual turnover and/or annual balance sheet total does not exceed EUR 2 million.
    /// <see href="http://w3id.org/roh#MicroEnterprise"></see></summary>
    let MicroEnterprise = _prefix "MicroEnterprise"
    /// <summary>
    /// An enterprise which employs fewer than 50 persons and whose annual turnover and/or annual balance sheet total does not exceed EUR 10 million.
    /// <see href="http://w3id.org/roh#SmallEnterprise"></see></summary>
    let SmallEnterprise = _prefix "SmallEnterprise"
    /// <summary>
    /// A document created to summarize research findings associated with the completion of an academic degree.
    /// A thesis reporting a research project undertaken as part of an undergraduate course of education to receive a bachelor's degree.
    /// <see href="http://w3id.org/roh#BachelorsThesis"></see></summary>
    let BachelorsThesis = _prefix "BachelorsThesis"
    /// <summary>
    /// A thesis reporting a research project undertaken as part of a second-cycle course of education to receive a master's degree.
    /// A document created to summarize research findings associated with the completion of a master's degree.
    /// <see href="http://w3id.org/roh#MastersThesis"></see></summary>
    let MastersThesis = _prefix "MastersThesis"
    /// <summary>
    /// A thesis reporting a research project undertaken as part of an undergraduate course of education to receive a doctoral degree.
    /// A document created to summarize research findings associated with the completion of a doctoral thesis.
    /// <see href="http://w3id.org/roh#PhDThesis"></see></summary>
    let PhDThesis = _prefix "PhDThesis"
    /// <summary>
    ///   <see href="http://w3id.org/roh#AuditingRelationship"></see>
    /// </summary>
    let AuditingRelationship = _prefix "AuditingRelationship"
    /// <summary>
    ///   <see href="http://w3id.org/roh#SupervisingRelationship"></see>
    /// </summary>
    let SupervisingRelationship = _prefix "SupervisingRelationship"
    /// <summary>
    /// An ethics committee is a body responsible for ensuring that medical experimentation and human subject research are carried out in an ethical manner in accordance with national and international law.
    /// <see href="http://w3id.org/roh#EthicsCommittee"></see></summary>
    let EthicsCommittee = _prefix "EthicsCommittee"
    /// <summary>
    /// A group of researchers often from the same centre, specialised on the same subject, working together on the issue or topic.
    /// <see href="http://w3id.org/roh#ResearchGroup"></see></summary>
    let ResearchGroup = _prefix "ResearchGroup"
    /// <summary>
    /// A financial award provided by a funding organisation for a particular project or purpose, usually awarded on the basis of a competitive application.
    /// An amount of money given especially by the government to a person or organization for a special purpose.
    /// <see href="http://w3id.org/roh#Grant"></see></summary>
    let Grant = _prefix "Grant"
    /// <summary>
    /// An amount of money that is borrowed, often from a bank or a funding organization, and has to be paid back, usually together with an extra amount of money that you have to pay as a charge for borrowing.
    /// <see href="http://w3id.org/roh#Loan"></see></summary>
    let Loan = _prefix "Loan"
    /// <summary>
    /// The process of paying to have part of a company's work done by another company.
    /// <see href="http://w3id.org/roh#Outsourcing"></see></summary>
    let Outsourcing = _prefix "Outsourcing"
    /// <summary>
    ///   <see href="http://w3id.org/roh#RefundableAdvance"></see>
    /// </summary>
    let RefundableAdvance = _prefix "RefundableAdvance"
    /// <summary>
    /// An oral examination in which a PhD Student defends her/his doctoral thesis.
    /// <see href="http://w3id.org/roh#ThesisViva"></see></summary>
    let ThesisViva = _prefix "ThesisViva"
    /// <summary>
    ///   <see href="http://w3id.org/roh#PatentContract"></see>
    /// </summary>
    let PatentContract = _prefix "PatentContract"
    /// <summary>
    /// An agreement between a person and an organization to work in a project for a specified duration.
    /// <see href="http://w3id.org/roh#PersonContract"></see></summary>
    let PersonContract = _prefix "PersonContract"
    /// <summary>
    /// An agreement among different organizations to work in a project for a specified duration.
    /// <see href="http://w3id.org/roh#ProjectContract"></see></summary>
    let ProjectContract = _prefix "ProjectContract"
    /// <summary>
    ///   <see href="http://w3id.org/roh#BachelorsSupervisingRelationship"></see>
    /// </summary>
    let BachelorsSupervisingRelationship = _prefix "BachelorsSupervisingRelationship"
    /// <summary>
    ///   <see href="http://w3id.org/roh#MastersSupervisingRelationship"></see>
    /// </summary>
    let MastersSupervisingRelationship = _prefix "MastersSupervisingRelationship"
    /// <summary>
    ///   <see href="http://w3id.org/roh#PhDSupervisingRelationship"></see>
    /// </summary>
    let PhDSupervisingRelationship = _prefix "PhDSupervisingRelationship"
    /// <summary>
    ///   <see href="http://w3id.org/roh#BlogPost"></see>
    /// </summary>
    let BlogPost = _prefix "BlogPost"
    /// <summary>
    ///   <see href="http://w3id.org/roh#PressArticle"></see>
    /// </summary>
    let PressArticle = _prefix "PressArticle"
    /// <summary>
    ///   <see href="http://w3id.org/roh#EthicalReport"></see>
    /// </summary>
    let EthicalReport = _prefix "EthicalReport"
    /// <summary>
    /// A member of a university or research organization focused on research task further than other ones.
    /// <see href="http://w3id.org/roh#ResearcherPosition"></see></summary>
    let ResearcherPosition = _prefix "ResearcherPosition"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Accepted"></see>
    /// </summary>
    let Accepted = _prefix "Accepted"
    /// <summary>
    /// Some entity related to any Concept.
    /// <see href="http://w3id.org/roh#hasKnowledgeArea"></see></summary>
    let hasKnowledgeArea = _prefix "hasKnowledgeArea"
    /// <summary>
    /// A data property that associates a title to any ROH entity requiring it.
    /// <see href="http://w3id.org/roh#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// An organization with a relevant or de facto authority or assumed competence to issue research or academic accreditations.
    /// <see href="http://w3id.org/roh#AccreditationIssuer"></see></summary>
    let AccreditationIssuer = _prefix "AccreditationIssuer"
    /// <summary>
    /// An Accreditation Issuer which issues an Accreditation.
    /// <see href="http://w3id.org/roh#issues"></see></summary>
    let issues = _prefix "issues"
    /// <summary>
    /// An Activity participated by an Entity.
    /// <see href="http://w3id.org/roh#participatedBy"></see></summary>
    let participatedBy = _prefix "participatedBy"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Administrative"></see>
    /// </summary>
    let Administrative = _prefix "Administrative"
    /// <summary>
    /// This vertical module in ASIO models all the relevant administrative bodies ("Administración Autonómica") of Spain's Autonomous Communities (conserjerías, departamentos, secretarías) that might have a role (funding, participating) within the development of a given project. It is modeled hierarchically through the relevant administrative levels thereof.
    /// <see href="http://w3id.org/roh#AdministrativeEntity"></see></summary>
    let AdministrativeEntity = _prefix "AdministrativeEntity"
    /// <summary>
    /// relates a Metric to the entity it describes
    /// <see href="http://w3id.org/roh#metricOf"></see></summary>
    let metricOf = _prefix "metricOf"
    /// <summary>
    /// the number of times a publication has been cited (when used in PublicationMetric) or the total number of citations for all of an author's works (when used in AuthorMetric)
    /// <see href="http://w3id.org/roh#citationCount"></see></summary>
    let citationCount = _prefix "citationCount"
    /// <summary>
    ///   <see href="http://w3id.org/roh#h-index"></see>
    /// </summary>
    let ``h-index`` = _prefix "h-index"
    /// <summary>
    /// A property to express the i10-index of an author.
    /// <see href="http://w3id.org/roh#i10-index"></see></summary>
    let ``i10-index`` = _prefix "i10-index"
    /// <summary>
    ///   <see href="http://w3id.org/roh#BachelorsDegreeSubject"></see>
    /// </summary>
    let BachelorsDegreeSubject = _prefix "BachelorsDegreeSubject"
    /// <summary>
    /// Some Thing producing some entity.
    /// <see href="http://w3id.org/roh#produces"></see></summary>
    let produces = _prefix "produces"
    /// <summary>
    /// This entity defines a BitBucket Repository (https://bitbucket.org).
    /// <see href="http://w3id.org/roh#BitBucketRepository"></see></summary>
    let BitBucketRepository = _prefix "BitBucketRepository"
    /// <summary>
    ///   <see href="http://w3id.org/roh#hasPredecessor"></see>
    /// </summary>
    let hasPredecessor = _prefix "hasPredecessor"
    /// <summary>
    /// An object property linking a CV to the person it belongs to.
    /// <see href="http://w3id.org/roh#CVOf"></see></summary>
    let CVOf = _prefix "CVOf"
    /// <summary>
    /// roh:CurriculumVitae adds extra fields necessary to be able to complete the CV of a foaf:Person which cannot be extracted from the relationships with roh:ResearchObject and vivo:Project, among others, that a foaf:Person may have.
    /// A document used and created by a person to present their background, skills and accomplishments.
    /// <see href="http://w3id.org/roh#CurriculumVitae"></see></summary>
    let CurriculumVitae = _prefix "CurriculumVitae"
    /// <summary>
    /// An object property linking a Person with her CV.
    /// <see href="http://w3id.org/roh#hasCV"></see></summary>
    let hasCV = _prefix "hasCV"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Cancelled"></see>
    /// </summary>
    let Cancelled = _prefix "Cancelled"
    /// <summary>
    /// A qualitative descriptive research study of individuals or a group.
    /// <see href="http://w3id.org/roh#CaseStudy"></see></summary>
    let CaseStudy = _prefix "CaseStudy"
    /// <summary>
    /// A list of items in a collection; an ordered compilation of item descriptions and sufficient information to afford access to them.
    /// <see href="http://w3id.org/roh#Catalog"></see></summary>
    let Catalog = _prefix "Catalog"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Closed"></see>
    /// </summary>
    let Closed = _prefix "Closed"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Contest"></see>
    /// </summary>
    let Contest = _prefix "Contest"
    /// <summary>
    /// A textual summary of the Curriculum Vitae
    /// <see href="http://w3id.org/roh#summary"></see></summary>
    let summary = _prefix "summary"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Database"></see>
    /// </summary>
    let Database = _prefix "Database"
    /// <summary>
    ///   <see href="http://w3id.org/roh#DisseminationEvent"></see>
    /// </summary>
    let DisseminationEvent = _prefix "DisseminationEvent"
    /// <summary>
    /// File is a collection in which all assets related to a Project are stored, including the Research Proposal, approval documents, viability plans and so on associated to a project are stored.
    /// <see href="http://w3id.org/roh#Dossier"></see></summary>
    let Dossier = _prefix "Dossier"
    /// <summary>
    ///   <see href="http://w3id.org/roh#EditedPublication"></see>
    /// </summary>
    let EditedPublication = _prefix "EditedPublication"
    /// <summary>
    ///   <see href="http://w3id.org/roh#EthicalAudit"></see>
    /// </summary>
    let EthicalAudit = _prefix "EthicalAudit"
    /// <summary>
    ///   <see href="http://w3id.org/roh#EthicalValidation"></see>
    /// </summary>
    let EthicalValidation = _prefix "EthicalValidation"
    /// <summary>
    /// The status of a Document (Accepted or Rejected).
    /// <see href="http://w3id.org/roh#documentStatus"></see></summary>
    let documentStatus = _prefix "documentStatus"
    /// <summary>
    /// A fund allocated by the European Union. It finances direct payments to farmers under the Common Agricultural Policy (CAP) and measures to regulate agricultural markets such as intervention and export refunds.
    /// <see href="http://w3id.org/roh#EuropeanAgriculturalGuaranteeFund"></see></summary>
    let EuropeanAgriculturalGuaranteeFund = _prefix "EuropeanAgriculturalGuaranteeFund"
    /// <summary>
    /// The EMFF is the fund for the EU's maritime and fisheries policies for 2014-2020.
    /// <see href="http://w3id.org/roh#EuropeanMaritimeAndFisheriesFund"></see></summary>
    let EuropeanMaritimeAndFisheriesFund = _prefix "EuropeanMaritimeAndFisheriesFund"
    /// <summary>
    /// A fund allocated by the European Union. Its purpose is to transfer money from richer regions (not countries), and invest it in the infrastructure and services of underdeveloped regions. This will allow those regions to start attracting private sector investments, and create jobs on their own.
    /// <see href="http://w3id.org/roh#EuropeanRegionalDevelopmentFund"></see></summary>
    let EuropeanRegionalDevelopmentFund = _prefix "EuropeanRegionalDevelopmentFund"
    /// <summary>
    /// It is one of the European Structural and Investment Funds (ESIF), which are dedicated to improving social cohesion and economic well-being across the regions of the Union. The funds are redistributive financial instruments that support cohesion within Europe by concentrating spending on the less-developed regions.
    /// <see href="http://w3id.org/roh#EuropeanSocialFund"></see></summary>
    let EuropeanSocialFund = _prefix "EuropeanSocialFund"
    /// <summary>
    /// The status in which a Evaluation Summary could be.
    /// <see href="http://w3id.org/roh#evaluationStatus"></see></summary>
    let evaluationStatus = _prefix "evaluationStatus"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Final"></see>
    /// </summary>
    let Final = _prefix "Final"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Provisional"></see>
    /// </summary>
    let Provisional = _prefix "Provisional"
    /// <summary>
    /// A role of organising cientific events, such as conferences, workshops, etc.
    /// <see href="http://w3id.org/roh#EventOrganiser"></see></summary>
    let EventOrganiser = _prefix "EventOrganiser"
    /// <summary>
    /// Data property used by roh:Funding and roh:FundingAmount
    /// <see href="http://w3id.org/roh#currency"></see></summary>
    let currency = _prefix "currency"
    /// <summary>
    /// Data property used by roh:Funding and roh:FundingAmount
    /// <see href="http://w3id.org/roh#monetaryAmount"></see></summary>
    let monetaryAmount = _prefix "monetaryAmount"
    /// <summary>
    ///   <see href="http://w3id.org/roh#hasExpenseClassification"></see>
    /// </summary>
    let hasExpenseClassification = _prefix "hasExpenseClassification"
    /// <summary>
    /// A free text property to represent the modality of an Expense.
    /// <see href="http://w3id.org/roh#expenseModality"></see></summary>
    let expenseModality = _prefix "expenseModality"
    /// <summary>
    /// A core relation that holds between a whole, that in this case is an Repository, and its part .
    /// <see href="http://w3id.org/roh#repositoryHasPart"></see></summary>
    let repositoryHasPart = _prefix "repositoryHasPart"
    /// <summary>
    /// Document that contains the result or execution of a Experimental Protocol.
    /// <see href="http://w3id.org/roh#ExperimentalProtocolResult"></see></summary>
    let ExperimentalProtocolResult = _prefix "ExperimentalProtocolResult"
    /// <summary>
    ///   <see href="http://w3id.org/roh#language"></see>
    /// </summary>
    let language = _prefix "language"
    /// <summary>
    /// An object property linking an Entity to a Person, considered the author of such Thing.
    /// <see href="http://w3id.org/roh#correspondingAuthor"></see></summary>
    let correspondingAuthor = _prefix "correspondingAuthor"
    /// <summary>
    /// An unordered list of authors.
    /// <see href="http://w3id.org/roh#seqOfAuthors"></see></summary>
    let seqOfAuthors = _prefix "seqOfAuthors"
    /// <summary>
    ///   <see href="http://w3id.org/roh#partOfResearchResult"></see>
    /// </summary>
    let partOfResearchResult = _prefix "partOfResearchResult"
    /// <summary>
    ///   <see href="http://w3id.org/roh#ResearchResult"></see>
    /// </summary>
    let ResearchResult = _prefix "ResearchResult"
    /// <summary>
    /// A retired professor who has retained their rank, title and privileges.
    /// <see href="http://w3id.org/roh#FacultyPositionEmeritus"></see></summary>
    let FacultyPositionEmeritus = _prefix "FacultyPositionEmeritus"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Funded"></see>
    /// </summary>
    let Funded = _prefix "Funded"
    /// <summary>
    /// An object property linking a Thing when is funded by another Thing.
    /// <see href="http://w3id.org/roh#fundedBy"></see></summary>
    let fundedBy = _prefix "fundedBy"
    /// <summary>
    /// To tag something as public (true) or private (false)
    /// <see href="http://w3id.org/roh#publicFunding"></see></summary>
    let publicFunding = _prefix "publicFunding"
    /// <summary>
    /// An object property linking an Entity to a Contract.
    /// <see href="http://w3id.org/roh#hasContract"></see></summary>
    let hasContract = _prefix "hasContract"
    /// <summary>
    /// An object property linking a FundingAmount with an Organization.
    /// <see href="http://w3id.org/roh#grants"></see></summary>
    let grants = _prefix "grants"
    /// <summary>
    /// A Funding Program or Funding Source promoted by a Funding Organization.
    /// <see href="http://w3id.org/roh#promotedBy"></see></summary>
    let promotedBy = _prefix "promotedBy"
    /// <summary>
    ///   <see href="http://w3id.org/roh#hasFundingProgramClassification"></see>
    /// </summary>
    let hasFundingProgramClassification = _prefix "hasFundingProgramClassification"
    /// <summary>
    /// An object property linking a Thing when it funds another Thing.
    /// <see href="http://w3id.org/roh#funds"></see></summary>
    let funds = _prefix "funds"
    /// <summary>
    /// It's a concrete Repository that is stored in https://github.com.
    /// <see href="http://w3id.org/roh#GitHubRepository"></see></summary>
    let GitHubRepository = _prefix "GitHubRepository"
    /// <summary>
    /// A Project supported by a Funding.
    /// <see href="http://w3id.org/roh#isSupportedBy"></see></summary>
    let isSupportedBy = _prefix "isSupportedBy"
    /// <summary>
    ///   <see href="http://w3id.org/roh#patentStatus"></see>
    /// </summary>
    let patentStatus = _prefix "patentStatus"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Rejected"></see>
    /// </summary>
    let Rejected = _prefix "Rejected"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Submitted"></see>
    /// </summary>
    let Submitted = _prefix "Submitted"
    /// <summary>
    /// A roh:ResearchObject is generated by one to several foaf:Person specified through property bibo:authorList. Usually a roh:ResearchObject results from the work in a vivo:Project (roh:produces). An elaborated taxonomy of research objects is provided, covering all types of publications, Patents, Software and Webpage. The main author of a research object is accessible through property roh:correspondingAuthor.
    /// <see href="http://w3id.org/roh#ResearchObject"></see></summary>
    let ResearchObject = _prefix "ResearchObject"
    /// <summary>
    ///   <see href="http://w3id.org/roh#hasPropertyClassification"></see>
    /// </summary>
    let hasPropertyClassification = _prefix "hasPropertyClassification"
    /// <summary>
    /// An entity spending an Expense.
    /// <see href="http://w3id.org/roh#spends"></see></summary>
    let spends = _prefix "spends"
    /// <summary>
    ///   <see href="http://w3id.org/roh#PatentApplication"></see>
    /// </summary>
    let PatentApplication = _prefix "PatentApplication"
    /// <summary>
    /// This is the metric of a jorunal. When the journal metric is updated, a new journal metric must be created with the same impactFactorName but with the updated impactFactor, ranking and quartile values.
    /// <see href="http://w3id.org/roh#JournalMetric"></see></summary>
    let JournalMetric = _prefix "JournalMetric"
    /// <summary>
    /// A scientometric index that reflects the yearly average number of citations that articles published in the last two years in a given journal received.
    /// <see href="http://w3id.org/roh#impactFactor"></see></summary>
    let impactFactor = _prefix "impactFactor"
    /// <summary>
    /// The ranking of a scientific publication.
    /// <see href="http://w3id.org/roh#ranking"></see></summary>
    let ranking = _prefix "ranking"
    /// <summary>
    ///   <see href="http://w3id.org/roh#impactFactorName"></see>
    /// </summary>
    let impactFactorName = _prefix "impactFactorName"
    /// <summary>
    /// The quartile to which a Journal publication belongs.
    /// <see href="http://w3id.org/roh#quartile"></see></summary>
    let quartile = _prefix "quartile"
    /// <summary>
    /// The ability to understand spoken language.
    /// <see href="http://w3id.org/roh#listeningSkill"></see></summary>
    let listeningSkill = _prefix "listeningSkill"
    /// <summary>
    /// The ability to write into a certain language.
    /// <see href="http://w3id.org/roh#writingSkill"></see></summary>
    let writingSkill = _prefix "writingSkill"
    /// <summary>
    /// The ability to participate into a conversation.
    /// <see href="http://w3id.org/roh#spokenInteractionSkill"></see></summary>
    let spokenInteractionSkill = _prefix "spokenInteractionSkill"
    /// <summary>
    /// The ability to understand written text.
    /// <see href="http://w3id.org/roh#readingSkill"></see></summary>
    let readingSkill = _prefix "readingSkill"
    /// <summary>
    /// The language to which refers the Language Certificate.
    /// <see href="http://w3id.org/roh#languageOfTheCertificate"></see></summary>
    let languageOfTheCertificate = _prefix "languageOfTheCertificate"
    /// <summary>
    /// The ability to speak a language.
    /// <see href="http://w3id.org/roh#speakingSkill"></see></summary>
    let speakingSkill = _prefix "speakingSkill"
    /// <summary>
    /// A retired librarian who has retained their rank, title and privileges.
    /// <see href="http://w3id.org/roh#LibrarianPositionEmeritus"></see></summary>
    let LibrarianPositionEmeritus = _prefix "LibrarianPositionEmeritus"
    /// <summary>
    ///   <see href="http://w3id.org/roh#ManagementUnit"></see>
    /// </summary>
    let ManagementUnit = _prefix "ManagementUnit"
    /// <summary>
    ///   <see href="http://w3id.org/roh#MastersDegreeSubject"></see>
    /// </summary>
    let MastersDegreeSubject = _prefix "MastersDegreeSubject"
    /// <summary>
    ///   <see href="http://w3id.org/roh#MastersStudent"></see>
    /// </summary>
    let MastersStudent = _prefix "MastersStudent"
    /// <summary>
    /// The name of a Metric.
    /// <see href="http://w3id.org/roh#metricName"></see></summary>
    let metricName = _prefix "metricName"
    /// <summary>
    ///   <see href="http://w3id.org/roh#ORCID"></see>
    /// </summary>
    let ORCID = _prefix "ORCID"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Open"></see>
    /// </summary>
    let Open = _prefix "Open"
    /// <summary>
    /// A group of people gathered to discuss a topic in front of an audience, typically at scientific, business, or academic conferences, fan conventions, and on television shows. Panels usually include a moderator who guides the discussion and sometimes elicits audience questions, with the goal of being informative and entertaining
    /// <see href="http://w3id.org/roh#PanelTalk"></see></summary>
    let PanelTalk = _prefix "PanelTalk"
    /// <summary>
    /// A Patent has an Organization who owns it.
    /// <see href="http://w3id.org/roh#ownerOrganization"></see></summary>
    let ownerOrganization = _prefix "ownerOrganization"
    /// <summary>
    /// The position a person has inside its organization.
    /// <see href="http://w3id.org/roh#hasHRClassification"></see></summary>
    let hasHRClassification = _prefix "hasHRClassification"
    /// <summary>
    ///   <see href="http://w3id.org/roh#PhDThesisMetric"></see>
    /// </summary>
    let PhDThesisMetric = _prefix "PhDThesisMetric"
    /// <summary>
    /// Meaning "with praise", used to indicate the level of distinction with which an academic degree has been earned.
    /// <see href="http://w3id.org/roh#cumLaude"></see></summary>
    let cumLaude = _prefix "cumLaude"
    /// <summary>
    /// A judgment, expressed as a number or letter, about the quality of a work.
    /// <see href="http://w3id.org/roh#mark"></see></summary>
    let mark = _prefix "mark"
    /// <summary>
    ///   <see href="http://w3id.org/roh#ThesisMetric"></see>
    /// </summary>
    let ThesisMetric = _prefix "ThesisMetric"
    /// <summary>
    ///   <see href="http://w3id.org/roh#ProformaInvoice"></see>
    /// </summary>
    let ProformaInvoice = _prefix "ProformaInvoice"
    /// <summary>
    ///   <see href="http://w3id.org/roh#ProposalSubmitted"></see>
    /// </summary>
    let ProposalSubmitted = _prefix "ProposalSubmitted"
    /// <summary>
    /// A product prototype
    /// <see href="http://w3id.org/roh#Prototype"></see></summary>
    let Prototype = _prefix "Prototype"
    /// <summary>
    /// The document named README that describe the content of a concret Repository.
    /// <see href="http://w3id.org/roh#README"></see></summary>
    let README = _prefix "README"
    /// <summary>
    /// This object property is used to specify the Repository or Software of a given README document.
    /// <see href="http://w3id.org/roh#readmeOf"></see></summary>
    let readmeOf = _prefix "readmeOf"
    /// <summary>
    ///   <see href="http://w3id.org/roh#RadioProgram"></see>
    /// </summary>
    let RadioProgram = _prefix "RadioProgram"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TvProgram"></see>
    /// </summary>
    let TvProgram = _prefix "TvProgram"
    /// <summary>
    ///   <see href="http://w3id.org/roh#repositoryStatus"></see>
    /// </summary>
    let repositoryStatus = _prefix "repositoryStatus"
    /// <summary>
    /// This object property is used to specify the README document of a given  Respository or Software.
    /// <see href="http://w3id.org/roh#hasReadme"></see></summary>
    let hasReadme = _prefix "hasReadme"
    /// <summary>
    /// Esta propiedad nos permite especificar la licencia (vivo:License) de una instancia.
    /// This object property is used to specify the licence (vivo:License) of a given instance.
    /// <see href="http://w3id.org/roh#hasLicense"></see></summary>
    let hasLicense = _prefix "hasLicense"
    /// <summary>
    /// Represents if an Entity has an excellence label or some kind of mention.
    /// <see href="http://w3id.org/roh#excellenceLabel"></see></summary>
    let excellenceLabel = _prefix "excellenceLabel"
    /// <summary>
    /// An establishment founded for doing research.
    /// <see href="http://w3id.org/roh#ResearchInstitute"></see></summary>
    let ResearchInstitute = _prefix "ResearchInstitute"
    /// <summary>
    ///   <see href="http://w3id.org/roh#ResearchMaterial"></see>
    /// </summary>
    let ResearchMaterial = _prefix "ResearchMaterial"
    /// <summary>
    /// Some entity producing some Thing.
    /// <see href="http://w3id.org/roh#producedBy"></see></summary>
    let producedBy = _prefix "producedBy"
    /// <summary>
    ///   <see href="http://w3id.org/roh#hasSucessor"></see>
    /// </summary>
    let hasSucessor = _prefix "hasSucessor"
    /// <summary>
    ///   <see href="http://w3id.org/roh#researchResultHasPart"></see>
    /// </summary>
    let researchResultHasPart = _prefix "researchResultHasPart"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Researching"></see>
    /// </summary>
    let Researching = _prefix "Researching"
    /// <summary>
    /// Some resources may available by an organization to be used by others.
    /// <see href="http://w3id.org/roh#Reservable"></see></summary>
    let Reservable = _prefix "Reservable"
    /// <summary>
    /// An Infrastructure belonging to an Agent.
    /// <see href="http://w3id.org/roh#reservableOf"></see></summary>
    let reservableOf = _prefix "reservableOf"
    /// <summary>
    /// Software that is reservable.
    /// <see href="http://w3id.org/roh#ReservableSoftware"></see></summary>
    let ReservableSoftware = _prefix "ReservableSoftware"
    /// <summary>
    ///   <see href="http://w3id.org/roh#ReservationRelationship"></see>
    /// </summary>
    let ReservationRelationship = _prefix "ReservationRelationship"
    /// <summary>
    ///   <see href="http://w3id.org/roh#RoundTable"></see>
    /// </summary>
    let RoundTable = _prefix "RoundTable"
    /// <summary>
    /// A graphic mark indicating highest levels of quality in research, often measured in terms of relevant publications related to the researching activity.
    /// <see href="http://w3id.org/roh#SealOfQuality"></see></summary>
    let SealOfQuality = _prefix "SealOfQuality"
    /// <summary>
    ///   <see href="http://w3id.org/roh#ServiceContract"></see>
    /// </summary>
    let ServiceContract = _prefix "ServiceContract"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Signed"></see>
    /// </summary>
    let Signed = _prefix "Signed"
    /// <summary>
    /// The Role held by an Agent in a Relationship.
    /// <see href="http://w3id.org/roh#roleOf"></see></summary>
    let roleOf = _prefix "roleOf"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Teaching"></see>
    /// </summary>
    let Teaching = _prefix "Teaching"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TechnicalReport"></see>
    /// </summary>
    let TechnicalReport = _prefix "TechnicalReport"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TechnicalSupport"></see>
    /// </summary>
    let TechnicalSupport = _prefix "TechnicalSupport"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Terminated"></see>
    /// </summary>
    let Terminated = _prefix "Terminated"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestAnotherGovernmentAgency"></see>
    /// </summary>
    let TestAnotherGovernmentAgency = _prefix "TestAnotherGovernmentAgency"
    /// <summary>
    /// A Funding Organization which promotes a Funding Program or a Funding Source.
    /// <see href="http://w3id.org/roh#promotes"></see></summary>
    let promotes = _prefix "promotes"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestFundingSource"></see>
    /// </summary>
    let TestFundingSource = _prefix "TestFundingSource"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestBook"></see>
    /// </summary>
    let TestBook = _prefix "TestBook"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestListofEditors"></see>
    /// </summary>
    let TestListofEditors = _prefix "TestListofEditors"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestChapterOne"></see>
    /// </summary>
    let TestChapterOne = _prefix "TestChapterOne"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestListofAuthors"></see>
    /// </summary>
    let TestListofAuthors = _prefix "TestListofAuthors"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestChapterThree"></see>
    /// </summary>
    let TestChapterThree = _prefix "TestChapterThree"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestChapterTwo"></see>
    /// </summary>
    let TestChapterTwo = _prefix "TestChapterTwo"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestCoSupervisorRole"></see>
    /// </summary>
    let TestCoSupervisorRole = _prefix "TestCoSupervisorRole"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestPhdCoSupervisor"></see>
    /// </summary>
    let TestPhdCoSupervisor = _prefix "TestPhdCoSupervisor"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestPhDSupervisingRelationship"></see>
    /// </summary>
    let TestPhDSupervisingRelationship = _prefix "TestPhDSupervisingRelationship"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestDateTimeInterval"></see>
    /// </summary>
    let TestDateTimeInterval = _prefix "TestDateTimeInterval"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestEndDateTimeValue"></see>
    /// </summary>
    let TestEndDateTimeValue = _prefix "TestEndDateTimeValue"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestStartDateTimeValue"></see>
    /// </summary>
    let TestStartDateTimeValue = _prefix "TestStartDateTimeValue"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestFundingProgram"></see>
    /// </summary>
    let TestFundingProgram = _prefix "TestFundingProgram"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestGovernmentAgency"></see>
    /// </summary>
    let TestGovernmentAgency = _prefix "TestGovernmentAgency"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestNonResearchSoftware"></see>
    /// </summary>
    let TestNonResearchSoftware = _prefix "TestNonResearchSoftware"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestOrganization"></see>
    /// </summary>
    let TestOrganization = _prefix "TestOrganization"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestPhDStudent"></see>
    /// </summary>
    let TestPhDStudent = _prefix "TestPhDStudent"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestPhdSupervisor"></see>
    /// </summary>
    let TestPhdSupervisor = _prefix "TestPhdSupervisor"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestProject"></see>
    /// </summary>
    let TestProject = _prefix "TestProject"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestSuperviseeRole"></see>
    /// </summary>
    let TestSuperviseeRole = _prefix "TestSuperviseeRole"
    /// <summary>
    ///   <see href="http://w3id.org/roh#TestSupervisorRole"></see>
    /// </summary>
    let TestSupervisorRole = _prefix "TestSupervisorRole"
    /// <summary>
    ///   <see href="http://w3id.org/roh#UndergraduateStudent"></see>
    /// </summary>
    let UndergraduateStudent = _prefix "UndergraduateStudent"
    /// <summary>
    ///   <see href="http://w3id.org/roh#Unfunded"></see>
    /// </summary>
    let Unfunded = _prefix "Unfunded"
    /// <summary>
    /// A division within a university (school, faculty, etc.)
    /// <see href="http://w3id.org/roh#UniversityDivision"></see></summary>
    let UniversityDivision = _prefix "UniversityDivision"
    /// <summary>
    /// A paper published on a conference workshop.
    /// <see href="http://w3id.org/roh#WorkshopPaper"></see></summary>
    let WorkshopPaper = _prefix "WorkshopPaper"
    /// <summary>
    /// It`s a Zenodo Repository that we can find in https://zenodo.org.
    /// <see href="http://w3id.org/roh#ZenodoRepository"></see></summary>
    let ZenodoRepository = _prefix "ZenodoRepository"
    /// <summary>
    /// An object property linking an Accreditation to the Agent is associated with.
    /// <see href="http://w3id.org/roh#accreditationOf"></see></summary>
    let accreditationOf = _prefix "accreditationOf"
    /// <summary>
    /// An object property linking an Agent with an Accreditation it posseses.
    /// <see href="http://w3id.org/roh#hasAccreditation"></see></summary>
    let hasAccreditation = _prefix "hasAccreditation"
    /// <summary>
    ///   <see href="http://w3id.org/roh#addresses"></see>
    /// </summary>
    let addresses = _prefix "addresses"
    /// <summary>
    ///   <see href="http://w3id.org/roh#advises"></see>
    /// </summary>
    let advises = _prefix "advises"
    /// <summary>
    ///   <see href="http://w3id.org/roh#isAdvisedBy"></see>
    /// </summary>
    let isAdvisedBy = _prefix "isAdvisedBy"
    /// <summary>
    /// an organisation (i.e. university) is associated with another organsiation (i.e. research institute).
    /// <see href="http://w3id.org/roh#associatedWith"></see></summary>
    let associatedWith = _prefix "associatedWith"
    /// <summary>
    /// An object property describing a not machine-readable document attached to an entity offering more detailed information.
    /// <see href="http://w3id.org/roh#attachment"></see></summary>
    let attachment = _prefix "attachment"
    /// <summary>
    ///   <see href="http://w3id.org/roh#authors"></see>
    /// </summary>
    let authors = _prefix "authors"
    /// <summary>
    ///   <see href="http://w3id.org/roh#isAuthoredBy"></see>
    /// </summary>
    let isAuthoredBy = _prefix "isAuthoredBy"
    /// <summary>
    /// An object property linking an AwardedDegree to the University that awarded it.
    /// <see href="http://w3id.org/roh#awardedBy"></see></summary>
    let awardedBy = _prefix "awardedBy"
    /// <summary>
    /// An object property linking the University awarding a degree to the AwardedDegree.
    /// <see href="http://w3id.org/roh#awards"></see></summary>
    let awards = _prefix "awards"
    /// <summary>
    ///   <see href="http://w3id.org/roh#awardedWith"></see>
    /// </summary>
    let awardedWith = _prefix "awardedWith"
    /// <summary>
    /// The birthdate of an Entity.
    /// <see href="http://w3id.org/roh#birthdate"></see></summary>
    let birthdate = _prefix "birthdate"
    /// <summary>
    /// An academic publication (bachelor's thesis, master's thesis or doctoral thesis) is co-advised by an advisor.
    /// <see href="http://w3id.org/roh#coadvisedBy"></see></summary>
    let coadvisedBy = _prefix "coadvisedBy"
    /// <summary>
    /// A person co-advises an academic publication (bachelor's thesis, master's thesis or doctoral thesis).
    /// <see href="http://w3id.org/roh#coadvises"></see></summary>
    let coadvises = _prefix "coadvises"
    /// <summary>
    /// A code is assigned to a concept.
    /// <see href="http://w3id.org/roh#codeOf"></see></summary>
    let codeOf = _prefix "codeOf"
    /// <summary>
    /// A concept can be asigned a code.
    /// <see href="http://w3id.org/roh#hasCode"></see></summary>
    let hasCode = _prefix "hasCode"
    /// <summary>
    ///   <see href="http://w3id.org/roh#companyFounder"></see>
    /// </summary>
    let companyFounder = _prefix "companyFounder"
    /// <summary>
    /// Specifies the contact info of type vcard:Kind for an Agent.
    /// <see href="http://w3id.org/roh#contactInfoOf"></see></summary>
    let contactInfoOf = _prefix "contactInfoOf"
    /// <summary>
    /// An Agent has a contact info of type vcard:Kind.
    /// <see href="http://w3id.org/roh#hasContactInfo"></see></summary>
    let hasContactInfo = _prefix "hasContactInfo"
    /// <summary>
    /// An object property linking a Contract to an Entity.
    /// <see href="http://w3id.org/roh#contractOf"></see></summary>
    let contractOf = _prefix "contractOf"
    /// <summary>
    /// An object property linking a Contract with the date (DateTimeValue) when it was signed.
    /// <see href="http://w3id.org/roh#contractSigningDate"></see></summary>
    let contractSigningDate = _prefix "contractSigningDate"
    /// <summary>
    /// An object property linking a signing date (DateTimeValue) with a Contract.
    /// <see href="http://w3id.org/roh#contractSigningDateOf"></see></summary>
    let contractSigningDateOf = _prefix "contractSigningDateOf"
    /// <summary>
    /// inverse property of 'project coordinator'
    /// <see href="http://w3id.org/roh#coordinatedBy"></see></summary>
    let coordinatedBy = _prefix "coordinatedBy"
    /// <summary>
    /// An object property linking a Person with a Thing, such person is corresponding author for.
    /// <see href="http://w3id.org/roh#correspondingAuthorOf"></see></summary>
    let correspondingAuthorOf = _prefix "correspondingAuthorOf"
    /// <summary>
    ///   <see href="http://w3id.org/roh#correspondingOrganization"></see>
    /// </summary>
    let correspondingOrganization = _prefix "correspondingOrganization"
    /// <summary>
    ///   <see href="http://w3id.org/roh#correspondingOrganizationOf"></see>
    /// </summary>
    let correspondingOrganizationOf = _prefix "correspondingOrganizationOf"
    /// <summary>
    /// This property indicates the nationality of a resource. The domain is not set so unpredicted resources within the ontology could be attached to countries.
    /// <see href="http://w3id.org/roh#country"></see></summary>
    let country = _prefix "country"
    /// <summary>
    /// The number of hours a course lasts.
    /// <see href="http://w3id.org/roh#courseHours"></see></summary>
    let courseHours = _prefix "courseHours"
    /// <summary>
    /// The dedication which a Person dedicates to a Role.
    /// <see href="http://w3id.org/roh#dedication"></see></summary>
    let dedication = _prefix "dedication"
    /// <summary>
    ///   <see href="http://w3id.org/roh#dedicationPercentage"></see>
    /// </summary>
    let dedicationPercentage = _prefix "dedicationPercentage"
    /// <summary>
    ///   <see href="http://w3id.org/roh#employs"></see>
    /// </summary>
    let employs = _prefix "employs"
    /// <summary>
    ///   <see href="http://w3id.org/roh#expirationDate"></see>
    /// </summary>
    let expirationDate = _prefix "expirationDate"
    /// <summary>
    /// The date in which a Justificacion has to be delivered.
    /// <see href="http://w3id.org/roh#foreseenJustificationDate"></see></summary>
    let foreseenJustificationDate = _prefix "foreseenJustificationDate"
    /// <summary>
    /// Date in which an Organization was created.
    /// <see href="http://w3id.org/roh#foundationDate"></see></summary>
    let foundationDate = _prefix "foundationDate"
    /// <summary>
    ///   <see href="http://w3id.org/roh#freeOrPaid"></see>
    /// </summary>
    let freeOrPaid = _prefix "freeOrPaid"
    /// <summary>
    /// An object property linking an Organization with a FundingAmount.
    /// <see href="http://w3id.org/roh#grantedBy"></see></summary>
    let grantedBy = _prefix "grantedBy"
    /// <summary>
    ///   <see href="http://w3id.org/roh#hasCompanyClassification"></see>
    /// </summary>
    let hasCompanyClassification = _prefix "hasCompanyClassification"
    /// <summary>
    /// The classification of the position of a Person.
    /// <see href="http://w3id.org/roh#hrClassificationOf"></see></summary>
    let hrClassificationOf = _prefix "hrClassificationOf"
    /// <summary>
    /// A skos:Concept which is the knowledge area of some entity.
    /// <see href="http://w3id.org/roh#knowledgeAreaOf"></see></summary>
    let knowledgeAreaOf = _prefix "knowledgeAreaOf"
    /// <summary>
    /// A Metric which quantifies a Research Object.
    /// <see href="http://w3id.org/roh#hasMetric"></see></summary>
    let hasMetric = _prefix "hasMetric"
    /// <summary>
    ///   <see href="http://w3id.org/roh#hasPatent"></see>
    /// </summary>
    let hasPatent = _prefix "hasPatent"
    /// <summary>
    /// A Person has a Position in his/her Organization.
    /// <see href="http://w3id.org/roh#hasPosition"></see></summary>
    let hasPosition = _prefix "hasPosition"
    /// <summary>
    /// The Position of a Person within an Organization.
    /// <see href="http://w3id.org/roh#positionOf"></see></summary>
    let positionOf = _prefix "positionOf"
    /// <summary>
    /// A Project is categorized by different Project Classifications.
    /// <see href="http://w3id.org/roh#hasProjectClassification"></see></summary>
    let hasProjectClassification = _prefix "hasProjectClassification"
    /// <summary>
    /// A Project Classification which categorizes a Project.
    /// <see href="http://w3id.org/roh#projectClassificationOf"></see></summary>
    let projectClassificationOf = _prefix "projectClassificationOf"
    /// <summary>
    ///   <see href="http://w3id.org/roh#hasResearchContribution"></see>
    /// </summary>
    let hasResearchContribution = _prefix "hasResearchContribution"
    /// <summary>
    /// An Agent who owns an infrastructure.
    /// <see href="http://w3id.org/roh#hasReservable"></see></summary>
    let hasReservable = _prefix "hasReservable"
    /// <summary>
    /// An Agent has a Role in a Relation.
    /// <see href="http://w3id.org/roh#hasRole"></see></summary>
    let hasRole = _prefix "hasRole"
    /// <summary>
    ///   <see href="http://w3id.org/roh#hasScientificDomain"></see>
    /// </summary>
    let hasScientificDomain = _prefix "hasScientificDomain"
    /// <summary>
    /// An Organization which has a spin off Company.
    /// <see href="http://w3id.org/roh#hasSpinoff"></see></summary>
    let hasSpinoff = _prefix "hasSpinoff"
    /// <summary>
    /// A Company which is an spinoff of an Organization.
    /// <see href="http://w3id.org/roh#isSpinfoffOf"></see></summary>
    let isSpinfoffOf = _prefix "isSpinfoffOf"
    /// <summary>
    /// A prototype has a given technology readiness level
    /// <see href="http://w3id.org/roh#hasTRL"></see></summary>
    let hasTRL = _prefix "hasTRL"
    /// <summary>
    ///   <see href="http://w3id.org/roh#isAwardedBy"></see>
    /// </summary>
    let isAwardedBy = _prefix "isAwardedBy"
    /// <summary>
    ///   <see href="http://w3id.org/roh#isCompetitive"></see>
    /// </summary>
    let isCompetitive = _prefix "isCompetitive"
    /// <summary>
    /// A person is granted with a stipend for researching.
    /// <see href="http://w3id.org/roh#isGrantedWith"></see></summary>
    let isGrantedWith = _prefix "isGrantedWith"
    /// <summary>
    /// A Service provided by an Organization.
    /// <see href="http://w3id.org/roh#isProvidedBy"></see></summary>
    let isProvidedBy = _prefix "isProvidedBy"
    /// <summary>
    /// An Organization which provides a Service.
    /// <see href="http://w3id.org/roh#provides"></see></summary>
    let provides = _prefix "provides"
    /// <summary>
    /// To specify that a company is in its early stage of life.
    /// <see href="http://w3id.org/roh#isStartup"></see></summary>
    let isStartup = _prefix "isStartup"
    /// <summary>
    /// A Funding which supports a Person Contract or a Project.
    /// <see href="http://w3id.org/roh#supports"></see></summary>
    let supports = _prefix "supports"
    /// <summary>
    /// A numeric commercial book identifier which is intended to be unique.
    /// <see href="http://w3id.org/roh#isbn"></see></summary>
    let isbn = _prefix "isbn"
    /// <summary>
    /// An Accreditation issued by an Accreditation Issuer.
    /// <see href="http://w3id.org/roh#issuedBy"></see></summary>
    let issuedBy = _prefix "issuedBy"
    /// <summary>
    /// Different skills required by the Common European Framework of Reference for Languages: Learning, Teaching, Assessment.
    /// <see href="http://w3id.org/roh#languageSkill"></see></summary>
    let languageSkill = _prefix "languageSkill"
    /// <summary>
    /// A free text property to represent the modality of a Project.
    /// <see href="http://w3id.org/roh#modality"></see></summary>
    let modality = _prefix "modality"
    /// <summary>
    /// Represents if a Project needs to pass an ethical validation.
    /// <see href="http://w3id.org/roh#needsEthicalValidation"></see></summary>
    let needsEthicalValidation = _prefix "needsEthicalValidation"
    /// <summary>
    /// An Organization owning a Patent.
    /// <see href="http://w3id.org/roh#ownerOrganizationOf"></see></summary>
    let ownerOrganizationOf = _prefix "ownerOrganizationOf"
    /// <summary>
    /// A core relation that holds between a part and its hole, that in this case is a Repository.
    /// <see href="http://w3id.org/roh#partOfRepository"></see></summary>
    let partOfRepository = _prefix "partOfRepository"
    /// <summary>
    /// An Entity participating in an Activity.
    /// <see href="http://w3id.org/roh#participates"></see></summary>
    let participates = _prefix "participates"
    /// <summary>
    ///   <see href="http://w3id.org/roh#patentAssistantExaminer"></see>
    /// </summary>
    let patentAssistantExaminer = _prefix "patentAssistantExaminer"
    /// <summary>
    ///   <see href="http://w3id.org/roh#patentCountry"></see>
    /// </summary>
    let patentCountry = _prefix "patentCountry"
    /// <summary>
    ///   <see href="http://w3id.org/roh#patentInventor"></see>
    /// </summary>
    let patentInventor = _prefix "patentInventor"
    /// <summary>
    ///   <see href="http://w3id.org/roh#patentPrimaryExaminer"></see>
    /// </summary>
    let patentPrimaryExaminer = _prefix "patentPrimaryExaminer"
    /// <summary>
    ///   <see href="http://w3id.org/roh#platform"></see>
    /// </summary>
    let platform = _prefix "platform"
    /// <summary>
    ///   <see href="http://w3id.org/roh#programmingLanguage"></see>
    /// </summary>
    let programmingLanguage = _prefix "programmingLanguage"
    /// <summary>
    ///   <see href="http://w3id.org/roh#projectAcronym"></see>
    /// </summary>
    let projectAcronym = _prefix "projectAcronym"
    /// <summary>
    ///   <see href="http://w3id.org/roh#projectID"></see>
    /// </summary>
    let projectID = _prefix "projectID"
    /// <summary>
    /// A defined objective of the project.
    /// <see href="http://w3id.org/roh#projectObjective"></see></summary>
    let projectObjective = _prefix "projectObjective"
    /// <summary>
    /// A project may be in a CLOSED, OPEN or in other future status that may be defined.
    /// <see href="http://w3id.org/roh#projectStatus"></see></summary>
    let projectStatus = _prefix "projectStatus"
    /// <summary>
    /// To define if a Company is public or not.
    /// <see href="http://w3id.org/roh#publicCompany"></see></summary>
    let publicCompany = _prefix "publicCompany"
    /// <summary>
    /// A reference law that establishes a position.
    /// <see href="http://w3id.org/roh#referencedLaw"></see></summary>
    let referencedLaw = _prefix "referencedLaw"
    /// <summary>
    ///   <see href="http://w3id.org/roh#requiredFor"></see>
    /// </summary>
    let requiredFor = _prefix "requiredFor"
    /// <summary>
    /// This property relates roles and their requisites, i.e. other roles.
    /// <see href="http://w3id.org/roh#requires"></see></summary>
    let requires = _prefix "requires"
    /// <summary>
    /// A free-text property to define the research line in which an Organization or Researcher is working on.
    /// <see href="http://w3id.org/roh#researchLine"></see></summary>
    let researchLine = _prefix "researchLine"
    /// <summary>
    /// a proerty to link a person to a publication as a reviewer.
    /// <see href="http://w3id.org/roh#reviews"></see></summary>
    let reviews = _prefix "reviews"
    /// <summary>
    /// The status of a Software  (Final or Provisional).
    /// <see href="http://w3id.org/roh#softwareStatus"></see></summary>
    let softwareStatus = _prefix "softwareStatus"
    /// <summary>
    /// An Expense spent by an Entity.
    /// <see href="http://w3id.org/roh#spentBy"></see></summary>
    let spentBy = _prefix "spentBy"
    /// <summary>
    /// A Thesis supervised by a Person.
    /// <see href="http://w3id.org/roh#supervisedBy"></see></summary>
    let supervisedBy = _prefix "supervisedBy"
    /// <summary>
    /// A Person supervising a Thesis.
    /// <see href="http://w3id.org/roh#supervisorOf"></see></summary>
    let supervisorOf = _prefix "supervisorOf"
    /// <summary>
    ///   <see href="http://w3id.org/roh#taughtBy"></see>
    /// </summary>
    let taughtBy = _prefix "taughtBy"
    /// <summary>
    ///   <see href="http://w3id.org/roh#teaches"></see>
    /// </summary>
    let teaches = _prefix "teaches"
    /// <summary>
    ///   <see href="http://w3id.org/roh#taxID"></see>
    /// </summary>
    let taxID = _prefix "taxID"
    /// <summary>
    ///   <see href="http://w3id.org/roh#upc"></see>
    /// </summary>
    let upc = _prefix "upc"
    /// <summary>
    /// A Uniform Resource Identifier.
    /// <see href="http://w3id.org/roh#url"></see></summary>
    let url = _prefix "url"
    /// <summary>
    ///   <see href="http://w3id.org/roh#utilizes"></see>
    /// </summary>
    let utilizes = _prefix "utilizes"
