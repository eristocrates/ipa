namespace http.purl.org.cerif.frapo.slash

open DoxAletheia.Rdf_Vocabulary

module frapo =
    let _namespace_name = "http://purl.org/cerif/frapo/"
    /// <summary>
    /// A mechanism for administering money, typically owned by an agent and dedicated to a particular purpose, for example the equipment account of a university department, to be used only for the purchase or maintenance of items of equipment.
    /// <see href="http://purl.org/cerif/frapo/Account"></see></summary>
    let Account = Namespaced_IRI.parse _namespace_name "Account" |> NamespacedName

    /// <summary>
    /// An entity primarily to do with money.
    /// <see href="http://purl.org/cerif/frapo/FinancialEntity"></see></summary>
    let FinancialEntity =
        Namespaced_IRI.parse _namespace_name "FinancialEntity" |> NamespacedName

    /// <summary>
    /// A statement of income and expenditure for an account, typically presented as dated income receipts and outgoings against categories in a budget for that account.
    /// <see href="http://purl.org/cerif/frapo/AccountStatement"></see></summary>
    let AccountStatement =
        Namespaced_IRI.parse _namespace_name "AccountStatement" |> NamespacedName

    /// <summary>
    /// The activity of applying for admission to some group or institution, for example a learned society or a university.
    /// <see href="http://purl.org/cerif/frapo/AdmissionApplication"></see></summary>
    let AdmissionApplication =
        Namespaced_IRI.parse _namespace_name "AdmissionApplication" |> NamespacedName

    /// <summary>
    /// The activity of making an application, for example for a job, or for funding.
    /// <see href="http://purl.org/cerif/frapo/Application"></see></summary>
    let Application =
        Namespaced_IRI.parse _namespace_name "Application" |> NamespacedName

    /// <summary>
    /// The anual financial turnover of an organization (in a specified currency).
    /// <see href="http://purl.org/cerif/frapo/AnnualTurnover"></see></summary>
    let AnnualTurnover =
        Namespaced_IRI.parse _namespace_name "AnnualTurnover" |> NamespacedName

    /// <summary>
    /// A fee levied by a publisher on an author or an institution to cover the cost of publishing an Open Access journal article.  Also knows as Article Processing Fee, Article Publication Charge, Author Processing Charge or Author Publishing Charge.
    /// <see href="http://purl.org/cerif/frapo/ArticleProcessingCharge"></see></summary>
    let ArticleProcessingCharge =
        Namespaced_IRI.parse _namespace_name "ArticleProcessingCharge" |> NamespacedName

    /// <summary>
    /// An amount of money paid for something that is not purchased.
    /// <see href="http://purl.org/cerif/frapo/Fee"></see></summary>
    let Fee = Namespaced_IRI.parse _namespace_name "Fee" |> NamespacedName

    /// <summary>
    /// The amount available to spend in a budget category, equalling the income minus the expenditure to date plus future expenditure commitments.
    /// <see href="http://purl.org/cerif/frapo/AvailableFunds"></see></summary>
    let AvailableFunds =
        Namespaced_IRI.parse _namespace_name "AvailableFunds" |> NamespacedName

    /// <summary>
    /// Information about an aspect of a budget.
    /// <see href="http://purl.org/cerif/frapo/BudgetInformation"></see></summary>
    let BudgetInformation =
        Namespaced_IRI.parse _namespace_name "BudgetInformation" |> NamespacedName

    /// <summary>
    /// A structured statement of how funds are to be used for expenditure in defined budget categories.  A budget is created, for example, when applying for funding for a project, and is subsequently used to manage the expenditure from the awarded grant for that project.
    /// <see href="http://purl.org/cerif/frapo/Budget"></see></summary>
    let Budget = Namespaced_IRI.parse _namespace_name "Budget" |> NamespacedName

    /// <summary>
    /// A category of expenditure within a budget, determining what the allocated money can be spent on, for example salaries, equipment, travel.
    /// <see href="http://purl.org/cerif/frapo/BudgetCategory"></see></summary>
    let BudgetCategory =
        Namespaced_IRI.parse _namespace_name "BudgetCategory" |> NamespacedName

    /// <summary>
    /// The amount of money originally available to spend in a particular budget category.
    /// <see href="http://purl.org/cerif/frapo/BudgetedAmount"></see></summary>
    let BudgetedAmount =
        Namespaced_IRI.parse _namespace_name "BudgetedAmount" |> NamespacedName

    /// <summary>
    /// An amount of money given to a person by an organization, for example by a university to a university student in need to enable that student to continue his/her studies.
    /// <see href="http://purl.org/cerif/frapo/Bursary"></see></summary>
    let Bursary = Namespaced_IRI.parse _namespace_name "Bursary" |> NamespacedName
    /// <summary>
    /// An amount of money available to finance some project or activity.
    /// <see href="http://purl.org/cerif/frapo/Funding"></see></summary>
    let Funding = Namespaced_IRI.parse _namespace_name "Funding" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cerif/frapo/Business_angel"></see>
    /// </summary>
    let Business_angel =
        Namespaced_IRI.parse _namespace_name "Business_angel" |> NamespacedName

    /// <summary>
    /// An academic organization that is either a small degree-giving university, or (in the OxBridge sense) an independent corporation of scholars within a larger university, providing undergraduate tuition and a social environment for its students and fellows.
    /// <see href="http://purl.org/cerif/frapo/College"></see></summary>
    let College = Namespaced_IRI.parse _namespace_name "College" |> NamespacedName

    /// <summary>
    /// Money set aside to honour expenditures already made but for which no invoices have yet been received, or expenditures planned for the future, for example for salaries.
    /// <see href="http://purl.org/cerif/frapo/Commitments"></see></summary>
    let Commitments =
        Namespaced_IRI.parse _namespace_name "Commitments" |> NamespacedName

    /// <summary>
    /// A commercial company or business run for profit.
    /// <see href="http://purl.org/cerif/frapo/Company"></see></summary>
    let Company = Namespaced_IRI.parse _namespace_name "Company" |> NamespacedName

    /// <summary>
    /// A computer system or software program whose action has an effect on external events, for example a laboratory robot that undertakes your experiments, or the financial control system that controls an institution's payrole, or that, following programmed business rules, prevents the principal investigator from placing an order for research equipment because there is insufficient money left in the project budget.
    /// <see href="http://purl.org/cerif/frapo/ComputationalAgent"></see></summary>
    let ComputationalAgent =
        Namespaced_IRI.parse _namespace_name "ComputationalAgent" |> NamespacedName

    /// <summary>
    /// A service provided by a computer system.
    /// <see href="http://purl.org/cerif/frapo/ComputationalService"></see></summary>
    let ComputationalService =
        Namespaced_IRI.parse _namespace_name "ComputationalService" |> NamespacedName

    /// <summary>
    /// A service of help to others, often requiring funding, employees, equipment and/or facilities for its provision, for example a library service, a transportation service, a DNA sequencing service.
    /// <see href="http://purl.org/cerif/frapo/Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    /// A fee paid to attend a conference.
    /// <see href="http://purl.org/cerif/frapo/ConferenceFee"></see></summary>
    let ConferenceFee =
        Namespaced_IRI.parse _namespace_name "ConferenceFee" |> NamespacedName

    /// <summary>
    /// A formal agreement between members of a consortium, for example between research groups at different universities engaged in a multi-partner research project.
    /// <see href="http://purl.org/cerif/frapo/ConsortiumAgreement"></see></summary>
    let ConsortiumAgreement =
        Namespaced_IRI.parse _namespace_name "ConsortiumAgreement" |> NamespacedName

    /// <summary>
    /// A legally binding agreement between parties.
    /// <see href="http://purl.org/cerif/frapo/Contract"></see></summary>
    let Contract = Namespaced_IRI.parse _namespace_name "Contract" |> NamespacedName

    /// <summary>
    /// A contract between an employer and a consultant, detailing the terms of the consultancy.
    /// <see href="http://purl.org/cerif/frapo/ConsultancyAgreement"></see></summary>
    let ConsultancyAgreement =
        Namespaced_IRI.parse _namespace_name "ConsultancyAgreement" |> NamespacedName

    /// <summary>
    /// A facility in which digital data are deposited for long-term preservation and (optional) publication.
    /// <see href="http://purl.org/cerif/frapo/DataRepository"></see></summary>
    let DataRepository =
        Namespaced_IRI.parse _namespace_name "DataRepository" |> NamespacedName

    /// <summary>
    /// A facility in which entities can be deposited for long-term preservation.
    /// <see href="http://purl.org/cerif/frapo/Repository"></see></summary>
    let Repository = Namespaced_IRI.parse _namespace_name "Repository" |> NamespacedName

    /// <summary>
    /// A class defining a 'deliverable' of a project, i.e. something that the project set out to deliver, or succeeds in delivering.
    /// <see href="http://purl.org/cerif/frapo/Deliverable"></see></summary>
    let Deliverable =
        Namespaced_IRI.parse _namespace_name "Deliverable" |> NamespacedName

    /// <summary>
    /// Something that is created or produced as a result of a project or an endeavour. Examples include a building resulting from a building project, educated students graduating from an educational programme, and a journal article published as a result of a research project.  Research outputs can also include reports, datasets, experimental protocols, workflows and mathematical models, and material outputs such as a cell line, a mouse mutant or a new form of microscope.
    /// <see href="http://purl.org/cerif/frapo/Output"></see></summary>
    let Output = Namespaced_IRI.parse _namespace_name "Output" |> NamespacedName
    /// <summary>
    /// A department or sub-section within a larger organization, for example a university academic department.
    /// <see href="http://purl.org/cerif/frapo/Department"></see></summary>
    let Department = Namespaced_IRI.parse _namespace_name "Department" |> NamespacedName
    /// <summary>
    /// A grouping of similar departments within a larger organization.  In the university context, also known as a school or a faculty, for example the Humanities Division, the Mathematics Faculty, or the School of Medicine.
    /// <see href="http://purl.org/cerif/frapo/Division"></see></summary>
    let Division = Namespaced_IRI.parse _namespace_name "Division" |> NamespacedName

    /// <summary>
    /// A facility in which digital documents are deposited for long-term preservation and (optional) publication.
    /// <see href="http://purl.org/cerif/frapo/DocumentRepository"></see></summary>
    let DocumentRepository =
        Namespaced_IRI.parse _namespace_name "DocumentRepository" |> NamespacedName

    /// <summary>
    /// The activity of applying for a job.
    /// <see href="http://purl.org/cerif/frapo/EmploymentApplication"></see></summary>
    let EmploymentApplication =
        Namespaced_IRI.parse _namespace_name "EmploymentApplication" |> NamespacedName

    /// <summary>
    /// A contract of employment between a person and an organization.
    /// <see href="http://purl.org/cerif/frapo/EmploymentContract"></see></summary>
    let EmploymentContract =
        Namespaced_IRI.parse _namespace_name "EmploymentContract" |> NamespacedName

    /// <summary>
    /// In FRAPO, an endeavour is an activity such as a research investigation that is enabled by a project.  An endeavour relate to the academic and practical aspects of undertaking that endeavour - thus for a research investigation the research itself, including the hypotheses being investigated, the experiments being undertaken, the data being gathered and analysed, the interpretations being drawn from the data, and the results obtained.  In contrast, the project relates to the administrative aspects of undertaking an endeavour, including the funding obtained, the people employed, and the management of the project in terms of deadlines and deliverables.
    /// <see href="http://purl.org/cerif/frapo/Endeavour"></see></summary>
    let Endeavour = Namespaced_IRI.parse _namespace_name "Endeavour" |> NamespacedName
    /// <summary>
    /// A transfer, generally as a gift, of money or property to an institution to provide a permanent fund, the income from which is to be used for a particular purpose.  (Abbreviated from http://legal-dictionary.thefreedictionary.com/endowment).
    /// <see href="http://purl.org/cerif/frapo/Endowment"></see></summary>
    let Endowment = Namespaced_IRI.parse _namespace_name "Endowment" |> NamespacedName
    /// <summary>
    /// A gift, donation, benefaction or legacy, typically of money.
    /// <see href="http://purl.org/cerif/frapo/Gift"></see></summary>
    let Gift = Namespaced_IRI.parse _namespace_name "Gift" |> NamespacedName
    /// <summary>
    /// An item of equipment or apparatus, or a laboratory instrument, for example a refrigerated centrifuge.
    /// <see href="http://purl.org/cerif/frapo/Equipment"></see></summary>
    let Equipment = Namespaced_IRI.parse _namespace_name "Equipment" |> NamespacedName

    /// <summary>
    /// An entity that facilitates work.
    /// <see href="http://purl.org/cerif/frapo/InfrastructureEntity"></see></summary>
    let InfrastructureEntity =
        Namespaced_IRI.parse _namespace_name "InfrastructureEntity" |> NamespacedName

    /// <summary>
    /// Money going out of an account, because of expenditure on various entities. May be associated with a particular budget category.
    /// <see href="http://purl.org/cerif/frapo/Expenditure"></see></summary>
    let Expenditure =
        Namespaced_IRI.parse _namespace_name "Expenditure" |> NamespacedName

    /// <summary>
    /// Total money expended to date from an an account, or from a particular budget category.
    /// <see href="http://purl.org/cerif/frapo/ExpenditureToDate"></see></summary>
    let ExpenditureToDate =
        Namespaced_IRI.parse _namespace_name "ExpenditureToDate" |> NamespacedName

    /// <summary>
    /// A place or installation built or designed to serve a specific function or provide a specific service, for example an animal breeding centre, a DNA sequencing facility or a confocal imaging laboratory.
    /// <see href="http://purl.org/cerif/frapo/Facility"></see></summary>
    let Facility = Namespaced_IRI.parse _namespace_name "Facility" |> NamespacedName
    /// <summary>
    /// A grouping of similar departments within a university context, also known as a school or a division, for example the Humanities Division, the Mathematics Faculty, or the School of Medicine.
    /// <see href="http://purl.org/cerif/frapo/Faculty"></see></summary>
    let Faculty = Namespaced_IRI.parse _namespace_name "Faculty" |> NamespacedName
    /// <summary>
    /// The stipend paid to a fellow in a college or university.
    /// <see href="http://purl.org/cerif/frapo/Fellowship"></see></summary>
    let Fellowship = Namespaced_IRI.parse _namespace_name "Fellowship" |> NamespacedName
    /// <summary>
    /// A sum of money allotted on a regular basis, usually for some specific purpose.
    /// <see href="http://purl.org/cerif/frapo/Stipend"></see></summary>
    let Stipend = Namespaced_IRI.parse _namespace_name "Stipend" |> NamespacedName

    /// <summary>
    /// A software system controlling the financial activities of an organization, for example determining full economic cost budgets for grant applications, and managing the funding of funded projects.
    /// <see href="http://purl.org/cerif/frapo/FinancialControlSystem"></see></summary>
    let FinancialControlSystem =
        Namespaced_IRI.parse _namespace_name "FinancialControlSystem" |> NamespacedName

    /// <summary>
    /// An organization that provides funding for projects, often in the form of grants awarded on the basis of competitive application.
    /// <see href="http://purl.org/cerif/frapo/FundingAgency"></see></summary>
    let FundingAgency =
        Namespaced_IRI.parse _namespace_name "FundingAgency" |> NamespacedName

    /// <summary>
    /// The activity of applying for funding.
    /// <see href="http://purl.org/cerif/frapo/FundingApplication"></see></summary>
    let FundingApplication =
        Namespaced_IRI.parse _namespace_name "FundingApplication" |> NamespacedName

    /// <summary>
    /// A programme of related funded activities or projects, typically established by a funding agency.  Often associated with publication of a call for applications (fabio:CallForApplications).
    /// <see href="http://purl.org/cerif/frapo/FundingProgramme"></see></summary>
    let FundingProgramme =
        Namespaced_IRI.parse _namespace_name "FundingProgramme" |> NamespacedName

    /// <summary>
    /// An organization that is part of, or funded by, central or local goverment.
    /// <see href="http://purl.org/cerif/frapo/GovernmentOrganization"></see></summary>
    let GovernmentOrganization =
        Namespaced_IRI.parse _namespace_name "GovernmentOrganization" |> NamespacedName

    /// <summary>
    /// A financial award by a funding agency for a particular project or purpose, usually awarded on the basis of a competitive application.
    /// <see href="http://purl.org/cerif/frapo/Grant"></see></summary>
    let Grant = Namespaced_IRI.parse _namespace_name "Grant" |> NamespacedName

    /// <summary>
    /// An institution that acts as a host, for example of a project or a person.
    /// <see href="http://purl.org/cerif/frapo/HostInstitution"></see></summary>
    let HostInstitution =
        Namespaced_IRI.parse _namespace_name "HostInstitution" |> NamespacedName

    /// <summary>
    /// Money coming into an account.  May be associated with a particular budget category.
    /// <see href="http://purl.org/cerif/frapo/Income"></see></summary>
    let Income = Namespaced_IRI.parse _namespace_name "Income" |> NamespacedName

    /// <summary>
    /// An investigation is an endeavour that involves research, enabled by a project.
    ///
    /// The investigation relate to the scholarly and practical aspects of conducting the research itself, including the hypotheses being investigated, the experiments being undertaken, the data being gathered and analysed, the interpretations being drawn from the data, and the results obtained.
    ///
    /// In contrast, the project that enables it encompasses the administrative aspects of undertaking the endeavour, including the funding obtained, the people employed, and the management of the project in terms of deadlines and deliverables.
    /// <see href="http://purl.org/cerif/frapo/Investigation"></see></summary>
    let Investigation =
        Namespaced_IRI.parse _namespace_name "Investigation" |> NamespacedName

    /// <summary>
    /// An investment of money, generally in stocks and shares, or in property, for the purpose of safeguarding the capital and yielding an income.
    /// <see href="http://purl.org/cerif/frapo/Investment"></see></summary>
    let Investment = Namespaced_IRI.parse _namespace_name "Investment" |> NamespacedName
    /// <summary>
    /// An invoice for payment of goods or services.
    /// <see href="http://purl.org/cerif/frapo/Invoice"></see></summary>
    let Invoice = Namespaced_IRI.parse _namespace_name "Invoice" |> NamespacedName
    /// <summary>
    /// A facility in which research can be conducted.
    /// <see href="http://purl.org/cerif/frapo/Laboratory"></see></summary>
    let Laboratory = Namespaced_IRI.parse _namespace_name "Laboratory" |> NamespacedName
    /// <summary>
    /// A gift of money or property specified in the will of a person, that is made after that person's death.
    /// <see href="http://purl.org/cerif/frapo/Legacy"></see></summary>
    let Legacy = Namespaced_IRI.parse _namespace_name "Legacy" |> NamespacedName
    /// <summary>
    /// A facility in which printed documents (for example books and journals) are deposited for long-term preservation and access.
    /// <see href="http://purl.org/cerif/frapo/Library"></see></summary>
    let Library = Namespaced_IRI.parse _namespace_name "Library" |> NamespacedName

    /// <summary>
    /// An agent who manufactures goods or equipment.
    /// <see href="http://purl.org/cerif/frapo/Manufacturer"></see></summary>
    let Manufacturer =
        Namespaced_IRI.parse _namespace_name "Manufacturer" |> NamespacedName

    /// <summary>
    /// A material or physical output created or produced as a result of a project or an endeavour such as a research investigation. Examples include a building constructed as a result of a building project, and research outputs such as a cell line, a mouse mutant or a new form of microscope.
    /// <see href="http://purl.org/cerif/frapo/MaterialOutput"></see></summary>
    let MaterialOutput =
        Namespaced_IRI.parse _namespace_name "MaterialOutput" |> NamespacedName

    /// <summary>
    /// An organization that does not primarily exist to make profit, for example a charity or charitable foundation, a learned society, or a standards body such as the World Wide Web Consortium.
    /// <see href="http://purl.org/cerif/frapo/NotForProfitOrganization"></see></summary>
    let NotForProfitOrganization =
        Namespaced_IRI.parse _namespace_name "NotForProfitOrganization" |> NamespacedName

    /// <summary>
    /// The agent who owns an entity.
    /// <see href="http://purl.org/cerif/frapo/Owner"></see></summary>
    let Owner = Namespaced_IRI.parse _namespace_name "Owner" |> NamespacedName
    /// <summary>
    /// A financial payment made, for example in exchange for something purchased such as property, goods or services, or to refund expenses incurred.
    /// <see href="http://purl.org/cerif/frapo/Payment"></see></summary>
    let Payment = Namespaced_IRI.parse _namespace_name "Payment" |> NamespacedName

    /// <summary>
    /// A postal address.
    /// <see href="http://purl.org/cerif/frapo/PostalAddress"></see></summary>
    let PostalAddress =
        Namespaced_IRI.parse _namespace_name "PostalAddress" |> NamespacedName

    /// <summary>
    /// A budget for a research project.
    /// <see href="http://purl.org/cerif/frapo/ProjectBudget"></see></summary>
    let ProjectBudget =
        Namespaced_IRI.parse _namespace_name "ProjectBudget" |> NamespacedName

    /// <summary>
    /// The payment for obtaining something, for example property, goods or services.
    /// <see href="http://purl.org/cerif/frapo/Purchase"></see></summary>
    let Purchase = Namespaced_IRI.parse _namespace_name "Purchase" |> NamespacedName

    /// <summary>
    /// An official order from a purchasing institution to a supplier for the purchase of goods or services, often issued in response to the receipt of a quotation from the supplier.
    /// <see href="http://purl.org/cerif/frapo/PurchaseOrder"></see></summary>
    let PurchaseOrder =
        Namespaced_IRI.parse _namespace_name "PurchaseOrder" |> NamespacedName

    /// <summary>
    /// An agent who purchases something from a supplier.
    /// <see href="http://purl.org/cerif/frapo/Purchaser"></see></summary>
    let Purchaser = Namespaced_IRI.parse _namespace_name "Purchaser" |> NamespacedName
    /// <summary>
    /// A formal statement of promise (usually provided in response to a request for quotation) by potential supplier to supply goods or services at specified prices and within a specified period. Acceptance of the quotation by the buyer constitutes an agreement binding on both parties.  (Shortened from http://www.businessdictionary.com/definition/quotation.html).
    ///
    /// <see href="http://purl.org/cerif/frapo/Quotation"></see></summary>
    let Quotation = Namespaced_IRI.parse _namespace_name "Quotation" |> NamespacedName

    /// <summary>
    /// An organization that acts to register things.  For example, CrossRef is a registration agency for DOIs relating to documents, while DataCite is a registration agency for DOIs relating to datasets.
    /// <see href="http://purl.org/cerif/frapo/RegistrationAgency"></see></summary>
    let RegistrationAgency =
        Namespaced_IRI.parse _namespace_name "RegistrationAgency" |> NamespacedName

    /// <summary>
    /// An agency with responsibility for registering and maintaining international standards, internet domain names, patents, controlled vocabularies and other similar entities required for reliable international cooperatative activities.
    /// <see href="http://purl.org/cerif/frapo/RegistrationAuthority"></see></summary>
    let RegistrationAuthority =
        Namespaced_IRI.parse _namespace_name "RegistrationAuthority" |> NamespacedName

    /// <summary>
    /// A group of people, usually within a university department or a research institute, and typically under a single group leader, dedicated to working together to undertake research on one or more topics. May also be called a research unit.
    /// <see href="http://purl.org/cerif/frapo/ResearchGroup"></see></summary>
    let ResearchGroup =
        Namespaced_IRI.parse _namespace_name "ResearchGroup" |> NamespacedName

    /// <summary>
    /// A database containing administrative information about the research undertaken in an institution, and the publications and other outputs from such research.
    /// <see href="http://purl.org/cerif/frapo/ResearchInformationSystem"></see></summary>
    let ResearchInformationSystem =
        Namespaced_IRI.parse _namespace_name "ResearchInformationSystem" |> NamespacedName

    /// <summary>
    /// An organization primarily dedicated to undertaking research, that might be part of a university or of a commercial company, or might be independently funded by a research funding agency.
    /// <see href="http://purl.org/cerif/frapo/ResearchInstitute"></see></summary>
    let ResearchInstitute =
        Namespaced_IRI.parse _namespace_name "ResearchInstitute" |> NamespacedName

    /// <summary>
    /// A small to medium enterprise, having up to 250 employees.
    /// <see href="http://purl.org/cerif/frapo/SME"></see></summary>
    let SME = Namespaced_IRI.parse _namespace_name "SME" |> NamespacedName

    /// <summary>
    /// A financial grant to a scholar to enable him/her to undertake advanced academic study.
    /// <see href="http://purl.org/cerif/frapo/Scholarship"></see></summary>
    let Scholarship =
        Namespaced_IRI.parse _namespace_name "Scholarship" |> NamespacedName

    /// <summary>
    /// The activity of applying for an educational scholarship.
    /// <see href="http://purl.org/cerif/frapo/ScholarshipApplication"></see></summary>
    let ScholarshipApplication =
        Namespaced_IRI.parse _namespace_name "ScholarshipApplication" |> NamespacedName

    /// <summary>
    /// A contract for the provision of a service such as a cleaning service, or for the regular servicing, maintenance and repair of some item of equipment or infrastructure.
    /// <see href="http://purl.org/cerif/frapo/ServiceContract"></see></summary>
    let ServiceContract =
        Namespaced_IRI.parse _namespace_name "ServiceContract" |> NamespacedName

    /// <summary>
    /// A fee paid periodically, typically annually, to obtain access when required to a service such as an equipment maintenance contract."
    /// <see href="http://purl.org/cerif/frapo/ServiceContractFee"></see></summary>
    let ServiceContractFee =
        Namespaced_IRI.parse _namespace_name "ServiceContractFee" |> NamespacedName

    /// <summary>
    /// A company that has been established by a university or research institute to mature and market the results of research conducted at that research institution.
    /// <see href="http://purl.org/cerif/frapo/SpinOffCompany"></see></summary>
    let SpinOffCompany =
        Namespaced_IRI.parse _namespace_name "SpinOffCompany" |> NamespacedName

    /// <summary>
    /// The status of something such as an application, an investigation or a project.
    /// <see href="http://purl.org/cerif/frapo/Status"></see></summary>
    let Status = Namespaced_IRI.parse _namespace_name "Status" |> NamespacedName

    /// <summary>
    /// A financial grant to a student to enable him/her to undertake advanced academic study.
    /// <see href="http://purl.org/cerif/frapo/Studentship"></see></summary>
    let Studentship =
        Namespaced_IRI.parse _namespace_name "Studentship" |> NamespacedName

    /// <summary>
    /// Payment, commonly made annually, to obtain access to something on a periodic or continuing basis, such as a journal.
    /// <see href="http://purl.org/cerif/frapo/Subscription"></see></summary>
    let Subscription =
        Namespaced_IRI.parse _namespace_name "Subscription" |> NamespacedName

    /// <summary>
    /// An agent who supplies something, such as goods or services.
    /// <see href="http://purl.org/cerif/frapo/Supplier"></see></summary>
    let Supplier = Namespaced_IRI.parse _namespace_name "Supplier" |> NamespacedName
    /// <summary>
    /// Sealed bid or offer document submitted in response to a request for tenders, containing detailed information on costs, requirements and terms associated with a potential contract.  (Adapted from http://www.businessdictionary.com/definition/tender.html).
    /// <see href="http://purl.org/cerif/frapo/Tender"></see></summary>
    let Tender = Namespaced_IRI.parse _namespace_name "Tender" |> NamespacedName
    /// <summary>
    /// A university at which higher education and research is conducted.
    /// <see href="http://purl.org/cerif/frapo/University"></see></summary>
    let University = Namespaced_IRI.parse _namespace_name "University" |> NamespacedName
    /// <summary>
    /// An agent who supplies goods or services in exchange for payment, in response to receipt of payment or of an official purchase order from a purchaser that is responded to by submission of an invoice for what is supplied.
    /// <see href="http://purl.org/cerif/frapo/Vendor"></see></summary>
    let Vendor = Namespaced_IRI.parse _namespace_name "Vendor" |> NamespacedName
    /// <summary>
    /// A member of the academic staff of an academic institution such as a university.
    /// <see href="http://purl.org/cerif/frapo/academic"></see></summary>
    let academic = Namespaced_IRI.parse _namespace_name "academic" |> NamespacedName
    /// <summary>
    /// The status of something such as an application as having been accepted.
    /// <see href="http://purl.org/cerif/frapo/accepted"></see></summary>
    let accepted = Namespaced_IRI.parse _namespace_name "accepted" |> NamespacedName
    /// <summary>
    /// An object property linking an agent to something for which that agent applies, for example a job, membership of an organization, or a grant from a funding agency.
    /// <see href="http://purl.org/cerif/frapo/appliesFor"></see></summary>
    let appliesFor = Namespaced_IRI.parse _namespace_name "appliesFor" |> NamespacedName
    /// <summary>
    /// An object property linking an agent to something the agent awards, for example linking a funding agency to a grant, a university to a degree, or an organization to a prize.
    /// <see href="http://purl.org/cerif/frapo/awards"></see></summary>
    let awards = Namespaced_IRI.parse _namespace_name "awards" |> NamespacedName
    /// <summary>
    /// A person who gives a gift.
    /// <see href="http://purl.org/cerif/frapo/benefactor"></see></summary>
    let benefactor = Namespaced_IRI.parse _namespace_name "benefactor" |> NamespacedName

    /// <summary>
    /// A budget category to cover the costs of constructing, renovating or modifying a physical building.
    /// <see href="http://purl.org/cerif/frapo/building-costs"></see></summary>
    let ``building-costs`` =
        Namespaced_IRI.parse _namespace_name "building-costs" |> NamespacedName

    /// <summary>
    /// A person willing to invest in start-up companies.
    /// <see href="http://purl.org/cerif/frapo/business-angel"></see></summary>
    let ``business-angel`` =
        Namespaced_IRI.parse _namespace_name "business-angel" |> NamespacedName

    /// <summary>
    /// An object property linking agents, for example different organizations, or people typically from different groups or organizations, that work together on a common task, project or endeavour, or towards a common goal.
    /// <see href="http://purl.org/cerif/frapo/collaboratesWith"></see></summary>
    let collaboratesWith =
        Namespaced_IRI.parse _namespace_name "collaboratesWith" |> NamespacedName

    /// <summary>
    /// A budget category to cover the costs of consultancy fees.
    /// <see href="http://purl.org/cerif/frapo/consultancy-costs"></see></summary>
    let ``consultancy-costs`` =
        Namespaced_IRI.parse _namespace_name "consultancy-costs" |> NamespacedName

    /// <summary>
    /// A budget category to cover the costs of purchasing consumables.
    /// <see href="http://purl.org/cerif/frapo/consumables-costs"></see></summary>
    let ``consumables-costs`` =
        Namespaced_IRI.parse _namespace_name "consumables-costs" |> NamespacedName

    /// <summary>
    /// A budget category to categorize the financial worth of contributions in kind (e.g. staff effort, access to facilities, sharing of know-how) given to a project by an agent, for example by the host institution or by a commerical partner in an academic project.
    /// <see href="http://purl.org/cerif/frapo/contributions-in-kind"></see></summary>
    let ``contributions-in-kind`` =
        Namespaced_IRI.parse _namespace_name "contributions-in-kind" |> NamespacedName

    /// <summary>
    /// A budget category to cover those costs normally borne by an institution, that are assigned to the budget of an externally funded project to cover the value of contributions to that project, for example to pay for the salary of a permanent member of staff seconded to work on the project, to compensate the employing organization for the loss of that person's efforts on other activities that he or she would otherwise be undertaking were it not for that secondment.
    /// <see href="http://purl.org/cerif/frapo/directly-allocated-costs"></see></summary>
    let ``directly-allocated-costs`` =
        Namespaced_IRI.parse _namespace_name "directly-allocated-costs" |> NamespacedName

    /// <summary>
    /// A budget category to cover all costs directly incurred because of a legitimate expenditure on a project, for example the purchase of reagents or the employment of a post-doctoral researcher.
    /// <see href="http://purl.org/cerif/frapo/directly-incurred-costs"></see></summary>
    let ``directly-incurred-costs`` =
        Namespaced_IRI.parse _namespace_name "directly-incurred-costs" |> NamespacedName

    /// <summary>
    /// An object property linking a benefactor to a gift.
    /// <see href="http://purl.org/cerif/frapo/donates"></see></summary>
    let donates = Namespaced_IRI.parse _namespace_name "donates" |> NamespacedName
    /// <summary>
    /// An object property relating an employing agent to an employed agent, for example a person or an organization, who is typically employed to undertaking specified work in exchange for payment.
    /// <see href="http://purl.org/cerif/frapo/employs"></see></summary>
    let employs = Namespaced_IRI.parse _namespace_name "employs" |> NamespacedName
    /// <summary>
    /// An object property relating an entity to another entity that it enables, e.g. linking a project to an endeavour that the project enables.
    /// <see href="http://purl.org/cerif/frapo/enables"></see></summary>
    let enables = Namespaced_IRI.parse _namespace_name "enables" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cerif/frapo/entrepreneur"></see>
    /// </summary>
    let entrepreneur =
        Namespaced_IRI.parse _namespace_name "entrepreneur" |> NamespacedName

    /// <summary>
    /// A budget category to cover the 'overhead' costs of maintaining the premises in which work is undertaken.
    /// <see href="http://purl.org/cerif/frapo/estates-costs"></see></summary>
    let ``estates-costs`` =
        Namespaced_IRI.parse _namespace_name "estates-costs" |> NamespacedName

    /// <summary>
    /// An object property linking an agent to an entity which that agent evaluates, for example a funding agency that is evaluating a grant application to determine whether the proposed project is worthy of funding, or a publisher evaluating a manuscript to determine whether it is suitable for publication.
    /// <see href="http://purl.org/cerif/frapo/evaluates"></see></summary>
    let evaluates = Namespaced_IRI.parse _namespace_name "evaluates" |> NamespacedName

    /// <summary>
    /// A budget category to cover the costs of maintaining facilities used by a project, for example an electron microscopy facility.
    /// <see href="http://purl.org/cerif/frapo/facilities-costs"></see></summary>
    let ``facilities-costs`` =
        Namespaced_IRI.parse _namespace_name "facilities-costs" |> NamespacedName

    /// <summary>
    /// A data property permitting specification of the initial(s) of a person's family name.
    /// <see href="http://purl.org/cerif/frapo/familyNameInitial"></see></summary>
    let familyNameInitial =
        Namespaced_IRI.parse _namespace_name "familyNameInitial" |> NamespacedName

    /// <summary>
    /// A data property permitting specification of the initial(s) of a person's name.
    /// <see href="http://purl.org/cerif/frapo/initial"></see></summary>
    let initial = Namespaced_IRI.parse _namespace_name "initial" |> NamespacedName
    /// <summary>
    /// A data property defining whether participation in an event is free, or requires payment of a fee.
    /// <see href="http://purl.org/cerif/frapo/feeOrFree"></see></summary>
    let feeOrFree = Namespaced_IRI.parse _namespace_name "feeOrFree" |> NamespacedName

    /// <summary>
    /// A budget category to cover all the direct and indirect costs of a project.
    /// <see href="http://purl.org/cerif/frapo/full-economic-costs"></see></summary>
    let ``full-economic-costs`` =
        Namespaced_IRI.parse _namespace_name "full-economic-costs" |> NamespacedName

    /// <summary>
    /// The status of something such as an investigation or a project as being funded.
    /// <see href="http://purl.org/cerif/frapo/funded"></see></summary>
    let funded = Namespaced_IRI.parse _namespace_name "funded" |> NamespacedName
    /// <summary>
    /// An object property that links a grant to something that it funds (i.e. that it finances or pays for), or that links an agent providing funding to something that it funds.  This flexibility is given because of alternative usages of the English word 'funds'.  [See also frapo:awards and frapo:supports.]
    /// <see href="http://purl.org/cerif/frapo/funds"></see></summary>
    let funds = Namespaced_IRI.parse _namespace_name "funds" |> NamespacedName
    /// <summary>
    /// An object property linking an agent to something that the agent supports by financial or other means.
    /// <see href="http://purl.org/cerif/frapo/supports"></see></summary>
    let supports = Namespaced_IRI.parse _namespace_name "supports" |> NamespacedName
    /// <summary>
    /// An object property linking something to the funding that funds it (i.e. that finances or pays for it), or to the funding agency providing that funding.  This flexibility is given because of alternative usages of the English word 'funds'.  [See also frapo:isAwardedBy and frapo:hasFundingAgency and frapo:isSupportedBy.]
    /// <see href="http://purl.org/cerif/frapo/isFundedBy"></see></summary>
    let isFundedBy = Namespaced_IRI.parse _namespace_name "isFundedBy" |> NamespacedName

    /// <summary>
    /// A data property permitting specification of the initial(s) of a person's given name(s).
    /// <see href="http://purl.org/cerif/frapo/givenNameInitial"></see></summary>
    let givenNameInitial =
        Namespaced_IRI.parse _namespace_name "givenNameInitial" |> NamespacedName

    /// <summary>
    /// A data property linking a financial account to an identifying number for that account.
    /// <see href="http://purl.org/cerif/frapo/hasAccountNumber"></see></summary>
    let hasAccountNumber =
        Namespaced_IRI.parse _namespace_name "hasAccountNumber" |> NamespacedName

    /// <summary>
    /// A data property linking an entity to an acronym used to identify it, based on its full name or title.  For example, this ontology has the full name 'Funding, Research Administration and Projects Ontology' and the acronym 'FRAPO'.
    /// <see href="http://purl.org/cerif/frapo/hasAcronym"></see></summary>
    let hasAcronym = Namespaced_IRI.parse _namespace_name "hasAcronym" |> NamespacedName

    /// <summary>
    /// A data property linking an agent to information about that agent.
    /// <see href="http://purl.org/cerif/frapo/hasAgentInformation"></see></summary>
    let hasAgentInformation =
        Namespaced_IRI.parse _namespace_name "hasAgentInformation" |> NamespacedName

    /// <summary>
    /// The date by which an application, for example a job application, a fellowship application or a grant application, has to be submitted if it is to be considered for acceptance or funding.
    /// <see href="http://purl.org/cerif/frapo/hasApplicationDeadline"></see></summary>
    let hasApplicationDeadline =
        Namespaced_IRI.parse _namespace_name "hasApplicationDeadline" |> NamespacedName

    /// <summary>
    /// A data property that permits the outcome of an application to be described, for example that a job has been offered or that a grant has been awarded.
    /// <see href="http://purl.org/cerif/frapo/hasApplicationOutcome"></see></summary>
    let hasApplicationOutcome =
        Namespaced_IRI.parse _namespace_name "hasApplicationOutcome" |> NamespacedName

    /// <summary>
    /// The date on which notification is given or received that something, for example a scholarship or a grant, has been awarded.  [See also frapo:hasDecisionDate.]
    /// <see href="http://purl.org/cerif/frapo/hasAwardDate"></see></summary>
    let hasAwardDate =
        Namespaced_IRI.parse _namespace_name "hasAwardDate" |> NamespacedName

    /// <summary>
    /// A data property linking something, for example a chemical or drug, to its manufacturing batch number.
    /// <see href="http://purl.org/cerif/frapo/hasBatchNumber"></see></summary>
    let hasBatchNumber =
        Namespaced_IRI.parse _namespace_name "hasBatchNumber" |> NamespacedName

    /// <summary>
    /// A data property permitting specification of the birth date of a person.
    /// <see href="http://purl.org/cerif/frapo/hasBirthDate"></see></summary>
    let hasBirthDate =
        Namespaced_IRI.parse _namespace_name "hasBirthDate" |> NamespacedName

    /// <summary>
    /// A data property specifying the identifying number of a call for applications issued by a funding agency.
    /// <see href="http://purl.org/cerif/frapo/hasCallIdentifier"></see></summary>
    let hasCallIdentifier =
        Namespaced_IRI.parse _namespace_name "hasCallIdentifier" |> NamespacedName

    /// <summary>
    /// A data property linking something to its catalog number.
    /// <see href="http://purl.org/cerif/frapo/hasCatalogNumber"></see></summary>
    let hasCatalogNumber =
        Namespaced_IRI.parse _namespace_name "hasCatalogNumber" |> NamespacedName

    /// <summary>
    /// A data property specifying a city or town, for example as the location of an event.
    /// <see href="http://purl.org/cerif/frapo/hasCityOrTown"></see></summary>
    let hasCityOrTown =
        Namespaced_IRI.parse _namespace_name "hasCityOrTown" |> NamespacedName

    /// <summary>
    /// A data property defining a code.
    /// <see href="http://purl.org/cerif/frapo/hasCode"></see></summary>
    let hasCode = Namespaced_IRI.parse _namespace_name "hasCode" |> NamespacedName

    /// <summary>
    /// A data property linking something such as a building or a contract to its date of completion.
    /// <see href="http://purl.org/cerif/frapo/hasCompletionDate"></see></summary>
    let hasCompletionDate =
        Namespaced_IRI.parse _namespace_name "hasCompletionDate" |> NamespacedName

    /// <summary>
    /// A data property enabling the cost of something that can be paid for to be defined.
    /// <see href="http://purl.org/cerif/frapo/hasCost"></see></summary>
    let hasCost = Namespaced_IRI.parse _namespace_name "hasCost" |> NamespacedName
    /// <summary>
    /// A data property specifying a country, for example as the location of an event.
    /// <see href="http://purl.org/cerif/frapo/hasCountry"></see></summary>
    let hasCountry = Namespaced_IRI.parse _namespace_name "hasCountry" |> NamespacedName

    /// <summary>
    /// A data property specifying the two-letter or three-letter upper-case country code used to identify a country (e.g. FR/FRA for France, DE/DEU for Germany) (see http://countrycode.org/).
    /// <see href="http://purl.org/cerif/frapo/hasCountryCode"></see></summary>
    let hasCountryCode =
        Namespaced_IRI.parse _namespace_name "hasCountryCode" |> NamespacedName

    /// <summary>
    /// A data property defining the currency used to specify a financial entity.  Use in conjection with frapo:hasMonetaryValue.
    /// <see href="http://purl.org/cerif/frapo/hasCurrency"></see></summary>
    let hasCurrency =
        Namespaced_IRI.parse _namespace_name "hasCurrency" |> NamespacedName

    /// <summary>
    /// A data property specifying the three-letter currency code used to identify a currency, as defined by ISO 4217 (e.g. EUR or GBP) (see http://en.wikipedia.org/wiki/ISO_4217).
    ///
    /// Not to be confused with the symbol used with numbers to denote an amount of money in a particular currency (e.g.€500; £3.40)
    /// <see href="http://purl.org/cerif/frapo/hasCurrencyCode"></see></summary>
    let hasCurrencyCode =
        Namespaced_IRI.parse _namespace_name "hasCurrencyCode" |> NamespacedName

    /// <summary>
    /// An object property linking a person to an on-line version of that person's curriculum vitae.
    /// <see href="http://purl.org/cerif/frapo/hasCurriculumVitae"></see></summary>
    let hasCurriculumVitae =
        Namespaced_IRI.parse _namespace_name "hasCurriculumVitae" |> NamespacedName

    /// <summary>
    /// A data property linking an agent to an identifying number for that agent, typically used by the accounting system of the supplier when issuing quotations, fulfilling orders and submitting invoices.
    /// <see href="http://purl.org/cerif/frapo/hasCustomerNumber"></see></summary>
    let hasCustomerNumber =
        Namespaced_IRI.parse _namespace_name "hasCustomerNumber" |> NamespacedName

    /// <summary>
    /// The date on which a particular action is or will be decided upon, or when an application, such as a grant application, is or will be approved or rejected. [See also frapo:hasAwardDate.]
    /// <see href="http://purl.org/cerif/frapo/hasDecisionDate"></see></summary>
    let hasDecisionDate =
        Namespaced_IRI.parse _namespace_name "hasDecisionDate" |> NamespacedName

    /// <summary>
    /// The letters that should be displayed after a person's name to indicate an academic degree, e.g. BA, BVSc, PhD, DSc.
    /// <see href="http://purl.org/cerif/frapo/hasDegreeSuffix"></see></summary>
    let hasDegreeSuffix =
        Namespaced_IRI.parse _namespace_name "hasDegreeSuffix" |> NamespacedName

    /// <summary>
    /// The letters that should be displayed after a person's name.
    /// <see href="http://purl.org/cerif/frapo/hasNameSuffix"></see></summary>
    let hasNameSuffix =
        Namespaced_IRI.parse _namespace_name "hasNameSuffix" |> NamespacedName

    /// <summary>
    /// A data property that permits one to define a deliverable of a project.
    /// <see href="http://purl.org/cerif/frapo/hasDeliverable"></see></summary>
    let hasDeliverable =
        Namespaced_IRI.parse _namespace_name "hasDeliverable" |> NamespacedName

    /// <summary>
    /// The date on which something is delivered, or is due to be delivered.
    /// <see href="http://purl.org/cerif/frapo/hasDeliveryDate"></see></summary>
    let hasDeliveryDate =
        Namespaced_IRI.parse _namespace_name "hasDeliveryDate" |> NamespacedName

    /// <summary>
    /// The date on which something, for example an item of equipment, is dispatched by the supplier.
    /// <see href="http://purl.org/cerif/frapo/hasDispatchDate"></see></summary>
    let hasDispatchDate =
        Namespaced_IRI.parse _namespace_name "hasDispatchDate" |> NamespacedName

    /// <summary>
    /// A data property linking an entity to an internet domain name that has been registered for that entity, for example http://www.miidi.org for MIIDI, the Minimal Information standard for reporting an Infectious Disease Investigation.
    /// <see href="http://purl.org/cerif/frapo/hasDomainName"></see></summary>
    let hasDomainName =
        Namespaced_IRI.parse _namespace_name "hasDomainName" |> NamespacedName

    /// <summary>
    /// A data property linking something such as a project to its end date.
    /// <see href="http://purl.org/cerif/frapo/hasEndDate"></see></summary>
    let hasEndDate = Namespaced_IRI.parse _namespace_name "hasEndDate" |> NamespacedName

    /// <summary>
    /// A data property specifying the currency exchange rate between two specified currencies.
    /// <see href="http://purl.org/cerif/frapo/hasExchangeRate"></see></summary>
    let hasExchangeRate =
        Namespaced_IRI.parse _namespace_name "hasExchangeRate" |> NamespacedName

    /// <summary>
    /// A data property identifying the area(s) of expertise and skills posessed by an individual or an organization.
    /// <see href="http://purl.org/cerif/frapo/hasExpertise"></see></summary>
    let hasExpertise =
        Namespaced_IRI.parse _namespace_name "hasExpertise" |> NamespacedName

    /// <summary>
    /// A data property linking something, for example a drug, to its expiry date, beyond which the manufacture recommends that it should not be used.
    /// <see href="http://purl.org/cerif/frapo/hasExpiryDate"></see></summary>
    let hasExpiryDate =
        Namespaced_IRI.parse _namespace_name "hasExpiryDate" |> NamespacedName

    /// <summary>
    /// The letters that may be displayed after a person's name to indicate familial status, e.g. Sn., Jn., III, 3rd.
    /// <see href="http://purl.org/cerif/frapo/hasFamilialSuffix"></see></summary>
    let hasFamilialSuffix =
        Namespaced_IRI.parse _namespace_name "hasFamilialSuffix" |> NamespacedName

    /// <summary>
    /// A data property identifying a Fax number for an agent.
    /// <see href="http://purl.org/cerif/frapo/hasFaxNumber"></see></summary>
    let hasFaxNumber =
        Namespaced_IRI.parse _namespace_name "hasFaxNumber" |> NamespacedName

    /// <summary>
    /// A data property linking a funding agency to an identifier for that funding agency.
    /// <see href="http://purl.org/cerif/frapo/hasFunderIdentifier"></see></summary>
    let hasFunderIdentifier =
        Namespaced_IRI.parse _namespace_name "hasFunderIdentifier" |> NamespacedName

    /// <summary>
    /// An object property linking something to a funding agency that provides funding for it.
    /// <see href="http://purl.org/cerif/frapo/hasFundingAgency"></see></summary>
    let hasFundingAgency =
        Namespaced_IRI.parse _namespace_name "hasFundingAgency" |> NamespacedName

    /// <summary>
    /// An object property linking something to an agent that provides funding or other support for it.
    /// <see href="http://purl.org/cerif/frapo/isSupportedBy"></see></summary>
    let isSupportedBy =
        Namespaced_IRI.parse _namespace_name "isSupportedBy" |> NamespacedName

    /// <summary>
    /// A data property specifying the grant number of a grant provided by a funding agency.
    /// <see href="http://purl.org/cerif/frapo/hasGrantNumber"></see></summary>
    let hasGrantNumber =
        Namespaced_IRI.parse _namespace_name "hasGrantNumber" |> NamespacedName

    /// <summary>
    /// A data property specifying the number of people employed by an organization.
    /// <see href="http://purl.org/cerif/frapo/hasHeadcount"></see></summary>
    let hasHeadcount =
        Namespaced_IRI.parse _namespace_name "hasHeadcount" |> NamespacedName

    /// <summary>
    /// It describes information about the organization.
    /// <see href="http://purl.org/cerif/frapo/hasOrganizationalInformation"></see></summary>
    let hasOrganizationalInformation =
        Namespaced_IRI.parse _namespace_name "hasOrganizationalInformation" |> NamespacedName

    /// <summary>
    /// The letters that should be displayed after a person's name to indicate qualification, membership or fellowship in a professional society, honours or elite status, e.g. MRCVS, FRCS, FRS, OBE, Kt.
    /// <see href="http://purl.org/cerif/frapo/hasHonorificSuffix"></see></summary>
    let hasHonorificSuffix =
        Namespaced_IRI.parse _namespace_name "hasHonorificSuffix" |> NamespacedName

    /// <summary>
    /// An object property linking an entity such as a project, an endeavour or an output to an agent who owns the IPR arising from or related to that entity.
    /// <see href="http://purl.org/cerif/frapo/hasIPROwner"></see></summary>
    let hasIPROwner =
        Namespaced_IRI.parse _namespace_name "hasIPROwner" |> NamespacedName

    /// <summary>
    /// An object property linking an entity to the agent that owns it.
    /// <see href="http://purl.org/cerif/frapo/isOwnedBy"></see></summary>
    let isOwnedBy = Namespaced_IRI.parse _namespace_name "isOwnedBy" |> NamespacedName

    /// <summary>
    /// A data property linking an invoice to its date.
    /// <see href="http://purl.org/cerif/frapo/hasInvoiceDate"></see></summary>
    let hasInvoiceDate =
        Namespaced_IRI.parse _namespace_name "hasInvoiceDate" |> NamespacedName

    /// <summary>
    /// A data property permitting specification of the job title held by a person, such as might appear next to the name in a directory or on a conference name badge.  For example, the person's specific Job Title might be 'Linacre Professor of Zoology' or 'Regius Professor of Moral Philosophy'.
    ///
    /// This job title properly refers to the **role** held by that person (e.g. 'Head of Department'), which can be separately defined using SCoRO, the Scholarly Contributions and Roles Ontology (http://purl.org/spar/scoro/). [see scoro:withJobTitle].
    ///
    ///
    /// <see href="http://purl.org/cerif/frapo/hasJobTitle"></see></summary>
    let hasJobTitle =
        Namespaced_IRI.parse _namespace_name "hasJobTitle" |> NamespacedName

    /// <summary>
    /// A data property linking a person to information about that person.
    /// <see href="http://purl.org/cerif/frapo/hasPersonalInformation"></see></summary>
    let hasPersonalInformation =
        Namespaced_IRI.parse _namespace_name "hasPersonalInformation" |> NamespacedName

    /// <summary>
    /// A data property permitting specification of a keyword relating to an entity.
    /// <see href="http://purl.org/cerif/frapo/hasKeyword"></see></summary>
    let hasKeyword = Namespaced_IRI.parse _namespace_name "hasKeyword" |> NamespacedName

    /// <summary>
    /// A data property specifying the two-letter or three-letter lower-case code used to identify a language (e.g. fr/fra for French, de/deu for Germany) (see http://en.wikipedia.org/wiki/List_of_ISO_639-1_codes).
    /// <see href="http://purl.org/cerif/frapo/hasLanguageCode"></see></summary>
    let hasLanguageCode =
        Namespaced_IRI.parse _namespace_name "hasLanguageCode" |> NamespacedName

    /// <summary>
    /// A data property link an entity to a relevant location, which might be geographical (e.g. New York City) or local (e.g. Freezer B, second shelf).
    /// <see href="http://purl.org/cerif/frapo/hasLocation"></see></summary>
    let hasLocation =
        Namespaced_IRI.parse _namespace_name "hasLocation" |> NamespacedName

    /// <summary>
    /// A data property linking something to its date of manufacture.
    /// <see href="http://purl.org/cerif/frapo/hasManufactureDate"></see></summary>
    let hasManufactureDate =
        Namespaced_IRI.parse _namespace_name "hasManufactureDate" |> NamespacedName

    /// <summary>
    /// A data property that permits one to define a significant event (a 'milestone') in the progress of a project.
    /// <see href="http://purl.org/cerif/frapo/hasMilestone"></see></summary>
    let hasMilestone =
        Namespaced_IRI.parse _namespace_name "hasMilestone" |> NamespacedName

    /// <summary>
    /// A data property linking something, for example a piece of equipment, to its model number.
    /// <see href="http://purl.org/cerif/frapo/hasModelNumber"></see></summary>
    let hasModelNumber =
        Namespaced_IRI.parse _namespace_name "hasModelNumber" |> NamespacedName

    /// <summary>
    /// A data property enabling one to specify the monetary value of a financial entity such as a grant, a gift or a budget category.  Use in conjuction with frapo:hasCurrency.
    /// <see href="http://purl.org/cerif/frapo/hasMonetaryValue"></see></summary>
    let hasMonetaryValue =
        Namespaced_IRI.parse _namespace_name "hasMonetaryValue" |> NamespacedName

    /// <summary>
    /// A data property relating an individual to his/her Open Researcher and Contributor ID (ORCID), an alphanumeric identifier for individual scholars described at http://about.orcid.org/.
    /// <see href="http://purl.org/cerif/frapo/hasORCID"></see></summary>
    let hasORCID = Namespaced_IRI.parse _namespace_name "hasORCID" |> NamespacedName

    /// <summary>
    /// A unique and unambiguous identifier for an individual person within a given context.
    /// <see href="http://purl.org/cerif/frapo/hasPersonalIdentifier"></see></summary>
    let hasPersonalIdentifier =
        Namespaced_IRI.parse _namespace_name "hasPersonalIdentifier" |> NamespacedName

    /// <summary>
    /// An object property linking an activity such as a project or endeavour to something that is created or produced as a result of that activity.  Examples include a building created as a result of a building project, and a journal article published to describe the results of a research investigation.
    /// <see href="http://purl.org/cerif/frapo/hasOutput"></see></summary>
    let hasOutput = Namespaced_IRI.parse _namespace_name "hasOutput" |> NamespacedName

    /// <summary>
    /// A data property identifying a telephone number for an agent.
    /// <see href="http://purl.org/cerif/frapo/hasPhoneNumber"></see></summary>
    let hasPhoneNumber =
        Namespaced_IRI.parse _namespace_name "hasPhoneNumber" |> NamespacedName

    /// <summary>
    /// A data property defining the postal code of an address.
    /// <see href="http://purl.org/cerif/frapo/hasPostCode"></see></summary>
    let hasPostCode =
        Namespaced_IRI.parse _namespace_name "hasPostCode" |> NamespacedName

    /// <summary>
    /// A data property identifying a postal address for an agent.
    /// <see href="http://purl.org/cerif/frapo/hasPostalAddress"></see></summary>
    let hasPostalAddress =
        Namespaced_IRI.parse _namespace_name "hasPostalAddress" |> NamespacedName

    /// <summary>
    /// A data property permitting specification of a single line of a postal address.
    /// <see href="http://purl.org/cerif/frapo/hasPostalAddressLine"></see></summary>
    let hasPostalAddressLine =
        Namespaced_IRI.parse _namespace_name "hasPostalAddressLine" |> NamespacedName

    /// <summary>
    /// An alternative name that a person uses for professional purposes, for example the pen name of an author, or a married woman's maiden name used as her professional name.
    /// <see href="http://purl.org/cerif/frapo/hasProfessionalName"></see></summary>
    let hasProfessionalName =
        Namespaced_IRI.parse _namespace_name "hasProfessionalName" |> NamespacedName

    /// <summary>
    /// A data property linking a project to an identifier for that project.
    /// <see href="http://purl.org/cerif/frapo/hasProjectIdentifier"></see></summary>
    let hasProjectIdentifier =
        Namespaced_IRI.parse _namespace_name "hasProjectIdentifier" |> NamespacedName

    /// <summary>
    /// A data property that permits the provenance of an entity to be described.
    /// <see href="http://purl.org/cerif/frapo/hasProvenance"></see></summary>
    let hasProvenance =
        Namespaced_IRI.parse _namespace_name "hasProvenance" |> NamespacedName

    /// <summary>
    /// A data property linking something to its purchase date.
    /// <see href="http://purl.org/cerif/frapo/hasPurchaseDate"></see></summary>
    let hasPurchaseDate =
        Namespaced_IRI.parse _namespace_name "hasPurchaseDate" |> NamespacedName

    /// <summary>
    /// A data property identifying an official purchase order issued by a purchasing agent to a supplier of goods or services, and used by the supplier to identify the order when delivering goods or submitting an invoice.
    /// <see href="http://purl.org/cerif/frapo/hasPurchaseOrderNumber"></see></summary>
    let hasPurchaseOrderNumber =
        Namespaced_IRI.parse _namespace_name "hasPurchaseOrderNumber" |> NamespacedName

    /// <summary>
    /// A data property permitting specification of the qualification held by a person.
    /// <see href="http://purl.org/cerif/frapo/hasQualification"></see></summary>
    let hasQualification =
        Namespaced_IRI.parse _namespace_name "hasQualification" |> NamespacedName

    /// <summary>
    /// A data property linking a quotation to its date.
    /// <see href="http://purl.org/cerif/frapo/hasQuotationDate"></see></summary>
    let hasQuotationDate =
        Namespaced_IRI.parse _namespace_name "hasQuotationDate" |> NamespacedName

    /// <summary>
    /// A data property linking something to a reference number for that item.
    /// <see href="http://purl.org/cerif/frapo/hasReferenceNumber"></see></summary>
    let hasReferenceNumber =
        Namespaced_IRI.parse _namespace_name "hasReferenceNumber" |> NamespacedName

    /// <summary>
    /// The date by which registration must be made, for example renewal of an internet domain name.
    /// <see href="http://purl.org/cerif/frapo/hasRegistrationDeadline"></see></summary>
    let hasRegistrationDeadline =
        Namespaced_IRI.parse _namespace_name "hasRegistrationDeadline" |> NamespacedName

    /// <summary>
    /// A data property linking something, for example a piece of equipment, to its serial number.
    /// <see href="http://purl.org/cerif/frapo/hasSerialNumber"></see></summary>
    let hasSerialNumber =
        Namespaced_IRI.parse _namespace_name "hasSerialNumber" |> NamespacedName

    /// <summary>
    /// A data property linking something such as a project to its start date.
    /// <see href="http://purl.org/cerif/frapo/hasStartDate"></see></summary>
    let hasStartDate =
        Namespaced_IRI.parse _namespace_name "hasStartDate" |> NamespacedName

    /// <summary>
    /// A data property linking a supplier to an identifying number for that supplier, typically used by the accounting system of the purchasing institution when placing and tracking orders.
    /// <see href="http://purl.org/cerif/frapo/hasSupplierNumber"></see></summary>
    let hasSupplierNumber =
        Namespaced_IRI.parse _namespace_name "hasSupplierNumber" |> NamespacedName

    /// <summary>
    /// A data property enabling one to define the temporal duration of some entity such as an event or a project.
    /// <see href="http://purl.org/cerif/frapo/hasTemporalDuration"></see></summary>
    let hasTemporalDuration =
        Namespaced_IRI.parse _namespace_name "hasTemporalDuration" |> NamespacedName

    /// <summary>
    /// A budget category to cover the indirect costs of running a project, for example heating and lighting, and the employment of non-project staff including administrators, accountants and cleaners.
    /// <see href="http://purl.org/cerif/frapo/indirect-costs"></see></summary>
    let ``indirect-costs`` =
        Namespaced_IRI.parse _namespace_name "indirect-costs" |> NamespacedName

    /// <summary>
    /// An object property linking something applied for to the agent making the application.
    /// <see href="http://purl.org/cerif/frapo/isAppliedForBy"></see></summary>
    let isAppliedForBy =
        Namespaced_IRI.parse _namespace_name "isAppliedForBy" |> NamespacedName

    /// <summary>
    /// An object property linking something awarded to the agent making the award, for example linking a grant to a funding agency, a degree to a university, or a prize to the awarding organization.
    /// <see href="http://purl.org/cerif/frapo/isAwardedBy"></see></summary>
    let isAwardedBy =
        Namespaced_IRI.parse _namespace_name "isAwardedBy" |> NamespacedName

    /// <summary>
    /// An object property linking a gift to the benefactor who provided it.
    /// <see href="http://purl.org/cerif/frapo/isDonatedBy"></see></summary>
    let isDonatedBy =
        Namespaced_IRI.parse _namespace_name "isDonatedBy" |> NamespacedName

    /// <summary>
    /// An object property relating an employed agent, typically a person or an organization, to an employing agent.
    /// <see href="http://purl.org/cerif/frapo/isEmployedBy"></see></summary>
    let isEmployedBy =
        Namespaced_IRI.parse _namespace_name "isEmployedBy" |> NamespacedName

    /// <summary>
    /// An object property relating an entity to another entity that enables it, e.g. linking an investigation to a project that enables it.
    /// <see href="http://purl.org/cerif/frapo/isEnabledBy"></see></summary>
    let isEnabledBy =
        Namespaced_IRI.parse _namespace_name "isEnabledBy" |> NamespacedName

    /// <summary>
    /// An object property linking an entity to an agent that evaluates it.
    /// <see href="http://purl.org/cerif/frapo/isEvaluatedBy"></see></summary>
    let isEvaluatedBy =
        Namespaced_IRI.parse _namespace_name "isEvaluatedBy" |> NamespacedName

    /// <summary>
    /// An object property linking a funding agency to an entity for which it provides funding.
    /// <see href="http://purl.org/cerif/frapo/isFundingAgencyFor"></see></summary>
    let isFundingAgencyFor =
        Namespaced_IRI.parse _namespace_name "isFundingAgencyFor" |> NamespacedName

    /// <summary>
    /// An object property relating a manufactured entity to its manufacturer.
    /// <see href="http://purl.org/cerif/frapo/isManufacturedBy"></see></summary>
    let isManufacturedBy =
        Namespaced_IRI.parse _namespace_name "isManufacturedBy" |> NamespacedName

    /// <summary>
    /// An object property relating a manufacturer to a manufactured entity.
    /// <see href="http://purl.org/cerif/frapo/manufactures"></see></summary>
    let manufactures =
        Namespaced_IRI.parse _namespace_name "manufactures" |> NamespacedName

    /// <summary>
    /// An object property linking something that is created or produced to the activity that created or produced it.
    /// <see href="http://purl.org/cerif/frapo/isOutputOf"></see></summary>
    let isOutputOf = Namespaced_IRI.parse _namespace_name "isOutputOf" |> NamespacedName
    /// <summary>
    /// An object property linking an agent to an entity owned by that agent.
    /// <see href="http://purl.org/cerif/frapo/owns"></see></summary>
    let owns = Namespaced_IRI.parse _namespace_name "owns" |> NamespacedName

    /// <summary>
    /// An object property relating a purchased entity to its purchaser.
    /// <see href="http://purl.org/cerif/frapo/isPurchasedBy"></see></summary>
    let isPurchasedBy =
        Namespaced_IRI.parse _namespace_name "isPurchasedBy" |> NamespacedName

    /// <summary>
    /// An object property linking an entity that is submitted (to some third party) to the agent who submits it.
    /// <see href="http://purl.org/cerif/frapo/isSubmittedBy"></see></summary>
    let isSubmittedBy =
        Namespaced_IRI.parse _namespace_name "isSubmittedBy" |> NamespacedName

    /// <summary>
    /// An object property linking an agent to an entity that is submitted to some third party, for example a grant application submitted to a funding agency, a manuscript submitted to a publisher, a quotation submitted by a vendor, or a dataset submitted by a researcher to a data repository.
    /// <see href="http://purl.org/cerif/frapo/submits"></see></summary>
    let submits = Namespaced_IRI.parse _namespace_name "submits" |> NamespacedName

    /// <summary>
    /// An object property relating an entity that is supplied, or an agent to whom an entity is supplied, to the supplier.
    /// <see href="http://purl.org/cerif/frapo/isSuppliedBy"></see></summary>
    let isSuppliedBy =
        Namespaced_IRI.parse _namespace_name "isSuppliedBy" |> NamespacedName

    /// <summary>
    /// An object property relating a supplier to a supplied entity, or to an agent to whom the entity is supplied.
    /// <see href="http://purl.org/cerif/frapo/supplies"></see></summary>
    let supplies = Namespaced_IRI.parse _namespace_name "supplies" |> NamespacedName

    /// <summary>
    /// A budget category to cover all the costs associated with a project that do not involve the employment of staff by the institution, thus, for example, including consumables purchase, travel costs and consultancy fees, but excluding the salary, estates and indirect costs associated with the allocation of the PI's time to the project and the direct employment of a project manager.
    /// <see href="http://purl.org/cerif/frapo/non-staff-costs"></see></summary>
    let ``non-staff-costs`` =
        Namespaced_IRI.parse _namespace_name "non-staff-costs" |> NamespacedName

    /// <summary>
    /// A budget category to cover costs not covered in other budget categories.
    /// <see href="http://purl.org/cerif/frapo/other-costs"></see></summary>
    let ``other-costs`` =
        Namespaced_IRI.parse _namespace_name "other-costs" |> NamespacedName

    /// <summary>
    /// A budget category to cover all the non-directly incurred costs of a project, including estates costs and indirect costs, that enable an institution to host an externally-funded project.
    /// <see href="http://purl.org/cerif/frapo/overhead-costs"></see></summary>
    let ``overhead-costs`` =
        Namespaced_IRI.parse _namespace_name "overhead-costs" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/cerif/frapo/owl:sameAs"></see>
    /// </summary>
    let ``owl:sameAs`` =
        Namespaced_IRI.parse _namespace_name "owl:sameAs" |> NamespacedName

    /// <summary>
    /// An object property linking an agent who owns IPR arising from or relating to an entity to that entity.
    /// <see href="http://purl.org/cerif/frapo/ownsIRPOf"></see></summary>
    let ownsIRPOf = Namespaced_IRI.parse _namespace_name "ownsIRPOf" |> NamespacedName

    /// <summary>
    /// An object property linking funding to a budget, specifying what fraction of the total budget is provided by that source of funding.
    /// <see href="http://purl.org/cerif/frapo/providesFractionOfTotalFunding"></see></summary>
    let providesFractionOfTotalFunding =
        Namespaced_IRI.parse _namespace_name "providesFractionOfTotalFunding" |> NamespacedName

    /// <summary>
    /// An agent that provides a service.
    /// <see href="http://purl.org/cerif/frapo/providesService"></see></summary>
    let providesService =
        Namespaced_IRI.parse _namespace_name "providesService" |> NamespacedName

    /// <summary>
    /// A budget category to cover the cost of publishing outpots from a project, for example author fees for journal articles in an open access journal.
    /// <see href="http://purl.org/cerif/frapo/publishing-costs"></see></summary>
    let ``publishing-costs`` =
        Namespaced_IRI.parse _namespace_name "publishing-costs" |> NamespacedName

    /// <summary>
    /// An object property relating a purchaser to a purchased entity.
    /// <see href="http://purl.org/cerif/frapo/purchases"></see></summary>
    let purchases = Namespaced_IRI.parse _namespace_name "purchases" |> NamespacedName

    /// <summary>
    /// An object property relating a purchaser to a supplier from whom the purchase is made.
    /// <see href="http://purl.org/cerif/frapo/purchasesFrom"></see></summary>
    let purchasesFrom =
        Namespaced_IRI.parse _namespace_name "purchasesFrom" |> NamespacedName

    /// <summary>
    /// The status of something such as an application as having been rejected.
    /// <see href="http://purl.org/cerif/frapo/rejected"></see></summary>
    let rejected = Namespaced_IRI.parse _namespace_name "rejected" |> NamespacedName
    /// <summary>
    /// An object property relating a supplier to a purchaser to whom an entity is sold.
    /// <see href="http://purl.org/cerif/frapo/sellsTo"></see></summary>
    let sellsTo = Namespaced_IRI.parse _namespace_name "sellsTo" |> NamespacedName

    /// <summary>
    /// A budget category to cover the costs of services used by a project, for example a DNA sequencing service, or an equipment maintenance service.
    /// <see href="http://purl.org/cerif/frapo/service-costs"></see></summary>
    let ``service-costs`` =
        Namespaced_IRI.parse _namespace_name "service-costs" |> NamespacedName

    /// <summary>
    /// A budget category to cover the costs of software licenses required by a project.
    /// <see href="http://purl.org/cerif/frapo/software-costs"></see></summary>
    let ``software-costs`` =
        Namespaced_IRI.parse _namespace_name "software-costs" |> NamespacedName

    /// <summary>
    /// An object property relating an agent or a budget to the expenditure specified by that agent or budget.
    /// <see href="http://purl.org/cerif/frapo/specifiesExpediture"></see></summary>
    let specifiesExpediture =
        Namespaced_IRI.parse _namespace_name "specifiesExpediture" |> NamespacedName

    /// <summary>
    /// A budget category to cover the costs of travel and subsistence incurred on behalf of the project.
    /// <see href="http://purl.org/cerif/frapo/travel-and-subsistence-costs"></see></summary>
    let ``travel-and-subsistence-costs`` =
        Namespaced_IRI.parse _namespace_name "travel-and-subsistence-costs" |> NamespacedName

    /// <summary>
    /// The status of something such as an investigation or a project as being unfunded.
    /// <see href="http://purl.org/cerif/frapo/unfunded"></see></summary>
    let unfunded = Namespaced_IRI.parse _namespace_name "unfunded" |> NamespacedName

    /// <summary>
    /// An object property linking an activity such as an expedition, a research project or an investigation, to an item of equipment employed in that activity.
    /// <see href="http://purl.org/cerif/frapo/usesEquipment"></see></summary>
    let usesEquipment =
        Namespaced_IRI.parse _namespace_name "usesEquipment" |> NamespacedName

    /// <summary>
    /// An object property linking an activity such as an expedition, a research project or an investigation, to a facility employed in that activity.
    /// <see href="http://purl.org/cerif/frapo/usesFacility"></see></summary>
    let usesFacility =
        Namespaced_IRI.parse _namespace_name "usesFacility" |> NamespacedName

    /// <summary>
    /// An object property linking an activity such as an expedition, a research project or an investigation, to a service employed in that activity.
    /// <see href="http://purl.org/cerif/frapo/usesService"></see></summary>
    let usesService =
        Namespaced_IRI.parse _namespace_name "usesService" |> NamespacedName
