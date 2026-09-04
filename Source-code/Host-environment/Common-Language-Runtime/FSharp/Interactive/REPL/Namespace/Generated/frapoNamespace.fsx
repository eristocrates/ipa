#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module frapo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/cerif/frapo/" "frapo"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : account</para>
    ///   <para>rdfs:comment : A mechanism for administering money, typically owned by an agent and dedicated to a particular purpose, for example the equipment account of a university department, to be used only for the purchase or maintenance of items of equipment. </para>
    ///   <a href="http://purl.org/cerif/frapo/Account">frapo:Account</a>
    /// </summary>
    let Account = _prefixId.prefix "Account"
    /// <summary>
    ///   <para>rdfs:label : account statement</para>
    ///   <para>rdfs:comment : A statement of income and expenditure for an account, typically presented as dated income receipts and outgoings against categories in a budget for that account.</para>
    ///   <a href="http://purl.org/cerif/frapo/AccountStatement">frapo:AccountStatement</a>
    /// </summary>
    let AccountStatement = _prefixId.prefix "AccountStatement"
    /// <summary>
    ///   <para>rdfs:label : admission application</para>
    ///   <para>rdfs:comment : The activity of applying for admission to some group or institution, for example a learned society or a university.</para>
    ///   <a href="http://purl.org/cerif/frapo/AdmissionApplication">frapo:AdmissionApplication</a>
    /// </summary>
    let AdmissionApplication = _prefixId.prefix "AdmissionApplication"
    /// <summary>
    ///   <para>rdfs:label : annual turnover</para>
    ///   <para>rdfs:comment : The anual financial turnover of an organization (in a specified currency).</para>
    ///   <a href="http://purl.org/cerif/frapo/AnnualTurnover">frapo:AnnualTurnover</a>
    /// </summary>
    let AnnualTurnover = _prefixId.prefix "AnnualTurnover"
    /// <summary>
    ///   <para>rdfs:label : application</para>
    ///   <para>rdfs:comment : The activity of making an application, for example for a job, or for funding.</para>
    ///   <a href="http://purl.org/cerif/frapo/Application">frapo:Application</a>
    /// </summary>
    let Application = _prefixId.prefix "Application"
    /// <summary>
    ///   <para>rdfs:label : article processing charge</para>
    ///   <para>rdfs:comment : A fee levied by a publisher on an author or an institution to cover the cost of publishing an Open Access journal article.  Also knows as Article Processing Fee, Article Publication Charge, Author Processing Charge or Author Publishing Charge.</para>
    ///   <a href="http://purl.org/cerif/frapo/ArticleProcessingCharge">frapo:ArticleProcessingCharge</a>
    /// </summary>
    let ArticleProcessingCharge = _prefixId.prefix "ArticleProcessingCharge"
    /// <summary>
    ///   <para>rdfs:label : available funds</para>
    ///   <para>rdfs:comment : The amount available to spend in a budget category, equalling the income minus the expenditure to date plus future expenditure commitments. </para>
    ///   <a href="http://purl.org/cerif/frapo/AvailableFunds">frapo:AvailableFunds</a>
    /// </summary>
    let AvailableFunds = _prefixId.prefix "AvailableFunds"
    /// <summary>
    ///   <para>rdfs:label : budget</para>
    ///   <para>rdfs:comment : A structured statement of how funds are to be used for expenditure in defined budget categories.  A budget is created, for example, when applying for funding for a project, and is subsequently used to manage the expenditure from the awarded grant for that project.</para>
    ///   <a href="http://purl.org/cerif/frapo/Budget">frapo:Budget</a>
    /// </summary>
    let Budget = _prefixId.prefix "Budget"
    /// <summary>
    ///   <para>rdfs:label : budget category</para>
    ///   <para>rdfs:comment : A category of expenditure within a budget, determining what the allocated money can be spent on, for example salaries, equipment, travel.</para>
    ///   <a href="http://purl.org/cerif/frapo/BudgetCategory">frapo:BudgetCategory</a>
    /// </summary>
    let BudgetCategory = _prefixId.prefix "BudgetCategory"
    /// <summary>
    ///   <para>rdfs:label : budget information</para>
    ///   <para>rdfs:comment : Information about an aspect of a budget.</para>
    ///   <a href="http://purl.org/cerif/frapo/BudgetInformation">frapo:BudgetInformation</a>
    /// </summary>
    let BudgetInformation = _prefixId.prefix "BudgetInformation"
    /// <summary>
    ///   <para>rdfs:label : budgeted amount</para>
    ///   <para>rdfs:comment : The amount of money originally available to spend in a particular budget category.</para>
    ///   <a href="http://purl.org/cerif/frapo/BudgetedAmount">frapo:BudgetedAmount</a>
    /// </summary>
    let BudgetedAmount = _prefixId.prefix "BudgetedAmount"
    /// <summary>
    ///   <para>rdfs:label : bursary</para>
    ///   <para>rdfs:comment : An amount of money given to a person by an organization, for example by a university to a university student in need to enable that student to continue his/her studies.</para>
    ///   <a href="http://purl.org/cerif/frapo/Bursary">frapo:Bursary</a>
    /// </summary>
    let Bursary = _prefixId.prefix "Bursary"
    let Business_angel = _prefixId.prefix "Business_angel"
    /// <summary>
    ///   <para>rdfs:label : college</para>
    ///   <para>rdfs:comment : An academic organization that is either a small degree-giving university, or (in the OxBridge sense) an independent corporation of scholars within a larger university, providing undergraduate tuition and a social environment for its students and fellows.</para>
    ///   <a href="http://purl.org/cerif/frapo/College">frapo:College</a>
    /// </summary>
    let College = _prefixId.prefix "College"
    /// <summary>
    ///   <para>rdfs:label : commitments</para>
    ///   <para>rdfs:comment : Money set aside to honour expenditures already made but for which no invoices have yet been received, or expenditures planned for the future, for example for salaries.</para>
    ///   <a href="http://purl.org/cerif/frapo/Commitments">frapo:Commitments</a>
    /// </summary>
    let Commitments = _prefixId.prefix "Commitments"
    /// <summary>
    ///   <para>rdfs:label : company</para>
    ///   <para>rdfs:comment : A commercial company or business run for profit.</para>
    ///   <a href="http://purl.org/cerif/frapo/Company">frapo:Company</a>
    /// </summary>
    let Company = _prefixId.prefix "Company"
    /// <summary>
    ///   <para>rdfs:label : computational agent</para>
    ///   <para>rdfs:comment : A computer system or software program whose action has an effect on external events, for example a laboratory robot that undertakes your experiments, or the financial control system that controls an institution's payrole, or that, following programmed business rules, prevents the principal investigator from placing an order for research equipment because there is insufficient money left in the project budget.</para>
    ///   <a href="http://purl.org/cerif/frapo/ComputationalAgent">frapo:ComputationalAgent</a>
    /// </summary>
    let ComputationalAgent = _prefixId.prefix "ComputationalAgent"
    /// <summary>
    ///   <para>rdfs:label : computational service</para>
    ///   <para>rdfs:comment : A service provided by a computer system.</para>
    ///   <a href="http://purl.org/cerif/frapo/ComputationalService">frapo:ComputationalService</a>
    /// </summary>
    let ComputationalService = _prefixId.prefix "ComputationalService"
    /// <summary>
    ///   <para>rdfs:label : conference fee</para>
    ///   <para>rdfs:comment : A fee paid to attend a conference.</para>
    ///   <a href="http://purl.org/cerif/frapo/ConferenceFee">frapo:ConferenceFee</a>
    /// </summary>
    let ConferenceFee = _prefixId.prefix "ConferenceFee"
    /// <summary>
    ///   <para>rdfs:label : consortium agreement</para>
    ///   <para>rdfs:comment : A formal agreement between members of a consortium, for example between research groups at different universities engaged in a multi-partner research project.</para>
    ///   <a href="http://purl.org/cerif/frapo/ConsortiumAgreement">frapo:ConsortiumAgreement</a>
    /// </summary>
    let ConsortiumAgreement = _prefixId.prefix "ConsortiumAgreement"
    /// <summary>
    ///   <para>rdfs:label : consultancy agreement</para>
    ///   <para>rdfs:comment : A contract between an employer and a consultant, detailing the terms of the consultancy.</para>
    ///   <a href="http://purl.org/cerif/frapo/ConsultancyAgreement">frapo:ConsultancyAgreement</a>
    /// </summary>
    let ConsultancyAgreement = _prefixId.prefix "ConsultancyAgreement"
    /// <summary>
    ///   <para>rdfs:label : contract</para>
    ///   <para>rdfs:comment : A legally binding agreement between parties.</para>
    ///   <a href="http://purl.org/cerif/frapo/Contract">frapo:Contract</a>
    /// </summary>
    let Contract = _prefixId.prefix "Contract"
    /// <summary>
    ///   <para>dce:description : May also be described as a data archive, or as a database.</para>
    ///   <para>rdfs:label : data repository</para>
    ///   <para>rdfs:comment : A facility in which digital data are deposited for long-term preservation and (optional) publication.</para>
    ///   <a href="http://purl.org/cerif/frapo/DataRepository">frapo:DataRepository</a>
    /// </summary>
    let DataRepository = _prefixId.prefix "DataRepository"
    /// <summary>
    ///   <para>rdfs:label : deliverable</para>
    ///   <para>rdfs:comment : A class defining a 'deliverable' of a project, i.e. something that the project set out to deliver, or succeeds in delivering.</para>
    ///   <a href="http://purl.org/cerif/frapo/Deliverable">frapo:Deliverable</a>
    /// </summary>
    let Deliverable = _prefixId.prefix "Deliverable"
    /// <summary>
    ///   <para>rdfs:label : department</para>
    ///   <para>rdfs:comment : A department or sub-section within a larger organization, for example a university academic department.</para>
    ///   <a href="http://purl.org/cerif/frapo/Department">frapo:Department</a>
    /// </summary>
    let Department = _prefixId.prefix "Department"
    /// <summary>
    ///   <para>rdfs:label : division</para>
    ///   <para>rdfs:comment : A grouping of similar departments within a larger organization.  In the university context, also known as a school or a faculty, for example the Humanities Division, the Mathematics Faculty, or the School of Medicine.</para>
    ///   <a href="http://purl.org/cerif/frapo/Division">frapo:Division</a>
    /// </summary>
    let Division = _prefixId.prefix "Division"
    /// <summary>
    ///   <para>dce:description : May also be described as a document archive, or a digital library.</para>
    ///   <para>rdfs:label : document repository</para>
    ///   <para>rdfs:comment : A facility in which digital documents are deposited for long-term preservation and (optional) publication.</para>
    ///   <a href="http://purl.org/cerif/frapo/DocumentRepository">frapo:DocumentRepository</a>
    /// </summary>
    let DocumentRepository = _prefixId.prefix "DocumentRepository"
    /// <summary>
    ///   <para>rdfs:label : employment application</para>
    ///   <para>rdfs:comment : The activity of applying for a job.</para>
    ///   <a href="http://purl.org/cerif/frapo/EmploymentApplication">frapo:EmploymentApplication</a>
    /// </summary>
    let EmploymentApplication = _prefixId.prefix "EmploymentApplication"
    /// <summary>
    ///   <para>rdfs:label : employment contract</para>
    ///   <para>rdfs:comment : A contract of employment between a person and an organization.</para>
    ///   <a href="http://purl.org/cerif/frapo/EmploymentContract">frapo:EmploymentContract</a>
    /// </summary>
    let EmploymentContract = _prefixId.prefix "EmploymentContract"
    /// <summary>
    ///   <para>rdfs:label : endeavour</para>
    ///   <para>rdfs:comment : In FRAPO, an endeavour is an activity such as a research investigation that is enabled by a project.  An endeavour relate to the academic and practical aspects of undertaking that endeavour - thus for a research investigation the research itself, including the hypotheses being investigated, the experiments being undertaken, the data being gathered and analysed, the interpretations being drawn from the data, and the results obtained.  In contrast, the project relates to the administrative aspects of undertaking an endeavour, including the funding obtained, the people employed, and the management of the project in terms of deadlines and deliverables.</para>
    ///   <a href="http://purl.org/cerif/frapo/Endeavour">frapo:Endeavour</a>
    /// </summary>
    let Endeavour = _prefixId.prefix "Endeavour"
    /// <summary>
    ///   <para>rdfs:label : endowment</para>
    ///   <para>rdfs:comment : A transfer, generally as a gift, of money or property to an institution to provide a permanent fund, the income from which is to be used for a particular purpose.  (Abbreviated from http://legal-dictionary.thefreedictionary.com/endowment).</para>
    ///   <a href="http://purl.org/cerif/frapo/Endowment">frapo:Endowment</a>
    /// </summary>
    let Endowment = _prefixId.prefix "Endowment"
    /// <summary>
    ///   <para>rdfs:label : equipment</para>
    ///   <para>rdfs:comment : An item of equipment or apparatus, or a laboratory instrument, for example a refrigerated centrifuge.</para>
    ///   <a href="http://purl.org/cerif/frapo/Equipment">frapo:Equipment</a>
    /// </summary>
    let Equipment = _prefixId.prefix "Equipment"
    /// <summary>
    ///   <para>rdfs:label : expenditure</para>
    ///   <para>rdfs:comment : Money going out of an account, because of expenditure on various entities. May be associated with a particular budget category.</para>
    ///   <a href="http://purl.org/cerif/frapo/Expenditure">frapo:Expenditure</a>
    /// </summary>
    let Expenditure = _prefixId.prefix "Expenditure"
    /// <summary>
    ///   <para>rdfs:label : expenditure to date</para>
    ///   <para>rdfs:comment : Total money expended to date from an an account, or from a particular budget category.</para>
    ///   <a href="http://purl.org/cerif/frapo/ExpenditureToDate">frapo:ExpenditureToDate</a>
    /// </summary>
    let ExpenditureToDate = _prefixId.prefix "ExpenditureToDate"
    /// <summary>
    ///   <para>rdfs:label : facility</para>
    ///   <para>rdfs:comment : A place or installation built or designed to serve a specific function or provide a specific service, for example an animal breeding centre, a DNA sequencing facility or a confocal imaging laboratory.</para>
    ///   <a href="http://purl.org/cerif/frapo/Facility">frapo:Facility</a>
    /// </summary>
    let Facility = _prefixId.prefix "Facility"
    /// <summary>
    ///   <para>rdfs:label : faculty</para>
    ///   <para>rdfs:comment : A grouping of similar departments within a university context, also known as a school or a division, for example the Humanities Division, the Mathematics Faculty, or the School of Medicine.</para>
    ///   <a href="http://purl.org/cerif/frapo/Faculty">frapo:Faculty</a>
    /// </summary>
    let Faculty = _prefixId.prefix "Faculty"
    /// <summary>
    ///   <para>rdfs:label : fee</para>
    ///   <para>rdfs:comment : An amount of money paid for something that is not purchased.</para>
    ///   <a href="http://purl.org/cerif/frapo/Fee">frapo:Fee</a>
    /// </summary>
    let Fee = _prefixId.prefix "Fee"
    /// <summary>
    ///   <para>rdfs:label : fellowship</para>
    ///   <para>rdfs:comment : The stipend paid to a fellow in a college or university.</para>
    ///   <a href="http://purl.org/cerif/frapo/Fellowship">frapo:Fellowship</a>
    /// </summary>
    let Fellowship = _prefixId.prefix "Fellowship"
    /// <summary>
    ///   <para>rdfs:label : financial control system</para>
    ///   <para>rdfs:comment : A software system controlling the financial activities of an organization, for example determining full economic cost budgets for grant applications, and managing the funding of funded projects.</para>
    ///   <a href="http://purl.org/cerif/frapo/FinancialControlSystem">frapo:FinancialControlSystem</a>
    /// </summary>
    let FinancialControlSystem = _prefixId.prefix "FinancialControlSystem"
    /// <summary>
    ///   <para>rdfs:label : financial entity</para>
    ///   <para>rdfs:comment : An entity primarily to do with money.</para>
    ///   <a href="http://purl.org/cerif/frapo/FinancialEntity">frapo:FinancialEntity</a>
    /// </summary>
    let FinancialEntity = _prefixId.prefix "FinancialEntity"
    /// <summary>
    ///   <para>rdfs:label : funding</para>
    ///   <para>rdfs:comment : An amount of money available to finance some project or activity. </para>
    ///   <a href="http://purl.org/cerif/frapo/Funding">frapo:Funding</a>
    /// </summary>
    let Funding = _prefixId.prefix "Funding"
    /// <summary>
    ///   <para>rdfs:label : funding agency</para>
    ///   <para>rdfs:comment : An organization that provides funding for projects, often in the form of grants awarded on the basis of competitive application.</para>
    ///   <a href="http://purl.org/cerif/frapo/FundingAgency">frapo:FundingAgency</a>
    /// </summary>
    let FundingAgency = _prefixId.prefix "FundingAgency"
    /// <summary>
    ///   <para>dce:description : For the documents supporting a funding application, use fabio:GrantApplicationDocument and fabio:CaseForSupportDocument.</para>
    ///   <para>rdfs:label : funding application</para>
    ///   <para>rdfs:comment : The activity of applying for funding.</para>
    ///   <a href="http://purl.org/cerif/frapo/FundingApplication">frapo:FundingApplication</a>
    /// </summary>
    let FundingApplication = _prefixId.prefix "FundingApplication"
    /// <summary>
    ///   <para>rdfs:label : funding programme</para>
    ///   <para>rdfs:comment : A programme of related funded activities or projects, typically established by a funding agency.  Often associated with publication of a call for applications (fabio:CallForApplications).</para>
    ///   <a href="http://purl.org/cerif/frapo/FundingProgramme">frapo:FundingProgramme</a>
    /// </summary>
    let FundingProgramme = _prefixId.prefix "FundingProgramme"
    /// <summary>
    ///   <para>rdfs:label : gift</para>
    ///   <para>rdfs:comment : A gift, donation, benefaction or legacy, typically of money.</para>
    ///   <a href="http://purl.org/cerif/frapo/Gift">frapo:Gift</a>
    /// </summary>
    let Gift = _prefixId.prefix "Gift"
    /// <summary>
    ///   <para>rdfs:label : government organization</para>
    ///   <para>rdfs:comment : An organization that is part of, or funded by, central or local goverment.</para>
    ///   <a href="http://purl.org/cerif/frapo/GovernmentOrganization">frapo:GovernmentOrganization</a>
    /// </summary>
    let GovernmentOrganization = _prefixId.prefix "GovernmentOrganization"
    /// <summary>
    ///   <para>rdfs:label : grant</para>
    ///   <para>rdfs:comment : A financial award by a funding agency for a particular project or purpose, usually awarded on the basis of a competitive application.</para>
    ///   <a href="http://purl.org/cerif/frapo/Grant">frapo:Grant</a>
    /// </summary>
    let Grant = _prefixId.prefix "Grant"
    /// <summary>
    ///   <para>rdfs:label : host institution</para>
    ///   <para>rdfs:comment : An institution that acts as a host, for example of a project or a person.</para>
    ///   <a href="http://purl.org/cerif/frapo/HostInstitution">frapo:HostInstitution</a>
    /// </summary>
    let HostInstitution = _prefixId.prefix "HostInstitution"
    /// <summary>
    ///   <para>rdfs:label : income</para>
    ///   <para>rdfs:comment : Money coming into an account.  May be associated with a particular budget category.</para>
    ///   <a href="http://purl.org/cerif/frapo/Income">frapo:Income</a>
    /// </summary>
    let Income = _prefixId.prefix "Income"
    /// <summary>
    ///   <para>dce:description : owl:equivalentClass cerif:InfrastructureEntity .</para>
    ///   <para>rdfs:label : infrastructure entity</para>
    ///   <para>rdfs:comment : An entity that facilitates work.</para>
    ///   <a href="http://purl.org/cerif/frapo/InfrastructureEntity">frapo:InfrastructureEntity</a>
    /// </summary>
    let InfrastructureEntity = _prefixId.prefix "InfrastructureEntity"
    /// <summary>
    ///   <para>dce:description : Equivalent class in ISA-RDF: 'Investigation'.</para>
    ///   <para>rdfs:label : investigation</para>
    ///   <para>rdfs:comment : An investigation is an endeavour that involves research, enabled by a project.
    ///
    /// The investigation relate to the scholarly and practical aspects of conducting the research itself, including the hypotheses being investigated, the experiments being undertaken, the data being gathered and analysed, the interpretations being drawn from the data, and the results obtained.
    ///
    /// In contrast, the project that enables it encompasses the administrative aspects of undertaking the endeavour, including the funding obtained, the people employed, and the management of the project in terms of deadlines and deliverables.</para>
    ///   <a href="http://purl.org/cerif/frapo/Investigation">frapo:Investigation</a>
    /// </summary>
    let Investigation = _prefixId.prefix "Investigation"
    /// <summary>
    ///   <para>rdfs:label : investment</para>
    ///   <para>rdfs:comment : An investment of money, generally in stocks and shares, or in property, for the purpose of safeguarding the capital and yielding an income.</para>
    ///   <a href="http://purl.org/cerif/frapo/Investment">frapo:Investment</a>
    /// </summary>
    let Investment = _prefixId.prefix "Investment"
    /// <summary>
    ///   <para>rdfs:label : invoice</para>
    ///   <para>rdfs:comment : An invoice for payment of goods or services.</para>
    ///   <a href="http://purl.org/cerif/frapo/Invoice">frapo:Invoice</a>
    /// </summary>
    let Invoice = _prefixId.prefix "Invoice"
    /// <summary>
    ///   <para>rdfs:label : laboratory</para>
    ///   <para>rdfs:comment : A facility in which research can be conducted.</para>
    ///   <a href="http://purl.org/cerif/frapo/Laboratory">frapo:Laboratory</a>
    /// </summary>
    let Laboratory = _prefixId.prefix "Laboratory"
    /// <summary>
    ///   <para>rdfs:label : legacy</para>
    ///   <para>rdfs:comment : A gift of money or property specified in the will of a person, that is made after that person's death.</para>
    ///   <a href="http://purl.org/cerif/frapo/Legacy">frapo:Legacy</a>
    /// </summary>
    let Legacy = _prefixId.prefix "Legacy"
    /// <summary>
    ///   <para>rdfs:label : library</para>
    ///   <para>rdfs:comment : A facility in which printed documents (for example books and journals) are deposited for long-term preservation and access.</para>
    ///   <a href="http://purl.org/cerif/frapo/Library">frapo:Library</a>
    /// </summary>
    let Library = _prefixId.prefix "Library"
    /// <summary>
    ///   <para>rdfs:label : manufacturer</para>
    ///   <para>rdfs:comment : An agent who manufactures goods or equipment.</para>
    ///   <a href="http://purl.org/cerif/frapo/Manufacturer">frapo:Manufacturer</a>
    /// </summary>
    let Manufacturer = _prefixId.prefix "Manufacturer"
    /// <summary>
    ///   <para>rdfs:label : material output</para>
    ///   <para>rdfs:comment : A material or physical output created or produced as a result of a project or an endeavour such as a research investigation. Examples include a building constructed as a result of a building project, and research outputs such as a cell line, a mouse mutant or a new form of microscope.</para>
    ///   <a href="http://purl.org/cerif/frapo/MaterialOutput">frapo:MaterialOutput</a>
    /// </summary>
    let MaterialOutput = _prefixId.prefix "MaterialOutput"
    /// <summary>
    ///   <para>rdfs:label : not-for-profit organization</para>
    ///   <para>rdfs:comment : An organization that does not primarily exist to make profit, for example a charity or charitable foundation, a learned society, or a standards body such as the World Wide Web Consortium.</para>
    ///   <a href="http://purl.org/cerif/frapo/NotForProfitOrganization">frapo:NotForProfitOrganization</a>
    /// </summary>
    let NotForProfitOrganization = _prefixId.prefix "NotForProfitOrganization"
    /// <summary>
    ///   <para>dce:description : Ontology terms and definitions for most publishable project outputs are given as 'Expression' classes in FaBiO, the FRBR-aligned Bibliographic Ontology, e.g. fabio:JournalArticle, fabio:DataSet.  For 'deliverables', use frapo:Deliverable.  For material outputs, use frapo:MaterialOutput.</para>
    ///   <para>rdfs:label : output</para>
    ///   <para>rdfs:comment : Something that is created or produced as a result of a project or an endeavour. Examples include a building resulting from a building project, educated students graduating from an educational programme, and a journal article published as a result of a research project.  Research outputs can also include reports, datasets, experimental protocols, workflows and mathematical models, and material outputs such as a cell line, a mouse mutant or a new form of microscope.</para>
    ///   <a href="http://purl.org/cerif/frapo/Output">frapo:Output</a>
    /// </summary>
    let Output = _prefixId.prefix "Output"
    /// <summary>
    ///   <para>rdfs:label : owner</para>
    ///   <para>rdfs:comment : The agent who owns an entity.</para>
    ///   <a href="http://purl.org/cerif/frapo/Owner">frapo:Owner</a>
    /// </summary>
    let Owner = _prefixId.prefix "Owner"
    /// <summary>
    ///   <para>rdfs:label : payment</para>
    ///   <para>rdfs:comment : A financial payment made, for example in exchange for something purchased such as property, goods or services, or to refund expenses incurred.</para>
    ///   <a href="http://purl.org/cerif/frapo/Payment">frapo:Payment</a>
    /// </summary>
    let Payment = _prefixId.prefix "Payment"
    /// <summary>
    ///   <para>rdfs:label : postal address</para>
    ///   <para>rdfs:comment : A postal address.</para>
    ///   <a href="http://purl.org/cerif/frapo/PostalAddress">frapo:PostalAddress</a>
    /// </summary>
    let PostalAddress = _prefixId.prefix "PostalAddress"
    /// <summary>
    ///   <para>rdfs:label : project budget</para>
    ///   <para>rdfs:comment : A budget for a research project.</para>
    ///   <a href="http://purl.org/cerif/frapo/ProjectBudget">frapo:ProjectBudget</a>
    /// </summary>
    let ProjectBudget = _prefixId.prefix "ProjectBudget"
    /// <summary>
    ///   <para>rdfs:label : purchase</para>
    ///   <para>rdfs:comment : The payment for obtaining something, for example property, goods or services.</para>
    ///   <a href="http://purl.org/cerif/frapo/Purchase">frapo:Purchase</a>
    /// </summary>
    let Purchase = _prefixId.prefix "Purchase"
    /// <summary>
    ///   <para>rdfs:label : purchase order</para>
    ///   <para>rdfs:comment : An official order from a purchasing institution to a supplier for the purchase of goods or services, often issued in response to the receipt of a quotation from the supplier.</para>
    ///   <a href="http://purl.org/cerif/frapo/PurchaseOrder">frapo:PurchaseOrder</a>
    /// </summary>
    let PurchaseOrder = _prefixId.prefix "PurchaseOrder"
    /// <summary>
    ///   <para>rdfs:label : purchaser</para>
    ///   <para>rdfs:comment : An agent who purchases something from a supplier.</para>
    ///   <a href="http://purl.org/cerif/frapo/Purchaser">frapo:Purchaser</a>
    /// </summary>
    let Purchaser = _prefixId.prefix "Purchaser"
    /// <summary>
    ///   <para>rdfs:label : quotation</para>
    ///   <para>rdfs:comment : A formal statement of promise (usually provided in response to a request for quotation) by potential supplier to supply goods or services at specified prices and within a specified period. Acceptance of the quotation by the buyer constitutes an agreement binding on both parties.  (Shortened from http://www.businessdictionary.com/definition/quotation.html).
    /// </para>
    ///   <a href="http://purl.org/cerif/frapo/Quotation">frapo:Quotation</a>
    /// </summary>
    let Quotation = _prefixId.prefix "Quotation"
    /// <summary>
    ///   <para>rdfs:label : registration agency</para>
    ///   <para>rdfs:comment : An organization that acts to register things.  For example, CrossRef is a registration agency for DOIs relating to documents, while DataCite is a registration agency for DOIs relating to datasets.</para>
    ///   <a href="http://purl.org/cerif/frapo/RegistrationAgency">frapo:RegistrationAgency</a>
    /// </summary>
    let RegistrationAgency = _prefixId.prefix "RegistrationAgency"
    /// <summary>
    ///   <para>rdfs:label : registration authority</para>
    ///   <para>rdfs:comment : An agency with responsibility for registering and maintaining international standards, internet domain names, patents, controlled vocabularies and other similar entities required for reliable international cooperatative activities.</para>
    ///   <a href="http://purl.org/cerif/frapo/RegistrationAuthority">frapo:RegistrationAuthority</a>
    /// </summary>
    let RegistrationAuthority = _prefixId.prefix "RegistrationAuthority"
    /// <summary>
    ///   <para>dce:description : May also be described as an archive, or as a database.</para>
    ///   <para>rdfs:label : repository</para>
    ///   <para>rdfs:comment : A facility in which entities can be deposited for long-term preservation.</para>
    ///   <a href="http://purl.org/cerif/frapo/Repository">frapo:Repository</a>
    /// </summary>
    let Repository = _prefixId.prefix "Repository"
    /// <summary>
    ///   <para>rdfs:label : research group</para>
    ///   <para>rdfs:comment : A group of people, usually within a university department or a research institute, and typically under a single group leader, dedicated to working together to undertake research on one or more topics. May also be called a research unit.</para>
    ///   <a href="http://purl.org/cerif/frapo/ResearchGroup">frapo:ResearchGroup</a>
    /// </summary>
    let ResearchGroup = _prefixId.prefix "ResearchGroup"
    /// <summary>
    ///   <para>rdfs:label : research information system</para>
    ///   <para>rdfs:comment : A database containing administrative information about the research undertaken in an institution, and the publications and other outputs from such research.</para>
    ///   <a href="http://purl.org/cerif/frapo/ResearchInformationSystem">frapo:ResearchInformationSystem</a>
    /// </summary>
    let ResearchInformationSystem = _prefixId.prefix "ResearchInformationSystem"
    /// <summary>
    ///   <para>rdfs:label : research institute</para>
    ///   <para>rdfs:comment : An organization primarily dedicated to undertaking research, that might be part of a university or of a commercial company, or might be independently funded by a research funding agency.  </para>
    ///   <a href="http://purl.org/cerif/frapo/ResearchInstitute">frapo:ResearchInstitute</a>
    /// </summary>
    let ResearchInstitute = _prefixId.prefix "ResearchInstitute"
    /// <summary>
    ///   <para>rdfs:label : small to medium enterpriserdfs:label : sme</para>
    ///   <para>rdfs:comment : A small to medium enterprise, having up to 250 employees.</para>
    ///   <a href="http://purl.org/cerif/frapo/SME">frapo:SME</a>
    /// </summary>
    let SME = _prefixId.prefix "SME"
    /// <summary>
    ///   <para>rdfs:label : scholarship</para>
    ///   <para>rdfs:comment : A financial grant to a scholar to enable him/her to undertake advanced academic study.</para>
    ///   <a href="http://purl.org/cerif/frapo/Scholarship">frapo:Scholarship</a>
    /// </summary>
    let Scholarship = _prefixId.prefix "Scholarship"
    /// <summary>
    ///   <para>rdfs:label : scholarship application</para>
    ///   <para>rdfs:comment : The activity of applying for an educational scholarship.</para>
    ///   <a href="http://purl.org/cerif/frapo/ScholarshipApplication">frapo:ScholarshipApplication</a>
    /// </summary>
    let ScholarshipApplication = _prefixId.prefix "ScholarshipApplication"
    /// <summary>
    ///   <para>rdfs:label : service</para>
    ///   <para>rdfs:comment : A service of help to others, often requiring funding, employees, equipment and/or facilities for its provision, for example a library service, a transportation service, a DNA sequencing service.</para>
    ///   <a href="http://purl.org/cerif/frapo/Service">frapo:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:label : service contract</para>
    ///   <para>rdfs:comment : A contract for the provision of a service such as a cleaning service, or for the regular servicing, maintenance and repair of some item of equipment or infrastructure.</para>
    ///   <a href="http://purl.org/cerif/frapo/ServiceContract">frapo:ServiceContract</a>
    /// </summary>
    let ServiceContract = _prefixId.prefix "ServiceContract"
    /// <summary>
    ///   <para>rdfs:label : service contract fee</para>
    ///   <para>rdfs:comment : A fee paid periodically, typically annually, to obtain access when required to a service such as an equipment maintenance contract."</para>
    ///   <a href="http://purl.org/cerif/frapo/ServiceContractFee">frapo:ServiceContractFee</a>
    /// </summary>
    let ServiceContractFee = _prefixId.prefix "ServiceContractFee"
    /// <summary>
    ///   <para>rdfs:label : spin-off company</para>
    ///   <para>rdfs:comment : A company that has been established by a university or research institute to mature and market the results of research conducted at that research institution.</para>
    ///   <a href="http://purl.org/cerif/frapo/SpinOffCompany">frapo:SpinOffCompany</a>
    /// </summary>
    let SpinOffCompany = _prefixId.prefix "SpinOffCompany"
    /// <summary>
    ///   <para>rdfs:label : status</para>
    ///   <para>rdfs:comment : The status of something such as an application, an investigation or a project.</para>
    ///   <a href="http://purl.org/cerif/frapo/Status">frapo:Status</a>
    /// </summary>
    let Status = _prefixId.prefix "Status"
    /// <summary>
    ///   <para>rdfs:label : stipend</para>
    ///   <para>rdfs:comment : A sum of money allotted on a regular basis, usually for some specific purpose.</para>
    ///   <a href="http://purl.org/cerif/frapo/Stipend">frapo:Stipend</a>
    /// </summary>
    let Stipend = _prefixId.prefix "Stipend"
    /// <summary>
    ///   <para>rdfs:label : studentship</para>
    ///   <para>rdfs:comment : A financial grant to a student to enable him/her to undertake advanced academic study.</para>
    ///   <a href="http://purl.org/cerif/frapo/Studentship">frapo:Studentship</a>
    /// </summary>
    let Studentship = _prefixId.prefix "Studentship"
    /// <summary>
    ///   <para>rdfs:label : subscription</para>
    ///   <para>rdfs:comment : Payment, commonly made annually, to obtain access to something on a periodic or continuing basis, such as a journal.</para>
    ///   <a href="http://purl.org/cerif/frapo/Subscription">frapo:Subscription</a>
    /// </summary>
    let Subscription = _prefixId.prefix "Subscription"
    /// <summary>
    ///   <para>rdfs:label : supplier</para>
    ///   <para>rdfs:comment : An agent who supplies something, such as goods or services.</para>
    ///   <a href="http://purl.org/cerif/frapo/Supplier">frapo:Supplier</a>
    /// </summary>
    let Supplier = _prefixId.prefix "Supplier"
    /// <summary>
    ///   <para>rdfs:label : tender</para>
    ///   <para>rdfs:comment : Sealed bid or offer document submitted in response to a request for tenders, containing detailed information on costs, requirements and terms associated with a potential contract.  (Adapted from http://www.businessdictionary.com/definition/tender.html).</para>
    ///   <a href="http://purl.org/cerif/frapo/Tender">frapo:Tender</a>
    /// </summary>
    let Tender = _prefixId.prefix "Tender"
    /// <summary>
    ///   <para>rdfs:label : university</para>
    ///   <para>rdfs:comment : A university at which higher education and research is conducted.</para>
    ///   <a href="http://purl.org/cerif/frapo/University">frapo:University</a>
    /// </summary>
    let University = _prefixId.prefix "University"
    /// <summary>
    ///   <para>rdfs:label : vendor</para>
    ///   <para>rdfs:comment : An agent who supplies goods or services in exchange for payment, in response to receipt of payment or of an official purchase order from a purchaser that is responded to by submission of an invoice for what is supplied.</para>
    ///   <a href="http://purl.org/cerif/frapo/Vendor">frapo:Vendor</a>
    /// </summary>
    let Vendor = _prefixId.prefix "Vendor"
    let academic = _prefixId.prefix "academic"
    let accepted = _prefixId.prefix "accepted"
    /// <summary>
    ///   <para>rdfs:label : applies for</para>
    ///   <para>rdfs:comment : An object property linking an agent to something for which that agent applies, for example a job, membership of an organization, or a grant from a funding agency.</para>
    ///   <a href="http://purl.org/cerif/frapo/appliesFor">frapo:appliesFor</a>
    /// </summary>
    let appliesFor = _prefixId.prefix "appliesFor"
    /// <summary>
    ///   <para>rdfs:label : awards</para>
    ///   <para>rdfs:comment : An object property linking an agent to something the agent awards, for example linking a funding agency to a grant, a university to a degree, or an organization to a prize.</para>
    ///   <a href="http://purl.org/cerif/frapo/awards">frapo:awards</a>
    /// </summary>
    let awards = _prefixId.prefix "awards"
    let benefactor = _prefixId.prefix "benefactor"
    let building_costs = _prefixId.prefix "building-costs"
    let business_angel = _prefixId.prefix "business-angel"
    /// <summary>
    ///   <para>rdfs:label : collaborates with</para>
    ///   <para>rdfs:comment : An object property linking agents, for example different organizations, or people typically from different groups or organizations, that work together on a common task, project or endeavour, or towards a common goal.</para>
    ///   <a href="http://purl.org/cerif/frapo/collaboratesWith">frapo:collaboratesWith</a>
    /// </summary>
    let collaboratesWith = _prefixId.prefix "collaboratesWith"
    let consultancy_costs = _prefixId.prefix "consultancy-costs"
    let consumables_costs = _prefixId.prefix "consumables-costs"
    let contributions_in_kind = _prefixId.prefix "contributions-in-kind"
    let directly_allocated_costs = _prefixId.prefix "directly-allocated-costs"
    let directly_incurred_costs = _prefixId.prefix "directly-incurred-costs"
    /// <summary>
    ///   <para>dce:description : Range constraints have been removed from this object property to permit it to be used in unforeseen ways.</para>
    ///   <para>rdfs:label : donates</para>
    ///   <para>rdfs:comment : An object property linking a benefactor to a gift.</para>
    ///   <a href="http://purl.org/cerif/frapo/donates">frapo:donates</a>
    /// </summary>
    let donates = _prefixId.prefix "donates"
    /// <summary>
    ///   <para>dce:description : This property should not be used for the other meaning of 'employ', meaning to use something, e.g. 'He employed great skill . . .'/</para>
    ///   <para>rdfs:label : employs</para>
    ///   <para>rdfs:comment : An object property relating an employing agent to an employed agent, for example a person or an organization, who is typically employed to undertaking specified work in exchange for payment.</para>
    ///   <a href="http://purl.org/cerif/frapo/employs">frapo:employs</a>
    /// </summary>
    let employs = _prefixId.prefix "employs"
    /// <summary>
    ///   <para>dce:description : Domain and range constraints have been removed from this object property to permit it to be used in unforeseen ways.</para>
    ///   <para>rdfs:label : enables</para>
    ///   <para>rdfs:comment : An object property relating an entity to another entity that it enables, e.g. linking a project to an endeavour that the project enables.</para>
    ///   <a href="http://purl.org/cerif/frapo/enables">frapo:enables</a>
    /// </summary>
    let enables = _prefixId.prefix "enables"
    let entrepreneur = _prefixId.prefix "entrepreneur"
    let estates_costs = _prefixId.prefix "estates-costs"
    /// <summary>
    ///   <para>rdfs:label : evaluates</para>
    ///   <para>rdfs:comment : An object property linking an agent to an entity which that agent evaluates, for example a funding agency that is evaluating a grant application to determine whether the proposed project is worthy of funding, or a publisher evaluating a manuscript to determine whether it is suitable for publication.</para>
    ///   <a href="http://purl.org/cerif/frapo/evaluates">frapo:evaluates</a>
    /// </summary>
    let evaluates = _prefixId.prefix "evaluates"
    let facilities_costs = _prefixId.prefix "facilities-costs"
    /// <summary>
    ///   <para>rdfs:label : family name initial</para>
    ///   <para>rdfs:comment : A data property permitting specification of the initial(s) of a person's family name.</para>
    ///   <a href="http://purl.org/cerif/frapo/familyNameInitial">frapo:familyNameInitial</a>
    /// </summary>
    let familyNameInitial = _prefixId.prefix "familyNameInitial"
    /// <summary>
    ///   <para>rdfs:label : fee or free</para>
    ///   <para>rdfs:comment : A data property defining whether participation in an event is free, or requires payment of a fee.</para>
    ///   <a href="http://purl.org/cerif/frapo/feeOrFree">frapo:feeOrFree</a>
    /// </summary>
    let feeOrFree = _prefixId.prefix "feeOrFree"
    let full_economic_costs = _prefixId.prefix "full-economic-costs"
    let funded = _prefixId.prefix "funded"
    /// <summary>
    ///   <para>rdfs:label : funds</para>
    ///   <para>rdfs:comment : An object property that links a grant to something that it funds (i.e. that it finances or pays for), or that links an agent providing funding to something that it funds.  This flexibility is given because of alternative usages of the English word 'funds'.  [See also frapo:awards and frapo:supports.]</para>
    ///   <a href="http://purl.org/cerif/frapo/funds">frapo:funds</a>
    /// </summary>
    let funds = _prefixId.prefix "funds"
    /// <summary>
    ///   <para>rdfs:label : given name initial</para>
    ///   <para>rdfs:comment : A data property permitting specification of the initial(s) of a person's given name(s).</para>
    ///   <a href="http://purl.org/cerif/frapo/givenNameInitial">frapo:givenNameInitial</a>
    /// </summary>
    let givenNameInitial = _prefixId.prefix "givenNameInitial"
    /// <summary>
    ///   <para>rdfs:label : has account number</para>
    ///   <para>rdfs:comment : A data property linking a financial account to an identifying number for that account.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasAccountNumber">frapo:hasAccountNumber</a>
    /// </summary>
    let hasAccountNumber = _prefixId.prefix "hasAccountNumber"
    /// <summary>
    ///   <para>rdfs:label : has acronym</para>
    ///   <para>rdfs:comment : A data property linking an entity to an acronym used to identify it, based on its full name or title.  For example, this ontology has the full name 'Funding, Research Administration and Projects Ontology' and the acronym 'FRAPO'.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasAcronym">frapo:hasAcronym</a>
    /// </summary>
    let hasAcronym = _prefixId.prefix "hasAcronym"
    /// <summary>
    ///   <para>rdfs:label : has information</para>
    ///   <para>rdfs:comment : A data property linking an agent to information about that agent.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasAgentInformation">frapo:hasAgentInformation</a>
    /// </summary>
    let hasAgentInformation = _prefixId.prefix "hasAgentInformation"
    /// <summary>
    ///   <para>dce:description : owl:equivalentProperty fabio:hasApplicationDeadline .</para>
    ///   <para>rdfs:label : has application deadline</para>
    ///   <para>rdfs:comment : The date by which an application, for example a job application, a fellowship application or a grant application, has to be submitted if it is to be considered for acceptance or funding.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasApplicationDeadline">frapo:hasApplicationDeadline</a>
    /// </summary>
    let hasApplicationDeadline = _prefixId.prefix "hasApplicationDeadline"
    /// <summary>
    ///   <para>rdfs:label : has application outcome</para>
    ///   <para>rdfs:comment : A data property that permits the outcome of an application to be described, for example that a job has been offered or that a grant has been awarded.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasApplicationOutcome">frapo:hasApplicationOutcome</a>
    /// </summary>
    let hasApplicationOutcome = _prefixId.prefix "hasApplicationOutcome"
    /// <summary>
    ///   <para>rdfs:label : has award date</para>
    ///   <para>rdfs:comment : The date on which notification is given or received that something, for example a scholarship or a grant, has been awarded.  [See also frapo:hasDecisionDate.]</para>
    ///   <a href="http://purl.org/cerif/frapo/hasAwardDate">frapo:hasAwardDate</a>
    /// </summary>
    let hasAwardDate = _prefixId.prefix "hasAwardDate"
    /// <summary>
    ///   <para>rdfs:label : has batch number</para>
    ///   <para>rdfs:comment : A data property linking something, for example a chemical or drug, to its manufacturing batch number.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasBatchNumber">frapo:hasBatchNumber</a>
    /// </summary>
    let hasBatchNumber = _prefixId.prefix "hasBatchNumber"
    /// <summary>
    ///   <para>rdfs:label : has birth date</para>
    ///   <para>rdfs:comment : A data property permitting specification of the birth date of a person.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasBirthDate">frapo:hasBirthDate</a>
    /// </summary>
    let hasBirthDate = _prefixId.prefix "hasBirthDate"
    /// <summary>
    ///   <para>rdfs:label : has call identifier</para>
    ///   <para>rdfs:comment : A data property specifying the identifying number of a call for applications issued by a funding agency.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasCallIdentifier">frapo:hasCallIdentifier</a>
    /// </summary>
    let hasCallIdentifier = _prefixId.prefix "hasCallIdentifier"
    /// <summary>
    ///   <para>rdfs:label : has catalog number</para>
    ///   <para>rdfs:comment : A data property linking something to its catalog number.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasCatalogNumber">frapo:hasCatalogNumber</a>
    /// </summary>
    let hasCatalogNumber = _prefixId.prefix "hasCatalogNumber"
    /// <summary>
    ///   <para>rdfs:label : has city or town</para>
    ///   <para>rdfs:comment : A data property specifying a city or town, for example as the location of an event.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasCityOrTown">frapo:hasCityOrTown</a>
    /// </summary>
    let hasCityOrTown = _prefixId.prefix "hasCityOrTown"
    /// <summary>
    ///   <para>rdfs:label : has code</para>
    ///   <para>rdfs:comment : A data property defining a code.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasCode">frapo:hasCode</a>
    /// </summary>
    let hasCode = _prefixId.prefix "hasCode"
    /// <summary>
    ///   <para>rdfs:label : has completion date</para>
    ///   <para>rdfs:comment : A data property linking something such as a building or a contract to its date of completion.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasCompletionDate">frapo:hasCompletionDate</a>
    /// </summary>
    let hasCompletionDate = _prefixId.prefix "hasCompletionDate"
    /// <summary>
    ///   <para>rdfs:label : has cost</para>
    ///   <para>rdfs:comment : A data property enabling the cost of something that can be paid for to be defined.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasCost">frapo:hasCost</a>
    /// </summary>
    let hasCost = _prefixId.prefix "hasCost"
    /// <summary>
    ///   <para>rdfs:label : has country</para>
    ///   <para>rdfs:comment : A data property specifying a country, for example as the location of an event.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasCountry">frapo:hasCountry</a>
    /// </summary>
    let hasCountry = _prefixId.prefix "hasCountry"
    /// <summary>
    ///   <para>rdfs:label : has country code</para>
    ///   <para>rdfs:comment : A data property specifying the two-letter or three-letter upper-case country code used to identify a country (e.g. FR/FRA for France, DE/DEU for Germany) (see http://countrycode.org/).</para>
    ///   <a href="http://purl.org/cerif/frapo/hasCountryCode">frapo:hasCountryCode</a>
    /// </summary>
    let hasCountryCode = _prefixId.prefix "hasCountryCode"
    /// <summary>
    ///   <para>rdfs:label : has currency</para>
    ///   <para>rdfs:comment : A data property defining the currency used to specify a financial entity.  Use in conjection with frapo:hasMonetaryValue.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasCurrency">frapo:hasCurrency</a>
    /// </summary>
    let hasCurrency = _prefixId.prefix "hasCurrency"
    /// <summary>
    ///   <para>rdfs:label : has currency code</para>
    ///   <para>rdfs:comment : A data property specifying the three-letter currency code used to identify a currency, as defined by ISO 4217 (e.g. EUR or GBP) (see http://en.wikipedia.org/wiki/ISO_4217).
    ///
    /// Not to be confused with the symbol used with numbers to denote an amount of money in a particular currency (e.g.€500; £3.40)</para>
    ///   <a href="http://purl.org/cerif/frapo/hasCurrencyCode">frapo:hasCurrencyCode</a>
    /// </summary>
    let hasCurrencyCode = _prefixId.prefix "hasCurrencyCode"
    /// <summary>
    ///   <para>rdfs:label : has curriculum vitae</para>
    ///   <para>rdfs:comment : An object property linking a person to an on-line version of that person's curriculum vitae.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasCurriculumVitae">frapo:hasCurriculumVitae</a>
    /// </summary>
    let hasCurriculumVitae = _prefixId.prefix "hasCurriculumVitae"
    /// <summary>
    ///   <para>rdfs:label : has customer number</para>
    ///   <para>rdfs:comment : A data property linking an agent to an identifying number for that agent, typically used by the accounting system of the supplier when issuing quotations, fulfilling orders and submitting invoices.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasCustomerNumber">frapo:hasCustomerNumber</a>
    /// </summary>
    let hasCustomerNumber = _prefixId.prefix "hasCustomerNumber"
    /// <summary>
    ///   <para>dce:description : This same data property appears in FaBiO, the FRBR-aligned Bibliographic Ontology (http://purl.org/spar/fabio/).</para>
    ///   <para>rdfs:label : has decision date</para>
    ///   <para>rdfs:comment : The date on which a particular action is or will be decided upon, or when an application, such as a grant application, is or will be approved or rejected. [See also frapo:hasAwardDate.]</para>
    ///   <a href="http://purl.org/cerif/frapo/hasDecisionDate">frapo:hasDecisionDate</a>
    /// </summary>
    let hasDecisionDate = _prefixId.prefix "hasDecisionDate"
    /// <summary>
    ///   <para>rdfs:label : has degrees</para>
    ///   <para>rdfs:comment : The letters that should be displayed after a person's name to indicate an academic degree, e.g. BA, BVSc, PhD, DSc.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasDegreeSuffix">frapo:hasDegreeSuffix</a>
    /// </summary>
    let hasDegreeSuffix = _prefixId.prefix "hasDegreeSuffix"
    /// <summary>
    ///   <para>rdfs:label : has deliverable</para>
    ///   <para>rdfs:comment : A data property that permits one to define a deliverable of a project.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasDeliverable">frapo:hasDeliverable</a>
    /// </summary>
    let hasDeliverable = _prefixId.prefix "hasDeliverable"
    /// <summary>
    ///   <para>rdfs:label : has delivery date</para>
    ///   <para>rdfs:comment : The date on which something is delivered, or is due to be delivered.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasDeliveryDate">frapo:hasDeliveryDate</a>
    /// </summary>
    let hasDeliveryDate = _prefixId.prefix "hasDeliveryDate"
    /// <summary>
    ///   <para>rdfs:label : has dispatch date</para>
    ///   <para>rdfs:comment : The date on which something, for example an item of equipment, is dispatched by the supplier.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasDispatchDate">frapo:hasDispatchDate</a>
    /// </summary>
    let hasDispatchDate = _prefixId.prefix "hasDispatchDate"
    /// <summary>
    ///   <para>rdfs:label : has domain name</para>
    ///   <para>rdfs:comment : A data property linking an entity to an internet domain name that has been registered for that entity, for example http://www.miidi.org for MIIDI, the Minimal Information standard for reporting an Infectious Disease Investigation.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasDomainName">frapo:hasDomainName</a>
    /// </summary>
    let hasDomainName = _prefixId.prefix "hasDomainName"
    /// <summary>
    ///   <para>rdfs:label : has end date</para>
    ///   <para>rdfs:comment : A data property linking something such as a project to its end date.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasEndDate">frapo:hasEndDate</a>
    /// </summary>
    let hasEndDate = _prefixId.prefix "hasEndDate"
    /// <summary>
    ///   <para>rdfs:label : has exchange rate</para>
    ///   <para>rdfs:comment : A data property specifying the currency exchange rate between two specified currencies.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasExchangeRate">frapo:hasExchangeRate</a>
    /// </summary>
    let hasExchangeRate = _prefixId.prefix "hasExchangeRate"
    /// <summary>
    ///   <para>rdfs:label : has expertise</para>
    ///   <para>rdfs:comment : A data property identifying the area(s) of expertise and skills posessed by an individual or an organization.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasExpertise">frapo:hasExpertise</a>
    /// </summary>
    let hasExpertise = _prefixId.prefix "hasExpertise"
    /// <summary>
    ///   <para>rdfs:label : has expiry date</para>
    ///   <para>rdfs:comment : A data property linking something, for example a drug, to its expiry date, beyond which the manufacture recommends that it should not be used.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasExpiryDate">frapo:hasExpiryDate</a>
    /// </summary>
    let hasExpiryDate = _prefixId.prefix "hasExpiryDate"
    /// <summary>
    ///   <para>rdfs:label : has familiar suffix</para>
    ///   <para>rdfs:comment : The letters that may be displayed after a person's name to indicate familial status, e.g. Sn., Jn., III, 3rd.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasFamilialSuffix">frapo:hasFamilialSuffix</a>
    /// </summary>
    let hasFamilialSuffix = _prefixId.prefix "hasFamilialSuffix"
    /// <summary>
    ///   <para>rdfs:label : has fax number</para>
    ///   <para>rdfs:comment : A data property identifying a Fax number for an agent.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasFaxNumber">frapo:hasFaxNumber</a>
    /// </summary>
    let hasFaxNumber = _prefixId.prefix "hasFaxNumber"
    /// <summary>
    ///   <para>rdfs:label : has funder identifer</para>
    ///   <para>rdfs:comment : A data property linking a funding agency to an identifier for that funding agency.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasFunderIdentifier">frapo:hasFunderIdentifier</a>
    /// </summary>
    let hasFunderIdentifier = _prefixId.prefix "hasFunderIdentifier"
    /// <summary>
    ///   <para>rdfs:label : has funding agency</para>
    ///   <para>rdfs:comment : An object property linking something to a funding agency that provides funding for it.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasFundingAgency">frapo:hasFundingAgency</a>
    /// </summary>
    let hasFundingAgency = _prefixId.prefix "hasFundingAgency"
    /// <summary>
    ///   <para>rdfs:label : has grant number</para>
    ///   <para>rdfs:comment : A data property specifying the grant number of a grant provided by a funding agency.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasGrantNumber">frapo:hasGrantNumber</a>
    /// </summary>
    let hasGrantNumber = _prefixId.prefix "hasGrantNumber"
    /// <summary>
    ///   <para>rdfs:label : has headcount</para>
    ///   <para>rdfs:comment : A data property specifying the number of people employed by an organization.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasHeadcount">frapo:hasHeadcount</a>
    /// </summary>
    let hasHeadcount = _prefixId.prefix "hasHeadcount"
    /// <summary>
    ///   <para>rdfs:label : post-nominals</para>
    ///   <para>rdfs:comment : The letters that should be displayed after a person's name to indicate qualification, membership or fellowship in a professional society, honours or elite status, e.g. MRCVS, FRCS, FRS, OBE, Kt.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasHonorificSuffix">frapo:hasHonorificSuffix</a>
    /// </summary>
    let hasHonorificSuffix = _prefixId.prefix "hasHonorificSuffix"
    /// <summary>
    ///   <para>rdfs:label : has IPR owner</para>
    ///   <para>rdfs:comment : An object property linking an entity such as a project, an endeavour or an output to an agent who owns the IPR arising from or related to that entity.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasIPROwner">frapo:hasIPROwner</a>
    /// </summary>
    let hasIPROwner = _prefixId.prefix "hasIPROwner"
    /// <summary>
    ///   <para>rdfs:label : has invoice date</para>
    ///   <para>rdfs:comment : A data property linking an invoice to its date.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasInvoiceDate">frapo:hasInvoiceDate</a>
    /// </summary>
    let hasInvoiceDate = _prefixId.prefix "hasInvoiceDate"
    /// <summary>
    ///   <para>rdfs:label : has job title</para>
    ///   <para>rdfs:comment : A data property permitting specification of the job title held by a person, such as might appear next to the name in a directory or on a conference name badge.  For example, the person's specific Job Title might be 'Linacre Professor of Zoology' or 'Regius Professor of Moral Philosophy'.
    ///
    /// This job title properly refers to the **role** held by that person (e.g. 'Head of Department'), which can be separately defined using SCoRO, the Scholarly Contributions and Roles Ontology (http://purl.org/spar/scoro/). [see scoro:withJobTitle].
    ///
    /// </para>
    ///   <a href="http://purl.org/cerif/frapo/hasJobTitle">frapo:hasJobTitle</a>
    /// </summary>
    let hasJobTitle = _prefixId.prefix "hasJobTitle"
    /// <summary>
    ///   <para>rdfs:label : has keyword</para>
    ///   <para>rdfs:comment : A data property permitting specification of a keyword relating to an entity.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasKeyword">frapo:hasKeyword</a>
    /// </summary>
    let hasKeyword = _prefixId.prefix "hasKeyword"
    /// <summary>
    ///   <para>rdfs:label : has language code</para>
    ///   <para>rdfs:comment : A data property specifying the two-letter or three-letter lower-case code used to identify a language (e.g. fr/fra for French, de/deu for Germany) (see http://en.wikipedia.org/wiki/List_of_ISO_639-1_codes).</para>
    ///   <a href="http://purl.org/cerif/frapo/hasLanguageCode">frapo:hasLanguageCode</a>
    /// </summary>
    let hasLanguageCode = _prefixId.prefix "hasLanguageCode"
    /// <summary>
    ///   <para>rdfs:label : has location</para>
    ///   <para>rdfs:comment : A data property link an entity to a relevant location, which might be geographical (e.g. New York City) or local (e.g. Freezer B, second shelf).</para>
    ///   <a href="http://purl.org/cerif/frapo/hasLocation">frapo:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    /// <summary>
    ///   <para>rdfs:label : has data of manufacture</para>
    ///   <para>rdfs:comment : A data property linking something to its date of manufacture.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasManufactureDate">frapo:hasManufactureDate</a>
    /// </summary>
    let hasManufactureDate = _prefixId.prefix "hasManufactureDate"
    /// <summary>
    ///   <para>rdfs:label : has milestone</para>
    ///   <para>rdfs:comment : A data property that permits one to define a significant event (a 'milestone') in the progress of a project.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasMilestone">frapo:hasMilestone</a>
    /// </summary>
    let hasMilestone = _prefixId.prefix "hasMilestone"
    /// <summary>
    ///   <para>rdfs:label : has model number</para>
    ///   <para>rdfs:comment : A data property linking something, for example a piece of equipment, to its model number.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasModelNumber">frapo:hasModelNumber</a>
    /// </summary>
    let hasModelNumber = _prefixId.prefix "hasModelNumber"
    /// <summary>
    ///   <para>rdfs:label : has value</para>
    ///   <para>rdfs:comment : A data property enabling one to specify the monetary value of a financial entity such as a grant, a gift or a budget category.  Use in conjuction with frapo:hasCurrency.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasMonetaryValue">frapo:hasMonetaryValue</a>
    /// </summary>
    let hasMonetaryValue = _prefixId.prefix "hasMonetaryValue"
    /// <summary>
    ///   <para>rdfs:label : has name suffix</para>
    ///   <para>rdfs:comment : The letters that should be displayed after a person's name.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasNameSuffix">frapo:hasNameSuffix</a>
    /// </summary>
    let hasNameSuffix = _prefixId.prefix "hasNameSuffix"
    /// <summary>
    ///   <para>dce:description : owl:equivalentProperty &lt;http://purl.org/spar/scoro/hasORCID&gt; .</para>
    ///   <para>rdfs:label : has ORCID</para>
    ///   <para>rdfs:comment : A data property relating an individual to his/her Open Researcher and Contributor ID (ORCID), an alphanumeric identifier for individual scholars described at http://about.orcid.org/.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasORCID">frapo:hasORCID</a>
    /// </summary>
    let hasORCID = _prefixId.prefix "hasORCID"
    /// <summary>
    ///   <para>rdfs:label : has organizational information</para>
    ///   <para>rdfs:comment : It describes information about the organization.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasOrganizationalInformation">frapo:hasOrganizationalInformation</a>
    /// </summary>
    let hasOrganizationalInformation = _prefixId.prefix "hasOrganizationalInformation"
    /// <summary>
    ///   <para>dce:description : Domain and range constraints have been removed from this object property to permit it to be used in unforeseen ways.</para>
    ///   <para>rdfs:label : has output</para>
    ///   <para>rdfs:comment : An object property linking an activity such as a project or endeavour to something that is created or produced as a result of that activity.  Examples include a building created as a result of a building project, and a journal article published to describe the results of a research investigation.  </para>
    ///   <a href="http://purl.org/cerif/frapo/hasOutput">frapo:hasOutput</a>
    /// </summary>
    let hasOutput = _prefixId.prefix "hasOutput"
    /// <summary>
    ///   <para>dce:description : owl:equivalentProperty &lt;http://purl.org/spar/datacite/hasPersonalIdentifier&gt; .^^xsd:stringdce:description : owl:equivalentProperty &lt;http://purl.org/spar/scoro/hasPersonalIdentifier&gt; .</para>
    ///   <para>rdfs:label : has personal identifier</para>
    ///   <para>rdfs:comment : A unique and unambiguous identifier for an individual person within a given context.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasPersonalIdentifier">frapo:hasPersonalIdentifier</a>
    /// </summary>
    let hasPersonalIdentifier = _prefixId.prefix "hasPersonalIdentifier"
    /// <summary>
    ///   <para>rdfs:label : has contact information</para>
    ///   <para>rdfs:comment : A data property linking a person to information about that person.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasPersonalInformation">frapo:hasPersonalInformation</a>
    /// </summary>
    let hasPersonalInformation = _prefixId.prefix "hasPersonalInformation"
    /// <summary>
    ///   <para>rdfs:label : has phone number</para>
    ///   <para>rdfs:comment : A data property identifying a telephone number for an agent.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasPhoneNumber">frapo:hasPhoneNumber</a>
    /// </summary>
    let hasPhoneNumber = _prefixId.prefix "hasPhoneNumber"
    /// <summary>
    ///   <para>rdfs:label : has post code</para>
    ///   <para>rdfs:comment : A data property defining the postal code of an address.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasPostCode">frapo:hasPostCode</a>
    /// </summary>
    let hasPostCode = _prefixId.prefix "hasPostCode"
    /// <summary>
    ///   <para>rdfs:label : has postal address</para>
    ///   <para>rdfs:comment : A data property identifying a postal address for an agent.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasPostalAddress">frapo:hasPostalAddress</a>
    /// </summary>
    let hasPostalAddress = _prefixId.prefix "hasPostalAddress"
    /// <summary>
    ///   <para>rdfs:label : has postal address line</para>
    ///   <para>rdfs:comment : A data property permitting specification of a single line of a postal address.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasPostalAddressLine">frapo:hasPostalAddressLine</a>
    /// </summary>
    let hasPostalAddressLine = _prefixId.prefix "hasPostalAddressLine"
    /// <summary>
    ///   <para>rdfs:label : has alternate name</para>
    ///   <para>rdfs:comment : An alternative name that a person uses for professional purposes, for example the pen name of an author, or a married woman's maiden name used as her professional name. </para>
    ///   <a href="http://purl.org/cerif/frapo/hasProfessionalName">frapo:hasProfessionalName</a>
    /// </summary>
    let hasProfessionalName = _prefixId.prefix "hasProfessionalName"
    /// <summary>
    ///   <para>rdfs:label : has project identifier</para>
    ///   <para>rdfs:comment : A data property linking a project to an identifier for that project.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasProjectIdentifier">frapo:hasProjectIdentifier</a>
    /// </summary>
    let hasProjectIdentifier = _prefixId.prefix "hasProjectIdentifier"
    /// <summary>
    ///   <para>rdfs:label : has provenance</para>
    ///   <para>rdfs:comment : A data property that permits the provenance of an entity to be described.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasProvenance">frapo:hasProvenance</a>
    /// </summary>
    let hasProvenance = _prefixId.prefix "hasProvenance"
    /// <summary>
    ///   <para>rdfs:label : has purchase date</para>
    ///   <para>rdfs:comment : A data property linking something to its purchase date.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasPurchaseDate">frapo:hasPurchaseDate</a>
    /// </summary>
    let hasPurchaseDate = _prefixId.prefix "hasPurchaseDate"
    /// <summary>
    ///   <para>rdfs:label : has purchase order number</para>
    ///   <para>rdfs:comment : A data property identifying an official purchase order issued by a purchasing agent to a supplier of goods or services, and used by the supplier to identify the order when delivering goods or submitting an invoice.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasPurchaseOrderNumber">frapo:hasPurchaseOrderNumber</a>
    /// </summary>
    let hasPurchaseOrderNumber = _prefixId.prefix "hasPurchaseOrderNumber"
    /// <summary>
    ///   <para>rdfs:label : has qualification</para>
    ///   <para>rdfs:comment : A data property permitting specification of the qualification held by a person.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasQualification">frapo:hasQualification</a>
    /// </summary>
    let hasQualification = _prefixId.prefix "hasQualification"
    /// <summary>
    ///   <para>rdfs:label : has quotation date</para>
    ///   <para>rdfs:comment : A data property linking a quotation to its date.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasQuotationDate">frapo:hasQuotationDate</a>
    /// </summary>
    let hasQuotationDate = _prefixId.prefix "hasQuotationDate"
    /// <summary>
    ///   <para>rdfs:label : has reference number</para>
    ///   <para>rdfs:comment : A data property linking something to a reference number for that item.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasReferenceNumber">frapo:hasReferenceNumber</a>
    /// </summary>
    let hasReferenceNumber = _prefixId.prefix "hasReferenceNumber"
    /// <summary>
    ///   <para>rdfs:label : has registration deadline</para>
    ///   <para>rdfs:comment : The date by which registration must be made, for example renewal of an internet domain name.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasRegistrationDeadline">frapo:hasRegistrationDeadline</a>
    /// </summary>
    let hasRegistrationDeadline = _prefixId.prefix "hasRegistrationDeadline"
    /// <summary>
    ///   <para>rdfs:label : has serial number</para>
    ///   <para>rdfs:comment : A data property linking something, for example a piece of equipment, to its serial number.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasSerialNumber">frapo:hasSerialNumber</a>
    /// </summary>
    let hasSerialNumber = _prefixId.prefix "hasSerialNumber"
    /// <summary>
    ///   <para>rdfs:label : has start date</para>
    ///   <para>rdfs:comment : A data property linking something such as a project to its start date.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasStartDate">frapo:hasStartDate</a>
    /// </summary>
    let hasStartDate = _prefixId.prefix "hasStartDate"
    /// <summary>
    ///   <para>rdfs:label : has supplier number</para>
    ///   <para>rdfs:comment : A data property linking a supplier to an identifying number for that supplier, typically used by the accounting system of the purchasing institution when placing and tracking orders.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasSupplierNumber">frapo:hasSupplierNumber</a>
    /// </summary>
    let hasSupplierNumber = _prefixId.prefix "hasSupplierNumber"
    /// <summary>
    ///   <para>rdfs:label : has temporal duration</para>
    ///   <para>rdfs:comment : A data property enabling one to define the temporal duration of some entity such as an event or a project.</para>
    ///   <a href="http://purl.org/cerif/frapo/hasTemporalDuration">frapo:hasTemporalDuration</a>
    /// </summary>
    let hasTemporalDuration = _prefixId.prefix "hasTemporalDuration"
    let indirect_costs = _prefixId.prefix "indirect-costs"
    /// <summary>
    ///   <para>rdfs:label : initials</para>
    ///   <para>rdfs:comment : A data property permitting specification of the initial(s) of a person's name.</para>
    ///   <a href="http://purl.org/cerif/frapo/initial">frapo:initial</a>
    /// </summary>
    let initial = _prefixId.prefix "initial"
    /// <summary>
    ///   <para>rdfs:label : is applied for by</para>
    ///   <para>rdfs:comment : An object property linking something applied for to the agent making the application.</para>
    ///   <a href="http://purl.org/cerif/frapo/isAppliedForBy">frapo:isAppliedForBy</a>
    /// </summary>
    let isAppliedForBy = _prefixId.prefix "isAppliedForBy"
    /// <summary>
    ///   <para>dce:description : Domain constraints have been removed from this object property to permit it to be used in unforeseen ways.</para>
    ///   <para>rdfs:label : is awarded by</para>
    ///   <para>rdfs:comment : An object property linking something awarded to the agent making the award, for example linking a grant to a funding agency, a degree to a university, or a prize to the awarding organization.</para>
    ///   <a href="http://purl.org/cerif/frapo/isAwardedBy">frapo:isAwardedBy</a>
    /// </summary>
    let isAwardedBy = _prefixId.prefix "isAwardedBy"
    /// <summary>
    ///   <para>dce:description : Domain constraints have been removed from this object property to permit it to be used in unforeseen ways.</para>
    ///   <para>rdfs:label : is donated by</para>
    ///   <para>rdfs:comment : An object property linking a gift to the benefactor who provided it.</para>
    ///   <a href="http://purl.org/cerif/frapo/isDonatedBy">frapo:isDonatedBy</a>
    /// </summary>
    let isDonatedBy = _prefixId.prefix "isDonatedBy"
    /// <summary>
    ///   <para>dce:description : This property should not be used for the other meaning of 'employ', meaning to use something, e.g. 'Great skill is employed by master craftsmen . . .'/</para>
    ///   <para>rdfs:label : is employed by</para>
    ///   <para>rdfs:comment : An object property relating an employed agent, typically a person or an organization, to an employing agent.</para>
    ///   <a href="http://purl.org/cerif/frapo/isEmployedBy">frapo:isEmployedBy</a>
    /// </summary>
    let isEmployedBy = _prefixId.prefix "isEmployedBy"
    /// <summary>
    ///   <para>dce:description : Domain and range constraints have been removed from this object property to permit it to be used in unforeseen ways.</para>
    ///   <para>rdfs:label : is enabled by</para>
    ///   <para>rdfs:comment : An object property relating an entity to another entity that enables it, e.g. linking an investigation to a project that enables it.</para>
    ///   <a href="http://purl.org/cerif/frapo/isEnabledBy">frapo:isEnabledBy</a>
    /// </summary>
    let isEnabledBy = _prefixId.prefix "isEnabledBy"
    /// <summary>
    ///   <para>rdfs:label : is evaluated by</para>
    ///   <para>rdfs:comment : An object property linking an entity to an agent that evaluates it.</para>
    ///   <a href="http://purl.org/cerif/frapo/isEvaluatedBy">frapo:isEvaluatedBy</a>
    /// </summary>
    let isEvaluatedBy = _prefixId.prefix "isEvaluatedBy"
    /// <summary>
    ///   <para>rdfs:label : is funded by</para>
    ///   <para>rdfs:comment : An object property linking something to the funding that funds it (i.e. that finances or pays for it), or to the funding agency providing that funding.  This flexibility is given because of alternative usages of the English word 'funds'.  [See also frapo:isAwardedBy and frapo:hasFundingAgency and frapo:isSupportedBy.]</para>
    ///   <a href="http://purl.org/cerif/frapo/isFundedBy">frapo:isFundedBy</a>
    /// </summary>
    let isFundedBy = _prefixId.prefix "isFundedBy"
    /// <summary>
    ///   <para>rdfs:label : is funding agency for</para>
    ///   <para>rdfs:comment : An object property linking a funding agency to an entity for which it provides funding.</para>
    ///   <a href="http://purl.org/cerif/frapo/isFundingAgencyFor">frapo:isFundingAgencyFor</a>
    /// </summary>
    let isFundingAgencyFor = _prefixId.prefix "isFundingAgencyFor"
    /// <summary>
    ///   <para>rdfs:label : is manufactured by</para>
    ///   <para>rdfs:comment : An object property relating a manufactured entity to its manufacturer.</para>
    ///   <a href="http://purl.org/cerif/frapo/isManufacturedBy">frapo:isManufacturedBy</a>
    /// </summary>
    let isManufacturedBy = _prefixId.prefix "isManufacturedBy"
    /// <summary>
    ///   <para>dce:description : Domain and range constraints have been removed from this object property to permit it to be used in unforeseen ways.</para>
    ///   <para>rdfs:label : is output of</para>
    ///   <para>rdfs:comment : An object property linking something that is created or produced to the activity that created or produced it.</para>
    ///   <a href="http://purl.org/cerif/frapo/isOutputOf">frapo:isOutputOf</a>
    /// </summary>
    let isOutputOf = _prefixId.prefix "isOutputOf"
    /// <summary>
    ///   <para>rdfs:label : is owned by</para>
    ///   <para>rdfs:comment : An object property linking an entity to the agent that owns it.</para>
    ///   <a href="http://purl.org/cerif/frapo/isOwnedBy">frapo:isOwnedBy</a>
    /// </summary>
    let isOwnedBy = _prefixId.prefix "isOwnedBy"
    /// <summary>
    ///   <para>dce:description : Domain constraints have been removed from this object property to permit it to be used in unforeseen ways.</para>
    ///   <para>rdfs:label : was purchased by</para>
    ///   <para>rdfs:comment : An object property relating a purchased entity to its purchaser.</para>
    ///   <a href="http://purl.org/cerif/frapo/isPurchasedBy">frapo:isPurchasedBy</a>
    /// </summary>
    let isPurchasedBy = _prefixId.prefix "isPurchasedBy"
    /// <summary>
    ///   <para>rdfs:label : is submitted by</para>
    ///   <para>rdfs:comment : An object property linking an entity that is submitted (to some third party) to the agent who submits it.</para>
    ///   <a href="http://purl.org/cerif/frapo/isSubmittedBy">frapo:isSubmittedBy</a>
    /// </summary>
    let isSubmittedBy = _prefixId.prefix "isSubmittedBy"
    /// <summary>
    ///   <para>rdfs:label : is supplied by</para>
    ///   <para>rdfs:comment : An object property relating an entity that is supplied, or an agent to whom an entity is supplied, to the supplier.</para>
    ///   <a href="http://purl.org/cerif/frapo/isSuppliedBy">frapo:isSuppliedBy</a>
    /// </summary>
    let isSuppliedBy = _prefixId.prefix "isSuppliedBy"
    /// <summary>
    ///   <para>dce:description : This property is not intended for use to describe mechanical or physical support, as in 'The statue is supported by the plinth'. </para>
    ///   <para>rdfs:label : is supported by</para>
    ///   <para>rdfs:comment : An object property linking something to an agent that provides funding or other support for it.</para>
    ///   <a href="http://purl.org/cerif/frapo/isSupportedBy">frapo:isSupportedBy</a>
    /// </summary>
    let isSupportedBy = _prefixId.prefix "isSupportedBy"
    /// <summary>
    ///   <para>rdfs:label : manufactures</para>
    ///   <para>rdfs:comment : An object property relating a manufacturer to a manufactured entity.</para>
    ///   <a href="http://purl.org/cerif/frapo/manufactures">frapo:manufactures</a>
    /// </summary>
    let manufactures = _prefixId.prefix "manufactures"
    let non_staff_costs = _prefixId.prefix "non-staff-costs"
    let other_costs = _prefixId.prefix "other-costs"
    let overhead_costs = _prefixId.prefix "overhead-costs"
    let owlsameAs = _prefixId.prefix "owl:sameAs"
    /// <summary>
    ///   <para>rdfs:label : owns</para>
    ///   <para>rdfs:comment : An object property linking an agent to an entity owned by that agent.</para>
    ///   <a href="http://purl.org/cerif/frapo/owns">frapo:owns</a>
    /// </summary>
    let owns = _prefixId.prefix "owns"
    /// <summary>
    ///   <para>rdfs:label : owns IPR of</para>
    ///   <para>rdfs:comment : An object property linking an agent who owns IPR arising from or relating to an entity to that entity.</para>
    ///   <a href="http://purl.org/cerif/frapo/ownsIRPOf">frapo:ownsIRPOf</a>
    /// </summary>
    let ownsIRPOf = _prefixId.prefix "ownsIRPOf"

    /// <summary>
    ///   <para>rdfs:label : percentage of total funding</para>
    ///   <para>rdfs:comment : An object property linking funding to a budget, specifying what fraction of the total budget is provided by that source of funding.</para>
    ///   <a href="http://purl.org/cerif/frapo/providesFractionOfTotalFunding">frapo:providesFractionOfTotalFunding</a>
    /// </summary>
    let providesFractionOfTotalFunding =
        _prefixId.prefix "providesFractionOfTotalFunding"

    /// <summary>
    ///   <para>dce:description : Range constraints have been removed from this object property to permit it to be used in unforeseen ways.</para>
    ///   <para>rdfs:label : provides service</para>
    ///   <para>rdfs:comment : An agent that provides a service.</para>
    ///   <a href="http://purl.org/cerif/frapo/providesService">frapo:providesService</a>
    /// </summary>
    let providesService = _prefixId.prefix "providesService"
    let publishing_costs = _prefixId.prefix "publishing-costs"
    /// <summary>
    ///   <para>dce:description : Range constraints have been removed from this object property to permit it to be used in unforeseen ways.</para>
    ///   <para>rdfs:label : purchases</para>
    ///   <para>rdfs:comment : An object property relating a purchaser to a purchased entity.</para>
    ///   <a href="http://purl.org/cerif/frapo/purchases">frapo:purchases</a>
    /// </summary>
    let purchases = _prefixId.prefix "purchases"
    /// <summary>
    ///   <para>dce:description : Domain and range constraints on this object property have been relaxed to permit it to be used in unforeseen ways.</para>
    ///   <para>rdfs:label : purchases from</para>
    ///   <para>rdfs:comment : An object property relating a purchaser to a supplier from whom the purchase is made.</para>
    ///   <a href="http://purl.org/cerif/frapo/purchasesFrom">frapo:purchasesFrom</a>
    /// </summary>
    let purchasesFrom = _prefixId.prefix "purchasesFrom"
    let rejected = _prefixId.prefix "rejected"
    /// <summary>
    ///   <para>dce:description : Domain and range constraints on this object property have been relaxed to permit it to be used in unforeseen ways.</para>
    ///   <para>rdfs:label : sells to</para>
    ///   <para>rdfs:comment : An object property relating a supplier to a purchaser to whom an entity is sold.</para>
    ///   <a href="http://purl.org/cerif/frapo/sellsTo">frapo:sellsTo</a>
    /// </summary>
    let sellsTo = _prefixId.prefix "sellsTo"
    let service_costs = _prefixId.prefix "service-costs"
    let software_costs = _prefixId.prefix "software-costs"
    /// <summary>
    ///   <para>dce:description : Range constraints have been removed from this object property to permit it to be used in unforeseen ways.</para>
    ///   <para>rdfs:label : specifies expenditure</para>
    ///   <para>rdfs:comment : An object property relating an agent or a budget to the expenditure specified by that agent or budget.</para>
    ///   <a href="http://purl.org/cerif/frapo/specifiesExpediture">frapo:specifiesExpediture</a>
    /// </summary>
    let specifiesExpediture = _prefixId.prefix "specifiesExpediture"
    /// <summary>
    ///   <para>rdfs:label : submits</para>
    ///   <para>rdfs:comment : An object property linking an agent to an entity that is submitted to some third party, for example a grant application submitted to a funding agency, a manuscript submitted to a publisher, a quotation submitted by a vendor, or a dataset submitted by a researcher to a data repository.</para>
    ///   <a href="http://purl.org/cerif/frapo/submits">frapo:submits</a>
    /// </summary>
    let submits = _prefixId.prefix "submits"
    /// <summary>
    ///   <para>dce:description : Domain constraints on this object property have been relaxed to permit it to be used in unforeseen ways.</para>
    ///   <para>rdfs:label : supplies</para>
    ///   <para>rdfs:comment : An object property relating a supplier to a supplied entity, or to an agent to whom the entity is supplied.</para>
    ///   <a href="http://purl.org/cerif/frapo/supplies">frapo:supplies</a>
    /// </summary>
    let supplies = _prefixId.prefix "supplies"
    /// <summary>
    ///   <para>dce:description : This property is not intended for use to describe mechanical or physical support, as in 'The plinth supports the statue'. </para>
    ///   <para>rdfs:label : supports</para>
    ///   <para>rdfs:comment : An object property linking an agent to something that the agent supports by financial or other means.</para>
    ///   <a href="http://purl.org/cerif/frapo/supports">frapo:supports</a>
    /// </summary>
    let supports = _prefixId.prefix "supports"
    let travel_and_subsistence_costs = _prefixId.prefix "travel-and-subsistence-costs"
    let unfunded = _prefixId.prefix "unfunded"
    /// <summary>
    ///   <para>dce:description : Domain constraints have been removed from this object property to permit it to be used in unforeseen ways.</para>
    ///   <para>rdfs:label : uses equipment</para>
    ///   <para>rdfs:comment : An object property linking an activity such as an expedition, a research project or an investigation, to an item of equipment employed in that activity.</para>
    ///   <a href="http://purl.org/cerif/frapo/usesEquipment">frapo:usesEquipment</a>
    /// </summary>
    let usesEquipment = _prefixId.prefix "usesEquipment"
    /// <summary>
    ///   <para>dce:description : Domain constraints have been removed from this object property to permit it to be used in unforeseen ways.</para>
    ///   <para>rdfs:label : uses facility</para>
    ///   <para>rdfs:comment : An object property linking an activity such as an expedition, a research project or an investigation, to a facility employed in that activity.</para>
    ///   <a href="http://purl.org/cerif/frapo/usesFacility">frapo:usesFacility</a>
    /// </summary>
    let usesFacility = _prefixId.prefix "usesFacility"
    /// <summary>
    ///   <para>dce:description : Domain constraints have been removed from this object property to permit it to be used in unforeseen ways.</para>
    ///   <para>rdfs:label : uses service</para>
    ///   <para>rdfs:comment : An object property linking an activity such as an expedition, a research project or an investigation, to a service employed in that activity.</para>
    ///   <a href="http://purl.org/cerif/frapo/usesService">frapo:usesService</a>
    /// </summary>
    let usesService = _prefixId.prefix "usesService"
