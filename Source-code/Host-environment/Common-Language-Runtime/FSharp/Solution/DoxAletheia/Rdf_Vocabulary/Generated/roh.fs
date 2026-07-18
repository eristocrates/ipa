namespace http.w3id.org.roh.hash

open DoxAletheia.Rdf_Vocabulary

module roh =
    let _namespace_name = "http://w3id.org/roh#"

    /// <summary>
    ///   <see href="http://w3id.org/roh#PatentExpense"></see>
    /// </summary>
    let PatentExpense =
        Namespaced_IRI.parse _namespace_name "PatentExpense" |> NamespacedName

    /// <summary>
    /// A ProjectExpense is carried out by a Researcher (by default the principal researcher) in charge of a Project, which indirectly links it to Funding, understood as a set of FundingAmounts. The types of expenses considered are: Personnel Expenses, Subcontracting, Travel, Equipment, Research Infrastructure and Other Goods and Services."^^rdfs:Literal
    /// <see href="http://w3id.org/roh#PersonExpense"></see></summary>
    let PersonExpense =
        Namespaced_IRI.parse _namespace_name "PersonExpense" |> NamespacedName

    /// <summary>
    /// A ProjectExpense is carried out by a Researcher (by default the principal researcher) in charge of a Project, which indirectly links it to Funding, understood as a set of FundingAmounts. The types of expenses considered are: Personnel Expenses, Subcontracting, Travel, Equipment, Research Infrastructure and Other Goods and Services.
    /// <see href="http://w3id.org/roh#ProjectExpense"></see></summary>
    let ProjectExpense =
        Namespaced_IRI.parse _namespace_name "ProjectExpense" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#ResearchObjectExpense"></see>
    /// </summary>
    let ResearchObjectExpense =
        Namespaced_IRI.parse _namespace_name "ResearchObjectExpense" |> NamespacedName

    /// <summary>
    /// A roh:Activity is participated by Persons (roh:participates) and organized by Organizations through roh:hasRole connecting to intermediary entity vivo:OrganizerRole. Each activity is usually linked to a Project through relationship (roh:participates) and causes a ProjectExpense linked through (vivo:relates). A thorough hierarchy of roh:Activity subtypes is defined: bibo:Conference, vivo:Intership, roh:ThesisViva.
    /// <see href="http://w3id.org/roh#Activity"></see></summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#ExperimentalProtocol"></see>
    /// </summary>
    let ExperimentalProtocol =
        Namespaced_IRI.parse _namespace_name "ExperimentalProtocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#Repository"></see>
    /// </summary>
    let Repository = Namespaced_IRI.parse _namespace_name "Repository" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#ResearchContribution"></see>
    /// </summary>
    let ResearchContribution =
        Namespaced_IRI.parse _namespace_name "ResearchContribution" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#ResearchMethod"></see>
    /// </summary>
    let ResearchMethod =
        Namespaced_IRI.parse _namespace_name "ResearchMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#Invoice"></see>
    /// </summary>
    let Invoice = Namespaced_IRI.parse _namespace_name "Invoice" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/roh#Award"></see>
    /// </summary>
    let Award = Namespaced_IRI.parse _namespace_name "Award" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#CourseCertificate"></see>
    /// </summary>
    let CourseCertificate =
        Namespaced_IRI.parse _namespace_name "CourseCertificate" |> NamespacedName

    /// <summary>
    /// A language certificate from the Common European Framework of Reference for Languages: Learning, Teaching, Assessment.
    /// <see href="http://w3id.org/roh#LanguageCertificate"></see></summary>
    let LanguageCertificate =
        Namespaced_IRI.parse _namespace_name "LanguageCertificate" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#AuditeeRole"></see>
    /// </summary>
    let AuditeeRole =
        Namespaced_IRI.parse _namespace_name "AuditeeRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#AuditorRole"></see>
    /// </summary>
    let AuditorRole =
        Namespaced_IRI.parse _namespace_name "AuditorRole" |> NamespacedName

    /// <summary>
    /// A member who works in a Project or participates in an Activity but do not belong to the main Organization.
    /// <see href="http://w3id.org/roh#ExternalMemberRole"></see></summary>
    let ExternalMemberRole =
        Namespaced_IRI.parse _namespace_name "ExternalMemberRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#ReservableConsumerRole"></see>
    /// </summary>
    let ReservableConsumerRole =
        Namespaced_IRI.parse _namespace_name "ReservableConsumerRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#ReservableProviderRole"></see>
    /// </summary>
    let ReservableProviderRole =
        Namespaced_IRI.parse _namespace_name "ReservableProviderRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#SuperviseeRole"></see>
    /// </summary>
    let SuperviseeRole =
        Namespaced_IRI.parse _namespace_name "SuperviseeRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#SupervisorRole"></see>
    /// </summary>
    let SupervisorRole =
        Namespaced_IRI.parse _namespace_name "SupervisorRole" |> NamespacedName

    /// <summary>
    /// A role of contracting someone to perform a job.
    /// <see href="http://w3id.org/roh#ThirdPartyContractorRole"></see></summary>
    let ThirdPartyContractorRole =
        Namespaced_IRI.parse _namespace_name "ThirdPartyContractorRole" |> NamespacedName

    /// <summary>
    /// An attestation of qualification, competence, or authority issued to an individual by a third party with a relevant or  de facto authority or assumed competence to do so in the academic field.
    /// <see href="http://w3id.org/roh#AcademicAccreditation"></see></summary>
    let AcademicAccreditation =
        Namespaced_IRI.parse _namespace_name "AcademicAccreditation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#DegreeHomologation"></see>
    /// </summary>
    let DegreeHomologation =
        Namespaced_IRI.parse _namespace_name "DegreeHomologation" |> NamespacedName

    /// <summary>
    /// An attestation of qualification, competence, or authority issued to an individual by a third party with a relevant or  de facto authority or assumed competence to do so in the research field.
    /// <see href="http://w3id.org/roh#ResearchAccreditation"></see></summary>
    let ResearchAccreditation =
        Namespaced_IRI.parse _namespace_name "ResearchAccreditation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#AcademicSubject"></see>
    /// </summary>
    let AcademicSubject =
        Namespaced_IRI.parse _namespace_name "AcademicSubject" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#CompanyClassification"></see>
    /// </summary>
    let CompanyClassification =
        Namespaced_IRI.parse _namespace_name "CompanyClassification" |> NamespacedName

    /// <summary>
    /// A region legally identified as a distinct entity in political geography.
    /// <see href="http://w3id.org/roh#Country"></see></summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#ExpenseClassification"></see>
    /// </summary>
    let ExpenseClassification =
        Namespaced_IRI.parse _namespace_name "ExpenseClassification" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#FundingProgramClassification"></see>
    /// </summary>
    let FundingProgramClassification =
        Namespaced_IRI.parse _namespace_name "FundingProgramClassification" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#HRClassification"></see>
    /// </summary>
    let HRClassification =
        Namespaced_IRI.parse _namespace_name "HRClassification" |> NamespacedName

    /// <summary>
    /// ROH will be populated with instance data of UNESCO skos concepts. A Person, Activity, Project and Organization can be qualified by a KnowledgeArea
    /// <see href="http://w3id.org/roh#KnowledgeArea"></see></summary>
    let KnowledgeArea =
        Namespaced_IRI.parse _namespace_name "KnowledgeArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#ProjectClassification"></see>
    /// </summary>
    let ProjectClassification =
        Namespaced_IRI.parse _namespace_name "ProjectClassification" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#PropertyClassification"></see>
    /// </summary>
    let PropertyClassification =
        Namespaced_IRI.parse _namespace_name "PropertyClassification" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#ResearchProblem"></see>
    /// </summary>
    let ResearchProblem =
        Namespaced_IRI.parse _namespace_name "ResearchProblem" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#AuthorMetric"></see>
    /// </summary>
    let AuthorMetric =
        Namespaced_IRI.parse _namespace_name "AuthorMetric" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#DegreeMetric"></see>
    /// </summary>
    let DegreeMetric =
        Namespaced_IRI.parse _namespace_name "DegreeMetric" |> NamespacedName

    /// <summary>
    /// An article is cited roh:citationCount times in the roh:metricName network. Example: if an article is cited 5 times in the Web of Science, then the roh:metricName should be Web of Science and the roh:citationCount 5. Thus, a roh:metricName can be roh and the value of roh:citationCount the number of times that article has been cited in the knowledge graph of this ontology.
    /// <see href="http://w3id.org/roh#PublicationMetric"></see></summary>
    let PublicationMetric =
        Namespaced_IRI.parse _namespace_name "PublicationMetric" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#ResearchGroupMetric"></see>
    /// </summary>
    let ResearchGroupMetric =
        Namespaced_IRI.parse _namespace_name "ResearchGroupMetric" |> NamespacedName

    /// <summary>
    /// An evaluation summary provided by a funding organization.
    /// <see href="http://w3id.org/roh#EvaluationSummary"></see></summary>
    let EvaluationSummary =
        Namespaced_IRI.parse _namespace_name "EvaluationSummary" |> NamespacedName

    /// <summary>
    /// A Justification is a bibo:Report used to justify eithet technically, economically or both a project.
    /// <see href="http://w3id.org/roh#Justification"></see></summary>
    let Justification =
        Namespaced_IRI.parse _namespace_name "Justification" |> NamespacedName

    /// <summary>
    /// An undergraduate academic degree awarded by colleges and universities upon completion of a course of study lasting three to four years (depending on institution and academic discipline).
    /// <see href="http://w3id.org/roh#BachelorsDegree"></see></summary>
    let BachelorsDegree =
        Namespaced_IRI.parse _namespace_name "BachelorsDegree" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#DoctoralDegree"></see>
    /// </summary>
    let DoctoralDegree =
        Namespaced_IRI.parse _namespace_name "DoctoralDegree" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#MastersDegree"></see>
    /// </summary>
    let MastersDegree =
        Namespaced_IRI.parse _namespace_name "MastersDegree" |> NamespacedName

    /// <summary>
    /// An Accreditation models research and academic position accreditations. Qualification goes beyond Accreditation because it also refers to degrees and other qualifications a person may have.  Accreditation has an important data property which is dateIssued which links Accreditation with vivo:DataTimeValue
    /// <see href="http://w3id.org/roh#Accreditation"></see></summary>
    let Accreditation =
        Namespaced_IRI.parse _namespace_name "Accreditation" |> NamespacedName

    /// <summary>
    /// A roh:Expense is carried out in a vivo:Project or by foaf:Person and associated through relationship roh:spends. It timestamps each expense with a vivo:DateTimeValue and has attributes roh:monetaryAmount, roh:currency, roh:title and roh:description and expenseAmount . The types of expenses considered are: Personnel Expenses, Subcontracting, Travel, Equipment, Research Infrastructure and Other Goods and Services. Some of these classes still not defined.
    /// <see href="http://w3id.org/roh#Expense"></see></summary>
    let Expense = Namespaced_IRI.parse _namespace_name "Expense" |> NamespacedName
    /// <summary>
    /// A roh:Funding is the funding associated to a vivo:Project whose funding is associated to a roh:FundingProgram, which in turn is associated to a vivo:FundingOrganization. A roh:Funding consists of several roh:FundingAmounts, associated to the different entities that participate in a project and to the annuities in which they do it.  Funding gathers information about the total funding received for a Project and its currency through properties roh:monetaryAmount and roh:currency. A roh:FundingSource funds a roh:FundingProgram. A roh:Funding supports a vivo:Project or a roh:PersonContract. A Funding can be tagged as public or private, by updating the data property roh:publicFunding.
    /// <see href="http://w3id.org/roh#Funding"></see></summary>
    let Funding = Namespaced_IRI.parse _namespace_name "Funding" |> NamespacedName

    /// <summary>
    /// A roh:FundingAmount is linked to a roh:Funding which is roh:fundedBy a roh:FundingProgram and finances a Project (through roh:supports relationship). Each FundingAmount is associated to an Organization participating in the Project (through roh:grants relationship) for each project specific annuity.
    /// <see href="http://w3id.org/roh#FundingAmount"></see></summary>
    let FundingAmount =
        Namespaced_IRI.parse _namespace_name "FundingAmount" |> NamespacedName

    /// <summary>
    /// A roh:FundingProgram is promoted (roh:promotedBy) by a Funding Organization (vivo:FundingOrganization) and it is in place for a time interval (vivo:dateTimeInterval)
    /// A programme of related funded projects, typically established by a funding organization.
    /// <see href="http://w3id.org/roh#FundingProgram"></see></summary>
    let FundingProgram =
        Namespaced_IRI.parse _namespace_name "FundingProgram" |> NamespacedName

    /// <summary>
    /// We have just considered a subset of the available funding sources, taking into account the sample datasets provided by University of Murcia
    ///
    /// A roh:FundingSource roh:feeds a roh:Funding with funds to sponsor some projects.
    /// <see href="http://w3id.org/roh#FundingSource"></see></summary>
    let FundingSource =
        Namespaced_IRI.parse _namespace_name "FundingSource" |> NamespacedName

    /// <summary>
    /// Invention
    /// A new device, method, or process developed from study and experimentation in the framework of research.
    /// <see href="http://w3id.org/roh#Invention"></see></summary>
    let Invention = Namespaced_IRI.parse _namespace_name "Invention" |> NamespacedName
    /// <summary>
    /// An roh:Metric indicates qualifies a roh:ResearchObject according to common established quality measurement metrics, e.g. impact factor or mark in an PhD viva.
    /// <see href="http://w3id.org/roh#Metric"></see></summary>
    let Metric = Namespaced_IRI.parse _namespace_name "Metric" |> NamespacedName
    /// <summary>
    /// A product as outcome of a project.
    /// <see href="http://w3id.org/roh#Product"></see></summary>
    let Product = Namespaced_IRI.parse _namespace_name "Product" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/roh#Status"></see>
    /// </summary>
    let Status = Namespaced_IRI.parse _namespace_name "Status" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#LargeEnterprise"></see>
    /// </summary>
    let LargeEnterprise =
        Namespaced_IRI.parse _namespace_name "LargeEnterprise" |> NamespacedName

    /// <summary>
    /// An enterprise which employ fewer than 250 persons and which have an annual turnover not exceeding EUR 50 million, and/or an annual balance sheet total not exceeding EUR 43 million.
    /// <see href="http://w3id.org/roh#MediumEnterprise"></see></summary>
    let MediumEnterprise =
        Namespaced_IRI.parse _namespace_name "MediumEnterprise" |> NamespacedName

    /// <summary>
    /// An enterprise which employs fewer than 10 persons and whose annual turnover and/or annual balance sheet total does not exceed EUR 2 million.
    /// <see href="http://w3id.org/roh#MicroEnterprise"></see></summary>
    let MicroEnterprise =
        Namespaced_IRI.parse _namespace_name "MicroEnterprise" |> NamespacedName

    /// <summary>
    /// An enterprise which employs fewer than 50 persons and whose annual turnover and/or annual balance sheet total does not exceed EUR 10 million.
    /// <see href="http://w3id.org/roh#SmallEnterprise"></see></summary>
    let SmallEnterprise =
        Namespaced_IRI.parse _namespace_name "SmallEnterprise" |> NamespacedName

    /// <summary>
    /// A document created to summarize research findings associated with the completion of an academic degree.
    /// A thesis reporting a research project undertaken as part of an undergraduate course of education to receive a bachelor's degree.
    /// <see href="http://w3id.org/roh#BachelorsThesis"></see></summary>
    let BachelorsThesis =
        Namespaced_IRI.parse _namespace_name "BachelorsThesis" |> NamespacedName

    /// <summary>
    /// A thesis reporting a research project undertaken as part of a second-cycle course of education to receive a master's degree.
    /// A document created to summarize research findings associated with the completion of a master's degree.
    /// <see href="http://w3id.org/roh#MastersThesis"></see></summary>
    let MastersThesis =
        Namespaced_IRI.parse _namespace_name "MastersThesis" |> NamespacedName

    /// <summary>
    /// A thesis reporting a research project undertaken as part of an undergraduate course of education to receive a doctoral degree.
    /// A document created to summarize research findings associated with the completion of a doctoral thesis.
    /// <see href="http://w3id.org/roh#PhDThesis"></see></summary>
    let PhDThesis = Namespaced_IRI.parse _namespace_name "PhDThesis" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#AuditingRelationship"></see>
    /// </summary>
    let AuditingRelationship =
        Namespaced_IRI.parse _namespace_name "AuditingRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#SupervisingRelationship"></see>
    /// </summary>
    let SupervisingRelationship =
        Namespaced_IRI.parse _namespace_name "SupervisingRelationship" |> NamespacedName

    /// <summary>
    /// An ethics committee is a body responsible for ensuring that medical experimentation and human subject research are carried out in an ethical manner in accordance with national and international law.
    /// <see href="http://w3id.org/roh#EthicsCommittee"></see></summary>
    let EthicsCommittee =
        Namespaced_IRI.parse _namespace_name "EthicsCommittee" |> NamespacedName

    /// <summary>
    /// A group of researchers often from the same centre, specialised on the same subject, working together on the issue or topic.
    /// <see href="http://w3id.org/roh#ResearchGroup"></see></summary>
    let ResearchGroup =
        Namespaced_IRI.parse _namespace_name "ResearchGroup" |> NamespacedName

    /// <summary>
    /// A financial award provided by a funding organisation for a particular project or purpose, usually awarded on the basis of a competitive application.
    /// An amount of money given especially by the government to a person or organization for a special purpose.
    /// <see href="http://w3id.org/roh#Grant"></see></summary>
    let Grant = Namespaced_IRI.parse _namespace_name "Grant" |> NamespacedName
    /// <summary>
    /// An amount of money that is borrowed, often from a bank or a funding organization, and has to be paid back, usually together with an extra amount of money that you have to pay as a charge for borrowing.
    /// <see href="http://w3id.org/roh#Loan"></see></summary>
    let Loan = Namespaced_IRI.parse _namespace_name "Loan" |> NamespacedName

    /// <summary>
    /// The process of paying to have part of a company's work done by another company.
    /// <see href="http://w3id.org/roh#Outsourcing"></see></summary>
    let Outsourcing =
        Namespaced_IRI.parse _namespace_name "Outsourcing" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#RefundableAdvance"></see>
    /// </summary>
    let RefundableAdvance =
        Namespaced_IRI.parse _namespace_name "RefundableAdvance" |> NamespacedName

    /// <summary>
    /// An oral examination in which a PhD Student defends her/his doctoral thesis.
    /// <see href="http://w3id.org/roh#ThesisViva"></see></summary>
    let ThesisViva = Namespaced_IRI.parse _namespace_name "ThesisViva" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#PatentContract"></see>
    /// </summary>
    let PatentContract =
        Namespaced_IRI.parse _namespace_name "PatentContract" |> NamespacedName

    /// <summary>
    /// An agreement between a person and an organization to work in a project for a specified duration.
    /// <see href="http://w3id.org/roh#PersonContract"></see></summary>
    let PersonContract =
        Namespaced_IRI.parse _namespace_name "PersonContract" |> NamespacedName

    /// <summary>
    /// An agreement among different organizations to work in a project for a specified duration.
    /// <see href="http://w3id.org/roh#ProjectContract"></see></summary>
    let ProjectContract =
        Namespaced_IRI.parse _namespace_name "ProjectContract" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#BachelorsSupervisingRelationship"></see>
    /// </summary>
    let BachelorsSupervisingRelationship =
        Namespaced_IRI.parse _namespace_name "BachelorsSupervisingRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#MastersSupervisingRelationship"></see>
    /// </summary>
    let MastersSupervisingRelationship =
        Namespaced_IRI.parse _namespace_name "MastersSupervisingRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#PhDSupervisingRelationship"></see>
    /// </summary>
    let PhDSupervisingRelationship =
        Namespaced_IRI.parse _namespace_name "PhDSupervisingRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#BlogPost"></see>
    /// </summary>
    let BlogPost = Namespaced_IRI.parse _namespace_name "BlogPost" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#PressArticle"></see>
    /// </summary>
    let PressArticle =
        Namespaced_IRI.parse _namespace_name "PressArticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#EthicalReport"></see>
    /// </summary>
    let EthicalReport =
        Namespaced_IRI.parse _namespace_name "EthicalReport" |> NamespacedName

    /// <summary>
    /// A member of a university or research organization focused on research task further than other ones.
    /// <see href="http://w3id.org/roh#ResearcherPosition"></see></summary>
    let ResearcherPosition =
        Namespaced_IRI.parse _namespace_name "ResearcherPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#Accepted"></see>
    /// </summary>
    let Accepted = Namespaced_IRI.parse _namespace_name "Accepted" |> NamespacedName

    /// <summary>
    /// Some entity related to any Concept.
    /// <see href="http://w3id.org/roh#hasKnowledgeArea"></see></summary>
    let hasKnowledgeArea =
        Namespaced_IRI.parse _namespace_name "hasKnowledgeArea" |> NamespacedName

    /// <summary>
    /// A data property that associates a title to any ROH entity requiring it.
    /// <see href="http://w3id.org/roh#title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName

    /// <summary>
    /// An organization with a relevant or de facto authority or assumed competence to issue research or academic accreditations.
    /// <see href="http://w3id.org/roh#AccreditationIssuer"></see></summary>
    let AccreditationIssuer =
        Namespaced_IRI.parse _namespace_name "AccreditationIssuer" |> NamespacedName

    /// <summary>
    /// An Accreditation Issuer which issues an Accreditation.
    /// <see href="http://w3id.org/roh#issues"></see></summary>
    let issues = Namespaced_IRI.parse _namespace_name "issues" |> NamespacedName

    /// <summary>
    /// An Activity participated by an Entity.
    /// <see href="http://w3id.org/roh#participatedBy"></see></summary>
    let participatedBy =
        Namespaced_IRI.parse _namespace_name "participatedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#Administrative"></see>
    /// </summary>
    let Administrative =
        Namespaced_IRI.parse _namespace_name "Administrative" |> NamespacedName

    /// <summary>
    /// This vertical module in ASIO models all the relevant administrative bodies ("Administración Autonómica") of Spain's Autonomous Communities (conserjerías, departamentos, secretarías) that might have a role (funding, participating) within the development of a given project. It is modeled hierarchically through the relevant administrative levels thereof.
    /// <see href="http://w3id.org/roh#AdministrativeEntity"></see></summary>
    let AdministrativeEntity =
        Namespaced_IRI.parse _namespace_name "AdministrativeEntity" |> NamespacedName

    /// <summary>
    /// relates a Metric to the entity it describes
    /// <see href="http://w3id.org/roh#metricOf"></see></summary>
    let metricOf = Namespaced_IRI.parse _namespace_name "metricOf" |> NamespacedName

    /// <summary>
    /// the number of times a publication has been cited (when used in PublicationMetric) or the total number of citations for all of an author's works (when used in AuthorMetric)
    /// <see href="http://w3id.org/roh#citationCount"></see></summary>
    let citationCount =
        Namespaced_IRI.parse _namespace_name "citationCount" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#h-index"></see>
    /// </summary>
    let ``h-index`` = Namespaced_IRI.parse _namespace_name "h-index" |> NamespacedName

    /// <summary>
    /// A property to express the i10-index of an author.
    /// <see href="http://w3id.org/roh#i10-index"></see></summary>
    let ``i10-index`` =
        Namespaced_IRI.parse _namespace_name "i10-index" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#BachelorsDegreeSubject"></see>
    /// </summary>
    let BachelorsDegreeSubject =
        Namespaced_IRI.parse _namespace_name "BachelorsDegreeSubject" |> NamespacedName

    /// <summary>
    /// Some Thing producing some entity.
    /// <see href="http://w3id.org/roh#produces"></see></summary>
    let produces = Namespaced_IRI.parse _namespace_name "produces" |> NamespacedName

    /// <summary>
    /// This entity defines a BitBucket Repository (https://bitbucket.org).
    /// <see href="http://w3id.org/roh#BitBucketRepository"></see></summary>
    let BitBucketRepository =
        Namespaced_IRI.parse _namespace_name "BitBucketRepository" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#hasPredecessor"></see>
    /// </summary>
    let hasPredecessor =
        Namespaced_IRI.parse _namespace_name "hasPredecessor" |> NamespacedName

    /// <summary>
    /// An object property linking a CV to the person it belongs to.
    /// <see href="http://w3id.org/roh#CVOf"></see></summary>
    let CVOf = Namespaced_IRI.parse _namespace_name "CVOf" |> NamespacedName

    /// <summary>
    /// roh:CurriculumVitae adds extra fields necessary to be able to complete the CV of a foaf:Person which cannot be extracted from the relationships with roh:ResearchObject and vivo:Project, among others, that a foaf:Person may have.
    /// A document used and created by a person to present their background, skills and accomplishments.
    /// <see href="http://w3id.org/roh#CurriculumVitae"></see></summary>
    let CurriculumVitae =
        Namespaced_IRI.parse _namespace_name "CurriculumVitae" |> NamespacedName

    /// <summary>
    /// An object property linking a Person with her CV.
    /// <see href="http://w3id.org/roh#hasCV"></see></summary>
    let hasCV = Namespaced_IRI.parse _namespace_name "hasCV" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/roh#Cancelled"></see>
    /// </summary>
    let Cancelled = Namespaced_IRI.parse _namespace_name "Cancelled" |> NamespacedName
    /// <summary>
    /// A qualitative descriptive research study of individuals or a group.
    /// <see href="http://w3id.org/roh#CaseStudy"></see></summary>
    let CaseStudy = Namespaced_IRI.parse _namespace_name "CaseStudy" |> NamespacedName
    /// <summary>
    /// A list of items in a collection; an ordered compilation of item descriptions and sufficient information to afford access to them.
    /// <see href="http://w3id.org/roh#Catalog"></see></summary>
    let Catalog = Namespaced_IRI.parse _namespace_name "Catalog" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/roh#Closed"></see>
    /// </summary>
    let Closed = Namespaced_IRI.parse _namespace_name "Closed" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/roh#Contest"></see>
    /// </summary>
    let Contest = Namespaced_IRI.parse _namespace_name "Contest" |> NamespacedName
    /// <summary>
    /// A textual summary of the Curriculum Vitae
    /// <see href="http://w3id.org/roh#summary"></see></summary>
    let summary = Namespaced_IRI.parse _namespace_name "summary" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/roh#Database"></see>
    /// </summary>
    let Database = Namespaced_IRI.parse _namespace_name "Database" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#DisseminationEvent"></see>
    /// </summary>
    let DisseminationEvent =
        Namespaced_IRI.parse _namespace_name "DisseminationEvent" |> NamespacedName

    /// <summary>
    /// File is a collection in which all assets related to a Project are stored, including the Research Proposal, approval documents, viability plans and so on associated to a project are stored.
    /// <see href="http://w3id.org/roh#Dossier"></see></summary>
    let Dossier = Namespaced_IRI.parse _namespace_name "Dossier" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#EditedPublication"></see>
    /// </summary>
    let EditedPublication =
        Namespaced_IRI.parse _namespace_name "EditedPublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#EthicalAudit"></see>
    /// </summary>
    let EthicalAudit =
        Namespaced_IRI.parse _namespace_name "EthicalAudit" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#EthicalValidation"></see>
    /// </summary>
    let EthicalValidation =
        Namespaced_IRI.parse _namespace_name "EthicalValidation" |> NamespacedName

    /// <summary>
    /// The status of a Document (Accepted or Rejected).
    /// <see href="http://w3id.org/roh#documentStatus"></see></summary>
    let documentStatus =
        Namespaced_IRI.parse _namespace_name "documentStatus" |> NamespacedName

    /// <summary>
    /// A fund allocated by the European Union. It finances direct payments to farmers under the Common Agricultural Policy (CAP) and measures to regulate agricultural markets such as intervention and export refunds.
    /// <see href="http://w3id.org/roh#EuropeanAgriculturalGuaranteeFund"></see></summary>
    let EuropeanAgriculturalGuaranteeFund =
        Namespaced_IRI.parse _namespace_name "EuropeanAgriculturalGuaranteeFund" |> NamespacedName

    /// <summary>
    /// The EMFF is the fund for the EU's maritime and fisheries policies for 2014-2020.
    /// <see href="http://w3id.org/roh#EuropeanMaritimeAndFisheriesFund"></see></summary>
    let EuropeanMaritimeAndFisheriesFund =
        Namespaced_IRI.parse _namespace_name "EuropeanMaritimeAndFisheriesFund" |> NamespacedName

    /// <summary>
    /// A fund allocated by the European Union. Its purpose is to transfer money from richer regions (not countries), and invest it in the infrastructure and services of underdeveloped regions. This will allow those regions to start attracting private sector investments, and create jobs on their own.
    /// <see href="http://w3id.org/roh#EuropeanRegionalDevelopmentFund"></see></summary>
    let EuropeanRegionalDevelopmentFund =
        Namespaced_IRI.parse _namespace_name "EuropeanRegionalDevelopmentFund" |> NamespacedName

    /// <summary>
    /// It is one of the European Structural and Investment Funds (ESIF), which are dedicated to improving social cohesion and economic well-being across the regions of the Union. The funds are redistributive financial instruments that support cohesion within Europe by concentrating spending on the less-developed regions.
    /// <see href="http://w3id.org/roh#EuropeanSocialFund"></see></summary>
    let EuropeanSocialFund =
        Namespaced_IRI.parse _namespace_name "EuropeanSocialFund" |> NamespacedName

    /// <summary>
    /// The status in which a Evaluation Summary could be.
    /// <see href="http://w3id.org/roh#evaluationStatus"></see></summary>
    let evaluationStatus =
        Namespaced_IRI.parse _namespace_name "evaluationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#Final"></see>
    /// </summary>
    let Final = Namespaced_IRI.parse _namespace_name "Final" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#Provisional"></see>
    /// </summary>
    let Provisional =
        Namespaced_IRI.parse _namespace_name "Provisional" |> NamespacedName

    /// <summary>
    /// A role of organising cientific events, such as conferences, workshops, etc.
    /// <see href="http://w3id.org/roh#EventOrganiser"></see></summary>
    let EventOrganiser =
        Namespaced_IRI.parse _namespace_name "EventOrganiser" |> NamespacedName

    /// <summary>
    /// Data property used by roh:Funding and roh:FundingAmount
    /// <see href="http://w3id.org/roh#currency"></see></summary>
    let currency = Namespaced_IRI.parse _namespace_name "currency" |> NamespacedName

    /// <summary>
    /// Data property used by roh:Funding and roh:FundingAmount
    /// <see href="http://w3id.org/roh#monetaryAmount"></see></summary>
    let monetaryAmount =
        Namespaced_IRI.parse _namespace_name "monetaryAmount" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#hasExpenseClassification"></see>
    /// </summary>
    let hasExpenseClassification =
        Namespaced_IRI.parse _namespace_name "hasExpenseClassification" |> NamespacedName

    /// <summary>
    /// A free text property to represent the modality of an Expense.
    /// <see href="http://w3id.org/roh#expenseModality"></see></summary>
    let expenseModality =
        Namespaced_IRI.parse _namespace_name "expenseModality" |> NamespacedName

    /// <summary>
    /// A core relation that holds between a whole, that in this case is an Repository, and its part .
    /// <see href="http://w3id.org/roh#repositoryHasPart"></see></summary>
    let repositoryHasPart =
        Namespaced_IRI.parse _namespace_name "repositoryHasPart" |> NamespacedName

    /// <summary>
    /// Document that contains the result or execution of a Experimental Protocol.
    /// <see href="http://w3id.org/roh#ExperimentalProtocolResult"></see></summary>
    let ExperimentalProtocolResult =
        Namespaced_IRI.parse _namespace_name "ExperimentalProtocolResult" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#language"></see>
    /// </summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName

    /// <summary>
    /// An object property linking an Entity to a Person, considered the author of such Thing.
    /// <see href="http://w3id.org/roh#correspondingAuthor"></see></summary>
    let correspondingAuthor =
        Namespaced_IRI.parse _namespace_name "correspondingAuthor" |> NamespacedName

    /// <summary>
    /// An unordered list of authors.
    /// <see href="http://w3id.org/roh#seqOfAuthors"></see></summary>
    let seqOfAuthors =
        Namespaced_IRI.parse _namespace_name "seqOfAuthors" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#partOfResearchResult"></see>
    /// </summary>
    let partOfResearchResult =
        Namespaced_IRI.parse _namespace_name "partOfResearchResult" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#ResearchResult"></see>
    /// </summary>
    let ResearchResult =
        Namespaced_IRI.parse _namespace_name "ResearchResult" |> NamespacedName

    /// <summary>
    /// A retired professor who has retained their rank, title and privileges.
    /// <see href="http://w3id.org/roh#FacultyPositionEmeritus"></see></summary>
    let FacultyPositionEmeritus =
        Namespaced_IRI.parse _namespace_name "FacultyPositionEmeritus" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#Funded"></see>
    /// </summary>
    let Funded = Namespaced_IRI.parse _namespace_name "Funded" |> NamespacedName
    /// <summary>
    /// An object property linking a Thing when is funded by another Thing.
    /// <see href="http://w3id.org/roh#fundedBy"></see></summary>
    let fundedBy = Namespaced_IRI.parse _namespace_name "fundedBy" |> NamespacedName

    /// <summary>
    /// To tag something as public (true) or private (false)
    /// <see href="http://w3id.org/roh#publicFunding"></see></summary>
    let publicFunding =
        Namespaced_IRI.parse _namespace_name "publicFunding" |> NamespacedName

    /// <summary>
    /// An object property linking an Entity to a Contract.
    /// <see href="http://w3id.org/roh#hasContract"></see></summary>
    let hasContract =
        Namespaced_IRI.parse _namespace_name "hasContract" |> NamespacedName

    /// <summary>
    /// An object property linking a FundingAmount with an Organization.
    /// <see href="http://w3id.org/roh#grants"></see></summary>
    let grants = Namespaced_IRI.parse _namespace_name "grants" |> NamespacedName
    /// <summary>
    /// A Funding Program or Funding Source promoted by a Funding Organization.
    /// <see href="http://w3id.org/roh#promotedBy"></see></summary>
    let promotedBy = Namespaced_IRI.parse _namespace_name "promotedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#hasFundingProgramClassification"></see>
    /// </summary>
    let hasFundingProgramClassification =
        Namespaced_IRI.parse _namespace_name "hasFundingProgramClassification" |> NamespacedName

    /// <summary>
    /// An object property linking a Thing when it funds another Thing.
    /// <see href="http://w3id.org/roh#funds"></see></summary>
    let funds = Namespaced_IRI.parse _namespace_name "funds" |> NamespacedName

    /// <summary>
    /// It's a concrete Repository that is stored in https://github.com.
    /// <see href="http://w3id.org/roh#GitHubRepository"></see></summary>
    let GitHubRepository =
        Namespaced_IRI.parse _namespace_name "GitHubRepository" |> NamespacedName

    /// <summary>
    /// A Project supported by a Funding.
    /// <see href="http://w3id.org/roh#isSupportedBy"></see></summary>
    let isSupportedBy =
        Namespaced_IRI.parse _namespace_name "isSupportedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#patentStatus"></see>
    /// </summary>
    let patentStatus =
        Namespaced_IRI.parse _namespace_name "patentStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#Rejected"></see>
    /// </summary>
    let Rejected = Namespaced_IRI.parse _namespace_name "Rejected" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/roh#Submitted"></see>
    /// </summary>
    let Submitted = Namespaced_IRI.parse _namespace_name "Submitted" |> NamespacedName

    /// <summary>
    /// A roh:ResearchObject is generated by one to several foaf:Person specified through property bibo:authorList. Usually a roh:ResearchObject results from the work in a vivo:Project (roh:produces). An elaborated taxonomy of research objects is provided, covering all types of publications, Patents, Software and Webpage. The main author of a research object is accessible through property roh:correspondingAuthor.
    /// <see href="http://w3id.org/roh#ResearchObject"></see></summary>
    let ResearchObject =
        Namespaced_IRI.parse _namespace_name "ResearchObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#hasPropertyClassification"></see>
    /// </summary>
    let hasPropertyClassification =
        Namespaced_IRI.parse _namespace_name "hasPropertyClassification" |> NamespacedName

    /// <summary>
    /// An entity spending an Expense.
    /// <see href="http://w3id.org/roh#spends"></see></summary>
    let spends = Namespaced_IRI.parse _namespace_name "spends" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#PatentApplication"></see>
    /// </summary>
    let PatentApplication =
        Namespaced_IRI.parse _namespace_name "PatentApplication" |> NamespacedName

    /// <summary>
    /// This is the metric of a jorunal. When the journal metric is updated, a new journal metric must be created with the same impactFactorName but with the updated impactFactor, ranking and quartile values.
    /// <see href="http://w3id.org/roh#JournalMetric"></see></summary>
    let JournalMetric =
        Namespaced_IRI.parse _namespace_name "JournalMetric" |> NamespacedName

    /// <summary>
    /// A scientometric index that reflects the yearly average number of citations that articles published in the last two years in a given journal received.
    /// <see href="http://w3id.org/roh#impactFactor"></see></summary>
    let impactFactor =
        Namespaced_IRI.parse _namespace_name "impactFactor" |> NamespacedName

    /// <summary>
    /// The ranking of a scientific publication.
    /// <see href="http://w3id.org/roh#ranking"></see></summary>
    let ranking = Namespaced_IRI.parse _namespace_name "ranking" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#impactFactorName"></see>
    /// </summary>
    let impactFactorName =
        Namespaced_IRI.parse _namespace_name "impactFactorName" |> NamespacedName

    /// <summary>
    /// The quartile to which a Journal publication belongs.
    /// <see href="http://w3id.org/roh#quartile"></see></summary>
    let quartile = Namespaced_IRI.parse _namespace_name "quartile" |> NamespacedName

    /// <summary>
    /// The ability to understand spoken language.
    /// <see href="http://w3id.org/roh#listeningSkill"></see></summary>
    let listeningSkill =
        Namespaced_IRI.parse _namespace_name "listeningSkill" |> NamespacedName

    /// <summary>
    /// The ability to write into a certain language.
    /// <see href="http://w3id.org/roh#writingSkill"></see></summary>
    let writingSkill =
        Namespaced_IRI.parse _namespace_name "writingSkill" |> NamespacedName

    /// <summary>
    /// The ability to participate into a conversation.
    /// <see href="http://w3id.org/roh#spokenInteractionSkill"></see></summary>
    let spokenInteractionSkill =
        Namespaced_IRI.parse _namespace_name "spokenInteractionSkill" |> NamespacedName

    /// <summary>
    /// The ability to understand written text.
    /// <see href="http://w3id.org/roh#readingSkill"></see></summary>
    let readingSkill =
        Namespaced_IRI.parse _namespace_name "readingSkill" |> NamespacedName

    /// <summary>
    /// The language to which refers the Language Certificate.
    /// <see href="http://w3id.org/roh#languageOfTheCertificate"></see></summary>
    let languageOfTheCertificate =
        Namespaced_IRI.parse _namespace_name "languageOfTheCertificate" |> NamespacedName

    /// <summary>
    /// The ability to speak a language.
    /// <see href="http://w3id.org/roh#speakingSkill"></see></summary>
    let speakingSkill =
        Namespaced_IRI.parse _namespace_name "speakingSkill" |> NamespacedName

    /// <summary>
    /// A retired librarian who has retained their rank, title and privileges.
    /// <see href="http://w3id.org/roh#LibrarianPositionEmeritus"></see></summary>
    let LibrarianPositionEmeritus =
        Namespaced_IRI.parse _namespace_name "LibrarianPositionEmeritus" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#ManagementUnit"></see>
    /// </summary>
    let ManagementUnit =
        Namespaced_IRI.parse _namespace_name "ManagementUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#MastersDegreeSubject"></see>
    /// </summary>
    let MastersDegreeSubject =
        Namespaced_IRI.parse _namespace_name "MastersDegreeSubject" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#MastersStudent"></see>
    /// </summary>
    let MastersStudent =
        Namespaced_IRI.parse _namespace_name "MastersStudent" |> NamespacedName

    /// <summary>
    /// The name of a Metric.
    /// <see href="http://w3id.org/roh#metricName"></see></summary>
    let metricName = Namespaced_IRI.parse _namespace_name "metricName" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/roh#ORCID"></see>
    /// </summary>
    let ORCID = Namespaced_IRI.parse _namespace_name "ORCID" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/roh#Open"></see>
    /// </summary>
    let Open = Namespaced_IRI.parse _namespace_name "Open" |> NamespacedName
    /// <summary>
    /// A group of people gathered to discuss a topic in front of an audience, typically at scientific, business, or academic conferences, fan conventions, and on television shows. Panels usually include a moderator who guides the discussion and sometimes elicits audience questions, with the goal of being informative and entertaining
    /// <see href="http://w3id.org/roh#PanelTalk"></see></summary>
    let PanelTalk = Namespaced_IRI.parse _namespace_name "PanelTalk" |> NamespacedName

    /// <summary>
    /// A Patent has an Organization who owns it.
    /// <see href="http://w3id.org/roh#ownerOrganization"></see></summary>
    let ownerOrganization =
        Namespaced_IRI.parse _namespace_name "ownerOrganization" |> NamespacedName

    /// <summary>
    /// The position a person has inside its organization.
    /// <see href="http://w3id.org/roh#hasHRClassification"></see></summary>
    let hasHRClassification =
        Namespaced_IRI.parse _namespace_name "hasHRClassification" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#PhDThesisMetric"></see>
    /// </summary>
    let PhDThesisMetric =
        Namespaced_IRI.parse _namespace_name "PhDThesisMetric" |> NamespacedName

    /// <summary>
    /// Meaning "with praise", used to indicate the level of distinction with which an academic degree has been earned.
    /// <see href="http://w3id.org/roh#cumLaude"></see></summary>
    let cumLaude = Namespaced_IRI.parse _namespace_name "cumLaude" |> NamespacedName
    /// <summary>
    /// A judgment, expressed as a number or letter, about the quality of a work.
    /// <see href="http://w3id.org/roh#mark"></see></summary>
    let mark = Namespaced_IRI.parse _namespace_name "mark" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#ThesisMetric"></see>
    /// </summary>
    let ThesisMetric =
        Namespaced_IRI.parse _namespace_name "ThesisMetric" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#ProformaInvoice"></see>
    /// </summary>
    let ProformaInvoice =
        Namespaced_IRI.parse _namespace_name "ProformaInvoice" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#ProposalSubmitted"></see>
    /// </summary>
    let ProposalSubmitted =
        Namespaced_IRI.parse _namespace_name "ProposalSubmitted" |> NamespacedName

    /// <summary>
    /// A product prototype
    /// <see href="http://w3id.org/roh#Prototype"></see></summary>
    let Prototype = Namespaced_IRI.parse _namespace_name "Prototype" |> NamespacedName
    /// <summary>
    /// The document named README that describe the content of a concret Repository.
    /// <see href="http://w3id.org/roh#README"></see></summary>
    let README = Namespaced_IRI.parse _namespace_name "README" |> NamespacedName
    /// <summary>
    /// This object property is used to specify the Repository or Software of a given README document.
    /// <see href="http://w3id.org/roh#readmeOf"></see></summary>
    let readmeOf = Namespaced_IRI.parse _namespace_name "readmeOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#RadioProgram"></see>
    /// </summary>
    let RadioProgram =
        Namespaced_IRI.parse _namespace_name "RadioProgram" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TvProgram"></see>
    /// </summary>
    let TvProgram = Namespaced_IRI.parse _namespace_name "TvProgram" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#repositoryStatus"></see>
    /// </summary>
    let repositoryStatus =
        Namespaced_IRI.parse _namespace_name "repositoryStatus" |> NamespacedName

    /// <summary>
    /// This object property is used to specify the README document of a given  Respository or Software.
    /// <see href="http://w3id.org/roh#hasReadme"></see></summary>
    let hasReadme = Namespaced_IRI.parse _namespace_name "hasReadme" |> NamespacedName
    /// <summary>
    /// Esta propiedad nos permite especificar la licencia (vivo:License) de una instancia.
    /// This object property is used to specify the licence (vivo:License) of a given instance.
    /// <see href="http://w3id.org/roh#hasLicense"></see></summary>
    let hasLicense = Namespaced_IRI.parse _namespace_name "hasLicense" |> NamespacedName

    /// <summary>
    /// Represents if an Entity has an excellence label or some kind of mention.
    /// <see href="http://w3id.org/roh#excellenceLabel"></see></summary>
    let excellenceLabel =
        Namespaced_IRI.parse _namespace_name "excellenceLabel" |> NamespacedName

    /// <summary>
    /// An establishment founded for doing research.
    /// <see href="http://w3id.org/roh#ResearchInstitute"></see></summary>
    let ResearchInstitute =
        Namespaced_IRI.parse _namespace_name "ResearchInstitute" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#ResearchMaterial"></see>
    /// </summary>
    let ResearchMaterial =
        Namespaced_IRI.parse _namespace_name "ResearchMaterial" |> NamespacedName

    /// <summary>
    /// Some entity producing some Thing.
    /// <see href="http://w3id.org/roh#producedBy"></see></summary>
    let producedBy = Namespaced_IRI.parse _namespace_name "producedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#hasSucessor"></see>
    /// </summary>
    let hasSucessor =
        Namespaced_IRI.parse _namespace_name "hasSucessor" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#researchResultHasPart"></see>
    /// </summary>
    let researchResultHasPart =
        Namespaced_IRI.parse _namespace_name "researchResultHasPart" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#Researching"></see>
    /// </summary>
    let Researching =
        Namespaced_IRI.parse _namespace_name "Researching" |> NamespacedName

    /// <summary>
    /// Some resources may available by an organization to be used by others.
    /// <see href="http://w3id.org/roh#Reservable"></see></summary>
    let Reservable = Namespaced_IRI.parse _namespace_name "Reservable" |> NamespacedName

    /// <summary>
    /// An Infrastructure belonging to an Agent.
    /// <see href="http://w3id.org/roh#reservableOf"></see></summary>
    let reservableOf =
        Namespaced_IRI.parse _namespace_name "reservableOf" |> NamespacedName

    /// <summary>
    /// Software that is reservable.
    /// <see href="http://w3id.org/roh#ReservableSoftware"></see></summary>
    let ReservableSoftware =
        Namespaced_IRI.parse _namespace_name "ReservableSoftware" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#ReservationRelationship"></see>
    /// </summary>
    let ReservationRelationship =
        Namespaced_IRI.parse _namespace_name "ReservationRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#RoundTable"></see>
    /// </summary>
    let RoundTable = Namespaced_IRI.parse _namespace_name "RoundTable" |> NamespacedName

    /// <summary>
    /// A graphic mark indicating highest levels of quality in research, often measured in terms of relevant publications related to the researching activity.
    /// <see href="http://w3id.org/roh#SealOfQuality"></see></summary>
    let SealOfQuality =
        Namespaced_IRI.parse _namespace_name "SealOfQuality" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#ServiceContract"></see>
    /// </summary>
    let ServiceContract =
        Namespaced_IRI.parse _namespace_name "ServiceContract" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#Signed"></see>
    /// </summary>
    let Signed = Namespaced_IRI.parse _namespace_name "Signed" |> NamespacedName
    /// <summary>
    /// The Role held by an Agent in a Relationship.
    /// <see href="http://w3id.org/roh#roleOf"></see></summary>
    let roleOf = Namespaced_IRI.parse _namespace_name "roleOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/roh#Teaching"></see>
    /// </summary>
    let Teaching = Namespaced_IRI.parse _namespace_name "Teaching" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TechnicalReport"></see>
    /// </summary>
    let TechnicalReport =
        Namespaced_IRI.parse _namespace_name "TechnicalReport" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TechnicalSupport"></see>
    /// </summary>
    let TechnicalSupport =
        Namespaced_IRI.parse _namespace_name "TechnicalSupport" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#Terminated"></see>
    /// </summary>
    let Terminated = Namespaced_IRI.parse _namespace_name "Terminated" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestAnotherGovernmentAgency"></see>
    /// </summary>
    let TestAnotherGovernmentAgency =
        Namespaced_IRI.parse _namespace_name "TestAnotherGovernmentAgency" |> NamespacedName

    /// <summary>
    /// A Funding Organization which promotes a Funding Program or a Funding Source.
    /// <see href="http://w3id.org/roh#promotes"></see></summary>
    let promotes = Namespaced_IRI.parse _namespace_name "promotes" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestFundingSource"></see>
    /// </summary>
    let TestFundingSource =
        Namespaced_IRI.parse _namespace_name "TestFundingSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestBook"></see>
    /// </summary>
    let TestBook = Namespaced_IRI.parse _namespace_name "TestBook" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestListofEditors"></see>
    /// </summary>
    let TestListofEditors =
        Namespaced_IRI.parse _namespace_name "TestListofEditors" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestChapterOne"></see>
    /// </summary>
    let TestChapterOne =
        Namespaced_IRI.parse _namespace_name "TestChapterOne" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestListofAuthors"></see>
    /// </summary>
    let TestListofAuthors =
        Namespaced_IRI.parse _namespace_name "TestListofAuthors" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestChapterThree"></see>
    /// </summary>
    let TestChapterThree =
        Namespaced_IRI.parse _namespace_name "TestChapterThree" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestChapterTwo"></see>
    /// </summary>
    let TestChapterTwo =
        Namespaced_IRI.parse _namespace_name "TestChapterTwo" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestCoSupervisorRole"></see>
    /// </summary>
    let TestCoSupervisorRole =
        Namespaced_IRI.parse _namespace_name "TestCoSupervisorRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestPhdCoSupervisor"></see>
    /// </summary>
    let TestPhdCoSupervisor =
        Namespaced_IRI.parse _namespace_name "TestPhdCoSupervisor" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestPhDSupervisingRelationship"></see>
    /// </summary>
    let TestPhDSupervisingRelationship =
        Namespaced_IRI.parse _namespace_name "TestPhDSupervisingRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestDateTimeInterval"></see>
    /// </summary>
    let TestDateTimeInterval =
        Namespaced_IRI.parse _namespace_name "TestDateTimeInterval" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestEndDateTimeValue"></see>
    /// </summary>
    let TestEndDateTimeValue =
        Namespaced_IRI.parse _namespace_name "TestEndDateTimeValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestStartDateTimeValue"></see>
    /// </summary>
    let TestStartDateTimeValue =
        Namespaced_IRI.parse _namespace_name "TestStartDateTimeValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestFundingProgram"></see>
    /// </summary>
    let TestFundingProgram =
        Namespaced_IRI.parse _namespace_name "TestFundingProgram" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestGovernmentAgency"></see>
    /// </summary>
    let TestGovernmentAgency =
        Namespaced_IRI.parse _namespace_name "TestGovernmentAgency" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestNonResearchSoftware"></see>
    /// </summary>
    let TestNonResearchSoftware =
        Namespaced_IRI.parse _namespace_name "TestNonResearchSoftware" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestOrganization"></see>
    /// </summary>
    let TestOrganization =
        Namespaced_IRI.parse _namespace_name "TestOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestPhDStudent"></see>
    /// </summary>
    let TestPhDStudent =
        Namespaced_IRI.parse _namespace_name "TestPhDStudent" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestPhdSupervisor"></see>
    /// </summary>
    let TestPhdSupervisor =
        Namespaced_IRI.parse _namespace_name "TestPhdSupervisor" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestProject"></see>
    /// </summary>
    let TestProject =
        Namespaced_IRI.parse _namespace_name "TestProject" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestSuperviseeRole"></see>
    /// </summary>
    let TestSuperviseeRole =
        Namespaced_IRI.parse _namespace_name "TestSuperviseeRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#TestSupervisorRole"></see>
    /// </summary>
    let TestSupervisorRole =
        Namespaced_IRI.parse _namespace_name "TestSupervisorRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#UndergraduateStudent"></see>
    /// </summary>
    let UndergraduateStudent =
        Namespaced_IRI.parse _namespace_name "UndergraduateStudent" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#Unfunded"></see>
    /// </summary>
    let Unfunded = Namespaced_IRI.parse _namespace_name "Unfunded" |> NamespacedName

    /// <summary>
    /// A division within a university (school, faculty, etc.)
    /// <see href="http://w3id.org/roh#UniversityDivision"></see></summary>
    let UniversityDivision =
        Namespaced_IRI.parse _namespace_name "UniversityDivision" |> NamespacedName

    /// <summary>
    /// A paper published on a conference workshop.
    /// <see href="http://w3id.org/roh#WorkshopPaper"></see></summary>
    let WorkshopPaper =
        Namespaced_IRI.parse _namespace_name "WorkshopPaper" |> NamespacedName

    /// <summary>
    /// It`s a Zenodo Repository that we can find in https://zenodo.org.
    /// <see href="http://w3id.org/roh#ZenodoRepository"></see></summary>
    let ZenodoRepository =
        Namespaced_IRI.parse _namespace_name "ZenodoRepository" |> NamespacedName

    /// <summary>
    /// An object property linking an Accreditation to the Agent is associated with.
    /// <see href="http://w3id.org/roh#accreditationOf"></see></summary>
    let accreditationOf =
        Namespaced_IRI.parse _namespace_name "accreditationOf" |> NamespacedName

    /// <summary>
    /// An object property linking an Agent with an Accreditation it posseses.
    /// <see href="http://w3id.org/roh#hasAccreditation"></see></summary>
    let hasAccreditation =
        Namespaced_IRI.parse _namespace_name "hasAccreditation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#addresses"></see>
    /// </summary>
    let addresses = Namespaced_IRI.parse _namespace_name "addresses" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/roh#advises"></see>
    /// </summary>
    let advises = Namespaced_IRI.parse _namespace_name "advises" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#isAdvisedBy"></see>
    /// </summary>
    let isAdvisedBy =
        Namespaced_IRI.parse _namespace_name "isAdvisedBy" |> NamespacedName

    /// <summary>
    /// an organisation (i.e. university) is associated with another organsiation (i.e. research institute).
    /// <see href="http://w3id.org/roh#associatedWith"></see></summary>
    let associatedWith =
        Namespaced_IRI.parse _namespace_name "associatedWith" |> NamespacedName

    /// <summary>
    /// An object property describing a not machine-readable document attached to an entity offering more detailed information.
    /// <see href="http://w3id.org/roh#attachment"></see></summary>
    let attachment = Namespaced_IRI.parse _namespace_name "attachment" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/roh#authors"></see>
    /// </summary>
    let authors = Namespaced_IRI.parse _namespace_name "authors" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#isAuthoredBy"></see>
    /// </summary>
    let isAuthoredBy =
        Namespaced_IRI.parse _namespace_name "isAuthoredBy" |> NamespacedName

    /// <summary>
    /// An object property linking an AwardedDegree to the University that awarded it.
    /// <see href="http://w3id.org/roh#awardedBy"></see></summary>
    let awardedBy = Namespaced_IRI.parse _namespace_name "awardedBy" |> NamespacedName
    /// <summary>
    /// An object property linking the University awarding a degree to the AwardedDegree.
    /// <see href="http://w3id.org/roh#awards"></see></summary>
    let awards = Namespaced_IRI.parse _namespace_name "awards" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#awardedWith"></see>
    /// </summary>
    let awardedWith =
        Namespaced_IRI.parse _namespace_name "awardedWith" |> NamespacedName

    /// <summary>
    /// The birthdate of an Entity.
    /// <see href="http://w3id.org/roh#birthdate"></see></summary>
    let birthdate = Namespaced_IRI.parse _namespace_name "birthdate" |> NamespacedName

    /// <summary>
    /// An academic publication (bachelor's thesis, master's thesis or doctoral thesis) is co-advised by an advisor.
    /// <see href="http://w3id.org/roh#coadvisedBy"></see></summary>
    let coadvisedBy =
        Namespaced_IRI.parse _namespace_name "coadvisedBy" |> NamespacedName

    /// <summary>
    /// A person co-advises an academic publication (bachelor's thesis, master's thesis or doctoral thesis).
    /// <see href="http://w3id.org/roh#coadvises"></see></summary>
    let coadvises = Namespaced_IRI.parse _namespace_name "coadvises" |> NamespacedName
    /// <summary>
    /// A code is assigned to a concept.
    /// <see href="http://w3id.org/roh#codeOf"></see></summary>
    let codeOf = Namespaced_IRI.parse _namespace_name "codeOf" |> NamespacedName
    /// <summary>
    /// A concept can be asigned a code.
    /// <see href="http://w3id.org/roh#hasCode"></see></summary>
    let hasCode = Namespaced_IRI.parse _namespace_name "hasCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#companyFounder"></see>
    /// </summary>
    let companyFounder =
        Namespaced_IRI.parse _namespace_name "companyFounder" |> NamespacedName

    /// <summary>
    /// Specifies the contact info of type vcard:Kind for an Agent.
    /// <see href="http://w3id.org/roh#contactInfoOf"></see></summary>
    let contactInfoOf =
        Namespaced_IRI.parse _namespace_name "contactInfoOf" |> NamespacedName

    /// <summary>
    /// An Agent has a contact info of type vcard:Kind.
    /// <see href="http://w3id.org/roh#hasContactInfo"></see></summary>
    let hasContactInfo =
        Namespaced_IRI.parse _namespace_name "hasContactInfo" |> NamespacedName

    /// <summary>
    /// An object property linking a Contract to an Entity.
    /// <see href="http://w3id.org/roh#contractOf"></see></summary>
    let contractOf = Namespaced_IRI.parse _namespace_name "contractOf" |> NamespacedName

    /// <summary>
    /// An object property linking a Contract with the date (DateTimeValue) when it was signed.
    /// <see href="http://w3id.org/roh#contractSigningDate"></see></summary>
    let contractSigningDate =
        Namespaced_IRI.parse _namespace_name "contractSigningDate" |> NamespacedName

    /// <summary>
    /// An object property linking a signing date (DateTimeValue) with a Contract.
    /// <see href="http://w3id.org/roh#contractSigningDateOf"></see></summary>
    let contractSigningDateOf =
        Namespaced_IRI.parse _namespace_name "contractSigningDateOf" |> NamespacedName

    /// <summary>
    /// inverse property of 'project coordinator'
    /// <see href="http://w3id.org/roh#coordinatedBy"></see></summary>
    let coordinatedBy =
        Namespaced_IRI.parse _namespace_name "coordinatedBy" |> NamespacedName

    /// <summary>
    /// An object property linking a Person with a Thing, such person is corresponding author for.
    /// <see href="http://w3id.org/roh#correspondingAuthorOf"></see></summary>
    let correspondingAuthorOf =
        Namespaced_IRI.parse _namespace_name "correspondingAuthorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#correspondingOrganization"></see>
    /// </summary>
    let correspondingOrganization =
        Namespaced_IRI.parse _namespace_name "correspondingOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#correspondingOrganizationOf"></see>
    /// </summary>
    let correspondingOrganizationOf =
        Namespaced_IRI.parse _namespace_name "correspondingOrganizationOf" |> NamespacedName

    /// <summary>
    /// This property indicates the nationality of a resource. The domain is not set so unpredicted resources within the ontology could be attached to countries.
    /// <see href="http://w3id.org/roh#country"></see></summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName

    /// <summary>
    /// The number of hours a course lasts.
    /// <see href="http://w3id.org/roh#courseHours"></see></summary>
    let courseHours =
        Namespaced_IRI.parse _namespace_name "courseHours" |> NamespacedName

    /// <summary>
    /// The dedication which a Person dedicates to a Role.
    /// <see href="http://w3id.org/roh#dedication"></see></summary>
    let dedication = Namespaced_IRI.parse _namespace_name "dedication" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#dedicationPercentage"></see>
    /// </summary>
    let dedicationPercentage =
        Namespaced_IRI.parse _namespace_name "dedicationPercentage" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#employs"></see>
    /// </summary>
    let employs = Namespaced_IRI.parse _namespace_name "employs" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#expirationDate"></see>
    /// </summary>
    let expirationDate =
        Namespaced_IRI.parse _namespace_name "expirationDate" |> NamespacedName

    /// <summary>
    /// The date in which a Justificacion has to be delivered.
    /// <see href="http://w3id.org/roh#foreseenJustificationDate"></see></summary>
    let foreseenJustificationDate =
        Namespaced_IRI.parse _namespace_name "foreseenJustificationDate" |> NamespacedName

    /// <summary>
    /// Date in which an Organization was created.
    /// <see href="http://w3id.org/roh#foundationDate"></see></summary>
    let foundationDate =
        Namespaced_IRI.parse _namespace_name "foundationDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#freeOrPaid"></see>
    /// </summary>
    let freeOrPaid = Namespaced_IRI.parse _namespace_name "freeOrPaid" |> NamespacedName
    /// <summary>
    /// An object property linking an Organization with a FundingAmount.
    /// <see href="http://w3id.org/roh#grantedBy"></see></summary>
    let grantedBy = Namespaced_IRI.parse _namespace_name "grantedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#hasCompanyClassification"></see>
    /// </summary>
    let hasCompanyClassification =
        Namespaced_IRI.parse _namespace_name "hasCompanyClassification" |> NamespacedName

    /// <summary>
    /// The classification of the position of a Person.
    /// <see href="http://w3id.org/roh#hrClassificationOf"></see></summary>
    let hrClassificationOf =
        Namespaced_IRI.parse _namespace_name "hrClassificationOf" |> NamespacedName

    /// <summary>
    /// A skos:Concept which is the knowledge area of some entity.
    /// <see href="http://w3id.org/roh#knowledgeAreaOf"></see></summary>
    let knowledgeAreaOf =
        Namespaced_IRI.parse _namespace_name "knowledgeAreaOf" |> NamespacedName

    /// <summary>
    /// A Metric which quantifies a Research Object.
    /// <see href="http://w3id.org/roh#hasMetric"></see></summary>
    let hasMetric = Namespaced_IRI.parse _namespace_name "hasMetric" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/roh#hasPatent"></see>
    /// </summary>
    let hasPatent = Namespaced_IRI.parse _namespace_name "hasPatent" |> NamespacedName

    /// <summary>
    /// A Person has a Position in his/her Organization.
    /// <see href="http://w3id.org/roh#hasPosition"></see></summary>
    let hasPosition =
        Namespaced_IRI.parse _namespace_name "hasPosition" |> NamespacedName

    /// <summary>
    /// The Position of a Person within an Organization.
    /// <see href="http://w3id.org/roh#positionOf"></see></summary>
    let positionOf = Namespaced_IRI.parse _namespace_name "positionOf" |> NamespacedName

    /// <summary>
    /// A Project is categorized by different Project Classifications.
    /// <see href="http://w3id.org/roh#hasProjectClassification"></see></summary>
    let hasProjectClassification =
        Namespaced_IRI.parse _namespace_name "hasProjectClassification" |> NamespacedName

    /// <summary>
    /// A Project Classification which categorizes a Project.
    /// <see href="http://w3id.org/roh#projectClassificationOf"></see></summary>
    let projectClassificationOf =
        Namespaced_IRI.parse _namespace_name "projectClassificationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#hasResearchContribution"></see>
    /// </summary>
    let hasResearchContribution =
        Namespaced_IRI.parse _namespace_name "hasResearchContribution" |> NamespacedName

    /// <summary>
    /// An Agent who owns an infrastructure.
    /// <see href="http://w3id.org/roh#hasReservable"></see></summary>
    let hasReservable =
        Namespaced_IRI.parse _namespace_name "hasReservable" |> NamespacedName

    /// <summary>
    /// An Agent has a Role in a Relation.
    /// <see href="http://w3id.org/roh#hasRole"></see></summary>
    let hasRole = Namespaced_IRI.parse _namespace_name "hasRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#hasScientificDomain"></see>
    /// </summary>
    let hasScientificDomain =
        Namespaced_IRI.parse _namespace_name "hasScientificDomain" |> NamespacedName

    /// <summary>
    /// An Organization which has a spin off Company.
    /// <see href="http://w3id.org/roh#hasSpinoff"></see></summary>
    let hasSpinoff = Namespaced_IRI.parse _namespace_name "hasSpinoff" |> NamespacedName

    /// <summary>
    /// A Company which is an spinoff of an Organization.
    /// <see href="http://w3id.org/roh#isSpinfoffOf"></see></summary>
    let isSpinfoffOf =
        Namespaced_IRI.parse _namespace_name "isSpinfoffOf" |> NamespacedName

    /// <summary>
    /// A prototype has a given technology readiness level
    /// <see href="http://w3id.org/roh#hasTRL"></see></summary>
    let hasTRL = Namespaced_IRI.parse _namespace_name "hasTRL" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#isAwardedBy"></see>
    /// </summary>
    let isAwardedBy =
        Namespaced_IRI.parse _namespace_name "isAwardedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#isCompetitive"></see>
    /// </summary>
    let isCompetitive =
        Namespaced_IRI.parse _namespace_name "isCompetitive" |> NamespacedName

    /// <summary>
    /// A person is granted with a stipend for researching.
    /// <see href="http://w3id.org/roh#isGrantedWith"></see></summary>
    let isGrantedWith =
        Namespaced_IRI.parse _namespace_name "isGrantedWith" |> NamespacedName

    /// <summary>
    /// A Service provided by an Organization.
    /// <see href="http://w3id.org/roh#isProvidedBy"></see></summary>
    let isProvidedBy =
        Namespaced_IRI.parse _namespace_name "isProvidedBy" |> NamespacedName

    /// <summary>
    /// An Organization which provides a Service.
    /// <see href="http://w3id.org/roh#provides"></see></summary>
    let provides = Namespaced_IRI.parse _namespace_name "provides" |> NamespacedName
    /// <summary>
    /// To specify that a company is in its early stage of life.
    /// <see href="http://w3id.org/roh#isStartup"></see></summary>
    let isStartup = Namespaced_IRI.parse _namespace_name "isStartup" |> NamespacedName
    /// <summary>
    /// A Funding which supports a Person Contract or a Project.
    /// <see href="http://w3id.org/roh#supports"></see></summary>
    let supports = Namespaced_IRI.parse _namespace_name "supports" |> NamespacedName
    /// <summary>
    /// A numeric commercial book identifier which is intended to be unique.
    /// <see href="http://w3id.org/roh#isbn"></see></summary>
    let isbn = Namespaced_IRI.parse _namespace_name "isbn" |> NamespacedName
    /// <summary>
    /// An Accreditation issued by an Accreditation Issuer.
    /// <see href="http://w3id.org/roh#issuedBy"></see></summary>
    let issuedBy = Namespaced_IRI.parse _namespace_name "issuedBy" |> NamespacedName

    /// <summary>
    /// Different skills required by the Common European Framework of Reference for Languages: Learning, Teaching, Assessment.
    /// <see href="http://w3id.org/roh#languageSkill"></see></summary>
    let languageSkill =
        Namespaced_IRI.parse _namespace_name "languageSkill" |> NamespacedName

    /// <summary>
    /// A free text property to represent the modality of a Project.
    /// <see href="http://w3id.org/roh#modality"></see></summary>
    let modality = Namespaced_IRI.parse _namespace_name "modality" |> NamespacedName

    /// <summary>
    /// Represents if a Project needs to pass an ethical validation.
    /// <see href="http://w3id.org/roh#needsEthicalValidation"></see></summary>
    let needsEthicalValidation =
        Namespaced_IRI.parse _namespace_name "needsEthicalValidation" |> NamespacedName

    /// <summary>
    /// An Organization owning a Patent.
    /// <see href="http://w3id.org/roh#ownerOrganizationOf"></see></summary>
    let ownerOrganizationOf =
        Namespaced_IRI.parse _namespace_name "ownerOrganizationOf" |> NamespacedName

    /// <summary>
    /// A core relation that holds between a part and its hole, that in this case is a Repository.
    /// <see href="http://w3id.org/roh#partOfRepository"></see></summary>
    let partOfRepository =
        Namespaced_IRI.parse _namespace_name "partOfRepository" |> NamespacedName

    /// <summary>
    /// An Entity participating in an Activity.
    /// <see href="http://w3id.org/roh#participates"></see></summary>
    let participates =
        Namespaced_IRI.parse _namespace_name "participates" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#patentAssistantExaminer"></see>
    /// </summary>
    let patentAssistantExaminer =
        Namespaced_IRI.parse _namespace_name "patentAssistantExaminer" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#patentCountry"></see>
    /// </summary>
    let patentCountry =
        Namespaced_IRI.parse _namespace_name "patentCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#patentInventor"></see>
    /// </summary>
    let patentInventor =
        Namespaced_IRI.parse _namespace_name "patentInventor" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#patentPrimaryExaminer"></see>
    /// </summary>
    let patentPrimaryExaminer =
        Namespaced_IRI.parse _namespace_name "patentPrimaryExaminer" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#platform"></see>
    /// </summary>
    let platform = Namespaced_IRI.parse _namespace_name "platform" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#programmingLanguage"></see>
    /// </summary>
    let programmingLanguage =
        Namespaced_IRI.parse _namespace_name "programmingLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#projectAcronym"></see>
    /// </summary>
    let projectAcronym =
        Namespaced_IRI.parse _namespace_name "projectAcronym" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#projectID"></see>
    /// </summary>
    let projectID = Namespaced_IRI.parse _namespace_name "projectID" |> NamespacedName

    /// <summary>
    /// A defined objective of the project.
    /// <see href="http://w3id.org/roh#projectObjective"></see></summary>
    let projectObjective =
        Namespaced_IRI.parse _namespace_name "projectObjective" |> NamespacedName

    /// <summary>
    /// A project may be in a CLOSED, OPEN or in other future status that may be defined.
    /// <see href="http://w3id.org/roh#projectStatus"></see></summary>
    let projectStatus =
        Namespaced_IRI.parse _namespace_name "projectStatus" |> NamespacedName

    /// <summary>
    /// To define if a Company is public or not.
    /// <see href="http://w3id.org/roh#publicCompany"></see></summary>
    let publicCompany =
        Namespaced_IRI.parse _namespace_name "publicCompany" |> NamespacedName

    /// <summary>
    /// A reference law that establishes a position.
    /// <see href="http://w3id.org/roh#referencedLaw"></see></summary>
    let referencedLaw =
        Namespaced_IRI.parse _namespace_name "referencedLaw" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#requiredFor"></see>
    /// </summary>
    let requiredFor =
        Namespaced_IRI.parse _namespace_name "requiredFor" |> NamespacedName

    /// <summary>
    /// This property relates roles and their requisites, i.e. other roles.
    /// <see href="http://w3id.org/roh#requires"></see></summary>
    let requires = Namespaced_IRI.parse _namespace_name "requires" |> NamespacedName

    /// <summary>
    /// A free-text property to define the research line in which an Organization or Researcher is working on.
    /// <see href="http://w3id.org/roh#researchLine"></see></summary>
    let researchLine =
        Namespaced_IRI.parse _namespace_name "researchLine" |> NamespacedName

    /// <summary>
    /// a proerty to link a person to a publication as a reviewer.
    /// <see href="http://w3id.org/roh#reviews"></see></summary>
    let reviews = Namespaced_IRI.parse _namespace_name "reviews" |> NamespacedName

    /// <summary>
    /// The status of a Software  (Final or Provisional).
    /// <see href="http://w3id.org/roh#softwareStatus"></see></summary>
    let softwareStatus =
        Namespaced_IRI.parse _namespace_name "softwareStatus" |> NamespacedName

    /// <summary>
    /// An Expense spent by an Entity.
    /// <see href="http://w3id.org/roh#spentBy"></see></summary>
    let spentBy = Namespaced_IRI.parse _namespace_name "spentBy" |> NamespacedName

    /// <summary>
    /// A Thesis supervised by a Person.
    /// <see href="http://w3id.org/roh#supervisedBy"></see></summary>
    let supervisedBy =
        Namespaced_IRI.parse _namespace_name "supervisedBy" |> NamespacedName

    /// <summary>
    /// A Person supervising a Thesis.
    /// <see href="http://w3id.org/roh#supervisorOf"></see></summary>
    let supervisorOf =
        Namespaced_IRI.parse _namespace_name "supervisorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/roh#taughtBy"></see>
    /// </summary>
    let taughtBy = Namespaced_IRI.parse _namespace_name "taughtBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/roh#teaches"></see>
    /// </summary>
    let teaches = Namespaced_IRI.parse _namespace_name "teaches" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/roh#taxID"></see>
    /// </summary>
    let taxID = Namespaced_IRI.parse _namespace_name "taxID" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/roh#upc"></see>
    /// </summary>
    let upc = Namespaced_IRI.parse _namespace_name "upc" |> NamespacedName
    /// <summary>
    /// A Uniform Resource Identifier.
    /// <see href="http://w3id.org/roh#url"></see></summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/roh#utilizes"></see>
    /// </summary>
    let utilizes = Namespaced_IRI.parse _namespace_name "utilizes" |> NamespacedName
