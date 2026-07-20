namespace http.data.europa.eu.s66.hash

open DoxAletheia

module eurio =
    let _namespace_name = "http://data.europa.eu/s66#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A document referring to the results obtained during the development of a project.
    /// <see href="http://data.europa.eu/s66#ProjectDeliverable"></see></summary>
    let ProjectDeliverable = _prefix "ProjectDeliverable"
    /// <summary>
    /// A scientific publication (e.g., journal article, conference paper, thesis dissertation, book, etc.) that resulted from the project activities.
    /// <see href="http://data.europa.eu/s66#ProjectPublication"></see></summary>
    let ProjectPublication = _prefix "ProjectPublication"
    /// <summary>
    /// A document reporting on the progress of an on-going or completed project at a given period..
    /// <see href="http://data.europa.eu/s66#ProjectReportSummary"></see></summary>
    let ProjectReportSummary = _prefix "ProjectReportSummary"
    /// <summary>
    /// A for profit entity
    /// <see href="http://data.europa.eu/s66#ForProfitOrganisation"></see></summary>
    let ForProfitOrganisation = _prefix "ForProfitOrganisation"
    /// <summary>
    /// An organisation that materially administrates funding schemes and disburses related grants. In the context of CORDIS, it represents the various European agencies responsible for funding research projects (e.g. ERC, EASME, REA, etc.).
    /// <see href="http://data.europa.eu/s66#FundingAgency"></see></summary>
    let FundingAgency = _prefix "FundingAgency"
    /// <summary>
    /// Institution that provides education.
    /// <see href="http://data.europa.eu/s66#HigherOrSecondaryEducation"></see></summary>
    let HigherOrSecondaryEducation = _prefix "HigherOrSecondaryEducation"
    /// <summary>
    /// Organisation or agency depending on a government, State or other supranational organisation and mainly operated by the government.
    /// <see href="http://data.europa.eu/s66#PublicBody"></see></summary>
    let PublicBody = _prefix "PublicBody"
    /// <summary>
    /// Organisations devoted to research activities.
    /// <see href="http://data.europa.eu/s66#ResearchOrganisation"></see></summary>
    let ResearchOrganisation = _prefix "ResearchOrganisation"
    /// <summary>
    /// Small and Medium Enterprises.
    /// <see href="http://data.europa.eu/s66#SME"></see></summary>
    let SME = _prefix "SME"
    /// <summary>
    /// An article, typically the realization of a research paper reporting original research findings, published in a journal issue.
    /// <see href="http://data.europa.eu/s66#JournalPaper"></see></summary>
    let JournalPaper = _prefix "JournalPaper"
    /// <summary>
    /// A paper, typically the realization of a research paper reporting original research findings, usually presented at a workshop and published within a workshop proceedings volume.
    /// <see href="http://data.europa.eu/s66#ProceedingsPaper"></see></summary>
    let ProceedingsPaper = _prefix "ProceedingsPaper"
    /// <summary>
    /// An abbreviation formed from the initial letters of other words and pronounced as a word. It can refer to any type of entities in the CORDIS conceptual framework, and may be stated explicitly or extracted automatically from text.
    /// <see href="http://data.europa.eu/s66#Acronym"></see></summary>
    let Acronym = _prefix "Acronym"
    /// <summary>
    /// The value of the acronym.
    /// <see href="http://data.europa.eu/s66#shortForm"></see></summary>
    let shortForm = _prefix "shortForm"
    /// <summary>
    /// The definition of the acronym.
    /// <see href="http://data.europa.eu/s66#definition"></see></summary>
    let definition = _prefix "definition"
    /// <summary>
    /// An administrative geographical area that is typically managed by a public body. It can be a country, a region, a municipality, a province, a sub-municipality area, etc.
    /// <see href="http://data.europa.eu/s66#AdministrativeArea"></see></summary>
    let AdministrativeArea = _prefix "AdministrativeArea"
    /// <summary>
    /// The name of an entity
    /// <see href="http://data.europa.eu/s66#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// A non-serial document that is complete in one volume or a designated finite number of volumes. A book published by a publisher is usually identified by an International Standard Book Number (ISBN), and may be manifested as a physical printed publication on paper bound in a hard or soft cover, or in electronic format as an 'e-book'.
    /// <see href="http://data.europa.eu/s66#Book"></see></summary>
    let Book = _prefix "Book"
    /// <summary>
    /// The geo coordinates for a location of entities that participate in or form part of research projects.
    /// <see href="http://data.europa.eu/s66#Coordinates"></see></summary>
    let Coordinates = _prefix "Coordinates"
    /// <summary>
    /// The longitude of a location. For example -122.08585 (WGS 84).
    /// <see href="http://data.europa.eu/s66#longitude"></see></summary>
    let longitude = _prefix "longitude"
    /// <summary>
    /// The latitude of a location. For example 37.42242 (WGS 84).
    /// <see href="http://data.europa.eu/s66#latitude"></see></summary>
    let latitude = _prefix "latitude"
    /// <summary>
    /// A country
    /// <see href="http://data.europa.eu/s66#Country"></see></summary>
    let Country = _prefix "Country"
    /// <summary>
    /// The country code of the location or address according to the EU country codes.
    /// <see href="http://data.europa.eu/s66#hasEUCountryCode"></see></summary>
    let hasEUCountryCode = _prefix "hasEUCountryCode"
    /// <summary>
    /// Any acronym that has been detected, automatically or manually, from the description of an entity or from any other form of natural language text.
    /// <see href="http://data.europa.eu/s66#DetectedAcronym"></see></summary>
    let DetectedAcronym = _prefix "DetectedAcronym"
    /// <summary>
    /// An acronym explicitly defined as the title or name of another entity (e.g. Project, Organisation, Funding Scheme, etc.).
    /// <see href="http://data.europa.eu/s66#TitleAcronym"></see></summary>
    let TitleAcronym = _prefix "TitleAcronym"
    /// <summary>
    /// Represents a group of people, with the same purpose, organized together into a community or other social, commercial or political structure that participate in CORDIS projects.
    /// <see href="http://data.europa.eu/s66#Organisation"></see></summary>
    let Organisation = _prefix "Organisation"
    /// <summary>
    /// Set of rules and conditions which forms the basis for public funding of European research. In CORDIS, they represent the different legal frameworks (e.g. FP6, FP7, H2020). They can also be used to represent the different calls inside each framework by using the recursive relation “partOfScheme”.
    /// <see href="http://data.europa.eu/s66#FundingScheme"></see></summary>
    let FundingScheme = _prefix "FundingScheme"
    /// <summary>
    /// Relates the funding scheme with the funding agency that implements and administers the scheme.
    /// <see href="http://data.europa.eu/s66#isImplementedBy"></see></summary>
    let isImplementedBy = _prefix "isImplementedBy"
    /// <summary>
    /// The period of time an entity (e.g. project, grant, etc.) has taken, represented as number of months.
    /// <see href="http://data.europa.eu/s66#duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    /// A URL that links internet resources related to a CORDIS entity.
    /// <see href="http://data.europa.eu/s66#url"></see></summary>
    let url = _prefix "url"
    /// <summary>
    /// A list of terms specifying the different categories / types of funding schemes.
    /// <see href="http://data.europa.eu/s66#hasFundingSchemeCategory"></see></summary>
    let hasFundingSchemeCategory = _prefix "hasFundingSchemeCategory"
    /// <summary>
    /// The entity’s (e.g. project, work package, etc.) official name or title.
    /// <see href="http://data.europa.eu/s66#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// A disbursed fund paid to a recipient or beneficiary within the context of a funded research project. In the context of CORDIS, it represents a grant of a specific EU programme (e.g. an H2020 grant).
    /// <see href="http://data.europa.eu/s66#Grant"></see></summary>
    let Grant = _prefix "Grant"
    /// <summary>
    /// The time an entity (e.g. project, grant, etc.) is initialized or starts to take effect.
    /// <see href="http://data.europa.eu/s66#startDate"></see></summary>
    let startDate = _prefix "startDate"
    /// <summary>
    /// Relates the grant to the organisation role(s) that are a beneficiary of the grant.
    /// <see href="http://data.europa.eu/s66#hasBeneficiary"></see></summary>
    let hasBeneficiary = _prefix "hasBeneficiary"
    /// <summary>
    /// Relates the grant to the funding agency that disburses the grant.
    /// <see href="http://data.europa.eu/s66#isDisbursedBy"></see></summary>
    let isDisbursedBy = _prefix "isDisbursedBy"
    /// <summary>
    /// Relates the grant or funding scheme to the amount of money available for funding.
    /// <see href="http://data.europa.eu/s66#hasFundingAmount"></see></summary>
    let hasFundingAmount = _prefix "hasFundingAmount"
    /// <summary>
    /// The date on which an entity (e.g. project, grant, etc.) is finalized or ceases to exist.
    /// <see href="http://data.europa.eu/s66#endDate"></see></summary>
    let endDate = _prefix "endDate"
    /// <summary>
    /// Relates the grant to the funding scheme of which the grant forms a part.
    /// <see href="http://data.europa.eu/s66#hasFundingScheme"></see></summary>
    let hasFundingScheme = _prefix "hasFundingScheme"
    /// <summary>
    /// Relates the grant with the project(s) that are completely or partially funded by it.
    /// <see href="http://data.europa.eu/s66#funds"></see></summary>
    let funds = _prefix "funds"
    /// <summary>
    /// Relates the grant to its payment(s).
    /// <see href="http://data.europa.eu/s66#hasPayment"></see></summary>
    let hasPayment = _prefix "hasPayment"
    /// <summary>
    /// A single payment to a recipient or beneficiary of a Grant within a research project.
    /// <see href="http://data.europa.eu/s66#GrantPayment"></see></summary>
    let GrantPayment = _prefix "GrantPayment"
    /// <summary>
    /// Relates the payment to the amount of money that was given to the beneficiary of the payment.
    /// <see href="http://data.europa.eu/s66#hasPaymentAmount"></see></summary>
    let hasPaymentAmount = _prefix "hasPaymentAmount"
    /// <summary>
    /// A monetary value or range. This type can be used to describe an amount of money such as $50 USD, or a range as in describing a bank account being suitable for a balance between £1,000 and £1,000,000 GBP, or the value of a salary, etc.
    /// <see href="http://data.europa.eu/s66#MonetaryAmount"></see></summary>
    let MonetaryAmount = _prefix "MonetaryAmount"
    /// <summary>
    /// The value of amount being expressed.
    /// <see href="http://data.europa.eu/s66#value"></see></summary>
    let value = _prefix "value"
    /// <summary>
    /// A work that hasn't undergone peer reviewing prior to its publication.
    /// <see href="http://data.europa.eu/s66#NonPeerReviewedPublication"></see></summary>
    let NonPeerReviewedPublication = _prefix "NonPeerReviewedPublication"
    /// <summary>
    /// The internal CORDA identifier.
    /// <see href="http://data.europa.eu/s66#identifier"></see></summary>
    let identifier = _prefix "identifier"
    /// <summary>
    /// Function assumed by or ascribed to an organisation that takes part in a particular project. In CORDIs, it represents roles such as coordinator, partner, consortium member, etc.
    /// <see href="http://data.europa.eu/s66#OrganisationRole"></see></summary>
    let OrganisationRole = _prefix "OrganisationRole"
    /// <summary>
    /// Relates the organisation to the roles that the organisation takes.
    /// <see href="http://data.europa.eu/s66#hasRole"></see></summary>
    let hasRole = _prefix "hasRole"
    /// <summary>
    /// The unique number that identifies a taxable organisation or non-taxable legal entity that is registered for VAT.
    /// <see href="http://data.europa.eu/s66#vatNumber"></see></summary>
    let vatNumber = _prefix "vatNumber"
    /// <summary>
    /// Internal CORDIS identifier used for the identification of the domain entities (e.g., projects, project results, organisations, funding schemes, etc.). Stands for Resource Control Number.
    /// <see href="http://data.europa.eu/s66#rcn"></see></summary>
    let rcn = _prefix "rcn"
    /// <summary>
    /// relates an organisation to its physical site
    /// <see href="http://data.europa.eu/s66#hasSite"></see></summary>
    let hasSite = _prefix "hasSite"
    /// <summary>
    /// The official name of the organization, e.g. the registered company name.
    /// <see href="http://data.europa.eu/s66#legalName"></see></summary>
    let legalName = _prefix "legalName"
    /// <summary>
    /// Relates the organisation role to the organisation which assumes the role.
    /// <see href="http://data.europa.eu/s66#isRoleOf"></see></summary>
    let isRoleOf = _prefix "isRoleOf"
    /// <summary>
    /// The function assumed by or ascribed to an entity (typically an organisation) in a particular project. It can be used to precise or represent additional information about a relationship or property such as participation or membership. In CORDIS, it represents the participation of an organisation in a research project.
    /// <see href="http://data.europa.eu/s66#Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// A department or unit which is part of some larger Organization and only has full recognition within the context of that Organization. In CORDIS, it represents for instance the different departments of a university that participate in a particular project.
    /// <see href="http://data.europa.eu/s66#OrganisationUnit"></see></summary>
    let OrganisationUnit = _prefix "OrganisationUnit"
    /// <summary>
    /// The postal address of entities that participate in or form part of research projects.
    /// <see href="http://data.europa.eu/s66#PostalAddress"></see></summary>
    let PostalAddress = _prefix "PostalAddress"
    /// <summary>
    /// The postal code of the place or address.
    /// <see href="http://data.europa.eu/s66#postalCode"></see></summary>
    let postalCode = _prefix "postalCode"
    /// <summary>
    /// The street name and number of the place or address.
    /// <see href="http://data.europa.eu/s66#streetAddress"></see></summary>
    let streetAddress = _prefix "streetAddress"
    /// <summary>
    /// The country of the place or address. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
    /// <see href="http://data.europa.eu/s66#addressCountry"></see></summary>
    let addressCountry = _prefix "addressCountry"
    /// <summary>
    /// The full address of a physical location of an entity.
    /// <see href="http://data.europa.eu/s66#fullAddress"></see></summary>
    let fullAddress = _prefix "fullAddress"
    /// <summary>
    /// The locality, town or city of the place or address.
    /// <see href="http://data.europa.eu/s66#addressLocality"></see></summary>
    let addressLocality = _prefix "addressLocality"
    /// <summary>
    /// A planned research work that has one or more objectives (divided or not into tasks) and is conducted by one or more organisations. In CORDIS, it represents a project funded by an EU programme.
    /// <see href="http://data.europa.eu/s66#Project"></see></summary>
    let Project = _prefix "Project"
    /// <summary>
    /// The general summary and ideas of a CORDIS entity, e.g., project, result.
    /// <see href="http://data.europa.eu/s66#abstract"></see></summary>
    let abstract_ = _prefix "abstract"
    /// <summary>
    /// Relates the project with the grant(s) that completely or partially fund the project.
    /// <see href="http://data.europa.eu/s66#isFundedBy"></see></summary>
    let isFundedBy = _prefix "isFundedBy"
    /// <summary>
    /// Relates the project with the amount of money expected, required, or given in payment for the project.
    /// <see href="http://data.europa.eu/s66#hasTotalCost"></see></summary>
    let hasTotalCost = _prefix "hasTotalCost"
    /// <summary>
    /// The digital object identifier of a publication.
    /// <see href="http://data.europa.eu/s66#doi"></see></summary>
    let doi = _prefix "doi"
    /// <summary>
    /// The day a grant agreement has been signed.
    /// <see href="http://data.europa.eu/s66#signatureDate"></see></summary>
    let signatureDate = _prefix "signatureDate"
    /// <summary>
    /// Relates the Project to the roles that are involved in the project.
    /// <see href="http://data.europa.eu/s66#hasInvolvedParty"></see></summary>
    let hasInvolvedParty = _prefix "hasInvolvedParty"
    /// <summary>
    /// The current status (signed, ongoing, terminated, etc.) of the project.
    /// <see href="http://data.europa.eu/s66#projectStatus"></see></summary>
    let projectStatus = _prefix "projectStatus"
    /// <summary>
    /// A brief summary of the entity (project, etc.).
    /// <see href="http://data.europa.eu/s66#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// A list of terms specifying the types of results that can have a project.
    /// <see href="http://data.europa.eu/s66#hasResultType"></see></summary>
    let hasResultType = _prefix "hasResultType"
    /// <summary>
    /// Any tangible or intangible output of the project (such as data, knowledge and information, whatever their form or nature, whether or not they can be protected), which are generated in the project.
    /// <see href="http://data.europa.eu/s66#Result"></see></summary>
    let Result = _prefix "Result"
    /// <summary>
    /// The journal number of a published result.
    /// <see href="http://data.europa.eu/s66#journalNumber"></see></summary>
    let journalNumber = _prefix "journalNumber"
    /// <summary>
    /// Represents the publishing body of a published result.
    /// <see href="http://data.europa.eu/s66#publisher"></see></summary>
    let publisher = _prefix "publisher"
    /// <summary>
    /// The year of publication.
    /// <see href="http://data.europa.eu/s66#publishedYear"></see></summary>
    let publishedYear = _prefix "publishedYear"
    /// <summary>
    /// The title of the journal of a published result.
    /// <see href="http://data.europa.eu/s66#journalTitle"></see></summary>
    let journalTitle = _prefix "journalTitle"
    /// <summary>
    /// The list of authors.
    /// <see href="http://data.europa.eu/s66#author"></see></summary>
    let author = _prefix "author"
    /// <summary>
    /// The pages of a published result.
    /// <see href="http://data.europa.eu/s66#publishedPages"></see></summary>
    let publishedPages = _prefix "publishedPages"
    /// <summary>
    /// A brief description of the project findings.
    /// <see href="http://data.europa.eu/s66#finalResults"></see></summary>
    let finalResults = _prefix "finalResults"
    /// <summary>
    /// A summary of the work carried out during the development of the project.
    /// <see href="http://data.europa.eu/s66#workPerformed"></see></summary>
    let workPerformed = _prefix "workPerformed"
    /// <summary>
    /// The language used in a project result.
    /// <see href="http://data.europa.eu/s66#language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// Title for capturing the role of an organisation.
    /// <see href="http://data.europa.eu/s66#roleLabel"></see></summary>
    let roleLabel = _prefix "roleLabel"
    /// <summary>
    /// Relates the role to the Project in which it is involved.
    /// <see href="http://data.europa.eu/s66#isInvolvedIn"></see></summary>
    let isInvolvedIn = _prefix "isInvolvedIn"
    /// <summary>
    /// The physical extension of entities that participate in or form part of research projects.
    /// <see href="http://data.europa.eu/s66#Site"></see></summary>
    let Site = _prefix "Site"
    /// <summary>
    /// Relates a physical location to its registered address.
    /// <see href="http://data.europa.eu/s66#hasAddress"></see></summary>
    let hasAddress = _prefix "hasAddress"
    /// <summary>
    /// The geo-coordinates of a place
    /// <see href="http://data.europa.eu/s66#hasCoordinates"></see></summary>
    let hasCoordinates = _prefix "hasCoordinates"
    /// <summary>
    /// The basic containment relation between a place and one that contains it
    /// <see href="http://data.europa.eu/s66#hasGeographicalLocation"></see></summary>
    let hasGeographicalLocation = _prefix "hasGeographicalLocation"
    /// <summary>
    /// Indicates an entity which has presence at the given site
    /// <see href="http://data.europa.eu/s66#isSiteOf"></see></summary>
    let isSiteOf = _prefix "isSiteOf"
    /// <summary>
    /// A book authored by a student containing a formal presentations of research outputs submitted for examination in completion of a course of study at an institution of higher education, to fulfil the requirements for an academic degree. Also know as a dissertation.
    /// <see href="http://data.europa.eu/s66#ThesisDissertation"></see></summary>
    let ThesisDissertation = _prefix "ThesisDissertation"
    /// <summary>
    /// A CORDA code.
    /// <see href="http://data.europa.eu/s66#code"></see></summary>
    let code = _prefix "code"
    /// <summary>
    /// The currency in which the monetary amount is expressed.
    /// <see href="http://data.europa.eu/s66#currency"></see></summary>
    let currency = _prefix "currency"
    /// <summary>
    /// The date in which the grant payment took place.
    /// <see href="http://data.europa.eu/s66#date"></see></summary>
    let date = _prefix "date"
    /// <summary>
    /// Relates the funding agency to the grant(s) that it disburses.
    /// <see href="http://data.europa.eu/s66#disburses"></see></summary>
    let disburses = _prefix "disburses"
    /// <summary>
    /// Relates an entity (e.g. project, grant, etc.) with its acronym(s). This includes acronyms representing the entity’s title as well as any additional acronyms extracted from other attributes of the entity.
    /// <see href="http://data.europa.eu/s66#hasAcronym"></see></summary>
    let hasAcronym = _prefix "hasAcronym"
    /// <summary>
    /// Relates the acronym to the entity or entities to which it belongs.
    /// <see href="http://data.europa.eu/s66#isAcronymOf"></see></summary>
    let isAcronymOf = _prefix "isAcronymOf"
    /// <summary>
    /// Relates an entity other than funding scheme (e.g., result, etc.) with associated funding schemes.
    /// <see href="http://data.europa.eu/s66#hasAssociatedFundingScheme"></see></summary>
    let hasAssociatedFundingScheme = _prefix "hasAssociatedFundingScheme"
    /// <summary>
    /// Relates the role to the grant(s) of which the role is a beneficiary.
    /// <see href="http://data.europa.eu/s66#isBeneficiaryOf"></see></summary>
    let isBeneficiaryOf = _prefix "isBeneficiaryOf"
    /// <summary>
    /// One or more values from the EuroSciVoc taxonomy that represent the main fields of science of the project.
    /// <see href="http://data.europa.eu/s66#hasEuroSciVocClassification"></see></summary>
    let hasEuroSciVocClassification = _prefix "hasEuroSciVocClassification"
    /// <summary>
    /// Relates a funding scheme with the grants that form part of it.
    /// <see href="http://data.europa.eu/s66#hasGrant"></see></summary>
    let hasGrant = _prefix "hasGrant"
    /// <summary>
    /// Indicates the Call under which a project has been funded.
    /// <see href="http://data.europa.eu/s66#hasFundingSchemeCall"></see></summary>
    let hasFundingSchemeCall = _prefix "hasFundingSchemeCall"
    /// <summary>
    /// Indicates the legal basis under which a project has been funded.
    /// <see href="http://data.europa.eu/s66#hasFundingSchemeProgramme"></see></summary>
    let hasFundingSchemeProgramme = _prefix "hasFundingSchemeProgramme"
    /// <summary>
    /// Indicates the Topic under which a project has been funded.
    /// <see href="http://data.europa.eu/s66#hasFundingSchemeTopic"></see></summary>
    let hasFundingSchemeTopic = _prefix "hasFundingSchemeTopic"
    /// <summary>
    /// Indicates the type of action under which a project has been funded.
    /// <see href="http://data.europa.eu/s66#hasFundingSchemeType"></see></summary>
    let hasFundingSchemeType = _prefix "hasFundingSchemeType"
    /// <summary>
    /// The 2-digit ISO country code.
    /// <see href="http://data.europa.eu/s66#hasISOCountryCode"></see></summary>
    let hasISOCountryCode = _prefix "hasISOCountryCode"
    /// <summary>
    /// A value representing the NUTS-0 code of the place or address.
    /// <see href="http://data.europa.eu/s66#hasNUTS0code"></see></summary>
    let hasNUTS0code = _prefix "hasNUTS0code"
    /// <summary>
    /// A value representing the NUTS code of the place or address.
    /// <see href="http://data.europa.eu/s66#hasNUTSCode"></see></summary>
    let hasNUTSCode = _prefix "hasNUTSCode"
    /// <summary>
    /// A value representing the NUTS-1 code of the place or address.
    /// <see href="http://data.europa.eu/s66#hasNUTS1code"></see></summary>
    let hasNUTS1code = _prefix "hasNUTS1code"
    /// <summary>
    /// A value representing the NUTS-2 code of the place or address.
    /// <see href="http://data.europa.eu/s66#hasNUTS2code"></see></summary>
    let hasNUTS2code = _prefix "hasNUTS2code"
    /// <summary>
    /// A value representing the NUTS-3 code of the place or address.
    /// <see href="http://data.europa.eu/s66#hasNUTS3code"></see></summary>
    let hasNUTS3code = _prefix "hasNUTS3code"
    /// <summary>
    /// Relates a funding scheme with the next funding scheme.
    /// <see href="http://data.europa.eu/s66#hasNextFundingScheme"></see></summary>
    let hasNextFundingScheme = _prefix "hasNextFundingScheme"
    /// <summary>
    /// Relates a payment to the grant of which it is a part.
    /// <see href="http://data.europa.eu/s66#isPaymentOf"></see></summary>
    let isPaymentOf = _prefix "isPaymentOf"
    /// <summary>
    /// Relates a funding scheme with the previous funding scheme.
    /// <see href="http://data.europa.eu/s66#hasPreviousFundingScheme"></see></summary>
    let hasPreviousFundingScheme = _prefix "hasPreviousFundingScheme"
    /// <summary>
    /// Relates the grant payment to the organisation role(s) which have received the grant payment. Inverse property of isRecipientOf.
    /// <see href="http://data.europa.eu/s66#hasRecipient"></see></summary>
    let hasRecipient = _prefix "hasRecipient"
    /// <summary>
    /// Relates the organisation role with the grant payment(s) which they have received. Inverse property of hasRecipient.
    /// <see href="http://data.europa.eu/s66#isRecipientOf"></see></summary>
    let isRecipientOf = _prefix "isRecipientOf"
    /// <summary>
    /// Represents a generic non parent-child relation between two CORDIS projects.
    /// <see href="http://data.europa.eu/s66#hasRelatedProject"></see></summary>
    let hasRelatedProject = _prefix "hasRelatedProject"
    /// <summary>
    /// Represents a generic non parent-child relation between two funding schemes.
    /// <see href="http://data.europa.eu/s66#hasRelatedScheme"></see></summary>
    let hasRelatedScheme = _prefix "hasRelatedScheme"
    /// <summary>
    /// Relates the project with its result(s).
    /// <see href="http://data.europa.eu/s66#hasResult"></see></summary>
    let hasResult = _prefix "hasResult"
    /// <summary>
    /// Relates the results with the Project(s) involved.
    /// <see href="http://data.europa.eu/s66#isResultOf"></see></summary>
    let isResultOf = _prefix "isResultOf"
    /// <summary>
    /// Relates the organisation with another organisation which is a sub-part or child of it.
    /// <see href="http://data.europa.eu/s66#hasSubOrganisation"></see></summary>
    let hasSubOrganisation = _prefix "hasSubOrganisation"
    /// <summary>
    /// Relates the organisation with another organisation of which it is a sub-part.
    /// <see href="http://data.europa.eu/s66#isSubOrganisationOf"></see></summary>
    let isSubOrganisationOf = _prefix "isSubOrganisationOf"
    /// <summary>
    /// Relates the funding scheme to its sub-schemes.
    /// <see href="http://data.europa.eu/s66#hasSubScheme"></see></summary>
    let hasSubScheme = _prefix "hasSubScheme"
    /// <summary>
    /// Relates the funding scheme to its parent scheme of which this funding scheme forms a part.
    /// <see href="http://data.europa.eu/s66#isSubSchemeOf"></see></summary>
    let isSubSchemeOf = _prefix "isSubSchemeOf"
    /// <summary>
    /// Relates the organisation with a unit or department that forms part of the organisation.
    /// <see href="http://data.europa.eu/s66#hasUnit"></see></summary>
    let hasUnit = _prefix "hasUnit"
    /// <summary>
    /// Relates the unit to the organisation of which the unit forms a part.
    /// <see href="http://data.europa.eu/s66#isUnitOf"></see></summary>
    let isUnitOf = _prefix "isUnitOf"
    /// <summary>
    /// Relates a funding agency to the funding schemes that it implements and administers.
    /// <see href="http://data.europa.eu/s66#implements"></see></summary>
    let implements = _prefix "implements"
    /// <summary>
    /// The international standard book number of book publications.
    /// <see href="http://data.europa.eu/s66#isbn"></see></summary>
    let isbn = _prefix "isbn"
    /// <summary>
    /// The international standard serial number of journal publications.
    /// <see href="http://data.europa.eu/s66#issn"></see></summary>
    let issn = _prefix "issn"
    /// <summary>
    /// Word or words that represent the main idea of a referred entity (e.g., project. project result, etc.)
    /// <see href="http://data.europa.eu/s66#keyword"></see></summary>
    let keyword = _prefix "keyword"
    /// <summary>
    ///   <see href="http://data.europa.eu/s66#order"></see>
    /// </summary>
    let order = _prefix "order"
    /// <summary>
    /// The date that the reporting period started.
    /// <see href="http://data.europa.eu/s66#periodFrom"></see></summary>
    let periodFrom = _prefix "periodFrom"
    /// <summary>
    /// The number of the reporting period.
    /// <see href="http://data.europa.eu/s66#periodNumber"></see></summary>
    let periodNumber = _prefix "periodNumber"
    /// <summary>
    /// The date that the reporting period ended.
    /// <see href="http://data.europa.eu/s66#periodTo"></see></summary>
    let periodTo = _prefix "periodTo"
    /// <summary>
    /// The post office box number for PO box addresses.
    /// <see href="http://data.europa.eu/s66#postOfficeBoxNumber"></see></summary>
    let postOfficeBoxNumber = _prefix "postOfficeBoxNumber"
    /// <summary>
    /// The entity to which this acronym refers. This can either be an entity inside of the knowledge graph or an external entity of any type.
    /// <see href="http://data.europa.eu/s66#refersTo"></see></summary>
    let refersTo = _prefix "refersTo"
    /// <summary>
    /// The termination date of a project.
    /// <see href="http://data.europa.eu/s66#terminationDate"></see></summary>
    let terminationDate = _prefix "terminationDate"
