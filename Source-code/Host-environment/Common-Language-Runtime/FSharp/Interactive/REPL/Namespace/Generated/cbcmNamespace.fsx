#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cbcm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://w3id.org/um/cbcm/eu-cm-ontology#" "cbcm"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Acquiring company</para>
    ///   <para>rdfs:comment : Acquiring Company means the resulting or surviving company in a transaction that takes over another, merging company.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#AcquiringCompany">cbcm:AcquiringCompany</a>
    /// </summary>
    let AcquiringCompany = _prefixId.prefix "AcquiringCompany"
    /// <summary>
    ///   <para>dcterms:description : An entity or group of entities (either biological or non-biological) that is able to perform actions autonomously in the world.</para>
    ///   <para>rdfs:label : Agent^^xsd:string</para>
    ///   <para>rdfs:comment : An entity or group of entities (either biological or non-biological) that is able to perform actions autonomously in the world.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#Agent">cbcm:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:label : Annual account</para>
    ///   <para>rdfs:comment : Annual reports measure a company's financial health. They focus on past and present financial performance, and make predictions about future prospects. The revenue and financial performance of a company.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#AnnualAccount">cbcm:AnnualAccount</a>
    /// </summary>
    let AnnualAccount = _prefixId.prefix "AnnualAccount"
    /// <summary>
    ///   <para>rdfs:label : Annual report</para>
    ///   <para>rdfs:comment : Annual reports measure a company's financial health. They focus on past and present financial performance, and make predictions about future prospects. The revenue and financial performance of a company.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#AnnualReport">cbcm:AnnualReport</a>
    /// </summary>
    let AnnualReport = _prefixId.prefix "AnnualReport"
    /// <summary>
    ///   <para>dcterms:description : An attribute is a characteristic of some entity.</para>
    ///   <para>rdfs:label : Attribute^^xsd:string</para>
    ///   <para>rdfs:comment : An attribute is a characteristic of some entity.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#Attribute">cbcm:Attribute</a>
    /// </summary>
    let Attribute = _prefixId.prefix "Attribute"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <para>dcterms:description : Behaviour is the set of actions and mannerisms made by systems (biological or otherwise) in response to stimuli or inputs, whether internal or external, conscious or subconscious, overt or covert, and voluntary or involuntary.</para>
    ///   <para>rdfs:label : Behaviour^^xsd:string</para>
    ///   <para>rdfs:comment : Behaviour is the set of actions and mannerisms made by systems (biological or otherwise) in response to stimuli or inputs, whether internal or external, conscious or subconscious, overt or covert, and voluntary or involuntary.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#Behaviour">cbcm:Behaviour</a>
    /// </summary>
    let Behaviour = _prefixId.prefix "Behaviour"

    /// <summary>
    ///   <para>rdfs:label : Board-level employee representation right</para>
    ///   <para>rdfs:comment : Board-level representation of employees (BLER) refers to the phenomenon where employees or their representatives elect or appoint representatives to the strategic decision-making body of a company (i.e. the supervisory board or non-executive board in a one-tier system). The BLER right requires that if such a system of BLER exists prior to a cross-border company transaction, such a right must be upheld in the acquiring/recipient company under the "before-and-after-principle".</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#BoardLevelEmployeeRepresentationRight">cbcm:BoardLevelEmployeeRepresentationRight</a>
    /// </summary>
    let BoardLevelEmployeeRepresentationRight =
        _prefixId.prefix "BoardLevelEmployeeRepresentationRight"

    /// <summary>
    ///   <para>rdfs:label : Board resolution</para>
    ///   <para>rdfs:comment : A Board Resolution, or Company Resolution, is a way of documenting a decision made by a Company's Board of Directors on behalf of the company. After the resolution is made during a meeting, a Board Resolution document is typically used to get the specifics of the resolution in writing.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#BoardResolution">cbcm:BoardResolution</a>
    /// </summary>
    let BoardResolution = _prefixId.prefix "BoardResolution"
    /// <summary>
    ///   <para>rdfs:label : Cross-border company mobility researcher</para>
    ///   <para>rdfs:comment : A person that is interested in research about cross-border company mobility, and actively collects and analyses data concerning cross-border company mobility.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CBCMResearcher">cbcm:CBCMResearcher</a>
    /// </summary>
    let CBCMResearcher = _prefixId.prefix "CBCMResearcher"
    /// <summary>
    ///   <para>rdfs:label : City</para>
    ///   <para>rdfs:comment : A city (plural "cities") is a geo-political region in which there is a large human settlement. The distinction with the term "town" (plural "towns") is that cities are generally larger than towns. Countries are generally larger than cities and, in fact, usually consist of multiple cities.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#City">cbcm:City</a>
    /// </summary>
    let City = _prefixId.prefix "City"
    /// <summary>
    ///   <para>rdfs:label : Company</para>
    ///   <para>rdfs:comment : A company is a legal entity formed by a group of individuals to engage in and operate a business—commercial or industrial—enterprise. A company may be organized in various ways for tax and financial liability purposes depending on the corporate law of its jurisdiction.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#Company">cbcm:Company</a>
    /// </summary>
    let Company = _prefixId.prefix "Company"
    /// <summary>
    ///   <para>rdfs:label : Central Administration</para>
    ///   <para>rdfs:comment : The headquarters or body of a company which governs it's financial and administrative activities</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyCentralAdministration">cbcm:CompanyCentralAdministration</a>
    /// </summary>
    let CompanyCentralAdministration = _prefixId.prefix "CompanyCentralAdministration"
    /// <summary>
    ///   <para>rdfs:label : Company conversion</para>
    ///   <para>rdfs:comment : The process of changing or converting the corporate structure of a company. For example, a limited liability company of one country to one of another country, or from a private to a public limited liability company, or vice-versa by means of the continuance of an entity into another entity.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyConversion">cbcm:CompanyConversion</a>
    /// </summary>
    let CompanyConversion = _prefixId.prefix "CompanyConversion"
    /// <summary>
    ///   <para>rdfs:comment : Article 160b - Division means:
    /// a) company being divided, on being dissolved without going into liquidation, transfers all its assets and liabilities to two or more newly formed companies (‘the recipient companies’), in exchange for the issue to the members of the company being divided of securities or shares in the recipient companies and, if any, a cash payment not exceeding 10 % of the nominal value of those securities or shares or, where they have no nominal value, a cash payment not exceeding 10% of the accounting par value of their securities or shares ('full division');
    ///
    /// (b) 	a company being divided transfers part of its assets and liabilities to one or more newly formed companies (‘the recipient companies’), in exchange for the issue to the members of the company being divided of securities or shares in the recipient companies or in the company being divided or in both the recipient companies and in the company being divided, and if any a cash payment not exceeding 10 % of the nominal value of those securities or shares, or in the absence of a nominal value, a cash payment not exceeding 10 % of the accounting par value of their securities or shares (‘partial division’).
    ///
    /// (c) 	a company being divided transfers part of its assets and liabilities to one or more newly formed companies (‘the recipient companies’), in exchange for the issue of securities or shares in the recipient companies to the company being divided (‘division by separation’).</para>
    ///   <para>rdfs:label : Company division</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyDivision">cbcm:CompanyDivision</a>
    /// </summary>
    let CompanyDivision = _prefixId.prefix "CompanyDivision"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://w3id.org/um/cbcm/eu-cm-ontology#CompanyCentralAdministration</para>
    ///   <para>rdfs:label : Company headquarter</para>
    ///   <para>rdfs:comment : The location of a company headquarter</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyHeadQuarter">cbcm:CompanyHeadQuarter</a>
    /// </summary>
    let CompanyHeadQuarter = _prefixId.prefix "CompanyHeadQuarter"
    /// <summary>
    ///   <para>rdfs:label : Company form</para>
    ///   <para>rdfs:comment : Name given to describe the structure of a corporation or business in the different legal orders. For example Limited (Ltd.), Public Limited Company (PLC), Gesellschaft mit beschränkter Haftung (GmbH), Aktiengesellschaft (AG). The company legal form is regulated under national law and grants specific rights and obligations to the company stakeholders (such as shareholders, management &amp; employees).</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyLegalForm">cbcm:CompanyLegalForm</a>
    /// </summary>
    let CompanyLegalForm = _prefixId.prefix "CompanyLegalForm"
    /// <summary>
    ///   <para>rdfs:label : Company merger</para>
    ///   <para>rdfs:comment : ‘merger’ in Directive (EU) 2017/1132 means an operation whereby:
    ///
    /// (a) one or more companies, on being dissolved without going into liquidation, transfer all their assets and liabilities to another existing company, the acquiring company, in exchange for the issue to their members of securities or shares representing the capital of that other company and, if applicable, a cash payment not exceeding 10 % of the nominal value, or, in the absence of a nominal value, of the accounting par value of those securities or shares; or
    ///
    /// (b) two or more companies, on being dissolved without going into liquidation, transfer all their assets and liabilities to a company that they form, the new company, in exchange for the issue to their members of securities or shares representing the capital of that new company and, if applicable, a cash payment not exceeding 10 % of the nominal value, or in the absence of a nominal value, of the accounting par value of those securities or shares; or
    ///
    /// (c) a company, on being dissolved without going into liquidation, transfers all its assets and liabilities to the company holding all the securities or shares representing its capital;"
    ///
    /// (d) one or more companies, on being dissolved without going into liquidation, transfer all their assets and liabilities to another existing company, the acquiring company, without the issue of any new shares by the acquiring company, provided that one person holds directly or indirectly all the shares in the merging companies or the members of the merging companies hold their shares in the same proportion in all merging companies.";</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyMerger">cbcm:CompanyMerger</a>
    /// </summary>
    let CompanyMerger = _prefixId.prefix "CompanyMerger"
    /// <summary>
    ///   <para>rdfs:label : Company mobility document</para>
    ///   <para>rdfs:comment : A legal document which provides information related to, or influencing, a company's mobility within a specific country or across national boundaries.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyMobilityDocument">cbcm:CompanyMobilityDocument</a>
    /// </summary>
    let CompanyMobilityDocument = _prefixId.prefix "CompanyMobilityDocument"
    /// <summary>
    ///   <para>rdfs:label : Registered office</para>
    ///   <para>rdfs:comment : The physical address or location at which the primary business activities of a company are carried out.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyRegisteredOffice">cbcm:CompanyRegisteredOffice</a>
    /// </summary>
    let CompanyRegisteredOffice = _prefixId.prefix "CompanyRegisteredOffice"
    /// <summary>
    ///   <para>rdfs:label : Company seat transfer</para>
    ///   <para>rdfs:comment : The act of changing the location where the company’s business was managed (registered office or headquarters) or the place where that company’s primary business was actually conducted (central administration).</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanySeatTransfer">cbcm:CompanySeatTransfer</a>
    /// </summary>
    let CompanySeatTransfer = _prefixId.prefix "CompanySeatTransfer"
    /// <summary>
    ///   <para>rdfs:label : Company shareholder</para>
    ///   <para>rdfs:comment : An individual, group, or organization that owns one or more shares in a company, and in whose name the share certificate is issued.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyShareholder">cbcm:CompanyShareholder</a>
    /// </summary>
    let CompanyShareholder = _prefixId.prefix "CompanyShareholder"
    /// <summary>
    ///   <para>rdfs:label : Stakeholder in a company</para>
    ///   <para>rdfs:comment : A person, group or organization that has interest or concern in an organization or company in particular. Stakeholders can affect or be affected by the company's actions, objectives and policies.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyStakeholder">cbcm:CompanyStakeholder</a>
    /// </summary>
    let CompanyStakeholder = _prefixId.prefix "CompanyStakeholder"
    /// <summary>
    ///   <para>rdfs:label : Company transaction</para>
    ///   <para>rdfs:comment : An action taken by a company that modifies its corporate structure with a change of control (for e.g. through either a merger, division, conversion or seat transfer in a domestic or cross-border setting). It involves one or more companies, each of which have a company legal form valid in a Member State of the European Union.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CompanyTransaction">cbcm:CompanyTransaction</a>
    /// </summary>
    let CompanyTransaction = _prefixId.prefix "CompanyTransaction"
    /// <summary>
    ///   <para>rdfs:label : Competent authority</para>
    ///   <para>rdfs:comment : The monitoring of the completion and legality of the decision-making process in each company involved in a transaction is carried out by a national authority having jurisdiction over each of those companies. The national authority could be a court, a notary or any other competent authority appointed by the Member State concerned.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CompetentAuthority">cbcm:CompetentAuthority</a>
    /// </summary>
    let CompetentAuthority = _prefixId.prefix "CompetentAuthority"
    /// <summary>
    ///   <para>rdfs:label : Consultation right</para>
    ///   <para>rdfs:comment : The right of employees or their representatives to be consulted and to give advice on a business decision, such as an intended merger/division/conversion/seat transfer.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#ConsultationRight">cbcm:ConsultationRight</a>
    /// </summary>
    let ConsultationRight = _prefixId.prefix "ConsultationRight"
    /// <summary>
    ///   <para>rdfs:label : Company conversion certificate</para>
    ///   <para>rdfs:comment : A document issued by a Competent Authority declaring that the legally required steps of a conversion are completed. The certificate needs to be presented by a company to either be registered in another company registry or to be removed from a company register.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#ConversionCertificate">cbcm:ConversionCertificate</a>
    /// </summary>
    let ConversionCertificate = _prefixId.prefix "ConversionCertificate"
    /// <summary>
    ///   <para>rdfs:label : Company conversion plan</para>
    ///   <para>rdfs:comment : A document providing details of how the conversion of a company will be implemented. Article 86d: The management or administrative organ of the company shall draw up the draft terms of a cross-border conversion. The draft terms of a cross-border conversion shall include at least the particulars listed in article 86d</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#ConversionPlan">cbcm:ConversionPlan</a>
    /// </summary>
    let ConversionPlan = _prefixId.prefix "ConversionPlan"
    /// <summary>
    ///   <para>dcterms:description : A geo-political region that has a distinct and common political governance structure for people that inhabit it for a significant portion of their lives. The majority of people that inhabit such a region are also usually united by common descent, history, culture and language.</para>
    ///   <para>rdfs:label : Country^^xsd:string</para>
    ///   <para>rdfs:comment : A geo-political region that has a distinct and common political governance structure for people that inhabit it for a significant portion of their lives. The majority of people that inhabit such a region are also usually united by common descent, history, culture and language.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#Country">cbcm:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>rdfs:label : Court</para>
    ///   <para>rdfs:comment : Legal forum in which a body of people presided over by a judge, judges, or magistrate, and acting as a tribunal in civil and criminal cases resolve legal disputes.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#Court">cbcm:Court</a>
    /// </summary>
    let Court = _prefixId.prefix "Court"
    /// <summary>
    ///   <para>rdfs:label : Creditor</para>
    ///   <para>rdfs:comment : A person, organization, or government that is owed money. A creditor's claims and the safeguarding of these creditor rights is laid down in the company law of the Member States and EU law.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#Creditor">cbcm:Creditor</a>
    /// </summary>
    let Creditor = _prefixId.prefix "Creditor"
    /// <summary>
    ///   <para>rdfs:label : Creditor decision right</para>
    ///   <para>rdfs:comment : The right of a creditor to influence or take a decision in the context of a transaction.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CreditorDecisionRight">cbcm:CreditorDecisionRight</a>
    /// </summary>
    let CreditorDecisionRight = _prefixId.prefix "CreditorDecisionRight"
    /// <summary>
    ///   <para>rdfs:label : Creditor exit right</para>
    ///   <para>rdfs:comment : The creditors right to be paid out and therefore to exit the company in the context of a transaction.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CreditorExitRight">cbcm:CreditorExitRight</a>
    /// </summary>
    let CreditorExitRight = _prefixId.prefix "CreditorExitRight"
    /// <summary>
    ///   <para>rdfs:label : Creditor information right</para>
    ///   <para>rdfs:comment : The information rights of creditors in the context of a company transaction, which includes for instance access to documents.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CreditorInformationRight">cbcm:CreditorInformationRight</a>
    /// </summary>
    let CreditorInformationRight = _prefixId.prefix "CreditorInformationRight"
    /// <summary>
    ///   <para>rdfs:label : Creditor right</para>
    ///   <para>rdfs:comment : The rights of creditors, which includes debenture holders, vis-a-vis the company that obtained credit from the individual or organisation. Legal safeguards are put in place to ensure that rights of creditors are not negatively affected by a company transaction.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CreditorRight">cbcm:CreditorRight</a>
    /// </summary>
    let CreditorRight = _prefixId.prefix "CreditorRight"
    /// <summary>
    ///   <para>rdfs:label : Creditor security right</para>
    ///   <para>rdfs:comment : Member States shall provide for an adequate system of protection of the interest of creditors, and shall ensure that creditors who are dissatisfied with the safeguards offered in the draft terms of the transaction, as provided for in Article 86d (1) point (f), may apply to the appropriate administrative or judicial authority for adequate safeguards provided that they can credibly demonstrate that due to the transaction the satisfaction of their claims is at stake and that no adequate safeguards have been obtained from the company.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CreditorSecurityRight">cbcm:CreditorSecurityRight</a>
    /// </summary>
    let CreditorSecurityRight = _prefixId.prefix "CreditorSecurityRight"
    /// <summary>
    ///   <para>rdfs:label : Cross-border conversion</para>
    ///   <para>rdfs:comment : A cross-border conversion is an operation through which a company, formed in one country (with the EU/EEA set of countries) is converted into a company governed by the law of another.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderConversion">cbcm:CrossBorderConversion</a>
    /// </summary>
    let CrossBorderConversion = _prefixId.prefix "CrossBorderConversion"
    /// <summary>
    ///   <para>rdfs:label : Cross-border company division</para>
    ///   <para>rdfs:comment : A company which in a process of the cross-border division in case of a full division transfers all its assets and liabilities to two or more companies, or in case of a partial division or division by separation transfers part of its assets and liabilities to one or more companies. The companies involved in the process are located in multiple (two or more) distinct countries.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderDivision">cbcm:CrossBorderDivision</a>
    /// </summary>
    let CrossBorderDivision = _prefixId.prefix "CrossBorderDivision"
    /// <summary>
    ///   <para>rdfs:comment : A cross border merger involves at least one company based in an EU Member State and one company that is registered elsewhere within the European Union and is leading to a universal transfer of assets and liabilities from the merging company to the acquiring company.</para>
    ///   <para>rdfs:label : Cross-border merger</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderMerger">cbcm:CrossBorderMerger</a>
    /// </summary>
    let CrossBorderMerger = _prefixId.prefix "CrossBorderMerger"

    /// <summary>
    ///   <para>rdfs:label : Cross-border company merger by acquisition</para>
    ///   <para>rdfs:comment : Article 89: The operation whereby one or more companies are wound up without going into liquidation and transfer to another all their assets and liabilities in exchange for the issue to the shareholders of the company or companies being acquired of shares in the acquiring company and a cash payment, if any, not exceeding 10 % of the nominal value of the shares so issued or, where they have no nominal value, of their accounting par value. Companies involved come from two or more distinct countries.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderMergerByAcquisition">cbcm:CrossBorderMergerByAcquisition</a>
    /// </summary>
    let CrossBorderMergerByAcquisition =
        _prefixId.prefix "CrossBorderMergerByAcquisition"

    /// <summary>
    ///   <para>rdfs:label : Cross-border merger into a new company</para>
    ///   <para>rdfs:comment : Article 90: the operation whereby several companies are wound up without going into liquidation and transfer to a company that they set up all their assets and liabilities in exchange for the issue to their shareholders of shares in the new company and a cash payment, if any, not exceeding 10 % of the nominal value of the shares so issued or, where they have no nominal value, of their accounting par value. Companies involved come from two or more distinct countries.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderMergerIntoNewCompany">cbcm:CrossBorderMergerIntoNewCompany</a>
    /// </summary>
    let CrossBorderMergerIntoNewCompany =
        _prefixId.prefix "CrossBorderMergerIntoNewCompany"

    /// <summary>
    ///   <para>rdfs:label : Cross-border company seat transfer</para>
    ///   <para>rdfs:comment : The act of changing the location where the company’s business was managed (registered office or headquarters) or the place where that company’s primary business was actually conducted (central administration), across national boundaries.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#CrossBorderSeatTransfer">cbcm:CrossBorderSeatTransfer</a>
    /// </summary>
    let CrossBorderSeatTransfer = _prefixId.prefix "CrossBorderSeatTransfer"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Data curation activity</para>
    ///   <para>rdfs:comment : A data curation activity represents a researcher's involvement in annotating cross border transactions</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#DataCurationActivity">cbcm:DataCurationActivity</a>
    /// </summary>
    let DataCurationActivity = _prefixId.prefix "DataCurationActivity"
    /// <summary>
    ///   <para>rdfs:label : Shareholder decision right</para>
    ///   <para>rdfs:comment : The shareholders can take a number of decisions affecting the company, such as amending the company's articles of association, appointing or dismissing board members and to approve important transactions (e.g. mergers, divisions and conversions/seat transfers). These are taken through a shareholder resolution.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#DecisionRight">cbcm:DecisionRight</a>
    /// </summary>
    let DecisionRight = _prefixId.prefix "DecisionRight"
    /// <summary>
    ///   <para>rdfs:label : Company division certificate</para>
    ///   <para>rdfs:comment : A document issued by a Competent Authority declaring that the legally required steps of a division are completed. The certificate needs to be presented by a company to either be registered (or register a newly established emerging/recipient company) in another company registry or to be removed from a company register.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#DivisionCertificate">cbcm:DivisionCertificate</a>
    /// </summary>
    let DivisionCertificate = _prefixId.prefix "DivisionCertificate"
    /// <summary>
    ///   <para>rdfs:label : Company division plan</para>
    ///   <para>rdfs:comment : The management or administrative organ of the company shall draw up the draft terms of a division. The draft terms of a division shall include at least the particulars listed in article 160d.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#DivisionPlan">cbcm:DivisionPlan</a>
    /// </summary>
    let DivisionPlan = _prefixId.prefix "DivisionPlan"
    /// <summary>
    ///   <para>rdfs:label : Company mobility document repository</para>
    ///   <para>rdfs:comment : A digital document repository containing documents related to company mobility.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#DocumentRepository">cbcm:DocumentRepository</a>
    /// </summary>
    let DocumentRepository = _prefixId.prefix "DocumentRepository"
    /// <summary>
    ///   <para>rdfs:label : Domestic company conversion</para>
    ///   <para>rdfs:comment : A domestic conversion is an operation through which a company's form is converted into a another while still remaining governed by the same law as the original company. For instance, the modification of a company's form from a public to a private limited company.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticConversion">cbcm:DomesticConversion</a>
    /// </summary>
    let DomesticConversion = _prefixId.prefix "DomesticConversion"
    /// <summary>
    ///   <para>rdfs:label : Company domestic division</para>
    ///   <para>rdfs:comment : A company which in a process of the domestic division - in case of a full division - transfers all its assets and liabilities to two or more companies, or - in case of a partial division or division by separation - transfers part of its assets and liabilities to one or more companies. All companies involved in the process are located in a single country.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticDivision">cbcm:DomesticDivision</a>
    /// </summary>
    let DomesticDivision = _prefixId.prefix "DomesticDivision"
    /// <summary>
    ///   <para>rdfs:label : Company domestic merger</para>
    ///   <para>rdfs:comment : A domestic merger involves at least two companies based in the same EU Member State and is leading to a universal transfer of assets and liabilities from the merging company to the acquiring company.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticMerger">cbcm:DomesticMerger</a>
    /// </summary>
    let DomesticMerger = _prefixId.prefix "DomesticMerger"
    /// <summary>
    ///   <para>rdfs:label : Domestic company merger by acquisition</para>
    ///   <para>rdfs:comment : Article 89: The operation whereby one or more companies are wound up without going into liquidation and transfer to another all their assets and liabilities in exchange for the issue to the shareholders of the company or companies being acquired of shares in the acquiring company and a cash payment, if any, not exceeding 10 % of the nominal value of the shares so issued or, where they have no nominal value, of their accounting par value. All companies involved are from a single country.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticMergerByAcquisition">cbcm:DomesticMergerByAcquisition</a>
    /// </summary>
    let DomesticMergerByAcquisition = _prefixId.prefix "DomesticMergerByAcquisition"
    /// <summary>
    ///   <para>rdfs:label : Domestic merger into a new company</para>
    ///   <para>rdfs:comment : Article 90: the operation whereby several companies are wound up without going into liquidation and transfer to a company that they set up all their assets and liabilities in exchange for the issue to their shareholders of shares in the new company and a cash payment, if any, not exceeding 10 % of the nominal value of the shares so issued or, where they have no nominal value, of their accounting par value. All companies involved are from a single country.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticMergerIntoNewCompany">cbcm:DomesticMergerIntoNewCompany</a>
    /// </summary>
    let DomesticMergerIntoNewCompany = _prefixId.prefix "DomesticMergerIntoNewCompany"
    /// <summary>
    ///   <para>rdfs:label : Domestic company seat transfer</para>
    ///   <para>rdfs:comment : The act of changing the location where the company’s business was managed (registered office or headquarters) or the place where that company’s primary business was actually conducted (central administration), within a specific country.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#DomesticSeatTransfer">cbcm:DomesticSeatTransfer</a>
    /// </summary>
    let DomesticSeatTransfer = _prefixId.prefix "DomesticSeatTransfer"
    /// <summary>
    ///   <para>rdfs:label : European Economic Area country</para>
    ///   <para>rdfs:comment : Created in 1994, the European Economic Area (EEA) combines the countries of the European Union (EU) and member countries of the European Free Trade Association (EFTA) to facilitate participation in the European Market trade and movement without having to apply to be one of the EU member countries</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#EEACountry">cbcm:EEACountry</a>
    /// </summary>
    let EEACountry = _prefixId.prefix "EEACountry"
    /// <summary>
    ///   <para>dcterms:description : A country which forms part of the European Union. The European Union is a conglomeration of European countries whose governance structures agree to abide with common political and economic criteria to improve efficiency of goods and services trading as well as movement and migration of inhabitants between these countries</para>
    ///   <para>rdfs:label : EU country^^xsd:string</para>
    ///   <para>rdfs:comment : A country which forms part of the European Union. The European Union is a conglomeration of European countries whose governance structures agree to abide with common political and economic criteria to improve efficiency of goods and services trading as well as movement and migration of inhabitants between these countries</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#EUCountry">cbcm:EUCountry</a>
    /// </summary>
    let EUCountry = _prefixId.prefix "EUCountry"
    /// <summary>
    ///   <para>rdfs:label : Emerging company</para>
    ///   <para>rdfs:comment : A company being divided transfers part of its assets and liabilities to one or more newly formed companies, which are the recipient companies in a (cross-border) division.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#EmergingCompany">cbcm:EmergingCompany</a>
    /// </summary>
    let EmergingCompany = _prefixId.prefix "EmergingCompany"
    /// <summary>
    ///   <para>rdfs:label : Company employee</para>
    ///   <para>rdfs:comment : The workforce of a company. An employee is a party to an employment relationship characterised as a contract of employment (or contract of service) between the employer and employee. However, this is only one of several different legal formulations of the concept of ‘worker’ in the EU which differ between Member States.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#Employee">cbcm:Employee</a>
    /// </summary>
    let Employee = _prefixId.prefix "Employee"
    /// <summary>
    ///   <para>rdfs:label : Financial service authority</para>
    ///   <para>rdfs:comment : A body that regulates the financial services industry in a country (e.g. the UK), including most financial services markets, exchanges and firms.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#FinancialServiceAuthority">cbcm:FinancialServiceAuthority</a>
    /// </summary>
    let FinancialServiceAuthority = _prefixId.prefix "FinancialServiceAuthority"
    /// <summary>
    ///   <para>dcterms:description : A spatial region on earth whose boundaries are determined by a combination of geographical, ecological, climatic, socio-economic and political criteria.</para>
    ///   <para>rdfs:label : Geo-political region^^xsd:string</para>
    ///   <para>rdfs:comment : A spatial region on earth whose boundaries are determined by a combination of geographical, ecological, climatic, socio-economic and political criteria.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#GeoPoliticalRegion">cbcm:GeoPoliticalRegion</a>
    /// </summary>
    let GeoPoliticalRegion = _prefixId.prefix "GeoPoliticalRegion"
    /// <summary>
    ///   <para>rdfs:label : Global ultimate owner</para>
    ///   <para>rdfs:comment : A global ultimate owner (GUO) is the individual or entity at the top of the corporate ownership structure.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#GlobalUltimateOwner">cbcm:GlobalUltimateOwner</a>
    /// </summary>
    let GlobalUltimateOwner = _prefixId.prefix "GlobalUltimateOwner"
    /// <summary>
    ///   <para>rdfs:label : Impact on employment information right</para>
    ///   <para>rdfs:comment : The right of employees or their representatives to be informed on the likely repercussions of the cross-border transaction on employment, which includes the dismissal as well as the hiring of employees or relocation of work. See for instance article 122 of Directive 2017/1132.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#ImpactOnEmploymentRight">cbcm:ImpactOnEmploymentRight</a>
    /// </summary>
    let ImpactOnEmploymentRight = _prefixId.prefix "ImpactOnEmploymentRight"
    /// <summary>
    ///   <para>rdfs:label : Independent expert</para>
    ///   <para>rdfs:comment : An Independent Expert provides impartial advice to shareholders and other company stakeholders on the fairness and/or reasonableness of a transaction.  A company may be required to commission an Independent Expert Report (IER) in the case of a (cross-border) merger, division or conversion.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#IndependentExpert">cbcm:IndependentExpert</a>
    /// </summary>
    let IndependentExpert = _prefixId.prefix "IndependentExpert"
    /// <summary>
    ///   <para>rdfs:label : Report by an independent expert</para>
    ///   <para>rdfs:comment : Article 86g and 160i: Member States must ensure that an independent expert examines the draft terms of the transaction and draws up a report intended for members which is made available to them not less than one month before the date of the general meeting. Depending on the law of Member States, the expert may be a natural person or a legal person. The report must assess the cash compensation proposed and valuation method.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#IndependentExpertReport">cbcm:IndependentExpertReport</a>
    /// </summary>
    let IndependentExpertReport = _prefixId.prefix "IndependentExpertReport"
    /// <summary>
    ///   <para>rdfs:label : Information right</para>
    ///   <para>rdfs:comment : The right of employees or their representatives to be informed and to receive any documents necessary for the exercise of their consultation and board-level employee representation rights in the context of an intended merger/division/conversion/seat transfer.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#InformationRight">cbcm:InformationRight</a>
    /// </summary>
    let InformationRight = _prefixId.prefix "InformationRight"
    /// <summary>
    ///   <para>rdfs:label : Interim account</para>
    ///   <para>rdfs:comment : Interim accounts are accounts that are published during a company's financial year and that show the financial situation on a given accounting date.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#InterimAccount">cbcm:InterimAccount</a>
    /// </summary>
    let InterimAccount = _prefixId.prefix "InterimAccount"
    /// <summary>
    ///   <para>rdfs:label : Management board</para>
    ///   <para>rdfs:comment : The group of persons comprising the governing body of the legal entity that is entrusted with the decision-making in the company. It is also called Executive Board in a one-tier board system.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagementBoard">cbcm:ManagementBoard</a>
    /// </summary>
    let ManagementBoard = _prefixId.prefix "ManagementBoard"
    /// <summary>
    ///   <para>rdfs:label : Management report</para>
    ///   <para>rdfs:comment : A report drawn up by the company's management on the intended transaction, laying out the main features of the transactions and its consequences.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagementReport">cbcm:ManagementReport</a>
    /// </summary>
    let ManagementReport = _prefixId.prefix "ManagementReport"
    /// <summary>
    ///   <para>rdfs:label : Manager</para>
    ///   <para>rdfs:comment : A person or group of persons that are responsible for overseeing the operations of a company.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#Manager">cbcm:Manager</a>
    /// </summary>
    let Manager = _prefixId.prefix "Manager"
    /// <summary>
    ///   <para>rdfs:label : Manager decision right</para>
    ///   <para>rdfs:comment : The right of the board of management or individual managers to take decisions or to not take a decision in the context of a transaction. These are in the form of a board resolution.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagerDecisionRight">cbcm:ManagerDecisionRight</a>
    /// </summary>
    let ManagerDecisionRight = _prefixId.prefix "ManagerDecisionRight"
    /// <summary>
    ///   <para>rdfs:label : Manager exit right</para>
    ///   <para>rdfs:comment : The right of a manager or the board of management to resign and therefore exit a company.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagerExitRight">cbcm:ManagerExitRight</a>
    /// </summary>
    let ManagerExitRight = _prefixId.prefix "ManagerExitRight"
    /// <summary>
    ///   <para>rdfs:label : Manager information right</para>
    ///   <para>rdfs:comment : The right of a manager to information and access to documents that he or she has in accordance with national or European company law.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagerInformationRight">cbcm:ManagerInformationRight</a>
    /// </summary>
    let ManagerInformationRight = _prefixId.prefix "ManagerInformationRight"
    /// <summary>
    ///   <para>rdfs:label : Manager right</para>
    ///   <para>rdfs:comment : The rights of members of the management in the context of a company transaction.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#ManagerRight">cbcm:ManagerRight</a>
    /// </summary>
    let ManagerRight = _prefixId.prefix "ManagerRight"
    /// <summary>
    ///   <para>rdfs:label : Member State Official Journal^^xsd:string</para>
    ///   <para>rdfs:comment : The national gazette or record in a particular Member State. In the official journal companies publish company transaction notices in order to inform concerned stakeholders and interested parties.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#MemberStateOfficialJournal">cbcm:MemberStateOfficialJournal</a>
    /// </summary>
    let MemberStateOfficialJournal = _prefixId.prefix "MemberStateOfficialJournal"
    /// <summary>
    ///   <para>rdfs:label : Company merger certificate</para>
    ///   <para>rdfs:comment : A document issued by a Competent Authority declaring that the legally required steps of a merger are completed. The certificate needs to be presented by a company to either be registered in another company registry or to be removed from a company register (depending on the company being the merging or acquiring company).</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#MergerCertificate">cbcm:MergerCertificate</a>
    /// </summary>
    let MergerCertificate = _prefixId.prefix "MergerCertificate"
    /// <summary>
    ///   <para>rdfs:label : Company merger plan</para>
    ///   <para>rdfs:comment : Article 91: The administrative or management bodies of the merging companies shall draw up draft terms of merger in writing by specifying at least the elements mentioned in article 91.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#MergerPlan">cbcm:MergerPlan</a>
    /// </summary>
    let MergerPlan = _prefixId.prefix "MergerPlan"
    /// <summary>
    ///   <para>rdfs:label : Merging company</para>
    ///   <para>rdfs:comment : Merging Company means the dissolving company that is being acquired by another (acquiring) company in the process of a transaction. In the context of company mobility, this means a universal transfer of assets and liabilities from the merging to the acquiring company (see article 131 of Directive 2017/1132).</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#MergingCompany">cbcm:MergingCompany</a>
    /// </summary>
    let MergingCompany = _prefixId.prefix "MergingCompany"
    /// <summary>
    ///   <para>rdfs:label : National registry</para>
    ///   <para>rdfs:comment : A national registry is a business registry in a Member State, which includes information on the population of companies in the jurisdiction and holds inter alia data on registration numbers, place of registration, notices and transaction documents in the national registry repository.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#NationalRegistry">cbcm:NationalRegistry</a>
    /// </summary>
    let NationalRegistry = _prefixId.prefix "NationalRegistry"
    /// <summary>
    ///   <para>rdfs:label : National registry repository</para>
    ///   <para>rdfs:comment : The digital repository in which documents published in the official journal or by by the national registry (on behalf of a company) are kept as well as related documents. In some EU Member States, this repository is overlapping or identical with the Official Journal Repository.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#NationalRegistryRepository">cbcm:NationalRegistryRepository</a>
    /// </summary>
    let NationalRegistryRepository = _prefixId.prefix "NationalRegistryRepository"
    /// <summary>
    ///   <para>rdfs:label : Non-EEA country</para>
    ///   <para>rdfs:comment : A country which does not belong to the European Economic Area (EEA).</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#NonEEACountry">cbcm:NonEEACountry</a>
    /// </summary>
    let NonEEACountry = _prefixId.prefix "NonEEACountry"
    /// <summary>
    ///   <para>rdfs:label : Non-EU country</para>
    ///   <para>rdfs:comment : A country that does not officially belong to the EU conglomeration</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#NonEUCountry">cbcm:NonEUCountry</a>
    /// </summary>
    let NonEUCountry = _prefixId.prefix "NonEUCountry"
    /// <summary>
    ///   <para>rdfs:label : Notary</para>
    ///   <para>rdfs:comment : A person authorized to perform certain legal formalities, especially to draw up or certify contracts, deeds, and other documents for use in other jurisdictions.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#Notary">cbcm:Notary</a>
    /// </summary>
    let Notary = _prefixId.prefix "Notary"
    /// <summary>
    ///   <para>rdfs:label : Official journal</para>
    ///   <para>rdfs:comment : The official gazette of record for the European Union or national gazette of record of a Member State. In the official journal companies publish transaction notices in order to inform concerned stakeholders and interested parties.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#OfficialJournal">cbcm:OfficialJournal</a>
    /// </summary>
    let OfficialJournal = _prefixId.prefix "OfficialJournal"
    /// <summary>
    ///   <para>rdfs:label : Official journal publication</para>
    ///   <para>rdfs:comment : Publication of a legally valid record or act in an official national gazette to inform stakeholders.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#OfficialJournalPublication">cbcm:OfficialJournalPublication</a>
    /// </summary>
    let OfficialJournalPublication = _prefixId.prefix "OfficialJournalPublication"
    /// <summary>
    ///   <para>rdfs:label : Official journal repository</para>
    ///   <para>rdfs:comment : The digital repository in which documents published in the official journal are kept as well as related documents. In some EU Member States, this repository is overlapping or identical with the National Registry Repository.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#OfficialJournalRepository">cbcm:OfficialJournalRepository</a>
    /// </summary>
    let OfficialJournalRepository = _prefixId.prefix "OfficialJournalRepository"
    /// <summary>
    ///   <para>rdfs:label : Organisation</para>
    ///   <para>rdfs:comment : Represents a collection of people organized together into a community or other social, commercial or political structure. The group has some common purpose or reason for existence which goes beyond the set of people belonging to it and can act as an Agent. Organizations are often decomposable into hierarchical structures.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#Organisation">cbcm:Organisation</a>
    /// </summary>
    let Organisation = _prefixId.prefix "Organisation"
    /// <summary>
    ///   <para>rdfs:label : Organisational unit</para>
    ///   <para>rdfs:comment : A division of a large organization such as a government, university, or business, dealing with a specific area of activity.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#OrganisationalUnit">cbcm:OrganisationalUnit</a>
    /// </summary>
    let OrganisationalUnit = _prefixId.prefix "OrganisationalUnit"
    /// <summary>
    ///   <para>rdfs:label : Original company</para>
    ///   <para>rdfs:comment : An original company, in the context of a (cross-border) division, means a company which - in case of a full division - transfers all its assets and liabilities to two or more companies, or - in case of a partial division or division by separation - transfers part of its assets and liabilities to one or more companies.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#OriginalCompany">cbcm:OriginalCompany</a>
    /// </summary>
    let OriginalCompany = _prefixId.prefix "OriginalCompany"
    /// <summary>
    ///   <para>rdfs:label : Parent company</para>
    ///   <para>rdfs:comment : A parent company is a company that has a controlling interest in another company, the subsidiary company, giving it control of its operations through a majority stock-ownership, decisive control over management appointments and therefore over the decision-making process. In the absence of a natural person as ultimate beneficial owner, the highest parent company in a chain of companies is the global ultimate owner.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#ParentCompany">cbcm:ParentCompany</a>
    /// </summary>
    let ParentCompany = _prefixId.prefix "ParentCompany"
    /// <summary>
    ///   <para>dcterms:description : A person is an object that has certain capacities or attributes constituting personhood. A human being that has existed or continues to exist in the world (either deceased or living). Fictional human beings cannot be  instances of this class.</para>
    ///   <para>rdfs:label : Person</para>
    ///   <para>rdfs:comment : A person is an object that has certain capacities or attributes constituting personhood. A human being that has existed or continues to exist in the world (either deceased or living). Fictional human beings cannot be  instances of this class.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#Person">cbcm:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : Company pre-conversion certificate</para>
    ///   <para>rdfs:comment : Article 86m: a pre-conversion certificate attests compliance with all the relevant conditions and the proper completion of all procedures and formalities in the departure Member State.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#PreConversionCertificate">cbcm:PreConversionCertificate</a>
    /// </summary>
    let PreConversionCertificate = _prefixId.prefix "PreConversionCertificate"
    /// <summary>
    ///   <para>rdfs:label : Company pre-division certificate</para>
    ///   <para>rdfs:comment : Article 160o: a pre-division certificate attests compliance with all the relevant conditions and the proper completion of all procedures and formalities in the Member State concerned.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#PreDivisionCertificate">cbcm:PreDivisionCertificate</a>
    /// </summary>
    let PreDivisionCertificate = _prefixId.prefix "PreDivisionCertificate"
    /// <summary>
    ///   <para>rdfs:label : Company pre-merger certificate</para>
    ///   <para>rdfs:comment : Article 127: a pre-merger certificate attests compliance with all the relevant conditions and the proper completion of all procedures and formalities in the Member State of the merging company.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#PreMergerCertificate">cbcm:PreMergerCertificate</a>
    /// </summary>
    let PreMergerCertificate = _prefixId.prefix "PreMergerCertificate"
    /// <summary>
    ///   <para>dcterms:description : A procedure is a process that attempts to achieve one or more objectives by following an established set of actions.</para>
    ///   <para>rdfs:label : Procedure^^xsd:string</para>
    ///   <para>rdfs:comment : A procedure is a process that attempts to achieve one or more objectives by following an established set of actions.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#Procedure">cbcm:Procedure</a>
    /// </summary>
    let Procedure = _prefixId.prefix "Procedure"
    /// <summary>
    ///   <para>rdfs:label : Recipient company</para>
    ///   <para>rdfs:comment : A company being divided transfers part of its assets and liabilities to one or more newly formed companies, which are the recipient companies in a (cross-border) division.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#RecipientCompany">cbcm:RecipientCompany</a>
    /// </summary>
    let RecipientCompany = _prefixId.prefix "RecipientCompany"
    /// <summary>
    ///   <para>rdfs:label : Resolution</para>
    ///   <para>rdfs:comment : A document detailing a decision made by an individual or group of natural or legal persons. This can be a decision concerning the restructuring of a company by its shareholders.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#Resolution">cbcm:Resolution</a>
    /// </summary>
    let Resolution = _prefixId.prefix "Resolution"
    /// <summary>
    ///   <para>rdfs:label : Societas Europaea (SE) type</para>
    ///   <para>rdfs:comment : Variable indicating the SE-establishment mode: by merger, conversion, holding-SE, subsidiary-SE or unsure (cases)</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#SEType">cbcm:SEType</a>
    /// </summary>
    let SEType = _prefixId.prefix "SEType"
    /// <summary>
    ///   <para>rdfs:label : Company seat transfer plan</para>
    ///   <para>rdfs:comment : The management or administrative organ of the company draws up the draft terms of a cross-border seat transfer. The draft terms of a cross-border seat transfer must include at least the particulars specified under national law.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#SeatTransferPlan">cbcm:SeatTransferPlan</a>
    /// </summary>
    let SeatTransferPlan = _prefixId.prefix "SeatTransferPlan"
    /// <summary>
    ///   <para>rdfs:label : Shareholder exit right</para>
    ///   <para>rdfs:comment : The right of a shareholder to exit the company by being bought out.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#ShareholderExitRight">cbcm:ShareholderExitRight</a>
    /// </summary>
    let ShareholderExitRight = _prefixId.prefix "ShareholderExitRight"
    /// <summary>
    ///   <para>rdfs:label : Shareholder information right</para>
    ///   <para>rdfs:comment : It is particularly important that the shareholders of the companies involved in a transaction be kept adequately informed in an objective manner, and that their rights be suitably protected. This includes for instance the availability of documents for inspection by shareholders (e.g. article 97 of Directive 2017/1132).</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#ShareholderInformationRight">cbcm:ShareholderInformationRight</a>
    /// </summary>
    let ShareholderInformationRight = _prefixId.prefix "ShareholderInformationRight"
    /// <summary>
    ///   <para>rdfs:label : Shareholder resolution</para>
    ///   <para>rdfs:comment : a shareholder resolution is a proposal submitted by shareholders for a vote at the company's shareholder meeting.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#ShareholderResolution">cbcm:ShareholderResolution</a>
    /// </summary>
    let ShareholderResolution = _prefixId.prefix "ShareholderResolution"
    /// <summary>
    ///   <para>rdfs:label : Shareholder right</para>
    ///   <para>rdfs:comment : The rights of shareholders of a company in the context of a transaction. Often, shreholder resolutions are used to effectuate shareholder rights. Many rights are laid down in the so-called Shareholder Rights Directive.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#ShareholderRight">cbcm:ShareholderRight</a>
    /// </summary>
    let ShareholderRight = _prefixId.prefix "ShareholderRight"
    /// <summary>
    ///   <para>rdfs:label : Social right</para>
    ///   <para>rdfs:comment : Social rights, as opposed to rights arising from natural law, are rights for legal entities that entitle them to certain levels of societal living conditions (e.g. the right to housing, to food, to health care etc.)</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#SocialRight">cbcm:SocialRight</a>
    /// </summary>
    let SocialRight = _prefixId.prefix "SocialRight"
    /// <summary>
    ///   <para>rdfs:label : Cross-border merger into a new company with a Societas Europaea form</para>
    ///   <para>rdfs:comment : This is a cross-border merger where two or more companies from different Member States merge into a new company that has a special legal form called a Societas Europaea (SE) which allows the behavior of this new company to be regulated under European Law (rather than national law).</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#SocietasEuropaeaMerger">cbcm:SocietasEuropaeaMerger</a>
    /// </summary>
    let SocietasEuropaeaMerger = _prefixId.prefix "SocietasEuropaeaMerger"
    /// <summary>
    ///   <para>rdfs:label : Society</para>
    ///   <para>rdfs:comment : The society at large is a stakeholder in a company through, inter alia, the government and its agencies, suppliers, customers, trade unions and the communities from which the business draws its resources.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#Society">cbcm:Society</a>
    /// </summary>
    let Society = _prefixId.prefix "Society"
    /// <summary>
    ///   <para>rdfs:label : Special negotiating body</para>
    ///   <para>rdfs:comment : The Special Negotiation Body (SNB) or Special Negotiating Body is an organisation that represents the employees of companies in negotiations with the company authorities in order to reach a written agreement on the involvement of employees in company transactions.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#SpecialNegotiationBody">cbcm:SpecialNegotiationBody</a>
    /// </summary>
    let SpecialNegotiationBody = _prefixId.prefix "SpecialNegotiationBody"

    /// <summary>
    ///   <para>rdfs:label : Special negotiating body agreement</para>
    ///   <para>rdfs:comment : A written agreement concerning the involvement of employees in company transactions. Special Negotiating Body (SNB) organisation represents employees in the negotiation of the terms of this agreement with the company authorities. The agreement must be reached in accordance with the EU Company Law Directive and is laid down in the SNB-agreement.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#SpecialNegotiationBodyAgreement">cbcm:SpecialNegotiationBodyAgreement</a>
    /// </summary>
    let SpecialNegotiationBodyAgreement =
        _prefixId.prefix "SpecialNegotiationBodyAgreement"

    /// <summary>
    ///   <para>rdfs:label : Subsidiary company</para>
    ///   <para>rdfs:comment : A subsidiary, subsidiary company or daughter company is a company that is owned or controlled by another company, which is called the parent company, parent, or holding company.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#SubsidiaryCompany">cbcm:SubsidiaryCompany</a>
    /// </summary>
    let SubsidiaryCompany = _prefixId.prefix "SubsidiaryCompany"
    /// <summary>
    ///   <para>rdfs:label : SupervisoryAuthority</para>
    ///   <para>rdfs:comment : An individual authority established by its member state to supervise the compliance with a specific regulation.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#SupervisoryAuthority">cbcm:SupervisoryAuthority</a>
    /// </summary>
    let SupervisoryAuthority = _prefixId.prefix "SupervisoryAuthority"
    /// <summary>
    ///   <para>rdfs:label : Supervisory board</para>
    ///   <para>rdfs:comment : A supervisory board must approve of major business decisions. It is a group of individuals chosen by the shareholders - and employee representatives in board-level employee representation systems - of a company to promote their interests through the governance of the company and to hire and supervise the management board. It is also called non-executive board in a one-tier board system.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#SupervisoryBoard">cbcm:SupervisoryBoard</a>
    /// </summary>
    let SupervisoryBoard = _prefixId.prefix "SupervisoryBoard"
    /// <summary>
    ///   <para>rdfs:label : Tax authority</para>
    ///   <para>rdfs:comment : Tax Authority means any governmental authority having jurisdiction over the assessment, determination, collection or imposition of any tax.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#TaxAuthority">cbcm:TaxAuthority</a>
    /// </summary>
    let TaxAuthority = _prefixId.prefix "TaxAuthority"
    /// <summary>
    ///   <para>rdfs:label : Company transaction certificate</para>
    ///   <para>rdfs:comment : A document issued by a Competent Authority declaring that certain steps of the transaction are completed.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#TransactionCertificate">cbcm:TransactionCertificate</a>
    /// </summary>
    let TransactionCertificate = _prefixId.prefix "TransactionCertificate"
    /// <summary>
    ///   <para>rdfs:label : Transaction document</para>
    ///   <para>rdfs:comment : Document required by law to document the step of a company transaction or an agreement made between stakeholders involved in the transaction that are either printed, inserted and mailed, or electronically presented.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#TransactionDocument">cbcm:TransactionDocument</a>
    /// </summary>
    let TransactionDocument = _prefixId.prefix "TransactionDocument"
    /// <summary>
    ///   <para>rdfs:label : Company transaction notice</para>
    ///   <para>rdfs:comment : A written notice, published in an official journal of a Member State of the EU and/or the European Official Journal indicating the intention to engage in a transaction and which informs  the members, creditors and representatives of the employees of the company, or, where there are no such representatives, the employees themselves of said transaction.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#TransactionNotice">cbcm:TransactionNotice</a>
    /// </summary>
    let TransactionNotice = _prefixId.prefix "TransactionNotice"
    /// <summary>
    ///   <para>rdfs:label : Transaction right</para>
    ///   <para>rdfs:comment : A legal right of a legal entity involved in the process of a company transaction. A legal right here refers to the entitlement of a person to be allowed to perform an activity, or to possess or obtain access to an object.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#TransactionRight">cbcm:TransactionRight</a>
    /// </summary>
    let TransactionRight = _prefixId.prefix "TransactionRight"

    /// <summary>
    ///   <para>rdfs:label : Transfer of company central administration</para>
    ///   <para>rdfs:comment : Act of modifying the location where the company’s business was managed or the place where that company’s business was actually conducted.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#TransferOfCentralAdministration">cbcm:TransferOfCentralAdministration</a>
    /// </summary>
    let TransferOfCentralAdministration =
        _prefixId.prefix "TransferOfCentralAdministration"

    /// <summary>
    ///   <para>rdfs:label : Transfer of company registered office</para>
    ///   <para>rdfs:comment : The act of changing the registered office, which is the official address of an incorporated company, association or any other legal entity.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#TransferOfRegisteredOffice">cbcm:TransferOfRegisteredOffice</a>
    /// </summary>
    let TransferOfRegisteredOffice = _prefixId.prefix "TransferOfRegisteredOffice"
    /// <summary>
    ///   <para>rdfs:label : Transferring company</para>
    ///   <para>rdfs:comment : Transferring Company means the company transferring its assets and liabilities to a recipient company.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#TransferringCompany">cbcm:TransferringCompany</a>
    /// </summary>
    let TransferringCompany = _prefixId.prefix "TransferringCompany"
    /// <summary>
    ///   <para>rdfs:label : Ultimate beneficial owner</para>
    ///   <para>rdfs:comment : Ultimate Beneficial owner refers to the natural person(s) who ultimately owns or controls a customer and/or the natural person on whose behalf a transaction is being conducted. It also includes those persons who exercise ultimate effective control over a legal person or arrangement.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#UltimateBeneficialOwner">cbcm:UltimateBeneficialOwner</a>
    /// </summary>
    let UltimateBeneficialOwner = _prefixId.prefix "UltimateBeneficialOwner"
    /// <summary>
    ///   <para>rdfs:comment : The exercise of employee participation through the representation of employees vis-a-vis the management of a company. The works council is a shop-floor level representation mechanism with information, consultation and veto-rights - depending on the extent of rights given in a Member State - and also at EU level through European Works Councils.</para>
    ///   <para>rdfs:label : Employee works council</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#WorksCouncil">cbcm:WorksCouncil</a>
    /// </summary>
    let WorksCouncil = _prefixId.prefix "WorksCouncil"

    /// <summary>
    ///   <para>rdfs:label : AC Employees count at transaction</para>
    ///   <para>rdfs:comment : number of employees of the acquiring company - at the moment of the transaction</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#acEmploymentFigureAtTransaction">cbcm:acEmploymentFigureAtTransaction</a>
    /// </summary>
    let acEmploymentFigureAtTransaction =
        _prefixId.prefix "acEmploymentFigureAtTransaction"

    /// <summary>
    ///   <para>rdfs:label : Last employment figure for the acquiring company</para>
    ///   <para>rdfs:comment : The last available annual employment figure for the acquiring company</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#acLastEmploymentFigure">cbcm:acLastEmploymentFigure</a>
    /// </summary>
    let acLastEmploymentFigure = _prefixId.prefix "acLastEmploymentFigure"
    /// <summary>
    ///   <para>rdfs:label : Total EU employees</para>
    ///   <para>rdfs:comment : total number of employees of the acquiring company in the EU at the moment of the transaction</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#acTotalEUEmploymentFigure">cbcm:acTotalEUEmploymentFigure</a>
    /// </summary>
    let acTotalEUEmploymentFigure = _prefixId.prefix "acTotalEUEmploymentFigure"
    /// <summary>
    ///   <para>rdfs:label : AC Last employment figure year</para>
    ///   <para>rdfs:comment : The year the last annual employment figure was obtained for acquiring companies</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#acYearEmploymentFigure">cbcm:acYearEmploymentFigure</a>
    /// </summary>
    let acYearEmploymentFigure = _prefixId.prefix "acYearEmploymentFigure"
    /// <summary>
    ///   <para>cbcm:example : (applicableTo creditorRight1 person1)</para>
    ///   <para>rdfs:label : applicable to</para>
    ///   <para>rdfs:comment : (applicableTo ?ENTITY1 ?ENTITY2) means that some legal right ?ENTITY1 is awarded or assigned to a particular person or agent ?ENTITY2.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#applicableTo">cbcm:applicableTo</a>
    /// </summary>
    let applicableTo = _prefixId.prefix "applicableTo"
    let austria = _prefixId.prefix "austria"
    /// <summary>
    ///   <para>cbcm:example : (authoredBy independentExpertReport1 independentExpert1)^^xsd:string</para>
    ///   <para>rdfs:label : authored by</para>
    ///   <para>rdfs:comment : (authoredBy ?ENTITY1 ?ENTITY2) means that ?ENTITY1 is an instance of a publication that is created primarily by the entity referred to by ?ENTITY2.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#authoredBy">cbcm:authoredBy</a>
    /// </summary>
    let authoredBy = _prefixId.prefix "authoredBy"
    /// <summary>
    ///   <para>rdfs:label : authors</para>
    ///   <para>rdfs:comment : (authors ?ENTITY1 ?ENTITY2) means that (authoredBy ?ENTITY2 ?ENTITY1)</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#authors">cbcm:authors</a>
    /// </summary>
    let authors = _prefixId.prefix "authors"
    let belgium = _prefixId.prefix "belgium"
    /// <summary>
    ///   <para>rdfs:label : is BLER existing prior</para>
    ///   <para>rdfs:comment : Is an employee board level representation/participation (BLER) mechanism applicable prior to the cross-border transaction?
    ///
    /// 0 = no BLER prior to cross-border transaction
    /// 1 = BLER existing prior to cross-border transaction</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#bler">cbcm:bler</a>
    /// </summary>
    let bler = _prefixId.prefix "bler"
    /// <summary>
    ///   <para>rdfs:label : BLER composition</para>
    ///   <para>rdfs:comment : What is the employee board level representation (BLER) ratio going to be after the completion of the transaction?
    ///
    /// The ratio is ranging from 0.00 (no BLER) to 0.33 (1/3 BLER) to 0.5 (50-50 Mitbestimmung) to (theoretically) 1.00, which would be 100% employee representatives on the board and no shareholder representatives.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#blerComposition">cbcm:blerComposition</a>
    /// </summary>
    let blerComposition = _prefixId.prefix "blerComposition"
    let bulgaria = _prefixId.prefix "bulgaria"
    /// <summary>
    ///   <para>rdfs:label : Cross-border company mobility data provenance relation</para>
    ///   <para>rdfs:comment : (cbcmDataProvenanceRelation ?ENTITY1 ?ENTITY2) means that the relation between ?ENTITY1 and ?ENTITY2 captures provenance information for company transaction data.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmDataProvenanceRelation">cbcm:cbcmDataProvenanceRelation</a>
    /// </summary>
    let cbcmDataProvenanceRelation = _prefixId.prefix "cbcmDataProvenanceRelation"
    /// <summary>
    ///   <para>rdfs:label : Cross-border company mobility document relation</para>
    ///   <para>rdfs:comment : (cbcmDocumentRelation ?ENTITY1 ?ENTITY2) means that the relation between ?ENTITY1 and ?ENTITY2 captures information pertaining to a company mobility document or similar information source relevant to corporate mobility.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmDocumentRelation">cbcm:cbcmDocumentRelation</a>
    /// </summary>
    let cbcmDocumentRelation = _prefixId.prefix "cbcmDocumentRelation"
    /// <summary>
    ///   <para>rdfs:label : Cross-border company mobility entity relation</para>
    ///   <para>rdfs:comment : (cbcmEntityRelation ?ENTITY1 ?ENTITY2) means that ?ENTITY1 is related to ?ENTITY2.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmEntityRelation">cbcm:cbcmEntityRelation</a>
    /// </summary>
    let cbcmEntityRelation = _prefixId.prefix "cbcmEntityRelation"
    /// <summary>
    ///   <para>rdfs:label : Cross-border company mobility object relation</para>
    ///   <para>rdfs:comment : (cbcmObjectRelation ?ENTITY1 ?ENTITY2) means that the relation between ?ENTITY1 and ?ENTITY2 captures information pertaining to an object.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmObjectRelation">cbcm:cbcmObjectRelation</a>
    /// </summary>
    let cbcmObjectRelation = _prefixId.prefix "cbcmObjectRelation"
    /// <summary>
    ///   <para>rdfs:label : Cross-border company mobility organisation relation</para>
    ///   <para>rdfs:comment : (cbcmOrganisationRelation ?ENTITY1 ?ENTITY2) means that the relation between ?ENTITY1 and ?ENTITY2 captures information pertaining to an organisation.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmOrganisationRelation">cbcm:cbcmOrganisationRelation</a>
    /// </summary>
    let cbcmOrganisationRelation = _prefixId.prefix "cbcmOrganisationRelation"
    /// <summary>
    ///   <para>rdfs:label : Cross-border company mobility transaction relation</para>
    ///   <para>rdfs:comment : (cbcmTransactionRelation ?ENTITY1 ?ENTITY2) means that the relation between ?ENTITY1 and ?ENTITY2 captures information pertaining to a company mobility transaction.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#cbcmTransactionRelation">cbcm:cbcmTransactionRelation</a>
    /// </summary>
    let cbcmTransactionRelation = _prefixId.prefix "cbcmTransactionRelation"

    /// <summary>
    ///   <para>rdfs:label : Companies have Economic Committee</para>
    ///   <para>rdfs:comment : Are the companies involved in the transaction having an economic committee?
    ///
    /// An economic committee advises the work council about the financial parts of the transaction.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#companiesHaveEconomicCommittee">cbcm:companiesHaveEconomicCommittee</a>
    /// </summary>
    let companiesHaveEconomicCommittee =
        _prefixId.prefix "companiesHaveEconomicCommittee"

    /// <summary>
    ///   <para>rdfs:label : Companies have employees</para>
    ///   <para>rdfs:comment : Are the companies involved in the transaction having employees? Only one company needs to have employees for this property to be true</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#companiesHaveEmployees">cbcm:companiesHaveEmployees</a>
    /// </summary>
    let companiesHaveEmployees = _prefixId.prefix "companiesHaveEmployees"
    /// <summary>
    ///   <para>rdfs:label : Companies have Works Council</para>
    ///   <para>rdfs:comment : Are the companies involved in the transaction having a works council? Works councils safeguard employees' welfare</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#companiesHaveWorksCouncil">cbcm:companiesHaveWorksCouncil</a>
    /// </summary>
    let companiesHaveWorksCouncil = _prefixId.prefix "companiesHaveWorksCouncil"
    /// <summary>
    ///   <para>rdfs:label : Company form country</para>
    ///   <para>rdfs:comment : (companyFormCountry ?ENTITY1 ?ENTITY2) means that ?ENTITY1 is a company form recognized by the law of country ?ENTITY2.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#companyFormCountry">cbcm:companyFormCountry</a>
    /// </summary>
    let companyFormCountry = _prefixId.prefix "companyFormCountry"
    /// <summary>
    ///   <para>cbcm:example : (containedIn transactionNotice1 nationalRegistry1)</para>
    ///   <para>rdfs:label : contained in</para>
    ///   <para>rdfs:comment : (containedIn ?ENTITY1 ?ENTITY2) means that some document or publication ?ENTITY1 is archived or stored in some other document collection, database or data repository referred to by ?ENTITY2.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#containedIn">cbcm:containedIn</a>
    /// </summary>
    let containedIn = _prefixId.prefix "containedIn"
    /// <summary>
    ///   <para>rdfs:label : country has company form</para>
    ///   <para>rdfs:comment : (countryHasCompanyForm ?ENTITY1 ?ENTITY2) means that ?ENTITY1 refers to a country the corporate law in that country permits and / or has occurrences of companies in that country which have the corporate legal structure (company legal form) referred to by ?ENTITY2.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#countryHasCompanyForm">cbcm:countryHasCompanyForm</a>
    /// </summary>
    let countryHasCompanyForm = _prefixId.prefix "countryHasCompanyForm"
    let croatia = _prefixId.prefix "croatia"
    let cyprus = _prefixId.prefix "cyprus"
    let czechia = _prefixId.prefix "czechia"
    let denmark = _prefixId.prefix "denmark"
    /// <summary>
    ///   <para>rdfs:label : Diverging employment figure</para>
    ///   <para>rdfs:comment : If a different employee number for the acquiring company is found, it is recorded in this field</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#divergingEmploymentFigure">cbcm:divergingEmploymentFigure</a>
    /// </summary>
    let divergingEmploymentFigure = _prefixId.prefix "divergingEmploymentFigure"
    /// <summary>
    ///   <para>cbcm:example : (documentValidatedByDocument mergerPlan1 mergerCertificate1)</para>
    ///   <para>rdfs:label : document validated by document</para>
    ///   <para>rdfs:comment : (documentValidatedByDocument ?ENTITY1 ?ENTITY2) means that some document or publication, ?ENTITY1, went through a process of approval and assessment through various criteria such as veracity, eligibility, legal relevance etc. and another document ?ENTITY2 was produced to prove the satisfaction of the critieria by ?ENTITY1.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#documentValidatedByDocument">cbcm:documentValidatedByDocument</a>
    /// </summary>
    let documentValidatedByDocument = _prefixId.prefix "documentValidatedByDocument"
    /// <summary>
    ///   <para>cbcm:example : (employedBy person1 company1)</para>
    ///   <para>rdfs:label : employed by</para>
    ///   <para>rdfs:comment : (employedBy ?ENTITY1 ?ENTITY2) means that some agent (person or organisation) ?ENTITY1 is promised and delivered an incentive (usually financial) to perform some work for ?ENTITY2 where ?ENTITY2 is an organisation. This exchange is usually governed by law and formal regulations in the particular country or social context in which the work is being performed.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#employedBy">cbcm:employedBy</a>
    /// </summary>
    let employedBy = _prefixId.prefix "employedBy"
    /// <summary>
    ///   <para>rdfs:label : employs</para>
    ///   <para>rdfs:comment : (employs ?ENTITY1 ?ENTITY2) means (employedBy ?ENTITY2 ?ENTITY1)</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#employs">cbcm:employs</a>
    /// </summary>
    let employs = _prefixId.prefix "employs"
    /// <summary>
    ///   <para>rdfs:label : Ended at</para>
    ///   <para>rdfs:comment : The date and time a process ended</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#endedAtTime">cbcm:endedAtTime</a>
    /// </summary>
    let endedAtTime = _prefixId.prefix "endedAtTime"
    let estonia = _prefixId.prefix "estonia"
    let euOfficialJournal = _prefixId.prefix "euOfficialJournal"
    /// <summary>
    ///   <para>rdfs:label : Has EWC</para>
    ///   <para>rdfs:comment : Is the company having a European Works Council (EWC)?</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#ewc">cbcm:ewc</a>
    /// </summary>
    let ewc = _prefixId.prefix "ewc"
    /// <summary>
    ///   <para>rdfs:label : Example</para>
    ///   <para>rdfs:comment : Provides a human-readable written example of the entity in question.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#example">cbcm:example</a>
    /// </summary>
    let example = _prefixId.prefix "example"
    let finland = _prefixId.prefix "finland"
    let france = _prefixId.prefix "france"
    /// <summary>
    ///   <para>rdfs:label : Generated</para>
    ///   <para>rdfs:comment : Generation is the completion of production of a new entity by a process. This entity did not exist before generation and becomes available for usage after this generation.
    ///
    /// Based (inverse of) on: https://www.w3.org/TR/prov-o/#wasGeneratedBy</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#generated">cbcm:generated</a>
    /// </summary>
    let generated = _prefixId.prefix "generated"
    let germany = _prefixId.prefix "germany"
    let greece = _prefixId.prefix "greece"
    /// <summary>
    ///   <para>rdfs:label : has acquiring company</para>
    ///   <para>rdfs:comment : (hasAcquiringCompany ?ENTITY1 ?ENTITY2) means that some company merger transaction ?ENTITY1 produces a new company or alters an existing one (?ENTITY2) such that ?ENTITY2 will acquire (via a universal transfer of assets and liabilities) one or more other companies involved in the process ?ENTITY1.</para>
    ///   <para>cbcm:example : (hasAcquiringCompany crossBorderMerger1 company1)^^xsd:string</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#hasAcquiringCompany">cbcm:hasAcquiringCompany</a>
    /// </summary>
    let hasAcquiringCompany = _prefixId.prefix "hasAcquiringCompany"
    /// <summary>
    ///   <para>rdfs:label : Company Form</para>
    ///   <para>rdfs:comment : Company legal form. Name given to describe the structure of a corporation or buiness in the different legal orders. For example Limited (Ltd.), Public Limited Company (PLC), Gesellschaft mit beschränkter Haftung (GmbH), Aktiengesellschaft (AG). The company legal form is regulated under national law and grants specific rights and obligations to the company stakeholders (such as shareholders, management &amp; employees).</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#hasCompanyForm">cbcm:hasCompanyForm</a>
    /// </summary>
    let hasCompanyForm = _prefixId.prefix "hasCompanyForm"
    /// <summary>
    ///   <para>cbcm:example : (hasCompanyStakeholder company1 person1)</para>
    ///   <para>rdfs:label : has company stakeholder</para>
    ///   <para>rdfs:comment : (hasCompanyStakeholder ?ENTITY1 ?ENTITY2) means that some entity ?ENTITY1, which is either a significant process or agent has another agent ?ENTITY2 with personal interests in benefiting either financially or otherwise from the outcomes of ?ENTITY1 (if it is an event or process), or in its byproducts and profits (if it is an agent).</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#hasCompanyStakeholder">cbcm:hasCompanyStakeholder</a>
    /// </summary>
    let hasCompanyStakeholder = _prefixId.prefix "hasCompanyStakeholder"

    /// <summary>
    ///   <para>rdfs:label : has document source</para>
    ///   <para>rdfs:comment : In which document did the researcher find information about the transaction?</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#hasDataProvenanceDocumentSource">cbcm:hasDataProvenanceDocumentSource</a>
    /// </summary>
    let hasDataProvenanceDocumentSource =
        _prefixId.prefix "hasDataProvenanceDocumentSource"

    /// <summary>
    ///   <para>rdfs:label : data found in registry from country</para>
    ///   <para>rdfs:comment : In which countries' registry did the researcher find information about the transaction?</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#hasDataProvenanceRegistryCountry">cbcm:hasDataProvenanceRegistryCountry</a>
    /// </summary>
    let hasDataProvenanceRegistryCountry =
        _prefixId.prefix "hasDataProvenanceRegistryCountry"

    /// <summary>
    ///   <para>cbcm:example : (hasMember worksCouncil1 employee1)</para>
    ///   <para>rdfs:label : has member</para>
    ///   <para>rdfs:comment : (hasMember ?ENTITY1 ?ENTITY2) means that some agent ?ENTITY1 (usually an organisation) has a person ?ENTITY2 that participates in its activities. This need not represent an employment role nor imply financial incentives between the organisation and person.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#hasMember">cbcm:hasMember</a>
    /// </summary>
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:label : has merging company</para>
    ///   <para>cbcm:example : (hasMergingCompany crossBorderMerger1 company1)^^xsd:string</para>
    ///   <para>rdfs:comment : (hasMergingCompany ?ENTITY1 ?ENTITY2) means that some company merger transaction ?ENTITY1 involves a company ?ENTITY2 which will be dissolved during the process of ?ENTITY1 and will be acquired (via a universal transfer of assets and liabilities) by another distinct company involved in ?ENTITY1.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#hasMergingCompany">cbcm:hasMergingCompany</a>
    /// </summary>
    let hasMergingCompany = _prefixId.prefix "hasMergingCompany"
    /// <summary>
    ///   <para>rdfs:comment : (hasOriginalCompany ?ENTITY1 ?ENTITY2) means that some company division transaction ?ENTITY1 involves a company ?ENTITY2 which will be divided (or "split") into multiple recipient or emerging companies.</para>
    ///   <para>rdfs:label : has original company</para>
    ///   <para>cbcm:example : (hasOriginalCompany crossBorderDivision1 company1)^^xsd:string</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#hasOriginalCompany">cbcm:hasOriginalCompany</a>
    /// </summary>
    let hasOriginalCompany = _prefixId.prefix "hasOriginalCompany"
    /// <summary>
    ///   <para>cbcm:example : (hasParentCompany company1 company2)</para>
    ///   <para>rdfs:label : has parent company</para>
    ///   <para>rdfs:comment : (hasParentCompany ?ENTITY1 ?ENTITY2) means that some company ?ENTITY1 is owned and under direct or indirect control by the company ?ENTITY2.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#hasParentCompany">cbcm:hasParentCompany</a>
    /// </summary>
    let hasParentCompany = _prefixId.prefix "hasParentCompany"
    /// <summary>
    ///   <para>rdfs:label : has part</para>
    ///   <para>rdfs:comment : (hasPart ?ENTITY1 ?ENTITY2) means that the entity referred to by ?ENTITY1 has a constituent entity referred to by ?ENTITY2.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#hasPart">cbcm:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>rdfs:label : After-transaction company form</para>
    ///   <para>rdfs:comment : (?ENTITY1 hasPostCompanyForm ?ENTITY2) indicates the new company form of a company undergoing a cross border conversion or a national conversion.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#hasPostCompanyForm">cbcm:hasPostCompanyForm</a>
    /// </summary>
    let hasPostCompanyForm = _prefixId.prefix "hasPostCompanyForm"

    /// <summary>
    ///   <para>rdfs:label : Company primary registration location</para>
    ///   <para>rdfs:comment : Primary country of registration (location) of a company as a full country name</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#hasPrimaryRegistrationLocation">cbcm:hasPrimaryRegistrationLocation</a>
    /// </summary>
    let hasPrimaryRegistrationLocation =
        _prefixId.prefix "hasPrimaryRegistrationLocation"

    /// <summary>
    ///   <para>rdfs:label : Pre-transaction company form</para>
    ///   <para>rdfs:comment : (?ENTITY1 hasPriorCompanyForm ?ENTITY2) indicates the original company form of a company undergoing a cross border conversion or a national conversion.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#hasPriorCompanyForm">cbcm:hasPriorCompanyForm</a>
    /// </summary>
    let hasPriorCompanyForm = _prefixId.prefix "hasPriorCompanyForm"
    /// <summary>
    ///   <para>cbcm:example : (hasMergingCompany crossBorderMerger1 company1)^^xsd:string</para>
    ///   <para>rdfs:comment : (hasRecipientCompany ?ENTITY1 ?ENTITY2) means that some company division transaction ?ENTITY1 produces two or more distinct companies, one of which is ?ENTITY2 (a so-called "recipient company").</para>
    ///   <para>rdfs:label : has recipient company</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#hasRecipientCompany">cbcm:hasRecipientCompany</a>
    /// </summary>
    let hasRecipientCompany = _prefixId.prefix "hasRecipientCompany"

    /// <summary>
    ///   <para>rdfs:label : Company secondary registration location</para>
    ///   <para>rdfs:comment : Country of secondary registration (location) of a company</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#hasSecondaryRegistrationLocation">cbcm:hasSecondaryRegistrationLocation</a>
    /// </summary>
    let hasSecondaryRegistrationLocation =
        _prefixId.prefix "hasSecondaryRegistrationLocation"

    /// <summary>
    ///   <para>cbcm:example : (hasSubProcedure seatTransfer1 changeOfCompanyAddress1)^^xsd:string</para>
    ///   <para>rdfs:label : has sub procedure</para>
    ///   <para>rdfs:comment : (hasSubProcedure ?ENTITY1 ?ENTITY2) means that some process ?ENTITY1 contains another (shorter) process ?ENTITY2 that should be completed before ?ENTITY1 can complete.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#hasSubProcedure">cbcm:hasSubProcedure</a>
    /// </summary>
    let hasSubProcedure = _prefixId.prefix "hasSubProcedure"
    /// <summary>
    ///   <para>rdfs:label : has subsidiary company</para>
    ///   <para>rdfs:comment : (hasSubsidiaryCompany ?ENTITY1 ?ENTITY2) means (hasParentCompany ?ENTITY2 ?ENTITY1)</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#hasSubsidiaryCompany">cbcm:hasSubsidiaryCompany</a>
    /// </summary>
    let hasSubsidiaryCompany = _prefixId.prefix "hasSubsidiaryCompany"
    /// <summary>
    ///   <para>cbcm:example : (hasTransactionInput crossBorderMerger1 company1)^^xsd:string</para>
    ///   <para>rdfs:label : has transaction input</para>
    ///   <para>rdfs:comment : (hasTransactionInput ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 has a prerequisite entity ?ENTITY2 that needs to be considered, assessed, or modified during the transaction referred to by ?ENTITY1.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#hasTransactionInput">cbcm:hasTransactionInput</a>
    /// </summary>
    let hasTransactionInput = _prefixId.prefix "hasTransactionInput"
    /// <summary>
    ///   <para>cbcm:example : (hasTransactionResult crossBorderMerger1 acquiringCompany1)^^xsd:stringcbcm:example : (hasTransactionResult crossBorderMerger1 mergerCertificate1)^^xsd:string</para>
    ///   <para>rdfs:label : has transaction result</para>
    ///   <para>rdfs:comment : (hasTransactionResult ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 has a byproduct ?ENTITY2 (e.g. a company, transaction certificate etc.) after completion of the process.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#hasTransactionResult">cbcm:hasTransactionResult</a>
    /// </summary>
    let hasTransactionResult = _prefixId.prefix "hasTransactionResult"
    let hungary = _prefixId.prefix "hungary"
    let iceland = _prefixId.prefix "iceland"
    /// <summary>
    ///   <para>rdfs:label : Impact on employees</para>
    ///   <para>rdfs:comment : Is the impact on employees of the envisaged transaction specified in the transaction document (e.g. the merger plan)?
    ///
    /// Part of merger plan that specifies how the transaction will affect employees.
    ///
    /// - Yes: there is an impact on employees (positive or negative);
    /// - No: no impact on employees;
    /// - Not applicable: the conditions are not met (e.g. no employees, BLER threshold not met) for this criterion to be applicable;
    /// - Unclear: the wording of the document is unclear with regard to the impact/effect/measures taken;
    /// - Not mentioned: given the parameters, this aspect should be addressed in the transaction document, but is not mentioned</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#impactOnEmployees">cbcm:impactOnEmployees</a>
    /// </summary>
    let impactOnEmployees = _prefixId.prefix "impactOnEmployees"
    /// <summary>
    ///   <para>cbcm:example : (involvesChangeOf seatTransfer1 businessAddress1)</para>
    ///   <para>rdfs:label : involves the change of</para>
    ///   <para>rdfs:comment : (involvesChangeOf ?ENTITY1 ?ENTITY2) means that the process ?ENTITY1 requires the modification or alteration of the entity or object ?ENTITY2.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#involvesChangeOf">cbcm:involvesChangeOf</a>
    /// </summary>
    let involvesChangeOf = _prefixId.prefix "involvesChangeOf"
    /// <summary>
    ///   <para>cbcm:example : (involvesCountry crossBorderMerger1 france)^^xsd:string</para>
    ///   <para>rdfs:label : involves country</para>
    ///   <para>rdfs:comment : (involvesCountry ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 includes the modification of a company whose place of business is located in the country referred to by ?ENTITY2</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#involvesCountry">cbcm:involvesCountry</a>
    /// </summary>
    let involvesCountry = _prefixId.prefix "involvesCountry"
    let ireland = _prefixId.prefix "ireland"
    /// <summary>
    ///   <para>rdfs:label : Is listed</para>
    ///   <para>rdfs:comment : Whether the company is publicly listed. A company whose shares are bought and sold on a particular stock market.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#isListed">cbcm:isListed</a>
    /// </summary>
    let isListed = _prefixId.prefix "isListed"
    /// <summary>
    ///   <para>rdfs:label : Is SE creation</para>
    ///   <para>rdfs:comment : Variable indicating whether this case concerns an SE-creation (yes/no) to distinguish creations of SEs from other transactions</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#isSECreation">cbcm:isSECreation</a>
    /// </summary>
    let isSECreation = _prefixId.prefix "isSECreation"
    /// <summary>
    ///   <para>rdfs:label : is transaction input of</para>
    ///   <para>rdfs:comment : (isTransactionInputOf ?ENTITY1 ?ENTITY2) means (hasTransactionInput ?ENTITY2 ?ENTITY1)</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#isTransactionInputOf">cbcm:isTransactionInputOf</a>
    /// </summary>
    let isTransactionInputOf = _prefixId.prefix "isTransactionInputOf"
    /// <summary>
    ///   <para>rdfs:label : is transaction result of</para>
    ///   <para>rdfs:comment : (isTransactionResultOf ?ENTITY1 ?ENTITY2) means (hasTransactionResult ?ENTITY2 ?ENTITY1)</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#isTransactionResultOf">cbcm:isTransactionResultOf</a>
    /// </summary>
    let isTransactionResultOf = _prefixId.prefix "isTransactionResultOf"
    let iso2code = _prefixId.prefix "iso2code"
    /// <summary>
    ///   <para>cbcm:example : (issuedByOrganisation document1 organisation1)</para>
    ///   <para>rdfs:label : issued by organisation</para>
    ///   <para>rdfs:comment : (issuedByOrganisation ?ENTITY1 ?ENTITY2) means that some document or publication, ?ENTITY1, was created (and possibly delivered or administered to another entity) by some entity ?ENTITY2.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#issuedByOrganisation">cbcm:issuedByOrganisation</a>
    /// </summary>
    let issuedByOrganisation = _prefixId.prefix "issuedByOrganisation"
    let italy = _prefixId.prefix "italy"
    /// <summary>
    ///   <para>rdfs:label : Last WW employment figure</para>
    ///   <para>rdfs:comment : Last available employment figure for the total worldwide employees</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#lastWWEmploymentFigure">cbcm:lastWWEmploymentFigure</a>
    /// </summary>
    let lastWWEmploymentFigure = _prefixId.prefix "lastWWEmploymentFigure"
    let latvia = _prefixId.prefix "latvia"
    /// <summary>
    ///   <para>rdfs:label : Law Firm</para>
    ///   <para>rdfs:comment : Name of the lawfirm involved in the transaction, if available (for internal use; cross-border divisions and seat transfers are currently not possible within an EU legal framework.)</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#lawfirm">cbcm:lawfirm</a>
    /// </summary>
    let lawfirm = _prefixId.prefix "lawfirm"
    /// <summary>
    ///   <para>rdfs:label : Legal form acronym</para>
    ///   <para>rdfs:comment : The acronym of a company legal form</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#legalFormAcronym">cbcm:legalFormAcronym</a>
    /// </summary>
    let legalFormAcronym = _prefixId.prefix "legalFormAcronym"
    let liechtenstein = _prefixId.prefix "liechtenstein"
    let lithuania = _prefixId.prefix "lithuania"
    /// <summary>
    ///   <para>rdfs:label : located in</para>
    ///   <para>rdfs:comment : (locatedIn ?ENTITY1 ?ENTITY2) means that some entity ?ENTITY1 occupies the spatial region referred to by ?ENTITY2.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#locatedIn">cbcm:locatedIn</a>
    /// </summary>
    let locatedIn = _prefixId.prefix "locatedIn"
    let luxembourg = _prefixId.prefix "luxembourg"
    /// <summary>
    ///   <para>cbcm:example : (maintainedBy officialJournalRepository1 officialJournalAdministration1)</para>
    ///   <para>rdfs:label : maintained by</para>
    ///   <para>rdfs:comment : (maintainedBy ?ENTITY1 ?ENTITY2) means that some digital resource ?ENTITY1 (e.g. database, website, document repository etc.) has stewardship by some agent or organisation ?ENTITY2 who is responsible for the upkeep of ?ENTITY1.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#maintainedBy">cbcm:maintainedBy</a>
    /// </summary>
    let maintainedBy = _prefixId.prefix "maintainedBy"
    /// <summary>
    ///   <para>rdfs:label : maintains</para>
    ///   <para>rdfs:comment : (maintains ?ENTITY1 ?ENTITY2) means (maintainedBy ?ENTITY2 ?ENTITY1)</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#maintains">cbcm:maintains</a>
    /// </summary>
    let maintains = _prefixId.prefix "maintains"
    let malta = _prefixId.prefix "malta"

    /// <summary>
    ///   <para>rdfs:label : MC Employees count at transaction</para>
    ///   <para>rdfs:comment : Number of employees of the acquiring company - at the moment of the transaction</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#mcEmploymentFigureAtTransaction">cbcm:mcEmploymentFigureAtTransaction</a>
    /// </summary>
    let mcEmploymentFigureAtTransaction =
        _prefixId.prefix "mcEmploymentFigureAtTransaction"

    /// <summary>
    ///   <para>rdfs:label : Last employment figure for the merging company</para>
    ///   <para>rdfs:comment : The last available annual employment figure for the merging company</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#mcLastEmploymentFigure">cbcm:mcLastEmploymentFigure</a>
    /// </summary>
    let mcLastEmploymentFigure = _prefixId.prefix "mcLastEmploymentFigure"
    /// <summary>
    ///   <para>rdfs:label : MC Last employment figure year</para>
    ///   <para>rdfs:comment : The year the last annual employment figure was obtained for merging companies</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#mcYearEmploymentFigure">cbcm:mcYearEmploymentFigure</a>
    /// </summary>
    let mcYearEmploymentFigure = _prefixId.prefix "mcYearEmploymentFigure"
    /// <summary>
    ///   <para>rdfs:label : Multi-transaction</para>
    ///   <para>rdfs:comment : A transaction whereby more than two companies (i.e. multiple merging companies) are involved and merged into one acquiring company</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#multiCBM">cbcm:multiCBM</a>
    /// </summary>
    let multiCBM = _prefixId.prefix "multiCBM"
    /// <summary>
    ///   <para>rdfs:label : NACE code</para>
    ///   <para>rdfs:comment : NACE Classification Code for companies. NACE (Nomenclature des Activités Économiques dans la Communauté Européenne) is a European industry standard classification system similar in function to Standard Industry Classification (SIC) and North American Industry Classification System (NAICS) for classifying business activities. From EUROSTAT</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#naceCode">cbcm:naceCode</a>
    /// </summary>
    let naceCode = _prefixId.prefix "naceCode"
    /// <summary>
    ///   <para>rdfs:label : NACE sector</para>
    ///   <para>rdfs:comment : Company NACE sector. NACE (Nomenclature of Economic Activities) is the European statistical classification of economic activities. Classification of a company according to which kinds of sector (i.e. industry / market / product type) they deal in. From EUROSTAT</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#naceSector">cbcm:naceSector</a>
    /// </summary>
    let naceSector = _prefixId.prefix "naceSector"
    /// <summary>
    ///   <para>rdfs:label : Organization name</para>
    ///   <para>rdfs:comment : The name of the organization</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#name">cbcm:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : NAT registration number</para>
    ///   <para>rdfs:comment : The national registration number of an acquiring/receiving/entry company. A company registration number is a unique combination of numbers and/or letters. It is used to identify a company and verify its legal existence as an incorporated entity.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#natRegistrationNumber">cbcm:natRegistrationNumber</a>
    /// </summary>
    let natRegistrationNumber = _prefixId.prefix "natRegistrationNumber"
    /// <summary>
    ///   <para>rdfs:label : Has negotiated agreement</para>
    ///   <para>rdfs:comment : Is the management of the companies involved starting the process of setting up a Special Negotiating Body (SNB) in order to reach a negotiated agreement on the future employee participation mechanism (BLER) after the transaction?
    ///
    /// BLER (Board-Level Employee Represenation): highest level of employee involvement in a company in the supervisory board. They can take co-determine decisions of the company's management and where the company is heading.
    ///
    /// - Yes: there is a negotiated agreement to be negotiated with the SNB;
    /// - No: no negotiated agreement;
    /// - Not applicable: the conditions are not met (e.g. no employees, BLER threshold not met) for this criterion to be applicable;
    /// - Unclear: the wording of the document is unclear with regard to the impact/effect/measures taken;
    /// - Not mentioned: given the parameters, this aspect should be addressed in the transaction document, but is not mentioned</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#negotiatedAgreement">cbcm:negotiatedAgreement</a>
    /// </summary>
    let negotiatedAgreement = _prefixId.prefix "negotiatedAgreement"
    let netherlands = _prefixId.prefix "netherlands"
    let norway = _prefixId.prefix "norway"
    /// <summary>
    ///   <para>cbcm:example : (ownedBy company1 company2)</para>
    ///   <para>rdfs:label : owned by</para>
    ///   <para>rdfs:comment : (ownedBy ?ENTITY1 ?ENTITY2) means that some agent ?ENTITY2 has proprietorship over another object or organisational agent ?ENTITY1.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#ownedBy">cbcm:ownedBy</a>
    /// </summary>
    let ownedBy = _prefixId.prefix "ownedBy"
    /// <summary>
    ///   <para>rdfs:label : owns</para>
    ///   <para>rdfs:comment : (owns ?ENTITY1 ?ENTITY2) means (owns ?ENTITY2 ?ENTITY1)</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#owns">cbcm:owns</a>
    /// </summary>
    let owns = _prefixId.prefix "owns"
    /// <summary>
    ///   <para>rdfs:label : part of</para>
    ///   <para>rdfs:comment : (partOf ?ENTITY1 ?ENTITY2) means (hasPart ?ENTITY2 ?ENTITY1)</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#partOf">cbcm:partOf</a>
    /// </summary>
    let partOf = _prefixId.prefix "partOf"
    let poland = _prefixId.prefix "poland"
    let portugal = _prefixId.prefix "portugal"
    /// <summary>
    ///   <para>rdfs:label : Raw transaction ID</para>
    ///   <para>rdfs:comment : unique identifier before database entry.
    ///
    /// This id is the old ID-structure used before entry into the CbCMdb</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#rawTransactionID">cbcm:rawTransactionID</a>
    /// </summary>
    let rawTransactionID = _prefixId.prefix "rawTransactionID"
    /// <summary>
    ///   <para>rdfs:label : Registered Office</para>
    ///   <para>rdfs:comment : Deprecated property</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#registeredOffice">cbcm:registeredOffice</a>
    /// </summary>
    let registeredOffice = _prefixId.prefix "registeredOffice"
    /// <summary>
    ///   <para>cbcm:example : (reportedIn crossBorderMerger1 transactionNotice1)</para>
    ///   <para>rdfs:label : reported in</para>
    ///   <para>rdfs:comment : (reportedIn ?ENTITY1 ?ENTITY2) means that some significant event, process or statement ?ENTITY1 is published or mentioned or declared in writing in some publication, document or database ?ENTITY2.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#reportedIn">cbcm:reportedIn</a>
    /// </summary>
    let reportedIn = _prefixId.prefix "reportedIn"
    /// <summary>
    ///   <para>cbcm:example : Examples include: MUST, SHOULD, RECOMMENDED and OPTIONAL</para>
    ///   <para>rdfs:label : Requirement level</para>
    ///   <para>rdfs:comment : Specifies a phrase to indicate the degree to which the providing of a value for the entity (e.g. a data or object property) in question is compulsory, recommended or optional.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#requirement-level">cbcm:requirement-level</a>
    /// </summary>
    let requirement_level = _prefixId.prefix "requirement-level"
    /// <summary>
    ///   <para>cbcm:example : (requiresDocument crossBorderMerger1 mergerPlan1)</para>
    ///   <para>rdfs:label : requires document</para>
    ///   <para>rdfs:comment : (requiresDocument ?ENTITY1 ?ENTITY2) means that some significant event or process ?ENTITY1 needs a compulsory document ?ENTITY2 to be submitted and reviewed before the process ?ENTITY1 can be completed.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#requiresDocument">cbcm:requiresDocument</a>
    /// </summary>
    let requiresDocument = _prefixId.prefix "requiresDocument"
    let romania = _prefixId.prefix "romania"
    /// <summary>
    ///   <para>rdfs:label : SNB voluntary application</para>
    ///   <para>rdfs:comment : Is a Special Negotiating Body (SNB) set up voluntary?
    ///
    /// Whether or not a SNB is created/will be created voluntarily.
    ///
    /// - Yes: an SNB is created voluntarily;
    /// - No: no voluntary SNB set up;
    /// - Not applicable: the conditions are not met (e.g. no employees, BLER threshold not met) for this criterion to be applicable;
    /// - Unclear: the wording of the document is unclear with regard to the impact/effect/measures taken;
    /// - Not mentioned: given the parameters, this aspect should be addressed in the transaction document, but is not mentioned</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#sbnVoluntaryApplication">cbcm:sbnVoluntaryApplication</a>
    /// </summary>
    let sbnVoluntaryApplication = _prefixId.prefix "sbnVoluntaryApplication"
    let se_conversion = _prefixId.prefix "se_conversion"
    let se_holding = _prefixId.prefix "se_holding"
    let se_merger = _prefixId.prefix "se_merger"
    let se_subsidiary = _prefixId.prefix "se_subsidiary"
    let se_unsure = _prefixId.prefix "se_unsure"
    let slovakia = _prefixId.prefix "slovakia"
    let slovenia = _prefixId.prefix "slovenia"
    /// <summary>
    ///   <para>cbcm:example : (sourceCountry crossBorderMerger1 france)^^xsd:string</para>
    ///   <para>rdfs:label : source country</para>
    ///   <para>rdfs:comment : (sourceCountry ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 has some transaction input (a company) whose place of business is located in the country ?ENTITY2.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#sourceCountry">cbcm:sourceCountry</a>
    /// </summary>
    let sourceCountry = _prefixId.prefix "sourceCountry"
    let spain = _prefixId.prefix "spain"
    /// <summary>
    ///   <para>rdfs:label : Standard rules application</para>
    ///   <para>rdfs:comment : Are the standard rules applied directly without and instead of the start of negotiations with a Special Negotiating Body (SNB)?
    ///
    /// Instead of an SNB being set up, the standard rules are applied instead.
    ///
    /// - Yes: the standard rules are applied;
    /// - No: standard rules ar enot applied;
    /// - Not applicable: the conditions are not met (e.g. no employees, BLER threshold not met) for this criterion to be applicable;
    /// - Unclear: the wording of the document is unclear with regard to the impact/effect/measures taken;
    /// - Not mentioned: given the parameters, this aspect should be addressed in the transaction document, but is not mentioned</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#standardRulesApplication">cbcm:standardRulesApplication</a>
    /// </summary>
    let standardRulesApplication = _prefixId.prefix "standardRulesApplication"
    let sweden = _prefixId.prefix "sweden"
    let switzerland = _prefixId.prefix "switzerland"
    /// <summary>
    ///   <para>cbcm:example : (targetCountry crossBorderMerger1 belgium)^^xsd:string</para>
    ///   <para>rdfs:label : target country</para>
    ///   <para>rdfs:comment : (targetCountry ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 has some transaction result (a company) whose place of business is located in the country ?ENTITY2.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#targetCountry">cbcm:targetCountry</a>
    /// </summary>
    let targetCountry = _prefixId.prefix "targetCountry"
    /// <summary>
    ///   <para>rdfs:label : Has TNIC</para>
    ///   <para>rdfs:comment : Is the company having a transnational information and consultation agreement in place? Does the company have an internal body which discusses employee rights and welfare?
    ///
    /// Different from works council. TNIC is global.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#tnic">cbcm:tnic</a>
    /// </summary>
    let tnic = _prefixId.prefix "tnic"
    /// <summary>
    ///   <para>rdfs:label : BLER to be negotiated</para>
    ///   <para>rdfs:comment : Is an employee board level representation/participation (BLER) mechanism going to be re-negotiated in the process of the cross-border transaction?
    ///
    /// - Yes: BLER be (re-)negotiated with the SNB;
    /// - No: no BLER-(re-)negotiation;
    /// - Not applicable: the conditions are not met (e.g. no employees, BLER threshold not met) for this criterion to be applicable;
    /// - Unclear: the wording of the document is unclear with regard to the impact/effect/measures taken;
    /// - Not mentioned: given the parameters, this aspect should be addressed in the transaction document, but is not mentioned</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#toBeNegotiatedBLER">cbcm:toBeNegotiatedBLER</a>
    /// </summary>
    let toBeNegotiatedBLER = _prefixId.prefix "toBeNegotiatedBLER"
    /// <summary>
    ///   <para>rdfs:label : Transaction comment</para>
    ///   <para>rdfs:comment : Notes from researcher about the transaction</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionComment">cbcm:transactionComment</a>
    /// </summary>
    let transactionComment = _prefixId.prefix "transactionComment"
    /// <summary>
    ///   <para>rdfs:label : Transaction completion date</para>
    ///   <para>rdfs:comment : Date on which the transaction was effectuated (the date that the competent authority e.g., business registry of that country, says that the criteria have been met by merging and acquiring companies and the merging/transferring company is dissolved).
    ///
    /// This is the final step of a transaction process</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionCompletionDate">cbcm:transactionCompletionDate</a>
    /// </summary>
    let transactionCompletionDate = _prefixId.prefix "transactionCompletionDate"
    /// <summary>
    ///   <para>rdfs:label : Transaction ID</para>
    ///   <para>rdfs:comment : unique identifier for a transaction</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionID">cbcm:transactionID</a>
    /// </summary>
    let transactionID = _prefixId.prefix "transactionID"
    /// <summary>
    ///   <para>rdfs:label : Transaction plan available</para>
    ///   <para>rdfs:comment : Is the transaction plan available for analysis?
    ///
    /// Merger plan, Seat transfer plan or Division plan. Transaction notice is where the transaction is announced. The other documents are where the nature and details of the transaction are specified.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionPlan">cbcm:transactionPlan</a>
    /// </summary>
    let transactionPlan = _prefixId.prefix "transactionPlan"
    /// <summary>
    ///   <para>rdfs:label : Transaction notice date</para>
    ///   <para>rdfs:comment : Date of the transaction notice (document announcing the transaction) constituting the start of the transaction process. Date that the document was published (which is the important date because this is when it becomes legally binding)</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionStartDate">cbcm:transactionStartDate</a>
    /// </summary>
    let transactionStartDate = _prefixId.prefix "transactionStartDate"

    /// <summary>
    ///   <para>cbcm:example : (transactionValidatedByDocument crossBorderMerger1 mergerCertificate1)</para>
    ///   <para>rdfs:label : transaction validated by document</para>
    ///   <para>rdfs:comment : (transactionValidatedByDocument ?ENTITY1 ?ENTITY2) means that some company transaction ?ENTITY1 went through a process of approval and assessment through various criteria such as veracity, eligibility, legal relevance etc. and a document ?ENTITY2 was produced to prove the satisfaction of the critieria by ?ENTITY1.</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#transactionValidatedByDocument">cbcm:transactionValidatedByDocument</a>
    /// </summary>
    let transactionValidatedByDocument =
        _prefixId.prefix "transactionValidatedByDocument"

    /// <summary>
    ///   <para>rdfs:label : Type of SE</para>
    ///   <para>rdfs:comment : Variable indicating the SE-establishment mode: by merger, conversion, holding-SE, subsidiary-SE or unsure</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#typeOfSE">cbcm:typeOfSE</a>
    /// </summary>
    let typeOfSE = _prefixId.prefix "typeOfSE"
    let unitedkingdom = _prefixId.prefix "unitedkingdom"
    /// <summary>
    ///   <para>rdfs:label : Used</para>
    ///   <para>rdfs:comment : Usage is the beginning of utilizing an entity by an activity. Before usage, the activity had not begun to utilize this entity and could not have been affected by the entity.
    ///
    /// Based on: https://www.w3.org/TR/prov-o/#used</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#used">cbcm:used</a>
    /// </summary>
    let used = _prefixId.prefix "used"

    /// <summary>
    ///   <para>rdfs:label : Has document source</para>
    ///   <para>rdfs:comment : In which document did the researcher find information about the transaction?</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#usedDataProvenanceDocumentSource">cbcm:usedDataProvenanceDocumentSource</a>
    /// </summary>
    let usedDataProvenanceDocumentSource =
        _prefixId.prefix "usedDataProvenanceDocumentSource"

    /// <summary>
    ///   <para>rdfs:label : Data found in registry from country</para>
    ///   <para>rdfs:comment : In which countries' registry did the researcher find information about the transaction?</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#usedDataProvenanceRegistryCountry">cbcm:usedDataProvenanceRegistryCountry</a>
    /// </summary>
    let usedDataProvenanceRegistryCountry =
        _prefixId.prefix "usedDataProvenanceRegistryCountry"

    /// <summary>
    ///   <para>rdfs:label : Associated with</para>
    ///   <para>rdfs:comment : An activity association is an assignment of responsibility to an agent for a process, indicating that the agent had a role in the activity.
    ///
    /// Based on: https://www.w3.org/TR/prov-o/#wasAssociatedWith</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#wasAssociatedWith">cbcm:wasAssociatedWith</a>
    /// </summary>
    let wasAssociatedWith = _prefixId.prefix "wasAssociatedWith"
    /// <summary>
    ///   <para>rdfs:label : Generated by</para>
    ///   <para>rdfs:comment : Generation is the completion of production of a new entity by a process. This entity did not exist before generation and becomes available for usage after this generation.
    ///
    /// Based on: https://www.w3.org/TR/prov-o/#wasGeneratedBy</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#wasGeneratedBy">cbcm:wasGeneratedBy</a>
    /// </summary>
    let wasGeneratedBy = _prefixId.prefix "wasGeneratedBy"
    /// <summary>
    ///   <para>rdfs:label : Website</para>
    ///   <para>rdfs:comment : Homepage of a company/organization website</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#website">cbcm:website</a>
    /// </summary>
    let website = _prefixId.prefix "website"

    /// <summary>
    ///   <para>rdfs:label : Total WW employees at transaction</para>
    ///   <para>rdfs:comment : number of employees of company group worldwide at the moment of the transaction</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#wwEmploymentFigureAtTransaction">cbcm:wwEmploymentFigureAtTransaction</a>
    /// </summary>
    let wwEmploymentFigureAtTransaction =
        _prefixId.prefix "wwEmploymentFigureAtTransaction"

    /// <summary>
    ///   <para>rdfs:label : Diverging employment figure year</para>
    ///   <para>rdfs:comment : The year for which a diverging employee number is recorded</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#yearDivergingEmploymentFigure">cbcm:yearDivergingEmploymentFigure</a>
    /// </summary>
    let yearDivergingEmploymentFigure = _prefixId.prefix "yearDivergingEmploymentFigure"
    /// <summary>
    ///   <para>rdfs:label : Last WW employment figure year</para>
    ///   <para>rdfs:comment : Year in which the last worldwide employment figure was recorded</para>
    ///   <a href="http://w3id.org/um/cbcm/eu-cm-ontology#yearWWEmploymentFigure">cbcm:yearWWEmploymentFigure</a>
    /// </summary>
    let yearWWEmploymentFigure = _prefixId.prefix "yearWWEmploymentFigure"
