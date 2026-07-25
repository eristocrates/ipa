namespace http.data.europa.eu.s66.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module eurio =
    let _namespace_iri = Namespace_Iri eurio |> NamespaceIRI
    /// <summary>
    ///   <para>eurio:ProjectPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A scientific publication (e.g., journal article, conference paper, thesis dissertation, book, etc.) that resulted from the project activities.</para>
    /// labels<para>Project Publication</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#ProjectPublication">http://data.europa.eu/s66#ProjectPublication</seealso>
    let ProjectPublication = Prefixed_Name(eurio, "ProjectPublication") |> PrefixedName

    /// <summary>
    ///   <para>eurio:ProjectReportSummary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A document reporting on the progress of an on-going or completed project at a given period..</para>
    /// labels<para>Project Report Summary</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#ProjectReportSummary">http://data.europa.eu/s66#ProjectReportSummary</seealso>
    let ProjectReportSummary =
        Prefixed_Name(eurio, "ProjectReportSummary") |> PrefixedName

    /// <summary>
    ///   <para>eurio:ForProfitOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A for profit entity</para>
    /// labels<para>For Profit Organisation</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#ForProfitOrganisation">http://data.europa.eu/s66#ForProfitOrganisation</seealso>
    let ForProfitOrganisation =
        Prefixed_Name(eurio, "ForProfitOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>eurio:ResearchOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Organisations devoted to research activities.</para>
    /// labels<para>Research Organisation</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#ResearchOrganisation">http://data.europa.eu/s66#ResearchOrganisation</seealso>
    let ResearchOrganisation =
        Prefixed_Name(eurio, "ResearchOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>eurio:JournalPaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An article, typically the realization of a research paper reporting original research findings, published in a journal issue.</para>
    /// labels<para>Journal Paper</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#JournalPaper">http://data.europa.eu/s66#JournalPaper</seealso>
    let JournalPaper = Prefixed_Name(eurio, "JournalPaper") |> PrefixedName
    /// <summary>
    ///   <para>eurio:shortForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The value of the acronym.</para>
    /// labels<para>short form</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#shortForm">http://data.europa.eu/s66#shortForm</seealso>
    let shortForm = Prefixed_Name(eurio, "shortForm") |> PrefixedName
    /// <summary>
    ///   <para>eurio:AdministrativeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An administrative geographical area that is typically managed by a public body. It can be a country, a region, a municipality, a province, a sub-municipality area, etc.</para>
    /// labels<para>Administrative Area</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#AdministrativeArea">http://data.europa.eu/s66#AdministrativeArea</seealso>
    let AdministrativeArea = Prefixed_Name(eurio, "AdministrativeArea") |> PrefixedName
    /// <summary>
    ///   <para>eurio:Book</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A non-serial document that is complete in one volume or a designated finite number of volumes. A book published by a publisher is usually identified by an International Standard Book Number (ISBN), and may be manifested as a physical printed publication on paper bound in a hard or soft cover, or in electronic format as an 'e-book'.</para>
    /// labels<para>Book</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#Book">http://data.europa.eu/s66#Book</seealso>
    let Book = Prefixed_Name(eurio, "Book") |> PrefixedName
    /// <summary>
    ///   <para>eurio:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A country</para>
    /// labels<para>Country</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#Country">http://data.europa.eu/s66#Country</seealso>
    let Country = Prefixed_Name(eurio, "Country") |> PrefixedName
    /// <summary>
    ///   <para>eurio:TitleAcronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An acronym explicitly defined as the title or name of another entity (e.g. Project, Organisation, Funding Scheme, etc.).</para>
    /// labels<para>Title Acronym</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#TitleAcronym">http://data.europa.eu/s66#TitleAcronym</seealso>
    let TitleAcronym = Prefixed_Name(eurio, "TitleAcronym") |> PrefixedName
    /// <summary>
    ///   <para>eurio:isImplementedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the funding scheme with the funding agency that implements and administers the scheme.</para>
    /// labels<para>is implemented by</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#isImplementedBy">http://data.europa.eu/s66#isImplementedBy</seealso>
    let isImplementedBy = Prefixed_Name(eurio, "isImplementedBy") |> PrefixedName
    /// <summary>
    ///   <para>eurio:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The period of time an entity (e.g. project, grant, etc.) has taken, represented as number of months.</para>
    /// labels<para>duration</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#duration">http://data.europa.eu/s66#duration</seealso>
    let duration = Prefixed_Name(eurio, "duration") |> PrefixedName
    /// <summary>
    ///   <para>eurio:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A URL that links internet resources related to a CORDIS entity.</para>
    /// labels<para>URL</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#url">http://data.europa.eu/s66#url</seealso>
    let url = Prefixed_Name(eurio, "url") |> PrefixedName
    /// <summary>
    ///   <para>eurio:Grant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A disbursed fund paid to a recipient or beneficiary within the context of a funded research project. In the context of CORDIS, it represents a grant of a specific EU programme (e.g. an H2020 grant).</para>
    /// labels<para>Grant</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#Grant">http://data.europa.eu/s66#Grant</seealso>
    let Grant = Prefixed_Name(eurio, "Grant") |> PrefixedName
    /// <summary>
    ///   <para>eurio:isDisbursedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the grant to the funding agency that disburses the grant.</para>
    /// labels<para>is disbursed by</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#isDisbursedBy">http://data.europa.eu/s66#isDisbursedBy</seealso>
    let isDisbursedBy = Prefixed_Name(eurio, "isDisbursedBy") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasPayment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the grant to its payment(s).</para>
    /// labels<para>has payment</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasPayment">http://data.europa.eu/s66#hasPayment</seealso>
    let hasPayment = Prefixed_Name(eurio, "hasPayment") |> PrefixedName
    /// <summary>
    ///   <para>eurio:GrantPayment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A single payment to a recipient or beneficiary of a Grant within a research project.</para>
    /// labels<para>Grant Payment</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#GrantPayment">http://data.europa.eu/s66#GrantPayment</seealso>
    let GrantPayment = Prefixed_Name(eurio, "GrantPayment") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasPaymentAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the payment to the amount of money that was given to the beneficiary of the payment.</para>
    /// labels<para>has payment amount</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasPaymentAmount">http://data.europa.eu/s66#hasPaymentAmount</seealso>
    let hasPaymentAmount = Prefixed_Name(eurio, "hasPaymentAmount") |> PrefixedName
    /// <summary>
    ///   <para>eurio:MonetaryAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A monetary value or range. This type can be used to describe an amount of money such as $50 USD, or a range as in describing a bank account being suitable for a balance between £1,000 and £1,000,000 GBP, or the value of a salary, etc.</para>
    /// labels<para>Monetary Amount</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#MonetaryAmount">http://data.europa.eu/s66#MonetaryAmount</seealso>
    let MonetaryAmount = Prefixed_Name(eurio, "MonetaryAmount") |> PrefixedName
    /// <summary>
    ///   <para>eurio:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The value of amount being expressed.</para>
    /// labels<para>value</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#value">http://data.europa.eu/s66#value</seealso>
    let value = Prefixed_Name(eurio, "value") |> PrefixedName

    /// <summary>
    ///   <para>eurio:NonPeerReviewedPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A work that hasn't undergone peer reviewing prior to its publication.</para>
    /// labels<para>Non Peer-Reviewed Publication</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#NonPeerReviewedPublication">http://data.europa.eu/s66#NonPeerReviewedPublication</seealso>
    let NonPeerReviewedPublication =
        Prefixed_Name(eurio, "NonPeerReviewedPublication") |> PrefixedName

    /// <summary>
    ///   <para>eurio:OrganisationRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Function assumed by or ascribed to an organisation that takes part in a particular project. In CORDIs, it represents roles such as coordinator, partner, consortium member, etc.</para>
    /// labels<para>Organisation Role</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#OrganisationRole">http://data.europa.eu/s66#OrganisationRole</seealso>
    let OrganisationRole = Prefixed_Name(eurio, "OrganisationRole") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the organisation to the roles that the organisation takes.</para>
    /// labels<para>has role</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasRole">http://data.europa.eu/s66#hasRole</seealso>
    let hasRole = Prefixed_Name(eurio, "hasRole") |> PrefixedName
    /// <summary>
    ///   <para>eurio:vatNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The unique number that identifies a taxable organisation or non-taxable legal entity that is registered for VAT.</para>
    /// labels<para>VAT number</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#vatNumber">http://data.europa.eu/s66#vatNumber</seealso>
    let vatNumber = Prefixed_Name(eurio, "vatNumber") |> PrefixedName
    /// <summary>
    ///   <para>eurio:rcn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Internal CORDIS identifier used for the identification of the domain entities (e.g., projects, project results, organisations, funding schemes, etc.). Stands for Resource Control Number.</para>
    /// labels<para>rcn</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#rcn">http://data.europa.eu/s66#rcn</seealso>
    let rcn = Prefixed_Name(eurio, "rcn") |> PrefixedName
    /// <summary>
    ///   <para>eurio:isRoleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the organisation role to the organisation which assumes the role.</para>
    /// labels<para>is role of</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#isRoleOf">http://data.europa.eu/s66#isRoleOf</seealso>
    let isRoleOf = Prefixed_Name(eurio, "isRoleOf") |> PrefixedName
    /// <summary>
    ///   <para>eurio:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The function assumed by or ascribed to an entity (typically an organisation) in a particular project. It can be used to precise or represent additional information about a relationship or property such as participation or membership. In CORDIS, it represents the participation of an organisation in a research project.</para>
    /// labels<para>Role</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#Role">http://data.europa.eu/s66#Role</seealso>
    let Role = Prefixed_Name(eurio, "Role") |> PrefixedName

    /// <summary>
    ///   <para>eurio:HigherOrSecondaryEducation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Institution that provides education.</para>
    /// labels<para>Higher Or Secondary Education</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#HigherOrSecondaryEducation">http://data.europa.eu/s66#HigherOrSecondaryEducation</seealso>
    let HigherOrSecondaryEducation =
        Prefixed_Name(eurio, "HigherOrSecondaryEducation") |> PrefixedName

    /// <summary>
    ///   <para>eurio:definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The definition of the acronym.</para>
    /// labels<para>definition</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#definition">http://data.europa.eu/s66#definition</seealso>
    let definition = Prefixed_Name(eurio, "definition") |> PrefixedName
    /// <summary>
    ///   <para>eurio:longitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The longitude of a location. For example -122.08585 (WGS 84).</para>
    /// labels<para>longitude</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#longitude">http://data.europa.eu/s66#longitude</seealso>
    let longitude = Prefixed_Name(eurio, "longitude") |> PrefixedName
    /// <summary>
    ///   <para>eurio:FundingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Set of rules and conditions which forms the basis for public funding of European research. In CORDIS, they represent the different legal frameworks (e.g. FP6, FP7, H2020). They can also be used to represent the different calls inside each framework by using the recursive relation “partOfScheme”.</para>
    /// labels<para>Funding Scheme</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#FundingScheme">http://data.europa.eu/s66#FundingScheme</seealso>
    let FundingScheme = Prefixed_Name(eurio, "FundingScheme") |> PrefixedName

    /// <summary>
    ///   <para>eurio:hasFundingSchemeCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A list of terms specifying the different categories / types of funding schemes.</para>
    /// labels<para>has funding scheme category</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasFundingSchemeCategory">http://data.europa.eu/s66#hasFundingSchemeCategory</seealso>
    let hasFundingSchemeCategory =
        Prefixed_Name(eurio, "hasFundingSchemeCategory") |> PrefixedName

    /// <summary>
    ///   <para>eurio:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The entity’s (e.g. project, work package, etc.) official name or title.</para>
    /// labels<para>title</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#title">http://data.europa.eu/s66#title</seealso>
    let title = Prefixed_Name(eurio, "title") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasFundingAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the grant or funding scheme to the amount of money available for funding.</para>
    /// labels<para>has funding amount</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasFundingAmount">http://data.europa.eu/s66#hasFundingAmount</seealso>
    let hasFundingAmount = Prefixed_Name(eurio, "hasFundingAmount") |> PrefixedName
    /// <summary>
    ///   <para>eurio:endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date on which an entity (e.g. project, grant, etc.) is finalized or ceases to exist.</para>
    /// labels<para>end date</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#endDate">http://data.europa.eu/s66#endDate</seealso>
    let endDate = Prefixed_Name(eurio, "endDate") |> PrefixedName
    /// <summary>
    ///   <para>eurio:fullAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The full address of a physical location of an entity.</para>
    /// labels<para>full address</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#fullAddress">http://data.europa.eu/s66#fullAddress</seealso>
    let fullAddress = Prefixed_Name(eurio, "fullAddress") |> PrefixedName
    /// <summary>
    ///   <para>eurio:Organisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a group of people, with the same purpose, organized together into a community or other social, commercial or political structure that participate in CORDIS projects.</para>
    /// labels<para>Organisation</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#Organisation">http://data.europa.eu/s66#Organisation</seealso>
    let Organisation = Prefixed_Name(eurio, "Organisation") |> PrefixedName
    /// <summary>
    ///   <para>eurio:PostalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The postal address of entities that participate in or form part of research projects.</para>
    /// labels<para>Postal Address</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#PostalAddress">http://data.europa.eu/s66#PostalAddress</seealso>
    let PostalAddress = Prefixed_Name(eurio, "PostalAddress") |> PrefixedName
    /// <summary>
    ///   <para>eurio:addressCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The country of the place or address. You can also provide the two-letter ISO 3166-1 alpha-2 country code.</para>
    /// labels<para>address country</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#addressCountry">http://data.europa.eu/s66#addressCountry</seealso>
    let addressCountry = Prefixed_Name(eurio, "addressCountry") |> PrefixedName
    /// <summary>
    ///   <para>eurio:addressLocality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The locality, town or city of the place or address.</para>
    /// labels<para>address locality</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#addressLocality">http://data.europa.eu/s66#addressLocality</seealso>
    let addressLocality = Prefixed_Name(eurio, "addressLocality") |> PrefixedName
    /// <summary>
    ///   <para>eurio:abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The general summary and ideas of a CORDIS entity, e.g., project, result.</para>
    /// labels<para>abstract</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#abstract">http://data.europa.eu/s66#abstract</seealso>
    let abstract_ = Prefixed_Name(eurio, "abstract") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasInvolvedParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the Project to the roles that are involved in the project.</para>
    /// labels<para>has involved party</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasInvolvedParty">http://data.europa.eu/s66#hasInvolvedParty</seealso>
    let hasInvolvedParty = Prefixed_Name(eurio, "hasInvolvedParty") |> PrefixedName
    /// <summary>
    ///   <para>eurio:projectStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The current status (signed, ongoing, terminated, etc.) of the project.</para>
    /// labels<para>project status</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#projectStatus">http://data.europa.eu/s66#projectStatus</seealso>
    let projectStatus = Prefixed_Name(eurio, "projectStatus") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasResultType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A list of terms specifying the types of results that can have a project.</para>
    /// labels<para>has result type</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasResultType">http://data.europa.eu/s66#hasResultType</seealso>
    let hasResultType = Prefixed_Name(eurio, "hasResultType") |> PrefixedName
    /// <summary>
    ///   <para>eurio:Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any tangible or intangible output of the project (such as data, knowledge and information, whatever their form or nature, whether or not they can be protected), which are generated in the project.</para>
    /// labels<para>Result</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#Result">http://data.europa.eu/s66#Result</seealso>
    let Result = Prefixed_Name(eurio, "Result") |> PrefixedName
    /// <summary>
    ///   <para>eurio:publishedYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The year of publication.</para>
    /// labels<para>published year</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#publishedYear">http://data.europa.eu/s66#publishedYear</seealso>
    let publishedYear = Prefixed_Name(eurio, "publishedYear") |> PrefixedName
    /// <summary>
    ///   <para>eurio:finalResults</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A brief description of the project findings.</para>
    /// labels<para>final results</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#finalResults">http://data.europa.eu/s66#finalResults</seealso>
    let finalResults = Prefixed_Name(eurio, "finalResults") |> PrefixedName
    /// <summary>
    ///   <para>eurio:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The internal CORDA identifier.</para>
    /// labels<para>identifier</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#identifier">http://data.europa.eu/s66#identifier</seealso>
    let identifier = Prefixed_Name(eurio, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a physical location to its registered address.</para>
    /// labels<para>has address</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasAddress">http://data.europa.eu/s66#hasAddress</seealso>
    let hasAddress = Prefixed_Name(eurio, "hasAddress") |> PrefixedName
    /// <summary>
    ///   <para>eurio:ProjectDeliverable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A document referring to the results obtained during the development of a project.</para>
    /// labels<para>Project Deliverable</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#ProjectDeliverable">http://data.europa.eu/s66#ProjectDeliverable</seealso>
    let ProjectDeliverable = Prefixed_Name(eurio, "ProjectDeliverable") |> PrefixedName
    /// <summary>
    ///   <para>eurio:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.europa.eu/s66#">http://data.europa.eu/s66#</seealso>
    let _prefix_iri = Prefixed_Name(eurio, "") |> PrefixedName
    /// <summary>
    ///   <para>eurio:FundingAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An organisation that materially administrates funding schemes and disburses related grants. In the context of CORDIS, it represents the various European agencies responsible for funding research projects (e.g. ERC, EASME, REA, etc.).</para>
    /// labels<para>Funding Agency</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#FundingAgency">http://data.europa.eu/s66#FundingAgency</seealso>
    let FundingAgency = Prefixed_Name(eurio, "FundingAgency") |> PrefixedName
    /// <summary>
    ///   <para>eurio:PublicBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Organisation or agency depending on a government, State or other supranational organisation and mainly operated by the government.</para>
    /// labels<para>Public Body</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#PublicBody">http://data.europa.eu/s66#PublicBody</seealso>
    let PublicBody = Prefixed_Name(eurio, "PublicBody") |> PrefixedName
    /// <summary>
    ///   <para>eurio:SME</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Small and Medium Enterprises.</para>
    /// labels<para>SME</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#SME">http://data.europa.eu/s66#SME</seealso>
    let SME = Prefixed_Name(eurio, "SME") |> PrefixedName
    /// <summary>
    ///   <para>eurio:ProceedingsPaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A paper, typically the realization of a research paper reporting original research findings, usually presented at a workshop and published within a workshop proceedings volume.</para>
    /// labels<para>Procedings Paper</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#ProceedingsPaper">http://data.europa.eu/s66#ProceedingsPaper</seealso>
    let ProceedingsPaper = Prefixed_Name(eurio, "ProceedingsPaper") |> PrefixedName
    /// <summary>
    ///   <para>eurio:Acronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An abbreviation formed from the initial letters of other words and pronounced as a word. It can refer to any type of entities in the CORDIS conceptual framework, and may be stated explicitly or extracted automatically from text.</para>
    /// labels<para>Acronym</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#Acronym">http://data.europa.eu/s66#Acronym</seealso>
    let Acronym = Prefixed_Name(eurio, "Acronym") |> PrefixedName
    /// <summary>
    ///   <para>eurio:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of an entity</para>
    /// labels<para>name</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#name">http://data.europa.eu/s66#name</seealso>
    let name = Prefixed_Name(eurio, "name") |> PrefixedName
    /// <summary>
    ///   <para>eurio:Coordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The geo coordinates for a location of entities that participate in or form part of research projects.</para>
    /// labels<para>Coordinates</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#Coordinates">http://data.europa.eu/s66#Coordinates</seealso>
    let Coordinates = Prefixed_Name(eurio, "Coordinates") |> PrefixedName
    /// <summary>
    ///   <para>eurio:latitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The latitude of a location. For example 37.42242 (WGS 84).</para>
    /// labels<para>latitude</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#latitude">http://data.europa.eu/s66#latitude</seealso>
    let latitude = Prefixed_Name(eurio, "latitude") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasEUCountryCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The country code of the location or address according to the EU country codes.</para>
    /// labels<para>has EU country code</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasEUCountryCode">http://data.europa.eu/s66#hasEUCountryCode</seealso>
    let hasEUCountryCode = Prefixed_Name(eurio, "hasEUCountryCode") |> PrefixedName
    /// <summary>
    ///   <para>eurio:DetectedAcronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any acronym that has been detected, automatically or manually, from the description of an entity or from any other form of natural language text.</para>
    /// labels<para>Detected Acronym</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#DetectedAcronym">http://data.europa.eu/s66#DetectedAcronym</seealso>
    let DetectedAcronym = Prefixed_Name(eurio, "DetectedAcronym") |> PrefixedName
    /// <summary>
    ///   <para>eurio:startDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The time an entity (e.g. project, grant, etc.) is initialized or starts to take effect.</para>
    /// labels<para>start date</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#startDate">http://data.europa.eu/s66#startDate</seealso>
    let startDate = Prefixed_Name(eurio, "startDate") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasBeneficiary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the grant to the organisation role(s) that are a beneficiary of the grant. </para>
    /// labels<para>has beneficiary</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasBeneficiary">http://data.europa.eu/s66#hasBeneficiary</seealso>
    let hasBeneficiary = Prefixed_Name(eurio, "hasBeneficiary") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasFundingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the grant to the funding scheme of which the grant forms a part.</para>
    /// labels<para>has funding scheme</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasFundingScheme">http://data.europa.eu/s66#hasFundingScheme</seealso>
    let hasFundingScheme = Prefixed_Name(eurio, "hasFundingScheme") |> PrefixedName
    /// <summary>
    ///   <para>eurio:funds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the grant with the project(s) that are completely or partially funded by it.</para>
    /// labels<para>funds</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#funds">http://data.europa.eu/s66#funds</seealso>
    let funds = Prefixed_Name(eurio, "funds") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>relates an organisation to its physical site</para>
    /// labels<para>has site</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasSite">http://data.europa.eu/s66#hasSite</seealso>
    let hasSite = Prefixed_Name(eurio, "hasSite") |> PrefixedName
    /// <summary>
    ///   <para>eurio:legalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The official name of the organization, e.g. the registered company name.</para>
    /// labels<para>legal name</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#legalName">http://data.europa.eu/s66#legalName</seealso>
    let legalName = Prefixed_Name(eurio, "legalName") |> PrefixedName
    /// <summary>
    ///   <para>eurio:OrganisationUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A department or unit which is part of some larger Organization and only has full recognition within the context of that Organization. In CORDIS, it represents for instance the different departments of a university that participate in a particular project.</para>
    /// labels<para>Organisation Unit</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#OrganisationUnit">http://data.europa.eu/s66#OrganisationUnit</seealso>
    let OrganisationUnit = Prefixed_Name(eurio, "OrganisationUnit") |> PrefixedName
    /// <summary>
    ///   <para>eurio:postalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The postal code of the place or address.</para>
    /// labels<para>postal code</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#postalCode">http://data.europa.eu/s66#postalCode</seealso>
    let postalCode = Prefixed_Name(eurio, "postalCode") |> PrefixedName
    /// <summary>
    ///   <para>eurio:streetAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The street name and number of the place or address.</para>
    /// labels<para>street address</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#streetAddress">http://data.europa.eu/s66#streetAddress</seealso>
    let streetAddress = Prefixed_Name(eurio, "streetAddress") |> PrefixedName
    /// <summary>
    ///   <para>eurio:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A planned research work that has one or more objectives (divided or not into tasks) and is conducted by one or more organisations. In CORDIS, it represents a project funded by an EU programme.</para>
    /// labels<para>Project</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#Project">http://data.europa.eu/s66#Project</seealso>
    let Project = Prefixed_Name(eurio, "Project") |> PrefixedName
    /// <summary>
    ///   <para>eurio:isFundedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the project with the grant(s) that completely or partially fund the project.</para>
    /// labels<para>is funded by</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#isFundedBy">http://data.europa.eu/s66#isFundedBy</seealso>
    let isFundedBy = Prefixed_Name(eurio, "isFundedBy") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasTotalCost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the project with the amount of money expected, required, or given in payment for the project.</para>
    /// labels<para>has total cost</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasTotalCost">http://data.europa.eu/s66#hasTotalCost</seealso>
    let hasTotalCost = Prefixed_Name(eurio, "hasTotalCost") |> PrefixedName
    /// <summary>
    ///   <para>eurio:doi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The digital object identifier of a publication.</para>
    /// labels<para>doi</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#doi">http://data.europa.eu/s66#doi</seealso>
    let doi = Prefixed_Name(eurio, "doi") |> PrefixedName
    /// <summary>
    ///   <para>eurio:signatureDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The day a grant agreement has been signed.</para>
    /// labels<para>signature date</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#signatureDate">http://data.europa.eu/s66#signatureDate</seealso>
    let signatureDate = Prefixed_Name(eurio, "signatureDate") |> PrefixedName
    /// <summary>
    ///   <para>eurio:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A brief summary of the entity (project, etc.).</para>
    /// labels<para>description</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#description">http://data.europa.eu/s66#description</seealso>
    let description = Prefixed_Name(eurio, "description") |> PrefixedName
    /// <summary>
    ///   <para>eurio:journalNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The journal number of a published result.</para>
    /// labels<para>journal number</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#journalNumber">http://data.europa.eu/s66#journalNumber</seealso>
    let journalNumber = Prefixed_Name(eurio, "journalNumber") |> PrefixedName
    /// <summary>
    ///   <para>eurio:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Represents the publishing body of a published result.</para>
    /// labels<para>publisher</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#publisher">http://data.europa.eu/s66#publisher</seealso>
    let publisher = Prefixed_Name(eurio, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>eurio:journalTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The title of the journal of a published result.</para>
    /// labels<para>journal title</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#journalTitle">http://data.europa.eu/s66#journalTitle</seealso>
    let journalTitle = Prefixed_Name(eurio, "journalTitle") |> PrefixedName
    /// <summary>
    ///   <para>eurio:author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The list of authors.</para>
    /// labels<para>author</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#author">http://data.europa.eu/s66#author</seealso>
    let author = Prefixed_Name(eurio, "author") |> PrefixedName
    /// <summary>
    ///   <para>eurio:publishedPages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The pages of a published result.</para>
    /// labels<para>published pages</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#publishedPages">http://data.europa.eu/s66#publishedPages</seealso>
    let publishedPages = Prefixed_Name(eurio, "publishedPages") |> PrefixedName
    /// <summary>
    ///   <para>eurio:workPerformed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A summary of the work carried out during the development of the project.</para>
    /// labels<para>work performed</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#workPerformed">http://data.europa.eu/s66#workPerformed</seealso>
    let workPerformed = Prefixed_Name(eurio, "workPerformed") |> PrefixedName
    /// <summary>
    ///   <para>eurio:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The language used in a project result.</para>
    /// labels<para>language</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#language">http://data.europa.eu/s66#language</seealso>
    let language = Prefixed_Name(eurio, "language") |> PrefixedName
    /// <summary>
    ///   <para>eurio:roleLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Title for capturing the role of an organisation.</para>
    /// labels<para>role label</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#roleLabel">http://data.europa.eu/s66#roleLabel</seealso>
    let roleLabel = Prefixed_Name(eurio, "roleLabel") |> PrefixedName
    /// <summary>
    ///   <para>eurio:isInvolvedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the role to the Project in which it is involved.</para>
    /// labels<para>is involved in</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#isInvolvedIn">http://data.europa.eu/s66#isInvolvedIn</seealso>
    let isInvolvedIn = Prefixed_Name(eurio, "isInvolvedIn") |> PrefixedName
    /// <summary>
    ///   <para>eurio:Site</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The physical extension of entities that participate in or form part of research projects.</para>
    /// labels<para>Site</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#Site">http://data.europa.eu/s66#Site</seealso>
    let Site = Prefixed_Name(eurio, "Site") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The geo-coordinates of a place</para>
    /// labels<para>has coordinates</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasCoordinates">http://data.europa.eu/s66#hasCoordinates</seealso>
    let hasCoordinates = Prefixed_Name(eurio, "hasCoordinates") |> PrefixedName

    /// <summary>
    ///   <para>eurio:hasGeographicalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The basic containment relation between a place and one that contains it</para>
    /// labels<para>has geographical location</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasGeographicalLocation">http://data.europa.eu/s66#hasGeographicalLocation</seealso>
    let hasGeographicalLocation =
        Prefixed_Name(eurio, "hasGeographicalLocation") |> PrefixedName

    /// <summary>
    ///   <para>eurio:isSiteOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates an entity which has presence at the given site</para>
    /// labels<para>is site of</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#isSiteOf">http://data.europa.eu/s66#isSiteOf</seealso>
    let isSiteOf = Prefixed_Name(eurio, "isSiteOf") |> PrefixedName
    /// <summary>
    ///   <para>eurio:ThesisDissertation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A book authored by a student containing a formal presentations of research outputs submitted for examination in completion of a course of study at an institution of higher education, to fulfil the requirements for an academic degree. Also know as a dissertation.</para>
    /// labels<para>Thesis Dissertation</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#ThesisDissertation">http://data.europa.eu/s66#ThesisDissertation</seealso>
    let ThesisDissertation = Prefixed_Name(eurio, "ThesisDissertation") |> PrefixedName
    /// <summary>
    ///   <para>eurio:code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A CORDA code.</para>
    /// labels<para>code</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#code">http://data.europa.eu/s66#code</seealso>
    let code = Prefixed_Name(eurio, "code") |> PrefixedName
    /// <summary>
    ///   <para>eurio:currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The currency in which the monetary amount is expressed.</para>
    /// labels<para>currency</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#currency">http://data.europa.eu/s66#currency</seealso>
    let currency = Prefixed_Name(eurio, "currency") |> PrefixedName
    /// <summary>
    ///   <para>eurio:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date in which the grant payment took place.</para>
    /// labels<para>date</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#date">http://data.europa.eu/s66#date</seealso>
    let date = Prefixed_Name(eurio, "date") |> PrefixedName
    /// <summary>
    ///   <para>eurio:disburses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the funding agency to the grant(s) that it disburses.</para>
    /// labels<para>disburses</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#disburses">http://data.europa.eu/s66#disburses</seealso>
    let disburses = Prefixed_Name(eurio, "disburses") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasAcronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an entity (e.g. project, grant, etc.) with its acronym(s). This includes acronyms representing the entity’s title as well as any additional acronyms extracted from other attributes of the entity.</para>
    /// labels<para>has acronym</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasAcronym">http://data.europa.eu/s66#hasAcronym</seealso>
    let hasAcronym = Prefixed_Name(eurio, "hasAcronym") |> PrefixedName
    /// <summary>
    ///   <para>eurio:isAcronymOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the acronym to the entity or entities to which it belongs.</para>
    /// labels<para>is acronym of</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#isAcronymOf">http://data.europa.eu/s66#isAcronymOf</seealso>
    let isAcronymOf = Prefixed_Name(eurio, "isAcronymOf") |> PrefixedName

    /// <summary>
    ///   <para>eurio:hasAssociatedFundingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an entity other than funding scheme (e.g., result, etc.) with associated funding schemes.</para>
    /// labels<para>has associated funding scheme</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasAssociatedFundingScheme">http://data.europa.eu/s66#hasAssociatedFundingScheme</seealso>
    let hasAssociatedFundingScheme =
        Prefixed_Name(eurio, "hasAssociatedFundingScheme") |> PrefixedName

    /// <summary>
    ///   <para>eurio:isBeneficiaryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the role to the grant(s) of which the role is a beneficiary.</para>
    /// labels<para>is beneficiary of</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#isBeneficiaryOf">http://data.europa.eu/s66#isBeneficiaryOf</seealso>
    let isBeneficiaryOf = Prefixed_Name(eurio, "isBeneficiaryOf") |> PrefixedName

    /// <summary>
    ///   <para>eurio:hasEuroSciVocClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>One or more values from the EuroSciVoc taxonomy that represent the main fields of science of the project.</para>
    /// labels<para>has EuroSciVoc classification</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasEuroSciVocClassification">http://data.europa.eu/s66#hasEuroSciVocClassification</seealso>
    let hasEuroSciVocClassification =
        Prefixed_Name(eurio, "hasEuroSciVocClassification") |> PrefixedName

    /// <summary>
    ///   <para>eurio:hasGrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a funding scheme with the grants that form part of it. </para>
    /// labels<para>has grant</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasGrant">http://data.europa.eu/s66#hasGrant</seealso>
    let hasGrant = Prefixed_Name(eurio, "hasGrant") |> PrefixedName

    /// <summary>
    ///   <para>eurio:hasFundingSchemeCall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the Call under which a project has been funded.</para>
    /// labels<para>has funding scheme call</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasFundingSchemeCall">http://data.europa.eu/s66#hasFundingSchemeCall</seealso>
    let hasFundingSchemeCall =
        Prefixed_Name(eurio, "hasFundingSchemeCall") |> PrefixedName

    /// <summary>
    ///   <para>eurio:hasFundingSchemeProgramme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the legal basis under which a project has been funded.</para>
    /// labels<para>has funding scheme programme</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasFundingSchemeProgramme">http://data.europa.eu/s66#hasFundingSchemeProgramme</seealso>
    let hasFundingSchemeProgramme =
        Prefixed_Name(eurio, "hasFundingSchemeProgramme") |> PrefixedName

    /// <summary>
    ///   <para>eurio:hasFundingSchemeTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the Topic under which a project has been funded.</para>
    /// labels<para>has funding scheme topic</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasFundingSchemeTopic">http://data.europa.eu/s66#hasFundingSchemeTopic</seealso>
    let hasFundingSchemeTopic =
        Prefixed_Name(eurio, "hasFundingSchemeTopic") |> PrefixedName

    /// <summary>
    ///   <para>eurio:hasFundingSchemeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the type of action under which a project has been funded.</para>
    /// labels<para>has funding scheme type</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasFundingSchemeType">http://data.europa.eu/s66#hasFundingSchemeType</seealso>
    let hasFundingSchemeType =
        Prefixed_Name(eurio, "hasFundingSchemeType") |> PrefixedName

    /// <summary>
    ///   <para>eurio:hasISOCountryCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The 2-digit ISO country code.</para>
    /// labels<para>has ISO country code</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasISOCountryCode">http://data.europa.eu/s66#hasISOCountryCode</seealso>
    let hasISOCountryCode = Prefixed_Name(eurio, "hasISOCountryCode") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasNUTS0code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A value representing the NUTS-0 code of the place or address.</para>
    /// labels<para>has NUTS 0 code</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasNUTS0code">http://data.europa.eu/s66#hasNUTS0code</seealso>
    let hasNUTS0code = Prefixed_Name(eurio, "hasNUTS0code") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasNUTSCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A value representing the NUTS code of the place or address.</para>
    /// labels<para>has NUTS code</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasNUTSCode">http://data.europa.eu/s66#hasNUTSCode</seealso>
    let hasNUTSCode = Prefixed_Name(eurio, "hasNUTSCode") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasNUTS1code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A value representing the NUTS-1 code of the place or address.</para>
    /// labels<para>has NUTS 1 code</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasNUTS1code">http://data.europa.eu/s66#hasNUTS1code</seealso>
    let hasNUTS1code = Prefixed_Name(eurio, "hasNUTS1code") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasNUTS2code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A value representing the NUTS-2 code of the place or address.</para>
    /// labels<para>has NUTS 2 code</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasNUTS2code">http://data.europa.eu/s66#hasNUTS2code</seealso>
    let hasNUTS2code = Prefixed_Name(eurio, "hasNUTS2code") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasNUTS3code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A value representing the NUTS-3 code of the place or address.</para>
    /// labels<para>has NUTS 3 code</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasNUTS3code">http://data.europa.eu/s66#hasNUTS3code</seealso>
    let hasNUTS3code = Prefixed_Name(eurio, "hasNUTS3code") |> PrefixedName

    /// <summary>
    ///   <para>eurio:hasNextFundingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a funding scheme with the next funding scheme.</para>
    /// labels<para>has next funding scheme</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasNextFundingScheme">http://data.europa.eu/s66#hasNextFundingScheme</seealso>
    let hasNextFundingScheme =
        Prefixed_Name(eurio, "hasNextFundingScheme") |> PrefixedName

    /// <summary>
    ///   <para>eurio:isPaymentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a payment to the grant of which it is a part.</para>
    /// labels<para>is payment of</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#isPaymentOf">http://data.europa.eu/s66#isPaymentOf</seealso>
    let isPaymentOf = Prefixed_Name(eurio, "isPaymentOf") |> PrefixedName

    /// <summary>
    ///   <para>eurio:hasPreviousFundingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a funding scheme with the previous funding scheme.</para>
    /// labels<para>has previous funding scheme</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasPreviousFundingScheme">http://data.europa.eu/s66#hasPreviousFundingScheme</seealso>
    let hasPreviousFundingScheme =
        Prefixed_Name(eurio, "hasPreviousFundingScheme") |> PrefixedName

    /// <summary>
    ///   <para>eurio:hasRecipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the grant payment to the organisation role(s) which have received the grant payment. Inverse property of isRecipientOf.</para>
    /// labels<para>has recipient</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasRecipient">http://data.europa.eu/s66#hasRecipient</seealso>
    let hasRecipient = Prefixed_Name(eurio, "hasRecipient") |> PrefixedName
    /// <summary>
    ///   <para>eurio:isRecipientOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the organisation role with the grant payment(s) which they have received. Inverse property of hasRecipient.</para>
    /// labels<para>is recipient of</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#isRecipientOf">http://data.europa.eu/s66#isRecipientOf</seealso>
    let isRecipientOf = Prefixed_Name(eurio, "isRecipientOf") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasRelatedProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Represents a generic non parent-child relation between two CORDIS projects.</para>
    /// labels<para>has related project</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasRelatedProject">http://data.europa.eu/s66#hasRelatedProject</seealso>
    let hasRelatedProject = Prefixed_Name(eurio, "hasRelatedProject") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasRelatedScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Represents a generic non parent-child relation between two funding schemes.</para>
    /// labels<para>has related scheme</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasRelatedScheme">http://data.europa.eu/s66#hasRelatedScheme</seealso>
    let hasRelatedScheme = Prefixed_Name(eurio, "hasRelatedScheme") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the project with its result(s).</para>
    /// labels<para>has result</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasResult">http://data.europa.eu/s66#hasResult</seealso>
    let hasResult = Prefixed_Name(eurio, "hasResult") |> PrefixedName
    /// <summary>
    ///   <para>eurio:isResultOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the results with the Project(s) involved.</para>
    /// labels<para>is result of</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#isResultOf">http://data.europa.eu/s66#isResultOf</seealso>
    let isResultOf = Prefixed_Name(eurio, "isResultOf") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasSubOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the organisation with another organisation which is a sub-part or child of it.</para>
    /// labels<para>has sub-organisation</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasSubOrganisation">http://data.europa.eu/s66#hasSubOrganisation</seealso>
    let hasSubOrganisation = Prefixed_Name(eurio, "hasSubOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>eurio:isSubOrganisationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the organisation with another organisation of which it is a sub-part.</para>
    /// labels<para>is sub-organisation of</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#isSubOrganisationOf">http://data.europa.eu/s66#isSubOrganisationOf</seealso>
    let isSubOrganisationOf =
        Prefixed_Name(eurio, "isSubOrganisationOf") |> PrefixedName

    /// <summary>
    ///   <para>eurio:hasSubScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the funding scheme to its sub-schemes.</para>
    /// labels<para>has subscheme</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasSubScheme">http://data.europa.eu/s66#hasSubScheme</seealso>
    let hasSubScheme = Prefixed_Name(eurio, "hasSubScheme") |> PrefixedName
    /// <summary>
    ///   <para>eurio:isSubSchemeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the funding scheme to its parent scheme of which this funding scheme forms a part. </para>
    /// labels<para>is subscheme of</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#isSubSchemeOf">http://data.europa.eu/s66#isSubSchemeOf</seealso>
    let isSubSchemeOf = Prefixed_Name(eurio, "isSubSchemeOf") |> PrefixedName
    /// <summary>
    ///   <para>eurio:hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the organisation with a unit or department that forms part of the organisation.</para>
    /// labels<para>has unit</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#hasUnit">http://data.europa.eu/s66#hasUnit</seealso>
    let hasUnit = Prefixed_Name(eurio, "hasUnit") |> PrefixedName
    /// <summary>
    ///   <para>eurio:isUnitOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the unit to the organisation of which the unit forms a part. </para>
    /// labels<para>is unit of</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#isUnitOf">http://data.europa.eu/s66#isUnitOf</seealso>
    let isUnitOf = Prefixed_Name(eurio, "isUnitOf") |> PrefixedName
    /// <summary>
    ///   <para>eurio:implements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a funding agency to the funding schemes that it implements and administers.</para>
    /// labels<para>implements</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#implements">http://data.europa.eu/s66#implements</seealso>
    let implements = Prefixed_Name(eurio, "implements") |> PrefixedName
    /// <summary>
    ///   <para>eurio:isbn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The international standard book number of book publications.</para>
    /// labels<para>isbn</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#isbn">http://data.europa.eu/s66#isbn</seealso>
    let isbn = Prefixed_Name(eurio, "isbn") |> PrefixedName
    /// <summary>
    ///   <para>eurio:issn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The international standard serial number of journal publications.</para>
    /// labels<para>issn</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#issn">http://data.europa.eu/s66#issn</seealso>
    let issn = Prefixed_Name(eurio, "issn") |> PrefixedName
    /// <summary>
    ///   <para>eurio:keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Word or words that represent the main idea of a referred entity (e.g., project. project result, etc.)</para>
    /// labels<para>keyword</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#keyword">http://data.europa.eu/s66#keyword</seealso>
    let keyword = Prefixed_Name(eurio, "keyword") |> PrefixedName
    /// <summary>
    ///   <para>eurio:order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://data.europa.eu/s66#order">http://data.europa.eu/s66#order</seealso>
    let order = Prefixed_Name(eurio, "order") |> PrefixedName
    /// <summary>
    ///   <para>eurio:periodFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date that the reporting period started.</para>
    /// labels<para>period from</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#periodFrom">http://data.europa.eu/s66#periodFrom</seealso>
    let periodFrom = Prefixed_Name(eurio, "periodFrom") |> PrefixedName
    /// <summary>
    ///   <para>eurio:periodNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of the reporting period.</para>
    /// labels<para>period number</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#periodNumber">http://data.europa.eu/s66#periodNumber</seealso>
    let periodNumber = Prefixed_Name(eurio, "periodNumber") |> PrefixedName
    /// <summary>
    ///   <para>eurio:periodTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date that the reporting period ended.</para>
    /// labels<para>period to</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#periodTo">http://data.europa.eu/s66#periodTo</seealso>
    let periodTo = Prefixed_Name(eurio, "periodTo") |> PrefixedName

    /// <summary>
    ///   <para>eurio:postOfficeBoxNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The post office box number for PO box addresses.</para>
    /// labels<para>post office box number</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#postOfficeBoxNumber">http://data.europa.eu/s66#postOfficeBoxNumber</seealso>
    let postOfficeBoxNumber =
        Prefixed_Name(eurio, "postOfficeBoxNumber") |> PrefixedName

    /// <summary>
    ///   <para>eurio:refersTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The entity to which this acronym refers. This can either be an entity inside of the knowledge graph or an external entity of any type.</para>
    /// labels<para>refers to</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#refersTo">http://data.europa.eu/s66#refersTo</seealso>
    let refersTo = Prefixed_Name(eurio, "refersTo") |> PrefixedName
    /// <summary>
    ///   <para>eurio:terminationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The termination date of a project.</para>
    /// labels<para>termination date</para></remarks>
    /// <seealso href="http://data.europa.eu/s66#terminationDate">http://data.europa.eu/s66#terminationDate</seealso>
    let terminationDate = Prefixed_Name(eurio, "terminationDate") |> PrefixedName
