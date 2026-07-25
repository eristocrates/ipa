namespace http.vivoweb.org.ontology.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vivo =
    let _namespace_iri = Namespace_Iri vivo |> NamespaceIRI
    /// <summary>
    ///   <para>vivo:PostdocPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Postdoctoral Position</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#PostdocPosition">http://vivoweb.org/ontology/core#PostdocPosition</seealso>
    let PostdocPosition = Prefixed_Name(vivo, "PostdocPosition") |> PrefixedName

    /// <summary>
    ///   <para>vivo:PostdoctoralTraining</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Postdoctoral Training</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#PostdoctoralTraining">http://vivoweb.org/ontology/core#PostdoctoralTraining</seealso>
    let PostdoctoralTraining =
        Prefixed_Name(vivo, "PostdoctoralTraining") |> PrefixedName

    /// <summary>
    ///   <para>vivo:Room</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Room</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Room">http://vivoweb.org/ontology/core#Room</seealso>
    let Room = Prefixed_Name(vivo, "Room") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Facility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Facility</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Facility">http://vivoweb.org/ontology/core#Facility</seealso>
    let Facility = Prefixed_Name(vivo, "Facility") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Campus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Campus</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Campus">http://vivoweb.org/ontology/core#Campus</seealso>
    let Campus = Prefixed_Name(vivo, "Campus") |> PrefixedName
    /// <summary>
    ///   <para>vivo:CaseStudy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Case Study</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#CaseStudy">http://vivoweb.org/ontology/core#CaseStudy</seealso>
    let CaseStudy = Prefixed_Name(vivo, "CaseStudy") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Certificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Certificate</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Certificate">http://vivoweb.org/ontology/core#Certificate</seealso>
    let Certificate = Prefixed_Name(vivo, "Certificate") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Credential</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Credential</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Credential">http://vivoweb.org/ontology/core#Credential</seealso>
    let Credential = Prefixed_Name(vivo, "Credential") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Certification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Certification</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Certification">http://vivoweb.org/ontology/core#Certification</seealso>
    let Certification = Prefixed_Name(vivo, "Certification") |> PrefixedName
    /// <summary>
    ///   <para>vivo:ClinicalRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Clinical Role</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#ClinicalRole">http://vivoweb.org/ontology/core#ClinicalRole</seealso>
    let ClinicalRole = Prefixed_Name(vivo, "ClinicalRole") |> PrefixedName

    /// <summary>
    ///   <para>vivo:CoPrincipalInvestigatorRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Co-Principal Investigator Role</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#CoPrincipalInvestigatorRole">http://vivoweb.org/ontology/core#CoPrincipalInvestigatorRole</seealso>
    let CoPrincipalInvestigatorRole =
        Prefixed_Name(vivo, "CoPrincipalInvestigatorRole") |> PrefixedName

    /// <summary>
    ///   <para>vivo:cclCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>published US Classification Class/subclass (CCL) code</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#cclCode">http://vivoweb.org/ontology/core#cclCode</seealso>
    let cclCode = Prefixed_Name(vivo, "cclCode") |> PrefixedName

    /// <summary>
    ///   <para>vivo:conceptAssociatedWith</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>concept for</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#conceptAssociatedWith">http://vivoweb.org/ontology/core#conceptAssociatedWith</seealso>
    let conceptAssociatedWith =
        Prefixed_Name(vivo, "conceptAssociatedWith") |> PrefixedName

    /// <summary>
    ///   <para>vivo:contributingRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>contributor</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#contributingRole">http://vivoweb.org/ontology/core#contributingRole</seealso>
    let contributingRole = Prefixed_Name(vivo, "contributingRole") |> PrefixedName
    /// <summary>
    ///   <para>vivo:roleContributesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>contributes to</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#roleContributesTo">http://vivoweb.org/ontology/core#roleContributesTo</seealso>
    let roleContributesTo = Prefixed_Name(vivo, "roleContributesTo") |> PrefixedName
    /// <summary>
    ///   <para>vivo:freetextKeyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>keywords</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#freetextKeyword">http://vivoweb.org/ontology/core#freetextKeyword</seealso>
    let freetextKeyword = Prefixed_Name(vivo, "freetextKeyword") |> PrefixedName
    /// <summary>
    ///   <para>vivo:hasSubjectArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has subject area</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#hasSubjectArea">http://vivoweb.org/ontology/core#hasSubjectArea</seealso>
    let hasSubjectArea = Prefixed_Name(vivo, "hasSubjectArea") |> PrefixedName
    /// <summary>
    ///   <para>vivo:dateTimeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>date/time value</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#dateTimeValue">http://vivoweb.org/ontology/core#dateTimeValue</seealso>
    let dateTimeValue = Prefixed_Name(vivo, "dateTimeValue") |> PrefixedName
    /// <summary>
    ///   <para>vivo:DateTimeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Date/Time Value</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#DateTimeValue">http://vivoweb.org/ontology/core#DateTimeValue</seealso>
    let DateTimeValue = Prefixed_Name(vivo, "DateTimeValue") |> PrefixedName
    /// <summary>
    ///   <para>vivo:County</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>County</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#County">http://vivoweb.org/ontology/core#County</seealso>
    let County = Prefixed_Name(vivo, "County") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Course</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Course</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Course">http://vivoweb.org/ontology/core#Course</seealso>
    let Course = Prefixed_Name(vivo, "Course") |> PrefixedName
    /// <summary>
    ///   <para>vivo:courseCredits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>credits</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#courseCredits">http://vivoweb.org/ontology/core#courseCredits</seealso>
    let courseCredits = Prefixed_Name(vivo, "courseCredits") |> PrefixedName
    /// <summary>
    ///   <para>vivo:prerequisiteFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>prerequisite for</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#prerequisiteFor">http://vivoweb.org/ontology/core#prerequisiteFor</seealso>
    let prerequisiteFor = Prefixed_Name(vivo, "prerequisiteFor") |> PrefixedName
    /// <summary>
    ///   <para>vivo:hasProceedings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>proceedings</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#hasProceedings">http://vivoweb.org/ontology/core#hasProceedings</seealso>
    let hasProceedings = Prefixed_Name(vivo, "hasProceedings") |> PrefixedName
    /// <summary>
    ///   <para>vivo:publicationVenueFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>publication venue for</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#publicationVenueFor">http://vivoweb.org/ontology/core#publicationVenueFor</seealso>
    let publicationVenueFor = Prefixed_Name(vivo, "publicationVenueFor") |> PrefixedName
    /// <summary>
    ///   <para>vivo:hasResearchArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>research areas</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#hasResearchArea">http://vivoweb.org/ontology/core#hasResearchArea</seealso>
    let hasResearchArea = Prefixed_Name(vivo, "hasResearchArea") |> PrefixedName
    /// <summary>
    ///   <para>vivo:researchAreaOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>research area of</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#researchAreaOf">http://vivoweb.org/ontology/core#researchAreaOf</seealso>
    let researchAreaOf = Prefixed_Name(vivo, "researchAreaOf") |> PrefixedName
    /// <summary>
    ///   <para>vivo:subjectAreaOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>subject area of</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#subjectAreaOf">http://vivoweb.org/ontology/core#subjectAreaOf</seealso>
    let subjectAreaOf = Prefixed_Name(vivo, "subjectAreaOf") |> PrefixedName
    /// <summary>
    ///   <para>vivo:hasTranslation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has translation</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#hasTranslation">http://vivoweb.org/ontology/core#hasTranslation</seealso>
    let hasTranslation = Prefixed_Name(vivo, "hasTranslation") |> PrefixedName
    /// <summary>
    ///   <para>vivo:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has value</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#hasValue">http://vivoweb.org/ontology/core#hasValue</seealso>
    let hasValue = Prefixed_Name(vivo, "hasValue") |> PrefixedName

    /// <summary>
    ///   <para>vivo:informationResourceSupportedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>supported by</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#informationResourceSupportedBy">http://vivoweb.org/ontology/core#informationResourceSupportedBy</seealso>
    let informationResourceSupportedBy =
        Prefixed_Name(vivo, "informationResourceSupportedBy") |> PrefixedName

    /// <summary>
    ///   <para>vivo:supportedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>supported by</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#supportedBy">http://vivoweb.org/ontology/core#supportedBy</seealso>
    let supportedBy = Prefixed_Name(vivo, "supportedBy") |> PrefixedName
    /// <summary>
    ///   <para>vivo:invited</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bibo:DocumentStatus</para>
    ///
    /// labels<para>invited</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#invited">http://vivoweb.org/ontology/core#invited</seealso>
    let invited = Prefixed_Name(vivo, "invited") |> PrefixedName

    /// <summary>
    ///   <para>vivo:isCorrespondingAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Is this person a corresponding author?</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#isCorrespondingAuthor">http://vivoweb.org/ontology/core#isCorrespondingAuthor</seealso>
    let isCorrespondingAuthor =
        Prefixed_Name(vivo, "isCorrespondingAuthor") |> PrefixedName

    /// <summary>
    ///   <para>vivo:licenseNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>license number</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#licenseNumber">http://vivoweb.org/ontology/core#licenseNumber</seealso>
    let licenseNumber = Prefixed_Name(vivo, "licenseNumber") |> PrefixedName
    /// <summary>
    ///   <para>vivo:localAwardId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>local award ID</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#localAwardId">http://vivoweb.org/ontology/core#localAwardId</seealso>
    let localAwardId = Prefixed_Name(vivo, "localAwardId") |> PrefixedName
    /// <summary>
    ///   <para>vivo:majorField</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>major field of degree</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#majorField">http://vivoweb.org/ontology/core#majorField</seealso>
    let majorField = Prefixed_Name(vivo, "majorField") |> PrefixedName
    /// <summary>
    ///   <para>vivo:middleName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>middle name or initial</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#middleName">http://vivoweb.org/ontology/core#middleName</seealso>
    let middleName = Prefixed_Name(vivo, "middleName") |> PrefixedName
    /// <summary>
    ///   <para>vivo:nihmsid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>NIH Manuscript Submission System ID</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#nihmsid">http://vivoweb.org/ontology/core#nihmsid</seealso>
    let nihmsid = Prefixed_Name(vivo, "nihmsid") |> PrefixedName
    /// <summary>
    ///   <para>vivo:offeredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>offered by</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#offeredBy">http://vivoweb.org/ontology/core#offeredBy</seealso>
    let offeredBy = Prefixed_Name(vivo, "offeredBy") |> PrefixedName
    /// <summary>
    ///   <para>vivo:offers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>offers</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#offers">http://vivoweb.org/ontology/core#offers</seealso>
    let offers = Prefixed_Name(vivo, "offers") |> PrefixedName
    /// <summary>
    ///   <para>vivo:orcidId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ORCID iD</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#orcidId">http://vivoweb.org/ontology/core#orcidId</seealso>
    let orcidId = Prefixed_Name(vivo, "orcidId") |> PrefixedName
    /// <summary>
    ///   <para>vivo:overview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>overview</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#overview">http://vivoweb.org/ontology/core#overview</seealso>
    let overview = Prefixed_Name(vivo, "overview") |> PrefixedName
    /// <summary>
    ///   <para>vivo:patentNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>patent number</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#patentNumber">http://vivoweb.org/ontology/core#patentNumber</seealso>
    let patentNumber = Prefixed_Name(vivo, "patentNumber") |> PrefixedName
    /// <summary>
    ///   <para>vivo:pmcid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>PubMed Central ID</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#pmcid">http://vivoweb.org/ontology/core#pmcid</seealso>
    let pmcid = Prefixed_Name(vivo, "pmcid") |> PrefixedName

    /// <summary>
    ///   <para>vivo:preferredDisplayOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>preferred display order</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#preferredDisplayOrder">http://vivoweb.org/ontology/core#preferredDisplayOrder</seealso>
    let preferredDisplayOrder =
        Prefixed_Name(vivo, "preferredDisplayOrder") |> PrefixedName

    /// <summary>
    ///   <para>vivo:proceedingsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>proceedings of</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#proceedingsOf">http://vivoweb.org/ontology/core#proceedingsOf</seealso>
    let proceedingsOf = Prefixed_Name(vivo, "proceedingsOf") |> PrefixedName
    /// <summary>
    ///   <para>vivo:publisherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>publisher of</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#publisherOf">http://vivoweb.org/ontology/core#publisherOf</seealso>
    let publisherOf = Prefixed_Name(vivo, "publisherOf") |> PrefixedName
    /// <summary>
    ///   <para>vivo:relatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>related by</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#relatedBy">http://vivoweb.org/ontology/core#relatedBy</seealso>
    let relatedBy = Prefixed_Name(vivo, "relatedBy") |> PrefixedName
    /// <summary>
    ///   <para>vivo:reportId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>report identifier</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#reportId">http://vivoweb.org/ontology/core#reportId</seealso>
    let reportId = Prefixed_Name(vivo, "reportId") |> PrefixedName
    /// <summary>
    ///   <para>vivo:reproduces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>reproduces</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#reproduces">http://vivoweb.org/ontology/core#reproduces</seealso>
    let reproduces = Prefixed_Name(vivo, "reproduces") |> PrefixedName
    /// <summary>
    ///   <para>vivo:ConferenceSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Conference Series</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#ConferenceSeries">http://vivoweb.org/ontology/core#ConferenceSeries</seealso>
    let ConferenceSeries = Prefixed_Name(vivo, "ConferenceSeries") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Continent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Continent</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Continent">http://vivoweb.org/ontology/core#Continent</seealso>
    let Continent = Prefixed_Name(vivo, "Continent") |> PrefixedName

    /// <summary>
    ///   <para>vivo:supportedInformationResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>supported publications or other works</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#supportedInformationResource">http://vivoweb.org/ontology/core#supportedInformationResource</seealso>
    let supportedInformationResource =
        Prefixed_Name(vivo, "supportedInformationResource") |> PrefixedName

    /// <summary>
    ///   <para>vivo:hasCollaborator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has collaborator</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#hasCollaborator">http://vivoweb.org/ontology/core#hasCollaborator</seealso>
    let hasCollaborator = Prefixed_Name(vivo, "hasCollaborator") |> PrefixedName
    /// <summary>
    ///   <para>vivo:hasEquipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has equipment</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#hasEquipment">http://vivoweb.org/ontology/core#hasEquipment</seealso>
    let hasEquipment = Prefixed_Name(vivo, "hasEquipment") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Catalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Catalog</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Catalog">http://vivoweb.org/ontology/core#Catalog</seealso>
    let Catalog = Prefixed_Name(vivo, "Catalog") |> PrefixedName
    /// <summary>
    ///   <para>vivo:IssuedCredential</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Issued Credential</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#IssuedCredential">http://vivoweb.org/ontology/core#IssuedCredential</seealso>
    let IssuedCredential = Prefixed_Name(vivo, "IssuedCredential") |> PrefixedName

    /// <summary>
    ///   <para>vivo:ClinicalOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Clinical Organization</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#ClinicalOrganization">http://vivoweb.org/ontology/core#ClinicalOrganization</seealso>
    let ClinicalOrganization =
        Prefixed_Name(vivo, "ClinicalOrganization") |> PrefixedName

    /// <summary>
    ///   <para>vivo:InvestigatorRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Investigator Role</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#InvestigatorRole">http://vivoweb.org/ontology/core#InvestigatorRole</seealso>
    let InvestigatorRole = Prefixed_Name(vivo, "InvestigatorRole") |> PrefixedName
    /// <summary>
    ///   <para>vivo:College</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>College</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#College">http://vivoweb.org/ontology/core#College</seealso>
    let College = Prefixed_Name(vivo, "College") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Company</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Company</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Company">http://vivoweb.org/ontology/core#Company</seealso>
    let Company = Prefixed_Name(vivo, "Company") |> PrefixedName
    /// <summary>
    ///   <para>vivo:ConferencePoster</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Conference Poster</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#ConferencePoster">http://vivoweb.org/ontology/core#ConferencePoster</seealso>
    let ConferencePoster = Prefixed_Name(vivo, "ConferencePoster") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Contract</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Contract">http://vivoweb.org/ontology/core#Contract</seealso>
    let Contract = Prefixed_Name(vivo, "Contract") |> PrefixedName
    /// <summary>
    ///   <para>vivo:CoreLaboratory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Core Laboratory</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#CoreLaboratory">http://vivoweb.org/ontology/core#CoreLaboratory</seealso>
    let CoreLaboratory = Prefixed_Name(vivo, "CoreLaboratory") |> PrefixedName

    /// <summary>
    ///   <para>vivo:ServiceProvidingLaboratory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Service Providing Lab</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#ServiceProvidingLaboratory">http://vivoweb.org/ontology/core#ServiceProvidingLaboratory</seealso>
    let ServiceProvidingLaboratory =
        Prefixed_Name(vivo, "ServiceProvidingLaboratory") |> PrefixedName

    /// <summary>
    ///   <para>vivo:hasMonetaryAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has monetary amount</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#hasMonetaryAmount">http://vivoweb.org/ontology/core#hasMonetaryAmount</seealso>
    let hasMonetaryAmount = Prefixed_Name(vivo, "hasMonetaryAmount") |> PrefixedName

    /// <summary>
    ///   <para>vivo:hasPredecessorOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>predecessor organization</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#hasPredecessorOrganization">http://vivoweb.org/ontology/core#hasPredecessorOrganization</seealso>
    let hasPredecessorOrganization =
        Prefixed_Name(vivo, "hasPredecessorOrganization") |> PrefixedName

    /// <summary>
    ///   <para>vivo:hasSuccessorOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>successor organization</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#hasSuccessorOrganization">http://vivoweb.org/ontology/core#hasSuccessorOrganization</seealso>
    let hasSuccessorOrganization =
        Prefixed_Name(vivo, "hasSuccessorOrganization") |> PrefixedName

    /// <summary>
    ///   <para>vivo:hasPrerequisite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has prerequisite</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#hasPrerequisite">http://vivoweb.org/ontology/core#hasPrerequisite</seealso>
    let hasPrerequisite = Prefixed_Name(vivo, "hasPrerequisite") |> PrefixedName
    /// <summary>
    ///   <para>vivo:geographicFocus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>geographic focus</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#geographicFocus">http://vivoweb.org/ontology/core#geographicFocus</seealso>
    let geographicFocus = Prefixed_Name(vivo, "geographicFocus") |> PrefixedName
    /// <summary>
    ///   <para>vivo:assignee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>assignee</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#assignee">http://vivoweb.org/ontology/core#assignee</seealso>
    let assignee = Prefixed_Name(vivo, "assignee") |> PrefixedName
    /// <summary>
    ///   <para>vivo:assigneeFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>assignee for patent</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#assigneeFor">http://vivoweb.org/ontology/core#assigneeFor</seealso>
    let assigneeFor = Prefixed_Name(vivo, "assigneeFor") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Committee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Committee</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Committee">http://vivoweb.org/ontology/core#Committee</seealso>
    let Committee = Prefixed_Name(vivo, "Committee") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Competition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Competition</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Competition">http://vivoweb.org/ontology/core#Competition</seealso>
    let Competition = Prefixed_Name(vivo, "Competition") |> PrefixedName
    /// <summary>
    ///   <para>vivo:ConferencePaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Conference Paper</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#ConferencePaper">http://vivoweb.org/ontology/core#ConferencePaper</seealso>
    let ConferencePaper = Prefixed_Name(vivo, "ConferencePaper") |> PrefixedName
    /// <summary>
    ///   <para>vivo:EventSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Event Series</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#EventSeries">http://vivoweb.org/ontology/core#EventSeries</seealso>
    let EventSeries = Prefixed_Name(vivo, "EventSeries") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Consortium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Consortium</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Consortium">http://vivoweb.org/ontology/core#Consortium</seealso>
    let Consortium = Prefixed_Name(vivo, "Consortium") |> PrefixedName
    /// <summary>
    ///   <para>vivo:GeographicLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Geographic Location</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#GeographicLocation">http://vivoweb.org/ontology/core#GeographicLocation</seealso>
    let GeographicLocation = Prefixed_Name(vivo, "GeographicLocation") |> PrefixedName
    /// <summary>
    ///   <para>vivo:hasPublicationVenue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>published in</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#hasPublicationVenue">http://vivoweb.org/ontology/core#hasPublicationVenue</seealso>
    let hasPublicationVenue = Prefixed_Name(vivo, "hasPublicationVenue") |> PrefixedName
    /// <summary>
    ///   <para>vivo:placeOfPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>place of publication</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#placeOfPublication">http://vivoweb.org/ontology/core#placeOfPublication</seealso>
    let placeOfPublication = Prefixed_Name(vivo, "placeOfPublication") |> PrefixedName
    /// <summary>
    ///   <para>vivo:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>publisher</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#publisher">http://vivoweb.org/ontology/core#publisher</seealso>
    let publisher = Prefixed_Name(vivo, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>vivo:abbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>abbreviation</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#abbreviation">http://vivoweb.org/ontology/core#abbreviation</seealso>
    let abbreviation = Prefixed_Name(vivo, "abbreviation") |> PrefixedName
    /// <summary>
    ///   <para>vivo:features</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>features</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#features">http://vivoweb.org/ontology/core#features</seealso>
    let features = Prefixed_Name(vivo, "features") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Dataset</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Dataset">http://vivoweb.org/ontology/core#Dataset</seealso>
    let Dataset = Prefixed_Name(vivo, "Dataset") |> PrefixedName
    /// <summary>
    ///   <para>vivo:dateIssued</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>date issued</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#dateIssued">http://vivoweb.org/ontology/core#dateIssued</seealso>
    let dateIssued = Prefixed_Name(vivo, "dateIssued") |> PrefixedName
    /// <summary>
    ///   <para>vivo:AcademicDegree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Academic Degree</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#AcademicDegree">http://vivoweb.org/ontology/core#AcademicDegree</seealso>
    let AcademicDegree = Prefixed_Name(vivo, "AcademicDegree") |> PrefixedName
    /// <summary>
    ///   <para>vivo:reviewedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>reviewed in</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#reviewedIn">http://vivoweb.org/ontology/core#reviewedIn</seealso>
    let reviewedIn = Prefixed_Name(vivo, "reviewedIn") |> PrefixedName
    /// <summary>
    ///   <para>vivo:translatorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>translator of</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#translatorOf">http://vivoweb.org/ontology/core#translatorOf</seealso>
    let translatorOf = Prefixed_Name(vivo, "translatorOf") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Abstract</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Abstract">http://vivoweb.org/ontology/core#Abstract</seealso>
    let Abstract = Prefixed_Name(vivo, "Abstract") |> PrefixedName
    /// <summary>
    ///   <para>vivo:AcademicDepartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Academic Department</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#AcademicDepartment">http://vivoweb.org/ontology/core#AcademicDepartment</seealso>
    let AcademicDepartment = Prefixed_Name(vivo, "AcademicDepartment") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Department</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Department</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Department">http://vivoweb.org/ontology/core#Department</seealso>
    let Department = Prefixed_Name(vivo, "Department") |> PrefixedName
    /// <summary>
    ///   <para>vivo:AcademicTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Academic Term</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#AcademicTerm">http://vivoweb.org/ontology/core#AcademicTerm</seealso>
    let AcademicTerm = Prefixed_Name(vivo, "AcademicTerm") |> PrefixedName
    /// <summary>
    ///   <para>vivo:AcademicYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Academic Year</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#AcademicYear">http://vivoweb.org/ontology/core#AcademicYear</seealso>
    let AcademicYear = Prefixed_Name(vivo, "AcademicYear") |> PrefixedName
    /// <summary>
    ///   <para>vivo:AdministratorRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Administrator Role</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#AdministratorRole">http://vivoweb.org/ontology/core#AdministratorRole</seealso>
    let AdministratorRole = Prefixed_Name(vivo, "AdministratorRole") |> PrefixedName
    /// <summary>
    ///   <para>vivo:AdviseeRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Advisee Role</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#AdviseeRole">http://vivoweb.org/ontology/core#AdviseeRole</seealso>
    let AdviseeRole = Prefixed_Name(vivo, "AdviseeRole") |> PrefixedName
    /// <summary>
    ///   <para>vivo:AdvisingProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Advising Process</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#AdvisingProcess">http://vivoweb.org/ontology/core#AdvisingProcess</seealso>
    let AdvisingProcess = Prefixed_Name(vivo, "AdvisingProcess") |> PrefixedName

    /// <summary>
    ///   <para>vivo:AdvisingRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Advising Relationship</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#AdvisingRelationship">http://vivoweb.org/ontology/core#AdvisingRelationship</seealso>
    let AdvisingRelationship =
        Prefixed_Name(vivo, "AdvisingRelationship") |> PrefixedName

    /// <summary>
    ///   <para>vivo:relates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>relates</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#relates">http://vivoweb.org/ontology/core#relates</seealso>
    let relates = Prefixed_Name(vivo, "relates") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Relationship</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Relationship">http://vivoweb.org/ontology/core#Relationship</seealso>
    let Relationship = Prefixed_Name(vivo, "Relationship") |> PrefixedName
    /// <summary>
    ///   <para>vivo:AdvisorRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Advisor Role</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#AdvisorRole">http://vivoweb.org/ontology/core#AdvisorRole</seealso>
    let AdvisorRole = Prefixed_Name(vivo, "AdvisorRole") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Association</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Association</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Association">http://vivoweb.org/ontology/core#Association</seealso>
    let Association = Prefixed_Name(vivo, "Association") |> PrefixedName
    /// <summary>
    ///   <para>vivo:PrivateCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Private Company</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#PrivateCompany">http://vivoweb.org/ontology/core#PrivateCompany</seealso>
    let PrivateCompany = Prefixed_Name(vivo, "PrivateCompany") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Program</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Program</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Program">http://vivoweb.org/ontology/core#Program</seealso>
    let Program = Prefixed_Name(vivo, "Program") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Publisher</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Publisher">http://vivoweb.org/ontology/core#Publisher</seealso>
    let Publisher = Prefixed_Name(vivo, "Publisher") |> PrefixedName

    /// <summary>
    ///   <para>vivo:ResearchOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Research Organization</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#ResearchOrganization">http://vivoweb.org/ontology/core#ResearchOrganization</seealso>
    let ResearchOrganization =
        Prefixed_Name(vivo, "ResearchOrganization") |> PrefixedName

    /// <summary>
    ///   <para>vivo:ResearchProposal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Research Proposal</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#ResearchProposal">http://vivoweb.org/ontology/core#ResearchProposal</seealso>
    let ResearchProposal = Prefixed_Name(vivo, "ResearchProposal") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Review</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Review</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Review">http://vivoweb.org/ontology/core#Review</seealso>
    let Review = Prefixed_Name(vivo, "Review") |> PrefixedName
    /// <summary>
    ///   <para>vivo:School</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>School</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#School">http://vivoweb.org/ontology/core#School</seealso>
    let School = Prefixed_Name(vivo, "School") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Score</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Score</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Score">http://vivoweb.org/ontology/core#Score</seealso>
    let Score = Prefixed_Name(vivo, "Score") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Screenplay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Screenplay</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Screenplay">http://vivoweb.org/ontology/core#Screenplay</seealso>
    let Screenplay = Prefixed_Name(vivo, "Screenplay") |> PrefixedName
    /// <summary>
    ///   <para>vivo:SeminarSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Seminar Series</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#SeminarSeries">http://vivoweb.org/ontology/core#SeminarSeries</seealso>
    let SeminarSeries = Prefixed_Name(vivo, "SeminarSeries") |> PrefixedName
    /// <summary>
    ///   <para>vivo:validIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>valid in</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#validIn">http://vivoweb.org/ontology/core#validIn</seealso>
    let validIn = Prefixed_Name(vivo, "validIn") |> PrefixedName
    /// <summary>
    ///   <para>vivo:hrJobTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>HR job title</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#hrJobTitle">http://vivoweb.org/ontology/core#hrJobTitle</seealso>
    let hrJobTitle = Prefixed_Name(vivo, "hrJobTitle") |> PrefixedName
    /// <summary>
    ///   <para>vivo:iclCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>International Classification (ICL) code</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#iclCode">http://vivoweb.org/ontology/core#iclCode</seealso>
    let iclCode = Prefixed_Name(vivo, "iclCode") |> PrefixedName
    /// <summary>
    ///   <para>vivo:GeopoliticalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Geopolitical Entity</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#GeopoliticalEntity">http://vivoweb.org/ontology/core#GeopoliticalEntity</seealso>
    let GeopoliticalEntity = Prefixed_Name(vivo, "GeopoliticalEntity") |> PrefixedName

    /// <summary>
    ///   <para>vivo:hasGoverningAuthority</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>governing authority</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#hasGoverningAuthority">http://vivoweb.org/ontology/core#hasGoverningAuthority</seealso>
    let hasGoverningAuthority =
        Prefixed_Name(vivo, "hasGoverningAuthority") |> PrefixedName

    /// <summary>
    ///   <para>vivo:Database</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Database</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Database">http://vivoweb.org/ontology/core#Database</seealso>
    let Database = Prefixed_Name(vivo, "Database") |> PrefixedName

    /// <summary>
    ///   <para>vivo:DateTimeValuePrecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Date/Time Value Precision</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#DateTimeValuePrecision">http://vivoweb.org/ontology/core#DateTimeValuePrecision</seealso>
    let DateTimeValuePrecision =
        Prefixed_Name(vivo, "DateTimeValuePrecision") |> PrefixedName

    /// <summary>
    ///   <para>vivo:Division</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Division</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Division">http://vivoweb.org/ontology/core#Division</seealso>
    let Division = Prefixed_Name(vivo, "Division") |> PrefixedName
    /// <summary>
    ///   <para>vivo:ExtensionUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Extension Unit</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#ExtensionUnit">http://vivoweb.org/ontology/core#ExtensionUnit</seealso>
    let ExtensionUnit = Prefixed_Name(vivo, "ExtensionUnit") |> PrefixedName
    /// <summary>
    ///   <para>vivo:EditorialArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Editorial Article</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#EditorialArticle">http://vivoweb.org/ontology/core#EditorialArticle</seealso>
    let EditorialArticle = Prefixed_Name(vivo, "EditorialArticle") |> PrefixedName
    /// <summary>
    ///   <para>vivo:inPress</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>in press</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#inPress">http://vivoweb.org/ontology/core#inPress</seealso>
    let inPress = Prefixed_Name(vivo, "inPress") |> PrefixedName
    /// <summary>
    ///   <para>vivo:researcherId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ISI Researcher ID</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#researcherId">http://vivoweb.org/ontology/core#researcherId</seealso>
    let researcherId = Prefixed_Name(vivo, "researcherId") |> PrefixedName
    /// <summary>
    ///   <para>vivo:seatingCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>seating capacity</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#seatingCapacity">http://vivoweb.org/ontology/core#seatingCapacity</seealso>
    let seatingCapacity = Prefixed_Name(vivo, "seatingCapacity") |> PrefixedName
    /// <summary>
    ///   <para>vivo:sponsorAwardId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>sponsor award ID</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#sponsorAwardId">http://vivoweb.org/ontology/core#sponsorAwardId</seealso>
    let sponsorAwardId = Prefixed_Name(vivo, "sponsorAwardId") |> PrefixedName
    /// <summary>
    ///   <para>vivo:EditorRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Editor Role</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#EditorRole">http://vivoweb.org/ontology/core#EditorRole</seealso>
    let EditorRole = Prefixed_Name(vivo, "EditorRole") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Editorship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Editorship</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Editorship">http://vivoweb.org/ontology/core#Editorship</seealso>
    let Editorship = Prefixed_Name(vivo, "Editorship") |> PrefixedName
    /// <summary>
    ///   <para>vivo:EducationalProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Educational Process</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#EducationalProcess">http://vivoweb.org/ontology/core#EducationalProcess</seealso>
    let EducationalProcess = Prefixed_Name(vivo, "EducationalProcess") |> PrefixedName

    /// <summary>
    ///   <para>vivo:supplementalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>supplemental information</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#supplementalInformation">http://vivoweb.org/ontology/core#supplementalInformation</seealso>
    let supplementalInformation =
        Prefixed_Name(vivo, "supplementalInformation") |> PrefixedName

    /// <summary>
    ///   <para>vivo:EmeritusLibrarian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Librarian Emeritus</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#EmeritusLibrarian">http://vivoweb.org/ontology/core#EmeritusLibrarian</seealso>
    let EmeritusLibrarian = Prefixed_Name(vivo, "EmeritusLibrarian") |> PrefixedName
    /// <summary>
    ///   <para>vivo:outreachOverview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>outreach overview</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#outreachOverview">http://vivoweb.org/ontology/core#outreachOverview</seealso>
    let outreachOverview = Prefixed_Name(vivo, "outreachOverview") |> PrefixedName
    /// <summary>
    ///   <para>vivo:researchOverview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>research overview</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#researchOverview">http://vivoweb.org/ontology/core#researchOverview</seealso>
    let researchOverview = Prefixed_Name(vivo, "researchOverview") |> PrefixedName
    /// <summary>
    ///   <para>vivo:scopusId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Scopus ID</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#scopusId">http://vivoweb.org/ontology/core#scopusId</seealso>
    let scopusId = Prefixed_Name(vivo, "scopusId") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Equipment</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Equipment">http://vivoweb.org/ontology/core#Equipment</seealso>
    let Equipment = Prefixed_Name(vivo, "Equipment") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Exhibit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Exhibit</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Exhibit">http://vivoweb.org/ontology/core#Exhibit</seealso>
    let Exhibit = Prefixed_Name(vivo, "Exhibit") |> PrefixedName
    /// <summary>
    ///   <para>vivo:F1000Link</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>F1000 Link</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#F1000Link">http://vivoweb.org/ontology/core#F1000Link</seealso>
    let F1000Link = Prefixed_Name(vivo, "F1000Link") |> PrefixedName

    /// <summary>
    ///   <para>vivo:FacultyAdministrativePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Faculty Administrative Position</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#FacultyAdministrativePosition">http://vivoweb.org/ontology/core#FacultyAdministrativePosition</seealso>
    let FacultyAdministrativePosition =
        Prefixed_Name(vivo, "FacultyAdministrativePosition") |> PrefixedName

    /// <summary>
    ///   <para>vivo:Position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Position</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Position">http://vivoweb.org/ontology/core#Position</seealso>
    let Position = Prefixed_Name(vivo, "Position") |> PrefixedName
    /// <summary>
    ///   <para>vivo:FacultyMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Faculty Member</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#FacultyMember">http://vivoweb.org/ontology/core#FacultyMember</seealso>
    let FacultyMember = Prefixed_Name(vivo, "FacultyMember") |> PrefixedName
    /// <summary>
    ///   <para>vivo:FacultyPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Faculty Position</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#FacultyPosition">http://vivoweb.org/ontology/core#FacultyPosition</seealso>
    let FacultyPosition = Prefixed_Name(vivo, "FacultyPosition") |> PrefixedName
    /// <summary>
    ///   <para>vivo:sponsoredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>award sponsored by</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#sponsoredBy">http://vivoweb.org/ontology/core#sponsoredBy</seealso>
    let sponsoredBy = Prefixed_Name(vivo, "sponsoredBy") |> PrefixedName
    /// <summary>
    ///   <para>vivo:sponsors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>sponsors award or honor</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#sponsors">http://vivoweb.org/ontology/core#sponsors</seealso>
    let sponsors = Prefixed_Name(vivo, "sponsors") |> PrefixedName
    /// <summary>
    ///   <para>vivo:start</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>start</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#start">http://vivoweb.org/ontology/core#start</seealso>
    let start = Prefixed_Name(vivo, "start") |> PrefixedName
    /// <summary>
    ///   <para>vivo:submitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bibo:DocumentStatus</para>
    ///
    /// labels<para>submitted</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#submitted">http://vivoweb.org/ontology/core#submitted</seealso>
    let submitted = Prefixed_Name(vivo, "submitted") |> PrefixedName
    /// <summary>
    ///   <para>vivo:teachingOverview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>teaching overview</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#teachingOverview">http://vivoweb.org/ontology/core#teachingOverview</seealso>
    let teachingOverview = Prefixed_Name(vivo, "teachingOverview") |> PrefixedName
    /// <summary>
    ///   <para>vivo:termLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>term label</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#termLabel">http://vivoweb.org/ontology/core#termLabel</seealso>
    let termLabel = Prefixed_Name(vivo, "termLabel") |> PrefixedName
    /// <summary>
    ///   <para>vivo:termType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>term type</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#termType">http://vivoweb.org/ontology/core#termType</seealso>
    let termType = Prefixed_Name(vivo, "termType") |> PrefixedName

    /// <summary>
    ///   <para>vivo:yearMonthDayTimePrecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vivo:DateTimeValuePrecision</para>
    ///
    /// labels<para>yearMonthDayTimePrecision</para><para>year-month-day-time value</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#yearMonthDayTimePrecision">http://vivoweb.org/ontology/core#yearMonthDayTimePrecision</seealso>
    let yearMonthDayTimePrecision =
        Prefixed_Name(vivo, "yearMonthDayTimePrecision") |> PrefixedName

    /// <summary>
    ///   <para>vivo:yearMonthPrecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vivo:DateTimeValuePrecision</para>
    ///
    /// labels<para>yearMonthPrecision</para><para>year-month value</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#yearMonthPrecision">http://vivoweb.org/ontology/core#yearMonthPrecision</seealso>
    let yearMonthPrecision = Prefixed_Name(vivo, "yearMonthPrecision") |> PrefixedName
    /// <summary>
    ///   <para>vivo:EmeritusFaculty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Faculty Member Emeritus</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#EmeritusFaculty">http://vivoweb.org/ontology/core#EmeritusFaculty</seealso>
    let EmeritusFaculty = Prefixed_Name(vivo, "EmeritusFaculty") |> PrefixedName
    /// <summary>
    ///   <para>vivo:EmeritusProfessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Professor Emeritus</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#EmeritusProfessor">http://vivoweb.org/ontology/core#EmeritusProfessor</seealso>
    let EmeritusProfessor = Prefixed_Name(vivo, "EmeritusProfessor") |> PrefixedName
    /// <summary>
    ///   <para>vivo:subcontractsGrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>subcontracts grant</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#subcontractsGrant">http://vivoweb.org/ontology/core#subcontractsGrant</seealso>
    let subcontractsGrant = Prefixed_Name(vivo, "subcontractsGrant") |> PrefixedName
    /// <summary>
    ///   <para>vivo:assigns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>assigns</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#assigns">http://vivoweb.org/ontology/core#assigns</seealso>
    let assigns = Prefixed_Name(vivo, "assigns") |> PrefixedName
    /// <summary>
    ///   <para>vivo:totalAwardAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>total award amount</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#totalAwardAmount">http://vivoweb.org/ontology/core#totalAwardAmount</seealso>
    let totalAwardAmount = Prefixed_Name(vivo, "totalAwardAmount") |> PrefixedName

    /// <summary>
    ///   <para>vivo:yearMonthDayPrecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>vivo:DateTimeValuePrecision</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>yearMonthDayPrecision</para><para>year-month-day value</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#yearMonthDayPrecision">http://vivoweb.org/ontology/core#yearMonthDayPrecision</seealso>
    let yearMonthDayPrecision =
        Prefixed_Name(vivo, "yearMonthDayPrecision") |> PrefixedName

    /// <summary>
    ///   <para>vivo:yearPrecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vivo:DateTimeValuePrecision</para>
    ///
    /// labels<para>yearPrecision</para><para>year value</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#yearPrecision">http://vivoweb.org/ontology/core#yearPrecision</seealso>
    let yearPrecision = Prefixed_Name(vivo, "yearPrecision") |> PrefixedName

    /// <summary>
    ///   <para>vivo:FacultyMentoringRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Faculty Mentoring Relationship</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#FacultyMentoringRelationship">http://vivoweb.org/ontology/core#FacultyMentoringRelationship</seealso>
    let FacultyMentoringRelationship =
        Prefixed_Name(vivo, "FacultyMentoringRelationship") |> PrefixedName

    /// <summary>
    ///   <para>vivo:Foundation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Foundation</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Foundation">http://vivoweb.org/ontology/core#Foundation</seealso>
    let Foundation = Prefixed_Name(vivo, "Foundation") |> PrefixedName
    /// <summary>
    ///   <para>vivo:FundingOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Funding Organization</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#FundingOrganization">http://vivoweb.org/ontology/core#FundingOrganization</seealso>
    let FundingOrganization = Prefixed_Name(vivo, "FundingOrganization") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Location</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Location">http://vivoweb.org/ontology/core#Location</seealso>
    let Location = Prefixed_Name(vivo, "Location") |> PrefixedName
    /// <summary>
    ///   <para>vivo:GovernmentAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Government Agency</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#GovernmentAgency">http://vivoweb.org/ontology/core#GovernmentAgency</seealso>
    let GovernmentAgency = Prefixed_Name(vivo, "GovernmentAgency") |> PrefixedName
    /// <summary>
    ///   <para>vivo:GraduateStudent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Graduate Student</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#GraduateStudent">http://vivoweb.org/ontology/core#GraduateStudent</seealso>
    let GraduateStudent = Prefixed_Name(vivo, "GraduateStudent") |> PrefixedName

    /// <summary>
    ///   <para>vivo:GraduateAdvisingRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Graduate Advising Relationship</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#GraduateAdvisingRelationship">http://vivoweb.org/ontology/core#GraduateAdvisingRelationship</seealso>
    let GraduateAdvisingRelationship =
        Prefixed_Name(vivo, "GraduateAdvisingRelationship") |> PrefixedName

    /// <summary>
    ///   <para>vivo:Student</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Student</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Student">http://vivoweb.org/ontology/core#Student</seealso>
    let Student = Prefixed_Name(vivo, "Student") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Hospital</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Hospital</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Hospital">http://vivoweb.org/ontology/core#Hospital</seealso>
    let Hospital = Prefixed_Name(vivo, "Hospital") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Institute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Institute</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Institute">http://vivoweb.org/ontology/core#Institute</seealso>
    let Institute = Prefixed_Name(vivo, "Institute") |> PrefixedName
    /// <summary>
    ///   <para>vivo:ResearcherRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Researcher Role</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#ResearcherRole">http://vivoweb.org/ontology/core#ResearcherRole</seealso>
    let ResearcherRole = Prefixed_Name(vivo, "ResearcherRole") |> PrefixedName
    /// <summary>
    ///   <para>vivo:expirationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>expiration date</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#expirationDate">http://vivoweb.org/ontology/core#expirationDate</seealso>
    let expirationDate = Prefixed_Name(vivo, "expirationDate") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Internship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Internship</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Internship">http://vivoweb.org/ontology/core#Internship</seealso>
    let Internship = Prefixed_Name(vivo, "Internship") |> PrefixedName
    /// <summary>
    ///   <para>vivo:InvitedTalk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Invited Talk</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#InvitedTalk">http://vivoweb.org/ontology/core#InvitedTalk</seealso>
    let InvitedTalk = Prefixed_Name(vivo, "InvitedTalk") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Presentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Presentation</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Presentation">http://vivoweb.org/ontology/core#Presentation</seealso>
    let Presentation = Prefixed_Name(vivo, "Presentation") |> PrefixedName
    /// <summary>
    ///   <para>vivo:GeographicRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Geographic Region</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#GeographicRegion">http://vivoweb.org/ontology/core#GeographicRegion</seealso>
    let GeographicRegion = Prefixed_Name(vivo, "GeographicRegion") |> PrefixedName
    /// <summary>
    ///   <para>vivo:PresentingProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Presenting Process</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#PresentingProcess">http://vivoweb.org/ontology/core#PresentingProcess</seealso>
    let PresentingProcess = Prefixed_Name(vivo, "PresentingProcess") |> PrefixedName
    /// <summary>
    ///   <para>vivo:PrimaryPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Primary Position</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#PrimaryPosition">http://vivoweb.org/ontology/core#PrimaryPosition</seealso>
    let PrimaryPosition = Prefixed_Name(vivo, "PrimaryPosition") |> PrefixedName

    /// <summary>
    ///   <para>vivo:PrincipalInvestigatorRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Principal Investigator Role</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#PrincipalInvestigatorRole">http://vivoweb.org/ontology/core#PrincipalInvestigatorRole</seealso>
    let PrincipalInvestigatorRole =
        Prefixed_Name(vivo, "PrincipalInvestigatorRole") |> PrefixedName

    /// <summary>
    ///   <para>vivo:Librarian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Librarian</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Librarian">http://vivoweb.org/ontology/core#Librarian</seealso>
    let Librarian = Prefixed_Name(vivo, "Librarian") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Library</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Library</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Library">http://vivoweb.org/ontology/core#Library</seealso>
    let Library = Prefixed_Name(vivo, "Library") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Licensure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Licensure</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Licensure">http://vivoweb.org/ontology/core#Licensure</seealso>
    let Licensure = Prefixed_Name(vivo, "Licensure") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Meeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Meeting</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Meeting">http://vivoweb.org/ontology/core#Meeting</seealso>
    let Meeting = Prefixed_Name(vivo, "Meeting") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Museum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Museum</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Museum">http://vivoweb.org/ontology/core#Museum</seealso>
    let Museum = Prefixed_Name(vivo, "Museum") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Newsletter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Newsletter</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Newsletter">http://vivoweb.org/ontology/core#Newsletter</seealso>
    let Newsletter = Prefixed_Name(vivo, "Newsletter") |> PrefixedName
    /// <summary>
    ///   <para>vivo:NonFacultyAcademic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Non-Faculty Academic</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#NonFacultyAcademic">http://vivoweb.org/ontology/core#NonFacultyAcademic</seealso>
    let NonFacultyAcademic = Prefixed_Name(vivo, "NonFacultyAcademic") |> PrefixedName
    /// <summary>
    ///   <para>vivo:OrganizerRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Organizer Role</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#OrganizerRole">http://vivoweb.org/ontology/core#OrganizerRole</seealso>
    let OrganizerRole = Prefixed_Name(vivo, "OrganizerRole") |> PrefixedName

    /// <summary>
    ///   <para>vivo:OutreachProviderRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Outreach Provider Role</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#OutreachProviderRole">http://vivoweb.org/ontology/core#OutreachProviderRole</seealso>
    let OutreachProviderRole =
        Prefixed_Name(vivo, "OutreachProviderRole") |> PrefixedName

    /// <summary>
    ///   <para>vivo:PeerReviewerRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Peer Reviewer Role</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#PeerReviewerRole">http://vivoweb.org/ontology/core#PeerReviewerRole</seealso>
    let PeerReviewerRole = Prefixed_Name(vivo, "PeerReviewerRole") |> PrefixedName
    /// <summary>
    ///   <para>vivo:rank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>rank</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#rank">http://vivoweb.org/ontology/core#rank</seealso>
    let rank = Prefixed_Name(vivo, "rank") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Postdoc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Postdoc</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Postdoc">http://vivoweb.org/ontology/core#Postdoc</seealso>
    let Postdoc = Prefixed_Name(vivo, "Postdoc") |> PrefixedName

    /// <summary>
    ///   <para>vivo:PostdocOrFellowAdvisingRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Postdoc or Fellow Advising Relationship</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#PostdocOrFellowAdvisingRelationship">http://vivoweb.org/ontology/core#PostdocOrFellowAdvisingRelationship</seealso>
    let PostdocOrFellowAdvisingRelationship =
        Prefixed_Name(vivo, "PostdocOrFellowAdvisingRelationship") |> PrefixedName

    /// <summary>
    ///   <para>vivo:PresenterRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Presenter Role</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#PresenterRole">http://vivoweb.org/ontology/core#PresenterRole</seealso>
    let PresenterRole = Prefixed_Name(vivo, "PresenterRole") |> PrefixedName
    /// <summary>
    ///   <para>vivo:LeaderRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Leader Role</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#LeaderRole">http://vivoweb.org/ontology/core#LeaderRole</seealso>
    let LeaderRole = Prefixed_Name(vivo, "LeaderRole") |> PrefixedName
    /// <summary>
    ///   <para>vivo:LibrarianPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Librarian Position</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#LibrarianPosition">http://vivoweb.org/ontology/core#LibrarianPosition</seealso>
    let LibrarianPosition = Prefixed_Name(vivo, "LibrarianPosition") |> PrefixedName
    /// <summary>
    ///   <para>vivo:License</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>License</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#License">http://vivoweb.org/ontology/core#License</seealso>
    let License = Prefixed_Name(vivo, "License") |> PrefixedName
    /// <summary>
    ///   <para>vivo:MedicalResidency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Medical Residency</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#MedicalResidency">http://vivoweb.org/ontology/core#MedicalResidency</seealso>
    let MedicalResidency = Prefixed_Name(vivo, "MedicalResidency") |> PrefixedName
    /// <summary>
    ///   <para>vivo:MemberRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Member Role</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#MemberRole">http://vivoweb.org/ontology/core#MemberRole</seealso>
    let MemberRole = Prefixed_Name(vivo, "MemberRole") |> PrefixedName
    /// <summary>
    ///   <para>vivo:NewsRelease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>News Release</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#NewsRelease">http://vivoweb.org/ontology/core#NewsRelease</seealso>
    let NewsRelease = Prefixed_Name(vivo, "NewsRelease") |> PrefixedName
    /// <summary>
    ///   <para>vivo:NonAcademic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Non-Academic</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#NonAcademic">http://vivoweb.org/ontology/core#NonAcademic</seealso>
    let NonAcademic = Prefixed_Name(vivo, "NonAcademic") |> PrefixedName
    /// <summary>
    ///   <para>vivo:NonAcademicPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Non-Academic Position</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#NonAcademicPosition">http://vivoweb.org/ontology/core#NonAcademicPosition</seealso>
    let NonAcademicPosition = Prefixed_Name(vivo, "NonAcademicPosition") |> PrefixedName

    /// <summary>
    ///   <para>vivo:NonFacultyAcademicPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Non-Faculty Academic Position</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#NonFacultyAcademicPosition">http://vivoweb.org/ontology/core#NonFacultyAcademicPosition</seealso>
    let NonFacultyAcademicPosition =
        Prefixed_Name(vivo, "NonFacultyAcademicPosition") |> PrefixedName

    /// <summary>
    ///   <para>vivo:OrganizingProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Organizing Process</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#OrganizingProcess">http://vivoweb.org/ontology/core#OrganizingProcess</seealso>
    let OrganizingProcess = Prefixed_Name(vivo, "OrganizingProcess") |> PrefixedName
    /// <summary>
    ///   <para>vivo:ReviewerRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Reviewer Role</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#ReviewerRole">http://vivoweb.org/ontology/core#ReviewerRole</seealso>
    let ReviewerRole = Prefixed_Name(vivo, "ReviewerRole") |> PrefixedName
    /// <summary>
    ///   <para>vivo:PopulatedPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Populated Place</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#PopulatedPlace">http://vivoweb.org/ontology/core#PopulatedPlace</seealso>
    let PopulatedPlace = Prefixed_Name(vivo, "PopulatedPlace") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Country</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Country">http://vivoweb.org/ontology/core#Country</seealso>
    let Country = Prefixed_Name(vivo, "Country") |> PrefixedName
    /// <summary>
    ///   <para>vivo:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>identifier</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#identifier">http://vivoweb.org/ontology/core#identifier</seealso>
    let identifier = Prefixed_Name(vivo, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>vivo:hideFromDisplay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>hide from display</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#hideFromDisplay">http://vivoweb.org/ontology/core#hideFromDisplay</seealso>
    let hideFromDisplay = Prefixed_Name(vivo, "hideFromDisplay") |> PrefixedName
    /// <summary>
    ///   <para>vivo:dateTimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>date/time interval</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#dateTimeInterval">http://vivoweb.org/ontology/core#dateTimeInterval</seealso>
    let dateTimeInterval = Prefixed_Name(vivo, "dateTimeInterval") |> PrefixedName
    /// <summary>
    ///   <para>vivo:DateTimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Date/Time Interval</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#DateTimeInterval">http://vivoweb.org/ontology/core#DateTimeInterval</seealso>
    let DateTimeInterval = Prefixed_Name(vivo, "DateTimeInterval") |> PrefixedName
    /// <summary>
    ///   <para>vivo:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>description</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#description">http://vivoweb.org/ontology/core#description</seealso>
    let description = Prefixed_Name(vivo, "description") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Project</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Project">http://vivoweb.org/ontology/core#Project</seealso>
    let Project = Prefixed_Name(vivo, "Project") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Center</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Center</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Center">http://vivoweb.org/ontology/core#Center</seealso>
    let Center = Prefixed_Name(vivo, "Center") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Laboratory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Laboratory</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Laboratory">http://vivoweb.org/ontology/core#Laboratory</seealso>
    let Laboratory = Prefixed_Name(vivo, "Laboratory") |> PrefixedName
    /// <summary>
    ///   <para>vivo:hasFundingVehicle</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>funding provided via</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#hasFundingVehicle">http://vivoweb.org/ontology/core#hasFundingVehicle</seealso>
    let hasFundingVehicle = Prefixed_Name(vivo, "hasFundingVehicle") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Grant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Grant</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Grant">http://vivoweb.org/ontology/core#Grant</seealso>
    let Grant = Prefixed_Name(vivo, "Grant") |> PrefixedName
    /// <summary>
    ///   <para>vivo:contactInformation</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>contact information</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#contactInformation">http://vivoweb.org/ontology/core#contactInformation</seealso>
    let contactInformation = Prefixed_Name(vivo, "contactInformation") |> PrefixedName
    /// <summary>
    ///   <para>vivo:AttendeeRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Attendee Role</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#AttendeeRole">http://vivoweb.org/ontology/core#AttendeeRole</seealso>
    let AttendeeRole = Prefixed_Name(vivo, "AttendeeRole") |> PrefixedName
    /// <summary>
    ///   <para>vivo:AttendingProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Attending Process</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#AttendingProcess">http://vivoweb.org/ontology/core#AttendingProcess</seealso>
    let AttendingProcess = Prefixed_Name(vivo, "AttendingProcess") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Authorship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Authorship</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Authorship">http://vivoweb.org/ontology/core#Authorship</seealso>
    let Authorship = Prefixed_Name(vivo, "Authorship") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Award</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Award or Honor</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Award">http://vivoweb.org/ontology/core#Award</seealso>
    let Award = Prefixed_Name(vivo, "Award") |> PrefixedName
    /// <summary>
    ///   <para>vivo:AwardReceipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Award or Honor Receipt</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#AwardReceipt">http://vivoweb.org/ontology/core#AwardReceipt</seealso>
    let AwardReceipt = Prefixed_Name(vivo, "AwardReceipt") |> PrefixedName
    /// <summary>
    ///   <para>vivo:assignedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>assigned by</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#assignedBy">http://vivoweb.org/ontology/core#assignedBy</seealso>
    let assignedBy = Prefixed_Name(vivo, "assignedBy") |> PrefixedName
    /// <summary>
    ///   <para>vivo:AwardedDegree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Awarded Degree</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#AwardedDegree">http://vivoweb.org/ontology/core#AwardedDegree</seealso>
    let AwardedDegree = Prefixed_Name(vivo, "AwardedDegree") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Blog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Blog</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Blog">http://vivoweb.org/ontology/core#Blog</seealso>
    let Blog = Prefixed_Name(vivo, "Blog") |> PrefixedName
    /// <summary>
    ///   <para>vivo:BlogPosting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Blog Posting</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#BlogPosting">http://vivoweb.org/ontology/core#BlogPosting</seealso>
    let BlogPosting = Prefixed_Name(vivo, "BlogPosting") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Building</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Building</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Building">http://vivoweb.org/ontology/core#Building</seealso>
    let Building = Prefixed_Name(vivo, "Building") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Speech</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Speech</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Speech">http://vivoweb.org/ontology/core#Speech</seealso>
    let Speech = Prefixed_Name(vivo, "Speech") |> PrefixedName
    /// <summary>
    ///   <para>vivo:StateOrProvince</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>State or Province</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#StateOrProvince">http://vivoweb.org/ontology/core#StateOrProvince</seealso>
    let StateOrProvince = Prefixed_Name(vivo, "StateOrProvince") |> PrefixedName
    /// <summary>
    ///   <para>vivo:StudentOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Student Organization</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#StudentOrganization">http://vivoweb.org/ontology/core#StudentOrganization</seealso>
    let StudentOrganization = Prefixed_Name(vivo, "StudentOrganization") |> PrefixedName
    /// <summary>
    ///   <para>vivo:SubnationalRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>For example, the Midwest, northeast U.S.</para>
    /// labels<para>Subnational Region</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#SubnationalRegion">http://vivoweb.org/ontology/core#SubnationalRegion</seealso>
    let SubnationalRegion = Prefixed_Name(vivo, "SubnationalRegion") |> PrefixedName
    /// <summary>
    ///   <para>vivo:TeacherRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Teacher Role</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#TeacherRole">http://vivoweb.org/ontology/core#TeacherRole</seealso>
    let TeacherRole = Prefixed_Name(vivo, "TeacherRole") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Team</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Team</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Team">http://vivoweb.org/ontology/core#Team</seealso>
    let Team = Prefixed_Name(vivo, "Team") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Translation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Translation</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Translation">http://vivoweb.org/ontology/core#Translation</seealso>
    let Translation = Prefixed_Name(vivo, "Translation") |> PrefixedName

    /// <summary>
    ///   <para>vivo:UndergraduateAdvisingRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Undergraduate Advising Relationship</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#UndergraduateAdvisingRelationship">http://vivoweb.org/ontology/core#UndergraduateAdvisingRelationship</seealso>
    let UndergraduateAdvisingRelationship =
        Prefixed_Name(vivo, "UndergraduateAdvisingRelationship") |> PrefixedName

    /// <summary>
    ///   <para>vivo:UndergraduateStudent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Undergraduate Student</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#UndergraduateStudent">http://vivoweb.org/ontology/core#UndergraduateStudent</seealso>
    let UndergraduateStudent =
        Prefixed_Name(vivo, "UndergraduateStudent") |> PrefixedName

    /// <summary>
    ///   <para>vivo:University</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>University</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#University">http://vivoweb.org/ontology/core#University</seealso>
    let University = Prefixed_Name(vivo, "University") |> PrefixedName
    /// <summary>
    ///   <para>vivo:Video</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Video</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#Video">http://vivoweb.org/ontology/core#Video</seealso>
    let Video = Prefixed_Name(vivo, "Video") |> PrefixedName
    /// <summary>
    ///   <para>vivo:WorkingPaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Working Paper</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#WorkingPaper">http://vivoweb.org/ontology/core#WorkingPaper</seealso>
    let WorkingPaper = Prefixed_Name(vivo, "WorkingPaper") |> PrefixedName
    /// <summary>
    ///   <para>vivo:WorkshopSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Workshop Series</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#WorkshopSeries">http://vivoweb.org/ontology/core#WorkshopSeries</seealso>
    let WorkshopSeries = Prefixed_Name(vivo, "WorkshopSeries") |> PrefixedName

    /// <summary>
    ///   <para>vivo:affiliatedOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has affiliated organization</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#affiliatedOrganization">http://vivoweb.org/ontology/core#affiliatedOrganization</seealso>
    let affiliatedOrganization =
        Prefixed_Name(vivo, "affiliatedOrganization") |> PrefixedName

    /// <summary>
    ///   <para>vivo:dateFiled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>date filed</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#dateFiled">http://vivoweb.org/ontology/core#dateFiled</seealso>
    let dateFiled = Prefixed_Name(vivo, "dateFiled") |> PrefixedName
    /// <summary>
    ///   <para>vivo:dateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>date/time</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#dateTime">http://vivoweb.org/ontology/core#dateTime</seealso>
    let dateTime = Prefixed_Name(vivo, "dateTime") |> PrefixedName
    /// <summary>
    ///   <para>vivo:dateTimePrecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>date/time precision</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#dateTimePrecision">http://vivoweb.org/ontology/core#dateTimePrecision</seealso>
    let dateTimePrecision = Prefixed_Name(vivo, "dateTimePrecision") |> PrefixedName
    /// <summary>
    ///   <para>vivo:degreeCandidacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>degree candidacy</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#degreeCandidacy">http://vivoweb.org/ontology/core#degreeCandidacy</seealso>
    let degreeCandidacy = Prefixed_Name(vivo, "degreeCandidacy") |> PrefixedName
    /// <summary>
    ///   <para>vivo:departmentOrSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>department or school name within institution</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#departmentOrSchool">http://vivoweb.org/ontology/core#departmentOrSchool</seealso>
    let departmentOrSchool = Prefixed_Name(vivo, "departmentOrSchool") |> PrefixedName
    /// <summary>
    ///   <para>vivo:distributes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>distributes</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#distributes">http://vivoweb.org/ontology/core#distributes</seealso>
    let distributes = Prefixed_Name(vivo, "distributes") |> PrefixedName

    /// <summary>
    ///   <para>vivo:distributesFundingFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>distributes funding from</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#distributesFundingFrom">http://vivoweb.org/ontology/core#distributesFundingFrom</seealso>
    let distributesFundingFrom =
        Prefixed_Name(vivo, "distributesFundingFrom") |> PrefixedName

    /// <summary>
    ///   <para>vivo:providesFundingThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>provides funding through</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#providesFundingThrough">http://vivoweb.org/ontology/core#providesFundingThrough</seealso>
    let providesFundingThrough =
        Prefixed_Name(vivo, "providesFundingThrough") |> PrefixedName

    /// <summary>
    ///   <para>vivo:eRACommonsId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>eRA Commons ID</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#eRACommonsId">http://vivoweb.org/ontology/core#eRACommonsId</seealso>
    let eRACommonsId = Prefixed_Name(vivo, "eRACommonsId") |> PrefixedName
    /// <summary>
    ///   <para>vivo:eligibleFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>credential eligibility attained</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#eligibleFor">http://vivoweb.org/ontology/core#eligibleFor</seealso>
    let eligibleFor = Prefixed_Name(vivo, "eligibleFor") |> PrefixedName
    /// <summary>
    ///   <para>vivo:end</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>end</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#end">http://vivoweb.org/ontology/core#end</seealso>
    let end_ = Prefixed_Name(vivo, "end") |> PrefixedName
    /// <summary>
    ///   <para>vivo:entryTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>entry term</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#entryTerm">http://vivoweb.org/ontology/core#entryTerm</seealso>
    let entryTerm = Prefixed_Name(vivo, "entryTerm") |> PrefixedName
    /// <summary>
    ///   <para>vivo:equipmentFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>equipment for</para><para>equipment for</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#equipmentFor">http://vivoweb.org/ontology/core#equipmentFor</seealso>
    let equipmentFor = Prefixed_Name(vivo, "equipmentFor") |> PrefixedName
    /// <summary>
    ///   <para>vivo:facilityFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#facilityFor">http://vivoweb.org/ontology/core#facilityFor</seealso>
    let facilityFor = Prefixed_Name(vivo, "facilityFor") |> PrefixedName
    /// <summary>
    ///   <para>vivo:hasFacility</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>has facility</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#hasFacility">http://vivoweb.org/ontology/core#hasFacility</seealso>
    let hasFacility = Prefixed_Name(vivo, "hasFacility") |> PrefixedName
    /// <summary>
    ///   <para>vivo:featuredIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>featured in</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#featuredIn">http://vivoweb.org/ontology/core#featuredIn</seealso>
    let featuredIn = Prefixed_Name(vivo, "featuredIn") |> PrefixedName
    /// <summary>
    ///   <para>vivo:fundingVehicleFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>provides funding for</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#fundingVehicleFor">http://vivoweb.org/ontology/core#fundingVehicleFor</seealso>
    let fundingVehicleFor = Prefixed_Name(vivo, "fundingVehicleFor") |> PrefixedName
    /// <summary>
    ///   <para>vivo:supports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>supports</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#supports">http://vivoweb.org/ontology/core#supports</seealso>
    let supports = Prefixed_Name(vivo, "supports") |> PrefixedName
    /// <summary>
    ///   <para>vivo:geographicFocusOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>geographic focus of</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#geographicFocusOf">http://vivoweb.org/ontology/core#geographicFocusOf</seealso>
    let geographicFocusOf = Prefixed_Name(vivo, "geographicFocusOf") |> PrefixedName

    /// <summary>
    ///   <para>vivo:governingAuthorityFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>governing authority for</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#governingAuthorityFor">http://vivoweb.org/ontology/core#governingAuthorityFor</seealso>
    let governingAuthorityFor =
        Prefixed_Name(vivo, "governingAuthorityFor") |> PrefixedName

    /// <summary>
    ///   <para>vivo:grantDirectCosts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>direct costs</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#grantDirectCosts">http://vivoweb.org/ontology/core#grantDirectCosts</seealso>
    let grantDirectCosts = Prefixed_Name(vivo, "grantDirectCosts") |> PrefixedName

    /// <summary>
    ///   <para>vivo:grantSubcontractedThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>subcontracted through</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#grantSubcontractedThrough">http://vivoweb.org/ontology/core#grantSubcontractedThrough</seealso>
    let grantSubcontractedThrough =
        Prefixed_Name(vivo, "grantSubcontractedThrough") |> PrefixedName

    /// <summary>
    ///   <para>vivo:hasAssociatedConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>associated concept</para></remarks>
    /// <seealso href="http://vivoweb.org/ontology/core#hasAssociatedConcept">http://vivoweb.org/ontology/core#hasAssociatedConcept</seealso>
    let hasAssociatedConcept =
        Prefixed_Name(vivo, "hasAssociatedConcept") |> PrefixedName
