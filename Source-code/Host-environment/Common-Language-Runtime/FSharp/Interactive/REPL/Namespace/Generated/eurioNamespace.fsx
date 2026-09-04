#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module eurio =
    let _prefixId = PrefixId.fromNamespaceLabel "http://data.europa.eu/s66#" "eurio"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Acronym</para>
    ///   <para>rdfs:comment : An abbreviation formed from the initial letters of other words and pronounced as a word. It can refer to any type of entities in the CORDIS conceptual framework, and may be stated explicitly or extracted automatically from text.</para>
    ///   <a href="http://data.europa.eu/s66#Acronym">eurio:Acronym</a>
    /// </summary>
    let Acronym = _prefixId.prefix "Acronym"
    /// <summary>
    ///   <para>rdfs:label : Administrative Area</para>
    ///   <para>rdfs:comment : An administrative geographical area that is typically managed by a public body. It can be a country, a region, a municipality, a province, a sub-municipality area, etc.</para>
    ///   <a href="http://data.europa.eu/s66#AdministrativeArea">eurio:AdministrativeArea</a>
    /// </summary>
    let AdministrativeArea = _prefixId.prefix "AdministrativeArea"
    /// <summary>
    ///   <para>rdfs:label : Book</para>
    ///   <para>rdfs:comment : A non-serial document that is complete in one volume or a designated finite number of volumes. A book published by a publisher is usually identified by an International Standard Book Number (ISBN), and may be manifested as a physical printed publication on paper bound in a hard or soft cover, or in electronic format as an 'e-book'.</para>
    ///   <a href="http://data.europa.eu/s66#Book">eurio:Book</a>
    /// </summary>
    let Book = _prefixId.prefix "Book"
    /// <summary>
    ///   <para>rdfs:label : Coordinates</para>
    ///   <para>rdfs:comment : The geo coordinates for a location of entities that participate in or form part of research projects.</para>
    ///   <a href="http://data.europa.eu/s66#Coordinates">eurio:Coordinates</a>
    /// </summary>
    let Coordinates = _prefixId.prefix "Coordinates"
    /// <summary>
    ///   <para>rdfs:label : Country</para>
    ///   <para>rdfs:comment : A country</para>
    ///   <a href="http://data.europa.eu/s66#Country">eurio:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>rdfs:label : Detected Acronym</para>
    ///   <para>rdfs:comment : Any acronym that has been detected, automatically or manually, from the description of an entity or from any other form of natural language text.</para>
    ///   <a href="http://data.europa.eu/s66#DetectedAcronym">eurio:DetectedAcronym</a>
    /// </summary>
    let DetectedAcronym = _prefixId.prefix "DetectedAcronym"
    /// <summary>
    ///   <para>rdfs:label : For Profit Organisation</para>
    ///   <para>rdfs:comment : A for profit entity</para>
    ///   <a href="http://data.europa.eu/s66#ForProfitOrganisation">eurio:ForProfitOrganisation</a>
    /// </summary>
    let ForProfitOrganisation = _prefixId.prefix "ForProfitOrganisation"
    /// <summary>
    ///   <para>rdfs:label : Funding Agency</para>
    ///   <para>rdfs:comment : An organisation that materially administrates funding schemes and disburses related grants. In the context of CORDIS, it represents the various European agencies responsible for funding research projects (e.g. ERC, EASME, REA, etc.).</para>
    ///   <a href="http://data.europa.eu/s66#FundingAgency">eurio:FundingAgency</a>
    /// </summary>
    let FundingAgency = _prefixId.prefix "FundingAgency"
    /// <summary>
    ///   <para>rdfs:comment : Set of rules and conditions which forms the basis for public funding of European research. In CORDIS, they represent the different legal frameworks (e.g. FP6, FP7, H2020). They can also be used to represent the different calls inside each framework by using the recursive relation “partOfScheme”.</para>
    ///   <para>rdfs:label : Funding Scheme</para>
    ///   <a href="http://data.europa.eu/s66#FundingScheme">eurio:FundingScheme</a>
    /// </summary>
    let FundingScheme = _prefixId.prefix "FundingScheme"
    /// <summary>
    ///   <para>rdfs:comment : A disbursed fund paid to a recipient or beneficiary within the context of a funded research project. In the context of CORDIS, it represents a grant of a specific EU programme (e.g. an H2020 grant).</para>
    ///   <para>rdfs:label : Grant</para>
    ///   <a href="http://data.europa.eu/s66#Grant">eurio:Grant</a>
    /// </summary>
    let Grant = _prefixId.prefix "Grant"
    /// <summary>
    ///   <para>rdfs:label : Grant Payment</para>
    ///   <para>rdfs:comment : A single payment to a recipient or beneficiary of a Grant within a research project.</para>
    ///   <a href="http://data.europa.eu/s66#GrantPayment">eurio:GrantPayment</a>
    /// </summary>
    let GrantPayment = _prefixId.prefix "GrantPayment"
    /// <summary>
    ///   <para>rdfs:label : Higher Or Secondary Education</para>
    ///   <para>rdfs:comment : Institution that provides education.</para>
    ///   <a href="http://data.europa.eu/s66#HigherOrSecondaryEducation">eurio:HigherOrSecondaryEducation</a>
    /// </summary>
    let HigherOrSecondaryEducation = _prefixId.prefix "HigherOrSecondaryEducation"
    /// <summary>
    ///   <para>rdfs:label : Journal Paper</para>
    ///   <para>rdfs:comment : An article, typically the realization of a research paper reporting original research findings, published in a journal issue.</para>
    ///   <a href="http://data.europa.eu/s66#JournalPaper">eurio:JournalPaper</a>
    /// </summary>
    let JournalPaper = _prefixId.prefix "JournalPaper"
    /// <summary>
    ///   <para>rdfs:label : Monetary Amount</para>
    ///   <para>rdfs:comment : A monetary value or range. This type can be used to describe an amount of money such as $50 USD, or a range as in describing a bank account being suitable for a balance between £1,000 and £1,000,000 GBP, or the value of a salary, etc.</para>
    ///   <a href="http://data.europa.eu/s66#MonetaryAmount">eurio:MonetaryAmount</a>
    /// </summary>
    let MonetaryAmount = _prefixId.prefix "MonetaryAmount"
    /// <summary>
    ///   <para>rdfs:label : Non Peer-Reviewed Publication</para>
    ///   <para>rdfs:comment : A work that hasn't undergone peer reviewing prior to its publication.</para>
    ///   <a href="http://data.europa.eu/s66#NonPeerReviewedPublication">eurio:NonPeerReviewedPublication</a>
    /// </summary>
    let NonPeerReviewedPublication = _prefixId.prefix "NonPeerReviewedPublication"
    /// <summary>
    ///   <para>rdfs:comment : Represents a group of people, with the same purpose, organized together into a community or other social, commercial or political structure that participate in CORDIS projects.</para>
    ///   <para>rdfs:label : Organisation</para>
    ///   <a href="http://data.europa.eu/s66#Organisation">eurio:Organisation</a>
    /// </summary>
    let Organisation = _prefixId.prefix "Organisation"
    /// <summary>
    ///   <para>rdfs:label : Organisation Role</para>
    ///   <para>rdfs:comment : Function assumed by or ascribed to an organisation that takes part in a particular project. In CORDIs, it represents roles such as coordinator, partner, consortium member, etc.</para>
    ///   <a href="http://data.europa.eu/s66#OrganisationRole">eurio:OrganisationRole</a>
    /// </summary>
    let OrganisationRole = _prefixId.prefix "OrganisationRole"
    /// <summary>
    ///   <para>rdfs:label : Organisation Unit</para>
    ///   <para>rdfs:comment : A department or unit which is part of some larger Organization and only has full recognition within the context of that Organization. In CORDIS, it represents for instance the different departments of a university that participate in a particular project.</para>
    ///   <a href="http://data.europa.eu/s66#OrganisationUnit">eurio:OrganisationUnit</a>
    /// </summary>
    let OrganisationUnit = _prefixId.prefix "OrganisationUnit"
    /// <summary>
    ///   <para>rdfs:label : Postal Address</para>
    ///   <para>rdfs:comment : The postal address of entities that participate in or form part of research projects.</para>
    ///   <a href="http://data.europa.eu/s66#PostalAddress">eurio:PostalAddress</a>
    /// </summary>
    let PostalAddress = _prefixId.prefix "PostalAddress"
    /// <summary>
    ///   <para>rdfs:label : Procedings Paper</para>
    ///   <para>rdfs:comment : A paper, typically the realization of a research paper reporting original research findings, usually presented at a workshop and published within a workshop proceedings volume.</para>
    ///   <a href="http://data.europa.eu/s66#ProceedingsPaper">eurio:ProceedingsPaper</a>
    /// </summary>
    let ProceedingsPaper = _prefixId.prefix "ProceedingsPaper"
    /// <summary>
    ///   <para>rdfs:label : Project</para>
    ///   <para>rdfs:comment : A planned research work that has one or more objectives (divided or not into tasks) and is conducted by one or more organisations. In CORDIS, it represents a project funded by an EU programme.</para>
    ///   <a href="http://data.europa.eu/s66#Project">eurio:Project</a>
    /// </summary>
    let Project = _prefixId.prefix "Project"
    /// <summary>
    ///   <para>rdfs:label : Project Deliverable</para>
    ///   <para>rdfs:comment : A document referring to the results obtained during the development of a project.</para>
    ///   <a href="http://data.europa.eu/s66#ProjectDeliverable">eurio:ProjectDeliverable</a>
    /// </summary>
    let ProjectDeliverable = _prefixId.prefix "ProjectDeliverable"
    /// <summary>
    ///   <para>rdfs:comment : A scientific publication (e.g., journal article, conference paper, thesis dissertation, book, etc.) that resulted from the project activities.</para>
    ///   <para>rdfs:label : Project Publication</para>
    ///   <a href="http://data.europa.eu/s66#ProjectPublication">eurio:ProjectPublication</a>
    /// </summary>
    let ProjectPublication = _prefixId.prefix "ProjectPublication"
    /// <summary>
    ///   <para>rdfs:label : Project Report Summary</para>
    ///   <para>rdfs:comment : A document reporting on the progress of an on-going or completed project at a given period..</para>
    ///   <a href="http://data.europa.eu/s66#ProjectReportSummary">eurio:ProjectReportSummary</a>
    /// </summary>
    let ProjectReportSummary = _prefixId.prefix "ProjectReportSummary"
    /// <summary>
    ///   <para>rdfs:label : Public Body</para>
    ///   <para>rdfs:comment : Organisation or agency depending on a government, State or other supranational organisation and mainly operated by the government.</para>
    ///   <a href="http://data.europa.eu/s66#PublicBody">eurio:PublicBody</a>
    /// </summary>
    let PublicBody = _prefixId.prefix "PublicBody"
    /// <summary>
    ///   <para>rdfs:label : Research Organisation</para>
    ///   <para>rdfs:comment : Organisations devoted to research activities.</para>
    ///   <a href="http://data.europa.eu/s66#ResearchOrganisation">eurio:ResearchOrganisation</a>
    /// </summary>
    let ResearchOrganisation = _prefixId.prefix "ResearchOrganisation"
    /// <summary>
    ///   <para>rdfs:label : Result</para>
    ///   <para>rdfs:comment : Any tangible or intangible output of the project (such as data, knowledge and information, whatever their form or nature, whether or not they can be protected), which are generated in the project.</para>
    ///   <a href="http://data.europa.eu/s66#Result">eurio:Result</a>
    /// </summary>
    let Result = _prefixId.prefix "Result"
    /// <summary>
    ///   <para>rdfs:label : Role</para>
    ///   <para>rdfs:comment : The function assumed by or ascribed to an entity (typically an organisation) in a particular project. It can be used to precise or represent additional information about a relationship or property such as participation or membership. In CORDIS, it represents the participation of an organisation in a research project.</para>
    ///   <a href="http://data.europa.eu/s66#Role">eurio:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : SME</para>
    ///   <para>rdfs:comment : Small and Medium Enterprises.</para>
    ///   <a href="http://data.europa.eu/s66#SME">eurio:SME</a>
    /// </summary>
    let SME = _prefixId.prefix "SME"
    /// <summary>
    ///   <para>rdfs:comment : The physical extension of entities that participate in or form part of research projects.</para>
    ///   <para>rdfs:label : Site</para>
    ///   <a href="http://data.europa.eu/s66#Site">eurio:Site</a>
    /// </summary>
    let Site = _prefixId.prefix "Site"
    /// <summary>
    ///   <para>rdfs:label : Thesis Dissertation</para>
    ///   <para>rdfs:comment : A book authored by a student containing a formal presentations of research outputs submitted for examination in completion of a course of study at an institution of higher education, to fulfil the requirements for an academic degree. Also know as a dissertation.</para>
    ///   <a href="http://data.europa.eu/s66#ThesisDissertation">eurio:ThesisDissertation</a>
    /// </summary>
    let ThesisDissertation = _prefixId.prefix "ThesisDissertation"
    /// <summary>
    ///   <para>rdfs:label : Title Acronym</para>
    ///   <para>rdfs:comment : An acronym explicitly defined as the title or name of another entity (e.g. Project, Organisation, Funding Scheme, etc.).</para>
    ///   <a href="http://data.europa.eu/s66#TitleAcronym">eurio:TitleAcronym</a>
    /// </summary>
    let TitleAcronym = _prefixId.prefix "TitleAcronym"
    /// <summary>
    ///   <para>rdfs:label : abstract</para>
    ///   <para>rdfs:comment : The general summary and ideas of a CORDIS entity, e.g., project, result.</para>
    ///   <a href="http://data.europa.eu/s66#abstract">eurio:abstract</a>
    /// </summary>
    let abstract_ = _prefixId.prefix "abstract"
    /// <summary>
    ///   <para>rdfs:label : address country</para>
    ///   <para>rdfs:comment : The country of the place or address. You can also provide the two-letter ISO 3166-1 alpha-2 country code.</para>
    ///   <a href="http://data.europa.eu/s66#addressCountry">eurio:addressCountry</a>
    /// </summary>
    let addressCountry = _prefixId.prefix "addressCountry"
    /// <summary>
    ///   <para>rdfs:label : address locality</para>
    ///   <para>rdfs:comment : The locality, town or city of the place or address.</para>
    ///   <a href="http://data.europa.eu/s66#addressLocality">eurio:addressLocality</a>
    /// </summary>
    let addressLocality = _prefixId.prefix "addressLocality"
    /// <summary>
    ///   <para>rdfs:label : author</para>
    ///   <para>rdfs:comment : The list of authors.</para>
    ///   <a href="http://data.europa.eu/s66#author">eurio:author</a>
    /// </summary>
    let author = _prefixId.prefix "author"
    /// <summary>
    ///   <para>rdfs:label : code</para>
    ///   <para>rdfs:comment : A CORDA code.</para>
    ///   <a href="http://data.europa.eu/s66#code">eurio:code</a>
    /// </summary>
    let code = _prefixId.prefix "code"
    /// <summary>
    ///   <para>rdfs:label : currency</para>
    ///   <para>rdfs:comment : The currency in which the monetary amount is expressed.</para>
    ///   <a href="http://data.europa.eu/s66#currency">eurio:currency</a>
    /// </summary>
    let currency = _prefixId.prefix "currency"
    /// <summary>
    ///   <para>rdfs:label : date</para>
    ///   <para>rdfs:comment : The date in which the grant payment took place.</para>
    ///   <a href="http://data.europa.eu/s66#date">eurio:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>rdfs:label : definition</para>
    ///   <para>rdfs:comment : The definition of the acronym.</para>
    ///   <a href="http://data.europa.eu/s66#definition">eurio:definition</a>
    /// </summary>
    let definition = _prefixId.prefix "definition"
    /// <summary>
    ///   <para>rdfs:label : description</para>
    ///   <para>rdfs:comment : A brief summary of the entity (project, etc.).</para>
    ///   <a href="http://data.europa.eu/s66#description">eurio:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : disburses</para>
    ///   <para>rdfs:comment : Relates the funding agency to the grant(s) that it disburses.</para>
    ///   <a href="http://data.europa.eu/s66#disburses">eurio:disburses</a>
    /// </summary>
    let disburses = _prefixId.prefix "disburses"
    /// <summary>
    ///   <para>rdfs:label : doi</para>
    ///   <para>rdfs:comment : The digital object identifier of a publication.</para>
    ///   <a href="http://data.europa.eu/s66#doi">eurio:doi</a>
    /// </summary>
    let doi = _prefixId.prefix "doi"
    /// <summary>
    ///   <para>rdfs:label : duration</para>
    ///   <para>rdfs:comment : The period of time an entity (e.g. project, grant, etc.) has taken, represented as number of months.</para>
    ///   <a href="http://data.europa.eu/s66#duration">eurio:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    /// <summary>
    ///   <para>rdfs:label : end date</para>
    ///   <para>rdfs:comment : The date on which an entity (e.g. project, grant, etc.) is finalized or ceases to exist.</para>
    ///   <a href="http://data.europa.eu/s66#endDate">eurio:endDate</a>
    /// </summary>
    let endDate = _prefixId.prefix "endDate"
    /// <summary>
    ///   <para>rdfs:label : final results</para>
    ///   <para>rdfs:comment : A brief description of the project findings.</para>
    ///   <a href="http://data.europa.eu/s66#finalResults">eurio:finalResults</a>
    /// </summary>
    let finalResults = _prefixId.prefix "finalResults"
    /// <summary>
    ///   <para>rdfs:label : full address</para>
    ///   <para>rdfs:comment : The full address of a physical location of an entity.</para>
    ///   <a href="http://data.europa.eu/s66#fullAddress">eurio:fullAddress</a>
    /// </summary>
    let fullAddress = _prefixId.prefix "fullAddress"
    /// <summary>
    ///   <para>rdfs:label : funds</para>
    ///   <para>rdfs:comment : Relates the grant with the project(s) that are completely or partially funded by it.</para>
    ///   <a href="http://data.europa.eu/s66#funds">eurio:funds</a>
    /// </summary>
    let funds = _prefixId.prefix "funds"
    /// <summary>
    ///   <para>rdfs:label : has acronym</para>
    ///   <para>rdfs:comment : Relates an entity (e.g. project, grant, etc.) with its acronym(s). This includes acronyms representing the entity’s title as well as any additional acronyms extracted from other attributes of the entity.</para>
    ///   <a href="http://data.europa.eu/s66#hasAcronym">eurio:hasAcronym</a>
    /// </summary>
    let hasAcronym = _prefixId.prefix "hasAcronym"
    /// <summary>
    ///   <para>rdfs:label : has address</para>
    ///   <para>rdfs:comment : Relates a physical location to its registered address.</para>
    ///   <a href="http://data.europa.eu/s66#hasAddress">eurio:hasAddress</a>
    /// </summary>
    let hasAddress = _prefixId.prefix "hasAddress"
    /// <summary>
    ///   <para>rdfs:label : has associated funding scheme</para>
    ///   <para>rdfs:comment : Relates an entity other than funding scheme (e.g., result, etc.) with associated funding schemes.</para>
    ///   <a href="http://data.europa.eu/s66#hasAssociatedFundingScheme">eurio:hasAssociatedFundingScheme</a>
    /// </summary>
    let hasAssociatedFundingScheme = _prefixId.prefix "hasAssociatedFundingScheme"
    /// <summary>
    ///   <para>rdfs:label : has beneficiary</para>
    ///   <para>rdfs:comment : Relates the grant to the organisation role(s) that are a beneficiary of the grant. </para>
    ///   <a href="http://data.europa.eu/s66#hasBeneficiary">eurio:hasBeneficiary</a>
    /// </summary>
    let hasBeneficiary = _prefixId.prefix "hasBeneficiary"
    /// <summary>
    ///   <para>rdfs:label : has coordinates</para>
    ///   <para>rdfs:comment : The geo-coordinates of a place</para>
    ///   <a href="http://data.europa.eu/s66#hasCoordinates">eurio:hasCoordinates</a>
    /// </summary>
    let hasCoordinates = _prefixId.prefix "hasCoordinates"
    /// <summary>
    ///   <para>rdfs:label : has EU country code</para>
    ///   <para>rdfs:comment : The country code of the location or address according to the EU country codes.</para>
    ///   <a href="http://data.europa.eu/s66#hasEUCountryCode">eurio:hasEUCountryCode</a>
    /// </summary>
    let hasEUCountryCode = _prefixId.prefix "hasEUCountryCode"
    /// <summary>
    ///   <para>rdfs:label : has EuroSciVoc classification</para>
    ///   <para>rdfs:comment : One or more values from the EuroSciVoc taxonomy that represent the main fields of science of the project.</para>
    ///   <a href="http://data.europa.eu/s66#hasEuroSciVocClassification">eurio:hasEuroSciVocClassification</a>
    /// </summary>
    let hasEuroSciVocClassification = _prefixId.prefix "hasEuroSciVocClassification"
    /// <summary>
    ///   <para>rdfs:label : has funding amount</para>
    ///   <para>rdfs:comment : Relates the grant or funding scheme to the amount of money available for funding.</para>
    ///   <a href="http://data.europa.eu/s66#hasFundingAmount">eurio:hasFundingAmount</a>
    /// </summary>
    let hasFundingAmount = _prefixId.prefix "hasFundingAmount"
    /// <summary>
    ///   <para>rdfs:label : has funding scheme</para>
    ///   <para>rdfs:comment : Relates the grant to the funding scheme of which the grant forms a part.</para>
    ///   <a href="http://data.europa.eu/s66#hasFundingScheme">eurio:hasFundingScheme</a>
    /// </summary>
    let hasFundingScheme = _prefixId.prefix "hasFundingScheme"
    /// <summary>
    ///   <para>rdfs:label : has funding scheme call</para>
    ///   <para>rdfs:comment : Indicates the Call under which a project has been funded.</para>
    ///   <a href="http://data.europa.eu/s66#hasFundingSchemeCall">eurio:hasFundingSchemeCall</a>
    /// </summary>
    let hasFundingSchemeCall = _prefixId.prefix "hasFundingSchemeCall"
    /// <summary>
    ///   <para>rdfs:label : has funding scheme category</para>
    ///   <para>rdfs:comment : A list of terms specifying the different categories / types of funding schemes.</para>
    ///   <a href="http://data.europa.eu/s66#hasFundingSchemeCategory">eurio:hasFundingSchemeCategory</a>
    /// </summary>
    let hasFundingSchemeCategory = _prefixId.prefix "hasFundingSchemeCategory"
    /// <summary>
    ///   <para>rdfs:label : has funding scheme programme</para>
    ///   <para>rdfs:comment : Indicates the legal basis under which a project has been funded.</para>
    ///   <a href="http://data.europa.eu/s66#hasFundingSchemeProgramme">eurio:hasFundingSchemeProgramme</a>
    /// </summary>
    let hasFundingSchemeProgramme = _prefixId.prefix "hasFundingSchemeProgramme"
    /// <summary>
    ///   <para>rdfs:label : has funding scheme topic</para>
    ///   <para>rdfs:comment : Indicates the Topic under which a project has been funded.</para>
    ///   <a href="http://data.europa.eu/s66#hasFundingSchemeTopic">eurio:hasFundingSchemeTopic</a>
    /// </summary>
    let hasFundingSchemeTopic = _prefixId.prefix "hasFundingSchemeTopic"
    /// <summary>
    ///   <para>rdfs:label : has funding scheme type</para>
    ///   <para>rdfs:comment : Indicates the type of action under which a project has been funded.</para>
    ///   <a href="http://data.europa.eu/s66#hasFundingSchemeType">eurio:hasFundingSchemeType</a>
    /// </summary>
    let hasFundingSchemeType = _prefixId.prefix "hasFundingSchemeType"
    /// <summary>
    ///   <para>rdfs:label : has geographical location</para>
    ///   <para>rdfs:comment : The basic containment relation between a place and one that contains it</para>
    ///   <a href="http://data.europa.eu/s66#hasGeographicalLocation">eurio:hasGeographicalLocation</a>
    /// </summary>
    let hasGeographicalLocation = _prefixId.prefix "hasGeographicalLocation"
    /// <summary>
    ///   <para>rdfs:label : has grant</para>
    ///   <para>rdfs:comment : Relates a funding scheme with the grants that form part of it. </para>
    ///   <a href="http://data.europa.eu/s66#hasGrant">eurio:hasGrant</a>
    /// </summary>
    let hasGrant = _prefixId.prefix "hasGrant"
    /// <summary>
    ///   <para>rdfs:label : has ISO country code</para>
    ///   <para>rdfs:comment : The 2-digit ISO country code.</para>
    ///   <a href="http://data.europa.eu/s66#hasISOCountryCode">eurio:hasISOCountryCode</a>
    /// </summary>
    let hasISOCountryCode = _prefixId.prefix "hasISOCountryCode"
    /// <summary>
    ///   <para>rdfs:label : has involved party</para>
    ///   <para>rdfs:comment : Relates the Project to the roles that are involved in the project.</para>
    ///   <a href="http://data.europa.eu/s66#hasInvolvedParty">eurio:hasInvolvedParty</a>
    /// </summary>
    let hasInvolvedParty = _prefixId.prefix "hasInvolvedParty"
    /// <summary>
    ///   <para>rdfs:label : has NUTS 0 code</para>
    ///   <para>rdfs:comment : A value representing the NUTS-0 code of the place or address.</para>
    ///   <a href="http://data.europa.eu/s66#hasNUTS0code">eurio:hasNUTS0code</a>
    /// </summary>
    let hasNUTS0code = _prefixId.prefix "hasNUTS0code"
    /// <summary>
    ///   <para>rdfs:label : has NUTS 1 code</para>
    ///   <para>rdfs:comment : A value representing the NUTS-1 code of the place or address.</para>
    ///   <a href="http://data.europa.eu/s66#hasNUTS1code">eurio:hasNUTS1code</a>
    /// </summary>
    let hasNUTS1code = _prefixId.prefix "hasNUTS1code"
    /// <summary>
    ///   <para>rdfs:label : has NUTS 2 code</para>
    ///   <para>rdfs:comment : A value representing the NUTS-2 code of the place or address.</para>
    ///   <a href="http://data.europa.eu/s66#hasNUTS2code">eurio:hasNUTS2code</a>
    /// </summary>
    let hasNUTS2code = _prefixId.prefix "hasNUTS2code"
    /// <summary>
    ///   <para>rdfs:label : has NUTS 3 code</para>
    ///   <para>rdfs:comment : A value representing the NUTS-3 code of the place or address.</para>
    ///   <a href="http://data.europa.eu/s66#hasNUTS3code">eurio:hasNUTS3code</a>
    /// </summary>
    let hasNUTS3code = _prefixId.prefix "hasNUTS3code"
    /// <summary>
    ///   <para>rdfs:label : has NUTS code</para>
    ///   <para>rdfs:comment : A value representing the NUTS code of the place or address.</para>
    ///   <a href="http://data.europa.eu/s66#hasNUTSCode">eurio:hasNUTSCode</a>
    /// </summary>
    let hasNUTSCode = _prefixId.prefix "hasNUTSCode"
    /// <summary>
    ///   <para>rdfs:label : has next funding scheme</para>
    ///   <para>rdfs:comment : Relates a funding scheme with the next funding scheme.</para>
    ///   <a href="http://data.europa.eu/s66#hasNextFundingScheme">eurio:hasNextFundingScheme</a>
    /// </summary>
    let hasNextFundingScheme = _prefixId.prefix "hasNextFundingScheme"
    /// <summary>
    ///   <para>rdfs:label : has payment</para>
    ///   <para>rdfs:comment : Relates the grant to its payment(s).</para>
    ///   <a href="http://data.europa.eu/s66#hasPayment">eurio:hasPayment</a>
    /// </summary>
    let hasPayment = _prefixId.prefix "hasPayment"
    /// <summary>
    ///   <para>rdfs:label : has payment amount</para>
    ///   <para>rdfs:comment : Relates the payment to the amount of money that was given to the beneficiary of the payment.</para>
    ///   <a href="http://data.europa.eu/s66#hasPaymentAmount">eurio:hasPaymentAmount</a>
    /// </summary>
    let hasPaymentAmount = _prefixId.prefix "hasPaymentAmount"
    /// <summary>
    ///   <para>rdfs:label : has previous funding scheme</para>
    ///   <para>rdfs:comment : Relates a funding scheme with the previous funding scheme.</para>
    ///   <a href="http://data.europa.eu/s66#hasPreviousFundingScheme">eurio:hasPreviousFundingScheme</a>
    /// </summary>
    let hasPreviousFundingScheme = _prefixId.prefix "hasPreviousFundingScheme"
    /// <summary>
    ///   <para>rdfs:label : has recipient</para>
    ///   <para>rdfs:comment : Relates the grant payment to the organisation role(s) which have received the grant payment. Inverse property of isRecipientOf.</para>
    ///   <a href="http://data.europa.eu/s66#hasRecipient">eurio:hasRecipient</a>
    /// </summary>
    let hasRecipient = _prefixId.prefix "hasRecipient"
    /// <summary>
    ///   <para>rdfs:label : has related project</para>
    ///   <para>rdfs:comment : Represents a generic non parent-child relation between two CORDIS projects.</para>
    ///   <a href="http://data.europa.eu/s66#hasRelatedProject">eurio:hasRelatedProject</a>
    /// </summary>
    let hasRelatedProject = _prefixId.prefix "hasRelatedProject"
    /// <summary>
    ///   <para>rdfs:label : has related scheme</para>
    ///   <para>rdfs:comment : Represents a generic non parent-child relation between two funding schemes.</para>
    ///   <a href="http://data.europa.eu/s66#hasRelatedScheme">eurio:hasRelatedScheme</a>
    /// </summary>
    let hasRelatedScheme = _prefixId.prefix "hasRelatedScheme"
    /// <summary>
    ///   <para>rdfs:label : has result</para>
    ///   <para>rdfs:comment : Relates the project with its result(s).</para>
    ///   <a href="http://data.europa.eu/s66#hasResult">eurio:hasResult</a>
    /// </summary>
    let hasResult = _prefixId.prefix "hasResult"
    /// <summary>
    ///   <para>rdfs:label : has result type</para>
    ///   <para>rdfs:comment : A list of terms specifying the types of results that can have a project.</para>
    ///   <a href="http://data.europa.eu/s66#hasResultType">eurio:hasResultType</a>
    /// </summary>
    let hasResultType = _prefixId.prefix "hasResultType"
    /// <summary>
    ///   <para>rdfs:label : has role</para>
    ///   <para>rdfs:comment : Relates the organisation to the roles that the organisation takes.</para>
    ///   <a href="http://data.europa.eu/s66#hasRole">eurio:hasRole</a>
    /// </summary>
    let hasRole = _prefixId.prefix "hasRole"
    /// <summary>
    ///   <para>rdfs:label : has site</para>
    ///   <para>rdfs:comment : relates an organisation to its physical site</para>
    ///   <a href="http://data.europa.eu/s66#hasSite">eurio:hasSite</a>
    /// </summary>
    let hasSite = _prefixId.prefix "hasSite"
    /// <summary>
    ///   <para>rdfs:label : has sub-organisation</para>
    ///   <para>rdfs:comment : Relates the organisation with another organisation which is a sub-part or child of it.</para>
    ///   <a href="http://data.europa.eu/s66#hasSubOrganisation">eurio:hasSubOrganisation</a>
    /// </summary>
    let hasSubOrganisation = _prefixId.prefix "hasSubOrganisation"
    /// <summary>
    ///   <para>rdfs:label : has subscheme</para>
    ///   <para>rdfs:comment : Relates the funding scheme to its sub-schemes.</para>
    ///   <a href="http://data.europa.eu/s66#hasSubScheme">eurio:hasSubScheme</a>
    /// </summary>
    let hasSubScheme = _prefixId.prefix "hasSubScheme"
    /// <summary>
    ///   <para>rdfs:label : has total cost</para>
    ///   <para>rdfs:comment : Relates the project with the amount of money expected, required, or given in payment for the project.</para>
    ///   <a href="http://data.europa.eu/s66#hasTotalCost">eurio:hasTotalCost</a>
    /// </summary>
    let hasTotalCost = _prefixId.prefix "hasTotalCost"
    /// <summary>
    ///   <para>rdfs:label : has unit</para>
    ///   <para>rdfs:comment : Relates the organisation with a unit or department that forms part of the organisation.</para>
    ///   <a href="http://data.europa.eu/s66#hasUnit">eurio:hasUnit</a>
    /// </summary>
    let hasUnit = _prefixId.prefix "hasUnit"
    /// <summary>
    ///   <para>rdfs:label : identifier</para>
    ///   <para>rdfs:comment : The internal CORDA identifier.</para>
    ///   <a href="http://data.europa.eu/s66#identifier">eurio:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>rdfs:label : implements</para>
    ///   <para>rdfs:comment : Relates a funding agency to the funding schemes that it implements and administers.</para>
    ///   <a href="http://data.europa.eu/s66#implements">eurio:implements</a>
    /// </summary>
    let implements = _prefixId.prefix "implements"
    /// <summary>
    ///   <para>rdfs:label : is acronym of</para>
    ///   <para>rdfs:comment : Relates the acronym to the entity or entities to which it belongs.</para>
    ///   <a href="http://data.europa.eu/s66#isAcronymOf">eurio:isAcronymOf</a>
    /// </summary>
    let isAcronymOf = _prefixId.prefix "isAcronymOf"
    /// <summary>
    ///   <para>rdfs:label : is beneficiary of</para>
    ///   <para>rdfs:comment : Relates the role to the grant(s) of which the role is a beneficiary.</para>
    ///   <a href="http://data.europa.eu/s66#isBeneficiaryOf">eurio:isBeneficiaryOf</a>
    /// </summary>
    let isBeneficiaryOf = _prefixId.prefix "isBeneficiaryOf"
    /// <summary>
    ///   <para>rdfs:label : is disbursed by</para>
    ///   <para>rdfs:comment : Relates the grant to the funding agency that disburses the grant.</para>
    ///   <a href="http://data.europa.eu/s66#isDisbursedBy">eurio:isDisbursedBy</a>
    /// </summary>
    let isDisbursedBy = _prefixId.prefix "isDisbursedBy"
    /// <summary>
    ///   <para>rdfs:label : is funded by</para>
    ///   <para>rdfs:comment : Relates the project with the grant(s) that completely or partially fund the project.</para>
    ///   <a href="http://data.europa.eu/s66#isFundedBy">eurio:isFundedBy</a>
    /// </summary>
    let isFundedBy = _prefixId.prefix "isFundedBy"
    /// <summary>
    ///   <para>rdfs:label : is implemented by</para>
    ///   <para>rdfs:comment : Relates the funding scheme with the funding agency that implements and administers the scheme.</para>
    ///   <a href="http://data.europa.eu/s66#isImplementedBy">eurio:isImplementedBy</a>
    /// </summary>
    let isImplementedBy = _prefixId.prefix "isImplementedBy"
    /// <summary>
    ///   <para>rdfs:label : is involved in</para>
    ///   <para>rdfs:comment : Relates the role to the Project in which it is involved.</para>
    ///   <a href="http://data.europa.eu/s66#isInvolvedIn">eurio:isInvolvedIn</a>
    /// </summary>
    let isInvolvedIn = _prefixId.prefix "isInvolvedIn"
    /// <summary>
    ///   <para>rdfs:label : is payment of</para>
    ///   <para>rdfs:comment : Relates a payment to the grant of which it is a part.</para>
    ///   <a href="http://data.europa.eu/s66#isPaymentOf">eurio:isPaymentOf</a>
    /// </summary>
    let isPaymentOf = _prefixId.prefix "isPaymentOf"
    /// <summary>
    ///   <para>rdfs:label : is recipient of</para>
    ///   <para>rdfs:comment : Relates the organisation role with the grant payment(s) which they have received. Inverse property of hasRecipient.</para>
    ///   <a href="http://data.europa.eu/s66#isRecipientOf">eurio:isRecipientOf</a>
    /// </summary>
    let isRecipientOf = _prefixId.prefix "isRecipientOf"
    /// <summary>
    ///   <para>rdfs:label : is result of</para>
    ///   <para>rdfs:comment : Relates the results with the Project(s) involved.</para>
    ///   <a href="http://data.europa.eu/s66#isResultOf">eurio:isResultOf</a>
    /// </summary>
    let isResultOf = _prefixId.prefix "isResultOf"
    /// <summary>
    ///   <para>rdfs:label : is role of</para>
    ///   <para>rdfs:comment : Relates the organisation role to the organisation which assumes the role.</para>
    ///   <a href="http://data.europa.eu/s66#isRoleOf">eurio:isRoleOf</a>
    /// </summary>
    let isRoleOf = _prefixId.prefix "isRoleOf"
    /// <summary>
    ///   <para>rdfs:label : is site of</para>
    ///   <para>rdfs:comment : Indicates an entity which has presence at the given site</para>
    ///   <a href="http://data.europa.eu/s66#isSiteOf">eurio:isSiteOf</a>
    /// </summary>
    let isSiteOf = _prefixId.prefix "isSiteOf"
    /// <summary>
    ///   <para>rdfs:label : is sub-organisation of</para>
    ///   <para>rdfs:comment : Relates the organisation with another organisation of which it is a sub-part.</para>
    ///   <a href="http://data.europa.eu/s66#isSubOrganisationOf">eurio:isSubOrganisationOf</a>
    /// </summary>
    let isSubOrganisationOf = _prefixId.prefix "isSubOrganisationOf"
    /// <summary>
    ///   <para>rdfs:label : is subscheme of</para>
    ///   <para>rdfs:comment : Relates the funding scheme to its parent scheme of which this funding scheme forms a part. </para>
    ///   <a href="http://data.europa.eu/s66#isSubSchemeOf">eurio:isSubSchemeOf</a>
    /// </summary>
    let isSubSchemeOf = _prefixId.prefix "isSubSchemeOf"
    /// <summary>
    ///   <para>rdfs:label : is unit of</para>
    ///   <para>rdfs:comment : Relates the unit to the organisation of which the unit forms a part. </para>
    ///   <a href="http://data.europa.eu/s66#isUnitOf">eurio:isUnitOf</a>
    /// </summary>
    let isUnitOf = _prefixId.prefix "isUnitOf"
    /// <summary>
    ///   <para>rdfs:label : isbn</para>
    ///   <para>rdfs:comment : The international standard book number of book publications.</para>
    ///   <a href="http://data.europa.eu/s66#isbn">eurio:isbn</a>
    /// </summary>
    let isbn = _prefixId.prefix "isbn"
    /// <summary>
    ///   <para>rdfs:label : issn</para>
    ///   <para>rdfs:comment : The international standard serial number of journal publications.</para>
    ///   <a href="http://data.europa.eu/s66#issn">eurio:issn</a>
    /// </summary>
    let issn = _prefixId.prefix "issn"
    /// <summary>
    ///   <para>rdfs:label : journal number</para>
    ///   <para>rdfs:comment : The journal number of a published result.</para>
    ///   <a href="http://data.europa.eu/s66#journalNumber">eurio:journalNumber</a>
    /// </summary>
    let journalNumber = _prefixId.prefix "journalNumber"
    /// <summary>
    ///   <para>rdfs:label : journal title</para>
    ///   <para>rdfs:comment : The title of the journal of a published result.</para>
    ///   <a href="http://data.europa.eu/s66#journalTitle">eurio:journalTitle</a>
    /// </summary>
    let journalTitle = _prefixId.prefix "journalTitle"
    /// <summary>
    ///   <para>rdfs:label : keyword</para>
    ///   <para>rdfs:comment : Word or words that represent the main idea of a referred entity (e.g., project. project result, etc.)</para>
    ///   <a href="http://data.europa.eu/s66#keyword">eurio:keyword</a>
    /// </summary>
    let keyword = _prefixId.prefix "keyword"
    /// <summary>
    ///   <para>rdfs:label : language</para>
    ///   <para>rdfs:comment : The language used in a project result.</para>
    ///   <a href="http://data.europa.eu/s66#language">eurio:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>rdfs:label : latitude</para>
    ///   <para>rdfs:comment : The latitude of a location. For example 37.42242 (WGS 84).</para>
    ///   <a href="http://data.europa.eu/s66#latitude">eurio:latitude</a>
    /// </summary>
    let latitude = _prefixId.prefix "latitude"
    /// <summary>
    ///   <para>rdfs:label : legal name</para>
    ///   <para>rdfs:comment : The official name of the organization, e.g. the registered company name.</para>
    ///   <a href="http://data.europa.eu/s66#legalName">eurio:legalName</a>
    /// </summary>
    let legalName = _prefixId.prefix "legalName"
    /// <summary>
    ///   <para>rdfs:label : longitude</para>
    ///   <para>rdfs:comment : The longitude of a location. For example -122.08585 (WGS 84).</para>
    ///   <a href="http://data.europa.eu/s66#longitude">eurio:longitude</a>
    /// </summary>
    let longitude = _prefixId.prefix "longitude"
    /// <summary>
    ///   <para>rdfs:label : name</para>
    ///   <para>rdfs:comment : The name of an entity</para>
    ///   <a href="http://data.europa.eu/s66#name">eurio:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    let order = _prefixId.prefix "order"
    /// <summary>
    ///   <para>rdfs:label : period from</para>
    ///   <para>rdfs:comment : The date that the reporting period started.</para>
    ///   <a href="http://data.europa.eu/s66#periodFrom">eurio:periodFrom</a>
    /// </summary>
    let periodFrom = _prefixId.prefix "periodFrom"
    /// <summary>
    ///   <para>rdfs:label : period number</para>
    ///   <para>rdfs:comment : The number of the reporting period.</para>
    ///   <a href="http://data.europa.eu/s66#periodNumber">eurio:periodNumber</a>
    /// </summary>
    let periodNumber = _prefixId.prefix "periodNumber"
    /// <summary>
    ///   <para>rdfs:label : period to</para>
    ///   <para>rdfs:comment : The date that the reporting period ended.</para>
    ///   <a href="http://data.europa.eu/s66#periodTo">eurio:periodTo</a>
    /// </summary>
    let periodTo = _prefixId.prefix "periodTo"
    /// <summary>
    ///   <para>rdfs:label : post office box number</para>
    ///   <para>rdfs:comment : The post office box number for PO box addresses.</para>
    ///   <a href="http://data.europa.eu/s66#postOfficeBoxNumber">eurio:postOfficeBoxNumber</a>
    /// </summary>
    let postOfficeBoxNumber = _prefixId.prefix "postOfficeBoxNumber"
    /// <summary>
    ///   <para>rdfs:label : postal code</para>
    ///   <para>rdfs:comment : The postal code of the place or address.</para>
    ///   <a href="http://data.europa.eu/s66#postalCode">eurio:postalCode</a>
    /// </summary>
    let postalCode = _prefixId.prefix "postalCode"
    /// <summary>
    ///   <para>rdfs:label : project status</para>
    ///   <para>rdfs:comment : The current status (signed, ongoing, terminated, etc.) of the project.</para>
    ///   <a href="http://data.europa.eu/s66#projectStatus">eurio:projectStatus</a>
    /// </summary>
    let projectStatus = _prefixId.prefix "projectStatus"
    /// <summary>
    ///   <para>rdfs:label : published pages</para>
    ///   <para>rdfs:comment : The pages of a published result.</para>
    ///   <a href="http://data.europa.eu/s66#publishedPages">eurio:publishedPages</a>
    /// </summary>
    let publishedPages = _prefixId.prefix "publishedPages"
    /// <summary>
    ///   <para>rdfs:label : published year</para>
    ///   <para>rdfs:comment : The year of publication.</para>
    ///   <a href="http://data.europa.eu/s66#publishedYear">eurio:publishedYear</a>
    /// </summary>
    let publishedYear = _prefixId.prefix "publishedYear"
    /// <summary>
    ///   <para>rdfs:label : publisher</para>
    ///   <para>rdfs:comment : Represents the publishing body of a published result.</para>
    ///   <a href="http://data.europa.eu/s66#publisher">eurio:publisher</a>
    /// </summary>
    let publisher = _prefixId.prefix "publisher"
    /// <summary>
    ///   <para>rdfs:label : rcn</para>
    ///   <para>rdfs:comment : Internal CORDIS identifier used for the identification of the domain entities (e.g., projects, project results, organisations, funding schemes, etc.). Stands for Resource Control Number.</para>
    ///   <a href="http://data.europa.eu/s66#rcn">eurio:rcn</a>
    /// </summary>
    let rcn = _prefixId.prefix "rcn"
    /// <summary>
    ///   <para>rdfs:label : refers to</para>
    ///   <para>rdfs:comment : The entity to which this acronym refers. This can either be an entity inside of the knowledge graph or an external entity of any type.</para>
    ///   <a href="http://data.europa.eu/s66#refersTo">eurio:refersTo</a>
    /// </summary>
    let refersTo = _prefixId.prefix "refersTo"
    /// <summary>
    ///   <para>rdfs:label : role label</para>
    ///   <para>rdfs:comment : Title for capturing the role of an organisation.</para>
    ///   <a href="http://data.europa.eu/s66#roleLabel">eurio:roleLabel</a>
    /// </summary>
    let roleLabel = _prefixId.prefix "roleLabel"
    /// <summary>
    ///   <para>rdfs:label : short form</para>
    ///   <para>rdfs:comment : The value of the acronym.</para>
    ///   <a href="http://data.europa.eu/s66#shortForm">eurio:shortForm</a>
    /// </summary>
    let shortForm = _prefixId.prefix "shortForm"
    /// <summary>
    ///   <para>rdfs:label : signature date</para>
    ///   <para>rdfs:comment : The day a grant agreement has been signed.</para>
    ///   <a href="http://data.europa.eu/s66#signatureDate">eurio:signatureDate</a>
    /// </summary>
    let signatureDate = _prefixId.prefix "signatureDate"
    /// <summary>
    ///   <para>rdfs:label : start date</para>
    ///   <para>rdfs:comment : The time an entity (e.g. project, grant, etc.) is initialized or starts to take effect.</para>
    ///   <a href="http://data.europa.eu/s66#startDate">eurio:startDate</a>
    /// </summary>
    let startDate = _prefixId.prefix "startDate"
    /// <summary>
    ///   <para>rdfs:label : street address</para>
    ///   <para>rdfs:comment : The street name and number of the place or address.</para>
    ///   <a href="http://data.europa.eu/s66#streetAddress">eurio:streetAddress</a>
    /// </summary>
    let streetAddress = _prefixId.prefix "streetAddress"
    /// <summary>
    ///   <para>rdfs:label : termination date</para>
    ///   <para>rdfs:comment : The termination date of a project.</para>
    ///   <a href="http://data.europa.eu/s66#terminationDate">eurio:terminationDate</a>
    /// </summary>
    let terminationDate = _prefixId.prefix "terminationDate"
    /// <summary>
    ///   <para>rdfs:label : title</para>
    ///   <para>rdfs:comment : The entity’s (e.g. project, work package, etc.) official name or title.</para>
    ///   <a href="http://data.europa.eu/s66#title">eurio:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : URL</para>
    ///   <para>rdfs:comment : A URL that links internet resources related to a CORDIS entity.</para>
    ///   <a href="http://data.europa.eu/s66#url">eurio:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
    /// <summary>
    ///   <para>rdfs:label : value</para>
    ///   <para>rdfs:comment : The value of amount being expressed.</para>
    ///   <a href="http://data.europa.eu/s66#value">eurio:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
    /// <summary>
    ///   <para>rdfs:label : VAT number</para>
    ///   <para>rdfs:comment : The unique number that identifies a taxable organisation or non-taxable legal entity that is registered for VAT.</para>
    ///   <a href="http://data.europa.eu/s66#vatNumber">eurio:vatNumber</a>
    /// </summary>
    let vatNumber = _prefixId.prefix "vatNumber"
    /// <summary>
    ///   <para>rdfs:label : work performed</para>
    ///   <para>rdfs:comment : A summary of the work carried out during the development of the project.</para>
    ///   <a href="http://data.europa.eu/s66#workPerformed">eurio:workPerformed</a>
    /// </summary>
    let workPerformed = _prefixId.prefix "workPerformed"
