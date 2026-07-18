namespace http.w3id.org.um.cbcm.eu_cm_ontology.hash

open DoxAletheia.Rdf_Vocabulary

module cbcm =
    let _namespace_name = "http://w3id.org/um/cbcm/eu-cm-ontology#"

    /// <summary>
    /// A legal document which provides information related to, or influencing, a company's mobility within a specific country or across national boundaries.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyMobilityDocument"></see></summary>
    let CompanyMobilityDocument =
        Namespaced_IRI.parse _namespace_name "CompanyMobilityDocument" |> NamespacedName

    /// <summary>
    /// A digital document repository containing documents related to company mobility.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DocumentRepository"></see></summary>
    let DocumentRepository =
        Namespaced_IRI.parse _namespace_name "DocumentRepository" |> NamespacedName

    /// <summary>
    /// A legal right of a legal entity involved in the process of a company transaction. A legal right here refers to the entitlement of a person to be allowed to perform an activity, or to possess or obtain access to an object.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#TransactionRight"></see></summary>
    let TransactionRight =
        Namespaced_IRI.parse _namespace_name "TransactionRight" |> NamespacedName

    /// <summary>
    /// A city (plural "cities") is a geo-political region in which there is a large human settlement. The distinction with the term "town" (plural "towns") is that cities are generally larger than towns. Countries are generally larger than cities and, in fact, usually consist of multiple cities.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#City"></see></summary>
    let City = Namespaced_IRI.parse _namespace_name "City" |> NamespacedName

    /// <summary>
    /// The physical address or location at which the primary business activities of a company are carried out.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyRegisteredOffice"></see></summary>
    let CompanyRegisteredOffice =
        Namespaced_IRI.parse _namespace_name "CompanyRegisteredOffice" |> NamespacedName

    /// <summary>
    /// A geo-political region that has a distinct and common political governance structure for people that inhabit it for a significant portion of their lives. The majority of people that inhabit such a region are also usually united by common descent, history, culture and language.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Country"></see></summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName

    /// <summary>
    /// Acquiring Company means the resulting or surviving company in a transaction that takes over another, merging company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#AcquiringCompany"></see></summary>
    let AcquiringCompany =
        Namespaced_IRI.parse _namespace_name "AcquiringCompany" |> NamespacedName

    /// <summary>
    /// ‘merger’ in Directive (EU) 2017/1132 means an operation whereby:
    ///
    /// (a) one or more companies, on being dissolved without going into liquidation, transfer all their assets and liabilities to another existing company, the acquiring company, in exchange for the issue to their members of securities or shares representing the capital of that other company and, if applicable, a cash payment not exceeding 10 % of the nominal value, or, in the absence of a nominal value, of the accounting par value of those securities or shares; or
    ///
    /// (b) two or more companies, on being dissolved without going into liquidation, transfer all their assets and liabilities to a company that they form, the new company, in exchange for the issue to their members of securities or shares representing the capital of that new company and, if applicable, a cash payment not exceeding 10 % of the nominal value, or in the absence of a nominal value, of the accounting par value of those securities or shares; or
    ///
    /// (c) a company, on being dissolved without going into liquidation, transfers all its assets and liabilities to the company holding all the securities or shares representing its capital;"
    ///
    /// (d) one or more companies, on being dissolved without going into liquidation, transfer all their assets and liabilities to another existing company, the acquiring company, without the issue of any new shares by the acquiring company, provided that one person holds directly or indirectly all the shares in the merging companies or the members of the merging companies hold their shares in the same proportion in all merging companies.";
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyMerger"></see></summary>
    let CompanyMerger =
        Namespaced_IRI.parse _namespace_name "CompanyMerger" |> NamespacedName

    /// <summary>
    /// (isTransactionResultOf ?ENTITY1 ?ENTITY2) means (hasTransactionResult ?ENTITY2 ?ENTITY1)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#isTransactionResultOf"></see></summary>
    let isTransactionResultOf =
        Namespaced_IRI.parse _namespace_name "isTransactionResultOf" |> NamespacedName

    /// <summary>
    /// A company is a legal entity formed by a group of individuals to engage in and operate a business—commercial or industrial—enterprise. A company may be organized in various ways for tax and financial liability purposes depending on the corporate law of its jurisdiction.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Company"></see></summary>
    let Company = Namespaced_IRI.parse _namespace_name "Company" |> NamespacedName
    /// <summary>
    /// An entity or group of entities (either biological or non-biological) that is able to perform actions autonomously in the world.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName

    /// <summary>
    /// Annual reports measure a company's financial health. They focus on past and present financial performance, and make predictions about future prospects. The revenue and financial performance of a company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#AnnualAccount"></see></summary>
    let AnnualAccount =
        Namespaced_IRI.parse _namespace_name "AnnualAccount" |> NamespacedName

    /// <summary>
    /// Annual reports measure a company's financial health. They focus on past and present financial performance, and make predictions about future prospects. The revenue and financial performance of a company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#AnnualReport"></see></summary>
    let AnnualReport =
        Namespaced_IRI.parse _namespace_name "AnnualReport" |> NamespacedName

    /// <summary>
    /// An attribute is a characteristic of some entity.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Attribute"></see></summary>
    let Attribute = Namespaced_IRI.parse _namespace_name "Attribute" |> NamespacedName
    /// <summary>
    /// Behaviour is the set of actions and mannerisms made by systems (biological or otherwise) in response to stimuli or inputs, whether internal or external, conscious or subconscious, overt or covert, and voluntary or involuntary.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Behaviour"></see></summary>
    let Behaviour = Namespaced_IRI.parse _namespace_name "Behaviour" |> NamespacedName
    /// <summary>
    /// A procedure is a process that attempts to achieve one or more objectives by following an established set of actions.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Procedure"></see></summary>
    let Procedure = Namespaced_IRI.parse _namespace_name "Procedure" |> NamespacedName

    /// <summary>
    /// Board-level representation of employees (BLER) refers to the phenomenon where employees or their representatives elect or appoint representatives to the strategic decision-making body of a company (i.e. the supervisory board or non-executive board in a one-tier system). The BLER right requires that if such a system of BLER exists prior to a cross-border company transaction, such a right must be upheld in the acquiring/recipient company under the "before-and-after-principle".
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#BoardLevelEmployeeRepresentationRight"></see></summary>
    let BoardLevelEmployeeRepresentationRight =
        Namespaced_IRI.parse _namespace_name "BoardLevelEmployeeRepresentationRight" |> NamespacedName

    /// <summary>
    /// Social rights, as opposed to rights arising from natural law, are rights for legal entities that entitle them to certain levels of societal living conditions (e.g. the right to housing, to food, to health care etc.)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#SocialRight"></see></summary>
    let SocialRight =
        Namespaced_IRI.parse _namespace_name "SocialRight" |> NamespacedName

    /// <summary>
    /// A Board Resolution, or Company Resolution, is a way of documenting a decision made by a Company's Board of Directors on behalf of the company. After the resolution is made during a meeting, a Board Resolution document is typically used to get the specifics of the resolution in writing.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#BoardResolution"></see></summary>
    let BoardResolution =
        Namespaced_IRI.parse _namespace_name "BoardResolution" |> NamespacedName

    /// <summary>
    /// A document detailing a decision made by an individual or group of natural or legal persons. This can be a decision concerning the restructuring of a company by its shareholders.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Resolution"></see></summary>
    let Resolution = Namespaced_IRI.parse _namespace_name "Resolution" |> NamespacedName

    /// <summary>
    /// A person that is interested in research about cross-border company mobility, and actively collects and analyses data concerning cross-border company mobility.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CBCMResearcher"></see></summary>
    let CBCMResearcher =
        Namespaced_IRI.parse _namespace_name "CBCMResearcher" |> NamespacedName

    /// <summary>
    /// A person is an object that has certain capacities or attributes constituting personhood. A human being that has existed or continues to exist in the world (either deceased or living). Fictional human beings cannot be  instances of this class.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName
    /// <summary>
    /// (locatedIn ?ENTITY1 ?ENTITY2) means that some entity ?ENTITY1 occupies the spatial region referred to by ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#locatedIn"></see></summary>
    let locatedIn = Namespaced_IRI.parse _namespace_name "locatedIn" |> NamespacedName

    /// <summary>
    /// A spatial region on earth whose boundaries are determined by a combination of geographical, ecological, climatic, socio-economic and political criteria.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#GeoPoliticalRegion"></see></summary>
    let GeoPoliticalRegion =
        Namespaced_IRI.parse _namespace_name "GeoPoliticalRegion" |> NamespacedName

    /// <summary>
    /// The workforce of a company. An employee is a party to an employment relationship characterised as a contract of employment (or contract of service) between the employer and employee. However, this is only one of several different legal formulations of the concept of ‘worker’ in the EU which differ between Member States.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Employee"></see></summary>
    let Employee = Namespaced_IRI.parse _namespace_name "Employee" |> NamespacedName
    /// <summary>
    /// (hasMember ?ENTITY1 ?ENTITY2) means that some agent ?ENTITY1 (usually an organisation) has a person ?ENTITY2 that participates in its activities. This need not represent an employment role nor imply financial incentives between the organisation and person.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasMember"></see></summary>
    let hasMember = Namespaced_IRI.parse _namespace_name "hasMember" |> NamespacedName
    /// <summary>
    /// (hasPart ?ENTITY1 ?ENTITY2) means that the entity referred to by ?ENTITY1 has a constituent entity referred to by ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasPart"></see></summary>
    let hasPart = Namespaced_IRI.parse _namespace_name "hasPart" |> NamespacedName

    /// <summary>
    /// The headquarters or body of a company which governs it's financial and administrative activities
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyCentralAdministration"></see></summary>
    let CompanyCentralAdministration =
        Namespaced_IRI.parse _namespace_name "CompanyCentralAdministration" |> NamespacedName

    /// <summary>
    /// Represents a collection of people organized together into a community or other social, commercial or political structure. The group has some common purpose or reason for existence which goes beyond the set of people belonging to it and can act as an Agent. Organizations are often decomposable into hierarchical structures.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Organisation"></see></summary>
    let Organisation =
        Namespaced_IRI.parse _namespace_name "Organisation" |> NamespacedName

    /// <summary>
    /// A division of a large organization such as a government, university, or business, dealing with a specific area of activity.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#OrganisationalUnit"></see></summary>
    let OrganisationalUnit =
        Namespaced_IRI.parse _namespace_name "OrganisationalUnit" |> NamespacedName

    /// <summary>
    /// The location of a company headquarter
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyHeadQuarter"></see></summary>
    let CompanyHeadQuarter =
        Namespaced_IRI.parse _namespace_name "CompanyHeadQuarter" |> NamespacedName

    /// <summary>
    /// The process of changing or converting the corporate structure of a company. For example, a limited liability company of one country to one of another country, or from a private to a public limited liability company, or vice-versa by means of the continuance of an entity into another entity.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyConversion"></see></summary>
    let CompanyConversion =
        Namespaced_IRI.parse _namespace_name "CompanyConversion" |> NamespacedName

    /// <summary>
    /// A document providing details of how the conversion of a company will be implemented. Article 86d: The management or administrative organ of the company shall draw up the draft terms of a cross-border conversion. The draft terms of a cross-border conversion shall include at least the particulars listed in article 86d
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ConversionPlan"></see></summary>
    let ConversionPlan =
        Namespaced_IRI.parse _namespace_name "ConversionPlan" |> NamespacedName

    /// <summary>
    /// (requiresDocument ?ENTITY1 ?ENTITY2) means that some significant event or process ?ENTITY1 needs a compulsory document ?ENTITY2 to be submitted and reviewed before the process ?ENTITY1 can be completed.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#requiresDocument"></see></summary>
    let requiresDocument =
        Namespaced_IRI.parse _namespace_name "requiresDocument" |> NamespacedName

    /// <summary>
    /// (sourceCountry ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 has some transaction input (a company) whose place of business is located in the country ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#sourceCountry"></see></summary>
    let sourceCountry =
        Namespaced_IRI.parse _namespace_name "sourceCountry" |> NamespacedName

    /// <summary>
    /// (targetCountry ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 has some transaction result (a company) whose place of business is located in the country ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#targetCountry"></see></summary>
    let targetCountry =
        Namespaced_IRI.parse _namespace_name "targetCountry" |> NamespacedName

    /// <summary>
    /// An action taken by a company that modifies its corporate structure with a change of control (for e.g. through either a merger, division, conversion or seat transfer in a domestic or cross-border setting). It involves one or more companies, each of which have a company legal form valid in a Member State of the European Union.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyTransaction"></see></summary>
    let CompanyTransaction =
        Namespaced_IRI.parse _namespace_name "CompanyTransaction" |> NamespacedName

    /// <summary>
    /// (hasTransactionInput ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 has a prerequisite entity ?ENTITY2 that needs to be considered, assessed, or modified during the transaction referred to by ?ENTITY1.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasTransactionInput"></see></summary>
    let hasTransactionInput =
        Namespaced_IRI.parse _namespace_name "hasTransactionInput" |> NamespacedName

    /// <summary>
    /// (hasTransactionResult ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 has a byproduct ?ENTITY2 (e.g. a company, transaction certificate etc.) after completion of the process.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasTransactionResult"></see></summary>
    let hasTransactionResult =
        Namespaced_IRI.parse _namespace_name "hasTransactionResult" |> NamespacedName

    /// <summary>
    /// (involvesChangeOf ?ENTITY1 ?ENTITY2) means that the process ?ENTITY1 requires the modification or alteration of the entity or object ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#involvesChangeOf"></see></summary>
    let involvesChangeOf =
        Namespaced_IRI.parse _namespace_name "involvesChangeOf" |> NamespacedName

    /// <summary>
    /// Name given to describe the structure of a corporation or business in the different legal orders. For example Limited (Ltd.), Public Limited Company (PLC), Gesellschaft mit beschränkter Haftung (GmbH), Aktiengesellschaft (AG). The company legal form is regulated under national law and grants specific rights and obligations to the company stakeholders (such as shareholders, management &amp; employees).
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyLegalForm"></see></summary>
    let CompanyLegalForm =
        Namespaced_IRI.parse _namespace_name "CompanyLegalForm" |> NamespacedName

    /// <summary>
    /// Article 160b - Division means:
    /// a) company being divided, on being dissolved without going into liquidation, transfers all its assets and liabilities to two or more newly formed companies (‘the recipient companies’), in exchange for the issue to the members of the company being divided of securities or shares in the recipient companies and, if any, a cash payment not exceeding 10 % of the nominal value of those securities or shares or, where they have no nominal value, a cash payment not exceeding 10% of the accounting par value of their securities or shares ('full division');
    ///
    /// (b) 	a company being divided transfers part of its assets and liabilities to one or more newly formed companies (‘the recipient companies’), in exchange for the issue to the members of the company being divided of securities or shares in the recipient companies or in the company being divided or in both the recipient companies and in the company being divided, and if any a cash payment not exceeding 10 % of the nominal value of those securities or shares, or in the absence of a nominal value, a cash payment not exceeding 10 % of the accounting par value of their securities or shares (‘partial division’).
    ///
    /// (c) 	a company being divided transfers part of its assets and liabilities to one or more newly formed companies (‘the recipient companies’), in exchange for the issue of securities or shares in the recipient companies to the company being divided (‘division by separation’).
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyDivision"></see></summary>
    let CompanyDivision =
        Namespaced_IRI.parse _namespace_name "CompanyDivision" |> NamespacedName

    /// <summary>
    /// (hasRecipientCompany ?ENTITY1 ?ENTITY2) means that some company division transaction ?ENTITY1 produces two or more distinct companies, one of which is ?ENTITY2 (a so-called "recipient company").
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasRecipientCompany"></see></summary>
    let hasRecipientCompany =
        Namespaced_IRI.parse _namespace_name "hasRecipientCompany" |> NamespacedName

    /// <summary>
    /// The management or administrative organ of the company shall draw up the draft terms of a division. The draft terms of a division shall include at least the particulars listed in article 160d.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DivisionPlan"></see></summary>
    let DivisionPlan =
        Namespaced_IRI.parse _namespace_name "DivisionPlan" |> NamespacedName

    /// <summary>
    /// Article 91: The administrative or management bodies of the merging companies shall draw up draft terms of merger in writing by specifying at least the elements mentioned in article 91.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#MergerPlan"></see></summary>
    let MergerPlan = Namespaced_IRI.parse _namespace_name "MergerPlan" |> NamespacedName

    /// <summary>
    /// The act of changing the location where the company’s business was managed (registered office or headquarters) or the place where that company’s primary business was actually conducted (central administration).
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanySeatTransfer"></see></summary>
    let CompanySeatTransfer =
        Namespaced_IRI.parse _namespace_name "CompanySeatTransfer" |> NamespacedName

    /// <summary>
    /// The management or administrative organ of the company draws up the draft terms of a cross-border seat transfer. The draft terms of a cross-border seat transfer must include at least the particulars specified under national law.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#SeatTransferPlan"></see></summary>
    let SeatTransferPlan =
        Namespaced_IRI.parse _namespace_name "SeatTransferPlan" |> NamespacedName

    /// <summary>
    /// (hasSubProcedure ?ENTITY1 ?ENTITY2) means that some process ?ENTITY1 contains another (shorter) process ?ENTITY2 that should be completed before ?ENTITY1 can complete.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasSubProcedure"></see></summary>
    let hasSubProcedure =
        Namespaced_IRI.parse _namespace_name "hasSubProcedure" |> NamespacedName

    /// <summary>
    /// Act of modifying the location where the company’s business was managed or the place where that company’s business was actually conducted.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#TransferOfCentralAdministration"></see></summary>
    let TransferOfCentralAdministration =
        Namespaced_IRI.parse _namespace_name "TransferOfCentralAdministration" |> NamespacedName

    /// <summary>
    /// The act of changing the registered office, which is the official address of an incorporated company, association or any other legal entity.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#TransferOfRegisteredOffice"></see></summary>
    let TransferOfRegisteredOffice =
        Namespaced_IRI.parse _namespace_name "TransferOfRegisteredOffice" |> NamespacedName

    /// <summary>
    /// An individual, group, or organization that owns one or more shares in a company, and in whose name the share certificate is issued.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyShareholder"></see></summary>
    let CompanyShareholder =
        Namespaced_IRI.parse _namespace_name "CompanyShareholder" |> NamespacedName

    /// <summary>
    /// (partOf ?ENTITY1 ?ENTITY2) means (hasPart ?ENTITY2 ?ENTITY1)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#partOf"></see></summary>
    let partOf = Namespaced_IRI.parse _namespace_name "partOf" |> NamespacedName

    /// <summary>
    /// A person, group or organization that has interest or concern in an organization or company in particular. Stakeholders can affect or be affected by the company's actions, objectives and policies.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyStakeholder"></see></summary>
    let CompanyStakeholder =
        Namespaced_IRI.parse _namespace_name "CompanyStakeholder" |> NamespacedName

    /// <summary>
    /// A written notice, published in an official journal of a Member State of the EU and/or the European Official Journal indicating the intention to engage in a transaction and which informs  the members, creditors and representatives of the employees of the company, or, where there are no such representatives, the employees themselves of said transaction.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#TransactionNotice"></see></summary>
    let TransactionNotice =
        Namespaced_IRI.parse _namespace_name "TransactionNotice" |> NamespacedName

    /// <summary>
    /// (reportedIn ?ENTITY1 ?ENTITY2) means that some significant event, process or statement ?ENTITY1 is published or mentioned or declared in writing in some publication, document or database ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#reportedIn"></see></summary>
    let reportedIn = Namespaced_IRI.parse _namespace_name "reportedIn" |> NamespacedName

    /// <summary>
    /// A document issued by a Competent Authority declaring that certain steps of the transaction are completed.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#TransactionCertificate"></see></summary>
    let TransactionCertificate =
        Namespaced_IRI.parse _namespace_name "TransactionCertificate" |> NamespacedName

    /// <summary>
    /// (transactionValidatedByDocument ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 went through a process of approval and assessment through various criteria such as veracity, eligibility, legal relevance etc. and a document ?ENTITY2 was produced to prove the satisfaction of the critieria by ?ENTITY1.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionValidatedByDocument"></see></summary>
    let transactionValidatedByDocument =
        Namespaced_IRI.parse _namespace_name "transactionValidatedByDocument" |> NamespacedName

    /// <summary>
    /// The monitoring of the completion and legality of the decision-making process in each company involved in a transaction is carried out by a national authority having jurisdiction over each of those companies. The national authority could be a court, a notary or any other competent authority appointed by the Member State concerned.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompetentAuthority"></see></summary>
    let CompetentAuthority =
        Namespaced_IRI.parse _namespace_name "CompetentAuthority" |> NamespacedName

    /// <summary>
    /// The right of employees or their representatives to be consulted and to give advice on a business decision, such as an intended merger/division/conversion/seat transfer.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ConsultationRight"></see></summary>
    let ConsultationRight =
        Namespaced_IRI.parse _namespace_name "ConsultationRight" |> NamespacedName

    /// <summary>
    /// A document issued by a Competent Authority declaring that the legally required steps of a conversion are completed. The certificate needs to be presented by a company to either be registered in another company registry or to be removed from a company register.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ConversionCertificate"></see></summary>
    let ConversionCertificate =
        Namespaced_IRI.parse _namespace_name "ConversionCertificate" |> NamespacedName

    /// <summary>
    /// Document required by law to document the step of a company transaction or an agreement made between stakeholders involved in the transaction that are either printed, inserted and mailed, or electronically presented.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#TransactionDocument"></see></summary>
    let TransactionDocument =
        Namespaced_IRI.parse _namespace_name "TransactionDocument" |> NamespacedName

    /// <summary>
    /// Legal forum in which a body of people presided over by a judge, judges, or magistrate, and acting as a tribunal in civil and criminal cases resolve legal disputes.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Court"></see></summary>
    let Court = Namespaced_IRI.parse _namespace_name "Court" |> NamespacedName
    /// <summary>
    /// A person, organization, or government that is owed money. A creditor's claims and the safeguarding of these creditor rights is laid down in the company law of the Member States and EU law.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Creditor"></see></summary>
    let Creditor = Namespaced_IRI.parse _namespace_name "Creditor" |> NamespacedName

    /// <summary>
    /// The right of a creditor to influence or take a decision in the context of a transaction.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CreditorDecisionRight"></see></summary>
    let CreditorDecisionRight =
        Namespaced_IRI.parse _namespace_name "CreditorDecisionRight" |> NamespacedName

    /// <summary>
    /// The rights of creditors, which includes debenture holders, vis-a-vis the company that obtained credit from the individual or organisation. Legal safeguards are put in place to ensure that rights of creditors are not negatively affected by a company transaction.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CreditorRight"></see></summary>
    let CreditorRight =
        Namespaced_IRI.parse _namespace_name "CreditorRight" |> NamespacedName

    /// <summary>
    /// The creditors right to be paid out and therefore to exit the company in the context of a transaction.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CreditorExitRight"></see></summary>
    let CreditorExitRight =
        Namespaced_IRI.parse _namespace_name "CreditorExitRight" |> NamespacedName

    /// <summary>
    /// The information rights of creditors in the context of a company transaction, which includes for instance access to documents.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CreditorInformationRight"></see></summary>
    let CreditorInformationRight =
        Namespaced_IRI.parse _namespace_name "CreditorInformationRight" |> NamespacedName

    /// <summary>
    /// (applicableTo ?ENTITY1 ?ENTITY2) means that some legal right ?ENTITY1 is awarded or assigned to a particular person or agent ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#applicableTo"></see></summary>
    let applicableTo =
        Namespaced_IRI.parse _namespace_name "applicableTo" |> NamespacedName

    /// <summary>
    /// Member States shall provide for an adequate system of protection of the interest of creditors, and shall ensure that creditors who are dissatisfied with the safeguards offered in the draft terms of the transaction, as provided for in Article 86d (1) point (f), may apply to the appropriate administrative or judicial authority for adequate safeguards provided that they can credibly demonstrate that due to the transaction the satisfaction of their claims is at stake and that no adequate safeguards have been obtained from the company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CreditorSecurityRight"></see></summary>
    let CreditorSecurityRight =
        Namespaced_IRI.parse _namespace_name "CreditorSecurityRight" |> NamespacedName

    /// <summary>
    /// A cross-border conversion is an operation through which a company, formed in one country (with the EU/EEA set of countries) is converted into a company governed by the law of another.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderConversion"></see></summary>
    let CrossBorderConversion =
        Namespaced_IRI.parse _namespace_name "CrossBorderConversion" |> NamespacedName

    /// <summary>
    /// Article 86m: a pre-conversion certificate attests compliance with all the relevant conditions and the proper completion of all procedures and formalities in the departure Member State.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#PreConversionCertificate"></see></summary>
    let PreConversionCertificate =
        Namespaced_IRI.parse _namespace_name "PreConversionCertificate" |> NamespacedName

    /// <summary>
    /// (involvesCountry ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 includes the modification of a company whose place of business is located in the country referred to by ?ENTITY2
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#involvesCountry"></see></summary>
    let involvesCountry =
        Namespaced_IRI.parse _namespace_name "involvesCountry" |> NamespacedName

    /// <summary>
    /// A company which in a process of the cross-border division in case of a full division transfers all its assets and liabilities to two or more companies, or in case of a partial division or division by separation transfers part of its assets and liabilities to one or more companies. The companies involved in the process are located in multiple (two or more) distinct countries.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderDivision"></see></summary>
    let CrossBorderDivision =
        Namespaced_IRI.parse _namespace_name "CrossBorderDivision" |> NamespacedName

    /// <summary>
    /// A cross border merger involves at least one company based in an EU Member State and one company that is registered elsewhere within the European Union and is leading to a universal transfer of assets and liabilities from the merging company to the acquiring company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderMerger"></see></summary>
    let CrossBorderMerger =
        Namespaced_IRI.parse _namespace_name "CrossBorderMerger" |> NamespacedName

    /// <summary>
    /// Merging Company means the dissolving company that is being acquired by another (acquiring) company in the process of a transaction. In the context of company mobility, this means a universal transfer of assets and liabilities from the merging to the acquiring company (see article 131 of Directive 2017/1132).
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#MergingCompany"></see></summary>
    let MergingCompany =
        Namespaced_IRI.parse _namespace_name "MergingCompany" |> NamespacedName

    /// <summary>
    /// Article 89: The operation whereby one or more companies are wound up without going into liquidation and transfer to another all their assets and liabilities in exchange for the issue to the shareholders of the company or companies being acquired of shares in the acquiring company and a cash payment, if any, not exceeding 10 % of the nominal value of the shares so issued or, where they have no nominal value, of their accounting par value. Companies involved come from two or more distinct countries.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderMergerByAcquisition"></see></summary>
    let CrossBorderMergerByAcquisition =
        Namespaced_IRI.parse _namespace_name "CrossBorderMergerByAcquisition" |> NamespacedName

    /// <summary>
    /// (hasMergingCompany ?ENTITY1 ?ENTITY2) means that some company merger transaction ?ENTITY1 involves a company ?ENTITY2 which will be dissolved during the process of ?ENTITY1 and will be acquired (via a universal transfer of assets and liabilities) by another distinct company involved in ?ENTITY1.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasMergingCompany"></see></summary>
    let hasMergingCompany =
        Namespaced_IRI.parse _namespace_name "hasMergingCompany" |> NamespacedName

    /// <summary>
    /// (hasAcquiringCompany ?ENTITY1 ?ENTITY2) means that some company merger transaction ?ENTITY1 produces a new company or alters an existing one (?ENTITY2) such that ?ENTITY2 will acquire (via a universal transfer of assets and liabilities) one or more other companies involved in the process ?ENTITY1.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasAcquiringCompany"></see></summary>
    let hasAcquiringCompany =
        Namespaced_IRI.parse _namespace_name "hasAcquiringCompany" |> NamespacedName

    /// <summary>
    /// Article 90: the operation whereby several companies are wound up without going into liquidation and transfer to a company that they set up all their assets and liabilities in exchange for the issue to their shareholders of shares in the new company and a cash payment, if any, not exceeding 10 % of the nominal value of the shares so issued or, where they have no nominal value, of their accounting par value. Companies involved come from two or more distinct countries.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderMergerIntoNewCompany"></see></summary>
    let CrossBorderMergerIntoNewCompany =
        Namespaced_IRI.parse _namespace_name "CrossBorderMergerIntoNewCompany" |> NamespacedName

    /// <summary>
    /// The act of changing the location where the company’s business was managed (registered office or headquarters) or the place where that company’s primary business was actually conducted (central administration), across national boundaries.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderSeatTransfer"></see></summary>
    let CrossBorderSeatTransfer =
        Namespaced_IRI.parse _namespace_name "CrossBorderSeatTransfer" |> NamespacedName

    /// <summary>
    /// A data curation activity represents a researcher's involvement in annotating cross border transactions
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DataCurationActivity"></see></summary>
    let DataCurationActivity =
        Namespaced_IRI.parse _namespace_name "DataCurationActivity" |> NamespacedName

    /// <summary>
    /// Usage is the beginning of utilizing an entity by an activity. Before usage, the activity had not begun to utilize this entity and could not have been affected by the entity.
    ///
    /// Based on: https://www.w3.org/TR/prov-o/#used
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#used"></see></summary>
    let used = Namespaced_IRI.parse _namespace_name "used" |> NamespacedName

    /// <summary>
    /// An activity association is an assignment of responsibility to an agent for a process, indicating that the agent had a role in the activity.
    ///
    /// Based on: https://www.w3.org/TR/prov-o/#wasAssociatedWith
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#wasAssociatedWith"></see></summary>
    let wasAssociatedWith =
        Namespaced_IRI.parse _namespace_name "wasAssociatedWith" |> NamespacedName

    /// <summary>
    /// The shareholders can take a number of decisions affecting the company, such as amending the company's articles of association, appointing or dismissing board members and to approve important transactions (e.g. mergers, divisions and conversions/seat transfers). These are taken through a shareholder resolution.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DecisionRight"></see></summary>
    let DecisionRight =
        Namespaced_IRI.parse _namespace_name "DecisionRight" |> NamespacedName

    /// <summary>
    /// The rights of shareholders of a company in the context of a transaction. Often, shreholder resolutions are used to effectuate shareholder rights. Many rights are laid down in the so-called Shareholder Rights Directive.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ShareholderRight"></see></summary>
    let ShareholderRight =
        Namespaced_IRI.parse _namespace_name "ShareholderRight" |> NamespacedName

    /// <summary>
    /// A document issued by a Competent Authority declaring that the legally required steps of a division are completed. The certificate needs to be presented by a company to either be registered (or register a newly established emerging/recipient company) in another company registry or to be removed from a company register.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DivisionCertificate"></see></summary>
    let DivisionCertificate =
        Namespaced_IRI.parse _namespace_name "DivisionCertificate" |> NamespacedName

    /// <summary>
    /// A domestic conversion is an operation through which a company's form is converted into a another while still remaining governed by the same law as the original company. For instance, the modification of a company's form from a public to a private limited company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticConversion"></see></summary>
    let DomesticConversion =
        Namespaced_IRI.parse _namespace_name "DomesticConversion" |> NamespacedName

    /// <summary>
    /// A company which in a process of the domestic division - in case of a full division - transfers all its assets and liabilities to two or more companies, or - in case of a partial division or division by separation - transfers part of its assets and liabilities to one or more companies. All companies involved in the process are located in a single country.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticDivision"></see></summary>
    let DomesticDivision =
        Namespaced_IRI.parse _namespace_name "DomesticDivision" |> NamespacedName

    /// <summary>
    /// A domestic merger involves at least two companies based in the same EU Member State and is leading to a universal transfer of assets and liabilities from the merging company to the acquiring company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticMerger"></see></summary>
    let DomesticMerger =
        Namespaced_IRI.parse _namespace_name "DomesticMerger" |> NamespacedName

    /// <summary>
    /// Article 89: The operation whereby one or more companies are wound up without going into liquidation and transfer to another all their assets and liabilities in exchange for the issue to the shareholders of the company or companies being acquired of shares in the acquiring company and a cash payment, if any, not exceeding 10 % of the nominal value of the shares so issued or, where they have no nominal value, of their accounting par value. All companies involved are from a single country.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticMergerByAcquisition"></see></summary>
    let DomesticMergerByAcquisition =
        Namespaced_IRI.parse _namespace_name "DomesticMergerByAcquisition" |> NamespacedName

    /// <summary>
    /// Article 90: the operation whereby several companies are wound up without going into liquidation and transfer to a company that they set up all their assets and liabilities in exchange for the issue to their shareholders of shares in the new company and a cash payment, if any, not exceeding 10 % of the nominal value of the shares so issued or, where they have no nominal value, of their accounting par value. All companies involved are from a single country.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticMergerIntoNewCompany"></see></summary>
    let DomesticMergerIntoNewCompany =
        Namespaced_IRI.parse _namespace_name "DomesticMergerIntoNewCompany" |> NamespacedName

    /// <summary>
    /// A company being divided transfers part of its assets and liabilities to one or more newly formed companies, which are the recipient companies in a (cross-border) division.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#EmergingCompany"></see></summary>
    let EmergingCompany =
        Namespaced_IRI.parse _namespace_name "EmergingCompany" |> NamespacedName

    /// <summary>
    /// The act of changing the location where the company’s business was managed (registered office or headquarters) or the place where that company’s primary business was actually conducted (central administration), within a specific country.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticSeatTransfer"></see></summary>
    let DomesticSeatTransfer =
        Namespaced_IRI.parse _namespace_name "DomesticSeatTransfer" |> NamespacedName

    /// <summary>
    /// Created in 1994, the European Economic Area (EEA) combines the countries of the European Union (EU) and member countries of the European Free Trade Association (EFTA) to facilitate participation in the European Market trade and movement without having to apply to be one of the EU member countries
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#EEACountry"></see></summary>
    let EEACountry = Namespaced_IRI.parse _namespace_name "EEACountry" |> NamespacedName

    /// <summary>
    /// A country which does not belong to the European Economic Area (EEA).
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#NonEEACountry"></see></summary>
    let NonEEACountry =
        Namespaced_IRI.parse _namespace_name "NonEEACountry" |> NamespacedName

    /// <summary>
    /// A country which forms part of the European Union. The European Union is a conglomeration of European countries whose governance structures agree to abide with common political and economic criteria to improve efficiency of goods and services trading as well as movement and migration of inhabitants between these countries
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#EUCountry"></see></summary>
    let EUCountry = Namespaced_IRI.parse _namespace_name "EUCountry" |> NamespacedName

    /// <summary>
    /// A country that does not officially belong to the EU conglomeration
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#NonEUCountry"></see></summary>
    let NonEUCountry =
        Namespaced_IRI.parse _namespace_name "NonEUCountry" |> NamespacedName

    /// <summary>
    /// (employedBy ?ENTITY1 ?ENTITY2) means that some agent (person or organisation) ?ENTITY1 is promised and delivered an incentive (usually financial) to perform some work for ?ENTITY2 where ?ENTITY2 is an organisation. This exchange is usually governed by law and formal regulations in the particular country or social context in which the work is being performed.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#employedBy"></see></summary>
    let employedBy = Namespaced_IRI.parse _namespace_name "employedBy" |> NamespacedName

    /// <summary>
    /// A body that regulates the financial services industry in a country (e.g. the UK), including most financial services markets, exchanges and firms.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#FinancialServiceAuthority"></see></summary>
    let FinancialServiceAuthority =
        Namespaced_IRI.parse _namespace_name "FinancialServiceAuthority" |> NamespacedName

    /// <summary>
    /// A global ultimate owner (GUO) is the individual or entity at the top of the corporate ownership structure.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#GlobalUltimateOwner"></see></summary>
    let GlobalUltimateOwner =
        Namespaced_IRI.parse _namespace_name "GlobalUltimateOwner" |> NamespacedName

    /// <summary>
    /// (owns ?ENTITY1 ?ENTITY2) means (owns ?ENTITY2 ?ENTITY1)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#owns"></see></summary>
    let owns = Namespaced_IRI.parse _namespace_name "owns" |> NamespacedName

    /// <summary>
    /// The right of employees or their representatives to be informed on the likely repercussions of the cross-border transaction on employment, which includes the dismissal as well as the hiring of employees or relocation of work. See for instance article 122 of Directive 2017/1132.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ImpactOnEmploymentRight"></see></summary>
    let ImpactOnEmploymentRight =
        Namespaced_IRI.parse _namespace_name "ImpactOnEmploymentRight" |> NamespacedName

    /// <summary>
    /// The right of employees or their representatives to be informed and to receive any documents necessary for the exercise of their consultation and board-level employee representation rights in the context of an intended merger/division/conversion/seat transfer.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#InformationRight"></see></summary>
    let InformationRight =
        Namespaced_IRI.parse _namespace_name "InformationRight" |> NamespacedName

    /// <summary>
    /// An Independent Expert provides impartial advice to shareholders and other company stakeholders on the fairness and/or reasonableness of a transaction.  A company may be required to commission an Independent Expert Report (IER) in the case of a (cross-border) merger, division or conversion.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#IndependentExpert"></see></summary>
    let IndependentExpert =
        Namespaced_IRI.parse _namespace_name "IndependentExpert" |> NamespacedName

    /// <summary>
    /// Article 86g and 160i: Member States must ensure that an independent expert examines the draft terms of the transaction and draws up a report intended for members which is made available to them not less than one month before the date of the general meeting. Depending on the law of Member States, the expert may be a natural person or a legal person. The report must assess the cash compensation proposed and valuation method.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#IndependentExpertReport"></see></summary>
    let IndependentExpertReport =
        Namespaced_IRI.parse _namespace_name "IndependentExpertReport" |> NamespacedName

    /// <summary>
    /// (authoredBy ?ENTITY1 ?ENTITY2) means that ?ENTITY1 is an instance of a publication that is created primarily by the entity referred to by ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#authoredBy"></see></summary>
    let authoredBy = Namespaced_IRI.parse _namespace_name "authoredBy" |> NamespacedName

    /// <summary>
    /// Interim accounts are accounts that are published during a company's financial year and that show the financial situation on a given accounting date.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#InterimAccount"></see></summary>
    let InterimAccount =
        Namespaced_IRI.parse _namespace_name "InterimAccount" |> NamespacedName

    /// <summary>
    /// The group of persons comprising the governing body of the legal entity that is entrusted with the decision-making in the company. It is also called Executive Board in a one-tier board system.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagementBoard"></see></summary>
    let ManagementBoard =
        Namespaced_IRI.parse _namespace_name "ManagementBoard" |> NamespacedName

    /// <summary>
    /// A person or group of persons that are responsible for overseeing the operations of a company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Manager"></see></summary>
    let Manager = Namespaced_IRI.parse _namespace_name "Manager" |> NamespacedName

    /// <summary>
    /// A report drawn up by the company's management on the intended transaction, laying out the main features of the transactions and its consequences.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagementReport"></see></summary>
    let ManagementReport =
        Namespaced_IRI.parse _namespace_name "ManagementReport" |> NamespacedName

    /// <summary>
    /// The right of the board of management or individual managers to take decisions or to not take a decision in the context of a transaction. These are in the form of a board resolution.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagerDecisionRight"></see></summary>
    let ManagerDecisionRight =
        Namespaced_IRI.parse _namespace_name "ManagerDecisionRight" |> NamespacedName

    /// <summary>
    /// The rights of members of the management in the context of a company transaction.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagerRight"></see></summary>
    let ManagerRight =
        Namespaced_IRI.parse _namespace_name "ManagerRight" |> NamespacedName

    /// <summary>
    /// The right of a manager or the board of management to resign and therefore exit a company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagerExitRight"></see></summary>
    let ManagerExitRight =
        Namespaced_IRI.parse _namespace_name "ManagerExitRight" |> NamespacedName

    /// <summary>
    /// The right of a manager to information and access to documents that he or she has in accordance with national or European company law.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagerInformationRight"></see></summary>
    let ManagerInformationRight =
        Namespaced_IRI.parse _namespace_name "ManagerInformationRight" |> NamespacedName

    /// <summary>
    /// The national gazette or record in a particular Member State. In the official journal companies publish company transaction notices in order to inform concerned stakeholders and interested parties.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#MemberStateOfficialJournal"></see></summary>
    let MemberStateOfficialJournal =
        Namespaced_IRI.parse _namespace_name "MemberStateOfficialJournal" |> NamespacedName

    /// <summary>
    /// The official gazette of record for the European Union or national gazette of record of a Member State. In the official journal companies publish transaction notices in order to inform concerned stakeholders and interested parties.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#OfficialJournal"></see></summary>
    let OfficialJournal =
        Namespaced_IRI.parse _namespace_name "OfficialJournal" |> NamespacedName

    /// <summary>
    /// A document issued by a Competent Authority declaring that the legally required steps of a merger are completed. The certificate needs to be presented by a company to either be registered in another company registry or to be removed from a company register (depending on the company being the merging or acquiring company).
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#MergerCertificate"></see></summary>
    let MergerCertificate =
        Namespaced_IRI.parse _namespace_name "MergerCertificate" |> NamespacedName

    /// <summary>
    /// (isTransactionInputOf ?ENTITY1 ?ENTITY2) means (hasTransactionInput ?ENTITY2 ?ENTITY1)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#isTransactionInputOf"></see></summary>
    let isTransactionInputOf =
        Namespaced_IRI.parse _namespace_name "isTransactionInputOf" |> NamespacedName

    /// <summary>
    /// A national registry is a business registry in a Member State, which includes information on the population of companies in the jurisdiction and holds inter alia data on registration numbers, place of registration, notices and transaction documents in the national registry repository.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#NationalRegistry"></see></summary>
    let NationalRegistry =
        Namespaced_IRI.parse _namespace_name "NationalRegistry" |> NamespacedName

    /// <summary>
    /// The digital repository in which documents published in the official journal or by by the national registry (on behalf of a company) are kept as well as related documents. In some EU Member States, this repository is overlapping or identical with the Official Journal Repository.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#NationalRegistryRepository"></see></summary>
    let NationalRegistryRepository =
        Namespaced_IRI.parse _namespace_name "NationalRegistryRepository" |> NamespacedName

    /// <summary>
    /// (maintainedBy ?ENTITY1 ?ENTITY2) means that some digital resource ?ENTITY1 (e.g. database, website, document repository etc.) has stewardship by some agent or organisation ?ENTITY2 who is responsible for the upkeep of ?ENTITY1.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#maintainedBy"></see></summary>
    let maintainedBy =
        Namespaced_IRI.parse _namespace_name "maintainedBy" |> NamespacedName

    /// <summary>
    /// A person authorized to perform certain legal formalities, especially to draw up or certify contracts, deeds, and other documents for use in other jurisdictions.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Notary"></see></summary>
    let Notary = Namespaced_IRI.parse _namespace_name "Notary" |> NamespacedName

    /// <summary>
    /// Publication of a legally valid record or act in an official national gazette to inform stakeholders.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#OfficialJournalPublication"></see></summary>
    let OfficialJournalPublication =
        Namespaced_IRI.parse _namespace_name "OfficialJournalPublication" |> NamespacedName

    /// <summary>
    /// The digital repository in which documents published in the official journal are kept as well as related documents. In some EU Member States, this repository is overlapping or identical with the National Registry Repository.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#OfficialJournalRepository"></see></summary>
    let OfficialJournalRepository =
        Namespaced_IRI.parse _namespace_name "OfficialJournalRepository" |> NamespacedName

    /// <summary>
    /// An original company, in the context of a (cross-border) division, means a company which - in case of a full division - transfers all its assets and liabilities to two or more companies, or - in case of a partial division or division by separation - transfers part of its assets and liabilities to one or more companies.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#OriginalCompany"></see></summary>
    let OriginalCompany =
        Namespaced_IRI.parse _namespace_name "OriginalCompany" |> NamespacedName

    /// <summary>
    /// A parent company is a company that has a controlling interest in another company, the subsidiary company, giving it control of its operations through a majority stock-ownership, decisive control over management appointments and therefore over the decision-making process. In the absence of a natural person as ultimate beneficial owner, the highest parent company in a chain of companies is the global ultimate owner.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ParentCompany"></see></summary>
    let ParentCompany =
        Namespaced_IRI.parse _namespace_name "ParentCompany" |> NamespacedName

    /// <summary>
    /// (hasSubsidiaryCompany ?ENTITY1 ?ENTITY2) means (hasParentCompany ?ENTITY2 ?ENTITY1)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasSubsidiaryCompany"></see></summary>
    let hasSubsidiaryCompany =
        Namespaced_IRI.parse _namespace_name "hasSubsidiaryCompany" |> NamespacedName

    /// <summary>
    /// Article 160o: a pre-division certificate attests compliance with all the relevant conditions and the proper completion of all procedures and formalities in the Member State concerned.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#PreDivisionCertificate"></see></summary>
    let PreDivisionCertificate =
        Namespaced_IRI.parse _namespace_name "PreDivisionCertificate" |> NamespacedName

    /// <summary>
    /// Article 127: a pre-merger certificate attests compliance with all the relevant conditions and the proper completion of all procedures and formalities in the Member State of the merging company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#PreMergerCertificate"></see></summary>
    let PreMergerCertificate =
        Namespaced_IRI.parse _namespace_name "PreMergerCertificate" |> NamespacedName

    /// <summary>
    /// A company being divided transfers part of its assets and liabilities to one or more newly formed companies, which are the recipient companies in a (cross-border) division.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#RecipientCompany"></see></summary>
    let RecipientCompany =
        Namespaced_IRI.parse _namespace_name "RecipientCompany" |> NamespacedName

    /// <summary>
    /// Variable indicating the SE-establishment mode: by merger, conversion, holding-SE, subsidiary-SE or unsure (cases)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#SEType"></see></summary>
    let SEType = Namespaced_IRI.parse _namespace_name "SEType" |> NamespacedName

    /// <summary>
    /// This is a cross-border merger where two or more companies from different Member States merge into a new company that has a special legal form called a Societas Europaea (SE) which allows the behavior of this new company to be regulated under European Law (rather than national law).
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#SocietasEuropaeaMerger"></see></summary>
    let SocietasEuropaeaMerger =
        Namespaced_IRI.parse _namespace_name "SocietasEuropaeaMerger" |> NamespacedName

    /// <summary>
    /// The right of a shareholder to exit the company by being bought out.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ShareholderExitRight"></see></summary>
    let ShareholderExitRight =
        Namespaced_IRI.parse _namespace_name "ShareholderExitRight" |> NamespacedName

    /// <summary>
    /// It is particularly important that the shareholders of the companies involved in a transaction be kept adequately informed in an objective manner, and that their rights be suitably protected. This includes for instance the availability of documents for inspection by shareholders (e.g. article 97 of Directive 2017/1132).
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ShareholderInformationRight"></see></summary>
    let ShareholderInformationRight =
        Namespaced_IRI.parse _namespace_name "ShareholderInformationRight" |> NamespacedName

    /// <summary>
    /// a shareholder resolution is a proposal submitted by shareholders for a vote at the company's shareholder meeting.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ShareholderResolution"></see></summary>
    let ShareholderResolution =
        Namespaced_IRI.parse _namespace_name "ShareholderResolution" |> NamespacedName

    /// <summary>
    /// The society at large is a stakeholder in a company through, inter alia, the government and its agencies, suppliers, customers, trade unions and the communities from which the business draws its resources.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Society"></see></summary>
    let Society = Namespaced_IRI.parse _namespace_name "Society" |> NamespacedName

    /// <summary>
    /// The Special Negotiation Body (SNB) or Special Negotiating Body is an organisation that represents the employees of companies in negotiations with the company authorities in order to reach a written agreement on the involvement of employees in company transactions.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#SpecialNegotiationBody"></see></summary>
    let SpecialNegotiationBody =
        Namespaced_IRI.parse _namespace_name "SpecialNegotiationBody" |> NamespacedName

    /// <summary>
    /// A written agreement concerning the involvement of employees in company transactions. Special Negotiating Body (SNB) organisation represents employees in the negotiation of the terms of this agreement with the company authorities. The agreement must be reached in accordance with the EU Company Law Directive and is laid down in the SNB-agreement.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#SpecialNegotiationBodyAgreement"></see></summary>
    let SpecialNegotiationBodyAgreement =
        Namespaced_IRI.parse _namespace_name "SpecialNegotiationBodyAgreement" |> NamespacedName

    /// <summary>
    /// A subsidiary, subsidiary company or daughter company is a company that is owned or controlled by another company, which is called the parent company, parent, or holding company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#SubsidiaryCompany"></see></summary>
    let SubsidiaryCompany =
        Namespaced_IRI.parse _namespace_name "SubsidiaryCompany" |> NamespacedName

    /// <summary>
    /// (hasParentCompany ?ENTITY1 ?ENTITY2) means that some company ?ENTITY1 is owned and under direct or indirect control by the company ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasParentCompany"></see></summary>
    let hasParentCompany =
        Namespaced_IRI.parse _namespace_name "hasParentCompany" |> NamespacedName

    /// <summary>
    /// An individual authority established by its member state to supervise the compliance with a specific regulation.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#SupervisoryAuthority"></see></summary>
    let SupervisoryAuthority =
        Namespaced_IRI.parse _namespace_name "SupervisoryAuthority" |> NamespacedName

    /// <summary>
    /// A supervisory board must approve of major business decisions. It is a group of individuals chosen by the shareholders - and employee representatives in board-level employee representation systems - of a company to promote their interests through the governance of the company and to hire and supervise the management board. It is also called non-executive board in a one-tier board system.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#SupervisoryBoard"></see></summary>
    let SupervisoryBoard =
        Namespaced_IRI.parse _namespace_name "SupervisoryBoard" |> NamespacedName

    /// <summary>
    /// Tax Authority means any governmental authority having jurisdiction over the assessment, determination, collection or imposition of any tax.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#TaxAuthority"></see></summary>
    let TaxAuthority =
        Namespaced_IRI.parse _namespace_name "TaxAuthority" |> NamespacedName

    /// <summary>
    /// (containedIn ?ENTITY1 ?ENTITY2) means that some document or publication ?ENTITY1 is archived or stored in some other document collection, database or data repository referred to by ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#containedIn"></see></summary>
    let containedIn =
        Namespaced_IRI.parse _namespace_name "containedIn" |> NamespacedName

    /// <summary>
    /// Transferring Company means the company transferring its assets and liabilities to a recipient company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#TransferringCompany"></see></summary>
    let TransferringCompany =
        Namespaced_IRI.parse _namespace_name "TransferringCompany" |> NamespacedName

    /// <summary>
    /// Ultimate Beneficial owner refers to the natural person(s) who ultimately owns or controls a customer and/or the natural person on whose behalf a transaction is being conducted. It also includes those persons who exercise ultimate effective control over a legal person or arrangement.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#UltimateBeneficialOwner"></see></summary>
    let UltimateBeneficialOwner =
        Namespaced_IRI.parse _namespace_name "UltimateBeneficialOwner" |> NamespacedName

    /// <summary>
    /// The exercise of employee participation through the representation of employees vis-a-vis the management of a company. The works council is a shop-floor level representation mechanism with information, consultation and veto-rights - depending on the extent of rights given in a Member State - and also at EU level through European Works Councils.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#WorksCouncil"></see></summary>
    let WorksCouncil =
        Namespaced_IRI.parse _namespace_name "WorksCouncil" |> NamespacedName

    /// <summary>
    /// number of employees of the acquiring company - at the moment of the transaction
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#acEmploymentFigureAtTransaction"></see></summary>
    let acEmploymentFigureAtTransaction =
        Namespaced_IRI.parse _namespace_name "acEmploymentFigureAtTransaction" |> NamespacedName

    /// <summary>
    /// The last available annual employment figure for the acquiring company
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#acLastEmploymentFigure"></see></summary>
    let acLastEmploymentFigure =
        Namespaced_IRI.parse _namespace_name "acLastEmploymentFigure" |> NamespacedName

    /// <summary>
    /// total number of employees of the acquiring company in the EU at the moment of the transaction
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#acTotalEUEmploymentFigure"></see></summary>
    let acTotalEUEmploymentFigure =
        Namespaced_IRI.parse _namespace_name "acTotalEUEmploymentFigure" |> NamespacedName

    /// <summary>
    /// The year the last annual employment figure was obtained for acquiring companies
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#acYearEmploymentFigure"></see></summary>
    let acYearEmploymentFigure =
        Namespaced_IRI.parse _namespace_name "acYearEmploymentFigure" |> NamespacedName

    /// <summary>
    /// Provides a human-readable written example of the entity in question.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#example"></see></summary>
    let example = Namespaced_IRI.parse _namespace_name "example" |> NamespacedName

    /// <summary>
    /// (cbcmObjectRelation ?ENTITY1 ?ENTITY2) means that the relation between ?ENTITY1 and ?ENTITY2 captures information pertaining to an object.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmObjectRelation"></see></summary>
    let cbcmObjectRelation =
        Namespaced_IRI.parse _namespace_name "cbcmObjectRelation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#austria"></see>
    /// </summary>
    let austria = Namespaced_IRI.parse _namespace_name "austria" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#iso2code"></see>
    /// </summary>
    let iso2code = Namespaced_IRI.parse _namespace_name "iso2code" |> NamespacedName
    /// <summary>
    /// (authors ?ENTITY1 ?ENTITY2) means that (authoredBy ?ENTITY2 ?ENTITY1)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#authors"></see></summary>
    let authors = Namespaced_IRI.parse _namespace_name "authors" |> NamespacedName

    /// <summary>
    /// (cbcmDocumentRelation ?ENTITY1 ?ENTITY2) means that the relation between ?ENTITY1 and ?ENTITY2 captures information pertaining to a company mobility document or similar information source relevant to corporate mobility.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmDocumentRelation"></see></summary>
    let cbcmDocumentRelation =
        Namespaced_IRI.parse _namespace_name "cbcmDocumentRelation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#belgium"></see>
    /// </summary>
    let belgium = Namespaced_IRI.parse _namespace_name "belgium" |> NamespacedName
    /// <summary>
    /// Is an employee board level representation/participation (BLER) mechanism applicable prior to the cross-border transaction?
    ///
    /// 0 = no BLER prior to cross-border transaction
    /// 1 = BLER existing prior to cross-border transaction
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#bler"></see></summary>
    let bler = Namespaced_IRI.parse _namespace_name "bler" |> NamespacedName

    /// <summary>
    /// What is the employee board level representation (BLER) ratio going to be after the completion of the transaction?
    ///
    /// The ratio is ranging from 0.00 (no BLER) to 0.33 (1/3 BLER) to 0.5 (50-50 Mitbestimmung) to (theoretically) 1.00, which would be 100% employee representatives on the board and no shareholder representatives.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#blerComposition"></see></summary>
    let blerComposition =
        Namespaced_IRI.parse _namespace_name "blerComposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#bulgaria"></see>
    /// </summary>
    let bulgaria = Namespaced_IRI.parse _namespace_name "bulgaria" |> NamespacedName

    /// <summary>
    /// (cbcmDataProvenanceRelation ?ENTITY1 ?ENTITY2) means that the relation between ?ENTITY1 and ?ENTITY2 captures provenance information for company transaction data.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmDataProvenanceRelation"></see></summary>
    let cbcmDataProvenanceRelation =
        Namespaced_IRI.parse _namespace_name "cbcmDataProvenanceRelation" |> NamespacedName

    /// <summary>
    /// (cbcmEntityRelation ?ENTITY1 ?ENTITY2) means that ?ENTITY1 is related to ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmEntityRelation"></see></summary>
    let cbcmEntityRelation =
        Namespaced_IRI.parse _namespace_name "cbcmEntityRelation" |> NamespacedName

    /// <summary>
    /// (cbcmOrganisationRelation ?ENTITY1 ?ENTITY2) means that the relation between ?ENTITY1 and ?ENTITY2 captures information pertaining to an organisation.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmOrganisationRelation"></see></summary>
    let cbcmOrganisationRelation =
        Namespaced_IRI.parse _namespace_name "cbcmOrganisationRelation" |> NamespacedName

    /// <summary>
    /// (cbcmTransactionRelation ?ENTITY1 ?ENTITY2) means that the relation between ?ENTITY1 and ?ENTITY2 captures information pertaining to a company mobility transaction.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmTransactionRelation"></see></summary>
    let cbcmTransactionRelation =
        Namespaced_IRI.parse _namespace_name "cbcmTransactionRelation" |> NamespacedName

    /// <summary>
    /// Are the companies involved in the transaction having an economic committee?
    ///
    /// An economic committee advises the work council about the financial parts of the transaction.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#companiesHaveEconomicCommittee"></see></summary>
    let companiesHaveEconomicCommittee =
        Namespaced_IRI.parse _namespace_name "companiesHaveEconomicCommittee" |> NamespacedName

    /// <summary>
    /// Are the companies involved in the transaction having employees? Only one company needs to have employees for this property to be true
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#companiesHaveEmployees"></see></summary>
    let companiesHaveEmployees =
        Namespaced_IRI.parse _namespace_name "companiesHaveEmployees" |> NamespacedName

    /// <summary>
    /// Are the companies involved in the transaction having a works council? Works councils safeguard employees' welfare
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#companiesHaveWorksCouncil"></see></summary>
    let companiesHaveWorksCouncil =
        Namespaced_IRI.parse _namespace_name "companiesHaveWorksCouncil" |> NamespacedName

    /// <summary>
    /// (companyFormCountry ?ENTITY1 ?ENTITY2) means that ?ENTITY1 is a company form recognized by the law of country ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#companyFormCountry"></see></summary>
    let companyFormCountry =
        Namespaced_IRI.parse _namespace_name "companyFormCountry" |> NamespacedName

    /// <summary>
    /// (countryHasCompanyForm ?ENTITY1 ?ENTITY2) means that ?ENTITY1 refers to a country the corporate law in that country permits and / or has occurrences of companies in that country which have the corporate legal structure (company legal form) referred to by ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#countryHasCompanyForm"></see></summary>
    let countryHasCompanyForm =
        Namespaced_IRI.parse _namespace_name "countryHasCompanyForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#croatia"></see>
    /// </summary>
    let croatia = Namespaced_IRI.parse _namespace_name "croatia" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#cyprus"></see>
    /// </summary>
    let cyprus = Namespaced_IRI.parse _namespace_name "cyprus" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#czechia"></see>
    /// </summary>
    let czechia = Namespaced_IRI.parse _namespace_name "czechia" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#denmark"></see>
    /// </summary>
    let denmark = Namespaced_IRI.parse _namespace_name "denmark" |> NamespacedName

    /// <summary>
    /// If a different employee number for the acquiring company is found, it is recorded in this field
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#divergingEmploymentFigure"></see></summary>
    let divergingEmploymentFigure =
        Namespaced_IRI.parse _namespace_name "divergingEmploymentFigure" |> NamespacedName

    /// <summary>
    /// (documentValidatedByDocument ?ENTITY1 ?ENTITY2) means that some document or publication, ?ENTITY1, went through a process of approval and assessment through various criteria such as veracity, eligibility, legal relevance etc. and another document ?ENTITY2 was produced to prove the satisfaction of the critieria by ?ENTITY1.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#documentValidatedByDocument"></see></summary>
    let documentValidatedByDocument =
        Namespaced_IRI.parse _namespace_name "documentValidatedByDocument" |> NamespacedName

    /// <summary>
    /// (hasCompanyStakeholder ?ENTITY1 ?ENTITY2) means that some entity ?ENTITY1, which is either a significant process or agent has another agent ?ENTITY2 with personal interests in benefiting either financially or otherwise from the outcomes of ?ENTITY1 (if it is an event or process), or in its byproducts and profits (if it is an agent).
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasCompanyStakeholder"></see></summary>
    let hasCompanyStakeholder =
        Namespaced_IRI.parse _namespace_name "hasCompanyStakeholder" |> NamespacedName

    /// <summary>
    /// (employs ?ENTITY1 ?ENTITY2) means (employedBy ?ENTITY2 ?ENTITY1)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#employs"></see></summary>
    let employs = Namespaced_IRI.parse _namespace_name "employs" |> NamespacedName

    /// <summary>
    /// The date and time a process ended
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#endedAtTime"></see></summary>
    let endedAtTime =
        Namespaced_IRI.parse _namespace_name "endedAtTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#estonia"></see>
    /// </summary>
    let estonia = Namespaced_IRI.parse _namespace_name "estonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#euOfficialJournal"></see>
    /// </summary>
    let euOfficialJournal =
        Namespaced_IRI.parse _namespace_name "euOfficialJournal" |> NamespacedName

    /// <summary>
    /// Is the company having a European Works Council (EWC)?
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ewc"></see></summary>
    let ewc = Namespaced_IRI.parse _namespace_name "ewc" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#finland"></see>
    /// </summary>
    let finland = Namespaced_IRI.parse _namespace_name "finland" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#france"></see>
    /// </summary>
    let france = Namespaced_IRI.parse _namespace_name "france" |> NamespacedName
    /// <summary>
    /// Generation is the completion of production of a new entity by a process. This entity did not exist before generation and becomes available for usage after this generation.
    ///
    /// Based (inverse of) on: https://www.w3.org/TR/prov-o/#wasGeneratedBy
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#generated"></see></summary>
    let generated = Namespaced_IRI.parse _namespace_name "generated" |> NamespacedName

    /// <summary>
    /// Generation is the completion of production of a new entity by a process. This entity did not exist before generation and becomes available for usage after this generation.
    ///
    /// Based on: https://www.w3.org/TR/prov-o/#wasGeneratedBy
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#wasGeneratedBy"></see></summary>
    let wasGeneratedBy =
        Namespaced_IRI.parse _namespace_name "wasGeneratedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#germany"></see>
    /// </summary>
    let germany = Namespaced_IRI.parse _namespace_name "germany" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#greece"></see>
    /// </summary>
    let greece = Namespaced_IRI.parse _namespace_name "greece" |> NamespacedName

    /// <summary>
    /// Company legal form. Name given to describe the structure of a corporation or buiness in the different legal orders. For example Limited (Ltd.), Public Limited Company (PLC), Gesellschaft mit beschränkter Haftung (GmbH), Aktiengesellschaft (AG). The company legal form is regulated under national law and grants specific rights and obligations to the company stakeholders (such as shareholders, management &amp; employees).
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasCompanyForm"></see></summary>
    let hasCompanyForm =
        Namespaced_IRI.parse _namespace_name "hasCompanyForm" |> NamespacedName

    /// <summary>
    /// In which document did the researcher find information about the transaction?
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasDataProvenanceDocumentSource"></see></summary>
    let hasDataProvenanceDocumentSource =
        Namespaced_IRI.parse _namespace_name "hasDataProvenanceDocumentSource" |> NamespacedName

    /// <summary>
    /// In which countries' registry did the researcher find information about the transaction?
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasDataProvenanceRegistryCountry"></see></summary>
    let hasDataProvenanceRegistryCountry =
        Namespaced_IRI.parse _namespace_name "hasDataProvenanceRegistryCountry" |> NamespacedName

    /// <summary>
    /// (hasOriginalCompany ?ENTITY1 ?ENTITY2) means that some company division transaction ?ENTITY1 involves a company ?ENTITY2 which will be divided (or "split") into multiple recipient or emerging companies.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasOriginalCompany"></see></summary>
    let hasOriginalCompany =
        Namespaced_IRI.parse _namespace_name "hasOriginalCompany" |> NamespacedName

    /// <summary>
    /// (?ENTITY1 hasPostCompanyForm ?ENTITY2) indicates the new company form of a company undergoing a cross border conversion or a national conversion.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasPostCompanyForm"></see></summary>
    let hasPostCompanyForm =
        Namespaced_IRI.parse _namespace_name "hasPostCompanyForm" |> NamespacedName

    /// <summary>
    /// Primary country of registration (location) of a company as a full country name
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasPrimaryRegistrationLocation"></see></summary>
    let hasPrimaryRegistrationLocation =
        Namespaced_IRI.parse _namespace_name "hasPrimaryRegistrationLocation" |> NamespacedName

    /// <summary>
    /// (?ENTITY1 hasPriorCompanyForm ?ENTITY2) indicates the original company form of a company undergoing a cross border conversion or a national conversion.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasPriorCompanyForm"></see></summary>
    let hasPriorCompanyForm =
        Namespaced_IRI.parse _namespace_name "hasPriorCompanyForm" |> NamespacedName

    /// <summary>
    /// Country of secondary registration (location) of a company
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasSecondaryRegistrationLocation"></see></summary>
    let hasSecondaryRegistrationLocation =
        Namespaced_IRI.parse _namespace_name "hasSecondaryRegistrationLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hungary"></see>
    /// </summary>
    let hungary = Namespaced_IRI.parse _namespace_name "hungary" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#iceland"></see>
    /// </summary>
    let iceland = Namespaced_IRI.parse _namespace_name "iceland" |> NamespacedName

    /// <summary>
    /// Is the impact on employees of the envisaged transaction specified in the transaction document (e.g. the merger plan)?
    ///
    /// Part of merger plan that specifies how the transaction will affect employees.
    ///
    /// - Yes: there is an impact on employees (positive or negative);
    /// - No: no impact on employees;
    /// - Not applicable: the conditions are not met (e.g. no employees, BLER threshold not met) for this criterion to be applicable;
    /// - Unclear: the wording of the document is unclear with regard to the impact/effect/measures taken;
    /// - Not mentioned: given the parameters, this aspect should be addressed in the transaction document, but is not mentioned
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#impactOnEmployees"></see></summary>
    let impactOnEmployees =
        Namespaced_IRI.parse _namespace_name "impactOnEmployees" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ireland"></see>
    /// </summary>
    let ireland = Namespaced_IRI.parse _namespace_name "ireland" |> NamespacedName
    /// <summary>
    /// Whether the company is publicly listed. A company whose shares are bought and sold on a particular stock market.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#isListed"></see></summary>
    let isListed = Namespaced_IRI.parse _namespace_name "isListed" |> NamespacedName

    /// <summary>
    /// Variable indicating whether this case concerns an SE-creation (yes/no) to distinguish creations of SEs from other transactions
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#isSECreation"></see></summary>
    let isSECreation =
        Namespaced_IRI.parse _namespace_name "isSECreation" |> NamespacedName

    /// <summary>
    /// (issuedByOrganisation ?ENTITY1 ?ENTITY2) means that some document or publication, ?ENTITY1, was created (and possibly delivered or administered to another entity) by some entity ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#issuedByOrganisation"></see></summary>
    let issuedByOrganisation =
        Namespaced_IRI.parse _namespace_name "issuedByOrganisation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#italy"></see>
    /// </summary>
    let italy = Namespaced_IRI.parse _namespace_name "italy" |> NamespacedName

    /// <summary>
    /// Last available employment figure for the total worldwide employees
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#lastWWEmploymentFigure"></see></summary>
    let lastWWEmploymentFigure =
        Namespaced_IRI.parse _namespace_name "lastWWEmploymentFigure" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#latvia"></see>
    /// </summary>
    let latvia = Namespaced_IRI.parse _namespace_name "latvia" |> NamespacedName
    /// <summary>
    /// Name of the lawfirm involved in the transaction, if available (for internal use; cross-border divisions and seat transfers are currently not possible within an EU legal framework.)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#lawfirm"></see></summary>
    let lawfirm = Namespaced_IRI.parse _namespace_name "lawfirm" |> NamespacedName

    /// <summary>
    /// The acronym of a company legal form
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#legalFormAcronym"></see></summary>
    let legalFormAcronym =
        Namespaced_IRI.parse _namespace_name "legalFormAcronym" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#liechtenstein"></see>
    /// </summary>
    let liechtenstein =
        Namespaced_IRI.parse _namespace_name "liechtenstein" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#lithuania"></see>
    /// </summary>
    let lithuania = Namespaced_IRI.parse _namespace_name "lithuania" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#luxembourg"></see>
    /// </summary>
    let luxembourg = Namespaced_IRI.parse _namespace_name "luxembourg" |> NamespacedName
    /// <summary>
    /// (maintains ?ENTITY1 ?ENTITY2) means (maintainedBy ?ENTITY2 ?ENTITY1)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#maintains"></see></summary>
    let maintains = Namespaced_IRI.parse _namespace_name "maintains" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#malta"></see>
    /// </summary>
    let malta = Namespaced_IRI.parse _namespace_name "malta" |> NamespacedName

    /// <summary>
    /// Number of employees of the acquiring company - at the moment of the transaction
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#mcEmploymentFigureAtTransaction"></see></summary>
    let mcEmploymentFigureAtTransaction =
        Namespaced_IRI.parse _namespace_name "mcEmploymentFigureAtTransaction" |> NamespacedName

    /// <summary>
    /// The last available annual employment figure for the merging company
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#mcLastEmploymentFigure"></see></summary>
    let mcLastEmploymentFigure =
        Namespaced_IRI.parse _namespace_name "mcLastEmploymentFigure" |> NamespacedName

    /// <summary>
    /// The year the last annual employment figure was obtained for merging companies
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#mcYearEmploymentFigure"></see></summary>
    let mcYearEmploymentFigure =
        Namespaced_IRI.parse _namespace_name "mcYearEmploymentFigure" |> NamespacedName

    /// <summary>
    /// A transaction whereby more than two companies (i.e. multiple merging companies) are involved and merged into one acquiring company
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#multiCBM"></see></summary>
    let multiCBM = Namespaced_IRI.parse _namespace_name "multiCBM" |> NamespacedName
    /// <summary>
    /// NACE Classification Code for companies. NACE (Nomenclature des Activités Économiques dans la Communauté Européenne) is a European industry standard classification system similar in function to Standard Industry Classification (SIC) and North American Industry Classification System (NAICS) for classifying business activities. From EUROSTAT
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#naceCode"></see></summary>
    let naceCode = Namespaced_IRI.parse _namespace_name "naceCode" |> NamespacedName
    /// <summary>
    /// Company NACE sector. NACE (Nomenclature of Economic Activities) is the European statistical classification of economic activities. Classification of a company according to which kinds of sector (i.e. industry / market / product type) they deal in. From EUROSTAT
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#naceSector"></see></summary>
    let naceSector = Namespaced_IRI.parse _namespace_name "naceSector" |> NamespacedName
    /// <summary>
    /// The name of the organization
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    /// The national registration number of an acquiring/receiving/entry company. A company registration number is a unique combination of numbers and/or letters. It is used to identify a company and verify its legal existence as an incorporated entity.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#natRegistrationNumber"></see></summary>
    let natRegistrationNumber =
        Namespaced_IRI.parse _namespace_name "natRegistrationNumber" |> NamespacedName

    /// <summary>
    /// Is the management of the companies involved starting the process of setting up a Special Negotiating Body (SNB) in order to reach a negotiated agreement on the future employee participation mechanism (BLER) after the transaction?
    ///
    /// BLER (Board-Level Employee Represenation): highest level of employee involvement in a company in the supervisory board. They can take co-determine decisions of the company's management and where the company is heading.
    ///
    /// - Yes: there is a negotiated agreement to be negotiated with the SNB;
    /// - No: no negotiated agreement;
    /// - Not applicable: the conditions are not met (e.g. no employees, BLER threshold not met) for this criterion to be applicable;
    /// - Unclear: the wording of the document is unclear with regard to the impact/effect/measures taken;
    /// - Not mentioned: given the parameters, this aspect should be addressed in the transaction document, but is not mentioned
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#negotiatedAgreement"></see></summary>
    let negotiatedAgreement =
        Namespaced_IRI.parse _namespace_name "negotiatedAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#netherlands"></see>
    /// </summary>
    let netherlands =
        Namespaced_IRI.parse _namespace_name "netherlands" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#norway"></see>
    /// </summary>
    let norway = Namespaced_IRI.parse _namespace_name "norway" |> NamespacedName
    /// <summary>
    /// (ownedBy ?ENTITY1 ?ENTITY2) means that some agent ?ENTITY2 has proprietorship over another object or organisational agent ?ENTITY1.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ownedBy"></see></summary>
    let ownedBy = Namespaced_IRI.parse _namespace_name "ownedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#poland"></see>
    /// </summary>
    let poland = Namespaced_IRI.parse _namespace_name "poland" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#portugal"></see>
    /// </summary>
    let portugal = Namespaced_IRI.parse _namespace_name "portugal" |> NamespacedName

    /// <summary>
    /// unique identifier before database entry.
    ///
    /// This id is the old ID-structure used before entry into the CbCMdb
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#rawTransactionID"></see></summary>
    let rawTransactionID =
        Namespaced_IRI.parse _namespace_name "rawTransactionID" |> NamespacedName

    /// <summary>
    /// Deprecated property
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#registeredOffice"></see></summary>
    let registeredOffice =
        Namespaced_IRI.parse _namespace_name "registeredOffice" |> NamespacedName

    /// <summary>
    /// Specifies a phrase to indicate the degree to which the providing of a value for the entity (e.g. a data or object property) in question is compulsory, recommended or optional.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#requirement-level"></see></summary>
    let ``requirement-level`` =
        Namespaced_IRI.parse _namespace_name "requirement-level" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#romania"></see>
    /// </summary>
    let romania = Namespaced_IRI.parse _namespace_name "romania" |> NamespacedName

    /// <summary>
    /// Is a Special Negotiating Body (SNB) set up voluntary?
    ///
    /// Whether or not a SNB is created/will be created voluntarily.
    ///
    /// - Yes: an SNB is created voluntarily;
    /// - No: no voluntary SNB set up;
    /// - Not applicable: the conditions are not met (e.g. no employees, BLER threshold not met) for this criterion to be applicable;
    /// - Unclear: the wording of the document is unclear with regard to the impact/effect/measures taken;
    /// - Not mentioned: given the parameters, this aspect should be addressed in the transaction document, but is not mentioned
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#sbnVoluntaryApplication"></see></summary>
    let sbnVoluntaryApplication =
        Namespaced_IRI.parse _namespace_name "sbnVoluntaryApplication" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#se_conversion"></see>
    /// </summary>
    let se_conversion =
        Namespaced_IRI.parse _namespace_name "se_conversion" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#se_holding"></see>
    /// </summary>
    let se_holding = Namespaced_IRI.parse _namespace_name "se_holding" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#se_merger"></see>
    /// </summary>
    let se_merger = Namespaced_IRI.parse _namespace_name "se_merger" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#se_subsidiary"></see>
    /// </summary>
    let se_subsidiary =
        Namespaced_IRI.parse _namespace_name "se_subsidiary" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#se_unsure"></see>
    /// </summary>
    let se_unsure = Namespaced_IRI.parse _namespace_name "se_unsure" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#slovakia"></see>
    /// </summary>
    let slovakia = Namespaced_IRI.parse _namespace_name "slovakia" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#slovenia"></see>
    /// </summary>
    let slovenia = Namespaced_IRI.parse _namespace_name "slovenia" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#spain"></see>
    /// </summary>
    let spain = Namespaced_IRI.parse _namespace_name "spain" |> NamespacedName

    /// <summary>
    /// Are the standard rules applied directly without and instead of the start of negotiations with a Special Negotiating Body (SNB)?
    ///
    /// Instead of an SNB being set up, the standard rules are applied instead.
    ///
    /// - Yes: the standard rules are applied;
    /// - No: standard rules ar enot applied;
    /// - Not applicable: the conditions are not met (e.g. no employees, BLER threshold not met) for this criterion to be applicable;
    /// - Unclear: the wording of the document is unclear with regard to the impact/effect/measures taken;
    /// - Not mentioned: given the parameters, this aspect should be addressed in the transaction document, but is not mentioned
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#standardRulesApplication"></see></summary>
    let standardRulesApplication =
        Namespaced_IRI.parse _namespace_name "standardRulesApplication" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#sweden"></see>
    /// </summary>
    let sweden = Namespaced_IRI.parse _namespace_name "sweden" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#switzerland"></see>
    /// </summary>
    let switzerland =
        Namespaced_IRI.parse _namespace_name "switzerland" |> NamespacedName

    /// <summary>
    /// Is the company having a transnational information and consultation agreement in place? Does the company have an internal body which discusses employee rights and welfare?
    ///
    /// Different from works council. TNIC is global.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#tnic"></see></summary>
    let tnic = Namespaced_IRI.parse _namespace_name "tnic" |> NamespacedName

    /// <summary>
    /// Is an employee board level representation/participation (BLER) mechanism going to be re-negotiated in the process of the cross-border transaction?
    ///
    /// - Yes: BLER be (re-)negotiated with the SNB;
    /// - No: no BLER-(re-)negotiation;
    /// - Not applicable: the conditions are not met (e.g. no employees, BLER threshold not met) for this criterion to be applicable;
    /// - Unclear: the wording of the document is unclear with regard to the impact/effect/measures taken;
    /// - Not mentioned: given the parameters, this aspect should be addressed in the transaction document, but is not mentioned
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#toBeNegotiatedBLER"></see></summary>
    let toBeNegotiatedBLER =
        Namespaced_IRI.parse _namespace_name "toBeNegotiatedBLER" |> NamespacedName

    /// <summary>
    /// Notes from researcher about the transaction
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionComment"></see></summary>
    let transactionComment =
        Namespaced_IRI.parse _namespace_name "transactionComment" |> NamespacedName

    /// <summary>
    /// Date on which the transaction was effectuated (the date that the competent authority e.g., business registry of that country, says that the criteria have been met by merging and acquiring companies and the merging/transferring company is dissolved).
    ///
    /// This is the final step of a transaction process
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionCompletionDate"></see></summary>
    let transactionCompletionDate =
        Namespaced_IRI.parse _namespace_name "transactionCompletionDate" |> NamespacedName

    /// <summary>
    /// unique identifier for a transaction
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionID"></see></summary>
    let transactionID =
        Namespaced_IRI.parse _namespace_name "transactionID" |> NamespacedName

    /// <summary>
    /// Is the transaction plan available for analysis?
    ///
    /// Merger plan, Seat transfer plan or Division plan. Transaction notice is where the transaction is announced. The other documents are where the nature and details of the transaction are specified.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionPlan"></see></summary>
    let transactionPlan =
        Namespaced_IRI.parse _namespace_name "transactionPlan" |> NamespacedName

    /// <summary>
    /// Date of the transaction notice (document announcing the transaction) constituting the start of the transaction process. Date that the document was published (which is the important date because this is when it becomes legally binding)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionStartDate"></see></summary>
    let transactionStartDate =
        Namespaced_IRI.parse _namespace_name "transactionStartDate" |> NamespacedName

    /// <summary>
    /// Variable indicating the SE-establishment mode: by merger, conversion, holding-SE, subsidiary-SE or unsure
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#typeOfSE"></see></summary>
    let typeOfSE = Namespaced_IRI.parse _namespace_name "typeOfSE" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#unitedkingdom"></see>
    /// </summary>
    let unitedkingdom =
        Namespaced_IRI.parse _namespace_name "unitedkingdom" |> NamespacedName

    /// <summary>
    /// In which document did the researcher find information about the transaction?
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#usedDataProvenanceDocumentSource"></see></summary>
    let usedDataProvenanceDocumentSource =
        Namespaced_IRI.parse _namespace_name "usedDataProvenanceDocumentSource" |> NamespacedName

    /// <summary>
    /// In which countries' registry did the researcher find information about the transaction?
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#usedDataProvenanceRegistryCountry"></see></summary>
    let usedDataProvenanceRegistryCountry =
        Namespaced_IRI.parse _namespace_name "usedDataProvenanceRegistryCountry" |> NamespacedName

    /// <summary>
    /// Homepage of a company/organization website
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#website"></see></summary>
    let website = Namespaced_IRI.parse _namespace_name "website" |> NamespacedName

    /// <summary>
    /// number of employees of company group worldwide at the moment of the transaction
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#wwEmploymentFigureAtTransaction"></see></summary>
    let wwEmploymentFigureAtTransaction =
        Namespaced_IRI.parse _namespace_name "wwEmploymentFigureAtTransaction" |> NamespacedName

    /// <summary>
    /// The year for which a diverging employee number is recorded
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#yearDivergingEmploymentFigure"></see></summary>
    let yearDivergingEmploymentFigure =
        Namespaced_IRI.parse _namespace_name "yearDivergingEmploymentFigure" |> NamespacedName

    /// <summary>
    /// Year in which the last worldwide employment figure was recorded
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#yearWWEmploymentFigure"></see></summary>
    let yearWWEmploymentFigure =
        Namespaced_IRI.parse _namespace_name "yearWWEmploymentFigure" |> NamespacedName
