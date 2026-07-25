namespace http.w3id.org.um.cbcm.eu_cm_ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cbcm =
    let _namespace_iri = Namespace_Iri cbcm |> NamespaceIRI
    /// <summary>
    ///   <para>cbcm:OriginalCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An original company, in the context of a (cross-border) division, means a company which - in case of a full division - transfers all its assets and liabilities to two or more companies, or - in case of a partial division or division by separation - transfers part of its assets and liabilities to one or more companies.</para>
    /// labels<para>Original company</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#OriginalCompany">http://w3id.org/um/cbcm/eu-cm-ontology#OriginalCompany</seealso>
    let OriginalCompany = Prefixed_Name(cbcm, "OriginalCompany") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:PreDivisionCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Article 160o: a pre-division certificate attests compliance with all the relevant conditions and the proper completion of all procedures and formalities in the Member State concerned.</para>
    /// labels<para>Company pre-division certificate</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#PreDivisionCertificate">http://w3id.org/um/cbcm/eu-cm-ontology#PreDivisionCertificate</seealso>
    let PreDivisionCertificate =
        Prefixed_Name(cbcm, "PreDivisionCertificate") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:PreMergerCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Article 127: a pre-merger certificate attests compliance with all the relevant conditions and the proper completion of all procedures and formalities in the Member State of the merging company.</para>
    /// labels<para>Company pre-merger certificate</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#PreMergerCertificate">http://w3id.org/um/cbcm/eu-cm-ontology#PreMergerCertificate</seealso>
    let PreMergerCertificate =
        Prefixed_Name(cbcm, "PreMergerCertificate") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:RecipientCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A company being divided transfers part of its assets and liabilities to one or more newly formed companies, which are the recipient companies in a (cross-border) division.</para>
    /// labels<para>Recipient company</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#RecipientCompany">http://w3id.org/um/cbcm/eu-cm-ontology#RecipientCompany</seealso>
    let RecipientCompany = Prefixed_Name(cbcm, "RecipientCompany") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:SocietasEuropaeaMerger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This is a cross-border merger where two or more companies from different Member States merge into a new company that has a special legal form called a Societas Europaea (SE) which allows the behavior of this new company to be regulated under European Law (rather than national law).</para>
    /// labels<para>Cross-border merger into a new company with a Societas Europaea form</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#SocietasEuropaeaMerger">http://w3id.org/um/cbcm/eu-cm-ontology#SocietasEuropaeaMerger</seealso>
    let SocietasEuropaeaMerger =
        Prefixed_Name(cbcm, "SocietasEuropaeaMerger") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:ShareholderInformationRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is particularly important that the shareholders of the companies involved in a transaction be kept adequately informed in an objective manner, and that their rights be suitably protected. This includes for instance the availability of documents for inspection by shareholders (e.g. article 97 of Directive 2017/1132).</para>
    /// labels<para>Shareholder information right</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#ShareholderInformationRight">http://w3id.org/um/cbcm/eu-cm-ontology#ShareholderInformationRight</seealso>
    let ShareholderInformationRight =
        Prefixed_Name(cbcm, "ShareholderInformationRight") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:Society</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The society at large is a stakeholder in a company through, inter alia, the government and its agencies, suppliers, customers, trade unions and the communities from which the business draws its resources.</para>
    /// labels<para>Society</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#Society">http://w3id.org/um/cbcm/eu-cm-ontology#Society</seealso>
    let Society = Prefixed_Name(cbcm, "Society") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:SpecialNegotiationBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Special Negotiation Body (SNB) or Special Negotiating Body is an organisation that represents the employees of companies in negotiations with the company authorities in order to reach a written agreement on the involvement of employees in company transactions.</para>
    /// labels<para>Special negotiating body</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#SpecialNegotiationBody">http://w3id.org/um/cbcm/eu-cm-ontology#SpecialNegotiationBody</seealso>
    let SpecialNegotiationBody =
        Prefixed_Name(cbcm, "SpecialNegotiationBody") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:SpecialNegotiationBodyAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A written agreement concerning the involvement of employees in company transactions. Special Negotiating Body (SNB) organisation represents employees in the negotiation of the terms of this agreement with the company authorities. The agreement must be reached in accordance with the EU Company Law Directive and is laid down in the SNB-agreement.</para>
    /// labels<para>Special negotiating body agreement</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#SpecialNegotiationBodyAgreement">http://w3id.org/um/cbcm/eu-cm-ontology#SpecialNegotiationBodyAgreement</seealso>
    let SpecialNegotiationBodyAgreement =
        Prefixed_Name(cbcm, "SpecialNegotiationBodyAgreement") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:SubsidiaryCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A subsidiary, subsidiary company or daughter company is a company that is owned or controlled by another company, which is called the parent company, parent, or holding company.</para>
    /// labels<para>Subsidiary company</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#SubsidiaryCompany">http://w3id.org/um/cbcm/eu-cm-ontology#SubsidiaryCompany</seealso>
    let SubsidiaryCompany = Prefixed_Name(cbcm, "SubsidiaryCompany") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:hasParentCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(hasParentCompany ?ENTITY1 ?ENTITY2) means that some company ?ENTITY1 is owned and under direct or indirect control by the company ?ENTITY2.</para>
    /// labels<para>has parent company</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#hasParentCompany">http://w3id.org/um/cbcm/eu-cm-ontology#hasParentCompany</seealso>
    let hasParentCompany = Prefixed_Name(cbcm, "hasParentCompany") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:SupervisoryAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An individual authority established by its member state to supervise the compliance with a specific regulation.</para>
    /// labels<para>SupervisoryAuthority</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#SupervisoryAuthority">http://w3id.org/um/cbcm/eu-cm-ontology#SupervisoryAuthority</seealso>
    let SupervisoryAuthority =
        Prefixed_Name(cbcm, "SupervisoryAuthority") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:SupervisoryBoard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A supervisory board must approve of major business decisions. It is a group of individuals chosen by the shareholders - and employee representatives in board-level employee representation systems - of a company to promote their interests through the governance of the company and to hire and supervise the management board. It is also called non-executive board in a one-tier board system.</para>
    /// labels<para>Supervisory board</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#SupervisoryBoard">http://w3id.org/um/cbcm/eu-cm-ontology#SupervisoryBoard</seealso>
    let SupervisoryBoard = Prefixed_Name(cbcm, "SupervisoryBoard") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:containedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(containedIn ?ENTITY1 ?ENTITY2) means that some document or publication ?ENTITY1 is archived or stored in some other document collection, database or data repository referred to by ?ENTITY2.</para>
    /// labels<para>contained in</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#containedIn">http://w3id.org/um/cbcm/eu-cm-ontology#containedIn</seealso>
    let containedIn = Prefixed_Name(cbcm, "containedIn") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:TransferringCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Transferring Company means the company transferring its assets and liabilities to a recipient company.</para>
    /// labels<para>Transferring company</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#TransferringCompany">http://w3id.org/um/cbcm/eu-cm-ontology#TransferringCompany</seealso>
    let TransferringCompany = Prefixed_Name(cbcm, "TransferringCompany") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:UltimateBeneficialOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Ultimate Beneficial owner refers to the natural person(s) who ultimately owns or controls a customer and/or the natural person on whose behalf a transaction is being conducted. It also includes those persons who exercise ultimate effective control over a legal person or arrangement.</para>
    /// labels<para>Ultimate beneficial owner</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#UltimateBeneficialOwner">http://w3id.org/um/cbcm/eu-cm-ontology#UltimateBeneficialOwner</seealso>
    let UltimateBeneficialOwner =
        Prefixed_Name(cbcm, "UltimateBeneficialOwner") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:CompanyShareholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An individual, group, or organization that owns one or more shares in a company, and in whose name the share certificate is issued.</para>
    /// labels<para>Company shareholder</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyShareholder">http://w3id.org/um/cbcm/eu-cm-ontology#CompanyShareholder</seealso>
    let CompanyShareholder = Prefixed_Name(cbcm, "CompanyShareholder") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:partOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(partOf ?ENTITY1 ?ENTITY2) means (hasPart ?ENTITY2 ?ENTITY1)</para>
    /// labels<para>part of</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#partOf">http://w3id.org/um/cbcm/eu-cm-ontology#partOf</seealso>
    let partOf = Prefixed_Name(cbcm, "partOf") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:CompanyStakeholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A person, group or organization that has interest or concern in an organization or company in particular. Stakeholders can affect or be affected by the company's actions, objectives and policies.</para>
    /// labels<para>Stakeholder in a company</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyStakeholder">http://w3id.org/um/cbcm/eu-cm-ontology#CompanyStakeholder</seealso>
    let CompanyStakeholder = Prefixed_Name(cbcm, "CompanyStakeholder") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:acYearEmploymentFigure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The year the last annual employment figure was obtained for acquiring companies</para>
    /// labels<para>AC Last employment figure year</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#acYearEmploymentFigure">http://w3id.org/um/cbcm/eu-cm-ontology#acYearEmploymentFigure</seealso>
    let acYearEmploymentFigure =
        Prefixed_Name(cbcm, "acYearEmploymentFigure") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:TransactionNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A written notice, published in an official journal of a Member State of the EU and/or the European Official Journal indicating the intention to engage in a transaction and which informs  the members, creditors and representatives of the employees of the company, or, where there are no such representatives, the employees themselves of said transaction.</para>
    /// labels<para>Company transaction notice</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#TransactionNotice">http://w3id.org/um/cbcm/eu-cm-ontology#TransactionNotice</seealso>
    let TransactionNotice = Prefixed_Name(cbcm, "TransactionNotice") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:transactionValidatedByDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(transactionValidatedByDocument ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 went through a process of approval and assessment through various criteria such as veracity, eligibility, legal relevance etc. and a document ?ENTITY2 was produced to prove the satisfaction of the critieria by ?ENTITY1.</para>
    /// labels<para>transaction validated by document</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionValidatedByDocument">http://w3id.org/um/cbcm/eu-cm-ontology#transactionValidatedByDocument</seealso>
    let transactionValidatedByDocument =
        Prefixed_Name(cbcm, "transactionValidatedByDocument") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:cbcmDataProvenanceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(cbcmDataProvenanceRelation ?ENTITY1 ?ENTITY2) means that the relation between ?ENTITY1 and ?ENTITY2 captures provenance information for company transaction data.</para>
    /// labels<para>Cross-border company mobility data provenance relation</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmDataProvenanceRelation">http://w3id.org/um/cbcm/eu-cm-ontology#cbcmDataProvenanceRelation</seealso>
    let cbcmDataProvenanceRelation =
        Prefixed_Name(cbcm, "cbcmDataProvenanceRelation") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:cbcmOrganisationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(cbcmOrganisationRelation ?ENTITY1 ?ENTITY2) means that the relation between ?ENTITY1 and ?ENTITY2 captures information pertaining to an organisation.</para>
    /// labels<para>Cross-border company mobility organisation relation</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmOrganisationRelation">http://w3id.org/um/cbcm/eu-cm-ontology#cbcmOrganisationRelation</seealso>
    let cbcmOrganisationRelation =
        Prefixed_Name(cbcm, "cbcmOrganisationRelation") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:companiesHaveEconomicCommittee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Are the companies involved in the transaction having an economic committee?
    ///
    /// An economic committee advises the work council about the financial parts of the transaction.</para>
    /// labels<para>Companies have Economic Committee</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#companiesHaveEconomicCommittee">http://w3id.org/um/cbcm/eu-cm-ontology#companiesHaveEconomicCommittee</seealso>
    let companiesHaveEconomicCommittee =
        Prefixed_Name(cbcm, "companiesHaveEconomicCommittee") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:companiesHaveWorksCouncil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Are the companies involved in the transaction having a works council? Works councils safeguard employees' welfare</para>
    /// labels<para>Companies have Works Council</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#companiesHaveWorksCouncil">http://w3id.org/um/cbcm/eu-cm-ontology#companiesHaveWorksCouncil</seealso>
    let companiesHaveWorksCouncil =
        Prefixed_Name(cbcm, "companiesHaveWorksCouncil") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:companyFormCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(companyFormCountry ?ENTITY1 ?ENTITY2) means that ?ENTITY1 is a company form recognized by the law of country ?ENTITY2.</para>
    /// labels<para>Company form country</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#companyFormCountry">http://w3id.org/um/cbcm/eu-cm-ontology#companyFormCountry</seealso>
    let companyFormCountry = Prefixed_Name(cbcm, "companyFormCountry") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:reportedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(reportedIn ?ENTITY1 ?ENTITY2) means that some significant event, process or statement ?ENTITY1 is published or mentioned or declared in writing in some publication, document or database ?ENTITY2.</para>
    /// labels<para>reported in</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#reportedIn">http://w3id.org/um/cbcm/eu-cm-ontology#reportedIn</seealso>
    let reportedIn = Prefixed_Name(cbcm, "reportedIn") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:TransactionCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A document issued by a Competent Authority declaring that certain steps of the transaction are completed.</para>
    /// labels<para>Company transaction certificate</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#TransactionCertificate">http://w3id.org/um/cbcm/eu-cm-ontology#TransactionCertificate</seealso>
    let TransactionCertificate =
        Prefixed_Name(cbcm, "TransactionCertificate") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:CompetentAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The monitoring of the completion and legality of the decision-making process in each company involved in a transaction is carried out by a national authority having jurisdiction over each of those companies. The national authority could be a court, a notary or any other competent authority appointed by the Member State concerned.</para>
    /// labels<para>Competent authority</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CompetentAuthority">http://w3id.org/um/cbcm/eu-cm-ontology#CompetentAuthority</seealso>
    let CompetentAuthority = Prefixed_Name(cbcm, "CompetentAuthority") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:ConsultationRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The right of employees or their representatives to be consulted and to give advice on a business decision, such as an intended merger/division/conversion/seat transfer.</para>
    /// labels<para>Consultation right</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#ConsultationRight">http://w3id.org/um/cbcm/eu-cm-ontology#ConsultationRight</seealso>
    let ConsultationRight = Prefixed_Name(cbcm, "ConsultationRight") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:TransactionDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Document required by law to document the step of a company transaction or an agreement made between stakeholders involved in the transaction that are either printed, inserted and mailed, or electronically presented.</para>
    /// labels<para>Transaction document</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#TransactionDocument">http://w3id.org/um/cbcm/eu-cm-ontology#TransactionDocument</seealso>
    let TransactionDocument = Prefixed_Name(cbcm, "TransactionDocument") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:Creditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A person, organization, or government that is owed money. A creditor's claims and the safeguarding of these creditor rights is laid down in the company law of the Member States and EU law.</para>
    /// labels<para>Creditor</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#Creditor">http://w3id.org/um/cbcm/eu-cm-ontology#Creditor</seealso>
    let Creditor = Prefixed_Name(cbcm, "Creditor") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:documentValidatedByDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(documentValidatedByDocument ?ENTITY1 ?ENTITY2) means that some document or publication, ?ENTITY1, went through a process of approval and assessment through various criteria such as veracity, eligibility, legal relevance etc. and another document ?ENTITY2 was produced to prove the satisfaction of the critieria by ?ENTITY1.</para>
    /// labels<para>document validated by document</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#documentValidatedByDocument">http://w3id.org/um/cbcm/eu-cm-ontology#documentValidatedByDocument</seealso>
    let documentValidatedByDocument =
        Prefixed_Name(cbcm, "documentValidatedByDocument") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:hasCompanyStakeholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(hasCompanyStakeholder ?ENTITY1 ?ENTITY2) means that some entity ?ENTITY1, which is either a significant process or agent has another agent ?ENTITY2 with personal interests in benefiting either financially or otherwise from the outcomes of ?ENTITY1 (if it is an event or process), or in its byproducts and profits (if it is an agent).</para>
    /// labels<para>has company stakeholder</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#hasCompanyStakeholder">http://w3id.org/um/cbcm/eu-cm-ontology#hasCompanyStakeholder</seealso>
    let hasCompanyStakeholder =
        Prefixed_Name(cbcm, "hasCompanyStakeholder") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:euOfficialJournal</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:OfficialJournal</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#euOfficialJournal">http://w3id.org/um/cbcm/eu-cm-ontology#euOfficialJournal</seealso>
    let euOfficialJournal = Prefixed_Name(cbcm, "euOfficialJournal") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:ewc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Is the company having a European Works Council (EWC)?</para>
    /// labels<para>Has EWC</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#ewc">http://w3id.org/um/cbcm/eu-cm-ontology#ewc</seealso>
    let ewc = Prefixed_Name(cbcm, "ewc") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:hasCompanyForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Company legal form. Name given to describe the structure of a corporation or buiness in the different legal orders. For example Limited (Ltd.), Public Limited Company (PLC), Gesellschaft mit beschränkter Haftung (GmbH), Aktiengesellschaft (AG). The company legal form is regulated under national law and grants specific rights and obligations to the company stakeholders (such as shareholders, management &amp; employees).</para>
    /// labels<para>Company Form</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#hasCompanyForm">http://w3id.org/um/cbcm/eu-cm-ontology#hasCompanyForm</seealso>
    let hasCompanyForm = Prefixed_Name(cbcm, "hasCompanyForm") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:hasOriginalCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(hasOriginalCompany ?ENTITY1 ?ENTITY2) means that some company division transaction ?ENTITY1 involves a company ?ENTITY2 which will be divided (or "split") into multiple recipient or emerging companies.</para>
    /// labels<para>has original company</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#hasOriginalCompany">http://w3id.org/um/cbcm/eu-cm-ontology#hasOriginalCompany</seealso>
    let hasOriginalCompany = Prefixed_Name(cbcm, "hasOriginalCompany") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:ConversionCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A document issued by a Competent Authority declaring that the legally required steps of a conversion are completed. The certificate needs to be presented by a company to either be registered in another company registry or to be removed from a company register.</para>
    /// labels<para>Company conversion certificate</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#ConversionCertificate">http://w3id.org/um/cbcm/eu-cm-ontology#ConversionCertificate</seealso>
    let ConversionCertificate =
        Prefixed_Name(cbcm, "ConversionCertificate") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:Court</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Legal forum in which a body of people presided over by a judge, judges, or magistrate, and acting as a tribunal in civil and criminal cases resolve legal disputes.</para>
    /// labels<para>Court</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#Court">http://w3id.org/um/cbcm/eu-cm-ontology#Court</seealso>
    let Court = Prefixed_Name(cbcm, "Court") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:CrossBorderMerger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A cross border merger involves at least one company based in an EU Member State and one company that is registered elsewhere within the European Union and is leading to a universal transfer of assets and liabilities from the merging company to the acquiring company.</para>
    /// labels<para>Cross-border merger</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderMerger">http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderMerger</seealso>
    let CrossBorderMerger = Prefixed_Name(cbcm, "CrossBorderMerger") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:france</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:EUCountry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>République française</para><para>French Republic</para><para>France</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#france">http://w3id.org/um/cbcm/eu-cm-ontology#france</seealso>
    let france = Prefixed_Name(cbcm, "france") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:greece</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cbcm:EUCountry</para>
    ///
    /// labels<para>Ellada</para><para>Greece</para><para>Ελλάδα</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#greece">http://w3id.org/um/cbcm/eu-cm-ontology#greece</seealso>
    let greece = Prefixed_Name(cbcm, "greece") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:hungary</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:EUCountry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Magyarország</para><para>Hungary</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#hungary">http://w3id.org/um/cbcm/eu-cm-ontology#hungary</seealso>
    let hungary = Prefixed_Name(cbcm, "hungary") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:iceland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cbcm:EEACountry</para>
    ///
    /// labels<para>Iceland</para><para>Ísland</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#iceland">http://w3id.org/um/cbcm/eu-cm-ontology#iceland</seealso>
    let iceland = Prefixed_Name(cbcm, "iceland") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:ireland</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:EUCountry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Ireland</para><para>Éire</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#ireland">http://w3id.org/um/cbcm/eu-cm-ontology#ireland</seealso>
    let ireland = Prefixed_Name(cbcm, "ireland") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:isSECreation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Variable indicating whether this case concerns an SE-creation (yes/no) to distinguish creations of SEs from other transactions</para>
    /// labels<para>Is SE creation</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#isSECreation">http://w3id.org/um/cbcm/eu-cm-ontology#isSECreation</seealso>
    let isSECreation = Prefixed_Name(cbcm, "isSECreation") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:impactOnEmployees</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Is the impact on employees of the envisaged transaction specified in the transaction document (e.g. the merger plan)?
    ///
    /// Part of merger plan that specifies how the transaction will affect employees.
    ///
    /// - Yes: there is an impact on employees (positive or negative);
    /// - No: no impact on employees;
    /// - Not applicable: the conditions are not met (e.g. no employees, BLER threshold not met) for this criterion to be applicable;
    /// - Unclear: the wording of the document is unclear with regard to the impact/effect/measures taken;
    /// - Not mentioned: given the parameters, this aspect should be addressed in the transaction document, but is not mentioned</para>
    /// labels<para>Impact on employees</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#impactOnEmployees">http://w3id.org/um/cbcm/eu-cm-ontology#impactOnEmployees</seealso>
    let impactOnEmployees = Prefixed_Name(cbcm, "impactOnEmployees") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:DomesticDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A company which in a process of the domestic division - in case of a full division - transfers all its assets and liabilities to two or more companies, or - in case of a partial division or division by separation - transfers part of its assets and liabilities to one or more companies. All companies involved in the process are located in a single country.</para>
    /// labels<para>Company domestic division</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticDivision">http://w3id.org/um/cbcm/eu-cm-ontology#DomesticDivision</seealso>
    let DomesticDivision = Prefixed_Name(cbcm, "DomesticDivision") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:isListed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Whether the company is publicly listed. A company whose shares are bought and sold on a particular stock market.</para>
    /// labels<para>Is listed</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#isListed">http://w3id.org/um/cbcm/eu-cm-ontology#isListed</seealso>
    let isListed = Prefixed_Name(cbcm, "isListed") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:issuedByOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(issuedByOrganisation ?ENTITY1 ?ENTITY2) means that some document or publication, ?ENTITY1, was created (and possibly delivered or administered to another entity) by some entity ?ENTITY2.</para>
    /// labels<para>issued by organisation</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#issuedByOrganisation">http://w3id.org/um/cbcm/eu-cm-ontology#issuedByOrganisation</seealso>
    let issuedByOrganisation =
        Prefixed_Name(cbcm, "issuedByOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:italy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cbcm:EUCountry</para>
    ///
    /// labels<para>Repubblica Italiana</para><para>Italian Republic</para><para>Italia</para><para>Italy</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#italy">http://w3id.org/um/cbcm/eu-cm-ontology#italy</seealso>
    let italy = Prefixed_Name(cbcm, "italy") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:lastWWEmploymentFigure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Last available employment figure for the total worldwide employees</para>
    /// labels<para>Last WW employment figure</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#lastWWEmploymentFigure">http://w3id.org/um/cbcm/eu-cm-ontology#lastWWEmploymentFigure</seealso>
    let lastWWEmploymentFigure =
        Prefixed_Name(cbcm, "lastWWEmploymentFigure") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:TransactionRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A legal right of a legal entity involved in the process of a company transaction. A legal right here refers to the entitlement of a person to be allowed to perform an activity, or to possess or obtain access to an object.</para>
    /// labels<para>Transaction right</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#TransactionRight">http://w3id.org/um/cbcm/eu-cm-ontology#TransactionRight</seealso>
    let TransactionRight = Prefixed_Name(cbcm, "TransactionRight") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:Resolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A document detailing a decision made by an individual or group of natural or legal persons. This can be a decision concerning the restructuring of a company by its shareholders.</para>
    /// labels<para>Resolution</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#Resolution">http://w3id.org/um/cbcm/eu-cm-ontology#Resolution</seealso>
    let Resolution = Prefixed_Name(cbcm, "Resolution") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:CBCMResearcher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A person that is interested in research about cross-border company mobility, and actively collects and analyses data concerning cross-border company mobility.</para>
    /// labels<para>Cross-border company mobility researcher</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CBCMResearcher">http://w3id.org/um/cbcm/eu-cm-ontology#CBCMResearcher</seealso>
    let CBCMResearcher = Prefixed_Name(cbcm, "CBCMResearcher") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:ParentCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A parent company is a company that has a controlling interest in another company, the subsidiary company, giving it control of its operations through a majority stock-ownership, decisive control over management appointments and therefore over the decision-making process. In the absence of a natural person as ultimate beneficial owner, the highest parent company in a chain of companies is the global ultimate owner.</para>
    /// labels<para>Parent company</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#ParentCompany">http://w3id.org/um/cbcm/eu-cm-ontology#ParentCompany</seealso>
    let ParentCompany = Prefixed_Name(cbcm, "ParentCompany") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:hasSubsidiaryCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(hasSubsidiaryCompany ?ENTITY1 ?ENTITY2) means (hasParentCompany ?ENTITY2 ?ENTITY1)</para>
    /// labels<para>has subsidiary company</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#hasSubsidiaryCompany">http://w3id.org/um/cbcm/eu-cm-ontology#hasSubsidiaryCompany</seealso>
    let hasSubsidiaryCompany =
        Prefixed_Name(cbcm, "hasSubsidiaryCompany") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:spain</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:EUCountry</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#spain">http://w3id.org/um/cbcm/eu-cm-ontology#spain</seealso>
    let spain = Prefixed_Name(cbcm, "spain") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:sweden</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:EUCountry</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#sweden">http://w3id.org/um/cbcm/eu-cm-ontology#sweden</seealso>
    let sweden = Prefixed_Name(cbcm, "sweden") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:switzerland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cbcm:EEACountry</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#switzerland">http://w3id.org/um/cbcm/eu-cm-ontology#switzerland</seealso>
    let switzerland = Prefixed_Name(cbcm, "switzerland") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:EEACountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Created in 1994, the European Economic Area (EEA) combines the countries of the European Union (EU) and member countries of the European Free Trade Association (EFTA) to facilitate participation in the European Market trade and movement without having to apply to be one of the EU member countries</para>
    /// labels<para>European Economic Area country</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#EEACountry">http://w3id.org/um/cbcm/eu-cm-ontology#EEACountry</seealso>
    let EEACountry = Prefixed_Name(cbcm, "EEACountry") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:latvia</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:EUCountry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Latvijas Republika</para><para>Republic of Latvia</para><para>Latvija</para><para>Latvia</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#latvia">http://w3id.org/um/cbcm/eu-cm-ontology#latvia</seealso>
    let latvia = Prefixed_Name(cbcm, "latvia") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:lawfirm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Name of the lawfirm involved in the transaction, if available (for internal use; cross-border divisions and seat transfers are currently not possible within an EU legal framework.)</para>
    /// labels<para>Law Firm</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#lawfirm">http://w3id.org/um/cbcm/eu-cm-ontology#lawfirm</seealso>
    let lawfirm = Prefixed_Name(cbcm, "lawfirm") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:lithuania</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cbcm:EUCountry</para>
    ///
    /// labels<para>Republic of Lithuania</para><para>Lietuvos Respublika</para><para>Lithuania</para><para>Lietuva</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#lithuania">http://w3id.org/um/cbcm/eu-cm-ontology#lithuania</seealso>
    let lithuania = Prefixed_Name(cbcm, "lithuania") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:CompanyMobilityDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A legal document which provides information related to, or influencing, a company's mobility within a specific country or across national boundaries.</para>
    /// labels<para>Company mobility document</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyMobilityDocument">http://w3id.org/um/cbcm/eu-cm-ontology#CompanyMobilityDocument</seealso>
    let CompanyMobilityDocument =
        Prefixed_Name(cbcm, "CompanyMobilityDocument") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#">http://w3id.org/um/cbcm/eu-cm-ontology#</seealso>
    let _prefix_iri = Prefixed_Name(cbcm, "") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:maintains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(maintains ?ENTITY1 ?ENTITY2) means (maintainedBy ?ENTITY2 ?ENTITY1)</para>
    /// labels<para>maintains</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#maintains">http://w3id.org/um/cbcm/eu-cm-ontology#maintains</seealso>
    let maintains = Prefixed_Name(cbcm, "maintains") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:multiCBM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A transaction whereby more than two companies (i.e. multiple merging companies) are involved and merged into one acquiring company</para>
    /// labels<para>Multi-transaction</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#multiCBM">http://w3id.org/um/cbcm/eu-cm-ontology#multiCBM</seealso>
    let multiCBM = Prefixed_Name(cbcm, "multiCBM") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:naceSector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Company NACE sector. NACE (Nomenclature of Economic Activities) is the European statistical classification of economic activities. Classification of a company according to which kinds of sector (i.e. industry / market / product type) they deal in. From EUROSTAT</para>
    /// labels<para>NACE sector</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#naceSector">http://w3id.org/um/cbcm/eu-cm-ontology#naceSector</seealso>
    let naceSector = Prefixed_Name(cbcm, "naceSector") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of the organization</para>
    /// labels<para>Organization name</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#name">http://w3id.org/um/cbcm/eu-cm-ontology#name</seealso>
    let name = Prefixed_Name(cbcm, "name") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:negotiatedAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Is the management of the companies involved starting the process of setting up a Special Negotiating Body (SNB) in order to reach a negotiated agreement on the future employee participation mechanism (BLER) after the transaction?
    ///
    /// BLER (Board-Level Employee Represenation): highest level of employee involvement in a company in the supervisory board. They can take co-determine decisions of the company's management and where the company is heading.
    ///
    /// - Yes: there is a negotiated agreement to be negotiated with the SNB;
    /// - No: no negotiated agreement;
    /// - Not applicable: the conditions are not met (e.g. no employees, BLER threshold not met) for this criterion to be applicable;
    /// - Unclear: the wording of the document is unclear with regard to the impact/effect/measures taken;
    /// - Not mentioned: given the parameters, this aspect should be addressed in the transaction document, but is not mentioned</para>
    /// labels<para>Has negotiated agreement</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#negotiatedAgreement">http://w3id.org/um/cbcm/eu-cm-ontology#negotiatedAgreement</seealso>
    let negotiatedAgreement = Prefixed_Name(cbcm, "negotiatedAgreement") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:norway</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:EEACountry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Norgga gonagasriika</para><para>Kingdom of Norway</para><para>Kongeriket Noreg</para><para>Kongeriket Norge</para><para>Nöörjen</para><para>Norgga</para><para>Norway</para><para>Noreg</para><para>Vuona</para><para>Norge</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#norway">http://w3id.org/um/cbcm/eu-cm-ontology#norway</seealso>
    let norway = Prefixed_Name(cbcm, "norway") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:poland</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:EUCountry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Rzeczpospolita Polska</para><para>Republic of Poland</para><para>Poland</para><para>Polska</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#poland">http://w3id.org/um/cbcm/eu-cm-ontology#poland</seealso>
    let poland = Prefixed_Name(cbcm, "poland") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:portugal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cbcm:EUCountry</para>
    ///
    /// labels<para>República Portuguesa</para><para>Portuguese Republic</para><para>Portugal</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#portugal">http://w3id.org/um/cbcm/eu-cm-ontology#portugal</seealso>
    let portugal = Prefixed_Name(cbcm, "portugal") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:DocumentRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A digital document repository containing documents related to company mobility.</para>
    /// labels<para>Company mobility document repository</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#DocumentRepository">http://w3id.org/um/cbcm/eu-cm-ontology#DocumentRepository</seealso>
    let DocumentRepository = Prefixed_Name(cbcm, "DocumentRepository") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:InformationRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The right of employees or their representatives to be informed and to receive any documents necessary for the exercise of their consultation and board-level employee representation rights in the context of an intended merger/division/conversion/seat transfer.</para>
    /// labels<para>Information right</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#InformationRight">http://w3id.org/um/cbcm/eu-cm-ontology#InformationRight</seealso>
    let InformationRight = Prefixed_Name(cbcm, "InformationRight") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:IndependentExpert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Independent Expert provides impartial advice to shareholders and other company stakeholders on the fairness and/or reasonableness of a transaction.  A company may be required to commission an Independent Expert Report (IER) in the case of a (cross-border) merger, division or conversion.</para>
    /// labels<para>Independent expert</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#IndependentExpert">http://w3id.org/um/cbcm/eu-cm-ontology#IndependentExpert</seealso>
    let IndependentExpert = Prefixed_Name(cbcm, "IndependentExpert") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:legalFormAcronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The acronym of a company legal form</para>
    /// labels<para>Legal form acronym</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#legalFormAcronym">http://w3id.org/um/cbcm/eu-cm-ontology#legalFormAcronym</seealso>
    let legalFormAcronym = Prefixed_Name(cbcm, "legalFormAcronym") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:liechtenstein</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:EEACountry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Principality of Liechtenstein</para><para>Fürstentum Liechtenstein</para><para>Liechtenstein</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#liechtenstein">http://w3id.org/um/cbcm/eu-cm-ontology#liechtenstein</seealso>
    let liechtenstein = Prefixed_Name(cbcm, "liechtenstein") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:luxembourg</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:EUCountry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Groussherzogtum Lëtzebuerg</para><para>Grand-Duché de Luxembourg</para><para>Grand Duchy of Luxembourg</para><para>Großherzogtum Luxemburg​</para><para>Lëtzebuerg</para><para>Luxembourg</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#luxembourg">http://w3id.org/um/cbcm/eu-cm-ontology#luxembourg</seealso>
    let luxembourg = Prefixed_Name(cbcm, "luxembourg") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:malta</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:EUCountry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Repubblika ta' Malta</para><para>Melita</para><para>Malta</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#malta">http://w3id.org/um/cbcm/eu-cm-ontology#malta</seealso>
    let malta = Prefixed_Name(cbcm, "malta") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:mcEmploymentFigureAtTransaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of employees of the acquiring company - at the moment of the transaction</para>
    /// labels<para>MC Employees count at transaction</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#mcEmploymentFigureAtTransaction">http://w3id.org/um/cbcm/eu-cm-ontology#mcEmploymentFigureAtTransaction</seealso>
    let mcEmploymentFigureAtTransaction =
        Prefixed_Name(cbcm, "mcEmploymentFigureAtTransaction") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:mcLastEmploymentFigure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The last available annual employment figure for the merging company</para>
    /// labels<para>Last employment figure for the merging company</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#mcLastEmploymentFigure">http://w3id.org/um/cbcm/eu-cm-ontology#mcLastEmploymentFigure</seealso>
    let mcLastEmploymentFigure =
        Prefixed_Name(cbcm, "mcLastEmploymentFigure") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:isTransactionResultOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(isTransactionResultOf ?ENTITY1 ?ENTITY2) means (hasTransactionResult ?ENTITY2 ?ENTITY1)</para>
    /// labels<para>is transaction result of</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#isTransactionResultOf">http://w3id.org/um/cbcm/eu-cm-ontology#isTransactionResultOf</seealso>
    let isTransactionResultOf =
        Prefixed_Name(cbcm, "isTransactionResultOf") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:AnnualAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Annual reports measure a company's financial health. They focus on past and present financial performance, and make predictions about future prospects. The revenue and financial performance of a company.</para>
    /// labels<para>Annual account</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#AnnualAccount">http://w3id.org/um/cbcm/eu-cm-ontology#AnnualAccount</seealso>
    let AnnualAccount = Prefixed_Name(cbcm, "AnnualAccount") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:OfficialJournal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The official gazette of record for the European Union or national gazette of record of a Member State. In the official journal companies publish transaction notices in order to inform concerned stakeholders and interested parties.</para>
    /// labels<para>Official journal</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#OfficialJournal">http://w3id.org/um/cbcm/eu-cm-ontology#OfficialJournal</seealso>
    let OfficialJournal = Prefixed_Name(cbcm, "OfficialJournal") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:MergerCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A document issued by a Competent Authority declaring that the legally required steps of a merger are completed. The certificate needs to be presented by a company to either be registered in another company registry or to be removed from a company register (depending on the company being the merging or acquiring company).</para>
    /// labels<para>Company merger certificate</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#MergerCertificate">http://w3id.org/um/cbcm/eu-cm-ontology#MergerCertificate</seealso>
    let MergerCertificate = Prefixed_Name(cbcm, "MergerCertificate") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:MemberStateOfficialJournal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The national gazette or record in a particular Member State. In the official journal companies publish company transaction notices in order to inform concerned stakeholders and interested parties.</para>
    /// labels<para>Member State Official Journal</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#MemberStateOfficialJournal">http://w3id.org/um/cbcm/eu-cm-ontology#MemberStateOfficialJournal</seealso>
    let MemberStateOfficialJournal =
        Prefixed_Name(cbcm, "MemberStateOfficialJournal") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:mcYearEmploymentFigure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The year the last annual employment figure was obtained for merging companies</para>
    /// labels<para>MC Last employment figure year</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#mcYearEmploymentFigure">http://w3id.org/um/cbcm/eu-cm-ontology#mcYearEmploymentFigure</seealso>
    let mcYearEmploymentFigure =
        Prefixed_Name(cbcm, "mcYearEmploymentFigure") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:naceCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>NACE Classification Code for companies. NACE (Nomenclature des Activités Économiques dans la Communauté Européenne) is a European industry standard classification system similar in function to Standard Industry Classification (SIC) and North American Industry Classification System (NAICS) for classifying business activities. From EUROSTAT</para>
    /// labels<para>NACE code</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#naceCode">http://w3id.org/um/cbcm/eu-cm-ontology#naceCode</seealso>
    let naceCode = Prefixed_Name(cbcm, "naceCode") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:natRegistrationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The national registration number of an acquiring/receiving/entry company. A company registration number is a unique combination of numbers and/or letters. It is used to identify a company and verify its legal existence as an incorporated entity.</para>
    /// labels<para>NAT registration number</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#natRegistrationNumber">http://w3id.org/um/cbcm/eu-cm-ontology#natRegistrationNumber</seealso>
    let natRegistrationNumber =
        Prefixed_Name(cbcm, "natRegistrationNumber") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:netherlands</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:EUCountry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>The Netherlands</para><para>Netherlands</para><para>Nederland</para><para>Holland</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#netherlands">http://w3id.org/um/cbcm/eu-cm-ontology#netherlands</seealso>
    let netherlands = Prefixed_Name(cbcm, "netherlands") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:ownedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(ownedBy ?ENTITY1 ?ENTITY2) means that some agent ?ENTITY2 has proprietorship over another object or organisational agent ?ENTITY1.</para>
    /// labels<para>owned by</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#ownedBy">http://w3id.org/um/cbcm/eu-cm-ontology#ownedBy</seealso>
    let ownedBy = Prefixed_Name(cbcm, "ownedBy") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:locatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(locatedIn ?ENTITY1 ?ENTITY2) means that some entity ?ENTITY1 occupies the spatial region referred to by ?ENTITY2.</para>
    /// labels<para>located in</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#locatedIn">http://w3id.org/um/cbcm/eu-cm-ontology#locatedIn</seealso>
    let locatedIn = Prefixed_Name(cbcm, "locatedIn") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(hasPart ?ENTITY1 ?ENTITY2) means that the entity referred to by ?ENTITY1 has a constituent entity referred to by ?ENTITY2.</para>
    /// labels<para>has part</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#hasPart">http://w3id.org/um/cbcm/eu-cm-ontology#hasPart</seealso>
    let hasPart = Prefixed_Name(cbcm, "hasPart") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:CompanyCentralAdministration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The headquarters or body of a company which governs it's financial and administrative activities</para>
    /// labels<para>Central Administration</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyCentralAdministration">http://w3id.org/um/cbcm/eu-cm-ontology#CompanyCentralAdministration</seealso>
    let CompanyCentralAdministration =
        Prefixed_Name(cbcm, "CompanyCentralAdministration") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:SEType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Variable indicating the SE-establishment mode: by merger, conversion, holding-SE, subsidiary-SE or unsure (cases)</para>
    /// labels<para>Societas Europaea (SE) type</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#SEType">http://w3id.org/um/cbcm/eu-cm-ontology#SEType</seealso>
    let SEType = Prefixed_Name(cbcm, "SEType") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:ShareholderExitRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The right of a shareholder to exit the company by being bought out.</para>
    /// labels<para>Shareholder exit right</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#ShareholderExitRight">http://w3id.org/um/cbcm/eu-cm-ontology#ShareholderExitRight</seealso>
    let ShareholderExitRight =
        Prefixed_Name(cbcm, "ShareholderExitRight") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:ShareholderResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>a shareholder resolution is a proposal submitted by shareholders for a vote at the company's shareholder meeting.</para>
    /// labels<para>Shareholder resolution</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#ShareholderResolution">http://w3id.org/um/cbcm/eu-cm-ontology#ShareholderResolution</seealso>
    let ShareholderResolution =
        Prefixed_Name(cbcm, "ShareholderResolution") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:City</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A city (plural "cities") is a geo-political region in which there is a large human settlement. The distinction with the term "town" (plural "towns") is that cities are generally larger than towns. Countries are generally larger than cities and, in fact, usually consist of multiple cities.</para>
    /// labels<para>City</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#City">http://w3id.org/um/cbcm/eu-cm-ontology#City</seealso>
    let City = Prefixed_Name(cbcm, "City") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:CompanyRegisteredOffice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The physical address or location at which the primary business activities of a company are carried out.</para>
    /// labels<para>Registered office</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyRegisteredOffice">http://w3id.org/um/cbcm/eu-cm-ontology#CompanyRegisteredOffice</seealso>
    let CompanyRegisteredOffice =
        Prefixed_Name(cbcm, "CompanyRegisteredOffice") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A geo-political region that has a distinct and common political governance structure for people that inhabit it for a significant portion of their lives. The majority of people that inhabit such a region are also usually united by common descent, history, culture and language.</para>
    /// labels<para>Country</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#Country">http://w3id.org/um/cbcm/eu-cm-ontology#Country</seealso>
    let Country = Prefixed_Name(cbcm, "Country") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:CreditorDecisionRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The right of a creditor to influence or take a decision in the context of a transaction.</para>
    /// labels<para>Creditor decision right</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CreditorDecisionRight">http://w3id.org/um/cbcm/eu-cm-ontology#CreditorDecisionRight</seealso>
    let CreditorDecisionRight =
        Prefixed_Name(cbcm, "CreditorDecisionRight") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:CreditorRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The rights of creditors, which includes debenture holders, vis-a-vis the company that obtained credit from the individual or organisation. Legal safeguards are put in place to ensure that rights of creditors are not negatively affected by a company transaction.</para>
    /// labels<para>Creditor right</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CreditorRight">http://w3id.org/um/cbcm/eu-cm-ontology#CreditorRight</seealso>
    let CreditorRight = Prefixed_Name(cbcm, "CreditorRight") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:CreditorExitRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The creditors right to be paid out and therefore to exit the company in the context of a transaction.</para>
    /// labels<para>Creditor exit right</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CreditorExitRight">http://w3id.org/um/cbcm/eu-cm-ontology#CreditorExitRight</seealso>
    let CreditorExitRight = Prefixed_Name(cbcm, "CreditorExitRight") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:CreditorInformationRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The information rights of creditors in the context of a company transaction, which includes for instance access to documents.</para>
    /// labels<para>Creditor information right</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CreditorInformationRight">http://w3id.org/um/cbcm/eu-cm-ontology#CreditorInformationRight</seealso>
    let CreditorInformationRight =
        Prefixed_Name(cbcm, "CreditorInformationRight") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:applicableTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(applicableTo ?ENTITY1 ?ENTITY2) means that some legal right ?ENTITY1 is awarded or assigned to a particular person or agent ?ENTITY2.</para>
    /// labels<para>applicable to</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#applicableTo">http://w3id.org/um/cbcm/eu-cm-ontology#applicableTo</seealso>
    let applicableTo = Prefixed_Name(cbcm, "applicableTo") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:CreditorSecurityRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Member States shall provide for an adequate system of protection of the interest of creditors, and shall ensure that creditors who are dissatisfied with the safeguards offered in the draft terms of the transaction, as provided for in Article 86d (1) point (f), may apply to the appropriate administrative or judicial authority for adequate safeguards provided that they can credibly demonstrate that due to the transaction the satisfaction of their claims is at stake and that no adequate safeguards have been obtained from the company.</para>
    /// labels<para>Creditor security right</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CreditorSecurityRight">http://w3id.org/um/cbcm/eu-cm-ontology#CreditorSecurityRight</seealso>
    let CreditorSecurityRight =
        Prefixed_Name(cbcm, "CreditorSecurityRight") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:CrossBorderConversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A cross-border conversion is an operation through which a company, formed in one country (with the EU/EEA set of countries) is converted into a company governed by the law of another.</para>
    /// labels<para>Cross-border conversion</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderConversion">http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderConversion</seealso>
    let CrossBorderConversion =
        Prefixed_Name(cbcm, "CrossBorderConversion") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:PreConversionCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Article 86m: a pre-conversion certificate attests compliance with all the relevant conditions and the proper completion of all procedures and formalities in the departure Member State.</para>
    /// labels<para>Company pre-conversion certificate</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#PreConversionCertificate">http://w3id.org/um/cbcm/eu-cm-ontology#PreConversionCertificate</seealso>
    let PreConversionCertificate =
        Prefixed_Name(cbcm, "PreConversionCertificate") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:involvesCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(involvesCountry ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 includes the modification of a company whose place of business is located in the country referred to by ?ENTITY2</para>
    /// labels<para>involves country</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#involvesCountry">http://w3id.org/um/cbcm/eu-cm-ontology#involvesCountry</seealso>
    let involvesCountry = Prefixed_Name(cbcm, "involvesCountry") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:CrossBorderDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A company which in a process of the cross-border division in case of a full division transfers all its assets and liabilities to two or more companies, or in case of a partial division or division by separation transfers part of its assets and liabilities to one or more companies. The companies involved in the process are located in multiple (two or more) distinct countries.</para>
    /// labels<para>Cross-border company division</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderDivision">http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderDivision</seealso>
    let CrossBorderDivision = Prefixed_Name(cbcm, "CrossBorderDivision") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:MergingCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Merging Company means the dissolving company that is being acquired by another (acquiring) company in the process of a transaction. In the context of company mobility, this means a universal transfer of assets and liabilities from the merging to the acquiring company (see article 131 of Directive 2017/1132).</para>
    /// labels<para>Merging company</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#MergingCompany">http://w3id.org/um/cbcm/eu-cm-ontology#MergingCompany</seealso>
    let MergingCompany = Prefixed_Name(cbcm, "MergingCompany") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:CrossBorderMergerByAcquisition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Article 89: The operation whereby one or more companies are wound up without going into liquidation and transfer to another all their assets and liabilities in exchange for the issue to the shareholders of the company or companies being acquired of shares in the acquiring company and a cash payment, if any, not exceeding 10 % of the nominal value of the shares so issued or, where they have no nominal value, of their accounting par value. Companies involved come from two or more distinct countries.</para>
    /// labels<para>Cross-border company merger by acquisition</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderMergerByAcquisition">http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderMergerByAcquisition</seealso>
    let CrossBorderMergerByAcquisition =
        Prefixed_Name(cbcm, "CrossBorderMergerByAcquisition") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:hasMergingCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(hasMergingCompany ?ENTITY1 ?ENTITY2) means that some company merger transaction ?ENTITY1 involves a company ?ENTITY2 which will be dissolved during the process of ?ENTITY1 and will be acquired (via a universal transfer of assets and liabilities) by another distinct company involved in ?ENTITY1.</para>
    /// labels<para>has merging company</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#hasMergingCompany">http://w3id.org/um/cbcm/eu-cm-ontology#hasMergingCompany</seealso>
    let hasMergingCompany = Prefixed_Name(cbcm, "hasMergingCompany") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:hasAcquiringCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(hasAcquiringCompany ?ENTITY1 ?ENTITY2) means that some company merger transaction ?ENTITY1 produces a new company or alters an existing one (?ENTITY2) such that ?ENTITY2 will acquire (via a universal transfer of assets and liabilities) one or more other companies involved in the process ?ENTITY1.</para>
    /// labels<para>has acquiring company</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#hasAcquiringCompany">http://w3id.org/um/cbcm/eu-cm-ontology#hasAcquiringCompany</seealso>
    let hasAcquiringCompany = Prefixed_Name(cbcm, "hasAcquiringCompany") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:CrossBorderMergerIntoNewCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Article 90: the operation whereby several companies are wound up without going into liquidation and transfer to a company that they set up all their assets and liabilities in exchange for the issue to their shareholders of shares in the new company and a cash payment, if any, not exceeding 10 % of the nominal value of the shares so issued or, where they have no nominal value, of their accounting par value. Companies involved come from two or more distinct countries.</para>
    /// labels<para>Cross-border merger into a new company</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderMergerIntoNewCompany">http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderMergerIntoNewCompany</seealso>
    let CrossBorderMergerIntoNewCompany =
        Prefixed_Name(cbcm, "CrossBorderMergerIntoNewCompany") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:CrossBorderSeatTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The act of changing the location where the company’s business was managed (registered office or headquarters) or the place where that company’s primary business was actually conducted (central administration), across national boundaries.</para>
    /// labels<para>Cross-border company seat transfer</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderSeatTransfer">http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderSeatTransfer</seealso>
    let CrossBorderSeatTransfer =
        Prefixed_Name(cbcm, "CrossBorderSeatTransfer") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:DataCurationActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A data curation activity represents a researcher's involvement in annotating cross border transactions</para>
    /// labels<para>Data curation activity</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#DataCurationActivity">http://w3id.org/um/cbcm/eu-cm-ontology#DataCurationActivity</seealso>
    let DataCurationActivity =
        Prefixed_Name(cbcm, "DataCurationActivity") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:used</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Usage is the beginning of utilizing an entity by an activity. Before usage, the activity had not begun to utilize this entity and could not have been affected by the entity.
    ///
    /// Based on: https://www.w3.org/TR/prov-o/#used</para>
    /// labels<para>Used</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#used">http://w3id.org/um/cbcm/eu-cm-ontology#used</seealso>
    let used = Prefixed_Name(cbcm, "used") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:wasAssociatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An activity association is an assignment of responsibility to an agent for a process, indicating that the agent had a role in the activity.
    ///
    /// Based on: https://www.w3.org/TR/prov-o/#wasAssociatedWith</para>
    /// labels<para>Associated with</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#wasAssociatedWith">http://w3id.org/um/cbcm/eu-cm-ontology#wasAssociatedWith</seealso>
    let wasAssociatedWith = Prefixed_Name(cbcm, "wasAssociatedWith") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:DecisionRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The shareholders can take a number of decisions affecting the company, such as amending the company's articles of association, appointing or dismissing board members and to approve important transactions (e.g. mergers, divisions and conversions/seat transfers). These are taken through a shareholder resolution.</para>
    /// labels<para>Shareholder decision right</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#DecisionRight">http://w3id.org/um/cbcm/eu-cm-ontology#DecisionRight</seealso>
    let DecisionRight = Prefixed_Name(cbcm, "DecisionRight") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:ShareholderRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The rights of shareholders of a company in the context of a transaction. Often, shreholder resolutions are used to effectuate shareholder rights. Many rights are laid down in the so-called Shareholder Rights Directive.</para>
    /// labels<para>Shareholder right</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#ShareholderRight">http://w3id.org/um/cbcm/eu-cm-ontology#ShareholderRight</seealso>
    let ShareholderRight = Prefixed_Name(cbcm, "ShareholderRight") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:DivisionCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A document issued by a Competent Authority declaring that the legally required steps of a division are completed. The certificate needs to be presented by a company to either be registered (or register a newly established emerging/recipient company) in another company registry or to be removed from a company register.</para>
    /// labels<para>Company division certificate</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#DivisionCertificate">http://w3id.org/um/cbcm/eu-cm-ontology#DivisionCertificate</seealso>
    let DivisionCertificate = Prefixed_Name(cbcm, "DivisionCertificate") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:DomesticConversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A domestic conversion is an operation through which a company's form is converted into a another while still remaining governed by the same law as the original company. For instance, the modification of a company's form from a public to a private limited company.</para>
    /// labels<para>Domestic company conversion</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticConversion">http://w3id.org/um/cbcm/eu-cm-ontology#DomesticConversion</seealso>
    let DomesticConversion = Prefixed_Name(cbcm, "DomesticConversion") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:DomesticMerger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A domestic merger involves at least two companies based in the same EU Member State and is leading to a universal transfer of assets and liabilities from the merging company to the acquiring company.</para>
    /// labels<para>Company domestic merger</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticMerger">http://w3id.org/um/cbcm/eu-cm-ontology#DomesticMerger</seealso>
    let DomesticMerger = Prefixed_Name(cbcm, "DomesticMerger") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:DomesticMergerByAcquisition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Article 89: The operation whereby one or more companies are wound up without going into liquidation and transfer to another all their assets and liabilities in exchange for the issue to the shareholders of the company or companies being acquired of shares in the acquiring company and a cash payment, if any, not exceeding 10 % of the nominal value of the shares so issued or, where they have no nominal value, of their accounting par value. All companies involved are from a single country.</para>
    /// labels<para>Domestic company merger by acquisition</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticMergerByAcquisition">http://w3id.org/um/cbcm/eu-cm-ontology#DomesticMergerByAcquisition</seealso>
    let DomesticMergerByAcquisition =
        Prefixed_Name(cbcm, "DomesticMergerByAcquisition") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:DomesticMergerIntoNewCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Article 90: the operation whereby several companies are wound up without going into liquidation and transfer to a company that they set up all their assets and liabilities in exchange for the issue to their shareholders of shares in the new company and a cash payment, if any, not exceeding 10 % of the nominal value of the shares so issued or, where they have no nominal value, of their accounting par value. All companies involved are from a single country.</para>
    /// labels<para>Domestic merger into a new company</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticMergerIntoNewCompany">http://w3id.org/um/cbcm/eu-cm-ontology#DomesticMergerIntoNewCompany</seealso>
    let DomesticMergerIntoNewCompany =
        Prefixed_Name(cbcm, "DomesticMergerIntoNewCompany") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:EmergingCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A company being divided transfers part of its assets and liabilities to one or more newly formed companies, which are the recipient companies in a (cross-border) division.</para>
    /// labels<para>Emerging company</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#EmergingCompany">http://w3id.org/um/cbcm/eu-cm-ontology#EmergingCompany</seealso>
    let EmergingCompany = Prefixed_Name(cbcm, "EmergingCompany") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:DomesticSeatTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The act of changing the location where the company’s business was managed (registered office or headquarters) or the place where that company’s primary business was actually conducted (central administration), within a specific country.</para>
    /// labels<para>Domestic company seat transfer</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticSeatTransfer">http://w3id.org/um/cbcm/eu-cm-ontology#DomesticSeatTransfer</seealso>
    let DomesticSeatTransfer =
        Prefixed_Name(cbcm, "DomesticSeatTransfer") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:NonEEACountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A country which does not belong to the European Economic Area (EEA).</para>
    /// labels<para>Non-EEA country</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#NonEEACountry">http://w3id.org/um/cbcm/eu-cm-ontology#NonEEACountry</seealso>
    let NonEEACountry = Prefixed_Name(cbcm, "NonEEACountry") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:EUCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A country which forms part of the European Union. The European Union is a conglomeration of European countries whose governance structures agree to abide with common political and economic criteria to improve efficiency of goods and services trading as well as movement and migration of inhabitants between these countries</para>
    /// labels<para>EU country</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#EUCountry">http://w3id.org/um/cbcm/eu-cm-ontology#EUCountry</seealso>
    let EUCountry = Prefixed_Name(cbcm, "EUCountry") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:NonEUCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A country that does not officially belong to the EU conglomeration</para>
    /// labels<para>Non-EU country</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#NonEUCountry">http://w3id.org/um/cbcm/eu-cm-ontology#NonEUCountry</seealso>
    let NonEUCountry = Prefixed_Name(cbcm, "NonEUCountry") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:employedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(employedBy ?ENTITY1 ?ENTITY2) means that some agent (person or organisation) ?ENTITY1 is promised and delivered an incentive (usually financial) to perform some work for ?ENTITY2 where ?ENTITY2 is an organisation. This exchange is usually governed by law and formal regulations in the particular country or social context in which the work is being performed.</para>
    /// labels<para>employed by</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#employedBy">http://w3id.org/um/cbcm/eu-cm-ontology#employedBy</seealso>
    let employedBy = Prefixed_Name(cbcm, "employedBy") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:FinancialServiceAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A body that regulates the financial services industry in a country (e.g. the UK), including most financial services markets, exchanges and firms.</para>
    /// labels<para>Financial service authority</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#FinancialServiceAuthority">http://w3id.org/um/cbcm/eu-cm-ontology#FinancialServiceAuthority</seealso>
    let FinancialServiceAuthority =
        Prefixed_Name(cbcm, "FinancialServiceAuthority") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:GlobalUltimateOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A global ultimate owner (GUO) is the individual or entity at the top of the corporate ownership structure.</para>
    /// labels<para>Global ultimate owner</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#GlobalUltimateOwner">http://w3id.org/um/cbcm/eu-cm-ontology#GlobalUltimateOwner</seealso>
    let GlobalUltimateOwner = Prefixed_Name(cbcm, "GlobalUltimateOwner") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:owns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(owns ?ENTITY1 ?ENTITY2) means (owns ?ENTITY2 ?ENTITY1)</para>
    /// labels<para>owns</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#owns">http://w3id.org/um/cbcm/eu-cm-ontology#owns</seealso>
    let owns = Prefixed_Name(cbcm, "owns") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:ImpactOnEmploymentRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The right of employees or their representatives to be informed on the likely repercussions of the cross-border transaction on employment, which includes the dismissal as well as the hiring of employees or relocation of work. See for instance article 122 of Directive 2017/1132.</para>
    /// labels<para>Impact on employment information right</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#ImpactOnEmploymentRight">http://w3id.org/um/cbcm/eu-cm-ontology#ImpactOnEmploymentRight</seealso>
    let ImpactOnEmploymentRight =
        Prefixed_Name(cbcm, "ImpactOnEmploymentRight") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:IndependentExpertReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Article 86g and 160i: Member States must ensure that an independent expert examines the draft terms of the transaction and draws up a report intended for members which is made available to them not less than one month before the date of the general meeting. Depending on the law of Member States, the expert may be a natural person or a legal person. The report must assess the cash compensation proposed and valuation method.</para>
    /// labels<para>Report by an independent expert</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#IndependentExpertReport">http://w3id.org/um/cbcm/eu-cm-ontology#IndependentExpertReport</seealso>
    let IndependentExpertReport =
        Prefixed_Name(cbcm, "IndependentExpertReport") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:authoredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(authoredBy ?ENTITY1 ?ENTITY2) means that ?ENTITY1 is an instance of a publication that is created primarily by the entity referred to by ?ENTITY2.</para>
    /// labels<para>authored by</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#authoredBy">http://w3id.org/um/cbcm/eu-cm-ontology#authoredBy</seealso>
    let authoredBy = Prefixed_Name(cbcm, "authoredBy") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:InterimAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Interim accounts are accounts that are published during a company's financial year and that show the financial situation on a given accounting date.</para>
    /// labels<para>Interim account</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#InterimAccount">http://w3id.org/um/cbcm/eu-cm-ontology#InterimAccount</seealso>
    let InterimAccount = Prefixed_Name(cbcm, "InterimAccount") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:ManagementBoard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The group of persons comprising the governing body of the legal entity that is entrusted with the decision-making in the company. It is also called Executive Board in a one-tier board system.</para>
    /// labels<para>Management board</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagementBoard">http://w3id.org/um/cbcm/eu-cm-ontology#ManagementBoard</seealso>
    let ManagementBoard = Prefixed_Name(cbcm, "ManagementBoard") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:Manager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A person or group of persons that are responsible for overseeing the operations of a company.</para>
    /// labels<para>Manager</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#Manager">http://w3id.org/um/cbcm/eu-cm-ontology#Manager</seealso>
    let Manager = Prefixed_Name(cbcm, "Manager") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:ManagementReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A report drawn up by the company's management on the intended transaction, laying out the main features of the transactions and its consequences.</para>
    /// labels<para>Management report</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagementReport">http://w3id.org/um/cbcm/eu-cm-ontology#ManagementReport</seealso>
    let ManagementReport = Prefixed_Name(cbcm, "ManagementReport") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:ManagerDecisionRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The right of the board of management or individual managers to take decisions or to not take a decision in the context of a transaction. These are in the form of a board resolution.</para>
    /// labels<para>Manager decision right</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagerDecisionRight">http://w3id.org/um/cbcm/eu-cm-ontology#ManagerDecisionRight</seealso>
    let ManagerDecisionRight =
        Prefixed_Name(cbcm, "ManagerDecisionRight") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:ManagerRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The rights of members of the management in the context of a company transaction.</para>
    /// labels<para>Manager right</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagerRight">http://w3id.org/um/cbcm/eu-cm-ontology#ManagerRight</seealso>
    let ManagerRight = Prefixed_Name(cbcm, "ManagerRight") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:ManagerExitRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The right of a manager or the board of management to resign and therefore exit a company.</para>
    /// labels<para>Manager exit right</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagerExitRight">http://w3id.org/um/cbcm/eu-cm-ontology#ManagerExitRight</seealso>
    let ManagerExitRight = Prefixed_Name(cbcm, "ManagerExitRight") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:ManagerInformationRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The right of a manager to information and access to documents that he or she has in accordance with national or European company law.</para>
    /// labels<para>Manager information right</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagerInformationRight">http://w3id.org/um/cbcm/eu-cm-ontology#ManagerInformationRight</seealso>
    let ManagerInformationRight =
        Prefixed_Name(cbcm, "ManagerInformationRight") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:isTransactionInputOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(isTransactionInputOf ?ENTITY1 ?ENTITY2) means (hasTransactionInput ?ENTITY2 ?ENTITY1)</para>
    /// labels<para>is transaction input of</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#isTransactionInputOf">http://w3id.org/um/cbcm/eu-cm-ontology#isTransactionInputOf</seealso>
    let isTransactionInputOf =
        Prefixed_Name(cbcm, "isTransactionInputOf") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:NationalRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A national registry is a business registry in a Member State, which includes information on the population of companies in the jurisdiction and holds inter alia data on registration numbers, place of registration, notices and transaction documents in the national registry repository.</para>
    /// labels<para>National registry</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#NationalRegistry">http://w3id.org/um/cbcm/eu-cm-ontology#NationalRegistry</seealso>
    let NationalRegistry = Prefixed_Name(cbcm, "NationalRegistry") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:NationalRegistryRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The digital repository in which documents published in the official journal or by by the national registry (on behalf of a company) are kept as well as related documents. In some EU Member States, this repository is overlapping or identical with the Official Journal Repository.</para>
    /// labels<para>National registry repository</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#NationalRegistryRepository">http://w3id.org/um/cbcm/eu-cm-ontology#NationalRegistryRepository</seealso>
    let NationalRegistryRepository =
        Prefixed_Name(cbcm, "NationalRegistryRepository") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:maintainedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(maintainedBy ?ENTITY1 ?ENTITY2) means that some digital resource ?ENTITY1 (e.g. database, website, document repository etc.) has stewardship by some agent or organisation ?ENTITY2 who is responsible for the upkeep of ?ENTITY1.</para>
    /// labels<para>maintained by</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#maintainedBy">http://w3id.org/um/cbcm/eu-cm-ontology#maintainedBy</seealso>
    let maintainedBy = Prefixed_Name(cbcm, "maintainedBy") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:Notary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A person authorized to perform certain legal formalities, especially to draw up or certify contracts, deeds, and other documents for use in other jurisdictions.</para>
    /// labels<para>Notary</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#Notary">http://w3id.org/um/cbcm/eu-cm-ontology#Notary</seealso>
    let Notary = Prefixed_Name(cbcm, "Notary") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:OfficialJournalPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Publication of a legally valid record or act in an official national gazette to inform stakeholders.</para>
    /// labels<para>Official journal publication</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#OfficialJournalPublication">http://w3id.org/um/cbcm/eu-cm-ontology#OfficialJournalPublication</seealso>
    let OfficialJournalPublication =
        Prefixed_Name(cbcm, "OfficialJournalPublication") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:OfficialJournalRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The digital repository in which documents published in the official journal are kept as well as related documents. In some EU Member States, this repository is overlapping or identical with the National Registry Repository.</para>
    /// labels<para>Official journal repository</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#OfficialJournalRepository">http://w3id.org/um/cbcm/eu-cm-ontology#OfficialJournalRepository</seealso>
    let OfficialJournalRepository =
        Prefixed_Name(cbcm, "OfficialJournalRepository") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:rawTransactionID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>unique identifier before database entry.
    ///
    /// This id is the old ID-structure used before entry into the CbCMdb</para>
    /// labels<para>Raw transaction ID</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#rawTransactionID">http://w3id.org/um/cbcm/eu-cm-ontology#rawTransactionID</seealso>
    let rawTransactionID = Prefixed_Name(cbcm, "rawTransactionID") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:registeredOffice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Deprecated property</para>
    /// labels<para>Registered Office</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#registeredOffice">http://w3id.org/um/cbcm/eu-cm-ontology#registeredOffice</seealso>
    let registeredOffice = Prefixed_Name(cbcm, "registeredOffice") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:requirement-level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Specifies a phrase to indicate the degree to which the providing of a value for the entity (e.g. a data or object property) in question is compulsory, recommended or optional.</para>
    /// labels<para>Requirement level</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#requirement-level">http://w3id.org/um/cbcm/eu-cm-ontology#requirement-level</seealso>
    let requirement_level = Prefixed_Name(cbcm, "requirement-level") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:romania</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cbcm:EUCountry</para>
    ///
    /// labels<para>Romania</para><para>România</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#romania">http://w3id.org/um/cbcm/eu-cm-ontology#romania</seealso>
    let romania = Prefixed_Name(cbcm, "romania") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:sbnVoluntaryApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Is a Special Negotiating Body (SNB) set up voluntary?
    ///
    /// Whether or not a SNB is created/will be created voluntarily.
    ///
    /// - Yes: an SNB is created voluntarily;
    /// - No: no voluntary SNB set up;
    /// - Not applicable: the conditions are not met (e.g. no employees, BLER threshold not met) for this criterion to be applicable;
    /// - Unclear: the wording of the document is unclear with regard to the impact/effect/measures taken;
    /// - Not mentioned: given the parameters, this aspect should be addressed in the transaction document, but is not mentioned</para>
    /// labels<para>SNB voluntary application</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#sbnVoluntaryApplication">http://w3id.org/um/cbcm/eu-cm-ontology#sbnVoluntaryApplication</seealso>
    let sbnVoluntaryApplication =
        Prefixed_Name(cbcm, "sbnVoluntaryApplication") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:se_conversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cbcm:SEType</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#se_conversion">http://w3id.org/um/cbcm/eu-cm-ontology#se_conversion</seealso>
    let se_conversion = Prefixed_Name(cbcm, "se_conversion") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:se_holding</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:SEType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#se_holding">http://w3id.org/um/cbcm/eu-cm-ontology#se_holding</seealso>
    let se_holding = Prefixed_Name(cbcm, "se_holding") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:se_merger</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:SEType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#se_merger">http://w3id.org/um/cbcm/eu-cm-ontology#se_merger</seealso>
    let se_merger = Prefixed_Name(cbcm, "se_merger") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:se_subsidiary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cbcm:SEType</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#se_subsidiary">http://w3id.org/um/cbcm/eu-cm-ontology#se_subsidiary</seealso>
    let se_subsidiary = Prefixed_Name(cbcm, "se_subsidiary") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:se_unsure</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:SEType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#se_unsure">http://w3id.org/um/cbcm/eu-cm-ontology#se_unsure</seealso>
    let se_unsure = Prefixed_Name(cbcm, "se_unsure") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:slovakia</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:EUCountry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Slovenská republika</para><para>Slovak Republic</para><para>Slovensko</para><para>Slovakia</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#slovakia">http://w3id.org/um/cbcm/eu-cm-ontology#slovakia</seealso>
    let slovakia = Prefixed_Name(cbcm, "slovakia") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:toBeNegotiatedBLER</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Is an employee board level representation/participation (BLER) mechanism going to be re-negotiated in the process of the cross-border transaction?
    ///
    /// - Yes: BLER be (re-)negotiated with the SNB;
    /// - No: no BLER-(re-)negotiation;
    /// - Not applicable: the conditions are not met (e.g. no employees, BLER threshold not met) for this criterion to be applicable;
    /// - Unclear: the wording of the document is unclear with regard to the impact/effect/measures taken;
    /// - Not mentioned: given the parameters, this aspect should be addressed in the transaction document, but is not mentioned</para>
    /// labels<para>BLER to be negotiated</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#toBeNegotiatedBLER">http://w3id.org/um/cbcm/eu-cm-ontology#toBeNegotiatedBLER</seealso>
    let toBeNegotiatedBLER = Prefixed_Name(cbcm, "toBeNegotiatedBLER") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:transactionComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Notes from researcher about the transaction</para>
    /// labels<para>Transaction comment</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionComment">http://w3id.org/um/cbcm/eu-cm-ontology#transactionComment</seealso>
    let transactionComment = Prefixed_Name(cbcm, "transactionComment") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:transactionCompletionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date on which the transaction was effectuated (the date that the competent authority e.g., business registry of that country, says that the criteria have been met by merging and acquiring companies and the merging/transferring company is dissolved).
    ///
    /// This is the final step of a transaction process</para>
    /// labels<para>Transaction completion date</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionCompletionDate">http://w3id.org/um/cbcm/eu-cm-ontology#transactionCompletionDate</seealso>
    let transactionCompletionDate =
        Prefixed_Name(cbcm, "transactionCompletionDate") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:transactionID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>unique identifier for a transaction</para>
    /// labels<para>Transaction ID</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionID">http://w3id.org/um/cbcm/eu-cm-ontology#transactionID</seealso>
    let transactionID = Prefixed_Name(cbcm, "transactionID") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:transactionPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Is the transaction plan available for analysis?
    ///
    /// Merger plan, Seat transfer plan or Division plan. Transaction notice is where the transaction is announced. The other documents are where the nature and details of the transaction are specified.</para>
    /// labels<para>Transaction plan available</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionPlan">http://w3id.org/um/cbcm/eu-cm-ontology#transactionPlan</seealso>
    let transactionPlan = Prefixed_Name(cbcm, "transactionPlan") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:transactionStartDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of the transaction notice (document announcing the transaction) constituting the start of the transaction process. Date that the document was published (which is the important date because this is when it becomes legally binding)</para>
    /// labels<para>Transaction notice date</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionStartDate">http://w3id.org/um/cbcm/eu-cm-ontology#transactionStartDate</seealso>
    let transactionStartDate =
        Prefixed_Name(cbcm, "transactionStartDate") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:typeOfSE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Variable indicating the SE-establishment mode: by merger, conversion, holding-SE, subsidiary-SE or unsure</para>
    /// labels<para>Type of SE</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#typeOfSE">http://w3id.org/um/cbcm/eu-cm-ontology#typeOfSE</seealso>
    let typeOfSE = Prefixed_Name(cbcm, "typeOfSE") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:unitedkingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:EUCountry</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#unitedkingdom">http://w3id.org/um/cbcm/eu-cm-ontology#unitedkingdom</seealso>
    let unitedkingdom = Prefixed_Name(cbcm, "unitedkingdom") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:usedDataProvenanceDocumentSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>In which document did the researcher find information about the transaction?</para>
    /// labels<para>Has document source</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#usedDataProvenanceDocumentSource">http://w3id.org/um/cbcm/eu-cm-ontology#usedDataProvenanceDocumentSource</seealso>
    let usedDataProvenanceDocumentSource =
        Prefixed_Name(cbcm, "usedDataProvenanceDocumentSource") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:usedDataProvenanceRegistryCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>In which countries' registry did the researcher find information about the transaction?</para>
    /// labels<para>Data found in registry from country</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#usedDataProvenanceRegistryCountry">http://w3id.org/um/cbcm/eu-cm-ontology#usedDataProvenanceRegistryCountry</seealso>
    let usedDataProvenanceRegistryCountry =
        Prefixed_Name(cbcm, "usedDataProvenanceRegistryCountry") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:website</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Homepage of a company/organization website</para>
    /// labels<para>Website</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#website">http://w3id.org/um/cbcm/eu-cm-ontology#website</seealso>
    let website = Prefixed_Name(cbcm, "website") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:wwEmploymentFigureAtTransaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>number of employees of company group worldwide at the moment of the transaction</para>
    /// labels<para>Total WW employees at transaction</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#wwEmploymentFigureAtTransaction">http://w3id.org/um/cbcm/eu-cm-ontology#wwEmploymentFigureAtTransaction</seealso>
    let wwEmploymentFigureAtTransaction =
        Prefixed_Name(cbcm, "wwEmploymentFigureAtTransaction") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:yearDivergingEmploymentFigure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The year for which a diverging employee number is recorded</para>
    /// labels<para>Diverging employment figure year</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#yearDivergingEmploymentFigure">http://w3id.org/um/cbcm/eu-cm-ontology#yearDivergingEmploymentFigure</seealso>
    let yearDivergingEmploymentFigure =
        Prefixed_Name(cbcm, "yearDivergingEmploymentFigure") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:yearWWEmploymentFigure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Year in which the last worldwide employment figure was recorded</para>
    /// labels<para>Last WW employment figure year</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#yearWWEmploymentFigure">http://w3id.org/um/cbcm/eu-cm-ontology#yearWWEmploymentFigure</seealso>
    let yearWWEmploymentFigure =
        Prefixed_Name(cbcm, "yearWWEmploymentFigure") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:slovenia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cbcm:EUCountry</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#slovenia">http://w3id.org/um/cbcm/eu-cm-ontology#slovenia</seealso>
    let slovenia = Prefixed_Name(cbcm, "slovenia") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:standardRulesApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Are the standard rules applied directly without and instead of the start of negotiations with a Special Negotiating Body (SNB)?
    ///
    /// Instead of an SNB being set up, the standard rules are applied instead.
    ///
    /// - Yes: the standard rules are applied;
    /// - No: standard rules ar enot applied;
    /// - Not applicable: the conditions are not met (e.g. no employees, BLER threshold not met) for this criterion to be applicable;
    /// - Unclear: the wording of the document is unclear with regard to the impact/effect/measures taken;
    /// - Not mentioned: given the parameters, this aspect should be addressed in the transaction document, but is not mentioned</para>
    /// labels<para>Standard rules application</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#standardRulesApplication">http://w3id.org/um/cbcm/eu-cm-ontology#standardRulesApplication</seealso>
    let standardRulesApplication =
        Prefixed_Name(cbcm, "standardRulesApplication") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:tnic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Is the company having a transnational information and consultation agreement in place? Does the company have an internal body which discusses employee rights and welfare?
    ///
    /// Different from works council. TNIC is global.</para>
    /// labels<para>Has TNIC</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#tnic">http://w3id.org/um/cbcm/eu-cm-ontology#tnic</seealso>
    let tnic = Prefixed_Name(cbcm, "tnic") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:hasTransactionInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(hasTransactionInput ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 has a prerequisite entity ?ENTITY2 that needs to be considered, assessed, or modified during the transaction referred to by ?ENTITY1.</para>
    /// labels<para>has transaction input</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#hasTransactionInput">http://w3id.org/um/cbcm/eu-cm-ontology#hasTransactionInput</seealso>
    let hasTransactionInput = Prefixed_Name(cbcm, "hasTransactionInput") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:hasTransactionResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(hasTransactionResult ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 has a byproduct ?ENTITY2 (e.g. a company, transaction certificate etc.) after completion of the process.</para>
    /// labels<para>has transaction result</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#hasTransactionResult">http://w3id.org/um/cbcm/eu-cm-ontology#hasTransactionResult</seealso>
    let hasTransactionResult =
        Prefixed_Name(cbcm, "hasTransactionResult") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:hasRecipientCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(hasRecipientCompany ?ENTITY1 ?ENTITY2) means that some company division transaction ?ENTITY1 produces two or more distinct companies, one of which is ?ENTITY2 (a so-called "recipient company").</para>
    /// labels<para>has recipient company</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#hasRecipientCompany">http://w3id.org/um/cbcm/eu-cm-ontology#hasRecipientCompany</seealso>
    let hasRecipientCompany = Prefixed_Name(cbcm, "hasRecipientCompany") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:DivisionPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The management or administrative organ of the company shall draw up the draft terms of a division. The draft terms of a division shall include at least the particulars listed in article 160d.</para>
    /// labels<para>Company division plan</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#DivisionPlan">http://w3id.org/um/cbcm/eu-cm-ontology#DivisionPlan</seealso>
    let DivisionPlan = Prefixed_Name(cbcm, "DivisionPlan") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:TaxAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Tax Authority means any governmental authority having jurisdiction over the assessment, determination, collection or imposition of any tax.</para>
    /// labels<para>Tax authority</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#TaxAuthority">http://w3id.org/um/cbcm/eu-cm-ontology#TaxAuthority</seealso>
    let TaxAuthority = Prefixed_Name(cbcm, "TaxAuthority") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:MergerPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Article 91: The administrative or management bodies of the merging companies shall draw up draft terms of merger in writing by specifying at least the elements mentioned in article 91.</para>
    /// labels<para>Company merger plan</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#MergerPlan">http://w3id.org/um/cbcm/eu-cm-ontology#MergerPlan</seealso>
    let MergerPlan = Prefixed_Name(cbcm, "MergerPlan") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:CompanySeatTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The act of changing the location where the company’s business was managed (registered office or headquarters) or the place where that company’s primary business was actually conducted (central administration).</para>
    /// labels<para>Company seat transfer</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanySeatTransfer">http://w3id.org/um/cbcm/eu-cm-ontology#CompanySeatTransfer</seealso>
    let CompanySeatTransfer = Prefixed_Name(cbcm, "CompanySeatTransfer") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:SeatTransferPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The management or administrative organ of the company draws up the draft terms of a cross-border seat transfer. The draft terms of a cross-border seat transfer must include at least the particulars specified under national law.</para>
    /// labels<para>Company seat transfer plan</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#SeatTransferPlan">http://w3id.org/um/cbcm/eu-cm-ontology#SeatTransferPlan</seealso>
    let SeatTransferPlan = Prefixed_Name(cbcm, "SeatTransferPlan") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:TransferOfCentralAdministration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Act of modifying the location where the company’s business was managed or the place where that company’s business was actually conducted.</para>
    /// labels<para>Transfer of company central administration</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#TransferOfCentralAdministration">http://w3id.org/um/cbcm/eu-cm-ontology#TransferOfCentralAdministration</seealso>
    let TransferOfCentralAdministration =
        Prefixed_Name(cbcm, "TransferOfCentralAdministration") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:hasSubProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(hasSubProcedure ?ENTITY1 ?ENTITY2) means that some process ?ENTITY1 contains another (shorter) process ?ENTITY2 that should be completed before ?ENTITY1 can complete.</para>
    /// labels<para>has sub procedure</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#hasSubProcedure">http://w3id.org/um/cbcm/eu-cm-ontology#hasSubProcedure</seealso>
    let hasSubProcedure = Prefixed_Name(cbcm, "hasSubProcedure") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:TransferOfRegisteredOffice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The act of changing the registered office, which is the official address of an incorporated company, association or any other legal entity.</para>
    /// labels<para>Transfer of company registered office</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#TransferOfRegisteredOffice">http://w3id.org/um/cbcm/eu-cm-ontology#TransferOfRegisteredOffice</seealso>
    let TransferOfRegisteredOffice =
        Prefixed_Name(cbcm, "TransferOfRegisteredOffice") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:acLastEmploymentFigure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The last available annual employment figure for the acquiring company</para>
    /// labels<para>Last employment figure for the acquiring company</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#acLastEmploymentFigure">http://w3id.org/um/cbcm/eu-cm-ontology#acLastEmploymentFigure</seealso>
    let acLastEmploymentFigure =
        Prefixed_Name(cbcm, "acLastEmploymentFigure") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:iso2code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#iso2code">http://w3id.org/um/cbcm/eu-cm-ontology#iso2code</seealso>
    let iso2code = Prefixed_Name(cbcm, "iso2code") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:cbcmDocumentRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(cbcmDocumentRelation ?ENTITY1 ?ENTITY2) means that the relation between ?ENTITY1 and ?ENTITY2 captures information pertaining to a company mobility document or similar information source relevant to corporate mobility.</para>
    /// labels<para>Cross-border company mobility document relation</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmDocumentRelation">http://w3id.org/um/cbcm/eu-cm-ontology#cbcmDocumentRelation</seealso>
    let cbcmDocumentRelation =
        Prefixed_Name(cbcm, "cbcmDocumentRelation") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:bler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Is an employee board level representation/participation (BLER) mechanism applicable prior to the cross-border transaction?
    ///
    /// 0 = no BLER prior to cross-border transaction
    /// 1 = BLER existing prior to cross-border transaction</para>
    /// labels<para>is BLER existing prior</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#bler">http://w3id.org/um/cbcm/eu-cm-ontology#bler</seealso>
    let bler = Prefixed_Name(cbcm, "bler") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:bulgaria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cbcm:EUCountry</para>
    ///
    /// labels<para>Bǎlgariya</para><para>Bulgaria</para><para>България</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#bulgaria">http://w3id.org/um/cbcm/eu-cm-ontology#bulgaria</seealso>
    let bulgaria = Prefixed_Name(cbcm, "bulgaria") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:cbcmEntityRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(cbcmEntityRelation ?ENTITY1 ?ENTITY2) means that ?ENTITY1 is related to ?ENTITY2.</para>
    /// labels<para>Cross-border company mobility entity relation</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmEntityRelation">http://w3id.org/um/cbcm/eu-cm-ontology#cbcmEntityRelation</seealso>
    let cbcmEntityRelation = Prefixed_Name(cbcm, "cbcmEntityRelation") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:cbcmTransactionRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(cbcmTransactionRelation ?ENTITY1 ?ENTITY2) means that the relation between ?ENTITY1 and ?ENTITY2 captures information pertaining to a company mobility transaction.</para>
    /// labels<para>Cross-border company mobility transaction relation</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmTransactionRelation">http://w3id.org/um/cbcm/eu-cm-ontology#cbcmTransactionRelation</seealso>
    let cbcmTransactionRelation =
        Prefixed_Name(cbcm, "cbcmTransactionRelation") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:companiesHaveEmployees</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Are the companies involved in the transaction having employees? Only one company needs to have employees for this property to be true</para>
    /// labels<para>Companies have employees</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#companiesHaveEmployees">http://w3id.org/um/cbcm/eu-cm-ontology#companiesHaveEmployees</seealso>
    let companiesHaveEmployees =
        Prefixed_Name(cbcm, "companiesHaveEmployees") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:countryHasCompanyForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(countryHasCompanyForm ?ENTITY1 ?ENTITY2) means that ?ENTITY1 refers to a country the corporate law in that country permits and / or has occurrences of companies in that country which have the corporate legal structure (company legal form) referred to by ?ENTITY2.</para>
    /// labels<para>country has company form</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#countryHasCompanyForm">http://w3id.org/um/cbcm/eu-cm-ontology#countryHasCompanyForm</seealso>
    let countryHasCompanyForm =
        Prefixed_Name(cbcm, "countryHasCompanyForm") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:croatia</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:EUCountry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Hrvatska</para><para>Croatia</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#croatia">http://w3id.org/um/cbcm/eu-cm-ontology#croatia</seealso>
    let croatia = Prefixed_Name(cbcm, "croatia") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:cyprus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cbcm:EUCountry</para>
    ///
    /// labels<para>Cyprus</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#cyprus">http://w3id.org/um/cbcm/eu-cm-ontology#cyprus</seealso>
    let cyprus = Prefixed_Name(cbcm, "cyprus") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:czechia</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:EUCountry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Česká republika</para><para>Czech Republic</para><para>Czechia</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#czechia">http://w3id.org/um/cbcm/eu-cm-ontology#czechia</seealso>
    let czechia = Prefixed_Name(cbcm, "czechia") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:denmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cbcm:EUCountry</para>
    ///
    /// labels<para>Kingdom of Denmark</para><para>Denmark</para><para>Danmark</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#denmark">http://w3id.org/um/cbcm/eu-cm-ontology#denmark</seealso>
    let denmark = Prefixed_Name(cbcm, "denmark") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:divergingEmploymentFigure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>If a different employee number for the acquiring company is found, it is recorded in this field</para>
    /// labels<para>Diverging employment figure</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#divergingEmploymentFigure">http://w3id.org/um/cbcm/eu-cm-ontology#divergingEmploymentFigure</seealso>
    let divergingEmploymentFigure =
        Prefixed_Name(cbcm, "divergingEmploymentFigure") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:employs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(employs ?ENTITY1 ?ENTITY2) means (employedBy ?ENTITY2 ?ENTITY1)</para>
    /// labels<para>employs</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#employs">http://w3id.org/um/cbcm/eu-cm-ontology#employs</seealso>
    let employs = Prefixed_Name(cbcm, "employs") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:endedAtTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date and time a process ended</para>
    /// labels<para>Ended at</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#endedAtTime">http://w3id.org/um/cbcm/eu-cm-ontology#endedAtTime</seealso>
    let endedAtTime = Prefixed_Name(cbcm, "endedAtTime") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:estonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cbcm:EUCountry</para>
    ///
    /// labels<para>Estonia</para><para>Eesti</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#estonia">http://w3id.org/um/cbcm/eu-cm-ontology#estonia</seealso>
    let estonia = Prefixed_Name(cbcm, "estonia") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:finland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cbcm:EUCountry</para>
    ///
    /// labels<para>Finland</para><para>Suomi</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#finland">http://w3id.org/um/cbcm/eu-cm-ontology#finland</seealso>
    let finland = Prefixed_Name(cbcm, "finland") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:generated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Generation is the completion of production of a new entity by a process. This entity did not exist before generation and becomes available for usage after this generation.
    ///
    /// Based (inverse of) on: https://www.w3.org/TR/prov-o/#wasGeneratedBy</para>
    /// labels<para>Generated</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#generated">http://w3id.org/um/cbcm/eu-cm-ontology#generated</seealso>
    let generated = Prefixed_Name(cbcm, "generated") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:wasGeneratedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Generation is the completion of production of a new entity by a process. This entity did not exist before generation and becomes available for usage after this generation.
    ///
    /// Based on: https://www.w3.org/TR/prov-o/#wasGeneratedBy</para>
    /// labels<para>Generated by</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#wasGeneratedBy">http://w3id.org/um/cbcm/eu-cm-ontology#wasGeneratedBy</seealso>
    let wasGeneratedBy = Prefixed_Name(cbcm, "wasGeneratedBy") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:germany</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:EUCountry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Deutschland</para><para>Germany</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#germany">http://w3id.org/um/cbcm/eu-cm-ontology#germany</seealso>
    let germany = Prefixed_Name(cbcm, "germany") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:hasDataProvenanceDocumentSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>In which document did the researcher find information about the transaction?</para>
    /// labels<para>has document source</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#hasDataProvenanceDocumentSource">http://w3id.org/um/cbcm/eu-cm-ontology#hasDataProvenanceDocumentSource</seealso>
    let hasDataProvenanceDocumentSource =
        Prefixed_Name(cbcm, "hasDataProvenanceDocumentSource") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:hasDataProvenanceRegistryCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>In which countries' registry did the researcher find information about the transaction?</para>
    /// labels<para>data found in registry from country</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#hasDataProvenanceRegistryCountry">http://w3id.org/um/cbcm/eu-cm-ontology#hasDataProvenanceRegistryCountry</seealso>
    let hasDataProvenanceRegistryCountry =
        Prefixed_Name(cbcm, "hasDataProvenanceRegistryCountry") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:hasPostCompanyForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(?ENTITY1 hasPostCompanyForm ?ENTITY2) indicates the new company form of a company undergoing a cross border conversion or a national conversion.</para>
    /// labels<para>After-transaction company form</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#hasPostCompanyForm">http://w3id.org/um/cbcm/eu-cm-ontology#hasPostCompanyForm</seealso>
    let hasPostCompanyForm = Prefixed_Name(cbcm, "hasPostCompanyForm") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:hasPrimaryRegistrationLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Primary country of registration (location) of a company as a full country name</para>
    /// labels<para>Company primary registration location</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#hasPrimaryRegistrationLocation">http://w3id.org/um/cbcm/eu-cm-ontology#hasPrimaryRegistrationLocation</seealso>
    let hasPrimaryRegistrationLocation =
        Prefixed_Name(cbcm, "hasPrimaryRegistrationLocation") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:hasPriorCompanyForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(?ENTITY1 hasPriorCompanyForm ?ENTITY2) indicates the original company form of a company undergoing a cross border conversion or a national conversion.</para>
    /// labels<para>Pre-transaction company form</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#hasPriorCompanyForm">http://w3id.org/um/cbcm/eu-cm-ontology#hasPriorCompanyForm</seealso>
    let hasPriorCompanyForm = Prefixed_Name(cbcm, "hasPriorCompanyForm") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:hasSecondaryRegistrationLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Country of secondary registration (location) of a company</para>
    /// labels<para>Company secondary registration location</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#hasSecondaryRegistrationLocation">http://w3id.org/um/cbcm/eu-cm-ontology#hasSecondaryRegistrationLocation</seealso>
    let hasSecondaryRegistrationLocation =
        Prefixed_Name(cbcm, "hasSecondaryRegistrationLocation") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:WorksCouncil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The exercise of employee participation through the representation of employees vis-a-vis the management of a company. The works council is a shop-floor level representation mechanism with information, consultation and veto-rights - depending on the extent of rights given in a Member State - and also at EU level through European Works Councils.</para>
    /// labels<para>Employee works council</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#WorksCouncil">http://w3id.org/um/cbcm/eu-cm-ontology#WorksCouncil</seealso>
    let WorksCouncil = Prefixed_Name(cbcm, "WorksCouncil") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:acEmploymentFigureAtTransaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>number of employees of the acquiring company - at the moment of the transaction</para>
    /// labels<para>AC Employees count at transaction</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#acEmploymentFigureAtTransaction">http://w3id.org/um/cbcm/eu-cm-ontology#acEmploymentFigureAtTransaction</seealso>
    let acEmploymentFigureAtTransaction =
        Prefixed_Name(cbcm, "acEmploymentFigureAtTransaction") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:acTotalEUEmploymentFigure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>total number of employees of the acquiring company in the EU at the moment of the transaction</para>
    /// labels<para>Total EU employees</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#acTotalEUEmploymentFigure">http://w3id.org/um/cbcm/eu-cm-ontology#acTotalEUEmploymentFigure</seealso>
    let acTotalEUEmploymentFigure =
        Prefixed_Name(cbcm, "acTotalEUEmploymentFigure") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:example</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Provides a human-readable written example of the entity in question.</para>
    /// labels<para>Example</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#example">http://w3id.org/um/cbcm/eu-cm-ontology#example</seealso>
    let example = Prefixed_Name(cbcm, "example") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:cbcmObjectRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(cbcmObjectRelation ?ENTITY1 ?ENTITY2) means that the relation between ?ENTITY1 and ?ENTITY2 captures information pertaining to an object.</para>
    /// labels<para>Cross-border company mobility object relation</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmObjectRelation">http://w3id.org/um/cbcm/eu-cm-ontology#cbcmObjectRelation</seealso>
    let cbcmObjectRelation = Prefixed_Name(cbcm, "cbcmObjectRelation") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:austria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cbcm:EUCountry</para>
    ///
    /// labels<para>Österreich</para><para>Austria</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#austria">http://w3id.org/um/cbcm/eu-cm-ontology#austria</seealso>
    let austria = Prefixed_Name(cbcm, "austria") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:authors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(authors ?ENTITY1 ?ENTITY2) means that (authoredBy ?ENTITY2 ?ENTITY1)</para>
    /// labels<para>authors</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#authors">http://w3id.org/um/cbcm/eu-cm-ontology#authors</seealso>
    let authors = Prefixed_Name(cbcm, "authors") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:belgium</para>
    /// </summary>
    /// <remarks>
    ///   <para>cbcm:EUCountry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Belgique</para><para>Belgium</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#belgium">http://w3id.org/um/cbcm/eu-cm-ontology#belgium</seealso>
    let belgium = Prefixed_Name(cbcm, "belgium") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:blerComposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>What is the employee board level representation (BLER) ratio going to be after the completion of the transaction?
    ///
    /// The ratio is ranging from 0.00 (no BLER) to 0.33 (1/3 BLER) to 0.5 (50-50 Mitbestimmung) to (theoretically) 1.00, which would be 100% employee representatives on the board and no shareholder representatives.</para>
    /// labels<para>BLER composition</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#blerComposition">http://w3id.org/um/cbcm/eu-cm-ontology#blerComposition</seealso>
    let blerComposition = Prefixed_Name(cbcm, "blerComposition") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:AcquiringCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Acquiring Company means the resulting or surviving company in a transaction that takes over another, merging company.</para>
    /// labels<para>Acquiring company</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#AcquiringCompany">http://w3id.org/um/cbcm/eu-cm-ontology#AcquiringCompany</seealso>
    let AcquiringCompany = Prefixed_Name(cbcm, "AcquiringCompany") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:CompanyMerger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>‘merger’ in Directive (EU) 2017/1132 means an operation whereby:
    ///
    /// (a) one or more companies, on being dissolved without going into liquidation, transfer all their assets and liabilities to another existing company, the acquiring company, in exchange for the issue to their members of securities or shares representing the capital of that other company and, if applicable, a cash payment not exceeding 10 % of the nominal value, or, in the absence of a nominal value, of the accounting par value of those securities or shares; or
    ///
    /// (b) two or more companies, on being dissolved without going into liquidation, transfer all their assets and liabilities to a company that they form, the new company, in exchange for the issue to their members of securities or shares representing the capital of that new company and, if applicable, a cash payment not exceeding 10 % of the nominal value, or in the absence of a nominal value, of the accounting par value of those securities or shares; or
    ///
    /// (c) a company, on being dissolved without going into liquidation, transfers all its assets and liabilities to the company holding all the securities or shares representing its capital;"
    ///
    /// (d) one or more companies, on being dissolved without going into liquidation, transfer all their assets and liabilities to another existing company, the acquiring company, without the issue of any new shares by the acquiring company, provided that one person holds directly or indirectly all the shares in the merging companies or the members of the merging companies hold their shares in the same proportion in all merging companies.";</para>
    /// labels<para>Company merger</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyMerger">http://w3id.org/um/cbcm/eu-cm-ontology#CompanyMerger</seealso>
    let CompanyMerger = Prefixed_Name(cbcm, "CompanyMerger") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:Company</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A company is a legal entity formed by a group of individuals to engage in and operate a business—commercial or industrial—enterprise. A company may be organized in various ways for tax and financial liability purposes depending on the corporate law of its jurisdiction.</para>
    /// labels<para>Company</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#Company">http://w3id.org/um/cbcm/eu-cm-ontology#Company</seealso>
    let Company = Prefixed_Name(cbcm, "Company") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An entity or group of entities (either biological or non-biological) that is able to perform actions autonomously in the world.</para>
    /// labels<para>Agent</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#Agent">http://w3id.org/um/cbcm/eu-cm-ontology#Agent</seealso>
    let Agent = Prefixed_Name(cbcm, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:AnnualReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Annual reports measure a company's financial health. They focus on past and present financial performance, and make predictions about future prospects. The revenue and financial performance of a company.</para>
    /// labels<para>Annual report</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#AnnualReport">http://w3id.org/um/cbcm/eu-cm-ontology#AnnualReport</seealso>
    let AnnualReport = Prefixed_Name(cbcm, "AnnualReport") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:Attribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An attribute is a characteristic of some entity.</para>
    /// labels<para>Attribute</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#Attribute">http://w3id.org/um/cbcm/eu-cm-ontology#Attribute</seealso>
    let Attribute = Prefixed_Name(cbcm, "Attribute") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:Behaviour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Behaviour is the set of actions and mannerisms made by systems (biological or otherwise) in response to stimuli or inputs, whether internal or external, conscious or subconscious, overt or covert, and voluntary or involuntary.</para>
    /// labels<para>Behaviour</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#Behaviour">http://w3id.org/um/cbcm/eu-cm-ontology#Behaviour</seealso>
    let Behaviour = Prefixed_Name(cbcm, "Behaviour") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:Procedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A procedure is a process that attempts to achieve one or more objectives by following an established set of actions.</para>
    /// labels<para>Procedure</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#Procedure">http://w3id.org/um/cbcm/eu-cm-ontology#Procedure</seealso>
    let Procedure = Prefixed_Name(cbcm, "Procedure") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:BoardLevelEmployeeRepresentationRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Board-level representation of employees (BLER) refers to the phenomenon where employees or their representatives elect or appoint representatives to the strategic decision-making body of a company (i.e. the supervisory board or non-executive board in a one-tier system). The BLER right requires that if such a system of BLER exists prior to a cross-border company transaction, such a right must be upheld in the acquiring/recipient company under the "before-and-after-principle".</para>
    /// labels<para>Board-level employee representation right</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#BoardLevelEmployeeRepresentationRight">http://w3id.org/um/cbcm/eu-cm-ontology#BoardLevelEmployeeRepresentationRight</seealso>
    let BoardLevelEmployeeRepresentationRight =
        Prefixed_Name(cbcm, "BoardLevelEmployeeRepresentationRight") |> PrefixedName

    /// <summary>
    ///   <para>cbcm:SocialRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Social rights, as opposed to rights arising from natural law, are rights for legal entities that entitle them to certain levels of societal living conditions (e.g. the right to housing, to food, to health care etc.)</para>
    /// labels<para>Social right</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#SocialRight">http://w3id.org/um/cbcm/eu-cm-ontology#SocialRight</seealso>
    let SocialRight = Prefixed_Name(cbcm, "SocialRight") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:BoardResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Board Resolution, or Company Resolution, is a way of documenting a decision made by a Company's Board of Directors on behalf of the company. After the resolution is made during a meeting, a Board Resolution document is typically used to get the specifics of the resolution in writing.</para>
    /// labels<para>Board resolution</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#BoardResolution">http://w3id.org/um/cbcm/eu-cm-ontology#BoardResolution</seealso>
    let BoardResolution = Prefixed_Name(cbcm, "BoardResolution") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A person is an object that has certain capacities or attributes constituting personhood. A human being that has existed or continues to exist in the world (either deceased or living). Fictional human beings cannot be  instances of this class.</para>
    /// labels<para>Person</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#Person">http://w3id.org/um/cbcm/eu-cm-ontology#Person</seealso>
    let Person = Prefixed_Name(cbcm, "Person") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:GeoPoliticalRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A spatial region on earth whose boundaries are determined by a combination of geographical, ecological, climatic, socio-economic and political criteria.</para>
    /// labels<para>Geo-political region</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#GeoPoliticalRegion">http://w3id.org/um/cbcm/eu-cm-ontology#GeoPoliticalRegion</seealso>
    let GeoPoliticalRegion = Prefixed_Name(cbcm, "GeoPoliticalRegion") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:Employee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The workforce of a company. An employee is a party to an employment relationship characterised as a contract of employment (or contract of service) between the employer and employee. However, this is only one of several different legal formulations of the concept of ‘worker’ in the EU which differ between Member States.</para>
    /// labels<para>Company employee</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#Employee">http://w3id.org/um/cbcm/eu-cm-ontology#Employee</seealso>
    let Employee = Prefixed_Name(cbcm, "Employee") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(hasMember ?ENTITY1 ?ENTITY2) means that some agent ?ENTITY1 (usually an organisation) has a person ?ENTITY2 that participates in its activities. This need not represent an employment role nor imply financial incentives between the organisation and person.</para>
    /// labels<para>has member</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#hasMember">http://w3id.org/um/cbcm/eu-cm-ontology#hasMember</seealso>
    let hasMember = Prefixed_Name(cbcm, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:Organisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a collection of people organized together into a community or other social, commercial or political structure. The group has some common purpose or reason for existence which goes beyond the set of people belonging to it and can act as an Agent. Organizations are often decomposable into hierarchical structures.</para>
    /// labels<para>Organisation</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#Organisation">http://w3id.org/um/cbcm/eu-cm-ontology#Organisation</seealso>
    let Organisation = Prefixed_Name(cbcm, "Organisation") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:OrganisationalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A division of a large organization such as a government, university, or business, dealing with a specific area of activity.</para>
    /// labels<para>Organisational unit</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#OrganisationalUnit">http://w3id.org/um/cbcm/eu-cm-ontology#OrganisationalUnit</seealso>
    let OrganisationalUnit = Prefixed_Name(cbcm, "OrganisationalUnit") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:CompanyHeadQuarter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The location of a company headquarter</para>
    /// labels<para>Company headquarter</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyHeadQuarter">http://w3id.org/um/cbcm/eu-cm-ontology#CompanyHeadQuarter</seealso>
    let CompanyHeadQuarter = Prefixed_Name(cbcm, "CompanyHeadQuarter") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:CompanyConversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The process of changing or converting the corporate structure of a company. For example, a limited liability company of one country to one of another country, or from a private to a public limited liability company, or vice-versa by means of the continuance of an entity into another entity.</para>
    /// labels<para>Company conversion</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyConversion">http://w3id.org/um/cbcm/eu-cm-ontology#CompanyConversion</seealso>
    let CompanyConversion = Prefixed_Name(cbcm, "CompanyConversion") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:ConversionPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A document providing details of how the conversion of a company will be implemented. Article 86d: The management or administrative organ of the company shall draw up the draft terms of a cross-border conversion. The draft terms of a cross-border conversion shall include at least the particulars listed in article 86d</para>
    /// labels<para>Company conversion plan</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#ConversionPlan">http://w3id.org/um/cbcm/eu-cm-ontology#ConversionPlan</seealso>
    let ConversionPlan = Prefixed_Name(cbcm, "ConversionPlan") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:requiresDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(requiresDocument ?ENTITY1 ?ENTITY2) means that some significant event or process ?ENTITY1 needs a compulsory document ?ENTITY2 to be submitted and reviewed before the process ?ENTITY1 can be completed.</para>
    /// labels<para>requires document</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#requiresDocument">http://w3id.org/um/cbcm/eu-cm-ontology#requiresDocument</seealso>
    let requiresDocument = Prefixed_Name(cbcm, "requiresDocument") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:sourceCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(sourceCountry ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 has some transaction input (a company) whose place of business is located in the country ?ENTITY2.</para>
    /// labels<para>source country</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#sourceCountry">http://w3id.org/um/cbcm/eu-cm-ontology#sourceCountry</seealso>
    let sourceCountry = Prefixed_Name(cbcm, "sourceCountry") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:targetCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(targetCountry ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 has some transaction result (a company) whose place of business is located in the country ?ENTITY2.</para>
    /// labels<para>target country</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#targetCountry">http://w3id.org/um/cbcm/eu-cm-ontology#targetCountry</seealso>
    let targetCountry = Prefixed_Name(cbcm, "targetCountry") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:CompanyTransaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An action taken by a company that modifies its corporate structure with a change of control (for e.g. through either a merger, division, conversion or seat transfer in a domestic or cross-border setting). It involves one or more companies, each of which have a company legal form valid in a Member State of the European Union.</para>
    /// labels<para>Company transaction</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyTransaction">http://w3id.org/um/cbcm/eu-cm-ontology#CompanyTransaction</seealso>
    let CompanyTransaction = Prefixed_Name(cbcm, "CompanyTransaction") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:involvesChangeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(involvesChangeOf ?ENTITY1 ?ENTITY2) means that the process ?ENTITY1 requires the modification or alteration of the entity or object ?ENTITY2.</para>
    /// labels<para>involves the change of</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#involvesChangeOf">http://w3id.org/um/cbcm/eu-cm-ontology#involvesChangeOf</seealso>
    let involvesChangeOf = Prefixed_Name(cbcm, "involvesChangeOf") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:CompanyLegalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Name given to describe the structure of a corporation or business in the different legal orders. For example Limited (Ltd.), Public Limited Company (PLC), Gesellschaft mit beschränkter Haftung (GmbH), Aktiengesellschaft (AG). The company legal form is regulated under national law and grants specific rights and obligations to the company stakeholders (such as shareholders, management &amp; employees).</para>
    /// labels<para>Company form</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyLegalForm">http://w3id.org/um/cbcm/eu-cm-ontology#CompanyLegalForm</seealso>
    let CompanyLegalForm = Prefixed_Name(cbcm, "CompanyLegalForm") |> PrefixedName
    /// <summary>
    ///   <para>cbcm:CompanyDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Article 160b - Division means:
    /// a) company being divided, on being dissolved without going into liquidation, transfers all its assets and liabilities to two or more newly formed companies (‘the recipient companies’), in exchange for the issue to the members of the company being divided of securities or shares in the recipient companies and, if any, a cash payment not exceeding 10 % of the nominal value of those securities or shares or, where they have no nominal value, a cash payment not exceeding 10% of the accounting par value of their securities or shares ('full division');
    ///
    /// (b) 	a company being divided transfers part of its assets and liabilities to one or more newly formed companies (‘the recipient companies’), in exchange for the issue to the members of the company being divided of securities or shares in the recipient companies or in the company being divided or in both the recipient companies and in the company being divided, and if any a cash payment not exceeding 10 % of the nominal value of those securities or shares, or in the absence of a nominal value, a cash payment not exceeding 10 % of the accounting par value of their securities or shares (‘partial division’).
    ///
    /// (c) 	a company being divided transfers part of its assets and liabilities to one or more newly formed companies (‘the recipient companies’), in exchange for the issue of securities or shares in the recipient companies to the company being divided (‘division by separation’).</para>
    /// labels<para>Company division</para></remarks>
    /// <seealso href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyDivision">http://w3id.org/um/cbcm/eu-cm-ontology#CompanyDivision</seealso>
    let CompanyDivision = Prefixed_Name(cbcm, "CompanyDivision") |> PrefixedName
