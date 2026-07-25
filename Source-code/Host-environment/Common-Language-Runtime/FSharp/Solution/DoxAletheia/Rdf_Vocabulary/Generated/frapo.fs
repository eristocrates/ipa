namespace http.purl.org.cerif.frapo.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module frapo =
    let _namespace_iri = Namespace_Iri frapo |> NamespaceIRI
    /// <summary>
    ///   <para>frapo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>FRAPO, the Funding, Research Administration and Projects Ontology, is a CERIF-compliant ontology  written in OWL 2 DL for describing research project administrative information.  This ontology is available at http://purl.org/cerif/frapo/, and uses the namespace prefix 'frapo'.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cerif/frapo/">http://purl.org/cerif/frapo/</seealso>
    let _prefix_iri = Prefixed_Name(frapo, "") |> PrefixedName
    /// <summary>
    ///   <para>frapo:FinancialEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An entity primarily to do with money.</para>
    /// labels<para>financial entity</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/FinancialEntity">http://purl.org/cerif/frapo/FinancialEntity</seealso>
    let FinancialEntity = Prefixed_Name(frapo, "FinancialEntity") |> PrefixedName
    /// <summary>
    ///   <para>frapo:AccountStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A statement of income and expenditure for an account, typically presented as dated income receipts and outgoings against categories in a budget for that account.</para>
    /// labels<para>account statement</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/AccountStatement">http://purl.org/cerif/frapo/AccountStatement</seealso>
    let AccountStatement = Prefixed_Name(frapo, "AccountStatement") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Application</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The activity of making an application, for example for a job, or for funding.</para>
    /// labels<para>application</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Application">http://purl.org/cerif/frapo/Application</seealso>
    let Application = Prefixed_Name(frapo, "Application") |> PrefixedName

    /// <summary>
    ///   <para>frapo:ArticleProcessingCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fee levied by a publisher on an author or an institution to cover the cost of publishing an Open Access journal article.  Also knows as Article Processing Fee, Article Publication Charge, Author Processing Charge or Author Publishing Charge.</para>
    /// labels<para>article processing charge</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/ArticleProcessingCharge">http://purl.org/cerif/frapo/ArticleProcessingCharge</seealso>
    let ArticleProcessingCharge =
        Prefixed_Name(frapo, "ArticleProcessingCharge") |> PrefixedName

    /// <summary>
    ///   <para>frapo:BudgetInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information about an aspect of a budget.</para>
    /// labels<para>budget information</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/BudgetInformation">http://purl.org/cerif/frapo/BudgetInformation</seealso>
    let BudgetInformation = Prefixed_Name(frapo, "BudgetInformation") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Budget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A structured statement of how funds are to be used for expenditure in defined budget categories.  A budget is created, for example, when applying for funding for a project, and is subsequently used to manage the expenditure from the awarded grant for that project.</para>
    /// labels<para>budget</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Budget">http://purl.org/cerif/frapo/Budget</seealso>
    let Budget = Prefixed_Name(frapo, "Budget") |> PrefixedName
    /// <summary>
    ///   <para>frapo:BudgetedAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The amount of money originally available to spend in a particular budget category.</para>
    /// labels<para>budgeted amount</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/BudgetedAmount">http://purl.org/cerif/frapo/BudgetedAmount</seealso>
    let BudgetedAmount = Prefixed_Name(frapo, "BudgetedAmount") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Funding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An amount of money available to finance some project or activity. </para>
    /// labels<para>funding</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Funding">http://purl.org/cerif/frapo/Funding</seealso>
    let Funding = Prefixed_Name(frapo, "Funding") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Business_angel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Business_angel">http://purl.org/cerif/frapo/Business_angel</seealso>
    let Business_angel = Prefixed_Name(frapo, "Business_angel") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Commitments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Money set aside to honour expenditures already made but for which no invoices have yet been received, or expenditures planned for the future, for example for salaries.</para>
    /// labels<para>commitments</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Commitments">http://purl.org/cerif/frapo/Commitments</seealso>
    let Commitments = Prefixed_Name(frapo, "Commitments") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Company</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A commercial company or business run for profit.</para>
    /// labels<para>company</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Company">http://purl.org/cerif/frapo/Company</seealso>
    let Company = Prefixed_Name(frapo, "Company") |> PrefixedName

    /// <summary>
    ///   <para>frapo:ComputationalService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A service provided by a computer system.</para>
    /// labels<para>computational service</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/ComputationalService">http://purl.org/cerif/frapo/ComputationalService</seealso>
    let ComputationalService =
        Prefixed_Name(frapo, "ComputationalService") |> PrefixedName

    /// <summary>
    ///   <para>frapo:DataRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A facility in which digital data are deposited for long-term preservation and (optional) publication.</para>
    /// labels<para>data repository</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/DataRepository">http://purl.org/cerif/frapo/DataRepository</seealso>
    let DataRepository = Prefixed_Name(frapo, "DataRepository") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Repository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A facility in which entities can be deposited for long-term preservation.</para>
    /// labels<para>repository</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Repository">http://purl.org/cerif/frapo/Repository</seealso>
    let Repository = Prefixed_Name(frapo, "Repository") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Deliverable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class defining a 'deliverable' of a project, i.e. something that the project set out to deliver, or succeeds in delivering.</para>
    /// labels<para>deliverable</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Deliverable">http://purl.org/cerif/frapo/Deliverable</seealso>
    let Deliverable = Prefixed_Name(frapo, "Deliverable") |> PrefixedName
    /// <summary>
    ///   <para>frapo:DocumentRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A facility in which digital documents are deposited for long-term preservation and (optional) publication.</para>
    /// labels<para>document repository</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/DocumentRepository">http://purl.org/cerif/frapo/DocumentRepository</seealso>
    let DocumentRepository = Prefixed_Name(frapo, "DocumentRepository") |> PrefixedName

    /// <summary>
    ///   <para>frapo:EmploymentApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The activity of applying for a job.</para>
    /// labels<para>employment application</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/EmploymentApplication">http://purl.org/cerif/frapo/EmploymentApplication</seealso>
    let EmploymentApplication =
        Prefixed_Name(frapo, "EmploymentApplication") |> PrefixedName

    /// <summary>
    ///   <para>frapo:Gift</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A gift, donation, benefaction or legacy, typically of money.</para>
    /// labels<para>gift</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Gift">http://purl.org/cerif/frapo/Gift</seealso>
    let Gift = Prefixed_Name(frapo, "Gift") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An item of equipment or apparatus, or a laboratory instrument, for example a refrigerated centrifuge.</para>
    /// labels<para>equipment</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Equipment">http://purl.org/cerif/frapo/Equipment</seealso>
    let Equipment = Prefixed_Name(frapo, "Equipment") |> PrefixedName

    /// <summary>
    ///   <para>frapo:InfrastructureEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An entity that facilitates work.</para>
    /// labels<para>infrastructure entity</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/InfrastructureEntity">http://purl.org/cerif/frapo/InfrastructureEntity</seealso>
    let InfrastructureEntity =
        Prefixed_Name(frapo, "InfrastructureEntity") |> PrefixedName

    /// <summary>
    ///   <para>frapo:Expenditure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Money going out of an account, because of expenditure on various entities. May be associated with a particular budget category.</para>
    /// labels<para>expenditure</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Expenditure">http://purl.org/cerif/frapo/Expenditure</seealso>
    let Expenditure = Prefixed_Name(frapo, "Expenditure") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Fellowship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The stipend paid to a fellow in a college or university.</para>
    /// labels<para>fellowship</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Fellowship">http://purl.org/cerif/frapo/Fellowship</seealso>
    let Fellowship = Prefixed_Name(frapo, "Fellowship") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Stipend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sum of money allotted on a regular basis, usually for some specific purpose.</para>
    /// labels<para>stipend</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Stipend">http://purl.org/cerif/frapo/Stipend</seealso>
    let Stipend = Prefixed_Name(frapo, "Stipend") |> PrefixedName

    /// <summary>
    ///   <para>frapo:FinancialControlSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A software system controlling the financial activities of an organization, for example determining full economic cost budgets for grant applications, and managing the funding of funded projects.</para>
    /// labels<para>financial control system</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/FinancialControlSystem">http://purl.org/cerif/frapo/FinancialControlSystem</seealso>
    let FinancialControlSystem =
        Prefixed_Name(frapo, "FinancialControlSystem") |> PrefixedName

    /// <summary>
    ///   <para>frapo:FundingAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An organization that provides funding for projects, often in the form of grants awarded on the basis of competitive application.</para>
    /// labels<para>funding agency</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/FundingAgency">http://purl.org/cerif/frapo/FundingAgency</seealso>
    let FundingAgency = Prefixed_Name(frapo, "FundingAgency") |> PrefixedName

    /// <summary>
    ///   <para>frapo:GovernmentOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An organization that is part of, or funded by, central or local goverment.</para>
    /// labels<para>government organization</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/GovernmentOrganization">http://purl.org/cerif/frapo/GovernmentOrganization</seealso>
    let GovernmentOrganization =
        Prefixed_Name(frapo, "GovernmentOrganization") |> PrefixedName

    /// <summary>
    ///   <para>frapo:Grant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A financial award by a funding agency for a particular project or purpose, usually awarded on the basis of a competitive application.</para>
    /// labels<para>grant</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Grant">http://purl.org/cerif/frapo/Grant</seealso>
    let Grant = Prefixed_Name(frapo, "Grant") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Investigation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An investigation is an endeavour that involves research, enabled by a project.
    ///
    /// The investigation relate to the scholarly and practical aspects of conducting the research itself, including the hypotheses being investigated, the experiments being undertaken, the data being gathered and analysed, the interpretations being drawn from the data, and the results obtained.
    ///
    /// In contrast, the project that enables it encompasses the administrative aspects of undertaking the endeavour, including the funding obtained, the people employed, and the management of the project in terms of deadlines and deliverables.</para>
    /// labels<para>investigation</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Investigation">http://purl.org/cerif/frapo/Investigation</seealso>
    let Investigation = Prefixed_Name(frapo, "Investigation") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Investment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An investment of money, generally in stocks and shares, or in property, for the purpose of safeguarding the capital and yielding an income.</para>
    /// labels<para>investment</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Investment">http://purl.org/cerif/frapo/Investment</seealso>
    let Investment = Prefixed_Name(frapo, "Investment") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Library</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A facility in which printed documents (for example books and journals) are deposited for long-term preservation and access.</para>
    /// labels<para>library</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Library">http://purl.org/cerif/frapo/Library</seealso>
    let Library = Prefixed_Name(frapo, "Library") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Manufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An agent who manufactures goods or equipment.</para>
    /// labels<para>manufacturer</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Manufacturer">http://purl.org/cerif/frapo/Manufacturer</seealso>
    let Manufacturer = Prefixed_Name(frapo, "Manufacturer") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The agent who owns an entity.</para>
    /// labels<para>owner</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Owner">http://purl.org/cerif/frapo/Owner</seealso>
    let Owner = Prefixed_Name(frapo, "Owner") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Payment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A financial payment made, for example in exchange for something purchased such as property, goods or services, or to refund expenses incurred.</para>
    /// labels<para>payment</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Payment">http://purl.org/cerif/frapo/Payment</seealso>
    let Payment = Prefixed_Name(frapo, "Payment") |> PrefixedName
    /// <summary>
    ///   <para>frapo:PostalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A postal address.</para>
    /// labels<para>postal address</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/PostalAddress">http://purl.org/cerif/frapo/PostalAddress</seealso>
    let PostalAddress = Prefixed_Name(frapo, "PostalAddress") |> PrefixedName
    /// <summary>
    ///   <para>frapo:RegistrationAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An organization that acts to register things.  For example, CrossRef is a registration agency for DOIs relating to documents, while DataCite is a registration agency for DOIs relating to datasets.</para>
    /// labels<para>registration agency</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/RegistrationAgency">http://purl.org/cerif/frapo/RegistrationAgency</seealso>
    let RegistrationAgency = Prefixed_Name(frapo, "RegistrationAgency") |> PrefixedName

    /// <summary>
    ///   <para>frapo:RegistrationAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An agency with responsibility for registering and maintaining international standards, internet domain names, patents, controlled vocabularies and other similar entities required for reliable international cooperatative activities.</para>
    /// labels<para>registration authority</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/RegistrationAuthority">http://purl.org/cerif/frapo/RegistrationAuthority</seealso>
    let RegistrationAuthority =
        Prefixed_Name(frapo, "RegistrationAuthority") |> PrefixedName

    /// <summary>
    ///   <para>frapo:ResearchGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A group of people, usually within a university department or a research institute, and typically under a single group leader, dedicated to working together to undertake research on one or more topics. May also be called a research unit.</para>
    /// labels<para>research group</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/ResearchGroup">http://purl.org/cerif/frapo/ResearchGroup</seealso>
    let ResearchGroup = Prefixed_Name(frapo, "ResearchGroup") |> PrefixedName

    /// <summary>
    ///   <para>frapo:ResearchInformationSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A database containing administrative information about the research undertaken in an institution, and the publications and other outputs from such research.</para>
    /// labels<para>research information system</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/ResearchInformationSystem">http://purl.org/cerif/frapo/ResearchInformationSystem</seealso>
    let ResearchInformationSystem =
        Prefixed_Name(frapo, "ResearchInformationSystem") |> PrefixedName

    /// <summary>
    ///   <para>frapo:ServiceContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A contract for the provision of a service such as a cleaning service, or for the regular servicing, maintenance and repair of some item of equipment or infrastructure.</para>
    /// labels<para>service contract</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/ServiceContract">http://purl.org/cerif/frapo/ServiceContract</seealso>
    let ServiceContract = Prefixed_Name(frapo, "ServiceContract") |> PrefixedName
    /// <summary>
    ///   <para>frapo:ServiceContractFee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fee paid periodically, typically annually, to obtain access when required to a service such as an equipment maintenance contract."</para>
    /// labels<para>service contract fee</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/ServiceContractFee">http://purl.org/cerif/frapo/ServiceContractFee</seealso>
    let ServiceContractFee = Prefixed_Name(frapo, "ServiceContractFee") |> PrefixedName
    /// <summary>
    ///   <para>frapo:SpinOffCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A company that has been established by a university or research institute to mature and market the results of research conducted at that research institution.</para>
    /// labels<para>spin-off company</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/SpinOffCompany">http://purl.org/cerif/frapo/SpinOffCompany</seealso>
    let SpinOffCompany = Prefixed_Name(frapo, "SpinOffCompany") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The status of something such as an application, an investigation or a project.</para>
    /// labels<para>status</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Status">http://purl.org/cerif/frapo/Status</seealso>
    let Status = Prefixed_Name(frapo, "Status") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Studentship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A financial grant to a student to enable him/her to undertake advanced academic study.</para>
    /// labels<para>studentship</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Studentship">http://purl.org/cerif/frapo/Studentship</seealso>
    let Studentship = Prefixed_Name(frapo, "Studentship") |> PrefixedName
    /// <summary>
    ///   <para>frapo:academic</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A member of the academic staff of an academic institution such as a university.</para>
    /// labels<para>academic</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/academic">http://purl.org/cerif/frapo/academic</seealso>
    let academic = Prefixed_Name(frapo, "academic") |> PrefixedName
    /// <summary>
    ///   <para>frapo:accepted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>frapo:Status</para>
    ///   <para>The status of something such as an application as having been accepted.</para>
    /// labels<para>accepted</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/accepted">http://purl.org/cerif/frapo/accepted</seealso>
    let accepted = Prefixed_Name(frapo, "accepted") |> PrefixedName
    /// <summary>
    ///   <para>frapo:appliesFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking an agent to something for which that agent applies, for example a job, membership of an organization, or a grant from a funding agency.</para>
    /// labels<para>applies for</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/appliesFor">http://purl.org/cerif/frapo/appliesFor</seealso>
    let appliesFor = Prefixed_Name(frapo, "appliesFor") |> PrefixedName
    /// <summary>
    ///   <para>frapo:awards</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>An object property linking an agent to something the agent awards, for example linking a funding agency to a grant, a university to a degree, or an organization to a prize.</para>
    /// labels<para>awards</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/awards">http://purl.org/cerif/frapo/awards</seealso>
    let awards = Prefixed_Name(frapo, "awards") |> PrefixedName
    /// <summary>
    ///   <para>frapo:consumables-costs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>frapo:BudgetCategory</para>
    ///   <para>A budget category to cover the costs of purchasing consumables.</para>
    /// labels<para>consumables costs</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/consumables-costs">http://purl.org/cerif/frapo/consumables-costs</seealso>
    let consumables_costs = Prefixed_Name(frapo, "consumables-costs") |> PrefixedName

    /// <summary>
    ///   <para>frapo:contributions-in-kind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>frapo:BudgetCategory</para>
    ///   <para>A budget category to categorize the financial worth of contributions in kind (e.g. staff effort, access to facilities, sharing of know-how) given to a project by an agent, for example by the host institution or by a commerical partner in an academic project. </para>
    /// labels<para>contributions in kind</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/contributions-in-kind">http://purl.org/cerif/frapo/contributions-in-kind</seealso>
    let contributions_in_kind =
        Prefixed_Name(frapo, "contributions-in-kind") |> PrefixedName

    /// <summary>
    ///   <para>frapo:directly-allocated-costs</para>
    /// </summary>
    /// <remarks>
    ///   <para>frapo:BudgetCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A budget category to cover those costs normally borne by an institution, that are assigned to the budget of an externally funded project to cover the value of contributions to that project, for example to pay for the salary of a permanent member of staff seconded to work on the project, to compensate the employing organization for the loss of that person's efforts on other activities that he or she would otherwise be undertaking were it not for that secondment.</para>
    /// labels<para>directly allocated costs</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/directly-allocated-costs">http://purl.org/cerif/frapo/directly-allocated-costs</seealso>
    let directly_allocated_costs =
        Prefixed_Name(frapo, "directly-allocated-costs") |> PrefixedName

    /// <summary>
    ///   <para>frapo:directly-incurred-costs</para>
    /// </summary>
    /// <remarks>
    ///   <para>frapo:BudgetCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A budget category to cover all costs directly incurred because of a legitimate expenditure on a project, for example the purchase of reagents or the employment of a post-doctoral researcher.</para>
    /// labels<para>directly incurred costs</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/directly-incurred-costs">http://purl.org/cerif/frapo/directly-incurred-costs</seealso>
    let directly_incurred_costs =
        Prefixed_Name(frapo, "directly-incurred-costs") |> PrefixedName

    /// <summary>
    ///   <para>frapo:donates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking a benefactor to a gift.</para>
    /// labels<para>donates</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/donates">http://purl.org/cerif/frapo/donates</seealso>
    let donates = Prefixed_Name(frapo, "donates") |> PrefixedName
    /// <summary>
    ///   <para>frapo:evaluates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking an agent to an entity which that agent evaluates, for example a funding agency that is evaluating a grant application to determine whether the proposed project is worthy of funding, or a publisher evaluating a manuscript to determine whether it is suitable for publication.</para>
    /// labels<para>evaluates</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/evaluates">http://purl.org/cerif/frapo/evaluates</seealso>
    let evaluates = Prefixed_Name(frapo, "evaluates") |> PrefixedName
    /// <summary>
    ///   <para>frapo:facilities-costs</para>
    /// </summary>
    /// <remarks>
    ///   <para>frapo:BudgetCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A budget category to cover the costs of maintaining facilities used by a project, for example an electron microscopy facility.</para>
    /// labels<para>facilities costs</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/facilities-costs">http://purl.org/cerif/frapo/facilities-costs</seealso>
    let facilities_costs = Prefixed_Name(frapo, "facilities-costs") |> PrefixedName
    /// <summary>
    ///   <para>frapo:familyNameInitial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property permitting specification of the initial(s) of a person's family name.</para>
    /// labels<para>family name initial</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/familyNameInitial">http://purl.org/cerif/frapo/familyNameInitial</seealso>
    let familyNameInitial = Prefixed_Name(frapo, "familyNameInitial") |> PrefixedName
    /// <summary>
    ///   <para>frapo:initial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property permitting specification of the initial(s) of a person's name.</para>
    /// labels<para>initials</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/initial">http://purl.org/cerif/frapo/initial</seealso>
    let initial = Prefixed_Name(frapo, "initial") |> PrefixedName
    /// <summary>
    ///   <para>frapo:feeOrFree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property defining whether participation in an event is free, or requires payment of a fee.</para>
    /// labels<para>fee or free</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/feeOrFree">http://purl.org/cerif/frapo/feeOrFree</seealso>
    let feeOrFree = Prefixed_Name(frapo, "feeOrFree") |> PrefixedName

    /// <summary>
    ///   <para>frapo:full-economic-costs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>frapo:BudgetCategory</para>
    ///   <para>A budget category to cover all the direct and indirect costs of a project. </para>
    /// labels<para>full economic costs</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/full-economic-costs">http://purl.org/cerif/frapo/full-economic-costs</seealso>
    let full_economic_costs =
        Prefixed_Name(frapo, "full-economic-costs") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasAcronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property linking an entity to an acronym used to identify it, based on its full name or title.  For example, this ontology has the full name 'Funding, Research Administration and Projects Ontology' and the acronym 'FRAPO'.</para>
    /// labels<para>has acronym</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasAcronym">http://purl.org/cerif/frapo/hasAcronym</seealso>
    let hasAcronym = Prefixed_Name(frapo, "hasAcronym") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasAgentInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property linking an agent to information about that agent.</para>
    /// labels<para>has information</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasAgentInformation">http://purl.org/cerif/frapo/hasAgentInformation</seealso>
    let hasAgentInformation =
        Prefixed_Name(frapo, "hasAgentInformation") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasApplicationDeadline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date by which an application, for example a job application, a fellowship application or a grant application, has to be submitted if it is to be considered for acceptance or funding.</para>
    /// labels<para>has application deadline</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasApplicationDeadline">http://purl.org/cerif/frapo/hasApplicationDeadline</seealso>
    let hasApplicationDeadline =
        Prefixed_Name(frapo, "hasApplicationDeadline") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasCatalogNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property linking something to its catalog number.</para>
    /// labels<para>has catalog number</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasCatalogNumber">http://purl.org/cerif/frapo/hasCatalogNumber</seealso>
    let hasCatalogNumber = Prefixed_Name(frapo, "hasCatalogNumber") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasCityOrTown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property specifying a city or town, for example as the location of an event.</para>
    /// labels<para>has city or town</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasCityOrTown">http://purl.org/cerif/frapo/hasCityOrTown</seealso>
    let hasCityOrTown = Prefixed_Name(frapo, "hasCityOrTown") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property defining a code.</para>
    /// labels<para>has code</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasCode">http://purl.org/cerif/frapo/hasCode</seealso>
    let hasCode = Prefixed_Name(frapo, "hasCode") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasCompletionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A data property linking something such as a building or a contract to its date of completion.</para>
    /// labels<para>has completion date</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasCompletionDate">http://purl.org/cerif/frapo/hasCompletionDate</seealso>
    let hasCompletionDate = Prefixed_Name(frapo, "hasCompletionDate") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasCost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property enabling the cost of something that can be paid for to be defined.</para>
    /// labels<para>has cost</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasCost">http://purl.org/cerif/frapo/hasCost</seealso>
    let hasCost = Prefixed_Name(frapo, "hasCost") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasCustomerNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property linking an agent to an identifying number for that agent, typically used by the accounting system of the supplier when issuing quotations, fulfilling orders and submitting invoices.</para>
    /// labels<para>has customer number</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasCustomerNumber">http://purl.org/cerif/frapo/hasCustomerNumber</seealso>
    let hasCustomerNumber = Prefixed_Name(frapo, "hasCustomerNumber") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasDecisionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date on which a particular action is or will be decided upon, or when an application, such as a grant application, is or will be approved or rejected. [See also frapo:hasAwardDate.]</para>
    /// labels<para>has decision date</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasDecisionDate">http://purl.org/cerif/frapo/hasDecisionDate</seealso>
    let hasDecisionDate = Prefixed_Name(frapo, "hasDecisionDate") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasDegreeSuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The letters that should be displayed after a person's name to indicate an academic degree, e.g. BA, BVSc, PhD, DSc.</para>
    /// labels<para>has degrees</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasDegreeSuffix">http://purl.org/cerif/frapo/hasDegreeSuffix</seealso>
    let hasDegreeSuffix = Prefixed_Name(frapo, "hasDegreeSuffix") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasNameSuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The letters that should be displayed after a person's name.</para>
    /// labels<para>has name suffix</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasNameSuffix">http://purl.org/cerif/frapo/hasNameSuffix</seealso>
    let hasNameSuffix = Prefixed_Name(frapo, "hasNameSuffix") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasDeliverable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property that permits one to define a deliverable of a project.</para>
    /// labels<para>has deliverable</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasDeliverable">http://purl.org/cerif/frapo/hasDeliverable</seealso>
    let hasDeliverable = Prefixed_Name(frapo, "hasDeliverable") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasReferenceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property linking something to a reference number for that item.</para>
    /// labels<para>has reference number</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasReferenceNumber">http://purl.org/cerif/frapo/hasReferenceNumber</seealso>
    let hasReferenceNumber = Prefixed_Name(frapo, "hasReferenceNumber") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasRegistrationDeadline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date by which registration must be made, for example renewal of an internet domain name.</para>
    /// labels<para>has registration deadline</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasRegistrationDeadline">http://purl.org/cerif/frapo/hasRegistrationDeadline</seealso>
    let hasRegistrationDeadline =
        Prefixed_Name(frapo, "hasRegistrationDeadline") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasSerialNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property linking something, for example a piece of equipment, to its serial number.</para>
    /// labels<para>has serial number</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasSerialNumber">http://purl.org/cerif/frapo/hasSerialNumber</seealso>
    let hasSerialNumber = Prefixed_Name(frapo, "hasSerialNumber") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasStartDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A data property linking something such as a project to its start date.</para>
    /// labels<para>has start date</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasStartDate">http://purl.org/cerif/frapo/hasStartDate</seealso>
    let hasStartDate = Prefixed_Name(frapo, "hasStartDate") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasSupplierNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property linking a supplier to an identifying number for that supplier, typically used by the accounting system of the purchasing institution when placing and tracking orders.</para>
    /// labels<para>has supplier number</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasSupplierNumber">http://purl.org/cerif/frapo/hasSupplierNumber</seealso>
    let hasSupplierNumber = Prefixed_Name(frapo, "hasSupplierNumber") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Account</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A mechanism for administering money, typically owned by an agent and dedicated to a particular purpose, for example the equipment account of a university department, to be used only for the purchase or maintenance of items of equipment. </para>
    /// labels<para>account</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Account">http://purl.org/cerif/frapo/Account</seealso>
    let Account = Prefixed_Name(frapo, "Account") |> PrefixedName

    /// <summary>
    ///   <para>frapo:AdmissionApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The activity of applying for admission to some group or institution, for example a learned society or a university.</para>
    /// labels<para>admission application</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/AdmissionApplication">http://purl.org/cerif/frapo/AdmissionApplication</seealso>
    let AdmissionApplication =
        Prefixed_Name(frapo, "AdmissionApplication") |> PrefixedName

    /// <summary>
    ///   <para>frapo:AnnualTurnover</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The anual financial turnover of an organization (in a specified currency).</para>
    /// labels<para>annual turnover</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/AnnualTurnover">http://purl.org/cerif/frapo/AnnualTurnover</seealso>
    let AnnualTurnover = Prefixed_Name(frapo, "AnnualTurnover") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Fee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An amount of money paid for something that is not purchased.</para>
    /// labels<para>fee</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Fee">http://purl.org/cerif/frapo/Fee</seealso>
    let Fee = Prefixed_Name(frapo, "Fee") |> PrefixedName
    /// <summary>
    ///   <para>frapo:AvailableFunds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The amount available to spend in a budget category, equalling the income minus the expenditure to date plus future expenditure commitments. </para>
    /// labels<para>available funds</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/AvailableFunds">http://purl.org/cerif/frapo/AvailableFunds</seealso>
    let AvailableFunds = Prefixed_Name(frapo, "AvailableFunds") |> PrefixedName
    /// <summary>
    ///   <para>frapo:BudgetCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A category of expenditure within a budget, determining what the allocated money can be spent on, for example salaries, equipment, travel.</para>
    /// labels<para>budget category</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/BudgetCategory">http://purl.org/cerif/frapo/BudgetCategory</seealso>
    let BudgetCategory = Prefixed_Name(frapo, "BudgetCategory") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Bursary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An amount of money given to a person by an organization, for example by a university to a university student in need to enable that student to continue his/her studies.</para>
    /// labels<para>bursary</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Bursary">http://purl.org/cerif/frapo/Bursary</seealso>
    let Bursary = Prefixed_Name(frapo, "Bursary") |> PrefixedName
    /// <summary>
    ///   <para>frapo:College</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An academic organization that is either a small degree-giving university, or (in the OxBridge sense) an independent corporation of scholars within a larger university, providing undergraduate tuition and a social environment for its students and fellows.</para>
    /// labels<para>college</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/College">http://purl.org/cerif/frapo/College</seealso>
    let College = Prefixed_Name(frapo, "College") |> PrefixedName
    /// <summary>
    ///   <para>frapo:ComputationalAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A computer system or software program whose action has an effect on external events, for example a laboratory robot that undertakes your experiments, or the financial control system that controls an institution's payrole, or that, following programmed business rules, prevents the principal investigator from placing an order for research equipment because there is insufficient money left in the project budget.</para>
    /// labels<para>computational agent</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/ComputationalAgent">http://purl.org/cerif/frapo/ComputationalAgent</seealso>
    let ComputationalAgent = Prefixed_Name(frapo, "ComputationalAgent") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A service of help to others, often requiring funding, employees, equipment and/or facilities for its provision, for example a library service, a transportation service, a DNA sequencing service.</para>
    /// labels<para>service</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Service">http://purl.org/cerif/frapo/Service</seealso>
    let Service = Prefixed_Name(frapo, "Service") |> PrefixedName
    /// <summary>
    ///   <para>frapo:ConferenceFee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fee paid to attend a conference.</para>
    /// labels<para>conference fee</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/ConferenceFee">http://purl.org/cerif/frapo/ConferenceFee</seealso>
    let ConferenceFee = Prefixed_Name(frapo, "ConferenceFee") |> PrefixedName

    /// <summary>
    ///   <para>frapo:ConsortiumAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A formal agreement between members of a consortium, for example between research groups at different universities engaged in a multi-partner research project.</para>
    /// labels<para>consortium agreement</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/ConsortiumAgreement">http://purl.org/cerif/frapo/ConsortiumAgreement</seealso>
    let ConsortiumAgreement =
        Prefixed_Name(frapo, "ConsortiumAgreement") |> PrefixedName

    /// <summary>
    ///   <para>frapo:Contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A legally binding agreement between parties.</para>
    /// labels<para>contract</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Contract">http://purl.org/cerif/frapo/Contract</seealso>
    let Contract = Prefixed_Name(frapo, "Contract") |> PrefixedName

    /// <summary>
    ///   <para>frapo:ConsultancyAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A contract between an employer and a consultant, detailing the terms of the consultancy.</para>
    /// labels<para>consultancy agreement</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/ConsultancyAgreement">http://purl.org/cerif/frapo/ConsultancyAgreement</seealso>
    let ConsultancyAgreement =
        Prefixed_Name(frapo, "ConsultancyAgreement") |> PrefixedName

    /// <summary>
    ///   <para>frapo:Output</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Something that is created or produced as a result of a project or an endeavour. Examples include a building resulting from a building project, educated students graduating from an educational programme, and a journal article published as a result of a research project.  Research outputs can also include reports, datasets, experimental protocols, workflows and mathematical models, and material outputs such as a cell line, a mouse mutant or a new form of microscope.</para>
    /// labels<para>output</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Output">http://purl.org/cerif/frapo/Output</seealso>
    let Output = Prefixed_Name(frapo, "Output") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Department</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A department or sub-section within a larger organization, for example a university academic department.</para>
    /// labels<para>department</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Department">http://purl.org/cerif/frapo/Department</seealso>
    let Department = Prefixed_Name(frapo, "Department") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Division</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A grouping of similar departments within a larger organization.  In the university context, also known as a school or a faculty, for example the Humanities Division, the Mathematics Faculty, or the School of Medicine.</para>
    /// labels<para>division</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Division">http://purl.org/cerif/frapo/Division</seealso>
    let Division = Prefixed_Name(frapo, "Division") |> PrefixedName
    /// <summary>
    ///   <para>frapo:EmploymentContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A contract of employment between a person and an organization.</para>
    /// labels<para>employment contract</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/EmploymentContract">http://purl.org/cerif/frapo/EmploymentContract</seealso>
    let EmploymentContract = Prefixed_Name(frapo, "EmploymentContract") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Endeavour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>In FRAPO, an endeavour is an activity such as a research investigation that is enabled by a project.  An endeavour relate to the academic and practical aspects of undertaking that endeavour - thus for a research investigation the research itself, including the hypotheses being investigated, the experiments being undertaken, the data being gathered and analysed, the interpretations being drawn from the data, and the results obtained.  In contrast, the project relates to the administrative aspects of undertaking an endeavour, including the funding obtained, the people employed, and the management of the project in terms of deadlines and deliverables.</para>
    /// labels<para>endeavour</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Endeavour">http://purl.org/cerif/frapo/Endeavour</seealso>
    let Endeavour = Prefixed_Name(frapo, "Endeavour") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Endowment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A transfer, generally as a gift, of money or property to an institution to provide a permanent fund, the income from which is to be used for a particular purpose.  (Abbreviated from http://legal-dictionary.thefreedictionary.com/endowment).</para>
    /// labels<para>endowment</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Endowment">http://purl.org/cerif/frapo/Endowment</seealso>
    let Endowment = Prefixed_Name(frapo, "Endowment") |> PrefixedName
    /// <summary>
    ///   <para>frapo:ExpenditureToDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Total money expended to date from an an account, or from a particular budget category.</para>
    /// labels<para>expenditure to date</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/ExpenditureToDate">http://purl.org/cerif/frapo/ExpenditureToDate</seealso>
    let ExpenditureToDate = Prefixed_Name(frapo, "ExpenditureToDate") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Facility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A place or installation built or designed to serve a specific function or provide a specific service, for example an animal breeding centre, a DNA sequencing facility or a confocal imaging laboratory.</para>
    /// labels<para>facility</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Facility">http://purl.org/cerif/frapo/Facility</seealso>
    let Facility = Prefixed_Name(frapo, "Facility") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Faculty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A grouping of similar departments within a university context, also known as a school or a division, for example the Humanities Division, the Mathematics Faculty, or the School of Medicine.</para>
    /// labels<para>faculty</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Faculty">http://purl.org/cerif/frapo/Faculty</seealso>
    let Faculty = Prefixed_Name(frapo, "Faculty") |> PrefixedName
    /// <summary>
    ///   <para>frapo:FundingApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The activity of applying for funding.</para>
    /// labels<para>funding application</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/FundingApplication">http://purl.org/cerif/frapo/FundingApplication</seealso>
    let FundingApplication = Prefixed_Name(frapo, "FundingApplication") |> PrefixedName
    /// <summary>
    ///   <para>frapo:FundingProgramme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A programme of related funded activities or projects, typically established by a funding agency.  Often associated with publication of a call for applications (fabio:CallForApplications).</para>
    /// labels<para>funding programme</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/FundingProgramme">http://purl.org/cerif/frapo/FundingProgramme</seealso>
    let FundingProgramme = Prefixed_Name(frapo, "FundingProgramme") |> PrefixedName
    /// <summary>
    ///   <para>frapo:HostInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An institution that acts as a host, for example of a project or a person.</para>
    /// labels<para>host institution</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/HostInstitution">http://purl.org/cerif/frapo/HostInstitution</seealso>
    let HostInstitution = Prefixed_Name(frapo, "HostInstitution") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Income</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Money coming into an account.  May be associated with a particular budget category.</para>
    /// labels<para>income</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Income">http://purl.org/cerif/frapo/Income</seealso>
    let Income = Prefixed_Name(frapo, "Income") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Invoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An invoice for payment of goods or services.</para>
    /// labels<para>invoice</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Invoice">http://purl.org/cerif/frapo/Invoice</seealso>
    let Invoice = Prefixed_Name(frapo, "Invoice") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Laboratory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A facility in which research can be conducted.</para>
    /// labels<para>laboratory</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Laboratory">http://purl.org/cerif/frapo/Laboratory</seealso>
    let Laboratory = Prefixed_Name(frapo, "Laboratory") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Legacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A gift of money or property specified in the will of a person, that is made after that person's death.</para>
    /// labels<para>legacy</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Legacy">http://purl.org/cerif/frapo/Legacy</seealso>
    let Legacy = Prefixed_Name(frapo, "Legacy") |> PrefixedName
    /// <summary>
    ///   <para>frapo:MaterialOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A material or physical output created or produced as a result of a project or an endeavour such as a research investigation. Examples include a building constructed as a result of a building project, and research outputs such as a cell line, a mouse mutant or a new form of microscope.</para>
    /// labels<para>material output</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/MaterialOutput">http://purl.org/cerif/frapo/MaterialOutput</seealso>
    let MaterialOutput = Prefixed_Name(frapo, "MaterialOutput") |> PrefixedName

    /// <summary>
    ///   <para>frapo:NotForProfitOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An organization that does not primarily exist to make profit, for example a charity or charitable foundation, a learned society, or a standards body such as the World Wide Web Consortium.</para>
    /// labels<para>not-for-profit organization</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/NotForProfitOrganization">http://purl.org/cerif/frapo/NotForProfitOrganization</seealso>
    let NotForProfitOrganization =
        Prefixed_Name(frapo, "NotForProfitOrganization") |> PrefixedName

    /// <summary>
    ///   <para>frapo:ProjectBudget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A budget for a research project.</para>
    /// labels<para>project budget</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/ProjectBudget">http://purl.org/cerif/frapo/ProjectBudget</seealso>
    let ProjectBudget = Prefixed_Name(frapo, "ProjectBudget") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Purchase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The payment for obtaining something, for example property, goods or services.</para>
    /// labels<para>purchase</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Purchase">http://purl.org/cerif/frapo/Purchase</seealso>
    let Purchase = Prefixed_Name(frapo, "Purchase") |> PrefixedName
    /// <summary>
    ///   <para>frapo:PurchaseOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An official order from a purchasing institution to a supplier for the purchase of goods or services, often issued in response to the receipt of a quotation from the supplier.</para>
    /// labels<para>purchase order</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/PurchaseOrder">http://purl.org/cerif/frapo/PurchaseOrder</seealso>
    let PurchaseOrder = Prefixed_Name(frapo, "PurchaseOrder") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Purchaser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An agent who purchases something from a supplier.</para>
    /// labels<para>purchaser</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Purchaser">http://purl.org/cerif/frapo/Purchaser</seealso>
    let Purchaser = Prefixed_Name(frapo, "Purchaser") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Quotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A formal statement of promise (usually provided in response to a request for quotation) by potential supplier to supply goods or services at specified prices and within a specified period. Acceptance of the quotation by the buyer constitutes an agreement binding on both parties.  (Shortened from http://www.businessdictionary.com/definition/quotation.html).
    /// </para>
    /// labels<para>quotation</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Quotation">http://purl.org/cerif/frapo/Quotation</seealso>
    let Quotation = Prefixed_Name(frapo, "Quotation") |> PrefixedName
    /// <summary>
    ///   <para>frapo:ResearchInstitute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An organization primarily dedicated to undertaking research, that might be part of a university or of a commercial company, or might be independently funded by a research funding agency.  </para>
    /// labels<para>research institute</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/ResearchInstitute">http://purl.org/cerif/frapo/ResearchInstitute</seealso>
    let ResearchInstitute = Prefixed_Name(frapo, "ResearchInstitute") |> PrefixedName
    /// <summary>
    ///   <para>frapo:SME</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A small to medium enterprise, having up to 250 employees.</para>
    /// labels<para>small to medium enterprise</para><para>sme</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/SME">http://purl.org/cerif/frapo/SME</seealso>
    let SME = Prefixed_Name(frapo, "SME") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Scholarship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A financial grant to a scholar to enable him/her to undertake advanced academic study.</para>
    /// labels<para>scholarship</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Scholarship">http://purl.org/cerif/frapo/Scholarship</seealso>
    let Scholarship = Prefixed_Name(frapo, "Scholarship") |> PrefixedName

    /// <summary>
    ///   <para>frapo:ScholarshipApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The activity of applying for an educational scholarship.</para>
    /// labels<para>scholarship application</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/ScholarshipApplication">http://purl.org/cerif/frapo/ScholarshipApplication</seealso>
    let ScholarshipApplication =
        Prefixed_Name(frapo, "ScholarshipApplication") |> PrefixedName

    /// <summary>
    ///   <para>frapo:Subscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Payment, commonly made annually, to obtain access to something on a periodic or continuing basis, such as a journal.</para>
    /// labels<para>subscription</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Subscription">http://purl.org/cerif/frapo/Subscription</seealso>
    let Subscription = Prefixed_Name(frapo, "Subscription") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Supplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An agent who supplies something, such as goods or services.</para>
    /// labels<para>supplier</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Supplier">http://purl.org/cerif/frapo/Supplier</seealso>
    let Supplier = Prefixed_Name(frapo, "Supplier") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Tender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sealed bid or offer document submitted in response to a request for tenders, containing detailed information on costs, requirements and terms associated with a potential contract.  (Adapted from http://www.businessdictionary.com/definition/tender.html).</para>
    /// labels<para>tender</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Tender">http://purl.org/cerif/frapo/Tender</seealso>
    let Tender = Prefixed_Name(frapo, "Tender") |> PrefixedName
    /// <summary>
    ///   <para>frapo:University</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A university at which higher education and research is conducted.</para>
    /// labels<para>university</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/University">http://purl.org/cerif/frapo/University</seealso>
    let University = Prefixed_Name(frapo, "University") |> PrefixedName
    /// <summary>
    ///   <para>frapo:Vendor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An agent who supplies goods or services in exchange for payment, in response to receipt of payment or of an official purchase order from a purchaser that is responded to by submission of an invoice for what is supplied.</para>
    /// labels<para>vendor</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/Vendor">http://purl.org/cerif/frapo/Vendor</seealso>
    let Vendor = Prefixed_Name(frapo, "Vendor") |> PrefixedName
    /// <summary>
    ///   <para>frapo:benefactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Person</para>
    ///   <para>A person who gives a gift.</para>
    /// labels<para>benefactor</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/benefactor">http://purl.org/cerif/frapo/benefactor</seealso>
    let benefactor = Prefixed_Name(frapo, "benefactor") |> PrefixedName
    /// <summary>
    ///   <para>frapo:building-costs</para>
    /// </summary>
    /// <remarks>
    ///   <para>frapo:BudgetCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A budget category to cover the costs of constructing, renovating or modifying a physical building.</para>
    /// labels<para>building costs</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/building-costs">http://purl.org/cerif/frapo/building-costs</seealso>
    let building_costs = Prefixed_Name(frapo, "building-costs") |> PrefixedName
    /// <summary>
    ///   <para>frapo:business-angel</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A person willing to invest in start-up companies.</para>
    /// labels<para>business angel</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/business-angel">http://purl.org/cerif/frapo/business-angel</seealso>
    let business_angel = Prefixed_Name(frapo, "business-angel") |> PrefixedName
    /// <summary>
    ///   <para>frapo:collaboratesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking agents, for example different organizations, or people typically from different groups or organizations, that work together on a common task, project or endeavour, or towards a common goal.</para>
    /// labels<para>collaborates with</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/collaboratesWith">http://purl.org/cerif/frapo/collaboratesWith</seealso>
    let collaboratesWith = Prefixed_Name(frapo, "collaboratesWith") |> PrefixedName
    /// <summary>
    ///   <para>frapo:consultancy-costs</para>
    /// </summary>
    /// <remarks>
    ///   <para>frapo:BudgetCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A budget category to cover the costs of consultancy fees.</para>
    /// labels<para>consultancy costs</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/consultancy-costs">http://purl.org/cerif/frapo/consultancy-costs</seealso>
    let consultancy_costs = Prefixed_Name(frapo, "consultancy-costs") |> PrefixedName
    /// <summary>
    ///   <para>frapo:employs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property relating an employing agent to an employed agent, for example a person or an organization, who is typically employed to undertaking specified work in exchange for payment.</para>
    /// labels<para>employs</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/employs">http://purl.org/cerif/frapo/employs</seealso>
    let employs = Prefixed_Name(frapo, "employs") |> PrefixedName
    /// <summary>
    ///   <para>frapo:enables</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property relating an entity to another entity that it enables, e.g. linking a project to an endeavour that the project enables.</para>
    /// labels<para>enables</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/enables">http://purl.org/cerif/frapo/enables</seealso>
    let enables = Prefixed_Name(frapo, "enables") |> PrefixedName
    /// <summary>
    ///   <para>frapo:entrepreneur</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>A person who invests in novel enterprises.</para><para>entrepreneur</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/entrepreneur">http://purl.org/cerif/frapo/entrepreneur</seealso>
    let entrepreneur = Prefixed_Name(frapo, "entrepreneur") |> PrefixedName
    /// <summary>
    ///   <para>frapo:estates-costs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>frapo:BudgetCategory</para>
    ///   <para>A budget category to cover the 'overhead' costs of maintaining the premises in which work is undertaken.</para>
    /// labels<para>estates costs</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/estates-costs">http://purl.org/cerif/frapo/estates-costs</seealso>
    let estates_costs = Prefixed_Name(frapo, "estates-costs") |> PrefixedName
    /// <summary>
    ///   <para>frapo:funded</para>
    /// </summary>
    /// <remarks>
    ///   <para>frapo:Status</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The status of something such as an investigation or a project as being funded.</para>
    /// labels<para>funded</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/funded">http://purl.org/cerif/frapo/funded</seealso>
    let funded = Prefixed_Name(frapo, "funded") |> PrefixedName
    /// <summary>
    ///   <para>frapo:funds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property that links a grant to something that it funds (i.e. that it finances or pays for), or that links an agent providing funding to something that it funds.  This flexibility is given because of alternative usages of the English word 'funds'.  [See also frapo:awards and frapo:supports.]</para>
    /// labels<para>funds</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/funds">http://purl.org/cerif/frapo/funds</seealso>
    let funds = Prefixed_Name(frapo, "funds") |> PrefixedName
    /// <summary>
    ///   <para>frapo:supports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking an agent to something that the agent supports by financial or other means.</para>
    /// labels<para>supports</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/supports">http://purl.org/cerif/frapo/supports</seealso>
    let supports = Prefixed_Name(frapo, "supports") |> PrefixedName
    /// <summary>
    ///   <para>frapo:isFundedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking something to the funding that funds it (i.e. that finances or pays for it), or to the funding agency providing that funding.  This flexibility is given because of alternative usages of the English word 'funds'.  [See also frapo:isAwardedBy and frapo:hasFundingAgency and frapo:isSupportedBy.]</para>
    /// labels<para>is funded by</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/isFundedBy">http://purl.org/cerif/frapo/isFundedBy</seealso>
    let isFundedBy = Prefixed_Name(frapo, "isFundedBy") |> PrefixedName
    /// <summary>
    ///   <para>frapo:givenNameInitial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property permitting specification of the initial(s) of a person's given name(s).</para>
    /// labels<para>given name initial</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/givenNameInitial">http://purl.org/cerif/frapo/givenNameInitial</seealso>
    let givenNameInitial = Prefixed_Name(frapo, "givenNameInitial") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasAccountNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property linking a financial account to an identifying number for that account.</para>
    /// labels<para>has account number</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasAccountNumber">http://purl.org/cerif/frapo/hasAccountNumber</seealso>
    let hasAccountNumber = Prefixed_Name(frapo, "hasAccountNumber") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasApplicationOutcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property that permits the outcome of an application to be described, for example that a job has been offered or that a grant has been awarded.</para>
    /// labels<para>has application outcome</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasApplicationOutcome">http://purl.org/cerif/frapo/hasApplicationOutcome</seealso>
    let hasApplicationOutcome =
        Prefixed_Name(frapo, "hasApplicationOutcome") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasAwardDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date on which notification is given or received that something, for example a scholarship or a grant, has been awarded.  [See also frapo:hasDecisionDate.]</para>
    /// labels<para>has award date</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasAwardDate">http://purl.org/cerif/frapo/hasAwardDate</seealso>
    let hasAwardDate = Prefixed_Name(frapo, "hasAwardDate") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasBatchNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property linking something, for example a chemical or drug, to its manufacturing batch number.</para>
    /// labels<para>has batch number</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasBatchNumber">http://purl.org/cerif/frapo/hasBatchNumber</seealso>
    let hasBatchNumber = Prefixed_Name(frapo, "hasBatchNumber") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasBirthDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property permitting specification of the birth date of a person.</para>
    /// labels<para>has birth date</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasBirthDate">http://purl.org/cerif/frapo/hasBirthDate</seealso>
    let hasBirthDate = Prefixed_Name(frapo, "hasBirthDate") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasCallIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property specifying the identifying number of a call for applications issued by a funding agency.</para>
    /// labels<para>has call identifier</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasCallIdentifier">http://purl.org/cerif/frapo/hasCallIdentifier</seealso>
    let hasCallIdentifier = Prefixed_Name(frapo, "hasCallIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property specifying a country, for example as the location of an event.</para>
    /// labels<para>has country</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasCountry">http://purl.org/cerif/frapo/hasCountry</seealso>
    let hasCountry = Prefixed_Name(frapo, "hasCountry") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasCountryCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property specifying the two-letter or three-letter upper-case country code used to identify a country (e.g. FR/FRA for France, DE/DEU for Germany) (see http://countrycode.org/).</para>
    /// labels<para>has country code</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasCountryCode">http://purl.org/cerif/frapo/hasCountryCode</seealso>
    let hasCountryCode = Prefixed_Name(frapo, "hasCountryCode") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property defining the currency used to specify a financial entity.  Use in conjection with frapo:hasMonetaryValue.</para>
    /// labels<para>has currency</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasCurrency">http://purl.org/cerif/frapo/hasCurrency</seealso>
    let hasCurrency = Prefixed_Name(frapo, "hasCurrency") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasCurrencyCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property specifying the three-letter currency code used to identify a currency, as defined by ISO 4217 (e.g. EUR or GBP) (see http://en.wikipedia.org/wiki/ISO_4217).
    ///
    /// Not to be confused with the symbol used with numbers to denote an amount of money in a particular currency (e.g.€500; £3.40)</para>
    /// labels<para>has currency code</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasCurrencyCode">http://purl.org/cerif/frapo/hasCurrencyCode</seealso>
    let hasCurrencyCode = Prefixed_Name(frapo, "hasCurrencyCode") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasCurriculumVitae</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking a person to an on-line version of that person's curriculum vitae.</para>
    /// labels<para>has curriculum vitae</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasCurriculumVitae">http://purl.org/cerif/frapo/hasCurriculumVitae</seealso>
    let hasCurriculumVitae = Prefixed_Name(frapo, "hasCurriculumVitae") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasDeliveryDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date on which something is delivered, or is due to be delivered.</para>
    /// labels<para>has delivery date</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasDeliveryDate">http://purl.org/cerif/frapo/hasDeliveryDate</seealso>
    let hasDeliveryDate = Prefixed_Name(frapo, "hasDeliveryDate") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasDispatchDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date on which something, for example an item of equipment, is dispatched by the supplier.</para>
    /// labels<para>has dispatch date</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasDispatchDate">http://purl.org/cerif/frapo/hasDispatchDate</seealso>
    let hasDispatchDate = Prefixed_Name(frapo, "hasDispatchDate") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasDomainName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property linking an entity to an internet domain name that has been registered for that entity, for example http://www.miidi.org for MIIDI, the Minimal Information standard for reporting an Infectious Disease Investigation.</para>
    /// labels<para>has domain name</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasDomainName">http://purl.org/cerif/frapo/hasDomainName</seealso>
    let hasDomainName = Prefixed_Name(frapo, "hasDomainName") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasEndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A data property linking something such as a project to its end date.</para>
    /// labels<para>has end date</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasEndDate">http://purl.org/cerif/frapo/hasEndDate</seealso>
    let hasEndDate = Prefixed_Name(frapo, "hasEndDate") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasExchangeRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property specifying the currency exchange rate between two specified currencies.</para>
    /// labels<para>has exchange rate</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasExchangeRate">http://purl.org/cerif/frapo/hasExchangeRate</seealso>
    let hasExchangeRate = Prefixed_Name(frapo, "hasExchangeRate") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasExpertise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property identifying the area(s) of expertise and skills posessed by an individual or an organization.</para>
    /// labels<para>has expertise</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasExpertise">http://purl.org/cerif/frapo/hasExpertise</seealso>
    let hasExpertise = Prefixed_Name(frapo, "hasExpertise") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasExpiryDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property linking something, for example a drug, to its expiry date, beyond which the manufacture recommends that it should not be used.</para>
    /// labels<para>has expiry date</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasExpiryDate">http://purl.org/cerif/frapo/hasExpiryDate</seealso>
    let hasExpiryDate = Prefixed_Name(frapo, "hasExpiryDate") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasFamilialSuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The letters that may be displayed after a person's name to indicate familial status, e.g. Sn., Jn., III, 3rd.</para>
    /// labels<para>has familiar suffix</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasFamilialSuffix">http://purl.org/cerif/frapo/hasFamilialSuffix</seealso>
    let hasFamilialSuffix = Prefixed_Name(frapo, "hasFamilialSuffix") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasFaxNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property identifying a Fax number for an agent.</para>
    /// labels<para>has fax number</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasFaxNumber">http://purl.org/cerif/frapo/hasFaxNumber</seealso>
    let hasFaxNumber = Prefixed_Name(frapo, "hasFaxNumber") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasFunderIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property linking a funding agency to an identifier for that funding agency.</para>
    /// labels<para>has funder identifer</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasFunderIdentifier">http://purl.org/cerif/frapo/hasFunderIdentifier</seealso>
    let hasFunderIdentifier =
        Prefixed_Name(frapo, "hasFunderIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasFundingAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking something to a funding agency that provides funding for it.</para>
    /// labels<para>has funding agency</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasFundingAgency">http://purl.org/cerif/frapo/hasFundingAgency</seealso>
    let hasFundingAgency = Prefixed_Name(frapo, "hasFundingAgency") |> PrefixedName
    /// <summary>
    ///   <para>frapo:isSupportedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking something to an agent that provides funding or other support for it.</para>
    /// labels<para>is supported by</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/isSupportedBy">http://purl.org/cerif/frapo/isSupportedBy</seealso>
    let isSupportedBy = Prefixed_Name(frapo, "isSupportedBy") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasGrantNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property specifying the grant number of a grant provided by a funding agency.</para>
    /// labels<para>has grant number</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasGrantNumber">http://purl.org/cerif/frapo/hasGrantNumber</seealso>
    let hasGrantNumber = Prefixed_Name(frapo, "hasGrantNumber") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasHeadcount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property specifying the number of people employed by an organization.</para>
    /// labels<para>has headcount</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasHeadcount">http://purl.org/cerif/frapo/hasHeadcount</seealso>
    let hasHeadcount = Prefixed_Name(frapo, "hasHeadcount") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasOrganizationalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>It describes information about the organization.</para>
    /// labels<para>has organizational information</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasOrganizationalInformation">http://purl.org/cerif/frapo/hasOrganizationalInformation</seealso>
    let hasOrganizationalInformation =
        Prefixed_Name(frapo, "hasOrganizationalInformation") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasHonorificSuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The letters that should be displayed after a person's name to indicate qualification, membership or fellowship in a professional society, honours or elite status, e.g. MRCVS, FRCS, FRS, OBE, Kt.</para>
    /// labels<para>post-nominals</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasHonorificSuffix">http://purl.org/cerif/frapo/hasHonorificSuffix</seealso>
    let hasHonorificSuffix = Prefixed_Name(frapo, "hasHonorificSuffix") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasIPROwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking an entity such as a project, an endeavour or an output to an agent who owns the IPR arising from or related to that entity.</para>
    /// labels<para>has IPR owner</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasIPROwner">http://purl.org/cerif/frapo/hasIPROwner</seealso>
    let hasIPROwner = Prefixed_Name(frapo, "hasIPROwner") |> PrefixedName
    /// <summary>
    ///   <para>frapo:isOwnedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking an entity to the agent that owns it.</para>
    /// labels<para>is owned by</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/isOwnedBy">http://purl.org/cerif/frapo/isOwnedBy</seealso>
    let isOwnedBy = Prefixed_Name(frapo, "isOwnedBy") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasInvoiceDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A data property linking an invoice to its date.</para>
    /// labels<para>has invoice date</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasInvoiceDate">http://purl.org/cerif/frapo/hasInvoiceDate</seealso>
    let hasInvoiceDate = Prefixed_Name(frapo, "hasInvoiceDate") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasJobTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property permitting specification of the job title held by a person, such as might appear next to the name in a directory or on a conference name badge.  For example, the person's specific Job Title might be 'Linacre Professor of Zoology' or 'Regius Professor of Moral Philosophy'.
    ///
    /// This job title properly refers to the **role** held by that person (e.g. 'Head of Department'), which can be separately defined using SCoRO, the Scholarly Contributions and Roles Ontology (http://purl.org/spar/scoro/). [see scoro:withJobTitle].
    ///
    /// </para>
    /// labels<para>has job title</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasJobTitle">http://purl.org/cerif/frapo/hasJobTitle</seealso>
    let hasJobTitle = Prefixed_Name(frapo, "hasJobTitle") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasPersonalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property linking a person to information about that person.</para>
    /// labels<para>has contact information</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasPersonalInformation">http://purl.org/cerif/frapo/hasPersonalInformation</seealso>
    let hasPersonalInformation =
        Prefixed_Name(frapo, "hasPersonalInformation") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasKeyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property permitting specification of a keyword relating to an entity.</para>
    /// labels<para>has keyword</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasKeyword">http://purl.org/cerif/frapo/hasKeyword</seealso>
    let hasKeyword = Prefixed_Name(frapo, "hasKeyword") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasLanguageCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property specifying the two-letter or three-letter lower-case code used to identify a language (e.g. fr/fra for French, de/deu for Germany) (see http://en.wikipedia.org/wiki/List_of_ISO_639-1_codes).</para>
    /// labels<para>has language code</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasLanguageCode">http://purl.org/cerif/frapo/hasLanguageCode</seealso>
    let hasLanguageCode = Prefixed_Name(frapo, "hasLanguageCode") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property link an entity to a relevant location, which might be geographical (e.g. New York City) or local (e.g. Freezer B, second shelf).</para>
    /// labels<para>has location</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasLocation">http://purl.org/cerif/frapo/hasLocation</seealso>
    let hasLocation = Prefixed_Name(frapo, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasManufactureDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A data property linking something to its date of manufacture.</para>
    /// labels<para>has data of manufacture</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasManufactureDate">http://purl.org/cerif/frapo/hasManufactureDate</seealso>
    let hasManufactureDate = Prefixed_Name(frapo, "hasManufactureDate") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasMilestone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property that permits one to define a significant event (a 'milestone') in the progress of a project.</para>
    /// labels<para>has milestone</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasMilestone">http://purl.org/cerif/frapo/hasMilestone</seealso>
    let hasMilestone = Prefixed_Name(frapo, "hasMilestone") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasModelNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property linking something, for example a piece of equipment, to its model number.</para>
    /// labels<para>has model number</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasModelNumber">http://purl.org/cerif/frapo/hasModelNumber</seealso>
    let hasModelNumber = Prefixed_Name(frapo, "hasModelNumber") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasMonetaryValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property enabling one to specify the monetary value of a financial entity such as a grant, a gift or a budget category.  Use in conjuction with frapo:hasCurrency.</para>
    /// labels<para>has value</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasMonetaryValue">http://purl.org/cerif/frapo/hasMonetaryValue</seealso>
    let hasMonetaryValue = Prefixed_Name(frapo, "hasMonetaryValue") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasORCID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property relating an individual to his/her Open Researcher and Contributor ID (ORCID), an alphanumeric identifier for individual scholars described at http://about.orcid.org/.</para>
    /// labels<para>has ORCID</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasORCID">http://purl.org/cerif/frapo/hasORCID</seealso>
    let hasORCID = Prefixed_Name(frapo, "hasORCID") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasPersonalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A unique and unambiguous identifier for an individual person within a given context.</para>
    /// labels<para>has personal identifier</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasPersonalIdentifier">http://purl.org/cerif/frapo/hasPersonalIdentifier</seealso>
    let hasPersonalIdentifier =
        Prefixed_Name(frapo, "hasPersonalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking an activity such as a project or endeavour to something that is created or produced as a result of that activity.  Examples include a building created as a result of a building project, and a journal article published to describe the results of a research investigation.  </para>
    /// labels<para>has output</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasOutput">http://purl.org/cerif/frapo/hasOutput</seealso>
    let hasOutput = Prefixed_Name(frapo, "hasOutput") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasPhoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property identifying a telephone number for an agent.</para>
    /// labels<para>has phone number</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasPhoneNumber">http://purl.org/cerif/frapo/hasPhoneNumber</seealso>
    let hasPhoneNumber = Prefixed_Name(frapo, "hasPhoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasPostCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property defining the postal code of an address.</para>
    /// labels<para>has post code</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasPostCode">http://purl.org/cerif/frapo/hasPostCode</seealso>
    let hasPostCode = Prefixed_Name(frapo, "hasPostCode") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasPostalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property identifying a postal address for an agent.</para>
    /// labels<para>has postal address</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasPostalAddress">http://purl.org/cerif/frapo/hasPostalAddress</seealso>
    let hasPostalAddress = Prefixed_Name(frapo, "hasPostalAddress") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasPostalAddressLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property permitting specification of a single line of a postal address.</para>
    /// labels<para>has postal address line</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasPostalAddressLine">http://purl.org/cerif/frapo/hasPostalAddressLine</seealso>
    let hasPostalAddressLine =
        Prefixed_Name(frapo, "hasPostalAddressLine") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasProfessionalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An alternative name that a person uses for professional purposes, for example the pen name of an author, or a married woman's maiden name used as her professional name. </para>
    /// labels<para>has alternate name</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasProfessionalName">http://purl.org/cerif/frapo/hasProfessionalName</seealso>
    let hasProfessionalName =
        Prefixed_Name(frapo, "hasProfessionalName") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasProjectIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property linking a project to an identifier for that project.</para>
    /// labels<para>has project identifier</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasProjectIdentifier">http://purl.org/cerif/frapo/hasProjectIdentifier</seealso>
    let hasProjectIdentifier =
        Prefixed_Name(frapo, "hasProjectIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasProvenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property that permits the provenance of an entity to be described.</para>
    /// labels<para>has provenance</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasProvenance">http://purl.org/cerif/frapo/hasProvenance</seealso>
    let hasProvenance = Prefixed_Name(frapo, "hasProvenance") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasPurchaseDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property linking something to its purchase date.</para>
    /// labels<para>has purchase date</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasPurchaseDate">http://purl.org/cerif/frapo/hasPurchaseDate</seealso>
    let hasPurchaseDate = Prefixed_Name(frapo, "hasPurchaseDate") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasPurchaseOrderNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property identifying an official purchase order issued by a purchasing agent to a supplier of goods or services, and used by the supplier to identify the order when delivering goods or submitting an invoice.</para>
    /// labels<para>has purchase order number</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasPurchaseOrderNumber">http://purl.org/cerif/frapo/hasPurchaseOrderNumber</seealso>
    let hasPurchaseOrderNumber =
        Prefixed_Name(frapo, "hasPurchaseOrderNumber") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasQualification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property permitting specification of the qualification held by a person.</para>
    /// labels<para>has qualification</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasQualification">http://purl.org/cerif/frapo/hasQualification</seealso>
    let hasQualification = Prefixed_Name(frapo, "hasQualification") |> PrefixedName
    /// <summary>
    ///   <para>frapo:hasQuotationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property linking a quotation to its date.</para>
    /// labels<para>has quotation date</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasQuotationDate">http://purl.org/cerif/frapo/hasQuotationDate</seealso>
    let hasQuotationDate = Prefixed_Name(frapo, "hasQuotationDate") |> PrefixedName

    /// <summary>
    ///   <para>frapo:hasTemporalDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data property enabling one to define the temporal duration of some entity such as an event or a project.</para>
    /// labels<para>has temporal duration</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/hasTemporalDuration">http://purl.org/cerif/frapo/hasTemporalDuration</seealso>
    let hasTemporalDuration =
        Prefixed_Name(frapo, "hasTemporalDuration") |> PrefixedName

    /// <summary>
    ///   <para>frapo:indirect-costs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>frapo:BudgetCategory</para>
    ///   <para>A budget category to cover the indirect costs of running a project, for example heating and lighting, and the employment of non-project staff including administrators, accountants and cleaners.</para>
    /// labels<para>indirect costs</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/indirect-costs">http://purl.org/cerif/frapo/indirect-costs</seealso>
    let indirect_costs = Prefixed_Name(frapo, "indirect-costs") |> PrefixedName
    /// <summary>
    ///   <para>frapo:isAppliedForBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking something applied for to the agent making the application.</para>
    /// labels<para>is applied for by</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/isAppliedForBy">http://purl.org/cerif/frapo/isAppliedForBy</seealso>
    let isAppliedForBy = Prefixed_Name(frapo, "isAppliedForBy") |> PrefixedName
    /// <summary>
    ///   <para>frapo:isAwardedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>An object property linking something awarded to the agent making the award, for example linking a grant to a funding agency, a degree to a university, or a prize to the awarding organization.</para>
    /// labels<para>is awarded by</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/isAwardedBy">http://purl.org/cerif/frapo/isAwardedBy</seealso>
    let isAwardedBy = Prefixed_Name(frapo, "isAwardedBy") |> PrefixedName
    /// <summary>
    ///   <para>frapo:isDonatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking a gift to the benefactor who provided it.</para>
    /// labels<para>is donated by</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/isDonatedBy">http://purl.org/cerif/frapo/isDonatedBy</seealso>
    let isDonatedBy = Prefixed_Name(frapo, "isDonatedBy") |> PrefixedName
    /// <summary>
    ///   <para>frapo:isEmployedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property relating an employed agent, typically a person or an organization, to an employing agent.</para>
    /// labels<para>is employed by</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/isEmployedBy">http://purl.org/cerif/frapo/isEmployedBy</seealso>
    let isEmployedBy = Prefixed_Name(frapo, "isEmployedBy") |> PrefixedName
    /// <summary>
    ///   <para>frapo:isEnabledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property relating an entity to another entity that enables it, e.g. linking an investigation to a project that enables it.</para>
    /// labels<para>is enabled by</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/isEnabledBy">http://purl.org/cerif/frapo/isEnabledBy</seealso>
    let isEnabledBy = Prefixed_Name(frapo, "isEnabledBy") |> PrefixedName
    /// <summary>
    ///   <para>frapo:isEvaluatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking an entity to an agent that evaluates it.</para>
    /// labels<para>is evaluated by</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/isEvaluatedBy">http://purl.org/cerif/frapo/isEvaluatedBy</seealso>
    let isEvaluatedBy = Prefixed_Name(frapo, "isEvaluatedBy") |> PrefixedName
    /// <summary>
    ///   <para>frapo:isFundingAgencyFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking a funding agency to an entity for which it provides funding.</para>
    /// labels<para>is funding agency for</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/isFundingAgencyFor">http://purl.org/cerif/frapo/isFundingAgencyFor</seealso>
    let isFundingAgencyFor = Prefixed_Name(frapo, "isFundingAgencyFor") |> PrefixedName
    /// <summary>
    ///   <para>frapo:isManufacturedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property relating a manufactured entity to its manufacturer.</para>
    /// labels<para>is manufactured by</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/isManufacturedBy">http://purl.org/cerif/frapo/isManufacturedBy</seealso>
    let isManufacturedBy = Prefixed_Name(frapo, "isManufacturedBy") |> PrefixedName
    /// <summary>
    ///   <para>frapo:manufactures</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property relating a manufacturer to a manufactured entity.</para>
    /// labels<para>manufactures</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/manufactures">http://purl.org/cerif/frapo/manufactures</seealso>
    let manufactures = Prefixed_Name(frapo, "manufactures") |> PrefixedName
    /// <summary>
    ///   <para>frapo:isOutputOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking something that is created or produced to the activity that created or produced it.</para>
    /// labels<para>is output of</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/isOutputOf">http://purl.org/cerif/frapo/isOutputOf</seealso>
    let isOutputOf = Prefixed_Name(frapo, "isOutputOf") |> PrefixedName
    /// <summary>
    ///   <para>frapo:owns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking an agent to an entity owned by that agent.</para>
    /// labels<para>owns</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/owns">http://purl.org/cerif/frapo/owns</seealso>
    let owns = Prefixed_Name(frapo, "owns") |> PrefixedName
    /// <summary>
    ///   <para>frapo:isPurchasedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property relating a purchased entity to its purchaser.</para>
    /// labels<para>was purchased by</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/isPurchasedBy">http://purl.org/cerif/frapo/isPurchasedBy</seealso>
    let isPurchasedBy = Prefixed_Name(frapo, "isPurchasedBy") |> PrefixedName
    /// <summary>
    ///   <para>frapo:isSubmittedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking an entity that is submitted (to some third party) to the agent who submits it.</para>
    /// labels<para>is submitted by</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/isSubmittedBy">http://purl.org/cerif/frapo/isSubmittedBy</seealso>
    let isSubmittedBy = Prefixed_Name(frapo, "isSubmittedBy") |> PrefixedName
    /// <summary>
    ///   <para>frapo:submits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking an agent to an entity that is submitted to some third party, for example a grant application submitted to a funding agency, a manuscript submitted to a publisher, a quotation submitted by a vendor, or a dataset submitted by a researcher to a data repository.</para>
    /// labels<para>submits</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/submits">http://purl.org/cerif/frapo/submits</seealso>
    let submits = Prefixed_Name(frapo, "submits") |> PrefixedName
    /// <summary>
    ///   <para>frapo:isSuppliedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property relating an entity that is supplied, or an agent to whom an entity is supplied, to the supplier.</para>
    /// labels<para>is supplied by</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/isSuppliedBy">http://purl.org/cerif/frapo/isSuppliedBy</seealso>
    let isSuppliedBy = Prefixed_Name(frapo, "isSuppliedBy") |> PrefixedName
    /// <summary>
    ///   <para>frapo:supplies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property relating a supplier to a supplied entity, or to an agent to whom the entity is supplied.</para>
    /// labels<para>supplies</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/supplies">http://purl.org/cerif/frapo/supplies</seealso>
    let supplies = Prefixed_Name(frapo, "supplies") |> PrefixedName
    /// <summary>
    ///   <para>frapo:non-staff-costs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>frapo:BudgetCategory</para>
    ///   <para>A budget category to cover all the costs associated with a project that do not involve the employment of staff by the institution, thus, for example, including consumables purchase, travel costs and consultancy fees, but excluding the salary, estates and indirect costs associated with the allocation of the PI's time to the project and the direct employment of a project manager.</para>
    /// labels<para>non-staff costs</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/non-staff-costs">http://purl.org/cerif/frapo/non-staff-costs</seealso>
    let non_staff_costs = Prefixed_Name(frapo, "non-staff-costs") |> PrefixedName
    /// <summary>
    ///   <para>frapo:other-costs</para>
    /// </summary>
    /// <remarks>
    ///   <para>frapo:BudgetCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A budget category to cover costs not covered in other budget categories.</para>
    /// labels<para>other costs</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/other-costs">http://purl.org/cerif/frapo/other-costs</seealso>
    let other_costs = Prefixed_Name(frapo, "other-costs") |> PrefixedName
    /// <summary>
    ///   <para>frapo:overhead-costs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>frapo:BudgetCategory</para>
    ///   <para>A budget category to cover all the non-directly incurred costs of a project, including estates costs and indirect costs, that enable an institution to host an externally-funded project. </para>
    /// labels<para>overhead costs</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/overhead-costs">http://purl.org/cerif/frapo/overhead-costs</seealso>
    let overhead_costs = Prefixed_Name(frapo, "overhead-costs") |> PrefixedName
    /// <summary>
    ///   <para>frapo:owl:sameAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cerif/frapo/owl:sameAs">http://purl.org/cerif/frapo/owl:sameAs</seealso>
    let ``owl:sameAs`` = Prefixed_Name(frapo, "owl:sameAs") |> PrefixedName
    /// <summary>
    ///   <para>frapo:ownsIRPOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking an agent who owns IPR arising from or relating to an entity to that entity.</para>
    /// labels<para>owns IPR of</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/ownsIRPOf">http://purl.org/cerif/frapo/ownsIRPOf</seealso>
    let ownsIRPOf = Prefixed_Name(frapo, "ownsIRPOf") |> PrefixedName

    /// <summary>
    ///   <para>frapo:providesFractionOfTotalFunding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking funding to a budget, specifying what fraction of the total budget is provided by that source of funding.</para>
    /// labels<para>percentage of total funding</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/providesFractionOfTotalFunding">http://purl.org/cerif/frapo/providesFractionOfTotalFunding</seealso>
    let providesFractionOfTotalFunding =
        Prefixed_Name(frapo, "providesFractionOfTotalFunding") |> PrefixedName

    /// <summary>
    ///   <para>frapo:providesService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An agent that provides a service.</para>
    /// labels<para>provides service</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/providesService">http://purl.org/cerif/frapo/providesService</seealso>
    let providesService = Prefixed_Name(frapo, "providesService") |> PrefixedName
    /// <summary>
    ///   <para>frapo:publishing-costs</para>
    /// </summary>
    /// <remarks>
    ///   <para>frapo:BudgetCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A budget category to cover the cost of publishing outpots from a project, for example author fees for journal articles in an open access journal.</para>
    /// labels<para>publishing costs</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/publishing-costs">http://purl.org/cerif/frapo/publishing-costs</seealso>
    let publishing_costs = Prefixed_Name(frapo, "publishing-costs") |> PrefixedName
    /// <summary>
    ///   <para>frapo:purchases</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property relating a purchaser to a purchased entity.</para>
    /// labels<para>purchases</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/purchases">http://purl.org/cerif/frapo/purchases</seealso>
    let purchases = Prefixed_Name(frapo, "purchases") |> PrefixedName
    /// <summary>
    ///   <para>frapo:purchasesFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property relating a purchaser to a supplier from whom the purchase is made.</para>
    /// labels<para>purchases from</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/purchasesFrom">http://purl.org/cerif/frapo/purchasesFrom</seealso>
    let purchasesFrom = Prefixed_Name(frapo, "purchasesFrom") |> PrefixedName
    /// <summary>
    ///   <para>frapo:rejected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>frapo:Status</para>
    ///   <para>The status of something such as an application as having been rejected.</para>
    /// labels<para>rejected</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/rejected">http://purl.org/cerif/frapo/rejected</seealso>
    let rejected = Prefixed_Name(frapo, "rejected") |> PrefixedName
    /// <summary>
    ///   <para>frapo:sellsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property relating a supplier to a purchaser to whom an entity is sold.</para>
    /// labels<para>sells to</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/sellsTo">http://purl.org/cerif/frapo/sellsTo</seealso>
    let sellsTo = Prefixed_Name(frapo, "sellsTo") |> PrefixedName
    /// <summary>
    ///   <para>frapo:service-costs</para>
    /// </summary>
    /// <remarks>
    ///   <para>frapo:BudgetCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A budget category to cover the costs of services used by a project, for example a DNA sequencing service, or an equipment maintenance service.</para>
    /// labels<para>service costs</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/service-costs">http://purl.org/cerif/frapo/service-costs</seealso>
    let service_costs = Prefixed_Name(frapo, "service-costs") |> PrefixedName
    /// <summary>
    ///   <para>frapo:software-costs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>frapo:BudgetCategory</para>
    ///   <para>A budget category to cover the costs of software licenses required by a project.</para>
    /// labels<para>software costs</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/software-costs">http://purl.org/cerif/frapo/software-costs</seealso>
    let software_costs = Prefixed_Name(frapo, "software-costs") |> PrefixedName

    /// <summary>
    ///   <para>frapo:specifiesExpediture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property relating an agent or a budget to the expenditure specified by that agent or budget.</para>
    /// labels<para>specifies expenditure</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/specifiesExpediture">http://purl.org/cerif/frapo/specifiesExpediture</seealso>
    let specifiesExpediture =
        Prefixed_Name(frapo, "specifiesExpediture") |> PrefixedName

    /// <summary>
    ///   <para>frapo:travel-and-subsistence-costs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>frapo:BudgetCategory</para>
    ///   <para>A budget category to cover the costs of travel and subsistence incurred on behalf of the project.</para>
    /// labels<para>travel and subsistence costs</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/travel-and-subsistence-costs">http://purl.org/cerif/frapo/travel-and-subsistence-costs</seealso>
    let travel_and_subsistence_costs =
        Prefixed_Name(frapo, "travel-and-subsistence-costs") |> PrefixedName

    /// <summary>
    ///   <para>frapo:unfunded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>frapo:Status</para>
    ///   <para>The status of something such as an investigation or a project as being unfunded.</para>
    /// labels<para>unfunded</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/unfunded">http://purl.org/cerif/frapo/unfunded</seealso>
    let unfunded = Prefixed_Name(frapo, "unfunded") |> PrefixedName
    /// <summary>
    ///   <para>frapo:usesEquipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking an activity such as an expedition, a research project or an investigation, to an item of equipment employed in that activity.</para>
    /// labels<para>uses equipment</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/usesEquipment">http://purl.org/cerif/frapo/usesEquipment</seealso>
    let usesEquipment = Prefixed_Name(frapo, "usesEquipment") |> PrefixedName
    /// <summary>
    ///   <para>frapo:usesFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking an activity such as an expedition, a research project or an investigation, to a facility employed in that activity.</para>
    /// labels<para>uses facility</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/usesFacility">http://purl.org/cerif/frapo/usesFacility</seealso>
    let usesFacility = Prefixed_Name(frapo, "usesFacility") |> PrefixedName
    /// <summary>
    ///   <para>frapo:usesService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property linking an activity such as an expedition, a research project or an investigation, to a service employed in that activity.</para>
    /// labels<para>uses service</para></remarks>
    /// <seealso href="http://purl.org/cerif/frapo/usesService">http://purl.org/cerif/frapo/usesService</seealso>
    let usesService = Prefixed_Name(frapo, "usesService") |> PrefixedName
