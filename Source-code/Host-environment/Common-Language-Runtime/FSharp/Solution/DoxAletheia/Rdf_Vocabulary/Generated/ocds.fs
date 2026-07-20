namespace http.purl.org.onto_ocds.ocds.hash

open DoxAletheia

module ocds =
    let _namespace_name = "http://purl.org/onto-ocds/ocds#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An address. This may be the legally registered address of the organization, or may be a correspondence address for this particular contracting process.
    /// <see href="http://purl.org/onto-ocds/ocds#Address"></see></summary>
    let Address = _prefix "Address"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#Amendment"></see>
    /// </summary>
    let Amendment = _prefix "Amendment"
    /// <summary>
    /// An award for the given procurement. There may be more than one award per contracting process e.g. because the contract is split amongst different providers, or because it is a standing offer.
    /// <see href="http://purl.org/onto-ocds/ocds#Award"></see></summary>
    let Award = _prefix "Award"
    /// <summary>
    /// The award criteria code list describes the basis on which contract awards will be made.
    /// <see href="http://purl.org/onto-ocds/ocds#AwardCriteria"></see></summary>
    let AwardCriteria = _prefix "AwardCriteria"
    /// <summary>
    /// An award move through multiple states. Releases over time may update the status of an award.
    /// <see href="http://purl.org/onto-ocds/ocds#AwardStatus"></see></summary>
    let AwardStatus = _prefix "AwardStatus"
    /// <summary>
    /// This award has been made, and is currently in force.
    /// <see href="http://purl.org/onto-ocds/ocds#awardStatusActive"></see></summary>
    let awardStatusActive = _prefix "awardStatusActive"
    /// <summary>
    /// This award has been cancelled.
    /// <see href="http://purl.org/onto-ocds/ocds#awardStatusCancelled"></see></summary>
    let awardStatusCancelled = _prefix "awardStatusCancelled"
    /// <summary>
    /// This award has been proposed, but is not yet in force. This may be due to a cooling off period, or some other process.
    /// <see href="http://purl.org/onto-ocds/ocds#awardStatusPending"></see></summary>
    let awardStatusPending = _prefix "awardStatusPending"
    /// <summary>
    /// This award could not be successfully made. If items or supplier details are included within the award section, then these narrow the scope of the unsuccessful award (i.e. the award of noted items, or an award to the noted supplier, was unsuccessful, but there may be other successful awards for different items listed in the tender, or to different suppliers).
    /// <see href="http://purl.org/onto-ocds/ocds#awardStatusUnsuccessful"></see></summary>
    let awardStatusUnsuccessful = _prefix "awardStatusUnsuccessful"
    /// <summary>
    /// This section contain information about the budget line, and associated projects, through which this contracting process is funded. It draws upon data model of the [Budget Data Package](https://github.com/openspending/budget-data-package/blob/master/specification.md), and should be used to cross-reference to more detailed information held using a Budget Data Package, or, where no linked Budget Data Package is available, to provide enough information to allow a user to manually or automatically cross-reference with another published source of budget and project information.
    /// <see href="http://purl.org/onto-ocds/ocds#Budget"></see></summary>
    let Budget = _prefix "Budget"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#Change"></see>
    /// </summary>
    let Change = _prefix "Change"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#Classification"></see>
    /// </summary>
    let Classification = _prefix "Classification"
    /// <summary>
    /// An person, contact point or department to contact in relation to this contracting process.
    /// <see href="http://purl.org/onto-ocds/ocds#ContactPoint"></see></summary>
    let ContactPoint = _prefix "ContactPoint"
    /// <summary>
    /// Information regarding the signed contract between the buyer and supplier(s).
    /// <see href="http://purl.org/onto-ocds/ocds#Contract"></see></summary>
    let Contract = _prefix "Contract"
    /// <summary>
    /// Contracts can move through multiple states. Releases over time may update the status of a contract.
    /// <see href="http://purl.org/onto-ocds/ocds#ContractStatus"></see></summary>
    let ContractStatus = _prefix "ContractStatus"
    /// <summary>
    /// This contract has been signed by all the parties, and is now legally in force.
    /// <see href="http://purl.org/onto-ocds/ocds#contractStatusActive"></see></summary>
    let contractStatusActive = _prefix "contractStatusActive"
    /// <summary>
    /// This contract has been cancelled prior to being signed.
    /// <see href="http://purl.org/onto-ocds/ocds#contractStatusCancelled"></see></summary>
    let contractStatusCancelled = _prefix "contractStatusCancelled"
    /// <summary>
    /// This contract has been proposed, but is not yet in force. It may be awaiting signature.
    /// <see href="http://purl.org/onto-ocds/ocds#contractStatusPending"></see></summary>
    let contractStatusPending = _prefix "contractStatusPending"
    /// <summary>
    /// This contract was signed and in force, and has now come to a close. This may be due to successful completion of the contract, or may be early termination due to some non-completion.
    /// <see href="http://purl.org/onto-ocds/ocds#contractStatusTerminated"></see></summary>
    let contractStatusTerminated = _prefix "contractStatusTerminated"
    /// <summary>
    /// Links to, or descriptions of, external documents can be attached at various locations within the standard. Documents may be supporting information, formal notices, downloadable forms, or any other kind of resource that should be made public as part of full open contracting.
    /// <see href="http://purl.org/onto-ocds/ocds#Document"></see></summary>
    let Document = _prefix "Document"
    /// <summary>
    /// This list provides details of the documents that publishers may wish to provide at various points their contracting process.
    /// <see href="http://purl.org/onto-ocds/ocds#DocumentType"></see></summary>
    let DocumentType = _prefix "DocumentType"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#Identifier"></see>
    /// </summary>
    let Identifier = _prefix "Identifier"
    /// <summary>
    /// Information during the performance / implementation stage of the contract.
    /// <see href="http://purl.org/onto-ocds/ocds#Implementation"></see></summary>
    let Implementation = _prefix "Implementation"
    /// <summary>
    /// Contracting processes may be formed under a number of different processes. Currently, only ‘tender’ is supported in this codelist. Future versions of the standard may support other Initiation Types. The initiation type may be provide information to consuming applications on the different blocks of data and releases they should expect from a contracting process.
    /// <see href="http://purl.org/onto-ocds/ocds#InitiationType"></see></summary>
    let InitiationType = _prefix "InitiationType"
    /// <summary>
    /// An open competitive bidding or tendering to form contracts. The process generally involves publicly inviting prospective contractors to submit bids for evaluation and selecting a winner or winners.
    /// <see href="http://purl.org/onto-ocds/ocds#initiationTypeTender"></see></summary>
    let initiationTypeTender = _prefix "initiationTypeTender"
    /// <summary>
    /// A good, service, or work to be contracted.
    /// <see href="http://purl.org/onto-ocds/ocds#Item"></see></summary>
    let Item = _prefix "Item"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#ItemClassificationScheme"></see>
    /// </summary>
    let ItemClassificationScheme = _prefix "ItemClassificationScheme"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#Lot"></see>
    /// </summary>
    let Lot = _prefix "Lot"
    /// <summary>
    /// The method codelist is based upon the GPA Definitions provided here.
    /// <see href="http://purl.org/onto-ocds/ocds#Method"></see></summary>
    let Method = _prefix "Method"
    /// <summary>
    /// Limited tendering means a procurement method whereby the procuring entity contacts a supplier or suppliers of its choice.
    /// <see href="http://purl.org/onto-ocds/ocds#methodLimited"></see></summary>
    let methodLimited = _prefix "methodLimited"
    /// <summary>
    /// Open tendering means a procurement method whereby all interested suppliers may submit a tender.
    /// <see href="http://purl.org/onto-ocds/ocds#methodOpen"></see></summary>
    let methodOpen = _prefix "methodOpen"
    /// <summary>
    /// Selective tendering means a procurement method whereby only qualified suppliers are invited by the procuring entity to submit a tender.
    /// <see href="http://purl.org/onto-ocds/ocds#methodSelective"></see></summary>
    let methodSelective = _prefix "methodSelective"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#Milestone"></see>
    /// </summary>
    let Milestone = _prefix "Milestone"
    /// <summary>
    /// An organization.
    /// <see href="http://purl.org/onto-ocds/ocds#Organization"></see></summary>
    let Organization = _prefix "Organization"
    /// <summary>
    /// The Organization Identifier Scheme currently uses the codes from the International Aid Transparency Initiative ‘Organisation Registration Agency’ codelist. See the identifiers section for more information on organization identifiers.
    /// <see href="http://purl.org/onto-ocds/ocds#OrganizationIdentifierScheme"></see></summary>
    let OrganizationIdentifierScheme = _prefix "OrganizationIdentifierScheme"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#Period"></see>
    /// </summary>
    let Period = _prefix "Period"
    /// <summary>
    /// nformation from the planning phase of the contracting process. Note that many other fields may be filled in a planning release, in the appropriate fields in other schema sections, these would likely be estimates at this stage e.g. totalValue in tender
    /// <see href="http://purl.org/onto-ocds/ocds#Planning"></see></summary>
    let Planning = _prefix "Planning"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#Release"></see>
    /// </summary>
    let Release = _prefix "Release"
    /// <summary>
    /// A contracting process may result in a number of releases of information over time. These should be tagged to indicate the stage of the contracting process they relate to.
    /// <see href="http://purl.org/onto-ocds/ocds#ReleaseTag"></see></summary>
    let ReleaseTag = _prefix "ReleaseTag"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#releaseTagAward"></see>
    /// </summary>
    let releaseTagAward = _prefix "releaseTagAward"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#releaseTagAwardCancellation"></see>
    /// </summary>
    let releaseTagAwardCancellation = _prefix "releaseTagAwardCancellation"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#releaseTagAwardUpdate"></see>
    /// </summary>
    let releaseTagAwardUpdate = _prefix "releaseTagAwardUpdate"
    /// <summary>
    /// This tag is used only in compiled records, which have merged together multiple releases to provide a snapshot view of the contract, and a version history.
    /// <see href="http://purl.org/onto-ocds/ocds#releaseTagCompiled"></see></summary>
    let releaseTagCompiled = _prefix "releaseTagCompiled"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#releaseTagContract"></see>
    /// </summary>
    let releaseTagContract = _prefix "releaseTagContract"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#releaseTagContractAmendment"></see>
    /// </summary>
    let releaseTagContractAmendment = _prefix "releaseTagContractAmendment"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#releaseTagContractTermination"></see>
    /// </summary>
    let releaseTagContractTermination = _prefix "releaseTagContractTermination"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#releaseTagContractUpdate"></see>
    /// </summary>
    let releaseTagContractUpdate = _prefix "releaseTagContractUpdate"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#releaseTagImplementation"></see>
    /// </summary>
    let releaseTagImplementation = _prefix "releaseTagImplementation"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#releaseTagImplementationUpdate"></see>
    /// </summary>
    let releaseTagImplementationUpdate = _prefix "releaseTagImplementationUpdate"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#releaseTagPlanning"></see>
    /// </summary>
    let releaseTagPlanning = _prefix "releaseTagPlanning"
    /// <summary>
    /// Announcing a new tender (call for proposals) process. Tender release should contain details of the goods or services being sought.
    /// <see href="http://purl.org/onto-ocds/ocds#releaseTagTender"></see></summary>
    let releaseTagTender = _prefix "releaseTagTender"
    /// <summary>
    /// An amendment to an existing tender release. There should be at least one tender release with the same ocid, but an earlier releaseDate, before a tenderAmendment is published. The term amendment has legal meaning in many jurisdictions.
    /// <see href="http://purl.org/onto-ocds/ocds#releaseTagTenderAmendment"></see></summary>
    let releaseTagTenderAmendment = _prefix "releaseTagTenderAmendment"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#releaseTagTenderCancellation"></see>
    /// </summary>
    let releaseTagTenderCancellation = _prefix "releaseTagTenderCancellation"
    /// <summary>
    /// An updated to an existing tender release. There should be at least one tender release with the same ocid, but an earlier releaseDate, before a tenderUpdate is published. An update may add new information or make corrections to prior published information. It should not be used for formal legal amendments to a tender, for which the tenderAmendment tag should be used.
    /// <see href="http://purl.org/onto-ocds/ocds#releaseTagTenderUpdate"></see></summary>
    let releaseTagTenderUpdate = _prefix "releaseTagTenderUpdate"
    /// <summary>
    /// The submission method codelist is used to identify the mechanism through which a submission may be made.
    /// <see href="http://purl.org/onto-ocds/ocds#SubmissionMethod"></see></summary>
    let SubmissionMethod = _prefix "SubmissionMethod"
    /// <summary>
    /// Data regarding tender process - publicly inviting prospective contractors to submit bids for evaluation and selecting a winner or winners
    /// <see href="http://purl.org/onto-ocds/ocds#Tender"></see></summary>
    let Tender = _prefix "Tender"
    /// <summary>
    /// The tender.status field is used to indicate the current status of a tender process.
    /// <see href="http://purl.org/onto-ocds/ocds#TenderStatus"></see></summary>
    let TenderStatus = _prefix "TenderStatus"
    /// <summary>
    /// A tender process is currently taking place.
    /// <see href="http://purl.org/onto-ocds/ocds#tenderStatusActive"></see></summary>
    let tenderStatusActive = _prefix "tenderStatusActive"
    /// <summary>
    /// The tender process has been cancelled.
    /// <see href="http://purl.org/onto-ocds/ocds#tenderStatusCancelled"></see></summary>
    let tenderStatusCancelled = _prefix "tenderStatusCancelled"
    /// <summary>
    /// The tender process as unsucessful.
    /// <see href="http://purl.org/onto-ocds/ocds#tenderStatusComplete"></see></summary>
    let tenderStatusComplete = _prefix "tenderStatusComplete"
    /// <summary>
    /// This tender has been proposed, but is not yet taking place.
    /// <see href="http://purl.org/onto-ocds/ocds#tenderStatusPlanned"></see></summary>
    let tenderStatusPlanned = _prefix "tenderStatusPlanned"
    /// <summary>
    /// The tender process as unsucessful.
    /// <see href="http://purl.org/onto-ocds/ocds#tenderStatusUnsuccessful"></see></summary>
    let tenderStatusUnsuccessful = _prefix "tenderStatusUnsuccessful"
    /// <summary>
    /// A spending transaction related to the contracting process. Draws upon the data models of the [Budget Data Package](https://github.com/openspending/budget-data-package/blob/master/specification.md) and the [International Aid Transpareny Initiative](http://iatistandard.org/activity-standard/iati-activities/iati-activity/transaction/) and should be used to cross-reference to more detailed information held using a Budget Data Package, IATI file, or to provide enough information to allow a user to manually or automatically cross-reference with some other published source of transactional spending data.
    /// <see href="http://purl.org/onto-ocds/ocds#Transaction"></see></summary>
    let Transaction = _prefix "Transaction"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#Unit"></see>
    /// </summary>
    let Unit = _prefix "Unit"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#Value"></see>
    /// </summary>
    let Value = _prefix "Value"
    /// <summary>
    /// An array of additional classifications for the item. See the [itemClassificationScheme](http://standard.open-contracting.org/latest/en/schema/codelists/#item-classification-scheme) codelist for common options to use in OCDS. This may also be used to present codes from an internal classification scheme.
    /// <see href="http://purl.org/onto-ocds/ocds#additionalClassifications"></see></summary>
    let additionalClassifications = _prefix "additionalClassifications"
    /// <summary>
    /// A list of additional / supplemental identifiers for the organization, using the [organization identifier guidance](http://standard.open-contracting.org/latest/en/schema/identifiers/). This could be used to provide an internally used identifier for this organization in addition to the primary legal entity identifier.
    /// <see href="http://purl.org/onto-ocds/ocds#additionalIdentifiers"></see></summary>
    let additionalIdentifiers = _prefix "additionalIdentifiers"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#address"></see>
    /// </summary>
    let address = _prefix "address"
    /// <summary>
    /// The data of this amendment.
    /// <see href="http://purl.org/onto-ocds/ocds#amendmentDate"></see></summary>
    let amendmentDate = _prefix "amendmentDate"
    /// <summary>
    /// An explanation for the amendment.
    /// <see href="http://purl.org/onto-ocds/ocds#amendmentRationale"></see></summary>
    let amendmentRationale = _prefix "amendmentRationale"
    /// <summary>
    /// Information from the award phase of the contracting process. There may be more than one award per contracting process e.g. because the contract is split amongst different providers, or because it is a standing offer.
    /// <see href="http://purl.org/onto-ocds/ocds#award"></see></summary>
    let award = _prefix "award"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#awardAmendment"></see>
    /// </summary>
    let awardAmendment = _prefix "awardAmendment"
    /// <summary>
    /// Specify the award criteria for the procurement, using the [award criteria codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#award-criteria)
    /// <see href="http://purl.org/onto-ocds/ocds#awardCriteria"></see></summary>
    let awardCriteria = _prefix "awardCriteria"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#awardCriteriaBestProposal"></see>
    /// </summary>
    let awardCriteriaBestProposal = _prefix "awardCriteriaBestProposal"

    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#awardCriteriaBestValueToGovernment"></see>
    /// </summary>
    let awardCriteriaBestValueToGovernment =
        _prefix "awardCriteriaBestValueToGovernment"

    /// <summary>
    /// Any detailed or further information on the award or selection criteria.
    /// <see href="http://purl.org/onto-ocds/ocds#awardCriteriaDetails"></see></summary>
    let awardCriteriaDetails = _prefix "awardCriteriaDetails"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#awardCriteriaLowestCost"></see>
    /// </summary>
    let awardCriteriaLowestCost = _prefix "awardCriteriaLowestCost"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#awardCriteriaSingleBidOnly"></see>
    /// </summary>
    let awardCriteriaSingleBidOnly = _prefix "awardCriteriaSingleBidOnly"
    /// <summary>
    /// The date of the contract award. This is usually the date on which a decision to award was made.
    /// <see href="http://purl.org/onto-ocds/ocds#awardDate"></see></summary>
    let awardDate = _prefix "awardDate"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#awardDescription"></see>
    /// </summary>
    let awardDescription = _prefix "awardDescription"
    /// <summary>
    /// All documents and attachments related to the award, including any notices.
    /// <see href="http://purl.org/onto-ocds/ocds#awardDocuments"></see></summary>
    let awardDocuments = _prefix "awardDocuments"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#awardFollows"></see>
    /// </summary>
    let awardFollows = _prefix "awardFollows"
    /// <summary>
    /// The award against which this contract is being issued.
    /// <see href="http://purl.org/onto-ocds/ocds#awardID"></see></summary>
    let awardID = _prefix "awardID"
    /// <summary>
    /// The identifier for this award. It must be unique and cannot change within the Open Contracting Process it is part of (defined by a single ocid). See the [identifier guidance](http://standard.open-contracting.org/latest/en/schema/identifiers/) for further details.
    /// <see href="http://purl.org/onto-ocds/ocds#awardId"></see></summary>
    let awardId = _prefix "awardId"
    /// <summary>
    /// The date or period on which an award is anticipated to be made.
    /// <see href="http://purl.org/onto-ocds/ocds#awardPeriod"></see></summary>
    let awardPeriod = _prefix "awardPeriod"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#awardPrecedes"></see>
    /// </summary>
    let awardPrecedes = _prefix "awardPrecedes"
    /// <summary>
    /// The current status of the award drawn from the [awardStatus codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#award-status)
    /// <see href="http://purl.org/onto-ocds/ocds#awardStatus"></see></summary>
    let awardStatus = _prefix "awardStatus"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#awardTitle"></see>
    /// </summary>
    let awardTitle = _prefix "awardTitle"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#awardURL"></see>
    /// </summary>
    let awardURL = _prefix "awardURL"
    /// <summary>
    /// The total value of this award. In the case of a framework contract this may be the total estimated lifetime value, or maximum value, of the agreement. There may be more than one award per procurement.
    /// <see href="http://purl.org/onto-ocds/ocds#awardValue"></see></summary>
    let awardValue = _prefix "awardValue"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#budget"></see>
    /// </summary>
    let budget = _prefix "budget"
    /// <summary>
    /// The value of the budget line item.
    /// <see href="http://purl.org/onto-ocds/ocds#budgetAmount"></see></summary>
    let budgetAmount = _prefix "budgetAmount"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#budgetDescription"></see>
    /// </summary>
    let budgetDescription = _prefix "budgetDescription"
    /// <summary>
    /// An identifier for the budget line item which provides funds for this contracting process. This identifier should be possible to cross-reference against the provided data source.
    /// <see href="http://purl.org/onto-ocds/ocds#budgetId"></see></summary>
    let budgetId = _prefix "budgetId"
    /// <summary>
    /// Used to point either to a corresponding Budget Data Package, or to a machine or human-readable source where users can find further information on the budget line item identifiers, or project identifiers, provided here.
    /// <see href="http://purl.org/onto-ocds/ocds#budgetSource"></see></summary>
    let budgetSource = _prefix "budgetSource"
    /// <summary>
    /// A URI pointing directly to a machine-readable record about the related budget or projects for this contracting process.
    /// <see href="http://purl.org/onto-ocds/ocds#budgetUri"></see></summary>
    let budgetUri = _prefix "budgetUri"
    /// <summary>
    /// The buyer is the entity whose budget will be used to purchase the goods. This may be different from the procuring agency who may be specified in the tender data.
    /// <see href="http://purl.org/onto-ocds/ocds#buyer"></see></summary>
    let buyer = _prefix "buyer"
    /// <summary>
    /// Comma-separated list of affected fields.
    /// <see href="http://purl.org/onto-ocds/ocds#changes"></see></summary>
    let changes = _prefix "changes"
    /// <summary>
    /// The primary classification for the item. See the [itemClassificationScheme](http://standard.open-contracting.org/latest/en/schema/codelists/#item-classification-scheme) to identify preferred classification lists, including CPV and GSIN.
    /// <see href="http://purl.org/onto-ocds/ocds#classification"></see></summary>
    let classification = _prefix "classification"
    /// <summary>
    /// A textual description or title for the code.
    /// <see href="http://purl.org/onto-ocds/ocds#classificationDescription"></see></summary>
    let classificationDescription = _prefix "classificationDescription"
    /// <summary>
    /// The classification code drawn from the selected scheme.
    /// <see href="http://purl.org/onto-ocds/ocds#classificationId"></see></summary>
    let classificationId = _prefix "classificationId"
    /// <summary>
    /// An classification should be drawn from an existing scheme or list of codes. This field is used to indicate the scheme/codelist from which the classification is drawn. For line item classifications, this value should represent an known [Item Classification Scheme](http://standard.open-contracting.org/latest/en/schema/codelists/#item-classification-scheme) wherever possible.
    /// <see href="http://purl.org/onto-ocds/ocds#classificationScheme"></see></summary>
    let classificationScheme = _prefix "classificationScheme"
    /// <summary>
    /// A URI to identify the code. In the event individual URIs are not available for items in the identifier scheme this value should be left blank.
    /// <see href="http://purl.org/onto-ocds/ocds#classificationUri"></see></summary>
    let classificationUri = _prefix "classificationUri"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#contactPoint"></see>
    /// </summary>
    let contactPoint = _prefix "contactPoint"
    /// <summary>
    /// The name of the contact person, department, or contact point, for correspondence relating to this contracting process.
    /// <see href="http://purl.org/onto-ocds/ocds#contactPointName"></see></summary>
    let contactPointName = _prefix "contactPointName"
    /// <summary>
    /// A web address for the contact point/person.
    /// <see href="http://purl.org/onto-ocds/ocds#contactPointUrl"></see></summary>
    let contactPointUrl = _prefix "contactPointUrl"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#contractAmendment"></see>
    /// </summary>
    let contractAmendment = _prefix "contractAmendment"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#contractDescription"></see>
    /// </summary>
    let contractDescription = _prefix "contractDescription"
    /// <summary>
    /// All documents and attachments related to the contract, including any notices.
    /// <see href="http://purl.org/onto-ocds/ocds#contractDocuments"></see></summary>
    let contractDocuments = _prefix "contractDocuments"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#contractFollows"></see>
    /// </summary>
    let contractFollows = _prefix "contractFollows"
    /// <summary>
    /// The identifier for this contract. It must be unique and cannot change within its Open Contracting Process (defined by a single ocid). See the [identifier guidance](http://standard.open-contracting.org/latest/en/schema/identifiers/) for further details.
    /// <see href="http://purl.org/onto-ocds/ocds#contractId"></see></summary>
    let contractId = _prefix "contractId"
    /// <summary>
    /// The goods, services, and any intangible outcomes in this contract. Note: If the items are the same as the award do not repeat.
    /// <see href="http://purl.org/onto-ocds/ocds#contractItems"></see></summary>
    let contractItems = _prefix "contractItems"
    /// <summary>
    /// List of lots associated with the contract
    /// <see href="http://purl.org/onto-ocds/ocds#contractLots"></see></summary>
    let contractLots = _prefix "contractLots"
    /// <summary>
    /// The period for which the contract has been awarded.
    /// The start and end date for the contract.
    /// <see href="http://purl.org/onto-ocds/ocds#contractPeriod"></see></summary>
    let contractPeriod = _prefix "contractPeriod"
    /// <summary>
    /// The current status of the contract. Drawn from the [contractStatus codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#contract-status)
    /// <see href="http://purl.org/onto-ocds/ocds#contractStatus"></see></summary>
    let contractStatus = _prefix "contractStatus"
    /// <summary>
    /// The suppliers awarded this contract. Is an implementacion of DNCP
    /// <see href="http://purl.org/onto-ocds/ocds#contractSuppliers"></see></summary>
    let contractSuppliers = _prefix "contractSuppliers"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#contractTitle"></see>
    /// </summary>
    let contractTitle = _prefix "contractTitle"
    /// <summary>
    /// The total value of this contract.
    /// <see href="http://purl.org/onto-ocds/ocds#contractValue"></see></summary>
    let contractValue = _prefix "contractValue"
    /// <summary>
    /// Information from the contract creation phase of the procurement process.
    /// <see href="http://purl.org/onto-ocds/ocds#contracts"></see></summary>
    let contracts = _prefix "contracts"
    /// <summary>
    /// The country name. For example, United States.
    /// <see href="http://purl.org/onto-ocds/ocds#countryName"></see></summary>
    let countryName = _prefix "countryName"
    /// <summary>
    /// The currency in 3-letter ISO 4217 format.
    /// <see href="http://purl.org/onto-ocds/ocds#currency"></see></summary>
    let currency = _prefix "currency"
    /// <summary>
    /// The date on which the document was first published. This is particularly important for legally important documents such as notices of a tender.
    /// <see href="http://purl.org/onto-ocds/ocds#datePublished"></see></summary>
    let datePublished = _prefix "datePublished"
    /// <summary>
    /// The date the contract was signed. In the case of multiple signatures, the date of the last signature.
    /// <see href="http://purl.org/onto-ocds/ocds#dateSigned"></see></summary>
    let dateSigned = _prefix "dateSigned"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#dncpContractCode"></see>
    /// </summary>
    let dncpContractCode = _prefix "dncpContractCode"
    /// <summary>
    /// Date that the document was last modified
    /// <see href="http://purl.org/onto-ocds/ocds#documentDateModified"></see></summary>
    let documentDateModified = _prefix "documentDateModified"
    /// <summary>
    /// A short description of the document. We recommend descriptions do not exceed 250 words. In the event the document is not accessible online, the description field can be used to describe arrangements for obtaining a copy of the document.
    /// <see href="http://purl.org/onto-ocds/ocds#documentDescription"></see></summary>
    let documentDescription = _prefix "documentDescription"
    /// <summary>
    /// A local, unique identifier for this document. This field is used to keep track of multiple revisions of a document through the compilation from release to record mechanism.
    /// <see href="http://purl.org/onto-ocds/ocds#documentId"></see></summary>
    let documentId = _prefix "documentId"
    /// <summary>
    /// Specifies the language of the linked document using either two-digit [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes), or extended [BCP47 language tags](http://www.w3.org/International/articles/language-tags/). The use of two-letter codes from [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) is strongly recommended unless there is a clear user need for distinguishing the language subtype.
    /// <see href="http://purl.org/onto-ocds/ocds#documentLanguage"></see></summary>
    let documentLanguage = _prefix "documentLanguage"
    /// <summary>
    /// The document title.
    /// <see href="http://purl.org/onto-ocds/ocds#documentTitle"></see></summary>
    let documentTitle = _prefix "documentTitle"
    /// <summary>
    /// A classification of the document described taken from the [documentType codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#document-type). Values from the provided codelist should be used wherever possible, though extended values can be provided if the codelist does not have a relevant code.
    /// <see href="http://purl.org/onto-ocds/ocds#documentType"></see></summary>
    let documentType = _prefix "documentType"
    /// <summary>
    /// The formal notice that gives details of the contract award. This may be a link to a downloadable document, to a web page, or to an official gazette in which the notice is contained.
    /// <see href="http://purl.org/onto-ocds/ocds#documentTypeAwardNotice"></see></summary>
    let documentTypeAwardNotice = _prefix "documentTypeAwardNotice"
    /// <summary>
    /// The formal notice that gives details of a tender. This may be a link to a downloadable document, to a web page, or to an official gazette in which the notice is contained.
    /// <see href="http://purl.org/onto-ocds/ocds#documentTypeTenderNotice"></see></summary>
    let documentTypeTenderNotice = _prefix "documentTypeTenderNotice"
    /// <summary>
    /// Direct link to the document or attachment. The server providing access to this document should be configured to correctly report the document mime type.
    /// <see href="http://purl.org/onto-ocds/ocds#documentUrl"></see></summary>
    let documentUrl = _prefix "documentUrl"
    /// <summary>
    /// A list of documents related to the planning process.
    /// <see href="http://purl.org/onto-ocds/ocds#documents"></see></summary>
    let documents = _prefix "documents"
    /// <summary>
    /// The date the milestone is due.
    /// <see href="http://purl.org/onto-ocds/ocds#dueDate"></see></summary>
    let dueDate = _prefix "dueDate"
    /// <summary>
    /// A description of any eligibility criteria for potential suppliers.
    /// <see href="http://purl.org/onto-ocds/ocds#eligibilityCriteria"></see></summary>
    let eligibilityCriteria = _prefix "eligibilityCriteria"
    /// <summary>
    /// The e-mail address of the contact point/person.
    /// <see href="http://purl.org/onto-ocds/ocds#email"></see></summary>
    let email = _prefix "email"
    /// <summary>
    /// The end date for the period.
    /// <see href="http://purl.org/onto-ocds/ocds#endDate"></see></summary>
    let endDate = _prefix "endDate"
    /// <summary>
    /// The period during which enquiries may be made and answered.
    /// <see href="http://purl.org/onto-ocds/ocds#enquiryPeriod"></see></summary>
    let enquiryPeriod = _prefix "enquiryPeriod"
    /// <summary>
    /// The fax number of the contact point/person. This should include the international dialling code.
    /// <see href="http://purl.org/onto-ocds/ocds#faxNumber"></see></summary>
    let faxNumber = _prefix "faxNumber"
    /// <summary>
    /// The format of the document taken from the [IANA Media Types code list](http://www.iana.org/assignments/media-types/), with the addition of one extra value for 'offline/print', used when this document entry is being used to describe the offline publication of a document. Use values from the template column. Links to web pages should be tagged 'text/html'.
    /// <see href="http://purl.org/onto-ocds/ocds#format"></see></summary>
    let format = _prefix "format"
    /// <summary>
    /// The previous value of the changed property, in whatever type the property is.
    /// <see href="http://purl.org/onto-ocds/ocds#former_value"></see></summary>
    let former_value = _prefix "former_value"
    /// <summary>
    ///  Yes/No field to indicate whether enquiries were part of tender process.
    /// <see href="http://purl.org/onto-ocds/ocds#hasEnquiries"></see></summary>
    let hasEnquiries = _prefix "hasEnquiries"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#ics_CDNCP"></see>
    /// </summary>
    let ics_CDNCP = _prefix "ics_CDNCP"
    /// <summary>
    /// The Common Procurement Vocabulary is a standard adopted by the Commission of the European Community, and consisting of a main vocabulary for defining the subject of a contract, and a supplementary vocabulary for adding further qualitative information. The main vocabulary, identified in OCDS by the code CPV, is based on a tree structure comprising codes of up to 9 digits (an 8 digit code plus a check digit) associated with a wording that describes the type of supplies, works or services forming the subject of the contract.
    /// <see href="http://purl.org/onto-ocds/ocds#ics_CPV"></see></summary>
    let ics_CPV = _prefix "ics_CPV"
    /// <summary>
    /// The Common Procurement Vocabulary is a standard adopted by the Commission of the European Community, and consisting of a main vocabulary for defining the subject of a contract, and a supplementary vocabulary for adding further qualitative information. The supplementary vocabulary, identified in OCDS by the code CPVS, is made up of an alphanumeric code with a corresponding wording allowing further details to be added regarding the specific nature or destination of the goods to be purchased.
    /// <see href="http://purl.org/onto-ocds/ocds#ics_CPVS"></see></summary>
    let ics_CPVS = _prefix "ics_CPVS"
    /// <summary>
    /// The Canadia federal government uses Goods and Services Identification Number (GSIN) codes to identify generic product descriptions for its procurement activities. The full list is published and maintained at buyandsell.gc.ca
    /// <see href="http://purl.org/onto-ocds/ocds#ics_GSIN"></see></summary>
    let ics_GSIN = _prefix "ics_GSIN"
    /// <summary>
    /// The United Nations Standard Products and Services Code (UNSPSC) is a hierarchical convention that is used to classify all products and services. Machine readable meta-data for UNSPSC is not provided as open data: and so publishers should consider alternative classification shemes that do provide open data lookup tables wherever possible.
    /// <see href="http://purl.org/onto-ocds/ocds#ics_UNSPSC"></see></summary>
    let ics_UNSPSC = _prefix "ics_UNSPSC"
    /// <summary>
    /// A unique identifier that identifies this release. A release ID must be unique within a release-package and must not contain the # character.
    /// <see href="http://purl.org/onto-ocds/ocds#id"></see></summary>
    let id = _prefix "id"
    /// <summary>
    /// The primary identifier for this organization. Identifiers that uniquely pick out a legal entity should be preferred. Consult the [organization identifier guidance](http://standard.open-contracting.org/latest/en/schema/identifiers/) for the preferred scheme and identifier to use.
    /// <see href="http://purl.org/onto-ocds/ocds#identifier"></see></summary>
    let identifier = _prefix "identifier"
    /// <summary>
    /// The identifier of the organization in the selected scheme.
    /// <see href="http://purl.org/onto-ocds/ocds#identifierId"></see></summary>
    let identifierId = _prefix "identifierId"
    /// <summary>
    /// Organization identifiers be drawn from an existing identification scheme. This field is used to indicate the scheme or codelist in which the identifier will be found. This value should be drawn from the [Organization Identifier Scheme](http://standard.open-contracting.org/latest/en/schema/codelists/#organization-identifier-scheme).
    /// <see href="http://purl.org/onto-ocds/ocds#identifierScheme"></see></summary>
    let identifierScheme = _prefix "identifierScheme"
    /// <summary>
    /// A URI to identify the organization, such as those provided by [Open Corporates](http://www.opencorporates.com) or some other relevant URI provider. This is not for listing the website of the organization: that can be done through the url field of the Organization contact point.
    /// <see href="http://purl.org/onto-ocds/ocds#identifierUri"></see></summary>
    let identifierUri = _prefix "identifierUri"
    /// <summary>
    /// Information related to the implementation of the contract in accordance with the obligations laid out therein.
    /// <see href="http://purl.org/onto-ocds/ocds#implementation"></see></summary>
    let implementation = _prefix "implementation"
    /// <summary>
    /// Documents and reports that are part of the implementation phase e.g. audit and evaluation reports.
    /// <see href="http://purl.org/onto-ocds/ocds#implementationDocuments"></see></summary>
    let implementationDocuments = _prefix "implementationDocuments"
    /// <summary>
    /// As milestones are completed, milestone completions should be documented.
    /// <see href="http://purl.org/onto-ocds/ocds#implementationMilestones"></see></summary>
    let implementationMilestones = _prefix "implementationMilestones"
    /// <summary>
    /// String specifying the type of initiation process used for this contract, taken from the [initiationType](http://standard.open-contracting.org/latest/en/schema/codelists/#initiation-type) codelist. Currently only tender is supported.
    /// <see href="http://purl.org/onto-ocds/ocds#initiationType"></see></summary>
    let initiationType = _prefix "initiationType"
    /// <summary>
    /// A description of the goods, services to be provided.
    /// <see href="http://purl.org/onto-ocds/ocds#itemDescription"></see></summary>
    let itemDescription = _prefix "itemDescription"
    /// <summary>
    /// A local identifier to reference and merge the items by. Must be unique within a given array of items.
    /// <see href="http://purl.org/onto-ocds/ocds#itemId"></see></summary>
    let itemId = _prefix "itemId"
    /// <summary>
    /// The legally registered name of the organization.
    /// <see href="http://purl.org/onto-ocds/ocds#legalName"></see></summary>
    let legalName = _prefix "legalName"
    /// <summary>
    /// The locality. For example, Mountain View.
    /// <see href="http://purl.org/onto-ocds/ocds#locality"></see></summary>
    let locality = _prefix "locality"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#lotId"></see>
    /// </summary>
    let lotId = _prefix "lotId"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#lotItems"></see>
    /// </summary>
    let lotItems = _prefix "lotItems"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#lotTitle"></see>
    /// </summary>
    let lotTitle = _prefix "lotTitle"
    /// <summary>
    /// The date the milestone was last reviewed or modified and the status was altered or confirmed to still be correct.
    /// <see href="http://purl.org/onto-ocds/ocds#milestoneDateModified"></see></summary>
    let milestoneDateModified = _prefix "milestoneDateModified"
    /// <summary>
    /// A description of the milestone.
    /// <see href="http://purl.org/onto-ocds/ocds#milestoneDescription"></see></summary>
    let milestoneDescription = _prefix "milestoneDescription"
    /// <summary>
    /// List of documents associated with this milestone.
    /// <see href="http://purl.org/onto-ocds/ocds#milestoneDocuments"></see></summary>
    let milestoneDocuments = _prefix "milestoneDocuments"
    /// <summary>
    /// A local identifier for this milestone, unique within this block. This field is used to keep track of multiple revisions of a milestone through the compilation from release to record mechanism.
    /// <see href="http://purl.org/onto-ocds/ocds#milestoneId"></see></summary>
    let milestoneId = _prefix "milestoneId"
    /// <summary>
    /// The status that was realized on the date provided in dateModified, drawn from the [milestoneStatus codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#milestone-status).
    /// <see href="http://purl.org/onto-ocds/ocds#milestoneStatus"></see></summary>
    let milestoneStatus = _prefix "milestoneStatus"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#milestoneTitle"></see>
    /// </summary>
    let milestoneTitle = _prefix "milestoneTitle"
    /// <summary>
    /// A list of milestones associated with the tender.
    /// <see href="http://purl.org/onto-ocds/ocds#milestones"></see></summary>
    let milestones = _prefix "milestones"
    /// <summary>
    /// The minimum estimated value of the procurement.
    /// <see href="http://purl.org/onto-ocds/ocds#minValue"></see></summary>
    let minValue = _prefix "minValue"
    /// <summary>
    /// The number of entities who submit a tender.
    /// <see href="http://purl.org/onto-ocds/ocds#numberOfTenderers"></see></summary>
    let numberOfTenderers = _prefix "numberOfTenderers"
    /// <summary>
    /// A globally unique identifier for this Open Contracting Process. Composed of a publisher prefix and an identifier for the contracting process. For more information see the [Open Contracting Identifier guidance](http://standard.open-contracting.org/latest/en/schema/identifiers/)
    /// <see href="http://purl.org/onto-ocds/ocds#ocid"></see></summary>
    let ocid = _prefix "ocid"
    /// <summary>
    /// Website not yet searchable.
    /// <see href="http://purl.org/onto-ocds/ocds#ois_AF-CBR"></see></summary>
    let ``ois_AF-CBR`` = _prefix "ois_AF-CBR"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#ois_AF-MOE"></see>
    /// </summary>
    let ``ois_AF-MOE`` = _prefix "ois_AF-MOE"
    /// <summary>
    /// The common name of the organization. The ID property provides an space for the formal legal name, and so this may either repeat that value, or could provide the common name by which this organization is known. This field could also include details of the department or sub-unit involved in this contracting process.
    /// <see href="http://purl.org/onto-ocds/ocds#organizationName"></see></summary>
    let organizationName = _prefix "organizationName"
    /// <summary>
    /// Information from the planning phase of the contracting process. This includes information related to the process of deciding what to contract for, when and how.
    /// <see href="http://purl.org/onto-ocds/ocds#planning"></see></summary>
    let planning = _prefix "planning"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#planningPrecedes"></see>
    /// </summary>
    let planningPrecedes = _prefix "planningPrecedes"
    /// <summary>
    /// The rationale for the procurement provided in free text. More detail can be provided in an attached document.
    /// <see href="http://purl.org/onto-ocds/ocds#planningRationale"></see></summary>
    let planningRationale = _prefix "planningRationale"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#planningUrl"></see>
    /// </summary>
    let planningUrl = _prefix "planningUrl"
    /// <summary>
    /// The postal code. For example, 94043.
    /// <see href="http://purl.org/onto-ocds/ocds#postalCode"></see></summary>
    let postalCode = _prefix "postalCode"
    /// <summary>
    /// Specify tendering method against the [method codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#method) as per [GPA definitions](http://www.wto.org/english/docs_e/legal_e/rev-gpr-94_01_e.htm) of Open, Selective, Limited
    /// <see href="http://purl.org/onto-ocds/ocds#procurementMethod"></see></summary>
    let procurementMethod = _prefix "procurementMethod"
    /// <summary>
    /// Rationale of procurement method, especially in the case of Limited tendering.
    /// <see href="http://purl.org/onto-ocds/ocds#procurementMethodRationale"></see></summary>
    let procurementMethodRationale = _prefix "procurementMethodRationale"
    /// <summary>
    /// The entity managing the procurement, which may be different from the buyer who is paying / using the items being procured.
    /// <see href="http://purl.org/onto-ocds/ocds#procuringEntity"></see></summary>
    let procuringEntity = _prefix "procuringEntity"
    /// <summary>
    /// The name of the project that through which this contracting process is funded (if applicable). Some organizations maintain a registry of projects, and the data should use the name by which the project is known in that registry. No translation option is offered for this string, as translated values can be provided in third-party data, linked from the data source above.
    /// <see href="http://purl.org/onto-ocds/ocds#project"></see></summary>
    let project = _prefix "project"
    /// <summary>
    /// An external identifier for the project that this contracting process forms part of, or is funded via (if applicable). Some organizations maintain a registry of projects, and the data should use the identifier from the relevant registry of projects.
    /// <see href="http://purl.org/onto-ocds/ocds#projectID"></see></summary>
    let projectID = _prefix "projectID"
    /// <summary>
    /// The property name that has been changed relative to the place the amendment is. For example if the contract value has changed, then the property under changes within the contract.amendment would be value.amount.
    /// <see href="http://purl.org/onto-ocds/ocds#property"></see></summary>
    let property = _prefix "property"
    /// <summary>
    /// The Organization Identifier for the organization from which the funds in this transaction originate. Expressed following the Organizational Identifier standard - consult the documentation and the codelist.
    /// <see href="http://purl.org/onto-ocds/ocds#providerOrganization"></see></summary>
    let providerOrganization = _prefix "providerOrganization"
    /// <summary>
    /// The number of units required
    /// <see href="http://purl.org/onto-ocds/ocds#quantity"></see></summary>
    let quantity = _prefix "quantity"
    /// <summary>
    /// The Organization Identifier for the organization which receives the funds in this transaction. Expressed following the Organizational Identifier standard - consult the documentation and the codelist.
    /// <see href="http://purl.org/onto-ocds/ocds#receiverOrganization"></see></summary>
    let receiverOrganization = _prefix "receiverOrganization"
    /// <summary>
    /// The region. For example, CA.
    /// <see href="http://purl.org/onto-ocds/ocds#region"></see></summary>
    let region = _prefix "region"
    /// <summary>
    /// The date this information is released, it may well be the same as the parent publishedDate, it must not be later than the publishedDate from the parent package. It is used to determine merge order.
    /// <see href="http://purl.org/onto-ocds/ocds#releaseDate"></see></summary>
    let releaseDate = _prefix "releaseDate"
    /// <summary>
    /// pecifies the default language of the data using either two-digit ISO 639-1, or extended BCP47 language tags. The use of two-letter codes from ISO 639-1 is strongly recommended.
    /// <see href="http://purl.org/onto-ocds/ocds#releaseLanguage"></see></summary>
    let releaseLanguage = _prefix "releaseLanguage"
    /// <summary>
    /// The start date for the period.
    /// <see href="http://purl.org/onto-ocds/ocds#startDate"></see></summary>
    let startDate = _prefix "startDate"
    /// <summary>
    /// The street address. For example, 1600 Amphitheatre Pkwy
    /// <see href="http://purl.org/onto-ocds/ocds#streetAddress"></see></summary>
    let streetAddress = _prefix "streetAddress"
    /// <summary>
    /// pecify the method by which bids must be submitted, in person, written, or electronic auction. Using the [submission method codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#submission-method)
    /// <see href="http://purl.org/onto-ocds/ocds#submissionMethod"></see></summary>
    let submissionMethod = _prefix "submissionMethod"
    /// <summary>
    /// Any detailed or further information on the submission method. This may include the address, e-mail address or online service to which bids should be submitted, and any special requirements to be followed for submissions.
    /// <see href="http://purl.org/onto-ocds/ocds#submissionMethodDetails"></see></summary>
    let submissionMethodDetails = _prefix "submissionMethodDetails"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#submissionMethodElectronicAuction"></see>
    /// </summary>
    let submissionMethodElectronicAuction = _prefix "submissionMethodElectronicAuction"

    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#submissionMethodElectronicSubmission"></see>
    /// </summary>
    let submissionMethodElectronicSubmission =
        _prefix "submissionMethodElectronicSubmission"

    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#submissionMethodInPerson"></see>
    /// </summary>
    let submissionMethodInPerson = _prefix "submissionMethodInPerson"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#submissionMethodWritten"></see>
    /// </summary>
    let submissionMethodWritten = _prefix "submissionMethodWritten"
    /// <summary>
    /// The suppliers awarded this award. If different suppliers have been awarded different items of values, these should be split into separate award blocks.
    /// <see href="http://purl.org/onto-ocds/ocds#suppliers"></see></summary>
    let suppliers = _prefix "suppliers"
    /// <summary>
    /// A value from the [releaseTag codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#release-tag) that identifies the nature of the release being made. Tags may be used to filter release, or, in future, for for advanced validation when certain kinds of releases should contain certain fields.
    /// <see href="http://purl.org/onto-ocds/ocds#tag"></see></summary>
    let tag = _prefix "tag"
    /// <summary>
    /// The telephone number of the contact point/person. This should include the international dialling code.
    /// <see href="http://purl.org/onto-ocds/ocds#telephone"></see></summary>
    let telephone = _prefix "telephone"
    /// <summary>
    /// The activities undertaken in order to enter into a contract.
    /// <see href="http://purl.org/onto-ocds/ocds#tender"></see></summary>
    let tender = _prefix "tender"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#tenderAmendment"></see>
    /// </summary>
    let tenderAmendment = _prefix "tenderAmendment"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#tenderDescription"></see>
    /// </summary>
    let tenderDescription = _prefix "tenderDescription"
    /// <summary>
    /// All documents and attachments related to the tender, including any notices. See the [documentType codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#document-type) for details of potential documents to include.
    /// <see href="http://purl.org/onto-ocds/ocds#tenderDocuments"></see></summary>
    let tenderDocuments = _prefix "tenderDocuments"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#tenderFollows"></see>
    /// </summary>
    let tenderFollows = _prefix "tenderFollows"
    /// <summary>
    /// An identifier for this tender process. This may be the same as the ocid, or may be drawn from an internally held identifier for this tender.
    /// <see href="http://purl.org/onto-ocds/ocds#tenderId"></see></summary>
    let tenderId = _prefix "tenderId"
    /// <summary>
    /// The goods and services to be purchased, broken into line items wherever possible. Items should not be duplicated, but a quantity of 2 specified instead.
    /// <see href="http://purl.org/onto-ocds/ocds#tenderItems"></see></summary>
    let tenderItems = _prefix "tenderItems"
    /// <summary>
    /// List of lots associated with the tender
    /// <see href="http://purl.org/onto-ocds/ocds#tenderLots"></see></summary>
    let tenderLots = _prefix "tenderLots"
    /// <summary>
    /// The period when the tender is open for submissions. The end date is the closing date for tender submissions.
    /// <see href="http://purl.org/onto-ocds/ocds#tenderPeriod"></see></summary>
    let tenderPeriod = _prefix "tenderPeriod"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#tenderPrecedes"></see>
    /// </summary>
    let tenderPrecedes = _prefix "tenderPrecedes"
    /// <summary>
    /// The current status of the tender based on the [tenderStatus codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#tender-status)
    /// <see href="http://purl.org/onto-ocds/ocds#tenderStatus"></see></summary>
    let tenderStatus = _prefix "tenderStatus"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#tenderTitle"></see>
    /// </summary>
    let tenderTitle = _prefix "tenderTitle"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#tenderUrl"></see>
    /// </summary>
    let tenderUrl = _prefix "tenderUrl"
    /// <summary>
    /// The total upper estimated value of the procurement.
    /// <see href="http://purl.org/onto-ocds/ocds#tenderValue"></see></summary>
    let tenderValue = _prefix "tenderValue"
    /// <summary>
    /// All entities who submit a tender.
    /// <see href="http://purl.org/onto-ocds/ocds#tenderers"></see></summary>
    let tenderers = _prefix "tenderers"
    /// <summary>
    /// The value of the transaction.
    /// <see href="http://purl.org/onto-ocds/ocds#transactionAmount"></see></summary>
    let transactionAmount = _prefix "transactionAmount"
    /// <summary>
    /// The date of the transaction
    /// <see href="http://purl.org/onto-ocds/ocds#transactionDate"></see></summary>
    let transactionDate = _prefix "transactionDate"
    /// <summary>
    /// A unique identifier for this transaction. This identifier should be possible to cross-reference against the provided data source. For the budget data package this is the id, for IATI, the transaction reference.
    /// <see href="http://purl.org/onto-ocds/ocds#transactionId"></see></summary>
    let transactionId = _prefix "transactionId"
    /// <summary>
    /// Used to point either to a corresponding Budget Data Package, IATI file, or machine or human-readable source where users can find further information on the budget line item identifiers, or project identifiers, provided here.
    /// <see href="http://purl.org/onto-ocds/ocds#transactionSource"></see></summary>
    let transactionSource = _prefix "transactionSource"
    /// <summary>
    /// A URI pointing directly to a machine-readable record about this spending transaction.
    /// <see href="http://purl.org/onto-ocds/ocds#transactionUri"></see></summary>
    let transactionUri = _prefix "transactionUri"
    /// <summary>
    /// A list of the spending transactions made against this contract
    /// <see href="http://purl.org/onto-ocds/ocds#transactions"></see></summary>
    let transactions = _prefix "transactions"
    /// <summary>
    /// Description of the unit which the good comes in e.g. hours, kilograms. Made up of a unit name, and the value of a single unit.
    /// <see href="http://purl.org/onto-ocds/ocds#unit"></see></summary>
    let unit = _prefix "unit"
    /// <summary>
    /// Name of the unit
    /// <see href="http://purl.org/onto-ocds/ocds#unitName"></see></summary>
    let unitName = _prefix "unitName"
    /// <summary>
    ///   <see href="http://purl.org/onto-ocds/ocds#unitValue"></see>
    /// </summary>
    let unitValue = _prefix "unitValue"
    /// <summary>
    /// Amount as a number.
    /// <see href="http://purl.org/onto-ocds/ocds#valueAmount"></see></summary>
    let valueAmount = _prefix "valueAmount"
