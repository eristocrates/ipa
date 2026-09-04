#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ocds =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/onto-ocds/ocds#" "ocds"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Address</para>
    ///   <para>rdfs:comment : An address. This may be the legally registered address of the organization, or may be a correspondence address for this particular contracting process.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Address">ocds:Address</a>
    /// </summary>
    let Address = _prefixId.prefix "Address"
    /// <summary>
    ///   <para>rdfs:label : Amendment</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Amendment">ocds:Amendment</a>
    /// </summary>
    let Amendment = _prefixId.prefix "Amendment"
    /// <summary>
    ///   <para>rdfs:label : Award</para>
    ///   <para>rdfs:comment : An award for the given procurement. There may be more than one award per contracting process e.g. because the contract is split amongst different providers, or because it is a standing offer.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Award">ocds:Award</a>
    /// </summary>
    let Award = _prefixId.prefix "Award"
    /// <summary>
    ///   <para>rdfs:label : Codelist Award Criteria</para>
    ///   <para>rdfs:comment : The award criteria code list describes the basis on which contract awards will be made.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#AwardCriteria">ocds:AwardCriteria</a>
    /// </summary>
    let AwardCriteria = _prefixId.prefix "AwardCriteria"
    /// <summary>
    ///   <para>rdfs:label : Codelist Award Status</para>
    ///   <para>rdfs:comment : An award move through multiple states. Releases over time may update the status of an award.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#AwardStatus">ocds:AwardStatus</a>
    /// </summary>
    let AwardStatus = _prefixId.prefix "AwardStatus"
    /// <summary>
    ///   <para>rdfs:label : Budget</para>
    ///   <para>rdfs:comment : This section contain information about the budget line, and associated projects, through which this contracting process is funded. It draws upon data model of the [Budget Data Package](https://github.com/openspending/budget-data-package/blob/master/specification.md), and should be used to cross-reference to more detailed information held using a Budget Data Package, or, where no linked Budget Data Package is available, to provide enough information to allow a user to manually or automatically cross-reference with another published source of budget and project information.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Budget">ocds:Budget</a>
    /// </summary>
    let Budget = _prefixId.prefix "Budget"
    /// <summary>
    ///   <para>rdfs:label : Change</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Change">ocds:Change</a>
    /// </summary>
    let Change = _prefixId.prefix "Change"
    /// <summary>
    ///   <para>rdfs:label : Classification</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Classification">ocds:Classification</a>
    /// </summary>
    let Classification = _prefixId.prefix "Classification"
    /// <summary>
    ///   <para>rdfs:label : Contact point</para>
    ///   <para>rdfs:comment : An person, contact point or department to contact in relation to this contracting process.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#ContactPoint">ocds:ContactPoint</a>
    /// </summary>
    let ContactPoint = _prefixId.prefix "ContactPoint"
    /// <summary>
    ///   <para>rdfs:label : Contract</para>
    ///   <para>rdfs:comment : Information regarding the signed contract between the buyer and supplier(s).</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Contract">ocds:Contract</a>
    /// </summary>
    let Contract = _prefixId.prefix "Contract"
    /// <summary>
    ///   <para>rdfs:label : Codelist Contract Status</para>
    ///   <para>rdfs:comment : Contracts can move through multiple states. Releases over time may update the status of a contract.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#ContractStatus">ocds:ContractStatus</a>
    /// </summary>
    let ContractStatus = _prefixId.prefix "ContractStatus"
    /// <summary>
    ///   <para>rdfs:label : Document</para>
    ///   <para>rdfs:comment : Links to, or descriptions of, external documents can be attached at various locations within the standard. Documents may be supporting information, formal notices, downloadable forms, or any other kind of resource that should be made public as part of full open contracting.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Document">ocds:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>rdfs:label : Codelist Document Type</para>
    ///   <para>rdfs:comment : This list provides details of the documents that publishers may wish to provide at various points their contracting process.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#DocumentType">ocds:DocumentType</a>
    /// </summary>
    let DocumentType = _prefixId.prefix "DocumentType"
    /// <summary>
    ///   <para>rdfs:label : Identifier</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Identifier">ocds:Identifier</a>
    /// </summary>
    let Identifier = _prefixId.prefix "Identifier"
    /// <summary>
    ///   <para>rdfs:label : Implementation^^xsd:string</para>
    ///   <para>rdfs:comment : Information during the performance / implementation stage of the contract.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Implementation">ocds:Implementation</a>
    /// </summary>
    let Implementation = _prefixId.prefix "Implementation"
    /// <summary>
    ///   <para>rdfs:label : Codelist Initiation Type</para>
    ///   <para>rdfs:comment : Contracting processes may be formed under a number of different processes. Currently, only ‘tender’ is supported in this codelist. Future versions of the standard may support other Initiation Types. The initiation type may be provide information to consuming applications on the different blocks of data and releases they should expect from a contracting process.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#InitiationType">ocds:InitiationType</a>
    /// </summary>
    let InitiationType = _prefixId.prefix "InitiationType"
    /// <summary>
    ///   <para>rdfs:label : Item</para>
    ///   <para>rdfs:comment : A good, service, or work to be contracted.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Item">ocds:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    let ItemClassificationScheme = _prefixId.prefix "ItemClassificationScheme"
    /// <summary>
    ///   <para>rdfs:label : Lote</para>
    ///   <para>rdfs:comment : Es una conexión de uno o más ítems</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Lot">ocds:Lot</a>
    /// </summary>
    let Lot = _prefixId.prefix "Lot"
    /// <summary>
    ///   <para>rdfs:label : Codelist Method</para>
    ///   <para>rdfs:comment : The method codelist is based upon the GPA Definitions provided here.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Method">ocds:Method</a>
    /// </summary>
    let Method = _prefixId.prefix "Method"
    /// <summary>
    ///   <para>rdfs:label : Milestone</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Milestone">ocds:Milestone</a>
    /// </summary>
    let Milestone = _prefixId.prefix "Milestone"
    /// <summary>
    ///   <para>rdfs:label : Organization</para>
    ///   <para>rdfs:comment : An organization.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Organization">ocds:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>rdfs:label : Codelist Organization Identifier Scheme</para>
    ///   <para>rdfs:comment : The Organization Identifier Scheme currently uses the codes from the International Aid Transparency Initiative ‘Organisation Registration Agency’ codelist. See the identifiers section for more information on organization identifiers.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#OrganizationIdentifierScheme">ocds:OrganizationIdentifierScheme</a>
    /// </summary>
    let OrganizationIdentifierScheme = _prefixId.prefix "OrganizationIdentifierScheme"
    /// <summary>
    ///   <para>rdfs:label : Period</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Period">ocds:Period</a>
    /// </summary>
    let Period = _prefixId.prefix "Period"
    /// <summary>
    ///   <para>rdfs:label : Planning</para>
    ///   <para>rdfs:comment : nformation from the planning phase of the contracting process. Note that many other fields may be filled in a planning release, in the appropriate fields in other schema sections, these would likely be estimates at this stage e.g. totalValue in tender</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Planning">ocds:Planning</a>
    /// </summary>
    let Planning = _prefixId.prefix "Planning"
    /// <summary>
    ///   <para>rdfs:label : Open Contracting Release</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Release">ocds:Release</a>
    /// </summary>
    let Release = _prefixId.prefix "Release"
    /// <summary>
    ///   <para>rdfs:label : Codelist ReleaseTag</para>
    ///   <para>rdfs:comment : A contracting process may result in a number of releases of information over time. These should be tagged to indicate the stage of the contracting process they relate to.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#ReleaseTag">ocds:ReleaseTag</a>
    /// </summary>
    let ReleaseTag = _prefixId.prefix "ReleaseTag"
    /// <summary>
    ///   <para>rdfs:label : Codelist Submission Method</para>
    ///   <para>rdfs:comment : The submission method codelist is used to identify the mechanism through which a submission may be made.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#SubmissionMethod">ocds:SubmissionMethod</a>
    /// </summary>
    let SubmissionMethod = _prefixId.prefix "SubmissionMethod"
    /// <summary>
    ///   <para>rdfs:label : Tender</para>
    ///   <para>rdfs:comment : Data regarding tender process - publicly inviting prospective contractors to submit bids for evaluation and selecting a winner or winners</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Tender">ocds:Tender</a>
    /// </summary>
    let Tender = _prefixId.prefix "Tender"
    /// <summary>
    ///   <para>rdfs:label : Codelist Tender Status</para>
    ///   <para>rdfs:comment : The tender.status field is used to indicate the current status of a tender process.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#TenderStatus">ocds:TenderStatus</a>
    /// </summary>
    let TenderStatus = _prefixId.prefix "TenderStatus"
    /// <summary>
    ///   <para>rdfs:label : Transaction Information</para>
    ///   <para>rdfs:comment : A spending transaction related to the contracting process. Draws upon the data models of the [Budget Data Package](https://github.com/openspending/budget-data-package/blob/master/specification.md) and the [International Aid Transpareny Initiative](http://iatistandard.org/activity-standard/iati-activities/iati-activity/transaction/) and should be used to cross-reference to more detailed information held using a Budget Data Package, IATI file, or to provide enough information to allow a user to manually or automatically cross-reference with some other published source of transactional spending data.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Transaction">ocds:Transaction</a>
    /// </summary>
    let Transaction = _prefixId.prefix "Transaction"
    /// <summary>
    ///   <para>rdfs:label : Unit</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Unit">ocds:Unit</a>
    /// </summary>
    let Unit = _prefixId.prefix "Unit"
    /// <summary>
    ///   <para>rdfs:label : Value</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#Value">ocds:Value</a>
    /// </summary>
    let Value = _prefixId.prefix "Value"
    /// <summary>
    ///   <para>rdfs:label : Additional classifications</para>
    ///   <para>rdfs:comment : An array of additional classifications for the item. See the [itemClassificationScheme](http://standard.open-contracting.org/latest/en/schema/codelists/#item-classification-scheme) codelist for common options to use in OCDS. This may also be used to present codes from an internal classification scheme.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#additionalClassifications">ocds:additionalClassifications</a>
    /// </summary>
    let additionalClassifications = _prefixId.prefix "additionalClassifications"
    /// <summary>
    ///   <para>rdfs:label : Additional identifiers</para>
    ///   <para>rdfs:comment : A list of additional / supplemental identifiers for the organization, using the [organization identifier guidance](http://standard.open-contracting.org/latest/en/schema/identifiers/). This could be used to provide an internally used identifier for this organization in addition to the primary legal entity identifier.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#additionalIdentifiers">ocds:additionalIdentifiers</a>
    /// </summary>
    let additionalIdentifiers = _prefixId.prefix "additionalIdentifiers"
    /// <summary>
    ///   <para>rdfs:label : Address</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#address">ocds:address</a>
    /// </summary>
    let address = _prefixId.prefix "address"
    /// <summary>
    ///   <para>rdfs:label : Amendment Date</para>
    ///   <para>rdfs:comment : The data of this amendment.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#amendmentDate">ocds:amendmentDate</a>
    /// </summary>
    let amendmentDate = _prefixId.prefix "amendmentDate"
    /// <summary>
    ///   <para>rdfs:label : Amendment rationale</para>
    ///   <para>rdfs:comment : An explanation for the amendment.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#amendmentRationale">ocds:amendmentRationale</a>
    /// </summary>
    let amendmentRationale = _prefixId.prefix "amendmentRationale"
    /// <summary>
    ///   <para>rdfs:label : Awards</para>
    ///   <para>rdfs:comment : Information from the award phase of the contracting process. There may be more than one award per contracting process e.g. because the contract is split amongst different providers, or because it is a standing offer.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#award">ocds:award</a>
    /// </summary>
    let award = _prefixId.prefix "award"
    /// <summary>
    ///   <para>rdfs:label : Award amendment</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#awardAmendment">ocds:awardAmendment</a>
    /// </summary>
    let awardAmendment = _prefixId.prefix "awardAmendment"
    /// <summary>
    ///   <para>rdfs:label : Award criteria</para>
    ///   <para>rdfs:comment : Specify the award criteria for the procurement, using the [award criteria codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#award-criteria)</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#awardCriteria">ocds:awardCriteria</a>
    /// </summary>
    let awardCriteria = _prefixId.prefix "awardCriteria"
    let awardCriteriaBestProposal = _prefixId.prefix "awardCriteriaBestProposal"

    let awardCriteriaBestValueToGovernment =
        _prefixId.prefix "awardCriteriaBestValueToGovernment"

    /// <summary>
    ///   <para>rdfs:label : Award criteria details</para>
    ///   <para>rdfs:comment : Any detailed or further information on the award or selection criteria.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#awardCriteriaDetails">ocds:awardCriteriaDetails</a>
    /// </summary>
    let awardCriteriaDetails = _prefixId.prefix "awardCriteriaDetails"
    let awardCriteriaLowestCost = _prefixId.prefix "awardCriteriaLowestCost"
    let awardCriteriaSingleBidOnly = _prefixId.prefix "awardCriteriaSingleBidOnly"
    /// <summary>
    ///   <para>rdfs:label : Award date</para>
    ///   <para>rdfs:comment : The date of the contract award. This is usually the date on which a decision to award was made.^^xsd:string</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#awardDate">ocds:awardDate</a>
    /// </summary>
    let awardDate = _prefixId.prefix "awardDate"
    /// <summary>
    ///   <para>rdfs:label : Award description^^xsd:string</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#awardDescription">ocds:awardDescription</a>
    /// </summary>
    let awardDescription = _prefixId.prefix "awardDescription"
    /// <summary>
    ///   <para>rdfs:label : Award documents</para>
    ///   <para>rdfs:comment : All documents and attachments related to the award, including any notices.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#awardDocuments">ocds:awardDocuments</a>
    /// </summary>
    let awardDocuments = _prefixId.prefix "awardDocuments"
    let awardFollows = _prefixId.prefix "awardFollows"
    /// <summary>
    ///   <para>rdfs:label : Award ID</para>
    ///   <para>rdfs:comment : The award against which this contract is being issued.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#awardID">ocds:awardID</a>
    /// </summary>
    let awardID = _prefixId.prefix "awardID"
    /// <summary>
    ///   <para>rdfs:label : Award ID</para>
    ///   <para>rdfs:comment : The identifier for this award. It must be unique and cannot change within the Open Contracting Process it is part of (defined by a single ocid). See the [identifier guidance](http://standard.open-contracting.org/latest/en/schema/identifiers/) for further details.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#awardId">ocds:awardId</a>
    /// </summary>
    let awardId = _prefixId.prefix "awardId"
    /// <summary>
    ///   <para>rdfs:label : Award period</para>
    ///   <para>rdfs:comment : The date or period on which an award is anticipated to be made.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#awardPeriod">ocds:awardPeriod</a>
    /// </summary>
    let awardPeriod = _prefixId.prefix "awardPeriod"
    let awardPrecedes = _prefixId.prefix "awardPrecedes"
    /// <summary>
    ///   <para>rdfs:label : Award status^^xsd:string</para>
    ///   <para>rdfs:comment : The current status of the award drawn from the [awardStatus codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#award-status)^^xsd:string</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#awardStatus">ocds:awardStatus</a>
    /// </summary>
    let awardStatus = _prefixId.prefix "awardStatus"
    let awardStatusActive = _prefixId.prefix "awardStatusActive"
    let awardStatusCancelled = _prefixId.prefix "awardStatusCancelled"
    let awardStatusPending = _prefixId.prefix "awardStatusPending"
    let awardStatusUnsuccessful = _prefixId.prefix "awardStatusUnsuccessful"
    /// <summary>
    ///   <para>rdfs:label : Award title</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#awardTitle">ocds:awardTitle</a>
    /// </summary>
    let awardTitle = _prefixId.prefix "awardTitle"
    let awardURL = _prefixId.prefix "awardURL"
    /// <summary>
    ///   <para>rdfs:label : Award value</para>
    ///   <para>rdfs:comment : The total value of this award. In the case of a framework contract this may be the total estimated lifetime value, or maximum value, of the agreement. There may be more than one award per procurement.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#awardValue">ocds:awardValue</a>
    /// </summary>
    let awardValue = _prefixId.prefix "awardValue"
    /// <summary>
    ///   <para>rdfs:label : Budget</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#budget">ocds:budget</a>
    /// </summary>
    let budget = _prefixId.prefix "budget"
    /// <summary>
    ///   <para>rdfs:label : Budget amount</para>
    ///   <para>rdfs:comment : The value of the budget line item.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#budgetAmount">ocds:budgetAmount</a>
    /// </summary>
    let budgetAmount = _prefixId.prefix "budgetAmount"
    let budgetDescription = _prefixId.prefix "budgetDescription"
    /// <summary>
    ///   <para>rdfs:label : Budget ID</para>
    ///   <para>rdfs:comment : An identifier for the budget line item which provides funds for this contracting process. This identifier should be possible to cross-reference against the provided data source.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#budgetId">ocds:budgetId</a>
    /// </summary>
    let budgetId = _prefixId.prefix "budgetId"
    /// <summary>
    ///   <para>rdfs:label : Budget Data Source</para>
    ///   <para>rdfs:comment : Used to point either to a corresponding Budget Data Package, or to a machine or human-readable source where users can find further information on the budget line item identifiers, or project identifiers, provided here.^^xsd:string</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#budgetSource">ocds:budgetSource</a>
    /// </summary>
    let budgetSource = _prefixId.prefix "budgetSource"
    /// <summary>
    ///   <para>rdfs:label : Linked budget information</para>
    ///   <para>rdfs:comment : A URI pointing directly to a machine-readable record about the related budget or projects for this contracting process.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#budgetUri">ocds:budgetUri</a>
    /// </summary>
    let budgetUri = _prefixId.prefix "budgetUri"
    /// <summary>
    ///   <para>rdfs:label : Buyer</para>
    ///   <para>rdfs:comment : The buyer is the entity whose budget will be used to purchase the goods. This may be different from the procuring agency who may be specified in the tender data.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#buyer">ocds:buyer</a>
    /// </summary>
    let buyer = _prefixId.prefix "buyer"
    /// <summary>
    ///   <para>rdfs:label : Amended fields</para>
    ///   <para>rdfs:comment : Comma-separated list of affected fields.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#changes">ocds:changes</a>
    /// </summary>
    let changes = _prefixId.prefix "changes"
    /// <summary>
    ///   <para>rdfs:label : Classification</para>
    ///   <para>rdfs:comment : The primary classification for the item. See the [itemClassificationScheme](http://standard.open-contracting.org/latest/en/schema/codelists/#item-classification-scheme) to identify preferred classification lists, including CPV and GSIN.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#classification">ocds:classification</a>
    /// </summary>
    let classification = _prefixId.prefix "classification"
    /// <summary>
    ///   <para>rdfs:label : Classification description</para>
    ///   <para>rdfs:comment : A textual description or title for the code.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#classificationDescription">ocds:classificationDescription</a>
    /// </summary>
    let classificationDescription = _prefixId.prefix "classificationDescription"
    /// <summary>
    ///   <para>rdfs:label : Classification ID</para>
    ///   <para>rdfs:comment : The classification code drawn from the selected scheme.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#classificationId">ocds:classificationId</a>
    /// </summary>
    let classificationId = _prefixId.prefix "classificationId"
    /// <summary>
    ///   <para>rdfs:label : Classification scheme</para>
    ///   <para>rdfs:comment : An classification should be drawn from an existing scheme or list of codes. This field is used to indicate the scheme/codelist from which the classification is drawn. For line item classifications, this value should represent an known [Item Classification Scheme](http://standard.open-contracting.org/latest/en/schema/codelists/#item-classification-scheme) wherever possible.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#classificationScheme">ocds:classificationScheme</a>
    /// </summary>
    let classificationScheme = _prefixId.prefix "classificationScheme"
    /// <summary>
    ///   <para>rdfs:label : Classification URI</para>
    ///   <para>rdfs:comment : A URI to identify the code. In the event individual URIs are not available for items in the identifier scheme this value should be left blank.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#classificationUri">ocds:classificationUri</a>
    /// </summary>
    let classificationUri = _prefixId.prefix "classificationUri"
    /// <summary>
    ///   <para>rdfs:label : Contact point</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#contactPoint">ocds:contactPoint</a>
    /// </summary>
    let contactPoint = _prefixId.prefix "contactPoint"
    /// <summary>
    ///   <para>rdfs:label : Contact point name</para>
    ///   <para>rdfs:comment : The name of the contact person, department, or contact point, for correspondence relating to this contracting process.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#contactPointName">ocds:contactPointName</a>
    /// </summary>
    let contactPointName = _prefixId.prefix "contactPointName"
    /// <summary>
    ///   <para>rdfs:label : Contact point URL</para>
    ///   <para>rdfs:comment : A web address for the contact point/person.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#contactPointUrl">ocds:contactPointUrl</a>
    /// </summary>
    let contactPointUrl = _prefixId.prefix "contactPointUrl"
    /// <summary>
    ///   <para>rdfs:label : Contract amendment</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#contractAmendment">ocds:contractAmendment</a>
    /// </summary>
    let contractAmendment = _prefixId.prefix "contractAmendment"
    /// <summary>
    ///   <para>rdfs:label : Contract description</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#contractDescription">ocds:contractDescription</a>
    /// </summary>
    let contractDescription = _prefixId.prefix "contractDescription"
    /// <summary>
    ///   <para>rdfs:label : Contract documents</para>
    ///   <para>rdfs:comment : All documents and attachments related to the contract, including any notices.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#contractDocuments">ocds:contractDocuments</a>
    /// </summary>
    let contractDocuments = _prefixId.prefix "contractDocuments"
    let contractFollows = _prefixId.prefix "contractFollows"
    /// <summary>
    ///   <para>rdfs:label : Contract ID</para>
    ///   <para>rdfs:comment : The identifier for this contract. It must be unique and cannot change within its Open Contracting Process (defined by a single ocid). See the [identifier guidance](http://standard.open-contracting.org/latest/en/schema/identifiers/) for further details.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#contractId">ocds:contractId</a>
    /// </summary>
    let contractId = _prefixId.prefix "contractId"
    /// <summary>
    ///   <para>rdfs:label : Items Contracted</para>
    ///   <para>rdfs:comment : The goods, services, and any intangible outcomes in this contract. Note: If the items are the same as the award do not repeat.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#contractItems">ocds:contractItems</a>
    /// </summary>
    let contractItems = _prefixId.prefix "contractItems"
    /// <summary>
    ///   <para>rdfs:label : Contract lots</para>
    ///   <para>rdfs:comment : List of lots associated with the contract</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#contractLots">ocds:contractLots</a>
    /// </summary>
    let contractLots = _prefixId.prefix "contractLots"
    /// <summary>
    ///   <para>rdfs:label : Contract period</para>
    ///   <para>rdfs:comment : The period for which the contract has been awarded.rdfs:comment : The start and end date for the contract.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#contractPeriod">ocds:contractPeriod</a>
    /// </summary>
    let contractPeriod = _prefixId.prefix "contractPeriod"
    /// <summary>
    ///   <para>rdfs:label : Contract status</para>
    ///   <para>rdfs:comment : The current status of the contract. Drawn from the [contractStatus codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#contract-status)</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#contractStatus">ocds:contractStatus</a>
    /// </summary>
    let contractStatus = _prefixId.prefix "contractStatus"
    let contractStatusActive = _prefixId.prefix "contractStatusActive"
    let contractStatusCancelled = _prefixId.prefix "contractStatusCancelled"
    let contractStatusPending = _prefixId.prefix "contractStatusPending"
    let contractStatusTerminated = _prefixId.prefix "contractStatusTerminated"
    /// <summary>
    ///   <para>rdfs:label : Contract Suppliers</para>
    ///   <para>rdfs:comment : The suppliers awarded this contract. Is an implementacion of DNCP</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#contractSuppliers">ocds:contractSuppliers</a>
    /// </summary>
    let contractSuppliers = _prefixId.prefix "contractSuppliers"
    /// <summary>
    ///   <para>rdfs:label : Contract title^^xsd:string</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#contractTitle">ocds:contractTitle</a>
    /// </summary>
    let contractTitle = _prefixId.prefix "contractTitle"
    /// <summary>
    ///   <para>rdfs:label : Contract value</para>
    ///   <para>rdfs:comment : The total value of this contract.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#contractValue">ocds:contractValue</a>
    /// </summary>
    let contractValue = _prefixId.prefix "contractValue"
    /// <summary>
    ///   <para>rdfs:label : Contracts</para>
    ///   <para>rdfs:comment : Information from the contract creation phase of the procurement process.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#contracts">ocds:contracts</a>
    /// </summary>
    let contracts = _prefixId.prefix "contracts"
    /// <summary>
    ///   <para>rdfs:label : Country name</para>
    ///   <para>rdfs:comment : The country name. For example, United States.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#countryName">ocds:countryName</a>
    /// </summary>
    let countryName = _prefixId.prefix "countryName"
    /// <summary>
    ///   <para>rdfs:label : Currency</para>
    ///   <para>rdfs:comment : The currency in 3-letter ISO 4217 format.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#currency">ocds:currency</a>
    /// </summary>
    let currency = _prefixId.prefix "currency"
    /// <summary>
    ///   <para>rdfs:label : Publication date</para>
    ///   <para>rdfs:comment : The date on which the document was first published. This is particularly important for legally important documents such as notices of a tender.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#datePublished">ocds:datePublished</a>
    /// </summary>
    let datePublished = _prefixId.prefix "datePublished"
    /// <summary>
    ///   <para>rdfs:label : Date of signature</para>
    ///   <para>rdfs:comment : The date the contract was signed. In the case of multiple signatures, the date of the last signature.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#dateSigned">ocds:dateSigned</a>
    /// </summary>
    let dateSigned = _prefixId.prefix "dateSigned"
    /// <summary>
    ///   <para>rdfs:label : Código de contrato</para>
    ///   <para>rdfs:comment : Código de contrato de la DNCP</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#dncpContractCode">ocds:dncpContractCode</a>
    /// </summary>
    let dncpContractCode = _prefixId.prefix "dncpContractCode"
    /// <summary>
    ///   <para>rdfs:label : Document modification date</para>
    ///   <para>rdfs:comment : Date that the document was last modified</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#documentDateModified">ocds:documentDateModified</a>
    /// </summary>
    let documentDateModified = _prefixId.prefix "documentDateModified"
    /// <summary>
    ///   <para>rdfs:label : Document description</para>
    ///   <para>rdfs:comment : A short description of the document. We recommend descriptions do not exceed 250 words. In the event the document is not accessible online, the description field can be used to describe arrangements for obtaining a copy of the document.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#documentDescription">ocds:documentDescription</a>
    /// </summary>
    let documentDescription = _prefixId.prefix "documentDescription"
    /// <summary>
    ///   <para>rdfs:label : Document ID</para>
    ///   <para>rdfs:comment : A local, unique identifier for this document. This field is used to keep track of multiple revisions of a document through the compilation from release to record mechanism.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#documentId">ocds:documentId</a>
    /// </summary>
    let documentId = _prefixId.prefix "documentId"
    /// <summary>
    ///   <para>rdfs:label : Document language</para>
    ///   <para>rdfs:comment : Specifies the language of the linked document using either two-digit [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes), or extended [BCP47 language tags](http://www.w3.org/International/articles/language-tags/). The use of two-letter codes from [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) is strongly recommended unless there is a clear user need for distinguishing the language subtype.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#documentLanguage">ocds:documentLanguage</a>
    /// </summary>
    let documentLanguage = _prefixId.prefix "documentLanguage"
    /// <summary>
    ///   <para>rdfs:label : Document title</para>
    ///   <para>rdfs:comment : The document title.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#documentTitle">ocds:documentTitle</a>
    /// </summary>
    let documentTitle = _prefixId.prefix "documentTitle"
    /// <summary>
    ///   <para>rdfs:label : Document type</para>
    ///   <para>rdfs:comment : A classification of the document described taken from the [documentType codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#document-type). Values from the provided codelist should be used wherever possible, though extended values can be provided if the codelist does not have a relevant code.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#documentType">ocds:documentType</a>
    /// </summary>
    let documentType = _prefixId.prefix "documentType"
    let documentTypeAwardNotice = _prefixId.prefix "documentTypeAwardNotice"
    let documentTypeTenderNotice = _prefixId.prefix "documentTypeTenderNotice"
    /// <summary>
    ///   <para>rdfs:label : Document URL</para>
    ///   <para>rdfs:comment : Direct link to the document or attachment. The server providing access to this document should be configured to correctly report the document mime type.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#documentUrl">ocds:documentUrl</a>
    /// </summary>
    let documentUrl = _prefixId.prefix "documentUrl"
    /// <summary>
    ///   <para>rdfs:label : Documents</para>
    ///   <para>rdfs:comment : A list of documents related to the planning process.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#documents">ocds:documents</a>
    /// </summary>
    let documents = _prefixId.prefix "documents"
    /// <summary>
    ///   <para>rdfs:label : Due date</para>
    ///   <para>rdfs:comment : The date the milestone is due.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#dueDate">ocds:dueDate</a>
    /// </summary>
    let dueDate = _prefixId.prefix "dueDate"
    /// <summary>
    ///   <para>rdfs:label : Eligibility criteria</para>
    ///   <para>rdfs:comment : A description of any eligibility criteria for potential suppliers.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#eligibilityCriteria">ocds:eligibilityCriteria</a>
    /// </summary>
    let eligibilityCriteria = _prefixId.prefix "eligibilityCriteria"
    /// <summary>
    ///   <para>rdfs:label : Email</para>
    ///   <para>rdfs:comment : The e-mail address of the contact point/person.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#email">ocds:email</a>
    /// </summary>
    let email = _prefixId.prefix "email"
    /// <summary>
    ///   <para>rdfs:label : End date</para>
    ///   <para>rdfs:comment : The end date for the period.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#endDate">ocds:endDate</a>
    /// </summary>
    let endDate = _prefixId.prefix "endDate"
    /// <summary>
    ///   <para>rdfs:label : Enquiry period</para>
    ///   <para>rdfs:comment : The period during which enquiries may be made and answered.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#enquiryPeriod">ocds:enquiryPeriod</a>
    /// </summary>
    let enquiryPeriod = _prefixId.prefix "enquiryPeriod"
    /// <summary>
    ///   <para>rdfs:label : Fax number</para>
    ///   <para>rdfs:comment : The fax number of the contact point/person. This should include the international dialling code.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#faxNumber">ocds:faxNumber</a>
    /// </summary>
    let faxNumber = _prefixId.prefix "faxNumber"
    /// <summary>
    ///   <para>rdfs:label : Format</para>
    ///   <para>rdfs:comment : The format of the document taken from the [IANA Media Types code list](http://www.iana.org/assignments/media-types/), with the addition of one extra value for 'offline/print', used when this document entry is being used to describe the offline publication of a document. Use values from the template column. Links to web pages should be tagged 'text/html'.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#format">ocds:format</a>
    /// </summary>
    let format = _prefixId.prefix "format"
    /// <summary>
    ///   <para>rdfs:label : Former value</para>
    ///   <para>rdfs:comment : The previous value of the changed property, in whatever type the property is.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#former_value">ocds:former_value</a>
    /// </summary>
    let former_value = _prefixId.prefix "former_value"
    /// <summary>
    ///   <para>rdfs:label : Has enquiries</para>
    ///   <para>rdfs:comment :  Yes/No field to indicate whether enquiries were part of tender process.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#hasEnquiries">ocds:hasEnquiries</a>
    /// </summary>
    let hasEnquiries = _prefixId.prefix "hasEnquiries"
    let ics_CDNCP = _prefixId.prefix "ics_CDNCP"
    let ics_CPV = _prefixId.prefix "ics_CPV"
    let ics_CPVS = _prefixId.prefix "ics_CPVS"
    let ics_GSIN = _prefixId.prefix "ics_GSIN"
    let ics_UNSPSC = _prefixId.prefix "ics_UNSPSC"
    /// <summary>
    ///   <para>rdfs:label : Release ID^^xsd:string</para>
    ///   <para>rdfs:comment : A unique identifier that identifies this release. A release ID must be unique within a release-package and must not contain the # character.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#id">ocds:id</a>
    /// </summary>
    let id = _prefixId.prefix "id"
    /// <summary>
    ///   <para>rdfs:label : Organization identifier</para>
    ///   <para>rdfs:comment : The primary identifier for this organization. Identifiers that uniquely pick out a legal entity should be preferred. Consult the [organization identifier guidance](http://standard.open-contracting.org/latest/en/schema/identifiers/) for the preferred scheme and identifier to use.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#identifier">ocds:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>rdfs:label : Identifier ID</para>
    ///   <para>rdfs:comment : The identifier of the organization in the selected scheme.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#identifierId">ocds:identifierId</a>
    /// </summary>
    let identifierId = _prefixId.prefix "identifierId"
    /// <summary>
    ///   <para>rdfs:label : Identifier scheme</para>
    ///   <para>rdfs:comment : Organization identifiers be drawn from an existing identification scheme. This field is used to indicate the scheme or codelist in which the identifier will be found. This value should be drawn from the [Organization Identifier Scheme](http://standard.open-contracting.org/latest/en/schema/codelists/#organization-identifier-scheme).</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#identifierScheme">ocds:identifierScheme</a>
    /// </summary>
    let identifierScheme = _prefixId.prefix "identifierScheme"
    /// <summary>
    ///   <para>rdfs:label : Identifier URI</para>
    ///   <para>rdfs:comment : A URI to identify the organization, such as those provided by [Open Corporates](http://www.opencorporates.com) or some other relevant URI provider. This is not for listing the website of the organization: that can be done through the url field of the Organization contact point.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#identifierUri">ocds:identifierUri</a>
    /// </summary>
    let identifierUri = _prefixId.prefix "identifierUri"
    /// <summary>
    ///   <para>rdfs:label : Implementation</para>
    ///   <para>rdfs:comment : Information related to the implementation of the contract in accordance with the obligations laid out therein.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#implementation">ocds:implementation</a>
    /// </summary>
    let implementation = _prefixId.prefix "implementation"
    /// <summary>
    ///   <para>rdfs:label : Implementation documents</para>
    ///   <para>rdfs:comment : Documents and reports that are part of the implementation phase e.g. audit and evaluation reports.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#implementationDocuments">ocds:implementationDocuments</a>
    /// </summary>
    let implementationDocuments = _prefixId.prefix "implementationDocuments"
    /// <summary>
    ///   <para>rdfs:label : Implementation milestones</para>
    ///   <para>rdfs:comment : As milestones are completed, milestone completions should be documented.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#implementationMilestones">ocds:implementationMilestones</a>
    /// </summary>
    let implementationMilestones = _prefixId.prefix "implementationMilestones"
    /// <summary>
    ///   <para>rdfs:label : Initiation Type</para>
    ///   <para>rdfs:comment : String specifying the type of initiation process used for this contract, taken from the [initiationType](http://standard.open-contracting.org/latest/en/schema/codelists/#initiation-type) codelist. Currently only tender is supported.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#initiationType">ocds:initiationType</a>
    /// </summary>
    let initiationType = _prefixId.prefix "initiationType"
    let initiationTypeTender = _prefixId.prefix "initiationTypeTender"
    /// <summary>
    ///   <para>rdfs:label : Item description</para>
    ///   <para>rdfs:comment : A description of the goods, services to be provided.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#itemDescription">ocds:itemDescription</a>
    /// </summary>
    let itemDescription = _prefixId.prefix "itemDescription"
    /// <summary>
    ///   <para>rdfs:label : Item ID</para>
    ///   <para>rdfs:comment : A local identifier to reference and merge the items by. Must be unique within a given array of items.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#itemId">ocds:itemId</a>
    /// </summary>
    let itemId = _prefixId.prefix "itemId"
    /// <summary>
    ///   <para>rdfs:label : Legal name</para>
    ///   <para>rdfs:comment : The legally registered name of the organization.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#legalName">ocds:legalName</a>
    /// </summary>
    let legalName = _prefixId.prefix "legalName"
    /// <summary>
    ///   <para>rdfs:label : Locality</para>
    ///   <para>rdfs:comment : The locality. For example, Mountain View.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#locality">ocds:locality</a>
    /// </summary>
    let locality = _prefixId.prefix "locality"
    let lotId = _prefixId.prefix "lotId"
    let lotItems = _prefixId.prefix "lotItems"
    let lotTitle = _prefixId.prefix "lotTitle"
    let methodLimited = _prefixId.prefix "methodLimited"
    let methodOpen = _prefixId.prefix "methodOpen"
    let methodSelective = _prefixId.prefix "methodSelective"
    /// <summary>
    ///   <para>rdfs:label : Milestone modification date</para>
    ///   <para>rdfs:comment : The date the milestone was last reviewed or modified and the status was altered or confirmed to still be correct.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#milestoneDateModified">ocds:milestoneDateModified</a>
    /// </summary>
    let milestoneDateModified = _prefixId.prefix "milestoneDateModified"
    /// <summary>
    ///   <para>rdfs:label : Milestone description</para>
    ///   <para>rdfs:comment : A description of the milestone.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#milestoneDescription">ocds:milestoneDescription</a>
    /// </summary>
    let milestoneDescription = _prefixId.prefix "milestoneDescription"
    /// <summary>
    ///   <para>rdfs:label : Milestone documents</para>
    ///   <para>rdfs:comment : List of documents associated with this milestone.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#milestoneDocuments">ocds:milestoneDocuments</a>
    /// </summary>
    let milestoneDocuments = _prefixId.prefix "milestoneDocuments"
    /// <summary>
    ///   <para>rdfs:label : Milestone ID</para>
    ///   <para>rdfs:comment : A local identifier for this milestone, unique within this block. This field is used to keep track of multiple revisions of a milestone through the compilation from release to record mechanism.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#milestoneId">ocds:milestoneId</a>
    /// </summary>
    let milestoneId = _prefixId.prefix "milestoneId"
    /// <summary>
    ///   <para>rdfs:label : Milestone status</para>
    ///   <para>rdfs:comment : The status that was realized on the date provided in dateModified, drawn from the [milestoneStatus codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#milestone-status).</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#milestoneStatus">ocds:milestoneStatus</a>
    /// </summary>
    let milestoneStatus = _prefixId.prefix "milestoneStatus"
    /// <summary>
    ///   <para>rdfs:label : Milestone title</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#milestoneTitle">ocds:milestoneTitle</a>
    /// </summary>
    let milestoneTitle = _prefixId.prefix "milestoneTitle"
    /// <summary>
    ///   <para>rdfs:label : Milestones</para>
    ///   <para>rdfs:comment : A list of milestones associated with the tender.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#milestones">ocds:milestones</a>
    /// </summary>
    let milestones = _prefixId.prefix "milestones"
    /// <summary>
    ///   <para>rdfs:label : Minimum value</para>
    ///   <para>rdfs:comment : The minimum estimated value of the procurement.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#minValue">ocds:minValue</a>
    /// </summary>
    let minValue = _prefixId.prefix "minValue"
    /// <summary>
    ///   <para>rdfs:label : Number of tenders</para>
    ///   <para>rdfs:comment : The number of entities who submit a tender.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#numberOfTenderers">ocds:numberOfTenderers</a>
    /// </summary>
    let numberOfTenderers = _prefixId.prefix "numberOfTenderers"
    /// <summary>
    ///   <para>rdfs:label : Open Contracting ID</para>
    ///   <para>rdfs:comment : A globally unique identifier for this Open Contracting Process. Composed of a publisher prefix and an identifier for the contracting process. For more information see the [Open Contracting Identifier guidance](http://standard.open-contracting.org/latest/en/schema/identifiers/)</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#ocid">ocds:ocid</a>
    /// </summary>
    let ocid = _prefixId.prefix "ocid"
    let ois_AF_CBR = _prefixId.prefix "ois_AF-CBR"
    let ois_AF_MOE = _prefixId.prefix "ois_AF-MOE"
    /// <summary>
    ///   <para>rdfs:label : Organization name</para>
    ///   <para>rdfs:comment : The common name of the organization. The ID property provides an space for the formal legal name, and so this may either repeat that value, or could provide the common name by which this organization is known. This field could also include details of the department or sub-unit involved in this contracting process.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#organizationName">ocds:organizationName</a>
    /// </summary>
    let organizationName = _prefixId.prefix "organizationName"
    /// <summary>
    ///   <para>rdfs:label : Planning</para>
    ///   <para>rdfs:comment : Information from the planning phase of the contracting process. This includes information related to the process of deciding what to contract for, when and how.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#planning">ocds:planning</a>
    /// </summary>
    let planning = _prefixId.prefix "planning"
    let planningPrecedes = _prefixId.prefix "planningPrecedes"
    /// <summary>
    ///   <para>rdfs:label : Planning rationale</para>
    ///   <para>rdfs:comment : The rationale for the procurement provided in free text. More detail can be provided in an attached document.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#planningRationale">ocds:planningRationale</a>
    /// </summary>
    let planningRationale = _prefixId.prefix "planningRationale"
    /// <summary>
    ///   <para>rdfs:label : Planning URL</para>
    ///   <para>rdfs:comment : Url para poder identificar el servicio que es utilizado para generar la planificación</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#planningUrl">ocds:planningUrl</a>
    /// </summary>
    let planningUrl = _prefixId.prefix "planningUrl"
    /// <summary>
    ///   <para>rdfs:label : Postal code</para>
    ///   <para>rdfs:comment : The postal code. For example, 94043.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#postalCode">ocds:postalCode</a>
    /// </summary>
    let postalCode = _prefixId.prefix "postalCode"
    /// <summary>
    ///   <para>rdfs:label : Procurement method</para>
    ///   <para>rdfs:comment : Specify tendering method against the [method codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#method) as per [GPA definitions](http://www.wto.org/english/docs_e/legal_e/rev-gpr-94_01_e.htm) of Open, Selective, Limited</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#procurementMethod">ocds:procurementMethod</a>
    /// </summary>
    let procurementMethod = _prefixId.prefix "procurementMethod"
    /// <summary>
    ///   <para>rdfs:label : Procurement method rationale</para>
    ///   <para>rdfs:comment : Rationale of procurement method, especially in the case of Limited tendering.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#procurementMethodRationale">ocds:procurementMethodRationale</a>
    /// </summary>
    let procurementMethodRationale = _prefixId.prefix "procurementMethodRationale"
    /// <summary>
    ///   <para>rdfs:label : Procuring entity</para>
    ///   <para>rdfs:comment : The entity managing the procurement, which may be different from the buyer who is paying / using the items being procured.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#procuringEntity">ocds:procuringEntity</a>
    /// </summary>
    let procuringEntity = _prefixId.prefix "procuringEntity"
    /// <summary>
    ///   <para>rdfs:label : Project Title</para>
    ///   <para>rdfs:comment : The name of the project that through which this contracting process is funded (if applicable). Some organizations maintain a registry of projects, and the data should use the name by which the project is known in that registry. No translation option is offered for this string, as translated values can be provided in third-party data, linked from the data source above.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#project">ocds:project</a>
    /// </summary>
    let project = _prefixId.prefix "project"
    /// <summary>
    ///   <para>rdfs:label : Project Identifier</para>
    ///   <para>rdfs:comment : An external identifier for the project that this contracting process forms part of, or is funded via (if applicable). Some organizations maintain a registry of projects, and the data should use the identifier from the relevant registry of projects.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#projectID">ocds:projectID</a>
    /// </summary>
    let projectID = _prefixId.prefix "projectID"
    /// <summary>
    ///   <para>rdfs:label : Property</para>
    ///   <para>rdfs:comment : The property name that has been changed relative to the place the amendment is. For example if the contract value has changed, then the property under changes within the contract.amendment would be value.amount.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#property">ocds:property</a>
    /// </summary>
    let property = _prefixId.prefix "property"
    /// <summary>
    ///   <para>rdfs:label : Provider organization</para>
    ///   <para>rdfs:comment : The Organization Identifier for the organization from which the funds in this transaction originate. Expressed following the Organizational Identifier standard - consult the documentation and the codelist.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#providerOrganization">ocds:providerOrganization</a>
    /// </summary>
    let providerOrganization = _prefixId.prefix "providerOrganization"
    /// <summary>
    ///   <para>rdfs:label : quantity</para>
    ///   <para>rdfs:comment : The number of units required</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#quantity">ocds:quantity</a>
    /// </summary>
    let quantity = _prefixId.prefix "quantity"
    /// <summary>
    ///   <para>rdfs:label : Receiver organization</para>
    ///   <para>rdfs:comment : The Organization Identifier for the organization which receives the funds in this transaction. Expressed following the Organizational Identifier standard - consult the documentation and the codelist.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#receiverOrganization">ocds:receiverOrganization</a>
    /// </summary>
    let receiverOrganization = _prefixId.prefix "receiverOrganization"
    /// <summary>
    ///   <para>rdfs:label : Region</para>
    ///   <para>rdfs:comment : The region. For example, CA.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#region">ocds:region</a>
    /// </summary>
    let region = _prefixId.prefix "region"
    /// <summary>
    ///   <para>rdfs:label : Release Date^^xsd:string</para>
    ///   <para>rdfs:comment : The date this information is released, it may well be the same as the parent publishedDate, it must not be later than the publishedDate from the parent package. It is used to determine merge order.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#releaseDate">ocds:releaseDate</a>
    /// </summary>
    let releaseDate = _prefixId.prefix "releaseDate"
    /// <summary>
    ///   <para>rdfs:label : Release language</para>
    ///   <para>rdfs:comment : pecifies the default language of the data using either two-digit ISO 639-1, or extended BCP47 language tags. The use of two-letter codes from ISO 639-1 is strongly recommended.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#releaseLanguage">ocds:releaseLanguage</a>
    /// </summary>
    let releaseLanguage = _prefixId.prefix "releaseLanguage"
    let releaseTagAward = _prefixId.prefix "releaseTagAward"
    let releaseTagAwardCancellation = _prefixId.prefix "releaseTagAwardCancellation"
    let releaseTagAwardUpdate = _prefixId.prefix "releaseTagAwardUpdate"
    let releaseTagCompiled = _prefixId.prefix "releaseTagCompiled"
    let releaseTagContract = _prefixId.prefix "releaseTagContract"
    let releaseTagContractAmendment = _prefixId.prefix "releaseTagContractAmendment"
    let releaseTagContractTermination = _prefixId.prefix "releaseTagContractTermination"
    let releaseTagContractUpdate = _prefixId.prefix "releaseTagContractUpdate"
    let releaseTagImplementation = _prefixId.prefix "releaseTagImplementation"

    let releaseTagImplementationUpdate =
        _prefixId.prefix "releaseTagImplementationUpdate"

    let releaseTagPlanning = _prefixId.prefix "releaseTagPlanning"
    let releaseTagTender = _prefixId.prefix "releaseTagTender"
    let releaseTagTenderAmendment = _prefixId.prefix "releaseTagTenderAmendment"
    let releaseTagTenderCancellation = _prefixId.prefix "releaseTagTenderCancellation"
    let releaseTagTenderUpdate = _prefixId.prefix "releaseTagTenderUpdate"
    /// <summary>
    ///   <para>rdfs:label : Start date</para>
    ///   <para>rdfs:comment : The start date for the period.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#startDate">ocds:startDate</a>
    /// </summary>
    let startDate = _prefixId.prefix "startDate"
    /// <summary>
    ///   <para>rdfs:label : Street address</para>
    ///   <para>rdfs:comment : The street address. For example, 1600 Amphitheatre Pkwy</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#streetAddress">ocds:streetAddress</a>
    /// </summary>
    let streetAddress = _prefixId.prefix "streetAddress"
    /// <summary>
    ///   <para>rdfs:label : Submission method</para>
    ///   <para>rdfs:comment : pecify the method by which bids must be submitted, in person, written, or electronic auction. Using the [submission method codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#submission-method)</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#submissionMethod">ocds:submissionMethod</a>
    /// </summary>
    let submissionMethod = _prefixId.prefix "submissionMethod"
    /// <summary>
    ///   <para>rdfs:label : Submission method details</para>
    ///   <para>rdfs:comment : Any detailed or further information on the submission method. This may include the address, e-mail address or online service to which bids should be submitted, and any special requirements to be followed for submissions.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#submissionMethodDetails">ocds:submissionMethodDetails</a>
    /// </summary>
    let submissionMethodDetails = _prefixId.prefix "submissionMethodDetails"

    let submissionMethodElectronicAuction =
        _prefixId.prefix "submissionMethodElectronicAuction"

    let submissionMethodElectronicSubmission =
        _prefixId.prefix "submissionMethodElectronicSubmission"

    let submissionMethodInPerson = _prefixId.prefix "submissionMethodInPerson"
    let submissionMethodWritten = _prefixId.prefix "submissionMethodWritten"
    /// <summary>
    ///   <para>rdfs:label : Suppliers</para>
    ///   <para>rdfs:comment : The suppliers awarded this award. If different suppliers have been awarded different items of values, these should be split into separate award blocks.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#suppliers">ocds:suppliers</a>
    /// </summary>
    let suppliers = _prefixId.prefix "suppliers"
    /// <summary>
    ///   <para>rdfs:label : Release Tag</para>
    ///   <para>rdfs:comment : A value from the [releaseTag codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#release-tag) that identifies the nature of the release being made. Tags may be used to filter release, or, in future, for for advanced validation when certain kinds of releases should contain certain fields.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#tag">ocds:tag</a>
    /// </summary>
    let tag = _prefixId.prefix "tag"
    /// <summary>
    ///   <para>rdfs:label : Telephone</para>
    ///   <para>rdfs:comment : The telephone number of the contact point/person. This should include the international dialling code.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#telephone">ocds:telephone</a>
    /// </summary>
    let telephone = _prefixId.prefix "telephone"
    /// <summary>
    ///   <para>rdfs:label : Tender</para>
    ///   <para>rdfs:comment : The activities undertaken in order to enter into a contract.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#tender">ocds:tender</a>
    /// </summary>
    let tender = _prefixId.prefix "tender"
    /// <summary>
    ///   <para>rdfs:label : Tender amendment</para>
    ///   <para>rdfs:comment : </para>
    ///   <a href="http://purl.org/onto-ocds/ocds#tenderAmendment">ocds:tenderAmendment</a>
    /// </summary>
    let tenderAmendment = _prefixId.prefix "tenderAmendment"
    /// <summary>
    ///   <para>rdfs:label : Tender description^^xsd:string</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#tenderDescription">ocds:tenderDescription</a>
    /// </summary>
    let tenderDescription = _prefixId.prefix "tenderDescription"
    /// <summary>
    ///   <para>rdfs:label : Tender documents</para>
    ///   <para>rdfs:comment : All documents and attachments related to the tender, including any notices. See the [documentType codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#document-type) for details of potential documents to include.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#tenderDocuments">ocds:tenderDocuments</a>
    /// </summary>
    let tenderDocuments = _prefixId.prefix "tenderDocuments"
    let tenderFollows = _prefixId.prefix "tenderFollows"
    /// <summary>
    ///   <para>rdfs:label : Tender ID</para>
    ///   <para>rdfs:comment : An identifier for this tender process. This may be the same as the ocid, or may be drawn from an internally held identifier for this tender.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#tenderId">ocds:tenderId</a>
    /// </summary>
    let tenderId = _prefixId.prefix "tenderId"
    /// <summary>
    ///   <para>rdfs:label : Items to be procured</para>
    ///   <para>rdfs:comment : The goods and services to be purchased, broken into line items wherever possible. Items should not be duplicated, but a quantity of 2 specified instead.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#tenderItems">ocds:tenderItems</a>
    /// </summary>
    let tenderItems = _prefixId.prefix "tenderItems"
    /// <summary>
    ///   <para>rdfs:label : Tender lots</para>
    ///   <para>rdfs:comment : List of lots associated with the tender</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#tenderLots">ocds:tenderLots</a>
    /// </summary>
    let tenderLots = _prefixId.prefix "tenderLots"
    /// <summary>
    ///   <para>rdfs:label : Tender period</para>
    ///   <para>rdfs:comment : The period when the tender is open for submissions. The end date is the closing date for tender submissions.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#tenderPeriod">ocds:tenderPeriod</a>
    /// </summary>
    let tenderPeriod = _prefixId.prefix "tenderPeriod"
    let tenderPrecedes = _prefixId.prefix "tenderPrecedes"
    /// <summary>
    ///   <para>rdfs:label : Tender Status</para>
    ///   <para>rdfs:comment : The current status of the tender based on the [tenderStatus codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#tender-status)</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#tenderStatus">ocds:tenderStatus</a>
    /// </summary>
    let tenderStatus = _prefixId.prefix "tenderStatus"
    let tenderStatusActive = _prefixId.prefix "tenderStatusActive"
    let tenderStatusCancelled = _prefixId.prefix "tenderStatusCancelled"
    let tenderStatusComplete = _prefixId.prefix "tenderStatusComplete"
    let tenderStatusPlanned = _prefixId.prefix "tenderStatusPlanned"
    let tenderStatusUnsuccessful = _prefixId.prefix "tenderStatusUnsuccessful"
    /// <summary>
    ///   <para>rdfs:label : Tender title</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#tenderTitle">ocds:tenderTitle</a>
    /// </summary>
    let tenderTitle = _prefixId.prefix "tenderTitle"
    /// <summary>
    ///   <para>rdfs:label : Tender URL</para>
    ///   <para>rdfs:comment : Url para poder identificar el servicio que es utilizado para generar la convocatoria</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#tenderUrl">ocds:tenderUrl</a>
    /// </summary>
    let tenderUrl = _prefixId.prefix "tenderUrl"
    /// <summary>
    ///   <para>rdfs:label : Tender value</para>
    ///   <para>rdfs:comment : The total upper estimated value of the procurement.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#tenderValue">ocds:tenderValue</a>
    /// </summary>
    let tenderValue = _prefixId.prefix "tenderValue"
    /// <summary>
    ///   <para>rdfs:label : Tenderers</para>
    ///   <para>rdfs:comment : All entities who submit a tender.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#tenderers">ocds:tenderers</a>
    /// </summary>
    let tenderers = _prefixId.prefix "tenderers"
    /// <summary>
    ///   <para>rdfs:label : Transaction amount</para>
    ///   <para>rdfs:comment : The value of the transaction.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#transactionAmount">ocds:transactionAmount</a>
    /// </summary>
    let transactionAmount = _prefixId.prefix "transactionAmount"
    /// <summary>
    ///   <para>rdfs:label : Transaction date</para>
    ///   <para>rdfs:comment : The date of the transaction</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#transactionDate">ocds:transactionDate</a>
    /// </summary>
    let transactionDate = _prefixId.prefix "transactionDate"
    /// <summary>
    ///   <para>rdfs:label : Transaction ID</para>
    ///   <para>rdfs:comment : A unique identifier for this transaction. This identifier should be possible to cross-reference against the provided data source. For the budget data package this is the id, for IATI, the transaction reference.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#transactionId">ocds:transactionId</a>
    /// </summary>
    let transactionId = _prefixId.prefix "transactionId"
    /// <summary>
    ///   <para>rdfs:label : Transaction Data Source</para>
    ///   <para>rdfs:comment : Used to point either to a corresponding Budget Data Package, IATI file, or machine or human-readable source where users can find further information on the budget line item identifiers, or project identifiers, provided here.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#transactionSource">ocds:transactionSource</a>
    /// </summary>
    let transactionSource = _prefixId.prefix "transactionSource"
    /// <summary>
    ///   <para>rdfs:label : Linked spending information</para>
    ///   <para>rdfs:comment : A URI pointing directly to a machine-readable record about this spending transaction.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#transactionUri">ocds:transactionUri</a>
    /// </summary>
    let transactionUri = _prefixId.prefix "transactionUri"
    /// <summary>
    ///   <para>rdfs:label : Transactions</para>
    ///   <para>rdfs:comment : A list of the spending transactions made against this contract</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#transactions">ocds:transactions</a>
    /// </summary>
    let transactions = _prefixId.prefix "transactions"
    /// <summary>
    ///   <para>rdfs:label : Unit</para>
    ///   <para>rdfs:comment : Description of the unit which the good comes in e.g. hours, kilograms. Made up of a unit name, and the value of a single unit.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#unit">ocds:unit</a>
    /// </summary>
    let unit = _prefixId.prefix "unit"
    /// <summary>
    ///   <para>rdfs:label : Unit name</para>
    ///   <para>rdfs:comment : Name of the unit</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#unitName">ocds:unitName</a>
    /// </summary>
    let unitName = _prefixId.prefix "unitName"
    /// <summary>
    ///   <para>rdfs:label : Unit value</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#unitValue">ocds:unitValue</a>
    /// </summary>
    let unitValue = _prefixId.prefix "unitValue"
    /// <summary>
    ///   <para>rdfs:label : Amount</para>
    ///   <para>rdfs:comment : Amount as a number.</para>
    ///   <a href="http://purl.org/onto-ocds/ocds#valueAmount">ocds:valueAmount</a>
    /// </summary>
    let valueAmount = _prefixId.prefix "valueAmount"
