namespace http.data.europa.eu.s66.hash

open DoxAletheia.Rdf_Vocabulary

module eurio =
    let _namespace_name = "http://data.europa.eu/s66#"

    /// <summary>
    /// A document referring to the results obtained during the development of a project.
    /// <see href="http://data.europa.eu/s66#ProjectDeliverable"></see></summary>
    let ProjectDeliverable =
        Namespaced_IRI.parse _namespace_name "ProjectDeliverable" |> NamespacedName

    /// <summary>
    /// A scientific publication (e.g., journal article, conference paper, thesis dissertation, book, etc.) that resulted from the project activities.
    /// <see href="http://data.europa.eu/s66#ProjectPublication"></see></summary>
    let ProjectPublication =
        Namespaced_IRI.parse _namespace_name "ProjectPublication" |> NamespacedName

    /// <summary>
    /// A document reporting on the progress of an on-going or completed project at a given period..
    /// <see href="http://data.europa.eu/s66#ProjectReportSummary"></see></summary>
    let ProjectReportSummary =
        Namespaced_IRI.parse _namespace_name "ProjectReportSummary" |> NamespacedName

    /// <summary>
    /// A for profit entity
    /// <see href="http://data.europa.eu/s66#ForProfitOrganisation"></see></summary>
    let ForProfitOrganisation =
        Namespaced_IRI.parse _namespace_name "ForProfitOrganisation" |> NamespacedName

    /// <summary>
    /// An organisation that materially administrates funding schemes and disburses related grants. In the context of CORDIS, it represents the various European agencies responsible for funding research projects (e.g. ERC, EASME, REA, etc.).
    /// <see href="http://data.europa.eu/s66#FundingAgency"></see></summary>
    let FundingAgency =
        Namespaced_IRI.parse _namespace_name "FundingAgency" |> NamespacedName

    /// <summary>
    /// Institution that provides education.
    /// <see href="http://data.europa.eu/s66#HigherOrSecondaryEducation"></see></summary>
    let HigherOrSecondaryEducation =
        Namespaced_IRI.parse _namespace_name "HigherOrSecondaryEducation" |> NamespacedName

    /// <summary>
    /// Organisation or agency depending on a government, State or other supranational organisation and mainly operated by the government.
    /// <see href="http://data.europa.eu/s66#PublicBody"></see></summary>
    let PublicBody = Namespaced_IRI.parse _namespace_name "PublicBody" |> NamespacedName

    /// <summary>
    /// Organisations devoted to research activities.
    /// <see href="http://data.europa.eu/s66#ResearchOrganisation"></see></summary>
    let ResearchOrganisation =
        Namespaced_IRI.parse _namespace_name "ResearchOrganisation" |> NamespacedName

    /// <summary>
    /// Small and Medium Enterprises.
    /// <see href="http://data.europa.eu/s66#SME"></see></summary>
    let SME = Namespaced_IRI.parse _namespace_name "SME" |> NamespacedName

    /// <summary>
    /// An article, typically the realization of a research paper reporting original research findings, published in a journal issue.
    /// <see href="http://data.europa.eu/s66#JournalPaper"></see></summary>
    let JournalPaper =
        Namespaced_IRI.parse _namespace_name "JournalPaper" |> NamespacedName

    /// <summary>
    /// A paper, typically the realization of a research paper reporting original research findings, usually presented at a workshop and published within a workshop proceedings volume.
    /// <see href="http://data.europa.eu/s66#ProceedingsPaper"></see></summary>
    let ProceedingsPaper =
        Namespaced_IRI.parse _namespace_name "ProceedingsPaper" |> NamespacedName

    /// <summary>
    /// An abbreviation formed from the initial letters of other words and pronounced as a word. It can refer to any type of entities in the CORDIS conceptual framework, and may be stated explicitly or extracted automatically from text.
    /// <see href="http://data.europa.eu/s66#Acronym"></see></summary>
    let Acronym = Namespaced_IRI.parse _namespace_name "Acronym" |> NamespacedName
    /// <summary>
    /// The value of the acronym.
    /// <see href="http://data.europa.eu/s66#shortForm"></see></summary>
    let shortForm = Namespaced_IRI.parse _namespace_name "shortForm" |> NamespacedName
    /// <summary>
    /// The definition of the acronym.
    /// <see href="http://data.europa.eu/s66#definition"></see></summary>
    let definition = Namespaced_IRI.parse _namespace_name "definition" |> NamespacedName

    /// <summary>
    /// An administrative geographical area that is typically managed by a public body. It can be a country, a region, a municipality, a province, a sub-municipality area, etc.
    /// <see href="http://data.europa.eu/s66#AdministrativeArea"></see></summary>
    let AdministrativeArea =
        Namespaced_IRI.parse _namespace_name "AdministrativeArea" |> NamespacedName

    /// <summary>
    /// The name of an entity
    /// <see href="http://data.europa.eu/s66#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// A non-serial document that is complete in one volume or a designated finite number of volumes. A book published by a publisher is usually identified by an International Standard Book Number (ISBN), and may be manifested as a physical printed publication on paper bound in a hard or soft cover, or in electronic format as an 'e-book'.
    /// <see href="http://data.europa.eu/s66#Book"></see></summary>
    let Book = Namespaced_IRI.parse _namespace_name "Book" |> NamespacedName

    /// <summary>
    /// The geo coordinates for a location of entities that participate in or form part of research projects.
    /// <see href="http://data.europa.eu/s66#Coordinates"></see></summary>
    let Coordinates =
        Namespaced_IRI.parse _namespace_name "Coordinates" |> NamespacedName

    /// <summary>
    /// The longitude of a location. For example -122.08585 (WGS 84).
    /// <see href="http://data.europa.eu/s66#longitude"></see></summary>
    let longitude = Namespaced_IRI.parse _namespace_name "longitude" |> NamespacedName
    /// <summary>
    /// The latitude of a location. For example 37.42242 (WGS 84).
    /// <see href="http://data.europa.eu/s66#latitude"></see></summary>
    let latitude = Namespaced_IRI.parse _namespace_name "latitude" |> NamespacedName
    /// <summary>
    /// A country
    /// <see href="http://data.europa.eu/s66#Country"></see></summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName

    /// <summary>
    /// The country code of the location or address according to the EU country codes.
    /// <see href="http://data.europa.eu/s66#hasEUCountryCode"></see></summary>
    let hasEUCountryCode =
        Namespaced_IRI.parse _namespace_name "hasEUCountryCode" |> NamespacedName

    /// <summary>
    /// Any acronym that has been detected, automatically or manually, from the description of an entity or from any other form of natural language text.
    /// <see href="http://data.europa.eu/s66#DetectedAcronym"></see></summary>
    let DetectedAcronym =
        Namespaced_IRI.parse _namespace_name "DetectedAcronym" |> NamespacedName

    /// <summary>
    /// An acronym explicitly defined as the title or name of another entity (e.g. Project, Organisation, Funding Scheme, etc.).
    /// <see href="http://data.europa.eu/s66#TitleAcronym"></see></summary>
    let TitleAcronym =
        Namespaced_IRI.parse _namespace_name "TitleAcronym" |> NamespacedName

    /// <summary>
    /// Represents a group of people, with the same purpose, organized together into a community or other social, commercial or political structure that participate in CORDIS projects.
    /// <see href="http://data.europa.eu/s66#Organisation"></see></summary>
    let Organisation =
        Namespaced_IRI.parse _namespace_name "Organisation" |> NamespacedName

    /// <summary>
    /// Set of rules and conditions which forms the basis for public funding of European research. In CORDIS, they represent the different legal frameworks (e.g. FP6, FP7, H2020). They can also be used to represent the different calls inside each framework by using the recursive relation “partOfScheme”.
    /// <see href="http://data.europa.eu/s66#FundingScheme"></see></summary>
    let FundingScheme =
        Namespaced_IRI.parse _namespace_name "FundingScheme" |> NamespacedName

    /// <summary>
    /// Relates the funding scheme with the funding agency that implements and administers the scheme.
    /// <see href="http://data.europa.eu/s66#isImplementedBy"></see></summary>
    let isImplementedBy =
        Namespaced_IRI.parse _namespace_name "isImplementedBy" |> NamespacedName

    /// <summary>
    /// The period of time an entity (e.g. project, grant, etc.) has taken, represented as number of months.
    /// <see href="http://data.europa.eu/s66#duration"></see></summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName
    /// <summary>
    /// A URL that links internet resources related to a CORDIS entity.
    /// <see href="http://data.europa.eu/s66#url"></see></summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName

    /// <summary>
    /// A list of terms specifying the different categories / types of funding schemes.
    /// <see href="http://data.europa.eu/s66#hasFundingSchemeCategory"></see></summary>
    let hasFundingSchemeCategory =
        Namespaced_IRI.parse _namespace_name "hasFundingSchemeCategory" |> NamespacedName

    /// <summary>
    /// The entity’s (e.g. project, work package, etc.) official name or title.
    /// <see href="http://data.europa.eu/s66#title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    /// A disbursed fund paid to a recipient or beneficiary within the context of a funded research project. In the context of CORDIS, it represents a grant of a specific EU programme (e.g. an H2020 grant).
    /// <see href="http://data.europa.eu/s66#Grant"></see></summary>
    let Grant = Namespaced_IRI.parse _namespace_name "Grant" |> NamespacedName
    /// <summary>
    /// The time an entity (e.g. project, grant, etc.) is initialized or starts to take effect.
    /// <see href="http://data.europa.eu/s66#startDate"></see></summary>
    let startDate = Namespaced_IRI.parse _namespace_name "startDate" |> NamespacedName

    /// <summary>
    /// Relates the grant to the organisation role(s) that are a beneficiary of the grant.
    /// <see href="http://data.europa.eu/s66#hasBeneficiary"></see></summary>
    let hasBeneficiary =
        Namespaced_IRI.parse _namespace_name "hasBeneficiary" |> NamespacedName

    /// <summary>
    /// Relates the grant to the funding agency that disburses the grant.
    /// <see href="http://data.europa.eu/s66#isDisbursedBy"></see></summary>
    let isDisbursedBy =
        Namespaced_IRI.parse _namespace_name "isDisbursedBy" |> NamespacedName

    /// <summary>
    /// Relates the grant or funding scheme to the amount of money available for funding.
    /// <see href="http://data.europa.eu/s66#hasFundingAmount"></see></summary>
    let hasFundingAmount =
        Namespaced_IRI.parse _namespace_name "hasFundingAmount" |> NamespacedName

    /// <summary>
    /// The date on which an entity (e.g. project, grant, etc.) is finalized or ceases to exist.
    /// <see href="http://data.europa.eu/s66#endDate"></see></summary>
    let endDate = Namespaced_IRI.parse _namespace_name "endDate" |> NamespacedName

    /// <summary>
    /// Relates the grant to the funding scheme of which the grant forms a part.
    /// <see href="http://data.europa.eu/s66#hasFundingScheme"></see></summary>
    let hasFundingScheme =
        Namespaced_IRI.parse _namespace_name "hasFundingScheme" |> NamespacedName

    /// <summary>
    /// Relates the grant with the project(s) that are completely or partially funded by it.
    /// <see href="http://data.europa.eu/s66#funds"></see></summary>
    let funds = Namespaced_IRI.parse _namespace_name "funds" |> NamespacedName
    /// <summary>
    /// Relates the grant to its payment(s).
    /// <see href="http://data.europa.eu/s66#hasPayment"></see></summary>
    let hasPayment = Namespaced_IRI.parse _namespace_name "hasPayment" |> NamespacedName

    /// <summary>
    /// A single payment to a recipient or beneficiary of a Grant within a research project.
    /// <see href="http://data.europa.eu/s66#GrantPayment"></see></summary>
    let GrantPayment =
        Namespaced_IRI.parse _namespace_name "GrantPayment" |> NamespacedName

    /// <summary>
    /// Relates the payment to the amount of money that was given to the beneficiary of the payment.
    /// <see href="http://data.europa.eu/s66#hasPaymentAmount"></see></summary>
    let hasPaymentAmount =
        Namespaced_IRI.parse _namespace_name "hasPaymentAmount" |> NamespacedName

    /// <summary>
    /// A monetary value or range. This type can be used to describe an amount of money such as $50 USD, or a range as in describing a bank account being suitable for a balance between £1,000 and £1,000,000 GBP, or the value of a salary, etc.
    /// <see href="http://data.europa.eu/s66#MonetaryAmount"></see></summary>
    let MonetaryAmount =
        Namespaced_IRI.parse _namespace_name "MonetaryAmount" |> NamespacedName

    /// <summary>
    /// The value of amount being expressed.
    /// <see href="http://data.europa.eu/s66#value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName

    /// <summary>
    /// A work that hasn't undergone peer reviewing prior to its publication.
    /// <see href="http://data.europa.eu/s66#NonPeerReviewedPublication"></see></summary>
    let NonPeerReviewedPublication =
        Namespaced_IRI.parse _namespace_name "NonPeerReviewedPublication" |> NamespacedName

    /// <summary>
    /// The internal CORDA identifier.
    /// <see href="http://data.europa.eu/s66#identifier"></see></summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName

    /// <summary>
    /// Function assumed by or ascribed to an organisation that takes part in a particular project. In CORDIs, it represents roles such as coordinator, partner, consortium member, etc.
    /// <see href="http://data.europa.eu/s66#OrganisationRole"></see></summary>
    let OrganisationRole =
        Namespaced_IRI.parse _namespace_name "OrganisationRole" |> NamespacedName

    /// <summary>
    /// Relates the organisation to the roles that the organisation takes.
    /// <see href="http://data.europa.eu/s66#hasRole"></see></summary>
    let hasRole = Namespaced_IRI.parse _namespace_name "hasRole" |> NamespacedName
    /// <summary>
    /// The unique number that identifies a taxable organisation or non-taxable legal entity that is registered for VAT.
    /// <see href="http://data.europa.eu/s66#vatNumber"></see></summary>
    let vatNumber = Namespaced_IRI.parse _namespace_name "vatNumber" |> NamespacedName
    /// <summary>
    /// Internal CORDIS identifier used for the identification of the domain entities (e.g., projects, project results, organisations, funding schemes, etc.). Stands for Resource Control Number.
    /// <see href="http://data.europa.eu/s66#rcn"></see></summary>
    let rcn = Namespaced_IRI.parse _namespace_name "rcn" |> NamespacedName
    /// <summary>
    /// relates an organisation to its physical site
    /// <see href="http://data.europa.eu/s66#hasSite"></see></summary>
    let hasSite = Namespaced_IRI.parse _namespace_name "hasSite" |> NamespacedName
    /// <summary>
    /// The official name of the organization, e.g. the registered company name.
    /// <see href="http://data.europa.eu/s66#legalName"></see></summary>
    let legalName = Namespaced_IRI.parse _namespace_name "legalName" |> NamespacedName
    /// <summary>
    /// Relates the organisation role to the organisation which assumes the role.
    /// <see href="http://data.europa.eu/s66#isRoleOf"></see></summary>
    let isRoleOf = Namespaced_IRI.parse _namespace_name "isRoleOf" |> NamespacedName
    /// <summary>
    /// The function assumed by or ascribed to an entity (typically an organisation) in a particular project. It can be used to precise or represent additional information about a relationship or property such as participation or membership. In CORDIS, it represents the participation of an organisation in a research project.
    /// <see href="http://data.europa.eu/s66#Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName

    /// <summary>
    /// A department or unit which is part of some larger Organization and only has full recognition within the context of that Organization. In CORDIS, it represents for instance the different departments of a university that participate in a particular project.
    /// <see href="http://data.europa.eu/s66#OrganisationUnit"></see></summary>
    let OrganisationUnit =
        Namespaced_IRI.parse _namespace_name "OrganisationUnit" |> NamespacedName

    /// <summary>
    /// The postal address of entities that participate in or form part of research projects.
    /// <see href="http://data.europa.eu/s66#PostalAddress"></see></summary>
    let PostalAddress =
        Namespaced_IRI.parse _namespace_name "PostalAddress" |> NamespacedName

    /// <summary>
    /// The postal code of the place or address.
    /// <see href="http://data.europa.eu/s66#postalCode"></see></summary>
    let postalCode = Namespaced_IRI.parse _namespace_name "postalCode" |> NamespacedName

    /// <summary>
    /// The street name and number of the place or address.
    /// <see href="http://data.europa.eu/s66#streetAddress"></see></summary>
    let streetAddress =
        Namespaced_IRI.parse _namespace_name "streetAddress" |> NamespacedName

    /// <summary>
    /// The country of the place or address. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
    /// <see href="http://data.europa.eu/s66#addressCountry"></see></summary>
    let addressCountry =
        Namespaced_IRI.parse _namespace_name "addressCountry" |> NamespacedName

    /// <summary>
    /// The full address of a physical location of an entity.
    /// <see href="http://data.europa.eu/s66#fullAddress"></see></summary>
    let fullAddress =
        Namespaced_IRI.parse _namespace_name "fullAddress" |> NamespacedName

    /// <summary>
    /// The locality, town or city of the place or address.
    /// <see href="http://data.europa.eu/s66#addressLocality"></see></summary>
    let addressLocality =
        Namespaced_IRI.parse _namespace_name "addressLocality" |> NamespacedName

    /// <summary>
    /// A planned research work that has one or more objectives (divided or not into tasks) and is conducted by one or more organisations. In CORDIS, it represents a project funded by an EU programme.
    /// <see href="http://data.europa.eu/s66#Project"></see></summary>
    let Project = Namespaced_IRI.parse _namespace_name "Project" |> NamespacedName
    /// <summary>
    /// The general summary and ideas of a CORDIS entity, e.g., project, result.
    /// <see href="http://data.europa.eu/s66#abstract"></see></summary>
    let abstract_ = Namespaced_IRI.parse _namespace_name "abstract" |> NamespacedName
    /// <summary>
    /// Relates the project with the grant(s) that completely or partially fund the project.
    /// <see href="http://data.europa.eu/s66#isFundedBy"></see></summary>
    let isFundedBy = Namespaced_IRI.parse _namespace_name "isFundedBy" |> NamespacedName

    /// <summary>
    /// Relates the project with the amount of money expected, required, or given in payment for the project.
    /// <see href="http://data.europa.eu/s66#hasTotalCost"></see></summary>
    let hasTotalCost =
        Namespaced_IRI.parse _namespace_name "hasTotalCost" |> NamespacedName

    /// <summary>
    /// The digital object identifier of a publication.
    /// <see href="http://data.europa.eu/s66#doi"></see></summary>
    let doi = Namespaced_IRI.parse _namespace_name "doi" |> NamespacedName

    /// <summary>
    /// The day a grant agreement has been signed.
    /// <see href="http://data.europa.eu/s66#signatureDate"></see></summary>
    let signatureDate =
        Namespaced_IRI.parse _namespace_name "signatureDate" |> NamespacedName

    /// <summary>
    /// Relates the Project to the roles that are involved in the project.
    /// <see href="http://data.europa.eu/s66#hasInvolvedParty"></see></summary>
    let hasInvolvedParty =
        Namespaced_IRI.parse _namespace_name "hasInvolvedParty" |> NamespacedName

    /// <summary>
    /// The current status (signed, ongoing, terminated, etc.) of the project.
    /// <see href="http://data.europa.eu/s66#projectStatus"></see></summary>
    let projectStatus =
        Namespaced_IRI.parse _namespace_name "projectStatus" |> NamespacedName

    /// <summary>
    /// A brief summary of the entity (project, etc.).
    /// <see href="http://data.europa.eu/s66#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// A list of terms specifying the types of results that can have a project.
    /// <see href="http://data.europa.eu/s66#hasResultType"></see></summary>
    let hasResultType =
        Namespaced_IRI.parse _namespace_name "hasResultType" |> NamespacedName

    /// <summary>
    /// Any tangible or intangible output of the project (such as data, knowledge and information, whatever their form or nature, whether or not they can be protected), which are generated in the project.
    /// <see href="http://data.europa.eu/s66#Result"></see></summary>
    let Result = Namespaced_IRI.parse _namespace_name "Result" |> NamespacedName

    /// <summary>
    /// The journal number of a published result.
    /// <see href="http://data.europa.eu/s66#journalNumber"></see></summary>
    let journalNumber =
        Namespaced_IRI.parse _namespace_name "journalNumber" |> NamespacedName

    /// <summary>
    /// Represents the publishing body of a published result.
    /// <see href="http://data.europa.eu/s66#publisher"></see></summary>
    let publisher = Namespaced_IRI.parse _namespace_name "publisher" |> NamespacedName

    /// <summary>
    /// The year of publication.
    /// <see href="http://data.europa.eu/s66#publishedYear"></see></summary>
    let publishedYear =
        Namespaced_IRI.parse _namespace_name "publishedYear" |> NamespacedName

    /// <summary>
    /// The title of the journal of a published result.
    /// <see href="http://data.europa.eu/s66#journalTitle"></see></summary>
    let journalTitle =
        Namespaced_IRI.parse _namespace_name "journalTitle" |> NamespacedName

    /// <summary>
    /// The list of authors.
    /// <see href="http://data.europa.eu/s66#author"></see></summary>
    let author = Namespaced_IRI.parse _namespace_name "author" |> NamespacedName

    /// <summary>
    /// The pages of a published result.
    /// <see href="http://data.europa.eu/s66#publishedPages"></see></summary>
    let publishedPages =
        Namespaced_IRI.parse _namespace_name "publishedPages" |> NamespacedName

    /// <summary>
    /// A brief description of the project findings.
    /// <see href="http://data.europa.eu/s66#finalResults"></see></summary>
    let finalResults =
        Namespaced_IRI.parse _namespace_name "finalResults" |> NamespacedName

    /// <summary>
    /// A summary of the work carried out during the development of the project.
    /// <see href="http://data.europa.eu/s66#workPerformed"></see></summary>
    let workPerformed =
        Namespaced_IRI.parse _namespace_name "workPerformed" |> NamespacedName

    /// <summary>
    /// The language used in a project result.
    /// <see href="http://data.europa.eu/s66#language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName
    /// <summary>
    /// Title for capturing the role of an organisation.
    /// <see href="http://data.europa.eu/s66#roleLabel"></see></summary>
    let roleLabel = Namespaced_IRI.parse _namespace_name "roleLabel" |> NamespacedName

    /// <summary>
    /// Relates the role to the Project in which it is involved.
    /// <see href="http://data.europa.eu/s66#isInvolvedIn"></see></summary>
    let isInvolvedIn =
        Namespaced_IRI.parse _namespace_name "isInvolvedIn" |> NamespacedName

    /// <summary>
    /// The physical extension of entities that participate in or form part of research projects.
    /// <see href="http://data.europa.eu/s66#Site"></see></summary>
    let Site = Namespaced_IRI.parse _namespace_name "Site" |> NamespacedName
    /// <summary>
    /// Relates a physical location to its registered address.
    /// <see href="http://data.europa.eu/s66#hasAddress"></see></summary>
    let hasAddress = Namespaced_IRI.parse _namespace_name "hasAddress" |> NamespacedName

    /// <summary>
    /// The geo-coordinates of a place
    /// <see href="http://data.europa.eu/s66#hasCoordinates"></see></summary>
    let hasCoordinates =
        Namespaced_IRI.parse _namespace_name "hasCoordinates" |> NamespacedName

    /// <summary>
    /// The basic containment relation between a place and one that contains it
    /// <see href="http://data.europa.eu/s66#hasGeographicalLocation"></see></summary>
    let hasGeographicalLocation =
        Namespaced_IRI.parse _namespace_name "hasGeographicalLocation" |> NamespacedName

    /// <summary>
    /// Indicates an entity which has presence at the given site
    /// <see href="http://data.europa.eu/s66#isSiteOf"></see></summary>
    let isSiteOf = Namespaced_IRI.parse _namespace_name "isSiteOf" |> NamespacedName

    /// <summary>
    /// A book authored by a student containing a formal presentations of research outputs submitted for examination in completion of a course of study at an institution of higher education, to fulfil the requirements for an academic degree. Also know as a dissertation.
    /// <see href="http://data.europa.eu/s66#ThesisDissertation"></see></summary>
    let ThesisDissertation =
        Namespaced_IRI.parse _namespace_name "ThesisDissertation" |> NamespacedName

    /// <summary>
    /// A CORDA code.
    /// <see href="http://data.europa.eu/s66#code"></see></summary>
    let code = Namespaced_IRI.parse _namespace_name "code" |> NamespacedName
    /// <summary>
    /// The currency in which the monetary amount is expressed.
    /// <see href="http://data.europa.eu/s66#currency"></see></summary>
    let currency = Namespaced_IRI.parse _namespace_name "currency" |> NamespacedName
    /// <summary>
    /// The date in which the grant payment took place.
    /// <see href="http://data.europa.eu/s66#date"></see></summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName
    /// <summary>
    /// Relates the funding agency to the grant(s) that it disburses.
    /// <see href="http://data.europa.eu/s66#disburses"></see></summary>
    let disburses = Namespaced_IRI.parse _namespace_name "disburses" |> NamespacedName
    /// <summary>
    /// Relates an entity (e.g. project, grant, etc.) with its acronym(s). This includes acronyms representing the entity’s title as well as any additional acronyms extracted from other attributes of the entity.
    /// <see href="http://data.europa.eu/s66#hasAcronym"></see></summary>
    let hasAcronym = Namespaced_IRI.parse _namespace_name "hasAcronym" |> NamespacedName

    /// <summary>
    /// Relates the acronym to the entity or entities to which it belongs.
    /// <see href="http://data.europa.eu/s66#isAcronymOf"></see></summary>
    let isAcronymOf =
        Namespaced_IRI.parse _namespace_name "isAcronymOf" |> NamespacedName

    /// <summary>
    /// Relates an entity other than funding scheme (e.g., result, etc.) with associated funding schemes.
    /// <see href="http://data.europa.eu/s66#hasAssociatedFundingScheme"></see></summary>
    let hasAssociatedFundingScheme =
        Namespaced_IRI.parse _namespace_name "hasAssociatedFundingScheme" |> NamespacedName

    /// <summary>
    /// Relates the role to the grant(s) of which the role is a beneficiary.
    /// <see href="http://data.europa.eu/s66#isBeneficiaryOf"></see></summary>
    let isBeneficiaryOf =
        Namespaced_IRI.parse _namespace_name "isBeneficiaryOf" |> NamespacedName

    /// <summary>
    /// One or more values from the EuroSciVoc taxonomy that represent the main fields of science of the project.
    /// <see href="http://data.europa.eu/s66#hasEuroSciVocClassification"></see></summary>
    let hasEuroSciVocClassification =
        Namespaced_IRI.parse _namespace_name "hasEuroSciVocClassification" |> NamespacedName

    /// <summary>
    /// Relates a funding scheme with the grants that form part of it.
    /// <see href="http://data.europa.eu/s66#hasGrant"></see></summary>
    let hasGrant = Namespaced_IRI.parse _namespace_name "hasGrant" |> NamespacedName

    /// <summary>
    /// Indicates the Call under which a project has been funded.
    /// <see href="http://data.europa.eu/s66#hasFundingSchemeCall"></see></summary>
    let hasFundingSchemeCall =
        Namespaced_IRI.parse _namespace_name "hasFundingSchemeCall" |> NamespacedName

    /// <summary>
    /// Indicates the legal basis under which a project has been funded.
    /// <see href="http://data.europa.eu/s66#hasFundingSchemeProgramme"></see></summary>
    let hasFundingSchemeProgramme =
        Namespaced_IRI.parse _namespace_name "hasFundingSchemeProgramme" |> NamespacedName

    /// <summary>
    /// Indicates the Topic under which a project has been funded.
    /// <see href="http://data.europa.eu/s66#hasFundingSchemeTopic"></see></summary>
    let hasFundingSchemeTopic =
        Namespaced_IRI.parse _namespace_name "hasFundingSchemeTopic" |> NamespacedName

    /// <summary>
    /// Indicates the type of action under which a project has been funded.
    /// <see href="http://data.europa.eu/s66#hasFundingSchemeType"></see></summary>
    let hasFundingSchemeType =
        Namespaced_IRI.parse _namespace_name "hasFundingSchemeType" |> NamespacedName

    /// <summary>
    /// The 2-digit ISO country code.
    /// <see href="http://data.europa.eu/s66#hasISOCountryCode"></see></summary>
    let hasISOCountryCode =
        Namespaced_IRI.parse _namespace_name "hasISOCountryCode" |> NamespacedName

    /// <summary>
    /// A value representing the NUTS-0 code of the place or address.
    /// <see href="http://data.europa.eu/s66#hasNUTS0code"></see></summary>
    let hasNUTS0code =
        Namespaced_IRI.parse _namespace_name "hasNUTS0code" |> NamespacedName

    /// <summary>
    /// A value representing the NUTS code of the place or address.
    /// <see href="http://data.europa.eu/s66#hasNUTSCode"></see></summary>
    let hasNUTSCode =
        Namespaced_IRI.parse _namespace_name "hasNUTSCode" |> NamespacedName

    /// <summary>
    /// A value representing the NUTS-1 code of the place or address.
    /// <see href="http://data.europa.eu/s66#hasNUTS1code"></see></summary>
    let hasNUTS1code =
        Namespaced_IRI.parse _namespace_name "hasNUTS1code" |> NamespacedName

    /// <summary>
    /// A value representing the NUTS-2 code of the place or address.
    /// <see href="http://data.europa.eu/s66#hasNUTS2code"></see></summary>
    let hasNUTS2code =
        Namespaced_IRI.parse _namespace_name "hasNUTS2code" |> NamespacedName

    /// <summary>
    /// A value representing the NUTS-3 code of the place or address.
    /// <see href="http://data.europa.eu/s66#hasNUTS3code"></see></summary>
    let hasNUTS3code =
        Namespaced_IRI.parse _namespace_name "hasNUTS3code" |> NamespacedName

    /// <summary>
    /// Relates a funding scheme with the next funding scheme.
    /// <see href="http://data.europa.eu/s66#hasNextFundingScheme"></see></summary>
    let hasNextFundingScheme =
        Namespaced_IRI.parse _namespace_name "hasNextFundingScheme" |> NamespacedName

    /// <summary>
    /// Relates a payment to the grant of which it is a part.
    /// <see href="http://data.europa.eu/s66#isPaymentOf"></see></summary>
    let isPaymentOf =
        Namespaced_IRI.parse _namespace_name "isPaymentOf" |> NamespacedName

    /// <summary>
    /// Relates a funding scheme with the previous funding scheme.
    /// <see href="http://data.europa.eu/s66#hasPreviousFundingScheme"></see></summary>
    let hasPreviousFundingScheme =
        Namespaced_IRI.parse _namespace_name "hasPreviousFundingScheme" |> NamespacedName

    /// <summary>
    /// Relates the grant payment to the organisation role(s) which have received the grant payment. Inverse property of isRecipientOf.
    /// <see href="http://data.europa.eu/s66#hasRecipient"></see></summary>
    let hasRecipient =
        Namespaced_IRI.parse _namespace_name "hasRecipient" |> NamespacedName

    /// <summary>
    /// Relates the organisation role with the grant payment(s) which they have received. Inverse property of hasRecipient.
    /// <see href="http://data.europa.eu/s66#isRecipientOf"></see></summary>
    let isRecipientOf =
        Namespaced_IRI.parse _namespace_name "isRecipientOf" |> NamespacedName

    /// <summary>
    /// Represents a generic non parent-child relation between two CORDIS projects.
    /// <see href="http://data.europa.eu/s66#hasRelatedProject"></see></summary>
    let hasRelatedProject =
        Namespaced_IRI.parse _namespace_name "hasRelatedProject" |> NamespacedName

    /// <summary>
    /// Represents a generic non parent-child relation between two funding schemes.
    /// <see href="http://data.europa.eu/s66#hasRelatedScheme"></see></summary>
    let hasRelatedScheme =
        Namespaced_IRI.parse _namespace_name "hasRelatedScheme" |> NamespacedName

    /// <summary>
    /// Relates the project with its result(s).
    /// <see href="http://data.europa.eu/s66#hasResult"></see></summary>
    let hasResult = Namespaced_IRI.parse _namespace_name "hasResult" |> NamespacedName
    /// <summary>
    /// Relates the results with the Project(s) involved.
    /// <see href="http://data.europa.eu/s66#isResultOf"></see></summary>
    let isResultOf = Namespaced_IRI.parse _namespace_name "isResultOf" |> NamespacedName

    /// <summary>
    /// Relates the organisation with another organisation which is a sub-part or child of it.
    /// <see href="http://data.europa.eu/s66#hasSubOrganisation"></see></summary>
    let hasSubOrganisation =
        Namespaced_IRI.parse _namespace_name "hasSubOrganisation" |> NamespacedName

    /// <summary>
    /// Relates the organisation with another organisation of which it is a sub-part.
    /// <see href="http://data.europa.eu/s66#isSubOrganisationOf"></see></summary>
    let isSubOrganisationOf =
        Namespaced_IRI.parse _namespace_name "isSubOrganisationOf" |> NamespacedName

    /// <summary>
    /// Relates the funding scheme to its sub-schemes.
    /// <see href="http://data.europa.eu/s66#hasSubScheme"></see></summary>
    let hasSubScheme =
        Namespaced_IRI.parse _namespace_name "hasSubScheme" |> NamespacedName

    /// <summary>
    /// Relates the funding scheme to its parent scheme of which this funding scheme forms a part.
    /// <see href="http://data.europa.eu/s66#isSubSchemeOf"></see></summary>
    let isSubSchemeOf =
        Namespaced_IRI.parse _namespace_name "isSubSchemeOf" |> NamespacedName

    /// <summary>
    /// Relates the organisation with a unit or department that forms part of the organisation.
    /// <see href="http://data.europa.eu/s66#hasUnit"></see></summary>
    let hasUnit = Namespaced_IRI.parse _namespace_name "hasUnit" |> NamespacedName
    /// <summary>
    /// Relates the unit to the organisation of which the unit forms a part.
    /// <see href="http://data.europa.eu/s66#isUnitOf"></see></summary>
    let isUnitOf = Namespaced_IRI.parse _namespace_name "isUnitOf" |> NamespacedName
    /// <summary>
    /// Relates a funding agency to the funding schemes that it implements and administers.
    /// <see href="http://data.europa.eu/s66#implements"></see></summary>
    let implements = Namespaced_IRI.parse _namespace_name "implements" |> NamespacedName
    /// <summary>
    /// The international standard book number of book publications.
    /// <see href="http://data.europa.eu/s66#isbn"></see></summary>
    let isbn = Namespaced_IRI.parse _namespace_name "isbn" |> NamespacedName
    /// <summary>
    /// The international standard serial number of journal publications.
    /// <see href="http://data.europa.eu/s66#issn"></see></summary>
    let issn = Namespaced_IRI.parse _namespace_name "issn" |> NamespacedName
    /// <summary>
    /// Word or words that represent the main idea of a referred entity (e.g., project. project result, etc.)
    /// <see href="http://data.europa.eu/s66#keyword"></see></summary>
    let keyword = Namespaced_IRI.parse _namespace_name "keyword" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.europa.eu/s66#order"></see>
    /// </summary>
    let order = Namespaced_IRI.parse _namespace_name "order" |> NamespacedName
    /// <summary>
    /// The date that the reporting period started.
    /// <see href="http://data.europa.eu/s66#periodFrom"></see></summary>
    let periodFrom = Namespaced_IRI.parse _namespace_name "periodFrom" |> NamespacedName

    /// <summary>
    /// The number of the reporting period.
    /// <see href="http://data.europa.eu/s66#periodNumber"></see></summary>
    let periodNumber =
        Namespaced_IRI.parse _namespace_name "periodNumber" |> NamespacedName

    /// <summary>
    /// The date that the reporting period ended.
    /// <see href="http://data.europa.eu/s66#periodTo"></see></summary>
    let periodTo = Namespaced_IRI.parse _namespace_name "periodTo" |> NamespacedName

    /// <summary>
    /// The post office box number for PO box addresses.
    /// <see href="http://data.europa.eu/s66#postOfficeBoxNumber"></see></summary>
    let postOfficeBoxNumber =
        Namespaced_IRI.parse _namespace_name "postOfficeBoxNumber" |> NamespacedName

    /// <summary>
    /// The entity to which this acronym refers. This can either be an entity inside of the knowledge graph or an external entity of any type.
    /// <see href="http://data.europa.eu/s66#refersTo"></see></summary>
    let refersTo = Namespaced_IRI.parse _namespace_name "refersTo" |> NamespacedName

    /// <summary>
    /// The termination date of a project.
    /// <see href="http://data.europa.eu/s66#terminationDate"></see></summary>
    let terminationDate =
        Namespaced_IRI.parse _namespace_name "terminationDate" |> NamespacedName
