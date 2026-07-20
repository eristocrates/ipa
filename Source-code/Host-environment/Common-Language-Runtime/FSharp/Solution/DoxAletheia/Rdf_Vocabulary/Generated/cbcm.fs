namespace http.w3id.org.um.cbcm.eu_cm_ontology.hash

open DoxAletheia

module cbcm =
    let _namespace_name = "http://w3id.org/um/cbcm/eu-cm-ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A legal document which provides information related to, or influencing, a company's mobility within a specific country or across national boundaries.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyMobilityDocument"></see></summary>
    let CompanyMobilityDocument = _prefix "CompanyMobilityDocument"
    /// <summary>
    /// A digital document repository containing documents related to company mobility.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DocumentRepository"></see></summary>
    let DocumentRepository = _prefix "DocumentRepository"
    /// <summary>
    /// A legal right of a legal entity involved in the process of a company transaction. A legal right here refers to the entitlement of a person to be allowed to perform an activity, or to possess or obtain access to an object.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#TransactionRight"></see></summary>
    let TransactionRight = _prefix "TransactionRight"
    /// <summary>
    /// A city (plural "cities") is a geo-political region in which there is a large human settlement. The distinction with the term "town" (plural "towns") is that cities are generally larger than towns. Countries are generally larger than cities and, in fact, usually consist of multiple cities.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#City"></see></summary>
    let City = _prefix "City"
    /// <summary>
    /// The physical address or location at which the primary business activities of a company are carried out.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyRegisteredOffice"></see></summary>
    let CompanyRegisteredOffice = _prefix "CompanyRegisteredOffice"
    /// <summary>
    /// A geo-political region that has a distinct and common political governance structure for people that inhabit it for a significant portion of their lives. The majority of people that inhabit such a region are also usually united by common descent, history, culture and language.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Country"></see></summary>
    let Country = _prefix "Country"
    /// <summary>
    /// Acquiring Company means the resulting or surviving company in a transaction that takes over another, merging company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#AcquiringCompany"></see></summary>
    let AcquiringCompany = _prefix "AcquiringCompany"
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
    let CompanyMerger = _prefix "CompanyMerger"
    /// <summary>
    /// (isTransactionResultOf ?ENTITY1 ?ENTITY2) means (hasTransactionResult ?ENTITY2 ?ENTITY1)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#isTransactionResultOf"></see></summary>
    let isTransactionResultOf = _prefix "isTransactionResultOf"
    /// <summary>
    /// A company is a legal entity formed by a group of individuals to engage in and operate a business—commercial or industrial—enterprise. A company may be organized in various ways for tax and financial liability purposes depending on the corporate law of its jurisdiction.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Company"></see></summary>
    let Company = _prefix "Company"
    /// <summary>
    /// An entity or group of entities (either biological or non-biological) that is able to perform actions autonomously in the world.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// Annual reports measure a company's financial health. They focus on past and present financial performance, and make predictions about future prospects. The revenue and financial performance of a company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#AnnualAccount"></see></summary>
    let AnnualAccount = _prefix "AnnualAccount"
    /// <summary>
    /// Annual reports measure a company's financial health. They focus on past and present financial performance, and make predictions about future prospects. The revenue and financial performance of a company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#AnnualReport"></see></summary>
    let AnnualReport = _prefix "AnnualReport"
    /// <summary>
    /// An attribute is a characteristic of some entity.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Attribute"></see></summary>
    let Attribute = _prefix "Attribute"
    /// <summary>
    /// Behaviour is the set of actions and mannerisms made by systems (biological or otherwise) in response to stimuli or inputs, whether internal or external, conscious or subconscious, overt or covert, and voluntary or involuntary.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Behaviour"></see></summary>
    let Behaviour = _prefix "Behaviour"
    /// <summary>
    /// A procedure is a process that attempts to achieve one or more objectives by following an established set of actions.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Procedure"></see></summary>
    let Procedure = _prefix "Procedure"

    /// <summary>
    /// Board-level representation of employees (BLER) refers to the phenomenon where employees or their representatives elect or appoint representatives to the strategic decision-making body of a company (i.e. the supervisory board or non-executive board in a one-tier system). The BLER right requires that if such a system of BLER exists prior to a cross-border company transaction, such a right must be upheld in the acquiring/recipient company under the "before-and-after-principle".
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#BoardLevelEmployeeRepresentationRight"></see></summary>
    let BoardLevelEmployeeRepresentationRight =
        _prefix "BoardLevelEmployeeRepresentationRight"

    /// <summary>
    /// Social rights, as opposed to rights arising from natural law, are rights for legal entities that entitle them to certain levels of societal living conditions (e.g. the right to housing, to food, to health care etc.)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#SocialRight"></see></summary>
    let SocialRight = _prefix "SocialRight"
    /// <summary>
    /// A Board Resolution, or Company Resolution, is a way of documenting a decision made by a Company's Board of Directors on behalf of the company. After the resolution is made during a meeting, a Board Resolution document is typically used to get the specifics of the resolution in writing.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#BoardResolution"></see></summary>
    let BoardResolution = _prefix "BoardResolution"
    /// <summary>
    /// A document detailing a decision made by an individual or group of natural or legal persons. This can be a decision concerning the restructuring of a company by its shareholders.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Resolution"></see></summary>
    let Resolution = _prefix "Resolution"
    /// <summary>
    /// A person that is interested in research about cross-border company mobility, and actively collects and analyses data concerning cross-border company mobility.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CBCMResearcher"></see></summary>
    let CBCMResearcher = _prefix "CBCMResearcher"
    /// <summary>
    /// A person is an object that has certain capacities or attributes constituting personhood. A human being that has existed or continues to exist in the world (either deceased or living). Fictional human beings cannot be  instances of this class.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// (locatedIn ?ENTITY1 ?ENTITY2) means that some entity ?ENTITY1 occupies the spatial region referred to by ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#locatedIn"></see></summary>
    let locatedIn = _prefix "locatedIn"
    /// <summary>
    /// A spatial region on earth whose boundaries are determined by a combination of geographical, ecological, climatic, socio-economic and political criteria.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#GeoPoliticalRegion"></see></summary>
    let GeoPoliticalRegion = _prefix "GeoPoliticalRegion"
    /// <summary>
    /// The workforce of a company. An employee is a party to an employment relationship characterised as a contract of employment (or contract of service) between the employer and employee. However, this is only one of several different legal formulations of the concept of ‘worker’ in the EU which differ between Member States.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Employee"></see></summary>
    let Employee = _prefix "Employee"
    /// <summary>
    /// (hasMember ?ENTITY1 ?ENTITY2) means that some agent ?ENTITY1 (usually an organisation) has a person ?ENTITY2 that participates in its activities. This need not represent an employment role nor imply financial incentives between the organisation and person.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasMember"></see></summary>
    let hasMember = _prefix "hasMember"
    /// <summary>
    /// (hasPart ?ENTITY1 ?ENTITY2) means that the entity referred to by ?ENTITY1 has a constituent entity referred to by ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasPart"></see></summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    /// The headquarters or body of a company which governs it's financial and administrative activities
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyCentralAdministration"></see></summary>
    let CompanyCentralAdministration = _prefix "CompanyCentralAdministration"
    /// <summary>
    /// Represents a collection of people organized together into a community or other social, commercial or political structure. The group has some common purpose or reason for existence which goes beyond the set of people belonging to it and can act as an Agent. Organizations are often decomposable into hierarchical structures.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Organisation"></see></summary>
    let Organisation = _prefix "Organisation"
    /// <summary>
    /// A division of a large organization such as a government, university, or business, dealing with a specific area of activity.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#OrganisationalUnit"></see></summary>
    let OrganisationalUnit = _prefix "OrganisationalUnit"
    /// <summary>
    /// The location of a company headquarter
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyHeadQuarter"></see></summary>
    let CompanyHeadQuarter = _prefix "CompanyHeadQuarter"
    /// <summary>
    /// The process of changing or converting the corporate structure of a company. For example, a limited liability company of one country to one of another country, or from a private to a public limited liability company, or vice-versa by means of the continuance of an entity into another entity.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyConversion"></see></summary>
    let CompanyConversion = _prefix "CompanyConversion"
    /// <summary>
    /// A document providing details of how the conversion of a company will be implemented. Article 86d: The management or administrative organ of the company shall draw up the draft terms of a cross-border conversion. The draft terms of a cross-border conversion shall include at least the particulars listed in article 86d
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ConversionPlan"></see></summary>
    let ConversionPlan = _prefix "ConversionPlan"
    /// <summary>
    /// (requiresDocument ?ENTITY1 ?ENTITY2) means that some significant event or process ?ENTITY1 needs a compulsory document ?ENTITY2 to be submitted and reviewed before the process ?ENTITY1 can be completed.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#requiresDocument"></see></summary>
    let requiresDocument = _prefix "requiresDocument"
    /// <summary>
    /// (sourceCountry ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 has some transaction input (a company) whose place of business is located in the country ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#sourceCountry"></see></summary>
    let sourceCountry = _prefix "sourceCountry"
    /// <summary>
    /// (targetCountry ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 has some transaction result (a company) whose place of business is located in the country ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#targetCountry"></see></summary>
    let targetCountry = _prefix "targetCountry"
    /// <summary>
    /// An action taken by a company that modifies its corporate structure with a change of control (for e.g. through either a merger, division, conversion or seat transfer in a domestic or cross-border setting). It involves one or more companies, each of which have a company legal form valid in a Member State of the European Union.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyTransaction"></see></summary>
    let CompanyTransaction = _prefix "CompanyTransaction"
    /// <summary>
    /// (hasTransactionInput ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 has a prerequisite entity ?ENTITY2 that needs to be considered, assessed, or modified during the transaction referred to by ?ENTITY1.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasTransactionInput"></see></summary>
    let hasTransactionInput = _prefix "hasTransactionInput"
    /// <summary>
    /// (hasTransactionResult ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 has a byproduct ?ENTITY2 (e.g. a company, transaction certificate etc.) after completion of the process.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasTransactionResult"></see></summary>
    let hasTransactionResult = _prefix "hasTransactionResult"
    /// <summary>
    /// (involvesChangeOf ?ENTITY1 ?ENTITY2) means that the process ?ENTITY1 requires the modification or alteration of the entity or object ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#involvesChangeOf"></see></summary>
    let involvesChangeOf = _prefix "involvesChangeOf"
    /// <summary>
    /// Name given to describe the structure of a corporation or business in the different legal orders. For example Limited (Ltd.), Public Limited Company (PLC), Gesellschaft mit beschränkter Haftung (GmbH), Aktiengesellschaft (AG). The company legal form is regulated under national law and grants specific rights and obligations to the company stakeholders (such as shareholders, management &amp; employees).
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyLegalForm"></see></summary>
    let CompanyLegalForm = _prefix "CompanyLegalForm"
    /// <summary>
    /// Article 160b - Division means:
    /// a) company being divided, on being dissolved without going into liquidation, transfers all its assets and liabilities to two or more newly formed companies (‘the recipient companies’), in exchange for the issue to the members of the company being divided of securities or shares in the recipient companies and, if any, a cash payment not exceeding 10 % of the nominal value of those securities or shares or, where they have no nominal value, a cash payment not exceeding 10% of the accounting par value of their securities or shares ('full division');
    ///
    /// (b) 	a company being divided transfers part of its assets and liabilities to one or more newly formed companies (‘the recipient companies’), in exchange for the issue to the members of the company being divided of securities or shares in the recipient companies or in the company being divided or in both the recipient companies and in the company being divided, and if any a cash payment not exceeding 10 % of the nominal value of those securities or shares, or in the absence of a nominal value, a cash payment not exceeding 10 % of the accounting par value of their securities or shares (‘partial division’).
    ///
    /// (c) 	a company being divided transfers part of its assets and liabilities to one or more newly formed companies (‘the recipient companies’), in exchange for the issue of securities or shares in the recipient companies to the company being divided (‘division by separation’).
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyDivision"></see></summary>
    let CompanyDivision = _prefix "CompanyDivision"
    /// <summary>
    /// (hasRecipientCompany ?ENTITY1 ?ENTITY2) means that some company division transaction ?ENTITY1 produces two or more distinct companies, one of which is ?ENTITY2 (a so-called "recipient company").
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasRecipientCompany"></see></summary>
    let hasRecipientCompany = _prefix "hasRecipientCompany"
    /// <summary>
    /// The management or administrative organ of the company shall draw up the draft terms of a division. The draft terms of a division shall include at least the particulars listed in article 160d.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DivisionPlan"></see></summary>
    let DivisionPlan = _prefix "DivisionPlan"
    /// <summary>
    /// Article 91: The administrative or management bodies of the merging companies shall draw up draft terms of merger in writing by specifying at least the elements mentioned in article 91.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#MergerPlan"></see></summary>
    let MergerPlan = _prefix "MergerPlan"
    /// <summary>
    /// The act of changing the location where the company’s business was managed (registered office or headquarters) or the place where that company’s primary business was actually conducted (central administration).
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanySeatTransfer"></see></summary>
    let CompanySeatTransfer = _prefix "CompanySeatTransfer"
    /// <summary>
    /// The management or administrative organ of the company draws up the draft terms of a cross-border seat transfer. The draft terms of a cross-border seat transfer must include at least the particulars specified under national law.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#SeatTransferPlan"></see></summary>
    let SeatTransferPlan = _prefix "SeatTransferPlan"
    /// <summary>
    /// (hasSubProcedure ?ENTITY1 ?ENTITY2) means that some process ?ENTITY1 contains another (shorter) process ?ENTITY2 that should be completed before ?ENTITY1 can complete.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasSubProcedure"></see></summary>
    let hasSubProcedure = _prefix "hasSubProcedure"
    /// <summary>
    /// Act of modifying the location where the company’s business was managed or the place where that company’s business was actually conducted.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#TransferOfCentralAdministration"></see></summary>
    let TransferOfCentralAdministration = _prefix "TransferOfCentralAdministration"
    /// <summary>
    /// The act of changing the registered office, which is the official address of an incorporated company, association or any other legal entity.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#TransferOfRegisteredOffice"></see></summary>
    let TransferOfRegisteredOffice = _prefix "TransferOfRegisteredOffice"
    /// <summary>
    /// An individual, group, or organization that owns one or more shares in a company, and in whose name the share certificate is issued.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyShareholder"></see></summary>
    let CompanyShareholder = _prefix "CompanyShareholder"
    /// <summary>
    /// (partOf ?ENTITY1 ?ENTITY2) means (hasPart ?ENTITY2 ?ENTITY1)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#partOf"></see></summary>
    let partOf = _prefix "partOf"
    /// <summary>
    /// A person, group or organization that has interest or concern in an organization or company in particular. Stakeholders can affect or be affected by the company's actions, objectives and policies.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyStakeholder"></see></summary>
    let CompanyStakeholder = _prefix "CompanyStakeholder"
    /// <summary>
    /// A written notice, published in an official journal of a Member State of the EU and/or the European Official Journal indicating the intention to engage in a transaction and which informs  the members, creditors and representatives of the employees of the company, or, where there are no such representatives, the employees themselves of said transaction.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#TransactionNotice"></see></summary>
    let TransactionNotice = _prefix "TransactionNotice"
    /// <summary>
    /// (reportedIn ?ENTITY1 ?ENTITY2) means that some significant event, process or statement ?ENTITY1 is published or mentioned or declared in writing in some publication, document or database ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#reportedIn"></see></summary>
    let reportedIn = _prefix "reportedIn"
    /// <summary>
    /// A document issued by a Competent Authority declaring that certain steps of the transaction are completed.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#TransactionCertificate"></see></summary>
    let TransactionCertificate = _prefix "TransactionCertificate"
    /// <summary>
    /// (transactionValidatedByDocument ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 went through a process of approval and assessment through various criteria such as veracity, eligibility, legal relevance etc. and a document ?ENTITY2 was produced to prove the satisfaction of the critieria by ?ENTITY1.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionValidatedByDocument"></see></summary>
    let transactionValidatedByDocument = _prefix "transactionValidatedByDocument"
    /// <summary>
    /// The monitoring of the completion and legality of the decision-making process in each company involved in a transaction is carried out by a national authority having jurisdiction over each of those companies. The national authority could be a court, a notary or any other competent authority appointed by the Member State concerned.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CompetentAuthority"></see></summary>
    let CompetentAuthority = _prefix "CompetentAuthority"
    /// <summary>
    /// The right of employees or their representatives to be consulted and to give advice on a business decision, such as an intended merger/division/conversion/seat transfer.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ConsultationRight"></see></summary>
    let ConsultationRight = _prefix "ConsultationRight"
    /// <summary>
    /// A document issued by a Competent Authority declaring that the legally required steps of a conversion are completed. The certificate needs to be presented by a company to either be registered in another company registry or to be removed from a company register.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ConversionCertificate"></see></summary>
    let ConversionCertificate = _prefix "ConversionCertificate"
    /// <summary>
    /// Document required by law to document the step of a company transaction or an agreement made between stakeholders involved in the transaction that are either printed, inserted and mailed, or electronically presented.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#TransactionDocument"></see></summary>
    let TransactionDocument = _prefix "TransactionDocument"
    /// <summary>
    /// Legal forum in which a body of people presided over by a judge, judges, or magistrate, and acting as a tribunal in civil and criminal cases resolve legal disputes.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Court"></see></summary>
    let Court = _prefix "Court"
    /// <summary>
    /// A person, organization, or government that is owed money. A creditor's claims and the safeguarding of these creditor rights is laid down in the company law of the Member States and EU law.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Creditor"></see></summary>
    let Creditor = _prefix "Creditor"
    /// <summary>
    /// The right of a creditor to influence or take a decision in the context of a transaction.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CreditorDecisionRight"></see></summary>
    let CreditorDecisionRight = _prefix "CreditorDecisionRight"
    /// <summary>
    /// The rights of creditors, which includes debenture holders, vis-a-vis the company that obtained credit from the individual or organisation. Legal safeguards are put in place to ensure that rights of creditors are not negatively affected by a company transaction.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CreditorRight"></see></summary>
    let CreditorRight = _prefix "CreditorRight"
    /// <summary>
    /// The creditors right to be paid out and therefore to exit the company in the context of a transaction.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CreditorExitRight"></see></summary>
    let CreditorExitRight = _prefix "CreditorExitRight"
    /// <summary>
    /// The information rights of creditors in the context of a company transaction, which includes for instance access to documents.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CreditorInformationRight"></see></summary>
    let CreditorInformationRight = _prefix "CreditorInformationRight"
    /// <summary>
    /// (applicableTo ?ENTITY1 ?ENTITY2) means that some legal right ?ENTITY1 is awarded or assigned to a particular person or agent ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#applicableTo"></see></summary>
    let applicableTo = _prefix "applicableTo"
    /// <summary>
    /// Member States shall provide for an adequate system of protection of the interest of creditors, and shall ensure that creditors who are dissatisfied with the safeguards offered in the draft terms of the transaction, as provided for in Article 86d (1) point (f), may apply to the appropriate administrative or judicial authority for adequate safeguards provided that they can credibly demonstrate that due to the transaction the satisfaction of their claims is at stake and that no adequate safeguards have been obtained from the company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CreditorSecurityRight"></see></summary>
    let CreditorSecurityRight = _prefix "CreditorSecurityRight"
    /// <summary>
    /// A cross-border conversion is an operation through which a company, formed in one country (with the EU/EEA set of countries) is converted into a company governed by the law of another.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderConversion"></see></summary>
    let CrossBorderConversion = _prefix "CrossBorderConversion"
    /// <summary>
    /// Article 86m: a pre-conversion certificate attests compliance with all the relevant conditions and the proper completion of all procedures and formalities in the departure Member State.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#PreConversionCertificate"></see></summary>
    let PreConversionCertificate = _prefix "PreConversionCertificate"
    /// <summary>
    /// (involvesCountry ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 includes the modification of a company whose place of business is located in the country referred to by ?ENTITY2
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#involvesCountry"></see></summary>
    let involvesCountry = _prefix "involvesCountry"
    /// <summary>
    /// A company which in a process of the cross-border division in case of a full division transfers all its assets and liabilities to two or more companies, or in case of a partial division or division by separation transfers part of its assets and liabilities to one or more companies. The companies involved in the process are located in multiple (two or more) distinct countries.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderDivision"></see></summary>
    let CrossBorderDivision = _prefix "CrossBorderDivision"
    /// <summary>
    /// A cross border merger involves at least one company based in an EU Member State and one company that is registered elsewhere within the European Union and is leading to a universal transfer of assets and liabilities from the merging company to the acquiring company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderMerger"></see></summary>
    let CrossBorderMerger = _prefix "CrossBorderMerger"
    /// <summary>
    /// Merging Company means the dissolving company that is being acquired by another (acquiring) company in the process of a transaction. In the context of company mobility, this means a universal transfer of assets and liabilities from the merging to the acquiring company (see article 131 of Directive 2017/1132).
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#MergingCompany"></see></summary>
    let MergingCompany = _prefix "MergingCompany"
    /// <summary>
    /// Article 89: The operation whereby one or more companies are wound up without going into liquidation and transfer to another all their assets and liabilities in exchange for the issue to the shareholders of the company or companies being acquired of shares in the acquiring company and a cash payment, if any, not exceeding 10 % of the nominal value of the shares so issued or, where they have no nominal value, of their accounting par value. Companies involved come from two or more distinct countries.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderMergerByAcquisition"></see></summary>
    let CrossBorderMergerByAcquisition = _prefix "CrossBorderMergerByAcquisition"
    /// <summary>
    /// (hasMergingCompany ?ENTITY1 ?ENTITY2) means that some company merger transaction ?ENTITY1 involves a company ?ENTITY2 which will be dissolved during the process of ?ENTITY1 and will be acquired (via a universal transfer of assets and liabilities) by another distinct company involved in ?ENTITY1.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasMergingCompany"></see></summary>
    let hasMergingCompany = _prefix "hasMergingCompany"
    /// <summary>
    /// (hasAcquiringCompany ?ENTITY1 ?ENTITY2) means that some company merger transaction ?ENTITY1 produces a new company or alters an existing one (?ENTITY2) such that ?ENTITY2 will acquire (via a universal transfer of assets and liabilities) one or more other companies involved in the process ?ENTITY1.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasAcquiringCompany"></see></summary>
    let hasAcquiringCompany = _prefix "hasAcquiringCompany"
    /// <summary>
    /// Article 90: the operation whereby several companies are wound up without going into liquidation and transfer to a company that they set up all their assets and liabilities in exchange for the issue to their shareholders of shares in the new company and a cash payment, if any, not exceeding 10 % of the nominal value of the shares so issued or, where they have no nominal value, of their accounting par value. Companies involved come from two or more distinct countries.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderMergerIntoNewCompany"></see></summary>
    let CrossBorderMergerIntoNewCompany = _prefix "CrossBorderMergerIntoNewCompany"
    /// <summary>
    /// The act of changing the location where the company’s business was managed (registered office or headquarters) or the place where that company’s primary business was actually conducted (central administration), across national boundaries.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderSeatTransfer"></see></summary>
    let CrossBorderSeatTransfer = _prefix "CrossBorderSeatTransfer"
    /// <summary>
    /// A data curation activity represents a researcher's involvement in annotating cross border transactions
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DataCurationActivity"></see></summary>
    let DataCurationActivity = _prefix "DataCurationActivity"
    /// <summary>
    /// Usage is the beginning of utilizing an entity by an activity. Before usage, the activity had not begun to utilize this entity and could not have been affected by the entity.
    ///
    /// Based on: https://www.w3.org/TR/prov-o/#used
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#used"></see></summary>
    let used = _prefix "used"
    /// <summary>
    /// An activity association is an assignment of responsibility to an agent for a process, indicating that the agent had a role in the activity.
    ///
    /// Based on: https://www.w3.org/TR/prov-o/#wasAssociatedWith
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#wasAssociatedWith"></see></summary>
    let wasAssociatedWith = _prefix "wasAssociatedWith"
    /// <summary>
    /// The shareholders can take a number of decisions affecting the company, such as amending the company's articles of association, appointing or dismissing board members and to approve important transactions (e.g. mergers, divisions and conversions/seat transfers). These are taken through a shareholder resolution.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DecisionRight"></see></summary>
    let DecisionRight = _prefix "DecisionRight"
    /// <summary>
    /// The rights of shareholders of a company in the context of a transaction. Often, shreholder resolutions are used to effectuate shareholder rights. Many rights are laid down in the so-called Shareholder Rights Directive.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ShareholderRight"></see></summary>
    let ShareholderRight = _prefix "ShareholderRight"
    /// <summary>
    /// A document issued by a Competent Authority declaring that the legally required steps of a division are completed. The certificate needs to be presented by a company to either be registered (or register a newly established emerging/recipient company) in another company registry or to be removed from a company register.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DivisionCertificate"></see></summary>
    let DivisionCertificate = _prefix "DivisionCertificate"
    /// <summary>
    /// A domestic conversion is an operation through which a company's form is converted into a another while still remaining governed by the same law as the original company. For instance, the modification of a company's form from a public to a private limited company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticConversion"></see></summary>
    let DomesticConversion = _prefix "DomesticConversion"
    /// <summary>
    /// A company which in a process of the domestic division - in case of a full division - transfers all its assets and liabilities to two or more companies, or - in case of a partial division or division by separation - transfers part of its assets and liabilities to one or more companies. All companies involved in the process are located in a single country.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticDivision"></see></summary>
    let DomesticDivision = _prefix "DomesticDivision"
    /// <summary>
    /// A domestic merger involves at least two companies based in the same EU Member State and is leading to a universal transfer of assets and liabilities from the merging company to the acquiring company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticMerger"></see></summary>
    let DomesticMerger = _prefix "DomesticMerger"
    /// <summary>
    /// Article 89: The operation whereby one or more companies are wound up without going into liquidation and transfer to another all their assets and liabilities in exchange for the issue to the shareholders of the company or companies being acquired of shares in the acquiring company and a cash payment, if any, not exceeding 10 % of the nominal value of the shares so issued or, where they have no nominal value, of their accounting par value. All companies involved are from a single country.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticMergerByAcquisition"></see></summary>
    let DomesticMergerByAcquisition = _prefix "DomesticMergerByAcquisition"
    /// <summary>
    /// Article 90: the operation whereby several companies are wound up without going into liquidation and transfer to a company that they set up all their assets and liabilities in exchange for the issue to their shareholders of shares in the new company and a cash payment, if any, not exceeding 10 % of the nominal value of the shares so issued or, where they have no nominal value, of their accounting par value. All companies involved are from a single country.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticMergerIntoNewCompany"></see></summary>
    let DomesticMergerIntoNewCompany = _prefix "DomesticMergerIntoNewCompany"
    /// <summary>
    /// A company being divided transfers part of its assets and liabilities to one or more newly formed companies, which are the recipient companies in a (cross-border) division.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#EmergingCompany"></see></summary>
    let EmergingCompany = _prefix "EmergingCompany"
    /// <summary>
    /// The act of changing the location where the company’s business was managed (registered office or headquarters) or the place where that company’s primary business was actually conducted (central administration), within a specific country.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticSeatTransfer"></see></summary>
    let DomesticSeatTransfer = _prefix "DomesticSeatTransfer"
    /// <summary>
    /// Created in 1994, the European Economic Area (EEA) combines the countries of the European Union (EU) and member countries of the European Free Trade Association (EFTA) to facilitate participation in the European Market trade and movement without having to apply to be one of the EU member countries
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#EEACountry"></see></summary>
    let EEACountry = _prefix "EEACountry"
    /// <summary>
    /// A country which does not belong to the European Economic Area (EEA).
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#NonEEACountry"></see></summary>
    let NonEEACountry = _prefix "NonEEACountry"
    /// <summary>
    /// A country which forms part of the European Union. The European Union is a conglomeration of European countries whose governance structures agree to abide with common political and economic criteria to improve efficiency of goods and services trading as well as movement and migration of inhabitants between these countries
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#EUCountry"></see></summary>
    let EUCountry = _prefix "EUCountry"
    /// <summary>
    /// A country that does not officially belong to the EU conglomeration
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#NonEUCountry"></see></summary>
    let NonEUCountry = _prefix "NonEUCountry"
    /// <summary>
    /// (employedBy ?ENTITY1 ?ENTITY2) means that some agent (person or organisation) ?ENTITY1 is promised and delivered an incentive (usually financial) to perform some work for ?ENTITY2 where ?ENTITY2 is an organisation. This exchange is usually governed by law and formal regulations in the particular country or social context in which the work is being performed.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#employedBy"></see></summary>
    let employedBy = _prefix "employedBy"
    /// <summary>
    /// A body that regulates the financial services industry in a country (e.g. the UK), including most financial services markets, exchanges and firms.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#FinancialServiceAuthority"></see></summary>
    let FinancialServiceAuthority = _prefix "FinancialServiceAuthority"
    /// <summary>
    /// A global ultimate owner (GUO) is the individual or entity at the top of the corporate ownership structure.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#GlobalUltimateOwner"></see></summary>
    let GlobalUltimateOwner = _prefix "GlobalUltimateOwner"
    /// <summary>
    /// (owns ?ENTITY1 ?ENTITY2) means (owns ?ENTITY2 ?ENTITY1)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#owns"></see></summary>
    let owns = _prefix "owns"
    /// <summary>
    /// The right of employees or their representatives to be informed on the likely repercussions of the cross-border transaction on employment, which includes the dismissal as well as the hiring of employees or relocation of work. See for instance article 122 of Directive 2017/1132.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ImpactOnEmploymentRight"></see></summary>
    let ImpactOnEmploymentRight = _prefix "ImpactOnEmploymentRight"
    /// <summary>
    /// The right of employees or their representatives to be informed and to receive any documents necessary for the exercise of their consultation and board-level employee representation rights in the context of an intended merger/division/conversion/seat transfer.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#InformationRight"></see></summary>
    let InformationRight = _prefix "InformationRight"
    /// <summary>
    /// An Independent Expert provides impartial advice to shareholders and other company stakeholders on the fairness and/or reasonableness of a transaction.  A company may be required to commission an Independent Expert Report (IER) in the case of a (cross-border) merger, division or conversion.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#IndependentExpert"></see></summary>
    let IndependentExpert = _prefix "IndependentExpert"
    /// <summary>
    /// Article 86g and 160i: Member States must ensure that an independent expert examines the draft terms of the transaction and draws up a report intended for members which is made available to them not less than one month before the date of the general meeting. Depending on the law of Member States, the expert may be a natural person or a legal person. The report must assess the cash compensation proposed and valuation method.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#IndependentExpertReport"></see></summary>
    let IndependentExpertReport = _prefix "IndependentExpertReport"
    /// <summary>
    /// (authoredBy ?ENTITY1 ?ENTITY2) means that ?ENTITY1 is an instance of a publication that is created primarily by the entity referred to by ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#authoredBy"></see></summary>
    let authoredBy = _prefix "authoredBy"
    /// <summary>
    /// Interim accounts are accounts that are published during a company's financial year and that show the financial situation on a given accounting date.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#InterimAccount"></see></summary>
    let InterimAccount = _prefix "InterimAccount"
    /// <summary>
    /// The group of persons comprising the governing body of the legal entity that is entrusted with the decision-making in the company. It is also called Executive Board in a one-tier board system.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagementBoard"></see></summary>
    let ManagementBoard = _prefix "ManagementBoard"
    /// <summary>
    /// A person or group of persons that are responsible for overseeing the operations of a company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Manager"></see></summary>
    let Manager = _prefix "Manager"
    /// <summary>
    /// A report drawn up by the company's management on the intended transaction, laying out the main features of the transactions and its consequences.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagementReport"></see></summary>
    let ManagementReport = _prefix "ManagementReport"
    /// <summary>
    /// The right of the board of management or individual managers to take decisions or to not take a decision in the context of a transaction. These are in the form of a board resolution.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagerDecisionRight"></see></summary>
    let ManagerDecisionRight = _prefix "ManagerDecisionRight"
    /// <summary>
    /// The rights of members of the management in the context of a company transaction.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagerRight"></see></summary>
    let ManagerRight = _prefix "ManagerRight"
    /// <summary>
    /// The right of a manager or the board of management to resign and therefore exit a company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagerExitRight"></see></summary>
    let ManagerExitRight = _prefix "ManagerExitRight"
    /// <summary>
    /// The right of a manager to information and access to documents that he or she has in accordance with national or European company law.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagerInformationRight"></see></summary>
    let ManagerInformationRight = _prefix "ManagerInformationRight"
    /// <summary>
    /// The national gazette or record in a particular Member State. In the official journal companies publish company transaction notices in order to inform concerned stakeholders and interested parties.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#MemberStateOfficialJournal"></see></summary>
    let MemberStateOfficialJournal = _prefix "MemberStateOfficialJournal"
    /// <summary>
    /// The official gazette of record for the European Union or national gazette of record of a Member State. In the official journal companies publish transaction notices in order to inform concerned stakeholders and interested parties.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#OfficialJournal"></see></summary>
    let OfficialJournal = _prefix "OfficialJournal"
    /// <summary>
    /// A document issued by a Competent Authority declaring that the legally required steps of a merger are completed. The certificate needs to be presented by a company to either be registered in another company registry or to be removed from a company register (depending on the company being the merging or acquiring company).
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#MergerCertificate"></see></summary>
    let MergerCertificate = _prefix "MergerCertificate"
    /// <summary>
    /// (isTransactionInputOf ?ENTITY1 ?ENTITY2) means (hasTransactionInput ?ENTITY2 ?ENTITY1)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#isTransactionInputOf"></see></summary>
    let isTransactionInputOf = _prefix "isTransactionInputOf"
    /// <summary>
    /// A national registry is a business registry in a Member State, which includes information on the population of companies in the jurisdiction and holds inter alia data on registration numbers, place of registration, notices and transaction documents in the national registry repository.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#NationalRegistry"></see></summary>
    let NationalRegistry = _prefix "NationalRegistry"
    /// <summary>
    /// The digital repository in which documents published in the official journal or by by the national registry (on behalf of a company) are kept as well as related documents. In some EU Member States, this repository is overlapping or identical with the Official Journal Repository.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#NationalRegistryRepository"></see></summary>
    let NationalRegistryRepository = _prefix "NationalRegistryRepository"
    /// <summary>
    /// (maintainedBy ?ENTITY1 ?ENTITY2) means that some digital resource ?ENTITY1 (e.g. database, website, document repository etc.) has stewardship by some agent or organisation ?ENTITY2 who is responsible for the upkeep of ?ENTITY1.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#maintainedBy"></see></summary>
    let maintainedBy = _prefix "maintainedBy"
    /// <summary>
    /// A person authorized to perform certain legal formalities, especially to draw up or certify contracts, deeds, and other documents for use in other jurisdictions.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Notary"></see></summary>
    let Notary = _prefix "Notary"
    /// <summary>
    /// Publication of a legally valid record or act in an official national gazette to inform stakeholders.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#OfficialJournalPublication"></see></summary>
    let OfficialJournalPublication = _prefix "OfficialJournalPublication"
    /// <summary>
    /// The digital repository in which documents published in the official journal are kept as well as related documents. In some EU Member States, this repository is overlapping or identical with the National Registry Repository.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#OfficialJournalRepository"></see></summary>
    let OfficialJournalRepository = _prefix "OfficialJournalRepository"
    /// <summary>
    /// An original company, in the context of a (cross-border) division, means a company which - in case of a full division - transfers all its assets and liabilities to two or more companies, or - in case of a partial division or division by separation - transfers part of its assets and liabilities to one or more companies.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#OriginalCompany"></see></summary>
    let OriginalCompany = _prefix "OriginalCompany"
    /// <summary>
    /// A parent company is a company that has a controlling interest in another company, the subsidiary company, giving it control of its operations through a majority stock-ownership, decisive control over management appointments and therefore over the decision-making process. In the absence of a natural person as ultimate beneficial owner, the highest parent company in a chain of companies is the global ultimate owner.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ParentCompany"></see></summary>
    let ParentCompany = _prefix "ParentCompany"
    /// <summary>
    /// (hasSubsidiaryCompany ?ENTITY1 ?ENTITY2) means (hasParentCompany ?ENTITY2 ?ENTITY1)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasSubsidiaryCompany"></see></summary>
    let hasSubsidiaryCompany = _prefix "hasSubsidiaryCompany"
    /// <summary>
    /// Article 160o: a pre-division certificate attests compliance with all the relevant conditions and the proper completion of all procedures and formalities in the Member State concerned.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#PreDivisionCertificate"></see></summary>
    let PreDivisionCertificate = _prefix "PreDivisionCertificate"
    /// <summary>
    /// Article 127: a pre-merger certificate attests compliance with all the relevant conditions and the proper completion of all procedures and formalities in the Member State of the merging company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#PreMergerCertificate"></see></summary>
    let PreMergerCertificate = _prefix "PreMergerCertificate"
    /// <summary>
    /// A company being divided transfers part of its assets and liabilities to one or more newly formed companies, which are the recipient companies in a (cross-border) division.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#RecipientCompany"></see></summary>
    let RecipientCompany = _prefix "RecipientCompany"
    /// <summary>
    /// Variable indicating the SE-establishment mode: by merger, conversion, holding-SE, subsidiary-SE or unsure (cases)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#SEType"></see></summary>
    let SEType = _prefix "SEType"
    /// <summary>
    /// This is a cross-border merger where two or more companies from different Member States merge into a new company that has a special legal form called a Societas Europaea (SE) which allows the behavior of this new company to be regulated under European Law (rather than national law).
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#SocietasEuropaeaMerger"></see></summary>
    let SocietasEuropaeaMerger = _prefix "SocietasEuropaeaMerger"
    /// <summary>
    /// The right of a shareholder to exit the company by being bought out.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ShareholderExitRight"></see></summary>
    let ShareholderExitRight = _prefix "ShareholderExitRight"
    /// <summary>
    /// It is particularly important that the shareholders of the companies involved in a transaction be kept adequately informed in an objective manner, and that their rights be suitably protected. This includes for instance the availability of documents for inspection by shareholders (e.g. article 97 of Directive 2017/1132).
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ShareholderInformationRight"></see></summary>
    let ShareholderInformationRight = _prefix "ShareholderInformationRight"
    /// <summary>
    /// a shareholder resolution is a proposal submitted by shareholders for a vote at the company's shareholder meeting.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ShareholderResolution"></see></summary>
    let ShareholderResolution = _prefix "ShareholderResolution"
    /// <summary>
    /// The society at large is a stakeholder in a company through, inter alia, the government and its agencies, suppliers, customers, trade unions and the communities from which the business draws its resources.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#Society"></see></summary>
    let Society = _prefix "Society"
    /// <summary>
    /// The Special Negotiation Body (SNB) or Special Negotiating Body is an organisation that represents the employees of companies in negotiations with the company authorities in order to reach a written agreement on the involvement of employees in company transactions.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#SpecialNegotiationBody"></see></summary>
    let SpecialNegotiationBody = _prefix "SpecialNegotiationBody"
    /// <summary>
    /// A written agreement concerning the involvement of employees in company transactions. Special Negotiating Body (SNB) organisation represents employees in the negotiation of the terms of this agreement with the company authorities. The agreement must be reached in accordance with the EU Company Law Directive and is laid down in the SNB-agreement.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#SpecialNegotiationBodyAgreement"></see></summary>
    let SpecialNegotiationBodyAgreement = _prefix "SpecialNegotiationBodyAgreement"
    /// <summary>
    /// A subsidiary, subsidiary company or daughter company is a company that is owned or controlled by another company, which is called the parent company, parent, or holding company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#SubsidiaryCompany"></see></summary>
    let SubsidiaryCompany = _prefix "SubsidiaryCompany"
    /// <summary>
    /// (hasParentCompany ?ENTITY1 ?ENTITY2) means that some company ?ENTITY1 is owned and under direct or indirect control by the company ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasParentCompany"></see></summary>
    let hasParentCompany = _prefix "hasParentCompany"
    /// <summary>
    /// An individual authority established by its member state to supervise the compliance with a specific regulation.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#SupervisoryAuthority"></see></summary>
    let SupervisoryAuthority = _prefix "SupervisoryAuthority"
    /// <summary>
    /// A supervisory board must approve of major business decisions. It is a group of individuals chosen by the shareholders - and employee representatives in board-level employee representation systems - of a company to promote their interests through the governance of the company and to hire and supervise the management board. It is also called non-executive board in a one-tier board system.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#SupervisoryBoard"></see></summary>
    let SupervisoryBoard = _prefix "SupervisoryBoard"
    /// <summary>
    /// Tax Authority means any governmental authority having jurisdiction over the assessment, determination, collection or imposition of any tax.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#TaxAuthority"></see></summary>
    let TaxAuthority = _prefix "TaxAuthority"
    /// <summary>
    /// (containedIn ?ENTITY1 ?ENTITY2) means that some document or publication ?ENTITY1 is archived or stored in some other document collection, database or data repository referred to by ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#containedIn"></see></summary>
    let containedIn = _prefix "containedIn"
    /// <summary>
    /// Transferring Company means the company transferring its assets and liabilities to a recipient company.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#TransferringCompany"></see></summary>
    let TransferringCompany = _prefix "TransferringCompany"
    /// <summary>
    /// Ultimate Beneficial owner refers to the natural person(s) who ultimately owns or controls a customer and/or the natural person on whose behalf a transaction is being conducted. It also includes those persons who exercise ultimate effective control over a legal person or arrangement.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#UltimateBeneficialOwner"></see></summary>
    let UltimateBeneficialOwner = _prefix "UltimateBeneficialOwner"
    /// <summary>
    /// The exercise of employee participation through the representation of employees vis-a-vis the management of a company. The works council is a shop-floor level representation mechanism with information, consultation and veto-rights - depending on the extent of rights given in a Member State - and also at EU level through European Works Councils.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#WorksCouncil"></see></summary>
    let WorksCouncil = _prefix "WorksCouncil"
    /// <summary>
    /// number of employees of the acquiring company - at the moment of the transaction
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#acEmploymentFigureAtTransaction"></see></summary>
    let acEmploymentFigureAtTransaction = _prefix "acEmploymentFigureAtTransaction"
    /// <summary>
    /// The last available annual employment figure for the acquiring company
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#acLastEmploymentFigure"></see></summary>
    let acLastEmploymentFigure = _prefix "acLastEmploymentFigure"
    /// <summary>
    /// total number of employees of the acquiring company in the EU at the moment of the transaction
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#acTotalEUEmploymentFigure"></see></summary>
    let acTotalEUEmploymentFigure = _prefix "acTotalEUEmploymentFigure"
    /// <summary>
    /// The year the last annual employment figure was obtained for acquiring companies
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#acYearEmploymentFigure"></see></summary>
    let acYearEmploymentFigure = _prefix "acYearEmploymentFigure"
    /// <summary>
    /// Provides a human-readable written example of the entity in question.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#example"></see></summary>
    let example = _prefix "example"
    /// <summary>
    /// (cbcmObjectRelation ?ENTITY1 ?ENTITY2) means that the relation between ?ENTITY1 and ?ENTITY2 captures information pertaining to an object.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmObjectRelation"></see></summary>
    let cbcmObjectRelation = _prefix "cbcmObjectRelation"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#austria"></see>
    /// </summary>
    let austria = _prefix "austria"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#iso2code"></see>
    /// </summary>
    let iso2code = _prefix "iso2code"
    /// <summary>
    /// (authors ?ENTITY1 ?ENTITY2) means that (authoredBy ?ENTITY2 ?ENTITY1)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#authors"></see></summary>
    let authors = _prefix "authors"
    /// <summary>
    /// (cbcmDocumentRelation ?ENTITY1 ?ENTITY2) means that the relation between ?ENTITY1 and ?ENTITY2 captures information pertaining to a company mobility document or similar information source relevant to corporate mobility.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmDocumentRelation"></see></summary>
    let cbcmDocumentRelation = _prefix "cbcmDocumentRelation"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#belgium"></see>
    /// </summary>
    let belgium = _prefix "belgium"
    /// <summary>
    /// Is an employee board level representation/participation (BLER) mechanism applicable prior to the cross-border transaction?
    ///
    /// 0 = no BLER prior to cross-border transaction
    /// 1 = BLER existing prior to cross-border transaction
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#bler"></see></summary>
    let bler = _prefix "bler"
    /// <summary>
    /// What is the employee board level representation (BLER) ratio going to be after the completion of the transaction?
    ///
    /// The ratio is ranging from 0.00 (no BLER) to 0.33 (1/3 BLER) to 0.5 (50-50 Mitbestimmung) to (theoretically) 1.00, which would be 100% employee representatives on the board and no shareholder representatives.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#blerComposition"></see></summary>
    let blerComposition = _prefix "blerComposition"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#bulgaria"></see>
    /// </summary>
    let bulgaria = _prefix "bulgaria"
    /// <summary>
    /// (cbcmDataProvenanceRelation ?ENTITY1 ?ENTITY2) means that the relation between ?ENTITY1 and ?ENTITY2 captures provenance information for company transaction data.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmDataProvenanceRelation"></see></summary>
    let cbcmDataProvenanceRelation = _prefix "cbcmDataProvenanceRelation"
    /// <summary>
    /// (cbcmEntityRelation ?ENTITY1 ?ENTITY2) means that ?ENTITY1 is related to ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmEntityRelation"></see></summary>
    let cbcmEntityRelation = _prefix "cbcmEntityRelation"
    /// <summary>
    /// (cbcmOrganisationRelation ?ENTITY1 ?ENTITY2) means that the relation between ?ENTITY1 and ?ENTITY2 captures information pertaining to an organisation.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmOrganisationRelation"></see></summary>
    let cbcmOrganisationRelation = _prefix "cbcmOrganisationRelation"
    /// <summary>
    /// (cbcmTransactionRelation ?ENTITY1 ?ENTITY2) means that the relation between ?ENTITY1 and ?ENTITY2 captures information pertaining to a company mobility transaction.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmTransactionRelation"></see></summary>
    let cbcmTransactionRelation = _prefix "cbcmTransactionRelation"
    /// <summary>
    /// Are the companies involved in the transaction having an economic committee?
    ///
    /// An economic committee advises the work council about the financial parts of the transaction.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#companiesHaveEconomicCommittee"></see></summary>
    let companiesHaveEconomicCommittee = _prefix "companiesHaveEconomicCommittee"
    /// <summary>
    /// Are the companies involved in the transaction having employees? Only one company needs to have employees for this property to be true
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#companiesHaveEmployees"></see></summary>
    let companiesHaveEmployees = _prefix "companiesHaveEmployees"
    /// <summary>
    /// Are the companies involved in the transaction having a works council? Works councils safeguard employees' welfare
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#companiesHaveWorksCouncil"></see></summary>
    let companiesHaveWorksCouncil = _prefix "companiesHaveWorksCouncil"
    /// <summary>
    /// (companyFormCountry ?ENTITY1 ?ENTITY2) means that ?ENTITY1 is a company form recognized by the law of country ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#companyFormCountry"></see></summary>
    let companyFormCountry = _prefix "companyFormCountry"
    /// <summary>
    /// (countryHasCompanyForm ?ENTITY1 ?ENTITY2) means that ?ENTITY1 refers to a country the corporate law in that country permits and / or has occurrences of companies in that country which have the corporate legal structure (company legal form) referred to by ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#countryHasCompanyForm"></see></summary>
    let countryHasCompanyForm = _prefix "countryHasCompanyForm"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#croatia"></see>
    /// </summary>
    let croatia = _prefix "croatia"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#cyprus"></see>
    /// </summary>
    let cyprus = _prefix "cyprus"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#czechia"></see>
    /// </summary>
    let czechia = _prefix "czechia"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#denmark"></see>
    /// </summary>
    let denmark = _prefix "denmark"
    /// <summary>
    /// If a different employee number for the acquiring company is found, it is recorded in this field
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#divergingEmploymentFigure"></see></summary>
    let divergingEmploymentFigure = _prefix "divergingEmploymentFigure"
    /// <summary>
    /// (documentValidatedByDocument ?ENTITY1 ?ENTITY2) means that some document or publication, ?ENTITY1, went through a process of approval and assessment through various criteria such as veracity, eligibility, legal relevance etc. and another document ?ENTITY2 was produced to prove the satisfaction of the critieria by ?ENTITY1.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#documentValidatedByDocument"></see></summary>
    let documentValidatedByDocument = _prefix "documentValidatedByDocument"
    /// <summary>
    /// (hasCompanyStakeholder ?ENTITY1 ?ENTITY2) means that some entity ?ENTITY1, which is either a significant process or agent has another agent ?ENTITY2 with personal interests in benefiting either financially or otherwise from the outcomes of ?ENTITY1 (if it is an event or process), or in its byproducts and profits (if it is an agent).
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasCompanyStakeholder"></see></summary>
    let hasCompanyStakeholder = _prefix "hasCompanyStakeholder"
    /// <summary>
    /// (employs ?ENTITY1 ?ENTITY2) means (employedBy ?ENTITY2 ?ENTITY1)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#employs"></see></summary>
    let employs = _prefix "employs"
    /// <summary>
    /// The date and time a process ended
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#endedAtTime"></see></summary>
    let endedAtTime = _prefix "endedAtTime"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#estonia"></see>
    /// </summary>
    let estonia = _prefix "estonia"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#euOfficialJournal"></see>
    /// </summary>
    let euOfficialJournal = _prefix "euOfficialJournal"
    /// <summary>
    /// Is the company having a European Works Council (EWC)?
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ewc"></see></summary>
    let ewc = _prefix "ewc"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#finland"></see>
    /// </summary>
    let finland = _prefix "finland"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#france"></see>
    /// </summary>
    let france = _prefix "france"
    /// <summary>
    /// Generation is the completion of production of a new entity by a process. This entity did not exist before generation and becomes available for usage after this generation.
    ///
    /// Based (inverse of) on: https://www.w3.org/TR/prov-o/#wasGeneratedBy
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#generated"></see></summary>
    let generated = _prefix "generated"
    /// <summary>
    /// Generation is the completion of production of a new entity by a process. This entity did not exist before generation and becomes available for usage after this generation.
    ///
    /// Based on: https://www.w3.org/TR/prov-o/#wasGeneratedBy
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#wasGeneratedBy"></see></summary>
    let wasGeneratedBy = _prefix "wasGeneratedBy"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#germany"></see>
    /// </summary>
    let germany = _prefix "germany"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#greece"></see>
    /// </summary>
    let greece = _prefix "greece"
    /// <summary>
    /// Company legal form. Name given to describe the structure of a corporation or buiness in the different legal orders. For example Limited (Ltd.), Public Limited Company (PLC), Gesellschaft mit beschränkter Haftung (GmbH), Aktiengesellschaft (AG). The company legal form is regulated under national law and grants specific rights and obligations to the company stakeholders (such as shareholders, management &amp; employees).
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasCompanyForm"></see></summary>
    let hasCompanyForm = _prefix "hasCompanyForm"
    /// <summary>
    /// In which document did the researcher find information about the transaction?
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasDataProvenanceDocumentSource"></see></summary>
    let hasDataProvenanceDocumentSource = _prefix "hasDataProvenanceDocumentSource"
    /// <summary>
    /// In which countries' registry did the researcher find information about the transaction?
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasDataProvenanceRegistryCountry"></see></summary>
    let hasDataProvenanceRegistryCountry = _prefix "hasDataProvenanceRegistryCountry"
    /// <summary>
    /// (hasOriginalCompany ?ENTITY1 ?ENTITY2) means that some company division transaction ?ENTITY1 involves a company ?ENTITY2 which will be divided (or "split") into multiple recipient or emerging companies.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasOriginalCompany"></see></summary>
    let hasOriginalCompany = _prefix "hasOriginalCompany"
    /// <summary>
    /// (?ENTITY1 hasPostCompanyForm ?ENTITY2) indicates the new company form of a company undergoing a cross border conversion or a national conversion.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasPostCompanyForm"></see></summary>
    let hasPostCompanyForm = _prefix "hasPostCompanyForm"
    /// <summary>
    /// Primary country of registration (location) of a company as a full country name
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasPrimaryRegistrationLocation"></see></summary>
    let hasPrimaryRegistrationLocation = _prefix "hasPrimaryRegistrationLocation"
    /// <summary>
    /// (?ENTITY1 hasPriorCompanyForm ?ENTITY2) indicates the original company form of a company undergoing a cross border conversion or a national conversion.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasPriorCompanyForm"></see></summary>
    let hasPriorCompanyForm = _prefix "hasPriorCompanyForm"
    /// <summary>
    /// Country of secondary registration (location) of a company
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hasSecondaryRegistrationLocation"></see></summary>
    let hasSecondaryRegistrationLocation = _prefix "hasSecondaryRegistrationLocation"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#hungary"></see>
    /// </summary>
    let hungary = _prefix "hungary"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#iceland"></see>
    /// </summary>
    let iceland = _prefix "iceland"
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
    let impactOnEmployees = _prefix "impactOnEmployees"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ireland"></see>
    /// </summary>
    let ireland = _prefix "ireland"
    /// <summary>
    /// Whether the company is publicly listed. A company whose shares are bought and sold on a particular stock market.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#isListed"></see></summary>
    let isListed = _prefix "isListed"
    /// <summary>
    /// Variable indicating whether this case concerns an SE-creation (yes/no) to distinguish creations of SEs from other transactions
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#isSECreation"></see></summary>
    let isSECreation = _prefix "isSECreation"
    /// <summary>
    /// (issuedByOrganisation ?ENTITY1 ?ENTITY2) means that some document or publication, ?ENTITY1, was created (and possibly delivered or administered to another entity) by some entity ?ENTITY2.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#issuedByOrganisation"></see></summary>
    let issuedByOrganisation = _prefix "issuedByOrganisation"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#italy"></see>
    /// </summary>
    let italy = _prefix "italy"
    /// <summary>
    /// Last available employment figure for the total worldwide employees
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#lastWWEmploymentFigure"></see></summary>
    let lastWWEmploymentFigure = _prefix "lastWWEmploymentFigure"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#latvia"></see>
    /// </summary>
    let latvia = _prefix "latvia"
    /// <summary>
    /// Name of the lawfirm involved in the transaction, if available (for internal use; cross-border divisions and seat transfers are currently not possible within an EU legal framework.)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#lawfirm"></see></summary>
    let lawfirm = _prefix "lawfirm"
    /// <summary>
    /// The acronym of a company legal form
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#legalFormAcronym"></see></summary>
    let legalFormAcronym = _prefix "legalFormAcronym"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#liechtenstein"></see>
    /// </summary>
    let liechtenstein = _prefix "liechtenstein"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#lithuania"></see>
    /// </summary>
    let lithuania = _prefix "lithuania"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#luxembourg"></see>
    /// </summary>
    let luxembourg = _prefix "luxembourg"
    /// <summary>
    /// (maintains ?ENTITY1 ?ENTITY2) means (maintainedBy ?ENTITY2 ?ENTITY1)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#maintains"></see></summary>
    let maintains = _prefix "maintains"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#malta"></see>
    /// </summary>
    let malta = _prefix "malta"
    /// <summary>
    /// Number of employees of the acquiring company - at the moment of the transaction
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#mcEmploymentFigureAtTransaction"></see></summary>
    let mcEmploymentFigureAtTransaction = _prefix "mcEmploymentFigureAtTransaction"
    /// <summary>
    /// The last available annual employment figure for the merging company
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#mcLastEmploymentFigure"></see></summary>
    let mcLastEmploymentFigure = _prefix "mcLastEmploymentFigure"
    /// <summary>
    /// The year the last annual employment figure was obtained for merging companies
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#mcYearEmploymentFigure"></see></summary>
    let mcYearEmploymentFigure = _prefix "mcYearEmploymentFigure"
    /// <summary>
    /// A transaction whereby more than two companies (i.e. multiple merging companies) are involved and merged into one acquiring company
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#multiCBM"></see></summary>
    let multiCBM = _prefix "multiCBM"
    /// <summary>
    /// NACE Classification Code for companies. NACE (Nomenclature des Activités Économiques dans la Communauté Européenne) is a European industry standard classification system similar in function to Standard Industry Classification (SIC) and North American Industry Classification System (NAICS) for classifying business activities. From EUROSTAT
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#naceCode"></see></summary>
    let naceCode = _prefix "naceCode"
    /// <summary>
    /// Company NACE sector. NACE (Nomenclature of Economic Activities) is the European statistical classification of economic activities. Classification of a company according to which kinds of sector (i.e. industry / market / product type) they deal in. From EUROSTAT
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#naceSector"></see></summary>
    let naceSector = _prefix "naceSector"
    /// <summary>
    /// The name of the organization
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// The national registration number of an acquiring/receiving/entry company. A company registration number is a unique combination of numbers and/or letters. It is used to identify a company and verify its legal existence as an incorporated entity.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#natRegistrationNumber"></see></summary>
    let natRegistrationNumber = _prefix "natRegistrationNumber"
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
    let negotiatedAgreement = _prefix "negotiatedAgreement"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#netherlands"></see>
    /// </summary>
    let netherlands = _prefix "netherlands"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#norway"></see>
    /// </summary>
    let norway = _prefix "norway"
    /// <summary>
    /// (ownedBy ?ENTITY1 ?ENTITY2) means that some agent ?ENTITY2 has proprietorship over another object or organisational agent ?ENTITY1.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#ownedBy"></see></summary>
    let ownedBy = _prefix "ownedBy"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#poland"></see>
    /// </summary>
    let poland = _prefix "poland"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#portugal"></see>
    /// </summary>
    let portugal = _prefix "portugal"
    /// <summary>
    /// unique identifier before database entry.
    ///
    /// This id is the old ID-structure used before entry into the CbCMdb
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#rawTransactionID"></see></summary>
    let rawTransactionID = _prefix "rawTransactionID"
    /// <summary>
    /// Deprecated property
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#registeredOffice"></see></summary>
    let registeredOffice = _prefix "registeredOffice"
    /// <summary>
    /// Specifies a phrase to indicate the degree to which the providing of a value for the entity (e.g. a data or object property) in question is compulsory, recommended or optional.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#requirement-level"></see></summary>
    let ``requirement-level`` = _prefix "requirement-level"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#romania"></see>
    /// </summary>
    let romania = _prefix "romania"
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
    let sbnVoluntaryApplication = _prefix "sbnVoluntaryApplication"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#se_conversion"></see>
    /// </summary>
    let se_conversion = _prefix "se_conversion"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#se_holding"></see>
    /// </summary>
    let se_holding = _prefix "se_holding"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#se_merger"></see>
    /// </summary>
    let se_merger = _prefix "se_merger"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#se_subsidiary"></see>
    /// </summary>
    let se_subsidiary = _prefix "se_subsidiary"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#se_unsure"></see>
    /// </summary>
    let se_unsure = _prefix "se_unsure"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#slovakia"></see>
    /// </summary>
    let slovakia = _prefix "slovakia"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#slovenia"></see>
    /// </summary>
    let slovenia = _prefix "slovenia"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#spain"></see>
    /// </summary>
    let spain = _prefix "spain"
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
    let standardRulesApplication = _prefix "standardRulesApplication"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#sweden"></see>
    /// </summary>
    let sweden = _prefix "sweden"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#switzerland"></see>
    /// </summary>
    let switzerland = _prefix "switzerland"
    /// <summary>
    /// Is the company having a transnational information and consultation agreement in place? Does the company have an internal body which discusses employee rights and welfare?
    ///
    /// Different from works council. TNIC is global.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#tnic"></see></summary>
    let tnic = _prefix "tnic"
    /// <summary>
    /// Is an employee board level representation/participation (BLER) mechanism going to be re-negotiated in the process of the cross-border transaction?
    ///
    /// - Yes: BLER be (re-)negotiated with the SNB;
    /// - No: no BLER-(re-)negotiation;
    /// - Not applicable: the conditions are not met (e.g. no employees, BLER threshold not met) for this criterion to be applicable;
    /// - Unclear: the wording of the document is unclear with regard to the impact/effect/measures taken;
    /// - Not mentioned: given the parameters, this aspect should be addressed in the transaction document, but is not mentioned
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#toBeNegotiatedBLER"></see></summary>
    let toBeNegotiatedBLER = _prefix "toBeNegotiatedBLER"
    /// <summary>
    /// Notes from researcher about the transaction
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionComment"></see></summary>
    let transactionComment = _prefix "transactionComment"
    /// <summary>
    /// Date on which the transaction was effectuated (the date that the competent authority e.g., business registry of that country, says that the criteria have been met by merging and acquiring companies and the merging/transferring company is dissolved).
    ///
    /// This is the final step of a transaction process
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionCompletionDate"></see></summary>
    let transactionCompletionDate = _prefix "transactionCompletionDate"
    /// <summary>
    /// unique identifier for a transaction
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionID"></see></summary>
    let transactionID = _prefix "transactionID"
    /// <summary>
    /// Is the transaction plan available for analysis?
    ///
    /// Merger plan, Seat transfer plan or Division plan. Transaction notice is where the transaction is announced. The other documents are where the nature and details of the transaction are specified.
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionPlan"></see></summary>
    let transactionPlan = _prefix "transactionPlan"
    /// <summary>
    /// Date of the transaction notice (document announcing the transaction) constituting the start of the transaction process. Date that the document was published (which is the important date because this is when it becomes legally binding)
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionStartDate"></see></summary>
    let transactionStartDate = _prefix "transactionStartDate"
    /// <summary>
    /// Variable indicating the SE-establishment mode: by merger, conversion, holding-SE, subsidiary-SE or unsure
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#typeOfSE"></see></summary>
    let typeOfSE = _prefix "typeOfSE"
    /// <summary>
    ///   <see href="http://w3id.org/um/cbcm/eu-cm-ontology#unitedkingdom"></see>
    /// </summary>
    let unitedkingdom = _prefix "unitedkingdom"
    /// <summary>
    /// In which document did the researcher find information about the transaction?
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#usedDataProvenanceDocumentSource"></see></summary>
    let usedDataProvenanceDocumentSource = _prefix "usedDataProvenanceDocumentSource"
    /// <summary>
    /// In which countries' registry did the researcher find information about the transaction?
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#usedDataProvenanceRegistryCountry"></see></summary>
    let usedDataProvenanceRegistryCountry = _prefix "usedDataProvenanceRegistryCountry"
    /// <summary>
    /// Homepage of a company/organization website
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#website"></see></summary>
    let website = _prefix "website"
    /// <summary>
    /// number of employees of company group worldwide at the moment of the transaction
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#wwEmploymentFigureAtTransaction"></see></summary>
    let wwEmploymentFigureAtTransaction = _prefix "wwEmploymentFigureAtTransaction"
    /// <summary>
    /// The year for which a diverging employee number is recorded
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#yearDivergingEmploymentFigure"></see></summary>
    let yearDivergingEmploymentFigure = _prefix "yearDivergingEmploymentFigure"
    /// <summary>
    /// Year in which the last worldwide employment figure was recorded
    /// <see href="http://w3id.org/um/cbcm/eu-cm-ontology#yearWWEmploymentFigure"></see></summary>
    let yearWWEmploymentFigure = _prefix "yearWWEmploymentFigure"
